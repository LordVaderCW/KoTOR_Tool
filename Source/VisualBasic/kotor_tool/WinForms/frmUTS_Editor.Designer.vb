Option Strict Off
Option Explicit On

Imports System.Windows.Forms

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmUTS_Editor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderRule As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterRule As Global.System.Windows.Forms.Label

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
        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x06001622 RID: 5666 RVA: 0x002C0BB0 File Offset: 0x002BFBB0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tabpagBasic = New System.Windows.Forms.TabPage()
            Me.tbVolume = New System.Windows.Forms.TextBox()
            Me.trkbarVolume = New System.Windows.Forms.TrackBar()
            Me.btnAddSound = New System.Windows.Forms.Button()
            Me.btnRemoveSound = New System.Windows.Forms.Button()
            Me.btnMoveUp = New System.Windows.Forms.Button()
            Me.btnMoveDown = New System.Windows.Forms.Button()
            Me.lbSounds = New System.Windows.Forms.ListBox()
            Me.tbComment = New System.Windows.Forms.TextBox()
            Me.btnSetNameLang = New System.Windows.Forms.Button()
            Me.tbTag = New System.Windows.Forms.TextBox()
            Me.tbName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnPlaySound = New System.Windows.Forms.Button()
            Me.btnStopSound = New System.Windows.Forms.Button()
            Me.tbSoundStatus = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.tbapagPositioning = New System.Windows.Forms.TabPage()
            Me.gbHeight = New System.Windows.Forms.GroupBox()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.nudElevation = New System.Windows.Forms.NumericUpDown()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.gbVolumeDistances = New System.Windows.Forms.GroupBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.nudMaxDistance = New System.Windows.Forms.NumericUpDown()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.nudMinDistance = New System.Windows.Forms.NumericUpDown()
            Me.rbPlaysEverywhere = New System.Windows.Forms.RadioButton()
            Me.rbRandomPosition = New System.Windows.Forms.RadioButton()
            Me.rbSpecificPosition = New System.Windows.Forms.RadioButton()
            Me.gbRandomRange = New System.Windows.Forms.GroupBox()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.nudRandomRangeY = New System.Windows.Forms.NumericUpDown()
            Me.nudRandomRangeX = New System.Windows.Forms.NumericUpDown()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.tabpagAdvanced = New System.Windows.Forms.TabPage()
            Me.pnlVolPitch = New System.Windows.Forms.Panel()
            Me.tbPitchVrtn = New System.Windows.Forms.TextBox()
            Me.trkbarVolumeVrtn = New System.Windows.Forms.TrackBar()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.trkbarPitchVrtn = New System.Windows.Forms.TrackBar()
            Me.tbVolumeVrtn = New System.Windows.Forms.TextBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.rbPlayDay = New System.Windows.Forms.RadioButton()
            Me.rbPlayNight = New System.Windows.Forms.RadioButton()
            Me.rbPlayAllTimes = New System.Windows.Forms.RadioButton()
            Me.rbPlaySpecificHours = New System.Windows.Forms.RadioButton()
            Me.pnlHours = New System.Windows.Forms.Panel()
            Me.chkb3a = New System.Windows.Forms.CheckBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.chkb3p = New System.Windows.Forms.CheckBox()
            Me.chkb10p = New System.Windows.Forms.CheckBox()
            Me.chkb12p = New System.Windows.Forms.CheckBox()
            Me.chkb1p = New System.Windows.Forms.CheckBox()
            Me.chkb4a = New System.Windows.Forms.CheckBox()
            Me.chkb6a = New System.Windows.Forms.CheckBox()
            Me.chkb5a = New System.Windows.Forms.CheckBox()
            Me.chkb7a = New System.Windows.Forms.CheckBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.chkb8p = New System.Windows.Forms.CheckBox()
            Me.chkb2p = New System.Windows.Forms.CheckBox()
            Me.chkb9p = New System.Windows.Forms.CheckBox()
            Me.chkb11p = New System.Windows.Forms.CheckBox()
            Me.chkb11a = New System.Windows.Forms.CheckBox()
            Me.chkb9a = New System.Windows.Forms.CheckBox()
            Me.chkb10a = New System.Windows.Forms.CheckBox()
            Me.chkb8a = New System.Windows.Forms.CheckBox()
            Me.chkb7p = New System.Windows.Forms.CheckBox()
            Me.chkb5p = New System.Windows.Forms.CheckBox()
            Me.chkb6p = New System.Windows.Forms.CheckBox()
            Me.chkb4p = New System.Windows.Forms.CheckBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.chkb1a = New System.Windows.Forms.CheckBox()
            Me.lblAM = New System.Windows.Forms.Label()
            Me.lblPM = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.chkb2a = New System.Windows.Forms.CheckBox()
            Me.lbl12 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.chkb12a = New System.Windows.Forms.CheckBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.chkbActive = New System.Windows.Forms.CheckBox()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.rbSequential = New System.Windows.Forms.RadioButton()
            Me.rbRandom = New System.Windows.Forms.RadioButton()
            Me.gbInterval = New System.Windows.Forms.GroupBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.nudInterval = New System.Windows.Forms.NumericUpDown()
            Me.nudIntervalVrtn = New System.Windows.Forms.NumericUpDown()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.rbOnce = New System.Windows.Forms.RadioButton()
            Me.rbRepeating = New System.Windows.Forms.RadioButton()
            Me.rbLooping = New System.Windows.Forms.RadioButton()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterRule = New System.Windows.Forms.Label()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderRule = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tabpagBasic.SuspendLayout()
            CType(Me.trkbarVolume, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tbapagPositioning.SuspendLayout()
            Me.gbHeight.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudElevation, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbVolumeDistances.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMaxDistance, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMinDistance, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRandomRange.SuspendLayout()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRandomRangeY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRandomRangeX, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAdvanced.SuspendLayout()
            Me.pnlVolPitch.SuspendLayout()
            CType(Me.trkbarVolumeVrtn, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarPitchVrtn, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            Me.pnlHours.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.gbInterval.SuspendLayout()
            CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudIntervalVrtn, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox5.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(560, 712)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Controls.Add(Me.btnDebug)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 67)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(16, 10, 16, 10)
            Me.pnlBody.Size = New System.Drawing.Size(560, 583)
            Me.pnlBody.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.tabpagBasic)
            Me.TabControl1.Controls.Add(Me.tbapagPositioning)
            Me.TabControl1.Controls.Add(Me.tabpagAdvanced)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(16, 10)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(528, 563)
            Me.TabControl1.TabIndex = 0
            '
            'tabpagBasic
            '
            Me.tabpagBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagBasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagBasic.Location = New System.Drawing.Point(4, 22)
            Me.tabpagBasic.Name = "tabpagBasic"
            Me.tabpagBasic.Size = New System.Drawing.Size(520, 503)
            Me.tabpagBasic.TabIndex = 0
            Me.tabpagBasic.Text = "Basic"
            '
            'tbVolume
            '
            Me.tbVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbVolume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbVolume.Location = New System.Drawing.Point(136, 452)
            Me.tbVolume.Name = "tbVolume"
            Me.tbVolume.ReadOnly = True
            Me.tbVolume.Size = New System.Drawing.Size(40, 22)
            Me.tbVolume.TabIndex = 25
            '
            'trkbarVolume
            '
            Me.trkbarVolume.Location = New System.Drawing.Point(184, 452)
            Me.trkbarVolume.Maximum = 127
            Me.trkbarVolume.Name = "trkbarVolume"
            Me.trkbarVolume.Size = New System.Drawing.Size(216, 45)
            Me.trkbarVolume.TabIndex = 21
            Me.trkbarVolume.TickFrequency = 5
            '
            'btnAddSound
            '
            Me.btnAddSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAddSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAddSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAddSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAddSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddSound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnAddSound.Location = New System.Drawing.Point(352, 175)
            Me.btnAddSound.Name = "btnAddSound"
            Me.btnAddSound.Size = New System.Drawing.Size(88, 27)
            Me.btnAddSound.TabIndex = 19
            Me.btnAddSound.Text = "Add Sound..."
            Me.btnAddSound.UseVisualStyleBackColor = False
            '
            'btnRemoveSound
            '
            Me.btnRemoveSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRemoveSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnRemoveSound.Enabled = False
            Me.btnRemoveSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnRemoveSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnRemoveSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnRemoveSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemoveSound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnRemoveSound.Location = New System.Drawing.Point(352, 212)
            Me.btnRemoveSound.Name = "btnRemoveSound"
            Me.btnRemoveSound.Size = New System.Drawing.Size(88, 27)
            Me.btnRemoveSound.TabIndex = 20
            Me.btnRemoveSound.Text = "Remove"
            Me.btnRemoveSound.UseVisualStyleBackColor = False
            '
            'btnMoveUp
            '
            Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnMoveUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnMoveUp.Enabled = False
            Me.btnMoveUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnMoveUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMoveUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnMoveUp.Location = New System.Drawing.Point(352, 360)
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.Size = New System.Drawing.Size(88, 27)
            Me.btnMoveUp.TabIndex = 17
            Me.btnMoveUp.Text = "Move Up"
            Me.btnMoveUp.UseVisualStyleBackColor = False
            '
            'btnMoveDown
            '
            Me.btnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnMoveDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnMoveDown.Enabled = False
            Me.btnMoveDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnMoveDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMoveDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnMoveDown.Location = New System.Drawing.Point(352, 397)
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.Size = New System.Drawing.Size(88, 26)
            Me.btnMoveDown.TabIndex = 18
            Me.btnMoveDown.Text = "Move Down"
            Me.btnMoveDown.UseVisualStyleBackColor = False
            '
            'lbSounds
            '
            Me.lbSounds.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.lbSounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbSounds.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbSounds.Location = New System.Drawing.Point(136, 175)
            Me.lbSounds.Name = "lbSounds"
            Me.lbSounds.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.lbSounds.Size = New System.Drawing.Size(176, 236)
            Me.lbSounds.TabIndex = 16
            '
            'tbComment
            '
            Me.tbComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbComment.Location = New System.Drawing.Point(136, 92)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New System.Drawing.Size(304, 65)
            Me.tbComment.TabIndex = 15
            '
            'btnSetNameLang
            '
            Me.btnSetNameLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSetNameLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetNameLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetNameLang.Location = New System.Drawing.Point(352, 28)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New System.Drawing.Size(96, 26)
            Me.btnSetNameLang.TabIndex = 14
            Me.btnSetNameLang.Text = "Set Language"
            Me.btnSetNameLang.UseVisualStyleBackColor = False
            '
            'tbTag
            '
            Me.tbTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTag.Location = New System.Drawing.Point(136, 55)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(200, 22)
            Me.tbTag.TabIndex = 13
            '
            'tbName
            '
            Me.tbName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbName.Location = New System.Drawing.Point(136, 28)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New System.Drawing.Size(200, 22)
            Me.tbName.TabIndex = 12
            '
            'Label1
            '
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(40, 28)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 18)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Name"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(40, 55)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 19)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(40, 102)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(80, 18)
            Me.Label3.TabIndex = 11
            Me.Label3.Text = "Comments"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(40, 185)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 27)
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "Sounds to Play"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(40, 452)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(88, 19)
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "In-game Volume"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnPlaySound
            '
            Me.btnPlaySound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnPlaySound.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPlaySound.Enabled = False
            Me.btnPlaySound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPlaySound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPlaySound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPlaySound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPlaySound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPlaySound.Location = New System.Drawing.Point(352, 268)
            Me.btnPlaySound.Name = "btnPlaySound"
            Me.btnPlaySound.Size = New System.Drawing.Size(88, 26)
            Me.btnPlaySound.TabIndex = 19
            Me.btnPlaySound.Text = "Play Sound"
            Me.btnPlaySound.UseVisualStyleBackColor = False
            '
            'btnStopSound
            '
            Me.btnStopSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnStopSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnStopSound.Enabled = False
            Me.btnStopSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnStopSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnStopSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnStopSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStopSound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnStopSound.Location = New System.Drawing.Point(352, 305)
            Me.btnStopSound.Name = "btnStopSound"
            Me.btnStopSound.Size = New System.Drawing.Size(88, 26)
            Me.btnStopSound.TabIndex = 19
            Me.btnStopSound.Text = "Stop"
            Me.btnStopSound.UseVisualStyleBackColor = False
            '
            'tbSoundStatus
            '
            Me.tbSoundStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbSoundStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbSoundStatus.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbSoundStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSoundStatus.Location = New System.Drawing.Point(136, 425)
            Me.tbSoundStatus.Name = "tbSoundStatus"
            Me.tbSoundStatus.ReadOnly = True
            Me.tbSoundStatus.Size = New System.Drawing.Size(176, 20)
            Me.tbSoundStatus.TabIndex = 25
            Me.tbSoundStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label26
            '
            Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label26.Location = New System.Drawing.Point(40, 425)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(80, 18)
            Me.Label26.TabIndex = 11
            Me.Label26.Text = "Time"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbapagPositioning
            '
            Me.tbapagPositioning.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tbapagPositioning.Controls.Add(Me.gbHeight)
            Me.tbapagPositioning.Controls.Add(Me.gbVolumeDistances)
            Me.tbapagPositioning.Controls.Add(Me.rbPlaysEverywhere)
            Me.tbapagPositioning.Controls.Add(Me.rbRandomPosition)
            Me.tbapagPositioning.Controls.Add(Me.rbSpecificPosition)
            Me.tbapagPositioning.Controls.Add(Me.gbRandomRange)
            Me.tbapagPositioning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbapagPositioning.Location = New System.Drawing.Point(4, 22)
            Me.tbapagPositioning.Name = "tbapagPositioning"
            Me.tbapagPositioning.Size = New System.Drawing.Size(520, 503)
            Me.tbapagPositioning.TabIndex = 1
            Me.tbapagPositioning.Text = "Positioning"
            '
            'gbHeight
            '
            Me.gbHeight.Controls.Add(Me.PictureBox2)
            Me.gbHeight.Controls.Add(Me.nudElevation)
            Me.gbHeight.Controls.Add(Me.Label10)
            Me.gbHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.gbHeight.Location = New System.Drawing.Point(16, 252)
            Me.gbHeight.Name = "gbHeight"
            Me.gbHeight.Size = New System.Drawing.Size(184, 203)
            Me.gbHeight.TabIndex = 2
            Me.gbHeight.TabStop = False
            Me.gbHeight.Text = "Height (m)"
            '
            'PictureBox2
            '
            Me.PictureBox2.Location = New System.Drawing.Point(8, 46)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(94, 111)
            Me.PictureBox2.TabIndex = 3
            Me.PictureBox2.TabStop = False
            '
            'nudElevation
            '
            Me.nudElevation.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudElevation.DecimalPlaces = 1
            Me.nudElevation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudElevation.Location = New System.Drawing.Point(112, 83)
            Me.nudElevation.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
            Me.nudElevation.Name = "nudElevation"
            Me.nudElevation.Size = New System.Drawing.Size(64, 22)
            Me.nudElevation.TabIndex = 0
            '
            'Label10
            '
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(112, 65)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(64, 18)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Height (m)"
            '
            'gbVolumeDistances
            '
            Me.gbVolumeDistances.Controls.Add(Me.PictureBox1)
            Me.gbVolumeDistances.Controls.Add(Me.Label8)
            Me.gbVolumeDistances.Controls.Add(Me.nudMaxDistance)
            Me.gbVolumeDistances.Controls.Add(Me.Label9)
            Me.gbVolumeDistances.Controls.Add(Me.nudMinDistance)
            Me.gbVolumeDistances.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.gbVolumeDistances.Location = New System.Drawing.Point(16, 108)
            Me.gbVolumeDistances.Name = "gbVolumeDistances"
            Me.gbVolumeDistances.Size = New System.Drawing.Size(484, 138)
            Me.gbVolumeDistances.TabIndex = 1
            Me.gbVolumeDistances.TabStop = False
            Me.gbVolumeDistances.Text = "Volume Distances"
            '
            'PictureBox1
            '
            Me.PictureBox1.Location = New System.Drawing.Point(8, 28)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(90, 94)
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            '
            'Label8
            '
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(128, 18)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(120, 19)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Cutoff distance (m)"
            '
            'nudMaxDistance
            '
            Me.nudMaxDistance.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudMaxDistance.DecimalPlaces = 1
            Me.nudMaxDistance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudMaxDistance.Location = New System.Drawing.Point(128, 37)
            Me.nudMaxDistance.Name = "nudMaxDistance"
            Me.nudMaxDistance.Size = New System.Drawing.Size(64, 22)
            Me.nudMaxDistance.TabIndex = 0
            '
            'Label9
            '
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(128, 74)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(152, 18)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Max Volume distance (m)"
            '
            'nudMinDistance
            '
            Me.nudMinDistance.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudMinDistance.DecimalPlaces = 1
            Me.nudMinDistance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudMinDistance.Location = New System.Drawing.Point(128, 92)
            Me.nudMinDistance.Name = "nudMinDistance"
            Me.nudMinDistance.Size = New System.Drawing.Size(64, 22)
            Me.nudMinDistance.TabIndex = 0
            '
            'rbPlaysEverywhere
            '
            Me.rbPlaysEverywhere.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbPlaysEverywhere.Location = New System.Drawing.Point(24, 18)
            Me.rbPlaysEverywhere.Name = "rbPlaysEverywhere"
            Me.rbPlaysEverywhere.Size = New System.Drawing.Size(176, 28)
            Me.rbPlaysEverywhere.TabIndex = 0
            Me.rbPlaysEverywhere.Text = "Plays everywhere in area"
            '
            'rbRandomPosition
            '
            Me.rbRandomPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbRandomPosition.Location = New System.Drawing.Point(24, 46)
            Me.rbRandomPosition.Name = "rbRandomPosition"
            Me.rbRandomPosition.Size = New System.Drawing.Size(288, 28)
            Me.rbRandomPosition.TabIndex = 0
            Me.rbRandomPosition.Text = "Plays from a random position each time it is played"
            '
            'rbSpecificPosition
            '
            Me.rbSpecificPosition.Checked = True
            Me.rbSpecificPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbSpecificPosition.Location = New System.Drawing.Point(24, 74)
            Me.rbSpecificPosition.Name = "rbSpecificPosition"
            Me.rbSpecificPosition.Size = New System.Drawing.Size(184, 28)
            Me.rbSpecificPosition.TabIndex = 0
            Me.rbSpecificPosition.TabStop = True
            Me.rbSpecificPosition.Text = "Plays from a specific position"
            '
            'gbRandomRange
            '
            Me.gbRandomRange.Controls.Add(Me.PictureBox3)
            Me.gbRandomRange.Controls.Add(Me.nudRandomRangeY)
            Me.gbRandomRange.Controls.Add(Me.nudRandomRangeX)
            Me.gbRandomRange.Controls.Add(Me.Label11)
            Me.gbRandomRange.Controls.Add(Me.Label12)
            Me.gbRandomRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.gbRandomRange.Location = New System.Drawing.Point(208, 252)
            Me.gbRandomRange.Name = "gbRandomRange"
            Me.gbRandomRange.Size = New System.Drawing.Size(292, 203)
            Me.gbRandomRange.TabIndex = 2
            Me.gbRandomRange.TabStop = False
            Me.gbRandomRange.Text = "Random Range"
            '
            'PictureBox3
            '
            Me.PictureBox3.Location = New System.Drawing.Point(8, 28)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(96, 109)
            Me.PictureBox3.TabIndex = 3
            Me.PictureBox3.TabStop = False
            '
            'nudRandomRangeY
            '
            Me.nudRandomRangeY.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudRandomRangeY.DecimalPlaces = 1
            Me.nudRandomRangeY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudRandomRangeY.Location = New System.Drawing.Point(112, 46)
            Me.nudRandomRangeY.Name = "nudRandomRangeY"
            Me.nudRandomRangeY.Size = New System.Drawing.Size(64, 22)
            Me.nudRandomRangeY.TabIndex = 0
            '
            'nudRandomRangeX
            '
            Me.nudRandomRangeX.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudRandomRangeX.DecimalPlaces = 1
            Me.nudRandomRangeX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudRandomRangeX.Location = New System.Drawing.Point(16, 166)
            Me.nudRandomRangeX.Name = "nudRandomRangeX"
            Me.nudRandomRangeX.Size = New System.Drawing.Size(64, 22)
            Me.nudRandomRangeX.TabIndex = 0
            '
            'Label11
            '
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(112, 28)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(160, 18)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "North-South Random Range (m)"
            '
            'Label12
            '
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(16, 148)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(160, 18)
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "West-East Random Range (m)"
            '
            'tabpagAdvanced
            '
            Me.tabpagAdvanced.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagAdvanced.Controls.Add(Me.pnlVolPitch)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox4)
            Me.tabpagAdvanced.Controls.Add(Me.chkbActive)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox6)
            Me.tabpagAdvanced.Controls.Add(Me.gbInterval)
            Me.tabpagAdvanced.Controls.Add(Me.GroupBox5)
            Me.tabpagAdvanced.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagAdvanced.Location = New System.Drawing.Point(4, 22)
            Me.tabpagAdvanced.Name = "tabpagAdvanced"
            Me.tabpagAdvanced.Size = New System.Drawing.Size(520, 537)
            Me.tabpagAdvanced.TabIndex = 2
            Me.tabpagAdvanced.Text = "Advanced"
            '
            'pnlVolPitch
            '
            Me.pnlVolPitch.Controls.Add(Me.tbPitchVrtn)
            Me.pnlVolPitch.Controls.Add(Me.trkbarVolumeVrtn)
            Me.pnlVolPitch.Controls.Add(Me.Label6)
            Me.pnlVolPitch.Controls.Add(Me.Label7)
            Me.pnlVolPitch.Controls.Add(Me.trkbarPitchVrtn)
            Me.pnlVolPitch.Controls.Add(Me.tbVolumeVrtn)
            Me.pnlVolPitch.Location = New System.Drawing.Point(8, 427)
            Me.pnlVolPitch.Name = "pnlVolPitch"
            Me.pnlVolPitch.Size = New System.Drawing.Size(504, 101)
            Me.pnlVolPitch.TabIndex = 25
            '
            'tbPitchVrtn
            '
            Me.tbPitchVrtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbPitchVrtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbPitchVrtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbPitchVrtn.Location = New System.Drawing.Point(171, 62)
            Me.tbPitchVrtn.Name = "tbPitchVrtn"
            Me.tbPitchVrtn.ReadOnly = True
            Me.tbPitchVrtn.Size = New System.Drawing.Size(40, 22)
            Me.tbPitchVrtn.TabIndex = 24
            '
            'trkbarVolumeVrtn
            '
            Me.trkbarVolumeVrtn.Location = New System.Drawing.Point(216, 9)
            Me.trkbarVolumeVrtn.Maximum = 100
            Me.trkbarVolumeVrtn.Name = "trkbarVolumeVrtn"
            Me.trkbarVolumeVrtn.Size = New System.Drawing.Size(216, 45)
            Me.trkbarVolumeVrtn.TabIndex = 23
            Me.trkbarVolumeVrtn.TickFrequency = 5
            '
            'Label6
            '
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(21, 9)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(136, 22)
            Me.Label6.TabIndex = 22
            Me.Label6.Text = "Volume Variation"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(21, 56)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(136, 28)
            Me.Label7.TabIndex = 22
            Me.Label7.Text = "Pitch  Variation (octaves)"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'trkbarPitchVrtn
            '
            Me.trkbarPitchVrtn.Location = New System.Drawing.Point(216, 53)
            Me.trkbarPitchVrtn.Maximum = 100
            Me.trkbarPitchVrtn.Name = "trkbarPitchVrtn"
            Me.trkbarPitchVrtn.Size = New System.Drawing.Size(216, 45)
            Me.trkbarPitchVrtn.TabIndex = 23
            Me.trkbarPitchVrtn.TickFrequency = 5
            '
            'tbVolumeVrtn
            '
            Me.tbVolumeVrtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbVolumeVrtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbVolumeVrtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbVolumeVrtn.Location = New System.Drawing.Point(171, 9)
            Me.tbVolumeVrtn.Name = "tbVolumeVrtn"
            Me.tbVolumeVrtn.ReadOnly = True
            Me.tbVolumeVrtn.Size = New System.Drawing.Size(40, 22)
            Me.tbVolumeVrtn.TabIndex = 24
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.rbPlayDay)
            Me.GroupBox4.Controls.Add(Me.rbPlayNight)
            Me.GroupBox4.Controls.Add(Me.rbPlayAllTimes)
            Me.GroupBox4.Controls.Add(Me.rbPlaySpecificHours)
            Me.GroupBox4.Controls.Add(Me.pnlHours)
            Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.GroupBox4.Location = New System.Drawing.Point(8, 55)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(504, 225)
            Me.GroupBox4.TabIndex = 1
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "When to play"
            '
            'rbPlayDay
            '
            Me.rbPlayDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbPlayDay.Location = New System.Drawing.Point(40, 18)
            Me.rbPlayDay.Name = "rbPlayDay"
            Me.rbPlayDay.Size = New System.Drawing.Size(128, 19)
            Me.rbPlayDay.TabIndex = 0
            Me.rbPlayDay.Text = "Play during the day"
            '
            'rbPlayNight
            '
            Me.rbPlayNight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbPlayNight.Location = New System.Drawing.Point(40, 37)
            Me.rbPlayNight.Name = "rbPlayNight"
            Me.rbPlayNight.Size = New System.Drawing.Size(128, 18)
            Me.rbPlayNight.TabIndex = 0
            Me.rbPlayNight.Text = "Play at night"
            '
            'rbPlayAllTimes
            '
            Me.rbPlayAllTimes.Checked = True
            Me.rbPlayAllTimes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbPlayAllTimes.Location = New System.Drawing.Point(40, 55)
            Me.rbPlayAllTimes.Name = "rbPlayAllTimes"
            Me.rbPlayAllTimes.Size = New System.Drawing.Size(128, 19)
            Me.rbPlayAllTimes.TabIndex = 0
            Me.rbPlayAllTimes.TabStop = True
            Me.rbPlayAllTimes.Text = "Play at all times"
            '
            'rbPlaySpecificHours
            '
            Me.rbPlaySpecificHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbPlaySpecificHours.Location = New System.Drawing.Point(40, 74)
            Me.rbPlaySpecificHours.Name = "rbPlaySpecificHours"
            Me.rbPlaySpecificHours.Size = New System.Drawing.Size(128, 18)
            Me.rbPlaySpecificHours.TabIndex = 0
            Me.rbPlaySpecificHours.Text = "Specific Hours"
            '
            'pnlHours
            '
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
            Me.pnlHours.Location = New System.Drawing.Point(40, 92)
            Me.pnlHours.Name = "pnlHours"
            Me.pnlHours.Size = New System.Drawing.Size(352, 92)
            Me.pnlHours.TabIndex = 4
            '
            'chkb3a
            '
            Me.chkb3a.Location = New System.Drawing.Point(128, 28)
            Me.chkb3a.Name = "chkb3a"
            Me.chkb3a.Size = New System.Drawing.Size(16, 18)
            Me.chkb3a.TabIndex = 1
            Me.chkb3a.Tag = "3"
            Me.chkb3a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label21
            '
            Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label21.Location = New System.Drawing.Point(224, 9)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(16, 19)
            Me.Label21.TabIndex = 3
            Me.Label21.Text = "7"
            '
            'Label20
            '
            Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label20.Location = New System.Drawing.Point(200, 9)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(16, 19)
            Me.Label20.TabIndex = 3
            Me.Label20.Text = "6"
            '
            'Label18
            '
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(152, 9)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(16, 19)
            Me.Label18.TabIndex = 3
            Me.Label18.Text = "4"
            '
            'chkb3p
            '
            Me.chkb3p.Location = New System.Drawing.Point(128, 55)
            Me.chkb3p.Name = "chkb3p"
            Me.chkb3p.Size = New System.Drawing.Size(16, 19)
            Me.chkb3p.TabIndex = 1
            Me.chkb3p.Tag = "15"
            Me.chkb3p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb10p
            '
            Me.chkb10p.Location = New System.Drawing.Point(296, 55)
            Me.chkb10p.Name = "chkb10p"
            Me.chkb10p.Size = New System.Drawing.Size(16, 19)
            Me.chkb10p.TabIndex = 1
            Me.chkb10p.Tag = "22"
            Me.chkb10p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb12p
            '
            Me.chkb12p.Location = New System.Drawing.Point(56, 55)
            Me.chkb12p.Name = "chkb12p"
            Me.chkb12p.Size = New System.Drawing.Size(16, 19)
            Me.chkb12p.TabIndex = 1
            Me.chkb12p.Tag = "12"
            Me.chkb12p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb1p
            '
            Me.chkb1p.Location = New System.Drawing.Point(80, 55)
            Me.chkb1p.Name = "chkb1p"
            Me.chkb1p.Size = New System.Drawing.Size(16, 19)
            Me.chkb1p.TabIndex = 1
            Me.chkb1p.Tag = "13"
            Me.chkb1p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb4a
            '
            Me.chkb4a.Location = New System.Drawing.Point(152, 28)
            Me.chkb4a.Name = "chkb4a"
            Me.chkb4a.Size = New System.Drawing.Size(16, 18)
            Me.chkb4a.TabIndex = 1
            Me.chkb4a.Tag = "4"
            Me.chkb4a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb6a
            '
            Me.chkb6a.Location = New System.Drawing.Point(200, 28)
            Me.chkb6a.Name = "chkb6a"
            Me.chkb6a.Size = New System.Drawing.Size(16, 18)
            Me.chkb6a.TabIndex = 1
            Me.chkb6a.Tag = "6"
            Me.chkb6a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb5a
            '
            Me.chkb5a.Location = New System.Drawing.Point(176, 28)
            Me.chkb5a.Name = "chkb5a"
            Me.chkb5a.Size = New System.Drawing.Size(16, 18)
            Me.chkb5a.TabIndex = 1
            Me.chkb5a.Tag = "5"
            Me.chkb5a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb7a
            '
            Me.chkb7a.Location = New System.Drawing.Point(224, 28)
            Me.chkb7a.Name = "chkb7a"
            Me.chkb7a.Size = New System.Drawing.Size(16, 18)
            Me.chkb7a.TabIndex = 1
            Me.chkb7a.Tag = "7"
            Me.chkb7a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label25
            '
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(318, 9)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(24, 19)
            Me.Label25.TabIndex = 3
            Me.Label25.Text = "11"
            '
            'chkb8p
            '
            Me.chkb8p.Location = New System.Drawing.Point(248, 55)
            Me.chkb8p.Name = "chkb8p"
            Me.chkb8p.Size = New System.Drawing.Size(16, 19)
            Me.chkb8p.TabIndex = 1
            Me.chkb8p.Tag = "20"
            Me.chkb8p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb2p
            '
            Me.chkb2p.Location = New System.Drawing.Point(104, 55)
            Me.chkb2p.Name = "chkb2p"
            Me.chkb2p.Size = New System.Drawing.Size(16, 19)
            Me.chkb2p.TabIndex = 1
            Me.chkb2p.Tag = "14"
            Me.chkb2p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb9p
            '
            Me.chkb9p.Location = New System.Drawing.Point(272, 55)
            Me.chkb9p.Name = "chkb9p"
            Me.chkb9p.Size = New System.Drawing.Size(16, 19)
            Me.chkb9p.TabIndex = 1
            Me.chkb9p.Tag = "21"
            Me.chkb9p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb11p
            '
            Me.chkb11p.Location = New System.Drawing.Point(320, 55)
            Me.chkb11p.Name = "chkb11p"
            Me.chkb11p.Size = New System.Drawing.Size(16, 19)
            Me.chkb11p.TabIndex = 1
            Me.chkb11p.Tag = "23"
            Me.chkb11p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb11a
            '
            Me.chkb11a.Location = New System.Drawing.Point(320, 28)
            Me.chkb11a.Name = "chkb11a"
            Me.chkb11a.Size = New System.Drawing.Size(16, 18)
            Me.chkb11a.TabIndex = 1
            Me.chkb11a.Tag = "11"
            Me.chkb11a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb9a
            '
            Me.chkb9a.Location = New System.Drawing.Point(272, 28)
            Me.chkb9a.Name = "chkb9a"
            Me.chkb9a.Size = New System.Drawing.Size(16, 18)
            Me.chkb9a.TabIndex = 1
            Me.chkb9a.Tag = "9"
            Me.chkb9a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb10a
            '
            Me.chkb10a.Location = New System.Drawing.Point(296, 28)
            Me.chkb10a.Name = "chkb10a"
            Me.chkb10a.Size = New System.Drawing.Size(16, 18)
            Me.chkb10a.TabIndex = 1
            Me.chkb10a.Tag = "10"
            Me.chkb10a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb8a
            '
            Me.chkb8a.Location = New System.Drawing.Point(248, 28)
            Me.chkb8a.Name = "chkb8a"
            Me.chkb8a.Size = New System.Drawing.Size(16, 18)
            Me.chkb8a.TabIndex = 1
            Me.chkb8a.Tag = "8"
            Me.chkb8a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb7p
            '
            Me.chkb7p.Location = New System.Drawing.Point(224, 55)
            Me.chkb7p.Name = "chkb7p"
            Me.chkb7p.Size = New System.Drawing.Size(16, 19)
            Me.chkb7p.TabIndex = 1
            Me.chkb7p.Tag = "19"
            Me.chkb7p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb5p
            '
            Me.chkb5p.Location = New System.Drawing.Point(176, 55)
            Me.chkb5p.Name = "chkb5p"
            Me.chkb5p.Size = New System.Drawing.Size(16, 19)
            Me.chkb5p.TabIndex = 1
            Me.chkb5p.Tag = "17"
            Me.chkb5p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb6p
            '
            Me.chkb6p.Location = New System.Drawing.Point(200, 55)
            Me.chkb6p.Name = "chkb6p"
            Me.chkb6p.Size = New System.Drawing.Size(16, 19)
            Me.chkb6p.TabIndex = 1
            Me.chkb6p.Tag = "18"
            Me.chkb6p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'chkb4p
            '
            Me.chkb4p.Location = New System.Drawing.Point(152, 55)
            Me.chkb4p.Name = "chkb4p"
            Me.chkb4p.Size = New System.Drawing.Size(16, 19)
            Me.chkb4p.TabIndex = 1
            Me.chkb4p.Tag = "16"
            Me.chkb4p.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label13
            '
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(80, 9)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(16, 19)
            Me.Label13.TabIndex = 3
            Me.Label13.Text = "1"
            '
            'chkb1a
            '
            Me.chkb1a.Location = New System.Drawing.Point(80, 28)
            Me.chkb1a.Name = "chkb1a"
            Me.chkb1a.Size = New System.Drawing.Size(16, 18)
            Me.chkb1a.TabIndex = 1
            Me.chkb1a.Tag = "1"
            Me.chkb1a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblAM
            '
            Me.lblAM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblAM.Location = New System.Drawing.Point(16, 28)
            Me.lblAM.Name = "lblAM"
            Me.lblAM.Size = New System.Drawing.Size(24, 18)
            Me.lblAM.TabIndex = 3
            Me.lblAM.Text = "AM"
            '
            'lblPM
            '
            Me.lblPM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblPM.Location = New System.Drawing.Point(16, 55)
            Me.lblPM.Name = "lblPM"
            Me.lblPM.Size = New System.Drawing.Size(24, 19)
            Me.lblPM.TabIndex = 3
            Me.lblPM.Text = "PM"
            '
            'Label23
            '
            Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label23.Location = New System.Drawing.Point(272, 9)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(16, 19)
            Me.Label23.TabIndex = 3
            Me.Label23.Text = "9"
            '
            'Label24
            '
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(294, 9)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(24, 19)
            Me.Label24.TabIndex = 3
            Me.Label24.Text = "10"
            '
            'chkb2a
            '
            Me.chkb2a.Location = New System.Drawing.Point(104, 28)
            Me.chkb2a.Name = "chkb2a"
            Me.chkb2a.Size = New System.Drawing.Size(16, 18)
            Me.chkb2a.TabIndex = 1
            Me.chkb2a.Tag = "2"
            Me.chkb2a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lbl12
            '
            Me.lbl12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lbl12.Location = New System.Drawing.Point(54, 9)
            Me.lbl12.Name = "lbl12"
            Me.lbl12.Size = New System.Drawing.Size(24, 19)
            Me.lbl12.TabIndex = 3
            Me.lbl12.Text = "12"
            '
            'Label17
            '
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(128, 9)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(16, 19)
            Me.Label17.TabIndex = 3
            Me.Label17.Text = "3"
            '
            'Label22
            '
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(248, 9)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(16, 19)
            Me.Label22.TabIndex = 3
            Me.Label22.Text = "8"
            '
            'Label14
            '
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(104, 9)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(16, 19)
            Me.Label14.TabIndex = 3
            Me.Label14.Text = "2"
            '
            'chkb12a
            '
            Me.chkb12a.Location = New System.Drawing.Point(56, 28)
            Me.chkb12a.Name = "chkb12a"
            Me.chkb12a.Size = New System.Drawing.Size(16, 18)
            Me.chkb12a.TabIndex = 1
            Me.chkb12a.Tag = "0"
            Me.chkb12a.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label19
            '
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(176, 9)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(16, 19)
            Me.Label19.TabIndex = 3
            Me.Label19.Text = "5"
            '
            'chkbActive
            '
            Me.chkbActive.Checked = True
            Me.chkbActive.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbActive.Location = New System.Drawing.Point(32, 18)
            Me.chkbActive.Name = "chkbActive"
            Me.chkbActive.Size = New System.Drawing.Size(104, 28)
            Me.chkbActive.TabIndex = 0
            Me.chkbActive.Text = "Active"
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.rbSequential)
            Me.GroupBox6.Controls.Add(Me.rbRandom)
            Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.GroupBox6.Location = New System.Drawing.Point(278, 286)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(234, 65)
            Me.GroupBox6.TabIndex = 2
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Play Order"
            '
            'rbSequential
            '
            Me.rbSequential.Checked = True
            Me.rbSequential.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbSequential.Location = New System.Drawing.Point(40, 18)
            Me.rbSequential.Name = "rbSequential"
            Me.rbSequential.Size = New System.Drawing.Size(104, 19)
            Me.rbSequential.TabIndex = 2
            Me.rbSequential.TabStop = True
            Me.rbSequential.Text = "Sequential"
            '
            'rbRandom
            '
            Me.rbRandom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbRandom.Location = New System.Drawing.Point(40, 37)
            Me.rbRandom.Name = "rbRandom"
            Me.rbRandom.Size = New System.Drawing.Size(104, 18)
            Me.rbRandom.TabIndex = 1
            Me.rbRandom.Text = "Random"
            '
            'gbInterval
            '
            Me.gbInterval.Controls.Add(Me.Label16)
            Me.gbInterval.Controls.Add(Me.Label15)
            Me.gbInterval.Controls.Add(Me.nudInterval)
            Me.gbInterval.Controls.Add(Me.nudIntervalVrtn)
            Me.gbInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.gbInterval.Location = New System.Drawing.Point(8, 357)
            Me.gbInterval.Name = "gbInterval"
            Me.gbInterval.Size = New System.Drawing.Size(504, 64)
            Me.gbInterval.TabIndex = 1
            Me.gbInterval.TabStop = False
            Me.gbInterval.Text = "Interval"
            '
            'Label16
            '
            Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label16.Location = New System.Drawing.Point(24, 42)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(176, 18)
            Me.Label16.TabIndex = 4
            Me.Label16.Text = "Interval Variation (seconds)"
            '
            'Label15
            '
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(24, 18)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(232, 19)
            Me.Label15.TabIndex = 3
            Me.Label15.Text = "Interval between playing sounds (seconds)"
            '
            'nudInterval
            '
            Me.nudInterval.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudInterval.DecimalPlaces = 2
            Me.nudInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudInterval.Location = New System.Drawing.Point(272, 18)
            Me.nudInterval.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
            Me.nudInterval.Name = "nudInterval"
            Me.nudInterval.Size = New System.Drawing.Size(64, 22)
            Me.nudInterval.TabIndex = 0
            '
            'nudIntervalVrtn
            '
            Me.nudIntervalVrtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudIntervalVrtn.DecimalPlaces = 2
            Me.nudIntervalVrtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudIntervalVrtn.Location = New System.Drawing.Point(272, 42)
            Me.nudIntervalVrtn.Name = "nudIntervalVrtn"
            Me.nudIntervalVrtn.Size = New System.Drawing.Size(64, 22)
            Me.nudIntervalVrtn.TabIndex = 0
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.rbOnce)
            Me.GroupBox5.Controls.Add(Me.rbRepeating)
            Me.GroupBox5.Controls.Add(Me.rbLooping)
            Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.GroupBox5.Location = New System.Drawing.Point(8, 286)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(265, 65)
            Me.GroupBox5.TabIndex = 2
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Play Style"
            '
            'rbOnce
            '
            Me.rbOnce.Checked = True
            Me.rbOnce.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbOnce.Location = New System.Drawing.Point(40, 18)
            Me.rbOnce.Name = "rbOnce"
            Me.rbOnce.Size = New System.Drawing.Size(104, 19)
            Me.rbOnce.TabIndex = 2
            Me.rbOnce.TabStop = True
            Me.rbOnce.Text = "Once"
            '
            'rbRepeating
            '
            Me.rbRepeating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbRepeating.Location = New System.Drawing.Point(40, 37)
            Me.rbRepeating.Name = "rbRepeating"
            Me.rbRepeating.Size = New System.Drawing.Size(104, 18)
            Me.rbRepeating.TabIndex = 1
            Me.rbRepeating.Text = "Repeating"
            '
            'rbLooping
            '
            Me.rbLooping.Enabled = False
            Me.rbLooping.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbLooping.Location = New System.Drawing.Point(128, 37)
            Me.rbLooping.Name = "rbLooping"
            Me.rbLooping.Size = New System.Drawing.Size(136, 18)
            Me.rbLooping.TabIndex = 1
            Me.rbLooping.Text = "Seamlessly looping"
            '
            'btnDebug
            '
            Me.btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnDebug.Location = New System.Drawing.Point(0, 27)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 9)
            Me.btnDebug.TabIndex = 19
            Me.btnDebug.TabStop = False
            Me.btnDebug.UseVisualStyleBackColor = False
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterRule)
            Me.pnlFooter.Controls.Add(Me.btnSave)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 650)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(560, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(560, 1)
            Me.lblFooterRule.TabIndex = 0
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSave.Location = New System.Drawing.Point(372, 18)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(80, 29)
            Me.btnSave.TabIndex = 3
            Me.btnSave.Text = "&Save"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(464, 18)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(80, 29)
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderRule)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(560, 67)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(18, 12)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(360, 23)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Sound Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(20, 37)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(500, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Restored KoTOR Tool sound object editor."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 65)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(560, 2)
            Me.lblHeaderRule.TabIndex = 2
            '
            'Timer1
            '
            Me.Timer1.Interval = 10
            '
            'frmUTS_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(560, 712)
            Me.Controls.Add(Me.pnlRoot)
            Me.MinimumSize = New System.Drawing.Size(568, 717)
            Me.Name = "frmUTS_Editor"
            Me.Text = "Sound Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tabpagBasic.ResumeLayout(False)
            Me.tabpagBasic.PerformLayout()
            CType(Me.trkbarVolume, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tbapagPositioning.ResumeLayout(False)
            Me.gbHeight.ResumeLayout(False)
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudElevation, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbVolumeDistances.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMaxDistance, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMinDistance, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRandomRange.ResumeLayout(False)
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRandomRangeY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRandomRangeX, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAdvanced.ResumeLayout(False)
            Me.pnlVolPitch.ResumeLayout(False)
            Me.pnlVolPitch.PerformLayout()
            CType(Me.trkbarVolumeVrtn, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarPitchVrtn, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.pnlHours.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.gbInterval.ResumeLayout(False)
            CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudIntervalVrtn, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox5.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
