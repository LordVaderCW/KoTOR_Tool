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
        Friend WithEvents TabControl1 As Global.kotor_tool.CustomTabControl
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
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TabControl1 = New kotor_tool.CustomTabControl()
            Me.tabpagTreeview = New System.Windows.Forms.TabPage()
            Me.chkbBuildModelsBifNode = New System.Windows.Forms.CheckBox()
            Me.chkbAlwaysConvertTPC2TGA = New System.Windows.Forms.CheckBox()
            Me.chkbBuildBIFTreeAtStartup = New System.Windows.Forms.CheckBox()
            Me.chkbAlwaysUnknownGFFasText = New System.Windows.Forms.CheckBox()
            Me.chkbShowModuleLocations = New System.Windows.Forms.CheckBox()
            Me.chkbShowModuleDescriptions = New System.Windows.Forms.CheckBox()
            Me.chkbRememberLastTreeNode = New System.Windows.Forms.CheckBox()
            Me.chkbRememberTreeViewState = New System.Windows.Forms.CheckBox()
            Me.tabpagProjectManager = New System.Windows.Forms.TabPage()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnBrowseProjMgrDLGEditorPath = New System.Windows.Forms.Button()
            Me.tbProjMgrDLGEditorPath = New System.Windows.Forms.TextBox()
            Me.rbProjMgrUseInternDLGEditor = New System.Windows.Forms.RadioButton()
            Me.rbProjMgrUseExternDLGEditor = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rbProjMgrUseInternTxtEditor = New System.Windows.Forms.RadioButton()
            Me.tbProjMgrTxtEditorPath = New System.Windows.Forms.TextBox()
            Me.rbProjMgrUseExternTxtEditor = New System.Windows.Forms.RadioButton()
            Me.btnBrowseProjMgrTxtEditorPath = New System.Windows.Forms.Button()
            Me.tabpagOther = New System.Windows.Forms.TabPage()
            Me.chkbTextEditorWordWrap = New System.Windows.Forms.CheckBox()
            Me.chkbDockImageViewer = New System.Windows.Forms.CheckBox()
            Me.chkbCheckForUpdatesAtStartup = New System.Windows.Forms.CheckBox()
            Me.chkbDownloadUpdatesAutomatically = New System.Windows.Forms.CheckBox()
            Me.chkbUseOverrideFiles = New System.Windows.Forms.CheckBox()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.lblFooterSeparator = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New System.Windows.Forms.Label()
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
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(520, 450)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(18)
            Me.pnlBody.Size = New System.Drawing.Size(520, 312)
            Me.pnlBody.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.TabControl1.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.Controls.Add(Me.tabpagTreeview)
            Me.TabControl1.Controls.Add(Me.tabpagProjectManager)
            Me.TabControl1.Controls.Add(Me.tabpagOther)
            Me.TabControl1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.TabControl1.DividerColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
            Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.ItemSize = New System.Drawing.Size(88, 31)
            Me.TabControl1.Location = New System.Drawing.Point(18, 18)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.NormalTabBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.TabControl1.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.TabControl1.OuterNativeBorderBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.TabControl1.Padding = New System.Drawing.Point(10, 3)
            Me.TabControl1.PageChromeBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.PageEdgeArtifactBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.PageInsetBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.SelectedTabBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.SelectedTabBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.TabControl1.SelectedTabButtonBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.TabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabControl1.Size = New System.Drawing.Size(484, 276)
            Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(115, Byte), Integer))
            Me.TabControl1.TabButtonBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(115, Byte), Integer))
            Me.TabControl1.TabChromeBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.TabControl1.TabIndex = 0
            Me.TabControl1.TabNativeBorderBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.TabNativeInsetBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.TabControl1.TabPageBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.TabStripBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            '
            'tabpagTreeview
            '
            Me.tabpagTreeview.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagTreeview.Controls.Add(Me.chkbBuildModelsBifNode)
            Me.tabpagTreeview.Controls.Add(Me.chkbAlwaysConvertTPC2TGA)
            Me.tabpagTreeview.Controls.Add(Me.chkbBuildBIFTreeAtStartup)
            Me.tabpagTreeview.Controls.Add(Me.chkbAlwaysUnknownGFFasText)
            Me.tabpagTreeview.Controls.Add(Me.chkbShowModuleLocations)
            Me.tabpagTreeview.Controls.Add(Me.chkbShowModuleDescriptions)
            Me.tabpagTreeview.Controls.Add(Me.chkbRememberLastTreeNode)
            Me.tabpagTreeview.Controls.Add(Me.chkbRememberTreeViewState)
            Me.tabpagTreeview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagTreeview.Location = New System.Drawing.Point(4, 35)
            Me.tabpagTreeview.Name = "tabpagTreeview"
            Me.tabpagTreeview.Padding = New System.Windows.Forms.Padding(18)
            Me.tabpagTreeview.Size = New System.Drawing.Size(476, 237)
            Me.tabpagTreeview.TabIndex = 0
            Me.tabpagTreeview.Text = "Treeview"
            '
            'chkbBuildModelsBifNode
            '
            Me.chkbBuildModelsBifNode.BackColor = System.Drawing.Color.Transparent
            Me.chkbBuildModelsBifNode.Checked = True
            Me.chkbBuildModelsBifNode.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbBuildModelsBifNode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbBuildModelsBifNode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbBuildModelsBifNode.Location = New System.Drawing.Point(32, 46)
            Me.chkbBuildModelsBifNode.Name = "chkbBuildModelsBifNode"
            Me.chkbBuildModelsBifNode.Size = New System.Drawing.Size(280, 22)
            Me.chkbBuildModelsBifNode.TabIndex = 1
            Me.chkbBuildModelsBifNode.Text = "Build Model BIF node in Tree"
            Me.chkbBuildModelsBifNode.UseVisualStyleBackColor = False
            '
            'chkbAlwaysConvertTPC2TGA
            '
            Me.chkbAlwaysConvertTPC2TGA.BackColor = System.Drawing.Color.Transparent
            Me.chkbAlwaysConvertTPC2TGA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbAlwaysConvertTPC2TGA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAlwaysConvertTPC2TGA.Location = New System.Drawing.Point(32, 100)
            Me.chkbAlwaysConvertTPC2TGA.Name = "chkbAlwaysConvertTPC2TGA"
            Me.chkbAlwaysConvertTPC2TGA.Size = New System.Drawing.Size(320, 22)
            Me.chkbAlwaysConvertTPC2TGA.TabIndex = 3
            Me.chkbAlwaysConvertTPC2TGA.Text = "Always convert TPC files to TGA upon extract"
            Me.chkbAlwaysConvertTPC2TGA.UseVisualStyleBackColor = False
            '
            'chkbBuildBIFTreeAtStartup
            '
            Me.chkbBuildBIFTreeAtStartup.BackColor = System.Drawing.Color.Transparent
            Me.chkbBuildBIFTreeAtStartup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbBuildBIFTreeAtStartup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbBuildBIFTreeAtStartup.Location = New System.Drawing.Point(32, 19)
            Me.chkbBuildBIFTreeAtStartup.Name = "chkbBuildBIFTreeAtStartup"
            Me.chkbBuildBIFTreeAtStartup.Size = New System.Drawing.Size(280, 22)
            Me.chkbBuildBIFTreeAtStartup.TabIndex = 0
            Me.chkbBuildBIFTreeAtStartup.Text = "Build BIF Tree at startup"
            Me.chkbBuildBIFTreeAtStartup.UseVisualStyleBackColor = False
            '
            'chkbAlwaysUnknownGFFasText
            '
            Me.chkbAlwaysUnknownGFFasText.BackColor = System.Drawing.Color.Transparent
            Me.chkbAlwaysUnknownGFFasText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbAlwaysUnknownGFFasText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAlwaysUnknownGFFasText.Location = New System.Drawing.Point(32, 73)
            Me.chkbAlwaysUnknownGFFasText.Name = "chkbAlwaysUnknownGFFasText"
            Me.chkbAlwaysUnknownGFFasText.Size = New System.Drawing.Size(330, 22)
            Me.chkbAlwaysUnknownGFFasText.TabIndex = 2
            Me.chkbAlwaysUnknownGFFasText.Text = "Double-click opens unsupported GFFs as Text"
            Me.chkbAlwaysUnknownGFFasText.UseVisualStyleBackColor = False
            '
            'chkbShowModuleLocations
            '
            Me.chkbShowModuleLocations.BackColor = System.Drawing.Color.Transparent
            Me.chkbShowModuleLocations.Checked = True
            Me.chkbShowModuleLocations.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbShowModuleLocations.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbShowModuleLocations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbShowModuleLocations.Location = New System.Drawing.Point(32, 154)
            Me.chkbShowModuleLocations.Name = "chkbShowModuleLocations"
            Me.chkbShowModuleLocations.Size = New System.Drawing.Size(280, 22)
            Me.chkbShowModuleLocations.TabIndex = 5
            Me.chkbShowModuleLocations.Text = "Show Module Locations"
            Me.chkbShowModuleLocations.UseVisualStyleBackColor = False
            '
            'chkbShowModuleDescriptions
            '
            Me.chkbShowModuleDescriptions.BackColor = System.Drawing.Color.Transparent
            Me.chkbShowModuleDescriptions.Checked = True
            Me.chkbShowModuleDescriptions.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbShowModuleDescriptions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbShowModuleDescriptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbShowModuleDescriptions.Location = New System.Drawing.Point(32, 127)
            Me.chkbShowModuleDescriptions.Name = "chkbShowModuleDescriptions"
            Me.chkbShowModuleDescriptions.Size = New System.Drawing.Size(280, 22)
            Me.chkbShowModuleDescriptions.TabIndex = 4
            Me.chkbShowModuleDescriptions.Text = "Show Module Descriptions"
            Me.chkbShowModuleDescriptions.UseVisualStyleBackColor = False
            '
            'chkbRememberLastTreeNode
            '
            Me.chkbRememberLastTreeNode.BackColor = System.Drawing.Color.Transparent
            Me.chkbRememberLastTreeNode.Checked = True
            Me.chkbRememberLastTreeNode.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbRememberLastTreeNode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbRememberLastTreeNode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbRememberLastTreeNode.Location = New System.Drawing.Point(32, 181)
            Me.chkbRememberLastTreeNode.Name = "chkbRememberLastTreeNode"
            Me.chkbRememberLastTreeNode.Size = New System.Drawing.Size(280, 22)
            Me.chkbRememberLastTreeNode.TabIndex = 6
            Me.chkbRememberLastTreeNode.Text = "Remember last opened node"
            Me.chkbRememberLastTreeNode.UseVisualStyleBackColor = False
            '
            'chkbRememberTreeViewState
            '
            Me.chkbRememberTreeViewState.BackColor = System.Drawing.Color.Transparent
            Me.chkbRememberTreeViewState.Checked = True
            Me.chkbRememberTreeViewState.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbRememberTreeViewState.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbRememberTreeViewState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbRememberTreeViewState.Location = New System.Drawing.Point(32, 208)
            Me.chkbRememberTreeViewState.Name = "chkbRememberTreeViewState"
            Me.chkbRememberTreeViewState.Size = New System.Drawing.Size(280, 22)
            Me.chkbRememberTreeViewState.TabIndex = 7
            Me.chkbRememberTreeViewState.Text = "Remember treeview state"
            Me.chkbRememberTreeViewState.UseVisualStyleBackColor = False
            '
            'tabpagProjectManager
            '
            Me.tabpagProjectManager.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagProjectManager.Controls.Add(Me.GroupBox1)
            Me.tabpagProjectManager.Controls.Add(Me.GroupBox2)
            Me.tabpagProjectManager.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagProjectManager.Location = New System.Drawing.Point(4, 35)
            Me.tabpagProjectManager.Name = "tabpagProjectManager"
            Me.tabpagProjectManager.Padding = New System.Windows.Forms.Padding(16)
            Me.tabpagProjectManager.Size = New System.Drawing.Size(476, 237)
            Me.tabpagProjectManager.TabIndex = 2
            Me.tabpagProjectManager.Text = "Project Manager"
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.GroupBox1.Controls.Add(Me.btnBrowseProjMgrDLGEditorPath)
            Me.GroupBox1.Controls.Add(Me.tbProjMgrDLGEditorPath)
            Me.GroupBox1.Controls.Add(Me.rbProjMgrUseInternDLGEditor)
            Me.GroupBox1.Controls.Add(Me.rbProjMgrUseExternDLGEditor)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox1.Location = New System.Drawing.Point(18, 16)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(440, 86)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Dialog Editor"
            '
            'btnBrowseProjMgrDLGEditorPath
            '
            Me.btnBrowseProjMgrDLGEditorPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnBrowseProjMgrDLGEditorPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.Enabled = False
            Me.btnBrowseProjMgrDLGEditorPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBrowseProjMgrDLGEditorPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBrowseProjMgrDLGEditorPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnBrowseProjMgrDLGEditorPath.Location = New System.Drawing.Point(398, 52)
            Me.btnBrowseProjMgrDLGEditorPath.Name = "btnBrowseProjMgrDLGEditorPath"
            Me.btnBrowseProjMgrDLGEditorPath.Size = New System.Drawing.Size(26, 22)
            Me.btnBrowseProjMgrDLGEditorPath.TabIndex = 3
            Me.btnBrowseProjMgrDLGEditorPath.Text = "..."
            Me.btnBrowseProjMgrDLGEditorPath.UseVisualStyleBackColor = False
            '
            'tbProjMgrDLGEditorPath
            '
            Me.tbProjMgrDLGEditorPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbProjMgrDLGEditorPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbProjMgrDLGEditorPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbProjMgrDLGEditorPath.Enabled = False
            Me.tbProjMgrDLGEditorPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbProjMgrDLGEditorPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbProjMgrDLGEditorPath.Location = New System.Drawing.Point(102, 52)
            Me.tbProjMgrDLGEditorPath.Name = "tbProjMgrDLGEditorPath"
            Me.tbProjMgrDLGEditorPath.Size = New System.Drawing.Size(288, 22)
            Me.tbProjMgrDLGEditorPath.TabIndex = 2
            '
            'rbProjMgrUseInternDLGEditor
            '
            Me.rbProjMgrUseInternDLGEditor.BackColor = System.Drawing.Color.Transparent
            Me.rbProjMgrUseInternDLGEditor.Checked = True
            Me.rbProjMgrUseInternDLGEditor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProjMgrUseInternDLGEditor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbProjMgrUseInternDLGEditor.Location = New System.Drawing.Point(22, 22)
            Me.rbProjMgrUseInternDLGEditor.Name = "rbProjMgrUseInternDLGEditor"
            Me.rbProjMgrUseInternDLGEditor.Size = New System.Drawing.Size(84, 22)
            Me.rbProjMgrUseInternDLGEditor.TabIndex = 0
            Me.rbProjMgrUseInternDLGEditor.TabStop = True
            Me.rbProjMgrUseInternDLGEditor.Text = "Internal"
            Me.rbProjMgrUseInternDLGEditor.UseVisualStyleBackColor = False
            '
            'rbProjMgrUseExternDLGEditor
            '
            Me.rbProjMgrUseExternDLGEditor.BackColor = System.Drawing.Color.Transparent
            Me.rbProjMgrUseExternDLGEditor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProjMgrUseExternDLGEditor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbProjMgrUseExternDLGEditor.Location = New System.Drawing.Point(22, 51)
            Me.rbProjMgrUseExternDLGEditor.Name = "rbProjMgrUseExternDLGEditor"
            Me.rbProjMgrUseExternDLGEditor.Size = New System.Drawing.Size(84, 22)
            Me.rbProjMgrUseExternDLGEditor.TabIndex = 1
            Me.rbProjMgrUseExternDLGEditor.Text = "External"
            Me.rbProjMgrUseExternDLGEditor.UseVisualStyleBackColor = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.GroupBox2.Controls.Add(Me.rbProjMgrUseInternTxtEditor)
            Me.GroupBox2.Controls.Add(Me.tbProjMgrTxtEditorPath)
            Me.GroupBox2.Controls.Add(Me.rbProjMgrUseExternTxtEditor)
            Me.GroupBox2.Controls.Add(Me.btnBrowseProjMgrTxtEditorPath)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox2.Location = New System.Drawing.Point(18, 118)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(440, 86)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Text/NSS Editor"
            '
            'rbProjMgrUseInternTxtEditor
            '
            Me.rbProjMgrUseInternTxtEditor.BackColor = System.Drawing.Color.Transparent
            Me.rbProjMgrUseInternTxtEditor.Checked = True
            Me.rbProjMgrUseInternTxtEditor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProjMgrUseInternTxtEditor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbProjMgrUseInternTxtEditor.Location = New System.Drawing.Point(22, 22)
            Me.rbProjMgrUseInternTxtEditor.Name = "rbProjMgrUseInternTxtEditor"
            Me.rbProjMgrUseInternTxtEditor.Size = New System.Drawing.Size(84, 22)
            Me.rbProjMgrUseInternTxtEditor.TabIndex = 0
            Me.rbProjMgrUseInternTxtEditor.TabStop = True
            Me.rbProjMgrUseInternTxtEditor.Text = "Internal"
            Me.rbProjMgrUseInternTxtEditor.UseVisualStyleBackColor = False
            '
            'tbProjMgrTxtEditorPath
            '
            Me.tbProjMgrTxtEditorPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbProjMgrTxtEditorPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbProjMgrTxtEditorPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbProjMgrTxtEditorPath.Enabled = False
            Me.tbProjMgrTxtEditorPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbProjMgrTxtEditorPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbProjMgrTxtEditorPath.Location = New System.Drawing.Point(102, 52)
            Me.tbProjMgrTxtEditorPath.Name = "tbProjMgrTxtEditorPath"
            Me.tbProjMgrTxtEditorPath.Size = New System.Drawing.Size(288, 22)
            Me.tbProjMgrTxtEditorPath.TabIndex = 2
            '
            'rbProjMgrUseExternTxtEditor
            '
            Me.rbProjMgrUseExternTxtEditor.BackColor = System.Drawing.Color.Transparent
            Me.rbProjMgrUseExternTxtEditor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProjMgrUseExternTxtEditor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbProjMgrUseExternTxtEditor.Location = New System.Drawing.Point(22, 51)
            Me.rbProjMgrUseExternTxtEditor.Name = "rbProjMgrUseExternTxtEditor"
            Me.rbProjMgrUseExternTxtEditor.Size = New System.Drawing.Size(84, 22)
            Me.rbProjMgrUseExternTxtEditor.TabIndex = 1
            Me.rbProjMgrUseExternTxtEditor.Text = "External"
            Me.rbProjMgrUseExternTxtEditor.UseVisualStyleBackColor = False
            '
            'btnBrowseProjMgrTxtEditorPath
            '
            Me.btnBrowseProjMgrTxtEditorPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnBrowseProjMgrTxtEditorPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.Enabled = False
            Me.btnBrowseProjMgrTxtEditorPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBrowseProjMgrTxtEditorPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBrowseProjMgrTxtEditorPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnBrowseProjMgrTxtEditorPath.Location = New System.Drawing.Point(398, 52)
            Me.btnBrowseProjMgrTxtEditorPath.Name = "btnBrowseProjMgrTxtEditorPath"
            Me.btnBrowseProjMgrTxtEditorPath.Size = New System.Drawing.Size(26, 22)
            Me.btnBrowseProjMgrTxtEditorPath.TabIndex = 3
            Me.btnBrowseProjMgrTxtEditorPath.Text = "..."
            Me.btnBrowseProjMgrTxtEditorPath.UseVisualStyleBackColor = False
            '
            'tabpagOther
            '
            Me.tabpagOther.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagOther.Controls.Add(Me.chkbTextEditorWordWrap)
            Me.tabpagOther.Controls.Add(Me.chkbDockImageViewer)
            Me.tabpagOther.Controls.Add(Me.chkbCheckForUpdatesAtStartup)
            Me.tabpagOther.Controls.Add(Me.chkbDownloadUpdatesAutomatically)
            Me.tabpagOther.Controls.Add(Me.chkbUseOverrideFiles)
            Me.tabpagOther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagOther.Location = New System.Drawing.Point(4, 35)
            Me.tabpagOther.Name = "tabpagOther"
            Me.tabpagOther.Padding = New System.Windows.Forms.Padding(18)
            Me.tabpagOther.Size = New System.Drawing.Size(476, 237)
            Me.tabpagOther.TabIndex = 1
            Me.tabpagOther.Text = "Other"
            '
            'chkbTextEditorWordWrap
            '
            Me.chkbTextEditorWordWrap.BackColor = System.Drawing.Color.Transparent
            Me.chkbTextEditorWordWrap.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbTextEditorWordWrap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbTextEditorWordWrap.Location = New System.Drawing.Point(32, 50)
            Me.chkbTextEditorWordWrap.Name = "chkbTextEditorWordWrap"
            Me.chkbTextEditorWordWrap.Size = New System.Drawing.Size(280, 22)
            Me.chkbTextEditorWordWrap.TabIndex = 1
            Me.chkbTextEditorWordWrap.Text = "Word Wrap on by default in text editor"
            Me.chkbTextEditorWordWrap.UseVisualStyleBackColor = False
            '
            'chkbDockImageViewer
            '
            Me.chkbDockImageViewer.BackColor = System.Drawing.Color.Transparent
            Me.chkbDockImageViewer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbDockImageViewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbDockImageViewer.Location = New System.Drawing.Point(32, 21)
            Me.chkbDockImageViewer.Name = "chkbDockImageViewer"
            Me.chkbDockImageViewer.Size = New System.Drawing.Size(280, 22)
            Me.chkbDockImageViewer.TabIndex = 0
            Me.chkbDockImageViewer.Text = "Dock Image Viewer to Main window"
            Me.chkbDockImageViewer.UseVisualStyleBackColor = False
            '
            'chkbCheckForUpdatesAtStartup
            '
            Me.chkbCheckForUpdatesAtStartup.BackColor = System.Drawing.Color.Transparent
            Me.chkbCheckForUpdatesAtStartup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbCheckForUpdatesAtStartup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbCheckForUpdatesAtStartup.Location = New System.Drawing.Point(32, 79)
            Me.chkbCheckForUpdatesAtStartup.Name = "chkbCheckForUpdatesAtStartup"
            Me.chkbCheckForUpdatesAtStartup.Size = New System.Drawing.Size(300, 22)
            Me.chkbCheckForUpdatesAtStartup.TabIndex = 2
            Me.chkbCheckForUpdatesAtStartup.Text = "Check for program updates at startup"
            Me.chkbCheckForUpdatesAtStartup.UseVisualStyleBackColor = False
            '
            'chkbDownloadUpdatesAutomatically
            '
            Me.chkbDownloadUpdatesAutomatically.BackColor = System.Drawing.Color.Transparent
            Me.chkbDownloadUpdatesAutomatically.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbDownloadUpdatesAutomatically.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.chkbDownloadUpdatesAutomatically.Location = New System.Drawing.Point(56, 106)
            Me.chkbDownloadUpdatesAutomatically.Name = "chkbDownloadUpdatesAutomatically"
            Me.chkbDownloadUpdatesAutomatically.Size = New System.Drawing.Size(280, 22)
            Me.chkbDownloadUpdatesAutomatically.TabIndex = 3
            Me.chkbDownloadUpdatesAutomatically.Text = "Download updates automatically"
            Me.chkbDownloadUpdatesAutomatically.UseVisualStyleBackColor = False
            '
            'chkbUseOverrideFiles
            '
            Me.chkbUseOverrideFiles.BackColor = System.Drawing.Color.Transparent
            Me.chkbUseOverrideFiles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUseOverrideFiles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUseOverrideFiles.Location = New System.Drawing.Point(32, 138)
            Me.chkbUseOverrideFiles.Name = "chkbUseOverrideFiles"
            Me.chkbUseOverrideFiles.Size = New System.Drawing.Size(360, 22)
            Me.chkbUseOverrideFiles.TabIndex = 4
            Me.chkbUseOverrideFiles.Text = "Look in Game's Override folder for 2DA files"
            Me.chkbUseOverrideFiles.UseVisualStyleBackColor = False
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 388)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(520, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(426, 15)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(76, 26)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(342, 15)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(76, 26)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New System.Drawing.Size(520, 1)
            Me.lblFooterSeparator.TabIndex = 2
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderSeparator)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(520, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(24, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(464, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Configure treeview, Project Manager, editor, update, and override behaviours."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(22, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(464, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Options"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 74)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(520, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmOptions
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(520, 450)
            Me.Controls.Add(Me.pnlRoot)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(520, 450)
            Me.Name = "frmOptions"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace