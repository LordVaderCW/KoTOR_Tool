Namespace kotor_tool
	' Token: 0x02000076 RID: 118
	Public Partial Class frmSSFEditor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000F1C RID: 3868 RVA: 0x00292A54 File Offset: 0x00291A54
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600101D RID: 4125 RVA: 0x0029446C File Offset: 0x0029346C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Me.nudBat1 = New Global.System.Windows.Forms.NumericUpDown()
            Me.tbBat1ResRef = New Global.System.Windows.Forms.TextBox()
            Me.tbBat1Desc = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
            Me.nudBat2 = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox4 = New Global.System.Windows.Forms.TextBox()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.nudBat3 = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox5 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox6 = New Global.System.Windows.Forms.TextBox()
            Me.nudBat4 = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Panel1 = New Global.System.Windows.Forms.Panel()
            Me.TextBox43 = New Global.System.Windows.Forms.TextBox()
            Me.Label23 = New Global.System.Windows.Forms.Label()
            Me.TextBox44 = New Global.System.Windows.Forms.TextBox()
            Me.Label24 = New Global.System.Windows.Forms.Label()
            Me.TextBox45 = New Global.System.Windows.Forms.TextBox()
            Me.nudTryUnlock = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudFailUnlock = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox46 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox9 = New Global.System.Windows.Forms.TextBox()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.TextBox8 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox7 = New Global.System.Windows.Forms.TextBox()
            Me.nudBat5 = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox10 = New Global.System.Windows.Forms.TextBox()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.nudBat6 = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudSel1 = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox11 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox12 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox13 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox14 = New Global.System.Windows.Forms.TextBox()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.nudSel3 = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox15 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox16 = New Global.System.Windows.Forms.TextBox()
            Me.nudSel2 = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.TextBox17 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox18 = New Global.System.Windows.Forms.TextBox()
            Me.nudAtk2 = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.nudAtk1 = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox19 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox20 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox21 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox22 = New Global.System.Windows.Forms.TextBox()
            Me.nudAtk3 = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.nudHit2 = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label13 = New Global.System.Windows.Forms.Label()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.nudHit1 = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox23 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox24 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox25 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox26 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox27 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox28 = New Global.System.Windows.Forms.TextBox()
            Me.nudDead = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.TextBox29 = New Global.System.Windows.Forms.TextBox()
            Me.nudLowHlth = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox30 = New Global.System.Windows.Forms.TextBox()
            Me.Label16 = New Global.System.Windows.Forms.Label()
            Me.nudCrit = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox31 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox32 = New Global.System.Windows.Forms.TextBox()
            Me.nudTIA = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label17 = New Global.System.Windows.Forms.Label()
            Me.TextBox33 = New Global.System.Windows.Forms.TextBox()
            Me.Label18 = New Global.System.Windows.Forms.Label()
            Me.TextBox34 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox35 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox36 = New Global.System.Windows.Forms.TextBox()
            Me.nudLMin = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.nudDMin = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox37 = New Global.System.Windows.Forms.TextBox()
            Me.Label20 = New Global.System.Windows.Forms.Label()
            Me.TextBox38 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox39 = New Global.System.Windows.Forms.TextBox()
            Me.Label21 = New Global.System.Windows.Forms.Label()
            Me.TextBox40 = New Global.System.Windows.Forms.TextBox()
            Me.Label22 = New Global.System.Windows.Forms.Label()
            Me.TextBox41 = New Global.System.Windows.Forms.TextBox()
            Me.nudStlh = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudSrch = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox42 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox47 = New Global.System.Windows.Forms.TextBox()
            Me.nudSucceedUnlock = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudLeaveParty = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox48 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox49 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox50 = New Global.System.Windows.Forms.TextBox()
            Me.Label25 = New Global.System.Windows.Forms.Label()
            Me.Label26 = New Global.System.Windows.Forms.Label()
            Me.TextBox51 = New Global.System.Windows.Forms.TextBox()
            Me.nudRejoinParty = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudPoisoned = New Global.System.Windows.Forms.NumericUpDown()
            Me.TextBox52 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox53 = New Global.System.Windows.Forms.TextBox()
            Me.TextBox54 = New Global.System.Windows.Forms.TextBox()
            Me.label111 = New Global.System.Windows.Forms.Label()
            Me.Label28 = New Global.System.Windows.Forms.Label()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miNew = New Global.System.Windows.Forms.MenuItem()
            Me.miOpen = New Global.System.Windows.Forms.MenuItem()
            Me.miSave = New Global.System.Windows.Forms.MenuItem()
            Me.miSaveAs = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.miUseK1DialogTlk = New Global.System.Windows.Forms.MenuItem()
            Me.miUseK2DialogTlk = New Global.System.Windows.Forms.MenuItem()
            Me.miUseExtDialogTlk = New Global.System.Windows.Forms.MenuItem()
            Me.miAskDialogTlk = New Global.System.Windows.Forms.MenuItem()
            Me.StatusBar1 = New Global.System.Windows.Forms.StatusBar()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
            CType(Me.nudBat1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudBat2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudBat3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudBat4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.nudTryUnlock, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFailUnlock, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudBat5, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudBat6, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSel1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSel3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSel2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudAtk2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudAtk1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudAtk3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudHit2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudHit1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDead, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudLowHlth, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCrit, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTIA, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudLMin, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDMin, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStlh, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSucceedUnlock, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudLeaveParty, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRejoinParty, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudPoisoned, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.nudBat1.Enabled = False
            Dim nudBat As Global.System.Windows.Forms.Control = Me.nudBat1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(152, 16)
            nudBat.Location = point
            Dim nudBat2 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat1
            Dim num As Decimal = New Decimal(New Integer() {300000, 0, 0, 0})
            nudBat2.Maximum = num
            Dim nudBat3 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat1
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudBat3.Minimum = num
            Me.nudBat1.Name = "nudBat1"
            Dim nudBat4 As Global.System.Windows.Forms.Control = Me.nudBat1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(64, 20)
            nudBat4.Size = size
            Me.nudBat1.TabIndex = 0
            Me.nudBat1.Tag = "0"
            Me.nudBat1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim tbBat1ResRef As Global.System.Windows.Forms.Control = Me.tbBat1ResRef
            point = New Global.System.Drawing.Point(224, 16)
            tbBat1ResRef.Location = point
            Me.tbBat1ResRef.Name = "tbBat1ResRef"
            Me.tbBat1ResRef.[ReadOnly] = True
            Dim tbBat1ResRef2 As Global.System.Windows.Forms.Control = Me.tbBat1ResRef
            size = New Global.System.Drawing.Size(136, 20)
            tbBat1ResRef2.Size = size
            Me.tbBat1ResRef.TabIndex = 4
            Me.tbBat1ResRef.TabStop = False
            Me.tbBat1ResRef.Tag = "rr0"
            Me.tbBat1ResRef.Text = ""
            Me.tbBat1ResRef.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbBat1Desc.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbBat1Desc As Global.System.Windows.Forms.Control = Me.tbBat1Desc
            point = New Global.System.Drawing.Point(368, 16)
            tbBat1Desc.Location = point
            Me.tbBat1Desc.Name = "tbBat1Desc"
            Me.tbBat1Desc.[ReadOnly] = True
            Dim tbBat1Desc2 As Global.System.Windows.Forms.Control = Me.tbBat1Desc
            size = New Global.System.Drawing.Size(272, 20)
            tbBat1Desc2.Size = size
            Me.tbBat1Desc.TabIndex = 4
            Me.tbBat1Desc.TabStop = False
            Me.tbBat1Desc.Tag = "d0"
            Me.tbBat1Desc.Text = ""
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(16, 16)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(64, 16)
            label2.Size = size
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Battlecry 1"
            Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
            point = New Global.System.Drawing.Point(224, 40)
            textBox.Location = point
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.[ReadOnly] = True
            Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
            size = New Global.System.Drawing.Size(136, 20)
            textBox2.Size = size
            Me.TextBox1.TabIndex = 4
            Me.TextBox1.TabStop = False
            Me.TextBox1.Tag = "rr1"
            Me.TextBox1.Text = ""
            Me.TextBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
            point = New Global.System.Drawing.Point(368, 40)
            textBox3.Location = point
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.[ReadOnly] = True
            Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
            size = New Global.System.Drawing.Size(272, 20)
            textBox4.Size = size
            Me.TextBox2.TabIndex = 4
            Me.TextBox2.TabStop = False
            Me.TextBox2.Tag = "d1"
            Me.TextBox2.Text = ""
            Me.nudBat2.Enabled = False
            Dim nudBat5 As Global.System.Windows.Forms.Control = Me.nudBat2
            point = New Global.System.Drawing.Point(152, 40)
            nudBat5.Location = point
            Dim nudBat6 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat2
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudBat6.Maximum = num
            Dim nudBat7 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat2
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudBat7.Minimum = num
            Me.nudBat2.Name = "nudBat2"
            Dim nudBat8 As Global.System.Windows.Forms.Control = Me.nudBat2
            size = New Global.System.Drawing.Size(64, 20)
            nudBat8.Size = size
            Me.nudBat2.TabIndex = 1
            Me.nudBat2.Tag = "1"
            Me.nudBat2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(16, 40)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(64, 16)
            label4.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Battlecry 2"
            Me.TextBox3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox5 As Global.System.Windows.Forms.Control = Me.TextBox3
            point = New Global.System.Drawing.Point(368, 64)
            textBox5.Location = point
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.[ReadOnly] = True
            Dim textBox6 As Global.System.Windows.Forms.Control = Me.TextBox3
            size = New Global.System.Drawing.Size(272, 20)
            textBox6.Size = size
            Me.TextBox3.TabIndex = 4
            Me.TextBox3.TabStop = False
            Me.TextBox3.Tag = "d2"
            Me.TextBox3.Text = ""
            Dim textBox7 As Global.System.Windows.Forms.Control = Me.TextBox4
            point = New Global.System.Drawing.Point(224, 64)
            textBox7.Location = point
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.[ReadOnly] = True
            Dim textBox8 As Global.System.Windows.Forms.Control = Me.TextBox4
            size = New Global.System.Drawing.Size(136, 20)
            textBox8.Size = size
            Me.TextBox4.TabIndex = 4
            Me.TextBox4.TabStop = False
            Me.TextBox4.Tag = "rr2"
            Me.TextBox4.Text = ""
            Me.TextBox4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(16, 64)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(64, 16)
            label6.Size = size
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Battlecry 3"
            Me.nudBat3.Enabled = False
            Dim nudBat9 As Global.System.Windows.Forms.Control = Me.nudBat3
            point = New Global.System.Drawing.Point(152, 64)
            nudBat9.Location = point
            Dim nudBat10 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat3
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudBat10.Maximum = num
            Dim nudBat11 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat3
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudBat11.Minimum = num
            Me.nudBat3.Name = "nudBat3"
            Dim nudBat12 As Global.System.Windows.Forms.Control = Me.nudBat3
            size = New Global.System.Drawing.Size(64, 20)
            nudBat12.Size = size
            Me.nudBat3.TabIndex = 2
            Me.nudBat3.Tag = "2"
            Me.nudBat3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox9 As Global.System.Windows.Forms.Control = Me.TextBox5
            point = New Global.System.Drawing.Point(224, 88)
            textBox9.Location = point
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.[ReadOnly] = True
            Dim textBox10 As Global.System.Windows.Forms.Control = Me.TextBox5
            size = New Global.System.Drawing.Size(136, 20)
            textBox10.Size = size
            Me.TextBox5.TabIndex = 4
            Me.TextBox5.TabStop = False
            Me.TextBox5.Tag = "rr3"
            Me.TextBox5.Text = ""
            Me.TextBox5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox11 As Global.System.Windows.Forms.Control = Me.TextBox6
            point = New Global.System.Drawing.Point(368, 88)
            textBox11.Location = point
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.[ReadOnly] = True
            Dim textBox12 As Global.System.Windows.Forms.Control = Me.TextBox6
            size = New Global.System.Drawing.Size(272, 20)
            textBox12.Size = size
            Me.TextBox6.TabIndex = 4
            Me.TextBox6.TabStop = False
            Me.TextBox6.Tag = "d3"
            Me.TextBox6.Text = ""
            Me.nudBat4.Enabled = False
            Dim nudBat13 As Global.System.Windows.Forms.Control = Me.nudBat4
            point = New Global.System.Drawing.Point(152, 88)
            nudBat13.Location = point
            Dim nudBat14 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat4
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudBat14.Maximum = num
            Dim nudBat15 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat4
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudBat15.Minimum = num
            Me.nudBat4.Name = "nudBat4"
            Dim nudBat16 As Global.System.Windows.Forms.Control = Me.nudBat4
            size = New Global.System.Drawing.Size(64, 20)
            nudBat16.Size = size
            Me.nudBat4.TabIndex = 3
            Me.nudBat4.Tag = "3"
            Me.nudBat4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(16, 88)
            label7.Location = point
            Me.Label4.Name = "Label4"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(64, 16)
            label8.Size = size
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Battlecry 4"
            Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.AutoScroll = True
            Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.TextBox43)
            Me.Panel1.Controls.Add(Me.Label23)
            Me.Panel1.Controls.Add(Me.TextBox44)
            Me.Panel1.Controls.Add(Me.Label24)
            Me.Panel1.Controls.Add(Me.TextBox45)
            Me.Panel1.Controls.Add(Me.nudTryUnlock)
            Me.Panel1.Controls.Add(Me.nudFailUnlock)
            Me.Panel1.Controls.Add(Me.TextBox46)
            Me.Panel1.Controls.Add(Me.nudBat1)
            Me.Panel1.Controls.Add(Me.tbBat1ResRef)
            Me.Panel1.Controls.Add(Me.TextBox5)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.TextBox9)
            Me.Panel1.Controls.Add(Me.Label6)
            Me.Panel1.Controls.Add(Me.tbBat1Desc)
            Me.Panel1.Controls.Add(Me.TextBox3)
            Me.Panel1.Controls.Add(Me.TextBox4)
            Me.Panel1.Controls.Add(Me.TextBox1)
            Me.Panel1.Controls.Add(Me.nudBat3)
            Me.Panel1.Controls.Add(Me.nudBat2)
            Me.Panel1.Controls.Add(Me.TextBox2)
            Me.Panel1.Controls.Add(Me.nudBat4)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.TextBox8)
            Me.Panel1.Controls.Add(Me.TextBox7)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.nudBat5)
            Me.Panel1.Controls.Add(Me.TextBox6)
            Me.Panel1.Controls.Add(Me.TextBox10)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.nudBat6)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.nudSel1)
            Me.Panel1.Controls.Add(Me.TextBox11)
            Me.Panel1.Controls.Add(Me.TextBox12)
            Me.Panel1.Controls.Add(Me.TextBox13)
            Me.Panel1.Controls.Add(Me.TextBox14)
            Me.Panel1.Controls.Add(Me.Label7)
            Me.Panel1.Controls.Add(Me.nudSel3)
            Me.Panel1.Controls.Add(Me.TextBox15)
            Me.Panel1.Controls.Add(Me.TextBox16)
            Me.Panel1.Controls.Add(Me.nudSel2)
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Controls.Add(Me.Label9)
            Me.Panel1.Controls.Add(Me.TextBox17)
            Me.Panel1.Controls.Add(Me.TextBox18)
            Me.Panel1.Controls.Add(Me.nudAtk2)
            Me.Panel1.Controls.Add(Me.Label10)
            Me.Panel1.Controls.Add(Me.Label11)
            Me.Panel1.Controls.Add(Me.nudAtk1)
            Me.Panel1.Controls.Add(Me.TextBox19)
            Me.Panel1.Controls.Add(Me.TextBox20)
            Me.Panel1.Controls.Add(Me.TextBox21)
            Me.Panel1.Controls.Add(Me.TextBox22)
            Me.Panel1.Controls.Add(Me.nudAtk3)
            Me.Panel1.Controls.Add(Me.Label12)
            Me.Panel1.Controls.Add(Me.nudHit2)
            Me.Panel1.Controls.Add(Me.Label13)
            Me.Panel1.Controls.Add(Me.Label14)
            Me.Panel1.Controls.Add(Me.nudHit1)
            Me.Panel1.Controls.Add(Me.TextBox23)
            Me.Panel1.Controls.Add(Me.TextBox24)
            Me.Panel1.Controls.Add(Me.TextBox25)
            Me.Panel1.Controls.Add(Me.TextBox26)
            Me.Panel1.Controls.Add(Me.TextBox27)
            Me.Panel1.Controls.Add(Me.TextBox28)
            Me.Panel1.Controls.Add(Me.nudDead)
            Me.Panel1.Controls.Add(Me.Label15)
            Me.Panel1.Controls.Add(Me.TextBox29)
            Me.Panel1.Controls.Add(Me.nudLowHlth)
            Me.Panel1.Controls.Add(Me.TextBox30)
            Me.Panel1.Controls.Add(Me.Label16)
            Me.Panel1.Controls.Add(Me.nudCrit)
            Me.Panel1.Controls.Add(Me.TextBox31)
            Me.Panel1.Controls.Add(Me.TextBox32)
            Me.Panel1.Controls.Add(Me.nudTIA)
            Me.Panel1.Controls.Add(Me.Label17)
            Me.Panel1.Controls.Add(Me.TextBox33)
            Me.Panel1.Controls.Add(Me.Label18)
            Me.Panel1.Controls.Add(Me.TextBox34)
            Me.Panel1.Controls.Add(Me.TextBox35)
            Me.Panel1.Controls.Add(Me.TextBox36)
            Me.Panel1.Controls.Add(Me.nudLMin)
            Me.Panel1.Controls.Add(Me.Label19)
            Me.Panel1.Controls.Add(Me.nudDMin)
            Me.Panel1.Controls.Add(Me.TextBox37)
            Me.Panel1.Controls.Add(Me.Label20)
            Me.Panel1.Controls.Add(Me.TextBox38)
            Me.Panel1.Controls.Add(Me.TextBox39)
            Me.Panel1.Controls.Add(Me.Label21)
            Me.Panel1.Controls.Add(Me.TextBox40)
            Me.Panel1.Controls.Add(Me.Label22)
            Me.Panel1.Controls.Add(Me.TextBox41)
            Me.Panel1.Controls.Add(Me.nudStlh)
            Me.Panel1.Controls.Add(Me.nudSrch)
            Me.Panel1.Controls.Add(Me.TextBox42)
            Me.Panel1.Controls.Add(Me.TextBox47)
            Me.Panel1.Controls.Add(Me.nudSucceedUnlock)
            Me.Panel1.Controls.Add(Me.nudLeaveParty)
            Me.Panel1.Controls.Add(Me.TextBox48)
            Me.Panel1.Controls.Add(Me.TextBox49)
            Me.Panel1.Controls.Add(Me.TextBox50)
            Me.Panel1.Controls.Add(Me.Label25)
            Me.Panel1.Controls.Add(Me.Label26)
            Me.Panel1.Controls.Add(Me.TextBox51)
            Me.Panel1.Controls.Add(Me.nudRejoinParty)
            Me.Panel1.Controls.Add(Me.nudPoisoned)
            Me.Panel1.Controls.Add(Me.TextBox52)
            Me.Panel1.Controls.Add(Me.TextBox53)
            Me.Panel1.Controls.Add(Me.TextBox54)
            Me.Panel1.Controls.Add(Me.label111)
            Me.Panel1.Controls.Add(Me.Label28)
            Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
            point = New Global.System.Drawing.Point(8, 16)
            panel.Location = point
            Me.Panel1.Name = "Panel1"
            Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
            size = New Global.System.Drawing.Size(672, 336)
            panel2.Size = size
            Me.Panel1.TabIndex = 6
            Dim textBox13 As Global.System.Windows.Forms.Control = Me.TextBox43
            point = New Global.System.Drawing.Point(224, 592)
            textBox13.Location = point
            Me.TextBox43.Name = "TextBox43"
            Me.TextBox43.[ReadOnly] = True
            Dim textBox14 As Global.System.Windows.Forms.Control = Me.TextBox43
            size = New Global.System.Drawing.Size(136, 20)
            textBox14.Size = size
            Me.TextBox43.TabIndex = 17
            Me.TextBox43.TabStop = False
            Me.TextBox43.Tag = "rr22"
            Me.TextBox43.Text = ""
            Me.TextBox43.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label23
            point = New Global.System.Drawing.Point(16, 616)
            label9.Location = point
            Me.Label23.Name = "Label23"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label23
            size = New Global.System.Drawing.Size(80, 16)
            label10.Size = size
            Me.Label23.TabIndex = 20
            Me.Label23.Text = "Unlock Failed"
            Dim textBox15 As Global.System.Windows.Forms.Control = Me.TextBox44
            point = New Global.System.Drawing.Point(224, 616)
            textBox15.Location = point
            Me.TextBox44.Name = "TextBox44"
            Me.TextBox44.[ReadOnly] = True
            Dim textBox16 As Global.System.Windows.Forms.Control = Me.TextBox44
            size = New Global.System.Drawing.Size(136, 20)
            textBox16.Size = size
            Me.TextBox44.TabIndex = 16
            Me.TextBox44.TabStop = False
            Me.TextBox44.Tag = "rr23"
            Me.TextBox44.Text = ""
            Me.TextBox44.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label24
            point = New Global.System.Drawing.Point(16, 592)
            label11.Location = point
            Me.Label24.Name = "Label24"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label24
            size = New Global.System.Drawing.Size(80, 16)
            label12.Size = size
            Me.Label24.TabIndex = 21
            Me.Label24.Text = "Begin Unlock"
            Me.TextBox45.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox17 As Global.System.Windows.Forms.Control = Me.TextBox45
            point = New Global.System.Drawing.Point(368, 592)
            textBox17.Location = point
            Me.TextBox45.Name = "TextBox45"
            Me.TextBox45.[ReadOnly] = True
            Dim textBox18 As Global.System.Windows.Forms.Control = Me.TextBox45
            size = New Global.System.Drawing.Size(272, 20)
            textBox18.Size = size
            Me.TextBox45.TabIndex = 18
            Me.TextBox45.TabStop = False
            Me.TextBox45.Tag = "d22"
            Me.TextBox45.Text = ""
            Me.nudTryUnlock.Enabled = False
            Dim nudTryUnlock As Global.System.Windows.Forms.Control = Me.nudTryUnlock
            point = New Global.System.Drawing.Point(152, 592)
            nudTryUnlock.Location = point
            Dim nudTryUnlock2 As Global.System.Windows.Forms.NumericUpDown = Me.nudTryUnlock
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudTryUnlock2.Maximum = num
            Dim nudTryUnlock3 As Global.System.Windows.Forms.NumericUpDown = Me.nudTryUnlock
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudTryUnlock3.Minimum = num
            Me.nudTryUnlock.Name = "nudTryUnlock"
            Dim nudTryUnlock4 As Global.System.Windows.Forms.Control = Me.nudTryUnlock
            size = New Global.System.Drawing.Size(64, 20)
            nudTryUnlock4.Size = size
            Me.nudTryUnlock.TabIndex = 22
            Me.nudTryUnlock.Tag = "22"
            Me.nudTryUnlock.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFailUnlock.Enabled = False
            Dim nudFailUnlock As Global.System.Windows.Forms.Control = Me.nudFailUnlock
            point = New Global.System.Drawing.Point(152, 616)
            nudFailUnlock.Location = point
            Dim nudFailUnlock2 As Global.System.Windows.Forms.NumericUpDown = Me.nudFailUnlock
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudFailUnlock2.Maximum = num
            Dim nudFailUnlock3 As Global.System.Windows.Forms.NumericUpDown = Me.nudFailUnlock
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudFailUnlock3.Minimum = num
            Me.nudFailUnlock.Name = "nudFailUnlock"
            Dim nudFailUnlock4 As Global.System.Windows.Forms.Control = Me.nudFailUnlock
            size = New Global.System.Drawing.Size(64, 20)
            nudFailUnlock4.Size = size
            Me.nudFailUnlock.TabIndex = 23
            Me.nudFailUnlock.Tag = "23"
            Me.nudFailUnlock.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox46.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox19 As Global.System.Windows.Forms.Control = Me.TextBox46
            point = New Global.System.Drawing.Point(368, 616)
            textBox19.Location = point
            Me.TextBox46.Name = "TextBox46"
            Me.TextBox46.[ReadOnly] = True
            Dim textBox20 As Global.System.Windows.Forms.Control = Me.TextBox46
            size = New Global.System.Drawing.Size(272, 20)
            textBox20.Size = size
            Me.TextBox46.TabIndex = 19
            Me.TextBox46.TabStop = False
            Me.TextBox46.Tag = "d23"
            Me.TextBox46.Text = ""
            Dim textBox21 As Global.System.Windows.Forms.Control = Me.TextBox9
            point = New Global.System.Drawing.Point(224, 112)
            textBox21.Location = point
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.[ReadOnly] = True
            Dim textBox22 As Global.System.Windows.Forms.Control = Me.TextBox9
            size = New Global.System.Drawing.Size(136, 20)
            textBox22.Size = size
            Me.TextBox9.TabIndex = 9
            Me.TextBox9.TabStop = False
            Me.TextBox9.Tag = "rr4"
            Me.TextBox9.Text = ""
            Me.TextBox9.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(16, 112)
            label13.Location = point
            Me.Label6.Name = "Label6"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(64, 16)
            label14.Size = size
            Me.Label6.TabIndex = 13
            Me.Label6.Text = "Battlecry 5"
            Me.TextBox8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox23 As Global.System.Windows.Forms.Control = Me.TextBox8
            point = New Global.System.Drawing.Point(368, 112)
            textBox23.Location = point
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.[ReadOnly] = True
            Dim textBox24 As Global.System.Windows.Forms.Control = Me.TextBox8
            size = New Global.System.Drawing.Size(272, 20)
            textBox24.Size = size
            Me.TextBox8.TabIndex = 11
            Me.TextBox8.TabStop = False
            Me.TextBox8.Tag = "d4"
            Me.TextBox8.Text = ""
            Me.TextBox7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox25 As Global.System.Windows.Forms.Control = Me.TextBox7
            point = New Global.System.Drawing.Point(368, 136)
            textBox25.Location = point
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.[ReadOnly] = True
            Dim textBox26 As Global.System.Windows.Forms.Control = Me.TextBox7
            size = New Global.System.Drawing.Size(272, 20)
            textBox26.Size = size
            Me.TextBox7.TabIndex = 10
            Me.TextBox7.TabStop = False
            Me.TextBox7.Tag = "d5"
            Me.TextBox7.Text = ""
            Me.nudBat5.Enabled = False
            Dim nudBat17 As Global.System.Windows.Forms.Control = Me.nudBat5
            point = New Global.System.Drawing.Point(152, 112)
            nudBat17.Location = point
            Dim nudBat18 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat5
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudBat18.Maximum = num
            Dim nudBat19 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat5
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudBat19.Minimum = num
            Me.nudBat5.Name = "nudBat5"
            Dim nudBat20 As Global.System.Windows.Forms.Control = Me.nudBat5
            size = New Global.System.Drawing.Size(64, 20)
            nudBat20.Size = size
            Me.nudBat5.TabIndex = 4
            Me.nudBat5.Tag = "4"
            Me.nudBat5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox27 As Global.System.Windows.Forms.Control = Me.TextBox10
            point = New Global.System.Drawing.Point(224, 136)
            textBox27.Location = point
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.[ReadOnly] = True
            Dim textBox28 As Global.System.Windows.Forms.Control = Me.TextBox10
            size = New Global.System.Drawing.Size(136, 20)
            textBox28.Size = size
            Me.TextBox10.TabIndex = 8
            Me.TextBox10.TabStop = False
            Me.TextBox10.Tag = "rr5"
            Me.TextBox10.Text = ""
            Me.TextBox10.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(16, 136)
            label15.Location = point
            Me.Label5.Name = "Label5"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(64, 16)
            label16.Size = size
            Me.Label5.TabIndex = 12
            Me.Label5.Text = "Battlecry 6"
            Me.nudBat6.Enabled = False
            Dim nudBat21 As Global.System.Windows.Forms.Control = Me.nudBat6
            point = New Global.System.Drawing.Point(152, 136)
            nudBat21.Location = point
            Dim nudBat22 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat6
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudBat22.Maximum = num
            Dim nudBat23 As Global.System.Windows.Forms.NumericUpDown = Me.nudBat6
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudBat23.Minimum = num
            Me.nudBat6.Name = "nudBat6"
            Dim nudBat24 As Global.System.Windows.Forms.Control = Me.nudBat6
            size = New Global.System.Drawing.Size(64, 20)
            nudBat24.Size = size
            Me.nudBat6.TabIndex = 5
            Me.nudBat6.Tag = "5"
            Me.nudBat6.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudSel1.Enabled = False
            Dim nudSel As Global.System.Windows.Forms.Control = Me.nudSel1
            point = New Global.System.Drawing.Point(152, 168)
            nudSel.Location = point
            Dim nudSel2 As Global.System.Windows.Forms.NumericUpDown = Me.nudSel1
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudSel2.Maximum = num
            Dim nudSel3 As Global.System.Windows.Forms.NumericUpDown = Me.nudSel1
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudSel3.Minimum = num
            Me.nudSel1.Name = "nudSel1"
            Dim nudSel4 As Global.System.Windows.Forms.Control = Me.nudSel1
            size = New Global.System.Drawing.Size(64, 20)
            nudSel4.Size = size
            Me.nudSel1.TabIndex = 6
            Me.nudSel1.Tag = "6"
            Me.nudSel1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox29 As Global.System.Windows.Forms.Control = Me.TextBox11
            point = New Global.System.Drawing.Point(224, 168)
            textBox29.Location = point
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.[ReadOnly] = True
            Dim textBox30 As Global.System.Windows.Forms.Control = Me.TextBox11
            size = New Global.System.Drawing.Size(136, 20)
            textBox30.Size = size
            Me.TextBox11.TabIndex = 4
            Me.TextBox11.TabStop = False
            Me.TextBox11.Tag = "rr6"
            Me.TextBox11.Text = ""
            Me.TextBox11.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox31 As Global.System.Windows.Forms.Control = Me.TextBox12
            point = New Global.System.Drawing.Point(368, 168)
            textBox31.Location = point
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.[ReadOnly] = True
            Dim textBox32 As Global.System.Windows.Forms.Control = Me.TextBox12
            size = New Global.System.Drawing.Size(272, 20)
            textBox32.Size = size
            Me.TextBox12.TabIndex = 4
            Me.TextBox12.TabStop = False
            Me.TextBox12.Tag = "d6"
            Me.TextBox12.Text = ""
            Me.TextBox13.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox33 As Global.System.Windows.Forms.Control = Me.TextBox13
            point = New Global.System.Drawing.Point(368, 216)
            textBox33.Location = point
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.[ReadOnly] = True
            Dim textBox34 As Global.System.Windows.Forms.Control = Me.TextBox13
            size = New Global.System.Drawing.Size(272, 20)
            textBox34.Size = size
            Me.TextBox13.TabIndex = 4
            Me.TextBox13.TabStop = False
            Me.TextBox13.Tag = "d8"
            Me.TextBox13.Text = ""
            Dim textBox35 As Global.System.Windows.Forms.Control = Me.TextBox14
            point = New Global.System.Drawing.Point(224, 216)
            textBox35.Location = point
            Me.TextBox14.Name = "TextBox14"
            Me.TextBox14.[ReadOnly] = True
            Dim textBox36 As Global.System.Windows.Forms.Control = Me.TextBox14
            size = New Global.System.Drawing.Size(136, 20)
            textBox36.Size = size
            Me.TextBox14.TabIndex = 4
            Me.TextBox14.TabStop = False
            Me.TextBox14.Tag = "rr8"
            Me.TextBox14.Text = ""
            Me.TextBox14.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(16, 216)
            label17.Location = point
            Me.Label7.Name = "Label7"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(64, 16)
            label18.Size = size
            Me.Label7.TabIndex = 5
            Me.Label7.Text = "Select 3"
            Me.nudSel3.Enabled = False
            Dim nudSel5 As Global.System.Windows.Forms.Control = Me.nudSel3
            point = New Global.System.Drawing.Point(152, 216)
            nudSel5.Location = point
            Dim nudSel6 As Global.System.Windows.Forms.NumericUpDown = Me.nudSel3
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudSel6.Maximum = num
            Dim nudSel7 As Global.System.Windows.Forms.NumericUpDown = Me.nudSel3
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudSel7.Minimum = num
            Me.nudSel3.Name = "nudSel3"
            Dim nudSel8 As Global.System.Windows.Forms.Control = Me.nudSel3
            size = New Global.System.Drawing.Size(64, 20)
            nudSel8.Size = size
            Me.nudSel3.TabIndex = 8
            Me.nudSel3.Tag = "8"
            Me.nudSel3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox37 As Global.System.Windows.Forms.Control = Me.TextBox15
            point = New Global.System.Drawing.Point(224, 192)
            textBox37.Location = point
            Me.TextBox15.Name = "TextBox15"
            Me.TextBox15.[ReadOnly] = True
            Dim textBox38 As Global.System.Windows.Forms.Control = Me.TextBox15
            size = New Global.System.Drawing.Size(136, 20)
            textBox38.Size = size
            Me.TextBox15.TabIndex = 4
            Me.TextBox15.TabStop = False
            Me.TextBox15.Tag = "rr7"
            Me.TextBox15.Text = ""
            Me.TextBox15.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox16.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox39 As Global.System.Windows.Forms.Control = Me.TextBox16
            point = New Global.System.Drawing.Point(368, 192)
            textBox39.Location = point
            Me.TextBox16.Name = "TextBox16"
            Me.TextBox16.[ReadOnly] = True
            Dim textBox40 As Global.System.Windows.Forms.Control = Me.TextBox16
            size = New Global.System.Drawing.Size(272, 20)
            textBox40.Size = size
            Me.TextBox16.TabIndex = 4
            Me.TextBox16.TabStop = False
            Me.TextBox16.Tag = "d7"
            Me.TextBox16.Text = ""
            Me.nudSel2.Enabled = False
            Dim nudSel9 As Global.System.Windows.Forms.Control = Me.nudSel2
            point = New Global.System.Drawing.Point(152, 192)
            nudSel9.Location = point
            Dim nudSel10 As Global.System.Windows.Forms.NumericUpDown = Me.nudSel2
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudSel10.Maximum = num
            Dim nudSel11 As Global.System.Windows.Forms.NumericUpDown = Me.nudSel2
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudSel11.Minimum = num
            Me.nudSel2.Name = "nudSel2"
            Dim nudSel12 As Global.System.Windows.Forms.Control = Me.nudSel2
            size = New Global.System.Drawing.Size(64, 20)
            nudSel12.Size = size
            Me.nudSel2.TabIndex = 7
            Me.nudSel2.Tag = "7"
            Me.nudSel2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(16, 192)
            label19.Location = point
            Me.Label8.Name = "Label8"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(64, 16)
            label20.Size = size
            Me.Label8.TabIndex = 5
            Me.Label8.Text = "Select 2"
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(16, 168)
            label21.Location = point
            Me.Label9.Name = "Label9"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(64, 16)
            label22.Size = size
            Me.Label9.TabIndex = 5
            Me.Label9.Text = "Select 1"
            Dim textBox41 As Global.System.Windows.Forms.Control = Me.TextBox17
            point = New Global.System.Drawing.Point(224, 272)
            textBox41.Location = point
            Me.TextBox17.Name = "TextBox17"
            Me.TextBox17.[ReadOnly] = True
            Dim textBox42 As Global.System.Windows.Forms.Control = Me.TextBox17
            size = New Global.System.Drawing.Size(136, 20)
            textBox42.Size = size
            Me.TextBox17.TabIndex = 4
            Me.TextBox17.TabStop = False
            Me.TextBox17.Tag = "rr10"
            Me.TextBox17.Text = ""
            Me.TextBox17.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox18.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox43 As Global.System.Windows.Forms.Control = Me.TextBox18
            point = New Global.System.Drawing.Point(368, 272)
            textBox43.Location = point
            Me.TextBox18.Name = "TextBox18"
            Me.TextBox18.[ReadOnly] = True
            Dim textBox44 As Global.System.Windows.Forms.Control = Me.TextBox18
            size = New Global.System.Drawing.Size(272, 20)
            textBox44.Size = size
            Me.TextBox18.TabIndex = 4
            Me.TextBox18.TabStop = False
            Me.TextBox18.Tag = "d10"
            Me.TextBox18.Text = ""
            Me.nudAtk2.Enabled = False
            Dim nudAtk As Global.System.Windows.Forms.Control = Me.nudAtk2
            point = New Global.System.Drawing.Point(152, 272)
            nudAtk.Location = point
            Dim nudAtk2 As Global.System.Windows.Forms.NumericUpDown = Me.nudAtk2
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudAtk2.Maximum = num
            Dim nudAtk3 As Global.System.Windows.Forms.NumericUpDown = Me.nudAtk2
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudAtk3.Minimum = num
            Me.nudAtk2.Name = "nudAtk2"
            Dim nudAtk4 As Global.System.Windows.Forms.Control = Me.nudAtk2
            size = New Global.System.Drawing.Size(64, 20)
            nudAtk4.Size = size
            Me.nudAtk2.TabIndex = 10
            Me.nudAtk2.Tag = "10"
            Me.nudAtk2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(16, 272)
            label23.Location = point
            Me.Label10.Name = "Label10"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(88, 16)
            label24.Size = size
            Me.Label10.TabIndex = 5
            Me.Label10.Text = "Attack Grunt 2"
            Dim label25 As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(16, 248)
            label25.Location = point
            Me.Label11.Name = "Label11"
            Dim label26 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(88, 16)
            label26.Size = size
            Me.Label11.TabIndex = 5
            Me.Label11.Text = "Attack Grunt 1"
            Me.nudAtk1.Enabled = False
            Dim nudAtk5 As Global.System.Windows.Forms.Control = Me.nudAtk1
            point = New Global.System.Drawing.Point(152, 248)
            nudAtk5.Location = point
            Dim nudAtk6 As Global.System.Windows.Forms.NumericUpDown = Me.nudAtk1
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudAtk6.Maximum = num
            Dim nudAtk7 As Global.System.Windows.Forms.NumericUpDown = Me.nudAtk1
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudAtk7.Minimum = num
            Me.nudAtk1.Name = "nudAtk1"
            Dim nudAtk8 As Global.System.Windows.Forms.Control = Me.nudAtk1
            size = New Global.System.Drawing.Size(64, 20)
            nudAtk8.Size = size
            Me.nudAtk1.TabIndex = 9
            Me.nudAtk1.Tag = "9"
            Me.nudAtk1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox45 As Global.System.Windows.Forms.Control = Me.TextBox19
            point = New Global.System.Drawing.Point(224, 248)
            textBox45.Location = point
            Me.TextBox19.Name = "TextBox19"
            Me.TextBox19.[ReadOnly] = True
            Dim textBox46 As Global.System.Windows.Forms.Control = Me.TextBox19
            size = New Global.System.Drawing.Size(136, 20)
            textBox46.Size = size
            Me.TextBox19.TabIndex = 4
            Me.TextBox19.TabStop = False
            Me.TextBox19.Tag = "rr9"
            Me.TextBox19.Text = ""
            Me.TextBox19.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox20.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox47 As Global.System.Windows.Forms.Control = Me.TextBox20
            point = New Global.System.Drawing.Point(368, 248)
            textBox47.Location = point
            Me.TextBox20.Name = "TextBox20"
            Me.TextBox20.[ReadOnly] = True
            Dim textBox48 As Global.System.Windows.Forms.Control = Me.TextBox20
            size = New Global.System.Drawing.Size(272, 20)
            textBox48.Size = size
            Me.TextBox20.TabIndex = 4
            Me.TextBox20.TabStop = False
            Me.TextBox20.Tag = "d9"
            Me.TextBox20.Text = ""
            Dim textBox49 As Global.System.Windows.Forms.Control = Me.TextBox21
            point = New Global.System.Drawing.Point(224, 296)
            textBox49.Location = point
            Me.TextBox21.Name = "TextBox21"
            Me.TextBox21.[ReadOnly] = True
            Dim textBox50 As Global.System.Windows.Forms.Control = Me.TextBox21
            size = New Global.System.Drawing.Size(136, 20)
            textBox50.Size = size
            Me.TextBox21.TabIndex = 4
            Me.TextBox21.TabStop = False
            Me.TextBox21.Tag = "rr11"
            Me.TextBox21.Text = ""
            Me.TextBox21.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox22.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox51 As Global.System.Windows.Forms.Control = Me.TextBox22
            point = New Global.System.Drawing.Point(368, 296)
            textBox51.Location = point
            Me.TextBox22.Name = "TextBox22"
            Me.TextBox22.[ReadOnly] = True
            Dim textBox52 As Global.System.Windows.Forms.Control = Me.TextBox22
            size = New Global.System.Drawing.Size(272, 20)
            textBox52.Size = size
            Me.TextBox22.TabIndex = 4
            Me.TextBox22.TabStop = False
            Me.TextBox22.Tag = "d11"
            Me.TextBox22.Text = ""
            Me.nudAtk3.Enabled = False
            Dim nudAtk9 As Global.System.Windows.Forms.Control = Me.nudAtk3
            point = New Global.System.Drawing.Point(152, 296)
            nudAtk9.Location = point
            Dim nudAtk10 As Global.System.Windows.Forms.NumericUpDown = Me.nudAtk3
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudAtk10.Maximum = num
            Dim nudAtk11 As Global.System.Windows.Forms.NumericUpDown = Me.nudAtk3
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudAtk11.Minimum = num
            Me.nudAtk3.Name = "nudAtk3"
            Dim nudAtk12 As Global.System.Windows.Forms.Control = Me.nudAtk3
            size = New Global.System.Drawing.Size(64, 20)
            nudAtk12.Size = size
            Me.nudAtk3.TabIndex = 11
            Me.nudAtk3.Tag = "11"
            Me.nudAtk3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label27 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(16, 296)
            label27.Location = point
            Me.Label12.Name = "Label12"
            Dim label28 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(88, 16)
            label28.Size = size
            Me.Label12.TabIndex = 5
            Me.Label12.Text = "Attack Grunt 3"
            Me.nudHit2.Enabled = False
            Dim nudHit As Global.System.Windows.Forms.Control = Me.nudHit2
            point = New Global.System.Drawing.Point(152, 352)
            nudHit.Location = point
            Dim nudHit2 As Global.System.Windows.Forms.NumericUpDown = Me.nudHit2
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudHit2.Maximum = num
            Dim nudHit3 As Global.System.Windows.Forms.NumericUpDown = Me.nudHit2
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudHit3.Minimum = num
            Me.nudHit2.Name = "nudHit2"
            Dim nudHit4 As Global.System.Windows.Forms.Control = Me.nudHit2
            size = New Global.System.Drawing.Size(64, 20)
            nudHit4.Size = size
            Me.nudHit2.TabIndex = 13
            Me.nudHit2.Tag = "13"
            Me.nudHit2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label29 As Global.System.Windows.Forms.Control = Me.Label13
            point = New Global.System.Drawing.Point(16, 352)
            label29.Location = point
            Me.Label13.Name = "Label13"
            Dim label30 As Global.System.Windows.Forms.Control = Me.Label13
            size = New Global.System.Drawing.Size(88, 16)
            label30.Size = size
            Me.Label13.TabIndex = 5
            Me.Label13.Text = "Pain Grunt 2"
            Dim label31 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(16, 328)
            label31.Location = point
            Me.Label14.Name = "Label14"
            Dim label32 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(88, 16)
            label32.Size = size
            Me.Label14.TabIndex = 5
            Me.Label14.Text = "Pain Grunt 1"
            Me.nudHit1.Enabled = False
            Dim nudHit5 As Global.System.Windows.Forms.Control = Me.nudHit1
            point = New Global.System.Drawing.Point(152, 328)
            nudHit5.Location = point
            Dim nudHit6 As Global.System.Windows.Forms.NumericUpDown = Me.nudHit1
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudHit6.Maximum = num
            Dim nudHit7 As Global.System.Windows.Forms.NumericUpDown = Me.nudHit1
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudHit7.Minimum = num
            Me.nudHit1.Name = "nudHit1"
            Dim nudHit8 As Global.System.Windows.Forms.Control = Me.nudHit1
            size = New Global.System.Drawing.Size(64, 20)
            nudHit8.Size = size
            Me.nudHit1.TabIndex = 12
            Me.nudHit1.Tag = "12"
            Me.nudHit1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox53 As Global.System.Windows.Forms.Control = Me.TextBox23
            point = New Global.System.Drawing.Point(224, 328)
            textBox53.Location = point
            Me.TextBox23.Name = "TextBox23"
            Me.TextBox23.[ReadOnly] = True
            Dim textBox54 As Global.System.Windows.Forms.Control = Me.TextBox23
            size = New Global.System.Drawing.Size(136, 20)
            textBox54.Size = size
            Me.TextBox23.TabIndex = 4
            Me.TextBox23.TabStop = False
            Me.TextBox23.Tag = "rr12"
            Me.TextBox23.Text = ""
            Me.TextBox23.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox24.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox55 As Global.System.Windows.Forms.Control = Me.TextBox24
            point = New Global.System.Drawing.Point(368, 328)
            textBox55.Location = point
            Me.TextBox24.Name = "TextBox24"
            Me.TextBox24.[ReadOnly] = True
            Dim textBox56 As Global.System.Windows.Forms.Control = Me.TextBox24
            size = New Global.System.Drawing.Size(272, 20)
            textBox56.Size = size
            Me.TextBox24.TabIndex = 4
            Me.TextBox24.TabStop = False
            Me.TextBox24.Tag = "d12"
            Me.TextBox24.Text = ""
            Dim textBox57 As Global.System.Windows.Forms.Control = Me.TextBox25
            point = New Global.System.Drawing.Point(224, 352)
            textBox57.Location = point
            Me.TextBox25.Name = "TextBox25"
            Me.TextBox25.[ReadOnly] = True
            Dim textBox58 As Global.System.Windows.Forms.Control = Me.TextBox25
            size = New Global.System.Drawing.Size(136, 20)
            textBox58.Size = size
            Me.TextBox25.TabIndex = 4
            Me.TextBox25.TabStop = False
            Me.TextBox25.Tag = "rr13"
            Me.TextBox25.Text = ""
            Me.TextBox25.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox26.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox59 As Global.System.Windows.Forms.Control = Me.TextBox26
            point = New Global.System.Drawing.Point(368, 352)
            textBox59.Location = point
            Me.TextBox26.Name = "TextBox26"
            Me.TextBox26.[ReadOnly] = True
            Dim textBox60 As Global.System.Windows.Forms.Control = Me.TextBox26
            size = New Global.System.Drawing.Size(272, 20)
            textBox60.Size = size
            Me.TextBox26.TabIndex = 4
            Me.TextBox26.TabStop = False
            Me.TextBox26.Tag = "d13"
            Me.TextBox26.Text = ""
            Dim textBox61 As Global.System.Windows.Forms.Control = Me.TextBox27
            point = New Global.System.Drawing.Point(224, 408)
            textBox61.Location = point
            Me.TextBox27.Name = "TextBox27"
            Me.TextBox27.[ReadOnly] = True
            Dim textBox62 As Global.System.Windows.Forms.Control = Me.TextBox27
            size = New Global.System.Drawing.Size(136, 20)
            textBox62.Size = size
            Me.TextBox27.TabIndex = 4
            Me.TextBox27.TabStop = False
            Me.TextBox27.Tag = "rr15"
            Me.TextBox27.Text = ""
            Me.TextBox27.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox28.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox63 As Global.System.Windows.Forms.Control = Me.TextBox28
            point = New Global.System.Drawing.Point(368, 408)
            textBox63.Location = point
            Me.TextBox28.Name = "TextBox28"
            Me.TextBox28.[ReadOnly] = True
            Dim textBox64 As Global.System.Windows.Forms.Control = Me.TextBox28
            size = New Global.System.Drawing.Size(272, 20)
            textBox64.Size = size
            Me.TextBox28.TabIndex = 4
            Me.TextBox28.TabStop = False
            Me.TextBox28.Tag = "d15"
            Me.TextBox28.Text = ""
            Me.nudDead.Enabled = False
            Dim nudDead As Global.System.Windows.Forms.Control = Me.nudDead
            point = New Global.System.Drawing.Point(152, 408)
            nudDead.Location = point
            Dim nudDead2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDead
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudDead2.Maximum = num
            Dim nudDead3 As Global.System.Windows.Forms.NumericUpDown = Me.nudDead
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudDead3.Minimum = num
            Me.nudDead.Name = "nudDead"
            Dim nudDead4 As Global.System.Windows.Forms.Control = Me.nudDead
            size = New Global.System.Drawing.Size(64, 20)
            nudDead4.Size = size
            Me.nudDead.TabIndex = 15
            Me.nudDead.Tag = "15"
            Me.nudDead.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label33 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(16, 408)
            label33.Location = point
            Me.Label15.Name = "Label15"
            Dim label34 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(64, 16)
            label34.Size = size
            Me.Label15.TabIndex = 5
            Me.Label15.Text = "Dead"
            Me.TextBox29.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox65 As Global.System.Windows.Forms.Control = Me.TextBox29
            point = New Global.System.Drawing.Point(368, 432)
            textBox65.Location = point
            Me.TextBox29.Name = "TextBox29"
            Me.TextBox29.[ReadOnly] = True
            Dim textBox66 As Global.System.Windows.Forms.Control = Me.TextBox29
            size = New Global.System.Drawing.Size(272, 20)
            textBox66.Size = size
            Me.TextBox29.TabIndex = 4
            Me.TextBox29.TabStop = False
            Me.TextBox29.Tag = "d16"
            Me.TextBox29.Text = ""
            Me.nudLowHlth.Enabled = False
            Dim nudLowHlth As Global.System.Windows.Forms.Control = Me.nudLowHlth
            point = New Global.System.Drawing.Point(152, 384)
            nudLowHlth.Location = point
            Dim nudLowHlth2 As Global.System.Windows.Forms.NumericUpDown = Me.nudLowHlth
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudLowHlth2.Maximum = num
            Dim nudLowHlth3 As Global.System.Windows.Forms.NumericUpDown = Me.nudLowHlth
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudLowHlth3.Minimum = num
            Me.nudLowHlth.Name = "nudLowHlth"
            Dim nudLowHlth4 As Global.System.Windows.Forms.Control = Me.nudLowHlth
            size = New Global.System.Drawing.Size(64, 20)
            nudLowHlth4.Size = size
            Me.nudLowHlth.TabIndex = 14
            Me.nudLowHlth.Tag = "14"
            Me.nudLowHlth.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox67 As Global.System.Windows.Forms.Control = Me.TextBox30
            point = New Global.System.Drawing.Point(224, 432)
            textBox67.Location = point
            Me.TextBox30.Name = "TextBox30"
            Me.TextBox30.[ReadOnly] = True
            Dim textBox68 As Global.System.Windows.Forms.Control = Me.TextBox30
            size = New Global.System.Drawing.Size(136, 20)
            textBox68.Size = size
            Me.TextBox30.TabIndex = 4
            Me.TextBox30.TabStop = False
            Me.TextBox30.Tag = "rr16"
            Me.TextBox30.Text = ""
            Me.TextBox30.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label35 As Global.System.Windows.Forms.Control = Me.Label16
            point = New Global.System.Drawing.Point(16, 432)
            label35.Location = point
            Me.Label16.Name = "Label16"
            Dim label36 As Global.System.Windows.Forms.Control = Me.Label16
            size = New Global.System.Drawing.Size(64, 16)
            label36.Size = size
            Me.Label16.TabIndex = 5
            Me.Label16.Text = "Critical Hit"
            Me.nudCrit.Enabled = False
            Dim nudCrit As Global.System.Windows.Forms.Control = Me.nudCrit
            point = New Global.System.Drawing.Point(152, 432)
            nudCrit.Location = point
            Dim nudCrit2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCrit
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudCrit2.Maximum = num
            Dim nudCrit3 As Global.System.Windows.Forms.NumericUpDown = Me.nudCrit
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudCrit3.Minimum = num
            Me.nudCrit.Name = "nudCrit"
            Dim nudCrit4 As Global.System.Windows.Forms.Control = Me.nudCrit
            size = New Global.System.Drawing.Size(64, 20)
            nudCrit4.Size = size
            Me.nudCrit.TabIndex = 16
            Me.nudCrit.Tag = "16"
            Me.nudCrit.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox69 As Global.System.Windows.Forms.Control = Me.TextBox31
            point = New Global.System.Drawing.Point(224, 456)
            textBox69.Location = point
            Me.TextBox31.Name = "TextBox31"
            Me.TextBox31.[ReadOnly] = True
            Dim textBox70 As Global.System.Windows.Forms.Control = Me.TextBox31
            size = New Global.System.Drawing.Size(136, 20)
            textBox70.Size = size
            Me.TextBox31.TabIndex = 4
            Me.TextBox31.TabStop = False
            Me.TextBox31.Tag = "rr17"
            Me.TextBox31.Text = ""
            Me.TextBox31.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox32.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox71 As Global.System.Windows.Forms.Control = Me.TextBox32
            point = New Global.System.Drawing.Point(368, 456)
            textBox71.Location = point
            Me.TextBox32.Name = "TextBox32"
            Me.TextBox32.[ReadOnly] = True
            Dim textBox72 As Global.System.Windows.Forms.Control = Me.TextBox32
            size = New Global.System.Drawing.Size(272, 20)
            textBox72.Size = size
            Me.TextBox32.TabIndex = 4
            Me.TextBox32.TabStop = False
            Me.TextBox32.Tag = "d17"
            Me.TextBox32.Text = ""
            Me.nudTIA.Enabled = False
            Dim nudTIA As Global.System.Windows.Forms.Control = Me.nudTIA
            point = New Global.System.Drawing.Point(152, 456)
            nudTIA.Location = point
            Dim nudTIA2 As Global.System.Windows.Forms.NumericUpDown = Me.nudTIA
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudTIA2.Maximum = num
            Dim nudTIA3 As Global.System.Windows.Forms.NumericUpDown = Me.nudTIA
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudTIA3.Minimum = num
            Me.nudTIA.Name = "nudTIA"
            Dim nudTIA4 As Global.System.Windows.Forms.Control = Me.nudTIA
            size = New Global.System.Drawing.Size(64, 20)
            nudTIA4.Size = size
            Me.nudTIA.TabIndex = 17
            Me.nudTIA.Tag = "17"
            Me.nudTIA.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label37 As Global.System.Windows.Forms.Control = Me.Label17
            point = New Global.System.Drawing.Point(16, 456)
            label37.Location = point
            Me.Label17.Name = "Label17"
            Dim label38 As Global.System.Windows.Forms.Control = Me.Label17
            size = New Global.System.Drawing.Size(152, 16)
            label38.Size = size
            Me.Label17.TabIndex = 5
            Me.Label17.Text = "Target Immune to Assault"
            Dim textBox73 As Global.System.Windows.Forms.Control = Me.TextBox33
            point = New Global.System.Drawing.Point(224, 480)
            textBox73.Location = point
            Me.TextBox33.Name = "TextBox33"
            Me.TextBox33.[ReadOnly] = True
            Dim textBox74 As Global.System.Windows.Forms.Control = Me.TextBox33
            size = New Global.System.Drawing.Size(136, 20)
            textBox74.Size = size
            Me.TextBox33.TabIndex = 9
            Me.TextBox33.TabStop = False
            Me.TextBox33.Tag = "rr18"
            Me.TextBox33.Text = ""
            Me.TextBox33.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label39 As Global.System.Windows.Forms.Control = Me.Label18
            point = New Global.System.Drawing.Point(16, 480)
            label39.Location = point
            Me.Label18.Name = "Label18"
            Dim label40 As Global.System.Windows.Forms.Control = Me.Label18
            size = New Global.System.Drawing.Size(64, 16)
            label40.Size = size
            Me.Label18.TabIndex = 13
            Me.Label18.Text = "Lay Mine"
            Me.TextBox34.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox75 As Global.System.Windows.Forms.Control = Me.TextBox34
            point = New Global.System.Drawing.Point(368, 480)
            textBox75.Location = point
            Me.TextBox34.Name = "TextBox34"
            Me.TextBox34.[ReadOnly] = True
            Dim textBox76 As Global.System.Windows.Forms.Control = Me.TextBox34
            size = New Global.System.Drawing.Size(272, 20)
            textBox76.Size = size
            Me.TextBox34.TabIndex = 11
            Me.TextBox34.TabStop = False
            Me.TextBox34.Tag = "d18"
            Me.TextBox34.Text = ""
            Dim textBox77 As Global.System.Windows.Forms.Control = Me.TextBox35
            point = New Global.System.Drawing.Point(224, 384)
            textBox77.Location = point
            Me.TextBox35.Name = "TextBox35"
            Me.TextBox35.[ReadOnly] = True
            Dim textBox78 As Global.System.Windows.Forms.Control = Me.TextBox35
            size = New Global.System.Drawing.Size(136, 20)
            textBox78.Size = size
            Me.TextBox35.TabIndex = 4
            Me.TextBox35.TabStop = False
            Me.TextBox35.Tag = "rr14"
            Me.TextBox35.Text = ""
            Me.TextBox35.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox36.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox79 As Global.System.Windows.Forms.Control = Me.TextBox36
            point = New Global.System.Drawing.Point(368, 384)
            textBox79.Location = point
            Me.TextBox36.Name = "TextBox36"
            Me.TextBox36.[ReadOnly] = True
            Dim textBox80 As Global.System.Windows.Forms.Control = Me.TextBox36
            size = New Global.System.Drawing.Size(272, 20)
            textBox80.Size = size
            Me.TextBox36.TabIndex = 4
            Me.TextBox36.TabStop = False
            Me.TextBox36.Tag = "d14"
            Me.TextBox36.Text = ""
            Me.nudLMin.Enabled = False
            Dim nudLMin As Global.System.Windows.Forms.Control = Me.nudLMin
            point = New Global.System.Drawing.Point(152, 480)
            nudLMin.Location = point
            Dim nudLMin2 As Global.System.Windows.Forms.NumericUpDown = Me.nudLMin
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudLMin2.Maximum = num
            Dim nudLMin3 As Global.System.Windows.Forms.NumericUpDown = Me.nudLMin
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudLMin3.Minimum = num
            Me.nudLMin.Name = "nudLMin"
            Dim nudLMin4 As Global.System.Windows.Forms.Control = Me.nudLMin
            size = New Global.System.Drawing.Size(64, 20)
            nudLMin4.Size = size
            Me.nudLMin.TabIndex = 18
            Me.nudLMin.Tag = "18"
            Me.nudLMin.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label41 As Global.System.Windows.Forms.Control = Me.Label19
            point = New Global.System.Drawing.Point(16, 384)
            label41.Location = point
            Me.Label19.Name = "Label19"
            Dim label42 As Global.System.Windows.Forms.Control = Me.Label19
            size = New Global.System.Drawing.Size(64, 16)
            label42.Size = size
            Me.Label19.TabIndex = 5
            Me.Label19.Text = "Low Health"
            Me.nudDMin.Enabled = False
            Dim nudDMin As Global.System.Windows.Forms.Control = Me.nudDMin
            point = New Global.System.Drawing.Point(152, 504)
            nudDMin.Location = point
            Dim nudDMin2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDMin
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudDMin2.Maximum = num
            Dim nudDMin3 As Global.System.Windows.Forms.NumericUpDown = Me.nudDMin
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudDMin3.Minimum = num
            Me.nudDMin.Name = "nudDMin"
            Dim nudDMin4 As Global.System.Windows.Forms.Control = Me.nudDMin
            size = New Global.System.Drawing.Size(64, 20)
            nudDMin4.Size = size
            Me.nudDMin.TabIndex = 19
            Me.nudDMin.Tag = "19"
            Me.nudDMin.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox37.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox81 As Global.System.Windows.Forms.Control = Me.TextBox37
            point = New Global.System.Drawing.Point(368, 504)
            textBox81.Location = point
            Me.TextBox37.Name = "TextBox37"
            Me.TextBox37.[ReadOnly] = True
            Dim textBox82 As Global.System.Windows.Forms.Control = Me.TextBox37
            size = New Global.System.Drawing.Size(272, 20)
            textBox82.Size = size
            Me.TextBox37.TabIndex = 11
            Me.TextBox37.TabStop = False
            Me.TextBox37.Tag = "d19"
            Me.TextBox37.Text = ""
            Dim label43 As Global.System.Windows.Forms.Control = Me.Label20
            point = New Global.System.Drawing.Point(16, 504)
            label43.Location = point
            Me.Label20.Name = "Label20"
            Dim label44 As Global.System.Windows.Forms.Control = Me.Label20
            size = New Global.System.Drawing.Size(96, 16)
            label44.Size = size
            Me.Label20.TabIndex = 13
            Me.Label20.Text = "Disarm Mine"
            Dim textBox83 As Global.System.Windows.Forms.Control = Me.TextBox38
            point = New Global.System.Drawing.Point(224, 504)
            textBox83.Location = point
            Me.TextBox38.Name = "TextBox38"
            Me.TextBox38.[ReadOnly] = True
            Dim textBox84 As Global.System.Windows.Forms.Control = Me.TextBox38
            size = New Global.System.Drawing.Size(136, 20)
            textBox84.Size = size
            Me.TextBox38.TabIndex = 9
            Me.TextBox38.TabStop = False
            Me.TextBox38.Tag = "rr19"
            Me.TextBox38.Text = ""
            Me.TextBox38.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox85 As Global.System.Windows.Forms.Control = Me.TextBox39
            point = New Global.System.Drawing.Point(224, 536)
            textBox85.Location = point
            Me.TextBox39.Name = "TextBox39"
            Me.TextBox39.[ReadOnly] = True
            Dim textBox86 As Global.System.Windows.Forms.Control = Me.TextBox39
            size = New Global.System.Drawing.Size(136, 20)
            textBox86.Size = size
            Me.TextBox39.TabIndex = 9
            Me.TextBox39.TabStop = False
            Me.TextBox39.Tag = "rr20"
            Me.TextBox39.Text = ""
            Me.TextBox39.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label45 As Global.System.Windows.Forms.Control = Me.Label21
            point = New Global.System.Drawing.Point(16, 560)
            label45.Location = point
            Me.Label21.Name = "Label21"
            Dim label46 As Global.System.Windows.Forms.Control = Me.Label21
            size = New Global.System.Drawing.Size(80, 16)
            label46.Size = size
            Me.Label21.TabIndex = 13
            Me.Label21.Text = "Begin Search"
            Dim textBox87 As Global.System.Windows.Forms.Control = Me.TextBox40
            point = New Global.System.Drawing.Point(224, 560)
            textBox87.Location = point
            Me.TextBox40.Name = "TextBox40"
            Me.TextBox40.[ReadOnly] = True
            Dim textBox88 As Global.System.Windows.Forms.Control = Me.TextBox40
            size = New Global.System.Drawing.Size(136, 20)
            textBox88.Size = size
            Me.TextBox40.TabIndex = 9
            Me.TextBox40.TabStop = False
            Me.TextBox40.Tag = "rr21"
            Me.TextBox40.Text = ""
            Me.TextBox40.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label47 As Global.System.Windows.Forms.Control = Me.Label22
            point = New Global.System.Drawing.Point(16, 536)
            label47.Location = point
            Me.Label22.Name = "Label22"
            Dim label48 As Global.System.Windows.Forms.Control = Me.Label22
            size = New Global.System.Drawing.Size(80, 16)
            label48.Size = size
            Me.Label22.TabIndex = 13
            Me.Label22.Text = "Begin Stealth"
            Me.TextBox41.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox89 As Global.System.Windows.Forms.Control = Me.TextBox41
            point = New Global.System.Drawing.Point(368, 536)
            textBox89.Location = point
            Me.TextBox41.Name = "TextBox41"
            Me.TextBox41.[ReadOnly] = True
            Dim textBox90 As Global.System.Windows.Forms.Control = Me.TextBox41
            size = New Global.System.Drawing.Size(272, 20)
            textBox90.Size = size
            Me.TextBox41.TabIndex = 11
            Me.TextBox41.TabStop = False
            Me.TextBox41.Tag = "d20"
            Me.TextBox41.Text = ""
            Me.nudStlh.Enabled = False
            Dim nudStlh As Global.System.Windows.Forms.Control = Me.nudStlh
            point = New Global.System.Drawing.Point(152, 536)
            nudStlh.Location = point
            Dim nudStlh2 As Global.System.Windows.Forms.NumericUpDown = Me.nudStlh
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudStlh2.Maximum = num
            Dim nudStlh3 As Global.System.Windows.Forms.NumericUpDown = Me.nudStlh
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudStlh3.Minimum = num
            Me.nudStlh.Name = "nudStlh"
            Dim nudStlh4 As Global.System.Windows.Forms.Control = Me.nudStlh
            size = New Global.System.Drawing.Size(64, 20)
            nudStlh4.Size = size
            Me.nudStlh.TabIndex = 20
            Me.nudStlh.Tag = "20"
            Me.nudStlh.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudSrch.Enabled = False
            Dim nudSrch As Global.System.Windows.Forms.Control = Me.nudSrch
            point = New Global.System.Drawing.Point(152, 560)
            nudSrch.Location = point
            Dim nudSrch2 As Global.System.Windows.Forms.NumericUpDown = Me.nudSrch
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudSrch2.Maximum = num
            Dim nudSrch3 As Global.System.Windows.Forms.NumericUpDown = Me.nudSrch
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudSrch3.Minimum = num
            Me.nudSrch.Name = "nudSrch"
            Dim nudSrch4 As Global.System.Windows.Forms.Control = Me.nudSrch
            size = New Global.System.Drawing.Size(64, 20)
            nudSrch4.Size = size
            Me.nudSrch.TabIndex = 21
            Me.nudSrch.Tag = "21"
            Me.nudSrch.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox42.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox91 As Global.System.Windows.Forms.Control = Me.TextBox42
            point = New Global.System.Drawing.Point(368, 560)
            textBox91.Location = point
            Me.TextBox42.Name = "TextBox42"
            Me.TextBox42.[ReadOnly] = True
            Dim textBox92 As Global.System.Windows.Forms.Control = Me.TextBox42
            size = New Global.System.Drawing.Size(272, 20)
            textBox92.Size = size
            Me.TextBox42.TabIndex = 11
            Me.TextBox42.TabStop = False
            Me.TextBox42.Tag = "d21"
            Me.TextBox42.Text = ""
            Me.TextBox47.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox93 As Global.System.Windows.Forms.Control = Me.TextBox47
            point = New Global.System.Drawing.Point(368, 640)
            textBox93.Location = point
            Me.TextBox47.Name = "TextBox47"
            Me.TextBox47.[ReadOnly] = True
            Dim textBox94 As Global.System.Windows.Forms.Control = Me.TextBox47
            size = New Global.System.Drawing.Size(272, 20)
            textBox94.Size = size
            Me.TextBox47.TabIndex = 18
            Me.TextBox47.TabStop = False
            Me.TextBox47.Tag = "d24"
            Me.TextBox47.Text = ""
            Me.nudSucceedUnlock.Enabled = False
            Dim nudSucceedUnlock As Global.System.Windows.Forms.Control = Me.nudSucceedUnlock
            point = New Global.System.Drawing.Point(152, 640)
            nudSucceedUnlock.Location = point
            Dim nudSucceedUnlock2 As Global.System.Windows.Forms.NumericUpDown = Me.nudSucceedUnlock
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudSucceedUnlock2.Maximum = num
            Dim nudSucceedUnlock3 As Global.System.Windows.Forms.NumericUpDown = Me.nudSucceedUnlock
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudSucceedUnlock3.Minimum = num
            Me.nudSucceedUnlock.Name = "nudSucceedUnlock"
            Dim nudSucceedUnlock4 As Global.System.Windows.Forms.Control = Me.nudSucceedUnlock
            size = New Global.System.Drawing.Size(64, 20)
            nudSucceedUnlock4.Size = size
            Me.nudSucceedUnlock.TabIndex = 24
            Me.nudSucceedUnlock.Tag = "24"
            Me.nudSucceedUnlock.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudLeaveParty.Enabled = False
            Dim nudLeaveParty As Global.System.Windows.Forms.Control = Me.nudLeaveParty
            point = New Global.System.Drawing.Point(152, 664)
            nudLeaveParty.Location = point
            Dim nudLeaveParty2 As Global.System.Windows.Forms.NumericUpDown = Me.nudLeaveParty
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudLeaveParty2.Maximum = num
            Dim nudLeaveParty3 As Global.System.Windows.Forms.NumericUpDown = Me.nudLeaveParty
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudLeaveParty3.Minimum = num
            Me.nudLeaveParty.Name = "nudLeaveParty"
            Dim nudLeaveParty4 As Global.System.Windows.Forms.Control = Me.nudLeaveParty
            size = New Global.System.Drawing.Size(64, 20)
            nudLeaveParty4.Size = size
            Me.nudLeaveParty.TabIndex = 25
            Me.nudLeaveParty.Tag = "25"
            Me.nudLeaveParty.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox48.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox95 As Global.System.Windows.Forms.Control = Me.TextBox48
            point = New Global.System.Drawing.Point(368, 664)
            textBox95.Location = point
            Me.TextBox48.Name = "TextBox48"
            Me.TextBox48.[ReadOnly] = True
            Dim textBox96 As Global.System.Windows.Forms.Control = Me.TextBox48
            size = New Global.System.Drawing.Size(272, 20)
            textBox96.Size = size
            Me.TextBox48.TabIndex = 19
            Me.TextBox48.TabStop = False
            Me.TextBox48.Tag = "d25"
            Me.TextBox48.Text = ""
            Dim textBox97 As Global.System.Windows.Forms.Control = Me.TextBox49
            point = New Global.System.Drawing.Point(224, 664)
            textBox97.Location = point
            Me.TextBox49.Name = "TextBox49"
            Me.TextBox49.[ReadOnly] = True
            Dim textBox98 As Global.System.Windows.Forms.Control = Me.TextBox49
            size = New Global.System.Drawing.Size(136, 20)
            textBox98.Size = size
            Me.TextBox49.TabIndex = 16
            Me.TextBox49.TabStop = False
            Me.TextBox49.Tag = "rr25"
            Me.TextBox49.Text = ""
            Me.TextBox49.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox99 As Global.System.Windows.Forms.Control = Me.TextBox50
            point = New Global.System.Drawing.Point(224, 640)
            textBox99.Location = point
            Me.TextBox50.Name = "TextBox50"
            Me.TextBox50.[ReadOnly] = True
            Dim textBox100 As Global.System.Windows.Forms.Control = Me.TextBox50
            size = New Global.System.Drawing.Size(136, 20)
            textBox100.Size = size
            Me.TextBox50.TabIndex = 17
            Me.TextBox50.TabStop = False
            Me.TextBox50.Tag = "rr24"
            Me.TextBox50.Text = ""
            Me.TextBox50.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label49 As Global.System.Windows.Forms.Control = Me.Label25
            point = New Global.System.Drawing.Point(16, 712)
            label49.Location = point
            Me.Label25.Name = "Label25"
            Dim label50 As Global.System.Windows.Forms.Control = Me.Label25
            size = New Global.System.Drawing.Size(80, 16)
            label50.Size = size
            Me.Label25.TabIndex = 20
            Me.Label25.Text = "Poisoned"
            Dim label51 As Global.System.Windows.Forms.Control = Me.Label26
            point = New Global.System.Drawing.Point(16, 640)
            label51.Location = point
            Me.Label26.Name = "Label26"
            Dim label52 As Global.System.Windows.Forms.Control = Me.Label26
            size = New Global.System.Drawing.Size(88, 16)
            label52.Size = size
            Me.Label26.TabIndex = 21
            Me.Label26.Text = "Unlock Success"
            Me.TextBox51.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox101 As Global.System.Windows.Forms.Control = Me.TextBox51
            point = New Global.System.Drawing.Point(368, 688)
            textBox101.Location = point
            Me.TextBox51.Name = "TextBox51"
            Me.TextBox51.[ReadOnly] = True
            Dim textBox102 As Global.System.Windows.Forms.Control = Me.TextBox51
            size = New Global.System.Drawing.Size(272, 20)
            textBox102.Size = size
            Me.TextBox51.TabIndex = 18
            Me.TextBox51.TabStop = False
            Me.TextBox51.Tag = "d26"
            Me.TextBox51.Text = ""
            Me.nudRejoinParty.Enabled = False
            Dim nudRejoinParty As Global.System.Windows.Forms.Control = Me.nudRejoinParty
            point = New Global.System.Drawing.Point(152, 688)
            nudRejoinParty.Location = point
            Dim nudRejoinParty2 As Global.System.Windows.Forms.NumericUpDown = Me.nudRejoinParty
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudRejoinParty2.Maximum = num
            Dim nudRejoinParty3 As Global.System.Windows.Forms.NumericUpDown = Me.nudRejoinParty
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudRejoinParty3.Minimum = num
            Me.nudRejoinParty.Name = "nudRejoinParty"
            Dim nudRejoinParty4 As Global.System.Windows.Forms.Control = Me.nudRejoinParty
            size = New Global.System.Drawing.Size(64, 20)
            nudRejoinParty4.Size = size
            Me.nudRejoinParty.TabIndex = 26
            Me.nudRejoinParty.Tag = "26"
            Me.nudRejoinParty.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudPoisoned.Enabled = False
            Dim nudPoisoned As Global.System.Windows.Forms.Control = Me.nudPoisoned
            point = New Global.System.Drawing.Point(152, 712)
            nudPoisoned.Location = point
            Dim nudPoisoned2 As Global.System.Windows.Forms.NumericUpDown = Me.nudPoisoned
            num = New Decimal(New Integer() {300000, 0, 0, 0})
            nudPoisoned2.Maximum = num
            Dim nudPoisoned3 As Global.System.Windows.Forms.NumericUpDown = Me.nudPoisoned
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudPoisoned3.Minimum = num
            Me.nudPoisoned.Name = "nudPoisoned"
            Dim nudPoisoned4 As Global.System.Windows.Forms.Control = Me.nudPoisoned
            size = New Global.System.Drawing.Size(64, 20)
            nudPoisoned4.Size = size
            Me.nudPoisoned.TabIndex = 27
            Me.nudPoisoned.Tag = "27"
            Me.nudPoisoned.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox52.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim textBox103 As Global.System.Windows.Forms.Control = Me.TextBox52
            point = New Global.System.Drawing.Point(368, 712)
            textBox103.Location = point
            Me.TextBox52.Name = "TextBox52"
            Me.TextBox52.[ReadOnly] = True
            Dim textBox104 As Global.System.Windows.Forms.Control = Me.TextBox52
            size = New Global.System.Drawing.Size(272, 20)
            textBox104.Size = size
            Me.TextBox52.TabIndex = 19
            Me.TextBox52.TabStop = False
            Me.TextBox52.Tag = "d27"
            Me.TextBox52.Text = ""
            Dim textBox105 As Global.System.Windows.Forms.Control = Me.TextBox53
            point = New Global.System.Drawing.Point(224, 712)
            textBox105.Location = point
            Me.TextBox53.Name = "TextBox53"
            Me.TextBox53.[ReadOnly] = True
            Dim textBox106 As Global.System.Windows.Forms.Control = Me.TextBox53
            size = New Global.System.Drawing.Size(136, 20)
            textBox106.Size = size
            Me.TextBox53.TabIndex = 16
            Me.TextBox53.TabStop = False
            Me.TextBox53.Tag = "rr27"
            Me.TextBox53.Text = ""
            Me.TextBox53.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim textBox107 As Global.System.Windows.Forms.Control = Me.TextBox54
            point = New Global.System.Drawing.Point(224, 688)
            textBox107.Location = point
            Me.TextBox54.Name = "TextBox54"
            Me.TextBox54.[ReadOnly] = True
            Dim textBox108 As Global.System.Windows.Forms.Control = Me.TextBox54
            size = New Global.System.Drawing.Size(136, 20)
            textBox108.Size = size
            Me.TextBox54.TabIndex = 17
            Me.TextBox54.TabStop = False
            Me.TextBox54.Tag = "rr26"
            Me.TextBox54.Text = ""
            Me.TextBox54.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label53 As Global.System.Windows.Forms.Control = Me.label111
            point = New Global.System.Drawing.Point(16, 688)
            label53.Location = point
            Me.label111.Name = "label111"
            Dim label54 As Global.System.Windows.Forms.Control = Me.label111
            size = New Global.System.Drawing.Size(80, 16)
            label54.Size = size
            Me.label111.TabIndex = 20
            Me.label111.Text = "Rejoin Party"
            Dim label55 As Global.System.Windows.Forms.Control = Me.Label28
            point = New Global.System.Drawing.Point(16, 664)
            label55.Location = point
            Me.Label28.Name = "Label28"
            Dim label56 As Global.System.Windows.Forms.Control = Me.Label28
            size = New Global.System.Drawing.Size(112, 16)
            label56.Size = size
            Me.Label28.TabIndex = 21
            Me.Label28.Text = "Separate from Party"
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miNew, Me.miOpen, Me.miSave, Me.miSaveAs, Me.MenuItem5, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            Me.miNew.Index = 0
            Me.miNew.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlN
            Me.miNew.Text = "&New"
            Me.miOpen.Index = 1
            Me.miOpen.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpen.Text = "&Open..."
            Me.miSave.Enabled = False
            Me.miSave.Index = 2
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            Me.miSaveAs.Enabled = False
            Me.miSaveAs.Index = 3
            Me.miSaveAs.Text = "Save &As..."
            Me.MenuItem5.Index = 4
            Me.MenuItem5.Text = "-"
            Me.miQuit.Index = 5
            Me.miQuit.Text = "E&xit"
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miUseK1DialogTlk, Me.miUseK2DialogTlk, Me.miUseExtDialogTlk, Me.miAskDialogTlk})
            Me.MenuItem2.Text = "Options"
            Me.miUseK1DialogTlk.Index = 0
            Me.miUseK1DialogTlk.Text = "Use KotOR I Dialog.Tlk"
            Me.miUseK2DialogTlk.Index = 1
            Me.miUseK2DialogTlk.Text = "Use KotOR II Dialog.Tlk"
            Me.miUseExtDialogTlk.Index = 2
            Me.miUseExtDialogTlk.Text = "Use External Dialog.Tlk"
            Me.miAskDialogTlk.Checked = True
            Me.miAskDialogTlk.Index = 3
            Me.miAskDialogTlk.Text = "Ask which Dialog.Tlk for each file"
            Dim statusBar As Global.System.Windows.Forms.Control = Me.StatusBar1
            point = New Global.System.Drawing.Point(0, 363)
            statusBar.Location = point
            Me.StatusBar1.Name = "StatusBar1"
            Dim statusBar2 As Global.System.Windows.Forms.Control = Me.StatusBar1
            size = New Global.System.Drawing.Size(688, 22)
            statusBar2.Size = size
            Me.StatusBar1.TabIndex = 7
            Me.StatusBar1.Text = "StatusBar1"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(688, 385)
            Me.ClientSize = size
            Me.Controls.Add(Me.StatusBar1)
            Me.Controls.Add(Me.Panel1)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmSSFEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "SSF Editor"
            CType(Me.nudBat1, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudBat2, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudBat3, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudBat4, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.nudTryUnlock, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFailUnlock, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudBat5, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudBat6, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSel1, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSel3, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSel2, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudAtk2, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudAtk1, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudAtk3, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudHit2, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudHit1, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDead, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudLowHlth, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCrit, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTIA, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudLMin, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDMin, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStlh, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSucceedUnlock, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudLeaveParty, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRejoinParty, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudPoisoned, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040007D4 RID: 2004
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
