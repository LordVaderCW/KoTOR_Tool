Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000053 RID: 83
	Public Partial Class frmItemPropertyEditor
		Inherits frmParent

		' Token: 0x0600061F RID: 1567 RVA: 0x0024A0EC File Offset: 0x002490EC
		Public Sub New(KotorVerIndex As Integer)
			AddHandler MyBase.Load, AddressOf Me.frm_Load
			AddHandler MyBase.Closing, AddressOf Me.frm_Closing
			Me.usetting = New UserSettings()
			Me.g_bCmbxPropertyHasParam1ResRef = False
			Me.debug = False
			Me.InitializeComponent()
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.KotorVersionIndex = KotorVerIndex
			Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
			Me.g_clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(KotorVerIndex))
			Me.Load2DAs()
			Me.FillComboBoxFrom2DA(Me.cmbxPropertyName, "name", Me.itempropdef, Me.g_clsDialogTlk)
			Me.FillComboBoxFrom2DA(Me.cmbxUpgrade, "label", Me.ReadCls2DA("upgrade", Me.g_clsChitinKey), Nothing)
			Me.cmbxUpgrade.Items.Insert(0, "(None - default)")
		End Sub

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x06000622 RID: 1570 RVA: 0x0024A20C File Offset: 0x0024920C
		' (set) Token: 0x06000621 RID: 1569 RVA: 0x0024A220 File Offset: 0x00249220
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

        ' Token: 0x170001D5 RID: 469
        ' (get) Token: 0x06000623 RID: 1571 RVA: 0x0024A23C File Offset: 0x0024923C
        ' (set) Token: 0x06000624 RID: 1572 RVA: 0x0024A250 File Offset: 0x00249250
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

        ' Token: 0x170001D6 RID: 470
        ' (get) Token: 0x06000625 RID: 1573 RVA: 0x0024A26C File Offset: 0x0024926C
        ' (set) Token: 0x06000626 RID: 1574 RVA: 0x0024A280 File Offset: 0x00249280
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

        ' Token: 0x170001D7 RID: 471
        ' (get) Token: 0x06000628 RID: 1576 RVA: 0x0024A29C File Offset: 0x0024929C
        ' (set) Token: 0x06000627 RID: 1575 RVA: 0x0024A2B0 File Offset: 0x002492B0
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

        ' Token: 0x170001D8 RID: 472
        ' (get) Token: 0x06000629 RID: 1577 RVA: 0x0024A2CC File Offset: 0x002492CC
        ' (set) Token: 0x0600062A RID: 1578 RVA: 0x0024A2E0 File Offset: 0x002492E0
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

        ' Token: 0x170001D9 RID: 473
        ' (get) Token: 0x0600062B RID: 1579 RVA: 0x0024A350 File Offset: 0x00249350
        ' (set) Token: 0x0600062C RID: 1580 RVA: 0x0024A2FC File Offset: 0x002492FC
        Friend Overridable Property cmbxPropertyName() As ComboBox
            Get
                Return Me._cmbxPropertyName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxPropertyName IsNot Nothing Then
                    RemoveHandler Me._cmbxPropertyName.SelectedIndexChanged, AddressOf Me.cmbxPropertyName_SelectedIndexChanged
                End If
                Me._cmbxPropertyName = value
                If Me._cmbxPropertyName IsNot Nothing Then
                    AddHandler Me._cmbxPropertyName.SelectedIndexChanged, AddressOf Me.cmbxPropertyName_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x170001DA RID: 474
        ' (get) Token: 0x0600062E RID: 1582 RVA: 0x0024A3B8 File Offset: 0x002493B8
        ' (set) Token: 0x0600062D RID: 1581 RVA: 0x0024A364 File Offset: 0x00249364
        Friend Overridable Property cmbxSubtype() As ComboBox
            Get
                Return Me._cmbxSubtype
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxSubtype IsNot Nothing Then
                    RemoveHandler Me._cmbxSubtype.SelectedIndexChanged, AddressOf Me.cmbxSubtype_SelectedIndexChanged
                End If
                Me._cmbxSubtype = value
                If Me._cmbxSubtype IsNot Nothing Then
                    AddHandler Me._cmbxSubtype.SelectedIndexChanged, AddressOf Me.cmbxSubtype_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x170001DB RID: 475
        ' (get) Token: 0x06000630 RID: 1584 RVA: 0x0024A420 File Offset: 0x00249420
        ' (set) Token: 0x0600062F RID: 1583 RVA: 0x0024A3CC File Offset: 0x002493CC
        Friend Overridable Property cmbxParam1Value() As ComboBox
            Get
                Return Me._cmbxParam1Value
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxParam1Value IsNot Nothing Then
                    RemoveHandler Me._cmbxParam1Value.SelectedIndexChanged, AddressOf Me.cmbxParam1Value_SelectedIndexChanged
                End If
                Me._cmbxParam1Value = value
                If Me._cmbxParam1Value IsNot Nothing Then
                    AddHandler Me._cmbxParam1Value.SelectedIndexChanged, AddressOf Me.cmbxParam1Value_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x170001DC RID: 476
        ' (get) Token: 0x06000631 RID: 1585 RVA: 0x0024A450 File Offset: 0x00249450
        ' (set) Token: 0x06000632 RID: 1586 RVA: 0x0024A434 File Offset: 0x00249434
        Friend Overridable Property nudPercentChance() As NumericUpDown
            Get
                Return Me._nudPercentChance
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudPercentChance IsNot Nothing Then
                End If
                Me._nudPercentChance = value
                If Me._nudPercentChance IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001DD RID: 477
        ' (get) Token: 0x06000633 RID: 1587 RVA: 0x0024A464 File Offset: 0x00249464
        ' (set) Token: 0x06000634 RID: 1588 RVA: 0x0024A478 File Offset: 0x00249478
        Friend Overridable Property lblParam1() As Label
            Get
                Return Me._lblParam1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblParam1 IsNot Nothing Then
                End If
                Me._lblParam1 = value
                If Me._lblParam1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001DE RID: 478
        ' (get) Token: 0x06000635 RID: 1589 RVA: 0x0024A494 File Offset: 0x00249494
        ' (set) Token: 0x06000636 RID: 1590 RVA: 0x0024A4A8 File Offset: 0x002494A8
        Friend Overridable Property lblCostTable() As Label
            Get
                Return Me._lblCostTable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblCostTable IsNot Nothing Then
                End If
                Me._lblCostTable = value
                If Me._lblCostTable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001DF RID: 479
        ' (get) Token: 0x06000637 RID: 1591 RVA: 0x0024A518 File Offset: 0x00249518
        ' (set) Token: 0x06000638 RID: 1592 RVA: 0x0024A4C4 File Offset: 0x002494C4
        Friend Overridable Property cmbxCostValue() As ComboBox
            Get
                Return Me._cmbxCostValue
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxCostValue IsNot Nothing Then
                    RemoveHandler Me._cmbxCostValue.SelectedIndexChanged, AddressOf Me.cmbxCostValue_SelectedIndexChanged
                End If
                Me._cmbxCostValue = value
                If Me._cmbxCostValue IsNot Nothing Then
                    AddHandler Me._cmbxCostValue.SelectedIndexChanged, AddressOf Me.cmbxCostValue_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x170001E0 RID: 480
        ' (get) Token: 0x06000639 RID: 1593 RVA: 0x0024A548 File Offset: 0x00249548
        ' (set) Token: 0x0600063A RID: 1594 RVA: 0x0024A52C File Offset: 0x0024952C
        Friend Overridable Property lblParam2() As Label
            Get
                Return Me._lblParam2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblParam2 IsNot Nothing Then
                End If
                Me._lblParam2 = value
                If Me._lblParam2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001E1 RID: 481
        ' (get) Token: 0x0600063C RID: 1596 RVA: 0x0024A55C File Offset: 0x0024955C
        ' (set) Token: 0x0600063B RID: 1595 RVA: 0x0024A570 File Offset: 0x00249570
        Friend Overridable Property cmbxParam2Value() As ComboBox
            Get
                Return Me._cmbxParam2Value
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxParam2Value IsNot Nothing Then
                    RemoveHandler Me._cmbxParam2Value.SelectedIndexChanged, AddressOf Me.cmbxParam2Value_SelectedIndexChanged
                End If
                Me._cmbxParam2Value = value
                If Me._cmbxParam2Value IsNot Nothing Then
                    AddHandler Me._cmbxParam2Value.SelectedIndexChanged, AddressOf Me.cmbxParam2Value_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x170001E2 RID: 482
        ' (get) Token: 0x0600063E RID: 1598 RVA: 0x0024A5C4 File Offset: 0x002495C4
        ' (set) Token: 0x0600063D RID: 1597 RVA: 0x0024A5D8 File Offset: 0x002495D8
        Friend Overridable Property tbStatus() As TextBox
            Get
                Return Me._tbStatus
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbStatus IsNot Nothing Then
                End If
                Me._tbStatus = value
                If Me._tbStatus IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001E3 RID: 483
        ' (get) Token: 0x0600063F RID: 1599 RVA: 0x0024A610 File Offset: 0x00249610
        ' (set) Token: 0x06000640 RID: 1600 RVA: 0x0024A5F4 File Offset: 0x002495F4
        Friend Overridable Property tbSubtyperesref() As TextBox
            Get
                Return Me._tbSubtyperesref
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbSubtyperesref IsNot Nothing Then
                End If
                Me._tbSubtyperesref = value
                If Me._tbSubtyperesref IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001E4 RID: 484
        ' (get) Token: 0x06000641 RID: 1601 RVA: 0x0024A640 File Offset: 0x00249640
        ' (set) Token: 0x06000642 RID: 1602 RVA: 0x0024A624 File Offset: 0x00249624
        Friend Overridable Property tbCostTableID() As TextBox
            Get
                Return Me._tbCostTableID
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCostTableID IsNot Nothing Then
                End If
                Me._tbCostTableID = value
                If Me._tbCostTableID IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001E5 RID: 485
        ' (get) Token: 0x06000643 RID: 1603 RVA: 0x0024A654 File Offset: 0x00249654
        ' (set) Token: 0x06000644 RID: 1604 RVA: 0x0024A668 File Offset: 0x00249668
        Friend Overridable Property tbCostTableName() As TextBox
            Get
                Return Me._tbCostTableName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCostTableName IsNot Nothing Then
                End If
                Me._tbCostTableName = value
                If Me._tbCostTableName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001E6 RID: 486
        ' (get) Token: 0x06000645 RID: 1605 RVA: 0x0024A684 File Offset: 0x00249684
        ' (set) Token: 0x06000646 RID: 1606 RVA: 0x0024A698 File Offset: 0x00249698
        Friend Overridable Property tbParam1resref() As TextBox
            Get
                Return Me._tbParam1resref
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbParam1resref IsNot Nothing Then
                End If
                Me._tbParam1resref = value
                If Me._tbParam1resref IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001E7 RID: 487
        ' (get) Token: 0x06000647 RID: 1607 RVA: 0x0024A6B4 File Offset: 0x002496B4
        ' (set) Token: 0x06000648 RID: 1608 RVA: 0x0024A6C8 File Offset: 0x002496C8
        Friend Overridable Property tbParam2resref() As TextBox
            Get
                Return Me._tbParam2resref
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbParam2resref IsNot Nothing Then
                End If
                Me._tbParam2resref = value
                If Me._tbParam2resref IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001E8 RID: 488
        ' (get) Token: 0x0600064A RID: 1610 RVA: 0x0024A6E4 File Offset: 0x002496E4
        ' (set) Token: 0x06000649 RID: 1609 RVA: 0x0024A6F8 File Offset: 0x002496F8
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

        ' Token: 0x170001E9 RID: 489
        ' (get) Token: 0x0600064C RID: 1612 RVA: 0x0024A714 File Offset: 0x00249714
        ' (set) Token: 0x0600064B RID: 1611 RVA: 0x0024A728 File Offset: 0x00249728
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

        ' Token: 0x170001EA RID: 490
        ' (get) Token: 0x0600064E RID: 1614 RVA: 0x0024A760 File Offset: 0x00249760
        ' (set) Token: 0x0600064D RID: 1613 RVA: 0x0024A744 File Offset: 0x00249744
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

        ' Token: 0x170001EB RID: 491
        ' (get) Token: 0x0600064F RID: 1615 RVA: 0x0024A774 File Offset: 0x00249774
        ' (set) Token: 0x06000650 RID: 1616 RVA: 0x0024A788 File Offset: 0x00249788
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

        ' Token: 0x170001EC RID: 492
        ' (get) Token: 0x06000651 RID: 1617 RVA: 0x0024A7A4 File Offset: 0x002497A4
        ' (set) Token: 0x06000652 RID: 1618 RVA: 0x0024A7B8 File Offset: 0x002497B8
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

        ' Token: 0x170001ED RID: 493
        ' (get) Token: 0x06000653 RID: 1619 RVA: 0x0024A7D4 File Offset: 0x002497D4
        ' (set) Token: 0x06000654 RID: 1620 RVA: 0x0024A7E8 File Offset: 0x002497E8
        Friend Overridable Property tbParam1tableresref() As TextBox
            Get
                Return Me._tbParam1tableresref
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbParam1tableresref IsNot Nothing Then
                End If
                Me._tbParam1tableresref = value
                If Me._tbParam1tableresref IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001EE RID: 494
        ' (get) Token: 0x06000656 RID: 1622 RVA: 0x0024A804 File Offset: 0x00249804
        ' (set) Token: 0x06000655 RID: 1621 RVA: 0x0024A818 File Offset: 0x00249818
        Friend Overridable Property label99() As Label
            Get
                Return Me._label99
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._label99 IsNot Nothing Then
                End If
                Me._label99 = value
                If Me._label99 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001EF RID: 495
        ' (get) Token: 0x06000658 RID: 1624 RVA: 0x0024A850 File Offset: 0x00249850
        ' (set) Token: 0x06000657 RID: 1623 RVA: 0x0024A834 File Offset: 0x00249834
        Friend Overridable Property tbParam2tableresref() As TextBox
            Get
                Return Me._tbParam2tableresref
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbParam2tableresref IsNot Nothing Then
                End If
                Me._tbParam2tableresref = value
                If Me._tbParam2tableresref IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001F0 RID: 496
        ' (get) Token: 0x0600065A RID: 1626 RVA: 0x0024A880 File Offset: 0x00249880
        ' (set) Token: 0x06000659 RID: 1625 RVA: 0x0024A864 File Offset: 0x00249864
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

        ' Token: 0x170001F1 RID: 497
        ' (get) Token: 0x0600065B RID: 1627 RVA: 0x0024A8B0 File Offset: 0x002498B0
        ' (set) Token: 0x0600065C RID: 1628 RVA: 0x0024A894 File Offset: 0x00249894
        Friend Overridable Property lblParam2Desc() As Label
            Get
                Return Me._lblParam2Desc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblParam2Desc IsNot Nothing Then
                End If
                Me._lblParam2Desc = value
                If Me._lblParam2Desc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001F2 RID: 498
        ' (get) Token: 0x0600065D RID: 1629 RVA: 0x0024A8E0 File Offset: 0x002498E0
        ' (set) Token: 0x0600065E RID: 1630 RVA: 0x0024A8C4 File Offset: 0x002498C4
        Friend Overridable Property lblParam1Desc() As Label
            Get
                Return Me._lblParam1Desc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblParam1Desc IsNot Nothing Then
                End If
                Me._lblParam1Desc = value
                If Me._lblParam1Desc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001F3 RID: 499
        ' (get) Token: 0x06000660 RID: 1632 RVA: 0x0024A8F4 File Offset: 0x002498F4
        ' (set) Token: 0x0600065F RID: 1631 RVA: 0x0024A908 File Offset: 0x00249908
        Friend Overridable Property lblValueDesc() As Label
            Get
                Return Me._lblValueDesc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblValueDesc IsNot Nothing Then
                End If
                Me._lblValueDesc = value
                If Me._lblValueDesc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001F4 RID: 500
        ' (get) Token: 0x06000662 RID: 1634 RVA: 0x0024A940 File Offset: 0x00249940
        ' (set) Token: 0x06000661 RID: 1633 RVA: 0x0024A924 File Offset: 0x00249924
        Friend Overridable Property lblSubtypeDesc() As Label
            Get
                Return Me._lblSubtypeDesc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblSubtypeDesc IsNot Nothing Then
                End If
                Me._lblSubtypeDesc = value
                If Me._lblSubtypeDesc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001F5 RID: 501
        ' (get) Token: 0x06000663 RID: 1635 RVA: 0x0024A954 File Offset: 0x00249954
        ' (set) Token: 0x06000664 RID: 1636 RVA: 0x0024A968 File Offset: 0x00249968
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

        ' Token: 0x170001F6 RID: 502
        ' (get) Token: 0x06000665 RID: 1637 RVA: 0x0024A9D8 File Offset: 0x002499D8
        ' (set) Token: 0x06000666 RID: 1638 RVA: 0x0024A9BC File Offset: 0x002499BC
        Friend Overridable Property cmbxUpgrade() As ComboBox
            Get
                Return Me._cmbxUpgrade
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxUpgrade IsNot Nothing Then
                End If
                Me._cmbxUpgrade = value
                If Me._cmbxUpgrade IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170001F7 RID: 503
        ' (get) Token: 0x06000667 RID: 1639 RVA: 0x0024A9EC File Offset: 0x002499EC
        ' (set) Token: 0x06000668 RID: 1640 RVA: 0x0024AA00 File Offset: 0x00249A00
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

        ' Token: 0x0600066A RID: 1642 RVA: 0x0024BCF8 File Offset: 0x0024ACF8
        Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.Name)
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x0600066B RID: 1643 RVA: 0x0024BD18 File Offset: 0x0024AD18
        Private Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.Name)
        End Sub

        ' Token: 0x0600066C RID: 1644 RVA: 0x0024BD28 File Offset: 0x0024AD28
        Public Sub New(ByVal PropertyID As Integer, ByVal SubtypeID As Integer, ByVal CostTableID As Integer, ByVal CostTableValue As Integer, ByVal Param1ID As Integer, ByVal Param1Value As Integer, ByVal Param2ID As Integer, ByVal Param2Value As Integer, ByVal KotorVerIndex As Integer)
            Me.New(KotorVerIndex)
            Me.cmbxPropertyName.SelectedIndex = PropertyID
            If Me.cmbxSubtype.Items.Count > 0 Then
                Me.cmbxSubtype.SelectedIndex = SubtypeID
            End If
            Me.cmbxCostValue.SelectedIndex = CostTableValue
        End Sub

        ' Token: 0x0600066D RID: 1645 RVA: 0x0024BD78 File Offset: 0x0024AD78
        Private Sub FillComboBoxFrom2DA(ByVal cmbx As ComboBox, ByVal colName As String, ByVal TwoDA As cls2DA, Optional ByVal DialogTlk As clsDialogTlk = Nothing)
            cmbx.Items.Clear()
            If DialogTlk IsNot Nothing Then
                Dim num As Integer = 0
                Dim rowsUpperBound As Integer = TwoDA.RowsUpperBound
                For i As Integer = num To rowsUpperBound
                    Dim indiceData As Object = TwoDA.GetIndiceData(i, colName)
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
                        cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
                    Else
                        cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
                    End If
                Next
            Else
                Dim num2 As Integer = 0
                Dim rowsUpperBound2 As Integer = TwoDA.RowsUpperBound
                For i As Integer = num2 To rowsUpperBound2
                    cmbx.Items.Add(TwoDA.GetIndiceData(i, colName))
                Next
            End If
        End Sub

        ' Token: 0x0600066E RID: 1646 RVA: 0x0024BE14 File Offset: 0x0024AE14
        Public Function ReadCls2DA(ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey) As cls2DA
            Dim flag As Boolean = True
            Dim array As Byte() = Nothing
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

        ' Token: 0x0600066F RID: 1647 RVA: 0x0024BF50 File Offset: 0x0024AF50
        Public Sub Load2DAs()
            Me.itempropdef = Me.ReadCls2DA("itempropdef", Me.g_clsChitinKey)
            Me.iprp_costtable = Me.ReadCls2DA("iprp_costtable", Me.g_clsChitinKey)
            Me.iprp_paramtable = Me.ReadCls2DA("iprp_paramtable", Me.g_clsChitinKey)
        End Sub

        ' Token: 0x06000670 RID: 1648 RVA: 0x0024BFA4 File Offset: 0x0024AFA4
        Private Sub cmbxPropertyName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim indiceData As String = Me.itempropdef.GetIndiceData(Me.cmbxPropertyName.SelectedIndex, "subtyperesref")
            Dim indiceData2 As String = Me.itempropdef.GetIndiceData(Me.cmbxPropertyName.SelectedIndex, "costtableresref")
            Dim indiceData3 As String = Me.itempropdef.GetIndiceData(Me.cmbxPropertyName.SelectedIndex, "param1resref")
            Me.CostTableID = indiceData2
            If (StringType.StrCmp(indiceData2, "****", False) = 0) Or (StringType.StrCmp(indiceData2, "0", False) = 0) Then
                Me.CostTableName = "None"
            Else
                Me.CostTableName = Me.iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "label")
            End If
            Me.cmbxParam1Value.Enabled = False
            Me.cmbxParam1Value.Items.Clear()
            Me.cmbxParam2Value.Enabled = False
            Me.cmbxParam2Value.Items.Clear()
            Me.tbCostTableID.Text = indiceData2
            Me.tbCostTableName.Text = Me.CostTableName
            Me.tbSubtyperesref.Text = indiceData
            Me.lblValueDesc.Text = "(" + Strings.Replace(Me.CostTableName, "_", " ", 1, -1, CompareMethod.Binary) + ")"
            If StringType.StrCmp(indiceData, "****", False) = 0 Then
                Me.cmbxSubtype.Enabled = False
                Me.cmbxSubtype.Items.Clear()
                Me.lblSubtypeDesc.Text = "(None)"
                If StringType.StrCmp(indiceData2, "0", False) <> 0 Then
                    Dim text As String = Me.iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "name")
                    Me.FillComboBoxFrom2DA(Me.cmbxCostValue, "name", Me.ReadCls2DA(text, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                    Me.cmbxCostValue.Enabled = True
                    Me.tbStatus.Text = "cmbxCostValue specifies CostValue"
                Else
                    Me.cmbxCostValue.Enabled = False
                    Me.cmbxCostValue.Items.Clear()
                    Me.tbStatus.Text = "No cost value needed"
                    Me.CostValue = 0
                End If
            Else
                ' The following expression was wrapped in a checked-expression
                Dim text As String = Strings.Mid(indiceData, Strings.InStr(indiceData, "_", CompareMethod.Binary) + 1)
                Me.lblSubtypeDesc.Text = "(" + Strings.UCase(Strings.Mid(text, 1, 1)) + Strings.LCase(Strings.Mid(text, 2)) + ")"
                Dim cls2DA As cls2DA = Me.ReadCls2DA(indiceData, Me.g_clsChitinKey)
                If StringType.StrCmp(indiceData, "Appearance", False) = 0 Then
                    Me.FillComboBoxFrom2DA(Me.cmbxSubtype, "label", cls2DA, Nothing)
                Else
                    Me.FillComboBoxFrom2DA(Me.cmbxSubtype, "name", cls2DA, Me.g_clsDialogTlk)
                End If
                Me.cmbxSubtype.Enabled = True
                If StringType.StrCmp(indiceData2, "****", False) = 0 OrElse StringType.StrCmp(indiceData2, "0", False) = 0 Then
                    Me.cmbxCostValue.Enabled = False
                    Me.cmbxCostValue.Items.Clear()
                    Me.tbStatus.Text = "cmbxSubtype specifies CostValue"
                Else
                    text = Me.iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "name")
                    Me.FillComboBoxFrom2DA(Me.cmbxCostValue, "name", Me.ReadCls2DA(text, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                    Me.cmbxCostValue.Enabled = True
                    Me.tbStatus.Text = "cmbxCostValue specifies CostValue"
                End If
            End If
            If StringType.StrCmp(indiceData3, "****", False) = 0 Then
                Me.cmbxParam1Value.Enabled = False
                Me.cmbxParam1Value.Items.Clear()
                Me.g_bCmbxPropertyHasParam1ResRef = False
                Me.tbParam1tableresref.Text = "None"
                Me.lblParam1Desc.Text = "(None)"
            Else
                Me.cmbxParam1Value.Enabled = True
                Dim num As Integer = IntegerType.FromString(indiceData3)
                Dim text As String = Me.iprp_paramtable.GetIndiceData(num, "tableresref")
                Me.FillComboBoxFrom2DA(Me.cmbxParam1Value, "name", Me.ReadCls2DA(text, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                Me.g_bCmbxPropertyHasParam1ResRef = True
                Me.tbParam1tableresref.Text = text
                Me.Param1Desc = Me.iprp_paramtable.GetIndiceData(num, "label")
                Me.lblParam1Desc.Text = "(" + Me.Param1Desc + ")"
                Me.tbParam1resref.Text = indiceData3
            End If
            Me.cmbxUpgrade.Enabled = True
            Me.cmbxUpgrade.SelectedIndex = 0
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x06000671 RID: 1649 RVA: 0x0024C434 File Offset: 0x0024B434
        Private Sub cmbxSubtype_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.g_bCmbxPropertyHasParam1ResRef Then
                Return
            End If
            Dim indiceData As String = Me.itempropdef.GetIndiceData(Me.cmbxPropertyName.SelectedIndex, "subtyperesref")
            Dim cls2DA As cls2DA = Me.ReadCls2DA(indiceData, Me.g_clsChitinKey)
            Dim flag As Boolean = False
            Dim num As Integer = 0
            Dim columnUpperBound As Integer = cls2DA.ColumnUpperBound
            For i As Integer = num To columnUpperBound
                If StringType.StrCmp(Strings.LCase(cls2DA.ColNames(i)), "param1resref", False) = 0 Then
                    flag = True
                    Exit For
                End If
            Next
            If flag Then
                Dim text As String = cls2DA.GetIndiceData(Me.cmbxSubtype.SelectedIndex, "param1resref")
                Me.tbParam1resref.Text = text
                If StringType.StrCmp(text, "****", False) = 0 Then
                    Me.cmbxParam1Value.Enabled = False
                    Me.cmbxParam1Value.Items.Clear()
                    Me.tbParam1tableresref.Text = "None"
                    Me.lblParam1Desc.Text = "(None)"
                Else
                    Me.cmbxParam1Value.Enabled = True
                    Dim i As Integer = IntegerType.FromString(text)
                    text = Me.iprp_paramtable.GetIndiceData(i, "tableresref")
                    Me.FillComboBoxFrom2DA(Me.cmbxParam1Value, "name", Me.ReadCls2DA(text, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                    Me.tbParam1tableresref.Text = text
                    Me.Param1Desc = Me.iprp_paramtable.GetIndiceData(i, "label")
                    Me.lblParam1Desc.Text = "(" + Me.Param1Desc + ")"
                End If
            Else
                Me.cmbxParam1Value.Enabled = False
                Me.cmbxParam1Value.Items.Clear()
            End If
            flag = False
            Dim num2 As Integer = 0
            Dim columnUpperBound2 As Integer = cls2DA.ColumnUpperBound
            For i As Integer = num2 To columnUpperBound2
                If StringType.StrCmp(Strings.LCase(cls2DA.ColNames(i)), "param2resref", False) = 0 Then
                    flag = True
                    Exit For
                End If
            Next
            If flag Then
                Dim text2 As String = cls2DA.GetIndiceData(Me.cmbxSubtype.SelectedIndex, "param2resref")
                Me.tbParam2resref.Text = text2
                If StringType.StrCmp(text2, "****", False) = 0 Then
                    Me.cmbxParam2Value.Enabled = False
                    Me.cmbxParam2Value.Items.Clear()
                    Me.tbParam1tableresref.Text = "None"
                    Me.lblParam2Desc.Text = "(None)"
                Else
                    Me.cmbxParam2Value.Enabled = True
                    Dim i As Integer = IntegerType.FromString(text2)
                    text2 = Me.iprp_paramtable.GetIndiceData(i, "tableresref")
                    Me.FillComboBoxFrom2DA(Me.cmbxParam2Value, "name", Me.ReadCls2DA(text2, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                    Me.tbParam2tableresref.Text = text2
                    Me.Param2Desc = Me.iprp_paramtable.GetIndiceData(i, "label")
                    Me.lblParam2Desc.Text = "(" + Me.Param2Desc + ")"
                End If
            Else
                Me.cmbxParam2Value.Enabled = False
                Me.cmbxParam2Value.Items.Clear()
            End If
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x06000672 RID: 1650 RVA: 0x0024C748 File Offset: 0x0024B748
        Private Function ValidateForm() As Boolean
            Return Me.cmbxPropertyName.SelectedIndex <> -1 AndAlso Not (Me.cmbxSubtype.Enabled And (Me.cmbxSubtype.SelectedIndex = -1)) AndAlso Not (Me.cmbxCostValue.Enabled And (Me.cmbxCostValue.SelectedIndex = -1)) AndAlso Not (Me.cmbxParam1Value.Enabled And (Me.cmbxParam1Value.SelectedIndex = -1)) AndAlso Not (Me.cmbxParam2Value.Enabled And (Me.cmbxParam2Value.SelectedIndex = -1))
        End Function

        ' Token: 0x06000673 RID: 1651 RVA: 0x0024C7E0 File Offset: 0x0024B7E0
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.debug Then
                Dim size As Size = New Size(520, 296)
                Me.Size = size
                size = New Size(520, 296)
                Me.MaximumSize = size
                size = New Size(520, 296)
                Me.MinimumSize = size
                Me.debug = False
            Else
                Dim size As Size = New Size(720, 376)
                Me.MaximumSize = size
                size = New Size(720, 376)
                Me.MinimumSize = size
                size = New Size(720, 376)
                Me.Size = size
                Me.debug = True
            End If
        End Sub

        ' Token: 0x06000674 RID: 1652 RVA: 0x0024C898 File Offset: 0x0024B898
        Private Sub cmbxCostValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x06000675 RID: 1653 RVA: 0x0024C8AC File Offset: 0x0024B8AC
        Private Sub cmbxParam1Value_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x06000676 RID: 1654 RVA: 0x0024C8C0 File Offset: 0x0024B8C0
        Private Sub cmbxParam2Value_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x04000337 RID: 823
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000338 RID: 824
        <AccessedThroughProperty("cmbxPropertyName")> _
        Private _cmbxPropertyName As ComboBox

        ' Token: 0x04000339 RID: 825
        <AccessedThroughProperty("cmbxSubtype")> _
        Private _cmbxSubtype As ComboBox

        ' Token: 0x0400033A RID: 826
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x0400033B RID: 827
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x0400033C RID: 828
        <AccessedThroughProperty("cmbxUpgrade")> _
        Private _cmbxUpgrade As ComboBox

        ' Token: 0x0400033D RID: 829
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x0400033E RID: 830
        <AccessedThroughProperty("lblSubtypeDesc")> _
        Private _lblSubtypeDesc As Label

        ' Token: 0x0400033F RID: 831
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x04000340 RID: 832
        <AccessedThroughProperty("lblValueDesc")> _
        Private _lblValueDesc As Label

        ' Token: 0x04000341 RID: 833
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x04000342 RID: 834
        <AccessedThroughProperty("lblParam1Desc")> _
        Private _lblParam1Desc As Label

        ' Token: 0x04000343 RID: 835
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x04000344 RID: 836
        <AccessedThroughProperty("lblParam2Desc")> _
        Private _lblParam2Desc As Label

        ' Token: 0x04000345 RID: 837
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x04000346 RID: 838
        <AccessedThroughProperty("tbParam2tableresref")> _
        Private _tbParam2tableresref As TextBox

        ' Token: 0x04000347 RID: 839
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000348 RID: 840
        <AccessedThroughProperty("label99")> _
        Private _label99 As Label

        ' Token: 0x04000349 RID: 841
        <AccessedThroughProperty("tbParam1tableresref")> _
        Private _tbParam1tableresref As TextBox

        ' Token: 0x0400034A RID: 842
        <AccessedThroughProperty("cmbxParam1Value")> _
        Private _cmbxParam1Value As ComboBox

        ' Token: 0x0400034B RID: 843
        <AccessedThroughProperty("nudPercentChance")> _
        Private _nudPercentChance As NumericUpDown

        ' Token: 0x0400034C RID: 844
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x0400034D RID: 845
        <AccessedThroughProperty("lblParam1")> _
        Private _lblParam1 As Label

        ' Token: 0x0400034E RID: 846
        <AccessedThroughProperty("lblCostTable")> _
        Private _lblCostTable As Label

        ' Token: 0x0400034F RID: 847
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000350 RID: 848
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000351 RID: 849
        <AccessedThroughProperty("cmbxCostValue")> _
        Private _cmbxCostValue As ComboBox

        ' Token: 0x04000352 RID: 850
        <AccessedThroughProperty("lblParam2")> _
        Private _lblParam2 As Label

        ' Token: 0x04000353 RID: 851
        <AccessedThroughProperty("cmbxParam2Value")> _
        Private _cmbxParam2Value As ComboBox

        ' Token: 0x04000354 RID: 852
        <AccessedThroughProperty("tbParam2resref")> _
        Private _tbParam2resref As TextBox

        ' Token: 0x04000355 RID: 853
        <AccessedThroughProperty("tbParam1resref")> _
        Private _tbParam1resref As TextBox

        ' Token: 0x04000356 RID: 854
        <AccessedThroughProperty("tbCostTableName")> _
        Private _tbCostTableName As TextBox

        ' Token: 0x04000357 RID: 855
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000358 RID: 856
        <AccessedThroughProperty("tbStatus")> _
        Private _tbStatus As TextBox

        ' Token: 0x04000359 RID: 857
        <AccessedThroughProperty("tbSubtyperesref")> _
        Private _tbSubtyperesref As TextBox

        ' Token: 0x0400035A RID: 858
        <AccessedThroughProperty("tbCostTableID")> _
        Private _tbCostTableID As TextBox

        ' Token: 0x0400035C RID: 860
        Private usetting As UserSettings

        ' Token: 0x0400035D RID: 861
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x0400035E RID: 862
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x0400035F RID: 863
        Private itempropdef As cls2DA

        ' Token: 0x04000360 RID: 864
        Private iprp_costtable As cls2DA

        ' Token: 0x04000361 RID: 865
        Private iprp_paramtable As cls2DA

        ' Token: 0x04000362 RID: 866
        Private iprp_abilities As cls2DA

        ' Token: 0x04000363 RID: 867
        Private appearance As cls2DA

        ' Token: 0x04000364 RID: 868
        Private classes As cls2DA

        ' Token: 0x04000365 RID: 869
        Private feat As cls2DA

        ' Token: 0x04000366 RID: 870
        Private iprp_acmodtype As cls2DA

        ' Token: 0x04000367 RID: 871
        Private iprp_aligngrp As cls2DA

        ' Token: 0x04000368 RID: 872
        Private iprp_ammotype As cls2DA

        ' Token: 0x04000369 RID: 873
        Private iprp_combatdam As cls2DA

        ' Token: 0x0400036A RID: 874
        Private iprp_damagetype As cls2DA

        ' Token: 0x0400036B RID: 875
        Private iprp_immunity As cls2DA

        ' Token: 0x0400036C RID: 876
        Private iprp_monsterhit As cls2DA

        ' Token: 0x0400036D RID: 877
        Private iprp_onhit As cls2DA

        ' Token: 0x0400036E RID: 878
        Private iprp_protection As cls2DA

        ' Token: 0x0400036F RID: 879
        Private iprp_saveelement As cls2DA

        ' Token: 0x04000370 RID: 880
        Private iprp_savingthrow As cls2DA

        ' Token: 0x04000371 RID: 881
        Private iprp_walk As cls2DA

        ' Token: 0x04000372 RID: 882
        Private racialtypes As cls2DA

        ' Token: 0x04000373 RID: 883
        Private skills As cls2DA

        ' Token: 0x04000374 RID: 884
        Private spells As cls2DA

        ' Token: 0x04000375 RID: 885
        Private traps As cls2DA

        ' Token: 0x04000376 RID: 886
        Public g_bCmbxPropertyHasParam1ResRef As Boolean

        ' Token: 0x04000377 RID: 887
        Public CostTableValue As Integer

        ' Token: 0x04000378 RID: 888
        Public CostTableID As String

        ' Token: 0x04000379 RID: 889
        Public CostTableName As String

        ' Token: 0x0400037A RID: 890
        Public Param1Desc As String

        ' Token: 0x0400037B RID: 891
        Public Param2Desc As String

        ' Token: 0x0400037C RID: 892
        Public CostValue As Integer

        ' Token: 0x0400037D RID: 893
        Private debug As Boolean
    End Class
End Namespace
