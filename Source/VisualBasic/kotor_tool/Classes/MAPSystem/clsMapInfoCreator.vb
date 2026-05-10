Imports System
Imports System.Collections
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000026 RID: 38
	Public Class clsMapInfoCreator
		' Token: 0x060000CF RID: 207 RVA: 0x00220A78 File Offset: 0x0021FA78
		Public Sub New()
			Me.mi = New MapInfo()
		End Sub

		' Token: 0x060000D0 RID: 208 RVA: 0x00220A8C File Offset: 0x0021FA8C
		Public Sub write(InstalledAppPath As String)
			Me.mi.Version = "2005"
			Me.mi.MapList = New ArrayList()
			Dim map As MapInfo.Map = New MapInfo.Map()
			map.MapName = "m02aa"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Taris - South Apartments"
			map.L = True
			map.S = True
			map.LXMul = 26.93D
			map.LYMul = 26.58D
			map.LXOff = 1775
			map.LYOff = 1857
			map.SXMul = 12.47D
			map.SYMul = 12.54D
			map.SXOff = 813
			map.SYOff = 799
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m02ac"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Taris - Upper City South"
			map.L = True
			map.S = True
			map.LXMul = 26.82D
			map.LYMul = 26.82D
			map.LXOff = 1385
			map.LYOff = 355
			map.SXMul = 13.43D
			map.SYMul = 13.43D
			map.SXOff = 695
			map.SYOff = 179
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m08aa"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Taris - Davik's Estate"
			map.L = True
			map.LXMul = 23.5D
			map.LYMul = 23.5D
			map.LXOff = 164
			map.LYOff = 196
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m10aa"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Taris - Black Vulkar Base 1"
			map.L = True
			map.S = True
			map.LXMul = 34.78D
			map.LYMul = 34.78D
			map.LXOff = 3268
			map.LYOff = 1473
			map.SXMul = 17.39D
			map.SYMul = 17.39D
			map.SXOff = 1634
			map.SYOff = 737
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m10ab"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Taris - Black Vulkar Base 2"
			map.L = True
			map.S = True
			map.LXMul = 43.88D
			map.LYMul = 44D
			map.LXOff = 1451
			map.LYOff = 2644
			map.SXMul = 21.94D
			map.SYMul = 21.94D
			map.SXOff = 719
			map.SYOff = 1320
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m10ac"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Taris - Black Vulkar Base 3"
			map.L = True
			map.S = True
			map.LXMul = 38.4D
			map.LYMul = 38.4D
			map.LXOff = 1188
			map.LYOff = 1145
			map.SXMul = 19.2D
			map.SYMul = 19.2D
			map.SXOff = 590
			map.SYOff = 570
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m11aa"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Taris - Hidden Bek Base 1"
			map.S = True
			map.SXMul = 20.1D
			map.SYMul = 20.1D
			map.SXOff = 432
			map.SYOff = 262
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m16aa"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Dantooine - Sandral Estate"
			map.S = True
			map.SXMul = 31.91D
			map.SYMul = 31.91D
			map.SXOff = 446
			map.SYOff = 813
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m42aa"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Unknown World - Elder Settlement"
			map.S = True
			map.SXMul = 11.66D
			map.SYMul = 11.66D
			map.SXOff = 93
			map.SYOff = 170
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "m43aa"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Unknown World - Rakatan Settlement"
			map.S = True
			map.SXMul = 10.02D
			map.SYMul = 10.02D
			map.SXOff = 9
			map.SYOff = 114
			map.L = True
			map.LXMul = 20.06D
			map.LYMul = 20.5D
			map.LXOff = 50
			map.LYOff = 311
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "151har"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Harbinger - Command Deck"
			map.S = False
			map.SXMul = 16.08D
			map.SYMul = 16.08D
			map.SXOff = -942
			map.SYOff = -838
			map.L = True
			map.LXMul = 32.62D
			map.LYMul = 32.62D
			map.LXOff = -135
			map.LYOff = 1139
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "201tel"
			map.S = True
			map.MapAssembler = "T7Nowhere"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Citadel Station Docking Module"
			map.SXMul = 16.08D
			map.SYMul = 16.08D
			map.SXOff = -942
			map.SYOff = -838
			map.L = True
			map.LXMul = 32.16D
			map.LYMul = 32.16D
			map.LXOff = -1884
			map.LYOff = -1683
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "203tel"
			map.MapAssembler = "T7Nowhere"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Citadel Station Residential 082 East"
			map.S = True
			map.SXMul = 14D
			map.SYMul = 14D
			map.SXOff = -696
			map.SYOff = -752
			map.L = True
			map.LXMul = 27.98D
			map.LYMul = 28.09D
			map.LXOff = -1393
			map.LYOff = -1505
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "204tel"
			map.MapAssembler = "T7Nowhere"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Citadel Station Residential 082 West"
			map.S = True
			map.SXMul = 21.8D
			map.SYMul = 21.8D
			map.SXOff = -1861
			map.SYOff = -1428
			map.L = True
			map.LXMul = 43.6D
			map.LYMul = 43.6D
			map.LXOff = -3722
			map.LYOff = -2855
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "207tel"
			map.MapAssembler = "T7Nowhere"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Citadel Station Cantina"
			map.S = True
			map.SXMul = 33.56D
			map.SYMul = 33.56D
			map.SXOff = -204
			map.SYOff = -1406
			map.L = True
			map.LXMul = 67D
			map.LYMul = 67D
			map.LXOff = -408
			map.LYOff = -2812
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "208tel"
			map.MapAssembler = "T7Nowhere"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Bumani Exchange Corp."
			map.S = True
			map.SXMul = 19.7D
			map.SYMul = 19.7D
			map.SXOff = -841
			map.SYOff = -253
			map.L = True
			map.LXMul = 39.46D
			map.LYMul = 39.46D
			map.LXOff = -1686
			map.LYOff = -509
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "502ond"
			map.MapAssembler = "Gsccc"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Onderon - Merchant Quarter"
			map.S = True
			map.SXMul = 14.29D
			map.SYMul = 14.29D
			map.SXOff = -379
			map.SYOff = -1521
			map.L = True
			map.LXMul = 28.6D
			map.LYMul = 28.6D
			map.LXOff = -757
			map.LYOff = -3040
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "904mal"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Malachor V - Trayus Core"
			map.S = True
			map.SXMul = 12.88D
			map.SYMul = 12.88D
			map.SXOff = -1603
			map.SYOff = -1288
			map.L = True
			map.LXMul = 25D
			map.LYMul = 25D
			map.LXOff = -3103
			map.LYOff = -2490
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Malachor V - Trayus Proving Grounds"
			map.MapName = "906mal"
			map.S = True
			map.SXMul = 7.07D
			map.SYMul = 7.07D
			map.SXOff = 415
			map.SYOff = -589
			map.L = True
			map.LXMul = 28.34D
			map.LYMul = 28.36D
			map.LXOff = 1669
			map.LYOff = -2354
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "851nih"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Ravager - Command Deck"
			map.L = True
			map.LXMul = 21.2473D
			map.LYMul = 21.2747D
			map.LXOff = -840
			map.LYOff = -1173
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "101per"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Peragus - Administration Level"
			map.L = True
			map.LXMul = 23.3D
			map.LYMul = 23.3D
			map.LXOff = -1125
			map.LYOff = -3155
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "102per"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Peragus - Mines"
			map.L = True
			map.LXMul = 21.61355D
			map.LYMul = 21.63151D
			map.LXOff = -1932
			map.LYOff = -2016
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "503ond"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Onderon - Iziz Cantina"
			map.S = True
			map.SXMul = 16.33915D
			map.SYMul = 16.4017D
			map.SXOff = 1598
			map.SYOff = 1262
			map.L = True
			map.LXMul = 65.54648D
			map.LYMul = 65.67685D
			map.LXOff = 6348
			map.LYOff = 5060
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "302nar"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Nar Shaddaa - Refugee Area"
			map.S = True
			map.SXMul = 7.553093D
			map.SYMul = 7.559947D
			map.SXOff = -645
			map.SYOff = 306
			map.L = True
			map.LXMul = 30.2465D
			map.LYMul = 30.23979D
			map.LXOff = -2586
			map.LYOff = 1226
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "301nar"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Nar Shaddaa - Refugee Landing Pad"
			map.L = True
			map.LXMul = 28.904D
			map.LYMul = 28.8827D
			map.LXOff = -4582
			map.LYOff = -1818
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "303nar"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Nar Shaddaa - Docks"
			map.L = True
			map.LXMul = 34.44209D
			map.LYMul = 34.43863D
			map.LXOff = -3112
			map.LYOff = -1843
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "298tel"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - ???"
			map.S = True
			map.SXMul = 14.33659D
			map.SYMul = 14.33602D
			map.SXOff = -1390
			map.SYOff = 722
			map.L = True
			map.LXMul = 28.68834D
			map.LYMul = 28.68133D
			map.LXOff = -2782
			map.LYOff = 1447
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "610dan"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Dantooine - Enclave Sublevel"
			map.L = True
			map.LXMul = 18.0677D
			map.LYMul = 18.06721D
			map.LXOff = -1408
			map.LYOff = -3437
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "001ebo"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Ebon Hawk - Interior"
			map.S = True
			map.SXMul = 13.0136D
			map.SYMul = 12.94298D
			map.SXOff = 243
			map.SYOff = 83
			map.L = True
			map.LXMul = 51.45989D
			map.LYMul = 51.51605D
			map.LXOff = 945
			map.LYOff = 317
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "002ebo"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Ebon Hawk - Exterior"
			map.S = True
			map.SXMul = 20.70314D
			map.SYMul = 20.71898D
			map.SXOff = -509
			map.SYOff = -562
			map.L = True
			map.LXMul = 41.4488D
			map.LYMul = 41.46269D
			map.LXOff = -1033
			map.LYOff = -1125
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "103per"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Peragus - Fuel Depot"
			map.S = True
			map.SXMul = 7.28313D
			map.SYMul = 7.259841D
			map.SXOff = -746
			map.SYOff = -528
			map.L = True
			map.LXMul = 29.09742D
			map.LYMul = 29.07998D
			map.LXOff = -2987
			map.LYOff = -2106
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "105per"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Peragus - Dormitories"
			map.S = True
			map.SXMul = 8.952945D
			map.SYMul = 8.940107D
			map.SXOff = -681
			map.SYOff = -571
			map.L = True
			map.LXMul = 35.80223D
			map.LYMul = 35.80211D
			map.LXOff = -2704
			map.LYOff = -2272
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "401dxn"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Dxun - Jungle Landing"
			map.S = True
			map.SXMul = 7.528076D
			map.SYMul = 7.580755D
			map.SXOff = -1552
			map.SYOff = -1328
			map.L = True
			map.LXMul = 15.065D
			map.LYMul = 15.17198D
			map.LXOff = -3106
			map.LYOff = -2743
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "402dxn"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Dxun - Jungle"
			map.S = True
			map.SXMul = 4.062005D
			map.SYMul = 4.065509D
			map.SXOff = -537
			map.SYOff = -464
			map.L = True
			map.LXMul = 16.26198D
			map.LYMul = 16.26204D
			map.LXOff = -2151
			map.LYOff = -1838
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "262tel"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Secret Academy"
			map.S = True
			map.SXMul = 14.563D
			map.SYMul = 14.42678D
			map.SXOff = -1003
			map.SYOff = -1984
			map.L = True
			map.LXMul = 18.01213D
			map.LYMul = 17.84771D
			map.LXOff = -1241
			map.LYOff = -2427
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "853nih"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Ravager - cutscene"
			map.S = True
			map.SXMul = 9.61601D
			map.SYMul = 9.586327D
			map.SXOff = -2408
			map.SYOff = 100
			map.L = True
			map.LXMul = 38.50027D
			map.LYMul = 38.50385D
			map.LXOff = -9673
			map.LYOff = 425
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "106per"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Peragus - Hangar Bay"
			map.S = True
			map.SXMul = 13.735D
			map.SYMul = 13.71459D
			map.SXOff = -934
			map.SYOff = -471
			map.L = True
			map.LXMul = 27.42084D
			map.LYMul = 27.42918D
			map.LXOff = -1870
			map.LYOff = -932
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "202tel"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Citadel Station Entertainment 081"
			map.S = True
			map.SXMul = 21.50936D
			map.SYMul = 21.51281D
			map.SXOff = -891
			map.SYOff = -1471
			map.L = True
			map.LXMul = 43.01873D
			map.LYMul = 43.04383D
			map.LXOff = -1784
			map.LYOff = -2934
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "231tel"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Restoration Zone"
			map.S = True
			map.SXMul = 5.424731D
			map.SYMul = 5.426398D
			map.SXOff = 1165
			map.SYOff = 901
			map.L = True
			map.LXMul = 10.85743D
			map.LYMul = 10.8528D
			map.LXOff = 2333
			map.LYOff = 1819
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "232tel"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Underground Base"
			map.S = True
			map.SXMul = 10.71395D
			map.SYMul = 10.72112D
			map.SXOff = -1072
			map.SYOff = -125
			map.L = True
			map.LXMul = 21.45145D
			map.LYMul = 21.44224D
			map.LXOff = -2143
			map.LYOff = -250
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "104per"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Peragus - Asteroid Exterior"
			map.S = True
			map.SXMul = 11.79846D
			map.SYMul = 11.78324D
			map.SXOff = -635
			map.SYOff = -2012
			map.L = True
			map.LXMul = 47.19384D
			map.LYMul = 47.17387D
			map.LXOff = -2543
			map.LYOff = -8030
			map.AltS = True
			map.AltSXMul = 37.00609D
			map.AltSYMul = 37.00414D
			map.AltSXOff = -9
			map.AltSYOff = 1058
			Me.mi.MapList.Add(map)
			map = New MapInfo.Map()
			map.MapName = "233tel"
			map.MapAssembler = "Fred Tetra"
			map.MapCalibrator = "Fred Tetra"
			map.ModuleName = "Telos - Czerka Site"
			map.S = True
			map.SXMul = 9.043454D
			map.SYMul = 9.017874D
			map.SXOff = 4060
			map.SYOff = 1566
			map.L = True
			map.LXMul = 18.08691D
			map.LYMul = 18.03575D
			map.LXOff = 8124
			map.LYOff = 3137
			Me.mi.MapList.Add(map)
			Dim fileStream As FileStream = File.Create("MapInfo.bfd")
			Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
			binaryFormatter.Serialize(fileStream, Me.mi)
			fileStream.Close()
			fileStream = File.Create(InstalledAppPath + "MapInfo.bfd")
			binaryFormatter.Serialize(fileStream, Me.mi)
			fileStream.Close()
			fileStream = File.Create("maptable.txt")
			Dim streamWriter As StreamWriter = New StreamWriter(fileStream)
			Dim arrayList As ArrayList = New ArrayList()
			Try
				For Each obj As Object In Me.mi.MapList
					Dim map2 As MapInfo.Map = CType(obj, MapInfo.Map)
					Dim text As String = String.Concat(New String() { map2.MapName, "|", map2.ModuleName, "|", map2.MapAssembler, "|" })
					If map2.S Then
						text += "y|"
					Else
						text += "n|"
					End If
					If map2.L Then
						text += "y|"
					Else
						text += "n|"
					End If
					arrayList.Add(text)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
			arrayList.Sort()
			Try
				For Each obj2 As Object In arrayList
					Dim text As String = StringType.FromObject(obj2)
					streamWriter.WriteLine(text)
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					CType(enumerator2, IDisposable).Dispose()
				End If
			End Try
			streamWriter.Close()
		End Sub

		' Token: 0x040000FA RID: 250
		Private mi As MapInfo
	End Class
End Namespace
