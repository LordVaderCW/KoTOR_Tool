Namespace kotor_tool
	' Token: 0x0200006A RID: 106
	Public Partial Class frmProjectManager
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000D2A RID: 3370 RVA: 0x00285BF4 File Offset: 0x00284BF4
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000DC1 RID: 3521 RVA: 0x00287484 File Offset: 0x00286484
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmProjectManager))
            Me.TreeView = New Global.System.Windows.Forms.TreeView()
            Me.ilistTree = New Global.System.Windows.Forms.ImageList(Me.components)
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miNewPoject = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenProject = New Global.System.Windows.Forms.MenuItem()
            Me.miSaveProject = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New Global.System.Windows.Forms.MenuItem()
            Me.miProjectProperties = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New Global.System.Windows.Forms.MenuItem()
            Me.miExploreDebugFolder = New Global.System.Windows.Forms.MenuItem()
            Me.miExploreReleaseFolder = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem10 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New Global.System.Windows.Forms.MenuItem()
            Me.miBuildProject = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New Global.System.Windows.Forms.MenuItem()
            Me.miDebug = New Global.System.Windows.Forms.MenuItem()
            Me.miRelease = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem8 = New Global.System.Windows.Forms.MenuItem()
            Me.miCleanDebugPrjFilesOnly = New Global.System.Windows.Forms.MenuItem()
            Me.miCleanReleasePrjFilesOnly = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmOverrideRoot = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiOverrideRoot_Add = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiOverrideRoot_RemoveAll = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmOverrideChild = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiOverrideChild_Exclude = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmModulesRoot = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiModulesRoot_Add = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem11 = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiModulesRoot_RemoveAllModules = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmLipsModulesRoot = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiLipsModulesRoot_Add = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem12 = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiLipsModulesRoot_RemoveAllModules = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmModulesParent = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiModulesParent_Add = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiModulesParent_RemoveAll = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiModulesParent_RenameSelf = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiModulesParent_RemoveSelf = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem16 = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiModulesParent_Properties = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem9 = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmLipsModulesParent = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiLipsModulesParent_Add = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiLipsModulesParent_RemoveAll = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiLipsModulesParent_RenameSelf = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiLipsModulesParent_RemoveSelf = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmModulesChild = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiModulesChild_Exclude = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmLipsModulesChild = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiLipsModulesChild_Exclude = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmProjectRoot = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiProperties = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmStreamWavesRoot = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiStreamWavesRoot_AddFile = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesRoot_AddModule = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem13 = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesRoot_RemoveAllFiles = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesRoot_RemoveAllModules = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesRoot_RemoveEverything = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmStreamWavesModulesParent = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiStreamWavesModuleParent_AddFiles = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem14 = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesModuleParent_RenameSelf = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem15 = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesModulesParent_RemoveSelf = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmStreamWavesModulesChild = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiStreamWavesModulesChild_ExcludeSelf = New Global.System.Windows.Forms.MenuItem()
            Me.tvcmStreamWavesFileChild = New Global.System.Windows.Forms.ContextMenu()
            Me.tvcmiStreamWavesFileChild_ExcludeSelf = New Global.System.Windows.Forms.MenuItem()
            Me.lblStatus = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.TreeView.AllowDrop = True
            Me.TreeView.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TreeView.HideSelection = False
            Me.TreeView.ImageList = Me.ilistTree
            Me.TreeView.Indent = 19
            Dim treeView As Global.System.Windows.Forms.Control = Me.TreeView
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 11)
            treeView.Location = point
            Me.TreeView.Name = "TreeView"
            Me.TreeView.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim treeView2 As Global.System.Windows.Forms.Control = Me.TreeView
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(264, 341)
            treeView2.Size = size
            Me.TreeView.TabIndex = 0
            Dim ilistTree As Global.System.Windows.Forms.ImageList = Me.ilistTree
            size = New Global.System.Drawing.Size(16, 16)
            ilistTree.ImageSize = size
            Me.ilistTree.ImageStream = CType(resourceManager.GetObject("ilistTree.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
            Me.ilistTree.TransparentColor = Global.System.Drawing.Color.Transparent
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem6})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miNewPoject, Me.miOpenProject, Me.miSaveProject, Me.MenuItem4, Me.miProjectProperties, Me.MenuItem7, Me.miExploreDebugFolder, Me.miExploreReleaseFolder, Me.MenuItem10, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            Me.miNewPoject.Index = 0
            Me.miNewPoject.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlN
            Me.miNewPoject.Text = "&New Project..."
            Me.miOpenProject.Index = 1
            Me.miOpenProject.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenProject.Text = "&Open project..."
            Me.miSaveProject.Enabled = False
            Me.miSaveProject.Index = 2
            Me.miSaveProject.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSaveProject.Text = "&Save Project"
            Me.MenuItem4.Index = 3
            Me.MenuItem4.Text = "-"
            Me.miProjectProperties.Enabled = False
            Me.miProjectProperties.Index = 4
            Me.miProjectProperties.Text = "&Project Properties..."
            Me.MenuItem7.Index = 5
            Me.MenuItem7.Text = "-"
            Me.miExploreDebugFolder.Enabled = False
            Me.miExploreDebugFolder.Index = 6
            Me.miExploreDebugFolder.Text = "Open &Debug Folder"
            Me.miExploreReleaseFolder.Enabled = False
            Me.miExploreReleaseFolder.Index = 7
            Me.miExploreReleaseFolder.Text = "Open &Release Folder"
            Me.MenuItem10.Index = 8
            Me.MenuItem10.Text = "-"
            Me.miQuit.Index = 9
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            Me.MenuItem6.Index = 1
            Me.MenuItem6.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miBuildProject, Me.MenuItem3, Me.miDebug, Me.miRelease, Me.MenuItem8, Me.miCleanDebugPrjFilesOnly, Me.miCleanReleasePrjFilesOnly})
            Me.MenuItem6.Text = "&Build"
            Me.miBuildProject.Enabled = False
            Me.miBuildProject.Index = 0
            Me.miBuildProject.Shortcut = Global.System.Windows.Forms.Shortcut.F5
            Me.miBuildProject.Text = "B&uild Project"
            Me.MenuItem3.Index = 1
            Me.MenuItem3.Text = "-"
            Me.miDebug.Checked = True
            Me.miDebug.Index = 2
            Me.miDebug.Text = "&Debug"
            Me.miRelease.Index = 3
            Me.miRelease.Text = "&Release"
            Me.MenuItem8.Index = 4
            Me.MenuItem8.Text = "-"
            Me.miCleanDebugPrjFilesOnly.Enabled = False
            Me.miCleanDebugPrjFilesOnly.Index = 5
            Me.miCleanDebugPrjFilesOnly.Text = "Clean Debug Directory - Project Files Only"
            Me.miCleanReleasePrjFilesOnly.Enabled = False
            Me.miCleanReleasePrjFilesOnly.Index = 6
            Me.miCleanReleasePrjFilesOnly.Text = "Clean Release Directory - Project Files Only"
            Me.tvcmOverrideRoot.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiOverrideRoot_Add, Me.tvcmiOverrideRoot_RemoveAll})
            Me.tvcmiOverrideRoot_Add.Index = 0
            Me.tvcmiOverrideRoot_Add.Text = "Add Files..."
            Me.tvcmiOverrideRoot_RemoveAll.Enabled = False
            Me.tvcmiOverrideRoot_RemoveAll.Index = 1
            Me.tvcmiOverrideRoot_RemoveAll.Text = "Exclude All Files..."
            Me.tvcmOverrideChild.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiOverrideChild_Exclude})
            Me.tvcmiOverrideChild_Exclude.Index = 0
            Me.tvcmiOverrideChild_Exclude.Text = "Exclude file from Project"
            Me.tvcmModulesRoot.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiModulesRoot_Add, Me.MenuItem11, Me.tvcmiModulesRoot_RemoveAllModules})
            Me.tvcmiModulesRoot_Add.Index = 0
            Me.tvcmiModulesRoot_Add.Text = "Add New Package..."
            Me.MenuItem11.Index = 1
            Me.MenuItem11.Text = "-"
            Me.tvcmiModulesRoot_RemoveAllModules.Enabled = False
            Me.tvcmiModulesRoot_RemoveAllModules.Index = 2
            Me.tvcmiModulesRoot_RemoveAllModules.Text = "Remove All Packages..."
            Me.MenuItem5.Index = -1
            Me.MenuItem5.Text = "-"
            Me.tvcmLipsModulesRoot.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiLipsModulesRoot_Add, Me.MenuItem12, Me.tvcmiLipsModulesRoot_RemoveAllModules})
            Me.tvcmiLipsModulesRoot_Add.Index = 0
            Me.tvcmiLipsModulesRoot_Add.Text = "Add New Module..."
            Me.MenuItem12.Index = 1
            Me.MenuItem12.Text = "-"
            Me.tvcmiLipsModulesRoot_RemoveAllModules.Enabled = False
            Me.tvcmiLipsModulesRoot_RemoveAllModules.Index = 2
            Me.tvcmiLipsModulesRoot_RemoveAllModules.Text = "Remove All Modules..."
            Me.tvcmModulesParent.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiModulesParent_Add, Me.tvcmiModulesParent_RemoveAll, Me.tvcmiModulesParent_RenameSelf, Me.tvcmiModulesParent_RemoveSelf, Me.MenuItem16, Me.tvcmiModulesParent_Properties})
            Me.tvcmiModulesParent_Add.Index = 0
            Me.tvcmiModulesParent_Add.Text = "Add Files..."
            Me.tvcmiModulesParent_RemoveAll.Enabled = False
            Me.tvcmiModulesParent_RemoveAll.Index = 1
            Me.tvcmiModulesParent_RemoveAll.Text = "Exclude All Files..."
            Me.tvcmiModulesParent_RenameSelf.Index = 2
            Me.tvcmiModulesParent_RenameSelf.Text = "Rename"
            Me.tvcmiModulesParent_RemoveSelf.Index = 3
            Me.tvcmiModulesParent_RemoveSelf.Text = "Remove Package"
            Me.MenuItem16.Index = 4
            Me.MenuItem16.Text = "-"
            Me.tvcmiModulesParent_Properties.Index = 5
            Me.tvcmiModulesParent_Properties.Text = "Properties"
            Me.MenuItem2.Index = 2
            Me.MenuItem2.Text = "-"
            Me.MenuItem9.Index = 4
            Me.MenuItem9.Text = "-"
            Me.tvcmLipsModulesParent.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiLipsModulesParent_Add, Me.tvcmiLipsModulesParent_RemoveAll, Me.MenuItem2, Me.tvcmiLipsModulesParent_RenameSelf, Me.MenuItem9, Me.tvcmiLipsModulesParent_RemoveSelf})
            Me.tvcmiLipsModulesParent_Add.Index = 0
            Me.tvcmiLipsModulesParent_Add.Text = "Add Files..."
            Me.tvcmiLipsModulesParent_RemoveAll.Enabled = False
            Me.tvcmiLipsModulesParent_RemoveAll.Index = 1
            Me.tvcmiLipsModulesParent_RemoveAll.Text = "Exclude All Files..."
            Me.tvcmiLipsModulesParent_RenameSelf.Index = 3
            Me.tvcmiLipsModulesParent_RenameSelf.Text = "Rename"
            Me.tvcmiLipsModulesParent_RemoveSelf.Index = 5
            Me.tvcmiLipsModulesParent_RemoveSelf.Text = "Remove Module"
            Me.tvcmModulesChild.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiModulesChild_Exclude})
            Me.tvcmiModulesChild_Exclude.Index = 0
            Me.tvcmiModulesChild_Exclude.Text = "Exclude file from Project"
            Me.tvcmLipsModulesChild.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiLipsModulesChild_Exclude})
            Me.tvcmiLipsModulesChild_Exclude.Index = 0
            Me.tvcmiLipsModulesChild_Exclude.Text = "Exclude file from Project"
            Me.tvcmProjectRoot.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiProperties})
            Me.tvcmiProperties.Index = 0
            Me.tvcmiProperties.Text = "Properties"
            Me.tvcmStreamWavesRoot.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiStreamWavesRoot_AddFile, Me.tvcmiStreamWavesRoot_AddModule, Me.MenuItem13, Me.tvcmiStreamWavesRoot_RemoveAllFiles, Me.tvcmiStreamWavesRoot_RemoveAllModules, Me.tvcmiStreamWavesRoot_RemoveEverything})
            Me.tvcmiStreamWavesRoot_AddFile.Index = 0
            Me.tvcmiStreamWavesRoot_AddFile.Text = "Add Files..."
            Me.tvcmiStreamWavesRoot_AddModule.Index = 1
            Me.tvcmiStreamWavesRoot_AddModule.Text = "Add Module..."
            Me.MenuItem13.Index = 2
            Me.MenuItem13.Text = "-"
            Me.tvcmiStreamWavesRoot_RemoveAllFiles.Index = 3
            Me.tvcmiStreamWavesRoot_RemoveAllFiles.Text = "Remove all root-level files..."
            Me.tvcmiStreamWavesRoot_RemoveAllModules.Index = 4
            Me.tvcmiStreamWavesRoot_RemoveAllModules.Text = "Remove All Modules..."
            Me.tvcmiStreamWavesRoot_RemoveEverything.Index = 5
            Me.tvcmiStreamWavesRoot_RemoveEverything.Text = "Remove Everything..."
            Me.tvcmStreamWavesModulesParent.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiStreamWavesModuleParent_AddFiles, Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles, Me.MenuItem14, Me.tvcmiStreamWavesModuleParent_RenameSelf, Me.MenuItem15, Me.tvcmiStreamWavesModulesParent_RemoveSelf})
            Me.tvcmiStreamWavesModuleParent_AddFiles.Index = 0
            Me.tvcmiStreamWavesModuleParent_AddFiles.Text = "Add Files..."
            Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Enabled = False
            Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Index = 1
            Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Text = "Exclude All Files..."
            Me.MenuItem14.Index = 2
            Me.MenuItem14.Text = "-"
            Me.tvcmiStreamWavesModuleParent_RenameSelf.Index = 3
            Me.tvcmiStreamWavesModuleParent_RenameSelf.Text = "Rename"
            Me.MenuItem15.Index = 4
            Me.MenuItem15.Text = "-"
            Me.tvcmiStreamWavesModulesParent_RemoveSelf.Index = 5
            Me.tvcmiStreamWavesModulesParent_RemoveSelf.Text = "Remove Module"
            Me.tvcmStreamWavesModulesChild.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiStreamWavesModulesChild_ExcludeSelf})
            Me.tvcmiStreamWavesModulesChild_ExcludeSelf.Index = 0
            Me.tvcmiStreamWavesModulesChild_ExcludeSelf.Text = "Exclude file from Project"
            Me.tvcmStreamWavesFileChild.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.tvcmiStreamWavesFileChild_ExcludeSelf})
            Me.tvcmiStreamWavesFileChild_ExcludeSelf.Index = 0
            Me.tvcmiStreamWavesFileChild_ExcludeSelf.Text = "Exclude file from Project"
            Me.lblStatus.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lblStatus.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
            Me.lblStatus.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblStatus.FlatStyle = Global.System.Windows.Forms.FlatStyle.System
            Dim lblStatus As Global.System.Windows.Forms.Control = Me.lblStatus
            point = New Global.System.Drawing.Point(12, 360)
            lblStatus.Location = point
            Me.lblStatus.Name = "lblStatus"
            Dim lblStatus2 As Global.System.Windows.Forms.Control = Me.lblStatus
            size = New Global.System.Drawing.Size(264, 32)
            lblStatus2.Size = size
            Me.lblStatus.TabIndex = 1
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(288, 401)
            Me.ClientSize = size
            Me.Controls.Add(Me.lblStatus)
            Me.Controls.Add(Me.TreeView)
            Me.Menu = Me.MainMenu1
            size = New Global.System.Drawing.Size(184, 232)
            Me.MinimumSize = size
            Me.Name = "frmProjectManager"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Project Manager"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040006D7 RID: 1751
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
