Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000061 RID: 97
	Public Partial Class frmModuleIfo_AreaEditor
		Inherits frmParent

		' Token: 0x06000974 RID: 2420 RVA: 0x0026E444 File Offset: 0x0026D444
		Public Sub New()
			Me.ComboBoxSettingError = False
			Me.bmpXY = New Bitmap(50, 50)
			Me._XYAngle = 0.0
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06000B17 RID: 2839 RVA: 0x00278E54 File Offset: 0x00277E54
        Public Sub New(ByRef AREFile As clsGFF, ByRef IFOFile As clsGFF, ByRef GITFile As clsGFF, ByVal KotorVersion As Integer)
            Me.New()
            Me.KotorVersionIndex = KotorVersion
            Me.CurrentSettings = UserSettings.GetSettings()
            Me._DialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\dialog.tlk", False)
            Me._ChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me._AREFile = AREFile
            Me._IFOFile = IFOFile
            Me._GITFile = GITFile
            Me.FillForm()
        End Sub

        ' Token: 0x06000B18 RID: 2840 RVA: 0x00278EDC File Offset: 0x00277EDC
        Private Sub SetupRooms()
            Me.FillComboBoxFrom2DA(Me.cmbxRoomEnvAudio, "label", "soundeax", Me._ChitinKey, Nothing)
            Dim num As Integer = Me._AREFile.GetListItemCount("Rooms") - 1
            Me.Rooms = New frmModuleIfo_AreaEditor.Room(num + 1 - 1) {}
            Dim num2 As Integer = 0
            Dim num3 As Integer = num
            For i As Integer = num2 To num3
                Me.Rooms(i) = New frmModuleIfo_AreaEditor.Room()
                Me.Rooms(i).RoomName = StringType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").RoomName"))
                Me.Rooms(i).EnvAudio = IntegerType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").EnvAudio"))
                Me.Rooms(i).AmbientScale = SingleType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").AmbientScale"))
                Me.Rooms(i).ForceRating = IntegerType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").ForceRating"))
                Me.Rooms(i).DisableWeather = BooleanType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").DisableWeather"))
            Next
            Me.lbRooms.DataSource = Me.Rooms
            Me.lbRooms.DisplayMember = "Text"
        End Sub

        ' Token: 0x06000B19 RID: 2841 RVA: 0x00279064 File Offset: 0x00278064
        Private Sub ReadRooms()
            Dim num As Integer = 0
            Dim upperBound As Integer = Me.Rooms.GetUpperBound(0)
            For i As Integer = num To upperBound
                Me._AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(i) + ").EnvAudio", Me.Rooms(i).EnvAudio)
                Me._AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(i) + ").AmbientScale", Me.Rooms(i).AmbientScale)
                Me._AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(i) + ").ForceRating", Me.Rooms(i).ForceRating)
                Me._AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(i) + ").DisableWeather", Me.Rooms(i).DisableWeather)
            Next
        End Sub

        ' Token: 0x06000B1A RID: 2842 RVA: 0x00279158 File Offset: 0x00278158
        Private Sub FillForm()
            Me._IFOFile.SetTextBoxFromCExoLocStringNodeValue(Me.tbModName, "Mod_Name")
            Me.Mod_Tag = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_Tag"))
            Me.Mod_Entry_Area = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Area"))
            Me.Mod_Entry_X = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_X"))
            Me.Mod_Entry_Y = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Y"))
            Me.Mod_Entry_Z = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Z"))
            Me._origXPos = Me.Mod_Entry_X
            Me._origYpos = Me.Mod_Entry_Y
            Me._origZpos = Me.Mod_Entry_Z
            Me._origXOrientation = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Dir_X"))
            Me._origYOrientation = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Dir_Y"))
            Me.SetupOrientationIndicators(Me._origXOrientation, Me._origYOrientation)
            Me.Mod_MinutesPerHour = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_MinPerHour"))
            Me.Mod_DawnHour = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_DawnHour"))
            Me.Mod_DuskHour = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_DuskHour"))
            Me.Mod_StartHour = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_StartHour"))
            Me.Mod_StartDay = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_StartDay"))
            Me.Mod_StartMonth = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_StartMonth"))
            Me.Mod_StartYear = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me._IFOFile.GetNodeValue("Mod_StartYear")))
            Me.Mod_XPScale = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_XPScale"))
            Me.Mod_OnAcquirItem = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnAcquirItem"))
            Me.Mod_OnActvtItem = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnActvtItem"))
            Me.Mod_OnClientEntr = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnClientEntr"))
            Me.Mod_OnClientLeav = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnClientLeav"))
            Me.Mod_OnHeartbeat = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnHeartbeat"))
            Me.Mod_OnModLoad = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnModLoad"))
            Me.Mod_OnPlrDeath = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnPlrDeath"))
            Me.Mod_OnPlrDying = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnPlrDying"))
            Me.Mod_OnPlrLvlUp = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnPlrLvlUp"))
            Me.Mod_OnSpawnBtnDn = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnSpawnBtnDn"))
            Me.Mod_OnPlrRest = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnPlrRest"))
            Me.Mod_OnUnAqreItem = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnUnAqreItem"))
            Me.Mod_OnUsrDefined = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnUsrDefined"))
            Me._AREFile.SetTextBoxFromCExoLocStringNodeValue(Me.tbAreaName, "Name")
            Me._AREFile.SetTextBoxToNodeValue(Me.tbAreaTag, "Tag")
            Me.FillComboBoxFrom2DA(Me.cmbxCameraStyle, "name", "camerastyle", Me._ChitinKey, Me._DialogTlk)
            If Not Me._AREFile.SyncComboBox(Me.cmbxCameraStyle, "CameraStyle") Then
                Me.ComboBoxSettingError = True
            End If
            Me.chkbUnescapable.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("Unescapable"))
            Me.chkbDisableTransit.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("DisableTransit"))
            Me.rbDayNightCycle.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("DayNightCycle"))
            If Not Me.rbDayNightCycle.Checked Then
                If ObjectType.ObjTst(Me._AREFile.GetNodeValue("IsNight"), 1, False) = 0 Then
                    Me.rbAlwaysNight.Checked = True
                Else
                    Me.rbAlwaysDay.Checked = True
                End If
            End If
            Me.DynAmbientColor = CUInt((If(Me._AREFile.GetNodeValue("DynAmbientColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudShadowOpacity, "ShadowOpacity", 0.0F)
            Me.SunAmbientColor = CUInt((If(Me._AREFile.GetNodeValue("SunAmbientColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.SunDiffuseColor = CUInt((If(Me._AREFile.GetNodeValue("SunDiffuseColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.SunFogColor = CUInt((If(Me._AREFile.GetNodeValue("SunFogColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.chkbSunFogOn.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("SunFogOn"))
            Me.trkbarSunFogNear.Value = IntegerType.FromObject(Me._AREFile.GetNodeValue("SunFogNear"))
            Me.trkbarSunFogFar.Value = IntegerType.FromObject(Me._AREFile.GetNodeValue("SunFogFar"))
            Me.chkbAreaSunShadows.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("SunShadows"))
            Me.MoonAmbientColor = CUInt((If(Me._AREFile.GetNodeValue("MoonAmbientColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.MoonDiffuseColor = CUInt((If(Me._AREFile.GetNodeValue("MoonDiffuseColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.MoonFogColor = CUInt((If(Me._AREFile.GetNodeValue("MoonFogColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.chkbMoonFogOn.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("MoonFogOn"))
            Me.trkbarMoonFogNear.Value = IntegerType.FromObject(Me._AREFile.GetNodeValue("MoonFogNear"))
            Me.trkbarMoonFogFar.Value = IntegerType.FromObject(Me._AREFile.GetNodeValue("MoonFogFar"))
            Me.chkbAreaMoonShadows.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("MoonShadows"))
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudChanceSnow, "ChanceSnow", 0.0F)
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudChanceRain, "ChanceRain", 0.0F)
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudChanceLightning, "ChanceLightning", 0.0F)
            Me.FillComboBoxFrom2DA(Me.cmbxAmbientSndDay, "description", "ambientsound", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxAmbientSndDay, "AreaProperties.AmbientSndDay") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxAmbientSndNight, "description", "ambientsound", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxAmbientSndNight, "AreaProperties.AmbientSndNight") Then
                Me.ComboBoxSettingError = True
            End If
            Me.trkbarAmbientSndDayVol.Value = IntegerType.FromObject(Me._GITFile.GetNodeValue("AreaProperties.AmbientSndDayVol"))
            Me.trkbarAmbientSndNightVol.Value = IntegerType.FromObject(Me._GITFile.GetNodeValue("AreaProperties.AmbientSndNitVol"))
            Me.FillComboBoxFrom2DA(Me.cmbxEnvAudio, "label", "soundeax", Me._ChitinKey, Nothing)
            If Not Me._GITFile.SyncComboBox(Me.cmbxEnvAudio, "AreaProperties.EnvAudio") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxMusicBattle, "description", "ambientmusic", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxMusicBattle, "AreaProperties.MusicBattle") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxMusicDay, "description", "ambientmusic", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxMusicDay, "AreaProperties.MusicDay") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxMusicNight, "description", "ambientmusic", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxMusicNight, "AreaProperties.MusicNight") Then
                Me.ComboBoxSettingError = True
            End If
            Me.nudMusicDelay.Value = DecimalType.FromObject(ObjectType.DivObj(Me._GITFile.GetNodeValue("AreaProperties.MusicDelay"), 1000))
            If Me.ComboBoxSettingError Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
            Me._AREFile.SetTextBoxToNodeValue(Me.tbGrass_TexName, "Grass_TexName")
            Me.Grass_Ambient = CUInt((If(Me._AREFile.GetNodeValue("Grass_Ambient"), Activator.CreateInstance(GetType(UInteger)))))
            Me.Grass_Diffuse = CUInt((If(Me._AREFile.GetNodeValue("Grass_Diffuse"), Activator.CreateInstance(GetType(UInteger)))))
            Me.Grass_Emissive = CUInt((If(Me._AREFile.GetNodeValue("Grass_Emissive"), Activator.CreateInstance(GetType(UInteger)))))
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudGrassQuadSize, "Grass_QuadSize", 0.0F)
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudGrassDensity, "Grass_Density", 0.0F)
            Me.Grass_Prob_LL = SingleType.FromObject(Me._AREFile.GetNodeValue("Grass_Prob_LL"))
            Me.Grass_Prob_UL = SingleType.FromObject(Me._AREFile.GetNodeValue("Grass_Prob_UL"))
            Me.Grass_Prob_LR = SingleType.FromObject(Me._AREFile.GetNodeValue("Grass_Prob_LR"))
            Me.Grass_Prob_UR = SingleType.FromObject(Me._AREFile.GetNodeValue("Grass_Prob_UR"))
            Me._AREFile.SetTextBoxToNodeValue(Me.tbArea_OnEnter, "OnEnter")
            Me._AREFile.SetTextBoxToNodeValue(Me.tbArea_OnExit, "OnExit")
            Me._AREFile.SetTextBoxToNodeValue(Me.tbArea_OnHeartbeat, "OnHeartbeat")
            Me._AREFile.SetTextBoxToNodeValue(Me.tbArea_OnUserDefined, "OnUserDefined")
            Me.SetupRooms()
        End Sub

        ' Token: 0x06000B1B RID: 2843 RVA: 0x00279C48 File Offset: 0x00278C48
        Public Sub UpdateFiles()
            Me._IFOFile.SetCExoLocStringNodeValueFromTextBox(Me.tbModName, "Mod_Name", Me.ModNameLang)
            Me._IFOFile.SetNodeValue("Mod_Tag", Me.Mod_Tag)
            Me._IFOFile.SetNodeValue("Mod_Entry_Area", Me.Mod_Entry_Area)
            Me._IFOFile.SetNodeValue("Mod_Entry_X", Me.Mod_Entry_X)
            Me._IFOFile.SetNodeValue("Mod_Entry_Y", Me.Mod_Entry_Y)
            Me._IFOFile.SetNodeValue("Mod_Entry_Z", Me.Mod_Entry_Z)
            Me._IFOFile.SetNodeValue("Mod_Entry_Dir_X", Me.XOrientation)
            Me._IFOFile.SetNodeValue("Mod_Entry_Dir_Y", Me.YOrientation)
            Me._IFOFile.SetNodeValue("Mod_MinPerHour", Me.Mod_MinutesPerHour)
            Me._IFOFile.SetNodeValue("Mod_DawnHour", Me.Mod_DawnHour)
            Me._IFOFile.SetNodeValue("Mod_DuskHour", Me.Mod_DuskHour)
            Me._IFOFile.SetNodeValue("Mod_StartHour", Me.Mod_StartHour)
            Me._IFOFile.SetNodeValue("Mod_StartDay", Me.Mod_StartDay)
            Me._IFOFile.SetNodeValue("Mod_StartMonth", Me.Mod_StartMonth)
            Me._IFOFile.SetNodeValue("Mod_StartYear", Me.Mod_StartYear)
            Me._IFOFile.SetNodeValue("Mod_XPScale", Me.Mod_XPScale)
            Me._IFOFile.SetNodeValue("Mod_OnAcquirItem", Me.Mod_OnAcquirItem)
            Me._IFOFile.SetNodeValue("Mod_OnActvtItem", Me.Mod_OnActvtItem)
            Me._IFOFile.SetNodeValue("Mod_OnClientEntr", Me.Mod_OnClientEntr)
            Me._IFOFile.SetNodeValue("Mod_OnClientLeav", Me.Mod_OnClientLeav)
            Me._IFOFile.SetNodeValue("Mod_OnHeartbeat", Me.Mod_OnHeartbeat)
            Me._IFOFile.SetNodeValue("Mod_OnModLoad", Me.Mod_OnModLoad)
            Me._IFOFile.SetNodeValue("Mod_OnPlrDeath", Me.Mod_OnPlrDeath)
            Me._IFOFile.SetNodeValue("Mod_OnPlrDying", Me.Mod_OnPlrDying)
            Me._IFOFile.SetNodeValue("Mod_OnPlrLvlUp", Me.Mod_OnPlrLvlUp)
            Me._IFOFile.SetNodeValue("Mod_OnSpawnBtnDn", Me.Mod_OnSpawnBtnDn)
            Me._IFOFile.SetNodeValue("Mod_OnPlrRest", Me.Mod_OnPlrRest)
            Me._IFOFile.SetNodeValue("Mod_OnUnAqreItem", Me.Mod_OnUnAqreItem)
            Me._IFOFile.SetNodeValue("Mod_OnUsrDefined", Me.Mod_OnUsrDefined)
            Me._IFOFile.SetCExoLocStringNodeValueFromTextBox(Me.tbModDescription, "Mod_Description", Me.ModDescriptionLang)
            Me._AREFile.SetNodeValueFromTextBox(Me.tbAreaTag, "Tag")
            Me._AREFile.SetCExoLocStringNodeValueFromTextBox(Me.tbAreaName, "Name", Me.AreaNameLang)
            Me._AREFile.SetNodeValueFromComboBox(Me.cmbxCameraStyle, "CameraStyle")
            Me._AREFile.SetNodeValue("Unescapable", Me.chkbUnescapable.Checked)
            Me._AREFile.SetNodeValue("DisableTransit", Me.chkbDisableTransit.Checked)
            Me._AREFile.SetNodeValue("DayNightCycle", Me.rbDayNightCycle.Checked)
            Me._AREFile.SetNodeValue("IsNight", Me.rbAlwaysNight.Checked)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudShadowOpacity, "ShadowOpacity", 0.0F)
            Me._AREFile.SetNodeValue("DynAmbientColor", Me.DynAmbientColor)
            Me._AREFile.SetNodeValue("SunAmbientColor", Me.SunAmbientColor)
            Me._AREFile.SetNodeValue("SunDiffuseColor", Me.SunDiffuseColor)
            Me._AREFile.SetNodeValue("SunFogColor", Me.SunFogColor)
            Me._AREFile.SetNodeValue("SunFogOn", Me.chkbSunFogOn.Checked)
            Me._AREFile.SetNodeValue("SunFogNear", Me.trkbarSunFogNear.Value)
            Me._AREFile.SetNodeValue("SunFogFar", Me.trkbarSunFogFar.Value)
            Me._AREFile.SetNodeValue("SunShadows", Me.chkbAreaSunShadows.Checked)
            Me._AREFile.SetNodeValue("MoonAmbientColor", Me.MoonAmbientColor)
            Me._AREFile.SetNodeValue("MoonDiffuseColor", Me.MoonDiffuseColor)
            Me._AREFile.SetNodeValue("MoonFogColor", Me.MoonFogColor)
            Me._AREFile.SetNodeValue("MoonFogOn", Me.chkbMoonFogOn.Checked)
            Me._AREFile.SetNodeValue("MoonFogNear", Me.trkbarMoonFogNear.Value)
            Me._AREFile.SetNodeValue("MoonFogFar", Me.trkbarMoonFogFar.Value)
            Me._AREFile.SetNodeValue("MoonShadows", Me.chkbAreaMoonShadows.Checked)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudChanceSnow, "ChanceSnow", 0.0F)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudChanceRain, "ChanceRain", 0.0F)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudChanceLightning, "ChanceLightning", 0.0F)
            Me._AREFile.SetNodeValueFromTextBox(Me.tbGrass_TexName, "Grass_TexName")
            Me._AREFile.SetNodeValue("Grass_Ambient", Me.Grass_Ambient)
            Me._AREFile.SetNodeValue("Grass_Diffuse", Me.Grass_Diffuse)
            Me._AREFile.SetNodeValue("Grass_Emissive", Me.Grass_Emissive)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudGrassDensity, "Grass_Density", 0.0F)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudGrassQuadSize, "Grass_QuadSize", 0.0F)
            Me._AREFile.SetNodeValue("Grass_Prob_LL", Me.Grass_Prob_LL)
            Me._AREFile.SetNodeValue("Grass_Prob_UL", Me.Grass_Prob_UL)
            Me._AREFile.SetNodeValue("Grass_Prob_LR", Me.Grass_Prob_LR)
            Me._AREFile.SetNodeValue("Grass_Prob_UR", Me.Grass_Prob_UR)
            Me._AREFile.SetNodeValueFromTextBox(Me.tbArea_OnEnter, "OnEnter")
            Me._AREFile.SetNodeValueFromTextBox(Me.tbArea_OnExit, "OnExit")
            Me._AREFile.SetNodeValueFromTextBox(Me.tbArea_OnHeartbeat, "OnHeartbeat")
            Me._AREFile.SetNodeValueFromTextBox(Me.tbArea_OnUserDefined, "OnUserDefined")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxAmbientSndDay, "AreaProperties.AmbientSndDay")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxAmbientSndNight, "AreaProperties.AmbientSndNight")
            Me._GITFile.SetNodeValue("AreaProperties.AmbientSndDayVol", Me.trkbarAmbientSndDayVol.Value)
            Me._GITFile.SetNodeValue("AreaProperties.AmbientSndNitVol", Me.trkbarAmbientSndNightVol.Value)
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxEnvAudio, "AreaProperties.EnvAudio")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxMusicBattle, "AreaProperties.MusicBattle")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxMusicDay, "AreaProperties.MusicDay")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxMusicNight, "AreaProperties.MusicNight")
            Me._GITFile.SetNodeValue("AreaProperties.MusicDelay", Decimal.Multiply(Me.nudMusicDelay.Value, 1000D))
            Me.ReadRooms()
        End Sub

        ' Token: 0x06000B1C RID: 2844 RVA: 0x0027A488 File Offset: 0x00279488
        Private Function color2bgr(ByVal col As Color) As UInteger
            ' The following expression was wrapped in a checked-expression
            Return Convert.ToUInt32(CInt(col.B) * 65536 + CInt(col.G) * 256 + CInt(col.R))
        End Function

        ' Token: 0x06000B1D RID: 2845 RVA: 0x0027A4C0 File Offset: 0x002794C0
        Private Function bgr2color(ByVal bgr As UInteger) As Color
            Dim num As Integer = Convert.ToInt32(bgr)
            Dim num2 As Integer = num And 255
            Dim num3 As Integer = (num And 65280) >> 8
            Dim num4 As Integer = (num And 16711680) >> 16
            Return Color.FromArgb(255, num2, num3, num4)
        End Function

        ' Token: 0x06000B1E RID: 2846 RVA: 0x0027A500 File Offset: 0x00279500
        Public Function ReadCls2DA(ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey) As cls2DA
            Dim flag As Boolean = True
            Dim array As Byte()
            If Me.CurrentSettings.bUseOverrideFiles Then
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\override\" + TwoDAName + ".2da"
                Try
                    If File.Exists(text) Then
                        Dim fileStream As FileStream = New FileStream(text, FileMode.Open)
                        array = New Byte(CInt(fileStream.Length) + 1 - 1) {}
                        fileStream.Read(array, 0, CInt(fileStream.Length))
                        fileStream.Close()
                        flag = False
                        Console.WriteLine("Read " + TwoDAName + ".2da from override")
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = ChitinKey.FindResIDForResRef(TwoDAName, 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + ChitinKey.BiffList(num >> 20).filename
                array = BIFFArchive.getBIFFResource(text, num).data
                Console.WriteLine("Read " + TwoDAName + ".2da from 2da.bif")
            End If
            Return New cls2DA(array)
        End Function

        ' Token: 0x06000B1F RID: 2847 RVA: 0x0027A63C File Offset: 0x0027963C
        Private Sub FillComboBoxFrom2DA(ByVal cmbx As ComboBox, ByVal colName As String, ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA(TwoDAName, ChitinKey)
            If DialogTlk IsNot Nothing Then
                Dim num As Integer = 0
                Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
                For i As Integer = num To rowsUpperBound
                    Dim indiceData As Object = cls2DA.GetIndiceData(i, colName)
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
                        cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
                    Else
                        cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
                    End If
                Next
            Else
                Dim num2 As Integer = 0
                Dim rowsUpperBound2 As Integer = cls2DA.RowsUpperBound
                For i As Integer = num2 To rowsUpperBound2
                    cmbx.Items.Add(cls2DA.GetIndiceData(i, colName))
                Next
            End If
        End Sub

        ' Token: 0x06000B20 RID: 2848 RVA: 0x0027A6DC File Offset: 0x002796DC
        Public Sub SetupOrientationIndicators()
            Dim num As Single = CSng(Math.Atan2(CDbl(Me._YOrientation), CDbl(Me._XOrientation)))
            Me._XYAngle = Math.Atan2(CDbl(Me._YOrientation), CDbl((Me._XOrientation * -1.0F))) * 180.0 / 3.1415926535897931 - 90.0
            If Me._XYAngle < 0.0 Then
                Me._XYAngle += 360.0
            End If
            Me.nudXY.Value = New Decimal(Me._XYAngle)
            Me.DrawXYOrientation()
        End Sub

        ' Token: 0x06000B21 RID: 2849 RVA: 0x0027A780 File Offset: 0x00279780
        Public Sub SetupOrientationIndicators(ByVal XOrientation As Single, ByVal YOrientation As Single)
            Me._XOrientation = XOrientation
            Me._YOrientation = YOrientation
            Me.SetupOrientationIndicators()
        End Sub

        ' Token: 0x06000B22 RID: 2850 RVA: 0x0027A798 File Offset: 0x00279798
        Private Sub DrawXYOrientation()
            Dim graphics As Graphics = graphics.FromImage(Me.bmpXY)
            graphics.FillEllipse(Brushes.White, 0, 0, 49, 49)
            graphics.DrawArc(New Pen(Color.Black), 0, 0, 49, 49, 0, 360)
            graphics.DrawPie(New Pen(Color.Black), 0.0F, 0.0F, 49.0F, 49.0F, CSng(Me._XYAngle), 1.0F)
            Me.bmpXY.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Me.pboxXY.Image = Me.bmpXY
        End Sub

        ' Token: 0x06000B23 RID: 2851 RVA: 0x0027A82C File Offset: 0x0027982C
        Private Sub nudXY_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Me._XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientation()
            Me._XOrientation = -CSng(Math.Round(Math.Cos((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me._YOrientation = CSng(Math.Round(Math.Sin((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
        End Sub

        ' Token: 0x06000B24 RID: 2852 RVA: 0x0027A8D0 File Offset: 0x002798D0
        Private Sub nudXY_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me._XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientation()
            Me._XOrientation = -CSng(Math.Round(Math.Cos((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me._YOrientation = CSng(Math.Round(Math.Sin((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
        End Sub

        ' Token: 0x06000B25 RID: 2853 RVA: 0x0027A974 File Offset: 0x00279974
        Private Sub SetColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim colorDialog As ColorDialog = Me.ColorDialog1
            colorDialog.AllowFullOpen = True
            colorDialog.AnyColor = True
            colorDialog.Color = CType(sender, Button).BackColor
            colorDialog.FullOpen = True
            If Me.ColorDialog1.ShowDialog(Me) = DialogResult.OK Then
                CType(sender, Button).BackColor = Me.ColorDialog1.Color
            End If
        End Sub

        ' Token: 0x06000B26 RID: 2854 RVA: 0x0027A9D8 File Offset: 0x002799D8
        Private Sub trkbarXPScale_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            Me.nudXPScale.Value = New Decimal(CType(sender, TrackBar).Value)
        End Sub

        ' Token: 0x06000B27 RID: 2855 RVA: 0x0027A9F8 File Offset: 0x002799F8
        Private Sub nudXPScale_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarXPScale.Value = Convert.ToInt32(CType(sender, NumericUpDown).Value)
        End Sub

        ' Token: 0x06000B28 RID: 2856 RVA: 0x0027AA18 File Offset: 0x00279A18
        Private Sub trkbarGrassDensityX10_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            Me.nudGrassDensity.Value = New Decimal(CDbl(CType(sender, TrackBar).Value) / 10.0)
        End Sub

        ' Token: 0x06000B29 RID: 2857 RVA: 0x0027AA40 File Offset: 0x00279A40
        Private Sub nudGrassDensity_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarGrassDensityX10.Value = Convert.ToInt32(Decimal.Multiply(CType(sender, NumericUpDown).Value, 10D))
        End Sub

        ' Token: 0x06000B2A RID: 2858 RVA: 0x0027AA70 File Offset: 0x00279A70
        Private Sub nudGrassProbXX_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Single = Convert.ToSingle(Decimal.Add(Decimal.Add(Decimal.Add(Me.nudGrassProbLL.Value, Me.nudGrassProbUL.Value), Me.nudGrassProbLR.Value), Me.nudGrassProbUR.Value))
            Me.lblTotalGrassProbability.Text = "Total: " + StringType.FromSingle(num) + "%"
            If (num > 100.0F) Or (num < 100.0F) Then
                Me.lblTotalGrassProbability.BackColor = Color.Tomato
            Else
                Me.lblTotalGrassProbability.BackColor = Control.DefaultBackColor
            End If
        End Sub

        ' Token: 0x06000B2B RID: 2859 RVA: 0x0027AB14 File Offset: 0x00279B14
        Private Sub DayNight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.rbDayNightCycle.Checked Then
                Me.gbMoon.Enabled = True
                Me.gbSun.Enabled = True
            ElseIf Me.rbAlwaysNight.Checked Then
                Me.gbMoon.Enabled = True
                Me.gbSun.Enabled = False
            Else
                Me.gbMoon.Enabled = False
                Me.gbSun.Enabled = True
            End If
        End Sub

        ' Token: 0x06000B2C RID: 2860 RVA: 0x0027AB88 File Offset: 0x00279B88
        Private Sub SunFogEnabled(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarSunFogNear.Enabled = Me.chkbSunFogOn.Checked
            Me.trkbarSunFogFar.Enabled = Me.chkbSunFogOn.Checked
            Me.lblSunFogFar.Enabled = Me.chkbSunFogOn.Checked
            Me.lblSunFogNear.Enabled = Me.chkbSunFogOn.Checked
        End Sub

        ' Token: 0x06000B2D RID: 2861 RVA: 0x0027ABF0 File Offset: 0x00279BF0
        Private Sub MoonFogEnabled(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarMoonFogNear.Enabled = Me.chkbMoonFogOn.Checked
            Me.trkbarMoonFogFar.Enabled = Me.chkbMoonFogOn.Checked
            Me.lblMoonFogFar.Enabled = Me.chkbMoonFogOn.Checked
            Me.lblMoonFogNear.Enabled = Me.chkbMoonFogOn.Checked
        End Sub

        ' Token: 0x06000B2E RID: 2862 RVA: 0x0027AC58 File Offset: 0x00279C58
        Private Sub lbRooms_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lbRooms.SelectedIndex = -1 Then
                Return
            End If
            Dim room As frmModuleIfo_AreaEditor.Room = CType(Me.lbRooms.SelectedItem, frmModuleIfo_AreaEditor.Room)
            RemoveHandler Me.cmbxRoomEnvAudio.SelectedIndexChanged, AddressOf Me.cmbxRoomEnvAudio_SelectedIndexChanged
            RemoveHandler Me.nudRoomAmbientScale.ValueChanged, AddressOf Me.nudRoomAmbientScale_ValueChanged
            RemoveHandler Me.nudRoomForceRating.ValueChanged, AddressOf Me.nudRoomForceRating_ValueChanged
            RemoveHandler Me.chkbRoomDisableWeather.CheckedChanged, AddressOf Me.chkbRoomDisableWeather_CheckedChanged
            Me.tbRoomName.Text = room.RoomName
            Me.nudRoomAmbientScale.Value = New Decimal(room.AmbientScale)
            Me.nudRoomForceRating.Value = New Decimal(room.ForceRating)
            Me.chkbRoomDisableWeather.Checked = room.DisableWeather
            Me.cmbxRoomEnvAudio.SelectedIndex = room.EnvAudio
            AddHandler Me.cmbxRoomEnvAudio.SelectedIndexChanged, AddressOf Me.cmbxRoomEnvAudio_SelectedIndexChanged
            AddHandler Me.nudRoomAmbientScale.ValueChanged, AddressOf Me.nudRoomAmbientScale_ValueChanged
            AddHandler Me.nudRoomForceRating.ValueChanged, AddressOf Me.nudRoomForceRating_ValueChanged
            AddHandler Me.chkbRoomDisableWeather.CheckedChanged, AddressOf Me.chkbRoomDisableWeather_CheckedChanged
        End Sub

        ' Token: 0x06000B2F RID: 2863 RVA: 0x0027ADA4 File Offset: 0x00279DA4
        Private Sub cmbxRoomEnvAudio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rooms(Me.lbRooms.SelectedIndex).EnvAudio = Me.cmbxRoomEnvAudio.SelectedIndex
        End Sub

        ' Token: 0x06000B30 RID: 2864 RVA: 0x0027ADC8 File Offset: 0x00279DC8
        Private Sub nudRoomAmbientScale_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rooms(Me.lbRooms.SelectedIndex).AmbientScale = Convert.ToSingle(Me.nudRoomAmbientScale.Value)
        End Sub

        ' Token: 0x06000B31 RID: 2865 RVA: 0x0027ADF4 File Offset: 0x00279DF4
        Private Sub nudRoomForceRating_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rooms(Me.lbRooms.SelectedIndex).ForceRating = Convert.ToInt32(Me.nudRoomForceRating.Value)
        End Sub

        ' Token: 0x06000B32 RID: 2866 RVA: 0x0027AE20 File Offset: 0x00279E20
        Private Sub chkbRoomDisableWeather_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rooms(Me.lbRooms.SelectedIndex).DisableWeather = Me.chkbRoomDisableWeather.Checked
        End Sub

        ' Token: 0x06000B33 RID: 2867 RVA: 0x0027AE44 File Offset: 0x00279E44
        Private Sub btnSetDescriptionLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.ModDescriptionLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.ModDescriptionLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06000B34 RID: 2868 RVA: 0x0027AE74 File Offset: 0x00279E74
        Private Sub btnSetModNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.ModNameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.ModNameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06000B35 RID: 2869 RVA: 0x0027AEA4 File Offset: 0x00279EA4
        Private Sub btnSetAreaNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.AreaNameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.AreaNameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x170003B7 RID: 951
        ' (get) Token: 0x06000B36 RID: 2870 RVA: 0x0027AED4 File Offset: 0x00279ED4
        ' (set) Token: 0x06000B37 RID: 2871 RVA: 0x0027AEF4 File Offset: 0x00279EF4
        Public Property Mod_Tag() As String
            Get
                Return Me.tbModTag.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbModTag.Text = value
            End Set
        End Property

        ' Token: 0x170003B8 RID: 952
        ' (get) Token: 0x06000B38 RID: 2872 RVA: 0x0027AF04 File Offset: 0x00279F04
        ' (set) Token: 0x06000B39 RID: 2873 RVA: 0x0027AF24 File Offset: 0x00279F24
        Public Property Mod_Entry_Area() As String
            Get
                Return Me.tbModEntryArea.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbModEntryArea.Text = value
            End Set
        End Property

        ' Token: 0x170003B9 RID: 953
        ' (get) Token: 0x06000B3A RID: 2874 RVA: 0x0027AF34 File Offset: 0x00279F34
        ' (set) Token: 0x06000B3B RID: 2875 RVA: 0x0027AF54 File Offset: 0x00279F54
        Public Property Mod_Name() As String
            Get
                Return Me.tbModName.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbModName.Text = value
            End Set
        End Property

        ' Token: 0x170003BA RID: 954
        ' (get) Token: 0x06000B3C RID: 2876 RVA: 0x0027AF64 File Offset: 0x00279F64
        ' (set) Token: 0x06000B3D RID: 2877 RVA: 0x0027AF84 File Offset: 0x00279F84
        Public Property Mod_Entry_X() As Single
            Get
                Return Convert.ToSingle(Me.nudModEntryX.Value)
            End Get
            Set(ByVal value As Single)
                Me.nudModEntryX.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003BB RID: 955
        ' (get) Token: 0x06000B3E RID: 2878 RVA: 0x0027AF98 File Offset: 0x00279F98
        ' (set) Token: 0x06000B3F RID: 2879 RVA: 0x0027AFB8 File Offset: 0x00279FB8
        Public Property Mod_Entry_Y() As Single
            Get
                Return Convert.ToSingle(Me.nudModEntryY.Value)
            End Get
            Set(ByVal value As Single)
                Me.nudModEntryY.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003BC RID: 956
        ' (get) Token: 0x06000B40 RID: 2880 RVA: 0x0027AFCC File Offset: 0x00279FCC
        ' (set) Token: 0x06000B41 RID: 2881 RVA: 0x0027AFEC File Offset: 0x00279FEC
        Public Property Mod_Entry_Z() As Single
            Get
                Return Convert.ToSingle(Me.nudModEntryZ.Value)
            End Get
            Set(ByVal value As Single)
                Me.nudModEntryZ.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003BD RID: 957
        ' (get) Token: 0x06000B42 RID: 2882 RVA: 0x0027B000 File Offset: 0x0027A000
        ' (set) Token: 0x06000B43 RID: 2883 RVA: 0x0027B014 File Offset: 0x0027A014
        Private Property XOrientation() As Single
            Get
                Return Me._XOrientation
            End Get
            Set(ByVal value As Single)
                Me._XOrientation = value
            End Set
        End Property

        ' Token: 0x170003BE RID: 958
        ' (get) Token: 0x06000B44 RID: 2884 RVA: 0x0027B020 File Offset: 0x0027A020
        ' (set) Token: 0x06000B45 RID: 2885 RVA: 0x0027B034 File Offset: 0x0027A034
        Private Property YOrientation() As Single
            Get
                Return Me._YOrientation
            End Get
            Set(ByVal value As Single)
                Me._YOrientation = value
            End Set
        End Property

        ' Token: 0x170003BF RID: 959
        ' (get) Token: 0x06000B46 RID: 2886 RVA: 0x0027B040 File Offset: 0x0027A040
        ' (set) Token: 0x06000B47 RID: 2887 RVA: 0x0027B060 File Offset: 0x0027A060
        Public Property Mod_MinutesPerHour() As Integer
            Get
                Return Convert.ToInt32(Me.nudMinutesPerHour.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudMinutesPerHour.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C0 RID: 960
        ' (get) Token: 0x06000B48 RID: 2888 RVA: 0x0027B074 File Offset: 0x0027A074
        ' (set) Token: 0x06000B49 RID: 2889 RVA: 0x0027B094 File Offset: 0x0027A094
        Public Property Mod_DawnHour() As Integer
            Get
                Return Convert.ToInt32(Me.nudDawnStartHour.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudDawnStartHour.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C1 RID: 961
        ' (get) Token: 0x06000B4A RID: 2890 RVA: 0x0027B0A8 File Offset: 0x0027A0A8
        ' (set) Token: 0x06000B4B RID: 2891 RVA: 0x0027B0C8 File Offset: 0x0027A0C8
        Public Property Mod_DuskHour() As Integer
            Get
                Return Convert.ToInt32(Me.nudDuskStartHour.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudDuskStartHour.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C2 RID: 962
        ' (get) Token: 0x06000B4C RID: 2892 RVA: 0x0027B0DC File Offset: 0x0027A0DC
        ' (set) Token: 0x06000B4D RID: 2893 RVA: 0x0027B0FC File Offset: 0x0027A0FC
        Public Property Mod_StartHour() As Integer
            Get
                Return Convert.ToInt32(Me.nudStartHour.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudStartHour.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C3 RID: 963
        ' (get) Token: 0x06000B4E RID: 2894 RVA: 0x0027B110 File Offset: 0x0027A110
        ' (set) Token: 0x06000B4F RID: 2895 RVA: 0x0027B130 File Offset: 0x0027A130
        Public Property Mod_StartDay() As Integer
            Get
                Return Convert.ToInt32(Me.nudStartDay.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudStartDay.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C4 RID: 964
        ' (get) Token: 0x06000B50 RID: 2896 RVA: 0x0027B144 File Offset: 0x0027A144
        ' (set) Token: 0x06000B51 RID: 2897 RVA: 0x0027B164 File Offset: 0x0027A164
        Public Property Mod_StartMonth() As Integer
            Get
                Return Convert.ToInt32(Me.nudStartMonth.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudStartMonth.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C5 RID: 965
        ' (get) Token: 0x06000B52 RID: 2898 RVA: 0x0027B178 File Offset: 0x0027A178
        ' (set) Token: 0x06000B53 RID: 2899 RVA: 0x0027B198 File Offset: 0x0027A198
        Public Property Mod_StartYear() As Integer
            Get
                Return Convert.ToInt32(Me.nudStartYear.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudStartYear.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C6 RID: 966
        ' (get) Token: 0x06000B54 RID: 2900 RVA: 0x0027B1AC File Offset: 0x0027A1AC
        ' (set) Token: 0x06000B55 RID: 2901 RVA: 0x0027B1CC File Offset: 0x0027A1CC
        Public Property Mod_XPScale() As Integer
            Get
                Return Convert.ToInt32(Me.nudXPScale.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudXPScale.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C7 RID: 967
        ' (get) Token: 0x06000B56 RID: 2902 RVA: 0x0027B1E0 File Offset: 0x0027A1E0
        ' (set) Token: 0x06000B57 RID: 2903 RVA: 0x0027B200 File Offset: 0x0027A200
        Public Property Mod_OnAcquirItem() As String
            Get
                Return Me.tbMod_OnAcquirItem.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnAcquirItem.Text = value
            End Set
        End Property

        ' Token: 0x170003C8 RID: 968
        ' (get) Token: 0x06000B58 RID: 2904 RVA: 0x0027B210 File Offset: 0x0027A210
        ' (set) Token: 0x06000B59 RID: 2905 RVA: 0x0027B230 File Offset: 0x0027A230
        Public Property Mod_OnActvtItem() As String
            Get
                Return Me.tbMod_OnActvtItem.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnActvtItem.Text = value
            End Set
        End Property

        ' Token: 0x170003C9 RID: 969
        ' (get) Token: 0x06000B5A RID: 2906 RVA: 0x0027B240 File Offset: 0x0027A240
        ' (set) Token: 0x06000B5B RID: 2907 RVA: 0x0027B260 File Offset: 0x0027A260
        Public Property Mod_OnClientEntr() As String
            Get
                Return Me.tbMod_OnClientEntr.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnClientEntr.Text = value
            End Set
        End Property

        ' Token: 0x170003CA RID: 970
        ' (get) Token: 0x06000B5C RID: 2908 RVA: 0x0027B270 File Offset: 0x0027A270
        ' (set) Token: 0x06000B5D RID: 2909 RVA: 0x0027B290 File Offset: 0x0027A290
        Public Property Mod_OnClientLeav() As String
            Get
                Return Me.tbMod_OnClientLeav.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnClientLeav.Text = value
            End Set
        End Property

        ' Token: 0x170003CB RID: 971
        ' (get) Token: 0x06000B5E RID: 2910 RVA: 0x0027B2A0 File Offset: 0x0027A2A0
        ' (set) Token: 0x06000B5F RID: 2911 RVA: 0x0027B2C0 File Offset: 0x0027A2C0
        Public Property Mod_OnHeartbeat() As String
            Get
                Return Me.tbMod_OnHeartbeat.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnHeartbeat.Text = value
            End Set
        End Property

        ' Token: 0x170003CC RID: 972
        ' (get) Token: 0x06000B60 RID: 2912 RVA: 0x0027B2D0 File Offset: 0x0027A2D0
        ' (set) Token: 0x06000B61 RID: 2913 RVA: 0x0027B2F0 File Offset: 0x0027A2F0
        Public Property Mod_OnModLoad() As String
            Get
                Return Me.tbMod_OnModLoad.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnModLoad.Text = value
            End Set
        End Property

        ' Token: 0x170003CD RID: 973
        ' (get) Token: 0x06000B62 RID: 2914 RVA: 0x0027B300 File Offset: 0x0027A300
        ' (set) Token: 0x06000B63 RID: 2915 RVA: 0x0027B320 File Offset: 0x0027A320
        Public Property Mod_OnPlrDeath() As String
            Get
                Return Me.tbMod_OnPlrDeath.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnPlrDeath.Text = value
            End Set
        End Property

        ' Token: 0x170003CE RID: 974
        ' (get) Token: 0x06000B64 RID: 2916 RVA: 0x0027B330 File Offset: 0x0027A330
        ' (set) Token: 0x06000B65 RID: 2917 RVA: 0x0027B350 File Offset: 0x0027A350
        Public Property Mod_OnPlrDying() As String
            Get
                Return Me.tbMod_OnPlrDying.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnPlrDying.Text = value
            End Set
        End Property

        ' Token: 0x170003CF RID: 975
        ' (get) Token: 0x06000B66 RID: 2918 RVA: 0x0027B360 File Offset: 0x0027A360
        ' (set) Token: 0x06000B67 RID: 2919 RVA: 0x0027B380 File Offset: 0x0027A380
        Public Property Mod_OnPlrLvlUp() As String
            Get
                Return Me.tbMod_OnPlrLvlUp.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnPlrLvlUp.Text = value
            End Set
        End Property

        ' Token: 0x170003D0 RID: 976
        ' (get) Token: 0x06000B68 RID: 2920 RVA: 0x0027B390 File Offset: 0x0027A390
        ' (set) Token: 0x06000B69 RID: 2921 RVA: 0x0027B3B0 File Offset: 0x0027A3B0
        Public Property Mod_OnSpawnBtnDn() As String
            Get
                Return Me.tbMod_OnSpawnBtnDn.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnSpawnBtnDn.Text = value
            End Set
        End Property

        ' Token: 0x170003D1 RID: 977
        ' (get) Token: 0x06000B6A RID: 2922 RVA: 0x0027B3C0 File Offset: 0x0027A3C0
        ' (set) Token: 0x06000B6B RID: 2923 RVA: 0x0027B3E0 File Offset: 0x0027A3E0
        Public Property Mod_OnPlrRest() As String
            Get
                Return Me.tbMod_OnPlrRest.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnPlrRest.Text = value
            End Set
        End Property

        ' Token: 0x170003D2 RID: 978
        ' (get) Token: 0x06000B6C RID: 2924 RVA: 0x0027B3F0 File Offset: 0x0027A3F0
        ' (set) Token: 0x06000B6D RID: 2925 RVA: 0x0027B410 File Offset: 0x0027A410
        Public Property Mod_OnUnAqreItem() As String
            Get
                Return Me.tbMod_OnUnAqreItem.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnUnAqreItem.Text = value
            End Set
        End Property

        ' Token: 0x170003D3 RID: 979
        ' (get) Token: 0x06000B6E RID: 2926 RVA: 0x0027B420 File Offset: 0x0027A420
        ' (set) Token: 0x06000B6F RID: 2927 RVA: 0x0027B440 File Offset: 0x0027A440
        Public Property Mod_OnUsrDefined() As String
            Get
                Return Me.tbMod_OnUsrDefined.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnUsrDefined.Text = value
            End Set
        End Property

        ' Token: 0x170003D4 RID: 980
        ' (get) Token: 0x06000B70 RID: 2928 RVA: 0x0027B450 File Offset: 0x0027A450
        ' (set) Token: 0x06000B71 RID: 2929 RVA: 0x0027B470 File Offset: 0x0027A470
        Public Property DynAmbientColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnDynAmbientColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnDynAmbientColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D5 RID: 981
        ' (get) Token: 0x06000B72 RID: 2930 RVA: 0x0027B484 File Offset: 0x0027A484
        ' (set) Token: 0x06000B73 RID: 2931 RVA: 0x0027B4A4 File Offset: 0x0027A4A4
        Public Property SunAmbientColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnSunAmbientColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnSunAmbientColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D6 RID: 982
        ' (get) Token: 0x06000B74 RID: 2932 RVA: 0x0027B4B8 File Offset: 0x0027A4B8
        ' (set) Token: 0x06000B75 RID: 2933 RVA: 0x0027B4D8 File Offset: 0x0027A4D8
        Public Property SunDiffuseColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnSunDiffuseColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnSunDiffuseColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D7 RID: 983
        ' (get) Token: 0x06000B76 RID: 2934 RVA: 0x0027B4EC File Offset: 0x0027A4EC
        ' (set) Token: 0x06000B77 RID: 2935 RVA: 0x0027B50C File Offset: 0x0027A50C
        Public Property SunFogColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnSunFogColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnSunFogColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D8 RID: 984
        ' (get) Token: 0x06000B78 RID: 2936 RVA: 0x0027B520 File Offset: 0x0027A520
        ' (set) Token: 0x06000B79 RID: 2937 RVA: 0x0027B540 File Offset: 0x0027A540
        Public Property MoonAmbientColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnMoonAmbientColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnMoonAmbientColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D9 RID: 985
        ' (get) Token: 0x06000B7A RID: 2938 RVA: 0x0027B554 File Offset: 0x0027A554
        ' (set) Token: 0x06000B7B RID: 2939 RVA: 0x0027B574 File Offset: 0x0027A574
        Public Property MoonDiffuseColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnMoonDiffuseColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnMoonDiffuseColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DA RID: 986
        ' (get) Token: 0x06000B7C RID: 2940 RVA: 0x0027B588 File Offset: 0x0027A588
        ' (set) Token: 0x06000B7D RID: 2941 RVA: 0x0027B5A8 File Offset: 0x0027A5A8
        Public Property MoonFogColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnMoonFogColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnMoonFogColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DB RID: 987
        ' (get) Token: 0x06000B7E RID: 2942 RVA: 0x0027B5BC File Offset: 0x0027A5BC
        ' (set) Token: 0x06000B7F RID: 2943 RVA: 0x0027B5DC File Offset: 0x0027A5DC
        Public Property Grass_Ambient() As UInteger
            Get
                Return Me.color2bgr(Me.btnGrassAmbientColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnGrassAmbientColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DC RID: 988
        ' (get) Token: 0x06000B80 RID: 2944 RVA: 0x0027B5F0 File Offset: 0x0027A5F0
        ' (set) Token: 0x06000B81 RID: 2945 RVA: 0x0027B610 File Offset: 0x0027A610
        Public Property Grass_Diffuse() As UInteger
            Get
                Return Me.color2bgr(Me.btnGrassDiffuseColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnGrassDiffuseColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DD RID: 989
        ' (get) Token: 0x06000B82 RID: 2946 RVA: 0x0027B624 File Offset: 0x0027A624
        ' (set) Token: 0x06000B83 RID: 2947 RVA: 0x0027B644 File Offset: 0x0027A644
        Public Property Grass_Emissive() As UInteger
            Get
                Return Me.color2bgr(Me.btnGrassEmissiveColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnGrassEmissiveColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DE RID: 990
        ' (get) Token: 0x06000B84 RID: 2948 RVA: 0x0027B658 File Offset: 0x0027A658
        ' (set) Token: 0x06000B85 RID: 2949 RVA: 0x0027B688 File Offset: 0x0027A688
        Public Property Grass_Prob_LL() As Single
            Get
                Return Convert.ToSingle(Decimal.Divide(Me.nudGrassProbLL.Value, 100D))
            End Get
            Set(ByVal value As Single)
                Me.nudGrassProbLL.Value = New Decimal(value * 100.0F)
            End Set
        End Property

        ' Token: 0x170003DF RID: 991
        ' (get) Token: 0x06000B86 RID: 2950 RVA: 0x0027B6A4 File Offset: 0x0027A6A4
        ' (set) Token: 0x06000B87 RID: 2951 RVA: 0x0027B6D4 File Offset: 0x0027A6D4
        Public Property Grass_Prob_UL() As Single
            Get
                Return Convert.ToSingle(Decimal.Divide(Me.nudGrassProbUL.Value, 100D))
            End Get
            Set(ByVal value As Single)
                Me.nudGrassProbUL.Value = New Decimal(value * 100.0F)
            End Set
        End Property

        ' Token: 0x170003E0 RID: 992
        ' (get) Token: 0x06000B88 RID: 2952 RVA: 0x0027B6F0 File Offset: 0x0027A6F0
        ' (set) Token: 0x06000B89 RID: 2953 RVA: 0x0027B720 File Offset: 0x0027A720
        Public Property Grass_Prob_LR() As Single
            Get
                Return Convert.ToSingle(Decimal.Divide(Me.nudGrassProbLR.Value, 100D))
            End Get
            Set(ByVal value As Single)
                Me.nudGrassProbLR.Value = New Decimal(value * 100.0F)
            End Set
        End Property

        ' Token: 0x170003E1 RID: 993
        ' (get) Token: 0x06000B8A RID: 2954 RVA: 0x0027B73C File Offset: 0x0027A73C
        ' (set) Token: 0x06000B8B RID: 2955 RVA: 0x0027B76C File Offset: 0x0027A76C
        Public Property Grass_Prob_UR() As Single
            Get
                Return Convert.ToSingle(Decimal.Divide(Me.nudGrassProbUR.Value, 100D))
            End Get
            Set(ByVal value As Single)
                Me.nudGrassProbUR.Value = New Decimal(value * 100.0F)
            End Set
        End Property

        ' Token: 0x170003E2 RID: 994
        ' (get) Token: 0x06000B8C RID: 2956 RVA: 0x0027B788 File Offset: 0x0027A788
        Public ReadOnly Property ModEntryChanged() As Boolean
            Get
                Return Me._origXOrientation <> Me._XOrientation OrElse Me._origYOrientation <> Me._YOrientation OrElse Me._origXPos <> Me.Mod_Entry_X OrElse Me._origYpos <> Me.Mod_Entry_Y OrElse Me._origZpos <> Me.Mod_Entry_Z
            End Get
        End Property

        ' Token: 0x040005B0 RID: 1456
        Private _AREFile As clsGFF

        ' Token: 0x040005B1 RID: 1457
        Private _IFOFile As clsGFF

        ' Token: 0x040005B2 RID: 1458
        Private _GITFile As clsGFF

        ' Token: 0x040005B3 RID: 1459
        Private _ChitinKey As clsChitinKey

        ' Token: 0x040005B4 RID: 1460
        Private _DialogTlk As clsDialogTlk

        ' Token: 0x040005B5 RID: 1461
        Private ComboBoxSettingError As Boolean

        ' Token: 0x040005B6 RID: 1462
        Private Rooms As frmModuleIfo_AreaEditor.Room()

        ' Token: 0x040005B7 RID: 1463
        Private bmpXY As Bitmap

        ' Token: 0x040005B8 RID: 1464
        Private _XYAngle As Double

        ' Token: 0x040005B9 RID: 1465
        Private _XOrientation As Single

        ' Token: 0x040005BA RID: 1466
        Private _YOrientation As Single

        ' Token: 0x040005BB RID: 1467
        Private _origXOrientation As Single

        ' Token: 0x040005BC RID: 1468
        Private _origYOrientation As Single

        ' Token: 0x040005BD RID: 1469
        Private _Bearing As Single

        ' Token: 0x040005BE RID: 1470
        Private _Xpos As Single

        ' Token: 0x040005BF RID: 1471
        Private _origXPos As Single

        ' Token: 0x040005C0 RID: 1472
        Private _Ypos As Single

        ' Token: 0x040005C1 RID: 1473
        Private _origYpos As Single

        ' Token: 0x040005C2 RID: 1474
        Private _Zpos As Single

        ' Token: 0x040005C3 RID: 1475
        Private _origZpos As Single

        ' Token: 0x040005C4 RID: 1476
        Private ModDescriptionLang As Integer

        ' Token: 0x040005C5 RID: 1477
        Private ModNameLang As Integer

        ' Token: 0x040005C6 RID: 1478
        Private AreaNameLang As Integer

        ' Token: 0x02000062 RID: 98
        Private Class Room
            ' Token: 0x170003E3 RID: 995
            ' (get) Token: 0x06000B8E RID: 2958 RVA: 0x0027B7E8 File Offset: 0x0027A7E8
            Public ReadOnly Property Text() As String
                Get
                    Return Me.RoomName
                End Get
            End Property

            ' Token: 0x040005C7 RID: 1479
            Public RoomName As String

            ' Token: 0x040005C8 RID: 1480
            Public EnvAudio As Integer

            ' Token: 0x040005C9 RID: 1481
            Public ForceRating As Integer

            ' Token: 0x040005CA RID: 1482
            Public AmbientScale As Single

            ' Token: 0x040005CB RID: 1483
            Public DisableWeather As Boolean
        End Class
    End Class
End Namespace
