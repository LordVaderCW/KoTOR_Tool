Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace kotor_tool
	' Token: 0x0200005C RID: 92
	Public Partial Class frmModule_Editor
		Inherits frmParent

		' Token: 0x060007A2 RID: 1954 RVA: 0x0025A2F4 File Offset: 0x002592F4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmModule_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmModule_Editor_Closing
			Me.bModuleLoadedOK = False
			Me.g_ShowPaletteNames = True
			Me.g_CurrentPaletteModItemType = -1
			Me.g_mapsPath = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\SCM\Kotor Tool").GetValue("path")), "maps\")
			Me.bPaletteVisible = True
			Me.bModElementsVisible = True
			Me.bConfirmDeletes = True
			Me.bShowLocatorRay = True
			Me.dModuleElementIndicatorSize = 1D
			Me.g_tvModule_TreeOpenPaths = New ArrayList()
			Me.g_UserPalettteFsw = New FileSystemWatcher()
			Me.g_ProjectFsw = New FileSystemWatcher()
			Me.CalibrationToolsVis = False
			Me.labelFont = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.labelBrush = New SolidBrush(Color.White)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000893 RID: 2195 RVA: 0x002600A0 File Offset: 0x0025F0A0
		Public Function Setup(ProjectPath As String) As Boolean
			Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
			frmModule_Editor.g_form = Me
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.gModuleEditorSettings = ModuleEditorProjectSettings.GetSettings(ProjectPath)
			While ProjectPath.EndsWith("\")
				ProjectPath = ProjectPath.Substring(0, ProjectPath.Length - 1)
			End While
			Me.g_ProjectPath = ProjectPath
			If StringType.StrCmp(Me.gModuleEditorSettings.ModuleEditorModOutputPath, "", False) = 0 Then
				Me.gModuleEditorSettings.ModuleEditorModOutputPath = Me.g_ProjectPath
			End If
			If Not Directory.Exists(Me.g_ProjectPath + "\extras") Then
				Directory.CreateDirectory(Me.g_ProjectPath + "\extras")
			End If
			If Directory.GetFiles(Me.g_ProjectPath, "*.git").Length = 0 Then
				Interaction.MsgBox("It would appear that your module is missing it's .git file.", MsgBoxStyle.Critical, "Module load error")
				Return False
			End If
			Dim text As String = Directory.GetFiles(Me.g_ProjectPath, "*.git")(0)
			Me.g_MapName = Path.GetFileNameWithoutExtension(text)
			Me.KotorVersionIndex = frmMain.GetGFFFileKotorVersionIndex(text)
			Me.SetEditorCaption()
			Me.g_UserPalettePath = Me.g_ProjectPath + "\userpalette"
			Me.g_GlobalTemplatesPath = frmMain.gRootPath + "\Global Templates\k" + StringType.FromInteger(Me.KotorVersionIndex + 1)
			Me.htTemplateBifFiles = frmMain.KxChitinKey(Me.KotorVersionIndex).GetBIFFileHash("templates")
			Dim stream As Stream
			Try
				stream = File.OpenRead(frmMain.gRootPath + "K1TemplateTags.bfd")
				Me.htK1Tags = CType(binaryFormatter.Deserialize(stream), Hashtable)
				stream.Close()
            Catch ex As System.Exception
            End Try
			Try
				stream = File.OpenRead(frmMain.gRootPath + "K2TemplateTags.bfd")
				Me.htK2Tags = CType(binaryFormatter.Deserialize(stream), Hashtable)
				stream.Close()
            Catch ex2 As System.Exception
            End Try
			Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\dialog.tlk", False)
			Try
				stream = New FileStream(text, FileMode.Open, FileAccess.Read)
				Me.GITfile = New clsGFF(CType(stream, FileStream), Me.KotorVersionIndex, True)
            Catch ex3 As System.Exception
                Interaction.MsgBox("It would appear that your module .GIT file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error")
                Return False
			End Try
			Try
				stream = New FileStream(Path.Combine(Path.GetDirectoryName(text), "module.ifo"), FileMode.Open, FileAccess.Read)
				Me.IFOfile = New clsGFF(CType(stream, FileStream), Me.KotorVersionIndex, True)
            Catch ex4 As System.Exception
                Interaction.MsgBox("It would appear that your Module.ifo file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error")
                Return False
			End Try
			Try
				stream = New FileStream(text.ToLower().Replace(".git", ".are"), FileMode.Open, FileAccess.Read)
				Me.AREfile = New clsGFF(CType(stream, FileStream), Me.KotorVersionIndex, True)
            Catch ex5 As System.Exception
                Interaction.MsgBox("It would appear that your module .ARE file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error")
                Return False
			End Try
			Me.g_MapName = Path.GetFileNameWithoutExtension(text).ToLower()
			Me.g_SmallMapAvailable = File.Exists(Me.g_mapsPath + "map" + Me.g_MapName + ".map")
			Me.g_LargeMapAvailable = File.Exists(Me.g_mapsPath + "map" + Me.g_MapName + "_lg.map")
			Me.g_AltSmallMapAvailable = File.Exists(Me.g_mapsPath + "map" + Me.g_MapName + "_alt.map")
			If Not(Me.g_SmallMapAvailable Or Me.g_LargeMapAvailable) Then
				MessageBox.Show("You do not have a .map file for this module in your Kotor Tool 'Maps' directory." & vbLf & vbLf & "Use the '' menu item on the main Tools menu to see if this module is supported." & vbLf & vbLf & "If it is, you will need to obtain the map file, put in the 'Maps' directory, and reload this module.", "Missing .map file", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Me.miUseSmallMap.Enabled = Me.g_SmallMapAvailable
			Me.miUseLargeMap.Enabled = Me.g_LargeMapAvailable
			Me.miUseAltSmallMap.Enabled = Me.g_AltSmallMapAvailable
			If StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "small", False) = 0 AndAlso Not Me.g_SmallMapAvailable AndAlso Me.g_LargeMapAvailable Then
				Me.gModuleEditorSettings.MapSize = "large"
			End If
			If StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "large", False) = 0 AndAlso Not Me.g_LargeMapAvailable AndAlso Me.g_SmallMapAvailable Then
				Me.gModuleEditorSettings.MapSize = "small"
			End If
			If StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "altsmall", False) = 0 AndAlso Not Me.g_AltSmallMapAvailable Then
				If Me.g_SmallMapAvailable Then
					Me.gModuleEditorSettings.MapSize = "small"
				ElseIf Me.g_LargeMapAvailable Then
					Me.gModuleEditorSettings.MapSize = "large"
				End If
			End If
			If((StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "", False) = 0) Or (StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "small", False) = 0)) AndAlso Me.g_SmallMapAvailable Then
				Me.g_mapImageName = "map" + Me.g_MapName + ".map"
				Me.g_MapTypeInUse = 0
				Me.g_UsingLargeMap = False
				Me.miUseSmallMap.Checked = True
				Me.miUseLargeMap.Checked = False
				Me.miUseAltSmallMap.Checked = False
			ElseIf((StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "", False) = 0) Or (StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "large", False) = 0)) AndAlso Me.g_LargeMapAvailable Then
				Me.g_mapImageName = "map" + Me.g_MapName + "_lg.map"
				Me.g_MapTypeInUse = 1
				Me.g_UsingLargeMap = True
				Me.miUseSmallMap.Checked = False
				Me.miUseLargeMap.Checked = True
				Me.miUseAltSmallMap.Checked = False
			ElseIf StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "altsmall", False) = 0 AndAlso Me.g_AltSmallMapAvailable Then
				Me.g_mapImageName = "map" + Me.g_MapName + "_alt.map"
				Me.g_MapTypeInUse = 2
				Me.miUseSmallMap.Checked = False
				Me.miUseLargeMap.Checked = False
				Me.miUseAltSmallMap.Checked = True
			End If
			If Not Me.chkbUseFactors.Checked Then
				Dim mapInfo As MapInfo
				Try
					stream = File.OpenRead(frmMain.gRootPath + "MapInfo.bfd")
					mapInfo = CType(binaryFormatter.Deserialize(stream), MapInfo)
					stream.Close()
                Catch ex6 As System.Exception
                    stream.Seek(0L, SeekOrigin.Begin)
                    binaryFormatter = frmMapInfoStatus.CreateMapInfoFormatter(Type.[GetType]("kotor_tool.MapInfo"))
                    mapInfo = CType(binaryFormatter.Deserialize(stream), MapInfo)
                    stream.Close()
                    If mapInfo.[GetType]() Is Type.[GetType]("kotor_tool.MapInfo") Then
                        stream = File.OpenWrite(frmMain.gRootPath + "MapInfo.bfd")
                        binaryFormatter = New BinaryFormatter()
                        binaryFormatter.Serialize(stream, mapInfo)
                        stream.Close()
                    Else
                        Interaction.MsgBox("Unable to load MapInfo.bfd file." & vbLf & vbLf & "Please download a fresh copy.", MsgBoxStyle.Critical, "MapInfo error")
                    End If
				End Try
				Dim flag As Boolean = False
				Try
					For Each obj As Object In mapInfo.MapList
						Dim map As MapInfo.Map = CType(obj, MapInfo.Map)
						If StringType.StrCmp(Me.g_MapName, map.MapName, False) = 0 Then
							If Me.g_UsingLargeMap AndAlso Not map.L Then
								Exit For
							End If
							If Not Me.g_UsingLargeMap AndAlso Not map.S Then
								Exit For
							End If
							flag = True
							Select Case Me.g_MapTypeInUse
								Case 0
									Me.nudXmul.Value = map.SXMul
									Me.nudYmul.Value = map.SYMul
									Me.nudXoff.Value = New Decimal(map.SXOff)
									Me.nudYoff.Value = New Decimal(map.SYOff)
									GoTo IL_088F
								Case 1
									Me.nudXmul.Value = map.LXMul
									Me.nudYmul.Value = map.LYMul
									Me.nudXoff.Value = New Decimal(map.LXOff)
									Me.nudYoff.Value = New Decimal(map.LYOff)
									GoTo IL_088F
								Case 2
									Me.nudXmul.Value = map.AltSXMul
									Me.nudYmul.Value = map.AltSYMul
									Me.nudXoff.Value = New Decimal(map.AltSXOff)
									Me.nudYoff.Value = New Decimal(map.AltSYOff)
									GoTo IL_088F
								Case Else
									GoTo IL_088F
							End Select
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
				IL_088F:
				If Not flag Then
					Interaction.MsgBox("You have the map for this module, but the MapInfo file appears to be incorrect or out-of date.", MsgBoxStyle.Critical, "Map Info missing")
					Return False
				End If
			End If
			Me.UpdateVisibilityBtnsWithSettings()
			AddHandler Me.chkbShowTags.CheckedChanged, AddressOf Me.chkbShowTags_CheckedChanged
			Me.bmp = Nothing
			Me.bmp_cache = Nothing
			Me.LoadBackground()
			Me.pbox.Size = Me.bmp.Size
			Me.BuildUserPaletteTreeView()
			Me.BuildScriptsPalette()
			Me.BuildDialogsPalette()
			Me.DisableFileSystemWatchers()
			Me.CreateFileSystemWatchers()
			Me.EnableControls(True)
			Dim panel As ScrollableControl = Me.Panel1
			Dim point As Point = New Point(Me.gModuleEditorSettings.LastScrollPosX, Me.gModuleEditorSettings.LastScrollPosY)
			panel.AutoScrollPosition = point
			Return True
		End Function

		' Token: 0x06000894 RID: 2196 RVA: 0x00260A9C File Offset: 0x0025FA9C
		Private Sub UpdateVisibilityBtnsWithSettings()
			Me.tbarbtnCreature.Pushed = Me.gModuleEditorSettings.FilterShowCreatures
			Me.tbarbtnDoor.Pushed = Me.gModuleEditorSettings.FilterShowDoors
			Me.tbarbtnEncounter.Pushed = Me.gModuleEditorSettings.FilterShowEncounters
			Me.tbarbtnMerchant.Pushed = Me.gModuleEditorSettings.FilterShowMerchants
			Me.tbarbtnPlaceable.Pushed = Me.gModuleEditorSettings.FilterShowPlaceables
			Me.tbarbtnSound.Pushed = Me.gModuleEditorSettings.FilterShowSounds
			Me.tbarbtnTrigger.Pushed = Me.gModuleEditorSettings.FilterShowTriggers
			Me.tbarbtnWaypoint.Pushed = Me.gModuleEditorSettings.FilterShowWaypoints
			Me.chkbShowTags.Checked = Me.gModuleEditorSettings.ShowTagsOnModulePalette
		End Sub

		' Token: 0x06000895 RID: 2197 RVA: 0x00260B70 File Offset: 0x0025FB70
		Private Sub CreateFileSystemWatchers()
			If Not Directory.Exists(Me.g_ProjectPath + "\userpalette") Then
				Directory.CreateDirectory(Me.g_ProjectPath + "\userpalette")
			End If
			Me.g_UserPalettteFsw.Path = Me.g_ProjectPath + "\userpalette"
			Me.g_UserPalettteFsw.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.CreationTime
			Me.g_UserPalettteFsw.SynchronizingObject = Me
			AddHandler Me.g_UserPalettteFsw.Created, AddressOf Me.OnUserPaletteFSChanged
			AddHandler Me.g_UserPalettteFsw.Deleted, AddressOf Me.OnUserPaletteFSChanged
			AddHandler Me.g_UserPalettteFsw.Renamed, AddressOf Me.OnUserPaletteFSChanged
			Me.g_ProjectFsw.Path = Me.g_ProjectPath
			Me.g_ProjectFsw.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.CreationTime
			Me.g_ProjectFsw.SynchronizingObject = Me
			AddHandler Me.g_ProjectFsw.Created, AddressOf Me.OnProjectFSChanged
			AddHandler Me.g_ProjectFsw.Deleted, AddressOf Me.OnProjectFSChanged
			AddHandler Me.g_ProjectFsw.Renamed, AddressOf Me.OnProjectFSChanged
			Me.g_UserPalettteFsw.EnableRaisingEvents = True
			Me.g_ProjectFsw.EnableRaisingEvents = True
		End Sub

		' Token: 0x06000896 RID: 2198 RVA: 0x00260CB0 File Offset: 0x0025FCB0
		Private Sub DisableFileSystemWatchers()
			If Me.g_UserPalettteFsw.EnableRaisingEvents Then
				Me.g_UserPalettteFsw.EnableRaisingEvents = False
				RemoveHandler Me.g_UserPalettteFsw.Created, AddressOf Me.OnUserPaletteFSChanged
				RemoveHandler Me.g_UserPalettteFsw.Deleted, AddressOf Me.OnUserPaletteFSChanged
				RemoveHandler Me.g_UserPalettteFsw.Renamed, AddressOf Me.OnUserPaletteFSChanged
			End If
			If Me.g_ProjectFsw.EnableRaisingEvents Then
				Me.g_ProjectFsw.EnableRaisingEvents = False
				RemoveHandler Me.g_ProjectFsw.Created, AddressOf Me.OnProjectFSChanged
				RemoveHandler Me.g_ProjectFsw.Deleted, AddressOf Me.OnProjectFSChanged
				RemoveHandler Me.g_ProjectFsw.Renamed, AddressOf Me.OnProjectFSChanged
			End If
		End Sub

		' Token: 0x06000897 RID: 2199 RVA: 0x00260D80 File Offset: 0x0025FD80
		Private Sub OnUserPaletteFSChanged(source As Object, e As FileSystemEventArgs)
			Me.BuildUserPaletteTreeView()
			Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger(CInt(e.ChangeType)))
		End Sub

		' Token: 0x06000898 RID: 2200 RVA: 0x00260DB0 File Offset: 0x0025FDB0
		Private Sub OnUserPaletteFSChanged(source As Object, e As RenamedEventArgs)
			frmModule_Editor.g_form.BuildUserPaletteTreeView()
			Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger(CInt(e.ChangeType)))
		End Sub

		' Token: 0x06000899 RID: 2201 RVA: 0x00260DE4 File Offset: 0x0025FDE4
		Private Sub OnProjectFSChanged(source As Object, e As FileSystemEventArgs)
			Dim extension As String = Path.GetExtension(e.Name.ToLower())
			If StringType.StrCmp(extension, ".nss", False) = 0 Then
				Me.BuildScriptsPalette()
			ElseIf StringType.StrCmp(extension, ".dlg", False) = 0 Then
				Me.BuildDialogsPalette()
			End If
			Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger(CInt(e.ChangeType)))
		End Sub

		' Token: 0x0600089A RID: 2202 RVA: 0x00260E54 File Offset: 0x0025FE54
		Private Sub OnProjectFSChanged(source As Object, e As RenamedEventArgs)
			Dim extension As String = Path.GetExtension(e.Name.ToLower())
			If StringType.StrCmp(extension, ".nss", False) = 0 Then
				Me.BuildScriptsPalette()
			ElseIf StringType.StrCmp(extension, ".dlg", False) = 0 Then
				Me.BuildDialogsPalette()
			End If
			Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger(CInt(e.ChangeType)))
		End Sub

		' Token: 0x0600089B RID: 2203 RVA: 0x00260EC4 File Offset: 0x0025FEC4
		Private Sub BuildScriptsPalette()
			Me.lbScripts.Items.Clear()
			Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Me.g_ProjectPath)
			For Each fileInfo As FileInfo In directoryInfo.GetFiles("*.nss")
				Me.lbScripts.Items.Add(Path.GetFileNameWithoutExtension(fileInfo.Name))
			Next
		End Sub

		' Token: 0x0600089C RID: 2204 RVA: 0x00260F28 File Offset: 0x0025FF28
		Private Sub BuildDialogsPalette()
			Me.lbDialogs.Items.Clear()
			Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Me.g_ProjectPath)
			For Each fileInfo As FileInfo In directoryInfo.GetFiles("*.dlg")
				Me.lbDialogs.Items.Add(Path.GetFileNameWithoutExtension(fileInfo.Name))
			Next
		End Sub

		' Token: 0x0600089D RID: 2205 RVA: 0x00260F8C File Offset: 0x0025FF8C
		Public Sub LoadBackground()
			If Me.bmp_cache Is Nothing Then
				Select Case Me.g_MapTypeInUse
					Case 0
						Me.bmp = New Bitmap(Me.g_mapsPath + "map" + Me.g_MapName + ".map")
					Case 1
						Me.bmp = New Bitmap(Me.g_mapsPath + "map" + Me.g_MapName + "_lg.map")
					Case 2
						Me.bmp = New Bitmap(Me.g_mapsPath + "map" + Me.g_MapName + "_alt.map")
				End Select
				Dim bitmap As Bitmap = Me.bmp
				Dim rectangle As Rectangle = New Rectangle(0, 0, Me.bmp.Width, Me.bmp.Height)
				Me.bmp_cache = bitmap.Clone(rectangle, Me.bmp.PixelFormat)
			Else
				Dim bitmap2 As Bitmap = Me.bmp_cache
				Dim rectangle As Rectangle = New Rectangle(0, 0, Me.bmp.Width, Me.bmp.Height)
				Me.bmp = bitmap2.Clone(rectangle, Me.bmp.PixelFormat)
			End If
			Me.g_imageYsize = Me.bmp.Height
		End Sub

		' Token: 0x0600089E RID: 2206 RVA: 0x002610C0 File Offset: 0x002600C0
		Public Sub Draw()
			Dim font As Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim num As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_X"))
			Dim num2 As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_Y"))
			Dim num3 As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
			Dim num4 As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
			Dim pen As Pen = New Pen(Color.White, 1F)
			pen.SetLineCap(LineCap.NoAnchor, LineCap.ArrowAnchor, DashCap.Flat)
			Try
                Dim obj As Object = Graphics.FromImage(Me.bmp)
				Dim type As Type = Nothing
				Dim text As String = "DrawLine"
				Dim array As Object() = New Object() { pen, num3, num4, ObjectType.AddObj(num3, ObjectType.MulObj(Me.IFOfile.GetNodeValue("Mod_Entry_Dir_X"), Me.nudXmul.Value)), ObjectType.SubObj(num4, ObjectType.MulObj(Me.IFOfile.GetNodeValue("Mod_Entry_Dir_Y"), Me.nudYmul.Value)) }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Boolean() = New Boolean() { True, True, True, False, False }
				LateBinding.LateCall(obj, type, text, array2, array3, array4)
				If array4(2) Then
					num4 = IntegerType.FromObject(array(2))
				End If
				If array4(1) Then
					num3 = IntegerType.FromObject(array(1))
				End If
				If array4(0) Then
					pen = CType(array(0), Pen)
				End If
				Graphics.FromImage(Me.bmp).DrawEllipse(New Pen(Color.Red, 2F), num3 - 6, num4 - 6, 12, 12)
			Catch ex As SystemException
				Dim ex2 As SystemException = CType(ex, SystemException)
			End Try
			Dim ticks As Long = DateAndTime.Now.Ticks
			Me.CreatureArr = New ModItem(Me.GITfile.GetListItemCount("Creature List") - 1 + 1 - 1) {}
			Dim num5 As Integer = Me.CreatureArr.GetUpperBound(0)
			Dim num6 As Integer = 0
			Dim num7 As Integer = num5
			For i As Integer = num6 To num7
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").XPosition"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").YPosition"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.CreatureArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "Creature List(" + StringType.FromInteger(i) + ")")
				Me.CreatureArr(i).XPosAccessor = "XPosition"
				Me.CreatureArr(i).YPosAccessor = "YPosition"
				Me.CreatureArr(i).ZPosAccessor = "ZPosition"
				Me.CreatureArr(i).ItemType = 2027
				If Me.CreatureArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowCreatures Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utc")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						Dim obj3 As Object = Graphics.FromImage(Me.bmp)
						Dim type2 As Type = Nothing
						Dim text2 As String = "DrawLine"
						Dim array5 As Object() = New Object() { New Pen(Color.White, 1F), num3, num4, ObjectType.AddObj(num3, ObjectType.MulObj(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").XOrientation"), Me.nudXmul.Value)), ObjectType.SubObj(num4, ObjectType.MulObj(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").YOrientation"), Me.nudYmul.Value)) }
						Dim array6 As Object() = array5
						Dim array7 As String() = Nothing
						Dim array4 As Boolean() = New Boolean() { False, True, True, False, False }
						LateBinding.LateCall(obj3, type2, text2, array6, array7, array4)
						If array4(2) Then
							num4 = IntegerType.FromObject(array5(2))
						End If
						If array4(1) Then
							num3 = IntegerType.FromObject(array5(1))
						End If
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.HotPink)
					Catch ex3 As SystemException
						Dim ex4 As SystemException = CType(ex3, SystemException)
					End Try
				End If
			Next
			Me.PlaceableArr = New ModItem(Me.GITfile.GetListItemCount("Placeable List") - 1 + 1 - 1) {}
			num5 = Me.PlaceableArr.GetUpperBound(0)
			Dim num8 As Integer = 0
			Dim num9 As Integer = num5
			For i As Integer = num8 To num9
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(i) + ").X"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(i) + ").Y"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.PlaceableArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "Placeable List(" + StringType.FromInteger(i) + ")")
				Me.PlaceableArr(i).XPosAccessor = "X"
				Me.PlaceableArr(i).YPosAccessor = "Y"
				Me.PlaceableArr(i).ZPosAccessor = "Z"
				Me.PlaceableArr(i).ItemType = 2044
				If Me.PlaceableArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowPlaceables Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utp")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						num = SingleType.FromObject(Me.GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(i) + ").Bearing"))
						Graphics.FromImage(Me.bmp).DrawLine(New Pen(Color.White, 1F), num3, num4, num3 - CInt(Math.Round(Math.Cos(CDbl(num)) * Convert.ToDouble(Me.nudXmul.Value))), num4 + CInt(Math.Round(Math.Sin(CDbl(num)) * Convert.ToDouble(Me.nudYmul.Value))))
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.LightGreen)
					Catch ex5 As SystemException
						Dim ex6 As SystemException = CType(ex5, SystemException)
						Console.WriteLine(String.Concat(New String() { ex6.Message, ":  ", StringType.FromInteger(num3), "  ", StringType.FromInteger(num4), "  ", StringType.FromInteger(num3 - CInt(Math.Round(Math.Cos(CDbl(num)) * Convert.ToDouble(Me.nudXmul.Value)))), "  ", StringType.FromInteger(num4 + CInt(Math.Round(Math.Sin(CDbl(num)) * Convert.ToDouble(Me.nudYmul.Value)))) }))
					End Try
				End If
			Next
			Me.DoorArr = New ModItem(Me.GITfile.GetListItemCount("Door List") - 1 + 1 - 1) {}
			num5 = Me.DoorArr.GetUpperBound(0)
			Dim num10 As Integer = 0
			Dim num11 As Integer = num5
			For i As Integer = num10 To num11
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("Door List(" + StringType.FromInteger(i) + ").X"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("Door List(" + StringType.FromInteger(i) + ").Y"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("Door List(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.DoorArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "Door List(" + StringType.FromInteger(i) + ")")
				Me.DoorArr(i).XPosAccessor = "X"
				Me.DoorArr(i).YPosAccessor = "Y"
				Me.DoorArr(i).ZPosAccessor = "Z"
				Me.DoorArr(i).ItemType = 2042
				If Me.DoorArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowDoors Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utd")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						num = SingleType.FromObject(ObjectType.AddObj(Me.GITfile.GetNodeValue("Door List(" + StringType.FromInteger(i) + ").Bearing"), 1.5707963267948966))
						Graphics.FromImage(Me.bmp).DrawLine(New Pen(Color.White, 1F), num3, num4, num3 - CInt(Math.Round(Math.Cos(CDbl(num)) * Convert.ToDouble(Me.nudXmul.Value))), num4 + CInt(Math.Round(Math.Sin(CDbl(num)) * Convert.ToDouble(Me.nudYmul.Value))))
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.Yellow)
					Catch ex7 As SystemException
						Dim ex8 As SystemException = CType(ex7, SystemException)
					End Try
				End If
			Next
			Me.SoundArr = New ModItem(Me.GITfile.GetListItemCount("SoundList") - 1 + 1 - 1) {}
			num5 = Me.SoundArr.GetUpperBound(0)
			Dim num12 As Integer = 0
			Dim num13 As Integer = num5
			For i As Integer = num12 To num13
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(i) + ").XPosition"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(i) + ").YPosition"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.SoundArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "SoundList(" + StringType.FromInteger(i) + ")")
				Me.SoundArr(i).XPosAccessor = "XPosition"
				Me.SoundArr(i).YPosAccessor = "YPosition"
				Me.SoundArr(i).ZPosAccessor = "ZPosition"
				Me.SoundArr(i).ItemType = 2035
				If Me.SoundArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowSounds Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".uts")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.Blue)
					Catch ex9 As SystemException
						Dim ex10 As SystemException = CType(ex9, SystemException)
					End Try
				End If
			Next
			Me.WaypointArr = New ModItem(Me.GITfile.GetListItemCount("WaypointList") - 1 + 1 - 1) {}
			num5 = Me.WaypointArr.GetUpperBound(0)
			Dim num14 As Integer = 0
			Dim num15 As Integer = num5
			For i As Integer = num14 To num15
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").XPosition"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").YPosition"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.WaypointArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "WaypointList(" + StringType.FromInteger(i) + ")")
				Me.WaypointArr(i).XPosAccessor = "XPosition"
				Me.WaypointArr(i).YPosAccessor = "YPosition"
				Me.WaypointArr(i).ZPosAccessor = "ZPosition"
				Me.WaypointArr(i).ItemType = 2058
				Me.WaypointArr(i).Tag = StringType.FromObject(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").Tag"))
				If Me.WaypointArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				Dim color As Color
				If BooleanType.FromObject(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").HasMapNote")) Then
					color = Color.Red
				Else
					color = Color.Orange
				End If
				If Me.gModuleEditorSettings.FilterShowWaypoints Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.WaypointArr(i).Tag
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						Dim obj4 As Object = Graphics.FromImage(Me.bmp)
						Dim type3 As Type = Nothing
						Dim text3 As String = "DrawLine"
						Dim array5 As Object() = New Object() { New Pen(Color.White, 1F), num3, num4, ObjectType.AddObj(num3, ObjectType.MulObj(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").XOrientation"), Me.nudXmul.Value)), ObjectType.SubObj(num4, ObjectType.MulObj(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").YOrientation"), Me.nudYmul.Value)) }
						Dim array8 As Object() = array5
						Dim array9 As String() = Nothing
						Dim array4 As Boolean() = New Boolean() { False, True, True, False, False }
						LateBinding.LateCall(obj4, type3, text3, array8, array9, array4)
						If array4(2) Then
							num4 = IntegerType.FromObject(array5(2))
						End If
						If array4(1) Then
							num3 = IntegerType.FromObject(array5(1))
						End If
						Me.Draw3x3Box(Me.bmp, num3, num4, color)
					Catch ex11 As SystemException
						Dim ex12 As SystemException = CType(ex11, SystemException)
					End Try
				End If
			Next
			Me.MerchantArr = New ModItem(Me.GITfile.GetListItemCount("StoreList") - 1 + 1 - 1) {}
			num5 = Me.MerchantArr.GetUpperBound(0)
			Dim num16 As Integer = 0
			Dim num17 As Integer = num5
			For i As Integer = num16 To num17
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").XPosition"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").YPosition"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").ResRef"))
				Me.MerchantArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "StoreList(" + StringType.FromInteger(i) + ")")
				Me.MerchantArr(i).XPosAccessor = "XPosition"
				Me.MerchantArr(i).YPosAccessor = "YPosition"
				Me.MerchantArr(i).ZPosAccessor = "ZPosition"
				Me.MerchantArr(i).ItemType = 2051
				If Me.MerchantArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowMerchants Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utm")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						Dim obj5 As Object = Graphics.FromImage(Me.bmp)
						Dim type4 As Type = Nothing
						Dim text4 As String = "DrawLine"
						Dim array5 As Object() = New Object() { New Pen(Color.White, 1F), num3, num4, ObjectType.AddObj(num3, ObjectType.MulObj(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").XOrientation"), Me.nudXmul.Value)), ObjectType.SubObj(num4, ObjectType.MulObj(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").YOrientation"), Me.nudYmul.Value)) }
						Dim array10 As Object() = array5
						Dim array11 As String() = Nothing
						Dim array4 As Boolean() = New Boolean() { False, True, True, False, False }
						LateBinding.LateCall(obj5, type4, text4, array10, array11, array4)
						If array4(2) Then
							num4 = IntegerType.FromObject(array5(2))
						End If
						If array4(1) Then
							num3 = IntegerType.FromObject(array5(1))
						End If
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.Plum)
					Catch ex13 As SystemException
						Dim ex14 As SystemException = CType(ex13, SystemException)
					End Try
				End If
			Next
			num5 = Me.GITfile.GetListItemCount("CameraList")
			Me.CameraArr = New ModItem(num5 - 1 + 1 - 1) {}
			Dim num18 As Integer = 0
			Dim num19 As Integer = num5 - 1
			For i As Integer = num18 To num19
				Dim gfftype As GFFType17 = CType(Me.GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(i) + ").Position"), GFFType17)
				num = gfftype.f1
				num2 = gfftype.f2
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(i) + ").CameraID"))
				Me.CameraArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "CameraList(" + StringType.FromInteger(i) + ")")
				Me.CameraArr(i).ItemType = 6
				If Me.CameraArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.ShowItemLabels Then
					Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(ObjectType.StrCatObj("Cam ", obj2)), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
				End If
				Try
					Me.Draw3x3Box(Me.bmp, num3, num4, Color.Olive)
				Catch ex15 As SystemException
					Dim ex16 As SystemException = CType(ex15, SystemException)
				End Try
			Next
            Dim mapGraphics As Graphics = Graphics.FromImage(Me.bmp)
            num5 = Me.GITfile.GetListItemCount("TriggerList")
            Me.TriggerRegions = New Region(num5 - 1 + 1 - 1) {}
            Me.TriggerArr = New ModItem(num5 - 1 + 1 - 1) {}
			Dim num20 As Integer = 0
			Dim num21 As Integer = num5 - 1
			For i As Integer = num20 To num21
				Dim num22 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").XPosition"))
				Dim num23 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").YPosition"))
				Dim num24 As Single
				Dim num25 As Single
				Dim num26 As Single
				Dim num27 As Single

					num24 = Convert.ToSingle(Me.nudXmul.Value) * num22 - Convert.ToSingle(Me.nudXoff.Value)
					num25 = Convert.ToSingle(Me.nudYmul.Value) * num23 - Convert.ToSingle(Me.nudYoff.Value)
					num26 = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, ObjectType.AddObj(num22, Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").Geometry(0).PointX"))))), Me.nudXoff.Value))
					num27 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, ObjectType.AddObj(num23, Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").Geometry(0).PointY"))))), Me.nudYoff.Value))))

				Me.TriggerArr(i) = New ModItem(CInt(Math.Round(CDbl(num24))), CInt(Math.Round(CDbl(num25))), num22, num23, StringType.FromObject(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").TemplateResRef")), "TriggerList(" + StringType.FromInteger(i) + ")")
				Me.TriggerArr(i).Z = SingleType.FromObject(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").ZPosition"))
				Me.TriggerArr(i).XPosAccessor = "XPosition"
				Me.TriggerArr(i).YPosAccessor = "YPosition"
				Me.TriggerArr(i).ZPosAccessor = "ZPosition"
				Me.TriggerArr(i).ItemType = 2032
				Me.TriggerArr(i).GeometryList = New ArrayList()
				Dim geometryList As ArrayList = Me.TriggerArr(i).GeometryList
				Dim point As Point = New Point(CInt(Math.Round(CDbl(num26))), CInt(Math.Round(CDbl(num27))))
				geometryList.Add(point)
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Dim num28 As Integer = Me.GITfile.GetListItemCount("TriggerList(" + StringType.FromInteger(i) + ").Geometry") - 1
				Dim num29 As Integer = 1
				Dim num30 As Integer = num28
				For j As Integer = num29 To num30
					num = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, ObjectType.AddObj(num22, Me.GITfile.GetNodeValue(String.Concat(New String() { "TriggerList(", StringType.FromInteger(i), ").Geometry(", StringType.FromInteger(j), ").PointX" })))))), Me.nudXoff.Value))
					num2 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, ObjectType.AddObj(num23, Me.GITfile.GetNodeValue(String.Concat(New String() { "TriggerList(", StringType.FromInteger(i), ").Geometry(", StringType.FromInteger(j), ").PointY" })))))), Me.nudYoff.Value))))
					Try
						Dim geometryList2 As ArrayList = Me.TriggerArr(i).GeometryList
						point = New Point(CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
						geometryList2.Add(point)
					Catch ex17 As SystemException
						Dim ex18 As SystemException = CType(ex17, SystemException)
					End Try
				Next
				num = 0F
				num2 = 0F
				Dim num31 As Integer = 0
				Dim num32 As Integer = num28
				For j As Integer = num31 To num32
					num = SingleType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(Me.TriggerArr(i).GeometryList(j), Nothing, "X", New Object(-1) {}, Nothing, Nothing)))
					num2 = SingleType.FromObject(ObjectType.AddObj(num2, LateBinding.LateGet(Me.TriggerArr(i).GeometryList(j), Nothing, "Y", New Object(-1) {}, Nothing, Nothing)))
				Next
				num = CSng(CInt(Math.Round(CDbl((num / CSng((num28 + 1)))))))
				num2 = CSng(CInt(Math.Round(CDbl((num2 / CSng((num28 + 1)))))))
				If Me.TriggerArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
				End If

					If Me.gModuleEditorSettings.FilterShowTriggers Then
						If Me.gModuleEditorSettings.ShowItemLabels AndAlso Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							Dim modItemTag As String = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utt")))
							If modItemTag IsNot Nothing AndAlso StringType.StrCmp(modItemTag, "", False) <> 0 Then
								Graphics.FromImage(Me.bmp).DrawString(modItemTag, Me.labelFont, Me.labelBrush, num + 5F, num2 - 5F)
							Else
								Dim text5 As String
								If Directory.Exists(Me.g_ProjectPath + "\recycle") Then
									Dim files As String() = Directory.GetFiles(Me.g_ProjectPath + "\recycle", StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj("*", obj2), ".utt")))
									If files.Length > 0 Then
										text5 = vbLf & vbLf & "However, there are one or more files in your project's 'recycle' folder that match the file's name." & vbLf & vbLf & "If you wish to keep the file's item, you can move and rename the desired file back into your project folder without quitting the Module editor. Otherwise, select the item in the Module treeview, right click to bring up the menu, then choose Delete."
									End If
								End If
								Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Unable to find file for trigger '", obj2), "' in your project folder or in templates.bif"), text5), MsgBoxStyle.Exclamation, "Missing file")
								Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(ObjectType.StrCatObj(obj2, " - MISSING")), Me.labelFont, Me.labelBrush, num + 5F, num2 - 5F)
							End If
						End If
						If obj2.ToString().StartsWith("g_t_") Then
                        Me.TriggerRegions(i) = Me.DrawRegionPoints(mapGraphics, Me.TriggerArr(i).GeometryList, Color.MediumAquamarine, True)
						Else
                        Me.TriggerRegions(i) = Me.DrawRegionPoints(mapGraphics, Me.TriggerArr(i).GeometryList, Color.MediumTurquoise, True)
						End If
					End If

			Next
            mapGraphics = Graphics.FromImage(Me.bmp)
            num5 = Me.GITfile.GetListItemCount("Encounter List")
			Me.EncounterRegions = New Region(num5 - 1 + 1 - 1) {}
			Me.EncounterArr = New ModItem(num5 - 1 + 1 - 1) {}
			Dim num33 As Integer = 0
			Dim num34 As Integer = num5 - 1
			For i As Integer = num33 To num34
				Dim num22 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").XPosition"))
				Dim num23 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").YPosition"))
				Dim num24 As Single
				Dim num25 As Single
				Dim num26 As Single
				Dim num27 As Single

					num24 = Convert.ToSingle(Me.nudXmul.Value) * num22 - Convert.ToSingle(Me.nudXoff.Value)
					num25 = Convert.ToSingle(Me.nudYmul.Value) * num23 - Convert.ToSingle(Me.nudYoff.Value)
					num26 = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, ObjectType.AddObj(num22, Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").Geometry(0).PointX"))))), Me.nudXoff.Value))
					num27 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, ObjectType.AddObj(num23, Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").Geometry(0).PointY"))))), Me.nudYoff.Value))))

				Me.EncounterArr(i) = New ModItem(CInt(Math.Round(CDbl(num24))), CInt(Math.Round(CDbl(num25))), num22, num23, StringType.FromObject(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").TemplateResRef")), "Encounter List(" + StringType.FromInteger(i) + ")")
				Me.EncounterArr(i).Z = SingleType.FromObject(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").ZPosition"))
				Me.EncounterArr(i).XPosAccessor = "XPosition"
				Me.EncounterArr(i).YPosAccessor = "YPosition"
				Me.EncounterArr(i).ZPosAccessor = "ZPosition"
				Me.EncounterArr(i).ItemType = 2040
				Me.EncounterArr(i).GeometryList = New ArrayList()
				Dim geometryList3 As ArrayList = Me.EncounterArr(i).GeometryList
				Dim point As Point = New Point(CInt(Math.Round(CDbl(num26))), CInt(Math.Round(CDbl(num27))))
				geometryList3.Add(point)
				Me.EncounterArr(i).SpawnPointList = New ArrayList()
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Dim num35 As Integer = 1
				Dim num36 As Integer = Me.GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(i) + ").Geometry") - 1
				For j As Integer = num35 To num36
					num = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, ObjectType.AddObj(num22, Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").Geometry(", StringType.FromInteger(j), ").X" })))))), Me.nudXoff.Value))
					num2 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, ObjectType.AddObj(num23, Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").Geometry(", StringType.FromInteger(j), ").Y" })))))), Me.nudYoff.Value))))
					Try
						Dim geometryList4 As ArrayList = Me.EncounterArr(i).GeometryList
						point = New Point(CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
						geometryList4.Add(point)
					Catch ex19 As SystemException
						Dim ex20 As SystemException = CType(ex19, SystemException)
					End Try
				Next
				Dim num37 As Integer = 0
				Dim num38 As Integer = Me.GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(i) + ").SpawnPointList") - 1
				For j As Integer = num37 To num38
					num = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").SpawnPointList(", StringType.FromInteger(j), ").X" }))))), Me.nudXoff.Value))
					num2 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").SpawnPointList(", StringType.FromInteger(j), ").Y" }))))), Me.nudYoff.Value))))
					Try
						Dim spawnPointList As ArrayList = Me.EncounterArr(i).SpawnPointList
						point = New Point(CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
						spawnPointList.Add(point)
					Catch ex21 As SystemException
						Dim ex22 As SystemException = CType(ex21, SystemException)
					End Try
				Next
				num = 0F
				num2 = 0F
				Dim num28 As Integer = Me.GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(i) + ").Geometry") - 1
				Dim num39 As Integer = 0
				Dim num40 As Integer = num28
				For j As Integer = num39 To num40
					num = SingleType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(Me.EncounterArr(i).GeometryList(j), Nothing, "X", New Object(-1) {}, Nothing, Nothing)))
					num2 = SingleType.FromObject(ObjectType.AddObj(num2, LateBinding.LateGet(Me.EncounterArr(i).GeometryList(j), Nothing, "Y", New Object(-1) {}, Nothing, Nothing)))
				Next
				num = CSng(CInt(Math.Round(CDbl((num / CSng((num28 + 1)))))))
				num2 = CSng(CInt(Math.Round(CDbl((num2 / CSng((num28 + 1)))))))
				Dim pen2 As Pen = New Pen(Color.Wheat, 0.5F)
				pen2.SetLineCap(LineCap.RoundAnchor, LineCap.ArrowAnchor, DashCap.Flat)
				If Me.EncounterArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
				End If
				If Me.gModuleEditorSettings.FilterShowEncounters Then
					Try
						For Each obj6 As Object In Me.EncounterArr(i).SpawnPointList
							Dim point2 As Point = CType((If(obj6, Activator.CreateInstance(GetType(Point)))), Point)
							Graphics.FromImage(Me.bmp).DrawLine(pen2, CSng(point2.X), CSng(point2.Y), num, num2)
							Graphics.FromImage(Me.bmp).DrawString(StringType.FromInteger(Me.EncounterArr(i).SpawnPointList.IndexOf(point2) + 1), font, Brushes.Orchid, CSng((point2.X + 2)), CSng((point2.Y + 2)))
							Me.Draw3x3Box(Me.bmp, point2.X, point2.Y, Color.Orchid)
							Dim num41 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").SpawnPointList(", StringType.FromInteger(Me.EncounterArr(i).SpawnPointList.IndexOf(point2)), ").Orientation" })))
							Graphics.FromImage(Me.bmp).DrawLine(New Pen(Color.White, 1F), point2.X, point2.Y, point2.X + CInt(Math.Round(Math.Sin(CDbl(num41)) * Convert.ToDouble(Me.nudXmul.Value))), point2.Y - CInt(Math.Round(Math.Cos(CDbl(num41)) * Convert.ToDouble(Me.nudYmul.Value))))
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							CType(enumerator, IDisposable).Dispose()
						End If
					End Try

						If Me.gModuleEditorSettings.ShowItemLabels Then
							If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
								obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".ute")))
							End If
							Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, num + 5F, num2 - 5F)
						End If
                    Me.EncounterRegions(i) = Me.DrawRegionPoints(mapGraphics, Me.EncounterArr(i).GeometryList, Color.Teal, True)

				End If
			Next
			Me.pbox.Image = Me.bmp
			GC.Collect()
		End Sub

		' Token: 0x0600089F RID: 2207 RVA: 0x00263C1C File Offset: 0x00262C1C
		Private Function DrawRegionPoints(g As Graphics, PointList As ArrayList, color As Color, Optional CloseFigure As Boolean = True) As Region
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim pen As Pen = New Pen(color, 1F)
			pen.EndCap = LineCap.Square
			Dim point As Point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim num As Integer = 1
			Dim num2 As Integer = PointList.Count - 1
			Dim rectangle As Rectangle
			For i As Integer = num To num2
				Dim pen2 As Pen = pen
				rectangle = New Rectangle(point.X - 1, point.Y - 1, 2, 2)
				g.DrawRectangle(pen2, rectangle)
				graphicsPath.AddLine(point, CType((If(PointList(i), Activator.CreateInstance(GetType(Point)))), Point))
				point = CType((If(PointList(i), Activator.CreateInstance(GetType(Point)))), Point)
			Next
			Dim pen3 As Pen = pen
			rectangle = New Rectangle(point.X - 1, point.Y - 1, 2, 2)
			g.DrawRectangle(pen3, rectangle)
			If CloseFigure Then
				graphicsPath.CloseFigure()
			End If
			g.DrawPath(pen, graphicsPath)
			Return New Region(graphicsPath)
		End Function

		' Token: 0x060008A0 RID: 2208 RVA: 0x00263D34 File Offset: 0x00262D34
		Private Sub Draw3x3Box(bmp As Bitmap, x As Integer, y As Integer, color As Color)
			' The following expression was wrapped in a checked-statement
			Graphics.FromImage(bmp).DrawRectangle(New Pen(color, Convert.ToSingle(Me.dModuleElementIndicatorSize)), x - 1, y - 1, 2, 2)
		End Sub

		' Token: 0x060008A1 RID: 2209 RVA: 0x00263D5C File Offset: 0x00262D5C
		Private Sub Draw6x6Box(bmp As Bitmap, x As Integer, y As Integer, color As Color)
			' The following expression was wrapped in a checked-statement
			Graphics.FromImage(bmp).DrawRectangle(New Pen(color, Convert.ToSingle(Me.dModuleElementIndicatorSize)), x - 2, y - 2, 5, 5)
		End Sub

		' Token: 0x060008A2 RID: 2210 RVA: 0x00263D84 File Offset: 0x00262D84
		Private Sub IndicateModItem(g As Graphics, x As Integer, y As Integer)
			' The following expression was wrapped in a checked-statement
			If Not Me.LeftMouseClickActive Then
				Dim panel As ScrollableControl = Me.Panel1
				Dim point As Point = New Point(CInt(Math.Round(CDbl(x) - CDbl(Me.Panel1.Size.Width) / 2.0)), CInt(Math.Round(CDbl(y) - CDbl(Me.Panel1.Size.Height) / 2.0)))
				panel.AutoScrollPosition = point
				If Me.bShowLocatorRay Then
					g.DrawLine(New Pen(Color.Orange, 2F), 0, 0, x, y)
				End If
			End If
			Dim pen As Pen = New Pen(Color.Orange, 1F)
			pen.EndCap = LineCap.ArrowAnchor
			g.DrawLine(pen, x + 10, y + 10, x + 4, y + 4)
			g.DrawLine(pen, x - 10, y + 10, x - 4, y + 4)
			g.DrawLine(pen, x + 10, y - 10, x + 4, y - 4)
			g.DrawLine(pen, x - 10, y - 10, x - 4, y - 4)
		End Sub

		' Token: 0x060008A3 RID: 2211 RVA: 0x00263E8C File Offset: 0x00262E8C
		Private Function invy(y As Integer) As Integer
			' The following expression was wrapped in a checked-expression
			Return Me.g_imageYsize - y
		End Function

		' Token: 0x060008A4 RID: 2212 RVA: 0x00263EA4 File Offset: 0x00262EA4
		Private Sub CopyModFilesToPath(ModItemArr As ModItem(), destPath As String)
			If ModItemArr IsNot Nothing Then
				For Each modItem As ModItem In ModItemArr
					If(modItem IsNot Nothing) And File.Exists(Me.g_ProjectPath + "\" + modItem.FileName) Then
						File.Copy(Me.g_ProjectPath + "\" + modItem.FileName, destPath + modItem.FileName, True)
					End If
				Next
			End If
		End Sub

		' Token: 0x060008A5 RID: 2213 RVA: 0x00263F18 File Offset: 0x00262F18
		Private Function Near(x As Object, y As Object, xCompare As Object, yCompare As Object) As Boolean
			Return BooleanType.FromObject(If((Not BooleanType.FromObject(ObjectType.ObjTst(LateBinding.LateGet(Nothing, GetType(Math), "Abs", New Object() { ObjectType.SubObj(x, xCompare) }, Nothing, Nothing), 2, False) <= 0) OrElse Not BooleanType.FromObject(ObjectType.ObjTst(LateBinding.LateGet(Nothing, GetType(Math), "Abs", New Object() { ObjectType.SubObj(y, yCompare) }, Nothing, Nothing), 2, False) <= 0)), False, True))
		End Function

		' Token: 0x060008A6 RID: 2214 RVA: 0x00263FC8 File Offset: 0x00262FC8
        ' Token: 0x060008A6 RID: 2214 RVA: 0x00263FC8 File Offset: 0x00262FC8
        Private Function FindModItem(ByVal pb As PictureBox) As ModItem
            Dim x As Integer = pb.PointToClient(Control.MousePosition).X
            Dim y As Integer = pb.PointToClient(Control.MousePosition).Y
            Dim foundItem As ModItem = Nothing

            If Me.CreatureArr IsNot Nothing Then
                For Each creatureItem As ModItem In Me.CreatureArr
                    If creatureItem IsNot Nothing AndAlso Me.Near(x, y, creatureItem.ScreenX, creatureItem.ScreenY) Then
                        foundItem = creatureItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.PlaceableArr IsNot Nothing Then
                For Each placeableItem As ModItem In Me.PlaceableArr
                    If placeableItem IsNot Nothing AndAlso Me.Near(x, y, placeableItem.ScreenX, placeableItem.ScreenY) Then
                        foundItem = placeableItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.WaypointArr IsNot Nothing Then
                For Each waypointItem As ModItem In Me.WaypointArr
                    If waypointItem IsNot Nothing AndAlso Me.Near(x, y, waypointItem.ScreenX, waypointItem.ScreenY) Then
                        foundItem = waypointItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.DoorArr IsNot Nothing Then
                For Each doorItem As ModItem In Me.DoorArr
                    If doorItem IsNot Nothing AndAlso Me.Near(x, y, doorItem.ScreenX, doorItem.ScreenY) Then
                        foundItem = doorItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.SoundArr IsNot Nothing Then
                For Each soundItem As ModItem In Me.SoundArr
                    If soundItem IsNot Nothing AndAlso Me.Near(x, y, soundItem.ScreenX, soundItem.ScreenY) Then
                        foundItem = soundItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.MerchantArr IsNot Nothing Then
                For Each merchantItem As ModItem In Me.MerchantArr
                    If merchantItem IsNot Nothing AndAlso Me.Near(x, y, merchantItem.ScreenX, merchantItem.ScreenY) Then
                        foundItem = merchantItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.TriggerArr IsNot Nothing Then
                For Each triggerItem As ModItem In Me.TriggerArr
                    If triggerItem IsNot Nothing AndAlso triggerItem.GeometryList IsNot Nothing Then
                        Dim nodeIndex As Integer = 0
                        Dim lastNodeIndex As Integer = triggerItem.GeometryList.Count - 1

                        For nodeIndex = 0 To lastNodeIndex
                            Dim point As Point = CType(If(triggerItem.GeometryList(nodeIndex), Activator.CreateInstance(GetType(Point))), Point)

                            If Me.Near(x, y, point.X, point.Y) Then
                                foundItem = New ModItem(triggerItem.ScreenX, triggerItem.ScreenY, 0.0F, 0.0F, triggerItem.ResRef, triggerItem.Path, triggerItem)
                                foundItem.XPosAccessor = "Geometry(" + StringType.FromInteger(nodeIndex) + ").PointX"
                                foundItem.YPosAccessor = "Geometry(" + StringType.FromInteger(nodeIndex) + ").PointY"
                                foundItem.ItemType = 2032

                                Me.sbarpnlAddlInfo.Text = String.Concat(New String() {
                                    "Node: ",
                                    StringType.FromInteger(nodeIndex),
                                    "   x: ",
                                    StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(point.X), Me.nudXoff.Value), Me.nudXmul.Value))),
                                    "   y: ",
                                    StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(point.Y)), Me.nudYoff.Value), Me.nudYmul.Value)))
                                })

                                foundItem.GeometryList = New ArrayList()
                                foundItem.GeometryList.Add(point)
                                Exit For
                            End If
                        Next
                    End If

                    If foundItem IsNot Nothing Then
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.EncounterArr IsNot Nothing Then
                For Each encounterItem As ModItem In Me.EncounterArr
                    If encounterItem IsNot Nothing Then
                        If encounterItem.GeometryList IsNot Nothing Then
                            Dim nodeIndex As Integer = 0
                            Dim lastNodeIndex As Integer = encounterItem.GeometryList.Count - 1

                            For nodeIndex = 0 To lastNodeIndex
                                Dim point As Point = CType(If(encounterItem.GeometryList(nodeIndex), Activator.CreateInstance(GetType(Point))), Point)

                                If Me.Near(x, y, point.X, point.Y) Then
                                    foundItem = New ModItem(encounterItem.ScreenX, encounterItem.ScreenY, 0.0F, 0.0F, encounterItem.ResRef, encounterItem.Path, encounterItem)
                                    foundItem.XPosAccessor = "Geometry(" + StringType.FromInteger(nodeIndex) + ").X"
                                    foundItem.YPosAccessor = "Geometry(" + StringType.FromInteger(nodeIndex) + ").Y"
                                    foundItem.ItemType = 2040

                                    Me.sbarpnlAddlInfo.Text = String.Concat(New String() {
                                        "Node: ",
                                        StringType.FromInteger(nodeIndex + 1),
                                        "   x: ",
                                        StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(point.X), Me.nudXoff.Value), Me.nudXmul.Value))),
                                        "   y: ",
                                        StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(point.Y)), Me.nudYoff.Value), Me.nudYmul.Value)))
                                    })

                                    foundItem.GeometryList = New ArrayList()
                                    foundItem.GeometryList.Add(point)
                                    Exit For
                                End If
                            Next
                        End If

                        If foundItem Is Nothing AndAlso encounterItem.SpawnPointList IsNot Nothing Then
                            Dim spawnIndex As Integer = 0
                            Dim lastSpawnIndex As Integer = encounterItem.SpawnPointList.Count - 1

                            For spawnIndex = 0 To lastSpawnIndex
                                Dim point As Point = CType(If(encounterItem.SpawnPointList(spawnIndex), Activator.CreateInstance(GetType(Point))), Point)

                                If Me.Near(x, y, point.X, point.Y) Then
                                    foundItem = New ModItem(encounterItem.ScreenX, encounterItem.ScreenY, 0.0F, 0.0F, encounterItem.ResRef, encounterItem.Path + ".SpawnPointList(" + StringType.FromInteger(spawnIndex) + ")", encounterItem)
                                    foundItem.XPosAccessor = "X"
                                    foundItem.YPosAccessor = "Y"
                                    foundItem.ItemType = 12040

                                    Me.sbarpnlAddlInfo.Text = String.Concat(New String() {
                                        "SP: ",
                                        StringType.FromInteger(spawnIndex + 1),
                                        "   x: ",
                                        StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(point.X), Me.nudXoff.Value), Me.nudXmul.Value))),
                                        "   y: ",
                                        StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(point.Y)), Me.nudYoff.Value), Me.nudYmul.Value)))
                                    })

                                    foundItem.GeometryList = New ArrayList()
                                    foundItem.GeometryList.Add(point)
                                    Exit For
                                End If
                            Next
                        End If
                    End If

                    If foundItem IsNot Nothing Then
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.CameraArr IsNot Nothing Then
                For Each cameraItem As ModItem In Me.CameraArr
                    If cameraItem IsNot Nothing AndAlso Me.Near(x, y, cameraItem.ScreenX, cameraItem.ScreenY) Then
                        foundItem = cameraItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing Then
                Dim entryX As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_X"))
                Dim entryY As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_Y"))

                Dim screenX As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl(Convert.ToSingle(Me.nudXmul.Value) * entryX)))), Me.nudXoff.Value))
                Dim screenY As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl(Convert.ToSingle(Me.nudYmul.Value) * entryY)))), Me.nudYoff.Value)))

                If Me.Near(x, y, screenX, screenY) Then
                    foundItem = New ModItem(screenX, screenY, entryX, entryY, "Mod Entry Point", "")
                    foundItem.ItemType = 5000
                End If
            End If

            Return foundItem
        End Function

		' Token: 0x060008A7 RID: 2215 RVA: 0x0026495C File Offset: 0x0026395C
        ' Token: 0x060008A7 RID: 2215 RVA: 0x0026495C File Offset: 0x0026395C
        Private Sub EditItemProperties(ByVal cmi As ModItem)
            Dim frmModuleItem_Base_Editor As frmModuleItem_Base_Editor = New frmModuleItem_Base_Editor()
            Dim resRef As String = cmi.ResRef

            frmModuleItem_Base_Editor.tbResRef.Text = cmi.ResRef
            frmModuleItem_Base_Editor.tbXPosition.Text = StringType.FromSingle(cmi.X)
            frmModuleItem_Base_Editor.tbYPosition.Text = StringType.FromSingle(cmi.Y)
            frmModuleItem_Base_Editor.tbZPosition.Text = StringType.FromObject(Me.GITfile.GetNodeValue(cmi.ZPosPath))

            Dim itemType As Integer = cmi.ItemType
            Dim flag As Boolean
            Dim listItemCount As Integer

            If itemType = 2027 OrElse itemType = 2051 Then
                frmModuleItem_Base_Editor.XOrientation = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".XOrientation"))
                frmModuleItem_Base_Editor.YOrientation = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".YOrientation"))
                frmModuleItem_Base_Editor.SetupOrientationIndicators()

            ElseIf itemType = 2058 Then
                frmModuleItem_Base_Editor.XOrientation = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".XOrientation"))
                frmModuleItem_Base_Editor.YOrientation = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".YOrientation"))
                frmModuleItem_Base_Editor.SetupOrientationIndicators()

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbWPLinkedTo, cmi.Path + ".LinkedTo")
                Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbWpLocalizedName, cmi.Path + ".LocalizedName", Me.g_clsDialogTlk)
                Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbWpDescription, cmi.Path + ".Description", Me.g_clsDialogTlk)
                Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbWpMapNote, cmi.Path + ".MapNote", Me.g_clsDialogTlk)

                frmModuleItem_Base_Editor.chkbHasMapNote.Checked = BooleanType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".HasMapNote"))
                frmModuleItem_Base_Editor.chkbMapNoteEnabled.Checked = BooleanType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".MapNoteEnabled"))

            ElseIf itemType = 2042 Then
                frmModuleItem_Base_Editor.Bearing(2042) = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".Bearing"))

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedTo, cmi.Path + ".LinkedTo")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule")
                Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin", Me.g_clsDialogTlk)

                frmModuleItem_Base_Editor.cmbxDoorLinkedToFlags.SelectedIndex = IntegerType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".LinkedToFlags"))
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")

            ElseIf itemType = 2032 Then
                Dim clsGFF As clsGFF = Nothing

                If File.Exists(Me.g_ProjectPath + "\" + cmi.FileName) Then
                    Dim fileStream As FileStream = File.OpenRead(Me.g_ProjectPath + "\" + cmi.FileName)
                    clsGFF = New clsGFF(fileStream, Me.KotorVersionIndex, True)
                Else
                    Dim biffresourceData As Byte() = frmMain.GetBIFFResourceData(Me.KotorVersionIndex, cmi.ResRef, 2032)
                    If biffresourceData IsNot Nothing Then
                        clsGFF = New clsGFF(biffresourceData, Me.KotorVersionIndex, True)
                    End If
                End If

                If clsGFF IsNot Nothing Then
                    Console.WriteLine(ObjectType.StrCatObj("Trigger type: ", clsGFF.GetNodeValue("Type")))
                    flag = ObjectType.ObjTst(clsGFF.GetNodeValue("Type"), 1, False) = 0

                    If Not flag Then
                        frmModuleItem_Base_Editor.DisableLinkedToFields()
                    End If
                End If

                If Me.GITfile.VerifyNodeExists(cmi.Path + ".LinkedToFlags") Then
                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".LinkedTo") Then
                        Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedTo, cmi.Path + ".LinkedTo")
                    End If

                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".LinkedToModule") Then
                        Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule")
                    End If

                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".TransitionDestin") Then
                        Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin", Me.g_clsDialogTlk)
                    End If

                    frmModuleItem_Base_Editor.cmbxDoorLinkedToFlags.SelectedIndex = IntegerType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".LinkedToFlags"))
                End If

                If cmi.Parent IsNot Nothing Then
                    frmModuleItem_Base_Editor.tbXPosition.Text = StringType.FromSingle(cmi.Parent.X)
                    frmModuleItem_Base_Editor.tbYPosition.Text = StringType.FromSingle(cmi.Parent.Y)
                    frmModuleItem_Base_Editor.tbZPosition.Text = StringType.FromObject(Me.GITfile.GetNodeValue(cmi.Parent.ZPosPath))
                End If

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")

            ElseIf itemType = 2044 Then
                frmModuleItem_Base_Editor.Bearing(2044) = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".Bearing"))
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")

            ElseIf itemType = 6 Then
                Dim gfftype As GFFType17 = CType(Me.GITfile.GetNodeValue(cmi.Path + ".Position"), GFFType17)
                frmModuleItem_Base_Editor.tbZPosition.Text = StringType.FromSingle(gfftype.f3)

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbCamFieldOfView, cmi.Path + ".FieldOfView")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbCamHeight, cmi.Path + ".Height")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbCamMicRange, cmi.Path + ".MicRange")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbCamPitch, cmi.Path + ".Pitch")

                Dim gfftype2 As GFFType16 = CType(Me.GITfile.GetNodeValue(cmi.Path + ".Orientation"), GFFType16)
                frmModuleItem_Base_Editor.CameraOrientationQuat = gfftype2

                If Me.GITfile.VerifyNodeExists(cmi.Path + ".EAOrientation") Then
                    frmModuleItem_Base_Editor.CameraOrientationEulerAngles = CType(Me.GITfile.GetNodeValue(cmi.Path + ".EAOrientation"), GFFType17)
                Else
                    frmModuleItem_Base_Editor.nudCamOrientationX.Value = 0D
                    frmModuleItem_Base_Editor.nudCamOrientationY.Value = 0D
                    frmModuleItem_Base_Editor.nudCamOrientationZ.Value = 0D
                    frmModuleItem_Base_Editor.ErrorProvider1.SetError(frmModuleItem_Base_Editor.nudCamOrientationX, "Unable to represent Quaternion as Euler angles; choose new values")
                End If

            ElseIf itemType = 2040 Then
                If cmi.Parent IsNot Nothing Then
                    frmModuleItem_Base_Editor.tbXPosition.Text = StringType.FromSingle(cmi.Parent.X)
                    frmModuleItem_Base_Editor.tbYPosition.Text = StringType.FromSingle(cmi.Parent.Y)
                    frmModuleItem_Base_Editor.tbZPosition.Text = StringType.FromObject(Me.GITfile.GetNodeValue(cmi.Parent.ZPosPath))
                End If

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")

                listItemCount = Me.GITfile.GetListItemCount(cmi.Path + ".SpawnPointList")

                Dim array As GFFType16() = New GFFType16(listItemCount - 1) {}
                Dim num As Integer = 0
                Dim num2 As Integer = listItemCount - 1

                For i As Integer = num To num2
                    array(i) = New GFFType16()
                    array(i).X = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(i) + ").X"))
                    array(i).Y = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(i) + ").Y"))
                    array(i).Z = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(i) + ").Z"))
                    array(i).W = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(i) + ").Orientation"))
                Next

                frmModuleItem_Base_Editor.SpawnPoints = array
            End If

            frmModuleItem_Base_Editor.SetupForItemType(cmi.ItemType)
            frmModuleItem_Base_Editor.ShowDialog(Me)

            If frmModuleItem_Base_Editor.DialogResult = DialogResult.OK Then
                Dim itemType2 As Integer = cmi.ItemType

                If itemType2 = 2040 OrElse itemType2 = 2032 Then
                    If cmi.Parent IsNot Nothing Then
                        Me.GITfile.SetNodeValue(cmi.Parent.XPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbXPosition.Text))
                        Me.GITfile.SetNodeValue(cmi.Parent.YPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbYPosition.Text))
                        Me.GITfile.SetNodeValue(cmi.Parent.ZPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbZPosition.Text))
                    Else
                        Me.GITfile.SetNodeValue(cmi.XPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbXPosition.Text))
                        Me.GITfile.SetNodeValue(cmi.YPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbYPosition.Text))
                        Me.GITfile.SetNodeValue(cmi.ZPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbZPosition.Text))
                    End If

                    Me.GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", Strings.Trim(frmModuleItem_Base_Editor.tbResRef.Text))

                    If StringType.StrCmp(frmModuleItem_Base_Editor.tbResRef.Text, resRef, False) <> 0 Then
                        Me.Draw()
                        Me.BuildModuleTreeView()
                    End If

                ElseIf itemType2 = 6 Then
                    Dim gfftype3 As GFFType17 = New GFFType17()
                    gfftype3.f1 = SingleType.FromString(frmModuleItem_Base_Editor.tbXPosition.Text)
                    gfftype3.f2 = SingleType.FromString(frmModuleItem_Base_Editor.tbYPosition.Text)
                    gfftype3.f3 = SingleType.FromString(frmModuleItem_Base_Editor.tbZPosition.Text)

                    Me.GITfile.SetNodeValue(cmi.Path + ".Position", gfftype3)

                    Dim gfftype4 As GFFType16 = frmModuleItem_Base_Editor.CameraOrientationQuat
                    Me.GITfile.SetNodeValue(cmi.Path + ".Orientation", gfftype4)

                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".EAOrientation") Then
                        Me.GITfile.SetNodeValue(cmi.Path + ".EAOrientation", frmModuleItem_Base_Editor.CameraOrientationEulerAngles)
                    Else
                        Me.GITfile.AddFieldToStruct(cmi.Path, "EAOrientation", 17, frmModuleItem_Base_Editor.CameraOrientationEulerAngles)
                    End If

                Else
                    Me.GITfile.SetNodeValue(cmi.XPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbXPosition.Text))
                    Me.GITfile.SetNodeValue(cmi.YPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbYPosition.Text))
                    Me.GITfile.SetNodeValue(cmi.ZPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbZPosition.Text))
                    Me.GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", Strings.Trim(frmModuleItem_Base_Editor.tbResRef.Text))

                    If StringType.StrCmp(frmModuleItem_Base_Editor.tbResRef.Text, resRef, False) <> 0 Then
                        Me.Draw()
                        Me.BuildModuleTreeView()
                    End If
                End If

                Dim itemType3 As Integer = cmi.ItemType

                If itemType3 = 2027 OrElse itemType3 = 2051 Then
                    Me.GITfile.SetNodeValue(cmi.Path + ".XOrientation", frmModuleItem_Base_Editor.XOrientation)
                    Me.GITfile.SetNodeValue(cmi.Path + ".YOrientation", frmModuleItem_Base_Editor.YOrientation)

                ElseIf itemType3 = 2042 OrElse itemType3 = 2040 OrElse itemType3 = 2032 Then
                    If cmi.ItemType = 2042 Then
                        Me.GITfile.SetNodeValue(cmi.Path + ".Bearing", frmModuleItem_Base_Editor.Bearing(2042))
                        Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")
                    End If

                    If flag Then
                        Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbDoorLinkedTo, cmi.Path + ".LinkedTo")
                        Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule")
                        Me.GITfile.SetCExoLocStringNodeValueFromTextBox(frmModuleItem_Base_Editor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin", 0)
                        Me.GITfile.SetNodeValue(cmi.Path + ".LinkedToFlags", frmModuleItem_Base_Editor.cmbxDoorLinkedToFlags.SelectedIndex)
                    End If

                    If cmi.ItemType = 2040 Then
                        Dim num3 As Integer = 0
                        Dim num4 As Integer = listItemCount - 1

                        For j As Integer = num3 To num4
                            Me.GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(j) + ").X", frmModuleItem_Base_Editor.SpawnPoints(j).X)
                            Me.GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(j) + ").Y", frmModuleItem_Base_Editor.SpawnPoints(j).Y)
                            Me.GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(j) + ").Z", frmModuleItem_Base_Editor.SpawnPoints(j).Z)
                            Me.GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(j) + ").Orientation", frmModuleItem_Base_Editor.SpawnPoints(j).W)
                        Next
                    End If

                ElseIf itemType3 = 2044 Then
                    Me.GITfile.SetNodeValue(cmi.Path + ".Bearing", frmModuleItem_Base_Editor.Bearing(2044))

                ElseIf itemType3 = 6 Then
                    Me.GITfile.SetNodeValue(cmi.Path + ".FieldOfView", SingleType.FromString(frmModuleItem_Base_Editor.tbCamFieldOfView.Text))
                    Me.GITfile.SetNodeValue(cmi.Path + ".Height", SingleType.FromString(frmModuleItem_Base_Editor.tbCamHeight.Text))
                    Me.GITfile.SetNodeValue(cmi.Path + ".MicRange", SingleType.FromString(frmModuleItem_Base_Editor.tbCamMicRange.Text))
                    Me.GITfile.SetNodeValue(cmi.Path + ".Pitch", SingleType.FromString(frmModuleItem_Base_Editor.tbCamPitch.Text))

                ElseIf itemType3 = 2058 Then
                    Me.GITfile.SetNodeValue(cmi.Path + ".XOrientation", frmModuleItem_Base_Editor.XOrientation)
                    Me.GITfile.SetNodeValue(cmi.Path + ".YOrientation", frmModuleItem_Base_Editor.YOrientation)
                    Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")
                    Me.GITfile.SetCExoLocStringNodeValueFromTextBox(frmModuleItem_Base_Editor.tbWpLocalizedName, cmi.Path + ".LocalizedName", frmModuleItem_Base_Editor.NameLang)
                    Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbWPLinkedTo, cmi.Path + ".LinkedTo")
                    Me.GITfile.SetCExoLocStringNodeValueFromTextBox(frmModuleItem_Base_Editor.tbWpDescription, cmi.Path + ".Description", frmModuleItem_Base_Editor.NameLang)

                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".MapNote") Then
                        Me.GITfile.SetCExoLocStringNodeValueFromTextBox(frmModuleItem_Base_Editor.tbWpMapNote, cmi.Path + ".MapNote", frmModuleItem_Base_Editor.NameLang)
                    End If

                    Me.GITfile.SetNodeValue(cmi.Path + ".HasMapNote", frmModuleItem_Base_Editor.chkbHasMapNote.Checked)
                    Me.GITfile.SetNodeValue(cmi.Path + ".MapNoteEnabled", frmModuleItem_Base_Editor.chkbMapNoteEnabled.Checked)
                End If
            End If
        End Sub

		' Token: 0x060008A8 RID: 2216 RVA: 0x00265B0C File Offset: 0x00264B0C
		Private Function GetTreeNodesModItem(node As ModItemTvNode) As ModItem
			Dim itemType As Integer = node.ItemType
			If itemType = 2027 Then
				Return Me.CreatureArr(node.ArrayIndex)
			End If
			If itemType = 2042 Then
				Return Me.DoorArr(node.ArrayIndex)
			End If
			If itemType = 2044 Then
				Return Me.PlaceableArr(node.ArrayIndex)
			End If
			If itemType = 2035 Then
				Return Me.SoundArr(node.ArrayIndex)
			End If
			If itemType = 2051 Then
				Return Me.MerchantArr(node.ArrayIndex)
			End If
			If itemType = 2058 Then
				Return Me.WaypointArr(node.ArrayIndex)
			End If
			If itemType = 2032 Then
				Return Me.TriggerArr(node.ArrayIndex)
			End If
			If itemType = 2040 Then
				Return Me.EncounterArr(node.ArrayIndex)
			End If
			If itemType = 6 Then
				Return Me.CameraArr(node.ArrayIndex)
			End If
			Dim modItem As ModItem
			Return modItem
		End Function

		' Token: 0x060008A9 RID: 2217 RVA: 0x00265BE4 File Offset: 0x00264BE4
		Private Function FileExistsInProject(FileName As String) As Boolean
			Return File.Exists(Me.g_ProjectPath + "\" + FileName)
		End Function

		' Token: 0x060008AA RID: 2218 RVA: 0x00265C08 File Offset: 0x00264C08
		Private Function FileExistsInUserPalette(FileName As String) As Boolean
			Return File.Exists(Me.g_UserPalettePath + "\" + FileName)
		End Function

		' Token: 0x060008AB RID: 2219 RVA: 0x00265C2C File Offset: 0x00264C2C
		Private Function FileExistsInGlobalTemplates(FileName As String) As Boolean
			Return File.Exists(Me.g_GlobalTemplatesPath + "\" + FileName)
		End Function

		' Token: 0x060008AC RID: 2220 RVA: 0x00265C50 File Offset: 0x00264C50
		Private Function FileExistsInTemplatesBif(FileName As String) As Boolean
			Return Me.htTemplateBifFiles.ContainsKey(FileName)
		End Function

' Token: 0x060008AD RID: 2221 RVA: 0x00265C6C File Offset: 0x00264C6C
        Private Sub EditItem(ByVal cmi As ModItem)
            If cmi Is Nothing Then
                Return
            End If

            If Not Me.FileExistsInProject(cmi.FileName) Then
                Dim existsInUserPalette As Boolean = Me.FileExistsInUserPalette(cmi.FileName)
                Dim existsInGlobalTemplates As Boolean = Me.FileExistsInGlobalTemplates(cmi.FileName)
                Dim existsInTemplatesBif As Boolean = Me.FileExistsInTemplatesBif(cmi.FileName)

                If Not existsInUserPalette AndAlso Not existsInGlobalTemplates AndAlso Not existsInTemplatesBif Then
                    Interaction.MsgBox("This item cannot be edited, as the file for it exists in neither the project, user palette, Global Templates directory, nor in the templates.bif file." & vbLf & "The file was most likely accidentally moved or deleted from the project.", MsgBoxStyle.Critical, "Item file missing")
                    Return
                End If

                Dim frmModuleEditor_MissingItemSelector As frmModuleEditor_MissingItemSelector = New frmModuleEditor_MissingItemSelector()
                frmModuleEditor_MissingItemSelector.UserPaletteAvailable = existsInUserPalette
                frmModuleEditor_MissingItemSelector.TemplatesBifAvailable = existsInTemplatesBif
                frmModuleEditor_MissingItemSelector.GlobalTemplatesAvailable = existsInGlobalTemplates

                If existsInUserPalette Xor existsInGlobalTemplates Xor existsInTemplatesBif Then
                    frmModuleEditor_MissingItemSelector.UserPaletteChecked = existsInUserPalette
                    frmModuleEditor_MissingItemSelector.TemplatesBifChecked = existsInTemplatesBif
                    frmModuleEditor_MissingItemSelector.GlobalTemplatesChecked = existsInGlobalTemplates
                End If

                If frmModuleEditor_MissingItemSelector.ShowDialog(Me) = DialogResult.Cancel Then
                    Return
                End If

                Dim frmPromptForString As frmPromptForString = New frmPromptForString("Create new instance", "Enter name for new instance (16 character max, no extension)", cmi.ResRef)
                frmPromptForString.tbValue.MaxLength = 16

                Dim validationMessage As String = ""

                Do
                    If frmPromptForString.ShowDialog(Me) = DialogResult.Cancel Then
                        Return
                    End If

                    Dim newFileName As String = frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension

                    If Me.FileExistsInProject(newFileName) Then
                        validationMessage = "A file with that name already exists. Please choose another."
                    ElseIf Me.FileExistsInUserPalette(newFileName) Then
                        validationMessage = "You cannot use the name of the template from the User Palette. Please choose another."
                    ElseIf Me.FileExistsInGlobalTemplates(newFileName) Then
                        validationMessage = "You cannot use the name of the template from the Global Templates. Please choose another."
                    ElseIf Me.FileExistsInTemplatesBif(newFileName) Then
                        validationMessage = "You cannot use the name of the template from Templates.bif. Please choose another."
                    Else
                        validationMessage = ""
                    End If

                    If StringType.StrCmp(validationMessage, "", False) <> 0 Then
                        Interaction.MsgBox(validationMessage, MsgBoxStyle.Exclamation, "Name error")
                    End If
                Loop While StringType.StrCmp(validationMessage, "", False) <> 0

                Dim newResRef As String = frmPromptForString.tbValue.Text.Trim()
                Dim destinationFile As String = Me.g_ProjectPath + "\" + newResRef + cmi.FileExtension

                If frmModuleEditor_MissingItemSelector.TemplatesBifChecked Then
                    Try
                        frmMain.ExportBiffResource(Me.KotorVersionIndex, cmi.ResRef, cmi.ItemType, destinationFile)
                    Catch ex As NotSupportedException
                        ' Preserve original decompiled behaviour: continue even if export reports NotSupportedException.
                    End Try
                ElseIf frmModuleEditor_MissingItemSelector.GlobalTemplatesChecked Then
                    File.Copy(Me.g_GlobalTemplatesPath + "\" + cmi.FileName, destinationFile)
                Else
                    File.Copy(Me.g_UserPalettePath + "\" + cmi.FileName, destinationFile)
                End If

                cmi.ResRef = newResRef
                Me.GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", cmi.ResRef)
                Me.Draw()
                Me.BuildModuleTreeView()
            End If

            Select Case cmi.ItemType
                Case 2025, 2027, 2032, 2035, 2042, 2044, 2051, 2058
                    Dim editorError As System.Exception = Nothing
                    Dim filePath As String = Me.g_ProjectPath + "\" + cmi.FileName
                    Dim fileStream As FileStream = Nothing

                    Try
                        fileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)

                        Select Case cmi.ItemType
                            Case 2025
                                Dim clsUTI As clsUTI = New clsUTI(fileStream, Me.KotorVersionIndex)
                                Dim frmUTI_Editor As frmUTI_Editor = New frmUTI_Editor(clsUTI, Me.KotorVersionIndex, True, filePath)
                                frmUTI_Editor.SetFormName(cmi.FileName)
                                frmUTI_Editor.Show()

                            Case 2027
                                Dim clsUTC As clsUTC = New clsUTC(fileStream, Me.KotorVersionIndex)
                                Dim frmUTC_Editor As frmUTC_Editor = New frmUTC_Editor(clsUTC, Me.KotorVersionIndex, True, filePath)
                                frmUTC_Editor.SetFormName(cmi.FileName)
                                frmUTC_Editor.Show()

                            Case 2032
                                Dim clsUTT As clsUTT = New clsUTT(fileStream, Me.KotorVersionIndex)
                                Dim frmUTT_Editor As frmUTT_Editor = New frmUTT_Editor(clsUTT, Me.KotorVersionIndex, True, filePath)
                                frmUTT_Editor.SetFormName(cmi.FileName)
                                frmUTT_Editor.Show()

                            Case 2035
                                Dim clsUTS As clsUTS = New clsUTS(fileStream, Me.KotorVersionIndex)
                                Dim frmUTS_Editor As frmUTS_Editor = New frmUTS_Editor(clsUTS, Me.KotorVersionIndex, True, filePath)
                                frmUTS_Editor.g_ProjectPath = Me.g_ProjectPath
                                frmUTS_Editor.SetFormName(cmi.FileName)
                                frmUTS_Editor.Show()

                            Case 2042
                                Dim clsUTD As clsUTD = New clsUTD(fileStream, Me.KotorVersionIndex)
                                Dim frmUTD_Editor As frmUTD_Editor = New frmUTD_Editor(clsUTD, Me.KotorVersionIndex, True, filePath)
                                frmUTD_Editor.SetFormName(cmi.FileName)
                                frmUTD_Editor.Show()

                            Case 2044
                                Dim clsUTP As clsUTP = New clsUTP(fileStream, Me.KotorVersionIndex)
                                Dim frmUTP_Editor As frmUTP_Editor = New frmUTP_Editor(clsUTP, Me.KotorVersionIndex, True, filePath)
                                frmUTP_Editor.SetFormName(cmi.FileName)
                                frmUTP_Editor.Show()

                            Case 2051
                                Dim clsUTM As clsUTM = New clsUTM(fileStream, Me.KotorVersionIndex)
                                Dim frmUTM_Editor As frmUTM_Editor = New frmUTM_Editor(clsUTM, Me.KotorVersionIndex, True, filePath)
                                frmUTM_Editor.SetFormName(cmi.FileName)
                                frmUTM_Editor.Show()

                            Case 2058
                                Dim clsUTW As clsUTW = New clsUTW(fileStream, Me.KotorVersionIndex)
                                Dim frmUTW_Editor As frmUTW_Editor = New frmUTW_Editor(clsUTW, Me.KotorVersionIndex, True, filePath)
                                frmUTW_Editor.SetFormName(cmi.FileName)
                                frmUTW_Editor.Show()
                        End Select

                    Catch ex As System.Exception
                        editorError = ex
                    End Try

                    If editorError IsNot Nothing Then
                        Interaction.MsgBox(editorError.Message, MsgBoxStyle.Critical, "Module Editing Error")
                    End If

                    Return
            End Select

            Interaction.MsgBox("No editor is available for that kind of item", MsgBoxStyle.Exclamation, Nothing)
        End Sub

		' Token: 0x060008AE RID: 2222 RVA: 0x0026646C File Offset: 0x0026546C
		Private Function NormalizeRectangle(selectionRect As Rectangle) As Rectangle
			Dim rectangle As Rectangle
			rectangle.Size = selectionRect.Size
			If selectionRect.Width < 0 Then
				rectangle.Width *= -1
				rectangle.X = selectionRect.X - rectangle.Width
			Else
				rectangle.X = selectionRect.X
			End If
			If selectionRect.Height < 0 Then
				rectangle.Height *= -1
				rectangle.Y = selectionRect.Y - rectangle.Height
			Else
				rectangle.Y = selectionRect.Y
			End If
			Return rectangle
		End Function

		' Token: 0x060008AF RID: 2223 RVA: 0x00266508 File Offset: 0x00265508
		Private Sub CreateTrap(TemplateResRef As String, Center As Point)
			Dim gff_Struct As GFF_Struct = New GFF_Struct(8, 1)
			Dim gfflist As GFFList = New GFFList(8)
			Dim listItemCount As Integer = Me.GITfile.GetListItemCount("TriggerList")
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", TemplateResRef)
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Center.X), Me.nudXoff.Value), Me.nudXmul.Value)))
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(Center.Y)), Me.nudYoff.Value), Me.nudYmul.Value)))
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
			gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "XOrientation", 0F)
			gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
			gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_float, "ZOrientation", 0F)
			gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_List, "Geometry", New GFFList(0))
			Me.GITfile.AddListElement("TriggerList", gff_Struct)
			Dim gff_Struct2 As GFF_Struct = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", -1.5F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 0F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", -1.06066F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", -1.06066F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 0F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", -1.5F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 1.06066F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", -1.06066F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 1.5F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 0F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 1.06066F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 1.06066F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 0F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 1.5F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", -1.06066F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 1.06066F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
		End Sub

		' Token: 0x060008B0 RID: 2224 RVA: 0x00266A84 File Offset: 0x00265A84
		Private Sub CreateTrigger(TemplateResRef As String, PointList As ArrayList)
			Dim gff_Struct As GFF_Struct = New GFF_Struct(8, 1)
			Dim gfflist As GFFList = New GFFList(PointList.Count - 1)
			Dim point As Point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim x As Integer = point.X
			point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim num As Integer = Me.invy(point.Y)
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", TemplateResRef)
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudYoff.Value), Me.nudYmul.Value)))
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
			gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "XOrientation", 0F)
			gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
			gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_float, "ZOrientation", 0F)
			gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_List, "Geometry", New GFFList(0))
			Me.GITfile.AddListElement("TriggerList", gff_Struct)
			Dim gff_Struct2 As GFF_Struct = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 0F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 0F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(Me.GITfile.GetListItemCount("TriggerList") - 1) + ").Geometry", gff_Struct2)
			Dim num2 As Integer = 1
			Dim num3 As Integer = PointList.Count - 1
			For i As Integer = num2 To num3
				gff_Struct2 = New GFF_Struct(3, 3)
				gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", SingleType.FromObject(ObjectType.DivObj(ObjectType.SubObj(LateBinding.LateGet(PointList(i), Nothing, "X", New Object(-1) {}, Nothing, Nothing), x), Me.nudXmul.Value)))
				gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", Convert.ToSingle(Decimal.Divide(New Decimal(Me.invy(IntegerType.FromObject(LateBinding.LateGet(PointList(i), Nothing, "Y", New Object(-1) {}, Nothing, Nothing))) - num), Me.nudYmul.Value)))
				gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
				Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(Me.GITfile.GetListItemCount("TriggerList") - 1) + ").Geometry", gff_Struct2)
			Next
		End Sub

		' Token: 0x060008B1 RID: 2225 RVA: 0x00266E08 File Offset: 0x00265E08
		Private Sub CreateEncounter(TemplateResRef As String, PointList As ArrayList)
			Dim gff_Struct As GFF_Struct = New GFF_Struct(6, 7)
			Dim gfflist As GFFList = New GFFList(PointList.Count - 1)
			Dim point As Point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim x As Integer = point.X
			point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim num As Integer = Me.invy(point.Y)
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", TemplateResRef)
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudYoff.Value), Me.nudYmul.Value)))
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
			gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_List, "Geometry", New GFFList(0))
			gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_List, "SpawnPointList", New GFFList(0))
			Me.GITfile.AddListElement("Encounter List", gff_Struct)
			Dim gff_Struct2 As GFF_Struct = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "X", 0F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "Y", 0F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "Z", 0F)
			Me.GITfile.AddListElement("Encounter List(" + StringType.FromInteger(Me.GITfile.GetListItemCount("Encounter List") - 1) + ").Geometry", gff_Struct2)
			Dim num2 As Integer = 1
			Dim num3 As Integer = PointList.Count - 1
			For i As Integer = num2 To num3
				gff_Struct2 = New GFF_Struct(3, 3)
				gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "X", SingleType.FromObject(ObjectType.DivObj(ObjectType.SubObj(LateBinding.LateGet(PointList(i), Nothing, "X", New Object(-1) {}, Nothing, Nothing), x), Me.nudXmul.Value)))
				gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(New Decimal(Me.invy(IntegerType.FromObject(LateBinding.LateGet(PointList(i), Nothing, "Y", New Object(-1) {}, Nothing, Nothing))) - num), Me.nudYmul.Value)))
				gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "Z", 0F)
				Me.GITfile.AddListElement("Encounter List(" + StringType.FromInteger(Me.GITfile.GetListItemCount("Encounter List") - 1) + ").Geometry", gff_Struct2)
			Next
		End Sub

		' Token: 0x060008B2 RID: 2226 RVA: 0x00267148 File Offset: 0x00266148
		Private Sub BuildModFile()
			Dim arrayList As ArrayList = New ArrayList()
			Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
			frmProgressMeter.maxvalue = 6
			frmProgressMeter.message = "Building Module"
			frmProgressMeter.status = "Add definition files"
			frmProgressMeter.stepAmount = 1
			frmProgressMeter.Location = New utilWindowRelativePositioner(Me, frmProgressMeter).getConcentric()
			frmProgressMeter.Show()
			Me.tbHelp.Text = "Starting module build"
			Me.miSave_Click(Nothing, Nothing)
			arrayList.Add(Me.g_ProjectPath + "\" + Me.g_MapName + ".git")
			arrayList.Add(Me.g_ProjectPath + "\" + Me.g_MapName + ".are")
			arrayList.Add(Me.g_ProjectPath + "\" + Me.g_MapName + ".pth")
			arrayList.Add(Me.g_ProjectPath + "\module.ifo")
			frmProgressMeter.stepUp()
			frmProgressMeter.status = "Add instance files"
			frmProgressMeter.stepUp()
			Dim num As Integer
			Dim num2 As Integer
			Me.BuildModuleFileList(Me.CreatureArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.ItemArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.DoorArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.MerchantArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.PlaceableArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.TriggerArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.SoundArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.WaypointArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.EncounterArr, arrayList, num, num2)
			Console.WriteLine("Template Refs: " + StringType.FromInteger(num) + "  Instances: " + StringType.FromInteger(num2))
			frmProgressMeter.status = "Add support files"
			frmProgressMeter.stepUp()
			Me.AddModuleFileNamesToList(Me.g_ProjectPath, arrayList, "*.ncs")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath, arrayList, "*.dlg")
			frmProgressMeter.status = "Add extras files"
			frmProgressMeter.stepUp()
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utc")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utd")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.uti")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utm")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utp")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utt")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.uts")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utw")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.ute")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.tga")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.mdl")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.mdx")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.pwk")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.lyt")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.2da")
			Dim array As String() = New String(arrayList.Count - 1 + 1 - 1) {}
			Dim num3 As Integer = 0
			Dim num4 As Integer = arrayList.Count - 1
			For i As Integer = num3 To num4
				array(i) = StringType.FromObject(arrayList(i))
			Next
			frmProgressMeter.status = "Create Mod file"
			frmProgressMeter.stepUp()
			Me.gModuleEditorSettings = ModuleEditorProjectSettings.GetSettings(Me.g_ProjectPath)
			If Not Me.gModuleEditorSettings.ModuleEditorModOutputPath.ToLower().EndsWith(".mod") Then
				Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", Me.gModuleEditorSettings.ModuleEditorModOutputPath, "", "Select the destination and name for your Mod file", "mod", False, True))
				If Not text.ToLower().EndsWith(".mod") Then
					Return
				End If
				Me.gModuleEditorSettings.ModuleEditorModOutputPath = text
				ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			End If
			Dim clsERF As clsERF = New clsERF(Me.gModuleEditorSettings.ModuleEditorModOutputPath, "MOD", Convert.ToUInt32(0), Nothing, array)
			Me.tbHelp.Text = "Module build complete"
			frmProgressMeter.Close()
		End Sub

		' Token: 0x060008B3 RID: 2227 RVA: 0x00267618 File Offset: 0x00266618
		Private Sub frmModule_Editor_Load(sender As Object, e As EventArgs)
			Dim settings As Options = UserSettings.GetSettings()
			Me.PositionWindow(Me.[GetType]().Name)
			Me.dModuleElementIndicatorSize = settings.ModuleEditorModuleElementIndicatorSize
			Me.bConfirmDeletes = settings.bModuleEditorConfirmDeletes
			Me.bShowLocatorRay = settings.bModuleEditorShowLocatorRay
			Me.tbHelp.Text = ""
		End Sub

		' Token: 0x060008B4 RID: 2228 RVA: 0x00267670 File Offset: 0x00266670
		Private Sub frmModule_Editor_Closing(sender As Object, e As CancelEventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.bModuleLoadedOK Then
				Me.SaveSettings(Me.[GetType]().Name)
				UserSettings.SaveSettings(Me.CurrentSettings)
				If StringType.StrCmp(Me.g_ProjectPath, "", False) <> 0 Then
					Me.gModuleEditorSettings.LastScrollPosX = 0 - Me.Panel1.AutoScrollPosition.X
					Me.gModuleEditorSettings.LastScrollPosY = 0 - Me.Panel1.AutoScrollPosition.Y
					ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
				End If
			End If
		End Sub

		' Token: 0x060008B5 RID: 2229 RVA: 0x0026770C File Offset: 0x0026670C
		Private Sub pbox_MouseDown(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left OrElse e.Button = MouseButtons.Right Then
				Dim obj As Object = CType(sender, PictureBox)
				Dim modItem As ModItem = Me.FindModItem(CType(sender, PictureBox))
				Dim obj2 As Object = obj
				Dim type As Type = Nothing
				Dim text As String = "PointToClient"
				Dim array As Object() = New Object(0) {}
				Dim array2 As Object() = array
				Dim num As Integer = 0
				Dim obj3 As Object = obj
				array2(num) = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj3, Nothing, "MousePosition", New Object(-1) {}, Nothing, Nothing))
				Dim array3 As Object() = array
				Dim array4 As Object() = array3
				Dim array5 As String() = Nothing
				Dim array6 As Boolean() = New Boolean() { True }
				Dim obj4 As Object = LateBinding.LateGet(obj2, type, text, array4, array5, array6)
				If array6(0) Then
					LateBinding.LateSetComplex(obj3, Nothing, "MousePosition", New Object() { RuntimeHelpers.GetObjectValue(array3(0)) }, Nothing, True, False)
				End If
				Dim point As Point = CType((If(obj4, Activator.CreateInstance(GetType(Point)))), Point)
				Dim num2 As Integer = point.X
				Dim num3 As Integer = point.Y
				Me.tbMouseX.Text = StringType.FromInteger(num2)
				Me.tbMouseY.Text = StringType.FromInteger(num3)
				Dim point2 As Point = New Point(num2, num3)
				Me.gLastMousePos = point2
				point2 = New Point(num2, num3)
				Me.g_LastMouseDownPos = point2
				If modItem IsNot Nothing Then
					Me.CurrentModItem = modItem
					Me.IndicatedModItem = modItem
					If e.Button = MouseButtons.Left Then
						If modItem.ItemType = 2032 Then
							If modItem.FileName.StartsWith("g_t_") Then
								Me.tbHelp.Text = "Move the mouse to reposition this trap. The trap is not redrawn while dragging. Right-click for the pop-up menu."
							Else
								Me.tbHelp.Text = "Move the mouse to reposition this node of the trigger. Hold down the shift key to move the whole trigger region. The trigger is not redrawn while dragging. Right-click for the pop-up menu."
							End If
						Else
							Me.tbHelp.Text = "Move the mouse to reposition this item. Right-click for the pop-up menu."
						End If
						Me.sbarpnlDesc.Text = modItem.ResRef
						Me.CurrentModItemBmp = New Bitmap(3, 3)
						Dim graphics As Graphics = Graphics.FromImage(Me.CurrentModItemBmp)
						Dim rectangle As Rectangle = New Rectangle(modItem.ScreenX - 1, modItem.ScreenY - 1, 3, 3)
						Dim rectangle2 As Rectangle = New Rectangle(0, 0, 3, 3)
						graphics.DrawImage(Me.bmp, rectangle2, rectangle, GraphicsUnit.Pixel)
					End If
					If e.Button = MouseButtons.Right AndAlso modItem.ItemType <> 5000 Then
						Me.cmMapSurfaceItems.MenuItems(Me.cmMapSurfaceItems.MenuItems.IndexOf(Me.cmiEditGFFFile)).Visible = modItem.ItemType <> 6 AndAlso modItem.ItemType <> 12040
						Me.cmMapSurfaceItems.MenuItems(Me.cmMapSurfaceItems.MenuItems.IndexOf(Me.cmiProperties)).Visible = modItem.ItemType <> 12040
						Me.cmMapSurfaceItems.MenuItems(Me.cmMapSurfaceItems.MenuItems.IndexOf(Me.cmiAddNewSpawnPoint)).Visible = modItem.ItemType = 2040
						Me.IndicatedModItem = Nothing
						Dim cmMapSurfaceItems As ContextMenu = Me.cmMapSurfaceItems
						Dim control As Control = CType(obj, Control)
						point2 = New Point(num2, num3)
						cmMapSurfaceItems.Show(control, point2)
						Me.LeftMouseClickActive = False
					Else
						Me.LeftMouseClickActive = True
					End If
				Else
					If Not Me.g_IsDrawingRegion AndAlso e.Button = MouseButtons.Right Then
						Dim cmPbox As ContextMenu = Me.cmPbox
						Dim control2 As Control = CType(obj, Control)
						point2 = New Point(num2, num3)
						cmPbox.Show(control2, point2)
						Me.LeftMouseClickActive = False
					End If
					Me.tbHelp.Text = "Left-click to select, right-click for pop-up menu, middle-click to pan"
				End If
				Me.LoadBackground()
				Me.Draw()
			ElseIf e.Button = MouseButtons.Middle Then
				Me.tbHelp.Text = "Press Shift key for 2x pan, Control for 10x pan"
				Dim point As Point = Me.Panel1.PointToClient(Control.MousePosition)
				Dim num2 As Integer = point.X
				Dim num3 As Integer = point.Y
				Dim point2 As Point = New Point(num2, num3)
				Me.gLastMousePos = point2
			End If
		End Sub

		' Token: 0x060008B6 RID: 2230 RVA: 0x00267AD4 File Offset: 0x00266AD4
		Private Sub pbox_MouseMove(sender As Object, e As MouseEventArgs)
			Dim pictureBox As PictureBox = CType(sender, PictureBox)
			Dim num As Integer = pictureBox.PointToClient(Control.MousePosition).X
			Dim point As Point = pictureBox.PointToClient(Control.MousePosition)
			Dim num2 As Integer = point.Y
			Me.sbarpnlLocX.Text = "X: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudXoff.Value), Me.nudXmul.Value)))
			Me.sbarpnlLocY.Text = "Y: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(num2)), Me.nudYoff.Value), Me.nudYmul.Value)))
			If e.Button = MouseButtons.None Then
				If Me.g_IsDrawingRegion Then
					Me.tbHelp.Text = "Left click to set next point or Right click to auto-close region"
					Dim graphics As Graphics
					Dim rectangle As Rectangle
					Dim rectangle2 As Rectangle
					Dim rectangle3 As Rectangle
					If Me.backbuffer IsNot Nothing Then
						graphics = Graphics.FromImage(Me.bmp)
						rectangle = New Rectangle(0, 0, Me.backbuffer.Width, Me.backbuffer.Height)
						rectangle2 = rectangle
						rectangle = New Rectangle(Me.gLastBackBufferOrigin.X, Me.gLastBackBufferOrigin.Y, Me.backbuffer.Width, Me.backbuffer.Height)
						rectangle3 = rectangle
						rectangle3 = Me.NormalizeRectangle(rectangle3)
						graphics.DrawImage(Me.backbuffer, rectangle3, rectangle2, GraphicsUnit.Pixel)
					End If
					If Me.g_RegionPointList.Count > 1 Then
						Me.DrawRegionPoints(Graphics.FromImage(Me.bmp), Me.g_RegionPointList, Me.gCurrentRegionDrawingColor, False)
					End If
					rectangle = New Rectangle(Me.gCurrentRegionSegmentOrigin.X, Me.gCurrentRegionSegmentOrigin.Y, num - Me.gCurrentRegionSegmentOrigin.X, num2 - Me.gCurrentRegionSegmentOrigin.Y)
					rectangle2 = rectangle
					rectangle2 = Me.NormalizeRectangle(rectangle2)
					rectangle2.Width += 1
					rectangle2.Height += 1
					Me.backbuffer = New Bitmap(rectangle2.Width, rectangle2.Height)
					graphics = Graphics.FromImage(Me.backbuffer)
					rectangle = New Rectangle(0, 0, rectangle2.Width, rectangle2.Height)
					rectangle3 = rectangle
					graphics.DrawImage(Me.bmp, rectangle3, rectangle2, GraphicsUnit.Pixel)
					graphics = Graphics.FromImage(Me.bmp)
					graphics.DrawLine(New Pen(Me.gCurrentRegionDrawingColor, 1F), Me.gCurrentRegionSegmentOrigin.X, Me.gCurrentRegionSegmentOrigin.Y, num, num2)
					Dim graphics2 As Graphics = graphics
					Dim pen As Pen = New Pen(Me.gCurrentRegionDrawingColor, 1F)
					rectangle = New Rectangle(Me.gCurrentRegionSegmentOrigin.X - 1, Me.gCurrentRegionSegmentOrigin.Y - 1, 2, 2)
					graphics2.DrawRectangle(pen, rectangle)
					Me.pbox.Refresh()
					Me.gLastBackBufferOrigin = rectangle2.Location
					point = New Point(num, num2)
					Me.gLastMousePos = point
				End If
			ElseIf e.Button = MouseButtons.Left Then
				If(Me.CurrentModItem IsNot Nothing) And Me.LeftMouseClickActive Then
					Dim num3 As Long = DateAndTime.Now.Ticks
					Cursor.Current = Cursors.Cross
					Dim rectangle As Rectangle
					Dim graphics3 As Graphics
					Dim rectangle4 As Rectangle
					Dim rectangle5 As Rectangle
					If Me.backbuffer IsNot Nothing Then
						graphics3 = Graphics.FromImage(Me.bmp)
						rectangle = New Rectangle(0, 0, 3, 3)
						rectangle4 = rectangle
						rectangle = New Rectangle(Me.gLastMousePos.X - 1, Me.gLastMousePos.Y - 1, 3, 3)
						rectangle5 = rectangle
						graphics3.DrawImage(Me.backbuffer, rectangle5, rectangle4, GraphicsUnit.Pixel)
					End If
					Dim timeSpan As TimeSpan = New TimeSpan(DateAndTime.Now.Ticks - num3)
					Dim timeSpan2 As TimeSpan = timeSpan
					num3 = DateAndTime.Now.Ticks
					Console.WriteLine("Move Drawing Time 1: " + StringType.FromInteger(timeSpan2.Milliseconds))
					point = New Point(num, num2)
					Me.gLastMousePos = point
					Me.backbuffer = New Bitmap(3, 3)
					graphics3 = Graphics.FromImage(Me.backbuffer)
					rectangle = New Rectangle(num - 1, num2 - 1, 3, 3)
					rectangle4 = rectangle
					rectangle = New Rectangle(0, 0, 3, 3)
					rectangle5 = rectangle
					num3 = DateAndTime.Now.Ticks
					graphics3.DrawImage(Me.bmp, rectangle5, rectangle4, GraphicsUnit.Pixel)
					timeSpan = New TimeSpan(DateAndTime.Now.Ticks - num3)
					timeSpan2 = timeSpan
					Console.WriteLine("Move Drawing Time 2e: " + StringType.FromInteger(timeSpan2.Milliseconds))
					num3 = DateAndTime.Now.Ticks
					graphics3 = Graphics.FromImage(Me.bmp)
					rectangle = New Rectangle(0, 0, 3, 3)
					rectangle4 = rectangle
					rectangle = New Rectangle(num - 1, num2 - 1, 3, 3)
					rectangle5 = rectangle
					graphics3.DrawImage(Me.CurrentModItemBmp, rectangle5, rectangle4, GraphicsUnit.Pixel)
					timeSpan = New TimeSpan(DateAndTime.Now.Ticks - num3)
					timeSpan2 = timeSpan
					Console.WriteLine(String.Concat(New String() { "Move Drawing Time 3: ", StringType.FromInteger(timeSpan2.Milliseconds), " T: ", StringType.FromLong(num3), " x: ", StringType.FromInteger(num), " Y: ", StringType.FromInteger(num2) }))
					Me.pbox.Refresh()
				End If
			ElseIf e.Button = MouseButtons.Middle Then
				Dim panel As Panel = Me.Panel1
				num = panel.PointToClient(Control.MousePosition).X
				num2 = panel.PointToClient(Control.MousePosition).Y
				Dim num4 As Integer = num - Me.gLastMousePos.X
				Dim num5 As Integer = num2 - Me.gLastMousePos.Y
				If Control.ModifierKeys = Keys.Shift Then
					num4 *= 2
					num5 *= 2
				End If
				If Control.ModifierKeys = Keys.Control Then
					num4 *= 10
					num5 *= 10
				End If
				Dim autoScrollPosition2 As Point
				If num4 <> 0 OrElse num5 <> 0 Then
					Dim autoScrollPosition As Point = Me.Panel1.AutoScrollPosition
					Dim num6 As Integer = 0
					Dim num7 As Integer = 0
					point = Me.Panel1.AutoScrollPosition
					autoScrollPosition2 = New Point(num6 - (num7 - point.X - num4), 0 - (0 - Me.Panel1.AutoScrollPosition.Y - num5))
					If autoScrollPosition <> autoScrollPosition2 Then
						Dim panel2 As ScrollableControl = Me.Panel1
						Dim num8 As Integer = 0
						autoScrollPosition2 = Me.Panel1.AutoScrollPosition
						point = New Point(num8 - autoScrollPosition2.X - num4, 0 - Me.Panel1.AutoScrollPosition.Y - num5)
						panel2.AutoScrollPosition = point
					End If
				End If
				autoScrollPosition2 = New Point(num, num2)
				Me.gLastMousePos = autoScrollPosition2
			End If
		End Sub

		' Token: 0x060008B7 RID: 2231 RVA: 0x002681A4 File Offset: 0x002671A4
		Private Sub pbox_MouseUp(sender As Object, e As MouseEventArgs)
			If(Me.CurrentModItem IsNot Nothing) And Not Me.gLastMousePos.IsEmpty Then
				If e.Button = MouseButtons.Left Then
					Dim num As Integer = Me.pbox.PointToClient(Control.MousePosition).X
					Dim num2 As Integer = Me.pbox.PointToClient(Control.MousePosition).Y
					If num = Me.g_LastMouseDownPos.X AndAlso num2 = Me.g_LastMouseDownPos.Y Then
						Return
					End If
					If Me.CurrentModItem.ItemType <> 2032 AndAlso Me.CurrentModItem.ItemType <> 2040 AndAlso Me.CurrentModItem.ItemType <> 6 AndAlso Me.CurrentModItem.ItemType <> 5000 Then
						Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.XPosAccessor, Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudXoff.Value), Me.nudXmul.Value)))
						Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.YPosAccessor, Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(num2)), Me.nudYoff.Value), Me.nudYmul.Value)))
					ElseIf Me.CurrentModItem.ItemType = 2032 OrElse Me.CurrentModItem.ItemType = 2040 Then
						' The following expression was wrapped in a checked-statement
						num -= Me.CurrentModItem.ScreenX
						num2 = Me.invy(num2) - Me.CurrentModItem.ScreenY
						If(Control.ModifierKeys And Keys.Shift) > Keys.None OrElse Me.CurrentModItem.FileName.StartsWith("g_t_") Then
							Dim num3 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.CurrentModItem.Path + ".XPosition"))
							Dim num4 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.CurrentModItem.Path + ".YPosition"))
							If(Not Control.ModifierKeys And Keys.Alt) > Keys.None Then
								' The following expression was wrapped in a checked-expression
								Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + ".XPosition", num3 + Convert.ToSingle(Decimal.Divide(New Decimal(Me.pbox.PointToClient(Control.MousePosition).X - Me.g_LastMouseDownPos.X), Me.nudXmul.Value)))
							End If
							If(Not Control.ModifierKeys And Keys.Control) > Keys.None Then
								' The following expression was wrapped in a checked-expression
								Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + ".YPosition", num4 - Convert.ToSingle(Decimal.Divide(New Decimal(Me.pbox.PointToClient(Control.MousePosition).Y - Me.g_LastMouseDownPos.Y), Me.nudYmul.Value)))
							End If
						Else
							Me.tbHelp.Text = ""
							Dim num3 As Single = Convert.ToSingle(Decimal.Divide(New Decimal(num), Me.nudXmul.Value))
							Dim num4 As Single = Convert.ToSingle(Decimal.Divide(New Decimal(num2), Me.nudYmul.Value))
							Dim num5 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.XPosAccessor))
							Dim num6 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.YPosAccessor))
							Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.XPosAccessor, num3)
							Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.YPosAccessor, num4)
						End If
					ElseIf Me.CurrentModItem.ItemType = 6 Then
						Dim gfftype As GFFType17 = New GFFType17()
						gfftype.f1 = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudXoff.Value), Me.nudXmul.Value))
						gfftype.f2 = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(num2)), Me.nudYoff.Value), Me.nudYmul.Value))
						Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + ".Position", gfftype)
					ElseIf Me.CurrentModItem.ItemType = 5000 Then
						Me.IFOfile.SetNodeValue("Mod_Entry_X", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudXoff.Value), Me.nudXmul.Value)))
						Me.IFOfile.SetNodeValue("Mod_Entry_Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(num2)), Me.nudYoff.Value), Me.nudYmul.Value)))
					End If
					Me.LoadBackground()
					Me.Draw()
					Me.CurrentModItem = Nothing
					Me.CurrentModItemBmp = Nothing
					Me.backbuffer = Nothing
					Cursor.Current = Cursors.[Default]
					Me.LeftMouseClickActive = False
					Me.gLastMousePos = CType((If(Nothing, Activator.CreateInstance(GetType(Point)))), Point)
				End If
			Else
				If Me.g_IsDrawingRegion Then
					If e.Button = MouseButtons.Left Then
						Dim x As Integer = Me.pbox.PointToClient(Control.MousePosition).X
						Dim point As Point = Me.pbox.PointToClient(Control.MousePosition)
						Dim y As Integer = point.Y
						point = New Point(x, y)
						Me.gLastMousePos = point
						Me.gCurrentRegionSegmentOrigin = Me.gLastMousePos
						If Me.Near(x, y, RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Me.g_RegionPointList(0), Nothing, "X", New Object(-1) {}, Nothing, Nothing)), RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Me.g_RegionPointList(0), Nothing, "Y", New Object(-1) {}, Nothing, Nothing))) Then
							Me.g_IsDrawingRegion = False
							If Me.gCurrentModItemType = 2032 Then
								Me.CreateTrigger(Me.g_RegionResRef, Me.g_RegionPointList)
							ElseIf Me.gCurrentModItemType = 2040 Then
								Me.CreateEncounter(Me.g_RegionResRef, Me.g_RegionPointList)
							End If
							Me.LoadBackground()
							Me.Draw()
							Me.BuildModuleTreeView()
						Else
							Dim arrayList As ArrayList = Me.g_RegionPointList
							point = New Point(x, y)
							arrayList.Add(point)
						End If
					ElseIf e.Button = MouseButtons.Right Then
						Me.tbHelp.Text = ""
						Me.g_IsDrawingRegion = False
						If Me.gCurrentModItemType = 2032 Then
							Me.CreateTrigger(Me.g_RegionResRef, Me.g_RegionPointList)
						ElseIf Me.gCurrentModItemType = 2040 Then
							Me.CreateEncounter(Me.g_RegionResRef, Me.g_RegionPointList)
						End If
						Me.gCurrentModItemType = -1
						Me.LoadBackground()
						Me.Draw()
						Me.BuildModuleTreeView()
					End If
				End If
				Me.tbHelp.Text = ""
				Me.sbarpnlDesc.Text = ""
				Me.sbarpnlAddlInfo.Text = ""
			End If
		End Sub

		' Token: 0x060008B8 RID: 2232 RVA: 0x002689A4 File Offset: 0x002679A4
		Private Sub pbox_MouseLeave(sender As Object, e As EventArgs)
			Me.sbarpnlLocX.Text = ""
			Me.sbarpnlLocY.Text = ""
		End Sub

		' Token: 0x060008B9 RID: 2233 RVA: 0x002689C8 File Offset: 0x002679C8
		Private Sub nudMulOff_ValueChanged(sender As Object, e As EventArgs)
			If Me.CanFocus And Me.chkbUseFactors.Checked Then
				Me.LoadBackground()
				Me.Draw()
			End If
		End Sub

		' Token: 0x060008BA RID: 2234 RVA: 0x002689EC File Offset: 0x002679EC
		Private Sub tvPalette_ItemDrag(sender As Object, e As ItemDragEventArgs)
			Dim treeNode As TreeNode = CType(e.Item, TreeNode)
			Dim text As String = treeNode.Text
			If treeNode.Tag IsNot Nothing AndAlso ObjectType.ObjTst(treeNode.Tag, "", False) <> 0 Then
				Me.DoDragDrop(RuntimeHelpers.GetObjectValue(treeNode.Tag), DragDropEffects.Copy Or DragDropEffects.Move)
			End If
		End Sub

		' Token: 0x060008BB RID: 2235 RVA: 0x00268A3C File Offset: 0x00267A3C
		Private Sub tvUserPalette_ItemDrag(sender As Object, e As ItemDragEventArgs)
			Dim treeNode As TreeNode = CType(e.Item, TreeNode)
			Dim text As String = treeNode.Text
			If treeNode.Tag IsNot Nothing AndAlso ObjectType.ObjTst(treeNode.Tag, "", False) <> 0 Then
				Me.DoDragDrop(RuntimeHelpers.GetObjectValue(treeNode.Tag), DragDropEffects.Copy Or DragDropEffects.Move)
			End If
		End Sub

		' Token: 0x060008BC RID: 2236 RVA: 0x00268A8C File Offset: 0x00267A8C
		Private Sub tvModule_MouseDown(sender As Object, e As MouseEventArgs)
			Dim point As Point = New Point(e.X, e.Y)
			Dim point2 As Point = point
			Me.LastClickedTvModuleNode = CType(Me.tvModule.GetNodeAt(point2), ModItemTvNode)
		End Sub

		' Token: 0x060008BD RID: 2237 RVA: 0x00268AC8 File Offset: 0x00267AC8
		Private Sub tvModule_MouseUp(sender As Object, e As MouseEventArgs)
			Dim point As Point = New Point(e.X, e.Y)
			Dim point2 As Point = point
			Dim lastClickedTvModuleNode As ModItemTvNode = Me.LastClickedTvModuleNode
			If lastClickedTvModuleNode IsNot Nothing Then
				Me.CurrentContextMenuTvModuleNode = lastClickedTvModuleNode
			End If
			If e.Button = MouseButtons.Right Then
				If lastClickedTvModuleNode IsNot Nothing Then
					Dim tag As Object = lastClickedTvModuleNode.Tag
					If ObjectType.ObjTst(tag, "ItemParent", False) <> 0 AndAlso ObjectType.ObjTst(tag, "Item", False) = 0 Then
						Me.tvModuleContextMenuItem.MenuItems(Me.tvModuleContextMenuItem.MenuItems.IndexOf(Me.cmiTvModuleItemEdit)).Visible = lastClickedTvModuleNode.ItemType <> 6
						Me.tvModuleContextMenuItem.Show(Me.tvModule, point2)
					End If
					Me.tvModule.SelectedNode = Me.CurrentContextMenuTvModuleNode
				End If
			ElseIf e.Button = MouseButtons.Left Then
				Me.tbHelp.Text = "Click an item to see it's location in the module, or right-click it to access the pop-up menu."
				If lastClickedTvModuleNode IsNot Nothing Then
					If e.X < lastClickedTvModuleNode.Bounds.Left Then
						Return
					End If
					Me.LeftMouseClickActive = False
					Dim tag2 As Object = lastClickedTvModuleNode.Tag
					If ObjectType.ObjTst(tag2, "Item", False) = 0 Then
						Me.IndicatedModItem = Me.GetTreeNodesModItem(lastClickedTvModuleNode)
						Me.LoadBackground()
						Me.Draw()
					End If
				End If
			End If
		End Sub

		' Token: 0x060008BE RID: 2238 RVA: 0x00268C04 File Offset: 0x00267C04
		Private Sub tvModule_KeyUp(sender As Object, e As KeyEventArgs)
			If Me.tvModule.SelectedNode Is Nothing Then
				Return
			End If
			Dim tag As Object = Me.tvModule.SelectedNode.Tag
			If ObjectType.ObjTst(tag, "Item", False) = 0 Then
				Me.IndicatedModItem = Me.GetTreeNodesModItem(CType(Me.tvModule.SelectedNode, ModItemTvNode))
				Me.LoadBackground()
				Me.Draw()
			End If
		End Sub

		' Token: 0x060008BF RID: 2239 RVA: 0x00268C68 File Offset: 0x00267C68
		Private Sub tvModule_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs)
			Dim modItemTvNode As ModItemTvNode = CType(e.Node, ModItemTvNode)
			If Not Me.g_tvModule_TreeOpenPaths.Contains(modItemTvNode.FullPath) Then
				Me.g_tvModule_TreeOpenPaths.Add(modItemTvNode.FullPath)
			End If
			Me.AddNodeChildrenToTreePaths(modItemTvNode, Me.g_tvModule_TreeOpenPaths)
		End Sub

		' Token: 0x060008C0 RID: 2240 RVA: 0x00268CB4 File Offset: 0x00267CB4
		Private Sub tvModule_BeforeCollapse(sender As Object, e As TreeViewCancelEventArgs)
			Dim modItemTvNode As ModItemTvNode = CType(e.Node, ModItemTvNode)
			For i As Integer = Me.g_tvModule_TreeOpenPaths.Count - 1 To 0 Step -1
				If BooleanType.FromObject(If((BooleanType.FromObject(LateBinding.LateGet(Me.g_tvModule_TreeOpenPaths(i), Nothing, "StartsWith", New Object() { modItemTvNode.FullPath + "\" }, Nothing, Nothing)) OrElse BooleanType.FromObject(ObjectType.ObjTst(Me.g_tvModule_TreeOpenPaths(i), modItemTvNode.FullPath, False) = 0)), True, False)) Then
					Me.g_tvModule_TreeOpenPaths.RemoveAt(i)
				End If
			Next
		End Sub

		' Token: 0x060008C1 RID: 2241 RVA: 0x00268D70 File Offset: 0x00267D70
		Private Sub cmiProperties_Click(sender As Object, e As EventArgs)
			Me.EditItemProperties(Me.CurrentModItem)
			Me.CurrentModItem = Nothing
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008C2 RID: 2242 RVA: 0x00268D94 File Offset: 0x00267D94
		Private Sub cmiEdit_Click(sender As Object, e As EventArgs)
			Me.EditItem(Me.CurrentModItem)
			Me.CurrentModItem = Nothing
		End Sub

		' Token: 0x060008C3 RID: 2243 RVA: 0x00268DAC File Offset: 0x00267DAC
		Private Sub cmiDelete_Click(sender As Object, e As EventArgs)
			If Not Me.bConfirmDeletes OrElse Interaction.MsgBox("Are you sure you want to delete this?", MsgBoxStyle.OkCancel, "Delete Item") = MsgBoxResult.Ok Then
				Me.DeleteModuleItem(Me.CurrentModItem)
				Me.CurrentModItem = Nothing
			End If
		End Sub

		' Token: 0x060008C4 RID: 2244 RVA: 0x00268DDC File Offset: 0x00267DDC
		Private Sub cmiAddNewSpawnPoint_Click(sender As Object, e As EventArgs)
			Dim currentModItem As ModItem = Me.CurrentModItem
			If Not Me.GITfile.VerifyNodeExists(currentModItem.Path + ".SpawnPointList") Then
				Me.GITfile.CreateList(currentModItem.Path, "SpawnPointList")
			End If
			Dim listItemCount As Integer = Me.GITfile.GetListItemCount(currentModItem.Path + ".SpawnPointList")
			Dim gff_Struct As GFF_Struct = New GFF_Struct(4, 2)
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_float, "X", currentModItem.Parent.X + 2F + CSng(listItemCount))
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "Y", currentModItem.Parent.Y + 2F)
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "Z", 0.0)
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "Orientation", 0.0)
			Me.GITfile.AddListElement(currentModItem.Path + ".SpawnPointList", gff_Struct)
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008C5 RID: 2245 RVA: 0x00268F0C File Offset: 0x00267F0C
		Private Sub cmiTvModuleItemProperties_Click(sender As Object, e As EventArgs)
			Dim currentContextMenuTvModuleNode As ModItemTvNode = Me.CurrentContextMenuTvModuleNode
			Dim pen As Pen = New Pen(Color.Orange, 1F)
			pen.EndCap = LineCap.ArrowAnchor
			Dim treeNodesModItem As ModItem = Me.GetTreeNodesModItem(currentContextMenuTvModuleNode)
			Dim panel As ScrollableControl = Me.Panel1
			Dim point As Point = New Point(CInt(Math.Round(CDbl(treeNodesModItem.ScreenX) - CDbl(Me.Panel1.Size.Width) / 2.0)), CInt(Math.Round(CDbl(treeNodesModItem.ScreenY) - CDbl(Me.Panel1.Size.Height) / 2.0)))
			panel.AutoScrollPosition = point
			If Me.bShowLocatorRay Then
				Graphics.FromImage(Me.pbox.Image).DrawLine(pen, 0, 0, treeNodesModItem.ScreenX - 3, treeNodesModItem.ScreenY - 3)
			End If
			Me.pbox.Update()
			Me.EditItemProperties(treeNodesModItem)
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008C6 RID: 2246 RVA: 0x00268FFC File Offset: 0x00267FFC
		Private Sub cmiTvModuleItemEdit_Click(sender As Object, e As EventArgs)
			Dim currentContextMenuTvModuleNode As ModItemTvNode = Me.CurrentContextMenuTvModuleNode
			Dim pen As Pen = New Pen(Color.Orange, 1F)
			pen.EndCap = LineCap.ArrowAnchor
			Dim treeNodesModItem As ModItem = Me.GetTreeNodesModItem(currentContextMenuTvModuleNode)
			Dim panel As ScrollableControl = Me.Panel1
			Dim point As Point = New Point(CInt(Math.Round(CDbl(treeNodesModItem.ScreenX) - CDbl(Me.Panel1.Size.Width) / 2.0)), CInt(Math.Round(CDbl(treeNodesModItem.ScreenY) - CDbl(Me.Panel1.Size.Height) / 2.0)))
			panel.AutoScrollPosition = point
			If Me.bShowLocatorRay Then
				Graphics.FromImage(Me.pbox.Image).DrawLine(pen, 0, 0, treeNodesModItem.ScreenX - 3, treeNodesModItem.ScreenY - 3)
			End If
			Me.pbox.Update()
			Me.EditItem(treeNodesModItem)
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008C7 RID: 2247 RVA: 0x002690EC File Offset: 0x002680EC
		Private Sub cmiTvModuleItemDelete_Click(sender As Object, e As EventArgs)
			If Not Me.bConfirmDeletes OrElse Interaction.MsgBox("Are you sure you want to delete this?", MsgBoxStyle.OkCancel, "Delete Item") = MsgBoxResult.Ok Then
				Dim currentContextMenuTvModuleNode As ModItemTvNode = Me.CurrentContextMenuTvModuleNode
				Dim fullPath As String = currentContextMenuTvModuleNode.Parent.FullPath
				Dim treeNodesModItem As ModItem = Me.GetTreeNodesModItem(currentContextMenuTvModuleNode)
				Me.DeleteModuleItem(treeNodesModItem)
				Me.CurrentModItem = Nothing
				frmMain.OpenTreeViewToPath(fullPath, Me.tvModule.Nodes(0), 0, True)
			End If
		End Sub

		' Token: 0x060008C8 RID: 2248 RVA: 0x00269158 File Offset: 0x00268158
		Private Sub cmiCreateCameraHere_Click(sender As Object, e As EventArgs)
			Dim num As Single = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.g_LastMouseDownPos.X), Me.nudXoff.Value), Me.nudXmul.Value))
			Dim num2 As Single = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(Me.g_LastMouseDownPos.Y)), Me.nudYoff.Value), Me.nudYmul.Value))
			If Not Me.GITfile.VerifyNodeExists("CameraList") Then
				Me.GITfile.CreateList("", "CameraList")
			End If
			Dim listItemCount As Integer = Me.GITfile.GetListItemCount("CameraList")
			Dim num3 As Integer = -1
			If listItemCount = 0 Then
				num3 = 1
			Else
				Dim num4 As Integer = 0
				Dim num5 As Integer = listItemCount - 1
				For i As Integer = num4 To num5
					Dim num6 As Integer = IntegerType.FromObject(Me.GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(i) + ").CameraID"))
					If num6 > num3 Then
						num3 = num6
					End If
				Next
				num3 += 1
			End If
			Dim gff_Struct As GFF_Struct = New GFF_Struct()
			gff_Struct.type = 14
			gff_Struct.fieldCount = 8
			gff_Struct.fields = New GFF_Field(7) {}
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_int, "CameraID", num3)
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_Type17, "Position", New GFFType17(num, num2, 0F))
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "Pitch", 0)
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "MicRange", 0)
			gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_Type16, "Orientation", New GFFType16(1F, 0F, 0F, 0F))
			gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_float, "Height", 2)
			gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_float, "FieldOfView", 55)
			gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_Type17, "EAOrientation", New GFFType17(0F, 0F, 0F))
			Me.GITfile.AddListElement("CameraList", gff_Struct)
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008C9 RID: 2249 RVA: 0x0026939C File Offset: 0x0026839C
		Private Sub cmiSetModuleStartPoint_Click(sender As Object, e As EventArgs)
			Dim num As Single = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.g_LastMouseDownPos.X), Me.nudXoff.Value), Me.nudXmul.Value))
			Dim num2 As Single = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(Me.g_LastMouseDownPos.Y)), Me.nudYoff.Value), Me.nudYmul.Value))
			Me.IFOfile.SetNodeValue("Mod_Entry_X", num)
			Me.IFOfile.SetNodeValue("Mod_Entry_Y", num2)
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008CA RID: 2250 RVA: 0x00269454 File Offset: 0x00268454
		Private Sub cmiModuleProperties_Click(sender As Object, e As EventArgs)
			Me.miModuleProperties_Click(Nothing, Nothing)
		End Sub

		' Token: 0x060008CB RID: 2251 RVA: 0x00269460 File Offset: 0x00268460
		Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
			If CType(sender, TabControl).SelectedTab Is Me.tabpagUserPalette Then
				Me.tbHelp.Text = "Place files in your project's UserPalette folder to make them available here."
			Else
				Me.tbHelp.Text = "Click an item type button on the palette above to see the available standard items you can place in the module."
			End If
		End Sub

		' Token: 0x060008CC RID: 2252 RVA: 0x00269498 File Offset: 0x00268498
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008CD RID: 2253 RVA: 0x0026949C File Offset: 0x0026849C
		Private Sub btnTest_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008CE RID: 2254 RVA: 0x002694A0 File Offset: 0x002684A0
		Private Sub btnClean_Click(sender As Object, e As EventArgs)
			Me.GITfile.ClearListElements("Creature List")
			Me.GITfile.ClearListElements("Placeable List")
			Me.GITfile.ClearListElements("Door List")
			Me.GITfile.ClearListElements("SoundList")
			Me.GITfile.ClearListElements("WaypointList")
			Me.GITfile.ClearListElements("TriggerList")
			Dim num As Integer = 8
			Do
				Me.GITfile.DeleteListElement("CameraList", num)
				num += -1
			Loop While num >= 1
		End Sub

		' Token: 0x060008CF RID: 2255 RVA: 0x00269528 File Offset: 0x00268528
		Private Sub btnPalCreature_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2027
			Me.BuildPaletteTreeView("creaturepalstd")
			Me.tbHelp.Text = "Drag the desired creature onto the map"
		End Sub

		' Token: 0x060008D0 RID: 2256 RVA: 0x00269550 File Offset: 0x00268550
		Private Sub btnPalDoor_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2042
			Me.BuildPaletteTreeView("doorpalstd")
			Me.tbHelp.Text = "Drag the desired door onto the map"
		End Sub

		' Token: 0x060008D1 RID: 2257 RVA: 0x00269578 File Offset: 0x00268578
		Private Sub btnPalEncounter_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2040
			Me.BuildPaletteTreeView("encounterpalstd")
			Me.tbHelp.Text = "Encounters are not yet supported"
		End Sub

		' Token: 0x060008D2 RID: 2258 RVA: 0x002695A0 File Offset: 0x002685A0
		Private Sub btnPalItem_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2025
			Me.BuildPaletteTreeView("itempalstd")
		End Sub

		' Token: 0x060008D3 RID: 2259 RVA: 0x002695B8 File Offset: 0x002685B8
		Private Sub btnPalMerchant_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2051
			Me.tbHelp.Text = "Drag the desired merchant onto the map"
			Me.BuildPaletteTreeView("storepal")
		End Sub

		' Token: 0x060008D4 RID: 2260 RVA: 0x002695E0 File Offset: 0x002685E0
		Private Sub btnPalPlaceable_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2044
			Me.BuildPaletteTreeView("placeablepalstd")
			Me.tbHelp.Text = "Drag the desired placeable onto the map"
		End Sub

		' Token: 0x060008D5 RID: 2261 RVA: 0x00269608 File Offset: 0x00268608
		Private Sub btnPalSound_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2035
			Me.BuildPaletteTreeView("soundpal")
			Me.tbHelp.Text = "Drag the desired sound onto the map"
		End Sub

		' Token: 0x060008D6 RID: 2262 RVA: 0x00269630 File Offset: 0x00268630
		Private Sub btnPalTrigger_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2032
			Me.BuildPaletteTreeView("triggerpalstd")
			Me.tbHelp.Text = "Drag the desired trigger type onto the map"
		End Sub

		' Token: 0x060008D7 RID: 2263 RVA: 0x00269658 File Offset: 0x00268658
		Private Sub btnPalWaypoint_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2058
			Me.BuildPaletteTreeView("waypointpalstd")
			Me.tbHelp.Text = "Drag the desired waypoint onto the map"
		End Sub

		' Token: 0x060008D8 RID: 2264 RVA: 0x00269680 File Offset: 0x00268680
		Private Sub btnLogFactors_Click(sender As Object, e As EventArgs)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim stringWriter As StringWriter = New StringWriter(stringBuilder)
			Dim frmErrorMessageWithCopyableText As frmErrorMessageWithCopyableText = New frmErrorMessageWithCopyableText()
			stringWriter.WriteLine("mie = New MapInfo.Map")
			stringWriter.WriteLine("mie.MapName = """ + Me.g_MapName + """")
			stringWriter.WriteLine("mie.MapAssembler = ""Fred Tetra""")
			stringWriter.WriteLine("mie.MapCalibrator = ""Fred Tetra""")
			stringWriter.WriteLine("mie.ModuleName = ""Harbinger""")
			If Me.miUseSmallMap.Checked Then
				stringWriter.WriteLine("mie.S = True")
				stringWriter.WriteLine("mie.SXMul = " + StringType.FromDecimal(Me.nudXmul.Value))
				stringWriter.WriteLine("mie.SYMul = " + StringType.FromDecimal(Me.nudYmul.Value))
				stringWriter.WriteLine("mie.SXOff = " + StringType.FromDecimal(Me.nudXoff.Value))
				stringWriter.WriteLine("mie.SYOff = " + StringType.FromDecimal(Me.nudYoff.Value))
			Else
				stringWriter.WriteLine("mie.L = True")
				stringWriter.WriteLine("mie.LXMul = " + StringType.FromDecimal(Me.nudXmul.Value))
				stringWriter.WriteLine("mie.LYMul = " + StringType.FromDecimal(Me.nudYmul.Value))
				stringWriter.WriteLine("mie.LXOff = " + StringType.FromDecimal(Me.nudXoff.Value))
				stringWriter.WriteLine("mie.LYOff = " + StringType.FromDecimal(Me.nudYoff.Value))
			End If
			stringWriter.WriteLine("mi.MapList.Add(mie)")
			frmErrorMessageWithCopyableText.tbMsg.Text = stringWriter.ToString()
			frmErrorMessageWithCopyableText.ShowDialog(Me)
		End Sub

		' Token: 0x060008D9 RID: 2265 RVA: 0x00269838 File Offset: 0x00268838
		Private Sub btnDebug_Click(sender As Object, e As EventArgs)
			Dim frmTextEditor As frmTextEditor = New frmTextEditor()
			frmTextEditor.Filename = Me.g_MapName + ".git"
			frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
			frmTextEditor.RTFMode = True
			frmTextEditor.tbGeneric.Rtf = Me.GITfile.ToString()
			frmTextEditor.tbGeneric.SelectionLength = 0
			frmTextEditor.Show()
		End Sub

		' Token: 0x060008DA RID: 2266 RVA: 0x002698A8 File Offset: 0x002688A8
		Private Sub btnTweakUp_Click(sender As Object, e As EventArgs)
			If Me.IndicatedModItem IsNot Nothing Then
				Me.GITfile.SetNodeValue(Me.IndicatedModItem.YPosPath, ObjectType.AddObj(Me.GITfile.GetNodeValue(Me.IndicatedModItem.YPosPath), 0.01))
				Me.UpdateAfterTweakBtn()
			End If
		End Sub

		' Token: 0x060008DB RID: 2267 RVA: 0x00269904 File Offset: 0x00268904
		Private Sub btnTweakDown_Click(sender As Object, e As EventArgs)
			If Me.IndicatedModItem IsNot Nothing Then
				Me.GITfile.SetNodeValue(Me.IndicatedModItem.YPosPath, ObjectType.SubObj(Me.GITfile.GetNodeValue(Me.IndicatedModItem.YPosPath), 0.01))
				Me.UpdateAfterTweakBtn()
			End If
		End Sub

		' Token: 0x060008DC RID: 2268 RVA: 0x00269960 File Offset: 0x00268960
		Private Sub btnTweakLeft_Click(sender As Object, e As EventArgs)
			If Me.IndicatedModItem IsNot Nothing Then
				Me.GITfile.SetNodeValue(Me.IndicatedModItem.XPosPath, ObjectType.SubObj(Me.GITfile.GetNodeValue(Me.IndicatedModItem.XPosPath), 0.01))
				Me.UpdateAfterTweakBtn()
			End If
		End Sub

		' Token: 0x060008DD RID: 2269 RVA: 0x002699BC File Offset: 0x002689BC
		Private Sub btnTweakRight_Click(sender As Object, e As EventArgs)
			If Me.IndicatedModItem IsNot Nothing Then
				Me.GITfile.SetNodeValue(Me.IndicatedModItem.XPosPath, ObjectType.AddObj(Me.GITfile.GetNodeValue(Me.IndicatedModItem.XPosPath), 0.01))
				Me.UpdateAfterTweakBtn()
			End If
		End Sub

		' Token: 0x060008DE RID: 2270 RVA: 0x00269A18 File Offset: 0x00268A18
		Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs)
			Dim array As Object() = New Object(3) {}
			Dim point As Point = New Point(e.X, e.Y)
			Dim x As Integer = Me.pbox.PointToClient(point).X
			Dim point2 As Point = Me.pbox.PointToClient(point)
			Dim y As Integer = point2.Y
			If e.Data.GetDataPresent(DataFormats.Text) Then
				array = Strings.Split(StringType.FromObject(e.Data.GetData(GetType(String))), "|", -1, CompareMethod.Binary)
				Dim num As Integer = Convert.ToInt32(Strings.Replace(StringType.FromObject(array(0)), "itemtype=", "", 1, -1, CompareMethod.Binary))
				Me.gCurrentModItemType = num
				Dim gff_Struct As GFF_Struct = New GFF_Struct()
				Dim text As String
				If num <> 6 Then
					text = Strings.Replace(StringType.FromObject(array(2)), "resref=", "", 1, -1, CompareMethod.Binary)
					Dim text2 As String = text + "." + frmMain.GetRsrcTypeForID(num)
					If array.Length = 4 AndAlso (ObjectType.ObjTst(array(3), "up", False) = 0 OrElse ObjectType.ObjTst(array(3), "gt", False) = 0) Then
						Dim frmInstanceOrRefPrompt As frmInstanceOrRefPrompt = New frmInstanceOrRefPrompt()
						frmInstanceOrRefPrompt.ShowDialog(Me)
						Dim dialogResult As DialogResult = frmInstanceOrRefPrompt.DialogResult
						If dialogResult = DialogResult.Cancel Then
							Return
						End If
						Dim frmPromptForString As frmPromptForString = New frmPromptForString("Create new instance", "Enter name for new instance (16 character max)", text)
						If StringType.StrCmp(frmInstanceOrRefPrompt.ItemClass, "instance", False) = 0 Then
							frmPromptForString.tbValue.MaxLength = 16
							Dim text3 As String
							Do
								frmPromptForString.ShowDialog(Me)
								If Me.FileExistsInProject(frmPromptForString.tbValue.Text.Trim() + "." + frmMain.GetRsrcTypeForID(num)) Then
									text3 = "A file with that name already exists. Please choose another."
								ElseIf StringType.StrCmp(text, frmPromptForString.tbValue.Text.Trim(), False) = 0 Then
									text3 = "You cannot use the name of the template. Please choose another."
								Else
									text3 = ""
								End If
								If StringType.StrCmp(text3, "", False) <> 0 Then
									Interaction.MsgBox(text3, MsgBoxStyle.Exclamation, "Name error")
								End If
							Loop While StringType.StrCmp(text3, "", False) <> 0 OrElse frmPromptForString.DialogResult = DialogResult.Cancel
							If frmPromptForString.DialogResult = DialogResult.Cancel Then
								Return
							End If
							Dim text4 As String
							If ObjectType.ObjTst(array(3), "up", False) = 0 Then
								text4 = Me.g_ProjectPath + "\userpalette\" + text2
							ElseIf ObjectType.ObjTst(array(3), "gt", False) = 0 Then
								' The following expression was wrapped in a checked-expression
								text4 = String.Concat(New String() { frmMain.gRootPath, "\Global Templates\k", StringType.FromInteger(Me.KotorVersionIndex + 1), "\", text2 })
							End If
							File.Copy(text4, String.Concat(New String() { Me.g_ProjectPath, "\", frmPromptForString.tbValue.Text.Trim(), ".", frmMain.GetRsrcTypeForID(num) }))
							text = frmPromptForString.tbValue.Text.Trim()
						End If
					End If
				End If
				Select Case num
					Case 2027
						gff_Struct.type = 4
						gff_Struct.fieldCount = 6
						gff_Struct.fields = New GFF_Field(5) {}
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "XOrientation", 1F)
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
						Dim text5 As String
						gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", text + text5)
						Me.GITfile.AddListElement("Creature List", gff_Struct)
						Me.gModuleEditorSettings.FilterShowCreatures = True
					Case 2032
						If text.StartsWith("g_t_") Then
							Dim text6 As String = text
							point2 = New Point(x, y)
							Me.CreateTrap(text6, point2)
						Else
							Me.gCurrentRegionDrawingColor = Color.Orange
							point2 = New Point(x, y)
							Me.gLastMousePos = point2
							Me.gCurrentRegionSegmentOrigin = Me.gLastMousePos
							If Not Me.g_IsDrawingRegion Then
								Dim text5 As String
								Me.g_RegionResRef = text + text5
								Me.g_IsDrawingRegion = True
								Me.backbuffer = Nothing
								Me.g_RegionPointList = New ArrayList()
								Dim arrayList As ArrayList = Me.g_RegionPointList
								point2 = New Point(x, y)
								arrayList.Add(point2)
							Else
								Interaction.MsgBox("Currently Drawing a Region", MsgBoxStyle.Exclamation, Nothing)
							End If
							Me.gModuleEditorSettings.FilterShowTriggers = True
						End If
					Case 2035
						gff_Struct = New GFF_Struct(5, 6)
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", text)
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_dword, "GeneratedType", 0)
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
						Me.GITfile.AddListElement("SoundList", gff_Struct)
						Me.gModuleEditorSettings.FilterShowSounds = True
					Case 2040
						Me.gCurrentRegionDrawingColor = Color.Green
						point2 = New Point(x, y)
						Me.gLastMousePos = point2
						Me.gCurrentRegionSegmentOrigin = Me.gLastMousePos
						If Not Me.g_IsDrawingRegion Then
							Dim text5 As String
							Me.g_RegionResRef = text + text5
							Me.g_IsDrawingRegion = True
							Me.backbuffer = Nothing
							Me.g_RegionPointList = New ArrayList()
							Dim arrayList2 As ArrayList = Me.g_RegionPointList
							point2 = New Point(x, y)
							arrayList2.Add(point2)
						Else
							Interaction.MsgBox("Currently Drawing a Region", MsgBoxStyle.Exclamation, Nothing)
						End If
						Me.gModuleEditorSettings.FilterShowEncounters = True
					Case 2042
						gff_Struct.type = 8
						gff_Struct.fieldCount = 12
						gff_Struct.fields = New GFF_Field(11) {}
						Dim text5 As String
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", text + text5)
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CExoString, "Tag", "empty")
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_CResRef, "LinkedToModule", "empty")
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_CExoString, "LinkedTo", "empty")
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_byte, "LinkedToFlags", 0)
						Dim gffexoLocString As GFFExoLocString = New GFFExoLocString("none", 0)
						gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_CExoLocString, "TransitionDestin", gffexoLocString)
						gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_float, "X", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(8) = New GFF_Field(GFFField.GFF_float, "Z", 0F)
						gff_Struct.fields(9) = New GFF_Field(GFFField.GFF_float, "Bearing", 0F)
						gff_Struct.fields(10) = New GFF_Field(GFFField.GFF_byte, "UseTweakColor", 0)
						gff_Struct.fields(11) = New GFF_Field(GFFField.GFF_dword, "TweakColor", 16777215)
						Me.GITfile.AddListElement("Door List", gff_Struct)
						Me.gModuleEditorSettings.FilterShowDoors = True
					Case 2044
						gff_Struct = New GFF_Struct(5, 9)
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_float, "X", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "Z", 0F)
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "Bearing", 0F)
						Dim text5 As String
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", text + text5)
						Me.GITfile.AddListElement("Placeable List", gff_Struct)
						Me.gModuleEditorSettings.FilterShowPlaceables = True
					Case 2051
						gff_Struct = New GFF_Struct(6, 11)
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "XOrientation", 1F)
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
						gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_CResRef, "ResRef", text)
						Me.GITfile.AddListElement("StoreList", gff_Struct)
						Me.gModuleEditorSettings.FilterShowMerchants = True
					Case 2058
						Dim templateBifResourceData As Byte() = frmMain.GetTemplateBifResourceData(Me.KotorVersionIndex, text, num)
						Dim clsGFF As clsGFF = New clsGFF(templateBifResourceData, Me.KotorVersionIndex, False)
						Dim cexoLocStringNodeValue As String = clsGFF.GetCExoLocStringNodeValue("LocalizedName")
						gff_Struct = New GFF_Struct(14, 5)
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("TemplateResRef")))
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CExoString, "LinkedTo", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("LinkedTo")))
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_CExoString, "Tag", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Tag")))
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_byte, "HasMapNote", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("HasMapNote")))
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_byte, "MapNoteEnabled", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("MapNoteEnabled")))
						gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_CExoLocString, "LocalizedName", New GFFExoLocString(clsGFF.GetCExoLocStringNodeValue("LocalizedName"), 0))
						gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_CExoLocString, "Description", New GFFExoLocString(clsGFF.GetCExoLocStringNodeValue("Description"), 0))
						gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_CExoLocString, "MapNote", New GFFExoLocString(clsGFF.GetCExoLocStringNodeValue("MapNote"), 0))
						gff_Struct.fields(8) = New GFF_Field(GFFField.GFF_CExoString, "Comment", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Comment")))
						gff_Struct.fields(9) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(10) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(11) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
						gff_Struct.fields(12) = New GFF_Field(GFFField.GFF_float, "XOrientation", 1F)
						gff_Struct.fields(13) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
						Me.GITfile.AddListElement("WaypointList", gff_Struct)
						Me.gModuleEditorSettings.FilterShowWaypoints = True
				End Select
				Me.LoadBackground()
				Me.Draw()
				Me.BuildModuleTreeView()
				Me.UpdateVisibilityBtnsWithSettings()
			End If
		End Sub

		' Token: 0x060008DF RID: 2271 RVA: 0x0026A854 File Offset: 0x00269854
		Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs)
			If e.Data.GetDataPresent(DataFormats.Text) Then
				e.Effect = DragDropEffects.Copy
			End If
		End Sub

		' Token: 0x060008E0 RID: 2272 RVA: 0x0026A870 File Offset: 0x00269870
		Private Sub chkbShowResRefs_CheckedChanged(sender As Object, e As EventArgs)
			Me.g_ShowPaletteResRefs = CType(sender, CheckBox).Checked
			If StringType.StrCmp(Me.g_CurrentPaletteName, "", False) <> 0 Then
				Me.BuildPaletteTreeView(Me.g_CurrentPaletteName)
			End If
		End Sub

		' Token: 0x060008E1 RID: 2273 RVA: 0x0026A8A4 File Offset: 0x002698A4
		Private Sub chkbShowNames_CheckedChanged(sender As Object, e As EventArgs)
			Me.g_ShowPaletteNames = CType(sender, CheckBox).Checked
			If StringType.StrCmp(Me.g_CurrentPaletteName, "", False) <> 0 Then
				Me.BuildPaletteTreeView(Me.g_CurrentPaletteName)
			End If
		End Sub

		' Token: 0x060008E2 RID: 2274 RVA: 0x0026A8D8 File Offset: 0x002698D8
		Private Sub chkbShowTags_CheckedChanged(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.ShowTagsOnModulePalette = Me.chkbShowTags.Checked
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008E3 RID: 2275 RVA: 0x0026A914 File Offset: 0x00269914
		Private Sub miOpenProject_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.BrowseForModuleEditorProjectFolder()
			If StringType.StrCmp(text, "", False) = 0 Then
				Return
			End If
			Me.bModuleLoadedOK = Me.Setup(text)
			If Not Me.bModuleLoadedOK Then
				Me.EnableControls(False)
				Me.lbScripts.Items.Clear()
				Me.Text = "Module Editor"
				Return
			End If
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008E4 RID: 2276 RVA: 0x0026A97C File Offset: 0x0026997C
		Private Sub miShowHideModuleElements_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.bModElementsVisible Then
				Me.pnlModElements.Visible = False
				Dim panel As Panel = Me.Panel1
				panel.Width += 194
				panel = Me.Panel1
				panel.Left -= 194
				Me.bModElementsVisible = False
				Me.miShowHideModuleElements.Checked = False
			Else
				Me.pnlModElements.Visible = True
				Dim panel As Panel = Me.Panel1
				panel.Width -= 194
				panel = Me.Panel1
				panel.Left += 194
				Me.bModElementsVisible = True
				Me.miShowHideModuleElements.Checked = True
			End If
		End Sub

		' Token: 0x060008E5 RID: 2277 RVA: 0x0026AA38 File Offset: 0x00269A38
		Private Sub miShowHidePalette_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.bPaletteVisible Then
				Me.pnlPalette.Visible = False
				Dim panel As Panel = Me.Panel1
				panel.Width += 240
				Me.bPaletteVisible = False
				Me.miShowHidePalette.Checked = False
			Else
				Me.pnlPalette.Visible = True
				Dim panel As Panel = Me.Panel1
				panel.Width -= 240
				Me.bPaletteVisible = True
				Me.miShowHidePalette.Checked = True
			End If
		End Sub

		' Token: 0x060008E6 RID: 2278 RVA: 0x0026AAC0 File Offset: 0x00269AC0
		Private Sub miSave_Click(sender As Object, e As EventArgs)
			Me.GITfile.WriteFile(Path.Combine(Me.g_ProjectPath, Me.g_MapName + ".git"), "GIT")
			Me.AREfile.WriteFile(Path.Combine(Me.g_ProjectPath, Me.g_MapName + ".are"), "ARE")
			Me.IFOfile.WriteFile(Path.Combine(Me.g_ProjectPath, "Module.ifo"), "IFO")
		End Sub

		' Token: 0x060008E7 RID: 2279 RVA: 0x0026AB44 File Offset: 0x00269B44
		Private Sub miClose_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060008E8 RID: 2280 RVA: 0x0026AB4C File Offset: 0x00269B4C
		Private Sub miShowModulePaths_Click(sender As Object, e As EventArgs)
			Dim fileStream As FileStream = New FileStream(Me.g_ProjectPath + "\" + Me.g_MapName + ".pth", FileMode.Open)
			Dim clsGFF As clsGFF = New clsGFF(fileStream, Me.KotorVersionIndex, True)
			Dim num As Integer = 0
			Dim num2 As Integer = clsGFF.GetListItemCount("Path_Points") - 1
			For i As Integer = num To num2
				Dim num3 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(i) + ").First_Conection")))
				Dim num4 As Double = DoubleType.FromObject(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(i) + ").X"))
				Dim num5 As Double = DoubleType.FromObject(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(i) + ").Y"))
				Dim num6 As Integer = 1
				Dim num7 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(i) + ").Conections")))
				For j As Integer = num6 To num7
					Dim num8 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Path_Conections(" + StringType.FromInteger(num3) + ").Destination")))
					Dim num9 As Double = DoubleType.FromObject(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(num8) + ").X"))
					Dim num10 As Double = DoubleType.FromObject(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(num8) + ").Y"))
					Dim num11 As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(Convert.ToDouble(Me.nudXmul.Value) * num4))), Me.nudXoff.Value))
					Dim num12 As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(Convert.ToDouble(Me.nudYmul.Value) * num5))), Me.nudYoff.Value)))
					Me.Draw3x3Box(Me.bmp, num11, num12, Color.Fuchsia)
					Dim num13 As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(Convert.ToDouble(Me.nudXmul.Value) * num9))), Me.nudXoff.Value))
					Dim num14 As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(Convert.ToDouble(Me.nudYmul.Value) * num10))), Me.nudYoff.Value)))
					Me.Draw3x3Box(Me.bmp, num13, num14, Color.Fuchsia)
					Graphics.FromImage(Me.bmp).DrawLine(New Pen(Color.Orange, 1F), num11, num12, num13, num14)
					num4 = num9
					num5 = num10
					num3 += 1
				Next
			Next
			Me.Draw()
		End Sub

		' Token: 0x060008E9 RID: 2281 RVA: 0x0026AE0C File Offset: 0x00269E0C
		Private Sub miOptions_Click(sender As Object, e As EventArgs)
			Dim frmModuleEditorOptions As frmModuleEditorOptions = New frmModuleEditorOptions()
			Dim settings As Options = UserSettings.GetSettings()
			frmModuleEditorOptions.ModuleElementIndicatorSize = Me.dModuleElementIndicatorSize
			frmModuleEditorOptions.ConfirmDeletes = Me.bConfirmDeletes
			frmModuleEditorOptions.ShowLocatorRay = Me.bShowLocatorRay
			frmModuleEditorOptions.ModuleExportPath = Me.gModuleEditorSettings.ModuleEditorModOutputPath
			frmModuleEditorOptions.ShowDialog(Me)
			If frmModuleEditorOptions.DialogResult = DialogResult.OK Then
				Me.dModuleElementIndicatorSize = frmModuleEditorOptions.ModuleElementIndicatorSize
				Me.bConfirmDeletes = frmModuleEditorOptions.ConfirmDeletes
				Me.bShowLocatorRay = frmModuleEditorOptions.ShowLocatorRay
				settings.bModuleEditorShowLocatorRay = Me.bShowLocatorRay
				settings.bModuleEditorConfirmDeletes = Me.bConfirmDeletes
				settings.ModuleEditorModuleElementIndicatorSize = Me.dModuleElementIndicatorSize
				Me.gModuleEditorSettings.ModuleEditorModOutputPath = frmModuleEditorOptions.ModuleExportPath
				UserSettings.SaveSettings(settings)
				ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			End If
		End Sub

		' Token: 0x060008EA RID: 2282 RVA: 0x0026AEDC File Offset: 0x00269EDC
        'Private Sub miExploreModuleFolder_Click(sender As Object, e As EventArgs)
        '	New Process() With { .StartInfo = { .FileName = "explorer.exe ", .Arguments = Me.g_ProjectPath } }.Start()
        'End Sub

        ' Token: 0x060008EA RID: 2282 RVA: 0x0026AEDC File Offset: 0x00269EDC
        Private Sub miExploreModuleFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = "explorer.exe"
            psi.Arguments = """" & Me.g_ProjectPath & """"
            psi.UseShellExecute = True

            Dim proc As Process = New Process()
            proc.StartInfo = psi
            proc.Start()
        End Sub

		' Token: 0x060008EB RID: 2283 RVA: 0x0026AF18 File Offset: 0x00269F18
		Private Sub miBuildModFile_Click(sender As Object, e As EventArgs)
			Me.BuildModFile()
		End Sub

		' Token: 0x060008EC RID: 2284 RVA: 0x0026AF20 File Offset: 0x00269F20
		Private Sub miShowGffDump_Click(sender As Object, e As EventArgs)
			Dim frmTextEditor As frmTextEditor = New frmTextEditor()
			frmTextEditor.Filename = Me.g_MapName
			frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
			If sender Is Me.miShowAreDump Then
				frmTextEditor.tbGeneric.Rtf = New clsGFF(Me.g_ProjectPath + "\" + Me.g_MapName + ".are", Me.KotorVersionIndex, True).ToString()
				Dim frmTextEditor2 As frmTextEditor = frmTextEditor
				frmTextEditor2.Text += ".are"
			ElseIf sender Is Me.miShowGitDump Then
				frmTextEditor.tbGeneric.Rtf = New clsGFF(Me.g_ProjectPath + "\" + Me.g_MapName + ".git", Me.KotorVersionIndex, True).ToString()
				Dim frmTextEditor2 As frmTextEditor = frmTextEditor
				frmTextEditor2.Text += ".git"
			Else
				frmTextEditor.tbGeneric.Rtf = New clsGFF(Me.g_ProjectPath + "\module.ifo", Me.KotorVersionIndex, True).ToString()
				Dim frmTextEditor2 As frmTextEditor = frmTextEditor
				frmTextEditor2.Text += ".ifo"
			End If
			frmTextEditor.RTFMode = True
			frmTextEditor.tbGeneric.SelectionLength = 0
			frmTextEditor.Show()
		End Sub

		' Token: 0x060008ED RID: 2285 RVA: 0x0026B06C File Offset: 0x0026A06C
		Private Sub miModuleProperties_Click(sender As Object, e As EventArgs)
			Dim frmModuleIfo_AreaEditor As frmModuleIfo_AreaEditor = New frmModuleIfo_AreaEditor(Me.AREfile, Me.IFOfile, Me.GITfile, Me.KotorVersionIndex)
			If frmModuleIfo_AreaEditor.ShowDialog(Me) = DialogResult.OK Then
				frmModuleIfo_AreaEditor.UpdateFiles()
				If frmModuleIfo_AreaEditor.ModEntryChanged Then
					Me.LoadBackground()
					Me.Draw()
				End If
			End If
		End Sub

		' Token: 0x060008EE RID: 2286 RVA: 0x0026B0BC File Offset: 0x0026A0BC
		Private Sub miUseSmallMap_Click(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.MapSize = "small"
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.miSave_Click(Nothing, Nothing)
			Me.Setup(Me.g_ProjectPath)
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008EF RID: 2287 RVA: 0x0026B10C File Offset: 0x0026A10C
		Private Sub miUseLargeMap_Click(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.MapSize = "large"
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.miSave_Click(Nothing, Nothing)
			Me.Setup(Me.g_ProjectPath)
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008F0 RID: 2288 RVA: 0x0026B15C File Offset: 0x0026A15C
		Private Sub miUseAltSmallMap_Click(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.MapSize = "altsmall"
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.miSave_Click(Nothing, Nothing)
			Me.Setup(Me.g_ProjectPath)
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008F1 RID: 2289 RVA: 0x0026B1AC File Offset: 0x0026A1AC
		Private Sub miShowItemLabels_Click(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.ShowItemLabels = Not Me.gModuleEditorSettings.ShowItemLabels
			Me.miShowItemLabels.Checked = Me.gModuleEditorSettings.ShowItemLabels
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008F2 RID: 2290 RVA: 0x0026B1EC File Offset: 0x0026A1EC
		Private Sub miShowModuleEntryPoint_Click(sender As Object, e As EventArgs)
			Dim num As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_X"))
			Dim num2 As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_Y"))
			Dim num3 As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
			Dim num4 As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
			Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
		End Sub

		' Token: 0x060008F3 RID: 2291 RVA: 0x0026B2A8 File Offset: 0x0026A2A8
		Private Sub ToolBarModElementsFilter_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Me.gModuleEditorSettings.FilterShowCreatures = Me.tbarbtnCreature.Pushed
			Me.gModuleEditorSettings.FilterShowDoors = Me.tbarbtnDoor.Pushed
			Me.gModuleEditorSettings.FilterShowEncounters = Me.tbarbtnEncounter.Pushed
			Me.gModuleEditorSettings.FilterShowMerchants = Me.tbarbtnMerchant.Pushed
			Me.gModuleEditorSettings.FilterShowPlaceables = Me.tbarbtnPlaceable.Pushed
			Me.gModuleEditorSettings.FilterShowSounds = Me.tbarbtnSound.Pushed
			Me.gModuleEditorSettings.FilterShowTriggers = Me.tbarbtnTrigger.Pushed
			Me.gModuleEditorSettings.FilterShowWaypoints = Me.tbarbtnWaypoint.Pushed
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008F4 RID: 2292 RVA: 0x0026B388 File Offset: 0x0026A388
		Public Sub BuildModuleTreeView()
			Me.tvModule.Nodes.Clear()
			Dim ticks As Long = DateAndTime.Now.Ticks
			Me.AddTvModuleNodes("Creatures", Me.CreatureArr, 8, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Doors", Me.DoorArr, 3, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Encounters", Me.EncounterArr, 10, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Items", Me.ItemArr, -1, False)
			Me.AddTvModuleNodes("Merchants", Me.MerchantArr, 7, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Placeables", Me.PlaceableArr, 4, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Sounds", Me.SoundArr, 6, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Triggers", Me.TriggerArr, 5, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Waypoints", Me.WaypointArr, 11, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Cameras", Me.CameraArr, 9, False)
			Dim timeSpan As TimeSpan = New TimeSpan(DateAndTime.Now.Ticks - ticks)
			Dim timeSpan2 As TimeSpan = timeSpan
			Console.WriteLine("BuildModuleTreeView Time: " + StringType.FromDouble(timeSpan2.TotalMilliseconds))
			Console.WriteLine(StringType.FromInteger(Me.tb) + " " + StringType.FromInteger(Me.lcl))
			Me.tb = 0
			Me.lcl = 0
			Try
				For Each obj As Object In Me.g_tvModule_TreeOpenPaths
					Dim text As String = StringType.FromObject(obj)
					frmMain.OpenTreeViewToPath(text, Me.tvModule.Nodes(0), 0, False)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

        '' Token: 0x060008F5 RID: 2293 RVA: 0x0026B598 File Offset: 0x0026A598
        'Private Sub AddTvModuleNodes(parentLabel As String, ModItemArr As ModItem(), Optional imageIndex As Integer = -1, Optional ShowTags As Boolean = False)
        '	Dim modItemTvNode As ModItemTvNode = New ModItemTvNode(parentLabel)
        '	modItemTvNode.ImageIndex = imageIndex
        '	modItemTvNode.SelectedImageIndex = imageIndex
        '	Me.tvModule.Nodes.Add(modItemTvNode)
        '	If ModItemArr IsNot Nothing Then
        '		For Each modItem As ModItem In ModItemArr
        '			Dim num As Integer
        '			If modItem IsNot Nothing Then
        '				Dim modItemTvNode2 As ModItemTvNode
        '				If ShowTags Then
        '					If StringType.StrCmp(modItem.Tag, "", False) <> 0 Then
        '						modItemTvNode2 = New ModItemTvNode(modItem.Tag)
        '					Else
        '						Dim modItemTag As String = Me.GetModItemTag(modItem.FileName)
        '						If modItemTag Is Nothing Then
        '							modItemTvNode2 = New ModItemTvNode(modItem.ResRef + " (missing file)")
        '						ElseIf StringType.StrCmp(modItemTag, "", False) = 0 Then
        '							modItemTvNode2 = New ModItemTvNode(modItem.ResRef + " (missing tag)")
        '						Else
        '							modItemTvNode2 = New ModItemTvNode(modItemTag)
        '						End If
        '					End If
        '				Else
        '					modItemTvNode2 = New ModItemTvNode(modItem.ResRef)
        '				End If
        '				modItemTvNode2.ArrayIndex = num
        '				modItemTvNode2.ItemType = modItem.ItemType
        '				modItemTvNode2.Tag = "Item"
        '				modItemTvNode.Nodes.Add(modItemTvNode2)
        '			End If
        '			num += 1
        '		Next
        '		Dim modItem As ModItem
        '		If modItem IsNot Nothing Then
        '			modItemTvNode.ItemType = modItem.ItemType
        '			modItemTvNode.Tag = "ItemParent"
        '		End If
        '	End If
        'End Sub

        ' Token: 0x060008F5 RID: 2293 RVA: 0x0026B598 File Offset: 0x0026A598
        Private Sub AddTvModuleNodes(ByVal parentLabel As String, ByVal ModItemArr As ModItem(), Optional ByVal imageIndex As Integer = -1, Optional ByVal ShowTags As Boolean = False)
            Dim parentNode As ModItemTvNode = New ModItemTvNode(parentLabel)
            parentNode.ImageIndex = imageIndex
            parentNode.SelectedImageIndex = imageIndex
            Me.tvModule.Nodes.Add(parentNode)

            If ModItemArr Is Nothing Then
                Return
            End If

            Dim itemIndex As Integer = 0
            Dim lastValidItem As ModItem = Nothing

            For Each currentItem As ModItem In ModItemArr
                If currentItem IsNot Nothing Then
                    lastValidItem = currentItem

                    Dim childNode As ModItemTvNode = Nothing

                    If ShowTags Then
                        If StringType.StrCmp(currentItem.Tag, "", False) <> 0 Then
                            childNode = New ModItemTvNode(currentItem.Tag)
                        Else
                            Dim modItemTag As String = Me.GetModItemTag(currentItem.FileName)

                            If modItemTag Is Nothing Then
                                childNode = New ModItemTvNode(currentItem.ResRef + " (missing file)")
                            ElseIf StringType.StrCmp(modItemTag, "", False) = 0 Then
                                childNode = New ModItemTvNode(currentItem.ResRef + " (missing tag)")
                            Else
                                childNode = New ModItemTvNode(modItemTag)
                            End If
                        End If
                    Else
                        childNode = New ModItemTvNode(currentItem.ResRef)
                    End If

                    childNode.ArrayIndex = itemIndex
                    childNode.ItemType = currentItem.ItemType
                    childNode.Tag = "Item"
                    parentNode.Nodes.Add(childNode)
                End If

                itemIndex += 1
            Next

            If lastValidItem IsNot Nothing Then
                parentNode.ItemType = lastValidItem.ItemType
                parentNode.Tag = "ItemParent"
            End If
        End Sub

		' Token: 0x060008F6 RID: 2294 RVA: 0x0026B6D4 File Offset: 0x0026A6D4
		Private Function GetModItemTag(FileName As String) As String
			' The following expression was wrapped in a checked-statement
			If File.Exists(Me.g_ProjectPath + "\" + FileName) Then
				Me.lcl += 1
				Dim fileStream As FileStream = File.OpenRead(Me.g_ProjectPath + "\" + FileName)
				Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
				Dim array As Byte() = binaryReader.ReadBytes(CInt(fileStream.Length))
				binaryReader.Close()
				Return frmMain.GetGFFTag(array)
			End If
			If Me.KotorVersionIndex = 0 Then
				If Me.htK1Tags.ContainsKey(FileName) Then
					Me.tb += 1
					Return StringType.FromObject(Me.htK1Tags(FileName))
				End If
			ElseIf Me.KotorVersionIndex = 1 AndAlso Me.htK2Tags.ContainsKey(FileName) Then
				Me.tb += 1
				Return StringType.FromObject(Me.htK2Tags(FileName))
			End If
			Dim text As String
			Return text
		End Function

		' Token: 0x060008F7 RID: 2295 RVA: 0x0026B7B8 File Offset: 0x0026A7B8
		Public Sub BuildPaletteTreeView(paletteName As String)
			If Not(Me.g_ShowPaletteNames Or Me.g_ShowPaletteResRefs) Then
				Return
			End If
			Dim frmMain As frmMain = New frmMain()
			Dim num As Integer = frmMain.KxChitinKey(Me.KotorVersionIndex).FindResIDForResRef(paletteName, 2030)
			Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + frmMain.KxChitinKey(Me.KotorVersionIndex).BiffList(num >> 20).filename
			Dim clsGFF As clsGFF = New clsGFF(frmMain.GetBIFFResource(text, num - (num >> 20 << 20)).data, Me.KotorVersionIndex, True)
			Me.g_CurrentPaletteName = paletteName
			Me.tvPalette.Nodes.Clear()
			Dim num2 As Integer = 0
			Dim num3 As Integer = clsGFF.GetListItemCount("MAIN") - 1
			For i As Integer = num2 To num3
				Dim text2 As String = StringType.FromObject(clsGFF.GetNodeValue("MAIN(" + StringType.FromInteger(i) + ").DELETE_ME"))
				Me.tvPalette.Nodes.Add(text2)
				Dim num4 As Integer = 0
				Dim num5 As Integer = clsGFF.GetListItemCount("MAIN(" + StringType.FromInteger(i) + ").LIST") - 1
				For j As Integer = num4 To num5
					Dim obj As Object = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").DELETE_ME" })))
					If obj IsNot Nothing Then
						Dim nodes As Object = Me.tvPalette.Nodes(i).Nodes
						Dim type As Type = Nothing
						Dim text3 As String = "Add"
						Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(obj) }
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Boolean() = New Boolean() { True }
						LateBinding.LateCall(nodes, type, text3, array2, array3, array4)
						If array4(0) Then
							obj = RuntimeHelpers.GetObjectValue(array(0))
						End If
						Dim num6 As Integer = clsGFF.GetListItemCount(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").LIST" })) - 1
						Dim num7 As Integer = 0
						Dim num8 As Integer = num6
						For k As Integer = num7 To num8
							Dim text4 As String = ""
							If Me.g_ShowPaletteNames Then
								obj = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").LIST(", StringType.FromInteger(k), ").NAME" })))
								text4 = StringType.FromObject(obj)
							End If
							Dim obj2 As Object = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").LIST(", StringType.FromInteger(k), ").RESREF" })))
							If Me.g_ShowPaletteResRefs Then
								If Me.g_ShowPaletteNames Then
									text4 += " ("
								End If
								text4 = StringType.FromObject(ObjectType.StrCatObj(text4, obj2))
								If Me.g_ShowPaletteNames Then
									text4 += ")"
								End If
							End If
							Dim treeNode As TreeNode = New TreeNode(text4)
							treeNode.Tag = ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("itemtype=" + StringType.FromInteger(Me.g_CurrentPaletteModItemType) + "|name=", obj), "|resref="), obj2)
							Me.tvPalette.Nodes(i).Nodes(j).Nodes.Add(treeNode)
						Next
					Else
						Dim text4 As String = ""
						If Me.g_ShowPaletteNames Then
							obj = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").NAME" })))
							text4 = StringType.FromObject(obj)
						End If
						Dim obj2 As Object = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").RESREF" })))
						If Me.g_ShowPaletteResRefs Then
							If Me.g_ShowPaletteNames Then
								text4 += " ("
							End If
							text4 = StringType.FromObject(ObjectType.StrCatObj(text4, obj2))
							If Me.g_ShowPaletteNames Then
								text4 += ")"
							End If
						End If
						Dim treeNode As TreeNode = New TreeNode(text4)
						treeNode.Tag = ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("itemtype=" + StringType.FromInteger(Me.g_CurrentPaletteModItemType) + "|name=", obj), "|resref="), obj2)
						Me.tvPalette.Nodes(i).Nodes.Add(treeNode)
					End If
				Next
			Next
			Dim num9 As Integer = 0
			Dim num10 As Integer = Me.tvPalette.Nodes.Count - 1
			For i As Integer = num9 To num10
				If StringType.StrCmp(Strings.Mid(Me.tvPalette.Nodes(i).Text, 1, 6), "ASSIGN", False) = 0 Then
					Me.tvPalette.Nodes.RemoveAt(i)
					Exit For
				End If
			Next
		End Sub

		' Token: 0x060008F8 RID: 2296 RVA: 0x0026BD50 File Offset: 0x0026AD50
		Private Sub BuildUserPaletteTreeView()
			If Not Directory.Exists(Me.g_ProjectPath + "\userpalette") Then
				Directory.CreateDirectory(Me.g_ProjectPath + "\userpalette")
				Return
			End If
			Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Me.g_ProjectPath + "\userpalette")
			Dim directoryInfo2 As DirectoryInfo = New DirectoryInfo(frmMain.gRootPath + "\Global Templates\k" + StringType.FromInteger(Me.KotorVersionIndex + 1))
			Me.tvUserPalette.Nodes(0).Nodes.Clear()
			Me.tvUserPalette.Nodes(1).Nodes.Clear()
			Me.tvUserPalette.Nodes(2).Nodes.Clear()
			Me.tvUserPalette.Nodes(3).Nodes.Clear()
			Me.tvUserPalette.Nodes(4).Nodes.Clear()
			Me.tvUserPalette.Nodes(5).Nodes.Clear()
			Me.tvUserPalette.Nodes(6).Nodes.Clear()
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utc", Me.tvUserPalette.Nodes(0), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utc", Me.tvUserPalette.Nodes(0), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utd", Me.tvUserPalette.Nodes(1), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utd", Me.tvUserPalette.Nodes(1), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "ute", Me.tvUserPalette.Nodes(2), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "ute", Me.tvUserPalette.Nodes(2), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utm", Me.tvUserPalette.Nodes(3), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utm", Me.tvUserPalette.Nodes(3), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utp", Me.tvUserPalette.Nodes(4), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utp", Me.tvUserPalette.Nodes(4), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "uts", Me.tvUserPalette.Nodes(5), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "uts", Me.tvUserPalette.Nodes(5), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utt", Me.tvUserPalette.Nodes(6), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utt", Me.tvUserPalette.Nodes(6), "up")
		End Sub

		' Token: 0x060008F9 RID: 2297 RVA: 0x0026C05C File Offset: 0x0026B05C
		Private Sub BuildUserPaletteTreeNodes(dir As DirectoryInfo, fileext As String, nodeparent As TreeNode, source As String)
			For Each fileInfo As FileInfo In dir.GetFiles("*." + fileext)
				Dim treeNode As TreeNode = New TreeNode()
				treeNode.Text = fileInfo.Name.Replace(fileInfo.Extension, "")
				treeNode.Tag = String.Concat(New String() { "itemtype=", StringType.FromInteger(CInt(frmMain.GetIDForRsrcType(fileext.ToLower()))), "|name=", treeNode.Text, "|resref=", treeNode.Text, "|", source })
				nodeparent.Nodes.Add(treeNode)
			Next
		End Sub

		' Token: 0x060008FA RID: 2298 RVA: 0x0026C124 File Offset: 0x0026B124
		Private Sub DeleteModuleItem(ModuleItem As ModItem)
			If ModuleItem.ItemType <> 12040 Then
				Dim array As String() = Strings.Split(Strings.Replace(ModuleItem.Path, ")", "", 1, -1, CompareMethod.Binary), "(", -1, CompareMethod.Binary)
				Me.GITfile.DeleteListElement(array(0), IntegerType.FromString(array(1)))
			Else
				Dim array As String() = Strings.Split(Strings.Replace(Strings.Replace(ModuleItem.Path, "(", ".", 1, -1, CompareMethod.Binary), ")", "", 1, -1, CompareMethod.Binary), ".", -1, CompareMethod.Binary)
				Me.GITfile.DeleteListElement(String.Concat(New String() { array(0), ".", array(1), ".", array(2) }), IntegerType.FromString(array(3)))
			End If
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
			If ModuleItem.ItemType = 12040 Then
				Return
			End If
			Dim fileName As String = ModuleItem.FileName
			If Not Directory.Exists(Me.g_ProjectPath + "\recycle") Then
				Directory.CreateDirectory(Me.g_ProjectPath + "\recycle")
			End If
			If File.Exists(Me.g_ProjectPath + "\" + fileName) Then
				Dim flag As Boolean = False
				Dim extension As String = Path.GetExtension(fileName)
				Dim array2 As ModItem()
				If StringType.StrCmp(extension, ".utc", False) = 0 Then
					array2 = Me.CreatureArr
				ElseIf StringType.StrCmp(extension, ".utd", False) = 0 Then
					array2 = Me.DoorArr
				ElseIf StringType.StrCmp(extension, ".uti", False) = 0 Then
					array2 = Me.ItemArr
				ElseIf StringType.StrCmp(extension, ".utm", False) = 0 Then
					array2 = Me.MerchantArr
				ElseIf StringType.StrCmp(extension, ".utp", False) = 0 Then
					array2 = Me.PlaceableArr
				ElseIf StringType.StrCmp(extension, ".utt", False) = 0 Then
					array2 = Me.TriggerArr
				ElseIf StringType.StrCmp(extension, ".uts", False) = 0 Then
					array2 = Me.SoundArr
				ElseIf StringType.StrCmp(extension, ".utw", False) = 0 Then
					array2 = Me.WaypointArr
				ElseIf StringType.StrCmp(extension, ".ute", False) = 0 Then
					array2 = Me.EncounterArr
				End If
				If array2 IsNot Nothing Then
					Dim num As Integer = 0
					Dim upperBound As Integer = array2.GetUpperBound(0)
					For i As Integer = num To upperBound
						If StringType.StrCmp(array2(i).FileName.ToLower(), fileName.ToLower(), False) = 0 Then
							flag = True
							Exit For
						End If
					Next
				End If
				If Not flag Then
					File.Move(Me.g_ProjectPath + "\" + fileName, String.Concat(New String() { Me.g_ProjectPath, "\recycle\", StringType.FromInteger(DateAndTime.Now.Minute), StringType.FromInteger(DateAndTime.Now.Second), fileName }))
				End If
			End If
		End Sub

		' Token: 0x060008FB RID: 2299 RVA: 0x0026C40C File Offset: 0x0026B40C
		Private Sub EnableControls(state As Boolean)
			Me.Panel1.Enabled = state
			Me.pbox.Visible = state
			Me.tabctrlModule.Enabled = state
			Me.tabctrlPalette.Enabled = state
			Me.miSave.Enabled = state
			Me.miBuildModFile.Enabled = state
			Me.miExploreModuleFolder.Enabled = state
			Me.miModuleProperties.Enabled = state
			Me.miShowHideModuleElements.Enabled = state
			Me.miShowHidePalette.Enabled = state
			Me.miShowItemLabels.Enabled = state
			Me.miUseSmallMap.Enabled = state And Me.g_SmallMapAvailable
			Me.miUseLargeMap.Enabled = state And Me.g_LargeMapAvailable
			Me.miShowModuleEntryPoint.Enabled = state
			Me.miShowModulePaths.Enabled = state
			Me.miShowAreDump.Enabled = state
			Me.miShowGitDump.Enabled = state
			Me.miShowIfoDump.Enabled = state
			Me.miOptions.Enabled = state
			Me.ToolBarModElementsFilter.Enabled = state
			Me.chkbShowTags.Enabled = state
		End Sub

		' Token: 0x060008FC RID: 2300 RVA: 0x0026C524 File Offset: 0x0026B524
		Private Sub BuildModuleFileList(items As ModItem(), ByRef list As ArrayList, ByRef refcount As Integer, ByRef instcount As Integer)
			If items Is Nothing Then
				Return
			End If
			For Each modItem As ModItem In items
				Dim text As String = modItem.ResRef + "." + frmMain.GetRsrcTypeForID(modItem.ItemType)
				Dim text2 As String = Me.g_ProjectPath + "\" + text
				If File.Exists(text2) Then
					If Not list.Contains(text2) Then
						list.Add(text2)
						instcount += 1
					End If
				Else
					text2 = Me.g_UserPalettePath + "\" + text
					If File.Exists(text2) Then
						If Not list.Contains(text2) Then
							list.Add(text2)
							instcount += 1
						End If
					Else
						text2 = Me.g_GlobalTemplatesPath + "\" + text
						If File.Exists(text2) Then
							If Not list.Contains(text2) Then
								list.Add(text2)
								instcount += 1
							End If
						Else
							refcount += 1
						End If
					End If
				End If
			Next
		End Sub

		' Token: 0x060008FD RID: 2301 RVA: 0x0026C61C File Offset: 0x0026B61C
		Private Sub AddModuleFileNamesToList(path As String, ByRef list As ArrayList, wildcard As String)
			Dim files As String() = Directory.GetFiles(path, wildcard)
			If files.Length > 0 Then
				For Each text As String In files
					list.Add(text)
				Next
			End If
		End Sub

		' Token: 0x060008FE RID: 2302 RVA: 0x0026C658 File Offset: 0x0026B658
		Private Function BrowseForModuleEditorProjectFolder() As String
			Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
			folderBrowserDialog.Description = "Select a Module Project folder:"
			Me.CurrentSettings = UserSettings.GetSettings()
			If Me.CurrentSettings.LastModuleEditedPath IsNot Nothing Then
				folderBrowserDialog.SelectedPath = Me.CurrentSettings.LastModuleEditedPath
			End If
			folderBrowserDialog.ShowNewFolderButton = False
			If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
				Me.CurrentSettings.LastModuleEditedPath = folderBrowserDialog.SelectedPath
				UserSettings.SaveSettings(Me.CurrentSettings)
				Return folderBrowserDialog.SelectedPath
			End If
			Dim text As String
			Return text
		End Function

		' Token: 0x060008FF RID: 2303 RVA: 0x0026C6D4 File Offset: 0x0026B6D4
		Private Sub AddNodeChildrenToTreePaths(node As ModItemTvNode, arTreeOpenPaths As ArrayList)
			Try
				For Each obj As Object In node.Nodes
					Dim modItemTvNode As ModItemTvNode = CType(obj, ModItemTvNode)
					If modItemTvNode.IsExpanded Then
						If Not arTreeOpenPaths.Contains(modItemTvNode.FullPath) Then
							arTreeOpenPaths.Add(modItemTvNode.FullPath)
						End If
						Me.AddNodeChildrenToTreePaths(modItemTvNode, arTreeOpenPaths)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000900 RID: 2304 RVA: 0x0026C754 File Offset: 0x0026B754
		Private Sub UpdateAfterTweakBtn()
			Me.IndicatedModItem.X = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.IndicatedModItem.XPosPath))
			Me.IndicatedModItem.Y = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.IndicatedModItem.YPosPath))
			Me.sbarpnlLocX.Text = StringType.FromSingle(Convert.ToSingle(Me.IndicatedModItem.X))
			Me.sbarpnlLocY.Text = StringType.FromSingle(Convert.ToSingle(Me.IndicatedModItem.Y))
			Me.LoadBackground()
			Me.Draw()
		End Sub

        '' Token: 0x06000901 RID: 2305 RVA: 0x0026C7FC File Offset: 0x0026B7FC
        'Private Sub lbScripts_DoubleClick(sender As Object, e As EventArgs)
        '	If Me.lbScripts.SelectedIndex = -1 Then
        '		Return
        '	End If
        '	New frmTextEditor(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Me.g_ProjectPath + "\", Me.lbScripts.SelectedItem), ".nss")), Me.KotorVersionIndex, True) With { .Filename = StringType.FromObject(ObjectType.StrCatObj(Me.lbScripts.SelectedItem, ".nss")), .DirectEdit = True }.Show()
        'End Sub

        ' Token: 0x06000901 RID: 2305 RVA: 0x0026C7FC File Offset: 0x0026B7FC
        Private Sub lbScripts_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lbScripts.SelectedIndex = -1 Then
                Return
            End If

            Dim scriptName As String = StringType.FromObject(Me.lbScripts.SelectedItem)
            Dim scriptPath As String = Me.g_ProjectPath + "\" + scriptName + ".nss"

            Dim editor As frmTextEditor = New frmTextEditor(scriptPath, Me.KotorVersionIndex, True)
            editor.Filename = scriptName + ".nss"
            editor.DirectEdit = True
            editor.Show()
        End Sub

		' Token: 0x06000902 RID: 2306 RVA: 0x0026C884 File Offset: 0x0026B884
		Private Sub SetEditorCaption()
			' The following expression was wrapped in a checked-expression
			Me.Text = String.Concat(New String() { "Module Editor - ", Me.g_MapName, " (K", StringType.FromInteger(Me.KotorVersionIndex + 1), ") - " })
			If StringType.StrCmp(Me.gModuleEditorSettings.ModuleEditorModOutputPath, "", False) = 0 Then
				Me.Text += "(No module output path set)"
			Else
				Me.Text += Me.gModuleEditorSettings.ModuleEditorModOutputPath
			End If
		End Sub

		' Token: 0x06000903 RID: 2307 RVA: 0x0026C924 File Offset: 0x0026B924
		Private Sub lbDialogs_DoubleClick(sender As Object, e As EventArgs)
			Dim cursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Dim frmDialogEditor As frmDialogEditor = New frmDialogEditor(Me.g_ProjectPath + "\" + Me.lbDialogs.SelectedItem.ToString() + ".dlg", Me.KotorVersionIndex)
			frmDialogEditor.Show()
			Cursor.Current = cursor
		End Sub

		' Token: 0x06000904 RID: 2308 RVA: 0x0026C980 File Offset: 0x0026B980
		Private Sub chkbFine_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkbFine.Checked Then
				Me.nudXmul.DecimalPlaces = 4
				Me.nudYmul.DecimalPlaces = 4
			Else
				Me.nudXmul.DecimalPlaces = 2
				Me.nudYmul.DecimalPlaces = 2
			End If
		End Sub

		' Token: 0x06000905 RID: 2309 RVA: 0x0026C9CC File Offset: 0x0026B9CC
		Private Sub btnAssignPt1_Click(sender As Object, e As EventArgs)
			Dim point As Point = New Point(Convert.ToInt32(Me.tbMouseX.Text), Convert.ToInt32(Me.tbMouseY.Text))
			Me.MapCalibratePt1 = point
			If Not Me.MapCalibratePt2.IsEmpty Then
				Me.btnCalcCalibrationVals.Enabled = True
			End If
		End Sub

		' Token: 0x06000906 RID: 2310 RVA: 0x0026CA20 File Offset: 0x0026BA20
		Private Sub btnAssignPt2_Click(sender As Object, e As EventArgs)
			Dim point As Point = New Point(Convert.ToInt32(Me.tbMouseX.Text), Convert.ToInt32(Me.tbMouseY.Text))
			Me.MapCalibratePt2 = point
			If Not Me.MapCalibratePt1.IsEmpty Then
				Me.btnCalcCalibrationVals.Enabled = True
			End If
		End Sub

		' Token: 0x06000907 RID: 2311 RVA: 0x0026CA74 File Offset: 0x0026BA74
		Private Sub btnCalcCalibrationVals_Click(sender As Object, e As EventArgs)
			Me.chkbUseFactors.Checked = False
			Me.nudXmul.Value = New Decimal(CSng((Me.MapCalibratePt2.X - Me.MapCalibratePt1.X)) / (Convert.ToSingle(Me.tb3dsMaxPt2X.Text) - Convert.ToSingle(Me.tb3dsMaxPt1X.Text)))
			Me.nudXoff.Value = New Decimal(-(CSng(Me.MapCalibratePt1.X) - Convert.ToSingle(Me.nudXmul.Value) * Convert.ToSingle(Me.tb3dsMaxPt1X.Text)))
			Me.nudYmul.Value = New Decimal(CSng((0 - (Me.MapCalibratePt2.Y - Me.MapCalibratePt1.Y))) / (Convert.ToSingle(Me.tb3dsMaxPt2Y.Text) - Convert.ToSingle(Me.tb3dsMaxPt1Y.Text)))
			Me.nudYoff.Value = New Decimal(-(CSng(Me.g_imageYsize) - (CSng(Me.MapCalibratePt1.Y) + Convert.ToSingle(Me.nudYmul.Value) * Convert.ToSingle(Me.tb3dsMaxPt1Y.Text))))
			Me.chkbUseFactors.Checked = True
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x06000908 RID: 2312 RVA: 0x0026CBC4 File Offset: 0x0026BBC4
		Private Sub btnCalToolsToggle_MouseDown(sender As Object, e As MouseEventArgs)
			If(Control.ModifierKeys And (Keys.Shift Or Keys.Control Or Keys.Alt)) > Keys.None AndAlso (Control.MouseButtons And MouseButtons.XButton2) > MouseButtons.None Then
				Me.CalibrationToolsVis = Not Me.CalibrationToolsVis
				Me.nudXmul.Visible = Me.CalibrationToolsVis
				Me.nudYmul.Visible = Me.CalibrationToolsVis
				Me.nudXoff.Visible = Me.CalibrationToolsVis
				Me.nudYoff.Visible = Me.CalibrationToolsVis
				Me.chkbUseFactors.Visible = Me.CalibrationToolsVis
				Me.btnLogFactors.Visible = Me.CalibrationToolsVis
				Me.btnAssignPt1.Visible = Me.CalibrationToolsVis
				Me.btnAssignPt2.Visible = Me.CalibrationToolsVis
				Me.btnAssignPt2.Visible = Me.CalibrationToolsVis
				Me.btnCalcCalibrationVals.Visible = Me.CalibrationToolsVis
				Me.tbMouseX.Visible = Me.CalibrationToolsVis
				Me.tbMouseY.Visible = Me.CalibrationToolsVis
				Me.tb3dsMaxPt1X.Visible = Me.CalibrationToolsVis
				Me.tb3dsMaxPt2X.Visible = Me.CalibrationToolsVis
				Me.tb3dsMaxPt1Y.Visible = Me.CalibrationToolsVis
				Me.tb3dsMaxPt2Y.Visible = Me.CalibrationToolsVis
			End If
		End Sub

		' Token: 0x06000909 RID: 2313 RVA: 0x0026CD18 File Offset: 0x0026BD18
		Private Sub miFont_Click(sender As Object, e As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.ShowColor = True
			fontDialog.Font = Me.labelFont
			fontDialog.Color = Me.labelBrush.Color
			fontDialog.ShowApply = False
			If fontDialog.ShowDialog() = DialogResult.OK Then
				Me.labelFont = fontDialog.Font
				Me.labelBrush.Color = fontDialog.Color
				Me.LoadBackground()
				Me.Draw()
			End If
		End Sub

		' Token: 0x0600090A RID: 2314 RVA: 0x0026CD88 File Offset: 0x0026BD88
		Private Function IsFileInTrash(filename As String) As Boolean
			Dim flag As Boolean
			Return flag
		End Function

		' Token: 0x04000460 RID: 1120
		Private Const HALF_ITEM_SIZE As Integer = 1

		' Token: 0x04000461 RID: 1121
		Private Const ITEM_SIZE As Integer = 3

		' Token: 0x04000462 RID: 1122
		Private Const NEAR_TOLERANCE As Integer = 2

		' Token: 0x04000463 RID: 1123
		Public g_clsDialogTlk As clsDialogTlk

		' Token: 0x04000464 RID: 1124
		Private CreatureArr As ModItem()

		' Token: 0x04000465 RID: 1125
		Private PlaceableArr As ModItem()

		' Token: 0x04000466 RID: 1126
		Private DoorArr As ModItem()

		' Token: 0x04000467 RID: 1127
		Private ItemArr As ModItem()

		' Token: 0x04000468 RID: 1128
		Private SoundArr As ModItem()

		' Token: 0x04000469 RID: 1129
		Private WaypointArr As ModItem()

		' Token: 0x0400046A RID: 1130
		Private MerchantArr As ModItem()

		' Token: 0x0400046B RID: 1131
		Private TriggerArr As ModItem()

		' Token: 0x0400046C RID: 1132
		Private EncounterArr As ModItem()

		' Token: 0x0400046D RID: 1133
		Private CameraArr As ModItem()

		' Token: 0x0400046E RID: 1134
		Private TriggerRegions As Region()

		' Token: 0x0400046F RID: 1135
		Private EncounterRegions As Region()

		' Token: 0x04000470 RID: 1136
		Private bModuleLoadedOK As Boolean

		' Token: 0x04000471 RID: 1137
		Private g_imageYsize As Integer

		' Token: 0x04000472 RID: 1138
		Private CurrentModItem As ModItem

		' Token: 0x04000473 RID: 1139
		Private IndicatedModItem As ModItem

		' Token: 0x04000474 RID: 1140
		Private gCurrentModItemType As Integer

		' Token: 0x04000475 RID: 1141
		Private gCurrentRegionDrawingColor As Color

		' Token: 0x04000476 RID: 1142
		Private GITfile As clsGFF

		' Token: 0x04000477 RID: 1143
		Private AREfile As clsGFF

		' Token: 0x04000478 RID: 1144
		Private IFOfile As clsGFF

		' Token: 0x04000479 RID: 1145
		Private backbuffer As Bitmap

		' Token: 0x0400047A RID: 1146
		Private CurrentModItemBmp As Bitmap

		' Token: 0x0400047B RID: 1147
		Private bmp As Bitmap

		' Token: 0x0400047C RID: 1148
		Private bmp_cache As Bitmap

		' Token: 0x0400047D RID: 1149
		Private gLastMousePos As Point

		' Token: 0x0400047E RID: 1150
		Private g_LastMouseDownPos As Point

		' Token: 0x0400047F RID: 1151
		Private gLastBackBufferOrigin As Point

		' Token: 0x04000480 RID: 1152
		Private gCurrentRegionSegmentOrigin As Point

		' Token: 0x04000481 RID: 1153
		Private LeftMouseClickActive As Boolean

		' Token: 0x04000482 RID: 1154
		Private LastClickedTvModuleNode As ModItemTvNode

		' Token: 0x04000483 RID: 1155
		Private CurrentContextMenuTvModuleNode As ModItemTvNode

		' Token: 0x04000484 RID: 1156
		Private g_ShowPaletteNames As Boolean

		' Token: 0x04000485 RID: 1157
		Private g_ShowPaletteResRefs As Boolean

		' Token: 0x04000486 RID: 1158
		Private g_CurrentPaletteName As String

		' Token: 0x04000487 RID: 1159
		Private g_CurrentPaletteModItemType As Integer

		' Token: 0x04000488 RID: 1160
		Private g_ProjectPath As String

		' Token: 0x04000489 RID: 1161
		Private g_GlobalTemplatesPath As String

		' Token: 0x0400048A RID: 1162
		Private g_UserPalettePath As String

		' Token: 0x0400048B RID: 1163
		Private g_IsDrawingRegion As Boolean

		' Token: 0x0400048C RID: 1164
		Private g_RegionPointList As ArrayList

		' Token: 0x0400048D RID: 1165
		Private g_RegionResRef As String

		' Token: 0x0400048E RID: 1166
		Private g_MapName As String

		' Token: 0x0400048F RID: 1167
		Private g_mapImageName As String

		' Token: 0x04000490 RID: 1168
		Private g_LargeMapAvailable As Boolean

		' Token: 0x04000491 RID: 1169
		Private g_SmallMapAvailable As Boolean

		' Token: 0x04000492 RID: 1170
		Private g_UsingLargeMap As Boolean

		' Token: 0x04000493 RID: 1171
		Private g_AltSmallMapAvailable As Boolean

		' Token: 0x04000494 RID: 1172
		Private g_MapTypeInUse As Integer

		' Token: 0x04000495 RID: 1173
		Private g_mapsPath As String

		' Token: 0x04000496 RID: 1174
		Private bPaletteVisible As Boolean

		' Token: 0x04000497 RID: 1175
		Private bModElementsVisible As Boolean

		' Token: 0x04000498 RID: 1176
		Private bConfirmDeletes As Boolean

		' Token: 0x04000499 RID: 1177
		Private bShowLocatorRay As Boolean

		' Token: 0x0400049A RID: 1178
		Private dModuleElementIndicatorSize As Decimal

		' Token: 0x0400049B RID: 1179
		Private gModuleEditorModOutputPath As String

		' Token: 0x0400049C RID: 1180
		Private gModuleEditorSettings As ModuleEditorProjectOptions

		' Token: 0x0400049D RID: 1181
		Private g_tvModule_TreeOpenPaths As ArrayList

		' Token: 0x0400049E RID: 1182
		Private g_UserPalettteFsw As FileSystemWatcher

		' Token: 0x0400049F RID: 1183
		Private g_ProjectFsw As FileSystemWatcher

		' Token: 0x040004A0 RID: 1184
		Public Shared g_form As frmModule_Editor

		' Token: 0x040004A1 RID: 1185
		Private g_ModuleStartPoint As PointF

		' Token: 0x040004A2 RID: 1186
		Private f As frmMain

		' Token: 0x040004A3 RID: 1187
		Private htK1Tags As Hashtable

		' Token: 0x040004A4 RID: 1188
		Private htK2Tags As Hashtable

		' Token: 0x040004A5 RID: 1189
		Private htTemplateBifFiles As Hashtable

		' Token: 0x040004A6 RID: 1190
		Private MapCalibratePt1 As Point

		' Token: 0x040004A7 RID: 1191
		Private MapCalibratePt2 As Point

		' Token: 0x040004A8 RID: 1192
		Private CalibrationToolsVis As Boolean

		' Token: 0x040004A9 RID: 1193
		Private labelFont As Font

		' Token: 0x040004AA RID: 1194
		Private labelBrush As SolidBrush

		' Token: 0x040004AB RID: 1195
		Private tb As Integer

		' Token: 0x040004AC RID: 1196
		Private lcl As Integer
	End Class
End Namespace
