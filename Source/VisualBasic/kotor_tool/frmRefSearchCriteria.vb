Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000070 RID: 112
	Public Partial Class frmRefSearchCriteria
		Inherits frmParent

		' Token: 0x06000E4D RID: 3661 RVA: 0x0028D878 File Offset: 0x0028C878
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004FB RID: 1275
		' (get) Token: 0x06000E4F RID: 3663 RVA: 0x0028D8FC File Offset: 0x0028C8FC
		' (set) Token: 0x06000E50 RID: 3664 RVA: 0x0028D8A8 File Offset: 0x0028C8A8
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

        ' Token: 0x170004FC RID: 1276
        ' (get) Token: 0x06000E51 RID: 3665 RVA: 0x0028D910 File Offset: 0x0028C910
        ' (set) Token: 0x06000E52 RID: 3666 RVA: 0x0028D924 File Offset: 0x0028C924
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

        ' Token: 0x170004FD RID: 1277
        ' (get) Token: 0x06000E54 RID: 3668 RVA: 0x0028D940 File Offset: 0x0028C940
        ' (set) Token: 0x06000E53 RID: 3667 RVA: 0x0028D954 File Offset: 0x0028C954
        Friend Overridable Property tbSearchString() As TextBox
            Get
                Return Me._tbSearchString
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbSearchString IsNot Nothing Then
                    RemoveHandler Me._tbSearchString.TextChanged, AddressOf Me.tbSearchString_TextChanged
                End If
                Me._tbSearchString = value
                If Me._tbSearchString IsNot Nothing Then
                    AddHandler Me._tbSearchString.TextChanged, AddressOf Me.tbSearchString_TextChanged
                End If
            End Set
        End Property

        ' Token: 0x170004FE RID: 1278
        ' (get) Token: 0x06000E55 RID: 3669 RVA: 0x0028D9C4 File Offset: 0x0028C9C4
        ' (set) Token: 0x06000E56 RID: 3670 RVA: 0x0028D9A8 File Offset: 0x0028C9A8
        Friend Overridable Property CheckBox1() As CheckBox
            Get
                Return Me._CheckBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox1 IsNot Nothing Then
                End If
                Me._CheckBox1 = value
                If Me._CheckBox1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004FF RID: 1279
        ' (get) Token: 0x06000E58 RID: 3672 RVA: 0x0028D9D8 File Offset: 0x0028C9D8
        ' (set) Token: 0x06000E57 RID: 3671 RVA: 0x0028D9EC File Offset: 0x0028C9EC
        Friend Overridable Property CheckBox2() As CheckBox
            Get
                Return Me._CheckBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox2 IsNot Nothing Then
                End If
                Me._CheckBox2 = value
                If Me._CheckBox2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000500 RID: 1280
        ' (get) Token: 0x06000E59 RID: 3673 RVA: 0x0028DA24 File Offset: 0x0028CA24
        ' (set) Token: 0x06000E5A RID: 3674 RVA: 0x0028DA08 File Offset: 0x0028CA08
        Friend Overridable Property CheckBox3() As CheckBox
            Get
                Return Me._CheckBox3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox3 IsNot Nothing Then
                End If
                Me._CheckBox3 = value
                If Me._CheckBox3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000501 RID: 1281
        ' (get) Token: 0x06000E5C RID: 3676 RVA: 0x0028DA54 File Offset: 0x0028CA54
        ' (set) Token: 0x06000E5B RID: 3675 RVA: 0x0028DA38 File Offset: 0x0028CA38
        Friend Overridable Property CheckBox4() As CheckBox
            Get
                Return Me._CheckBox4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox4 IsNot Nothing Then
                End If
                Me._CheckBox4 = value
                If Me._CheckBox4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000502 RID: 1282
        ' (get) Token: 0x06000E5D RID: 3677 RVA: 0x0028DA84 File Offset: 0x0028CA84
        ' (set) Token: 0x06000E5E RID: 3678 RVA: 0x0028DA68 File Offset: 0x0028CA68
        Friend Overridable Property CheckBox5() As CheckBox
            Get
                Return Me._CheckBox5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox5 IsNot Nothing Then
                End If
                Me._CheckBox5 = value
                If Me._CheckBox5 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000503 RID: 1283
        ' (get) Token: 0x06000E60 RID: 3680 RVA: 0x0028DA98 File Offset: 0x0028CA98
        ' (set) Token: 0x06000E5F RID: 3679 RVA: 0x0028DAAC File Offset: 0x0028CAAC
        Friend Overridable Property CheckBox6() As CheckBox
            Get
                Return Me._CheckBox6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox6 IsNot Nothing Then
                End If
                Me._CheckBox6 = value
                If Me._CheckBox6 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000504 RID: 1284
        ' (get) Token: 0x06000E62 RID: 3682 RVA: 0x0028DAE4 File Offset: 0x0028CAE4
        ' (set) Token: 0x06000E61 RID: 3681 RVA: 0x0028DAC8 File Offset: 0x0028CAC8
        Friend Overridable Property CheckBox7() As CheckBox
            Get
                Return Me._CheckBox7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox7 IsNot Nothing Then
                End If
                Me._CheckBox7 = value
                If Me._CheckBox7 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000505 RID: 1285
        ' (get) Token: 0x06000E64 RID: 3684 RVA: 0x0028DB14 File Offset: 0x0028CB14
        ' (set) Token: 0x06000E63 RID: 3683 RVA: 0x0028DAF8 File Offset: 0x0028CAF8
        Friend Overridable Property CheckBox8() As CheckBox
            Get
                Return Me._CheckBox8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox8 IsNot Nothing Then
                End If
                Me._CheckBox8 = value
                If Me._CheckBox8 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000506 RID: 1286
        ' (get) Token: 0x06000E66 RID: 3686 RVA: 0x0028DB44 File Offset: 0x0028CB44
        ' (set) Token: 0x06000E65 RID: 3685 RVA: 0x0028DB28 File Offset: 0x0028CB28
        Friend Overridable Property CheckBox11() As CheckBox
            Get
                Return Me._CheckBox11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox11 IsNot Nothing Then
                End If
                Me._CheckBox11 = value
                If Me._CheckBox11 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000507 RID: 1287
        ' (get) Token: 0x06000E67 RID: 3687 RVA: 0x0028DB58 File Offset: 0x0028CB58
        ' (set) Token: 0x06000E68 RID: 3688 RVA: 0x0028DB6C File Offset: 0x0028CB6C
        Friend Overridable Property CheckBox12() As CheckBox
            Get
                Return Me._CheckBox12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox12 IsNot Nothing Then
                End If
                Me._CheckBox12 = value
                If Me._CheckBox12 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000508 RID: 1288
        ' (get) Token: 0x06000E6A RID: 3690 RVA: 0x0028DB88 File Offset: 0x0028CB88
        ' (set) Token: 0x06000E69 RID: 3689 RVA: 0x0028DB9C File Offset: 0x0028CB9C
        Friend Overridable Property CheckBox13() As CheckBox
            Get
                Return Me._CheckBox13
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox13 IsNot Nothing Then
                End If
                Me._CheckBox13 = value
                If Me._CheckBox13 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000509 RID: 1289
        ' (get) Token: 0x06000E6B RID: 3691 RVA: 0x0028DBB8 File Offset: 0x0028CBB8
        ' (set) Token: 0x06000E6C RID: 3692 RVA: 0x0028DBCC File Offset: 0x0028CBCC
        Friend Overridable Property CheckBox16() As CheckBox
            Get
                Return Me._CheckBox16
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox16 IsNot Nothing Then
                End If
                Me._CheckBox16 = value
                If Me._CheckBox16 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700050A RID: 1290
        ' (get) Token: 0x06000E6D RID: 3693 RVA: 0x0028DC04 File Offset: 0x0028CC04
        ' (set) Token: 0x06000E6E RID: 3694 RVA: 0x0028DBE8 File Offset: 0x0028CBE8
        Friend Overridable Property CheckBox18() As CheckBox
            Get
                Return Me._CheckBox18
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox18 IsNot Nothing Then
                End If
                Me._CheckBox18 = value
                If Me._CheckBox18 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700050B RID: 1291
        ' (get) Token: 0x06000E6F RID: 3695 RVA: 0x0028DC6C File Offset: 0x0028CC6C
        ' (set) Token: 0x06000E70 RID: 3696 RVA: 0x0028DC18 File Offset: 0x0028CC18
        Friend Overridable Property btnSetAll() As Button
            Get
                Return Me._btnSetAll
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetAll IsNot Nothing Then
                    RemoveHandler Me._btnSetAll.Click, AddressOf Me.btnSetAll_Click
                End If
                Me._btnSetAll = value
                If Me._btnSetAll IsNot Nothing Then
                    AddHandler Me._btnSetAll.Click, AddressOf Me.btnSetAll_Click
                End If
            End Set
        End Property

        ' Token: 0x1700050C RID: 1292
        ' (get) Token: 0x06000E72 RID: 3698 RVA: 0x0028DCD4 File Offset: 0x0028CCD4
        ' (set) Token: 0x06000E71 RID: 3697 RVA: 0x0028DC80 File Offset: 0x0028CC80
        Friend Overridable Property btnClearAll() As Button
            Get
                Return Me._btnClearAll
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnClearAll IsNot Nothing Then
                    RemoveHandler Me._btnClearAll.Click, AddressOf Me.btnClearAll_Click
                End If
                Me._btnClearAll = value
                If Me._btnClearAll IsNot Nothing Then
                    AddHandler Me._btnClearAll.Click, AddressOf Me.btnClearAll_Click
                End If
            End Set
        End Property

        ' Token: 0x1700050D RID: 1293
        ' (get) Token: 0x06000E73 RID: 3699 RVA: 0x0028DD04 File Offset: 0x0028CD04
        ' (set) Token: 0x06000E74 RID: 3700 RVA: 0x0028DCE8 File Offset: 0x0028CCE8
        Friend Overridable Property rbtnSensitive() As RadioButton
            Get
                Return Me._rbtnSensitive
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbtnSensitive IsNot Nothing Then
                End If
                Me._rbtnSensitive = value
                If Me._rbtnSensitive IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700050E RID: 1294
        ' (get) Token: 0x06000E76 RID: 3702 RVA: 0x0028DD18 File Offset: 0x0028CD18
        ' (set) Token: 0x06000E75 RID: 3701 RVA: 0x0028DD2C File Offset: 0x0028CD2C
        Friend Overridable Property rbtnInsensitive() As RadioButton
            Get
                Return Me._rbtnInsensitive
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbtnInsensitive IsNot Nothing Then
                End If
                Me._rbtnInsensitive = value
                If Me._rbtnInsensitive IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700050F RID: 1295
        ' (get) Token: 0x06000E77 RID: 3703 RVA: 0x0028DD48 File Offset: 0x0028CD48
        ' (set) Token: 0x06000E78 RID: 3704 RVA: 0x0028DD5C File Offset: 0x0028CD5C
        Friend Overridable Property gboxFileTypes() As GroupBox
            Get
                Return Me._gboxFileTypes
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gboxFileTypes IsNot Nothing Then
                End If
                Me._gboxFileTypes = value
                If Me._gboxFileTypes IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000510 RID: 1296
        ' (get) Token: 0x06000E7A RID: 3706 RVA: 0x0028DD78 File Offset: 0x0028CD78
        ' (set) Token: 0x06000E79 RID: 3705 RVA: 0x0028DD8C File Offset: 0x0028CD8C
        Friend Overridable Property gboxArchiveTypes() As GroupBox
            Get
                Return Me._gboxArchiveTypes
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gboxArchiveTypes IsNot Nothing Then
                End If
                Me._gboxArchiveTypes = value
                If Me._gboxArchiveTypes IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000511 RID: 1297
        ' (get) Token: 0x06000E7B RID: 3707 RVA: 0x0028DDFC File Offset: 0x0028CDFC
        ' (set) Token: 0x06000E7C RID: 3708 RVA: 0x0028DDA8 File Offset: 0x0028CDA8
        Friend Overridable Property chkbScripts() As CheckBox
            Get
                Return Me._chkbScripts
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbScripts IsNot Nothing Then
                    RemoveHandler Me._chkbScripts.CheckedChanged, AddressOf Me.chkbScripts_CheckedChanged
                End If
                Me._chkbScripts = value
                If Me._chkbScripts IsNot Nothing Then
                    AddHandler Me._chkbScripts.CheckedChanged, AddressOf Me.chkbScripts_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000512 RID: 1298
        ' (get) Token: 0x06000E7D RID: 3709 RVA: 0x0028DE64 File Offset: 0x0028CE64
        ' (set) Token: 0x06000E7E RID: 3710 RVA: 0x0028DE10 File Offset: 0x0028CE10
        Friend Overridable Property chkbTemplates() As CheckBox
            Get
                Return Me._chkbTemplates
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbTemplates IsNot Nothing Then
                    RemoveHandler Me._chkbTemplates.CheckedChanged, AddressOf Me.chkbTemplates_CheckedChanged
                End If
                Me._chkbTemplates = value
                If Me._chkbTemplates IsNot Nothing Then
                    AddHandler Me._chkbTemplates.CheckedChanged, AddressOf Me.chkbTemplates_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000513 RID: 1299
        ' (get) Token: 0x06000E7F RID: 3711 RVA: 0x0028DE78 File Offset: 0x0028CE78
        ' (set) Token: 0x06000E80 RID: 3712 RVA: 0x0028DE8C File Offset: 0x0028CE8C
        Friend Overridable Property chkbRIMs() As CheckBox
            Get
                Return Me._chkbRIMs
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbRIMs IsNot Nothing Then
                    RemoveHandler Me._chkbRIMs.CheckedChanged, AddressOf Me.chkbRIMs_CheckedChanged
                End If
                Me._chkbRIMs = value
                If Me._chkbRIMs IsNot Nothing Then
                    AddHandler Me._chkbRIMs.CheckedChanged, AddressOf Me.chkbRIMs_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000514 RID: 1300
        ' (get) Token: 0x06000E81 RID: 3713 RVA: 0x0028DEFC File Offset: 0x0028CEFC
        ' (set) Token: 0x06000E82 RID: 3714 RVA: 0x0028DEE0 File Offset: 0x0028CEE0
        Friend Overridable Property gboxGFF() As GroupBox
            Get
                Return Me._gboxGFF
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gboxGFF IsNot Nothing Then
                End If
                Me._gboxGFF = value
                If Me._gboxGFF IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000515 RID: 1301
        ' (get) Token: 0x06000E83 RID: 3715 RVA: 0x0028DF10 File Offset: 0x0028CF10
        ' (set) Token: 0x06000E84 RID: 3716 RVA: 0x0028DF24 File Offset: 0x0028CF24
        Friend Overridable Property CheckBox22() As CheckBox
            Get
                Return Me._CheckBox22
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox22 IsNot Nothing Then
                End If
                Me._CheckBox22 = value
                If Me._CheckBox22 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000516 RID: 1302
        ' (get) Token: 0x06000E86 RID: 3718 RVA: 0x0028DF5C File Offset: 0x0028CF5C
        ' (set) Token: 0x06000E85 RID: 3717 RVA: 0x0028DF40 File Offset: 0x0028CF40
        Friend Overridable Property CheckBox23() As CheckBox
            Get
                Return Me._CheckBox23
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._CheckBox23 IsNot Nothing Then
                End If
                Me._CheckBox23 = value
                If Me._CheckBox23 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000517 RID: 1303
        ' (get) Token: 0x06000E88 RID: 3720 RVA: 0x0028DF70 File Offset: 0x0028CF70
        ' (set) Token: 0x06000E87 RID: 3719 RVA: 0x0028DF84 File Offset: 0x0028CF84
        Friend Overridable Property gboxScript() As GroupBox
            Get
                Return Me._gboxScript
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gboxScript IsNot Nothing Then
                End If
                Me._gboxScript = value
                If Me._gboxScript IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000518 RID: 1304
        ' (get) Token: 0x06000E89 RID: 3721 RVA: 0x0028DFA0 File Offset: 0x0028CFA0
        ' (set) Token: 0x06000E8A RID: 3722 RVA: 0x0028DFB4 File Offset: 0x0028CFB4
        Friend Overridable Property chkbAllBifs() As CheckBox
            Get
                Return Me._chkbAllBifs
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbAllBifs IsNot Nothing Then
                    RemoveHandler Me._chkbAllBifs.CheckedChanged, AddressOf Me.chkbAllBifs_CheckedChanged
                End If
                Me._chkbAllBifs = value
                If Me._chkbAllBifs IsNot Nothing Then
                    AddHandler Me._chkbAllBifs.CheckedChanged, AddressOf Me.chkbAllBifs_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000519 RID: 1305
        ' (get) Token: 0x06000E8C RID: 3724 RVA: 0x0028E008 File Offset: 0x0028D008
        ' (set) Token: 0x06000E8B RID: 3723 RVA: 0x0028E01C File Offset: 0x0028D01C
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

        ' Token: 0x1700051A RID: 1306
        ' (get) Token: 0x06000E8E RID: 3726 RVA: 0x0028E038 File Offset: 0x0028D038
        ' (set) Token: 0x06000E8D RID: 3725 RVA: 0x0028E04C File Offset: 0x0028D04C
        Friend Overridable Property rbSearchKotor1() As RadioButton
            Get
                Return Me._rbSearchKotor1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbSearchKotor1 IsNot Nothing Then
                    RemoveHandler Me._rbSearchKotor1.CheckedChanged, AddressOf Me.rbSearch_CheckedChanged
                End If
                Me._rbSearchKotor1 = value
                If Me._rbSearchKotor1 IsNot Nothing Then
                    AddHandler Me._rbSearchKotor1.CheckedChanged, AddressOf Me.rbSearch_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x1700051B RID: 1307
        ' (get) Token: 0x06000E8F RID: 3727 RVA: 0x0028E0A0 File Offset: 0x0028D0A0
        ' (set) Token: 0x06000E90 RID: 3728 RVA: 0x0028E0B4 File Offset: 0x0028D0B4
        Friend Overridable Property rbSearchKotor2() As RadioButton
            Get
                Return Me._rbSearchKotor2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbSearchKotor2 IsNot Nothing Then
                    RemoveHandler Me._rbSearchKotor2.CheckedChanged, AddressOf Me.rbSearch_CheckedChanged
                End If
                Me._rbSearchKotor2 = value
                If Me._rbSearchKotor2 IsNot Nothing Then
                    AddHandler Me._rbSearchKotor2.CheckedChanged, AddressOf Me.rbSearch_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x1700051C RID: 1308
        ' (get) Token: 0x06000E91 RID: 3729 RVA: 0x0028E124 File Offset: 0x0028D124
        ' (set) Token: 0x06000E92 RID: 3730 RVA: 0x0028E108 File Offset: 0x0028D108
        Friend Overridable Property gboxCaseSens() As GroupBox
            Get
                Return Me._gboxCaseSens
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gboxCaseSens IsNot Nothing Then
                End If
                Me._gboxCaseSens = value
                If Me._gboxCaseSens IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700051D RID: 1309
        ' (get) Token: 0x06000E93 RID: 3731 RVA: 0x0028E154 File Offset: 0x0028D154
        ' (set) Token: 0x06000E94 RID: 3732 RVA: 0x0028E138 File Offset: 0x0028D138
        Friend Overridable Property gboxSearchString() As GroupBox
            Get
                Return Me._gboxSearchString
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gboxSearchString IsNot Nothing Then
                End If
                Me._gboxSearchString = value
                If Me._gboxSearchString IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x06000E96 RID: 3734 RVA: 0x0028F5DC File Offset: 0x0028E5DC
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.htFileTypes = New Hashtable()
            If StringType.StrCmp(Me.tbSearchString.Text, "", False) = 0 Then
                Interaction.MsgBox("Please enter a search string", MsgBoxStyle.Critical, Nothing)
                Return
            End If
            Try
                For Each obj As Object In Me.gboxGFF.Controls
                    Dim control As Control = CType(obj, Control)
                    If ((StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0) And control.Parent.Enabled) AndAlso CType(control, CheckBox).Checked Then
                        Me.htFileTypes.Add(control.Text, "")
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.gboxScript.Controls
                    Dim control2 As Control = CType(obj2, Control)
                    If ((StringType.StrCmp(control2.[GetType]().Name, "CheckBox", False) = 0) And control2.Parent.Enabled) AndAlso CType(control2, CheckBox).Checked Then
                        Me.htFileTypes.Add(control2.Text, "")
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            If Me.htFileTypes.Count = 0 Then
                Interaction.MsgBox("Select at least one file type to search for the string in", MsgBoxStyle.Critical, Nothing)
            Else
                Me.DialogResult = DialogResult.OK
            End If
        End Sub

        ' Token: 0x06000E97 RID: 3735 RVA: 0x0028F76C File Offset: 0x0028E76C
        Private Sub btnSetAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                For Each obj As Object In Me.gboxGFF.Controls
                    Dim control As Control = CType(obj, Control)
                    If StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0 Then
                        CType(control, CheckBox).Checked = True
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.gboxScript.Controls
                    Dim control2 As Control = CType(obj2, Control)
                    If StringType.StrCmp(control2.[GetType]().Name, "CheckBox", False) = 0 Then
                        CType(control2, CheckBox).Checked = True
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000E98 RID: 3736 RVA: 0x0028F85C File Offset: 0x0028E85C
        Private Sub btnClearAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                For Each obj As Object In Me.gboxGFF.Controls
                    Dim control As Control = CType(obj, Control)
                    If StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0 Then
                        CType(control, CheckBox).Checked = False
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.gboxScript.Controls
                    Dim control2 As Control = CType(obj2, Control)
                    If StringType.StrCmp(control2.[GetType]().Name, "CheckBox", False) = 0 Then
                        CType(control2, CheckBox).Checked = False
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000E99 RID: 3737 RVA: 0x0028F94C File Offset: 0x0028E94C
        Private Sub chkbTemplates_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.gboxGFF.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbAllBifs.Checked
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9A RID: 3738 RVA: 0x0028F9C4 File Offset: 0x0028E9C4
        Private Sub chkbRIMs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.gboxGFF.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbAllBifs.Checked
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9B RID: 3739 RVA: 0x0028FA3C File Offset: 0x0028EA3C
        Private Sub chkbScripts_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9C RID: 3740 RVA: 0x0028FA78 File Offset: 0x0028EA78
        Private Sub chkbAllBifs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.chkbAllBifs.Checked Then
                Me.chkbScripts.Checked = Me.chkbAllBifs.Checked
                Me.chkbTemplates.Checked = Me.chkbScripts.Checked
            End If
            Me.gboxGFF.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbAllBifs.Checked
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9D RID: 3741 RVA: 0x0028FB28 File Offset: 0x0028EB28
        Private Sub SetFileTypeGBsState()
            Me.chkbScripts.Checked = Me.chkbAllBifs.Checked
            Me.chkbTemplates.Checked = Me.chkbScripts.Checked
            Me.gboxGFF.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbAllBifs.Checked
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9E RID: 3742 RVA: 0x0028FBCC File Offset: 0x0028EBCC
        Private Sub rbSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.rbSearchKotor1.Checked Or Me.rbSearchKotor2.Checked Then
                Me.gboxCaseSens.Enabled = True
                Me.gboxSearchString.Enabled = True
            End If
        End Sub

        ' Token: 0x06000E9F RID: 3743 RVA: 0x0028FC00 File Offset: 0x0028EC00
        Private Sub tbSearchString_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim flag As Boolean = Me.tbSearchString.Text.Length > 0
            Me.gboxFileTypes.Enabled = flag
            Me.gboxArchiveTypes.Enabled = flag
            Me.btnOK.Enabled = flag
        End Sub

        ' Token: 0x040006F8 RID: 1784
        <AccessedThroughProperty("gboxCaseSens")> _
        Private _gboxCaseSens As GroupBox

        ' Token: 0x040006F9 RID: 1785
        <AccessedThroughProperty("rbSearchKotor2")> _
        Private _rbSearchKotor2 As RadioButton

        ' Token: 0x040006FA RID: 1786
        <AccessedThroughProperty("GroupBox2")> _
        Private _GroupBox2 As GroupBox

        ' Token: 0x040006FB RID: 1787
        <AccessedThroughProperty("rbSearchKotor1")> _
        Private _rbSearchKotor1 As RadioButton

        ' Token: 0x040006FC RID: 1788
        <AccessedThroughProperty("tbSearchString")> _
        Private _tbSearchString As TextBox

        ' Token: 0x040006FD RID: 1789
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040006FE RID: 1790
        <AccessedThroughProperty("chkbAllBifs")> _
        Private _chkbAllBifs As CheckBox

        ' Token: 0x040006FF RID: 1791
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x04000700 RID: 1792
        <AccessedThroughProperty("CheckBox1")> _
        Private _CheckBox1 As CheckBox

        ' Token: 0x04000701 RID: 1793
        <AccessedThroughProperty("gboxScript")> _
        Private _gboxScript As GroupBox

        ' Token: 0x04000702 RID: 1794
        <AccessedThroughProperty("CheckBox23")> _
        Private _CheckBox23 As CheckBox

        ' Token: 0x04000703 RID: 1795
        <AccessedThroughProperty("CheckBox22")> _
        Private _CheckBox22 As CheckBox

        ' Token: 0x04000704 RID: 1796
        <AccessedThroughProperty("gboxGFF")> _
        Private _gboxGFF As GroupBox

        ' Token: 0x04000705 RID: 1797
        <AccessedThroughProperty("chkbRIMs")> _
        Private _chkbRIMs As CheckBox

        ' Token: 0x04000706 RID: 1798
        <AccessedThroughProperty("chkbTemplates")> _
        Private _chkbTemplates As CheckBox

        ' Token: 0x04000707 RID: 1799
        <AccessedThroughProperty("gboxSearchString")> _
        Private _gboxSearchString As GroupBox

        ' Token: 0x04000708 RID: 1800
        <AccessedThroughProperty("chkbScripts")> _
        Private _chkbScripts As CheckBox

        ' Token: 0x04000709 RID: 1801
        <AccessedThroughProperty("gboxArchiveTypes")> _
        Private _gboxArchiveTypes As GroupBox

        ' Token: 0x0400070A RID: 1802
        <AccessedThroughProperty("gboxFileTypes")> _
        Private _gboxFileTypes As GroupBox

        ' Token: 0x0400070B RID: 1803
        <AccessedThroughProperty("rbtnInsensitive")> _
        Private _rbtnInsensitive As RadioButton

        ' Token: 0x0400070C RID: 1804
        <AccessedThroughProperty("rbtnSensitive")> _
        Private _rbtnSensitive As RadioButton

        ' Token: 0x0400070D RID: 1805
        <AccessedThroughProperty("btnClearAll")> _
        Private _btnClearAll As Button

        ' Token: 0x0400070E RID: 1806
        <AccessedThroughProperty("btnSetAll")> _
        Private _btnSetAll As Button

        ' Token: 0x0400070F RID: 1807
        <AccessedThroughProperty("CheckBox2")> _
        Private _CheckBox2 As CheckBox

        ' Token: 0x04000710 RID: 1808
        <AccessedThroughProperty("CheckBox3")> _
        Private _CheckBox3 As CheckBox

        ' Token: 0x04000711 RID: 1809
        <AccessedThroughProperty("CheckBox4")> _
        Private _CheckBox4 As CheckBox

        ' Token: 0x04000712 RID: 1810
        <AccessedThroughProperty("CheckBox5")> _
        Private _CheckBox5 As CheckBox

        ' Token: 0x04000713 RID: 1811
        <AccessedThroughProperty("CheckBox18")> _
        Private _CheckBox18 As CheckBox

        ' Token: 0x04000714 RID: 1812
        <AccessedThroughProperty("CheckBox6")> _
        Private _CheckBox6 As CheckBox

        ' Token: 0x04000715 RID: 1813
        <AccessedThroughProperty("CheckBox7")> _
        Private _CheckBox7 As CheckBox

        ' Token: 0x04000716 RID: 1814
        <AccessedThroughProperty("CheckBox8")> _
        Private _CheckBox8 As CheckBox

        ' Token: 0x04000717 RID: 1815
        <AccessedThroughProperty("CheckBox11")> _
        Private _CheckBox11 As CheckBox

        ' Token: 0x04000718 RID: 1816
        <AccessedThroughProperty("CheckBox12")> _
        Private _CheckBox12 As CheckBox

        ' Token: 0x04000719 RID: 1817
        <AccessedThroughProperty("CheckBox13")> _
        Private _CheckBox13 As CheckBox

        ' Token: 0x0400071A RID: 1818
        <AccessedThroughProperty("CheckBox16")> _
        Private _CheckBox16 As CheckBox

        ' Token: 0x0400071B RID: 1819
        Public htFileTypes As Hashtable
    End Class
End Namespace
