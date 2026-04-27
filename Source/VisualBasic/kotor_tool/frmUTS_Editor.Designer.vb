Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x02000082 RID: 130
    Partial Public Class frmUTS_Editor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents btnSetNameLang As Global.System.Windows.Forms.Button
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents tbComment As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents btnMoveUp As Global.System.Windows.Forms.Button
        Friend WithEvents btnMoveDown As Global.System.Windows.Forms.Button
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents lbSounds As Global.System.Windows.Forms.ListBox
        Friend WithEvents rbPlaysEverywhere As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbRandomPosition As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbSpecificPosition As Global.System.Windows.Forms.RadioButton
        Friend WithEvents tabpagBasic As Global.System.Windows.Forms.TabPage
        Friend WithEvents tbapagPositioning As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagAdvanced As Global.System.Windows.Forms.TabPage
        Friend WithEvents GroupBox4 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox5 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox6 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents chkbActive As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents gbHeight As Global.System.Windows.Forms.GroupBox
        Friend WithEvents gbVolumeDistances As Global.System.Windows.Forms.GroupBox
        Friend WithEvents gbRandomRange As Global.System.Windows.Forms.GroupBox
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As Global.System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox2 As Global.System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox3 As Global.System.Windows.Forms.PictureBox
        Friend WithEvents rbPlayDay As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbPlayNight As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbPlayAllTimes As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbPlaySpecificHours As Global.System.Windows.Forms.RadioButton
        Friend WithEvents trkbarVolumeVrtn As Global.System.Windows.Forms.TrackBar
        Friend WithEvents rbOnce As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbRepeating As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbSequential As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbRandom As Global.System.Windows.Forms.RadioButton
        Friend WithEvents gbInterval As Global.System.Windows.Forms.GroupBox
        Friend WithEvents nudInterval As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudIntervalVrtn As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents trkbarPitchVrtn As Global.System.Windows.Forms.TrackBar
        Friend WithEvents lbl12 As Global.System.Windows.Forms.Label
        Friend WithEvents lblPM As Global.System.Windows.Forms.Label
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents lblAM As Global.System.Windows.Forms.Label
        Friend WithEvents tbPitchVrtn As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudElevation As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRandomRangeY As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRandomRangeX As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents pnlHours As Global.System.Windows.Forms.Panel
        Friend WithEvents rbLooping As Global.System.Windows.Forms.RadioButton
        Friend WithEvents pnlVolPitch As Global.System.Windows.Forms.Panel
        Friend WithEvents btnAddSound As Global.System.Windows.Forms.Button
        Friend WithEvents btnRemoveSound As Global.System.Windows.Forms.Button
        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents trkbarVolume As Global.System.Windows.Forms.TrackBar
        Friend WithEvents nudMaxDistance As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbVolumeVrtn As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudMinDistance As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbVolume As Global.System.Windows.Forms.TextBox
        Friend WithEvents chkb3a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb3p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb10p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb4a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb6a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb5a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb7a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb8p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb2p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb9p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb11p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb11a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb9a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb10a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb8a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb7p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb5p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb6p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb4p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb1a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb2a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb12a As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb12p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkb1p As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnPlaySound As Global.System.Windows.Forms.Button
        Friend WithEvents Timer1 As Timer
        Friend WithEvents btnStopSound As Global.System.Windows.Forms.Button
        Friend WithEvents tbSoundStatus As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label26 As Global.System.Windows.Forms.Label


        ' Token: 0x06001543 RID: 5443 RVA: 0x002BF118 File Offset: 0x002BE118
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x06001622 RID: 5666 RVA: 0x002C0BB0 File Offset: 0x002BFBB0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUTS_Editor))
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
            Me.Timer1 = New Global.System.Windows.Forms.Timer()
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
            Me.TabControl1.Location = New Global.System.Drawing.Point(16, 8)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(504, 504)
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
            Me.tabpagBasic.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagBasic.Name = "tabpagBasic"
            Me.tabpagBasic.Size = New Global.System.Drawing.Size(496, 478)
            Me.tabpagBasic.TabIndex = 0
            Me.tabpagBasic.Text = "Basic"
            Me.tbVolume.Location = New Global.System.Drawing.Point(136, 424)
            Me.tbVolume.Name = "tbVolume"
            Me.tbVolume.[ReadOnly] = True
            Me.tbVolume.Size = New Global.System.Drawing.Size(40, 20)
            Me.tbVolume.TabIndex = 25
            Me.tbVolume.Text = ""
            Me.trkbarVolume.Location = New Global.System.Drawing.Point(184, 424)
            Me.trkbarVolume.Maximum = 127
            Me.trkbarVolume.Name = "trkbarVolume"
            Me.trkbarVolume.Size = New Global.System.Drawing.Size(216, 42)
            Me.trkbarVolume.TabIndex = 21
            Me.trkbarVolume.TickFrequency = 5
            Me.btnAddSound.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnAddSound.Location = New Global.System.Drawing.Point(328, 160)
            Me.btnAddSound.Name = "btnAddSound"
            Me.btnAddSound.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnAddSound.TabIndex = 19
            Me.btnAddSound.Text = "Add Sound..."
            Me.btnRemoveSound.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnRemoveSound.Enabled = False
            Me.btnRemoveSound.Location = New Global.System.Drawing.Point(328, 192)
            Me.btnRemoveSound.Name = "btnRemoveSound"
            Me.btnRemoveSound.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnRemoveSound.TabIndex = 20
            Me.btnRemoveSound.Text = "Remove"
            Me.btnMoveUp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnMoveUp.Enabled = False
            Me.btnMoveUp.Location = New Global.System.Drawing.Point(328, 320)
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnMoveUp.TabIndex = 17
            Me.btnMoveUp.Text = "Move Up"
            Me.btnMoveDown.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnMoveDown.Enabled = False
            Me.btnMoveDown.Location = New Global.System.Drawing.Point(328, 352)
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnMoveDown.TabIndex = 18
            Me.btnMoveDown.Text = "Move Down"
            Me.lbSounds.Location = New Global.System.Drawing.Point(136, 160)
            Me.lbSounds.Name = "lbSounds"
            Me.lbSounds.SelectionMode = Global.System.Windows.Forms.SelectionMode.MultiExtended
            Me.lbSounds.Size = New Global.System.Drawing.Size(144, 212)
            Me.lbSounds.TabIndex = 16
            Me.tbComment.Location = New Global.System.Drawing.Point(136, 80)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New Global.System.Drawing.Size(272, 64)
            Me.tbComment.TabIndex = 15
            Me.tbComment.Text = ""
            Me.btnSetNameLang.Location = New Global.System.Drawing.Point(344, 24)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetNameLang.TabIndex = 14
            Me.btnSetNameLang.Text = "Set Language"
            Me.tbTag.Location = New Global.System.Drawing.Point(136, 48)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbTag.TabIndex = 13
            Me.tbTag.Text = ""
            Me.tbName.Location = New Global.System.Drawing.Point(136, 24)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbName.TabIndex = 12
            Me.tbName.Text = ""
            Me.Label1.Location = New Global.System.Drawing.Point(40, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Name"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label2.Location = New Global.System.Drawing.Point(40, 48)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label3.Location = New Global.System.Drawing.Point(40, 88)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label3.TabIndex = 11
            Me.Label3.Text = "Comments"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label4.Location = New Global.System.Drawing.Point(40, 160)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(88, 24)
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "Sounds to Play"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label5.Location = New Global.System.Drawing.Point(40, 424)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "In-game Volume"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPlaySound.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnPlaySound.Enabled = False
            Me.btnPlaySound.Location = New Global.System.Drawing.Point(328, 240)
            Me.btnPlaySound.Name = "btnPlaySound"
            Me.btnPlaySound.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnPlaySound.TabIndex = 19
            Me.btnPlaySound.Text = "Play Sound"
            Me.btnStopSound.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnStopSound.Enabled = False
            Me.btnStopSound.Location = New Global.System.Drawing.Point(328, 272)
            Me.btnStopSound.Name = "btnStopSound"
            Me.btnStopSound.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnStopSound.TabIndex = 19
            Me.btnStopSound.Text = "Stop"
            Me.tbSoundStatus.Font = New Global.System.Drawing.Font("Courier New", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.tbSoundStatus.Location = New Global.System.Drawing.Point(136, 384)
            Me.tbSoundStatus.Name = "tbSoundStatus"
            Me.tbSoundStatus.[ReadOnly] = True
            Me.tbSoundStatus.Size = New Global.System.Drawing.Size(144, 20)
            Me.tbSoundStatus.TabIndex = 25
            Me.tbSoundStatus.Text = ""
            Me.tbSoundStatus.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label26.Location = New Global.System.Drawing.Point(40, 384)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label26.TabIndex = 11
            Me.Label26.Text = "Time"
            Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbapagPositioning.Controls.Add(Me.gbHeight)
            Me.tbapagPositioning.Controls.Add(Me.gbVolumeDistances)
            Me.tbapagPositioning.Controls.Add(Me.rbPlaysEverywhere)
            Me.tbapagPositioning.Controls.Add(Me.rbRandomPosition)
            Me.tbapagPositioning.Controls.Add(Me.rbSpecificPosition)
            Me.tbapagPositioning.Controls.Add(Me.gbRandomRange)
            Me.tbapagPositioning.Location = New Global.System.Drawing.Point(4, 22)
            Me.tbapagPositioning.Name = "tbapagPositioning"
            Me.tbapagPositioning.Size = New Global.System.Drawing.Size(496, 478)
            Me.tbapagPositioning.TabIndex = 1
            Me.tbapagPositioning.Text = "Positioning"
            Me.gbHeight.Controls.Add(Me.PictureBox2)
            Me.gbHeight.Controls.Add(Me.nudElevation)
            Me.gbHeight.Controls.Add(Me.Label10)
            Me.gbHeight.Location = New Global.System.Drawing.Point(16, 248)
            Me.gbHeight.Name = "gbHeight"
            Me.gbHeight.Size = New Global.System.Drawing.Size(184, 176)
            Me.gbHeight.TabIndex = 2
            Me.gbHeight.TabStop = False
            Me.gbHeight.Text = "Height (m)"
            Me.PictureBox2.Image = CType(resources.GetObject("Me.PictureBox2.Image"), Global.System.Drawing.Image)
            Me.PictureBox2.Location = New Global.System.Drawing.Point(8, 40)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New Global.System.Drawing.Size(94, 96)
            Me.PictureBox2.TabIndex = 3
            Me.PictureBox2.TabStop = False
            Me.nudElevation.DecimalPlaces = 1
            Me.nudElevation.Location = New Global.System.Drawing.Point(112, 72)
            Me.nudElevation.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
            Me.nudElevation.Name = "nudElevation"
            Me.nudElevation.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudElevation.TabIndex = 0
            Me.Label10.Location = New Global.System.Drawing.Point(112, 56)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Height (m)"
            Me.gbVolumeDistances.Controls.Add(Me.PictureBox1)
            Me.gbVolumeDistances.Controls.Add(Me.Label8)
            Me.gbVolumeDistances.Controls.Add(Me.nudMaxDistance)
            Me.gbVolumeDistances.Controls.Add(Me.Label9)
            Me.gbVolumeDistances.Controls.Add(Me.nudMinDistance)
            Me.gbVolumeDistances.Location = New Global.System.Drawing.Point(16, 104)
            Me.gbVolumeDistances.Name = "gbVolumeDistances"
            Me.gbVolumeDistances.Size = New Global.System.Drawing.Size(408, 120)
            Me.gbVolumeDistances.TabIndex = 1
            Me.gbVolumeDistances.TabStop = False
            Me.gbVolumeDistances.Text = "Volume Distances"
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
            Me.PictureBox1.Location = New Global.System.Drawing.Point(8, 24)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New Global.System.Drawing.Size(90, 82)
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            Me.Label8.Location = New Global.System.Drawing.Point(128, 16)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Cutoff distance (m)"
            Me.nudMaxDistance.DecimalPlaces = 1
            Me.nudMaxDistance.Location = New Global.System.Drawing.Point(128, 32)
            Me.nudMaxDistance.Name = "nudMaxDistance"
            Me.nudMaxDistance.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudMaxDistance.TabIndex = 0
            Me.Label9.Location = New Global.System.Drawing.Point(128, 64)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(152, 16)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Max Volume distance (m)"
            Me.nudMinDistance.DecimalPlaces = 1
            Me.nudMinDistance.Location = New Global.System.Drawing.Point(128, 80)
            Me.nudMinDistance.Name = "nudMinDistance"
            Me.nudMinDistance.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudMinDistance.TabIndex = 0
            Me.rbPlaysEverywhere.Location = New Global.System.Drawing.Point(24, 16)
            Me.rbPlaysEverywhere.Name = "rbPlaysEverywhere"
            Me.rbPlaysEverywhere.Size = New Global.System.Drawing.Size(160, 24)
            Me.rbPlaysEverywhere.TabIndex = 0
            Me.rbPlaysEverywhere.Text = "Plays everywhere in area"
            Me.rbRandomPosition.Location = New Global.System.Drawing.Point(24, 40)
            Me.rbRandomPosition.Name = "rbRandomPosition"
            Me.rbRandomPosition.Size = New Global.System.Drawing.Size(288, 24)
            Me.rbRandomPosition.TabIndex = 0
            Me.rbRandomPosition.Text = "Plays from a random position each time it is played"
            Me.rbSpecificPosition.Checked = True
            Me.rbSpecificPosition.Location = New Global.System.Drawing.Point(24, 64)
            Me.rbSpecificPosition.Name = "rbSpecificPosition"
            Me.rbSpecificPosition.Size = New Global.System.Drawing.Size(168, 24)
            Me.rbSpecificPosition.TabIndex = 0
            Me.rbSpecificPosition.TabStop = True
            Me.rbSpecificPosition.Text = "Plays from a specific position"
            Me.gbRandomRange.Controls.Add(Me.PictureBox3)
            Me.gbRandomRange.Controls.Add(Me.nudRandomRangeY)
            Me.gbRandomRange.Controls.Add(Me.nudRandomRangeX)
            Me.gbRandomRange.Controls.Add(Me.Label11)
            Me.gbRandomRange.Controls.Add(Me.Label12)
            Me.gbRandomRange.Location = New Global.System.Drawing.Point(208, 248)
            Me.gbRandomRange.Name = "gbRandomRange"
            Me.gbRandomRange.Size = New Global.System.Drawing.Size(280, 176)
            Me.gbRandomRange.TabIndex = 2
            Me.gbRandomRange.TabStop = False
            Me.gbRandomRange.Text = "Random Range"
            Me.PictureBox3.Image = CType(resources.GetObject("Me.PictureBox1.Image"), Global.System.Drawing.Image)
            Me.PictureBox3.Location = New Global.System.Drawing.Point(8, 24)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New Global.System.Drawing.Size(96, 95)
            Me.PictureBox3.TabIndex = 3
            Me.PictureBox3.TabStop = False
            Me.nudRandomRangeY.DecimalPlaces = 1
            Me.nudRandomRangeY.Location = New Global.System.Drawing.Point(112, 40)
            Me.nudRandomRangeY.Name = "nudRandomRangeY"
            Me.nudRandomRangeY.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudRandomRangeY.TabIndex = 0
            Me.nudRandomRangeX.DecimalPlaces = 1
            Me.nudRandomRangeX.Location = New Global.System.Drawing.Point(16, 144)
            Me.nudRandomRangeX.Name = "nudRandomRangeX"
            Me.nudRandomRangeX.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudRandomRangeX.TabIndex = 0
            Me.Label11.Location = New Global.System.Drawing.Point(112, 24)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(160, 16)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "North-South Random Range (m)"
            Me.Label12.Location = New Global.System.Drawing.Point(16, 128)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(160, 16)
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "West-East Random Range (m)"
            Me.tabpagAdvanced.Controls.Add(Me.pnlVolPitch)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox4)
            Me.tabpagAdvanced.Controls.Add(Me.chkbActive)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox6)
            Me.tabpagAdvanced.Controls.Add(Me.gbInterval)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox5)
            Me.tabpagAdvanced.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagAdvanced.Name = "tabpagAdvanced"
            Me.tabpagAdvanced.Size = New Global.System.Drawing.Size(496, 478)
            Me.tabpagAdvanced.TabIndex = 2
            Me.tabpagAdvanced.Text = "Advanced"
            Me.pnlVolPitch.Controls.Add(Me.tbPitchVrtn)
            Me.pnlVolPitch.Controls.Add(Me.trkbarVolumeVrtn)
            Me.pnlVolPitch.Controls.Add(Me.Label6)
            Me.pnlVolPitch.Controls.Add(Me.Label7)
            Me.pnlVolPitch.Controls.Add(Me.trkbarPitchVrtn)
            Me.pnlVolPitch.Controls.Add(Me.tbVolumeVrtn)
            Me.pnlVolPitch.Location = New Global.System.Drawing.Point(8, 368)
            Me.pnlVolPitch.Name = "pnlVolPitch"
            Me.pnlVolPitch.Size = New Global.System.Drawing.Size(480, 104)
            Me.pnlVolPitch.TabIndex = 25
            Me.tbPitchVrtn.Location = New Global.System.Drawing.Point(160, 64)
            Me.tbPitchVrtn.Name = "tbPitchVrtn"
            Me.tbPitchVrtn.[ReadOnly] = True
            Me.tbPitchVrtn.Size = New Global.System.Drawing.Size(40, 20)
            Me.tbPitchVrtn.TabIndex = 24
            Me.tbPitchVrtn.Text = ""
            Me.trkbarVolumeVrtn.Location = New Global.System.Drawing.Point(216, 8)
            Me.trkbarVolumeVrtn.Maximum = 100
            Me.trkbarVolumeVrtn.Name = "trkbarVolumeVrtn"
            Me.trkbarVolumeVrtn.Size = New Global.System.Drawing.Size(216, 42)
            Me.trkbarVolumeVrtn.TabIndex = 23
            Me.trkbarVolumeVrtn.TickFrequency = 5
            Me.Label6.Location = New Global.System.Drawing.Point(24, 16)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label6.TabIndex = 22
            Me.Label6.Text = "Volume Variation"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label7.Location = New Global.System.Drawing.Point(24, 64)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(160, 24)
            Me.Label7.TabIndex = 22
            Me.Label7.Text = "Pitch  Variation (octaves)"
            Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.trkbarPitchVrtn.Location = New Global.System.Drawing.Point(216, 56)
            Me.trkbarPitchVrtn.Maximum = 100
            Me.trkbarPitchVrtn.Name = "trkbarPitchVrtn"
            Me.trkbarPitchVrtn.Size = New Global.System.Drawing.Size(216, 42)
            Me.trkbarPitchVrtn.TabIndex = 23
            Me.trkbarPitchVrtn.TickFrequency = 5
            Me.tbVolumeVrtn.Location = New Global.System.Drawing.Point(160, 16)
            Me.tbVolumeVrtn.Name = "tbVolumeVrtn"
            Me.tbVolumeVrtn.[ReadOnly] = True
            Me.tbVolumeVrtn.Size = New Global.System.Drawing.Size(40, 20)
            Me.tbVolumeVrtn.TabIndex = 24
            Me.tbVolumeVrtn.Text = ""
            Me.GroupBox4.Controls.Add(Me.rbPlayDay)
            Me.GroupBox4.Controls.Add(Me.rbPlayNight)
            Me.GroupBox4.Controls.Add(Me.rbPlayAllTimes)
            Me.GroupBox4.Controls.Add(Me.rbPlaySpecificHours)
            Me.GroupBox4.Controls.Add(Me.pnlHours)
            Me.GroupBox4.Location = New Global.System.Drawing.Point(8, 48)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New Global.System.Drawing.Size(472, 160)
            Me.GroupBox4.TabIndex = 1
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "When to play"
            Me.rbPlayDay.Location = New Global.System.Drawing.Point(40, 16)
            Me.rbPlayDay.Name = "rbPlayDay"
            Me.rbPlayDay.Size = New Global.System.Drawing.Size(128, 16)
            Me.rbPlayDay.TabIndex = 0
            Me.rbPlayDay.Text = "Play during the day"
            Me.rbPlayNight.Location = New Global.System.Drawing.Point(40, 32)
            Me.rbPlayNight.Name = "rbPlayNight"
            Me.rbPlayNight.Size = New Global.System.Drawing.Size(128, 16)
            Me.rbPlayNight.TabIndex = 0
            Me.rbPlayNight.Text = "Play at night"
            Me.rbPlayAllTimes.Checked = True
            Me.rbPlayAllTimes.Location = New Global.System.Drawing.Point(40, 48)
            Me.rbPlayAllTimes.Name = "rbPlayAllTimes"
            Me.rbPlayAllTimes.Size = New Global.System.Drawing.Size(128, 16)
            Me.rbPlayAllTimes.TabIndex = 0
            Me.rbPlayAllTimes.TabStop = True
            Me.rbPlayAllTimes.Text = "Play at all times"
            Me.rbPlaySpecificHours.Location = New Global.System.Drawing.Point(40, 64)
            Me.rbPlaySpecificHours.Name = "rbPlaySpecificHours"
            Me.rbPlaySpecificHours.Size = New Global.System.Drawing.Size(128, 16)
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
            Me.pnlHours.Location = New Global.System.Drawing.Point(40, 80)
            Me.pnlHours.Name = "pnlHours"
            Me.pnlHours.Size = New Global.System.Drawing.Size(352, 72)
            Me.pnlHours.TabIndex = 4
            Me.chkb3a.Location = New Global.System.Drawing.Point(128, 24)
            Me.chkb3a.Name = "chkb3a"
            Me.chkb3a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb3a.TabIndex = 1
            Me.chkb3a.Tag = "3"
            Me.chkb3a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.Label21.Location = New Global.System.Drawing.Point(224, 8)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label21.TabIndex = 3
            Me.Label21.Text = "7"
            Me.Label20.Location = New Global.System.Drawing.Point(200, 8)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label20.TabIndex = 3
            Me.Label20.Text = "6"
            Me.Label18.Location = New Global.System.Drawing.Point(152, 8)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label18.TabIndex = 3
            Me.Label18.Text = "4"
            Me.chkb3p.Location = New Global.System.Drawing.Point(128, 48)
            Me.chkb3p.Name = "chkb3p"
            Me.chkb3p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb3p.TabIndex = 1
            Me.chkb3p.Tag = "15"
            Me.chkb3p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb10p.Location = New Global.System.Drawing.Point(296, 48)
            Me.chkb10p.Name = "chkb10p"
            Me.chkb10p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb10p.TabIndex = 1
            Me.chkb10p.Tag = "22"
            Me.chkb10p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb12p.Location = New Global.System.Drawing.Point(56, 48)
            Me.chkb12p.Name = "chkb12p"
            Me.chkb12p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb12p.TabIndex = 1
            Me.chkb12p.Tag = "12"
            Me.chkb12p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb1p.Location = New Global.System.Drawing.Point(80, 48)
            Me.chkb1p.Name = "chkb1p"
            Me.chkb1p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb1p.TabIndex = 1
            Me.chkb1p.Tag = "13"
            Me.chkb1p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb4a.Location = New Global.System.Drawing.Point(152, 24)
            Me.chkb4a.Name = "chkb4a"
            Me.chkb4a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb4a.TabIndex = 1
            Me.chkb4a.Tag = "4"
            Me.chkb4a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb6a.Location = New Global.System.Drawing.Point(200, 24)
            Me.chkb6a.Name = "chkb6a"
            Me.chkb6a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb6a.TabIndex = 1
            Me.chkb6a.Tag = "6"
            Me.chkb6a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb5a.Location = New Global.System.Drawing.Point(176, 24)
            Me.chkb5a.Name = "chkb5a"
            Me.chkb5a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb5a.TabIndex = 1
            Me.chkb5a.Tag = "5"
            Me.chkb5a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb7a.Location = New Global.System.Drawing.Point(224, 24)
            Me.chkb7a.Name = "chkb7a"
            Me.chkb7a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb7a.TabIndex = 1
            Me.chkb7a.Tag = "7"
            Me.chkb7a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.Label25.Location = New Global.System.Drawing.Point(318, 8)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label25.TabIndex = 3
            Me.Label25.Text = "11"
            Me.chkb8p.Location = New Global.System.Drawing.Point(248, 48)
            Me.chkb8p.Name = "chkb8p"
            Me.chkb8p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb8p.TabIndex = 1
            Me.chkb8p.Tag = "20"
            Me.chkb8p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb2p.Location = New Global.System.Drawing.Point(104, 48)
            Me.chkb2p.Name = "chkb2p"
            Me.chkb2p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb2p.TabIndex = 1
            Me.chkb2p.Tag = "14"
            Me.chkb2p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb9p.Location = New Global.System.Drawing.Point(272, 48)
            Me.chkb9p.Name = "chkb9p"
            Me.chkb9p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb9p.TabIndex = 1
            Me.chkb9p.Tag = "21"
            Me.chkb9p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb11p.Location = New Global.System.Drawing.Point(320, 48)
            Me.chkb11p.Name = "chkb11p"
            Me.chkb11p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb11p.TabIndex = 1
            Me.chkb11p.Tag = "23"
            Me.chkb11p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb11a.Location = New Global.System.Drawing.Point(320, 24)
            Me.chkb11a.Name = "chkb11a"
            Me.chkb11a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb11a.TabIndex = 1
            Me.chkb11a.Tag = "11"
            Me.chkb11a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb9a.Location = New Global.System.Drawing.Point(272, 24)
            Me.chkb9a.Name = "chkb9a"
            Me.chkb9a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb9a.TabIndex = 1
            Me.chkb9a.Tag = "9"
            Me.chkb9a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb10a.Location = New Global.System.Drawing.Point(296, 24)
            Me.chkb10a.Name = "chkb10a"
            Me.chkb10a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb10a.TabIndex = 1
            Me.chkb10a.Tag = "10"
            Me.chkb10a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb8a.Location = New Global.System.Drawing.Point(248, 24)
            Me.chkb8a.Name = "chkb8a"
            Me.chkb8a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb8a.TabIndex = 1
            Me.chkb8a.Tag = "8"
            Me.chkb8a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb7p.Location = New Global.System.Drawing.Point(224, 48)
            Me.chkb7p.Name = "chkb7p"
            Me.chkb7p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb7p.TabIndex = 1
            Me.chkb7p.Tag = "19"
            Me.chkb7p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb5p.Location = New Global.System.Drawing.Point(176, 48)
            Me.chkb5p.Name = "chkb5p"
            Me.chkb5p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb5p.TabIndex = 1
            Me.chkb5p.Tag = "17"
            Me.chkb5p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb6p.Location = New Global.System.Drawing.Point(200, 48)
            Me.chkb6p.Name = "chkb6p"
            Me.chkb6p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb6p.TabIndex = 1
            Me.chkb6p.Tag = "18"
            Me.chkb6p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.chkb4p.Location = New Global.System.Drawing.Point(152, 48)
            Me.chkb4p.Name = "chkb4p"
            Me.chkb4p.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb4p.TabIndex = 1
            Me.chkb4p.Tag = "16"
            Me.chkb4p.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.Label13.Location = New Global.System.Drawing.Point(80, 8)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label13.TabIndex = 3
            Me.Label13.Text = "1"
            Me.chkb1a.Location = New Global.System.Drawing.Point(80, 24)
            Me.chkb1a.Name = "chkb1a"
            Me.chkb1a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb1a.TabIndex = 1
            Me.chkb1a.Tag = "1"
            Me.chkb1a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.lblAM.Location = New Global.System.Drawing.Point(16, 24)
            Me.lblAM.Name = "lblAM"
            Me.lblAM.Size = New Global.System.Drawing.Size(24, 16)
            Me.lblAM.TabIndex = 3
            Me.lblAM.Text = "AM"
            Me.lblPM.Location = New Global.System.Drawing.Point(16, 48)
            Me.lblPM.Name = "lblPM"
            Me.lblPM.Size = New Global.System.Drawing.Size(24, 16)
            Me.lblPM.TabIndex = 3
            Me.lblPM.Text = "PM"
            Me.Label23.Location = New Global.System.Drawing.Point(272, 8)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label23.TabIndex = 3
            Me.Label23.Text = "9"
            Me.Label24.Location = New Global.System.Drawing.Point(294, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label24.TabIndex = 3
            Me.Label24.Text = "10"
            Me.chkb2a.Location = New Global.System.Drawing.Point(104, 24)
            Me.chkb2a.Name = "chkb2a"
            Me.chkb2a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb2a.TabIndex = 1
            Me.chkb2a.Tag = "2"
            Me.chkb2a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.lbl12.Location = New Global.System.Drawing.Point(54, 8)
            Me.lbl12.Name = "lbl12"
            Me.lbl12.Size = New Global.System.Drawing.Size(24, 16)
            Me.lbl12.TabIndex = 3
            Me.lbl12.Text = "12"
            Me.Label17.Location = New Global.System.Drawing.Point(128, 8)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label17.TabIndex = 3
            Me.Label17.Text = "3"
            Me.Label22.Location = New Global.System.Drawing.Point(248, 8)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label22.TabIndex = 3
            Me.Label22.Text = "8"
            Me.Label14.Location = New Global.System.Drawing.Point(104, 8)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label14.TabIndex = 3
            Me.Label14.Text = "2"
            Me.chkb12a.Location = New Global.System.Drawing.Point(56, 24)
            Me.chkb12a.Name = "chkb12a"
            Me.chkb12a.Size = New Global.System.Drawing.Size(16, 16)
            Me.chkb12a.TabIndex = 1
            Me.chkb12a.Tag = "0"
            Me.chkb12a.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.Label19.Location = New Global.System.Drawing.Point(176, 8)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label19.TabIndex = 3
            Me.Label19.Text = "5"
            Me.chkbActive.Checked = True
            Me.chkbActive.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbActive.Location = New Global.System.Drawing.Point(32, 16)
            Me.chkbActive.Name = "chkbActive"
            Me.chkbActive.TabIndex = 0
            Me.chkbActive.Text = "Active"
            Me.GroupBox6.Controls.Add(Me.rbSequential)
            Me.GroupBox6.Controls.Add(Me.rbRandom)
            Me.GroupBox6.Location = New Global.System.Drawing.Point(256, 216)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New Global.System.Drawing.Size(224, 56)
            Me.GroupBox6.TabIndex = 2
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Play Order"
            Me.rbSequential.Checked = True
            Me.rbSequential.Location = New Global.System.Drawing.Point(40, 16)
            Me.rbSequential.Name = "rbSequential"
            Me.rbSequential.Size = New Global.System.Drawing.Size(104, 16)
            Me.rbSequential.TabIndex = 2
            Me.rbSequential.TabStop = True
            Me.rbSequential.Text = "Sequential"
            Me.rbRandom.Location = New Global.System.Drawing.Point(40, 32)
            Me.rbRandom.Name = "rbRandom"
            Me.rbRandom.Size = New Global.System.Drawing.Size(104, 16)
            Me.rbRandom.TabIndex = 1
            Me.rbRandom.Text = "Random"
            Me.gbInterval.Controls.Add(Me.Label16)
            Me.gbInterval.Controls.Add(Me.Label15)
            Me.gbInterval.Controls.Add(Me.nudInterval)
            Me.gbInterval.Controls.Add(Me.nudIntervalVrtn)
            Me.gbInterval.Location = New Global.System.Drawing.Point(8, 296)
            Me.gbInterval.Name = "gbInterval"
            Me.gbInterval.Size = New Global.System.Drawing.Size(472, 72)
            Me.gbInterval.TabIndex = 1
            Me.gbInterval.TabStop = False
            Me.gbInterval.Text = "Interval"
            Me.Label16.Location = New Global.System.Drawing.Point(24, 40)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Global.System.Drawing.Size(144, 16)
            Me.Label16.TabIndex = 4
            Me.Label16.Text = "Interval Variation (seconds)"
            Me.Label15.Location = New Global.System.Drawing.Point(24, 16)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(232, 16)
            Me.Label15.TabIndex = 3
            Me.Label15.Text = "Interval between playing sounds (seconds)"
            Me.nudInterval.DecimalPlaces = 2
            Me.nudInterval.Location = New Global.System.Drawing.Point(272, 16)
            Me.nudInterval.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
            Me.nudInterval.Name = "nudInterval"
            Me.nudInterval.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudInterval.TabIndex = 0
            Me.nudIntervalVrtn.DecimalPlaces = 2
            Me.nudIntervalVrtn.Location = New Global.System.Drawing.Point(272, 40)
            Me.nudIntervalVrtn.Name = "nudIntervalVrtn"
            Me.nudIntervalVrtn.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudIntervalVrtn.TabIndex = 0
            Me.GroupBox5.Controls.Add(Me.rbOnce)
            Me.GroupBox5.Controls.Add(Me.rbRepeating)
            Me.GroupBox5.Controls.Add(Me.rbLooping)
            Me.GroupBox5.Location = New Global.System.Drawing.Point(8, 216)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New Global.System.Drawing.Size(232, 72)
            Me.GroupBox5.TabIndex = 2
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Play Style"
            Me.rbOnce.Checked = True
            Me.rbOnce.Location = New Global.System.Drawing.Point(40, 16)
            Me.rbOnce.Name = "rbOnce"
            Me.rbOnce.Size = New Global.System.Drawing.Size(104, 16)
            Me.rbOnce.TabIndex = 2
            Me.rbOnce.TabStop = True
            Me.rbOnce.Text = "Once"
            Me.rbRepeating.Location = New Global.System.Drawing.Point(40, 32)
            Me.rbRepeating.Name = "rbRepeating"
            Me.rbRepeating.Size = New Global.System.Drawing.Size(104, 16)
            Me.rbRepeating.TabIndex = 1
            Me.rbRepeating.Text = "Repeating"
            Me.rbLooping.Enabled = False
            Me.rbLooping.Location = New Global.System.Drawing.Point(40, 48)
            Me.rbLooping.Name = "rbLooping"
            Me.rbLooping.Size = New Global.System.Drawing.Size(136, 16)
            Me.rbLooping.TabIndex = 1
            Me.rbLooping.Text = "Seamlessly looping"
            Me.btnSave.Location = New Global.System.Drawing.Point(336, 520)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 3
            Me.btnSave.Text = "&Save"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(432, 520)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "&Cancel"
            Me.btnDebug.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New Global.System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New Global.System.Drawing.Size(8, 8)
            Me.btnDebug.TabIndex = 19
            Me.btnDebug.TabStop = False
            Me.Timer1.Interval = 10
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(536, 549)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
            AddHandler Me.btnMoveUp.Click, AddressOf Me.btnMoveUp_Click
            AddHandler Me.btnMoveDown.Click, AddressOf Me.btnMoveDown_Click
            AddHandler Me.lbSounds.SelectedIndexChanged, AddressOf Me.lbSounds_SelectedIndexChanged
            AddHandler Me.lbSounds.DoubleClick, AddressOf Me.lbSounds_DoubleClick
            AddHandler Me.rbPlaysEverywhere.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
            AddHandler Me.rbRandomPosition.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
            AddHandler Me.rbSpecificPosition.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
            AddHandler Me.rbPlayDay.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
            AddHandler Me.rbPlayNight.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
            AddHandler Me.rbPlayAllTimes.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
            AddHandler Me.rbPlaySpecificHours.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
            AddHandler Me.trkbarVolumeVrtn.ValueChanged, AddressOf Me.trkbarVolumeVrtn_ValueChanged
            AddHandler Me.rbOnce.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
            AddHandler Me.rbRepeating.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
            AddHandler Me.trkbarPitchVrtn.ValueChanged, AddressOf Me.trkbarPitchVrtn_ValueChanged
            AddHandler Me.rbLooping.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
            AddHandler Me.btnAddSound.Click, AddressOf Me.btnAddSound_Click
            AddHandler Me.btnRemoveSound.Click, AddressOf Me.btnRemoveSound_Click
            AddHandler Me.btnSave.Click, AddressOf Me.btnSave_Click
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.trkbarVolume.ValueChanged, AddressOf Me.trkbarVolume_ValueChanged
            AddHandler Me.btnPlaySound.Click, AddressOf Me.btnPlaySound_Click
            AddHandler Me.Timer1.Tick, AddressOf Me.Timer1_Tick
            AddHandler Me.btnStopSound.Click, AddressOf Me.btnStopSound_Click
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace
