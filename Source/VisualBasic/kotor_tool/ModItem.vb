Imports System
Imports System.Collections
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200005D RID: 93
	Public Class ModItem
		Implements IComparable

		' Token: 0x0600090B RID: 2315 RVA: 0x0026CD98 File Offset: 0x0026BD98
		Public Sub New(ScreenX As Integer, ScreenY As Integer, X As Single, Y As Single, ResRef As String, path As String)
			Me._screenX = ScreenX
			Me._screenY = ScreenY
			Me._x = X
			Me._y = Y
			Me._path = path
			Me._ResRef = ResRef
		End Sub

		' Token: 0x0600090C RID: 2316 RVA: 0x0026CDD0 File Offset: 0x0026BDD0
		Public Sub New(ScreenX As Integer, ScreenY As Integer, X As Single, Y As Single, ResRef As String, path As String, parent As ModItem)
			Me.New(ScreenX, ScreenY, X, Y, ResRef, path)
			Me._Parent = parent
		End Sub

		' Token: 0x0600090D RID: 2317 RVA: 0x0026CDEC File Offset: 0x0026BDEC
		Public Sub New(ScreenX As Integer, ScreenY As Integer, X As Single, Y As Single, ResRef As String, path As String, dummy As Boolean, Tag As String)
			Me.New(ScreenX, ScreenY, X, Y, ResRef, path)
			Me._localTag = Tag
		End Sub

		' Token: 0x170002B6 RID: 694
		' (get) Token: 0x0600090E RID: 2318 RVA: 0x0026CE08 File Offset: 0x0026BE08
		' (set) Token: 0x0600090F RID: 2319 RVA: 0x0026CE1C File Offset: 0x0026BE1C
		Public Property ScreenX As Integer
			Get
				Return Me._screenX
			End Get
			Set(value As Integer)
				Me._screenX = value
			End Set
		End Property

		' Token: 0x170002B7 RID: 695
		' (get) Token: 0x06000910 RID: 2320 RVA: 0x0026CE28 File Offset: 0x0026BE28
		' (set) Token: 0x06000911 RID: 2321 RVA: 0x0026CE3C File Offset: 0x0026BE3C
		Public Property ScreenY As Integer
			Get
				Return Me._screenY
			End Get
			Set(value As Integer)
				Me._screenY = value
			End Set
		End Property

		' Token: 0x170002B8 RID: 696
		' (get) Token: 0x06000912 RID: 2322 RVA: 0x0026CE48 File Offset: 0x0026BE48
		' (set) Token: 0x06000913 RID: 2323 RVA: 0x0026CE5C File Offset: 0x0026BE5C
		Public Property X As Single
			Get
				Return Me._x
			End Get
			Set(value As Single)
				Me._x = value
			End Set
		End Property

		' Token: 0x170002B9 RID: 697
		' (get) Token: 0x06000914 RID: 2324 RVA: 0x0026CE68 File Offset: 0x0026BE68
		' (set) Token: 0x06000915 RID: 2325 RVA: 0x0026CE7C File Offset: 0x0026BE7C
		Public Property Y As Single
			Get
				Return Me._y
			End Get
			Set(value As Single)
				Me._y = value
			End Set
		End Property

		' Token: 0x170002BA RID: 698
		' (get) Token: 0x06000916 RID: 2326 RVA: 0x0026CE88 File Offset: 0x0026BE88
		' (set) Token: 0x06000917 RID: 2327 RVA: 0x0026CE9C File Offset: 0x0026BE9C
		Public Property Z As Single
			Get
				Return Me._z
			End Get
			Set(value As Single)
				Me._z = value
			End Set
		End Property

		' Token: 0x170002BB RID: 699
		' (get) Token: 0x06000918 RID: 2328 RVA: 0x0026CEA8 File Offset: 0x0026BEA8
		' (set) Token: 0x06000919 RID: 2329 RVA: 0x0026CEBC File Offset: 0x0026BEBC
		Public Property Path As String
			Get
				Return Me._path
			End Get
			Set(value As String)
				Me._path = value
			End Set
		End Property

		' Token: 0x170002BC RID: 700
		' (get) Token: 0x0600091A RID: 2330 RVA: 0x0026CEC8 File Offset: 0x0026BEC8
		' (set) Token: 0x0600091B RID: 2331 RVA: 0x0026CEDC File Offset: 0x0026BEDC
		Public Property ResRef As String
			Get
				Return Me._ResRef
			End Get
			Set(value As String)
				Me._ResRef = value
			End Set
		End Property

		' Token: 0x170002BD RID: 701
		' (get) Token: 0x0600091C RID: 2332 RVA: 0x0026CEE8 File Offset: 0x0026BEE8
		' (set) Token: 0x0600091D RID: 2333 RVA: 0x0026CEFC File Offset: 0x0026BEFC
		Public Property ItemType As Integer
			Get
				Return Me._ItemType
			End Get
			Set(value As Integer)
				Me._ItemType = value
			End Set
		End Property

		' Token: 0x170002BE RID: 702
		' (get) Token: 0x0600091E RID: 2334 RVA: 0x0026CF08 File Offset: 0x0026BF08
		' (set) Token: 0x0600091F RID: 2335 RVA: 0x0026CF1C File Offset: 0x0026BF1C
		Public Property XPosAccessor As String
			Get
				Return Me._XPosAccessor
			End Get
			Set(value As String)
				Me._XPosAccessor = value
			End Set
		End Property

		' Token: 0x170002BF RID: 703
		' (get) Token: 0x06000920 RID: 2336 RVA: 0x0026CF28 File Offset: 0x0026BF28
		' (set) Token: 0x06000921 RID: 2337 RVA: 0x0026CF3C File Offset: 0x0026BF3C
		Public Property YPosAccessor As String
			Get
				Return Me._YPosAccessor
			End Get
			Set(value As String)
				Me._YPosAccessor = value
			End Set
		End Property

		' Token: 0x170002C0 RID: 704
		' (get) Token: 0x06000922 RID: 2338 RVA: 0x0026CF48 File Offset: 0x0026BF48
		' (set) Token: 0x06000923 RID: 2339 RVA: 0x0026CF5C File Offset: 0x0026BF5C
		Public Property ZPosAccessor As String
			Get
				Return Me._ZPosAccessor
			End Get
			Set(value As String)
				Me._ZPosAccessor = value
			End Set
		End Property

		' Token: 0x170002C1 RID: 705
		' (get) Token: 0x06000924 RID: 2340 RVA: 0x0026CF68 File Offset: 0x0026BF68
		Public ReadOnly Property XPosPath As String
			Get
				Return Me._path + "." + Me._XPosAccessor
			End Get
		End Property

		' Token: 0x170002C2 RID: 706
		' (get) Token: 0x06000925 RID: 2341 RVA: 0x0026CF8C File Offset: 0x0026BF8C
		Public ReadOnly Property YPosPath As String
			Get
				Return Me._path + "." + Me._YPosAccessor
			End Get
		End Property

		' Token: 0x170002C3 RID: 707
		' (get) Token: 0x06000926 RID: 2342 RVA: 0x0026CFB0 File Offset: 0x0026BFB0
		Public ReadOnly Property ZPosPath As String
			Get
				Return Me._path + "." + Me._ZPosAccessor
			End Get
		End Property

		' Token: 0x170002C4 RID: 708
		' (get) Token: 0x06000927 RID: 2343 RVA: 0x0026CFD4 File Offset: 0x0026BFD4
		' (set) Token: 0x06000928 RID: 2344 RVA: 0x0026CFE8 File Offset: 0x0026BFE8
		Public Property GeometryList As ArrayList
			Get
				Return Me._GeometryList
			End Get
			Set(value As ArrayList)
				Me._GeometryList = value
			End Set
		End Property

		' Token: 0x170002C5 RID: 709
		' (get) Token: 0x06000929 RID: 2345 RVA: 0x0026CFF4 File Offset: 0x0026BFF4
		' (set) Token: 0x0600092A RID: 2346 RVA: 0x0026D008 File Offset: 0x0026C008
		Public Property SpawnPointList As ArrayList
			Get
				Return Me._spawnPointList
			End Get
			Set(value As ArrayList)
				Me._spawnPointList = value
			End Set
		End Property

		' Token: 0x170002C6 RID: 710
		' (get) Token: 0x0600092B RID: 2347 RVA: 0x0026D014 File Offset: 0x0026C014
		Public ReadOnly Property FileExtension As String
			Get
				Select Case Me._ItemType
					Case 2025
						Return ".uti"
					Case 2027
						Return ".utc"
					Case 2032
						Return ".utt"
					Case 2035
						Return ".uts"
					Case 2040
						Return ".ute"
					Case 2042
						Return ".utd"
					Case 2044
						Return ".utp"
					Case 2051
						Return ".utm"
					Case 2058
						Return ".utw"
				End Select
				Dim text As String
				Return text
			End Get
		End Property

		' Token: 0x170002C7 RID: 711
		' (get) Token: 0x0600092C RID: 2348 RVA: 0x0026D0F4 File Offset: 0x0026C0F4
		Public ReadOnly Property FileName As String
			Get
				Return Me._ResRef + Me.FileExtension
			End Get
		End Property

		' Token: 0x170002C8 RID: 712
		' (get) Token: 0x0600092D RID: 2349 RVA: 0x0026D114 File Offset: 0x0026C114
		' (set) Token: 0x0600092E RID: 2350 RVA: 0x0026D128 File Offset: 0x0026C128
		Public Property Parent As ModItem
			Get
				Return Me._Parent
			End Get
			Set(value As ModItem)
				Me._Parent = value
			End Set
		End Property

		' Token: 0x170002C9 RID: 713
		' (get) Token: 0x0600092F RID: 2351 RVA: 0x0026D134 File Offset: 0x0026C134
		' (set) Token: 0x06000930 RID: 2352 RVA: 0x0026D148 File Offset: 0x0026C148
		Public Property Tag As String
			Get
				Return Me._localTag
			End Get
			Set(value As String)
				Me._localTag = value
			End Set
		End Property

		' Token: 0x06000931 RID: 2353 RVA: 0x0026D154 File Offset: 0x0026C154
		Public Function IsEqual(mi As ModItem) As Boolean
			Return mi IsNot Nothing AndAlso mi.ItemType = Me.ItemType AndAlso mi.X = Me.X AndAlso mi.Y = Me.Y AndAlso StringType.StrCmp(mi.ResRef, Me.ResRef, False) = 0
		End Function

		' Token: 0x06000932 RID: 2354 RVA: 0x0026D1A8 File Offset: 0x0026C1A8
		Public Function CompareTo(obj As Object) As Integer Implements System.IComparable.CompareTo
			Return String.Compare(Me.ResRef, CType(obj, ModItem).ResRef)
		End Function

		' Token: 0x040004AD RID: 1197
		Private _screenX As Integer

		' Token: 0x040004AE RID: 1198
		Private _screenY As Integer

		' Token: 0x040004AF RID: 1199
		Private _x As Single

		' Token: 0x040004B0 RID: 1200
		Private _y As Single

		' Token: 0x040004B1 RID: 1201
		Private _z As Single

		' Token: 0x040004B2 RID: 1202
		Private _ResRef As String

		' Token: 0x040004B3 RID: 1203
		Private _path As String

		' Token: 0x040004B4 RID: 1204
		Private _localTag As String

		' Token: 0x040004B5 RID: 1205
		Private _ItemType As Integer

		' Token: 0x040004B6 RID: 1206
		Private _XPosAccessor As String

		' Token: 0x040004B7 RID: 1207
		Private _YPosAccessor As String

		' Token: 0x040004B8 RID: 1208
		Private _ZPosAccessor As String

		' Token: 0x040004B9 RID: 1209
		Private _GeometryList As ArrayList

		' Token: 0x040004BA RID: 1210
		Private _spawnPointList As ArrayList

		' Token: 0x040004BB RID: 1211
		Private _Parent As ModItem

		' Token: 0x040004BC RID: 1212
		Public Const ItemTypeCreature As Integer = 2027

		' Token: 0x040004BD RID: 1213
		Public Const ItemTypePlaceable As Integer = 2044

		' Token: 0x040004BE RID: 1214
		Public Const ItemTypeDoor As Integer = 2042

		' Token: 0x040004BF RID: 1215
		Public Const ItemTypeSound As Integer = 2035

		' Token: 0x040004C0 RID: 1216
		Public Const ItemTypeWaypoint As Integer = 2058

		' Token: 0x040004C1 RID: 1217
		Public Const ItemTypeCamera As Integer = 6

		' Token: 0x040004C2 RID: 1218
		Public Const ItemTypeStore As Integer = 2051

		' Token: 0x040004C3 RID: 1219
		Public Const ItemTypeTrigger As Integer = 2032

		' Token: 0x040004C4 RID: 1220
		Public Const ItemTypeEncounter As Integer = 2040

		' Token: 0x040004C5 RID: 1221
		Public Const ItemTypeEncounterSpawnPoint As Integer = 12040

		' Token: 0x040004C6 RID: 1222
		Public Const ItemTypeItem As Integer = 2025

		' Token: 0x040004C7 RID: 1223
		Public Const ItemTypeStartPoint As Integer = 5000
	End Class
End Namespace
