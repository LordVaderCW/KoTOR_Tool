Namespace kotor_tool
	' Token: 0x02000061 RID: 97
	Public Partial Class frmModuleIfo_AreaEditor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label34 As Global.System.Windows.Forms.Label
        Friend WithEvents Label33 As Global.System.Windows.Forms.Label
        Friend WithEvents Label32 As Global.System.Windows.Forms.Label
        Friend WithEvents Label35 As Global.System.Windows.Forms.Label
        Friend WithEvents Label36 As Global.System.Windows.Forms.Label
        Friend WithEvents Label37 As Global.System.Windows.Forms.Label
        Friend WithEvents Label38 As Global.System.Windows.Forms.Label
        Friend WithEvents Label39 As Global.System.Windows.Forms.Label
        Friend WithEvents Label40 As Global.System.Windows.Forms.Label
        Friend WithEvents Label41 As Global.System.Windows.Forms.Label
        Friend WithEvents Label42 As Global.System.Windows.Forms.Label
        Friend WithEvents Label43 As Global.System.Windows.Forms.Label
        Friend WithEvents Label44 As Global.System.Windows.Forms.Label
        Friend WithEvents Label46 As Global.System.Windows.Forms.Label
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents nudXPScale As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents trkbarXPScale As Global.System.Windows.Forms.TrackBar
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents btnSetDescriptionLang As Global.System.Windows.Forms.Button
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents TabPage5 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage6 As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents NumericUpDown10 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents NumericUpDown11 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents NumericUpDown12 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents TabControlModule As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabControlMain As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabControlArea As Global.System.Windows.Forms.TabControl
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents ColorDialog1 As Global.System.Windows.Forms.ColorDialog
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents btnGrassDiffuseColor As Global.System.Windows.Forms.Button
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents btnGrassAmbientColor As Global.System.Windows.Forms.Button
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents btnGrassEmissiveColor As Global.System.Windows.Forms.Button
        Friend WithEvents tabpagAreaBasic As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagAreaGrass As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagAreaEnvironment As Global.System.Windows.Forms.TabPage
        Friend WithEvents btnSunDiffuseColor As Global.System.Windows.Forms.Button
        Friend WithEvents Label26 As Global.System.Windows.Forms.Label
        Friend WithEvents Label27 As Global.System.Windows.Forms.Label
        Friend WithEvents btnSunAmbientColor As Global.System.Windows.Forms.Button
        Friend WithEvents gbSun As Global.System.Windows.Forms.GroupBox
        Friend WithEvents gbMoon As Global.System.Windows.Forms.GroupBox
        Friend WithEvents btnMoonDiffuseColor As Global.System.Windows.Forms.Button
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents btnMoonAmbientColor As Global.System.Windows.Forms.Button
        Friend WithEvents rbDayNightCycle As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbAlwaysDay As Global.System.Windows.Forms.RadioButton
        Friend WithEvents Label28 As Global.System.Windows.Forms.Label
        Friend WithEvents Label29 As Global.System.Windows.Forms.Label
        Friend WithEvents Label30 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbAreaSunShadows As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label31 As Global.System.Windows.Forms.Label
        Friend WithEvents Label45 As Global.System.Windows.Forms.Label
        Friend WithEvents Label47 As Global.System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents Label49 As Global.System.Windows.Forms.Label
        Friend WithEvents Label50 As Global.System.Windows.Forms.Label
        Friend WithEvents Label51 As Global.System.Windows.Forms.Label
        Friend WithEvents tabpagAreaAudio As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label52 As Global.System.Windows.Forms.Label
        Friend WithEvents Label53 As Global.System.Windows.Forms.Label
        Friend WithEvents Label54 As Global.System.Windows.Forms.Label
        Friend WithEvents Label55 As Global.System.Windows.Forms.Label
        Friend WithEvents Label56 As Global.System.Windows.Forms.Label
        Friend WithEvents Label57 As Global.System.Windows.Forms.Label
        Friend WithEvents Label58 As Global.System.Windows.Forms.Label
        Friend WithEvents Label59 As Global.System.Windows.Forms.Label
        Friend WithEvents Label60 As Global.System.Windows.Forms.Label
        Friend WithEvents Label61 As Global.System.Windows.Forms.Label
        Friend WithEvents tabpagModuleBasic As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagModuleAdvanced As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagModuleEvents As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagModuleDescription As Global.System.Windows.Forms.TabPage
        Friend WithEvents nudModEntryX As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudModEntryY As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudModEntryZ As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbModTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbModName As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudMinutesPerHour As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudDawnStartHour As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudDuskStartHour As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudStartHour As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudStartDay As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudStartMonth As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudStartYear As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbMod_OnClientEntr As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnActvtItem As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnAcquirItem As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnClientLeav As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnHeartbeat As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnModLoad As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnMoonFogColor As Global.System.Windows.Forms.Button
        Friend WithEvents chkbAreaMoonShadows As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnSunFogColor As Global.System.Windows.Forms.Button
        Friend WithEvents rbAlwaysNight As Global.System.Windows.Forms.RadioButton
        Friend WithEvents tbMod_OnPlrDeath As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnPlrDying As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnPlrLvlUp As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnSpawnBtnDn As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnPlrRest As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnUnAqreItem As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMod_OnUsrDefined As Global.System.Windows.Forms.TextBox
        Friend WithEvents chkbSunFogOn As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbMoonFogOn As Global.System.Windows.Forms.CheckBox
        Friend WithEvents trkbarSunFogNear As Global.System.Windows.Forms.TrackBar
        Friend WithEvents trkbarSunFogFar As Global.System.Windows.Forms.TrackBar
        Friend WithEvents trkbarMoonFogNear As Global.System.Windows.Forms.TrackBar
        Friend WithEvents trkbarMoonFogFar As Global.System.Windows.Forms.TrackBar
        Friend WithEvents nudChanceSnow As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudChanceRain As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudChanceLightning As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents btnDynAmbientColor As Global.System.Windows.Forms.Button
        Friend WithEvents Label48 As Global.System.Windows.Forms.Label
        Friend WithEvents lblMoonFogNear As Global.System.Windows.Forms.Label
        Friend WithEvents lblMoonFogFar As Global.System.Windows.Forms.Label
        Friend WithEvents lblSunFogNear As Global.System.Windows.Forms.Label
        Friend WithEvents lblSunFogFar As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents trkbarAmbientSndDayVol As Global.System.Windows.Forms.TrackBar
        Friend WithEvents cmbxAmbientSndDay As Global.System.Windows.Forms.ComboBox
        Friend WithEvents trkbarAmbientSndNightVol As Global.System.Windows.Forms.TrackBar
        Friend WithEvents nudMusicDelay As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents cmbxMusicNight As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxMusicDay As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxMusicBattle As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxEnvAudio As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxAmbientSndNight As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbGrass_TexName As Global.System.Windows.Forms.TextBox
        Friend WithEvents trkbarGrassDensityX10 As Global.System.Windows.Forms.TrackBar
        Friend WithEvents Label62 As Global.System.Windows.Forms.Label
        Friend WithEvents nudGrassDensity As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label63 As Global.System.Windows.Forms.Label
        Friend WithEvents Label64 As Global.System.Windows.Forms.Label
        Friend WithEvents Label65 As Global.System.Windows.Forms.Label
        Friend WithEvents Label66 As Global.System.Windows.Forms.Label
        Friend WithEvents Label67 As Global.System.Windows.Forms.Label
        Friend WithEvents nudGrassProbUL As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudGrassProbLL As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudGrassProbUR As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudGrassProbLR As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblTotalGrassProbability As Global.System.Windows.Forms.Label
        Friend WithEvents Label69 As Global.System.Windows.Forms.Label
        Friend WithEvents Label70 As Global.System.Windows.Forms.Label
        Friend WithEvents Label71 As Global.System.Windows.Forms.Label
        Friend WithEvents Label72 As Global.System.Windows.Forms.Label
        Friend WithEvents Label68 As Global.System.Windows.Forms.Label
        Friend WithEvents nudGrassQuadSize As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbAreaTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbAreaName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxCameraStyle As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label73 As Global.System.Windows.Forms.Label
        Friend WithEvents nudShadowOpacity As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tabpagArea_Events As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label74 As Global.System.Windows.Forms.Label
        Friend WithEvents tbArea_OnEnter As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label75 As Global.System.Windows.Forms.Label
        Friend WithEvents tbArea_OnExit As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbArea_OnHeartbeat As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label76 As Global.System.Windows.Forms.Label
        Friend WithEvents Label77 As Global.System.Windows.Forms.Label
        Friend WithEvents tbArea_OnUserDefined As Global.System.Windows.Forms.TextBox
        Friend WithEvents tabpagAreaRooms As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label78 As Global.System.Windows.Forms.Label
        Friend WithEvents Label79 As Global.System.Windows.Forms.Label
        Friend WithEvents Label80 As Global.System.Windows.Forms.Label
        Friend WithEvents Label81 As Global.System.Windows.Forms.Label
        Friend WithEvents Label82 As Global.System.Windows.Forms.Label
        Friend WithEvents lbRooms As Global.System.Windows.Forms.ListBox
        Friend WithEvents Label83 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbRoomDisableWeather As Global.System.Windows.Forms.CheckBox
        Friend WithEvents nudRoomAmbientScale As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents cmbxRoomEnvAudio As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbRoomName As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudRoomForceRating As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbModDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnSetModNameLang As Global.System.Windows.Forms.Button
        Friend WithEvents btnSetAreaNameLang As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxWindPower As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label84 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbUnescapable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label85 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbDisableTransit As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label86 As Global.System.Windows.Forms.Label
        Friend WithEvents pboxXY As Global.System.Windows.Forms.PictureBox
        Friend WithEvents nudXY As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblBearing As Global.System.Windows.Forms.Label
        Friend WithEvents tbModEntryArea As Global.System.Windows.Forms.TextBox


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
            Me.TabControlModule.Location = New Global.System.Drawing.Point(0, 0)
            Me.TabControlModule.Name = "TabControlModule"
            Me.TabControlModule.Padding = New Global.System.Drawing.Point(12, 3)
            Me.TabControlModule.SelectedIndex = 0
            Me.TabControlModule.Size = New Global.System.Drawing.Size(488, 470)
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
            Me.tabpagModuleBasic.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagModuleBasic.Name = "tabpagModuleBasic"
            Me.tabpagModuleBasic.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagModuleBasic.TabIndex = 0
            Me.tabpagModuleBasic.Text = "Basic"
            Me.pboxXY.Location = New Global.System.Drawing.Point(312, 152)
            Me.pboxXY.Name = "pboxXY"
            Me.pboxXY.Size = New Global.System.Drawing.Size(50, 50)
            Me.pboxXY.TabIndex = 22
            Me.pboxXY.TabStop = False
            Me.nudXY.DecimalPlaces = 2
            Me.nudXY.Location = New Global.System.Drawing.Point(304, 208)
            Me.nudXY.Maximum = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            Me.nudXY.Name = "nudXY"
            Me.nudXY.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudXY.TabIndex = 23
            Me.nudXY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
            Me.lblBearing.Location = New Global.System.Drawing.Point(312, 128)
            Me.lblBearing.Name = "lblBearing"
            Me.lblBearing.Size = New Global.System.Drawing.Size(48, 16)
            Me.lblBearing.TabIndex = 21
            Me.lblBearing.Text = "Bearing"
            Me.lblBearing.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label11.Location = New Global.System.Drawing.Point(24, 144)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label11.TabIndex = 19
            Me.Label11.Text = "Starting Position X"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudModEntryX.DecimalPlaces = 4
            Me.nudModEntryX.Location = New Global.System.Drawing.Point(144, 144)
            Me.nudModEntryX.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudModEntryX.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.nudModEntryX.Name = "nudModEntryX"
            Me.nudModEntryX.Size = New Global.System.Drawing.Size(96, 20)
            Me.nudModEntryX.TabIndex = 4
            Me.nudModEntryX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label12.Location = New Global.System.Drawing.Point(24, 176)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label12.TabIndex = 20
            Me.Label12.Text = "Starting Position Y"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudModEntryY.DecimalPlaces = 4
            Me.nudModEntryY.Location = New Global.System.Drawing.Point(144, 176)
            Me.nudModEntryY.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudModEntryY.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.nudModEntryY.Name = "nudModEntryY"
            Me.nudModEntryY.Size = New Global.System.Drawing.Size(96, 20)
            Me.nudModEntryY.TabIndex = 5
            Me.nudModEntryY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label13.Location = New Global.System.Drawing.Point(24, 208)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label13.TabIndex = 18
            Me.Label13.Text = "Starting Position Z"
            Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudModEntryZ.DecimalPlaces = 4
            Me.nudModEntryZ.Location = New Global.System.Drawing.Point(144, 208)
            Me.nudModEntryZ.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudModEntryZ.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.nudModEntryZ.Name = "nudModEntryZ"
            Me.nudModEntryZ.Size = New Global.System.Drawing.Size(96, 20)
            Me.nudModEntryZ.TabIndex = 6
            Me.nudModEntryZ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.btnSetModNameLang.Location = New Global.System.Drawing.Point(296, 40)
            Me.btnSetModNameLang.Name = "btnSetModNameLang"
            Me.btnSetModNameLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetModNameLang.TabIndex = 1
            Me.btnSetModNameLang.Text = "Set Language"
            Me.tbModTag.Location = New Global.System.Drawing.Point(112, 64)
            Me.tbModTag.Name = "tbModTag"
            Me.tbModTag.Size = New Global.System.Drawing.Size(88, 20)
            Me.tbModTag.TabIndex = 2
            Me.tbModTag.Text = ""
            Me.tbModName.Location = New Global.System.Drawing.Point(112, 40)
            Me.tbModName.Name = "tbModName"
            Me.tbModName.Size = New Global.System.Drawing.Size(176, 20)
            Me.tbModName.TabIndex = 0
            Me.tbModName.Text = ""
            Me.Label8.Location = New Global.System.Drawing.Point(24, 40)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label8.TabIndex = 10
            Me.Label8.Text = "Name"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label9.Location = New Global.System.Drawing.Point(24, 64)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label9.TabIndex = 11
            Me.Label9.Text = "Tag"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbModEntryArea.Location = New Global.System.Drawing.Point(112, 104)
            Me.tbModEntryArea.Name = "tbModEntryArea"
            Me.tbModEntryArea.Size = New Global.System.Drawing.Size(176, 20)
            Me.tbModEntryArea.TabIndex = 3
            Me.tbModEntryArea.Text = ""
            Me.Label10.Location = New Global.System.Drawing.Point(16, 104)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(56, 16)
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
            Me.tabpagModuleAdvanced.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagModuleAdvanced.Name = "tabpagModuleAdvanced"
            Me.tabpagModuleAdvanced.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagModuleAdvanced.TabIndex = 2
            Me.tabpagModuleAdvanced.Text = "Advanced"
            Me.nudXPScale.Location = New Global.System.Drawing.Point(336, 272)
            Me.nudXPScale.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
            Me.nudXPScale.Name = "nudXPScale"
            Me.nudXPScale.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudXPScale.Size = New Global.System.Drawing.Size(42, 20)
            Me.nudXPScale.TabIndex = 8
            Me.nudXPScale.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.trkbarXPScale.Location = New Global.System.Drawing.Point(120, 264)
            Me.trkbarXPScale.Maximum = 200
            Me.trkbarXPScale.Name = "trkbarXPScale"
            Me.trkbarXPScale.Size = New Global.System.Drawing.Size(216, 42)
            Me.trkbarXPScale.TabIndex = 7
            Me.trkbarXPScale.TickFrequency = 10
            Me.Label46.Location = New Global.System.Drawing.Point(24, 40)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label46.TabIndex = 5
            Me.Label46.Text = "Minutes/Hour"
            Me.Label46.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudMinutesPerHour.Location = New Global.System.Drawing.Point(128, 40)
            Me.nudMinutesPerHour.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
            Me.nudMinutesPerHour.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMinutesPerHour.Name = "nudMinutesPerHour"
            Me.nudMinutesPerHour.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudMinutesPerHour.TabIndex = 0
            Me.nudMinutesPerHour.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudMinutesPerHour.Value = New Decimal(New Integer() {1, 0, 0, 0})
            Me.Label1.Location = New Global.System.Drawing.Point(24, 72)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Dawn Start Hour"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudDawnStartHour.Location = New Global.System.Drawing.Point(128, 72)
            Me.nudDawnStartHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudDawnStartHour.Name = "nudDawnStartHour"
            Me.nudDawnStartHour.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudDawnStartHour.TabIndex = 1
            Me.nudDawnStartHour.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label2.Location = New Global.System.Drawing.Point(24, 104)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Dusk Start Hour"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudDuskStartHour.Location = New Global.System.Drawing.Point(128, 104)
            Me.nudDuskStartHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudDuskStartHour.Name = "nudDuskStartHour"
            Me.nudDuskStartHour.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudDuskStartHour.TabIndex = 2
            Me.nudDuskStartHour.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label3.Location = New Global.System.Drawing.Point(24, 200)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Starting Month"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudStartHour.Location = New Global.System.Drawing.Point(128, 136)
            Me.nudStartHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudStartHour.Name = "nudStartHour"
            Me.nudStartHour.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudStartHour.TabIndex = 3
            Me.nudStartHour.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label4.Location = New Global.System.Drawing.Point(24, 168)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(72, 16)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Starting Day"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudStartDay.Location = New Global.System.Drawing.Point(128, 168)
            Me.nudStartDay.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
            Me.nudStartDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudStartDay.Name = "nudStartDay"
            Me.nudStartDay.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudStartDay.TabIndex = 4
            Me.nudStartDay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudStartDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
            Me.Label5.Location = New Global.System.Drawing.Point(24, 136)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(72, 16)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "Starting Hour"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudStartMonth.Location = New Global.System.Drawing.Point(128, 200)
            Me.nudStartMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
            Me.nudStartMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudStartMonth.Name = "nudStartMonth"
            Me.nudStartMonth.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudStartMonth.TabIndex = 5
            Me.nudStartMonth.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudStartMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
            Me.Label6.Location = New Global.System.Drawing.Point(24, 232)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(72, 16)
            Me.Label6.TabIndex = 5
            Me.Label6.Text = "Starting Year"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudStartYear.Location = New Global.System.Drawing.Point(128, 232)
            Me.nudStartYear.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudStartYear.Name = "nudStartYear"
            Me.nudStartYear.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudStartYear.TabIndex = 6
            Me.nudStartYear.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label7.Location = New Global.System.Drawing.Point(24, 272)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(56, 16)
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
            Me.tabpagModuleEvents.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagModuleEvents.Name = "tabpagModuleEvents"
            Me.tabpagModuleEvents.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagModuleEvents.TabIndex = 1
            Me.tabpagModuleEvents.Text = "Events"
            Me.Label34.Location = New Global.System.Drawing.Point(24, 88)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label34.TabIndex = 28
            Me.Label34.Text = "OnClientEnter"
            Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnClientEntr.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnClientEntr.Location = New Global.System.Drawing.Point(136, 88)
            Me.tbMod_OnClientEntr.MaxLength = 16
            Me.tbMod_OnClientEntr.Name = "tbMod_OnClientEntr"
            Me.tbMod_OnClientEntr.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnClientEntr.TabIndex = 2
            Me.tbMod_OnClientEntr.Text = ""
            Me.Label33.Location = New Global.System.Drawing.Point(24, 64)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label33.TabIndex = 18
            Me.Label33.Text = "OnActivateItem"
            Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnActvtItem.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnActvtItem.Location = New Global.System.Drawing.Point(136, 64)
            Me.tbMod_OnActvtItem.MaxLength = 16
            Me.tbMod_OnActvtItem.Name = "tbMod_OnActvtItem"
            Me.tbMod_OnActvtItem.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnActvtItem.TabIndex = 1
            Me.tbMod_OnActvtItem.Text = ""
            Me.Label32.Location = New Global.System.Drawing.Point(24, 40)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label32.TabIndex = 15
            Me.Label32.Text = "OnAcquireItem"
            Me.Label32.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnAcquirItem.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnAcquirItem.Location = New Global.System.Drawing.Point(136, 40)
            Me.tbMod_OnAcquirItem.MaxLength = 16
            Me.tbMod_OnAcquirItem.Name = "tbMod_OnAcquirItem"
            Me.tbMod_OnAcquirItem.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnAcquirItem.TabIndex = 0
            Me.tbMod_OnAcquirItem.Text = ""
            Me.Label35.Location = New Global.System.Drawing.Point(24, 112)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label35.TabIndex = 27
            Me.Label35.Text = "OnClientLeave"
            Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnClientLeav.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnClientLeav.Location = New Global.System.Drawing.Point(136, 112)
            Me.tbMod_OnClientLeav.MaxLength = 16
            Me.tbMod_OnClientLeav.Name = "tbMod_OnClientLeav"
            Me.tbMod_OnClientLeav.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnClientLeav.TabIndex = 3
            Me.tbMod_OnClientLeav.Text = ""
            Me.tbMod_OnHeartbeat.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnHeartbeat.Location = New Global.System.Drawing.Point(136, 136)
            Me.tbMod_OnHeartbeat.MaxLength = 16
            Me.tbMod_OnHeartbeat.Name = "tbMod_OnHeartbeat"
            Me.tbMod_OnHeartbeat.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnHeartbeat.TabIndex = 4
            Me.tbMod_OnHeartbeat.Text = ""
            Me.Label36.Location = New Global.System.Drawing.Point(24, 136)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label36.TabIndex = 26
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label37.Location = New Global.System.Drawing.Point(24, 160)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label37.TabIndex = 31
            Me.Label37.Text = "OnModuleLoad"
            Me.Label37.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnModLoad.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnModLoad.Location = New Global.System.Drawing.Point(136, 160)
            Me.tbMod_OnModLoad.MaxLength = 16
            Me.tbMod_OnModLoad.Name = "tbMod_OnModLoad"
            Me.tbMod_OnModLoad.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnModLoad.TabIndex = 5
            Me.tbMod_OnModLoad.Text = ""
            Me.tbMod_OnPlrDeath.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnPlrDeath.Location = New Global.System.Drawing.Point(136, 184)
            Me.tbMod_OnPlrDeath.MaxLength = 16
            Me.tbMod_OnPlrDeath.Name = "tbMod_OnPlrDeath"
            Me.tbMod_OnPlrDeath.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnPlrDeath.TabIndex = 6
            Me.tbMod_OnPlrDeath.Text = ""
            Me.Label38.Location = New Global.System.Drawing.Point(24, 184)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label38.TabIndex = 21
            Me.Label38.Text = "OnPlayerDeath"
            Me.Label38.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnPlrDying.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnPlrDying.Location = New Global.System.Drawing.Point(136, 208)
            Me.tbMod_OnPlrDying.MaxLength = 16
            Me.tbMod_OnPlrDying.Name = "tbMod_OnPlrDying"
            Me.tbMod_OnPlrDying.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnPlrDying.TabIndex = 7
            Me.tbMod_OnPlrDying.Text = ""
            Me.Label39.Location = New Global.System.Drawing.Point(24, 208)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label39.TabIndex = 20
            Me.Label39.Text = "OnPlayerDying"
            Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label40.Location = New Global.System.Drawing.Point(24, 232)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label40.TabIndex = 25
            Me.Label40.Text = "OnPlayerLevelUp"
            Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnPlrLvlUp.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnPlrLvlUp.Location = New Global.System.Drawing.Point(136, 232)
            Me.tbMod_OnPlrLvlUp.MaxLength = 16
            Me.tbMod_OnPlrLvlUp.Name = "tbMod_OnPlrLvlUp"
            Me.tbMod_OnPlrLvlUp.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnPlrLvlUp.TabIndex = 8
            Me.tbMod_OnPlrLvlUp.Text = ""
            Me.Label41.Location = New Global.System.Drawing.Point(24, 256)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label41.TabIndex = 23
            Me.Label41.Text = "OnPlayerRespawn"
            Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnSpawnBtnDn.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnSpawnBtnDn.Location = New Global.System.Drawing.Point(136, 256)
            Me.tbMod_OnSpawnBtnDn.MaxLength = 16
            Me.tbMod_OnSpawnBtnDn.Name = "tbMod_OnSpawnBtnDn"
            Me.tbMod_OnSpawnBtnDn.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnSpawnBtnDn.TabIndex = 9
            Me.tbMod_OnSpawnBtnDn.Text = ""
            Me.tbMod_OnPlrRest.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnPlrRest.Location = New Global.System.Drawing.Point(136, 280)
            Me.tbMod_OnPlrRest.MaxLength = 16
            Me.tbMod_OnPlrRest.Name = "tbMod_OnPlrRest"
            Me.tbMod_OnPlrRest.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnPlrRest.TabIndex = 10
            Me.tbMod_OnPlrRest.Text = ""
            Me.Label42.Location = New Global.System.Drawing.Point(24, 280)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label42.TabIndex = 24
            Me.Label42.Text = "OnPlayerRest"
            Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnUnAqreItem.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnUnAqreItem.Location = New Global.System.Drawing.Point(136, 304)
            Me.tbMod_OnUnAqreItem.MaxLength = 16
            Me.tbMod_OnUnAqreItem.Name = "tbMod_OnUnAqreItem"
            Me.tbMod_OnUnAqreItem.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnUnAqreItem.TabIndex = 11
            Me.tbMod_OnUnAqreItem.Text = ""
            Me.Label43.Location = New Global.System.Drawing.Point(24, 304)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUnacquireItem"
            Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label44.Location = New Global.System.Drawing.Point(24, 328)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label44.TabIndex = 29
            Me.Label44.Text = "OnUserDefined"
            Me.Label44.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbMod_OnUsrDefined.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnUsrDefined.Location = New Global.System.Drawing.Point(136, 328)
            Me.tbMod_OnUsrDefined.MaxLength = 16
            Me.tbMod_OnUsrDefined.Name = "tbMod_OnUsrDefined"
            Me.tbMod_OnUsrDefined.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbMod_OnUsrDefined.TabIndex = 12
            Me.tbMod_OnUsrDefined.Text = ""
            Me.tabpagModuleDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.tabpagModuleDescription.Controls.Add(Me.tbModDescription)
            Me.tabpagModuleDescription.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagModuleDescription.Name = "tabpagModuleDescription"
            Me.tabpagModuleDescription.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagModuleDescription.TabIndex = 3
            Me.tabpagModuleDescription.Text = "Description"
            Me.btnSetDescriptionLang.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSetDescriptionLang.Location = New Global.System.Drawing.Point(368, 414)
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Me.btnSetDescriptionLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetDescriptionLang.TabIndex = 1
            Me.btnSetDescriptionLang.Text = "Set Language"
            Me.tbModDescription.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbModDescription.Location = New Global.System.Drawing.Point(16, 8)
            Me.tbModDescription.Multiline = True
            Me.tbModDescription.Name = "tbModDescription"
            Me.tbModDescription.Size = New Global.System.Drawing.Size(448, 391)
            Me.tbModDescription.TabIndex = 0
            Me.tbModDescription.Text = ""
            Me.TabControlMain.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControlMain.Controls.Add(Me.TabPage5)
            Me.TabControlMain.Controls.Add(Me.TabPage6)
            Me.TabControlMain.Location = New Global.System.Drawing.Point(16, 24)
            Me.TabControlMain.Name = "TabControlMain"
            Me.TabControlMain.Padding = New Global.System.Drawing.Point(12, 3)
            Me.TabControlMain.SelectedIndex = 0
            Me.TabControlMain.Size = New Global.System.Drawing.Size(496, 496)
            Me.TabControlMain.TabIndex = 1
            Me.TabPage5.Controls.Add(Me.TabControlModule)
            Me.TabPage5.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Size = New Global.System.Drawing.Size(488, 470)
            Me.TabPage5.TabIndex = 0
            Me.TabPage5.Text = "Module"
            Me.TabPage6.Controls.Add(Me.TabControlArea)
            Me.TabPage6.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage6.Name = "TabPage6"
            Me.TabPage6.Size = New Global.System.Drawing.Size(488, 470)
            Me.TabPage6.TabIndex = 1
            Me.TabPage6.Text = "Area"
            Me.TabControlArea.Controls.Add(Me.tabpagAreaBasic)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaEnvironment)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaGrass)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaAudio)
            Me.TabControlArea.Controls.Add(Me.tabpagArea_Events)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaRooms)
            Me.TabControlArea.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.TabControlArea.Location = New Global.System.Drawing.Point(0, 0)
            Me.TabControlArea.Name = "TabControlArea"
            Me.TabControlArea.Padding = New Global.System.Drawing.Point(12, 3)
            Me.TabControlArea.SelectedIndex = 0
            Me.TabControlArea.Size = New Global.System.Drawing.Size(488, 470)
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
            Me.tabpagAreaBasic.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagAreaBasic.Name = "tabpagAreaBasic"
            Me.tabpagAreaBasic.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagAreaBasic.TabIndex = 1
            Me.tabpagAreaBasic.Text = "Basic"
            Me.chkbUnescapable.Location = New Global.System.Drawing.Point(112, 144)
            Me.chkbUnescapable.Name = "chkbUnescapable"
            Me.chkbUnescapable.Size = New Global.System.Drawing.Size(32, 24)
            Me.chkbUnescapable.TabIndex = 23
            Me.Label19.Location = New Global.System.Drawing.Point(16, 104)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label19.TabIndex = 22
            Me.Label19.Text = "Camera Style"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxCameraStyle.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxCameraStyle.Location = New Global.System.Drawing.Point(112, 104)
            Me.cmbxCameraStyle.Name = "cmbxCameraStyle"
            Me.cmbxCameraStyle.Size = New Global.System.Drawing.Size(120, 21)
            Me.cmbxCameraStyle.TabIndex = 21
            Me.Label14.BackColor = Global.System.Drawing.Color.Red
            Me.Label14.Location = New Global.System.Drawing.Point(88, 328)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label14.TabIndex = 19
            Me.Label14.Text = "Starting Position X"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label14.Visible = False
            Me.NumericUpDown10.BackColor = Global.System.Drawing.Color.Red
            Me.NumericUpDown10.DecimalPlaces = 4
            Me.NumericUpDown10.Location = New Global.System.Drawing.Point(208, 328)
            Me.NumericUpDown10.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.NumericUpDown10.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.NumericUpDown10.Name = "NumericUpDown10"
            Me.NumericUpDown10.Size = New Global.System.Drawing.Size(96, 20)
            Me.NumericUpDown10.TabIndex = 16
            Me.NumericUpDown10.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown10.Visible = False
            Me.Label15.BackColor = Global.System.Drawing.Color.Red
            Me.Label15.Location = New Global.System.Drawing.Point(88, 360)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label15.TabIndex = 20
            Me.Label15.Text = "Starting Position Y"
            Me.Label15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label15.Visible = False
            Me.NumericUpDown11.BackColor = Global.System.Drawing.Color.Red
            Me.NumericUpDown11.DecimalPlaces = 4
            Me.NumericUpDown11.Location = New Global.System.Drawing.Point(208, 360)
            Me.NumericUpDown11.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.NumericUpDown11.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.NumericUpDown11.Name = "NumericUpDown11"
            Me.NumericUpDown11.Size = New Global.System.Drawing.Size(96, 20)
            Me.NumericUpDown11.TabIndex = 15
            Me.NumericUpDown11.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown11.Visible = False
            Me.Label16.BackColor = Global.System.Drawing.Color.Red
            Me.Label16.Location = New Global.System.Drawing.Point(88, 392)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label16.TabIndex = 18
            Me.Label16.Text = "Starting Position Z"
            Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label16.Visible = False
            Me.NumericUpDown12.BackColor = Global.System.Drawing.Color.Red
            Me.NumericUpDown12.DecimalPlaces = 4
            Me.NumericUpDown12.Location = New Global.System.Drawing.Point(208, 392)
            Me.NumericUpDown12.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.NumericUpDown12.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.NumericUpDown12.Name = "NumericUpDown12"
            Me.NumericUpDown12.Size = New Global.System.Drawing.Size(96, 20)
            Me.NumericUpDown12.TabIndex = 17
            Me.NumericUpDown12.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown12.Visible = False
            Me.btnSetAreaNameLang.Location = New Global.System.Drawing.Point(376, 40)
            Me.btnSetAreaNameLang.Name = "btnSetAreaNameLang"
            Me.btnSetAreaNameLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetAreaNameLang.TabIndex = 1
            Me.btnSetAreaNameLang.Text = "Set Language"
            Me.tbAreaTag.Location = New Global.System.Drawing.Point(112, 64)
            Me.tbAreaTag.Name = "tbAreaTag"
            Me.tbAreaTag.Size = New Global.System.Drawing.Size(104, 20)
            Me.tbAreaTag.TabIndex = 2
            Me.tbAreaTag.Text = ""
            Me.tbAreaName.Location = New Global.System.Drawing.Point(112, 40)
            Me.tbAreaName.Name = "tbAreaName"
            Me.tbAreaName.Size = New Global.System.Drawing.Size(256, 20)
            Me.tbAreaName.TabIndex = 0
            Me.tbAreaName.Text = ""
            Me.Label17.Location = New Global.System.Drawing.Point(24, 40)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label17.TabIndex = 10
            Me.Label17.Text = "Name"
            Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label18.Location = New Global.System.Drawing.Point(24, 64)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label18.TabIndex = 11
            Me.Label18.Text = "Tag"
            Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label85.Location = New Global.System.Drawing.Point(16, 148)
            Me.Label85.Name = "Label85"
            Me.Label85.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label85.TabIndex = 22
            Me.Label85.Text = "Unescapable"
            Me.Label85.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbDisableTransit.Location = New Global.System.Drawing.Point(112, 176)
            Me.chkbDisableTransit.Name = "chkbDisableTransit"
            Me.chkbDisableTransit.Size = New Global.System.Drawing.Size(32, 24)
            Me.chkbDisableTransit.TabIndex = 23
            Me.Label86.Location = New Global.System.Drawing.Point(16, 180)
            Me.Label86.Name = "Label86"
            Me.Label86.Size = New Global.System.Drawing.Size(88, 16)
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
            Me.tabpagAreaEnvironment.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagAreaEnvironment.Name = "tabpagAreaEnvironment"
            Me.tabpagAreaEnvironment.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagAreaEnvironment.TabIndex = 4
            Me.tabpagAreaEnvironment.Text = "Environment"
            Me.cmbxWindPower.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxWindPower.Items.AddRange(New Object() {"Calm", "Light", "Heavy"})
            Me.cmbxWindPower.Location = New Global.System.Drawing.Point(328, 358)
            Me.cmbxWindPower.Name = "cmbxWindPower"
            Me.cmbxWindPower.Size = New Global.System.Drawing.Size(112, 21)
            Me.cmbxWindPower.TabIndex = 26
            Me.GroupBox1.Controls.Add(Me.Label49)
            Me.GroupBox1.Controls.Add(Me.nudChanceSnow)
            Me.GroupBox1.Controls.Add(Me.Label50)
            Me.GroupBox1.Controls.Add(Me.nudChanceRain)
            Me.GroupBox1.Controls.Add(Me.Label51)
            Me.GroupBox1.Controls.Add(Me.nudChanceLightning)
            Me.GroupBox1.Location = New Global.System.Drawing.Point(16, 344)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New Global.System.Drawing.Size(200, 88)
            Me.GroupBox1.TabIndex = 25
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Weather"
            Me.Label49.Location = New Global.System.Drawing.Point(8, 16)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label49.TabIndex = 24
            Me.Label49.Text = "% Chance Snow"
            Me.Label49.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudChanceSnow.Location = New Global.System.Drawing.Point(128, 16)
            Me.nudChanceSnow.Name = "nudChanceSnow"
            Me.nudChanceSnow.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudChanceSnow.TabIndex = 0
            Me.nudChanceSnow.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label50.Location = New Global.System.Drawing.Point(8, 40)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label50.TabIndex = 24
            Me.Label50.Text = "% Chance Rain"
            Me.Label50.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudChanceRain.Location = New Global.System.Drawing.Point(128, 40)
            Me.nudChanceRain.Name = "nudChanceRain"
            Me.nudChanceRain.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudChanceRain.TabIndex = 1
            Me.nudChanceRain.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label51.Location = New Global.System.Drawing.Point(8, 64)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label51.TabIndex = 24
            Me.Label51.Text = "% Chance Lightning"
            Me.Label51.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudChanceLightning.Location = New Global.System.Drawing.Point(128, 64)
            Me.nudChanceLightning.Name = "nudChanceLightning"
            Me.nudChanceLightning.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudChanceLightning.TabIndex = 2
            Me.nudChanceLightning.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.rbDayNightCycle.Checked = True
            Me.rbDayNightCycle.Location = New Global.System.Drawing.Point(40, 8)
            Me.rbDayNightCycle.Name = "rbDayNightCycle"
            Me.rbDayNightCycle.Size = New Global.System.Drawing.Size(152, 16)
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
            Me.gbMoon.Location = New Global.System.Drawing.Point(16, 200)
            Me.gbMoon.Name = "gbMoon"
            Me.gbMoon.Size = New Global.System.Drawing.Size(448, 136)
            Me.gbMoon.TabIndex = 21
            Me.gbMoon.TabStop = False
            Me.gbMoon.Text = "Moon"
            Me.btnMoonDiffuseColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnMoonDiffuseColor.Location = New Global.System.Drawing.Point(112, 40)
            Me.btnMoonDiffuseColor.Name = "btnMoonDiffuseColor"
            Me.btnMoonDiffuseColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnMoonDiffuseColor.TabIndex = 1
            Me.Label24.Location = New Global.System.Drawing.Point(16, 16)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label24.TabIndex = 21
            Me.Label24.Text = "Ambient Color"
            Me.Label24.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label25.Location = New Global.System.Drawing.Point(16, 40)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label25.TabIndex = 20
            Me.Label25.Text = "Diffuse Color"
            Me.Label25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnMoonAmbientColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnMoonAmbientColor.Location = New Global.System.Drawing.Point(112, 16)
            Me.btnMoonAmbientColor.Name = "btnMoonAmbientColor"
            Me.btnMoonAmbientColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnMoonAmbientColor.TabIndex = 0
            Me.Label31.Location = New Global.System.Drawing.Point(16, 112)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label31.TabIndex = 16
            Me.Label31.Text = "Shadows"
            Me.Label31.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label45.Location = New Global.System.Drawing.Point(16, 88)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label45.TabIndex = 16
            Me.Label45.Text = "Fog Color"
            Me.Label45.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnMoonFogColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnMoonFogColor.Location = New Global.System.Drawing.Point(112, 88)
            Me.btnMoonFogColor.Name = "btnMoonFogColor"
            Me.btnMoonFogColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnMoonFogColor.TabIndex = 3
            Me.chkbAreaMoonShadows.Location = New Global.System.Drawing.Point(112, 112)
            Me.chkbAreaMoonShadows.Name = "chkbAreaMoonShadows"
            Me.chkbAreaMoonShadows.Size = New Global.System.Drawing.Size(32, 16)
            Me.chkbAreaMoonShadows.TabIndex = 4
            Me.Label47.Location = New Global.System.Drawing.Point(16, 64)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label47.TabIndex = 16
            Me.Label47.Text = "Fog Enabled"
            Me.Label47.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbMoonFogOn.Location = New Global.System.Drawing.Point(112, 64)
            Me.chkbMoonFogOn.Name = "chkbMoonFogOn"
            Me.chkbMoonFogOn.Size = New Global.System.Drawing.Size(32, 16)
            Me.chkbMoonFogOn.TabIndex = 2
            Me.trkbarMoonFogNear.Enabled = False
            Me.trkbarMoonFogNear.Location = New Global.System.Drawing.Point(232, 24)
            Me.trkbarMoonFogNear.Maximum = 2000
            Me.trkbarMoonFogNear.Name = "trkbarMoonFogNear"
            Me.trkbarMoonFogNear.Size = New Global.System.Drawing.Size(200, 42)
            Me.trkbarMoonFogNear.TabIndex = 5
            Me.trkbarMoonFogNear.TickFrequency = 50
            Me.trkbarMoonFogNear.TickStyle = Global.System.Windows.Forms.TickStyle.TopLeft
            Me.lblMoonFogNear.Enabled = False
            Me.lblMoonFogNear.Location = New Global.System.Drawing.Point(160, 32)
            Me.lblMoonFogNear.Name = "lblMoonFogNear"
            Me.lblMoonFogNear.Size = New Global.System.Drawing.Size(64, 16)
            Me.lblMoonFogNear.TabIndex = 16
            Me.lblMoonFogNear.Text = "Fog Near"
            Me.lblMoonFogNear.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.trkbarMoonFogFar.Enabled = False
            Me.trkbarMoonFogFar.Location = New Global.System.Drawing.Point(232, 88)
            Me.trkbarMoonFogFar.Maximum = 2000
            Me.trkbarMoonFogFar.Name = "trkbarMoonFogFar"
            Me.trkbarMoonFogFar.Size = New Global.System.Drawing.Size(200, 42)
            Me.trkbarMoonFogFar.TabIndex = 6
            Me.trkbarMoonFogFar.TickFrequency = 50
            Me.trkbarMoonFogFar.TickStyle = Global.System.Windows.Forms.TickStyle.TopLeft
            Me.lblMoonFogFar.Enabled = False
            Me.lblMoonFogFar.Location = New Global.System.Drawing.Point(160, 88)
            Me.lblMoonFogFar.Name = "lblMoonFogFar"
            Me.lblMoonFogFar.Size = New Global.System.Drawing.Size(64, 16)
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
            Me.gbSun.Location = New Global.System.Drawing.Point(16, 56)
            Me.gbSun.Name = "gbSun"
            Me.gbSun.Size = New Global.System.Drawing.Size(448, 136)
            Me.gbSun.TabIndex = 20
            Me.gbSun.TabStop = False
            Me.gbSun.Text = "Sun"
            Me.chkbAreaSunShadows.Location = New Global.System.Drawing.Point(112, 112)
            Me.chkbAreaSunShadows.Name = "chkbAreaSunShadows"
            Me.chkbAreaSunShadows.Size = New Global.System.Drawing.Size(32, 16)
            Me.chkbAreaSunShadows.TabIndex = 4
            Me.trkbarSunFogNear.Enabled = False
            Me.trkbarSunFogNear.Location = New Global.System.Drawing.Point(232, 24)
            Me.trkbarSunFogNear.Maximum = 2000
            Me.trkbarSunFogNear.Name = "trkbarSunFogNear"
            Me.trkbarSunFogNear.Size = New Global.System.Drawing.Size(200, 42)
            Me.trkbarSunFogNear.TabIndex = 5
            Me.trkbarSunFogNear.TickFrequency = 50
            Me.trkbarSunFogNear.TickStyle = Global.System.Windows.Forms.TickStyle.TopLeft
            Me.Label27.Location = New Global.System.Drawing.Point(16, 40)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label27.TabIndex = 16
            Me.Label27.Text = "Diffuse Color"
            Me.Label27.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSunAmbientColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnSunAmbientColor.Location = New Global.System.Drawing.Point(112, 16)
            Me.btnSunAmbientColor.Name = "btnSunAmbientColor"
            Me.btnSunAmbientColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnSunAmbientColor.TabIndex = 0
            Me.Label26.Location = New Global.System.Drawing.Point(16, 16)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label26.TabIndex = 17
            Me.Label26.Text = "Ambient Color"
            Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSunDiffuseColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnSunDiffuseColor.Location = New Global.System.Drawing.Point(112, 40)
            Me.btnSunDiffuseColor.Name = "btnSunDiffuseColor"
            Me.btnSunDiffuseColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnSunDiffuseColor.TabIndex = 1
            Me.Label28.Location = New Global.System.Drawing.Point(16, 88)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label28.TabIndex = 16
            Me.Label28.Text = "Fog Color"
            Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSunFogColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnSunFogColor.Location = New Global.System.Drawing.Point(112, 88)
            Me.btnSunFogColor.Name = "btnSunFogColor"
            Me.btnSunFogColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnSunFogColor.TabIndex = 3
            Me.Label29.Location = New Global.System.Drawing.Point(16, 64)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label29.TabIndex = 16
            Me.Label29.Text = "Fog Enabled"
            Me.Label29.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label30.Location = New Global.System.Drawing.Point(16, 112)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label30.TabIndex = 16
            Me.Label30.Text = "Shadows"
            Me.Label30.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.trkbarSunFogFar.Enabled = False
            Me.trkbarSunFogFar.Location = New Global.System.Drawing.Point(232, 80)
            Me.trkbarSunFogFar.Maximum = 2000
            Me.trkbarSunFogFar.Name = "trkbarSunFogFar"
            Me.trkbarSunFogFar.Size = New Global.System.Drawing.Size(200, 42)
            Me.trkbarSunFogFar.TabIndex = 6
            Me.trkbarSunFogFar.TickFrequency = 50
            Me.trkbarSunFogFar.TickStyle = Global.System.Windows.Forms.TickStyle.TopLeft
            Me.lblSunFogNear.Enabled = False
            Me.lblSunFogNear.Location = New Global.System.Drawing.Point(160, 32)
            Me.lblSunFogNear.Name = "lblSunFogNear"
            Me.lblSunFogNear.Size = New Global.System.Drawing.Size(64, 16)
            Me.lblSunFogNear.TabIndex = 16
            Me.lblSunFogNear.Text = "Fog Near"
            Me.lblSunFogNear.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblSunFogFar.Enabled = False
            Me.lblSunFogFar.Location = New Global.System.Drawing.Point(160, 88)
            Me.lblSunFogFar.Name = "lblSunFogFar"
            Me.lblSunFogFar.Size = New Global.System.Drawing.Size(64, 16)
            Me.lblSunFogFar.TabIndex = 16
            Me.lblSunFogFar.Text = "Fog Far"
            Me.lblSunFogFar.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbSunFogOn.Location = New Global.System.Drawing.Point(112, 64)
            Me.chkbSunFogOn.Name = "chkbSunFogOn"
            Me.chkbSunFogOn.Size = New Global.System.Drawing.Size(32, 16)
            Me.chkbSunFogOn.TabIndex = 2
            Me.rbAlwaysDay.Location = New Global.System.Drawing.Point(40, 24)
            Me.rbAlwaysDay.Name = "rbAlwaysDay"
            Me.rbAlwaysDay.Size = New Global.System.Drawing.Size(104, 16)
            Me.rbAlwaysDay.TabIndex = 1
            Me.rbAlwaysDay.Text = "Always Day"
            Me.rbAlwaysNight.Location = New Global.System.Drawing.Point(40, 40)
            Me.rbAlwaysNight.Name = "rbAlwaysNight"
            Me.rbAlwaysNight.Size = New Global.System.Drawing.Size(104, 16)
            Me.rbAlwaysNight.TabIndex = 2
            Me.rbAlwaysNight.Text = "Always Night"
            Me.btnDynAmbientColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDynAmbientColor.Location = New Global.System.Drawing.Point(376, 10)
            Me.btnDynAmbientColor.Name = "btnDynAmbientColor"
            Me.btnDynAmbientColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnDynAmbientColor.TabIndex = 3
            Me.Label48.Location = New Global.System.Drawing.Point(232, 10)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label48.TabIndex = 17
            Me.Label48.Text = "Dynamic Ambient Color"
            Me.Label48.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label73.Location = New Global.System.Drawing.Point(232, 32)
            Me.Label73.Name = "Label73"
            Me.Label73.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label73.TabIndex = 24
            Me.Label73.Text = "Shadow Opacity"
            Me.Label73.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudShadowOpacity.Location = New Global.System.Drawing.Point(352, 32)
            Me.nudShadowOpacity.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudShadowOpacity.Name = "nudShadowOpacity"
            Me.nudShadowOpacity.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudShadowOpacity.TabIndex = 0
            Me.nudShadowOpacity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label84.Enabled = False
            Me.Label84.Location = New Global.System.Drawing.Point(248, 360)
            Me.Label84.Name = "Label84"
            Me.Label84.Size = New Global.System.Drawing.Size(80, 16)
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
            Me.tabpagAreaGrass.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagAreaGrass.Name = "tabpagAreaGrass"
            Me.tabpagAreaGrass.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagAreaGrass.TabIndex = 2
            Me.tabpagAreaGrass.Text = "Grass"
            Me.nudGrassDensity.DecimalPlaces = 2
            Me.nudGrassDensity.Location = New Global.System.Drawing.Point(320, 320)
            Me.nudGrassDensity.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.nudGrassDensity.Name = "nudGrassDensity"
            Me.nudGrassDensity.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudGrassDensity.TabIndex = 19
            Me.nudGrassDensity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.trkbarGrassDensityX10.Location = New Global.System.Drawing.Point(112, 312)
            Me.trkbarGrassDensityX10.Maximum = 500
            Me.trkbarGrassDensityX10.Name = "trkbarGrassDensityX10"
            Me.trkbarGrassDensityX10.Size = New Global.System.Drawing.Size(200, 42)
            Me.trkbarGrassDensityX10.TabIndex = 17
            Me.trkbarGrassDensityX10.TickFrequency = 10
            Me.Label62.Location = New Global.System.Drawing.Point(24, 320)
            Me.Label62.Name = "Label62"
            Me.Label62.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label62.TabIndex = 18
            Me.Label62.Text = "Grass Density"
            Me.Label62.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGrassDiffuseColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnGrassDiffuseColor.Location = New Global.System.Drawing.Point(120, 104)
            Me.btnGrassDiffuseColor.Name = "btnGrassDiffuseColor"
            Me.btnGrassDiffuseColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnGrassDiffuseColor.TabIndex = 15
            Me.tbGrass_TexName.Location = New Global.System.Drawing.Point(120, 40)
            Me.tbGrass_TexName.MaxLength = 16
            Me.tbGrass_TexName.Name = "tbGrass_TexName"
            Me.tbGrass_TexName.Size = New Global.System.Drawing.Size(176, 20)
            Me.tbGrass_TexName.TabIndex = 14
            Me.tbGrass_TexName.Text = ""
            Me.Label20.Location = New Global.System.Drawing.Point(24, 40)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label20.TabIndex = 13
            Me.Label20.Text = "Texture Name"
            Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label21.Location = New Global.System.Drawing.Point(24, 80)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label21.TabIndex = 13
            Me.Label21.Text = "Ambient Color"
            Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label22.Location = New Global.System.Drawing.Point(24, 104)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label22.TabIndex = 13
            Me.Label22.Text = "Diffuse Color"
            Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGrassAmbientColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnGrassAmbientColor.Location = New Global.System.Drawing.Point(120, 80)
            Me.btnGrassAmbientColor.Name = "btnGrassAmbientColor"
            Me.btnGrassAmbientColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnGrassAmbientColor.TabIndex = 15
            Me.Label23.Location = New Global.System.Drawing.Point(24, 128)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label23.TabIndex = 13
            Me.Label23.Text = "Emissive Color"
            Me.Label23.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGrassEmissiveColor.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnGrassEmissiveColor.Location = New Global.System.Drawing.Point(120, 128)
            Me.btnGrassEmissiveColor.Name = "btnGrassEmissiveColor"
            Me.btnGrassEmissiveColor.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnGrassEmissiveColor.TabIndex = 15
            Me.nudGrassProbUL.Location = New Global.System.Drawing.Point(160, 216)
            Me.nudGrassProbUL.Name = "nudGrassProbUL"
            Me.nudGrassProbUL.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudGrassProbUL.TabIndex = 19
            Me.nudGrassProbUL.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassProbUL.Value = New Decimal(New Integer() {25, 0, 0, 0})
            Me.nudGrassProbLL.Location = New Global.System.Drawing.Point(160, 272)
            Me.nudGrassProbLL.Name = "nudGrassProbLL"
            Me.nudGrassProbLL.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudGrassProbLL.TabIndex = 19
            Me.nudGrassProbLL.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassProbLL.Value = New Decimal(New Integer() {25, 0, 0, 0})
            Me.nudGrassProbUR.Location = New Global.System.Drawing.Point(264, 216)
            Me.nudGrassProbUR.Name = "nudGrassProbUR"
            Me.nudGrassProbUR.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudGrassProbUR.TabIndex = 19
            Me.nudGrassProbUR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassProbUR.Value = New Decimal(New Integer() {25, 0, 0, 0})
            Me.nudGrassProbLR.Location = New Global.System.Drawing.Point(264, 272)
            Me.nudGrassProbLR.Name = "nudGrassProbLR"
            Me.nudGrassProbLR.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudGrassProbLR.TabIndex = 19
            Me.nudGrassProbLR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassProbLR.Value = New Decimal(New Integer() {25, 0, 0, 0})
            Me.Label63.Location = New Global.System.Drawing.Point(24, 224)
            Me.Label63.Name = "Label63"
            Me.Label63.Size = New Global.System.Drawing.Size(80, 48)
            Me.Label63.TabIndex = 18
            Me.Label63.Text = "Grass Movement Probability"
            Me.Label63.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label64.Location = New Global.System.Drawing.Point(224, 208)
            Me.Label64.Name = "Label64"
            Me.Label64.Size = New Global.System.Drawing.Size(40, 32)
            Me.Label64.TabIndex = 13
            Me.Label64.Text = "Upper Right"
            Me.Label64.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label65.Location = New Global.System.Drawing.Point(120, 208)
            Me.Label65.Name = "Label65"
            Me.Label65.Size = New Global.System.Drawing.Size(40, 32)
            Me.Label65.TabIndex = 13
            Me.Label65.Text = "Upper Left"
            Me.Label65.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label66.Location = New Global.System.Drawing.Point(120, 264)
            Me.Label66.Name = "Label66"
            Me.Label66.Size = New Global.System.Drawing.Size(40, 32)
            Me.Label66.TabIndex = 13
            Me.Label66.Text = "Lower Left"
            Me.Label66.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label67.Location = New Global.System.Drawing.Point(224, 264)
            Me.Label67.Name = "Label67"
            Me.Label67.Size = New Global.System.Drawing.Size(40, 32)
            Me.Label67.TabIndex = 13
            Me.Label67.Text = "Lower Right"
            Me.Label67.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblTotalGrassProbability.Location = New Global.System.Drawing.Point(344, 248)
            Me.lblTotalGrassProbability.Name = "lblTotalGrassProbability"
            Me.lblTotalGrassProbability.Size = New Global.System.Drawing.Size(80, 16)
            Me.lblTotalGrassProbability.TabIndex = 18
            Me.lblTotalGrassProbability.Text = "Total: "
            Me.lblTotalGrassProbability.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label69.Location = New Global.System.Drawing.Point(200, 218)
            Me.Label69.Name = "Label69"
            Me.Label69.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label69.TabIndex = 13
            Me.Label69.Text = "%"
            Me.Label69.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label70.Location = New Global.System.Drawing.Point(304, 218)
            Me.Label70.Name = "Label70"
            Me.Label70.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label70.TabIndex = 13
            Me.Label70.Text = "%"
            Me.Label70.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label71.Location = New Global.System.Drawing.Point(304, 274)
            Me.Label71.Name = "Label71"
            Me.Label71.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label71.TabIndex = 13
            Me.Label71.Text = "%"
            Me.Label71.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label72.Location = New Global.System.Drawing.Point(200, 274)
            Me.Label72.Name = "Label72"
            Me.Label72.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label72.TabIndex = 13
            Me.Label72.Text = "%"
            Me.Label72.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label68.Location = New Global.System.Drawing.Point(24, 160)
            Me.Label68.Name = "Label68"
            Me.Label68.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label68.TabIndex = 18
            Me.Label68.Text = "Grass Quad localSize"
            Me.Label68.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudGrassQuadSize.DecimalPlaces = 2
            Me.nudGrassQuadSize.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudGrassQuadSize.Location = New Global.System.Drawing.Point(120, 160)
            Me.nudGrassQuadSize.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.nudGrassQuadSize.Name = "nudGrassQuadSize"
            Me.nudGrassQuadSize.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudGrassQuadSize.TabIndex = 19
            Me.nudGrassQuadSize.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassQuadSize.Value = New Decimal(New Integer() {10, 0, 0, 65536})
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
            Me.tabpagAreaAudio.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagAreaAudio.Name = "tabpagAreaAudio"
            Me.tabpagAreaAudio.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagAreaAudio.TabIndex = 5
            Me.tabpagAreaAudio.Text = "Audio"
            Me.trkbarAmbientSndNightVol.Location = New Global.System.Drawing.Point(160, 144)
            Me.trkbarAmbientSndNightVol.Maximum = 127
            Me.trkbarAmbientSndNightVol.Name = "trkbarAmbientSndNightVol"
            Me.trkbarAmbientSndNightVol.Size = New Global.System.Drawing.Size(216, 42)
            Me.trkbarAmbientSndNightVol.TabIndex = 3
            Me.trkbarAmbientSndNightVol.TickFrequency = 5
            Me.trkbarAmbientSndDayVol.Location = New Global.System.Drawing.Point(160, 64)
            Me.trkbarAmbientSndDayVol.Maximum = 127
            Me.trkbarAmbientSndDayVol.Name = "trkbarAmbientSndDayVol"
            Me.trkbarAmbientSndDayVol.Size = New Global.System.Drawing.Size(216, 42)
            Me.trkbarAmbientSndDayVol.TabIndex = 1
            Me.trkbarAmbientSndDayVol.TickFrequency = 5
            Me.Label52.Location = New Global.System.Drawing.Point(24, 40)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label52.TabIndex = 19
            Me.Label52.Text = "Ambient Sound - Day"
            Me.Label52.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudMusicDelay.Location = New Global.System.Drawing.Point(168, 336)
            Me.nudMusicDelay.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
            Me.nudMusicDelay.Name = "nudMusicDelay"
            Me.nudMusicDelay.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudMusicDelay.TabIndex = 8
            Me.nudMusicDelay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.cmbxMusicNight.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMusicNight.Location = New Global.System.Drawing.Point(168, 304)
            Me.cmbxMusicNight.Name = "cmbxMusicNight"
            Me.cmbxMusicNight.Size = New Global.System.Drawing.Size(200, 21)
            Me.cmbxMusicNight.TabIndex = 7
            Me.cmbxMusicDay.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMusicDay.Location = New Global.System.Drawing.Point(168, 272)
            Me.cmbxMusicDay.Name = "cmbxMusicDay"
            Me.cmbxMusicDay.Size = New Global.System.Drawing.Size(200, 21)
            Me.cmbxMusicDay.TabIndex = 6
            Me.cmbxMusicBattle.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMusicBattle.Location = New Global.System.Drawing.Point(168, 240)
            Me.cmbxMusicBattle.Name = "cmbxMusicBattle"
            Me.cmbxMusicBattle.Size = New Global.System.Drawing.Size(200, 21)
            Me.cmbxMusicBattle.TabIndex = 5
            Me.cmbxEnvAudio.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxEnvAudio.Location = New Global.System.Drawing.Point(168, 208)
            Me.cmbxEnvAudio.Name = "cmbxEnvAudio"
            Me.cmbxEnvAudio.Size = New Global.System.Drawing.Size(200, 21)
            Me.cmbxEnvAudio.TabIndex = 4
            Me.cmbxAmbientSndNight.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxAmbientSndNight.Location = New Global.System.Drawing.Point(168, 120)
            Me.cmbxAmbientSndNight.Name = "cmbxAmbientSndNight"
            Me.cmbxAmbientSndNight.Size = New Global.System.Drawing.Size(200, 21)
            Me.cmbxAmbientSndNight.TabIndex = 2
            Me.cmbxAmbientSndDay.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxAmbientSndDay.Location = New Global.System.Drawing.Point(168, 40)
            Me.cmbxAmbientSndDay.Name = "cmbxAmbientSndDay"
            Me.cmbxAmbientSndDay.Size = New Global.System.Drawing.Size(200, 21)
            Me.cmbxAmbientSndDay.TabIndex = 0
            Me.Label53.Location = New Global.System.Drawing.Point(24, 68)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label53.TabIndex = 19
            Me.Label53.Text = "Volume"
            Me.Label53.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label54.Location = New Global.System.Drawing.Point(24, 120)
            Me.Label54.Name = "Label54"
            Me.Label54.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label54.TabIndex = 19
            Me.Label54.Text = "Ambient Sound - Night"
            Me.Label54.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label55.Location = New Global.System.Drawing.Point(24, 148)
            Me.Label55.Name = "Label55"
            Me.Label55.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label55.TabIndex = 19
            Me.Label55.Text = "Volume"
            Me.Label55.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label56.Location = New Global.System.Drawing.Point(24, 205)
            Me.Label56.Name = "Label56"
            Me.Label56.Size = New Global.System.Drawing.Size(88, 24)
            Me.Label56.TabIndex = 19
            Me.Label56.Text = "Environmental Audio Effects"
            Me.Label56.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label57.Location = New Global.System.Drawing.Point(24, 240)
            Me.Label57.Name = "Label57"
            Me.Label57.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label57.TabIndex = 19
            Me.Label57.Text = "Battle Music"
            Me.Label57.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label58.Location = New Global.System.Drawing.Point(24, 272)
            Me.Label58.Name = "Label58"
            Me.Label58.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label58.TabIndex = 19
            Me.Label58.Text = "Daytime Music"
            Me.Label58.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label59.Location = New Global.System.Drawing.Point(24, 304)
            Me.Label59.Name = "Label59"
            Me.Label59.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label59.TabIndex = 19
            Me.Label59.Text = "Nighttime Music"
            Me.Label59.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label60.Location = New Global.System.Drawing.Point(24, 336)
            Me.Label60.Name = "Label60"
            Me.Label60.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label60.TabIndex = 19
            Me.Label60.Text = "Music Delay"
            Me.Label60.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label61.Location = New Global.System.Drawing.Point(224, 338)
            Me.Label61.Name = "Label61"
            Me.Label61.Size = New Global.System.Drawing.Size(88, 16)
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
            Me.tabpagArea_Events.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagArea_Events.Name = "tabpagArea_Events"
            Me.tabpagArea_Events.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagArea_Events.TabIndex = 6
            Me.tabpagArea_Events.Text = "Events"
            Me.Label77.Location = New Global.System.Drawing.Point(24, 112)
            Me.Label77.Name = "Label77"
            Me.Label77.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label77.TabIndex = 36
            Me.Label77.Text = "OnUserDefined"
            Me.Label77.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbArea_OnUserDefined.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbArea_OnUserDefined.Location = New Global.System.Drawing.Point(136, 112)
            Me.tbArea_OnUserDefined.MaxLength = 16
            Me.tbArea_OnUserDefined.Name = "tbArea_OnUserDefined"
            Me.tbArea_OnUserDefined.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbArea_OnUserDefined.TabIndex = 35
            Me.tbArea_OnUserDefined.Text = ""
            Me.tbArea_OnHeartbeat.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbArea_OnHeartbeat.Location = New Global.System.Drawing.Point(136, 88)
            Me.tbArea_OnHeartbeat.MaxLength = 16
            Me.tbArea_OnHeartbeat.Name = "tbArea_OnHeartbeat"
            Me.tbArea_OnHeartbeat.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbArea_OnHeartbeat.TabIndex = 33
            Me.tbArea_OnHeartbeat.Text = ""
            Me.Label76.Location = New Global.System.Drawing.Point(24, 88)
            Me.Label76.Name = "Label76"
            Me.Label76.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label76.TabIndex = 34
            Me.Label76.Text = "OnHeartbeat"
            Me.Label76.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label74.Location = New Global.System.Drawing.Point(24, 40)
            Me.Label74.Name = "Label74"
            Me.Label74.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label74.TabIndex = 32
            Me.Label74.Text = "OnEnter"
            Me.Label74.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbArea_OnEnter.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbArea_OnEnter.Location = New Global.System.Drawing.Point(136, 40)
            Me.tbArea_OnEnter.MaxLength = 16
            Me.tbArea_OnEnter.Name = "tbArea_OnEnter"
            Me.tbArea_OnEnter.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbArea_OnEnter.TabIndex = 29
            Me.tbArea_OnEnter.Text = ""
            Me.Label75.Location = New Global.System.Drawing.Point(24, 64)
            Me.Label75.Name = "Label75"
            Me.Label75.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label75.TabIndex = 31
            Me.Label75.Text = "OnExit"
            Me.Label75.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbArea_OnExit.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbArea_OnExit.Location = New Global.System.Drawing.Point(136, 64)
            Me.tbArea_OnExit.MaxLength = 16
            Me.tbArea_OnExit.Name = "tbArea_OnExit"
            Me.tbArea_OnExit.Size = New Global.System.Drawing.Size(204, 20)
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
            Me.tabpagAreaRooms.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagAreaRooms.Name = "tabpagAreaRooms"
            Me.tabpagAreaRooms.Size = New Global.System.Drawing.Size(480, 444)
            Me.tabpagAreaRooms.TabIndex = 7
            Me.tabpagAreaRooms.Text = "Rooms"
            Me.lbRooms.Location = New Global.System.Drawing.Point(176, 40)
            Me.lbRooms.Name = "lbRooms"
            Me.lbRooms.ScrollAlwaysVisible = True
            Me.lbRooms.Size = New Global.System.Drawing.Size(96, 95)
            Me.lbRooms.TabIndex = 41
            Me.Label82.Location = New Global.System.Drawing.Point(24, 288)
            Me.Label82.Name = "Label82"
            Me.Label82.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label82.TabIndex = 40
            Me.Label82.Text = "Disable Weather"
            Me.Label82.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbRoomDisableWeather.Location = New Global.System.Drawing.Point(184, 288)
            Me.chkbRoomDisableWeather.Name = "chkbRoomDisableWeather"
            Me.chkbRoomDisableWeather.Size = New Global.System.Drawing.Size(32, 16)
            Me.chkbRoomDisableWeather.TabIndex = 39
            Me.nudRoomAmbientScale.DecimalPlaces = 2
            Me.nudRoomAmbientScale.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudRoomAmbientScale.Location = New Global.System.Drawing.Point(184, 224)
            Me.nudRoomAmbientScale.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudRoomAmbientScale.Name = "nudRoomAmbientScale"
            Me.nudRoomAmbientScale.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudRoomAmbientScale.TabIndex = 38
            Me.nudRoomAmbientScale.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label80.Location = New Global.System.Drawing.Point(24, 224)
            Me.Label80.Name = "Label80"
            Me.Label80.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label80.TabIndex = 37
            Me.Label80.Text = "Ambient Sound Scale"
            Me.Label80.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxRoomEnvAudio.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxRoomEnvAudio.Location = New Global.System.Drawing.Point(184, 192)
            Me.cmbxRoomEnvAudio.Name = "cmbxRoomEnvAudio"
            Me.cmbxRoomEnvAudio.Size = New Global.System.Drawing.Size(192, 21)
            Me.cmbxRoomEnvAudio.TabIndex = 35
            Me.Label79.Location = New Global.System.Drawing.Point(24, 192)
            Me.Label79.Name = "Label79"
            Me.Label79.Size = New Global.System.Drawing.Size(160, 24)
            Me.Label79.TabIndex = 36
            Me.Label79.Text = "Environmental Audio Effects"
            Me.Label79.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label78.Location = New Global.System.Drawing.Point(24, 160)
            Me.Label78.Name = "Label78"
            Me.Label78.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label78.TabIndex = 34
            Me.Label78.Text = "Room Name"
            Me.Label78.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbRoomName.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbRoomName.Location = New Global.System.Drawing.Point(184, 160)
            Me.tbRoomName.MaxLength = 16
            Me.tbRoomName.Name = "tbRoomName"
            Me.tbRoomName.[ReadOnly] = True
            Me.tbRoomName.Size = New Global.System.Drawing.Size(104, 20)
            Me.tbRoomName.TabIndex = 33
            Me.tbRoomName.Text = ""
            Me.nudRoomForceRating.Location = New Global.System.Drawing.Point(184, 256)
            Me.nudRoomForceRating.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
            Me.nudRoomForceRating.Name = "nudRoomForceRating"
            Me.nudRoomForceRating.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudRoomForceRating.TabIndex = 38
            Me.nudRoomForceRating.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label81.Location = New Global.System.Drawing.Point(24, 256)
            Me.Label81.Name = "Label81"
            Me.Label81.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label81.TabIndex = 37
            Me.Label81.Text = "Force Rating"
            Me.Label81.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label83.Location = New Global.System.Drawing.Point(24, 72)
            Me.Label83.Name = "Label83"
            Me.Label83.Size = New Global.System.Drawing.Size(100, 18)
            Me.Label83.TabIndex = 34
            Me.Label83.Text = "Rooms"
            Me.Label83.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(320, 532)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&OK"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(416, 532)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancel"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(528, 565)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.nudXPScale.ValueChanged, AddressOf Me.nudXPScale_ValueChanged
            AddHandler Me.trkbarXPScale.Scroll, AddressOf Me.trkbarXPScale_Scroll
            AddHandler Me.btnSetDescriptionLang.Click, AddressOf Me.btnSetDescriptionLang_Click
            AddHandler Me.btnGrassDiffuseColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.btnGrassAmbientColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.btnGrassEmissiveColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.btnSunDiffuseColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.btnSunAmbientColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.btnMoonDiffuseColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.btnMoonAmbientColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.rbDayNightCycle.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
            AddHandler Me.rbAlwaysDay.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
            AddHandler Me.btnMoonFogColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.btnSunFogColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.rbAlwaysNight.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
            AddHandler Me.chkbSunFogOn.CheckedChanged, AddressOf Me.SunFogEnabled
            AddHandler Me.chkbMoonFogOn.CheckedChanged, AddressOf Me.MoonFogEnabled
            AddHandler Me.btnDynAmbientColor.Click, AddressOf Me.SetColor_Click
            AddHandler Me.trkbarGrassDensityX10.Scroll, AddressOf Me.trkbarGrassDensityX10_Scroll
            AddHandler Me.nudGrassDensity.ValueChanged, AddressOf Me.nudGrassDensity_ValueChanged
            AddHandler Me.nudGrassProbUL.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
            AddHandler Me.nudGrassProbLL.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
            AddHandler Me.nudGrassProbUR.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
            AddHandler Me.nudGrassProbLR.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
            AddHandler Me.lbRooms.SelectedIndexChanged, AddressOf Me.lbRooms_SelectedIndexChanged
            AddHandler Me.btnSetModNameLang.Click, AddressOf Me.btnSetModNameLang_Click
            AddHandler Me.btnSetAreaNameLang.Click, AddressOf Me.btnSetAreaNameLang_Click
            AddHandler Me.nudXY.ValueChanged, AddressOf Me.nudXY_ValueChanged
            AddHandler Me.nudXY.KeyUp, AddressOf Me.nudXY_KeyUp
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
