Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmUTI_Editor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderRule As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterRule As Global.System.Windows.Forms.Label

        Friend WithEvents TabControl1 As Global.kotor_tool.CustomTabControl
        Friend WithEvents tabpagGeneral As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagProperties As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagDescription As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagComments As Global.System.Windows.Forms.TabPage
        Friend WithEvents chkbPlotItem As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbStolen As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents tbUnidentifiedDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents tbLocalizedName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudCost As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudAdditionalCost As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents tbTemplateResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents tbIdentifiedDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label33 As Global.System.Windows.Forms.Label
        Friend WithEvents tbComment As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudModelVariation As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudStackSize As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxBaseItem As Global.System.Windows.Forms.ComboBox
        Friend WithEvents dgProperties As Global.System.Windows.Forms.DataGrid
        Friend WithEvents chkbIdentified As Global.System.Windows.Forms.CheckBox
        Friend WithEvents nudPaletteID As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents nudTextureVariation As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCharges As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudBodyVariation As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents lblTextureVariation As Global.System.Windows.Forms.Label
        Friend WithEvents lblBodyVariation As Global.System.Windows.Forms.Label
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents btnLoadXML As Global.System.Windows.Forms.Button
        Friend WithEvents btnSaveXML As Global.System.Windows.Forms.Button
        Friend WithEvents btnSetUnidentDescLang As Global.System.Windows.Forms.Button
        Friend WithEvents btnSetIdentDescLang As Global.System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As Global.System.Windows.Forms.ToolTip
        Friend WithEvents lblUpgradeLevel As Global.System.Windows.Forms.Label
        Friend WithEvents nudUpgradeLevel As Global.System.Windows.Forms.NumericUpDown

        ' Token: 0x06001380 RID: 4992 RVA: 0x002B0C00 File Offset: 0x002AFC00
        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x060013E1 RID: 5089 RVA: 0x002B16E0 File Offset: 0x002B06E0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUTI_Editor))
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TabControl1 = New kotor_tool.CustomTabControl()
            Me.tabpagGeneral = New System.Windows.Forms.TabPage()
            Me.cmbxBaseItem = New System.Windows.Forms.ComboBox()
            Me.nudCost = New System.Windows.Forms.NumericUpDown()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.tbTag = New System.Windows.Forms.TextBox()
            Me.chkbPlotItem = New System.Windows.Forms.CheckBox()
            Me.chkbStolen = New System.Windows.Forms.CheckBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.nudAdditionalCost = New System.Windows.Forms.NumericUpDown()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.nudTextureVariation = New System.Windows.Forms.NumericUpDown()
            Me.nudModelVariation = New System.Windows.Forms.NumericUpDown()
            Me.nudStackSize = New System.Windows.Forms.NumericUpDown()
            Me.lblTextureVariation = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.tbTemplateResRef = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.nudPaletteID = New System.Windows.Forms.NumericUpDown()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.nudCharges = New System.Windows.Forms.NumericUpDown()
            Me.nudBodyVariation = New System.Windows.Forms.NumericUpDown()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.lblBodyVariation = New System.Windows.Forms.Label()
            Me.lblUpgradeLevel = New System.Windows.Forms.Label()
            Me.nudUpgradeLevel = New System.Windows.Forms.NumericUpDown()
            Me.tabpagProperties = New System.Windows.Forms.TabPage()
            Me.btnLoadXML = New System.Windows.Forms.Button()
            Me.dgProperties = New System.Windows.Forms.DataGrid()
            Me.btnSaveXML = New System.Windows.Forms.Button()
            Me.tabpagDescription = New System.Windows.Forms.TabPage()
            Me.btnSetUnidentDescLang = New System.Windows.Forms.Button()
            Me.chkbIdentified = New System.Windows.Forms.CheckBox()
            Me.tbLocalizedName = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.tbUnidentifiedDescription = New System.Windows.Forms.TextBox()
            Me.tbIdentifiedDescription = New System.Windows.Forms.TextBox()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.btnSetIdentDescLang = New System.Windows.Forms.Button()
            Me.tabpagComments = New System.Windows.Forms.TabPage()
            Me.tbComment = New System.Windows.Forms.TextBox()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterRule = New System.Windows.Forms.Label()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderRule = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tabpagGeneral.SuspendLayout()
            CType(Me.nudCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudAdditionalCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTextureVariation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudModelVariation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStackSize, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudPaletteID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCharges, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudBodyVariation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUpgradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagProperties.SuspendLayout()
            CType(Me.dgProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagDescription.SuspendLayout()
            Me.tabpagComments.SuspendLayout()
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
            Me.pnlRoot.Size = New System.Drawing.Size(536, 509)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Controls.Add(Me.btnDebug)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 67)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
            Me.pnlBody.Size = New System.Drawing.Size(536, 380)
            Me.pnlBody.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.TabControl1.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.Controls.Add(Me.tabpagGeneral)
            Me.TabControl1.Controls.Add(Me.tabpagProperties)
            Me.TabControl1.Controls.Add(Me.tabpagDescription)
            Me.TabControl1.Controls.Add(Me.tabpagComments)
            Me.TabControl1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.TabControl1.DividerColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
            Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.TabControl1.ItemSize = New System.Drawing.Size(88, 31)
            Me.TabControl1.Location = New System.Drawing.Point(12, 10)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.NormalTabBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.TabControl1.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.TabControl1.OuterNativeBorderBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.TabControl1.Padding = New System.Drawing.Point(15, 3)
            Me.TabControl1.PageChromeBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.PageEdgeArtifactBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.PageInsetBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.SelectedTabBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabControl1.SelectedTabBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.TabControl1.SelectedTabButtonBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.TabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabControl1.Size = New System.Drawing.Size(512, 360)
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
            'tabpagGeneral
            '
            Me.tabpagGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagGeneral.Controls.Add(Me.cmbxBaseItem)
            Me.tabpagGeneral.Controls.Add(Me.nudCost)
            Me.tabpagGeneral.Controls.Add(Me.Label1)
            Me.tabpagGeneral.Controls.Add(Me.tbTag)
            Me.tabpagGeneral.Controls.Add(Me.chkbPlotItem)
            Me.tabpagGeneral.Controls.Add(Me.chkbStolen)
            Me.tabpagGeneral.Controls.Add(Me.Label2)
            Me.tabpagGeneral.Controls.Add(Me.Label3)
            Me.tabpagGeneral.Controls.Add(Me.nudAdditionalCost)
            Me.tabpagGeneral.Controls.Add(Me.Label5)
            Me.tabpagGeneral.Controls.Add(Me.nudTextureVariation)
            Me.tabpagGeneral.Controls.Add(Me.nudModelVariation)
            Me.tabpagGeneral.Controls.Add(Me.nudStackSize)
            Me.tabpagGeneral.Controls.Add(Me.lblTextureVariation)
            Me.tabpagGeneral.Controls.Add(Me.Label8)
            Me.tabpagGeneral.Controls.Add(Me.tbTemplateResRef)
            Me.tabpagGeneral.Controls.Add(Me.Label9)
            Me.tabpagGeneral.Controls.Add(Me.Label10)
            Me.tabpagGeneral.Controls.Add(Me.nudPaletteID)
            Me.tabpagGeneral.Controls.Add(Me.Label11)
            Me.tabpagGeneral.Controls.Add(Me.nudCharges)
            Me.tabpagGeneral.Controls.Add(Me.nudBodyVariation)
            Me.tabpagGeneral.Controls.Add(Me.Label12)
            Me.tabpagGeneral.Controls.Add(Me.lblBodyVariation)
            Me.tabpagGeneral.Controls.Add(Me.lblUpgradeLevel)
            Me.tabpagGeneral.Controls.Add(Me.nudUpgradeLevel)
            Me.tabpagGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagGeneral.Location = New System.Drawing.Point(4, 35)
            Me.tabpagGeneral.Name = "tabpagGeneral"
            Me.tabpagGeneral.Size = New System.Drawing.Size(504, 321)
            Me.tabpagGeneral.TabIndex = 0
            Me.tabpagGeneral.Text = "General"
            '
            'cmbxBaseItem
            '
            Me.cmbxBaseItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxBaseItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxBaseItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxBaseItem.Location = New System.Drawing.Point(109, 113)
            Me.cmbxBaseItem.Name = "cmbxBaseItem"
            Me.cmbxBaseItem.Size = New System.Drawing.Size(184, 21)
            Me.cmbxBaseItem.TabIndex = 4
            '
            'nudCost
            '
            Me.nudCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCost.Location = New System.Drawing.Point(109, 157)
            Me.nudCost.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudCost.Name = "nudCost"
            Me.nudCost.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudCost.Size = New System.Drawing.Size(64, 22)
            Me.nudCost.TabIndex = 3
            Me.nudCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label1
            '
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(16, 72)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(80, 18)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Tag"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbTag
            '
            Me.tbTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTag.Location = New System.Drawing.Point(109, 69)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(184, 22)
            Me.tbTag.TabIndex = 1
            '
            'chkbPlotItem
            '
            Me.chkbPlotItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbPlotItem.Location = New System.Drawing.Point(344, 24)
            Me.chkbPlotItem.Name = "chkbPlotItem"
            Me.chkbPlotItem.Size = New System.Drawing.Size(88, 28)
            Me.chkbPlotItem.TabIndex = 0
            Me.chkbPlotItem.Text = "Plot item"
            '
            'chkbStolen
            '
            Me.chkbStolen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbStolen.Location = New System.Drawing.Point(344, 67)
            Me.chkbStolen.Name = "chkbStolen"
            Me.chkbStolen.Size = New System.Drawing.Size(104, 28)
            Me.chkbStolen.TabIndex = 0
            Me.chkbStolen.Text = "Stolen"
            '
            'Label2
            '
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(16, 203)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(88, 19)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Additional Cost"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(16, 159)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(80, 19)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Cost"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudAdditionalCost
            '
            Me.nudAdditionalCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudAdditionalCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudAdditionalCost.Location = New System.Drawing.Point(109, 201)
            Me.nudAdditionalCost.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudAdditionalCost.Name = "nudAdditionalCost"
            Me.nudAdditionalCost.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudAdditionalCost.Size = New System.Drawing.Size(64, 22)
            Me.nudAdditionalCost.TabIndex = 3
            Me.nudAdditionalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(312, 203)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(88, 19)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Model Variation"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudTextureVariation
            '
            Me.nudTextureVariation.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudTextureVariation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudTextureVariation.Location = New System.Drawing.Point(408, 286)
            Me.nudTextureVariation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudTextureVariation.Name = "nudTextureVariation"
            Me.nudTextureVariation.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudTextureVariation.Size = New System.Drawing.Size(48, 22)
            Me.nudTextureVariation.TabIndex = 3
            Me.nudTextureVariation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudTextureVariation.Visible = False
            '
            'nudModelVariation
            '
            Me.nudModelVariation.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudModelVariation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudModelVariation.Location = New System.Drawing.Point(408, 201)
            Me.nudModelVariation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudModelVariation.Name = "nudModelVariation"
            Me.nudModelVariation.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudModelVariation.Size = New System.Drawing.Size(48, 22)
            Me.nudModelVariation.TabIndex = 3
            Me.nudModelVariation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudStackSize
            '
            Me.nudStackSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudStackSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudStackSize.Location = New System.Drawing.Point(408, 157)
            Me.nudStackSize.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudStackSize.Name = "nudStackSize"
            Me.nudStackSize.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudStackSize.Size = New System.Drawing.Size(48, 22)
            Me.nudStackSize.TabIndex = 3
            Me.nudStackSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblTextureVariation
            '
            Me.lblTextureVariation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblTextureVariation.Location = New System.Drawing.Point(312, 288)
            Me.lblTextureVariation.Name = "lblTextureVariation"
            Me.lblTextureVariation.Size = New System.Drawing.Size(96, 19)
            Me.lblTextureVariation.TabIndex = 2
            Me.lblTextureVariation.Text = "Texture Variation"
            Me.lblTextureVariation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblTextureVariation.Visible = False
            '
            'Label8
            '
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(312, 159)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(88, 19)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Stack localSize"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbTemplateResRef
            '
            Me.tbTemplateResRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTemplateResRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTemplateResRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbTemplateResRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTemplateResRef.Location = New System.Drawing.Point(109, 27)
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Me.tbTemplateResRef.Size = New System.Drawing.Size(184, 22)
            Me.tbTemplateResRef.TabIndex = 1
            '
            'Label9
            '
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(16, 28)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(96, 18)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Template ResRef"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label10
            '
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(16, 115)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(80, 19)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Base Item"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudPaletteID
            '
            Me.nudPaletteID.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudPaletteID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudPaletteID.Location = New System.Drawing.Point(109, 243)
            Me.nudPaletteID.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudPaletteID.Name = "nudPaletteID"
            Me.nudPaletteID.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudPaletteID.Size = New System.Drawing.Size(64, 22)
            Me.nudPaletteID.TabIndex = 3
            Me.nudPaletteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label11
            '
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(16, 246)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(80, 18)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Palette ID"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudCharges
            '
            Me.nudCharges.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCharges.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCharges.Location = New System.Drawing.Point(408, 113)
            Me.nudCharges.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCharges.Name = "nudCharges"
            Me.nudCharges.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudCharges.Size = New System.Drawing.Size(48, 22)
            Me.nudCharges.TabIndex = 3
            Me.nudCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudBodyVariation
            '
            Me.nudBodyVariation.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudBodyVariation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudBodyVariation.Location = New System.Drawing.Point(408, 243)
            Me.nudBodyVariation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudBodyVariation.Name = "nudBodyVariation"
            Me.nudBodyVariation.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudBodyVariation.Size = New System.Drawing.Size(48, 22)
            Me.nudBodyVariation.TabIndex = 3
            Me.nudBodyVariation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudBodyVariation.Visible = False
            '
            'Label12
            '
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(312, 115)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(88, 19)
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "Charges"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblBodyVariation
            '
            Me.lblBodyVariation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblBodyVariation.Location = New System.Drawing.Point(312, 246)
            Me.lblBodyVariation.Name = "lblBodyVariation"
            Me.lblBodyVariation.Size = New System.Drawing.Size(88, 18)
            Me.lblBodyVariation.TabIndex = 2
            Me.lblBodyVariation.Text = "Body Variation"
            Me.lblBodyVariation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblBodyVariation.Visible = False
            '
            'lblUpgradeLevel
            '
            Me.lblUpgradeLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblUpgradeLevel.Location = New System.Drawing.Point(16, 288)
            Me.lblUpgradeLevel.Name = "lblUpgradeLevel"
            Me.lblUpgradeLevel.Size = New System.Drawing.Size(88, 19)
            Me.lblUpgradeLevel.TabIndex = 2
            Me.lblUpgradeLevel.Text = "Upgrade Level"
            Me.lblUpgradeLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudUpgradeLevel
            '
            Me.nudUpgradeLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudUpgradeLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUpgradeLevel.Location = New System.Drawing.Point(109, 286)
            Me.nudUpgradeLevel.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudUpgradeLevel.Name = "nudUpgradeLevel"
            Me.nudUpgradeLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudUpgradeLevel.Size = New System.Drawing.Size(64, 22)
            Me.nudUpgradeLevel.TabIndex = 3
            Me.nudUpgradeLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'tabpagProperties
            '
            Me.tabpagProperties.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagProperties.Controls.Add(Me.btnLoadXML)
            Me.tabpagProperties.Controls.Add(Me.dgProperties)
            Me.tabpagProperties.Controls.Add(Me.btnSaveXML)
            Me.tabpagProperties.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagProperties.Location = New System.Drawing.Point(4, 22)
            Me.tabpagProperties.Name = "tabpagProperties"
            Me.tabpagProperties.Size = New System.Drawing.Size(504, 334)
            Me.tabpagProperties.TabIndex = 1
            Me.tabpagProperties.Text = "Properties"
            '
            'btnLoadXML
            '
            Me.btnLoadXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnLoadXML.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnLoadXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnLoadXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLoadXML.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnLoadXML.Location = New System.Drawing.Point(312, 287)
            Me.btnLoadXML.Name = "btnLoadXML"
            Me.btnLoadXML.Size = New System.Drawing.Size(75, 26)
            Me.btnLoadXML.TabIndex = 4
            Me.btnLoadXML.Text = "Load XML"
            Me.btnLoadXML.UseVisualStyleBackColor = False
            '
            'dgProperties
            '
            Me.dgProperties.AllowSorting = False
            Me.dgProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgProperties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.dgProperties.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgProperties.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgProperties.DataMember = ""
            Me.dgProperties.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.dgProperties.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgProperties.Location = New System.Drawing.Point(8, 18)
            Me.dgProperties.Name = "dgProperties"
            Me.dgProperties.Size = New System.Drawing.Size(488, 250)
            Me.dgProperties.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.dgProperties, "Double-click on the row header to edit an existing entry or on the '*' row header" &
        " to add a new entry")
            '
            'btnSaveXML
            '
            Me.btnSaveXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSaveXML.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSaveXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSaveXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveXML.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSaveXML.Location = New System.Drawing.Point(408, 287)
            Me.btnSaveXML.Name = "btnSaveXML"
            Me.btnSaveXML.Size = New System.Drawing.Size(75, 26)
            Me.btnSaveXML.TabIndex = 4
            Me.btnSaveXML.Text = "Save XML"
            Me.btnSaveXML.UseVisualStyleBackColor = False
            '
            'tabpagDescription
            '
            Me.tabpagDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagDescription.Controls.Add(Me.btnSetUnidentDescLang)
            Me.tabpagDescription.Controls.Add(Me.chkbIdentified)
            Me.tabpagDescription.Controls.Add(Me.tbLocalizedName)
            Me.tabpagDescription.Controls.Add(Me.Label4)
            Me.tabpagDescription.Controls.Add(Me.tbUnidentifiedDescription)
            Me.tabpagDescription.Controls.Add(Me.tbIdentifiedDescription)
            Me.tabpagDescription.Controls.Add(Me.Label33)
            Me.tabpagDescription.Controls.Add(Me.Label6)
            Me.tabpagDescription.Controls.Add(Me.btnSetIdentDescLang)
            Me.tabpagDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagDescription.Location = New System.Drawing.Point(4, 22)
            Me.tabpagDescription.Name = "tabpagDescription"
            Me.tabpagDescription.Size = New System.Drawing.Size(504, 334)
            Me.tabpagDescription.TabIndex = 2
            Me.tabpagDescription.Text = "Description"
            '
            'btnSetUnidentDescLang
            '
            Me.btnSetUnidentDescLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetUnidentDescLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetUnidentDescLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetUnidentDescLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetUnidentDescLang.Location = New System.Drawing.Point(128, 286)
            Me.btnSetUnidentDescLang.Name = "btnSetUnidentDescLang"
            Me.btnSetUnidentDescLang.Size = New System.Drawing.Size(96, 27)
            Me.btnSetUnidentDescLang.TabIndex = 4
            Me.btnSetUnidentDescLang.Text = "Set Language"
            Me.btnSetUnidentDescLang.UseVisualStyleBackColor = False
            '
            'chkbIdentified
            '
            Me.chkbIdentified.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbIdentified.Location = New System.Drawing.Point(344, 46)
            Me.chkbIdentified.Name = "chkbIdentified"
            Me.chkbIdentified.Size = New System.Drawing.Size(88, 28)
            Me.chkbIdentified.TabIndex = 3
            Me.chkbIdentified.Text = "Identified"
            '
            'tbLocalizedName
            '
            Me.tbLocalizedName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbLocalizedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbLocalizedName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbLocalizedName.Location = New System.Drawing.Point(24, 46)
            Me.tbLocalizedName.Name = "tbLocalizedName"
            Me.tbLocalizedName.Size = New System.Drawing.Size(272, 22)
            Me.tbLocalizedName.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(24, 102)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(160, 18)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Unidentified Description"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbUnidentifiedDescription
            '
            Me.tbUnidentifiedDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbUnidentifiedDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbUnidentifiedDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbUnidentifiedDescription.Location = New System.Drawing.Point(24, 129)
            Me.tbUnidentifiedDescription.Multiline = True
            Me.tbUnidentifiedDescription.Name = "tbUnidentifiedDescription"
            Me.tbUnidentifiedDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbUnidentifiedDescription.Size = New System.Drawing.Size(200, 139)
            Me.tbUnidentifiedDescription.TabIndex = 0
            '
            'tbIdentifiedDescription
            '
            Me.tbIdentifiedDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.tbIdentifiedDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbIdentifiedDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbIdentifiedDescription.Location = New System.Drawing.Point(272, 129)
            Me.tbIdentifiedDescription.Multiline = True
            Me.tbIdentifiedDescription.Name = "tbIdentifiedDescription"
            Me.tbIdentifiedDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbIdentifiedDescription.Size = New System.Drawing.Size(200, 139)
            Me.tbIdentifiedDescription.TabIndex = 0
            '
            'Label33
            '
            Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label33.Location = New System.Drawing.Point(272, 102)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(160, 18)
            Me.Label33.TabIndex = 1
            Me.Label33.Text = "Identified Description"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label6
            '
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(24, 18)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(136, 19)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "Name"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnSetIdentDescLang
            '
            Me.btnSetIdentDescLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetIdentDescLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetIdentDescLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetIdentDescLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetIdentDescLang.Location = New System.Drawing.Point(376, 286)
            Me.btnSetIdentDescLang.Name = "btnSetIdentDescLang"
            Me.btnSetIdentDescLang.Size = New System.Drawing.Size(96, 27)
            Me.btnSetIdentDescLang.TabIndex = 4
            Me.btnSetIdentDescLang.Text = "Set Language"
            Me.btnSetIdentDescLang.UseVisualStyleBackColor = False
            '
            'tabpagComments
            '
            Me.tabpagComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagComments.Controls.Add(Me.tbComment)
            Me.tabpagComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagComments.Location = New System.Drawing.Point(4, 22)
            Me.tabpagComments.Name = "tabpagComments"
            Me.tabpagComments.Size = New System.Drawing.Size(504, 334)
            Me.tabpagComments.TabIndex = 3
            Me.tabpagComments.Text = "Comment"
            '
            'tbComment
            '
            Me.tbComment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbComment.Location = New System.Drawing.Point(8, 9)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New System.Drawing.Size(488, 312)
            Me.tbComment.TabIndex = 0
            '
            'btnDebug
            '
            Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnDebug.Location = New System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 9)
            Me.btnDebug.TabIndex = 2
            Me.btnDebug.UseVisualStyleBackColor = False
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterRule)
            Me.pnlFooter.Controls.Add(Me.btnSave)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 447)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(536, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(536, 1)
            Me.lblFooterRule.TabIndex = 0
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSave.Location = New System.Drawing.Point(348, 18)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(80, 29)
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "&Save"
            Me.btnSave.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New System.Drawing.Point(440, 18)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(80, 29)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderRule)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(536, 67)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(18, 12)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(360, 23)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Item Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(20, 37)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(496, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Restored KoTOR Tool item editor."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 65)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(536, 2)
            Me.lblHeaderRule.TabIndex = 2
            '
            'frmUTI_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(536, 509)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(544, 548)
            Me.Name = "frmUTI_Editor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Item Editor - KotOR "
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tabpagGeneral.ResumeLayout(False)
            Me.tabpagGeneral.PerformLayout()
            CType(Me.nudCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudAdditionalCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTextureVariation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudModelVariation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStackSize, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudPaletteID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCharges, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudBodyVariation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUpgradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagProperties.ResumeLayout(False)
            CType(Me.dgProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagDescription.ResumeLayout(False)
            Me.tabpagDescription.PerformLayout()
            Me.tabpagComments.ResumeLayout(False)
            Me.tabpagComments.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
