Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace kotor_tool
	' Token: 0x0200005C RID: 92
	Public Partial Class frmModule_Editor
		Inherits frmParent

		' Token: 0x060007A2 RID: 1954 RVA: 0x0025A2F4 File Offset: 0x002592F4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmModule_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmModule_Editor_Closing
			Me.bModuleLoadedOK = False
			Me.g_ShowPaletteNames = True
			Me.g_CurrentPaletteModItemType = -1
			Me.g_mapsPath = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\SCM\Kotor Tool").GetValue("path")), "maps\")
			Me.bPaletteVisible = True
			Me.bModElementsVisible = True
			Me.bConfirmDeletes = True
			Me.bShowLocatorRay = True
			Me.dModuleElementIndicatorSize = 1D
			Me.g_tvModule_TreeOpenPaths = New ArrayList()
			Me.g_UserPalettteFsw = New FileSystemWatcher()
			Me.g_ProjectFsw = New FileSystemWatcher()
			Me.CalibrationToolsVis = False
			Me.labelFont = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.labelBrush = New SolidBrush(Color.White)
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700023F RID: 575
		' (get) Token: 0x060007A5 RID: 1957 RVA: 0x0025A494 File Offset: 0x00259494
		' (set) Token: 0x060007A4 RID: 1956 RVA: 0x0025A410 File Offset: 0x00259410
		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				If Me._Panel1 IsNot Nothing Then
					RemoveHandler Me._Panel1.DragEnter, AddressOf Me.Panel1_DragEnter
					RemoveHandler Me._Panel1.DragDrop, AddressOf Me.Panel1_DragDrop
				End If
				Me._Panel1 = value
				If Me._Panel1 IsNot Nothing Then
					AddHandler Me._Panel1.DragEnter, AddressOf Me.Panel1_DragEnter
					AddHandler Me._Panel1.DragDrop, AddressOf Me.Panel1_DragDrop
				End If
			End Set
		End Property

		' Token: 0x17000240 RID: 576
		' (get) Token: 0x060007A6 RID: 1958 RVA: 0x0025A4A8 File Offset: 0x002594A8
		' (set) Token: 0x060007A7 RID: 1959 RVA: 0x0025A4BC File Offset: 0x002594BC
		Friend Overridable Property pbox As PictureBox
			Get
				Return Me._pbox
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				If Me._pbox IsNot Nothing Then
					RemoveHandler Me._pbox.MouseLeave, AddressOf Me.pbox_MouseLeave
					RemoveHandler Me._pbox.MouseUp, AddressOf Me.pbox_MouseUp
					RemoveHandler Me._pbox.MouseMove, AddressOf Me.pbox_MouseMove
					RemoveHandler Me._pbox.MouseDown, AddressOf Me.pbox_MouseDown
				End If
				Me._pbox = value
				If Me._pbox IsNot Nothing Then
					AddHandler Me._pbox.MouseLeave, AddressOf Me.pbox_MouseLeave
					AddHandler Me._pbox.MouseUp, AddressOf Me.pbox_MouseUp
					AddHandler Me._pbox.MouseMove, AddressOf Me.pbox_MouseMove
					AddHandler Me._pbox.MouseDown, AddressOf Me.pbox_MouseDown
				End If
			End Set
		End Property

		' Token: 0x17000241 RID: 577
		' (get) Token: 0x060007A9 RID: 1961 RVA: 0x0025A5F4 File Offset: 0x002595F4
		' (set) Token: 0x060007A8 RID: 1960 RVA: 0x0025A5A0 File Offset: 0x002595A0
		Friend Overridable Property nudXmul As NumericUpDown
			Get
				Return Me._nudXmul
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudXmul IsNot Nothing Then
					RemoveHandler Me._nudXmul.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
				End If
				Me._nudXmul = value
				If Me._nudXmul IsNot Nothing Then
					AddHandler Me._nudXmul.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
				End If
			End Set
		End Property

		' Token: 0x17000242 RID: 578
		' (get) Token: 0x060007AA RID: 1962 RVA: 0x0025A65C File Offset: 0x0025965C
		' (set) Token: 0x060007AB RID: 1963 RVA: 0x0025A608 File Offset: 0x00259608
		Friend Overridable Property nudYmul As NumericUpDown
			Get
				Return Me._nudYmul
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudYmul IsNot Nothing Then
					RemoveHandler Me._nudYmul.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
				End If
				Me._nudYmul = value
				If Me._nudYmul IsNot Nothing Then
					AddHandler Me._nudYmul.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
				End If
			End Set
		End Property

		' Token: 0x17000243 RID: 579
		' (get) Token: 0x060007AD RID: 1965 RVA: 0x0025A6C4 File Offset: 0x002596C4
		' (set) Token: 0x060007AC RID: 1964 RVA: 0x0025A670 File Offset: 0x00259670
		Friend Overridable Property nudXoff As NumericUpDown
			Get
				Return Me._nudXoff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudXoff IsNot Nothing Then
					RemoveHandler Me._nudXoff.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
				End If
				Me._nudXoff = value
				If Me._nudXoff IsNot Nothing Then
					AddHandler Me._nudXoff.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
				End If
			End Set
		End Property

		' Token: 0x17000244 RID: 580
		' (get) Token: 0x060007AF RID: 1967 RVA: 0x0025A6D8 File Offset: 0x002596D8
		' (set) Token: 0x060007AE RID: 1966 RVA: 0x0025A6EC File Offset: 0x002596EC
		Friend Overridable Property nudYoff As NumericUpDown
			Get
				Return Me._nudYoff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudYoff IsNot Nothing Then
					RemoveHandler Me._nudYoff.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
				End If
				Me._nudYoff = value
				If Me._nudYoff IsNot Nothing Then
					AddHandler Me._nudYoff.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
				End If
			End Set
		End Property

		' Token: 0x17000245 RID: 581
		' (get) Token: 0x060007B1 RID: 1969 RVA: 0x0025A794 File Offset: 0x00259794
		' (set) Token: 0x060007B0 RID: 1968 RVA: 0x0025A740 File Offset: 0x00259740
		Friend Overridable Property btnTest As Button
			Get
				Return Me._btnTest
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnTest IsNot Nothing Then
					RemoveHandler Me._btnTest.Click, AddressOf Me.btnTest_Click
				End If
				Me._btnTest = value
				If Me._btnTest IsNot Nothing Then
					AddHandler Me._btnTest.Click, AddressOf Me.btnTest_Click
				End If
			End Set
		End Property

		' Token: 0x17000246 RID: 582
		' (get) Token: 0x060007B2 RID: 1970 RVA: 0x0025A7FC File Offset: 0x002597FC
		' (set) Token: 0x060007B3 RID: 1971 RVA: 0x0025A7A8 File Offset: 0x002597A8
		Friend Overridable Property btnClean As Button
			Get
				Return Me._btnClean
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnClean IsNot Nothing Then
					RemoveHandler Me._btnClean.Click, AddressOf Me.btnClean_Click
				End If
				Me._btnClean = value
				If Me._btnClean IsNot Nothing Then
					AddHandler Me._btnClean.Click, AddressOf Me.btnClean_Click
				End If
			End Set
		End Property

		' Token: 0x17000247 RID: 583
		' (get) Token: 0x060007B4 RID: 1972 RVA: 0x0025A924 File Offset: 0x00259924
		' (set) Token: 0x060007B5 RID: 1973 RVA: 0x0025A810 File Offset: 0x00259810
		Friend Overridable Property tvModule As TreeView
			Get
				Return Me._tvModule
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				If Me._tvModule IsNot Nothing Then
					RemoveHandler Me._tvModule.BeforeCollapse, AddressOf Me.tvModule_BeforeCollapse
					RemoveHandler Me._tvModule.BeforeExpand, AddressOf Me.tvModule_BeforeExpand
					RemoveHandler Me._tvModule.KeyUp, AddressOf Me.tvModule_KeyUp
					RemoveHandler Me._tvModule.MouseUp, AddressOf Me.tvModule_MouseUp
					RemoveHandler Me._tvModule.MouseDown, AddressOf Me.tvModule_MouseDown
				End If
				Me._tvModule = value
				If Me._tvModule IsNot Nothing Then
					AddHandler Me._tvModule.BeforeCollapse, AddressOf Me.tvModule_BeforeCollapse
					AddHandler Me._tvModule.BeforeExpand, AddressOf Me.tvModule_BeforeExpand
					AddHandler Me._tvModule.KeyUp, AddressOf Me.tvModule_KeyUp
					AddHandler Me._tvModule.MouseUp, AddressOf Me.tvModule_MouseUp
					AddHandler Me._tvModule.MouseDown, AddressOf Me.tvModule_MouseDown
				End If
			End Set
		End Property

		' Token: 0x17000248 RID: 584
		' (get) Token: 0x060007B6 RID: 1974 RVA: 0x0025A938 File Offset: 0x00259938
		' (set) Token: 0x060007B7 RID: 1975 RVA: 0x0025A94C File Offset: 0x0025994C
		Friend Overridable Property tvPalette As TreeView
			Get
				Return Me._tvPalette
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				If Me._tvPalette IsNot Nothing Then
					RemoveHandler Me._tvPalette.ItemDrag, AddressOf Me.tvPalette_ItemDrag
				End If
				Me._tvPalette = value
				If Me._tvPalette IsNot Nothing Then
					AddHandler Me._tvPalette.ItemDrag, AddressOf Me.tvPalette_ItemDrag
				End If
			End Set
		End Property

		' Token: 0x17000249 RID: 585
		' (get) Token: 0x060007B9 RID: 1977 RVA: 0x0025A9A0 File Offset: 0x002599A0
		' (set) Token: 0x060007B8 RID: 1976 RVA: 0x0025A9B4 File Offset: 0x002599B4
		Friend Overridable Property tvModuleContextMenuItem As ContextMenu
			Get
				Return Me._tvModuleContextMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				If Me._tvModuleContextMenuItem IsNot Nothing Then
				End If
				Me._tvModuleContextMenuItem = value
				If Me._tvModuleContextMenuItem IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700024A RID: 586
		' (get) Token: 0x060007BA RID: 1978 RVA: 0x0025A9D0 File Offset: 0x002599D0
		' (set) Token: 0x060007BB RID: 1979 RVA: 0x0025A9E4 File Offset: 0x002599E4
		Friend Overridable Property cmiTvModuleItemProperties As MenuItem
			Get
				Return Me._cmiTvModuleItemProperties
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiTvModuleItemProperties IsNot Nothing Then
					RemoveHandler Me._cmiTvModuleItemProperties.Click, AddressOf Me.cmiTvModuleItemProperties_Click
				End If
				Me._cmiTvModuleItemProperties = value
				If Me._cmiTvModuleItemProperties IsNot Nothing Then
					AddHandler Me._cmiTvModuleItemProperties.Click, AddressOf Me.cmiTvModuleItemProperties_Click
				End If
			End Set
		End Property

		' Token: 0x1700024B RID: 587
		' (get) Token: 0x060007BC RID: 1980 RVA: 0x0025AA38 File Offset: 0x00259A38
		' (set) Token: 0x060007BD RID: 1981 RVA: 0x0025AA4C File Offset: 0x00259A4C
		Friend Overridable Property btnPalDoor As Button
			Get
				Return Me._btnPalDoor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalDoor IsNot Nothing Then
					RemoveHandler Me._btnPalDoor.Click, AddressOf Me.btnPalDoor_Click
				End If
				Me._btnPalDoor = value
				If Me._btnPalDoor IsNot Nothing Then
					AddHandler Me._btnPalDoor.Click, AddressOf Me.btnPalDoor_Click
				End If
			End Set
		End Property

		' Token: 0x1700024C RID: 588
		' (get) Token: 0x060007BE RID: 1982 RVA: 0x0025AAA0 File Offset: 0x00259AA0
		' (set) Token: 0x060007BF RID: 1983 RVA: 0x0025AAB4 File Offset: 0x00259AB4
		Friend Overridable Property btnPalCreature As Button
			Get
				Return Me._btnPalCreature
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalCreature IsNot Nothing Then
					RemoveHandler Me._btnPalCreature.Click, AddressOf Me.btnPalCreature_Click
				End If
				Me._btnPalCreature = value
				If Me._btnPalCreature IsNot Nothing Then
					AddHandler Me._btnPalCreature.Click, AddressOf Me.btnPalCreature_Click
				End If
			End Set
		End Property

		' Token: 0x1700024D RID: 589
		' (get) Token: 0x060007C0 RID: 1984 RVA: 0x0025AB08 File Offset: 0x00259B08
		' (set) Token: 0x060007C1 RID: 1985 RVA: 0x0025AB1C File Offset: 0x00259B1C
		Friend Overridable Property btnPalEncounter As Button
			Get
				Return Me._btnPalEncounter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalEncounter IsNot Nothing Then
					RemoveHandler Me._btnPalEncounter.Click, AddressOf Me.btnPalEncounter_Click
				End If
				Me._btnPalEncounter = value
				If Me._btnPalEncounter IsNot Nothing Then
					AddHandler Me._btnPalEncounter.Click, AddressOf Me.btnPalEncounter_Click
				End If
			End Set
		End Property

		' Token: 0x1700024E RID: 590
		' (get) Token: 0x060007C3 RID: 1987 RVA: 0x0025AB70 File Offset: 0x00259B70
		' (set) Token: 0x060007C2 RID: 1986 RVA: 0x0025AB84 File Offset: 0x00259B84
		Friend Overridable Property btnPalItem As Button
			Get
				Return Me._btnPalItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalItem IsNot Nothing Then
					RemoveHandler Me._btnPalItem.Click, AddressOf Me.btnPalItem_Click
				End If
				Me._btnPalItem = value
				If Me._btnPalItem IsNot Nothing Then
					AddHandler Me._btnPalItem.Click, AddressOf Me.btnPalItem_Click
				End If
			End Set
		End Property

		' Token: 0x1700024F RID: 591
		' (get) Token: 0x060007C4 RID: 1988 RVA: 0x0025ABD8 File Offset: 0x00259BD8
		' (set) Token: 0x060007C5 RID: 1989 RVA: 0x0025ABEC File Offset: 0x00259BEC
		Friend Overridable Property btnPalMerchant As Button
			Get
				Return Me._btnPalMerchant
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalMerchant IsNot Nothing Then
					RemoveHandler Me._btnPalMerchant.Click, AddressOf Me.btnPalMerchant_Click
				End If
				Me._btnPalMerchant = value
				If Me._btnPalMerchant IsNot Nothing Then
					AddHandler Me._btnPalMerchant.Click, AddressOf Me.btnPalMerchant_Click
				End If
			End Set
		End Property

		' Token: 0x17000250 RID: 592
		' (get) Token: 0x060007C6 RID: 1990 RVA: 0x0025AC40 File Offset: 0x00259C40
		' (set) Token: 0x060007C7 RID: 1991 RVA: 0x0025AC54 File Offset: 0x00259C54
		Friend Overridable Property btnPalPlaceable As Button
			Get
				Return Me._btnPalPlaceable
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalPlaceable IsNot Nothing Then
					RemoveHandler Me._btnPalPlaceable.Click, AddressOf Me.btnPalPlaceable_Click
				End If
				Me._btnPalPlaceable = value
				If Me._btnPalPlaceable IsNot Nothing Then
					AddHandler Me._btnPalPlaceable.Click, AddressOf Me.btnPalPlaceable_Click
				End If
			End Set
		End Property

		' Token: 0x17000251 RID: 593
		' (get) Token: 0x060007C8 RID: 1992 RVA: 0x0025ACA8 File Offset: 0x00259CA8
		' (set) Token: 0x060007C9 RID: 1993 RVA: 0x0025ACBC File Offset: 0x00259CBC
		Friend Overridable Property btnPalWaypoint As Button
			Get
				Return Me._btnPalWaypoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalWaypoint IsNot Nothing Then
					RemoveHandler Me._btnPalWaypoint.Click, AddressOf Me.btnPalWaypoint_Click
				End If
				Me._btnPalWaypoint = value
				If Me._btnPalWaypoint IsNot Nothing Then
					AddHandler Me._btnPalWaypoint.Click, AddressOf Me.btnPalWaypoint_Click
				End If
			End Set
		End Property

		' Token: 0x17000252 RID: 594
		' (get) Token: 0x060007CB RID: 1995 RVA: 0x0025AD10 File Offset: 0x00259D10
		' (set) Token: 0x060007CA RID: 1994 RVA: 0x0025AD24 File Offset: 0x00259D24
		Friend Overridable Property btnPalSound As Button
			Get
				Return Me._btnPalSound
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalSound IsNot Nothing Then
					RemoveHandler Me._btnPalSound.Click, AddressOf Me.btnPalSound_Click
				End If
				Me._btnPalSound = value
				If Me._btnPalSound IsNot Nothing Then
					AddHandler Me._btnPalSound.Click, AddressOf Me.btnPalSound_Click
				End If
			End Set
		End Property

		' Token: 0x17000253 RID: 595
		' (get) Token: 0x060007CC RID: 1996 RVA: 0x0025AD78 File Offset: 0x00259D78
		' (set) Token: 0x060007CD RID: 1997 RVA: 0x0025AD8C File Offset: 0x00259D8C
		Friend Overridable Property btnPalTrigger As Button
			Get
				Return Me._btnPalTrigger
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnPalTrigger IsNot Nothing Then
					RemoveHandler Me._btnPalTrigger.Click, AddressOf Me.btnPalTrigger_Click
				End If
				Me._btnPalTrigger = value
				If Me._btnPalTrigger IsNot Nothing Then
					AddHandler Me._btnPalTrigger.Click, AddressOf Me.btnPalTrigger_Click
				End If
			End Set
		End Property

		' Token: 0x17000254 RID: 596
		' (get) Token: 0x060007CE RID: 1998 RVA: 0x0025ADE0 File Offset: 0x00259DE0
		' (set) Token: 0x060007CF RID: 1999 RVA: 0x0025ADF4 File Offset: 0x00259DF4
		Friend Overridable Property chkbShowResRefs As CheckBox
			Get
				Return Me._chkbShowResRefs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				If Me._chkbShowResRefs IsNot Nothing Then
					RemoveHandler Me._chkbShowResRefs.CheckedChanged, AddressOf Me.chkbShowResRefs_CheckedChanged
				End If
				Me._chkbShowResRefs = value
				If Me._chkbShowResRefs IsNot Nothing Then
					AddHandler Me._chkbShowResRefs.CheckedChanged, AddressOf Me.chkbShowResRefs_CheckedChanged
				End If
			End Set
		End Property

		' Token: 0x17000255 RID: 597
		' (get) Token: 0x060007D0 RID: 2000 RVA: 0x0025AE48 File Offset: 0x00259E48
		' (set) Token: 0x060007D1 RID: 2001 RVA: 0x0025AE5C File Offset: 0x00259E5C
		Friend Overridable Property ToolTip1 As ToolTip
			Get
				Return Me._ToolTip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolTip)
				If Me._ToolTip1 IsNot Nothing Then
				End If
				Me._ToolTip1 = value
				If Me._ToolTip1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000256 RID: 598
		' (get) Token: 0x060007D2 RID: 2002 RVA: 0x0025AE78 File Offset: 0x00259E78
		' (set) Token: 0x060007D3 RID: 2003 RVA: 0x0025AE8C File Offset: 0x00259E8C
		Friend Overridable Property btnLogFactors As Button
			Get
				Return Me._btnLogFactors
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnLogFactors IsNot Nothing Then
					RemoveHandler Me._btnLogFactors.Click, AddressOf Me.btnLogFactors_Click
				End If
				Me._btnLogFactors = value
				If Me._btnLogFactors IsNot Nothing Then
					AddHandler Me._btnLogFactors.Click, AddressOf Me.btnLogFactors_Click
				End If
			End Set
		End Property

		' Token: 0x17000257 RID: 599
		' (get) Token: 0x060007D5 RID: 2005 RVA: 0x0025AEE0 File Offset: 0x00259EE0
		' (set) Token: 0x060007D4 RID: 2004 RVA: 0x0025AEF4 File Offset: 0x00259EF4
		Friend Overridable Property ImageList1 As ImageList
			Get
				Return Me._ImageList1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				If Me._ImageList1 IsNot Nothing Then
				End If
				Me._ImageList1 = value
				If Me._ImageList1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000258 RID: 600
		' (get) Token: 0x060007D6 RID: 2006 RVA: 0x0025AF10 File Offset: 0x00259F10
		' (set) Token: 0x060007D7 RID: 2007 RVA: 0x0025AF24 File Offset: 0x00259F24
		Friend Overridable Property pnlPalette As Panel
			Get
				Return Me._pnlPalette
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				If Me._pnlPalette IsNot Nothing Then
				End If
				Me._pnlPalette = value
				If Me._pnlPalette IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000259 RID: 601
		' (get) Token: 0x060007D8 RID: 2008 RVA: 0x0025AF40 File Offset: 0x00259F40
		' (set) Token: 0x060007D9 RID: 2009 RVA: 0x0025AF54 File Offset: 0x00259F54
		Friend Overridable Property pnlModElements As Panel
			Get
				Return Me._pnlModElements
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				If Me._pnlModElements IsNot Nothing Then
				End If
				Me._pnlModElements = value
				If Me._pnlModElements IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700025A RID: 602
		' (get) Token: 0x060007DA RID: 2010 RVA: 0x0025AF70 File Offset: 0x00259F70
		' (set) Token: 0x060007DB RID: 2011 RVA: 0x0025AF84 File Offset: 0x00259F84
		Friend Overridable Property MainMenu1 As MainMenu
			Get
				Return Me._MainMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MainMenu)
				If Me._MainMenu1 IsNot Nothing Then
				End If
				Me._MainMenu1 = value
				If Me._MainMenu1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700025B RID: 603
		' (get) Token: 0x060007DC RID: 2012 RVA: 0x0025AFA0 File Offset: 0x00259FA0
		' (set) Token: 0x060007DD RID: 2013 RVA: 0x0025AFB4 File Offset: 0x00259FB4
		Friend Overridable Property MenuItem1 As MenuItem
			Get
				Return Me._MenuItem1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem1 IsNot Nothing Then
				End If
				Me._MenuItem1 = value
				If Me._MenuItem1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700025C RID: 604
		' (get) Token: 0x060007DF RID: 2015 RVA: 0x0025B024 File Offset: 0x0025A024
		' (set) Token: 0x060007DE RID: 2014 RVA: 0x0025AFD0 File Offset: 0x00259FD0
		Friend Overridable Property miSave As MenuItem
			Get
				Return Me._miSave
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miSave IsNot Nothing Then
					RemoveHandler Me._miSave.Click, AddressOf Me.miSave_Click
				End If
				Me._miSave = value
				If Me._miSave IsNot Nothing Then
					AddHandler Me._miSave.Click, AddressOf Me.miSave_Click
				End If
			End Set
		End Property

		' Token: 0x1700025D RID: 605
		' (get) Token: 0x060007E1 RID: 2017 RVA: 0x0025B054 File Offset: 0x0025A054
		' (set) Token: 0x060007E0 RID: 2016 RVA: 0x0025B038 File Offset: 0x0025A038
		Friend Overridable Property MenuItem3 As MenuItem
			Get
				Return Me._MenuItem3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem3 IsNot Nothing Then
				End If
				Me._MenuItem3 = value
				If Me._MenuItem3 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700025E RID: 606
		' (get) Token: 0x060007E2 RID: 2018 RVA: 0x0025B068 File Offset: 0x0025A068
		' (set) Token: 0x060007E3 RID: 2019 RVA: 0x0025B07C File Offset: 0x0025A07C
		Friend Overridable Property miClose As MenuItem
			Get
				Return Me._miClose
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miClose IsNot Nothing Then
					RemoveHandler Me._miClose.Click, AddressOf Me.miClose_Click
				End If
				Me._miClose = value
				If Me._miClose IsNot Nothing Then
					AddHandler Me._miClose.Click, AddressOf Me.miClose_Click
				End If
			End Set
		End Property

		' Token: 0x1700025F RID: 607
		' (get) Token: 0x060007E5 RID: 2021 RVA: 0x0025B0D0 File Offset: 0x0025A0D0
		' (set) Token: 0x060007E4 RID: 2020 RVA: 0x0025B0E4 File Offset: 0x0025A0E4
		Friend Overridable Property miShowHideModuleElements As MenuItem
			Get
				Return Me._miShowHideModuleElements
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miShowHideModuleElements IsNot Nothing Then
					RemoveHandler Me._miShowHideModuleElements.Click, AddressOf Me.miShowHideModuleElements_Click
				End If
				Me._miShowHideModuleElements = value
				If Me._miShowHideModuleElements IsNot Nothing Then
					AddHandler Me._miShowHideModuleElements.Click, AddressOf Me.miShowHideModuleElements_Click
				End If
			End Set
		End Property

		' Token: 0x17000260 RID: 608
		' (get) Token: 0x060007E6 RID: 2022 RVA: 0x0025B138 File Offset: 0x0025A138
		' (set) Token: 0x060007E7 RID: 2023 RVA: 0x0025B14C File Offset: 0x0025A14C
		Friend Overridable Property miShowHidePalette As MenuItem
			Get
				Return Me._miShowHidePalette
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miShowHidePalette IsNot Nothing Then
					RemoveHandler Me._miShowHidePalette.Click, AddressOf Me.miShowHidePalette_Click
				End If
				Me._miShowHidePalette = value
				If Me._miShowHidePalette IsNot Nothing Then
					AddHandler Me._miShowHidePalette.Click, AddressOf Me.miShowHidePalette_Click
				End If
			End Set
		End Property

		' Token: 0x17000261 RID: 609
		' (get) Token: 0x060007E8 RID: 2024 RVA: 0x0025B1A0 File Offset: 0x0025A1A0
		' (set) Token: 0x060007E9 RID: 2025 RVA: 0x0025B1B4 File Offset: 0x0025A1B4
		Friend Overridable Property MenuItem6 As MenuItem
			Get
				Return Me._MenuItem6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem6 IsNot Nothing Then
				End If
				Me._MenuItem6 = value
				If Me._MenuItem6 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000262 RID: 610
		' (get) Token: 0x060007EB RID: 2027 RVA: 0x0025B1D0 File Offset: 0x0025A1D0
		' (set) Token: 0x060007EA RID: 2026 RVA: 0x0025B1E4 File Offset: 0x0025A1E4
		Friend Overridable Property miShowModulePaths As MenuItem
			Get
				Return Me._miShowModulePaths
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miShowModulePaths IsNot Nothing Then
					RemoveHandler Me._miShowModulePaths.Click, AddressOf Me.miShowModulePaths_Click
				End If
				Me._miShowModulePaths = value
				If Me._miShowModulePaths IsNot Nothing Then
					AddHandler Me._miShowModulePaths.Click, AddressOf Me.miShowModulePaths_Click
				End If
			End Set
		End Property

		' Token: 0x17000263 RID: 611
		' (get) Token: 0x060007EC RID: 2028 RVA: 0x0025B238 File Offset: 0x0025A238
		' (set) Token: 0x060007ED RID: 2029 RVA: 0x0025B24C File Offset: 0x0025A24C
		Friend Overridable Property btnDebug As Button
			Get
				Return Me._btnDebug
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnDebug IsNot Nothing Then
					RemoveHandler Me._btnDebug.Click, AddressOf Me.btnDebug_Click
				End If
				Me._btnDebug = value
				If Me._btnDebug IsNot Nothing Then
					AddHandler Me._btnDebug.Click, AddressOf Me.btnDebug_Click
				End If
			End Set
		End Property

		' Token: 0x17000264 RID: 612
		' (get) Token: 0x060007EE RID: 2030 RVA: 0x0025B2BC File Offset: 0x0025A2BC
		' (set) Token: 0x060007EF RID: 2031 RVA: 0x0025B2A0 File Offset: 0x0025A2A0
		Friend Overridable Property MenuItem4 As MenuItem
			Get
				Return Me._MenuItem4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem4 IsNot Nothing Then
				End If
				Me._MenuItem4 = value
				If Me._MenuItem4 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000265 RID: 613
		' (get) Token: 0x060007F0 RID: 2032 RVA: 0x0025B324 File Offset: 0x0025A324
		' (set) Token: 0x060007F1 RID: 2033 RVA: 0x0025B2D0 File Offset: 0x0025A2D0
		Friend Overridable Property miOptions As MenuItem
			Get
				Return Me._miOptions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miOptions IsNot Nothing Then
					RemoveHandler Me._miOptions.Click, AddressOf Me.miOptions_Click
				End If
				Me._miOptions = value
				If Me._miOptions IsNot Nothing Then
					AddHandler Me._miOptions.Click, AddressOf Me.miOptions_Click
				End If
			End Set
		End Property

		' Token: 0x17000266 RID: 614
		' (get) Token: 0x060007F3 RID: 2035 RVA: 0x0025B338 File Offset: 0x0025A338
		' (set) Token: 0x060007F2 RID: 2034 RVA: 0x0025B34C File Offset: 0x0025A34C
		Friend Overridable Property tvUserPalette As TreeView
			Get
				Return Me._tvUserPalette
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				If Me._tvUserPalette IsNot Nothing Then
					RemoveHandler Me._tvUserPalette.ItemDrag, AddressOf Me.tvUserPalette_ItemDrag
				End If
				Me._tvUserPalette = value
				If Me._tvUserPalette IsNot Nothing Then
					AddHandler Me._tvUserPalette.ItemDrag, AddressOf Me.tvUserPalette_ItemDrag
				End If
			End Set
		End Property

		' Token: 0x17000267 RID: 615
		' (get) Token: 0x060007F5 RID: 2037 RVA: 0x0025B3A0 File Offset: 0x0025A3A0
		' (set) Token: 0x060007F4 RID: 2036 RVA: 0x0025B3B4 File Offset: 0x0025A3B4
		Friend Overridable Property TabPage1 As TabPage
			Get
				Return Me._TabPage1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				If Me._TabPage1 IsNot Nothing Then
				End If
				Me._TabPage1 = value
				If Me._TabPage1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000268 RID: 616
		' (get) Token: 0x060007F6 RID: 2038 RVA: 0x0025B3D0 File Offset: 0x0025A3D0
		' (set) Token: 0x060007F7 RID: 2039 RVA: 0x0025B3E4 File Offset: 0x0025A3E4
		Friend Overridable Property chkbShowNames As CheckBox
			Get
				Return Me._chkbShowNames
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				If Me._chkbShowNames IsNot Nothing Then
					RemoveHandler Me._chkbShowNames.CheckedChanged, AddressOf Me.chkbShowNames_CheckedChanged
				End If
				Me._chkbShowNames = value
				If Me._chkbShowNames IsNot Nothing Then
					AddHandler Me._chkbShowNames.CheckedChanged, AddressOf Me.chkbShowNames_CheckedChanged
				End If
			End Set
		End Property

		' Token: 0x17000269 RID: 617
		' (get) Token: 0x060007F9 RID: 2041 RVA: 0x0025B438 File Offset: 0x0025A438
		' (set) Token: 0x060007F8 RID: 2040 RVA: 0x0025B44C File Offset: 0x0025A44C
		Friend Overridable Property miRemoveFromOverride As MenuItem
			Get
				Return Me._miRemoveFromOverride
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miRemoveFromOverride IsNot Nothing Then
				End If
				Me._miRemoveFromOverride = value
				If Me._miRemoveFromOverride IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700026A RID: 618
		' (get) Token: 0x060007FA RID: 2042 RVA: 0x0025B468 File Offset: 0x0025A468
		' (set) Token: 0x060007FB RID: 2043 RVA: 0x0025B47C File Offset: 0x0025A47C
		Friend Overridable Property miCopyToOverride As MenuItem
			Get
				Return Me._miCopyToOverride
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miCopyToOverride IsNot Nothing Then
				End If
				Me._miCopyToOverride = value
				If Me._miCopyToOverride IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700026B RID: 619
		' (get) Token: 0x060007FD RID: 2045 RVA: 0x0025B4B4 File Offset: 0x0025A4B4
		' (set) Token: 0x060007FC RID: 2044 RVA: 0x0025B498 File Offset: 0x0025A498
		Friend Overridable Property miCleanOverride As MenuItem
			Get
				Return Me._miCleanOverride
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miCleanOverride IsNot Nothing Then
				End If
				Me._miCleanOverride = value
				If Me._miCleanOverride IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700026C RID: 620
		' (get) Token: 0x060007FF RID: 2047 RVA: 0x0025B4E4 File Offset: 0x0025A4E4
		' (set) Token: 0x060007FE RID: 2046 RVA: 0x0025B4C8 File Offset: 0x0025A4C8
		Friend Overridable Property MenuItem9 As MenuItem
			Get
				Return Me._MenuItem9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem9 IsNot Nothing Then
				End If
				Me._MenuItem9 = value
				If Me._MenuItem9 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700026D RID: 621
		' (get) Token: 0x06000801 RID: 2049 RVA: 0x0025B54C File Offset: 0x0025A54C
		' (set) Token: 0x06000800 RID: 2048 RVA: 0x0025B4F8 File Offset: 0x0025A4F8
		Friend Overridable Property cmiTvModuleItemEdit As MenuItem
			Get
				Return Me._cmiTvModuleItemEdit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiTvModuleItemEdit IsNot Nothing Then
					RemoveHandler Me._cmiTvModuleItemEdit.Click, AddressOf Me.cmiTvModuleItemEdit_Click
				End If
				Me._cmiTvModuleItemEdit = value
				If Me._cmiTvModuleItemEdit IsNot Nothing Then
					AddHandler Me._cmiTvModuleItemEdit.Click, AddressOf Me.cmiTvModuleItemEdit_Click
				End If
			End Set
		End Property

		' Token: 0x1700026E RID: 622
		' (get) Token: 0x06000803 RID: 2051 RVA: 0x0025B560 File Offset: 0x0025A560
		' (set) Token: 0x06000802 RID: 2050 RVA: 0x0025B574 File Offset: 0x0025A574
		Friend Overridable Property cmiTvModuleItemDelete As MenuItem
			Get
				Return Me._cmiTvModuleItemDelete
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiTvModuleItemDelete IsNot Nothing Then
					RemoveHandler Me._cmiTvModuleItemDelete.Click, AddressOf Me.cmiTvModuleItemDelete_Click
				End If
				Me._cmiTvModuleItemDelete = value
				If Me._cmiTvModuleItemDelete IsNot Nothing Then
					AddHandler Me._cmiTvModuleItemDelete.Click, AddressOf Me.cmiTvModuleItemDelete_Click
				End If
			End Set
		End Property

		' Token: 0x1700026F RID: 623
		' (get) Token: 0x06000805 RID: 2053 RVA: 0x0025B5E4 File Offset: 0x0025A5E4
		' (set) Token: 0x06000804 RID: 2052 RVA: 0x0025B5C8 File Offset: 0x0025A5C8
		Friend Overridable Property Label5 As Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label5 IsNot Nothing Then
				End If
				Me._Label5 = value
				If Me._Label5 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000270 RID: 624
		' (get) Token: 0x06000806 RID: 2054 RVA: 0x0025B614 File Offset: 0x0025A614
		' (set) Token: 0x06000807 RID: 2055 RVA: 0x0025B5F8 File Offset: 0x0025A5F8
		Friend Overridable Property tbHelp As TextBox
			Get
				Return Me._tbHelp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tbHelp IsNot Nothing Then
				End If
				Me._tbHelp = value
				If Me._tbHelp IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000271 RID: 625
		' (get) Token: 0x06000808 RID: 2056 RVA: 0x0025B644 File Offset: 0x0025A644
		' (set) Token: 0x06000809 RID: 2057 RVA: 0x0025B628 File Offset: 0x0025A628
		Friend Overridable Property tabpagUserPalette As TabPage
			Get
				Return Me._tabpagUserPalette
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				If Me._tabpagUserPalette IsNot Nothing Then
				End If
				Me._tabpagUserPalette = value
				If Me._tabpagUserPalette IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000272 RID: 626
		' (get) Token: 0x0600080A RID: 2058 RVA: 0x0025B658 File Offset: 0x0025A658
		' (set) Token: 0x0600080B RID: 2059 RVA: 0x0025B66C File Offset: 0x0025A66C
		Friend Overridable Property tabctrlPalette As TabControl
			Get
				Return Me._tabctrlPalette
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				If Me._tabctrlPalette IsNot Nothing Then
					RemoveHandler Me._tabctrlPalette.SelectedIndexChanged, AddressOf Me.TabControl1_SelectedIndexChanged
				End If
				Me._tabctrlPalette = value
				If Me._tabctrlPalette IsNot Nothing Then
					AddHandler Me._tabctrlPalette.SelectedIndexChanged, AddressOf Me.TabControl1_SelectedIndexChanged
				End If
			End Set
		End Property

		' Token: 0x17000273 RID: 627
		' (get) Token: 0x0600080C RID: 2060 RVA: 0x0025B6C0 File Offset: 0x0025A6C0
		' (set) Token: 0x0600080D RID: 2061 RVA: 0x0025B6D4 File Offset: 0x0025A6D4
		Friend Overridable Property MenuItem7 As MenuItem
			Get
				Return Me._MenuItem7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem7 IsNot Nothing Then
				End If
				Me._MenuItem7 = value
				If Me._MenuItem7 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000274 RID: 628
		' (get) Token: 0x0600080F RID: 2063 RVA: 0x0025B6F0 File Offset: 0x0025A6F0
		' (set) Token: 0x0600080E RID: 2062 RVA: 0x0025B704 File Offset: 0x0025A704
		Friend Overridable Property miOpenProject As MenuItem
			Get
				Return Me._miOpenProject
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miOpenProject IsNot Nothing Then
					RemoveHandler Me._miOpenProject.Click, AddressOf Me.miOpenProject_Click
				End If
				Me._miOpenProject = value
				If Me._miOpenProject IsNot Nothing Then
					AddHandler Me._miOpenProject.Click, AddressOf Me.miOpenProject_Click
				End If
			End Set
		End Property

		' Token: 0x17000275 RID: 629
		' (get) Token: 0x06000811 RID: 2065 RVA: 0x0025B758 File Offset: 0x0025A758
		' (set) Token: 0x06000810 RID: 2064 RVA: 0x0025B76C File Offset: 0x0025A76C
		Friend Overridable Property tabpagModuleElements As TabPage
			Get
				Return Me._tabpagModuleElements
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				If Me._tabpagModuleElements IsNot Nothing Then
				End If
				Me._tabpagModuleElements = value
				If Me._tabpagModuleElements IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000276 RID: 630
		' (get) Token: 0x06000812 RID: 2066 RVA: 0x0025B7A4 File Offset: 0x0025A7A4
		' (set) Token: 0x06000813 RID: 2067 RVA: 0x0025B788 File Offset: 0x0025A788
		Friend Overridable Property tabpagScripts As TabPage
			Get
				Return Me._tabpagScripts
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				If Me._tabpagScripts IsNot Nothing Then
				End If
				Me._tabpagScripts = value
				If Me._tabpagScripts IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000277 RID: 631
		' (get) Token: 0x06000815 RID: 2069 RVA: 0x0025B7B8 File Offset: 0x0025A7B8
		' (set) Token: 0x06000814 RID: 2068 RVA: 0x0025B7CC File Offset: 0x0025A7CC
		Friend Overridable Property tabctrlModule As TabControl
			Get
				Return Me._tabctrlModule
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				If Me._tabctrlModule IsNot Nothing Then
				End If
				Me._tabctrlModule = value
				If Me._tabctrlModule IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000278 RID: 632
		' (get) Token: 0x06000817 RID: 2071 RVA: 0x0025B7E8 File Offset: 0x0025A7E8
		' (set) Token: 0x06000816 RID: 2070 RVA: 0x0025B7FC File Offset: 0x0025A7FC
		Friend Overridable Property mnuView As MenuItem
			Get
				Return Me._mnuView
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._mnuView IsNot Nothing Then
				End If
				Me._mnuView = value
				If Me._mnuView IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000279 RID: 633
		' (get) Token: 0x06000818 RID: 2072 RVA: 0x0025B818 File Offset: 0x0025A818
		' (set) Token: 0x06000819 RID: 2073 RVA: 0x0025B82C File Offset: 0x0025A82C
		Friend Overridable Property miExploreModuleFolder As MenuItem
			Get
				Return Me._miExploreModuleFolder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miExploreModuleFolder IsNot Nothing Then
					RemoveHandler Me._miExploreModuleFolder.Click, AddressOf Me.miExploreModuleFolder_Click
				End If
				Me._miExploreModuleFolder = value
				If Me._miExploreModuleFolder IsNot Nothing Then
					AddHandler Me._miExploreModuleFolder.Click, AddressOf Me.miExploreModuleFolder_Click
				End If
			End Set
		End Property

		' Token: 0x1700027A RID: 634
		' (get) Token: 0x0600081B RID: 2075 RVA: 0x0025B880 File Offset: 0x0025A880
		' (set) Token: 0x0600081A RID: 2074 RVA: 0x0025B894 File Offset: 0x0025A894
		Friend Overridable Property miBuildModFile As MenuItem
			Get
				Return Me._miBuildModFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miBuildModFile IsNot Nothing Then
					RemoveHandler Me._miBuildModFile.Click, AddressOf Me.miBuildModFile_Click
				End If
				Me._miBuildModFile = value
				If Me._miBuildModFile IsNot Nothing Then
					AddHandler Me._miBuildModFile.Click, AddressOf Me.miBuildModFile_Click
				End If
			End Set
		End Property

		' Token: 0x1700027B RID: 635
		' (get) Token: 0x0600081D RID: 2077 RVA: 0x0025B8E8 File Offset: 0x0025A8E8
		' (set) Token: 0x0600081C RID: 2076 RVA: 0x0025B8FC File Offset: 0x0025A8FC
		Friend Overridable Property chkbUseFactors As CheckBox
			Get
				Return Me._chkbUseFactors
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				If Me._chkbUseFactors IsNot Nothing Then
				End If
				Me._chkbUseFactors = value
				If Me._chkbUseFactors IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700027C RID: 636
		' (get) Token: 0x0600081F RID: 2079 RVA: 0x0025B918 File Offset: 0x0025A918
		' (set) Token: 0x0600081E RID: 2078 RVA: 0x0025B92C File Offset: 0x0025A92C
		Friend Overridable Property MenuItem5 As MenuItem
			Get
				Return Me._MenuItem5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem5 IsNot Nothing Then
				End If
				Me._MenuItem5 = value
				If Me._MenuItem5 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700027D RID: 637
		' (get) Token: 0x06000820 RID: 2080 RVA: 0x0025B964 File Offset: 0x0025A964
		' (set) Token: 0x06000821 RID: 2081 RVA: 0x0025B948 File Offset: 0x0025A948
		Friend Overridable Property MenuItem2 As MenuItem
			Get
				Return Me._MenuItem2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem2 IsNot Nothing Then
				End If
				Me._MenuItem2 = value
				If Me._MenuItem2 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700027E RID: 638
		' (get) Token: 0x06000822 RID: 2082 RVA: 0x0025B978 File Offset: 0x0025A978
		' (set) Token: 0x06000823 RID: 2083 RVA: 0x0025B98C File Offset: 0x0025A98C
		Friend Overridable Property miModuleProperties As MenuItem
			Get
				Return Me._miModuleProperties
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miModuleProperties IsNot Nothing Then
					RemoveHandler Me._miModuleProperties.Click, AddressOf Me.miModuleProperties_Click
				End If
				Me._miModuleProperties = value
				If Me._miModuleProperties IsNot Nothing Then
					AddHandler Me._miModuleProperties.Click, AddressOf Me.miModuleProperties_Click
				End If
			End Set
		End Property

		' Token: 0x1700027F RID: 639
		' (get) Token: 0x06000825 RID: 2085 RVA: 0x0025B9E0 File Offset: 0x0025A9E0
		' (set) Token: 0x06000824 RID: 2084 RVA: 0x0025B9F4 File Offset: 0x0025A9F4
		Friend Overridable Property miShowGitDump As MenuItem
			Get
				Return Me._miShowGitDump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miShowGitDump IsNot Nothing Then
					RemoveHandler Me._miShowGitDump.Click, AddressOf Me.miShowGffDump_Click
				End If
				Me._miShowGitDump = value
				If Me._miShowGitDump IsNot Nothing Then
					AddHandler Me._miShowGitDump.Click, AddressOf Me.miShowGffDump_Click
				End If
			End Set
		End Property

		' Token: 0x17000280 RID: 640
		' (get) Token: 0x06000827 RID: 2087 RVA: 0x0025BA48 File Offset: 0x0025AA48
		' (set) Token: 0x06000826 RID: 2086 RVA: 0x0025BA5C File Offset: 0x0025AA5C
		Friend Overridable Property miShowAreDump As MenuItem
			Get
				Return Me._miShowAreDump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miShowAreDump IsNot Nothing Then
					RemoveHandler Me._miShowAreDump.Click, AddressOf Me.miShowGffDump_Click
				End If
				Me._miShowAreDump = value
				If Me._miShowAreDump IsNot Nothing Then
					AddHandler Me._miShowAreDump.Click, AddressOf Me.miShowGffDump_Click
				End If
			End Set
		End Property

		' Token: 0x17000281 RID: 641
		' (get) Token: 0x06000828 RID: 2088 RVA: 0x0025BAB0 File Offset: 0x0025AAB0
		' (set) Token: 0x06000829 RID: 2089 RVA: 0x0025BAC4 File Offset: 0x0025AAC4
		Friend Overridable Property miShowIfoDump As MenuItem
			Get
				Return Me._miShowIfoDump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miShowIfoDump IsNot Nothing Then
					RemoveHandler Me._miShowIfoDump.Click, AddressOf Me.miShowGffDump_Click
				End If
				Me._miShowIfoDump = value
				If Me._miShowIfoDump IsNot Nothing Then
					AddHandler Me._miShowIfoDump.Click, AddressOf Me.miShowGffDump_Click
				End If
			End Set
		End Property

		' Token: 0x17000282 RID: 642
		' (get) Token: 0x0600082A RID: 2090 RVA: 0x0025BB34 File Offset: 0x0025AB34
		' (set) Token: 0x0600082B RID: 2091 RVA: 0x0025BB18 File Offset: 0x0025AB18
		Friend Overridable Property sbar As StatusBar
			Get
				Return Me._sbar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBar)
				If Me._sbar IsNot Nothing Then
				End If
				Me._sbar = value
				If Me._sbar IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000283 RID: 643
		' (get) Token: 0x0600082D RID: 2093 RVA: 0x0025BB48 File Offset: 0x0025AB48
		' (set) Token: 0x0600082C RID: 2092 RVA: 0x0025BB5C File Offset: 0x0025AB5C
		Friend Overridable Property sbarpnlLocX As StatusBarPanel
			Get
				Return Me._sbarpnlLocX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				If Me._sbarpnlLocX IsNot Nothing Then
				End If
				Me._sbarpnlLocX = value
				If Me._sbarpnlLocX IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000284 RID: 644
		' (get) Token: 0x0600082E RID: 2094 RVA: 0x0025BB78 File Offset: 0x0025AB78
		' (set) Token: 0x0600082F RID: 2095 RVA: 0x0025BB8C File Offset: 0x0025AB8C
		Friend Overridable Property sbarpnlLocY As StatusBarPanel
			Get
				Return Me._sbarpnlLocY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				If Me._sbarpnlLocY IsNot Nothing Then
				End If
				Me._sbarpnlLocY = value
				If Me._sbarpnlLocY IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000285 RID: 645
		' (get) Token: 0x06000830 RID: 2096 RVA: 0x0025BBC4 File Offset: 0x0025ABC4
		' (set) Token: 0x06000831 RID: 2097 RVA: 0x0025BBA8 File Offset: 0x0025ABA8
		Friend Overridable Property sbarpnlDesc As StatusBarPanel
			Get
				Return Me._sbarpnlDesc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				If Me._sbarpnlDesc IsNot Nothing Then
				End If
				Me._sbarpnlDesc = value
				If Me._sbarpnlDesc IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000286 RID: 646
		' (get) Token: 0x06000832 RID: 2098 RVA: 0x0025BBF4 File Offset: 0x0025ABF4
		' (set) Token: 0x06000833 RID: 2099 RVA: 0x0025BBD8 File Offset: 0x0025ABD8
		Friend Overridable Property sbarpnlAddlInfo As StatusBarPanel
			Get
				Return Me._sbarpnlAddlInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				If Me._sbarpnlAddlInfo IsNot Nothing Then
				End If
				Me._sbarpnlAddlInfo = value
				If Me._sbarpnlAddlInfo IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000287 RID: 647
		' (get) Token: 0x06000834 RID: 2100 RVA: 0x0025BC24 File Offset: 0x0025AC24
		' (set) Token: 0x06000835 RID: 2101 RVA: 0x0025BC08 File Offset: 0x0025AC08
		Friend Overridable Property sbarpnlStatus As StatusBarPanel
			Get
				Return Me._sbarpnlStatus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				If Me._sbarpnlStatus IsNot Nothing Then
				End If
				Me._sbarpnlStatus = value
				If Me._sbarpnlStatus IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000288 RID: 648
		' (get) Token: 0x06000836 RID: 2102 RVA: 0x0025BC8C File Offset: 0x0025AC8C
		' (set) Token: 0x06000837 RID: 2103 RVA: 0x0025BC38 File Offset: 0x0025AC38
		Friend Overridable Property ToolBarModElementsFilter As ToolBar
			Get
				Return Me._ToolBarModElementsFilter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				If Me._ToolBarModElementsFilter IsNot Nothing Then
					RemoveHandler Me._ToolBarModElementsFilter.ButtonClick, AddressOf Me.ToolBarModElementsFilter_ButtonClick
				End If
				Me._ToolBarModElementsFilter = value
				If Me._ToolBarModElementsFilter IsNot Nothing Then
					AddHandler Me._ToolBarModElementsFilter.ButtonClick, AddressOf Me.ToolBarModElementsFilter_ButtonClick
				End If
			End Set
		End Property

		' Token: 0x17000289 RID: 649
		' (get) Token: 0x06000838 RID: 2104 RVA: 0x0025BCA0 File Offset: 0x0025ACA0
		' (set) Token: 0x06000839 RID: 2105 RVA: 0x0025BCB4 File Offset: 0x0025ACB4
		Friend Overridable Property tbarbtnCreature As ToolBarButton
			Get
				Return Me._tbarbtnCreature
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				If Me._tbarbtnCreature IsNot Nothing Then
				End If
				Me._tbarbtnCreature = value
				If Me._tbarbtnCreature IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700028A RID: 650
		' (get) Token: 0x0600083A RID: 2106 RVA: 0x0025BCEC File Offset: 0x0025ACEC
		' (set) Token: 0x0600083B RID: 2107 RVA: 0x0025BCD0 File Offset: 0x0025ACD0
		Friend Overridable Property tbarbtnDoor As ToolBarButton
			Get
				Return Me._tbarbtnDoor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				If Me._tbarbtnDoor IsNot Nothing Then
				End If
				Me._tbarbtnDoor = value
				If Me._tbarbtnDoor IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700028B RID: 651
		' (get) Token: 0x0600083C RID: 2108 RVA: 0x0025BD00 File Offset: 0x0025AD00
		' (set) Token: 0x0600083D RID: 2109 RVA: 0x0025BD14 File Offset: 0x0025AD14
		Friend Overridable Property tbarbtnEncounter As ToolBarButton
			Get
				Return Me._tbarbtnEncounter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				If Me._tbarbtnEncounter IsNot Nothing Then
				End If
				Me._tbarbtnEncounter = value
				If Me._tbarbtnEncounter IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700028C RID: 652
		' (get) Token: 0x0600083E RID: 2110 RVA: 0x0025BD4C File Offset: 0x0025AD4C
		' (set) Token: 0x0600083F RID: 2111 RVA: 0x0025BD30 File Offset: 0x0025AD30
		Friend Overridable Property tbarbtnMerchant As ToolBarButton
			Get
				Return Me._tbarbtnMerchant
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				If Me._tbarbtnMerchant IsNot Nothing Then
				End If
				Me._tbarbtnMerchant = value
				If Me._tbarbtnMerchant IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700028D RID: 653
		' (get) Token: 0x06000840 RID: 2112 RVA: 0x0025BD60 File Offset: 0x0025AD60
		' (set) Token: 0x06000841 RID: 2113 RVA: 0x0025BD74 File Offset: 0x0025AD74
		Friend Overridable Property tbarbtnPlaceable As ToolBarButton
			Get
				Return Me._tbarbtnPlaceable
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				If Me._tbarbtnPlaceable IsNot Nothing Then
				End If
				Me._tbarbtnPlaceable = value
				If Me._tbarbtnPlaceable IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700028E RID: 654
		' (get) Token: 0x06000842 RID: 2114 RVA: 0x0025BDAC File Offset: 0x0025ADAC
		' (set) Token: 0x06000843 RID: 2115 RVA: 0x0025BD90 File Offset: 0x0025AD90
		Friend Overridable Property tbarbtnSound As ToolBarButton
			Get
				Return Me._tbarbtnSound
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				If Me._tbarbtnSound IsNot Nothing Then
				End If
				Me._tbarbtnSound = value
				If Me._tbarbtnSound IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700028F RID: 655
		' (get) Token: 0x06000844 RID: 2116 RVA: 0x0025BDC0 File Offset: 0x0025ADC0
		' (set) Token: 0x06000845 RID: 2117 RVA: 0x0025BDD4 File Offset: 0x0025ADD4
		Friend Overridable Property tbarbtnTrigger As ToolBarButton
			Get
				Return Me._tbarbtnTrigger
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				If Me._tbarbtnTrigger IsNot Nothing Then
				End If
				Me._tbarbtnTrigger = value
				If Me._tbarbtnTrigger IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000290 RID: 656
		' (get) Token: 0x06000847 RID: 2119 RVA: 0x0025BDF0 File Offset: 0x0025ADF0
		' (set) Token: 0x06000846 RID: 2118 RVA: 0x0025BE04 File Offset: 0x0025AE04
		Friend Overridable Property tbarbtnWaypoint As ToolBarButton
			Get
				Return Me._tbarbtnWaypoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				If Me._tbarbtnWaypoint IsNot Nothing Then
				End If
				Me._tbarbtnWaypoint = value
				If Me._tbarbtnWaypoint IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000291 RID: 657
		' (get) Token: 0x06000848 RID: 2120 RVA: 0x0025BE3C File Offset: 0x0025AE3C
		' (set) Token: 0x06000849 RID: 2121 RVA: 0x0025BE20 File Offset: 0x0025AE20
		Friend Overridable Property ilModElementsFilter As ImageList
			Get
				Return Me._ilModElementsFilter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				If Me._ilModElementsFilter IsNot Nothing Then
				End If
				Me._ilModElementsFilter = value
				If Me._ilModElementsFilter IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000292 RID: 658
		' (get) Token: 0x0600084A RID: 2122 RVA: 0x0025BEA4 File Offset: 0x0025AEA4
		' (set) Token: 0x0600084B RID: 2123 RVA: 0x0025BE50 File Offset: 0x0025AE50
		Friend Overridable Property miUseLargeMap As MenuItem
			Get
				Return Me._miUseLargeMap
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miUseLargeMap IsNot Nothing Then
					RemoveHandler Me._miUseLargeMap.Click, AddressOf Me.miUseLargeMap_Click
				End If
				Me._miUseLargeMap = value
				If Me._miUseLargeMap IsNot Nothing Then
					AddHandler Me._miUseLargeMap.Click, AddressOf Me.miUseLargeMap_Click
				End If
			End Set
		End Property

		' Token: 0x17000293 RID: 659
		' (get) Token: 0x0600084C RID: 2124 RVA: 0x0025BF0C File Offset: 0x0025AF0C
		' (set) Token: 0x0600084D RID: 2125 RVA: 0x0025BEB8 File Offset: 0x0025AEB8
		Friend Overridable Property miUseSmallMap As MenuItem
			Get
				Return Me._miUseSmallMap
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miUseSmallMap IsNot Nothing Then
					RemoveHandler Me._miUseSmallMap.Click, AddressOf Me.miUseSmallMap_Click
				End If
				Me._miUseSmallMap = value
				If Me._miUseSmallMap IsNot Nothing Then
					AddHandler Me._miUseSmallMap.Click, AddressOf Me.miUseSmallMap_Click
				End If
			End Set
		End Property

		' Token: 0x17000294 RID: 660
		' (get) Token: 0x0600084E RID: 2126 RVA: 0x0025BF20 File Offset: 0x0025AF20
		' (set) Token: 0x0600084F RID: 2127 RVA: 0x0025BF34 File Offset: 0x0025AF34
		Friend Overridable Property MenuItem11 As MenuItem
			Get
				Return Me._MenuItem11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem11 IsNot Nothing Then
				End If
				Me._MenuItem11 = value
				If Me._MenuItem11 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000295 RID: 661
		' (get) Token: 0x06000850 RID: 2128 RVA: 0x0025BF50 File Offset: 0x0025AF50
		' (set) Token: 0x06000851 RID: 2129 RVA: 0x0025BF64 File Offset: 0x0025AF64
		Friend Overridable Property miShowItemLabels As MenuItem
			Get
				Return Me._miShowItemLabels
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miShowItemLabels IsNot Nothing Then
					RemoveHandler Me._miShowItemLabels.Click, AddressOf Me.miShowItemLabels_Click
				End If
				Me._miShowItemLabels = value
				If Me._miShowItemLabels IsNot Nothing Then
					AddHandler Me._miShowItemLabels.Click, AddressOf Me.miShowItemLabels_Click
				End If
			End Set
		End Property

		' Token: 0x17000296 RID: 662
		' (get) Token: 0x06000853 RID: 2131 RVA: 0x0025BFB8 File Offset: 0x0025AFB8
		' (set) Token: 0x06000852 RID: 2130 RVA: 0x0025BFCC File Offset: 0x0025AFCC
		Friend Overridable Property cmPbox As ContextMenu
			Get
				Return Me._cmPbox
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				If Me._cmPbox IsNot Nothing Then
				End If
				Me._cmPbox = value
				If Me._cmPbox IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000297 RID: 663
		' (get) Token: 0x06000855 RID: 2133 RVA: 0x0025BFE8 File Offset: 0x0025AFE8
		' (set) Token: 0x06000854 RID: 2132 RVA: 0x0025BFFC File Offset: 0x0025AFFC
		Friend Overridable Property cmiModuleProperties As MenuItem
			Get
				Return Me._cmiModuleProperties
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiModuleProperties IsNot Nothing Then
					RemoveHandler Me._cmiModuleProperties.Click, AddressOf Me.cmiModuleProperties_Click
				End If
				Me._cmiModuleProperties = value
				If Me._cmiModuleProperties IsNot Nothing Then
					AddHandler Me._cmiModuleProperties.Click, AddressOf Me.cmiModuleProperties_Click
				End If
			End Set
		End Property

		' Token: 0x17000298 RID: 664
		' (get) Token: 0x06000856 RID: 2134 RVA: 0x0025C0A4 File Offset: 0x0025B0A4
		' (set) Token: 0x06000857 RID: 2135 RVA: 0x0025C050 File Offset: 0x0025B050
		Friend Overridable Property cmiCreateCameraHere As MenuItem
			Get
				Return Me._cmiCreateCameraHere
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiCreateCameraHere IsNot Nothing Then
					RemoveHandler Me._cmiCreateCameraHere.Click, AddressOf Me.cmiCreateCameraHere_Click
				End If
				Me._cmiCreateCameraHere = value
				If Me._cmiCreateCameraHere IsNot Nothing Then
					AddHandler Me._cmiCreateCameraHere.Click, AddressOf Me.cmiCreateCameraHere_Click
				End If
			End Set
		End Property

		' Token: 0x17000299 RID: 665
		' (get) Token: 0x06000858 RID: 2136 RVA: 0x0025C0B8 File Offset: 0x0025B0B8
		' (set) Token: 0x06000859 RID: 2137 RVA: 0x0025C0CC File Offset: 0x0025B0CC
		Friend Overridable Property cmiSetModuleStartPoint As MenuItem
			Get
				Return Me._cmiSetModuleStartPoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiSetModuleStartPoint IsNot Nothing Then
					RemoveHandler Me._cmiSetModuleStartPoint.Click, AddressOf Me.cmiSetModuleStartPoint_Click
				End If
				Me._cmiSetModuleStartPoint = value
				If Me._cmiSetModuleStartPoint IsNot Nothing Then
					AddHandler Me._cmiSetModuleStartPoint.Click, AddressOf Me.cmiSetModuleStartPoint_Click
				End If
			End Set
		End Property

		' Token: 0x1700029A RID: 666
		' (get) Token: 0x0600085A RID: 2138 RVA: 0x0025C120 File Offset: 0x0025B120
		' (set) Token: 0x0600085B RID: 2139 RVA: 0x0025C134 File Offset: 0x0025B134
		Friend Overridable Property MenuItem13 As MenuItem
			Get
				Return Me._MenuItem13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem13 IsNot Nothing Then
				End If
				Me._MenuItem13 = value
				If Me._MenuItem13 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700029B RID: 667
		' (get) Token: 0x0600085C RID: 2140 RVA: 0x0025C150 File Offset: 0x0025B150
		' (set) Token: 0x0600085D RID: 2141 RVA: 0x0025C164 File Offset: 0x0025B164
		Friend Overridable Property chkbShowTags As CheckBox
			Get
				Return Me._chkbShowTags
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				If Me._chkbShowTags IsNot Nothing Then
				End If
				Me._chkbShowTags = value
				If Me._chkbShowTags IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700029C RID: 668
		' (get) Token: 0x0600085E RID: 2142 RVA: 0x0025C180 File Offset: 0x0025B180
		' (set) Token: 0x0600085F RID: 2143 RVA: 0x0025C194 File Offset: 0x0025B194
		Friend Overridable Property btnTweakUp As RepeatButton
			Get
				Return Me._btnTweakUp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RepeatButton)
				If Me._btnTweakUp IsNot Nothing Then
					RemoveHandler Me._btnTweakUp.Click, AddressOf Me.btnTweakUp_Click
				End If
				Me._btnTweakUp = value
				If Me._btnTweakUp IsNot Nothing Then
					AddHandler Me._btnTweakUp.Click, AddressOf Me.btnTweakUp_Click
				End If
			End Set
		End Property

		' Token: 0x1700029D RID: 669
		' (get) Token: 0x06000861 RID: 2145 RVA: 0x0025C1E8 File Offset: 0x0025B1E8
		' (set) Token: 0x06000860 RID: 2144 RVA: 0x0025C1FC File Offset: 0x0025B1FC
		Friend Overridable Property btnTweakLeft As RepeatButton
			Get
				Return Me._btnTweakLeft
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RepeatButton)
				If Me._btnTweakLeft IsNot Nothing Then
					RemoveHandler Me._btnTweakLeft.Click, AddressOf Me.btnTweakLeft_Click
				End If
				Me._btnTweakLeft = value
				If Me._btnTweakLeft IsNot Nothing Then
					AddHandler Me._btnTweakLeft.Click, AddressOf Me.btnTweakLeft_Click
				End If
			End Set
		End Property

		' Token: 0x1700029E RID: 670
		' (get) Token: 0x06000862 RID: 2146 RVA: 0x0025C2A4 File Offset: 0x0025B2A4
		' (set) Token: 0x06000863 RID: 2147 RVA: 0x0025C250 File Offset: 0x0025B250
		Friend Overridable Property btnTweakRight As RepeatButton
			Get
				Return Me._btnTweakRight
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RepeatButton)
				If Me._btnTweakRight IsNot Nothing Then
					RemoveHandler Me._btnTweakRight.Click, AddressOf Me.btnTweakRight_Click
				End If
				Me._btnTweakRight = value
				If Me._btnTweakRight IsNot Nothing Then
					AddHandler Me._btnTweakRight.Click, AddressOf Me.btnTweakRight_Click
				End If
			End Set
		End Property

		' Token: 0x1700029F RID: 671
		' (get) Token: 0x06000864 RID: 2148 RVA: 0x0025C2B8 File Offset: 0x0025B2B8
		' (set) Token: 0x06000865 RID: 2149 RVA: 0x0025C2CC File Offset: 0x0025B2CC
		Friend Overridable Property btnTweakDown As RepeatButton
			Get
				Return Me._btnTweakDown
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RepeatButton)
				If Me._btnTweakDown IsNot Nothing Then
					RemoveHandler Me._btnTweakDown.Click, AddressOf Me.btnTweakDown_Click
				End If
				Me._btnTweakDown = value
				If Me._btnTweakDown IsNot Nothing Then
					AddHandler Me._btnTweakDown.Click, AddressOf Me.btnTweakDown_Click
				End If
			End Set
		End Property

		' Token: 0x170002A0 RID: 672
		' (get) Token: 0x06000866 RID: 2150 RVA: 0x0025C320 File Offset: 0x0025B320
		' (set) Token: 0x06000867 RID: 2151 RVA: 0x0025C334 File Offset: 0x0025B334
		Friend Overridable Property cmMapSurfaceItems As ContextMenu
			Get
				Return Me._cmMapSurfaceItems
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				If Me._cmMapSurfaceItems IsNot Nothing Then
				End If
				Me._cmMapSurfaceItems = value
				If Me._cmMapSurfaceItems IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170002A1 RID: 673
		' (get) Token: 0x06000869 RID: 2153 RVA: 0x0025C3A4 File Offset: 0x0025B3A4
		' (set) Token: 0x06000868 RID: 2152 RVA: 0x0025C350 File Offset: 0x0025B350
		Friend Overridable Property cmiProperties As MenuItem
			Get
				Return Me._cmiProperties
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiProperties IsNot Nothing Then
					RemoveHandler Me._cmiProperties.Click, AddressOf Me.cmiProperties_Click
				End If
				Me._cmiProperties = value
				If Me._cmiProperties IsNot Nothing Then
					AddHandler Me._cmiProperties.Click, AddressOf Me.cmiProperties_Click
				End If
			End Set
		End Property

		' Token: 0x170002A2 RID: 674
		' (get) Token: 0x0600086A RID: 2154 RVA: 0x0025C3B8 File Offset: 0x0025B3B8
		' (set) Token: 0x0600086B RID: 2155 RVA: 0x0025C3CC File Offset: 0x0025B3CC
		Friend Overridable Property cmiDelete As MenuItem
			Get
				Return Me._cmiDelete
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiDelete IsNot Nothing Then
					RemoveHandler Me._cmiDelete.Click, AddressOf Me.cmiDelete_Click
				End If
				Me._cmiDelete = value
				If Me._cmiDelete IsNot Nothing Then
					AddHandler Me._cmiDelete.Click, AddressOf Me.cmiDelete_Click
				End If
			End Set
		End Property

		' Token: 0x170002A3 RID: 675
		' (get) Token: 0x0600086C RID: 2156 RVA: 0x0025C420 File Offset: 0x0025B420
		' (set) Token: 0x0600086D RID: 2157 RVA: 0x0025C434 File Offset: 0x0025B434
		Friend Overridable Property cmiEditGFFFile As MenuItem
			Get
				Return Me._cmiEditGFFFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiEditGFFFile IsNot Nothing Then
					RemoveHandler Me._cmiEditGFFFile.Click, AddressOf Me.cmiEdit_Click
				End If
				Me._cmiEditGFFFile = value
				If Me._cmiEditGFFFile IsNot Nothing Then
					AddHandler Me._cmiEditGFFFile.Click, AddressOf Me.cmiEdit_Click
				End If
			End Set
		End Property

		' Token: 0x170002A4 RID: 676
		' (get) Token: 0x0600086E RID: 2158 RVA: 0x0025C488 File Offset: 0x0025B488
		' (set) Token: 0x0600086F RID: 2159 RVA: 0x0025C49C File Offset: 0x0025B49C
		Friend Overridable Property cmiAddNewSpawnPoint As MenuItem
			Get
				Return Me._cmiAddNewSpawnPoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._cmiAddNewSpawnPoint IsNot Nothing Then
					RemoveHandler Me._cmiAddNewSpawnPoint.Click, AddressOf Me.cmiAddNewSpawnPoint_Click
				End If
				Me._cmiAddNewSpawnPoint = value
				If Me._cmiAddNewSpawnPoint IsNot Nothing Then
					AddHandler Me._cmiAddNewSpawnPoint.Click, AddressOf Me.cmiAddNewSpawnPoint_Click
				End If
			End Set
		End Property

		' Token: 0x170002A5 RID: 677
		' (get) Token: 0x06000871 RID: 2161 RVA: 0x0025C4F0 File Offset: 0x0025B4F0
		' (set) Token: 0x06000870 RID: 2160 RVA: 0x0025C504 File Offset: 0x0025B504
		Friend Overridable Property miShowModuleEntryPoint As MenuItem
			Get
				Return Me._miShowModuleEntryPoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miShowModuleEntryPoint IsNot Nothing Then
					RemoveHandler Me._miShowModuleEntryPoint.Click, AddressOf Me.miShowModuleEntryPoint_Click
				End If
				Me._miShowModuleEntryPoint = value
				If Me._miShowModuleEntryPoint IsNot Nothing Then
					AddHandler Me._miShowModuleEntryPoint.Click, AddressOf Me.miShowModuleEntryPoint_Click
				End If
			End Set
		End Property

		' Token: 0x170002A6 RID: 678
		' (get) Token: 0x06000873 RID: 2163 RVA: 0x0025C5AC File Offset: 0x0025B5AC
		' (set) Token: 0x06000872 RID: 2162 RVA: 0x0025C558 File Offset: 0x0025B558
		Friend Overridable Property lbScripts As ListBox
			Get
				Return Me._lbScripts
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				If Me._lbScripts IsNot Nothing Then
					RemoveHandler Me._lbScripts.DoubleClick, AddressOf Me.lbScripts_DoubleClick
				End If
				Me._lbScripts = value
				If Me._lbScripts IsNot Nothing Then
					AddHandler Me._lbScripts.DoubleClick, AddressOf Me.lbScripts_DoubleClick
				End If
			End Set
		End Property

		' Token: 0x170002A7 RID: 679
		' (get) Token: 0x06000874 RID: 2164 RVA: 0x0025C5DC File Offset: 0x0025B5DC
		' (set) Token: 0x06000875 RID: 2165 RVA: 0x0025C5C0 File Offset: 0x0025B5C0
		Friend Overridable Property tabpagDialogs As TabPage
			Get
				Return Me._tabpagDialogs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				If Me._tabpagDialogs IsNot Nothing Then
				End If
				Me._tabpagDialogs = value
				If Me._tabpagDialogs IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170002A8 RID: 680
		' (get) Token: 0x06000877 RID: 2167 RVA: 0x0025C644 File Offset: 0x0025B644
		' (set) Token: 0x06000876 RID: 2166 RVA: 0x0025C5F0 File Offset: 0x0025B5F0
		Friend Overridable Property lbDialogs As ListBox
			Get
				Return Me._lbDialogs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				If Me._lbDialogs IsNot Nothing Then
					RemoveHandler Me._lbDialogs.DoubleClick, AddressOf Me.lbDialogs_DoubleClick
				End If
				Me._lbDialogs = value
				If Me._lbDialogs IsNot Nothing Then
					AddHandler Me._lbDialogs.DoubleClick, AddressOf Me.lbDialogs_DoubleClick
				End If
			End Set
		End Property

		' Token: 0x170002A9 RID: 681
		' (get) Token: 0x06000879 RID: 2169 RVA: 0x0025C658 File Offset: 0x0025B658
		' (set) Token: 0x06000878 RID: 2168 RVA: 0x0025C66C File Offset: 0x0025B66C
		Friend Overridable Property tbMouseX As TextBox
			Get
				Return Me._tbMouseX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tbMouseX IsNot Nothing Then
				End If
				Me._tbMouseX = value
				If Me._tbMouseX IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170002AA RID: 682
		' (get) Token: 0x0600087A RID: 2170 RVA: 0x0025C688 File Offset: 0x0025B688
		' (set) Token: 0x0600087B RID: 2171 RVA: 0x0025C69C File Offset: 0x0025B69C
		Friend Overridable Property tbMouseY As TextBox
			Get
				Return Me._tbMouseY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tbMouseY IsNot Nothing Then
				End If
				Me._tbMouseY = value
				If Me._tbMouseY IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170002AB RID: 683
		' (get) Token: 0x0600087D RID: 2173 RVA: 0x0025C6B8 File Offset: 0x0025B6B8
		' (set) Token: 0x0600087C RID: 2172 RVA: 0x0025C6CC File Offset: 0x0025B6CC
		Friend Overridable Property chkbFine As CheckBox
			Get
				Return Me._chkbFine
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				If Me._chkbFine IsNot Nothing Then
					RemoveHandler Me._chkbFine.CheckedChanged, AddressOf Me.chkbFine_CheckedChanged
				End If
				Me._chkbFine = value
				If Me._chkbFine IsNot Nothing Then
					AddHandler Me._chkbFine.CheckedChanged, AddressOf Me.chkbFine_CheckedChanged
				End If
			End Set
		End Property

		' Token: 0x170002AC RID: 684
		' (get) Token: 0x0600087E RID: 2174 RVA: 0x0025C720 File Offset: 0x0025B720
		' (set) Token: 0x0600087F RID: 2175 RVA: 0x0025C734 File Offset: 0x0025B734
		Friend Overridable Property btnAssignPt1 As Button
			Get
				Return Me._btnAssignPt1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnAssignPt1 IsNot Nothing Then
					RemoveHandler Me._btnAssignPt1.Click, AddressOf Me.btnAssignPt1_Click
				End If
				Me._btnAssignPt1 = value
				If Me._btnAssignPt1 IsNot Nothing Then
					AddHandler Me._btnAssignPt1.Click, AddressOf Me.btnAssignPt1_Click
				End If
			End Set
		End Property

		' Token: 0x170002AD RID: 685
		' (get) Token: 0x06000881 RID: 2177 RVA: 0x0025C788 File Offset: 0x0025B788
		' (set) Token: 0x06000880 RID: 2176 RVA: 0x0025C79C File Offset: 0x0025B79C
		Friend Overridable Property tb3dsMaxPt1X As TextBox
			Get
				Return Me._tb3dsMaxPt1X
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tb3dsMaxPt1X IsNot Nothing Then
				End If
				Me._tb3dsMaxPt1X = value
				If Me._tb3dsMaxPt1X IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170002AE RID: 686
		' (get) Token: 0x06000883 RID: 2179 RVA: 0x0025C7B8 File Offset: 0x0025B7B8
		' (set) Token: 0x06000882 RID: 2178 RVA: 0x0025C7CC File Offset: 0x0025B7CC
		Friend Overridable Property tb3dsMaxPt1Y As TextBox
			Get
				Return Me._tb3dsMaxPt1Y
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tb3dsMaxPt1Y IsNot Nothing Then
				End If
				Me._tb3dsMaxPt1Y = value
				If Me._tb3dsMaxPt1Y IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170002AF RID: 687
		' (get) Token: 0x06000885 RID: 2181 RVA: 0x0025C7E8 File Offset: 0x0025B7E8
		' (set) Token: 0x06000884 RID: 2180 RVA: 0x0025C7FC File Offset: 0x0025B7FC
		Friend Overridable Property tb3dsMaxPt2Y As TextBox
			Get
				Return Me._tb3dsMaxPt2Y
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tb3dsMaxPt2Y IsNot Nothing Then
				End If
				Me._tb3dsMaxPt2Y = value
				If Me._tb3dsMaxPt2Y IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170002B0 RID: 688
		' (get) Token: 0x06000887 RID: 2183 RVA: 0x0025C818 File Offset: 0x0025B818
		' (set) Token: 0x06000886 RID: 2182 RVA: 0x0025C82C File Offset: 0x0025B82C
		Friend Overridable Property tb3dsMaxPt2X As TextBox
			Get
				Return Me._tb3dsMaxPt2X
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tb3dsMaxPt2X IsNot Nothing Then
				End If
				Me._tb3dsMaxPt2X = value
				If Me._tb3dsMaxPt2X IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170002B1 RID: 689
		' (get) Token: 0x06000889 RID: 2185 RVA: 0x0025C848 File Offset: 0x0025B848
		' (set) Token: 0x06000888 RID: 2184 RVA: 0x0025C85C File Offset: 0x0025B85C
		Friend Overridable Property btnAssignPt2 As Button
			Get
				Return Me._btnAssignPt2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnAssignPt2 IsNot Nothing Then
					RemoveHandler Me._btnAssignPt2.Click, AddressOf Me.btnAssignPt2_Click
				End If
				Me._btnAssignPt2 = value
				If Me._btnAssignPt2 IsNot Nothing Then
					AddHandler Me._btnAssignPt2.Click, AddressOf Me.btnAssignPt2_Click
				End If
			End Set
		End Property

		' Token: 0x170002B2 RID: 690
		' (get) Token: 0x0600088B RID: 2187 RVA: 0x0025C8B0 File Offset: 0x0025B8B0
		' (set) Token: 0x0600088A RID: 2186 RVA: 0x0025C8C4 File Offset: 0x0025B8C4
		Friend Overridable Property btnCalcCalibrationVals As Button
			Get
				Return Me._btnCalcCalibrationVals
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnCalcCalibrationVals IsNot Nothing Then
					RemoveHandler Me._btnCalcCalibrationVals.Click, AddressOf Me.btnCalcCalibrationVals_Click
				End If
				Me._btnCalcCalibrationVals = value
				If Me._btnCalcCalibrationVals IsNot Nothing Then
					AddHandler Me._btnCalcCalibrationVals.Click, AddressOf Me.btnCalcCalibrationVals_Click
				End If
			End Set
		End Property

		' Token: 0x170002B3 RID: 691
		' (get) Token: 0x0600088C RID: 2188 RVA: 0x0025C918 File Offset: 0x0025B918
		' (set) Token: 0x0600088D RID: 2189 RVA: 0x0025C92C File Offset: 0x0025B92C
		Friend Overridable Property btnCalToolsToggle As Button
			Get
				Return Me._btnCalToolsToggle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				If Me._btnCalToolsToggle IsNot Nothing Then
					RemoveHandler Me._btnCalToolsToggle.MouseDown, AddressOf Me.btnCalToolsToggle_MouseDown
				End If
				Me._btnCalToolsToggle = value
				If Me._btnCalToolsToggle IsNot Nothing Then
					AddHandler Me._btnCalToolsToggle.MouseDown, AddressOf Me.btnCalToolsToggle_MouseDown
				End If
			End Set
		End Property

		' Token: 0x170002B4 RID: 692
		' (get) Token: 0x0600088E RID: 2190 RVA: 0x0025C980 File Offset: 0x0025B980
		' (set) Token: 0x0600088F RID: 2191 RVA: 0x0025C994 File Offset: 0x0025B994
		Friend Overridable Property miFont As MenuItem
			Get
				Return Me._miFont
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miFont IsNot Nothing Then
					RemoveHandler Me._miFont.Click, AddressOf Me.miFont_Click
				End If
				Me._miFont = value
				If Me._miFont IsNot Nothing Then
					AddHandler Me._miFont.Click, AddressOf Me.miFont_Click
				End If
			End Set
		End Property

		' Token: 0x170002B5 RID: 693
		' (get) Token: 0x06000891 RID: 2193 RVA: 0x0025C9E8 File Offset: 0x0025B9E8
		' (set) Token: 0x06000890 RID: 2192 RVA: 0x0025C9FC File Offset: 0x0025B9FC
		Friend Overridable Property miUseAltSmallMap As MenuItem
			Get
				Return Me._miUseAltSmallMap
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miUseAltSmallMap IsNot Nothing Then
					RemoveHandler Me._miUseAltSmallMap.Click, AddressOf Me.miUseAltSmallMap_Click
				End If
				Me._miUseAltSmallMap = value
				If Me._miUseAltSmallMap IsNot Nothing Then
					AddHandler Me._miUseAltSmallMap.Click, AddressOf Me.miUseAltSmallMap_Click
				End If
			End Set
		End Property

		' Token: 0x06000893 RID: 2195 RVA: 0x002600A0 File Offset: 0x0025F0A0
		Public Function Setup(ProjectPath As String) As Boolean
			Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
			frmModule_Editor.g_form = Me
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.gModuleEditorSettings = ModuleEditorProjectSettings.GetSettings(ProjectPath)
			While ProjectPath.EndsWith("\")
				ProjectPath = ProjectPath.Substring(0, ProjectPath.Length - 1)
			End While
			Me.g_ProjectPath = ProjectPath
			If StringType.StrCmp(Me.gModuleEditorSettings.ModuleEditorModOutputPath, "", False) = 0 Then
				Me.gModuleEditorSettings.ModuleEditorModOutputPath = Me.g_ProjectPath
			End If
			If Not Directory.Exists(Me.g_ProjectPath + "\extras") Then
				Directory.CreateDirectory(Me.g_ProjectPath + "\extras")
			End If
			If Directory.GetFiles(Me.g_ProjectPath, "*.git").Length = 0 Then
				Interaction.MsgBox("It would appear that your module is missing it's .git file.", MsgBoxStyle.Critical, "Module load error")
				Return False
			End If
			Dim text As String = Directory.GetFiles(Me.g_ProjectPath, "*.git")(0)
			Me.g_MapName = Path.GetFileNameWithoutExtension(text)
			Me.KotorVersionIndex = frmMain.GetGFFFileKotorVersionIndex(text)
			Me.SetEditorCaption()
			Me.g_UserPalettePath = Me.g_ProjectPath + "\userpalette"
			Me.g_GlobalTemplatesPath = frmMain.gRootPath + "\Global Templates\k" + StringType.FromInteger(Me.KotorVersionIndex + 1)
			Me.htTemplateBifFiles = frmMain.KxChitinKey(Me.KotorVersionIndex).GetBIFFileHash("templates")
			Dim stream As Stream
			Try
				stream = File.OpenRead(frmMain.gRootPath + "K1TemplateTags.bfd")
				Me.htK1Tags = CType(binaryFormatter.Deserialize(stream), Hashtable)
				stream.Close()
            Catch ex As System.Exception
            End Try
			Try
				stream = File.OpenRead(frmMain.gRootPath + "K2TemplateTags.bfd")
				Me.htK2Tags = CType(binaryFormatter.Deserialize(stream), Hashtable)
				stream.Close()
            Catch ex2 As System.Exception
            End Try
			Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\dialog.tlk", False)
			Try
				stream = New FileStream(text, FileMode.Open, FileAccess.Read)
				Me.GITfile = New clsGFF(CType(stream, FileStream), Me.KotorVersionIndex, True)
            Catch ex3 As System.Exception
                Interaction.MsgBox("It would appear that your module .GIT file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error")
                Return False
			End Try
			Try
				stream = New FileStream(Path.Combine(Path.GetDirectoryName(text), "module.ifo"), FileMode.Open, FileAccess.Read)
				Me.IFOfile = New clsGFF(CType(stream, FileStream), Me.KotorVersionIndex, True)
            Catch ex4 As System.Exception
                Interaction.MsgBox("It would appear that your Module.ifo file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error")
                Return False
			End Try
			Try
				stream = New FileStream(text.ToLower().Replace(".git", ".are"), FileMode.Open, FileAccess.Read)
				Me.AREfile = New clsGFF(CType(stream, FileStream), Me.KotorVersionIndex, True)
            Catch ex5 As System.Exception
                Interaction.MsgBox("It would appear that your module .ARE file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error")
                Return False
			End Try
			Me.g_MapName = Path.GetFileNameWithoutExtension(text).ToLower()
			Me.g_SmallMapAvailable = File.Exists(Me.g_mapsPath + "map" + Me.g_MapName + ".map")
			Me.g_LargeMapAvailable = File.Exists(Me.g_mapsPath + "map" + Me.g_MapName + "_lg.map")
			Me.g_AltSmallMapAvailable = File.Exists(Me.g_mapsPath + "map" + Me.g_MapName + "_alt.map")
			If Not(Me.g_SmallMapAvailable Or Me.g_LargeMapAvailable) Then
				MessageBox.Show("You do not have a .map file for this module in your Kotor Tool 'Maps' directory." & vbLf & vbLf & "Use the '' menu item on the main Tools menu to see if this module is supported." & vbLf & vbLf & "If it is, you will need to obtain the map file, put in the 'Maps' directory, and reload this module.", "Missing .map file", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Me.miUseSmallMap.Enabled = Me.g_SmallMapAvailable
			Me.miUseLargeMap.Enabled = Me.g_LargeMapAvailable
			Me.miUseAltSmallMap.Enabled = Me.g_AltSmallMapAvailable
			If StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "small", False) = 0 AndAlso Not Me.g_SmallMapAvailable AndAlso Me.g_LargeMapAvailable Then
				Me.gModuleEditorSettings.MapSize = "large"
			End If
			If StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "large", False) = 0 AndAlso Not Me.g_LargeMapAvailable AndAlso Me.g_SmallMapAvailable Then
				Me.gModuleEditorSettings.MapSize = "small"
			End If
			If StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "altsmall", False) = 0 AndAlso Not Me.g_AltSmallMapAvailable Then
				If Me.g_SmallMapAvailable Then
					Me.gModuleEditorSettings.MapSize = "small"
				ElseIf Me.g_LargeMapAvailable Then
					Me.gModuleEditorSettings.MapSize = "large"
				End If
			End If
			If((StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "", False) = 0) Or (StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "small", False) = 0)) AndAlso Me.g_SmallMapAvailable Then
				Me.g_mapImageName = "map" + Me.g_MapName + ".map"
				Me.g_MapTypeInUse = 0
				Me.g_UsingLargeMap = False
				Me.miUseSmallMap.Checked = True
				Me.miUseLargeMap.Checked = False
				Me.miUseAltSmallMap.Checked = False
			ElseIf((StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "", False) = 0) Or (StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "large", False) = 0)) AndAlso Me.g_LargeMapAvailable Then
				Me.g_mapImageName = "map" + Me.g_MapName + "_lg.map"
				Me.g_MapTypeInUse = 1
				Me.g_UsingLargeMap = True
				Me.miUseSmallMap.Checked = False
				Me.miUseLargeMap.Checked = True
				Me.miUseAltSmallMap.Checked = False
			ElseIf StringType.StrCmp(Me.gModuleEditorSettings.MapSize, "altsmall", False) = 0 AndAlso Me.g_AltSmallMapAvailable Then
				Me.g_mapImageName = "map" + Me.g_MapName + "_alt.map"
				Me.g_MapTypeInUse = 2
				Me.miUseSmallMap.Checked = False
				Me.miUseLargeMap.Checked = False
				Me.miUseAltSmallMap.Checked = True
			End If
			If Not Me.chkbUseFactors.Checked Then
				Dim mapInfo As MapInfo
				Try
					stream = File.OpenRead(frmMain.gRootPath + "MapInfo.bfd")
					mapInfo = CType(binaryFormatter.Deserialize(stream), MapInfo)
					stream.Close()
                Catch ex6 As System.Exception
                    stream.Seek(0L, SeekOrigin.Begin)
                    binaryFormatter = frmMapInfoStatus.CreateMapInfoFormatter(Type.[GetType]("kotor_tool.MapInfo"))
                    mapInfo = CType(binaryFormatter.Deserialize(stream), MapInfo)
                    stream.Close()
                    If mapInfo.[GetType]() Is Type.[GetType]("kotor_tool.MapInfo") Then
                        stream = File.OpenWrite(frmMain.gRootPath + "MapInfo.bfd")
                        binaryFormatter = New BinaryFormatter()
                        binaryFormatter.Serialize(stream, mapInfo)
                        stream.Close()
                    Else
                        Interaction.MsgBox("Unable to load MapInfo.bfd file." & vbLf & vbLf & "Please download a fresh copy.", MsgBoxStyle.Critical, "MapInfo error")
                    End If
				End Try
				Dim flag As Boolean = False
				Try
					For Each obj As Object In mapInfo.MapList
						Dim map As MapInfo.Map = CType(obj, MapInfo.Map)
						If StringType.StrCmp(Me.g_MapName, map.MapName, False) = 0 Then
							If Me.g_UsingLargeMap AndAlso Not map.L Then
								Exit For
							End If
							If Not Me.g_UsingLargeMap AndAlso Not map.S Then
								Exit For
							End If
							flag = True
							Select Case Me.g_MapTypeInUse
								Case 0
									Me.nudXmul.Value = map.SXMul
									Me.nudYmul.Value = map.SYMul
									Me.nudXoff.Value = New Decimal(map.SXOff)
									Me.nudYoff.Value = New Decimal(map.SYOff)
									GoTo IL_088F
								Case 1
									Me.nudXmul.Value = map.LXMul
									Me.nudYmul.Value = map.LYMul
									Me.nudXoff.Value = New Decimal(map.LXOff)
									Me.nudYoff.Value = New Decimal(map.LYOff)
									GoTo IL_088F
								Case 2
									Me.nudXmul.Value = map.AltSXMul
									Me.nudYmul.Value = map.AltSYMul
									Me.nudXoff.Value = New Decimal(map.AltSXOff)
									Me.nudYoff.Value = New Decimal(map.AltSYOff)
									GoTo IL_088F
								Case Else
									GoTo IL_088F
							End Select
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
				IL_088F:
				If Not flag Then
					Interaction.MsgBox("You have the map for this module, but the MapInfo file appears to be incorrect or out-of date.", MsgBoxStyle.Critical, "Map Info missing")
					Return False
				End If
			End If
			Me.UpdateVisibilityBtnsWithSettings()
			AddHandler Me.chkbShowTags.CheckedChanged, AddressOf Me.chkbShowTags_CheckedChanged
			Me.bmp = Nothing
			Me.bmp_cache = Nothing
			Me.LoadBackground()
			Me.pbox.Size = Me.bmp.Size
			Me.BuildUserPaletteTreeView()
			Me.BuildScriptsPalette()
			Me.BuildDialogsPalette()
			Me.DisableFileSystemWatchers()
			Me.CreateFileSystemWatchers()
			Me.EnableControls(True)
			Dim panel As ScrollableControl = Me.Panel1
			Dim point As Point = New Point(Me.gModuleEditorSettings.LastScrollPosX, Me.gModuleEditorSettings.LastScrollPosY)
			panel.AutoScrollPosition = point
			Return True
		End Function

		' Token: 0x06000894 RID: 2196 RVA: 0x00260A9C File Offset: 0x0025FA9C
		Private Sub UpdateVisibilityBtnsWithSettings()
			Me.tbarbtnCreature.Pushed = Me.gModuleEditorSettings.FilterShowCreatures
			Me.tbarbtnDoor.Pushed = Me.gModuleEditorSettings.FilterShowDoors
			Me.tbarbtnEncounter.Pushed = Me.gModuleEditorSettings.FilterShowEncounters
			Me.tbarbtnMerchant.Pushed = Me.gModuleEditorSettings.FilterShowMerchants
			Me.tbarbtnPlaceable.Pushed = Me.gModuleEditorSettings.FilterShowPlaceables
			Me.tbarbtnSound.Pushed = Me.gModuleEditorSettings.FilterShowSounds
			Me.tbarbtnTrigger.Pushed = Me.gModuleEditorSettings.FilterShowTriggers
			Me.tbarbtnWaypoint.Pushed = Me.gModuleEditorSettings.FilterShowWaypoints
			Me.chkbShowTags.Checked = Me.gModuleEditorSettings.ShowTagsOnModulePalette
		End Sub

		' Token: 0x06000895 RID: 2197 RVA: 0x00260B70 File Offset: 0x0025FB70
		Private Sub CreateFileSystemWatchers()
			If Not Directory.Exists(Me.g_ProjectPath + "\userpalette") Then
				Directory.CreateDirectory(Me.g_ProjectPath + "\userpalette")
			End If
			Me.g_UserPalettteFsw.Path = Me.g_ProjectPath + "\userpalette"
			Me.g_UserPalettteFsw.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.CreationTime
			Me.g_UserPalettteFsw.SynchronizingObject = Me
			AddHandler Me.g_UserPalettteFsw.Created, AddressOf Me.OnUserPaletteFSChanged
			AddHandler Me.g_UserPalettteFsw.Deleted, AddressOf Me.OnUserPaletteFSChanged
			AddHandler Me.g_UserPalettteFsw.Renamed, AddressOf Me.OnUserPaletteFSChanged
			Me.g_ProjectFsw.Path = Me.g_ProjectPath
			Me.g_ProjectFsw.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.CreationTime
			Me.g_ProjectFsw.SynchronizingObject = Me
			AddHandler Me.g_ProjectFsw.Created, AddressOf Me.OnProjectFSChanged
			AddHandler Me.g_ProjectFsw.Deleted, AddressOf Me.OnProjectFSChanged
			AddHandler Me.g_ProjectFsw.Renamed, AddressOf Me.OnProjectFSChanged
			Me.g_UserPalettteFsw.EnableRaisingEvents = True
			Me.g_ProjectFsw.EnableRaisingEvents = True
		End Sub

		' Token: 0x06000896 RID: 2198 RVA: 0x00260CB0 File Offset: 0x0025FCB0
		Private Sub DisableFileSystemWatchers()
			If Me.g_UserPalettteFsw.EnableRaisingEvents Then
				Me.g_UserPalettteFsw.EnableRaisingEvents = False
				RemoveHandler Me.g_UserPalettteFsw.Created, AddressOf Me.OnUserPaletteFSChanged
				RemoveHandler Me.g_UserPalettteFsw.Deleted, AddressOf Me.OnUserPaletteFSChanged
				RemoveHandler Me.g_UserPalettteFsw.Renamed, AddressOf Me.OnUserPaletteFSChanged
			End If
			If Me.g_ProjectFsw.EnableRaisingEvents Then
				Me.g_ProjectFsw.EnableRaisingEvents = False
				RemoveHandler Me.g_ProjectFsw.Created, AddressOf Me.OnProjectFSChanged
				RemoveHandler Me.g_ProjectFsw.Deleted, AddressOf Me.OnProjectFSChanged
				RemoveHandler Me.g_ProjectFsw.Renamed, AddressOf Me.OnProjectFSChanged
			End If
		End Sub

		' Token: 0x06000897 RID: 2199 RVA: 0x00260D80 File Offset: 0x0025FD80
		Private Sub OnUserPaletteFSChanged(source As Object, e As FileSystemEventArgs)
			Me.BuildUserPaletteTreeView()
			Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger(CInt(e.ChangeType)))
		End Sub

		' Token: 0x06000898 RID: 2200 RVA: 0x00260DB0 File Offset: 0x0025FDB0
		Private Sub OnUserPaletteFSChanged(source As Object, e As RenamedEventArgs)
			frmModule_Editor.g_form.BuildUserPaletteTreeView()
			Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger(CInt(e.ChangeType)))
		End Sub

		' Token: 0x06000899 RID: 2201 RVA: 0x00260DE4 File Offset: 0x0025FDE4
		Private Sub OnProjectFSChanged(source As Object, e As FileSystemEventArgs)
			Dim extension As String = Path.GetExtension(e.Name.ToLower())
			If StringType.StrCmp(extension, ".nss", False) = 0 Then
				Me.BuildScriptsPalette()
			ElseIf StringType.StrCmp(extension, ".dlg", False) = 0 Then
				Me.BuildDialogsPalette()
			End If
			Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger(CInt(e.ChangeType)))
		End Sub

		' Token: 0x0600089A RID: 2202 RVA: 0x00260E54 File Offset: 0x0025FE54
		Private Sub OnProjectFSChanged(source As Object, e As RenamedEventArgs)
			Dim extension As String = Path.GetExtension(e.Name.ToLower())
			If StringType.StrCmp(extension, ".nss", False) = 0 Then
				Me.BuildScriptsPalette()
			ElseIf StringType.StrCmp(extension, ".dlg", False) = 0 Then
				Me.BuildDialogsPalette()
			End If
			Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger(CInt(e.ChangeType)))
		End Sub

		' Token: 0x0600089B RID: 2203 RVA: 0x00260EC4 File Offset: 0x0025FEC4
		Private Sub BuildScriptsPalette()
			Me.lbScripts.Items.Clear()
			Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Me.g_ProjectPath)
			For Each fileInfo As FileInfo In directoryInfo.GetFiles("*.nss")
				Me.lbScripts.Items.Add(Path.GetFileNameWithoutExtension(fileInfo.Name))
			Next
		End Sub

		' Token: 0x0600089C RID: 2204 RVA: 0x00260F28 File Offset: 0x0025FF28
		Private Sub BuildDialogsPalette()
			Me.lbDialogs.Items.Clear()
			Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Me.g_ProjectPath)
			For Each fileInfo As FileInfo In directoryInfo.GetFiles("*.dlg")
				Me.lbDialogs.Items.Add(Path.GetFileNameWithoutExtension(fileInfo.Name))
			Next
		End Sub

		' Token: 0x0600089D RID: 2205 RVA: 0x00260F8C File Offset: 0x0025FF8C
		Public Sub LoadBackground()
			If Me.bmp_cache Is Nothing Then
				Select Case Me.g_MapTypeInUse
					Case 0
						Me.bmp = New Bitmap(Me.g_mapsPath + "map" + Me.g_MapName + ".map")
					Case 1
						Me.bmp = New Bitmap(Me.g_mapsPath + "map" + Me.g_MapName + "_lg.map")
					Case 2
						Me.bmp = New Bitmap(Me.g_mapsPath + "map" + Me.g_MapName + "_alt.map")
				End Select
				Dim bitmap As Bitmap = Me.bmp
				Dim rectangle As Rectangle = New Rectangle(0, 0, Me.bmp.Width, Me.bmp.Height)
				Me.bmp_cache = bitmap.Clone(rectangle, Me.bmp.PixelFormat)
			Else
				Dim bitmap2 As Bitmap = Me.bmp_cache
				Dim rectangle As Rectangle = New Rectangle(0, 0, Me.bmp.Width, Me.bmp.Height)
				Me.bmp = bitmap2.Clone(rectangle, Me.bmp.PixelFormat)
			End If
			Me.g_imageYsize = Me.bmp.Height
		End Sub

		' Token: 0x0600089E RID: 2206 RVA: 0x002610C0 File Offset: 0x002600C0
		Public Sub Draw()
			Dim font As Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim num As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_X"))
			Dim num2 As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_Y"))
			Dim num3 As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
			Dim num4 As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
			Dim pen As Pen = New Pen(Color.White, 1F)
			pen.SetLineCap(LineCap.NoAnchor, LineCap.ArrowAnchor, DashCap.Flat)
			Try
                Dim obj As Object = Graphics.FromImage(Me.bmp)
				Dim type As Type = Nothing
				Dim text As String = "DrawLine"
				Dim array As Object() = New Object() { pen, num3, num4, ObjectType.AddObj(num3, ObjectType.MulObj(Me.IFOfile.GetNodeValue("Mod_Entry_Dir_X"), Me.nudXmul.Value)), ObjectType.SubObj(num4, ObjectType.MulObj(Me.IFOfile.GetNodeValue("Mod_Entry_Dir_Y"), Me.nudYmul.Value)) }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Boolean() = New Boolean() { True, True, True, False, False }
				LateBinding.LateCall(obj, type, text, array2, array3, array4)
				If array4(2) Then
					num4 = IntegerType.FromObject(array(2))
				End If
				If array4(1) Then
					num3 = IntegerType.FromObject(array(1))
				End If
				If array4(0) Then
					pen = CType(array(0), Pen)
				End If
				Graphics.FromImage(Me.bmp).DrawEllipse(New Pen(Color.Red, 2F), num3 - 6, num4 - 6, 12, 12)
			Catch ex As SystemException
				Dim ex2 As SystemException = CType(ex, SystemException)
			End Try
			Dim ticks As Long = DateAndTime.Now.Ticks
			Me.CreatureArr = New ModItem(Me.GITfile.GetListItemCount("Creature List") - 1 + 1 - 1) {}
			Dim num5 As Integer = Me.CreatureArr.GetUpperBound(0)
			Dim num6 As Integer = 0
			Dim num7 As Integer = num5
			For i As Integer = num6 To num7
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").XPosition"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").YPosition"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.CreatureArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "Creature List(" + StringType.FromInteger(i) + ")")
				Me.CreatureArr(i).XPosAccessor = "XPosition"
				Me.CreatureArr(i).YPosAccessor = "YPosition"
				Me.CreatureArr(i).ZPosAccessor = "ZPosition"
				Me.CreatureArr(i).ItemType = 2027
				If Me.CreatureArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowCreatures Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utc")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						Dim obj3 As Object = Graphics.FromImage(Me.bmp)
						Dim type2 As Type = Nothing
						Dim text2 As String = "DrawLine"
						Dim array5 As Object() = New Object() { New Pen(Color.White, 1F), num3, num4, ObjectType.AddObj(num3, ObjectType.MulObj(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").XOrientation"), Me.nudXmul.Value)), ObjectType.SubObj(num4, ObjectType.MulObj(Me.GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(i) + ").YOrientation"), Me.nudYmul.Value)) }
						Dim array6 As Object() = array5
						Dim array7 As String() = Nothing
						Dim array4 As Boolean() = New Boolean() { False, True, True, False, False }
						LateBinding.LateCall(obj3, type2, text2, array6, array7, array4)
						If array4(2) Then
							num4 = IntegerType.FromObject(array5(2))
						End If
						If array4(1) Then
							num3 = IntegerType.FromObject(array5(1))
						End If
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.HotPink)
					Catch ex3 As SystemException
						Dim ex4 As SystemException = CType(ex3, SystemException)
					End Try
				End If
			Next
			Me.PlaceableArr = New ModItem(Me.GITfile.GetListItemCount("Placeable List") - 1 + 1 - 1) {}
			num5 = Me.PlaceableArr.GetUpperBound(0)
			Dim num8 As Integer = 0
			Dim num9 As Integer = num5
			For i As Integer = num8 To num9
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(i) + ").X"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(i) + ").Y"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.PlaceableArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "Placeable List(" + StringType.FromInteger(i) + ")")
				Me.PlaceableArr(i).XPosAccessor = "X"
				Me.PlaceableArr(i).YPosAccessor = "Y"
				Me.PlaceableArr(i).ZPosAccessor = "Z"
				Me.PlaceableArr(i).ItemType = 2044
				If Me.PlaceableArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowPlaceables Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utp")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						num = SingleType.FromObject(Me.GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(i) + ").Bearing"))
						Graphics.FromImage(Me.bmp).DrawLine(New Pen(Color.White, 1F), num3, num4, num3 - CInt(Math.Round(Math.Cos(CDbl(num)) * Convert.ToDouble(Me.nudXmul.Value))), num4 + CInt(Math.Round(Math.Sin(CDbl(num)) * Convert.ToDouble(Me.nudYmul.Value))))
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.LightGreen)
					Catch ex5 As SystemException
						Dim ex6 As SystemException = CType(ex5, SystemException)
						Console.WriteLine(String.Concat(New String() { ex6.Message, ":  ", StringType.FromInteger(num3), "  ", StringType.FromInteger(num4), "  ", StringType.FromInteger(num3 - CInt(Math.Round(Math.Cos(CDbl(num)) * Convert.ToDouble(Me.nudXmul.Value)))), "  ", StringType.FromInteger(num4 + CInt(Math.Round(Math.Sin(CDbl(num)) * Convert.ToDouble(Me.nudYmul.Value)))) }))
					End Try
				End If
			Next
			Me.DoorArr = New ModItem(Me.GITfile.GetListItemCount("Door List") - 1 + 1 - 1) {}
			num5 = Me.DoorArr.GetUpperBound(0)
			Dim num10 As Integer = 0
			Dim num11 As Integer = num5
			For i As Integer = num10 To num11
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("Door List(" + StringType.FromInteger(i) + ").X"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("Door List(" + StringType.FromInteger(i) + ").Y"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("Door List(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.DoorArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "Door List(" + StringType.FromInteger(i) + ")")
				Me.DoorArr(i).XPosAccessor = "X"
				Me.DoorArr(i).YPosAccessor = "Y"
				Me.DoorArr(i).ZPosAccessor = "Z"
				Me.DoorArr(i).ItemType = 2042
				If Me.DoorArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowDoors Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utd")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						num = SingleType.FromObject(ObjectType.AddObj(Me.GITfile.GetNodeValue("Door List(" + StringType.FromInteger(i) + ").Bearing"), 1.5707963267948966))
						Graphics.FromImage(Me.bmp).DrawLine(New Pen(Color.White, 1F), num3, num4, num3 - CInt(Math.Round(Math.Cos(CDbl(num)) * Convert.ToDouble(Me.nudXmul.Value))), num4 + CInt(Math.Round(Math.Sin(CDbl(num)) * Convert.ToDouble(Me.nudYmul.Value))))
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.Yellow)
					Catch ex7 As SystemException
						Dim ex8 As SystemException = CType(ex7, SystemException)
					End Try
				End If
			Next
			Me.SoundArr = New ModItem(Me.GITfile.GetListItemCount("SoundList") - 1 + 1 - 1) {}
			num5 = Me.SoundArr.GetUpperBound(0)
			Dim num12 As Integer = 0
			Dim num13 As Integer = num5
			For i As Integer = num12 To num13
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(i) + ").XPosition"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(i) + ").YPosition"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.SoundArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "SoundList(" + StringType.FromInteger(i) + ")")
				Me.SoundArr(i).XPosAccessor = "XPosition"
				Me.SoundArr(i).YPosAccessor = "YPosition"
				Me.SoundArr(i).ZPosAccessor = "ZPosition"
				Me.SoundArr(i).ItemType = 2035
				If Me.SoundArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowSounds Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".uts")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.Blue)
					Catch ex9 As SystemException
						Dim ex10 As SystemException = CType(ex9, SystemException)
					End Try
				End If
			Next
			Me.WaypointArr = New ModItem(Me.GITfile.GetListItemCount("WaypointList") - 1 + 1 - 1) {}
			num5 = Me.WaypointArr.GetUpperBound(0)
			Dim num14 As Integer = 0
			Dim num15 As Integer = num5
			For i As Integer = num14 To num15
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").XPosition"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").YPosition"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Me.WaypointArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "WaypointList(" + StringType.FromInteger(i) + ")")
				Me.WaypointArr(i).XPosAccessor = "XPosition"
				Me.WaypointArr(i).YPosAccessor = "YPosition"
				Me.WaypointArr(i).ZPosAccessor = "ZPosition"
				Me.WaypointArr(i).ItemType = 2058
				Me.WaypointArr(i).Tag = StringType.FromObject(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").Tag"))
				If Me.WaypointArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				Dim color As Color
				If BooleanType.FromObject(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").HasMapNote")) Then
					color = Color.Red
				Else
					color = Color.Orange
				End If
				If Me.gModuleEditorSettings.FilterShowWaypoints Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.WaypointArr(i).Tag
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						Dim obj4 As Object = Graphics.FromImage(Me.bmp)
						Dim type3 As Type = Nothing
						Dim text3 As String = "DrawLine"
						Dim array5 As Object() = New Object() { New Pen(Color.White, 1F), num3, num4, ObjectType.AddObj(num3, ObjectType.MulObj(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").XOrientation"), Me.nudXmul.Value)), ObjectType.SubObj(num4, ObjectType.MulObj(Me.GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(i) + ").YOrientation"), Me.nudYmul.Value)) }
						Dim array8 As Object() = array5
						Dim array9 As String() = Nothing
						Dim array4 As Boolean() = New Boolean() { False, True, True, False, False }
						LateBinding.LateCall(obj4, type3, text3, array8, array9, array4)
						If array4(2) Then
							num4 = IntegerType.FromObject(array5(2))
						End If
						If array4(1) Then
							num3 = IntegerType.FromObject(array5(1))
						End If
						Me.Draw3x3Box(Me.bmp, num3, num4, color)
					Catch ex11 As SystemException
						Dim ex12 As SystemException = CType(ex11, SystemException)
					End Try
				End If
			Next
			Me.MerchantArr = New ModItem(Me.GITfile.GetListItemCount("StoreList") - 1 + 1 - 1) {}
			num5 = Me.MerchantArr.GetUpperBound(0)
			Dim num16 As Integer = 0
			Dim num17 As Integer = num5
			For i As Integer = num16 To num17
				num = SingleType.FromObject(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").XPosition"))
				num2 = SingleType.FromObject(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").YPosition"))
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").ResRef"))
				Me.MerchantArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "StoreList(" + StringType.FromInteger(i) + ")")
				Me.MerchantArr(i).XPosAccessor = "XPosition"
				Me.MerchantArr(i).YPosAccessor = "YPosition"
				Me.MerchantArr(i).ZPosAccessor = "ZPosition"
				Me.MerchantArr(i).ItemType = 2051
				If Me.MerchantArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.FilterShowMerchants Then
					If Me.gModuleEditorSettings.ShowItemLabels Then
						If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utm")))
						End If
						Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
					End If
					Try
						Dim obj5 As Object = Graphics.FromImage(Me.bmp)
						Dim type4 As Type = Nothing
						Dim text4 As String = "DrawLine"
						Dim array5 As Object() = New Object() { New Pen(Color.White, 1F), num3, num4, ObjectType.AddObj(num3, ObjectType.MulObj(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").XOrientation"), Me.nudXmul.Value)), ObjectType.SubObj(num4, ObjectType.MulObj(Me.GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(i) + ").YOrientation"), Me.nudYmul.Value)) }
						Dim array10 As Object() = array5
						Dim array11 As String() = Nothing
						Dim array4 As Boolean() = New Boolean() { False, True, True, False, False }
						LateBinding.LateCall(obj5, type4, text4, array10, array11, array4)
						If array4(2) Then
							num4 = IntegerType.FromObject(array5(2))
						End If
						If array4(1) Then
							num3 = IntegerType.FromObject(array5(1))
						End If
						Me.Draw3x3Box(Me.bmp, num3, num4, Color.Plum)
					Catch ex13 As SystemException
						Dim ex14 As SystemException = CType(ex13, SystemException)
					End Try
				End If
			Next
			num5 = Me.GITfile.GetListItemCount("CameraList")
			Me.CameraArr = New ModItem(num5 - 1 + 1 - 1) {}
			Dim num18 As Integer = 0
			Dim num19 As Integer = num5 - 1
			For i As Integer = num18 To num19
				Dim gfftype As GFFType17 = CType(Me.GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(i) + ").Position"), GFFType17)
				num = gfftype.f1
				num2 = gfftype.f2
				num3 = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
				num4 = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(i) + ").CameraID"))
				Me.CameraArr(i) = New ModItem(num3, num4, num, num2, StringType.FromObject(obj2), "CameraList(" + StringType.FromInteger(i) + ")")
				Me.CameraArr(i).ItemType = 6
				If Me.CameraArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
				End If
				If Me.gModuleEditorSettings.ShowItemLabels Then
					Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(ObjectType.StrCatObj("Cam ", obj2)), Me.labelFont, Me.labelBrush, CSng((num3 + 5)), CSng((num4 - 5)))
				End If
				Try
					Me.Draw3x3Box(Me.bmp, num3, num4, Color.Olive)
				Catch ex15 As SystemException
					Dim ex16 As SystemException = CType(ex15, SystemException)
				End Try
			Next
            Dim mapGraphics As Graphics = Graphics.FromImage(Me.bmp)
            num5 = Me.GITfile.GetListItemCount("TriggerList")
            Me.TriggerRegions = New Region(num5 - 1 + 1 - 1) {}
            Me.TriggerArr = New ModItem(num5 - 1 + 1 - 1) {}
			Dim num20 As Integer = 0
			Dim num21 As Integer = num5 - 1
			For i As Integer = num20 To num21
				Dim num22 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").XPosition"))
				Dim num23 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").YPosition"))
				Dim num24 As Single
				Dim num25 As Single
				Dim num26 As Single
				Dim num27 As Single

					num24 = Convert.ToSingle(Me.nudXmul.Value) * num22 - Convert.ToSingle(Me.nudXoff.Value)
					num25 = Convert.ToSingle(Me.nudYmul.Value) * num23 - Convert.ToSingle(Me.nudYoff.Value)
					num26 = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, ObjectType.AddObj(num22, Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").Geometry(0).PointX"))))), Me.nudXoff.Value))
					num27 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, ObjectType.AddObj(num23, Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").Geometry(0).PointY"))))), Me.nudYoff.Value))))

				Me.TriggerArr(i) = New ModItem(CInt(Math.Round(CDbl(num24))), CInt(Math.Round(CDbl(num25))), num22, num23, StringType.FromObject(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").TemplateResRef")), "TriggerList(" + StringType.FromInteger(i) + ")")
				Me.TriggerArr(i).Z = SingleType.FromObject(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").ZPosition"))
				Me.TriggerArr(i).XPosAccessor = "XPosition"
				Me.TriggerArr(i).YPosAccessor = "YPosition"
				Me.TriggerArr(i).ZPosAccessor = "ZPosition"
				Me.TriggerArr(i).ItemType = 2032
				Me.TriggerArr(i).GeometryList = New ArrayList()
				Dim geometryList As ArrayList = Me.TriggerArr(i).GeometryList
				Dim point As Point = New Point(CInt(Math.Round(CDbl(num26))), CInt(Math.Round(CDbl(num27))))
				geometryList.Add(point)
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Dim num28 As Integer = Me.GITfile.GetListItemCount("TriggerList(" + StringType.FromInteger(i) + ").Geometry") - 1
				Dim num29 As Integer = 1
				Dim num30 As Integer = num28
				For j As Integer = num29 To num30
					num = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, ObjectType.AddObj(num22, Me.GITfile.GetNodeValue(String.Concat(New String() { "TriggerList(", StringType.FromInteger(i), ").Geometry(", StringType.FromInteger(j), ").PointX" })))))), Me.nudXoff.Value))
					num2 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, ObjectType.AddObj(num23, Me.GITfile.GetNodeValue(String.Concat(New String() { "TriggerList(", StringType.FromInteger(i), ").Geometry(", StringType.FromInteger(j), ").PointY" })))))), Me.nudYoff.Value))))
					Try
						Dim geometryList2 As ArrayList = Me.TriggerArr(i).GeometryList
						point = New Point(CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
						geometryList2.Add(point)
					Catch ex17 As SystemException
						Dim ex18 As SystemException = CType(ex17, SystemException)
					End Try
				Next
				num = 0F
				num2 = 0F
				Dim num31 As Integer = 0
				Dim num32 As Integer = num28
				For j As Integer = num31 To num32
					num = SingleType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(Me.TriggerArr(i).GeometryList(j), Nothing, "X", New Object(-1) {}, Nothing, Nothing)))
					num2 = SingleType.FromObject(ObjectType.AddObj(num2, LateBinding.LateGet(Me.TriggerArr(i).GeometryList(j), Nothing, "Y", New Object(-1) {}, Nothing, Nothing)))
				Next
				num = CSng(CInt(Math.Round(CDbl((num / CSng((num28 + 1)))))))
				num2 = CSng(CInt(Math.Round(CDbl((num2 / CSng((num28 + 1)))))))
				If Me.TriggerArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
				End If

					If Me.gModuleEditorSettings.FilterShowTriggers Then
						If Me.gModuleEditorSettings.ShowItemLabels AndAlso Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
							Dim modItemTag As String = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".utt")))
							If modItemTag IsNot Nothing AndAlso StringType.StrCmp(modItemTag, "", False) <> 0 Then
								Graphics.FromImage(Me.bmp).DrawString(modItemTag, Me.labelFont, Me.labelBrush, num + 5F, num2 - 5F)
							Else
								Dim text5 As String
								If Directory.Exists(Me.g_ProjectPath + "\recycle") Then
									Dim files As String() = Directory.GetFiles(Me.g_ProjectPath + "\recycle", StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj("*", obj2), ".utt")))
									If files.Length > 0 Then
										text5 = vbLf & vbLf & "However, there are one or more files in your project's 'recycle' folder that match the file's name." & vbLf & vbLf & "If you wish to keep the file's item, you can move and rename the desired file back into your project folder without quitting the Module editor. Otherwise, select the item in the Module treeview, right click to bring up the menu, then choose Delete."
									End If
								End If
								Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Unable to find file for trigger '", obj2), "' in your project folder or in templates.bif"), text5), MsgBoxStyle.Exclamation, "Missing file")
								Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(ObjectType.StrCatObj(obj2, " - MISSING")), Me.labelFont, Me.labelBrush, num + 5F, num2 - 5F)
							End If
						End If
						If obj2.ToString().StartsWith("g_t_") Then
                        Me.TriggerRegions(i) = Me.DrawRegionPoints(mapGraphics, Me.TriggerArr(i).GeometryList, Color.MediumAquamarine, True)
						Else
                        Me.TriggerRegions(i) = Me.DrawRegionPoints(mapGraphics, Me.TriggerArr(i).GeometryList, Color.MediumTurquoise, True)
						End If
					End If

			Next
            mapGraphics = Graphics.FromImage(Me.bmp)
            num5 = Me.GITfile.GetListItemCount("Encounter List")
			Me.EncounterRegions = New Region(num5 - 1 + 1 - 1) {}
			Me.EncounterArr = New ModItem(num5 - 1 + 1 - 1) {}
			Dim num33 As Integer = 0
			Dim num34 As Integer = num5 - 1
			For i As Integer = num33 To num34
				Dim num22 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").XPosition"))
				Dim num23 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").YPosition"))
				Dim num24 As Single
				Dim num25 As Single
				Dim num26 As Single
				Dim num27 As Single

					num24 = Convert.ToSingle(Me.nudXmul.Value) * num22 - Convert.ToSingle(Me.nudXoff.Value)
					num25 = Convert.ToSingle(Me.nudYmul.Value) * num23 - Convert.ToSingle(Me.nudYoff.Value)
					num26 = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, ObjectType.AddObj(num22, Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").Geometry(0).PointX"))))), Me.nudXoff.Value))
					num27 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, ObjectType.AddObj(num23, Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").Geometry(0).PointY"))))), Me.nudYoff.Value))))

				Me.EncounterArr(i) = New ModItem(CInt(Math.Round(CDbl(num24))), CInt(Math.Round(CDbl(num25))), num22, num23, StringType.FromObject(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").TemplateResRef")), "Encounter List(" + StringType.FromInteger(i) + ")")
				Me.EncounterArr(i).Z = SingleType.FromObject(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").ZPosition"))
				Me.EncounterArr(i).XPosAccessor = "XPosition"
				Me.EncounterArr(i).YPosAccessor = "YPosition"
				Me.EncounterArr(i).ZPosAccessor = "ZPosition"
				Me.EncounterArr(i).ItemType = 2040
				Me.EncounterArr(i).GeometryList = New ArrayList()
				Dim geometryList3 As ArrayList = Me.EncounterArr(i).GeometryList
				Dim point As Point = New Point(CInt(Math.Round(CDbl(num26))), CInt(Math.Round(CDbl(num27))))
				geometryList3.Add(point)
				Me.EncounterArr(i).SpawnPointList = New ArrayList()
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Me.GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(i) + ").TemplateResRef"))
				Dim num35 As Integer = 1
				Dim num36 As Integer = Me.GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(i) + ").Geometry") - 1
				For j As Integer = num35 To num36
					num = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, ObjectType.AddObj(num22, Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").Geometry(", StringType.FromInteger(j), ").X" })))))), Me.nudXoff.Value))
					num2 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, ObjectType.AddObj(num23, Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").Geometry(", StringType.FromInteger(j), ").Y" })))))), Me.nudYoff.Value))))
					Try
						Dim geometryList4 As ArrayList = Me.EncounterArr(i).GeometryList
						point = New Point(CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
						geometryList4.Add(point)
					Catch ex19 As SystemException
						Dim ex20 As SystemException = CType(ex19, SystemException)
					End Try
				Next
				Dim num37 As Integer = 0
				Dim num38 As Integer = Me.GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(i) + ").SpawnPointList") - 1
				For j As Integer = num37 To num38
					num = Convert.ToSingle(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudXmul.Value, Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").SpawnPointList(", StringType.FromInteger(j), ").X" }))))), Me.nudXoff.Value))
					num2 = CSng(Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(IntegerType.FromObject(ObjectType.MulObj(Me.nudYmul.Value, Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").SpawnPointList(", StringType.FromInteger(j), ").Y" }))))), Me.nudYoff.Value))))
					Try
						Dim spawnPointList As ArrayList = Me.EncounterArr(i).SpawnPointList
						point = New Point(CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
						spawnPointList.Add(point)
					Catch ex21 As SystemException
						Dim ex22 As SystemException = CType(ex21, SystemException)
					End Try
				Next
				num = 0F
				num2 = 0F
				Dim num28 As Integer = Me.GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(i) + ").Geometry") - 1
				Dim num39 As Integer = 0
				Dim num40 As Integer = num28
				For j As Integer = num39 To num40
					num = SingleType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(Me.EncounterArr(i).GeometryList(j), Nothing, "X", New Object(-1) {}, Nothing, Nothing)))
					num2 = SingleType.FromObject(ObjectType.AddObj(num2, LateBinding.LateGet(Me.EncounterArr(i).GeometryList(j), Nothing, "Y", New Object(-1) {}, Nothing, Nothing)))
				Next
				num = CSng(CInt(Math.Round(CDbl((num / CSng((num28 + 1)))))))
				num2 = CSng(CInt(Math.Round(CDbl((num2 / CSng((num28 + 1)))))))
				Dim pen2 As Pen = New Pen(Color.Wheat, 0.5F)
				pen2.SetLineCap(LineCap.RoundAnchor, LineCap.ArrowAnchor, DashCap.Flat)
				If Me.EncounterArr(i).IsEqual(Me.IndicatedModItem) Then
					Me.IndicateModItem(Graphics.FromImage(Me.bmp), CInt(Math.Round(CDbl(num))), CInt(Math.Round(CDbl(num2))))
				End If
				If Me.gModuleEditorSettings.FilterShowEncounters Then
					Try
						For Each obj6 As Object In Me.EncounterArr(i).SpawnPointList
							Dim point2 As Point = CType((If(obj6, Activator.CreateInstance(GetType(Point)))), Point)
							Graphics.FromImage(Me.bmp).DrawLine(pen2, CSng(point2.X), CSng(point2.Y), num, num2)
							Graphics.FromImage(Me.bmp).DrawString(StringType.FromInteger(Me.EncounterArr(i).SpawnPointList.IndexOf(point2) + 1), font, Brushes.Orchid, CSng((point2.X + 2)), CSng((point2.Y + 2)))
							Me.Draw3x3Box(Me.bmp, point2.X, point2.Y, Color.Orchid)
							Dim num41 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(String.Concat(New String() { "Encounter List(", StringType.FromInteger(i), ").SpawnPointList(", StringType.FromInteger(Me.EncounterArr(i).SpawnPointList.IndexOf(point2)), ").Orientation" })))
							Graphics.FromImage(Me.bmp).DrawLine(New Pen(Color.White, 1F), point2.X, point2.Y, point2.X + CInt(Math.Round(Math.Sin(CDbl(num41)) * Convert.ToDouble(Me.nudXmul.Value))), point2.Y - CInt(Math.Round(Math.Cos(CDbl(num41)) * Convert.ToDouble(Me.nudYmul.Value))))
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							CType(enumerator, IDisposable).Dispose()
						End If
					End Try

						If Me.gModuleEditorSettings.ShowItemLabels Then
							If Me.gModuleEditorSettings.ShowTagsOnModulePalette Then
								obj2 = Me.GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(obj2, ".ute")))
							End If
							Graphics.FromImage(Me.bmp).DrawString(StringType.FromObject(obj2), Me.labelFont, Me.labelBrush, num + 5F, num2 - 5F)
						End If
                    Me.EncounterRegions(i) = Me.DrawRegionPoints(mapGraphics, Me.EncounterArr(i).GeometryList, Color.Teal, True)

				End If
			Next
			Me.pbox.Image = Me.bmp
			GC.Collect()
		End Sub

		' Token: 0x0600089F RID: 2207 RVA: 0x00263C1C File Offset: 0x00262C1C
		Private Function DrawRegionPoints(g As Graphics, PointList As ArrayList, color As Color, Optional CloseFigure As Boolean = True) As Region
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim pen As Pen = New Pen(color, 1F)
			pen.EndCap = LineCap.Square
			Dim point As Point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim num As Integer = 1
			Dim num2 As Integer = PointList.Count - 1
			Dim rectangle As Rectangle
			For i As Integer = num To num2
				Dim pen2 As Pen = pen
				rectangle = New Rectangle(point.X - 1, point.Y - 1, 2, 2)
				g.DrawRectangle(pen2, rectangle)
				graphicsPath.AddLine(point, CType((If(PointList(i), Activator.CreateInstance(GetType(Point)))), Point))
				point = CType((If(PointList(i), Activator.CreateInstance(GetType(Point)))), Point)
			Next
			Dim pen3 As Pen = pen
			rectangle = New Rectangle(point.X - 1, point.Y - 1, 2, 2)
			g.DrawRectangle(pen3, rectangle)
			If CloseFigure Then
				graphicsPath.CloseFigure()
			End If
			g.DrawPath(pen, graphicsPath)
			Return New Region(graphicsPath)
		End Function

		' Token: 0x060008A0 RID: 2208 RVA: 0x00263D34 File Offset: 0x00262D34
		Private Sub Draw3x3Box(bmp As Bitmap, x As Integer, y As Integer, color As Color)
			' The following expression was wrapped in a checked-statement
			Graphics.FromImage(bmp).DrawRectangle(New Pen(color, Convert.ToSingle(Me.dModuleElementIndicatorSize)), x - 1, y - 1, 2, 2)
		End Sub

		' Token: 0x060008A1 RID: 2209 RVA: 0x00263D5C File Offset: 0x00262D5C
		Private Sub Draw6x6Box(bmp As Bitmap, x As Integer, y As Integer, color As Color)
			' The following expression was wrapped in a checked-statement
			Graphics.FromImage(bmp).DrawRectangle(New Pen(color, Convert.ToSingle(Me.dModuleElementIndicatorSize)), x - 2, y - 2, 5, 5)
		End Sub

		' Token: 0x060008A2 RID: 2210 RVA: 0x00263D84 File Offset: 0x00262D84
		Private Sub IndicateModItem(g As Graphics, x As Integer, y As Integer)
			' The following expression was wrapped in a checked-statement
			If Not Me.LeftMouseClickActive Then
				Dim panel As ScrollableControl = Me.Panel1
				Dim point As Point = New Point(CInt(Math.Round(CDbl(x) - CDbl(Me.Panel1.Size.Width) / 2.0)), CInt(Math.Round(CDbl(y) - CDbl(Me.Panel1.Size.Height) / 2.0)))
				panel.AutoScrollPosition = point
				If Me.bShowLocatorRay Then
					g.DrawLine(New Pen(Color.Orange, 2F), 0, 0, x, y)
				End If
			End If
			Dim pen As Pen = New Pen(Color.Orange, 1F)
			pen.EndCap = LineCap.ArrowAnchor
			g.DrawLine(pen, x + 10, y + 10, x + 4, y + 4)
			g.DrawLine(pen, x - 10, y + 10, x - 4, y + 4)
			g.DrawLine(pen, x + 10, y - 10, x + 4, y - 4)
			g.DrawLine(pen, x - 10, y - 10, x - 4, y - 4)
		End Sub

		' Token: 0x060008A3 RID: 2211 RVA: 0x00263E8C File Offset: 0x00262E8C
		Private Function invy(y As Integer) As Integer
			' The following expression was wrapped in a checked-expression
			Return Me.g_imageYsize - y
		End Function

		' Token: 0x060008A4 RID: 2212 RVA: 0x00263EA4 File Offset: 0x00262EA4
		Private Sub CopyModFilesToPath(ModItemArr As ModItem(), destPath As String)
			If ModItemArr IsNot Nothing Then
				For Each modItem As ModItem In ModItemArr
					If(modItem IsNot Nothing) And File.Exists(Me.g_ProjectPath + "\" + modItem.FileName) Then
						File.Copy(Me.g_ProjectPath + "\" + modItem.FileName, destPath + modItem.FileName, True)
					End If
				Next
			End If
		End Sub

		' Token: 0x060008A5 RID: 2213 RVA: 0x00263F18 File Offset: 0x00262F18
		Private Function Near(x As Object, y As Object, xCompare As Object, yCompare As Object) As Boolean
			Return BooleanType.FromObject(If((Not BooleanType.FromObject(ObjectType.ObjTst(LateBinding.LateGet(Nothing, GetType(Math), "Abs", New Object() { ObjectType.SubObj(x, xCompare) }, Nothing, Nothing), 2, False) <= 0) OrElse Not BooleanType.FromObject(ObjectType.ObjTst(LateBinding.LateGet(Nothing, GetType(Math), "Abs", New Object() { ObjectType.SubObj(y, yCompare) }, Nothing, Nothing), 2, False) <= 0)), False, True))
		End Function

		' Token: 0x060008A6 RID: 2214 RVA: 0x00263FC8 File Offset: 0x00262FC8
        ' Token: 0x060008A6 RID: 2214 RVA: 0x00263FC8 File Offset: 0x00262FC8
        Private Function FindModItem(ByVal pb As PictureBox) As ModItem
            Dim x As Integer = pb.PointToClient(Control.MousePosition).X
            Dim y As Integer = pb.PointToClient(Control.MousePosition).Y
            Dim foundItem As ModItem = Nothing

            If Me.CreatureArr IsNot Nothing Then
                For Each creatureItem As ModItem In Me.CreatureArr
                    If creatureItem IsNot Nothing AndAlso Me.Near(x, y, creatureItem.ScreenX, creatureItem.ScreenY) Then
                        foundItem = creatureItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.PlaceableArr IsNot Nothing Then
                For Each placeableItem As ModItem In Me.PlaceableArr
                    If placeableItem IsNot Nothing AndAlso Me.Near(x, y, placeableItem.ScreenX, placeableItem.ScreenY) Then
                        foundItem = placeableItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.WaypointArr IsNot Nothing Then
                For Each waypointItem As ModItem In Me.WaypointArr
                    If waypointItem IsNot Nothing AndAlso Me.Near(x, y, waypointItem.ScreenX, waypointItem.ScreenY) Then
                        foundItem = waypointItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.DoorArr IsNot Nothing Then
                For Each doorItem As ModItem In Me.DoorArr
                    If doorItem IsNot Nothing AndAlso Me.Near(x, y, doorItem.ScreenX, doorItem.ScreenY) Then
                        foundItem = doorItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.SoundArr IsNot Nothing Then
                For Each soundItem As ModItem In Me.SoundArr
                    If soundItem IsNot Nothing AndAlso Me.Near(x, y, soundItem.ScreenX, soundItem.ScreenY) Then
                        foundItem = soundItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.MerchantArr IsNot Nothing Then
                For Each merchantItem As ModItem In Me.MerchantArr
                    If merchantItem IsNot Nothing AndAlso Me.Near(x, y, merchantItem.ScreenX, merchantItem.ScreenY) Then
                        foundItem = merchantItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.TriggerArr IsNot Nothing Then
                For Each triggerItem As ModItem In Me.TriggerArr
                    If triggerItem IsNot Nothing AndAlso triggerItem.GeometryList IsNot Nothing Then
                        Dim nodeIndex As Integer = 0
                        Dim lastNodeIndex As Integer = triggerItem.GeometryList.Count - 1

                        For nodeIndex = 0 To lastNodeIndex
                            Dim point As Point = CType(If(triggerItem.GeometryList(nodeIndex), Activator.CreateInstance(GetType(Point))), Point)

                            If Me.Near(x, y, point.X, point.Y) Then
                                foundItem = New ModItem(triggerItem.ScreenX, triggerItem.ScreenY, 0.0F, 0.0F, triggerItem.ResRef, triggerItem.Path, triggerItem)
                                foundItem.XPosAccessor = "Geometry(" + StringType.FromInteger(nodeIndex) + ").PointX"
                                foundItem.YPosAccessor = "Geometry(" + StringType.FromInteger(nodeIndex) + ").PointY"
                                foundItem.ItemType = 2032

                                Me.sbarpnlAddlInfo.Text = String.Concat(New String() {
                                    "Node: ",
                                    StringType.FromInteger(nodeIndex),
                                    "   x: ",
                                    StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(point.X), Me.nudXoff.Value), Me.nudXmul.Value))),
                                    "   y: ",
                                    StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(point.Y)), Me.nudYoff.Value), Me.nudYmul.Value)))
                                })

                                foundItem.GeometryList = New ArrayList()
                                foundItem.GeometryList.Add(point)
                                Exit For
                            End If
                        Next
                    End If

                    If foundItem IsNot Nothing Then
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.EncounterArr IsNot Nothing Then
                For Each encounterItem As ModItem In Me.EncounterArr
                    If encounterItem IsNot Nothing Then
                        If encounterItem.GeometryList IsNot Nothing Then
                            Dim nodeIndex As Integer = 0
                            Dim lastNodeIndex As Integer = encounterItem.GeometryList.Count - 1

                            For nodeIndex = 0 To lastNodeIndex
                                Dim point As Point = CType(If(encounterItem.GeometryList(nodeIndex), Activator.CreateInstance(GetType(Point))), Point)

                                If Me.Near(x, y, point.X, point.Y) Then
                                    foundItem = New ModItem(encounterItem.ScreenX, encounterItem.ScreenY, 0.0F, 0.0F, encounterItem.ResRef, encounterItem.Path, encounterItem)
                                    foundItem.XPosAccessor = "Geometry(" + StringType.FromInteger(nodeIndex) + ").X"
                                    foundItem.YPosAccessor = "Geometry(" + StringType.FromInteger(nodeIndex) + ").Y"
                                    foundItem.ItemType = 2040

                                    Me.sbarpnlAddlInfo.Text = String.Concat(New String() {
                                        "Node: ",
                                        StringType.FromInteger(nodeIndex + 1),
                                        "   x: ",
                                        StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(point.X), Me.nudXoff.Value), Me.nudXmul.Value))),
                                        "   y: ",
                                        StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(point.Y)), Me.nudYoff.Value), Me.nudYmul.Value)))
                                    })

                                    foundItem.GeometryList = New ArrayList()
                                    foundItem.GeometryList.Add(point)
                                    Exit For
                                End If
                            Next
                        End If

                        If foundItem Is Nothing AndAlso encounterItem.SpawnPointList IsNot Nothing Then
                            Dim spawnIndex As Integer = 0
                            Dim lastSpawnIndex As Integer = encounterItem.SpawnPointList.Count - 1

                            For spawnIndex = 0 To lastSpawnIndex
                                Dim point As Point = CType(If(encounterItem.SpawnPointList(spawnIndex), Activator.CreateInstance(GetType(Point))), Point)

                                If Me.Near(x, y, point.X, point.Y) Then
                                    foundItem = New ModItem(encounterItem.ScreenX, encounterItem.ScreenY, 0.0F, 0.0F, encounterItem.ResRef, encounterItem.Path + ".SpawnPointList(" + StringType.FromInteger(spawnIndex) + ")", encounterItem)
                                    foundItem.XPosAccessor = "X"
                                    foundItem.YPosAccessor = "Y"
                                    foundItem.ItemType = 12040

                                    Me.sbarpnlAddlInfo.Text = String.Concat(New String() {
                                        "SP: ",
                                        StringType.FromInteger(spawnIndex + 1),
                                        "   x: ",
                                        StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(point.X), Me.nudXoff.Value), Me.nudXmul.Value))),
                                        "   y: ",
                                        StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(point.Y)), Me.nudYoff.Value), Me.nudYmul.Value)))
                                    })

                                    foundItem.GeometryList = New ArrayList()
                                    foundItem.GeometryList.Add(point)
                                    Exit For
                                End If
                            Next
                        End If
                    End If

                    If foundItem IsNot Nothing Then
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing AndAlso Me.CameraArr IsNot Nothing Then
                For Each cameraItem As ModItem In Me.CameraArr
                    If cameraItem IsNot Nothing AndAlso Me.Near(x, y, cameraItem.ScreenX, cameraItem.ScreenY) Then
                        foundItem = cameraItem
                        Exit For
                    End If
                Next
            End If

            If foundItem Is Nothing Then
                Dim entryX As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_X"))
                Dim entryY As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_Y"))

                Dim screenX As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl(Convert.ToSingle(Me.nudXmul.Value) * entryX)))), Me.nudXoff.Value))
                Dim screenY As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl(Convert.ToSingle(Me.nudYmul.Value) * entryY)))), Me.nudYoff.Value)))

                If Me.Near(x, y, screenX, screenY) Then
                    foundItem = New ModItem(screenX, screenY, entryX, entryY, "Mod Entry Point", "")
                    foundItem.ItemType = 5000
                End If
            End If

            Return foundItem
        End Function

		' Token: 0x060008A7 RID: 2215 RVA: 0x0026495C File Offset: 0x0026395C
        ' Token: 0x060008A7 RID: 2215 RVA: 0x0026495C File Offset: 0x0026395C
        Private Sub EditItemProperties(ByVal cmi As ModItem)
            Dim frmModuleItem_Base_Editor As frmModuleItem_Base_Editor = New frmModuleItem_Base_Editor()
            Dim resRef As String = cmi.ResRef

            frmModuleItem_Base_Editor.tbResRef.Text = cmi.ResRef
            frmModuleItem_Base_Editor.tbXPosition.Text = StringType.FromSingle(cmi.X)
            frmModuleItem_Base_Editor.tbYPosition.Text = StringType.FromSingle(cmi.Y)
            frmModuleItem_Base_Editor.tbZPosition.Text = StringType.FromObject(Me.GITfile.GetNodeValue(cmi.ZPosPath))

            Dim itemType As Integer = cmi.ItemType
            Dim flag As Boolean
            Dim listItemCount As Integer

            If itemType = 2027 OrElse itemType = 2051 Then
                frmModuleItem_Base_Editor.XOrientation = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".XOrientation"))
                frmModuleItem_Base_Editor.YOrientation = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".YOrientation"))
                frmModuleItem_Base_Editor.SetupOrientationIndicators()

            ElseIf itemType = 2058 Then
                frmModuleItem_Base_Editor.XOrientation = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".XOrientation"))
                frmModuleItem_Base_Editor.YOrientation = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".YOrientation"))
                frmModuleItem_Base_Editor.SetupOrientationIndicators()

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbWPLinkedTo, cmi.Path + ".LinkedTo")
                Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbWpLocalizedName, cmi.Path + ".LocalizedName", Me.g_clsDialogTlk)
                Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbWpDescription, cmi.Path + ".Description", Me.g_clsDialogTlk)
                Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbWpMapNote, cmi.Path + ".MapNote", Me.g_clsDialogTlk)

                frmModuleItem_Base_Editor.chkbHasMapNote.Checked = BooleanType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".HasMapNote"))
                frmModuleItem_Base_Editor.chkbMapNoteEnabled.Checked = BooleanType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".MapNoteEnabled"))

            ElseIf itemType = 2042 Then
                frmModuleItem_Base_Editor.Bearing(2042) = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".Bearing"))

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedTo, cmi.Path + ".LinkedTo")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule")
                Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin", Me.g_clsDialogTlk)

                frmModuleItem_Base_Editor.cmbxDoorLinkedToFlags.SelectedIndex = IntegerType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".LinkedToFlags"))
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")

            ElseIf itemType = 2032 Then
                Dim clsGFF As clsGFF = Nothing

                If File.Exists(Me.g_ProjectPath + "\" + cmi.FileName) Then
                    Dim fileStream As FileStream = File.OpenRead(Me.g_ProjectPath + "\" + cmi.FileName)
                    clsGFF = New clsGFF(fileStream, Me.KotorVersionIndex, True)
                Else
                    Dim biffresourceData As Byte() = frmMain.GetBIFFResourceData(Me.KotorVersionIndex, cmi.ResRef, 2032)
                    If biffresourceData IsNot Nothing Then
                        clsGFF = New clsGFF(biffresourceData, Me.KotorVersionIndex, True)
                    End If
                End If

                If clsGFF IsNot Nothing Then
                    Console.WriteLine(ObjectType.StrCatObj("Trigger type: ", clsGFF.GetNodeValue("Type")))
                    flag = ObjectType.ObjTst(clsGFF.GetNodeValue("Type"), 1, False) = 0

                    If Not flag Then
                        frmModuleItem_Base_Editor.DisableLinkedToFields()
                    End If
                End If

                If Me.GITfile.VerifyNodeExists(cmi.Path + ".LinkedToFlags") Then
                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".LinkedTo") Then
                        Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedTo, cmi.Path + ".LinkedTo")
                    End If

                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".LinkedToModule") Then
                        Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule")
                    End If

                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".TransitionDestin") Then
                        Me.GITfile.SetTextBoxFromCExoLocStringNodeValue(frmModuleItem_Base_Editor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin", Me.g_clsDialogTlk)
                    End If

                    frmModuleItem_Base_Editor.cmbxDoorLinkedToFlags.SelectedIndex = IntegerType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".LinkedToFlags"))
                End If

                If cmi.Parent IsNot Nothing Then
                    frmModuleItem_Base_Editor.tbXPosition.Text = StringType.FromSingle(cmi.Parent.X)
                    frmModuleItem_Base_Editor.tbYPosition.Text = StringType.FromSingle(cmi.Parent.Y)
                    frmModuleItem_Base_Editor.tbZPosition.Text = StringType.FromObject(Me.GITfile.GetNodeValue(cmi.Parent.ZPosPath))
                End If

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")

            ElseIf itemType = 2044 Then
                frmModuleItem_Base_Editor.Bearing(2044) = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".Bearing"))
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")

            ElseIf itemType = 6 Then
                Dim gfftype As GFFType17 = CType(Me.GITfile.GetNodeValue(cmi.Path + ".Position"), GFFType17)
                frmModuleItem_Base_Editor.tbZPosition.Text = StringType.FromSingle(gfftype.f3)

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbCamFieldOfView, cmi.Path + ".FieldOfView")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbCamHeight, cmi.Path + ".Height")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbCamMicRange, cmi.Path + ".MicRange")
                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbCamPitch, cmi.Path + ".Pitch")

                Dim gfftype2 As GFFType16 = CType(Me.GITfile.GetNodeValue(cmi.Path + ".Orientation"), GFFType16)
                frmModuleItem_Base_Editor.CameraOrientationQuat = gfftype2

                If Me.GITfile.VerifyNodeExists(cmi.Path + ".EAOrientation") Then
                    frmModuleItem_Base_Editor.CameraOrientationEulerAngles = CType(Me.GITfile.GetNodeValue(cmi.Path + ".EAOrientation"), GFFType17)
                Else
                    frmModuleItem_Base_Editor.nudCamOrientationX.Value = 0D
                    frmModuleItem_Base_Editor.nudCamOrientationY.Value = 0D
                    frmModuleItem_Base_Editor.nudCamOrientationZ.Value = 0D
                    frmModuleItem_Base_Editor.ErrorProvider1.SetError(frmModuleItem_Base_Editor.nudCamOrientationX, "Unable to represent Quaternion as Euler angles; choose new values")
                End If

            ElseIf itemType = 2040 Then
                If cmi.Parent IsNot Nothing Then
                    frmModuleItem_Base_Editor.tbXPosition.Text = StringType.FromSingle(cmi.Parent.X)
                    frmModuleItem_Base_Editor.tbYPosition.Text = StringType.FromSingle(cmi.Parent.Y)
                    frmModuleItem_Base_Editor.tbZPosition.Text = StringType.FromObject(Me.GITfile.GetNodeValue(cmi.Parent.ZPosPath))
                End If

                Me.GITfile.SetTextBoxToNodeValue(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")

                listItemCount = Me.GITfile.GetListItemCount(cmi.Path + ".SpawnPointList")

                Dim array As GFFType16() = New GFFType16(listItemCount - 1) {}
                Dim num As Integer = 0
                Dim num2 As Integer = listItemCount - 1

                For i As Integer = num To num2
                    array(i) = New GFFType16()
                    array(i).X = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(i) + ").X"))
                    array(i).Y = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(i) + ").Y"))
                    array(i).Z = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(i) + ").Z"))
                    array(i).W = SingleType.FromObject(Me.GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(i) + ").Orientation"))
                Next

                frmModuleItem_Base_Editor.SpawnPoints = array
            End If

            frmModuleItem_Base_Editor.SetupForItemType(cmi.ItemType)
            frmModuleItem_Base_Editor.ShowDialog(Me)

            If frmModuleItem_Base_Editor.DialogResult = DialogResult.OK Then
                Dim itemType2 As Integer = cmi.ItemType

                If itemType2 = 2040 OrElse itemType2 = 2032 Then
                    If cmi.Parent IsNot Nothing Then
                        Me.GITfile.SetNodeValue(cmi.Parent.XPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbXPosition.Text))
                        Me.GITfile.SetNodeValue(cmi.Parent.YPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbYPosition.Text))
                        Me.GITfile.SetNodeValue(cmi.Parent.ZPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbZPosition.Text))
                    Else
                        Me.GITfile.SetNodeValue(cmi.XPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbXPosition.Text))
                        Me.GITfile.SetNodeValue(cmi.YPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbYPosition.Text))
                        Me.GITfile.SetNodeValue(cmi.ZPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbZPosition.Text))
                    End If

                    Me.GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", Strings.Trim(frmModuleItem_Base_Editor.tbResRef.Text))

                    If StringType.StrCmp(frmModuleItem_Base_Editor.tbResRef.Text, resRef, False) <> 0 Then
                        Me.Draw()
                        Me.BuildModuleTreeView()
                    End If

                ElseIf itemType2 = 6 Then
                    Dim gfftype3 As GFFType17 = New GFFType17()
                    gfftype3.f1 = SingleType.FromString(frmModuleItem_Base_Editor.tbXPosition.Text)
                    gfftype3.f2 = SingleType.FromString(frmModuleItem_Base_Editor.tbYPosition.Text)
                    gfftype3.f3 = SingleType.FromString(frmModuleItem_Base_Editor.tbZPosition.Text)

                    Me.GITfile.SetNodeValue(cmi.Path + ".Position", gfftype3)

                    Dim gfftype4 As GFFType16 = frmModuleItem_Base_Editor.CameraOrientationQuat
                    Me.GITfile.SetNodeValue(cmi.Path + ".Orientation", gfftype4)

                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".EAOrientation") Then
                        Me.GITfile.SetNodeValue(cmi.Path + ".EAOrientation", frmModuleItem_Base_Editor.CameraOrientationEulerAngles)
                    Else
                        Me.GITfile.AddFieldToStruct(cmi.Path, "EAOrientation", 17, frmModuleItem_Base_Editor.CameraOrientationEulerAngles)
                    End If

                Else
                    Me.GITfile.SetNodeValue(cmi.XPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbXPosition.Text))
                    Me.GITfile.SetNodeValue(cmi.YPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbYPosition.Text))
                    Me.GITfile.SetNodeValue(cmi.ZPosPath, SingleType.FromString(frmModuleItem_Base_Editor.tbZPosition.Text))
                    Me.GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", Strings.Trim(frmModuleItem_Base_Editor.tbResRef.Text))

                    If StringType.StrCmp(frmModuleItem_Base_Editor.tbResRef.Text, resRef, False) <> 0 Then
                        Me.Draw()
                        Me.BuildModuleTreeView()
                    End If
                End If

                Dim itemType3 As Integer = cmi.ItemType

                If itemType3 = 2027 OrElse itemType3 = 2051 Then
                    Me.GITfile.SetNodeValue(cmi.Path + ".XOrientation", frmModuleItem_Base_Editor.XOrientation)
                    Me.GITfile.SetNodeValue(cmi.Path + ".YOrientation", frmModuleItem_Base_Editor.YOrientation)

                ElseIf itemType3 = 2042 OrElse itemType3 = 2040 OrElse itemType3 = 2032 Then
                    If cmi.ItemType = 2042 Then
                        Me.GITfile.SetNodeValue(cmi.Path + ".Bearing", frmModuleItem_Base_Editor.Bearing(2042))
                        Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")
                    End If

                    If flag Then
                        Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbDoorLinkedTo, cmi.Path + ".LinkedTo")
                        Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule")
                        Me.GITfile.SetCExoLocStringNodeValueFromTextBox(frmModuleItem_Base_Editor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin", 0)
                        Me.GITfile.SetNodeValue(cmi.Path + ".LinkedToFlags", frmModuleItem_Base_Editor.cmbxDoorLinkedToFlags.SelectedIndex)
                    End If

                    If cmi.ItemType = 2040 Then
                        Dim num3 As Integer = 0
                        Dim num4 As Integer = listItemCount - 1

                        For j As Integer = num3 To num4
                            Me.GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(j) + ").X", frmModuleItem_Base_Editor.SpawnPoints(j).X)
                            Me.GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(j) + ").Y", frmModuleItem_Base_Editor.SpawnPoints(j).Y)
                            Me.GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(j) + ").Z", frmModuleItem_Base_Editor.SpawnPoints(j).Z)
                            Me.GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(j) + ").Orientation", frmModuleItem_Base_Editor.SpawnPoints(j).W)
                        Next
                    End If

                ElseIf itemType3 = 2044 Then
                    Me.GITfile.SetNodeValue(cmi.Path + ".Bearing", frmModuleItem_Base_Editor.Bearing(2044))

                ElseIf itemType3 = 6 Then
                    Me.GITfile.SetNodeValue(cmi.Path + ".FieldOfView", SingleType.FromString(frmModuleItem_Base_Editor.tbCamFieldOfView.Text))
                    Me.GITfile.SetNodeValue(cmi.Path + ".Height", SingleType.FromString(frmModuleItem_Base_Editor.tbCamHeight.Text))
                    Me.GITfile.SetNodeValue(cmi.Path + ".MicRange", SingleType.FromString(frmModuleItem_Base_Editor.tbCamMicRange.Text))
                    Me.GITfile.SetNodeValue(cmi.Path + ".Pitch", SingleType.FromString(frmModuleItem_Base_Editor.tbCamPitch.Text))

                ElseIf itemType3 = 2058 Then
                    Me.GITfile.SetNodeValue(cmi.Path + ".XOrientation", frmModuleItem_Base_Editor.XOrientation)
                    Me.GITfile.SetNodeValue(cmi.Path + ".YOrientation", frmModuleItem_Base_Editor.YOrientation)
                    Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbTag, cmi.Path + ".Tag")
                    Me.GITfile.SetCExoLocStringNodeValueFromTextBox(frmModuleItem_Base_Editor.tbWpLocalizedName, cmi.Path + ".LocalizedName", frmModuleItem_Base_Editor.NameLang)
                    Me.GITfile.SetNodeValueFromTextBox(frmModuleItem_Base_Editor.tbWPLinkedTo, cmi.Path + ".LinkedTo")
                    Me.GITfile.SetCExoLocStringNodeValueFromTextBox(frmModuleItem_Base_Editor.tbWpDescription, cmi.Path + ".Description", frmModuleItem_Base_Editor.NameLang)

                    If Me.GITfile.VerifyNodeExists(cmi.Path + ".MapNote") Then
                        Me.GITfile.SetCExoLocStringNodeValueFromTextBox(frmModuleItem_Base_Editor.tbWpMapNote, cmi.Path + ".MapNote", frmModuleItem_Base_Editor.NameLang)
                    End If

                    Me.GITfile.SetNodeValue(cmi.Path + ".HasMapNote", frmModuleItem_Base_Editor.chkbHasMapNote.Checked)
                    Me.GITfile.SetNodeValue(cmi.Path + ".MapNoteEnabled", frmModuleItem_Base_Editor.chkbMapNoteEnabled.Checked)
                End If
            End If
        End Sub

		' Token: 0x060008A8 RID: 2216 RVA: 0x00265B0C File Offset: 0x00264B0C
		Private Function GetTreeNodesModItem(node As ModItemTvNode) As ModItem
			Dim itemType As Integer = node.ItemType
			If itemType = 2027 Then
				Return Me.CreatureArr(node.ArrayIndex)
			End If
			If itemType = 2042 Then
				Return Me.DoorArr(node.ArrayIndex)
			End If
			If itemType = 2044 Then
				Return Me.PlaceableArr(node.ArrayIndex)
			End If
			If itemType = 2035 Then
				Return Me.SoundArr(node.ArrayIndex)
			End If
			If itemType = 2051 Then
				Return Me.MerchantArr(node.ArrayIndex)
			End If
			If itemType = 2058 Then
				Return Me.WaypointArr(node.ArrayIndex)
			End If
			If itemType = 2032 Then
				Return Me.TriggerArr(node.ArrayIndex)
			End If
			If itemType = 2040 Then
				Return Me.EncounterArr(node.ArrayIndex)
			End If
			If itemType = 6 Then
				Return Me.CameraArr(node.ArrayIndex)
			End If
			Dim modItem As ModItem
			Return modItem
		End Function

		' Token: 0x060008A9 RID: 2217 RVA: 0x00265BE4 File Offset: 0x00264BE4
		Private Function FileExistsInProject(FileName As String) As Boolean
			Return File.Exists(Me.g_ProjectPath + "\" + FileName)
		End Function

		' Token: 0x060008AA RID: 2218 RVA: 0x00265C08 File Offset: 0x00264C08
		Private Function FileExistsInUserPalette(FileName As String) As Boolean
			Return File.Exists(Me.g_UserPalettePath + "\" + FileName)
		End Function

		' Token: 0x060008AB RID: 2219 RVA: 0x00265C2C File Offset: 0x00264C2C
		Private Function FileExistsInGlobalTemplates(FileName As String) As Boolean
			Return File.Exists(Me.g_GlobalTemplatesPath + "\" + FileName)
		End Function

		' Token: 0x060008AC RID: 2220 RVA: 0x00265C50 File Offset: 0x00264C50
		Private Function FileExistsInTemplatesBif(FileName As String) As Boolean
			Return Me.htTemplateBifFiles.ContainsKey(FileName)
		End Function

' Token: 0x060008AD RID: 2221 RVA: 0x00265C6C File Offset: 0x00264C6C
        Private Sub EditItem(ByVal cmi As ModItem)
            If cmi Is Nothing Then
                Return
            End If

            If Not Me.FileExistsInProject(cmi.FileName) Then
                Dim existsInUserPalette As Boolean = Me.FileExistsInUserPalette(cmi.FileName)
                Dim existsInGlobalTemplates As Boolean = Me.FileExistsInGlobalTemplates(cmi.FileName)
                Dim existsInTemplatesBif As Boolean = Me.FileExistsInTemplatesBif(cmi.FileName)

                If Not existsInUserPalette AndAlso Not existsInGlobalTemplates AndAlso Not existsInTemplatesBif Then
                    Interaction.MsgBox("This item cannot be edited, as the file for it exists in neither the project, user palette, Global Templates directory, nor in the templates.bif file." & vbLf & "The file was most likely accidentally moved or deleted from the project.", MsgBoxStyle.Critical, "Item file missing")
                    Return
                End If

                Dim frmModuleEditor_MissingItemSelector As frmModuleEditor_MissingItemSelector = New frmModuleEditor_MissingItemSelector()
                frmModuleEditor_MissingItemSelector.UserPaletteAvailable = existsInUserPalette
                frmModuleEditor_MissingItemSelector.TemplatesBifAvailable = existsInTemplatesBif
                frmModuleEditor_MissingItemSelector.GlobalTemplatesAvailable = existsInGlobalTemplates

                If existsInUserPalette Xor existsInGlobalTemplates Xor existsInTemplatesBif Then
                    frmModuleEditor_MissingItemSelector.UserPaletteChecked = existsInUserPalette
                    frmModuleEditor_MissingItemSelector.TemplatesBifChecked = existsInTemplatesBif
                    frmModuleEditor_MissingItemSelector.GlobalTemplatesChecked = existsInGlobalTemplates
                End If

                If frmModuleEditor_MissingItemSelector.ShowDialog(Me) = DialogResult.Cancel Then
                    Return
                End If

                Dim frmPromptForString As frmPromptForString = New frmPromptForString("Create new instance", "Enter name for new instance (16 character max, no extension)", cmi.ResRef)
                frmPromptForString.tbValue.MaxLength = 16

                Dim validationMessage As String = ""

                Do
                    If frmPromptForString.ShowDialog(Me) = DialogResult.Cancel Then
                        Return
                    End If

                    Dim newFileName As String = frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension

                    If Me.FileExistsInProject(newFileName) Then
                        validationMessage = "A file with that name already exists. Please choose another."
                    ElseIf Me.FileExistsInUserPalette(newFileName) Then
                        validationMessage = "You cannot use the name of the template from the User Palette. Please choose another."
                    ElseIf Me.FileExistsInGlobalTemplates(newFileName) Then
                        validationMessage = "You cannot use the name of the template from the Global Templates. Please choose another."
                    ElseIf Me.FileExistsInTemplatesBif(newFileName) Then
                        validationMessage = "You cannot use the name of the template from Templates.bif. Please choose another."
                    Else
                        validationMessage = ""
                    End If

                    If StringType.StrCmp(validationMessage, "", False) <> 0 Then
                        Interaction.MsgBox(validationMessage, MsgBoxStyle.Exclamation, "Name error")
                    End If
                Loop While StringType.StrCmp(validationMessage, "", False) <> 0

                Dim newResRef As String = frmPromptForString.tbValue.Text.Trim()
                Dim destinationFile As String = Me.g_ProjectPath + "\" + newResRef + cmi.FileExtension

                If frmModuleEditor_MissingItemSelector.TemplatesBifChecked Then
                    Try
                        frmMain.ExportBiffResource(Me.KotorVersionIndex, cmi.ResRef, cmi.ItemType, destinationFile)
                    Catch ex As NotSupportedException
                        ' Preserve original decompiled behaviour: continue even if export reports NotSupportedException.
                    End Try
                ElseIf frmModuleEditor_MissingItemSelector.GlobalTemplatesChecked Then
                    File.Copy(Me.g_GlobalTemplatesPath + "\" + cmi.FileName, destinationFile)
                Else
                    File.Copy(Me.g_UserPalettePath + "\" + cmi.FileName, destinationFile)
                End If

                cmi.ResRef = newResRef
                Me.GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", cmi.ResRef)
                Me.Draw()
                Me.BuildModuleTreeView()
            End If

            Select Case cmi.ItemType
                Case 2025, 2027, 2032, 2035, 2042, 2044, 2051, 2058
                    Dim editorError As System.Exception = Nothing
                    Dim filePath As String = Me.g_ProjectPath + "\" + cmi.FileName
                    Dim fileStream As FileStream = Nothing

                    Try
                        fileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)

                        Select Case cmi.ItemType
                            Case 2025
                                Dim clsUTI As clsUTI = New clsUTI(fileStream, Me.KotorVersionIndex)
                                Dim frmUTI_Editor As frmUTI_Editor = New frmUTI_Editor(clsUTI, Me.KotorVersionIndex, True, filePath)
                                frmUTI_Editor.SetFormName(cmi.FileName)
                                frmUTI_Editor.Show()

                            Case 2027
                                Dim clsUTC As clsUTC = New clsUTC(fileStream, Me.KotorVersionIndex)
                                Dim frmUTC_Editor As frmUTC_Editor = New frmUTC_Editor(clsUTC, Me.KotorVersionIndex, True, filePath)
                                frmUTC_Editor.SetFormName(cmi.FileName)
                                frmUTC_Editor.Show()

                            Case 2032
                                Dim clsUTT As clsUTT = New clsUTT(fileStream, Me.KotorVersionIndex)
                                Dim frmUTT_Editor As frmUTT_Editor = New frmUTT_Editor(clsUTT, Me.KotorVersionIndex, True, filePath)
                                frmUTT_Editor.SetFormName(cmi.FileName)
                                frmUTT_Editor.Show()

                            Case 2035
                                Dim clsUTS As clsUTS = New clsUTS(fileStream, Me.KotorVersionIndex)
                                Dim frmUTS_Editor As frmUTS_Editor = New frmUTS_Editor(clsUTS, Me.KotorVersionIndex, True, filePath)
                                frmUTS_Editor.g_ProjectPath = Me.g_ProjectPath
                                frmUTS_Editor.SetFormName(cmi.FileName)
                                frmUTS_Editor.Show()

                            Case 2042
                                Dim clsUTD As clsUTD = New clsUTD(fileStream, Me.KotorVersionIndex)
                                Dim frmUTD_Editor As frmUTD_Editor = New frmUTD_Editor(clsUTD, Me.KotorVersionIndex, True, filePath)
                                frmUTD_Editor.SetFormName(cmi.FileName)
                                frmUTD_Editor.Show()

                            Case 2044
                                Dim clsUTP As clsUTP = New clsUTP(fileStream, Me.KotorVersionIndex)
                                Dim frmUTP_Editor As frmUTP_Editor = New frmUTP_Editor(clsUTP, Me.KotorVersionIndex, True, filePath)
                                frmUTP_Editor.SetFormName(cmi.FileName)
                                frmUTP_Editor.Show()

                            Case 2051
                                Dim clsUTM As clsUTM = New clsUTM(fileStream, Me.KotorVersionIndex)
                                Dim frmUTM_Editor As frmUTM_Editor = New frmUTM_Editor(clsUTM, Me.KotorVersionIndex, True, filePath)
                                frmUTM_Editor.SetFormName(cmi.FileName)
                                frmUTM_Editor.Show()

                            Case 2058
                                Dim clsUTW As clsUTW = New clsUTW(fileStream, Me.KotorVersionIndex)
                                Dim frmUTW_Editor As frmUTW_Editor = New frmUTW_Editor(clsUTW, Me.KotorVersionIndex, True, filePath)
                                frmUTW_Editor.SetFormName(cmi.FileName)
                                frmUTW_Editor.Show()
                        End Select

                    Catch ex As System.Exception
                        editorError = ex
                    End Try

                    If editorError IsNot Nothing Then
                        Interaction.MsgBox(editorError.Message, MsgBoxStyle.Critical, "Module Editing Error")
                    End If

                    Return
            End Select

            Interaction.MsgBox("No editor is available for that kind of item", MsgBoxStyle.Exclamation, Nothing)
        End Sub

		' Token: 0x060008AE RID: 2222 RVA: 0x0026646C File Offset: 0x0026546C
		Private Function NormalizeRectangle(selectionRect As Rectangle) As Rectangle
			Dim rectangle As Rectangle
			rectangle.Size = selectionRect.Size
			If selectionRect.Width < 0 Then
				rectangle.Width *= -1
				rectangle.X = selectionRect.X - rectangle.Width
			Else
				rectangle.X = selectionRect.X
			End If
			If selectionRect.Height < 0 Then
				rectangle.Height *= -1
				rectangle.Y = selectionRect.Y - rectangle.Height
			Else
				rectangle.Y = selectionRect.Y
			End If
			Return rectangle
		End Function

		' Token: 0x060008AF RID: 2223 RVA: 0x00266508 File Offset: 0x00265508
		Private Sub CreateTrap(TemplateResRef As String, Center As Point)
			Dim gff_Struct As GFF_Struct = New GFF_Struct(8, 1)
			Dim gfflist As GFFList = New GFFList(8)
			Dim listItemCount As Integer = Me.GITfile.GetListItemCount("TriggerList")
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", TemplateResRef)
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Center.X), Me.nudXoff.Value), Me.nudXmul.Value)))
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(Center.Y)), Me.nudYoff.Value), Me.nudYmul.Value)))
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
			gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "XOrientation", 0F)
			gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
			gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_float, "ZOrientation", 0F)
			gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_List, "Geometry", New GFFList(0))
			Me.GITfile.AddListElement("TriggerList", gff_Struct)
			Dim gff_Struct2 As GFF_Struct = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", -1.5F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 0F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", -1.06066F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", -1.06066F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 0F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", -1.5F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 1.06066F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", -1.06066F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 1.5F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 0F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 1.06066F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 1.06066F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 0F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 1.5F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
			gff_Struct2 = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", -1.06066F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 1.06066F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", gff_Struct2)
		End Sub

		' Token: 0x060008B0 RID: 2224 RVA: 0x00266A84 File Offset: 0x00265A84
		Private Sub CreateTrigger(TemplateResRef As String, PointList As ArrayList)
			Dim gff_Struct As GFF_Struct = New GFF_Struct(8, 1)
			Dim gfflist As GFFList = New GFFList(PointList.Count - 1)
			Dim point As Point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim x As Integer = point.X
			point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim num As Integer = Me.invy(point.Y)
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", TemplateResRef)
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudYoff.Value), Me.nudYmul.Value)))
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
			gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "XOrientation", 0F)
			gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
			gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_float, "ZOrientation", 0F)
			gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_List, "Geometry", New GFFList(0))
			Me.GITfile.AddListElement("TriggerList", gff_Struct)
			Dim gff_Struct2 As GFF_Struct = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", 0F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", 0F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
			Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(Me.GITfile.GetListItemCount("TriggerList") - 1) + ").Geometry", gff_Struct2)
			Dim num2 As Integer = 1
			Dim num3 As Integer = PointList.Count - 1
			For i As Integer = num2 To num3
				gff_Struct2 = New GFF_Struct(3, 3)
				gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "PointX", SingleType.FromObject(ObjectType.DivObj(ObjectType.SubObj(LateBinding.LateGet(PointList(i), Nothing, "X", New Object(-1) {}, Nothing, Nothing), x), Me.nudXmul.Value)))
				gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "PointY", Convert.ToSingle(Decimal.Divide(New Decimal(Me.invy(IntegerType.FromObject(LateBinding.LateGet(PointList(i), Nothing, "Y", New Object(-1) {}, Nothing, Nothing))) - num), Me.nudYmul.Value)))
				gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "PointZ", 0F)
				Me.GITfile.AddListElement("TriggerList(" + StringType.FromInteger(Me.GITfile.GetListItemCount("TriggerList") - 1) + ").Geometry", gff_Struct2)
			Next
		End Sub

		' Token: 0x060008B1 RID: 2225 RVA: 0x00266E08 File Offset: 0x00265E08
		Private Sub CreateEncounter(TemplateResRef As String, PointList As ArrayList)
			Dim gff_Struct As GFF_Struct = New GFF_Struct(6, 7)
			Dim gfflist As GFFList = New GFFList(PointList.Count - 1)
			Dim point As Point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim x As Integer = point.X
			point = CType((If(PointList(0), Activator.CreateInstance(GetType(Point)))), Point)
			Dim num As Integer = Me.invy(point.Y)
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", TemplateResRef)
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudYoff.Value), Me.nudYmul.Value)))
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
			gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_List, "Geometry", New GFFList(0))
			gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_List, "SpawnPointList", New GFFList(0))
			Me.GITfile.AddListElement("Encounter List", gff_Struct)
			Dim gff_Struct2 As GFF_Struct = New GFF_Struct(3, 3)
			gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "X", 0F)
			gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "Y", 0F)
			gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "Z", 0F)
			Me.GITfile.AddListElement("Encounter List(" + StringType.FromInteger(Me.GITfile.GetListItemCount("Encounter List") - 1) + ").Geometry", gff_Struct2)
			Dim num2 As Integer = 1
			Dim num3 As Integer = PointList.Count - 1
			For i As Integer = num2 To num3
				gff_Struct2 = New GFF_Struct(3, 3)
				gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_float, "X", SingleType.FromObject(ObjectType.DivObj(ObjectType.SubObj(LateBinding.LateGet(PointList(i), Nothing, "X", New Object(-1) {}, Nothing, Nothing), x), Me.nudXmul.Value)))
				gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(New Decimal(Me.invy(IntegerType.FromObject(LateBinding.LateGet(PointList(i), Nothing, "Y", New Object(-1) {}, Nothing, Nothing))) - num), Me.nudYmul.Value)))
				gff_Struct2.fields(2) = New GFF_Field(GFFField.GFF_float, "Z", 0F)
				Me.GITfile.AddListElement("Encounter List(" + StringType.FromInteger(Me.GITfile.GetListItemCount("Encounter List") - 1) + ").Geometry", gff_Struct2)
			Next
		End Sub

		' Token: 0x060008B2 RID: 2226 RVA: 0x00267148 File Offset: 0x00266148
		Private Sub BuildModFile()
			Dim arrayList As ArrayList = New ArrayList()
			Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
			frmProgressMeter.maxvalue = 6
			frmProgressMeter.message = "Building Module"
			frmProgressMeter.status = "Add definition files"
			frmProgressMeter.stepAmount = 1
			frmProgressMeter.Location = New utilWindowRelativePositioner(Me, frmProgressMeter).getConcentric()
			frmProgressMeter.Show()
			Me.tbHelp.Text = "Starting module build"
			Me.miSave_Click(Nothing, Nothing)
			arrayList.Add(Me.g_ProjectPath + "\" + Me.g_MapName + ".git")
			arrayList.Add(Me.g_ProjectPath + "\" + Me.g_MapName + ".are")
			arrayList.Add(Me.g_ProjectPath + "\" + Me.g_MapName + ".pth")
			arrayList.Add(Me.g_ProjectPath + "\module.ifo")
			frmProgressMeter.stepUp()
			frmProgressMeter.status = "Add instance files"
			frmProgressMeter.stepUp()
			Dim num As Integer
			Dim num2 As Integer
			Me.BuildModuleFileList(Me.CreatureArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.ItemArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.DoorArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.MerchantArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.PlaceableArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.TriggerArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.SoundArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.WaypointArr, arrayList, num, num2)
			Me.BuildModuleFileList(Me.EncounterArr, arrayList, num, num2)
			Console.WriteLine("Template Refs: " + StringType.FromInteger(num) + "  Instances: " + StringType.FromInteger(num2))
			frmProgressMeter.status = "Add support files"
			frmProgressMeter.stepUp()
			Me.AddModuleFileNamesToList(Me.g_ProjectPath, arrayList, "*.ncs")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath, arrayList, "*.dlg")
			frmProgressMeter.status = "Add extras files"
			frmProgressMeter.stepUp()
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utc")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utd")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.uti")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utm")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utp")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utt")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.uts")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.utw")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.ute")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.tga")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.mdl")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.mdx")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.pwk")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.lyt")
			Me.AddModuleFileNamesToList(Me.g_ProjectPath + "\extras", arrayList, "*.2da")
			Dim array As String() = New String(arrayList.Count - 1 + 1 - 1) {}
			Dim num3 As Integer = 0
			Dim num4 As Integer = arrayList.Count - 1
			For i As Integer = num3 To num4
				array(i) = StringType.FromObject(arrayList(i))
			Next
			frmProgressMeter.status = "Create Mod file"
			frmProgressMeter.stepUp()
			Me.gModuleEditorSettings = ModuleEditorProjectSettings.GetSettings(Me.g_ProjectPath)
			If Not Me.gModuleEditorSettings.ModuleEditorModOutputPath.ToLower().EndsWith(".mod") Then
				Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", Me.gModuleEditorSettings.ModuleEditorModOutputPath, "", "Select the destination and name for your Mod file", "mod", False, True))
				If Not text.ToLower().EndsWith(".mod") Then
					Return
				End If
				Me.gModuleEditorSettings.ModuleEditorModOutputPath = text
				ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			End If
			Dim clsERF As clsERF = New clsERF(Me.gModuleEditorSettings.ModuleEditorModOutputPath, "MOD", Convert.ToUInt32(0), Nothing, array)
			Me.tbHelp.Text = "Module build complete"
			frmProgressMeter.Close()
		End Sub

		' Token: 0x060008B3 RID: 2227 RVA: 0x00267618 File Offset: 0x00266618
		Private Sub frmModule_Editor_Load(sender As Object, e As EventArgs)
			Dim settings As Options = UserSettings.GetSettings()
			Me.PositionWindow(Me.[GetType]().Name)
			Me.dModuleElementIndicatorSize = settings.ModuleEditorModuleElementIndicatorSize
			Me.bConfirmDeletes = settings.bModuleEditorConfirmDeletes
			Me.bShowLocatorRay = settings.bModuleEditorShowLocatorRay
			Me.tbHelp.Text = ""
		End Sub

		' Token: 0x060008B4 RID: 2228 RVA: 0x00267670 File Offset: 0x00266670
		Private Sub frmModule_Editor_Closing(sender As Object, e As CancelEventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.bModuleLoadedOK Then
				Me.SaveSettings(Me.[GetType]().Name)
				UserSettings.SaveSettings(Me.CurrentSettings)
				If StringType.StrCmp(Me.g_ProjectPath, "", False) <> 0 Then
					Me.gModuleEditorSettings.LastScrollPosX = 0 - Me.Panel1.AutoScrollPosition.X
					Me.gModuleEditorSettings.LastScrollPosY = 0 - Me.Panel1.AutoScrollPosition.Y
					ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
				End If
			End If
		End Sub

		' Token: 0x060008B5 RID: 2229 RVA: 0x0026770C File Offset: 0x0026670C
		Private Sub pbox_MouseDown(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left OrElse e.Button = MouseButtons.Right Then
				Dim obj As Object = CType(sender, PictureBox)
				Dim modItem As ModItem = Me.FindModItem(CType(sender, PictureBox))
				Dim obj2 As Object = obj
				Dim type As Type = Nothing
				Dim text As String = "PointToClient"
				Dim array As Object() = New Object(0) {}
				Dim array2 As Object() = array
				Dim num As Integer = 0
				Dim obj3 As Object = obj
				array2(num) = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj3, Nothing, "MousePosition", New Object(-1) {}, Nothing, Nothing))
				Dim array3 As Object() = array
				Dim array4 As Object() = array3
				Dim array5 As String() = Nothing
				Dim array6 As Boolean() = New Boolean() { True }
				Dim obj4 As Object = LateBinding.LateGet(obj2, type, text, array4, array5, array6)
				If array6(0) Then
					LateBinding.LateSetComplex(obj3, Nothing, "MousePosition", New Object() { RuntimeHelpers.GetObjectValue(array3(0)) }, Nothing, True, False)
				End If
				Dim point As Point = CType((If(obj4, Activator.CreateInstance(GetType(Point)))), Point)
				Dim num2 As Integer = point.X
				Dim num3 As Integer = point.Y
				Me.tbMouseX.Text = StringType.FromInteger(num2)
				Me.tbMouseY.Text = StringType.FromInteger(num3)
				Dim point2 As Point = New Point(num2, num3)
				Me.gLastMousePos = point2
				point2 = New Point(num2, num3)
				Me.g_LastMouseDownPos = point2
				If modItem IsNot Nothing Then
					Me.CurrentModItem = modItem
					Me.IndicatedModItem = modItem
					If e.Button = MouseButtons.Left Then
						If modItem.ItemType = 2032 Then
							If modItem.FileName.StartsWith("g_t_") Then
								Me.tbHelp.Text = "Move the mouse to reposition this trap. The trap is not redrawn while dragging. Right-click for the pop-up menu."
							Else
								Me.tbHelp.Text = "Move the mouse to reposition this node of the trigger. Hold down the shift key to move the whole trigger region. The trigger is not redrawn while dragging. Right-click for the pop-up menu."
							End If
						Else
							Me.tbHelp.Text = "Move the mouse to reposition this item. Right-click for the pop-up menu."
						End If
						Me.sbarpnlDesc.Text = modItem.ResRef
						Me.CurrentModItemBmp = New Bitmap(3, 3)
						Dim graphics As Graphics = Graphics.FromImage(Me.CurrentModItemBmp)
						Dim rectangle As Rectangle = New Rectangle(modItem.ScreenX - 1, modItem.ScreenY - 1, 3, 3)
						Dim rectangle2 As Rectangle = New Rectangle(0, 0, 3, 3)
						graphics.DrawImage(Me.bmp, rectangle2, rectangle, GraphicsUnit.Pixel)
					End If
					If e.Button = MouseButtons.Right AndAlso modItem.ItemType <> 5000 Then
						Me.cmMapSurfaceItems.MenuItems(Me.cmMapSurfaceItems.MenuItems.IndexOf(Me.cmiEditGFFFile)).Visible = modItem.ItemType <> 6 AndAlso modItem.ItemType <> 12040
						Me.cmMapSurfaceItems.MenuItems(Me.cmMapSurfaceItems.MenuItems.IndexOf(Me.cmiProperties)).Visible = modItem.ItemType <> 12040
						Me.cmMapSurfaceItems.MenuItems(Me.cmMapSurfaceItems.MenuItems.IndexOf(Me.cmiAddNewSpawnPoint)).Visible = modItem.ItemType = 2040
						Me.IndicatedModItem = Nothing
						Dim cmMapSurfaceItems As ContextMenu = Me.cmMapSurfaceItems
						Dim control As Control = CType(obj, Control)
						point2 = New Point(num2, num3)
						cmMapSurfaceItems.Show(control, point2)
						Me.LeftMouseClickActive = False
					Else
						Me.LeftMouseClickActive = True
					End If
				Else
					If Not Me.g_IsDrawingRegion AndAlso e.Button = MouseButtons.Right Then
						Dim cmPbox As ContextMenu = Me.cmPbox
						Dim control2 As Control = CType(obj, Control)
						point2 = New Point(num2, num3)
						cmPbox.Show(control2, point2)
						Me.LeftMouseClickActive = False
					End If
					Me.tbHelp.Text = "Left-click to select, right-click for pop-up menu, middle-click to pan"
				End If
				Me.LoadBackground()
				Me.Draw()
			ElseIf e.Button = MouseButtons.Middle Then
				Me.tbHelp.Text = "Press Shift key for 2x pan, Control for 10x pan"
				Dim point As Point = Me.Panel1.PointToClient(Control.MousePosition)
				Dim num2 As Integer = point.X
				Dim num3 As Integer = point.Y
				Dim point2 As Point = New Point(num2, num3)
				Me.gLastMousePos = point2
			End If
		End Sub

		' Token: 0x060008B6 RID: 2230 RVA: 0x00267AD4 File Offset: 0x00266AD4
		Private Sub pbox_MouseMove(sender As Object, e As MouseEventArgs)
			Dim pictureBox As PictureBox = CType(sender, PictureBox)
			Dim num As Integer = pictureBox.PointToClient(Control.MousePosition).X
			Dim point As Point = pictureBox.PointToClient(Control.MousePosition)
			Dim num2 As Integer = point.Y
			Me.sbarpnlLocX.Text = "X: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudXoff.Value), Me.nudXmul.Value)))
			Me.sbarpnlLocY.Text = "Y: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(num2)), Me.nudYoff.Value), Me.nudYmul.Value)))
			If e.Button = MouseButtons.None Then
				If Me.g_IsDrawingRegion Then
					Me.tbHelp.Text = "Left click to set next point or Right click to auto-close region"
					Dim graphics As Graphics
					Dim rectangle As Rectangle
					Dim rectangle2 As Rectangle
					Dim rectangle3 As Rectangle
					If Me.backbuffer IsNot Nothing Then
						graphics = Graphics.FromImage(Me.bmp)
						rectangle = New Rectangle(0, 0, Me.backbuffer.Width, Me.backbuffer.Height)
						rectangle2 = rectangle
						rectangle = New Rectangle(Me.gLastBackBufferOrigin.X, Me.gLastBackBufferOrigin.Y, Me.backbuffer.Width, Me.backbuffer.Height)
						rectangle3 = rectangle
						rectangle3 = Me.NormalizeRectangle(rectangle3)
						graphics.DrawImage(Me.backbuffer, rectangle3, rectangle2, GraphicsUnit.Pixel)
					End If
					If Me.g_RegionPointList.Count > 1 Then
						Me.DrawRegionPoints(Graphics.FromImage(Me.bmp), Me.g_RegionPointList, Me.gCurrentRegionDrawingColor, False)
					End If
					rectangle = New Rectangle(Me.gCurrentRegionSegmentOrigin.X, Me.gCurrentRegionSegmentOrigin.Y, num - Me.gCurrentRegionSegmentOrigin.X, num2 - Me.gCurrentRegionSegmentOrigin.Y)
					rectangle2 = rectangle
					rectangle2 = Me.NormalizeRectangle(rectangle2)
					rectangle2.Width += 1
					rectangle2.Height += 1
					Me.backbuffer = New Bitmap(rectangle2.Width, rectangle2.Height)
					graphics = Graphics.FromImage(Me.backbuffer)
					rectangle = New Rectangle(0, 0, rectangle2.Width, rectangle2.Height)
					rectangle3 = rectangle
					graphics.DrawImage(Me.bmp, rectangle3, rectangle2, GraphicsUnit.Pixel)
					graphics = Graphics.FromImage(Me.bmp)
					graphics.DrawLine(New Pen(Me.gCurrentRegionDrawingColor, 1F), Me.gCurrentRegionSegmentOrigin.X, Me.gCurrentRegionSegmentOrigin.Y, num, num2)
					Dim graphics2 As Graphics = graphics
					Dim pen As Pen = New Pen(Me.gCurrentRegionDrawingColor, 1F)
					rectangle = New Rectangle(Me.gCurrentRegionSegmentOrigin.X - 1, Me.gCurrentRegionSegmentOrigin.Y - 1, 2, 2)
					graphics2.DrawRectangle(pen, rectangle)
					Me.pbox.Refresh()
					Me.gLastBackBufferOrigin = rectangle2.Location
					point = New Point(num, num2)
					Me.gLastMousePos = point
				End If
			ElseIf e.Button = MouseButtons.Left Then
				If(Me.CurrentModItem IsNot Nothing) And Me.LeftMouseClickActive Then
					Dim num3 As Long = DateAndTime.Now.Ticks
					Cursor.Current = Cursors.Cross
					Dim rectangle As Rectangle
					Dim graphics3 As Graphics
					Dim rectangle4 As Rectangle
					Dim rectangle5 As Rectangle
					If Me.backbuffer IsNot Nothing Then
						graphics3 = Graphics.FromImage(Me.bmp)
						rectangle = New Rectangle(0, 0, 3, 3)
						rectangle4 = rectangle
						rectangle = New Rectangle(Me.gLastMousePos.X - 1, Me.gLastMousePos.Y - 1, 3, 3)
						rectangle5 = rectangle
						graphics3.DrawImage(Me.backbuffer, rectangle5, rectangle4, GraphicsUnit.Pixel)
					End If
					Dim timeSpan As TimeSpan = New TimeSpan(DateAndTime.Now.Ticks - num3)
					Dim timeSpan2 As TimeSpan = timeSpan
					num3 = DateAndTime.Now.Ticks
					Console.WriteLine("Move Drawing Time 1: " + StringType.FromInteger(timeSpan2.Milliseconds))
					point = New Point(num, num2)
					Me.gLastMousePos = point
					Me.backbuffer = New Bitmap(3, 3)
					graphics3 = Graphics.FromImage(Me.backbuffer)
					rectangle = New Rectangle(num - 1, num2 - 1, 3, 3)
					rectangle4 = rectangle
					rectangle = New Rectangle(0, 0, 3, 3)
					rectangle5 = rectangle
					num3 = DateAndTime.Now.Ticks
					graphics3.DrawImage(Me.bmp, rectangle5, rectangle4, GraphicsUnit.Pixel)
					timeSpan = New TimeSpan(DateAndTime.Now.Ticks - num3)
					timeSpan2 = timeSpan
					Console.WriteLine("Move Drawing Time 2e: " + StringType.FromInteger(timeSpan2.Milliseconds))
					num3 = DateAndTime.Now.Ticks
					graphics3 = Graphics.FromImage(Me.bmp)
					rectangle = New Rectangle(0, 0, 3, 3)
					rectangle4 = rectangle
					rectangle = New Rectangle(num - 1, num2 - 1, 3, 3)
					rectangle5 = rectangle
					graphics3.DrawImage(Me.CurrentModItemBmp, rectangle5, rectangle4, GraphicsUnit.Pixel)
					timeSpan = New TimeSpan(DateAndTime.Now.Ticks - num3)
					timeSpan2 = timeSpan
					Console.WriteLine(String.Concat(New String() { "Move Drawing Time 3: ", StringType.FromInteger(timeSpan2.Milliseconds), " T: ", StringType.FromLong(num3), " x: ", StringType.FromInteger(num), " Y: ", StringType.FromInteger(num2) }))
					Me.pbox.Refresh()
				End If
			ElseIf e.Button = MouseButtons.Middle Then
				Dim panel As Panel = Me.Panel1
				num = panel.PointToClient(Control.MousePosition).X
				num2 = panel.PointToClient(Control.MousePosition).Y
				Dim num4 As Integer = num - Me.gLastMousePos.X
				Dim num5 As Integer = num2 - Me.gLastMousePos.Y
				If Control.ModifierKeys = Keys.Shift Then
					num4 *= 2
					num5 *= 2
				End If
				If Control.ModifierKeys = Keys.Control Then
					num4 *= 10
					num5 *= 10
				End If
				Dim autoScrollPosition2 As Point
				If num4 <> 0 OrElse num5 <> 0 Then
					Dim autoScrollPosition As Point = Me.Panel1.AutoScrollPosition
					Dim num6 As Integer = 0
					Dim num7 As Integer = 0
					point = Me.Panel1.AutoScrollPosition
					autoScrollPosition2 = New Point(num6 - (num7 - point.X - num4), 0 - (0 - Me.Panel1.AutoScrollPosition.Y - num5))
					If autoScrollPosition <> autoScrollPosition2 Then
						Dim panel2 As ScrollableControl = Me.Panel1
						Dim num8 As Integer = 0
						autoScrollPosition2 = Me.Panel1.AutoScrollPosition
						point = New Point(num8 - autoScrollPosition2.X - num4, 0 - Me.Panel1.AutoScrollPosition.Y - num5)
						panel2.AutoScrollPosition = point
					End If
				End If
				autoScrollPosition2 = New Point(num, num2)
				Me.gLastMousePos = autoScrollPosition2
			End If
		End Sub

		' Token: 0x060008B7 RID: 2231 RVA: 0x002681A4 File Offset: 0x002671A4
		Private Sub pbox_MouseUp(sender As Object, e As MouseEventArgs)
			If(Me.CurrentModItem IsNot Nothing) And Not Me.gLastMousePos.IsEmpty Then
				If e.Button = MouseButtons.Left Then
					Dim num As Integer = Me.pbox.PointToClient(Control.MousePosition).X
					Dim num2 As Integer = Me.pbox.PointToClient(Control.MousePosition).Y
					If num = Me.g_LastMouseDownPos.X AndAlso num2 = Me.g_LastMouseDownPos.Y Then
						Return
					End If
					If Me.CurrentModItem.ItemType <> 2032 AndAlso Me.CurrentModItem.ItemType <> 2040 AndAlso Me.CurrentModItem.ItemType <> 6 AndAlso Me.CurrentModItem.ItemType <> 5000 Then
						Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.XPosAccessor, Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudXoff.Value), Me.nudXmul.Value)))
						Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.YPosAccessor, Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(num2)), Me.nudYoff.Value), Me.nudYmul.Value)))
					ElseIf Me.CurrentModItem.ItemType = 2032 OrElse Me.CurrentModItem.ItemType = 2040 Then
						' The following expression was wrapped in a checked-statement
						num -= Me.CurrentModItem.ScreenX
						num2 = Me.invy(num2) - Me.CurrentModItem.ScreenY
						If(Control.ModifierKeys And Keys.Shift) > Keys.None OrElse Me.CurrentModItem.FileName.StartsWith("g_t_") Then
							Dim num3 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.CurrentModItem.Path + ".XPosition"))
							Dim num4 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.CurrentModItem.Path + ".YPosition"))
							If(Not Control.ModifierKeys And Keys.Alt) > Keys.None Then
								' The following expression was wrapped in a checked-expression
								Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + ".XPosition", num3 + Convert.ToSingle(Decimal.Divide(New Decimal(Me.pbox.PointToClient(Control.MousePosition).X - Me.g_LastMouseDownPos.X), Me.nudXmul.Value)))
							End If
							If(Not Control.ModifierKeys And Keys.Control) > Keys.None Then
								' The following expression was wrapped in a checked-expression
								Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + ".YPosition", num4 - Convert.ToSingle(Decimal.Divide(New Decimal(Me.pbox.PointToClient(Control.MousePosition).Y - Me.g_LastMouseDownPos.Y), Me.nudYmul.Value)))
							End If
						Else
							Me.tbHelp.Text = ""
							Dim num3 As Single = Convert.ToSingle(Decimal.Divide(New Decimal(num), Me.nudXmul.Value))
							Dim num4 As Single = Convert.ToSingle(Decimal.Divide(New Decimal(num2), Me.nudYmul.Value))
							Dim num5 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.XPosAccessor))
							Dim num6 As Single = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.YPosAccessor))
							Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.XPosAccessor, num3)
							Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + "." + Me.CurrentModItem.YPosAccessor, num4)
						End If
					ElseIf Me.CurrentModItem.ItemType = 6 Then
						Dim gfftype As GFFType17 = New GFFType17()
						gfftype.f1 = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudXoff.Value), Me.nudXmul.Value))
						gfftype.f2 = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(num2)), Me.nudYoff.Value), Me.nudYmul.Value))
						Me.GITfile.SetNodeValue(Me.CurrentModItem.Path + ".Position", gfftype)
					ElseIf Me.CurrentModItem.ItemType = 5000 Then
						Me.IFOfile.SetNodeValue("Mod_Entry_X", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(num), Me.nudXoff.Value), Me.nudXmul.Value)))
						Me.IFOfile.SetNodeValue("Mod_Entry_Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(num2)), Me.nudYoff.Value), Me.nudYmul.Value)))
					End If
					Me.LoadBackground()
					Me.Draw()
					Me.CurrentModItem = Nothing
					Me.CurrentModItemBmp = Nothing
					Me.backbuffer = Nothing
					Cursor.Current = Cursors.[Default]
					Me.LeftMouseClickActive = False
					Me.gLastMousePos = CType((If(Nothing, Activator.CreateInstance(GetType(Point)))), Point)
				End If
			Else
				If Me.g_IsDrawingRegion Then
					If e.Button = MouseButtons.Left Then
						Dim x As Integer = Me.pbox.PointToClient(Control.MousePosition).X
						Dim point As Point = Me.pbox.PointToClient(Control.MousePosition)
						Dim y As Integer = point.Y
						point = New Point(x, y)
						Me.gLastMousePos = point
						Me.gCurrentRegionSegmentOrigin = Me.gLastMousePos
						If Me.Near(x, y, RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Me.g_RegionPointList(0), Nothing, "X", New Object(-1) {}, Nothing, Nothing)), RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Me.g_RegionPointList(0), Nothing, "Y", New Object(-1) {}, Nothing, Nothing))) Then
							Me.g_IsDrawingRegion = False
							If Me.gCurrentModItemType = 2032 Then
								Me.CreateTrigger(Me.g_RegionResRef, Me.g_RegionPointList)
							ElseIf Me.gCurrentModItemType = 2040 Then
								Me.CreateEncounter(Me.g_RegionResRef, Me.g_RegionPointList)
							End If
							Me.LoadBackground()
							Me.Draw()
							Me.BuildModuleTreeView()
						Else
							Dim arrayList As ArrayList = Me.g_RegionPointList
							point = New Point(x, y)
							arrayList.Add(point)
						End If
					ElseIf e.Button = MouseButtons.Right Then
						Me.tbHelp.Text = ""
						Me.g_IsDrawingRegion = False
						If Me.gCurrentModItemType = 2032 Then
							Me.CreateTrigger(Me.g_RegionResRef, Me.g_RegionPointList)
						ElseIf Me.gCurrentModItemType = 2040 Then
							Me.CreateEncounter(Me.g_RegionResRef, Me.g_RegionPointList)
						End If
						Me.gCurrentModItemType = -1
						Me.LoadBackground()
						Me.Draw()
						Me.BuildModuleTreeView()
					End If
				End If
				Me.tbHelp.Text = ""
				Me.sbarpnlDesc.Text = ""
				Me.sbarpnlAddlInfo.Text = ""
			End If
		End Sub

		' Token: 0x060008B8 RID: 2232 RVA: 0x002689A4 File Offset: 0x002679A4
		Private Sub pbox_MouseLeave(sender As Object, e As EventArgs)
			Me.sbarpnlLocX.Text = ""
			Me.sbarpnlLocY.Text = ""
		End Sub

		' Token: 0x060008B9 RID: 2233 RVA: 0x002689C8 File Offset: 0x002679C8
		Private Sub nudMulOff_ValueChanged(sender As Object, e As EventArgs)
			If Me.CanFocus And Me.chkbUseFactors.Checked Then
				Me.LoadBackground()
				Me.Draw()
			End If
		End Sub

		' Token: 0x060008BA RID: 2234 RVA: 0x002689EC File Offset: 0x002679EC
		Private Sub tvPalette_ItemDrag(sender As Object, e As ItemDragEventArgs)
			Dim treeNode As TreeNode = CType(e.Item, TreeNode)
			Dim text As String = treeNode.Text
			If treeNode.Tag IsNot Nothing AndAlso ObjectType.ObjTst(treeNode.Tag, "", False) <> 0 Then
				Me.DoDragDrop(RuntimeHelpers.GetObjectValue(treeNode.Tag), DragDropEffects.Copy Or DragDropEffects.Move)
			End If
		End Sub

		' Token: 0x060008BB RID: 2235 RVA: 0x00268A3C File Offset: 0x00267A3C
		Private Sub tvUserPalette_ItemDrag(sender As Object, e As ItemDragEventArgs)
			Dim treeNode As TreeNode = CType(e.Item, TreeNode)
			Dim text As String = treeNode.Text
			If treeNode.Tag IsNot Nothing AndAlso ObjectType.ObjTst(treeNode.Tag, "", False) <> 0 Then
				Me.DoDragDrop(RuntimeHelpers.GetObjectValue(treeNode.Tag), DragDropEffects.Copy Or DragDropEffects.Move)
			End If
		End Sub

		' Token: 0x060008BC RID: 2236 RVA: 0x00268A8C File Offset: 0x00267A8C
		Private Sub tvModule_MouseDown(sender As Object, e As MouseEventArgs)
			Dim point As Point = New Point(e.X, e.Y)
			Dim point2 As Point = point
			Me.LastClickedTvModuleNode = CType(Me.tvModule.GetNodeAt(point2), ModItemTvNode)
		End Sub

		' Token: 0x060008BD RID: 2237 RVA: 0x00268AC8 File Offset: 0x00267AC8
		Private Sub tvModule_MouseUp(sender As Object, e As MouseEventArgs)
			Dim point As Point = New Point(e.X, e.Y)
			Dim point2 As Point = point
			Dim lastClickedTvModuleNode As ModItemTvNode = Me.LastClickedTvModuleNode
			If lastClickedTvModuleNode IsNot Nothing Then
				Me.CurrentContextMenuTvModuleNode = lastClickedTvModuleNode
			End If
			If e.Button = MouseButtons.Right Then
				If lastClickedTvModuleNode IsNot Nothing Then
					Dim tag As Object = lastClickedTvModuleNode.Tag
					If ObjectType.ObjTst(tag, "ItemParent", False) <> 0 AndAlso ObjectType.ObjTst(tag, "Item", False) = 0 Then
						Me.tvModuleContextMenuItem.MenuItems(Me.tvModuleContextMenuItem.MenuItems.IndexOf(Me.cmiTvModuleItemEdit)).Visible = lastClickedTvModuleNode.ItemType <> 6
						Me.tvModuleContextMenuItem.Show(Me.tvModule, point2)
					End If
					Me.tvModule.SelectedNode = Me.CurrentContextMenuTvModuleNode
				End If
			ElseIf e.Button = MouseButtons.Left Then
				Me.tbHelp.Text = "Click an item to see it's location in the module, or right-click it to access the pop-up menu."
				If lastClickedTvModuleNode IsNot Nothing Then
					If e.X < lastClickedTvModuleNode.Bounds.Left Then
						Return
					End If
					Me.LeftMouseClickActive = False
					Dim tag2 As Object = lastClickedTvModuleNode.Tag
					If ObjectType.ObjTst(tag2, "Item", False) = 0 Then
						Me.IndicatedModItem = Me.GetTreeNodesModItem(lastClickedTvModuleNode)
						Me.LoadBackground()
						Me.Draw()
					End If
				End If
			End If
		End Sub

		' Token: 0x060008BE RID: 2238 RVA: 0x00268C04 File Offset: 0x00267C04
		Private Sub tvModule_KeyUp(sender As Object, e As KeyEventArgs)
			If Me.tvModule.SelectedNode Is Nothing Then
				Return
			End If
			Dim tag As Object = Me.tvModule.SelectedNode.Tag
			If ObjectType.ObjTst(tag, "Item", False) = 0 Then
				Me.IndicatedModItem = Me.GetTreeNodesModItem(CType(Me.tvModule.SelectedNode, ModItemTvNode))
				Me.LoadBackground()
				Me.Draw()
			End If
		End Sub

		' Token: 0x060008BF RID: 2239 RVA: 0x00268C68 File Offset: 0x00267C68
		Private Sub tvModule_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs)
			Dim modItemTvNode As ModItemTvNode = CType(e.Node, ModItemTvNode)
			If Not Me.g_tvModule_TreeOpenPaths.Contains(modItemTvNode.FullPath) Then
				Me.g_tvModule_TreeOpenPaths.Add(modItemTvNode.FullPath)
			End If
			Me.AddNodeChildrenToTreePaths(modItemTvNode, Me.g_tvModule_TreeOpenPaths)
		End Sub

		' Token: 0x060008C0 RID: 2240 RVA: 0x00268CB4 File Offset: 0x00267CB4
		Private Sub tvModule_BeforeCollapse(sender As Object, e As TreeViewCancelEventArgs)
			Dim modItemTvNode As ModItemTvNode = CType(e.Node, ModItemTvNode)
			For i As Integer = Me.g_tvModule_TreeOpenPaths.Count - 1 To 0 Step -1
				If BooleanType.FromObject(If((BooleanType.FromObject(LateBinding.LateGet(Me.g_tvModule_TreeOpenPaths(i), Nothing, "StartsWith", New Object() { modItemTvNode.FullPath + "\" }, Nothing, Nothing)) OrElse BooleanType.FromObject(ObjectType.ObjTst(Me.g_tvModule_TreeOpenPaths(i), modItemTvNode.FullPath, False) = 0)), True, False)) Then
					Me.g_tvModule_TreeOpenPaths.RemoveAt(i)
				End If
			Next
		End Sub

		' Token: 0x060008C1 RID: 2241 RVA: 0x00268D70 File Offset: 0x00267D70
		Private Sub cmiProperties_Click(sender As Object, e As EventArgs)
			Me.EditItemProperties(Me.CurrentModItem)
			Me.CurrentModItem = Nothing
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008C2 RID: 2242 RVA: 0x00268D94 File Offset: 0x00267D94
		Private Sub cmiEdit_Click(sender As Object, e As EventArgs)
			Me.EditItem(Me.CurrentModItem)
			Me.CurrentModItem = Nothing
		End Sub

		' Token: 0x060008C3 RID: 2243 RVA: 0x00268DAC File Offset: 0x00267DAC
		Private Sub cmiDelete_Click(sender As Object, e As EventArgs)
			If Not Me.bConfirmDeletes OrElse Interaction.MsgBox("Are you sure you want to delete this?", MsgBoxStyle.OkCancel, "Delete Item") = MsgBoxResult.Ok Then
				Me.DeleteModuleItem(Me.CurrentModItem)
				Me.CurrentModItem = Nothing
			End If
		End Sub

		' Token: 0x060008C4 RID: 2244 RVA: 0x00268DDC File Offset: 0x00267DDC
		Private Sub cmiAddNewSpawnPoint_Click(sender As Object, e As EventArgs)
			Dim currentModItem As ModItem = Me.CurrentModItem
			If Not Me.GITfile.VerifyNodeExists(currentModItem.Path + ".SpawnPointList") Then
				Me.GITfile.CreateList(currentModItem.Path, "SpawnPointList")
			End If
			Dim listItemCount As Integer = Me.GITfile.GetListItemCount(currentModItem.Path + ".SpawnPointList")
			Dim gff_Struct As GFF_Struct = New GFF_Struct(4, 2)
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_float, "X", currentModItem.Parent.X + 2F + CSng(listItemCount))
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "Y", currentModItem.Parent.Y + 2F)
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "Z", 0.0)
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "Orientation", 0.0)
			Me.GITfile.AddListElement(currentModItem.Path + ".SpawnPointList", gff_Struct)
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008C5 RID: 2245 RVA: 0x00268F0C File Offset: 0x00267F0C
		Private Sub cmiTvModuleItemProperties_Click(sender As Object, e As EventArgs)
			Dim currentContextMenuTvModuleNode As ModItemTvNode = Me.CurrentContextMenuTvModuleNode
			Dim pen As Pen = New Pen(Color.Orange, 1F)
			pen.EndCap = LineCap.ArrowAnchor
			Dim treeNodesModItem As ModItem = Me.GetTreeNodesModItem(currentContextMenuTvModuleNode)
			Dim panel As ScrollableControl = Me.Panel1
			Dim point As Point = New Point(CInt(Math.Round(CDbl(treeNodesModItem.ScreenX) - CDbl(Me.Panel1.Size.Width) / 2.0)), CInt(Math.Round(CDbl(treeNodesModItem.ScreenY) - CDbl(Me.Panel1.Size.Height) / 2.0)))
			panel.AutoScrollPosition = point
			If Me.bShowLocatorRay Then
				Graphics.FromImage(Me.pbox.Image).DrawLine(pen, 0, 0, treeNodesModItem.ScreenX - 3, treeNodesModItem.ScreenY - 3)
			End If
			Me.pbox.Update()
			Me.EditItemProperties(treeNodesModItem)
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008C6 RID: 2246 RVA: 0x00268FFC File Offset: 0x00267FFC
		Private Sub cmiTvModuleItemEdit_Click(sender As Object, e As EventArgs)
			Dim currentContextMenuTvModuleNode As ModItemTvNode = Me.CurrentContextMenuTvModuleNode
			Dim pen As Pen = New Pen(Color.Orange, 1F)
			pen.EndCap = LineCap.ArrowAnchor
			Dim treeNodesModItem As ModItem = Me.GetTreeNodesModItem(currentContextMenuTvModuleNode)
			Dim panel As ScrollableControl = Me.Panel1
			Dim point As Point = New Point(CInt(Math.Round(CDbl(treeNodesModItem.ScreenX) - CDbl(Me.Panel1.Size.Width) / 2.0)), CInt(Math.Round(CDbl(treeNodesModItem.ScreenY) - CDbl(Me.Panel1.Size.Height) / 2.0)))
			panel.AutoScrollPosition = point
			If Me.bShowLocatorRay Then
				Graphics.FromImage(Me.pbox.Image).DrawLine(pen, 0, 0, treeNodesModItem.ScreenX - 3, treeNodesModItem.ScreenY - 3)
			End If
			Me.pbox.Update()
			Me.EditItem(treeNodesModItem)
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008C7 RID: 2247 RVA: 0x002690EC File Offset: 0x002680EC
		Private Sub cmiTvModuleItemDelete_Click(sender As Object, e As EventArgs)
			If Not Me.bConfirmDeletes OrElse Interaction.MsgBox("Are you sure you want to delete this?", MsgBoxStyle.OkCancel, "Delete Item") = MsgBoxResult.Ok Then
				Dim currentContextMenuTvModuleNode As ModItemTvNode = Me.CurrentContextMenuTvModuleNode
				Dim fullPath As String = currentContextMenuTvModuleNode.Parent.FullPath
				Dim treeNodesModItem As ModItem = Me.GetTreeNodesModItem(currentContextMenuTvModuleNode)
				Me.DeleteModuleItem(treeNodesModItem)
				Me.CurrentModItem = Nothing
				frmMain.OpenTreeViewToPath(fullPath, Me.tvModule.Nodes(0), 0, True)
			End If
		End Sub

		' Token: 0x060008C8 RID: 2248 RVA: 0x00269158 File Offset: 0x00268158
		Private Sub cmiCreateCameraHere_Click(sender As Object, e As EventArgs)
			Dim num As Single = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.g_LastMouseDownPos.X), Me.nudXoff.Value), Me.nudXmul.Value))
			Dim num2 As Single = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(Me.g_LastMouseDownPos.Y)), Me.nudYoff.Value), Me.nudYmul.Value))
			If Not Me.GITfile.VerifyNodeExists("CameraList") Then
				Me.GITfile.CreateList("", "CameraList")
			End If
			Dim listItemCount As Integer = Me.GITfile.GetListItemCount("CameraList")
			Dim num3 As Integer = -1
			If listItemCount = 0 Then
				num3 = 1
			Else
				Dim num4 As Integer = 0
				Dim num5 As Integer = listItemCount - 1
				For i As Integer = num4 To num5
					Dim num6 As Integer = IntegerType.FromObject(Me.GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(i) + ").CameraID"))
					If num6 > num3 Then
						num3 = num6
					End If
				Next
				num3 += 1
			End If
			Dim gff_Struct As GFF_Struct = New GFF_Struct()
			gff_Struct.type = 14
			gff_Struct.fieldCount = 8
			gff_Struct.fields = New GFF_Field(7) {}
			gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_int, "CameraID", num3)
			gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_Type17, "Position", New GFFType17(num, num2, 0F))
			gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "Pitch", 0)
			gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "MicRange", 0)
			gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_Type16, "Orientation", New GFFType16(1F, 0F, 0F, 0F))
			gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_float, "Height", 2)
			gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_float, "FieldOfView", 55)
			gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_Type17, "EAOrientation", New GFFType17(0F, 0F, 0F))
			Me.GITfile.AddListElement("CameraList", gff_Struct)
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008C9 RID: 2249 RVA: 0x0026939C File Offset: 0x0026839C
		Private Sub cmiSetModuleStartPoint_Click(sender As Object, e As EventArgs)
			Dim num As Single = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.g_LastMouseDownPos.X), Me.nudXoff.Value), Me.nudXmul.Value))
			Dim num2 As Single = Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(Me.g_LastMouseDownPos.Y)), Me.nudYoff.Value), Me.nudYmul.Value))
			Me.IFOfile.SetNodeValue("Mod_Entry_X", num)
			Me.IFOfile.SetNodeValue("Mod_Entry_Y", num2)
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008CA RID: 2250 RVA: 0x00269454 File Offset: 0x00268454
		Private Sub cmiModuleProperties_Click(sender As Object, e As EventArgs)
			Me.miModuleProperties_Click(Nothing, Nothing)
		End Sub

		' Token: 0x060008CB RID: 2251 RVA: 0x00269460 File Offset: 0x00268460
		Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
			If CType(sender, TabControl).SelectedTab Is Me.tabpagUserPalette Then
				Me.tbHelp.Text = "Place files in your project's UserPalette folder to make them available here."
			Else
				Me.tbHelp.Text = "Click an item type button on the palette above to see the available standard items you can place in the module."
			End If
		End Sub

		' Token: 0x060008CC RID: 2252 RVA: 0x00269498 File Offset: 0x00268498
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008CD RID: 2253 RVA: 0x0026949C File Offset: 0x0026849C
		Private Sub btnTest_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060008CE RID: 2254 RVA: 0x002694A0 File Offset: 0x002684A0
		Private Sub btnClean_Click(sender As Object, e As EventArgs)
			Me.GITfile.ClearListElements("Creature List")
			Me.GITfile.ClearListElements("Placeable List")
			Me.GITfile.ClearListElements("Door List")
			Me.GITfile.ClearListElements("SoundList")
			Me.GITfile.ClearListElements("WaypointList")
			Me.GITfile.ClearListElements("TriggerList")
			Dim num As Integer = 8
			Do
				Me.GITfile.DeleteListElement("CameraList", num)
				num += -1
			Loop While num >= 1
		End Sub

		' Token: 0x060008CF RID: 2255 RVA: 0x00269528 File Offset: 0x00268528
		Private Sub btnPalCreature_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2027
			Me.BuildPaletteTreeView("creaturepalstd")
			Me.tbHelp.Text = "Drag the desired creature onto the map"
		End Sub

		' Token: 0x060008D0 RID: 2256 RVA: 0x00269550 File Offset: 0x00268550
		Private Sub btnPalDoor_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2042
			Me.BuildPaletteTreeView("doorpalstd")
			Me.tbHelp.Text = "Drag the desired door onto the map"
		End Sub

		' Token: 0x060008D1 RID: 2257 RVA: 0x00269578 File Offset: 0x00268578
		Private Sub btnPalEncounter_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2040
			Me.BuildPaletteTreeView("encounterpalstd")
			Me.tbHelp.Text = "Encounters are not yet supported"
		End Sub

		' Token: 0x060008D2 RID: 2258 RVA: 0x002695A0 File Offset: 0x002685A0
		Private Sub btnPalItem_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2025
			Me.BuildPaletteTreeView("itempalstd")
		End Sub

		' Token: 0x060008D3 RID: 2259 RVA: 0x002695B8 File Offset: 0x002685B8
		Private Sub btnPalMerchant_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2051
			Me.tbHelp.Text = "Drag the desired merchant onto the map"
			Me.BuildPaletteTreeView("storepal")
		End Sub

		' Token: 0x060008D4 RID: 2260 RVA: 0x002695E0 File Offset: 0x002685E0
		Private Sub btnPalPlaceable_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2044
			Me.BuildPaletteTreeView("placeablepalstd")
			Me.tbHelp.Text = "Drag the desired placeable onto the map"
		End Sub

		' Token: 0x060008D5 RID: 2261 RVA: 0x00269608 File Offset: 0x00268608
		Private Sub btnPalSound_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2035
			Me.BuildPaletteTreeView("soundpal")
			Me.tbHelp.Text = "Drag the desired sound onto the map"
		End Sub

		' Token: 0x060008D6 RID: 2262 RVA: 0x00269630 File Offset: 0x00268630
		Private Sub btnPalTrigger_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2032
			Me.BuildPaletteTreeView("triggerpalstd")
			Me.tbHelp.Text = "Drag the desired trigger type onto the map"
		End Sub

		' Token: 0x060008D7 RID: 2263 RVA: 0x00269658 File Offset: 0x00268658
		Private Sub btnPalWaypoint_Click(sender As Object, e As EventArgs)
			Me.g_CurrentPaletteModItemType = 2058
			Me.BuildPaletteTreeView("waypointpalstd")
			Me.tbHelp.Text = "Drag the desired waypoint onto the map"
		End Sub

		' Token: 0x060008D8 RID: 2264 RVA: 0x00269680 File Offset: 0x00268680
		Private Sub btnLogFactors_Click(sender As Object, e As EventArgs)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim stringWriter As StringWriter = New StringWriter(stringBuilder)
			Dim frmErrorMessageWithCopyableText As frmErrorMessageWithCopyableText = New frmErrorMessageWithCopyableText()
			stringWriter.WriteLine("mie = New MapInfo.Map")
			stringWriter.WriteLine("mie.MapName = """ + Me.g_MapName + """")
			stringWriter.WriteLine("mie.MapAssembler = ""Fred Tetra""")
			stringWriter.WriteLine("mie.MapCalibrator = ""Fred Tetra""")
			stringWriter.WriteLine("mie.ModuleName = ""Harbinger""")
			If Me.miUseSmallMap.Checked Then
				stringWriter.WriteLine("mie.S = True")
				stringWriter.WriteLine("mie.SXMul = " + StringType.FromDecimal(Me.nudXmul.Value))
				stringWriter.WriteLine("mie.SYMul = " + StringType.FromDecimal(Me.nudYmul.Value))
				stringWriter.WriteLine("mie.SXOff = " + StringType.FromDecimal(Me.nudXoff.Value))
				stringWriter.WriteLine("mie.SYOff = " + StringType.FromDecimal(Me.nudYoff.Value))
			Else
				stringWriter.WriteLine("mie.L = True")
				stringWriter.WriteLine("mie.LXMul = " + StringType.FromDecimal(Me.nudXmul.Value))
				stringWriter.WriteLine("mie.LYMul = " + StringType.FromDecimal(Me.nudYmul.Value))
				stringWriter.WriteLine("mie.LXOff = " + StringType.FromDecimal(Me.nudXoff.Value))
				stringWriter.WriteLine("mie.LYOff = " + StringType.FromDecimal(Me.nudYoff.Value))
			End If
			stringWriter.WriteLine("mi.MapList.Add(mie)")
			frmErrorMessageWithCopyableText.tbMsg.Text = stringWriter.ToString()
			frmErrorMessageWithCopyableText.ShowDialog(Me)
		End Sub

		' Token: 0x060008D9 RID: 2265 RVA: 0x00269838 File Offset: 0x00268838
		Private Sub btnDebug_Click(sender As Object, e As EventArgs)
			Dim frmTextEditor As frmTextEditor = New frmTextEditor()
			frmTextEditor.Filename = Me.g_MapName + ".git"
			frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
			frmTextEditor.RTFMode = True
			frmTextEditor.tbGeneric.Rtf = Me.GITfile.ToString()
			frmTextEditor.tbGeneric.SelectionLength = 0
			frmTextEditor.Show()
		End Sub

		' Token: 0x060008DA RID: 2266 RVA: 0x002698A8 File Offset: 0x002688A8
		Private Sub btnTweakUp_Click(sender As Object, e As EventArgs)
			If Me.IndicatedModItem IsNot Nothing Then
				Me.GITfile.SetNodeValue(Me.IndicatedModItem.YPosPath, ObjectType.AddObj(Me.GITfile.GetNodeValue(Me.IndicatedModItem.YPosPath), 0.01))
				Me.UpdateAfterTweakBtn()
			End If
		End Sub

		' Token: 0x060008DB RID: 2267 RVA: 0x00269904 File Offset: 0x00268904
		Private Sub btnTweakDown_Click(sender As Object, e As EventArgs)
			If Me.IndicatedModItem IsNot Nothing Then
				Me.GITfile.SetNodeValue(Me.IndicatedModItem.YPosPath, ObjectType.SubObj(Me.GITfile.GetNodeValue(Me.IndicatedModItem.YPosPath), 0.01))
				Me.UpdateAfterTweakBtn()
			End If
		End Sub

		' Token: 0x060008DC RID: 2268 RVA: 0x00269960 File Offset: 0x00268960
		Private Sub btnTweakLeft_Click(sender As Object, e As EventArgs)
			If Me.IndicatedModItem IsNot Nothing Then
				Me.GITfile.SetNodeValue(Me.IndicatedModItem.XPosPath, ObjectType.SubObj(Me.GITfile.GetNodeValue(Me.IndicatedModItem.XPosPath), 0.01))
				Me.UpdateAfterTweakBtn()
			End If
		End Sub

		' Token: 0x060008DD RID: 2269 RVA: 0x002699BC File Offset: 0x002689BC
		Private Sub btnTweakRight_Click(sender As Object, e As EventArgs)
			If Me.IndicatedModItem IsNot Nothing Then
				Me.GITfile.SetNodeValue(Me.IndicatedModItem.XPosPath, ObjectType.AddObj(Me.GITfile.GetNodeValue(Me.IndicatedModItem.XPosPath), 0.01))
				Me.UpdateAfterTweakBtn()
			End If
		End Sub

		' Token: 0x060008DE RID: 2270 RVA: 0x00269A18 File Offset: 0x00268A18
		Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs)
			Dim array As Object() = New Object(3) {}
			Dim point As Point = New Point(e.X, e.Y)
			Dim x As Integer = Me.pbox.PointToClient(point).X
			Dim point2 As Point = Me.pbox.PointToClient(point)
			Dim y As Integer = point2.Y
			If e.Data.GetDataPresent(DataFormats.Text) Then
				array = Strings.Split(StringType.FromObject(e.Data.GetData(GetType(String))), "|", -1, CompareMethod.Binary)
				Dim num As Integer = Convert.ToInt32(Strings.Replace(StringType.FromObject(array(0)), "itemtype=", "", 1, -1, CompareMethod.Binary))
				Me.gCurrentModItemType = num
				Dim gff_Struct As GFF_Struct = New GFF_Struct()
				Dim text As String
				If num <> 6 Then
					text = Strings.Replace(StringType.FromObject(array(2)), "resref=", "", 1, -1, CompareMethod.Binary)
					Dim text2 As String = text + "." + frmMain.GetRsrcTypeForID(num)
					If array.Length = 4 AndAlso (ObjectType.ObjTst(array(3), "up", False) = 0 OrElse ObjectType.ObjTst(array(3), "gt", False) = 0) Then
						Dim frmInstanceOrRefPrompt As frmInstanceOrRefPrompt = New frmInstanceOrRefPrompt()
						frmInstanceOrRefPrompt.ShowDialog(Me)
						Dim dialogResult As DialogResult = frmInstanceOrRefPrompt.DialogResult
						If dialogResult = DialogResult.Cancel Then
							Return
						End If
						Dim frmPromptForString As frmPromptForString = New frmPromptForString("Create new instance", "Enter name for new instance (16 character max)", text)
						If StringType.StrCmp(frmInstanceOrRefPrompt.ItemClass, "instance", False) = 0 Then
							frmPromptForString.tbValue.MaxLength = 16
							Dim text3 As String
							Do
								frmPromptForString.ShowDialog(Me)
								If Me.FileExistsInProject(frmPromptForString.tbValue.Text.Trim() + "." + frmMain.GetRsrcTypeForID(num)) Then
									text3 = "A file with that name already exists. Please choose another."
								ElseIf StringType.StrCmp(text, frmPromptForString.tbValue.Text.Trim(), False) = 0 Then
									text3 = "You cannot use the name of the template. Please choose another."
								Else
									text3 = ""
								End If
								If StringType.StrCmp(text3, "", False) <> 0 Then
									Interaction.MsgBox(text3, MsgBoxStyle.Exclamation, "Name error")
								End If
							Loop While StringType.StrCmp(text3, "", False) <> 0 OrElse frmPromptForString.DialogResult = DialogResult.Cancel
							If frmPromptForString.DialogResult = DialogResult.Cancel Then
								Return
							End If
							Dim text4 As String
							If ObjectType.ObjTst(array(3), "up", False) = 0 Then
								text4 = Me.g_ProjectPath + "\userpalette\" + text2
							ElseIf ObjectType.ObjTst(array(3), "gt", False) = 0 Then
								' The following expression was wrapped in a checked-expression
								text4 = String.Concat(New String() { frmMain.gRootPath, "\Global Templates\k", StringType.FromInteger(Me.KotorVersionIndex + 1), "\", text2 })
							End If
							File.Copy(text4, String.Concat(New String() { Me.g_ProjectPath, "\", frmPromptForString.tbValue.Text.Trim(), ".", frmMain.GetRsrcTypeForID(num) }))
							text = frmPromptForString.tbValue.Text.Trim()
						End If
					End If
				End If
				Select Case num
					Case 2027
						gff_Struct.type = 4
						gff_Struct.fieldCount = 6
						gff_Struct.fields = New GFF_Field(5) {}
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "XOrientation", 1F)
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
						Dim text5 As String
						gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", text + text5)
						Me.GITfile.AddListElement("Creature List", gff_Struct)
						Me.gModuleEditorSettings.FilterShowCreatures = True
					Case 2032
						If text.StartsWith("g_t_") Then
							Dim text6 As String = text
							point2 = New Point(x, y)
							Me.CreateTrap(text6, point2)
						Else
							Me.gCurrentRegionDrawingColor = Color.Orange
							point2 = New Point(x, y)
							Me.gLastMousePos = point2
							Me.gCurrentRegionSegmentOrigin = Me.gLastMousePos
							If Not Me.g_IsDrawingRegion Then
								Dim text5 As String
								Me.g_RegionResRef = text + text5
								Me.g_IsDrawingRegion = True
								Me.backbuffer = Nothing
								Me.g_RegionPointList = New ArrayList()
								Dim arrayList As ArrayList = Me.g_RegionPointList
								point2 = New Point(x, y)
								arrayList.Add(point2)
							Else
								Interaction.MsgBox("Currently Drawing a Region", MsgBoxStyle.Exclamation, Nothing)
							End If
							Me.gModuleEditorSettings.FilterShowTriggers = True
						End If
					Case 2035
						gff_Struct = New GFF_Struct(5, 6)
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", text)
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_dword, "GeneratedType", 0)
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
						Me.GITfile.AddListElement("SoundList", gff_Struct)
						Me.gModuleEditorSettings.FilterShowSounds = True
					Case 2040
						Me.gCurrentRegionDrawingColor = Color.Green
						point2 = New Point(x, y)
						Me.gLastMousePos = point2
						Me.gCurrentRegionSegmentOrigin = Me.gLastMousePos
						If Not Me.g_IsDrawingRegion Then
							Dim text5 As String
							Me.g_RegionResRef = text + text5
							Me.g_IsDrawingRegion = True
							Me.backbuffer = Nothing
							Me.g_RegionPointList = New ArrayList()
							Dim arrayList2 As ArrayList = Me.g_RegionPointList
							point2 = New Point(x, y)
							arrayList2.Add(point2)
						Else
							Interaction.MsgBox("Currently Drawing a Region", MsgBoxStyle.Exclamation, Nothing)
						End If
						Me.gModuleEditorSettings.FilterShowEncounters = True
					Case 2042
						gff_Struct.type = 8
						gff_Struct.fieldCount = 12
						gff_Struct.fields = New GFF_Field(11) {}
						Dim text5 As String
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", text + text5)
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CExoString, "Tag", "empty")
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_CResRef, "LinkedToModule", "empty")
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_CExoString, "LinkedTo", "empty")
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_byte, "LinkedToFlags", 0)
						Dim gffexoLocString As GFFExoLocString = New GFFExoLocString("none", 0)
						gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_CExoLocString, "TransitionDestin", gffexoLocString)
						gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_float, "X", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(8) = New GFF_Field(GFFField.GFF_float, "Z", 0F)
						gff_Struct.fields(9) = New GFF_Field(GFFField.GFF_float, "Bearing", 0F)
						gff_Struct.fields(10) = New GFF_Field(GFFField.GFF_byte, "UseTweakColor", 0)
						gff_Struct.fields(11) = New GFF_Field(GFFField.GFF_dword, "TweakColor", 16777215)
						Me.GITfile.AddListElement("Door List", gff_Struct)
						Me.gModuleEditorSettings.FilterShowDoors = True
					Case 2044
						gff_Struct = New GFF_Struct(5, 9)
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_float, "X", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "Z", 0F)
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "Bearing", 0F)
						Dim text5 As String
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", text + text5)
						Me.GITfile.AddListElement("Placeable List", gff_Struct)
						Me.gModuleEditorSettings.FilterShowPlaceables = True
					Case 2051
						gff_Struct = New GFF_Struct(6, 11)
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_float, "XOrientation", 1F)
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
						gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_CResRef, "ResRef", text)
						Me.GITfile.AddListElement("StoreList", gff_Struct)
						Me.gModuleEditorSettings.FilterShowMerchants = True
					Case 2058
						Dim templateBifResourceData As Byte() = frmMain.GetTemplateBifResourceData(Me.KotorVersionIndex, text, num)
						Dim clsGFF As clsGFF = New clsGFF(templateBifResourceData, Me.KotorVersionIndex, False)
						Dim cexoLocStringNodeValue As String = clsGFF.GetCExoLocStringNodeValue("LocalizedName")
						gff_Struct = New GFF_Struct(14, 5)
						gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("TemplateResRef")))
						gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CExoString, "LinkedTo", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("LinkedTo")))
						gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_CExoString, "Tag", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Tag")))
						gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_byte, "HasMapNote", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("HasMapNote")))
						gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_byte, "MapNoteEnabled", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("MapNoteEnabled")))
						gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_CExoLocString, "LocalizedName", New GFFExoLocString(clsGFF.GetCExoLocStringNodeValue("LocalizedName"), 0))
						gff_Struct.fields(6) = New GFF_Field(GFFField.GFF_CExoLocString, "Description", New GFFExoLocString(clsGFF.GetCExoLocStringNodeValue("Description"), 0))
						gff_Struct.fields(7) = New GFF_Field(GFFField.GFF_CExoLocString, "MapNote", New GFFExoLocString(clsGFF.GetCExoLocStringNodeValue("MapNote"), 0))
						gff_Struct.fields(8) = New GFF_Field(GFFField.GFF_CExoString, "Comment", RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Comment")))
						gff_Struct.fields(9) = New GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(x), Me.nudXoff.Value), Me.nudXmul.Value)))
						gff_Struct.fields(10) = New GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(New Decimal(Me.invy(y)), Me.nudYoff.Value), Me.nudYmul.Value)))
						gff_Struct.fields(11) = New GFF_Field(GFFField.GFF_float, "ZPosition", 0F)
						gff_Struct.fields(12) = New GFF_Field(GFFField.GFF_float, "XOrientation", 1F)
						gff_Struct.fields(13) = New GFF_Field(GFFField.GFF_float, "YOrientation", 0F)
						Me.GITfile.AddListElement("WaypointList", gff_Struct)
						Me.gModuleEditorSettings.FilterShowWaypoints = True
				End Select
				Me.LoadBackground()
				Me.Draw()
				Me.BuildModuleTreeView()
				Me.UpdateVisibilityBtnsWithSettings()
			End If
		End Sub

		' Token: 0x060008DF RID: 2271 RVA: 0x0026A854 File Offset: 0x00269854
		Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs)
			If e.Data.GetDataPresent(DataFormats.Text) Then
				e.Effect = DragDropEffects.Copy
			End If
		End Sub

		' Token: 0x060008E0 RID: 2272 RVA: 0x0026A870 File Offset: 0x00269870
		Private Sub chkbShowResRefs_CheckedChanged(sender As Object, e As EventArgs)
			Me.g_ShowPaletteResRefs = CType(sender, CheckBox).Checked
			If StringType.StrCmp(Me.g_CurrentPaletteName, "", False) <> 0 Then
				Me.BuildPaletteTreeView(Me.g_CurrentPaletteName)
			End If
		End Sub

		' Token: 0x060008E1 RID: 2273 RVA: 0x0026A8A4 File Offset: 0x002698A4
		Private Sub chkbShowNames_CheckedChanged(sender As Object, e As EventArgs)
			Me.g_ShowPaletteNames = CType(sender, CheckBox).Checked
			If StringType.StrCmp(Me.g_CurrentPaletteName, "", False) <> 0 Then
				Me.BuildPaletteTreeView(Me.g_CurrentPaletteName)
			End If
		End Sub

		' Token: 0x060008E2 RID: 2274 RVA: 0x0026A8D8 File Offset: 0x002698D8
		Private Sub chkbShowTags_CheckedChanged(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.ShowTagsOnModulePalette = Me.chkbShowTags.Checked
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008E3 RID: 2275 RVA: 0x0026A914 File Offset: 0x00269914
		Private Sub miOpenProject_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.BrowseForModuleEditorProjectFolder()
			If StringType.StrCmp(text, "", False) = 0 Then
				Return
			End If
			Me.bModuleLoadedOK = Me.Setup(text)
			If Not Me.bModuleLoadedOK Then
				Me.EnableControls(False)
				Me.lbScripts.Items.Clear()
				Me.Text = "Module Editor"
				Return
			End If
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008E4 RID: 2276 RVA: 0x0026A97C File Offset: 0x0026997C
		Private Sub miShowHideModuleElements_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.bModElementsVisible Then
				Me.pnlModElements.Visible = False
				Dim panel As Panel = Me.Panel1
				panel.Width += 194
				panel = Me.Panel1
				panel.Left -= 194
				Me.bModElementsVisible = False
				Me.miShowHideModuleElements.Checked = False
			Else
				Me.pnlModElements.Visible = True
				Dim panel As Panel = Me.Panel1
				panel.Width -= 194
				panel = Me.Panel1
				panel.Left += 194
				Me.bModElementsVisible = True
				Me.miShowHideModuleElements.Checked = True
			End If
		End Sub

		' Token: 0x060008E5 RID: 2277 RVA: 0x0026AA38 File Offset: 0x00269A38
		Private Sub miShowHidePalette_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.bPaletteVisible Then
				Me.pnlPalette.Visible = False
				Dim panel As Panel = Me.Panel1
				panel.Width += 240
				Me.bPaletteVisible = False
				Me.miShowHidePalette.Checked = False
			Else
				Me.pnlPalette.Visible = True
				Dim panel As Panel = Me.Panel1
				panel.Width -= 240
				Me.bPaletteVisible = True
				Me.miShowHidePalette.Checked = True
			End If
		End Sub

		' Token: 0x060008E6 RID: 2278 RVA: 0x0026AAC0 File Offset: 0x00269AC0
		Private Sub miSave_Click(sender As Object, e As EventArgs)
			Me.GITfile.WriteFile(Path.Combine(Me.g_ProjectPath, Me.g_MapName + ".git"), "GIT")
			Me.AREfile.WriteFile(Path.Combine(Me.g_ProjectPath, Me.g_MapName + ".are"), "ARE")
			Me.IFOfile.WriteFile(Path.Combine(Me.g_ProjectPath, "Module.ifo"), "IFO")
		End Sub

		' Token: 0x060008E7 RID: 2279 RVA: 0x0026AB44 File Offset: 0x00269B44
		Private Sub miClose_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060008E8 RID: 2280 RVA: 0x0026AB4C File Offset: 0x00269B4C
		Private Sub miShowModulePaths_Click(sender As Object, e As EventArgs)
			Dim fileStream As FileStream = New FileStream(Me.g_ProjectPath + "\" + Me.g_MapName + ".pth", FileMode.Open)
			Dim clsGFF As clsGFF = New clsGFF(fileStream, Me.KotorVersionIndex, True)
			Dim num As Integer = 0
			Dim num2 As Integer = clsGFF.GetListItemCount("Path_Points") - 1
			For i As Integer = num To num2
				Dim num3 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(i) + ").First_Conection")))
				Dim num4 As Double = DoubleType.FromObject(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(i) + ").X"))
				Dim num5 As Double = DoubleType.FromObject(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(i) + ").Y"))
				Dim num6 As Integer = 1
				Dim num7 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(i) + ").Conections")))
				For j As Integer = num6 To num7
					Dim num8 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("Path_Conections(" + StringType.FromInteger(num3) + ").Destination")))
					Dim num9 As Double = DoubleType.FromObject(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(num8) + ").X"))
					Dim num10 As Double = DoubleType.FromObject(clsGFF.GetNodeValue("Path_Points(" + StringType.FromInteger(num8) + ").Y"))
					Dim num11 As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(Convert.ToDouble(Me.nudXmul.Value) * num4))), Me.nudXoff.Value))
					Dim num12 As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(Convert.ToDouble(Me.nudYmul.Value) * num5))), Me.nudYoff.Value)))
					Me.Draw3x3Box(Me.bmp, num11, num12, Color.Fuchsia)
					Dim num13 As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(Convert.ToDouble(Me.nudXmul.Value) * num9))), Me.nudXoff.Value))
					Dim num14 As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(Convert.ToDouble(Me.nudYmul.Value) * num10))), Me.nudYoff.Value)))
					Me.Draw3x3Box(Me.bmp, num13, num14, Color.Fuchsia)
					Graphics.FromImage(Me.bmp).DrawLine(New Pen(Color.Orange, 1F), num11, num12, num13, num14)
					num4 = num9
					num5 = num10
					num3 += 1
				Next
			Next
			Me.Draw()
		End Sub

		' Token: 0x060008E9 RID: 2281 RVA: 0x0026AE0C File Offset: 0x00269E0C
		Private Sub miOptions_Click(sender As Object, e As EventArgs)
			Dim frmModuleEditorOptions As frmModuleEditorOptions = New frmModuleEditorOptions()
			Dim settings As Options = UserSettings.GetSettings()
			frmModuleEditorOptions.ModuleElementIndicatorSize = Me.dModuleElementIndicatorSize
			frmModuleEditorOptions.ConfirmDeletes = Me.bConfirmDeletes
			frmModuleEditorOptions.ShowLocatorRay = Me.bShowLocatorRay
			frmModuleEditorOptions.ModuleExportPath = Me.gModuleEditorSettings.ModuleEditorModOutputPath
			frmModuleEditorOptions.ShowDialog(Me)
			If frmModuleEditorOptions.DialogResult = DialogResult.OK Then
				Me.dModuleElementIndicatorSize = frmModuleEditorOptions.ModuleElementIndicatorSize
				Me.bConfirmDeletes = frmModuleEditorOptions.ConfirmDeletes
				Me.bShowLocatorRay = frmModuleEditorOptions.ShowLocatorRay
				settings.bModuleEditorShowLocatorRay = Me.bShowLocatorRay
				settings.bModuleEditorConfirmDeletes = Me.bConfirmDeletes
				settings.ModuleEditorModuleElementIndicatorSize = Me.dModuleElementIndicatorSize
				Me.gModuleEditorSettings.ModuleEditorModOutputPath = frmModuleEditorOptions.ModuleExportPath
				UserSettings.SaveSettings(settings)
				ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			End If
		End Sub

		' Token: 0x060008EA RID: 2282 RVA: 0x0026AEDC File Offset: 0x00269EDC
        'Private Sub miExploreModuleFolder_Click(sender As Object, e As EventArgs)
        '	New Process() With { .StartInfo = { .FileName = "explorer.exe ", .Arguments = Me.g_ProjectPath } }.Start()
        'End Sub

        ' Token: 0x060008EA RID: 2282 RVA: 0x0026AEDC File Offset: 0x00269EDC
        Private Sub miExploreModuleFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = "explorer.exe"
            psi.Arguments = """" & Me.g_ProjectPath & """"
            psi.UseShellExecute = True

            Dim proc As Process = New Process()
            proc.StartInfo = psi
            proc.Start()
        End Sub

		' Token: 0x060008EB RID: 2283 RVA: 0x0026AF18 File Offset: 0x00269F18
		Private Sub miBuildModFile_Click(sender As Object, e As EventArgs)
			Me.BuildModFile()
		End Sub

		' Token: 0x060008EC RID: 2284 RVA: 0x0026AF20 File Offset: 0x00269F20
		Private Sub miShowGffDump_Click(sender As Object, e As EventArgs)
			Dim frmTextEditor As frmTextEditor = New frmTextEditor()
			frmTextEditor.Filename = Me.g_MapName
			frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
			If sender Is Me.miShowAreDump Then
				frmTextEditor.tbGeneric.Rtf = New clsGFF(Me.g_ProjectPath + "\" + Me.g_MapName + ".are", Me.KotorVersionIndex, True).ToString()
				Dim frmTextEditor2 As frmTextEditor = frmTextEditor
				frmTextEditor2.Text += ".are"
			ElseIf sender Is Me.miShowGitDump Then
				frmTextEditor.tbGeneric.Rtf = New clsGFF(Me.g_ProjectPath + "\" + Me.g_MapName + ".git", Me.KotorVersionIndex, True).ToString()
				Dim frmTextEditor2 As frmTextEditor = frmTextEditor
				frmTextEditor2.Text += ".git"
			Else
				frmTextEditor.tbGeneric.Rtf = New clsGFF(Me.g_ProjectPath + "\module.ifo", Me.KotorVersionIndex, True).ToString()
				Dim frmTextEditor2 As frmTextEditor = frmTextEditor
				frmTextEditor2.Text += ".ifo"
			End If
			frmTextEditor.RTFMode = True
			frmTextEditor.tbGeneric.SelectionLength = 0
			frmTextEditor.Show()
		End Sub

		' Token: 0x060008ED RID: 2285 RVA: 0x0026B06C File Offset: 0x0026A06C
		Private Sub miModuleProperties_Click(sender As Object, e As EventArgs)
			Dim frmModuleIfo_AreaEditor As frmModuleIfo_AreaEditor = New frmModuleIfo_AreaEditor(Me.AREfile, Me.IFOfile, Me.GITfile, Me.KotorVersionIndex)
			If frmModuleIfo_AreaEditor.ShowDialog(Me) = DialogResult.OK Then
				frmModuleIfo_AreaEditor.UpdateFiles()
				If frmModuleIfo_AreaEditor.ModEntryChanged Then
					Me.LoadBackground()
					Me.Draw()
				End If
			End If
		End Sub

		' Token: 0x060008EE RID: 2286 RVA: 0x0026B0BC File Offset: 0x0026A0BC
		Private Sub miUseSmallMap_Click(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.MapSize = "small"
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.miSave_Click(Nothing, Nothing)
			Me.Setup(Me.g_ProjectPath)
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008EF RID: 2287 RVA: 0x0026B10C File Offset: 0x0026A10C
		Private Sub miUseLargeMap_Click(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.MapSize = "large"
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.miSave_Click(Nothing, Nothing)
			Me.Setup(Me.g_ProjectPath)
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008F0 RID: 2288 RVA: 0x0026B15C File Offset: 0x0026A15C
		Private Sub miUseAltSmallMap_Click(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.MapSize = "altsmall"
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.miSave_Click(Nothing, Nothing)
			Me.Setup(Me.g_ProjectPath)
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008F1 RID: 2289 RVA: 0x0026B1AC File Offset: 0x0026A1AC
		Private Sub miShowItemLabels_Click(sender As Object, e As EventArgs)
			Me.gModuleEditorSettings.ShowItemLabels = Not Me.gModuleEditorSettings.ShowItemLabels
			Me.miShowItemLabels.Checked = Me.gModuleEditorSettings.ShowItemLabels
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x060008F2 RID: 2290 RVA: 0x0026B1EC File Offset: 0x0026A1EC
		Private Sub miShowModuleEntryPoint_Click(sender As Object, e As EventArgs)
			Dim num As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_X"))
			Dim num2 As Single = SingleType.FromObject(Me.IFOfile.GetNodeValue("Mod_Entry_Y"))
			Dim num3 As Integer = Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudXmul.Value) * num))))), Me.nudXoff.Value))
			Dim num4 As Integer = Me.invy(Convert.ToInt32(Decimal.Subtract(New Decimal(CInt(Math.Round(CDbl((Convert.ToSingle(Me.nudYmul.Value) * num2))))), Me.nudYoff.Value)))
			Me.IndicateModItem(Graphics.FromImage(Me.bmp), num3, num4)
		End Sub

		' Token: 0x060008F3 RID: 2291 RVA: 0x0026B2A8 File Offset: 0x0026A2A8
		Private Sub ToolBarModElementsFilter_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Me.gModuleEditorSettings.FilterShowCreatures = Me.tbarbtnCreature.Pushed
			Me.gModuleEditorSettings.FilterShowDoors = Me.tbarbtnDoor.Pushed
			Me.gModuleEditorSettings.FilterShowEncounters = Me.tbarbtnEncounter.Pushed
			Me.gModuleEditorSettings.FilterShowMerchants = Me.tbarbtnMerchant.Pushed
			Me.gModuleEditorSettings.FilterShowPlaceables = Me.tbarbtnPlaceable.Pushed
			Me.gModuleEditorSettings.FilterShowSounds = Me.tbarbtnSound.Pushed
			Me.gModuleEditorSettings.FilterShowTriggers = Me.tbarbtnTrigger.Pushed
			Me.gModuleEditorSettings.FilterShowWaypoints = Me.tbarbtnWaypoint.Pushed
			ModuleEditorProjectSettings.SaveSettings(Me.gModuleEditorSettings, Me.g_ProjectPath)
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
		End Sub

		' Token: 0x060008F4 RID: 2292 RVA: 0x0026B388 File Offset: 0x0026A388
		Public Sub BuildModuleTreeView()
			Me.tvModule.Nodes.Clear()
			Dim ticks As Long = DateAndTime.Now.Ticks
			Me.AddTvModuleNodes("Creatures", Me.CreatureArr, 8, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Doors", Me.DoorArr, 3, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Encounters", Me.EncounterArr, 10, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Items", Me.ItemArr, -1, False)
			Me.AddTvModuleNodes("Merchants", Me.MerchantArr, 7, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Placeables", Me.PlaceableArr, 4, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Sounds", Me.SoundArr, 6, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Triggers", Me.TriggerArr, 5, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Waypoints", Me.WaypointArr, 11, Me.gModuleEditorSettings.ShowTagsOnModulePalette)
			Me.AddTvModuleNodes("Cameras", Me.CameraArr, 9, False)
			Dim timeSpan As TimeSpan = New TimeSpan(DateAndTime.Now.Ticks - ticks)
			Dim timeSpan2 As TimeSpan = timeSpan
			Console.WriteLine("BuildModuleTreeView Time: " + StringType.FromDouble(timeSpan2.TotalMilliseconds))
			Console.WriteLine(StringType.FromInteger(Me.tb) + " " + StringType.FromInteger(Me.lcl))
			Me.tb = 0
			Me.lcl = 0
			Try
				For Each obj As Object In Me.g_tvModule_TreeOpenPaths
					Dim text As String = StringType.FromObject(obj)
					frmMain.OpenTreeViewToPath(text, Me.tvModule.Nodes(0), 0, False)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

        '' Token: 0x060008F5 RID: 2293 RVA: 0x0026B598 File Offset: 0x0026A598
        'Private Sub AddTvModuleNodes(parentLabel As String, ModItemArr As ModItem(), Optional imageIndex As Integer = -1, Optional ShowTags As Boolean = False)
        '	Dim modItemTvNode As ModItemTvNode = New ModItemTvNode(parentLabel)
        '	modItemTvNode.ImageIndex = imageIndex
        '	modItemTvNode.SelectedImageIndex = imageIndex
        '	Me.tvModule.Nodes.Add(modItemTvNode)
        '	If ModItemArr IsNot Nothing Then
        '		For Each modItem As ModItem In ModItemArr
        '			Dim num As Integer
        '			If modItem IsNot Nothing Then
        '				Dim modItemTvNode2 As ModItemTvNode
        '				If ShowTags Then
        '					If StringType.StrCmp(modItem.Tag, "", False) <> 0 Then
        '						modItemTvNode2 = New ModItemTvNode(modItem.Tag)
        '					Else
        '						Dim modItemTag As String = Me.GetModItemTag(modItem.FileName)
        '						If modItemTag Is Nothing Then
        '							modItemTvNode2 = New ModItemTvNode(modItem.ResRef + " (missing file)")
        '						ElseIf StringType.StrCmp(modItemTag, "", False) = 0 Then
        '							modItemTvNode2 = New ModItemTvNode(modItem.ResRef + " (missing tag)")
        '						Else
        '							modItemTvNode2 = New ModItemTvNode(modItemTag)
        '						End If
        '					End If
        '				Else
        '					modItemTvNode2 = New ModItemTvNode(modItem.ResRef)
        '				End If
        '				modItemTvNode2.ArrayIndex = num
        '				modItemTvNode2.ItemType = modItem.ItemType
        '				modItemTvNode2.Tag = "Item"
        '				modItemTvNode.Nodes.Add(modItemTvNode2)
        '			End If
        '			num += 1
        '		Next
        '		Dim modItem As ModItem
        '		If modItem IsNot Nothing Then
        '			modItemTvNode.ItemType = modItem.ItemType
        '			modItemTvNode.Tag = "ItemParent"
        '		End If
        '	End If
        'End Sub

        ' Token: 0x060008F5 RID: 2293 RVA: 0x0026B598 File Offset: 0x0026A598
        Private Sub AddTvModuleNodes(ByVal parentLabel As String, ByVal ModItemArr As ModItem(), Optional ByVal imageIndex As Integer = -1, Optional ByVal ShowTags As Boolean = False)
            Dim parentNode As ModItemTvNode = New ModItemTvNode(parentLabel)
            parentNode.ImageIndex = imageIndex
            parentNode.SelectedImageIndex = imageIndex
            Me.tvModule.Nodes.Add(parentNode)

            If ModItemArr Is Nothing Then
                Return
            End If

            Dim itemIndex As Integer = 0
            Dim lastValidItem As ModItem = Nothing

            For Each currentItem As ModItem In ModItemArr
                If currentItem IsNot Nothing Then
                    lastValidItem = currentItem

                    Dim childNode As ModItemTvNode = Nothing

                    If ShowTags Then
                        If StringType.StrCmp(currentItem.Tag, "", False) <> 0 Then
                            childNode = New ModItemTvNode(currentItem.Tag)
                        Else
                            Dim modItemTag As String = Me.GetModItemTag(currentItem.FileName)

                            If modItemTag Is Nothing Then
                                childNode = New ModItemTvNode(currentItem.ResRef + " (missing file)")
                            ElseIf StringType.StrCmp(modItemTag, "", False) = 0 Then
                                childNode = New ModItemTvNode(currentItem.ResRef + " (missing tag)")
                            Else
                                childNode = New ModItemTvNode(modItemTag)
                            End If
                        End If
                    Else
                        childNode = New ModItemTvNode(currentItem.ResRef)
                    End If

                    childNode.ArrayIndex = itemIndex
                    childNode.ItemType = currentItem.ItemType
                    childNode.Tag = "Item"
                    parentNode.Nodes.Add(childNode)
                End If

                itemIndex += 1
            Next

            If lastValidItem IsNot Nothing Then
                parentNode.ItemType = lastValidItem.ItemType
                parentNode.Tag = "ItemParent"
            End If
        End Sub

		' Token: 0x060008F6 RID: 2294 RVA: 0x0026B6D4 File Offset: 0x0026A6D4
		Private Function GetModItemTag(FileName As String) As String
			' The following expression was wrapped in a checked-statement
			If File.Exists(Me.g_ProjectPath + "\" + FileName) Then
				Me.lcl += 1
				Dim fileStream As FileStream = File.OpenRead(Me.g_ProjectPath + "\" + FileName)
				Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
				Dim array As Byte() = binaryReader.ReadBytes(CInt(fileStream.Length))
				binaryReader.Close()
				Return frmMain.GetGFFTag(array)
			End If
			If Me.KotorVersionIndex = 0 Then
				If Me.htK1Tags.ContainsKey(FileName) Then
					Me.tb += 1
					Return StringType.FromObject(Me.htK1Tags(FileName))
				End If
			ElseIf Me.KotorVersionIndex = 1 AndAlso Me.htK2Tags.ContainsKey(FileName) Then
				Me.tb += 1
				Return StringType.FromObject(Me.htK2Tags(FileName))
			End If
			Dim text As String
			Return text
		End Function

		' Token: 0x060008F7 RID: 2295 RVA: 0x0026B7B8 File Offset: 0x0026A7B8
		Public Sub BuildPaletteTreeView(paletteName As String)
			If Not(Me.g_ShowPaletteNames Or Me.g_ShowPaletteResRefs) Then
				Return
			End If
			Dim frmMain As frmMain = New frmMain()
			Dim num As Integer = frmMain.KxChitinKey(Me.KotorVersionIndex).FindResIDForResRef(paletteName, 2030)
			Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + frmMain.KxChitinKey(Me.KotorVersionIndex).BiffList(num >> 20).filename
			Dim clsGFF As clsGFF = New clsGFF(frmMain.GetBIFFResource(text, num - (num >> 20 << 20)).data, Me.KotorVersionIndex, True)
			Me.g_CurrentPaletteName = paletteName
			Me.tvPalette.Nodes.Clear()
			Dim num2 As Integer = 0
			Dim num3 As Integer = clsGFF.GetListItemCount("MAIN") - 1
			For i As Integer = num2 To num3
				Dim text2 As String = StringType.FromObject(clsGFF.GetNodeValue("MAIN(" + StringType.FromInteger(i) + ").DELETE_ME"))
				Me.tvPalette.Nodes.Add(text2)
				Dim num4 As Integer = 0
				Dim num5 As Integer = clsGFF.GetListItemCount("MAIN(" + StringType.FromInteger(i) + ").LIST") - 1
				For j As Integer = num4 To num5
					Dim obj As Object = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").DELETE_ME" })))
					If obj IsNot Nothing Then
						Dim nodes As Object = Me.tvPalette.Nodes(i).Nodes
						Dim type As Type = Nothing
						Dim text3 As String = "Add"
						Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(obj) }
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Boolean() = New Boolean() { True }
						LateBinding.LateCall(nodes, type, text3, array2, array3, array4)
						If array4(0) Then
							obj = RuntimeHelpers.GetObjectValue(array(0))
						End If
						Dim num6 As Integer = clsGFF.GetListItemCount(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").LIST" })) - 1
						Dim num7 As Integer = 0
						Dim num8 As Integer = num6
						For k As Integer = num7 To num8
							Dim text4 As String = ""
							If Me.g_ShowPaletteNames Then
								obj = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").LIST(", StringType.FromInteger(k), ").NAME" })))
								text4 = StringType.FromObject(obj)
							End If
							Dim obj2 As Object = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").LIST(", StringType.FromInteger(k), ").RESREF" })))
							If Me.g_ShowPaletteResRefs Then
								If Me.g_ShowPaletteNames Then
									text4 += " ("
								End If
								text4 = StringType.FromObject(ObjectType.StrCatObj(text4, obj2))
								If Me.g_ShowPaletteNames Then
									text4 += ")"
								End If
							End If
							Dim treeNode As TreeNode = New TreeNode(text4)
							treeNode.Tag = ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("itemtype=" + StringType.FromInteger(Me.g_CurrentPaletteModItemType) + "|name=", obj), "|resref="), obj2)
							Me.tvPalette.Nodes(i).Nodes(j).Nodes.Add(treeNode)
						Next
					Else
						Dim text4 As String = ""
						If Me.g_ShowPaletteNames Then
							obj = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").NAME" })))
							text4 = StringType.FromObject(obj)
						End If
						Dim obj2 As Object = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue(String.Concat(New String() { "MAIN(", StringType.FromInteger(i), ").LIST(", StringType.FromInteger(j), ").RESREF" })))
						If Me.g_ShowPaletteResRefs Then
							If Me.g_ShowPaletteNames Then
								text4 += " ("
							End If
							text4 = StringType.FromObject(ObjectType.StrCatObj(text4, obj2))
							If Me.g_ShowPaletteNames Then
								text4 += ")"
							End If
						End If
						Dim treeNode As TreeNode = New TreeNode(text4)
						treeNode.Tag = ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("itemtype=" + StringType.FromInteger(Me.g_CurrentPaletteModItemType) + "|name=", obj), "|resref="), obj2)
						Me.tvPalette.Nodes(i).Nodes.Add(treeNode)
					End If
				Next
			Next
			Dim num9 As Integer = 0
			Dim num10 As Integer = Me.tvPalette.Nodes.Count - 1
			For i As Integer = num9 To num10
				If StringType.StrCmp(Strings.Mid(Me.tvPalette.Nodes(i).Text, 1, 6), "ASSIGN", False) = 0 Then
					Me.tvPalette.Nodes.RemoveAt(i)
					Exit For
				End If
			Next
		End Sub

		' Token: 0x060008F8 RID: 2296 RVA: 0x0026BD50 File Offset: 0x0026AD50
		Private Sub BuildUserPaletteTreeView()
			If Not Directory.Exists(Me.g_ProjectPath + "\userpalette") Then
				Directory.CreateDirectory(Me.g_ProjectPath + "\userpalette")
				Return
			End If
			Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Me.g_ProjectPath + "\userpalette")
			Dim directoryInfo2 As DirectoryInfo = New DirectoryInfo(frmMain.gRootPath + "\Global Templates\k" + StringType.FromInteger(Me.KotorVersionIndex + 1))
			Me.tvUserPalette.Nodes(0).Nodes.Clear()
			Me.tvUserPalette.Nodes(1).Nodes.Clear()
			Me.tvUserPalette.Nodes(2).Nodes.Clear()
			Me.tvUserPalette.Nodes(3).Nodes.Clear()
			Me.tvUserPalette.Nodes(4).Nodes.Clear()
			Me.tvUserPalette.Nodes(5).Nodes.Clear()
			Me.tvUserPalette.Nodes(6).Nodes.Clear()
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utc", Me.tvUserPalette.Nodes(0), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utc", Me.tvUserPalette.Nodes(0), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utd", Me.tvUserPalette.Nodes(1), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utd", Me.tvUserPalette.Nodes(1), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "ute", Me.tvUserPalette.Nodes(2), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "ute", Me.tvUserPalette.Nodes(2), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utm", Me.tvUserPalette.Nodes(3), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utm", Me.tvUserPalette.Nodes(3), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utp", Me.tvUserPalette.Nodes(4), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utp", Me.tvUserPalette.Nodes(4), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "uts", Me.tvUserPalette.Nodes(5), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "uts", Me.tvUserPalette.Nodes(5), "up")
			Me.BuildUserPaletteTreeNodes(directoryInfo2, "utt", Me.tvUserPalette.Nodes(6), "gt")
			Me.BuildUserPaletteTreeNodes(directoryInfo, "utt", Me.tvUserPalette.Nodes(6), "up")
		End Sub

		' Token: 0x060008F9 RID: 2297 RVA: 0x0026C05C File Offset: 0x0026B05C
		Private Sub BuildUserPaletteTreeNodes(dir As DirectoryInfo, fileext As String, nodeparent As TreeNode, source As String)
			For Each fileInfo As FileInfo In dir.GetFiles("*." + fileext)
				Dim treeNode As TreeNode = New TreeNode()
				treeNode.Text = fileInfo.Name.Replace(fileInfo.Extension, "")
				treeNode.Tag = String.Concat(New String() { "itemtype=", StringType.FromInteger(CInt(frmMain.GetIDForRsrcType(fileext.ToLower()))), "|name=", treeNode.Text, "|resref=", treeNode.Text, "|", source })
				nodeparent.Nodes.Add(treeNode)
			Next
		End Sub

		' Token: 0x060008FA RID: 2298 RVA: 0x0026C124 File Offset: 0x0026B124
		Private Sub DeleteModuleItem(ModuleItem As ModItem)
			If ModuleItem.ItemType <> 12040 Then
				Dim array As String() = Strings.Split(Strings.Replace(ModuleItem.Path, ")", "", 1, -1, CompareMethod.Binary), "(", -1, CompareMethod.Binary)
				Me.GITfile.DeleteListElement(array(0), IntegerType.FromString(array(1)))
			Else
				Dim array As String() = Strings.Split(Strings.Replace(Strings.Replace(ModuleItem.Path, "(", ".", 1, -1, CompareMethod.Binary), ")", "", 1, -1, CompareMethod.Binary), ".", -1, CompareMethod.Binary)
				Me.GITfile.DeleteListElement(String.Concat(New String() { array(0), ".", array(1), ".", array(2) }), IntegerType.FromString(array(3)))
			End If
			Me.LoadBackground()
			Me.Draw()
			Me.BuildModuleTreeView()
			If ModuleItem.ItemType = 12040 Then
				Return
			End If
			Dim fileName As String = ModuleItem.FileName
			If Not Directory.Exists(Me.g_ProjectPath + "\recycle") Then
				Directory.CreateDirectory(Me.g_ProjectPath + "\recycle")
			End If
			If File.Exists(Me.g_ProjectPath + "\" + fileName) Then
				Dim flag As Boolean = False
				Dim extension As String = Path.GetExtension(fileName)
				Dim array2 As ModItem()
				If StringType.StrCmp(extension, ".utc", False) = 0 Then
					array2 = Me.CreatureArr
				ElseIf StringType.StrCmp(extension, ".utd", False) = 0 Then
					array2 = Me.DoorArr
				ElseIf StringType.StrCmp(extension, ".uti", False) = 0 Then
					array2 = Me.ItemArr
				ElseIf StringType.StrCmp(extension, ".utm", False) = 0 Then
					array2 = Me.MerchantArr
				ElseIf StringType.StrCmp(extension, ".utp", False) = 0 Then
					array2 = Me.PlaceableArr
				ElseIf StringType.StrCmp(extension, ".utt", False) = 0 Then
					array2 = Me.TriggerArr
				ElseIf StringType.StrCmp(extension, ".uts", False) = 0 Then
					array2 = Me.SoundArr
				ElseIf StringType.StrCmp(extension, ".utw", False) = 0 Then
					array2 = Me.WaypointArr
				ElseIf StringType.StrCmp(extension, ".ute", False) = 0 Then
					array2 = Me.EncounterArr
				End If
				If array2 IsNot Nothing Then
					Dim num As Integer = 0
					Dim upperBound As Integer = array2.GetUpperBound(0)
					For i As Integer = num To upperBound
						If StringType.StrCmp(array2(i).FileName.ToLower(), fileName.ToLower(), False) = 0 Then
							flag = True
							Exit For
						End If
					Next
				End If
				If Not flag Then
					File.Move(Me.g_ProjectPath + "\" + fileName, String.Concat(New String() { Me.g_ProjectPath, "\recycle\", StringType.FromInteger(DateAndTime.Now.Minute), StringType.FromInteger(DateAndTime.Now.Second), fileName }))
				End If
			End If
		End Sub

		' Token: 0x060008FB RID: 2299 RVA: 0x0026C40C File Offset: 0x0026B40C
		Private Sub EnableControls(state As Boolean)
			Me.Panel1.Enabled = state
			Me.pbox.Visible = state
			Me.tabctrlModule.Enabled = state
			Me.tabctrlPalette.Enabled = state
			Me.miSave.Enabled = state
			Me.miBuildModFile.Enabled = state
			Me.miExploreModuleFolder.Enabled = state
			Me.miModuleProperties.Enabled = state
			Me.miShowHideModuleElements.Enabled = state
			Me.miShowHidePalette.Enabled = state
			Me.miShowItemLabels.Enabled = state
			Me.miUseSmallMap.Enabled = state And Me.g_SmallMapAvailable
			Me.miUseLargeMap.Enabled = state And Me.g_LargeMapAvailable
			Me.miShowModuleEntryPoint.Enabled = state
			Me.miShowModulePaths.Enabled = state
			Me.miShowAreDump.Enabled = state
			Me.miShowGitDump.Enabled = state
			Me.miShowIfoDump.Enabled = state
			Me.miOptions.Enabled = state
			Me.ToolBarModElementsFilter.Enabled = state
			Me.chkbShowTags.Enabled = state
		End Sub

		' Token: 0x060008FC RID: 2300 RVA: 0x0026C524 File Offset: 0x0026B524
		Private Sub BuildModuleFileList(items As ModItem(), ByRef list As ArrayList, ByRef refcount As Integer, ByRef instcount As Integer)
			If items Is Nothing Then
				Return
			End If
			For Each modItem As ModItem In items
				Dim text As String = modItem.ResRef + "." + frmMain.GetRsrcTypeForID(modItem.ItemType)
				Dim text2 As String = Me.g_ProjectPath + "\" + text
				If File.Exists(text2) Then
					If Not list.Contains(text2) Then
						list.Add(text2)
						instcount += 1
					End If
				Else
					text2 = Me.g_UserPalettePath + "\" + text
					If File.Exists(text2) Then
						If Not list.Contains(text2) Then
							list.Add(text2)
							instcount += 1
						End If
					Else
						text2 = Me.g_GlobalTemplatesPath + "\" + text
						If File.Exists(text2) Then
							If Not list.Contains(text2) Then
								list.Add(text2)
								instcount += 1
							End If
						Else
							refcount += 1
						End If
					End If
				End If
			Next
		End Sub

		' Token: 0x060008FD RID: 2301 RVA: 0x0026C61C File Offset: 0x0026B61C
		Private Sub AddModuleFileNamesToList(path As String, ByRef list As ArrayList, wildcard As String)
			Dim files As String() = Directory.GetFiles(path, wildcard)
			If files.Length > 0 Then
				For Each text As String In files
					list.Add(text)
				Next
			End If
		End Sub

		' Token: 0x060008FE RID: 2302 RVA: 0x0026C658 File Offset: 0x0026B658
		Private Function BrowseForModuleEditorProjectFolder() As String
			Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
			folderBrowserDialog.Description = "Select a Module Project folder:"
			Me.CurrentSettings = UserSettings.GetSettings()
			If Me.CurrentSettings.LastModuleEditedPath IsNot Nothing Then
				folderBrowserDialog.SelectedPath = Me.CurrentSettings.LastModuleEditedPath
			End If
			folderBrowserDialog.ShowNewFolderButton = False
			If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
				Me.CurrentSettings.LastModuleEditedPath = folderBrowserDialog.SelectedPath
				UserSettings.SaveSettings(Me.CurrentSettings)
				Return folderBrowserDialog.SelectedPath
			End If
			Dim text As String
			Return text
		End Function

		' Token: 0x060008FF RID: 2303 RVA: 0x0026C6D4 File Offset: 0x0026B6D4
		Private Sub AddNodeChildrenToTreePaths(node As ModItemTvNode, arTreeOpenPaths As ArrayList)
			Try
				For Each obj As Object In node.Nodes
					Dim modItemTvNode As ModItemTvNode = CType(obj, ModItemTvNode)
					If modItemTvNode.IsExpanded Then
						If Not arTreeOpenPaths.Contains(modItemTvNode.FullPath) Then
							arTreeOpenPaths.Add(modItemTvNode.FullPath)
						End If
						Me.AddNodeChildrenToTreePaths(modItemTvNode, arTreeOpenPaths)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000900 RID: 2304 RVA: 0x0026C754 File Offset: 0x0026B754
		Private Sub UpdateAfterTweakBtn()
			Me.IndicatedModItem.X = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.IndicatedModItem.XPosPath))
			Me.IndicatedModItem.Y = SingleType.FromObject(Me.GITfile.GetNodeValue(Me.IndicatedModItem.YPosPath))
			Me.sbarpnlLocX.Text = StringType.FromSingle(Convert.ToSingle(Me.IndicatedModItem.X))
			Me.sbarpnlLocY.Text = StringType.FromSingle(Convert.ToSingle(Me.IndicatedModItem.Y))
			Me.LoadBackground()
			Me.Draw()
		End Sub

        '' Token: 0x06000901 RID: 2305 RVA: 0x0026C7FC File Offset: 0x0026B7FC
        'Private Sub lbScripts_DoubleClick(sender As Object, e As EventArgs)
        '	If Me.lbScripts.SelectedIndex = -1 Then
        '		Return
        '	End If
        '	New frmTextEditor(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Me.g_ProjectPath + "\", Me.lbScripts.SelectedItem), ".nss")), Me.KotorVersionIndex, True) With { .Filename = StringType.FromObject(ObjectType.StrCatObj(Me.lbScripts.SelectedItem, ".nss")), .DirectEdit = True }.Show()
        'End Sub

        ' Token: 0x06000901 RID: 2305 RVA: 0x0026C7FC File Offset: 0x0026B7FC
        Private Sub lbScripts_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lbScripts.SelectedIndex = -1 Then
                Return
            End If

            Dim scriptName As String = StringType.FromObject(Me.lbScripts.SelectedItem)
            Dim scriptPath As String = Me.g_ProjectPath + "\" + scriptName + ".nss"

            Dim editor As frmTextEditor = New frmTextEditor(scriptPath, Me.KotorVersionIndex, True)
            editor.Filename = scriptName + ".nss"
            editor.DirectEdit = True
            editor.Show()
        End Sub

		' Token: 0x06000902 RID: 2306 RVA: 0x0026C884 File Offset: 0x0026B884
		Private Sub SetEditorCaption()
			' The following expression was wrapped in a checked-expression
			Me.Text = String.Concat(New String() { "Module Editor - ", Me.g_MapName, " (K", StringType.FromInteger(Me.KotorVersionIndex + 1), ") - " })
			If StringType.StrCmp(Me.gModuleEditorSettings.ModuleEditorModOutputPath, "", False) = 0 Then
				Me.Text += "(No module output path set)"
			Else
				Me.Text += Me.gModuleEditorSettings.ModuleEditorModOutputPath
			End If
		End Sub

		' Token: 0x06000903 RID: 2307 RVA: 0x0026C924 File Offset: 0x0026B924
		Private Sub lbDialogs_DoubleClick(sender As Object, e As EventArgs)
			Dim cursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Dim frmDialogEditor As frmDialogEditor = New frmDialogEditor(Me.g_ProjectPath + "\" + Me.lbDialogs.SelectedItem.ToString() + ".dlg", Me.KotorVersionIndex)
			frmDialogEditor.Show()
			Cursor.Current = cursor
		End Sub

		' Token: 0x06000904 RID: 2308 RVA: 0x0026C980 File Offset: 0x0026B980
		Private Sub chkbFine_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkbFine.Checked Then
				Me.nudXmul.DecimalPlaces = 4
				Me.nudYmul.DecimalPlaces = 4
			Else
				Me.nudXmul.DecimalPlaces = 2
				Me.nudYmul.DecimalPlaces = 2
			End If
		End Sub

		' Token: 0x06000905 RID: 2309 RVA: 0x0026C9CC File Offset: 0x0026B9CC
		Private Sub btnAssignPt1_Click(sender As Object, e As EventArgs)
			Dim point As Point = New Point(Convert.ToInt32(Me.tbMouseX.Text), Convert.ToInt32(Me.tbMouseY.Text))
			Me.MapCalibratePt1 = point
			If Not Me.MapCalibratePt2.IsEmpty Then
				Me.btnCalcCalibrationVals.Enabled = True
			End If
		End Sub

		' Token: 0x06000906 RID: 2310 RVA: 0x0026CA20 File Offset: 0x0026BA20
		Private Sub btnAssignPt2_Click(sender As Object, e As EventArgs)
			Dim point As Point = New Point(Convert.ToInt32(Me.tbMouseX.Text), Convert.ToInt32(Me.tbMouseY.Text))
			Me.MapCalibratePt2 = point
			If Not Me.MapCalibratePt1.IsEmpty Then
				Me.btnCalcCalibrationVals.Enabled = True
			End If
		End Sub

		' Token: 0x06000907 RID: 2311 RVA: 0x0026CA74 File Offset: 0x0026BA74
		Private Sub btnCalcCalibrationVals_Click(sender As Object, e As EventArgs)
			Me.chkbUseFactors.Checked = False
			Me.nudXmul.Value = New Decimal(CSng((Me.MapCalibratePt2.X - Me.MapCalibratePt1.X)) / (Convert.ToSingle(Me.tb3dsMaxPt2X.Text) - Convert.ToSingle(Me.tb3dsMaxPt1X.Text)))
			Me.nudXoff.Value = New Decimal(-(CSng(Me.MapCalibratePt1.X) - Convert.ToSingle(Me.nudXmul.Value) * Convert.ToSingle(Me.tb3dsMaxPt1X.Text)))
			Me.nudYmul.Value = New Decimal(CSng((0 - (Me.MapCalibratePt2.Y - Me.MapCalibratePt1.Y))) / (Convert.ToSingle(Me.tb3dsMaxPt2Y.Text) - Convert.ToSingle(Me.tb3dsMaxPt1Y.Text)))
			Me.nudYoff.Value = New Decimal(-(CSng(Me.g_imageYsize) - (CSng(Me.MapCalibratePt1.Y) + Convert.ToSingle(Me.nudYmul.Value) * Convert.ToSingle(Me.tb3dsMaxPt1Y.Text))))
			Me.chkbUseFactors.Checked = True
			Me.LoadBackground()
			Me.Draw()
		End Sub

		' Token: 0x06000908 RID: 2312 RVA: 0x0026CBC4 File Offset: 0x0026BBC4
		Private Sub btnCalToolsToggle_MouseDown(sender As Object, e As MouseEventArgs)
			If(Control.ModifierKeys And (Keys.Shift Or Keys.Control Or Keys.Alt)) > Keys.None AndAlso (Control.MouseButtons And MouseButtons.XButton2) > MouseButtons.None Then
				Me.CalibrationToolsVis = Not Me.CalibrationToolsVis
				Me.nudXmul.Visible = Me.CalibrationToolsVis
				Me.nudYmul.Visible = Me.CalibrationToolsVis
				Me.nudXoff.Visible = Me.CalibrationToolsVis
				Me.nudYoff.Visible = Me.CalibrationToolsVis
				Me.chkbUseFactors.Visible = Me.CalibrationToolsVis
				Me.btnLogFactors.Visible = Me.CalibrationToolsVis
				Me.btnAssignPt1.Visible = Me.CalibrationToolsVis
				Me.btnAssignPt2.Visible = Me.CalibrationToolsVis
				Me.btnAssignPt2.Visible = Me.CalibrationToolsVis
				Me.btnCalcCalibrationVals.Visible = Me.CalibrationToolsVis
				Me.tbMouseX.Visible = Me.CalibrationToolsVis
				Me.tbMouseY.Visible = Me.CalibrationToolsVis
				Me.tb3dsMaxPt1X.Visible = Me.CalibrationToolsVis
				Me.tb3dsMaxPt2X.Visible = Me.CalibrationToolsVis
				Me.tb3dsMaxPt1Y.Visible = Me.CalibrationToolsVis
				Me.tb3dsMaxPt2Y.Visible = Me.CalibrationToolsVis
			End If
		End Sub

		' Token: 0x06000909 RID: 2313 RVA: 0x0026CD18 File Offset: 0x0026BD18
		Private Sub miFont_Click(sender As Object, e As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.ShowColor = True
			fontDialog.Font = Me.labelFont
			fontDialog.Color = Me.labelBrush.Color
			fontDialog.ShowApply = False
			If fontDialog.ShowDialog() = DialogResult.OK Then
				Me.labelFont = fontDialog.Font
				Me.labelBrush.Color = fontDialog.Color
				Me.LoadBackground()
				Me.Draw()
			End If
		End Sub

		' Token: 0x0600090A RID: 2314 RVA: 0x0026CD88 File Offset: 0x0026BD88
		Private Function IsFileInTrash(filename As String) As Boolean
			Dim flag As Boolean
			Return flag
		End Function

		' Token: 0x040003E8 RID: 1000
		<AccessedThroughProperty("miCopyToOverride")>
		Private _miCopyToOverride As MenuItem

		' Token: 0x040003E9 RID: 1001
		<AccessedThroughProperty("miRemoveFromOverride")>
		Private _miRemoveFromOverride As MenuItem

		' Token: 0x040003EA RID: 1002
		<AccessedThroughProperty("miCleanOverride")>
		Private _miCleanOverride As MenuItem

		' Token: 0x040003EB RID: 1003
		<AccessedThroughProperty("chkbShowNames")>
		Private _chkbShowNames As CheckBox

		' Token: 0x040003EC RID: 1004
		<AccessedThroughProperty("MenuItem9")>
		Private _MenuItem9 As MenuItem

		' Token: 0x040003ED RID: 1005
		<AccessedThroughProperty("tvUserPalette")>
		Private _tvUserPalette As TreeView

		' Token: 0x040003EE RID: 1006
		<AccessedThroughProperty("miShowModulePaths")>
		Private _miShowModulePaths As MenuItem

		' Token: 0x040003EF RID: 1007
		<AccessedThroughProperty("cmiTvModuleItemEdit")>
		Private _cmiTvModuleItemEdit As MenuItem

		' Token: 0x040003F0 RID: 1008
		<AccessedThroughProperty("miShowHidePalette")>
		Private _miShowHidePalette As MenuItem

		' Token: 0x040003F1 RID: 1009
		<AccessedThroughProperty("miShowHideModuleElements")>
		Private _miShowHideModuleElements As MenuItem

		' Token: 0x040003F2 RID: 1010
		<AccessedThroughProperty("ToolTip1")>
		Private _ToolTip1 As ToolTip

		' Token: 0x040003F3 RID: 1011
		<AccessedThroughProperty("miClose")>
		Private _miClose As MenuItem

		' Token: 0x040003F4 RID: 1012
		<AccessedThroughProperty("pnlModElements")>
		Private _pnlModElements As Panel

		' Token: 0x040003F5 RID: 1013
		<AccessedThroughProperty("pnlPalette")>
		Private _pnlPalette As Panel

		' Token: 0x040003F6 RID: 1014
		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		' Token: 0x040003F7 RID: 1015
		<AccessedThroughProperty("btnLogFactors")>
		Private _btnLogFactors As Button

		' Token: 0x040003F8 RID: 1016
		<AccessedThroughProperty("chkbShowResRefs")>
		Private _chkbShowResRefs As CheckBox

		' Token: 0x040003F9 RID: 1017
		<AccessedThroughProperty("btnPalTrigger")>
		Private _btnPalTrigger As Button

		' Token: 0x040003FA RID: 1018
		<AccessedThroughProperty("btnPalSound")>
		Private _btnPalSound As Button

		' Token: 0x040003FB RID: 1019
		<AccessedThroughProperty("miFont")>
		Private _miFont As MenuItem

		' Token: 0x040003FC RID: 1020
		<AccessedThroughProperty("btnCalToolsToggle")>
		Private _btnCalToolsToggle As Button

		' Token: 0x040003FD RID: 1021
		<AccessedThroughProperty("btnCalcCalibrationVals")>
		Private _btnCalcCalibrationVals As Button

		' Token: 0x040003FE RID: 1022
		<AccessedThroughProperty("btnAssignPt2")>
		Private _btnAssignPt2 As Button

		' Token: 0x040003FF RID: 1023
		<AccessedThroughProperty("btnPalWaypoint")>
		Private _btnPalWaypoint As Button

		' Token: 0x04000400 RID: 1024
		<AccessedThroughProperty("btnPalPlaceable")>
		Private _btnPalPlaceable As Button

		' Token: 0x04000401 RID: 1025
		<AccessedThroughProperty("btnPalMerchant")>
		Private _btnPalMerchant As Button

		' Token: 0x04000402 RID: 1026
		<AccessedThroughProperty("btnPalItem")>
		Private _btnPalItem As Button

		' Token: 0x04000403 RID: 1027
		<AccessedThroughProperty("btnPalEncounter")>
		Private _btnPalEncounter As Button

		' Token: 0x04000404 RID: 1028
		<AccessedThroughProperty("cmiTvModuleItemDelete")>
		Private _cmiTvModuleItemDelete As MenuItem

		' Token: 0x04000405 RID: 1029
		<AccessedThroughProperty("MenuItem7")>
		Private _MenuItem7 As MenuItem

		' Token: 0x04000406 RID: 1030
		<AccessedThroughProperty("btnPalCreature")>
		Private _btnPalCreature As Button

		' Token: 0x04000407 RID: 1031
		<AccessedThroughProperty("tbHelp")>
		Private _tbHelp As TextBox

		' Token: 0x04000408 RID: 1032
		<AccessedThroughProperty("miSave")>
		Private _miSave As MenuItem

		' Token: 0x04000409 RID: 1033
		<AccessedThroughProperty("btnPalDoor")>
		Private _btnPalDoor As Button

		' Token: 0x0400040A RID: 1034
		<AccessedThroughProperty("tabpagUserPalette")>
		Private _tabpagUserPalette As TabPage

		' Token: 0x0400040B RID: 1035
		<AccessedThroughProperty("tb3dsMaxPt2X")>
		Private _tb3dsMaxPt2X As TextBox

		' Token: 0x0400040C RID: 1036
		<AccessedThroughProperty("tb3dsMaxPt2Y")>
		Private _tb3dsMaxPt2Y As TextBox

		' Token: 0x0400040D RID: 1037
		<AccessedThroughProperty("cmiTvModuleItemProperties")>
		Private _cmiTvModuleItemProperties As MenuItem

		' Token: 0x0400040E RID: 1038
		<AccessedThroughProperty("tb3dsMaxPt1Y")>
		Private _tb3dsMaxPt1Y As TextBox

		' Token: 0x0400040F RID: 1039
		<AccessedThroughProperty("tb3dsMaxPt1X")>
		Private _tb3dsMaxPt1X As TextBox

		' Token: 0x04000410 RID: 1040
		<AccessedThroughProperty("btnAssignPt1")>
		Private _btnAssignPt1 As Button

		' Token: 0x04000411 RID: 1041
		<AccessedThroughProperty("chkbFine")>
		Private _chkbFine As CheckBox

		' Token: 0x04000412 RID: 1042
		<AccessedThroughProperty("tbMouseY")>
		Private _tbMouseY As TextBox

		' Token: 0x04000413 RID: 1043
		<AccessedThroughProperty("tvModuleContextMenuItem")>
		Private _tvModuleContextMenuItem As ContextMenu

		' Token: 0x04000414 RID: 1044
		<AccessedThroughProperty("tabctrlPalette")>
		Private _tabctrlPalette As TabControl

		' Token: 0x04000415 RID: 1045
		<AccessedThroughProperty("tvPalette")>
		Private _tvPalette As TreeView

		' Token: 0x04000416 RID: 1046
		<AccessedThroughProperty("tvModule")>
		Private _tvModule As TreeView

		' Token: 0x04000417 RID: 1047
		<AccessedThroughProperty("btnClean")>
		Private _btnClean As Button

		' Token: 0x04000418 RID: 1048
		<AccessedThroughProperty("nudYoff")>
		Private _nudYoff As NumericUpDown

		' Token: 0x04000419 RID: 1049
		<AccessedThroughProperty("tbMouseX")>
		Private _tbMouseX As TextBox

		' Token: 0x0400041A RID: 1050
		<AccessedThroughProperty("nudXoff")>
		Private _nudXoff As NumericUpDown

		' Token: 0x0400041B RID: 1051
		<AccessedThroughProperty("miOpenProject")>
		Private _miOpenProject As MenuItem

		' Token: 0x0400041C RID: 1052
		<AccessedThroughProperty("nudYmul")>
		Private _nudYmul As NumericUpDown

		' Token: 0x0400041D RID: 1053
		<AccessedThroughProperty("tabpagModuleElements")>
		Private _tabpagModuleElements As TabPage

		' Token: 0x0400041E RID: 1054
		<AccessedThroughProperty("nudXmul")>
		Private _nudXmul As NumericUpDown

		' Token: 0x0400041F RID: 1055
		<AccessedThroughProperty("tabpagScripts")>
		Private _tabpagScripts As TabPage

		' Token: 0x04000420 RID: 1056
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000421 RID: 1057
		<AccessedThroughProperty("miUseAltSmallMap")>
		Private _miUseAltSmallMap As MenuItem

		' Token: 0x04000422 RID: 1058
		<AccessedThroughProperty("lbDialogs")>
		Private _lbDialogs As ListBox

		' Token: 0x04000423 RID: 1059
		<AccessedThroughProperty("tabpagDialogs")>
		Private _tabpagDialogs As TabPage

		' Token: 0x04000424 RID: 1060
		<AccessedThroughProperty("tabctrlModule")>
		Private _tabctrlModule As TabControl

		' Token: 0x04000425 RID: 1061
		<AccessedThroughProperty("mnuView")>
		Private _mnuView As MenuItem

		' Token: 0x04000426 RID: 1062
		<AccessedThroughProperty("miExploreModuleFolder")>
		Private _miExploreModuleFolder As MenuItem

		' Token: 0x04000427 RID: 1063
		<AccessedThroughProperty("miBuildModFile")>
		Private _miBuildModFile As MenuItem

		' Token: 0x04000428 RID: 1064
		<AccessedThroughProperty("chkbUseFactors")>
		Private _chkbUseFactors As CheckBox

		' Token: 0x04000429 RID: 1065
		<AccessedThroughProperty("miModuleProperties")>
		Private _miModuleProperties As MenuItem

		' Token: 0x0400042A RID: 1066
		<AccessedThroughProperty("miShowGitDump")>
		Private _miShowGitDump As MenuItem

		' Token: 0x0400042B RID: 1067
		<AccessedThroughProperty("btnTest")>
		Private _btnTest As Button

		' Token: 0x0400042C RID: 1068
		<AccessedThroughProperty("miShowAreDump")>
		Private _miShowAreDump As MenuItem

		' Token: 0x0400042D RID: 1069
		<AccessedThroughProperty("miShowIfoDump")>
		Private _miShowIfoDump As MenuItem

		' Token: 0x0400042E RID: 1070
		<AccessedThroughProperty("btnDebug")>
		Private _btnDebug As Button

		' Token: 0x0400042F RID: 1071
		<AccessedThroughProperty("sbar")>
		Private _sbar As StatusBar

		' Token: 0x04000430 RID: 1072
		<AccessedThroughProperty("pbox")>
		Private _pbox As PictureBox

		' Token: 0x04000431 RID: 1073
		<AccessedThroughProperty("sbarpnlLocX")>
		Private _sbarpnlLocX As StatusBarPanel

		' Token: 0x04000432 RID: 1074
		<AccessedThroughProperty("MenuItem3")>
		Private _MenuItem3 As MenuItem

		' Token: 0x04000433 RID: 1075
		<AccessedThroughProperty("sbarpnlLocY")>
		Private _sbarpnlLocY As StatusBarPanel

		' Token: 0x04000434 RID: 1076
		<AccessedThroughProperty("sbarpnlDesc")>
		Private _sbarpnlDesc As StatusBarPanel

		' Token: 0x04000435 RID: 1077
		<AccessedThroughProperty("sbarpnlAddlInfo")>
		Private _sbarpnlAddlInfo As StatusBarPanel

		' Token: 0x04000436 RID: 1078
		<AccessedThroughProperty("sbarpnlStatus")>
		Private _sbarpnlStatus As StatusBarPanel

		' Token: 0x04000437 RID: 1079
		<AccessedThroughProperty("ToolBarModElementsFilter")>
		Private _ToolBarModElementsFilter As ToolBar

		' Token: 0x04000438 RID: 1080
		<AccessedThroughProperty("MenuItem6")>
		Private _MenuItem6 As MenuItem

		' Token: 0x04000439 RID: 1081
		<AccessedThroughProperty("tbarbtnCreature")>
		Private _tbarbtnCreature As ToolBarButton

		' Token: 0x0400043A RID: 1082
		<AccessedThroughProperty("tbarbtnDoor")>
		Private _tbarbtnDoor As ToolBarButton

		' Token: 0x0400043B RID: 1083
		<AccessedThroughProperty("tbarbtnEncounter")>
		Private _tbarbtnEncounter As ToolBarButton

		' Token: 0x0400043C RID: 1084
		<AccessedThroughProperty("tbarbtnMerchant")>
		Private _tbarbtnMerchant As ToolBarButton

		' Token: 0x0400043D RID: 1085
		<AccessedThroughProperty("tbarbtnPlaceable")>
		Private _tbarbtnPlaceable As ToolBarButton

		' Token: 0x0400043E RID: 1086
		<AccessedThroughProperty("tbarbtnSound")>
		Private _tbarbtnSound As ToolBarButton

		' Token: 0x0400043F RID: 1087
		<AccessedThroughProperty("miOptions")>
		Private _miOptions As MenuItem

		' Token: 0x04000440 RID: 1088
		<AccessedThroughProperty("MenuItem4")>
		Private _MenuItem4 As MenuItem

		' Token: 0x04000441 RID: 1089
		<AccessedThroughProperty("tbarbtnTrigger")>
		Private _tbarbtnTrigger As ToolBarButton

		' Token: 0x04000442 RID: 1090
		<AccessedThroughProperty("tbarbtnWaypoint")>
		Private _tbarbtnWaypoint As ToolBarButton

		' Token: 0x04000443 RID: 1091
		<AccessedThroughProperty("ilModElementsFilter")>
		Private _ilModElementsFilter As ImageList

		' Token: 0x04000444 RID: 1092
		<AccessedThroughProperty("lbScripts")>
		Private _lbScripts As ListBox

		' Token: 0x04000445 RID: 1093
		<AccessedThroughProperty("miUseLargeMap")>
		Private _miUseLargeMap As MenuItem

		' Token: 0x04000446 RID: 1094
		<AccessedThroughProperty("miShowModuleEntryPoint")>
		Private _miShowModuleEntryPoint As MenuItem

		' Token: 0x04000447 RID: 1095
		<AccessedThroughProperty("cmiAddNewSpawnPoint")>
		Private _cmiAddNewSpawnPoint As MenuItem

		' Token: 0x04000448 RID: 1096
		<AccessedThroughProperty("cmiEditGFFFile")>
		Private _cmiEditGFFFile As MenuItem

		' Token: 0x04000449 RID: 1097
		<AccessedThroughProperty("MenuItem2")>
		Private _MenuItem2 As MenuItem

		' Token: 0x0400044A RID: 1098
		<AccessedThroughProperty("miUseSmallMap")>
		Private _miUseSmallMap As MenuItem

		' Token: 0x0400044B RID: 1099
		<AccessedThroughProperty("MenuItem11")>
		Private _MenuItem11 As MenuItem

		' Token: 0x0400044C RID: 1100
		<AccessedThroughProperty("miShowItemLabels")>
		Private _miShowItemLabels As MenuItem

		' Token: 0x0400044D RID: 1101
		<AccessedThroughProperty("cmPbox")>
		Private _cmPbox As ContextMenu

		' Token: 0x0400044E RID: 1102
		<AccessedThroughProperty("MenuItem5")>
		Private _MenuItem5 As MenuItem

		' Token: 0x0400044F RID: 1103
		<AccessedThroughProperty("cmiModuleProperties")>
		Private _cmiModuleProperties As MenuItem

		' Token: 0x04000450 RID: 1104
		<AccessedThroughProperty("cmiDelete")>
		Private _cmiDelete As MenuItem

		' Token: 0x04000451 RID: 1105
		<AccessedThroughProperty("cmiCreateCameraHere")>
		Private _cmiCreateCameraHere As MenuItem

		' Token: 0x04000452 RID: 1106
		<AccessedThroughProperty("cmiSetModuleStartPoint")>
		Private _cmiSetModuleStartPoint As MenuItem

		' Token: 0x04000453 RID: 1107
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000454 RID: 1108
		<AccessedThroughProperty("MenuItem13")>
		Private _MenuItem13 As MenuItem

		' Token: 0x04000455 RID: 1109
		<AccessedThroughProperty("cmiProperties")>
		Private _cmiProperties As MenuItem

		' Token: 0x04000456 RID: 1110
		<AccessedThroughProperty("MainMenu1")>
		Private _MainMenu1 As MainMenu

		' Token: 0x04000457 RID: 1111
		<AccessedThroughProperty("cmMapSurfaceItems")>
		Private _cmMapSurfaceItems As ContextMenu

		' Token: 0x04000458 RID: 1112
		<AccessedThroughProperty("chkbShowTags")>
		Private _chkbShowTags As CheckBox

		' Token: 0x04000459 RID: 1113
		<AccessedThroughProperty("btnTweakUp")>
		Private _btnTweakUp As RepeatButton

		' Token: 0x0400045A RID: 1114
		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		' Token: 0x0400045B RID: 1115
		<AccessedThroughProperty("MenuItem1")>
		Private _MenuItem1 As MenuItem

		' Token: 0x0400045C RID: 1116
		<AccessedThroughProperty("btnTweakLeft")>
		Private _btnTweakLeft As RepeatButton

		' Token: 0x0400045D RID: 1117
		<AccessedThroughProperty("btnTweakDown")>
		Private _btnTweakDown As RepeatButton

		' Token: 0x0400045E RID: 1118
		<AccessedThroughProperty("btnTweakRight")>
		Private _btnTweakRight As RepeatButton

		' Token: 0x04000460 RID: 1120
		Private Const HALF_ITEM_SIZE As Integer = 1

		' Token: 0x04000461 RID: 1121
		Private Const ITEM_SIZE As Integer = 3

		' Token: 0x04000462 RID: 1122
		Private Const NEAR_TOLERANCE As Integer = 2

		' Token: 0x04000463 RID: 1123
		Public g_clsDialogTlk As clsDialogTlk

		' Token: 0x04000464 RID: 1124
		Private CreatureArr As ModItem()

		' Token: 0x04000465 RID: 1125
		Private PlaceableArr As ModItem()

		' Token: 0x04000466 RID: 1126
		Private DoorArr As ModItem()

		' Token: 0x04000467 RID: 1127
		Private ItemArr As ModItem()

		' Token: 0x04000468 RID: 1128
		Private SoundArr As ModItem()

		' Token: 0x04000469 RID: 1129
		Private WaypointArr As ModItem()

		' Token: 0x0400046A RID: 1130
		Private MerchantArr As ModItem()

		' Token: 0x0400046B RID: 1131
		Private TriggerArr As ModItem()

		' Token: 0x0400046C RID: 1132
		Private EncounterArr As ModItem()

		' Token: 0x0400046D RID: 1133
		Private CameraArr As ModItem()

		' Token: 0x0400046E RID: 1134
		Private TriggerRegions As Region()

		' Token: 0x0400046F RID: 1135
		Private EncounterRegions As Region()

		' Token: 0x04000470 RID: 1136
		Private bModuleLoadedOK As Boolean

		' Token: 0x04000471 RID: 1137
		Private g_imageYsize As Integer

		' Token: 0x04000472 RID: 1138
		Private CurrentModItem As ModItem

		' Token: 0x04000473 RID: 1139
		Private IndicatedModItem As ModItem

		' Token: 0x04000474 RID: 1140
		Private gCurrentModItemType As Integer

		' Token: 0x04000475 RID: 1141
		Private gCurrentRegionDrawingColor As Color

		' Token: 0x04000476 RID: 1142
		Private GITfile As clsGFF

		' Token: 0x04000477 RID: 1143
		Private AREfile As clsGFF

		' Token: 0x04000478 RID: 1144
		Private IFOfile As clsGFF

		' Token: 0x04000479 RID: 1145
		Private backbuffer As Bitmap

		' Token: 0x0400047A RID: 1146
		Private CurrentModItemBmp As Bitmap

		' Token: 0x0400047B RID: 1147
		Private bmp As Bitmap

		' Token: 0x0400047C RID: 1148
		Private bmp_cache As Bitmap

		' Token: 0x0400047D RID: 1149
		Private gLastMousePos As Point

		' Token: 0x0400047E RID: 1150
		Private g_LastMouseDownPos As Point

		' Token: 0x0400047F RID: 1151
		Private gLastBackBufferOrigin As Point

		' Token: 0x04000480 RID: 1152
		Private gCurrentRegionSegmentOrigin As Point

		' Token: 0x04000481 RID: 1153
		Private LeftMouseClickActive As Boolean

		' Token: 0x04000482 RID: 1154
		Private LastClickedTvModuleNode As ModItemTvNode

		' Token: 0x04000483 RID: 1155
		Private CurrentContextMenuTvModuleNode As ModItemTvNode

		' Token: 0x04000484 RID: 1156
		Private g_ShowPaletteNames As Boolean

		' Token: 0x04000485 RID: 1157
		Private g_ShowPaletteResRefs As Boolean

		' Token: 0x04000486 RID: 1158
		Private g_CurrentPaletteName As String

		' Token: 0x04000487 RID: 1159
		Private g_CurrentPaletteModItemType As Integer

		' Token: 0x04000488 RID: 1160
		Private g_ProjectPath As String

		' Token: 0x04000489 RID: 1161
		Private g_GlobalTemplatesPath As String

		' Token: 0x0400048A RID: 1162
		Private g_UserPalettePath As String

		' Token: 0x0400048B RID: 1163
		Private g_IsDrawingRegion As Boolean

		' Token: 0x0400048C RID: 1164
		Private g_RegionPointList As ArrayList

		' Token: 0x0400048D RID: 1165
		Private g_RegionResRef As String

		' Token: 0x0400048E RID: 1166
		Private g_MapName As String

		' Token: 0x0400048F RID: 1167
		Private g_mapImageName As String

		' Token: 0x04000490 RID: 1168
		Private g_LargeMapAvailable As Boolean

		' Token: 0x04000491 RID: 1169
		Private g_SmallMapAvailable As Boolean

		' Token: 0x04000492 RID: 1170
		Private g_UsingLargeMap As Boolean

		' Token: 0x04000493 RID: 1171
		Private g_AltSmallMapAvailable As Boolean

		' Token: 0x04000494 RID: 1172
		Private g_MapTypeInUse As Integer

		' Token: 0x04000495 RID: 1173
		Private g_mapsPath As String

		' Token: 0x04000496 RID: 1174
		Private bPaletteVisible As Boolean

		' Token: 0x04000497 RID: 1175
		Private bModElementsVisible As Boolean

		' Token: 0x04000498 RID: 1176
		Private bConfirmDeletes As Boolean

		' Token: 0x04000499 RID: 1177
		Private bShowLocatorRay As Boolean

		' Token: 0x0400049A RID: 1178
		Private dModuleElementIndicatorSize As Decimal

		' Token: 0x0400049B RID: 1179
		Private gModuleEditorModOutputPath As String

		' Token: 0x0400049C RID: 1180
		Private gModuleEditorSettings As ModuleEditorProjectOptions

		' Token: 0x0400049D RID: 1181
		Private g_tvModule_TreeOpenPaths As ArrayList

		' Token: 0x0400049E RID: 1182
		Private g_UserPalettteFsw As FileSystemWatcher

		' Token: 0x0400049F RID: 1183
		Private g_ProjectFsw As FileSystemWatcher

		' Token: 0x040004A0 RID: 1184
		Public Shared g_form As frmModule_Editor

		' Token: 0x040004A1 RID: 1185
		Private g_ModuleStartPoint As PointF

		' Token: 0x040004A2 RID: 1186
		Private f As frmMain

		' Token: 0x040004A3 RID: 1187
		Private htK1Tags As Hashtable

		' Token: 0x040004A4 RID: 1188
		Private htK2Tags As Hashtable

		' Token: 0x040004A5 RID: 1189
		Private htTemplateBifFiles As Hashtable

		' Token: 0x040004A6 RID: 1190
		Private MapCalibratePt1 As Point

		' Token: 0x040004A7 RID: 1191
		Private MapCalibratePt2 As Point

		' Token: 0x040004A8 RID: 1192
		Private CalibrationToolsVis As Boolean

		' Token: 0x040004A9 RID: 1193
		Private labelFont As Font

		' Token: 0x040004AA RID: 1194
		Private labelBrush As SolidBrush

		' Token: 0x040004AB RID: 1195
		Private tb As Integer

		' Token: 0x040004AC RID: 1196
		Private lcl As Integer
	End Class
End Namespace
