Option Strict Off
Option Explicit On

Imports System.Windows.Forms

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmModuleIfo_AreaEditor
        Inherits Global.kotor_tool.frmParent

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderRule As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterRule As Global.System.Windows.Forms.Label

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

        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TabControlMain = New System.Windows.Forms.TabControl()
            Me.TabPage5 = New System.Windows.Forms.TabPage()
            Me.TabControlModule = New System.Windows.Forms.TabControl()
            Me.tabpagModuleBasic = New System.Windows.Forms.TabPage()
            Me.pboxXY = New System.Windows.Forms.PictureBox()
            Me.nudXY = New System.Windows.Forms.NumericUpDown()
            Me.lblBearing = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.nudModEntryX = New System.Windows.Forms.NumericUpDown()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.nudModEntryY = New System.Windows.Forms.NumericUpDown()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.nudModEntryZ = New System.Windows.Forms.NumericUpDown()
            Me.btnSetModNameLang = New System.Windows.Forms.Button()
            Me.tbModTag = New System.Windows.Forms.TextBox()
            Me.tbModName = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.tbModEntryArea = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.tabpagModuleAdvanced = New System.Windows.Forms.TabPage()
            Me.nudXPScale = New System.Windows.Forms.NumericUpDown()
            Me.trkbarXPScale = New System.Windows.Forms.TrackBar()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.nudMinutesPerHour = New System.Windows.Forms.NumericUpDown()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.nudDawnStartHour = New System.Windows.Forms.NumericUpDown()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.nudDuskStartHour = New System.Windows.Forms.NumericUpDown()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.nudStartHour = New System.Windows.Forms.NumericUpDown()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.nudStartDay = New System.Windows.Forms.NumericUpDown()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.nudStartMonth = New System.Windows.Forms.NumericUpDown()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.nudStartYear = New System.Windows.Forms.NumericUpDown()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.tabpagModuleEvents = New System.Windows.Forms.TabPage()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.tbMod_OnClientEntr = New System.Windows.Forms.TextBox()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.tbMod_OnActvtItem = New System.Windows.Forms.TextBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.tbMod_OnAcquirItem = New System.Windows.Forms.TextBox()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.tbMod_OnClientLeav = New System.Windows.Forms.TextBox()
            Me.tbMod_OnHeartbeat = New System.Windows.Forms.TextBox()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.tbMod_OnModLoad = New System.Windows.Forms.TextBox()
            Me.tbMod_OnPlrDeath = New System.Windows.Forms.TextBox()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.tbMod_OnPlrDying = New System.Windows.Forms.TextBox()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.tbMod_OnPlrLvlUp = New System.Windows.Forms.TextBox()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.tbMod_OnSpawnBtnDn = New System.Windows.Forms.TextBox()
            Me.tbMod_OnPlrRest = New System.Windows.Forms.TextBox()
            Me.Label42 = New System.Windows.Forms.Label()
            Me.tbMod_OnUnAqreItem = New System.Windows.Forms.TextBox()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.tbMod_OnUsrDefined = New System.Windows.Forms.TextBox()
            Me.tabpagModuleDescription = New System.Windows.Forms.TabPage()
            Me.btnSetDescriptionLang = New System.Windows.Forms.Button()
            Me.tbModDescription = New System.Windows.Forms.TextBox()
            Me.TabPage6 = New System.Windows.Forms.TabPage()
            Me.TabControlArea = New System.Windows.Forms.TabControl()
            Me.tabpagAreaBasic = New System.Windows.Forms.TabPage()
            Me.chkbUnescapable = New System.Windows.Forms.CheckBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.cmbxCameraStyle = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.NumericUpDown10 = New System.Windows.Forms.NumericUpDown()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.NumericUpDown11 = New System.Windows.Forms.NumericUpDown()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.NumericUpDown12 = New System.Windows.Forms.NumericUpDown()
            Me.btnSetAreaNameLang = New System.Windows.Forms.Button()
            Me.tbAreaTag = New System.Windows.Forms.TextBox()
            Me.tbAreaName = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label85 = New System.Windows.Forms.Label()
            Me.chkbDisableTransit = New System.Windows.Forms.CheckBox()
            Me.Label86 = New System.Windows.Forms.Label()
            Me.tabpagAreaEnvironment = New System.Windows.Forms.TabPage()
            Me.cmbxWindPower = New System.Windows.Forms.ComboBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.nudChanceSnow = New System.Windows.Forms.NumericUpDown()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.nudChanceRain = New System.Windows.Forms.NumericUpDown()
            Me.Label51 = New System.Windows.Forms.Label()
            Me.nudChanceLightning = New System.Windows.Forms.NumericUpDown()
            Me.rbDayNightCycle = New System.Windows.Forms.RadioButton()
            Me.gbMoon = New System.Windows.Forms.GroupBox()
            Me.btnMoonDiffuseColor = New System.Windows.Forms.Button()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.btnMoonAmbientColor = New System.Windows.Forms.Button()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.btnMoonFogColor = New System.Windows.Forms.Button()
            Me.chkbAreaMoonShadows = New System.Windows.Forms.CheckBox()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.chkbMoonFogOn = New System.Windows.Forms.CheckBox()
            Me.trkbarMoonFogNear = New System.Windows.Forms.TrackBar()
            Me.lblMoonFogNear = New System.Windows.Forms.Label()
            Me.trkbarMoonFogFar = New System.Windows.Forms.TrackBar()
            Me.lblMoonFogFar = New System.Windows.Forms.Label()
            Me.gbSun = New System.Windows.Forms.GroupBox()
            Me.chkbAreaSunShadows = New System.Windows.Forms.CheckBox()
            Me.trkbarSunFogNear = New System.Windows.Forms.TrackBar()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.btnSunAmbientColor = New System.Windows.Forms.Button()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.btnSunDiffuseColor = New System.Windows.Forms.Button()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.btnSunFogColor = New System.Windows.Forms.Button()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.trkbarSunFogFar = New System.Windows.Forms.TrackBar()
            Me.lblSunFogNear = New System.Windows.Forms.Label()
            Me.lblSunFogFar = New System.Windows.Forms.Label()
            Me.chkbSunFogOn = New System.Windows.Forms.CheckBox()
            Me.rbAlwaysDay = New System.Windows.Forms.RadioButton()
            Me.rbAlwaysNight = New System.Windows.Forms.RadioButton()
            Me.btnDynAmbientColor = New System.Windows.Forms.Button()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label73 = New System.Windows.Forms.Label()
            Me.nudShadowOpacity = New System.Windows.Forms.NumericUpDown()
            Me.Label84 = New System.Windows.Forms.Label()
            Me.tabpagAreaGrass = New System.Windows.Forms.TabPage()
            Me.nudGrassDensity = New System.Windows.Forms.NumericUpDown()
            Me.trkbarGrassDensityX10 = New System.Windows.Forms.TrackBar()
            Me.Label62 = New System.Windows.Forms.Label()
            Me.btnGrassDiffuseColor = New System.Windows.Forms.Button()
            Me.tbGrass_TexName = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.btnGrassAmbientColor = New System.Windows.Forms.Button()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.btnGrassEmissiveColor = New System.Windows.Forms.Button()
            Me.nudGrassProbUL = New System.Windows.Forms.NumericUpDown()
            Me.nudGrassProbLL = New System.Windows.Forms.NumericUpDown()
            Me.nudGrassProbUR = New System.Windows.Forms.NumericUpDown()
            Me.nudGrassProbLR = New System.Windows.Forms.NumericUpDown()
            Me.Label63 = New System.Windows.Forms.Label()
            Me.Label64 = New System.Windows.Forms.Label()
            Me.Label65 = New System.Windows.Forms.Label()
            Me.Label66 = New System.Windows.Forms.Label()
            Me.Label67 = New System.Windows.Forms.Label()
            Me.lblTotalGrassProbability = New System.Windows.Forms.Label()
            Me.Label69 = New System.Windows.Forms.Label()
            Me.Label70 = New System.Windows.Forms.Label()
            Me.Label71 = New System.Windows.Forms.Label()
            Me.Label72 = New System.Windows.Forms.Label()
            Me.Label68 = New System.Windows.Forms.Label()
            Me.nudGrassQuadSize = New System.Windows.Forms.NumericUpDown()
            Me.tabpagAreaAudio = New System.Windows.Forms.TabPage()
            Me.trkbarAmbientSndNightVol = New System.Windows.Forms.TrackBar()
            Me.trkbarAmbientSndDayVol = New System.Windows.Forms.TrackBar()
            Me.Label52 = New System.Windows.Forms.Label()
            Me.nudMusicDelay = New System.Windows.Forms.NumericUpDown()
            Me.cmbxMusicNight = New System.Windows.Forms.ComboBox()
            Me.cmbxMusicDay = New System.Windows.Forms.ComboBox()
            Me.cmbxMusicBattle = New System.Windows.Forms.ComboBox()
            Me.cmbxEnvAudio = New System.Windows.Forms.ComboBox()
            Me.cmbxAmbientSndNight = New System.Windows.Forms.ComboBox()
            Me.cmbxAmbientSndDay = New System.Windows.Forms.ComboBox()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.Label54 = New System.Windows.Forms.Label()
            Me.Label55 = New System.Windows.Forms.Label()
            Me.Label56 = New System.Windows.Forms.Label()
            Me.Label57 = New System.Windows.Forms.Label()
            Me.Label58 = New System.Windows.Forms.Label()
            Me.Label59 = New System.Windows.Forms.Label()
            Me.Label60 = New System.Windows.Forms.Label()
            Me.Label61 = New System.Windows.Forms.Label()
            Me.tabpagArea_Events = New System.Windows.Forms.TabPage()
            Me.Label77 = New System.Windows.Forms.Label()
            Me.tbArea_OnUserDefined = New System.Windows.Forms.TextBox()
            Me.tbArea_OnHeartbeat = New System.Windows.Forms.TextBox()
            Me.Label76 = New System.Windows.Forms.Label()
            Me.Label74 = New System.Windows.Forms.Label()
            Me.tbArea_OnEnter = New System.Windows.Forms.TextBox()
            Me.Label75 = New System.Windows.Forms.Label()
            Me.tbArea_OnExit = New System.Windows.Forms.TextBox()
            Me.tabpagAreaRooms = New System.Windows.Forms.TabPage()
            Me.lbRooms = New System.Windows.Forms.ListBox()
            Me.Label82 = New System.Windows.Forms.Label()
            Me.chkbRoomDisableWeather = New System.Windows.Forms.CheckBox()
            Me.nudRoomAmbientScale = New System.Windows.Forms.NumericUpDown()
            Me.Label80 = New System.Windows.Forms.Label()
            Me.cmbxRoomEnvAudio = New System.Windows.Forms.ComboBox()
            Me.Label79 = New System.Windows.Forms.Label()
            Me.Label78 = New System.Windows.Forms.Label()
            Me.tbRoomName = New System.Windows.Forms.TextBox()
            Me.nudRoomForceRating = New System.Windows.Forms.NumericUpDown()
            Me.Label81 = New System.Windows.Forms.Label()
            Me.Label83 = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterRule = New System.Windows.Forms.Label()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderRule = New System.Windows.Forms.Label()
            Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.TabControlMain.SuspendLayout()
            Me.TabPage5.SuspendLayout()
            Me.TabControlModule.SuspendLayout()
            Me.tabpagModuleBasic.SuspendLayout()
            CType(Me.pboxXY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudXY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudModEntryX, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudModEntryY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudModEntryZ, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagModuleAdvanced.SuspendLayout()
            CType(Me.nudXPScale, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarXPScale, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMinutesPerHour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDawnStartHour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDuskStartHour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStartHour, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStartDay, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStartMonth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStartYear, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagModuleEvents.SuspendLayout()
            Me.tabpagModuleDescription.SuspendLayout()
            Me.TabPage6.SuspendLayout()
            Me.TabControlArea.SuspendLayout()
            Me.tabpagAreaBasic.SuspendLayout()
            CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAreaEnvironment.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.nudChanceSnow, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudChanceRain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudChanceLightning, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbMoon.SuspendLayout()
            CType(Me.trkbarMoonFogNear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarMoonFogFar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbSun.SuspendLayout()
            CType(Me.trkbarSunFogNear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarSunFogFar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudShadowOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAreaGrass.SuspendLayout()
            CType(Me.nudGrassDensity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarGrassDensityX10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassProbUL, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassProbLL, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassProbUR, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassProbLR, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGrassQuadSize, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAreaAudio.SuspendLayout()
            CType(Me.trkbarAmbientSndNightVol, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarAmbientSndDayVol, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMusicDelay, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagArea_Events.SuspendLayout()
            Me.tabpagAreaRooms.SuspendLayout()
            CType(Me.nudRoomAmbientScale, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRoomForceRating, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(552, 747)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControlMain)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 90)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(14)
            Me.pnlBody.Size = New System.Drawing.Size(550, 585)
            Me.pnlBody.TabIndex = 1
            '
            'TabControlMain
            '
            Me.TabControlMain.Controls.Add(Me.TabPage5)
            Me.TabControlMain.Controls.Add(Me.TabPage6)
            Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlMain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControlMain.Location = New System.Drawing.Point(14, 14)
            Me.TabControlMain.Name = "TabControlMain"
            Me.TabControlMain.Padding = New System.Drawing.Point(12, 3)
            Me.TabControlMain.SelectedIndex = 0
            Me.TabControlMain.Size = New System.Drawing.Size(522, 557)
            Me.TabControlMain.TabIndex = 1
            '
            'TabPage5
            '
            Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage5.Controls.Add(Me.TabControlModule)
            Me.TabPage5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage5.Location = New System.Drawing.Point(4, 22)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Size = New System.Drawing.Size(514, 531)
            Me.TabPage5.TabIndex = 0
            Me.TabPage5.Text = "Module"
            '
            'TabControlModule
            '
            Me.TabControlModule.Controls.Add(Me.tabpagModuleBasic)
            Me.TabControlModule.Controls.Add(Me.tabpagModuleAdvanced)
            Me.TabControlModule.Controls.Add(Me.tabpagModuleEvents)
            Me.TabControlModule.Controls.Add(Me.tabpagModuleDescription)
            Me.TabControlModule.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlModule.Location = New System.Drawing.Point(0, 0)
            Me.TabControlModule.Name = "TabControlModule"
            Me.TabControlModule.Padding = New System.Drawing.Point(12, 3)
            Me.TabControlModule.SelectedIndex = 0
            Me.TabControlModule.Size = New System.Drawing.Size(514, 531)
            Me.TabControlModule.TabIndex = 0
            '
            'tabpagModuleBasic
            '
            Me.tabpagModuleBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagModuleBasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagModuleBasic.Location = New System.Drawing.Point(4, 22)
            Me.tabpagModuleBasic.Name = "tabpagModuleBasic"
            Me.tabpagModuleBasic.Size = New System.Drawing.Size(506, 505)
            Me.tabpagModuleBasic.TabIndex = 0
            Me.tabpagModuleBasic.Text = "Basic"
            '
            'pboxXY
            '
            Me.pboxXY.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pboxXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pboxXY.Location = New System.Drawing.Point(350, 178)
            Me.pboxXY.Name = "pboxXY"
            Me.pboxXY.Size = New System.Drawing.Size(50, 57)
            Me.pboxXY.TabIndex = 22
            Me.pboxXY.TabStop = False
            '
            'nudXY
            '
            Me.nudXY.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudXY.DecimalPlaces = 2
            Me.nudXY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudXY.Location = New System.Drawing.Point(334, 249)
            Me.nudXY.Maximum = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            Me.nudXY.Name = "nudXY"
            Me.nudXY.Size = New System.Drawing.Size(84, 22)
            Me.nudXY.TabIndex = 23
            Me.nudXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblBearing
            '
            Me.lblBearing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBearing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblBearing.Location = New System.Drawing.Point(336, 150)
            Me.lblBearing.Name = "lblBearing"
            Me.lblBearing.Size = New System.Drawing.Size(80, 21)
            Me.lblBearing.TabIndex = 21
            Me.lblBearing.Text = "Bearing"
            Me.lblBearing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label11
            '
            Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(28, 171)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(120, 21)
            Me.Label11.TabIndex = 19
            Me.Label11.Text = "Starting Position X"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudModEntryX
            '
            Me.nudModEntryX.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudModEntryX.DecimalPlaces = 4
            Me.nudModEntryX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudModEntryX.Location = New System.Drawing.Point(168, 168)
            Me.nudModEntryX.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudModEntryX.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.nudModEntryX.Name = "nudModEntryX"
            Me.nudModEntryX.Size = New System.Drawing.Size(104, 22)
            Me.nudModEntryX.TabIndex = 4
            Me.nudModEntryX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label12
            '
            Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(28, 210)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(120, 21)
            Me.Label12.TabIndex = 20
            Me.Label12.Text = "Starting Position Y"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudModEntryY
            '
            Me.nudModEntryY.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudModEntryY.DecimalPlaces = 4
            Me.nudModEntryY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudModEntryY.Location = New System.Drawing.Point(168, 208)
            Me.nudModEntryY.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudModEntryY.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.nudModEntryY.Name = "nudModEntryY"
            Me.nudModEntryY.Size = New System.Drawing.Size(104, 22)
            Me.nudModEntryY.TabIndex = 5
            Me.nudModEntryY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label13
            '
            Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(28, 249)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(120, 21)
            Me.Label13.TabIndex = 18
            Me.Label13.Text = "Starting Position Z"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudModEntryZ
            '
            Me.nudModEntryZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudModEntryZ.DecimalPlaces = 4
            Me.nudModEntryZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudModEntryZ.Location = New System.Drawing.Point(168, 247)
            Me.nudModEntryZ.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudModEntryZ.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.nudModEntryZ.Name = "nudModEntryZ"
            Me.nudModEntryZ.Size = New System.Drawing.Size(104, 22)
            Me.nudModEntryZ.TabIndex = 6
            Me.nudModEntryZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnSetModNameLang
            '
            Me.btnSetModNameLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetModNameLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetModNameLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSetModNameLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSetModNameLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetModNameLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSetModNameLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetModNameLang.Location = New System.Drawing.Point(334, 44)
            Me.btnSetModNameLang.Name = "btnSetModNameLang"
            Me.btnSetModNameLang.Size = New System.Drawing.Size(116, 32)
            Me.btnSetModNameLang.TabIndex = 1
            Me.btnSetModNameLang.Text = "Set Language"
            Me.btnSetModNameLang.UseVisualStyleBackColor = False
            '
            'tbModTag
            '
            Me.tbModTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbModTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbModTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbModTag.Location = New System.Drawing.Point(128, 83)
            Me.tbModTag.Name = "tbModTag"
            Me.tbModTag.Size = New System.Drawing.Size(104, 22)
            Me.tbModTag.TabIndex = 2
            '
            'tbModName
            '
            Me.tbModName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbModName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbModName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbModName.Location = New System.Drawing.Point(128, 46)
            Me.tbModName.Name = "tbModName"
            Me.tbModName.Size = New System.Drawing.Size(184, 22)
            Me.tbModName.TabIndex = 0
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(28, 48)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(80, 21)
            Me.Label8.TabIndex = 10
            Me.Label8.Text = "Name"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(28, 85)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(80, 21)
            Me.Label9.TabIndex = 11
            Me.Label9.Text = "Tag"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbModEntryArea
            '
            Me.tbModEntryArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbModEntryArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbModEntryArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbModEntryArea.Location = New System.Drawing.Point(128, 129)
            Me.tbModEntryArea.Name = "tbModEntryArea"
            Me.tbModEntryArea.Size = New System.Drawing.Size(184, 22)
            Me.tbModEntryArea.TabIndex = 3
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(28, 132)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(80, 20)
            Me.Label10.TabIndex = 10
            Me.Label10.Text = "Start Area"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tabpagModuleAdvanced
            '
            Me.tabpagModuleAdvanced.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagModuleAdvanced.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagModuleAdvanced.Location = New System.Drawing.Point(4, 22)
            Me.tabpagModuleAdvanced.Name = "tabpagModuleAdvanced"
            Me.tabpagModuleAdvanced.Size = New System.Drawing.Size(506, 505)
            Me.tabpagModuleAdvanced.TabIndex = 2
            Me.tabpagModuleAdvanced.Text = "Advanced"
            '
            'nudXPScale
            '
            Me.nudXPScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudXPScale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudXPScale.Location = New System.Drawing.Point(358, 321)
            Me.nudXPScale.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
            Me.nudXPScale.Name = "nudXPScale"
            Me.nudXPScale.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudXPScale.Size = New System.Drawing.Size(56, 22)
            Me.nudXPScale.TabIndex = 8
            Me.nudXPScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'trkbarXPScale
            '
            Me.trkbarXPScale.Location = New System.Drawing.Point(146, 312)
            Me.trkbarXPScale.Maximum = 200
            Me.trkbarXPScale.Name = "trkbarXPScale"
            Me.trkbarXPScale.Size = New System.Drawing.Size(206, 45)
            Me.trkbarXPScale.TabIndex = 7
            Me.trkbarXPScale.TickFrequency = 10
            '
            'Label46
            '
            Me.Label46.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label46.Location = New System.Drawing.Point(30, 48)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(104, 21)
            Me.Label46.TabIndex = 5
            Me.Label46.Text = "Minutes/Hour"
            Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudMinutesPerHour
            '
            Me.nudMinutesPerHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudMinutesPerHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudMinutesPerHour.Location = New System.Drawing.Point(146, 46)
            Me.nudMinutesPerHour.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
            Me.nudMinutesPerHour.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMinutesPerHour.Name = "nudMinutesPerHour"
            Me.nudMinutesPerHour.Size = New System.Drawing.Size(56, 22)
            Me.nudMinutesPerHour.TabIndex = 0
            Me.nudMinutesPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudMinutesPerHour.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(30, 88)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(104, 20)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Dawn Start Hour"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudDawnStartHour
            '
            Me.nudDawnStartHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudDawnStartHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudDawnStartHour.Location = New System.Drawing.Point(146, 85)
            Me.nudDawnStartHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudDawnStartHour.Name = "nudDawnStartHour"
            Me.nudDawnStartHour.Size = New System.Drawing.Size(56, 22)
            Me.nudDawnStartHour.TabIndex = 1
            Me.nudDawnStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(30, 127)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(104, 21)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Dusk Start Hour"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudDuskStartHour
            '
            Me.nudDuskStartHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudDuskStartHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudDuskStartHour.Location = New System.Drawing.Point(146, 125)
            Me.nudDuskStartHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudDuskStartHour.Name = "nudDuskStartHour"
            Me.nudDuskStartHour.Size = New System.Drawing.Size(56, 22)
            Me.nudDuskStartHour.TabIndex = 2
            Me.nudDuskStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(30, 245)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(104, 20)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Starting Month"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudStartHour
            '
            Me.nudStartHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudStartHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudStartHour.Location = New System.Drawing.Point(146, 164)
            Me.nudStartHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudStartHour.Name = "nudStartHour"
            Me.nudStartHour.Size = New System.Drawing.Size(56, 22)
            Me.nudStartHour.TabIndex = 3
            Me.nudStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(30, 205)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(104, 21)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Starting Day"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudStartDay
            '
            Me.nudStartDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudStartDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudStartDay.Location = New System.Drawing.Point(146, 203)
            Me.nudStartDay.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
            Me.nudStartDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudStartDay.Name = "nudStartDay"
            Me.nudStartDay.Size = New System.Drawing.Size(56, 22)
            Me.nudStartDay.TabIndex = 4
            Me.nudStartDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudStartDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(30, 166)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(104, 21)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "Starting Hour"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudStartMonth
            '
            Me.nudStartMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudStartMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudStartMonth.Location = New System.Drawing.Point(146, 242)
            Me.nudStartMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
            Me.nudStartMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudStartMonth.Name = "nudStartMonth"
            Me.nudStartMonth.Size = New System.Drawing.Size(56, 22)
            Me.nudStartMonth.TabIndex = 5
            Me.nudStartMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudStartMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(30, 284)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(104, 21)
            Me.Label6.TabIndex = 5
            Me.Label6.Text = "Starting Year"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudStartYear
            '
            Me.nudStartYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudStartYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudStartYear.Location = New System.Drawing.Point(146, 282)
            Me.nudStartYear.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudStartYear.Name = "nudStartYear"
            Me.nudStartYear.Size = New System.Drawing.Size(56, 22)
            Me.nudStartYear.TabIndex = 6
            Me.nudStartYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(30, 323)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(104, 21)
            Me.Label7.TabIndex = 5
            Me.Label7.Text = "XP Scale"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tabpagModuleEvents
            '
            Me.tabpagModuleEvents.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagModuleEvents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagModuleEvents.Location = New System.Drawing.Point(4, 22)
            Me.tabpagModuleEvents.Name = "tabpagModuleEvents"
            Me.tabpagModuleEvents.Size = New System.Drawing.Size(506, 505)
            Me.tabpagModuleEvents.TabIndex = 1
            Me.tabpagModuleEvents.Text = "Events"
            '
            'Label34
            '
            Me.Label34.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label34.Location = New System.Drawing.Point(30, 102)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(120, 23)
            Me.Label34.TabIndex = 28
            Me.Label34.Text = "OnClientEnter"
            Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnClientEntr
            '
            Me.tbMod_OnClientEntr.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnClientEntr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnClientEntr.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnClientEntr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnClientEntr.Location = New System.Drawing.Point(168, 102)
            Me.tbMod_OnClientEntr.MaxLength = 16
            Me.tbMod_OnClientEntr.Name = "tbMod_OnClientEntr"
            Me.tbMod_OnClientEntr.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnClientEntr.TabIndex = 2
            '
            'Label33
            '
            Me.Label33.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label33.Location = New System.Drawing.Point(30, 72)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(120, 23)
            Me.Label33.TabIndex = 18
            Me.Label33.Text = "OnActivateItem"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnActvtItem
            '
            Me.tbMod_OnActvtItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnActvtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnActvtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnActvtItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnActvtItem.Location = New System.Drawing.Point(168, 72)
            Me.tbMod_OnActvtItem.MaxLength = 16
            Me.tbMod_OnActvtItem.Name = "tbMod_OnActvtItem"
            Me.tbMod_OnActvtItem.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnActvtItem.TabIndex = 1
            '
            'Label32
            '
            Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label32.Location = New System.Drawing.Point(30, 42)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(120, 23)
            Me.Label32.TabIndex = 15
            Me.Label32.Text = "OnAcquireItem"
            Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnAcquirItem
            '
            Me.tbMod_OnAcquirItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnAcquirItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnAcquirItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnAcquirItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnAcquirItem.Location = New System.Drawing.Point(168, 42)
            Me.tbMod_OnAcquirItem.MaxLength = 16
            Me.tbMod_OnAcquirItem.Name = "tbMod_OnAcquirItem"
            Me.tbMod_OnAcquirItem.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnAcquirItem.TabIndex = 0
            '
            'Label35
            '
            Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label35.Location = New System.Drawing.Point(30, 132)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(120, 23)
            Me.Label35.TabIndex = 27
            Me.Label35.Text = "OnClientLeave"
            Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnClientLeav
            '
            Me.tbMod_OnClientLeav.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnClientLeav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnClientLeav.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnClientLeav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnClientLeav.Location = New System.Drawing.Point(168, 132)
            Me.tbMod_OnClientLeav.MaxLength = 16
            Me.tbMod_OnClientLeav.Name = "tbMod_OnClientLeav"
            Me.tbMod_OnClientLeav.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnClientLeav.TabIndex = 3
            '
            'tbMod_OnHeartbeat
            '
            Me.tbMod_OnHeartbeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnHeartbeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnHeartbeat.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnHeartbeat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnHeartbeat.Location = New System.Drawing.Point(168, 162)
            Me.tbMod_OnHeartbeat.MaxLength = 16
            Me.tbMod_OnHeartbeat.Name = "tbMod_OnHeartbeat"
            Me.tbMod_OnHeartbeat.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnHeartbeat.TabIndex = 4
            '
            'Label36
            '
            Me.Label36.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label36.Location = New System.Drawing.Point(30, 162)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(120, 23)
            Me.Label36.TabIndex = 26
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label37
            '
            Me.Label37.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label37.Location = New System.Drawing.Point(30, 192)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(120, 23)
            Me.Label37.TabIndex = 31
            Me.Label37.Text = "OnModuleLoad"
            Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnModLoad
            '
            Me.tbMod_OnModLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnModLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnModLoad.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnModLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnModLoad.Location = New System.Drawing.Point(168, 192)
            Me.tbMod_OnModLoad.MaxLength = 16
            Me.tbMod_OnModLoad.Name = "tbMod_OnModLoad"
            Me.tbMod_OnModLoad.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnModLoad.TabIndex = 5
            '
            'tbMod_OnPlrDeath
            '
            Me.tbMod_OnPlrDeath.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnPlrDeath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnPlrDeath.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnPlrDeath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnPlrDeath.Location = New System.Drawing.Point(168, 222)
            Me.tbMod_OnPlrDeath.MaxLength = 16
            Me.tbMod_OnPlrDeath.Name = "tbMod_OnPlrDeath"
            Me.tbMod_OnPlrDeath.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnPlrDeath.TabIndex = 6
            '
            'Label38
            '
            Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label38.Location = New System.Drawing.Point(30, 222)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(120, 23)
            Me.Label38.TabIndex = 21
            Me.Label38.Text = "OnPlayerDeath"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnPlrDying
            '
            Me.tbMod_OnPlrDying.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnPlrDying.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnPlrDying.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnPlrDying.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnPlrDying.Location = New System.Drawing.Point(168, 252)
            Me.tbMod_OnPlrDying.MaxLength = 16
            Me.tbMod_OnPlrDying.Name = "tbMod_OnPlrDying"
            Me.tbMod_OnPlrDying.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnPlrDying.TabIndex = 7
            '
            'Label39
            '
            Me.Label39.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label39.Location = New System.Drawing.Point(30, 252)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(120, 23)
            Me.Label39.TabIndex = 20
            Me.Label39.Text = "OnPlayerDying"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label40
            '
            Me.Label40.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label40.Location = New System.Drawing.Point(30, 282)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(120, 23)
            Me.Label40.TabIndex = 25
            Me.Label40.Text = "OnPlayerLevelUp"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnPlrLvlUp
            '
            Me.tbMod_OnPlrLvlUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnPlrLvlUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnPlrLvlUp.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnPlrLvlUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnPlrLvlUp.Location = New System.Drawing.Point(168, 282)
            Me.tbMod_OnPlrLvlUp.MaxLength = 16
            Me.tbMod_OnPlrLvlUp.Name = "tbMod_OnPlrLvlUp"
            Me.tbMod_OnPlrLvlUp.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnPlrLvlUp.TabIndex = 8
            '
            'Label41
            '
            Me.Label41.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label41.Location = New System.Drawing.Point(30, 312)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(120, 23)
            Me.Label41.TabIndex = 23
            Me.Label41.Text = "OnPlayerRespawn"
            Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnSpawnBtnDn
            '
            Me.tbMod_OnSpawnBtnDn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnSpawnBtnDn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnSpawnBtnDn.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnSpawnBtnDn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnSpawnBtnDn.Location = New System.Drawing.Point(168, 312)
            Me.tbMod_OnSpawnBtnDn.MaxLength = 16
            Me.tbMod_OnSpawnBtnDn.Name = "tbMod_OnSpawnBtnDn"
            Me.tbMod_OnSpawnBtnDn.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnSpawnBtnDn.TabIndex = 9
            '
            'tbMod_OnPlrRest
            '
            Me.tbMod_OnPlrRest.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnPlrRest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnPlrRest.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnPlrRest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnPlrRest.Location = New System.Drawing.Point(168, 342)
            Me.tbMod_OnPlrRest.MaxLength = 16
            Me.tbMod_OnPlrRest.Name = "tbMod_OnPlrRest"
            Me.tbMod_OnPlrRest.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnPlrRest.TabIndex = 10
            '
            'Label42
            '
            Me.Label42.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label42.Location = New System.Drawing.Point(30, 342)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(120, 23)
            Me.Label42.TabIndex = 24
            Me.Label42.Text = "OnPlayerRest"
            Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnUnAqreItem
            '
            Me.tbMod_OnUnAqreItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnUnAqreItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnUnAqreItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnUnAqreItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnUnAqreItem.Location = New System.Drawing.Point(168, 372)
            Me.tbMod_OnUnAqreItem.MaxLength = 16
            Me.tbMod_OnUnAqreItem.Name = "tbMod_OnUnAqreItem"
            Me.tbMod_OnUnAqreItem.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnUnAqreItem.TabIndex = 11
            '
            'Label43
            '
            Me.Label43.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label43.Location = New System.Drawing.Point(30, 372)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(120, 23)
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUnacquireItem"
            Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label44
            '
            Me.Label44.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label44.Location = New System.Drawing.Point(30, 402)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(120, 23)
            Me.Label44.TabIndex = 29
            Me.Label44.Text = "OnUserDefined"
            Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMod_OnUsrDefined
            '
            Me.tbMod_OnUsrDefined.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbMod_OnUsrDefined.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMod_OnUsrDefined.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbMod_OnUsrDefined.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMod_OnUsrDefined.Location = New System.Drawing.Point(168, 402)
            Me.tbMod_OnUsrDefined.MaxLength = 16
            Me.tbMod_OnUsrDefined.Name = "tbMod_OnUsrDefined"
            Me.tbMod_OnUsrDefined.Size = New System.Drawing.Size(220, 22)
            Me.tbMod_OnUsrDefined.TabIndex = 12
            '
            'tabpagModuleDescription
            '
            Me.tabpagModuleDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagModuleDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.tabpagModuleDescription.Controls.Add(Me.tbModDescription)
            Me.tabpagModuleDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagModuleDescription.Location = New System.Drawing.Point(4, 22)
            Me.tabpagModuleDescription.Name = "tabpagModuleDescription"
            Me.tabpagModuleDescription.Size = New System.Drawing.Size(506, 505)
            Me.tabpagModuleDescription.TabIndex = 3
            Me.tabpagModuleDescription.Text = "Description"
            '
            'btnSetDescriptionLang
            '
            Me.btnSetDescriptionLang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSetDescriptionLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetDescriptionLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetDescriptionLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSetDescriptionLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSetDescriptionLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetDescriptionLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSetDescriptionLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetDescriptionLang.Location = New System.Drawing.Point(374, 456)
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Me.btnSetDescriptionLang.Size = New System.Drawing.Size(112, 33)
            Me.btnSetDescriptionLang.TabIndex = 1
            Me.btnSetDescriptionLang.Text = "Set Language"
            Me.btnSetDescriptionLang.UseVisualStyleBackColor = False
            '
            'tbModDescription
            '
            Me.tbModDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbModDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbModDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbModDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbModDescription.Location = New System.Drawing.Point(14, 16)
            Me.tbModDescription.Multiline = True
            Me.tbModDescription.Name = "tbModDescription"
            Me.tbModDescription.Size = New System.Drawing.Size(478, 426)
            Me.tbModDescription.TabIndex = 0
            '
            'TabPage6
            '
            Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage6.Controls.Add(Me.TabControlArea)
            Me.TabPage6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage6.Location = New System.Drawing.Point(4, 22)
            Me.TabPage6.Name = "TabPage6"
            Me.TabPage6.Size = New System.Drawing.Size(514, 531)
            Me.TabPage6.TabIndex = 1
            Me.TabPage6.Text = "Area"
            '
            'TabControlArea
            '
            Me.TabControlArea.Controls.Add(Me.tabpagAreaBasic)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaEnvironment)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaGrass)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaAudio)
            Me.TabControlArea.Controls.Add(Me.tabpagArea_Events)
            Me.TabControlArea.Controls.Add(Me.tabpagAreaRooms)
            Me.TabControlArea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControlArea.Location = New System.Drawing.Point(0, 0)
            Me.TabControlArea.Name = "TabControlArea"
            Me.TabControlArea.Padding = New System.Drawing.Point(12, 3)
            Me.TabControlArea.SelectedIndex = 0
            Me.TabControlArea.Size = New System.Drawing.Size(514, 531)
            Me.TabControlArea.TabIndex = 0
            '
            'tabpagAreaBasic
            '
            Me.tabpagAreaBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagAreaBasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagAreaBasic.Location = New System.Drawing.Point(4, 22)
            Me.tabpagAreaBasic.Name = "tabpagAreaBasic"
            Me.tabpagAreaBasic.Size = New System.Drawing.Size(506, 505)
            Me.tabpagAreaBasic.TabIndex = 1
            Me.tabpagAreaBasic.Text = "Basic"
            '
            'chkbUnescapable
            '
            Me.chkbUnescapable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbUnescapable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUnescapable.Location = New System.Drawing.Point(132, 166)
            Me.chkbUnescapable.Name = "chkbUnescapable"
            Me.chkbUnescapable.Size = New System.Drawing.Size(32, 28)
            Me.chkbUnescapable.TabIndex = 23
            '
            'Label19
            '
            Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(28, 127)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(96, 21)
            Me.Label19.TabIndex = 22
            Me.Label19.Text = "Camera Style"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxCameraStyle
            '
            Me.cmbxCameraStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxCameraStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxCameraStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxCameraStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxCameraStyle.Location = New System.Drawing.Point(132, 125)
            Me.cmbxCameraStyle.Name = "cmbxCameraStyle"
            Me.cmbxCameraStyle.Size = New System.Drawing.Size(140, 21)
            Me.cmbxCameraStyle.TabIndex = 21
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.Transparent
            Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(88, 353)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(104, 21)
            Me.Label14.TabIndex = 19
            Me.Label14.Text = "Starting Position X"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label14.Visible = False
            '
            'NumericUpDown10
            '
            Me.NumericUpDown10.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.NumericUpDown10.DecimalPlaces = 4
            Me.NumericUpDown10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.NumericUpDown10.Location = New System.Drawing.Point(208, 353)
            Me.NumericUpDown10.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.NumericUpDown10.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.NumericUpDown10.Name = "NumericUpDown10"
            Me.NumericUpDown10.Size = New System.Drawing.Size(96, 22)
            Me.NumericUpDown10.TabIndex = 16
            Me.NumericUpDown10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown10.Visible = False
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.Transparent
            Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(88, 390)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(104, 21)
            Me.Label15.TabIndex = 20
            Me.Label15.Text = "Starting Position Y"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label15.Visible = False
            '
            'NumericUpDown11
            '
            Me.NumericUpDown11.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.NumericUpDown11.DecimalPlaces = 4
            Me.NumericUpDown11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.NumericUpDown11.Location = New System.Drawing.Point(208, 390)
            Me.NumericUpDown11.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.NumericUpDown11.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.NumericUpDown11.Name = "NumericUpDown11"
            Me.NumericUpDown11.Size = New System.Drawing.Size(96, 22)
            Me.NumericUpDown11.TabIndex = 15
            Me.NumericUpDown11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown11.Visible = False
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label16.Location = New System.Drawing.Point(88, 427)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(104, 21)
            Me.Label16.TabIndex = 18
            Me.Label16.Text = "Starting Position Z"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label16.Visible = False
            '
            'NumericUpDown12
            '
            Me.NumericUpDown12.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.NumericUpDown12.DecimalPlaces = 4
            Me.NumericUpDown12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.NumericUpDown12.Location = New System.Drawing.Point(208, 427)
            Me.NumericUpDown12.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.NumericUpDown12.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.NumericUpDown12.Name = "NumericUpDown12"
            Me.NumericUpDown12.Size = New System.Drawing.Size(96, 22)
            Me.NumericUpDown12.TabIndex = 17
            Me.NumericUpDown12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown12.Visible = False
            '
            'btnSetAreaNameLang
            '
            Me.btnSetAreaNameLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetAreaNameLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetAreaNameLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSetAreaNameLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSetAreaNameLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetAreaNameLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSetAreaNameLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetAreaNameLang.Location = New System.Drawing.Point(396, 43)
            Me.btnSetAreaNameLang.Name = "btnSetAreaNameLang"
            Me.btnSetAreaNameLang.Size = New System.Drawing.Size(96, 32)
            Me.btnSetAreaNameLang.TabIndex = 1
            Me.btnSetAreaNameLang.Text = "Set Language"
            Me.btnSetAreaNameLang.UseVisualStyleBackColor = False
            '
            'tbAreaTag
            '
            Me.tbAreaTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbAreaTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbAreaTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbAreaTag.Location = New System.Drawing.Point(132, 85)
            Me.tbAreaTag.Name = "tbAreaTag"
            Me.tbAreaTag.Size = New System.Drawing.Size(120, 22)
            Me.tbAreaTag.TabIndex = 2
            '
            'tbAreaName
            '
            Me.tbAreaName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbAreaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbAreaName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbAreaName.Location = New System.Drawing.Point(132, 46)
            Me.tbAreaName.Name = "tbAreaName"
            Me.tbAreaName.Size = New System.Drawing.Size(256, 22)
            Me.tbAreaName.TabIndex = 0
            '
            'Label17
            '
            Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(28, 48)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(96, 21)
            Me.Label17.TabIndex = 10
            Me.Label17.Text = "Name"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label18
            '
            Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(28, 88)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(96, 20)
            Me.Label18.TabIndex = 11
            Me.Label18.Text = "Tag"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label85
            '
            Me.Label85.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label85.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label85.Location = New System.Drawing.Point(28, 171)
            Me.Label85.Name = "Label85"
            Me.Label85.Size = New System.Drawing.Size(96, 21)
            Me.Label85.TabIndex = 22
            Me.Label85.Text = "Unescapable"
            Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbDisableTransit
            '
            Me.chkbDisableTransit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbDisableTransit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbDisableTransit.Location = New System.Drawing.Point(132, 205)
            Me.chkbDisableTransit.Name = "chkbDisableTransit"
            Me.chkbDisableTransit.Size = New System.Drawing.Size(32, 28)
            Me.chkbDisableTransit.TabIndex = 23
            '
            'Label86
            '
            Me.Label86.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label86.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label86.Location = New System.Drawing.Point(28, 210)
            Me.Label86.Name = "Label86"
            Me.Label86.Size = New System.Drawing.Size(96, 21)
            Me.Label86.TabIndex = 22
            Me.Label86.Text = "Disable Transit"
            Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tabpagAreaEnvironment
            '
            Me.tabpagAreaEnvironment.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagAreaEnvironment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagAreaEnvironment.Location = New System.Drawing.Point(4, 22)
            Me.tabpagAreaEnvironment.Name = "tabpagAreaEnvironment"
            Me.tabpagAreaEnvironment.Size = New System.Drawing.Size(506, 490)
            Me.tabpagAreaEnvironment.TabIndex = 4
            Me.tabpagAreaEnvironment.Text = "Environment"
            '
            'cmbxWindPower
            '
            Me.cmbxWindPower.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxWindPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxWindPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxWindPower.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxWindPower.Items.AddRange(New Object() {"Calm", "Light", "Heavy"})
            Me.cmbxWindPower.Location = New System.Drawing.Point(348, 413)
            Me.cmbxWindPower.Name = "cmbxWindPower"
            Me.cmbxWindPower.Size = New System.Drawing.Size(112, 21)
            Me.cmbxWindPower.TabIndex = 26
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.Label49)
            Me.GroupBox1.Controls.Add(Me.nudChanceSnow)
            Me.GroupBox1.Controls.Add(Me.Label50)
            Me.GroupBox1.Controls.Add(Me.nudChanceRain)
            Me.GroupBox1.Controls.Add(Me.Label51)
            Me.GroupBox1.Controls.Add(Me.nudChanceLightning)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox1.Location = New System.Drawing.Point(18, 397)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(210, 101)
            Me.GroupBox1.TabIndex = 25
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Weather"
            '
            'Label49
            '
            Me.Label49.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label49.Location = New System.Drawing.Point(10, 21)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(104, 18)
            Me.Label49.TabIndex = 24
            Me.Label49.Text = "% Chance Snow"
            Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudChanceSnow
            '
            Me.nudChanceSnow.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudChanceSnow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudChanceSnow.Location = New System.Drawing.Point(138, 18)
            Me.nudChanceSnow.Name = "nudChanceSnow"
            Me.nudChanceSnow.Size = New System.Drawing.Size(56, 22)
            Me.nudChanceSnow.TabIndex = 0
            Me.nudChanceSnow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label50
            '
            Me.Label50.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label50.Location = New System.Drawing.Point(10, 48)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(104, 19)
            Me.Label50.TabIndex = 24
            Me.Label50.Text = "% Chance Rain"
            Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudChanceRain
            '
            Me.nudChanceRain.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudChanceRain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudChanceRain.Location = New System.Drawing.Point(138, 46)
            Me.nudChanceRain.Name = "nudChanceRain"
            Me.nudChanceRain.Size = New System.Drawing.Size(56, 22)
            Me.nudChanceRain.TabIndex = 1
            Me.nudChanceRain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label51
            '
            Me.Label51.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label51.Location = New System.Drawing.Point(10, 76)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(124, 19)
            Me.Label51.TabIndex = 24
            Me.Label51.Text = "% Chance Lightning"
            Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudChanceLightning
            '
            Me.nudChanceLightning.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudChanceLightning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudChanceLightning.Location = New System.Drawing.Point(138, 74)
            Me.nudChanceLightning.Name = "nudChanceLightning"
            Me.nudChanceLightning.Size = New System.Drawing.Size(56, 22)
            Me.nudChanceLightning.TabIndex = 2
            Me.nudChanceLightning.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'rbDayNightCycle
            '
            Me.rbDayNightCycle.BackColor = System.Drawing.Color.Transparent
            Me.rbDayNightCycle.Checked = True
            Me.rbDayNightCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbDayNightCycle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbDayNightCycle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbDayNightCycle.Location = New System.Drawing.Point(40, 9)
            Me.rbDayNightCycle.Name = "rbDayNightCycle"
            Me.rbDayNightCycle.Size = New System.Drawing.Size(152, 21)
            Me.rbDayNightCycle.TabIndex = 0
            Me.rbDayNightCycle.TabStop = True
            Me.rbDayNightCycle.Text = "Cycle Day and Night"
            Me.rbDayNightCycle.UseVisualStyleBackColor = False
            '
            'gbMoon
            '
            Me.gbMoon.BackColor = System.Drawing.Color.Transparent
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
            Me.gbMoon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbMoon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gbMoon.Location = New System.Drawing.Point(18, 231)
            Me.gbMoon.Name = "gbMoon"
            Me.gbMoon.Size = New System.Drawing.Size(468, 157)
            Me.gbMoon.TabIndex = 21
            Me.gbMoon.TabStop = False
            Me.gbMoon.Text = "Moon"
            '
            'btnMoonDiffuseColor
            '
            Me.btnMoonDiffuseColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnMoonDiffuseColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnMoonDiffuseColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnMoonDiffuseColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnMoonDiffuseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMoonDiffuseColor.Location = New System.Drawing.Point(112, 46)
            Me.btnMoonDiffuseColor.Name = "btnMoonDiffuseColor"
            Me.btnMoonDiffuseColor.Size = New System.Drawing.Size(18, 21)
            Me.btnMoonDiffuseColor.TabIndex = 1
            Me.btnMoonDiffuseColor.UseVisualStyleBackColor = False
            '
            'Label24
            '
            Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(16, 18)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(88, 19)
            Me.Label24.TabIndex = 21
            Me.Label24.Text = "Ambient Color"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(16, 46)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(88, 19)
            Me.Label25.TabIndex = 20
            Me.Label25.Text = "Diffuse Color"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnMoonAmbientColor
            '
            Me.btnMoonAmbientColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnMoonAmbientColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnMoonAmbientColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnMoonAmbientColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnMoonAmbientColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMoonAmbientColor.Location = New System.Drawing.Point(112, 18)
            Me.btnMoonAmbientColor.Name = "btnMoonAmbientColor"
            Me.btnMoonAmbientColor.Size = New System.Drawing.Size(18, 21)
            Me.btnMoonAmbientColor.TabIndex = 0
            Me.btnMoonAmbientColor.UseVisualStyleBackColor = False
            '
            'Label31
            '
            Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label31.Location = New System.Drawing.Point(16, 129)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(88, 19)
            Me.Label31.TabIndex = 16
            Me.Label31.Text = "Shadows"
            Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label45
            '
            Me.Label45.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label45.Location = New System.Drawing.Point(16, 102)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(88, 18)
            Me.Label45.TabIndex = 16
            Me.Label45.Text = "Fog Color"
            Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnMoonFogColor
            '
            Me.btnMoonFogColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnMoonFogColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnMoonFogColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnMoonFogColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnMoonFogColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMoonFogColor.Location = New System.Drawing.Point(112, 102)
            Me.btnMoonFogColor.Name = "btnMoonFogColor"
            Me.btnMoonFogColor.Size = New System.Drawing.Size(18, 20)
            Me.btnMoonFogColor.TabIndex = 3
            Me.btnMoonFogColor.UseVisualStyleBackColor = False
            '
            'chkbAreaMoonShadows
            '
            Me.chkbAreaMoonShadows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbAreaMoonShadows.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAreaMoonShadows.Location = New System.Drawing.Point(112, 129)
            Me.chkbAreaMoonShadows.Name = "chkbAreaMoonShadows"
            Me.chkbAreaMoonShadows.Size = New System.Drawing.Size(32, 19)
            Me.chkbAreaMoonShadows.TabIndex = 4
            '
            'Label47
            '
            Me.Label47.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label47.Location = New System.Drawing.Point(16, 74)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(88, 18)
            Me.Label47.TabIndex = 16
            Me.Label47.Text = "Fog Enabled"
            Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbMoonFogOn
            '
            Me.chkbMoonFogOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbMoonFogOn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbMoonFogOn.Location = New System.Drawing.Point(112, 74)
            Me.chkbMoonFogOn.Name = "chkbMoonFogOn"
            Me.chkbMoonFogOn.Size = New System.Drawing.Size(32, 18)
            Me.chkbMoonFogOn.TabIndex = 2
            '
            'trkbarMoonFogNear
            '
            Me.trkbarMoonFogNear.Enabled = False
            Me.trkbarMoonFogNear.Location = New System.Drawing.Point(246, 28)
            Me.trkbarMoonFogNear.Maximum = 2000
            Me.trkbarMoonFogNear.Name = "trkbarMoonFogNear"
            Me.trkbarMoonFogNear.Size = New System.Drawing.Size(200, 45)
            Me.trkbarMoonFogNear.TabIndex = 5
            Me.trkbarMoonFogNear.TickFrequency = 50
            Me.trkbarMoonFogNear.TickStyle = System.Windows.Forms.TickStyle.TopLeft
            '
            'lblMoonFogNear
            '
            Me.lblMoonFogNear.Enabled = False
            Me.lblMoonFogNear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMoonFogNear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblMoonFogNear.Location = New System.Drawing.Point(168, 37)
            Me.lblMoonFogNear.Name = "lblMoonFogNear"
            Me.lblMoonFogNear.Size = New System.Drawing.Size(72, 18)
            Me.lblMoonFogNear.TabIndex = 16
            Me.lblMoonFogNear.Text = "Fog Near"
            Me.lblMoonFogNear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'trkbarMoonFogFar
            '
            Me.trkbarMoonFogFar.Enabled = False
            Me.trkbarMoonFogFar.Location = New System.Drawing.Point(246, 102)
            Me.trkbarMoonFogFar.Maximum = 2000
            Me.trkbarMoonFogFar.Name = "trkbarMoonFogFar"
            Me.trkbarMoonFogFar.Size = New System.Drawing.Size(200, 45)
            Me.trkbarMoonFogFar.TabIndex = 6
            Me.trkbarMoonFogFar.TickFrequency = 50
            Me.trkbarMoonFogFar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
            '
            'lblMoonFogFar
            '
            Me.lblMoonFogFar.Enabled = False
            Me.lblMoonFogFar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMoonFogFar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblMoonFogFar.Location = New System.Drawing.Point(168, 102)
            Me.lblMoonFogFar.Name = "lblMoonFogFar"
            Me.lblMoonFogFar.Size = New System.Drawing.Size(72, 18)
            Me.lblMoonFogFar.TabIndex = 16
            Me.lblMoonFogFar.Text = "Fog Far"
            Me.lblMoonFogFar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'gbSun
            '
            Me.gbSun.BackColor = System.Drawing.Color.Transparent
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
            Me.gbSun.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbSun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gbSun.Location = New System.Drawing.Point(18, 65)
            Me.gbSun.Name = "gbSun"
            Me.gbSun.Size = New System.Drawing.Size(468, 157)
            Me.gbSun.TabIndex = 20
            Me.gbSun.TabStop = False
            Me.gbSun.Text = "Sun"
            '
            'chkbAreaSunShadows
            '
            Me.chkbAreaSunShadows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbAreaSunShadows.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAreaSunShadows.Location = New System.Drawing.Point(112, 129)
            Me.chkbAreaSunShadows.Name = "chkbAreaSunShadows"
            Me.chkbAreaSunShadows.Size = New System.Drawing.Size(32, 19)
            Me.chkbAreaSunShadows.TabIndex = 4
            '
            'trkbarSunFogNear
            '
            Me.trkbarSunFogNear.Enabled = False
            Me.trkbarSunFogNear.Location = New System.Drawing.Point(246, 28)
            Me.trkbarSunFogNear.Maximum = 2000
            Me.trkbarSunFogNear.Name = "trkbarSunFogNear"
            Me.trkbarSunFogNear.Size = New System.Drawing.Size(200, 45)
            Me.trkbarSunFogNear.TabIndex = 5
            Me.trkbarSunFogNear.TickFrequency = 50
            Me.trkbarSunFogNear.TickStyle = System.Windows.Forms.TickStyle.TopLeft
            '
            'Label27
            '
            Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label27.Location = New System.Drawing.Point(16, 46)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(88, 19)
            Me.Label27.TabIndex = 16
            Me.Label27.Text = "Diffuse Color"
            Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnSunAmbientColor
            '
            Me.btnSunAmbientColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSunAmbientColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSunAmbientColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSunAmbientColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSunAmbientColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSunAmbientColor.Location = New System.Drawing.Point(112, 18)
            Me.btnSunAmbientColor.Name = "btnSunAmbientColor"
            Me.btnSunAmbientColor.Size = New System.Drawing.Size(18, 21)
            Me.btnSunAmbientColor.TabIndex = 0
            Me.btnSunAmbientColor.UseVisualStyleBackColor = False
            '
            'Label26
            '
            Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label26.Location = New System.Drawing.Point(16, 18)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(88, 19)
            Me.Label26.TabIndex = 17
            Me.Label26.Text = "Ambient Color"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnSunDiffuseColor
            '
            Me.btnSunDiffuseColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSunDiffuseColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSunDiffuseColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSunDiffuseColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSunDiffuseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSunDiffuseColor.Location = New System.Drawing.Point(112, 46)
            Me.btnSunDiffuseColor.Name = "btnSunDiffuseColor"
            Me.btnSunDiffuseColor.Size = New System.Drawing.Size(18, 21)
            Me.btnSunDiffuseColor.TabIndex = 1
            Me.btnSunDiffuseColor.UseVisualStyleBackColor = False
            '
            'Label28
            '
            Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label28.Location = New System.Drawing.Point(16, 102)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(88, 18)
            Me.Label28.TabIndex = 16
            Me.Label28.Text = "Fog Color"
            Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnSunFogColor
            '
            Me.btnSunFogColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSunFogColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSunFogColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSunFogColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSunFogColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSunFogColor.Location = New System.Drawing.Point(112, 102)
            Me.btnSunFogColor.Name = "btnSunFogColor"
            Me.btnSunFogColor.Size = New System.Drawing.Size(18, 20)
            Me.btnSunFogColor.TabIndex = 3
            Me.btnSunFogColor.UseVisualStyleBackColor = False
            '
            'Label29
            '
            Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label29.Location = New System.Drawing.Point(16, 74)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(88, 18)
            Me.Label29.TabIndex = 16
            Me.Label29.Text = "Fog Enabled"
            Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label30
            '
            Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label30.Location = New System.Drawing.Point(16, 129)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(88, 19)
            Me.Label30.TabIndex = 16
            Me.Label30.Text = "Shadows"
            Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'trkbarSunFogFar
            '
            Me.trkbarSunFogFar.Enabled = False
            Me.trkbarSunFogFar.Location = New System.Drawing.Point(246, 92)
            Me.trkbarSunFogFar.Maximum = 2000
            Me.trkbarSunFogFar.Name = "trkbarSunFogFar"
            Me.trkbarSunFogFar.Size = New System.Drawing.Size(200, 45)
            Me.trkbarSunFogFar.TabIndex = 6
            Me.trkbarSunFogFar.TickFrequency = 50
            Me.trkbarSunFogFar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
            '
            'lblSunFogNear
            '
            Me.lblSunFogNear.Enabled = False
            Me.lblSunFogNear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSunFogNear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSunFogNear.Location = New System.Drawing.Point(168, 37)
            Me.lblSunFogNear.Name = "lblSunFogNear"
            Me.lblSunFogNear.Size = New System.Drawing.Size(72, 18)
            Me.lblSunFogNear.TabIndex = 16
            Me.lblSunFogNear.Text = "Fog Near"
            Me.lblSunFogNear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSunFogFar
            '
            Me.lblSunFogFar.Enabled = False
            Me.lblSunFogFar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSunFogFar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSunFogFar.Location = New System.Drawing.Point(168, 102)
            Me.lblSunFogFar.Name = "lblSunFogFar"
            Me.lblSunFogFar.Size = New System.Drawing.Size(72, 18)
            Me.lblSunFogFar.TabIndex = 16
            Me.lblSunFogFar.Text = "Fog Far"
            Me.lblSunFogFar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbSunFogOn
            '
            Me.chkbSunFogOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbSunFogOn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbSunFogOn.Location = New System.Drawing.Point(112, 74)
            Me.chkbSunFogOn.Name = "chkbSunFogOn"
            Me.chkbSunFogOn.Size = New System.Drawing.Size(32, 18)
            Me.chkbSunFogOn.TabIndex = 2
            '
            'rbAlwaysDay
            '
            Me.rbAlwaysDay.BackColor = System.Drawing.Color.Transparent
            Me.rbAlwaysDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbAlwaysDay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAlwaysDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbAlwaysDay.Location = New System.Drawing.Point(40, 30)
            Me.rbAlwaysDay.Name = "rbAlwaysDay"
            Me.rbAlwaysDay.Size = New System.Drawing.Size(104, 21)
            Me.rbAlwaysDay.TabIndex = 1
            Me.rbAlwaysDay.Text = "Always Day"
            Me.rbAlwaysDay.UseVisualStyleBackColor = False
            '
            'rbAlwaysNight
            '
            Me.rbAlwaysNight.BackColor = System.Drawing.Color.Transparent
            Me.rbAlwaysNight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbAlwaysNight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAlwaysNight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbAlwaysNight.Location = New System.Drawing.Point(40, 51)
            Me.rbAlwaysNight.Name = "rbAlwaysNight"
            Me.rbAlwaysNight.Size = New System.Drawing.Size(104, 21)
            Me.rbAlwaysNight.TabIndex = 2
            Me.rbAlwaysNight.Text = "Always Night"
            Me.rbAlwaysNight.UseVisualStyleBackColor = False
            '
            'btnDynAmbientColor
            '
            Me.btnDynAmbientColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnDynAmbientColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnDynAmbientColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnDynAmbientColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnDynAmbientColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDynAmbientColor.Location = New System.Drawing.Point(396, 12)
            Me.btnDynAmbientColor.Name = "btnDynAmbientColor"
            Me.btnDynAmbientColor.Size = New System.Drawing.Size(18, 20)
            Me.btnDynAmbientColor.TabIndex = 3
            Me.btnDynAmbientColor.UseVisualStyleBackColor = False
            '
            'Label48
            '
            Me.Label48.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label48.Location = New System.Drawing.Point(232, 12)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(150, 20)
            Me.Label48.TabIndex = 17
            Me.Label48.Text = "Dynamic Ambient Color"
            Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label73
            '
            Me.Label73.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label73.Location = New System.Drawing.Point(232, 39)
            Me.Label73.Name = "Label73"
            Me.Label73.Size = New System.Drawing.Size(104, 21)
            Me.Label73.TabIndex = 24
            Me.Label73.Text = "Shadow Opacity"
            Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudShadowOpacity
            '
            Me.nudShadowOpacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudShadowOpacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudShadowOpacity.Location = New System.Drawing.Point(356, 37)
            Me.nudShadowOpacity.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudShadowOpacity.Name = "nudShadowOpacity"
            Me.nudShadowOpacity.Size = New System.Drawing.Size(56, 22)
            Me.nudShadowOpacity.TabIndex = 0
            Me.nudShadowOpacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label84
            '
            Me.Label84.Enabled = False
            Me.Label84.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label84.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label84.Location = New System.Drawing.Point(248, 415)
            Me.Label84.Name = "Label84"
            Me.Label84.Size = New System.Drawing.Size(96, 21)
            Me.Label84.TabIndex = 16
            Me.Label84.Text = "Wind Strength"
            Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tabpagAreaGrass
            '
            Me.tabpagAreaGrass.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagAreaGrass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagAreaGrass.Location = New System.Drawing.Point(4, 22)
            Me.tabpagAreaGrass.Name = "tabpagAreaGrass"
            Me.tabpagAreaGrass.Size = New System.Drawing.Size(506, 490)
            Me.tabpagAreaGrass.TabIndex = 2
            Me.tabpagAreaGrass.Text = "Grass"
            '
            'nudGrassDensity
            '
            Me.nudGrassDensity.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudGrassDensity.DecimalPlaces = 2
            Me.nudGrassDensity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudGrassDensity.Location = New System.Drawing.Point(334, 369)
            Me.nudGrassDensity.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.nudGrassDensity.Name = "nudGrassDensity"
            Me.nudGrassDensity.Size = New System.Drawing.Size(62, 22)
            Me.nudGrassDensity.TabIndex = 19
            Me.nudGrassDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'trkbarGrassDensityX10
            '
            Me.trkbarGrassDensityX10.Location = New System.Drawing.Point(118, 360)
            Me.trkbarGrassDensityX10.Maximum = 500
            Me.trkbarGrassDensityX10.Name = "trkbarGrassDensityX10"
            Me.trkbarGrassDensityX10.Size = New System.Drawing.Size(210, 45)
            Me.trkbarGrassDensityX10.TabIndex = 17
            Me.trkbarGrassDensityX10.TickFrequency = 10
            '
            'Label62
            '
            Me.Label62.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label62.Location = New System.Drawing.Point(24, 369)
            Me.Label62.Name = "Label62"
            Me.Label62.Size = New System.Drawing.Size(90, 21)
            Me.Label62.TabIndex = 18
            Me.Label62.Text = "Grass Density"
            Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGrassDiffuseColor
            '
            Me.btnGrassDiffuseColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnGrassDiffuseColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnGrassDiffuseColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnGrassDiffuseColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnGrassDiffuseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGrassDiffuseColor.Location = New System.Drawing.Point(128, 120)
            Me.btnGrassDiffuseColor.Name = "btnGrassDiffuseColor"
            Me.btnGrassDiffuseColor.Size = New System.Drawing.Size(18, 21)
            Me.btnGrassDiffuseColor.TabIndex = 15
            Me.btnGrassDiffuseColor.UseVisualStyleBackColor = False
            '
            'tbGrass_TexName
            '
            Me.tbGrass_TexName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbGrass_TexName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbGrass_TexName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbGrass_TexName.Location = New System.Drawing.Point(128, 46)
            Me.tbGrass_TexName.MaxLength = 16
            Me.tbGrass_TexName.Name = "tbGrass_TexName"
            Me.tbGrass_TexName.Size = New System.Drawing.Size(176, 22)
            Me.tbGrass_TexName.TabIndex = 14
            '
            'Label20
            '
            Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label20.Location = New System.Drawing.Point(24, 48)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(96, 21)
            Me.Label20.TabIndex = 13
            Me.Label20.Text = "Texture Name"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label21
            '
            Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label21.Location = New System.Drawing.Point(24, 92)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(96, 21)
            Me.Label21.TabIndex = 13
            Me.Label21.Text = "Ambient Color"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label22
            '
            Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(24, 120)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(96, 21)
            Me.Label22.TabIndex = 13
            Me.Label22.Text = "Diffuse Color"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGrassAmbientColor
            '
            Me.btnGrassAmbientColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnGrassAmbientColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnGrassAmbientColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnGrassAmbientColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnGrassAmbientColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGrassAmbientColor.Location = New System.Drawing.Point(128, 92)
            Me.btnGrassAmbientColor.Name = "btnGrassAmbientColor"
            Me.btnGrassAmbientColor.Size = New System.Drawing.Size(18, 21)
            Me.btnGrassAmbientColor.TabIndex = 15
            Me.btnGrassAmbientColor.UseVisualStyleBackColor = False
            '
            'Label23
            '
            Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label23.Location = New System.Drawing.Point(24, 148)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(96, 20)
            Me.Label23.TabIndex = 13
            Me.Label23.Text = "Emissive Color"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGrassEmissiveColor
            '
            Me.btnGrassEmissiveColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnGrassEmissiveColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnGrassEmissiveColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnGrassEmissiveColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnGrassEmissiveColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGrassEmissiveColor.Location = New System.Drawing.Point(128, 148)
            Me.btnGrassEmissiveColor.Name = "btnGrassEmissiveColor"
            Me.btnGrassEmissiveColor.Size = New System.Drawing.Size(18, 20)
            Me.btnGrassEmissiveColor.TabIndex = 15
            Me.btnGrassEmissiveColor.UseVisualStyleBackColor = False
            '
            'nudGrassProbUL
            '
            Me.nudGrassProbUL.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudGrassProbUL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudGrassProbUL.Location = New System.Drawing.Point(168, 249)
            Me.nudGrassProbUL.Name = "nudGrassProbUL"
            Me.nudGrassProbUL.Size = New System.Drawing.Size(44, 22)
            Me.nudGrassProbUL.TabIndex = 19
            Me.nudGrassProbUL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassProbUL.Value = New Decimal(New Integer() {25, 0, 0, 0})
            '
            'nudGrassProbLL
            '
            Me.nudGrassProbLL.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudGrassProbLL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudGrassProbLL.Location = New System.Drawing.Point(168, 314)
            Me.nudGrassProbLL.Name = "nudGrassProbLL"
            Me.nudGrassProbLL.Size = New System.Drawing.Size(44, 22)
            Me.nudGrassProbLL.TabIndex = 19
            Me.nudGrassProbLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassProbLL.Value = New Decimal(New Integer() {25, 0, 0, 0})
            '
            'nudGrassProbUR
            '
            Me.nudGrassProbUR.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudGrassProbUR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudGrassProbUR.Location = New System.Drawing.Point(280, 249)
            Me.nudGrassProbUR.Name = "nudGrassProbUR"
            Me.nudGrassProbUR.Size = New System.Drawing.Size(44, 22)
            Me.nudGrassProbUR.TabIndex = 19
            Me.nudGrassProbUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassProbUR.Value = New Decimal(New Integer() {25, 0, 0, 0})
            '
            'nudGrassProbLR
            '
            Me.nudGrassProbLR.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudGrassProbLR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudGrassProbLR.Location = New System.Drawing.Point(280, 314)
            Me.nudGrassProbLR.Name = "nudGrassProbLR"
            Me.nudGrassProbLR.Size = New System.Drawing.Size(44, 22)
            Me.nudGrassProbLR.TabIndex = 19
            Me.nudGrassProbLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassProbLR.Value = New Decimal(New Integer() {25, 0, 0, 0})
            '
            'Label63
            '
            Me.Label63.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label63.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label63.Location = New System.Drawing.Point(24, 258)
            Me.Label63.Name = "Label63"
            Me.Label63.Size = New System.Drawing.Size(96, 56)
            Me.Label63.TabIndex = 18
            Me.Label63.Text = "Grass Movement Probability"
            Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label64
            '
            Me.Label64.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label64.Location = New System.Drawing.Point(232, 240)
            Me.Label64.Name = "Label64"
            Me.Label64.Size = New System.Drawing.Size(48, 37)
            Me.Label64.TabIndex = 13
            Me.Label64.Text = "Upper Right"
            Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label65
            '
            Me.Label65.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label65.Location = New System.Drawing.Point(120, 240)
            Me.Label65.Name = "Label65"
            Me.Label65.Size = New System.Drawing.Size(48, 37)
            Me.Label65.TabIndex = 13
            Me.Label65.Text = "Upper Left"
            Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label66
            '
            Me.Label66.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label66.Location = New System.Drawing.Point(120, 305)
            Me.Label66.Name = "Label66"
            Me.Label66.Size = New System.Drawing.Size(48, 37)
            Me.Label66.TabIndex = 13
            Me.Label66.Text = "Lower Left"
            Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label67
            '
            Me.Label67.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label67.Location = New System.Drawing.Point(232, 305)
            Me.Label67.Name = "Label67"
            Me.Label67.Size = New System.Drawing.Size(48, 37)
            Me.Label67.TabIndex = 13
            Me.Label67.Text = "Lower Right"
            Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTotalGrassProbability
            '
            Me.lblTotalGrassProbability.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalGrassProbability.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTotalGrassProbability.Location = New System.Drawing.Point(352, 286)
            Me.lblTotalGrassProbability.Name = "lblTotalGrassProbability"
            Me.lblTotalGrassProbability.Size = New System.Drawing.Size(90, 21)
            Me.lblTotalGrassProbability.TabIndex = 18
            Me.lblTotalGrassProbability.Text = "Total: "
            Me.lblTotalGrassProbability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label69
            '
            Me.Label69.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label69.Location = New System.Drawing.Point(214, 252)
            Me.Label69.Name = "Label69"
            Me.Label69.Size = New System.Drawing.Size(16, 18)
            Me.Label69.TabIndex = 13
            Me.Label69.Text = "%"
            Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label70
            '
            Me.Label70.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label70.Location = New System.Drawing.Point(326, 252)
            Me.Label70.Name = "Label70"
            Me.Label70.Size = New System.Drawing.Size(16, 18)
            Me.Label70.TabIndex = 13
            Me.Label70.Text = "%"
            Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label71
            '
            Me.Label71.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label71.Location = New System.Drawing.Point(326, 316)
            Me.Label71.Name = "Label71"
            Me.Label71.Size = New System.Drawing.Size(16, 19)
            Me.Label71.TabIndex = 13
            Me.Label71.Text = "%"
            Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label72
            '
            Me.Label72.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label72.Location = New System.Drawing.Point(214, 316)
            Me.Label72.Name = "Label72"
            Me.Label72.Size = New System.Drawing.Size(16, 19)
            Me.Label72.TabIndex = 13
            Me.Label72.Text = "%"
            Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label68
            '
            Me.Label68.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label68.Location = New System.Drawing.Point(24, 185)
            Me.Label68.Name = "Label68"
            Me.Label68.Size = New System.Drawing.Size(112, 20)
            Me.Label68.TabIndex = 18
            Me.Label68.Text = "Grass Quad Size"
            Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudGrassQuadSize
            '
            Me.nudGrassQuadSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudGrassQuadSize.DecimalPlaces = 2
            Me.nudGrassQuadSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudGrassQuadSize.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudGrassQuadSize.Location = New System.Drawing.Point(128, 185)
            Me.nudGrassQuadSize.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.nudGrassQuadSize.Name = "nudGrassQuadSize"
            Me.nudGrassQuadSize.Size = New System.Drawing.Size(62, 22)
            Me.nudGrassQuadSize.TabIndex = 19
            Me.nudGrassQuadSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudGrassQuadSize.Value = New Decimal(New Integer() {10, 0, 0, 65536})
            '
            'tabpagAreaAudio
            '
            Me.tabpagAreaAudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagAreaAudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagAreaAudio.Location = New System.Drawing.Point(4, 22)
            Me.tabpagAreaAudio.Name = "tabpagAreaAudio"
            Me.tabpagAreaAudio.Size = New System.Drawing.Size(506, 490)
            Me.tabpagAreaAudio.TabIndex = 5
            Me.tabpagAreaAudio.Text = "Audio"
            '
            'trkbarAmbientSndNightVol
            '
            Me.trkbarAmbientSndNightVol.Location = New System.Drawing.Point(170, 166)
            Me.trkbarAmbientSndNightVol.Maximum = 127
            Me.trkbarAmbientSndNightVol.Name = "trkbarAmbientSndNightVol"
            Me.trkbarAmbientSndNightVol.Size = New System.Drawing.Size(230, 45)
            Me.trkbarAmbientSndNightVol.TabIndex = 3
            Me.trkbarAmbientSndNightVol.TickFrequency = 5
            '
            'trkbarAmbientSndDayVol
            '
            Me.trkbarAmbientSndDayVol.Location = New System.Drawing.Point(170, 74)
            Me.trkbarAmbientSndDayVol.Maximum = 127
            Me.trkbarAmbientSndDayVol.Name = "trkbarAmbientSndDayVol"
            Me.trkbarAmbientSndDayVol.Size = New System.Drawing.Size(230, 45)
            Me.trkbarAmbientSndDayVol.TabIndex = 1
            Me.trkbarAmbientSndDayVol.TickFrequency = 5
            '
            'Label52
            '
            Me.Label52.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label52.Location = New System.Drawing.Point(24, 48)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(130, 21)
            Me.Label52.TabIndex = 19
            Me.Label52.Text = "Ambient Sound - Day"
            Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudMusicDelay
            '
            Me.nudMusicDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudMusicDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudMusicDelay.Location = New System.Drawing.Point(170, 388)
            Me.nudMusicDelay.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
            Me.nudMusicDelay.Name = "nudMusicDelay"
            Me.nudMusicDelay.Size = New System.Drawing.Size(64, 22)
            Me.nudMusicDelay.TabIndex = 8
            Me.nudMusicDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cmbxMusicNight
            '
            Me.cmbxMusicNight.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxMusicNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMusicNight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxMusicNight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxMusicNight.Location = New System.Drawing.Point(170, 351)
            Me.cmbxMusicNight.Name = "cmbxMusicNight"
            Me.cmbxMusicNight.Size = New System.Drawing.Size(216, 21)
            Me.cmbxMusicNight.TabIndex = 7
            '
            'cmbxMusicDay
            '
            Me.cmbxMusicDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxMusicDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMusicDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxMusicDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxMusicDay.Location = New System.Drawing.Point(170, 314)
            Me.cmbxMusicDay.Name = "cmbxMusicDay"
            Me.cmbxMusicDay.Size = New System.Drawing.Size(216, 21)
            Me.cmbxMusicDay.TabIndex = 6
            '
            'cmbxMusicBattle
            '
            Me.cmbxMusicBattle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxMusicBattle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMusicBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxMusicBattle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxMusicBattle.Location = New System.Drawing.Point(170, 277)
            Me.cmbxMusicBattle.Name = "cmbxMusicBattle"
            Me.cmbxMusicBattle.Size = New System.Drawing.Size(216, 21)
            Me.cmbxMusicBattle.TabIndex = 5
            '
            'cmbxEnvAudio
            '
            Me.cmbxEnvAudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxEnvAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxEnvAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxEnvAudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxEnvAudio.Location = New System.Drawing.Point(170, 240)
            Me.cmbxEnvAudio.Name = "cmbxEnvAudio"
            Me.cmbxEnvAudio.Size = New System.Drawing.Size(216, 21)
            Me.cmbxEnvAudio.TabIndex = 4
            '
            'cmbxAmbientSndNight
            '
            Me.cmbxAmbientSndNight.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxAmbientSndNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxAmbientSndNight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxAmbientSndNight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxAmbientSndNight.Location = New System.Drawing.Point(170, 138)
            Me.cmbxAmbientSndNight.Name = "cmbxAmbientSndNight"
            Me.cmbxAmbientSndNight.Size = New System.Drawing.Size(216, 21)
            Me.cmbxAmbientSndNight.TabIndex = 2
            '
            'cmbxAmbientSndDay
            '
            Me.cmbxAmbientSndDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxAmbientSndDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxAmbientSndDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxAmbientSndDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxAmbientSndDay.Location = New System.Drawing.Point(170, 46)
            Me.cmbxAmbientSndDay.Name = "cmbxAmbientSndDay"
            Me.cmbxAmbientSndDay.Size = New System.Drawing.Size(216, 21)
            Me.cmbxAmbientSndDay.TabIndex = 0
            '
            'Label53
            '
            Me.Label53.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label53.Location = New System.Drawing.Point(24, 78)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(88, 21)
            Me.Label53.TabIndex = 19
            Me.Label53.Text = "Volume"
            Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label54
            '
            Me.Label54.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label54.Location = New System.Drawing.Point(24, 141)
            Me.Label54.Name = "Label54"
            Me.Label54.Size = New System.Drawing.Size(140, 21)
            Me.Label54.TabIndex = 19
            Me.Label54.Text = "Ambient Sound - Night"
            Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label55
            '
            Me.Label55.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label55.Location = New System.Drawing.Point(24, 171)
            Me.Label55.Name = "Label55"
            Me.Label55.Size = New System.Drawing.Size(88, 21)
            Me.Label55.TabIndex = 19
            Me.Label55.Text = "Volume"
            Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label56
            '
            Me.Label56.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label56.Location = New System.Drawing.Point(24, 235)
            Me.Label56.Name = "Label56"
            Me.Label56.Size = New System.Drawing.Size(130, 35)
            Me.Label56.TabIndex = 19
            Me.Label56.Text = "Environmental Audio Effects"
            Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label57
            '
            Me.Label57.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label57.Location = New System.Drawing.Point(24, 279)
            Me.Label57.Name = "Label57"
            Me.Label57.Size = New System.Drawing.Size(120, 21)
            Me.Label57.TabIndex = 19
            Me.Label57.Text = "Battle Music"
            Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label58
            '
            Me.Label58.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label58.Location = New System.Drawing.Point(24, 316)
            Me.Label58.Name = "Label58"
            Me.Label58.Size = New System.Drawing.Size(120, 21)
            Me.Label58.TabIndex = 19
            Me.Label58.Text = "Daytime Music"
            Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label59
            '
            Me.Label59.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label59.Location = New System.Drawing.Point(24, 353)
            Me.Label59.Name = "Label59"
            Me.Label59.Size = New System.Drawing.Size(120, 21)
            Me.Label59.TabIndex = 19
            Me.Label59.Text = "Nighttime Music"
            Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label60
            '
            Me.Label60.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label60.Location = New System.Drawing.Point(24, 390)
            Me.Label60.Name = "Label60"
            Me.Label60.Size = New System.Drawing.Size(120, 21)
            Me.Label60.TabIndex = 19
            Me.Label60.Text = "Music Delay"
            Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label61
            '
            Me.Label61.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label61.Location = New System.Drawing.Point(240, 390)
            Me.Label61.Name = "Label61"
            Me.Label61.Size = New System.Drawing.Size(88, 21)
            Me.Label61.TabIndex = 19
            Me.Label61.Text = "Seconds"
            Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tabpagArea_Events
            '
            Me.tabpagArea_Events.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagArea_Events.Controls.Add(Me.Label77)
            Me.tabpagArea_Events.Controls.Add(Me.tbArea_OnUserDefined)
            Me.tabpagArea_Events.Controls.Add(Me.tbArea_OnHeartbeat)
            Me.tabpagArea_Events.Controls.Add(Me.Label76)
            Me.tabpagArea_Events.Controls.Add(Me.Label74)
            Me.tabpagArea_Events.Controls.Add(Me.tbArea_OnEnter)
            Me.tabpagArea_Events.Controls.Add(Me.Label75)
            Me.tabpagArea_Events.Controls.Add(Me.tbArea_OnExit)
            Me.tabpagArea_Events.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagArea_Events.Location = New System.Drawing.Point(4, 22)
            Me.tabpagArea_Events.Name = "tabpagArea_Events"
            Me.tabpagArea_Events.Size = New System.Drawing.Size(506, 490)
            Me.tabpagArea_Events.TabIndex = 6
            Me.tabpagArea_Events.Text = "Events"
            '
            'Label77
            '
            Me.Label77.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label77.Location = New System.Drawing.Point(30, 138)
            Me.Label77.Name = "Label77"
            Me.Label77.Size = New System.Drawing.Size(120, 24)
            Me.Label77.TabIndex = 36
            Me.Label77.Text = "OnUserDefined"
            Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbArea_OnUserDefined
            '
            Me.tbArea_OnUserDefined.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbArea_OnUserDefined.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbArea_OnUserDefined.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbArea_OnUserDefined.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbArea_OnUserDefined.Location = New System.Drawing.Point(168, 136)
            Me.tbArea_OnUserDefined.MaxLength = 16
            Me.tbArea_OnUserDefined.Name = "tbArea_OnUserDefined"
            Me.tbArea_OnUserDefined.Size = New System.Drawing.Size(220, 22)
            Me.tbArea_OnUserDefined.TabIndex = 35
            '
            'tbArea_OnHeartbeat
            '
            Me.tbArea_OnHeartbeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbArea_OnHeartbeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbArea_OnHeartbeat.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbArea_OnHeartbeat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbArea_OnHeartbeat.Location = New System.Drawing.Point(168, 106)
            Me.tbArea_OnHeartbeat.MaxLength = 16
            Me.tbArea_OnHeartbeat.Name = "tbArea_OnHeartbeat"
            Me.tbArea_OnHeartbeat.Size = New System.Drawing.Size(220, 22)
            Me.tbArea_OnHeartbeat.TabIndex = 33
            '
            'Label76
            '
            Me.Label76.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label76.Location = New System.Drawing.Point(30, 108)
            Me.Label76.Name = "Label76"
            Me.Label76.Size = New System.Drawing.Size(120, 24)
            Me.Label76.TabIndex = 34
            Me.Label76.Text = "OnHeartbeat"
            Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label74
            '
            Me.Label74.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label74.Location = New System.Drawing.Point(30, 48)
            Me.Label74.Name = "Label74"
            Me.Label74.Size = New System.Drawing.Size(120, 24)
            Me.Label74.TabIndex = 32
            Me.Label74.Text = "OnEnter"
            Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbArea_OnEnter
            '
            Me.tbArea_OnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbArea_OnEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbArea_OnEnter.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbArea_OnEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbArea_OnEnter.Location = New System.Drawing.Point(168, 46)
            Me.tbArea_OnEnter.MaxLength = 16
            Me.tbArea_OnEnter.Name = "tbArea_OnEnter"
            Me.tbArea_OnEnter.Size = New System.Drawing.Size(220, 22)
            Me.tbArea_OnEnter.TabIndex = 29
            '
            'Label75
            '
            Me.Label75.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label75.Location = New System.Drawing.Point(30, 78)
            Me.Label75.Name = "Label75"
            Me.Label75.Size = New System.Drawing.Size(120, 24)
            Me.Label75.TabIndex = 31
            Me.Label75.Text = "OnExit"
            Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbArea_OnExit
            '
            Me.tbArea_OnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbArea_OnExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbArea_OnExit.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbArea_OnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbArea_OnExit.Location = New System.Drawing.Point(168, 76)
            Me.tbArea_OnExit.MaxLength = 16
            Me.tbArea_OnExit.Name = "tbArea_OnExit"
            Me.tbArea_OnExit.Size = New System.Drawing.Size(220, 22)
            Me.tbArea_OnExit.TabIndex = 30
            '
            'tabpagAreaRooms
            '
            Me.tabpagAreaRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagAreaRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagAreaRooms.Location = New System.Drawing.Point(4, 22)
            Me.tabpagAreaRooms.Name = "tabpagAreaRooms"
            Me.tabpagAreaRooms.Size = New System.Drawing.Size(506, 490)
            Me.tabpagAreaRooms.TabIndex = 7
            Me.tabpagAreaRooms.Text = "Rooms"
            '
            'lbRooms
            '
            Me.lbRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.lbRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbRooms.Location = New System.Drawing.Point(184, 46)
            Me.lbRooms.Name = "lbRooms"
            Me.lbRooms.ScrollAlwaysVisible = True
            Me.lbRooms.Size = New System.Drawing.Size(112, 119)
            Me.lbRooms.TabIndex = 41
            '
            'Label82
            '
            Me.Label82.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label82.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label82.Location = New System.Drawing.Point(24, 335)
            Me.Label82.Name = "Label82"
            Me.Label82.Size = New System.Drawing.Size(140, 23)
            Me.Label82.TabIndex = 40
            Me.Label82.Text = "Disable Weather"
            Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbRoomDisableWeather
            '
            Me.chkbRoomDisableWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbRoomDisableWeather.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbRoomDisableWeather.Location = New System.Drawing.Point(184, 335)
            Me.chkbRoomDisableWeather.Name = "chkbRoomDisableWeather"
            Me.chkbRoomDisableWeather.Size = New System.Drawing.Size(32, 18)
            Me.chkbRoomDisableWeather.TabIndex = 39
            '
            'nudRoomAmbientScale
            '
            Me.nudRoomAmbientScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudRoomAmbientScale.DecimalPlaces = 2
            Me.nudRoomAmbientScale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudRoomAmbientScale.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudRoomAmbientScale.Location = New System.Drawing.Point(184, 261)
            Me.nudRoomAmbientScale.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudRoomAmbientScale.Name = "nudRoomAmbientScale"
            Me.nudRoomAmbientScale.Size = New System.Drawing.Size(64, 22)
            Me.nudRoomAmbientScale.TabIndex = 38
            Me.nudRoomAmbientScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label80
            '
            Me.Label80.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label80.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label80.Location = New System.Drawing.Point(24, 261)
            Me.Label80.Name = "Label80"
            Me.Label80.Size = New System.Drawing.Size(140, 23)
            Me.Label80.TabIndex = 37
            Me.Label80.Text = "Ambient Sound Scale"
            Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxRoomEnvAudio
            '
            Me.cmbxRoomEnvAudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxRoomEnvAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxRoomEnvAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxRoomEnvAudio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxRoomEnvAudio.Location = New System.Drawing.Point(184, 224)
            Me.cmbxRoomEnvAudio.Name = "cmbxRoomEnvAudio"
            Me.cmbxRoomEnvAudio.Size = New System.Drawing.Size(206, 21)
            Me.cmbxRoomEnvAudio.TabIndex = 35
            '
            'Label79
            '
            Me.Label79.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label79.Location = New System.Drawing.Point(24, 224)
            Me.Label79.Name = "Label79"
            Me.Label79.Size = New System.Drawing.Size(152, 32)
            Me.Label79.TabIndex = 36
            Me.Label79.Text = "Environmental Audio Effects"
            Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label78
            '
            Me.Label78.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label78.Location = New System.Drawing.Point(24, 189)
            Me.Label78.Name = "Label78"
            Me.Label78.Size = New System.Drawing.Size(140, 23)
            Me.Label78.TabIndex = 34
            Me.Label78.Text = "Room Name"
            Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbRoomName
            '
            Me.tbRoomName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbRoomName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbRoomName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbRoomName.Location = New System.Drawing.Point(184, 187)
            Me.tbRoomName.MaxLength = 16
            Me.tbRoomName.Name = "tbRoomName"
            Me.tbRoomName.ReadOnly = True
            Me.tbRoomName.Size = New System.Drawing.Size(120, 22)
            Me.tbRoomName.TabIndex = 33
            '
            'nudRoomForceRating
            '
            Me.nudRoomForceRating.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudRoomForceRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudRoomForceRating.Location = New System.Drawing.Point(184, 298)
            Me.nudRoomForceRating.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
            Me.nudRoomForceRating.Name = "nudRoomForceRating"
            Me.nudRoomForceRating.Size = New System.Drawing.Size(64, 22)
            Me.nudRoomForceRating.TabIndex = 38
            Me.nudRoomForceRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label81
            '
            Me.Label81.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label81.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label81.Location = New System.Drawing.Point(24, 298)
            Me.Label81.Name = "Label81"
            Me.Label81.Size = New System.Drawing.Size(140, 23)
            Me.Label81.TabIndex = 37
            Me.Label81.Text = "Force Rating"
            Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label83
            '
            Me.Label83.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label83.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label83.Location = New System.Drawing.Point(24, 83)
            Me.Label83.Name = "Label83"
            Me.Label83.Size = New System.Drawing.Size(120, 23)
            Me.Label83.TabIndex = 34
            Me.Label83.Text = "Rooms"
            Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterRule)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 675)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(550, 70)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(550, 1)
            Me.lblFooterRule.TabIndex = 2
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(360, 20)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(80, 33)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New System.Drawing.Point(454, 20)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(80, 33)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
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
            Me.pnlHeader.Size = New System.Drawing.Size(550, 90)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(18, 12)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(510, 41)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Module Properties Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(20, 55)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(508, 23)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Restored KoTOR Tool module, area, environment, grass, audio, and room properties." &
    ""
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 87)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(550, 3)
            Me.lblHeaderRule.TabIndex = 2
            '
            'frmModuleIfo_AreaEditor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(552, 747)
            Me.Controls.Add(Me.pnlRoot)
            Me.MinimumSize = New System.Drawing.Size(568, 786)
            Me.Name = "frmModuleIfo_AreaEditor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Module Properties Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControlMain.ResumeLayout(False)
            Me.TabPage5.ResumeLayout(False)
            Me.TabControlModule.ResumeLayout(False)
            Me.tabpagModuleBasic.ResumeLayout(False)
            Me.tabpagModuleBasic.PerformLayout()
            CType(Me.pboxXY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudXY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudModEntryX, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudModEntryY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudModEntryZ, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagModuleAdvanced.ResumeLayout(False)
            Me.tabpagModuleAdvanced.PerformLayout()
            CType(Me.nudXPScale, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarXPScale, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMinutesPerHour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDawnStartHour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDuskStartHour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStartHour, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStartDay, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStartMonth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStartYear, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagModuleEvents.ResumeLayout(False)
            Me.tabpagModuleEvents.PerformLayout()
            Me.tabpagModuleDescription.ResumeLayout(False)
            Me.tabpagModuleDescription.PerformLayout()
            Me.TabPage6.ResumeLayout(False)
            Me.TabControlArea.ResumeLayout(False)
            Me.tabpagAreaBasic.ResumeLayout(False)
            Me.tabpagAreaBasic.PerformLayout()
            CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAreaEnvironment.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.nudChanceSnow, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudChanceRain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudChanceLightning, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbMoon.ResumeLayout(False)
            Me.gbMoon.PerformLayout()
            CType(Me.trkbarMoonFogNear, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarMoonFogFar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbSun.ResumeLayout(False)
            Me.gbSun.PerformLayout()
            CType(Me.trkbarSunFogNear, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarSunFogFar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudShadowOpacity, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAreaGrass.ResumeLayout(False)
            Me.tabpagAreaGrass.PerformLayout()
            CType(Me.nudGrassDensity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarGrassDensityX10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassProbUL, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassProbLL, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassProbUR, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassProbLR, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGrassQuadSize, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAreaAudio.ResumeLayout(False)
            Me.tabpagAreaAudio.PerformLayout()
            CType(Me.trkbarAmbientSndNightVol, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarAmbientSndDayVol, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMusicDelay, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagArea_Events.ResumeLayout(False)
            Me.tabpagArea_Events.PerformLayout()
            Me.tabpagAreaRooms.ResumeLayout(False)
            Me.tabpagAreaRooms.PerformLayout()
            CType(Me.nudRoomAmbientScale, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRoomForceRating, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
