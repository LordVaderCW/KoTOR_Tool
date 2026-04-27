Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000064 RID: 100
	Public Partial Class frmOptions
		Inherits Form

		' Token: 0x06000C6F RID: 3183 RVA: 0x002814C0 File Offset: 0x002804C0
		Public Sub New()
			Me.InitializeComponent()
			Me.Setup()
		End Sub

		' Token: 0x1700044A RID: 1098
		' (get) Token: 0x06000C71 RID: 3185 RVA: 0x00281548 File Offset: 0x00280548
		' (set) Token: 0x06000C72 RID: 3186 RVA: 0x002814F4 File Offset: 0x002804F4
		Friend Overridable Property btnOK As Button
			Get
				Return Me._btnOK
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                    RemoveHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                    AddHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
            End Set
        End Property

        ' Token: 0x1700044B RID: 1099
        ' (get) Token: 0x06000C74 RID: 3188 RVA: 0x00281578 File Offset: 0x00280578
        ' (set) Token: 0x06000C73 RID: 3187 RVA: 0x0028155C File Offset: 0x0028055C
        Friend Overridable Property btnCancel() As Button
            Get
                Return Me._btnCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnCancel IsNot Nothing Then
                End If
                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700044C RID: 1100
        ' (get) Token: 0x06000C75 RID: 3189 RVA: 0x0028158C File Offset: 0x0028058C
        ' (set) Token: 0x06000C76 RID: 3190 RVA: 0x002815A0 File Offset: 0x002805A0
        Friend Overridable Property chkbBuildBIFTreeAtStartup() As CheckBox
            Get
                Return Me._chkbBuildBIFTreeAtStartup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbBuildBIFTreeAtStartup IsNot Nothing Then
                End If
                Me._chkbBuildBIFTreeAtStartup = value
                If Me._chkbBuildBIFTreeAtStartup IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700044D RID: 1101
        ' (get) Token: 0x06000C78 RID: 3192 RVA: 0x002815BC File Offset: 0x002805BC
        ' (set) Token: 0x06000C77 RID: 3191 RVA: 0x002815D0 File Offset: 0x002805D0
        Friend Overridable Property chkbAlwaysConvertTPC2TGA() As CheckBox
            Get
                Return Me._chkbAlwaysConvertTPC2TGA
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbAlwaysConvertTPC2TGA IsNot Nothing Then
                End If
                Me._chkbAlwaysConvertTPC2TGA = value
                If Me._chkbAlwaysConvertTPC2TGA IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700044E RID: 1102
        ' (get) Token: 0x06000C7A RID: 3194 RVA: 0x002815EC File Offset: 0x002805EC
        ' (set) Token: 0x06000C79 RID: 3193 RVA: 0x00281600 File Offset: 0x00280600
        Friend Overridable Property chkbDockImageViewer() As CheckBox
            Get
                Return Me._chkbDockImageViewer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbDockImageViewer IsNot Nothing Then
                End If
                Me._chkbDockImageViewer = value
                If Me._chkbDockImageViewer IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700044F RID: 1103
        ' (get) Token: 0x06000C7B RID: 3195 RVA: 0x00281638 File Offset: 0x00280638
        ' (set) Token: 0x06000C7C RID: 3196 RVA: 0x0028161C File Offset: 0x0028061C
        Friend Overridable Property chkbTextEditorWordWrap() As CheckBox
            Get
                Return Me._chkbTextEditorWordWrap
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbTextEditorWordWrap IsNot Nothing Then
                End If
                Me._chkbTextEditorWordWrap = value
                If Me._chkbTextEditorWordWrap IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000450 RID: 1104
        ' (get) Token: 0x06000C7D RID: 3197 RVA: 0x00281668 File Offset: 0x00280668
        ' (set) Token: 0x06000C7E RID: 3198 RVA: 0x0028164C File Offset: 0x0028064C
        Friend Overridable Property chkbBuildModelsBifNode() As CheckBox
            Get
                Return Me._chkbBuildModelsBifNode
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbBuildModelsBifNode IsNot Nothing Then
                End If
                Me._chkbBuildModelsBifNode = value
                If Me._chkbBuildModelsBifNode IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000451 RID: 1105
        ' (get) Token: 0x06000C80 RID: 3200 RVA: 0x0028167C File Offset: 0x0028067C
        ' (set) Token: 0x06000C7F RID: 3199 RVA: 0x00281690 File Offset: 0x00280690
        Friend Overridable Property chkbAlwaysUnknownGFFasText() As CheckBox
            Get
                Return Me._chkbAlwaysUnknownGFFasText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbAlwaysUnknownGFFasText IsNot Nothing Then
                End If
                Me._chkbAlwaysUnknownGFFasText = value
                If Me._chkbAlwaysUnknownGFFasText IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000452 RID: 1106
        ' (get) Token: 0x06000C81 RID: 3201 RVA: 0x002816C8 File Offset: 0x002806C8
        ' (set) Token: 0x06000C82 RID: 3202 RVA: 0x002816AC File Offset: 0x002806AC
        Friend Overridable Property TabControl1() As TabControl
            Get
                Return Me._TabControl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._TabControl1 IsNot Nothing Then
                End If
                Me._TabControl1 = value
                If Me._TabControl1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000453 RID: 1107
        ' (get) Token: 0x06000C84 RID: 3204 RVA: 0x002816DC File Offset: 0x002806DC
        ' (set) Token: 0x06000C83 RID: 3203 RVA: 0x002816F0 File Offset: 0x002806F0
        Friend Overridable Property chkbShowModuleLocations() As CheckBox
            Get
                Return Me._chkbShowModuleLocations
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbShowModuleLocations IsNot Nothing Then
                End If
                Me._chkbShowModuleLocations = value
                If Me._chkbShowModuleLocations IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000454 RID: 1108
        ' (get) Token: 0x06000C85 RID: 3205 RVA: 0x00281728 File Offset: 0x00280728
        ' (set) Token: 0x06000C86 RID: 3206 RVA: 0x0028170C File Offset: 0x0028070C
        Friend Overridable Property chkbShowModuleDescriptions() As CheckBox
            Get
                Return Me._chkbShowModuleDescriptions
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbShowModuleDescriptions IsNot Nothing Then
                End If
                Me._chkbShowModuleDescriptions = value
                If Me._chkbShowModuleDescriptions IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000455 RID: 1109
        ' (get) Token: 0x06000C88 RID: 3208 RVA: 0x00281790 File Offset: 0x00280790
        ' (set) Token: 0x06000C87 RID: 3207 RVA: 0x0028173C File Offset: 0x0028073C
        Friend Overridable Property chkbCheckForUpdatesAtStartup() As CheckBox
            Get
                Return Me._chkbCheckForUpdatesAtStartup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbCheckForUpdatesAtStartup IsNot Nothing Then
                    RemoveHandler Me._chkbCheckForUpdatesAtStartup.CheckedChanged, AddressOf Me.chkbCheckForUpdatesAtStartup_CheckedChanged
                End If
                Me._chkbCheckForUpdatesAtStartup = value
                If Me._chkbCheckForUpdatesAtStartup IsNot Nothing Then
                    AddHandler Me._chkbCheckForUpdatesAtStartup.CheckedChanged, AddressOf Me.chkbCheckForUpdatesAtStartup_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000456 RID: 1110
        ' (get) Token: 0x06000C89 RID: 3209 RVA: 0x002817A4 File Offset: 0x002807A4
        ' (set) Token: 0x06000C8A RID: 3210 RVA: 0x002817B8 File Offset: 0x002807B8
        Friend Overridable Property chkbDownloadUpdatesAutomatically() As CheckBox
            Get
                Return Me._chkbDownloadUpdatesAutomatically
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbDownloadUpdatesAutomatically IsNot Nothing Then
                End If
                Me._chkbDownloadUpdatesAutomatically = value
                If Me._chkbDownloadUpdatesAutomatically IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000457 RID: 1111
        ' (get) Token: 0x06000C8B RID: 3211 RVA: 0x002817D4 File Offset: 0x002807D4
        ' (set) Token: 0x06000C8C RID: 3212 RVA: 0x002817E8 File Offset: 0x002807E8
        Friend Overridable Property chkbRememberLastTreeNode() As CheckBox
            Get
                Return Me._chkbRememberLastTreeNode
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbRememberLastTreeNode IsNot Nothing Then
                End If
                Me._chkbRememberLastTreeNode = value
                If Me._chkbRememberLastTreeNode IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000458 RID: 1112
        ' (get) Token: 0x06000C8D RID: 3213 RVA: 0x00281820 File Offset: 0x00280820
        ' (set) Token: 0x06000C8E RID: 3214 RVA: 0x00281804 File Offset: 0x00280804
        Friend Overridable Property chkbUseOverrideFiles() As CheckBox
            Get
                Return Me._chkbUseOverrideFiles
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbUseOverrideFiles IsNot Nothing Then
                End If
                Me._chkbUseOverrideFiles = value
                If Me._chkbUseOverrideFiles IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000459 RID: 1113
        ' (get) Token: 0x06000C8F RID: 3215 RVA: 0x00281850 File Offset: 0x00280850
        ' (set) Token: 0x06000C90 RID: 3216 RVA: 0x00281834 File Offset: 0x00280834
        Friend Overridable Property chkbRememberTreeViewState() As CheckBox
            Get
                Return Me._chkbRememberTreeViewState
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbRememberTreeViewState IsNot Nothing Then
                End If
                Me._chkbRememberTreeViewState = value
                If Me._chkbRememberTreeViewState IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700045A RID: 1114
        ' (get) Token: 0x06000C91 RID: 3217 RVA: 0x00281880 File Offset: 0x00280880
        ' (set) Token: 0x06000C92 RID: 3218 RVA: 0x00281864 File Offset: 0x00280864
        Friend Overridable Property tabpagTreeview() As TabPage
            Get
                Return Me._tabpagTreeview
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagTreeview IsNot Nothing Then
                End If
                Me._tabpagTreeview = value
                If Me._tabpagTreeview IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700045B RID: 1115
        ' (get) Token: 0x06000C94 RID: 3220 RVA: 0x00281894 File Offset: 0x00280894
        ' (set) Token: 0x06000C93 RID: 3219 RVA: 0x002818A8 File Offset: 0x002808A8
        Friend Overridable Property tabpagOther() As TabPage
            Get
                Return Me._tabpagOther
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagOther IsNot Nothing Then
                End If
                Me._tabpagOther = value
                If Me._tabpagOther IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700045C RID: 1116
        ' (get) Token: 0x06000C96 RID: 3222 RVA: 0x002818C4 File Offset: 0x002808C4
        ' (set) Token: 0x06000C95 RID: 3221 RVA: 0x002818D8 File Offset: 0x002808D8
        Friend Overridable Property tabpagProjectManager() As TabPage
            Get
                Return Me._tabpagProjectManager
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagProjectManager IsNot Nothing Then
                End If
                Me._tabpagProjectManager = value
                If Me._tabpagProjectManager IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700045D RID: 1117
        ' (get) Token: 0x06000C97 RID: 3223 RVA: 0x002818F4 File Offset: 0x002808F4
        ' (set) Token: 0x06000C98 RID: 3224 RVA: 0x00281908 File Offset: 0x00280908
        Friend Overridable Property GroupBox1() As GroupBox
            Get
                Return Me._GroupBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox1 IsNot Nothing Then
                End If
                Me._GroupBox1 = value
                If Me._GroupBox1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700045E RID: 1118
        ' (get) Token: 0x06000C99 RID: 3225 RVA: 0x00281924 File Offset: 0x00280924
        ' (set) Token: 0x06000C9A RID: 3226 RVA: 0x00281938 File Offset: 0x00280938
        Friend Overridable Property GroupBox2() As GroupBox
            Get
                Return Me._GroupBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox2 IsNot Nothing Then
                End If
                Me._GroupBox2 = value
                If Me._GroupBox2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700045F RID: 1119
        ' (get) Token: 0x06000C9C RID: 3228 RVA: 0x00281954 File Offset: 0x00280954
        ' (set) Token: 0x06000C9B RID: 3227 RVA: 0x00281968 File Offset: 0x00280968
        Friend Overridable Property rbProjMgrUseExternDLGEditor() As RadioButton
            Get
                Return Me._rbProjMgrUseExternDLGEditor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbProjMgrUseExternDLGEditor IsNot Nothing Then
                    RemoveHandler Me._rbProjMgrUseExternDLGEditor.CheckedChanged, AddressOf Me.rbProjMgrUseExternDLGEditor_CheckedChanged
                End If
                Me._rbProjMgrUseExternDLGEditor = value
                If Me._rbProjMgrUseExternDLGEditor IsNot Nothing Then
                    AddHandler Me._rbProjMgrUseExternDLGEditor.CheckedChanged, AddressOf Me.rbProjMgrUseExternDLGEditor_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000460 RID: 1120
        ' (get) Token: 0x06000C9E RID: 3230 RVA: 0x002819BC File Offset: 0x002809BC
        ' (set) Token: 0x06000C9D RID: 3229 RVA: 0x002819D0 File Offset: 0x002809D0
        Friend Overridable Property rbProjMgrUseExternTxtEditor() As RadioButton
            Get
                Return Me._rbProjMgrUseExternTxtEditor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbProjMgrUseExternTxtEditor IsNot Nothing Then
                    RemoveHandler Me._rbProjMgrUseExternTxtEditor.CheckedChanged, AddressOf Me.rbProjMgrUseExternTxtEditor_CheckedChanged_1
                End If
                Me._rbProjMgrUseExternTxtEditor = value
                If Me._rbProjMgrUseExternTxtEditor IsNot Nothing Then
                    AddHandler Me._rbProjMgrUseExternTxtEditor.CheckedChanged, AddressOf Me.rbProjMgrUseExternTxtEditor_CheckedChanged_1
                End If
            End Set
        End Property

        ' Token: 0x17000461 RID: 1121
        ' (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00281A24 File Offset: 0x00280A24
        ' (set) Token: 0x06000C9F RID: 3231 RVA: 0x00281A38 File Offset: 0x00280A38
        Friend Overridable Property btnBrowseProjMgrDLGEditorPath() As Button
            Get
                Return Me._btnBrowseProjMgrDLGEditorPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnBrowseProjMgrDLGEditorPath IsNot Nothing Then
                    RemoveHandler Me._btnBrowseProjMgrDLGEditorPath.Click, AddressOf Me.btnBrowseProjMgrDLGEditorPath_Click
                End If
                Me._btnBrowseProjMgrDLGEditorPath = value
                If Me._btnBrowseProjMgrDLGEditorPath IsNot Nothing Then
                    AddHandler Me._btnBrowseProjMgrDLGEditorPath.Click, AddressOf Me.btnBrowseProjMgrDLGEditorPath_Click
                End If
            End Set
        End Property

        ' Token: 0x17000462 RID: 1122
        ' (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00281A8C File Offset: 0x00280A8C
        ' (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00281AA0 File Offset: 0x00280AA0
        Friend Overridable Property tbProjMgrDLGEditorPath() As TextBox
            Get
                Return Me._tbProjMgrDLGEditorPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbProjMgrDLGEditorPath IsNot Nothing Then
                End If
                Me._tbProjMgrDLGEditorPath = value
                If Me._tbProjMgrDLGEditorPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000463 RID: 1123
        ' (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00281ABC File Offset: 0x00280ABC
        ' (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00281AD0 File Offset: 0x00280AD0
        Friend Overridable Property btnBrowseProjMgrTxtEditorPath() As Button
            Get
                Return Me._btnBrowseProjMgrTxtEditorPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnBrowseProjMgrTxtEditorPath IsNot Nothing Then
                    RemoveHandler Me._btnBrowseProjMgrTxtEditorPath.Click, AddressOf Me.btnBrowseProjMgrTxtEditorPath_Click
                End If
                Me._btnBrowseProjMgrTxtEditorPath = value
                If Me._btnBrowseProjMgrTxtEditorPath IsNot Nothing Then
                    AddHandler Me._btnBrowseProjMgrTxtEditorPath.Click, AddressOf Me.btnBrowseProjMgrTxtEditorPath_Click
                End If
            End Set
        End Property

        ' Token: 0x17000464 RID: 1124
        ' (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00281B24 File Offset: 0x00280B24
        ' (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00281B38 File Offset: 0x00280B38
        Friend Overridable Property tbProjMgrTxtEditorPath() As TextBox
            Get
                Return Me._tbProjMgrTxtEditorPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbProjMgrTxtEditorPath IsNot Nothing Then
                End If
                Me._tbProjMgrTxtEditorPath = value
                If Me._tbProjMgrTxtEditorPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000465 RID: 1125
        ' (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00281B70 File Offset: 0x00280B70
        ' (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00281B54 File Offset: 0x00280B54
        Friend Overridable Property rbProjMgrUseInternDLGEditor() As RadioButton
            Get
                Return Me._rbProjMgrUseInternDLGEditor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbProjMgrUseInternDLGEditor IsNot Nothing Then
                End If
                Me._rbProjMgrUseInternDLGEditor = value
                If Me._rbProjMgrUseInternDLGEditor IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000466 RID: 1126
        ' (get) Token: 0x06000CAA RID: 3242 RVA: 0x00281B84 File Offset: 0x00280B84
        ' (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00281B98 File Offset: 0x00280B98
        Friend Overridable Property rbProjMgrUseInternTxtEditor() As RadioButton
            Get
                Return Me._rbProjMgrUseInternTxtEditor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbProjMgrUseInternTxtEditor IsNot Nothing Then
                End If
                Me._rbProjMgrUseInternTxtEditor = value
                If Me._rbProjMgrUseInternTxtEditor IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x06000CAC RID: 3244 RVA: 0x00282C78 File Offset: 0x00281C78
        Public Sub Setup()
            Me.options = UserSettings.GetSettings()
            Me.chkbBuildBIFTreeAtStartup.Checked = Me.options.bBuildBIFFtreeOnStartup
            Me.chkbBuildModelsBifNode.Checked = Me.options.bBuildModelsBifNode
            Me.chkbAlwaysUnknownGFFasText.Checked = Me.options.bAlwaysUnknownGFFasText
            Me.chkbAlwaysConvertTPC2TGA.Checked = Me.options.bAlwaysConvertTPC2TGA
            Me.chkbDockImageViewer.Checked = Me.options.bDockImageViewer
            Me.chkbTextEditorWordWrap.Checked = Me.options.bTextEditorWordWrap
            Me.chkbShowModuleDescriptions.Checked = Me.options.bShowModuleDescriptions
            Me.chkbShowModuleLocations.Checked = Me.options.bShowModuleLocations
            Me.chkbCheckForUpdatesAtStartup.Checked = Me.options.bCheckForUpdatesAtStartup
            Me.chkbDownloadUpdatesAutomatically.Checked = Me.options.bDownloadUpdatesAutomatically And Me.chkbCheckForUpdatesAtStartup.Checked
            Me.chkbRememberLastTreeNode.Checked = Me.options.bRememberLastTreeNode
            Me.chkbRememberTreeViewState.Checked = Me.options.bRememberTreeViewState
            Me.chkbUseOverrideFiles.Checked = Me.options.bUseOverrideFiles
            If Me.options.bProjMgrUseExternTxtEditor AndAlso StringType.StrCmp(Me.options.ProjMgrTxtEditorPath, "", False) <> 0 Then
                Me.rbProjMgrUseExternTxtEditor.Checked = True
                Me.tbProjMgrTxtEditorPath.Text = Me.options.ProjMgrTxtEditorPath
            Else
                Me.rbProjMgrUseInternTxtEditor.Checked = True
            End If
            If Me.options.bProjMgrUseExternDLGEditor AndAlso StringType.StrCmp(Me.options.ProjMgrDLGEditorPath, "", False) <> 0 Then
                Me.rbProjMgrUseExternDLGEditor.Checked = True
                Me.tbProjMgrDLGEditorPath.Text = Me.options.ProjMgrDLGEditorPath
            Else
                Me.rbProjMgrUseInternDLGEditor.Checked = True
            End If
        End Sub

        ' Token: 0x06000CAD RID: 3245 RVA: 0x00282E68 File Offset: 0x00281E68
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.options.bBuildBIFFtreeOnStartup = Me.chkbBuildBIFTreeAtStartup.Checked
            Me.options.bBuildModelsBifNode = Me.chkbBuildModelsBifNode.Checked
            Me.options.bAlwaysUnknownGFFasText = Me.chkbAlwaysUnknownGFFasText.Checked
            Me.options.bAlwaysConvertTPC2TGA = Me.chkbAlwaysConvertTPC2TGA.Checked
            Me.options.bDockImageViewer = Me.chkbDockImageViewer.Checked
            Me.options.bTextEditorWordWrap = Me.chkbTextEditorWordWrap.Checked
            Me.options.bShowModuleDescriptions = Me.chkbShowModuleDescriptions.Checked
            Me.options.bShowModuleLocations = Me.chkbShowModuleLocations.Checked
            Me.options.bCheckForUpdatesAtStartup = Me.chkbCheckForUpdatesAtStartup.Checked
            Me.options.bDownloadUpdatesAutomatically = Me.chkbDownloadUpdatesAutomatically.Checked
            If Not Me.options.bRememberLastTreeNode And Me.chkbRememberLastTreeNode.Checked Then
                Me.options.LastClickedTVNodePath = ""
            End If
            Me.options.bRememberLastTreeNode = Me.chkbRememberLastTreeNode.Checked
            Me.options.bRememberTreeViewState = Me.chkbRememberTreeViewState.Checked
            Me.options.bUseOverrideFiles = Me.chkbUseOverrideFiles.Checked
            If Me.rbProjMgrUseExternTxtEditor.Checked AndAlso StringType.StrCmp(Me.tbProjMgrTxtEditorPath.Text.Trim(), "", False) <> 0 Then
                Me.options.bProjMgrUseExternTxtEditor = True
                Me.options.ProjMgrTxtEditorPath = Me.tbProjMgrTxtEditorPath.Text
            Else
                Me.options.bProjMgrUseExternTxtEditor = False
                Me.options.ProjMgrTxtEditorPath = ""
            End If
            If Me.rbProjMgrUseExternDLGEditor.Checked AndAlso StringType.StrCmp(Me.tbProjMgrDLGEditorPath.Text.Trim(), "", False) <> 0 Then
                Me.options.bProjMgrUseExternDLGEditor = True
                Me.options.ProjMgrDLGEditorPath = Me.tbProjMgrDLGEditorPath.Text
            Else
                Me.options.bProjMgrUseExternDLGEditor = False
                Me.options.ProjMgrDLGEditorPath = ""
            End If
            UserSettings.SaveSettings(Me.options)
        End Sub

        ' Token: 0x06000CAE RID: 3246 RVA: 0x002830A0 File Offset: 0x002820A0
        Private Sub chkbCheckForUpdatesAtStartup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.chkbDownloadUpdatesAutomatically.Enabled = Me.chkbCheckForUpdatesAtStartup.Checked
            Me.chkbDownloadUpdatesAutomatically.Checked = Me.chkbCheckForUpdatesAtStartup.Checked
        End Sub

        ' Token: 0x06000CAF RID: 3247 RVA: 0x002830D0 File Offset: 0x002820D0
        Private Sub btnBrowseProjMgrDLGEditorPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", "C:\", "*.exe", "Select the Dialog Editor you wish to use", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.tbProjMgrDLGEditorPath.Text = text
        End Sub

        ' Token: 0x06000CB0 RID: 3248 RVA: 0x00283120 File Offset: 0x00282120
        Private Sub btnBrowseProjMgrTxtEditorPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", "C:\", "*.exe", "Select the Text Editor you wish to use", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.tbProjMgrTxtEditorPath.Text = text
        End Sub

        ' Token: 0x06000CB1 RID: 3249 RVA: 0x00283170 File Offset: 0x00282170
        Private Sub rbProjMgrUseExternDLGEditor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checked As Boolean = CType(sender, RadioButton).Checked
            Me.tbProjMgrDLGEditorPath.Enabled = checked
            Me.btnBrowseProjMgrDLGEditorPath.Enabled = checked
        End Sub

        ' Token: 0x06000CB2 RID: 3250 RVA: 0x002831A4 File Offset: 0x002821A4
        Private Sub rbProjMgrUseExternTxtEditor_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs)
            Dim checked As Boolean = CType(sender, RadioButton).Checked
            Me.tbProjMgrTxtEditorPath.Enabled = checked
            Me.btnBrowseProjMgrTxtEditorPath.Enabled = checked
        End Sub

        ' Token: 0x04000633 RID: 1587
        <AccessedThroughProperty("btnBrowseProjMgrDLGEditorPath")> _
        Private _btnBrowseProjMgrDLGEditorPath As Button

        ' Token: 0x04000634 RID: 1588
        <AccessedThroughProperty("rbProjMgrUseExternTxtEditor")> _
        Private _rbProjMgrUseExternTxtEditor As RadioButton

        ' Token: 0x04000635 RID: 1589
        <AccessedThroughProperty("rbProjMgrUseExternDLGEditor")> _
        Private _rbProjMgrUseExternDLGEditor As RadioButton

        ' Token: 0x04000636 RID: 1590
        <AccessedThroughProperty("GroupBox2")> _
        Private _GroupBox2 As GroupBox

        ' Token: 0x04000637 RID: 1591
        <AccessedThroughProperty("btnBrowseProjMgrTxtEditorPath")> _
        Private _btnBrowseProjMgrTxtEditorPath As Button

        ' Token: 0x04000638 RID: 1592
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox

        ' Token: 0x04000639 RID: 1593
        <AccessedThroughProperty("tabpagProjectManager")> _
        Private _tabpagProjectManager As TabPage

        ' Token: 0x0400063A RID: 1594
        <AccessedThroughProperty("tabpagOther")> _
        Private _tabpagOther As TabPage

        ' Token: 0x0400063B RID: 1595
        <AccessedThroughProperty("tabpagTreeview")> _
        Private _tabpagTreeview As TabPage

        ' Token: 0x0400063C RID: 1596
        <AccessedThroughProperty("chkbRememberTreeViewState")> _
        Private _chkbRememberTreeViewState As CheckBox

        ' Token: 0x0400063D RID: 1597
        <AccessedThroughProperty("chkbUseOverrideFiles")> _
        Private _chkbUseOverrideFiles As CheckBox

        ' Token: 0x0400063E RID: 1598
        <AccessedThroughProperty("chkbRememberLastTreeNode")> _
        Private _chkbRememberLastTreeNode As CheckBox

        ' Token: 0x0400063F RID: 1599
        <AccessedThroughProperty("chkbDownloadUpdatesAutomatically")> _
        Private _chkbDownloadUpdatesAutomatically As CheckBox

        ' Token: 0x04000640 RID: 1600
        <AccessedThroughProperty("chkbCheckForUpdatesAtStartup")> _
        Private _chkbCheckForUpdatesAtStartup As CheckBox

        ' Token: 0x04000641 RID: 1601
        <AccessedThroughProperty("chkbShowModuleDescriptions")> _
        Private _chkbShowModuleDescriptions As CheckBox

        ' Token: 0x04000642 RID: 1602
        <AccessedThroughProperty("tbProjMgrTxtEditorPath")> _
        Private _tbProjMgrTxtEditorPath As TextBox

        ' Token: 0x04000643 RID: 1603
        <AccessedThroughProperty("chkbShowModuleLocations")> _
        Private _chkbShowModuleLocations As CheckBox

        ' Token: 0x04000644 RID: 1604
        <AccessedThroughProperty("rbProjMgrUseInternDLGEditor")> _
        Private _rbProjMgrUseInternDLGEditor As RadioButton

        ' Token: 0x04000645 RID: 1605
        <AccessedThroughProperty("chkbAlwaysUnknownGFFasText")> _
        Private _chkbAlwaysUnknownGFFasText As CheckBox

        ' Token: 0x04000646 RID: 1606
        <AccessedThroughProperty("rbProjMgrUseInternTxtEditor")> _
        Private _rbProjMgrUseInternTxtEditor As RadioButton

        ' Token: 0x04000647 RID: 1607
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x04000648 RID: 1608
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000649 RID: 1609
        <AccessedThroughProperty("chkbBuildBIFTreeAtStartup")> _
        Private _chkbBuildBIFTreeAtStartup As CheckBox

        ' Token: 0x0400064A RID: 1610
        <AccessedThroughProperty("tbProjMgrDLGEditorPath")> _
        Private _tbProjMgrDLGEditorPath As TextBox

        ' Token: 0x0400064B RID: 1611
        <AccessedThroughProperty("chkbAlwaysConvertTPC2TGA")> _
        Private _chkbAlwaysConvertTPC2TGA As CheckBox

        ' Token: 0x0400064C RID: 1612
        <AccessedThroughProperty("chkbDockImageViewer")> _
        Private _chkbDockImageViewer As CheckBox

        ' Token: 0x0400064D RID: 1613
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x0400064E RID: 1614
        <AccessedThroughProperty("chkbTextEditorWordWrap")> _
        Private _chkbTextEditorWordWrap As CheckBox

        ' Token: 0x0400064F RID: 1615
        <AccessedThroughProperty("chkbBuildModelsBifNode")> _
        Private _chkbBuildModelsBifNode As CheckBox

        ' Token: 0x04000651 RID: 1617
        Private options As Options
    End Class
End Namespace
