Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace kotor_tool
    Partial Public Class frmMain
        Private Sub PopulateDialogueTree(ByVal root As KotorTreeNode)
            Dim previousCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Me.TreeView.BeginUpdate()
            Try
                Dim result As KotorTreeNode = DialogueTree.Build(root.FilePath, Me.NodeTreeRootIndex(root))
                root.Nodes.Clear()
                While result.Nodes.Count > 0
                    Dim child As TreeNode = result.Nodes(0)
                    child.Remove()
                    root.Nodes.Add(child)
                End While
            Finally
                Me.TreeView.EndUpdate()
                Cursor.Current = previousCursor
            End Try
        End Sub
    End Class

    ' A browsing index, not an engine override resolver. Every archive version stays visible.
    Friend NotInheritable Class DialogueTree
        Private Const DialogueType As Short = 2029

        Friend Shared Function CreateRoot(ByVal gamePath As String) As KotorTreeNode
            Dim root As New KotorTreeNode("Dialogue") With {.Tag = "Dialogue_Root", .FilePath = gamePath}
            root.Nodes.Add(New KotorTreeNode("") With {.Tag = "dummy"})
            Return root
        End Function

        Friend Shared Function Build(ByVal gamePath As String, ByVal gameIndex As Integer) As KotorTreeNode
            Dim root As New KotorTreeNode("Dialogue") With {.Tag = "Dialogue_Root"}
            Dim keyPath As String = Path.Combine(gamePath, "chitin.key")
            Try
                Using stream As FileStream = File.OpenRead(keyPath), reader As New BinaryReader(stream)
                    stream.Position = 8
                    Dim bifCount As Integer = reader.ReadInt32()
                    Dim keyCount As Integer = reader.ReadInt32()
                    Dim bifOffset As Integer = reader.ReadInt32()
                    Dim keyOffset As Integer = reader.ReadInt32()
                    ValidateTable(stream, bifOffset, bifCount, 12)
                    ValidateTable(stream, keyOffset, keyCount, 22)
                    Dim archives As New List(Of BIFFEntry)()
                    For i As Integer = 0 To bifCount - 1
                        archives.Add(New BIFFEntry(i, stream, bifOffset + 12 * i))
                    Next
                    For i As Integer = 0 To keyCount - 1
                        Dim entry As New KeyEntry(i, stream, keyOffset + 22 * i)
                        If entry.ResourceType <> DialogueType Then Continue For
                        Dim archiveIndex As Integer = entry.ResID >> 20
                        If archiveIndex < 0 OrElse archiveIndex >= archives.Count Then Throw New InvalidDataException("Invalid BIF index.")
                        Dim source As String = Path.Combine(gamePath, archives(archiveIndex).filename)
                        Dim leaf As New KotorTreeNode(entry, source) With {.Tag = "BIFF_Res", .ContainingFileType = "BIF", .KotorVerIndex = gameIndex}
                        AddLeaf(Folder(root, "Shared & Companions"), leaf, Path.GetFileName(source))
                    Next
                End Using
            Catch ex As System.Exception
                AddError(root, keyPath, ex)
            End Try

            For Each directoryName As String In New String() {"modules", "rims"}
                Dim directoryPath As String = Path.Combine(gamePath, directoryName)
                If Not Directory.Exists(directoryPath) Then Continue For
                Try
                    Dim paths As String() = Directory.GetFiles(directoryPath)
                    Array.Sort(paths, StringComparer.OrdinalIgnoreCase)
                    For Each source As String In paths
                        Dim extension As String = Path.GetExtension(source).ToLowerInvariant()
                        If extension <> ".rim" AndAlso extension <> ".erf" AndAlso extension <> ".mod" Then Continue For
                        Try
                            AddArchive(root, source, gameIndex, extension)
                        Catch ex As System.Exception
                            AddError(root, source, ex)
                        End Try
                    Next
                Catch ex As System.Exception
                    AddError(root, directoryPath, ex)
                End Try
            Next

            Dim overridePath As String = Path.Combine(gamePath, "Override")
            If Directory.Exists(overridePath) Then
                Try
                    For Each source As String In Directory.GetFiles(overridePath, "*.dlg")
                        Dim leaf As New KotorTreeNode(New KeyEntry(Path.GetFileNameWithoutExtension(source), DialogueType, 0), source) With {
                            .Tag = "Dialogue_File", .ContainingFileType = "Override", .KotorVerIndex = gameIndex}
                        AddLeaf(Folder(root, "Override"), leaf, "Override")
                    Next
                Catch ex As System.Exception
                    AddError(root, overridePath, ex)
                End Try
            End If
            SortChildren(root)
            If root.Nodes.Count = 0 Then root.Nodes.Add(New KotorTreeNode("No dialogues found") With {.Tag = "Dialogue_Group"})
            Return root
        End Function

        Private Shared Sub ValidateTable(ByVal stream As Stream, ByVal offset As Integer, ByVal count As Integer, ByVal size As Integer)
            If offset < 0 OrElse count < 0 OrElse CLng(offset) + CLng(count) * size > stream.Length Then
                Throw New InvalidDataException("Archive table is outside the file.")
            End If
        End Sub

        Private Shared Sub AddArchive(ByVal root As KotorTreeNode, ByVal source As String, ByVal gameIndex As Integer, ByVal extension As String)
            Dim leaves As New List(Of KotorTreeNode)()
            Using stream As FileStream = File.OpenRead(source), reader As New BinaryReader(stream)
                stream.Position = If(extension = ".rim", 12, 16)
                Dim count As Integer = reader.ReadInt32()
                If extension <> ".rim" Then stream.Position += 4
                Dim offset As Integer = reader.ReadInt32()
                ValidateTable(stream, offset, count, If(extension = ".rim", 32, 24))
                If extension = ".rim" Then
                    Dim archive As New clsRIM(File.ReadAllBytes(source))
                    For i As Integer = 0 To archive.EntryCount - 1
                        Dim entry As RIMKeyEntry = CType(archive.KeyEntryList(i), RIMKeyEntry)
                        If entry._ResType = DialogueType Then leaves.Add(New KotorTreeNode(entry, source) With {.ContainingFileType = "rim", .RIMorERFindex = i, .KotorVerIndex = gameIndex})
                    Next
                Else
                    Dim resourceOffset As Integer = reader.ReadInt32()
                    ValidateTable(stream, resourceOffset, count, 8)
                    Dim archive As New clsERF(stream)
                    For i As Integer = 0 To archive.EntryCount - 1
                        Dim entry As ERFKeyEntry = CType(archive.KeyEntryList(i), ERFKeyEntry)
                        If entry._ResType = DialogueType Then leaves.Add(New KotorTreeNode(entry, source) With {.ContainingFileType = "ERF", .RIMorERFindex = i, .KotorVerIndex = gameIndex})
                    Next
                End If
            End Using
            If leaves.Count = 0 Then Return
            Dim moduleCode As String = Path.GetFileNameWithoutExtension(source)
            moduleCode = Regex.Replace(moduleCode, "(_dlg|_s)$", "", RegexOptions.IgnoreCase)
            Dim lookup As String = moduleCode
            If gameIndex = 0 Then
                Dim match As Match = Regex.Match(moduleCode, "(m[0-9]{2}[a-z]{2})$", RegexOptions.IgnoreCase)
                If match.Success Then lookup = match.Groups(1).Value
            End If
            Dim location As String = Nothing
            Dim level As String = Nothing
            MapModuleMetadata.GetLevel(lookup & "_", gameIndex, location, level)
            If location = "Unidentified levels" Then
                location = "Other Modules"
                level = moduleCode
            Else
                If gameIndex = 1 AndAlso lookup.Length = 6 Then
                    Dim planet As String = Nothing
                    Select Case lookup.Substring(3).ToLowerInvariant()
                        Case "tel" : planet = "Telos"
                        Case "ond" : planet = "Onderon"
                        Case "dxn" : planet = "Dxun"
                        Case "nar" : planet = "Nar Shaddaa"
                        Case "nih" : planet = "Ravager"
                    End Select
                    If planet IsNot Nothing Then
                        If location <> planet Then level = (location & " - " & level).TrimEnd(" "c, "-"c)
                        location = planet
                    End If
                End If
                level = If(String.IsNullOrEmpty(level), moduleCode, level & " (" & moduleCode & ")")
            End If
            Dim area As KotorTreeNode = Folder(Folder(root, location), level)
            For Each leaf As KotorTreeNode In leaves
                AddLeaf(area, leaf, Path.GetFileName(source))
            Next
        End Sub

        Private Shared Function Folder(ByVal parent As KotorTreeNode, ByVal title As String) As KotorTreeNode
            For Each node As KotorTreeNode In parent.Nodes
                If node.Text = title Then Return node
            Next
            Dim result As New KotorTreeNode(title) With {.Tag = "Dialogue_Group"}
            parent.Nodes.Add(result)
            Return result
        End Function

        Private Shared Sub AddLeaf(ByVal parent As KotorTreeNode, ByVal leaf As KotorTreeNode, ByVal sourceName As String)
            leaf.Text = leaf.Filename & " [" & sourceName & "]"
            leaf.ToolTipText = leaf.FilePath
            parent.Nodes.Add(leaf)
        End Sub

        Private Shared Sub AddError(ByVal root As KotorTreeNode, ByVal source As String, ByVal ex As System.Exception)
            Folder(root, "Unavailable sources").Nodes.Add(New KotorTreeNode(Path.GetFileName(source) & ": " & ex.Message) With {.Tag = "Dialogue_Group", .ToolTipText = source})
        End Sub

        Private Shared Sub SortChildren(ByVal parent As KotorTreeNode)
            Dim children As New List(Of KotorTreeNode)()
            For Each child As KotorTreeNode In parent.Nodes
                SortChildren(child)
                children.Add(child)
            Next
            children.Sort(Function(a, b) StringComparer.OrdinalIgnoreCase.Compare(a.Text, b.Text))
            parent.Nodes.Clear()
            parent.Nodes.AddRange(children.ToArray())
        End Sub
    End Class
End Namespace
