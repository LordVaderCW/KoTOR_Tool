Imports System
Imports System.Collections
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
	' Token: 0x0200007C RID: 124
	Public Partial Class frmUTC_Editor
		Inherits frmParent

		' Token: 0x06001109 RID: 4361 RVA: 0x0029F1C0 File Offset: 0x0029E1C0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTC_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTC_Editor_Closing
			Me.ComboBoxSettingError = False
			Me.m_bSaveGameMode = False
			Me.g_ForcePowerList = New ArrayList()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000618 RID: 1560
		' (get) Token: 0x0600110B RID: 4363 RVA: 0x0029F254 File Offset: 0x0029E254
		' (set) Token: 0x0600110C RID: 4364 RVA: 0x0029F238 File Offset: 0x0029E238
		Friend Overridable Property tpBasic As TabPage
			Get
				Return Me._tpBasic
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpBasic IsNot Nothing Then
                End If
                Me._tpBasic = value
                If Me._tpBasic IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000619 RID: 1561
        ' (get) Token: 0x0600110E RID: 4366 RVA: 0x0029F284 File Offset: 0x0029E284
        ' (set) Token: 0x0600110D RID: 4365 RVA: 0x0029F268 File Offset: 0x0029E268
        Friend Overridable Property tpStatistics() As TabPage
            Get
                Return Me._tpStatistics
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpStatistics IsNot Nothing Then
                End If
                Me._tpStatistics = value
                If Me._tpStatistics IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700061A RID: 1562
        ' (get) Token: 0x06001110 RID: 4368 RVA: 0x0029F2B4 File Offset: 0x0029E2B4
        ' (set) Token: 0x0600110F RID: 4367 RVA: 0x0029F298 File Offset: 0x0029E298
        Friend Overridable Property tpClasses() As TabPage
            Get
                Return Me._tpClasses
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpClasses IsNot Nothing Then
                End If
                Me._tpClasses = value
                If Me._tpClasses IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700061B RID: 1563
        ' (get) Token: 0x06001111 RID: 4369 RVA: 0x0029F2C8 File Offset: 0x0029E2C8
        ' (set) Token: 0x06001112 RID: 4370 RVA: 0x0029F2DC File Offset: 0x0029E2DC
        Friend Overridable Property tpSkills() As TabPage
            Get
                Return Me._tpSkills
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpSkills IsNot Nothing Then
                End If
                Me._tpSkills = value
                If Me._tpSkills IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700061C RID: 1564
        ' (get) Token: 0x06001114 RID: 4372 RVA: 0x0029F2F8 File Offset: 0x0029E2F8
        ' (set) Token: 0x06001113 RID: 4371 RVA: 0x0029F30C File Offset: 0x0029E30C
        Friend Overridable Property tpScripts() As TabPage
            Get
                Return Me._tpScripts
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpScripts IsNot Nothing Then
                End If
                Me._tpScripts = value
                If Me._tpScripts IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700061D RID: 1565
        ' (get) Token: 0x06001116 RID: 4374 RVA: 0x0029F328 File Offset: 0x0029E328
        ' (set) Token: 0x06001115 RID: 4373 RVA: 0x0029F33C File Offset: 0x0029E33C
        Friend Overridable Property tpAdvanced() As TabPage
            Get
                Return Me._tpAdvanced
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpAdvanced IsNot Nothing Then
                End If
                Me._tpAdvanced = value
                If Me._tpAdvanced IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700061E RID: 1566
        ' (get) Token: 0x06001118 RID: 4376 RVA: 0x0029F358 File Offset: 0x0029E358
        ' (set) Token: 0x06001117 RID: 4375 RVA: 0x0029F36C File Offset: 0x0029E36C
        Friend Overridable Property tpFeats() As TabPage
            Get
                Return Me._tpFeats
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpFeats IsNot Nothing Then
                End If
                Me._tpFeats = value
                If Me._tpFeats IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700061F RID: 1567
        ' (get) Token: 0x0600111A RID: 4378 RVA: 0x0029F388 File Offset: 0x0029E388
        ' (set) Token: 0x06001119 RID: 4377 RVA: 0x0029F39C File Offset: 0x0029E39C
        Friend Overridable Property toForcePowers() As TabPage
            Get
                Return Me._toForcePowers
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._toForcePowers IsNot Nothing Then
                End If
                Me._toForcePowers = value
                If Me._toForcePowers IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000620 RID: 1568
        ' (get) Token: 0x0600111C RID: 4380 RVA: 0x0029F3B8 File Offset: 0x0029E3B8
        ' (set) Token: 0x0600111B RID: 4379 RVA: 0x0029F3CC File Offset: 0x0029E3CC
        Friend Overridable Property tpSpecialAbilities() As TabPage
            Get
                Return Me._tpSpecialAbilities
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpSpecialAbilities IsNot Nothing Then
                End If
                Me._tpSpecialAbilities = value
                If Me._tpSpecialAbilities IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000621 RID: 1569
        ' (get) Token: 0x0600111E RID: 4382 RVA: 0x0029F3E8 File Offset: 0x0029E3E8
        ' (set) Token: 0x0600111D RID: 4381 RVA: 0x0029F3FC File Offset: 0x0029E3FC
        Friend Overridable Property tpComments() As TabPage
            Get
                Return Me._tpComments
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tpComments IsNot Nothing Then
                End If
                Me._tpComments = value
                If Me._tpComments IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000622 RID: 1570
        ' (get) Token: 0x0600111F RID: 4383 RVA: 0x0029F434 File Offset: 0x0029E434
        ' (set) Token: 0x06001120 RID: 4384 RVA: 0x0029F418 File Offset: 0x0029E418
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

        ' Token: 0x17000623 RID: 1571
        ' (get) Token: 0x06001122 RID: 4386 RVA: 0x0029F448 File Offset: 0x0029E448
        ' (set) Token: 0x06001121 RID: 4385 RVA: 0x0029F45C File Offset: 0x0029E45C
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

        ' Token: 0x17000624 RID: 1572
        ' (get) Token: 0x06001123 RID: 4387 RVA: 0x0029F478 File Offset: 0x0029E478
        ' (set) Token: 0x06001124 RID: 4388 RVA: 0x0029F48C File Offset: 0x0029E48C
        Friend Overridable Property GroupBox3() As GroupBox
            Get
                Return Me._GroupBox3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox3 IsNot Nothing Then
                End If
                Me._GroupBox3 = value
                If Me._GroupBox3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000625 RID: 1573
        ' (get) Token: 0x06001125 RID: 4389 RVA: 0x0029F4A8 File Offset: 0x0029E4A8
        ' (set) Token: 0x06001126 RID: 4390 RVA: 0x0029F4BC File Offset: 0x0029E4BC
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

        ' Token: 0x17000626 RID: 1574
        ' (get) Token: 0x06001128 RID: 4392 RVA: 0x0029F4F4 File Offset: 0x0029E4F4
        ' (set) Token: 0x06001127 RID: 4391 RVA: 0x0029F4D8 File Offset: 0x0029E4D8
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

        ' Token: 0x17000627 RID: 1575
        ' (get) Token: 0x0600112A RID: 4394 RVA: 0x0029F508 File Offset: 0x0029E508
        ' (set) Token: 0x06001129 RID: 4393 RVA: 0x0029F51C File Offset: 0x0029E51C
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

        ' Token: 0x17000628 RID: 1576
        ' (get) Token: 0x0600112C RID: 4396 RVA: 0x0029F538 File Offset: 0x0029E538
        ' (set) Token: 0x0600112B RID: 4395 RVA: 0x0029F54C File Offset: 0x0029E54C
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

        ' Token: 0x17000629 RID: 1577
        ' (get) Token: 0x0600112D RID: 4397 RVA: 0x0029F584 File Offset: 0x0029E584
        ' (set) Token: 0x0600112E RID: 4398 RVA: 0x0029F568 File Offset: 0x0029E568
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

        ' Token: 0x1700062A RID: 1578
        ' (get) Token: 0x06001130 RID: 4400 RVA: 0x0029F5B4 File Offset: 0x0029E5B4
        ' (set) Token: 0x0600112F RID: 4399 RVA: 0x0029F598 File Offset: 0x0029E598
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

        ' Token: 0x1700062B RID: 1579
        ' (get) Token: 0x06001131 RID: 4401 RVA: 0x0029F5E4 File Offset: 0x0029E5E4
        ' (set) Token: 0x06001132 RID: 4402 RVA: 0x0029F5C8 File Offset: 0x0029E5C8
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

        ' Token: 0x1700062C RID: 1580
        ' (get) Token: 0x06001134 RID: 4404 RVA: 0x0029F5F8 File Offset: 0x0029E5F8
        ' (set) Token: 0x06001133 RID: 4403 RVA: 0x0029F60C File Offset: 0x0029E60C
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

        ' Token: 0x1700062D RID: 1581
        ' (get) Token: 0x06001135 RID: 4405 RVA: 0x0029F644 File Offset: 0x0029E644
        ' (set) Token: 0x06001136 RID: 4406 RVA: 0x0029F628 File Offset: 0x0029E628
        Friend Overridable Property tbConversation() As TextBox
            Get
                Return Me._tbConversation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbConversation IsNot Nothing Then
                End If
                Me._tbConversation = value
                If Me._tbConversation IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700062E RID: 1582
        ' (get) Token: 0x06001138 RID: 4408 RVA: 0x0029F658 File Offset: 0x0029E658
        ' (set) Token: 0x06001137 RID: 4407 RVA: 0x0029F66C File Offset: 0x0029E66C
        Friend Overridable Property cmbxRace() As ComboBox
            Get
                Return Me._cmbxRace
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxRace IsNot Nothing Then
                End If
                Me._cmbxRace = value
                If Me._cmbxRace IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700062F RID: 1583
        ' (get) Token: 0x06001139 RID: 4409 RVA: 0x0029F688 File Offset: 0x0029E688
        ' (set) Token: 0x0600113A RID: 4410 RVA: 0x0029F69C File Offset: 0x0029E69C
        Friend Overridable Property tbFirstName() As TextBox
            Get
                Return Me._tbFirstName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbFirstName IsNot Nothing Then
                End If
                Me._tbFirstName = value
                If Me._tbFirstName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000630 RID: 1584
        ' (get) Token: 0x0600113B RID: 4411 RVA: 0x0029F6B8 File Offset: 0x0029E6B8
        ' (set) Token: 0x0600113C RID: 4412 RVA: 0x0029F6CC File Offset: 0x0029E6CC
        Friend Overridable Property tbLastName() As TextBox
            Get
                Return Me._tbLastName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbLastName IsNot Nothing Then
                End If
                Me._tbLastName = value
                If Me._tbLastName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000631 RID: 1585
        ' (get) Token: 0x0600113E RID: 4414 RVA: 0x0029F704 File Offset: 0x0029E704
        ' (set) Token: 0x0600113D RID: 4413 RVA: 0x0029F6E8 File Offset: 0x0029E6E8
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

        ' Token: 0x17000632 RID: 1586
        ' (get) Token: 0x06001140 RID: 4416 RVA: 0x0029F718 File Offset: 0x0029E718
        ' (set) Token: 0x0600113F RID: 4415 RVA: 0x0029F72C File Offset: 0x0029E72C
        Friend Overridable Property tbDescription() As TextBox
            Get
                Return Me._tbDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbDescription IsNot Nothing Then
                End If
                Me._tbDescription = value
                If Me._tbDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000633 RID: 1587
        ' (get) Token: 0x06001142 RID: 4418 RVA: 0x0029F748 File Offset: 0x0029E748
        ' (set) Token: 0x06001141 RID: 4417 RVA: 0x0029F75C File Offset: 0x0029E75C
        Friend Overridable Property cmbxAppearance() As ComboBox
            Get
                Return Me._cmbxAppearance
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxAppearance IsNot Nothing Then
                End If
                Me._cmbxAppearance = value
                If Me._cmbxAppearance IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000634 RID: 1588
        ' (get) Token: 0x06001144 RID: 4420 RVA: 0x0029F794 File Offset: 0x0029E794
        ' (set) Token: 0x06001143 RID: 4419 RVA: 0x0029F778 File Offset: 0x0029E778
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

        ' Token: 0x17000635 RID: 1589
        ' (get) Token: 0x06001145 RID: 4421 RVA: 0x0029F7A8 File Offset: 0x0029E7A8
        ' (set) Token: 0x06001146 RID: 4422 RVA: 0x0029F7BC File Offset: 0x0029E7BC
        Friend Overridable Property tabCtrl1() As TabControl
            Get
                Return Me._tabCtrl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._tabCtrl1 IsNot Nothing Then
                End If
                Me._tabCtrl1 = value
                If Me._tabCtrl1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000636 RID: 1590
        ' (get) Token: 0x06001147 RID: 4423 RVA: 0x0029F7D8 File Offset: 0x0029E7D8
        ' (set) Token: 0x06001148 RID: 4424 RVA: 0x0029F7EC File Offset: 0x0029E7EC
        Friend Overridable Property cmbxPhenotype() As ComboBox
            Get
                Return Me._cmbxPhenotype
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxPhenotype IsNot Nothing Then
                End If
                Me._cmbxPhenotype = value
                If Me._cmbxPhenotype IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000637 RID: 1591
        ' (get) Token: 0x0600114A RID: 4426 RVA: 0x0029F824 File Offset: 0x0029E824
        ' (set) Token: 0x06001149 RID: 4425 RVA: 0x0029F808 File Offset: 0x0029E808
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

        ' Token: 0x17000638 RID: 1592
        ' (get) Token: 0x0600114B RID: 4427 RVA: 0x0029F854 File Offset: 0x0029E854
        ' (set) Token: 0x0600114C RID: 4428 RVA: 0x0029F838 File Offset: 0x0029E838
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

        ' Token: 0x17000639 RID: 1593
        ' (get) Token: 0x0600114E RID: 4430 RVA: 0x0029F868 File Offset: 0x0029E868
        ' (set) Token: 0x0600114D RID: 4429 RVA: 0x0029F87C File Offset: 0x0029E87C
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

        ' Token: 0x1700063A RID: 1594
        ' (get) Token: 0x0600114F RID: 4431 RVA: 0x0029F898 File Offset: 0x0029E898
        ' (set) Token: 0x06001150 RID: 4432 RVA: 0x0029F8AC File Offset: 0x0029E8AC
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

        ' Token: 0x1700063B RID: 1595
        ' (get) Token: 0x06001152 RID: 4434 RVA: 0x0029F8E4 File Offset: 0x0029E8E4
        ' (set) Token: 0x06001151 RID: 4433 RVA: 0x0029F8C8 File Offset: 0x0029E8C8
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

        ' Token: 0x1700063C RID: 1596
        ' (get) Token: 0x06001153 RID: 4435 RVA: 0x0029F8F8 File Offset: 0x0029E8F8
        ' (set) Token: 0x06001154 RID: 4436 RVA: 0x0029F90C File Offset: 0x0029E90C
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

        ' Token: 0x1700063D RID: 1597
        ' (get) Token: 0x06001156 RID: 4438 RVA: 0x0029F928 File Offset: 0x0029E928
        ' (set) Token: 0x06001155 RID: 4437 RVA: 0x0029F93C File Offset: 0x0029E93C
        Friend Overridable Property GroupBox4() As GroupBox
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

        ' Token: 0x1700063E RID: 1598
        ' (get) Token: 0x06001157 RID: 4439 RVA: 0x0029F958 File Offset: 0x0029E958
        ' (set) Token: 0x06001158 RID: 4440 RVA: 0x0029F96C File Offset: 0x0029E96C
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

        ' Token: 0x1700063F RID: 1599
        ' (get) Token: 0x06001159 RID: 4441 RVA: 0x0029F988 File Offset: 0x0029E988
        ' (set) Token: 0x0600115A RID: 4442 RVA: 0x0029F99C File Offset: 0x0029E99C
        Friend Overridable Property nudStrength() As NumericUpDown
            Get
                Return Me._nudStrength
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudStrength IsNot Nothing Then
                End If
                Me._nudStrength = value
                If Me._nudStrength IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000640 RID: 1600
        ' (get) Token: 0x0600115C RID: 4444 RVA: 0x0029F9B8 File Offset: 0x0029E9B8
        ' (set) Token: 0x0600115B RID: 4443 RVA: 0x0029F9CC File Offset: 0x0029E9CC
        Friend Overridable Property nudDexterity() As NumericUpDown
            Get
                Return Me._nudDexterity
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudDexterity IsNot Nothing Then
                End If
                Me._nudDexterity = value
                If Me._nudDexterity IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000641 RID: 1601
        ' (get) Token: 0x0600115E RID: 4446 RVA: 0x0029F9E8 File Offset: 0x0029E9E8
        ' (set) Token: 0x0600115D RID: 4445 RVA: 0x0029F9FC File Offset: 0x0029E9FC
        Friend Overridable Property nudConstitution() As NumericUpDown
            Get
                Return Me._nudConstitution
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudConstitution IsNot Nothing Then
                End If
                Me._nudConstitution = value
                If Me._nudConstitution IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000642 RID: 1602
        ' (get) Token: 0x06001160 RID: 4448 RVA: 0x0029FA18 File Offset: 0x0029EA18
        ' (set) Token: 0x0600115F RID: 4447 RVA: 0x0029FA2C File Offset: 0x0029EA2C
        Friend Overridable Property nudIntelligence() As NumericUpDown
            Get
                Return Me._nudIntelligence
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudIntelligence IsNot Nothing Then
                End If
                Me._nudIntelligence = value
                If Me._nudIntelligence IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000643 RID: 1603
        ' (get) Token: 0x06001162 RID: 4450 RVA: 0x0029FA64 File Offset: 0x0029EA64
        ' (set) Token: 0x06001161 RID: 4449 RVA: 0x0029FA48 File Offset: 0x0029EA48
        Friend Overridable Property nudWisdom() As NumericUpDown
            Get
                Return Me._nudWisdom
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudWisdom IsNot Nothing Then
                End If
                Me._nudWisdom = value
                If Me._nudWisdom IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000644 RID: 1604
        ' (get) Token: 0x06001163 RID: 4451 RVA: 0x0029FA94 File Offset: 0x0029EA94
        ' (set) Token: 0x06001164 RID: 4452 RVA: 0x0029FA78 File Offset: 0x0029EA78
        Friend Overridable Property nudCharisma() As NumericUpDown
            Get
                Return Me._nudCharisma
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCharisma IsNot Nothing Then
                End If
                Me._nudCharisma = value
                If Me._nudCharisma IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000645 RID: 1605
        ' (get) Token: 0x06001165 RID: 4453 RVA: 0x0029FAC4 File Offset: 0x0029EAC4
        ' (set) Token: 0x06001166 RID: 4454 RVA: 0x0029FAA8 File Offset: 0x0029EAA8
        Friend Overridable Property gb2() As GroupBox
            Get
                Return Me._gb2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gb2 IsNot Nothing Then
                End If
                Me._gb2 = value
                If Me._gb2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000646 RID: 1606
        ' (get) Token: 0x06001168 RID: 4456 RVA: 0x0029FAD8 File Offset: 0x0029EAD8
        ' (set) Token: 0x06001167 RID: 4455 RVA: 0x0029FAEC File Offset: 0x0029EAEC
        Friend Overridable Property GroupBox6() As GroupBox
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

        ' Token: 0x17000647 RID: 1607
        ' (get) Token: 0x06001169 RID: 4457 RVA: 0x0029FB24 File Offset: 0x0029EB24
        ' (set) Token: 0x0600116A RID: 4458 RVA: 0x0029FB08 File Offset: 0x0029EB08
        Friend Overridable Property GroupBox5() As GroupBox
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

        ' Token: 0x17000648 RID: 1608
        ' (get) Token: 0x0600116C RID: 4460 RVA: 0x0029FB38 File Offset: 0x0029EB38
        ' (set) Token: 0x0600116B RID: 4459 RVA: 0x0029FB4C File Offset: 0x0029EB4C
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

        ' Token: 0x17000649 RID: 1609
        ' (get) Token: 0x0600116E RID: 4462 RVA: 0x0029FB68 File Offset: 0x0029EB68
        ' (set) Token: 0x0600116D RID: 4461 RVA: 0x0029FB7C File Offset: 0x0029EB7C
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

        ' Token: 0x1700064A RID: 1610
        ' (get) Token: 0x06001170 RID: 4464 RVA: 0x0029FB98 File Offset: 0x0029EB98
        ' (set) Token: 0x0600116F RID: 4463 RVA: 0x0029FBAC File Offset: 0x0029EBAC
        Friend Overridable Property nudBaseHP() As NumericUpDown
            Get
                Return Me._nudBaseHP
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudBaseHP IsNot Nothing Then
                End If
                Me._nudBaseHP = value
                If Me._nudBaseHP IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700064B RID: 1611
        ' (get) Token: 0x06001172 RID: 4466 RVA: 0x0029FBE4 File Offset: 0x0029EBE4
        ' (set) Token: 0x06001171 RID: 4465 RVA: 0x0029FBC8 File Offset: 0x0029EBC8
        Friend Overridable Property GroupBox7() As GroupBox
            Get
                Return Me._GroupBox7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox7 IsNot Nothing Then
                End If
                Me._GroupBox7 = value
                If Me._GroupBox7 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700064C RID: 1612
        ' (get) Token: 0x06001173 RID: 4467 RVA: 0x0029FBF8 File Offset: 0x0029EBF8
        ' (set) Token: 0x06001174 RID: 4468 RVA: 0x0029FC0C File Offset: 0x0029EC0C
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

        ' Token: 0x1700064D RID: 1613
        ' (get) Token: 0x06001175 RID: 4469 RVA: 0x0029FC28 File Offset: 0x0029EC28
        ' (set) Token: 0x06001176 RID: 4470 RVA: 0x0029FC3C File Offset: 0x0029EC3C
        Friend Overridable Property nudNaturalAC() As NumericUpDown
            Get
                Return Me._nudNaturalAC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudNaturalAC IsNot Nothing Then
                End If
                Me._nudNaturalAC = value
                If Me._nudNaturalAC IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700064E RID: 1614
        ' (get) Token: 0x06001177 RID: 4471 RVA: 0x0029FC74 File Offset: 0x0029EC74
        ' (set) Token: 0x06001178 RID: 4472 RVA: 0x0029FC58 File Offset: 0x0029EC58
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

        ' Token: 0x1700064F RID: 1615
        ' (get) Token: 0x06001179 RID: 4473 RVA: 0x0029FC88 File Offset: 0x0029EC88
        ' (set) Token: 0x0600117A RID: 4474 RVA: 0x0029FC9C File Offset: 0x0029EC9C
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

        ' Token: 0x17000650 RID: 1616
        ' (get) Token: 0x0600117C RID: 4476 RVA: 0x0029FCB8 File Offset: 0x0029ECB8
        ' (set) Token: 0x0600117B RID: 4475 RVA: 0x0029FCCC File Offset: 0x0029ECCC
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

        ' Token: 0x17000651 RID: 1617
        ' (get) Token: 0x0600117D RID: 4477 RVA: 0x0029FD04 File Offset: 0x0029ED04
        ' (set) Token: 0x0600117E RID: 4478 RVA: 0x0029FCE8 File Offset: 0x0029ECE8
        Friend Overridable Property nudWillBonus() As NumericUpDown
            Get
                Return Me._nudWillBonus
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudWillBonus IsNot Nothing Then
                End If
                Me._nudWillBonus = value
                If Me._nudWillBonus IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000652 RID: 1618
        ' (get) Token: 0x06001180 RID: 4480 RVA: 0x0029FD18 File Offset: 0x0029ED18
        ' (set) Token: 0x0600117F RID: 4479 RVA: 0x0029FD2C File Offset: 0x0029ED2C
        Friend Overridable Property nudFortBonus() As NumericUpDown
            Get
                Return Me._nudFortBonus
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudFortBonus IsNot Nothing Then
                End If
                Me._nudFortBonus = value
                If Me._nudFortBonus IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000653 RID: 1619
        ' (get) Token: 0x06001181 RID: 4481 RVA: 0x0029FD48 File Offset: 0x0029ED48
        ' (set) Token: 0x06001182 RID: 4482 RVA: 0x0029FD5C File Offset: 0x0029ED5C
        Friend Overridable Property nudRefBonus() As NumericUpDown
            Get
                Return Me._nudRefBonus
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudRefBonus IsNot Nothing Then
                End If
                Me._nudRefBonus = value
                If Me._nudRefBonus IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000654 RID: 1620
        ' (get) Token: 0x06001184 RID: 4484 RVA: 0x0029FD94 File Offset: 0x0029ED94
        ' (set) Token: 0x06001183 RID: 4483 RVA: 0x0029FD78 File Offset: 0x0029ED78
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

        ' Token: 0x17000655 RID: 1621
        ' (get) Token: 0x06001186 RID: 4486 RVA: 0x0029FDC4 File Offset: 0x0029EDC4
        ' (set) Token: 0x06001185 RID: 4485 RVA: 0x0029FDA8 File Offset: 0x0029EDA8
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

        ' Token: 0x17000656 RID: 1622
        ' (get) Token: 0x06001187 RID: 4487 RVA: 0x0029FDD8 File Offset: 0x0029EDD8
        ' (set) Token: 0x06001188 RID: 4488 RVA: 0x0029FDEC File Offset: 0x0029EDEC
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

        ' Token: 0x17000657 RID: 1623
        ' (get) Token: 0x0600118A RID: 4490 RVA: 0x0029FE24 File Offset: 0x0029EE24
        ' (set) Token: 0x06001189 RID: 4489 RVA: 0x0029FE08 File Offset: 0x0029EE08
        Friend Overridable Property cmbxClass() As ComboBox
            Get
                Return Me._cmbxClass
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxClass IsNot Nothing Then
                End If
                Me._cmbxClass = value
                If Me._cmbxClass IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000658 RID: 1624
        ' (get) Token: 0x0600118B RID: 4491 RVA: 0x0029FE54 File Offset: 0x0029EE54
        ' (set) Token: 0x0600118C RID: 4492 RVA: 0x0029FE38 File Offset: 0x0029EE38
        Friend Overridable Property nudComputerUse() As NumericUpDown
            Get
                Return Me._nudComputerUse
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudComputerUse IsNot Nothing Then
                End If
                Me._nudComputerUse = value
                If Me._nudComputerUse IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000659 RID: 1625
        ' (get) Token: 0x0600118E RID: 4494 RVA: 0x0029FE68 File Offset: 0x0029EE68
        ' (set) Token: 0x0600118D RID: 4493 RVA: 0x0029FE7C File Offset: 0x0029EE7C
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

        ' Token: 0x1700065A RID: 1626
        ' (get) Token: 0x0600118F RID: 4495 RVA: 0x0029FE98 File Offset: 0x0029EE98
        ' (set) Token: 0x06001190 RID: 4496 RVA: 0x0029FEAC File Offset: 0x0029EEAC
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

        ' Token: 0x1700065B RID: 1627
        ' (get) Token: 0x06001191 RID: 4497 RVA: 0x0029FEC8 File Offset: 0x0029EEC8
        ' (set) Token: 0x06001192 RID: 4498 RVA: 0x0029FEDC File Offset: 0x0029EEDC
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

        ' Token: 0x1700065C RID: 1628
        ' (get) Token: 0x06001193 RID: 4499 RVA: 0x0029FF14 File Offset: 0x0029EF14
        ' (set) Token: 0x06001194 RID: 4500 RVA: 0x0029FEF8 File Offset: 0x0029EEF8
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

        ' Token: 0x1700065D RID: 1629
        ' (get) Token: 0x06001195 RID: 4501 RVA: 0x0029FF28 File Offset: 0x0029EF28
        ' (set) Token: 0x06001196 RID: 4502 RVA: 0x0029FF3C File Offset: 0x0029EF3C
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

        ' Token: 0x1700065E RID: 1630
        ' (get) Token: 0x06001197 RID: 4503 RVA: 0x0029FF58 File Offset: 0x0029EF58
        ' (set) Token: 0x06001198 RID: 4504 RVA: 0x0029FF6C File Offset: 0x0029EF6C
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

        ' Token: 0x1700065F RID: 1631
        ' (get) Token: 0x06001199 RID: 4505 RVA: 0x0029FFA4 File Offset: 0x0029EFA4
        ' (set) Token: 0x0600119A RID: 4506 RVA: 0x0029FF88 File Offset: 0x0029EF88
        Friend Overridable Property nudDemolitions() As NumericUpDown
            Get
                Return Me._nudDemolitions
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudDemolitions IsNot Nothing Then
                End If
                Me._nudDemolitions = value
                If Me._nudDemolitions IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000660 RID: 1632
        ' (get) Token: 0x0600119C RID: 4508 RVA: 0x0029FFD4 File Offset: 0x0029EFD4
        ' (set) Token: 0x0600119B RID: 4507 RVA: 0x0029FFB8 File Offset: 0x0029EFB8
        Friend Overridable Property nudStealth() As NumericUpDown
            Get
                Return Me._nudStealth
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudStealth IsNot Nothing Then
                End If
                Me._nudStealth = value
                If Me._nudStealth IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000661 RID: 1633
        ' (get) Token: 0x0600119D RID: 4509 RVA: 0x0029FFE8 File Offset: 0x0029EFE8
        ' (set) Token: 0x0600119E RID: 4510 RVA: 0x0029FFFC File Offset: 0x0029EFFC
        Friend Overridable Property nudAwareness() As NumericUpDown
            Get
                Return Me._nudAwareness
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudAwareness IsNot Nothing Then
                End If
                Me._nudAwareness = value
                If Me._nudAwareness IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000662 RID: 1634
        ' (get) Token: 0x060011A0 RID: 4512 RVA: 0x002A0018 File Offset: 0x0029F018
        ' (set) Token: 0x0600119F RID: 4511 RVA: 0x002A002C File Offset: 0x0029F02C
        Friend Overridable Property nudPersuade() As NumericUpDown
            Get
                Return Me._nudPersuade
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudPersuade IsNot Nothing Then
                End If
                Me._nudPersuade = value
                If Me._nudPersuade IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000663 RID: 1635
        ' (get) Token: 0x060011A2 RID: 4514 RVA: 0x002A0048 File Offset: 0x0029F048
        ' (set) Token: 0x060011A1 RID: 4513 RVA: 0x002A005C File Offset: 0x0029F05C
        Friend Overridable Property nudRepair() As NumericUpDown
            Get
                Return Me._nudRepair
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudRepair IsNot Nothing Then
                End If
                Me._nudRepair = value
                If Me._nudRepair IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000664 RID: 1636
        ' (get) Token: 0x060011A4 RID: 4516 RVA: 0x002A0078 File Offset: 0x0029F078
        ' (set) Token: 0x060011A3 RID: 4515 RVA: 0x002A008C File Offset: 0x0029F08C
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

        ' Token: 0x17000665 RID: 1637
        ' (get) Token: 0x060011A5 RID: 4517 RVA: 0x002A00A8 File Offset: 0x0029F0A8
        ' (set) Token: 0x060011A6 RID: 4518 RVA: 0x002A00BC File Offset: 0x0029F0BC
        Friend Overridable Property nudSecurity() As NumericUpDown
            Get
                Return Me._nudSecurity
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudSecurity IsNot Nothing Then
                End If
                Me._nudSecurity = value
                If Me._nudSecurity IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000666 RID: 1638
        ' (get) Token: 0x060011A7 RID: 4519 RVA: 0x002A00D8 File Offset: 0x0029F0D8
        ' (set) Token: 0x060011A8 RID: 4520 RVA: 0x002A00EC File Offset: 0x0029F0EC
        Friend Overridable Property nudTreatInjury() As NumericUpDown
            Get
                Return Me._nudTreatInjury
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudTreatInjury IsNot Nothing Then
                End If
                Me._nudTreatInjury = value
                If Me._nudTreatInjury IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000667 RID: 1639
        ' (get) Token: 0x060011A9 RID: 4521 RVA: 0x002A0108 File Offset: 0x0029F108
        ' (set) Token: 0x060011AA RID: 4522 RVA: 0x002A011C File Offset: 0x0029F11C
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

        ' Token: 0x17000668 RID: 1640
        ' (get) Token: 0x060011AB RID: 4523 RVA: 0x002A0138 File Offset: 0x0029F138
        ' (set) Token: 0x060011AC RID: 4524 RVA: 0x002A014C File Offset: 0x0029F14C
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

        ' Token: 0x17000669 RID: 1641
        ' (get) Token: 0x060011AD RID: 4525 RVA: 0x002A0184 File Offset: 0x0029F184
        ' (set) Token: 0x060011AE RID: 4526 RVA: 0x002A0168 File Offset: 0x0029F168
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

        ' Token: 0x1700066A RID: 1642
        ' (get) Token: 0x060011B0 RID: 4528 RVA: 0x002A0198 File Offset: 0x0029F198
        ' (set) Token: 0x060011AF RID: 4527 RVA: 0x002A01AC File Offset: 0x0029F1AC
        Friend Overridable Property Label34() As Label
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

        ' Token: 0x1700066B RID: 1643
        ' (get) Token: 0x060011B1 RID: 4529 RVA: 0x002A01C8 File Offset: 0x0029F1C8
        ' (set) Token: 0x060011B2 RID: 4530 RVA: 0x002A01DC File Offset: 0x0029F1DC
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

        ' Token: 0x1700066C RID: 1644
        ' (get) Token: 0x060011B3 RID: 4531 RVA: 0x002A0214 File Offset: 0x0029F214
        ' (set) Token: 0x060011B4 RID: 4532 RVA: 0x002A01F8 File Offset: 0x0029F1F8
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

        ' Token: 0x1700066D RID: 1645
        ' (get) Token: 0x060011B6 RID: 4534 RVA: 0x002A0228 File Offset: 0x0029F228
        ' (set) Token: 0x060011B5 RID: 4533 RVA: 0x002A023C File Offset: 0x0029F23C
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

        ' Token: 0x1700066E RID: 1646
        ' (get) Token: 0x060011B7 RID: 4535 RVA: 0x002A0258 File Offset: 0x0029F258
        ' (set) Token: 0x060011B8 RID: 4536 RVA: 0x002A026C File Offset: 0x0029F26C
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

        ' Token: 0x1700066F RID: 1647
        ' (get) Token: 0x060011BA RID: 4538 RVA: 0x002A02A4 File Offset: 0x0029F2A4
        ' (set) Token: 0x060011B9 RID: 4537 RVA: 0x002A0288 File Offset: 0x0029F288
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

        ' Token: 0x17000670 RID: 1648
        ' (get) Token: 0x060011BC RID: 4540 RVA: 0x002A02D4 File Offset: 0x0029F2D4
        ' (set) Token: 0x060011BB RID: 4539 RVA: 0x002A02B8 File Offset: 0x0029F2B8
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

        ' Token: 0x17000671 RID: 1649
        ' (get) Token: 0x060011BE RID: 4542 RVA: 0x002A02E8 File Offset: 0x0029F2E8
        ' (set) Token: 0x060011BD RID: 4541 RVA: 0x002A02FC File Offset: 0x0029F2FC
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

        ' Token: 0x17000672 RID: 1650
        ' (get) Token: 0x060011C0 RID: 4544 RVA: 0x002A0334 File Offset: 0x0029F334
        ' (set) Token: 0x060011BF RID: 4543 RVA: 0x002A0318 File Offset: 0x0029F318
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

        ' Token: 0x17000673 RID: 1651
        ' (get) Token: 0x060011C2 RID: 4546 RVA: 0x002A0348 File Offset: 0x0029F348
        ' (set) Token: 0x060011C1 RID: 4545 RVA: 0x002A035C File Offset: 0x0029F35C
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

        ' Token: 0x17000674 RID: 1652
        ' (get) Token: 0x060011C4 RID: 4548 RVA: 0x002A0394 File Offset: 0x0029F394
        ' (set) Token: 0x060011C3 RID: 4547 RVA: 0x002A0378 File Offset: 0x0029F378
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

        ' Token: 0x17000675 RID: 1653
        ' (get) Token: 0x060011C5 RID: 4549 RVA: 0x002A03C4 File Offset: 0x0029F3C4
        ' (set) Token: 0x060011C6 RID: 4550 RVA: 0x002A03A8 File Offset: 0x0029F3A8
        Friend Overridable Property tbOnHeartbeat() As TextBox
            Get
                Return Me._tbOnHeartbeat
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnHeartbeat IsNot Nothing Then
                End If
                Me._tbOnHeartbeat = value
                If Me._tbOnHeartbeat IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000676 RID: 1654
        ' (get) Token: 0x060011C7 RID: 4551 RVA: 0x002A03F4 File Offset: 0x0029F3F4
        ' (set) Token: 0x060011C8 RID: 4552 RVA: 0x002A03D8 File Offset: 0x0029F3D8
        Friend Overridable Property tbOnNotice() As TextBox
            Get
                Return Me._tbOnNotice
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnNotice IsNot Nothing Then
                End If
                Me._tbOnNotice = value
                If Me._tbOnNotice IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000677 RID: 1655
        ' (get) Token: 0x060011C9 RID: 4553 RVA: 0x002A0424 File Offset: 0x0029F424
        ' (set) Token: 0x060011CA RID: 4554 RVA: 0x002A0408 File Offset: 0x0029F408
        Friend Overridable Property tbOnSpellAt() As TextBox
            Get
                Return Me._tbOnSpellAt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnSpellAt IsNot Nothing Then
                End If
                Me._tbOnSpellAt = value
                If Me._tbOnSpellAt IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000678 RID: 1656
        ' (get) Token: 0x060011CB RID: 4555 RVA: 0x002A0438 File Offset: 0x0029F438
        ' (set) Token: 0x060011CC RID: 4556 RVA: 0x002A044C File Offset: 0x0029F44C
        Friend Overridable Property tbOnAttacked() As TextBox
            Get
                Return Me._tbOnAttacked
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnAttacked IsNot Nothing Then
                End If
                Me._tbOnAttacked = value
                If Me._tbOnAttacked IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000679 RID: 1657
        ' (get) Token: 0x060011CE RID: 4558 RVA: 0x002A0484 File Offset: 0x0029F484
        ' (set) Token: 0x060011CD RID: 4557 RVA: 0x002A0468 File Offset: 0x0029F468
        Friend Overridable Property tbOnDamaged() As TextBox
            Get
                Return Me._tbOnDamaged
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnDamaged IsNot Nothing Then
                End If
                Me._tbOnDamaged = value
                If Me._tbOnDamaged IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700067A RID: 1658
        ' (get) Token: 0x060011CF RID: 4559 RVA: 0x002A0498 File Offset: 0x0029F498
        ' (set) Token: 0x060011D0 RID: 4560 RVA: 0x002A04AC File Offset: 0x0029F4AC
        Friend Overridable Property tbOnDisturbed() As TextBox
            Get
                Return Me._tbOnDisturbed
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnDisturbed IsNot Nothing Then
                End If
                Me._tbOnDisturbed = value
                If Me._tbOnDisturbed IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700067B RID: 1659
        ' (get) Token: 0x060011D1 RID: 4561 RVA: 0x002A04C8 File Offset: 0x0029F4C8
        ' (set) Token: 0x060011D2 RID: 4562 RVA: 0x002A04DC File Offset: 0x0029F4DC
        Friend Overridable Property tbOnEndRound() As TextBox
            Get
                Return Me._tbOnEndRound
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnEndRound IsNot Nothing Then
                End If
                Me._tbOnEndRound = value
                If Me._tbOnEndRound IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700067C RID: 1660
        ' (get) Token: 0x060011D4 RID: 4564 RVA: 0x002A0514 File Offset: 0x0029F514
        ' (set) Token: 0x060011D3 RID: 4563 RVA: 0x002A04F8 File Offset: 0x0029F4F8
        Friend Overridable Property tbOnEndDialogu() As TextBox
            Get
                Return Me._tbOnEndDialogu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnEndDialogu IsNot Nothing Then
                End If
                Me._tbOnEndDialogu = value
                If Me._tbOnEndDialogu IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700067D RID: 1661
        ' (get) Token: 0x060011D6 RID: 4566 RVA: 0x002A0528 File Offset: 0x0029F528
        ' (set) Token: 0x060011D5 RID: 4565 RVA: 0x002A053C File Offset: 0x0029F53C
        Friend Overridable Property tbOnDialogue() As TextBox
            Get
                Return Me._tbOnDialogue
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnDialogue IsNot Nothing Then
                End If
                Me._tbOnDialogue = value
                If Me._tbOnDialogue IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700067E RID: 1662
        ' (get) Token: 0x060011D7 RID: 4567 RVA: 0x002A0574 File Offset: 0x0029F574
        ' (set) Token: 0x060011D8 RID: 4568 RVA: 0x002A0558 File Offset: 0x0029F558
        Friend Overridable Property tbOnSpawn() As TextBox
            Get
                Return Me._tbOnSpawn
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnSpawn IsNot Nothing Then
                End If
                Me._tbOnSpawn = value
                If Me._tbOnSpawn IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700067F RID: 1663
        ' (get) Token: 0x060011D9 RID: 4569 RVA: 0x002A0588 File Offset: 0x0029F588
        ' (set) Token: 0x060011DA RID: 4570 RVA: 0x002A059C File Offset: 0x0029F59C
        Friend Overridable Property tbOnRested() As TextBox
            Get
                Return Me._tbOnRested
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnRested IsNot Nothing Then
                End If
                Me._tbOnRested = value
                If Me._tbOnRested IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000680 RID: 1664
        ' (get) Token: 0x060011DC RID: 4572 RVA: 0x002A05B8 File Offset: 0x0029F5B8
        ' (set) Token: 0x060011DB RID: 4571 RVA: 0x002A05CC File Offset: 0x0029F5CC
        Friend Overridable Property tbOnDeath() As TextBox
            Get
                Return Me._tbOnDeath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnDeath IsNot Nothing Then
                End If
                Me._tbOnDeath = value
                If Me._tbOnDeath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000681 RID: 1665
        ' (get) Token: 0x060011DD RID: 4573 RVA: 0x002A05E8 File Offset: 0x0029F5E8
        ' (set) Token: 0x060011DE RID: 4574 RVA: 0x002A05FC File Offset: 0x0029F5FC
        Friend Overridable Property tbOnBlocked() As TextBox
            Get
                Return Me._tbOnBlocked
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnBlocked IsNot Nothing Then
                End If
                Me._tbOnBlocked = value
                If Me._tbOnBlocked IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000682 RID: 1666
        ' (get) Token: 0x060011DF RID: 4575 RVA: 0x002A0634 File Offset: 0x0029F634
        ' (set) Token: 0x060011E0 RID: 4576 RVA: 0x002A0618 File Offset: 0x0029F618
        Friend Overridable Property tbOnUserDefine() As TextBox
            Get
                Return Me._tbOnUserDefine
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnUserDefine IsNot Nothing Then
                End If
                Me._tbOnUserDefine = value
                If Me._tbOnUserDefine IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000683 RID: 1667
        ' (get) Token: 0x060011E2 RID: 4578 RVA: 0x002A0648 File Offset: 0x0029F648
        ' (set) Token: 0x060011E1 RID: 4577 RVA: 0x002A065C File Offset: 0x0029F65C
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

        ' Token: 0x17000684 RID: 1668
        ' (get) Token: 0x060011E4 RID: 4580 RVA: 0x002A0678 File Offset: 0x0029F678
        ' (set) Token: 0x060011E3 RID: 4579 RVA: 0x002A068C File Offset: 0x0029F68C
        Friend Overridable Property chkbNotInterruptable() As CheckBox
            Get
                Return Me._chkbNotInterruptable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbNotInterruptable IsNot Nothing Then
                End If
                Me._chkbNotInterruptable = value
                If Me._chkbNotInterruptable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000685 RID: 1669
        ' (get) Token: 0x060011E5 RID: 4581 RVA: 0x002A06C4 File Offset: 0x0029F6C4
        ' (set) Token: 0x060011E6 RID: 4582 RVA: 0x002A06A8 File Offset: 0x0029F6A8
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

        ' Token: 0x17000686 RID: 1670
        ' (get) Token: 0x060011E7 RID: 4583 RVA: 0x002A06F4 File Offset: 0x0029F6F4
        ' (set) Token: 0x060011E8 RID: 4584 RVA: 0x002A06D8 File Offset: 0x0029F6D8
        Friend Overridable Property nudClassLevel() As NumericUpDown
            Get
                Return Me._nudClassLevel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudClassLevel IsNot Nothing Then
                End If
                Me._nudClassLevel = value
                If Me._nudClassLevel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000687 RID: 1671
        ' (get) Token: 0x060011EA RID: 4586 RVA: 0x002A0724 File Offset: 0x0029F724
        ' (set) Token: 0x060011E9 RID: 4585 RVA: 0x002A0708 File Offset: 0x0029F708
        Friend Overridable Property GroupBox8() As GroupBox
            Get
                Return Me._GroupBox8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox8 IsNot Nothing Then
                End If
                Me._GroupBox8 = value
                If Me._GroupBox8 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000688 RID: 1672
        ' (get) Token: 0x060011EC RID: 4588 RVA: 0x002A0738 File Offset: 0x0029F738
        ' (set) Token: 0x060011EB RID: 4587 RVA: 0x002A074C File Offset: 0x0029F74C
        Friend Overridable Property GroupBox9() As GroupBox
            Get
                Return Me._GroupBox9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox9 IsNot Nothing Then
                End If
                Me._GroupBox9 = value
                If Me._GroupBox9 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000689 RID: 1673
        ' (get) Token: 0x060011EE RID: 4590 RVA: 0x002A0768 File Offset: 0x0029F768
        ' (set) Token: 0x060011ED RID: 4589 RVA: 0x002A077C File Offset: 0x0029F77C
        Friend Overridable Property trkbarAlignment() As TrackBar
            Get
                Return Me._trkbarAlignment
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbarAlignment IsNot Nothing Then
                    RemoveHandler Me._trkbarAlignment.Scroll, AddressOf Me.trkbarAlignment_Scroll
                End If
                Me._trkbarAlignment = value
                If Me._trkbarAlignment IsNot Nothing Then
                    AddHandler Me._trkbarAlignment.Scroll, AddressOf Me.trkbarAlignment_Scroll
                End If
            End Set
        End Property

        ' Token: 0x1700068A RID: 1674
        ' (get) Token: 0x060011F0 RID: 4592 RVA: 0x002A07D0 File Offset: 0x0029F7D0
        ' (set) Token: 0x060011EF RID: 4591 RVA: 0x002A07E4 File Offset: 0x0029F7E4
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

        ' Token: 0x1700068B RID: 1675
        ' (get) Token: 0x060011F1 RID: 4593 RVA: 0x002A0800 File Offset: 0x0029F800
        ' (set) Token: 0x060011F2 RID: 4594 RVA: 0x002A0814 File Offset: 0x0029F814
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

        ' Token: 0x1700068C RID: 1676
        ' (get) Token: 0x060011F3 RID: 4595 RVA: 0x002A0830 File Offset: 0x0029F830
        ' (set) Token: 0x060011F4 RID: 4596 RVA: 0x002A0844 File Offset: 0x0029F844
        Friend Overridable Property nudAlignment() As NumericUpDown
            Get
                Return Me._nudAlignment
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudAlignment IsNot Nothing Then
                    RemoveHandler Me._nudAlignment.ValueChanged, AddressOf Me.nudAlignment_ValueChanged
                End If
                Me._nudAlignment = value
                If Me._nudAlignment IsNot Nothing Then
                    AddHandler Me._nudAlignment.ValueChanged, AddressOf Me.nudAlignment_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x1700068D RID: 1677
        ' (get) Token: 0x060011F6 RID: 4598 RVA: 0x002A0898 File Offset: 0x0029F898
        ' (set) Token: 0x060011F5 RID: 4597 RVA: 0x002A08AC File Offset: 0x0029F8AC
        Friend Overridable Property chklbFeats() As CheckedListBox
            Get
                Return Me._chklbFeats
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckedListBox)
                If Me._chklbFeats IsNot Nothing Then
                    RemoveHandler Me._chklbFeats.MouseMove, AddressOf Me.chklbFeats_MouseMove
                End If
                Me._chklbFeats = value
                If Me._chklbFeats IsNot Nothing Then
                    AddHandler Me._chklbFeats.MouseMove, AddressOf Me.chklbFeats_MouseMove
                End If
            End Set
        End Property

        ' Token: 0x1700068E RID: 1678
        ' (get) Token: 0x060011F8 RID: 4600 RVA: 0x002A091C File Offset: 0x0029F91C
        ' (set) Token: 0x060011F7 RID: 4599 RVA: 0x002A0900 File Offset: 0x0029F900
        Friend Overridable Property tbFeatSummary() As TextBox
            Get
                Return Me._tbFeatSummary
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbFeatSummary IsNot Nothing Then
                End If
                Me._tbFeatSummary = value
                If Me._tbFeatSummary IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700068F RID: 1679
        ' (get) Token: 0x060011F9 RID: 4601 RVA: 0x002A0930 File Offset: 0x0029F930
        ' (set) Token: 0x060011FA RID: 4602 RVA: 0x002A0944 File Offset: 0x0029F944
        Friend Overridable Property GroupBox10() As GroupBox
            Get
                Return Me._GroupBox10
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox10 IsNot Nothing Then
                End If
                Me._GroupBox10 = value
                If Me._GroupBox10 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000690 RID: 1680
        ' (get) Token: 0x060011FC RID: 4604 RVA: 0x002A097C File Offset: 0x0029F97C
        ' (set) Token: 0x060011FB RID: 4603 RVA: 0x002A0960 File Offset: 0x0029F960
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

        ' Token: 0x17000691 RID: 1681
        ' (get) Token: 0x060011FE RID: 4606 RVA: 0x002A0990 File Offset: 0x0029F990
        ' (set) Token: 0x060011FD RID: 4605 RVA: 0x002A09A4 File Offset: 0x0029F9A4
        Friend Overridable Property nudCurrentHP() As NumericUpDown
            Get
                Return Me._nudCurrentHP
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCurrentHP IsNot Nothing Then
                End If
                Me._nudCurrentHP = value
                If Me._nudCurrentHP IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000692 RID: 1682
        ' (get) Token: 0x06001200 RID: 4608 RVA: 0x002A09DC File Offset: 0x0029F9DC
        ' (set) Token: 0x060011FF RID: 4607 RVA: 0x002A09C0 File Offset: 0x0029F9C0
        Friend Overridable Property nudMaxHP() As NumericUpDown
            Get
                Return Me._nudMaxHP
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudMaxHP IsNot Nothing Then
                End If
                Me._nudMaxHP = value
                If Me._nudMaxHP IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000693 RID: 1683
        ' (get) Token: 0x06001202 RID: 4610 RVA: 0x002A09F0 File Offset: 0x0029F9F0
        ' (set) Token: 0x06001201 RID: 4609 RVA: 0x002A0A04 File Offset: 0x0029FA04
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

        ' Token: 0x17000694 RID: 1684
        ' (get) Token: 0x06001204 RID: 4612 RVA: 0x002A0A20 File Offset: 0x0029FA20
        ' (set) Token: 0x06001203 RID: 4611 RVA: 0x002A0A34 File Offset: 0x0029FA34
        Friend Overridable Property tbComments() As TextBox
            Get
                Return Me._tbComments
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbComments IsNot Nothing Then
                End If
                Me._tbComments = value
                If Me._tbComments IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000695 RID: 1685
        ' (get) Token: 0x06001205 RID: 4613 RVA: 0x002A0A50 File Offset: 0x0029FA50
        ' (set) Token: 0x06001206 RID: 4614 RVA: 0x002A0A64 File Offset: 0x0029FA64
        Friend Overridable Property GroupBox11() As GroupBox
            Get
                Return Me._GroupBox11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox11 IsNot Nothing Then
                End If
                Me._GroupBox11 = value
                If Me._GroupBox11 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000696 RID: 1686
        ' (get) Token: 0x06001208 RID: 4616 RVA: 0x002A0A80 File Offset: 0x0029FA80
        ' (set) Token: 0x06001207 RID: 4615 RVA: 0x002A0A94 File Offset: 0x0029FA94
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

        ' Token: 0x17000697 RID: 1687
        ' (get) Token: 0x06001209 RID: 4617 RVA: 0x002A0ACC File Offset: 0x0029FACC
        ' (set) Token: 0x0600120A RID: 4618 RVA: 0x002A0AB0 File Offset: 0x0029FAB0
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

        ' Token: 0x17000698 RID: 1688
        ' (get) Token: 0x0600120B RID: 4619 RVA: 0x002A0AE0 File Offset: 0x0029FAE0
        ' (set) Token: 0x0600120C RID: 4620 RVA: 0x002A0AF4 File Offset: 0x0029FAF4
        Friend Overridable Property chkbDisarmable() As CheckBox
            Get
                Return Me._chkbDisarmable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbDisarmable IsNot Nothing Then
                End If
                Me._chkbDisarmable = value
                If Me._chkbDisarmable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000699 RID: 1689
        ' (get) Token: 0x0600120D RID: 4621 RVA: 0x002A0B2C File Offset: 0x0029FB2C
        ' (set) Token: 0x0600120E RID: 4622 RVA: 0x002A0B10 File Offset: 0x0029FB10
        Friend Overridable Property chkbPlot() As CheckBox
            Get
                Return Me._chkbPlot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbPlot IsNot Nothing Then
                End If
                Me._chkbPlot = value
                If Me._chkbPlot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700069A RID: 1690
        ' (get) Token: 0x0600120F RID: 4623 RVA: 0x002A0B5C File Offset: 0x0029FB5C
        ' (set) Token: 0x06001210 RID: 4624 RVA: 0x002A0B40 File Offset: 0x0029FB40
        Friend Overridable Property chkbNoPermDeath() As CheckBox
            Get
                Return Me._chkbNoPermDeath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbNoPermDeath IsNot Nothing Then
                End If
                Me._chkbNoPermDeath = value
                If Me._chkbNoPermDeath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700069B RID: 1691
        ' (get) Token: 0x06001211 RID: 4625 RVA: 0x002A0B8C File Offset: 0x0029FB8C
        ' (set) Token: 0x06001212 RID: 4626 RVA: 0x002A0B70 File Offset: 0x0029FB70
        Friend Overridable Property GroupBox12() As GroupBox
            Get
                Return Me._GroupBox12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox12 IsNot Nothing Then
                End If
                Me._GroupBox12 = value
                If Me._GroupBox12 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700069C RID: 1692
        ' (get) Token: 0x06001214 RID: 4628 RVA: 0x002A0BA0 File Offset: 0x0029FBA0
        ' (set) Token: 0x06001213 RID: 4627 RVA: 0x002A0BB4 File Offset: 0x0029FBB4
        Friend Overridable Property GroupBox13() As GroupBox
            Get
                Return Me._GroupBox13
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox13 IsNot Nothing Then
                End If
                Me._GroupBox13 = value
                If Me._GroupBox13 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700069D RID: 1693
        ' (get) Token: 0x06001216 RID: 4630 RVA: 0x002A0BD0 File Offset: 0x0029FBD0
        ' (set) Token: 0x06001215 RID: 4629 RVA: 0x002A0BE4 File Offset: 0x0029FBE4
        Friend Overridable Property GroupBox14() As GroupBox
            Get
                Return Me._GroupBox14
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox14 IsNot Nothing Then
                End If
                Me._GroupBox14 = value
                If Me._GroupBox14 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700069E RID: 1694
        ' (get) Token: 0x06001218 RID: 4632 RVA: 0x002A0C00 File Offset: 0x0029FC00
        ' (set) Token: 0x06001217 RID: 4631 RVA: 0x002A0C14 File Offset: 0x0029FC14
        Friend Overridable Property tbChallengeRating() As TextBox
            Get
                Return Me._tbChallengeRating
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbChallengeRating IsNot Nothing Then
                End If
                Me._tbChallengeRating = value
                If Me._tbChallengeRating IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700069F RID: 1695
        ' (get) Token: 0x06001219 RID: 4633 RVA: 0x002A0C30 File Offset: 0x0029FC30
        ' (set) Token: 0x0600121A RID: 4634 RVA: 0x002A0C44 File Offset: 0x0029FC44
        Friend Overridable Property GroupBox15() As GroupBox
            Get
                Return Me._GroupBox15
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox15 IsNot Nothing Then
                End If
                Me._GroupBox15 = value
                If Me._GroupBox15 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006A0 RID: 1696
        ' (get) Token: 0x0600121C RID: 4636 RVA: 0x002A0C60 File Offset: 0x0029FC60
        ' (set) Token: 0x0600121B RID: 4635 RVA: 0x002A0C74 File Offset: 0x0029FC74
        Friend Overridable Property cmbxPerceptionRange() As ComboBox
            Get
                Return Me._cmbxPerceptionRange
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxPerceptionRange IsNot Nothing Then
                End If
                Me._cmbxPerceptionRange = value
                If Me._cmbxPerceptionRange IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006A1 RID: 1697
        ' (get) Token: 0x0600121D RID: 4637 RVA: 0x002A0C90 File Offset: 0x0029FC90
        ' (set) Token: 0x0600121E RID: 4638 RVA: 0x002A0CA4 File Offset: 0x0029FCA4
        Friend Overridable Property tbDeity() As TextBox
            Get
                Return Me._tbDeity
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbDeity IsNot Nothing Then
                End If
                Me._tbDeity = value
                If Me._tbDeity IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006A2 RID: 1698
        ' (get) Token: 0x06001220 RID: 4640 RVA: 0x002A0CC0 File Offset: 0x0029FCC0
        ' (set) Token: 0x0600121F RID: 4639 RVA: 0x002A0CD4 File Offset: 0x0029FCD4
        Friend Overridable Property GroupBox16() As GroupBox
            Get
                Return Me._GroupBox16
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox16 IsNot Nothing Then
                End If
                Me._GroupBox16 = value
                If Me._GroupBox16 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006A3 RID: 1699
        ' (get) Token: 0x06001221 RID: 4641 RVA: 0x002A0D0C File Offset: 0x0029FD0C
        ' (set) Token: 0x06001222 RID: 4642 RVA: 0x002A0CF0 File Offset: 0x0029FCF0
        Friend Overridable Property GroupBox17() As GroupBox
            Get
                Return Me._GroupBox17
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox17 IsNot Nothing Then
                End If
                Me._GroupBox17 = value
                If Me._GroupBox17 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006A4 RID: 1700
        ' (get) Token: 0x06001223 RID: 4643 RVA: 0x002A0D74 File Offset: 0x0029FD74
        ' (set) Token: 0x06001224 RID: 4644 RVA: 0x002A0D20 File Offset: 0x0029FD20
        Friend Overridable Property chklbForcePowers() As CheckedListBox
            Get
                Return Me._chklbForcePowers
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckedListBox)
                If Me._chklbForcePowers IsNot Nothing Then
                    RemoveHandler Me._chklbForcePowers.MouseMove, AddressOf Me.chklbForcePowers_MouseMove
                End If
                Me._chklbForcePowers = value
                If Me._chklbForcePowers IsNot Nothing Then
                    AddHandler Me._chklbForcePowers.MouseMove, AddressOf Me.chklbForcePowers_MouseMove
                End If
            End Set
        End Property

        ' Token: 0x170006A5 RID: 1701
        ' (get) Token: 0x06001226 RID: 4646 RVA: 0x002A0DA4 File Offset: 0x0029FDA4
        ' (set) Token: 0x06001225 RID: 4645 RVA: 0x002A0D88 File Offset: 0x0029FD88
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

        ' Token: 0x170006A6 RID: 1702
        ' (get) Token: 0x06001227 RID: 4647 RVA: 0x002A0DB8 File Offset: 0x0029FDB8
        ' (set) Token: 0x06001228 RID: 4648 RVA: 0x002A0DCC File Offset: 0x0029FDCC
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

        ' Token: 0x170006A7 RID: 1703
        ' (get) Token: 0x06001229 RID: 4649 RVA: 0x002A0E04 File Offset: 0x0029FE04
        ' (set) Token: 0x0600122A RID: 4650 RVA: 0x002A0DE8 File Offset: 0x0029FDE8
        Friend Overridable Property nudForcePoints() As NumericUpDown
            Get
                Return Me._nudForcePoints
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudForcePoints IsNot Nothing Then
                End If
                Me._nudForcePoints = value
                If Me._nudForcePoints IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006A8 RID: 1704
        ' (get) Token: 0x0600122C RID: 4652 RVA: 0x002A0E18 File Offset: 0x0029FE18
        ' (set) Token: 0x0600122B RID: 4651 RVA: 0x002A0E2C File Offset: 0x0029FE2C
        Friend Overridable Property nudCurrentForce() As NumericUpDown
            Get
                Return Me._nudCurrentForce
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCurrentForce IsNot Nothing Then
                End If
                Me._nudCurrentForce = value
                If Me._nudCurrentForce IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006A9 RID: 1705
        ' (get) Token: 0x0600122D RID: 4653 RVA: 0x002A0E48 File Offset: 0x0029FE48
        ' (set) Token: 0x0600122E RID: 4654 RVA: 0x002A0E5C File Offset: 0x0029FE5C
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

        ' Token: 0x170006AA RID: 1706
        ' (get) Token: 0x0600122F RID: 4655 RVA: 0x002A0EB0 File Offset: 0x0029FEB0
        ' (set) Token: 0x06001230 RID: 4656 RVA: 0x002A0EC4 File Offset: 0x0029FEC4
        Friend Overridable Property chklbSpecialAbilities() As CheckedListBox
            Get
                Return Me._chklbSpecialAbilities
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckedListBox)
                If Me._chklbSpecialAbilities IsNot Nothing Then
                End If
                Me._chklbSpecialAbilities = value
                If Me._chklbSpecialAbilities IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006AB RID: 1707
        ' (get) Token: 0x06001231 RID: 4657 RVA: 0x002A0EFC File Offset: 0x0029FEFC
        ' (set) Token: 0x06001232 RID: 4658 RVA: 0x002A0EE0 File Offset: 0x0029FEE0
        Friend Overridable Property GroupBox18() As GroupBox
            Get
                Return Me._GroupBox18
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox18 IsNot Nothing Then
                End If
                Me._GroupBox18 = value
                If Me._GroupBox18 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006AC RID: 1708
        ' (get) Token: 0x06001233 RID: 4659 RVA: 0x002A0F10 File Offset: 0x0029FF10
        ' (set) Token: 0x06001234 RID: 4660 RVA: 0x002A0F24 File Offset: 0x0029FF24
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

        ' Token: 0x170006AD RID: 1709
        ' (get) Token: 0x06001235 RID: 4661 RVA: 0x002A0F5C File Offset: 0x0029FF5C
        ' (set) Token: 0x06001236 RID: 4662 RVA: 0x002A0F40 File Offset: 0x0029FF40
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

        ' Token: 0x170006AE RID: 1710
        ' (get) Token: 0x06001237 RID: 4663 RVA: 0x002A0F70 File Offset: 0x0029FF70
        ' (set) Token: 0x06001238 RID: 4664 RVA: 0x002A0F84 File Offset: 0x0029FF84
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

        ' Token: 0x170006AF RID: 1711
        ' (get) Token: 0x0600123A RID: 4666 RVA: 0x002A0FA0 File Offset: 0x0029FFA0
        ' (set) Token: 0x06001239 RID: 4665 RVA: 0x002A0FB4 File Offset: 0x0029FFB4
        Friend Overridable Property cmbxTreasureModel() As ComboBox
            Get
                Return Me._cmbxTreasureModel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxTreasureModel IsNot Nothing Then
                End If
                Me._cmbxTreasureModel = value
                If Me._cmbxTreasureModel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006B0 RID: 1712
        ' (get) Token: 0x0600123C RID: 4668 RVA: 0x002A0FD0 File Offset: 0x0029FFD0
        ' (set) Token: 0x0600123B RID: 4667 RVA: 0x002A0FE4 File Offset: 0x0029FFE4
        Friend Overridable Property btnWriteFile() As Button
            Get
                Return Me._btnWriteFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnWriteFile IsNot Nothing Then
                    RemoveHandler Me._btnWriteFile.Click, AddressOf Me.btnWriteFile_Click
                End If
                Me._btnWriteFile = value
                If Me._btnWriteFile IsNot Nothing Then
                    AddHandler Me._btnWriteFile.Click, AddressOf Me.btnWriteFile_Click
                End If
            End Set
        End Property

        ' Token: 0x170006B1 RID: 1713
        ' (get) Token: 0x0600123E RID: 4670 RVA: 0x002A1038 File Offset: 0x002A0038
        ' (set) Token: 0x0600123D RID: 4669 RVA: 0x002A104C File Offset: 0x002A004C
        Friend Overridable Property cmbxSoundSet() As ComboBox
            Get
                Return Me._cmbxSoundSet
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxSoundSet IsNot Nothing Then
                End If
                Me._cmbxSoundSet = value
                If Me._cmbxSoundSet IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006B2 RID: 1714
        ' (get) Token: 0x0600123F RID: 4671 RVA: 0x002A1084 File Offset: 0x002A0084
        ' (set) Token: 0x06001240 RID: 4672 RVA: 0x002A1068 File Offset: 0x002A0068
        Friend Overridable Property cmbxPortrait() As ComboBox
            Get
                Return Me._cmbxPortrait
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxPortrait IsNot Nothing Then
                End If
                Me._cmbxPortrait = value
                If Me._cmbxPortrait IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006B3 RID: 1715
        ' (get) Token: 0x06001241 RID: 4673 RVA: 0x002A10B4 File Offset: 0x002A00B4
        ' (set) Token: 0x06001242 RID: 4674 RVA: 0x002A1098 File Offset: 0x002A0098
        Friend Overridable Property cmbxSubrace() As ComboBox
            Get
                Return Me._cmbxSubrace
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxSubrace IsNot Nothing Then
                End If
                Me._cmbxSubrace = value
                If Me._cmbxSubrace IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006B4 RID: 1716
        ' (get) Token: 0x06001244 RID: 4676 RVA: 0x002A10C8 File Offset: 0x002A00C8
        ' (set) Token: 0x06001243 RID: 4675 RVA: 0x002A10DC File Offset: 0x002A00DC
        Friend Overridable Property btnClearAllPowers() As Button
            Get
                Return Me._btnClearAllPowers
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnClearAllPowers IsNot Nothing Then
                    RemoveHandler Me._btnClearAllPowers.Click, AddressOf Me.btnClearAllPowers_Click
                End If
                Me._btnClearAllPowers = value
                If Me._btnClearAllPowers IsNot Nothing Then
                    AddHandler Me._btnClearAllPowers.Click, AddressOf Me.btnClearAllPowers_Click
                End If
            End Set
        End Property

        ' Token: 0x170006B5 RID: 1717
        ' (get) Token: 0x06001245 RID: 4677 RVA: 0x002A1130 File Offset: 0x002A0130
        ' (set) Token: 0x06001246 RID: 4678 RVA: 0x002A1144 File Offset: 0x002A0144
        Friend Overridable Property btnSelectAllPowers() As Button
            Get
                Return Me._btnSelectAllPowers
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSelectAllPowers IsNot Nothing Then
                    RemoveHandler Me._btnSelectAllPowers.Click, AddressOf Me.btnSelectAllPowers_Click
                End If
                Me._btnSelectAllPowers = value
                If Me._btnSelectAllPowers IsNot Nothing Then
                    AddHandler Me._btnSelectAllPowers.Click, AddressOf Me.btnSelectAllPowers_Click
                End If
            End Set
        End Property

        ' Token: 0x170006B6 RID: 1718
        ' (get) Token: 0x06001247 RID: 4679 RVA: 0x002A1198 File Offset: 0x002A0198
        ' (set) Token: 0x06001248 RID: 4680 RVA: 0x002A11AC File Offset: 0x002A01AC
        Friend Overridable Property btnInventory() As Button
            Get
                Return Me._btnInventory
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnInventory IsNot Nothing Then
                    RemoveHandler Me._btnInventory.Click, AddressOf Me.btnInventory_Click
                End If
                Me._btnInventory = value
                If Me._btnInventory IsNot Nothing Then
                    AddHandler Me._btnInventory.Click, AddressOf Me.btnInventory_Click
                End If
            End Set
        End Property

        ' Token: 0x170006B7 RID: 1719
        ' (get) Token: 0x06001249 RID: 4681 RVA: 0x002A121C File Offset: 0x002A021C
        ' (set) Token: 0x0600124A RID: 4682 RVA: 0x002A1200 File Offset: 0x002A0200
        Friend Overridable Property GroupBox19() As GroupBox
            Get
                Return Me._GroupBox19
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox19 IsNot Nothing Then
                End If
                Me._GroupBox19 = value
                If Me._GroupBox19 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006B8 RID: 1720
        ' (get) Token: 0x0600124C RID: 4684 RVA: 0x002A124C File Offset: 0x002A024C
        ' (set) Token: 0x0600124B RID: 4683 RVA: 0x002A1230 File Offset: 0x002A0230
        Friend Overridable Property tbForcePowerSummary() As TextBox
            Get
                Return Me._tbForcePowerSummary
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbForcePowerSummary IsNot Nothing Then
                End If
                Me._tbForcePowerSummary = value
                If Me._tbForcePowerSummary IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006B9 RID: 1721
        ' (get) Token: 0x0600124D RID: 4685 RVA: 0x002A1260 File Offset: 0x002A0260
        ' (set) Token: 0x0600124E RID: 4686 RVA: 0x002A1274 File Offset: 0x002A0274
        Friend Overridable Property GroupBox20() As GroupBox
            Get
                Return Me._GroupBox20
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._GroupBox20 IsNot Nothing Then
                End If
                Me._GroupBox20 = value
                If Me._GroupBox20 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006BA RID: 1722
        ' (get) Token: 0x06001250 RID: 4688 RVA: 0x002A1290 File Offset: 0x002A0290
        ' (set) Token: 0x0600124F RID: 4687 RVA: 0x002A12A4 File Offset: 0x002A02A4
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

        ' Token: 0x170006BB RID: 1723
        ' (get) Token: 0x06001251 RID: 4689 RVA: 0x002A12F8 File Offset: 0x002A02F8
        ' (set) Token: 0x06001252 RID: 4690 RVA: 0x002A130C File Offset: 0x002A030C
        Friend Overridable Property cmbxBodyBag() As ComboBox
            Get
                Return Me._cmbxBodyBag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxBodyBag IsNot Nothing Then
                End If
                Me._cmbxBodyBag = value
                If Me._cmbxBodyBag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006BC RID: 1724
        ' (get) Token: 0x06001253 RID: 4691 RVA: 0x002A1328 File Offset: 0x002A0328
        ' (set) Token: 0x06001254 RID: 4692 RVA: 0x002A133C File Offset: 0x002A033C
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

        ' Token: 0x170006BD RID: 1725
        ' (get) Token: 0x06001256 RID: 4694 RVA: 0x002A1374 File Offset: 0x002A0374
        ' (set) Token: 0x06001255 RID: 4693 RVA: 0x002A1358 File Offset: 0x002A0358
        Friend Overridable Property chkbIsHologram() As CheckBox
            Get
                Return Me._chkbIsHologram
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbIsHologram IsNot Nothing Then
                End If
                Me._chkbIsHologram = value
                If Me._chkbIsHologram IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006BE RID: 1726
        ' (get) Token: 0x06001257 RID: 4695 RVA: 0x002A1388 File Offset: 0x002A0388
        ' (set) Token: 0x06001258 RID: 4696 RVA: 0x002A139C File Offset: 0x002A039C
        Friend Overridable Property chkbNotReorienting() As CheckBox
            Get
                Return Me._chkbNotReorienting
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbNotReorienting IsNot Nothing Then
                End If
                Me._chkbNotReorienting = value
                If Me._chkbNotReorienting IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006BF RID: 1727
        ' (get) Token: 0x06001259 RID: 4697 RVA: 0x002A13B8 File Offset: 0x002A03B8
        ' (set) Token: 0x0600125A RID: 4698 RVA: 0x002A13CC File Offset: 0x002A03CC
        Friend Overridable Property chkbIgnoreCrePath() As CheckBox
            Get
                Return Me._chkbIgnoreCrePath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbIgnoreCrePath IsNot Nothing Then
                End If
                Me._chkbIgnoreCrePath = value
                If Me._chkbIgnoreCrePath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006C0 RID: 1728
        ' (get) Token: 0x0600125C RID: 4700 RVA: 0x002A13E8 File Offset: 0x002A03E8
        ' (set) Token: 0x0600125B RID: 4699 RVA: 0x002A13FC File Offset: 0x002A03FC
        Friend Overridable Property nudMultiplierSet() As NumericUpDown
            Get
                Return Me._nudMultiplierSet
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudMultiplierSet IsNot Nothing Then
                End If
                Me._nudMultiplierSet = value
                If Me._nudMultiplierSet IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006C1 RID: 1729
        ' (get) Token: 0x0600125E RID: 4702 RVA: 0x002A1418 File Offset: 0x002A0418
        ' (set) Token: 0x0600125D RID: 4701 RVA: 0x002A142C File Offset: 0x002A042C
        Friend Overridable Property lblMultiplierSet() As Label
            Get
                Return Me._lblMultiplierSet
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblMultiplierSet IsNot Nothing Then
                End If
                Me._lblMultiplierSet = value
                If Me._lblMultiplierSet IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006C2 RID: 1730
        ' (get) Token: 0x0600125F RID: 4703 RVA: 0x002A1448 File Offset: 0x002A0448
        ' (set) Token: 0x06001260 RID: 4704 RVA: 0x002A145C File Offset: 0x002A045C
        Friend Overridable Property lblBlindSpot() As Label
            Get
                Return Me._lblBlindSpot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblBlindSpot IsNot Nothing Then
                End If
                Me._lblBlindSpot = value
                If Me._lblBlindSpot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006C3 RID: 1731
        ' (get) Token: 0x06001262 RID: 4706 RVA: 0x002A1478 File Offset: 0x002A0478
        ' (set) Token: 0x06001261 RID: 4705 RVA: 0x002A148C File Offset: 0x002A048C
        Friend Overridable Property nudBlindSpot() As NumericUpDown
            Get
                Return Me._nudBlindSpot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudBlindSpot IsNot Nothing Then
                End If
                Me._nudBlindSpot = value
                If Me._nudBlindSpot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006C4 RID: 1732
        ' (get) Token: 0x06001264 RID: 4708 RVA: 0x002A14A8 File Offset: 0x002A04A8
        ' (set) Token: 0x06001263 RID: 4707 RVA: 0x002A14BC File Offset: 0x002A04BC
        Friend Overridable Property chkbMin1HP() As CheckBox
            Get
                Return Me._chkbMin1HP
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbMin1HP IsNot Nothing Then
                End If
                Me._chkbMin1HP = value
                If Me._chkbMin1HP IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006C5 RID: 1733
        ' (get) Token: 0x06001266 RID: 4710 RVA: 0x002A14D8 File Offset: 0x002A04D8
        ' (set) Token: 0x06001265 RID: 4709 RVA: 0x002A14EC File Offset: 0x002A04EC
        Friend Overridable Property cmbxFaction() As ComboBox
            Get
                Return Me._cmbxFaction
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxFaction IsNot Nothing Then
                End If
                Me._cmbxFaction = value
                If Me._cmbxFaction IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006C6 RID: 1734
        ' (get) Token: 0x06001267 RID: 4711 RVA: 0x002A1524 File Offset: 0x002A0524
        ' (set) Token: 0x06001268 RID: 4712 RVA: 0x002A1508 File Offset: 0x002A0508
        Friend Overridable Property chkbIsPC() As CheckBox
            Get
                Return Me._chkbIsPC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbIsPC IsNot Nothing Then
                End If
                Me._chkbIsPC = value
                If Me._chkbIsPC IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006C7 RID: 1735
        ' (get) Token: 0x0600126A RID: 4714 RVA: 0x002A1538 File Offset: 0x002A0538
        ' (set) Token: 0x06001269 RID: 4713 RVA: 0x002A154C File Offset: 0x002A054C
        Friend Overridable Property btnEditOnEndDialogu() As Button
            Get
                Return Me._btnEditOnEndDialogu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnEndDialogu IsNot Nothing Then
                    RemoveHandler Me._btnEditOnEndDialogu.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnEndDialogu = value
                If Me._btnEditOnEndDialogu IsNot Nothing Then
                    AddHandler Me._btnEditOnEndDialogu.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006C8 RID: 1736
        ' (get) Token: 0x0600126B RID: 4715 RVA: 0x002A15F4 File Offset: 0x002A05F4
        ' (set) Token: 0x0600126C RID: 4716 RVA: 0x002A15A0 File Offset: 0x002A05A0
        Friend Overridable Property btnEditOnDialogue() As Button
            Get
                Return Me._btnEditOnDialogue
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnDialogue IsNot Nothing Then
                    RemoveHandler Me._btnEditOnDialogue.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnDialogue = value
                If Me._btnEditOnDialogue IsNot Nothing Then
                    AddHandler Me._btnEditOnDialogue.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006C9 RID: 1737
        ' (get) Token: 0x0600126E RID: 4718 RVA: 0x002A165C File Offset: 0x002A065C
        ' (set) Token: 0x0600126D RID: 4717 RVA: 0x002A1608 File Offset: 0x002A0608
        Friend Overridable Property btnEditOnUserDefine() As Button
            Get
                Return Me._btnEditOnUserDefine
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnUserDefine IsNot Nothing Then
                    RemoveHandler Me._btnEditOnUserDefine.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnUserDefine = value
                If Me._btnEditOnUserDefine IsNot Nothing Then
                    AddHandler Me._btnEditOnUserDefine.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006CA RID: 1738
        ' (get) Token: 0x06001270 RID: 4720 RVA: 0x002A1670 File Offset: 0x002A0670
        ' (set) Token: 0x0600126F RID: 4719 RVA: 0x002A1684 File Offset: 0x002A0684
        Friend Overridable Property btnEditOnHeartbeat() As Button
            Get
                Return Me._btnEditOnHeartbeat
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnHeartbeat IsNot Nothing Then
                    RemoveHandler Me._btnEditOnHeartbeat.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnHeartbeat = value
                If Me._btnEditOnHeartbeat IsNot Nothing Then
                    AddHandler Me._btnEditOnHeartbeat.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006CB RID: 1739
        ' (get) Token: 0x06001271 RID: 4721 RVA: 0x002A16D8 File Offset: 0x002A06D8
        ' (set) Token: 0x06001272 RID: 4722 RVA: 0x002A16EC File Offset: 0x002A06EC
        Friend Overridable Property btnEditOnDisturbed() As Button
            Get
                Return Me._btnEditOnDisturbed
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnDisturbed IsNot Nothing Then
                    RemoveHandler Me._btnEditOnDisturbed.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnDisturbed = value
                If Me._btnEditOnDisturbed IsNot Nothing Then
                    AddHandler Me._btnEditOnDisturbed.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006CC RID: 1740
        ' (get) Token: 0x06001273 RID: 4723 RVA: 0x002A1740 File Offset: 0x002A0740
        ' (set) Token: 0x06001274 RID: 4724 RVA: 0x002A1754 File Offset: 0x002A0754
        Friend Overridable Property btnEditOnDamaged() As Button
            Get
                Return Me._btnEditOnDamaged
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnDamaged IsNot Nothing Then
                    RemoveHandler Me._btnEditOnDamaged.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnDamaged = value
                If Me._btnEditOnDamaged IsNot Nothing Then
                    AddHandler Me._btnEditOnDamaged.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006CD RID: 1741
        ' (get) Token: 0x06001275 RID: 4725 RVA: 0x002A17A8 File Offset: 0x002A07A8
        ' (set) Token: 0x06001276 RID: 4726 RVA: 0x002A17BC File Offset: 0x002A07BC
        Friend Overridable Property btnEditOnAttacked() As Button
            Get
                Return Me._btnEditOnAttacked
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnAttacked IsNot Nothing Then
                    RemoveHandler Me._btnEditOnAttacked.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnAttacked = value
                If Me._btnEditOnAttacked IsNot Nothing Then
                    AddHandler Me._btnEditOnAttacked.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006CE RID: 1742
        ' (get) Token: 0x06001277 RID: 4727 RVA: 0x002A1810 File Offset: 0x002A0810
        ' (set) Token: 0x06001278 RID: 4728 RVA: 0x002A1824 File Offset: 0x002A0824
        Friend Overridable Property btnEditOnNotice() As Button
            Get
                Return Me._btnEditOnNotice
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnNotice IsNot Nothing Then
                    RemoveHandler Me._btnEditOnNotice.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnNotice = value
                If Me._btnEditOnNotice IsNot Nothing Then
                    AddHandler Me._btnEditOnNotice.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006CF RID: 1743
        ' (get) Token: 0x06001279 RID: 4729 RVA: 0x002A18CC File Offset: 0x002A08CC
        ' (set) Token: 0x0600127A RID: 4730 RVA: 0x002A1878 File Offset: 0x002A0878
        Friend Overridable Property btnEditOnSpellAt() As Button
            Get
                Return Me._btnEditOnSpellAt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnSpellAt IsNot Nothing Then
                    RemoveHandler Me._btnEditOnSpellAt.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnSpellAt = value
                If Me._btnEditOnSpellAt IsNot Nothing Then
                    AddHandler Me._btnEditOnSpellAt.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006D0 RID: 1744
        ' (get) Token: 0x0600127C RID: 4732 RVA: 0x002A1934 File Offset: 0x002A0934
        ' (set) Token: 0x0600127B RID: 4731 RVA: 0x002A18E0 File Offset: 0x002A08E0
        Friend Overridable Property btnEditOnSpawn() As Button
            Get
                Return Me._btnEditOnSpawn
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnSpawn IsNot Nothing Then
                    RemoveHandler Me._btnEditOnSpawn.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnSpawn = value
                If Me._btnEditOnSpawn IsNot Nothing Then
                    AddHandler Me._btnEditOnSpawn.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006D1 RID: 1745
        ' (get) Token: 0x0600127D RID: 4733 RVA: 0x002A1948 File Offset: 0x002A0948
        ' (set) Token: 0x0600127E RID: 4734 RVA: 0x002A195C File Offset: 0x002A095C
        Friend Overridable Property btnEditOnDeath() As Button
            Get
                Return Me._btnEditOnDeath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnDeath IsNot Nothing Then
                    RemoveHandler Me._btnEditOnDeath.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnDeath = value
                If Me._btnEditOnDeath IsNot Nothing Then
                    AddHandler Me._btnEditOnDeath.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006D2 RID: 1746
        ' (get) Token: 0x06001280 RID: 4736 RVA: 0x002A19B0 File Offset: 0x002A09B0
        ' (set) Token: 0x0600127F RID: 4735 RVA: 0x002A19C4 File Offset: 0x002A09C4
        Friend Overridable Property btnEditOnBlocked() As Button
            Get
                Return Me._btnEditOnBlocked
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnBlocked IsNot Nothing Then
                    RemoveHandler Me._btnEditOnBlocked.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnBlocked = value
                If Me._btnEditOnBlocked IsNot Nothing Then
                    AddHandler Me._btnEditOnBlocked.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006D3 RID: 1747
        ' (get) Token: 0x06001282 RID: 4738 RVA: 0x002A1A18 File Offset: 0x002A0A18
        ' (set) Token: 0x06001281 RID: 4737 RVA: 0x002A1A2C File Offset: 0x002A0A2C
        Friend Overridable Property btnEditOnRested() As Button
            Get
                Return Me._btnEditOnRested
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnRested IsNot Nothing Then
                    RemoveHandler Me._btnEditOnRested.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnRested = value
                If Me._btnEditOnRested IsNot Nothing Then
                    AddHandler Me._btnEditOnRested.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170006D4 RID: 1748
        ' (get) Token: 0x06001283 RID: 4739 RVA: 0x002A1AD4 File Offset: 0x002A0AD4
        ' (set) Token: 0x06001284 RID: 4740 RVA: 0x002A1A80 File Offset: 0x002A0A80
        Friend Overridable Property btnEditOnEndRound() As Button
            Get
                Return Me._btnEditOnEndRound
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnEndRound IsNot Nothing Then
                    RemoveHandler Me._btnEditOnEndRound.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnEndRound = value
                If Me._btnEditOnEndRound IsNot Nothing Then
                    AddHandler Me._btnEditOnEndRound.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x06001286 RID: 4742 RVA: 0x002A8C44 File Offset: 0x002A7C44
        Public Sub New(ByVal UTCClass As clsUTC, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Creature Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTC = UTCClass
            Me.KotorVersionIndex = KotorVerIndex
            Dim num As Integer = IntegerType.FromObject(Me.UTC.GetNodeValue("Color_Skin"))
            Me.Setup()
        End Sub

        ' Token: 0x170006D5 RID: 1749
        ' (get) Token: 0x06001287 RID: 4743 RVA: 0x002A8D0C File Offset: 0x002A7D0C
        ' (set) Token: 0x06001288 RID: 4744 RVA: 0x002A8D20 File Offset: 0x002A7D20
        Public Property IsSaveGameMode() As Boolean
            Get
                Return Me.m_bSaveGameMode
            End Get
            Set(ByVal value As Boolean)
                Me.m_bSaveGameMode = value
            End Set
        End Property

        ' Token: 0x06001289 RID: 4745 RVA: 0x002A8D2C File Offset: 0x002A7D2C
        Public Sub Setup()
            Dim clsChitinKey As clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me.BuildComboBoxes(clsChitinKey)
            Me.UTC.SetTextBoxFromCExoLocStringNodeValue(Me.tbFirstName, "FirstName")
            Me.UTC.SetTextBoxFromCExoLocStringNodeValue(Me.tbLastName, "LastName")
            Me.UTC.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTC.SetTextBoxToNodeValue(Me.tbConversation, "Conversation")
            Me.chkbNotInterruptable.Checked = BooleanType.FromObject(ObjectType.NotObj(ObjectType.ObjTst(Me.UTC.GetNodeValue("Interruptable"), 1, False) = 0))
            Me.UTC.SetTextBoxFromCExoLocStringNodeValue(Me.tbDescription, "Description")
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudStrength, "Str", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudIntelligence, "Int", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudWisdom, "Wis", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudDexterity, "Dex", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudConstitution, "Con", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudCharisma, "Cha", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudFortBonus, "fortbonus", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudRefBonus, "refbonus", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudWillBonus, "willbonus", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudNaturalAC, "NaturalAC", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudBaseHP, "HitPoints", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudMaxHP, "MaxHitPoints", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudCurrentHP, "CurrentHitPoints", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudAlignment, "GoodEvil", 0.0F)
            Me.trkbarAlignment.Value = IntegerType.FromObject(Me.UTC.GetNodeValue("GoodEvil"))
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudClassLevel, "ClassList(0).ClassLevel", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudComputerUse, "SkillList(0).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudDemolitions, "SkillList(1).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudStealth, "SkillList(2).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudAwareness, "SkillList(3).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudPersuade, "SkillList(4).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudRepair, "SkillList(5).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudSecurity, "SkillList(6).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudTreatInjury, "SkillList(7).Rank", 0.0F)
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnAttacked, "ScriptAttacked")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnBlocked, "ScriptOnBlocked")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnDamaged, "ScriptDamaged")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnDeath, "ScriptDeath")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnDialogue, "ScriptDialogue")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnDisturbed, "ScriptDisturbed")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnEndDialogu, "ScriptEndDialogu")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnEndRound, "ScriptEndRound")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnHeartbeat, "ScriptHeartbeat")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnNotice, "ScriptOnNotice")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnRested, "ScriptRested")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnSpawn, "ScriptSpawn")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnSpellAt, "ScriptSpellAt")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnUserDefine, "ScriptUserDefine")
            Me.FillChkListBoxFrom2DA(Me.chklbFeats, "name", "feat", clsChitinKey, Me.g_clsDialogTlk)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.UTC.GetListItemCount("FeatList") - 1
            For i As Integer = num To num2
                Me.chklbFeats.SetItemChecked(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTC.GetNodeValue("FeatList(" + StringType.FromInteger(i) + ").Feat"))), True)
            Next
            Me.FillSpecialAbilitiesChkListBoxFrom2DA(Me.chklbSpecialAbilities, clsChitinKey, Me.g_clsDialogTlk)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudForcePoints, "ForcePoints", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudCurrentForce, "CurrentForce", 0.0F)
            Me.FillSpellsChkListBoxFrom2DA(Me.chklbForcePowers, clsChitinKey, Me.g_clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA("spells", clsChitinKey)
            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.UTC.GetListItemCount("ClassList(0).KnownList0") - 1
            For i As Integer = num3 To num4
                Dim num5 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTC.GetNodeValue("ClassList(0).KnownList0(" + StringType.FromInteger(i) + ").Spell")))
                Dim indiceData As Object = cls2DA.GetIndiceData(num5, "usertype")
                If BooleanType.FromObject(If((Not BooleanType.FromObject(Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData))) OrElse Not BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(indiceData, 1, False) = 0, ObjectType.ObjTst(indiceData, -2, False) = 0), ObjectType.ObjTst(indiceData, 6, False) = 0))), False, True)) Then
                    Me.chklbForcePowers.SetItemChecked(Me.g_ForcePowerList.IndexOf(num5), True)
                End If
            Next
            Me.UTC.SetTextBoxToNodeValue(Me.tbChallengeRating, "ChallengeRating")
            Me.chkbDisarmable.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("Disarmable"))
            Me.chkbPlot.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("Plot"))
            Me.chkbNoPermDeath.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("NoPermDeath"))
            Me.chkbMin1HP.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("Min1HP"))
            Me.chkbIsPC.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("IsPC"))
            Me.UTC.SetTextBoxToNodeValue(Me.tbDeity, "Deity")
            If Me.UTC.VerifyNodeExists("TemplateResRef") Then
                Me.UTC.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
                Me.SyncPerceptionRangeComboBox()
            End If
            If Me.KotorVersionIndex = 1 Then
                Me.lblBlindSpot.Visible = True
                Me.lblMultiplierSet.Visible = True
                Me.nudBlindSpot.Visible = True
                Me.nudMultiplierSet.Visible = True
                Me.chkbIsHologram.Visible = True
                Me.chkbNotReorienting.Visible = True
                Me.chkbIgnoreCrePath.Visible = True
                Me.UTC.SetNumericUpDownToNodeValue(Me.nudBlindSpot, "BlindSpot", 0.0F)
                Me.UTC.SetNumericUpDownToNodeValue(Me.nudMultiplierSet, "MultiplierSet", 0.0F)
                Me.chkbIgnoreCrePath.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("IgnoreCrePath"))
                Me.chkbIsHologram.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("Hologram"))
                Me.chkbNotReorienting.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("NotReorienting"))
            End If
            Me.UTC.SetTextBoxToNodeValue(Me.tbComments, "Comment")
            If Me.ComboBoxSettingError Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
        End Sub

        ' Token: 0x0600128A RID: 4746 RVA: 0x002A95BC File Offset: 0x002A85BC
        Private Function BuildComboBoxes(ByVal clsChitin As clsChitinKey) As Object
            Me.FillComboBoxFrom2DA(Me.cmbxAppearance, "label", "appearance", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxAppearance, "Appearance_Type") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxFaction, "label", "repute", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxFaction, "FactionID") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxBodyBag, "label", "bodybag", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxBodyBag, "BodyBag") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxGender, "name", "gender", clsChitin, Me.g_clsDialogTlk)
            If Not Me.UTC.SyncComboBox(Me.cmbxGender, "Gender") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxRace, "name", "racialtypes", clsChitin, Me.g_clsDialogTlk)
            If Not Me.UTC.SyncComboBox(Me.cmbxRace, "Race") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxPhenotype, "label", "phenotype", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxPhenotype, "Phenotype") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxMovementRate, "label", "creaturespeed", clsChitin, Nothing)
            If Me.UTC.VerifyNodeExists("WalkRate") AndAlso Not Me.UTC.SyncComboBox(Me.cmbxMovementRate, "WalkRate") Then
                Me.ComboBoxSettingError = True
            End If
            If Me.UTC.VerifyNodeExists("MovementRate") AndAlso Not Me.UTC.SyncComboBox(Me.cmbxMovementRate, "MovementRate") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxClass, "name", "classes", clsChitin, Me.g_clsDialogTlk)
            If Not Me.UTC.SyncComboBox(Me.cmbxClass, "ClassList(0).Class") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxSubrace, "label", "subrace", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxSubrace, "SubraceIndex") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxSoundSet, "label", "soundset", clsChitin, Me.g_clsDialogTlk)
            If Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTC.GetNodeValue("SoundSetFile"))) = 65535 Then
                Me.cmbxSoundSet.SelectedIndex = 0
            ElseIf Not Me.UTC.SyncComboBox(Me.cmbxSoundSet, "SoundSetFile") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxPortrait, "baseresref", "portraits", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxPortrait, "PortraitId") Then
                Me.ComboBoxSettingError = True
            End If
            Dim obj As Object
            Return obj
        End Function

        ' Token: 0x0600128B RID: 4747 RVA: 0x002A98B0 File Offset: 0x002A88B0
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

        ' Token: 0x0600128C RID: 4748 RVA: 0x002A9950 File Offset: 0x002A8950
        Private Sub SyncPerceptionRangeComboBox()
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.UTC.GetNodeValue("PerceptionRange"))
            If objectValue IsNot Nothing Then
                ' The following expression was wrapped in a checked-expression
                Me.cmbxPerceptionRange.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)) - 9
            End If
        End Sub

        ' Token: 0x0600128D RID: 4749 RVA: 0x002A9990 File Offset: 0x002A8990
        Private Sub FillChkListBoxFrom2DA(ByVal lbx As CheckedListBox, ByVal colName As String, ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA(TwoDAName, ChitinKey)
            If DialogTlk IsNot Nothing Then
                Dim num As Integer = 0
                Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
                For i As Integer = num To rowsUpperBound
                    Dim indiceData As Object = cls2DA.GetIndiceData(i, colName)
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
                        lbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
                    Else
                        lbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
                    End If
                Next
            Else
                Dim num2 As Integer = 0
                Dim rowsUpperBound2 As Integer = cls2DA.RowsUpperBound
                For i As Integer = num2 To rowsUpperBound2
                    lbx.Items.Add(cls2DA.GetIndiceData(i, colName))
                Next
            End If
        End Sub

        ' Token: 0x0600128E RID: 4750 RVA: 0x002A9A30 File Offset: 0x002A8A30
        Private Sub FillSpellsChkListBoxFrom2DA(ByVal lbx As CheckedListBox, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA("spells", ChitinKey)
            Dim num As Integer = 0
            Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
            For i As Integer = num To rowsUpperBound
                Dim obj As Object = cls2DA.GetIndiceData(i, "usertype")
                If BooleanType.FromObject(If((Not BooleanType.FromObject(Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj))) OrElse Not BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(obj, 1, False) = 0, ObjectType.ObjTst(obj, -2, False) = 0), ObjectType.ObjTst(obj, 6, False) = 0))), False, True)) Then
                    obj = cls2DA.GetIndiceData(i, "name")
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
                        lbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(obj)))
                        Me.g_ForcePowerList.Add(i)
                    End If
                End If
            Next
        End Sub

        ' Token: 0x0600128F RID: 4751 RVA: 0x002A9B38 File Offset: 0x002A8B38
        Private Sub FillSpecialAbilitiesChkListBoxFrom2DA(ByVal lbx As CheckedListBox, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim arrayList As ArrayList = New ArrayList()
            Dim cls2DA As cls2DA = Me.ReadCls2DA("spells", ChitinKey)
            Dim num As Integer = 0
            Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
            For i As Integer = num To rowsUpperBound
                Dim obj As Object = cls2DA.GetIndiceData(i, "usertype")
                If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) AndAlso ObjectType.ObjTst(obj, 2, False) = 0 Then
                    obj = cls2DA.GetIndiceData(i, "name")
                    Dim text As String
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
                        text = DialogTlk.GetString(IntegerType.FromObject(obj))
                    Else
                        text = StringType.FromObject(obj)
                    End If
                    If StringType.StrCmp(text, "****", False) <> 0 Then
                        arrayList.Add(New ComboBoxListItem(i, text, ""))
                    End If
                End If
            Next
            lbx.DataSource = arrayList
            lbx.DisplayMember = "Text"
            lbx.ValueMember = "TwoDAIndex"
        End Sub

        ' Token: 0x06001290 RID: 4752 RVA: 0x002A9C18 File Offset: 0x002A8C18
        Private Sub trkbarAlignment_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            Me.nudAlignment.Value = New Decimal(CType(sender, TrackBar).Value)
        End Sub

        ' Token: 0x06001291 RID: 4753 RVA: 0x002A9C38 File Offset: 0x002A8C38
        Private Sub nudAlignment_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarAlignment.Value = Convert.ToInt32(CType(sender, NumericUpDown).Value)
        End Sub

        ' Token: 0x06001292 RID: 4754 RVA: 0x002A9C58 File Offset: 0x002A8C58
        Private Sub chklbForcePowers_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.tbForcePowerSummary.Clear()
            Try
                For Each obj As Object In Me.chklbForcePowers.CheckedItems
                    Dim text As String = StringType.FromObject(obj)
                    Dim tbForcePowerSummary As TextBox = Me.tbForcePowerSummary
                    tbForcePowerSummary.Text = tbForcePowerSummary.Text + text + vbCrLf
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06001293 RID: 4755 RVA: 0x002A9CDC File Offset: 0x002A8CDC
        Private Sub chklbFeats_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.tbFeatSummary.Clear()
            Try
                For Each obj As Object In Me.chklbFeats.CheckedItems
                    Dim text As String = StringType.FromObject(obj)
                    Dim tbFeatSummary As TextBox = Me.tbFeatSummary
                    tbFeatSummary.Text = tbFeatSummary.Text + text + vbCrLf
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x170006D6 RID: 1750
        ' (set) Token: 0x06001294 RID: 4756 RVA: 0x002A9D60 File Offset: 0x002A8D60
        Public WriteOnly Property UTCFileData() As Object
            Set(ByVal value As Object)
                Me.UTC = CType(value, clsUTC)
            End Set
        End Property

        ' Token: 0x06001295 RID: 4757 RVA: 0x002A9D70 File Offset: 0x002A8D70
        Private Sub SetGFFNodeValues()
            Me.UTC.SetCExoLocStringNodeValueFromTextBox(Me.tbFirstName, "FirstName", 0)
            Me.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.SetNodeValueFromTextBox(Me.tbConversation, "Conversation")
            Dim b As Byte
            If Me.chkbNotInterruptable.Checked Then
                b = 0
            Else
                b = 1
            End If
            Me.UTC.SetNodeValue("Interruptable", b)
            Me.UTC.SetCExoLocStringNodeValueFromTextBox(Me.tbDescription, "Description", 0)
            Me.SetNodeValueFromComboBox(Me.cmbxRace, "Race")
            Me.SetNodeValueFromComboBox(Me.cmbxAppearance, "Appearance_Type")
            Me.SetNodeValueFromComboBox(Me.cmbxGender, "Gender")
            Me.SetNodeValueFromComboBox(Me.cmbxPhenotype, "Phenotype")
            Me.SetNodeValueFromComboBox(Me.cmbxBodyBag, "BodyBag")
            Me.SetNodeValueFromNumericUpDown(Me.nudStrength, "Str")
            Me.SetNodeValueFromNumericUpDown(Me.nudIntelligence, "Int")
            Me.SetNodeValueFromNumericUpDown(Me.nudWisdom, "Wis")
            Me.SetNodeValueFromNumericUpDown(Me.nudDexterity, "Dex")
            Me.SetNodeValueFromNumericUpDown(Me.nudConstitution, "Con")
            Me.SetNodeValueFromNumericUpDown(Me.nudCharisma, "Cha")
            Me.SetNodeValueFromNumericUpDown(Me.nudFortBonus, "fortbonus")
            Me.SetNodeValueFromNumericUpDown(Me.nudRefBonus, "refbonus")
            Me.SetNodeValueFromNumericUpDown(Me.nudWillBonus, "willbonus")
            Me.SetNodeValueFromNumericUpDown(Me.nudNaturalAC, "NaturalAC")
            Me.SetNodeValueFromNumericUpDown(Me.nudBaseHP, "HitPoints")
            Me.SetNodeValueFromNumericUpDown(Me.nudMaxHP, "MaxHitPoints")
            Me.SetNodeValueFromNumericUpDown(Me.nudCurrentHP, "CurrentHitPoints")
            If Me.UTC.VerifyNodeExists("WalkRate") Then
                Me.SetNodeValueFromComboBox(Me.cmbxMovementRate, "WalkRate")
            End If
            If Me.UTC.VerifyNodeExists("MovementRate") Then
                Me.SetNodeValueFromComboBox(Me.cmbxMovementRate, "MovementRate")
            End If
            Me.SetNodeValueFromNumericUpDown(Me.nudAlignment, "GoodEvil")
            Me.SetNodeValueFromNumericUpDown(Me.nudClassLevel, "ClassList(0).ClassLevel")
            Me.SetNodeValueFromComboBox(Me.cmbxClass, "ClassList(0).Class")
            Me.SetNodeValueFromNumericUpDown(Me.nudComputerUse, "SkillList(0).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudDemolitions, "SkillList(1).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudStealth, "SkillList(2).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudAwareness, "SkillList(3).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudPersuade, "SkillList(4).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudRepair, "SkillList(5).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudSecurity, "SkillList(6).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudTreatInjury, "SkillList(7).Rank")
            Me.SetNodeValueFromTextBox(Me.tbOnAttacked, "ScriptAttacked")
            Me.SetNodeValueFromTextBox(Me.tbOnBlocked, "ScriptOnBlocked")
            Me.SetNodeValueFromTextBox(Me.tbOnDamaged, "ScriptDamaged")
            Me.SetNodeValueFromTextBox(Me.tbOnDeath, "ScriptDeath")
            Me.SetNodeValueFromTextBox(Me.tbOnDialogue, "ScriptDialogue")
            Me.SetNodeValueFromTextBox(Me.tbOnDisturbed, "ScriptDisturbed")
            Me.SetNodeValueFromTextBox(Me.tbOnEndDialogu, "ScriptEndDialogu")
            Me.SetNodeValueFromTextBox(Me.tbOnEndRound, "ScriptEndRound")
            Me.SetNodeValueFromTextBox(Me.tbOnHeartbeat, "ScriptHeartbeat")
            Me.SetNodeValueFromTextBox(Me.tbOnNotice, "ScriptOnNotice")
            Me.SetNodeValueFromTextBox(Me.tbOnRested, "ScriptRested")
            Me.SetNodeValueFromTextBox(Me.tbOnSpawn, "ScriptSpawn")
            Me.SetNodeValueFromTextBox(Me.tbOnSpellAt, "ScriptSpellAt")
            Me.SetNodeValueFromTextBox(Me.tbOnUserDefine, "ScriptUserDefine")
            Me.UTC.ClearListElements("FeatList")
            Try
                For Each obj As Object In Me.chklbFeats.CheckedIndices
                    Dim num As Integer = IntegerType.FromObject(obj)
                    Dim gff_Struct As GFF_Struct = New GFF_Struct()
                    gff_Struct.type = 1
                    gff_Struct.fieldCount = 1
                    gff_Struct.fields = New GFF_Field(0) {}
                    gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_word, "Feat", num)
                    Me.UTC.AddListElement("FeatList", gff_Struct)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.SetNodeValueFromNumericUpDown(Me.nudForcePoints, "ForcePoints")
            Me.SetNodeValueFromNumericUpDown(Me.nudCurrentForce, "CurrentForce")
            Me.UTC.ClearListElements("ClassList(0).KnownList0")
            Try
                For Each obj2 As Object In Me.chklbForcePowers.CheckedIndices
                    Dim num As Integer = IntegerType.FromObject(obj2)
                    Dim gff_Struct As GFF_Struct = New GFF_Struct()
                    gff_Struct.type = 3
                    gff_Struct.fieldCount = 3
                    gff_Struct.fields = New GFF_Field(2) {}
                    Dim num2 As Integer = IntegerType.FromObject(Me.g_ForcePowerList(num))
                    gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_word, "Spell", num2)
                    gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_byte, "SpellMetaMagic", 0)
                    gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "SpellFlags", 1)
                    Me.UTC.AddListElement("ClassList(0).KnownList0", gff_Struct)
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            If Me.UTC.VerifyNodeExists("TemplateResRef") Then
                Me.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            End If
            Me.SetNodeValueFromComboBox(Me.cmbxSubrace, "Subrace")
            If Me.cmbxSoundSet.SelectedIndex = 0 Then
                Me.UTC.SetNodeValue("SoundSetFile", 65535)
            Else
                Me.SetNodeValueFromComboBox(Me.cmbxSoundSet, "SoundSetFile")
            End If
            Me.SetNodeValueFromTextBox(Me.tbDeity, "Deity")
            Me.SetNodeValueFromComboBox(Me.cmbxFaction, "FactionID")
            Me.UTC.SetNodeValue("Disarmable", Me.chkbDisarmable.Checked)
            Me.UTC.SetNodeValue("Plot", Me.chkbPlot.Checked)
            Me.UTC.SetNodeValue("Min1HP", Me.chkbMin1HP.Checked)
            Me.UTC.SetNodeValue("IsPC", Me.chkbIsPC.Checked)
            If Me.UTC.VerifyNodeExists("NoPermDeath") Then
                Me.UTC.SetNodeValue("NoPermDeath", Me.chkbNoPermDeath.Checked)
            End If
            Me.UTC.SetNodeValue("ChallengeRating", SingleType.FromString(Me.tbChallengeRating.Text))
            If Me.UTC.VerifyNodeExists("PerceptionRange") Then
                Me.SetPerceptionRangeNodeValueFromComboBox()
            End If
            If Me.KotorVersionIndex = 1 Then
                If Not Me.UTC.VerifyNodeExists("BlindSpot") Then
                    Me.UTC.AddSimpleField("BlindSpot", GFFField.GFF_float, Me.nudBlindSpot.Value)
                Else
                    Me.UTC.SetNodeValueFromNumericUpDown(Me.nudBlindSpot, "BlindSpot", 0.0F)
                End If
                If Not Me.UTC.VerifyNodeExists("MultiplierSet") Then
                    Me.UTC.AddSimpleField("MultiplierSet", GFFField.GFF_byte, Me.nudMultiplierSet.Value)
                Else
                    Me.UTC.SetNodeValueFromNumericUpDown(Me.nudMultiplierSet, "MultiplierSet", 0.0F)
                End If
                If Not Me.UTC.VerifyNodeExists("IgnoreCrePath") Then
                    Me.UTC.AddSimpleField("IgnoreCrePath", GFFField.GFF_byte, Me.chkbIgnoreCrePath.Checked)
                Else
                    Me.UTC.SetNodeValue("IgnoreCrePath", Me.chkbIgnoreCrePath.Checked)
                End If
                If Not Me.UTC.VerifyNodeExists("Hologram") Then
                    Me.UTC.AddSimpleField("Hologram", GFFField.GFF_byte, Me.chkbIsHologram.Checked)
                Else
                    Me.UTC.SetNodeValue("Hologram", Me.chkbIsHologram.Checked)
                End If
                If Not Me.UTC.VerifyNodeExists("NotReorienting") Then
                    Me.UTC.AddSimpleField("NotReorienting", GFFField.GFF_byte, Me.chkbNotReorienting.Checked)
                Else
                    Me.UTC.SetNodeValue("NotReorienting", Me.chkbNotReorienting.Checked)
                End If
            End If
            If Me.UTC.VerifyNodeExists("Comment") Then
                Me.SetNodeValueFromTextBox(Me.tbComments, "Comment")
            End If
        End Sub

        ' Token: 0x06001296 RID: 4758 RVA: 0x002AA628 File Offset: 0x002A9628
        Private Sub SetNodeValueFromNumericUpDown(ByVal NUD As NumericUpDown, ByVal NodePath As String)
            Me.UTC.SetNodeValue(NodePath, NUD.Value)
        End Sub

        ' Token: 0x06001297 RID: 4759 RVA: 0x002AA644 File Offset: 0x002A9644
        Private Sub SetNodeValueFromTextBox(ByVal TB As TextBox, ByVal NodePath As String)
            Me.UTC.SetNodeValue(NodePath, TB.Text)
        End Sub

        ' Token: 0x06001298 RID: 4760 RVA: 0x002AA658 File Offset: 0x002A9658
        Private Sub SetNodeValueFromComboBox(ByVal cmbx As ComboBox, ByVal NodePath As String)
            Me.UTC.SetNodeValue(NodePath, cmbx.SelectedIndex)
        End Sub

        ' Token: 0x06001299 RID: 4761 RVA: 0x002AA674 File Offset: 0x002A9674
        Private Sub SetPerceptionRangeNodeValueFromComboBox()
            ' The following expression was wrapped in a checked-expression
            Me.UTC.SetNodeValue("PerceptionRange", Me.cmbxPerceptionRange.SelectedIndex + 9)
        End Sub

        ' Token: 0x0600129A RID: 4762 RVA: 0x002AA69C File Offset: 0x002A969C
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x0600129B RID: 4763 RVA: 0x002AA6A4 File Offset: 0x002A96A4
        Private Sub btnWriteFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utc", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTC.WriteFile(Me.m_EditingFilePath, "UTC")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x0600129C RID: 4764 RVA: 0x002AA73C File Offset: 0x002A973C
        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim gff_Struct As GFF_Struct = New GFF_Struct()
            gff_Struct.type = 3
            gff_Struct.fieldCount = 3
            gff_Struct.fields = New GFF_Field(2) {}
            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_word, "Spell", 99)
            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_byte, "SpellMetaMagic", 1)
            gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "SpellFlags", 2)
            Me.UTC.AddListElement("ClassList(0).KnownList0", gff_Struct)
        End Sub

        ' Token: 0x0600129D RID: 4765 RVA: 0x002AA7C8 File Offset: 0x002A97C8
        Private Sub btnInventory_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmInventoryEditor As frmInventoryEditor = New frmInventoryEditor(Me.KotorVersionIndex)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.UTC.GetListItemCount("ItemList") - 1
            For i As Integer = num To num2
                Dim text As String = StringType.FromObject(Me.UTC.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").InventoryRes"))
                Dim flag As Boolean = Not Me.UTC.VerifyNodeExists("ItemList(" + StringType.FromInteger(i) + ").Dropable") OrElse ObjectType.ObjTst(Me.UTC.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").Dropable"), 1, False) = 0
                frmInventoryEditor.AddPackItem(text, flag)
            Next
            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.UTC.GetListItemCount("Equip_ItemList") - 1
            For i As Integer = num3 To num4
                Dim text As String = StringType.FromObject(Me.UTC.GetNodeValue("Equip_ItemList(" + StringType.FromInteger(i) + ").EquippedRes"))
                Dim structFieldType As Integer = Me.UTC.GetStructFieldType("Equip_ItemList(" + StringType.FromInteger(i) + ")")
                Dim flag As Boolean = Not Me.UTC.VerifyNodeExists("Equip_ItemList(" + StringType.FromInteger(i) + ").Dropable") OrElse ObjectType.ObjTst(Me.UTC.GetNodeValue("Equip_ItemList(" + StringType.FromInteger(i) + ").Dropable"), 1, False) = 0
                frmInventoryEditor.AddEquippedItem(text, structFieldType, flag)
            Next
            frmInventoryEditor.SetFormName(Me.tbTemplateResRef.Text + ".utc")
            If frmInventoryEditor.ShowDialog() = DialogResult.OK Then
                Dim i As Integer = 0
                Me.UTC.ClearListElements("ItemList")
                Try
                    For Each obj As Object In frmInventoryEditor.GetPackItemsList()
                        Dim inventoryItem As InventoryItem = CType(obj, InventoryItem)
                        Dim num5 As Integer = 1
                        Dim quantity As Integer = inventoryItem._Quantity
                        For j As Integer = num5 To quantity
                            Dim gff_Struct As GFF_Struct = New GFF_Struct()
                            gff_Struct.type = i
                            gff_Struct.fieldCount = 4
                            gff_Struct.fields = New GFF_Field(3) {}
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "InventoryRes", inventoryItem._ResRef)
                            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_word, "Repos_PosX", i)
                            gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_word, "Repos_PosY", 0)
                            Dim b As Byte
                            If inventoryItem._Dropable Then
                                b = 1
                            Else
                                b = 0
                            End If
                            gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_byte, "Dropable", b)
                            If Not Me.UTC.VerifyNodeExists("ItemList") Then
                                Me.UTC.CreateList("", "ItemList")
                            End If
                            Me.UTC.AddListElement("ItemList", gff_Struct)
                            i += 1
                        Next
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.UTC.ClearListElements("Equip_ItemList")
                Try
                    For Each obj2 As Object In frmInventoryEditor.GetEquippedItemsList()
                        Dim inventoryItem As InventoryItem = CType(obj2, InventoryItem)
                        If inventoryItem._ResRef IsNot Nothing Then
                            Dim gff_Struct As GFF_Struct = New GFF_Struct()
                            gff_Struct.type = IntegerType.FromString(inventoryItem._EquipableSlots)
                            gff_Struct.fieldCount = 2
                            gff_Struct.fields = New GFF_Field(1) {}
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "EquippedRes", inventoryItem._ResRef)
                            Dim b As Byte
                            If inventoryItem._Dropable Then
                                b = 1
                            Else
                                b = 0
                            End If
                            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_byte, "Dropable", b)
                            If Not Me.UTC.VerifyNodeExists("Equip_ItemList") Then
                                Me.UTC.CreateList("", "Equip_ItemList")
                            End If
                            Me.UTC.AddListElement("Equip_ItemList", gff_Struct)
                        End If
                    Next
                Finally
                    Dim enumerator2 As IEnumerator
                    If TypeOf enumerator2 Is IDisposable Then
                        CType(enumerator2, IDisposable).Dispose()
                    End If
                End Try
            End If
        End Sub

        ' Token: 0x0600129E RID: 4766 RVA: 0x002AAC1C File Offset: 0x002A9C1C
        Private Sub btnSelectAllPowers_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.chklbForcePowers.Items.Count - 1
            For i As Integer = num To num2
                Me.chklbForcePowers.SetItemChecked(i, True)
            Next
        End Sub

        ' Token: 0x0600129F RID: 4767 RVA: 0x002AAC58 File Offset: 0x002A9C58
        Private Sub btnClearAllPowers_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.chklbForcePowers.Items.Count - 1
            For i As Integer = num To num2
                Me.chklbForcePowers.SetItemChecked(i, False)
            Next
        End Sub

        ' Token: 0x060012A0 RID: 4768 RVA: 0x002AAC94 File Offset: 0x002A9C94
        Private Sub frmUTC_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060012A1 RID: 4769 RVA: 0x002AACA8 File Offset: 0x002A9CA8
        Private Sub frmUTC_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060012A2 RID: 4770 RVA: 0x002AACBC File Offset: 0x002A9CBC
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Creature Editor - " + Name
        End Sub

        ' Token: 0x060012A3 RID: 4771 RVA: 0x002AACD0 File Offset: 0x002A9CD0
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbTag.Text
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTC.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x060012A4 RID: 4772 RVA: 0x002AAD3C File Offset: 0x002A9D3C
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

        ' Token: 0x060012A5 RID: 4773 RVA: 0x002AAE78 File Offset: 0x002A9E78
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x04000833 RID: 2099
        <AccessedThroughProperty("tbOnEndRound")> _
        Private _tbOnEndRound As TextBox

        ' Token: 0x04000834 RID: 2100
        <AccessedThroughProperty("tbOnDisturbed")> _
        Private _tbOnDisturbed As TextBox

        ' Token: 0x04000835 RID: 2101
        <AccessedThroughProperty("tbOnDamaged")> _
        Private _tbOnDamaged As TextBox

        ' Token: 0x04000836 RID: 2102
        <AccessedThroughProperty("tbComments")> _
        Private _tbComments As TextBox

        ' Token: 0x04000837 RID: 2103
        <AccessedThroughProperty("tbOnAttacked")> _
        Private _tbOnAttacked As TextBox

        ' Token: 0x04000838 RID: 2104
        <AccessedThroughProperty("tbOnSpellAt")> _
        Private _tbOnSpellAt As TextBox

        ' Token: 0x04000839 RID: 2105
        <AccessedThroughProperty("tbOnNotice")> _
        Private _tbOnNotice As TextBox

        ' Token: 0x0400083A RID: 2106
        <AccessedThroughProperty("tbOnHeartbeat")> _
        Private _tbOnHeartbeat As TextBox

        ' Token: 0x0400083B RID: 2107
        <AccessedThroughProperty("nudTreatInjury")> _
        Private _nudTreatInjury As NumericUpDown

        ' Token: 0x0400083C RID: 2108
        <AccessedThroughProperty("nudSecurity")> _
        Private _nudSecurity As NumericUpDown

        ' Token: 0x0400083D RID: 2109
        <AccessedThroughProperty("nudRepair")> _
        Private _nudRepair As NumericUpDown

        ' Token: 0x0400083E RID: 2110
        <AccessedThroughProperty("nudPersuade")> _
        Private _nudPersuade As NumericUpDown

        ' Token: 0x0400083F RID: 2111
        <AccessedThroughProperty("nudAwareness")> _
        Private _nudAwareness As NumericUpDown

        ' Token: 0x04000840 RID: 2112
        <AccessedThroughProperty("nudStealth")> _
        Private _nudStealth As NumericUpDown

        ' Token: 0x04000841 RID: 2113
        <AccessedThroughProperty("nudDemolitions")> _
        Private _nudDemolitions As NumericUpDown

        ' Token: 0x04000842 RID: 2114
        <AccessedThroughProperty("nudComputerUse")> _
        Private _nudComputerUse As NumericUpDown

        ' Token: 0x04000843 RID: 2115
        <AccessedThroughProperty("cmbxClass")> _
        Private _cmbxClass As ComboBox

        ' Token: 0x04000844 RID: 2116
        <AccessedThroughProperty("nudRefBonus")> _
        Private _nudRefBonus As NumericUpDown

        ' Token: 0x04000845 RID: 2117
        <AccessedThroughProperty("nudFortBonus")> _
        Private _nudFortBonus As NumericUpDown

        ' Token: 0x04000846 RID: 2118
        <AccessedThroughProperty("nudWillBonus")> _
        Private _nudWillBonus As NumericUpDown

        ' Token: 0x04000847 RID: 2119
        <AccessedThroughProperty("nudNaturalAC")> _
        Private _nudNaturalAC As NumericUpDown

        ' Token: 0x04000848 RID: 2120
        <AccessedThroughProperty("GroupBox7")> _
        Private _GroupBox7 As GroupBox

        ' Token: 0x04000849 RID: 2121
        <AccessedThroughProperty("nudBaseHP")> _
        Private _nudBaseHP As NumericUpDown

        ' Token: 0x0400084A RID: 2122
        <AccessedThroughProperty("GroupBox5")> _
        Private _GroupBox5 As GroupBox

        ' Token: 0x0400084B RID: 2123
        <AccessedThroughProperty("GroupBox6")> _
        Private _GroupBox6 As GroupBox

        ' Token: 0x0400084C RID: 2124
        <AccessedThroughProperty("gb2")> _
        Private _gb2 As GroupBox

        ' Token: 0x0400084D RID: 2125
        <AccessedThroughProperty("nudCharisma")> _
        Private _nudCharisma As NumericUpDown

        ' Token: 0x0400084E RID: 2126
        <AccessedThroughProperty("Label46")> _
        Private _Label46 As Label

        ' Token: 0x0400084F RID: 2127
        <AccessedThroughProperty("nudWisdom")> _
        Private _nudWisdom As NumericUpDown

        ' Token: 0x04000850 RID: 2128
        <AccessedThroughProperty("Label44")> _
        Private _Label44 As Label

        ' Token: 0x04000851 RID: 2129
        <AccessedThroughProperty("tbOnEndDialogu")> _
        Private _tbOnEndDialogu As TextBox

        ' Token: 0x04000852 RID: 2130
        <AccessedThroughProperty("tbOnDialogue")> _
        Private _tbOnDialogue As TextBox

        ' Token: 0x04000853 RID: 2131
        <AccessedThroughProperty("Label45")> _
        Private _Label45 As Label

        ' Token: 0x04000854 RID: 2132
        <AccessedThroughProperty("tbOnSpawn")> _
        Private _tbOnSpawn As TextBox

        ' Token: 0x04000855 RID: 2133
        <AccessedThroughProperty("nudIntelligence")> _
        Private _nudIntelligence As NumericUpDown

        ' Token: 0x04000856 RID: 2134
        <AccessedThroughProperty("Label43")> _
        Private _Label43 As Label

        ' Token: 0x04000857 RID: 2135
        <AccessedThroughProperty("Label47")> _
        Private _Label47 As Label

        ' Token: 0x04000858 RID: 2136
        <AccessedThroughProperty("tbOnRested")> _
        Private _tbOnRested As TextBox

        ' Token: 0x04000859 RID: 2137
        <AccessedThroughProperty("Label49")> _
        Private _Label49 As Label

        ' Token: 0x0400085A RID: 2138
        <AccessedThroughProperty("tbOnDeath")> _
        Private _tbOnDeath As TextBox

        ' Token: 0x0400085B RID: 2139
        <AccessedThroughProperty("nudConstitution")> _
        Private _nudConstitution As NumericUpDown

        ' Token: 0x0400085C RID: 2140
        <AccessedThroughProperty("Label42")> _
        Private _Label42 As Label

        ' Token: 0x0400085D RID: 2141
        <AccessedThroughProperty("nudDexterity")> _
        Private _nudDexterity As NumericUpDown

        ' Token: 0x0400085E RID: 2142
        <AccessedThroughProperty("Label41")> _
        Private _Label41 As Label

        ' Token: 0x0400085F RID: 2143
        <AccessedThroughProperty("nudStrength")> _
        Private _nudStrength As NumericUpDown

        ' Token: 0x04000860 RID: 2144
        <AccessedThroughProperty("Label40")> _
        Private _Label40 As Label

        ' Token: 0x04000861 RID: 2145
        <AccessedThroughProperty("GroupBox4")> _
        Private _GroupBox4 As GroupBox

        ' Token: 0x04000862 RID: 2146
        <AccessedThroughProperty("Label50")> _
        Private _Label50 As Label

        ' Token: 0x04000863 RID: 2147
        <AccessedThroughProperty("tbOnBlocked")> _
        Private _tbOnBlocked As TextBox

        ' Token: 0x04000864 RID: 2148
        <AccessedThroughProperty("cmbxPhenotype")> _
        Private _cmbxPhenotype As ComboBox

        ' Token: 0x04000865 RID: 2149
        <AccessedThroughProperty("tabCtrl1")> _
        Private _tabCtrl1 As TabControl

        ' Token: 0x04000866 RID: 2150
        <AccessedThroughProperty("cmbxAppearance")> _
        Private _cmbxAppearance As ComboBox

        ' Token: 0x04000867 RID: 2151
        <AccessedThroughProperty("tbDescription")> _
        Private _tbDescription As TextBox

        ' Token: 0x04000868 RID: 2152
        <AccessedThroughProperty("tbLastName")> _
        Private _tbLastName As TextBox

        ' Token: 0x04000869 RID: 2153
        <AccessedThroughProperty("tbFirstName")> _
        Private _tbFirstName As TextBox

        ' Token: 0x0400086A RID: 2154
        <AccessedThroughProperty("Label51")> _
        Private _Label51 As Label

        ' Token: 0x0400086B RID: 2155
        <AccessedThroughProperty("tbOnUserDefine")> _
        Private _tbOnUserDefine As TextBox

        ' Token: 0x0400086C RID: 2156
        <AccessedThroughProperty("chkbNotInterruptable")> _
        Private _chkbNotInterruptable As CheckBox

        ' Token: 0x0400086D RID: 2157
        <AccessedThroughProperty("Label52")> _
        Private _Label52 As Label

        ' Token: 0x0400086E RID: 2158
        <AccessedThroughProperty("nudClassLevel")> _
        Private _nudClassLevel As NumericUpDown

        ' Token: 0x0400086F RID: 2159
        <AccessedThroughProperty("cmbxRace")> _
        Private _cmbxRace As ComboBox

        ' Token: 0x04000870 RID: 2160
        <AccessedThroughProperty("Label53")> _
        Private _Label53 As Label

        ' Token: 0x04000871 RID: 2161
        <AccessedThroughProperty("GroupBox8")> _
        Private _GroupBox8 As GroupBox

        ' Token: 0x04000872 RID: 2162
        <AccessedThroughProperty("Label54")> _
        Private _Label54 As Label

        ' Token: 0x04000873 RID: 2163
        <AccessedThroughProperty("GroupBox9")> _
        Private _GroupBox9 As GroupBox

        ' Token: 0x04000874 RID: 2164
        <AccessedThroughProperty("Label55")> _
        Private _Label55 As Label

        ' Token: 0x04000875 RID: 2165
        <AccessedThroughProperty("trkbarAlignment")> _
        Private _trkbarAlignment As TrackBar

        ' Token: 0x04000876 RID: 2166
        <AccessedThroughProperty("tbConversation")> _
        Private _tbConversation As TextBox

        ' Token: 0x04000877 RID: 2167
        <AccessedThroughProperty("Label56")> _
        Private _Label56 As Label

        ' Token: 0x04000878 RID: 2168
        <AccessedThroughProperty("nudAlignment")> _
        Private _nudAlignment As NumericUpDown

        ' Token: 0x04000879 RID: 2169
        <AccessedThroughProperty("Label57")> _
        Private _Label57 As Label

        ' Token: 0x0400087A RID: 2170
        <AccessedThroughProperty("chklbFeats")> _
        Private _chklbFeats As CheckedListBox

        ' Token: 0x0400087B RID: 2171
        <AccessedThroughProperty("GroupBox3")> _
        Private _GroupBox3 As GroupBox

        ' Token: 0x0400087C RID: 2172
        <AccessedThroughProperty("tbFeatSummary")> _
        Private _tbFeatSummary As TextBox

        ' Token: 0x0400087D RID: 2173
        <AccessedThroughProperty("GroupBox10")> _
        Private _GroupBox10 As GroupBox

        ' Token: 0x0400087E RID: 2174
        <AccessedThroughProperty("nudCurrentHP")> _
        Private _nudCurrentHP As NumericUpDown

        ' Token: 0x0400087F RID: 2175
        <AccessedThroughProperty("btnWriteFile")> _
        Private _btnWriteFile As Button

        ' Token: 0x04000880 RID: 2176
        <AccessedThroughProperty("tpComments")> _
        Private _tpComments As TabPage

        ' Token: 0x04000881 RID: 2177
        <AccessedThroughProperty("tpSpecialAbilities")> _
        Private _tpSpecialAbilities As TabPage

        ' Token: 0x04000882 RID: 2178
        <AccessedThroughProperty("toForcePowers")> _
        Private _toForcePowers As TabPage

        ' Token: 0x04000883 RID: 2179
        <AccessedThroughProperty("tpFeats")> _
        Private _tpFeats As TabPage

        ' Token: 0x04000884 RID: 2180
        <AccessedThroughProperty("tpAdvanced")> _
        Private _tpAdvanced As TabPage

        ' Token: 0x04000885 RID: 2181
        <AccessedThroughProperty("nudMaxHP")> _
        Private _nudMaxHP As NumericUpDown

        ' Token: 0x04000886 RID: 2182
        <AccessedThroughProperty("GroupBox11")> _
        Private _GroupBox11 As GroupBox

        ' Token: 0x04000887 RID: 2183
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox

        ' Token: 0x04000888 RID: 2184
        <AccessedThroughProperty("chkbDisarmable")> _
        Private _chkbDisarmable As CheckBox

        ' Token: 0x04000889 RID: 2185
        <AccessedThroughProperty("tpScripts")> _
        Private _tpScripts As TabPage

        ' Token: 0x0400088A RID: 2186
        <AccessedThroughProperty("tpSkills")> _
        Private _tpSkills As TabPage

        ' Token: 0x0400088B RID: 2187
        <AccessedThroughProperty("chkbPlot")> _
        Private _chkbPlot As CheckBox

        ' Token: 0x0400088C RID: 2188
        <AccessedThroughProperty("chkbNoPermDeath")> _
        Private _chkbNoPermDeath As CheckBox

        ' Token: 0x0400088D RID: 2189
        <AccessedThroughProperty("GroupBox12")> _
        Private _GroupBox12 As GroupBox

        ' Token: 0x0400088E RID: 2190
        <AccessedThroughProperty("GroupBox13")> _
        Private _GroupBox13 As GroupBox

        ' Token: 0x0400088F RID: 2191
        <AccessedThroughProperty("GroupBox14")> _
        Private _GroupBox14 As GroupBox

        ' Token: 0x04000890 RID: 2192
        <AccessedThroughProperty("tbChallengeRating")> _
        Private _tbChallengeRating As TextBox

        ' Token: 0x04000891 RID: 2193
        <AccessedThroughProperty("GroupBox15")> _
        Private _GroupBox15 As GroupBox

        ' Token: 0x04000892 RID: 2194
        <AccessedThroughProperty("cmbxPerceptionRange")> _
        Private _cmbxPerceptionRange As ComboBox

        ' Token: 0x04000893 RID: 2195
        <AccessedThroughProperty("tpClasses")> _
        Private _tpClasses As TabPage

        ' Token: 0x04000894 RID: 2196
        <AccessedThroughProperty("tpStatistics")> _
        Private _tpStatistics As TabPage

        ' Token: 0x04000895 RID: 2197
        <AccessedThroughProperty("tbDeity")> _
        Private _tbDeity As TextBox

        ' Token: 0x04000896 RID: 2198
        <AccessedThroughProperty("GroupBox16")> _
        Private _GroupBox16 As GroupBox

        ' Token: 0x04000897 RID: 2199
        <AccessedThroughProperty("Label26")> _
        Private _Label26 As Label

        ' Token: 0x04000898 RID: 2200
        <AccessedThroughProperty("GroupBox17")> _
        Private _GroupBox17 As GroupBox

        ' Token: 0x04000899 RID: 2201
        <AccessedThroughProperty("chklbForcePowers")> _
        Private _chklbForcePowers As CheckedListBox

        ' Token: 0x0400089A RID: 2202
        <AccessedThroughProperty("nudForcePoints")> _
        Private _nudForcePoints As NumericUpDown

        ' Token: 0x0400089B RID: 2203
        <AccessedThroughProperty("Label27")> _
        Private _Label27 As Label

        ' Token: 0x0400089C RID: 2204
        <AccessedThroughProperty("nudCurrentForce")> _
        Private _nudCurrentForce As NumericUpDown

        ' Token: 0x0400089D RID: 2205
        <AccessedThroughProperty("tpBasic")> _
        Private _tpBasic As TabPage

        ' Token: 0x0400089E RID: 2206
        <AccessedThroughProperty("chklbSpecialAbilities")> _
        Private _chklbSpecialAbilities As CheckedListBox

        ' Token: 0x0400089F RID: 2207
        <AccessedThroughProperty("GroupBox18")> _
        Private _GroupBox18 As GroupBox

        ' Token: 0x040008A0 RID: 2208
        <AccessedThroughProperty("Label28")> _
        Private _Label28 As Label

        ' Token: 0x040008A1 RID: 2209
        <AccessedThroughProperty("tbTemplateResRef")> _
        Private _tbTemplateResRef As TextBox

        ' Token: 0x040008A2 RID: 2210
        <AccessedThroughProperty("cmbxTreasureModel")> _
        Private _cmbxTreasureModel As ComboBox

        ' Token: 0x040008A3 RID: 2211
        <AccessedThroughProperty("Label29")> _
        Private _Label29 As Label

        ' Token: 0x040008A4 RID: 2212
        <AccessedThroughProperty("cmbxSoundSet")> _
        Private _cmbxSoundSet As ComboBox

        ' Token: 0x040008A5 RID: 2213
        <AccessedThroughProperty("cmbxPortrait")> _
        Private _cmbxPortrait As ComboBox

        ' Token: 0x040008A6 RID: 2214
        <AccessedThroughProperty("cmbxSubrace")> _
        Private _cmbxSubrace As ComboBox

        ' Token: 0x040008A7 RID: 2215
        <AccessedThroughProperty("btnClearAllPowers")> _
        Private _btnClearAllPowers As Button

        ' Token: 0x040008A8 RID: 2216
        <AccessedThroughProperty("btnSelectAllPowers")> _
        Private _btnSelectAllPowers As Button

        ' Token: 0x040008A9 RID: 2217
        <AccessedThroughProperty("btnInventory")> _
        Private _btnInventory As Button

        ' Token: 0x040008AA RID: 2218
        <AccessedThroughProperty("GroupBox19")> _
        Private _GroupBox19 As GroupBox

        ' Token: 0x040008AB RID: 2219
        <AccessedThroughProperty("tbForcePowerSummary")> _
        Private _tbForcePowerSummary As TextBox

        ' Token: 0x040008AC RID: 2220
        <AccessedThroughProperty("GroupBox20")> _
        Private _GroupBox20 As GroupBox

        ' Token: 0x040008AD RID: 2221
        <AccessedThroughProperty("cmbxBodyBag")> _
        Private _cmbxBodyBag As ComboBox

        ' Token: 0x040008AE RID: 2222
        <AccessedThroughProperty("chkbIsHologram")> _
        Private _chkbIsHologram As CheckBox

        ' Token: 0x040008AF RID: 2223
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040008B0 RID: 2224
        <AccessedThroughProperty("chkbNotReorienting")> _
        Private _chkbNotReorienting As CheckBox

        ' Token: 0x040008B1 RID: 2225
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x040008B2 RID: 2226
        <AccessedThroughProperty("chkbIgnoreCrePath")> _
        Private _chkbIgnoreCrePath As CheckBox

        ' Token: 0x040008B3 RID: 2227
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x040008B4 RID: 2228
        <AccessedThroughProperty("nudMultiplierSet")> _
        Private _nudMultiplierSet As NumericUpDown

        ' Token: 0x040008B5 RID: 2229
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x040008B6 RID: 2230
        <AccessedThroughProperty("Label30")> _
        Private _Label30 As Label

        ' Token: 0x040008B7 RID: 2231
        <AccessedThroughProperty("lblMultiplierSet")> _
        Private _lblMultiplierSet As Label

        ' Token: 0x040008B8 RID: 2232
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x040008B9 RID: 2233
        <AccessedThroughProperty("lblBlindSpot")> _
        Private _lblBlindSpot As Label

        ' Token: 0x040008BA RID: 2234
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x040008BB RID: 2235
        <AccessedThroughProperty("GroupBox2")> _
        Private _GroupBox2 As GroupBox

        ' Token: 0x040008BC RID: 2236
        <AccessedThroughProperty("nudBlindSpot")> _
        Private _nudBlindSpot As NumericUpDown

        ' Token: 0x040008BD RID: 2237
        <AccessedThroughProperty("chkbMin1HP")> _
        Private _chkbMin1HP As CheckBox

        ' Token: 0x040008BE RID: 2238
        <AccessedThroughProperty("cmbxGender")> _
        Private _cmbxGender As ComboBox

        ' Token: 0x040008BF RID: 2239
        <AccessedThroughProperty("cmbxFaction")> _
        Private _cmbxFaction As ComboBox

        ' Token: 0x040008C0 RID: 2240
        <AccessedThroughProperty("chkbIsPC")> _
        Private _chkbIsPC As CheckBox

        ' Token: 0x040008C1 RID: 2241
        <AccessedThroughProperty("Label32")> _
        Private _Label32 As Label

        ' Token: 0x040008C2 RID: 2242
        <AccessedThroughProperty("btnEditOnEndDialogu")> _
        Private _btnEditOnEndDialogu As Button

        ' Token: 0x040008C3 RID: 2243
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x040008C4 RID: 2244
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x040008C5 RID: 2245
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x040008C6 RID: 2246
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040008C7 RID: 2247
        <AccessedThroughProperty("cmbxMovementRate")> _
        Private _cmbxMovementRate As ComboBox

        ' Token: 0x040008C8 RID: 2248
        <AccessedThroughProperty("btnEditOnDialogue")> _
        Private _btnEditOnDialogue As Button

        ' Token: 0x040008C9 RID: 2249
        <AccessedThroughProperty("Label33")> _
        Private _Label33 As Label

        ' Token: 0x040008CA RID: 2250
        <AccessedThroughProperty("btnEditOnUserDefine")> _
        Private _btnEditOnUserDefine As Button

        ' Token: 0x040008CB RID: 2251
        <AccessedThroughProperty("Label48")> _
        Private _Label48 As Label

        ' Token: 0x040008CC RID: 2252
        <AccessedThroughProperty("btnEditOnHeartbeat")> _
        Private _btnEditOnHeartbeat As Button

        ' Token: 0x040008CD RID: 2253
        <AccessedThroughProperty("btnEditOnDisturbed")> _
        Private _btnEditOnDisturbed As Button

        ' Token: 0x040008CE RID: 2254
        <AccessedThroughProperty("btnEditOnDamaged")> _
        Private _btnEditOnDamaged As Button

        ' Token: 0x040008CF RID: 2255
        <AccessedThroughProperty("Label34")> _
        Private _Label34 As Label

        ' Token: 0x040008D0 RID: 2256
        <AccessedThroughProperty("btnEditOnAttacked")> _
        Private _btnEditOnAttacked As Button

        ' Token: 0x040008D1 RID: 2257
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x040008D2 RID: 2258
        <AccessedThroughProperty("btnEditOnNotice")> _
        Private _btnEditOnNotice As Button

        ' Token: 0x040008D3 RID: 2259
        <AccessedThroughProperty("btnEditOnSpellAt")> _
        Private _btnEditOnSpellAt As Button

        ' Token: 0x040008D4 RID: 2260
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040008D5 RID: 2261
        <AccessedThroughProperty("btnEditOnSpawn")> _
        Private _btnEditOnSpawn As Button

        ' Token: 0x040008D6 RID: 2262
        <AccessedThroughProperty("Label35")> _
        Private _Label35 As Label

        ' Token: 0x040008D7 RID: 2263
        <AccessedThroughProperty("btnEditOnDeath")> _
        Private _btnEditOnDeath As Button

        ' Token: 0x040008D8 RID: 2264
        <AccessedThroughProperty("Label36")> _
        Private _Label36 As Label

        ' Token: 0x040008D9 RID: 2265
        <AccessedThroughProperty("btnEditOnBlocked")> _
        Private _btnEditOnBlocked As Button

        ' Token: 0x040008DA RID: 2266
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x040008DB RID: 2267
        <AccessedThroughProperty("btnEditOnRested")> _
        Private _btnEditOnRested As Button

        ' Token: 0x040008DC RID: 2268
        <AccessedThroughProperty("btnEditOnEndRound")> _
        Private _btnEditOnEndRound As Button

        ' Token: 0x040008DD RID: 2269
        <AccessedThroughProperty("Label13")> _
        Private _Label13 As Label

        ' Token: 0x040008DE RID: 2270
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x040008DF RID: 2271
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x040008E0 RID: 2272
        <AccessedThroughProperty("Label31")> _
        Private _Label31 As Label

        ' Token: 0x040008E1 RID: 2273
        <AccessedThroughProperty("Label16")> _
        Private _Label16 As Label

        ' Token: 0x040008E2 RID: 2274
        <AccessedThroughProperty("Label37")> _
        Private _Label37 As Label

        ' Token: 0x040008E3 RID: 2275
        <AccessedThroughProperty("Label17")> _
        Private _Label17 As Label

        ' Token: 0x040008E4 RID: 2276
        <AccessedThroughProperty("Label18")> _
        Private _Label18 As Label

        ' Token: 0x040008E5 RID: 2277
        <AccessedThroughProperty("Label19")> _
        Private _Label19 As Label

        ' Token: 0x040008E6 RID: 2278
        <AccessedThroughProperty("Label20")> _
        Private _Label20 As Label

        ' Token: 0x040008E7 RID: 2279
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

        ' Token: 0x040008E8 RID: 2280
        <AccessedThroughProperty("Label21")> _
        Private _Label21 As Label

        ' Token: 0x040008E9 RID: 2281
        <AccessedThroughProperty("Label22")> _
        Private _Label22 As Label

        ' Token: 0x040008EA RID: 2282
        <AccessedThroughProperty("Label38")> _
        Private _Label38 As Label

        ' Token: 0x040008EB RID: 2283
        <AccessedThroughProperty("Label23")> _
        Private _Label23 As Label

        ' Token: 0x040008EC RID: 2284
        <AccessedThroughProperty("Label24")> _
        Private _Label24 As Label

        ' Token: 0x040008ED RID: 2285
        <AccessedThroughProperty("Label39")> _
        Private _Label39 As Label

        ' Token: 0x040008EE RID: 2286
        <AccessedThroughProperty("Label25")> _
        Private _Label25 As Label

        ' Token: 0x040008EF RID: 2287
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x040008F1 RID: 2289
        Public UTC As clsUTC

        ' Token: 0x040008F2 RID: 2290
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x040008F3 RID: 2291
        Private ComboBoxSettingError As Boolean

        ' Token: 0x040008F4 RID: 2292
        Private m_bSaveGameMode As Boolean

        ' Token: 0x040008F5 RID: 2293
        Private g_ForcePowerList As ArrayList
    End Class
End Namespace
