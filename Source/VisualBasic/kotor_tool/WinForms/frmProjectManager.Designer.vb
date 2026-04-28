Namespace kotor_tool
	' Token: 0x0200006A RID: 106
	Public Partial Class frmProjectManager
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents TreeView As Global.System.Windows.Forms.TreeView
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem7 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmOverrideRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmOverrideChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmModulesRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmModulesParent As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmModulesChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmLipsModulesRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmLipsModulesParent As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmLipsModulesChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmiOverrideRoot_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiOverrideChild_Exclude As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesRoot_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesParent_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesChild_Exclude As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesRoot_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesParent_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesChild_Exclude As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miProjectProperties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miNewPoject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miDebug As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miRelease As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenProject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSaveProject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miBuildProject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem3 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiOverrideRoot_RemoveAll As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesParent_RemoveAll As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesParent_RemoveAll As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesRoot_RemoveAllModules As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesRoot_RemoveAllModules As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesParent_RemoveSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesParent_RemoveSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmProjectRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmiProperties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miExploreReleaseFolder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miExploreDebugFolder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem10 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesParent_RenameSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesParent_RenameSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem9 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem8 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCleanDebugPrjFilesOnly As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCleanReleasePrjFilesOnly As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem11 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem12 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmStreamWavesRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmStreamWavesModulesParent As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmStreamWavesModulesChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmStreamWavesFileChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmiStreamWavesRoot_AddFile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesRoot_AddModule As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem13 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesRoot_RemoveAllFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesRoot_RemoveAllModules As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesRoot_RemoveEverything As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModuleParent_AddFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModuleParent_ExcludeAllFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem14 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModuleParent_RenameSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem15 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModulesParent_RemoveSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModulesChild_ExcludeSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesFileChild_ExcludeSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents ilistTree As Global.System.Windows.Forms.ImageList
        Friend WithEvents lblStatus As Global.System.Windows.Forms.Label
        Friend WithEvents tvcmiModulesParent_Properties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem16 As Global.System.Windows.Forms.MenuItem


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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmProjectManager))
            Me.TreeView = New Global.System.Windows.Forms.TreeView()
            Me.ilistTree = New Global.System.Windows.Forms.ImageList()
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
            Me.TreeView.Location = New Global.System.Drawing.Point(12, 11)
            Me.TreeView.Name = "TreeView"
            Me.TreeView.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.TreeView.Size = New Global.System.Drawing.Size(264, 341)
            Me.TreeView.TabIndex = 0
            Me.ilistTree.ImageSize = New Global.System.Drawing.Size(16, 16)
            Me.ilistTree.ImageStream = CType(resources.GetObject("Me.ilistTree.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
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
            Me.lblStatus.Location = New Global.System.Drawing.Point(12, 360)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New Global.System.Drawing.Size(264, 32)
            Me.lblStatus.TabIndex = 1
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(288, 401)
            Me.Controls.Add(Me.lblStatus)
            Me.Controls.Add(Me.TreeView)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New Global.System.Drawing.Size(184, 232)
            Me.Name = "frmProjectManager"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Project Manager"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.TreeView.DoubleClick, AddressOf Me.TreeView_DoubleClick
            AddHandler Me.TreeView.MouseLeave, AddressOf Me.TreeView_MouseLeave
            AddHandler Me.TreeView.MouseMove, AddressOf Me.TreeView_MouseMove
            AddHandler Me.TreeView.DragOver, AddressOf Me.TreeView_DragOver
            AddHandler Me.TreeView.DragDrop, AddressOf Me.TreeView_DragDrop
            AddHandler Me.TreeView.MouseDown, AddressOf Me.TreeView_MouseDown
            AddHandler Me.tvcmiOverrideRoot_Add.Click, AddressOf Me.tvcmiOverrideRoot_Add_Click
            AddHandler Me.tvcmiOverrideChild_Exclude.Click, AddressOf Me.tvcmiOverrideChild_Exclude_Click
            AddHandler Me.tvcmiModulesRoot_Add.Click, AddressOf Me.tvcmiModulesRoot_Add_Click
            AddHandler Me.tvcmiModulesParent_Add.Click, AddressOf Me.tvcmiModulesParent_Add_Click
            AddHandler Me.tvcmiModulesChild_Exclude.Click, AddressOf Me.tvcmiModulesChild_Exclude_Click
            AddHandler Me.tvcmiLipsModulesRoot_Add.Click, AddressOf Me.tvcmiLipsModulesRoot_Add_Click
            AddHandler Me.tvcmiLipsModulesParent_Add.Click, AddressOf Me.tvcmiLipsModulesParent_Add_Click
            AddHandler Me.tvcmiLipsModulesChild_Exclude.Click, AddressOf Me.tvcmiLipsModulesChild_Exclude_Click
            AddHandler Me.miProjectProperties.Click, AddressOf Me.miProjectProperties_Click
            AddHandler Me.miNewPoject.Click, AddressOf Me.miNewPoject_Click
            AddHandler Me.miDebug.Click, AddressOf Me.miDebug_Click
            AddHandler Me.miRelease.Click, AddressOf Me.miRelease_Click
            AddHandler Me.miOpenProject.Click, AddressOf Me.miOpenProject_Click
            AddHandler Me.miSaveProject.Click, AddressOf Me.miSaveProject_Click
            AddHandler Me.miQuit.Click, AddressOf Me.miQuit_Click
            AddHandler Me.miBuildProject.Click, AddressOf Me.miBuildProject_Click
            AddHandler Me.tvcmiOverrideRoot_RemoveAll.Click, AddressOf Me.tvcmiOverrideRoot_RemoveAll_Click
            AddHandler Me.tvcmiModulesParent_RemoveAll.Click, AddressOf Me.tvcmiModulesParent_RemoveAll_Click
            AddHandler Me.tvcmiLipsModulesParent_RemoveAll.Click, AddressOf Me.tvcmiLipsModulesParent_RemoveAll_Click
            AddHandler Me.tvcmiModulesRoot_RemoveAllModules.Click, AddressOf Me.tvcmModulesRoot_RemoveAllModules_Click
            AddHandler Me.tvcmiLipsModulesRoot_RemoveAllModules.Click, AddressOf Me.tvcmLipsModulesRoot_RemoveAllModules_Click
            AddHandler Me.tvcmiModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiModulesParent_RemoveSelf_Click
            AddHandler Me.tvcmiLipsModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiLipsModulesParent_RemoveSelf_Click
            AddHandler Me.tvcmiProperties.Click, AddressOf Me.tvcmiProperties_Click
            AddHandler Me.miExploreReleaseFolder.Click, AddressOf Me.miExploreReleaseFolder_Click
            AddHandler Me.miExploreDebugFolder.Click, AddressOf Me.miExploreDebugFolder_Click
            AddHandler Me.tvcmiModulesParent_RenameSelf.Click, AddressOf Me.tvcmiModulesParent_RenameSelf_Click
            AddHandler Me.tvcmiLipsModulesParent_RenameSelf.Click, AddressOf Me.tvcmiLipsModulesParent_RenameSelf_Click
            AddHandler Me.miCleanDebugPrjFilesOnly.Click, AddressOf Me.miCleanDebugPrjFilesOnly_Click
            AddHandler Me.miCleanReleasePrjFilesOnly.Click, AddressOf Me.miCleanReleasePrjFilesOnly_Click
            AddHandler Me.tvcmiStreamWavesRoot_AddFile.Click, AddressOf Me.tvcmiStreamWavesRoot_AddFile_Click
            AddHandler Me.tvcmiStreamWavesRoot_AddModule.Click, AddressOf Me.tvcmiStreamWavesRoot_AddModule_Click
            AddHandler Me.tvcmiStreamWavesRoot_RemoveAllFiles.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveAllFiles_Click
            AddHandler Me.tvcmiStreamWavesRoot_RemoveAllModules.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveAllModules_Click
            AddHandler Me.tvcmiStreamWavesRoot_RemoveEverything.Click, AddressOf Me.tvcmiStreamWavesRoot_RemoveEverything_Click
            AddHandler Me.tvcmiStreamWavesModuleParent_AddFiles.Click, AddressOf Me.tvcmiStreamWavesModuleParent_AddFiles_Click
            AddHandler Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Click, AddressOf Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click
            AddHandler Me.tvcmiStreamWavesModuleParent_RenameSelf.Click, AddressOf Me.tvcmiStreamWavesModuleParent_RenameSelf_Click
            AddHandler Me.tvcmiStreamWavesModulesParent_RemoveSelf.Click, AddressOf Me.tvcmiStreamWavesModulesParent_RemoveSelf_Click
            AddHandler Me.tvcmiStreamWavesModulesChild_ExcludeSelf.Click, AddressOf Me.tvcmiStreamWavesModulesChild_ExcludeSelf_Click
            AddHandler Me.tvcmiStreamWavesFileChild_ExcludeSelf.Click, AddressOf Me.tvcmiStreamWavesFileChild_ExcludeSelf_Click
            AddHandler Me.tvcmiModulesParent_Properties.Click, AddressOf Me.tvcmiModulesParent_Properties_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
