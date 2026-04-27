Namespace kotor_tool
	' Token: 0x02000076 RID: 118
	Public Partial Class frmSSFEditor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents nudBat1 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbBat1ResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbBat1Desc As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox1 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox2 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox3 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox4 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox5 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox6 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Panel1 As Global.System.Windows.Forms.Panel
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox7 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox8 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox9 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox10 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox11 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox12 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox13 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox14 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox15 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox16 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox17 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox18 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox19 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox20 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox21 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox22 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox23 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox24 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox25 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox26 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox27 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox28 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox29 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox30 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox31 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox32 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox33 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox34 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox35 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox36 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox37 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox38 As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudBat2 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudBat3 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudBat4 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudBat5 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudBat6 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudSel1 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudSel3 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudSel2 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudAtk2 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudAtk1 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudAtk3 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudHit2 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudHit1 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudDead As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudLowHlth As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCrit As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudTIA As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudLMin As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudDMin As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents TextBox39 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox40 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox41 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox42 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox43 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox44 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox45 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox46 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox47 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox48 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox49 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox50 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents Label26 As Global.System.Windows.Forms.Label
        Friend WithEvents TextBox51 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox52 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox53 As Global.System.Windows.Forms.TextBox
        Friend WithEvents TextBox54 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label28 As Global.System.Windows.Forms.Label
        Friend WithEvents nudStlh As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudSrch As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudTryUnlock As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFailUnlock As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudSucceedUnlock As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudLeaveParty As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRejoinParty As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudPoisoned As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents label111 As Global.System.Windows.Forms.Label
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSave As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miNew As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpen As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSaveAs As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miUseK1DialogTlk As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miUseK2DialogTlk As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miUseExtDialogTlk As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miAskDialogTlk As Global.System.Windows.Forms.MenuItem
        Friend WithEvents StatusBar1 As Global.System.Windows.Forms.StatusBar
        Friend WithEvents ToolTip1 As Global.System.Windows.Forms.ToolTip


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
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip()
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
            Me.nudBat1.Location = New Global.System.Drawing.Point(152, 16)
            Me.nudBat1.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudBat1.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudBat1.Name = "nudBat1"
            Me.nudBat1.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudBat1.TabIndex = 0
            Me.nudBat1.Tag = "0"
            Me.nudBat1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbBat1ResRef.Location = New Global.System.Drawing.Point(224, 16)
            Me.tbBat1ResRef.Name = "tbBat1ResRef"
            Me.tbBat1ResRef.[ReadOnly] = True
            Me.tbBat1ResRef.Size = New Global.System.Drawing.Size(136, 20)
            Me.tbBat1ResRef.TabIndex = 4
            Me.tbBat1ResRef.TabStop = False
            Me.tbBat1ResRef.Tag = "rr0"
            Me.tbBat1ResRef.Text = ""
            Me.tbBat1ResRef.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbBat1Desc.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbBat1Desc.Location = New Global.System.Drawing.Point(368, 16)
            Me.tbBat1Desc.Name = "tbBat1Desc"
            Me.tbBat1Desc.[ReadOnly] = True
            Me.tbBat1Desc.Size = New Global.System.Drawing.Size(272, 20)
            Me.tbBat1Desc.TabIndex = 4
            Me.tbBat1Desc.TabStop = False
            Me.tbBat1Desc.Tag = "d0"
            Me.tbBat1Desc.Text = ""
            Me.Label1.Location = New Global.System.Drawing.Point(16, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Battlecry 1"
            Me.TextBox1.Location = New Global.System.Drawing.Point(224, 40)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.[ReadOnly] = True
            Me.TextBox1.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox1.TabIndex = 4
            Me.TextBox1.TabStop = False
            Me.TextBox1.Tag = "rr1"
            Me.TextBox1.Text = ""
            Me.TextBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox2.Location = New Global.System.Drawing.Point(368, 40)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.[ReadOnly] = True
            Me.TextBox2.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox2.TabIndex = 4
            Me.TextBox2.TabStop = False
            Me.TextBox2.Tag = "d1"
            Me.TextBox2.Text = ""
            Me.nudBat2.Enabled = False
            Me.nudBat2.Location = New Global.System.Drawing.Point(152, 40)
            Me.nudBat2.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudBat2.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudBat2.Name = "nudBat2"
            Me.nudBat2.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudBat2.TabIndex = 1
            Me.nudBat2.Tag = "1"
            Me.nudBat2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label2.Location = New Global.System.Drawing.Point(16, 40)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Battlecry 2"
            Me.TextBox3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox3.Location = New Global.System.Drawing.Point(368, 64)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.[ReadOnly] = True
            Me.TextBox3.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox3.TabIndex = 4
            Me.TextBox3.TabStop = False
            Me.TextBox3.Tag = "d2"
            Me.TextBox3.Text = ""
            Me.TextBox4.Location = New Global.System.Drawing.Point(224, 64)
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.[ReadOnly] = True
            Me.TextBox4.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox4.TabIndex = 4
            Me.TextBox4.TabStop = False
            Me.TextBox4.Tag = "rr2"
            Me.TextBox4.Text = ""
            Me.TextBox4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label3.Location = New Global.System.Drawing.Point(16, 64)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Battlecry 3"
            Me.nudBat3.Enabled = False
            Me.nudBat3.Location = New Global.System.Drawing.Point(152, 64)
            Me.nudBat3.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudBat3.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudBat3.Name = "nudBat3"
            Me.nudBat3.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudBat3.TabIndex = 2
            Me.nudBat3.Tag = "2"
            Me.nudBat3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox5.Location = New Global.System.Drawing.Point(224, 88)
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.[ReadOnly] = True
            Me.TextBox5.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox5.TabIndex = 4
            Me.TextBox5.TabStop = False
            Me.TextBox5.Tag = "rr3"
            Me.TextBox5.Text = ""
            Me.TextBox5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox6.Location = New Global.System.Drawing.Point(368, 88)
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.[ReadOnly] = True
            Me.TextBox6.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox6.TabIndex = 4
            Me.TextBox6.TabStop = False
            Me.TextBox6.Tag = "d3"
            Me.TextBox6.Text = ""
            Me.nudBat4.Enabled = False
            Me.nudBat4.Location = New Global.System.Drawing.Point(152, 88)
            Me.nudBat4.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudBat4.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudBat4.Name = "nudBat4"
            Me.nudBat4.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudBat4.TabIndex = 3
            Me.nudBat4.Tag = "3"
            Me.nudBat4.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label4.Location = New Global.System.Drawing.Point(16, 88)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(64, 16)
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
            Me.Panel1.Location = New Global.System.Drawing.Point(8, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New Global.System.Drawing.Size(672, 336)
            Me.Panel1.TabIndex = 6
            Me.TextBox43.Location = New Global.System.Drawing.Point(224, 592)
            Me.TextBox43.Name = "TextBox43"
            Me.TextBox43.[ReadOnly] = True
            Me.TextBox43.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox43.TabIndex = 17
            Me.TextBox43.TabStop = False
            Me.TextBox43.Tag = "rr22"
            Me.TextBox43.Text = ""
            Me.TextBox43.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label23.Location = New Global.System.Drawing.Point(16, 616)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label23.TabIndex = 20
            Me.Label23.Text = "Unlock Failed"
            Me.TextBox44.Location = New Global.System.Drawing.Point(224, 616)
            Me.TextBox44.Name = "TextBox44"
            Me.TextBox44.[ReadOnly] = True
            Me.TextBox44.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox44.TabIndex = 16
            Me.TextBox44.TabStop = False
            Me.TextBox44.Tag = "rr23"
            Me.TextBox44.Text = ""
            Me.TextBox44.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label24.Location = New Global.System.Drawing.Point(16, 592)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label24.TabIndex = 21
            Me.Label24.Text = "Begin Unlock"
            Me.TextBox45.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox45.Location = New Global.System.Drawing.Point(368, 592)
            Me.TextBox45.Name = "TextBox45"
            Me.TextBox45.[ReadOnly] = True
            Me.TextBox45.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox45.TabIndex = 18
            Me.TextBox45.TabStop = False
            Me.TextBox45.Tag = "d22"
            Me.TextBox45.Text = ""
            Me.nudTryUnlock.Enabled = False
            Me.nudTryUnlock.Location = New Global.System.Drawing.Point(152, 592)
            Me.nudTryUnlock.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudTryUnlock.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudTryUnlock.Name = "nudTryUnlock"
            Me.nudTryUnlock.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudTryUnlock.TabIndex = 22
            Me.nudTryUnlock.Tag = "22"
            Me.nudTryUnlock.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFailUnlock.Enabled = False
            Me.nudFailUnlock.Location = New Global.System.Drawing.Point(152, 616)
            Me.nudFailUnlock.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudFailUnlock.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudFailUnlock.Name = "nudFailUnlock"
            Me.nudFailUnlock.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudFailUnlock.TabIndex = 23
            Me.nudFailUnlock.Tag = "23"
            Me.nudFailUnlock.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox46.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox46.Location = New Global.System.Drawing.Point(368, 616)
            Me.TextBox46.Name = "TextBox46"
            Me.TextBox46.[ReadOnly] = True
            Me.TextBox46.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox46.TabIndex = 19
            Me.TextBox46.TabStop = False
            Me.TextBox46.Tag = "d23"
            Me.TextBox46.Text = ""
            Me.TextBox9.Location = New Global.System.Drawing.Point(224, 112)
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.[ReadOnly] = True
            Me.TextBox9.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox9.TabIndex = 9
            Me.TextBox9.TabStop = False
            Me.TextBox9.Tag = "rr4"
            Me.TextBox9.Text = ""
            Me.TextBox9.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label6.Location = New Global.System.Drawing.Point(16, 112)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label6.TabIndex = 13
            Me.Label6.Text = "Battlecry 5"
            Me.TextBox8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox8.Location = New Global.System.Drawing.Point(368, 112)
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.[ReadOnly] = True
            Me.TextBox8.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox8.TabIndex = 11
            Me.TextBox8.TabStop = False
            Me.TextBox8.Tag = "d4"
            Me.TextBox8.Text = ""
            Me.TextBox7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox7.Location = New Global.System.Drawing.Point(368, 136)
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.[ReadOnly] = True
            Me.TextBox7.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox7.TabIndex = 10
            Me.TextBox7.TabStop = False
            Me.TextBox7.Tag = "d5"
            Me.TextBox7.Text = ""
            Me.nudBat5.Enabled = False
            Me.nudBat5.Location = New Global.System.Drawing.Point(152, 112)
            Me.nudBat5.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudBat5.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudBat5.Name = "nudBat5"
            Me.nudBat5.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudBat5.TabIndex = 4
            Me.nudBat5.Tag = "4"
            Me.nudBat5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox10.Location = New Global.System.Drawing.Point(224, 136)
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.[ReadOnly] = True
            Me.TextBox10.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox10.TabIndex = 8
            Me.TextBox10.TabStop = False
            Me.TextBox10.Tag = "rr5"
            Me.TextBox10.Text = ""
            Me.TextBox10.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label5.Location = New Global.System.Drawing.Point(16, 136)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label5.TabIndex = 12
            Me.Label5.Text = "Battlecry 6"
            Me.nudBat6.Enabled = False
            Me.nudBat6.Location = New Global.System.Drawing.Point(152, 136)
            Me.nudBat6.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudBat6.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudBat6.Name = "nudBat6"
            Me.nudBat6.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudBat6.TabIndex = 5
            Me.nudBat6.Tag = "5"
            Me.nudBat6.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudSel1.Enabled = False
            Me.nudSel1.Location = New Global.System.Drawing.Point(152, 168)
            Me.nudSel1.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudSel1.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudSel1.Name = "nudSel1"
            Me.nudSel1.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudSel1.TabIndex = 6
            Me.nudSel1.Tag = "6"
            Me.nudSel1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox11.Location = New Global.System.Drawing.Point(224, 168)
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.[ReadOnly] = True
            Me.TextBox11.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox11.TabIndex = 4
            Me.TextBox11.TabStop = False
            Me.TextBox11.Tag = "rr6"
            Me.TextBox11.Text = ""
            Me.TextBox11.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox12.Location = New Global.System.Drawing.Point(368, 168)
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.[ReadOnly] = True
            Me.TextBox12.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox12.TabIndex = 4
            Me.TextBox12.TabStop = False
            Me.TextBox12.Tag = "d6"
            Me.TextBox12.Text = ""
            Me.TextBox13.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox13.Location = New Global.System.Drawing.Point(368, 216)
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.[ReadOnly] = True
            Me.TextBox13.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox13.TabIndex = 4
            Me.TextBox13.TabStop = False
            Me.TextBox13.Tag = "d8"
            Me.TextBox13.Text = ""
            Me.TextBox14.Location = New Global.System.Drawing.Point(224, 216)
            Me.TextBox14.Name = "TextBox14"
            Me.TextBox14.[ReadOnly] = True
            Me.TextBox14.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox14.TabIndex = 4
            Me.TextBox14.TabStop = False
            Me.TextBox14.Tag = "rr8"
            Me.TextBox14.Text = ""
            Me.TextBox14.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label7.Location = New Global.System.Drawing.Point(16, 216)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label7.TabIndex = 5
            Me.Label7.Text = "Select 3"
            Me.nudSel3.Enabled = False
            Me.nudSel3.Location = New Global.System.Drawing.Point(152, 216)
            Me.nudSel3.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudSel3.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudSel3.Name = "nudSel3"
            Me.nudSel3.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudSel3.TabIndex = 8
            Me.nudSel3.Tag = "8"
            Me.nudSel3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox15.Location = New Global.System.Drawing.Point(224, 192)
            Me.TextBox15.Name = "TextBox15"
            Me.TextBox15.[ReadOnly] = True
            Me.TextBox15.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox15.TabIndex = 4
            Me.TextBox15.TabStop = False
            Me.TextBox15.Tag = "rr7"
            Me.TextBox15.Text = ""
            Me.TextBox15.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox16.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox16.Location = New Global.System.Drawing.Point(368, 192)
            Me.TextBox16.Name = "TextBox16"
            Me.TextBox16.[ReadOnly] = True
            Me.TextBox16.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox16.TabIndex = 4
            Me.TextBox16.TabStop = False
            Me.TextBox16.Tag = "d7"
            Me.TextBox16.Text = ""
            Me.nudSel2.Enabled = False
            Me.nudSel2.Location = New Global.System.Drawing.Point(152, 192)
            Me.nudSel2.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudSel2.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudSel2.Name = "nudSel2"
            Me.nudSel2.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudSel2.TabIndex = 7
            Me.nudSel2.Tag = "7"
            Me.nudSel2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label8.Location = New Global.System.Drawing.Point(16, 192)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label8.TabIndex = 5
            Me.Label8.Text = "Select 2"
            Me.Label9.Location = New Global.System.Drawing.Point(16, 168)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label9.TabIndex = 5
            Me.Label9.Text = "Select 1"
            Me.TextBox17.Location = New Global.System.Drawing.Point(224, 272)
            Me.TextBox17.Name = "TextBox17"
            Me.TextBox17.[ReadOnly] = True
            Me.TextBox17.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox17.TabIndex = 4
            Me.TextBox17.TabStop = False
            Me.TextBox17.Tag = "rr10"
            Me.TextBox17.Text = ""
            Me.TextBox17.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox18.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox18.Location = New Global.System.Drawing.Point(368, 272)
            Me.TextBox18.Name = "TextBox18"
            Me.TextBox18.[ReadOnly] = True
            Me.TextBox18.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox18.TabIndex = 4
            Me.TextBox18.TabStop = False
            Me.TextBox18.Tag = "d10"
            Me.TextBox18.Text = ""
            Me.nudAtk2.Enabled = False
            Me.nudAtk2.Location = New Global.System.Drawing.Point(152, 272)
            Me.nudAtk2.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudAtk2.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudAtk2.Name = "nudAtk2"
            Me.nudAtk2.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudAtk2.TabIndex = 10
            Me.nudAtk2.Tag = "10"
            Me.nudAtk2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label10.Location = New Global.System.Drawing.Point(16, 272)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label10.TabIndex = 5
            Me.Label10.Text = "Attack Grunt 2"
            Me.Label11.Location = New Global.System.Drawing.Point(16, 248)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label11.TabIndex = 5
            Me.Label11.Text = "Attack Grunt 1"
            Me.nudAtk1.Enabled = False
            Me.nudAtk1.Location = New Global.System.Drawing.Point(152, 248)
            Me.nudAtk1.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudAtk1.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudAtk1.Name = "nudAtk1"
            Me.nudAtk1.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudAtk1.TabIndex = 9
            Me.nudAtk1.Tag = "9"
            Me.nudAtk1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox19.Location = New Global.System.Drawing.Point(224, 248)
            Me.TextBox19.Name = "TextBox19"
            Me.TextBox19.[ReadOnly] = True
            Me.TextBox19.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox19.TabIndex = 4
            Me.TextBox19.TabStop = False
            Me.TextBox19.Tag = "rr9"
            Me.TextBox19.Text = ""
            Me.TextBox19.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox20.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox20.Location = New Global.System.Drawing.Point(368, 248)
            Me.TextBox20.Name = "TextBox20"
            Me.TextBox20.[ReadOnly] = True
            Me.TextBox20.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox20.TabIndex = 4
            Me.TextBox20.TabStop = False
            Me.TextBox20.Tag = "d9"
            Me.TextBox20.Text = ""
            Me.TextBox21.Location = New Global.System.Drawing.Point(224, 296)
            Me.TextBox21.Name = "TextBox21"
            Me.TextBox21.[ReadOnly] = True
            Me.TextBox21.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox21.TabIndex = 4
            Me.TextBox21.TabStop = False
            Me.TextBox21.Tag = "rr11"
            Me.TextBox21.Text = ""
            Me.TextBox21.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox22.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox22.Location = New Global.System.Drawing.Point(368, 296)
            Me.TextBox22.Name = "TextBox22"
            Me.TextBox22.[ReadOnly] = True
            Me.TextBox22.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox22.TabIndex = 4
            Me.TextBox22.TabStop = False
            Me.TextBox22.Tag = "d11"
            Me.TextBox22.Text = ""
            Me.nudAtk3.Enabled = False
            Me.nudAtk3.Location = New Global.System.Drawing.Point(152, 296)
            Me.nudAtk3.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudAtk3.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudAtk3.Name = "nudAtk3"
            Me.nudAtk3.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudAtk3.TabIndex = 11
            Me.nudAtk3.Tag = "11"
            Me.nudAtk3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label12.Location = New Global.System.Drawing.Point(16, 296)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label12.TabIndex = 5
            Me.Label12.Text = "Attack Grunt 3"
            Me.nudHit2.Enabled = False
            Me.nudHit2.Location = New Global.System.Drawing.Point(152, 352)
            Me.nudHit2.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudHit2.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudHit2.Name = "nudHit2"
            Me.nudHit2.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudHit2.TabIndex = 13
            Me.nudHit2.Tag = "13"
            Me.nudHit2.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label13.Location = New Global.System.Drawing.Point(16, 352)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label13.TabIndex = 5
            Me.Label13.Text = "Pain Grunt 2"
            Me.Label14.Location = New Global.System.Drawing.Point(16, 328)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label14.TabIndex = 5
            Me.Label14.Text = "Pain Grunt 1"
            Me.nudHit1.Enabled = False
            Me.nudHit1.Location = New Global.System.Drawing.Point(152, 328)
            Me.nudHit1.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudHit1.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudHit1.Name = "nudHit1"
            Me.nudHit1.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudHit1.TabIndex = 12
            Me.nudHit1.Tag = "12"
            Me.nudHit1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox23.Location = New Global.System.Drawing.Point(224, 328)
            Me.TextBox23.Name = "TextBox23"
            Me.TextBox23.[ReadOnly] = True
            Me.TextBox23.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox23.TabIndex = 4
            Me.TextBox23.TabStop = False
            Me.TextBox23.Tag = "rr12"
            Me.TextBox23.Text = ""
            Me.TextBox23.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox24.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox24.Location = New Global.System.Drawing.Point(368, 328)
            Me.TextBox24.Name = "TextBox24"
            Me.TextBox24.[ReadOnly] = True
            Me.TextBox24.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox24.TabIndex = 4
            Me.TextBox24.TabStop = False
            Me.TextBox24.Tag = "d12"
            Me.TextBox24.Text = ""
            Me.TextBox25.Location = New Global.System.Drawing.Point(224, 352)
            Me.TextBox25.Name = "TextBox25"
            Me.TextBox25.[ReadOnly] = True
            Me.TextBox25.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox25.TabIndex = 4
            Me.TextBox25.TabStop = False
            Me.TextBox25.Tag = "rr13"
            Me.TextBox25.Text = ""
            Me.TextBox25.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox26.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox26.Location = New Global.System.Drawing.Point(368, 352)
            Me.TextBox26.Name = "TextBox26"
            Me.TextBox26.[ReadOnly] = True
            Me.TextBox26.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox26.TabIndex = 4
            Me.TextBox26.TabStop = False
            Me.TextBox26.Tag = "d13"
            Me.TextBox26.Text = ""
            Me.TextBox27.Location = New Global.System.Drawing.Point(224, 408)
            Me.TextBox27.Name = "TextBox27"
            Me.TextBox27.[ReadOnly] = True
            Me.TextBox27.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox27.TabIndex = 4
            Me.TextBox27.TabStop = False
            Me.TextBox27.Tag = "rr15"
            Me.TextBox27.Text = ""
            Me.TextBox27.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox28.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox28.Location = New Global.System.Drawing.Point(368, 408)
            Me.TextBox28.Name = "TextBox28"
            Me.TextBox28.[ReadOnly] = True
            Me.TextBox28.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox28.TabIndex = 4
            Me.TextBox28.TabStop = False
            Me.TextBox28.Tag = "d15"
            Me.TextBox28.Text = ""
            Me.nudDead.Enabled = False
            Me.nudDead.Location = New Global.System.Drawing.Point(152, 408)
            Me.nudDead.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudDead.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudDead.Name = "nudDead"
            Me.nudDead.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudDead.TabIndex = 15
            Me.nudDead.Tag = "15"
            Me.nudDead.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label15.Location = New Global.System.Drawing.Point(16, 408)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label15.TabIndex = 5
            Me.Label15.Text = "Dead"
            Me.TextBox29.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox29.Location = New Global.System.Drawing.Point(368, 432)
            Me.TextBox29.Name = "TextBox29"
            Me.TextBox29.[ReadOnly] = True
            Me.TextBox29.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox29.TabIndex = 4
            Me.TextBox29.TabStop = False
            Me.TextBox29.Tag = "d16"
            Me.TextBox29.Text = ""
            Me.nudLowHlth.Enabled = False
            Me.nudLowHlth.Location = New Global.System.Drawing.Point(152, 384)
            Me.nudLowHlth.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudLowHlth.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudLowHlth.Name = "nudLowHlth"
            Me.nudLowHlth.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudLowHlth.TabIndex = 14
            Me.nudLowHlth.Tag = "14"
            Me.nudLowHlth.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox30.Location = New Global.System.Drawing.Point(224, 432)
            Me.TextBox30.Name = "TextBox30"
            Me.TextBox30.[ReadOnly] = True
            Me.TextBox30.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox30.TabIndex = 4
            Me.TextBox30.TabStop = False
            Me.TextBox30.Tag = "rr16"
            Me.TextBox30.Text = ""
            Me.TextBox30.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label16.Location = New Global.System.Drawing.Point(16, 432)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label16.TabIndex = 5
            Me.Label16.Text = "Critical Hit"
            Me.nudCrit.Enabled = False
            Me.nudCrit.Location = New Global.System.Drawing.Point(152, 432)
            Me.nudCrit.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudCrit.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudCrit.Name = "nudCrit"
            Me.nudCrit.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudCrit.TabIndex = 16
            Me.nudCrit.Tag = "16"
            Me.nudCrit.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox31.Location = New Global.System.Drawing.Point(224, 456)
            Me.TextBox31.Name = "TextBox31"
            Me.TextBox31.[ReadOnly] = True
            Me.TextBox31.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox31.TabIndex = 4
            Me.TextBox31.TabStop = False
            Me.TextBox31.Tag = "rr17"
            Me.TextBox31.Text = ""
            Me.TextBox31.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox32.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox32.Location = New Global.System.Drawing.Point(368, 456)
            Me.TextBox32.Name = "TextBox32"
            Me.TextBox32.[ReadOnly] = True
            Me.TextBox32.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox32.TabIndex = 4
            Me.TextBox32.TabStop = False
            Me.TextBox32.Tag = "d17"
            Me.TextBox32.Text = ""
            Me.nudTIA.Enabled = False
            Me.nudTIA.Location = New Global.System.Drawing.Point(152, 456)
            Me.nudTIA.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudTIA.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudTIA.Name = "nudTIA"
            Me.nudTIA.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudTIA.TabIndex = 17
            Me.nudTIA.Tag = "17"
            Me.nudTIA.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label17.Location = New Global.System.Drawing.Point(16, 456)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Global.System.Drawing.Size(152, 16)
            Me.Label17.TabIndex = 5
            Me.Label17.Text = "Target Immune to Assault"
            Me.TextBox33.Location = New Global.System.Drawing.Point(224, 480)
            Me.TextBox33.Name = "TextBox33"
            Me.TextBox33.[ReadOnly] = True
            Me.TextBox33.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox33.TabIndex = 9
            Me.TextBox33.TabStop = False
            Me.TextBox33.Tag = "rr18"
            Me.TextBox33.Text = ""
            Me.TextBox33.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label18.Location = New Global.System.Drawing.Point(16, 480)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label18.TabIndex = 13
            Me.Label18.Text = "Lay Mine"
            Me.TextBox34.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox34.Location = New Global.System.Drawing.Point(368, 480)
            Me.TextBox34.Name = "TextBox34"
            Me.TextBox34.[ReadOnly] = True
            Me.TextBox34.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox34.TabIndex = 11
            Me.TextBox34.TabStop = False
            Me.TextBox34.Tag = "d18"
            Me.TextBox34.Text = ""
            Me.TextBox35.Location = New Global.System.Drawing.Point(224, 384)
            Me.TextBox35.Name = "TextBox35"
            Me.TextBox35.[ReadOnly] = True
            Me.TextBox35.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox35.TabIndex = 4
            Me.TextBox35.TabStop = False
            Me.TextBox35.Tag = "rr14"
            Me.TextBox35.Text = ""
            Me.TextBox35.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox36.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox36.Location = New Global.System.Drawing.Point(368, 384)
            Me.TextBox36.Name = "TextBox36"
            Me.TextBox36.[ReadOnly] = True
            Me.TextBox36.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox36.TabIndex = 4
            Me.TextBox36.TabStop = False
            Me.TextBox36.Tag = "d14"
            Me.TextBox36.Text = ""
            Me.nudLMin.Enabled = False
            Me.nudLMin.Location = New Global.System.Drawing.Point(152, 480)
            Me.nudLMin.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudLMin.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudLMin.Name = "nudLMin"
            Me.nudLMin.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudLMin.TabIndex = 18
            Me.nudLMin.Tag = "18"
            Me.nudLMin.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label19.Location = New Global.System.Drawing.Point(16, 384)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label19.TabIndex = 5
            Me.Label19.Text = "Low Health"
            Me.nudDMin.Enabled = False
            Me.nudDMin.Location = New Global.System.Drawing.Point(152, 504)
            Me.nudDMin.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudDMin.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudDMin.Name = "nudDMin"
            Me.nudDMin.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudDMin.TabIndex = 19
            Me.nudDMin.Tag = "19"
            Me.nudDMin.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox37.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox37.Location = New Global.System.Drawing.Point(368, 504)
            Me.TextBox37.Name = "TextBox37"
            Me.TextBox37.[ReadOnly] = True
            Me.TextBox37.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox37.TabIndex = 11
            Me.TextBox37.TabStop = False
            Me.TextBox37.Tag = "d19"
            Me.TextBox37.Text = ""
            Me.Label20.Location = New Global.System.Drawing.Point(16, 504)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label20.TabIndex = 13
            Me.Label20.Text = "Disarm Mine"
            Me.TextBox38.Location = New Global.System.Drawing.Point(224, 504)
            Me.TextBox38.Name = "TextBox38"
            Me.TextBox38.[ReadOnly] = True
            Me.TextBox38.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox38.TabIndex = 9
            Me.TextBox38.TabStop = False
            Me.TextBox38.Tag = "rr19"
            Me.TextBox38.Text = ""
            Me.TextBox38.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox39.Location = New Global.System.Drawing.Point(224, 536)
            Me.TextBox39.Name = "TextBox39"
            Me.TextBox39.[ReadOnly] = True
            Me.TextBox39.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox39.TabIndex = 9
            Me.TextBox39.TabStop = False
            Me.TextBox39.Tag = "rr20"
            Me.TextBox39.Text = ""
            Me.TextBox39.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label21.Location = New Global.System.Drawing.Point(16, 560)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label21.TabIndex = 13
            Me.Label21.Text = "Begin Search"
            Me.TextBox40.Location = New Global.System.Drawing.Point(224, 560)
            Me.TextBox40.Name = "TextBox40"
            Me.TextBox40.[ReadOnly] = True
            Me.TextBox40.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox40.TabIndex = 9
            Me.TextBox40.TabStop = False
            Me.TextBox40.Tag = "rr21"
            Me.TextBox40.Text = ""
            Me.TextBox40.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label22.Location = New Global.System.Drawing.Point(16, 536)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label22.TabIndex = 13
            Me.Label22.Text = "Begin Stealth"
            Me.TextBox41.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox41.Location = New Global.System.Drawing.Point(368, 536)
            Me.TextBox41.Name = "TextBox41"
            Me.TextBox41.[ReadOnly] = True
            Me.TextBox41.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox41.TabIndex = 11
            Me.TextBox41.TabStop = False
            Me.TextBox41.Tag = "d20"
            Me.TextBox41.Text = ""
            Me.nudStlh.Enabled = False
            Me.nudStlh.Location = New Global.System.Drawing.Point(152, 536)
            Me.nudStlh.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudStlh.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudStlh.Name = "nudStlh"
            Me.nudStlh.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudStlh.TabIndex = 20
            Me.nudStlh.Tag = "20"
            Me.nudStlh.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudSrch.Enabled = False
            Me.nudSrch.Location = New Global.System.Drawing.Point(152, 560)
            Me.nudSrch.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudSrch.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudSrch.Name = "nudSrch"
            Me.nudSrch.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudSrch.TabIndex = 21
            Me.nudSrch.Tag = "21"
            Me.nudSrch.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox42.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox42.Location = New Global.System.Drawing.Point(368, 560)
            Me.TextBox42.Name = "TextBox42"
            Me.TextBox42.[ReadOnly] = True
            Me.TextBox42.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox42.TabIndex = 11
            Me.TextBox42.TabStop = False
            Me.TextBox42.Tag = "d21"
            Me.TextBox42.Text = ""
            Me.TextBox47.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox47.Location = New Global.System.Drawing.Point(368, 640)
            Me.TextBox47.Name = "TextBox47"
            Me.TextBox47.[ReadOnly] = True
            Me.TextBox47.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox47.TabIndex = 18
            Me.TextBox47.TabStop = False
            Me.TextBox47.Tag = "d24"
            Me.TextBox47.Text = ""
            Me.nudSucceedUnlock.Enabled = False
            Me.nudSucceedUnlock.Location = New Global.System.Drawing.Point(152, 640)
            Me.nudSucceedUnlock.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudSucceedUnlock.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudSucceedUnlock.Name = "nudSucceedUnlock"
            Me.nudSucceedUnlock.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudSucceedUnlock.TabIndex = 24
            Me.nudSucceedUnlock.Tag = "24"
            Me.nudSucceedUnlock.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudLeaveParty.Enabled = False
            Me.nudLeaveParty.Location = New Global.System.Drawing.Point(152, 664)
            Me.nudLeaveParty.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudLeaveParty.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudLeaveParty.Name = "nudLeaveParty"
            Me.nudLeaveParty.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudLeaveParty.TabIndex = 25
            Me.nudLeaveParty.Tag = "25"
            Me.nudLeaveParty.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox48.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox48.Location = New Global.System.Drawing.Point(368, 664)
            Me.TextBox48.Name = "TextBox48"
            Me.TextBox48.[ReadOnly] = True
            Me.TextBox48.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox48.TabIndex = 19
            Me.TextBox48.TabStop = False
            Me.TextBox48.Tag = "d25"
            Me.TextBox48.Text = ""
            Me.TextBox49.Location = New Global.System.Drawing.Point(224, 664)
            Me.TextBox49.Name = "TextBox49"
            Me.TextBox49.[ReadOnly] = True
            Me.TextBox49.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox49.TabIndex = 16
            Me.TextBox49.TabStop = False
            Me.TextBox49.Tag = "rr25"
            Me.TextBox49.Text = ""
            Me.TextBox49.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox50.Location = New Global.System.Drawing.Point(224, 640)
            Me.TextBox50.Name = "TextBox50"
            Me.TextBox50.[ReadOnly] = True
            Me.TextBox50.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox50.TabIndex = 17
            Me.TextBox50.TabStop = False
            Me.TextBox50.Tag = "rr24"
            Me.TextBox50.Text = ""
            Me.TextBox50.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label25.Location = New Global.System.Drawing.Point(16, 712)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label25.TabIndex = 20
            Me.Label25.Text = "Poisoned"
            Me.Label26.Location = New Global.System.Drawing.Point(16, 640)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label26.TabIndex = 21
            Me.Label26.Text = "Unlock Success"
            Me.TextBox51.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox51.Location = New Global.System.Drawing.Point(368, 688)
            Me.TextBox51.Name = "TextBox51"
            Me.TextBox51.[ReadOnly] = True
            Me.TextBox51.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox51.TabIndex = 18
            Me.TextBox51.TabStop = False
            Me.TextBox51.Tag = "d26"
            Me.TextBox51.Text = ""
            Me.nudRejoinParty.Enabled = False
            Me.nudRejoinParty.Location = New Global.System.Drawing.Point(152, 688)
            Me.nudRejoinParty.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudRejoinParty.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudRejoinParty.Name = "nudRejoinParty"
            Me.nudRejoinParty.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudRejoinParty.TabIndex = 26
            Me.nudRejoinParty.Tag = "26"
            Me.nudRejoinParty.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudPoisoned.Enabled = False
            Me.nudPoisoned.Location = New Global.System.Drawing.Point(152, 712)
            Me.nudPoisoned.Maximum = New Decimal(New Integer() {300000, 0, 0, 0})
            Me.nudPoisoned.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudPoisoned.Name = "nudPoisoned"
            Me.nudPoisoned.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudPoisoned.TabIndex = 27
            Me.nudPoisoned.Tag = "27"
            Me.nudPoisoned.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox52.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TextBox52.Location = New Global.System.Drawing.Point(368, 712)
            Me.TextBox52.Name = "TextBox52"
            Me.TextBox52.[ReadOnly] = True
            Me.TextBox52.Size = New Global.System.Drawing.Size(272, 20)
            Me.TextBox52.TabIndex = 19
            Me.TextBox52.TabStop = False
            Me.TextBox52.Tag = "d27"
            Me.TextBox52.Text = ""
            Me.TextBox53.Location = New Global.System.Drawing.Point(224, 712)
            Me.TextBox53.Name = "TextBox53"
            Me.TextBox53.[ReadOnly] = True
            Me.TextBox53.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox53.TabIndex = 16
            Me.TextBox53.TabStop = False
            Me.TextBox53.Tag = "rr27"
            Me.TextBox53.Text = ""
            Me.TextBox53.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TextBox54.Location = New Global.System.Drawing.Point(224, 688)
            Me.TextBox54.Name = "TextBox54"
            Me.TextBox54.[ReadOnly] = True
            Me.TextBox54.Size = New Global.System.Drawing.Size(136, 20)
            Me.TextBox54.TabIndex = 17
            Me.TextBox54.TabStop = False
            Me.TextBox54.Tag = "rr26"
            Me.TextBox54.Text = ""
            Me.TextBox54.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.label111.Location = New Global.System.Drawing.Point(16, 688)
            Me.label111.Name = "label111"
            Me.label111.Size = New Global.System.Drawing.Size(80, 16)
            Me.label111.TabIndex = 20
            Me.label111.Text = "Rejoin Party"
            Me.Label28.Location = New Global.System.Drawing.Point(16, 664)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New Global.System.Drawing.Size(112, 16)
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
            Me.StatusBar1.Location = New Global.System.Drawing.Point(0, 363)
            Me.StatusBar1.Name = "StatusBar1"
            Me.StatusBar1.Size = New Global.System.Drawing.Size(688, 22)
            Me.StatusBar1.TabIndex = 7
            Me.StatusBar1.Text = "StatusBar1"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(688, 385)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.miSave.Click, AddressOf Me.miSave_Click
            AddHandler Me.miNew.Click, AddressOf Me.miNew_Click
            AddHandler Me.miOpen.Click, AddressOf Me.miOpen_Click
            AddHandler Me.miQuit.Click, AddressOf Me.miQuit_Click
            AddHandler Me.miSaveAs.Click, AddressOf Me.miSaveAs_Click
            AddHandler Me.miUseK1DialogTlk.Click, AddressOf Me.UseDialogTlk_Click
            AddHandler Me.miUseK2DialogTlk.Click, AddressOf Me.UseDialogTlk_Click
            AddHandler Me.miUseExtDialogTlk.Click, AddressOf Me.UseDialogTlk_Click
            AddHandler Me.miAskDialogTlk.Click, AddressOf Me.UseDialogTlk_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
