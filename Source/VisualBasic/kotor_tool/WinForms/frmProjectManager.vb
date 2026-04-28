Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200006A RID: 106
	Public Partial Class frmProjectManager
		Inherits frmParent

		' Token: 0x06000D28 RID: 3368 RVA: 0x00285B8C File Offset: 0x00284B8C
		Public Sub New()
			AddHandler MyBase.Closing, AddressOf Me.frmProjectManager_Closing
			AddHandler MyBase.Load, AddressOf Me.frmProjectManager_Load
			Me.InitialBrowsePath = "c:\"
			Me.BuildMode = "debug"
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000D29 RID: 3369 RVA: 0x00285BE4 File Offset: 0x00284BE4
		Public Sub New(parentForm As frmMain)
			Me.New()
			Me.MyParentForm = parentForm
		End Sub

        ' Token: 0x06000DC2 RID: 3522 RVA: 0x002884BC File Offset: 0x002874BC
        Private Sub frmProjectManager_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.AskIfSaveProject()
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x06000DC3 RID: 3523 RVA: 0x002884D8 File Offset: 0x002874D8
        Private Sub TreeView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim point As Point = New Point(e.X, e.Y)
            Dim point2 As Point = point
            Me.LastClickedTVNode = Me.TreeView.GetNodeAt(point2)
            Me.TreeView.SelectedNode = Me.LastClickedTVNode
            If e.Button = MouseButtons.Right Then
                Dim tag As Object = Me.LastClickedTVNode.Tag
                If ObjectType.ObjTst(tag, "projectroot", False) = 0 Then
                    Me.tvcmProjectRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "overrideroot", False) = 0 Then
                    Me.tvcmiOverrideRoot_RemoveAll.Enabled = Me.Project.OverrideFiles.Count > 0
                    Me.tvcmOverrideRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "overridechild", False) = 0 Then
                    Me.tvcmOverrideChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "moduleroot", False) = 0 Then
                    Me.tvcmiModulesRoot_RemoveAllModules.Enabled = Me.Project.Modules.Count > 0
                    Me.tvcmModulesRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "moduleparent", False) = 0 Then
                    Me.tvcmiModulesParent_RemoveAll.Enabled = Me.Project.GetModuleFiles(Me.LastClickedTVNode.Text).Count > 0
                    Me.tvcmModulesParent.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "modulechild", False) = 0 Then
                    Me.tvcmModulesChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "lipsmoduleroot", False) = 0 Then
                    Me.tvcmiLipsModulesRoot_RemoveAllModules.Enabled = Me.Project.LipsModules.Count > 0
                    Me.tvcmLipsModulesRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "lipsmoduleparent", False) = 0 Then
                    Me.tvcmiLipsModulesParent_RemoveAll.Enabled = Me.Project.GetLipsModuleFiles(Me.LastClickedTVNode.Text).Count > 0
                    Me.tvcmLipsModulesParent.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "lipsmodulechild", False) = 0 Then
                    Me.tvcmLipsModulesChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "streamwavesroot", False) = 0 Then
                    Me.tvcmiStreamWavesRoot_RemoveAllFiles.Enabled = Me.Project.StreamWavesFiles.Count > 0
                    Me.tvcmiStreamWavesRoot_RemoveAllModules.Enabled = Me.Project.StreamWavesModules.Count > 0
                    Me.tvcmiStreamWavesRoot_RemoveEverything.Enabled = Me.Project.StreamWavesFiles.Count > 0 OrElse Me.Project.StreamWavesModules.Count > 0
                    Me.tvcmStreamWavesRoot.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "streamwavesmoduleparent", False) = 0 Then
                    Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Enabled = Me.Project.GetStreamWavesModuleFiles(Me.LastClickedTVNode.Text).Count > 0
                    Me.tvcmStreamWavesModulesParent.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "streamwavesmodulechild", False) = 0 Then
                    Me.tvcmStreamWavesModulesChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                ElseIf ObjectType.ObjTst(tag, "streamwavesfilechild", False) = 0 Then
                    Me.tvcmStreamWavesFileChild.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
                End If
            End If
        End Sub

        ' Token: 0x06000DC4 RID: 3524 RVA: 0x00288928 File Offset: 0x00287928
        Private Sub TreeView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim projectFileItemTreeNode As ProjectFileItemTreeNode = CType(Me.TreeView.SelectedNode, ProjectFileItemTreeNode)
            If ObjectType.ObjTst(projectFileItemTreeNode.Tag, "overridechild", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "modulechild", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "streamwavesfilechild", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "streamwavesmodulechild", False) = 0 Then
                Dim text As String = Path.GetExtension(projectFileItemTreeNode.FilePath).ToLower()
                If StringType.StrCmp(text, ".nss", False) = 0 OrElse StringType.StrCmp(text, ".txt", False) = 0 Then
                    Dim settings As Options = UserSettings.GetSettings()
                    If settings.bProjMgrUseExternTxtEditor Then
                        'New Process() With { .StartInfo = { .FileName = settings.ProjMgrTxtEditorPath + " ", .Arguments = projectFileItemTreeNode.FilePath } }.Start()
                        Dim process As Process = New Process()
                        process.StartInfo.FileName = settings.ProjMgrTxtEditorPath
                        process.StartInfo.Arguments = """" & projectFileItemTreeNode.FilePath & """"
                        process.Start()
                    Else
                        Dim fileStream As FileStream = New FileStream(projectFileItemTreeNode.FilePath, FileMode.Open)
                        Dim frmTextEditor As frmTextEditor = New frmTextEditor(projectFileItemTreeNode.Filename, False, "")
                        Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
                        Dim array As Byte() = New Byte(CInt((fileStream.Length - 1L)) + 1 - 1) {}
                        fileStream.Read(array, 0, CInt(fileStream.Length))
                        frmTextEditor.tbGeneric.Text = asciiencoding.GetString(array)
                        frmTextEditor.tbGeneric.SelectionLength = 0
                        fileStream.Close()
                        frmTextEditor.Show()
                    End If
                ElseIf StringType.StrCmp(text, ".utc", False) = 0 OrElse StringType.StrCmp(text, ".utd", False) = 0 OrElse StringType.StrCmp(text, ".uti", False) = 0 OrElse StringType.StrCmp(text, ".utm", False) = 0 OrElse StringType.StrCmp(text, ".utp", False) = 0 OrElse StringType.StrCmp(text, ".utt", False) = 0 Then
                    Me.MyParentForm.OpenGFFFileInEditor(projectFileItemTreeNode.FilePath, -1)
                ElseIf StringType.StrCmp(text, ".dlg", False) = 0 Then
                    Dim settings2 As Options = UserSettings.GetSettings()
                    If settings2.bProjMgrUseExternDLGEditor Then
                        '#New Process() With { .StartInfo = { .FileName = settings2.ProjMgrDLGEditorPath + " ", .Arguments = projectFileItemTreeNode.FilePath } }.Start()
                        Dim process2 As Process = New Process()
                        process2.StartInfo.FileName = settings2.ProjMgrDLGEditorPath
                        process2.StartInfo.Arguments = """" & projectFileItemTreeNode.FilePath & """"
                        process2.Start()
                    Else
                        Dim fileStream2 As FileStream = New FileStream(projectFileItemTreeNode.FilePath, FileMode.Open)
                        Dim frmDialogEditor As frmDialogEditor = New frmDialogEditor(fileStream2, Me.KotorVersionIndex)
                        frmDialogEditor.Show()
                    End If
                End If
            End If
        End Sub

        ' Token: 0x06000DC5 RID: 3525 RVA: 0x00288BA0 File Offset: 0x00287BA0
        Private Sub TreeView_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim treeView As TreeView = Me.TreeView
            Dim treeView2 As Control = Me.TreeView
            Dim point As Point = New Point(e.X, e.Y)
            Dim projectFileItemTreeNode As ProjectFileItemTreeNode = CType(treeView.GetNodeAt(treeView2.PointToClient(point)), ProjectFileItemTreeNode)
            Dim fullPath As String = projectFileItemTreeNode.FullPath
            Dim array As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Dim tag As Object = projectFileItemTreeNode.Tag
            If ObjectType.ObjTst(tag, "moduleparent", False) = 0 Then
                Dim hashtable As Hashtable = CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
                Dim num As Integer = 0
                Dim num2 As Integer = array.Length - 1
                For i As Integer = num To num2
                    If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                        Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                    ElseIf Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.AddModuleFile(projectFileItemTreeNode.Text, array(i))
                        Me.ProjectMgr.SaveProject()
                    End If
                Next
            ElseIf ObjectType.ObjTst(tag, "lipsmoduleparent", False) = 0 Then
                Dim hashtable As Hashtable = CType(Me.Project.LipsModules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
                Dim num3 As Integer = 0
                Dim num4 As Integer = array.Length - 1
                For i As Integer = num3 To num4
                    If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                        Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                    ElseIf Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.AddLipsModuleFile(projectFileItemTreeNode.Text, array(i))
                        Me.ProjectMgr.SaveProject()
                    End If
                Next
            ElseIf ObjectType.ObjTst(tag, "streamwavesmoduleparent", False) = 0 Then
                Dim hashtable As Hashtable = CType(Me.Project.StreamWavesModules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
                Dim num5 As Integer = 0
                Dim num6 As Integer = array.Length - 1
                For i As Integer = num5 To num6
                    If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                        Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                    ElseIf Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.AddStreamWavesModuleFile(projectFileItemTreeNode.Text, array(i))
                        Me.ProjectMgr.SaveProject()
                    End If
                Next
            ElseIf ObjectType.ObjTst(tag, "overrideroot", False) = 0 Then
                Dim hashtable As Hashtable = Me.Project.OverrideFilesHashTable
                Dim num7 As Integer = 0
                Dim num8 As Integer = array.Length - 1
                For i As Integer = num7 To num8
                    If Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.OverrideFiles.Add(array(i))
                    End If
                Next
                Me.ProjectMgr.SaveProject()
            ElseIf ObjectType.ObjTst(tag, "streamwavesroot", False) = 0 Then
                Dim hashtable As Hashtable = Me.Project.StreamWavesFilesHashTable
                Dim num9 As Integer = 0
                Dim num10 As Integer = array.Length - 1
                For i As Integer = num9 To num10
                    If Not hashtable.ContainsKey(array(i)) Then
                        Me.Project.StreamWavesFiles.Add(array(i))
                    End If
                Next
                Me.ProjectMgr.SaveProject()
            End If
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DC6 RID: 3526 RVA: 0x00288F1C File Offset: 0x00287F1C
        Private Sub TreeView_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim treeView As TreeView = Me.TreeView
                Dim treeView2 As Control = Me.TreeView
                Dim point As Point = New Point(e.X, e.Y)
                Dim projectFileItemTreeNode As ProjectFileItemTreeNode = CType(treeView.GetNodeAt(treeView2.PointToClient(point)), ProjectFileItemTreeNode)
                If projectFileItemTreeNode IsNot Nothing Then
                    If ObjectType.ObjTst(projectFileItemTreeNode.Tag, "overrideroot", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "moduleparent", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "lipsmoduleparent", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "streamwavesroot", False) = 0 OrElse ObjectType.ObjTst(projectFileItemTreeNode.Tag, "streamwavesmoduleparent", False) = 0 Then
                        e.Effect = DragDropEffects.All
                        Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Match: ", projectFileItemTreeNode.Tag), " "), DateAndTime.Now))
                    Else
                        e.Effect = DragDropEffects.None
                        Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("No match: ", projectFileItemTreeNode.Tag), " "), DateAndTime.Now))
                    End If
                End If
            End If
        End Sub

        ' Token: 0x06000DC7 RID: 3527 RVA: 0x00289048 File Offset: 0x00288048
        Private Sub tvcmiProperties_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.EditProjectProperties()
        End Sub

        ' Token: 0x06000DC8 RID: 3528 RVA: 0x00289050 File Offset: 0x00288050
        Private Sub tvcmiOverrideRoot_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Override folder", "all", True, True))
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim overrideFilesHashTable As Hashtable = Me.Project.OverrideFilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Not overrideFilesHashTable.ContainsKey(array(i)) Then
                    Me.Project.OverrideFiles.Add(array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DC9 RID: 3529 RVA: 0x0028911C File Offset: 0x0028811C
        Private Sub tvcmiOverrideChild_Exclude_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveOverrideFile(filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DCA RID: 3530 RVA: 0x00289180 File Offset: 0x00288180
        Private Sub tvcmiOverrideRoot_RemoveAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to exclude all of the files from Override?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllOverrideFiles()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DCB RID: 3531 RVA: 0x002891B8 File Offset: 0x002881B8
        Private Sub tvcmiModulesRoot_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter name for new module"
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                Me.Project.AddModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()))
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
                Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
            End If
        End Sub

        ' Token: 0x06000DCC RID: 3532 RVA: 0x0028923C File Offset: 0x0028823C
        Private Sub tvcmModulesRoot_RemoveAllModules_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to remove all of the Packages from the Project?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.ProjectMgr.SaveProject()
                Me.Project.RemoveAllModules()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DCD RID: 3533 RVA: 0x00289274 File Offset: 0x00288274
        Private Sub tvcmiModulesParent_RemoveSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to remove the module '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveModule(Me.LastClickedTVNode.Text.Trim())
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DCE RID: 3534 RVA: 0x002892FC File Offset: 0x002882FC
        Private Sub tvcmiModulesParent_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", True, True))
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim filesHashTable As Hashtable = CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                    Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                ElseIf Not filesHashTable.ContainsKey(array(i)) Then
                    Me.Project.AddModuleFile(Me.LastClickedTVNode.Text, array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DCF RID: 3535 RVA: 0x00289424 File Offset: 0x00288424
        Private Sub tvcmiModulesParent_RenameSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter new name for package"
            frmPromptForString.tbValue.Text = Me.LastClickedTVNode.Text
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).ModuleName = frmPromptForString.tbValue.Text.Trim()
                Me.LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim()
            End If
        End Sub

        ' Token: 0x06000DD0 RID: 3536 RVA: 0x002894C4 File Offset: 0x002884C4
        Private Sub tvcmiModulesParent_RemoveAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to exclude all of the files from '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton3, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllModuleFiles(Me.LastClickedTVNode.Text)
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DD1 RID: 3537 RVA: 0x00289548 File Offset: 0x00288548
        Private Sub tvcmiModulesParent_Properties_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmPackageTypeSelector As frmPackageTypeSelector = New frmPackageTypeSelector(CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).PackageType)
            If frmPackageTypeSelector.ShowDialog(Me) = DialogResult.OK Then
                CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).PackageType = frmPackageTypeSelector.PackageType
            End If
        End Sub

        ' Token: 0x06000DD2 RID: 3538 RVA: 0x002895CC File Offset: 0x002885CC
        Private Sub tvcmiModulesChild_Exclude_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim text As String = Me.LastClickedTVNode.Parent.Text
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveModuleFile(text, filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DD3 RID: 3539 RVA: 0x00289640 File Offset: 0x00288640
        Private Sub tvcmiLipsModulesRoot_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter name for new module"
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                Me.Project.AddLipsModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()))
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
                Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
            End If
        End Sub

        ' Token: 0x06000DD4 RID: 3540 RVA: 0x002896C4 File Offset: 0x002886C4
        Private Sub tvcmLipsModulesRoot_RemoveAllModules_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to remove all of the Modules from the Project?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllLipsModules()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DD5 RID: 3541 RVA: 0x002896FC File Offset: 0x002886FC
        Private Sub tvcmiLipsModulesParent_RemoveSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to remove the module '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveLipsModule(Me.LastClickedTVNode.Text.Trim())
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DD6 RID: 3542 RVA: 0x00289784 File Offset: 0x00288784
        Private Sub tvcmiLipsModulesParent_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", True, True))
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim filesHashTable As Hashtable = CType(Me.Project.Modules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                    Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                ElseIf Not filesHashTable.ContainsKey(array(i)) Then
                    Me.Project.AddLipsModuleFile(Me.LastClickedTVNode.Text, array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DD7 RID: 3543 RVA: 0x002898AC File Offset: 0x002888AC
        Private Sub tvcmiLipsModulesParent_RenameSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter new name for module"
            frmPromptForString.tbValue.Text = Me.LastClickedTVNode.Text
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                CType(Me.Project.LipsModules(Me.Project.GetLipsModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).ModuleName = frmPromptForString.tbValue.Text.Trim()
                Me.LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim()
            End If
        End Sub

        ' Token: 0x06000DD8 RID: 3544 RVA: 0x0028994C File Offset: 0x0028894C
        Private Sub tvcmiLipsModulesParent_RemoveAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to exclude all of the files from '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton3, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllLipsModuleFiles(Me.LastClickedTVNode.Text)
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DD9 RID: 3545 RVA: 0x002899D0 File Offset: 0x002889D0
        Private Sub tvcmiLipsModulesChild_Exclude_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim text As String = Me.LastClickedTVNode.Parent.Text
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveLipsModuleFile(text, filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DDA RID: 3546 RVA: 0x00289A44 File Offset: 0x00288A44
        Private Sub tvcmiStreamWavesRoot_AddFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Override folder", "all", True, True))
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim streamWavesFilesHashTable As Hashtable = Me.Project.StreamWavesFilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Not streamWavesFilesHashTable.ContainsKey(array(i)) Then
                    Me.Project.StreamWavesFiles.Add(array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DDB RID: 3547 RVA: 0x00289B10 File Offset: 0x00288B10
        Private Sub tvcmiStreamWavesRoot_AddModule_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter name for new module"
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                Me.Project.AddStreamWavesModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()))
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
                Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
            End If
        End Sub

        ' Token: 0x06000DDC RID: 3548 RVA: 0x00289B94 File Offset: 0x00288B94
        Private Sub tvcmiStreamWavesRoot_RemoveAllFiles_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to exclude all of the files?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton3, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllStreamWavesFiles()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DDD RID: 3549 RVA: 0x00289BCC File Offset: 0x00288BCC
        Private Sub tvcmiStreamWavesRoot_RemoveAllModules_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to remove all of the StreamWaves Modules from the Project?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllStreamWavesModules()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DDE RID: 3550 RVA: 0x00289C04 File Offset: 0x00288C04
        Private Sub tvcmiStreamWavesRoot_RemoveEverything_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to remove everything (StreamWaves Modules and files) from the Project?" & vbLf & "(No files will be deleted from disk)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllStreamWavesModules()
                Me.Project.RemoveAllStreamWavesFiles()
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DDF RID: 3551 RVA: 0x00289C44 File Offset: 0x00288C44
        Private Sub tvcmiStreamWavesModuleParent_AddFiles_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", Me.InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", True, True))
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            If objectValue.[GetType]() Is GetType(String) Then
                Return
            End If
            Dim array As String() = CType(objectValue, String())
            Dim filesHashTable As Hashtable = CType(Me.Project.StreamWavesModules(Me.Project.GetModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).FilesHashTable
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1
            For i As Integer = num To num2
                If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                    Interaction.MsgBox("The file '" + array(i) + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long")
                ElseIf Not filesHashTable.ContainsKey(array(i)) Then
                    Me.Project.AddStreamWavesModuleFile(Me.LastClickedTVNode.Text, array(i))
                End If
            Next
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DE0 RID: 3552 RVA: 0x00289D6C File Offset: 0x00288D6C
        Private Sub tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to exclude all of the files from '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton3, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveAllStreamWavesModuleFiles(Me.LastClickedTVNode.Text)
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DE1 RID: 3553 RVA: 0x00289DF0 File Offset: 0x00288DF0
        Private Sub tvcmiStreamWavesModuleParent_RenameSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.lblMsg.Text = "Enter new name for module"
            frmPromptForString.tbValue.Text = Me.LastClickedTVNode.Text
            If frmPromptForString.ShowDialog() = DialogResult.OK Then
                CType(Me.Project.StreamWavesModules(Me.Project.GetStreamWavesModuleIndex(Me.LastClickedTVNode.Text)), ModuleFileEntry).ModuleName = frmPromptForString.tbValue.Text.Trim()
                Me.LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim()
            End If
        End Sub

        ' Token: 0x06000DE2 RID: 3554 RVA: 0x00289E90 File Offset: 0x00288E90
        Private Sub tvcmiStreamWavesModulesParent_RemoveSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox(String.Concat(New String() {"Are you sure you want to remove the module '", Me.LastClickedTVNode.Text, "'?", vbLf, "(No files will be deleted from disk)"}), MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Warning") = MsgBoxResult.Ok Then
                Me.Project.RemoveStreamWavesModule(Me.LastClickedTVNode.Text.Trim())
                Me.ProjectMgr.SaveProject()
                Me.RefreshTreeView()
            End If
        End Sub

        ' Token: 0x06000DE3 RID: 3555 RVA: 0x00289F18 File Offset: 0x00288F18
        Private Sub tvcmiStreamWavesModulesChild_ExcludeSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim text As String = Me.LastClickedTVNode.Parent.Text
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveStreamWavesModuleFile(text, filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DE4 RID: 3556 RVA: 0x00289F8C File Offset: 0x00288F8C
        Private Sub tvcmiStreamWavesFileChild_ExcludeSelf_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fullPath As String = Me.LastClickedTVNode.FullPath
            Dim text As String = Me.LastClickedTVNode.Parent.Text
            Dim filePath As String = CType(Me.LastClickedTVNode, ProjectFileItemTreeNode).FilePath
            Me.Project.RemoveStreamWavesFile(filePath)
            Me.ProjectMgr.SaveProject()
            Me.RefreshTreeView()
            Me.OpenTreeViewToPath(fullPath, Me.TreeView.Nodes(0), 1)
        End Sub

        ' Token: 0x06000DE5 RID: 3557 RVA: 0x0028A000 File Offset: 0x00289000
        Private Sub miNewPoject_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AskIfSaveProject()
            Dim frmProjectManagerProperties As frmProjectManagerProperties = New frmProjectManagerProperties()
            If frmProjectManagerProperties.ShowDialog(Me) = DialogResult.OK Then
                Me.InitialBrowsePath = "C:\"
                Me.ProjectFilePath = frmProjectManagerProperties.tbProjectPath.Text.Trim()
                Me.ProjectMgr = New clsProjectManager(Me.ProjectFilePath, frmProjectManagerProperties.tbProjectName.Text.Trim())
                Me.Project = Me.ProjectMgr.Project
                Me.Project.DebugFilePath = frmProjectManagerProperties.tbReleasePath.Text
                Me.Project.ReleaseFilePath = frmProjectManagerProperties.tbReleasePath.Text.Trim()
                If frmProjectManagerProperties.rbKotor1.Checked Then
                    Me.Project.KotorVersionIndex = 0
                End If
                If frmProjectManagerProperties.rbKotor2.Checked Then
                    Me.Project.KotorVersionIndex = 1
                End If
                If Not Me.Project.DebugFilePath.EndsWith("\") Then
                    Dim clsProject As clsProject = Me.Project
                    clsProject.DebugFilePath += "\"
                End If
                If Not Me.Project.ReleaseFilePath.EndsWith("\") Then
                    Dim clsProject As clsProject = Me.Project
                    clsProject.ReleaseFilePath += "\"
                End If
                Me.EnableMenus()
                Me.BuildTreeRoots()
                Me.RefreshTreeView()
                Me.Text = "Project Manager - " + Path.GetFileName(Me.ProjectMgr.ProjectFilePath)
            End If
        End Sub

        ' Token: 0x06000DE6 RID: 3558 RVA: 0x0028A178 File Offset: 0x00289178
        Private Sub miOpenProject_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AskIfSaveProject()
            Dim text As String = Me.BrowseForProjectFile()
            If File.Exists(text) Then
                Dim clsProjectManager As clsProjectManager = New clsProjectManager(text)
                If clsProjectManager.Project IsNot Nothing Then
                    Me.ProjectMgr = clsProjectManager
                    Me.Project = Me.ProjectMgr.Project
                    Me.BuildTreeRoots()
                    Me.RefreshTreeView()
                    Me.Text = "Project Manager - " + Path.GetFileName(Me.ProjectMgr.ProjectFilePath)
                    Me.miProjectProperties.Enabled = True
                    If Not Me.Project.DebugFilePath.EndsWith("\") Then
                        Dim clsProject As clsProject = Me.Project
                        clsProject.DebugFilePath += "\"
                    End If
                    If Not Me.Project.ReleaseFilePath.EndsWith("\") Then
                        Dim clsProject As clsProject = Me.Project
                        clsProject.ReleaseFilePath += "\"
                    End If
                    Me.EnableMenus()
                End If
            End If
        End Sub

        ' Token: 0x06000DE7 RID: 3559 RVA: 0x0028A270 File Offset: 0x00289270
        Private Sub miSaveProject_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.Project IsNot Nothing Then
                Me.ProjectMgr.SaveProject()
            End If
        End Sub

        ' Token: 0x06000DE8 RID: 3560 RVA: 0x0028A288 File Offset: 0x00289288
        Private Sub miProjectProperties_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.EditProjectProperties()
        End Sub

        ' Token: 0x06000DE9 RID: 3561 RVA: 0x0028A290 File Offset: 0x00289290
        Private Sub miExploreDebugFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
            'New Process() With { .StartInfo = { .FileName = "explorer.exe ", .Arguments = Me.Project.DebugFilePath } }.Start()
            Dim process As Process = New Process()
            process.StartInfo.FileName = "explorer.exe"
            process.StartInfo.Arguments = """" & Me.Project.DebugFilePath & """"
            process.Start()
        End Sub

        ' Token: 0x06000DEA RID: 3562 RVA: 0x0028A2D0 File Offset: 0x002892D0
        Private Sub miExploreReleaseFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
            'New Process() With { .StartInfo = { .FileName = "explorer.exe ", .Arguments = Me.Project.ReleaseFilePath } }.Start()
            Dim process As Process = New Process()
            process.StartInfo.FileName = "explorer.exe"
            process.StartInfo.Arguments = """" & Me.Project.ReleaseFilePath & """"
            process.Start()
        End Sub

        ' Token: 0x06000DEB RID: 3563 RVA: 0x0028A310 File Offset: 0x00289310
        Private Sub miDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.miDebug.Checked = True
            Me.miRelease.Checked = False
            Me.BuildMode = "debug"
        End Sub

        ' Token: 0x06000DEC RID: 3564 RVA: 0x0028A338 File Offset: 0x00289338
        Private Sub miRelease_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.miDebug.Checked = False
            Me.miRelease.Checked = True
            Me.BuildMode = "build"
        End Sub

        ' Token: 0x06000DED RID: 3565 RVA: 0x0028A360 File Offset: 0x00289360
        Private Sub miBuildProject_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
            Dim utilWindowRelativePositioner As utilWindowRelativePositioner = New utilWindowRelativePositioner(Me, frmProgressMeter)
            Me.WorkingPath = Path.Combine(Me.Project.DebugFilePath, "working")
            Dim text As String
            If StringType.StrCmp(Me.BuildMode, "debug", False) = 0 Then
                text = Me.Project.DebugFilePath
            Else
                text = Me.Project.ReleaseFilePath
            End If
            frmProgressMeter.Location = utilWindowRelativePositioner.getConcentric()
            frmProgressMeter.Show()
            If Me.Project.OverrideFiles.Count > 0 Then
                Me.EnsureDirectoryExists(text + "Override\")
                frmProgressMeter.message = "Copying Override files"
                frmProgressMeter.stepAmount = 100 / Me.Project.OverrideFiles.Count
                Try
                    For Each obj As Object In Me.Project.OverrideFiles
                        Dim text2 As String = StringType.FromObject(obj)
                        If Not text2.ToLower().EndsWith("nss") Then
                            frmProgressMeter.status = "Copying " + Path.GetFileName(text2)
                            File.Copy(text2, text + "override\" + Path.GetFileName(text2), True)
                        Else
                            frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(text2)
                            Dim text3 As String = Nothing
                            Try
                                text3 = Me.CompileNSS(text2)
                            Catch ex As System.Exception
                                If Interaction.MsgBox(String.Concat(New String() {"Override Script ", text2, " failed to compile.", vbLf, "Error message:", vbLf, ex.Message, vbLf, "Do you wish to continue compiling scripts?"}), MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "Script compile failure") = MsgBoxResult.No Then
                                    frmProgressMeter.Close()
                                    Return
                                End If
                            End Try
                            If StringType.StrCmp(text3, "", False) <> 0 Then
                                File.Copy(text3, text + "override\" + Path.GetFileName(text3), True)
                                frmProgressMeter.stepUp()
                            End If
                        End If
                        frmProgressMeter.stepUp()
                    Next
                Finally
                    Dim enumerator As IEnumerator = Nothing
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            Dim arrayList As ArrayList = Me.Project.Modules
            If arrayList.Count > 0 Then
                Me.EnsureDirectoryExists(text + "Modules\")
                Me.EnsureDirectoryExists(Me.WorkingPath)
                Try
                    For Each obj2 As Object In arrayList
                        Dim moduleFileEntry As ModuleFileEntry = CType(obj2, ModuleFileEntry)
                        If moduleFileEntry.ModuleFiles.Count > 0 Then
                            frmProgressMeter.progress = 0
                            frmProgressMeter.message = "Compiling Package: " + moduleFileEntry.ModuleName
                            frmProgressMeter.stepAmount = 100 / moduleFileEntry.ModuleFiles.Count
                            Dim array As String() = New String(moduleFileEntry.ModuleFiles.Count - 1 + 1 - 1) {}
                            Dim num As Integer = 0
                            Dim num2 As Integer = moduleFileEntry.ModuleFiles.Count - 1
                            For i As Integer = num To num2
                                If Not moduleFileEntry.ModuleFiles(i).ToString().ToLower().EndsWith("nss") Then
                                    frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles(i)))
                                    array(i) = StringType.FromObject(moduleFileEntry.ModuleFiles(i))
                                    frmProgressMeter.stepUp()
                                Else
                                    frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles(i)))
                                    Dim text3 As String = Me.CompileNSS(StringType.FromObject(moduleFileEntry.ModuleFiles(i)))
                                    If StringType.StrCmp(text3, "", False) = 0 Then
                                        Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Module Script " + moduleFileEntry.ModuleName + ":", moduleFileEntry.ModuleFiles(i)), " failed to compile."), vbLf), "Aborting build"), MsgBoxStyle.Exclamation, "Script compile failure")
                                        Return
                                    End If
                                    array(i) = text3
                                    frmProgressMeter.stepUp()
                                End If
                            Next
                            Dim clsERF As clsERF = New clsERF(String.Concat(New String() {text, "Modules\", moduleFileEntry.ModuleName, ".", moduleFileEntry.PackageType.ToLower()}), moduleFileEntry.PackageType.ToUpper(), Convert.ToUInt32(0), Nothing, array)
                        End If
                    Next
                Finally
                    Dim enumerator2 As IEnumerator = Nothing
                    If TypeOf enumerator2 Is IDisposable Then
                        CType(enumerator2, IDisposable).Dispose()
                    End If
                End Try
            End If
            arrayList = Me.Project.LipsModules
            If arrayList.Count > 0 Then
                Me.EnsureDirectoryExists(text + "Lips\")
                Me.EnsureDirectoryExists(Me.WorkingPath)
                Try
                    For Each obj3 As Object In arrayList
                        Dim moduleFileEntry2 As ModuleFileEntry = CType(obj3, ModuleFileEntry)
                        If moduleFileEntry2.ModuleFiles.Count > 0 Then
                            frmProgressMeter.progress = 0
                            frmProgressMeter.message = "Compiling Module: " + moduleFileEntry2.ModuleName
                            frmProgressMeter.stepAmount = 100 / moduleFileEntry2.ModuleFiles.Count
                            Dim array2 As String() = New String(moduleFileEntry2.ModuleFiles.Count - 1 + 1 - 1) {}
                            Dim num3 As Integer = 0
                            Dim num4 As Integer = moduleFileEntry2.ModuleFiles.Count - 1
                            For j As Integer = num3 To num4
                                If Not moduleFileEntry2.ModuleFiles(j).ToString().ToLower().EndsWith("nss") Then
                                    frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry2.ModuleFiles(j)))
                                    array2(j) = StringType.FromObject(moduleFileEntry2.ModuleFiles(j))
                                    frmProgressMeter.stepUp()
                                Else
                                    frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(StringType.FromObject(moduleFileEntry2.ModuleFiles(j)))
                                    Dim text3 As String = Me.CompileNSS(StringType.FromObject(moduleFileEntry2.ModuleFiles(j)))
                                    If StringType.StrCmp(text3, "", False) = 0 Then
                                        Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Module Script " + moduleFileEntry2.ModuleName + ":", moduleFileEntry2.ModuleFiles(j)), " failed to compile."), vbLf), "Aborting build"), MsgBoxStyle.Exclamation, "Script compile failure")
                                        Return
                                    End If
                                    array2(j) = text3
                                    frmProgressMeter.stepUp()
                                End If
                            Next
                            Dim clsERF2 As clsERF = New clsERF(text + "Lips\" + moduleFileEntry2.ModuleName + ".mod", "MOD", Convert.ToUInt32(0), Nothing, array2)
                        End If
                    Next
                Finally
                    Dim enumerator3 As IEnumerator = Nothing
                    If TypeOf enumerator3 Is IDisposable Then
                        CType(enumerator3, IDisposable).Dispose()
                    End If
                End Try
            End If
            arrayList = Me.Project.StreamWavesModules
            If arrayList.Count > 0 Then
                Me.EnsureDirectoryExists(text + "StreamWaves\")
                Try
                    For Each obj4 As Object In arrayList
                        Dim moduleFileEntry3 As ModuleFileEntry = CType(obj4, ModuleFileEntry)
                        If moduleFileEntry3.ModuleFiles.Count > 0 Then
                            Me.EnsureDirectoryExists(text + "StreamWaves\" + moduleFileEntry3.ModuleName + "\")
                            frmProgressMeter.progress = 0
                            frmProgressMeter.message = "Copying Module: " + moduleFileEntry3.ModuleName
                            frmProgressMeter.stepAmount = 100 / moduleFileEntry3.ModuleFiles.Count
                            Dim num5 As Integer = 0
                            Dim num6 As Integer = moduleFileEntry3.ModuleFiles.Count - 1
                            For k As Integer = num5 To num6
                                frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry3.ModuleFiles(k)))
                                File.Copy(StringType.FromObject(moduleFileEntry3.ModuleFiles(k)), String.Concat(New String() {text, "StreamWaves\", moduleFileEntry3.ModuleName, "\", Path.GetFileName(StringType.FromObject(moduleFileEntry3.ModuleFiles(k)))}), True)
                            Next
                        End If
                    Next
                Finally
                    Dim enumerator4 As IEnumerator = Nothing
                    If TypeOf enumerator4 Is IDisposable Then
                        CType(enumerator4, IDisposable).Dispose()
                    End If
                End Try
            End If
            If Me.Project.StreamWavesFiles.Count > 0 Then
                frmProgressMeter.message = "Copying StreamWaves files"
                frmProgressMeter.stepAmount = 100 / Me.Project.StreamWavesFiles.Count
                Try
                    For Each obj5 As Object In Me.Project.StreamWavesFiles
                        Dim text4 As String = StringType.FromObject(obj5)
                        frmProgressMeter.status = "Copying " + Path.GetFileName(text4)
                        File.Copy(text4, text + "StreamWaves\" + Path.GetFileName(text4), True)
                        frmProgressMeter.stepUp()
                    Next
                Finally
                    Dim enumerator5 As IEnumerator = Nothing
                    If TypeOf enumerator5 Is IDisposable Then
                        CType(enumerator5, IDisposable).Dispose()
                    End If
                End Try
            End If
            frmProgressMeter.Close()
        End Sub

        ' Token: 0x06000DEE RID: 3566 RVA: 0x0028AD3C File Offset: 0x00289D3C
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x06000DEF RID: 3567 RVA: 0x0028AD44 File Offset: 0x00289D44
        Private Sub miCleanDebugPrjFilesOnly_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.CleanProjectFilesFromDir(Me.Project.DebugFilePath)
        End Sub

        ' Token: 0x06000DF0 RID: 3568 RVA: 0x0028AD58 File Offset: 0x00289D58
        Private Sub miCleanReleasePrjFilesOnly_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.CleanProjectFilesFromDir(Me.Project.ReleaseFilePath)
        End Sub

        ' Token: 0x06000DF1 RID: 3569 RVA: 0x0028AD6C File Offset: 0x00289D6C
        Private Sub AskIfSaveProject()
            If Me.Project IsNot Nothing AndAlso Interaction.MsgBox("Save Project before closing?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Me.ProjectMgr.SaveProject()
            End If
        End Sub

        ' Token: 0x06000DF2 RID: 3570 RVA: 0x0028AD94 File Offset: 0x00289D94
        Private Sub EnableMenus()
            Me.miProjectProperties.Enabled = True
            Me.miExploreDebugFolder.Enabled = True
            Me.miExploreReleaseFolder.Enabled = True
            Me.miSaveProject.Enabled = True
            Me.miBuildProject.Enabled = True
            Me.miCleanDebugPrjFilesOnly.Enabled = True
            Me.miCleanReleasePrjFilesOnly.Enabled = True
        End Sub

        ' Token: 0x06000DF3 RID: 3571 RVA: 0x0028ADF8 File Offset: 0x00289DF8
        Private Sub BuildTreeRoots()
            Me.TreeView.Nodes.Clear()
            Me.TreeView.Nodes.AddRange(New ProjectFileItemTreeNode() {New ProjectFileItemTreeNode("Project", New ProjectFileItemTreeNode() {New ProjectFileItemTreeNode("Overrides"), New ProjectFileItemTreeNode("Packages"), New ProjectFileItemTreeNode("Lips Modules"), New ProjectFileItemTreeNode("StreamWaves")})})
            Me.TreeView.Nodes(0).Nodes(0).Tag = "overrideroot"
            Me.TreeView.Nodes(0).Nodes(1).Tag = "moduleroot"
            Me.TreeView.Nodes(0).Nodes(2).Tag = "lipsmoduleroot"
            Me.TreeView.Nodes(0).Nodes(3).Tag = "streamwavesroot"
            Me.TreeView.Nodes(0).Nodes(0).ImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(1).ImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(2).ImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(3).ImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(0).SelectedImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(1).SelectedImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(2).SelectedImageIndex = 2
            Me.TreeView.Nodes(0).Nodes(3).SelectedImageIndex = 2
            Me.TreeView.Nodes(0).Text = "projectroot"
            Me.TreeView.Nodes(0).Expand()
        End Sub

        ' Token: 0x06000DF4 RID: 3572 RVA: 0x0028B050 File Offset: 0x0028A050
        Private Sub RefreshTreeView()
            Me.TreeView.BeginUpdate()
            Me.TreeView.Nodes(0).Nodes(0).Nodes.Clear()
            Me.TreeView.Nodes(0).Nodes(1).Nodes.Clear()
            Me.TreeView.Nodes(0).Nodes(2).Nodes.Clear()
            Me.TreeView.Nodes(0).Nodes(3).Nodes.Clear()
            Me.TreeView.Nodes(0).Text = Me.Project.Name
            Me.TreeView.Nodes(0).Tag = "projectroot"
            Me.TreeView.Nodes(0).ImageIndex = 0
            Me.TreeView.Nodes(0).SelectedImageIndex = Me.TreeView.Nodes(0).ImageIndex
            Me.Project.OverrideFiles.Sort()
            Try
                For Each obj As Object In Me.Project.OverrideFiles
                    Dim text As String = StringType.FromObject(obj)
                    Dim projectFileItemTreeNode As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text))
                    projectFileItemTreeNode.Tag = "overridechild"
                    projectFileItemTreeNode.ImageIndex = 1
                    projectFileItemTreeNode.SelectedImageIndex = projectFileItemTreeNode.ImageIndex
                    projectFileItemTreeNode.FilePath = text
                    Me.TreeView.Nodes(0).Nodes(0).Nodes.Add(projectFileItemTreeNode)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Dim arrayList As ArrayList = Me.Project.Modules
            Try
                For Each obj2 As Object In arrayList
                    Dim moduleFileEntry As ModuleFileEntry = CType(obj2, ModuleFileEntry)
                    Dim projectFileItemTreeNode2 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(moduleFileEntry.ModuleName)
                    projectFileItemTreeNode2.Tag = "moduleparent"
                    projectFileItemTreeNode2.ImageIndex = 2
                    projectFileItemTreeNode2.SelectedImageIndex = projectFileItemTreeNode2.ImageIndex
                    moduleFileEntry.ModuleFiles.Sort()
                    Try
                        For Each obj3 As Object In moduleFileEntry.ModuleFiles
                            Dim text2 As String = StringType.FromObject(obj3)
                            Dim projectFileItemTreeNode3 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text2))
                            projectFileItemTreeNode3.Tag = "modulechild"
                            projectFileItemTreeNode3.ImageIndex = 1
                            projectFileItemTreeNode3.SelectedImageIndex = projectFileItemTreeNode3.ImageIndex
                            projectFileItemTreeNode3.FilePath = text2
                            projectFileItemTreeNode2.Nodes.Add(projectFileItemTreeNode3)
                        Next
                    Finally
                        Dim enumerator3 As IEnumerator = Nothing
                        If TypeOf enumerator3 Is IDisposable Then
                            CType(enumerator3, IDisposable).Dispose()
                        End If
                    End Try
                    Me.TreeView.Nodes(0).Nodes(1).Nodes.Add(projectFileItemTreeNode2)
                Next
            Finally
                Dim enumerator2 As IEnumerator = Nothing
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            arrayList = Me.Project.LipsModules
            Try
                For Each obj4 As Object In arrayList
                    Dim moduleFileEntry2 As ModuleFileEntry = CType(obj4, ModuleFileEntry)
                    Dim projectFileItemTreeNode4 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(moduleFileEntry2.ModuleName)
                    projectFileItemTreeNode4.Tag = "lipsmoduleparent"
                    projectFileItemTreeNode4.ImageIndex = 2
                    projectFileItemTreeNode4.SelectedImageIndex = projectFileItemTreeNode4.ImageIndex
                    moduleFileEntry2.ModuleFiles.Sort()
                    Try
                        For Each obj5 As Object In moduleFileEntry2.ModuleFiles
                            Dim text3 As String = StringType.FromObject(obj5)
                            Dim projectFileItemTreeNode5 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text3))
                            projectFileItemTreeNode5.Tag = "lipsmodulechild"
                            projectFileItemTreeNode5.ImageIndex = 1
                            projectFileItemTreeNode5.SelectedImageIndex = projectFileItemTreeNode5.ImageIndex
                            projectFileItemTreeNode5.FilePath = text3
                            projectFileItemTreeNode4.Nodes.Add(projectFileItemTreeNode5)
                        Next
                    Finally
                        Dim enumerator5 As IEnumerator = Nothing
                        If TypeOf enumerator5 Is IDisposable Then
                            CType(enumerator5, IDisposable).Dispose()
                        End If
                    End Try
                    Me.TreeView.Nodes(0).Nodes(2).Nodes.Add(projectFileItemTreeNode4)
                Next
            Finally
                Dim enumerator4 As IEnumerator = Nothing
                If TypeOf enumerator4 Is IDisposable Then
                    CType(enumerator4, IDisposable).Dispose()
                End If
            End Try
            arrayList = Me.Project.StreamWavesModules
            Try
                For Each obj6 As Object In arrayList
                    Dim moduleFileEntry3 As ModuleFileEntry = CType(obj6, ModuleFileEntry)
                    Dim projectFileItemTreeNode6 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(moduleFileEntry3.ModuleName)
                    projectFileItemTreeNode6.Tag = "streamwavesmoduleparent"
                    projectFileItemTreeNode6.ImageIndex = 2
                    projectFileItemTreeNode6.SelectedImageIndex = projectFileItemTreeNode6.ImageIndex
                    moduleFileEntry3.ModuleFiles.Sort()
                    Try
                        For Each obj7 As Object In moduleFileEntry3.ModuleFiles
                            Dim text4 As String = StringType.FromObject(obj7)
                            Dim projectFileItemTreeNode7 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text4))
                            projectFileItemTreeNode7.Tag = "streamwavesmodulechild"
                            projectFileItemTreeNode7.ImageIndex = 1
                            projectFileItemTreeNode7.SelectedImageIndex = projectFileItemTreeNode7.ImageIndex
                            projectFileItemTreeNode7.FilePath = text4
                            projectFileItemTreeNode6.Nodes.Add(projectFileItemTreeNode7)
                        Next
                    Finally
                        Dim enumerator7 As IEnumerator = Nothing
                        If TypeOf enumerator7 Is IDisposable Then
                            CType(enumerator7, IDisposable).Dispose()
                        End If
                    End Try
                    Me.TreeView.Nodes(0).Nodes(3).Nodes.Add(projectFileItemTreeNode6)
                Next
            Finally
                Dim enumerator6 As IEnumerator = Nothing
                If TypeOf enumerator6 Is IDisposable Then
                    CType(enumerator6, IDisposable).Dispose()
                End If
            End Try
            Me.Project.StreamWavesFiles.Sort()
            Try
                For Each obj8 As Object In Me.Project.StreamWavesFiles
                    Dim text5 As String = StringType.FromObject(obj8)
                    Dim projectFileItemTreeNode8 As ProjectFileItemTreeNode = New ProjectFileItemTreeNode(Path.GetFileName(text5))
                    projectFileItemTreeNode8.Tag = "streamwavesfilechild"
                    projectFileItemTreeNode8.ImageIndex = 1
                    projectFileItemTreeNode8.SelectedImageIndex = projectFileItemTreeNode8.ImageIndex
                    projectFileItemTreeNode8.FilePath = text5
                    Me.TreeView.Nodes(0).Nodes(3).Nodes.Add(projectFileItemTreeNode8)
                Next
            Finally
                Dim enumerator8 As IEnumerator = Nothing
                If TypeOf enumerator8 Is IDisposable Then
                    CType(enumerator8, IDisposable).Dispose()
                End If
            End Try
            Me.TreeView.EndUpdate()
        End Sub

        ' Token: 0x06000DF5 RID: 3573 RVA: 0x0028B750 File Offset: 0x0028A750
        Private Sub EditProjectProperties()
            Dim frmProjectManagerProperties As frmProjectManagerProperties = New frmProjectManagerProperties("edit")
            frmProjectManagerProperties.tbProjectName.Text = Me.Project.Name
            frmProjectManagerProperties.tbProjectPath.Text = Me.ProjectMgr.ProjectFilePath
            frmProjectManagerProperties.tbDebugPath.Text = Me.Project.DebugFilePath
            frmProjectManagerProperties.tbReleasePath.Text = Me.Project.ReleaseFilePath
            frmProjectManagerProperties.rbKotor1.Checked = Me.Project.KotorVersionIndex = 0
            frmProjectManagerProperties.rbKotor2.Checked = Me.Project.KotorVersionIndex = 1
            If frmProjectManagerProperties.ShowDialog(Me) = DialogResult.OK Then
                If StringType.StrCmp(frmProjectManagerProperties.tbProjectName.Text.Trim(), Me.Project.Name, False) <> 0 Then
                    Me.Project.Name = frmProjectManagerProperties.tbProjectName.Text.Trim()
                    Me.TreeView.Nodes(0).Text = frmProjectManagerProperties.tbProjectName.Text.Trim()
                End If
                Me.ProjectMgr.ProjectFilePath = frmProjectManagerProperties.tbProjectPath.Text.Trim()
                Me.Text = "Project Manager - " + Path.GetFileName(frmProjectManagerProperties.tbProjectPath.Text.Trim())
                Me.Project.DebugFilePath = frmProjectManagerProperties.tbDebugPath.Text.Trim()
                Me.Project.ReleaseFilePath = frmProjectManagerProperties.tbReleasePath.Text.Trim()
                If Not Me.Project.DebugFilePath.EndsWith("\") Then
                    Dim clsProject As clsProject = Me.Project
                    clsProject.DebugFilePath += "\"
                End If
                If Not Me.Project.ReleaseFilePath.EndsWith("\") Then
                    Dim clsProject As clsProject = Me.Project
                    clsProject.ReleaseFilePath += "\"
                End If
                If frmProjectManagerProperties.rbKotor1.Checked Then
                    Me.Project.KotorVersionIndex = 0
                End If
                If frmProjectManagerProperties.rbKotor2.Checked Then
                    Me.Project.KotorVersionIndex = 1
                End If
            End If
        End Sub

        ' Token: 0x06000DF6 RID: 3574 RVA: 0x0028B974 File Offset: 0x0028A974
        Public Sub OpenTreeViewToPath(ByVal treepath As String, ByVal currNode As TreeNode, ByVal currLevel As Integer)
            Dim array As String() = Strings.Split(treepath, "\", -1, CompareMethod.Binary)
            If currLevel = array.Length Then
                Return
            End If
            Try
                For Each obj As Object In currNode.Nodes
                    Dim treeNode As TreeNode = CType(obj, TreeNode)
                    If StringType.StrCmp(treeNode.Text, array(currLevel), False) = 0 Then
                        treeNode.Expand()
                        Me.OpenTreeViewToPath(treepath, treeNode, currLevel + 1)
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000DF7 RID: 3575 RVA: 0x0028BA04 File Offset: 0x0028AA04
        Private Function BrowseForProjectFile() As String
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Title = "Select project file..."
            openFileDialog.Filter = "Kotor Tool Project (*.ktp)|*.ktp"
            openFileDialog.CheckFileExists = True
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = False
            openFileDialog.RestoreDirectory = True
            openFileDialog.FileName = "*.ktp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Return openFileDialog.FileName
            End If
            Dim text As String = Nothing
            Return text
        End Function

        ' Token: 0x06000DF8 RID: 3576 RVA: 0x0028BA68 File Offset: 0x0028AA68
        Public Sub EnsureDirectoryExists(ByVal dirPath As Object)
            If Not Directory.Exists(StringType.FromObject(dirPath)) Then
                Directory.CreateDirectory(StringType.FromObject(dirPath))
            End If
        End Sub

        ' Token: 0x06000DF9 RID: 3577 RVA: 0x0028BA84 File Offset: 0x0028AA84
        Private Function CompileNSS(ByVal sourcefilepath As String) As String
            ' The following expression was wrapped in a checked-expression
            Dim text As String = "-g " + Convert.ToString(Me.Project.KotorVersionIndex + 1)
            Dim text2 As String = Me.WorkingPath + "\" + Path.GetFileNameWithoutExtension(sourcefilepath) + ".ncs"
            Me.EnsureDirectoryExists(Me.WorkingPath)
            If File.Exists(text2) Then
                File.Delete(text2)
            End If
            Dim process As Process = New Process()
            process.StartInfo.FileName = frmMain.gRootPath + "nwnnsscomp.exe"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.CreateNoWindow = True
            process.StartInfo.Arguments = String.Concat(New String() {"-c ", text, " -o ", """", text2, """", " ", """", sourcefilepath, """"})
            process.StartInfo.RedirectStandardOutput = True
            process.Start()
            Dim text3 As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit(4000)
            If text3.IndexOf("Error") = -1 Then
                Return text2
            End If
            Throw New frmProjectManager.NSSCompilerException(text3)
        End Function

        ' Token: 0x06000DFA RID: 3578 RVA: 0x0028BBCC File Offset: 0x0028ABCC
        Private Sub CleanProjectFilesFromDir(ByVal dirname As String)
            Try
                For Each obj As Object In Me.Project.OverrideFiles
                    Dim text As String = StringType.FromObject(obj)
                    Try
                        File.Delete(dirname + "override\" + Path.GetFileName(text))
                    Catch ex As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.Project.Modules
                    Dim moduleFileEntry As ModuleFileEntry = CType(obj2, ModuleFileEntry)
                    Try
                        File.Delete(dirname + "modules\" + moduleFileEntry.ModuleName + ".mod")
                    Catch ex2 As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator2 As IEnumerator = Nothing
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj3 As Object In Me.Project.LipsModules
                    Dim moduleFileEntry2 As ModuleFileEntry = CType(obj3, ModuleFileEntry)
                    Try
                        File.Delete(dirname + "lips\" + moduleFileEntry2.ModuleName + ".mod")
                    Catch ex3 As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator3 As IEnumerator = Nothing
                If TypeOf enumerator3 Is IDisposable Then
                    CType(enumerator3, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj4 As Object In Me.Project.StreamWavesModules
                    Dim moduleFileEntry3 As ModuleFileEntry = CType(obj4, ModuleFileEntry)
                    Try
                        For Each obj5 As Object In moduleFileEntry3.ModuleFiles
                            Dim text2 As String = StringType.FromObject(obj5)
                            Try
                                File.Delete(String.Concat(New String() {dirname, "StreamWaves\", moduleFileEntry3.ModuleName, "\", Path.GetFileName(text2)}))
                            Catch ex4 As System.Exception
                            End Try
                        Next
                    Finally
                        Dim enumerator5 As IEnumerator = Nothing
                        If TypeOf enumerator5 Is IDisposable Then
                            CType(enumerator5, IDisposable).Dispose()
                        End If
                    End Try
                    Try
                        Directory.Delete(dirname + "StreamWaves\" + moduleFileEntry3.ModuleName + "\")
                    Catch ex5 As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator4 As IEnumerator = Nothing
                If TypeOf enumerator4 Is IDisposable Then
                    CType(enumerator4, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj6 As Object In Me.Project.StreamWavesFiles
                    Dim text3 As String = StringType.FromObject(obj6)
                    Try
                        File.Delete(dirname + "StreamWaves\" + Path.GetFileName(text3))
                    Catch ex6 As System.Exception
                    End Try
                Next
            Finally
                Dim enumerator6 As IEnumerator = Nothing
                If TypeOf enumerator6 Is IDisposable Then
                    CType(enumerator6, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000DFB RID: 3579 RVA: 0x0028BF24 File Offset: 0x0028AF24
        Private Sub TreeView_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim point As Point = Me.TreeView.PointToClient(Control.MousePosition)
            Dim projectFileItemTreeNode As ProjectFileItemTreeNode = CType(Me.TreeView.GetNodeAt(point), ProjectFileItemTreeNode)
            If projectFileItemTreeNode IsNot Nothing Then
                Me.lblStatus.Text = projectFileItemTreeNode.FilePath
            End If
        End Sub

        ' Token: 0x06000DFC RID: 3580 RVA: 0x0028BF68 File Offset: 0x0028AF68
        Private Sub TreeView_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            Me.lblStatus.Text = ""
        End Sub

        ' Token: 0x06000DFD RID: 3581 RVA: 0x0028BF7C File Offset: 0x0028AF7C
        Private Sub frmProjectManager_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x040006CD RID: 1741
        Private InitialBrowsePath As String

        ' Token: 0x040006CE RID: 1742
        Private ProjectFilePath As String

        ' Token: 0x040006CF RID: 1743
        Private WorkingPath As String

        ' Token: 0x040006D0 RID: 1744
        Private ProjectMgr As clsProjectManager

        ' Token: 0x040006D1 RID: 1745
        Private Project As clsProject

        ' Token: 0x040006D2 RID: 1746
        Private LastClickedTVNode As TreeNode

        ' Token: 0x040006D3 RID: 1747
        Private MyParentForm As frmMain

        ' Token: 0x040006D4 RID: 1748
        Private BuildMode As String

        ' Token: 0x040006D5 RID: 1749
        Private Const ilFileIcon As Integer = 1

        ' Token: 0x040006D6 RID: 1750
        Private Const ilFolderIcon As Integer = 2

        ' Token: 0x0200006B RID: 107
        Private Class NSSCompilerException
            Inherits System.Exception

            ' Token: 0x06000DFE RID: 3582 RVA: 0x0028BF90 File Offset: 0x0028AF90
            Public Sub New(ByVal Message As Object)
                MyBase.New(StringType.FromObject(Message))
            End Sub
        End Class
    End Class
End Namespace
