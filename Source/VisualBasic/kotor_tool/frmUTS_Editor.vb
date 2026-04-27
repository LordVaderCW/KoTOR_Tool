Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports FMOD
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000082 RID: 130
	Public Partial Class frmUTS_Editor
		Inherits frmParent

		' Token: 0x14000001 RID: 1
		' (add) Token: 0x06001541 RID: 5441 RVA: 0x002BF084 File Offset: 0x002BE084
		' (remove) Token: 0x06001540 RID: 5440 RVA: 0x002BF0A0 File Offset: 0x002BE0A0
		Public Event StoppedPlaying As frmUTS_Editor.StoppedPlayingEventHandler

		' Token: 0x06001542 RID: 5442 RVA: 0x002BF0BC File Offset: 0x002BE0BC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTS_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTS_Editor_Closing
			Me.m_bSaveGameMode = False
			Me.fmSystem = Nothing
			Me.sound1 = Nothing
			Me.channel = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x170007FA RID: 2042
		' (get) Token: 0x06001544 RID: 5444 RVA: 0x002BF154 File Offset: 0x002BE154
		' (set) Token: 0x06001545 RID: 5445 RVA: 0x002BF138 File Offset: 0x002BE138
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

		' Token: 0x170007FB RID: 2043
		' (get) Token: 0x06001546 RID: 5446 RVA: 0x002BF168 File Offset: 0x002BE168
		' (set) Token: 0x06001547 RID: 5447 RVA: 0x002BF17C File Offset: 0x002BE17C
		Friend Overridable Property btnSetNameLang As Button
			Get
				Return Me._btnSetNameLang
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnSetNameLang IsNot Nothing Then
                    RemoveHandler Me._btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
                End If
                Me._btnSetNameLang = value
                If Me._btnSetNameLang IsNot Nothing Then
                    AddHandler Me._btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
                End If
            End Set
        End Property

		' Token: 0x170007FC RID: 2044
		' (get) Token: 0x06001548 RID: 5448 RVA: 0x002BF1EC File Offset: 0x002BE1EC
		' (set) Token: 0x06001549 RID: 5449 RVA: 0x002BF1D0 File Offset: 0x002BE1D0
		Friend Overridable Property tbTag As TextBox
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

		' Token: 0x170007FD RID: 2045
		' (get) Token: 0x0600154A RID: 5450 RVA: 0x002BF21C File Offset: 0x002BE21C
		' (set) Token: 0x0600154B RID: 5451 RVA: 0x002BF200 File Offset: 0x002BE200
		Friend Overridable Property tbName As TextBox
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

		' Token: 0x170007FE RID: 2046
		' (get) Token: 0x0600154D RID: 5453 RVA: 0x002BF24C File Offset: 0x002BE24C
		' (set) Token: 0x0600154C RID: 5452 RVA: 0x002BF230 File Offset: 0x002BE230
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

		' Token: 0x170007FF RID: 2047
		' (get) Token: 0x0600154F RID: 5455 RVA: 0x002BF260 File Offset: 0x002BE260
		' (set) Token: 0x0600154E RID: 5454 RVA: 0x002BF274 File Offset: 0x002BE274
		Friend Overridable Property Label2 As Label
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

		' Token: 0x17000800 RID: 2048
		' (get) Token: 0x06001550 RID: 5456 RVA: 0x002BF290 File Offset: 0x002BE290
		' (set) Token: 0x06001551 RID: 5457 RVA: 0x002BF2A4 File Offset: 0x002BE2A4
		Friend Overridable Property tbComment As TextBox
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

		' Token: 0x17000801 RID: 2049
		' (get) Token: 0x06001553 RID: 5459 RVA: 0x002BF2DC File Offset: 0x002BE2DC
		' (set) Token: 0x06001552 RID: 5458 RVA: 0x002BF2C0 File Offset: 0x002BE2C0
		Friend Overridable Property Label3 As Label
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

		' Token: 0x17000802 RID: 2050
		' (get) Token: 0x06001555 RID: 5461 RVA: 0x002BF344 File Offset: 0x002BE344
		' (set) Token: 0x06001554 RID: 5460 RVA: 0x002BF2F0 File Offset: 0x002BE2F0
		Friend Overridable Property btnMoveUp As Button
			Get
				Return Me._btnMoveUp
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnMoveUp IsNot Nothing Then
                    RemoveHandler Me._btnMoveUp.Click, AddressOf Me.btnMoveUp_Click
                End If
                Me._btnMoveUp = value
                If Me._btnMoveUp IsNot Nothing Then
                    AddHandler Me._btnMoveUp.Click, AddressOf Me.btnMoveUp_Click
                End If
            End Set
        End Property

		' Token: 0x17000803 RID: 2051
		' (get) Token: 0x06001557 RID: 5463 RVA: 0x002BF3AC File Offset: 0x002BE3AC
		' (set) Token: 0x06001556 RID: 5462 RVA: 0x002BF358 File Offset: 0x002BE358
		Friend Overridable Property btnMoveDown As Button
			Get
				Return Me._btnMoveDown
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnMoveDown IsNot Nothing Then
                    RemoveHandler Me._btnMoveDown.Click, AddressOf Me.btnMoveDown_Click
                End If
                Me._btnMoveDown = value
                If Me._btnMoveDown IsNot Nothing Then
                    AddHandler Me._btnMoveDown.Click, AddressOf Me.btnMoveDown_Click
                End If
            End Set
        End Property

		' Token: 0x17000804 RID: 2052
		' (get) Token: 0x06001558 RID: 5464 RVA: 0x002BF3C0 File Offset: 0x002BE3C0
		' (set) Token: 0x06001559 RID: 5465 RVA: 0x002BF3D4 File Offset: 0x002BE3D4
		Friend Overridable Property Label4 As Label
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

		' Token: 0x17000805 RID: 2053
		' (get) Token: 0x0600155A RID: 5466 RVA: 0x002BF3F0 File Offset: 0x002BE3F0
		' (set) Token: 0x0600155B RID: 5467 RVA: 0x002BF404 File Offset: 0x002BE404
		Friend Overridable Property Label5 As Label
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

		' Token: 0x17000806 RID: 2054
		' (get) Token: 0x0600155D RID: 5469 RVA: 0x002BF420 File Offset: 0x002BE420
		' (set) Token: 0x0600155C RID: 5468 RVA: 0x002BF434 File Offset: 0x002BE434
		Friend Overridable Property lbSounds As ListBox
			Get
				Return Me._lbSounds
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ListBox)
                If Me._lbSounds IsNot Nothing Then
                    RemoveHandler Me._lbSounds.SelectedIndexChanged, AddressOf Me.lbSounds_SelectedIndexChanged
                    RemoveHandler Me._lbSounds.DoubleClick, AddressOf Me.lbSounds_DoubleClick
                End If
                Me._lbSounds = value
                If Me._lbSounds IsNot Nothing Then
                    AddHandler Me._lbSounds.SelectedIndexChanged, AddressOf Me.lbSounds_SelectedIndexChanged
                    AddHandler Me._lbSounds.DoubleClick, AddressOf Me.lbSounds_DoubleClick
                End If
            End Set
        End Property

		' Token: 0x17000807 RID: 2055
		' (get) Token: 0x0600155E RID: 5470 RVA: 0x002BF4B8 File Offset: 0x002BE4B8
		' (set) Token: 0x0600155F RID: 5471 RVA: 0x002BF4CC File Offset: 0x002BE4CC
		Friend Overridable Property rbPlaysEverywhere As RadioButton
			Get
				Return Me._rbPlaysEverywhere
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbPlaysEverywhere IsNot Nothing Then
                    RemoveHandler Me._rbPlaysEverywhere.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
                End If
                Me._rbPlaysEverywhere = value
                If Me._rbPlaysEverywhere IsNot Nothing Then
                    AddHandler Me._rbPlaysEverywhere.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x17000808 RID: 2056
		' (get) Token: 0x06001560 RID: 5472 RVA: 0x002BF574 File Offset: 0x002BE574
		' (set) Token: 0x06001561 RID: 5473 RVA: 0x002BF520 File Offset: 0x002BE520
		Friend Overridable Property rbRandomPosition As RadioButton
			Get
				Return Me._rbRandomPosition
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbRandomPosition IsNot Nothing Then
                    RemoveHandler Me._rbRandomPosition.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
                End If
                Me._rbRandomPosition = value
                If Me._rbRandomPosition IsNot Nothing Then
                    AddHandler Me._rbRandomPosition.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x17000809 RID: 2057
		' (get) Token: 0x06001562 RID: 5474 RVA: 0x002BF5DC File Offset: 0x002BE5DC
		' (set) Token: 0x06001563 RID: 5475 RVA: 0x002BF588 File Offset: 0x002BE588
		Friend Overridable Property rbSpecificPosition As RadioButton
			Get
				Return Me._rbSpecificPosition
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbSpecificPosition IsNot Nothing Then
                    RemoveHandler Me._rbSpecificPosition.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
                End If
                Me._rbSpecificPosition = value
                If Me._rbSpecificPosition IsNot Nothing Then
                    AddHandler Me._rbSpecificPosition.CheckedChanged, AddressOf Me.rbPlaysWhere_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x1700080A RID: 2058
		' (get) Token: 0x06001564 RID: 5476 RVA: 0x002BF5F0 File Offset: 0x002BE5F0
		' (set) Token: 0x06001565 RID: 5477 RVA: 0x002BF604 File Offset: 0x002BE604
		Friend Overridable Property tabpagBasic As TabPage
			Get
				Return Me._tabpagBasic
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TabPage)
                If Me._tabpagBasic IsNot Nothing Then
                End If
                Me._tabpagBasic = value
                If Me._tabpagBasic IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700080B RID: 2059
		' (get) Token: 0x06001567 RID: 5479 RVA: 0x002BF620 File Offset: 0x002BE620
		' (set) Token: 0x06001566 RID: 5478 RVA: 0x002BF634 File Offset: 0x002BE634
		Friend Overridable Property tbapagPositioning As TabPage
			Get
				Return Me._tbapagPositioning
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TabPage)
                If Me._tbapagPositioning IsNot Nothing Then
                End If
                Me._tbapagPositioning = value
                If Me._tbapagPositioning IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700080C RID: 2060
		' (get) Token: 0x06001568 RID: 5480 RVA: 0x002BF66C File Offset: 0x002BE66C
		' (set) Token: 0x06001569 RID: 5481 RVA: 0x002BF650 File Offset: 0x002BE650
		Friend Overridable Property tabpagAdvanced As TabPage
			Get
				Return Me._tabpagAdvanced
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TabPage)
                If Me._tabpagAdvanced IsNot Nothing Then
                End If
                Me._tabpagAdvanced = value
                If Me._tabpagAdvanced IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700080D RID: 2061
		' (get) Token: 0x0600156A RID: 5482 RVA: 0x002BF69C File Offset: 0x002BE69C
		' (set) Token: 0x0600156B RID: 5483 RVA: 0x002BF680 File Offset: 0x002BE680
		Friend Overridable Property GroupBox4 As GroupBox
			Get
				Return Me._GroupBox4
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As GroupBox)
                If Me._GroupBox4 IsNot Nothing Then
                End If
                Me._GroupBox4 = value
                If Me._GroupBox4 IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700080E RID: 2062
		' (get) Token: 0x0600156C RID: 5484 RVA: 0x002BF6B0 File Offset: 0x002BE6B0
		' (set) Token: 0x0600156D RID: 5485 RVA: 0x002BF6C4 File Offset: 0x002BE6C4
		Friend Overridable Property GroupBox5 As GroupBox
			Get
				Return Me._GroupBox5
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As GroupBox)
                If Me._GroupBox5 IsNot Nothing Then
                End If
                Me._GroupBox5 = value
                If Me._GroupBox5 IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700080F RID: 2063
		' (get) Token: 0x0600156E RID: 5486 RVA: 0x002BF6E0 File Offset: 0x002BE6E0
		' (set) Token: 0x0600156F RID: 5487 RVA: 0x002BF6F4 File Offset: 0x002BE6F4
		Friend Overridable Property GroupBox6 As GroupBox
			Get
				Return Me._GroupBox6
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As GroupBox)
                If Me._GroupBox6 IsNot Nothing Then
                End If
                Me._GroupBox6 = value
                If Me._GroupBox6 IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000810 RID: 2064
		' (get) Token: 0x06001570 RID: 5488 RVA: 0x002BF710 File Offset: 0x002BE710
		' (set) Token: 0x06001571 RID: 5489 RVA: 0x002BF724 File Offset: 0x002BE724
		Friend Overridable Property chkbActive As CheckBox
			Get
				Return Me._chkbActive
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkbActive IsNot Nothing Then
                End If
                Me._chkbActive = value
                If Me._chkbActive IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000811 RID: 2065
		' (get) Token: 0x06001572 RID: 5490 RVA: 0x002BF740 File Offset: 0x002BE740
		' (set) Token: 0x06001573 RID: 5491 RVA: 0x002BF754 File Offset: 0x002BE754
		Friend Overridable Property Label6 As Label
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

		' Token: 0x17000812 RID: 2066
		' (get) Token: 0x06001575 RID: 5493 RVA: 0x002BF78C File Offset: 0x002BE78C
		' (set) Token: 0x06001574 RID: 5492 RVA: 0x002BF770 File Offset: 0x002BE770
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

		' Token: 0x17000813 RID: 2067
		' (get) Token: 0x06001576 RID: 5494 RVA: 0x002BF7BC File Offset: 0x002BE7BC
		' (set) Token: 0x06001577 RID: 5495 RVA: 0x002BF7A0 File Offset: 0x002BE7A0
		Friend Overridable Property gbHeight As GroupBox
			Get
				Return Me._gbHeight
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As GroupBox)
                If Me._gbHeight IsNot Nothing Then
                End If
                Me._gbHeight = value
                If Me._gbHeight IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000814 RID: 2068
		' (get) Token: 0x06001578 RID: 5496 RVA: 0x002BF7EC File Offset: 0x002BE7EC
		' (set) Token: 0x06001579 RID: 5497 RVA: 0x002BF7D0 File Offset: 0x002BE7D0
		Friend Overridable Property gbVolumeDistances As GroupBox
			Get
				Return Me._gbVolumeDistances
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As GroupBox)
                If Me._gbVolumeDistances IsNot Nothing Then
                End If
                Me._gbVolumeDistances = value
                If Me._gbVolumeDistances IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000815 RID: 2069
		' (get) Token: 0x0600157B RID: 5499 RVA: 0x002BF800 File Offset: 0x002BE800
		' (set) Token: 0x0600157A RID: 5498 RVA: 0x002BF814 File Offset: 0x002BE814
		Friend Overridable Property gbRandomRange As GroupBox
			Get
				Return Me._gbRandomRange
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As GroupBox)
                If Me._gbRandomRange IsNot Nothing Then
                End If
                Me._gbRandomRange = value
                If Me._gbRandomRange IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000816 RID: 2070
		' (get) Token: 0x0600157D RID: 5501 RVA: 0x002BF84C File Offset: 0x002BE84C
		' (set) Token: 0x0600157C RID: 5500 RVA: 0x002BF830 File Offset: 0x002BE830
		Friend Overridable Property Label8 As Label
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

		' Token: 0x17000817 RID: 2071
		' (get) Token: 0x0600157E RID: 5502 RVA: 0x002BF860 File Offset: 0x002BE860
		' (set) Token: 0x0600157F RID: 5503 RVA: 0x002BF874 File Offset: 0x002BE874
		Friend Overridable Property Label9 As Label
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

		' Token: 0x17000818 RID: 2072
		' (get) Token: 0x06001580 RID: 5504 RVA: 0x002BF8AC File Offset: 0x002BE8AC
		' (set) Token: 0x06001581 RID: 5505 RVA: 0x002BF890 File Offset: 0x002BE890
		Friend Overridable Property Label10 As Label
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

		' Token: 0x17000819 RID: 2073
		' (get) Token: 0x06001583 RID: 5507 RVA: 0x002BF8C0 File Offset: 0x002BE8C0
		' (set) Token: 0x06001582 RID: 5506 RVA: 0x002BF8D4 File Offset: 0x002BE8D4
		Friend Overridable Property Label11 As Label
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

		' Token: 0x1700081A RID: 2074
		' (get) Token: 0x06001585 RID: 5509 RVA: 0x002BF90C File Offset: 0x002BE90C
		' (set) Token: 0x06001584 RID: 5508 RVA: 0x002BF8F0 File Offset: 0x002BE8F0
		Friend Overridable Property Label12 As Label
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

		' Token: 0x1700081B RID: 2075
		' (get) Token: 0x06001587 RID: 5511 RVA: 0x002BF920 File Offset: 0x002BE920
		' (set) Token: 0x06001586 RID: 5510 RVA: 0x002BF934 File Offset: 0x002BE934
		Friend Overridable Property PictureBox1 As PictureBox
			Get
				Return Me._PictureBox1
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As PictureBox)
                If Me._PictureBox1 IsNot Nothing Then
                End If
                Me._PictureBox1 = value
                If Me._PictureBox1 IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700081C RID: 2076
		' (get) Token: 0x06001588 RID: 5512 RVA: 0x002BF950 File Offset: 0x002BE950
		' (set) Token: 0x06001589 RID: 5513 RVA: 0x002BF964 File Offset: 0x002BE964
		Friend Overridable Property PictureBox2 As PictureBox
			Get
				Return Me._PictureBox2
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As PictureBox)
                If Me._PictureBox2 IsNot Nothing Then
                End If
                Me._PictureBox2 = value
                If Me._PictureBox2 IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700081D RID: 2077
		' (get) Token: 0x0600158B RID: 5515 RVA: 0x002BF99C File Offset: 0x002BE99C
		' (set) Token: 0x0600158A RID: 5514 RVA: 0x002BF980 File Offset: 0x002BE980
		Friend Overridable Property PictureBox3 As PictureBox
			Get
				Return Me._PictureBox3
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As PictureBox)
                If Me._PictureBox3 IsNot Nothing Then
                End If
                Me._PictureBox3 = value
                If Me._PictureBox3 IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700081E RID: 2078
		' (get) Token: 0x0600158C RID: 5516 RVA: 0x002BFA04 File Offset: 0x002BEA04
		' (set) Token: 0x0600158D RID: 5517 RVA: 0x002BF9B0 File Offset: 0x002BE9B0
		Friend Overridable Property rbPlayDay As RadioButton
			Get
				Return Me._rbPlayDay
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbPlayDay IsNot Nothing Then
                    RemoveHandler Me._rbPlayDay.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
                End If
                Me._rbPlayDay = value
                If Me._rbPlayDay IsNot Nothing Then
                    AddHandler Me._rbPlayDay.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x1700081F RID: 2079
		' (get) Token: 0x0600158F RID: 5519 RVA: 0x002BFA18 File Offset: 0x002BEA18
		' (set) Token: 0x0600158E RID: 5518 RVA: 0x002BFA2C File Offset: 0x002BEA2C
		Friend Overridable Property rbPlayNight As RadioButton
			Get
				Return Me._rbPlayNight
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbPlayNight IsNot Nothing Then
                    RemoveHandler Me._rbPlayNight.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
                End If
                Me._rbPlayNight = value
                If Me._rbPlayNight IsNot Nothing Then
                    AddHandler Me._rbPlayNight.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x17000820 RID: 2080
		' (get) Token: 0x06001591 RID: 5521 RVA: 0x002BFAD4 File Offset: 0x002BEAD4
		' (set) Token: 0x06001590 RID: 5520 RVA: 0x002BFA80 File Offset: 0x002BEA80
		Friend Overridable Property rbPlayAllTimes As RadioButton
			Get
				Return Me._rbPlayAllTimes
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbPlayAllTimes IsNot Nothing Then
                    RemoveHandler Me._rbPlayAllTimes.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
                End If
                Me._rbPlayAllTimes = value
                If Me._rbPlayAllTimes IsNot Nothing Then
                    AddHandler Me._rbPlayAllTimes.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x17000821 RID: 2081
		' (get) Token: 0x06001592 RID: 5522 RVA: 0x002BFAE8 File Offset: 0x002BEAE8
		' (set) Token: 0x06001593 RID: 5523 RVA: 0x002BFAFC File Offset: 0x002BEAFC
		Friend Overridable Property rbPlaySpecificHours As RadioButton
			Get
				Return Me._rbPlaySpecificHours
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbPlaySpecificHours IsNot Nothing Then
                    RemoveHandler Me._rbPlaySpecificHours.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
                End If
                Me._rbPlaySpecificHours = value
                If Me._rbPlaySpecificHours IsNot Nothing Then
                    AddHandler Me._rbPlaySpecificHours.CheckedChanged, AddressOf Me.rbPlayDay_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x17000822 RID: 2082
		' (get) Token: 0x06001595 RID: 5525 RVA: 0x002BFBA4 File Offset: 0x002BEBA4
		' (set) Token: 0x06001594 RID: 5524 RVA: 0x002BFB50 File Offset: 0x002BEB50
		Friend Overridable Property trkbarVolumeVrtn As TrackBar
			Get
				Return Me._trkbarVolumeVrtn
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TrackBar)
                If Me._trkbarVolumeVrtn IsNot Nothing Then
                    RemoveHandler Me._trkbarVolumeVrtn.ValueChanged, AddressOf Me.trkbarVolumeVrtn_ValueChanged
                End If
                Me._trkbarVolumeVrtn = value
                If Me._trkbarVolumeVrtn IsNot Nothing Then
                    AddHandler Me._trkbarVolumeVrtn.ValueChanged, AddressOf Me.trkbarVolumeVrtn_ValueChanged
                End If
            End Set
        End Property

		' Token: 0x17000823 RID: 2083
		' (get) Token: 0x06001597 RID: 5527 RVA: 0x002BFBB8 File Offset: 0x002BEBB8
		' (set) Token: 0x06001596 RID: 5526 RVA: 0x002BFBCC File Offset: 0x002BEBCC
		Friend Overridable Property rbOnce As RadioButton
			Get
				Return Me._rbOnce
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbOnce IsNot Nothing Then
                    RemoveHandler Me._rbOnce.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
                End If
                Me._rbOnce = value
                If Me._rbOnce IsNot Nothing Then
                    AddHandler Me._rbOnce.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x17000824 RID: 2084
		' (get) Token: 0x06001598 RID: 5528 RVA: 0x002BFC20 File Offset: 0x002BEC20
		' (set) Token: 0x06001599 RID: 5529 RVA: 0x002BFC34 File Offset: 0x002BEC34
		Friend Overridable Property rbRepeating As RadioButton
			Get
				Return Me._rbRepeating
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbRepeating IsNot Nothing Then
                    RemoveHandler Me._rbRepeating.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
                End If
                Me._rbRepeating = value
                If Me._rbRepeating IsNot Nothing Then
                    AddHandler Me._rbRepeating.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x17000825 RID: 2085
		' (get) Token: 0x0600159A RID: 5530 RVA: 0x002BFCA4 File Offset: 0x002BECA4
		' (set) Token: 0x0600159B RID: 5531 RVA: 0x002BFC88 File Offset: 0x002BEC88
		Friend Overridable Property rbSequential As RadioButton
			Get
				Return Me._rbSequential
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbSequential IsNot Nothing Then
                End If
                Me._rbSequential = value
                If Me._rbSequential IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000826 RID: 2086
		' (get) Token: 0x0600159C RID: 5532 RVA: 0x002BFCB8 File Offset: 0x002BECB8
		' (set) Token: 0x0600159D RID: 5533 RVA: 0x002BFCCC File Offset: 0x002BECCC
		Friend Overridable Property rbRandom As RadioButton
			Get
				Return Me._rbRandom
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbRandom IsNot Nothing Then
                End If
                Me._rbRandom = value
                If Me._rbRandom IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000827 RID: 2087
		' (get) Token: 0x0600159F RID: 5535 RVA: 0x002BFD04 File Offset: 0x002BED04
		' (set) Token: 0x0600159E RID: 5534 RVA: 0x002BFCE8 File Offset: 0x002BECE8
		Friend Overridable Property gbInterval As GroupBox
			Get
				Return Me._gbInterval
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As GroupBox)
                If Me._gbInterval IsNot Nothing Then
                End If
                Me._gbInterval = value
                If Me._gbInterval IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000828 RID: 2088
		' (get) Token: 0x060015A0 RID: 5536 RVA: 0x002BFD18 File Offset: 0x002BED18
		' (set) Token: 0x060015A1 RID: 5537 RVA: 0x002BFD2C File Offset: 0x002BED2C
		Friend Overridable Property nudInterval As NumericUpDown
			Get
				Return Me._nudInterval
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As NumericUpDown)
                If Me._nudInterval IsNot Nothing Then
                End If
                Me._nudInterval = value
                If Me._nudInterval IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000829 RID: 2089
		' (get) Token: 0x060015A2 RID: 5538 RVA: 0x002BFD64 File Offset: 0x002BED64
		' (set) Token: 0x060015A3 RID: 5539 RVA: 0x002BFD48 File Offset: 0x002BED48
		Friend Overridable Property nudIntervalVrtn As NumericUpDown
			Get
				Return Me._nudIntervalVrtn
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As NumericUpDown)
                If Me._nudIntervalVrtn IsNot Nothing Then
                End If
                Me._nudIntervalVrtn = value
                If Me._nudIntervalVrtn IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700082A RID: 2090
		' (get) Token: 0x060015A5 RID: 5541 RVA: 0x002BFDCC File Offset: 0x002BEDCC
		' (set) Token: 0x060015A4 RID: 5540 RVA: 0x002BFD78 File Offset: 0x002BED78
		Friend Overridable Property trkbarPitchVrtn As TrackBar
			Get
				Return Me._trkbarPitchVrtn
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TrackBar)
                If Me._trkbarPitchVrtn IsNot Nothing Then
                    RemoveHandler Me._trkbarPitchVrtn.ValueChanged, AddressOf Me.trkbarPitchVrtn_ValueChanged
                End If
                Me._trkbarPitchVrtn = value
                If Me._trkbarPitchVrtn IsNot Nothing Then
                    AddHandler Me._trkbarPitchVrtn.ValueChanged, AddressOf Me.trkbarPitchVrtn_ValueChanged
                End If
            End Set
        End Property

		' Token: 0x1700082B RID: 2091
		' (get) Token: 0x060015A7 RID: 5543 RVA: 0x002BFDE0 File Offset: 0x002BEDE0
		' (set) Token: 0x060015A6 RID: 5542 RVA: 0x002BFDF4 File Offset: 0x002BEDF4
		Friend Overridable Property lbl12 As Label
			Get
				Return Me._lbl12
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._lbl12 IsNot Nothing Then
                End If
                Me._lbl12 = value
                If Me._lbl12 IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700082C RID: 2092
		' (get) Token: 0x060015A9 RID: 5545 RVA: 0x002BFE10 File Offset: 0x002BEE10
		' (set) Token: 0x060015A8 RID: 5544 RVA: 0x002BFE24 File Offset: 0x002BEE24
		Friend Overridable Property lblPM As Label
			Get
				Return Me._lblPM
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._lblPM IsNot Nothing Then
                End If
                Me._lblPM = value
                If Me._lblPM IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700082D RID: 2093
		' (get) Token: 0x060015AA RID: 5546 RVA: 0x002BFE40 File Offset: 0x002BEE40
		' (set) Token: 0x060015AB RID: 5547 RVA: 0x002BFE54 File Offset: 0x002BEE54
		Friend Overridable Property Label15 As Label
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

		' Token: 0x1700082E RID: 2094
		' (get) Token: 0x060015AC RID: 5548 RVA: 0x002BFE70 File Offset: 0x002BEE70
		' (set) Token: 0x060015AD RID: 5549 RVA: 0x002BFE84 File Offset: 0x002BEE84
		Friend Overridable Property Label16 As Label
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

		' Token: 0x1700082F RID: 2095
		' (get) Token: 0x060015AE RID: 5550 RVA: 0x002BFEBC File Offset: 0x002BEEBC
		' (set) Token: 0x060015AF RID: 5551 RVA: 0x002BFEA0 File Offset: 0x002BEEA0
		Friend Overridable Property Label13 As Label
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

		' Token: 0x17000830 RID: 2096
		' (get) Token: 0x060015B1 RID: 5553 RVA: 0x002BFED0 File Offset: 0x002BEED0
		' (set) Token: 0x060015B0 RID: 5552 RVA: 0x002BFEE4 File Offset: 0x002BEEE4
		Friend Overridable Property Label14 As Label
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

		' Token: 0x17000831 RID: 2097
		' (get) Token: 0x060015B2 RID: 5554 RVA: 0x002BFF00 File Offset: 0x002BEF00
		' (set) Token: 0x060015B3 RID: 5555 RVA: 0x002BFF14 File Offset: 0x002BEF14
		Friend Overridable Property Label17 As Label
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

		' Token: 0x17000832 RID: 2098
		' (get) Token: 0x060015B4 RID: 5556 RVA: 0x002BFF4C File Offset: 0x002BEF4C
		' (set) Token: 0x060015B5 RID: 5557 RVA: 0x002BFF30 File Offset: 0x002BEF30
		Friend Overridable Property Label18 As Label
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

		' Token: 0x17000833 RID: 2099
		' (get) Token: 0x060015B6 RID: 5558 RVA: 0x002BFF7C File Offset: 0x002BEF7C
		' (set) Token: 0x060015B7 RID: 5559 RVA: 0x002BFF60 File Offset: 0x002BEF60
		Friend Overridable Property Label19 As Label
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

		' Token: 0x17000834 RID: 2100
		' (get) Token: 0x060015B9 RID: 5561 RVA: 0x002BFFAC File Offset: 0x002BEFAC
		' (set) Token: 0x060015B8 RID: 5560 RVA: 0x002BFF90 File Offset: 0x002BEF90
		Friend Overridable Property Label20 As Label
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

		' Token: 0x17000835 RID: 2101
		' (get) Token: 0x060015BA RID: 5562 RVA: 0x002BFFC0 File Offset: 0x002BEFC0
		' (set) Token: 0x060015BB RID: 5563 RVA: 0x002BFFD4 File Offset: 0x002BEFD4
		Friend Overridable Property Label21 As Label
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

		' Token: 0x17000836 RID: 2102
		' (get) Token: 0x060015BC RID: 5564 RVA: 0x002BFFF0 File Offset: 0x002BEFF0
		' (set) Token: 0x060015BD RID: 5565 RVA: 0x002C0004 File Offset: 0x002BF004
		Friend Overridable Property Label22 As Label
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

		' Token: 0x17000837 RID: 2103
		' (get) Token: 0x060015BE RID: 5566 RVA: 0x002C003C File Offset: 0x002BF03C
		' (set) Token: 0x060015BF RID: 5567 RVA: 0x002C0020 File Offset: 0x002BF020
		Friend Overridable Property Label23 As Label
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

		' Token: 0x17000838 RID: 2104
		' (get) Token: 0x060015C0 RID: 5568 RVA: 0x002C0050 File Offset: 0x002BF050
		' (set) Token: 0x060015C1 RID: 5569 RVA: 0x002C0064 File Offset: 0x002BF064
		Friend Overridable Property Label24 As Label
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

		' Token: 0x17000839 RID: 2105
		' (get) Token: 0x060015C2 RID: 5570 RVA: 0x002C0080 File Offset: 0x002BF080
		' (set) Token: 0x060015C3 RID: 5571 RVA: 0x002C0094 File Offset: 0x002BF094
		Friend Overridable Property Label25 As Label
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

		' Token: 0x1700083A RID: 2106
		' (get) Token: 0x060015C4 RID: 5572 RVA: 0x002C00CC File Offset: 0x002BF0CC
		' (set) Token: 0x060015C5 RID: 5573 RVA: 0x002C00B0 File Offset: 0x002BF0B0
		Friend Overridable Property lblAM As Label
			Get
				Return Me._lblAM
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._lblAM IsNot Nothing Then
                End If
                Me._lblAM = value
                If Me._lblAM IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700083B RID: 2107
		' (get) Token: 0x060015C6 RID: 5574 RVA: 0x002C00E0 File Offset: 0x002BF0E0
		' (set) Token: 0x060015C7 RID: 5575 RVA: 0x002C00F4 File Offset: 0x002BF0F4
		Friend Overridable Property tbPitchVrtn As TextBox
			Get
				Return Me._tbPitchVrtn
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbPitchVrtn IsNot Nothing Then
                End If
                Me._tbPitchVrtn = value
                If Me._tbPitchVrtn IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700083C RID: 2108
		' (get) Token: 0x060015C8 RID: 5576 RVA: 0x002C012C File Offset: 0x002BF12C
		' (set) Token: 0x060015C9 RID: 5577 RVA: 0x002C0110 File Offset: 0x002BF110
		Friend Overridable Property nudElevation As NumericUpDown
			Get
				Return Me._nudElevation
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As NumericUpDown)
                If Me._nudElevation IsNot Nothing Then
                End If
                Me._nudElevation = value
                If Me._nudElevation IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700083D RID: 2109
		' (get) Token: 0x060015CA RID: 5578 RVA: 0x002C015C File Offset: 0x002BF15C
		' (set) Token: 0x060015CB RID: 5579 RVA: 0x002C0140 File Offset: 0x002BF140
		Friend Overridable Property nudRandomRangeY As NumericUpDown
			Get
				Return Me._nudRandomRangeY
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As NumericUpDown)
                If Me._nudRandomRangeY IsNot Nothing Then
                End If
                Me._nudRandomRangeY = value
                If Me._nudRandomRangeY IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700083E RID: 2110
		' (get) Token: 0x060015CC RID: 5580 RVA: 0x002C0170 File Offset: 0x002BF170
		' (set) Token: 0x060015CD RID: 5581 RVA: 0x002C0184 File Offset: 0x002BF184
		Friend Overridable Property nudRandomRangeX As NumericUpDown
			Get
				Return Me._nudRandomRangeX
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As NumericUpDown)
                If Me._nudRandomRangeX IsNot Nothing Then
                End If
                Me._nudRandomRangeX = value
                If Me._nudRandomRangeX IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700083F RID: 2111
		' (get) Token: 0x060015CF RID: 5583 RVA: 0x002C01BC File Offset: 0x002BF1BC
		' (set) Token: 0x060015CE RID: 5582 RVA: 0x002C01A0 File Offset: 0x002BF1A0
		Friend Overridable Property pnlHours As Panel
			Get
				Return Me._pnlHours
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Panel)
                If Me._pnlHours IsNot Nothing Then
                End If
                Me._pnlHours = value
                If Me._pnlHours IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000840 RID: 2112
		' (get) Token: 0x060015D1 RID: 5585 RVA: 0x002C01D0 File Offset: 0x002BF1D0
		' (set) Token: 0x060015D0 RID: 5584 RVA: 0x002C01E4 File Offset: 0x002BF1E4
		Friend Overridable Property rbLooping As RadioButton
			Get
				Return Me._rbLooping
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As RadioButton)
                If Me._rbLooping IsNot Nothing Then
                    RemoveHandler Me._rbLooping.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
                End If
                Me._rbLooping = value
                If Me._rbLooping IsNot Nothing Then
                    AddHandler Me._rbLooping.CheckedChanged, AddressOf Me.rbLooping_CheckedChanged
                End If
            End Set
        End Property

		' Token: 0x17000841 RID: 2113
		' (get) Token: 0x060015D2 RID: 5586 RVA: 0x002C0238 File Offset: 0x002BF238
		' (set) Token: 0x060015D3 RID: 5587 RVA: 0x002C024C File Offset: 0x002BF24C
		Friend Overridable Property pnlVolPitch As Panel
			Get
				Return Me._pnlVolPitch
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Panel)
                If Me._pnlVolPitch IsNot Nothing Then
                End If
                Me._pnlVolPitch = value
                If Me._pnlVolPitch IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000842 RID: 2114
		' (get) Token: 0x060015D4 RID: 5588 RVA: 0x002C0268 File Offset: 0x002BF268
		' (set) Token: 0x060015D5 RID: 5589 RVA: 0x002C027C File Offset: 0x002BF27C
		Friend Overridable Property btnAddSound As Button
			Get
				Return Me._btnAddSound
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnAddSound IsNot Nothing Then
                    RemoveHandler Me._btnAddSound.Click, AddressOf Me.btnAddSound_Click
                End If
                Me._btnAddSound = value
                If Me._btnAddSound IsNot Nothing Then
                    AddHandler Me._btnAddSound.Click, AddressOf Me.btnAddSound_Click
                End If
            End Set
        End Property

		' Token: 0x17000843 RID: 2115
		' (get) Token: 0x060015D6 RID: 5590 RVA: 0x002C02D0 File Offset: 0x002BF2D0
		' (set) Token: 0x060015D7 RID: 5591 RVA: 0x002C02E4 File Offset: 0x002BF2E4
		Friend Overridable Property btnRemoveSound As Button
			Get
				Return Me._btnRemoveSound
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnRemoveSound IsNot Nothing Then
                    RemoveHandler Me._btnRemoveSound.Click, AddressOf Me.btnRemoveSound_Click
                End If
                Me._btnRemoveSound = value
                If Me._btnRemoveSound IsNot Nothing Then
                    AddHandler Me._btnRemoveSound.Click, AddressOf Me.btnRemoveSound_Click
                End If
            End Set
        End Property

		' Token: 0x17000844 RID: 2116
		' (get) Token: 0x060015D8 RID: 5592 RVA: 0x002C038C File Offset: 0x002BF38C
		' (set) Token: 0x060015D9 RID: 5593 RVA: 0x002C0338 File Offset: 0x002BF338
		Friend Overridable Property btnSave As Button
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

		' Token: 0x17000845 RID: 2117
		' (get) Token: 0x060015DB RID: 5595 RVA: 0x002C03A0 File Offset: 0x002BF3A0
		' (set) Token: 0x060015DA RID: 5594 RVA: 0x002C03B4 File Offset: 0x002BF3B4
		Friend Overridable Property btnCancel As Button
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

		' Token: 0x17000846 RID: 2118
		' (get) Token: 0x060015DD RID: 5597 RVA: 0x002C0408 File Offset: 0x002BF408
		' (set) Token: 0x060015DC RID: 5596 RVA: 0x002C041C File Offset: 0x002BF41C
		Friend Overridable Property btnDebug As Button
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

		' Token: 0x17000847 RID: 2119
		' (get) Token: 0x060015DF RID: 5599 RVA: 0x002C0470 File Offset: 0x002BF470
		' (set) Token: 0x060015DE RID: 5598 RVA: 0x002C0484 File Offset: 0x002BF484
		Friend Overridable Property trkbarVolume As TrackBar
			Get
				Return Me._trkbarVolume
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TrackBar)
                If Me._trkbarVolume IsNot Nothing Then
                    RemoveHandler Me._trkbarVolume.ValueChanged, AddressOf Me.trkbarVolume_ValueChanged
                End If
                Me._trkbarVolume = value
                If Me._trkbarVolume IsNot Nothing Then
                    AddHandler Me._trkbarVolume.ValueChanged, AddressOf Me.trkbarVolume_ValueChanged
                End If
            End Set
        End Property

		' Token: 0x17000848 RID: 2120
		' (get) Token: 0x060015E0 RID: 5600 RVA: 0x002C04F4 File Offset: 0x002BF4F4
		' (set) Token: 0x060015E1 RID: 5601 RVA: 0x002C04D8 File Offset: 0x002BF4D8
		Friend Overridable Property nudMaxDistance As NumericUpDown
			Get
				Return Me._nudMaxDistance
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As NumericUpDown)
                If Me._nudMaxDistance IsNot Nothing Then
                End If
                Me._nudMaxDistance = value
                If Me._nudMaxDistance IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000849 RID: 2121
		' (get) Token: 0x060015E3 RID: 5603 RVA: 0x002C0508 File Offset: 0x002BF508
		' (set) Token: 0x060015E2 RID: 5602 RVA: 0x002C051C File Offset: 0x002BF51C
		Friend Overridable Property tbVolumeVrtn As TextBox
			Get
				Return Me._tbVolumeVrtn
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbVolumeVrtn IsNot Nothing Then
                End If
                Me._tbVolumeVrtn = value
                If Me._tbVolumeVrtn IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700084A RID: 2122
		' (get) Token: 0x060015E5 RID: 5605 RVA: 0x002C0554 File Offset: 0x002BF554
		' (set) Token: 0x060015E4 RID: 5604 RVA: 0x002C0538 File Offset: 0x002BF538
		Friend Overridable Property nudMinDistance As NumericUpDown
			Get
				Return Me._nudMinDistance
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As NumericUpDown)
                If Me._nudMinDistance IsNot Nothing Then
                End If
                Me._nudMinDistance = value
                If Me._nudMinDistance IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700084B RID: 2123
		' (get) Token: 0x060015E6 RID: 5606 RVA: 0x002C0568 File Offset: 0x002BF568
		' (set) Token: 0x060015E7 RID: 5607 RVA: 0x002C057C File Offset: 0x002BF57C
		Friend Overridable Property tbVolume As TextBox
			Get
				Return Me._tbVolume
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbVolume IsNot Nothing Then
                End If
                Me._tbVolume = value
                If Me._tbVolume IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700084C RID: 2124
		' (get) Token: 0x060015E8 RID: 5608 RVA: 0x002C05B4 File Offset: 0x002BF5B4
		' (set) Token: 0x060015E9 RID: 5609 RVA: 0x002C0598 File Offset: 0x002BF598
		Friend Overridable Property chkb3a As CheckBox
			Get
				Return Me._chkb3a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb3a IsNot Nothing Then
                End If
                Me._chkb3a = value
                If Me._chkb3a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700084D RID: 2125
		' (get) Token: 0x060015EA RID: 5610 RVA: 0x002C05C8 File Offset: 0x002BF5C8
		' (set) Token: 0x060015EB RID: 5611 RVA: 0x002C05DC File Offset: 0x002BF5DC
		Friend Overridable Property chkb3p As CheckBox
			Get
				Return Me._chkb3p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb3p IsNot Nothing Then
                End If
                Me._chkb3p = value
                If Me._chkb3p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700084E RID: 2126
		' (get) Token: 0x060015EC RID: 5612 RVA: 0x002C0614 File Offset: 0x002BF614
		' (set) Token: 0x060015ED RID: 5613 RVA: 0x002C05F8 File Offset: 0x002BF5F8
		Friend Overridable Property chkb10p As CheckBox
			Get
				Return Me._chkb10p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb10p IsNot Nothing Then
                End If
                Me._chkb10p = value
                If Me._chkb10p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700084F RID: 2127
		' (get) Token: 0x060015EF RID: 5615 RVA: 0x002C0644 File Offset: 0x002BF644
		' (set) Token: 0x060015EE RID: 5614 RVA: 0x002C0628 File Offset: 0x002BF628
		Friend Overridable Property chkb4a As CheckBox
			Get
				Return Me._chkb4a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb4a IsNot Nothing Then
                End If
                Me._chkb4a = value
                If Me._chkb4a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000850 RID: 2128
		' (get) Token: 0x060015F0 RID: 5616 RVA: 0x002C0658 File Offset: 0x002BF658
		' (set) Token: 0x060015F1 RID: 5617 RVA: 0x002C066C File Offset: 0x002BF66C
		Friend Overridable Property chkb6a As CheckBox
			Get
				Return Me._chkb6a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb6a IsNot Nothing Then
                End If
                Me._chkb6a = value
                If Me._chkb6a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000851 RID: 2129
		' (get) Token: 0x060015F3 RID: 5619 RVA: 0x002C0688 File Offset: 0x002BF688
		' (set) Token: 0x060015F2 RID: 5618 RVA: 0x002C069C File Offset: 0x002BF69C
		Friend Overridable Property chkb5a As CheckBox
			Get
				Return Me._chkb5a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb5a IsNot Nothing Then
                End If
                Me._chkb5a = value
                If Me._chkb5a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000852 RID: 2130
		' (get) Token: 0x060015F5 RID: 5621 RVA: 0x002C06D4 File Offset: 0x002BF6D4
		' (set) Token: 0x060015F4 RID: 5620 RVA: 0x002C06B8 File Offset: 0x002BF6B8
		Friend Overridable Property chkb7a As CheckBox
			Get
				Return Me._chkb7a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb7a IsNot Nothing Then
                End If
                Me._chkb7a = value
                If Me._chkb7a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000853 RID: 2131
		' (get) Token: 0x060015F6 RID: 5622 RVA: 0x002C0704 File Offset: 0x002BF704
		' (set) Token: 0x060015F7 RID: 5623 RVA: 0x002C06E8 File Offset: 0x002BF6E8
		Friend Overridable Property chkb8p As CheckBox
			Get
				Return Me._chkb8p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb8p IsNot Nothing Then
                End If
                Me._chkb8p = value
                If Me._chkb8p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000854 RID: 2132
		' (get) Token: 0x060015F8 RID: 5624 RVA: 0x002C0718 File Offset: 0x002BF718
		' (set) Token: 0x060015F9 RID: 5625 RVA: 0x002C072C File Offset: 0x002BF72C
		Friend Overridable Property chkb2p As CheckBox
			Get
				Return Me._chkb2p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb2p IsNot Nothing Then
                End If
                Me._chkb2p = value
                If Me._chkb2p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000855 RID: 2133
		' (get) Token: 0x060015FB RID: 5627 RVA: 0x002C0748 File Offset: 0x002BF748
		' (set) Token: 0x060015FA RID: 5626 RVA: 0x002C075C File Offset: 0x002BF75C
		Friend Overridable Property chkb9p As CheckBox
			Get
				Return Me._chkb9p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb9p IsNot Nothing Then
                End If
                Me._chkb9p = value
                If Me._chkb9p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000856 RID: 2134
		' (get) Token: 0x060015FC RID: 5628 RVA: 0x002C0794 File Offset: 0x002BF794
		' (set) Token: 0x060015FD RID: 5629 RVA: 0x002C0778 File Offset: 0x002BF778
		Friend Overridable Property chkb11p As CheckBox
			Get
				Return Me._chkb11p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb11p IsNot Nothing Then
                End If
                Me._chkb11p = value
                If Me._chkb11p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000857 RID: 2135
		' (get) Token: 0x060015FE RID: 5630 RVA: 0x002C07A8 File Offset: 0x002BF7A8
		' (set) Token: 0x060015FF RID: 5631 RVA: 0x002C07BC File Offset: 0x002BF7BC
		Friend Overridable Property chkb11a As CheckBox
			Get
				Return Me._chkb11a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb11a IsNot Nothing Then
                End If
                Me._chkb11a = value
                If Me._chkb11a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000858 RID: 2136
		' (get) Token: 0x06001601 RID: 5633 RVA: 0x002C07D8 File Offset: 0x002BF7D8
		' (set) Token: 0x06001600 RID: 5632 RVA: 0x002C07EC File Offset: 0x002BF7EC
		Friend Overridable Property chkb9a As CheckBox
			Get
				Return Me._chkb9a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb9a IsNot Nothing Then
                End If
                Me._chkb9a = value
                If Me._chkb9a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000859 RID: 2137
		' (get) Token: 0x06001602 RID: 5634 RVA: 0x002C0808 File Offset: 0x002BF808
		' (set) Token: 0x06001603 RID: 5635 RVA: 0x002C081C File Offset: 0x002BF81C
		Friend Overridable Property chkb10a As CheckBox
			Get
				Return Me._chkb10a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb10a IsNot Nothing Then
                End If
                Me._chkb10a = value
                If Me._chkb10a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700085A RID: 2138
		' (get) Token: 0x06001604 RID: 5636 RVA: 0x002C0838 File Offset: 0x002BF838
		' (set) Token: 0x06001605 RID: 5637 RVA: 0x002C084C File Offset: 0x002BF84C
		Friend Overridable Property chkb8a As CheckBox
			Get
				Return Me._chkb8a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb8a IsNot Nothing Then
                End If
                Me._chkb8a = value
                If Me._chkb8a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700085B RID: 2139
		' (get) Token: 0x06001606 RID: 5638 RVA: 0x002C0884 File Offset: 0x002BF884
		' (set) Token: 0x06001607 RID: 5639 RVA: 0x002C0868 File Offset: 0x002BF868
		Friend Overridable Property chkb7p As CheckBox
			Get
				Return Me._chkb7p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb7p IsNot Nothing Then
                End If
                Me._chkb7p = value
                If Me._chkb7p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700085C RID: 2140
		' (get) Token: 0x06001609 RID: 5641 RVA: 0x002C08B4 File Offset: 0x002BF8B4
		' (set) Token: 0x06001608 RID: 5640 RVA: 0x002C0898 File Offset: 0x002BF898
		Friend Overridable Property chkb5p As CheckBox
			Get
				Return Me._chkb5p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb5p IsNot Nothing Then
                End If
                Me._chkb5p = value
                If Me._chkb5p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700085D RID: 2141
		' (get) Token: 0x0600160A RID: 5642 RVA: 0x002C08C8 File Offset: 0x002BF8C8
		' (set) Token: 0x0600160B RID: 5643 RVA: 0x002C08DC File Offset: 0x002BF8DC
		Friend Overridable Property chkb6p As CheckBox
			Get
				Return Me._chkb6p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb6p IsNot Nothing Then
                End If
                Me._chkb6p = value
                If Me._chkb6p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700085E RID: 2142
		' (get) Token: 0x0600160C RID: 5644 RVA: 0x002C0914 File Offset: 0x002BF914
		' (set) Token: 0x0600160D RID: 5645 RVA: 0x002C08F8 File Offset: 0x002BF8F8
		Friend Overridable Property chkb4p As CheckBox
			Get
				Return Me._chkb4p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb4p IsNot Nothing Then
                End If
                Me._chkb4p = value
                If Me._chkb4p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x1700085F RID: 2143
		' (get) Token: 0x0600160F RID: 5647 RVA: 0x002C0928 File Offset: 0x002BF928
		' (set) Token: 0x0600160E RID: 5646 RVA: 0x002C093C File Offset: 0x002BF93C
		Friend Overridable Property chkb1a As CheckBox
			Get
				Return Me._chkb1a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb1a IsNot Nothing Then
                End If
                Me._chkb1a = value
                If Me._chkb1a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000860 RID: 2144
		' (get) Token: 0x06001611 RID: 5649 RVA: 0x002C0974 File Offset: 0x002BF974
		' (set) Token: 0x06001610 RID: 5648 RVA: 0x002C0958 File Offset: 0x002BF958
		Friend Overridable Property chkb2a As CheckBox
			Get
				Return Me._chkb2a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb2a IsNot Nothing Then
                End If
                Me._chkb2a = value
                If Me._chkb2a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000861 RID: 2145
		' (get) Token: 0x06001612 RID: 5650 RVA: 0x002C09A4 File Offset: 0x002BF9A4
		' (set) Token: 0x06001613 RID: 5651 RVA: 0x002C0988 File Offset: 0x002BF988
		Friend Overridable Property chkb12a As CheckBox
			Get
				Return Me._chkb12a
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb12a IsNot Nothing Then
                End If
                Me._chkb12a = value
                If Me._chkb12a IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000862 RID: 2146
		' (get) Token: 0x06001614 RID: 5652 RVA: 0x002C09B8 File Offset: 0x002BF9B8
		' (set) Token: 0x06001615 RID: 5653 RVA: 0x002C09CC File Offset: 0x002BF9CC
		Friend Overridable Property chkb12p As CheckBox
			Get
				Return Me._chkb12p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb12p IsNot Nothing Then
                End If
                Me._chkb12p = value
                If Me._chkb12p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000863 RID: 2147
		' (get) Token: 0x06001617 RID: 5655 RVA: 0x002C0A04 File Offset: 0x002BFA04
		' (set) Token: 0x06001616 RID: 5654 RVA: 0x002C09E8 File Offset: 0x002BF9E8
		Friend Overridable Property chkb1p As CheckBox
			Get
				Return Me._chkb1p
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkb1p IsNot Nothing Then
                End If
                Me._chkb1p = value
                If Me._chkb1p IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000864 RID: 2148
		' (get) Token: 0x06001619 RID: 5657 RVA: 0x002C0A6C File Offset: 0x002BFA6C
		' (set) Token: 0x06001618 RID: 5656 RVA: 0x002C0A18 File Offset: 0x002BFA18
		Friend Overridable Property btnPlaySound As Button
			Get
				Return Me._btnPlaySound
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnPlaySound IsNot Nothing Then
                    RemoveHandler Me._btnPlaySound.Click, AddressOf Me.btnPlaySound_Click
                End If
                Me._btnPlaySound = value
                If Me._btnPlaySound IsNot Nothing Then
                    AddHandler Me._btnPlaySound.Click, AddressOf Me.btnPlaySound_Click
                End If
            End Set
        End Property

		' Token: 0x17000865 RID: 2149
		' (get) Token: 0x0600161B RID: 5659 RVA: 0x002C0A80 File Offset: 0x002BFA80
		' (set) Token: 0x0600161A RID: 5658 RVA: 0x002C0A94 File Offset: 0x002BFA94
		Friend Overridable Property Timer1 As Timer
			Get
				Return Me._Timer1
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Timer)
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, AddressOf Me.Timer1_Tick
                End If
                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, AddressOf Me.Timer1_Tick
                End If
            End Set
        End Property

		' Token: 0x17000866 RID: 2150
		' (get) Token: 0x0600161C RID: 5660 RVA: 0x002C0AE8 File Offset: 0x002BFAE8
		' (set) Token: 0x0600161D RID: 5661 RVA: 0x002C0AFC File Offset: 0x002BFAFC
		Friend Overridable Property btnStopSound As Button
			Get
				Return Me._btnStopSound
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnStopSound IsNot Nothing Then
                    RemoveHandler Me._btnStopSound.Click, AddressOf Me.btnStopSound_Click
                End If
                Me._btnStopSound = value
                If Me._btnStopSound IsNot Nothing Then
                    AddHandler Me._btnStopSound.Click, AddressOf Me.btnStopSound_Click
                End If
            End Set
        End Property

		' Token: 0x17000867 RID: 2151
		' (get) Token: 0x0600161F RID: 5663 RVA: 0x002C0B6C File Offset: 0x002BFB6C
		' (set) Token: 0x0600161E RID: 5662 RVA: 0x002C0B50 File Offset: 0x002BFB50
		Friend Overridable Property tbSoundStatus As TextBox
			Get
				Return Me._tbSoundStatus
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbSoundStatus IsNot Nothing Then
                End If
                Me._tbSoundStatus = value
                If Me._tbSoundStatus IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x17000868 RID: 2152
		' (get) Token: 0x06001620 RID: 5664 RVA: 0x002C0B80 File Offset: 0x002BFB80
		' (set) Token: 0x06001621 RID: 5665 RVA: 0x002C0B94 File Offset: 0x002BFB94
		Friend Overridable Property Label26 As Label
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

		' Token: 0x06001623 RID: 5667 RVA: 0x002C48A0 File Offset: 0x002C38A0
		Public Sub New(UTSClass As clsUTS, KotorVerIndex As Integer, Optional IsDirectEdit As Boolean = False, Optional EditingPath As String = "")
			Me.New()
			If IsDirectEdit Then
				Me.m_bSaveGameMode = True
				Me.m_EditingFilePath = EditingPath
			End If
			Me.m_defaultTitleText = "Sound Editor - KotOR "
			Me.Text = Me.m_defaultTitleText
			If KotorVerIndex = 0 Then
				Me.Text += "I"
			Else
				Me.Text += "II"
			End If
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.UTS = UTSClass
			Me.KotorVersionIndex = KotorVerIndex
			Me.Setup()
			Me.result = Factory.System_Create(Me.fmSystem)
			Me.result = Me.fmSystem.getVersion(Me.FMODversion)
			If Convert.ToInt32(Me.FMODversion) < Convert.ToInt32(262405) Then
				MessageBox.Show(String.Concat(New String() { "Error!  You are using an old version of FMOD ", Me.FMODversion.ToString("X"), ".  This program requires ", 262405.ToString("X"), "." }))
			End If
			Me.result = Me.fmSystem.init(32, INITFLAG.NORMAL, CType((If(Nothing, Activator.CreateInstance(GetType(IntPtr)))), IntPtr))
			Me.htBIFSounds = frmMain.KxChitinKey(Me.KotorVersionIndex).GetBIFFileHash("sounds")
			Me.SoundsBifPath = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\"
			Me.SoundsBifPath += CType(frmMain.KxChitinKey(Me.KotorVersionIndex).BiffListInfo("sounds"), BIFFEntry).filename
			Me.SoundsResInfo = BIFFArchive.GetBIFFResourceInfoList(Me.SoundsBifPath)
		End Sub

		' Token: 0x06001624 RID: 5668 RVA: 0x002C4A74 File Offset: 0x002C3A74
		Private Sub Setup()
			Me.UTS.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocName")
			Me.UTS.SetTextBoxToNodeValue(Me.tbTag, "Tag")
			Me.UTS.SetTextBoxToNodeValue(Me.tbComment, "Comment")
			Me.trkbarVolume.Value = IntegerType.FromObject(Me.UTS.GetNodeValue("Volume"))
			Me.trkbarVolume_ValueChanged(Nothing, Nothing)
			Dim num As Integer = 0
			Dim num2 As Integer = Me.UTS.GetListItemCount("Sounds") - 1
			For i As Integer = num To num2
				Me.lbSounds.Items.Add(RuntimeHelpers.GetObjectValue(Me.UTS.GetNodeValue("Sounds(" + StringType.FromInteger(i) + ").Sound")))
			Next
			Dim flag As Boolean = BooleanType.FromObject(Me.UTS.GetNodeValue("Positional"))
			Dim flag2 As Boolean = BooleanType.FromObject(Me.UTS.GetNodeValue("RandomPosition"))
			If Not flag AndAlso Not flag2 Then
				Me.rbPlaysEverywhere.Checked = True
			ElseIf flag AndAlso flag2 Then
				Me.rbRandomPosition.Checked = True
			Else
				Me.rbSpecificPosition.Checked = True
			End If
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudMaxDistance, "MaxDistance", 0F)
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudMinDistance, "MinDistance", 0F)
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudElevation, "Elevation", 0F)
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudRandomRangeX, "RandomRangeX", 0F)
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudRandomRangeY, "RandomRangeY", 0F)
			Me.chkbActive.Checked = BooleanType.FromObject(Me.UTS.GetNodeValue("Active"))
			Dim nodeValue As Object = Me.UTS.GetNodeValue("Times")
			If ObjectType.ObjTst(nodeValue, 1, False) = 0 Then
				Me.rbPlayDay.Checked = True
			ElseIf ObjectType.ObjTst(nodeValue, 2, False) = 0 Then
				Me.rbPlayNight.Checked = True
			ElseIf ObjectType.ObjTst(nodeValue, 3, False) = 0 Then
				Me.rbPlayAllTimes.Checked = True
			ElseIf ObjectType.ObjTst(nodeValue, 0, False) = 0 Then
				Me.rbPlaySpecificHours.Checked = True
				Dim num3 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTS.GetNodeValue("Hours")))
				Try
					For Each obj As Object In Me.pnlHours.Controls
						Dim control As Control = CType(obj, Control)
						If StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0 AndAlso (CLng(num3) And CLng(Math.Round(Math.Pow(2.0, CDbl(Convert.ToInt32(RuntimeHelpers.GetObjectValue(control.Tag))))))) <> 0L Then
							CType(control, CheckBox).Checked = True
						End If
					Next
				Finally
                    Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Dim flag3 As Boolean = BooleanType.FromObject(Me.UTS.GetNodeValue("Continuous"))
			Dim flag4 As Boolean = BooleanType.FromObject(Me.UTS.GetNodeValue("Looping"))
			If Not flag3 AndAlso Not flag4 Then
				Me.rbOnce.Checked = True
			ElseIf flag3 And Not flag4 Then
				Me.rbRepeating.Checked = True
			ElseIf Not flag3 AndAlso flag4 Then
				Me.rbLooping.Checked = True
			End If
			If BooleanType.FromObject(Me.UTS.GetNodeValue("Random")) Then
				Me.rbRandom.Checked = True
			Else
				Me.rbSequential.Checked = True
			End If
			Me.UTS.SetNumericUpDownToUIntNodeValue(Me.nudInterval, "Interval", 0.01F)
			Me.UTS.SetNumericUpDownToUIntNodeValue(Me.nudIntervalVrtn, "IntervalVrtn", 0.01F)
			Me.trkbarVolumeVrtn.Value = IntegerType.FromObject(Me.UTS.GetNodeValue("VolumeVrtn"))
			Me.trkbarVolumeVrtn_ValueChanged(Nothing, Nothing)
			Me.trkbarPitchVrtn.Value = IntegerType.FromObject(ObjectType.MulObj(Me.UTS.GetNodeValue("PitchVariation"), 100))
			Me.trkbarPitchVrtn_ValueChanged(Nothing, Nothing)
		End Sub

		' Token: 0x06001625 RID: 5669 RVA: 0x002C4EE0 File Offset: 0x002C3EE0
		Private Sub SetGFFNodeValues()
			Me.UTS.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocName", Me.NameLang)
			Me.UTS.SetNodeValueFromTextBox(Me.tbTag, "Tag")
			Me.UTS.SetNodeValueFromTextBox(Me.tbComment, "Comment")
			Me.UTS.SetNodeValue("Volume", Me.trkbarVolume.Value)
			Me.UTS.ClearListElements("Sounds")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.lbSounds.Items.Count - 1
			For i As Integer = num To num2
				Dim gff_Struct As GFF_Struct = New GFF_Struct(1, 0)
				gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "Sound", RuntimeHelpers.GetObjectValue(Me.lbSounds.Items(i)))
				Me.UTS.AddListElement("Sounds", gff_Struct)
			Next
			Me.UTS.SetNodeValue("Positional", Not Me.rbPlaysEverywhere.Checked)
			Me.UTS.SetNodeValue("RandomPosition", Me.rbRandomPosition.Checked)
			If Me.rbPlaysEverywhere.Checked Then
				Me.UTS.SetNodeValue("Positional", Not Me.rbPlaysEverywhere.Checked)
			Else
				Me.UTS.SetNodeValue("Positional", Not Me.rbPlaysEverywhere.Checked)
			End If
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudMaxDistance, "MaxDistance", 0F)
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudMinDistance, "MinDistance", 0F)
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudElevation, "Elevation", 0F)
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudRandomRangeX, "RandomRangeX", 0F)
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudRandomRangeY, "RandomRangeY", 0F)
			Me.UTS.SetNodeValue("Active", Me.chkbActive.Checked)
			If Me.rbPlayDay.Checked Then
				Me.UTS.SetNodeValue("Times", 1)
			ElseIf Me.rbPlayNight.Checked Then
				Me.UTS.SetNodeValue("Times", 2)
			ElseIf Me.rbPlayAllTimes.Checked Then
				Me.UTS.SetNodeValue("Times", 3)
			Else
				Me.UTS.SetNodeValue("Times", 0)
				Dim num3 As Integer = 0
				Try
					For Each obj As Object In Me.pnlHours.Controls
						Dim control As Control = CType(obj, Control)
						If StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0 AndAlso CType(control, CheckBox).Checked Then
							' The following expression was wrapped in a unchecked-expression
							num3 = CInt((CLng(num3) Or CLng(Math.Round(Math.Pow(2.0, CDbl(Convert.ToInt32(RuntimeHelpers.GetObjectValue(control.Tag))))))))
						End If
					Next
				Finally
                    Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.UTS.SetNodeValue("Hours", num3)
			End If
			Me.UTS.SetNodeValue("Continuous", Me.rbRepeating.Checked)
			Me.UTS.SetNodeValue("Looping", Me.rbLooping.Checked)
			Me.UTS.SetNodeValue("Random", Me.rbRandom.Checked)
			Me.UTS.SetUInt32NodeValueFromNumericUpDown(Me.nudInterval, "Interval", 0.01F)
			Me.UTS.SetUInt32NodeValueFromNumericUpDown(Me.nudIntervalVrtn, "IntervalVrtn", 0.01F)
			Me.UTS.SetNodeValue("VolumeVrtn", Me.trkbarVolumeVrtn.Value)
			Me.UTS.SetNodeValue("PitchVariation", CDbl(Me.trkbarPitchVrtn.Value) / 100.0)
		End Sub

		' Token: 0x06001626 RID: 5670 RVA: 0x002C5334 File Offset: 0x002C4334
		Private Sub btnAddSound_Click(sender As Object, e As EventArgs)
			Dim frmSoundChooser As frmSoundChooser = New frmSoundChooser()
			frmSoundChooser.SoundBifFilesHash = Me.htBIFSounds
			If Me.htStreamSounds Is Nothing Then
				Me.htStreamSounds = New Hashtable()
				Dim directoryInfo As DirectoryInfo = New DirectoryInfo(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamSounds")
				For Each fileInfo As FileInfo In directoryInfo.GetFiles()
					Me.htStreamSounds.Add(fileInfo.Name, Nothing)
				Next
			End If
			frmSoundChooser.StreamSoundsFilesHash = Me.htStreamSounds
			frmSoundChooser.ShowDialog(Me)
			If frmSoundChooser.DialogResult = DialogResult.OK Then
				Try
					For Each obj As Object In frmSoundChooser.SelectedSounds
						Dim text As String = StringType.FromObject(obj)
						If text.Length > 16 Then
							Interaction.MsgBox(String.Concat(New String() { "The sound """, text, """", " must be renamed to be no more than 16 characters long, not including the extension, to be used.", vbLf, vbLf, "The sound will not be added." }), MsgBoxStyle.Critical, "ResRef too long")
						Else
							Me.lbSounds.Items.Add(text)
						End If
					Next
				Finally
                    Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Me.UpdateUI()
		End Sub

		' Token: 0x06001627 RID: 5671 RVA: 0x002C54A8 File Offset: 0x002C44A8
		Private Sub btnRemoveSound_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.lbSounds.SelectedIndices.Count = 1 Then
				Me.lbSounds.Items.RemoveAt(Me.lbSounds.SelectedIndex)
			ElseIf Me.lbSounds.SelectedIndices.Count > 1 AndAlso Interaction.MsgBox("Remove all " + StringType.FromInteger(Me.lbSounds.SelectedIndices.Count) + " sounds?", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Confirm removal") = MsgBoxResult.Ok Then
				For i As Integer = Me.lbSounds.SelectedIndices.Count - 1 To 0 Step -1
					Me.lbSounds.Items.RemoveAt(Me.lbSounds.SelectedIndices(i))
				Next
			End If
			Me.UpdateUI()
		End Sub

		' Token: 0x06001628 RID: 5672 RVA: 0x002C5578 File Offset: 0x002C4578
		Private Sub btnPlaySound_Click(sender As Object, e As EventArgs)
			If Me.PlaySound(StringType.FromObject(ObjectType.StrCatObj(Me.lbSounds.SelectedItem, ".wav"))) Then
				Me.btnPlaySound.Enabled = False
				Me.btnStopSound.Enabled = True
			End If
		End Sub

		' Token: 0x06001629 RID: 5673 RVA: 0x002C55B4 File Offset: 0x002C45B4
		Private Sub btnStopSound_Click(sender As Object, e As EventArgs)
			Me.StopSound()
		End Sub

		' Token: 0x0600162A RID: 5674 RVA: 0x002C55BC File Offset: 0x002C45BC
		Private Sub btnMoveUp_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lbSounds.SelectedIndex
			If selectedIndex > 0 Then
				Dim text As String = StringType.FromObject(Me.lbSounds.SelectedItem)
				Me.lbSounds.Items(selectedIndex) = RuntimeHelpers.GetObjectValue(Me.lbSounds.Items(selectedIndex - 1))
				Me.lbSounds.Items(selectedIndex - 1) = text
				Dim lbSounds As ListBox = Me.lbSounds
				lbSounds.SelectedIndex -= 1
			End If
		End Sub

		' Token: 0x0600162B RID: 5675 RVA: 0x002C563C File Offset: 0x002C463C
		Private Sub btnMoveDown_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lbSounds.SelectedIndex
			If selectedIndex < Me.lbSounds.Items.Count - 1 Then
				Dim text As String = StringType.FromObject(Me.lbSounds.SelectedItem)
				Me.lbSounds.Items(selectedIndex) = RuntimeHelpers.GetObjectValue(Me.lbSounds.Items(selectedIndex + 1))
				Me.lbSounds.Items(selectedIndex + 1) = text
				Dim lbSounds As ListBox = Me.lbSounds
				lbSounds.SelectedIndex += 1
			End If
		End Sub

		' Token: 0x0600162C RID: 5676 RVA: 0x002C56D0 File Offset: 0x002C46D0
		Private Sub btnSetNameLang_Click(sender As Object, e As EventArgs)
			Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
			If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
				Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
			End If
		End Sub

		' Token: 0x0600162D RID: 5677 RVA: 0x002C5700 File Offset: 0x002C4700
		Private Sub btnDebug_Click(sender As Object, e As EventArgs)
			Dim frmTextEditor As frmTextEditor = New frmTextEditor()
			frmTextEditor.Filename = Me.tbName.Text + ".uts"
			frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
			frmTextEditor.RTFMode = True
			frmTextEditor.tbGeneric.Rtf = Me.UTS.ToString()
			frmTextEditor.tbGeneric.SelectionLength = 0
			frmTextEditor.Show()
		End Sub

		' Token: 0x0600162E RID: 5678 RVA: 0x002C5774 File Offset: 0x002C4774
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Me.SetGFFNodeValues()
			If Not Me.m_bSaveGameMode Then
				Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".uts", "", "", False, True))
				If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
					Return
				End If
			End If
			Me.UTS.WriteFile(Me.m_EditingFilePath, "UTS")
			If Me.m_bSaveGameMode Then
				Me.Close()
			End If
		End Sub

		' Token: 0x0600162F RID: 5679 RVA: 0x002C580C File Offset: 0x002C480C
		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06001630 RID: 5680 RVA: 0x002C5814 File Offset: 0x002C4814
		Private Sub lbSounds_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.lbSounds.SelectedIndex = -1 Then
				Me.btnMoveUp.Enabled = False
				Me.btnMoveDown.Enabled = False
				Me.btnRemoveSound.Enabled = False
				Me.btnPlaySound.Enabled = False
				Me.IsItemSelected = False
			Else
				Me.IsItemSelected = True
				If Not Me.IsSoundPlaying() Then
					Me.btnPlaySound.Enabled = True
				End If
				Me.btnRemoveSound.Enabled = True
				If(Me.lbSounds.Items.Count = 1) Or (Me.lbSounds.SelectedIndices.Count > 1) Then
					Me.btnMoveUp.Enabled = False
					Me.btnMoveDown.Enabled = False
				ElseIf Me.lbSounds.SelectedIndices.Count = 1 Then
					' The following expression was wrapped in a checked-expression
					If Me.lbSounds.SelectedIndex = Me.lbSounds.Items.Count - 1 Then
						Me.btnMoveUp.Enabled = True
						Me.btnMoveDown.Enabled = False
					ElseIf Me.lbSounds.SelectedIndex = 0 Then
						Me.btnMoveUp.Enabled = False
						Me.btnMoveDown.Enabled = True
					Else
						Me.btnMoveUp.Enabled = True
						Me.btnMoveDown.Enabled = True
					End If
				End If
			End If
		End Sub

		' Token: 0x06001631 RID: 5681 RVA: 0x002C5964 File Offset: 0x002C4964
		Private Sub lbSounds_DoubleClick(sender As Object, e As EventArgs)
			If(Me.lbSounds.SelectedIndex <> -1) And Not Me.IsSoundPlaying() Then
				Me.btnPlaySound_Click(Nothing, Nothing)
			End If
		End Sub

		' Token: 0x06001632 RID: 5682 RVA: 0x002C598C File Offset: 0x002C498C
		Private Sub rbPlaysWhere_CheckedChanged(sender As Object, e As EventArgs)
			Me.gbHeight.Enabled = Not Me.rbPlaysEverywhere.Checked
			Me.gbVolumeDistances.Enabled = Not Me.rbPlaysEverywhere.Checked
			Me.gbRandomRange.Enabled = Me.rbRandomPosition.Checked
		End Sub

		' Token: 0x06001633 RID: 5683 RVA: 0x002C59E4 File Offset: 0x002C49E4
		Private Sub rbPlayDay_CheckedChanged(sender As Object, e As EventArgs)
			Me.pnlHours.Enabled = Me.rbPlaySpecificHours.Checked
		End Sub

		' Token: 0x06001634 RID: 5684 RVA: 0x002C59FC File Offset: 0x002C49FC
		Private Sub rbLooping_CheckedChanged(sender As Object, e As EventArgs)
			Me.rbSequential.Enabled = Not Me.rbLooping.Checked
			Me.rbRandom.Enabled = Not Me.rbLooping.Checked
			Me.pnlVolPitch.Enabled = Not Me.rbLooping.Checked
			Me.gbInterval.Enabled = Me.rbRepeating.Checked
			If Me.rbLooping.Checked Then
				If Me.rbRandomPosition.Checked Then
					Me.rbPlaysEverywhere.Checked = True
				End If
				Me.rbSequential.Checked = True
			End If
			Me.rbRandomPosition.Enabled = Not Me.rbLooping.Checked
		End Sub

		' Token: 0x06001635 RID: 5685 RVA: 0x002C5AB8 File Offset: 0x002C4AB8
		Private Sub frmUTS_Editor_Load(sender As Object, e As EventArgs)
			Me.PositionWindow(Me.[GetType]().Name)
		End Sub

		' Token: 0x06001636 RID: 5686 RVA: 0x002C5ACC File Offset: 0x002C4ACC
		Private Sub frmUTS_Editor_Closing(sender As Object, e As CancelEventArgs)
			Me.SaveSettings(Me.[GetType]().Name)
			Me.ClosedownSound()
		End Sub

		' Token: 0x06001637 RID: 5687 RVA: 0x002C5AE8 File Offset: 0x002C4AE8
		Private Sub trkbarVolumeVrtn_ValueChanged(sender As Object, e As EventArgs)
			Me.tbVolumeVrtn.Text = StringType.FromInteger(Me.trkbarVolumeVrtn.Value)
		End Sub

		' Token: 0x06001638 RID: 5688 RVA: 0x002C5B08 File Offset: 0x002C4B08
		Private Sub trkbarPitchVrtn_ValueChanged(sender As Object, e As EventArgs)
			Me.tbPitchVrtn.Text = StringType.FromDouble(CDbl(Me.trkbarPitchVrtn.Value) / 100.0)
		End Sub

		' Token: 0x06001639 RID: 5689 RVA: 0x002C5B30 File Offset: 0x002C4B30
		Private Sub trkbarVolume_ValueChanged(sender As Object, e As EventArgs)
			Me.tbVolume.Text = StringType.FromInteger(Me.trkbarVolume.Value)
		End Sub

		' Token: 0x0600163A RID: 5690 RVA: 0x002C5B50 File Offset: 0x002C4B50
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			If Me.IsSoundPlaying() Then
				Dim num As UInteger
				Me.result = Me.channel.getPosition(num, TIMEUNIT.MS)
                Dim sound As Sound = Nothing
				Me.channel.getCurrentSound(sound)
				Dim num2 As UInteger
				If sound IsNot Nothing Then
					Me.result = sound.getLength(num2, TIMEUNIT.MS)
					If Me.result <> RESULT.OK AndAlso Me.result <> RESULT.ERR_INVALID_HANDLE AndAlso Me.result <> RESULT.ERR_CHANNEL_STOLEN Then
						Me.ERRCHECK(Me.result)
					End If
				End If
				Dim num3 As Integer = Convert.ToInt32(num2)
				Dim num4 As Integer = Convert.ToInt32(num)
				Me.tbSoundStatus.Text = String.Concat(New String() { (CLng(Math.Round(CDbl(num4) / 1000.0)) / 60L).ToString().PadLeft(2, "0"c), ":", Conversion.Int(CDbl(num4) / 1000.0 Mod 60.0).ToString().PadLeft(2, "0"c), ":", Conversion.Int(CDbl(num4) / 10.0 Mod 100.0).ToString().PadLeft(2, "0"c), "/", (CLng(Math.Round(CDbl(num3) / 1000.0)) / 60L).ToString().PadLeft(2, "0"c), ":", Conversion.Int(CDbl(num3) / 1000.0 Mod 60.0).ToString().PadLeft(2, "0"c), ":", Conversion.Int(CDbl(num3) / 10.0 Mod 100.0).ToString().PadLeft(2, "0"c) })
			Else
				Me.btnStopSound.Enabled = False
				If Me.IsItemSelected Then
					Me.btnPlaySound.Enabled = True
				End If
				Me.Timer1.Enabled = False
				If Me.sound1 IsNot Nothing Then
					Me.sound1.release()
				End If
				If Me.StoppedPlayingEvent IsNot Nothing Then
					Me.StoppedPlayingEvent()
				End If
			End If
		End Sub

		' Token: 0x0600163B RID: 5691 RVA: 0x002C5D98 File Offset: 0x002C4D98
		Private Sub ClosedownSound()
			If Me.channel IsNot Nothing Then
				Me.channel.[stop]()
			End If
			If Me.sound1 IsNot Nothing Then
				Me.sound1.release()
			End If
			If Me.fmSystem IsNot Nothing Then
				Me.result = Me.fmSystem.close()
				Me.result = Me.fmSystem.release()
			End If
		End Sub

		' Token: 0x0600163C RID: 5692 RVA: 0x002C5DF8 File Offset: 0x002C4DF8
		Private Sub UpdateUI()
			If Me.lbSounds.Items.Count > 1 Then
				Me.rbLooping.Enabled = False
				If Me.rbLooping.Checked Then
					Me.rbOnce.Checked = True
				End If
			Else
				Me.rbLooping.Enabled = True
				Me.rbSequential.Enabled = True
				Me.rbSequential.Checked = True
				Me.rbRandom.Enabled = False
			End If
		End Sub

		' Token: 0x0600163D RID: 5693 RVA: 0x002C5E70 File Offset: 0x002C4E70
		Public Sub SetFormName(Name As String)
			Me.Text = "Sound Editor - " + Name
		End Sub

		' Token: 0x0600163E RID: 5694 RVA: 0x002C5E84 File Offset: 0x002C4E84
		Public Function PlaySound(filename As String) As Boolean
            Dim biffvarRsrcEntryInfo As BIFFVarRsrcEntryInfo = Nothing
			Dim flag As Boolean
			If Me.htBIFSounds.ContainsKey(filename) Then
				biffvarRsrcEntryInfo = Me.SoundsResInfo(IntegerType.FromObject(Me.htBIFSounds(filename)))
				filename = Me.SoundsBifPath
				flag = True
			ElseIf File.Exists(Me.g_ProjectPath + "\extras\" + filename) Then
				filename = Me.g_ProjectPath + "\extras\" + filename
			ElseIf Me.CurrentSettings.bUseOverrideFiles AndAlso File.Exists(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\Override\" + filename) Then
				filename = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\Override\" + filename
			ElseIf File.Exists(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamSounds\" + filename) Then
				filename = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamSounds\" + filename
			ElseIf File.Exists(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamVoice\" + filename) Then
				filename = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamVoice\" + filename
			Else
				If Not File.Exists(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamMusic\" + filename) Then
					Return False
				End If
				filename = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamMusic\" + filename
			End If
			Dim createsoundexinfo As CREATESOUNDEXINFO = Nothing
			createsoundexinfo.cbsize = 72
			If Not flag Then
				Dim kotorSoundInfo As KTSoundInfo = frmMain.GetKotorSoundInfo(filename)
				createsoundexinfo.length = Convert.ToUInt32(kotorSoundInfo.DataSize)
				createsoundexinfo.fileoffset = Convert.ToUInt32(kotorSoundInfo.DataOffset)
			Else
				createsoundexinfo.length = Convert.ToUInt32(biffvarRsrcEntryInfo.FileSize)
				createsoundexinfo.fileoffset = Convert.ToUInt32(biffvarRsrcEntryInfo.Offset)
			End If
			Me.result = Me.fmSystem.createSound(filename, CType(32936, MODE), createsoundexinfo, Me.sound1)
			Me.result = Me.fmSystem.playSound(CHANNELINDEX.FREE, Me.sound1, False, Me.channel)
			Me.Timer1.Enabled = True
			Return True
		End Function

		' Token: 0x0600163F RID: 5695 RVA: 0x002C60C4 File Offset: 0x002C50C4
		Public Sub StopSound()
			Me.channel.[stop]()
			Me.Timer1.Enabled = False
			Me.btnStopSound.Enabled = False
			Me.btnPlaySound.Enabled = True
			If Me.sound1 IsNot Nothing Then
				Me.sound1.release()
			End If
		End Sub

		' Token: 0x06001640 RID: 5696 RVA: 0x002C6118 File Offset: 0x002C5118
		Public Function IsSoundPlaying() As Boolean
			Dim flag As Boolean = False
			If Me.channel IsNot Nothing Then
				Me.result = Me.channel.isPlaying(flag)
			End If
			Return flag
		End Function

		' Token: 0x06001641 RID: 5697 RVA: 0x002C6144 File Offset: 0x002C5144
		Private Sub ERRCHECK(result As RESULT)
			If result <> RESULT.OK Then
			End If
		End Sub

        ' Token: 0x04000A50 RID: 2640
        <AccessedThroughProperty("chkb7a")> _
        Private _chkb7a As CheckBox

        ' Token: 0x04000A51 RID: 2641
        <AccessedThroughProperty("chkb2p")> _
        Private _chkb2p As CheckBox

        ' Token: 0x04000A52 RID: 2642
        <AccessedThroughProperty("GroupBox5")> _
        Private _GroupBox5 As GroupBox

        ' Token: 0x04000A53 RID: 2643
        <AccessedThroughProperty("chkb5a")> _
        Private _chkb5a As CheckBox

        ' Token: 0x04000A54 RID: 2644
        <AccessedThroughProperty("GroupBox6")> _
        Private _GroupBox6 As GroupBox

        ' Token: 0x04000A55 RID: 2645
        <AccessedThroughProperty("chkb6a")> _
        Private _chkb6a As CheckBox

        ' Token: 0x04000A56 RID: 2646
        <AccessedThroughProperty("chkb4a")> _
        Private _chkb4a As CheckBox

        ' Token: 0x04000A57 RID: 2647
        <AccessedThroughProperty("chkb10p")> _
        Private _chkb10p As CheckBox

        ' Token: 0x04000A58 RID: 2648
        <AccessedThroughProperty("btnSetNameLang")> _
        Private _btnSetNameLang As Button

        ' Token: 0x04000A59 RID: 2649
        <AccessedThroughProperty("chkb3p")> _
        Private _chkb3p As CheckBox

        ' Token: 0x04000A5A RID: 2650
        <AccessedThroughProperty("chkb3a")> _
        Private _chkb3a As CheckBox

        ' Token: 0x04000A5B RID: 2651
        <AccessedThroughProperty("tbVolume")> _
        Private _tbVolume As TextBox

        ' Token: 0x04000A5C RID: 2652
        <AccessedThroughProperty("tbName")> _
        Private _tbName As TextBox

        ' Token: 0x04000A5D RID: 2653
        <AccessedThroughProperty("nudMinDistance")> _
        Private _nudMinDistance As NumericUpDown

        ' Token: 0x04000A5E RID: 2654
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x04000A5F RID: 2655
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x04000A60 RID: 2656
        <AccessedThroughProperty("tbVolumeVrtn")> _
        Private _tbVolumeVrtn As TextBox

        ' Token: 0x04000A61 RID: 2657
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x04000A62 RID: 2658
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000A63 RID: 2659
        <AccessedThroughProperty("GroupBox4")> _
        Private _GroupBox4 As GroupBox

        ' Token: 0x04000A64 RID: 2660
        <AccessedThroughProperty("nudMaxDistance")> _
        Private _nudMaxDistance As NumericUpDown

        ' Token: 0x04000A65 RID: 2661
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x04000A66 RID: 2662
        <AccessedThroughProperty("trkbarVolume")> _
        Private _trkbarVolume As TrackBar

        ' Token: 0x04000A67 RID: 2663
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x04000A68 RID: 2664
        <AccessedThroughProperty("btnRemoveSound")> _
        Private _btnRemoveSound As Button

        ' Token: 0x04000A69 RID: 2665
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x04000A6A RID: 2666
        <AccessedThroughProperty("btnAddSound")> _
        Private _btnAddSound As Button

        ' Token: 0x04000A6B RID: 2667
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000A6C RID: 2668
        <AccessedThroughProperty("chkb9p")> _
        Private _chkb9p As CheckBox

        ' Token: 0x04000A6D RID: 2669
        <AccessedThroughProperty("pnlVolPitch")> _
        Private _pnlVolPitch As Panel

        ' Token: 0x04000A6E RID: 2670
        <AccessedThroughProperty("chkb11p")> _
        Private _chkb11p As CheckBox

        ' Token: 0x04000A6F RID: 2671
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000A70 RID: 2672
        <AccessedThroughProperty("chkb11a")> _
        Private _chkb11a As CheckBox

        ' Token: 0x04000A71 RID: 2673
        <AccessedThroughProperty("chkb9a")> _
        Private _chkb9a As CheckBox

        ' Token: 0x04000A72 RID: 2674
        <AccessedThroughProperty("rbLooping")> _
        Private _rbLooping As RadioButton

        ' Token: 0x04000A73 RID: 2675
        <AccessedThroughProperty("chkb10a")> _
        Private _chkb10a As CheckBox

        ' Token: 0x04000A74 RID: 2676
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x04000A75 RID: 2677
        <AccessedThroughProperty("pnlHours")> _
        Private _pnlHours As Panel

        ' Token: 0x04000A76 RID: 2678
        <AccessedThroughProperty("chkb8a")> _
        Private _chkb8a As CheckBox

        ' Token: 0x04000A77 RID: 2679
        <AccessedThroughProperty("nudRandomRangeX")> _
        Private _nudRandomRangeX As NumericUpDown

        ' Token: 0x04000A78 RID: 2680
        <AccessedThroughProperty("nudRandomRangeY")> _
        Private _nudRandomRangeY As NumericUpDown

        ' Token: 0x04000A79 RID: 2681
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer

        ' Token: 0x04000A7A RID: 2682
        <AccessedThroughProperty("nudElevation")> _
        Private _nudElevation As NumericUpDown

        ' Token: 0x04000A7B RID: 2683
        <AccessedThroughProperty("chkb7p")> _
        Private _chkb7p As CheckBox

        ' Token: 0x04000A7C RID: 2684
        <AccessedThroughProperty("tbPitchVrtn")> _
        Private _tbPitchVrtn As TextBox

        ' Token: 0x04000A7D RID: 2685
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x04000A7E RID: 2686
        <AccessedThroughProperty("lblAM")> _
        Private _lblAM As Label

        ' Token: 0x04000A7F RID: 2687
        <AccessedThroughProperty("lblPM")> _
        Private _lblPM As Label

        ' Token: 0x04000A80 RID: 2688
        <AccessedThroughProperty("lbl12")> _
        Private _lbl12 As Label

        ' Token: 0x04000A81 RID: 2689
        <AccessedThroughProperty("trkbarPitchVrtn")> _
        Private _trkbarPitchVrtn As TrackBar

        ' Token: 0x04000A82 RID: 2690
        <AccessedThroughProperty("nudIntervalVrtn")> _
        Private _nudIntervalVrtn As NumericUpDown

        ' Token: 0x04000A83 RID: 2691
        <AccessedThroughProperty("nudInterval")> _
        Private _nudInterval As NumericUpDown

        ' Token: 0x04000A84 RID: 2692
        <AccessedThroughProperty("gbInterval")> _
        Private _gbInterval As GroupBox

        ' Token: 0x04000A85 RID: 2693
        <AccessedThroughProperty("rbRandom")> _
        Private _rbRandom As RadioButton

        ' Token: 0x04000A86 RID: 2694
        <AccessedThroughProperty("rbSequential")> _
        Private _rbSequential As RadioButton

        ' Token: 0x04000A87 RID: 2695
        <AccessedThroughProperty("rbRepeating")> _
        Private _rbRepeating As RadioButton

        ' Token: 0x04000A88 RID: 2696
        <AccessedThroughProperty("chkb5p")> _
        Private _chkb5p As CheckBox

        ' Token: 0x04000A89 RID: 2697
        <AccessedThroughProperty("rbOnce")> _
        Private _rbOnce As RadioButton

        ' Token: 0x04000A8A RID: 2698
        <AccessedThroughProperty("trkbarVolumeVrtn")> _
        Private _trkbarVolumeVrtn As TrackBar

        ' Token: 0x04000A8B RID: 2699
        <AccessedThroughProperty("rbPlaySpecificHours")> _
        Private _rbPlaySpecificHours As RadioButton

        ' Token: 0x04000A8C RID: 2700
        <AccessedThroughProperty("rbPlayAllTimes")> _
        Private _rbPlayAllTimes As RadioButton

        ' Token: 0x04000A8D RID: 2701
        <AccessedThroughProperty("rbPlayNight")> _
        Private _rbPlayNight As RadioButton

        ' Token: 0x04000A8E RID: 2702
        <AccessedThroughProperty("rbPlayDay")> _
        Private _rbPlayDay As RadioButton

        ' Token: 0x04000A8F RID: 2703
        <AccessedThroughProperty("btnPlaySound")> _
        Private _btnPlaySound As Button

        ' Token: 0x04000A90 RID: 2704
        <AccessedThroughProperty("chkb6p")> _
        Private _chkb6p As CheckBox

        ' Token: 0x04000A91 RID: 2705
        <AccessedThroughProperty("btnStopSound")> _
        Private _btnStopSound As Button

        ' Token: 0x04000A92 RID: 2706
        <AccessedThroughProperty("chkb4p")> _
        Private _chkb4p As CheckBox

        ' Token: 0x04000A93 RID: 2707
        <AccessedThroughProperty("PictureBox3")> _
        Private _PictureBox3 As PictureBox

        ' Token: 0x04000A94 RID: 2708
        <AccessedThroughProperty("PictureBox2")> _
        Private _PictureBox2 As PictureBox

        ' Token: 0x04000A95 RID: 2709
        <AccessedThroughProperty("lbSounds")> _
        Private _lbSounds As ListBox

        ' Token: 0x04000A96 RID: 2710
        <AccessedThroughProperty("gbRandomRange")> _
        Private _gbRandomRange As GroupBox

        ' Token: 0x04000A97 RID: 2711
        <AccessedThroughProperty("Label13")> _
        Private _Label13 As Label

        ' Token: 0x04000A98 RID: 2712
        <AccessedThroughProperty("chkb1a")> _
        Private _chkb1a As CheckBox

        ' Token: 0x04000A99 RID: 2713
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x04000A9A RID: 2714
        <AccessedThroughProperty("chkb2a")> _
        Private _chkb2a As CheckBox

        ' Token: 0x04000A9B RID: 2715
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x04000A9C RID: 2716
        <AccessedThroughProperty("chkb12a")> _
        Private _chkb12a As CheckBox

        ' Token: 0x04000A9D RID: 2717
        <AccessedThroughProperty("Label16")> _
        Private _Label16 As Label

        ' Token: 0x04000A9E RID: 2718
        <AccessedThroughProperty("chkb12p")> _
        Private _chkb12p As CheckBox

        ' Token: 0x04000A9F RID: 2719
        <AccessedThroughProperty("Label17")> _
        Private _Label17 As Label

        ' Token: 0x04000AA0 RID: 2720
        <AccessedThroughProperty("chkb1p")> _
        Private _chkb1p As CheckBox

        ' Token: 0x04000AA1 RID: 2721
        <AccessedThroughProperty("Label18")> _
        Private _Label18 As Label

        ' Token: 0x04000AA2 RID: 2722
        <AccessedThroughProperty("gbVolumeDistances")> _
        Private _gbVolumeDistances As GroupBox

        ' Token: 0x04000AA3 RID: 2723
        <AccessedThroughProperty("tbSoundStatus")> _
        Private _tbSoundStatus As TextBox

        ' Token: 0x04000AA4 RID: 2724
        <AccessedThroughProperty("Label19")> _
        Private _Label19 As Label

        ' Token: 0x04000AA5 RID: 2725
        <AccessedThroughProperty("Label20")> _
        Private _Label20 As Label

        ' Token: 0x04000AA6 RID: 2726
        <AccessedThroughProperty("Label21")> _
        Private _Label21 As Label

        ' Token: 0x04000AA7 RID: 2727
        <AccessedThroughProperty("Label22")> _
        Private _Label22 As Label

        ' Token: 0x04000AA8 RID: 2728
        <AccessedThroughProperty("Label26")> _
        Private _Label26 As Label

        ' Token: 0x04000AA9 RID: 2729
        <AccessedThroughProperty("Label23")> _
        Private _Label23 As Label

        ' Token: 0x04000AAA RID: 2730
        <AccessedThroughProperty("gbHeight")> _
        Private _gbHeight As GroupBox

        ' Token: 0x04000AAB RID: 2731
        <AccessedThroughProperty("chkbActive")> _
        Private _chkbActive As CheckBox

        ' Token: 0x04000AAC RID: 2732
        <AccessedThroughProperty("tabpagAdvanced")> _
        Private _tabpagAdvanced As TabPage

        ' Token: 0x04000AAD RID: 2733
        <AccessedThroughProperty("tbapagPositioning")> _
        Private _tbapagPositioning As TabPage

        ' Token: 0x04000AAE RID: 2734
        <AccessedThroughProperty("tabpagBasic")> _
        Private _tabpagBasic As TabPage

        ' Token: 0x04000AAF RID: 2735
        <AccessedThroughProperty("rbSpecificPosition")> _
        Private _rbSpecificPosition As RadioButton

        ' Token: 0x04000AB0 RID: 2736
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000AB1 RID: 2737
        <AccessedThroughProperty("rbRandomPosition")> _
        Private _rbRandomPosition As RadioButton

        ' Token: 0x04000AB2 RID: 2738
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000AB3 RID: 2739
        <AccessedThroughProperty("rbPlaysEverywhere")> _
        Private _rbPlaysEverywhere As RadioButton

        ' Token: 0x04000AB4 RID: 2740
        <AccessedThroughProperty("PictureBox1")> _
        Private _PictureBox1 As PictureBox

        ' Token: 0x04000AB5 RID: 2741
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000AB6 RID: 2742
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000AB7 RID: 2743
        <AccessedThroughProperty("Label24")> _
        Private _Label24 As Label

        ' Token: 0x04000AB9 RID: 2745
        <AccessedThroughProperty("btnMoveUp")> _
        Private _btnMoveUp As Button

        ' Token: 0x04000ABA RID: 2746
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As Button

        ' Token: 0x04000ABB RID: 2747
        <AccessedThroughProperty("btnMoveDown")> _
        Private _btnMoveDown As Button

        ' Token: 0x04000ABC RID: 2748
        <AccessedThroughProperty("tbComment")> _
        Private _tbComment As TextBox

        ' Token: 0x04000ABD RID: 2749
        <AccessedThroughProperty("Label25")> _
        Private _Label25 As Label

        ' Token: 0x04000ABE RID: 2750
        <AccessedThroughProperty("chkb8p")> _
        Private _chkb8p As CheckBox

        ' Token: 0x04000ABF RID: 2751
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

		' Token: 0x04000AC1 RID: 2753
		Public UTS As clsUTS

		' Token: 0x04000AC2 RID: 2754
		Private NameLang As Integer

		' Token: 0x04000AC3 RID: 2755
		Private m_bSaveGameMode As Boolean

		' Token: 0x04000AC4 RID: 2756
		Public g_ProjectPath As String

		' Token: 0x04000AC5 RID: 2757
		Private fmSystem As Global.FMOD.System

		' Token: 0x04000AC6 RID: 2758
		Private result As RESULT

		' Token: 0x04000AC7 RID: 2759
		Private FMODversion As UInteger

		' Token: 0x04000AC8 RID: 2760
		Private sound1 As Sound

		' Token: 0x04000AC9 RID: 2761
		Private channel As Channel

		' Token: 0x04000ACA RID: 2762
		Private SoundsBifPath As String

		' Token: 0x04000ACB RID: 2763
		Private IsItemSelected As Boolean

		' Token: 0x04000ACC RID: 2764
		Private htBIFSounds As Hashtable

		' Token: 0x04000ACD RID: 2765
		Private htStreamSounds As Hashtable

		' Token: 0x04000ACE RID: 2766
		Private SoundsResInfo As BIFFVarRsrcEntryInfo()

		' Token: 0x02000083 RID: 131
		' (Invoke) Token: 0x06001645 RID: 5701
		Public Delegate Sub StoppedPlayingEventHandler()
	End Class
End Namespace
