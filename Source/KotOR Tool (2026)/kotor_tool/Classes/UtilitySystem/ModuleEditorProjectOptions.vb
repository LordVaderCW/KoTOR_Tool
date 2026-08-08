Imports System

Namespace kotor_tool
	' Token: 0x0200008A RID: 138
    <Serializable()> _
 Public Class ModuleEditorProjectOptions
        ' Token: 0x06001725 RID: 5925 RVA: 0x002CB4D4 File Offset: 0x002CA4D4
        Public Sub New()
            Me._moduleEditorModOutputPath = ""
            Me._useHiResMap = True
            Me._filterShowCreatures = True
            Me._filterShowDoors = True
            Me._filterShowPlaceables = True
            Me._filterShowEncounters = True
            Me._filterShowTriggers = True
            Me._filterShowMerchants = True
            Me._filterShowSounds = True
            Me._filterShowWaypoints = True
            Me._mapSize = "small"
            Me._showItemLabels = True
            Me._showTagsOnModulePalette = False
            Me._LastScrollPosX = 0
            Me._LastScrollPosY = 0
        End Sub

        ' Token: 0x170008C5 RID: 2245
        ' (get) Token: 0x06001726 RID: 5926 RVA: 0x002CB558 File Offset: 0x002CA558
        ' (set) Token: 0x06001727 RID: 5927 RVA: 0x002CB56C File Offset: 0x002CA56C
        Public Property ModuleEditorModOutputPath() As String
            Get
                Return Me._moduleEditorModOutputPath
            End Get
            Set(ByVal value As String)
                Me._moduleEditorModOutputPath = value
            End Set
        End Property

        ' Token: 0x170008C6 RID: 2246
        ' (get) Token: 0x06001728 RID: 5928 RVA: 0x002CB578 File Offset: 0x002CA578
        ' (set) Token: 0x06001729 RID: 5929 RVA: 0x002CB58C File Offset: 0x002CA58C
        Public Property UseHiResMap() As Boolean
            Get
                Return Me._useHiResMap
            End Get
            Set(ByVal value As Boolean)
                Me._useHiResMap = value
            End Set
        End Property

        ' Token: 0x170008C7 RID: 2247
        ' (get) Token: 0x0600172A RID: 5930 RVA: 0x002CB598 File Offset: 0x002CA598
        ' (set) Token: 0x0600172B RID: 5931 RVA: 0x002CB5AC File Offset: 0x002CA5AC
        Public Property FilterShowCreatures() As Boolean
            Get
                Return Me._filterShowCreatures
            End Get
            Set(ByVal value As Boolean)
                Me._filterShowCreatures = value
            End Set
        End Property

        ' Token: 0x170008C8 RID: 2248
        ' (get) Token: 0x0600172C RID: 5932 RVA: 0x002CB5B8 File Offset: 0x002CA5B8
        ' (set) Token: 0x0600172D RID: 5933 RVA: 0x002CB5CC File Offset: 0x002CA5CC
        Public Property FilterShowDoors() As Boolean
            Get
                Return Me._filterShowDoors
            End Get
            Set(ByVal value As Boolean)
                Me._filterShowDoors = value
            End Set
        End Property

        ' Token: 0x170008C9 RID: 2249
        ' (get) Token: 0x0600172E RID: 5934 RVA: 0x002CB5D8 File Offset: 0x002CA5D8
        ' (set) Token: 0x0600172F RID: 5935 RVA: 0x002CB5EC File Offset: 0x002CA5EC
        Public Property FilterShowPlaceables() As Boolean
            Get
                Return Me._filterShowPlaceables
            End Get
            Set(ByVal value As Boolean)
                Me._filterShowPlaceables = value
            End Set
        End Property

        ' Token: 0x170008CA RID: 2250
        ' (get) Token: 0x06001730 RID: 5936 RVA: 0x002CB5F8 File Offset: 0x002CA5F8
        ' (set) Token: 0x06001731 RID: 5937 RVA: 0x002CB60C File Offset: 0x002CA60C
        Public Property FilterShowEncounters() As Boolean
            Get
                Return Me._filterShowEncounters
            End Get
            Set(ByVal value As Boolean)
                Me._filterShowEncounters = value
            End Set
        End Property

        ' Token: 0x170008CB RID: 2251
        ' (get) Token: 0x06001732 RID: 5938 RVA: 0x002CB618 File Offset: 0x002CA618
        ' (set) Token: 0x06001733 RID: 5939 RVA: 0x002CB62C File Offset: 0x002CA62C
        Public Property FilterShowTriggers() As Boolean
            Get
                Return Me._filterShowTriggers
            End Get
            Set(ByVal value As Boolean)
                Me._filterShowTriggers = value
            End Set
        End Property

        ' Token: 0x170008CC RID: 2252
        ' (get) Token: 0x06001734 RID: 5940 RVA: 0x002CB638 File Offset: 0x002CA638
        ' (set) Token: 0x06001735 RID: 5941 RVA: 0x002CB64C File Offset: 0x002CA64C
        Public Property FilterShowMerchants() As Boolean
            Get
                Return Me._filterShowMerchants
            End Get
            Set(ByVal value As Boolean)
                Me._filterShowMerchants = value
            End Set
        End Property

        ' Token: 0x170008CD RID: 2253
        ' (get) Token: 0x06001736 RID: 5942 RVA: 0x002CB658 File Offset: 0x002CA658
        ' (set) Token: 0x06001737 RID: 5943 RVA: 0x002CB66C File Offset: 0x002CA66C
        Public Property FilterShowSounds() As Boolean
            Get
                Return Me._filterShowSounds
            End Get
            Set(ByVal value As Boolean)
                Me._filterShowSounds = value
            End Set
        End Property

        ' Token: 0x170008CE RID: 2254
        ' (get) Token: 0x06001738 RID: 5944 RVA: 0x002CB678 File Offset: 0x002CA678
        ' (set) Token: 0x06001739 RID: 5945 RVA: 0x002CB68C File Offset: 0x002CA68C
        Public Property FilterShowWaypoints() As Boolean
            Get
                Return Me._filterShowWaypoints
            End Get
            Set(ByVal value As Boolean)
                Me._filterShowWaypoints = value
            End Set
        End Property

        ' Token: 0x170008CF RID: 2255
        ' (get) Token: 0x0600173A RID: 5946 RVA: 0x002CB698 File Offset: 0x002CA698
        ' (set) Token: 0x0600173B RID: 5947 RVA: 0x002CB6AC File Offset: 0x002CA6AC
        Public Property MapSize() As String
            Get
                Return Me._mapSize
            End Get
            Set(ByVal value As String)
                Me._mapSize = value
            End Set
        End Property

        ' Token: 0x170008D0 RID: 2256
        ' (get) Token: 0x0600173C RID: 5948 RVA: 0x002CB6B8 File Offset: 0x002CA6B8
        ' (set) Token: 0x0600173D RID: 5949 RVA: 0x002CB6CC File Offset: 0x002CA6CC
        Public Property ShowItemLabels() As Boolean
            Get
                Return Me._showItemLabels
            End Get
            Set(ByVal value As Boolean)
                Me._showItemLabels = value
            End Set
        End Property

        ' Token: 0x170008D1 RID: 2257
        ' (get) Token: 0x0600173E RID: 5950 RVA: 0x002CB6D8 File Offset: 0x002CA6D8
        ' (set) Token: 0x0600173F RID: 5951 RVA: 0x002CB6EC File Offset: 0x002CA6EC
        Public Property ShowTagsOnModulePalette() As Boolean
            Get
                Return Me._showTagsOnModulePalette
            End Get
            Set(ByVal value As Boolean)
                Me._showTagsOnModulePalette = value
            End Set
        End Property

        ' Token: 0x170008D2 RID: 2258
        ' (get) Token: 0x06001740 RID: 5952 RVA: 0x002CB6F8 File Offset: 0x002CA6F8
        ' (set) Token: 0x06001741 RID: 5953 RVA: 0x002CB70C File Offset: 0x002CA70C
        Public Property LastScrollPosX() As Integer
            Get
                Return Me._LastScrollPosX
            End Get
            Set(ByVal value As Integer)
                Me._LastScrollPosX = value
            End Set
        End Property

        ' Token: 0x170008D3 RID: 2259
        ' (get) Token: 0x06001742 RID: 5954 RVA: 0x002CB718 File Offset: 0x002CA718
        ' (set) Token: 0x06001743 RID: 5955 RVA: 0x002CB72C File Offset: 0x002CA72C
        Public Property LastScrollPosY() As Integer
            Get
                Return Me._LastScrollPosY
            End Get
            Set(ByVal value As Integer)
                Me._LastScrollPosY = value
            End Set
        End Property

        ' Token: 0x04000B4B RID: 2891
        Private _moduleEditorModOutputPath As String

        ' Token: 0x04000B4C RID: 2892
        Private _useHiResMap As Boolean

        ' Token: 0x04000B4D RID: 2893
        Private _filterShowCreatures As Boolean

        ' Token: 0x04000B4E RID: 2894
        Private _filterShowDoors As Boolean

        ' Token: 0x04000B4F RID: 2895
        Private _filterShowPlaceables As Boolean

        ' Token: 0x04000B50 RID: 2896
        Private _filterShowEncounters As Boolean

        ' Token: 0x04000B51 RID: 2897
        Private _filterShowTriggers As Boolean

        ' Token: 0x04000B52 RID: 2898
        Private _filterShowMerchants As Boolean

        ' Token: 0x04000B53 RID: 2899
        Private _filterShowSounds As Boolean

        ' Token: 0x04000B54 RID: 2900
        Private _filterShowWaypoints As Boolean

        ' Token: 0x04000B55 RID: 2901
        Private _mapSize As String

        ' Token: 0x04000B56 RID: 2902
        Private _showItemLabels As Boolean

        ' Token: 0x04000B57 RID: 2903
        Private _showTagsOnModulePalette As Boolean

        ' Token: 0x04000B58 RID: 2904
        Private _LastScrollPosX As Integer

        ' Token: 0x04000B59 RID: 2905
        Private _LastScrollPosY As Integer
    End Class
End Namespace
