Namespace kotor_tool
	' Token: 0x02000080 RID: 128
	Public Partial Class frmUTM_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x060013FD RID: 5117 RVA: 0x002B6484 File Offset: 0x002B5484
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06001432 RID: 5170 RVA: 0x002B6AD4 File Offset: 0x002B5AD4
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.btnSave = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnInventory = New Global.System.Windows.Forms.Button()
            Me.btnSetNameLang = New Global.System.Windows.Forms.Button()
            Me.tbTag = New Global.System.Windows.Forms.TextBox()
            Me.tbLocName = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.nudMarkDown = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.nudMarkUp = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.tbOnOpenStore = New Global.System.Windows.Forms.TextBox()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.tbID = New Global.System.Windows.Forms.TextBox()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
            Me.cmbxBuySellType = New Global.System.Windows.Forms.ComboBox()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.tbResRef = New Global.System.Windows.Forms.TextBox()
            Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
            Me.tbComment = New Global.System.Windows.Forms.TextBox()
            Me.btnDebug = New Global.System.Windows.Forms.Button()
            Me.btnEditOnOpenStore = New Global.System.Windows.Forms.Button()
            CType(Me.nudMarkDown, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMarkUp, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(312, 360)
            btnSave.Location = point
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 10
            Me.btnSave.Text = "&Save"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(408, 360)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 11
            Me.btnCancel.Text = "&Cancel"
            Me.btnInventory.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim btnInventory As Global.System.Windows.Forms.Control = Me.btnInventory
            point = New Global.System.Drawing.Point(16, 360)
            btnInventory.Location = point
            Me.btnInventory.Name = "btnInventory"
            Dim btnInventory2 As Global.System.Windows.Forms.Control = Me.btnInventory
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(72, 24)
            btnInventory2.Size = size
            Me.btnInventory.TabIndex = 12
            Me.btnInventory.Text = "&Inventory"
            Dim btnSetNameLang As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            point = New Global.System.Drawing.Point(336, 50)
            btnSetNameLang.Location = point
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Dim btnSetNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetNameLang2.Size = size
            Me.btnSetNameLang.TabIndex = 2
            Me.btnSetNameLang.Text = "Set Language"
            Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
            point = New Global.System.Drawing.Point(120, 82)
            tbTag.Location = point
            Me.tbTag.Name = "tbTag"
            Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
            size = New Global.System.Drawing.Size(200, 20)
            tbTag2.Size = size
            Me.tbTag.TabIndex = 3
            Me.tbTag.Text = ""
            Dim tbLocName As Global.System.Windows.Forms.Control = Me.tbLocName
            point = New Global.System.Drawing.Point(120, 50)
            tbLocName.Location = point
            Me.tbLocName.Name = "tbLocName"
            Dim tbLocName2 As Global.System.Windows.Forms.Control = Me.tbLocName
            size = New Global.System.Drawing.Size(200, 20)
            tbLocName2.Size = size
            Me.tbLocName.TabIndex = 1
            Me.tbLocName.Text = ""
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(9, 49)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(100, 16)
            label2.Size = size
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "LocName"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(7, 81)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(100, 16)
            label4.Size = size
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(29, 113)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(80, 16)
            label6.Size = size
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Buy/Sell Flag"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Dim nudMarkDown As Global.System.Windows.Forms.Control = Me.nudMarkDown
            point = New Global.System.Drawing.Point(120, 178)
            nudMarkDown.Location = point
            Dim nudMarkDown2 As Global.System.Windows.Forms.NumericUpDown = Me.nudMarkDown
            Dim num As Decimal = New Decimal(New Integer() {99999, 0, 0, 0})
            nudMarkDown2.Maximum = num
            Me.nudMarkDown.Name = "nudMarkDown"
            Me.nudMarkDown.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudMarkDown3 As Global.System.Windows.Forms.Control = Me.nudMarkDown
            size = New Global.System.Drawing.Size(80, 20)
            nudMarkDown3.Size = size
            Me.nudMarkDown.TabIndex = 6
            Me.nudMarkDown.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(21, 177)
            label7.Location = point
            Me.Label8.Name = "Label8"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(88, 16)
            label8.Size = size
            Me.Label8.TabIndex = 18
            Me.Label8.Text = "Mark Down"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Dim nudMarkUp As Global.System.Windows.Forms.Control = Me.nudMarkUp
            point = New Global.System.Drawing.Point(120, 146)
            nudMarkUp.Location = point
            Dim nudMarkUp2 As Global.System.Windows.Forms.NumericUpDown = Me.nudMarkUp
            num = New Decimal(New Integer() {1000000, 0, 0, 0})
            nudMarkUp2.Maximum = num
            Me.nudMarkUp.Name = "nudMarkUp"
            Me.nudMarkUp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudMarkUp3 As Global.System.Windows.Forms.Control = Me.nudMarkUp
            size = New Global.System.Drawing.Size(80, 20)
            nudMarkUp3.Size = size
            Me.nudMarkUp.TabIndex = 5
            Me.nudMarkUp.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(21, 145)
            label9.Location = point
            Me.Label12.Name = "Label12"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(88, 16)
            label10.Size = size
            Me.Label12.TabIndex = 19
            Me.Label12.Text = "Mark Up"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(-7, 212)
            label11.Location = point
            Me.Label4.Name = "Label4"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(123, 16)
            label12.Size = size
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "OnOpenStore Script"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Dim tbOnOpenStore As Global.System.Windows.Forms.Control = Me.tbOnOpenStore
            point = New Global.System.Drawing.Point(120, 210)
            tbOnOpenStore.Location = point
            Me.tbOnOpenStore.MaxLength = 16
            Me.tbOnOpenStore.Name = "tbOnOpenStore"
            Dim tbOnOpenStore2 As Global.System.Windows.Forms.Control = Me.tbOnOpenStore
            size = New Global.System.Drawing.Size(144, 20)
            tbOnOpenStore2.Size = size
            Me.tbOnOpenStore.TabIndex = 7
            Me.tbOnOpenStore.Text = ""
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(37, 241)
            label13.Location = point
            Me.Label5.Name = "Label5"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(72, 16)
            label14.Size = size
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "ID"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Dim tbID As Global.System.Windows.Forms.Control = Me.tbID
            point = New Global.System.Drawing.Point(120, 242)
            tbID.Location = point
            Me.tbID.MaxLength = 16
            Me.tbID.Name = "tbID"
            Dim tbID2 As Global.System.Windows.Forms.Control = Me.tbID
            size = New Global.System.Drawing.Size(48, 20)
            tbID2.Size = size
            Me.tbID.TabIndex = 8
            Me.tbID.Text = ""
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            point = New Global.System.Drawing.Point(16, 16)
            tabControl.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
            size = New Global.System.Drawing.Size(464, 320)
            tabControl2.Size = size
            Me.TabControl1.TabIndex = 22
            Me.TabPage1.Controls.Add(Me.btnEditOnOpenStore)
            Me.TabPage1.Controls.Add(Me.cmbxBuySellType)
            Me.TabPage1.Controls.Add(Me.Label5)
            Me.TabPage1.Controls.Add(Me.tbID)
            Me.TabPage1.Controls.Add(Me.Label3)
            Me.TabPage1.Controls.Add(Me.Label12)
            Me.TabPage1.Controls.Add(Me.nudMarkUp)
            Me.TabPage1.Controls.Add(Me.Label8)
            Me.TabPage1.Controls.Add(Me.nudMarkDown)
            Me.TabPage1.Controls.Add(Me.Label2)
            Me.TabPage1.Controls.Add(Me.Label1)
            Me.TabPage1.Controls.Add(Me.tbLocName)
            Me.TabPage1.Controls.Add(Me.tbTag)
            Me.TabPage1.Controls.Add(Me.btnSetNameLang)
            Me.TabPage1.Controls.Add(Me.Label4)
            Me.TabPage1.Controls.Add(Me.tbOnOpenStore)
            Me.TabPage1.Controls.Add(Me.Label6)
            Me.TabPage1.Controls.Add(Me.tbResRef)
            Dim tabPage As Global.System.Windows.Forms.Control = Me.TabPage1
            point = New Global.System.Drawing.Point(4, 22)
            tabPage.Location = point
            Me.TabPage1.Name = "TabPage1"
            Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
            size = New Global.System.Drawing.Size(456, 294)
            tabPage2.Size = size
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Basic"
            Me.cmbxBuySellType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxBuySellType.Items.AddRange(New Object() {"Only buys", "Only sells", "Buys and Sells"})
            Dim cmbxBuySellType As Global.System.Windows.Forms.Control = Me.cmbxBuySellType
            point = New Global.System.Drawing.Point(120, 112)
            cmbxBuySellType.Location = point
            Me.cmbxBuySellType.Name = "cmbxBuySellType"
            Dim cmbxBuySellType2 As Global.System.Windows.Forms.Control = Me.cmbxBuySellType
            size = New Global.System.Drawing.Size(104, 21)
            cmbxBuySellType2.Size = size
            Me.cmbxBuySellType.TabIndex = 4
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(-11, 18)
            label15.Location = point
            Me.Label6.Name = "Label6"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(123, 16)
            label16.Size = size
            Me.Label6.TabIndex = 14
            Me.Label6.Text = "ResRef"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.tbResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbResRef As Global.System.Windows.Forms.Control = Me.tbResRef
            point = New Global.System.Drawing.Point(120, 16)
            tbResRef.Location = point
            Me.tbResRef.MaxLength = 16
            Me.tbResRef.Name = "tbResRef"
            Dim tbResRef2 As Global.System.Windows.Forms.Control = Me.tbResRef
            size = New Global.System.Drawing.Size(144, 20)
            tbResRef2.Size = size
            Me.tbResRef.TabIndex = 0
            Me.tbResRef.Text = ""
            Me.TabPage2.Controls.Add(Me.tbComment)
            Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage2
            point = New Global.System.Drawing.Point(4, 22)
            tabPage3.Location = point
            Me.TabPage2.Name = "TabPage2"
            Dim tabPage4 As Global.System.Windows.Forms.Control = Me.TabPage2
            size = New Global.System.Drawing.Size(456, 294)
            tabPage4.Size = size
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Comments"
            Dim tbComment As Global.System.Windows.Forms.Control = Me.tbComment
            point = New Global.System.Drawing.Point(8, 8)
            tbComment.Location = point
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Dim tbComment2 As Global.System.Windows.Forms.Control = Me.tbComment
            size = New Global.System.Drawing.Size(440, 304)
            tbComment2.Size = size
            Me.tbComment.TabIndex = 1
            Me.tbComment.Text = ""
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
            point = New Global.System.Drawing.Point(0, 0)
            btnDebug.Location = point
            Me.btnDebug.Name = "btnDebug"
            Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
            size = New Global.System.Drawing.Size(8, 9)
            btnDebug2.Size = size
            Me.btnDebug.TabIndex = 23
            Me.btnDebug.TabStop = False
            Dim btnEditOnOpenStore As Global.System.Windows.Forms.Control = Me.btnEditOnOpenStore
            point = New Global.System.Drawing.Point(280, 208)
            btnEditOnOpenStore.Location = point
            Me.btnEditOnOpenStore.Name = "btnEditOnOpenStore"
            Dim btnEditOnOpenStore2 As Global.System.Windows.Forms.Control = Me.btnEditOnOpenStore
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnOpenStore2.Size = size
            Me.btnEditOnOpenStore.TabIndex = 36
            Me.btnEditOnOpenStore.Text = "Edit"
            Me.btnEditOnOpenStore.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(496, 397)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnInventory)
            Me.Name = "frmUTM_Editor"
            Me.Text = "Merchant Editor - KotOR"
            CType(Me.nudMarkDown, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMarkUp, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040009CD RID: 2509
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
