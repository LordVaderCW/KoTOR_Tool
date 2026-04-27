Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200003F RID: 63
	Public Partial Class frmAppearanceWizard
		Inherits frmParent

		' Token: 0x060001D5 RID: 469 RVA: 0x00228F04 File Offset: 0x00227F04
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmAppearanceWizard_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060001D8 RID: 472 RVA: 0x00228F48 File Offset: 0x00227F48
		' (set) Token: 0x060001D7 RID: 471 RVA: 0x00228F5C File Offset: 0x00227F5C
		Friend Overridable Property Label1 As Label
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

        ' Token: 0x17000051 RID: 81
        ' (get) Token: 0x060001DA RID: 474 RVA: 0x00228F78 File Offset: 0x00227F78
        ' (set) Token: 0x060001D9 RID: 473 RVA: 0x00228F8C File Offset: 0x00227F8C
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

        ' Token: 0x17000052 RID: 82
        ' (get) Token: 0x060001DB RID: 475 RVA: 0x00228FA8 File Offset: 0x00227FA8
        ' (set) Token: 0x060001DC RID: 476 RVA: 0x00228FBC File Offset: 0x00227FBC
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

        ' Token: 0x17000053 RID: 83
        ' (get) Token: 0x060001DE RID: 478 RVA: 0x00228FD8 File Offset: 0x00227FD8
        ' (set) Token: 0x060001DD RID: 477 RVA: 0x00228FEC File Offset: 0x00227FEC
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

        ' Token: 0x17000054 RID: 84
        ' (get) Token: 0x060001DF RID: 479 RVA: 0x00229008 File Offset: 0x00228008
        ' (set) Token: 0x060001E0 RID: 480 RVA: 0x0022901C File Offset: 0x0022801C
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

        ' Token: 0x17000055 RID: 85
        ' (get) Token: 0x060001E1 RID: 481 RVA: 0x00229054 File Offset: 0x00228054
        ' (set) Token: 0x060001E2 RID: 482 RVA: 0x00229038 File Offset: 0x00228038
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

        ' Token: 0x17000056 RID: 86
        ' (get) Token: 0x060001E3 RID: 483 RVA: 0x00229068 File Offset: 0x00228068
        ' (set) Token: 0x060001E4 RID: 484 RVA: 0x0022907C File Offset: 0x0022807C
        Friend Overridable Property Label7() As Label
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

        ' Token: 0x17000057 RID: 87
        ' (get) Token: 0x060001E5 RID: 485 RVA: 0x00229098 File Offset: 0x00228098
        ' (set) Token: 0x060001E6 RID: 486 RVA: 0x002290AC File Offset: 0x002280AC
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

        ' Token: 0x17000058 RID: 88
        ' (get) Token: 0x060001E7 RID: 487 RVA: 0x002290E4 File Offset: 0x002280E4
        ' (set) Token: 0x060001E8 RID: 488 RVA: 0x002290C8 File Offset: 0x002280C8
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

        ' Token: 0x17000059 RID: 89
        ' (get) Token: 0x060001E9 RID: 489 RVA: 0x00229114 File Offset: 0x00228114
        ' (set) Token: 0x060001EA RID: 490 RVA: 0x002290F8 File Offset: 0x002280F8
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

        ' Token: 0x1700005A RID: 90
        ' (get) Token: 0x060001EB RID: 491 RVA: 0x00229128 File Offset: 0x00228128
        ' (set) Token: 0x060001EC RID: 492 RVA: 0x0022913C File Offset: 0x0022813C
        Friend Overridable Property tbName() As TextBox
            Get
                Return Me._tbName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbName IsNot Nothing Then
                End If
                Me._tbName = value
                If Me._tbName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700005B RID: 91
        ' (get) Token: 0x060001EE RID: 494 RVA: 0x00229158 File Offset: 0x00228158
        ' (set) Token: 0x060001ED RID: 493 RVA: 0x0022916C File Offset: 0x0022816C
        Friend Overridable Property cmbxGender() As ComboBox
            Get
                Return Me._cmbxGender
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxGender IsNot Nothing Then
                End If
                Me._cmbxGender = value
                If Me._cmbxGender IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700005C RID: 92
        ' (get) Token: 0x060001F0 RID: 496 RVA: 0x00229188 File Offset: 0x00228188
        ' (set) Token: 0x060001EF RID: 495 RVA: 0x0022919C File Offset: 0x0022819C
        Friend Overridable Property cmbxSizes() As ComboBox
            Get
                Return Me._cmbxSizes
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxSizes IsNot Nothing Then
                End If
                Me._cmbxSizes = value
                If Me._cmbxSizes IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700005D RID: 93
        ' (get) Token: 0x060001F2 RID: 498 RVA: 0x002291B8 File Offset: 0x002281B8
        ' (set) Token: 0x060001F1 RID: 497 RVA: 0x002291CC File Offset: 0x002281CC
        Friend Overridable Property cmbxEnvMap() As ComboBox
            Get
                Return Me._cmbxEnvMap
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxEnvMap IsNot Nothing Then
                End If
                Me._cmbxEnvMap = value
                If Me._cmbxEnvMap IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700005E RID: 94
        ' (get) Token: 0x060001F3 RID: 499 RVA: 0x002291E8 File Offset: 0x002281E8
        ' (set) Token: 0x060001F4 RID: 500 RVA: 0x002291FC File Offset: 0x002281FC
        Friend Overridable Property cmbxMovementRate() As ComboBox
            Get
                Return Me._cmbxMovementRate
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxMovementRate IsNot Nothing Then
                End If
                Me._cmbxMovementRate = value
                If Me._cmbxMovementRate IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700005F RID: 95
        ' (get) Token: 0x060001F5 RID: 501 RVA: 0x00229218 File Offset: 0x00228218
        ' (set) Token: 0x060001F6 RID: 502 RVA: 0x0022922C File Offset: 0x0022822C
        Friend Overridable Property cmbxModelType() As ComboBox
            Get
                Return Me._cmbxModelType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxModelType IsNot Nothing Then
                End If
                Me._cmbxModelType = value
                If Me._cmbxModelType IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000060 RID: 96
        ' (get) Token: 0x060001F7 RID: 503 RVA: 0x00229248 File Offset: 0x00228248
        ' (set) Token: 0x060001F8 RID: 504 RVA: 0x0022925C File Offset: 0x0022825C
        Friend Overridable Property tbHitRadius() As TextBox
            Get
                Return Me._tbHitRadius
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbHitRadius IsNot Nothing Then
                End If
                Me._tbHitRadius = value
                If Me._tbHitRadius IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000061 RID: 97
        ' (get) Token: 0x060001F9 RID: 505 RVA: 0x00229278 File Offset: 0x00228278
        ' (set) Token: 0x060001FA RID: 506 RVA: 0x0022928C File Offset: 0x0022828C
        Friend Overridable Property tbPerspace() As TextBox
            Get
                Return Me._tbPerspace
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbPerspace IsNot Nothing Then
                End If
                Me._tbPerspace = value
                If Me._tbPerspace IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000062 RID: 98
        ' (get) Token: 0x060001FB RID: 507 RVA: 0x002292A8 File Offset: 0x002282A8
        ' (set) Token: 0x060001FC RID: 508 RVA: 0x002292BC File Offset: 0x002282BC
        Friend Overridable Property tbprefatkdist() As TextBox
            Get
                Return Me._tbprefatkdist
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbprefatkdist IsNot Nothing Then
                End If
                Me._tbprefatkdist = value
                If Me._tbprefatkdist IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000063 RID: 99
        ' (get) Token: 0x060001FD RID: 509 RVA: 0x002292D8 File Offset: 0x002282D8
        ' (set) Token: 0x060001FE RID: 510 RVA: 0x002292EC File Offset: 0x002282EC
        Friend Overridable Property tbCreperspace() As TextBox
            Get
                Return Me._tbCreperspace
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCreperspace IsNot Nothing Then
                End If
                Me._tbCreperspace = value
                If Me._tbCreperspace IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000064 RID: 100
        ' (get) Token: 0x060001FF RID: 511 RVA: 0x00229324 File Offset: 0x00228324
        ' (set) Token: 0x06000200 RID: 512 RVA: 0x00229308 File Offset: 0x00228308
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

        ' Token: 0x17000065 RID: 101
        ' (get) Token: 0x06000202 RID: 514 RVA: 0x00229354 File Offset: 0x00228354
        ' (set) Token: 0x06000201 RID: 513 RVA: 0x00229338 File Offset: 0x00228338
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

        ' Token: 0x17000066 RID: 102
        ' (get) Token: 0x06000203 RID: 515 RVA: 0x00229368 File Offset: 0x00228368
        ' (set) Token: 0x06000204 RID: 516 RVA: 0x0022937C File Offset: 0x0022837C
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

        ' Token: 0x17000067 RID: 103
        ' (get) Token: 0x06000205 RID: 517 RVA: 0x00229398 File Offset: 0x00228398
        ' (set) Token: 0x06000206 RID: 518 RVA: 0x002293AC File Offset: 0x002283AC
        Friend Overridable Property cmbxModelNaming() As ComboBox
            Get
                Return Me._cmbxModelNaming
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxModelNaming IsNot Nothing Then
                    RemoveHandler Me._cmbxModelNaming.SelectedIndexChanged, AddressOf Me.cmbxModelNaming_SelectedIndexChanged
                End If
                Me._cmbxModelNaming = value
                If Me._cmbxModelNaming IsNot Nothing Then
                    AddHandler Me._cmbxModelNaming.SelectedIndexChanged, AddressOf Me.cmbxModelNaming_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x17000068 RID: 104
        ' (get) Token: 0x06000207 RID: 519 RVA: 0x00229400 File Offset: 0x00228400
        ' (set) Token: 0x06000208 RID: 520 RVA: 0x00229414 File Offset: 0x00228414
        Friend Overridable Property tbBaseModelName() As TextBox
            Get
                Return Me._tbBaseModelName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbBaseModelName IsNot Nothing Then
                End If
                Me._tbBaseModelName = value
                If Me._tbBaseModelName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000069 RID: 105
        ' (get) Token: 0x06000209 RID: 521 RVA: 0x0022944C File Offset: 0x0022844C
        ' (set) Token: 0x0600020A RID: 522 RVA: 0x00229430 File Offset: 0x00228430
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

        ' Token: 0x1700006A RID: 106
        ' (get) Token: 0x0600020B RID: 523 RVA: 0x00229460 File Offset: 0x00228460
        ' (set) Token: 0x0600020C RID: 524 RVA: 0x00229474 File Offset: 0x00228474
        Friend Overridable Property tbHeadNum() As TextBox
            Get
                Return Me._tbHeadNum
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbHeadNum IsNot Nothing Then
                End If
                Me._tbHeadNum = value
                If Me._tbHeadNum IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700006B RID: 107
        ' (get) Token: 0x0600020D RID: 525 RVA: 0x00229490 File Offset: 0x00228490
        ' (set) Token: 0x0600020E RID: 526 RVA: 0x002294A4 File Offset: 0x002284A4
        Friend Overridable Property TabControl1() As TabControl
            Get
                Return Me._TabControl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._TabControl1 IsNot Nothing Then
                    RemoveHandler Me._TabControl1.SelectedIndexChanged, AddressOf Me.TabControl1_SelectedIndexChanged
                End If
                Me._TabControl1 = value
                If Me._TabControl1 IsNot Nothing Then
                    AddHandler Me._TabControl1.SelectedIndexChanged, AddressOf Me.TabControl1_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x1700006C RID: 108
        ' (get) Token: 0x0600020F RID: 527 RVA: 0x00229514 File Offset: 0x00228514
        ' (set) Token: 0x06000210 RID: 528 RVA: 0x002294F8 File Offset: 0x002284F8
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

        ' Token: 0x1700006D RID: 109
        ' (get) Token: 0x06000211 RID: 529 RVA: 0x00229528 File Offset: 0x00228528
        ' (set) Token: 0x06000212 RID: 530 RVA: 0x0022953C File Offset: 0x0022853C
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

        ' Token: 0x1700006E RID: 110
        ' (get) Token: 0x06000214 RID: 532 RVA: 0x00229558 File Offset: 0x00228558
        ' (set) Token: 0x06000213 RID: 531 RVA: 0x0022956C File Offset: 0x0022856C
        Friend Overridable Property Label13() As Label
            Get
                Return Me._Label13
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label13 IsNot Nothing Then
                End If
                Me._Label13 = value
                If Me._Label13 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700006F RID: 111
        ' (get) Token: 0x06000216 RID: 534 RVA: 0x002295A4 File Offset: 0x002285A4
        ' (set) Token: 0x06000215 RID: 533 RVA: 0x00229588 File Offset: 0x00228588
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

        ' Token: 0x17000070 RID: 112
        ' (get) Token: 0x06000218 RID: 536 RVA: 0x002295B8 File Offset: 0x002285B8
        ' (set) Token: 0x06000217 RID: 535 RVA: 0x002295CC File Offset: 0x002285CC
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

        ' Token: 0x17000071 RID: 113
        ' (get) Token: 0x06000219 RID: 537 RVA: 0x002295E8 File Offset: 0x002285E8
        ' (set) Token: 0x0600021A RID: 538 RVA: 0x002295FC File Offset: 0x002285FC
        Friend Overridable Property Label16() As Label
            Get
                Return Me._Label16
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label16 IsNot Nothing Then
                End If
                Me._Label16 = value
                If Me._Label16 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000072 RID: 114
        ' (get) Token: 0x0600021B RID: 539 RVA: 0x00229634 File Offset: 0x00228634
        ' (set) Token: 0x0600021C RID: 540 RVA: 0x00229618 File Offset: 0x00228618
        Friend Overridable Property Label17() As Label
            Get
                Return Me._Label17
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label17 IsNot Nothing Then
                End If
                Me._Label17 = value
                If Me._Label17 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000073 RID: 115
        ' (get) Token: 0x0600021E RID: 542 RVA: 0x00229664 File Offset: 0x00228664
        ' (set) Token: 0x0600021D RID: 541 RVA: 0x00229648 File Offset: 0x00228648
        Friend Overridable Property Label18() As Label
            Get
                Return Me._Label18
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label18 IsNot Nothing Then
                End If
                Me._Label18 = value
                If Me._Label18 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000074 RID: 116
        ' (get) Token: 0x0600021F RID: 543 RVA: 0x00229678 File Offset: 0x00228678
        ' (set) Token: 0x06000220 RID: 544 RVA: 0x0022968C File Offset: 0x0022868C
        Friend Overridable Property Label19() As Label
            Get
                Return Me._Label19
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label19 IsNot Nothing Then
                End If
                Me._Label19 = value
                If Me._Label19 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000075 RID: 117
        ' (get) Token: 0x06000222 RID: 546 RVA: 0x002296A8 File Offset: 0x002286A8
        ' (set) Token: 0x06000221 RID: 545 RVA: 0x002296BC File Offset: 0x002286BC
        Friend Overridable Property Label20() As Label
            Get
                Return Me._Label20
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label20 IsNot Nothing Then
                End If
                Me._Label20 = value
                If Me._Label20 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000076 RID: 118
        ' (get) Token: 0x06000223 RID: 547 RVA: 0x002296D8 File Offset: 0x002286D8
        ' (set) Token: 0x06000224 RID: 548 RVA: 0x002296EC File Offset: 0x002286EC
        Friend Overridable Property Label21() As Label
            Get
                Return Me._Label21
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label21 IsNot Nothing Then
                End If
                Me._Label21 = value
                If Me._Label21 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000077 RID: 119
        ' (get) Token: 0x06000225 RID: 549 RVA: 0x00229708 File Offset: 0x00228708
        ' (set) Token: 0x06000226 RID: 550 RVA: 0x0022971C File Offset: 0x0022871C
        Friend Overridable Property Label22() As Label
            Get
                Return Me._Label22
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label22 IsNot Nothing Then
                End If
                Me._Label22 = value
                If Me._Label22 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000078 RID: 120
        ' (get) Token: 0x06000227 RID: 551 RVA: 0x00229738 File Offset: 0x00228738
        ' (set) Token: 0x06000228 RID: 552 RVA: 0x0022974C File Offset: 0x0022874C
        Friend Overridable Property Label23() As Label
            Get
                Return Me._Label23
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label23 IsNot Nothing Then
                End If
                Me._Label23 = value
                If Me._Label23 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000079 RID: 121
        ' (get) Token: 0x06000229 RID: 553 RVA: 0x00229768 File Offset: 0x00228768
        ' (set) Token: 0x0600022A RID: 554 RVA: 0x0022977C File Offset: 0x0022877C
        Friend Overridable Property Label24() As Label
            Get
                Return Me._Label24
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label24 IsNot Nothing Then
                End If
                Me._Label24 = value
                If Me._Label24 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700007A RID: 122
        ' (get) Token: 0x0600022C RID: 556 RVA: 0x00229798 File Offset: 0x00228798
        ' (set) Token: 0x0600022B RID: 555 RVA: 0x002297AC File Offset: 0x002287AC
        Friend Overridable Property tbMa() As TextBox
            Get
                Return Me._tbMa
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMa IsNot Nothing Then
                End If
                Me._tbMa = value
                If Me._tbMa IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700007B RID: 123
        ' (get) Token: 0x0600022E RID: 558 RVA: 0x002297C8 File Offset: 0x002287C8
        ' (set) Token: 0x0600022D RID: 557 RVA: 0x002297DC File Offset: 0x002287DC
        Friend Overridable Property tbTa() As TextBox
            Get
                Return Me._tbTa
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTa IsNot Nothing Then
                End If
                Me._tbTa = value
                If Me._tbTa IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700007C RID: 124
        ' (get) Token: 0x06000230 RID: 560 RVA: 0x00229814 File Offset: 0x00228814
        ' (set) Token: 0x0600022F RID: 559 RVA: 0x002297F8 File Offset: 0x002287F8
        Friend Overridable Property tbMb() As TextBox
            Get
                Return Me._tbMb
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMb IsNot Nothing Then
                End If
                Me._tbMb = value
                If Me._tbMb IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700007D RID: 125
        ' (get) Token: 0x06000232 RID: 562 RVA: 0x00229828 File Offset: 0x00228828
        ' (set) Token: 0x06000231 RID: 561 RVA: 0x0022983C File Offset: 0x0022883C
        Friend Overridable Property tbTb() As TextBox
            Get
                Return Me._tbTb
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTb IsNot Nothing Then
                End If
                Me._tbTb = value
                If Me._tbTb IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700007E RID: 126
        ' (get) Token: 0x06000233 RID: 563 RVA: 0x00229858 File Offset: 0x00228858
        ' (set) Token: 0x06000234 RID: 564 RVA: 0x0022986C File Offset: 0x0022886C
        Friend Overridable Property tbTd() As TextBox
            Get
                Return Me._tbTd
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTd IsNot Nothing Then
                End If
                Me._tbTd = value
                If Me._tbTd IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700007F RID: 127
        ' (get) Token: 0x06000236 RID: 566 RVA: 0x00229888 File Offset: 0x00228888
        ' (set) Token: 0x06000235 RID: 565 RVA: 0x0022989C File Offset: 0x0022889C
        Friend Overridable Property tbMd() As TextBox
            Get
                Return Me._tbMd
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMd IsNot Nothing Then
                End If
                Me._tbMd = value
                If Me._tbMd IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000080 RID: 128
        ' (get) Token: 0x06000237 RID: 567 RVA: 0x002298B8 File Offset: 0x002288B8
        ' (set) Token: 0x06000238 RID: 568 RVA: 0x002298CC File Offset: 0x002288CC
        Friend Overridable Property tbMc() As TextBox
            Get
                Return Me._tbMc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMc IsNot Nothing Then
                End If
                Me._tbMc = value
                If Me._tbMc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000081 RID: 129
        ' (get) Token: 0x06000239 RID: 569 RVA: 0x002298E8 File Offset: 0x002288E8
        ' (set) Token: 0x0600023A RID: 570 RVA: 0x002298FC File Offset: 0x002288FC
        Friend Overridable Property tbTc() As TextBox
            Get
                Return Me._tbTc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTc IsNot Nothing Then
                End If
                Me._tbTc = value
                If Me._tbTc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000082 RID: 130
        ' (get) Token: 0x0600023C RID: 572 RVA: 0x00229918 File Offset: 0x00228918
        ' (set) Token: 0x0600023B RID: 571 RVA: 0x0022992C File Offset: 0x0022892C
        Friend Overridable Property tbTf() As TextBox
            Get
                Return Me._tbTf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTf IsNot Nothing Then
                End If
                Me._tbTf = value
                If Me._tbTf IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000083 RID: 131
        ' (get) Token: 0x0600023D RID: 573 RVA: 0x00229948 File Offset: 0x00228948
        ' (set) Token: 0x0600023E RID: 574 RVA: 0x0022995C File Offset: 0x0022895C
        Friend Overridable Property tbMf() As TextBox
            Get
                Return Me._tbMf
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMf IsNot Nothing Then
                End If
                Me._tbMf = value
                If Me._tbMf IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000084 RID: 132
        ' (get) Token: 0x0600023F RID: 575 RVA: 0x00229978 File Offset: 0x00228978
        ' (set) Token: 0x06000240 RID: 576 RVA: 0x0022998C File Offset: 0x0022898C
        Friend Overridable Property tbMe() As TextBox
            Get
                Return Me._tbMe
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMe IsNot Nothing Then
                End If
                Me._tbMe = value
                If Me._tbMe IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000085 RID: 133
        ' (get) Token: 0x06000241 RID: 577 RVA: 0x002299A8 File Offset: 0x002289A8
        ' (set) Token: 0x06000242 RID: 578 RVA: 0x002299BC File Offset: 0x002289BC
        Friend Overridable Property tbTe() As TextBox
            Get
                Return Me._tbTe
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTe IsNot Nothing Then
                End If
                Me._tbTe = value
                If Me._tbTe IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000086 RID: 134
        ' (get) Token: 0x06000243 RID: 579 RVA: 0x002299D8 File Offset: 0x002289D8
        ' (set) Token: 0x06000244 RID: 580 RVA: 0x002299EC File Offset: 0x002289EC
        Friend Overridable Property tbTg() As TextBox
            Get
                Return Me._tbTg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTg IsNot Nothing Then
                End If
                Me._tbTg = value
                If Me._tbTg IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000087 RID: 135
        ' (get) Token: 0x06000246 RID: 582 RVA: 0x00229A08 File Offset: 0x00228A08
        ' (set) Token: 0x06000245 RID: 581 RVA: 0x00229A1C File Offset: 0x00228A1C
        Friend Overridable Property tbMg() As TextBox
            Get
                Return Me._tbMg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMg IsNot Nothing Then
                End If
                Me._tbMg = value
                If Me._tbMg IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000088 RID: 136
        ' (get) Token: 0x06000247 RID: 583 RVA: 0x00229A38 File Offset: 0x00228A38
        ' (set) Token: 0x06000248 RID: 584 RVA: 0x00229A4C File Offset: 0x00228A4C
        Friend Overridable Property tbMh() As TextBox
            Get
                Return Me._tbMh
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMh IsNot Nothing Then
                End If
                Me._tbMh = value
                If Me._tbMh IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000089 RID: 137
        ' (get) Token: 0x06000249 RID: 585 RVA: 0x00229A68 File Offset: 0x00228A68
        ' (set) Token: 0x0600024A RID: 586 RVA: 0x00229A7C File Offset: 0x00228A7C
        Friend Overridable Property tbTh() As TextBox
            Get
                Return Me._tbTh
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTh IsNot Nothing Then
                End If
                Me._tbTh = value
                If Me._tbTh IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700008A RID: 138
        ' (get) Token: 0x0600024B RID: 587 RVA: 0x00229A98 File Offset: 0x00228A98
        ' (set) Token: 0x0600024C RID: 588 RVA: 0x00229AAC File Offset: 0x00228AAC
        Friend Overridable Property tbTi() As TextBox
            Get
                Return Me._tbTi
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTi IsNot Nothing Then
                End If
                Me._tbTi = value
                If Me._tbTi IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700008B RID: 139
        ' (get) Token: 0x0600024E RID: 590 RVA: 0x00229AC8 File Offset: 0x00228AC8
        ' (set) Token: 0x0600024D RID: 589 RVA: 0x00229ADC File Offset: 0x00228ADC
        Friend Overridable Property tbMi() As TextBox
            Get
                Return Me._tbMi
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMi IsNot Nothing Then
                End If
                Me._tbMi = value
                If Me._tbMi IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700008C RID: 140
        ' (get) Token: 0x06000250 RID: 592 RVA: 0x00229AF8 File Offset: 0x00228AF8
        ' (set) Token: 0x0600024F RID: 591 RVA: 0x00229B0C File Offset: 0x00228B0C
        Friend Overridable Property tbMj() As TextBox
            Get
                Return Me._tbMj
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMj IsNot Nothing Then
                End If
                Me._tbMj = value
                If Me._tbMj IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700008D RID: 141
        ' (get) Token: 0x06000252 RID: 594 RVA: 0x00229B44 File Offset: 0x00228B44
        ' (set) Token: 0x06000251 RID: 593 RVA: 0x00229B28 File Offset: 0x00228B28
        Friend Overridable Property tbTj() As TextBox
            Get
                Return Me._tbTj
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTj IsNot Nothing Then
                End If
                Me._tbTj = value
                If Me._tbTj IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700008E RID: 142
        ' (get) Token: 0x06000253 RID: 595 RVA: 0x00229B58 File Offset: 0x00228B58
        ' (set) Token: 0x06000254 RID: 596 RVA: 0x00229B6C File Offset: 0x00228B6C
        Friend Overridable Property tbEvilTexture() As TextBox
            Get
                Return Me._tbEvilTexture
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbEvilTexture IsNot Nothing Then
                End If
                Me._tbEvilTexture = value
                If Me._tbEvilTexture IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700008F RID: 143
        ' (get) Token: 0x06000255 RID: 597 RVA: 0x00229B88 File Offset: 0x00228B88
        ' (set) Token: 0x06000256 RID: 598 RVA: 0x00229B9C File Offset: 0x00228B9C
        Friend Overridable Property Label25() As Label
            Get
                Return Me._Label25
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label25 IsNot Nothing Then
                End If
                Me._Label25 = value
                If Me._Label25 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000090 RID: 144
        ' (get) Token: 0x06000258 RID: 600 RVA: 0x00229BD4 File Offset: 0x00228BD4
        ' (set) Token: 0x06000257 RID: 599 RVA: 0x00229BB8 File Offset: 0x00228BB8
        Friend Overridable Property Button1() As Button
            Get
                Return Me._Button1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._Button1 IsNot Nothing Then
                End If
                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000091 RID: 145
        ' (get) Token: 0x0600025A RID: 602 RVA: 0x00229C3C File Offset: 0x00228C3C
        ' (set) Token: 0x06000259 RID: 601 RVA: 0x00229BE8 File Offset: 0x00228BE8
        Friend Overridable Property chkbAutoCreateSeqEntries() As CheckBox
            Get
                Return Me._chkbAutoCreateSeqEntries
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbAutoCreateSeqEntries IsNot Nothing Then
                    RemoveHandler Me._chkbAutoCreateSeqEntries.CheckedChanged, AddressOf Me.chkbAutoCreateSeqEntires_CheckedChanged
                End If
                Me._chkbAutoCreateSeqEntries = value
                If Me._chkbAutoCreateSeqEntries IsNot Nothing Then
                    AddHandler Me._chkbAutoCreateSeqEntries.CheckedChanged, AddressOf Me.chkbAutoCreateSeqEntires_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x0600025C RID: 604 RVA: 0x0022BE9C File Offset: 0x0022AE9C
        Private Sub frmAppearanceWizard_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.cmbxEnvMap.SelectedIndex = 0
            Me.cmbxGender.SelectedIndex = 0
            Me.cmbxModelNaming.SelectedIndex = 0
            Me.cmbxModelType.SelectedIndex = 0
            Me.cmbxMovementRate.SelectedIndex = 4
            Me.cmbxSizes.SelectedIndex = 1
            Me.tbHitRadius.Text = "0.25"
            Me.tbPerspace.Text = "0.35"
            Me.tbCreperspace.Text = "0.4"
            Me.tbprefatkdist.Text = "0.5"
        End Sub

        ' Token: 0x0600025D RID: 605 RVA: 0x0022BF34 File Offset: 0x0022AF34
        Public Function GetSizeString(ByVal index As Integer) As String
            Select Case index
                Case 1
                    Return "SML"
                Case 2
                    Return "MED"
                Case 3
                    Return "LRG"
                Case Else
                    Dim text As String
                    Return text
            End Select
        End Function

        ' Token: 0x0600025E RID: 606 RVA: 0x0022BF6C File Offset: 0x0022AF6C
        Public Function GetSizeLetter(ByVal index As Integer) As String
            Return Strings.Mid(Me.GetSizeString(index), 1, 1)
        End Function

        ' Token: 0x0600025F RID: 607 RVA: 0x0022BF88 File Offset: 0x0022AF88
        Public Function GetSpeedString() As String
            Select Case Me.cmbxMovementRate.SelectedIndex
                Case 0
                    Return "NOMOVE"
                Case 1
                    Return "WEE_FOLK"
                Case 2
                    Return "VSLOW"
                Case 3
                    Return "SLOW"
                Case 4
                    Return "NORM"
                Case 5
                    Return "FAST"
                Case 6
                    Return "VFAST"
                Case 7
                    Return "PLAYER"
                Case 8
                    Return "HUGE"
                Case 9
                    Return "GIANT"
                Case 10
                    Return "DFAST"
                Case Else
                    Dim text As String
                    Return text
            End Select
        End Function

        ' Token: 0x06000260 RID: 608 RVA: 0x0022C018 File Offset: 0x0022B018
        Public Sub FillRowCommonInfo(ByRef dr As DataRow)
            dr(0) = "512"
            dr(1) = "placeholder for name"
            dr(2) = "****"
            dr(3) = "****"
            dr(4) = "1.813"
            dr(5) = "3.96"
            dr(6) = "1.813"
            dr(7) = "3.96"
            dr(8) = "****"
            dr(9) = "B"
            dr(10) = "77"
            dr(11) = "PMBAL"
            dr(12) = ""
            dr(13) = ""
            dr(14) = ""
            dr(15) = ""
            dr(16) = ""
            dr(17) = ""
            dr(18) = ""
            dr(19) = ""
            dr(20) = ""
            dr(21) = ""
            dr(22) = ""
            dr(23) = ""
            dr(24) = ""
            dr(25) = ""
            dr(26) = ""
            dr(27) = ""
            dr(28) = ""
            dr(29) = ""
            dr(30) = ""
            dr(31) = ""
            dr(32) = "****"
            dr(33) = "****"
            dr(34) = "****"
            dr(35) = "****"
            dr(36) = "****"
            dr(37) = "****"
            dr(38) = "DEFAULT"
            dr(39) = "R"
            dr(40) = "****"
            dr(41) = "1"
            dr(42) = "NORM"
            dr(43) = "50"
            dr(44) = "5.4"
            dr(45) = "0.25"
            dr(46) = "0.35"
            dr(47) = "0.4"
            dr(48) = "****"
            dr(49) = "1.6"
            dr(50) = "l"
            dr(51) = "0"
            dr(52) = "20"
            dr(53) = "1"
            dr(54) = "1"
            dr(55) = "****"
            dr(56) = "****"
            dr(57) = "1"
            dr(58) = "3"
            dr(59) = "****"
            dr(60) = "****"
            dr(61) = "****"
            dr(62) = "****"
            dr(63) = "9"
            dr(64) = "0"
            dr(65) = "0"
            dr(66) = "1"
            dr(67) = "30"
            dr(68) = "15"
            dr(69) = "****"
            dr(70) = "1"
            dr(71) = "0.5"
            dr(72) = "0"
            dr(73) = "2"
            dr(74) = "****"
            dr(75) = "****"
            dr(76) = "****"
            dr(77) = "****"
            dr(78) = "****"
            dr(79) = "****"
            dr(80) = "****"
        End Sub

        ' Token: 0x06000261 RID: 609 RVA: 0x0022C48C File Offset: 0x0022B48C
        Public Sub GenerateModelStrings(ByVal size As Integer)
            Me.tbMa.Text = Me.tbBaseModelName.Text + "A" + Me.GetSizeLetter(size)
            Me.tbMb.Text = Me.tbBaseModelName.Text + "B" + Me.GetSizeLetter(size)
            Me.tbMc.Text = Me.tbBaseModelName.Text + "C" + Me.GetSizeLetter(size)
            Me.tbMd.Text = Me.tbBaseModelName.Text + "D" + Me.GetSizeLetter(size)
            Me.tbMe.Text = Me.tbBaseModelName.Text + "E" + Me.GetSizeLetter(size)
            Me.tbMf.Text = Me.tbBaseModelName.Text + "F" + Me.GetSizeLetter(size)
            Me.tbMg.Text = Me.tbBaseModelName.Text + "G" + Me.GetSizeLetter(size)
            Me.tbMh.Text = Me.tbBaseModelName.Text + "H" + Me.GetSizeLetter(size)
            Me.tbMi.Text = Me.tbBaseModelName.Text + "I" + Me.GetSizeLetter(size)
            Me.tbMj.Text = Me.tbBaseModelName.Text + "J" + Me.GetSizeLetter(size)
            Me.tbTa.Text = Me.tbBaseModelName.Text + "A"
            Me.tbTb.Text = Me.tbBaseModelName.Text + "B"
            Me.tbTc.Text = Me.tbBaseModelName.Text + "C"
            Me.tbTd.Text = Me.tbBaseModelName.Text + "D"
            Me.tbTe.Text = Me.tbBaseModelName.Text + "E"
            Me.tbTf.Text = Me.tbBaseModelName.Text + "F"
            Me.tbTg.Text = Me.tbBaseModelName.Text + "G"
            Me.tbTh.Text = Me.tbBaseModelName.Text + "H"
            Me.tbTi.Text = Me.tbBaseModelName.Text + "I"
            Me.tbTj.Text = Me.tbBaseModelName.Text + "J"
        End Sub

        ' Token: 0x06000262 RID: 610 RVA: 0x0022C760 File Offset: 0x0022B760
        Public Sub PropagateBaseModelString()
            Me.SetAllModelStrings(Me.tbBaseModelName.Text)
        End Sub

        ' Token: 0x06000263 RID: 611 RVA: 0x0022C774 File Offset: 0x0022B774
        Public Sub ClearAllModelStrings()
            Me.SetAllModelStrings("")
        End Sub

        ' Token: 0x06000264 RID: 612 RVA: 0x0022C784 File Offset: 0x0022B784
        Public Sub SetAllModelStrings(ByVal s As String)
            Me.tbMa.Text = s
            Me.tbMb.Text = s
            Me.tbMc.Text = s
            Me.tbMd.Text = s
            Me.tbMe.Text = s
            Me.tbMf.Text = s
            Me.tbMg.Text = s
            Me.tbMh.Text = s
            Me.tbMi.Text = s
            Me.tbMj.Text = s
            Me.tbTa.Text = s
            Me.tbTb.Text = s
            Me.tbTc.Text = s
            Me.tbTd.Text = s
            Me.tbTe.Text = s
            Me.tbTf.Text = s
            Me.tbTg.Text = s
            Me.tbTh.Text = s
            Me.tbTi.Text = s
            Me.tbTj.Text = s
        End Sub

        ' Token: 0x06000265 RID: 613 RVA: 0x0022C884 File Offset: 0x0022B884
        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If StringType.StrCmp(Strings.Trim(Me.tbBaseModelName.Text), "", False) <> 0 Then
                If Me.cmbxModelNaming.SelectedIndex = 1 Then
                    Me.GenerateModelStrings(1)
                Else
                    Me.PropagateBaseModelString()
                End If
            End If
        End Sub

        ' Token: 0x06000266 RID: 614 RVA: 0x0022C8C4 File Offset: 0x0022B8C4
        Private Sub cmbxModelNaming_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.chkbAutoCreateSeqEntries.Visible = Me.cmbxModelNaming.SelectedIndex = 1
        End Sub

        ' Token: 0x06000267 RID: 615 RVA: 0x0022C8E0 File Offset: 0x0022B8E0
        Private Sub chkbAutoCreateSeqEntires_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checked As Boolean = Me.chkbAutoCreateSeqEntries.Checked
            Me.tbMa.[ReadOnly] = checked
            Me.tbTa.[ReadOnly] = checked
            Me.tbEvilTexture.[ReadOnly] = checked
            Me.tbMb.[ReadOnly] = checked
            Me.tbTb.[ReadOnly] = checked
            Me.tbMc.[ReadOnly] = checked
            Me.tbTc.[ReadOnly] = checked
            Me.tbMd.[ReadOnly] = checked
            Me.tbTd.[ReadOnly] = checked
            Me.tbMe.[ReadOnly] = checked
            Me.tbTe.[ReadOnly] = checked
            Me.tbMf.[ReadOnly] = checked
            Me.tbTf.[ReadOnly] = checked
            Me.tbMg.[ReadOnly] = checked
            Me.tbTg.[ReadOnly] = checked
            Me.tbMh.[ReadOnly] = checked
            Me.tbTh.[ReadOnly] = checked
            Me.tbMi.[ReadOnly] = checked
            Me.tbTi.[ReadOnly] = checked
            Me.tbMj.[ReadOnly] = checked
            Me.tbTj.[ReadOnly] = checked
        End Sub

        ' Token: 0x04000154 RID: 340
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x04000155 RID: 341
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x04000156 RID: 342
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x04000157 RID: 343
        <AccessedThroughProperty("tbHeadNum")> _
        Private _tbHeadNum As TextBox

        ' Token: 0x04000158 RID: 344
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x04000159 RID: 345
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x0400015A RID: 346
        <AccessedThroughProperty("tbName")> _
        Private _tbName As TextBox

        ' Token: 0x0400015B RID: 347
        <AccessedThroughProperty("cmbxGender")> _
        Private _cmbxGender As ComboBox

        ' Token: 0x0400015C RID: 348
        <AccessedThroughProperty("cmbxSizes")> _
        Private _cmbxSizes As ComboBox

        ' Token: 0x0400015D RID: 349
        <AccessedThroughProperty("cmbxEnvMap")> _
        Private _cmbxEnvMap As ComboBox

        ' Token: 0x0400015E RID: 350
        <AccessedThroughProperty("cmbxMovementRate")> _
        Private _cmbxMovementRate As ComboBox

        ' Token: 0x0400015F RID: 351
        <AccessedThroughProperty("cmbxModelType")> _
        Private _cmbxModelType As ComboBox

        ' Token: 0x04000160 RID: 352
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000161 RID: 353
        <AccessedThroughProperty("tbHitRadius")> _
        Private _tbHitRadius As TextBox

        ' Token: 0x04000162 RID: 354
        <AccessedThroughProperty("tbPerspace")> _
        Private _tbPerspace As TextBox

        ' Token: 0x04000163 RID: 355
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000164 RID: 356
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x04000165 RID: 357
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000166 RID: 358
        <AccessedThroughProperty("TabPage1")> _
        Private _TabPage1 As TabPage

        ' Token: 0x04000167 RID: 359
        <AccessedThroughProperty("tbprefatkdist")> _
        Private _tbprefatkdist As TextBox

        ' Token: 0x04000168 RID: 360
        <AccessedThroughProperty("TabPage2")> _
        Private _TabPage2 As TabPage

        ' Token: 0x04000169 RID: 361
        <AccessedThroughProperty("Label13")> _
        Private _Label13 As Label

        ' Token: 0x0400016A RID: 362
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x0400016B RID: 363
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x0400016C RID: 364
        <AccessedThroughProperty("Label16")> _
        Private _Label16 As Label

        ' Token: 0x0400016D RID: 365
        <AccessedThroughProperty("Label17")> _
        Private _Label17 As Label

        ' Token: 0x0400016E RID: 366
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x0400016F RID: 367
        <AccessedThroughProperty("tbBaseModelName")> _
        Private _tbBaseModelName As TextBox

        ' Token: 0x04000170 RID: 368
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x04000171 RID: 369
        <AccessedThroughProperty("cmbxModelNaming")> _
        Private _cmbxModelNaming As ComboBox

        ' Token: 0x04000172 RID: 370
        <AccessedThroughProperty("Label18")> _
        Private _Label18 As Label

        ' Token: 0x04000173 RID: 371
        <AccessedThroughProperty("Label19")> _
        Private _Label19 As Label

        ' Token: 0x04000174 RID: 372
        <AccessedThroughProperty("Label20")> _
        Private _Label20 As Label

        ' Token: 0x04000175 RID: 373
        <AccessedThroughProperty("tbCreperspace")> _
        Private _tbCreperspace As TextBox

        ' Token: 0x04000176 RID: 374
        <AccessedThroughProperty("Label21")> _
        Private _Label21 As Label

        ' Token: 0x04000177 RID: 375
        <AccessedThroughProperty("Label22")> _
        Private _Label22 As Label

        ' Token: 0x04000178 RID: 376
        <AccessedThroughProperty("Label23")> _
        Private _Label23 As Label

        ' Token: 0x04000179 RID: 377
        <AccessedThroughProperty("Label24")> _
        Private _Label24 As Label

        ' Token: 0x0400017A RID: 378
        <AccessedThroughProperty("tbMa")> _
        Private _tbMa As TextBox

        ' Token: 0x0400017B RID: 379
        <AccessedThroughProperty("tbTa")> _
        Private _tbTa As TextBox

        ' Token: 0x0400017C RID: 380
        <AccessedThroughProperty("tbMb")> _
        Private _tbMb As TextBox

        ' Token: 0x0400017D RID: 381
        <AccessedThroughProperty("tbTb")> _
        Private _tbTb As TextBox

        ' Token: 0x0400017E RID: 382
        <AccessedThroughProperty("tbTd")> _
        Private _tbTd As TextBox

        ' Token: 0x0400017F RID: 383
        <AccessedThroughProperty("tbMd")> _
        Private _tbMd As TextBox

        ' Token: 0x04000180 RID: 384
        <AccessedThroughProperty("tbMc")> _
        Private _tbMc As TextBox

        ' Token: 0x04000181 RID: 385
        <AccessedThroughProperty("tbTc")> _
        Private _tbTc As TextBox

        ' Token: 0x04000182 RID: 386
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000183 RID: 387
        <AccessedThroughProperty("tbTf")> _
        Private _tbTf As TextBox

        ' Token: 0x04000184 RID: 388
        <AccessedThroughProperty("tbMf")> _
        Private _tbMf As TextBox

        ' Token: 0x04000185 RID: 389
        <AccessedThroughProperty("tbMe")> _
        Private _tbMe As TextBox

        ' Token: 0x04000186 RID: 390
        <AccessedThroughProperty("tbTe")> _
        Private _tbTe As TextBox

        ' Token: 0x04000187 RID: 391
        <AccessedThroughProperty("tbTg")> _
        Private _tbTg As TextBox

        ' Token: 0x04000188 RID: 392
        <AccessedThroughProperty("tbMg")> _
        Private _tbMg As TextBox

        ' Token: 0x04000189 RID: 393
        <AccessedThroughProperty("tbMh")> _
        Private _tbMh As TextBox

        ' Token: 0x0400018A RID: 394
        <AccessedThroughProperty("tbTh")> _
        Private _tbTh As TextBox

        ' Token: 0x0400018B RID: 395
        <AccessedThroughProperty("tbTi")> _
        Private _tbTi As TextBox

        ' Token: 0x0400018C RID: 396
        <AccessedThroughProperty("tbMi")> _
        Private _tbMi As TextBox

        ' Token: 0x0400018D RID: 397
        <AccessedThroughProperty("tbMj")> _
        Private _tbMj As TextBox

        ' Token: 0x0400018E RID: 398
        <AccessedThroughProperty("tbTj")> _
        Private _tbTj As TextBox

        ' Token: 0x0400018F RID: 399
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x04000190 RID: 400
        <AccessedThroughProperty("tbEvilTexture")> _
        Private _tbEvilTexture As TextBox

        ' Token: 0x04000191 RID: 401
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000192 RID: 402
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000193 RID: 403
        <AccessedThroughProperty("chkbAutoCreateSeqEntries")> _
        Private _chkbAutoCreateSeqEntries As CheckBox

        ' Token: 0x04000194 RID: 404
        <AccessedThroughProperty("Label25")> _
        Private _Label25 As Label

        ' Token: 0x04000195 RID: 405
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x04000197 RID: 407
        Public appearanceName As String
    End Class
End Namespace
