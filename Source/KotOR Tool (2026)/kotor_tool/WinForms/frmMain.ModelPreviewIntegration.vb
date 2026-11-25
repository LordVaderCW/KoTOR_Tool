Imports System
Imports System.IO
Imports System.Windows.Forms

Namespace kotor_tool
    Partial Public Class frmMain
        Private modelPreviewMenu As ContextMenu
        Private previewSelectionTimer As Timer

        Private Sub InitializeModelPreviewComponents()
            If modelPreviewMenu IsNot Nothing Then Return
            modelPreviewMenu = New ContextMenu()
            If components IsNot Nothing Then components.Add(modelPreviewMenu)
            previewSelectionTimer = New Timer(components) With {.Interval = 180}
            AddHandler previewSelectionTimer.Tick, AddressOf PreviewSelectionTick
            AddHandler TreeView.AfterSelect, AddressOf PreviewTreeSelectionChanged
            AddHandler lvResourceBrowser.SelectedIndexChanged, AddressOf PreviewListSelectionChanged
            If lvResourceDetails IsNot Nothing Then AddHandler lvResourceDetails.SelectedIndexChanged, AddressOf PreviewListSelectionChanged
            modelPreviewMenu.MenuItems.Add(New MenuItem("Preview 3D model", AddressOf PreviewModelMenuClick))
            modelPreviewMenu.MenuItems.Add(New MenuItem("Send to 3DS Max (2021)", AddressOf SendModelToMax))
            AddHandler TreeView.MouseUp, AddressOf ShowModelPreviewMenu
            AddHandler lvResourceBrowser.MouseUp, AddressOf ShowModelPreviewMenu
            If lvResourceDetails IsNot Nothing Then AddHandler lvResourceDetails.MouseUp, AddressOf ShowModelPreviewMenu
        End Sub


        Private modelPreviewBusy As Boolean
        Private modelPreviewNode As KotorTreeNode
        Private activeModelPreview As frmModelPreview
        Private pendingPreviewNode As KotorTreeNode
        Private previewSelectionVersion As Integer

        Private Sub QueueSelectedModel(ByVal node As KotorTreeNode)
            If activeModelPreview Is Nothing OrElse activeModelPreview.IsDisposed Then Return
            previewSelectionVersion += 1
            previewSelectionTimer.Stop()
            pendingPreviewNode = Nothing
            If node Is Nothing OrElse Not String.Equals(node.ResTypeStr, "mdl", StringComparison.OrdinalIgnoreCase) Then
                activeModelPreview.CancelLoading()
                Return
            End If
            pendingPreviewNode = node
            previewSelectionTimer.Start()
        End Sub

        Private Sub PreviewTreeSelectionChanged(ByVal sender As Object, ByVal e As TreeViewEventArgs)
            If TreeView.Focused Then QueueSelectedModel(TryCast(e.Node, KotorTreeNode))
        End Sub

        Private Sub PreviewListSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim list As ListView = CType(sender, ListView)
            If Not list.Focused Then Return
            Dim node As KotorTreeNode = Nothing
            If list.SelectedItems.Count = 1 Then node = TryCast(list.SelectedItems(0).Tag, KotorTreeNode)
            QueueSelectedModel(node)
        End Sub

        Private Sub PreviewSelectionTick(ByVal sender As Object, ByVal e As EventArgs)
            If modelPreviewBusy Then Return
            previewSelectionTimer.Stop()
            Dim node As KotorTreeNode = pendingPreviewNode
            pendingPreviewNode = Nothing
            If node IsNot Nothing AndAlso activeModelPreview IsNot Nothing AndAlso Not activeModelPreview.IsDisposed Then PreviewModel(node, True)
        End Sub

        Private Sub ModelPreviewClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            previewSelectionVersion += 1
            previewSelectionTimer.Stop()
            pendingPreviewNode = Nothing
            If Object.ReferenceEquals(activeModelPreview, sender) Then activeModelPreview = Nothing
        End Sub

        Private Sub InitialiseModelPreviewMenu()
            InitializeModelPreviewComponents()
        End Sub

        Private Sub PreviewModelMenuClick(ByVal sender As Object, ByVal e As EventArgs)
            PreviewModel(modelPreviewNode)
        End Sub

        Private Sub ShowModelPreviewMenu(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Right OrElse modelPreviewBusy Then Return
            Dim source As Control = CType(sender, Control)
            Dim node As KotorTreeNode = Nothing
            If TypeOf source Is TreeView Then
                node = TryCast(CType(source, TreeView).GetNodeAt(e.Location), KotorTreeNode)
                If node IsNot Nothing Then CType(source, TreeView).SelectedNode = node
            Else
                Dim item As ListViewItem = CType(source, ListView).GetItemAt(e.X, e.Y)
                If item IsNot Nothing Then node = TryCast(item.Tag, KotorTreeNode)
            End If
            If node Is Nothing OrElse Not String.Equals(node.ResTypeStr, "mdl", StringComparison.OrdinalIgnoreCase) Then Return
            modelPreviewNode = node
            modelPreviewMenu.Show(source, e.Location)
        End Sub

        Private Sub PreviewModel(ByVal node As KotorTreeNode, Optional ByVal followSelection As Boolean = False)
            If modelPreviewBusy OrElse node Is Nothing Then Return
            Dim tag As String = TryCast(node.Tag, String)
            If tag <> "BIFF_Res" AndAlso tag <> "ERF_Res" AndAlso tag <> "RIM_Res" Then Return
            Dim directory As String = Path.Combine(Path.GetTempPath(), "KotorToolPreview", Guid.NewGuid().ToString("N"))
            Dim window As frmModelPreview = Nothing
            If Not followSelection Then
                previewSelectionTimer.Stop()
                pendingPreviewNode = Nothing
                previewSelectionVersion += 1
            End If
            Dim requestVersion As Integer = previewSelectionVersion
            Try
                modelPreviewBusy = True
                UseWaitCursor = True
                If activeModelPreview IsNot Nothing AndAlso Not activeModelPreview.IsDisposed Then activeModelPreview.ShowLoading(node.ResRef)
                Dim game As Integer = NodeTreeRootIndex(node)
                If game < 0 OrElse game > 1 Then Throw New InvalidDataException("The selected model has no game context.")
                Dim manager As New clsPluginManager()
                manager.LoadPlugins()
                Dim plugin As clsPluginDefinition = manager.FindPluginForResource("mdl", "decompile")
                If plugin Is Nothing Then Throw New InvalidOperationException("Install and enable the MDLOps plugin to preview models. Double-click opens the existing model extraction dialog.")
                IO.Directory.CreateDirectory(directory)
                Dim model As Byte() = ReadPreviewResource(node, node.ResRef, 2002, True)
                Dim mdx As Byte() = ReadPreviewResource(node, node.ResRef, 3008, False)
                If model Is Nothing OrElse mdx Is Nothing Then Throw New InvalidDataException("The model or its companion MDX is missing from the selected archive/game.")
                ' Fixed staging names prevent archive resource names from becoming filesystem paths.
                Dim input As String = Path.Combine(directory, "model.mdl")
                Dim ascii As String = Path.Combine(directory, "model-ascii.mdl")
                File.WriteAllBytes(input, model)
                File.WriteAllBytes(Path.Combine(directory, "model.mdx"), mdx)
                Dim result As clsPluginExecutionResult = manager.ExecutePlugin(plugin, input, ascii, game + 1, "model.mdl", "model", "mdl", "decompile", "")
                If result Is Nothing Then Throw New InvalidOperationException("MDLOps returned no result.")
                If result.TimedOut Then Throw New InvalidOperationException("MDLOps timed out while preparing the preview.")
                If Not result.Success Then Throw New InvalidOperationException("MDLOps preview conversion failed: " & result.ErrorMessage)
                If Not File.Exists(ascii) Then Throw New InvalidDataException("MDLOps did not produce an ASCII model.")
                If IsDisposed OrElse Disposing OrElse requestVersion <> previewSelectionVersion Then Return
                Dim gltf As String = ModelPreview.AsciiModel.Convert(ascii, Function(name As String) PreviewTexture(node, game, directory, name))
                File.WriteAllText(Path.Combine(directory, "model.gltf"), gltf)
                For Each asset As String In IO.Directory.GetFiles(Path.Combine(Application.StartupPath, "ModelPreview"))
                    File.Copy(asset, Path.Combine(directory, Path.GetFileName(asset)), True)
                Next
                If activeModelPreview IsNot Nothing AndAlso Not activeModelPreview.IsDisposed Then
                    activeModelPreview.ReplaceModel(directory, node.ResRef)
                    window = activeModelPreview
                    If Not followSelection Then
                        If window.WindowState = FormWindowState.Minimized Then window.WindowState = FormWindowState.Normal
                        window.Activate()
                    End If
                ElseIf Not followSelection Then
                    window = New frmModelPreview(directory, node.ResRef)
                    activeModelPreview = window
                    AddHandler window.FormClosed, AddressOf ModelPreviewClosed
                    window.Show(Me)
                End If
            Catch ex As System.Exception
                If Not IsDisposed AndAlso requestVersion = previewSelectionVersion Then
                    If activeModelPreview IsNot Nothing AndAlso Not activeModelPreview.IsDisposed Then
                        activeModelPreview.ShowLoadError(ex.Message)
                    ElseIf Not followSelection Then
                        MessageBox.Show(Me, ex.Message, "Model preview", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Finally
                If Not IsDisposed Then UseWaitCursor = False
                modelPreviewBusy = False
                If window Is Nothing AndAlso IO.Directory.Exists(directory) Then
                    Try
                        IO.Directory.Delete(directory, True)
                    Catch ex As IOException
                    Catch ex As UnauthorizedAccessException
                    End Try
                End If
            End Try
        End Sub

        Private Function ReadPreviewResource(ByVal selected As KotorTreeNode, ByVal name As String, ByVal resourceType As Integer, ByVal exact As Boolean) As Byte()
            If exact Then
                Select Case CStr(selected.Tag)
                    Case "BIFF_Res" : Return GetBIFFResource(selected.FilePath, selected.LocalResID).data
                    Case "ERF_Res" : Return GetERFResource(selected.FilePath, selected)
                    Case "RIM_Res" : Return GetRIMResource(selected.FilePath, selected)
                End Select
            End If
            ' Search all resource-type groups within the same archive before the game-wide KEY.
            Dim container As TreeNode = selected.Parent
            If container IsNot Nothing AndAlso TypeOf container Is KotorTreeNode AndAlso
                Not String.Equals(CType(container, KotorTreeNode).FilePath, selected.FilePath, StringComparison.OrdinalIgnoreCase) Then container = container.Parent
            If container IsNot Nothing Then
                Dim found As KotorTreeNode = FindPreviewSibling(container, selected.FilePath, name, frmMain.GetRsrcTypeForID(resourceType))
                If found Is Nothing AndAlso container.Parent IsNot Nothing Then found = FindPreviewSibling(container.Parent, selected.FilePath, name, frmMain.GetRsrcTypeForID(resourceType))
                If found IsNot Nothing Then Return ReadPreviewResource(found, name, resourceType, True)
            End If
            Return frmMain.GetBIFFResourceData(NodeTreeRootIndex(selected), name, resourceType)
        End Function

        Private Function FindPreviewSibling(ByVal parent As TreeNode, ByVal archive As String, ByVal name As String, ByVal extension As String) As KotorTreeNode
            For Each child As TreeNode In parent.Nodes
                Dim resource As KotorTreeNode = TryCast(child, KotorTreeNode)
                If resource IsNot Nothing AndAlso String.Equals(resource.FilePath, archive, StringComparison.OrdinalIgnoreCase) AndAlso
                    String.Equals(resource.ResRef, name, StringComparison.OrdinalIgnoreCase) AndAlso String.Equals(resource.ResTypeStr, extension, StringComparison.OrdinalIgnoreCase) Then Return resource
                Dim found As KotorTreeNode = FindPreviewSibling(child, archive, name, extension)
                If found IsNot Nothing Then Return found
            Next
            Return Nothing
        End Function

        Private Function PreviewTexture(ByVal node As KotorTreeNode, ByVal game As Integer, ByVal directory As String, ByVal name As String) As Byte()
            Dim data As Byte() = ReadPreviewResource(node, name, 3007, False)
            If data Is Nothing Then data = TryGetTextureDataFromCommonPacks(game, name)
            If data Is Nothing Then Return Nothing
            Dim output As String = Path.Combine(directory, name & ".png")
            clsImageExtraction.ExportTPC(data, output, "PNG")
            Return File.ReadAllBytes(output)
        End Function
    End Class
End Namespace
