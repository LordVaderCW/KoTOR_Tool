Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic

Namespace kotor_tool
    Public NotInheritable Class ModelTreeGroups
        Public Shared Sub Apply(ByVal archive As KotorTreeNode, ByVal gameIndex As Integer)
            If gameIndex <> 0 AndAlso gameIndex <> 1 Then Return
            For Each category As KotorTreeNode In archive.Nodes
                If category.ResType <> 2002 OrElse Not String.Equals(CStr(category.Tag), "NodeCategory", StringComparison.Ordinal) Then Continue For
                Dim groups As New SortedDictionary(Of String, List(Of KotorTreeNode))(StringComparer.OrdinalIgnoreCase)
                For Each leaf As KotorTreeNode In ResourceLeaves(category)
                    If Not String.Equals(CStr(leaf.Tag), "BIFF_Res", StringComparison.Ordinal) OrElse leaf.ResType <> 2002 Then Continue For
                    Dim metadata As ModelMetadataRegistry.Classification = ModelMetadataRegistry.Classify(leaf.ResRef, gameIndex)
                    If metadata.Category = "Maps" Then
                        Dim moduleName As String = MapModuleMetadata.GetModuleName(leaf.ResRef, gameIndex)
                        If moduleName.Length = 0 Then moduleName = "Module name unavailable"
                        leaf.Text = leaf.Filename & " | " & moduleName
                    End If
                    If Not groups.ContainsKey(metadata.Category) Then groups.Add(metadata.Category, New List(Of KotorTreeNode)())
                    groups(metadata.Category).Add(leaf)
                Next
                If groups.Count = 0 Then Continue For
                category.Nodes.Clear()
                For Each group As KeyValuePair(Of String, List(Of KotorTreeNode)) In groups
                    group.Value.Sort(Function(a, b) StringComparer.OrdinalIgnoreCase.Compare(a.ResRef, b.ResRef))
                    Dim folder As New KotorTreeNode(group.Key & " (" & group.Value.Count & ")") With {
                        .Name = "mdl-group:" & group.Key, .Tag = "NodeCategory", .KotorVerIndex = gameIndex,
                        .ToolTipText = "Model naming group. Individual models retain their original archive identity."}
                    If group.Key = "Maps" Then
                        AddMapLevels(folder, group.Value, gameIndex)
                    Else
                        For Each leaf As KotorTreeNode In group.Value
                            folder.Nodes.Add(leaf)
                        Next
                    End If
                    category.Nodes.Add(folder)
                Next
            Next
        End Sub

        Private Shared Sub AddMapLevels(ByVal maps As KotorTreeNode, ByVal leaves As List(Of KotorTreeNode), ByVal gameIndex As Integer)
            Dim locations As New SortedDictionary(Of String, SortedDictionary(Of String, List(Of KotorTreeNode)))(StringComparer.OrdinalIgnoreCase)
            For Each leaf As KotorTreeNode In leaves
                Dim location As String = Nothing
                Dim level As String = Nothing
                MapModuleMetadata.GetLevel(leaf.ResRef, gameIndex, location, level)
                If Not locations.ContainsKey(location) Then locations.Add(location, New SortedDictionary(Of String, List(Of KotorTreeNode))(StringComparer.OrdinalIgnoreCase))
                If Not locations(location).ContainsKey(level) Then locations(location).Add(level, New List(Of KotorTreeNode)())
                locations(location)(level).Add(leaf)
            Next
            For Each location As KeyValuePair(Of String, SortedDictionary(Of String, List(Of KotorTreeNode))) In locations
                Dim count As Integer = 0
                For Each levelLeaves As List(Of KotorTreeNode) In location.Value.Values
                    count += levelLeaves.Count
                Next
                Dim locationFolder As KotorTreeNode = MapFolder(location.Key, location.Key, count, gameIndex)
                For Each level As KeyValuePair(Of String, List(Of KotorTreeNode)) In location.Value
                    Dim target As KotorTreeNode = locationFolder
                    If level.Key.Length > 0 Then
                        target = MapFolder(level.Key, location.Key & "/" & level.Key, level.Value.Count, gameIndex)
                        locationFolder.Nodes.Add(target)
                    End If
                    For Each leaf As KotorTreeNode In level.Value
                        target.Nodes.Add(leaf)
                    Next
                Next
                maps.Nodes.Add(locationFolder)
            Next
        End Sub

        Private Shared Function MapFolder(ByVal title As String, ByVal identity As String, ByVal count As Integer, ByVal gameIndex As Integer) As KotorTreeNode
            Return New KotorTreeNode(title & " (" & count & ")") With {
                .Name = "mdl-group:Maps/" & identity, .Tag = "NodeCategory", .KotorVerIndex = gameIndex,
                .ToolTipText = "Map models grouped by location and level. Extract this group to export its model files."}
        End Function

        Public Shared Function ResourceLeaves(ByVal node As KotorTreeNode) As List(Of KotorTreeNode)
            Dim result As New List(Of KotorTreeNode)()
            CollectLeaves(node, result)
            Return result
        End Function
        Private Shared Sub CollectLeaves(ByVal node As KotorTreeNode, ByVal result As List(Of KotorTreeNode))
            Dim tag As String = TryCast(node.Tag, String)
            If tag = "BIFF_Res" OrElse tag = "RIM_Res" OrElse tag = "ERF_Res" Then
                result.Add(node)
                Return
            End If
            For Each child As KotorTreeNode In node.ResourceChildren()
                CollectLeaves(child, result)
            Next
        End Sub
        Public Shared Function FindArchive(ByVal node As KotorTreeNode) As KotorTreeNode
            Dim current As KotorTreeNode = node.ResourceParent
            While current IsNot Nothing
                Dim tag As String = TryCast(current.Tag, String)
                If tag = "BIFF" OrElse tag = "RIM" OrElse tag = "ERF" Then Return current
                current = current.ResourceParent
            End While
            Return Nothing
        End Function
    End Class
End Namespace
