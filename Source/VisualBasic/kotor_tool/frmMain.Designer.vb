Namespace kotor_tool
	' Token: 0x02000054 RID: 84
	Public Partial Class frmMain
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600067A RID: 1658 RVA: 0x0024CA38 File Offset: 0x0024BA38
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060006E7 RID: 1767 RVA: 0x0024DCA0 File Offset: 0x0024CCA0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmMain))
            Me.TreeView = New Global.System.Windows.Forms.TreeView()
            Me.btnHexViewer = New Global.System.Windows.Forms.Button()
            Me.btnExtract = New Global.System.Windows.Forms.Button()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.miFile = New Global.System.Windows.Forms.MenuItem()
            Me.miManagePaths = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenGFFFile = New Global.System.Windows.Forms.MenuItem()
            Me.miViewGFFFiles = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenKey = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenRIM = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New Global.System.Windows.Forms.MenuItem()
            Me.miRecentFiles = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New Global.System.Windows.Forms.MenuItem()
            Me.miExtract = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenProjectManager = New Global.System.Windows.Forms.MenuItem()
            Me.miOpen2DAEditor = New Global.System.Windows.Forms.MenuItem()
            Me.miConversationEditor = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenModuleEditor = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenDialogTlkViewer = New Global.System.Windows.Forms.MenuItem()
            Me.miGlobalVariableEditor = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenTextEditor = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenPWKEditor = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenSSFEditor = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenERFBuilder = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem10 = New Global.System.Windows.Forms.MenuItem()
            Me.miRefSearch = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New Global.System.Windows.Forms.MenuItem()
            Me.miCleanWorkingDir = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenWorkingDir = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem8 = New Global.System.Windows.Forms.MenuItem()
            Me.miShowSupportedModEditorMaps = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenMapsFolder = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New Global.System.Windows.Forms.MenuItem()
            Me.miOptions = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.miBasicHelp = New Global.System.Windows.Forms.MenuItem()
            Me.miCheckForUpdates = New Global.System.Windows.Forms.MenuItem()
            Me.miRegisterSoftware = New Global.System.Windows.Forms.MenuItem()
            Me.miAbout = New Global.System.Windows.Forms.MenuItem()
            Me.tvCMenu = New Global.System.Windows.Forms.ContextMenu()
            Me.cmiExtractForModuleEditing = New Global.System.Windows.Forms.MenuItem()
            Me.ToolBar1 = New Global.System.Windows.Forms.ToolBar()
            Me.tbbtn2DAEditor = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbbtnConversationEditor = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbbtnTextEditor = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbbtnERFBuilder = New Global.System.Windows.Forms.ToolBarButton()
            Me.imglstToolBar = New Global.System.Windows.Forms.ImageList(Me.components)
            Me.btnExtractForModuleEditing = New Global.System.Windows.Forms.Button()
            Me.Button4 = New Global.System.Windows.Forms.Button()
            Me.btnCreateMapInfoBFD = New Global.System.Windows.Forms.Button()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.TreeView.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TreeView.ImageIndex = -1
            Dim treeView As Global.System.Windows.Forms.Control = Me.TreeView
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(16, 40)
            treeView.Location = point
            Me.TreeView.Name = "TreeView"
            Me.TreeView.SelectedImageIndex = -1
            Dim treeView2 As Global.System.Windows.Forms.Control = Me.TreeView
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(160, 400)
            treeView2.Size = size
            Me.TreeView.TabIndex = 1
            Me.btnHexViewer.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnHexViewer.BackColor = Global.System.Drawing.SystemColors.Control
            Me.btnHexViewer.Enabled = False
            Dim btnHexViewer As Global.System.Windows.Forms.Control = Me.btnHexViewer
            point = New Global.System.Drawing.Point(200, 176)
            btnHexViewer.Location = point
            Me.btnHexViewer.Name = "btnHexViewer"
            Dim btnHexViewer2 As Global.System.Windows.Forms.Control = Me.btnHexViewer
            size = New Global.System.Drawing.Size(88, 23)
            btnHexViewer2.Size = size
            Me.btnHexViewer.TabIndex = 0
            Me.btnHexViewer.Text = "Hex Viewer"
            Me.btnExtract.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnExtract.BackColor = Global.System.Drawing.SystemColors.Control
            Me.btnExtract.Enabled = False
            Dim btnExtract As Global.System.Windows.Forms.Control = Me.btnExtract
            point = New Global.System.Drawing.Point(200, 48)
            btnExtract.Location = point
            Me.btnExtract.Name = "btnExtract"
            Dim btnExtract2 As Global.System.Windows.Forms.Control = Me.btnExtract
            size = New Global.System.Drawing.Size(88, 56)
            btnExtract2.Size = size
            Me.btnExtract.TabIndex = 1
            Me.btnExtract.Text = "Extract"
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miFile, Me.MenuItem3, Me.MenuItem2})
            Me.miFile.Index = 0
            Me.miFile.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miManagePaths, Me.miOpenGFFFile, Me.miViewGFFFiles, Me.miOpenKey, Me.miOpenRIM, Me.MenuItem5, Me.miRecentFiles, Me.MenuItem6, Me.miQuit})
            Me.miFile.Text = "&File"
            Me.miManagePaths.Index = 0
            Me.miManagePaths.Text = "&Manage Paths..."
            Me.miOpenGFFFile.Index = 1
            Me.miOpenGFFFile.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenGFFFile.Text = "Open &GFF Files..."
            Me.miViewGFFFiles.Index = 2
            Me.miViewGFFFiles.Text = "&View GFF Files as Text..."
            Me.miOpenKey.Index = 3
            Me.miOpenKey.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenKey.Text = "&Open Key file..."
            Me.miOpenKey.Visible = False
            Me.miOpenRIM.Index = 4
            Me.miOpenRIM.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlR
            Me.miOpenRIM.Text = "Open RIM file..."
            Me.miOpenRIM.Visible = False
            Me.MenuItem5.Index = 5
            Me.MenuItem5.Text = "-"
            Me.miRecentFiles.Index = 6
            Me.miRecentFiles.Text = "Recent &Files"
            Me.MenuItem6.Index = 7
            Me.MenuItem6.Text = "-"
            Me.miQuit.Index = 8
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            Me.MenuItem3.Index = 1
            Me.MenuItem3.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miExtract, Me.miOpenProjectManager, Me.miOpen2DAEditor, Me.miConversationEditor, Me.miOpenModuleEditor, Me.miOpenDialogTlkViewer, Me.miGlobalVariableEditor, Me.miOpenTextEditor, Me.miOpenPWKEditor, Me.miOpenSSFEditor, Me.miOpenERFBuilder, Me.MenuItem10, Me.miRefSearch, Me.MenuItem4, Me.miCleanWorkingDir, Me.MenuItem1, Me.miOpenWorkingDir, Me.MenuItem8, Me.miShowSupportedModEditorMaps, Me.miOpenMapsFolder, Me.MenuItem7, Me.miOptions})
            Me.MenuItem3.Text = "&Tools"
            Me.miExtract.Enabled = False
            Me.miExtract.Index = 0
            Me.miExtract.Text = "(nothing selected)"
            Me.miExtract.Visible = False
            Me.miOpenProjectManager.Index = 1
            Me.miOpenProjectManager.Shortcut = Global.System.Windows.Forms.Shortcut.Ctrl1
            Me.miOpenProjectManager.Text = "Open Project Manager"
            Me.miOpen2DAEditor.Index = 2
            Me.miOpen2DAEditor.Shortcut = Global.System.Windows.Forms.Shortcut.Ctrl2
            Me.miOpen2DAEditor.Text = "Open &2DA file editor"
            Me.miConversationEditor.Index = 3
            Me.miConversationEditor.Shortcut = Global.System.Windows.Forms.Shortcut.Ctrl3
            Me.miConversationEditor.Text = "Open &Conversation editor"
            Me.miOpenModuleEditor.Index = 4
            Me.miOpenModuleEditor.Shortcut = Global.System.Windows.Forms.Shortcut.F1
            Me.miOpenModuleEditor.Text = "Open &Module editor"
            Me.miOpenDialogTlkViewer.Index = 5
            Me.miOpenDialogTlkViewer.Text = "Open &Dialog.Tlk editor"
            Me.miGlobalVariableEditor.Index = 6
            Me.miGlobalVariableEditor.Text = "Open &Global Variable editor"
            Me.miOpenTextEditor.Index = 7
            Me.miOpenTextEditor.Text = "Open &Text editor"
            Me.miOpenPWKEditor.Index = 8
            Me.miOpenPWKEditor.Text = "Open &PWK/DWK editor"
            Me.miOpenSSFEditor.Index = 9
            Me.miOpenSSFEditor.Text = "Open &SSF editor"
            Me.miOpenERFBuilder.Index = 10
            Me.miOpenERFBuilder.Text = "Open &ERF/MOD builder"
            Me.MenuItem10.Index = 11
            Me.MenuItem10.Text = "-"
            Me.miRefSearch.Index = 12
            Me.miRefSearch.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlF
            Me.miRefSearch.Text = "Search for text in BIFs/RIMs"
            Me.MenuItem4.Index = 13
            Me.MenuItem4.Text = "-"
            Me.miCleanWorkingDir.Index = 14
            Me.miCleanWorkingDir.Text = "Clean Working Directory"
            Me.MenuItem1.Index = 15
            Me.MenuItem1.Text = "-"
            Me.miOpenWorkingDir.Index = 16
            Me.miOpenWorkingDir.Text = "Open Working Directory"
            Me.MenuItem8.Index = 17
            Me.MenuItem8.Text = "-"
            Me.miShowSupportedModEditorMaps.Index = 18
            Me.miShowSupportedModEditorMaps.Text = "Show Maps supported by Module editor"
            Me.miOpenMapsFolder.Index = 19
            Me.miOpenMapsFolder.Text = "Explore Maps folder"
            Me.MenuItem7.Index = 20
            Me.MenuItem7.Text = "-"
            Me.miOptions.Index = 21
            Me.miOptions.Text = "&Options..."
            Me.MenuItem2.Index = 2
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miBasicHelp, Me.miCheckForUpdates, Me.miRegisterSoftware, Me.miAbout})
            Me.MenuItem2.Text = "&Help"
            Me.miBasicHelp.Index = 0
            Me.miBasicHelp.Text = "Basic &Instructions..."
            Me.miCheckForUpdates.Index = 1
            Me.miCheckForUpdates.Text = "Check for program updates"
            Me.miRegisterSoftware.Index = 2
            Me.miRegisterSoftware.Text = "&Register..."
            Me.miRegisterSoftware.Visible = False
            Me.miAbout.Index = 3
            Me.miAbout.Text = "&About..."
            Me.tvCMenu.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiExtractForModuleEditing})
            Me.cmiExtractForModuleEditing.Index = 0
            Me.cmiExtractForModuleEditing.Text = "Extract for Module editing..."
            Me.ToolBar1.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() {Me.tbbtn2DAEditor, Me.tbbtnConversationEditor, Me.tbbtnTextEditor, Me.tbbtnERFBuilder})
            Dim toolBar As Global.System.Windows.Forms.ToolBar = Me.ToolBar1
            size = New Global.System.Drawing.Size(20, 20)
            toolBar.ButtonSize = size
            Me.ToolBar1.DropDownArrows = True
            Me.ToolBar1.ImageList = Me.imglstToolBar
            Dim toolBar2 As Global.System.Windows.Forms.Control = Me.ToolBar1
            point = New Global.System.Drawing.Point(0, 0)
            toolBar2.Location = point
            Me.ToolBar1.Name = "ToolBar1"
            Me.ToolBar1.ShowToolTips = True
            Dim toolBar3 As Global.System.Windows.Forms.Control = Me.ToolBar1
            size = New Global.System.Drawing.Size(296, 32)
            toolBar3.Size = size
            Me.ToolBar1.TabIndex = 4
            Me.tbbtn2DAEditor.ImageIndex = 0
            Me.tbbtn2DAEditor.ToolTipText = "Open the 2DA Editor"
            Me.tbbtnConversationEditor.ImageIndex = 1
            Me.tbbtnConversationEditor.ToolTipText = "Open the Conversation Editor"
            Me.tbbtnTextEditor.ImageIndex = 2
            Me.tbbtnTextEditor.ToolTipText = "Open the Text Editor"
            Me.tbbtnERFBuilder.ImageIndex = 3
            Me.tbbtnERFBuilder.ToolTipText = "Open the ERF File Builder"
            Dim imglstToolBar As Global.System.Windows.Forms.ImageList = Me.imglstToolBar
            size = New Global.System.Drawing.Size(20, 20)
            imglstToolBar.ImageSize = size
            Me.imglstToolBar.ImageStream = CType(resourceManager.GetObject("imglstToolBar.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
            Me.imglstToolBar.TransparentColor = Global.System.Drawing.Color.Transparent
            Me.btnExtractForModuleEditing.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnExtractForModuleEditing.BackColor = Global.System.Drawing.SystemColors.Control
            Me.btnExtractForModuleEditing.Enabled = False
            Dim btnExtractForModuleEditing As Global.System.Windows.Forms.Control = Me.btnExtractForModuleEditing
            point = New Global.System.Drawing.Point(200, 120)
            btnExtractForModuleEditing.Location = point
            Me.btnExtractForModuleEditing.Name = "btnExtractForModuleEditing"
            Dim btnExtractForModuleEditing2 As Global.System.Windows.Forms.Control = Me.btnExtractForModuleEditing
            size = New Global.System.Drawing.Size(88, 32)
            btnExtractForModuleEditing2.Size = size
            Me.btnExtractForModuleEditing.TabIndex = 5
            Me.btnExtractForModuleEditing.Text = "Extract for Module Editing"
            Me.Button4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Button4.BackColor = Global.System.Drawing.SystemColors.Control
            Dim button As Global.System.Windows.Forms.Control = Me.Button4
            point = New Global.System.Drawing.Point(192, 312)
            button.Location = point
            Me.Button4.Name = "Button4"
            Dim button2 As Global.System.Windows.Forms.Control = Me.Button4
            size = New Global.System.Drawing.Size(96, 24)
            button2.Size = size
            Me.Button4.TabIndex = 5
            Me.Button4.Text = "Parse NWScript"
            Me.Button4.Visible = False
            Me.btnCreateMapInfoBFD.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCreateMapInfoBFD.BackColor = Global.System.Drawing.SystemColors.Control
            Dim btnCreateMapInfoBFD As Global.System.Windows.Forms.Control = Me.btnCreateMapInfoBFD
            point = New Global.System.Drawing.Point(192, 408)
            btnCreateMapInfoBFD.Location = point
            Me.btnCreateMapInfoBFD.Name = "btnCreateMapInfoBFD"
            Dim btnCreateMapInfoBFD2 As Global.System.Windows.Forms.Control = Me.btnCreateMapInfoBFD
            size = New Global.System.Drawing.Size(96, 23)
            btnCreateMapInfoBFD2.Size = size
            Me.btnCreateMapInfoBFD.TabIndex = 5
            Me.btnCreateMapInfoBFD.Text = "Create MapInfo"
            Me.btnCreateMapInfoBFD.Visible = False
            Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Button1.BackColor = Global.System.Drawing.SystemColors.Control
            Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
            point = New Global.System.Drawing.Point(192, 352)
            button3.Location = point
            Me.Button1.Name = "Button1"
            Dim button4 As Global.System.Windows.Forms.Control = Me.Button1
            size = New Global.System.Drawing.Size(96, 24)
            button4.Size = size
            Me.Button1.TabIndex = 5
            Me.Button1.Text = "Test Getktsi"
            Me.Button1.Visible = False
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.BackColor = Global.System.Drawing.SystemColors.Control
            size = New Global.System.Drawing.Size(296, 465)
            Me.ClientSize = size
            Me.Controls.Add(Me.Button4)
            Me.Controls.Add(Me.btnExtractForModuleEditing)
            Me.Controls.Add(Me.ToolBar1)
            Me.Controls.Add(Me.TreeView)
            Me.Controls.Add(Me.btnHexViewer)
            Me.Controls.Add(Me.btnExtract)
            Me.Controls.Add(Me.btnCreateMapInfoBFD)
            Me.Controls.Add(Me.Button1)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Menu = Me.MainMenu1
            size = New Global.System.Drawing.Size(304, 352)
            Me.MinimumSize = size
            Me.Name = "frmMain"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Kotor Tool"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040003B4 RID: 948
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
