Namespace kotor_tool
	' Token: 0x02000061 RID: 97
	Public Partial Class frmModuleIfo_AreaEditor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000975 RID: 2421 RVA: 0x0026E478 File Offset: 0x0026D478
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000B16 RID: 2838 RVA: 0x002711E8 File Offset: 0x002701E8
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.TabControlModule = New Global.System.Windows.Forms.TabControl()
            Me.tabpagModuleBasic = New Global.System.Windows.Forms.TabPage()
            Me.pboxXY = New Global.System.Windows.Forms.PictureBox()
            Me.nudXY = New Global.System.Windows.Forms.NumericUpDown()
            Me.lblBearing = New Global.System.Windows.Forms.Label()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.nudModEntryX = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.nudModEntryY = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label13 = New Global.System.Windows.Forms.Label()
            Me.nudModEntryZ = New Global.System.Windows.Forms.NumericUpDown()
            Me.btnSetModNameLang = New Global.System.Windows.Forms.Button()
            Me.tbModTag = New Global.System.Windows.Forms.TextBox()
            Me.tbModName = New Global.System.Windows.Forms.TextBox()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.tbModEntryArea = New Global.System.Windows.Forms.TextBox()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.tabpagModuleAdvanced = New Global.System.Windows.Forms.TabPage()
            Me.nudXPScale = New Global.System.Windows.Forms.NumericUpDown()
            Me.trkbarXPScale = New Global.System.Windows.Forms.TrackBar()
            Me.Label46 = New Global.System.Windows.Forms.Label()
            Me.nudMinutesPerHour = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.nudDawnStartHour = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.nudDuskStartHour = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.nudStartHour = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.nudStartDay = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.nudStartMonth = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.nudStartYear = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.tabpagModuleEvents = New Global.System.Windows.Forms.TabPage()
            Me.Label34 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnClientEntr = New Global.System.Windows.Forms.TextBox()
            Me.Label33 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnActvtItem = New Global.System.Windows.Forms.TextBox()
            Me.Label32 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnAcquirItem = New Global.System.Windows.Forms.TextBox()
            Me.Label35 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnClientLeav = New Global.System.Windows.Forms.TextBox()
            Me.tbMod_OnHeartbeat = New Global.System.Windows.Forms.TextBox()
            Me.Label36 = New Global.System.Windows.Forms.Label()
            Me.Label37 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnModLoad = New Global.System.Windows.Forms.TextBox()
            Me.tbMod_OnPlrDeath = New Global.System.Windows.Forms.TextBox()
            Me.Label38 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnPlrDying = New Global.System.Windows.Forms.TextBox()
            Me.Label39 = New Global.System.Windows.Forms.Label()
            Me.Label40 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnPlrLvlUp = New Global.System.Windows.Forms.TextBox()
            Me.Label41 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnSpawnBtnDn = New Global.System.Windows.Forms.TextBox()
            Me.tbMod_OnPlrRest = New Global.System.Windows.Forms.TextBox()
            Me.Label42 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnUnAqreItem = New Global.System.Windows.Forms.TextBox()
            Me.Label43 = New Global.System.Windows.Forms.Label()
            Me.Label44 = New Global.System.Windows.Forms.Label()
            Me.tbMod_OnUsrDefined = New Global.System.Windows.Forms.TextBox()
            Me.tabpagModuleDescription = New Global.System.Windows.Forms.TabPage()
            Me.btnSetDescriptionLang = New Global.System.Windows.Forms.Button()
            Me.tbModDescription = New Global.System.Windows.Forms.TextBox()
            Me.TabControlMain = New Global.System.Windows.Forms.TabControl()
            Me.TabPage5 = New Global.System.Windows.Forms.TabPage()
            Me.TabPage6 = New Global.System.Windows.Forms.TabPage()
            Me.TabControlArea = New Global.System.Windows.Forms.TabControl()
            Me.tabpagAreaBasic = New Global.System.Windows.Forms.TabPage()
            Me.chkbUnescapable = New Global.System.Windows.Forms.CheckBox()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.cmbxCameraStyle = New Global.System.Windows.Forms.ComboBox()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.NumericUpDown10 = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.NumericUpDown11 = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label16 = New Global.System.Windows.Forms.Label()
            Me.NumericUpDown12 = New Global.System.Windows.Forms.NumericUpDown()
            Me.btnSetAreaNameLang = New Global.System.Windows.Forms.Button()
            Me.tbAreaTag = New Global.System.Windows.Forms.TextBox()
            Me.tbAreaName = New Global.System.Windows.Forms.TextBox()
            Me.Label17 = New Global.System.Windows.Forms.Label()
            Me.Label18 = New Global.System.Windows.Forms.Label()
            Me.Label85 = New Global.System.Windows.Forms.Label()
            Me.chkbDisableTransit = New Global.System.Windows.Forms.CheckBox()
            Me.Label86 = New Global.System.Windows.Forms.Label()
            Me.tabpagAreaEnvironment = New Global.System.Windows.Forms.TabPage()
            Me.cmbxWindPower = New Global.System.Windows.Forms.ComboBox()
            Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
            Me.Label49 = New Global.System.Windows.Forms.Label()
            Me.nudChanceSnow = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label50 = New Global.System.Windows.Forms.Label()
            Me.nudChanceRain = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label51 = New Global.System.Windows.Forms.Label()
            Me.nudChanceLightning = New Global.System.Windows.Forms.NumericUpDown()
            Me.rbDayNightCycle = New Global.System.Windows.Forms.RadioButton()
            Me.gbMoon = New Global.System.Windows.Forms.GroupBox()
            Me.btnMoonDiffuseColor = New Global.System.Windows.Forms.Button()
            Me.Label24 = New Global.System.Windows.Forms.Label()
            Me.Label25 = New Global.System.Windows.Forms.Label()
            Me.btnMoonAmbientColor = New Global.System.Windows.Forms.Button()
            Me.Label31 = New Global.System.Windows.Forms.Label()
            Me.Label45 = New Global.System.Windows.Forms.Label()
            Me.btnMoonFogColor = New Global.System.Windows.Forms.Button()
            Me.chkbAreaMoonShadows = New Global.System.Windows.Forms.CheckBox()
            Me.Label47 = New Global.System.Windows.Forms.Label()
            Me.chkbMoonFogOn = New Global.System.Windows.Forms.CheckBox()
            Me.trkbarMoonFogNear = New Global.System.Windows.Forms.TrackBar()
            Me.lblMoonFogNear = New Global.System.Windows.Forms.Label()
            Me.trkbarMoonFogFar = New Global.System.Windows.Forms.TrackBar()
            Me.lblMoonFogFar = New Global.System.Windows.Forms.Label()
            Me.gbSun = New Global.System.Windows.Forms.GroupBox()
            Me.chkbAreaSunShadows = New Global.System.Windows.Forms.CheckBox()
            Me.trkbarSunFogNear = New Global.System.Windows.Forms.TrackBar()
            Me.Label27 = New Global.System.Windows.Forms.Label()
            Me.btnSunAmbientColor = New Global.System.Windows.Forms.Button()
            Me.Label26 = New Global.System.Windows.Forms.Label()
            Me.btnSunDiffuseColor = New Global.System.Windows.Forms.Button()
            Me.Label28 = New Global.System.Windows.Forms.Label()
            Me.btnSunFogColor = New Global.System.Windows.Forms.Button()
            Me.Label29 = New Global.System.Windows.Forms.Label()
            Me.Label30 = New Global.System.Windows.Forms.Label()
            Me.trkbarSunFogFar = New Global.System.Windows.Forms.TrackBar()
            Me.lblSunFogNear = New Global.System.Windows.Forms.Label()
            Me.lblSunFogFar = New Global.System.Windows.Forms.Label()
            Me.chkbSunFogOn = New Global.System.Windows.Forms.CheckBox()
            Me.rbAlwaysDay = New Global.System.Windows.Forms.RadioButton()
            Me.rbAlwaysNight = New Global.System.Windows.Forms.RadioButton()
            Me.btnDynAmbientColor = New Global.System.Windows.Forms.Button()
            Me.Label48 = New Global.System.Windows.Forms.Label()
            Me.Label73 = New Global.System.Windows.Forms.Label()
            Me.nudShadowOpacity = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label84 = New Global.System.Windows.Forms.Label()
            Me.tabpagAreaGrass = New Global.System.Windows.Forms.TabPage()
            Me.nudGrassDensity = New Global.System.Windows.Forms.NumericUpDown()
            Me.trkbarGrassDensityX10 = New Global.System.Windows.Forms.TrackBar()
            Me.Label62 = New Global.System.Windows.Forms.Label()
            Me.btnGrassDiffuseColor = New Global.System.Windows.Forms.Button()
            Me.tbGrass_TexName = New Global.System.Windows.Forms.TextBox()
            Me.Label20 = New Global.System.Windows.Forms.Label()
            Me.Label21 = New Global.System.Windows.Forms.Label()
            Me.Label22 = New Global.System.Windows.Forms.Label()
            Me.btnGrassAmbientColor = New Global.System.Windows.Forms.Button()
            Me.Label23 = New Global.System.Windows.Forms.Label()
            Me.btnGrassEmissiveColor = New Global.System.Windows.Forms.Button()
            Me.nudGrassProbUL = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudGrassProbLL = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudGrassProbUR = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudGrassProbLR = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label63 = New Global.System.Windows.Forms.Label()
            Me.Label64 = New Global.System.Windows.Forms.Label()
            Me.Label65 = New Global.System.Windows.Forms.Label()
            Me.Label66 = New Global.System.Windows.Forms.Label()
            Me.Label67 = New Global.System.Windows.Forms.Label()
            Me.lblTotalGrassProbability = New Global.System.Windows.Forms.Label()
            Me.Label69 = New Global.System.Windows.Forms.Label()
            Me.Label70 = New Global.System.Windows.Forms.Label()
            Me.Label71 = New Global.System.Windows.Forms.Label()
            Me.Label72 = New Global.System.Windows.Forms.Label()
            Me.Label68 = New Global.System.Windows.Forms.Label()
            Me.nudGrassQuadSize = New Global.System.Windows.Forms.NumericUpDown()
            Me.tabpagAreaAudio = New Global.System.Windows.Forms.TabPage()
            Me.trkbarAmbientSndNightVol = New Global.System.Windows.Forms.TrackBar()
            Me.trkbarAmbientSndDayVol = New Global.System.Windows.Forms.TrackBar()
            Me.Label52 = New Global.System.Windows.Forms.Label()
            Me.nudMusicDelay = New Global.System.Windows.Forms.NumericUpDown()
            Me.cmbxMusicNight = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxMusicDay = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxMusicBattle = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxEnvAudio = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxAmbientSndNight = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxAmbientSndDay = New Global.System.Windows.Forms.ComboBox()
            Me.Label53 = New Global.System.Windows.Forms.Label()
            Me.Label54 = New Global.System.Windows.Forms.Label()
            Me.Label55 = New Global.System.Windows.Forms.Label()
            Me.Label56 = New Global.System.Windows.Forms.Label()
            Me.Label57 = New Global.System.Windows.Forms.Label()
            Me.Label58 = New Global.System.Windows.Forms.Label()
            Me.Label59 = New Global.System.Windows.Forms.Label()
            Me.Label60 = New Global.System.Windows.Forms.Label()
            Me.Label61 = New Global.System.Windows.Forms.Label()
            Me.tabpagArea_Events = New Global.System.Windows.Forms.TabPage()
            Me.Label77 = New Global.System.Windows.Forms.Label()
            Me.tbArea_OnUserDefined = New Global.System.Windows.Forms.TextBox()
            Me.tbArea_OnHeartbeat = New Global.System.Windows.Forms.TextBox()
            Me.Label76 = New Global.System.Windows.Forms.Label()
            Me.Label74 = New Global.System.Windows.Forms.Label()
            Me.tbArea_OnEnter = New Global.System.Windows.Forms.TextBox()
            Me.Label75 = New Global.System.Windows.Forms.Label()
            Me.tbArea_OnExit = New Global.System.Windows.Forms.TextBox()
            Me.tabpagAreaRooms = New Global.System.Windows.Forms.TabPage()
            Me.lbRooms = New Global.System.Windows.Forms.ListBox()
            Me.Label82 = New Global.System.Windows.Forms.Label()
            Me.chkbRoomDisableWeather = New Global.System.Windows.Forms.CheckBox()
            Me.nudRoomAmbientScale = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label80 = New Global.System.Windows.Forms.Label()
            Me.cmbxRoomEnvAudio = New Global.System.Windows.Forms.ComboBox()
            Me.Label79 = New Global.System.Windows.Forms.Label()
            Me.Label78 = New Global.System.Windows.Forms.Label()
            Me.tbRoomName = New Global.System.Windows.Forms.TextBox()
            Me.nudRoomForceRating = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label81 = New Global.System.Windows.Forms.Label()
            Me.Label83 = New Global.System.Windows.Forms.Label()
            Me.ColorDialog1 = New Global.System.Windows.Forms.ColorDialog()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.TabControlModule.SuspendLayout()
            Me.tabpagModuleBasic.SuspendLayout()
            CType(Me.nudXY, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudModEntryX, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudModEntryY, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudModEntryZ, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagModuleAdvanced.SuspendLayout()
            CType(Me.nudXPScale, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarXPScale, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMinutesPerHour, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDawnStartHour, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDuskStartHour, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStartHour, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStartDay, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStartMonth, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStartYear, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagModuleEvents.SuspendLayout()
            Me.tabpagModuleDescription.SuspendLayout()
            Me.TabControlMain.SuspendLayout()
            Me.TabPage5.SuspendLayout()
            Me.TabPage6.SuspendLayout()
            Me.TabControlArea.SuspendLayout()
            Me.tabpagAreaBasic.SuspendLayout()
            CType(Me.NumericUpDown10, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NumericUpDown11, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NumericUpDown12, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAreaEnvironment.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.nudChanceSnow, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudChanceRain, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudChanceLightning, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbMoon.SuspendLayout()
            CType(Me.trkbarMoonFogNear, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarMoonFogFar, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbSun.SuspendLayout()
            CType(Me.trkbarSunFogNear, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarSunFogFar, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudShadowOpacity, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAreaGrass.SuspendLayout()
            CType(Me.nudGrassDensity, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarGrassDensityX10, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassProbUL, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassProbLL, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassProbUR, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassProbLR, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassQuadSize, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAreaAudio.SuspendLayout()
            CType(Me.trkbarAmbientSndNightVol, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarAmbientSndDayVol, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMusicDelay, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagArea_Events.SuspendLayout()
            Me.tabpagAreaRooms.SuspendLayout()
            CType(Me.nudRoomAmbientScale, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRoomForceRating, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.TabControlModule.Controls.Add(Me.tabpagModuleBasic)
            Me.TabControlModule.Controls.Add(Me.tabpagModuleAdvanced)
            Me.TabControlModule.Controls.Add(Me.tabpagModuleEvents)
            Me.TabControlModule.Controls.Add(Me.tabpagModuleDescription)
            Me.TabControlModule.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Dim tabControlModule As Global.System.Windows.Forms.Control = Me.TabControlModule
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
            tabControlModule.Location = point
            Me.TabControlModule.Name = "TabControlModule"
            Dim tabControlModule2 As Global.System.Windows.Forms.TabControl = Me.TabControlModule
            point = New Global.System.Drawing.Point(12, 3)
            tabControlModule2.Padding = point
            Me.TabControlModule.SelectedIndex = 0
            Dim tabControlModule3 As Global.System.Windows.Forms.Control = Me.TabControlModule
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(488, 470)
            tabControlModule3.Size = size
            Me.TabControlModule.TabIndex = 0
            Me.tabpagModuleBasic.Controls.Add(Me.pboxXY)
            Me.tabpagModuleBasic.Controls.Add(Me.nudXY)
            Me.tabpagModuleBasic.Controls.Add(Me.lblBearing)
            Me.tabpagModuleBasic.Controls.Add(Me.Label11)
            Me.tabpagModuleBasic.Controls.Add(Me.nudModEntryX)
            Me.tabpagModuleBasic.Controls.Add(Me.Label12)
            Me.tabpagModuleBasic.Controls.Add(Me.nudModEntryY)
            Me.tabpagModuleBasic.Controls.Add(Me.Label13)
            Me.tabpagModuleBasic.Controls.Add(Me.nudModEntryZ)
            Me.tabpagModuleBasic.Controls.Add(Me.btnSetModNameLang)
            Me.tabpagModuleBasic.Controls.Add(Me.tbModTag)
            Me.tabpagModuleBasic.Controls.Add(Me.tbModName)
            Me.tabpagModuleBasic.Controls.Add(Me.Label8)
            Me.tabpagModuleBasic.Controls.Add(Me.Label9)
            Me.tabpagModuleBasic.Controls.Add(Me.tbModEntryArea)
            Me.tabpagModuleBasic.Controls.Add(Me.Label10)
            Dim tabpagModuleBasic As Global.System.Windows.Forms.Control = Me.tabpagModuleBasic
            point = New Global.System.Drawing.Point(4, 22)
            tabpagModuleBasic.Location = point
            Me.tabpagModuleBasic.Name = "tabpagModuleBasic"
            Dim tabpagModuleBasic2 As Global.System.Windows.Forms.Control = Me.tabpagModuleBasic
            size = New Global.System.Drawing.Size(480, 444)
            tabpagModuleBasic2.Size = size
            Me.tabpagModuleBasic.TabIndex = 0
            Me.tabpagModuleBasic.Text = "Basic"
            Dim pboxXY As Global.System.Windows.Forms.Control = Me.pboxXY
            point = New Global.System.Drawing.Point(312, 152)
            pboxXY.Location = point
            Me.pboxXY.Name = "pboxXY"
            Dim pboxXY2 As Global.System.Windows.Forms.Control = Me.pboxXY
            size = New Global.System.Drawing.Size(50, 50)
            pboxXY2.Size = size
            Me.pboxXY.TabIndex = 22
            Me.pboxXY.TabStop = False
            Me.nudXY.DecimalPlaces = 2
            Dim nudXY As Global.System.Windows.Forms.Control = Me.nudXY
            point = New Global.System.Drawing.Point(304, 208)
            nudXY.Location = point
            Dim nudXY2 As Global.System.Windows.Forms.NumericUpDown = Me.nudXY
            Dim num As Decimal = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            nudXY2.Maximum = num
            Me.nudXY.Name = "nudXY"
            Dim nudXY3 As Global.System.Windows.Forms.Control = Me.nudXY
            size = New Global.System.Drawing.Size(64, 20)
            nudXY3.Size = size
            Me.nudXY.TabIndex = 23
            Me.nudXY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
            Dim lblBearing As Global.System.Windows.Forms.Control = Me.lblBearing
            point = New Global.System.Drawing.Point(312, 128)
            lblBearing.Location = point
            Me.lblBearing.Name = "lblBearing"
            Dim lblBearing2 As Global.System.Windows.Forms.Control = Me.lblBearing
            size = New Global.System.Drawing.Size(48, 16)
            lblBearing2.Size = size
            Me.lblBearing.TabIndex = 21
            Me.lblBearing.Text = "Bearing"
            Me.lblBearing.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Dim label As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(24, 144)
            label.Location = point
            Me.Label11.Name = "Label11"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(104, 16)
            label2.Size = size
            Me.Label11.TabIndex = 19
            Me.Label11.Text = "Starting Position X"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudModEntryX.DecimalPlaces = 4
            Dim nudModEntryX As Global.System.Windows.Forms.Control = Me.nudModEntryX
            point = New Global.System.Drawing.Point(144, 144)
            nudModEntryX.Location = point
            Dim nudModEntryX2 As Global.System.Windows.Forms.NumericUpDown = Me.nudModEntryX
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            nudModEntryX2.Maximum = num
            Dim nudModEntryX3 As Global.System.Windows.Forms.NumericUpDown = Me.nudModEntryX
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            nudModEntryX3.Minimum = num
            Me.nudModEntryX.Name = "nudModEntryX"
            Dim nudModEntryX4 As Global.System.Windows.Forms.Control = Me.nudModEntryX
            size = New Global.System.Drawing.Size(96, 20)
            nudModEntryX4.Size = size
            Me.nudModEntryX.TabIndex = 4
            Me.nudModEntryX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(24, 176)
            label3.Location = point
            Me.Label12.Name = "Label12"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(104, 16)
            label4.Size = size
            Me.Label12.TabIndex = 20
            Me.Label12.Text = "Starting Position Y"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudModEntryY.DecimalPlaces = 4
            Dim nudModEntryY As Global.System.Windows.Forms.Control = Me.nudModEntryY
            point = New Global.System.Drawing.Point(144, 176)
            nudModEntryY.Location = point
            Dim nudModEntryY2 As Global.System.Windows.Forms.NumericUpDown = Me.nudModEntryY
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            nudModEntryY2.Maximum = num
            Dim nudModEntryY3 As Global.System.Windows.Forms.NumericUpDown = Me.nudModEntryY
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            nudModEntryY3.Minimum = num
            Me.nudModEntryY.Name = "nudModEntryY"
            Dim nudModEntryY4 As Global.System.Windows.Forms.Control = Me.nudModEntryY
            size = New Global.System.Drawing.Size(96, 20)
            nudModEntryY4.Size = size
            Me.nudModEntryY.TabIndex = 5
            Me.nudModEntryY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label13
            point = New Global.System.Drawing.Point(24, 208)
            label5.Location = point
            Me.Label13.Name = "Label13"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label13
            size = New Global.System.Drawing.Size(104, 16)
            label6.Size = size
            Me.Label13.TabIndex = 18
            Me.Label13.Text = "Starting Position Z"
            Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudModEntryZ.DecimalPlaces = 4
            Dim nudModEntryZ As Global.System.Windows.Forms.Control = Me.nudModEntryZ
            point = New Global.System.Drawing.Point(144, 208)
            nudModEntryZ.Location = point
            Dim nudModEntryZ2 As Global.System.Windows.Forms.NumericUpDown = Me.nudModEntryZ
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            nudModEntryZ2.Maximum = num
            Dim nudModEntryZ3 As Global.System.Windows.Forms.NumericUpDown = Me.nudModEntryZ
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            nudModEntryZ3.Minimum = num
            Me.nudModEntryZ.Name = "nudModEntryZ"
            Dim nudModEntryZ4 As Global.System.Windows.Forms.Control = Me.nudModEntryZ
            size = New Global.System.Drawing.Size(96, 20)
            nudModEntryZ4.Size = size
            Me.nudModEntryZ.TabIndex = 6
            Me.nudModEntryZ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim btnSetModNameLang As Global.System.Windows.Forms.Control = Me.btnSetModNameLang
            point = New Global.System.Drawing.Point(296, 40)
            btnSetModNameLang.Location = point
            Me.btnSetModNameLang.Name = "btnSetModNameLang"
            Dim btnSetModNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetModNameLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetModNameLang2.Size = size
            Me.btnSetModNameLang.TabIndex = 1
            Me.btnSetModNameLang.Text = "Set Language"
            Dim tbModTag As Global.System.Windows.Forms.Control = Me.tbModTag
            point = New Global.System.Drawing.Point(112, 64)
            tbModTag.Location = point
            Me.tbModTag.Name = "tbModTag"
            Dim tbModTag2 As Global.System.Windows.Forms.Control = Me.tbModTag
            size = New Global.System.Drawing.Size(88, 20)
            tbModTag2.Size = size
            Me.tbModTag.TabIndex = 2
            Me.tbModTag.Text = ""
            Dim tbModName As Global.System.Windows.Forms.Control = Me.tbModName
            point = New Global.System.Drawing.Point(112, 40)
            tbModName.Location = point
            Me.tbModName.Name = "tbModName"
            Dim tbModName2 As Global.System.Windows.Forms.Control = Me.tbModName
            size = New Global.System.Drawing.Size(176, 20)
            tbModName2.Size = size
            Me.tbModName.TabIndex = 0
            Me.tbModName.Text = ""
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(24, 40)
            label7.Location = point
            Me.Label8.Name = "Label8"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(48, 16)
            label8.Size = size
            Me.Label8.TabIndex = 10
            Me.Label8.Text = "Name"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(24, 64)
            label9.Location = point
            Me.Label9.Name = "Label9"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(48, 16)
            label10.Size = size
            Me.Label9.TabIndex = 11
            Me.Label9.Text = "Tag"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbModEntryArea As Global.System.Windows.Forms.Control = Me.tbModEntryArea
            point = New Global.System.Drawing.Point(112, 104)
            tbModEntryArea.Location = point
            Me.tbModEntryArea.Name = "tbModEntryArea"
            Dim tbModEntryArea2 As Global.System.Windows.Forms.Control = Me.tbModEntryArea
            size = New Global.System.Drawing.Size(176, 20)
            tbModEntryArea2.Size = size
            Me.tbModEntryArea.TabIndex = 3
            Me.tbModEntryArea.Text = ""
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(16, 104)
            label11.Location = point
            Me.Label10.Name = "Label10"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(56, 16)
            label12.Size = size
            Me.Label10.TabIndex = 10
            Me.Label10.Text = "Start Area"
            Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tabpagModuleAdvanced.Controls.Add(Me.nudXPScale)
            Me.tabpagModuleAdvanced.Controls.Add(Me.trkbarXPScale)
            Me.tabpagModuleAdvanced.Controls.Add(Me.Label46)
            Me.tabpagModuleAdvanced.Controls.Add(Me.nudMinutesPerHour)
            Me.tabpagModuleAdvanced.Controls.Add(Me.Label1)
            Me.tabpagModuleAdvanced.Controls.Add(Me.nudDawnStartHour)
            Me.tabpagModuleAdvanced.Controls.Add(Me.Label2)
            Me.tabpagModuleAdvanced.Controls.Add(Me.nudDuskStartHour)
            Me.tabpagModuleAdvanced.Controls.Add(Me.Label3)
            Me.tabpagModuleAdvanced.Controls.Add(Me.nudStartHour)
            Me.tabpagModuleAdvanced.Controls.Add(Me.Label4)
            Me.tabpagModuleAdvanced.Controls.Add(Me.nudStartDay)
            Me.tabpagModuleAdvanced.Controls.Add(Me.Label5)
            Me.tabpagModuleAdvanced.Controls.Add(Me.nudStartMonth)
            Me.tabpagModuleAdvanced.Controls.Add(Me.Label6)
            Me.tabpagModuleAdvanced.Controls.Add(Me.nudStartYear)
            Me.tabpagModuleAdvanced.Controls.Add(Me.Label7)
            Dim tabpagModuleAdvanced As Global.System.Windows.Forms.Control = Me.tabpagModuleAdvanced
            point = New Global.System.Drawing.Point(4, 22)
            tabpagModuleAdvanced.Location = point
            Me.tabpagModuleAdvanced.Name = "tabpagModuleAdvanced"
            Dim tabpagModuleAdvanced2 As Global.System.Windows.Forms.Control = Me.tabpagModuleAdvanced
            size = New Global.System.Drawing.Size(480, 444)
            tabpagModuleAdvanced2.Size = size
            Me.tabpagModuleAdvanced.TabIndex = 2
            Me.tabpagModuleAdvanced.Text = "Advanced"
            Dim nudXPScale As Global.System.Windows.Forms.Control = Me.nudXPScale
            point = New Global.System.Drawing.Point(336, 272)
            nudXPScale.Location = point
            Dim nudXPScale2 As Global.System.Windows.Forms.NumericUpDown = Me.nudXPScale
            num = New Decimal(New Integer() {200, 0, 0, 0})
            nudXPScale2.Maximum = num
            Me.nudXPScale.Name = "nudXPScale"
            Me.nudXPScale.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudXPScale3 As Global.System.Windows.Forms.Control = Me.nudXPScale
            size = New Global.System.Drawing.Size(42, 20)
            nudXPScale3.Size = size
            Me.nudXPScale.TabIndex = 8
            Me.nudXPScale.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim trkbarXPScale As Global.System.Windows.Forms.Control = Me.trkbarXPScale
            point = New Global.System.Drawing.Point(120, 264)
            trkbarXPScale.Location = point
            Me.trkbarXPScale.Maximum = 200
            Me.trkbarXPScale.Name = "trkbarXPScale"
            Dim trkbarXPScale2 As Global.System.Windows.Forms.Control = Me.trkbarXPScale
            size = New Global.System.Drawing.Size(216, 42)
            trkbarXPScale2.Size = size
            Me.trkbarXPScale.TabIndex = 7
            Me.trkbarXPScale.TickFrequency = 10
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label46
            point = New Global.System.Drawing.Point(24, 40)
            label13.Location = point
            Me.Label46.Name = "Label46"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label46
            size = New Global.System.Drawing.Size(88, 16)
            label14.Size = size
            Me.Label46.TabIndex = 5
            Me.Label46.Text = "Minutes/Hour"
            Me.Label46.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudMinutesPerHour As Global.System.Windows.Forms.Control = Me.nudMinutesPerHour
            point = New Global.System.Drawing.Point(128, 40)
            nudMinutesPerHour.Location = point
            Dim nudMinutesPerHour2 As Global.System.Windows.Forms.NumericUpDown = Me.nudMinutesPerHour
            num = New Decimal(New Integer() {60, 0, 0, 0})
            nudMinutesPerHour2.Maximum = num
            Dim nudMinutesPerHour3 As Global.System.Windows.Forms.NumericUpDown = Me.nudMinutesPerHour
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudMinutesPerHour3.Minimum = num
            Me.nudMinutesPerHour.Name = "nudMinutesPerHour"
            Dim nudMinutesPerHour4 As Global.System.Windows.Forms.Control = Me.nudMinutesPerHour
            size = New Global.System.Drawing.Size(48, 20)
            nudMinutesPerHour4.Size = size
            Me.nudMinutesPerHour.TabIndex = 0
            Me.nudMinutesPerHour.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudMinutesPerHour5 As Global.System.Windows.Forms.NumericUpDown = Me.nudMinutesPerHour
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudMinutesPerHour5.Value = num
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(24, 72)
            label15.Location = point
            Me.Label1.Name = "Label1"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(88, 16)
            label16.Size = size
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Dawn Start Hour"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudDawnStartHour As Global.System.Windows.Forms.Control = Me.nudDawnStartHour
            point = New Global.System.Drawing.Point(128, 72)
            nudDawnStartHour.Location = point
            Dim nudDawnStartHour2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDawnStartHour
            num = New Decimal(New Integer() {23, 0, 0, 0})
            nudDawnStartHour2.Maximum = num
            Me.nudDawnStartHour.Name = "nudDawnStartHour"
            Dim nudDawnStartHour3 As Global.System.Windows.Forms.Control = Me.nudDawnStartHour
            size = New Global.System.Drawing.Size(48, 20)
            nudDawnStartHour3.Size = size
            Me.nudDawnStartHour.TabIndex = 1
            Me.nudDawnStartHour.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(24, 104)
            label17.Location = point
            Me.Label2.Name = "Label2"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(88, 16)
            label18.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Dusk Start Hour"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudDuskStartHour As Global.System.Windows.Forms.Control = Me.nudDuskStartHour
            point = New Global.System.Drawing.Point(128, 104)
            nudDuskStartHour.Location = point
            Dim nudDuskStartHour2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDuskStartHour
            num = New Decimal(New Integer() {23, 0, 0, 0})
            nudDuskStartHour2.Maximum = num
            Me.nudDuskStartHour.Name = "nudDuskStartHour"
            Dim nudDuskStartHour3 As Global.System.Windows.Forms.Control = Me.nudDuskStartHour
            size = New Global.System.Drawing.Size(48, 20)
            nudDuskStartHour3.Size = size
            Me.nudDuskStartHour.TabIndex = 2
            Me.nudDuskStartHour.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(24, 200)
            label19.Location = point
            Me.Label3.Name = "Label3"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(80, 16)
            label20.Size = size
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Starting Month"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudStartHour As Global.System.Windows.Forms.Control = Me.nudStartHour
            point = New Global.System.Drawing.Point(128, 136)
            nudStartHour.Location = point
            Dim nudStartHour2 As Global.System.Windows.Forms.NumericUpDown = Me.nudStartHour
            num = New Decimal(New Integer() {23, 0, 0, 0})
            nudStartHour2.Maximum = num
            Me.nudStartHour.Name = "nudStartHour"
            Dim nudStartHour3 As Global.System.Windows.Forms.Control = Me.nudStartHour
            size = New Global.System.Drawing.Size(48, 20)
            nudStartHour3.Size = size
            Me.nudStartHour.TabIndex = 3
            Me.nudStartHour.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(24, 168)
            label21.Location = point
            Me.Label4.Name = "Label4"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(72, 16)
            label22.Size = size
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Starting Day"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudStartDay As Global.System.Windows.Forms.Control = Me.nudStartDay
            point = New Global.System.Drawing.Point(128, 168)
            nudStartDay.Location = point
            Dim nudStartDay2 As Global.System.Windows.Forms.NumericUpDown = Me.nudStartDay
            num = New Decimal(New Integer() {31, 0, 0, 0})
            nudStartDay2.Maximum = num
            Dim nudStartDay3 As Global.System.Windows.Forms.NumericUpDown = Me.nudStartDay
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudStartDay3.Minimum = num
            Me.nudStartDay.Name = "nudStartDay"
            Dim nudStartDay4 As Global.System.Windows.Forms.Control = Me.nudStartDay
            size = New Global.System.Drawing.Size(48, 20)
            nudStartDay4.Size = size
            Me.nudStartDay.TabIndex = 4
            Me.nudStartDay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudStartDay5 As Global.System.Windows.Forms.NumericUpDown = Me.nudStartDay
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudStartDay5.Value = num
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(24, 136)
            label23.Location = point
            Me.Label5.Name = "Label5"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(72, 16)
            label24.Size = size
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "Starting Hour"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudStartMonth As Global.System.Windows.Forms.Control = Me.nudStartMonth
            point = New Global.System.Drawing.Point(128, 200)
            nudStartMonth.Location = point
            Dim nudStartMonth2 As Global.System.Windows.Forms.NumericUpDown = Me.nudStartMonth
            num = New Decimal(New Integer() {12, 0, 0, 0})
            nudStartMonth2.Maximum = num
            Dim nudStartMonth3 As Global.System.Windows.Forms.NumericUpDown = Me.nudStartMonth
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudStartMonth3.Minimum = num
            Me.nudStartMonth.Name = "nudStartMonth"
            Dim nudStartMonth4 As Global.System.Windows.Forms.Control = Me.nudStartMonth
            size = New Global.System.Drawing.Size(48, 20)
            nudStartMonth4.Size = size
            Me.nudStartMonth.TabIndex = 5
            Me.nudStartMonth.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudStartMonth5 As Global.System.Windows.Forms.NumericUpDown = Me.nudStartMonth
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudStartMonth5.Value = num
            Dim label25 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(24, 232)
            label25.Location = point
            Me.Label6.Name = "Label6"
            Dim label26 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(72, 16)
            label26.Size = size
            Me.Label6.TabIndex = 5
            Me.Label6.Text = "Starting Year"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudStartYear As Global.System.Windows.Forms.Control = Me.nudStartYear
            point = New Global.System.Drawing.Point(128, 232)
            nudStartYear.Location = point
            Dim nudStartYear2 As Global.System.Windows.Forms.NumericUpDown = Me.nudStartYear
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            nudStartYear2.Maximum = num
            Me.nudStartYear.Name = "nudStartYear"
            Dim nudStartYear3 As Global.System.Windows.Forms.Control = Me.nudStartYear
            size = New Global.System.Drawing.Size(48, 20)
            nudStartYear3.Size = size
            Me.nudStartYear.TabIndex = 6
            Me.nudStartYear.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label27 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(24, 272)
            label27.Location = point
            Me.Label7.Name = "Label7"
            Dim label28 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(56, 16)
            label28.Size = size
            Me.Label7.TabIndex = 5
            Me.Label7.Text = "XP Scale"
            Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tabpagModuleEvents.Controls.Add(Me.Label34)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnClientEntr)
            Me.tabpagModuleEvents.Controls.Add(Me.Label33)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnActvtItem)
            Me.tabpagModuleEvents.Controls.Add(Me.Label32)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnAcquirItem)
            Me.tabpagModuleEvents.Controls.Add(Me.Label35)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnClientLeav)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnHeartbeat)
            Me.tabpagModuleEvents.Controls.Add(Me.Label36)
            Me.tabpagModuleEvents.Controls.Add(Me.Label37)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnModLoad)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnPlrDeath)
            Me.tabpagModuleEvents.Controls.Add(Me.Label38)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnPlrDying)
            Me.tabpagModuleEvents.Controls.Add(Me.Label39)
            Me.tabpagModuleEvents.Controls.Add(Me.Label40)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnPlrLvlUp)
            Me.tabpagModuleEvents.Controls.Add(Me.Label41)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnSpawnBtnDn)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnPlrRest)
            Me.tabpagModuleEvents.Controls.Add(Me.Label42)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnUnAqreItem)
            Me.tabpagModuleEvents.Controls.Add(Me.Label43)
            Me.tabpagModuleEvents.Controls.Add(Me.Label44)
            Me.tabpagModuleEvents.Controls.Add(Me.tbMod_OnUsrDefined)
            Dim tabpagModuleEvents As Global.System.Windows.Forms.Control = Me.tabpagModuleEvents
            point = New Global.System.Drawing.Point(4, 22)
            tabpagModuleEvents.Location = point
            Me.tabpagModuleEvents.Name = "tabpagModuleEvents"
            Dim tabpagModuleEvents2 As Global.System.Windows.Forms.Control = Me.tabpagModuleEvents
            size = New Global.System.Drawing.Size(480, 444)
            tabpagModuleEvents2.Size = size
            Me.tabpagModuleEvents.TabIndex = 1
            Me.tabpagModuleEvents.Text = "Events"
            Dim label29 As Global.System.Windows.Forms.Control = Me.Label34
            point = New Global.System.Drawing.Point(24, 88)
            label29.Location = point
            Me.Label34.Name = "Label34"
            Dim label30 As Global.System.Windows.Forms.Control = Me.Label34
            size = New Global.System.Drawing.Size(100, 18)
            label30.Size = size
            Me.Label34.TabIndex = 28
            Me.Label34.Text = "OnClientEnter"
            Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnClientEntr.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnClientEntr As Global.System.Windows.Forms.Control = Me.tbMod_OnClientEntr
            point = New Global.System.Drawing.Point(136, 88)
            tbMod_OnClientEntr.Location = point
            Me.tbMod_OnClientEntr.MaxLength = 16
            Me.tbMod_OnClientEntr.Name = "tbMod_OnClientEntr"
            Dim tbMod_OnClientEntr2 As Global.System.Windows.Forms.Control = Me.tbMod_OnClientEntr
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnClientEntr2.Size = size
            Me.tbMod_OnClientEntr.TabIndex = 2
            Me.tbMod_OnClientEntr.Text = ""
            Dim label31 As Global.System.Windows.Forms.Control = Me.Label33
            point = New Global.System.Drawing.Point(24, 64)
            label31.Location = point
            Me.Label33.Name = "Label33"
            Dim label32 As Global.System.Windows.Forms.Control = Me.Label33
            size = New Global.System.Drawing.Size(100, 18)
            label32.Size = size
            Me.Label33.TabIndex = 18
            Me.Label33.Text = "OnActivateItem"
            Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnActvtItem.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnActvtItem As Global.System.Windows.Forms.Control = Me.tbMod_OnActvtItem
            point = New Global.System.Drawing.Point(136, 64)
            tbMod_OnActvtItem.Location = point
            Me.tbMod_OnActvtItem.MaxLength = 16
            Me.tbMod_OnActvtItem.Name = "tbMod_OnActvtItem"
            Dim tbMod_OnActvtItem2 As Global.System.Windows.Forms.Control = Me.tbMod_OnActvtItem
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnActvtItem2.Size = size
            Me.tbMod_OnActvtItem.TabIndex = 1
            Me.tbMod_OnActvtItem.Text = ""
            Dim label33 As Global.System.Windows.Forms.Control = Me.Label32
            point = New Global.System.Drawing.Point(24, 40)
            label33.Location = point
            Me.Label32.Name = "Label32"
            Dim label34 As Global.System.Windows.Forms.Control = Me.Label32
            size = New Global.System.Drawing.Size(100, 18)
            label34.Size = size
            Me.Label32.TabIndex = 15
            Me.Label32.Text = "OnAcquireItem"
            Me.Label32.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnAcquirItem.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnAcquirItem As Global.System.Windows.Forms.Control = Me.tbMod_OnAcquirItem
            point = New Global.System.Drawing.Point(136, 40)
            tbMod_OnAcquirItem.Location = point
            Me.tbMod_OnAcquirItem.MaxLength = 16
            Me.tbMod_OnAcquirItem.Name = "tbMod_OnAcquirItem"
            Dim tbMod_OnAcquirItem2 As Global.System.Windows.Forms.Control = Me.tbMod_OnAcquirItem
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnAcquirItem2.Size = size
            Me.tbMod_OnAcquirItem.TabIndex = 0
            Me.tbMod_OnAcquirItem.Text = ""
            Dim label35 As Global.System.Windows.Forms.Control = Me.Label35
            point = New Global.System.Drawing.Point(24, 112)
            label35.Location = point
            Me.Label35.Name = "Label35"
            Dim label36 As Global.System.Windows.Forms.Control = Me.Label35
            size = New Global.System.Drawing.Size(100, 18)
            label36.Size = size
            Me.Label35.TabIndex = 27
            Me.Label35.Text = "OnClientLeave"
            Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnClientLeav.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnClientLeav As Global.System.Windows.Forms.Control = Me.tbMod_OnClientLeav
            point = New Global.System.Drawing.Point(136, 112)
            tbMod_OnClientLeav.Location = point
            Me.tbMod_OnClientLeav.MaxLength = 16
            Me.tbMod_OnClientLeav.Name = "tbMod_OnClientLeav"
            Dim tbMod_OnClientLeav2 As Global.System.Windows.Forms.Control = Me.tbMod_OnClientLeav
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnClientLeav2.Size = size
            Me.tbMod_OnClientLeav.TabIndex = 3
            Me.tbMod_OnClientLeav.Text = ""
            Me.tbMod_OnHeartbeat.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnHeartbeat As Global.System.Windows.Forms.Control = Me.tbMod_OnHeartbeat
            point = New Global.System.Drawing.Point(136, 136)
            tbMod_OnHeartbeat.Location = point
            Me.tbMod_OnHeartbeat.MaxLength = 16
            Me.tbMod_OnHeartbeat.Name = "tbMod_OnHeartbeat"
            Dim tbMod_OnHeartbeat2 As Global.System.Windows.Forms.Control = Me.tbMod_OnHeartbeat
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnHeartbeat2.Size = size
            Me.tbMod_OnHeartbeat.TabIndex = 4
            Me.tbMod_OnHeartbeat.Text = ""
            Dim label37 As Global.System.Windows.Forms.Control = Me.Label36
            point = New Global.System.Drawing.Point(24, 136)
            label37.Location = point
            Me.Label36.Name = "Label36"
            Dim label38 As Global.System.Windows.Forms.Control = Me.Label36
            size = New Global.System.Drawing.Size(100, 18)
            label38.Size = size
            Me.Label36.TabIndex = 26
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label39 As Global.System.Windows.Forms.Control = Me.Label37
            point = New Global.System.Drawing.Point(24, 160)
            label39.Location = point
            Me.Label37.Name = "Label37"
            Dim label40 As Global.System.Windows.Forms.Control = Me.Label37
            size = New Global.System.Drawing.Size(100, 18)
            label40.Size = size
            Me.Label37.TabIndex = 31
            Me.Label37.Text = "OnModuleLoad"
            Me.Label37.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnModLoad.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnModLoad As Global.System.Windows.Forms.Control = Me.tbMod_OnModLoad
            point = New Global.System.Drawing.Point(136, 160)
            tbMod_OnModLoad.Location = point
            Me.tbMod_OnModLoad.MaxLength = 16
            Me.tbMod_OnModLoad.Name = "tbMod_OnModLoad"
            Dim tbMod_OnModLoad2 As Global.System.Windows.Forms.Control = Me.tbMod_OnModLoad
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnModLoad2.Size = size
            Me.tbMod_OnModLoad.TabIndex = 5
            Me.tbMod_OnModLoad.Text = ""
            Me.tbMod_OnPlrDeath.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnPlrDeath As Global.System.Windows.Forms.Control = Me.tbMod_OnPlrDeath
            point = New Global.System.Drawing.Point(136, 184)
            tbMod_OnPlrDeath.Location = point
            Me.tbMod_OnPlrDeath.MaxLength = 16
            Me.tbMod_OnPlrDeath.Name = "tbMod_OnPlrDeath"
            Dim tbMod_OnPlrDeath2 As Global.System.Windows.Forms.Control = Me.tbMod_OnPlrDeath
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnPlrDeath2.Size = size
            Me.tbMod_OnPlrDeath.TabIndex = 6
            Me.tbMod_OnPlrDeath.Text = ""
            Dim label41 As Global.System.Windows.Forms.Control = Me.Label38
            point = New Global.System.Drawing.Point(24, 184)
            label41.Location = point
            Me.Label38.Name = "Label38"
            Dim label42 As Global.System.Windows.Forms.Control = Me.Label38
            size = New Global.System.Drawing.Size(100, 18)
            label42.Size = size
            Me.Label38.TabIndex = 21
            Me.Label38.Text = "OnPlayerDeath"
            Me.Label38.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnPlrDying.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnPlrDying As Global.System.Windows.Forms.Control = Me.tbMod_OnPlrDying
            point = New Global.System.Drawing.Point(136, 208)
            tbMod_OnPlrDying.Location = point
            Me.tbMod_OnPlrDying.MaxLength = 16
            Me.tbMod_OnPlrDying.Name = "tbMod_OnPlrDying"
            Dim tbMod_OnPlrDying2 As Global.System.Windows.Forms.Control = Me.tbMod_OnPlrDying
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnPlrDying2.Size = size
            Me.tbMod_OnPlrDying.TabIndex = 7
            Me.tbMod_OnPlrDying.Text = ""
            Dim label43 As Global.System.Windows.Forms.Control = Me.Label39
            point = New Global.System.Drawing.Point(24, 208)
            label43.Location = point
            Me.Label39.Name = "Label39"
            Dim label44 As Global.System.Windows.Forms.Control = Me.Label39
            size = New Global.System.Drawing.Size(100, 18)
            label44.Size = size
            Me.Label39.TabIndex = 20
            Me.Label39.Text = "OnPlayerDying"
            Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label45 As Global.System.Windows.Forms.Control = Me.Label40
            point = New Global.System.Drawing.Point(24, 232)
            label45.Location = point
            Me.Label40.Name = "Label40"
            Dim label46 As Global.System.Windows.Forms.Control = Me.Label40
            size = New Global.System.Drawing.Size(100, 18)
            label46.Size = size
            Me.Label40.TabIndex = 25
            Me.Label40.Text = "OnPlayerLevelUp"
            Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnPlrLvlUp.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnPlrLvlUp As Global.System.Windows.Forms.Control = Me.tbMod_OnPlrLvlUp
            point = New Global.System.Drawing.Point(136, 232)
            tbMod_OnPlrLvlUp.Location = point
            Me.tbMod_OnPlrLvlUp.MaxLength = 16
            Me.tbMod_OnPlrLvlUp.Name = "tbMod_OnPlrLvlUp"
            Dim tbMod_OnPlrLvlUp2 As Global.System.Windows.Forms.Control = Me.tbMod_OnPlrLvlUp
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnPlrLvlUp2.Size = size
            Me.tbMod_OnPlrLvlUp.TabIndex = 8
            Me.tbMod_OnPlrLvlUp.Text = ""
            Dim label47 As Global.System.Windows.Forms.Control = Me.Label41
            point = New Global.System.Drawing.Point(24, 256)
            label47.Location = point
            Me.Label41.Name = "Label41"
            Dim label48 As Global.System.Windows.Forms.Control = Me.Label41
            size = New Global.System.Drawing.Size(100, 18)
            label48.Size = size
            Me.Label41.TabIndex = 23
            Me.Label41.Text = "OnPlayerRespawn"
            Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnSpawnBtnDn.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnSpawnBtnDn As Global.System.Windows.Forms.Control = Me.tbMod_OnSpawnBtnDn
            point = New Global.System.Drawing.Point(136, 256)
            tbMod_OnSpawnBtnDn.Location = point
            Me.tbMod_OnSpawnBtnDn.MaxLength = 16
            Me.tbMod_OnSpawnBtnDn.Name = "tbMod_OnSpawnBtnDn"
            Dim tbMod_OnSpawnBtnDn2 As Global.System.Windows.Forms.Control = Me.tbMod_OnSpawnBtnDn
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnSpawnBtnDn2.Size = size
            Me.tbMod_OnSpawnBtnDn.TabIndex = 9
            Me.tbMod_OnSpawnBtnDn.Text = ""
            Me.tbMod_OnPlrRest.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnPlrRest As Global.System.Windows.Forms.Control = Me.tbMod_OnPlrRest
            point = New Global.System.Drawing.Point(136, 280)
            tbMod_OnPlrRest.Location = point
            Me.tbMod_OnPlrRest.MaxLength = 16
            Me.tbMod_OnPlrRest.Name = "tbMod_OnPlrRest"
            Dim tbMod_OnPlrRest2 As Global.System.Windows.Forms.Control = Me.tbMod_OnPlrRest
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnPlrRest2.Size = size
            Me.tbMod_OnPlrRest.TabIndex = 10
            Me.tbMod_OnPlrRest.Text = ""
            Dim label49 As Global.System.Windows.Forms.Control = Me.Label42
            point = New Global.System.Drawing.Point(24, 280)
            label49.Location = point
            Me.Label42.Name = "Label42"
            Dim label50 As Global.System.Windows.Forms.Control = Me.Label42
            size = New Global.System.Drawing.Size(100, 18)
            label50.Size = size
            Me.Label42.TabIndex = 24
            Me.Label42.Text = "OnPlayerRest"
            Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnUnAqreItem.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnUnAqreItem As Global.System.Windows.Forms.Control = Me.tbMod_OnUnAqreItem
            point = New Global.System.Drawing.Point(136, 304)
            tbMod_OnUnAqreItem.Location = point
            Me.tbMod_OnUnAqreItem.MaxLength = 16
            Me.tbMod_OnUnAqreItem.Name = "tbMod_OnUnAqreItem"
            Dim tbMod_OnUnAqreItem2 As Global.System.Windows.Forms.Control = Me.tbMod_OnUnAqreItem
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnUnAqreItem2.Size = size
            Me.tbMod_OnUnAqreItem.TabIndex = 11
            Me.tbMod_OnUnAqreItem.Text = ""
            Dim label51 As Global.System.Windows.Forms.Control = Me.Label43
            point = New Global.System.Drawing.Point(24, 304)
            label51.Location = point
            Me.Label43.Name = "Label43"
            Dim label52 As Global.System.Windows.Forms.Control = Me.Label43
            size = New Global.System.Drawing.Size(100, 18)
            label52.Size = size
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUnacquireItem"
            Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label53 As Global.System.Windows.Forms.Control = Me.Label44
            point = New Global.System.Drawing.Point(24, 328)
            label53.Location = point
            Me.Label44.Name = "Label44"
            Dim label54 As Global.System.Windows.Forms.Control = Me.Label44
            size = New Global.System.Drawing.Size(100, 18)
            label54.Size = size
            Me.Label44.TabIndex = 29
            Me.Label44.Text = "OnUserDefined"
            Me.Label44.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnUsrDefined.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbMod_OnUsrDefined As Global.System.Windows.Forms.Control = Me.tbMod_OnUsrDefined
            point = New Global.System.Drawing.Point(136, 328)
            tbMod_OnUsrDefined.Location = point
            Me.tbMod_OnUsrDefined.MaxLength = 16
            Me.tbMod_OnUsrDefined.Name = "tbMod_OnUsrDefined"
            Dim tbMod_OnUsrDefined2 As Global.System.Windows.Forms.Control = Me.tbMod_OnUsrDefined
            size = New Global.System.Drawing.Size(204, 20)
            tbMod_OnUsrDefined2.Size = size
            Me.tbMod_OnUsrDefined.TabIndex = 12
            Me.tbMod_OnUsrDefined.Text = ""
            Me.tabpagModuleDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.tabpagModuleDescription.Controls.Add(Me.tbModDescription)
            Dim tabpagModuleDescription As Global.System.Windows.Forms.Control = Me.tabpagModuleDescription
            point = New Global.System.Drawing.Point(4, 22)
            tabpagModuleDescription.Location = point
            Me.tabpagModuleDescription.Name = "tabpagModuleDescription"
            Dim tabpagModuleDescription2 As Global.System.Windows.Forms.Control = Me.tabpagModuleDescription
            size = New Global.System.Drawing.Size(480, 444)
            tabpagModuleDescription2.Size = size
            Me.tabpagModuleDescription.TabIndex = 3
            Me.tabpagModuleDescription.Text = "Description"
            Me.btnSetDescriptionLang.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSetDescriptionLang As Global.System.Windows.Forms.Control = Me.btnSetDescriptionLang
            point = New Global.System.Drawing.Point(368, 414)
            btnSetDescriptionLang.Location = point
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Dim btnSetDescriptionLang2 As Global.System.Windows.Forms.Control = Me.btnSetDescriptionLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetDescriptionLang2.Size = size
            Me.btnSetDescriptionLang.TabIndex = 1
            Me.btnSetDescriptionLang.Text = "Set Language"
            Me.tbModDescription.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbModDescription As Global.System.Windows.Forms.Control = Me.tbModDescription
            point = New Global.System.Drawing.Point(16, 8)
            tbModDescription.Location = point
            Me.tbModDescription.Multiline = True
            Me.tbModDescription.Name = "tbModDescription"
            Dim tbModDescription2 As Global.System.Windows.Forms.Control = Me.tbModDescription
            size = New Global.System.Drawing.Size(448, 391)
            tbModDescription2.Size = size
            Me.tbModDescription.TabIndex = 0
            Me.tbModDescription.Text = ""
            Me.TabControlMain.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControlMain.Controls.Add(Me.TabPage5)
            Me.TabControlMain.Controls.Add(Me.TabPage6)
            Dim tabControlMain As Global.System.Windows.Forms.Control = Me.TabControlMain
            point = New Global.System.Drawing.Point(16, 24)
            tabControlMain.Location = point
            Me.TabControlMain.Name = "TabControlMain"
            Dim tabControlMain2 As Global.System.Windows.Forms.TabControl = Me.TabControlMain
            point = New Global.System.Drawing.Point(12, 3)
            tabControlMain2.Padding = point
            Me.TabControlMain.SelectedIndex = 0
            Dim tabControlMain3 As Global.System.Windows.Forms.Control = Me.TabControlMain
            size = New Global.System.Drawing.Size(496, 496)
            tabControlMain3.Size = size
            Me.TabControlMain.TabIndex = 1
            Me.TabPage5.Controls.Add(Me.TabControlModule)
            Dim tabPage As Global.System.Windows.Forms.Control = Me.TabPage5
            point = New Global.System.Drawing.Point(4, 22)
            tabPage.Location = point
            Me.TabPage5.Name = "TabPage5"
            Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage5
            size = New Global.System.Drawing.Size(488, 470)
            tabPage2.Size = size
            Me.TabPage5.TabIndex = 0
            Me.TabPage5.Text = "Module"
            Me.TabPage6.Controls.Add(Me.TabControlArea)
            Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage6
            point = New Global.System.Drawing.Point(4, 22)
            tabPage3.Location = point
            Me.TabPage6.Name = "TabPage6"
            Dim tabPage4 As Global.System.Windows.Forms.Control = Me.TabPage6
            size = New Global.System.Drawing.Size(488, 470)
            tabPage4.Size = size
            Me.TabPage6.TabIndex = 1
            Me.TabPage6.Text = "Area"
            Me.TabControlArea.Controls.Add(Me.tabpagAreaBasic)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaEnvironment)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaGrass)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaAudio)
            Me.TabControlArea.Controls.Add(Me.tabpagArea_Events)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaRooms)
            Me.TabControlArea.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Dim tabControlArea As Global.System.Windows.Forms.Control = Me.TabControlArea
            point = New Global.System.Drawing.Point(0, 0)
            tabControlArea.Location = point
            Me.TabControlArea.Name = "TabControlArea"
            Dim tabControlArea2 As Global.System.Windows.Forms.TabControl = Me.TabControlArea
            point = New Global.System.Drawing.Point(12, 3)
            tabControlArea2.Padding = point
            Me.TabControlArea.SelectedIndex = 0
            Dim tabControlArea3 As Global.System.Windows.Forms.Control = Me.TabControlArea
            size = New Global.System.Drawing.Size(488, 470)
            tabControlArea3.Size = size
            Me.TabControlArea.TabIndex = 0
            Me.tabpagAreaBasic.Controls.Add(Me.chkbUnescapable)
            Me.tabpagAreaBasic.Controls.Add(Me.Label19)
            Me.tabpagAreaBasic.Controls.Add(Me.cmbxCameraStyle)
            Me.tabpagAreaBasic.Controls.Add(Me.Label14)
            Me.tabpagAreaBasic.Controls.Add(Me.NumericUpDown10)
            Me.tabpagAreaBasic.Controls.Add(Me.Label15)
            Me.tabpagAreaBasic.Controls.Add(Me.NumericUpDown11)
            Me.tabpagAreaBasic.Controls.Add(Me.Label16)
            Me.tabpagAreaBasic.Controls.Add(Me.NumericUpDown12)
            Me.tabpagAreaBasic.Controls.Add(Me.btnSetAreaNameLang)
            Me.tabpagAreaBasic.Controls.Add(Me.tbAreaTag)
            Me.tabpagAreaBasic.Controls.Add(Me.tbAreaName)
            Me.tabpagAreaBasic.Controls.Add(Me.Label17)
            Me.tabpagAreaBasic.Controls.Add(Me.Label18)
            Me.tabpagAreaBasic.Controls.Add(Me.Label85)
            Me.tabpagAreaBasic.Controls.Add(Me.chkbDisableTransit)
            Me.tabpagAreaBasic.Controls.Add(Me.Label86)
            Dim tabpagAreaBasic As Global.System.Windows.Forms.Control = Me.tabpagAreaBasic
            point = New Global.System.Drawing.Point(4, 22)
            tabpagAreaBasic.Location = point
            Me.tabpagAreaBasic.Name = "tabpagAreaBasic"
            Dim tabpagAreaBasic2 As Global.System.Windows.Forms.Control = Me.tabpagAreaBasic
            size = New Global.System.Drawing.Size(480, 444)
            tabpagAreaBasic2.Size = size
            Me.tabpagAreaBasic.TabIndex = 1
            Me.tabpagAreaBasic.Text = "Basic"
            Dim chkbUnescapable As Global.System.Windows.Forms.Control = Me.chkbUnescapable
            point = New Global.System.Drawing.Point(112, 144)
            chkbUnescapable.Location = point
            Me.chkbUnescapable.Name = "chkbUnescapable"
            Dim chkbUnescapable2 As Global.System.Windows.Forms.Control = Me.chkbUnescapable
            size = New Global.System.Drawing.Size(32, 24)
            chkbUnescapable2.Size = size
            Me.chkbUnescapable.TabIndex = 23
            Dim label55 As Global.System.Windows.Forms.Control = Me.Label19
            point = New Global.System.Drawing.Point(16, 104)
            label55.Location = point
            Me.Label19.Name = "Label19"
            Dim label56 As Global.System.Windows.Forms.Control = Me.Label19
            size = New Global.System.Drawing.Size(88, 16)
            label56.Size = size
            Me.Label19.TabIndex = 22
            Me.Label19.Text = "Camera Style"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxCameraStyle.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxCameraStyle As Global.System.Windows.Forms.Control = Me.cmbxCameraStyle
            point = New Global.System.Drawing.Point(112, 104)
            cmbxCameraStyle.Location = point
            Me.cmbxCameraStyle.Name = "cmbxCameraStyle"
            Dim cmbxCameraStyle2 As Global.System.Windows.Forms.Control = Me.cmbxCameraStyle
            size = New Global.System.Drawing.Size(120, 21)
            cmbxCameraStyle2.Size = size
            Me.cmbxCameraStyle.TabIndex = 21
            Me.Label14.BackColor = Global.System.Drawing.Color.Red
            Dim label57 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(88, 328)
            label57.Location = point
            Me.Label14.Name = "Label14"
            Dim label58 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(104, 16)
            label58.Size = size
            Me.Label14.TabIndex = 19
            Me.Label14.Text = "Starting Position X"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label14.Visible = False
            Me.NumericUpDown10.BackColor = Global.System.Drawing.Color.Red
            Me.NumericUpDown10.DecimalPlaces = 4
            Dim numericUpDown As Global.System.Windows.Forms.Control = Me.NumericUpDown10
            point = New Global.System.Drawing.Point(208, 328)
            numericUpDown.Location = point
            Dim numericUpDown2 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown10
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            numericUpDown2.Maximum = num
            Dim numericUpDown3 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown10
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            numericUpDown3.Minimum = num
            Me.NumericUpDown10.Name = "NumericUpDown10"
            Dim numericUpDown4 As Global.System.Windows.Forms.Control = Me.NumericUpDown10
            size = New Global.System.Drawing.Size(96, 20)
            numericUpDown4.Size = size
            Me.NumericUpDown10.TabIndex = 16
            Me.NumericUpDown10.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown10.Visible = False
            Me.Label15.BackColor = Global.System.Drawing.Color.Red
            Dim label59 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(88, 360)
            label59.Location = point
            Me.Label15.Name = "Label15"
            Dim label60 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(104, 16)
            label60.Size = size
            Me.Label15.TabIndex = 20
            Me.Label15.Text = "Starting Position Y"
            Me.Label15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label15.Visible = False
            Me.NumericUpDown11.BackColor = Global.System.Drawing.Color.Red
            Me.NumericUpDown11.DecimalPlaces = 4
            Dim numericUpDown5 As Global.System.Windows.Forms.Control = Me.NumericUpDown11
            point = New Global.System.Drawing.Point(208, 360)
            numericUpDown5.Location = point
            Dim numericUpDown6 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown11
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            numericUpDown6.Maximum = num
            Dim numericUpDown7 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown11
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            numericUpDown7.Minimum = num
            Me.NumericUpDown11.Name = "NumericUpDown11"
            Dim numericUpDown8 As Global.System.Windows.Forms.Control = Me.NumericUpDown11
            size = New Global.System.Drawing.Size(96, 20)
            numericUpDown8.Size = size
            Me.NumericUpDown11.TabIndex = 15
            Me.NumericUpDown11.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown11.Visible = False
            Me.Label16.BackColor = Global.System.Drawing.Color.Red
            Dim label61 As Global.System.Windows.Forms.Control = Me.Label16
            point = New Global.System.Drawing.Point(88, 392)
            label61.Location = point
            Me.Label16.Name = "Label16"
            Dim label62 As Global.System.Windows.Forms.Control = Me.Label16
            size = New Global.System.Drawing.Size(104, 16)
            label62.Size = size
            Me.Label16.TabIndex = 18
            Me.Label16.Text = "Starting Position Z"
            Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label16.Visible = False
            Me.NumericUpDown12.BackColor = Global.System.Drawing.Color.Red
            Me.NumericUpDown12.DecimalPlaces = 4
            Dim numericUpDown9 As Global.System.Windows.Forms.Control = Me.NumericUpDown12
            point = New Global.System.Drawing.Point(208, 392)
            numericUpDown9.Location = point
            Dim numericUpDown10 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown12
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            numericUpDown10.Maximum = num
            Dim numericUpDown11 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown12
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            numericUpDown11.Minimum = num
            Me.NumericUpDown12.Name = "NumericUpDown12"
            Dim numericUpDown12 As Global.System.Windows.Forms.Control = Me.NumericUpDown12
            size = New Global.System.Drawing.Size(96, 20)
            numericUpDown12.Size = size
            Me.NumericUpDown12.TabIndex = 17
            Me.NumericUpDown12.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown12.Visible = False
            Dim btnSetAreaNameLang As Global.System.Windows.Forms.Control = Me.btnSetAreaNameLang
            point = New Global.System.Drawing.Point(376, 40)
            btnSetAreaNameLang.Location = point
            Me.btnSetAreaNameLang.Name = "btnSetAreaNameLang"
            Dim btnSetAreaNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetAreaNameLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetAreaNameLang2.Size = size
            Me.btnSetAreaNameLang.TabIndex = 1
            Me.btnSetAreaNameLang.Text = "Set Language"
            Dim tbAreaTag As Global.System.Windows.Forms.Control = Me.tbAreaTag
            point = New Global.System.Drawing.Point(112, 64)
            tbAreaTag.Location = point
            Me.tbAreaTag.Name = "tbAreaTag"
            Dim tbAreaTag2 As Global.System.Windows.Forms.Control = Me.tbAreaTag
            size = New Global.System.Drawing.Size(104, 20)
            tbAreaTag2.Size = size
            Me.tbAreaTag.TabIndex = 2
            Me.tbAreaTag.Text = ""
            Dim tbAreaName As Global.System.Windows.Forms.Control = Me.tbAreaName
            point = New Global.System.Drawing.Point(112, 40)
            tbAreaName.Location = point
            Me.tbAreaName.Name = "tbAreaName"
            Dim tbAreaName2 As Global.System.Windows.Forms.Control = Me.tbAreaName
            size = New Global.System.Drawing.Size(256, 20)
            tbAreaName2.Size = size
            Me.tbAreaName.TabIndex = 0
            Me.tbAreaName.Text = ""
            Dim label63 As Global.System.Windows.Forms.Control = Me.Label17
            point = New Global.System.Drawing.Point(24, 40)
            label63.Location = point
            Me.Label17.Name = "Label17"
            Dim label64 As Global.System.Windows.Forms.Control = Me.Label17
            size = New Global.System.Drawing.Size(48, 16)
            label64.Size = size
            Me.Label17.TabIndex = 10
            Me.Label17.Text = "Name"
            Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label65 As Global.System.Windows.Forms.Control = Me.Label18
            point = New Global.System.Drawing.Point(24, 64)
            label65.Location = point
            Me.Label18.Name = "Label18"
            Dim label66 As Global.System.Windows.Forms.Control = Me.Label18
            size = New Global.System.Drawing.Size(48, 16)
            label66.Size = size
            Me.Label18.TabIndex = 11
            Me.Label18.Text = "Tag"
            Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label67 As Global.System.Windows.Forms.Control = Me.Label85
            point = New Global.System.Drawing.Point(16, 148)
            label67.Location = point
            Me.Label85.Name = "Label85"
            Dim label68 As Global.System.Windows.Forms.Control = Me.Label85
            size = New Global.System.Drawing.Size(88, 16)
            label68.Size = size
            Me.Label85.TabIndex = 22
            Me.Label85.Text = "Unescapable"
            Me.Label85.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbDisableTransit As Global.System.Windows.Forms.Control = Me.chkbDisableTransit
            point = New Global.System.Drawing.Point(112, 176)
            chkbDisableTransit.Location = point
            Me.chkbDisableTransit.Name = "chkbDisableTransit"
            Dim chkbDisableTransit2 As Global.System.Windows.Forms.Control = Me.chkbDisableTransit
            size = New Global.System.Drawing.Size(32, 24)
            chkbDisableTransit2.Size = size
            Me.chkbDisableTransit.TabIndex = 23
            Dim label69 As Global.System.Windows.Forms.Control = Me.Label86
            point = New Global.System.Drawing.Point(16, 180)
            label69.Location = point
            Me.Label86.Name = "Label86"
            Dim label70 As Global.System.Windows.Forms.Control = Me.Label86
            size = New Global.System.Drawing.Size(88, 16)
            label70.Size = size
            Me.Label86.TabIndex = 22
            Me.Label86.Text = "Disable Transit"
            Me.Label86.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tabpagAreaEnvironment.Controls.Add(Me.cmbxWindPower)
            Me.tabpagAreaEnvironment.Controls.Add(Me.GroupBox1)
            Me.tabpagAreaEnvironment.Controls.Add(Me.rbDayNightCycle)
            Me.tabpagAreaEnvironment.Controls.Add(Me.gbMoon)
            Me.tabpagAreaEnvironment.Controls.Add(Me.gbSun)
            Me.tabpagAreaEnvironment.Controls.Add(Me.rbAlwaysDay)
            Me.tabpagAreaEnvironment.Controls.Add(Me.rbAlwaysNight)
            Me.tabpagAreaEnvironment.Controls.Add(Me.btnDynAmbientColor)
            Me.tabpagAreaEnvironment.Controls.Add(Me.Label48)
            Me.tabpagAreaEnvironment.Controls.Add(Me.Label73)
            Me.tabpagAreaEnvironment.Controls.Add(Me.nudShadowOpacity)
            Me.tabpagAreaEnvironment.Controls.Add(Me.Label84)
            Dim tabpagAreaEnvironment As Global.System.Windows.Forms.Control = Me.tabpagAreaEnvironment
            point = New Global.System.Drawing.Point(4, 22)
            tabpagAreaEnvironment.Location = point
            Me.tabpagAreaEnvironment.Name = "tabpagAreaEnvironment"
            Dim tabpagAreaEnvironment2 As Global.System.Windows.Forms.Control = Me.tabpagAreaEnvironment
            size = New Global.System.Drawing.Size(480, 444)
            tabpagAreaEnvironment2.Size = size
            Me.tabpagAreaEnvironment.TabIndex = 4
            Me.tabpagAreaEnvironment.Text = "Environment"
            Me.cmbxWindPower.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxWindPower.Items.AddRange(New Object() {"Calm", "Light", "Heavy"})
            Dim cmbxWindPower As Global.System.Windows.Forms.Control = Me.cmbxWindPower
            point = New Global.System.Drawing.Point(328, 358)
            cmbxWindPower.Location = point
            Me.cmbxWindPower.Name = "cmbxWindPower"
            Dim cmbxWindPower2 As Global.System.Windows.Forms.Control = Me.cmbxWindPower
            size = New Global.System.Drawing.Size(112, 21)
            cmbxWindPower2.Size = size
            Me.cmbxWindPower.TabIndex = 26
            Me.GroupBox1.Controls.Add(Me.Label49)
            Me.GroupBox1.Controls.Add(Me.nudChanceSnow)
            Me.GroupBox1.Controls.Add(Me.Label50)
            Me.GroupBox1.Controls.Add(Me.nudChanceRain)
            Me.GroupBox1.Controls.Add(Me.Label51)
            Me.GroupBox1.Controls.Add(Me.nudChanceLightning)
            Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
            point = New Global.System.Drawing.Point(16, 344)
            groupBox.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
            size = New Global.System.Drawing.Size(200, 88)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 25
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Weather"
            Dim label71 As Global.System.Windows.Forms.Control = Me.Label49
            point = New Global.System.Drawing.Point(8, 16)
            label71.Location = point
            Me.Label49.Name = "Label49"
            Dim label72 As Global.System.Windows.Forms.Control = Me.Label49
            size = New Global.System.Drawing.Size(88, 16)
            label72.Size = size
            Me.Label49.TabIndex = 24
            Me.Label49.Text = "% Chance Snow"
            Me.Label49.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudChanceSnow As Global.System.Windows.Forms.Control = Me.nudChanceSnow
            point = New Global.System.Drawing.Point(128, 16)
            nudChanceSnow.Location = point
            Me.nudChanceSnow.Name = "nudChanceSnow"
            Dim nudChanceSnow2 As Global.System.Windows.Forms.Control = Me.nudChanceSnow
            size = New Global.System.Drawing.Size(56, 20)
            nudChanceSnow2.Size = size
            Me.nudChanceSnow.TabIndex = 0
            Me.nudChanceSnow.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label73 As Global.System.Windows.Forms.Control = Me.Label50
            point = New Global.System.Drawing.Point(8, 40)
            label73.Location = point
            Me.Label50.Name = "Label50"
            Dim label74 As Global.System.Windows.Forms.Control = Me.Label50
            size = New Global.System.Drawing.Size(88, 16)
            label74.Size = size
            Me.Label50.TabIndex = 24
            Me.Label50.Text = "% Chance Rain"
            Me.Label50.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudChanceRain As Global.System.Windows.Forms.Control = Me.nudChanceRain
            point = New Global.System.Drawing.Point(128, 40)
            nudChanceRain.Location = point
            Me.nudChanceRain.Name = "nudChanceRain"
            Dim nudChanceRain2 As Global.System.Windows.Forms.Control = Me.nudChanceRain
            size = New Global.System.Drawing.Size(56, 20)
            nudChanceRain2.Size = size
            Me.nudChanceRain.TabIndex = 1
            Me.nudChanceRain.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label75 As Global.System.Windows.Forms.Control = Me.Label51
            point = New Global.System.Drawing.Point(8, 64)
            label75.Location = point
            Me.Label51.Name = "Label51"
            Dim label76 As Global.System.Windows.Forms.Control = Me.Label51
            size = New Global.System.Drawing.Size(120, 16)
            label76.Size = size
            Me.Label51.TabIndex = 24
            Me.Label51.Text = "% Chance Lightning"
            Me.Label51.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudChanceLightning As Global.System.Windows.Forms.Control = Me.nudChanceLightning
            point = New Global.System.Drawing.Point(128, 64)
            nudChanceLightning.Location = point
            Me.nudChanceLightning.Name = "nudChanceLightning"
            Dim nudChanceLightning2 As Global.System.Windows.Forms.Control = Me.nudChanceLightning
            size = New Global.System.Drawing.Size(56, 20)
            nudChanceLightning2.Size = size
            Me.nudChanceLightning.TabIndex = 2
            Me.nudChanceLightning.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.rbDayNightCycle.Checked = True
            Dim rbDayNightCycle As Global.System.Windows.Forms.Control = Me.rbDayNightCycle
            point = New Global.System.Drawing.Point(40, 8)
            rbDayNightCycle.Location = point
            Me.rbDayNightCycle.Name = "rbDayNightCycle"
            Dim rbDayNightCycle2 As Global.System.Windows.Forms.Control = Me.rbDayNightCycle
            size = New Global.System.Drawing.Size(152, 16)
            rbDayNightCycle2.Size = size
            Me.rbDayNightCycle.TabIndex = 0
            Me.rbDayNightCycle.TabStop = True
            Me.rbDayNightCycle.Text = "Cycle Day and Night"
            Me.gbMoon.Controls.Add(Me.btnMoonDiffuseColor)
            Me.gbMoon.Controls.Add(Me.Label24)
            Me.gbMoon.Controls.Add(Me.Label25)
            Me.gbMoon.Controls.Add(Me.btnMoonAmbientColor)
            Me.gbMoon.Controls.Add(Me.Label31)
            Me.gbMoon.Controls.Add(Me.Label45)
            Me.gbMoon.Controls.Add(Me.btnMoonFogColor)
            Me.gbMoon.Controls.Add(Me.chkbAreaMoonShadows)
            Me.gbMoon.Controls.Add(Me.Label47)
            Me.gbMoon.Controls.Add(Me.chkbMoonFogOn)
            Me.gbMoon.Controls.Add(Me.trkbarMoonFogNear)
            Me.gbMoon.Controls.Add(Me.lblMoonFogNear)
            Me.gbMoon.Controls.Add(Me.trkbarMoonFogFar)
            Me.gbMoon.Controls.Add(Me.lblMoonFogFar)
            Dim gbMoon As Global.System.Windows.Forms.Control = Me.gbMoon
            point = New Global.System.Drawing.Point(16, 200)
            gbMoon.Location = point
            Me.gbMoon.Name = "gbMoon"
            Dim gbMoon2 As Global.System.Windows.Forms.Control = Me.gbMoon
            size = New Global.System.Drawing.Size(448, 136)
            gbMoon2.Size = size
            Me.gbMoon.TabIndex = 21
            Me.gbMoon.TabStop = False
            Me.gbMoon.Text = "Moon"
            Me.btnMoonDiffuseColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnMoonDiffuseColor As Global.System.Windows.Forms.Control = Me.btnMoonDiffuseColor
            point = New Global.System.Drawing.Point(112, 40)
            btnMoonDiffuseColor.Location = point
            Me.btnMoonDiffuseColor.Name = "btnMoonDiffuseColor"
            Dim btnMoonDiffuseColor2 As Global.System.Windows.Forms.Control = Me.btnMoonDiffuseColor
            size = New Global.System.Drawing.Size(16, 16)
            btnMoonDiffuseColor2.Size = size
            Me.btnMoonDiffuseColor.TabIndex = 1
            Dim label77 As Global.System.Windows.Forms.Control = Me.Label24
            point = New Global.System.Drawing.Point(16, 16)
            label77.Location = point
            Me.Label24.Name = "Label24"
            Dim label78 As Global.System.Windows.Forms.Control = Me.Label24
            size = New Global.System.Drawing.Size(88, 16)
            label78.Size = size
            Me.Label24.TabIndex = 21
            Me.Label24.Text = "Ambient Color"
            Me.Label24.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label79 As Global.System.Windows.Forms.Control = Me.Label25
            point = New Global.System.Drawing.Point(16, 40)
            label79.Location = point
            Me.Label25.Name = "Label25"
            Dim label80 As Global.System.Windows.Forms.Control = Me.Label25
            size = New Global.System.Drawing.Size(88, 16)
            label80.Size = size
            Me.Label25.TabIndex = 20
            Me.Label25.Text = "Diffuse Color"
            Me.Label25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnMoonAmbientColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnMoonAmbientColor As Global.System.Windows.Forms.Control = Me.btnMoonAmbientColor
            point = New Global.System.Drawing.Point(112, 16)
            btnMoonAmbientColor.Location = point
            Me.btnMoonAmbientColor.Name = "btnMoonAmbientColor"
            Dim btnMoonAmbientColor2 As Global.System.Windows.Forms.Control = Me.btnMoonAmbientColor
            size = New Global.System.Drawing.Size(16, 16)
            btnMoonAmbientColor2.Size = size
            Me.btnMoonAmbientColor.TabIndex = 0
            Dim label81 As Global.System.Windows.Forms.Control = Me.Label31
            point = New Global.System.Drawing.Point(16, 112)
            label81.Location = point
            Me.Label31.Name = "Label31"
            Dim label82 As Global.System.Windows.Forms.Control = Me.Label31
            size = New Global.System.Drawing.Size(88, 16)
            label82.Size = size
            Me.Label31.TabIndex = 16
            Me.Label31.Text = "Shadows"
            Me.Label31.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label83 As Global.System.Windows.Forms.Control = Me.Label45
            point = New Global.System.Drawing.Point(16, 88)
            label83.Location = point
            Me.Label45.Name = "Label45"
            Dim label84 As Global.System.Windows.Forms.Control = Me.Label45
            size = New Global.System.Drawing.Size(88, 16)
            label84.Size = size
            Me.Label45.TabIndex = 16
            Me.Label45.Text = "Fog Color"
            Me.Label45.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnMoonFogColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnMoonFogColor As Global.System.Windows.Forms.Control = Me.btnMoonFogColor
            point = New Global.System.Drawing.Point(112, 88)
            btnMoonFogColor.Location = point
            Me.btnMoonFogColor.Name = "btnMoonFogColor"
            Dim btnMoonFogColor2 As Global.System.Windows.Forms.Control = Me.btnMoonFogColor
            size = New Global.System.Drawing.Size(16, 16)
            btnMoonFogColor2.Size = size
            Me.btnMoonFogColor.TabIndex = 3
            Dim chkbAreaMoonShadows As Global.System.Windows.Forms.Control = Me.chkbAreaMoonShadows
            point = New Global.System.Drawing.Point(112, 112)
            chkbAreaMoonShadows.Location = point
            Me.chkbAreaMoonShadows.Name = "chkbAreaMoonShadows"
            Dim chkbAreaMoonShadows2 As Global.System.Windows.Forms.Control = Me.chkbAreaMoonShadows
            size = New Global.System.Drawing.Size(32, 16)
            chkbAreaMoonShadows2.Size = size
            Me.chkbAreaMoonShadows.TabIndex = 4
            Dim label85 As Global.System.Windows.Forms.Control = Me.Label47
            point = New Global.System.Drawing.Point(16, 64)
            label85.Location = point
            Me.Label47.Name = "Label47"
            Dim label86 As Global.System.Windows.Forms.Control = Me.Label47
            size = New Global.System.Drawing.Size(88, 16)
            label86.Size = size
            Me.Label47.TabIndex = 16
            Me.Label47.Text = "Fog Enabled"
            Me.Label47.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbMoonFogOn As Global.System.Windows.Forms.Control = Me.chkbMoonFogOn
            point = New Global.System.Drawing.Point(112, 64)
            chkbMoonFogOn.Location = point
            Me.chkbMoonFogOn.Name = "chkbMoonFogOn"
            Dim chkbMoonFogOn2 As Global.System.Windows.Forms.Control = Me.chkbMoonFogOn
            size = New Global.System.Drawing.Size(32, 16)
            chkbMoonFogOn2.Size = size
            Me.chkbMoonFogOn.TabIndex = 2
            Me.trkbarMoonFogNear.Enabled = False
            Dim trkbarMoonFogNear As Global.System.Windows.Forms.Control = Me.trkbarMoonFogNear
            point = New Global.System.Drawing.Point(232, 24)
            trkbarMoonFogNear.Location = point
            Me.trkbarMoonFogNear.Maximum = 2000
            Me.trkbarMoonFogNear.Name = "trkbarMoonFogNear"
            Dim trkbarMoonFogNear2 As Global.System.Windows.Forms.Control = Me.trkbarMoonFogNear
            size = New Global.System.Drawing.Size(200, 42)
            trkbarMoonFogNear2.Size = size
            Me.trkbarMoonFogNear.TabIndex = 5
            Me.trkbarMoonFogNear.TickFrequency = 50
            Me.trkbarMoonFogNear.TickStyle = Global.System.Windows.Forms.TickStyle.TopLeft
            Me.lblMoonFogNear.Enabled = False
            Dim lblMoonFogNear As Global.System.Windows.Forms.Control = Me.lblMoonFogNear
            point = New Global.System.Drawing.Point(160, 32)
            lblMoonFogNear.Location = point
            Me.lblMoonFogNear.Name = "lblMoonFogNear"
            Dim lblMoonFogNear2 As Global.System.Windows.Forms.Control = Me.lblMoonFogNear
            size = New Global.System.Drawing.Size(64, 16)
            lblMoonFogNear2.Size = size
            Me.lblMoonFogNear.TabIndex = 16
            Me.lblMoonFogNear.Text = "Fog Near"
            Me.lblMoonFogNear.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.trkbarMoonFogFar.Enabled = False
            Dim trkbarMoonFogFar As Global.System.Windows.Forms.Control = Me.trkbarMoonFogFar
            point = New Global.System.Drawing.Point(232, 88)
            trkbarMoonFogFar.Location = point
            Me.trkbarMoonFogFar.Maximum = 2000
            Me.trkbarMoonFogFar.Name = "trkbarMoonFogFar"
            Dim trkbarMoonFogFar2 As Global.System.Windows.Forms.Control = Me.trkbarMoonFogFar
            size = New Global.System.Drawing.Size(200, 42)
            trkbarMoonFogFar2.Size = size
            Me.trkbarMoonFogFar.TabIndex = 6
            Me.trkbarMoonFogFar.TickFrequency = 50
            Me.trkbarMoonFogFar.TickStyle = Global.System.Windows.Forms.TickStyle.TopLeft
            Me.lblMoonFogFar.Enabled = False
            Dim lblMoonFogFar As Global.System.Windows.Forms.Control = Me.lblMoonFogFar
            point = New Global.System.Drawing.Point(160, 88)
            lblMoonFogFar.Location = point
            Me.lblMoonFogFar.Name = "lblMoonFogFar"
            Dim lblMoonFogFar2 As Global.System.Windows.Forms.Control = Me.lblMoonFogFar
            size = New Global.System.Drawing.Size(64, 16)
            lblMoonFogFar2.Size = size
            Me.lblMoonFogFar.TabIndex = 16
            Me.lblMoonFogFar.Text = "Fog Far"
            Me.lblMoonFogFar.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.gbSun.Controls.Add(Me.chkbAreaSunShadows)
            Me.gbSun.Controls.Add(Me.trkbarSunFogNear)
            Me.gbSun.Controls.Add(Me.Label27)
            Me.gbSun.Controls.Add(Me.btnSunAmbientColor)
            Me.gbSun.Controls.Add(Me.Label26)
            Me.gbSun.Controls.Add(Me.btnSunDiffuseColor)
            Me.gbSun.Controls.Add(Me.Label28)
            Me.gbSun.Controls.Add(Me.btnSunFogColor)
            Me.gbSun.Controls.Add(Me.Label29)
            Me.gbSun.Controls.Add(Me.Label30)
            Me.gbSun.Controls.Add(Me.trkbarSunFogFar)
            Me.gbSun.Controls.Add(Me.lblSunFogNear)
            Me.gbSun.Controls.Add(Me.lblSunFogFar)
            Me.gbSun.Controls.Add(Me.chkbSunFogOn)
            Dim gbSun As Global.System.Windows.Forms.Control = Me.gbSun
            point = New Global.System.Drawing.Point(16, 56)
            gbSun.Location = point
            Me.gbSun.Name = "gbSun"
            Dim gbSun2 As Global.System.Windows.Forms.Control = Me.gbSun
            size = New Global.System.Drawing.Size(448, 136)
            gbSun2.Size = size
            Me.gbSun.TabIndex = 20
            Me.gbSun.TabStop = False
            Me.gbSun.Text = "Sun"
            Dim chkbAreaSunShadows As Global.System.Windows.Forms.Control = Me.chkbAreaSunShadows
            point = New Global.System.Drawing.Point(112, 112)
            chkbAreaSunShadows.Location = point
            Me.chkbAreaSunShadows.Name = "chkbAreaSunShadows"
            Dim chkbAreaSunShadows2 As Global.System.Windows.Forms.Control = Me.chkbAreaSunShadows
            size = New Global.System.Drawing.Size(32, 16)
            chkbAreaSunShadows2.Size = size
            Me.chkbAreaSunShadows.TabIndex = 4
            Me.trkbarSunFogNear.Enabled = False
            Dim trkbarSunFogNear As Global.System.Windows.Forms.Control = Me.trkbarSunFogNear
            point = New Global.System.Drawing.Point(232, 24)
            trkbarSunFogNear.Location = point
            Me.trkbarSunFogNear.Maximum = 2000
            Me.trkbarSunFogNear.Name = "trkbarSunFogNear"
            Dim trkbarSunFogNear2 As Global.System.Windows.Forms.Control = Me.trkbarSunFogNear
            size = New Global.System.Drawing.Size(200, 42)
            trkbarSunFogNear2.Size = size
            Me.trkbarSunFogNear.TabIndex = 5
            Me.trkbarSunFogNear.TickFrequency = 50
            Me.trkbarSunFogNear.TickStyle = Global.System.Windows.Forms.TickStyle.TopLeft
            Dim label87 As Global.System.Windows.Forms.Control = Me.Label27
            point = New Global.System.Drawing.Point(16, 40)
            label87.Location = point
            Me.Label27.Name = "Label27"
            Dim label88 As Global.System.Windows.Forms.Control = Me.Label27
            size = New Global.System.Drawing.Size(88, 16)
            label88.Size = size
            Me.Label27.TabIndex = 16
            Me.Label27.Text = "Diffuse Color"
            Me.Label27.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSunAmbientColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnSunAmbientColor As Global.System.Windows.Forms.Control = Me.btnSunAmbientColor
            point = New Global.System.Drawing.Point(112, 16)
            btnSunAmbientColor.Location = point
            Me.btnSunAmbientColor.Name = "btnSunAmbientColor"
            Dim btnSunAmbientColor2 As Global.System.Windows.Forms.Control = Me.btnSunAmbientColor
            size = New Global.System.Drawing.Size(16, 16)
            btnSunAmbientColor2.Size = size
            Me.btnSunAmbientColor.TabIndex = 0
            Dim label89 As Global.System.Windows.Forms.Control = Me.Label26
            point = New Global.System.Drawing.Point(16, 16)
            label89.Location = point
            Me.Label26.Name = "Label26"
            Dim label90 As Global.System.Windows.Forms.Control = Me.Label26
            size = New Global.System.Drawing.Size(88, 16)
            label90.Size = size
            Me.Label26.TabIndex = 17
            Me.Label26.Text = "Ambient Color"
            Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSunDiffuseColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnSunDiffuseColor As Global.System.Windows.Forms.Control = Me.btnSunDiffuseColor
            point = New Global.System.Drawing.Point(112, 40)
            btnSunDiffuseColor.Location = point
            Me.btnSunDiffuseColor.Name = "btnSunDiffuseColor"
            Dim btnSunDiffuseColor2 As Global.System.Windows.Forms.Control = Me.btnSunDiffuseColor
            size = New Global.System.Drawing.Size(16, 16)
            btnSunDiffuseColor2.Size = size
            Me.btnSunDiffuseColor.TabIndex = 1
            Dim label91 As Global.System.Windows.Forms.Control = Me.Label28
            point = New Global.System.Drawing.Point(16, 88)
            label91.Location = point
            Me.Label28.Name = "Label28"
            Dim label92 As Global.System.Windows.Forms.Control = Me.Label28
            size = New Global.System.Drawing.Size(88, 16)
            label92.Size = size
            Me.Label28.TabIndex = 16
            Me.Label28.Text = "Fog Color"
            Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSunFogColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnSunFogColor As Global.System.Windows.Forms.Control = Me.btnSunFogColor
            point = New Global.System.Drawing.Point(112, 88)
            btnSunFogColor.Location = point
            Me.btnSunFogColor.Name = "btnSunFogColor"
            Dim btnSunFogColor2 As Global.System.Windows.Forms.Control = Me.btnSunFogColor
            size = New Global.System.Drawing.Size(16, 16)
            btnSunFogColor2.Size = size
            Me.btnSunFogColor.TabIndex = 3
            Dim label93 As Global.System.Windows.Forms.Control = Me.Label29
            point = New Global.System.Drawing.Point(16, 64)
            label93.Location = point
            Me.Label29.Name = "Label29"
            Dim label94 As Global.System.Windows.Forms.Control = Me.Label29
            size = New Global.System.Drawing.Size(88, 16)
            label94.Size = size
            Me.Label29.TabIndex = 16
            Me.Label29.Text = "Fog Enabled"
            Me.Label29.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label95 As Global.System.Windows.Forms.Control = Me.Label30
            point = New Global.System.Drawing.Point(16, 112)
            label95.Location = point
            Me.Label30.Name = "Label30"
            Dim label96 As Global.System.Windows.Forms.Control = Me.Label30
            size = New Global.System.Drawing.Size(88, 16)
            label96.Size = size
            Me.Label30.TabIndex = 16
            Me.Label30.Text = "Shadows"
            Me.Label30.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.trkbarSunFogFar.Enabled = False
            Dim trkbarSunFogFar As Global.System.Windows.Forms.Control = Me.trkbarSunFogFar
            point = New Global.System.Drawing.Point(232, 80)
            trkbarSunFogFar.Location = point
            Me.trkbarSunFogFar.Maximum = 2000
            Me.trkbarSunFogFar.Name = "trkbarSunFogFar"
            Dim trkbarSunFogFar2 As Global.System.Windows.Forms.Control = Me.trkbarSunFogFar
            size = New Global.System.Drawing.Size(200, 42)
            trkbarSunFogFar2.Size = size
            Me.trkbarSunFogFar.TabIndex = 6
            Me.trkbarSunFogFar.TickFrequency = 50
            Me.trkbarSunFogFar.TickStyle = Global.System.Windows.Forms.TickStyle.TopLeft
            Me.lblSunFogNear.Enabled = False
            Dim lblSunFogNear As Global.System.Windows.Forms.Control = Me.lblSunFogNear
            point = New Global.System.Drawing.Point(160, 32)
            lblSunFogNear.Location = point
            Me.lblSunFogNear.Name = "lblSunFogNear"
            Dim lblSunFogNear2 As Global.System.Windows.Forms.Control = Me.lblSunFogNear
            size = New Global.System.Drawing.Size(64, 16)
            lblSunFogNear2.Size = size
            Me.lblSunFogNear.TabIndex = 16
            Me.lblSunFogNear.Text = "Fog Near"
            Me.lblSunFogNear.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblSunFogFar.Enabled = False
            Dim lblSunFogFar As Global.System.Windows.Forms.Control = Me.lblSunFogFar
            point = New Global.System.Drawing.Point(160, 88)
            lblSunFogFar.Location = point
            Me.lblSunFogFar.Name = "lblSunFogFar"
            Dim lblSunFogFar2 As Global.System.Windows.Forms.Control = Me.lblSunFogFar
            size = New Global.System.Drawing.Size(64, 16)
            lblSunFogFar2.Size = size
            Me.lblSunFogFar.TabIndex = 16
            Me.lblSunFogFar.Text = "Fog Far"
            Me.lblSunFogFar.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbSunFogOn As Global.System.Windows.Forms.Control = Me.chkbSunFogOn
            point = New Global.System.Drawing.Point(112, 64)
            chkbSunFogOn.Location = point
            Me.chkbSunFogOn.Name = "chkbSunFogOn"
            Dim chkbSunFogOn2 As Global.System.Windows.Forms.Control = Me.chkbSunFogOn
            size = New Global.System.Drawing.Size(32, 16)
            chkbSunFogOn2.Size = size
            Me.chkbSunFogOn.TabIndex = 2
            Dim rbAlwaysDay As Global.System.Windows.Forms.Control = Me.rbAlwaysDay
            point = New Global.System.Drawing.Point(40, 24)
            rbAlwaysDay.Location = point
            Me.rbAlwaysDay.Name = "rbAlwaysDay"
            Dim rbAlwaysDay2 As Global.System.Windows.Forms.Control = Me.rbAlwaysDay
            size = New Global.System.Drawing.Size(104, 16)
            rbAlwaysDay2.Size = size
            Me.rbAlwaysDay.TabIndex = 1
            Me.rbAlwaysDay.Text = "Always Day"
            Dim rbAlwaysNight As Global.System.Windows.Forms.Control = Me.rbAlwaysNight
            point = New Global.System.Drawing.Point(40, 40)
            rbAlwaysNight.Location = point
            Me.rbAlwaysNight.Name = "rbAlwaysNight"
            Dim rbAlwaysNight2 As Global.System.Windows.Forms.Control = Me.rbAlwaysNight
            size = New Global.System.Drawing.Size(104, 16)
            rbAlwaysNight2.Size = size
            Me.rbAlwaysNight.TabIndex = 2
            Me.rbAlwaysNight.Text = "Always Night"
            Me.btnDynAmbientColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnDynAmbientColor As Global.System.Windows.Forms.Control = Me.btnDynAmbientColor
            point = New Global.System.Drawing.Point(376, 10)
            btnDynAmbientColor.Location = point
            Me.btnDynAmbientColor.Name = "btnDynAmbientColor"
            Dim btnDynAmbientColor2 As Global.System.Windows.Forms.Control = Me.btnDynAmbientColor
            size = New Global.System.Drawing.Size(16, 16)
            btnDynAmbientColor2.Size = size
            Me.btnDynAmbientColor.TabIndex = 3
            Dim label97 As Global.System.Windows.Forms.Control = Me.Label48
            point = New Global.System.Drawing.Point(232, 10)
            label97.Location = point
            Me.Label48.Name = "Label48"
            Dim label98 As Global.System.Windows.Forms.Control = Me.Label48
            size = New Global.System.Drawing.Size(136, 16)
            label98.Size = size
            Me.Label48.TabIndex = 17
            Me.Label48.Text = "Dynamic Ambient Color"
            Me.Label48.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label99 As Global.System.Windows.Forms.Control = Me.Label73
            point = New Global.System.Drawing.Point(232, 32)
            label99.Location = point
            Me.Label73.Name = "Label73"
            Dim label100 As Global.System.Windows.Forms.Control = Me.Label73
            size = New Global.System.Drawing.Size(88, 16)
            label100.Size = size
            Me.Label73.TabIndex = 24
            Me.Label73.Text = "Shadow Opacity"
            Me.Label73.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudShadowOpacity As Global.System.Windows.Forms.Control = Me.nudShadowOpacity
            point = New Global.System.Drawing.Point(352, 32)
            nudShadowOpacity.Location = point
            Dim nudShadowOpacity2 As Global.System.Windows.Forms.NumericUpDown = Me.nudShadowOpacity
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudShadowOpacity2.Maximum = num
            Me.nudShadowOpacity.Name = "nudShadowOpacity"
            Dim nudShadowOpacity3 As Global.System.Windows.Forms.Control = Me.nudShadowOpacity
            size = New Global.System.Drawing.Size(48, 20)
            nudShadowOpacity3.Size = size
            Me.nudShadowOpacity.TabIndex = 0
            Me.nudShadowOpacity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label84.Enabled = False
            Dim label101 As Global.System.Windows.Forms.Control = Me.Label84
            point = New Global.System.Drawing.Point(248, 360)
            label101.Location = point
            Me.Label84.Name = "Label84"
            Dim label102 As Global.System.Windows.Forms.Control = Me.Label84
            size = New Global.System.Drawing.Size(80, 16)
            label102.Size = size
            Me.Label84.TabIndex = 16
            Me.Label84.Text = "Wind Strength"
            Me.Label84.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tabpagAreaGrass.Controls.Add(Me.nudGrassDensity)
            Me.tabpagAreaGrass.Controls.Add(Me.trkbarGrassDensityX10)
            Me.tabpagAreaGrass.Controls.Add(Me.Label62)
            Me.tabpagAreaGrass.Controls.Add(Me.btnGrassDiffuseColor)
            Me.tabpagAreaGrass.Controls.Add(Me.tbGrass_TexName)
            Me.tabpagAreaGrass.Controls.Add(Me.Label20)
            Me.tabpagAreaGrass.Controls.Add(Me.Label21)
            Me.tabpagAreaGrass.Controls.Add(Me.Label22)
            Me.tabpagAreaGrass.Controls.Add(Me.btnGrassAmbientColor)
            Me.tabpagAreaGrass.Controls.Add(Me.Label23)
            Me.tabpagAreaGrass.Controls.Add(Me.btnGrassEmissiveColor)
            Me.tabpagAreaGrass.Controls.Add(Me.nudGrassProbUL)
            Me.tabpagAreaGrass.Controls.Add(Me.nudGrassProbLL)
            Me.tabpagAreaGrass.Controls.Add(Me.nudGrassProbUR)
            Me.tabpagAreaGrass.Controls.Add(Me.nudGrassProbLR)
            Me.tabpagAreaGrass.Controls.Add(Me.Label63)
            Me.tabpagAreaGrass.Controls.Add(Me.Label64)
            Me.tabpagAreaGrass.Controls.Add(Me.Label65)
            Me.tabpagAreaGrass.Controls.Add(Me.Label66)
            Me.tabpagAreaGrass.Controls.Add(Me.Label67)
            Me.tabpagAreaGrass.Controls.Add(Me.lblTotalGrassProbability)
            Me.tabpagAreaGrass.Controls.Add(Me.Label69)
            Me.tabpagAreaGrass.Controls.Add(Me.Label70)
            Me.tabpagAreaGrass.Controls.Add(Me.Label71)
            Me.tabpagAreaGrass.Controls.Add(Me.Label72)
            Me.tabpagAreaGrass.Controls.Add(Me.Label68)
            Me.tabpagAreaGrass.Controls.Add(Me.nudGrassQuadSize)
            Dim tabpagAreaGrass As Global.System.Windows.Forms.Control = Me.tabpagAreaGrass
            point = New Global.System.Drawing.Point(4, 22)
            tabpagAreaGrass.Location = point
            Me.tabpagAreaGrass.Name = "tabpagAreaGrass"
            Dim tabpagAreaGrass2 As Global.System.Windows.Forms.Control = Me.tabpagAreaGrass
            size = New Global.System.Drawing.Size(480, 444)
            tabpagAreaGrass2.Size = size
            Me.tabpagAreaGrass.TabIndex = 2
            Me.tabpagAreaGrass.Text = "Grass"
            Me.nudGrassDensity.DecimalPlaces = 2
            Dim nudGrassDensity As Global.System.Windows.Forms.Control = Me.nudGrassDensity
            point = New Global.System.Drawing.Point(320, 320)
            nudGrassDensity.Location = point
            Dim nudGrassDensity2 As Global.System.Windows.Forms.NumericUpDown = Me.nudGrassDensity
            num = New Decimal(New Integer() {50, 0, 0, 0})
            nudGrassDensity2.Maximum = num
            Me.nudGrassDensity.Name = "nudGrassDensity"
            Dim nudGrassDensity3 As Global.System.Windows.Forms.Control = Me.nudGrassDensity
            size = New Global.System.Drawing.Size(56, 20)
            nudGrassDensity3.Size = size
            Me.nudGrassDensity.TabIndex = 19
            Me.nudGrassDensity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim trkbarGrassDensityX As Global.System.Windows.Forms.Control = Me.trkbarGrassDensityX10
            point = New Global.System.Drawing.Point(112, 312)
            trkbarGrassDensityX.Location = point
            Me.trkbarGrassDensityX10.Maximum = 500
            Me.trkbarGrassDensityX10.Name = "trkbarGrassDensityX10"
            Dim trkbarGrassDensityX2 As Global.System.Windows.Forms.Control = Me.trkbarGrassDensityX10
            size = New Global.System.Drawing.Size(200, 42)
            trkbarGrassDensityX2.Size = size
            Me.trkbarGrassDensityX10.TabIndex = 17
            Me.trkbarGrassDensityX10.TickFrequency = 10
            Dim label103 As Global.System.Windows.Forms.Control = Me.Label62
            point = New Global.System.Drawing.Point(24, 320)
            label103.Location = point
            Me.Label62.Name = "Label62"
            Dim label104 As Global.System.Windows.Forms.Control = Me.Label62
            size = New Global.System.Drawing.Size(80, 16)
            label104.Size = size
            Me.Label62.TabIndex = 18
            Me.Label62.Text = "Grass Density"
            Me.Label62.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGrassDiffuseColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnGrassDiffuseColor As Global.System.Windows.Forms.Control = Me.btnGrassDiffuseColor
            point = New Global.System.Drawing.Point(120, 104)
            btnGrassDiffuseColor.Location = point
            Me.btnGrassDiffuseColor.Name = "btnGrassDiffuseColor"
            Dim btnGrassDiffuseColor2 As Global.System.Windows.Forms.Control = Me.btnGrassDiffuseColor
            size = New Global.System.Drawing.Size(16, 16)
            btnGrassDiffuseColor2.Size = size
            Me.btnGrassDiffuseColor.TabIndex = 15
            Dim tbGrass_TexName As Global.System.Windows.Forms.Control = Me.tbGrass_TexName
            point = New Global.System.Drawing.Point(120, 40)
            tbGrass_TexName.Location = point
            Me.tbGrass_TexName.MaxLength = 16
            Me.tbGrass_TexName.Name = "tbGrass_TexName"
            Dim tbGrass_TexName2 As Global.System.Windows.Forms.Control = Me.tbGrass_TexName
            size = New Global.System.Drawing.Size(176, 20)
            tbGrass_TexName2.Size = size
            Me.tbGrass_TexName.TabIndex = 14
            Me.tbGrass_TexName.Text = ""
            Dim label105 As Global.System.Windows.Forms.Control = Me.Label20
            point = New Global.System.Drawing.Point(24, 40)
            label105.Location = point
            Me.Label20.Name = "Label20"
            Dim label106 As Global.System.Windows.Forms.Control = Me.Label20
            size = New Global.System.Drawing.Size(88, 16)
            label106.Size = size
            Me.Label20.TabIndex = 13
            Me.Label20.Text = "Texture Name"
            Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label107 As Global.System.Windows.Forms.Control = Me.Label21
            point = New Global.System.Drawing.Point(24, 80)
            label107.Location = point
            Me.Label21.Name = "Label21"
            Dim label108 As Global.System.Windows.Forms.Control = Me.Label21
            size = New Global.System.Drawing.Size(88, 16)
            label108.Size = size
            Me.Label21.TabIndex = 13
            Me.Label21.Text = "Ambient Color"
            Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label109 As Global.System.Windows.Forms.Control = Me.Label22
            point = New Global.System.Drawing.Point(24, 104)
            label109.Location = point
            Me.Label22.Name = "Label22"
            Dim label110 As Global.System.Windows.Forms.Control = Me.Label22
            size = New Global.System.Drawing.Size(88, 16)
            label110.Size = size
            Me.Label22.TabIndex = 13
            Me.Label22.Text = "Diffuse Color"
            Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGrassAmbientColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnGrassAmbientColor As Global.System.Windows.Forms.Control = Me.btnGrassAmbientColor
            point = New Global.System.Drawing.Point(120, 80)
            btnGrassAmbientColor.Location = point
            Me.btnGrassAmbientColor.Name = "btnGrassAmbientColor"
            Dim btnGrassAmbientColor2 As Global.System.Windows.Forms.Control = Me.btnGrassAmbientColor
            size = New Global.System.Drawing.Size(16, 16)
            btnGrassAmbientColor2.Size = size
            Me.btnGrassAmbientColor.TabIndex = 15
            Dim label111 As Global.System.Windows.Forms.Control = Me.Label23
            point = New Global.System.Drawing.Point(24, 128)
            label111.Location = point
            Me.Label23.Name = "Label23"
            Dim label112 As Global.System.Windows.Forms.Control = Me.Label23
            size = New Global.System.Drawing.Size(88, 16)
            label112.Size = size
            Me.Label23.TabIndex = 13
            Me.Label23.Text = "Emissive Color"
            Me.Label23.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGrassEmissiveColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Dim btnGrassEmissiveColor As Global.System.Windows.Forms.Control = Me.btnGrassEmissiveColor
            point = New Global.System.Drawing.Point(120, 128)
            btnGrassEmissiveColor.Location = point
            Me.btnGrassEmissiveColor.Name = "btnGrassEmissiveColor"
            Dim btnGrassEmissiveColor2 As Global.System.Windows.Forms.Control = Me.btnGrassEmissiveColor
            size = New Global.System.Drawing.Size(16, 16)
            btnGrassEmissiveColor2.Size = size
            Me.btnGrassEmissiveColor.TabIndex = 15
            Dim nudGrassProbUL As Global.System.Windows.Forms.Control = Me.nudGrassProbUL
            point = New Global.System.Drawing.Point(160, 216)
            nudGrassProbUL.Location = point
            Me.nudGrassProbUL.Name = "nudGrassProbUL"
            Dim nudGrassProbUL2 As Global.System.Windows.Forms.Control = Me.nudGrassProbUL
            size = New Global.System.Drawing.Size(40, 20)
            nudGrassProbUL2.Size = size
            Me.nudGrassProbUL.TabIndex = 19
            Me.nudGrassProbUL.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudGrassProbUL3 As Global.System.Windows.Forms.NumericUpDown = Me.nudGrassProbUL
            num = New Decimal(New Integer() {25, 0, 0, 0})
            nudGrassProbUL3.Value = num
            Dim nudGrassProbLL As Global.System.Windows.Forms.Control = Me.nudGrassProbLL
            point = New Global.System.Drawing.Point(160, 272)
            nudGrassProbLL.Location = point
            Me.nudGrassProbLL.Name = "nudGrassProbLL"
            Dim nudGrassProbLL2 As Global.System.Windows.Forms.Control = Me.nudGrassProbLL
            size = New Global.System.Drawing.Size(40, 20)
            nudGrassProbLL2.Size = size
            Me.nudGrassProbLL.TabIndex = 19
            Me.nudGrassProbLL.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudGrassProbLL3 As Global.System.Windows.Forms.NumericUpDown = Me.nudGrassProbLL
            num = New Decimal(New Integer() {25, 0, 0, 0})
            nudGrassProbLL3.Value = num
            Dim nudGrassProbUR As Global.System.Windows.Forms.Control = Me.nudGrassProbUR
            point = New Global.System.Drawing.Point(264, 216)
            nudGrassProbUR.Location = point
            Me.nudGrassProbUR.Name = "nudGrassProbUR"
            Dim nudGrassProbUR2 As Global.System.Windows.Forms.Control = Me.nudGrassProbUR
            size = New Global.System.Drawing.Size(40, 20)
            nudGrassProbUR2.Size = size
            Me.nudGrassProbUR.TabIndex = 19
            Me.nudGrassProbUR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudGrassProbUR3 As Global.System.Windows.Forms.NumericUpDown = Me.nudGrassProbUR
            num = New Decimal(New Integer() {25, 0, 0, 0})
            nudGrassProbUR3.Value = num
            Dim nudGrassProbLR As Global.System.Windows.Forms.Control = Me.nudGrassProbLR
            point = New Global.System.Drawing.Point(264, 272)
            nudGrassProbLR.Location = point
            Me.nudGrassProbLR.Name = "nudGrassProbLR"
            Dim nudGrassProbLR2 As Global.System.Windows.Forms.Control = Me.nudGrassProbLR
            size = New Global.System.Drawing.Size(40, 20)
            nudGrassProbLR2.Size = size
            Me.nudGrassProbLR.TabIndex = 19
            Me.nudGrassProbLR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudGrassProbLR3 As Global.System.Windows.Forms.NumericUpDown = Me.nudGrassProbLR
            num = New Decimal(New Integer() {25, 0, 0, 0})
            nudGrassProbLR3.Value = num
            Dim label113 As Global.System.Windows.Forms.Control = Me.Label63
            point = New Global.System.Drawing.Point(24, 224)
            label113.Location = point
            Me.Label63.Name = "Label63"
            Dim label114 As Global.System.Windows.Forms.Control = Me.Label63
            size = New Global.System.Drawing.Size(80, 48)
            label114.Size = size
            Me.Label63.TabIndex = 18
            Me.Label63.Text = "Grass Movement Probability"
            Me.Label63.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label115 As Global.System.Windows.Forms.Control = Me.Label64
            point = New Global.System.Drawing.Point(224, 208)
            label115.Location = point
            Me.Label64.Name = "Label64"
            Dim label116 As Global.System.Windows.Forms.Control = Me.Label64
            size = New Global.System.Drawing.Size(40, 32)
            label116.Size = size
            Me.Label64.TabIndex = 13
            Me.Label64.Text = "Upper Right"
            Me.Label64.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label117 As Global.System.Windows.Forms.Control = Me.Label65
            point = New Global.System.Drawing.Point(120, 208)
            label117.Location = point
            Me.Label65.Name = "Label65"
            Dim label118 As Global.System.Windows.Forms.Control = Me.Label65
            size = New Global.System.Drawing.Size(40, 32)
            label118.Size = size
            Me.Label65.TabIndex = 13
            Me.Label65.Text = "Upper Left"
            Me.Label65.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label119 As Global.System.Windows.Forms.Control = Me.Label66
            point = New Global.System.Drawing.Point(120, 264)
            label119.Location = point
            Me.Label66.Name = "Label66"
            Dim label120 As Global.System.Windows.Forms.Control = Me.Label66
            size = New Global.System.Drawing.Size(40, 32)
            label120.Size = size
            Me.Label66.TabIndex = 13
            Me.Label66.Text = "Lower Left"
            Me.Label66.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label121 As Global.System.Windows.Forms.Control = Me.Label67
            point = New Global.System.Drawing.Point(224, 264)
            label121.Location = point
            Me.Label67.Name = "Label67"
            Dim label122 As Global.System.Windows.Forms.Control = Me.Label67
            size = New Global.System.Drawing.Size(40, 32)
            label122.Size = size
            Me.Label67.TabIndex = 13
            Me.Label67.Text = "Lower Right"
            Me.Label67.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim lblTotalGrassProbability As Global.System.Windows.Forms.Control = Me.lblTotalGrassProbability
            point = New Global.System.Drawing.Point(344, 248)
            lblTotalGrassProbability.Location = point
            Me.lblTotalGrassProbability.Name = "lblTotalGrassProbability"
            Dim lblTotalGrassProbability2 As Global.System.Windows.Forms.Control = Me.lblTotalGrassProbability
            size = New Global.System.Drawing.Size(80, 16)
            lblTotalGrassProbability2.Size = size
            Me.lblTotalGrassProbability.TabIndex = 18
            Me.lblTotalGrassProbability.Text = "Total: "
            Me.lblTotalGrassProbability.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label123 As Global.System.Windows.Forms.Control = Me.Label69
            point = New Global.System.Drawing.Point(200, 218)
            label123.Location = point
            Me.Label69.Name = "Label69"
            Dim label124 As Global.System.Windows.Forms.Control = Me.Label69
            size = New Global.System.Drawing.Size(16, 16)
            label124.Size = size
            Me.Label69.TabIndex = 13
            Me.Label69.Text = "%"
            Me.Label69.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label125 As Global.System.Windows.Forms.Control = Me.Label70
            point = New Global.System.Drawing.Point(304, 218)
            label125.Location = point
            Me.Label70.Name = "Label70"
            Dim label126 As Global.System.Windows.Forms.Control = Me.Label70
            size = New Global.System.Drawing.Size(16, 16)
            label126.Size = size
            Me.Label70.TabIndex = 13
            Me.Label70.Text = "%"
            Me.Label70.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label127 As Global.System.Windows.Forms.Control = Me.Label71
            point = New Global.System.Drawing.Point(304, 274)
            label127.Location = point
            Me.Label71.Name = "Label71"
            Dim label128 As Global.System.Windows.Forms.Control = Me.Label71
            size = New Global.System.Drawing.Size(16, 16)
            label128.Size = size
            Me.Label71.TabIndex = 13
            Me.Label71.Text = "%"
            Me.Label71.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label129 As Global.System.Windows.Forms.Control = Me.Label72
            point = New Global.System.Drawing.Point(200, 274)
            label129.Location = point
            Me.Label72.Name = "Label72"
            Dim label130 As Global.System.Windows.Forms.Control = Me.Label72
            size = New Global.System.Drawing.Size(16, 16)
            label130.Size = size
            Me.Label72.TabIndex = 13
            Me.Label72.Text = "%"
            Me.Label72.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label131 As Global.System.Windows.Forms.Control = Me.Label68
            point = New Global.System.Drawing.Point(24, 160)
            label131.Location = point
            Me.Label68.Name = "Label68"
            Dim label132 As Global.System.Windows.Forms.Control = Me.Label68
            size = New Global.System.Drawing.Size(96, 16)
            label132.Size = size
            Me.Label68.TabIndex = 18
            Me.Label68.Text = "Grass Quad Size"
            Me.Label68.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudGrassQuadSize.DecimalPlaces = 2
            Dim nudGrassQuadSize As Global.System.Windows.Forms.NumericUpDown = Me.nudGrassQuadSize
            num = New Decimal(New Integer() {5, 0, 0, 131072})
            nudGrassQuadSize.Increment = num
            Dim nudGrassQuadSize2 As Global.System.Windows.Forms.Control = Me.nudGrassQuadSize
            point = New Global.System.Drawing.Point(120, 160)
            nudGrassQuadSize2.Location = point
            Dim nudGrassQuadSize3 As Global.System.Windows.Forms.NumericUpDown = Me.nudGrassQuadSize
            num = New Decimal(New Integer() {20, 0, 0, 0})
            nudGrassQuadSize3.Maximum = num
            Me.nudGrassQuadSize.Name = "nudGrassQuadSize"
            Dim nudGrassQuadSize4 As Global.System.Windows.Forms.Control = Me.nudGrassQuadSize
            size = New Global.System.Drawing.Size(56, 20)
            nudGrassQuadSize4.Size = size
            Me.nudGrassQuadSize.TabIndex = 19
            Me.nudGrassQuadSize.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudGrassQuadSize5 As Global.System.Windows.Forms.NumericUpDown = Me.nudGrassQuadSize
            num = New Decimal(New Integer() {10, 0, 0, 65536})
            nudGrassQuadSize5.Value = num
            Me.tabpagAreaAudio.Controls.Add(Me.trkbarAmbientSndNightVol)
            Me.tabpagAreaAudio.Controls.Add(Me.trkbarAmbientSndDayVol)
            Me.tabpagAreaAudio.Controls.Add(Me.Label52)
            Me.tabpagAreaAudio.Controls.Add(Me.nudMusicDelay)
            Me.tabpagAreaAudio.Controls.Add(Me.cmbxMusicNight)
            Me.tabpagAreaAudio.Controls.Add(Me.cmbxMusicDay)
            Me.tabpagAreaAudio.Controls.Add(Me.cmbxMusicBattle)
            Me.tabpagAreaAudio.Controls.Add(Me.cmbxEnvAudio)
            Me.tabpagAreaAudio.Controls.Add(Me.cmbxAmbientSndNight)
            Me.tabpagAreaAudio.Controls.Add(Me.cmbxAmbientSndDay)
            Me.tabpagAreaAudio.Controls.Add(Me.Label53)
            Me.tabpagAreaAudio.Controls.Add(Me.Label54)
            Me.tabpagAreaAudio.Controls.Add(Me.Label55)
            Me.tabpagAreaAudio.Controls.Add(Me.Label56)
            Me.tabpagAreaAudio.Controls.Add(Me.Label57)
            Me.tabpagAreaAudio.Controls.Add(Me.Label58)
            Me.tabpagAreaAudio.Controls.Add(Me.Label59)
            Me.tabpagAreaAudio.Controls.Add(Me.Label60)
            Me.tabpagAreaAudio.Controls.Add(Me.Label61)
            Dim tabpagAreaAudio As Global.System.Windows.Forms.Control = Me.tabpagAreaAudio
            point = New Global.System.Drawing.Point(4, 22)
            tabpagAreaAudio.Location = point
            Me.tabpagAreaAudio.Name = "tabpagAreaAudio"
            Dim tabpagAreaAudio2 As Global.System.Windows.Forms.Control = Me.tabpagAreaAudio
            size = New Global.System.Drawing.Size(480, 444)
            tabpagAreaAudio2.Size = size
            Me.tabpagAreaAudio.TabIndex = 5
            Me.tabpagAreaAudio.Text = "Audio"
            Dim trkbarAmbientSndNightVol As Global.System.Windows.Forms.Control = Me.trkbarAmbientSndNightVol
            point = New Global.System.Drawing.Point(160, 144)
            trkbarAmbientSndNightVol.Location = point
            Me.trkbarAmbientSndNightVol.Maximum = 127
            Me.trkbarAmbientSndNightVol.Name = "trkbarAmbientSndNightVol"
            Dim trkbarAmbientSndNightVol2 As Global.System.Windows.Forms.Control = Me.trkbarAmbientSndNightVol
            size = New Global.System.Drawing.Size(216, 42)
            trkbarAmbientSndNightVol2.Size = size
            Me.trkbarAmbientSndNightVol.TabIndex = 3
            Me.trkbarAmbientSndNightVol.TickFrequency = 5
            Dim trkbarAmbientSndDayVol As Global.System.Windows.Forms.Control = Me.trkbarAmbientSndDayVol
            point = New Global.System.Drawing.Point(160, 64)
            trkbarAmbientSndDayVol.Location = point
            Me.trkbarAmbientSndDayVol.Maximum = 127
            Me.trkbarAmbientSndDayVol.Name = "trkbarAmbientSndDayVol"
            Dim trkbarAmbientSndDayVol2 As Global.System.Windows.Forms.Control = Me.trkbarAmbientSndDayVol
            size = New Global.System.Drawing.Size(216, 42)
            trkbarAmbientSndDayVol2.Size = size
            Me.trkbarAmbientSndDayVol.TabIndex = 1
            Me.trkbarAmbientSndDayVol.TickFrequency = 5
            Dim label133 As Global.System.Windows.Forms.Control = Me.Label52
            point = New Global.System.Drawing.Point(24, 40)
            label133.Location = point
            Me.Label52.Name = "Label52"
            Dim label134 As Global.System.Windows.Forms.Control = Me.Label52
            size = New Global.System.Drawing.Size(112, 16)
            label134.Size = size
            Me.Label52.TabIndex = 19
            Me.Label52.Text = "Ambient Sound - Day"
            Me.Label52.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudMusicDelay As Global.System.Windows.Forms.Control = Me.nudMusicDelay
            point = New Global.System.Drawing.Point(168, 336)
            nudMusicDelay.Location = point
            Dim nudMusicDelay2 As Global.System.Windows.Forms.NumericUpDown = Me.nudMusicDelay
            num = New Decimal(New Integer() {600, 0, 0, 0})
            nudMusicDelay2.Maximum = num
            Me.nudMusicDelay.Name = "nudMusicDelay"
            Dim nudMusicDelay3 As Global.System.Windows.Forms.Control = Me.nudMusicDelay
            size = New Global.System.Drawing.Size(56, 20)
            nudMusicDelay3.Size = size
            Me.nudMusicDelay.TabIndex = 8
            Me.nudMusicDelay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.cmbxMusicNight.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxMusicNight As Global.System.Windows.Forms.Control = Me.cmbxMusicNight
            point = New Global.System.Drawing.Point(168, 304)
            cmbxMusicNight.Location = point
            Me.cmbxMusicNight.Name = "cmbxMusicNight"
            Dim cmbxMusicNight2 As Global.System.Windows.Forms.Control = Me.cmbxMusicNight
            size = New Global.System.Drawing.Size(200, 21)
            cmbxMusicNight2.Size = size
            Me.cmbxMusicNight.TabIndex = 7
            Me.cmbxMusicDay.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxMusicDay As Global.System.Windows.Forms.Control = Me.cmbxMusicDay
            point = New Global.System.Drawing.Point(168, 272)
            cmbxMusicDay.Location = point
            Me.cmbxMusicDay.Name = "cmbxMusicDay"
            Dim cmbxMusicDay2 As Global.System.Windows.Forms.Control = Me.cmbxMusicDay
            size = New Global.System.Drawing.Size(200, 21)
            cmbxMusicDay2.Size = size
            Me.cmbxMusicDay.TabIndex = 6
            Me.cmbxMusicBattle.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxMusicBattle As Global.System.Windows.Forms.Control = Me.cmbxMusicBattle
            point = New Global.System.Drawing.Point(168, 240)
            cmbxMusicBattle.Location = point
            Me.cmbxMusicBattle.Name = "cmbxMusicBattle"
            Dim cmbxMusicBattle2 As Global.System.Windows.Forms.Control = Me.cmbxMusicBattle
            size = New Global.System.Drawing.Size(200, 21)
            cmbxMusicBattle2.Size = size
            Me.cmbxMusicBattle.TabIndex = 5
            Me.cmbxEnvAudio.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxEnvAudio As Global.System.Windows.Forms.Control = Me.cmbxEnvAudio
            point = New Global.System.Drawing.Point(168, 208)
            cmbxEnvAudio.Location = point
            Me.cmbxEnvAudio.Name = "cmbxEnvAudio"
            Dim cmbxEnvAudio2 As Global.System.Windows.Forms.Control = Me.cmbxEnvAudio
            size = New Global.System.Drawing.Size(200, 21)
            cmbxEnvAudio2.Size = size
            Me.cmbxEnvAudio.TabIndex = 4
            Me.cmbxAmbientSndNight.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxAmbientSndNight As Global.System.Windows.Forms.Control = Me.cmbxAmbientSndNight
            point = New Global.System.Drawing.Point(168, 120)
            cmbxAmbientSndNight.Location = point
            Me.cmbxAmbientSndNight.Name = "cmbxAmbientSndNight"
            Dim cmbxAmbientSndNight2 As Global.System.Windows.Forms.Control = Me.cmbxAmbientSndNight
            size = New Global.System.Drawing.Size(200, 21)
            cmbxAmbientSndNight2.Size = size
            Me.cmbxAmbientSndNight.TabIndex = 2
            Me.cmbxAmbientSndDay.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxAmbientSndDay As Global.System.Windows.Forms.Control = Me.cmbxAmbientSndDay
            point = New Global.System.Drawing.Point(168, 40)
            cmbxAmbientSndDay.Location = point
            Me.cmbxAmbientSndDay.Name = "cmbxAmbientSndDay"
            Dim cmbxAmbientSndDay2 As Global.System.Windows.Forms.Control = Me.cmbxAmbientSndDay
            size = New Global.System.Drawing.Size(200, 21)
            cmbxAmbientSndDay2.Size = size
            Me.cmbxAmbientSndDay.TabIndex = 0
            Dim label135 As Global.System.Windows.Forms.Control = Me.Label53
            point = New Global.System.Drawing.Point(24, 68)
            label135.Location = point
            Me.Label53.Name = "Label53"
            Dim label136 As Global.System.Windows.Forms.Control = Me.Label53
            size = New Global.System.Drawing.Size(88, 16)
            label136.Size = size
            Me.Label53.TabIndex = 19
            Me.Label53.Text = "Volume"
            Me.Label53.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label137 As Global.System.Windows.Forms.Control = Me.Label54
            point = New Global.System.Drawing.Point(24, 120)
            label137.Location = point
            Me.Label54.Name = "Label54"
            Dim label138 As Global.System.Windows.Forms.Control = Me.Label54
            size = New Global.System.Drawing.Size(120, 16)
            label138.Size = size
            Me.Label54.TabIndex = 19
            Me.Label54.Text = "Ambient Sound - Night"
            Me.Label54.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label139 As Global.System.Windows.Forms.Control = Me.Label55
            point = New Global.System.Drawing.Point(24, 148)
            label139.Location = point
            Me.Label55.Name = "Label55"
            Dim label140 As Global.System.Windows.Forms.Control = Me.Label55
            size = New Global.System.Drawing.Size(88, 16)
            label140.Size = size
            Me.Label55.TabIndex = 19
            Me.Label55.Text = "Volume"
            Me.Label55.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label141 As Global.System.Windows.Forms.Control = Me.Label56
            point = New Global.System.Drawing.Point(24, 205)
            label141.Location = point
            Me.Label56.Name = "Label56"
            Dim label142 As Global.System.Windows.Forms.Control = Me.Label56
            size = New Global.System.Drawing.Size(88, 24)
            label142.Size = size
            Me.Label56.TabIndex = 19
            Me.Label56.Text = "Environmental Audio Effects"
            Me.Label56.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label143 As Global.System.Windows.Forms.Control = Me.Label57
            point = New Global.System.Drawing.Point(24, 240)
            label143.Location = point
            Me.Label57.Name = "Label57"
            Dim label144 As Global.System.Windows.Forms.Control = Me.Label57
            size = New Global.System.Drawing.Size(88, 16)
            label144.Size = size
            Me.Label57.TabIndex = 19
            Me.Label57.Text = "Battle Music"
            Me.Label57.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label145 As Global.System.Windows.Forms.Control = Me.Label58
            point = New Global.System.Drawing.Point(24, 272)
            label145.Location = point
            Me.Label58.Name = "Label58"
            Dim label146 As Global.System.Windows.Forms.Control = Me.Label58
            size = New Global.System.Drawing.Size(88, 16)
            label146.Size = size
            Me.Label58.TabIndex = 19
            Me.Label58.Text = "Daytime Music"
            Me.Label58.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label147 As Global.System.Windows.Forms.Control = Me.Label59
            point = New Global.System.Drawing.Point(24, 304)
            label147.Location = point
            Me.Label59.Name = "Label59"
            Dim label148 As Global.System.Windows.Forms.Control = Me.Label59
            size = New Global.System.Drawing.Size(88, 16)
            label148.Size = size
            Me.Label59.TabIndex = 19
            Me.Label59.Text = "Nighttime Music"
            Me.Label59.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label149 As Global.System.Windows.Forms.Control = Me.Label60
            point = New Global.System.Drawing.Point(24, 336)
            label149.Location = point
            Me.Label60.Name = "Label60"
            Dim label150 As Global.System.Windows.Forms.Control = Me.Label60
            size = New Global.System.Drawing.Size(88, 16)
            label150.Size = size
            Me.Label60.TabIndex = 19
            Me.Label60.Text = "Music Delay"
            Me.Label60.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label151 As Global.System.Windows.Forms.Control = Me.Label61
            point = New Global.System.Drawing.Point(224, 338)
            label151.Location = point
            Me.Label61.Name = "Label61"
            Dim label152 As Global.System.Windows.Forms.Control = Me.Label61
            size = New Global.System.Drawing.Size(88, 16)
            label152.Size = size
            Me.Label61.TabIndex = 19
            Me.Label61.Text = "Seconds"
            Me.Label61.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tabpagArea_Events.Controls.Add(Me.Label77)
            Me.tabpagArea_Events.Controls.Add(Me.tbArea_OnUserDefined)
            Me.tabpagArea_Events.Controls.Add(Me.tbArea_OnHeartbeat)
            Me.tabpagArea_Events.Controls.Add(Me.Label76)
            Me.tabpagArea_Events.Controls.Add(Me.Label74)
            Me.tabpagArea_Events.Controls.Add(Me.tbArea_OnEnter)
            Me.tabpagArea_Events.Controls.Add(Me.Label75)
            Me.tabpagArea_Events.Controls.Add(Me.tbArea_OnExit)
            Dim tabpagArea_Events As Global.System.Windows.Forms.Control = Me.tabpagArea_Events
            point = New Global.System.Drawing.Point(4, 22)
            tabpagArea_Events.Location = point
            Me.tabpagArea_Events.Name = "tabpagArea_Events"
            Dim tabpagArea_Events2 As Global.System.Windows.Forms.Control = Me.tabpagArea_Events
            size = New Global.System.Drawing.Size(480, 444)
            tabpagArea_Events2.Size = size
            Me.tabpagArea_Events.TabIndex = 6
            Me.tabpagArea_Events.Text = "Events"
            Dim label153 As Global.System.Windows.Forms.Control = Me.Label77
            point = New Global.System.Drawing.Point(24, 112)
            label153.Location = point
            Me.Label77.Name = "Label77"
            Dim label154 As Global.System.Windows.Forms.Control = Me.Label77
            size = New Global.System.Drawing.Size(100, 18)
            label154.Size = size
            Me.Label77.TabIndex = 36
            Me.Label77.Text = "OnUserDefined"
            Me.Label77.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbArea_OnUserDefined.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbArea_OnUserDefined As Global.System.Windows.Forms.Control = Me.tbArea_OnUserDefined
            point = New Global.System.Drawing.Point(136, 112)
            tbArea_OnUserDefined.Location = point
            Me.tbArea_OnUserDefined.MaxLength = 16
            Me.tbArea_OnUserDefined.Name = "tbArea_OnUserDefined"
            Dim tbArea_OnUserDefined2 As Global.System.Windows.Forms.Control = Me.tbArea_OnUserDefined
            size = New Global.System.Drawing.Size(204, 20)
            tbArea_OnUserDefined2.Size = size
            Me.tbArea_OnUserDefined.TabIndex = 35
            Me.tbArea_OnUserDefined.Text = ""
            Me.tbArea_OnHeartbeat.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbArea_OnHeartbeat As Global.System.Windows.Forms.Control = Me.tbArea_OnHeartbeat
            point = New Global.System.Drawing.Point(136, 88)
            tbArea_OnHeartbeat.Location = point
            Me.tbArea_OnHeartbeat.MaxLength = 16
            Me.tbArea_OnHeartbeat.Name = "tbArea_OnHeartbeat"
            Dim tbArea_OnHeartbeat2 As Global.System.Windows.Forms.Control = Me.tbArea_OnHeartbeat
            size = New Global.System.Drawing.Size(204, 20)
            tbArea_OnHeartbeat2.Size = size
            Me.tbArea_OnHeartbeat.TabIndex = 33
            Me.tbArea_OnHeartbeat.Text = ""
            Dim label155 As Global.System.Windows.Forms.Control = Me.Label76
            point = New Global.System.Drawing.Point(24, 88)
            label155.Location = point
            Me.Label76.Name = "Label76"
            Dim label156 As Global.System.Windows.Forms.Control = Me.Label76
            size = New Global.System.Drawing.Size(100, 18)
            label156.Size = size
            Me.Label76.TabIndex = 34
            Me.Label76.Text = "OnHeartbeat"
            Me.Label76.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label157 As Global.System.Windows.Forms.Control = Me.Label74
            point = New Global.System.Drawing.Point(24, 40)
            label157.Location = point
            Me.Label74.Name = "Label74"
            Dim label158 As Global.System.Windows.Forms.Control = Me.Label74
            size = New Global.System.Drawing.Size(100, 18)
            label158.Size = size
            Me.Label74.TabIndex = 32
            Me.Label74.Text = "OnEnter"
            Me.Label74.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbArea_OnEnter.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbArea_OnEnter As Global.System.Windows.Forms.Control = Me.tbArea_OnEnter
            point = New Global.System.Drawing.Point(136, 40)
            tbArea_OnEnter.Location = point
            Me.tbArea_OnEnter.MaxLength = 16
            Me.tbArea_OnEnter.Name = "tbArea_OnEnter"
            Dim tbArea_OnEnter2 As Global.System.Windows.Forms.Control = Me.tbArea_OnEnter
            size = New Global.System.Drawing.Size(204, 20)
            tbArea_OnEnter2.Size = size
            Me.tbArea_OnEnter.TabIndex = 29
            Me.tbArea_OnEnter.Text = ""
            Dim label159 As Global.System.Windows.Forms.Control = Me.Label75
            point = New Global.System.Drawing.Point(24, 64)
            label159.Location = point
            Me.Label75.Name = "Label75"
            Dim label160 As Global.System.Windows.Forms.Control = Me.Label75
            size = New Global.System.Drawing.Size(100, 18)
            label160.Size = size
            Me.Label75.TabIndex = 31
            Me.Label75.Text = "OnExit"
            Me.Label75.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbArea_OnExit.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbArea_OnExit As Global.System.Windows.Forms.Control = Me.tbArea_OnExit
            point = New Global.System.Drawing.Point(136, 64)
            tbArea_OnExit.Location = point
            Me.tbArea_OnExit.MaxLength = 16
            Me.tbArea_OnExit.Name = "tbArea_OnExit"
            Dim tbArea_OnExit2 As Global.System.Windows.Forms.Control = Me.tbArea_OnExit
            size = New Global.System.Drawing.Size(204, 20)
            tbArea_OnExit2.Size = size
            Me.tbArea_OnExit.TabIndex = 30
            Me.tbArea_OnExit.Text = ""
            Me.tabpagAreaRooms.Controls.Add(Me.lbRooms)
            Me.tabpagAreaRooms.Controls.Add(Me.Label82)
            Me.tabpagAreaRooms.Controls.Add(Me.chkbRoomDisableWeather)
            Me.tabpagAreaRooms.Controls.Add(Me.nudRoomAmbientScale)
            Me.tabpagAreaRooms.Controls.Add(Me.Label80)
            Me.tabpagAreaRooms.Controls.Add(Me.cmbxRoomEnvAudio)
            Me.tabpagAreaRooms.Controls.Add(Me.Label79)
            Me.tabpagAreaRooms.Controls.Add(Me.Label78)
            Me.tabpagAreaRooms.Controls.Add(Me.tbRoomName)
            Me.tabpagAreaRooms.Controls.Add(Me.nudRoomForceRating)
            Me.tabpagAreaRooms.Controls.Add(Me.Label81)
            Me.tabpagAreaRooms.Controls.Add(Me.Label83)
            Dim tabpagAreaRooms As Global.System.Windows.Forms.Control = Me.tabpagAreaRooms
            point = New Global.System.Drawing.Point(4, 22)
            tabpagAreaRooms.Location = point
            Me.tabpagAreaRooms.Name = "tabpagAreaRooms"
            Dim tabpagAreaRooms2 As Global.System.Windows.Forms.Control = Me.tabpagAreaRooms
            size = New Global.System.Drawing.Size(480, 444)
            tabpagAreaRooms2.Size = size
            Me.tabpagAreaRooms.TabIndex = 7
            Me.tabpagAreaRooms.Text = "Rooms"
            Dim lbRooms As Global.System.Windows.Forms.Control = Me.lbRooms
            point = New Global.System.Drawing.Point(176, 40)
            lbRooms.Location = point
            Me.lbRooms.Name = "lbRooms"
            Me.lbRooms.ScrollAlwaysVisible = True
            Dim lbRooms2 As Global.System.Windows.Forms.Control = Me.lbRooms
            size = New Global.System.Drawing.Size(96, 95)
            lbRooms2.Size = size
            Me.lbRooms.TabIndex = 41
            Dim label161 As Global.System.Windows.Forms.Control = Me.Label82
            point = New Global.System.Drawing.Point(24, 288)
            label161.Location = point
            Me.Label82.Name = "Label82"
            Dim label162 As Global.System.Windows.Forms.Control = Me.Label82
            size = New Global.System.Drawing.Size(88, 16)
            label162.Size = size
            Me.Label82.TabIndex = 40
            Me.Label82.Text = "Disable Weather"
            Me.Label82.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbRoomDisableWeather As Global.System.Windows.Forms.Control = Me.chkbRoomDisableWeather
            point = New Global.System.Drawing.Point(184, 288)
            chkbRoomDisableWeather.Location = point
            Me.chkbRoomDisableWeather.Name = "chkbRoomDisableWeather"
            Dim chkbRoomDisableWeather2 As Global.System.Windows.Forms.Control = Me.chkbRoomDisableWeather
            size = New Global.System.Drawing.Size(32, 16)
            chkbRoomDisableWeather2.Size = size
            Me.chkbRoomDisableWeather.TabIndex = 39
            Me.nudRoomAmbientScale.DecimalPlaces = 2
            Dim nudRoomAmbientScale As Global.System.Windows.Forms.NumericUpDown = Me.nudRoomAmbientScale
            num = New Decimal(New Integer() {5, 0, 0, 131072})
            nudRoomAmbientScale.Increment = num
            Dim nudRoomAmbientScale2 As Global.System.Windows.Forms.Control = Me.nudRoomAmbientScale
            point = New Global.System.Drawing.Point(184, 224)
            nudRoomAmbientScale2.Location = point
            Dim nudRoomAmbientScale3 As Global.System.Windows.Forms.NumericUpDown = Me.nudRoomAmbientScale
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudRoomAmbientScale3.Maximum = num
            Me.nudRoomAmbientScale.Name = "nudRoomAmbientScale"
            Dim nudRoomAmbientScale4 As Global.System.Windows.Forms.Control = Me.nudRoomAmbientScale
            size = New Global.System.Drawing.Size(56, 20)
            nudRoomAmbientScale4.Size = size
            Me.nudRoomAmbientScale.TabIndex = 38
            Me.nudRoomAmbientScale.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label163 As Global.System.Windows.Forms.Control = Me.Label80
            point = New Global.System.Drawing.Point(24, 224)
            label163.Location = point
            Me.Label80.Name = "Label80"
            Dim label164 As Global.System.Windows.Forms.Control = Me.Label80
            size = New Global.System.Drawing.Size(128, 16)
            label164.Size = size
            Me.Label80.TabIndex = 37
            Me.Label80.Text = "Ambient Sound Scale"
            Me.Label80.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxRoomEnvAudio.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxRoomEnvAudio As Global.System.Windows.Forms.Control = Me.cmbxRoomEnvAudio
            point = New Global.System.Drawing.Point(184, 192)
            cmbxRoomEnvAudio.Location = point
            Me.cmbxRoomEnvAudio.Name = "cmbxRoomEnvAudio"
            Dim cmbxRoomEnvAudio2 As Global.System.Windows.Forms.Control = Me.cmbxRoomEnvAudio
            size = New Global.System.Drawing.Size(192, 21)
            cmbxRoomEnvAudio2.Size = size
            Me.cmbxRoomEnvAudio.TabIndex = 35
            Dim label165 As Global.System.Windows.Forms.Control = Me.Label79
            point = New Global.System.Drawing.Point(24, 192)
            label165.Location = point
            Me.Label79.Name = "Label79"
            Dim label166 As Global.System.Windows.Forms.Control = Me.Label79
            size = New Global.System.Drawing.Size(160, 24)
            label166.Size = size
            Me.Label79.TabIndex = 36
            Me.Label79.Text = "Environmental Audio Effects"
            Me.Label79.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label167 As Global.System.Windows.Forms.Control = Me.Label78
            point = New Global.System.Drawing.Point(24, 160)
            label167.Location = point
            Me.Label78.Name = "Label78"
            Dim label168 As Global.System.Windows.Forms.Control = Me.Label78
            size = New Global.System.Drawing.Size(100, 18)
            label168.Size = size
            Me.Label78.TabIndex = 34
            Me.Label78.Text = "Room Name"
            Me.Label78.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbRoomName.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbRoomName As Global.System.Windows.Forms.Control = Me.tbRoomName
            point = New Global.System.Drawing.Point(184, 160)
            tbRoomName.Location = point
            Me.tbRoomName.MaxLength = 16
            Me.tbRoomName.Name = "tbRoomName"
            Me.tbRoomName.[ReadOnly] = True
            Dim tbRoomName2 As Global.System.Windows.Forms.Control = Me.tbRoomName
            size = New Global.System.Drawing.Size(104, 20)
            tbRoomName2.Size = size
            Me.tbRoomName.TabIndex = 33
            Me.tbRoomName.Text = ""
            Dim nudRoomForceRating As Global.System.Windows.Forms.Control = Me.nudRoomForceRating
            point = New Global.System.Drawing.Point(184, 256)
            nudRoomForceRating.Location = point
            Dim nudRoomForceRating2 As Global.System.Windows.Forms.NumericUpDown = Me.nudRoomForceRating
            num = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
            nudRoomForceRating2.Minimum = num
            Me.nudRoomForceRating.Name = "nudRoomForceRating"
            Dim nudRoomForceRating3 As Global.System.Windows.Forms.Control = Me.nudRoomForceRating
            size = New Global.System.Drawing.Size(56, 20)
            nudRoomForceRating3.Size = size
            Me.nudRoomForceRating.TabIndex = 38
            Me.nudRoomForceRating.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label169 As Global.System.Windows.Forms.Control = Me.Label81
            point = New Global.System.Drawing.Point(24, 256)
            label169.Location = point
            Me.Label81.Name = "Label81"
            Dim label170 As Global.System.Windows.Forms.Control = Me.Label81
            size = New Global.System.Drawing.Size(128, 16)
            label170.Size = size
            Me.Label81.TabIndex = 37
            Me.Label81.Text = "Force Rating"
            Me.Label81.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label171 As Global.System.Windows.Forms.Control = Me.Label83
            point = New Global.System.Drawing.Point(24, 72)
            label171.Location = point
            Me.Label83.Name = "Label83"
            Dim label172 As Global.System.Windows.Forms.Control = Me.Label83
            size = New Global.System.Drawing.Size(100, 18)
            label172.Size = size
            Me.Label83.TabIndex = 34
            Me.Label83.Text = "Rooms"
            Me.Label83.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(320, 532)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&OK"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(416, 532)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancel"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(528, 565)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.TabControlMain)
            Me.Name = "frmModuleIfo_AreaEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Module Properties Editor"
            Me.TabControlModule.ResumeLayout(False)
            Me.tabpagModuleBasic.ResumeLayout(False)
            CType(Me.nudXY, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudModEntryX, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudModEntryY, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudModEntryZ, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagModuleAdvanced.ResumeLayout(False)
            CType(Me.nudXPScale, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarXPScale, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMinutesPerHour, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDawnStartHour, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDuskStartHour, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStartHour, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStartDay, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStartMonth, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStartYear, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagModuleEvents.ResumeLayout(False)
            Me.tabpagModuleDescription.ResumeLayout(False)
            Me.TabControlMain.ResumeLayout(False)
            Me.TabPage5.ResumeLayout(False)
            Me.TabPage6.ResumeLayout(False)
            Me.TabControlArea.ResumeLayout(False)
            Me.tabpagAreaBasic.ResumeLayout(False)
            CType(Me.NumericUpDown10, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NumericUpDown11, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NumericUpDown12, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAreaEnvironment.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.nudChanceSnow, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudChanceRain, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudChanceLightning, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbMoon.ResumeLayout(False)
            CType(Me.trkbarMoonFogNear, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarMoonFogFar, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbSun.ResumeLayout(False)
            CType(Me.trkbarSunFogNear, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarSunFogFar, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudShadowOpacity, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAreaGrass.ResumeLayout(False)
            CType(Me.nudGrassDensity, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarGrassDensityX10, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassProbUL, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassProbLL, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassProbUR, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassProbLR, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassQuadSize, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAreaAudio.ResumeLayout(False)
            CType(Me.trkbarAmbientSndNightVol, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarAmbientSndDayVol, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMusicDelay, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagArea_Events.ResumeLayout(False)
            Me.tabpagAreaRooms.ResumeLayout(False)
            CType(Me.nudRoomAmbientScale, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRoomForceRating, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040005AF RID: 1455
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
