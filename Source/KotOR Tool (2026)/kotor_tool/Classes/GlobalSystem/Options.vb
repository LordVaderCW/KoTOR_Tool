Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200008C RID: 140
    <Serializable()> _
 Public Class Options
        ' Token: 0x06001747 RID: 5959 RVA: 0x002CB840 File Offset: 0x002CA840
        Public Sub New()
            Me._ModuleExtractPath = ""
            Me._TextEditorSavePath = ""
            Me._bProjMgrUseExternTxtEditor = False
            Me._bProjMgrUseExternDLGEditor = False
            Me._projMgrDLGEditorPath = ""
            Me._projMgrTxtEditorPath = ""
            Me.m_Key = ""
            Me.m_LastModuleEditedPath = ""
            Me.m_bModuleEditorShowLocatorRay = True
            Me.m_bModuleEditorConfirmDeletes = True
            Me.m_MRUMainFiles = New ArrayList()
            Me.m_TreeOpenPaths = New ArrayList()
            Me.m_bCheckForUpdatesAtStartup = True
            Me.m_bDownloadUpdatesAutomatically = True
            Me.m_bRememberLastTreeNode = True
            Me.m_bRememberTreeViewState = True
            Me.m_bModelExtraction_ExtractAnimations = False
            Me.m_bModelExtraction_ConvertSkinToTrimesh = False
            Me.m_bModelExtraction_EachModelInOwnDirectory = True
            Me.m_bModelExtraction_CleanWorkingDirectoryBeforeExport = True
            Me.m_bUseOverrideFiles = False
        End Sub

        ' Token: 0x170008D4 RID: 2260
        ' (get) Token: 0x06001748 RID: 5960 RVA: 0x002CB908 File Offset: 0x002CA908
        ' (set) Token: 0x06001749 RID: 5961 RVA: 0x002CB91C File Offset: 0x002CA91C
        Public Property bProjMgrUseExternTxtEditor() As Boolean
            Get
                Return Me._bProjMgrUseExternTxtEditor
            End Get
            Set(ByVal value As Boolean)
                Me._bProjMgrUseExternTxtEditor = value
            End Set
        End Property

        ' Token: 0x170008D5 RID: 2261
        ' (get) Token: 0x0600174A RID: 5962 RVA: 0x002CB928 File Offset: 0x002CA928
        ' (set) Token: 0x0600174B RID: 5963 RVA: 0x002CB93C File Offset: 0x002CA93C
        Public Property bProjMgrUseExternDLGEditor() As Boolean
            Get
                Return Me._bProjMgrUseExternDLGEditor
            End Get
            Set(ByVal value As Boolean)
                Me._bProjMgrUseExternDLGEditor = value
            End Set
        End Property

        ' Token: 0x170008D6 RID: 2262
        ' (get) Token: 0x0600174C RID: 5964 RVA: 0x002CB948 File Offset: 0x002CA948
        ' (set) Token: 0x0600174D RID: 5965 RVA: 0x002CB95C File Offset: 0x002CA95C
        Public Property ProjMgrDLGEditorPath() As String
            Get
                Return Me._projMgrDLGEditorPath
            End Get
            Set(ByVal value As String)
                Me._projMgrDLGEditorPath = value
            End Set
        End Property

        ' Token: 0x170008D7 RID: 2263
        ' (get) Token: 0x0600174E RID: 5966 RVA: 0x002CB968 File Offset: 0x002CA968
        ' (set) Token: 0x0600174F RID: 5967 RVA: 0x002CB97C File Offset: 0x002CA97C
        Public Property ProjMgrTxtEditorPath() As String
            Get
                Return Me._projMgrTxtEditorPath
            End Get
            Set(ByVal value As String)
                Me._projMgrTxtEditorPath = value
            End Set
        End Property

        ' Token: 0x170008D8 RID: 2264
        ' (get) Token: 0x06001750 RID: 5968 RVA: 0x002CB988 File Offset: 0x002CA988
        ' (set) Token: 0x06001751 RID: 5969 RVA: 0x002CB99C File Offset: 0x002CA99C
        Public Property bModelExtraction_ExtractAnimations() As Boolean
            Get
                Return Me.m_bModelExtraction_ExtractAnimations
            End Get
            Set(ByVal value As Boolean)
                Me.m_bModelExtraction_ExtractAnimations = value
            End Set
        End Property

        ' Token: 0x170008D9 RID: 2265
        ' (get) Token: 0x06001752 RID: 5970 RVA: 0x002CB9A8 File Offset: 0x002CA9A8
        ' (set) Token: 0x06001753 RID: 5971 RVA: 0x002CB9BC File Offset: 0x002CA9BC
        Public Property bModelExtraction_ConvertSkinToTrimesh() As Boolean
            Get
                Return Me.m_bModelExtraction_ConvertSkinToTrimesh
            End Get
            Set(ByVal value As Boolean)
                Me.m_bModelExtraction_ConvertSkinToTrimesh = value
            End Set
        End Property

        ' Token: 0x170008DA RID: 2266
        ' (get) Token: 0x06001754 RID: 5972 RVA: 0x002CB9C8 File Offset: 0x002CA9C8
        ' (set) Token: 0x06001755 RID: 5973 RVA: 0x002CB9DC File Offset: 0x002CA9DC
        Public Property bModelExtraction_EachModelInOwnDirectory() As Boolean
            Get
                Return Me.m_bModelExtraction_EachModelInOwnDirectory
            End Get
            Set(ByVal value As Boolean)
                Me.m_bModelExtraction_EachModelInOwnDirectory = value
            End Set
        End Property

        ' Token: 0x170008DB RID: 2267
        ' (get) Token: 0x06001756 RID: 5974 RVA: 0x002CB9E8 File Offset: 0x002CA9E8
        ' (set) Token: 0x06001757 RID: 5975 RVA: 0x002CB9FC File Offset: 0x002CA9FC
        Public Property bModelExtraction_CleanWorkingDirectoryBeforeExport() As Boolean
            Get
                Return Me.m_bModelExtraction_CleanWorkingDirectoryBeforeExport
            End Get
            Set(ByVal value As Boolean)
                Me.m_bModelExtraction_CleanWorkingDirectoryBeforeExport = value
            End Set
        End Property

        ' Token: 0x170008DC RID: 2268
        ' (get) Token: 0x06001758 RID: 5976 RVA: 0x002CBA08 File Offset: 0x002CAA08
        ' (set) Token: 0x06001759 RID: 5977 RVA: 0x002CBA1C File Offset: 0x002CAA1C
        Public Property bCheckForUpdatesAtStartup() As Boolean
            Get
                Return Me.m_bCheckForUpdatesAtStartup
            End Get
            Set(ByVal value As Boolean)
                Me.m_bCheckForUpdatesAtStartup = value
            End Set
        End Property

        ' Token: 0x170008DD RID: 2269
        ' (get) Token: 0x0600175A RID: 5978 RVA: 0x002CBA28 File Offset: 0x002CAA28
        ' (set) Token: 0x0600175B RID: 5979 RVA: 0x002CBA3C File Offset: 0x002CAA3C
        Public Property bDownloadUpdatesAutomatically() As Boolean
            Get
                Return Me.m_bDownloadUpdatesAutomatically
            End Get
            Set(ByVal value As Boolean)
                Me.m_bDownloadUpdatesAutomatically = value
            End Set
        End Property

        ' Token: 0x170008DE RID: 2270
        ' (get) Token: 0x0600175C RID: 5980 RVA: 0x002CBA48 File Offset: 0x002CAA48
        ' (set) Token: 0x0600175D RID: 5981 RVA: 0x002CBA5C File Offset: 0x002CAA5C
        Public Property bModuleEditorShowLocatorRay() As Boolean
            Get
                Return Me.m_bModuleEditorShowLocatorRay
            End Get
            Set(ByVal value As Boolean)
                Me.m_bModuleEditorShowLocatorRay = value
            End Set
        End Property

        ' Token: 0x170008DF RID: 2271
        ' (get) Token: 0x0600175E RID: 5982 RVA: 0x002CBA68 File Offset: 0x002CAA68
        ' (set) Token: 0x0600175F RID: 5983 RVA: 0x002CBA7C File Offset: 0x002CAA7C
        Public Property bModuleEditorConfirmDeletes() As Boolean
            Get
                Return Me.m_bModuleEditorConfirmDeletes
            End Get
            Set(ByVal value As Boolean)
                Me.m_bModuleEditorConfirmDeletes = value
            End Set
        End Property

        ' Token: 0x170008E0 RID: 2272
        ' (get) Token: 0x06001760 RID: 5984 RVA: 0x002CBA88 File Offset: 0x002CAA88
        ' (set) Token: 0x06001761 RID: 5985 RVA: 0x002CBA9C File Offset: 0x002CAA9C
        Public Property ModuleEditorModuleElementIndicatorSize() As Decimal
            Get
                Return Me.m_ModuleEditorModuleElementIndicatorSize
            End Get
            Set(ByVal value As Decimal)
                Me.m_ModuleEditorModuleElementIndicatorSize = value
            End Set
        End Property

        ' Token: 0x170008E1 RID: 2273
        ' (get) Token: 0x06001762 RID: 5986 RVA: 0x002CBAA8 File Offset: 0x002CAAA8
        ' (set) Token: 0x06001763 RID: 5987 RVA: 0x002CBABC File Offset: 0x002CAABC
        Public Property MainWindowSplitterPos() As Integer
            Get
                Return Me.m_MainWindowSplitterPos
            End Get
            Set(ByVal value As Integer)
                Me.m_MainWindowSplitterPos = value
            End Set
        End Property

        ' Token: 0x06001764 RID: 5988 RVA: 0x002CBAC8 File Offset: 0x002CAAC8
        Public Function KotorLocation(ByVal index As Integer) As String
            Select Case index
                Case 0
                    Return Me.m_defaultKotORLocation
                Case 1
                    Return Me.m_defaultKotORLocation2
                Case Else
                    Dim text As String
                    Return text
            End Select
        End Function

        ' Token: 0x06001765 RID: 5989 RVA: 0x002CBAF4 File Offset: 0x002CAAF4
        Public Function KeyFileLocation(ByVal index As Integer) As String
            Select Case index
                Case 0
                    Return Me.m_defaultKotORLocation + "\chitin.key"
                Case 1
                    Return Me.m_defaultKotORLocation2 + "\chitin.key"
                Case Else
                    Dim text As String
                    Return text
            End Select
        End Function

        ' Token: 0x170008E2 RID: 2274
        ' (get) Token: 0x06001766 RID: 5990 RVA: 0x002CBB34 File Offset: 0x002CAB34
        ' (set) Token: 0x06001767 RID: 5991 RVA: 0x002CBB48 File Offset: 0x002CAB48
        Public Property ModelExportLocation() As String
            Get
                Return Me.m_ModelExportLocation
            End Get
            Set(ByVal value As String)
                Me.m_ModelExportLocation = value
            End Set
        End Property

        ' Token: 0x170008E3 RID: 2275
        ' (get) Token: 0x06001768 RID: 5992 RVA: 0x002CBB54 File Offset: 0x002CAB54
        ' (set) Token: 0x06001769 RID: 5993 RVA: 0x002CBB68 File Offset: 0x002CAB68
        Public Property ModuleExtractPath() As String
            Get
                Return Me._ModuleExtractPath
            End Get
            Set(ByVal value As String)
                Me._ModuleExtractPath = value
            End Set
        End Property

        ' Token: 0x170008E4 RID: 2276
        ' (get) Token: 0x0600176A RID: 5994 RVA: 0x002CBB74 File Offset: 0x002CAB74
        ' (set) Token: 0x0600176B RID: 5995 RVA: 0x002CBB88 File Offset: 0x002CAB88
        Public Property defaultKotORLocation() As String
            Get
                Return Me.m_defaultKotORLocation
            End Get
            Set(ByVal value As String)
                Me.m_defaultKotORLocation = value
            End Set
        End Property

        ' Token: 0x170008E5 RID: 2277
        ' (get) Token: 0x0600176C RID: 5996 RVA: 0x002CBB94 File Offset: 0x002CAB94
        ' (set) Token: 0x0600176D RID: 5997 RVA: 0x002CBBA8 File Offset: 0x002CABA8
        Public Property defaultKotORLocation2() As String
            Get
                Return Me.m_defaultKotORLocation2
            End Get
            Set(ByVal value As String)
                Me.m_defaultKotORLocation2 = value
            End Set
        End Property

        ' Token: 0x170008E6 RID: 2278
        ' (get) Token: 0x0600176E RID: 5998 RVA: 0x002CBBB4 File Offset: 0x002CABB4
        ' (set) Token: 0x0600176F RID: 5999 RVA: 0x002CBBC8 File Offset: 0x002CABC8
        Public Property ImageViewerLocation() As String
            Get
                Return Me.m_ImageViewerLocation
            End Get
            Set(ByVal value As String)
                Me.m_ImageViewerLocation = value
            End Set
        End Property

        ' Token: 0x170008E7 RID: 2279
        ' (get) Token: 0x06001770 RID: 6000 RVA: 0x002CBBD4 File Offset: 0x002CABD4
        ' (set) Token: 0x06001771 RID: 6001 RVA: 0x002CBBE8 File Offset: 0x002CABE8
        Public Property defaultSaveLocation() As String
            Get
                Return Me.m_defaultSaveLocation
            End Get
            Set(ByVal value As String)
                Me.m_defaultSaveLocation = value
            End Set
        End Property

        ' Token: 0x170008E8 RID: 2280
        ' (get) Token: 0x06001772 RID: 6002 RVA: 0x002CBBF4 File Offset: 0x002CABF4
        ' (set) Token: 0x06001773 RID: 6003 RVA: 0x002CBC08 File Offset: 0x002CAC08
        Public Property defaultImportLocation() As String
            Get
                Return Me.m_defaultImportLocation
            End Get
            Set(ByVal value As String)
                Me.m_defaultImportLocation = value
            End Set
        End Property

        ' Token: 0x170008E9 RID: 2281
        ' (get) Token: 0x06001774 RID: 6004 RVA: 0x002CBC14 File Offset: 0x002CAC14
        ' (set) Token: 0x06001775 RID: 6005 RVA: 0x002CBC28 File Offset: 0x002CAC28
        Public Property TextEditorSavePath() As String
            Get
                Return Me._TextEditorSavePath
            End Get
            Set(ByVal value As String)
                Me._TextEditorSavePath = value
            End Set
        End Property

        ' Token: 0x170008EA RID: 2282
        ' (get) Token: 0x06001776 RID: 6006 RVA: 0x002CBC34 File Offset: 0x002CAC34
        ' (set) Token: 0x06001777 RID: 6007 RVA: 0x002CBC48 File Offset: 0x002CAC48
        Public Property bUseOverrideFiles() As Boolean
            Get
                Return Me.m_bUseOverrideFiles
            End Get
            Set(ByVal value As Boolean)
                Me.m_bUseOverrideFiles = value
            End Set
        End Property

        ' Token: 0x170008EB RID: 2283
        ' (get) Token: 0x06001778 RID: 6008 RVA: 0x002CBC54 File Offset: 0x002CAC54
        ' (set) Token: 0x06001779 RID: 6009 RVA: 0x002CBC68 File Offset: 0x002CAC68
        Public Property LastClickedTVNodePath() As String
            Get
                Return Me.m_LastClickedTVNodePath
            End Get
            Set(ByVal value As String)
                Me.m_LastClickedTVNodePath = value
            End Set
        End Property

        ' Token: 0x170008EC RID: 2284
        ' (get) Token: 0x0600177A RID: 6010 RVA: 0x002CBC74 File Offset: 0x002CAC74
        ' (set) Token: 0x0600177B RID: 6011 RVA: 0x002CBC88 File Offset: 0x002CAC88
        Public Property bRememberLastTreeNode() As Boolean
            Get
                Return Me.m_bRememberLastTreeNode
            End Get
            Set(ByVal value As Boolean)
                Me.m_bRememberLastTreeNode = value
            End Set
        End Property

        ' Token: 0x170008ED RID: 2285
        ' (get) Token: 0x0600177C RID: 6012 RVA: 0x002CBC94 File Offset: 0x002CAC94
        ' (set) Token: 0x0600177D RID: 6013 RVA: 0x002CBCA8 File Offset: 0x002CACA8
        Public Property bRememberTreeViewState() As Boolean
            Get
                Return Me.m_bRememberTreeViewState
            End Get
            Set(ByVal value As Boolean)
                Me.m_bRememberTreeViewState = value
            End Set
        End Property

        ' Token: 0x170008EE RID: 2286
        ' (get) Token: 0x0600177E RID: 6014 RVA: 0x002CBCB4 File Offset: 0x002CACB4
        ' (set) Token: 0x0600177F RID: 6015 RVA: 0x002CBCC8 File Offset: 0x002CACC8
        Public Property bBuildModelsBifNode() As Boolean
            Get
                Return Me.m_bBuildModelsBifNode
            End Get
            Set(ByVal value As Boolean)
                Me.m_bBuildModelsBifNode = value
            End Set
        End Property

        ' Token: 0x170008EF RID: 2287
        ' (get) Token: 0x06001780 RID: 6016 RVA: 0x002CBCD4 File Offset: 0x002CACD4
        ' (set) Token: 0x06001781 RID: 6017 RVA: 0x002CBCE8 File Offset: 0x002CACE8
        Public Property bBuildBIFFtreeOnStartup() As Boolean
            Get
                Return Me.m_bBuildBIFFtreeOnStartup
            End Get
            Set(ByVal value As Boolean)
                Me.m_bBuildBIFFtreeOnStartup = value
            End Set
        End Property

        ' Token: 0x170008F0 RID: 2288
        ' (get) Token: 0x06001782 RID: 6018 RVA: 0x002CBCF4 File Offset: 0x002CACF4
        ' (set) Token: 0x06001783 RID: 6019 RVA: 0x002CBD08 File Offset: 0x002CAD08
        Public Property bAlwaysUnknownGFFasText() As Boolean
            Get
                Return Me.m_bAlwaysUnknownGFFasText
            End Get
            Set(ByVal value As Boolean)
                Me.m_bAlwaysUnknownGFFasText = value
            End Set
        End Property

        ' Token: 0x170008F1 RID: 2289
        ' (get) Token: 0x06001784 RID: 6020 RVA: 0x002CBD14 File Offset: 0x002CAD14
        ' (set) Token: 0x06001785 RID: 6021 RVA: 0x002CBD28 File Offset: 0x002CAD28
        Public Property bAlwaysConvertTPC2TGA() As Boolean
            Get
                Return Me.m_bAlwaysConvertTPC2TGA
            End Get
            Set(ByVal value As Boolean)
                Me.m_bAlwaysConvertTPC2TGA = value
            End Set
        End Property

        ' Token: 0x170008F2 RID: 2290
        ' (get) Token: 0x06001786 RID: 6022 RVA: 0x002CBD34 File Offset: 0x002CAD34
        ' (set) Token: 0x06001787 RID: 6023 RVA: 0x002CBD48 File Offset: 0x002CAD48
        Public Property bDockImageViewer() As Boolean
            Get
                Return Me.m_bDockImageViewer
            End Get
            Set(ByVal value As Boolean)
                Me.m_bDockImageViewer = value
            End Set
        End Property

        ' Token: 0x170008F3 RID: 2291
        ' (get) Token: 0x06001788 RID: 6024 RVA: 0x002CBD54 File Offset: 0x002CAD54
        ' (set) Token: 0x06001789 RID: 6025 RVA: 0x002CBD68 File Offset: 0x002CAD68
        Public Property bTextEditorWordWrap() As Boolean
            Get
                Return Me.m_bTextEditorWordWrap
            End Get
            Set(ByVal value As Boolean)
                Me.m_bTextEditorWordWrap = value
            End Set
        End Property

        ' Token: 0x170008F4 RID: 2292
        ' (get) Token: 0x0600178A RID: 6026 RVA: 0x002CBD74 File Offset: 0x002CAD74
        ' (set) Token: 0x0600178B RID: 6027 RVA: 0x002CBD88 File Offset: 0x002CAD88
        Public Property bShowModuleDescriptions() As Boolean
            Get
                Return Me.m_bShowModuleDescriptions
            End Get
            Set(ByVal value As Boolean)
                Me.m_bShowModuleDescriptions = value
            End Set
        End Property

        ' Token: 0x170008F5 RID: 2293
        ' (get) Token: 0x0600178C RID: 6028 RVA: 0x002CBD94 File Offset: 0x002CAD94
        ' (set) Token: 0x0600178D RID: 6029 RVA: 0x002CBDA8 File Offset: 0x002CADA8
        Public Property bShowModuleLocations() As Boolean
            Get
                Return Me.m_bShowModuleLocations
            End Get
            Set(ByVal value As Boolean)
                Me.m_bShowModuleLocations = value
            End Set
        End Property

        ' Token: 0x170008F6 RID: 2294
        ' (get) Token: 0x0600178E RID: 6030 RVA: 0x002CBDB4 File Offset: 0x002CADB4
        ' (set) Token: 0x0600178F RID: 6031 RVA: 0x002CBDC8 File Offset: 0x002CADC8
        Public Property MainWindowLoc() As Point
            Get
                Return Me.m_MainWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_MainWindowLoc = value
            End Set
        End Property

        ' Token: 0x170008F7 RID: 2295
        ' (get) Token: 0x06001790 RID: 6032 RVA: 0x002CBDD4 File Offset: 0x002CADD4
        ' (set) Token: 0x06001791 RID: 6033 RVA: 0x002CBDE8 File Offset: 0x002CADE8
        Public Property MainWindowSize() As Size
            Get
                Return Me.m_MainWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_MainWindowSize = value
            End Set
        End Property

        ' Token: 0x170008F8 RID: 2296
        ' (get) Token: 0x06001792 RID: 6034 RVA: 0x002CBDF4 File Offset: 0x002CADF4
        ' (set) Token: 0x06001793 RID: 6035 RVA: 0x002CBE08 File Offset: 0x002CAE08
        Public Property TextEditorWindowLoc() As Point
            Get
                Return Me.m_TextEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_TextEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x170008F9 RID: 2297
        ' (get) Token: 0x06001794 RID: 6036 RVA: 0x002CBE14 File Offset: 0x002CAE14
        ' (set) Token: 0x06001795 RID: 6037 RVA: 0x002CBE28 File Offset: 0x002CAE28
        Public Property TextEditorWindowSize() As Size
            Get
                Return Me.m_TextEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_TextEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x170008FA RID: 2298
        ' (get) Token: 0x06001796 RID: 6038 RVA: 0x002CBE34 File Offset: 0x002CAE34
        ' (set) Token: 0x06001797 RID: 6039 RVA: 0x002CBE48 File Offset: 0x002CAE48
        Public Property ImageViewerWindowLoc() As Point
            Get
                Return Me.m_ImageViewerWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_ImageViewerWindowLoc = value
            End Set
        End Property

        ' Token: 0x170008FB RID: 2299
        ' (get) Token: 0x06001798 RID: 6040 RVA: 0x002CBE54 File Offset: 0x002CAE54
        ' (set) Token: 0x06001799 RID: 6041 RVA: 0x002CBE68 File Offset: 0x002CAE68
        Public Property ImageViewerWindowSize() As Size
            Get
                Return Me.m_ImageViewerWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_ImageViewerWindowSize = value
            End Set
        End Property

        ' Token: 0x170008FC RID: 2300
        ' (get) Token: 0x0600179A RID: 6042 RVA: 0x002CBE74 File Offset: 0x002CAE74
        ' (set) Token: 0x0600179B RID: 6043 RVA: 0x002CBE88 File Offset: 0x002CAE88
        Public Property ByteViewerWindowLoc() As Point
            Get
                Return Me.m_ByteViewerWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_ByteViewerWindowLoc = value
            End Set
        End Property

        ' Token: 0x170008FD RID: 2301
        ' (get) Token: 0x0600179C RID: 6044 RVA: 0x002CBE94 File Offset: 0x002CAE94
        ' (set) Token: 0x0600179D RID: 6045 RVA: 0x002CBEA8 File Offset: 0x002CAEA8
        Public Property ByteViewerWindowSize() As Size
            Get
                Return Me.m_ByteViewerWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_ByteViewerWindowSize = value
            End Set
        End Property

        ' Token: 0x170008FE RID: 2302
        ' (get) Token: 0x0600179E RID: 6046 RVA: 0x002CBEB4 File Offset: 0x002CAEB4
        ' (set) Token: 0x0600179F RID: 6047 RVA: 0x002CBEC8 File Offset: 0x002CAEC8
        Public Property ERFManagerWindowLoc() As Point
            Get
                Return Me.m_ERFManagerWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_ERFManagerWindowLoc = value
            End Set
        End Property

        ' Token: 0x170008FF RID: 2303
        ' (get) Token: 0x060017A0 RID: 6048 RVA: 0x002CBED4 File Offset: 0x002CAED4
        ' (set) Token: 0x060017A1 RID: 6049 RVA: 0x002CBEE8 File Offset: 0x002CAEE8
        Public Property ERFManagerWindowSize() As Size
            Get
                Return Me.m_ERFManagerWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_ERFManagerWindowSize = value
            End Set
        End Property

        ' Token: 0x17000900 RID: 2304
        ' (get) Token: 0x060017A2 RID: 6050 RVA: 0x002CBEF4 File Offset: 0x002CAEF4
        ' (set) Token: 0x060017A3 RID: 6051 RVA: 0x002CBF08 File Offset: 0x002CAF08
        Public Property TwoDAEditorWindowLoc() As Point
            Get
                Return Me.m_2DAEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_2DAEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000901 RID: 2305
        ' (get) Token: 0x060017A4 RID: 6052 RVA: 0x002CBF14 File Offset: 0x002CAF14
        ' (set) Token: 0x060017A5 RID: 6053 RVA: 0x002CBF28 File Offset: 0x002CAF28
        Public Property TwoDAEditorWindowSize() As Size
            Get
                Return Me.m_2DAEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_2DAEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x17000902 RID: 2306
        ' (get) Token: 0x060017A6 RID: 6054 RVA: 0x002CBF34 File Offset: 0x002CAF34
        ' (set) Token: 0x060017A7 RID: 6055 RVA: 0x002CBF48 File Offset: 0x002CAF48
        Public Property UTCEditorWindowLoc() As Point
            Get
                Return Me.m_UTCEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_UTCEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000903 RID: 2307
        ' (get) Token: 0x060017A8 RID: 6056 RVA: 0x002CBF54 File Offset: 0x002CAF54
        ' (set) Token: 0x060017A9 RID: 6057 RVA: 0x002CBF68 File Offset: 0x002CAF68
        Public Property UTCEditorWindowSize() As Size
            Get
                Return Me.m_UTCEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_UTCEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x17000904 RID: 2308
        ' (get) Token: 0x060017AA RID: 6058 RVA: 0x002CBF74 File Offset: 0x002CAF74
        ' (set) Token: 0x060017AB RID: 6059 RVA: 0x002CBF88 File Offset: 0x002CAF88
        Public Property UTDEditorWindowLoc() As Point
            Get
                Return Me.m_UTDEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_UTDEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000905 RID: 2309
        ' (get) Token: 0x060017AC RID: 6060 RVA: 0x002CBF94 File Offset: 0x002CAF94
        ' (set) Token: 0x060017AD RID: 6061 RVA: 0x002CBFA8 File Offset: 0x002CAFA8
        Public Property UTdEditorWindowSize() As Size
            Get
                Return Me.m_UTDEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_UTDEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x17000906 RID: 2310
        ' (get) Token: 0x060017AE RID: 6062 RVA: 0x002CBFB4 File Offset: 0x002CAFB4
        ' (set) Token: 0x060017AF RID: 6063 RVA: 0x002CBFC8 File Offset: 0x002CAFC8
        Public Property UTIEditorWindowLoc() As Point
            Get
                Return Me.m_UTIEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_UTIEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000907 RID: 2311
        ' (get) Token: 0x060017B0 RID: 6064 RVA: 0x002CBFD4 File Offset: 0x002CAFD4
        ' (set) Token: 0x060017B1 RID: 6065 RVA: 0x002CBFE8 File Offset: 0x002CAFE8
        Public Property UTIEditorWindowSize() As Size
            Get
                Return Me.m_UTIEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_UTIEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x17000908 RID: 2312
        ' (get) Token: 0x060017B2 RID: 6066 RVA: 0x002CBFF4 File Offset: 0x002CAFF4
        ' (set) Token: 0x060017B3 RID: 6067 RVA: 0x002CC008 File Offset: 0x002CB008
        Public Property UTMEditorWindowLoc() As Point
            Get
                Return Me.m_UTMEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_UTMEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000909 RID: 2313
        ' (get) Token: 0x060017B4 RID: 6068 RVA: 0x002CC014 File Offset: 0x002CB014
        ' (set) Token: 0x060017B5 RID: 6069 RVA: 0x002CC028 File Offset: 0x002CB028
        Public Property UTMEditorWindowSize() As Size
            Get
                Return Me.m_UTMEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_UTMEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x1700090A RID: 2314
        ' (get) Token: 0x060017B6 RID: 6070 RVA: 0x002CC034 File Offset: 0x002CB034
        ' (set) Token: 0x060017B7 RID: 6071 RVA: 0x002CC048 File Offset: 0x002CB048
        Public Property UTPEditorWindowLoc() As Point
            Get
                Return Me.m_UTPEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_UTPEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x1700090B RID: 2315
        ' (get) Token: 0x060017B8 RID: 6072 RVA: 0x002CC054 File Offset: 0x002CB054
        ' (set) Token: 0x060017B9 RID: 6073 RVA: 0x002CC068 File Offset: 0x002CB068
        Public Property UTPEditorWindowSize() As Size
            Get
                Return Me.m_UTPEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_UTPEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x1700090C RID: 2316
        ' (get) Token: 0x060017BA RID: 6074 RVA: 0x002CC074 File Offset: 0x002CB074
        ' (set) Token: 0x060017BB RID: 6075 RVA: 0x002CC088 File Offset: 0x002CB088
        Public Property UTSEditorWindowLoc() As Point
            Get
                Return Me.m_UTSEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_UTSEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x1700090D RID: 2317
        ' (get) Token: 0x060017BC RID: 6076 RVA: 0x002CC094 File Offset: 0x002CB094
        ' (set) Token: 0x060017BD RID: 6077 RVA: 0x002CC0A8 File Offset: 0x002CB0A8
        Public Property UTSEditorWindowSize() As Size
            Get
                Return Me.m_UTSEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_UTSEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x1700090E RID: 2318
        ' (get) Token: 0x060017BE RID: 6078 RVA: 0x002CC0B4 File Offset: 0x002CB0B4
        ' (set) Token: 0x060017BF RID: 6079 RVA: 0x002CC0C8 File Offset: 0x002CB0C8
        Public Property UTTEditorWindowLoc() As Point
            Get
                Return Me.m_UTTEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_UTTEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x1700090F RID: 2319
        ' (get) Token: 0x060017C0 RID: 6080 RVA: 0x002CC0D4 File Offset: 0x002CB0D4
        ' (set) Token: 0x060017C1 RID: 6081 RVA: 0x002CC0E8 File Offset: 0x002CB0E8
        Public Property UTTEditorWindowSize() As Size
            Get
                Return Me.m_UTTEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_UTTEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x17000910 RID: 2320
        ' (get) Token: 0x060017C2 RID: 6082 RVA: 0x002CC0F4 File Offset: 0x002CB0F4
        ' (set) Token: 0x060017C3 RID: 6083 RVA: 0x002CC108 File Offset: 0x002CB108
        Public Property UTWEditorWindowLoc() As Point
            Get
                Return Me.m_UTWEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_UTWEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000911 RID: 2321
        ' (get) Token: 0x060017C4 RID: 6084 RVA: 0x002CC114 File Offset: 0x002CB114
        ' (set) Token: 0x060017C5 RID: 6085 RVA: 0x002CC128 File Offset: 0x002CB128
        Public Property UTWEditorWindowSize() As Size
            Get
                Return Me.m_UTWEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_UTWEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x17000912 RID: 2322
        ' (get) Token: 0x060017C6 RID: 6086 RVA: 0x002CC134 File Offset: 0x002CB134
        ' (set) Token: 0x060017C7 RID: 6087 RVA: 0x002CC148 File Offset: 0x002CB148
        Public Property ProjectManagerWindowLoc() As Point
            Get
                Return Me.m_ProjectManagerWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_ProjectManagerWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000913 RID: 2323
        ' (get) Token: 0x060017C8 RID: 6088 RVA: 0x002CC154 File Offset: 0x002CB154
        ' (set) Token: 0x060017C9 RID: 6089 RVA: 0x002CC168 File Offset: 0x002CB168
        Public Property ProjectManagerWindowSize() As Size
            Get
                Return Me.m_ProjectManagerWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_ProjectManagerWindowSize = value
            End Set
        End Property

        ' Token: 0x17000914 RID: 2324
        ' (get) Token: 0x060017CA RID: 6090 RVA: 0x002CC174 File Offset: 0x002CB174
        ' (set) Token: 0x060017CB RID: 6091 RVA: 0x002CC188 File Offset: 0x002CB188
        Public Property InventoryEditorWindowLoc() As Point
            Get
                Return Me.m_InventoryEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_InventoryEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000915 RID: 2325
        ' (get) Token: 0x060017CC RID: 6092 RVA: 0x002CC194 File Offset: 0x002CB194
        ' (set) Token: 0x060017CD RID: 6093 RVA: 0x002CC1A8 File Offset: 0x002CB1A8
        Public Property InventoryEditorWindowSize() As Size
            Get
                Return Me.m_InventoryEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_InventoryEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x17000916 RID: 2326
        ' (get) Token: 0x060017CE RID: 6094 RVA: 0x002CC1B4 File Offset: 0x002CB1B4
        ' (set) Token: 0x060017CF RID: 6095 RVA: 0x002CC1C8 File Offset: 0x002CB1C8
        Public Property ModuleEditorWindowLoc() As Point
            Get
                Return Me.m_ModuleEditorWindowLoc
            End Get
            Set(ByVal value As Point)
                Me.m_ModuleEditorWindowLoc = value
            End Set
        End Property

        ' Token: 0x17000917 RID: 2327
        ' (get) Token: 0x060017D0 RID: 6096 RVA: 0x002CC1D4 File Offset: 0x002CB1D4
        ' (set) Token: 0x060017D1 RID: 6097 RVA: 0x002CC1E8 File Offset: 0x002CB1E8
        Public Property ModuleEditorWindowSize() As Size
            Get
                Return Me.m_ModuleEditorWindowSize
            End Get
            Set(ByVal value As Size)
                Me.m_ModuleEditorWindowSize = value
            End Set
        End Property

        ' Token: 0x17000918 RID: 2328
        ' (get) Token: 0x060017D2 RID: 6098 RVA: 0x002CC1F4 File Offset: 0x002CB1F4
        ' (set) Token: 0x060017D3 RID: 6099 RVA: 0x002CC324 File Offset: 0x002CB324
        Public Property WindowSize(ByVal FormClassName As String) As Size
            Get
                If StringType.StrCmp(FormClassName, "frmInventoryEditor", False) = 0 Then
                    Return Me.m_InventoryEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmUTC_Editor", False) = 0 Then
                    Return Me.m_UTCEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmUTD_Editor", False) = 0 Then
                    Return Me.m_UTDEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmUTI_Editor", False) = 0 Then
                    Return Me.m_UTIEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmUTM_Editor", False) = 0 Then
                    Return Me.m_UTMEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmUTP_Editor", False) = 0 Then
                    Return Me.m_UTPEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmUTS_Editor", False) = 0 Then
                    Return Me.m_UTSEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmUTT_Editor", False) = 0 Then
                    Return Me.m_UTTEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmUTW_Editor", False) = 0 Then
                    Return Me.m_UTWEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmGlobalVar_Editor", False) = 0 Then
                    Return Me.m_frmGlobalVarEditorWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmProjectManager", False) = 0 Then
                    Return Me.m_ProjectManagerWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmERFManager", False) = 0 Then
                    Return Me.m_ERFManagerWindowSize
                End If
                If StringType.StrCmp(FormClassName, "frmModule_Editor", False) = 0 Then
                    Return Me.m_ModuleEditorWindowSize
                End If
                Dim size As Size
                Return size
            End Get
            Set(ByVal value As Size)
                If StringType.StrCmp(FormClassName, "frmInventoryEditor", False) = 0 Then
                    Me.m_InventoryEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTC_Editor", False) = 0 Then
                    Me.m_UTCEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTD_Editor", False) = 0 Then
                    Me.m_UTDEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTI_Editor", False) = 0 Then
                    Me.m_UTIEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTM_Editor", False) = 0 Then
                    Me.m_UTMEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTP_Editor", False) = 0 Then
                    Me.m_UTPEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTS_Editor", False) = 0 Then
                    Me.m_UTSEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTT_Editor", False) = 0 Then
                    Me.m_UTTEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTW_Editor", False) = 0 Then
                    Me.m_UTWEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmGlobalVar_Editor", False) = 0 Then
                    Me.m_frmGlobalVarEditorWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmProjectManager", False) = 0 Then
                    Me.m_ProjectManagerWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmERFManager", False) = 0 Then
                    Me.m_ERFManagerWindowSize = value
                ElseIf StringType.StrCmp(FormClassName, "frmModule_Editor", False) = 0 Then
                    Me.m_ModuleEditorWindowSize = value
                End If
            End Set
        End Property

        ' Token: 0x17000919 RID: 2329
        ' (get) Token: 0x060017D4 RID: 6100 RVA: 0x002CC480 File Offset: 0x002CB480
        ' (set) Token: 0x060017D5 RID: 6101 RVA: 0x002CC5B0 File Offset: 0x002CB5B0
        Public Property WindowLoc(ByVal FormClassName As String) As Point
            Get
                If StringType.StrCmp(FormClassName, "frmInventoryEditor", False) = 0 Then
                    Return Me.m_InventoryEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmUTC_Editor", False) = 0 Then
                    Return Me.m_UTCEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmUTD_Editor", False) = 0 Then
                    Return Me.m_UTDEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmUTI_Editor", False) = 0 Then
                    Return Me.m_UTIEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmUTM_Editor", False) = 0 Then
                    Return Me.m_UTMEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmUTP_Editor", False) = 0 Then
                    Return Me.m_UTPEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmUTS_Editor", False) = 0 Then
                    Return Me.m_UTSEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmUTT_Editor", False) = 0 Then
                    Return Me.m_UTTEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmUTW_Editor", False) = 0 Then
                    Return Me.m_UTWEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmGlobalVar_Editor", False) = 0 Then
                    Return Me.m_frmGlobalVarEditorWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmProjectManager", False) = 0 Then
                    Return Me.m_ProjectManagerWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmERFManager", False) = 0 Then
                    Return Me.m_ERFManagerWindowLoc
                End If
                If StringType.StrCmp(FormClassName, "frmModule_Editor", False) = 0 Then
                    Return Me.m_ModuleEditorWindowLoc
                End If
                Dim point As Point
                Return point
            End Get
            Set(ByVal value As Point)
                If StringType.StrCmp(FormClassName, "frmInventoryEditor", False) = 0 Then
                    Me.m_InventoryEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTC_Editor", False) = 0 Then
                    Me.m_UTCEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTD_Editor", False) = 0 Then
                    Me.m_UTDEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTI_Editor", False) = 0 Then
                    Me.m_UTIEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTM_Editor", False) = 0 Then
                    Me.m_UTMEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTP_Editor", False) = 0 Then
                    Me.m_UTPEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTS_Editor", False) = 0 Then
                    Me.m_UTSEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTT_Editor", False) = 0 Then
                    Me.m_UTTEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmUTW_Editor", False) = 0 Then
                    Me.m_UTWEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmGlobalVar_Editor", False) = 0 Then
                    Me.m_frmGlobalVarEditorWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmProjectManager", False) = 0 Then
                    Me.m_ProjectManagerWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmERFManager", False) = 0 Then
                    Me.m_ERFManagerWindowLoc = value
                ElseIf StringType.StrCmp(FormClassName, "frmModule_Editor", False) = 0 Then
                    Me.m_ModuleEditorWindowLoc = value
                End If
            End Set
        End Property

        ' Token: 0x1700091A RID: 2330
        ' (get) Token: 0x060017D6 RID: 6102 RVA: 0x002CC70C File Offset: 0x002CB70C
        ' (set) Token: 0x060017D7 RID: 6103 RVA: 0x002CC720 File Offset: 0x002CB720
        Public Property Key() As String
            Get
                Return Me.m_Key
            End Get
            Set(ByVal value As String)
                Me.m_Key = value
            End Set
        End Property

        ' Token: 0x1700091B RID: 2331
        ' (get) Token: 0x060017D8 RID: 6104 RVA: 0x002CC72C File Offset: 0x002CB72C
        ' (set) Token: 0x060017D9 RID: 6105 RVA: 0x002CC740 File Offset: 0x002CB740
        Public Property LastModuleEditedPath() As String
            Get
                Return Me.m_LastModuleEditedPath
            End Get
            Set(ByVal value As String)
                Me.m_LastModuleEditedPath = value
            End Set
        End Property

        ' Token: 0x1700091C RID: 2332
        ' (get) Token: 0x060017DA RID: 6106 RVA: 0x002CC74C File Offset: 0x002CB74C
        ' (set) Token: 0x060017DB RID: 6107 RVA: 0x002CC760 File Offset: 0x002CB760
        <XmlArrayItem(GetType(String))> _
        <XmlArray()> _
              Public Property MRUMainFiles() As ArrayList
            Get
                Return Me.m_MRUMainFiles
            End Get
            Set(ByVal value As ArrayList)
                Me.m_MRUMainFiles = value
            End Set
        End Property

        ' Token: 0x1700091D RID: 2333
        ' (get) Token: 0x060017DC RID: 6108 RVA: 0x002CC76C File Offset: 0x002CB76C
        ' (set) Token: 0x060017DD RID: 6109 RVA: 0x002CC780 File Offset: 0x002CB780
        <XmlArrayItem(GetType(String))> _
        <XmlArray()> _
              Public Property TreeOpenPaths() As ArrayList
            Get
                Return Me.m_TreeOpenPaths
            End Get
            Set(ByVal value As ArrayList)
                Me.m_TreeOpenPaths = value
            End Set
        End Property

        ' Token: 0x04000B5A RID: 2906
        Private m_MainWindowLoc As Point

        ' Token: 0x04000B5B RID: 2907
        Private m_MainWindowSize As Size

        ' Token: 0x04000B5C RID: 2908
        Private m_MainWindowSplitterPos As Integer

        ' Token: 0x04000B5D RID: 2909
        Private m_defaultImportLocation As String

        ' Token: 0x04000B5E RID: 2910
        Private m_defaultOverrideLocation As String

        ' Token: 0x04000B5F RID: 2911
        Private m_defaultKeyFileLocation As String

        ' Token: 0x04000B60 RID: 2912
        Private m_defaultSaveLocation As String

        ' Token: 0x04000B61 RID: 2913
        Private m_defaultKotORLocation As String

        ' Token: 0x04000B62 RID: 2914
        Private m_defaultModuleLocation As String

        ' Token: 0x04000B63 RID: 2915
        Private m_defaultDataLocation As String

        ' Token: 0x04000B64 RID: 2916
        Private m_ImageViewerLocation As String

        ' Token: 0x04000B65 RID: 2917
        Private m_defaultRimsLocation As String

        ' Token: 0x04000B66 RID: 2918
        Private m_defaultTexturePackLocation As String

        ' Token: 0x04000B67 RID: 2919
        Private m_ModelExportLocation As String

        ' Token: 0x04000B68 RID: 2920
        Private _ModuleExtractPath As String

        ' Token: 0x04000B69 RID: 2921
        Private _TextEditorSavePath As String

        ' Token: 0x04000B6A RID: 2922
        Public CurrentDataLocation As String

        ' Token: 0x04000B6B RID: 2923
        Public CurrentKotORLocation As String

        ' Token: 0x04000B6C RID: 2924
        Public CurrentModuleLocation As String

        ' Token: 0x04000B6D RID: 2925
        Public CurrentOverrideLocation As String

        ' Token: 0x04000B6E RID: 2926
        Public CurrentKeyFileLocation As String

        ' Token: 0x04000B6F RID: 2927
        Public CurrentRimsLocation As String

        ' Token: 0x04000B70 RID: 2928
        Private m_defaultKotORLocation2 As String

        ' Token: 0x04000B71 RID: 2929
        Private m_defaultModuleLocation2 As String

        ' Token: 0x04000B72 RID: 2930
        Private m_bBuildBIFFtreeOnStartup As Boolean

        ' Token: 0x04000B73 RID: 2931
        Private m_bAlwaysConvertTPC2TGA As Boolean

        ' Token: 0x04000B74 RID: 2932
        Private m_bDockImageViewer As Boolean

        ' Token: 0x04000B75 RID: 2933
        Private m_bTextEditorWordWrap As Boolean

        ' Token: 0x04000B76 RID: 2934
        Private m_bAlwaysUnknownGFFasText As Boolean

        ' Token: 0x04000B77 RID: 2935
        Private m_bShowModuleLocations As Boolean

        ' Token: 0x04000B78 RID: 2936
        Private m_bShowModuleDescriptions As Boolean

        ' Token: 0x04000B79 RID: 2937
        Private m_bBuildModelsBifNode As Boolean

        ' Token: 0x04000B7A RID: 2938
        Private _bProjMgrUseExternTxtEditor As Boolean

        ' Token: 0x04000B7B RID: 2939
        Private _bProjMgrUseExternDLGEditor As Boolean

        ' Token: 0x04000B7C RID: 2940
        Private _projMgrDLGEditorPath As String

        ' Token: 0x04000B7D RID: 2941
        Private _projMgrTxtEditorPath As String

        ' Token: 0x04000B7E RID: 2942
        Private m_ImageViewerWindowLoc As Point

        ' Token: 0x04000B7F RID: 2943
        Private m_frmGlobalVarEditorWindowLoc As Point

        ' Token: 0x04000B80 RID: 2944
        Private m_ImageViewerWindowSize As Size

        ' Token: 0x04000B81 RID: 2945
        Private m_frmGlobalVarEditorWindowSize As Size

        ' Token: 0x04000B82 RID: 2946
        Private m_ByteViewerWindowLoc As Point

        ' Token: 0x04000B83 RID: 2947
        Private m_ByteViewerWindowSize As Size

        ' Token: 0x04000B84 RID: 2948
        Private m_TextEditorWindowLoc As Point

        ' Token: 0x04000B85 RID: 2949
        Private m_TextEditorWindowSize As Size

        ' Token: 0x04000B86 RID: 2950
        Private m_ERFManagerWindowLoc As Point

        ' Token: 0x04000B87 RID: 2951
        Private m_ERFManagerWindowSize As Size

        ' Token: 0x04000B88 RID: 2952
        Private m_2DAEditorWindowLoc As Point

        ' Token: 0x04000B89 RID: 2953
        Private m_2DAEditorWindowSize As Size

        ' Token: 0x04000B8A RID: 2954
        Private m_UTCEditorWindowLoc As Point

        ' Token: 0x04000B8B RID: 2955
        Private m_UTCEditorWindowSize As Size

        ' Token: 0x04000B8C RID: 2956
        Private m_UTDEditorWindowLoc As Point

        ' Token: 0x04000B8D RID: 2957
        Private m_UTDEditorWindowSize As Size

        ' Token: 0x04000B8E RID: 2958
        Private m_UTIEditorWindowLoc As Point

        ' Token: 0x04000B8F RID: 2959
        Private m_UTIEditorWindowSize As Size

        ' Token: 0x04000B90 RID: 2960
        Private m_UTMEditorWindowLoc As Point

        ' Token: 0x04000B91 RID: 2961
        Private m_UTMEditorWindowSize As Size

        ' Token: 0x04000B92 RID: 2962
        Private m_UTPEditorWindowLoc As Point

        ' Token: 0x04000B93 RID: 2963
        Private m_UTPEditorWindowSize As Size

        ' Token: 0x04000B94 RID: 2964
        Private m_UTSEditorWindowLoc As Point

        ' Token: 0x04000B95 RID: 2965
        Private m_UTSEditorWindowSize As Size

        ' Token: 0x04000B96 RID: 2966
        Private m_UTTEditorWindowLoc As Point

        ' Token: 0x04000B97 RID: 2967
        Private m_UTTEditorWindowSize As Size

        ' Token: 0x04000B98 RID: 2968
        Private m_UTWEditorWindowLoc As Point

        ' Token: 0x04000B99 RID: 2969
        Private m_UTWEditorWindowSize As Size

        ' Token: 0x04000B9A RID: 2970
        Private m_ProjectManagerWindowLoc As Point

        ' Token: 0x04000B9B RID: 2971
        Private m_ProjectManagerWindowSize As Size

        ' Token: 0x04000B9C RID: 2972
        Private m_InventoryEditorWindowLoc As Point

        ' Token: 0x04000B9D RID: 2973
        Private m_InventoryEditorWindowSize As Size

        ' Token: 0x04000B9E RID: 2974
        Private m_ModuleEditorWindowLoc As Point

        ' Token: 0x04000B9F RID: 2975
        Private m_ModuleEditorWindowSize As Size

        ' Token: 0x04000BA0 RID: 2976
        Private m_Key As String

        ' Token: 0x04000BA1 RID: 2977
        Private m_LastModuleEditedPath As String

        ' Token: 0x04000BA2 RID: 2978
        Private m_bModuleEditorShowLocatorRay As Boolean

        ' Token: 0x04000BA3 RID: 2979
        Private m_bModuleEditorConfirmDeletes As Boolean

        ' Token: 0x04000BA4 RID: 2980
        Private m_ModuleEditorModuleElementIndicatorSize As Decimal

        ' Token: 0x04000BA5 RID: 2981
        Private m_MRUMainFiles As ArrayList

        ' Token: 0x04000BA6 RID: 2982
        Private m_TreeOpenPaths As ArrayList

        ' Token: 0x04000BA7 RID: 2983
        Private m_LastClickedTVNodePath As String

        ' Token: 0x04000BA8 RID: 2984
        Private m_bCheckForUpdatesAtStartup As Boolean

        ' Token: 0x04000BA9 RID: 2985
        Private m_bDownloadUpdatesAutomatically As Boolean

        ' Token: 0x04000BAA RID: 2986
        Private m_bRememberLastTreeNode As Boolean

        ' Token: 0x04000BAB RID: 2987
        Private m_bRememberTreeViewState As Boolean

        ' Token: 0x04000BAC RID: 2988
        Private m_bModelExtraction_ExtractAnimations As Boolean

        ' Token: 0x04000BAD RID: 2989
        Private m_bModelExtraction_ConvertSkinToTrimesh As Boolean

        ' Token: 0x04000BAE RID: 2990
        Private m_bModelExtraction_EachModelInOwnDirectory As Boolean

        ' Token: 0x04000BAF RID: 2991
        Private m_bModelExtraction_CleanWorkingDirectoryBeforeExport As Boolean

        ' Token: 0x04000BB0 RID: 2992
        Private m_bUseOverrideFiles As Boolean
    End Class
End Namespace
