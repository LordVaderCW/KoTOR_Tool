Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200005B RID: 91
	Public Partial Class frmMdlOpsSwitches
		Inherits Form

		' Token: 0x0600077D RID: 1917 RVA: 0x0025960C File Offset: 0x0025860C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmMdlOpsSwitches_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700022F RID: 559
		' (get) Token: 0x0600077F RID: 1919 RVA: 0x0025966C File Offset: 0x0025866C
		' (set) Token: 0x06000780 RID: 1920 RVA: 0x00259650 File Offset: 0x00258650
		Friend Overridable Property chkbExtractAnimations As CheckBox
			Get
				Return Me._chkbExtractAnimations
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbExtractAnimations IsNot Nothing Then
                End If
                Me._chkbExtractAnimations = value
                If Me._chkbExtractAnimations IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000230 RID: 560
        ' (get) Token: 0x06000781 RID: 1921 RVA: 0x00259680 File Offset: 0x00258680
        ' (set) Token: 0x06000782 RID: 1922 RVA: 0x00259694 File Offset: 0x00258694
        Friend Overridable Property chkbConvertSkin() As CheckBox
            Get
                Return Me._chkbConvertSkin
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbConvertSkin IsNot Nothing Then
                End If
                Me._chkbConvertSkin = value
                If Me._chkbConvertSkin IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000231 RID: 561
        ' (get) Token: 0x06000783 RID: 1923 RVA: 0x002596B0 File Offset: 0x002586B0
        ' (set) Token: 0x06000784 RID: 1924 RVA: 0x002596C4 File Offset: 0x002586C4
        Friend Overridable Property Label1() As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label1 IsNot Nothing Then
                End If
                Me._Label1 = value
                If Me._Label1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000232 RID: 562
        ' (get) Token: 0x06000786 RID: 1926 RVA: 0x002596E0 File Offset: 0x002586E0
        ' (set) Token: 0x06000785 RID: 1925 RVA: 0x002596F4 File Offset: 0x002586F4
        Friend Overridable Property btnOK() As Button
            Get
                Return Me._btnOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000233 RID: 563
        ' (get) Token: 0x06000787 RID: 1927 RVA: 0x00259710 File Offset: 0x00258710
        ' (set) Token: 0x06000788 RID: 1928 RVA: 0x00259724 File Offset: 0x00258724
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

        ' Token: 0x17000234 RID: 564
        ' (get) Token: 0x06000789 RID: 1929 RVA: 0x00259740 File Offset: 0x00258740
        ' (set) Token: 0x0600078A RID: 1930 RVA: 0x00259754 File Offset: 0x00258754
        Friend Overridable Property nudNumberToExtract() As NumericUpDown
            Get
                Return Me._nudNumberToExtract
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudNumberToExtract IsNot Nothing Then
                End If
                Me._nudNumberToExtract = value
                If Me._nudNumberToExtract IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000235 RID: 565
        ' (get) Token: 0x0600078B RID: 1931 RVA: 0x00259770 File Offset: 0x00258770
        ' (set) Token: 0x0600078C RID: 1932 RVA: 0x00259784 File Offset: 0x00258784
        Friend Overridable Property Label2() As Label
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label2 IsNot Nothing Then
                End If
                Me._Label2 = value
                If Me._Label2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000236 RID: 566
        ' (get) Token: 0x0600078D RID: 1933 RVA: 0x002597BC File Offset: 0x002587BC
        ' (set) Token: 0x0600078E RID: 1934 RVA: 0x002597A0 File Offset: 0x002587A0
        Friend Overridable Property chkbEachModelInOwnDir() As CheckBox
            Get
                Return Me._chkbEachModelInOwnDir
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbEachModelInOwnDir IsNot Nothing Then
                End If
                Me._chkbEachModelInOwnDir = value
                If Me._chkbEachModelInOwnDir IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000237 RID: 567
        ' (get) Token: 0x0600078F RID: 1935 RVA: 0x002597EC File Offset: 0x002587EC
        ' (set) Token: 0x06000790 RID: 1936 RVA: 0x002597D0 File Offset: 0x002587D0
        Friend Overridable Property chkbCleanWorkingDir() As CheckBox
            Get
                Return Me._chkbCleanWorkingDir
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbCleanWorkingDir IsNot Nothing Then
                End If
                Me._chkbCleanWorkingDir = value
                If Me._chkbCleanWorkingDir IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000238 RID: 568
        ' (get) Token: 0x06000791 RID: 1937 RVA: 0x0025981C File Offset: 0x0025881C
        ' (set) Token: 0x06000792 RID: 1938 RVA: 0x00259800 File Offset: 0x00258800
        Friend Overridable Property tbModelExtractionPath() As TextBox
            Get
                Return Me._tbModelExtractionPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbModelExtractionPath IsNot Nothing Then
                End If
                Me._tbModelExtractionPath = value
                If Me._tbModelExtractionPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000239 RID: 569
        ' (get) Token: 0x06000794 RID: 1940 RVA: 0x00259884 File Offset: 0x00258884
        ' (set) Token: 0x06000793 RID: 1939 RVA: 0x00259830 File Offset: 0x00258830
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

        ' Token: 0x1700023A RID: 570
        ' (get) Token: 0x06000796 RID: 1942 RVA: 0x002598B4 File Offset: 0x002588B4
        ' (set) Token: 0x06000795 RID: 1941 RVA: 0x00259898 File Offset: 0x00258898
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

        ' Token: 0x1700023B RID: 571
        ' (get) Token: 0x06000798 RID: 1944 RVA: 0x0025991C File Offset: 0x0025891C
        ' (set) Token: 0x06000797 RID: 1943 RVA: 0x002598C8 File Offset: 0x002588C8
        Friend Overridable Property chkbMdlAlignDataOnly() As CheckBox
            Get
                Return Me._chkbMdlAlignDataOnly
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbMdlAlignDataOnly IsNot Nothing Then
                    RemoveHandler Me._chkbMdlAlignDataOnly.CheckedChanged, AddressOf Me.chkbMdlAlignDataOnly_CheckedChanged
                End If
                Me._chkbMdlAlignDataOnly = value
                If Me._chkbMdlAlignDataOnly IsNot Nothing Then
                    AddHandler Me._chkbMdlAlignDataOnly.CheckedChanged, AddressOf Me.chkbMdlAlignDataOnly_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x1700023C RID: 572
        ' (get) Token: 0x0600079A RID: 1946 RVA: 0x00259984 File Offset: 0x00258984
        ' (set) Token: 0x06000799 RID: 1945 RVA: 0x00259930 File Offset: 0x00258930
        Friend Overridable Property chkbExportMdlAlignData() As CheckBox
            Get
                Return Me._chkbExportMdlAlignData
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbExportMdlAlignData IsNot Nothing Then
                    RemoveHandler Me._chkbExportMdlAlignData.CheckedChanged, AddressOf Me.chkbExportMdlAlignData_CheckedChanged
                End If
                Me._chkbExportMdlAlignData = value
                If Me._chkbExportMdlAlignData IsNot Nothing Then
                    AddHandler Me._chkbExportMdlAlignData.CheckedChanged, AddressOf Me.chkbExportMdlAlignData_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x1700023D RID: 573
        ' (get) Token: 0x0600079C RID: 1948 RVA: 0x0025A238 File Offset: 0x00259238
        Public ReadOnly Property ExtractAnimations() As Boolean
            Get
                Return Me.chkbExtractAnimations.Checked
            End Get
        End Property

        ' Token: 0x1700023E RID: 574
        ' (get) Token: 0x0600079D RID: 1949 RVA: 0x0025A250 File Offset: 0x00259250
        Public ReadOnly Property ConvertSkin() As Boolean
            Get
                Return Me.chkbConvertSkin.Checked
            End Get
        End Property

        ' Token: 0x0600079E RID: 1950 RVA: 0x0025A268 File Offset: 0x00259268
        Private Sub btnModuleExportPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
            folderBrowserDialog.Description = "Locate folder to store exported models in"
            folderBrowserDialog.SelectedPath = Me.tbModelExtractionPath.Text
            folderBrowserDialog.ShowNewFolderButton = True
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Me.tbModelExtractionPath.Text = folderBrowserDialog.SelectedPath
            End If
        End Sub

        ' Token: 0x0600079F RID: 1951 RVA: 0x0025A2B8 File Offset: 0x002592B8
        Private Sub chkbExportMdlAlignData_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.chkbMdlAlignDataOnly.Checked = Not Me.chkbExportMdlAlignData.Checked
        End Sub

        ' Token: 0x060007A0 RID: 1952 RVA: 0x0025A2D4 File Offset: 0x002592D4
        Private Sub chkbMdlAlignDataOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.chkbExportMdlAlignData.Checked = Not Me.chkbMdlAlignDataOnly.Checked
        End Sub

        ' Token: 0x060007A1 RID: 1953 RVA: 0x0025A2F0 File Offset: 0x002592F0
        Private Sub frmMdlOpsSwitches_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        ' Token: 0x040003D9 RID: 985
        <AccessedThroughProperty("chkbExportMdlAlignData")> _
        Private _chkbExportMdlAlignData As CheckBox

        ' Token: 0x040003DA RID: 986
        <AccessedThroughProperty("chkbMdlAlignDataOnly")> _
        Private _chkbMdlAlignDataOnly As CheckBox

        ' Token: 0x040003DB RID: 987
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x040003DC RID: 988
        <AccessedThroughProperty("btnModuleExportPath")> _
        Private _btnModuleExportPath As Button

        ' Token: 0x040003DD RID: 989
        <AccessedThroughProperty("chkbExtractAnimations")> _
        Private _chkbExtractAnimations As CheckBox

        ' Token: 0x040003DE RID: 990
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x040003DF RID: 991
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040003E0 RID: 992
        <AccessedThroughProperty("chkbConvertSkin")> _
        Private _chkbConvertSkin As CheckBox

        ' Token: 0x040003E1 RID: 993
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040003E2 RID: 994
        <AccessedThroughProperty("nudNumberToExtract")> _
        Private _nudNumberToExtract As NumericUpDown

        ' Token: 0x040003E3 RID: 995
        <AccessedThroughProperty("chkbEachModelInOwnDir")> _
        Private _chkbEachModelInOwnDir As CheckBox

        ' Token: 0x040003E4 RID: 996
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040003E5 RID: 997
        <AccessedThroughProperty("chkbCleanWorkingDir")> _
        Private _chkbCleanWorkingDir As CheckBox

        ' Token: 0x040003E6 RID: 998
        <AccessedThroughProperty("tbModelExtractionPath")> _
        Private _tbModelExtractionPath As TextBox
    End Class
End Namespace
