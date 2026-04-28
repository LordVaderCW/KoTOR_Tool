Namespace kotor_tool
	' Token: 0x02000054 RID: 84
	Public Partial Class frmMain
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents TreeView As Global.System.Windows.Forms.TreeView
        Friend WithEvents btnExtract As Global.System.Windows.Forms.Button
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem3 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miAbout As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenKey As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miExtract As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miBasicHelp As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenRIM As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miManagePaths As Global.System.Windows.Forms.MenuItem
        Friend WithEvents btnHexViewer As Global.System.Windows.Forms.Button
        Friend WithEvents miOptions As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpen2DAEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenTextEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenGFFFile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenERFBuilder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miViewGFFFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miRegisterSoftware As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvCMenu As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents cmiExtractForModuleEditing As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miConversationEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents ToolBar1 As Global.System.Windows.Forms.ToolBar
        Friend WithEvents tbbtn2DAEditor As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbbtnConversationEditor As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbbtnTextEditor As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbbtnERFBuilder As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCleanWorkingDir As Global.System.Windows.Forms.MenuItem
        Friend WithEvents imglstToolBar As Global.System.Windows.Forms.ImageList
        Friend WithEvents miRefSearch As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miFile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miRecentFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenProjectManager As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCheckForUpdates As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miGlobalVariableEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenWorkingDir As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem8 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents Button4 As Global.System.Windows.Forms.Button
        Friend WithEvents miOpenDialogTlkViewer As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenPWKEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowSupportedModEditorMaps As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem7 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenMapsFolder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenModuleEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem10 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenSSFEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents btnCreateMapInfoBFD As Global.System.Windows.Forms.Button
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents btnExtractForModuleEditing As Global.System.Windows.Forms.Button


		' Token: 0x0600067A RID: 1658 RVA: 0x0024CA38 File Offset: 0x0024BA38
		Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso Me.Components IsNot Nothing Then
                Me.Components.Dispose()
            End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060006E7 RID: 1767 RVA: 0x0024DCA0 File Offset: 0x0024CCA0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.TreeView = New System.Windows.Forms.TreeView()
            Me.btnHexViewer = New System.Windows.Forms.Button()
            Me.btnExtract = New System.Windows.Forms.Button()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu()
            Me.miFile = New System.Windows.Forms.MenuItem()
            Me.miManagePaths = New System.Windows.Forms.MenuItem()
            Me.miOpenGFFFile = New System.Windows.Forms.MenuItem()
            Me.miViewGFFFiles = New System.Windows.Forms.MenuItem()
            Me.miOpenKey = New System.Windows.Forms.MenuItem()
            Me.miOpenRIM = New System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New System.Windows.Forms.MenuItem()
            Me.miRecentFiles = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New System.Windows.Forms.MenuItem()
            Me.miExtract = New System.Windows.Forms.MenuItem()
            Me.miOpenProjectManager = New System.Windows.Forms.MenuItem()
            Me.miOpen2DAEditor = New System.Windows.Forms.MenuItem()
            Me.miConversationEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenModuleEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenDialogTlkViewer = New System.Windows.Forms.MenuItem()
            Me.miGlobalVariableEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenTextEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenPWKEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenSSFEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenERFBuilder = New System.Windows.Forms.MenuItem()
            Me.MenuItem10 = New System.Windows.Forms.MenuItem()
            Me.miRefSearch = New System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New System.Windows.Forms.MenuItem()
            Me.miCleanWorkingDir = New System.Windows.Forms.MenuItem()
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miOpenWorkingDir = New System.Windows.Forms.MenuItem()
            Me.MenuItem8 = New System.Windows.Forms.MenuItem()
            Me.miShowSupportedModEditorMaps = New System.Windows.Forms.MenuItem()
            Me.miOpenMapsFolder = New System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New System.Windows.Forms.MenuItem()
            Me.miOptions = New System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New System.Windows.Forms.MenuItem()
            Me.miBasicHelp = New System.Windows.Forms.MenuItem()
            Me.miCheckForUpdates = New System.Windows.Forms.MenuItem()
            Me.miRegisterSoftware = New System.Windows.Forms.MenuItem()
            Me.miAbout = New System.Windows.Forms.MenuItem()
            Me.tvCMenu = New System.Windows.Forms.ContextMenu()
            Me.cmiExtractForModuleEditing = New System.Windows.Forms.MenuItem()
            Me.ToolBar1 = New System.Windows.Forms.ToolBar()
            Me.tbbtn2DAEditor = New System.Windows.Forms.ToolBarButton()
            Me.tbbtnConversationEditor = New System.Windows.Forms.ToolBarButton()
            Me.tbbtnTextEditor = New System.Windows.Forms.ToolBarButton()
            Me.tbbtnERFBuilder = New System.Windows.Forms.ToolBarButton()
            Me.imglstToolBar = New System.Windows.Forms.ImageList()
            Me.btnExtractForModuleEditing = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.btnCreateMapInfoBFD = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'TreeView
            '
            Me.TreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TreeView.Location = New System.Drawing.Point(16, 40)
            Me.TreeView.Name = "TreeView"
            Me.TreeView.Size = New System.Drawing.Size(302, 400)
            Me.TreeView.TabIndex = 1
            '
            'btnHexViewer
            '
            Me.btnHexViewer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnHexViewer.BackColor = System.Drawing.SystemColors.Control
            Me.btnHexViewer.Enabled = False
            Me.btnHexViewer.Location = New System.Drawing.Point(324, 172)
            Me.btnHexViewer.Name = "btnHexViewer"
            Me.btnHexViewer.Size = New System.Drawing.Size(110, 50)
            Me.btnHexViewer.TabIndex = 0
            Me.btnHexViewer.Text = "Hex Viewer"
            Me.btnHexViewer.UseVisualStyleBackColor = False
            '
            'btnExtract
            '
            Me.btnExtract.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExtract.BackColor = System.Drawing.SystemColors.Control
            Me.btnExtract.Enabled = False
            Me.btnExtract.Location = New System.Drawing.Point(324, 40)
            Me.btnExtract.Name = "btnExtract"
            Me.btnExtract.Size = New System.Drawing.Size(110, 56)
            Me.btnExtract.TabIndex = 1
            Me.btnExtract.Text = "Extract"
            Me.btnExtract.UseVisualStyleBackColor = False
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miFile, Me.MenuItem3, Me.MenuItem2})
            '
            'miFile
            '
            Me.miFile.Index = 0
            Me.miFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miManagePaths, Me.miOpenGFFFile, Me.miViewGFFFiles, Me.miOpenKey, Me.miOpenRIM, Me.MenuItem5, Me.miRecentFiles, Me.MenuItem6, Me.miQuit})
            Me.miFile.Text = "&File"
            '
            'miManagePaths
            '
            Me.miManagePaths.Index = 0
            Me.miManagePaths.Text = "&Manage Paths..."
            '
            'miOpenGFFFile
            '
            Me.miOpenGFFFile.Index = 1
            Me.miOpenGFFFile.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenGFFFile.Text = "Open &GFF Files..."
            '
            'miViewGFFFiles
            '
            Me.miViewGFFFiles.Index = 2
            Me.miViewGFFFiles.Text = "&View GFF Files as Text..."
            '
            'miOpenKey
            '
            Me.miOpenKey.Index = 3
            Me.miOpenKey.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenKey.Text = "&Open Key file..."
            Me.miOpenKey.Visible = False
            '
            'miOpenRIM
            '
            Me.miOpenRIM.Index = 4
            Me.miOpenRIM.Shortcut = System.Windows.Forms.Shortcut.CtrlR
            Me.miOpenRIM.Text = "Open RIM file..."
            Me.miOpenRIM.Visible = False
            '
            'MenuItem5
            '
            Me.MenuItem5.Index = 5
            Me.MenuItem5.Text = "-"
            '
            'miRecentFiles
            '
            Me.miRecentFiles.Index = 6
            Me.miRecentFiles.Text = "Recent &Files"
            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 7
            Me.MenuItem6.Text = "-"
            '
            'miQuit
            '
            Me.miQuit.Index = 8
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'MenuItem3
            '
            Me.MenuItem3.Index = 1
            Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miExtract, Me.miOpenProjectManager, Me.miOpen2DAEditor, Me.miConversationEditor, Me.miOpenModuleEditor, Me.miOpenDialogTlkViewer, Me.miGlobalVariableEditor, Me.miOpenTextEditor, Me.miOpenPWKEditor, Me.miOpenSSFEditor, Me.miOpenERFBuilder, Me.MenuItem10, Me.miRefSearch, Me.MenuItem4, Me.miCleanWorkingDir, Me.MenuItem1, Me.miOpenWorkingDir, Me.MenuItem8, Me.miShowSupportedModEditorMaps, Me.miOpenMapsFolder, Me.MenuItem7, Me.miOptions})
            Me.MenuItem3.Text = "&Tools"
            '
            'miExtract
            '
            Me.miExtract.Enabled = False
            Me.miExtract.Index = 0
            Me.miExtract.Text = "(nothing selected)"
            Me.miExtract.Visible = False
            '
            'miOpenProjectManager
            '
            Me.miOpenProjectManager.Index = 1
            Me.miOpenProjectManager.Shortcut = System.Windows.Forms.Shortcut.Ctrl1
            Me.miOpenProjectManager.Text = "Open Project Manager"
            '
            'miOpen2DAEditor
            '
            Me.miOpen2DAEditor.Index = 2
            Me.miOpen2DAEditor.Shortcut = System.Windows.Forms.Shortcut.Ctrl2
            Me.miOpen2DAEditor.Text = "Open &2DA file editor"
            '
            'miConversationEditor
            '
            Me.miConversationEditor.Index = 3
            Me.miConversationEditor.Shortcut = System.Windows.Forms.Shortcut.Ctrl3
            Me.miConversationEditor.Text = "Open &Conversation editor"
            '
            'miOpenModuleEditor
            '
            Me.miOpenModuleEditor.Index = 4
            Me.miOpenModuleEditor.Shortcut = System.Windows.Forms.Shortcut.F1
            Me.miOpenModuleEditor.Text = "Open &Module editor"
            '
            'miOpenDialogTlkViewer
            '
            Me.miOpenDialogTlkViewer.Index = 5
            Me.miOpenDialogTlkViewer.Text = "Open &Dialog.Tlk editor"
            '
            'miGlobalVariableEditor
            '
            Me.miGlobalVariableEditor.Index = 6
            Me.miGlobalVariableEditor.Text = "Open &Global Variable editor"
            '
            'miOpenTextEditor
            '
            Me.miOpenTextEditor.Index = 7
            Me.miOpenTextEditor.Text = "Open &Text editor"
            '
            'miOpenPWKEditor
            '
            Me.miOpenPWKEditor.Index = 8
            Me.miOpenPWKEditor.Text = "Open &PWK/DWK editor"
            '
            'miOpenSSFEditor
            '
            Me.miOpenSSFEditor.Index = 9
            Me.miOpenSSFEditor.Text = "Open &SSF editor"
            '
            'miOpenERFBuilder
            '
            Me.miOpenERFBuilder.Index = 10
            Me.miOpenERFBuilder.Text = "Open &ERF/MOD builder"
            '
            'MenuItem10
            '
            Me.MenuItem10.Index = 11
            Me.MenuItem10.Text = "-"
            '
            'miRefSearch
            '
            Me.miRefSearch.Index = 12
            Me.miRefSearch.Shortcut = System.Windows.Forms.Shortcut.CtrlF
            Me.miRefSearch.Text = "Search for text in BIFs/RIMs"
            '
            'MenuItem4
            '
            Me.MenuItem4.Index = 13
            Me.MenuItem4.Text = "-"
            '
            'miCleanWorkingDir
            '
            Me.miCleanWorkingDir.Index = 14
            Me.miCleanWorkingDir.Text = "Clean Working Directory"
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 15
            Me.MenuItem1.Text = "-"
            '
            'miOpenWorkingDir
            '
            Me.miOpenWorkingDir.Index = 16
            Me.miOpenWorkingDir.Text = "Open Working Directory"
            '
            'MenuItem8
            '
            Me.MenuItem8.Index = 17
            Me.MenuItem8.Text = "-"
            '
            'miShowSupportedModEditorMaps
            '
            Me.miShowSupportedModEditorMaps.Index = 18
            Me.miShowSupportedModEditorMaps.Text = "Show Maps supported by Module editor"
            '
            'miOpenMapsFolder
            '
            Me.miOpenMapsFolder.Index = 19
            Me.miOpenMapsFolder.Text = "Explore Maps folder"
            '
            'MenuItem7
            '
            Me.MenuItem7.Index = 20
            Me.MenuItem7.Text = "-"
            '
            'miOptions
            '
            Me.miOptions.Index = 21
            Me.miOptions.Text = "&Options..."
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 2
            Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miBasicHelp, Me.miCheckForUpdates, Me.miRegisterSoftware, Me.miAbout})
            Me.MenuItem2.Text = "&Help"
            '
            'miBasicHelp
            '
            Me.miBasicHelp.Index = 0
            Me.miBasicHelp.Text = "Basic &Instructions..."
            '
            'miCheckForUpdates
            '
            Me.miCheckForUpdates.Index = 1
            Me.miCheckForUpdates.Text = "Check for program updates"
            '
            'miRegisterSoftware
            '
            Me.miRegisterSoftware.Index = 2
            Me.miRegisterSoftware.Text = "&Register..."
            Me.miRegisterSoftware.Visible = False
            '
            'miAbout
            '
            Me.miAbout.Index = 3
            Me.miAbout.Text = "&About..."
            '
            'tvCMenu
            '
            Me.tvCMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmiExtractForModuleEditing})
            '
            'cmiExtractForModuleEditing
            '
            Me.cmiExtractForModuleEditing.Index = 0
            Me.cmiExtractForModuleEditing.Text = "Extract for Module editing..."
            '
            'ToolBar1
            '
            Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtn2DAEditor, Me.tbbtnConversationEditor, Me.tbbtnTextEditor, Me.tbbtnERFBuilder})
            Me.ToolBar1.ButtonSize = New System.Drawing.Size(20, 20)
            Me.ToolBar1.DropDownArrows = True
            Me.ToolBar1.ImageList = Me.imglstToolBar
            Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
            Me.ToolBar1.Name = "ToolBar1"
            Me.ToolBar1.ShowToolTips = True
            Me.ToolBar1.Size = New System.Drawing.Size(438, 33)
            Me.ToolBar1.TabIndex = 4
            Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
            '
            'tbbtn2DAEditor
            '
            Me.tbbtn2DAEditor.ImageIndex = 0
            Me.tbbtn2DAEditor.Name = "tbbtn2DAEditor"
            Me.tbbtn2DAEditor.Text = "2DA"
            Me.tbbtn2DAEditor.ToolTipText = "Open the 2DA Editor"
            '
            'tbbtnConversationEditor
            '
            Me.tbbtnConversationEditor.ImageIndex = 1
            Me.tbbtnConversationEditor.Name = "tbbtnConversationEditor"
            Me.tbbtnConversationEditor.Text = "CNV"
            Me.tbbtnConversationEditor.ToolTipText = "Open the Conversation Editor"
            '
            'tbbtnTextEditor
            '
            Me.tbbtnTextEditor.ImageIndex = 2
            Me.tbbtnTextEditor.Name = "tbbtnTextEditor"
            Me.tbbtnTextEditor.Text = "TXT"
            Me.tbbtnTextEditor.ToolTipText = "Open the Text Editor"
            '
            'tbbtnERFBuilder
            '
            Me.tbbtnERFBuilder.ImageIndex = 3
            Me.tbbtnERFBuilder.Name = "tbbtnERFBuilder"
            Me.tbbtnERFBuilder.Text = "ERF"
            Me.tbbtnERFBuilder.ToolTipText = "Open the ERF File Builder"
            '
            'imglstToolBar
            '
            Me.imglstToolBar.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
            Me.imglstToolBar.ImageSize = New System.Drawing.Size(20, 20)
            Me.imglstToolBar.TransparentColor = System.Drawing.Color.Transparent
            '
            'btnExtractForModuleEditing
            '
            Me.btnExtractForModuleEditing.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExtractForModuleEditing.BackColor = System.Drawing.SystemColors.Control
            Me.btnExtractForModuleEditing.Enabled = False
            Me.btnExtractForModuleEditing.Location = New System.Drawing.Point(324, 102)
            Me.btnExtractForModuleEditing.Name = "btnExtractForModuleEditing"
            Me.btnExtractForModuleEditing.Size = New System.Drawing.Size(110, 64)
            Me.btnExtractForModuleEditing.TabIndex = 5
            Me.btnExtractForModuleEditing.Text = "Extract for Module Editing"
            Me.btnExtractForModuleEditing.UseVisualStyleBackColor = False
            '
            'Button4
            '
            Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button4.BackColor = System.Drawing.SystemColors.Control
            Me.Button4.Location = New System.Drawing.Point(324, 228)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(110, 24)
            Me.Button4.TabIndex = 5
            Me.Button4.Text = "Parse NWScript"
            Me.Button4.UseVisualStyleBackColor = False
            Me.Button4.Visible = False
            '
            'btnCreateMapInfoBFD
            '
            Me.btnCreateMapInfoBFD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreateMapInfoBFD.BackColor = System.Drawing.SystemColors.Control
            Me.btnCreateMapInfoBFD.Location = New System.Drawing.Point(324, 288)
            Me.btnCreateMapInfoBFD.Name = "btnCreateMapInfoBFD"
            Me.btnCreateMapInfoBFD.Size = New System.Drawing.Size(110, 23)
            Me.btnCreateMapInfoBFD.TabIndex = 5
            Me.btnCreateMapInfoBFD.Text = "Create MapInfo"
            Me.btnCreateMapInfoBFD.UseVisualStyleBackColor = False
            Me.btnCreateMapInfoBFD.Visible = False
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.BackColor = System.Drawing.SystemColors.Control
            Me.Button1.Location = New System.Drawing.Point(324, 258)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(110, 24)
            Me.Button1.TabIndex = 5
            Me.Button1.Text = "Test Getktsi"
            Me.Button1.UseVisualStyleBackColor = False
            Me.Button1.Visible = False
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.ClientSize = New System.Drawing.Size(438, 465)
            Me.Controls.Add(Me.Button4)
            Me.Controls.Add(Me.btnExtractForModuleEditing)
            Me.Controls.Add(Me.ToolBar1)
            Me.Controls.Add(Me.TreeView)
            Me.Controls.Add(Me.btnHexViewer)
            Me.Controls.Add(Me.btnExtract)
            Me.Controls.Add(Me.btnCreateMapInfoBFD)
            Me.Controls.Add(Me.Button1)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New System.Drawing.Size(304, 352)
            Me.Name = "frmMain"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Kotor Tool"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

	End Class
End Namespace
