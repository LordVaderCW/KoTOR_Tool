Namespace kotor_tool
	' Token: 0x02000080 RID: 128
	Public Partial Class frmUTM_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnInventory As Global.System.Windows.Forms.Button
        Friend WithEvents btnSetNameLang As Global.System.Windows.Forms.Button
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbLocName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents tbComment As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudMarkDown As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudMarkUp As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbOnOpenStore As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbID As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents tbResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxBuySellType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnEditOnOpenStore As Global.System.Windows.Forms.Button


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
            Me.btnSave.Location = New Global.System.Drawing.Point(312, 360)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 10
            Me.btnSave.Text = "&Save"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(408, 360)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 11
            Me.btnCancel.Text = "&Cancel"
            Me.btnInventory.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnInventory.Location = New Global.System.Drawing.Point(16, 360)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New Global.System.Drawing.Size(72, 24)
            Me.btnInventory.TabIndex = 12
            Me.btnInventory.Text = "&Inventory"
            Me.btnSetNameLang.Location = New Global.System.Drawing.Point(336, 50)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetNameLang.TabIndex = 2
            Me.btnSetNameLang.Text = "Set Language"
            Me.tbTag.Location = New Global.System.Drawing.Point(120, 82)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbTag.TabIndex = 3
            Me.tbTag.Text = ""
            Me.tbLocName.Location = New Global.System.Drawing.Point(120, 50)
            Me.tbLocName.Name = "tbLocName"
            Me.tbLocName.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbLocName.TabIndex = 1
            Me.tbLocName.Text = ""
            Me.Label1.Location = New Global.System.Drawing.Point(9, 49)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "LocName"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label2.Location = New Global.System.Drawing.Point(7, 81)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label3.Location = New Global.System.Drawing.Point(29, 113)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Buy/Sell Flag"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudMarkDown.Location = New Global.System.Drawing.Point(120, 178)
            Me.nudMarkDown.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudMarkDown.Name = "nudMarkDown"
            Me.nudMarkDown.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudMarkDown.Size = New Global.System.Drawing.Size(80, 20)
            Me.nudMarkDown.TabIndex = 6
            Me.nudMarkDown.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label8.Location = New Global.System.Drawing.Point(21, 177)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label8.TabIndex = 18
            Me.Label8.Text = "Mark Down"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudMarkUp.Location = New Global.System.Drawing.Point(120, 146)
            Me.nudMarkUp.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.nudMarkUp.Name = "nudMarkUp"
            Me.nudMarkUp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudMarkUp.Size = New Global.System.Drawing.Size(80, 20)
            Me.nudMarkUp.TabIndex = 5
            Me.nudMarkUp.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label12.Location = New Global.System.Drawing.Point(21, 145)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label12.TabIndex = 19
            Me.Label12.Text = "Mark Up"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label4.Location = New Global.System.Drawing.Point(-7, 212)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(123, 16)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "OnOpenStore Script"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.tbOnOpenStore.Location = New Global.System.Drawing.Point(120, 210)
            Me.tbOnOpenStore.MaxLength = 16
            Me.tbOnOpenStore.Name = "tbOnOpenStore"
            Me.tbOnOpenStore.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbOnOpenStore.TabIndex = 7
            Me.tbOnOpenStore.Text = ""
            Me.Label5.Location = New Global.System.Drawing.Point(37, 241)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(72, 16)
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "ID"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.tbID.Location = New Global.System.Drawing.Point(120, 242)
            Me.tbID.MaxLength = 16
            Me.tbID.Name = "tbID"
            Me.tbID.Size = New Global.System.Drawing.Size(48, 20)
            Me.tbID.TabIndex = 8
            Me.tbID.Text = ""
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New Global.System.Drawing.Point(16, 16)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(464, 320)
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
            Me.TabPage1.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New Global.System.Drawing.Size(456, 294)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Basic"
            Me.cmbxBuySellType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxBuySellType.Items.AddRange(New Object() {"Only buys", "Only sells", "Buys and Sells"})
            Me.cmbxBuySellType.Location = New Global.System.Drawing.Point(120, 112)
            Me.cmbxBuySellType.Name = "cmbxBuySellType"
            Me.cmbxBuySellType.Size = New Global.System.Drawing.Size(104, 21)
            Me.cmbxBuySellType.TabIndex = 4
            Me.Label6.Location = New Global.System.Drawing.Point(-11, 18)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(123, 16)
            Me.Label6.TabIndex = 14
            Me.Label6.Text = "ResRef"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.tbResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbResRef.Location = New Global.System.Drawing.Point(120, 16)
            Me.tbResRef.MaxLength = 16
            Me.tbResRef.Name = "tbResRef"
            Me.tbResRef.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbResRef.TabIndex = 0
            Me.tbResRef.Text = ""
            Me.TabPage2.Controls.Add(Me.tbComment)
            Me.TabPage2.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New Global.System.Drawing.Size(456, 294)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Comments"
            Me.tbComment.Location = New Global.System.Drawing.Point(8, 8)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New Global.System.Drawing.Size(440, 304)
            Me.tbComment.TabIndex = 1
            Me.tbComment.Text = ""
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New Global.System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New Global.System.Drawing.Size(8, 9)
            Me.btnDebug.TabIndex = 23
            Me.btnDebug.TabStop = False
            Me.btnEditOnOpenStore.Location = New Global.System.Drawing.Point(280, 208)
            Me.btnEditOnOpenStore.Name = "btnEditOnOpenStore"
            Me.btnEditOnOpenStore.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnOpenStore.TabIndex = 36
            Me.btnEditOnOpenStore.Text = "Edit"
            Me.btnEditOnOpenStore.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(496, 397)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnSave.Click, AddressOf Me.btnSave_Click
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.btnInventory.Click, AddressOf Me.btnInventory_Click
            AddHandler Me.btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.btnEditOnOpenStore.Click, AddressOf Me.btnEditScript_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
