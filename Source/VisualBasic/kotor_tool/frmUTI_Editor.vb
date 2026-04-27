Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200007F RID: 127
	Public Partial Class frmUTI_Editor
		Inherits frmParent

		' Token: 0x0600137F RID: 4991 RVA: 0x002B0BA4 File Offset: 0x002AFBA4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTI_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTI_Editor_Closing
			Me.dt = New DataTable()
			Me.htOverrideFiles = New Hashtable()
			Me.m_bSaveGameMode = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700073A RID: 1850
		' (get) Token: 0x06001382 RID: 4994 RVA: 0x002B0C20 File Offset: 0x002AFC20
		' (set) Token: 0x06001381 RID: 4993 RVA: 0x002B0C34 File Offset: 0x002AFC34
		Friend Overridable Property TabControl1 As TabControl
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

        ' Token: 0x1700073B RID: 1851
        ' (get) Token: 0x06001383 RID: 4995 RVA: 0x002B0C50 File Offset: 0x002AFC50
        ' (set) Token: 0x06001384 RID: 4996 RVA: 0x002B0C64 File Offset: 0x002AFC64
        Friend Overridable Property tabpagGeneral() As TabPage
            Get
                Return Me._tabpagGeneral
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagGeneral IsNot Nothing Then
                End If
                Me._tabpagGeneral = value
                If Me._tabpagGeneral IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700073C RID: 1852
        ' (get) Token: 0x06001385 RID: 4997 RVA: 0x002B0C9C File Offset: 0x002AFC9C
        ' (set) Token: 0x06001386 RID: 4998 RVA: 0x002B0C80 File Offset: 0x002AFC80
        Friend Overridable Property tabpagProperties() As TabPage
            Get
                Return Me._tabpagProperties
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagProperties IsNot Nothing Then
                End If
                Me._tabpagProperties = value
                If Me._tabpagProperties IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700073D RID: 1853
        ' (get) Token: 0x06001388 RID: 5000 RVA: 0x002B0CB0 File Offset: 0x002AFCB0
        ' (set) Token: 0x06001387 RID: 4999 RVA: 0x002B0CC4 File Offset: 0x002AFCC4
        Friend Overridable Property tabpagDescription() As TabPage
            Get
                Return Me._tabpagDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagDescription IsNot Nothing Then
                End If
                Me._tabpagDescription = value
                If Me._tabpagDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700073E RID: 1854
        ' (get) Token: 0x0600138A RID: 5002 RVA: 0x002B0CE0 File Offset: 0x002AFCE0
        ' (set) Token: 0x06001389 RID: 5001 RVA: 0x002B0CF4 File Offset: 0x002AFCF4
        Friend Overridable Property tabpagComments() As TabPage
            Get
                Return Me._tabpagComments
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagComments IsNot Nothing Then
                End If
                Me._tabpagComments = value
                If Me._tabpagComments IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700073F RID: 1855
        ' (get) Token: 0x0600138B RID: 5003 RVA: 0x002B0D2C File Offset: 0x002AFD2C
        ' (set) Token: 0x0600138C RID: 5004 RVA: 0x002B0D10 File Offset: 0x002AFD10
        Friend Overridable Property chkbPlotItem() As CheckBox
            Get
                Return Me._chkbPlotItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbPlotItem IsNot Nothing Then
                End If
                Me._chkbPlotItem = value
                If Me._chkbPlotItem IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000740 RID: 1856
        ' (get) Token: 0x0600138D RID: 5005 RVA: 0x002B0D40 File Offset: 0x002AFD40
        ' (set) Token: 0x0600138E RID: 5006 RVA: 0x002B0D54 File Offset: 0x002AFD54
        Friend Overridable Property chkbStolen() As CheckBox
            Get
                Return Me._chkbStolen
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbStolen IsNot Nothing Then
                End If
                Me._chkbStolen = value
                If Me._chkbStolen IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000741 RID: 1857
        ' (get) Token: 0x0600138F RID: 5007 RVA: 0x002B0D70 File Offset: 0x002AFD70
        ' (set) Token: 0x06001390 RID: 5008 RVA: 0x002B0D84 File Offset: 0x002AFD84
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

        ' Token: 0x17000742 RID: 1858
        ' (get) Token: 0x06001392 RID: 5010 RVA: 0x002B0DA0 File Offset: 0x002AFDA0
        ' (set) Token: 0x06001391 RID: 5009 RVA: 0x002B0DB4 File Offset: 0x002AFDB4
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

        ' Token: 0x17000743 RID: 1859
        ' (get) Token: 0x06001394 RID: 5012 RVA: 0x002B0DEC File Offset: 0x002AFDEC
        ' (set) Token: 0x06001393 RID: 5011 RVA: 0x002B0DD0 File Offset: 0x002AFDD0
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

        ' Token: 0x17000744 RID: 1860
        ' (get) Token: 0x06001395 RID: 5013 RVA: 0x002B0E1C File Offset: 0x002AFE1C
        ' (set) Token: 0x06001396 RID: 5014 RVA: 0x002B0E00 File Offset: 0x002AFE00
        Friend Overridable Property tbUnidentifiedDescription() As TextBox
            Get
                Return Me._tbUnidentifiedDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbUnidentifiedDescription IsNot Nothing Then
                End If
                Me._tbUnidentifiedDescription = value
                If Me._tbUnidentifiedDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000745 RID: 1861
        ' (get) Token: 0x06001397 RID: 5015 RVA: 0x002B0E4C File Offset: 0x002AFE4C
        ' (set) Token: 0x06001398 RID: 5016 RVA: 0x002B0E30 File Offset: 0x002AFE30
        Friend Overridable Property Label4() As Label
            Get
                Return Me._Label4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label4 IsNot Nothing Then
                End If
                Me._Label4 = value
                If Me._Label4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000746 RID: 1862
        ' (get) Token: 0x0600139A RID: 5018 RVA: 0x002B0E60 File Offset: 0x002AFE60
        ' (set) Token: 0x06001399 RID: 5017 RVA: 0x002B0E74 File Offset: 0x002AFE74
        Friend Overridable Property tbLocalizedName() As TextBox
            Get
                Return Me._tbLocalizedName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbLocalizedName IsNot Nothing Then
                End If
                Me._tbLocalizedName = value
                If Me._tbLocalizedName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000747 RID: 1863
        ' (get) Token: 0x0600139C RID: 5020 RVA: 0x002B0E90 File Offset: 0x002AFE90
        ' (set) Token: 0x0600139B RID: 5019 RVA: 0x002B0EA4 File Offset: 0x002AFEA4
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

        ' Token: 0x17000748 RID: 1864
        ' (get) Token: 0x0600139D RID: 5021 RVA: 0x002B0EDC File Offset: 0x002AFEDC
        ' (set) Token: 0x0600139E RID: 5022 RVA: 0x002B0EC0 File Offset: 0x002AFEC0
        Friend Overridable Property tbTag() As TextBox
            Get
                Return Me._tbTag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTag IsNot Nothing Then
                End If
                Me._tbTag = value
                If Me._tbTag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000749 RID: 1865
        ' (get) Token: 0x0600139F RID: 5023 RVA: 0x002B0EF0 File Offset: 0x002AFEF0
        ' (set) Token: 0x060013A0 RID: 5024 RVA: 0x002B0F04 File Offset: 0x002AFF04
        Friend Overridable Property nudCost() As NumericUpDown
            Get
                Return Me._nudCost
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCost IsNot Nothing Then
                End If
                Me._nudCost = value
                If Me._nudCost IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700074A RID: 1866
        ' (get) Token: 0x060013A1 RID: 5025 RVA: 0x002B0F20 File Offset: 0x002AFF20
        ' (set) Token: 0x060013A2 RID: 5026 RVA: 0x002B0F34 File Offset: 0x002AFF34
        Friend Overridable Property nudAdditionalCost() As NumericUpDown
            Get
                Return Me._nudAdditionalCost
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudAdditionalCost IsNot Nothing Then
                End If
                Me._nudAdditionalCost = value
                If Me._nudAdditionalCost IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700074B RID: 1867
        ' (get) Token: 0x060013A4 RID: 5028 RVA: 0x002B0F50 File Offset: 0x002AFF50
        ' (set) Token: 0x060013A3 RID: 5027 RVA: 0x002B0F64 File Offset: 0x002AFF64
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

        ' Token: 0x1700074C RID: 1868
        ' (get) Token: 0x060013A5 RID: 5029 RVA: 0x002B0F80 File Offset: 0x002AFF80
        ' (set) Token: 0x060013A6 RID: 5030 RVA: 0x002B0F94 File Offset: 0x002AFF94
        Friend Overridable Property Label8() As Label
            Get
                Return Me._Label8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label8 IsNot Nothing Then
                End If
                Me._Label8 = value
                If Me._Label8 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700074D RID: 1869
        ' (get) Token: 0x060013A8 RID: 5032 RVA: 0x002B0FB0 File Offset: 0x002AFFB0
        ' (set) Token: 0x060013A7 RID: 5031 RVA: 0x002B0FC4 File Offset: 0x002AFFC4
        Friend Overridable Property tbTemplateResRef() As TextBox
            Get
                Return Me._tbTemplateResRef
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTemplateResRef IsNot Nothing Then
                End If
                Me._tbTemplateResRef = value
                If Me._tbTemplateResRef IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700074E RID: 1870
        ' (get) Token: 0x060013AA RID: 5034 RVA: 0x002B0FFC File Offset: 0x002AFFFC
        ' (set) Token: 0x060013A9 RID: 5033 RVA: 0x002B0FE0 File Offset: 0x002AFFE0
        Friend Overridable Property Label9() As Label
            Get
                Return Me._Label9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label9 IsNot Nothing Then
                End If
                Me._Label9 = value
                If Me._Label9 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700074F RID: 1871
        ' (get) Token: 0x060013AC RID: 5036 RVA: 0x002B102C File Offset: 0x002B002C
        ' (set) Token: 0x060013AB RID: 5035 RVA: 0x002B1010 File Offset: 0x002B0010
        Friend Overridable Property tbIdentifiedDescription() As TextBox
            Get
                Return Me._tbIdentifiedDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbIdentifiedDescription IsNot Nothing Then
                End If
                Me._tbIdentifiedDescription = value
                If Me._tbIdentifiedDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000750 RID: 1872
        ' (get) Token: 0x060013AD RID: 5037 RVA: 0x002B1040 File Offset: 0x002B0040
        ' (set) Token: 0x060013AE RID: 5038 RVA: 0x002B1054 File Offset: 0x002B0054
        Friend Overridable Property Label33() As Label
            Get
                Return Me._Label33
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label33 IsNot Nothing Then
                End If
                Me._Label33 = value
                If Me._Label33 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000751 RID: 1873
        ' (get) Token: 0x060013AF RID: 5039 RVA: 0x002B108C File Offset: 0x002B008C
        ' (set) Token: 0x060013B0 RID: 5040 RVA: 0x002B1070 File Offset: 0x002B0070
        Friend Overridable Property tbComment() As TextBox
            Get
                Return Me._tbComment
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbComment IsNot Nothing Then
                End If
                Me._tbComment = value
                If Me._tbComment IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000752 RID: 1874
        ' (get) Token: 0x060013B1 RID: 5041 RVA: 0x002B10BC File Offset: 0x002B00BC
        ' (set) Token: 0x060013B2 RID: 5042 RVA: 0x002B10A0 File Offset: 0x002B00A0
        Friend Overridable Property nudModelVariation() As NumericUpDown
            Get
                Return Me._nudModelVariation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudModelVariation IsNot Nothing Then
                End If
                Me._nudModelVariation = value
                If Me._nudModelVariation IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000753 RID: 1875
        ' (get) Token: 0x060013B3 RID: 5043 RVA: 0x002B10D0 File Offset: 0x002B00D0
        ' (set) Token: 0x060013B4 RID: 5044 RVA: 0x002B10E4 File Offset: 0x002B00E4
        Friend Overridable Property nudStackSize() As NumericUpDown
            Get
                Return Me._nudStackSize
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudStackSize IsNot Nothing Then
                End If
                Me._nudStackSize = value
                If Me._nudStackSize IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000754 RID: 1876
        ' (get) Token: 0x060013B5 RID: 5045 RVA: 0x002B1100 File Offset: 0x002B0100
        ' (set) Token: 0x060013B6 RID: 5046 RVA: 0x002B1114 File Offset: 0x002B0114
        Friend Overridable Property Label10() As Label
            Get
                Return Me._Label10
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label10 IsNot Nothing Then
                End If
                Me._Label10 = value
                If Me._Label10 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000755 RID: 1877
        ' (get) Token: 0x060013B8 RID: 5048 RVA: 0x002B1130 File Offset: 0x002B0130
        ' (set) Token: 0x060013B7 RID: 5047 RVA: 0x002B1144 File Offset: 0x002B0144
        Friend Overridable Property cmbxBaseItem() As ComboBox
            Get
                Return Me._cmbxBaseItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxBaseItem IsNot Nothing Then
                End If
                Me._cmbxBaseItem = value
                If Me._cmbxBaseItem IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000756 RID: 1878
        ' (get) Token: 0x060013BA RID: 5050 RVA: 0x002B1160 File Offset: 0x002B0160
        ' (set) Token: 0x060013B9 RID: 5049 RVA: 0x002B1174 File Offset: 0x002B0174
        Friend Overridable Property dgProperties() As DataGrid
            Get
                Return Me._dgProperties
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As DataGrid)
                If Me._dgProperties IsNot Nothing Then
                    RemoveHandler Me._dgProperties.DoubleClick, AddressOf Me.dgProperties_DoubleClick
                End If
                Me._dgProperties = value
                If Me._dgProperties IsNot Nothing Then
                    AddHandler Me._dgProperties.DoubleClick, AddressOf Me.dgProperties_DoubleClick
                End If
            End Set
        End Property

        ' Token: 0x17000757 RID: 1879
        ' (get) Token: 0x060013BC RID: 5052 RVA: 0x002B11C8 File Offset: 0x002B01C8
        ' (set) Token: 0x060013BB RID: 5051 RVA: 0x002B11DC File Offset: 0x002B01DC
        Friend Overridable Property chkbIdentified() As CheckBox
            Get
                Return Me._chkbIdentified
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbIdentified IsNot Nothing Then
                End If
                Me._chkbIdentified = value
                If Me._chkbIdentified IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000758 RID: 1880
        ' (get) Token: 0x060013BE RID: 5054 RVA: 0x002B11F8 File Offset: 0x002B01F8
        ' (set) Token: 0x060013BD RID: 5053 RVA: 0x002B120C File Offset: 0x002B020C
        Friend Overridable Property nudPaletteID() As NumericUpDown
            Get
                Return Me._nudPaletteID
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudPaletteID IsNot Nothing Then
                End If
                Me._nudPaletteID = value
                If Me._nudPaletteID IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000759 RID: 1881
        ' (get) Token: 0x060013BF RID: 5055 RVA: 0x002B1228 File Offset: 0x002B0228
        ' (set) Token: 0x060013C0 RID: 5056 RVA: 0x002B123C File Offset: 0x002B023C
        Friend Overridable Property Label11() As Label
            Get
                Return Me._Label11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label11 IsNot Nothing Then
                End If
                Me._Label11 = value
                If Me._Label11 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700075A RID: 1882
        ' (get) Token: 0x060013C2 RID: 5058 RVA: 0x002B1274 File Offset: 0x002B0274
        ' (set) Token: 0x060013C1 RID: 5057 RVA: 0x002B1258 File Offset: 0x002B0258
        Friend Overridable Property nudTextureVariation() As NumericUpDown
            Get
                Return Me._nudTextureVariation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudTextureVariation IsNot Nothing Then
                End If
                Me._nudTextureVariation = value
                If Me._nudTextureVariation IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700075B RID: 1883
        ' (get) Token: 0x060013C3 RID: 5059 RVA: 0x002B12A4 File Offset: 0x002B02A4
        ' (set) Token: 0x060013C4 RID: 5060 RVA: 0x002B1288 File Offset: 0x002B0288
        Friend Overridable Property nudCharges() As NumericUpDown
            Get
                Return Me._nudCharges
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCharges IsNot Nothing Then
                End If
                Me._nudCharges = value
                If Me._nudCharges IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700075C RID: 1884
        ' (get) Token: 0x060013C6 RID: 5062 RVA: 0x002B12B8 File Offset: 0x002B02B8
        ' (set) Token: 0x060013C5 RID: 5061 RVA: 0x002B12CC File Offset: 0x002B02CC
        Friend Overridable Property nudBodyVariation() As NumericUpDown
            Get
                Return Me._nudBodyVariation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudBodyVariation IsNot Nothing Then
                End If
                Me._nudBodyVariation = value
                If Me._nudBodyVariation IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700075D RID: 1885
        ' (get) Token: 0x060013C7 RID: 5063 RVA: 0x002B12E8 File Offset: 0x002B02E8
        ' (set) Token: 0x060013C8 RID: 5064 RVA: 0x002B12FC File Offset: 0x002B02FC
        Friend Overridable Property Label12() As Label
            Get
                Return Me._Label12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label12 IsNot Nothing Then
                End If
                Me._Label12 = value
                If Me._Label12 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700075E RID: 1886
        ' (get) Token: 0x060013C9 RID: 5065 RVA: 0x002B1318 File Offset: 0x002B0318
        ' (set) Token: 0x060013CA RID: 5066 RVA: 0x002B132C File Offset: 0x002B032C
        Friend Overridable Property lblTextureVariation() As Label
            Get
                Return Me._lblTextureVariation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblTextureVariation IsNot Nothing Then
                End If
                Me._lblTextureVariation = value
                If Me._lblTextureVariation IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700075F RID: 1887
        ' (get) Token: 0x060013CB RID: 5067 RVA: 0x002B1364 File Offset: 0x002B0364
        ' (set) Token: 0x060013CC RID: 5068 RVA: 0x002B1348 File Offset: 0x002B0348
        Friend Overridable Property lblBodyVariation() As Label
            Get
                Return Me._lblBodyVariation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblBodyVariation IsNot Nothing Then
                End If
                Me._lblBodyVariation = value
                If Me._lblBodyVariation IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000760 RID: 1888
        ' (get) Token: 0x060013CE RID: 5070 RVA: 0x002B1378 File Offset: 0x002B0378
        ' (set) Token: 0x060013CD RID: 5069 RVA: 0x002B138C File Offset: 0x002B038C
        Friend Overridable Property btnCancel() As Button
            Get
                Return Me._btnCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, AddressOf Me.btnCancel_Click
                End If
                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, AddressOf Me.btnCancel_Click
                End If
            End Set
        End Property

        ' Token: 0x17000761 RID: 1889
        ' (get) Token: 0x060013D0 RID: 5072 RVA: 0x002B13E0 File Offset: 0x002B03E0
        ' (set) Token: 0x060013CF RID: 5071 RVA: 0x002B13F4 File Offset: 0x002B03F4
        Friend Overridable Property btnSave() As Button
            Get
                Return Me._btnSave
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSave IsNot Nothing Then
                    RemoveHandler Me._btnSave.Click, AddressOf Me.btnSave_Click
                End If
                Me._btnSave = value
                If Me._btnSave IsNot Nothing Then
                    AddHandler Me._btnSave.Click, AddressOf Me.btnSave_Click
                End If
            End Set
        End Property

        ' Token: 0x17000762 RID: 1890
        ' (get) Token: 0x060013D2 RID: 5074 RVA: 0x002B149C File Offset: 0x002B049C
        ' (set) Token: 0x060013D1 RID: 5073 RVA: 0x002B1448 File Offset: 0x002B0448
        Friend Overridable Property btnDebug() As Button
            Get
                Return Me._btnDebug
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnDebug IsNot Nothing Then
                    RemoveHandler Me._btnDebug.Click, AddressOf Me.btnDebug_Click
                End If
                Me._btnDebug = value
                If Me._btnDebug IsNot Nothing Then
                    AddHandler Me._btnDebug.Click, AddressOf Me.btnDebug_Click
                End If
            End Set
        End Property

        ' Token: 0x17000763 RID: 1891
        ' (get) Token: 0x060013D3 RID: 5075 RVA: 0x002B1504 File Offset: 0x002B0504
        ' (set) Token: 0x060013D4 RID: 5076 RVA: 0x002B14B0 File Offset: 0x002B04B0
        Friend Overridable Property btnLoadXML() As Button
            Get
                Return Me._btnLoadXML
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnLoadXML IsNot Nothing Then
                    RemoveHandler Me._btnLoadXML.Click, AddressOf Me.btnLoadXML_Click
                End If
                Me._btnLoadXML = value
                If Me._btnLoadXML IsNot Nothing Then
                    AddHandler Me._btnLoadXML.Click, AddressOf Me.btnLoadXML_Click
                End If
            End Set
        End Property

        ' Token: 0x17000764 RID: 1892
        ' (get) Token: 0x060013D6 RID: 5078 RVA: 0x002B1518 File Offset: 0x002B0518
        ' (set) Token: 0x060013D5 RID: 5077 RVA: 0x002B152C File Offset: 0x002B052C
        Friend Overridable Property btnSaveXML() As Button
            Get
                Return Me._btnSaveXML
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSaveXML IsNot Nothing Then
                    RemoveHandler Me._btnSaveXML.Click, AddressOf Me.btnSaveXML_Click
                End If
                Me._btnSaveXML = value
                If Me._btnSaveXML IsNot Nothing Then
                    AddHandler Me._btnSaveXML.Click, AddressOf Me.btnSaveXML_Click
                End If
            End Set
        End Property

        ' Token: 0x17000765 RID: 1893
        ' (get) Token: 0x060013D7 RID: 5079 RVA: 0x002B15D4 File Offset: 0x002B05D4
        ' (set) Token: 0x060013D8 RID: 5080 RVA: 0x002B1580 File Offset: 0x002B0580
        Friend Overridable Property btnSetUnidentDescLang() As Button
            Get
                Return Me._btnSetUnidentDescLang
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetUnidentDescLang IsNot Nothing Then
                    RemoveHandler Me._btnSetUnidentDescLang.Click, AddressOf Me.btnSetUnidentDescLang_Click
                End If
                Me._btnSetUnidentDescLang = value
                If Me._btnSetUnidentDescLang IsNot Nothing Then
                    AddHandler Me._btnSetUnidentDescLang.Click, AddressOf Me.btnSetUnidentDescLang_Click
                End If
            End Set
        End Property

        ' Token: 0x17000766 RID: 1894
        ' (get) Token: 0x060013DA RID: 5082 RVA: 0x002B15E8 File Offset: 0x002B05E8
        ' (set) Token: 0x060013D9 RID: 5081 RVA: 0x002B15FC File Offset: 0x002B05FC
        Friend Overridable Property btnSetIdentDescLang() As Button
            Get
                Return Me._btnSetIdentDescLang
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetIdentDescLang IsNot Nothing Then
                    RemoveHandler Me._btnSetIdentDescLang.Click, AddressOf Me.btnSetIdentDescLang_Click
                End If
                Me._btnSetIdentDescLang = value
                If Me._btnSetIdentDescLang IsNot Nothing Then
                    AddHandler Me._btnSetIdentDescLang.Click, AddressOf Me.btnSetIdentDescLang_Click
                End If
            End Set
        End Property

        ' Token: 0x17000767 RID: 1895
        ' (get) Token: 0x060013DB RID: 5083 RVA: 0x002B166C File Offset: 0x002B066C
        ' (set) Token: 0x060013DC RID: 5084 RVA: 0x002B1650 File Offset: 0x002B0650
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

        ' Token: 0x17000768 RID: 1896
        ' (get) Token: 0x060013DE RID: 5086 RVA: 0x002B1680 File Offset: 0x002B0680
        ' (set) Token: 0x060013DD RID: 5085 RVA: 0x002B1694 File Offset: 0x002B0694
        Friend Overridable Property lblUpgradeLevel() As Label
            Get
                Return Me._lblUpgradeLevel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblUpgradeLevel IsNot Nothing Then
                End If
                Me._lblUpgradeLevel = value
                If Me._lblUpgradeLevel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000769 RID: 1897
        ' (get) Token: 0x060013E0 RID: 5088 RVA: 0x002B16CC File Offset: 0x002B06CC
        ' (set) Token: 0x060013DF RID: 5087 RVA: 0x002B16B0 File Offset: 0x002B06B0
        Friend Overridable Property nudUpgradeLevel() As NumericUpDown
            Get
                Return Me._nudUpgradeLevel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudUpgradeLevel IsNot Nothing Then
                End If
                Me._nudUpgradeLevel = value
                If Me._nudUpgradeLevel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x060013E2 RID: 5090 RVA: 0x002B33E8 File Offset: 0x002B23E8
        Public Sub New(ByVal UTIClass As clsUTI, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Item Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTI = UTIClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
            If Me.htOverrideFiles.Keys.Count > 0 AndAlso Interaction.MsgBox("The loaded file used some data from files in the Override folder" & vbLf & vbLf & "           Click OK to view the files used.", MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Override files used") = MsgBoxResult.Ok Then
                Dim frmOverrideFilesUsed As frmOverrideFilesUsed = New frmOverrideFilesUsed()
                For Each obj As Object In Me.htOverrideFiles
                    Dim dictionaryEntry As DictionaryEntry = CType((If(obj, Activator.CreateInstance(GetType(DictionaryEntry)))), DictionaryEntry)
                    frmOverrideFilesUsed.lbOverrideFiles.Items.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key))
                Next
                frmOverrideFilesUsed.ShowDialog(Me)
            End If
        End Sub

        ' Token: 0x060013E3 RID: 5091 RVA: 0x002B3524 File Offset: 0x002B2524
        Public Sub Setup()
            Me.g_clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me.UTI.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTI.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTI.SetNumericUpDownToUIntNodeValue(Me.nudCost, "Cost", 0.0F)
            Me.UTI.SetNumericUpDownToUIntNodeValue(Me.nudAdditionalCost, "AddCost", 0.0F)
            Me.UTI.SetNumericUpDownToNodeValue(Me.nudModelVariation, "ModelVariation", 0.0F)
            Me.UTI.SetNumericUpDownToNodeValue(Me.nudCharges, "Charges", 0.0F)
            Me.UTI.SetNumericUpDownToUIntNodeValue(Me.nudStackSize, "StackSize", 0.0F)
            Me.chkbPlotItem.Checked = BooleanType.FromObject(Me.UTI.GetNodeValue("Plot"))
            Me.chkbStolen.Checked = BooleanType.FromObject(Me.UTI.GetNodeValue("Stolen"))
            Me.UTI.SetNumericUpDownToNodeValue(Me.nudPaletteID, "PaletteID", 0.0F)
            If Me.UTI.VerifyNodeExists("TextureVar") Then
                Me.UTI.SetNumericUpDownToNodeValue(Me.nudTextureVariation, "TextureVar", 0.0F)
                Me.nudTextureVariation.Visible = True
                Me.lblTextureVariation.Visible = True
            End If
            If Me.UTI.VerifyNodeExists("BodyVariation") Then
                Me.UTI.SetNumericUpDownToNodeValue(Me.nudBodyVariation, "BodyVariation", 0.0F)
                Me.nudBodyVariation.Visible = True
                Me.lblBodyVariation.Visible = True
            End If
            If Me.UTI.VerifyNodeExists("UpgradeLevel") Then
                Me.UTI.SetNumericUpDownToNodeValue(Me.nudBodyVariation, "UpgradeLevel", 0.0F)
                Me.nudUpgradeLevel.Visible = True
                Me.lblUpgradeLevel.Visible = True
            End If
            Me.BuildDataTable()
            Me.BuildDataGrid()
            Me.ReadPropsAndLoadGrid()
            Me.UTI.SetTextBoxFromCExoLocStringNodeValue(Me.tbLocalizedName, "LocalizedName", Me.g_clsDialogTlk)
            Me.UTI.SetTextBoxFromCExoLocStringNodeValue(Me.tbUnidentifiedDescription, "Description", Me.g_clsDialogTlk)
            Me.UnidentDescLang = IntegerType.FromObject(Me.UTI.GetCExoLocStringLanguage("Description"))
            Me.tbUnidentifiedDescription.Text = Strings.Replace(Me.tbUnidentifiedDescription.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            Me.UTI.SetTextBoxFromCExoLocStringNodeValue(Me.tbIdentifiedDescription, "DescIdentified", Me.g_clsDialogTlk)
            Me.IdentDescLang = IntegerType.FromObject(Me.UTI.GetCExoLocStringLanguage("DescIdentified"))
            Me.tbIdentifiedDescription.Text = Strings.Replace(Me.tbIdentifiedDescription.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            Me.chkbIdentified.Checked = BooleanType.FromObject(Me.UTI.GetNodeValue("Identified"))
            Me.UTI.SetTextBoxToNodeValue(Me.tbComment, "Comment")
            Me.BuildComboBoxes()
            Me.UTI.SyncComboBox(Me.cmbxBaseItem, "BaseItem")
            If Not Me.UTI.SyncComboBox(Me.cmbxBaseItem, "BaseItem") Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
        End Sub

        ' Token: 0x060013E4 RID: 5092 RVA: 0x002B3894 File Offset: 0x002B2894
        Public Sub BuildComboBoxes()
            Me.BuildBaseItemComboBox()
        End Sub

        ' Token: 0x060013E5 RID: 5093 RVA: 0x002B389C File Offset: 0x002B289C
        Public Sub BuildBaseItemComboBox()
            Dim biffarchive As BIFFArchive = New BIFFArchive()
            Dim fileStream As FileStream = New FileStream(Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\data\templates.bif", FileMode.Open)
            Dim biffarchive2 As BIFFArchive = New BIFFArchive(fileStream)
            Dim flag As Boolean = True
            Dim array As Byte()
            If Me.CurrentSettings.bUseOverrideFiles Then
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\override\baseitems.2da"
                Try
                    If File.Exists(text) Then
                        Dim fileStream2 As FileStream = New FileStream(text, FileMode.Open)
                        array = New Byte(CInt(fileStream2.Length) + 1 - 1) {}
                        fileStream2.Read(array, 0, CInt(fileStream2.Length))
                        fileStream2.Close()
                        flag = False
                        Console.WriteLine("Read baseitems.2da from override")
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = Me.g_clsChitinKey.FindResIDForResRef("baseitems", 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + Me.g_clsChitinKey.BiffList(num >> 20).filename
                array = biffarchive.getBIFFResource(text, num).data
                Console.WriteLine("Read baseitems.2da from 2da.bif")
            End If
            Dim clsBaseItems2DA As clsBaseItems2DA = New clsBaseItems2DA(array)
            Dim itemNamesAndTypesList As ArrayList = clsBaseItems2DA.GetItemNamesAndTypesList(Me.g_clsDialogTlk)
            Try
                For Each obj As Object In itemNamesAndTypesList
                    Dim treeBaseItem As TreeBaseItem = CType(obj, TreeBaseItem)
                    Me.cmbxBaseItem.Items.Add(treeBaseItem._name)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x060013E6 RID: 5094 RVA: 0x002B3A70 File Offset: 0x002B2A70
        Private Sub SetGFFNodeValues()
            Me.UTI.SetNodeValueFromComboBox(Me.cmbxBaseItem, "BaseItem")
            Me.UTI.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTI.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTI.SetNumericUpDownToUIntNodeValue(Me.nudCost, "Cost", 0.0F)
            Me.UTI.SetNodeValueFromNumericUpDown(Me.nudAdditionalCost, "AddCost", 0.0F)
            If Me.UTI.VerifyNodeExists("ModelVariation") Then
                Me.UTI.SetNodeValueFromNumericUpDown(Me.nudModelVariation, "ModelVariation", 0.0F)
            End If
            Me.UTI.SetNodeValueFromNumericUpDown(Me.nudCharges, "Charges", 0.0F)
            Me.UTI.SetNodeValueFromNumericUpDown(Me.nudStackSize, "StackSize", 0.0F)
            Me.UTI.SetNodeValue("Plot", Me.chkbPlotItem.Checked)
            Me.UTI.SetNodeValue("Stolen", Me.chkbStolen.Checked)
            Me.UTI.SetNodeValueFromNumericUpDown(Me.nudPaletteID, "PaletteID", 0.0F)
            If Me.UTI.VerifyNodeExists("TextureVar") Then
                Me.UTI.SetNodeValueFromNumericUpDown(Me.nudTextureVariation, "TextureVar", 0.0F)
            End If
            If Me.UTI.VerifyNodeExists("BodyVariation") Then
                Me.UTI.SetNodeValueFromNumericUpDown(Me.nudBodyVariation, "BodyVariation", 0.0F)
            End If
            If Me.UTI.VerifyNodeExists("UpgradeLevel") Then
                Me.UTI.SetNodeValueFromNumericUpDown(Me.nudBodyVariation, "UpgradeLevel", 0.0F)
            End If
            If Not Me.UTI.VerifyNodeExists("PropertiesList") Then
                Me.UTI.CreateList("", "PropertiesList")
            Else
                Me.UTI.ClearListElements("PropertiesList")
            End If
            Try
                For Each obj As Object In Me.dt.Rows
                    Dim dataRow As DataRow = CType(obj, DataRow)
                    Dim gff_Struct As GFF_Struct = New GFF_Struct()
                    gff_Struct.type = 0
                    gff_Struct.fieldCount = 7
                    If ObjectType.ObjTst(dataRow("Param2ID"), -1, False) <> 0 Then
                        Dim gff_Struct2 As GFF_Struct = gff_Struct
                        gff_Struct2.fieldCount += 2
                    End If
                    If ObjectType.ObjTst(dataRow("UpgradeID"), -1, False) <> 0 Then
                        Dim gff_Struct2 As GFF_Struct = gff_Struct
                        gff_Struct2.fieldCount += 1
                    End If
                    gff_Struct.fields = New GFF_Field(gff_Struct.fieldCount - 1 + 1 - 1) {}
                    gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_word, "PropertyName", IntegerType.FromObject(dataRow("PropertyID")))
                    gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_word, "Subtype", IntegerType.FromObject(dataRow("SubtypeID")))
                    gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "CostTable", IntegerType.FromObject(dataRow("CostTableID")))
                    gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_word, "CostValue", IntegerType.FromObject(dataRow("CostValueID")))
                    gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_byte, "Param1", IntegerType.FromObject(dataRow("Param1ID")))
                    gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_byte, "Param1Value", IntegerType.FromObject(dataRow("Param1ValueID")))
                    Dim num As Integer = 6
                    If ObjectType.ObjTst(dataRow("Param2ID"), -1, False) <> 0 Then
                        gff_Struct.fields(num) = New GFF_Field(GFFField.GFF_byte, "Param2", IntegerType.FromObject(dataRow("Param2ID")))
                        num += 1
                        gff_Struct.fields(num) = New GFF_Field(GFFField.GFF_byte, "Param2Value", IntegerType.FromObject(dataRow("Param2ValueID")))
                        num += 1
                    End If
                    If ObjectType.ObjTst(dataRow("UpgradeID"), -1, False) <> 0 Then
                        gff_Struct.fields(num) = New GFF_Field(GFFField.GFF_byte, "UpgradeType", IntegerType.FromObject(dataRow("UpgradeID")))
                        num += 1
                    End If
                    gff_Struct.fields(num) = New GFF_Field(GFFField.GFF_byte, "ChanceAppear", IntegerType.FromObject(dataRow("% Chance of Appearance")))
                    Me.UTI.AddListElement("PropertiesList", gff_Struct)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.UTI.SetNodeValue("Identified", Me.chkbIdentified.Checked)
            Me.UTI.SetCExoLocStringNodeValueFromTextBox(Me.tbLocalizedName, "LocalizedName", 0)
            Dim textBox As TextBox = New TextBox()
            textBox.Text = Strings.Replace(Me.tbUnidentifiedDescription.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary)
            Me.UTI.SetCExoLocStringNodeValueFromTextBox(textBox, "Description", Me.UnidentDescLang)
            textBox.Text = Strings.Replace(Me.tbIdentifiedDescription.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary)
            Me.UTI.SetCExoLocStringNodeValueFromTextBox(textBox, "DescIdentified", Me.IdentDescLang)
            Me.UTI.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x060013E7 RID: 5095 RVA: 0x002B4004 File Offset: 0x002B3004
        Public Function ReadCls2DA(ByVal TwoDAName As String) As cls2DA
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
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = Me.g_clsChitinKey.FindResIDForResRef(TwoDAName, 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + Me.g_clsChitinKey.BiffList(num >> 20).filename
                array = BIFFArchive.getBIFFResource(text, num).data
            End If
            Return New cls2DA(array)
        End Function

        ' Token: 0x060013E8 RID: 5096 RVA: 0x002B4120 File Offset: 0x002B3120
        Public Function GetCls2DA(ByVal TwoDAName As String) As cls2DA
            Dim text As String = Strings.LCase(TwoDAName)
            If StringType.StrCmp(text, "iprp_abilities", False) = 0 Then
                If Me.iprp_abilities Is Nothing Then
                    Me.iprp_abilities = Me.ReadCls2DA("iprp_abilities")
                End If
                Return Me.iprp_abilities
            End If
            If StringType.StrCmp(text, "appearance", False) = 0 Then
                If Me.appearance Is Nothing Then
                    Me.appearance = Me.ReadCls2DA("appearance")
                End If
                Return Me.appearance
            End If
            If StringType.StrCmp(text, "classes", False) = 0 Then
                If Me.classes Is Nothing Then
                    Me.classes = Me.ReadCls2DA("classes")
                End If
                Return Me.classes
            End If
            If StringType.StrCmp(text, "feat", False) = 0 Then
                If Me.feat Is Nothing Then
                    Me.feat = Me.ReadCls2DA("feat")
                End If
                Return Me.feat
            End If
            If StringType.StrCmp(text, "iprp_acmodtype", False) = 0 Then
                If Me.iprp_acmodtype Is Nothing Then
                    Me.iprp_acmodtype = Me.ReadCls2DA("iprp_acmodtype")
                End If
                Return Me.iprp_acmodtype
            End If
            If StringType.StrCmp(text, "iprp_aligngrp", False) = 0 Then
                If Me.iprp_aligngrp Is Nothing Then
                    Me.iprp_aligngrp = Me.ReadCls2DA("iprp_aligngrp")
                End If
                Return Me.iprp_aligngrp
            End If
            If StringType.StrCmp(text, "iprp_ammotype", False) = 0 Then
                If Me.iprp_ammotype Is Nothing Then
                    Me.iprp_ammotype = Me.ReadCls2DA("iprp_ammotype")
                End If
                Return Me.iprp_ammotype
            End If
            If StringType.StrCmp(text, "iprp_combatdam", False) = 0 Then
                If Me.iprp_combatdam Is Nothing Then
                    Me.iprp_combatdam = Me.ReadCls2DA("iprp_combatdam")
                End If
                Return Me.iprp_combatdam
            End If
            If StringType.StrCmp(text, "iprp_damagetype", False) = 0 Then
                If Me.iprp_damagetype Is Nothing Then
                    Me.iprp_damagetype = Me.ReadCls2DA("iprp_damagetype")
                End If
                Return Me.iprp_damagetype
            End If
            If StringType.StrCmp(text, "iprp_immunity", False) = 0 Then
                If Me.iprp_immunity Is Nothing Then
                    Me.iprp_immunity = Me.ReadCls2DA("iprp_immunity")
                End If
                Return Me.iprp_immunity
            End If
            If StringType.StrCmp(text, "iprp_monsterhit", False) = 0 Then
                If Me.iprp_monsterhit Is Nothing Then
                    Me.iprp_monsterhit = Me.ReadCls2DA("iprp_monsterhit")
                End If
                Return Me.iprp_monsterhit
            End If
            If StringType.StrCmp(text, "iprp_onhit", False) = 0 Then
                If Me.iprp_onhit Is Nothing Then
                    Me.iprp_onhit = Me.ReadCls2DA("iprp_onhit")
                End If
                Return Me.iprp_onhit
            End If
            If StringType.StrCmp(text, "iprp_protection", False) = 0 Then
                If Me.iprp_protection Is Nothing Then
                    Me.iprp_protection = Me.ReadCls2DA("iprp_protection")
                End If
                Return Me.iprp_protection
            End If
            If StringType.StrCmp(text, "iprp_saveelement", False) = 0 Then
                If Me.iprp_saveelement Is Nothing Then
                    Me.iprp_saveelement = Me.ReadCls2DA("iprp_saveelement")
                End If
                Return Me.iprp_saveelement
            End If
            If StringType.StrCmp(text, "iprp_savingthrow", False) = 0 Then
                If Me.iprp_savingthrow Is Nothing Then
                    Me.iprp_savingthrow = Me.ReadCls2DA("iprp_savingthrow")
                End If
                Return Me.iprp_savingthrow
            End If
            If StringType.StrCmp(text, "iprp_walk", False) = 0 Then
                If Me.iprp_walk Is Nothing Then
                    Me.iprp_walk = Me.ReadCls2DA("iprp_walk")
                End If
                Return Me.iprp_walk
            End If
            If StringType.StrCmp(text, "racialtypes", False) = 0 Then
                If Me.racialtypes Is Nothing Then
                    Me.racialtypes = Me.ReadCls2DA("racialtypes")
                End If
                Return Me.racialtypes
            End If
            If StringType.StrCmp(text, "skills", False) = 0 Then
                If Me.skills Is Nothing Then
                    Me.skills = Me.ReadCls2DA("skills")
                End If
                Return Me.skills
            End If
            If StringType.StrCmp(text, "spells", False) = 0 Then
                If Me.spells Is Nothing Then
                    Me.spells = Me.ReadCls2DA("spells")
                End If
                Return Me.spells
            End If
            If StringType.StrCmp(text, "traps", False) = 0 Then
                If Me.traps Is Nothing Then
                    Me.traps = Me.ReadCls2DA("traps")
                End If
                Return Me.traps
            End If
            If StringType.StrCmp(text, "iprp_pc", False) = 0 Then
                If Me.iprp_pc Is Nothing Then
                    Me.iprp_pc = Me.ReadCls2DA("iprp_pc")
                End If
                Return Me.iprp_pc
            End If
            Console.WriteLine("UTI Editor: 2DA file needed for lookup loaded directly - " + TwoDAName)
            Return Me.ReadCls2DA(TwoDAName)
        End Function

        ' Token: 0x060013E9 RID: 5097 RVA: 0x002B4528 File Offset: 0x002B3528
        Public Sub Load2DAs()
            Me.itempropdef = Me.ReadCls2DA("itempropdef")
            Me.iprp_costtable = Me.ReadCls2DA("iprp_costtable")
            Me.iprp_paramtable = Me.ReadCls2DA("iprp_paramtable")
        End Sub

        ' Token: 0x060013EA RID: 5098 RVA: 0x002B4560 File Offset: 0x002B3560
        Public Sub BuildDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Property", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Subtype", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("CostTable", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("CostValue", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param1", GetType(String))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param1Value", GetType(String))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param2", GetType(String))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param2Value", GetType(String))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Upgrade", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("% Chance of Appearance", GetType(String))
            dataColumn.DefaultValue = 100
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("PropertyID", GetType(Integer))
            dataColumn.DefaultValue = 0
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("SubtypeID", GetType(Integer))
            dataColumn.DefaultValue = 0
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("CostTableID", GetType(Integer))
            dataColumn.DefaultValue = 0
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("CostValueID", GetType(Integer))
            dataColumn.DefaultValue = 0
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param1ID", GetType(Integer))
            dataColumn.DefaultValue = -1
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param1ValueID", GetType(Integer))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param2ID", GetType(Integer))
            dataColumn.DefaultValue = -1
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param2ValueID", GetType(Integer))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("UpgradeID", GetType(Integer))
            dataColumn.DefaultValue = -1
            Me.dt.Columns.Add(dataColumn)
        End Sub

        ' Token: 0x060013EB RID: 5099 RVA: 0x002B48D8 File Offset: 0x002B38D8
        Public Sub BuildDataGrid()
            Me.DView = Me.dt.DefaultView
            Me.DView.AllowDelete = True
            Me.DView.AllowNew = True
            Me.DView.AllowEdit = False
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgProperties.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dt.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Property"
            dataGridTextBoxColumn.HeaderText = "Property"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Subtype"
            dataGridTextBoxColumn.HeaderText = "Subtype"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "CostTable"
            dataGridTextBoxColumn.HeaderText = "CostTable"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "CostValue"
            dataGridTextBoxColumn.HeaderText = "CostValue"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param1"
            dataGridTextBoxColumn.HeaderText = "Param1"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param1Value"
            dataGridTextBoxColumn.HeaderText = "Param1Value"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param2"
            dataGridTextBoxColumn.HeaderText = "Param2"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param2Value"
            dataGridTextBoxColumn.HeaderText = "Param2Value"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Upgrade"
            dataGridTextBoxColumn.HeaderText = "Upgrade"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "% Chance of Appearance"
            dataGridTextBoxColumn.HeaderText = "% Chance of Appearance"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "PropertyID"
            dataGridTextBoxColumn.HeaderText = "PropertyID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "SubtypeID"
            dataGridTextBoxColumn.HeaderText = "SubtypeID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "CostTableID"
            dataGridTextBoxColumn.HeaderText = "CostTableID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "CostValueID"
            dataGridTextBoxColumn.HeaderText = "CostValueID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param1ID"
            dataGridTextBoxColumn.HeaderText = "Param1ID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param1ValueID"
            dataGridTextBoxColumn.HeaderText = "Param1ValueID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param2ID"
            dataGridTextBoxColumn.HeaderText = "Param2ID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param2ValueID"
            dataGridTextBoxColumn.HeaderText = "Param2ValueID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "UpgradeID"
            dataGridTextBoxColumn.HeaderText = "UpgradeID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Me.dgProperties.TableStyles.Add(dataGridTableStyle)
            Me.dgProperties.SetDataBinding(Me.DView, Nothing)
            Me.dgProperties.CaptionVisible = False
        End Sub

        ' Token: 0x060013EC RID: 5100 RVA: 0x002B4D84 File Offset: 0x002B3D84
        Public Sub AutoSizeColumns()
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1
            For i As Integer = num To num2
                Me.dgProperties.TableStyles(0).GridColumnStyles(i).Width = Me.GetColWidth(i, Me.dt.Columns(i).Caption)
            Next
        End Sub

        ' Token: 0x060013ED RID: 5101 RVA: 0x002B4DF0 File Offset: 0x002B3DF0
        Protected Function GetColWidth(ByVal col As Integer, ByVal DisplayName As String) As Integer
            Dim num As Single = 0.0F
            Dim count As Integer = CType(Me.dgProperties.DataSource, DataView).Count
            Dim graphics As Graphics = graphics.FromHwnd(Me.Handle)
            Dim stringFormat As StringFormat = New StringFormat(stringFormat.GenericTypographic)
            num = graphics.MeasureString(DisplayName, Me.Font, 500, stringFormat).Width
            Try
                Dim num2 As Integer = 0
                Dim num3 As Integer = count - 1
                For i As Integer = num2 To num3
                    Dim sizeF As SizeF = graphics.MeasureString(Me.dgProperties(i, col).ToString(), Me.Font, 500, stringFormat)
                    If sizeF.Width > num Then
                        num = sizeF.Width
                    End If
                Next
                graphics.Dispose()
            Catch ex As System.Exception
                num = 75.0F
            End Try
            Return CInt(Math.Round(CDbl((num + 10.0F))))
        End Function

        ' Token: 0x060013EE RID: 5102 RVA: 0x002B4EDC File Offset: 0x002B3EDC
        Private Sub ReadPropsAndLoadGrid()
            If Not Me.UTI.VerifyNodeExists("PropertiesList") Then
                Return
            End If
            Dim listItemCount As Integer = Me.UTI.GetListItemCount("PropertiesList")
            If listItemCount > 0 Then
                Me.Load2DAs()
            End If
            Dim num As Integer = 0
            Dim num2 As Integer = listItemCount - 1
            For i As Integer = num To num2
                Dim dataRow As DataRow = Me.dt.NewRow()
                Dim num3 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").PropertyName")))
                dataRow("PropertyID") = num3
                Dim num4 As Integer = IntegerType.FromString(Me.itempropdef.GetIndiceData(num3, "name"))
                Dim text As String = Me.g_clsDialogTlk.GetString(num4)
                dataRow("Property") = text
                text = Me.itempropdef.GetIndiceData(num3, "subtyperesref")
                Dim obj As Object
                If StringType.StrCmp(text, "****", False) <> 0 Then
                    num3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Subtype")))
                    dataRow("SubtypeID") = num3
                    If StringType.StrCmp(text, "Appearance", False) = 0 Then
                        obj = Me.GetCls2DA(text).GetIndiceData(num3, "label")
                    Else
                        obj = Me.GetCls2DA(text).GetIndiceData(num3, "name")
                    End If
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
                        text = Me.g_clsDialogTlk.GetString(IntegerType.FromObject(obj))
                    ElseIf obj.[GetType]().Name.EndsWith("String") Then
                        text = obj.ToString()
                    Else
                        text = "Error: Unknown type"
                    End If
                    dataRow("Subtype") = text
                End If
                num3 = IntegerType.FromObject(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").CostTable"))
                dataRow("CostTableID") = num3
                text = Me.iprp_costtable.GetIndiceData(num3, "label")
                dataRow("CostTable") = text
                text = Me.iprp_costtable.GetIndiceData(num3, "name")
                num3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").CostValue")))
                dataRow("CostValueID") = num3
                If StringType.StrCmp(text, "IPRP_BASE1", False) <> 0 Then
                    num4 = IntegerType.FromString(Me.ReadCls2DA(text).GetIndiceData(num3, "name"))
                    text = Me.g_clsDialogTlk.GetString(num4)
                    dataRow("CostValue") = text
                Else
                    dataRow("CostValue") = "n/a"
                End If
                obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param1"))
                If obj Is Nothing OrElse ObjectType.ObjTst(obj, 255, False) = 0 Then
                    dataRow("Param1") = "n/a"
                    If ObjectType.ObjTst(obj, 255, False) = 0 Then
                        dataRow("Param1ID") = RuntimeHelpers.GetObjectValue(obj)
                    End If
                    obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param1Value"))
                    If obj Is Nothing Then
                        dataRow("Param1Value") = "n/a"
                        dataRow("Param1ValueID") = -1
                    Else
                        dataRow("Param1ValueID") = RuntimeHelpers.GetObjectValue(obj)
                    End If
                Else
                    num3 = IntegerType.FromObject(obj)
                    dataRow("Param1ID") = num3
                    num4 = IntegerType.FromString(Me.iprp_paramtable.GetIndiceData(num3, "name"))
                    text = Me.g_clsDialogTlk.GetString(num4)
                    dataRow("Param1") = text
                    text = Me.iprp_paramtable.GetIndiceData(num3, "tableresref")
                    obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param1Value"))
                    If obj Is Nothing Then
                        dataRow("Param1Value") = "n/a"
                    Else
                        num3 = IntegerType.FromObject(obj)
                        dataRow("Param1ValueID") = num3
                        num4 = IntegerType.FromString(Me.ReadCls2DA(text).GetIndiceData(num3, "name"))
                        text = Me.g_clsDialogTlk.GetString(num4)
                        dataRow("Param1Value") = text
                    End If
                End If
                obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param2"))
                If obj Is Nothing OrElse ObjectType.ObjTst(obj, 255, False) = 0 Then
                    dataRow("Param2") = "n/a"
                    If ObjectType.ObjTst(obj, 255, False) = 0 Then
                        dataRow("Param2ID") = RuntimeHelpers.GetObjectValue(obj)
                    End If
                    obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param2Value"))
                    If obj Is Nothing Then
                        dataRow("Param2Value") = "n/a"
                        dataRow("Param2ValueID") = -1
                    Else
                        dataRow("Param2ValueID") = RuntimeHelpers.GetObjectValue(obj)
                        dataRow("Param2ValueID") = num3
                        num4 = IntegerType.FromString(Me.ReadCls2DA(text).GetIndiceData(num3, "name"))
                        text = Me.g_clsDialogTlk.GetString(num4)
                        dataRow("Param2Value") = text
                    End If
                Else
                    num3 = IntegerType.FromObject(obj)
                    dataRow("Param2ID") = num3
                    num4 = IntegerType.FromString(Me.iprp_paramtable.GetIndiceData(num3, "name"))
                    text = Me.g_clsDialogTlk.GetString(num4)
                    dataRow("Param2") = text
                    text = Me.iprp_paramtable.GetIndiceData(num3, "tableresref")
                    obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param2Value"))
                    If obj Is Nothing Then
                        dataRow("Param2Value") = "n/a"
                    Else
                        num3 = IntegerType.FromObject(obj)
                        dataRow("Param2ValueID") = num3
                        num4 = IntegerType.FromString(Me.ReadCls2DA(text).GetIndiceData(num3, "name"))
                        text = Me.g_clsDialogTlk.GetString(num4)
                        dataRow("Param2Value") = text
                    End If
                End If
                If Me.UTI.VerifyNodeExists("PropertiesList(" + StringType.FromInteger(i) + ").UpgradeType") Then
                    num4 = IntegerType.FromObject(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").UpgradeType"))
                    dataRow("UpgradeID") = num4
                    dataRow("Upgrade") = Strings.Replace(Me.ReadCls2DA("Upgrade").GetIndiceData(num4, "label"), "_", " ", 1, -1, CompareMethod.Binary)
                Else
                    dataRow("UpgradeID") = -1
                    dataRow("Upgrade") = "n/a"
                End If
                obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").ChanceAppear"))
                If obj Is Nothing Then
                    dataRow("% Chance of Appearance") = "n/a"
                Else
                    dataRow("% Chance of Appearance") = RuntimeHelpers.GetObjectValue(obj)
                End If
                Me.dt.Rows.Add(dataRow)
            Next
            Me.AutoSizeColumns()
        End Sub

        ' Token: 0x060013EF RID: 5103 RVA: 0x002B5690 File Offset: 0x002B4690
        Private Sub dgProperties_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim cursor As Cursor = cursor.Current
            Dim dataGrid As DataGrid = CType(sender, DataGrid)
            Dim hitTestInfo As DataGrid.HitTestInfo = dataGrid.HitTest(dataGrid.PointToClient(Control.MousePosition).X, dataGrid.PointToClient(Control.MousePosition).Y)
            If hitTestInfo.Type = dataGrid.HitTestType.RowHeader Then
                Dim frmItemPropertyEditor As frmItemPropertyEditor = New frmItemPropertyEditor(Me.KotorVersionIndex)
                If Me.IsLastRow(hitTestInfo.Row) Then
                    frmItemPropertyEditor.btnOK.Text = "Add"
                    frmItemPropertyEditor.ShowDialog(Me)
                    Application.DoEvents()
                    If frmItemPropertyEditor.DialogResult = DialogResult.OK Then
                        Dim dataRow As DataRow = Me.dt.NewRow()
                        dataRow("Property") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxPropertyName.SelectedItem)
                        dataRow("Subtype") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxSubtype.SelectedItem)
                        dataRow("CostTable") = frmItemPropertyEditor.CostTableName
                        If Not frmItemPropertyEditor.cmbxParam1Value.Enabled Then
                            dataRow("Param1") = "n/a"
                            dataRow("Param1ID") = 255
                            dataRow("Param1Value") = "(none)"
                            dataRow("Param1ValueID") = 0
                        Else
                            dataRow("Param1") = frmItemPropertyEditor.Param1Desc
                            dataRow("Param1ID") = IntegerType.FromString(frmItemPropertyEditor.tbParam1resref.Text)
                            dataRow("Param1Value") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxParam1Value.SelectedItem)
                            dataRow("Param1ValueID") = frmItemPropertyEditor.cmbxParam1Value.SelectedIndex
                        End If
                        If Not frmItemPropertyEditor.cmbxParam2Value.Enabled Then
                            dataRow("Param2") = "n/a"
                            dataRow("Param2ID") = -1
                            dataRow("Param2Value") = "(none)"
                            dataRow("Param2ValueID") = -1
                        Else
                            dataRow("Param2") = frmItemPropertyEditor.Param2Desc
                            dataRow("Param2ID") = IntegerType.FromString(frmItemPropertyEditor.tbParam2resref.Text)
                            dataRow("Param2Value") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxParam2Value.SelectedItem)
                            dataRow("Param2ValueID") = frmItemPropertyEditor.cmbxParam2Value.SelectedIndex
                        End If
                        If frmItemPropertyEditor.cmbxUpgrade.SelectedIndex > 0 Then
                            dataRow("UpgradeID") = frmItemPropertyEditor.cmbxUpgrade.SelectedIndex - 1
                            dataRow("Upgrade") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxUpgrade.SelectedItem)
                        End If
                        dataRow("PropertyID") = frmItemPropertyEditor.cmbxPropertyName.SelectedIndex
                        If Not frmItemPropertyEditor.cmbxSubtype.Enabled Then
                            dataRow("SubtypeID") = 0
                        Else
                            dataRow("SubtypeID") = frmItemPropertyEditor.cmbxSubtype.SelectedIndex
                        End If
                        If StringType.StrCmp(frmItemPropertyEditor.CostTableID, "****", False) = 0 Then
                            dataRow("CostTableID") = 0
                        Else
                            dataRow("CostTableID") = frmItemPropertyEditor.CostTableID
                        End If
                        If (Not frmItemPropertyEditor.cmbxSubtype.Enabled Or (StringType.StrCmp(frmItemPropertyEditor.CostTableID, "****", False) = 0)) And Not frmItemPropertyEditor.cmbxCostValue.Enabled Then
                            dataRow("CostValue") = 0
                            dataRow("CostValueID") = 0
                        ElseIf frmItemPropertyEditor.cmbxSubtype.Enabled And Not frmItemPropertyEditor.cmbxCostValue.Enabled Then
                            dataRow("CostValue") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxSubtype.SelectedItem)
                            dataRow("CostValueID") = frmItemPropertyEditor.cmbxSubtype.SelectedIndex
                        Else
                            dataRow("CostValue") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxCostValue.SelectedItem)
                            dataRow("CostValueID") = frmItemPropertyEditor.cmbxCostValue.SelectedIndex
                        End If
                        dataRow("% Chance of Appearance") = frmItemPropertyEditor.nudPercentChance.Value
                        Me.dt.Rows.Add(dataRow)
                        cursor.Current = Cursors.WaitCursor
                        cursor.Current = cursor
                    End If
                Else
                    frmItemPropertyEditor.btnOK.Text = "Update"
                    Dim dataRow As DataRow = Me.dt.DefaultView(hitTestInfo.Row).Row
                    frmItemPropertyEditor.cmbxPropertyName.SelectedIndex = IntegerType.FromObject(dataRow("PropertyID"))
                    If frmItemPropertyEditor.cmbxSubtype.Items.Count > 0 Then
                        frmItemPropertyEditor.cmbxSubtype.SelectedIndex = IntegerType.FromObject(dataRow("SubtypeID"))
                    End If
                    If frmItemPropertyEditor.cmbxCostValue.Items.Count > 0 Then
                        frmItemPropertyEditor.cmbxCostValue.SelectedIndex = IntegerType.FromObject(dataRow("CostValueID"))
                    End If
                    If IntegerType.FromObject(dataRow("Param1ID")) <> 255 Then
                        frmItemPropertyEditor.cmbxParam1Value.SelectedIndex = IntegerType.FromObject(dataRow("Param1ValueID"))
                    End If
                    If IntegerType.FromObject(dataRow("Param2ID")) <> -1 Then
                        frmItemPropertyEditor.cmbxParam2Value.SelectedIndex = IntegerType.FromObject(dataRow("Param2ValueID"))
                    End If
                    If IntegerType.FromObject(dataRow("UpgradeID")) <> -1 Then
                        frmItemPropertyEditor.cmbxUpgrade.SelectedIndex = IntegerType.FromObject(dataRow("UpgradeID")) + 1
                    End If
                    dataGrid.UnSelect(dataGrid.CurrentRowIndex + 1)
                    frmItemPropertyEditor.ShowDialog(Me)
                    Application.DoEvents()
                    If frmItemPropertyEditor.DialogResult = DialogResult.OK Then
                        Me.SetDataTableReadOnlyState(False)
                        dataRow("Property") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxPropertyName.SelectedItem)
                        dataRow("Subtype") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxSubtype.SelectedItem)
                        dataRow("CostTable") = frmItemPropertyEditor.CostTableName
                        If Not frmItemPropertyEditor.cmbxParam1Value.Enabled Then
                            dataRow("Param1") = "n/a"
                            dataRow("Param1ID") = 255
                            dataRow("Param1Value") = "(none)"
                            dataRow("Param1ValueID") = 0
                        Else
                            dataRow("Param1") = frmItemPropertyEditor.Param1Desc
                            dataRow("Param1ID") = IntegerType.FromString(frmItemPropertyEditor.tbParam1resref.Text)
                            dataRow("Param1Value") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxParam1Value.SelectedItem)
                            dataRow("Param1ValueID") = frmItemPropertyEditor.cmbxParam1Value.SelectedIndex
                        End If
                        If Not frmItemPropertyEditor.cmbxParam2Value.Enabled Then
                            dataRow("Param2") = "n/a"
                            dataRow("Param2ID") = -1
                            dataRow("Param2Value") = "(none)"
                            dataRow("Param2ValueID") = -1
                        Else
                            dataRow("Param2") = frmItemPropertyEditor.Param2Desc
                            dataRow("Param2ID") = IntegerType.FromString(frmItemPropertyEditor.tbParam2resref.Text)
                            dataRow("Param2Value") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxParam2Value.SelectedItem)
                            dataRow("Param2ValueID") = frmItemPropertyEditor.cmbxParam2Value.SelectedIndex
                        End If
                        If frmItemPropertyEditor.cmbxUpgrade.SelectedIndex > 0 Then
                            dataRow("UpgradeID") = frmItemPropertyEditor.cmbxUpgrade.SelectedIndex - 1
                            dataRow("Upgrade") = Strings.Replace(StringType.FromObject(frmItemPropertyEditor.cmbxUpgrade.SelectedItem), "_", " ", 1, -1, CompareMethod.Binary)
                        Else
                            dataRow("UpgradeID") = -1
                            dataRow("Upgrade") = "n/a"
                        End If
                        dataRow("PropertyID") = frmItemPropertyEditor.cmbxPropertyName.SelectedIndex
                        If Not frmItemPropertyEditor.cmbxSubtype.Enabled Then
                            dataRow("SubtypeID") = 0
                        Else
                            dataRow("SubtypeID") = frmItemPropertyEditor.cmbxSubtype.SelectedIndex
                        End If
                        If StringType.StrCmp(frmItemPropertyEditor.CostTableID, "****", False) = 0 Then
                            dataRow("CostTableID") = 0
                        Else
                            dataRow("CostTableID") = frmItemPropertyEditor.CostTableID
                        End If
                        If (Not frmItemPropertyEditor.cmbxSubtype.Enabled Or (StringType.StrCmp(frmItemPropertyEditor.CostTableID, "****", False) = 0)) And Not frmItemPropertyEditor.cmbxCostValue.Enabled Then
                            dataRow("CostValue") = 0
                            dataRow("CostValueID") = 0
                        ElseIf frmItemPropertyEditor.cmbxSubtype.Enabled And Not frmItemPropertyEditor.cmbxCostValue.Enabled Then
                            dataRow("CostValue") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxSubtype.SelectedItem)
                            dataRow("CostValueID") = frmItemPropertyEditor.cmbxSubtype.SelectedIndex
                        Else
                            dataRow("CostValue") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxCostValue.SelectedItem)
                            dataRow("CostValueID") = frmItemPropertyEditor.cmbxCostValue.SelectedIndex
                        End If
                        dataRow("% Chance of Appearance") = frmItemPropertyEditor.nudPercentChance.Value
                        Me.SetDataTableReadOnlyState(True)
                        dataGrid.[Select](hitTestInfo.Row)
                    End If
                End If
            End If
            Me.AutoSizeColumns()
        End Sub

        ' Token: 0x060013F0 RID: 5104 RVA: 0x002B60C8 File Offset: 0x002B50C8
        Protected Function IsLastRow(ByVal row As Integer) As Boolean
            ' The following expression was wrapped in a checked-statement
            Dim flag As Boolean
            Try
                Me.dgProperties.[Select](row + 1)
                Me.dgProperties.UnSelect(row + 1)
                flag = False
            Catch ex As IndexOutOfRangeException
                Dim ex2 As IndexOutOfRangeException = CType(ex, IndexOutOfRangeException)
                flag = True
            End Try
            Return flag
        End Function

        ' Token: 0x060013F1 RID: 5105 RVA: 0x002B611C File Offset: 0x002B511C
        Protected Sub SetDataTableReadOnlyState(ByVal ReadOnlyState As Boolean)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1
            For i As Integer = num To num2
                Me.dt.Columns(i).[ReadOnly] = ReadOnlyState
            Next
        End Sub

        ' Token: 0x060013F2 RID: 5106 RVA: 0x002B6160 File Offset: 0x002B5160
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x060013F3 RID: 5107 RVA: 0x002B6168 File Offset: 0x002B5168
        Private Sub frmUTI_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.Name)
        End Sub

        ' Token: 0x060013F4 RID: 5108 RVA: 0x002B6178 File Offset: 0x002B5178
        Private Sub frmUTI_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.Name)
        End Sub

        ' Token: 0x060013F5 RID: 5109 RVA: 0x002B6188 File Offset: 0x002B5188
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Item Editor - " + Name
        End Sub

        ' Token: 0x060013F6 RID: 5110 RVA: 0x002B619C File Offset: 0x002B519C
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".uti", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTI.WriteFile(Me.m_EditingFilePath, "UTI")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x060013F7 RID: 5111 RVA: 0x002B6234 File Offset: 0x002B5234
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbTag.Text
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTI.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x060013F8 RID: 5112 RVA: 0x002B62A0 File Offset: 0x002B52A0
        Private Sub btnLoadXML_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", Me.CurrentSettings.defaultImportLocation, "", "Load Properties (XML) file...", "xml", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim dataSet As DataSet = New DataSet("Kotor_ItemProperties_File")
            dataSet.ReadXml(text)
            Me.dt = dataSet.Tables(0)
            dataSet.Tables.Remove(Me.dt)
            dataSet.Dispose()
            Me.DView = Me.dt.DefaultView
            Me.dgProperties.SetDataBinding(Me.DView, Nothing)
            Me.BuildDataGrid()
            Me.AutoSizeColumns()
        End Sub

        ' Token: 0x060013F9 RID: 5113 RVA: 0x002B6354 File Offset: 0x002B5354
        Private Sub btnSaveXML_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Me.tbTemplateResRef.Text + ".xml", "Save Properties (XML) file...", "xml", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim dataSet As DataSet = New DataSet("Kotor_ItemProperties_File")
            dataSet.Tables.Add(Me.dt)
            dataSet.WriteXml(text)
            dataSet.Tables.Remove(Me.dt)
            dataSet.Dispose()
        End Sub

        ' Token: 0x060013FA RID: 5114 RVA: 0x002B63E8 File Offset: 0x002B53E8
        Private Sub btnSetUnidentDescLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.UnidentDescLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.UnidentDescLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x060013FB RID: 5115 RVA: 0x002B6418 File Offset: 0x002B5418
        Private Sub btnSetIdentDescLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.IdentDescLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.IdentDescLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x04000961 RID: 2401
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000962 RID: 2402
        <AccessedThroughProperty("tabpagProperties")> _
        Private _tabpagProperties As TabPage

        ' Token: 0x04000963 RID: 2403
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000964 RID: 2404
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x04000965 RID: 2405
        <AccessedThroughProperty("tabpagDescription")> _
        Private _tabpagDescription As TabPage

        ' Token: 0x04000966 RID: 2406
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000967 RID: 2407
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x04000968 RID: 2408
        <AccessedThroughProperty("tbTemplateResRef")> _
        Private _tbTemplateResRef As TextBox

        ' Token: 0x04000969 RID: 2409
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x0400096A RID: 2410
        <AccessedThroughProperty("tabpagComments")> _
        Private _tabpagComments As TabPage

        ' Token: 0x0400096B RID: 2411
        <AccessedThroughProperty("ToolTip1")> _
        Private _ToolTip1 As ToolTip

        ' Token: 0x0400096C RID: 2412
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x0400096D RID: 2413
        <AccessedThroughProperty("chkbStolen")> _
        Private _chkbStolen As CheckBox

        ' Token: 0x0400096E RID: 2414
        <AccessedThroughProperty("tbUnidentifiedDescription")> _
        Private _tbUnidentifiedDescription As TextBox

        ' Token: 0x0400096F RID: 2415
        <AccessedThroughProperty("tbLocalizedName")> _
        Private _tbLocalizedName As TextBox

        ' Token: 0x04000970 RID: 2416
        <AccessedThroughProperty("nudCost")> _
        Private _nudCost As NumericUpDown

        ' Token: 0x04000971 RID: 2417
        <AccessedThroughProperty("nudAdditionalCost")> _
        Private _nudAdditionalCost As NumericUpDown

        ' Token: 0x04000972 RID: 2418
        <AccessedThroughProperty("tbIdentifiedDescription")> _
        Private _tbIdentifiedDescription As TextBox

        ' Token: 0x04000973 RID: 2419
        <AccessedThroughProperty("nudModelVariation")> _
        Private _nudModelVariation As NumericUpDown

        ' Token: 0x04000974 RID: 2420
        <AccessedThroughProperty("nudStackSize")> _
        Private _nudStackSize As NumericUpDown

        ' Token: 0x04000975 RID: 2421 _
        <AccessedThroughProperty("cmbxBaseItem")> _
        Private _cmbxBaseItem As ComboBox

        ' Token: 0x04000976 RID: 2422
        <AccessedThroughProperty("dgProperties")> _
        Private _dgProperties As DataGrid

        ' Token: 0x04000977 RID: 2423
        <AccessedThroughProperty("chkbIdentified")> _
        Private _chkbIdentified As CheckBox

        ' Token: 0x04000978 RID: 2424
        <AccessedThroughProperty("nudPaletteID")> _
        Private _nudPaletteID As NumericUpDown

        ' Token: 0x04000979 RID: 2425
        <AccessedThroughProperty("nudTextureVariation")> _
        Private _nudTextureVariation As NumericUpDown

        ' Token: 0x0400097A RID: 2426
        <AccessedThroughProperty("nudCharges")> _
        Private _nudCharges As NumericUpDown

        ' Token: 0x0400097B RID: 2427
        <AccessedThroughProperty("lblBodyVariation")> _
        Private _lblBodyVariation As Label

        ' Token: 0x0400097C RID: 2428
        <AccessedThroughProperty("nudBodyVariation")> _
        Private _nudBodyVariation As NumericUpDown

        ' Token: 0x0400097D RID: 2429
        <AccessedThroughProperty("btnLoadXML")> _
        Private _btnLoadXML As Button

        ' Token: 0x0400097E RID: 2430
        <AccessedThroughProperty("btnSaveXML")> _
        Private _btnSaveXML As Button

        ' Token: 0x0400097F RID: 2431
        <AccessedThroughProperty("btnSetUnidentDescLang")> _
        Private _btnSetUnidentDescLang As Button

        ' Token: 0x04000980 RID: 2432
        <AccessedThroughProperty("btnSetIdentDescLang")> _
        Private _btnSetIdentDescLang As Button

        ' Token: 0x04000981 RID: 2433
        <AccessedThroughProperty("lblUpgradeLevel")> _
        Private _lblUpgradeLevel As Label

        ' Token: 0x04000982 RID: 2434
        <AccessedThroughProperty("nudUpgradeLevel")> _
        Private _nudUpgradeLevel As NumericUpDown

        ' Token: 0x04000983 RID: 2435
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000984 RID: 2436
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000985 RID: 2437
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As Button

        ' Token: 0x04000986 RID: 2438
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x04000987 RID: 2439
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

        ' Token: 0x04000988 RID: 2440
        <AccessedThroughProperty("lblTextureVariation")> _
        Private _lblTextureVariation As Label

        ' Token: 0x04000989 RID: 2441
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x0400098A RID: 2442
        <AccessedThroughProperty("chkbPlotItem")> _
        Private _chkbPlotItem As CheckBox

        ' Token: 0x0400098B RID: 2443
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x0400098C RID: 2444
        <AccessedThroughProperty("tbComment")> _
        Private _tbComment As TextBox

        ' Token: 0x0400098D RID: 2445
        <AccessedThroughProperty("tabpagGeneral")> _
        Private _tabpagGeneral As TabPage

        ' Token: 0x0400098E RID: 2446
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x0400098F RID: 2447
        <AccessedThroughProperty("Label33")> _
        Private _Label33 As Label

        ' Token: 0x04000990 RID: 2448
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000992 RID: 2450
        Public UTI As clsUTI

        ' Token: 0x04000993 RID: 2451
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x04000994 RID: 2452
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x04000995 RID: 2453
        Private dt As DataTable

        ' Token: 0x04000996 RID: 2454
        Private DView As DataView

        ' Token: 0x04000997 RID: 2455
        Public UnidentDescLang As Integer

        ' Token: 0x04000998 RID: 2456
        Public IdentDescLang As Integer

        ' Token: 0x04000999 RID: 2457
        Private htOverrideFiles As Hashtable

        ' Token: 0x0400099A RID: 2458
        Private m_bSaveGameMode As Boolean

        ' Token: 0x0400099B RID: 2459
        Private itempropdef As cls2DA

        ' Token: 0x0400099C RID: 2460
        Private iprp_costtable As cls2DA

        ' Token: 0x0400099D RID: 2461
        Private iprp_paramtable As cls2DA

        ' Token: 0x0400099E RID: 2462
        Private iprp_abilities As cls2DA

        ' Token: 0x0400099F RID: 2463
        Private appearance As cls2DA

        ' Token: 0x040009A0 RID: 2464
        Private classes As cls2DA

        ' Token: 0x040009A1 RID: 2465
        Private feat As cls2DA

        ' Token: 0x040009A2 RID: 2466
        Private iprp_acmodtype As cls2DA

        ' Token: 0x040009A3 RID: 2467
        Private iprp_aligngrp As cls2DA

        ' Token: 0x040009A4 RID: 2468
        Private iprp_ammotype As cls2DA

        ' Token: 0x040009A5 RID: 2469
        Private iprp_combatdam As cls2DA

        ' Token: 0x040009A6 RID: 2470
        Private iprp_damagetype As cls2DA

        ' Token: 0x040009A7 RID: 2471
        Private iprp_immunity As cls2DA

        ' Token: 0x040009A8 RID: 2472
        Private iprp_monsterhit As cls2DA

        ' Token: 0x040009A9 RID: 2473
        Private iprp_onhit As cls2DA

        ' Token: 0x040009AA RID: 2474
        Private iprp_protection As cls2DA

        ' Token: 0x040009AB RID: 2475
        Private iprp_saveelement As cls2DA

        ' Token: 0x040009AC RID: 2476
        Private iprp_savingthrow As cls2DA

        ' Token: 0x040009AD RID: 2477
        Private iprp_walk As cls2DA

        ' Token: 0x040009AE RID: 2478
        Private racialtypes As cls2DA

        ' Token: 0x040009AF RID: 2479
        Private skills As cls2DA

        ' Token: 0x040009B0 RID: 2480
        Private spells As cls2DA

        ' Token: 0x040009B1 RID: 2481
        Private traps As cls2DA

        ' Token: 0x040009B2 RID: 2482
        Private iprp_pc As cls2DA
    End Class
End Namespace
