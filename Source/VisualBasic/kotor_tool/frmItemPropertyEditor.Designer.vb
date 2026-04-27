Namespace kotor_tool
	' Token: 0x02000053 RID: 83
	Public Partial Class frmItemPropertyEditor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxPropertyName As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxSubtype As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxParam1Value As Global.System.Windows.Forms.ComboBox
        Friend WithEvents nudPercentChance As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblParam1 As Global.System.Windows.Forms.Label
        Friend WithEvents lblCostTable As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxCostValue As Global.System.Windows.Forms.ComboBox
        Friend WithEvents lblParam2 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxParam2Value As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbStatus As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbSubtyperesref As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCostTableID As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCostTableName As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbParam1resref As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbParam2resref As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents tbParam1tableresref As Global.System.Windows.Forms.TextBox
        Friend WithEvents label99 As Global.System.Windows.Forms.Label
        Friend WithEvents tbParam2tableresref As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents lblParam2Desc As Global.System.Windows.Forms.Label
        Friend WithEvents lblParam1Desc As Global.System.Windows.Forms.Label
        Friend WithEvents lblValueDesc As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtypeDesc As Global.System.Windows.Forms.Label
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxUpgrade As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label


		' Token: 0x06000620 RID: 1568 RVA: 0x0024A1EC File Offset: 0x002491EC
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x06000669 RID: 1641 RVA: 0x0024AA1C File Offset: 0x00249A1C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmItemPropertyEditor))
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
            Me.cmbxPropertyName.Location = New Global.System.Drawing.Point(24, 40)
            Me.cmbxPropertyName.MaxDropDownItems = 15
            Me.cmbxPropertyName.Name = "cmbxPropertyName"
            Me.cmbxPropertyName.Size = New Global.System.Drawing.Size(232, 21)
            Me.cmbxPropertyName.TabIndex = 0
            Me.cmbxSubtype.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSubtype.Enabled = False
            Me.cmbxSubtype.Location = New Global.System.Drawing.Point(24, 88)
            Me.cmbxSubtype.MaxDropDownItems = 12
            Me.cmbxSubtype.Name = "cmbxSubtype"
            Me.cmbxSubtype.Size = New Global.System.Drawing.Size(232, 21)
            Me.cmbxSubtype.TabIndex = 1
            Me.cmbxParam1Value.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxParam1Value.Enabled = False
            Me.cmbxParam1Value.Location = New Global.System.Drawing.Point(280, 40)
            Me.cmbxParam1Value.MaxDropDownItems = 15
            Me.cmbxParam1Value.Name = "cmbxParam1Value"
            Me.cmbxParam1Value.Size = New Global.System.Drawing.Size(216, 21)
            Me.cmbxParam1Value.TabIndex = 3
            Me.Label1.Location = New Global.System.Drawing.Point(24, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Property Name"
            Me.Label2.Location = New Global.System.Drawing.Point(24, 72)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Subtype"
            Me.lblParam1.Location = New Global.System.Drawing.Point(280, 24)
            Me.lblParam1.Name = "lblParam1"
            Me.lblParam1.Size = New Global.System.Drawing.Size(48, 16)
            Me.lblParam1.TabIndex = 1
            Me.lblParam1.Text = "Param 1"
            Me.nudPercentChance.Location = New Global.System.Drawing.Point(64, 184)
            Me.nudPercentChance.Name = "nudPercentChance"
            Me.nudPercentChance.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudPercentChance.TabIndex = 5
            Me.nudPercentChance.Value = New Decimal(New Integer() {100, 0, 0, 0})
            Me.Label5.Location = New Global.System.Drawing.Point(24, 168)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "% Chance of Appearance"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(312, 232)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 6
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(408, 232)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 7
            Me.btnCancel.Text = "Cancel"
            Me.lblCostTable.Location = New Global.System.Drawing.Point(24, 120)
            Me.lblCostTable.Name = "lblCostTable"
            Me.lblCostTable.Size = New Global.System.Drawing.Size(40, 16)
            Me.lblCostTable.TabIndex = 1
            Me.lblCostTable.Text = "Value"
            Me.cmbxCostValue.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxCostValue.Enabled = False
            Me.cmbxCostValue.Location = New Global.System.Drawing.Point(24, 136)
            Me.cmbxCostValue.Name = "cmbxCostValue"
            Me.cmbxCostValue.Size = New Global.System.Drawing.Size(232, 21)
            Me.cmbxCostValue.TabIndex = 2
            Me.lblParam2.Location = New Global.System.Drawing.Point(280, 72)
            Me.lblParam2.Name = "lblParam2"
            Me.lblParam2.Size = New Global.System.Drawing.Size(48, 16)
            Me.lblParam2.TabIndex = 1
            Me.lblParam2.Text = "Param 2"
            Me.cmbxParam2Value.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxParam2Value.Enabled = False
            Me.cmbxParam2Value.Location = New Global.System.Drawing.Point(280, 88)
            Me.cmbxParam2Value.MaxDropDownItems = 12
            Me.cmbxParam2Value.Name = "cmbxParam2Value"
            Me.cmbxParam2Value.Size = New Global.System.Drawing.Size(216, 21)
            Me.cmbxParam2Value.TabIndex = 4
            Me.tbStatus.Location = New Global.System.Drawing.Point(16, 312)
            Me.tbStatus.Name = "tbStatus"
            Me.tbStatus.Size = New Global.System.Drawing.Size(488, 20)
            Me.tbStatus.TabIndex = 4
            Me.tbStatus.TabStop = False
            Me.tbStatus.Text = ""
            Me.tbSubtyperesref.Location = New Global.System.Drawing.Point(552, 24)
            Me.tbSubtyperesref.Name = "tbSubtyperesref"
            Me.tbSubtyperesref.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbSubtyperesref.TabIndex = 5
            Me.tbSubtyperesref.TabStop = False
            Me.tbSubtyperesref.Text = ""
            Me.tbCostTableID.Location = New Global.System.Drawing.Point(552, 72)
            Me.tbCostTableID.Name = "tbCostTableID"
            Me.tbCostTableID.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbCostTableID.TabIndex = 5
            Me.tbCostTableID.TabStop = False
            Me.tbCostTableID.Text = ""
            Me.tbCostTableName.Location = New Global.System.Drawing.Point(552, 120)
            Me.tbCostTableName.Name = "tbCostTableName"
            Me.tbCostTableName.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbCostTableName.TabIndex = 5
            Me.tbCostTableName.TabStop = False
            Me.tbCostTableName.Text = ""
            Me.tbParam1resref.Location = New Global.System.Drawing.Point(552, 168)
            Me.tbParam1resref.Name = "tbParam1resref"
            Me.tbParam1resref.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbParam1resref.TabIndex = 5
            Me.tbParam1resref.TabStop = False
            Me.tbParam1resref.Text = ""
            Me.tbParam2resref.Location = New Global.System.Drawing.Point(552, 264)
            Me.tbParam2resref.Name = "tbParam2resref"
            Me.tbParam2resref.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbParam2resref.TabIndex = 5
            Me.tbParam2resref.TabStop = False
            Me.tbParam2resref.Text = ""
            Me.Label3.Location = New Global.System.Drawing.Point(552, 8)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Subtyperesref"
            Me.Label4.Location = New Global.System.Drawing.Point(552, 56)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "CostTableID"
            Me.Label6.Location = New Global.System.Drawing.Point(552, 104)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label6.TabIndex = 1
            Me.Label6.Text = "CostTableName"
            Me.Label7.Location = New Global.System.Drawing.Point(552, 152)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Param1resref"
            Me.Label8.Location = New Global.System.Drawing.Point(552, 248)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label8.TabIndex = 1
            Me.Label8.Text = "Param2resref"
            Me.tbParam1tableresref.Location = New Global.System.Drawing.Point(552, 216)
            Me.tbParam1tableresref.Name = "tbParam1tableresref"
            Me.tbParam1tableresref.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbParam1tableresref.TabIndex = 5
            Me.tbParam1tableresref.TabStop = False
            Me.tbParam1tableresref.Text = ""
            Me.label99.Location = New Global.System.Drawing.Point(552, 200)
            Me.label99.Name = "label99"
            Me.label99.Size = New Global.System.Drawing.Size(120, 16)
            Me.label99.TabIndex = 1
            Me.label99.Text = "Param1tableresref"
            Me.tbParam2tableresref.Location = New Global.System.Drawing.Point(552, 312)
            Me.tbParam2tableresref.Name = "tbParam2tableresref"
            Me.tbParam2tableresref.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbParam2tableresref.TabIndex = 5
            Me.tbParam2tableresref.TabStop = False
            Me.tbParam2tableresref.Text = ""
            Me.Label10.Location = New Global.System.Drawing.Point(552, 296)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label10.TabIndex = 1
            Me.Label10.Text = "Param2tableresref"
            Me.lblParam2Desc.Location = New Global.System.Drawing.Point(344, 72)
            Me.lblParam2Desc.Name = "lblParam2Desc"
            Me.lblParam2Desc.Size = New Global.System.Drawing.Size(104, 16)
            Me.lblParam2Desc.TabIndex = 1
            Me.lblParam1Desc.Location = New Global.System.Drawing.Point(344, 24)
            Me.lblParam1Desc.Name = "lblParam1Desc"
            Me.lblParam1Desc.Size = New Global.System.Drawing.Size(104, 16)
            Me.lblParam1Desc.TabIndex = 1
            Me.lblValueDesc.Location = New Global.System.Drawing.Point(88, 120)
            Me.lblValueDesc.Name = "lblValueDesc"
            Me.lblValueDesc.Size = New Global.System.Drawing.Size(136, 16)
            Me.lblValueDesc.TabIndex = 1
            Me.lblSubtypeDesc.Location = New Global.System.Drawing.Point(88, 72)
            Me.lblSubtypeDesc.Name = "lblSubtypeDesc"
            Me.lblSubtypeDesc.Size = New Global.System.Drawing.Size(136, 16)
            Me.lblSubtypeDesc.TabIndex = 1
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New Global.System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New Global.System.Drawing.Size(8, 8)
            Me.btnDebug.TabIndex = 8
            Me.btnDebug.TabStop = False
            Me.cmbxUpgrade.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxUpgrade.Enabled = False
            Me.cmbxUpgrade.Location = New Global.System.Drawing.Point(280, 136)
            Me.cmbxUpgrade.Name = "cmbxUpgrade"
            Me.cmbxUpgrade.Size = New Global.System.Drawing.Size(216, 21)
            Me.cmbxUpgrade.TabIndex = 4
            Me.Label9.Location = New Global.System.Drawing.Point(280, 120)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(160, 16)
            Me.Label9.TabIndex = 1
            Me.Label9.Text = "Upgrade required to activate"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(512, 269)
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
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New Global.System.Drawing.Size(520, 296)
            Me.Name = "frmItemPropertyEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Item Property Editor"
            CType(Me.nudPercentChance, Global.System.ComponentModel.ISupportInitialize).EndInit()

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.cmbxPropertyName.SelectedIndexChanged, AddressOf Me.cmbxPropertyName_SelectedIndexChanged
            AddHandler Me.cmbxSubtype.SelectedIndexChanged, AddressOf Me.cmbxSubtype_SelectedIndexChanged
            AddHandler Me.cmbxParam1Value.SelectedIndexChanged, AddressOf Me.cmbxParam1Value_SelectedIndexChanged
            AddHandler Me.cmbxCostValue.SelectedIndexChanged, AddressOf Me.cmbxCostValue_SelectedIndexChanged
            AddHandler Me.cmbxParam2Value.SelectedIndexChanged, AddressOf Me.cmbxParam2Value_SelectedIndexChanged
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
