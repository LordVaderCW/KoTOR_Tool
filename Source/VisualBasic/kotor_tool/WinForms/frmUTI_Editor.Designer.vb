Namespace kotor_tool
	' Token: 0x0200007F RID: 127
	Public Partial Class frmUTI_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
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
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060013E1 RID: 5089 RVA: 0x002B16E0 File Offset: 0x002B06E0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUTI_Editor))
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.tabpagGeneral = New Global.System.Windows.Forms.TabPage()
            Me.cmbxBaseItem = New Global.System.Windows.Forms.ComboBox()
            Me.nudCost = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.tbTag = New Global.System.Windows.Forms.TextBox()
            Me.chkbPlotItem = New Global.System.Windows.Forms.CheckBox()
            Me.chkbStolen = New Global.System.Windows.Forms.CheckBox()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.nudAdditionalCost = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.nudTextureVariation = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudModelVariation = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudStackSize = New Global.System.Windows.Forms.NumericUpDown()
            Me.lblTextureVariation = New Global.System.Windows.Forms.Label()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.tbTemplateResRef = New Global.System.Windows.Forms.TextBox()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.nudPaletteID = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.nudCharges = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudBodyVariation = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.lblBodyVariation = New Global.System.Windows.Forms.Label()
            Me.lblUpgradeLevel = New Global.System.Windows.Forms.Label()
            Me.nudUpgradeLevel = New Global.System.Windows.Forms.NumericUpDown()
            Me.tabpagProperties = New Global.System.Windows.Forms.TabPage()
            Me.btnLoadXML = New Global.System.Windows.Forms.Button()
            Me.dgProperties = New Global.System.Windows.Forms.DataGrid()
            Me.btnSaveXML = New Global.System.Windows.Forms.Button()
            Me.tabpagDescription = New Global.System.Windows.Forms.TabPage()
            Me.btnSetUnidentDescLang = New Global.System.Windows.Forms.Button()
            Me.chkbIdentified = New Global.System.Windows.Forms.CheckBox()
            Me.tbLocalizedName = New Global.System.Windows.Forms.TextBox()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.tbUnidentifiedDescription = New Global.System.Windows.Forms.TextBox()
            Me.tbIdentifiedDescription = New Global.System.Windows.Forms.TextBox()
            Me.Label33 = New Global.System.Windows.Forms.Label()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.btnSetIdentDescLang = New Global.System.Windows.Forms.Button()
            Me.tabpagComments = New Global.System.Windows.Forms.TabPage()
            Me.tbComment = New Global.System.Windows.Forms.TextBox()
            Me.btnSave = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnDebug = New Global.System.Windows.Forms.Button()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip()
            Me.TabControl1.SuspendLayout()
            Me.tabpagGeneral.SuspendLayout()
            CType(Me.nudCost, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudAdditionalCost, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTextureVariation, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudModelVariation, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStackSize, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudPaletteID, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCharges, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudBodyVariation, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUpgradeLevel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagProperties.SuspendLayout()
            CType(Me.dgProperties, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagDescription.SuspendLayout()
            Me.tabpagComments.SuspendLayout()
            Me.SuspendLayout()
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.tabpagGeneral)
            Me.TabControl1.Controls.Add(Me.tabpagProperties)
            Me.TabControl1.Controls.Add(Me.tabpagDescription)
            Me.TabControl1.Controls.Add(Me.tabpagComments)
            Me.TabControl1.ItemSize = New Global.System.Drawing.Size(49, 18)
            Me.TabControl1.Location = New Global.System.Drawing.Point(8, 32)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(488, 312)
            Me.TabControl1.TabIndex = 0
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
            Me.tabpagGeneral.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagGeneral.Name = "tabpagGeneral"
            Me.tabpagGeneral.Size = New Global.System.Drawing.Size(480, 286)
            Me.tabpagGeneral.TabIndex = 0
            Me.tabpagGeneral.Text = "General"
            Me.cmbxBaseItem.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxBaseItem.Location = New Global.System.Drawing.Point(109, 98)
            Me.cmbxBaseItem.Name = "cmbxBaseItem"
            Me.cmbxBaseItem.Size = New Global.System.Drawing.Size(184, 21)
            Me.cmbxBaseItem.TabIndex = 4
            Me.nudCost.Location = New Global.System.Drawing.Point(109, 136)
            Me.nudCost.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudCost.Name = "nudCost"
            Me.nudCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudCost.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudCost.TabIndex = 3
            Me.nudCost.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label1.Location = New Global.System.Drawing.Point(16, 62)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Tag"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbTag.Location = New Global.System.Drawing.Point(109, 60)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New Global.System.Drawing.Size(168, 20)
            Me.tbTag.TabIndex = 1
            Me.tbTag.Text = ""
            Me.chkbPlotItem.Location = New Global.System.Drawing.Point(344, 21)
            Me.chkbPlotItem.Name = "chkbPlotItem"
            Me.chkbPlotItem.Size = New Global.System.Drawing.Size(72, 24)
            Me.chkbPlotItem.TabIndex = 0
            Me.chkbPlotItem.Text = "Plot item"
            Me.chkbStolen.Location = New Global.System.Drawing.Point(344, 58)
            Me.chkbStolen.Name = "chkbStolen"
            Me.chkbStolen.TabIndex = 0
            Me.chkbStolen.Text = "Stolen"
            Me.Label2.Location = New Global.System.Drawing.Point(16, 176)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Additional Cost"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label3.Location = New Global.System.Drawing.Point(16, 138)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Cost"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudAdditionalCost.Location = New Global.System.Drawing.Point(109, 174)
            Me.nudAdditionalCost.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudAdditionalCost.Name = "nudAdditionalCost"
            Me.nudAdditionalCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudAdditionalCost.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudAdditionalCost.TabIndex = 3
            Me.nudAdditionalCost.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label5.Location = New Global.System.Drawing.Point(312, 176)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Model Variation"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudTextureVariation.Location = New Global.System.Drawing.Point(408, 248)
            Me.nudTextureVariation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudTextureVariation.Name = "nudTextureVariation"
            Me.nudTextureVariation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudTextureVariation.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudTextureVariation.TabIndex = 3
            Me.nudTextureVariation.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudTextureVariation.Visible = False
            Me.nudModelVariation.Location = New Global.System.Drawing.Point(408, 174)
            Me.nudModelVariation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudModelVariation.Name = "nudModelVariation"
            Me.nudModelVariation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudModelVariation.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudModelVariation.TabIndex = 3
            Me.nudModelVariation.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudStackSize.Location = New Global.System.Drawing.Point(408, 136)
            Me.nudStackSize.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudStackSize.Name = "nudStackSize"
            Me.nudStackSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudStackSize.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudStackSize.TabIndex = 3
            Me.nudStackSize.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblTextureVariation.Location = New Global.System.Drawing.Point(312, 250)
            Me.lblTextureVariation.Name = "lblTextureVariation"
            Me.lblTextureVariation.Size = New Global.System.Drawing.Size(96, 16)
            Me.lblTextureVariation.TabIndex = 2
            Me.lblTextureVariation.Text = "Texture Variation"
            Me.lblTextureVariation.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblTextureVariation.Visible = False
            Me.Label8.Location = New Global.System.Drawing.Point(312, 138)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Stack localSize"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbTemplateResRef.Location = New Global.System.Drawing.Point(109, 23)
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Me.tbTemplateResRef.Size = New Global.System.Drawing.Size(168, 20)
            Me.tbTemplateResRef.TabIndex = 1
            Me.tbTemplateResRef.Text = ""
            Me.Label9.Location = New Global.System.Drawing.Point(16, 24)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Template ResRef"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label10.Location = New Global.System.Drawing.Point(16, 100)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Base Item"
            Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudPaletteID.Location = New Global.System.Drawing.Point(125, 211)
            Me.nudPaletteID.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudPaletteID.Name = "nudPaletteID"
            Me.nudPaletteID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudPaletteID.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudPaletteID.TabIndex = 3
            Me.nudPaletteID.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label11.Location = New Global.System.Drawing.Point(16, 213)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Palette ID"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudCharges.Location = New Global.System.Drawing.Point(408, 98)
            Me.nudCharges.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCharges.Name = "nudCharges"
            Me.nudCharges.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudCharges.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudCharges.TabIndex = 3
            Me.nudCharges.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudBodyVariation.Location = New Global.System.Drawing.Point(408, 211)
            Me.nudBodyVariation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudBodyVariation.Name = "nudBodyVariation"
            Me.nudBodyVariation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudBodyVariation.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudBodyVariation.TabIndex = 3
            Me.nudBodyVariation.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudBodyVariation.Visible = False
            Me.Label12.Location = New Global.System.Drawing.Point(312, 100)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "Charges"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblBodyVariation.Location = New Global.System.Drawing.Point(312, 213)
            Me.lblBodyVariation.Name = "lblBodyVariation"
            Me.lblBodyVariation.Size = New Global.System.Drawing.Size(88, 16)
            Me.lblBodyVariation.TabIndex = 2
            Me.lblBodyVariation.Text = "Body Variation"
            Me.lblBodyVariation.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblBodyVariation.Visible = False
            Me.lblUpgradeLevel.Location = New Global.System.Drawing.Point(16, 250)
            Me.lblUpgradeLevel.Name = "lblUpgradeLevel"
            Me.lblUpgradeLevel.Size = New Global.System.Drawing.Size(80, 16)
            Me.lblUpgradeLevel.TabIndex = 2
            Me.lblUpgradeLevel.Text = "Upgrade Level"
            Me.lblUpgradeLevel.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudUpgradeLevel.Location = New Global.System.Drawing.Point(125, 248)
            Me.nudUpgradeLevel.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudUpgradeLevel.Name = "nudUpgradeLevel"
            Me.nudUpgradeLevel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudUpgradeLevel.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudUpgradeLevel.TabIndex = 3
            Me.nudUpgradeLevel.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tabpagProperties.Controls.Add(Me.btnLoadXML)
            Me.tabpagProperties.Controls.Add(Me.dgProperties)
            Me.tabpagProperties.Controls.Add(Me.btnSaveXML)
            Me.tabpagProperties.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagProperties.Name = "tabpagProperties"
            Me.tabpagProperties.Size = New Global.System.Drawing.Size(480, 286)
            Me.tabpagProperties.TabIndex = 1
            Me.tabpagProperties.Text = "Properties"
            Me.btnLoadXML.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnLoadXML.Location = New Global.System.Drawing.Point(288, 248)
            Me.btnLoadXML.Name = "btnLoadXML"
            Me.btnLoadXML.TabIndex = 4
            Me.btnLoadXML.Text = "Load XML"
            Me.dgProperties.AllowSorting = False
            Me.dgProperties.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.dgProperties.DataMember = ""
            Me.dgProperties.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Me.dgProperties.Location = New Global.System.Drawing.Point(8, 16)
            Me.dgProperties.Name = "dgProperties"
            Me.dgProperties.Size = New Global.System.Drawing.Size(464, 208)
            Me.dgProperties.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.dgProperties, "Double-click on the row header to edit an existing entry or on the '*"" row header to add a new entry")
            Me.btnSaveXML.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSaveXML.Location = New Global.System.Drawing.Point(384, 248)
            Me.btnSaveXML.Name = "btnSaveXML"
            Me.btnSaveXML.TabIndex = 4
            Me.btnSaveXML.Text = "Save XML"
            Me.tabpagDescription.Controls.Add(Me.btnSetUnidentDescLang)
            Me.tabpagDescription.Controls.Add(Me.chkbIdentified)
            Me.tabpagDescription.Controls.Add(Me.tbLocalizedName)
            Me.tabpagDescription.Controls.Add(Me.Label4)
            Me.tabpagDescription.Controls.Add(Me.tbUnidentifiedDescription)
            Me.tabpagDescription.Controls.Add(Me.tbIdentifiedDescription)
            Me.tabpagDescription.Controls.Add(Me.Label33)
            Me.tabpagDescription.Controls.Add(Me.Label6)
            Me.tabpagDescription.Controls.Add(Me.btnSetIdentDescLang)
            Me.tabpagDescription.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagDescription.Name = "tabpagDescription"
            Me.tabpagDescription.Size = New Global.System.Drawing.Size(480, 286)
            Me.tabpagDescription.TabIndex = 2
            Me.tabpagDescription.Text = "Description"
            Me.btnSetUnidentDescLang.Location = New Global.System.Drawing.Point(128, 248)
            Me.btnSetUnidentDescLang.Name = "btnSetUnidentDescLang"
            Me.btnSetUnidentDescLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetUnidentDescLang.TabIndex = 4
            Me.btnSetUnidentDescLang.Text = "Set Language"
            Me.chkbIdentified.Location = New Global.System.Drawing.Point(328, 40)
            Me.chkbIdentified.Name = "chkbIdentified"
            Me.chkbIdentified.Size = New Global.System.Drawing.Size(72, 24)
            Me.chkbIdentified.TabIndex = 3
            Me.chkbIdentified.Text = "Identified"
            Me.tbLocalizedName.Location = New Global.System.Drawing.Point(24, 40)
            Me.tbLocalizedName.Name = "tbLocalizedName"
            Me.tbLocalizedName.Size = New Global.System.Drawing.Size(256, 20)
            Me.tbLocalizedName.TabIndex = 2
            Me.tbLocalizedName.Text = ""
            Me.Label4.Location = New Global.System.Drawing.Point(24, 88)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Unidentified Description"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbUnidentifiedDescription.Location = New Global.System.Drawing.Point(24, 112)
            Me.tbUnidentifiedDescription.Multiline = True
            Me.tbUnidentifiedDescription.Name = "tbUnidentifiedDescription"
            Me.tbUnidentifiedDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbUnidentifiedDescription.Size = New Global.System.Drawing.Size(192, 120)
            Me.tbUnidentifiedDescription.TabIndex = 0
            Me.tbUnidentifiedDescription.Text = ""
            Me.tbIdentifiedDescription.BackColor = Global.System.Drawing.SystemColors.Info
            Me.tbIdentifiedDescription.Location = New Global.System.Drawing.Point(272, 112)
            Me.tbIdentifiedDescription.Multiline = True
            Me.tbIdentifiedDescription.Name = "tbIdentifiedDescription"
            Me.tbIdentifiedDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbIdentifiedDescription.Size = New Global.System.Drawing.Size(192, 120)
            Me.tbIdentifiedDescription.TabIndex = 0
            Me.tbIdentifiedDescription.Text = ""
            Me.Label33.Location = New Global.System.Drawing.Point(272, 88)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label33.TabIndex = 1
            Me.Label33.Text = "Identified Description"
            Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label6.Location = New Global.System.Drawing.Point(24, 16)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "Name"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSetIdentDescLang.Location = New Global.System.Drawing.Point(376, 248)
            Me.btnSetIdentDescLang.Name = "btnSetIdentDescLang"
            Me.btnSetIdentDescLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetIdentDescLang.TabIndex = 4
            Me.btnSetIdentDescLang.Text = "Set Language"
            Me.tabpagComments.Controls.Add(Me.tbComment)
            Me.tabpagComments.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagComments.Name = "tabpagComments"
            Me.tabpagComments.Size = New Global.System.Drawing.Size(480, 286)
            Me.tabpagComments.TabIndex = 3
            Me.tabpagComments.Text = "Comment"
            Me.tbComment.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbComment.Location = New Global.System.Drawing.Point(8, 8)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New Global.System.Drawing.Size(464, 272)
            Me.tbComment.TabIndex = 0
            Me.tbComment.Text = ""
            Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSave.Location = New Global.System.Drawing.Point(304, 360)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "&Save"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(408, 360)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancel"
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New Global.System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New Global.System.Drawing.Size(8, 8)
            Me.btnDebug.TabIndex = 2
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(512, 397)
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(520, 424)
            Me.Name = "frmUTI_Editor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Item Editor - KotOR "
            Me.TabControl1.ResumeLayout(False)
            Me.tabpagGeneral.ResumeLayout(False)
            CType(Me.nudCost, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudAdditionalCost, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTextureVariation, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudModelVariation, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStackSize, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudPaletteID, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCharges, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudBodyVariation, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUpgradeLevel, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagProperties.ResumeLayout(False)
            CType(Me.dgProperties, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagDescription.ResumeLayout(False)
            Me.tabpagComments.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.dgProperties.DoubleClick, AddressOf Me.dgProperties_DoubleClick
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.btnSave.Click, AddressOf Me.btnSave_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.btnLoadXML.Click, AddressOf Me.btnLoadXML_Click
            AddHandler Me.btnSaveXML.Click, AddressOf Me.btnSaveXML_Click
            AddHandler Me.btnSetUnidentDescLang.Click, AddressOf Me.btnSetUnidentDescLang_Click
            AddHandler Me.btnSetIdentDescLang.Click, AddressOf Me.btnSetIdentDescLang_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
