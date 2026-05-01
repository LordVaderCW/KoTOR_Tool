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
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnInventory = New System.Windows.Forms.Button()
            Me.btnSetNameLang = New System.Windows.Forms.Button()
            Me.tbTag = New System.Windows.Forms.TextBox()
            Me.tbLocName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.nudMarkDown = New System.Windows.Forms.NumericUpDown()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.nudMarkUp = New System.Windows.Forms.NumericUpDown()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.tbOnOpenStore = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.tbID = New System.Windows.Forms.TextBox()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.btnEditOnOpenStore = New System.Windows.Forms.Button()
            Me.cmbxBuySellType = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.tbResRef = New System.Windows.Forms.TextBox()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.tbComment = New System.Windows.Forms.TextBox()
            Me.btnDebug = New System.Windows.Forms.Button()
            CType(Me.nudMarkDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMarkUp, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.Location = New System.Drawing.Point(312, 354)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 27)
            Me.btnSave.TabIndex = 10
            Me.btnSave.Text = "&Save"
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(408, 354)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 27)
            Me.btnCancel.TabIndex = 11
            Me.btnCancel.Text = "&Cancel"
            '
            'btnInventory
            '
            Me.btnInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnInventory.Location = New System.Drawing.Point(16, 354)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New System.Drawing.Size(72, 28)
            Me.btnInventory.TabIndex = 12
            Me.btnInventory.Text = "&Inventory"
            '
            'btnSetNameLang
            '
            Me.btnSetNameLang.Location = New System.Drawing.Point(336, 58)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New System.Drawing.Size(88, 26)
            Me.btnSetNameLang.TabIndex = 2
            Me.btnSetNameLang.Text = "Set Language"
            '
            'tbTag
            '
            Me.tbTag.Location = New System.Drawing.Point(120, 95)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(200, 22)
            Me.tbTag.TabIndex = 3
            '
            'tbLocName
            '
            Me.tbLocName.Location = New System.Drawing.Point(120, 58)
            Me.tbLocName.Name = "tbLocName"
            Me.tbLocName.Size = New System.Drawing.Size(200, 22)
            Me.tbLocName.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(9, 57)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 18)
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "LocName"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(7, 93)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 19)
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.Location = New System.Drawing.Point(29, 130)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(80, 19)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Buy/Sell Flag"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'nudMarkDown
            '
            Me.nudMarkDown.Location = New System.Drawing.Point(120, 205)
            Me.nudMarkDown.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudMarkDown.Name = "nudMarkDown"
            Me.nudMarkDown.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudMarkDown.Size = New System.Drawing.Size(80, 22)
            Me.nudMarkDown.TabIndex = 6
            Me.nudMarkDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.Location = New System.Drawing.Point(21, 204)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(88, 19)
            Me.Label8.TabIndex = 18
            Me.Label8.Text = "Mark Down"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'nudMarkUp
            '
            Me.nudMarkUp.Location = New System.Drawing.Point(120, 168)
            Me.nudMarkUp.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.nudMarkUp.Name = "nudMarkUp"
            Me.nudMarkUp.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudMarkUp.Size = New System.Drawing.Size(80, 22)
            Me.nudMarkUp.TabIndex = 5
            Me.nudMarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label12
            '
            Me.Label12.Location = New System.Drawing.Point(21, 167)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(88, 19)
            Me.Label12.TabIndex = 19
            Me.Label12.Text = "Mark Up"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.Location = New System.Drawing.Point(-7, 245)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(123, 18)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "OnOpenStore Script"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'tbOnOpenStore
            '
            Me.tbOnOpenStore.Location = New System.Drawing.Point(120, 242)
            Me.tbOnOpenStore.MaxLength = 16
            Me.tbOnOpenStore.Name = "tbOnOpenStore"
            Me.tbOnOpenStore.Size = New System.Drawing.Size(144, 22)
            Me.tbOnOpenStore.TabIndex = 7
            '
            'Label5
            '
            Me.Label5.Location = New System.Drawing.Point(37, 278)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(72, 19)
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "ID"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'tbID
            '
            Me.tbID.Location = New System.Drawing.Point(120, 279)
            Me.tbID.MaxLength = 16
            Me.tbID.Name = "tbID"
            Me.tbID.Size = New System.Drawing.Size(48, 22)
            Me.tbID.TabIndex = 8
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New System.Drawing.Point(16, 18)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(464, 370)
            Me.TabControl1.TabIndex = 22
            '
            'TabPage1
            '
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
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New System.Drawing.Size(456, 344)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Basic"
            '
            'btnEditOnOpenStore
            '
            Me.btnEditOnOpenStore.Location = New System.Drawing.Point(280, 240)
            Me.btnEditOnOpenStore.Name = "btnEditOnOpenStore"
            Me.btnEditOnOpenStore.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnOpenStore.TabIndex = 36
            Me.btnEditOnOpenStore.Text = "Edit"
            Me.btnEditOnOpenStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxBuySellType
            '
            Me.cmbxBuySellType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxBuySellType.Items.AddRange(New Object() {"Only buys", "Only sells", "Buys and Sells"})
            Me.cmbxBuySellType.Location = New System.Drawing.Point(120, 129)
            Me.cmbxBuySellType.Name = "cmbxBuySellType"
            Me.cmbxBuySellType.Size = New System.Drawing.Size(104, 21)
            Me.cmbxBuySellType.TabIndex = 4
            '
            'Label6
            '
            Me.Label6.Location = New System.Drawing.Point(-11, 21)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(123, 18)
            Me.Label6.TabIndex = 14
            Me.Label6.Text = "ResRef"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'tbResRef
            '
            Me.tbResRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbResRef.Location = New System.Drawing.Point(120, 18)
            Me.tbResRef.MaxLength = 16
            Me.tbResRef.Name = "tbResRef"
            Me.tbResRef.Size = New System.Drawing.Size(144, 22)
            Me.tbResRef.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.tbComment)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New System.Drawing.Size(456, 344)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Comments"
            '
            'tbComment
            '
            Me.tbComment.Location = New System.Drawing.Point(8, 9)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New System.Drawing.Size(440, 351)
            Me.tbComment.TabIndex = 1
            '
            'btnDebug
            '
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 10)
            Me.btnDebug.TabIndex = 23
            Me.btnDebug.TabStop = False
            '
            'frmUTM_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(496, 397)
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnInventory)
            Me.Name = "frmUTM_Editor"
            Me.Text = "Merchant Editor - KotOR"
            CType(Me.nudMarkDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMarkUp, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
