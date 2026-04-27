Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000061 RID: 97
	Public Partial Class frmModuleIfo_AreaEditor
		Inherits frmParent

		' Token: 0x06000974 RID: 2420 RVA: 0x0026E444 File Offset: 0x0026D444
		Public Sub New()
			Me.ComboBoxSettingError = False
			Me.bmpXY = New Bitmap(50, 50)
			Me._XYAngle = 0.0
			Me.InitializeComponent()
		End Sub

		' Token: 0x170002E7 RID: 743
		' (get) Token: 0x06000976 RID: 2422 RVA: 0x0026E498 File Offset: 0x0026D498
		' (set) Token: 0x06000977 RID: 2423 RVA: 0x0026E4AC File Offset: 0x0026D4AC
		Friend Overridable Property Label34 As Label
			Get
				Return Me._Label34
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label34 IsNot Nothing Then
                End If
                Me._Label34 = value
                If Me._Label34 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002E8 RID: 744
        ' (get) Token: 0x06000978 RID: 2424 RVA: 0x0026E4E4 File Offset: 0x0026D4E4
        ' (set) Token: 0x06000979 RID: 2425 RVA: 0x0026E4C8 File Offset: 0x0026D4C8
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

        ' Token: 0x170002E9 RID: 745
        ' (get) Token: 0x0600097A RID: 2426 RVA: 0x0026E4F8 File Offset: 0x0026D4F8
        ' (set) Token: 0x0600097B RID: 2427 RVA: 0x0026E50C File Offset: 0x0026D50C
        Friend Overridable Property Label32() As Label
            Get
                Return Me._Label32
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label32 IsNot Nothing Then
                End If
                Me._Label32 = value
                If Me._Label32 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002EA RID: 746
        ' (get) Token: 0x0600097C RID: 2428 RVA: 0x0026E544 File Offset: 0x0026D544
        ' (set) Token: 0x0600097D RID: 2429 RVA: 0x0026E528 File Offset: 0x0026D528
        Friend Overridable Property Label35() As Label
            Get
                Return Me._Label35
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label35 IsNot Nothing Then
                End If
                Me._Label35 = value
                If Me._Label35 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002EB RID: 747
        ' (get) Token: 0x0600097E RID: 2430 RVA: 0x0026E558 File Offset: 0x0026D558
        ' (set) Token: 0x0600097F RID: 2431 RVA: 0x0026E56C File Offset: 0x0026D56C
        Friend Overridable Property Label36() As Label
            Get
                Return Me._Label36
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label36 IsNot Nothing Then
                End If
                Me._Label36 = value
                If Me._Label36 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002EC RID: 748
        ' (get) Token: 0x06000980 RID: 2432 RVA: 0x0026E588 File Offset: 0x0026D588
        ' (set) Token: 0x06000981 RID: 2433 RVA: 0x0026E59C File Offset: 0x0026D59C
        Friend Overridable Property Label37() As Label
            Get
                Return Me._Label37
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label37 IsNot Nothing Then
                End If
                Me._Label37 = value
                If Me._Label37 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002ED RID: 749
        ' (get) Token: 0x06000982 RID: 2434 RVA: 0x0026E5B8 File Offset: 0x0026D5B8
        ' (set) Token: 0x06000983 RID: 2435 RVA: 0x0026E5CC File Offset: 0x0026D5CC
        Friend Overridable Property Label38() As Label
            Get
                Return Me._Label38
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label38 IsNot Nothing Then
                End If
                Me._Label38 = value
                If Me._Label38 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002EE RID: 750
        ' (get) Token: 0x06000984 RID: 2436 RVA: 0x0026E5E8 File Offset: 0x0026D5E8
        ' (set) Token: 0x06000985 RID: 2437 RVA: 0x0026E5FC File Offset: 0x0026D5FC
        Friend Overridable Property Label39() As Label
            Get
                Return Me._Label39
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label39 IsNot Nothing Then
                End If
                Me._Label39 = value
                If Me._Label39 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002EF RID: 751
        ' (get) Token: 0x06000986 RID: 2438 RVA: 0x0026E618 File Offset: 0x0026D618
        ' (set) Token: 0x06000987 RID: 2439 RVA: 0x0026E62C File Offset: 0x0026D62C
        Friend Overridable Property Label40() As Label
            Get
                Return Me._Label40
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label40 IsNot Nothing Then
                End If
                Me._Label40 = value
                If Me._Label40 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002F0 RID: 752
        ' (get) Token: 0x06000989 RID: 2441 RVA: 0x0026E664 File Offset: 0x0026D664
        ' (set) Token: 0x06000988 RID: 2440 RVA: 0x0026E648 File Offset: 0x0026D648
        Friend Overridable Property Label41() As Label
            Get
                Return Me._Label41
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label41 IsNot Nothing Then
                End If
                Me._Label41 = value
                If Me._Label41 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002F1 RID: 753
        ' (get) Token: 0x0600098A RID: 2442 RVA: 0x0026E678 File Offset: 0x0026D678
        ' (set) Token: 0x0600098B RID: 2443 RVA: 0x0026E68C File Offset: 0x0026D68C
        Friend Overridable Property Label42() As Label
            Get
                Return Me._Label42
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label42 IsNot Nothing Then
                End If
                Me._Label42 = value
                If Me._Label42 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002F2 RID: 754
        ' (get) Token: 0x0600098C RID: 2444 RVA: 0x0026E6C4 File Offset: 0x0026D6C4
        ' (set) Token: 0x0600098D RID: 2445 RVA: 0x0026E6A8 File Offset: 0x0026D6A8
        Friend Overridable Property Label43() As Label
            Get
                Return Me._Label43
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label43 IsNot Nothing Then
                End If
                Me._Label43 = value
                If Me._Label43 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002F3 RID: 755
        ' (get) Token: 0x0600098F RID: 2447 RVA: 0x0026E6D8 File Offset: 0x0026D6D8
        ' (set) Token: 0x0600098E RID: 2446 RVA: 0x0026E6EC File Offset: 0x0026D6EC
        Friend Overridable Property Label44() As Label
            Get
                Return Me._Label44
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label44 IsNot Nothing Then
                End If
                Me._Label44 = value
                If Me._Label44 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002F4 RID: 756
        ' (get) Token: 0x06000990 RID: 2448 RVA: 0x0026E708 File Offset: 0x0026D708
        ' (set) Token: 0x06000991 RID: 2449 RVA: 0x0026E71C File Offset: 0x0026D71C
        Friend Overridable Property Label46() As Label
            Get
                Return Me._Label46
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label46 IsNot Nothing Then
                End If
                Me._Label46 = value
                If Me._Label46 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002F5 RID: 757
        ' (get) Token: 0x06000992 RID: 2450 RVA: 0x0026E754 File Offset: 0x0026D754
        ' (set) Token: 0x06000993 RID: 2451 RVA: 0x0026E738 File Offset: 0x0026D738
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

        ' Token: 0x170002F6 RID: 758
        ' (get) Token: 0x06000994 RID: 2452 RVA: 0x0026E784 File Offset: 0x0026D784
        ' (set) Token: 0x06000995 RID: 2453 RVA: 0x0026E768 File Offset: 0x0026D768
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

        ' Token: 0x170002F7 RID: 759
        ' (get) Token: 0x06000996 RID: 2454 RVA: 0x0026E7B4 File Offset: 0x0026D7B4
        ' (set) Token: 0x06000997 RID: 2455 RVA: 0x0026E798 File Offset: 0x0026D798
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

        ' Token: 0x170002F8 RID: 760
        ' (get) Token: 0x06000998 RID: 2456 RVA: 0x0026E7E4 File Offset: 0x0026D7E4
        ' (set) Token: 0x06000999 RID: 2457 RVA: 0x0026E7C8 File Offset: 0x0026D7C8
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

        ' Token: 0x170002F9 RID: 761
        ' (get) Token: 0x0600099A RID: 2458 RVA: 0x0026E7F8 File Offset: 0x0026D7F8
        ' (set) Token: 0x0600099B RID: 2459 RVA: 0x0026E80C File Offset: 0x0026D80C
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

        ' Token: 0x170002FA RID: 762
        ' (get) Token: 0x0600099D RID: 2461 RVA: 0x0026E844 File Offset: 0x0026D844
        ' (set) Token: 0x0600099C RID: 2460 RVA: 0x0026E828 File Offset: 0x0026D828
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

        ' Token: 0x170002FB RID: 763
        ' (get) Token: 0x0600099E RID: 2462 RVA: 0x0026E858 File Offset: 0x0026D858
        ' (set) Token: 0x0600099F RID: 2463 RVA: 0x0026E86C File Offset: 0x0026D86C
        Friend Overridable Property nudXPScale() As NumericUpDown
            Get
                Return Me._nudXPScale
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudXPScale IsNot Nothing Then
                    RemoveHandler Me._nudXPScale.ValueChanged, AddressOf Me.nudXPScale_ValueChanged
                End If
                Me._nudXPScale = value
                If Me._nudXPScale IsNot Nothing Then
                    AddHandler Me._nudXPScale.ValueChanged, AddressOf Me.nudXPScale_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x170002FC RID: 764
        ' (get) Token: 0x060009A0 RID: 2464 RVA: 0x0026E914 File Offset: 0x0026D914
        ' (set) Token: 0x060009A1 RID: 2465 RVA: 0x0026E8C0 File Offset: 0x0026D8C0
        Friend Overridable Property trkbarXPScale() As TrackBar
            Get
                Return Me._trkbarXPScale
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarXPScale IsNot Nothing Then
                    RemoveHandler Me._trkbarXPScale.Scroll, AddressOf Me.trkbarXPScale_Scroll
                End If
                Me._trkbarXPScale = value
                If Me._trkbarXPScale IsNot Nothing Then
                    AddHandler Me._trkbarXPScale.Scroll, AddressOf Me.trkbarXPScale_Scroll
                End If
            End Set
        End Property

        ' Token: 0x170002FD RID: 765
        ' (get) Token: 0x060009A2 RID: 2466 RVA: 0x0026E944 File Offset: 0x0026D944
        ' (set) Token: 0x060009A3 RID: 2467 RVA: 0x0026E928 File Offset: 0x0026D928
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

        ' Token: 0x170002FE RID: 766
        ' (get) Token: 0x060009A4 RID: 2468 RVA: 0x0026E958 File Offset: 0x0026D958
        ' (set) Token: 0x060009A5 RID: 2469 RVA: 0x0026E96C File Offset: 0x0026D96C
        Friend Overridable Property btnSetDescriptionLang() As Button
            Get
                Return Me._btnSetDescriptionLang
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetDescriptionLang IsNot Nothing Then
                    RemoveHandler Me._btnSetDescriptionLang.Click, AddressOf Me.btnSetDescriptionLang_Click
                End If
                Me._btnSetDescriptionLang = value
                If Me._btnSetDescriptionLang IsNot Nothing Then
                    AddHandler Me._btnSetDescriptionLang.Click, AddressOf Me.btnSetDescriptionLang_Click
                End If
            End Set
        End Property

        ' Token: 0x170002FF RID: 767
        ' (get) Token: 0x060009A7 RID: 2471 RVA: 0x0026E9C0 File Offset: 0x0026D9C0
        ' (set) Token: 0x060009A6 RID: 2470 RVA: 0x0026E9D4 File Offset: 0x0026D9D4
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

        ' Token: 0x17000300 RID: 768
        ' (get) Token: 0x060009A8 RID: 2472 RVA: 0x0026EA0C File Offset: 0x0026DA0C
        ' (set) Token: 0x060009A9 RID: 2473 RVA: 0x0026E9F0 File Offset: 0x0026D9F0
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

        ' Token: 0x17000301 RID: 769
        ' (get) Token: 0x060009AA RID: 2474 RVA: 0x0026EA20 File Offset: 0x0026DA20
        ' (set) Token: 0x060009AB RID: 2475 RVA: 0x0026EA34 File Offset: 0x0026DA34
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

        ' Token: 0x17000302 RID: 770
        ' (get) Token: 0x060009AC RID: 2476 RVA: 0x0026EA6C File Offset: 0x0026DA6C
        ' (set) Token: 0x060009AD RID: 2477 RVA: 0x0026EA50 File Offset: 0x0026DA50
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

        ' Token: 0x17000303 RID: 771
        ' (get) Token: 0x060009AF RID: 2479 RVA: 0x0026EA80 File Offset: 0x0026DA80
        ' (set) Token: 0x060009AE RID: 2478 RVA: 0x0026EA94 File Offset: 0x0026DA94
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

        ' Token: 0x17000304 RID: 772
        ' (get) Token: 0x060009B0 RID: 2480 RVA: 0x0026EAB0 File Offset: 0x0026DAB0
        ' (set) Token: 0x060009B1 RID: 2481 RVA: 0x0026EAC4 File Offset: 0x0026DAC4
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

        ' Token: 0x17000305 RID: 773
        ' (get) Token: 0x060009B2 RID: 2482 RVA: 0x0026EAFC File Offset: 0x0026DAFC
        ' (set) Token: 0x060009B3 RID: 2483 RVA: 0x0026EAE0 File Offset: 0x0026DAE0
        Friend Overridable Property TabPage5() As TabPage
            Get
                Return Me._TabPage5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage5 IsNot Nothing Then
                End If
                Me._TabPage5 = value
                If Me._TabPage5 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000306 RID: 774
        ' (get) Token: 0x060009B4 RID: 2484 RVA: 0x0026EB10 File Offset: 0x0026DB10
        ' (set) Token: 0x060009B5 RID: 2485 RVA: 0x0026EB24 File Offset: 0x0026DB24
        Friend Overridable Property TabPage6() As TabPage
            Get
                Return Me._TabPage6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage6 IsNot Nothing Then
                End If
                Me._TabPage6 = value
                If Me._TabPage6 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000307 RID: 775
        ' (get) Token: 0x060009B6 RID: 2486 RVA: 0x0026EB5C File Offset: 0x0026DB5C
        ' (set) Token: 0x060009B7 RID: 2487 RVA: 0x0026EB40 File Offset: 0x0026DB40
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

        ' Token: 0x17000308 RID: 776
        ' (get) Token: 0x060009B8 RID: 2488 RVA: 0x0026EB8C File Offset: 0x0026DB8C
        ' (set) Token: 0x060009B9 RID: 2489 RVA: 0x0026EB70 File Offset: 0x0026DB70
        Friend Overridable Property NumericUpDown10() As NumericUpDown
            Get
                Return Me._NumericUpDown10
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._NumericUpDown10 IsNot Nothing Then
                End If
                Me._NumericUpDown10 = value
                If Me._NumericUpDown10 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000309 RID: 777
        ' (get) Token: 0x060009BA RID: 2490 RVA: 0x0026EBA0 File Offset: 0x0026DBA0
        ' (set) Token: 0x060009BB RID: 2491 RVA: 0x0026EBB4 File Offset: 0x0026DBB4
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

        ' Token: 0x1700030A RID: 778
        ' (get) Token: 0x060009BD RID: 2493 RVA: 0x0026EBD0 File Offset: 0x0026DBD0
        ' (set) Token: 0x060009BC RID: 2492 RVA: 0x0026EBE4 File Offset: 0x0026DBE4
        Friend Overridable Property NumericUpDown11() As NumericUpDown
            Get
                Return Me._NumericUpDown11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._NumericUpDown11 IsNot Nothing Then
                End If
                Me._NumericUpDown11 = value
                If Me._NumericUpDown11 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700030B RID: 779
        ' (get) Token: 0x060009BF RID: 2495 RVA: 0x0026EC1C File Offset: 0x0026DC1C
        ' (set) Token: 0x060009BE RID: 2494 RVA: 0x0026EC00 File Offset: 0x0026DC00
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

        ' Token: 0x1700030C RID: 780
        ' (get) Token: 0x060009C0 RID: 2496 RVA: 0x0026EC30 File Offset: 0x0026DC30
        ' (set) Token: 0x060009C1 RID: 2497 RVA: 0x0026EC44 File Offset: 0x0026DC44
        Friend Overridable Property NumericUpDown12() As NumericUpDown
            Get
                Return Me._NumericUpDown12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._NumericUpDown12 IsNot Nothing Then
                End If
                Me._NumericUpDown12 = value
                If Me._NumericUpDown12 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700030D RID: 781
        ' (get) Token: 0x060009C3 RID: 2499 RVA: 0x0026EC7C File Offset: 0x0026DC7C
        ' (set) Token: 0x060009C2 RID: 2498 RVA: 0x0026EC60 File Offset: 0x0026DC60
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

        ' Token: 0x1700030E RID: 782
        ' (get) Token: 0x060009C4 RID: 2500 RVA: 0x0026ECAC File Offset: 0x0026DCAC
        ' (set) Token: 0x060009C5 RID: 2501 RVA: 0x0026EC90 File Offset: 0x0026DC90
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

        ' Token: 0x1700030F RID: 783
        ' (get) Token: 0x060009C6 RID: 2502 RVA: 0x0026ECDC File Offset: 0x0026DCDC
        ' (set) Token: 0x060009C7 RID: 2503 RVA: 0x0026ECC0 File Offset: 0x0026DCC0
        Friend Overridable Property TabControlModule() As TabControl
            Get
                Return Me._TabControlModule
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._TabControlModule IsNot Nothing Then
                End If
                Me._TabControlModule = value
                If Me._TabControlModule IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000310 RID: 784
        ' (get) Token: 0x060009C9 RID: 2505 RVA: 0x0026ECF0 File Offset: 0x0026DCF0
        ' (set) Token: 0x060009C8 RID: 2504 RVA: 0x0026ED04 File Offset: 0x0026DD04
        Friend Overridable Property TabControlMain() As TabControl
            Get
                Return Me._TabControlMain
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._TabControlMain IsNot Nothing Then
                End If
                Me._TabControlMain = value
                If Me._TabControlMain IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000311 RID: 785
        ' (get) Token: 0x060009CA RID: 2506 RVA: 0x0026ED20 File Offset: 0x0026DD20
        ' (set) Token: 0x060009CB RID: 2507 RVA: 0x0026ED34 File Offset: 0x0026DD34
        Friend Overridable Property TabControlArea() As TabControl
            Get
                Return Me._TabControlArea
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._TabControlArea IsNot Nothing Then
                End If
                Me._TabControlArea = value
                If Me._TabControlArea IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000312 RID: 786
        ' (get) Token: 0x060009CD RID: 2509 RVA: 0x0026ED6C File Offset: 0x0026DD6C
        ' (set) Token: 0x060009CC RID: 2508 RVA: 0x0026ED50 File Offset: 0x0026DD50
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

        ' Token: 0x17000313 RID: 787
        ' (get) Token: 0x060009CF RID: 2511 RVA: 0x0026ED9C File Offset: 0x0026DD9C
        ' (set) Token: 0x060009CE RID: 2510 RVA: 0x0026ED80 File Offset: 0x0026DD80
        Friend Overridable Property ColorDialog1() As ColorDialog
            Get
                Return Me._ColorDialog1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ColorDialog)
                If Me._ColorDialog1 IsNot Nothing Then
                End If
                Me._ColorDialog1 = value
                If Me._ColorDialog1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000314 RID: 788
        ' (get) Token: 0x060009D1 RID: 2513 RVA: 0x0026EDB0 File Offset: 0x0026DDB0
        ' (set) Token: 0x060009D0 RID: 2512 RVA: 0x0026EDC4 File Offset: 0x0026DDC4
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

        ' Token: 0x17000315 RID: 789
        ' (get) Token: 0x060009D2 RID: 2514 RVA: 0x0026EDE0 File Offset: 0x0026DDE0
        ' (set) Token: 0x060009D3 RID: 2515 RVA: 0x0026EDF4 File Offset: 0x0026DDF4
        Friend Overridable Property btnGrassDiffuseColor() As Button
            Get
                Return Me._btnGrassDiffuseColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnGrassDiffuseColor IsNot Nothing Then
                    RemoveHandler Me._btnGrassDiffuseColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnGrassDiffuseColor = value
                If Me._btnGrassDiffuseColor IsNot Nothing Then
                    AddHandler Me._btnGrassDiffuseColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x17000316 RID: 790
        ' (get) Token: 0x060009D5 RID: 2517 RVA: 0x0026EE48 File Offset: 0x0026DE48
        ' (set) Token: 0x060009D4 RID: 2516 RVA: 0x0026EE5C File Offset: 0x0026DE5C
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

        ' Token: 0x17000317 RID: 791
        ' (get) Token: 0x060009D7 RID: 2519 RVA: 0x0026EECC File Offset: 0x0026DECC
        ' (set) Token: 0x060009D6 RID: 2518 RVA: 0x0026EE78 File Offset: 0x0026DE78
        Friend Overridable Property btnGrassAmbientColor() As Button
            Get
                Return Me._btnGrassAmbientColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnGrassAmbientColor IsNot Nothing Then
                    RemoveHandler Me._btnGrassAmbientColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnGrassAmbientColor = value
                If Me._btnGrassAmbientColor IsNot Nothing Then
                    AddHandler Me._btnGrassAmbientColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x17000318 RID: 792
        ' (get) Token: 0x060009D8 RID: 2520 RVA: 0x0026EEFC File Offset: 0x0026DEFC
        ' (set) Token: 0x060009D9 RID: 2521 RVA: 0x0026EEE0 File Offset: 0x0026DEE0
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

        ' Token: 0x17000319 RID: 793
        ' (get) Token: 0x060009DB RID: 2523 RVA: 0x0026EF10 File Offset: 0x0026DF10
        ' (set) Token: 0x060009DA RID: 2522 RVA: 0x0026EF24 File Offset: 0x0026DF24
        Friend Overridable Property btnGrassEmissiveColor() As Button
            Get
                Return Me._btnGrassEmissiveColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnGrassEmissiveColor IsNot Nothing Then
                    RemoveHandler Me._btnGrassEmissiveColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnGrassEmissiveColor = value
                If Me._btnGrassEmissiveColor IsNot Nothing Then
                    AddHandler Me._btnGrassEmissiveColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x1700031A RID: 794
        ' (get) Token: 0x060009DC RID: 2524 RVA: 0x0026EF94 File Offset: 0x0026DF94
        ' (set) Token: 0x060009DD RID: 2525 RVA: 0x0026EF78 File Offset: 0x0026DF78
        Friend Overridable Property tabpagAreaBasic() As TabPage
            Get
                Return Me._tabpagAreaBasic
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagAreaBasic IsNot Nothing Then
                End If
                Me._tabpagAreaBasic = value
                If Me._tabpagAreaBasic IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700031B RID: 795
        ' (get) Token: 0x060009DE RID: 2526 RVA: 0x0026EFC4 File Offset: 0x0026DFC4
        ' (set) Token: 0x060009DF RID: 2527 RVA: 0x0026EFA8 File Offset: 0x0026DFA8
        Friend Overridable Property tabpagAreaGrass() As TabPage
            Get
                Return Me._tabpagAreaGrass
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagAreaGrass IsNot Nothing Then
                End If
                Me._tabpagAreaGrass = value
                If Me._tabpagAreaGrass IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700031C RID: 796
        ' (get) Token: 0x060009E0 RID: 2528 RVA: 0x0026EFF4 File Offset: 0x0026DFF4
        ' (set) Token: 0x060009E1 RID: 2529 RVA: 0x0026EFD8 File Offset: 0x0026DFD8
        Friend Overridable Property tabpagAreaEnvironment() As TabPage
            Get
                Return Me._tabpagAreaEnvironment
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagAreaEnvironment IsNot Nothing Then
                End If
                Me._tabpagAreaEnvironment = value
                If Me._tabpagAreaEnvironment IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700031D RID: 797
        ' (get) Token: 0x060009E2 RID: 2530 RVA: 0x0026F008 File Offset: 0x0026E008
        ' (set) Token: 0x060009E3 RID: 2531 RVA: 0x0026F01C File Offset: 0x0026E01C
        Friend Overridable Property btnSunDiffuseColor() As Button
            Get
                Return Me._btnSunDiffuseColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSunDiffuseColor IsNot Nothing Then
                    RemoveHandler Me._btnSunDiffuseColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnSunDiffuseColor = value
                If Me._btnSunDiffuseColor IsNot Nothing Then
                    AddHandler Me._btnSunDiffuseColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x1700031E RID: 798
        ' (get) Token: 0x060009E4 RID: 2532 RVA: 0x0026F070 File Offset: 0x0026E070
        ' (set) Token: 0x060009E5 RID: 2533 RVA: 0x0026F084 File Offset: 0x0026E084
        Friend Overridable Property Label26() As Label
            Get
                Return Me._Label26
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label26 IsNot Nothing Then
                End If
                Me._Label26 = value
                If Me._Label26 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700031F RID: 799
        ' (get) Token: 0x060009E7 RID: 2535 RVA: 0x0026F0A0 File Offset: 0x0026E0A0
        ' (set) Token: 0x060009E6 RID: 2534 RVA: 0x0026F0B4 File Offset: 0x0026E0B4
        Friend Overridable Property Label27() As Label
            Get
                Return Me._Label27
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label27 IsNot Nothing Then
                End If
                Me._Label27 = value
                If Me._Label27 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000320 RID: 800
        ' (get) Token: 0x060009E9 RID: 2537 RVA: 0x0026F0D0 File Offset: 0x0026E0D0
        ' (set) Token: 0x060009E8 RID: 2536 RVA: 0x0026F0E4 File Offset: 0x0026E0E4
        Friend Overridable Property btnSunAmbientColor() As Button
            Get
                Return Me._btnSunAmbientColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSunAmbientColor IsNot Nothing Then
                    RemoveHandler Me._btnSunAmbientColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnSunAmbientColor = value
                If Me._btnSunAmbientColor IsNot Nothing Then
                    AddHandler Me._btnSunAmbientColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x17000321 RID: 801
        ' (get) Token: 0x060009EA RID: 2538 RVA: 0x0026F138 File Offset: 0x0026E138
        ' (set) Token: 0x060009EB RID: 2539 RVA: 0x0026F14C File Offset: 0x0026E14C
        Friend Overridable Property gbSun() As GroupBox
            Get
                Return Me._gbSun
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gbSun IsNot Nothing Then
                End If
                Me._gbSun = value
                If Me._gbSun IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000322 RID: 802
        ' (get) Token: 0x060009EC RID: 2540 RVA: 0x0026F184 File Offset: 0x0026E184
        ' (set) Token: 0x060009ED RID: 2541 RVA: 0x0026F168 File Offset: 0x0026E168
        Friend Overridable Property gbMoon() As GroupBox
            Get
                Return Me._gbMoon
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gbMoon IsNot Nothing Then
                End If
                Me._gbMoon = value
                If Me._gbMoon IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000323 RID: 803
        ' (get) Token: 0x060009EF RID: 2543 RVA: 0x0026F198 File Offset: 0x0026E198
        ' (set) Token: 0x060009EE RID: 2542 RVA: 0x0026F1AC File Offset: 0x0026E1AC
        Friend Overridable Property btnMoonDiffuseColor() As Button
            Get
                Return Me._btnMoonDiffuseColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnMoonDiffuseColor IsNot Nothing Then
                    RemoveHandler Me._btnMoonDiffuseColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnMoonDiffuseColor = value
                If Me._btnMoonDiffuseColor IsNot Nothing Then
                    AddHandler Me._btnMoonDiffuseColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x17000324 RID: 804
        ' (get) Token: 0x060009F0 RID: 2544 RVA: 0x0026F21C File Offset: 0x0026E21C
        ' (set) Token: 0x060009F1 RID: 2545 RVA: 0x0026F200 File Offset: 0x0026E200
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

        ' Token: 0x17000325 RID: 805
        ' (get) Token: 0x060009F2 RID: 2546 RVA: 0x0026F230 File Offset: 0x0026E230
        ' (set) Token: 0x060009F3 RID: 2547 RVA: 0x0026F244 File Offset: 0x0026E244
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

        ' Token: 0x17000326 RID: 806
        ' (get) Token: 0x060009F4 RID: 2548 RVA: 0x0026F260 File Offset: 0x0026E260
        ' (set) Token: 0x060009F5 RID: 2549 RVA: 0x0026F274 File Offset: 0x0026E274
        Friend Overridable Property btnMoonAmbientColor() As Button
            Get
                Return Me._btnMoonAmbientColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnMoonAmbientColor IsNot Nothing Then
                    RemoveHandler Me._btnMoonAmbientColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnMoonAmbientColor = value
                If Me._btnMoonAmbientColor IsNot Nothing Then
                    AddHandler Me._btnMoonAmbientColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x17000327 RID: 807
        ' (get) Token: 0x060009F7 RID: 2551 RVA: 0x0026F31C File Offset: 0x0026E31C
        ' (set) Token: 0x060009F6 RID: 2550 RVA: 0x0026F2C8 File Offset: 0x0026E2C8
        Friend Overridable Property rbDayNightCycle() As RadioButton
            Get
                Return Me._rbDayNightCycle
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbDayNightCycle IsNot Nothing Then
                    RemoveHandler Me._rbDayNightCycle.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
                End If
                Me._rbDayNightCycle = value
                If Me._rbDayNightCycle IsNot Nothing Then
                    AddHandler Me._rbDayNightCycle.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000328 RID: 808
        ' (get) Token: 0x060009F8 RID: 2552 RVA: 0x0026F384 File Offset: 0x0026E384
        ' (set) Token: 0x060009F9 RID: 2553 RVA: 0x0026F330 File Offset: 0x0026E330
        Friend Overridable Property rbAlwaysDay() As RadioButton
            Get
                Return Me._rbAlwaysDay
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbAlwaysDay IsNot Nothing Then
                    RemoveHandler Me._rbAlwaysDay.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
                End If
                Me._rbAlwaysDay = value
                If Me._rbAlwaysDay IsNot Nothing Then
                    AddHandler Me._rbAlwaysDay.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000329 RID: 809
        ' (get) Token: 0x060009FB RID: 2555 RVA: 0x0026F398 File Offset: 0x0026E398
        ' (set) Token: 0x060009FA RID: 2554 RVA: 0x0026F3AC File Offset: 0x0026E3AC
        Friend Overridable Property Label28() As Label
            Get
                Return Me._Label28
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label28 IsNot Nothing Then
                End If
                Me._Label28 = value
                If Me._Label28 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700032A RID: 810
        ' (get) Token: 0x060009FC RID: 2556 RVA: 0x0026F3C8 File Offset: 0x0026E3C8
        ' (set) Token: 0x060009FD RID: 2557 RVA: 0x0026F3DC File Offset: 0x0026E3DC
        Friend Overridable Property Label29() As Label
            Get
                Return Me._Label29
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label29 IsNot Nothing Then
                End If
                Me._Label29 = value
                If Me._Label29 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700032B RID: 811
        ' (get) Token: 0x060009FE RID: 2558 RVA: 0x0026F3F8 File Offset: 0x0026E3F8
        ' (set) Token: 0x060009FF RID: 2559 RVA: 0x0026F40C File Offset: 0x0026E40C
        Friend Overridable Property Label30() As Label
            Get
                Return Me._Label30
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label30 IsNot Nothing Then
                End If
                Me._Label30 = value
                If Me._Label30 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700032C RID: 812
        ' (get) Token: 0x06000A01 RID: 2561 RVA: 0x0026F428 File Offset: 0x0026E428
        ' (set) Token: 0x06000A00 RID: 2560 RVA: 0x0026F43C File Offset: 0x0026E43C
        Friend Overridable Property chkbAreaSunShadows() As CheckBox
            Get
                Return Me._chkbAreaSunShadows
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbAreaSunShadows IsNot Nothing Then
                End If
                Me._chkbAreaSunShadows = value
                If Me._chkbAreaSunShadows IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700032D RID: 813
        ' (get) Token: 0x06000A03 RID: 2563 RVA: 0x0026F474 File Offset: 0x0026E474
        ' (set) Token: 0x06000A02 RID: 2562 RVA: 0x0026F458 File Offset: 0x0026E458
        Friend Overridable Property Label31() As Label
            Get
                Return Me._Label31
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label31 IsNot Nothing Then
                End If
                Me._Label31 = value
                If Me._Label31 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700032E RID: 814
        ' (get) Token: 0x06000A05 RID: 2565 RVA: 0x0026F488 File Offset: 0x0026E488
        ' (set) Token: 0x06000A04 RID: 2564 RVA: 0x0026F49C File Offset: 0x0026E49C
        Friend Overridable Property Label45() As Label
            Get
                Return Me._Label45
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label45 IsNot Nothing Then
                End If
                Me._Label45 = value
                If Me._Label45 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700032F RID: 815
        ' (get) Token: 0x06000A06 RID: 2566 RVA: 0x0026F4B8 File Offset: 0x0026E4B8
        ' (set) Token: 0x06000A07 RID: 2567 RVA: 0x0026F4CC File Offset: 0x0026E4CC
        Friend Overridable Property Label47() As Label
            Get
                Return Me._Label47
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label47 IsNot Nothing Then
                End If
                Me._Label47 = value
                If Me._Label47 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000330 RID: 816
        ' (get) Token: 0x06000A08 RID: 2568 RVA: 0x0026F4E8 File Offset: 0x0026E4E8
        ' (set) Token: 0x06000A09 RID: 2569 RVA: 0x0026F4FC File Offset: 0x0026E4FC
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

        ' Token: 0x17000331 RID: 817
        ' (get) Token: 0x06000A0A RID: 2570 RVA: 0x0026F534 File Offset: 0x0026E534
        ' (set) Token: 0x06000A0B RID: 2571 RVA: 0x0026F518 File Offset: 0x0026E518
        Friend Overridable Property Label49() As Label
            Get
                Return Me._Label49
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label49 IsNot Nothing Then
                End If
                Me._Label49 = value
                If Me._Label49 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000332 RID: 818
        ' (get) Token: 0x06000A0D RID: 2573 RVA: 0x0026F564 File Offset: 0x0026E564
        ' (set) Token: 0x06000A0C RID: 2572 RVA: 0x0026F548 File Offset: 0x0026E548
        Friend Overridable Property Label50() As Label
            Get
                Return Me._Label50
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label50 IsNot Nothing Then
                End If
                Me._Label50 = value
                If Me._Label50 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000333 RID: 819
        ' (get) Token: 0x06000A0F RID: 2575 RVA: 0x0026F578 File Offset: 0x0026E578
        ' (set) Token: 0x06000A0E RID: 2574 RVA: 0x0026F58C File Offset: 0x0026E58C
        Friend Overridable Property Label51() As Label
            Get
                Return Me._Label51
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label51 IsNot Nothing Then
                End If
                Me._Label51 = value
                If Me._Label51 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000334 RID: 820
        ' (get) Token: 0x06000A10 RID: 2576 RVA: 0x0026F5A8 File Offset: 0x0026E5A8
        ' (set) Token: 0x06000A11 RID: 2577 RVA: 0x0026F5BC File Offset: 0x0026E5BC
        Friend Overridable Property tabpagAreaAudio() As TabPage
            Get
                Return Me._tabpagAreaAudio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagAreaAudio IsNot Nothing Then
                End If
                Me._tabpagAreaAudio = value
                If Me._tabpagAreaAudio IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000335 RID: 821
        ' (get) Token: 0x06000A12 RID: 2578 RVA: 0x0026F5F4 File Offset: 0x0026E5F4
        ' (set) Token: 0x06000A13 RID: 2579 RVA: 0x0026F5D8 File Offset: 0x0026E5D8
        Friend Overridable Property Label52() As Label
            Get
                Return Me._Label52
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label52 IsNot Nothing Then
                End If
                Me._Label52 = value
                If Me._Label52 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000336 RID: 822
        ' (get) Token: 0x06000A14 RID: 2580 RVA: 0x0026F624 File Offset: 0x0026E624
        ' (set) Token: 0x06000A15 RID: 2581 RVA: 0x0026F608 File Offset: 0x0026E608
        Friend Overridable Property Label53() As Label
            Get
                Return Me._Label53
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label53 IsNot Nothing Then
                End If
                Me._Label53 = value
                If Me._Label53 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000337 RID: 823
        ' (get) Token: 0x06000A16 RID: 2582 RVA: 0x0026F638 File Offset: 0x0026E638
        ' (set) Token: 0x06000A17 RID: 2583 RVA: 0x0026F64C File Offset: 0x0026E64C
        Friend Overridable Property Label54() As Label
            Get
                Return Me._Label54
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label54 IsNot Nothing Then
                End If
                Me._Label54 = value
                If Me._Label54 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000338 RID: 824
        ' (get) Token: 0x06000A18 RID: 2584 RVA: 0x0026F668 File Offset: 0x0026E668
        ' (set) Token: 0x06000A19 RID: 2585 RVA: 0x0026F67C File Offset: 0x0026E67C
        Friend Overridable Property Label55() As Label
            Get
                Return Me._Label55
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label55 IsNot Nothing Then
                End If
                Me._Label55 = value
                If Me._Label55 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000339 RID: 825
        ' (get) Token: 0x06000A1B RID: 2587 RVA: 0x0026F698 File Offset: 0x0026E698
        ' (set) Token: 0x06000A1A RID: 2586 RVA: 0x0026F6AC File Offset: 0x0026E6AC
        Friend Overridable Property Label56() As Label
            Get
                Return Me._Label56
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label56 IsNot Nothing Then
                End If
                Me._Label56 = value
                If Me._Label56 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700033A RID: 826
        ' (get) Token: 0x06000A1C RID: 2588 RVA: 0x0026F6C8 File Offset: 0x0026E6C8
        ' (set) Token: 0x06000A1D RID: 2589 RVA: 0x0026F6DC File Offset: 0x0026E6DC
        Friend Overridable Property Label57() As Label
            Get
                Return Me._Label57
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label57 IsNot Nothing Then
                End If
                Me._Label57 = value
                If Me._Label57 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700033B RID: 827
        ' (get) Token: 0x06000A1F RID: 2591 RVA: 0x0026F6F8 File Offset: 0x0026E6F8
        ' (set) Token: 0x06000A1E RID: 2590 RVA: 0x0026F70C File Offset: 0x0026E70C
        Friend Overridable Property Label58() As Label
            Get
                Return Me._Label58
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label58 IsNot Nothing Then
                End If
                Me._Label58 = value
                If Me._Label58 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700033C RID: 828
        ' (get) Token: 0x06000A21 RID: 2593 RVA: 0x0026F744 File Offset: 0x0026E744
        ' (set) Token: 0x06000A20 RID: 2592 RVA: 0x0026F728 File Offset: 0x0026E728
        Friend Overridable Property Label59() As Label
            Get
                Return Me._Label59
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label59 IsNot Nothing Then
                End If
                Me._Label59 = value
                If Me._Label59 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700033D RID: 829
        ' (get) Token: 0x06000A22 RID: 2594 RVA: 0x0026F758 File Offset: 0x0026E758
        ' (set) Token: 0x06000A23 RID: 2595 RVA: 0x0026F76C File Offset: 0x0026E76C
        Friend Overridable Property Label60() As Label
            Get
                Return Me._Label60
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label60 IsNot Nothing Then
                End If
                Me._Label60 = value
                If Me._Label60 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700033E RID: 830
        ' (get) Token: 0x06000A25 RID: 2597 RVA: 0x0026F7A4 File Offset: 0x0026E7A4
        ' (set) Token: 0x06000A24 RID: 2596 RVA: 0x0026F788 File Offset: 0x0026E788
        Friend Overridable Property Label61() As Label
            Get
                Return Me._Label61
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label61 IsNot Nothing Then
                End If
                Me._Label61 = value
                If Me._Label61 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700033F RID: 831
        ' (get) Token: 0x06000A26 RID: 2598 RVA: 0x0026F7D4 File Offset: 0x0026E7D4
        ' (set) Token: 0x06000A27 RID: 2599 RVA: 0x0026F7B8 File Offset: 0x0026E7B8
        Friend Overridable Property tabpagModuleBasic() As TabPage
            Get
                Return Me._tabpagModuleBasic
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagModuleBasic IsNot Nothing Then
                End If
                Me._tabpagModuleBasic = value
                If Me._tabpagModuleBasic IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000340 RID: 832
        ' (get) Token: 0x06000A29 RID: 2601 RVA: 0x0026F7E8 File Offset: 0x0026E7E8
        ' (set) Token: 0x06000A28 RID: 2600 RVA: 0x0026F7FC File Offset: 0x0026E7FC
        Friend Overridable Property tabpagModuleAdvanced() As TabPage
            Get
                Return Me._tabpagModuleAdvanced
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagModuleAdvanced IsNot Nothing Then
                End If
                Me._tabpagModuleAdvanced = value
                If Me._tabpagModuleAdvanced IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000341 RID: 833
        ' (get) Token: 0x06000A2A RID: 2602 RVA: 0x0026F834 File Offset: 0x0026E834
        ' (set) Token: 0x06000A2B RID: 2603 RVA: 0x0026F818 File Offset: 0x0026E818
        Friend Overridable Property tabpagModuleEvents() As TabPage
            Get
                Return Me._tabpagModuleEvents
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagModuleEvents IsNot Nothing Then
                End If
                Me._tabpagModuleEvents = value
                If Me._tabpagModuleEvents IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000342 RID: 834
        ' (get) Token: 0x06000A2D RID: 2605 RVA: 0x0026F864 File Offset: 0x0026E864
        ' (set) Token: 0x06000A2C RID: 2604 RVA: 0x0026F848 File Offset: 0x0026E848
        Friend Overridable Property tabpagModuleDescription() As TabPage
            Get
                Return Me._tabpagModuleDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagModuleDescription IsNot Nothing Then
                End If
                Me._tabpagModuleDescription = value
                If Me._tabpagModuleDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000343 RID: 835
        ' (get) Token: 0x06000A2E RID: 2606 RVA: 0x0026F878 File Offset: 0x0026E878
        ' (set) Token: 0x06000A2F RID: 2607 RVA: 0x0026F88C File Offset: 0x0026E88C
        Friend Overridable Property nudModEntryX() As NumericUpDown
            Get
                Return Me._nudModEntryX
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudModEntryX IsNot Nothing Then
                End If
                Me._nudModEntryX = value
                If Me._nudModEntryX IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000344 RID: 836
        ' (get) Token: 0x06000A31 RID: 2609 RVA: 0x0026F8A8 File Offset: 0x0026E8A8
        ' (set) Token: 0x06000A30 RID: 2608 RVA: 0x0026F8BC File Offset: 0x0026E8BC
        Friend Overridable Property nudModEntryY() As NumericUpDown
            Get
                Return Me._nudModEntryY
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudModEntryY IsNot Nothing Then
                End If
                Me._nudModEntryY = value
                If Me._nudModEntryY IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000345 RID: 837
        ' (get) Token: 0x06000A33 RID: 2611 RVA: 0x0026F8D8 File Offset: 0x0026E8D8
        ' (set) Token: 0x06000A32 RID: 2610 RVA: 0x0026F8EC File Offset: 0x0026E8EC
        Friend Overridable Property nudModEntryZ() As NumericUpDown
            Get
                Return Me._nudModEntryZ
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudModEntryZ IsNot Nothing Then
                End If
                Me._nudModEntryZ = value
                If Me._nudModEntryZ IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000346 RID: 838
        ' (get) Token: 0x06000A34 RID: 2612 RVA: 0x0026F924 File Offset: 0x0026E924
        ' (set) Token: 0x06000A35 RID: 2613 RVA: 0x0026F908 File Offset: 0x0026E908
        Friend Overridable Property tbModTag() As TextBox
            Get
                Return Me._tbModTag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbModTag IsNot Nothing Then
                End If
                Me._tbModTag = value
                If Me._tbModTag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000347 RID: 839
        ' (get) Token: 0x06000A36 RID: 2614 RVA: 0x0026F938 File Offset: 0x0026E938
        ' (set) Token: 0x06000A37 RID: 2615 RVA: 0x0026F94C File Offset: 0x0026E94C
        Friend Overridable Property tbModName() As TextBox
            Get
                Return Me._tbModName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbModName IsNot Nothing Then
                End If
                Me._tbModName = value
                If Me._tbModName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000348 RID: 840
        ' (get) Token: 0x06000A39 RID: 2617 RVA: 0x0026F968 File Offset: 0x0026E968
        ' (set) Token: 0x06000A38 RID: 2616 RVA: 0x0026F97C File Offset: 0x0026E97C
        Friend Overridable Property nudMinutesPerHour() As NumericUpDown
            Get
                Return Me._nudMinutesPerHour
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudMinutesPerHour IsNot Nothing Then
                End If
                Me._nudMinutesPerHour = value
                If Me._nudMinutesPerHour IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000349 RID: 841
        ' (get) Token: 0x06000A3A RID: 2618 RVA: 0x0026F998 File Offset: 0x0026E998
        ' (set) Token: 0x06000A3B RID: 2619 RVA: 0x0026F9AC File Offset: 0x0026E9AC
        Friend Overridable Property nudDawnStartHour() As NumericUpDown
            Get
                Return Me._nudDawnStartHour
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudDawnStartHour IsNot Nothing Then
                End If
                Me._nudDawnStartHour = value
                If Me._nudDawnStartHour IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700034A RID: 842
        ' (get) Token: 0x06000A3C RID: 2620 RVA: 0x0026F9C8 File Offset: 0x0026E9C8
        ' (set) Token: 0x06000A3D RID: 2621 RVA: 0x0026F9DC File Offset: 0x0026E9DC
        Friend Overridable Property nudDuskStartHour() As NumericUpDown
            Get
                Return Me._nudDuskStartHour
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudDuskStartHour IsNot Nothing Then
                End If
                Me._nudDuskStartHour = value
                If Me._nudDuskStartHour IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700034B RID: 843
        ' (get) Token: 0x06000A3E RID: 2622 RVA: 0x0026F9F8 File Offset: 0x0026E9F8
        ' (set) Token: 0x06000A3F RID: 2623 RVA: 0x0026FA0C File Offset: 0x0026EA0C
        Friend Overridable Property nudStartHour() As NumericUpDown
            Get
                Return Me._nudStartHour
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudStartHour IsNot Nothing Then
                End If
                Me._nudStartHour = value
                If Me._nudStartHour IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700034C RID: 844
        ' (get) Token: 0x06000A41 RID: 2625 RVA: 0x0026FA44 File Offset: 0x0026EA44
        ' (set) Token: 0x06000A40 RID: 2624 RVA: 0x0026FA28 File Offset: 0x0026EA28
        Friend Overridable Property nudStartDay() As NumericUpDown
            Get
                Return Me._nudStartDay
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudStartDay IsNot Nothing Then
                End If
                Me._nudStartDay = value
                If Me._nudStartDay IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700034D RID: 845
        ' (get) Token: 0x06000A43 RID: 2627 RVA: 0x0026FA58 File Offset: 0x0026EA58
        ' (set) Token: 0x06000A42 RID: 2626 RVA: 0x0026FA6C File Offset: 0x0026EA6C
        Friend Overridable Property nudStartMonth() As NumericUpDown
            Get
                Return Me._nudStartMonth
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudStartMonth IsNot Nothing Then
                End If
                Me._nudStartMonth = value
                If Me._nudStartMonth IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700034E RID: 846
        ' (get) Token: 0x06000A44 RID: 2628 RVA: 0x0026FA88 File Offset: 0x0026EA88
        ' (set) Token: 0x06000A45 RID: 2629 RVA: 0x0026FA9C File Offset: 0x0026EA9C
        Friend Overridable Property nudStartYear() As NumericUpDown
            Get
                Return Me._nudStartYear
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudStartYear IsNot Nothing Then
                End If
                Me._nudStartYear = value
                If Me._nudStartYear IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700034F RID: 847
        ' (get) Token: 0x06000A47 RID: 2631 RVA: 0x0026FAB8 File Offset: 0x0026EAB8
        ' (set) Token: 0x06000A46 RID: 2630 RVA: 0x0026FACC File Offset: 0x0026EACC
        Friend Overridable Property tbMod_OnClientEntr() As TextBox
            Get
                Return Me._tbMod_OnClientEntr
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnClientEntr IsNot Nothing Then
                End If
                Me._tbMod_OnClientEntr = value
                If Me._tbMod_OnClientEntr IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000350 RID: 848
        ' (get) Token: 0x06000A49 RID: 2633 RVA: 0x0026FB04 File Offset: 0x0026EB04
        ' (set) Token: 0x06000A48 RID: 2632 RVA: 0x0026FAE8 File Offset: 0x0026EAE8
        Friend Overridable Property tbMod_OnActvtItem() As TextBox
            Get
                Return Me._tbMod_OnActvtItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnActvtItem IsNot Nothing Then
                End If
                Me._tbMod_OnActvtItem = value
                If Me._tbMod_OnActvtItem IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000351 RID: 849
        ' (get) Token: 0x06000A4B RID: 2635 RVA: 0x0026FB34 File Offset: 0x0026EB34
        ' (set) Token: 0x06000A4A RID: 2634 RVA: 0x0026FB18 File Offset: 0x0026EB18
        Friend Overridable Property tbMod_OnAcquirItem() As TextBox
            Get
                Return Me._tbMod_OnAcquirItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnAcquirItem IsNot Nothing Then
                End If
                Me._tbMod_OnAcquirItem = value
                If Me._tbMod_OnAcquirItem IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000352 RID: 850
        ' (get) Token: 0x06000A4C RID: 2636 RVA: 0x0026FB64 File Offset: 0x0026EB64
        ' (set) Token: 0x06000A4D RID: 2637 RVA: 0x0026FB48 File Offset: 0x0026EB48
        Friend Overridable Property tbMod_OnClientLeav() As TextBox
            Get
                Return Me._tbMod_OnClientLeav
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnClientLeav IsNot Nothing Then
                End If
                Me._tbMod_OnClientLeav = value
                If Me._tbMod_OnClientLeav IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000353 RID: 851
        ' (get) Token: 0x06000A4E RID: 2638 RVA: 0x0026FB78 File Offset: 0x0026EB78
        ' (set) Token: 0x06000A4F RID: 2639 RVA: 0x0026FB8C File Offset: 0x0026EB8C
        Friend Overridable Property tbMod_OnHeartbeat() As TextBox
            Get
                Return Me._tbMod_OnHeartbeat
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnHeartbeat IsNot Nothing Then
                End If
                Me._tbMod_OnHeartbeat = value
                If Me._tbMod_OnHeartbeat IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000354 RID: 852
        ' (get) Token: 0x06000A50 RID: 2640 RVA: 0x0026FBA8 File Offset: 0x0026EBA8
        ' (set) Token: 0x06000A51 RID: 2641 RVA: 0x0026FBBC File Offset: 0x0026EBBC
        Friend Overridable Property tbMod_OnModLoad() As TextBox
            Get
                Return Me._tbMod_OnModLoad
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnModLoad IsNot Nothing Then
                End If
                Me._tbMod_OnModLoad = value
                If Me._tbMod_OnModLoad IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000355 RID: 853
        ' (get) Token: 0x06000A52 RID: 2642 RVA: 0x0026FBD8 File Offset: 0x0026EBD8
        ' (set) Token: 0x06000A53 RID: 2643 RVA: 0x0026FBEC File Offset: 0x0026EBEC
        Friend Overridable Property btnMoonFogColor() As Button
            Get
                Return Me._btnMoonFogColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnMoonFogColor IsNot Nothing Then
                    RemoveHandler Me._btnMoonFogColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnMoonFogColor = value
                If Me._btnMoonFogColor IsNot Nothing Then
                    AddHandler Me._btnMoonFogColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x17000356 RID: 854
        ' (get) Token: 0x06000A55 RID: 2645 RVA: 0x0026FC40 File Offset: 0x0026EC40
        ' (set) Token: 0x06000A54 RID: 2644 RVA: 0x0026FC54 File Offset: 0x0026EC54
        Friend Overridable Property chkbAreaMoonShadows() As CheckBox
            Get
                Return Me._chkbAreaMoonShadows
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbAreaMoonShadows IsNot Nothing Then
                End If
                Me._chkbAreaMoonShadows = value
                If Me._chkbAreaMoonShadows IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000357 RID: 855
        ' (get) Token: 0x06000A57 RID: 2647 RVA: 0x0026FC70 File Offset: 0x0026EC70
        ' (set) Token: 0x06000A56 RID: 2646 RVA: 0x0026FC84 File Offset: 0x0026EC84
        Friend Overridable Property btnSunFogColor() As Button
            Get
                Return Me._btnSunFogColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSunFogColor IsNot Nothing Then
                    RemoveHandler Me._btnSunFogColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnSunFogColor = value
                If Me._btnSunFogColor IsNot Nothing Then
                    AddHandler Me._btnSunFogColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x17000358 RID: 856
        ' (get) Token: 0x06000A58 RID: 2648 RVA: 0x0026FCD8 File Offset: 0x0026ECD8
        ' (set) Token: 0x06000A59 RID: 2649 RVA: 0x0026FCEC File Offset: 0x0026ECEC
        Friend Overridable Property rbAlwaysNight() As RadioButton
            Get
                Return Me._rbAlwaysNight
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbAlwaysNight IsNot Nothing Then
                    RemoveHandler Me._rbAlwaysNight.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
                End If
                Me._rbAlwaysNight = value
                If Me._rbAlwaysNight IsNot Nothing Then
                    AddHandler Me._rbAlwaysNight.CheckedChanged, AddressOf Me.DayNight_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000359 RID: 857
        ' (get) Token: 0x06000A5B RID: 2651 RVA: 0x0026FD5C File Offset: 0x0026ED5C
        ' (set) Token: 0x06000A5A RID: 2650 RVA: 0x0026FD40 File Offset: 0x0026ED40
        Friend Overridable Property tbMod_OnPlrDeath() As TextBox
            Get
                Return Me._tbMod_OnPlrDeath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnPlrDeath IsNot Nothing Then
                End If
                Me._tbMod_OnPlrDeath = value
                If Me._tbMod_OnPlrDeath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700035A RID: 858
        ' (get) Token: 0x06000A5D RID: 2653 RVA: 0x0026FD70 File Offset: 0x0026ED70
        ' (set) Token: 0x06000A5C RID: 2652 RVA: 0x0026FD84 File Offset: 0x0026ED84
        Friend Overridable Property tbMod_OnPlrDying() As TextBox
            Get
                Return Me._tbMod_OnPlrDying
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnPlrDying IsNot Nothing Then
                End If
                Me._tbMod_OnPlrDying = value
                If Me._tbMod_OnPlrDying IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700035B RID: 859
        ' (get) Token: 0x06000A5F RID: 2655 RVA: 0x0026FDBC File Offset: 0x0026EDBC
        ' (set) Token: 0x06000A5E RID: 2654 RVA: 0x0026FDA0 File Offset: 0x0026EDA0
        Friend Overridable Property tbMod_OnPlrLvlUp() As TextBox
            Get
                Return Me._tbMod_OnPlrLvlUp
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnPlrLvlUp IsNot Nothing Then
                End If
                Me._tbMod_OnPlrLvlUp = value
                If Me._tbMod_OnPlrLvlUp IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700035C RID: 860
        ' (get) Token: 0x06000A61 RID: 2657 RVA: 0x0026FDEC File Offset: 0x0026EDEC
        ' (set) Token: 0x06000A60 RID: 2656 RVA: 0x0026FDD0 File Offset: 0x0026EDD0
        Friend Overridable Property tbMod_OnSpawnBtnDn() As TextBox
            Get
                Return Me._tbMod_OnSpawnBtnDn
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnSpawnBtnDn IsNot Nothing Then
                End If
                Me._tbMod_OnSpawnBtnDn = value
                If Me._tbMod_OnSpawnBtnDn IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700035D RID: 861
        ' (get) Token: 0x06000A62 RID: 2658 RVA: 0x0026FE00 File Offset: 0x0026EE00
        ' (set) Token: 0x06000A63 RID: 2659 RVA: 0x0026FE14 File Offset: 0x0026EE14
        Friend Overridable Property tbMod_OnPlrRest() As TextBox
            Get
                Return Me._tbMod_OnPlrRest
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnPlrRest IsNot Nothing Then
                End If
                Me._tbMod_OnPlrRest = value
                If Me._tbMod_OnPlrRest IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700035E RID: 862
        ' (get) Token: 0x06000A64 RID: 2660 RVA: 0x0026FE30 File Offset: 0x0026EE30
        ' (set) Token: 0x06000A65 RID: 2661 RVA: 0x0026FE44 File Offset: 0x0026EE44
        Friend Overridable Property tbMod_OnUnAqreItem() As TextBox
            Get
                Return Me._tbMod_OnUnAqreItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnUnAqreItem IsNot Nothing Then
                End If
                Me._tbMod_OnUnAqreItem = value
                If Me._tbMod_OnUnAqreItem IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700035F RID: 863
        ' (get) Token: 0x06000A66 RID: 2662 RVA: 0x0026FE60 File Offset: 0x0026EE60
        ' (set) Token: 0x06000A67 RID: 2663 RVA: 0x0026FE74 File Offset: 0x0026EE74
        Friend Overridable Property tbMod_OnUsrDefined() As TextBox
            Get
                Return Me._tbMod_OnUsrDefined
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMod_OnUsrDefined IsNot Nothing Then
                End If
                Me._tbMod_OnUsrDefined = value
                If Me._tbMod_OnUsrDefined IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000360 RID: 864
        ' (get) Token: 0x06000A68 RID: 2664 RVA: 0x0026FEE4 File Offset: 0x0026EEE4
        ' (set) Token: 0x06000A69 RID: 2665 RVA: 0x0026FE90 File Offset: 0x0026EE90
        Friend Overridable Property chkbSunFogOn() As CheckBox
            Get
                Return Me._chkbSunFogOn
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbSunFogOn IsNot Nothing Then
                    RemoveHandler Me._chkbSunFogOn.CheckedChanged, AddressOf Me.SunFogEnabled
                End If
                Me._chkbSunFogOn = value
                If Me._chkbSunFogOn IsNot Nothing Then
                    AddHandler Me._chkbSunFogOn.CheckedChanged, AddressOf Me.SunFogEnabled
                End If
            End Set
        End Property

        ' Token: 0x17000361 RID: 865
        ' (get) Token: 0x06000A6B RID: 2667 RVA: 0x0026FF4C File Offset: 0x0026EF4C
        ' (set) Token: 0x06000A6A RID: 2666 RVA: 0x0026FEF8 File Offset: 0x0026EEF8
        Friend Overridable Property chkbMoonFogOn() As CheckBox
            Get
                Return Me._chkbMoonFogOn
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbMoonFogOn IsNot Nothing Then
                    RemoveHandler Me._chkbMoonFogOn.CheckedChanged, AddressOf Me.MoonFogEnabled
                End If
                Me._chkbMoonFogOn = value
                If Me._chkbMoonFogOn IsNot Nothing Then
                    AddHandler Me._chkbMoonFogOn.CheckedChanged, AddressOf Me.MoonFogEnabled
                End If
            End Set
        End Property

        ' Token: 0x17000362 RID: 866
        ' (get) Token: 0x06000A6C RID: 2668 RVA: 0x0026FF60 File Offset: 0x0026EF60
        ' (set) Token: 0x06000A6D RID: 2669 RVA: 0x0026FF74 File Offset: 0x0026EF74
        Friend Overridable Property trkbarSunFogNear() As TrackBar
            Get
                Return Me._trkbarSunFogNear
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarSunFogNear IsNot Nothing Then
                End If
                Me._trkbarSunFogNear = value
                If Me._trkbarSunFogNear IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000363 RID: 867
        ' (get) Token: 0x06000A6E RID: 2670 RVA: 0x0026FF90 File Offset: 0x0026EF90
        ' (set) Token: 0x06000A6F RID: 2671 RVA: 0x0026FFA4 File Offset: 0x0026EFA4
        Friend Overridable Property trkbarSunFogFar() As TrackBar
            Get
                Return Me._trkbarSunFogFar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarSunFogFar IsNot Nothing Then
                End If
                Me._trkbarSunFogFar = value
                If Me._trkbarSunFogFar IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000364 RID: 868
        ' (get) Token: 0x06000A70 RID: 2672 RVA: 0x0026FFDC File Offset: 0x0026EFDC
        ' (set) Token: 0x06000A71 RID: 2673 RVA: 0x0026FFC0 File Offset: 0x0026EFC0
        Friend Overridable Property trkbarMoonFogNear() As TrackBar
            Get
                Return Me._trkbarMoonFogNear
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarMoonFogNear IsNot Nothing Then
                End If
                Me._trkbarMoonFogNear = value
                If Me._trkbarMoonFogNear IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000365 RID: 869
        ' (get) Token: 0x06000A72 RID: 2674 RVA: 0x0026FFF0 File Offset: 0x0026EFF0
        ' (set) Token: 0x06000A73 RID: 2675 RVA: 0x00270004 File Offset: 0x0026F004
        Friend Overridable Property trkbarMoonFogFar() As TrackBar
            Get
                Return Me._trkbarMoonFogFar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarMoonFogFar IsNot Nothing Then
                End If
                Me._trkbarMoonFogFar = value
                If Me._trkbarMoonFogFar IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000366 RID: 870
        ' (get) Token: 0x06000A74 RID: 2676 RVA: 0x0027003C File Offset: 0x0026F03C
        ' (set) Token: 0x06000A75 RID: 2677 RVA: 0x00270020 File Offset: 0x0026F020
        Friend Overridable Property nudChanceSnow() As NumericUpDown
            Get
                Return Me._nudChanceSnow
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudChanceSnow IsNot Nothing Then
                End If
                Me._nudChanceSnow = value
                If Me._nudChanceSnow IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000367 RID: 871
        ' (get) Token: 0x06000A77 RID: 2679 RVA: 0x00270050 File Offset: 0x0026F050
        ' (set) Token: 0x06000A76 RID: 2678 RVA: 0x00270064 File Offset: 0x0026F064
        Friend Overridable Property nudChanceRain() As NumericUpDown
            Get
                Return Me._nudChanceRain
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudChanceRain IsNot Nothing Then
                End If
                Me._nudChanceRain = value
                If Me._nudChanceRain IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000368 RID: 872
        ' (get) Token: 0x06000A79 RID: 2681 RVA: 0x0027009C File Offset: 0x0026F09C
        ' (set) Token: 0x06000A78 RID: 2680 RVA: 0x00270080 File Offset: 0x0026F080
        Friend Overridable Property nudChanceLightning() As NumericUpDown
            Get
                Return Me._nudChanceLightning
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudChanceLightning IsNot Nothing Then
                End If
                Me._nudChanceLightning = value
                If Me._nudChanceLightning IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000369 RID: 873
        ' (get) Token: 0x06000A7B RID: 2683 RVA: 0x002700B0 File Offset: 0x0026F0B0
        ' (set) Token: 0x06000A7A RID: 2682 RVA: 0x002700C4 File Offset: 0x0026F0C4
        Friend Overridable Property btnDynAmbientColor() As Button
            Get
                Return Me._btnDynAmbientColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnDynAmbientColor IsNot Nothing Then
                    RemoveHandler Me._btnDynAmbientColor.Click, AddressOf Me.SetColor_Click
                End If
                Me._btnDynAmbientColor = value
                If Me._btnDynAmbientColor IsNot Nothing Then
                    AddHandler Me._btnDynAmbientColor.Click, AddressOf Me.SetColor_Click
                End If
            End Set
        End Property

        ' Token: 0x1700036A RID: 874
        ' (get) Token: 0x06000A7C RID: 2684 RVA: 0x00270134 File Offset: 0x0026F134
        ' (set) Token: 0x06000A7D RID: 2685 RVA: 0x00270118 File Offset: 0x0026F118
        Friend Overridable Property Label48() As Label
            Get
                Return Me._Label48
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label48 IsNot Nothing Then
                End If
                Me._Label48 = value
                If Me._Label48 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700036B RID: 875
        ' (get) Token: 0x06000A7F RID: 2687 RVA: 0x00270164 File Offset: 0x0026F164
        ' (set) Token: 0x06000A7E RID: 2686 RVA: 0x00270148 File Offset: 0x0026F148
        Friend Overridable Property lblMoonFogNear() As Label
            Get
                Return Me._lblMoonFogNear
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblMoonFogNear IsNot Nothing Then
                End If
                Me._lblMoonFogNear = value
                If Me._lblMoonFogNear IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700036C RID: 876
        ' (get) Token: 0x06000A81 RID: 2689 RVA: 0x00270194 File Offset: 0x0026F194
        ' (set) Token: 0x06000A80 RID: 2688 RVA: 0x00270178 File Offset: 0x0026F178
        Friend Overridable Property lblMoonFogFar() As Label
            Get
                Return Me._lblMoonFogFar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblMoonFogFar IsNot Nothing Then
                End If
                Me._lblMoonFogFar = value
                If Me._lblMoonFogFar IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700036D RID: 877
        ' (get) Token: 0x06000A83 RID: 2691 RVA: 0x002701C4 File Offset: 0x0026F1C4
        ' (set) Token: 0x06000A82 RID: 2690 RVA: 0x002701A8 File Offset: 0x0026F1A8
        Friend Overridable Property lblSunFogNear() As Label
            Get
                Return Me._lblSunFogNear
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblSunFogNear IsNot Nothing Then
                End If
                Me._lblSunFogNear = value
                If Me._lblSunFogNear IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700036E RID: 878
        ' (get) Token: 0x06000A85 RID: 2693 RVA: 0x002701D8 File Offset: 0x0026F1D8
        ' (set) Token: 0x06000A84 RID: 2692 RVA: 0x002701EC File Offset: 0x0026F1EC
        Friend Overridable Property lblSunFogFar() As Label
            Get
                Return Me._lblSunFogFar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblSunFogFar IsNot Nothing Then
                End If
                Me._lblSunFogFar = value
                If Me._lblSunFogFar IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700036F RID: 879
        ' (get) Token: 0x06000A86 RID: 2694 RVA: 0x00270208 File Offset: 0x0026F208
        ' (set) Token: 0x06000A87 RID: 2695 RVA: 0x0027021C File Offset: 0x0026F21C
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

        ' Token: 0x17000370 RID: 880
        ' (get) Token: 0x06000A89 RID: 2697 RVA: 0x00270238 File Offset: 0x0026F238
        ' (set) Token: 0x06000A88 RID: 2696 RVA: 0x0027024C File Offset: 0x0026F24C
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

        ' Token: 0x17000371 RID: 881
        ' (get) Token: 0x06000A8B RID: 2699 RVA: 0x00270284 File Offset: 0x0026F284
        ' (set) Token: 0x06000A8A RID: 2698 RVA: 0x00270268 File Offset: 0x0026F268
        Friend Overridable Property trkbarAmbientSndDayVol() As TrackBar
            Get
                Return Me._trkbarAmbientSndDayVol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarAmbientSndDayVol IsNot Nothing Then
                End If
                Me._trkbarAmbientSndDayVol = value
                If Me._trkbarAmbientSndDayVol IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000372 RID: 882
        ' (get) Token: 0x06000A8C RID: 2700 RVA: 0x002702B4 File Offset: 0x0026F2B4
        ' (set) Token: 0x06000A8D RID: 2701 RVA: 0x00270298 File Offset: 0x0026F298
        Friend Overridable Property cmbxAmbientSndDay() As ComboBox
            Get
                Return Me._cmbxAmbientSndDay
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxAmbientSndDay IsNot Nothing Then
                End If
                Me._cmbxAmbientSndDay = value
                If Me._cmbxAmbientSndDay IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000373 RID: 883
        ' (get) Token: 0x06000A8E RID: 2702 RVA: 0x002702E4 File Offset: 0x0026F2E4
        ' (set) Token: 0x06000A8F RID: 2703 RVA: 0x002702C8 File Offset: 0x0026F2C8
        Friend Overridable Property trkbarAmbientSndNightVol() As TrackBar
            Get
                Return Me._trkbarAmbientSndNightVol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarAmbientSndNightVol IsNot Nothing Then
                End If
                Me._trkbarAmbientSndNightVol = value
                If Me._trkbarAmbientSndNightVol IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000374 RID: 884
        ' (get) Token: 0x06000A91 RID: 2705 RVA: 0x002702F8 File Offset: 0x0026F2F8
        ' (set) Token: 0x06000A90 RID: 2704 RVA: 0x0027030C File Offset: 0x0026F30C
        Friend Overridable Property nudMusicDelay() As NumericUpDown
            Get
                Return Me._nudMusicDelay
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudMusicDelay IsNot Nothing Then
                End If
                Me._nudMusicDelay = value
                If Me._nudMusicDelay IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000375 RID: 885
        ' (get) Token: 0x06000A92 RID: 2706 RVA: 0x00270328 File Offset: 0x0026F328
        ' (set) Token: 0x06000A93 RID: 2707 RVA: 0x0027033C File Offset: 0x0026F33C
        Friend Overridable Property cmbxMusicNight() As ComboBox
            Get
                Return Me._cmbxMusicNight
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxMusicNight IsNot Nothing Then
                End If
                Me._cmbxMusicNight = value
                If Me._cmbxMusicNight IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000376 RID: 886
        ' (get) Token: 0x06000A95 RID: 2709 RVA: 0x00270358 File Offset: 0x0026F358
        ' (set) Token: 0x06000A94 RID: 2708 RVA: 0x0027036C File Offset: 0x0026F36C
        Friend Overridable Property cmbxMusicDay() As ComboBox
            Get
                Return Me._cmbxMusicDay
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxMusicDay IsNot Nothing Then
                End If
                Me._cmbxMusicDay = value
                If Me._cmbxMusicDay IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000377 RID: 887
        ' (get) Token: 0x06000A96 RID: 2710 RVA: 0x00270388 File Offset: 0x0026F388
        ' (set) Token: 0x06000A97 RID: 2711 RVA: 0x0027039C File Offset: 0x0026F39C
        Friend Overridable Property cmbxMusicBattle() As ComboBox
            Get
                Return Me._cmbxMusicBattle
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxMusicBattle IsNot Nothing Then
                End If
                Me._cmbxMusicBattle = value
                If Me._cmbxMusicBattle IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000378 RID: 888
        ' (get) Token: 0x06000A98 RID: 2712 RVA: 0x002703B8 File Offset: 0x0026F3B8
        ' (set) Token: 0x06000A99 RID: 2713 RVA: 0x002703CC File Offset: 0x0026F3CC
        Friend Overridable Property cmbxEnvAudio() As ComboBox
            Get
                Return Me._cmbxEnvAudio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxEnvAudio IsNot Nothing Then
                End If
                Me._cmbxEnvAudio = value
                If Me._cmbxEnvAudio IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000379 RID: 889
        ' (get) Token: 0x06000A9A RID: 2714 RVA: 0x00270404 File Offset: 0x0026F404
        ' (set) Token: 0x06000A9B RID: 2715 RVA: 0x002703E8 File Offset: 0x0026F3E8
        Friend Overridable Property cmbxAmbientSndNight() As ComboBox
            Get
                Return Me._cmbxAmbientSndNight
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxAmbientSndNight IsNot Nothing Then
                End If
                Me._cmbxAmbientSndNight = value
                If Me._cmbxAmbientSndNight IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700037A RID: 890
        ' (get) Token: 0x06000A9D RID: 2717 RVA: 0x00270434 File Offset: 0x0026F434
        ' (set) Token: 0x06000A9C RID: 2716 RVA: 0x00270418 File Offset: 0x0026F418
        Friend Overridable Property tbGrass_TexName() As TextBox
            Get
                Return Me._tbGrass_TexName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbGrass_TexName IsNot Nothing Then
                End If
                Me._tbGrass_TexName = value
                If Me._tbGrass_TexName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700037B RID: 891
        ' (get) Token: 0x06000A9F RID: 2719 RVA: 0x0027049C File Offset: 0x0026F49C
        ' (set) Token: 0x06000A9E RID: 2718 RVA: 0x00270448 File Offset: 0x0026F448
        Friend Overridable Property trkbarGrassDensityX10() As TrackBar
            Get
                Return Me._trkbarGrassDensityX10
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarGrassDensityX10 IsNot Nothing Then
                    RemoveHandler Me._trkbarGrassDensityX10.Scroll, AddressOf Me.trkbarGrassDensityX10_Scroll
                End If
                Me._trkbarGrassDensityX10 = value
                If Me._trkbarGrassDensityX10 IsNot Nothing Then
                    AddHandler Me._trkbarGrassDensityX10.Scroll, AddressOf Me.trkbarGrassDensityX10_Scroll
                End If
            End Set
        End Property

        ' Token: 0x1700037C RID: 892
        ' (get) Token: 0x06000AA1 RID: 2721 RVA: 0x002704B0 File Offset: 0x0026F4B0
        ' (set) Token: 0x06000AA0 RID: 2720 RVA: 0x002704C4 File Offset: 0x0026F4C4
        Friend Overridable Property Label62() As Label
            Get
                Return Me._Label62
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label62 IsNot Nothing Then
                End If
                Me._Label62 = value
                If Me._Label62 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700037D RID: 893
        ' (get) Token: 0x06000AA3 RID: 2723 RVA: 0x002704E0 File Offset: 0x0026F4E0
        ' (set) Token: 0x06000AA2 RID: 2722 RVA: 0x002704F4 File Offset: 0x0026F4F4
        Friend Overridable Property nudGrassDensity() As NumericUpDown
            Get
                Return Me._nudGrassDensity
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudGrassDensity IsNot Nothing Then
                    RemoveHandler Me._nudGrassDensity.ValueChanged, AddressOf Me.nudGrassDensity_ValueChanged
                End If
                Me._nudGrassDensity = value
                If Me._nudGrassDensity IsNot Nothing Then
                    AddHandler Me._nudGrassDensity.ValueChanged, AddressOf Me.nudGrassDensity_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x1700037E RID: 894
        ' (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00270548 File Offset: 0x0026F548
        ' (set) Token: 0x06000AA5 RID: 2725 RVA: 0x0027055C File Offset: 0x0026F55C
        Friend Overridable Property Label63() As Label
            Get
                Return Me._Label63
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label63 IsNot Nothing Then
                End If
                Me._Label63 = value
                If Me._Label63 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700037F RID: 895
        ' (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00270578 File Offset: 0x0026F578
        ' (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0027058C File Offset: 0x0026F58C
        Friend Overridable Property Label64() As Label
            Get
                Return Me._Label64
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label64 IsNot Nothing Then
                End If
                Me._Label64 = value
                If Me._Label64 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000380 RID: 896
        ' (get) Token: 0x06000AA9 RID: 2729 RVA: 0x002705C4 File Offset: 0x0026F5C4
        ' (set) Token: 0x06000AA8 RID: 2728 RVA: 0x002705A8 File Offset: 0x0026F5A8
        Friend Overridable Property Label65() As Label
            Get
                Return Me._Label65
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label65 IsNot Nothing Then
                End If
                Me._Label65 = value
                If Me._Label65 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000381 RID: 897
        ' (get) Token: 0x06000AAB RID: 2731 RVA: 0x002705D8 File Offset: 0x0026F5D8
        ' (set) Token: 0x06000AAA RID: 2730 RVA: 0x002705EC File Offset: 0x0026F5EC
        Friend Overridable Property Label66() As Label
            Get
                Return Me._Label66
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label66 IsNot Nothing Then
                End If
                Me._Label66 = value
                If Me._Label66 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000382 RID: 898
        ' (get) Token: 0x06000AAC RID: 2732 RVA: 0x00270608 File Offset: 0x0026F608
        ' (set) Token: 0x06000AAD RID: 2733 RVA: 0x0027061C File Offset: 0x0026F61C
        Friend Overridable Property Label67() As Label
            Get
                Return Me._Label67
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label67 IsNot Nothing Then
                End If
                Me._Label67 = value
                If Me._Label67 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000383 RID: 899
        ' (get) Token: 0x06000AAF RID: 2735 RVA: 0x0027068C File Offset: 0x0026F68C
        ' (set) Token: 0x06000AAE RID: 2734 RVA: 0x00270638 File Offset: 0x0026F638
        Friend Overridable Property nudGrassProbUL() As NumericUpDown
            Get
                Return Me._nudGrassProbUL
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudGrassProbUL IsNot Nothing Then
                    RemoveHandler Me._nudGrassProbUL.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
                End If
                Me._nudGrassProbUL = value
                If Me._nudGrassProbUL IsNot Nothing Then
                    AddHandler Me._nudGrassProbUL.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x17000384 RID: 900
        ' (get) Token: 0x06000AB1 RID: 2737 RVA: 0x002706A0 File Offset: 0x0026F6A0
        ' (set) Token: 0x06000AB0 RID: 2736 RVA: 0x002706B4 File Offset: 0x0026F6B4
        Friend Overridable Property nudGrassProbLL() As NumericUpDown
            Get
                Return Me._nudGrassProbLL
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudGrassProbLL IsNot Nothing Then
                    RemoveHandler Me._nudGrassProbLL.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
                End If
                Me._nudGrassProbLL = value
                If Me._nudGrassProbLL IsNot Nothing Then
                    AddHandler Me._nudGrassProbLL.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x17000385 RID: 901
        ' (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00270708 File Offset: 0x0026F708
        ' (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0027071C File Offset: 0x0026F71C
        Friend Overridable Property nudGrassProbUR() As NumericUpDown
            Get
                Return Me._nudGrassProbUR
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudGrassProbUR IsNot Nothing Then
                    RemoveHandler Me._nudGrassProbUR.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
                End If
                Me._nudGrassProbUR = value
                If Me._nudGrassProbUR IsNot Nothing Then
                    AddHandler Me._nudGrassProbUR.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x17000386 RID: 902
        ' (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00270770 File Offset: 0x0026F770
        ' (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00270784 File Offset: 0x0026F784
        Friend Overridable Property nudGrassProbLR() As NumericUpDown
            Get
                Return Me._nudGrassProbLR
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudGrassProbLR IsNot Nothing Then
                    RemoveHandler Me._nudGrassProbLR.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
                End If
                Me._nudGrassProbLR = value
                If Me._nudGrassProbLR IsNot Nothing Then
                    AddHandler Me._nudGrassProbLR.ValueChanged, AddressOf Me.nudGrassProbXX_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x17000387 RID: 903
        ' (get) Token: 0x06000AB7 RID: 2743 RVA: 0x002707D8 File Offset: 0x0026F7D8
        ' (set) Token: 0x06000AB6 RID: 2742 RVA: 0x002707EC File Offset: 0x0026F7EC
        Friend Overridable Property lblTotalGrassProbability() As Label
            Get
                Return Me._lblTotalGrassProbability
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblTotalGrassProbability IsNot Nothing Then
                End If
                Me._lblTotalGrassProbability = value
                If Me._lblTotalGrassProbability IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000388 RID: 904
        ' (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00270808 File Offset: 0x0026F808
        ' (set) Token: 0x06000AB9 RID: 2745 RVA: 0x0027081C File Offset: 0x0026F81C
        Friend Overridable Property Label69() As Label
            Get
                Return Me._Label69
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label69 IsNot Nothing Then
                End If
                Me._Label69 = value
                If Me._Label69 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000389 RID: 905
        ' (get) Token: 0x06000ABA RID: 2746 RVA: 0x00270838 File Offset: 0x0026F838
        ' (set) Token: 0x06000ABB RID: 2747 RVA: 0x0027084C File Offset: 0x0026F84C
        Friend Overridable Property Label70() As Label
            Get
                Return Me._Label70
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label70 IsNot Nothing Then
                End If
                Me._Label70 = value
                If Me._Label70 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700038A RID: 906
        ' (get) Token: 0x06000ABC RID: 2748 RVA: 0x00270884 File Offset: 0x0026F884
        ' (set) Token: 0x06000ABD RID: 2749 RVA: 0x00270868 File Offset: 0x0026F868
        Friend Overridable Property Label71() As Label
            Get
                Return Me._Label71
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label71 IsNot Nothing Then
                End If
                Me._Label71 = value
                If Me._Label71 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700038B RID: 907
        ' (get) Token: 0x06000ABE RID: 2750 RVA: 0x002708B4 File Offset: 0x0026F8B4
        ' (set) Token: 0x06000ABF RID: 2751 RVA: 0x00270898 File Offset: 0x0026F898
        Friend Overridable Property Label72() As Label
            Get
                Return Me._Label72
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label72 IsNot Nothing Then
                End If
                Me._Label72 = value
                If Me._Label72 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700038C RID: 908
        ' (get) Token: 0x06000AC0 RID: 2752 RVA: 0x002708C8 File Offset: 0x0026F8C8
        ' (set) Token: 0x06000AC1 RID: 2753 RVA: 0x002708DC File Offset: 0x0026F8DC
        Friend Overridable Property Label68() As Label
            Get
                Return Me._Label68
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label68 IsNot Nothing Then
                End If
                Me._Label68 = value
                If Me._Label68 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700038D RID: 909
        ' (get) Token: 0x06000AC2 RID: 2754 RVA: 0x002708F8 File Offset: 0x0026F8F8
        ' (set) Token: 0x06000AC3 RID: 2755 RVA: 0x0027090C File Offset: 0x0026F90C
        Friend Overridable Property nudGrassQuadSize() As NumericUpDown
            Get
                Return Me._nudGrassQuadSize
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudGrassQuadSize IsNot Nothing Then
                End If
                Me._nudGrassQuadSize = value
                If Me._nudGrassQuadSize IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700038E RID: 910
        ' (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00270944 File Offset: 0x0026F944
        ' (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00270928 File Offset: 0x0026F928
        Friend Overridable Property tbAreaTag() As TextBox
            Get
                Return Me._tbAreaTag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbAreaTag IsNot Nothing Then
                End If
                Me._tbAreaTag = value
                If Me._tbAreaTag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700038F RID: 911
        ' (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00270974 File Offset: 0x0026F974
        ' (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00270958 File Offset: 0x0026F958
        Friend Overridable Property tbAreaName() As TextBox
            Get
                Return Me._tbAreaName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbAreaName IsNot Nothing Then
                End If
                Me._tbAreaName = value
                If Me._tbAreaName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000390 RID: 912
        ' (get) Token: 0x06000AC8 RID: 2760 RVA: 0x002709A4 File Offset: 0x0026F9A4
        ' (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00270988 File Offset: 0x0026F988
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

        ' Token: 0x17000391 RID: 913
        ' (get) Token: 0x06000ACA RID: 2762 RVA: 0x002709B8 File Offset: 0x0026F9B8
        ' (set) Token: 0x06000ACB RID: 2763 RVA: 0x002709CC File Offset: 0x0026F9CC
        Friend Overridable Property cmbxCameraStyle() As ComboBox
            Get
                Return Me._cmbxCameraStyle
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxCameraStyle IsNot Nothing Then
                End If
                Me._cmbxCameraStyle = value
                If Me._cmbxCameraStyle IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000392 RID: 914
        ' (get) Token: 0x06000ACC RID: 2764 RVA: 0x002709E8 File Offset: 0x0026F9E8
        ' (set) Token: 0x06000ACD RID: 2765 RVA: 0x002709FC File Offset: 0x0026F9FC
        Friend Overridable Property Label73() As Label
            Get
                Return Me._Label73
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label73 IsNot Nothing Then
                End If
                Me._Label73 = value
                If Me._Label73 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000393 RID: 915
        ' (get) Token: 0x06000ACE RID: 2766 RVA: 0x00270A34 File Offset: 0x0026FA34
        ' (set) Token: 0x06000ACF RID: 2767 RVA: 0x00270A18 File Offset: 0x0026FA18
        Friend Overridable Property nudShadowOpacity() As NumericUpDown
            Get
                Return Me._nudShadowOpacity
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudShadowOpacity IsNot Nothing Then
                End If
                Me._nudShadowOpacity = value
                If Me._nudShadowOpacity IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000394 RID: 916
        ' (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00270A48 File Offset: 0x0026FA48
        ' (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00270A5C File Offset: 0x0026FA5C
        Friend Overridable Property tabpagArea_Events() As TabPage
            Get
                Return Me._tabpagArea_Events
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagArea_Events IsNot Nothing Then
                End If
                Me._tabpagArea_Events = value
                If Me._tabpagArea_Events IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000395 RID: 917
        ' (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00270A78 File Offset: 0x0026FA78
        ' (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00270A8C File Offset: 0x0026FA8C
        Friend Overridable Property Label74() As Label
            Get
                Return Me._Label74
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label74 IsNot Nothing Then
                End If
                Me._Label74 = value
                If Me._Label74 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000396 RID: 918
        ' (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00270AC4 File Offset: 0x0026FAC4
        ' (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00270AA8 File Offset: 0x0026FAA8
        Friend Overridable Property tbArea_OnEnter() As TextBox
            Get
                Return Me._tbArea_OnEnter
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbArea_OnEnter IsNot Nothing Then
                End If
                Me._tbArea_OnEnter = value
                If Me._tbArea_OnEnter IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000397 RID: 919
        ' (get) Token: 0x06000AD6 RID: 2774 RVA: 0x00270AD8 File Offset: 0x0026FAD8
        ' (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00270AEC File Offset: 0x0026FAEC
        Friend Overridable Property Label75() As Label
            Get
                Return Me._Label75
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label75 IsNot Nothing Then
                End If
                Me._Label75 = value
                If Me._Label75 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000398 RID: 920
        ' (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00270B24 File Offset: 0x0026FB24
        ' (set) Token: 0x06000AD9 RID: 2777 RVA: 0x00270B08 File Offset: 0x0026FB08
        Friend Overridable Property tbArea_OnExit() As TextBox
            Get
                Return Me._tbArea_OnExit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbArea_OnExit IsNot Nothing Then
                End If
                Me._tbArea_OnExit = value
                If Me._tbArea_OnExit IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000399 RID: 921
        ' (get) Token: 0x06000ADB RID: 2779 RVA: 0x00270B38 File Offset: 0x0026FB38
        ' (set) Token: 0x06000ADA RID: 2778 RVA: 0x00270B4C File Offset: 0x0026FB4C
        Friend Overridable Property tbArea_OnHeartbeat() As TextBox
            Get
                Return Me._tbArea_OnHeartbeat
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbArea_OnHeartbeat IsNot Nothing Then
                End If
                Me._tbArea_OnHeartbeat = value
                If Me._tbArea_OnHeartbeat IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700039A RID: 922
        ' (get) Token: 0x06000ADD RID: 2781 RVA: 0x00270B68 File Offset: 0x0026FB68
        ' (set) Token: 0x06000ADC RID: 2780 RVA: 0x00270B7C File Offset: 0x0026FB7C
        Friend Overridable Property Label76() As Label
            Get
                Return Me._Label76
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label76 IsNot Nothing Then
                End If
                Me._Label76 = value
                If Me._Label76 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700039B RID: 923
        ' (get) Token: 0x06000ADE RID: 2782 RVA: 0x00270BB4 File Offset: 0x0026FBB4
        ' (set) Token: 0x06000ADF RID: 2783 RVA: 0x00270B98 File Offset: 0x0026FB98
        Friend Overridable Property Label77() As Label
            Get
                Return Me._Label77
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label77 IsNot Nothing Then
                End If
                Me._Label77 = value
                If Me._Label77 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700039C RID: 924
        ' (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00270BC8 File Offset: 0x0026FBC8
        ' (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00270BDC File Offset: 0x0026FBDC
        Friend Overridable Property tbArea_OnUserDefined() As TextBox
            Get
                Return Me._tbArea_OnUserDefined
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbArea_OnUserDefined IsNot Nothing Then
                End If
                Me._tbArea_OnUserDefined = value
                If Me._tbArea_OnUserDefined IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700039D RID: 925
        ' (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00270BF8 File Offset: 0x0026FBF8
        ' (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00270C0C File Offset: 0x0026FC0C
        Friend Overridable Property tabpagAreaRooms() As TabPage
            Get
                Return Me._tabpagAreaRooms
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagAreaRooms IsNot Nothing Then
                End If
                Me._tabpagAreaRooms = value
                If Me._tabpagAreaRooms IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700039E RID: 926
        ' (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00270C44 File Offset: 0x0026FC44
        ' (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00270C28 File Offset: 0x0026FC28
        Friend Overridable Property Label78() As Label
            Get
                Return Me._Label78
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label78 IsNot Nothing Then
                End If
                Me._Label78 = value
                If Me._Label78 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700039F RID: 927
        ' (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00270C58 File Offset: 0x0026FC58
        ' (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00270C6C File Offset: 0x0026FC6C
        Friend Overridable Property Label79() As Label
            Get
                Return Me._Label79
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label79 IsNot Nothing Then
                End If
                Me._Label79 = value
                If Me._Label79 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A0 RID: 928
        ' (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00270C88 File Offset: 0x0026FC88
        ' (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00270C9C File Offset: 0x0026FC9C
        Friend Overridable Property Label80() As Label
            Get
                Return Me._Label80
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label80 IsNot Nothing Then
                End If
                Me._Label80 = value
                If Me._Label80 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A1 RID: 929
        ' (get) Token: 0x06000AEA RID: 2794 RVA: 0x00270CB8 File Offset: 0x0026FCB8
        ' (set) Token: 0x06000AEB RID: 2795 RVA: 0x00270CCC File Offset: 0x0026FCCC
        Friend Overridable Property Label81() As Label
            Get
                Return Me._Label81
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label81 IsNot Nothing Then
                End If
                Me._Label81 = value
                If Me._Label81 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A2 RID: 930
        ' (get) Token: 0x06000AED RID: 2797 RVA: 0x00270CE8 File Offset: 0x0026FCE8
        ' (set) Token: 0x06000AEC RID: 2796 RVA: 0x00270CFC File Offset: 0x0026FCFC
        Friend Overridable Property Label82() As Label
            Get
                Return Me._Label82
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label82 IsNot Nothing Then
                End If
                Me._Label82 = value
                If Me._Label82 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A3 RID: 931
        ' (get) Token: 0x06000AEE RID: 2798 RVA: 0x00270D18 File Offset: 0x0026FD18
        ' (set) Token: 0x06000AEF RID: 2799 RVA: 0x00270D2C File Offset: 0x0026FD2C
        Friend Overridable Property lbRooms() As ListBox
            Get
                Return Me._lbRooms
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ListBox)
                If Me._lbRooms IsNot Nothing Then
                    RemoveHandler Me._lbRooms.SelectedIndexChanged, AddressOf Me.lbRooms_SelectedIndexChanged
                End If
                Me._lbRooms = value
                If Me._lbRooms IsNot Nothing Then
                    AddHandler Me._lbRooms.SelectedIndexChanged, AddressOf Me.lbRooms_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x170003A4 RID: 932
        ' (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00270D80 File Offset: 0x0026FD80
        ' (set) Token: 0x06000AF1 RID: 2801 RVA: 0x00270D94 File Offset: 0x0026FD94
        Friend Overridable Property Label83() As Label
            Get
                Return Me._Label83
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label83 IsNot Nothing Then
                End If
                Me._Label83 = value
                If Me._Label83 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A5 RID: 933
        ' (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00270DCC File Offset: 0x0026FDCC
        ' (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00270DB0 File Offset: 0x0026FDB0
        Friend Overridable Property chkbRoomDisableWeather() As CheckBox
            Get
                Return Me._chkbRoomDisableWeather
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbRoomDisableWeather IsNot Nothing Then
                End If
                Me._chkbRoomDisableWeather = value
                If Me._chkbRoomDisableWeather IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A6 RID: 934
        ' (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00270DE0 File Offset: 0x0026FDE0
        ' (set) Token: 0x06000AF5 RID: 2805 RVA: 0x00270DF4 File Offset: 0x0026FDF4
        Friend Overridable Property nudRoomAmbientScale() As NumericUpDown
            Get
                Return Me._nudRoomAmbientScale
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudRoomAmbientScale IsNot Nothing Then
                End If
                Me._nudRoomAmbientScale = value
                If Me._nudRoomAmbientScale IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A7 RID: 935
        ' (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00270E2C File Offset: 0x0026FE2C
        ' (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00270E10 File Offset: 0x0026FE10
        Friend Overridable Property cmbxRoomEnvAudio() As ComboBox
            Get
                Return Me._cmbxRoomEnvAudio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxRoomEnvAudio IsNot Nothing Then
                End If
                Me._cmbxRoomEnvAudio = value
                If Me._cmbxRoomEnvAudio IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A8 RID: 936
        ' (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00270E40 File Offset: 0x0026FE40
        ' (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00270E54 File Offset: 0x0026FE54
        Friend Overridable Property tbRoomName() As TextBox
            Get
                Return Me._tbRoomName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbRoomName IsNot Nothing Then
                End If
                Me._tbRoomName = value
                If Me._tbRoomName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003A9 RID: 937
        ' (get) Token: 0x06000AFA RID: 2810 RVA: 0x00270E70 File Offset: 0x0026FE70
        ' (set) Token: 0x06000AFB RID: 2811 RVA: 0x00270E84 File Offset: 0x0026FE84
        Friend Overridable Property nudRoomForceRating() As NumericUpDown
            Get
                Return Me._nudRoomForceRating
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudRoomForceRating IsNot Nothing Then
                End If
                Me._nudRoomForceRating = value
                If Me._nudRoomForceRating IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003AA RID: 938
        ' (get) Token: 0x06000AFD RID: 2813 RVA: 0x00270EA0 File Offset: 0x0026FEA0
        ' (set) Token: 0x06000AFC RID: 2812 RVA: 0x00270EB4 File Offset: 0x0026FEB4
        Friend Overridable Property tbModDescription() As TextBox
            Get
                Return Me._tbModDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbModDescription IsNot Nothing Then
                End If
                Me._tbModDescription = value
                If Me._tbModDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003AB RID: 939
        ' (get) Token: 0x06000AFE RID: 2814 RVA: 0x00270F24 File Offset: 0x0026FF24
        ' (set) Token: 0x06000AFF RID: 2815 RVA: 0x00270ED0 File Offset: 0x0026FED0
        Friend Overridable Property btnSetModNameLang() As Button
            Get
                Return Me._btnSetModNameLang
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetModNameLang IsNot Nothing Then
                    RemoveHandler Me._btnSetModNameLang.Click, AddressOf Me.btnSetModNameLang_Click
                End If
                Me._btnSetModNameLang = value
                If Me._btnSetModNameLang IsNot Nothing Then
                    AddHandler Me._btnSetModNameLang.Click, AddressOf Me.btnSetModNameLang_Click
                End If
            End Set
        End Property

        ' Token: 0x170003AC RID: 940
        ' (get) Token: 0x06000B01 RID: 2817 RVA: 0x00270F38 File Offset: 0x0026FF38
        ' (set) Token: 0x06000B00 RID: 2816 RVA: 0x00270F4C File Offset: 0x0026FF4C
        Friend Overridable Property btnSetAreaNameLang() As Button
            Get
                Return Me._btnSetAreaNameLang
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetAreaNameLang IsNot Nothing Then
                    RemoveHandler Me._btnSetAreaNameLang.Click, AddressOf Me.btnSetAreaNameLang_Click
                End If
                Me._btnSetAreaNameLang = value
                If Me._btnSetAreaNameLang IsNot Nothing Then
                    AddHandler Me._btnSetAreaNameLang.Click, AddressOf Me.btnSetAreaNameLang_Click
                End If
            End Set
        End Property

        ' Token: 0x170003AD RID: 941
        ' (get) Token: 0x06000B03 RID: 2819 RVA: 0x00270FA0 File Offset: 0x0026FFA0
        ' (set) Token: 0x06000B02 RID: 2818 RVA: 0x00270FB4 File Offset: 0x0026FFB4
        Friend Overridable Property cmbxWindPower() As ComboBox
            Get
                Return Me._cmbxWindPower
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxWindPower IsNot Nothing Then
                End If
                Me._cmbxWindPower = value
                If Me._cmbxWindPower IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003AE RID: 942
        ' (get) Token: 0x06000B05 RID: 2821 RVA: 0x00270FEC File Offset: 0x0026FFEC
        ' (set) Token: 0x06000B04 RID: 2820 RVA: 0x00270FD0 File Offset: 0x0026FFD0
        Friend Overridable Property Label84() As Label
            Get
                Return Me._Label84
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label84 IsNot Nothing Then
                End If
                Me._Label84 = value
                If Me._Label84 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003AF RID: 943
        ' (get) Token: 0x06000B06 RID: 2822 RVA: 0x00271000 File Offset: 0x00270000
        ' (set) Token: 0x06000B07 RID: 2823 RVA: 0x00271014 File Offset: 0x00270014
        Friend Overridable Property chkbUnescapable() As CheckBox
            Get
                Return Me._chkbUnescapable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbUnescapable IsNot Nothing Then
                End If
                Me._chkbUnescapable = value
                If Me._chkbUnescapable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003B0 RID: 944
        ' (get) Token: 0x06000B09 RID: 2825 RVA: 0x00271030 File Offset: 0x00270030
        ' (set) Token: 0x06000B08 RID: 2824 RVA: 0x00271044 File Offset: 0x00270044
        Friend Overridable Property Label85() As Label
            Get
                Return Me._Label85
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label85 IsNot Nothing Then
                End If
                Me._Label85 = value
                If Me._Label85 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003B1 RID: 945
        ' (get) Token: 0x06000B0B RID: 2827 RVA: 0x0027107C File Offset: 0x0027007C
        ' (set) Token: 0x06000B0A RID: 2826 RVA: 0x00271060 File Offset: 0x00270060
        Friend Overridable Property chkbDisableTransit() As CheckBox
            Get
                Return Me._chkbDisableTransit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbDisableTransit IsNot Nothing Then
                End If
                Me._chkbDisableTransit = value
                If Me._chkbDisableTransit IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003B2 RID: 946
        ' (get) Token: 0x06000B0C RID: 2828 RVA: 0x00271090 File Offset: 0x00270090
        ' (set) Token: 0x06000B0D RID: 2829 RVA: 0x002710A4 File Offset: 0x002700A4
        Friend Overridable Property Label86() As Label
            Get
                Return Me._Label86
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label86 IsNot Nothing Then
                End If
                Me._Label86 = value
                If Me._Label86 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003B3 RID: 947
        ' (get) Token: 0x06000B0E RID: 2830 RVA: 0x002710DC File Offset: 0x002700DC
        ' (set) Token: 0x06000B0F RID: 2831 RVA: 0x002710C0 File Offset: 0x002700C0
        Friend Overridable Property pboxXY() As PictureBox
            Get
                Return Me._pboxXY
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As PictureBox)
                If Me._pboxXY IsNot Nothing Then
                End If
                Me._pboxXY = value
                If Me._pboxXY IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003B4 RID: 948
        ' (get) Token: 0x06000B11 RID: 2833 RVA: 0x002710F0 File Offset: 0x002700F0
        ' (set) Token: 0x06000B10 RID: 2832 RVA: 0x00271104 File Offset: 0x00270104
        Friend Overridable Property nudXY() As NumericUpDown
            Get
                Return Me._nudXY
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudXY IsNot Nothing Then
                    RemoveHandler Me._nudXY.ValueChanged, AddressOf Me.nudXY_ValueChanged
                    RemoveHandler Me._nudXY.KeyUp, AddressOf Me.nudXY_KeyUp
                End If
                Me._nudXY = value
                If Me._nudXY IsNot Nothing Then
                    AddHandler Me._nudXY.ValueChanged, AddressOf Me.nudXY_ValueChanged
                    AddHandler Me._nudXY.KeyUp, AddressOf Me.nudXY_KeyUp
                End If
            End Set
        End Property

        ' Token: 0x170003B5 RID: 949
        ' (get) Token: 0x06000B12 RID: 2834 RVA: 0x002711A4 File Offset: 0x002701A4
        ' (set) Token: 0x06000B13 RID: 2835 RVA: 0x00271188 File Offset: 0x00270188
        Friend Overridable Property lblBearing() As Label
            Get
                Return Me._lblBearing
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblBearing IsNot Nothing Then
                End If
                Me._lblBearing = value
                If Me._lblBearing IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003B6 RID: 950
        ' (get) Token: 0x06000B15 RID: 2837 RVA: 0x002711B8 File Offset: 0x002701B8
        ' (set) Token: 0x06000B14 RID: 2836 RVA: 0x002711CC File Offset: 0x002701CC
        Friend Overridable Property tbModEntryArea() As TextBox
            Get
                Return Me._tbModEntryArea
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbModEntryArea IsNot Nothing Then
                End If
                Me._tbModEntryArea = value
                If Me._tbModEntryArea IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x06000B17 RID: 2839 RVA: 0x00278E54 File Offset: 0x00277E54
        Public Sub New(ByRef AREFile As clsGFF, ByRef IFOFile As clsGFF, ByRef GITFile As clsGFF, ByVal KotorVersion As Integer)
            Me.New()
            Me.KotorVersionIndex = KotorVersion
            Me.CurrentSettings = UserSettings.GetSettings()
            Me._DialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\dialog.tlk", False)
            Me._ChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me._AREFile = AREFile
            Me._IFOFile = IFOFile
            Me._GITFile = GITFile
            Me.FillForm()
        End Sub

        ' Token: 0x06000B18 RID: 2840 RVA: 0x00278EDC File Offset: 0x00277EDC
        Private Sub SetupRooms()
            Me.FillComboBoxFrom2DA(Me.cmbxRoomEnvAudio, "label", "soundeax", Me._ChitinKey, Nothing)
            Dim num As Integer = Me._AREFile.GetListItemCount("Rooms") - 1
            Me.Rooms = New frmModuleIfo_AreaEditor.Room(num + 1 - 1) {}
            Dim num2 As Integer = 0
            Dim num3 As Integer = num
            For i As Integer = num2 To num3
                Me.Rooms(i) = New frmModuleIfo_AreaEditor.Room()
                Me.Rooms(i).RoomName = StringType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").RoomName"))
                Me.Rooms(i).EnvAudio = IntegerType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").EnvAudio"))
                Me.Rooms(i).AmbientScale = SingleType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").AmbientScale"))
                Me.Rooms(i).ForceRating = IntegerType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").ForceRating"))
                Me.Rooms(i).DisableWeather = BooleanType.FromObject(Me._AREFile.GetNodeValue("Rooms(" + StringType.FromInteger(i) + ").DisableWeather"))
            Next
            Me.lbRooms.DataSource = Me.Rooms
            Me.lbRooms.DisplayMember = "Text"
        End Sub

        ' Token: 0x06000B19 RID: 2841 RVA: 0x00279064 File Offset: 0x00278064
        Private Sub ReadRooms()
            Dim num As Integer = 0
            Dim upperBound As Integer = Me.Rooms.GetUpperBound(0)
            For i As Integer = num To upperBound
                Me._AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(i) + ").EnvAudio", Me.Rooms(i).EnvAudio)
                Me._AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(i) + ").AmbientScale", Me.Rooms(i).AmbientScale)
                Me._AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(i) + ").ForceRating", Me.Rooms(i).ForceRating)
                Me._AREFile.SetNodeValue("Rooms(" + StringType.FromInteger(i) + ").DisableWeather", Me.Rooms(i).DisableWeather)
            Next
        End Sub

        ' Token: 0x06000B1A RID: 2842 RVA: 0x00279158 File Offset: 0x00278158
        Private Sub FillForm()
            Me._IFOFile.SetTextBoxFromCExoLocStringNodeValue(Me.tbModName, "Mod_Name")
            Me.Mod_Tag = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_Tag"))
            Me.Mod_Entry_Area = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Area"))
            Me.Mod_Entry_X = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_X"))
            Me.Mod_Entry_Y = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Y"))
            Me.Mod_Entry_Z = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Z"))
            Me._origXPos = Me.Mod_Entry_X
            Me._origYpos = Me.Mod_Entry_Y
            Me._origZpos = Me.Mod_Entry_Z
            Me._origXOrientation = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Dir_X"))
            Me._origYOrientation = SingleType.FromObject(Me._IFOFile.GetNodeValue("Mod_Entry_Dir_Y"))
            Me.SetupOrientationIndicators(Me._origXOrientation, Me._origYOrientation)
            Me.Mod_MinutesPerHour = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_MinPerHour"))
            Me.Mod_DawnHour = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_DawnHour"))
            Me.Mod_DuskHour = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_DuskHour"))
            Me.Mod_StartHour = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_StartHour"))
            Me.Mod_StartDay = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_StartDay"))
            Me.Mod_StartMonth = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_StartMonth"))
            Me.Mod_StartYear = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me._IFOFile.GetNodeValue("Mod_StartYear")))
            Me.Mod_XPScale = IntegerType.FromObject(Me._IFOFile.GetNodeValue("Mod_XPScale"))
            Me.Mod_OnAcquirItem = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnAcquirItem"))
            Me.Mod_OnActvtItem = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnActvtItem"))
            Me.Mod_OnClientEntr = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnClientEntr"))
            Me.Mod_OnClientLeav = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnClientLeav"))
            Me.Mod_OnHeartbeat = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnHeartbeat"))
            Me.Mod_OnModLoad = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnModLoad"))
            Me.Mod_OnPlrDeath = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnPlrDeath"))
            Me.Mod_OnPlrDying = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnPlrDying"))
            Me.Mod_OnPlrLvlUp = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnPlrLvlUp"))
            Me.Mod_OnSpawnBtnDn = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnSpawnBtnDn"))
            Me.Mod_OnPlrRest = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnPlrRest"))
            Me.Mod_OnUnAqreItem = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnUnAqreItem"))
            Me.Mod_OnUsrDefined = StringType.FromObject(Me._IFOFile.GetNodeValue("Mod_OnUsrDefined"))
            Me._AREFile.SetTextBoxFromCExoLocStringNodeValue(Me.tbAreaName, "Name")
            Me._AREFile.SetTextBoxToNodeValue(Me.tbAreaTag, "Tag")
            Me.FillComboBoxFrom2DA(Me.cmbxCameraStyle, "name", "camerastyle", Me._ChitinKey, Me._DialogTlk)
            If Not Me._AREFile.SyncComboBox(Me.cmbxCameraStyle, "CameraStyle") Then
                Me.ComboBoxSettingError = True
            End If
            Me.chkbUnescapable.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("Unescapable"))
            Me.chkbDisableTransit.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("DisableTransit"))
            Me.rbDayNightCycle.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("DayNightCycle"))
            If Not Me.rbDayNightCycle.Checked Then
                If ObjectType.ObjTst(Me._AREFile.GetNodeValue("IsNight"), 1, False) = 0 Then
                    Me.rbAlwaysNight.Checked = True
                Else
                    Me.rbAlwaysDay.Checked = True
                End If
            End If
            Me.DynAmbientColor = CUInt((If(Me._AREFile.GetNodeValue("DynAmbientColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudShadowOpacity, "ShadowOpacity", 0.0F)
            Me.SunAmbientColor = CUInt((If(Me._AREFile.GetNodeValue("SunAmbientColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.SunDiffuseColor = CUInt((If(Me._AREFile.GetNodeValue("SunDiffuseColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.SunFogColor = CUInt((If(Me._AREFile.GetNodeValue("SunFogColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.chkbSunFogOn.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("SunFogOn"))
            Me.trkbarSunFogNear.Value = IntegerType.FromObject(Me._AREFile.GetNodeValue("SunFogNear"))
            Me.trkbarSunFogFar.Value = IntegerType.FromObject(Me._AREFile.GetNodeValue("SunFogFar"))
            Me.chkbAreaSunShadows.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("SunShadows"))
            Me.MoonAmbientColor = CUInt((If(Me._AREFile.GetNodeValue("MoonAmbientColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.MoonDiffuseColor = CUInt((If(Me._AREFile.GetNodeValue("MoonDiffuseColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.MoonFogColor = CUInt((If(Me._AREFile.GetNodeValue("MoonFogColor"), Activator.CreateInstance(GetType(UInteger)))))
            Me.chkbMoonFogOn.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("MoonFogOn"))
            Me.trkbarMoonFogNear.Value = IntegerType.FromObject(Me._AREFile.GetNodeValue("MoonFogNear"))
            Me.trkbarMoonFogFar.Value = IntegerType.FromObject(Me._AREFile.GetNodeValue("MoonFogFar"))
            Me.chkbAreaMoonShadows.Checked = BooleanType.FromObject(Me._AREFile.GetNodeValue("MoonShadows"))
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudChanceSnow, "ChanceSnow", 0.0F)
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudChanceRain, "ChanceRain", 0.0F)
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudChanceLightning, "ChanceLightning", 0.0F)
            Me.FillComboBoxFrom2DA(Me.cmbxAmbientSndDay, "description", "ambientsound", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxAmbientSndDay, "AreaProperties.AmbientSndDay") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxAmbientSndNight, "description", "ambientsound", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxAmbientSndNight, "AreaProperties.AmbientSndNight") Then
                Me.ComboBoxSettingError = True
            End If
            Me.trkbarAmbientSndDayVol.Value = IntegerType.FromObject(Me._GITFile.GetNodeValue("AreaProperties.AmbientSndDayVol"))
            Me.trkbarAmbientSndNightVol.Value = IntegerType.FromObject(Me._GITFile.GetNodeValue("AreaProperties.AmbientSndNitVol"))
            Me.FillComboBoxFrom2DA(Me.cmbxEnvAudio, "label", "soundeax", Me._ChitinKey, Nothing)
            If Not Me._GITFile.SyncComboBox(Me.cmbxEnvAudio, "AreaProperties.EnvAudio") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxMusicBattle, "description", "ambientmusic", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxMusicBattle, "AreaProperties.MusicBattle") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxMusicDay, "description", "ambientmusic", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxMusicDay, "AreaProperties.MusicDay") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxMusicNight, "description", "ambientmusic", Me._ChitinKey, Me._DialogTlk)
            If Not Me._GITFile.SyncComboBox(Me.cmbxMusicNight, "AreaProperties.MusicNight") Then
                Me.ComboBoxSettingError = True
            End If
            Me.nudMusicDelay.Value = DecimalType.FromObject(ObjectType.DivObj(Me._GITFile.GetNodeValue("AreaProperties.MusicDelay"), 1000))
            If Me.ComboBoxSettingError Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
            Me._AREFile.SetTextBoxToNodeValue(Me.tbGrass_TexName, "Grass_TexName")
            Me.Grass_Ambient = CUInt((If(Me._AREFile.GetNodeValue("Grass_Ambient"), Activator.CreateInstance(GetType(UInteger)))))
            Me.Grass_Diffuse = CUInt((If(Me._AREFile.GetNodeValue("Grass_Diffuse"), Activator.CreateInstance(GetType(UInteger)))))
            Me.Grass_Emissive = CUInt((If(Me._AREFile.GetNodeValue("Grass_Emissive"), Activator.CreateInstance(GetType(UInteger)))))
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudGrassQuadSize, "Grass_QuadSize", 0.0F)
            Me._AREFile.SetNumericUpDownToNodeValue(Me.nudGrassDensity, "Grass_Density", 0.0F)
            Me.Grass_Prob_LL = SingleType.FromObject(Me._AREFile.GetNodeValue("Grass_Prob_LL"))
            Me.Grass_Prob_UL = SingleType.FromObject(Me._AREFile.GetNodeValue("Grass_Prob_UL"))
            Me.Grass_Prob_LR = SingleType.FromObject(Me._AREFile.GetNodeValue("Grass_Prob_LR"))
            Me.Grass_Prob_UR = SingleType.FromObject(Me._AREFile.GetNodeValue("Grass_Prob_UR"))
            Me._AREFile.SetTextBoxToNodeValue(Me.tbArea_OnEnter, "OnEnter")
            Me._AREFile.SetTextBoxToNodeValue(Me.tbArea_OnExit, "OnExit")
            Me._AREFile.SetTextBoxToNodeValue(Me.tbArea_OnHeartbeat, "OnHeartbeat")
            Me._AREFile.SetTextBoxToNodeValue(Me.tbArea_OnUserDefined, "OnUserDefined")
            Me.SetupRooms()
        End Sub

        ' Token: 0x06000B1B RID: 2843 RVA: 0x00279C48 File Offset: 0x00278C48
        Public Sub UpdateFiles()
            Me._IFOFile.SetCExoLocStringNodeValueFromTextBox(Me.tbModName, "Mod_Name", Me.ModNameLang)
            Me._IFOFile.SetNodeValue("Mod_Tag", Me.Mod_Tag)
            Me._IFOFile.SetNodeValue("Mod_Entry_Area", Me.Mod_Entry_Area)
            Me._IFOFile.SetNodeValue("Mod_Entry_X", Me.Mod_Entry_X)
            Me._IFOFile.SetNodeValue("Mod_Entry_Y", Me.Mod_Entry_Y)
            Me._IFOFile.SetNodeValue("Mod_Entry_Z", Me.Mod_Entry_Z)
            Me._IFOFile.SetNodeValue("Mod_Entry_Dir_X", Me.XOrientation)
            Me._IFOFile.SetNodeValue("Mod_Entry_Dir_Y", Me.YOrientation)
            Me._IFOFile.SetNodeValue("Mod_MinPerHour", Me.Mod_MinutesPerHour)
            Me._IFOFile.SetNodeValue("Mod_DawnHour", Me.Mod_DawnHour)
            Me._IFOFile.SetNodeValue("Mod_DuskHour", Me.Mod_DuskHour)
            Me._IFOFile.SetNodeValue("Mod_StartHour", Me.Mod_StartHour)
            Me._IFOFile.SetNodeValue("Mod_StartDay", Me.Mod_StartDay)
            Me._IFOFile.SetNodeValue("Mod_StartMonth", Me.Mod_StartMonth)
            Me._IFOFile.SetNodeValue("Mod_StartYear", Me.Mod_StartYear)
            Me._IFOFile.SetNodeValue("Mod_XPScale", Me.Mod_XPScale)
            Me._IFOFile.SetNodeValue("Mod_OnAcquirItem", Me.Mod_OnAcquirItem)
            Me._IFOFile.SetNodeValue("Mod_OnActvtItem", Me.Mod_OnActvtItem)
            Me._IFOFile.SetNodeValue("Mod_OnClientEntr", Me.Mod_OnClientEntr)
            Me._IFOFile.SetNodeValue("Mod_OnClientLeav", Me.Mod_OnClientLeav)
            Me._IFOFile.SetNodeValue("Mod_OnHeartbeat", Me.Mod_OnHeartbeat)
            Me._IFOFile.SetNodeValue("Mod_OnModLoad", Me.Mod_OnModLoad)
            Me._IFOFile.SetNodeValue("Mod_OnPlrDeath", Me.Mod_OnPlrDeath)
            Me._IFOFile.SetNodeValue("Mod_OnPlrDying", Me.Mod_OnPlrDying)
            Me._IFOFile.SetNodeValue("Mod_OnPlrLvlUp", Me.Mod_OnPlrLvlUp)
            Me._IFOFile.SetNodeValue("Mod_OnSpawnBtnDn", Me.Mod_OnSpawnBtnDn)
            Me._IFOFile.SetNodeValue("Mod_OnPlrRest", Me.Mod_OnPlrRest)
            Me._IFOFile.SetNodeValue("Mod_OnUnAqreItem", Me.Mod_OnUnAqreItem)
            Me._IFOFile.SetNodeValue("Mod_OnUsrDefined", Me.Mod_OnUsrDefined)
            Me._IFOFile.SetCExoLocStringNodeValueFromTextBox(Me.tbModDescription, "Mod_Description", Me.ModDescriptionLang)
            Me._AREFile.SetNodeValueFromTextBox(Me.tbAreaTag, "Tag")
            Me._AREFile.SetCExoLocStringNodeValueFromTextBox(Me.tbAreaName, "Name", Me.AreaNameLang)
            Me._AREFile.SetNodeValueFromComboBox(Me.cmbxCameraStyle, "CameraStyle")
            Me._AREFile.SetNodeValue("Unescapable", Me.chkbUnescapable.Checked)
            Me._AREFile.SetNodeValue("DisableTransit", Me.chkbDisableTransit.Checked)
            Me._AREFile.SetNodeValue("DayNightCycle", Me.rbDayNightCycle.Checked)
            Me._AREFile.SetNodeValue("IsNight", Me.rbAlwaysNight.Checked)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudShadowOpacity, "ShadowOpacity", 0.0F)
            Me._AREFile.SetNodeValue("DynAmbientColor", Me.DynAmbientColor)
            Me._AREFile.SetNodeValue("SunAmbientColor", Me.SunAmbientColor)
            Me._AREFile.SetNodeValue("SunDiffuseColor", Me.SunDiffuseColor)
            Me._AREFile.SetNodeValue("SunFogColor", Me.SunFogColor)
            Me._AREFile.SetNodeValue("SunFogOn", Me.chkbSunFogOn.Checked)
            Me._AREFile.SetNodeValue("SunFogNear", Me.trkbarSunFogNear.Value)
            Me._AREFile.SetNodeValue("SunFogFar", Me.trkbarSunFogFar.Value)
            Me._AREFile.SetNodeValue("SunShadows", Me.chkbAreaSunShadows.Checked)
            Me._AREFile.SetNodeValue("MoonAmbientColor", Me.MoonAmbientColor)
            Me._AREFile.SetNodeValue("MoonDiffuseColor", Me.MoonDiffuseColor)
            Me._AREFile.SetNodeValue("MoonFogColor", Me.MoonFogColor)
            Me._AREFile.SetNodeValue("MoonFogOn", Me.chkbMoonFogOn.Checked)
            Me._AREFile.SetNodeValue("MoonFogNear", Me.trkbarMoonFogNear.Value)
            Me._AREFile.SetNodeValue("MoonFogFar", Me.trkbarMoonFogFar.Value)
            Me._AREFile.SetNodeValue("MoonShadows", Me.chkbAreaMoonShadows.Checked)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudChanceSnow, "ChanceSnow", 0.0F)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudChanceRain, "ChanceRain", 0.0F)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudChanceLightning, "ChanceLightning", 0.0F)
            Me._AREFile.SetNodeValueFromTextBox(Me.tbGrass_TexName, "Grass_TexName")
            Me._AREFile.SetNodeValue("Grass_Ambient", Me.Grass_Ambient)
            Me._AREFile.SetNodeValue("Grass_Diffuse", Me.Grass_Diffuse)
            Me._AREFile.SetNodeValue("Grass_Emissive", Me.Grass_Emissive)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudGrassDensity, "Grass_Density", 0.0F)
            Me._AREFile.SetNodeValueFromNumericUpDown(Me.nudGrassQuadSize, "Grass_QuadSize", 0.0F)
            Me._AREFile.SetNodeValue("Grass_Prob_LL", Me.Grass_Prob_LL)
            Me._AREFile.SetNodeValue("Grass_Prob_UL", Me.Grass_Prob_UL)
            Me._AREFile.SetNodeValue("Grass_Prob_LR", Me.Grass_Prob_LR)
            Me._AREFile.SetNodeValue("Grass_Prob_UR", Me.Grass_Prob_UR)
            Me._AREFile.SetNodeValueFromTextBox(Me.tbArea_OnEnter, "OnEnter")
            Me._AREFile.SetNodeValueFromTextBox(Me.tbArea_OnExit, "OnExit")
            Me._AREFile.SetNodeValueFromTextBox(Me.tbArea_OnHeartbeat, "OnHeartbeat")
            Me._AREFile.SetNodeValueFromTextBox(Me.tbArea_OnUserDefined, "OnUserDefined")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxAmbientSndDay, "AreaProperties.AmbientSndDay")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxAmbientSndNight, "AreaProperties.AmbientSndNight")
            Me._GITFile.SetNodeValue("AreaProperties.AmbientSndDayVol", Me.trkbarAmbientSndDayVol.Value)
            Me._GITFile.SetNodeValue("AreaProperties.AmbientSndNitVol", Me.trkbarAmbientSndNightVol.Value)
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxEnvAudio, "AreaProperties.EnvAudio")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxMusicBattle, "AreaProperties.MusicBattle")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxMusicDay, "AreaProperties.MusicDay")
            Me._GITFile.SetNodeValueFromComboBox(Me.cmbxMusicNight, "AreaProperties.MusicNight")
            Me._GITFile.SetNodeValue("AreaProperties.MusicDelay", Decimal.Multiply(Me.nudMusicDelay.Value, 1000D))
            Me.ReadRooms()
        End Sub

        ' Token: 0x06000B1C RID: 2844 RVA: 0x0027A488 File Offset: 0x00279488
        Private Function color2bgr(ByVal col As Color) As UInteger
            ' The following expression was wrapped in a checked-expression
            Return Convert.ToUInt32(CInt(col.B) * 65536 + CInt(col.G) * 256 + CInt(col.R))
        End Function

        ' Token: 0x06000B1D RID: 2845 RVA: 0x0027A4C0 File Offset: 0x002794C0
        Private Function bgr2color(ByVal bgr As UInteger) As Color
            Dim num As Integer = Convert.ToInt32(bgr)
            Dim num2 As Integer = num And 255
            Dim num3 As Integer = (num And 65280) >> 8
            Dim num4 As Integer = (num And 16711680) >> 16
            Return Color.FromArgb(255, num2, num3, num4)
        End Function

        ' Token: 0x06000B1E RID: 2846 RVA: 0x0027A500 File Offset: 0x00279500
        Public Function ReadCls2DA(ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey) As cls2DA
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
                        Console.WriteLine("Read " + TwoDAName + ".2da from override")
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = ChitinKey.FindResIDForResRef(TwoDAName, 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + ChitinKey.BiffList(num >> 20).filename
                array = BIFFArchive.getBIFFResource(text, num).data
                Console.WriteLine("Read " + TwoDAName + ".2da from 2da.bif")
            End If
            Return New cls2DA(array)
        End Function

        ' Token: 0x06000B1F RID: 2847 RVA: 0x0027A63C File Offset: 0x0027963C
        Private Sub FillComboBoxFrom2DA(ByVal cmbx As ComboBox, ByVal colName As String, ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA(TwoDAName, ChitinKey)
            If DialogTlk IsNot Nothing Then
                Dim num As Integer = 0
                Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
                For i As Integer = num To rowsUpperBound
                    Dim indiceData As Object = cls2DA.GetIndiceData(i, colName)
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
                        cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
                    Else
                        cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
                    End If
                Next
            Else
                Dim num2 As Integer = 0
                Dim rowsUpperBound2 As Integer = cls2DA.RowsUpperBound
                For i As Integer = num2 To rowsUpperBound2
                    cmbx.Items.Add(cls2DA.GetIndiceData(i, colName))
                Next
            End If
        End Sub

        ' Token: 0x06000B20 RID: 2848 RVA: 0x0027A6DC File Offset: 0x002796DC
        Public Sub SetupOrientationIndicators()
            Dim num As Single = CSng(Math.Atan2(CDbl(Me._YOrientation), CDbl(Me._XOrientation)))
            Me._XYAngle = Math.Atan2(CDbl(Me._YOrientation), CDbl((Me._XOrientation * -1.0F))) * 180.0 / 3.1415926535897931 - 90.0
            If Me._XYAngle < 0.0 Then
                Me._XYAngle += 360.0
            End If
            Me.nudXY.Value = New Decimal(Me._XYAngle)
            Me.DrawXYOrientation()
        End Sub

        ' Token: 0x06000B21 RID: 2849 RVA: 0x0027A780 File Offset: 0x00279780
        Public Sub SetupOrientationIndicators(ByVal XOrientation As Single, ByVal YOrientation As Single)
            Me._XOrientation = XOrientation
            Me._YOrientation = YOrientation
            Me.SetupOrientationIndicators()
        End Sub

        ' Token: 0x06000B22 RID: 2850 RVA: 0x0027A798 File Offset: 0x00279798
        Private Sub DrawXYOrientation()
            Dim graphics As Graphics = graphics.FromImage(Me.bmpXY)
            graphics.FillEllipse(Brushes.White, 0, 0, 49, 49)
            graphics.DrawArc(New Pen(Color.Black), 0, 0, 49, 49, 0, 360)
            graphics.DrawPie(New Pen(Color.Black), 0.0F, 0.0F, 49.0F, 49.0F, CSng(Me._XYAngle), 1.0F)
            Me.bmpXY.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Me.pboxXY.Image = Me.bmpXY
        End Sub

        ' Token: 0x06000B23 RID: 2851 RVA: 0x0027A82C File Offset: 0x0027982C
        Private Sub nudXY_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Me._XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientation()
            Me._XOrientation = -CSng(Math.Round(Math.Cos((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me._YOrientation = CSng(Math.Round(Math.Sin((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
        End Sub

        ' Token: 0x06000B24 RID: 2852 RVA: 0x0027A8D0 File Offset: 0x002798D0
        Private Sub nudXY_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me._XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientation()
            Me._XOrientation = -CSng(Math.Round(Math.Cos((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me._YOrientation = CSng(Math.Round(Math.Sin((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
        End Sub

        ' Token: 0x06000B25 RID: 2853 RVA: 0x0027A974 File Offset: 0x00279974
        Private Sub SetColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim colorDialog As ColorDialog = Me.ColorDialog1
            colorDialog.AllowFullOpen = True
            colorDialog.AnyColor = True
            colorDialog.Color = CType(sender, Button).BackColor
            colorDialog.FullOpen = True
            If Me.ColorDialog1.ShowDialog(Me) = DialogResult.OK Then
                CType(sender, Button).BackColor = Me.ColorDialog1.Color
            End If
        End Sub

        ' Token: 0x06000B26 RID: 2854 RVA: 0x0027A9D8 File Offset: 0x002799D8
        Private Sub trkbarXPScale_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            Me.nudXPScale.Value = New Decimal(CType(sender, TrackBar).Value)
        End Sub

        ' Token: 0x06000B27 RID: 2855 RVA: 0x0027A9F8 File Offset: 0x002799F8
        Private Sub nudXPScale_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarXPScale.Value = Convert.ToInt32(CType(sender, NumericUpDown).Value)
        End Sub

        ' Token: 0x06000B28 RID: 2856 RVA: 0x0027AA18 File Offset: 0x00279A18
        Private Sub trkbarGrassDensityX10_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            Me.nudGrassDensity.Value = New Decimal(CDbl(CType(sender, TrackBar).Value) / 10.0)
        End Sub

        ' Token: 0x06000B29 RID: 2857 RVA: 0x0027AA40 File Offset: 0x00279A40
        Private Sub nudGrassDensity_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarGrassDensityX10.Value = Convert.ToInt32(Decimal.Multiply(CType(sender, NumericUpDown).Value, 10D))
        End Sub

        ' Token: 0x06000B2A RID: 2858 RVA: 0x0027AA70 File Offset: 0x00279A70
        Private Sub nudGrassProbXX_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Single = Convert.ToSingle(Decimal.Add(Decimal.Add(Decimal.Add(Me.nudGrassProbLL.Value, Me.nudGrassProbUL.Value), Me.nudGrassProbLR.Value), Me.nudGrassProbUR.Value))
            Me.lblTotalGrassProbability.Text = "Total: " + StringType.FromSingle(num) + "%"
            If (num > 100.0F) Or (num < 100.0F) Then
                Me.lblTotalGrassProbability.BackColor = Color.Tomato
            Else
                Me.lblTotalGrassProbability.BackColor = Control.DefaultBackColor
            End If
        End Sub

        ' Token: 0x06000B2B RID: 2859 RVA: 0x0027AB14 File Offset: 0x00279B14
        Private Sub DayNight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.rbDayNightCycle.Checked Then
                Me.gbMoon.Enabled = True
                Me.gbSun.Enabled = True
            ElseIf Me.rbAlwaysNight.Checked Then
                Me.gbMoon.Enabled = True
                Me.gbSun.Enabled = False
            Else
                Me.gbMoon.Enabled = False
                Me.gbSun.Enabled = True
            End If
        End Sub

        ' Token: 0x06000B2C RID: 2860 RVA: 0x0027AB88 File Offset: 0x00279B88
        Private Sub SunFogEnabled(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarSunFogNear.Enabled = Me.chkbSunFogOn.Checked
            Me.trkbarSunFogFar.Enabled = Me.chkbSunFogOn.Checked
            Me.lblSunFogFar.Enabled = Me.chkbSunFogOn.Checked
            Me.lblSunFogNear.Enabled = Me.chkbSunFogOn.Checked
        End Sub

        ' Token: 0x06000B2D RID: 2861 RVA: 0x0027ABF0 File Offset: 0x00279BF0
        Private Sub MoonFogEnabled(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarMoonFogNear.Enabled = Me.chkbMoonFogOn.Checked
            Me.trkbarMoonFogFar.Enabled = Me.chkbMoonFogOn.Checked
            Me.lblMoonFogFar.Enabled = Me.chkbMoonFogOn.Checked
            Me.lblMoonFogNear.Enabled = Me.chkbMoonFogOn.Checked
        End Sub

        ' Token: 0x06000B2E RID: 2862 RVA: 0x0027AC58 File Offset: 0x00279C58
        Private Sub lbRooms_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lbRooms.SelectedIndex = -1 Then
                Return
            End If
            Dim room As frmModuleIfo_AreaEditor.Room = CType(Me.lbRooms.SelectedItem, frmModuleIfo_AreaEditor.Room)
            RemoveHandler Me.cmbxRoomEnvAudio.SelectedIndexChanged, AddressOf Me.cmbxRoomEnvAudio_SelectedIndexChanged
            RemoveHandler Me.nudRoomAmbientScale.ValueChanged, AddressOf Me.nudRoomAmbientScale_ValueChanged
            RemoveHandler Me.nudRoomForceRating.ValueChanged, AddressOf Me.nudRoomForceRating_ValueChanged
            RemoveHandler Me.chkbRoomDisableWeather.CheckedChanged, AddressOf Me.chkbRoomDisableWeather_CheckedChanged
            Me.tbRoomName.Text = room.RoomName
            Me.nudRoomAmbientScale.Value = New Decimal(room.AmbientScale)
            Me.nudRoomForceRating.Value = New Decimal(room.ForceRating)
            Me.chkbRoomDisableWeather.Checked = room.DisableWeather
            Me.cmbxRoomEnvAudio.SelectedIndex = room.EnvAudio
            AddHandler Me.cmbxRoomEnvAudio.SelectedIndexChanged, AddressOf Me.cmbxRoomEnvAudio_SelectedIndexChanged
            AddHandler Me.nudRoomAmbientScale.ValueChanged, AddressOf Me.nudRoomAmbientScale_ValueChanged
            AddHandler Me.nudRoomForceRating.ValueChanged, AddressOf Me.nudRoomForceRating_ValueChanged
            AddHandler Me.chkbRoomDisableWeather.CheckedChanged, AddressOf Me.chkbRoomDisableWeather_CheckedChanged
        End Sub

        ' Token: 0x06000B2F RID: 2863 RVA: 0x0027ADA4 File Offset: 0x00279DA4
        Private Sub cmbxRoomEnvAudio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rooms(Me.lbRooms.SelectedIndex).EnvAudio = Me.cmbxRoomEnvAudio.SelectedIndex
        End Sub

        ' Token: 0x06000B30 RID: 2864 RVA: 0x0027ADC8 File Offset: 0x00279DC8
        Private Sub nudRoomAmbientScale_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rooms(Me.lbRooms.SelectedIndex).AmbientScale = Convert.ToSingle(Me.nudRoomAmbientScale.Value)
        End Sub

        ' Token: 0x06000B31 RID: 2865 RVA: 0x0027ADF4 File Offset: 0x00279DF4
        Private Sub nudRoomForceRating_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rooms(Me.lbRooms.SelectedIndex).ForceRating = Convert.ToInt32(Me.nudRoomForceRating.Value)
        End Sub

        ' Token: 0x06000B32 RID: 2866 RVA: 0x0027AE20 File Offset: 0x00279E20
        Private Sub chkbRoomDisableWeather_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rooms(Me.lbRooms.SelectedIndex).DisableWeather = Me.chkbRoomDisableWeather.Checked
        End Sub

        ' Token: 0x06000B33 RID: 2867 RVA: 0x0027AE44 File Offset: 0x00279E44
        Private Sub btnSetDescriptionLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.ModDescriptionLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.ModDescriptionLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06000B34 RID: 2868 RVA: 0x0027AE74 File Offset: 0x00279E74
        Private Sub btnSetModNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.ModNameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.ModNameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06000B35 RID: 2869 RVA: 0x0027AEA4 File Offset: 0x00279EA4
        Private Sub btnSetAreaNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.AreaNameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.AreaNameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x170003B7 RID: 951
        ' (get) Token: 0x06000B36 RID: 2870 RVA: 0x0027AED4 File Offset: 0x00279ED4
        ' (set) Token: 0x06000B37 RID: 2871 RVA: 0x0027AEF4 File Offset: 0x00279EF4
        Public Property Mod_Tag() As String
            Get
                Return Me.tbModTag.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbModTag.Text = value
            End Set
        End Property

        ' Token: 0x170003B8 RID: 952
        ' (get) Token: 0x06000B38 RID: 2872 RVA: 0x0027AF04 File Offset: 0x00279F04
        ' (set) Token: 0x06000B39 RID: 2873 RVA: 0x0027AF24 File Offset: 0x00279F24
        Public Property Mod_Entry_Area() As String
            Get
                Return Me.tbModEntryArea.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbModEntryArea.Text = value
            End Set
        End Property

        ' Token: 0x170003B9 RID: 953
        ' (get) Token: 0x06000B3A RID: 2874 RVA: 0x0027AF34 File Offset: 0x00279F34
        ' (set) Token: 0x06000B3B RID: 2875 RVA: 0x0027AF54 File Offset: 0x00279F54
        Public Property Mod_Name() As String
            Get
                Return Me.tbModName.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbModName.Text = value
            End Set
        End Property

        ' Token: 0x170003BA RID: 954
        ' (get) Token: 0x06000B3C RID: 2876 RVA: 0x0027AF64 File Offset: 0x00279F64
        ' (set) Token: 0x06000B3D RID: 2877 RVA: 0x0027AF84 File Offset: 0x00279F84
        Public Property Mod_Entry_X() As Single
            Get
                Return Convert.ToSingle(Me.nudModEntryX.Value)
            End Get
            Set(ByVal value As Single)
                Me.nudModEntryX.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003BB RID: 955
        ' (get) Token: 0x06000B3E RID: 2878 RVA: 0x0027AF98 File Offset: 0x00279F98
        ' (set) Token: 0x06000B3F RID: 2879 RVA: 0x0027AFB8 File Offset: 0x00279FB8
        Public Property Mod_Entry_Y() As Single
            Get
                Return Convert.ToSingle(Me.nudModEntryY.Value)
            End Get
            Set(ByVal value As Single)
                Me.nudModEntryY.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003BC RID: 956
        ' (get) Token: 0x06000B40 RID: 2880 RVA: 0x0027AFCC File Offset: 0x00279FCC
        ' (set) Token: 0x06000B41 RID: 2881 RVA: 0x0027AFEC File Offset: 0x00279FEC
        Public Property Mod_Entry_Z() As Single
            Get
                Return Convert.ToSingle(Me.nudModEntryZ.Value)
            End Get
            Set(ByVal value As Single)
                Me.nudModEntryZ.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003BD RID: 957
        ' (get) Token: 0x06000B42 RID: 2882 RVA: 0x0027B000 File Offset: 0x0027A000
        ' (set) Token: 0x06000B43 RID: 2883 RVA: 0x0027B014 File Offset: 0x0027A014
        Private Property XOrientation() As Single
            Get
                Return Me._XOrientation
            End Get
            Set(ByVal value As Single)
                Me._XOrientation = value
            End Set
        End Property

        ' Token: 0x170003BE RID: 958
        ' (get) Token: 0x06000B44 RID: 2884 RVA: 0x0027B020 File Offset: 0x0027A020
        ' (set) Token: 0x06000B45 RID: 2885 RVA: 0x0027B034 File Offset: 0x0027A034
        Private Property YOrientation() As Single
            Get
                Return Me._YOrientation
            End Get
            Set(ByVal value As Single)
                Me._YOrientation = value
            End Set
        End Property

        ' Token: 0x170003BF RID: 959
        ' (get) Token: 0x06000B46 RID: 2886 RVA: 0x0027B040 File Offset: 0x0027A040
        ' (set) Token: 0x06000B47 RID: 2887 RVA: 0x0027B060 File Offset: 0x0027A060
        Public Property Mod_MinutesPerHour() As Integer
            Get
                Return Convert.ToInt32(Me.nudMinutesPerHour.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudMinutesPerHour.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C0 RID: 960
        ' (get) Token: 0x06000B48 RID: 2888 RVA: 0x0027B074 File Offset: 0x0027A074
        ' (set) Token: 0x06000B49 RID: 2889 RVA: 0x0027B094 File Offset: 0x0027A094
        Public Property Mod_DawnHour() As Integer
            Get
                Return Convert.ToInt32(Me.nudDawnStartHour.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudDawnStartHour.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C1 RID: 961
        ' (get) Token: 0x06000B4A RID: 2890 RVA: 0x0027B0A8 File Offset: 0x0027A0A8
        ' (set) Token: 0x06000B4B RID: 2891 RVA: 0x0027B0C8 File Offset: 0x0027A0C8
        Public Property Mod_DuskHour() As Integer
            Get
                Return Convert.ToInt32(Me.nudDuskStartHour.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudDuskStartHour.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C2 RID: 962
        ' (get) Token: 0x06000B4C RID: 2892 RVA: 0x0027B0DC File Offset: 0x0027A0DC
        ' (set) Token: 0x06000B4D RID: 2893 RVA: 0x0027B0FC File Offset: 0x0027A0FC
        Public Property Mod_StartHour() As Integer
            Get
                Return Convert.ToInt32(Me.nudStartHour.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudStartHour.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C3 RID: 963
        ' (get) Token: 0x06000B4E RID: 2894 RVA: 0x0027B110 File Offset: 0x0027A110
        ' (set) Token: 0x06000B4F RID: 2895 RVA: 0x0027B130 File Offset: 0x0027A130
        Public Property Mod_StartDay() As Integer
            Get
                Return Convert.ToInt32(Me.nudStartDay.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudStartDay.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C4 RID: 964
        ' (get) Token: 0x06000B50 RID: 2896 RVA: 0x0027B144 File Offset: 0x0027A144
        ' (set) Token: 0x06000B51 RID: 2897 RVA: 0x0027B164 File Offset: 0x0027A164
        Public Property Mod_StartMonth() As Integer
            Get
                Return Convert.ToInt32(Me.nudStartMonth.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudStartMonth.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C5 RID: 965
        ' (get) Token: 0x06000B52 RID: 2898 RVA: 0x0027B178 File Offset: 0x0027A178
        ' (set) Token: 0x06000B53 RID: 2899 RVA: 0x0027B198 File Offset: 0x0027A198
        Public Property Mod_StartYear() As Integer
            Get
                Return Convert.ToInt32(Me.nudStartYear.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudStartYear.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C6 RID: 966
        ' (get) Token: 0x06000B54 RID: 2900 RVA: 0x0027B1AC File Offset: 0x0027A1AC
        ' (set) Token: 0x06000B55 RID: 2901 RVA: 0x0027B1CC File Offset: 0x0027A1CC
        Public Property Mod_XPScale() As Integer
            Get
                Return Convert.ToInt32(Me.nudXPScale.Value)
            End Get
            Set(ByVal value As Integer)
                Me.nudXPScale.Value = New Decimal(value)
            End Set
        End Property

        ' Token: 0x170003C7 RID: 967
        ' (get) Token: 0x06000B56 RID: 2902 RVA: 0x0027B1E0 File Offset: 0x0027A1E0
        ' (set) Token: 0x06000B57 RID: 2903 RVA: 0x0027B200 File Offset: 0x0027A200
        Public Property Mod_OnAcquirItem() As String
            Get
                Return Me.tbMod_OnAcquirItem.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnAcquirItem.Text = value
            End Set
        End Property

        ' Token: 0x170003C8 RID: 968
        ' (get) Token: 0x06000B58 RID: 2904 RVA: 0x0027B210 File Offset: 0x0027A210
        ' (set) Token: 0x06000B59 RID: 2905 RVA: 0x0027B230 File Offset: 0x0027A230
        Public Property Mod_OnActvtItem() As String
            Get
                Return Me.tbMod_OnActvtItem.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnActvtItem.Text = value
            End Set
        End Property

        ' Token: 0x170003C9 RID: 969
        ' (get) Token: 0x06000B5A RID: 2906 RVA: 0x0027B240 File Offset: 0x0027A240
        ' (set) Token: 0x06000B5B RID: 2907 RVA: 0x0027B260 File Offset: 0x0027A260
        Public Property Mod_OnClientEntr() As String
            Get
                Return Me.tbMod_OnClientEntr.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnClientEntr.Text = value
            End Set
        End Property

        ' Token: 0x170003CA RID: 970
        ' (get) Token: 0x06000B5C RID: 2908 RVA: 0x0027B270 File Offset: 0x0027A270
        ' (set) Token: 0x06000B5D RID: 2909 RVA: 0x0027B290 File Offset: 0x0027A290
        Public Property Mod_OnClientLeav() As String
            Get
                Return Me.tbMod_OnClientLeav.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnClientLeav.Text = value
            End Set
        End Property

        ' Token: 0x170003CB RID: 971
        ' (get) Token: 0x06000B5E RID: 2910 RVA: 0x0027B2A0 File Offset: 0x0027A2A0
        ' (set) Token: 0x06000B5F RID: 2911 RVA: 0x0027B2C0 File Offset: 0x0027A2C0
        Public Property Mod_OnHeartbeat() As String
            Get
                Return Me.tbMod_OnHeartbeat.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnHeartbeat.Text = value
            End Set
        End Property

        ' Token: 0x170003CC RID: 972
        ' (get) Token: 0x06000B60 RID: 2912 RVA: 0x0027B2D0 File Offset: 0x0027A2D0
        ' (set) Token: 0x06000B61 RID: 2913 RVA: 0x0027B2F0 File Offset: 0x0027A2F0
        Public Property Mod_OnModLoad() As String
            Get
                Return Me.tbMod_OnModLoad.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnModLoad.Text = value
            End Set
        End Property

        ' Token: 0x170003CD RID: 973
        ' (get) Token: 0x06000B62 RID: 2914 RVA: 0x0027B300 File Offset: 0x0027A300
        ' (set) Token: 0x06000B63 RID: 2915 RVA: 0x0027B320 File Offset: 0x0027A320
        Public Property Mod_OnPlrDeath() As String
            Get
                Return Me.tbMod_OnPlrDeath.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnPlrDeath.Text = value
            End Set
        End Property

        ' Token: 0x170003CE RID: 974
        ' (get) Token: 0x06000B64 RID: 2916 RVA: 0x0027B330 File Offset: 0x0027A330
        ' (set) Token: 0x06000B65 RID: 2917 RVA: 0x0027B350 File Offset: 0x0027A350
        Public Property Mod_OnPlrDying() As String
            Get
                Return Me.tbMod_OnPlrDying.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnPlrDying.Text = value
            End Set
        End Property

        ' Token: 0x170003CF RID: 975
        ' (get) Token: 0x06000B66 RID: 2918 RVA: 0x0027B360 File Offset: 0x0027A360
        ' (set) Token: 0x06000B67 RID: 2919 RVA: 0x0027B380 File Offset: 0x0027A380
        Public Property Mod_OnPlrLvlUp() As String
            Get
                Return Me.tbMod_OnPlrLvlUp.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnPlrLvlUp.Text = value
            End Set
        End Property

        ' Token: 0x170003D0 RID: 976
        ' (get) Token: 0x06000B68 RID: 2920 RVA: 0x0027B390 File Offset: 0x0027A390
        ' (set) Token: 0x06000B69 RID: 2921 RVA: 0x0027B3B0 File Offset: 0x0027A3B0
        Public Property Mod_OnSpawnBtnDn() As String
            Get
                Return Me.tbMod_OnSpawnBtnDn.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnSpawnBtnDn.Text = value
            End Set
        End Property

        ' Token: 0x170003D1 RID: 977
        ' (get) Token: 0x06000B6A RID: 2922 RVA: 0x0027B3C0 File Offset: 0x0027A3C0
        ' (set) Token: 0x06000B6B RID: 2923 RVA: 0x0027B3E0 File Offset: 0x0027A3E0
        Public Property Mod_OnPlrRest() As String
            Get
                Return Me.tbMod_OnPlrRest.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnPlrRest.Text = value
            End Set
        End Property

        ' Token: 0x170003D2 RID: 978
        ' (get) Token: 0x06000B6C RID: 2924 RVA: 0x0027B3F0 File Offset: 0x0027A3F0
        ' (set) Token: 0x06000B6D RID: 2925 RVA: 0x0027B410 File Offset: 0x0027A410
        Public Property Mod_OnUnAqreItem() As String
            Get
                Return Me.tbMod_OnUnAqreItem.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnUnAqreItem.Text = value
            End Set
        End Property

        ' Token: 0x170003D3 RID: 979
        ' (get) Token: 0x06000B6E RID: 2926 RVA: 0x0027B420 File Offset: 0x0027A420
        ' (set) Token: 0x06000B6F RID: 2927 RVA: 0x0027B440 File Offset: 0x0027A440
        Public Property Mod_OnUsrDefined() As String
            Get
                Return Me.tbMod_OnUsrDefined.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbMod_OnUsrDefined.Text = value
            End Set
        End Property

        ' Token: 0x170003D4 RID: 980
        ' (get) Token: 0x06000B70 RID: 2928 RVA: 0x0027B450 File Offset: 0x0027A450
        ' (set) Token: 0x06000B71 RID: 2929 RVA: 0x0027B470 File Offset: 0x0027A470
        Public Property DynAmbientColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnDynAmbientColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnDynAmbientColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D5 RID: 981
        ' (get) Token: 0x06000B72 RID: 2930 RVA: 0x0027B484 File Offset: 0x0027A484
        ' (set) Token: 0x06000B73 RID: 2931 RVA: 0x0027B4A4 File Offset: 0x0027A4A4
        Public Property SunAmbientColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnSunAmbientColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnSunAmbientColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D6 RID: 982
        ' (get) Token: 0x06000B74 RID: 2932 RVA: 0x0027B4B8 File Offset: 0x0027A4B8
        ' (set) Token: 0x06000B75 RID: 2933 RVA: 0x0027B4D8 File Offset: 0x0027A4D8
        Public Property SunDiffuseColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnSunDiffuseColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnSunDiffuseColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D7 RID: 983
        ' (get) Token: 0x06000B76 RID: 2934 RVA: 0x0027B4EC File Offset: 0x0027A4EC
        ' (set) Token: 0x06000B77 RID: 2935 RVA: 0x0027B50C File Offset: 0x0027A50C
        Public Property SunFogColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnSunFogColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnSunFogColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D8 RID: 984
        ' (get) Token: 0x06000B78 RID: 2936 RVA: 0x0027B520 File Offset: 0x0027A520
        ' (set) Token: 0x06000B79 RID: 2937 RVA: 0x0027B540 File Offset: 0x0027A540
        Public Property MoonAmbientColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnMoonAmbientColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnMoonAmbientColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003D9 RID: 985
        ' (get) Token: 0x06000B7A RID: 2938 RVA: 0x0027B554 File Offset: 0x0027A554
        ' (set) Token: 0x06000B7B RID: 2939 RVA: 0x0027B574 File Offset: 0x0027A574
        Public Property MoonDiffuseColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnMoonDiffuseColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnMoonDiffuseColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DA RID: 986
        ' (get) Token: 0x06000B7C RID: 2940 RVA: 0x0027B588 File Offset: 0x0027A588
        ' (set) Token: 0x06000B7D RID: 2941 RVA: 0x0027B5A8 File Offset: 0x0027A5A8
        Public Property MoonFogColor() As UInteger
            Get
                Return Me.color2bgr(Me.btnMoonFogColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnMoonFogColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DB RID: 987
        ' (get) Token: 0x06000B7E RID: 2942 RVA: 0x0027B5BC File Offset: 0x0027A5BC
        ' (set) Token: 0x06000B7F RID: 2943 RVA: 0x0027B5DC File Offset: 0x0027A5DC
        Public Property Grass_Ambient() As UInteger
            Get
                Return Me.color2bgr(Me.btnGrassAmbientColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnGrassAmbientColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DC RID: 988
        ' (get) Token: 0x06000B80 RID: 2944 RVA: 0x0027B5F0 File Offset: 0x0027A5F0
        ' (set) Token: 0x06000B81 RID: 2945 RVA: 0x0027B610 File Offset: 0x0027A610
        Public Property Grass_Diffuse() As UInteger
            Get
                Return Me.color2bgr(Me.btnGrassDiffuseColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnGrassDiffuseColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DD RID: 989
        ' (get) Token: 0x06000B82 RID: 2946 RVA: 0x0027B624 File Offset: 0x0027A624
        ' (set) Token: 0x06000B83 RID: 2947 RVA: 0x0027B644 File Offset: 0x0027A644
        Public Property Grass_Emissive() As UInteger
            Get
                Return Me.color2bgr(Me.btnGrassEmissiveColor.BackColor)
            End Get
            Set(ByVal value As UInteger)
                Me.btnGrassEmissiveColor.BackColor = Me.bgr2color(value)
            End Set
        End Property

        ' Token: 0x170003DE RID: 990
        ' (get) Token: 0x06000B84 RID: 2948 RVA: 0x0027B658 File Offset: 0x0027A658
        ' (set) Token: 0x06000B85 RID: 2949 RVA: 0x0027B688 File Offset: 0x0027A688
        Public Property Grass_Prob_LL() As Single
            Get
                Return Convert.ToSingle(Decimal.Divide(Me.nudGrassProbLL.Value, 100D))
            End Get
            Set(ByVal value As Single)
                Me.nudGrassProbLL.Value = New Decimal(value * 100.0F)
            End Set
        End Property

        ' Token: 0x170003DF RID: 991
        ' (get) Token: 0x06000B86 RID: 2950 RVA: 0x0027B6A4 File Offset: 0x0027A6A4
        ' (set) Token: 0x06000B87 RID: 2951 RVA: 0x0027B6D4 File Offset: 0x0027A6D4
        Public Property Grass_Prob_UL() As Single
            Get
                Return Convert.ToSingle(Decimal.Divide(Me.nudGrassProbUL.Value, 100D))
            End Get
            Set(ByVal value As Single)
                Me.nudGrassProbUL.Value = New Decimal(value * 100.0F)
            End Set
        End Property

        ' Token: 0x170003E0 RID: 992
        ' (get) Token: 0x06000B88 RID: 2952 RVA: 0x0027B6F0 File Offset: 0x0027A6F0
        ' (set) Token: 0x06000B89 RID: 2953 RVA: 0x0027B720 File Offset: 0x0027A720
        Public Property Grass_Prob_LR() As Single
            Get
                Return Convert.ToSingle(Decimal.Divide(Me.nudGrassProbLR.Value, 100D))
            End Get
            Set(ByVal value As Single)
                Me.nudGrassProbLR.Value = New Decimal(value * 100.0F)
            End Set
        End Property

        ' Token: 0x170003E1 RID: 993
        ' (get) Token: 0x06000B8A RID: 2954 RVA: 0x0027B73C File Offset: 0x0027A73C
        ' (set) Token: 0x06000B8B RID: 2955 RVA: 0x0027B76C File Offset: 0x0027A76C
        Public Property Grass_Prob_UR() As Single
            Get
                Return Convert.ToSingle(Decimal.Divide(Me.nudGrassProbUR.Value, 100D))
            End Get
            Set(ByVal value As Single)
                Me.nudGrassProbUR.Value = New Decimal(value * 100.0F)
            End Set
        End Property

        ' Token: 0x170003E2 RID: 994
        ' (get) Token: 0x06000B8C RID: 2956 RVA: 0x0027B788 File Offset: 0x0027A788
        Public ReadOnly Property ModEntryChanged() As Boolean
            Get
                Return Me._origXOrientation <> Me._XOrientation OrElse Me._origYOrientation <> Me._YOrientation OrElse Me._origXPos <> Me.Mod_Entry_X OrElse Me._origYpos <> Me.Mod_Entry_Y OrElse Me._origZpos <> Me.Mod_Entry_Z
            End Get
        End Property

        ' Token: 0x040004DF RID: 1247
        <AccessedThroughProperty("rbAlwaysDay")> _
        Private _rbAlwaysDay As RadioButton

        ' Token: 0x040004E0 RID: 1248
        <AccessedThroughProperty("rbDayNightCycle")> _
        Private _rbDayNightCycle As RadioButton

        ' Token: 0x040004E1 RID: 1249
        <AccessedThroughProperty("btnMoonAmbientColor")> _
        Private _btnMoonAmbientColor As Button

        ' Token: 0x040004E2 RID: 1250
        <AccessedThroughProperty("btnMoonDiffuseColor")> _
        Private _btnMoonDiffuseColor As Button

        ' Token: 0x040004E3 RID: 1251
        <AccessedThroughProperty("chkbAreaSunShadows")> _
        Private _chkbAreaSunShadows As CheckBox

        ' Token: 0x040004E4 RID: 1252
        <AccessedThroughProperty("gbMoon")> _
        Private _gbMoon As GroupBox

        ' Token: 0x040004E5 RID: 1253
        <AccessedThroughProperty("gbSun")> _
        Private _gbSun As GroupBox

        ' Token: 0x040004E6 RID: 1254
        <AccessedThroughProperty("btnSunAmbientColor")> _
        Private _btnSunAmbientColor As Button

        ' Token: 0x040004E7 RID: 1255
        <AccessedThroughProperty("btnSunDiffuseColor")> _
        Private _btnSunDiffuseColor As Button

        ' Token: 0x040004E8 RID: 1256
        <AccessedThroughProperty("tabpagAreaEnvironment")> _
        Private _tabpagAreaEnvironment As TabPage

        ' Token: 0x040004E9 RID: 1257
        <AccessedThroughProperty("tabpagAreaGrass")> _
        Private _tabpagAreaGrass As TabPage

        ' Token: 0x040004EA RID: 1258
        <AccessedThroughProperty("tabpagAreaBasic")> _
        Private _tabpagAreaBasic As TabPage

        ' Token: 0x040004EB RID: 1259
        <AccessedThroughProperty("btnGrassEmissiveColor")> _
        Private _btnGrassEmissiveColor As Button

        ' Token: 0x040004EC RID: 1260
        <AccessedThroughProperty("Label45")> _
        Private _Label45 As Label

        ' Token: 0x040004ED RID: 1261
        <AccessedThroughProperty("Label47")> _
        Private _Label47 As Label

        ' Token: 0x040004EE RID: 1262
        <AccessedThroughProperty("Label49")> _
        Private _Label49 As Label

        ' Token: 0x040004EF RID: 1263
        <AccessedThroughProperty("Label50")> _
        Private _Label50 As Label

        ' Token: 0x040004F0 RID: 1264
        <AccessedThroughProperty("Label51")> _
        Private _Label51 As Label

        ' Token: 0x040004F1 RID: 1265
        <AccessedThroughProperty("tabpagAreaAudio")> _
        Private _tabpagAreaAudio As TabPage

        ' Token: 0x040004F2 RID: 1266
        <AccessedThroughProperty("Label52")> _
        Private _Label52 As Label

        ' Token: 0x040004F3 RID: 1267
        <AccessedThroughProperty("trkbarAmbientSndDayVol")> _
        Private _trkbarAmbientSndDayVol As TrackBar

        ' Token: 0x040004F4 RID: 1268
        <AccessedThroughProperty("Label34")> _
        Private _Label34 As Label

        ' Token: 0x040004F5 RID: 1269
        <AccessedThroughProperty("cmbxAmbientSndDay")> _
        Private _cmbxAmbientSndDay As ComboBox

        ' Token: 0x040004F6 RID: 1270
        <AccessedThroughProperty("trkbarAmbientSndNightVol")> _
        Private _trkbarAmbientSndNightVol As TrackBar

        ' Token: 0x040004F7 RID: 1271
        <AccessedThroughProperty("nudMusicDelay")> _
        Private _nudMusicDelay As NumericUpDown

        ' Token: 0x040004F8 RID: 1272
        <AccessedThroughProperty("cmbxMusicNight")> _
        Private _cmbxMusicNight As ComboBox

        ' Token: 0x040004F9 RID: 1273
        <AccessedThroughProperty("Label35")> _
        Private _Label35 As Label

        ' Token: 0x040004FA RID: 1274
        <AccessedThroughProperty("Label25")> _
        Private _Label25 As Label

        ' Token: 0x040004FB RID: 1275
        <AccessedThroughProperty("cmbxMusicDay")> _
        Private _cmbxMusicDay As ComboBox

        ' Token: 0x040004FC RID: 1276
        <AccessedThroughProperty("Label36")> _
        Private _Label36 As Label

        ' Token: 0x040004FD RID: 1277
        <AccessedThroughProperty("cmbxMusicBattle")> _
        Private _cmbxMusicBattle As ComboBox

        ' Token: 0x040004FE RID: 1278
        <AccessedThroughProperty("cmbxEnvAudio")> _
        Private _cmbxEnvAudio As ComboBox

        ' Token: 0x040004FF RID: 1279
        <AccessedThroughProperty("cmbxAmbientSndNight")> _
        Private _cmbxAmbientSndNight As ComboBox

        ' Token: 0x04000500 RID: 1280
        <AccessedThroughProperty("tbGrass_TexName")> _
        Private _tbGrass_TexName As TextBox

        ' Token: 0x04000501 RID: 1281
        <AccessedThroughProperty("trkbarGrassDensityX10")> _
        Private _trkbarGrassDensityX10 As TrackBar

        ' Token: 0x04000502 RID: 1282
        <AccessedThroughProperty("Label62")> _
        Private _Label62 As Label

        ' Token: 0x04000503 RID: 1283
        <AccessedThroughProperty("nudGrassDensity")> _
        Private _nudGrassDensity As NumericUpDown

        ' Token: 0x04000504 RID: 1284
        <AccessedThroughProperty("Label63")> _
        Private _Label63 As Label

        ' Token: 0x04000505 RID: 1285
        <AccessedThroughProperty("Label31")> _
        Private _Label31 As Label

        ' Token: 0x04000506 RID: 1286
        <AccessedThroughProperty("Label64")> _
        Private _Label64 As Label

        ' Token: 0x04000507 RID: 1287
        <AccessedThroughProperty("Label53")> _
        Private _Label53 As Label

        ' Token: 0x04000508 RID: 1288
        <AccessedThroughProperty("Label54")> _
        Private _Label54 As Label

        ' Token: 0x04000509 RID: 1289
        <AccessedThroughProperty("Label55")> _
        Private _Label55 As Label

        ' Token: 0x0400050A RID: 1290
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x0400050B RID: 1291
        <AccessedThroughProperty("Label37")> _
        Private _Label37 As Label

        ' Token: 0x0400050C RID: 1292
        <AccessedThroughProperty("lblSunFogNear")> _
        Private _lblSunFogNear As Label

        ' Token: 0x0400050D RID: 1293
        <AccessedThroughProperty("lblMoonFogFar")> _
        Private _lblMoonFogFar As Label

        ' Token: 0x0400050E RID: 1294
        <AccessedThroughProperty("Label33")> _
        Private _Label33 As Label

        ' Token: 0x0400050F RID: 1295
        <AccessedThroughProperty("lblMoonFogNear")> _
        Private _lblMoonFogNear As Label

        ' Token: 0x04000510 RID: 1296
        <AccessedThroughProperty("Label65")> _
        Private _Label65 As Label

        ' Token: 0x04000511 RID: 1297
        <AccessedThroughProperty("Label66")> _
        Private _Label66 As Label

        ' Token: 0x04000512 RID: 1298
        <AccessedThroughProperty("Label67")> _
        Private _Label67 As Label

        ' Token: 0x04000513 RID: 1299
        <AccessedThroughProperty("nudGrassProbUL")> _
        Private _nudGrassProbUL As NumericUpDown

        ' Token: 0x04000514 RID: 1300
        <AccessedThroughProperty("nudGrassProbLL")> _
        Private _nudGrassProbLL As NumericUpDown

        ' Token: 0x04000515 RID: 1301
        <AccessedThroughProperty("nudGrassProbUR")> _
        Private _nudGrassProbUR As NumericUpDown

        ' Token: 0x04000516 RID: 1302
        <AccessedThroughProperty("Label38")> _
        Private _Label38 As Label

        ' Token: 0x04000517 RID: 1303
        <AccessedThroughProperty("tbModEntryArea")> _
        Private _tbModEntryArea As TextBox

        ' Token: 0x04000518 RID: 1304
        <AccessedThroughProperty("lblBearing")> _
        Private _lblBearing As Label

        ' Token: 0x04000519 RID: 1305
        <AccessedThroughProperty("nudXY")> _
        Private _nudXY As NumericUpDown

        ' Token: 0x0400051A RID: 1306
        <AccessedThroughProperty("pboxXY")> _
        Private _pboxXY As PictureBox

        ' Token: 0x0400051B RID: 1307
        <AccessedThroughProperty("Label86")> _
        Private _Label86 As Label

        ' Token: 0x0400051C RID: 1308
        <AccessedThroughProperty("chkbDisableTransit")> _
        Private _chkbDisableTransit As CheckBox

        ' Token: 0x0400051D RID: 1309
        <AccessedThroughProperty("Label85")> _
        Private _Label85 As Label

        ' Token: 0x0400051E RID: 1310
        <AccessedThroughProperty("chkbUnescapable")> _
        Private _chkbUnescapable As CheckBox

        ' Token: 0x0400051F RID: 1311
        <AccessedThroughProperty("Label84")> _
        Private _Label84 As Label

        ' Token: 0x04000520 RID: 1312
        <AccessedThroughProperty("cmbxWindPower")> _
        Private _cmbxWindPower As ComboBox

        ' Token: 0x04000521 RID: 1313
        <AccessedThroughProperty("btnSetAreaNameLang")> _
        Private _btnSetAreaNameLang As Button

        ' Token: 0x04000522 RID: 1314
        <AccessedThroughProperty("btnSetModNameLang")> _
        Private _btnSetModNameLang As Button

        ' Token: 0x04000523 RID: 1315
        <AccessedThroughProperty("tbModDescription")> _
        Private _tbModDescription As TextBox

        ' Token: 0x04000524 RID: 1316
        <AccessedThroughProperty("nudRoomForceRating")> _
        Private _nudRoomForceRating As NumericUpDown

        ' Token: 0x04000525 RID: 1317
        <AccessedThroughProperty("tbRoomName")> _
        Private _tbRoomName As TextBox

        ' Token: 0x04000526 RID: 1318
        <AccessedThroughProperty("cmbxRoomEnvAudio")> _
        Private _cmbxRoomEnvAudio As ComboBox

        ' Token: 0x04000527 RID: 1319
        <AccessedThroughProperty("nudRoomAmbientScale")> _
        Private _nudRoomAmbientScale As NumericUpDown

        ' Token: 0x04000528 RID: 1320
        <AccessedThroughProperty("chkbRoomDisableWeather")> _
        Private _chkbRoomDisableWeather As CheckBox

        ' Token: 0x04000529 RID: 1321
        <AccessedThroughProperty("Label83")> _
        Private _Label83 As Label

        ' Token: 0x0400052A RID: 1322
        <AccessedThroughProperty("lbRooms")> _
        Private _lbRooms As ListBox

        ' Token: 0x0400052B RID: 1323
        <AccessedThroughProperty("Label56")> _
        Private _Label56 As Label

        ' Token: 0x0400052C RID: 1324
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x0400052D RID: 1325
        <AccessedThroughProperty("Label57")> _
        Private _Label57 As Label

        ' Token: 0x0400052E RID: 1326
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x0400052F RID: 1327
        <AccessedThroughProperty("Label82")> _
        Private _Label82 As Label

        ' Token: 0x04000530 RID: 1328
        <AccessedThroughProperty("Label58")> _
        Private _Label58 As Label

        ' Token: 0x04000531 RID: 1329
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x04000532 RID: 1330
        <AccessedThroughProperty("Label59")> _
        Private _Label59 As Label

        ' Token: 0x04000533 RID: 1331
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x04000534 RID: 1332
        <AccessedThroughProperty("Label60")> _
        Private _Label60 As Label

        ' Token: 0x04000535 RID: 1333
        <AccessedThroughProperty("Label81")> _
        Private _Label81 As Label

        ' Token: 0x04000536 RID: 1334
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x04000537 RID: 1335
        <AccessedThroughProperty("Label61")> _
        Private _Label61 As Label

        ' Token: 0x04000538 RID: 1336
        <AccessedThroughProperty("tabpagModuleBasic")> _
        Private _tabpagModuleBasic As TabPage

        ' Token: 0x04000539 RID: 1337
        <AccessedThroughProperty("tabpagModuleAdvanced")> _
        Private _tabpagModuleAdvanced As TabPage

        ' Token: 0x0400053A RID: 1338
        <AccessedThroughProperty("btnGrassAmbientColor")> _
        Private _btnGrassAmbientColor As Button

        ' Token: 0x0400053B RID: 1339
        <AccessedThroughProperty("nudGrassProbLR")> _
        Private _nudGrassProbLR As NumericUpDown

        ' Token: 0x0400053C RID: 1340
        <AccessedThroughProperty("btnGrassDiffuseColor")> _
        Private _btnGrassDiffuseColor As Button

        ' Token: 0x0400053D RID: 1341
        <AccessedThroughProperty("Label80")> _
        Private _Label80 As Label

        ' Token: 0x0400053E RID: 1342
        <AccessedThroughProperty("Label79")> _
        Private _Label79 As Label

        ' Token: 0x0400053F RID: 1343
        <AccessedThroughProperty("Label78")> _
        Private _Label78 As Label

        ' Token: 0x04000540 RID: 1344
        <AccessedThroughProperty("tabpagAreaRooms")> _
        Private _tabpagAreaRooms As TabPage

        ' Token: 0x04000541 RID: 1345
        <AccessedThroughProperty("tbArea_OnUserDefined")> _
        Private _tbArea_OnUserDefined As TextBox

        ' Token: 0x04000542 RID: 1346
        <AccessedThroughProperty("Label77")> _
        Private _Label77 As Label

        ' Token: 0x04000543 RID: 1347
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000544 RID: 1348
        <AccessedThroughProperty("Label76")> _
        Private _Label76 As Label

        ' Token: 0x04000545 RID: 1349
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000546 RID: 1350
        <AccessedThroughProperty("tbArea_OnHeartbeat")> _
        Private _tbArea_OnHeartbeat As TextBox

        ' Token: 0x04000547 RID: 1351
        <AccessedThroughProperty("tbArea_OnExit")> _
        Private _tbArea_OnExit As TextBox

        ' Token: 0x04000548 RID: 1352
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000549 RID: 1353
        <AccessedThroughProperty("Label75")> _
        Private _Label75 As Label

        ' Token: 0x0400054A RID: 1354
        <AccessedThroughProperty("tbArea_OnEnter")> _
        Private _tbArea_OnEnter As TextBox

        ' Token: 0x0400054B RID: 1355
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x0400054C RID: 1356
        <AccessedThroughProperty("Label74")> _
        Private _Label74 As Label

        ' Token: 0x0400054D RID: 1357
        <AccessedThroughProperty("ColorDialog1")> _
        Private _ColorDialog1 As ColorDialog

        ' Token: 0x0400054E RID: 1358
        <AccessedThroughProperty("TabControlArea")> _
        Private _TabControlArea As TabControl

        ' Token: 0x0400054F RID: 1359
        <AccessedThroughProperty("TabControlMain")> _
        Private _TabControlMain As TabControl

        ' Token: 0x04000550 RID: 1360
        <AccessedThroughProperty("TabControlModule")> _
        Private _TabControlModule As TabControl

        ' Token: 0x04000551 RID: 1361
        <AccessedThroughProperty("NumericUpDown12")> _
        Private _NumericUpDown12 As NumericUpDown

        ' Token: 0x04000552 RID: 1362
        <AccessedThroughProperty("tabpagArea_Events")> _
        Private _tabpagArea_Events As TabPage

        ' Token: 0x04000553 RID: 1363
        <AccessedThroughProperty("tabpagModuleEvents")> _
        Private _tabpagModuleEvents As TabPage

        ' Token: 0x04000554 RID: 1364
        <AccessedThroughProperty("tabpagModuleDescription")> _
        Private _tabpagModuleDescription As TabPage

        ' Token: 0x04000555 RID: 1365
        <AccessedThroughProperty("nudModEntryX")> _
        Private _nudModEntryX As NumericUpDown

        ' Token: 0x04000556 RID: 1366
        <AccessedThroughProperty("nudModEntryY")> _
        Private _nudModEntryY As NumericUpDown

        ' Token: 0x04000557 RID: 1367
        <AccessedThroughProperty("Label48")> _
        Private _Label48 As Label

        ' Token: 0x04000558 RID: 1368
        <AccessedThroughProperty("Label32")> _
        Private _Label32 As Label

        ' Token: 0x04000559 RID: 1369
        <AccessedThroughProperty("btnDynAmbientColor")> _
        Private _btnDynAmbientColor As Button

        ' Token: 0x0400055A RID: 1370
        <AccessedThroughProperty("lblSunFogFar")> _
        Private _lblSunFogFar As Label

        ' Token: 0x0400055B RID: 1371
        <AccessedThroughProperty("nudModEntryZ")> _
        Private _nudModEntryZ As NumericUpDown

        ' Token: 0x0400055C RID: 1372
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox

        ' Token: 0x0400055D RID: 1373
        <AccessedThroughProperty("lblTotalGrassProbability")> _
        Private _lblTotalGrassProbability As Label

        ' Token: 0x0400055E RID: 1374
        <AccessedThroughProperty("tbModTag")> _
        Private _tbModTag As TextBox

        ' Token: 0x0400055F RID: 1375
        <AccessedThroughProperty("nudShadowOpacity")> _
        Private _nudShadowOpacity As NumericUpDown

        ' Token: 0x04000560 RID: 1376
        <AccessedThroughProperty("tbModName")> _
        Private _tbModName As TextBox

        ' Token: 0x04000561 RID: 1377
        <AccessedThroughProperty("nudMinutesPerHour")> _
        Private _nudMinutesPerHour As NumericUpDown

        ' Token: 0x04000562 RID: 1378
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000563 RID: 1379
        <AccessedThroughProperty("nudDawnStartHour")> _
        Private _nudDawnStartHour As NumericUpDown

        ' Token: 0x04000564 RID: 1380
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x04000565 RID: 1381
        <AccessedThroughProperty("nudDuskStartHour")> _
        Private _nudDuskStartHour As NumericUpDown

        ' Token: 0x04000566 RID: 1382
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000567 RID: 1383
        <AccessedThroughProperty("Label73")> _
        Private _Label73 As Label

        ' Token: 0x04000568 RID: 1384
        <AccessedThroughProperty("cmbxCameraStyle")> _
        Private _cmbxCameraStyle As ComboBox

        ' Token: 0x04000569 RID: 1385
        <AccessedThroughProperty("tbAreaName")> _
        Private _tbAreaName As TextBox

        ' Token: 0x0400056A RID: 1386
        <AccessedThroughProperty("nudStartHour")> _
        Private _nudStartHour As NumericUpDown

        ' Token: 0x0400056B RID: 1387
        <AccessedThroughProperty("tbAreaTag")> _
        Private _tbAreaTag As TextBox

        ' Token: 0x0400056C RID: 1388
        <AccessedThroughProperty("nudStartDay")> _
        Private _nudStartDay As NumericUpDown

        ' Token: 0x0400056D RID: 1389
        <AccessedThroughProperty("nudStartMonth")> _
        Private _nudStartMonth As NumericUpDown

        ' Token: 0x0400056E RID: 1390
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x0400056F RID: 1391
        <AccessedThroughProperty("Label40")> _
        Private _Label40 As Label

        ' Token: 0x04000570 RID: 1392
        <AccessedThroughProperty("Label41")> _
        Private _Label41 As Label

        ' Token: 0x04000571 RID: 1393
        <AccessedThroughProperty("Label42")> _
        Private _Label42 As Label

        ' Token: 0x04000572 RID: 1394
        <AccessedThroughProperty("Label43")> _
        Private _Label43 As Label

        ' Token: 0x04000573 RID: 1395
        <AccessedThroughProperty("Label44")> _
        Private _Label44 As Label

        ' Token: 0x04000574 RID: 1396
        <AccessedThroughProperty("Label46")> _
        Private _Label46 As Label

        ' Token: 0x04000575 RID: 1397
        <AccessedThroughProperty("nudXPScale")> _
        Private _nudXPScale As NumericUpDown

        ' Token: 0x04000576 RID: 1398
        <AccessedThroughProperty("trkbarXPScale")> _
        Private _trkbarXPScale As TrackBar

        ' Token: 0x04000577 RID: 1399
        <AccessedThroughProperty("nudGrassQuadSize")> _
        Private _nudGrassQuadSize As NumericUpDown

        ' Token: 0x04000578 RID: 1400
        <AccessedThroughProperty("Label26")> _
        Private _Label26 As Label

        ' Token: 0x04000579 RID: 1401
        <AccessedThroughProperty("nudStartYear")> _
        Private _nudStartYear As NumericUpDown

        ' Token: 0x0400057A RID: 1402
        <AccessedThroughProperty("tbMod_OnClientEntr")> _
        Private _tbMod_OnClientEntr As TextBox

        ' Token: 0x0400057B RID: 1403
        <AccessedThroughProperty("tbMod_OnActvtItem")> _
        Private _tbMod_OnActvtItem As TextBox

        ' Token: 0x0400057C RID: 1404
        <AccessedThroughProperty("Label68")> _
        Private _Label68 As Label

        ' Token: 0x0400057D RID: 1405
        <AccessedThroughProperty("btnSetDescriptionLang")> _
        Private _btnSetDescriptionLang As Button

        ' Token: 0x0400057E RID: 1406
        <AccessedThroughProperty("Label72")> _
        Private _Label72 As Label

        ' Token: 0x0400057F RID: 1407
        <AccessedThroughProperty("Label27")> _
        Private _Label27 As Label

        ' Token: 0x04000580 RID: 1408
        <AccessedThroughProperty("tbMod_OnAcquirItem")> _
        Private _tbMod_OnAcquirItem As TextBox

        ' Token: 0x04000581 RID: 1409
        <AccessedThroughProperty("tbMod_OnClientLeav")> _
        Private _tbMod_OnClientLeav As TextBox

        ' Token: 0x04000582 RID: 1410
        <AccessedThroughProperty("Label13")> _
        Private _Label13 As Label

        ' Token: 0x04000583 RID: 1411
        <AccessedThroughProperty("tbMod_OnHeartbeat")> _
        Private _tbMod_OnHeartbeat As TextBox

        ' Token: 0x04000584 RID: 1412
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x04000585 RID: 1413
        <AccessedThroughProperty("Label28")> _
        Private _Label28 As Label

        ' Token: 0x04000586 RID: 1414
        <AccessedThroughProperty("tbMod_OnModLoad")> _
        Private _tbMod_OnModLoad As TextBox

        ' Token: 0x04000587 RID: 1415
        <AccessedThroughProperty("nudChanceLightning")> _
        Private _nudChanceLightning As NumericUpDown

        ' Token: 0x04000588 RID: 1416
        <AccessedThroughProperty("Label71")> _
        Private _Label71 As Label

        ' Token: 0x04000589 RID: 1417
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x0400058A RID: 1418
        <AccessedThroughProperty("btnMoonFogColor")> _
        Private _btnMoonFogColor As Button

        ' Token: 0x0400058B RID: 1419
        <AccessedThroughProperty("Label16")> _
        Private _Label16 As Label

        ' Token: 0x0400058C RID: 1420
        <AccessedThroughProperty("Label29")> _
        Private _Label29 As Label

        ' Token: 0x0400058D RID: 1421
        <AccessedThroughProperty("chkbAreaMoonShadows")> _
        Private _chkbAreaMoonShadows As CheckBox

        ' Token: 0x0400058E RID: 1422
        <AccessedThroughProperty("Label17")> _
        Private _Label17 As Label

        ' Token: 0x0400058F RID: 1423
        <AccessedThroughProperty("btnSunFogColor")> _
        Private _btnSunFogColor As Button

        ' Token: 0x04000590 RID: 1424
        <AccessedThroughProperty("Label18")> _
        Private _Label18 As Label

        ' Token: 0x04000591 RID: 1425
        <AccessedThroughProperty("rbAlwaysNight")> _
        Private _rbAlwaysNight As RadioButton

        ' Token: 0x04000592 RID: 1426
        <AccessedThroughProperty("Label19")> _
        Private _Label19 As Label

        ' Token: 0x04000593 RID: 1427
        <AccessedThroughProperty("tbMod_OnPlrDeath")> _
        Private _tbMod_OnPlrDeath As TextBox

        ' Token: 0x04000594 RID: 1428
        <AccessedThroughProperty("Label20")> _
        Private _Label20 As Label

        ' Token: 0x04000595 RID: 1429
        <AccessedThroughProperty("Label70")> _
        Private _Label70 As Label

        ' Token: 0x04000596 RID: 1430
        <AccessedThroughProperty("tbMod_OnPlrDying")> _
        Private _tbMod_OnPlrDying As TextBox

        ' Token: 0x04000597 RID: 1431
        <AccessedThroughProperty("Label21")> _
        Private _Label21 As Label

        ' Token: 0x04000598 RID: 1432
        <AccessedThroughProperty("tbMod_OnPlrLvlUp")> _
        Private _tbMod_OnPlrLvlUp As TextBox

        ' Token: 0x04000599 RID: 1433
        <AccessedThroughProperty("TabPage5")> _
        Private _TabPage5 As TabPage

        ' Token: 0x0400059A RID: 1434
        <AccessedThroughProperty("TabPage6")> _
        Private _TabPage6 As TabPage

        ' Token: 0x0400059B RID: 1435
        <AccessedThroughProperty("NumericUpDown10")> _
        Private _NumericUpDown10 As NumericUpDown

        ' Token: 0x0400059C RID: 1436
        <AccessedThroughProperty("NumericUpDown11")> _
        Private _NumericUpDown11 As NumericUpDown

        ' Token: 0x0400059D RID: 1437
        <AccessedThroughProperty("Label22")> _
        Private _Label22 As Label

        ' Token: 0x0400059E RID: 1438
        <AccessedThroughProperty("tbMod_OnSpawnBtnDn")> _
        Private _tbMod_OnSpawnBtnDn As TextBox

        ' Token: 0x0400059F RID: 1439
        <AccessedThroughProperty("Label23")> _
        Private _Label23 As Label

        ' Token: 0x040005A0 RID: 1440
        <AccessedThroughProperty("tbMod_OnPlrRest")> _
        Private _tbMod_OnPlrRest As TextBox

        ' Token: 0x040005A1 RID: 1441
        <AccessedThroughProperty("Label24")> _
        Private _Label24 As Label

        ' Token: 0x040005A2 RID: 1442
        <AccessedThroughProperty("Label69")> _
        Private _Label69 As Label

        ' Token: 0x040005A3 RID: 1443
        <AccessedThroughProperty("tbMod_OnUnAqreItem")> _
        Private _tbMod_OnUnAqreItem As TextBox

        ' Token: 0x040005A4 RID: 1444
        <AccessedThroughProperty("tbMod_OnUsrDefined")> _
        Private _tbMod_OnUsrDefined As TextBox

        ' Token: 0x040005A5 RID: 1445
        <AccessedThroughProperty("chkbSunFogOn")> _
        Private _chkbSunFogOn As CheckBox

        ' Token: 0x040005A6 RID: 1446
        <AccessedThroughProperty("chkbMoonFogOn")> _
        Private _chkbMoonFogOn As CheckBox

        ' Token: 0x040005A7 RID: 1447
        <AccessedThroughProperty("trkbarSunFogNear")> _
        Private _trkbarSunFogNear As TrackBar

        ' Token: 0x040005A8 RID: 1448
        <AccessedThroughProperty("trkbarSunFogFar")> _
        Private _trkbarSunFogFar As TrackBar

        ' Token: 0x040005A9 RID: 1449
        <AccessedThroughProperty("Label30")> _
        Private _Label30 As Label

        ' Token: 0x040005AA RID: 1450
        <AccessedThroughProperty("Label39")> _
        Private _Label39 As Label

        ' Token: 0x040005AB RID: 1451
        <AccessedThroughProperty("trkbarMoonFogNear")> _
        Private _trkbarMoonFogNear As TrackBar

        ' Token: 0x040005AC RID: 1452
        <AccessedThroughProperty("trkbarMoonFogFar")> _
        Private _trkbarMoonFogFar As TrackBar

        ' Token: 0x040005AD RID: 1453
        <AccessedThroughProperty("nudChanceSnow")> _
        Private _nudChanceSnow As NumericUpDown

        ' Token: 0x040005AE RID: 1454
        <AccessedThroughProperty("nudChanceRain")> _
        Private _nudChanceRain As NumericUpDown

        ' Token: 0x040005B0 RID: 1456
        Private _AREFile As clsGFF

        ' Token: 0x040005B1 RID: 1457
        Private _IFOFile As clsGFF

        ' Token: 0x040005B2 RID: 1458
        Private _GITFile As clsGFF

        ' Token: 0x040005B3 RID: 1459
        Private _ChitinKey As clsChitinKey

        ' Token: 0x040005B4 RID: 1460
        Private _DialogTlk As clsDialogTlk

        ' Token: 0x040005B5 RID: 1461
        Private ComboBoxSettingError As Boolean

        ' Token: 0x040005B6 RID: 1462
        Private Rooms As frmModuleIfo_AreaEditor.Room()

        ' Token: 0x040005B7 RID: 1463
        Private bmpXY As Bitmap

        ' Token: 0x040005B8 RID: 1464
        Private _XYAngle As Double

        ' Token: 0x040005B9 RID: 1465
        Private _XOrientation As Single

        ' Token: 0x040005BA RID: 1466
        Private _YOrientation As Single

        ' Token: 0x040005BB RID: 1467
        Private _origXOrientation As Single

        ' Token: 0x040005BC RID: 1468
        Private _origYOrientation As Single

        ' Token: 0x040005BD RID: 1469
        Private _Bearing As Single

        ' Token: 0x040005BE RID: 1470
        Private _Xpos As Single

        ' Token: 0x040005BF RID: 1471
        Private _origXPos As Single

        ' Token: 0x040005C0 RID: 1472
        Private _Ypos As Single

        ' Token: 0x040005C1 RID: 1473
        Private _origYpos As Single

        ' Token: 0x040005C2 RID: 1474
        Private _Zpos As Single

        ' Token: 0x040005C3 RID: 1475
        Private _origZpos As Single

        ' Token: 0x040005C4 RID: 1476
        Private ModDescriptionLang As Integer

        ' Token: 0x040005C5 RID: 1477
        Private ModNameLang As Integer

        ' Token: 0x040005C6 RID: 1478
        Private AreaNameLang As Integer

        ' Token: 0x02000062 RID: 98
        Private Class Room
            ' Token: 0x170003E3 RID: 995
            ' (get) Token: 0x06000B8E RID: 2958 RVA: 0x0027B7E8 File Offset: 0x0027A7E8
            Public ReadOnly Property Text() As String
                Get
                    Return Me.RoomName
                End Get
            End Property

            ' Token: 0x040005C7 RID: 1479
            Public RoomName As String

            ' Token: 0x040005C8 RID: 1480
            Public EnvAudio As Integer

            ' Token: 0x040005C9 RID: 1481
            Public ForceRating As Integer

            ' Token: 0x040005CA RID: 1482
            Public AmbientScale As Single

            ' Token: 0x040005CB RID: 1483
            Public DisableWeather As Boolean
        End Class
    End Class
End Namespace
