Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmOptions
        Inherits Global.System.Windows.Forms.Form

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderSeparator As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterSeparator As Global.System.Windows.Forms.Label

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

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmOptions))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.tabpagTreeview = New Global.System.Windows.Forms.TabPage()
            Me.chkbBuildModelsBifNode = New Global.System.Windows.Forms.CheckBox()
            Me.chkbAlwaysConvertTPC2TGA = New Global.System.Windows.Forms.CheckBox()
            Me.chkbBuildBIFTreeAtStartup = New Global.System.Windows.Forms.CheckBox()
            Me.chkbAlwaysUnknownGFFasText = New Global.System.Windows.Forms.CheckBox()
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
            Me.chkbTextEditorWordWrap = New Global.System.Windows.Forms.CheckBox()
            Me.chkbDockImageViewer = New Global.System.Windows.Forms.CheckBox()
            Me.chkbCheckForUpdatesAtStartup = New Global.System.Windows.Forms.CheckBox()
            Me.chkbDownloadUpdatesAutomatically = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUseOverrideFiles = New Global.System.Windows.Forms.CheckBox()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.lblFooterSeparator = New Global.System.Windows.Forms.Label()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New Global.System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tabpagTreeview.SuspendLayout()
            Me.tabpagProjectManager.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.tabpagOther.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(520, 450)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(18, 18, 18, 18)
            Me.pnlBody.Size = New Global.System.Drawing.Size(520, 312)
            Me.pnlBody.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tabpagTreeview)
            Me.TabControl1.Controls.Add(Me.tabpagProjectManager)
            Me.TabControl1.Controls.Add(Me.tabpagOther)
            Me.TabControl1.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New Global.System.Drawing.Point(18, 18)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(484, 276)
            Me.TabControl1.TabIndex = 0
            '
            'tabpagTreeview
            '
            Me.tabpagTreeview.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagTreeview.Controls.Add(Me.chkbBuildModelsBifNode)
            Me.tabpagTreeview.Controls.Add(Me.chkbAlwaysConvertTPC2TGA)
            Me.tabpagTreeview.Controls.Add(Me.chkbBuildBIFTreeAtStartup)
            Me.tabpagTreeview.Controls.Add(Me.chkbAlwaysUnknownGFFasText)
            Me.tabpagTreeview.Controls.Add(Me.chkbShowModuleLocations)
            Me.tabpagTreeview.Controls.Add(Me.chkbShowModuleDescriptions)
            Me.tabpagTreeview.Controls.Add(Me.chkbRememberLastTreeNode)
            Me.tabpagTreeview.Controls.Add(Me.chkbRememberTreeViewState)
            Me.tabpagTreeview.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagTreeview.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagTreeview.Name = "tabpagTreeview"
            Me.tabpagTreeview.Padding = New Global.System.Windows.Forms.Padding(18, 18, 18, 18)
            Me.tabpagTreeview.Size = New Global.System.Drawing.Size(476, 250)
            Me.tabpagTreeview.TabIndex = 0
            Me.tabpagTreeview.Text = "Treeview"
            '
            'chkbBuildModelsBifNode
            '
            Me.chkbBuildModelsBifNode.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbBuildModelsBifNode.Checked = True
            Me.chkbBuildModelsBifNode.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbBuildModelsBifNode.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbBuildModelsBifNode.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbBuildModelsBifNode.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbBuildModelsBifNode.Location = New Global.System.Drawing.Point(32, 46)
            Me.chkbBuildModelsBifNode.Name = "chkbBuildModelsBifNode"
            Me.chkbBuildModelsBifNode.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbBuildModelsBifNode.TabIndex = 1
            Me.chkbBuildModelsBifNode.Text = "Build Model BIF node in Tree"
            Me.chkbBuildModelsBifNode.UseVisualStyleBackColor = False
            '
            'chkbAlwaysConvertTPC2TGA
            '
            Me.chkbAlwaysConvertTPC2TGA.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbAlwaysConvertTPC2TGA.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbAlwaysConvertTPC2TGA.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbAlwaysConvertTPC2TGA.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAlwaysConvertTPC2TGA.Location = New Global.System.Drawing.Point(32, 100)
            Me.chkbAlwaysConvertTPC2TGA.Name = "chkbAlwaysConvertTPC2TGA"
            Me.chkbAlwaysConvertTPC2TGA.Size = New Global.System.Drawing.Size(320, 22)
            Me.chkbAlwaysConvertTPC2TGA.TabIndex = 3
            Me.chkbAlwaysConvertTPC2TGA.Text = "Always convert TPC files to TGA upon extract"
            Me.chkbAlwaysConvertTPC2TGA.UseVisualStyleBackColor = False
            '
            'chkbBuildBIFTreeAtStartup
            '
            Me.chkbBuildBIFTreeAtStartup.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbBuildBIFTreeAtStartup.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbBuildBIFTreeAtStartup.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbBuildBIFTreeAtStartup.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbBuildBIFTreeAtStartup.Location = New Global.System.Drawing.Point(32, 19)
            Me.chkbBuildBIFTreeAtStartup.Name = "chkbBuildBIFTreeAtStartup"
            Me.chkbBuildBIFTreeAtStartup.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbBuildBIFTreeAtStartup.TabIndex = 0
            Me.chkbBuildBIFTreeAtStartup.Text = "Build BIF Tree at startup"
            Me.chkbBuildBIFTreeAtStartup.UseVisualStyleBackColor = False
            '
            'chkbAlwaysUnknownGFFasText
            '
            Me.chkbAlwaysUnknownGFFasText.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbAlwaysUnknownGFFasText.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbAlwaysUnknownGFFasText.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbAlwaysUnknownGFFasText.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAlwaysUnknownGFFasText.Location = New Global.System.Drawing.Point(32, 73)
            Me.chkbAlwaysUnknownGFFasText.Name = "chkbAlwaysUnknownGFFasText"
            Me.chkbAlwaysUnknownGFFasText.Size = New Global.System.Drawing.Size(330, 22)
            Me.chkbAlwaysUnknownGFFasText.TabIndex = 2
            Me.chkbAlwaysUnknownGFFasText.Text = "Double-click opens unsupported GFFs as Text"
            Me.chkbAlwaysUnknownGFFasText.UseVisualStyleBackColor = False
            '
            'chkbShowModuleLocations
            '
            Me.chkbShowModuleLocations.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbShowModuleLocations.Checked = True
            Me.chkbShowModuleLocations.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbShowModuleLocations.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbShowModuleLocations.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbShowModuleLocations.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbShowModuleLocations.Location = New Global.System.Drawing.Point(32, 154)
            Me.chkbShowModuleLocations.Name = "chkbShowModuleLocations"
            Me.chkbShowModuleLocations.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbShowModuleLocations.TabIndex = 5
            Me.chkbShowModuleLocations.Text = "Show Module Locations"
            Me.chkbShowModuleLocations.UseVisualStyleBackColor = False
            '
            'chkbShowModuleDescriptions
            '
            Me.chkbShowModuleDescriptions.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbShowModuleDescriptions.Checked = True
            Me.chkbShowModuleDescriptions.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbShowModuleDescriptions.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbShowModuleDescriptions.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbShowModuleDescriptions.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbShowModuleDescriptions.Location = New Global.System.Drawing.Point(32, 127)
            Me.chkbShowModuleDescriptions.Name = "chkbShowModuleDescriptions"
            Me.chkbShowModuleDescriptions.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbShowModuleDescriptions.TabIndex = 4
            Me.chkbShowModuleDescriptions.Text = "Show Module Descriptions"
            Me.chkbShowModuleDescriptions.UseVisualStyleBackColor = False
            '
            'chkbRememberLastTreeNode
            '
            Me.chkbRememberLastTreeNode.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbRememberLastTreeNode.Checked = True
            Me.chkbRememberLastTreeNode.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbRememberLastTreeNode.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbRememberLastTreeNode.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbRememberLastTreeNode.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbRememberLastTreeNode.Location = New Global.System.Drawing.Point(32, 181)
            Me.chkbRememberLastTreeNode.Name = "chkbRememberLastTreeNode"
            Me.chkbRememberLastTreeNode.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbRememberLastTreeNode.TabIndex = 6
            Me.chkbRememberLastTreeNode.Text = "Remember last opened node"
            Me.chkbRememberLastTreeNode.UseVisualStyleBackColor = False
            '
            'chkbRememberTreeViewState
            '
            Me.chkbRememberTreeViewState.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbRememberTreeViewState.Checked = True
            Me.chkbRememberTreeViewState.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbRememberTreeViewState.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbRememberTreeViewState.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbRememberTreeViewState.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbRememberTreeViewState.Location = New Global.System.Drawing.Point(32, 208)
            Me.chkbRememberTreeViewState.Name = "chkbRememberTreeViewState"
            Me.chkbRememberTreeViewState.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbRememberTreeViewState.TabIndex = 7
            Me.chkbRememberTreeViewState.Text = "Remember treeview state"
            Me.chkbRememberTreeViewState.UseVisualStyleBackColor = False
            '
            'tabpagProjectManager
            '
            Me.tabpagProjectManager.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagProjectManager.Controls.Add(Me.GroupBox1)
            Me.tabpagProjectManager.Controls.Add(Me.GroupBox2)
            Me.tabpagProjectManager.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagProjectManager.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagProjectManager.Name = "tabpagProjectManager"
            Me.tabpagProjectManager.Padding = New Global.System.Windows.Forms.Padding(16, 16, 16, 16)
            Me.tabpagProjectManager.Size = New Global.System.Drawing.Size(476, 250)
            Me.tabpagProjectManager.TabIndex = 2
            Me.tabpagProjectManager.Text = "Project Manager"
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.GroupBox1.Controls.Add(Me.btnBrowseProjMgrDLGEditorPath)
            Me.GroupBox1.Controls.Add(Me.tbProjMgrDLGEditorPath)
            Me.GroupBox1.Controls.Add(Me.rbProjMgrUseInternDLGEditor)
            Me.GroupBox1.Controls.Add(Me.rbProjMgrUseExternDLGEditor)
            Me.GroupBox1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox1.Location = New Global.System.Drawing.Point(18, 16)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New Global.System.Drawing.Size(440, 86)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Dialog Editor"
            '
            'btnBrowseProjMgrDLGEditorPath
            '
            Me.btnBrowseProjMgrDLGEditorPath.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnBrowseProjMgrDLGEditorPath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.Enabled = False
            Me.btnBrowseProjMgrDLGEditorPath.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnBrowseProjMgrDLGEditorPath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBrowseProjMgrDLGEditorPath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.Location = New Global.System.Drawing.Point(398, 52)
            Me.btnBrowseProjMgrDLGEditorPath.Name = "btnBrowseProjMgrDLGEditorPath"
            Me.btnBrowseProjMgrDLGEditorPath.Size = New Global.System.Drawing.Size(26, 22)
            Me.btnBrowseProjMgrDLGEditorPath.TabIndex = 3
            Me.btnBrowseProjMgrDLGEditorPath.Text = "..."
            Me.btnBrowseProjMgrDLGEditorPath.UseVisualStyleBackColor = False
            '
            'tbProjMgrDLGEditorPath
            '
            Me.tbProjMgrDLGEditorPath.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbProjMgrDLGEditorPath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbProjMgrDLGEditorPath.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbProjMgrDLGEditorPath.Enabled = False
            Me.tbProjMgrDLGEditorPath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbProjMgrDLGEditorPath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbProjMgrDLGEditorPath.Location = New Global.System.Drawing.Point(102, 52)
            Me.tbProjMgrDLGEditorPath.Name = "tbProjMgrDLGEditorPath"
            Me.tbProjMgrDLGEditorPath.Size = New Global.System.Drawing.Size(288, 22)
            Me.tbProjMgrDLGEditorPath.TabIndex = 2
            Me.tbProjMgrDLGEditorPath.Text = ""
            '
            'rbProjMgrUseInternDLGEditor
            '
            Me.rbProjMgrUseInternDLGEditor.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbProjMgrUseInternDLGEditor.Checked = True
            Me.rbProjMgrUseInternDLGEditor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.rbProjMgrUseInternDLGEditor.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProjMgrUseInternDLGEditor.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbProjMgrUseInternDLGEditor.Location = New Global.System.Drawing.Point(22, 22)
            Me.rbProjMgrUseInternDLGEditor.Name = "rbProjMgrUseInternDLGEditor"
            Me.rbProjMgrUseInternDLGEditor.Size = New Global.System.Drawing.Size(84, 22)
            Me.rbProjMgrUseInternDLGEditor.TabIndex = 0
            Me.rbProjMgrUseInternDLGEditor.TabStop = True
            Me.rbProjMgrUseInternDLGEditor.Text = "Internal"
            Me.rbProjMgrUseInternDLGEditor.UseVisualStyleBackColor = False
            '
            'rbProjMgrUseExternDLGEditor
            '
            Me.rbProjMgrUseExternDLGEditor.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbProjMgrUseExternDLGEditor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.rbProjMgrUseExternDLGEditor.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProjMgrUseExternDLGEditor.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbProjMgrUseExternDLGEditor.Location = New Global.System.Drawing.Point(22, 51)
            Me.rbProjMgrUseExternDLGEditor.Name = "rbProjMgrUseExternDLGEditor"
            Me.rbProjMgrUseExternDLGEditor.Size = New Global.System.Drawing.Size(84, 22)
            Me.rbProjMgrUseExternDLGEditor.TabIndex = 1
            Me.rbProjMgrUseExternDLGEditor.Text = "External"
            Me.rbProjMgrUseExternDLGEditor.UseVisualStyleBackColor = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.GroupBox2.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.GroupBox2.Controls.Add(Me.rbProjMgrUseInternTxtEditor)
            Me.GroupBox2.Controls.Add(Me.tbProjMgrTxtEditorPath)
            Me.GroupBox2.Controls.Add(Me.rbProjMgrUseExternTxtEditor)
            Me.GroupBox2.Controls.Add(Me.btnBrowseProjMgrTxtEditorPath)
            Me.GroupBox2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox2.Location = New Global.System.Drawing.Point(18, 118)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New Global.System.Drawing.Size(440, 86)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Text/NSS Editor"
            '
            'rbProjMgrUseInternTxtEditor
            '
            Me.rbProjMgrUseInternTxtEditor.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbProjMgrUseInternTxtEditor.Checked = True
            Me.rbProjMgrUseInternTxtEditor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.rbProjMgrUseInternTxtEditor.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProjMgrUseInternTxtEditor.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbProjMgrUseInternTxtEditor.Location = New Global.System.Drawing.Point(22, 22)
            Me.rbProjMgrUseInternTxtEditor.Name = "rbProjMgrUseInternTxtEditor"
            Me.rbProjMgrUseInternTxtEditor.Size = New Global.System.Drawing.Size(84, 22)
            Me.rbProjMgrUseInternTxtEditor.TabIndex = 0
            Me.rbProjMgrUseInternTxtEditor.TabStop = True
            Me.rbProjMgrUseInternTxtEditor.Text = "Internal"
            Me.rbProjMgrUseInternTxtEditor.UseVisualStyleBackColor = False
            '
            'tbProjMgrTxtEditorPath
            '
            Me.tbProjMgrTxtEditorPath.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbProjMgrTxtEditorPath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbProjMgrTxtEditorPath.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbProjMgrTxtEditorPath.Enabled = False
            Me.tbProjMgrTxtEditorPath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbProjMgrTxtEditorPath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbProjMgrTxtEditorPath.Location = New Global.System.Drawing.Point(102, 52)
            Me.tbProjMgrTxtEditorPath.Name = "tbProjMgrTxtEditorPath"
            Me.tbProjMgrTxtEditorPath.Size = New Global.System.Drawing.Size(288, 22)
            Me.tbProjMgrTxtEditorPath.TabIndex = 2
            Me.tbProjMgrTxtEditorPath.Text = ""
            '
            'rbProjMgrUseExternTxtEditor
            '
            Me.rbProjMgrUseExternTxtEditor.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbProjMgrUseExternTxtEditor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.rbProjMgrUseExternTxtEditor.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProjMgrUseExternTxtEditor.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbProjMgrUseExternTxtEditor.Location = New Global.System.Drawing.Point(22, 51)
            Me.rbProjMgrUseExternTxtEditor.Name = "rbProjMgrUseExternTxtEditor"
            Me.rbProjMgrUseExternTxtEditor.Size = New Global.System.Drawing.Size(84, 22)
            Me.rbProjMgrUseExternTxtEditor.TabIndex = 1
            Me.rbProjMgrUseExternTxtEditor.Text = "External"
            Me.rbProjMgrUseExternTxtEditor.UseVisualStyleBackColor = False
            '
            'btnBrowseProjMgrTxtEditorPath
            '
            Me.btnBrowseProjMgrTxtEditorPath.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnBrowseProjMgrTxtEditorPath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.Enabled = False
            Me.btnBrowseProjMgrTxtEditorPath.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnBrowseProjMgrTxtEditorPath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBrowseProjMgrTxtEditorPath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.Location = New Global.System.Drawing.Point(398, 52)
            Me.btnBrowseProjMgrTxtEditorPath.Name = "btnBrowseProjMgrTxtEditorPath"
            Me.btnBrowseProjMgrTxtEditorPath.Size = New Global.System.Drawing.Size(26, 22)
            Me.btnBrowseProjMgrTxtEditorPath.TabIndex = 3
            Me.btnBrowseProjMgrTxtEditorPath.Text = "..."
            Me.btnBrowseProjMgrTxtEditorPath.UseVisualStyleBackColor = False
            '
            'tabpagOther
            '
            Me.tabpagOther.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagOther.Controls.Add(Me.chkbTextEditorWordWrap)
            Me.tabpagOther.Controls.Add(Me.chkbDockImageViewer)
            Me.tabpagOther.Controls.Add(Me.chkbCheckForUpdatesAtStartup)
            Me.tabpagOther.Controls.Add(Me.chkbDownloadUpdatesAutomatically)
            Me.tabpagOther.Controls.Add(Me.chkbUseOverrideFiles)
            Me.tabpagOther.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagOther.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagOther.Name = "tabpagOther"
            Me.tabpagOther.Padding = New Global.System.Windows.Forms.Padding(18, 18, 18, 18)
            Me.tabpagOther.Size = New Global.System.Drawing.Size(476, 250)
            Me.tabpagOther.TabIndex = 1
            Me.tabpagOther.Text = "Other"
            '
            'chkbTextEditorWordWrap
            '
            Me.chkbTextEditorWordWrap.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbTextEditorWordWrap.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbTextEditorWordWrap.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbTextEditorWordWrap.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbTextEditorWordWrap.Location = New Global.System.Drawing.Point(32, 50)
            Me.chkbTextEditorWordWrap.Name = "chkbTextEditorWordWrap"
            Me.chkbTextEditorWordWrap.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbTextEditorWordWrap.TabIndex = 1
            Me.chkbTextEditorWordWrap.Text = "Word Wrap on by default in text editor"
            Me.chkbTextEditorWordWrap.UseVisualStyleBackColor = False
            '
            'chkbDockImageViewer
            '
            Me.chkbDockImageViewer.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbDockImageViewer.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbDockImageViewer.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbDockImageViewer.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbDockImageViewer.Location = New Global.System.Drawing.Point(32, 21)
            Me.chkbDockImageViewer.Name = "chkbDockImageViewer"
            Me.chkbDockImageViewer.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbDockImageViewer.TabIndex = 0
            Me.chkbDockImageViewer.Text = "Dock Image Viewer to Main window"
            Me.chkbDockImageViewer.UseVisualStyleBackColor = False
            '
            'chkbCheckForUpdatesAtStartup
            '
            Me.chkbCheckForUpdatesAtStartup.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbCheckForUpdatesAtStartup.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbCheckForUpdatesAtStartup.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbCheckForUpdatesAtStartup.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbCheckForUpdatesAtStartup.Location = New Global.System.Drawing.Point(32, 79)
            Me.chkbCheckForUpdatesAtStartup.Name = "chkbCheckForUpdatesAtStartup"
            Me.chkbCheckForUpdatesAtStartup.Size = New Global.System.Drawing.Size(300, 22)
            Me.chkbCheckForUpdatesAtStartup.TabIndex = 2
            Me.chkbCheckForUpdatesAtStartup.Text = "Check for program updates at startup"
            Me.chkbCheckForUpdatesAtStartup.UseVisualStyleBackColor = False
            '
            'chkbDownloadUpdatesAutomatically
            '
            Me.chkbDownloadUpdatesAutomatically.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbDownloadUpdatesAutomatically.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbDownloadUpdatesAutomatically.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbDownloadUpdatesAutomatically.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.chkbDownloadUpdatesAutomatically.Location = New Global.System.Drawing.Point(56, 106)
            Me.chkbDownloadUpdatesAutomatically.Name = "chkbDownloadUpdatesAutomatically"
            Me.chkbDownloadUpdatesAutomatically.Size = New Global.System.Drawing.Size(280, 22)
            Me.chkbDownloadUpdatesAutomatically.TabIndex = 3
            Me.chkbDownloadUpdatesAutomatically.Text = "Download updates automatically"
            Me.chkbDownloadUpdatesAutomatically.UseVisualStyleBackColor = False
            '
            'chkbUseOverrideFiles
            '
            Me.chkbUseOverrideFiles.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbUseOverrideFiles.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbUseOverrideFiles.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUseOverrideFiles.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUseOverrideFiles.Location = New Global.System.Drawing.Point(32, 138)
            Me.chkbUseOverrideFiles.Name = "chkbUseOverrideFiles"
            Me.chkbUseOverrideFiles.Size = New Global.System.Drawing.Size(360, 22)
            Me.chkbUseOverrideFiles.TabIndex = 4
            Me.chkbUseOverrideFiles.Text = "Look in Game's Override folder for 2DA files"
            Me.chkbUseOverrideFiles.UseVisualStyleBackColor = False
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 388)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(520, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCancel.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New Global.System.Drawing.Point(412, 20)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New Global.System.Drawing.Size(76, 26)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New Global.System.Drawing.Point(328, 20)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New Global.System.Drawing.Size(76, 26)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New Global.System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New Global.System.Drawing.Size(520, 1)
            Me.lblFooterSeparator.TabIndex = 2
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderSeparator)
            Me.pnlHeader.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New Global.System.Drawing.Size(520, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(24, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(464, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Configure treeview, Project Manager, editor, update, and override behaviours."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(22, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(464, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Options"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New Global.System.Drawing.Size(520, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmOptions
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(520, 450)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New Global.System.Drawing.Size(520, 450)
            Me.Name = "frmOptions"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Options"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tabpagTreeview.ResumeLayout(False)
            Me.tabpagProjectManager.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.tabpagOther.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)

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