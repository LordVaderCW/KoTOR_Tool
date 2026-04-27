Namespace kotor_tool
	' Token: 0x02000082 RID: 130
	Public Partial Class frmUTS_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06001543 RID: 5443 RVA: 0x002BF118 File Offset: 0x002BE118
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06001622 RID: 5666 RVA: 0x002C0BB0 File Offset: 0x002BFBB0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUTS_Editor))
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.tabpagBasic = New Global.System.Windows.Forms.TabPage()
            Me.tbVolume = New Global.System.Windows.Forms.TextBox()
            Me.trkbarVolume = New Global.System.Windows.Forms.TrackBar()
            Me.btnAddSound = New Global.System.Windows.Forms.Button()
            Me.btnRemoveSound = New Global.System.Windows.Forms.Button()
            Me.btnMoveUp = New Global.System.Windows.Forms.Button()
            Me.btnMoveDown = New Global.System.Windows.Forms.Button()
            Me.lbSounds = New Global.System.Windows.Forms.ListBox()
            Me.tbComment = New Global.System.Windows.Forms.TextBox()
            Me.btnSetNameLang = New Global.System.Windows.Forms.Button()
            Me.tbTag = New Global.System.Windows.Forms.TextBox()
            Me.tbName = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.btnPlaySound = New Global.System.Windows.Forms.Button()
            Me.btnStopSound = New Global.System.Windows.Forms.Button()
            Me.tbSoundStatus = New Global.System.Windows.Forms.TextBox()
            Me.Label26 = New Global.System.Windows.Forms.Label()
            Me.tbapagPositioning = New Global.System.Windows.Forms.TabPage()
            Me.gbHeight = New Global.System.Windows.Forms.GroupBox()
            Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
            Me.nudElevation = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.gbVolumeDistances = New Global.System.Windows.Forms.GroupBox()
            Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.nudMaxDistance = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.nudMinDistance = New Global.System.Windows.Forms.NumericUpDown()
            Me.rbPlaysEverywhere = New Global.System.Windows.Forms.RadioButton()
            Me.rbRandomPosition = New Global.System.Windows.Forms.RadioButton()
            Me.rbSpecificPosition = New Global.System.Windows.Forms.RadioButton()
            Me.gbRandomRange = New Global.System.Windows.Forms.GroupBox()
            Me.PictureBox3 = New Global.System.Windows.Forms.PictureBox()
            Me.nudRandomRangeY = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudRandomRangeX = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.tabpagAdvanced = New Global.System.Windows.Forms.TabPage()
            Me.pnlVolPitch = New Global.System.Windows.Forms.Panel()
            Me.tbPitchVrtn = New Global.System.Windows.Forms.TextBox()
            Me.trkbarVolumeVrtn = New Global.System.Windows.Forms.TrackBar()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.trkbarPitchVrtn = New Global.System.Windows.Forms.TrackBar()
            Me.tbVolumeVrtn = New Global.System.Windows.Forms.TextBox()
            Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
            Me.rbPlayDay = New Global.System.Windows.Forms.RadioButton()
            Me.rbPlayNight = New Global.System.Windows.Forms.RadioButton()
            Me.rbPlayAllTimes = New Global.System.Windows.Forms.RadioButton()
            Me.rbPlaySpecificHours = New Global.System.Windows.Forms.RadioButton()
            Me.pnlHours = New Global.System.Windows.Forms.Panel()
            Me.chkb3a = New Global.System.Windows.Forms.CheckBox()
            Me.Label21 = New Global.System.Windows.Forms.Label()
            Me.Label20 = New Global.System.Windows.Forms.Label()
            Me.Label18 = New Global.System.Windows.Forms.Label()
            Me.chkb3p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb10p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb12p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb1p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb4a = New Global.System.Windows.Forms.CheckBox()
            Me.chkb6a = New Global.System.Windows.Forms.CheckBox()
            Me.chkb5a = New Global.System.Windows.Forms.CheckBox()
            Me.chkb7a = New Global.System.Windows.Forms.CheckBox()
            Me.Label25 = New Global.System.Windows.Forms.Label()
            Me.chkb8p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb2p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb9p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb11p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb11a = New Global.System.Windows.Forms.CheckBox()
            Me.chkb9a = New Global.System.Windows.Forms.CheckBox()
            Me.chkb10a = New Global.System.Windows.Forms.CheckBox()
            Me.chkb8a = New Global.System.Windows.Forms.CheckBox()
            Me.chkb7p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb5p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb6p = New Global.System.Windows.Forms.CheckBox()
            Me.chkb4p = New Global.System.Windows.Forms.CheckBox()
            Me.Label13 = New Global.System.Windows.Forms.Label()
            Me.chkb1a = New Global.System.Windows.Forms.CheckBox()
            Me.lblAM = New Global.System.Windows.Forms.Label()
            Me.lblPM = New Global.System.Windows.Forms.Label()
            Me.Label23 = New Global.System.Windows.Forms.Label()
            Me.Label24 = New Global.System.Windows.Forms.Label()
            Me.chkb2a = New Global.System.Windows.Forms.CheckBox()
            Me.lbl12 = New Global.System.Windows.Forms.Label()
            Me.Label17 = New Global.System.Windows.Forms.Label()
            Me.Label22 = New Global.System.Windows.Forms.Label()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.chkb12a = New Global.System.Windows.Forms.CheckBox()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.chkbActive = New Global.System.Windows.Forms.CheckBox()
            Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
            Me.rbSequential = New Global.System.Windows.Forms.RadioButton()
            Me.rbRandom = New Global.System.Windows.Forms.RadioButton()
            Me.gbInterval = New Global.System.Windows.Forms.GroupBox()
            Me.Label16 = New Global.System.Windows.Forms.Label()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.nudInterval = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudIntervalVrtn = New Global.System.Windows.Forms.NumericUpDown()
            Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
            Me.rbOnce = New Global.System.Windows.Forms.RadioButton()
            Me.rbRepeating = New Global.System.Windows.Forms.RadioButton()
            Me.rbLooping = New Global.System.Windows.Forms.RadioButton()
            Me.btnSave = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnDebug = New Global.System.Windows.Forms.Button()
            Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
            Me.TabControl1.SuspendLayout()
            Me.tabpagBasic.SuspendLayout()
            CType(Me.trkbarVolume, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tbapagPositioning.SuspendLayout()
            Me.gbHeight.SuspendLayout()
            CType(Me.nudElevation, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbVolumeDistances.SuspendLayout()
            CType(Me.nudMaxDistance, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMinDistance, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRandomRange.SuspendLayout()
            CType(Me.nudRandomRangeY, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRandomRangeX, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAdvanced.SuspendLayout()
            Me.pnlVolPitch.SuspendLayout()
            CType(Me.trkbarVolumeVrtn, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarPitchVrtn, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            Me.pnlHours.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.gbInterval.SuspendLayout()
            CType(Me.nudInterval, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudIntervalVrtn, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox5.SuspendLayout()
            Me.SuspendLayout()
            Me.TabControl1.Controls.Add(Me.tabpagBasic)
            Me.TabControl1.Controls.Add(Me.tbapagPositioning)
            Me.TabControl1.Controls.Add(Me.tabpagAdvanced)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(16, 8)
            tabControl.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(504, 504)
            tabControl2.Size = size
            Me.TabControl1.TabIndex = 0
            Me.tabpagBasic.Controls.Add(Me.tbVolume)
            Me.tabpagBasic.Controls.Add(Me.trkbarVolume)
            Me.tabpagBasic.Controls.Add(Me.btnAddSound)
            Me.tabpagBasic.Controls.Add(Me.btnRemoveSound)
            Me.tabpagBasic.Controls.Add(Me.btnMoveUp)
            Me.tabpagBasic.Controls.Add(Me.btnMoveDown)
            Me.tabpagBasic.Controls.Add(Me.lbSounds)
            Me.tabpagBasic.Controls.Add(Me.tbComment)
            Me.tabpagBasic.Controls.Add(Me.btnSetNameLang)
            Me.tabpagBasic.Controls.Add(Me.tbTag)
            Me.tabpagBasic.Controls.Add(Me.tbName)
            Me.tabpagBasic.Controls.Add(Me.Label1)
            Me.tabpagBasic.Controls.Add(Me.Label2)
            Me.tabpagBasic.Controls.Add(Me.Label3)
            Me.tabpagBasic.Controls.Add(Me.Label4)
            Me.tabpagBasic.Controls.Add(Me.Label5)
            Me.tabpagBasic.Controls.Add(Me.btnPlaySound)
            Me.tabpagBasic.Controls.Add(Me.btnStopSound)
            Me.tabpagBasic.Controls.Add(Me.tbSoundStatus)
            Me.tabpagBasic.Controls.Add(Me.Label26)
            Dim tabpagBasic As Global.System.Windows.Forms.Control = Me.tabpagBasic
            point = New Global.System.Drawing.Point(4, 22)
            tabpagBasic.Location = point
            Me.tabpagBasic.Name = "tabpagBasic"
            Dim tabpagBasic2 As Global.System.Windows.Forms.Control = Me.tabpagBasic
            size = New Global.System.Drawing.Size(496, 478)
            tabpagBasic2.Size = size
            Me.tabpagBasic.TabIndex = 0
            Me.tabpagBasic.Text = "Basic"
            Dim tbVolume As Global.System.Windows.Forms.Control = Me.tbVolume
            point = New Global.System.Drawing.Point(136, 424)
            tbVolume.Location = point
            Me.tbVolume.Name = "tbVolume"
            Me.tbVolume.[ReadOnly] = True
            Dim tbVolume2 As Global.System.Windows.Forms.Control = Me.tbVolume
            size = New Global.System.Drawing.Size(40, 20)
            tbVolume2.Size = size
            Me.tbVolume.TabIndex = 25
            Me.tbVolume.Text = ""
            Dim trkbarVolume As Global.System.Windows.Forms.Control = Me.trkbarVolume
            point = New Global.System.Drawing.Point(184, 424)
            trkbarVolume.Location = point
            Me.trkbarVolume.Maximum = 127
            Me.trkbarVolume.Name = "trkbarVolume"
            Dim trkbarVolume2 As Global.System.Windows.Forms.Control = Me.trkbarVolume
            size = New Global.System.Drawing.Size(216, 42)
            trkbarVolume2.Size = size
            Me.trkbarVolume.TabIndex = 21
            Me.trkbarVolume.TickFrequency = 5
            Me.btnAddSound.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnAddSound As Global.System.Windows.Forms.Control = Me.btnAddSound
            point = New Global.System.Drawing.Point(328, 160)
            btnAddSound.Location = point
            Me.btnAddSound.Name = "btnAddSound"
            Dim btnAddSound2 As Global.System.Windows.Forms.Control = Me.btnAddSound
            size = New Global.System.Drawing.Size(80, 23)
            btnAddSound2.Size = size
            Me.btnAddSound.TabIndex = 19
            Me.btnAddSound.Text = "Add Sound..."
            Me.btnRemoveSound.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnRemoveSound.Enabled = False
            Dim btnRemoveSound As Global.System.Windows.Forms.Control = Me.btnRemoveSound
            point = New Global.System.Drawing.Point(328, 192)
            btnRemoveSound.Location = point
            Me.btnRemoveSound.Name = "btnRemoveSound"
            Dim btnRemoveSound2 As Global.System.Windows.Forms.Control = Me.btnRemoveSound
            size = New Global.System.Drawing.Size(80, 23)
            btnRemoveSound2.Size = size
            Me.btnRemoveSound.TabIndex = 20
            Me.btnRemoveSound.Text = "Remove"
            Me.btnMoveUp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnMoveUp.Enabled = False
            Dim btnMoveUp As Global.System.Windows.Forms.Control = Me.btnMoveUp
            point = New Global.System.Drawing.Point(328, 320)
            btnMoveUp.Location = point
            Me.btnMoveUp.Name = "btnMoveUp"
            Dim btnMoveUp2 As Global.System.Windows.Forms.Control = Me.btnMoveUp
            size = New Global.System.Drawing.Size(80, 23)
            btnMoveUp2.Size = size
            Me.btnMoveUp.TabIndex = 17
            Me.btnMoveUp.Text = "Move Up"
            Me.btnMoveDown.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnMoveDown.Enabled = False
            Dim btnMoveDown As Global.System.Windows.Forms.Control = Me.btnMoveDown
            point = New Global.System.Drawing.Point(328, 352)
            btnMoveDown.Location = point
            Me.btnMoveDown.Name = "btnMoveDown"
            Dim btnMoveDown2 As Global.System.Windows.Forms.Control = Me.btnMoveDown
            size = New Global.System.Drawing.Size(80, 23)
            btnMoveDown2.Size = size
            Me.btnMoveDown.TabIndex = 18
            Me.btnMoveDown.Text = "Move Down"
            Dim lbSounds As Global.System.Windows.Forms.Control = Me.lbSounds
            point = New Global.System.Drawing.Point(136, 160)
            lbSounds.Location = point
            Me.lbSounds.Name = "lbSounds"
            Me.lbSounds.SelectionMode = Global.System.Windows.Forms.SelectionMode.MultiExtended
            Dim lbSounds2 As Global.System.Windows.Forms.Control = Me.lbSounds
            size = New Global.System.Drawing.Size(144, 212)
            lbSounds2.Size = size
            Me.lbSounds.TabIndex = 16
            Dim tbComment As Global.System.Windows.Forms.Control = Me.tbComment
            point = New Global.System.Drawing.Point(136, 80)
            tbComment.Location = point
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Dim tbComment2 As Global.System.Windows.Forms.Control = Me.tbComment
            size = New Global.System.Drawing.Size(272, 64)
            tbComment2.Size = size
            Me.tbComment.TabIndex = 15
            Me.tbComment.Text = ""
            Dim btnSetNameLang As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            point = New Global.System.Drawing.Point(344, 24)
            btnSetNameLang.Location = point
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Dim btnSetNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetNameLang2.Size = size
            Me.btnSetNameLang.TabIndex = 14
            Me.btnSetNameLang.Text = "Set Language"
            Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
            point = New Global.System.Drawing.Point(136, 48)
            tbTag.Location = point
            Me.tbTag.Name = "tbTag"
            Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
            size = New Global.System.Drawing.Size(200, 20)
            tbTag2.Size = size
            Me.tbTag.TabIndex = 13
            Me.tbTag.Text = ""
            Dim tbName As Global.System.Windows.Forms.Control = Me.tbName
            point = New Global.System.Drawing.Point(136, 24)
            tbName.Location = point
            Me.tbName.Name = "tbName"
            Dim tbName2 As Global.System.Windows.Forms.Control = Me.tbName
            size = New Global.System.Drawing.Size(200, 20)
            tbName2.Size = size
            Me.tbName.TabIndex = 12
            Me.tbName.Text = ""
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(40, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(100, 16)
            label2.Size = size
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Name"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(40, 48)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(100, 16)
            label4.Size = size
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(40, 88)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(80, 16)
            label6.Size = size
            Me.Label3.TabIndex = 11
            Me.Label3.Text = "Comments"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(40, 160)
            label7.Location = point
            Me.Label4.Name = "Label4"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(88, 24)
            label8.Size = size
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "Sounds to Play"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(40, 424)
            label9.Location = point
            Me.Label5.Name = "Label5"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(88, 16)
            label10.Size = size
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "In-game Volume"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPlaySound.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnPlaySound.Enabled = False
            Dim btnPlaySound As Global.System.Windows.Forms.Control = Me.btnPlaySound
            point = New Global.System.Drawing.Point(328, 240)
            btnPlaySound.Location = point
            Me.btnPlaySound.Name = "btnPlaySound"
            Dim btnPlaySound2 As Global.System.Windows.Forms.Control = Me.btnPlaySound
            size = New Global.System.Drawing.Size(80, 23)
            btnPlaySound2.Size = size
            Me.btnPlaySound.TabIndex = 19
            Me.btnPlaySound.Text = "Play Sound"
            Me.btnStopSound.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnStopSound.Enabled = False
            Dim btnStopSound As Global.System.Windows.Forms.Control = Me.btnStopSound
            point = New Global.System.Drawing.Point(328, 272)
            btnStopSound.Location = point
            Me.btnStopSound.Name = "btnStopSound"
            Dim btnStopSound2 As Global.System.Windows.Forms.Control = Me.btnStopSound
            size = New Global.System.Drawing.Size(80, 23)
            btnStopSound2.Size = size
            Me.btnStopSound.TabIndex = 19
            Me.btnStopSound.Text = "Stop"
            Me.tbSoundStatus.Font = New Global.System.Drawing.Font("Courier New", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim tbSoundStatus As Global.System.Windows.Forms.Control = Me.tbSoundStatus
            point = New Global.System.Drawing.Point(136, 384)
            tbSoundStatus.Location = point
            Me.tbSoundStatus.Name = "tbSoundStatus"
            Me.tbSoundStatus.[ReadOnly] = True
            Dim tbSoundStatus2 As Global.System.Windows.Forms.Control = Me.tbSoundStatus
            size = New Global.System.Drawing.Size(144, 20)
            tbSoundStatus2.Size = size
            Me.tbSoundStatus.TabIndex = 25
            Me.tbSoundStatus.Text = ""
            Me.tbSoundStatus.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label26
            point = New Global.System.Drawing.Point(40, 384)
            label11.Location = point
            Me.Label26.Name = "Label26"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label26
            size = New Global.System.Drawing.Size(80, 16)
            label12.Size = size
            Me.Label26.TabIndex = 11
            Me.Label26.Text = "Time"
            Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbapagPositioning.Controls.Add(Me.gbHeight)
            Me.tbapagPositioning.Controls.Add(Me.gbVolumeDistances)
            Me.tbapagPositioning.Controls.Add(Me.rbPlaysEverywhere)
            Me.tbapagPositioning.Controls.Add(Me.rbRandomPosition)
            Me.tbapagPositioning.Controls.Add(Me.rbSpecificPosition)
            Me.tbapagPositioning.Controls.Add(Me.gbRandomRange)
            Dim tbapagPositioning As Global.System.Windows.Forms.Control = Me.tbapagPositioning
            point = New Global.System.Drawing.Point(4, 22)
            tbapagPositioning.Location = point
            Me.tbapagPositioning.Name = "tbapagPositioning"
            Dim tbapagPositioning2 As Global.System.Windows.Forms.Control = Me.tbapagPositioning
            size = New Global.System.Drawing.Size(496, 478)
            tbapagPositioning2.Size = size
            Me.tbapagPositioning.TabIndex = 1
            Me.tbapagPositioning.Text = "Positioning"
            Me.gbHeight.Controls.Add(Me.PictureBox2)
            Me.gbHeight.Controls.Add(Me.nudElevation)
            Me.gbHeight.Controls.Add(Me.Label10)
            Dim gbHeight As Global.System.Windows.Forms.Control = Me.gbHeight
            point = New Global.System.Drawing.Point(16, 248)
            gbHeight.Location = point
            Me.gbHeight.Name = "gbHeight"
            Dim gbHeight2 As Global.System.Windows.Forms.Control = Me.gbHeight
            size = New Global.System.Drawing.Size(184, 176)
            gbHeight2.Size = size
            Me.gbHeight.TabIndex = 2
            Me.gbHeight.TabStop = False
            Me.gbHeight.Text = "Height (m)"
            Me.PictureBox2.Image = CType(resourceManager.GetObject("PictureBox2.Image"), Global.System.Drawing.Image)
            Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox2
            point = New Global.System.Drawing.Point(8, 40)
            pictureBox.Location = point
            Me.PictureBox2.Name = "PictureBox2"
            Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox2
            size = New Global.System.Drawing.Size(94, 96)
            pictureBox2.Size = size
            Me.PictureBox2.TabIndex = 3
            Me.PictureBox2.TabStop = False
            Me.nudElevation.DecimalPlaces = 1
            Dim nudElevation As Global.System.Windows.Forms.Control = Me.nudElevation
            point = New Global.System.Drawing.Point(112, 72)
            nudElevation.Location = point
            Dim nudElevation2 As Global.System.Windows.Forms.NumericUpDown = Me.nudElevation
            Dim num As Decimal = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
            nudElevation2.Minimum = num
            Me.nudElevation.Name = "nudElevation"
            Dim nudElevation3 As Global.System.Windows.Forms.Control = Me.nudElevation
            size = New Global.System.Drawing.Size(64, 20)
            nudElevation3.Size = size
            Me.nudElevation.TabIndex = 0
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(112, 56)
            label13.Location = point
            Me.Label10.Name = "Label10"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(64, 16)
            label14.Size = size
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Height (m)"
            Me.gbVolumeDistances.Controls.Add(Me.PictureBox1)
            Me.gbVolumeDistances.Controls.Add(Me.Label8)
            Me.gbVolumeDistances.Controls.Add(Me.nudMaxDistance)
            Me.gbVolumeDistances.Controls.Add(Me.Label9)
            Me.gbVolumeDistances.Controls.Add(Me.nudMinDistance)
            Dim gbVolumeDistances As Global.System.Windows.Forms.Control = Me.gbVolumeDistances
            point = New Global.System.Drawing.Point(16, 104)
            gbVolumeDistances.Location = point
            Me.gbVolumeDistances.Name = "gbVolumeDistances"
            Dim gbVolumeDistances2 As Global.System.Windows.Forms.Control = Me.gbVolumeDistances
            size = New Global.System.Drawing.Size(408, 120)
            gbVolumeDistances2.Size = size
            Me.gbVolumeDistances.TabIndex = 1
            Me.gbVolumeDistances.TabStop = False
            Me.gbVolumeDistances.Text = "Volume Distances"
            Me.PictureBox1.Image = CType(resourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
            Dim pictureBox3 As Global.System.Windows.Forms.Control = Me.PictureBox1
            point = New Global.System.Drawing.Point(8, 24)
            pictureBox3.Location = point
            Me.PictureBox1.Name = "PictureBox1"
            Dim pictureBox4 As Global.System.Windows.Forms.Control = Me.PictureBox1
            size = New Global.System.Drawing.Size(90, 82)
            pictureBox4.Size = size
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(128, 16)
            label15.Location = point
            Me.Label8.Name = "Label8"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(100, 16)
            label16.Size = size
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Cutoff distance (m)"
            Me.nudMaxDistance.DecimalPlaces = 1
            Dim nudMaxDistance As Global.System.Windows.Forms.Control = Me.nudMaxDistance
            point = New Global.System.Drawing.Point(128, 32)
            nudMaxDistance.Location = point
            Me.nudMaxDistance.Name = "nudMaxDistance"
            Dim nudMaxDistance2 As Global.System.Windows.Forms.Control = Me.nudMaxDistance
            size = New Global.System.Drawing.Size(64, 20)
            nudMaxDistance2.Size = size
            Me.nudMaxDistance.TabIndex = 0
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(128, 64)
            label17.Location = point
            Me.Label9.Name = "Label9"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(152, 16)
            label18.Size = size
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Max Volume distance (m)"
            Me.nudMinDistance.DecimalPlaces = 1
            Dim nudMinDistance As Global.System.Windows.Forms.Control = Me.nudMinDistance
            point = New Global.System.Drawing.Point(128, 80)
            nudMinDistance.Location = point
            Me.nudMinDistance.Name = "nudMinDistance"
            Dim nudMinDistance2 As Global.System.Windows.Forms.Control = Me.nudMinDistance
            size = New Global.System.Drawing.Size(64, 20)
            nudMinDistance2.Size = size
            Me.nudMinDistance.TabIndex = 0
            Dim rbPlaysEverywhere As Global.System.Windows.Forms.Control = Me.rbPlaysEverywhere
            point = New Global.System.Drawing.Point(24, 16)
            rbPlaysEverywhere.Location = point
            Me.rbPlaysEverywhere.Name = "rbPlaysEverywhere"
            Dim rbPlaysEverywhere2 As Global.System.Windows.Forms.Control = Me.rbPlaysEverywhere
            size = New Global.System.Drawing.Size(160, 24)
            rbPlaysEverywhere2.Size = size
            Me.rbPlaysEverywhere.TabIndex = 0
            Me.rbPlaysEverywhere.Text = "Plays everywhere in area"
            Dim rbRandomPosition As Global.System.Windows.Forms.Control = Me.rbRandomPosition
            point = New Global.System.Drawing.Point(24, 40)
            rbRandomPosition.Location = point
            Me.rbRandomPosition.Name = "rbRandomPosition"
            Dim rbRandomPosition2 As Global.System.Windows.Forms.Control = Me.rbRandomPosition
            size = New Global.System.Drawing.Size(288, 24)
            rbRandomPosition2.Size = size
            Me.rbRandomPosition.TabIndex = 0
            Me.rbRandomPosition.Text = "Plays from a random position each time it is played"
            Me.rbSpecificPosition.Checked = True
            Dim rbSpecificPosition As Global.System.Windows.Forms.Control = Me.rbSpecificPosition
            point = New Global.System.Drawing.Point(24, 64)
            rbSpecificPosition.Location = point
            Me.rbSpecificPosition.Name = "rbSpecificPosition"
            Dim rbSpecificPosition2 As Global.System.Windows.Forms.Control = Me.rbSpecificPosition
            size = New Global.System.Drawing.Size(168, 24)
            rbSpecificPosition2.Size = size
            Me.rbSpecificPosition.TabIndex = 0
            Me.rbSpecificPosition.TabStop = True
            Me.rbSpecificPosition.Text = "Plays from a specific position"
            Me.gbRandomRange.Controls.Add(Me.PictureBox3)
            Me.gbRandomRange.Controls.Add(Me.nudRandomRangeY)
            Me.gbRandomRange.Controls.Add(Me.nudRandomRangeX)
            Me.gbRandomRange.Controls.Add(Me.Label11)
            Me.gbRandomRange.Controls.Add(Me.Label12)
            Dim gbRandomRange As Global.System.Windows.Forms.Control = Me.gbRandomRange
            point = New Global.System.Drawing.Point(208, 248)
            gbRandomRange.Location = point
            Me.gbRandomRange.Name = "gbRandomRange"
            Dim gbRandomRange2 As Global.System.Windows.Forms.Control = Me.gbRandomRange
            size = New Global.System.Drawing.Size(280, 176)
            gbRandomRange2.Size = size
            Me.gbRandomRange.TabIndex = 2
            Me.gbRandomRange.TabStop = False
            Me.gbRandomRange.Text = "Random Range"
            Me.PictureBox3.Image = CType(resourceManager.GetObject("PictureBox3.Image"), Global.System.Drawing.Image)
            Dim pictureBox5 As Global.System.Windows.Forms.Control = Me.PictureBox3
            point = New Global.System.Drawing.Point(8, 24)
            pictureBox5.Location = point
            Me.PictureBox3.Name = "PictureBox3"
            Dim pictureBox6 As Global.System.Windows.Forms.Control = Me.PictureBox3
            size = New Global.System.Drawing.Size(96, 95)
            pictureBox6.Size = size
            Me.PictureBox3.TabIndex = 3
            Me.PictureBox3.TabStop = False
            Me.nudRandomRangeY.DecimalPlaces = 1
            Dim nudRandomRangeY As Global.System.Windows.Forms.Control = Me.nudRandomRangeY
            point = New Global.System.Drawing.Point(112, 40)
            nudRandomRangeY.Location = point
            Me.nudRandomRangeY.Name = "nudRandomRangeY"
            Dim nudRandomRangeY2 As Global.System.Windows.Forms.Control = Me.nudRandomRangeY
            size = New Global.System.Drawing.Size(64, 20)
            nudRandomRangeY2.Size = size
            Me.nudRandomRangeY.TabIndex = 0
            Me.nudRandomRangeX.DecimalPlaces = 1
            Dim nudRandomRangeX As Global.System.Windows.Forms.Control = Me.nudRandomRangeX
            point = New Global.System.Drawing.Point(16, 144)
            nudRandomRangeX.Location = point
            Me.nudRandomRangeX.Name = "nudRandomRangeX"
            Dim nudRandomRangeX2 As Global.System.Windows.Forms.Control = Me.nudRandomRangeX
            size = New Global.System.Drawing.Size(64, 20)
            nudRandomRangeX2.Size = size
            Me.nudRandomRangeX.TabIndex = 0
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(112, 24)
            label19.Location = point
            Me.Label11.Name = "Label11"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(160, 16)
            label20.Size = size
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "North-South Random Range (m)"
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(16, 128)
            label21.Location = point
            Me.Label12.Name = "Label12"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(160, 16)
            label22.Size = size
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "West-East Random Range (m)"
            Me.tabpagAdvanced.Controls.Add(Me.pnlVolPitch)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox4)
            Me.tabpagAdvanced.Controls.Add(Me.chkbActive)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox6)
            Me.tabpagAdvanced.Controls.Add(Me.gbInterval)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox5)
            Dim tabpagAdvanced As Global.System.Windows.Forms.Control = Me.tabpagAdvanced
            point = New Global.System.Drawing.Point(4, 22)
            tabpagAdvanced.Location = point
            Me.tabpagAdvanced.Name = "tabpagAdvanced"
            Dim tabpagAdvanced2 As Global.System.Windows.Forms.Control = Me.tabpagAdvanced
            size = New Global.System.Drawing.Size(496, 478)
            tabpagAdvanced2.Size = size
            Me.tabpagAdvanced.TabIndex = 2
            Me.tabpagAdvanced.Text = "Advanced"
            Me.pnlVolPitch.Controls.Add(Me.tbPitchVrtn)
            Me.pnlVolPitch.Controls.Add(Me.trkbarVolumeVrtn)
            Me.pnlVolPitch.Controls.Add(Me.Label6)
            Me.pnlVolPitch.Controls.Add(Me.Label7)
            Me.pnlVolPitch.Controls.Add(Me.trkbarPitchVrtn)
            Me.pnlVolPitch.Controls.Add(Me.tbVolumeVrtn)
            Dim pnlVolPitch As Global.System.Windows.Forms.Control = Me.pnlVolPitch
            point = New Global.System.Drawing.Point(8, 368)
            pnlVolPitch.Location = point
            Me.pnlVolPitch.Name = "pnlVolPitch"
            Dim pnlVolPitch2 As Global.System.Windows.Forms.Control = Me.pnlVolPitch
            size = New Global.System.Drawing.Size(480, 104)
            pnlVolPitch2.Size = size
            Me.pnlVolPitch.TabIndex = 25
            Dim tbPitchVrtn As Global.System.Windows.Forms.Control = Me.tbPitchVrtn
            point = New Global.System.Drawing.Point(160, 64)
            tbPitchVrtn.Location = point
            Me.tbPitchVrtn.Name = "tbPitchVrtn"
            Me.tbPitchVrtn.[ReadOnly] = True
            Dim tbPitchVrtn2 As Global.System.Windows.Forms.Control = Me.tbPitchVrtn
            size = New Global.System.Drawing.Size(40, 20)
            tbPitchVrtn2.Size = size
            Me.tbPitchVrtn.TabIndex = 24
            Me.tbPitchVrtn.Text = ""
            Dim trkbarVolumeVrtn As Global.System.Windows.Forms.Control = Me.trkbarVolumeVrtn
            point = New Global.System.Drawing.Point(216, 8)
            trkbarVolumeVrtn.Location = point
            Me.trkbarVolumeVrtn.Maximum = 100
            Me.trkbarVolumeVrtn.Name = "trkbarVolumeVrtn"
            Dim trkbarVolumeVrtn2 As Global.System.Windows.Forms.Control = Me.trkbarVolumeVrtn
            size = New Global.System.Drawing.Size(216, 42)
            trkbarVolumeVrtn2.Size = size
            Me.trkbarVolumeVrtn.TabIndex = 23
            Me.trkbarVolumeVrtn.TickFrequency = 5
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(24, 16)
            label23.Location = point
            Me.Label6.Name = "Label6"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(96, 16)
            label24.Size = size
            Me.Label6.TabIndex = 22
            Me.Label6.Text = "Volume Variation"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label25 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(24, 64)
            label25.Location = point
            Me.Label7.Name = "Label7"
            Dim label26 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(160, 24)
            label26.Size = size
            Me.Label7.TabIndex = 22
            Me.Label7.Text = "Pitch  Variation (octaves)"
            Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim trkbarPitchVrtn As Global.System.Windows.Forms.Control = Me.trkbarPitchVrtn
            point = New Global.System.Drawing.Point(216, 56)
            trkbarPitchVrtn.Location = point
            Me.trkbarPitchVrtn.Maximum = 100
            Me.trkbarPitchVrtn.Name = "trkbarPitchVrtn"
            Dim trkbarPitchVrtn2 As Global.System.Windows.Forms.Control = Me.trkbarPitchVrtn
            size = New Global.System.Drawing.Size(216, 42)
            trkbarPitchVrtn2.Size = size
            Me.trkbarPitchVrtn.TabIndex = 23
            Me.trkbarPitchVrtn.TickFrequency = 5
            Dim tbVolumeVrtn As Global.System.Windows.Forms.Control = Me.tbVolumeVrtn
            point = New Global.System.Drawing.Point(160, 16)
            tbVolumeVrtn.Location = point
            Me.tbVolumeVrtn.Name = "tbVolumeVrtn"
            Me.tbVolumeVrtn.[ReadOnly] = True
            Dim tbVolumeVrtn2 As Global.System.Windows.Forms.Control = Me.tbVolumeVrtn
            size = New Global.System.Drawing.Size(40, 20)
            tbVolumeVrtn2.Size = size
            Me.tbVolumeVrtn.TabIndex = 24
            Me.tbVolumeVrtn.Text = ""
            Me.GroupBox4.Controls.Add(Me.rbPlayDay)
            Me.GroupBox4.Controls.Add(Me.rbPlayNight)
            Me.GroupBox4.Controls.Add(Me.rbPlayAllTimes)
            Me.GroupBox4.Controls.Add(Me.rbPlaySpecificHours)
            Me.GroupBox4.Controls.Add(Me.pnlHours)
            Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox4
            point = New Global.System.Drawing.Point(8, 48)
            groupBox.Location = point
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox4
            size = New Global.System.Drawing.Size(472, 160)
            groupBox2.Size = size
            Me.GroupBox4.TabIndex = 1
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "When to play"
            Dim rbPlayDay As Global.System.Windows.Forms.Control = Me.rbPlayDay
            point = New Global.System.Drawing.Point(40, 16)
            rbPlayDay.Location = point
            Me.rbPlayDay.Name = "rbPlayDay"
            Dim rbPlayDay2 As Global.System.Windows.Forms.Control = Me.rbPlayDay
            size = New Global.System.Drawing.Size(128, 16)
            rbPlayDay2.Size = size
            Me.rbPlayDay.TabIndex = 0
            Me.rbPlayDay.Text = "Play during the day"
            Dim rbPlayNight As Global.System.Windows.Forms.Control = Me.rbPlayNight
            point = New Global.System.Drawing.Point(40, 32)
            rbPlayNight.Location = point
            Me.rbPlayNight.Name = "rbPlayNight"
            Dim rbPlayNight2 As Global.System.Windows.Forms.Control = Me.rbPlayNight
            size = New Global.System.Drawing.Size(128, 16)
            rbPlayNight2.Size = size
            Me.rbPlayNight.TabIndex = 0
            Me.rbPlayNight.Text = "Play at night"
            Me.rbPlayAllTimes.Checked = True
            Dim rbPlayAllTimes As Global.System.Windows.Forms.Control = Me.rbPlayAllTimes
            point = New Global.System.Drawing.Point(40, 48)
            rbPlayAllTimes.Location = point
            Me.rbPlayAllTimes.Name = "rbPlayAllTimes"
            Dim rbPlayAllTimes2 As Global.System.Windows.Forms.Control = Me.rbPlayAllTimes
            size = New Global.System.Drawing.Size(128, 16)
            rbPlayAllTimes2.Size = size
            Me.rbPlayAllTimes.TabIndex = 0
            Me.rbPlayAllTimes.TabStop = True
            Me.rbPlayAllTimes.Text = "Play at all times"
            Dim rbPlaySpecificHours As Global.System.Windows.Forms.Control = Me.rbPlaySpecificHours
            point = New Global.System.Drawing.Point(40, 64)
            rbPlaySpecificHours.Location = point
            Me.rbPlaySpecificHours.Name = "rbPlaySpecificHours"
            Dim rbPlaySpecificHours2 As Global.System.Windows.Forms.Control = Me.rbPlaySpecificHours
            size = New Global.System.Drawing.Size(128, 16)
            rbPlaySpecificHours2.Size = size
            Me.rbPlaySpecificHours.TabIndex = 0
            Me.rbPlaySpecificHours.Text = "Specific Hours"
            Me.pnlHours.Controls.Add(Me.chkb3a)
            Me.pnlHours.Controls.Add(Me.Label21)
            Me.pnlHours.Controls.Add(Me.Label20)
            Me.pnlHours.Controls.Add(Me.Label18)
            Me.pnlHours.Controls.Add(Me.chkb3p)
            Me.pnlHours.Controls.Add(Me.chkb10p)
            Me.pnlHours.Controls.Add(Me.chkb12p)
            Me.pnlHours.Controls.Add(Me.chkb1p)
            Me.pnlHours.Controls.Add(Me.chkb4a)
            Me.pnlHours.Controls.Add(Me.chkb6a)
            Me.pnlHours.Controls.Add(Me.chkb5a)
            Me.pnlHours.Controls.Add(Me.chkb7a)
            Me.pnlHours.Controls.Add(Me.Label25)
            Me.pnlHours.Controls.Add(Me.chkb8p)
            Me.pnlHours.Controls.Add(Me.chkb2p)
            Me.pnlHours.Controls.Add(Me.chkb9p)
            Me.pnlHours.Controls.Add(Me.chkb11p)
            Me.pnlHours.Controls.Add(Me.chkb11a)
            Me.pnlHours.Controls.Add(Me.chkb9a)
            Me.pnlHours.Controls.Add(Me.chkb10a)
            Me.pnlHours.Controls.Add(Me.chkb8a)
            Me.pnlHours.Controls.Add(Me.chkb7p)
            Me.pnlHours.Controls.Add(Me.chkb5p)
            Me.pnlHours.Controls.Add(Me.chkb6p)
            Me.pnlHours.Controls.Add(Me.chkb4p)
            Me.pnlHours.Controls.Add(Me.Label13)
            Me.pnlHours.Controls.Add(Me.chkb1a)
            Me.pnlHours.Controls.Add(Me.lblAM)
            Me.pnlHours.Controls.Add(Me.lblPM)
            Me.pnlHours.Controls.Add(Me.Label23)
            Me.pnlHours.Controls.Add(Me.Label24)
            Me.pnlHours.Controls.Add(Me.chkb2a)
            Me.pnlHours.Controls.Add(Me.lbl12)
            Me.pnlHours.Controls.Add(Me.Label17)
            Me.pnlHours.Controls.Add(Me.Label22)
            Me.pnlHours.Controls.Add(Me.Label14)
            Me.pnlHours.Controls.Add(Me.chkb12a)
            Me.pnlHours.Controls.Add(Me.Label19)
            Dim pnlHours As Global.System.Windows.Forms.Control = Me.pnlHours
            point = New Global.System.Drawing.Point(40, 80)
            pnlHours.Location = point
            Me.pnlHours.Name = "pnlHours"
            Dim pnlHours2 As Global.System.Windows.Forms.Control = Me.pnlHours
            size = New Global.System.Drawing.Size(352, 72)
            pnlHours2.Size = size
            Me.pnlHours.TabIndex = 4
            Dim chkb3a As Global.System.Windows.Forms.Control = Me.chkb3a
            point = New Global.System.Drawing.Point(128, 24)
            chkb3a.Location = point
            Me.chkb3a.Name = "chkb3a"
            Dim chkb3a2 As Global.System.Windows.Forms.Control = Me.chkb3a
            size = New Global.System.Drawing.Size(16, 16)
            chkb3a2.Size = size
            Me.chkb3a.TabIndex = 1
            Me.chkb3a.Tag = "3"
            Me.chkb3a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim label27 As Global.System.Windows.Forms.Control = Me.Label21
            point = New Global.System.Drawing.Point(224, 8)
            label27.Location = point
            Me.Label21.Name = "Label21"
            Dim label28 As Global.System.Windows.Forms.Control = Me.Label21
            size = New Global.System.Drawing.Size(16, 16)
            label28.Size = size
            Me.Label21.TabIndex = 3
            Me.Label21.Text = "7"
            Dim label29 As Global.System.Windows.Forms.Control = Me.Label20
            point = New Global.System.Drawing.Point(200, 8)
            label29.Location = point
            Me.Label20.Name = "Label20"
            Dim label30 As Global.System.Windows.Forms.Control = Me.Label20
            size = New Global.System.Drawing.Size(16, 16)
            label30.Size = size
            Me.Label20.TabIndex = 3
            Me.Label20.Text = "6"
            Dim label31 As Global.System.Windows.Forms.Control = Me.Label18
            point = New Global.System.Drawing.Point(152, 8)
            label31.Location = point
            Me.Label18.Name = "Label18"
            Dim label32 As Global.System.Windows.Forms.Control = Me.Label18
            size = New Global.System.Drawing.Size(16, 16)
            label32.Size = size
            Me.Label18.TabIndex = 3
            Me.Label18.Text = "4"
            Dim chkb3p As Global.System.Windows.Forms.Control = Me.chkb3p
            point = New Global.System.Drawing.Point(128, 48)
            chkb3p.Location = point
            Me.chkb3p.Name = "chkb3p"
            Dim chkb3p2 As Global.System.Windows.Forms.Control = Me.chkb3p
            size = New Global.System.Drawing.Size(16, 16)
            chkb3p2.Size = size
            Me.chkb3p.TabIndex = 1
            Me.chkb3p.Tag = "15"
            Me.chkb3p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb10p As Global.System.Windows.Forms.Control = Me.chkb10p
            point = New Global.System.Drawing.Point(296, 48)
            chkb10p.Location = point
            Me.chkb10p.Name = "chkb10p"
            Dim chkb10p2 As Global.System.Windows.Forms.Control = Me.chkb10p
            size = New Global.System.Drawing.Size(16, 16)
            chkb10p2.Size = size
            Me.chkb10p.TabIndex = 1
            Me.chkb10p.Tag = "22"
            Me.chkb10p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb12p As Global.System.Windows.Forms.Control = Me.chkb12p
            point = New Global.System.Drawing.Point(56, 48)
            chkb12p.Location = point
            Me.chkb12p.Name = "chkb12p"
            Dim chkb12p2 As Global.System.Windows.Forms.Control = Me.chkb12p
            size = New Global.System.Drawing.Size(16, 16)
            chkb12p2.Size = size
            Me.chkb12p.TabIndex = 1
            Me.chkb12p.Tag = "12"
            Me.chkb12p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb1p As Global.System.Windows.Forms.Control = Me.chkb1p
            point = New Global.System.Drawing.Point(80, 48)
            chkb1p.Location = point
            Me.chkb1p.Name = "chkb1p"
            Dim chkb1p2 As Global.System.Windows.Forms.Control = Me.chkb1p
            size = New Global.System.Drawing.Size(16, 16)
            chkb1p2.Size = size
            Me.chkb1p.TabIndex = 1
            Me.chkb1p.Tag = "13"
            Me.chkb1p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb4a As Global.System.Windows.Forms.Control = Me.chkb4a
            point = New Global.System.Drawing.Point(152, 24)
            chkb4a.Location = point
            Me.chkb4a.Name = "chkb4a"
            Dim chkb4a2 As Global.System.Windows.Forms.Control = Me.chkb4a
            size = New Global.System.Drawing.Size(16, 16)
            chkb4a2.Size = size
            Me.chkb4a.TabIndex = 1
            Me.chkb4a.Tag = "4"
            Me.chkb4a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb6a As Global.System.Windows.Forms.Control = Me.chkb6a
            point = New Global.System.Drawing.Point(200, 24)
            chkb6a.Location = point
            Me.chkb6a.Name = "chkb6a"
            Dim chkb6a2 As Global.System.Windows.Forms.Control = Me.chkb6a
            size = New Global.System.Drawing.Size(16, 16)
            chkb6a2.Size = size
            Me.chkb6a.TabIndex = 1
            Me.chkb6a.Tag = "6"
            Me.chkb6a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb5a As Global.System.Windows.Forms.Control = Me.chkb5a
            point = New Global.System.Drawing.Point(176, 24)
            chkb5a.Location = point
            Me.chkb5a.Name = "chkb5a"
            Dim chkb5a2 As Global.System.Windows.Forms.Control = Me.chkb5a
            size = New Global.System.Drawing.Size(16, 16)
            chkb5a2.Size = size
            Me.chkb5a.TabIndex = 1
            Me.chkb5a.Tag = "5"
            Me.chkb5a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb7a As Global.System.Windows.Forms.Control = Me.chkb7a
            point = New Global.System.Drawing.Point(224, 24)
            chkb7a.Location = point
            Me.chkb7a.Name = "chkb7a"
            Dim chkb7a2 As Global.System.Windows.Forms.Control = Me.chkb7a
            size = New Global.System.Drawing.Size(16, 16)
            chkb7a2.Size = size
            Me.chkb7a.TabIndex = 1
            Me.chkb7a.Tag = "7"
            Me.chkb7a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim label33 As Global.System.Windows.Forms.Control = Me.Label25
            point = New Global.System.Drawing.Point(318, 8)
            label33.Location = point
            Me.Label25.Name = "Label25"
            Dim label34 As Global.System.Windows.Forms.Control = Me.Label25
            size = New Global.System.Drawing.Size(24, 16)
            label34.Size = size
            Me.Label25.TabIndex = 3
            Me.Label25.Text = "11"
            Dim chkb8p As Global.System.Windows.Forms.Control = Me.chkb8p
            point = New Global.System.Drawing.Point(248, 48)
            chkb8p.Location = point
            Me.chkb8p.Name = "chkb8p"
            Dim chkb8p2 As Global.System.Windows.Forms.Control = Me.chkb8p
            size = New Global.System.Drawing.Size(16, 16)
            chkb8p2.Size = size
            Me.chkb8p.TabIndex = 1
            Me.chkb8p.Tag = "20"
            Me.chkb8p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb2p As Global.System.Windows.Forms.Control = Me.chkb2p
            point = New Global.System.Drawing.Point(104, 48)
            chkb2p.Location = point
            Me.chkb2p.Name = "chkb2p"
            Dim chkb2p2 As Global.System.Windows.Forms.Control = Me.chkb2p
            size = New Global.System.Drawing.Size(16, 16)
            chkb2p2.Size = size
            Me.chkb2p.TabIndex = 1
            Me.chkb2p.Tag = "14"
            Me.chkb2p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb9p As Global.System.Windows.Forms.Control = Me.chkb9p
            point = New Global.System.Drawing.Point(272, 48)
            chkb9p.Location = point
            Me.chkb9p.Name = "chkb9p"
            Dim chkb9p2 As Global.System.Windows.Forms.Control = Me.chkb9p
            size = New Global.System.Drawing.Size(16, 16)
            chkb9p2.Size = size
            Me.chkb9p.TabIndex = 1
            Me.chkb9p.Tag = "21"
            Me.chkb9p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb11p As Global.System.Windows.Forms.Control = Me.chkb11p
            point = New Global.System.Drawing.Point(320, 48)
            chkb11p.Location = point
            Me.chkb11p.Name = "chkb11p"
            Dim chkb11p2 As Global.System.Windows.Forms.Control = Me.chkb11p
            size = New Global.System.Drawing.Size(16, 16)
            chkb11p2.Size = size
            Me.chkb11p.TabIndex = 1
            Me.chkb11p.Tag = "23"
            Me.chkb11p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb11a As Global.System.Windows.Forms.Control = Me.chkb11a
            point = New Global.System.Drawing.Point(320, 24)
            chkb11a.Location = point
            Me.chkb11a.Name = "chkb11a"
            Dim chkb11a2 As Global.System.Windows.Forms.Control = Me.chkb11a
            size = New Global.System.Drawing.Size(16, 16)
            chkb11a2.Size = size
            Me.chkb11a.TabIndex = 1
            Me.chkb11a.Tag = "11"
            Me.chkb11a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb9a As Global.System.Windows.Forms.Control = Me.chkb9a
            point = New Global.System.Drawing.Point(272, 24)
            chkb9a.Location = point
            Me.chkb9a.Name = "chkb9a"
            Dim chkb9a2 As Global.System.Windows.Forms.Control = Me.chkb9a
            size = New Global.System.Drawing.Size(16, 16)
            chkb9a2.Size = size
            Me.chkb9a.TabIndex = 1
            Me.chkb9a.Tag = "9"
            Me.chkb9a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb10a As Global.System.Windows.Forms.Control = Me.chkb10a
            point = New Global.System.Drawing.Point(296, 24)
            chkb10a.Location = point
            Me.chkb10a.Name = "chkb10a"
            Dim chkb10a2 As Global.System.Windows.Forms.Control = Me.chkb10a
            size = New Global.System.Drawing.Size(16, 16)
            chkb10a2.Size = size
            Me.chkb10a.TabIndex = 1
            Me.chkb10a.Tag = "10"
            Me.chkb10a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb8a As Global.System.Windows.Forms.Control = Me.chkb8a
            point = New Global.System.Drawing.Point(248, 24)
            chkb8a.Location = point
            Me.chkb8a.Name = "chkb8a"
            Dim chkb8a2 As Global.System.Windows.Forms.Control = Me.chkb8a
            size = New Global.System.Drawing.Size(16, 16)
            chkb8a2.Size = size
            Me.chkb8a.TabIndex = 1
            Me.chkb8a.Tag = "8"
            Me.chkb8a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb7p As Global.System.Windows.Forms.Control = Me.chkb7p
            point = New Global.System.Drawing.Point(224, 48)
            chkb7p.Location = point
            Me.chkb7p.Name = "chkb7p"
            Dim chkb7p2 As Global.System.Windows.Forms.Control = Me.chkb7p
            size = New Global.System.Drawing.Size(16, 16)
            chkb7p2.Size = size
            Me.chkb7p.TabIndex = 1
            Me.chkb7p.Tag = "19"
            Me.chkb7p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb5p As Global.System.Windows.Forms.Control = Me.chkb5p
            point = New Global.System.Drawing.Point(176, 48)
            chkb5p.Location = point
            Me.chkb5p.Name = "chkb5p"
            Dim chkb5p2 As Global.System.Windows.Forms.Control = Me.chkb5p
            size = New Global.System.Drawing.Size(16, 16)
            chkb5p2.Size = size
            Me.chkb5p.TabIndex = 1
            Me.chkb5p.Tag = "17"
            Me.chkb5p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb6p As Global.System.Windows.Forms.Control = Me.chkb6p
            point = New Global.System.Drawing.Point(200, 48)
            chkb6p.Location = point
            Me.chkb6p.Name = "chkb6p"
            Dim chkb6p2 As Global.System.Windows.Forms.Control = Me.chkb6p
            size = New Global.System.Drawing.Size(16, 16)
            chkb6p2.Size = size
            Me.chkb6p.TabIndex = 1
            Me.chkb6p.Tag = "18"
            Me.chkb6p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim chkb4p As Global.System.Windows.Forms.Control = Me.chkb4p
            point = New Global.System.Drawing.Point(152, 48)
            chkb4p.Location = point
            Me.chkb4p.Name = "chkb4p"
            Dim chkb4p2 As Global.System.Windows.Forms.Control = Me.chkb4p
            size = New Global.System.Drawing.Size(16, 16)
            chkb4p2.Size = size
            Me.chkb4p.TabIndex = 1
            Me.chkb4p.Tag = "16"
            Me.chkb4p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim label35 As Global.System.Windows.Forms.Control = Me.Label13
            point = New Global.System.Drawing.Point(80, 8)
            label35.Location = point
            Me.Label13.Name = "Label13"
            Dim label36 As Global.System.Windows.Forms.Control = Me.Label13
            size = New Global.System.Drawing.Size(16, 16)
            label36.Size = size
            Me.Label13.TabIndex = 3
            Me.Label13.Text = "1"
            Dim chkb1a As Global.System.Windows.Forms.Control = Me.chkb1a
            point = New Global.System.Drawing.Point(80, 24)
            chkb1a.Location = point
            Me.chkb1a.Name = "chkb1a"
            Dim chkb1a2 As Global.System.Windows.Forms.Control = Me.chkb1a
            size = New Global.System.Drawing.Size(16, 16)
            chkb1a2.Size = size
            Me.chkb1a.TabIndex = 1
            Me.chkb1a.Tag = "1"
            Me.chkb1a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim lblAM As Global.System.Windows.Forms.Control = Me.lblAM
            point = New Global.System.Drawing.Point(16, 24)
            lblAM.Location = point
            Me.lblAM.Name = "lblAM"
            Dim lblAM2 As Global.System.Windows.Forms.Control = Me.lblAM
            size = New Global.System.Drawing.Size(24, 16)
            lblAM2.Size = size
            Me.lblAM.TabIndex = 3
            Me.lblAM.Text = "AM"
            Dim lblPM As Global.System.Windows.Forms.Control = Me.lblPM
            point = New Global.System.Drawing.Point(16, 48)
            lblPM.Location = point
            Me.lblPM.Name = "lblPM"
            Dim lblPM2 As Global.System.Windows.Forms.Control = Me.lblPM
            size = New Global.System.Drawing.Size(24, 16)
            lblPM2.Size = size
            Me.lblPM.TabIndex = 3
            Me.lblPM.Text = "PM"
            Dim label37 As Global.System.Windows.Forms.Control = Me.Label23
            point = New Global.System.Drawing.Point(272, 8)
            label37.Location = point
            Me.Label23.Name = "Label23"
            Dim label38 As Global.System.Windows.Forms.Control = Me.Label23
            size = New Global.System.Drawing.Size(16, 16)
            label38.Size = size
            Me.Label23.TabIndex = 3
            Me.Label23.Text = "9"
            Dim label39 As Global.System.Windows.Forms.Control = Me.Label24
            point = New Global.System.Drawing.Point(294, 8)
            label39.Location = point
            Me.Label24.Name = "Label24"
            Dim label40 As Global.System.Windows.Forms.Control = Me.Label24
            size = New Global.System.Drawing.Size(24, 16)
            label40.Size = size
            Me.Label24.TabIndex = 3
            Me.Label24.Text = "10"
            Dim chkb2a As Global.System.Windows.Forms.Control = Me.chkb2a
            point = New Global.System.Drawing.Point(104, 24)
            chkb2a.Location = point
            Me.chkb2a.Name = "chkb2a"
            Dim chkb2a2 As Global.System.Windows.Forms.Control = Me.chkb2a
            size = New Global.System.Drawing.Size(16, 16)
            chkb2a2.Size = size
            Me.chkb2a.TabIndex = 1
            Me.chkb2a.Tag = "2"
            Me.chkb2a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim lbl As Global.System.Windows.Forms.Control = Me.lbl12
            point = New Global.System.Drawing.Point(54, 8)
            lbl.Location = point
            Me.lbl12.Name = "lbl12"
            Dim lbl2 As Global.System.Windows.Forms.Control = Me.lbl12
            size = New Global.System.Drawing.Size(24, 16)
            lbl2.Size = size
            Me.lbl12.TabIndex = 3
            Me.lbl12.Text = "12"
            Dim label41 As Global.System.Windows.Forms.Control = Me.Label17
            point = New Global.System.Drawing.Point(128, 8)
            label41.Location = point
            Me.Label17.Name = "Label17"
            Dim label42 As Global.System.Windows.Forms.Control = Me.Label17
            size = New Global.System.Drawing.Size(16, 16)
            label42.Size = size
            Me.Label17.TabIndex = 3
            Me.Label17.Text = "3"
            Dim label43 As Global.System.Windows.Forms.Control = Me.Label22
            point = New Global.System.Drawing.Point(248, 8)
            label43.Location = point
            Me.Label22.Name = "Label22"
            Dim label44 As Global.System.Windows.Forms.Control = Me.Label22
            size = New Global.System.Drawing.Size(16, 16)
            label44.Size = size
            Me.Label22.TabIndex = 3
            Me.Label22.Text = "8"
            Dim label45 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(104, 8)
            label45.Location = point
            Me.Label14.Name = "Label14"
            Dim label46 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(16, 16)
            label46.Size = size
            Me.Label14.TabIndex = 3
            Me.Label14.Text = "2"
            Dim chkb12a As Global.System.Windows.Forms.Control = Me.chkb12a
            point = New Global.System.Drawing.Point(56, 24)
            chkb12a.Location = point
            Me.chkb12a.Name = "chkb12a"
            Dim chkb12a2 As Global.System.Windows.Forms.Control = Me.chkb12a
            size = New Global.System.Drawing.Size(16, 16)
            chkb12a2.Size = size
            Me.chkb12a.TabIndex = 1
            Me.chkb12a.Tag = "0"
            Me.chkb12a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim label47 As Global.System.Windows.Forms.Control = Me.Label19
            point = New Global.System.Drawing.Point(176, 8)
            label47.Location = point
            Me.Label19.Name = "Label19"
            Dim label48 As Global.System.Windows.Forms.Control = Me.Label19
            size = New Global.System.Drawing.Size(16, 16)
            label48.Size = size
            Me.Label19.TabIndex = 3
            Me.Label19.Text = "5"
            Me.chkbActive.Checked = True
            Me.chkbActive.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbActive As Global.System.Windows.Forms.Control = Me.chkbActive
            point = New Global.System.Drawing.Point(32, 16)
            chkbActive.Location = point
            Me.chkbActive.Name = "chkbActive"
            Me.chkbActive.TabIndex = 0
            Me.chkbActive.Text = "Active"
            Me.GroupBox6.Controls.Add(Me.rbSequential)
            Me.GroupBox6.Controls.Add(Me.rbRandom)
            Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox6
            point = New Global.System.Drawing.Point(256, 216)
            groupBox3.Location = point
            Me.GroupBox6.Name = "GroupBox6"
            Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox6
            size = New Global.System.Drawing.Size(224, 56)
            groupBox4.Size = size
            Me.GroupBox6.TabIndex = 2
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Play Order"
            Me.rbSequential.Checked = True
            Dim rbSequential As Global.System.Windows.Forms.Control = Me.rbSequential
            point = New Global.System.Drawing.Point(40, 16)
            rbSequential.Location = point
            Me.rbSequential.Name = "rbSequential"
            Dim rbSequential2 As Global.System.Windows.Forms.Control = Me.rbSequential
            size = New Global.System.Drawing.Size(104, 16)
            rbSequential2.Size = size
            Me.rbSequential.TabIndex = 2
            Me.rbSequential.TabStop = True
            Me.rbSequential.Text = "Sequential"
            Dim rbRandom As Global.System.Windows.Forms.Control = Me.rbRandom
            point = New Global.System.Drawing.Point(40, 32)
            rbRandom.Location = point
            Me.rbRandom.Name = "rbRandom"
            Dim rbRandom2 As Global.System.Windows.Forms.Control = Me.rbRandom
            size = New Global.System.Drawing.Size(104, 16)
            rbRandom2.Size = size
            Me.rbRandom.TabIndex = 1
            Me.rbRandom.Text = "Random"
            Me.gbInterval.Controls.Add(Me.Label16)
            Me.gbInterval.Controls.Add(Me.Label15)
            Me.gbInterval.Controls.Add(Me.nudInterval)
            Me.gbInterval.Controls.Add(Me.nudIntervalVrtn)
            Dim gbInterval As Global.System.Windows.Forms.Control = Me.gbInterval
            point = New Global.System.Drawing.Point(8, 296)
            gbInterval.Location = point
            Me.gbInterval.Name = "gbInterval"
            Dim gbInterval2 As Global.System.Windows.Forms.Control = Me.gbInterval
            size = New Global.System.Drawing.Size(472, 72)
            gbInterval2.Size = size
            Me.gbInterval.TabIndex = 1
            Me.gbInterval.TabStop = False
            Me.gbInterval.Text = "Interval"
            Dim label49 As Global.System.Windows.Forms.Control = Me.Label16
            point = New Global.System.Drawing.Point(24, 40)
            label49.Location = point
            Me.Label16.Name = "Label16"
            Dim label50 As Global.System.Windows.Forms.Control = Me.Label16
            size = New Global.System.Drawing.Size(144, 16)
            label50.Size = size
            Me.Label16.TabIndex = 4
            Me.Label16.Text = "Interval Variation (seconds)"
            Dim label51 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(24, 16)
            label51.Location = point
            Me.Label15.Name = "Label15"
            Dim label52 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(232, 16)
            label52.Size = size
            Me.Label15.TabIndex = 3
            Me.Label15.Text = "Interval between playing sounds (seconds)"
            Me.nudInterval.DecimalPlaces = 2
            Dim nudInterval As Global.System.Windows.Forms.Control = Me.nudInterval
            point = New Global.System.Drawing.Point(272, 16)
            nudInterval.Location = point
            Dim nudInterval2 As Global.System.Windows.Forms.NumericUpDown = Me.nudInterval
            num = New Decimal(New Integer() {600, 0, 0, 0})
            nudInterval2.Maximum = num
            Me.nudInterval.Name = "nudInterval"
            Dim nudInterval3 As Global.System.Windows.Forms.Control = Me.nudInterval
            size = New Global.System.Drawing.Size(64, 20)
            nudInterval3.Size = size
            Me.nudInterval.TabIndex = 0
            Me.nudIntervalVrtn.DecimalPlaces = 2
            Dim nudIntervalVrtn As Global.System.Windows.Forms.Control = Me.nudIntervalVrtn
            point = New Global.System.Drawing.Point(272, 40)
            nudIntervalVrtn.Location = point
            Me.nudIntervalVrtn.Name = "nudIntervalVrtn"
            Dim nudIntervalVrtn2 As Global.System.Windows.Forms.Control = Me.nudIntervalVrtn
            size = New Global.System.Drawing.Size(64, 20)
            nudIntervalVrtn2.Size = size
            Me.nudIntervalVrtn.TabIndex = 0
            Me.GroupBox5.Controls.Add(Me.rbOnce)
            Me.GroupBox5.Controls.Add(Me.rbRepeating)
            Me.GroupBox5.Controls.Add(Me.rbLooping)
            Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox5
            point = New Global.System.Drawing.Point(8, 216)
            groupBox5.Location = point
            Me.GroupBox5.Name = "GroupBox5"
            Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox5
            size = New Global.System.Drawing.Size(232, 72)
            groupBox6.Size = size
            Me.GroupBox5.TabIndex = 2
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Play Style"
            Me.rbOnce.Checked = True
            Dim rbOnce As Global.System.Windows.Forms.Control = Me.rbOnce
            point = New Global.System.Drawing.Point(40, 16)
            rbOnce.Location = point
            Me.rbOnce.Name = "rbOnce"
            Dim rbOnce2 As Global.System.Windows.Forms.Control = Me.rbOnce
            size = New Global.System.Drawing.Size(104, 16)
            rbOnce2.Size = size
            Me.rbOnce.TabIndex = 2
            Me.rbOnce.TabStop = True
            Me.rbOnce.Text = "Once"
            Dim rbRepeating As Global.System.Windows.Forms.Control = Me.rbRepeating
            point = New Global.System.Drawing.Point(40, 32)
            rbRepeating.Location = point
            Me.rbRepeating.Name = "rbRepeating"
            Dim rbRepeating2 As Global.System.Windows.Forms.Control = Me.rbRepeating
            size = New Global.System.Drawing.Size(104, 16)
            rbRepeating2.Size = size
            Me.rbRepeating.TabIndex = 1
            Me.rbRepeating.Text = "Repeating"
            Me.rbLooping.Enabled = False
            Dim rbLooping As Global.System.Windows.Forms.Control = Me.rbLooping
            point = New Global.System.Drawing.Point(40, 48)
            rbLooping.Location = point
            Me.rbLooping.Name = "rbLooping"
            Dim rbLooping2 As Global.System.Windows.Forms.Control = Me.rbLooping
            size = New Global.System.Drawing.Size(136, 16)
            rbLooping2.Size = size
            Me.rbLooping.TabIndex = 1
            Me.rbLooping.Text = "Seamlessly looping"
            Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
            point = New Global.System.Drawing.Point(336, 520)
            btnSave.Location = point
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 3
            Me.btnSave.Text = "&Save"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(432, 520)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "&Cancel"
            Me.btnDebug.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
            point = New Global.System.Drawing.Point(0, 0)
            btnDebug.Location = point
            Me.btnDebug.Name = "btnDebug"
            Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
            size = New Global.System.Drawing.Size(8, 8)
            btnDebug2.Size = size
            Me.btnDebug.TabIndex = 19
            Me.btnDebug.TabStop = False
            Me.Timer1.Interval = 10
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(536, 549)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnDebug)
            Me.Name = "frmUTS_Editor"
            Me.Text = "Sound Editor"
            Me.TabControl1.ResumeLayout(False)
            Me.tabpagBasic.ResumeLayout(False)
            CType(Me.trkbarVolume, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tbapagPositioning.ResumeLayout(False)
            Me.gbHeight.ResumeLayout(False)
            CType(Me.nudElevation, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbVolumeDistances.ResumeLayout(False)
            CType(Me.nudMaxDistance, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMinDistance, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRandomRange.ResumeLayout(False)
            CType(Me.nudRandomRangeY, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRandomRangeX, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAdvanced.ResumeLayout(False)
            Me.pnlVolPitch.ResumeLayout(False)
            CType(Me.trkbarVolumeVrtn, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarPitchVrtn, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.pnlHours.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.gbInterval.ResumeLayout(False)
            CType(Me.nudInterval, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudIntervalVrtn, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox5.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000AC0 RID: 2752
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
