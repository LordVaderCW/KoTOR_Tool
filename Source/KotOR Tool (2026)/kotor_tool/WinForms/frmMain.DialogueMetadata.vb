Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace kotor_tool
    Partial Public Class frmMain
        Private Sub DescribeDialogueGroup(ByVal group As KotorTreeNode)
            If group Is Nothing OrElse CStr(group.Tag) <> "Dialogue_Group" Then Return
            Dim gameRoot As KotorTreeNode = Me.NodeTreeRoot(group)
            Dim previousCursor As Cursor = Cursor.Current
            Try
                Cursor.Current = Cursors.WaitCursor
                DialogueMetadata.Enrich(group, gameRoot.FilePath)
            Finally
                Cursor.Current = previousCursor
            End Try
        End Sub
    End Class

    ' Read-only evidence from the selected source version; never changes a GFF or resolves scripts.
    Friend NotInheritable Class DialogueMetadata
        Private ReadOnly textTable As Byte()
        Private ReadOnly textEncoding As Encoding = Encoding.GetEncoding(1252)
        Private ReadOnly notices As New List(Of String)()
        Private ReadOnly owners As New Dictionary(Of String, List(Of String))(StringComparer.OrdinalIgnoreCase)
        Private ReadOnly speakers As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

        Private Sub New(ByVal gamePath As String)
            Try
                textTable = File.ReadAllBytes(Path.Combine(gamePath, "dialog.tlk"))
                If textTable.Length < 20 OrElse Encoding.ASCII.GetString(textTable, 0, 8) <> "TLK V3.0" Then Throw New InvalidDataException("Invalid TLK header")
                Select Case BitConverter.ToInt32(textTable, 8)
                    Case 5 : textEncoding = Encoding.GetEncoding(1250)
                    Case 128 : textEncoding = Encoding.GetEncoding(949)
                    Case 129 : textEncoding = Encoding.GetEncoding(950)
                    Case 130 : textEncoding = Encoding.GetEncoding(936)
                    Case 131 : textEncoding = Encoding.GetEncoding(932)
                End Select
            Catch ex As System.Exception
                textTable = Nothing
                notices.Add("Text lookup unavailable: " & ex.Message)
            End Try
        End Sub

        Friend Shared Sub Enrich(ByVal group As KotorTreeNode, ByVal gamePath As String)
            Dim leaves As New List(Of KotorTreeNode)()
            For Each child As KotorTreeNode In group.Nodes
                If child.ResType = 2029 AndAlso child.Name <> "dialogue-described" Then leaves.Add(child)
            Next
            If leaves.Count = 0 Then Return
            Dim metadata As New DialogueMetadata(gamePath)
            Dim sources As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            For Each leaf As KotorTreeNode In leaves
                If CStr(leaf.Tag) <> "RIM_Res" AndAlso CStr(leaf.Tag) <> "ERF_Res" Then Continue For
                sources.Add(leaf.FilePath)
                Dim code As String = Regex.Replace(Path.GetFileNameWithoutExtension(leaf.FilePath), "(_dlg|_s)$", "", RegexOptions.IgnoreCase)
                For Each suffix As String In New String() {".rim", "_s.rim", ".mod", "_dlg.erf"}
                    Dim sibling As String = Path.Combine(Path.GetDirectoryName(leaf.FilePath), code & suffix)
                    If File.Exists(sibling) Then sources.Add(sibling)
                Next
            Next
            For Each source As String In sources.OrderBy(Function(p) p, StringComparer.OrdinalIgnoreCase)
                Try
                    metadata.ReadOwners(source)
                Catch ex As System.Exception
                    metadata.notices.Add("Template lookup incomplete: " & Path.GetFileName(source) & " (" & ex.Message & ")")
                End Try
            Next
            For Each leaf As KotorTreeNode In leaves
                Try
                    metadata.Describe(leaf)
                Catch ex As System.Exception
                    leaf.Text = leaf.Filename & " | Description unavailable [" & Path.GetFileName(leaf.FilePath) & "]"
                    leaf.ToolTipText = "Metadata could not be read: " & ex.Message & Environment.NewLine & leaf.FilePath
                End Try
                leaf.Name = "dialogue-described"
            Next
        End Sub

        Private Sub ReadOwners(ByVal source As String)
            Using stream As FileStream = File.OpenRead(source), reader As New BinaryReader(stream)
                Dim rim As Boolean = Path.GetExtension(source).Equals(".rim", StringComparison.OrdinalIgnoreCase)
                stream.Position = If(rim, 12, 16)
                Dim count As Integer = reader.ReadInt32()
                If Not rim Then reader.ReadInt32()
                Dim offset As Integer = reader.ReadInt32()
                If count < 0 OrElse offset < 0 OrElse CLng(offset) + CLng(count) * If(rim, 32, 24) > stream.Length Then Throw New InvalidDataException("Invalid template archive table")
            End Using
            If Path.GetExtension(source).Equals(".rim", StringComparison.OrdinalIgnoreCase) Then
                Dim archive As New clsRIM(File.ReadAllBytes(source))
                For i As Integer = 0 To archive.EntryCount - 1
                    Dim entry As RIMKeyEntry = CType(archive.KeyEntryList(i), RIMKeyEntry)
                    If entry._ResType = 2027 OrElse entry._ResType = 2042 OrElse entry._ResType = 2044 Then
                        ReadOwner(archive.GetRIMResource(i), entry._ResourceName, source)
                    End If
                Next
            Else
                Using stream As FileStream = File.OpenRead(source)
                    Dim archive As New clsERF(stream)
                    For i As Integer = 0 To archive.EntryCount - 1
                        Dim entry As ERFKeyEntry = CType(archive.KeyEntryList(i), ERFKeyEntry)
                        If entry._ResType = 2027 OrElse entry._ResType = 2042 OrElse entry._ResType = 2044 Then
                            ReadOwner(archive.getERFResource(i), entry._ResourceName, source)
                        End If
                    Next
                End Using
            End If
        End Sub

        Private Sub ReadOwner(ByVal bytes As Byte(), ByVal resRef As String, ByVal source As String)
            Try
                Dim gff As clsGFF = ParseGff(bytes)
                Dim name As String = (LocalText(gff.GetNodeValue("FirstName")) & " " & LocalText(gff.GetNodeValue("LastName"))).Trim()
                If name.Length = 0 Then name = LocalText(gff.GetNodeValue("LocName"))
                If name.Length = 0 Then name = resRef & " (template)"
                Dim tag As String = Value(gff, "Tag")
                If tag.Length > 0 AndAlso Not speakers.ContainsKey(tag) Then speakers.Add(tag, name)
                Dim conversation As String = Value(gff, "Conversation")
                If conversation.Length = 0 Then Return
                Dim matches As List(Of String) = Nothing
                If Not owners.TryGetValue(conversation, matches) Then
                    matches = New List(Of String)()
                    owners.Add(conversation, matches)
                End If
                Dim evidence As String = name & " [" & resRef & " in " & Path.GetFileName(source) & "]"
                If Not matches.Contains(evidence) Then matches.Add(evidence)
            Catch ex As System.Exception
                notices.Add("Unreadable template: " & resRef & " in " & Path.GetFileName(source))
            End Try
        End Sub

        Private Shared Function Value(ByVal gff As clsGFF, ByVal path As String) As String
            Return Convert.ToString(gff.GetNodeValue(path), Globalization.CultureInfo.InvariantCulture)
        End Function

        Private Shared Function ParseGff(ByVal bytes As Byte()) As clsGFF
            If bytes.Length < 56 Then Throw New InvalidDataException("Truncated GFF header")
            Dim sizes As Integer() = {12, 12, 16, 1, 1, 1}
            For i As Integer = 0 To sizes.Length - 1
                Dim offset As UInteger = BitConverter.ToUInt32(bytes, 8 + i * 8)
                Dim count As UInteger = BitConverter.ToUInt32(bytes, 12 + i * 8)
                If CLng(offset) + CLng(count) * sizes(i) > bytes.Length Then Throw New InvalidDataException("GFF table is outside the resource")
            Next
            Return New clsGFF(bytes, -1, False)
        End Function

        Private Function LocalText(ByVal value As Object) As String
            Dim loc As GFFExoLocString = TryCast(value, GFFExoLocString)
            If loc Is Nothing Then Return String.Empty
            If loc.StringRef >= 0 Then
                If textTable Is Nothing Then Return String.Empty
                Dim entry As Long = 20L + CLng(loc.StringRef) * 40L
                If loc.StringRef >= BitConverter.ToInt32(textTable, 12) OrElse entry + 40 > textTable.Length Then Return String.Empty
                Dim position As Integer = CInt(entry)
                If (BitConverter.ToInt32(textTable, position) And 1) = 0 Then Return String.Empty
                Dim start As Long = CLng(BitConverter.ToInt32(textTable, 16)) + BitConverter.ToInt32(textTable, position + 28)
                Dim length As Integer = BitConverter.ToInt32(textTable, position + 32)
                If start < 0 OrElse length < 0 OrElse start + length > textTable.Length Then Return String.Empty
                Return Clean(textEncoding.GetString(textTable, CInt(start), length))
            End If
            If loc.subStringArr IsNot Nothing Then
                For Each item As Object In loc.subStringArr
                    Dim text As GFFExoLocSubString = TryCast(item, GFFExoLocSubString)
                    If text IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(text.value) Then Return Clean(text.value)
                Next
            End If
            Return String.Empty
        End Function

        Private Shared Function Clean(ByVal text As String) As String
            Return Regex.Replace(If(text, String.Empty), "\s+", " ").Trim()
        End Function

        Private Shared Function Clip(ByVal text As String, ByVal length As Integer) As String
            Return If(text.Length <= length, text, text.Substring(0, length - 3) & "...")
        End Function

        Private Shared Function ReadDialogue(ByVal leaf As KotorTreeNode) As Byte()
            Select Case CStr(leaf.Tag)
                Case "Dialogue_File" : Return File.ReadAllBytes(leaf.FilePath)
                Case "RIM_Res" : Return New clsRIM(File.ReadAllBytes(leaf.FilePath)).GetRIMResource(leaf.RIMorERFindex)
                Case "ERF_Res"
                    Using stream As FileStream = File.OpenRead(leaf.FilePath)
                        Return New clsERF(stream).getERFResource(leaf.RIMorERFindex)
                    End Using
                Case "BIFF_Res"
                    Using stream As FileStream = File.OpenRead(leaf.FilePath)
                        Return New BIFFArchive(stream).getBIFFResource(leaf.LocalResID).data
                    End Using
                Case Else : Throw New InvalidDataException("Unknown dialogue source")
            End Select
        End Function

        Private Sub Describe(ByVal leaf As KotorTreeNode)
            Dim bytes As Byte() = ReadDialogue(leaf)
            If bytes.Length < 56 OrElse Encoding.ASCII.GetString(bytes, 0, 8) <> "DLG V3.2" Then Throw New InvalidDataException("Not a DLG V3.2 resource")
            Dim gff As clsGFF = ParseGff(bytes)
            Dim entries As Integer = gff.GetListItemCount("EntryList")
            Dim replies As Integer = gff.GetListItemCount("ReplyList")
            Dim starts As Integer = gff.GetListItemCount("StartingList")
            Dim details As New List(Of String) From {leaf.Filename, "Structure: " & entries & " NPC entries, " & replies & " player replies, " & starts & " starting links"}
            Dim label As String = String.Empty
            Dim matches As List(Of String) = Nothing
            If owners.TryGetValue(leaf.ResRef, matches) Then
                details.Add("Assigned by nearby templates (not proof of placement): " & String.Join("; ", matches))
                label = String.Join(" / ", matches.Select(Function(m) m.Split("["c)(0).Trim()).Distinct().Take(3))
            End If
            Dim speakerTags As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            Dim quests As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            Dim scripts As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            Dim sample As String = String.Empty
            Dim sampleKind As String = "Text sample"
            ' Starting links may be conditional. Do not claim the first stored entry always plays.
            For i As Integer = 0 To starts - 1
                Dim index As Integer
                If Integer.TryParse(Value(gff, "StartingList(" & i & ").Index"), index) AndAlso index >= 0 AndAlso index < entries Then
                    sample = LocalText(gff.GetNodeValue("EntryList(" & index & ").Text"))
                    If sample.Length > 0 Then
                        sampleKind = "Possible opening"
                        Exit For
                    End If
                End If
            Next
            For Each list As String In New String() {"EntryList", "ReplyList"}
                For i As Integer = 0 To gff.GetListItemCount(list) - 1
                    Dim prefix As String = list & "(" & i & ")."
                    If sample.Length = 0 Then sample = LocalText(gff.GetNodeValue(prefix & "Text"))
                    Dim speaker As String = Value(gff, prefix & "Speaker")
                    If speaker.Length > 0 Then speakerTags.Add(speaker)
                    Dim quest As String = Value(gff, prefix & "Quest")
                    If quest.Length > 0 Then quests.Add(quest)
                    For Each field As String In New String() {"Script", "Script2"}
                        Dim script As String = Value(gff, prefix & field)
                        If script.Length > 0 Then scripts.Add(script)
                    Next
                Next
            Next
            If speakerTags.Count > 0 Then
                Dim names As String() = speakerTags.OrderBy(Function(s) s).Select(Function(s) If(speakers.ContainsKey(s), speakers(s) & " [" & s & "]", s & " (speaker tag)")).ToArray()
                details.Add("Speakers: " & String.Join("; ", names))
                If label.Length = 0 Then label = String.Join(" / ", names.Take(2))
            End If
            Dim kind As String = If(replies > 0, "Player replies", "No player replies")
            If entries = 0 AndAlso replies = 0 Then kind = "No dialogue entries"
            If label.Length = 0 Then label = kind
            details.Add("Summary: " & kind & ". Runtime purpose is not inferred from the filename.")
            If sample.Length > 0 Then details.Add(sampleKind & ": " & Clip(sample, 700))
            If sample.Length = 0 Then details.Add("No resolved text; this may be a silent/scripted dialogue or require unavailable text references.")
            Dim comment As String = Clean(Value(gff, "Comment"))
            If comment.Length > 0 Then details.Add("Author comment: " & Clip(comment, 600))
            If quests.Count > 0 Then details.Add("Journal references: " & String.Join(", ", quests.OrderBy(Function(q) q)))
            For Each field As String In New String() {"EndConversation", "EndConverAbort"}
                Dim script As String = Value(gff, field)
                If script.Length > 0 Then scripts.Add(script)
            Next
            If scripts.Count > 0 Then details.Add("Scripts: " & String.Join(", ", scripts.OrderBy(Function(s) s).Take(12)))
            If gff.VerifyNodeExists("ConversationType") Then
                Dim conversationType As String = Value(gff, "ConversationType")
                details.Add("Conversation type: " & If(conversationType = "0", "Human (0)", If(conversationType = "1", "Computer (1)", "Type " & conversationType)))
            End If
            details.AddRange(notices.Distinct().Take(4))
            details.Add("Source: " & leaf.FilePath)
            leaf.Text = leaf.Filename & " | " & Clip(label, 60) & If(sample.Length > 0, " - """ & Clip(sample, 80) & """", "") & " [" & Path.GetFileName(leaf.FilePath) & "]"
            leaf.ToolTipText = String.Join(Environment.NewLine, details)
        End Sub
    End Class
End Namespace
