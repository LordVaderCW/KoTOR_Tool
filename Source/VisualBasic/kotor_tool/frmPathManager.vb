Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace kotor_tool
	' Token: 0x02000068 RID: 104
	Public Partial Class frmPathManager
		Inherits Form

		' Token: 0x06000CD3 RID: 3283 RVA: 0x00283DE4 File Offset: 0x00282DE4
		Public Sub New()
			Me.InitializeComponent()
			Me.CreateNew()
		End Sub

		' Token: 0x17000470 RID: 1136
		' (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00283E34 File Offset: 0x00282E34
		' (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00283E18 File Offset: 0x00282E18
		Friend Overridable Property Label7 As Label
			Get
				Return Me._Label7
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label7 IsNot Nothing Then
                End If
                Me._Label7 = value
                If Me._Label7 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000471 RID: 1137
        ' (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00283E64 File Offset: 0x00282E64
        ' (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00283E48 File Offset: 0x00282E48
        Friend Overridable Property tbKotorPath() As TextBox
            Get
                Return Me._tbKotorPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbKotorPath IsNot Nothing Then
                End If
                Me._tbKotorPath = value
                If Me._tbKotorPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000472 RID: 1138
        ' (get) Token: 0x06000CDA RID: 3290 RVA: 0x00283E78 File Offset: 0x00282E78
        ' (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00283E8C File Offset: 0x00282E8C
        Friend Overridable Property btnKotorPath() As Button
            Get
                Return Me._btnKotorPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnKotorPath IsNot Nothing Then
                    RemoveHandler Me._btnKotorPath.Click, AddressOf Me.btnKotorPath_Click
                End If
                Me._btnKotorPath = value
                If Me._btnKotorPath IsNot Nothing Then
                    AddHandler Me._btnKotorPath.Click, AddressOf Me.btnKotorPath_Click
                End If
            End Set
        End Property

        ' Token: 0x17000473 RID: 1139
        ' (get) Token: 0x06000CDB RID: 3291 RVA: 0x00283EE0 File Offset: 0x00282EE0
        ' (set) Token: 0x06000CDC RID: 3292 RVA: 0x00283EF4 File Offset: 0x00282EF4
        Friend Overridable Property btnOK() As Button
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

        ' Token: 0x17000474 RID: 1140
        ' (get) Token: 0x06000CDD RID: 3293 RVA: 0x00283F48 File Offset: 0x00282F48
        ' (set) Token: 0x06000CDE RID: 3294 RVA: 0x00283F5C File Offset: 0x00282F5C
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

        ' Token: 0x17000475 RID: 1141
        ' (get) Token: 0x06000CDF RID: 3295 RVA: 0x00283F94 File Offset: 0x00282F94
        ' (set) Token: 0x06000CE0 RID: 3296 RVA: 0x00283F78 File Offset: 0x00282F78
        Friend Overridable Property ToolTip1() As ToolTip
            Get
                Return Me._ToolTip1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ToolTip)
                If Me._ToolTip1 IsNot Nothing Then
                End If
                Me._ToolTip1 = value
                If Me._ToolTip1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000476 RID: 1142
        ' (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00283FA8 File Offset: 0x00282FA8
        ' (set) Token: 0x06000CE2 RID: 3298 RVA: 0x00283FBC File Offset: 0x00282FBC
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

        ' Token: 0x17000477 RID: 1143
        ' (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00283FF4 File Offset: 0x00282FF4
        ' (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00283FD8 File Offset: 0x00282FD8
        Friend Overridable Property TabPage1() As TabPage
            Get
                Return Me._TabPage1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage1 IsNot Nothing Then
                End If
                Me._TabPage1 = value
                If Me._TabPage1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000478 RID: 1144
        ' (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00284008 File Offset: 0x00283008
        ' (set) Token: 0x06000CE5 RID: 3301 RVA: 0x0028401C File Offset: 0x0028301C
        Friend Overridable Property TabPage2() As TabPage
            Get
                Return Me._TabPage2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage2 IsNot Nothing Then
                End If
                Me._TabPage2 = value
                If Me._TabPage2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000479 RID: 1145
        ' (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00284054 File Offset: 0x00283054
        ' (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00284038 File Offset: 0x00283038
        Friend Overridable Property Label14() As Label
            Get
                Return Me._Label14
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label14 IsNot Nothing Then
                End If
                Me._Label14 = value
                If Me._Label14 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700047A RID: 1146
        ' (get) Token: 0x06000CEA RID: 3306 RVA: 0x00284084 File Offset: 0x00283084
        ' (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00284068 File Offset: 0x00283068
        Friend Overridable Property tbKotorPath2() As TextBox
            Get
                Return Me._tbKotorPath2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbKotorPath2 IsNot Nothing Then
                End If
                Me._tbKotorPath2 = value
                If Me._tbKotorPath2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700047B RID: 1147
        ' (get) Token: 0x06000CEC RID: 3308 RVA: 0x00284098 File Offset: 0x00283098
        ' (set) Token: 0x06000CEB RID: 3307 RVA: 0x002840AC File Offset: 0x002830AC
        Friend Overridable Property Label6() As Label
            Get
                Return Me._Label6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label6 IsNot Nothing Then
                End If
                Me._Label6 = value
                If Me._Label6 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700047C RID: 1148
        ' (get) Token: 0x06000CEE RID: 3310 RVA: 0x002840C8 File Offset: 0x002830C8
        ' (set) Token: 0x06000CED RID: 3309 RVA: 0x002840DC File Offset: 0x002830DC
        Friend Overridable Property btnImportPath() As Button
            Get
                Return Me._btnImportPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnImportPath IsNot Nothing Then
                    RemoveHandler Me._btnImportPath.Click, AddressOf Me.btnImportPath_Click
                End If
                Me._btnImportPath = value
                If Me._btnImportPath IsNot Nothing Then
                    AddHandler Me._btnImportPath.Click, AddressOf Me.btnImportPath_Click
                End If
            End Set
        End Property

        ' Token: 0x1700047D RID: 1149
        ' (get) Token: 0x06000CEF RID: 3311 RVA: 0x00284184 File Offset: 0x00283184
        ' (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00284130 File Offset: 0x00283130
        Friend Overridable Property btnSavePath() As Button
            Get
                Return Me._btnSavePath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSavePath IsNot Nothing Then
                    RemoveHandler Me._btnSavePath.Click, AddressOf Me.btnSavePath_Click
                End If
                Me._btnSavePath = value
                If Me._btnSavePath IsNot Nothing Then
                    AddHandler Me._btnSavePath.Click, AddressOf Me.btnSavePath_Click
                End If
            End Set
        End Property

        ' Token: 0x1700047E RID: 1150
        ' (get) Token: 0x06000CF2 RID: 3314 RVA: 0x00284198 File Offset: 0x00283198
        ' (set) Token: 0x06000CF1 RID: 3313 RVA: 0x002841AC File Offset: 0x002831AC
        Friend Overridable Property tbSavePath() As TextBox
            Get
                Return Me._tbSavePath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbSavePath IsNot Nothing Then
                End If
                Me._tbSavePath = value
                If Me._tbSavePath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700047F RID: 1151
        ' (get) Token: 0x06000CF3 RID: 3315 RVA: 0x002841E4 File Offset: 0x002831E4
        ' (set) Token: 0x06000CF4 RID: 3316 RVA: 0x002841C8 File Offset: 0x002831C8
        Friend Overridable Property Label5() As Label
            Get
                Return Me._Label5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label5 IsNot Nothing Then
                End If
                Me._Label5 = value
                If Me._Label5 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000480 RID: 1152
        ' (get) Token: 0x06000CF5 RID: 3317 RVA: 0x002841F8 File Offset: 0x002831F8
        ' (set) Token: 0x06000CF6 RID: 3318 RVA: 0x0028420C File Offset: 0x0028320C
        Friend Overridable Property Label3() As Label
            Get
                Return Me._Label3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label3 IsNot Nothing Then
                End If
                Me._Label3 = value
                If Me._Label3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000481 RID: 1153
        ' (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00284228 File Offset: 0x00283228
        ' (set) Token: 0x06000CF7 RID: 3319 RVA: 0x0028423C File Offset: 0x0028323C
        Friend Overridable Property tbImageViewerPath() As TextBox
            Get
                Return Me._tbImageViewerPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbImageViewerPath IsNot Nothing Then
                End If
                Me._tbImageViewerPath = value
                If Me._tbImageViewerPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000482 RID: 1154
        ' (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00284258 File Offset: 0x00283258
        ' (set) Token: 0x06000CFA RID: 3322 RVA: 0x0028426C File Offset: 0x0028326C
        Friend Overridable Property btnImageViewerPath() As Button
            Get
                Return Me._btnImageViewerPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnImageViewerPath IsNot Nothing Then
                    RemoveHandler Me._btnImageViewerPath.Click, AddressOf Me.btnImageViewerPath_Click
                End If
                Me._btnImageViewerPath = value
                If Me._btnImageViewerPath IsNot Nothing Then
                    AddHandler Me._btnImageViewerPath.Click, AddressOf Me.btnImageViewerPath_Click
                End If
            End Set
        End Property

        ' Token: 0x17000483 RID: 1155
        ' (get) Token: 0x06000CFB RID: 3323 RVA: 0x002842DC File Offset: 0x002832DC
        ' (set) Token: 0x06000CFC RID: 3324 RVA: 0x002842C0 File Offset: 0x002832C0
        Friend Overridable Property tbImportPath() As TextBox
            Get
                Return Me._tbImportPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbImportPath IsNot Nothing Then
                End If
                Me._tbImportPath = value
                If Me._tbImportPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000484 RID: 1156
        ' (get) Token: 0x06000CFD RID: 3325 RVA: 0x002842F0 File Offset: 0x002832F0
        ' (set) Token: 0x06000CFE RID: 3326 RVA: 0x00284304 File Offset: 0x00283304
        Friend Overridable Property btnKotorPath2() As Button
            Get
                Return Me._btnKotorPath2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnKotorPath2 IsNot Nothing Then
                    RemoveHandler Me._btnKotorPath2.Click, AddressOf Me.btnKotorPath2_Click
                End If
                Me._btnKotorPath2 = value
                If Me._btnKotorPath2 IsNot Nothing Then
                    AddHandler Me._btnKotorPath2.Click, AddressOf Me.btnKotorPath2_Click
                End If
            End Set
        End Property

        ' Token: 0x17000485 RID: 1157
        ' (get) Token: 0x06000D00 RID: 3328 RVA: 0x002843AC File Offset: 0x002833AC
        ' (set) Token: 0x06000CFF RID: 3327 RVA: 0x00284358 File Offset: 0x00283358
        Friend Overridable Property btnAutoDetectKotor1() As Button
            Get
                Return Me._btnAutoDetectKotor1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnAutoDetectKotor1 IsNot Nothing Then
                    RemoveHandler Me._btnAutoDetectKotor1.Click, AddressOf Me.btnAutoDetectKotor1_Click
                End If
                Me._btnAutoDetectKotor1 = value
                If Me._btnAutoDetectKotor1 IsNot Nothing Then
                    AddHandler Me._btnAutoDetectKotor1.Click, AddressOf Me.btnAutoDetectKotor1_Click
                End If
            End Set
        End Property

        ' Token: 0x17000486 RID: 1158
        ' (get) Token: 0x06000D01 RID: 3329 RVA: 0x002843C0 File Offset: 0x002833C0
        ' (set) Token: 0x06000D02 RID: 3330 RVA: 0x002843D4 File Offset: 0x002833D4
        Friend Overridable Property btnAutoDetectKotor2() As Button
            Get
                Return Me._btnAutoDetectKotor2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnAutoDetectKotor2 IsNot Nothing Then
                    RemoveHandler Me._btnAutoDetectKotor2.Click, AddressOf Me.btnAutoDetectKotor2_Click
                End If
                Me._btnAutoDetectKotor2 = value
                If Me._btnAutoDetectKotor2 IsNot Nothing Then
                    AddHandler Me._btnAutoDetectKotor2.Click, AddressOf Me.btnAutoDetectKotor2_Click
                End If
            End Set
        End Property

        ' Token: 0x17000487 RID: 1159
        ' (get) Token: 0x06000D03 RID: 3331 RVA: 0x00284428 File Offset: 0x00283428
        ' (set) Token: 0x06000D04 RID: 3332 RVA: 0x0028443C File Offset: 0x0028343C
        Friend Overridable Property TabPage3() As TabPage
            Get
                Return Me._TabPage3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage3 IsNot Nothing Then
                End If
                Me._TabPage3 = value
                If Me._TabPage3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000488 RID: 1160
        ' (get) Token: 0x06000D05 RID: 3333 RVA: 0x00284458 File Offset: 0x00283458
        ' (set) Token: 0x06000D06 RID: 3334 RVA: 0x0028446C File Offset: 0x0028346C
        Friend Overridable Property Label15() As Label
            Get
                Return Me._Label15
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label15 IsNot Nothing Then
                End If
                Me._Label15 = value
                If Me._Label15 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000489 RID: 1161
        ' (get) Token: 0x06000D08 RID: 3336 RVA: 0x002844A4 File Offset: 0x002834A4
        ' (set) Token: 0x06000D07 RID: 3335 RVA: 0x00284488 File Offset: 0x00283488
        Friend Overridable Property tbModuleExportPath() As TextBox
            Get
                Return Me._tbModuleExportPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbModuleExportPath IsNot Nothing Then
                End If
                Me._tbModuleExportPath = value
                If Me._tbModuleExportPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700048A RID: 1162
        ' (get) Token: 0x06000D09 RID: 3337 RVA: 0x002844B8 File Offset: 0x002834B8
        ' (set) Token: 0x06000D0A RID: 3338 RVA: 0x002844CC File Offset: 0x002834CC
        Friend Overridable Property btnModuleExportPath() As Button
            Get
                Return Me._btnModuleExportPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnModuleExportPath IsNot Nothing Then
                    RemoveHandler Me._btnModuleExportPath.Click, AddressOf Me.btnModuleExportPath_Click
                End If
                Me._btnModuleExportPath = value
                If Me._btnModuleExportPath IsNot Nothing Then
                    AddHandler Me._btnModuleExportPath.Click, AddressOf Me.btnModuleExportPath_Click
                End If
            End Set
        End Property

        ' Token: 0x06000D0C RID: 3340 RVA: 0x00285478 File Offset: 0x00284478
        Public Sub CreateNew()
            Me.options = UserSettings.GetSettings()
            Me.tbKotorPath.Text = Me.options.KotorLocation(0)
            Me.tbKotorPath2.Text = Me.options.KotorLocation(1)
            Me.tbImportPath.Text = Me.options.defaultImportLocation
            Me.tbSavePath.Text = Me.options.defaultSaveLocation
            Me.tbImageViewerPath.Text = Me.options.ImageViewerLocation
            Me.tbModuleExportPath.Text = Me.options.ModelExportLocation
        End Sub

        ' Token: 0x06000D0D RID: 3341 RVA: 0x00285518 File Offset: 0x00284518
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.options.defaultKotORLocation = Me.tbKotorPath.Text
            Me.options.defaultKotORLocation2 = Me.tbKotorPath2.Text
            Me.options.defaultImportLocation = Me.tbImportPath.Text
            Me.options.defaultSaveLocation = Me.tbSavePath.Text
            Me.options.ImageViewerLocation = Me.tbImageViewerPath.Text
            Me.options.ModelExportLocation = Me.tbModuleExportPath.Text
            UserSettings.SaveSettings(Me.options)
        End Sub

        ' Token: 0x06000D0E RID: 3342 RVA: 0x002855B4 File Offset: 0x002845B4
        Private Sub BrowseForFolder(ByRef fld As TextBox)
            Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
            folderBrowserDialog.Description = "Locate folder"
            folderBrowserDialog.SelectedPath = fld.Text
            folderBrowserDialog.ShowNewFolderButton = False
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = folderBrowserDialog.SelectedPath
            End If
        End Sub

        ' Token: 0x06000D0F RID: 3343 RVA: 0x002855FC File Offset: 0x002845FC
        Private Sub BrowseForFile(ByRef fld As TextBox)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Title = "Select Chitin.key file..."
            openFileDialog.Filter = "Chitin files (*.key)|*.key"
            openFileDialog.InitialDirectory = fld.Text
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = False
            openFileDialog.RestoreDirectory = True
            openFileDialog.FileName = "chitin.key"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = openFileDialog.FileName
            End If
        End Sub

        ' Token: 0x06000D10 RID: 3344 RVA: 0x00285668 File Offset: 0x00284668
        Private Sub BrowseForApp(ByRef fld As TextBox)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Title = "Select Program file..."
            openFileDialog.Filter = "Image Viewer Application (*.exe)|*.exe"
            If StringType.StrCmp(fld.Text, "", False) <> 0 Then
                openFileDialog.InitialDirectory = Strings.Mid(fld.Text, 1, fld.Text.LastIndexOf("\"))
            End If
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = False
            openFileDialog.RestoreDirectory = True
            If StringType.StrCmp(fld.Text, "", False) <> 0 Then
                ' The following expression was wrapped in a checked-expression
                openFileDialog.FileName = Strings.Mid(fld.Text, fld.Text.LastIndexOf("\") + 2)
            End If
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = openFileDialog.FileName
            End If
        End Sub

        ' Token: 0x06000D11 RID: 3345 RVA: 0x00285730 File Offset: 0x00284730
        Private Sub btnKotorPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbKotorPath As TextBox = Me.tbKotorPath
            Me.BrowseForFolder(tbKotorPath)
            Me.tbKotorPath = tbKotorPath
        End Sub

        ' Token: 0x06000D12 RID: 3346 RVA: 0x00285754 File Offset: 0x00284754
        Private Sub btnImageViewerPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbImageViewerPath As TextBox = Me.tbImageViewerPath
            Me.BrowseForApp(tbImageViewerPath)
            Me.tbImageViewerPath = tbImageViewerPath
        End Sub

        ' Token: 0x06000D13 RID: 3347 RVA: 0x00285778 File Offset: 0x00284778
        Private Sub btnImportPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbImportPath As TextBox = Me.tbImportPath
            Me.BrowseForFolder(tbImportPath)
            Me.tbImportPath = tbImportPath
        End Sub

        ' Token: 0x06000D14 RID: 3348 RVA: 0x0028579C File Offset: 0x0028479C
        Private Sub btnSavePath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbSavePath As TextBox = Me.tbSavePath
            Me.BrowseForFolder(tbSavePath)
            Me.tbSavePath = tbSavePath
        End Sub

        ' Token: 0x06000D15 RID: 3349 RVA: 0x002857C0 File Offset: 0x002847C0
        Private Sub btnKotorPath2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbKotorPath As TextBox = Me.tbKotorPath2
            Me.BrowseForFolder(tbKotorPath)
            Me.tbKotorPath2 = tbKotorPath
        End Sub

        ' ---------------------------------------------------------------------
        ' KotOR Path Auto-Detection Upgrade
        ' ---------------------------------------------------------------------
        '
        ' Original decompiled behaviour:
        '
        '   KotOR I:
        '       HKLM\software\Bioware\SW\KOTOR
        '       value: path
        '
        '   KotOR II:
        '       HKLM\software\LucasArts\KotOR2
        '       value: path
        '
        ' The original logic only checked the old retail registry keys.
        ' That is too narrow for modern systems because Steam may be installed
        ' on any drive, Steam libraries may be moved anywhere, and GOG/manual
        ' installs may not have the old registry keys.
        '
        ' New behaviour:
        '
        '   1. Check original retail registry keys.
        '   2. Check WOW6432Node registry keys.
        '   3. Detect Steam install path from registry.
        '   4. Read Steam libraryfolders.vdf from every discovered Steam path.
        '   5. Check Steam app manifests:
        '          KotOR I  = appmanifest_32370.acf
        '          KotOR II = appmanifest_208580.acf
        '   6. Check common install paths on every fixed drive.
        '   7. Perform a limited safe folder scan in likely game folders.
        '
        ' A path is accepted only if chitin.key exists inside it.
        ' ---------------------------------------------------------------------

        Private Shared Function NormaliseGamePath(ByVal gamePath As String) As String
            If gamePath Is Nothing Then
                Return ""
            End If

            gamePath = gamePath.Trim().Replace("/", "\")

            While gamePath.EndsWith("\")
                gamePath = gamePath.Substring(0, gamePath.Length - 1)
            End While

            Return gamePath
        End Function

        Private Shared Function SafeDirectoryExists(ByVal path As String) As Boolean
            Try
                If path Is Nothing Then
                    Return False
                End If

                Return Directory.Exists(path)
            Catch ex As System.Exception
                Return False
            End Try
        End Function

        Private Shared Function SafeFileExists(ByVal path As String) As Boolean
            Try
                If path Is Nothing Then
                    Return False
                End If

                Return File.Exists(path)
            Catch ex As System.Exception
                Return False
            End Try
        End Function

        Private Shared Function HasChitinKey(ByVal gamePath As String) As Boolean
            gamePath = NormaliseGamePath(gamePath)

            If gamePath.Length = 0 Then
                Return False
            End If

            Return SafeFileExists(Path.Combine(gamePath, "chitin.key"))
        End Function

        Private Shared Sub AddUniquePath(ByVal list As ArrayList, ByVal path As String)
            path = NormaliseGamePath(path)

            If path.Length = 0 Then
                Return
            End If

            If Not SafeDirectoryExists(path) Then
                Return
            End If

            For Each existingPathObj As Object In list
                Dim existingPath As String = NormaliseGamePath(StringType.FromObject(existingPathObj))

                If StringType.StrCmp(existingPath, path, False) = 0 Then
                    Return
                End If
            Next

            list.Add(path)
        End Sub

        Private Shared Function TryRegistryPath(ByVal hive As RegistryKey, ByVal registryPath As String, ByVal valueName As String, Optional ByVal valueIsFile As Boolean = False) As String
            Dim registryKey As RegistryKey = Nothing

            Try
                registryKey = hive.OpenSubKey(registryPath)

                If registryKey IsNot Nothing Then
                    Dim value As Object = registryKey.GetValue(valueName)

                    If value IsNot Nothing Then
                        Dim detectedPath As String = NormaliseGamePath(StringType.FromObject(value))

                        If valueIsFile Then
                            detectedPath = NormaliseGamePath(Path.GetDirectoryName(detectedPath))
                        End If

                        If detectedPath.Length > 0 AndAlso SafeDirectoryExists(detectedPath) Then
                            Return detectedPath
                        End If
                    End If
                End If
            Catch ex As System.Exception
            Finally
                If registryKey IsNot Nothing Then
                    registryKey.Close()
                End If
            End Try

            Return ""
        End Function

        Private Shared Function TryGameRegistryPath(ByVal hive As RegistryKey, ByVal registryPath As String, ByVal valueName As String) As String
            Dim detectedPath As String = TryRegistryPath(hive, registryPath, valueName, False)

            If HasChitinKey(detectedPath) Then
                Return detectedPath
            End If

            Return ""
        End Function

        Private Shared Function ExtractVdfValue(ByVal line As String, ByVal keyName As String) As String
            If line Is Nothing Then
                Return ""
            End If

            Dim pattern As String = """" & Regex.Escape(keyName) & """" & "\s+""(?<value>[^""]+)"""
            Dim match As Match = Regex.Match(line, pattern, RegexOptions.IgnoreCase)

            If match.Success Then
                Return match.Groups("value").Value.Replace("\\", "\")
            End If

            Return ""
        End Function

        Private Shared Function GetFixedDriveRoots() As ArrayList
            Dim driveRoots As ArrayList = New ArrayList()

            Try
                For Each drive As DriveInfo In DriveInfo.GetDrives()
                    If drive IsNot Nothing Then
                        If drive.IsReady AndAlso drive.DriveType = DriveType.Fixed Then
                            AddUniquePath(driveRoots, drive.RootDirectory.FullName)
                        End If
                    End If
                Next
            Catch ex As System.Exception
            End Try

            Return driveRoots
        End Function

        Private Shared Function GetSteamInstallCandidates() As ArrayList
            Dim steamPaths As ArrayList = New ArrayList()

            ' Steam registry locations.
            AddUniquePath(steamPaths, TryRegistryPath(Registry.CurrentUser, "Software\Valve\Steam", "SteamPath", False))
            AddUniquePath(steamPaths, TryRegistryPath(Registry.CurrentUser, "Software\Valve\Steam", "SteamExe", True))
            AddUniquePath(steamPaths, TryRegistryPath(Registry.LocalMachine, "Software\Valve\Steam", "InstallPath", False))
            AddUniquePath(steamPaths, TryRegistryPath(Registry.LocalMachine, "Software\WOW6432Node\Valve\Steam", "InstallPath", False))

            ' Common Steam locations on every fixed drive.
            Dim driveRoots As ArrayList = GetFixedDriveRoots()

            For Each driveRootObj As Object In driveRoots
                Dim driveRoot As String = StringType.FromObject(driveRootObj)

                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Steam"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "SteamLibrary"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Games\Steam"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Games\SteamLibrary"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Program Files\Steam"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Program Files (x86)\Steam"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Valve\Steam"))
            Next

            Return steamPaths
        End Function

        Private Shared Function GetSteamLibraryFoldersFromSteamPath(ByVal steamPath As String) As ArrayList
            Dim libraries As ArrayList = New ArrayList()

            steamPath = NormaliseGamePath(steamPath)

            If steamPath.Length = 0 Then
                Return libraries
            End If

            ' The Steam install folder itself is also a library folder.
            AddUniquePath(libraries, steamPath)

            Dim steamAppsPath As String = Path.Combine(steamPath, "steamapps")
            Dim libraryFoldersFile As String = Path.Combine(steamAppsPath, "libraryfolders.vdf")

            If Not SafeFileExists(libraryFoldersFile) Then
                Return libraries
            End If

            Try
                Dim lines As String() = File.ReadAllLines(libraryFoldersFile)

                For Each line As String In lines
                    Dim detectedPath As String = ExtractVdfValue(line, "path")

                    If detectedPath.Length > 0 Then
                        AddUniquePath(libraries, detectedPath)
                    End If
                Next
            Catch ex As System.Exception
            End Try

            Return libraries
        End Function

        Private Shared Function GetAllSteamLibraries() As ArrayList
            Dim allLibraries As ArrayList = New ArrayList()
            Dim steamInstallCandidates As ArrayList = GetSteamInstallCandidates()

            For Each steamPathObj As Object In steamInstallCandidates
                Dim steamPath As String = StringType.FromObject(steamPathObj)
                Dim libraries As ArrayList = GetSteamLibraryFoldersFromSteamPath(steamPath)

                For Each libraryPathObj As Object In libraries
                    AddUniquePath(allLibraries, StringType.FromObject(libraryPathObj))
                Next
            Next

            Return allLibraries
        End Function

        Private Shared Function TrySteamGamePath(ByVal appId As String, ByVal defaultFolderNames As String()) As String
            Dim libraries As ArrayList = GetAllSteamLibraries()

            For Each libraryPathObj As Object In libraries
                Dim libraryPath As String = NormaliseGamePath(StringType.FromObject(libraryPathObj))
                Dim steamAppsPath As String = Path.Combine(libraryPath, "steamapps")

                If SafeDirectoryExists(steamAppsPath) Then
                    Dim manifestPath As String = Path.Combine(steamAppsPath, "appmanifest_" & appId & ".acf")

                    ' Preferred detection: Steam manifest tells us the real folder name.
                    If SafeFileExists(manifestPath) Then
                        Try
                            Dim lines As String() = File.ReadAllLines(manifestPath)

                            For Each line As String In lines
                                Dim installDir As String = ExtractVdfValue(line, "installdir")

                                If installDir.Length > 0 Then
                                    Dim detectedPath As String = Path.Combine(Path.Combine(steamAppsPath, "common"), installDir)
                                    detectedPath = NormaliseGamePath(detectedPath)

                                    If HasChitinKey(detectedPath) Then
                                        Return detectedPath
                                    End If
                                End If
                            Next
                        Catch ex As System.Exception
                        End Try
                    End If

                    ' Fallback: known Steam common folder names.
                    For Each folderName As String In defaultFolderNames
                        Dim commonPath As String = Path.Combine(Path.Combine(steamAppsPath, "common"), folderName)

                        If HasChitinKey(commonPath) Then
                            Return NormaliseGamePath(commonPath)
                        End If
                    Next
                End If
            Next

            Return ""
        End Function

        Private Shared Function TryCommonGamePathEveryDrive(ByVal relativeCandidates As String()) As String
            Dim driveRoots As ArrayList = GetFixedDriveRoots()

            For Each driveRootObj As Object In driveRoots
                Dim driveRoot As String = StringType.FromObject(driveRootObj)

                For Each relativeCandidate As String In relativeCandidates
                    Dim candidate As String = Path.Combine(driveRoot, relativeCandidate)

                    If HasChitinKey(candidate) Then
                        Return NormaliseGamePath(candidate)
                    End If
                Next
            Next

            Return ""
        End Function

        Private Shared Function TryLimitedFolderScan(ByVal folderNameHints As String()) As String
            Dim driveRoots As ArrayList = GetFixedDriveRoots()

            For Each driveRootObj As Object In driveRoots
                Dim driveRoot As String = StringType.FromObject(driveRootObj)

                Dim scanRoots As String() = New String() { _
                    Path.Combine(driveRoot, "Games"), _
                    Path.Combine(driveRoot, "Steam"), _
                    Path.Combine(driveRoot, "SteamLibrary"), _
                    Path.Combine(driveRoot, "GOG Games"), _
                    Path.Combine(driveRoot, "Program Files"), _
                    Path.Combine(driveRoot, "Program Files (x86)") _
                }

                For Each scanRoot As String In scanRoots
                    Dim foundPath As String = TryLimitedFolderScanRecursive(scanRoot, folderNameHints, 0, 3)

                    If foundPath.Length > 0 Then
                        Return foundPath
                    End If
                Next
            Next

            Return ""
        End Function

        Private Shared Function TryLimitedFolderScanRecursive(ByVal currentPath As String, ByVal folderNameHints As String(), ByVal depth As Integer, ByVal maxDepth As Integer) As String
            If depth > maxDepth Then
                Return ""
            End If

            If Not SafeDirectoryExists(currentPath) Then
                Return ""
            End If

            If HasChitinKey(currentPath) Then
                Dim currentFolderName As String = Path.GetFileName(currentPath).ToLower()

                For Each hint As String In folderNameHints
                    If currentFolderName.IndexOf(hint.ToLower()) >= 0 Then
                        Return NormaliseGamePath(currentPath)
                    End If
                Next
            End If

            Try
                Dim directories As String() = Directory.GetDirectories(currentPath)

                For Each directoryPath As String In directories
                    Dim folderName As String = Path.GetFileName(directoryPath).ToLower()
                    Dim worthScanning As Boolean = False

                    For Each hint As String In folderNameHints
                        If folderName.IndexOf(hint.ToLower()) >= 0 Then
                            worthScanning = True
                            Exit For
                        End If
                    Next

                    ' Scan broad at the top two levels only, then narrow by folder name.
                    If worthScanning OrElse depth < 2 Then
                        Dim foundPath As String = TryLimitedFolderScanRecursive(directoryPath, folderNameHints, depth + 1, maxDepth)

                        If foundPath.Length > 0 Then
                            Return foundPath
                        End If
                    End If
                Next
            Catch ex As System.Exception
            End Try

            Return ""
        End Function

        Public Shared Function DetectKotor1Path() As String
            Dim detectedPath As String = ""

            ' Original old retail registry detection preserved and used first.
            detectedPath = TryGameRegistryPath(Registry.LocalMachine, "software\Bioware\SW\KOTOR", "path")
            If detectedPath.Length > 0 Then Return detectedPath

            ' 32-bit registry redirector location on 64-bit Windows.
            detectedPath = TryGameRegistryPath(Registry.LocalMachine, "software\WOW6432Node\Bioware\SW\KOTOR", "path")
            If detectedPath.Length > 0 Then Return detectedPath

            ' Steam AppID: Star Wars: Knights of the Old Republic.
            detectedPath = TrySteamGamePath("32370", New String() { _
                "swkotor", _
                "Star Wars Knights of the Old Republic", _
                "Knights of the Old Republic" _
            })
            If detectedPath.Length > 0 Then Return detectedPath

            ' Common retail, Steam, GOG, and manual install locations on every fixed drive.
            detectedPath = TryCommonGamePathEveryDrive(New String() { _
                "LucasArts\SWKotOR", _
                "Program Files\LucasArts\SWKotOR", _
                "Program Files (x86)\LucasArts\SWKotOR", _
                "Steam\steamapps\common\swkotor", _
                "SteamLibrary\steamapps\common\swkotor", _
                "GOG Games\Star Wars - KotOR", _
                "GOG Games\Star Wars Knights of the Old Republic", _
                "Games\Star Wars - KotOR", _
                "Games\Star Wars Knights of the Old Republic" _
            })
            If detectedPath.Length > 0 Then Return detectedPath

            ' Last safe fallback. Limited depth only.
            detectedPath = TryLimitedFolderScan(New String() { _
                "kotor", _
                "swkotor", _
                "knights of the old republic" _
            })

            Return detectedPath
        End Function

        Public Shared Function DetectKotor2Path() As String
            Dim detectedPath As String = ""

            ' Original old retail registry detection preserved and used first.
            detectedPath = TryGameRegistryPath(Registry.LocalMachine, "software\LucasArts\KotOR2", "path")
            If detectedPath.Length > 0 Then Return detectedPath

            ' 32-bit registry redirector location on 64-bit Windows.
            detectedPath = TryGameRegistryPath(Registry.LocalMachine, "software\WOW6432Node\LucasArts\KotOR2", "path")
            If detectedPath.Length > 0 Then Return detectedPath

            ' Steam AppID: Star Wars: Knights of the Old Republic II.
            detectedPath = TrySteamGamePath("208580", New String() { _
                "Knights of the Old Republic II", _
                "Star Wars Knights of the Old Republic II", _
                "swkotor2" _
            })
            If detectedPath.Length > 0 Then Return detectedPath

            ' Common retail, Steam, GOG, and manual install locations on every fixed drive.
            detectedPath = TryCommonGamePathEveryDrive(New String() { _
                "LucasArts\SWKotOR2", _
                "Program Files\LucasArts\SWKotOR2", _
                "Program Files (x86)\LucasArts\SWKotOR2", _
                "Steam\steamapps\common\Knights of the Old Republic II", _
                "SteamLibrary\steamapps\common\Knights of the Old Republic II", _
                "Steam\steamapps\common\swkotor2", _
                "SteamLibrary\steamapps\common\swkotor2", _
                "GOG Games\Star Wars - KotOR2", _
                "GOG Games\Star Wars Knights of the Old Republic II", _
                "Games\Star Wars - KotOR2", _
                "Games\Star Wars Knights of the Old Republic II" _
            })
            If detectedPath.Length > 0 Then Return detectedPath

            ' Last safe fallback. Limited depth only.
            detectedPath = TryLimitedFolderScan(New String() { _
                "kotor2", _
                "swkotor2", _
                "knights of the old republic ii", _
                "old republic ii" _
            })

            Return detectedPath
        End Function

        ' Token: 0x06000D16 RID: 3350 RVA: 0x002857E4 File Offset: 0x002847E4
        Public Sub btnAutoDetectKotor1_Click(ByVal sender As Object, ByVal e As EventArgs)

            ' -----------------------------------------------------------------
            ' Original preserved code:
            '
            ' Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\Bioware\SW\KOTOR")
            ' If registryKey Is Nothing Then
            '     Interaction.MsgBox("KotOR I not detected in registry. You mau still enter paths manually", MsgBoxStyle.Critical, "Registry value not found")
            ' Else
            '     Me.tbKotorPath.Text = StringType.FromObject(registryKey.GetValue("path"))
            ' End If
            ' -----------------------------------------------------------------

            Dim detectedPath As String = DetectKotor1Path()

            If detectedPath.Length > 0 Then
                Me.tbKotorPath.Text = detectedPath
            Else
                Interaction.MsgBox( _
                    "KotOR I was not detected in the registry, Steam libraries, common folders, or limited drive scan." & vbCrLf & vbCrLf & _
                    "You may still enter the path manually.", _
                    MsgBoxStyle.Exclamation, _
                    "KotOR I not detected" _
                )
            End If
        End Sub

        ' Token: 0x06000D17 RID: 3351 RVA: 0x00285834 File Offset: 0x00284834
        Public Sub btnAutoDetectKotor2_Click(ByVal sender As Object, ByVal e As EventArgs)

            ' -----------------------------------------------------------------
            ' Original preserved code:
            '
            ' Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\LucasArts\KotOR2")
            ' If registryKey Is Nothing Then
            '     Interaction.MsgBox("KotOR II not detected in registry. You mau still enter paths manually", MsgBoxStyle.Critical, "Registry value not found")
            ' Else
            '     Me.tbKotorPath2.Text = StringType.FromObject(registryKey.GetValue("path"))
            ' End If
            ' -----------------------------------------------------------------

            Dim detectedPath As String = DetectKotor2Path()

            If detectedPath.Length > 0 Then
                Me.tbKotorPath2.Text = detectedPath
            Else
                Interaction.MsgBox( _
                    "KotOR II was not detected in the registry, Steam libraries, common folders, or limited drive scan." & vbCrLf & vbCrLf & _
                    "You may still enter the path manually.", _
                    MsgBoxStyle.Exclamation, _
                    "KotOR II not detected" _
                )
            End If
        End Sub

        ' Token: 0x06000D18 RID: 3352 RVA: 0x00285884 File Offset: 0x00284884
        Private Sub btnModuleExportPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbModuleExportPath As TextBox = Me.tbModuleExportPath
            Me.BrowseForFolder(tbModuleExportPath)
            Me.tbModuleExportPath = tbModuleExportPath
        End Sub

        ' Token: 0x04000661 RID: 1633
        <AccessedThroughProperty("btnKotorPath")> _
        Private _btnKotorPath As Button

        ' Token: 0x04000662 RID: 1634
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x04000663 RID: 1635
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000664 RID: 1636
        <AccessedThroughProperty("TabPage1")> _
        Private _TabPage1 As TabPage

        ' Token: 0x04000665 RID: 1637
        <AccessedThroughProperty("btnAutoDetectKotor2")> _
        Private _btnAutoDetectKotor2 As Button

        ' Token: 0x04000666 RID: 1638
        <AccessedThroughProperty("ToolTip1")> _
        Private _ToolTip1 As ToolTip

        ' Token: 0x04000667 RID: 1639
        <AccessedThroughProperty("TabPage2")> _
        Private _TabPage2 As TabPage

        ' Token: 0x04000668 RID: 1640
        <AccessedThroughProperty("tbModuleExportPath")> _
        Private _tbModuleExportPath As TextBox

        ' Token: 0x04000669 RID: 1641
        <AccessedThroughProperty("tbKotorPath")> _
        Private _tbKotorPath As TextBox

        ' Token: 0x0400066A RID: 1642
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x0400066B RID: 1643
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x0400066C RID: 1644
        <AccessedThroughProperty("TabPage3")> _
        Private _TabPage3 As TabPage

        ' Token: 0x0400066D RID: 1645
        <AccessedThroughProperty("btnAutoDetectKotor1")> _
        Private _btnAutoDetectKotor1 As Button

        ' Token: 0x0400066E RID: 1646
        <AccessedThroughProperty("tbKotorPath2")> _
        Private _tbKotorPath2 As TextBox

        ' Token: 0x0400066F RID: 1647
        <AccessedThroughProperty("btnModuleExportPath")> _
        Private _btnModuleExportPath As Button

        ' Token: 0x04000670 RID: 1648
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x04000671 RID: 1649
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x04000672 RID: 1650
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x04000673 RID: 1651
        <AccessedThroughProperty("btnKotorPath2")> _
        Private _btnKotorPath2 As Button

        ' Token: 0x04000674 RID: 1652
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x04000675 RID: 1653
        <AccessedThroughProperty("tbImportPath")> _
        Private _tbImportPath As TextBox

        ' Token: 0x04000676 RID: 1654
        <AccessedThroughProperty("btnImageViewerPath")> _
        Private _btnImageViewerPath As Button

        ' Token: 0x04000677 RID: 1655
        <AccessedThroughProperty("tbImageViewerPath")> _
        Private _tbImageViewerPath As TextBox

        ' Token: 0x04000678 RID: 1656
        <AccessedThroughProperty("tbSavePath")> _
        Private _tbSavePath As TextBox

        ' Token: 0x04000679 RID: 1657
        <AccessedThroughProperty("btnSavePath")> _
        Private _btnSavePath As Button

        ' Token: 0x0400067A RID: 1658
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x0400067B RID: 1659
        <AccessedThroughProperty("btnImportPath")> _
        Private _btnImportPath As Button

        ' Token: 0x0400067D RID: 1661
        Private options As Options
    End Class
End Namespace
