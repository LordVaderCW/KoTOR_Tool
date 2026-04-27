Namespace kotor_tool
	' Token: 0x02000064 RID: 100
	Public Partial Class frmOptions
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents chkbBuildBIFTreeAtStartup As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbAlwaysConvertTPC2TGA As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbDockImageViewer As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbTextEditorWordWrap As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbBuildModelsBifNode As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbAlwaysUnknownGFFasText As Global.System.Windows.Forms.CheckBox
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents chkbShowModuleLocations As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbShowModuleDescriptions As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbCheckForUpdatesAtStartup As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbDownloadUpdatesAutomatically As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbRememberLastTreeNode As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUseOverrideFiles As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbRememberTreeViewState As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tabpagTreeview As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagOther As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagProjectManager As Global.System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents rbProjMgrUseExternDLGEditor As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbProjMgrUseExternTxtEditor As Global.System.Windows.Forms.RadioButton
        Friend WithEvents btnBrowseProjMgrDLGEditorPath As Global.System.Windows.Forms.Button
        Friend WithEvents tbProjMgrDLGEditorPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnBrowseProjMgrTxtEditorPath As Global.System.Windows.Forms.Button
        Friend WithEvents tbProjMgrTxtEditorPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents rbProjMgrUseInternDLGEditor As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbProjMgrUseInternTxtEditor As Global.System.Windows.Forms.RadioButton


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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmOptions))
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
            Me.btnOK.Location = New Global.System.Drawing.Point(232, 352)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 6
            Me.btnOK.Text = "OK"
            Me.chkbBuildBIFTreeAtStartup.Location = New Global.System.Drawing.Point(32, 16)
            Me.chkbBuildBIFTreeAtStartup.Name = "chkbBuildBIFTreeAtStartup"
            Me.chkbBuildBIFTreeAtStartup.Size = New Global.System.Drawing.Size(160, 24)
            Me.chkbBuildBIFTreeAtStartup.TabIndex = 0
            Me.chkbBuildBIFTreeAtStartup.Text = "Build BIF Tree at startup"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(320, 352)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 7
            Me.btnCancel.Text = "Cancel"
            Me.chkbAlwaysConvertTPC2TGA.Location = New Global.System.Drawing.Point(32, 112)
            Me.chkbAlwaysConvertTPC2TGA.Name = "chkbAlwaysConvertTPC2TGA"
            Me.chkbAlwaysConvertTPC2TGA.Size = New Global.System.Drawing.Size(264, 24)
            Me.chkbAlwaysConvertTPC2TGA.TabIndex = 3
            Me.chkbAlwaysConvertTPC2TGA.Text = "Always convert TPC files to TGA upon extract"
            Me.chkbDockImageViewer.Location = New Global.System.Drawing.Point(32, 16)
            Me.chkbDockImageViewer.Name = "chkbDockImageViewer"
            Me.chkbDockImageViewer.Size = New Global.System.Drawing.Size(208, 24)
            Me.chkbDockImageViewer.TabIndex = 4
            Me.chkbDockImageViewer.Text = "Dock Image Viewer to Main window"
            Me.chkbTextEditorWordWrap.Location = New Global.System.Drawing.Point(32, 48)
            Me.chkbTextEditorWordWrap.Name = "chkbTextEditorWordWrap"
            Me.chkbTextEditorWordWrap.Size = New Global.System.Drawing.Size(232, 24)
            Me.chkbTextEditorWordWrap.TabIndex = 5
            Me.chkbTextEditorWordWrap.Text = "Word Wrap on by default in text editor"
            Me.chkbBuildModelsBifNode.Checked = True
            Me.chkbBuildModelsBifNode.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbBuildModelsBifNode.Location = New Global.System.Drawing.Point(32, 48)
            Me.chkbBuildModelsBifNode.Name = "chkbBuildModelsBifNode"
            Me.chkbBuildModelsBifNode.Size = New Global.System.Drawing.Size(254, 24)
            Me.chkbBuildModelsBifNode.TabIndex = 1
            Me.chkbBuildModelsBifNode.Text = "Build Model BIF node in Tree"
            Me.chkbAlwaysUnknownGFFasText.Location = New Global.System.Drawing.Point(32, 80)
            Me.chkbAlwaysUnknownGFFasText.Name = "chkbAlwaysUnknownGFFasText"
            Me.chkbAlwaysUnknownGFFasText.Size = New Global.System.Drawing.Size(270, 24)
            Me.chkbAlwaysUnknownGFFasText.TabIndex = 2
            Me.chkbAlwaysUnknownGFFasText.Text = "Double-click opens unsupported GFFs as Text"
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.tabpagTreeview)
            Me.TabControl1.Controls.Add(Me.tabpagProjectManager)
            Me.TabControl1.Controls.Add(Me.tabpagOther)
            Me.TabControl1.Location = New Global.System.Drawing.Point(16, 16)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(392, 312)
            Me.TabControl1.TabIndex = 8
            Me.tabpagTreeview.Controls.Add(Me.chkbBuildModelsBifNode)
            Me.tabpagTreeview.Controls.Add(Me.chkbAlwaysConvertTPC2TGA)
            Me.tabpagTreeview.Controls.Add(Me.chkbBuildBIFTreeAtStartup)
            Me.tabpagTreeview.Controls.Add(Me.chkbAlwaysUnknownGFFasText)
            Me.tabpagTreeview.Controls.Add(Me.chkbShowModuleLocations)
            Me.tabpagTreeview.Controls.Add(Me.chkbShowModuleDescriptions)
            Me.tabpagTreeview.Controls.Add(Me.chkbRememberLastTreeNode)
            Me.tabpagTreeview.Controls.Add(Me.chkbRememberTreeViewState)
            Me.tabpagTreeview.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagTreeview.Name = "tabpagTreeview"
            Me.tabpagTreeview.Size = New Global.System.Drawing.Size(384, 286)
            Me.tabpagTreeview.TabIndex = 0
            Me.tabpagTreeview.Text = "Treeview"
            Me.chkbShowModuleLocations.Checked = True
            Me.chkbShowModuleLocations.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbShowModuleLocations.Location = New Global.System.Drawing.Point(32, 176)
            Me.chkbShowModuleLocations.Name = "chkbShowModuleLocations"
            Me.chkbShowModuleLocations.Size = New Global.System.Drawing.Size(264, 24)
            Me.chkbShowModuleLocations.TabIndex = 3
            Me.chkbShowModuleLocations.Text = "Show Module Locations"
            Me.chkbShowModuleDescriptions.Checked = True
            Me.chkbShowModuleDescriptions.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbShowModuleDescriptions.Location = New Global.System.Drawing.Point(32, 144)
            Me.chkbShowModuleDescriptions.Name = "chkbShowModuleDescriptions"
            Me.chkbShowModuleDescriptions.Size = New Global.System.Drawing.Size(270, 24)
            Me.chkbShowModuleDescriptions.TabIndex = 2
            Me.chkbShowModuleDescriptions.Text = "Show Module Descriptions"
            Me.chkbRememberLastTreeNode.Checked = True
            Me.chkbRememberLastTreeNode.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbRememberLastTreeNode.Location = New Global.System.Drawing.Point(32, 208)
            Me.chkbRememberLastTreeNode.Name = "chkbRememberLastTreeNode"
            Me.chkbRememberLastTreeNode.Size = New Global.System.Drawing.Size(264, 24)
            Me.chkbRememberLastTreeNode.TabIndex = 3
            Me.chkbRememberLastTreeNode.Text = "Remember last opened node"
            Me.chkbRememberTreeViewState.Checked = True
            Me.chkbRememberTreeViewState.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbRememberTreeViewState.Location = New Global.System.Drawing.Point(32, 240)
            Me.chkbRememberTreeViewState.Name = "chkbRememberTreeViewState"
            Me.chkbRememberTreeViewState.Size = New Global.System.Drawing.Size(264, 24)
            Me.chkbRememberTreeViewState.TabIndex = 3
            Me.chkbRememberTreeViewState.Text = "Remember treeview state"
            Me.tabpagProjectManager.Controls.Add(Me.GroupBox1)
            Me.tabpagProjectManager.Controls.Add(Me.GroupBox2)
            Me.tabpagProjectManager.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagProjectManager.Name = "tabpagProjectManager"
            Me.tabpagProjectManager.Size = New Global.System.Drawing.Size(384, 286)
            Me.tabpagProjectManager.TabIndex = 2
            Me.tabpagProjectManager.Text = "Project Manager"
            Me.GroupBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.GroupBox1.Controls.Add(Me.btnBrowseProjMgrDLGEditorPath)
            Me.GroupBox1.Controls.Add(Me.tbProjMgrDLGEditorPath)
            Me.GroupBox1.Controls.Add(Me.rbProjMgrUseInternDLGEditor)
            Me.GroupBox1.Controls.Add(Me.rbProjMgrUseExternDLGEditor)
            Me.GroupBox1.Location = New Global.System.Drawing.Point(16, 8)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New Global.System.Drawing.Size(352, 80)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Dialog Editor"
            Me.btnBrowseProjMgrDLGEditorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnBrowseProjMgrDLGEditorPath.Enabled = False
            Me.btnBrowseProjMgrDLGEditorPath.Location = New Global.System.Drawing.Point(312, 50)
            Me.btnBrowseProjMgrDLGEditorPath.Name = "btnBrowseProjMgrDLGEditorPath"
            Me.btnBrowseProjMgrDLGEditorPath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnBrowseProjMgrDLGEditorPath.TabIndex = 4
            Me.btnBrowseProjMgrDLGEditorPath.Text = "..."
            Me.tbProjMgrDLGEditorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbProjMgrDLGEditorPath.Enabled = False
            Me.tbProjMgrDLGEditorPath.Location = New Global.System.Drawing.Point(96, 50)
            Me.tbProjMgrDLGEditorPath.Name = "tbProjMgrDLGEditorPath"
            Me.tbProjMgrDLGEditorPath.Size = New Global.System.Drawing.Size(208, 20)
            Me.tbProjMgrDLGEditorPath.TabIndex = 3
            Me.tbProjMgrDLGEditorPath.Text = ""
            Me.rbProjMgrUseInternDLGEditor.Checked = True
            Me.rbProjMgrUseInternDLGEditor.Location = New Global.System.Drawing.Point(24, 16)
            Me.rbProjMgrUseInternDLGEditor.Name = "rbProjMgrUseInternDLGEditor"
            Me.rbProjMgrUseInternDLGEditor.Size = New Global.System.Drawing.Size(72, 24)
            Me.rbProjMgrUseInternDLGEditor.TabIndex = 0
            Me.rbProjMgrUseInternDLGEditor.TabStop = True
            Me.rbProjMgrUseInternDLGEditor.Text = "Internal"
            Me.rbProjMgrUseExternDLGEditor.Location = New Global.System.Drawing.Point(24, 48)
            Me.rbProjMgrUseExternDLGEditor.Name = "rbProjMgrUseExternDLGEditor"
            Me.rbProjMgrUseExternDLGEditor.Size = New Global.System.Drawing.Size(72, 24)
            Me.rbProjMgrUseExternDLGEditor.TabIndex = 0
            Me.rbProjMgrUseExternDLGEditor.Text = "External"
            Me.GroupBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.GroupBox2.Controls.Add(Me.rbProjMgrUseInternTxtEditor)
            Me.GroupBox2.Controls.Add(Me.tbProjMgrTxtEditorPath)
            Me.GroupBox2.Controls.Add(Me.rbProjMgrUseExternTxtEditor)
            Me.GroupBox2.Controls.Add(Me.btnBrowseProjMgrTxtEditorPath)
            Me.GroupBox2.Location = New Global.System.Drawing.Point(16, 112)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New Global.System.Drawing.Size(352, 80)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Text/NSS Editor"
            Me.rbProjMgrUseInternTxtEditor.Checked = True
            Me.rbProjMgrUseInternTxtEditor.Location = New Global.System.Drawing.Point(24, 16)
            Me.rbProjMgrUseInternTxtEditor.Name = "rbProjMgrUseInternTxtEditor"
            Me.rbProjMgrUseInternTxtEditor.Size = New Global.System.Drawing.Size(72, 24)
            Me.rbProjMgrUseInternTxtEditor.TabIndex = 0
            Me.rbProjMgrUseInternTxtEditor.TabStop = True
            Me.rbProjMgrUseInternTxtEditor.Text = "Internal"
            Me.tbProjMgrTxtEditorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbProjMgrTxtEditorPath.Enabled = False
            Me.tbProjMgrTxtEditorPath.Location = New Global.System.Drawing.Point(96, 49)
            Me.tbProjMgrTxtEditorPath.Name = "tbProjMgrTxtEditorPath"
            Me.tbProjMgrTxtEditorPath.Size = New Global.System.Drawing.Size(208, 20)
            Me.tbProjMgrTxtEditorPath.TabIndex = 3
            Me.tbProjMgrTxtEditorPath.Text = ""
            Me.rbProjMgrUseExternTxtEditor.Location = New Global.System.Drawing.Point(24, 48)
            Me.rbProjMgrUseExternTxtEditor.Name = "rbProjMgrUseExternTxtEditor"
            Me.rbProjMgrUseExternTxtEditor.Size = New Global.System.Drawing.Size(72, 24)
            Me.rbProjMgrUseExternTxtEditor.TabIndex = 0
            Me.rbProjMgrUseExternTxtEditor.Text = "External"
            Me.btnBrowseProjMgrTxtEditorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnBrowseProjMgrTxtEditorPath.Enabled = False
            Me.btnBrowseProjMgrTxtEditorPath.Location = New Global.System.Drawing.Point(312, 50)
            Me.btnBrowseProjMgrTxtEditorPath.Name = "btnBrowseProjMgrTxtEditorPath"
            Me.btnBrowseProjMgrTxtEditorPath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnBrowseProjMgrTxtEditorPath.TabIndex = 4
            Me.btnBrowseProjMgrTxtEditorPath.Text = "..."
            Me.tabpagOther.Controls.Add(Me.chkbTextEditorWordWrap)
            Me.tabpagOther.Controls.Add(Me.chkbDockImageViewer)
            Me.tabpagOther.Controls.Add(Me.chkbCheckForUpdatesAtStartup)
            Me.tabpagOther.Controls.Add(Me.chkbDownloadUpdatesAutomatically)
            Me.tabpagOther.Controls.Add(Me.chkbUseOverrideFiles)
            Me.tabpagOther.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagOther.Name = "tabpagOther"
            Me.tabpagOther.Size = New Global.System.Drawing.Size(384, 286)
            Me.tabpagOther.TabIndex = 1
            Me.tabpagOther.Text = "Other"
            Me.chkbCheckForUpdatesAtStartup.Location = New Global.System.Drawing.Point(32, 80)
            Me.chkbCheckForUpdatesAtStartup.Name = "chkbCheckForUpdatesAtStartup"
            Me.chkbCheckForUpdatesAtStartup.Size = New Global.System.Drawing.Size(232, 24)
            Me.chkbCheckForUpdatesAtStartup.TabIndex = 5
            Me.chkbCheckForUpdatesAtStartup.Text = "Check for program updates at startup"
            Me.chkbDownloadUpdatesAutomatically.Location = New Global.System.Drawing.Point(56, 104)
            Me.chkbDownloadUpdatesAutomatically.Name = "chkbDownloadUpdatesAutomatically"
            Me.chkbDownloadUpdatesAutomatically.Size = New Global.System.Drawing.Size(192, 24)
            Me.chkbDownloadUpdatesAutomatically.TabIndex = 5
            Me.chkbDownloadUpdatesAutomatically.Text = "Download updates automatically"
            Me.chkbUseOverrideFiles.Location = New Global.System.Drawing.Point(32, 136)
            Me.chkbUseOverrideFiles.Name = "chkbUseOverrideFiles"
            Me.chkbUseOverrideFiles.Size = New Global.System.Drawing.Size(256, 24)
            Me.chkbUseOverrideFiles.TabIndex = 5
            Me.chkbUseOverrideFiles.Text = "Look in Game's Override folder for 2DA files"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(432, 389)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.chkbCheckForUpdatesAtStartup.CheckedChanged, AddressOf Me.chkbCheckForUpdatesAtStartup_CheckedChanged
            AddHandler Me.rbProjMgrUseExternDLGEditor.CheckedChanged, AddressOf Me.rbProjMgrUseExternDLGEditor_CheckedChanged
            AddHandler Me.rbProjMgrUseExternTxtEditor.CheckedChanged, AddressOf Me.rbProjMgrUseExternTxtEditor_CheckedChanged_1
            AddHandler Me.btnBrowseProjMgrDLGEditorPath.Click, AddressOf Me.btnBrowseProjMgrDLGEditorPath_Click
            AddHandler Me.btnBrowseProjMgrTxtEditorPath.Click, AddressOf Me.btnBrowseProjMgrTxtEditorPath_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
