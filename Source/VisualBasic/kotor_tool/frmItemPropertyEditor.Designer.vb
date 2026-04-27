Namespace kotor_tool
	' Token: 0x02000053 RID: 83
	Public Partial Class frmItemPropertyEditor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000620 RID: 1568 RVA: 0x0024A1EC File Offset: 0x002491EC
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000669 RID: 1641 RVA: 0x0024AA1C File Offset: 0x00249A1C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmItemPropertyEditor))
            Me.cmbxPropertyName = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxSubtype = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxParam1Value = New Global.System.Windows.Forms.ComboBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.lblParam1 = New Global.System.Windows.Forms.Label()
            Me.nudPercentChance = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.lblCostTable = New Global.System.Windows.Forms.Label()
            Me.cmbxCostValue = New Global.System.Windows.Forms.ComboBox()
            Me.lblParam2 = New Global.System.Windows.Forms.Label()
            Me.cmbxParam2Value = New Global.System.Windows.Forms.ComboBox()
            Me.tbStatus = New Global.System.Windows.Forms.TextBox()
            Me.tbSubtyperesref = New Global.System.Windows.Forms.TextBox()
            Me.tbCostTableID = New Global.System.Windows.Forms.TextBox()
            Me.tbCostTableName = New Global.System.Windows.Forms.TextBox()
            Me.tbParam1resref = New Global.System.Windows.Forms.TextBox()
            Me.tbParam2resref = New Global.System.Windows.Forms.TextBox()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.tbParam1tableresref = New Global.System.Windows.Forms.TextBox()
            Me.label99 = New Global.System.Windows.Forms.Label()
            Me.tbParam2tableresref = New Global.System.Windows.Forms.TextBox()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.lblParam2Desc = New Global.System.Windows.Forms.Label()
            Me.lblParam1Desc = New Global.System.Windows.Forms.Label()
            Me.lblValueDesc = New Global.System.Windows.Forms.Label()
            Me.lblSubtypeDesc = New Global.System.Windows.Forms.Label()
            Me.btnDebug = New Global.System.Windows.Forms.Button()
            Me.cmbxUpgrade = New Global.System.Windows.Forms.ComboBox()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            CType(Me.nudPercentChance, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.cmbxPropertyName.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxPropertyName As Global.System.Windows.Forms.Control = Me.cmbxPropertyName
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(24, 40)
            cmbxPropertyName.Location = point
            Me.cmbxPropertyName.MaxDropDownItems = 15
            Me.cmbxPropertyName.Name = "cmbxPropertyName"
            Dim cmbxPropertyName2 As Global.System.Windows.Forms.Control = Me.cmbxPropertyName
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(232, 21)
            cmbxPropertyName2.Size = size
            Me.cmbxPropertyName.TabIndex = 0
            Me.cmbxSubtype.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSubtype.Enabled = False
            Dim cmbxSubtype As Global.System.Windows.Forms.Control = Me.cmbxSubtype
            point = New Global.System.Drawing.Point(24, 88)
            cmbxSubtype.Location = point
            Me.cmbxSubtype.MaxDropDownItems = 12
            Me.cmbxSubtype.Name = "cmbxSubtype"
            Dim cmbxSubtype2 As Global.System.Windows.Forms.Control = Me.cmbxSubtype
            size = New Global.System.Drawing.Size(232, 21)
            cmbxSubtype2.Size = size
            Me.cmbxSubtype.TabIndex = 1
            Me.cmbxParam1Value.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxParam1Value.Enabled = False
            Dim cmbxParam1Value As Global.System.Windows.Forms.Control = Me.cmbxParam1Value
            point = New Global.System.Drawing.Point(280, 40)
            cmbxParam1Value.Location = point
            Me.cmbxParam1Value.MaxDropDownItems = 15
            Me.cmbxParam1Value.Name = "cmbxParam1Value"
            Dim cmbxParam1Value2 As Global.System.Windows.Forms.Control = Me.cmbxParam1Value
            size = New Global.System.Drawing.Size(216, 21)
            cmbxParam1Value2.Size = size
            Me.cmbxParam1Value.TabIndex = 3
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(24, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(120, 16)
            label2.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Property Name"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(24, 72)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(48, 16)
            label4.Size = size
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Subtype"
            Dim lblParam As Global.System.Windows.Forms.Control = Me.lblParam1
            point = New Global.System.Drawing.Point(280, 24)
            lblParam.Location = point
            Me.lblParam1.Name = "lblParam1"
            Dim lblParam2 As Global.System.Windows.Forms.Control = Me.lblParam1
            size = New Global.System.Drawing.Size(48, 16)
            lblParam2.Size = size
            Me.lblParam1.TabIndex = 1
            Me.lblParam1.Text = "Param 1"
            Dim nudPercentChance As Global.System.Windows.Forms.Control = Me.nudPercentChance
            point = New Global.System.Drawing.Point(64, 184)
            nudPercentChance.Location = point
            Me.nudPercentChance.Name = "nudPercentChance"
            Dim nudPercentChance2 As Global.System.Windows.Forms.Control = Me.nudPercentChance
            size = New Global.System.Drawing.Size(40, 20)
            nudPercentChance2.Size = size
            Me.nudPercentChance.TabIndex = 5
            Dim nudPercentChance3 As Global.System.Windows.Forms.NumericUpDown = Me.nudPercentChance
            Dim num As Decimal = New Decimal(New Integer() {100, 0, 0, 0})
            nudPercentChance3.Value = num
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(24, 168)
            label5.Location = point
            Me.Label5.Name = "Label5"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(136, 16)
            label6.Size = size
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "% Chance of Appearance"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(312, 232)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 6
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(408, 232)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 7
            Me.btnCancel.Text = "Cancel"
            Dim lblCostTable As Global.System.Windows.Forms.Control = Me.lblCostTable
            point = New Global.System.Drawing.Point(24, 120)
            lblCostTable.Location = point
            Me.lblCostTable.Name = "lblCostTable"
            Dim lblCostTable2 As Global.System.Windows.Forms.Control = Me.lblCostTable
            size = New Global.System.Drawing.Size(40, 16)
            lblCostTable2.Size = size
            Me.lblCostTable.TabIndex = 1
            Me.lblCostTable.Text = "Value"
            Me.cmbxCostValue.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxCostValue.Enabled = False
            Dim cmbxCostValue As Global.System.Windows.Forms.Control = Me.cmbxCostValue
            point = New Global.System.Drawing.Point(24, 136)
            cmbxCostValue.Location = point
            Me.cmbxCostValue.Name = "cmbxCostValue"
            Dim cmbxCostValue2 As Global.System.Windows.Forms.Control = Me.cmbxCostValue
            size = New Global.System.Drawing.Size(232, 21)
            cmbxCostValue2.Size = size
            Me.cmbxCostValue.TabIndex = 2
            Dim lblParam3 As Global.System.Windows.Forms.Control = Me.lblParam2
            point = New Global.System.Drawing.Point(280, 72)
            lblParam3.Location = point
            Me.lblParam2.Name = "lblParam2"
            Dim lblParam4 As Global.System.Windows.Forms.Control = Me.lblParam2
            size = New Global.System.Drawing.Size(48, 16)
            lblParam4.Size = size
            Me.lblParam2.TabIndex = 1
            Me.lblParam2.Text = "Param 2"
            Me.cmbxParam2Value.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxParam2Value.Enabled = False
            Dim cmbxParam2Value As Global.System.Windows.Forms.Control = Me.cmbxParam2Value
            point = New Global.System.Drawing.Point(280, 88)
            cmbxParam2Value.Location = point
            Me.cmbxParam2Value.MaxDropDownItems = 12
            Me.cmbxParam2Value.Name = "cmbxParam2Value"
            Dim cmbxParam2Value2 As Global.System.Windows.Forms.Control = Me.cmbxParam2Value
            size = New Global.System.Drawing.Size(216, 21)
            cmbxParam2Value2.Size = size
            Me.cmbxParam2Value.TabIndex = 4
            Dim tbStatus As Global.System.Windows.Forms.Control = Me.tbStatus
            point = New Global.System.Drawing.Point(16, 312)
            tbStatus.Location = point
            Me.tbStatus.Name = "tbStatus"
            Dim tbStatus2 As Global.System.Windows.Forms.Control = Me.tbStatus
            size = New Global.System.Drawing.Size(488, 20)
            tbStatus2.Size = size
            Me.tbStatus.TabIndex = 4
            Me.tbStatus.TabStop = False
            Me.tbStatus.Text = ""
            Dim tbSubtyperesref As Global.System.Windows.Forms.Control = Me.tbSubtyperesref
            point = New Global.System.Drawing.Point(552, 24)
            tbSubtyperesref.Location = point
            Me.tbSubtyperesref.Name = "tbSubtyperesref"
            Dim tbSubtyperesref2 As Global.System.Windows.Forms.Control = Me.tbSubtyperesref
            size = New Global.System.Drawing.Size(144, 20)
            tbSubtyperesref2.Size = size
            Me.tbSubtyperesref.TabIndex = 5
            Me.tbSubtyperesref.TabStop = False
            Me.tbSubtyperesref.Text = ""
            Dim tbCostTableID As Global.System.Windows.Forms.Control = Me.tbCostTableID
            point = New Global.System.Drawing.Point(552, 72)
            tbCostTableID.Location = point
            Me.tbCostTableID.Name = "tbCostTableID"
            Dim tbCostTableID2 As Global.System.Windows.Forms.Control = Me.tbCostTableID
            size = New Global.System.Drawing.Size(144, 20)
            tbCostTableID2.Size = size
            Me.tbCostTableID.TabIndex = 5
            Me.tbCostTableID.TabStop = False
            Me.tbCostTableID.Text = ""
            Dim tbCostTableName As Global.System.Windows.Forms.Control = Me.tbCostTableName
            point = New Global.System.Drawing.Point(552, 120)
            tbCostTableName.Location = point
            Me.tbCostTableName.Name = "tbCostTableName"
            Dim tbCostTableName2 As Global.System.Windows.Forms.Control = Me.tbCostTableName
            size = New Global.System.Drawing.Size(144, 20)
            tbCostTableName2.Size = size
            Me.tbCostTableName.TabIndex = 5
            Me.tbCostTableName.TabStop = False
            Me.tbCostTableName.Text = ""
            Dim tbParam1resref As Global.System.Windows.Forms.Control = Me.tbParam1resref
            point = New Global.System.Drawing.Point(552, 168)
            tbParam1resref.Location = point
            Me.tbParam1resref.Name = "tbParam1resref"
            Dim tbParam1resref2 As Global.System.Windows.Forms.Control = Me.tbParam1resref
            size = New Global.System.Drawing.Size(144, 20)
            tbParam1resref2.Size = size
            Me.tbParam1resref.TabIndex = 5
            Me.tbParam1resref.TabStop = False
            Me.tbParam1resref.Text = ""
            Dim tbParam2resref As Global.System.Windows.Forms.Control = Me.tbParam2resref
            point = New Global.System.Drawing.Point(552, 264)
            tbParam2resref.Location = point
            Me.tbParam2resref.Name = "tbParam2resref"
            Dim tbParam2resref2 As Global.System.Windows.Forms.Control = Me.tbParam2resref
            size = New Global.System.Drawing.Size(144, 20)
            tbParam2resref2.Size = size
            Me.tbParam2resref.TabIndex = 5
            Me.tbParam2resref.TabStop = False
            Me.tbParam2resref.Text = ""
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(552, 8)
            label7.Location = point
            Me.Label3.Name = "Label3"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(120, 16)
            label8.Size = size
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Subtyperesref"
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(552, 56)
            label9.Location = point
            Me.Label4.Name = "Label4"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(120, 16)
            label10.Size = size
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "CostTableID"
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(552, 104)
            label11.Location = point
            Me.Label6.Name = "Label6"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(120, 16)
            label12.Size = size
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "CostTableName"
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(552, 152)
            label13.Location = point
            Me.Label7.Name = "Label7"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(120, 16)
            label14.Size = size
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Param1resref"
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(552, 248)
            label15.Location = point
            Me.Label8.Name = "Label8"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(120, 16)
            label16.Size = size
            Me.Label8.TabIndex = 1
            Me.Label8.Text = "Param2resref"
            Dim tbParam1tableresref As Global.System.Windows.Forms.Control = Me.tbParam1tableresref
            point = New Global.System.Drawing.Point(552, 216)
            tbParam1tableresref.Location = point
            Me.tbParam1tableresref.Name = "tbParam1tableresref"
            Dim tbParam1tableresref2 As Global.System.Windows.Forms.Control = Me.tbParam1tableresref
            size = New Global.System.Drawing.Size(144, 20)
            tbParam1tableresref2.Size = size
            Me.tbParam1tableresref.TabIndex = 5
            Me.tbParam1tableresref.TabStop = False
            Me.tbParam1tableresref.Text = ""
            Dim label17 As Global.System.Windows.Forms.Control = Me.label99
            point = New Global.System.Drawing.Point(552, 200)
            label17.Location = point
            Me.label99.Name = "label99"
            Dim label18 As Global.System.Windows.Forms.Control = Me.label99
            size = New Global.System.Drawing.Size(120, 16)
            label18.Size = size
            Me.label99.TabIndex = 1
            Me.label99.Text = "Param1tableresref"
            Dim tbParam2tableresref As Global.System.Windows.Forms.Control = Me.tbParam2tableresref
            point = New Global.System.Drawing.Point(552, 312)
            tbParam2tableresref.Location = point
            Me.tbParam2tableresref.Name = "tbParam2tableresref"
            Dim tbParam2tableresref2 As Global.System.Windows.Forms.Control = Me.tbParam2tableresref
            size = New Global.System.Drawing.Size(144, 20)
            tbParam2tableresref2.Size = size
            Me.tbParam2tableresref.TabIndex = 5
            Me.tbParam2tableresref.TabStop = False
            Me.tbParam2tableresref.Text = ""
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(552, 296)
            label19.Location = point
            Me.Label10.Name = "Label10"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(120, 16)
            label20.Size = size
            Me.Label10.TabIndex = 1
            Me.Label10.Text = "Param2tableresref"
            Dim lblParam2Desc As Global.System.Windows.Forms.Control = Me.lblParam2Desc
            point = New Global.System.Drawing.Point(344, 72)
            lblParam2Desc.Location = point
            Me.lblParam2Desc.Name = "lblParam2Desc"
            Dim lblParam2Desc2 As Global.System.Windows.Forms.Control = Me.lblParam2Desc
            size = New Global.System.Drawing.Size(104, 16)
            lblParam2Desc2.Size = size
            Me.lblParam2Desc.TabIndex = 1
            Dim lblParam1Desc As Global.System.Windows.Forms.Control = Me.lblParam1Desc
            point = New Global.System.Drawing.Point(344, 24)
            lblParam1Desc.Location = point
            Me.lblParam1Desc.Name = "lblParam1Desc"
            Dim lblParam1Desc2 As Global.System.Windows.Forms.Control = Me.lblParam1Desc
            size = New Global.System.Drawing.Size(104, 16)
            lblParam1Desc2.Size = size
            Me.lblParam1Desc.TabIndex = 1
            Dim lblValueDesc As Global.System.Windows.Forms.Control = Me.lblValueDesc
            point = New Global.System.Drawing.Point(88, 120)
            lblValueDesc.Location = point
            Me.lblValueDesc.Name = "lblValueDesc"
            Dim lblValueDesc2 As Global.System.Windows.Forms.Control = Me.lblValueDesc
            size = New Global.System.Drawing.Size(136, 16)
            lblValueDesc2.Size = size
            Me.lblValueDesc.TabIndex = 1
            Dim lblSubtypeDesc As Global.System.Windows.Forms.Control = Me.lblSubtypeDesc
            point = New Global.System.Drawing.Point(88, 72)
            lblSubtypeDesc.Location = point
            Me.lblSubtypeDesc.Name = "lblSubtypeDesc"
            Dim lblSubtypeDesc2 As Global.System.Windows.Forms.Control = Me.lblSubtypeDesc
            size = New Global.System.Drawing.Size(136, 16)
            lblSubtypeDesc2.Size = size
            Me.lblSubtypeDesc.TabIndex = 1
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
            point = New Global.System.Drawing.Point(0, 0)
            btnDebug.Location = point
            Me.btnDebug.Name = "btnDebug"
            Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
            size = New Global.System.Drawing.Size(8, 8)
            btnDebug2.Size = size
            Me.btnDebug.TabIndex = 8
            Me.btnDebug.TabStop = False
            Me.cmbxUpgrade.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxUpgrade.Enabled = False
            Dim cmbxUpgrade As Global.System.Windows.Forms.Control = Me.cmbxUpgrade
            point = New Global.System.Drawing.Point(280, 136)
            cmbxUpgrade.Location = point
            Me.cmbxUpgrade.Name = "cmbxUpgrade"
            Dim cmbxUpgrade2 As Global.System.Windows.Forms.Control = Me.cmbxUpgrade
            size = New Global.System.Drawing.Size(216, 21)
            cmbxUpgrade2.Size = size
            Me.cmbxUpgrade.TabIndex = 4
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(280, 120)
            label21.Location = point
            Me.Label9.Name = "Label9"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(160, 16)
            label22.Size = size
            Me.Label9.TabIndex = 1
            Me.Label9.Text = "Upgrade required to activate"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(512, 269)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.tbSubtyperesref)
            Me.Controls.Add(Me.tbStatus)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.nudPercentChance)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cmbxPropertyName)
            Me.Controls.Add(Me.cmbxSubtype)
            Me.Controls.Add(Me.cmbxParam1Value)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblParam1)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.lblCostTable)
            Me.Controls.Add(Me.cmbxCostValue)
            Me.Controls.Add(Me.lblParam2)
            Me.Controls.Add(Me.cmbxParam2Value)
            Me.Controls.Add(Me.tbCostTableID)
            Me.Controls.Add(Me.tbCostTableName)
            Me.Controls.Add(Me.tbParam1resref)
            Me.Controls.Add(Me.tbParam2resref)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.tbParam1tableresref)
            Me.Controls.Add(Me.label99)
            Me.Controls.Add(Me.tbParam2tableresref)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.lblParam2Desc)
            Me.Controls.Add(Me.lblParam1Desc)
            Me.Controls.Add(Me.lblValueDesc)
            Me.Controls.Add(Me.lblSubtypeDesc)
            Me.Controls.Add(Me.cmbxUpgrade)
            Me.Controls.Add(Me.Label9)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            size = New Global.System.Drawing.Size(520, 296)
            Me.MinimumSize = size
            Me.Name = "frmItemPropertyEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Item Property Editor"
            CType(Me.nudPercentChance, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x0400035B RID: 859
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
