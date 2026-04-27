Namespace kotor_tool
	' Token: 0x0200007F RID: 127
	Public Partial Class frmUTI_Editor
		Inherits Global.kotor_tool.frmParent

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
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUTI_Editor))
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
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
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
            Dim tabControl As Global.System.Windows.Forms.TabControl = Me.TabControl1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(49, 18)
            tabControl.ItemSize = size
            Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 32)
            tabControl2.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl3 As Global.System.Windows.Forms.Control = Me.TabControl1
            size = New Global.System.Drawing.Size(488, 312)
            tabControl3.Size = size
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
            Dim tabpagGeneral As Global.System.Windows.Forms.Control = Me.tabpagGeneral
            point = New Global.System.Drawing.Point(4, 22)
            tabpagGeneral.Location = point
            Me.tabpagGeneral.Name = "tabpagGeneral"
            Dim tabpagGeneral2 As Global.System.Windows.Forms.Control = Me.tabpagGeneral
            size = New Global.System.Drawing.Size(480, 286)
            tabpagGeneral2.Size = size
            Me.tabpagGeneral.TabIndex = 0
            Me.tabpagGeneral.Text = "General"
            Me.cmbxBaseItem.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxBaseItem As Global.System.Windows.Forms.Control = Me.cmbxBaseItem
            point = New Global.System.Drawing.Point(109, 98)
            cmbxBaseItem.Location = point
            Me.cmbxBaseItem.Name = "cmbxBaseItem"
            Dim cmbxBaseItem2 As Global.System.Windows.Forms.Control = Me.cmbxBaseItem
            size = New Global.System.Drawing.Size(184, 21)
            cmbxBaseItem2.Size = size
            Me.cmbxBaseItem.TabIndex = 4
            Dim nudCost As Global.System.Windows.Forms.Control = Me.nudCost
            point = New Global.System.Drawing.Point(109, 136)
            nudCost.Location = point
            Dim nudCost2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCost
            Dim num As Decimal = New Decimal(New Integer() {99999, 0, 0, 0})
            nudCost2.Maximum = num
            Me.nudCost.Name = "nudCost"
            Me.nudCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudCost3 As Global.System.Windows.Forms.Control = Me.nudCost
            size = New Global.System.Drawing.Size(64, 20)
            nudCost3.Size = size
            Me.nudCost.TabIndex = 3
            Me.nudCost.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(16, 62)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(80, 16)
            label2.Size = size
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Tag"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
            point = New Global.System.Drawing.Point(109, 60)
            tbTag.Location = point
            Me.tbTag.Name = "tbTag"
            Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
            size = New Global.System.Drawing.Size(168, 20)
            tbTag2.Size = size
            Me.tbTag.TabIndex = 1
            Me.tbTag.Text = ""
            Dim chkbPlotItem As Global.System.Windows.Forms.Control = Me.chkbPlotItem
            point = New Global.System.Drawing.Point(344, 21)
            chkbPlotItem.Location = point
            Me.chkbPlotItem.Name = "chkbPlotItem"
            Dim chkbPlotItem2 As Global.System.Windows.Forms.Control = Me.chkbPlotItem
            size = New Global.System.Drawing.Size(72, 24)
            chkbPlotItem2.Size = size
            Me.chkbPlotItem.TabIndex = 0
            Me.chkbPlotItem.Text = "Plot item"
            Dim chkbStolen As Global.System.Windows.Forms.Control = Me.chkbStolen
            point = New Global.System.Drawing.Point(344, 58)
            chkbStolen.Location = point
            Me.chkbStolen.Name = "chkbStolen"
            Me.chkbStolen.TabIndex = 0
            Me.chkbStolen.Text = "Stolen"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(16, 176)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(80, 16)
            label4.Size = size
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Additional Cost"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(16, 138)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(80, 16)
            label6.Size = size
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Cost"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudAdditionalCost As Global.System.Windows.Forms.Control = Me.nudAdditionalCost
            point = New Global.System.Drawing.Point(109, 174)
            nudAdditionalCost.Location = point
            Dim nudAdditionalCost2 As Global.System.Windows.Forms.NumericUpDown = Me.nudAdditionalCost
            num = New Decimal(New Integer() {99999, 0, 0, 0})
            nudAdditionalCost2.Maximum = num
            Me.nudAdditionalCost.Name = "nudAdditionalCost"
            Me.nudAdditionalCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudAdditionalCost3 As Global.System.Windows.Forms.Control = Me.nudAdditionalCost
            size = New Global.System.Drawing.Size(64, 20)
            nudAdditionalCost3.Size = size
            Me.nudAdditionalCost.TabIndex = 3
            Me.nudAdditionalCost.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(312, 176)
            label7.Location = point
            Me.Label5.Name = "Label5"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(88, 16)
            label8.Size = size
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Model Variation"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudTextureVariation As Global.System.Windows.Forms.Control = Me.nudTextureVariation
            point = New Global.System.Drawing.Point(408, 248)
            nudTextureVariation.Location = point
            Dim nudTextureVariation2 As Global.System.Windows.Forms.NumericUpDown = Me.nudTextureVariation
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudTextureVariation2.Maximum = num
            Me.nudTextureVariation.Name = "nudTextureVariation"
            Me.nudTextureVariation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudTextureVariation3 As Global.System.Windows.Forms.Control = Me.nudTextureVariation
            size = New Global.System.Drawing.Size(48, 20)
            nudTextureVariation3.Size = size
            Me.nudTextureVariation.TabIndex = 3
            Me.nudTextureVariation.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudTextureVariation.Visible = False
            Dim nudModelVariation As Global.System.Windows.Forms.Control = Me.nudModelVariation
            point = New Global.System.Drawing.Point(408, 174)
            nudModelVariation.Location = point
            Dim nudModelVariation2 As Global.System.Windows.Forms.NumericUpDown = Me.nudModelVariation
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudModelVariation2.Maximum = num
            Me.nudModelVariation.Name = "nudModelVariation"
            Me.nudModelVariation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudModelVariation3 As Global.System.Windows.Forms.Control = Me.nudModelVariation
            size = New Global.System.Drawing.Size(48, 20)
            nudModelVariation3.Size = size
            Me.nudModelVariation.TabIndex = 3
            Me.nudModelVariation.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudStackSize As Global.System.Windows.Forms.Control = Me.nudStackSize
            point = New Global.System.Drawing.Point(408, 136)
            nudStackSize.Location = point
            Dim nudStackSize2 As Global.System.Windows.Forms.NumericUpDown = Me.nudStackSize
            num = New Decimal(New Integer() {99999, 0, 0, 0})
            nudStackSize2.Maximum = num
            Me.nudStackSize.Name = "nudStackSize"
            Me.nudStackSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudStackSize3 As Global.System.Windows.Forms.Control = Me.nudStackSize
            size = New Global.System.Drawing.Size(48, 20)
            nudStackSize3.Size = size
            Me.nudStackSize.TabIndex = 3
            Me.nudStackSize.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim lblTextureVariation As Global.System.Windows.Forms.Control = Me.lblTextureVariation
            point = New Global.System.Drawing.Point(312, 250)
            lblTextureVariation.Location = point
            Me.lblTextureVariation.Name = "lblTextureVariation"
            Dim lblTextureVariation2 As Global.System.Windows.Forms.Control = Me.lblTextureVariation
            size = New Global.System.Drawing.Size(96, 16)
            lblTextureVariation2.Size = size
            Me.lblTextureVariation.TabIndex = 2
            Me.lblTextureVariation.Text = "Texture Variation"
            Me.lblTextureVariation.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblTextureVariation.Visible = False
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(312, 138)
            label9.Location = point
            Me.Label8.Name = "Label8"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(88, 16)
            label10.Size = size
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Stack Size"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbTemplateResRef As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
            point = New Global.System.Drawing.Point(109, 23)
            tbTemplateResRef.Location = point
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Dim tbTemplateResRef2 As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
            size = New Global.System.Drawing.Size(168, 20)
            tbTemplateResRef2.Size = size
            Me.tbTemplateResRef.TabIndex = 1
            Me.tbTemplateResRef.Text = ""
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(16, 24)
            label11.Location = point
            Me.Label9.Name = "Label9"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(96, 16)
            label12.Size = size
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Template ResRef"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(16, 100)
            label13.Location = point
            Me.Label10.Name = "Label10"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(80, 16)
            label14.Size = size
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Base Item"
            Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudPaletteID As Global.System.Windows.Forms.Control = Me.nudPaletteID
            point = New Global.System.Drawing.Point(125, 211)
            nudPaletteID.Location = point
            Dim nudPaletteID2 As Global.System.Windows.Forms.NumericUpDown = Me.nudPaletteID
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudPaletteID2.Maximum = num
            Me.nudPaletteID.Name = "nudPaletteID"
            Me.nudPaletteID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudPaletteID3 As Global.System.Windows.Forms.Control = Me.nudPaletteID
            size = New Global.System.Drawing.Size(48, 20)
            nudPaletteID3.Size = size
            Me.nudPaletteID.TabIndex = 3
            Me.nudPaletteID.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(16, 213)
            label15.Location = point
            Me.Label11.Name = "Label11"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(80, 16)
            label16.Size = size
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Palette ID"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudCharges As Global.System.Windows.Forms.Control = Me.nudCharges
            point = New Global.System.Drawing.Point(408, 98)
            nudCharges.Location = point
            Dim nudCharges2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCharges
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudCharges2.Maximum = num
            Me.nudCharges.Name = "nudCharges"
            Me.nudCharges.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudCharges3 As Global.System.Windows.Forms.Control = Me.nudCharges
            size = New Global.System.Drawing.Size(48, 20)
            nudCharges3.Size = size
            Me.nudCharges.TabIndex = 3
            Me.nudCharges.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudBodyVariation As Global.System.Windows.Forms.Control = Me.nudBodyVariation
            point = New Global.System.Drawing.Point(408, 211)
            nudBodyVariation.Location = point
            Dim nudBodyVariation2 As Global.System.Windows.Forms.NumericUpDown = Me.nudBodyVariation
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudBodyVariation2.Maximum = num
            Me.nudBodyVariation.Name = "nudBodyVariation"
            Me.nudBodyVariation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudBodyVariation3 As Global.System.Windows.Forms.Control = Me.nudBodyVariation
            size = New Global.System.Drawing.Size(48, 20)
            nudBodyVariation3.Size = size
            Me.nudBodyVariation.TabIndex = 3
            Me.nudBodyVariation.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudBodyVariation.Visible = False
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(312, 100)
            label17.Location = point
            Me.Label12.Name = "Label12"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(88, 16)
            label18.Size = size
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "Charges"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim lblBodyVariation As Global.System.Windows.Forms.Control = Me.lblBodyVariation
            point = New Global.System.Drawing.Point(312, 213)
            lblBodyVariation.Location = point
            Me.lblBodyVariation.Name = "lblBodyVariation"
            Dim lblBodyVariation2 As Global.System.Windows.Forms.Control = Me.lblBodyVariation
            size = New Global.System.Drawing.Size(88, 16)
            lblBodyVariation2.Size = size
            Me.lblBodyVariation.TabIndex = 2
            Me.lblBodyVariation.Text = "Body Variation"
            Me.lblBodyVariation.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblBodyVariation.Visible = False
            Dim lblUpgradeLevel As Global.System.Windows.Forms.Control = Me.lblUpgradeLevel
            point = New Global.System.Drawing.Point(16, 250)
            lblUpgradeLevel.Location = point
            Me.lblUpgradeLevel.Name = "lblUpgradeLevel"
            Dim lblUpgradeLevel2 As Global.System.Windows.Forms.Control = Me.lblUpgradeLevel
            size = New Global.System.Drawing.Size(80, 16)
            lblUpgradeLevel2.Size = size
            Me.lblUpgradeLevel.TabIndex = 2
            Me.lblUpgradeLevel.Text = "Upgrade Level"
            Me.lblUpgradeLevel.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudUpgradeLevel As Global.System.Windows.Forms.Control = Me.nudUpgradeLevel
            point = New Global.System.Drawing.Point(125, 248)
            nudUpgradeLevel.Location = point
            Dim nudUpgradeLevel2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUpgradeLevel
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudUpgradeLevel2.Maximum = num
            Me.nudUpgradeLevel.Name = "nudUpgradeLevel"
            Me.nudUpgradeLevel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudUpgradeLevel3 As Global.System.Windows.Forms.Control = Me.nudUpgradeLevel
            size = New Global.System.Drawing.Size(48, 20)
            nudUpgradeLevel3.Size = size
            Me.nudUpgradeLevel.TabIndex = 3
            Me.nudUpgradeLevel.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tabpagProperties.Controls.Add(Me.btnLoadXML)
            Me.tabpagProperties.Controls.Add(Me.dgProperties)
            Me.tabpagProperties.Controls.Add(Me.btnSaveXML)
            Dim tabpagProperties As Global.System.Windows.Forms.Control = Me.tabpagProperties
            point = New Global.System.Drawing.Point(4, 22)
            tabpagProperties.Location = point
            Me.tabpagProperties.Name = "tabpagProperties"
            Dim tabpagProperties2 As Global.System.Windows.Forms.Control = Me.tabpagProperties
            size = New Global.System.Drawing.Size(480, 286)
            tabpagProperties2.Size = size
            Me.tabpagProperties.TabIndex = 1
            Me.tabpagProperties.Text = "Properties"
            Me.btnLoadXML.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnLoadXML As Global.System.Windows.Forms.Control = Me.btnLoadXML
            point = New Global.System.Drawing.Point(288, 248)
            btnLoadXML.Location = point
            Me.btnLoadXML.Name = "btnLoadXML"
            Me.btnLoadXML.TabIndex = 4
            Me.btnLoadXML.Text = "Load XML"
            Me.dgProperties.AllowSorting = False
            Me.dgProperties.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.dgProperties.DataMember = ""
            Me.dgProperties.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Dim dgProperties As Global.System.Windows.Forms.Control = Me.dgProperties
            point = New Global.System.Drawing.Point(8, 16)
            dgProperties.Location = point
            Me.dgProperties.Name = "dgProperties"
            Dim dgProperties2 As Global.System.Windows.Forms.Control = Me.dgProperties
            size = New Global.System.Drawing.Size(464, 208)
            dgProperties2.Size = size
            Me.dgProperties.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.dgProperties, "Double-click on the row header to edit an existing entry or on the '*"" row header to add a new entry")
            Me.btnSaveXML.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSaveXML As Global.System.Windows.Forms.Control = Me.btnSaveXML
            point = New Global.System.Drawing.Point(384, 248)
            btnSaveXML.Location = point
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
            Dim tabpagDescription As Global.System.Windows.Forms.Control = Me.tabpagDescription
            point = New Global.System.Drawing.Point(4, 22)
            tabpagDescription.Location = point
            Me.tabpagDescription.Name = "tabpagDescription"
            Dim tabpagDescription2 As Global.System.Windows.Forms.Control = Me.tabpagDescription
            size = New Global.System.Drawing.Size(480, 286)
            tabpagDescription2.Size = size
            Me.tabpagDescription.TabIndex = 2
            Me.tabpagDescription.Text = "Description"
            Dim btnSetUnidentDescLang As Global.System.Windows.Forms.Control = Me.btnSetUnidentDescLang
            point = New Global.System.Drawing.Point(128, 248)
            btnSetUnidentDescLang.Location = point
            Me.btnSetUnidentDescLang.Name = "btnSetUnidentDescLang"
            Dim btnSetUnidentDescLang2 As Global.System.Windows.Forms.Control = Me.btnSetUnidentDescLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetUnidentDescLang2.Size = size
            Me.btnSetUnidentDescLang.TabIndex = 4
            Me.btnSetUnidentDescLang.Text = "Set Language"
            Dim chkbIdentified As Global.System.Windows.Forms.Control = Me.chkbIdentified
            point = New Global.System.Drawing.Point(328, 40)
            chkbIdentified.Location = point
            Me.chkbIdentified.Name = "chkbIdentified"
            Dim chkbIdentified2 As Global.System.Windows.Forms.Control = Me.chkbIdentified
            size = New Global.System.Drawing.Size(72, 24)
            chkbIdentified2.Size = size
            Me.chkbIdentified.TabIndex = 3
            Me.chkbIdentified.Text = "Identified"
            Dim tbLocalizedName As Global.System.Windows.Forms.Control = Me.tbLocalizedName
            point = New Global.System.Drawing.Point(24, 40)
            tbLocalizedName.Location = point
            Me.tbLocalizedName.Name = "tbLocalizedName"
            Dim tbLocalizedName2 As Global.System.Windows.Forms.Control = Me.tbLocalizedName
            size = New Global.System.Drawing.Size(256, 20)
            tbLocalizedName2.Size = size
            Me.tbLocalizedName.TabIndex = 2
            Me.tbLocalizedName.Text = ""
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(24, 88)
            label19.Location = point
            Me.Label4.Name = "Label4"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(136, 16)
            label20.Size = size
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Unidentified Description"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbUnidentifiedDescription As Global.System.Windows.Forms.Control = Me.tbUnidentifiedDescription
            point = New Global.System.Drawing.Point(24, 112)
            tbUnidentifiedDescription.Location = point
            Me.tbUnidentifiedDescription.Multiline = True
            Me.tbUnidentifiedDescription.Name = "tbUnidentifiedDescription"
            Me.tbUnidentifiedDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Dim tbUnidentifiedDescription2 As Global.System.Windows.Forms.Control = Me.tbUnidentifiedDescription
            size = New Global.System.Drawing.Size(192, 120)
            tbUnidentifiedDescription2.Size = size
            Me.tbUnidentifiedDescription.TabIndex = 0
            Me.tbUnidentifiedDescription.Text = ""
            Me.tbIdentifiedDescription.BackColor = Global.System.Drawing.SystemColors.Info
            Dim tbIdentifiedDescription As Global.System.Windows.Forms.Control = Me.tbIdentifiedDescription
            point = New Global.System.Drawing.Point(272, 112)
            tbIdentifiedDescription.Location = point
            Me.tbIdentifiedDescription.Multiline = True
            Me.tbIdentifiedDescription.Name = "tbIdentifiedDescription"
            Me.tbIdentifiedDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Dim tbIdentifiedDescription2 As Global.System.Windows.Forms.Control = Me.tbIdentifiedDescription
            size = New Global.System.Drawing.Size(192, 120)
            tbIdentifiedDescription2.Size = size
            Me.tbIdentifiedDescription.TabIndex = 0
            Me.tbIdentifiedDescription.Text = ""
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label33
            point = New Global.System.Drawing.Point(272, 88)
            label21.Location = point
            Me.Label33.Name = "Label33"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label33
            size = New Global.System.Drawing.Size(136, 16)
            label22.Size = size
            Me.Label33.TabIndex = 1
            Me.Label33.Text = "Identified Description"
            Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(24, 16)
            label23.Location = point
            Me.Label6.Name = "Label6"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(136, 16)
            label24.Size = size
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "Name"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnSetIdentDescLang As Global.System.Windows.Forms.Control = Me.btnSetIdentDescLang
            point = New Global.System.Drawing.Point(376, 248)
            btnSetIdentDescLang.Location = point
            Me.btnSetIdentDescLang.Name = "btnSetIdentDescLang"
            Dim btnSetIdentDescLang2 As Global.System.Windows.Forms.Control = Me.btnSetIdentDescLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetIdentDescLang2.Size = size
            Me.btnSetIdentDescLang.TabIndex = 4
            Me.btnSetIdentDescLang.Text = "Set Language"
            Me.tabpagComments.Controls.Add(Me.tbComment)
            Dim tabpagComments As Global.System.Windows.Forms.Control = Me.tabpagComments
            point = New Global.System.Drawing.Point(4, 22)
            tabpagComments.Location = point
            Me.tabpagComments.Name = "tabpagComments"
            Dim tabpagComments2 As Global.System.Windows.Forms.Control = Me.tabpagComments
            size = New Global.System.Drawing.Size(480, 286)
            tabpagComments2.Size = size
            Me.tabpagComments.TabIndex = 3
            Me.tabpagComments.Text = "Comment"
            Me.tbComment.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbComment As Global.System.Windows.Forms.Control = Me.tbComment
            point = New Global.System.Drawing.Point(8, 8)
            tbComment.Location = point
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Dim tbComment2 As Global.System.Windows.Forms.Control = Me.tbComment
            size = New Global.System.Drawing.Size(464, 272)
            tbComment2.Size = size
            Me.tbComment.TabIndex = 0
            Me.tbComment.Text = ""
            Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
            point = New Global.System.Drawing.Point(304, 360)
            btnSave.Location = point
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "&Save"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(408, 360)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancel"
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
            point = New Global.System.Drawing.Point(0, 0)
            btnDebug.Location = point
            Me.btnDebug.Name = "btnDebug"
            Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
            size = New Global.System.Drawing.Size(8, 8)
            btnDebug2.Size = size
            Me.btnDebug.TabIndex = 2
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(512, 397)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(520, 424)
            Me.MinimumSize = size
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
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000991 RID: 2449
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
