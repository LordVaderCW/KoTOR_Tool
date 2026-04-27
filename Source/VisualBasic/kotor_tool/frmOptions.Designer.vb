Namespace kotor_tool
	' Token: 0x02000064 RID: 100
	Public Partial Class frmOptions
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000C70 RID: 3184 RVA: 0x002814D4 File Offset: 0x002804D4
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000CAB RID: 3243 RVA: 0x00281BB4 File Offset: 0x00280BB4
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmOptions))
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.chkbBuildBIFTreeAtStartup = New Global.System.Windows.Forms.CheckBox()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.chkbAlwaysConvertTPC2TGA = New Global.System.Windows.Forms.CheckBox()
            Me.chkbDockImageViewer = New Global.System.Windows.Forms.CheckBox()
            Me.chkbTextEditorWordWrap = New Global.System.Windows.Forms.CheckBox()
            Me.chkbBuildModelsBifNode = New Global.System.Windows.Forms.CheckBox()
            Me.chkbAlwaysUnknownGFFasText = New Global.System.Windows.Forms.CheckBox()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.tabpagTreeview = New Global.System.Windows.Forms.TabPage()
            Me.chkbShowModuleLocations = New Global.System.Windows.Forms.CheckBox()
            Me.chkbShowModuleDescriptions = New Global.System.Windows.Forms.CheckBox()
            Me.chkbRememberLastTreeNode = New Global.System.Windows.Forms.CheckBox()
            Me.chkbRememberTreeViewState = New Global.System.Windows.Forms.CheckBox()
            Me.tabpagProjectManager = New Global.System.Windows.Forms.TabPage()
            Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
            Me.btnBrowseProjMgrDLGEditorPath = New Global.System.Windows.Forms.Button()
            Me.tbProjMgrDLGEditorPath = New Global.System.Windows.Forms.TextBox()
            Me.rbProjMgrUseInternDLGEditor = New Global.System.Windows.Forms.RadioButton()
            Me.rbProjMgrUseExternDLGEditor = New Global.System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
            Me.rbProjMgrUseInternTxtEditor = New Global.System.Windows.Forms.RadioButton()
            Me.tbProjMgrTxtEditorPath = New Global.System.Windows.Forms.TextBox()
            Me.rbProjMgrUseExternTxtEditor = New Global.System.Windows.Forms.RadioButton()
            Me.btnBrowseProjMgrTxtEditorPath = New Global.System.Windows.Forms.Button()
            Me.tabpagOther = New Global.System.Windows.Forms.TabPage()
            Me.chkbCheckForUpdatesAtStartup = New Global.System.Windows.Forms.CheckBox()
            Me.chkbDownloadUpdatesAutomatically = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUseOverrideFiles = New Global.System.Windows.Forms.CheckBox()
            Me.TabControl1.SuspendLayout()
            Me.tabpagTreeview.SuspendLayout()
            Me.tabpagProjectManager.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.tabpagOther.SuspendLayout()
            Me.SuspendLayout()
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(232, 352)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 6
            Me.btnOK.Text = "OK"
            Dim chkbBuildBIFTreeAtStartup As Global.System.Windows.Forms.Control = Me.chkbBuildBIFTreeAtStartup
            point = New Global.System.Drawing.Point(32, 16)
            chkbBuildBIFTreeAtStartup.Location = point
            Me.chkbBuildBIFTreeAtStartup.Name = "chkbBuildBIFTreeAtStartup"
            Dim chkbBuildBIFTreeAtStartup2 As Global.System.Windows.Forms.Control = Me.chkbBuildBIFTreeAtStartup
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(160, 24)
            chkbBuildBIFTreeAtStartup2.Size = size
            Me.chkbBuildBIFTreeAtStartup.TabIndex = 0
            Me.chkbBuildBIFTreeAtStartup.Text = "Build BIF Tree at startup"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(320, 352)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 7
            Me.btnCancel.Text = "Cancel"
            Dim chkbAlwaysConvertTPC2TGA As Global.System.Windows.Forms.Control = Me.chkbAlwaysConvertTPC2TGA
            point = New Global.System.Drawing.Point(32, 112)
            chkbAlwaysConvertTPC2TGA.Location = point
            Me.chkbAlwaysConvertTPC2TGA.Name = "chkbAlwaysConvertTPC2TGA"
            Dim chkbAlwaysConvertTPC2TGA2 As Global.System.Windows.Forms.Control = Me.chkbAlwaysConvertTPC2TGA
            size = New Global.System.Drawing.Size(264, 24)
            chkbAlwaysConvertTPC2TGA2.Size = size
            Me.chkbAlwaysConvertTPC2TGA.TabIndex = 3
            Me.chkbAlwaysConvertTPC2TGA.Text = "Always convert TPC files to TGA upon extract"
            Dim chkbDockImageViewer As Global.System.Windows.Forms.Control = Me.chkbDockImageViewer
            point = New Global.System.Drawing.Point(32, 16)
            chkbDockImageViewer.Location = point
            Me.chkbDockImageViewer.Name = "chkbDockImageViewer"
            Dim chkbDockImageViewer2 As Global.System.Windows.Forms.Control = Me.chkbDockImageViewer
            size = New Global.System.Drawing.Size(208, 24)
            chkbDockImageViewer2.Size = size
            Me.chkbDockImageViewer.TabIndex = 4
            Me.chkbDockImageViewer.Text = "Dock Image Viewer to Main window"
            Dim chkbTextEditorWordWrap As Global.System.Windows.Forms.Control = Me.chkbTextEditorWordWrap
            point = New Global.System.Drawing.Point(32, 48)
            chkbTextEditorWordWrap.Location = point
            Me.chkbTextEditorWordWrap.Name = "chkbTextEditorWordWrap"
            Dim chkbTextEditorWordWrap2 As Global.System.Windows.Forms.Control = Me.chkbTextEditorWordWrap
            size = New Global.System.Drawing.Size(232, 24)
            chkbTextEditorWordWrap2.Size = size
            Me.chkbTextEditorWordWrap.TabIndex = 5
            Me.chkbTextEditorWordWrap.Text = "Word Wrap on by default in text editor"
            Me.chkbBuildModelsBifNode.Checked = True
            Me.chkbBuildModelsBifNode.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbBuildModelsBifNode As Global.System.Windows.Forms.Control = Me.chkbBuildModelsBifNode
            point = New Global.System.Drawing.Point(32, 48)
            chkbBuildModelsBifNode.Location = point
            Me.chkbBuildModelsBifNode.Name = "chkbBuildModelsBifNode"
            Dim chkbBuildModelsBifNode2 As Global.System.Windows.Forms.Control = Me.chkbBuildModelsBifNode
            size = New Global.System.Drawing.Size(254, 24)
            chkbBuildModelsBifNode2.Size = size
            Me.chkbBuildModelsBifNode.TabIndex = 1
            Me.chkbBuildModelsBifNode.Text = "Build Model BIF node in Tree"
            Dim chkbAlwaysUnknownGFFasText As Global.System.Windows.Forms.Control = Me.chkbAlwaysUnknownGFFasText
            point = New Global.System.Drawing.Point(32, 80)
            chkbAlwaysUnknownGFFasText.Location = point
            Me.chkbAlwaysUnknownGFFasText.Name = "chkbAlwaysUnknownGFFasText"
            Dim chkbAlwaysUnknownGFFasText2 As Global.System.Windows.Forms.Control = Me.chkbAlwaysUnknownGFFasText
            size = New Global.System.Drawing.Size(270, 24)
            chkbAlwaysUnknownGFFasText2.Size = size
            Me.chkbAlwaysUnknownGFFasText.TabIndex = 2
            Me.chkbAlwaysUnknownGFFasText.Text = "Double-click opens unsupported GFFs as Text"
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.tabpagTreeview)
            Me.TabControl1.Controls.Add(Me.tabpagProjectManager)
            Me.TabControl1.Controls.Add(Me.tabpagOther)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            point = New Global.System.Drawing.Point(16, 16)
            tabControl.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
            size = New Global.System.Drawing.Size(392, 312)
            tabControl2.Size = size
            Me.TabControl1.TabIndex = 8
            Me.tabpagTreeview.Controls.Add(Me.chkbBuildModelsBifNode)
            Me.tabpagTreeview.Controls.Add(Me.chkbAlwaysConvertTPC2TGA)
            Me.tabpagTreeview.Controls.Add(Me.chkbBuildBIFTreeAtStartup)
            Me.tabpagTreeview.Controls.Add(Me.chkbAlwaysUnknownGFFasText)
            Me.tabpagTreeview.Controls.Add(Me.chkbShowModuleLocations)
            Me.tabpagTreeview.Controls.Add(Me.chkbShowModuleDescriptions)
            Me.tabpagTreeview.Controls.Add(Me.chkbRememberLastTreeNode)
            Me.tabpagTreeview.Controls.Add(Me.chkbRememberTreeViewState)
            Dim tabpagTreeview As Global.System.Windows.Forms.Control = Me.tabpagTreeview
            point = New Global.System.Drawing.Point(4, 22)
            tabpagTreeview.Location = point
            Me.tabpagTreeview.Name = "tabpagTreeview"
            Dim tabpagTreeview2 As Global.System.Windows.Forms.Control = Me.tabpagTreeview
            size = New Global.System.Drawing.Size(384, 286)
            tabpagTreeview2.Size = size
            Me.tabpagTreeview.TabIndex = 0
            Me.tabpagTreeview.Text = "Treeview"
            Me.chkbShowModuleLocations.Checked = True
            Me.chkbShowModuleLocations.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbShowModuleLocations As Global.System.Windows.Forms.Control = Me.chkbShowModuleLocations
            point = New Global.System.Drawing.Point(32, 176)
            chkbShowModuleLocations.Location = point
            Me.chkbShowModuleLocations.Name = "chkbShowModuleLocations"
            Dim chkbShowModuleLocations2 As Global.System.Windows.Forms.Control = Me.chkbShowModuleLocations
            size = New Global.System.Drawing.Size(264, 24)
            chkbShowModuleLocations2.Size = size
            Me.chkbShowModuleLocations.TabIndex = 3
            Me.chkbShowModuleLocations.Text = "Show Module Locations"
            Me.chkbShowModuleDescriptions.Checked = True
            Me.chkbShowModuleDescriptions.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbShowModuleDescriptions As Global.System.Windows.Forms.Control = Me.chkbShowModuleDescriptions
            point = New Global.System.Drawing.Point(32, 144)
            chkbShowModuleDescriptions.Location = point
            Me.chkbShowModuleDescriptions.Name = "chkbShowModuleDescriptions"
            Dim chkbShowModuleDescriptions2 As Global.System.Windows.Forms.Control = Me.chkbShowModuleDescriptions
            size = New Global.System.Drawing.Size(270, 24)
            chkbShowModuleDescriptions2.Size = size
            Me.chkbShowModuleDescriptions.TabIndex = 2
            Me.chkbShowModuleDescriptions.Text = "Show Module Descriptions"
            Me.chkbRememberLastTreeNode.Checked = True
            Me.chkbRememberLastTreeNode.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbRememberLastTreeNode As Global.System.Windows.Forms.Control = Me.chkbRememberLastTreeNode
            point = New Global.System.Drawing.Point(32, 208)
            chkbRememberLastTreeNode.Location = point
            Me.chkbRememberLastTreeNode.Name = "chkbRememberLastTreeNode"
            Dim chkbRememberLastTreeNode2 As Global.System.Windows.Forms.Control = Me.chkbRememberLastTreeNode
            size = New Global.System.Drawing.Size(264, 24)
            chkbRememberLastTreeNode2.Size = size
            Me.chkbRememberLastTreeNode.TabIndex = 3
            Me.chkbRememberLastTreeNode.Text = "Remember last opened node"
            Me.chkbRememberTreeViewState.Checked = True
            Me.chkbRememberTreeViewState.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbRememberTreeViewState As Global.System.Windows.Forms.Control = Me.chkbRememberTreeViewState
            point = New Global.System.Drawing.Point(32, 240)
            chkbRememberTreeViewState.Location = point
            Me.chkbRememberTreeViewState.Name = "chkbRememberTreeViewState"
            Dim chkbRememberTreeViewState2 As Global.System.Windows.Forms.Control = Me.chkbRememberTreeViewState
            size = New Global.System.Drawing.Size(264, 24)
            chkbRememberTreeViewState2.Size = size
            Me.chkbRememberTreeViewState.TabIndex = 3
            Me.chkbRememberTreeViewState.Text = "Remember treeview state"
            Me.tabpagProjectManager.Controls.Add(Me.GroupBox1)
            Me.tabpagProjectManager.Controls.Add(Me.GroupBox2)
            Dim tabpagProjectManager As Global.System.Windows.Forms.Control = Me.tabpagProjectManager
            point = New Global.System.Drawing.Point(4, 22)
            tabpagProjectManager.Location = point
            Me.tabpagProjectManager.Name = "tabpagProjectManager"
            Dim tabpagProjectManager2 As Global.System.Windows.Forms.Control = Me.tabpagProjectManager
            size = New Global.System.Drawing.Size(384, 286)
            tabpagProjectManager2.Size = size
            Me.tabpagProjectManager.TabIndex = 2
            Me.tabpagProjectManager.Text = "Project Manager"
            Me.GroupBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.GroupBox1.Controls.Add(Me.btnBrowseProjMgrDLGEditorPath)
            Me.GroupBox1.Controls.Add(Me.tbProjMgrDLGEditorPath)
            Me.GroupBox1.Controls.Add(Me.rbProjMgrUseInternDLGEditor)
            Me.GroupBox1.Controls.Add(Me.rbProjMgrUseExternDLGEditor)
            Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
            point = New Global.System.Drawing.Point(16, 8)
            groupBox.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
            size = New Global.System.Drawing.Size(352, 80)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Dialog Editor"
            Me.btnBrowseProjMgrDLGEditorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnBrowseProjMgrDLGEditorPath.Enabled = False
            Dim btnBrowseProjMgrDLGEditorPath As Global.System.Windows.Forms.Control = Me.btnBrowseProjMgrDLGEditorPath
            point = New Global.System.Drawing.Point(312, 50)
            btnBrowseProjMgrDLGEditorPath.Location = point
            Me.btnBrowseProjMgrDLGEditorPath.Name = "btnBrowseProjMgrDLGEditorPath"
            Dim btnBrowseProjMgrDLGEditorPath2 As Global.System.Windows.Forms.Control = Me.btnBrowseProjMgrDLGEditorPath
            size = New Global.System.Drawing.Size(24, 20)
            btnBrowseProjMgrDLGEditorPath2.Size = size
            Me.btnBrowseProjMgrDLGEditorPath.TabIndex = 4
            Me.btnBrowseProjMgrDLGEditorPath.Text = "..."
            Me.tbProjMgrDLGEditorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbProjMgrDLGEditorPath.Enabled = False
            Dim tbProjMgrDLGEditorPath As Global.System.Windows.Forms.Control = Me.tbProjMgrDLGEditorPath
            point = New Global.System.Drawing.Point(96, 50)
            tbProjMgrDLGEditorPath.Location = point
            Me.tbProjMgrDLGEditorPath.Name = "tbProjMgrDLGEditorPath"
            Dim tbProjMgrDLGEditorPath2 As Global.System.Windows.Forms.Control = Me.tbProjMgrDLGEditorPath
            size = New Global.System.Drawing.Size(208, 20)
            tbProjMgrDLGEditorPath2.Size = size
            Me.tbProjMgrDLGEditorPath.TabIndex = 3
            Me.tbProjMgrDLGEditorPath.Text = ""
            Me.rbProjMgrUseInternDLGEditor.Checked = True
            Dim rbProjMgrUseInternDLGEditor As Global.System.Windows.Forms.Control = Me.rbProjMgrUseInternDLGEditor
            point = New Global.System.Drawing.Point(24, 16)
            rbProjMgrUseInternDLGEditor.Location = point
            Me.rbProjMgrUseInternDLGEditor.Name = "rbProjMgrUseInternDLGEditor"
            Dim rbProjMgrUseInternDLGEditor2 As Global.System.Windows.Forms.Control = Me.rbProjMgrUseInternDLGEditor
            size = New Global.System.Drawing.Size(72, 24)
            rbProjMgrUseInternDLGEditor2.Size = size
            Me.rbProjMgrUseInternDLGEditor.TabIndex = 0
            Me.rbProjMgrUseInternDLGEditor.TabStop = True
            Me.rbProjMgrUseInternDLGEditor.Text = "Internal"
            Dim rbProjMgrUseExternDLGEditor As Global.System.Windows.Forms.Control = Me.rbProjMgrUseExternDLGEditor
            point = New Global.System.Drawing.Point(24, 48)
            rbProjMgrUseExternDLGEditor.Location = point
            Me.rbProjMgrUseExternDLGEditor.Name = "rbProjMgrUseExternDLGEditor"
            Dim rbProjMgrUseExternDLGEditor2 As Global.System.Windows.Forms.Control = Me.rbProjMgrUseExternDLGEditor
            size = New Global.System.Drawing.Size(72, 24)
            rbProjMgrUseExternDLGEditor2.Size = size
            Me.rbProjMgrUseExternDLGEditor.TabIndex = 0
            Me.rbProjMgrUseExternDLGEditor.Text = "External"
            Me.GroupBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.GroupBox2.Controls.Add(Me.rbProjMgrUseInternTxtEditor)
            Me.GroupBox2.Controls.Add(Me.tbProjMgrTxtEditorPath)
            Me.GroupBox2.Controls.Add(Me.rbProjMgrUseExternTxtEditor)
            Me.GroupBox2.Controls.Add(Me.btnBrowseProjMgrTxtEditorPath)
            Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
            point = New Global.System.Drawing.Point(16, 112)
            groupBox3.Location = point
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
            size = New Global.System.Drawing.Size(352, 80)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Text/NSS Editor"
            Me.rbProjMgrUseInternTxtEditor.Checked = True
            Dim rbProjMgrUseInternTxtEditor As Global.System.Windows.Forms.Control = Me.rbProjMgrUseInternTxtEditor
            point = New Global.System.Drawing.Point(24, 16)
            rbProjMgrUseInternTxtEditor.Location = point
            Me.rbProjMgrUseInternTxtEditor.Name = "rbProjMgrUseInternTxtEditor"
            Dim rbProjMgrUseInternTxtEditor2 As Global.System.Windows.Forms.Control = Me.rbProjMgrUseInternTxtEditor
            size = New Global.System.Drawing.Size(72, 24)
            rbProjMgrUseInternTxtEditor2.Size = size
            Me.rbProjMgrUseInternTxtEditor.TabIndex = 0
            Me.rbProjMgrUseInternTxtEditor.TabStop = True
            Me.rbProjMgrUseInternTxtEditor.Text = "Internal"
            Me.tbProjMgrTxtEditorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbProjMgrTxtEditorPath.Enabled = False
            Dim tbProjMgrTxtEditorPath As Global.System.Windows.Forms.Control = Me.tbProjMgrTxtEditorPath
            point = New Global.System.Drawing.Point(96, 49)
            tbProjMgrTxtEditorPath.Location = point
            Me.tbProjMgrTxtEditorPath.Name = "tbProjMgrTxtEditorPath"
            Dim tbProjMgrTxtEditorPath2 As Global.System.Windows.Forms.Control = Me.tbProjMgrTxtEditorPath
            size = New Global.System.Drawing.Size(208, 20)
            tbProjMgrTxtEditorPath2.Size = size
            Me.tbProjMgrTxtEditorPath.TabIndex = 3
            Me.tbProjMgrTxtEditorPath.Text = ""
            Dim rbProjMgrUseExternTxtEditor As Global.System.Windows.Forms.Control = Me.rbProjMgrUseExternTxtEditor
            point = New Global.System.Drawing.Point(24, 48)
            rbProjMgrUseExternTxtEditor.Location = point
            Me.rbProjMgrUseExternTxtEditor.Name = "rbProjMgrUseExternTxtEditor"
            Dim rbProjMgrUseExternTxtEditor2 As Global.System.Windows.Forms.Control = Me.rbProjMgrUseExternTxtEditor
            size = New Global.System.Drawing.Size(72, 24)
            rbProjMgrUseExternTxtEditor2.Size = size
            Me.rbProjMgrUseExternTxtEditor.TabIndex = 0
            Me.rbProjMgrUseExternTxtEditor.Text = "External"
            Me.btnBrowseProjMgrTxtEditorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnBrowseProjMgrTxtEditorPath.Enabled = False
            Dim btnBrowseProjMgrTxtEditorPath As Global.System.Windows.Forms.Control = Me.btnBrowseProjMgrTxtEditorPath
            point = New Global.System.Drawing.Point(312, 50)
            btnBrowseProjMgrTxtEditorPath.Location = point
            Me.btnBrowseProjMgrTxtEditorPath.Name = "btnBrowseProjMgrTxtEditorPath"
            Dim btnBrowseProjMgrTxtEditorPath2 As Global.System.Windows.Forms.Control = Me.btnBrowseProjMgrTxtEditorPath
            size = New Global.System.Drawing.Size(24, 20)
            btnBrowseProjMgrTxtEditorPath2.Size = size
            Me.btnBrowseProjMgrTxtEditorPath.TabIndex = 4
            Me.btnBrowseProjMgrTxtEditorPath.Text = "..."
            Me.tabpagOther.Controls.Add(Me.chkbTextEditorWordWrap)
            Me.tabpagOther.Controls.Add(Me.chkbDockImageViewer)
            Me.tabpagOther.Controls.Add(Me.chkbCheckForUpdatesAtStartup)
            Me.tabpagOther.Controls.Add(Me.chkbDownloadUpdatesAutomatically)
            Me.tabpagOther.Controls.Add(Me.chkbUseOverrideFiles)
            Dim tabpagOther As Global.System.Windows.Forms.Control = Me.tabpagOther
            point = New Global.System.Drawing.Point(4, 22)
            tabpagOther.Location = point
            Me.tabpagOther.Name = "tabpagOther"
            Dim tabpagOther2 As Global.System.Windows.Forms.Control = Me.tabpagOther
            size = New Global.System.Drawing.Size(384, 286)
            tabpagOther2.Size = size
            Me.tabpagOther.TabIndex = 1
            Me.tabpagOther.Text = "Other"
            Dim chkbCheckForUpdatesAtStartup As Global.System.Windows.Forms.Control = Me.chkbCheckForUpdatesAtStartup
            point = New Global.System.Drawing.Point(32, 80)
            chkbCheckForUpdatesAtStartup.Location = point
            Me.chkbCheckForUpdatesAtStartup.Name = "chkbCheckForUpdatesAtStartup"
            Dim chkbCheckForUpdatesAtStartup2 As Global.System.Windows.Forms.Control = Me.chkbCheckForUpdatesAtStartup
            size = New Global.System.Drawing.Size(232, 24)
            chkbCheckForUpdatesAtStartup2.Size = size
            Me.chkbCheckForUpdatesAtStartup.TabIndex = 5
            Me.chkbCheckForUpdatesAtStartup.Text = "Check for program updates at startup"
            Dim chkbDownloadUpdatesAutomatically As Global.System.Windows.Forms.Control = Me.chkbDownloadUpdatesAutomatically
            point = New Global.System.Drawing.Point(56, 104)
            chkbDownloadUpdatesAutomatically.Location = point
            Me.chkbDownloadUpdatesAutomatically.Name = "chkbDownloadUpdatesAutomatically"
            Dim chkbDownloadUpdatesAutomatically2 As Global.System.Windows.Forms.Control = Me.chkbDownloadUpdatesAutomatically
            size = New Global.System.Drawing.Size(192, 24)
            chkbDownloadUpdatesAutomatically2.Size = size
            Me.chkbDownloadUpdatesAutomatically.TabIndex = 5
            Me.chkbDownloadUpdatesAutomatically.Text = "Download updates automatically"
            Dim chkbUseOverrideFiles As Global.System.Windows.Forms.Control = Me.chkbUseOverrideFiles
            point = New Global.System.Drawing.Point(32, 136)
            chkbUseOverrideFiles.Location = point
            Me.chkbUseOverrideFiles.Name = "chkbUseOverrideFiles"
            Dim chkbUseOverrideFiles2 As Global.System.Windows.Forms.Control = Me.chkbUseOverrideFiles
            size = New Global.System.Drawing.Size(256, 24)
            chkbUseOverrideFiles2.Size = size
            Me.chkbUseOverrideFiles.TabIndex = 5
            Me.chkbUseOverrideFiles.Text = "Look in Game's Override folder for 2DA files"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(432, 389)
            Me.ClientSize = size
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmOptions"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Options"
            Me.TabControl1.ResumeLayout(False)
            Me.tabpagTreeview.ResumeLayout(False)
            Me.tabpagProjectManager.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.tabpagOther.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000650 RID: 1616
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
