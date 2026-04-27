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
	' Token: 0x02000084 RID: 132
	Public Partial Class frmUTT_Editor
		Inherits frmParent

		' Token: 0x06001646 RID: 5702 RVA: 0x002C614C File Offset: 0x002C514C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTT_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTT_Editor_Closing
			Me.ComboBoxSettingError = False
			Me.m_bSaveGameMode = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000869 RID: 2153
		' (get) Token: 0x06001649 RID: 5705 RVA: 0x002C61BC File Offset: 0x002C51BC
		' (set) Token: 0x06001648 RID: 5704 RVA: 0x002C61D0 File Offset: 0x002C51D0
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

        ' Token: 0x1700086A RID: 2154
        ' (get) Token: 0x0600164B RID: 5707 RVA: 0x002C61EC File Offset: 0x002C51EC
        ' (set) Token: 0x0600164A RID: 5706 RVA: 0x002C6200 File Offset: 0x002C5200
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

        ' Token: 0x1700086B RID: 2155
        ' (get) Token: 0x0600164D RID: 5709 RVA: 0x002C621C File Offset: 0x002C521C
        ' (set) Token: 0x0600164C RID: 5708 RVA: 0x002C6230 File Offset: 0x002C5230
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

        ' Token: 0x1700086C RID: 2156
        ' (get) Token: 0x0600164F RID: 5711 RVA: 0x002C624C File Offset: 0x002C524C
        ' (set) Token: 0x0600164E RID: 5710 RVA: 0x002C6260 File Offset: 0x002C5260
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

        ' Token: 0x1700086D RID: 2157
        ' (get) Token: 0x06001651 RID: 5713 RVA: 0x002C6298 File Offset: 0x002C5298
        ' (set) Token: 0x06001650 RID: 5712 RVA: 0x002C627C File Offset: 0x002C527C
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

        ' Token: 0x1700086E RID: 2158
        ' (get) Token: 0x06001653 RID: 5715 RVA: 0x002C62AC File Offset: 0x002C52AC
        ' (set) Token: 0x06001652 RID: 5714 RVA: 0x002C62C0 File Offset: 0x002C52C0
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

        ' Token: 0x1700086F RID: 2159
        ' (get) Token: 0x06001654 RID: 5716 RVA: 0x002C62DC File Offset: 0x002C52DC
        ' (set) Token: 0x06001655 RID: 5717 RVA: 0x002C62F0 File Offset: 0x002C52F0
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

        ' Token: 0x17000870 RID: 2160
        ' (get) Token: 0x06001656 RID: 5718 RVA: 0x002C630C File Offset: 0x002C530C
        ' (set) Token: 0x06001657 RID: 5719 RVA: 0x002C6320 File Offset: 0x002C5320
        Friend Overridable Property tbOnDisarm() As TextBox
            Get
                Return Me._tbOnDisarm
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnDisarm IsNot Nothing Then
                End If
                Me._tbOnDisarm = value
                If Me._tbOnDisarm IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000871 RID: 2161
        ' (get) Token: 0x06001659 RID: 5721 RVA: 0x002C633C File Offset: 0x002C533C
        ' (set) Token: 0x06001658 RID: 5720 RVA: 0x002C6350 File Offset: 0x002C5350
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

        ' Token: 0x17000872 RID: 2162
        ' (get) Token: 0x0600165B RID: 5723 RVA: 0x002C6388 File Offset: 0x002C5388
        ' (set) Token: 0x0600165A RID: 5722 RVA: 0x002C636C File Offset: 0x002C536C
        Friend Overridable Property tbOnTrapTriggered() As TextBox
            Get
                Return Me._tbOnTrapTriggered
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnTrapTriggered IsNot Nothing Then
                End If
                Me._tbOnTrapTriggered = value
                If Me._tbOnTrapTriggered IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000873 RID: 2163
        ' (get) Token: 0x0600165D RID: 5725 RVA: 0x002C639C File Offset: 0x002C539C
        ' (set) Token: 0x0600165C RID: 5724 RVA: 0x002C63B0 File Offset: 0x002C53B0
        Friend Overridable Property tbOnClick() As TextBox
            Get
                Return Me._tbOnClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnClick IsNot Nothing Then
                End If
                Me._tbOnClick = value
                If Me._tbOnClick IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000874 RID: 2164
        ' (get) Token: 0x0600165F RID: 5727 RVA: 0x002C63CC File Offset: 0x002C53CC
        ' (set) Token: 0x0600165E RID: 5726 RVA: 0x002C63E0 File Offset: 0x002C53E0
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

        ' Token: 0x17000875 RID: 2165
        ' (get) Token: 0x06001660 RID: 5728 RVA: 0x002C63FC File Offset: 0x002C53FC
        ' (set) Token: 0x06001661 RID: 5729 RVA: 0x002C6410 File Offset: 0x002C5410
        Friend Overridable Property tbScriptUserDefine() As TextBox
            Get
                Return Me._tbScriptUserDefine
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbScriptUserDefine IsNot Nothing Then
                End If
                Me._tbScriptUserDefine = value
                If Me._tbScriptUserDefine IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000876 RID: 2166
        ' (get) Token: 0x06001663 RID: 5731 RVA: 0x002C642C File Offset: 0x002C542C
        ' (set) Token: 0x06001662 RID: 5730 RVA: 0x002C6440 File Offset: 0x002C5440
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

        ' Token: 0x17000877 RID: 2167
        ' (get) Token: 0x06001665 RID: 5733 RVA: 0x002C645C File Offset: 0x002C545C
        ' (set) Token: 0x06001664 RID: 5732 RVA: 0x002C6470 File Offset: 0x002C5470
        Friend Overridable Property TabPageComments() As TabPage
            Get
                Return Me._TabPageComments
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPageComments IsNot Nothing Then
                End If
                Me._TabPageComments = value
                If Me._TabPageComments IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000878 RID: 2168
        ' (get) Token: 0x06001667 RID: 5735 RVA: 0x002C648C File Offset: 0x002C548C
        ' (set) Token: 0x06001666 RID: 5734 RVA: 0x002C64A0 File Offset: 0x002C54A0
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

        ' Token: 0x17000879 RID: 2169
        ' (get) Token: 0x06001668 RID: 5736 RVA: 0x002C64BC File Offset: 0x002C54BC
        ' (set) Token: 0x06001669 RID: 5737 RVA: 0x002C64D0 File Offset: 0x002C54D0
        Friend Overridable Property tbScriptHeartbeat() As TextBox
            Get
                Return Me._tbScriptHeartbeat
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbScriptHeartbeat IsNot Nothing Then
                End If
                Me._tbScriptHeartbeat = value
                If Me._tbScriptHeartbeat IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700087A RID: 2170
        ' (get) Token: 0x0600166B RID: 5739 RVA: 0x002C6508 File Offset: 0x002C5508
        ' (set) Token: 0x0600166A RID: 5738 RVA: 0x002C64EC File Offset: 0x002C54EC
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

        ' Token: 0x1700087B RID: 2171
        ' (get) Token: 0x0600166D RID: 5741 RVA: 0x002C651C File Offset: 0x002C551C
        ' (set) Token: 0x0600166C RID: 5740 RVA: 0x002C6530 File Offset: 0x002C5530
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

        ' Token: 0x1700087C RID: 2172
        ' (get) Token: 0x0600166E RID: 5742 RVA: 0x002C654C File Offset: 0x002C554C
        ' (set) Token: 0x0600166F RID: 5743 RVA: 0x002C6560 File Offset: 0x002C5560
        Friend Overridable Property tbScriptOnEnter() As TextBox
            Get
                Return Me._tbScriptOnEnter
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbScriptOnEnter IsNot Nothing Then
                End If
                Me._tbScriptOnEnter = value
                If Me._tbScriptOnEnter IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700087D RID: 2173
        ' (get) Token: 0x06001670 RID: 5744 RVA: 0x002C657C File Offset: 0x002C557C
        ' (set) Token: 0x06001671 RID: 5745 RVA: 0x002C6590 File Offset: 0x002C5590
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

        ' Token: 0x1700087E RID: 2174
        ' (get) Token: 0x06001672 RID: 5746 RVA: 0x002C65C8 File Offset: 0x002C55C8
        ' (set) Token: 0x06001673 RID: 5747 RVA: 0x002C65AC File Offset: 0x002C55AC
        Friend Overridable Property tbScriptOnExit() As TextBox
            Get
                Return Me._tbScriptOnExit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbScriptOnExit IsNot Nothing Then
                End If
                Me._tbScriptOnExit = value
                If Me._tbScriptOnExit IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700087F RID: 2175
        ' (get) Token: 0x06001675 RID: 5749 RVA: 0x002C65F8 File Offset: 0x002C55F8
        ' (set) Token: 0x06001674 RID: 5748 RVA: 0x002C65DC File Offset: 0x002C55DC
        Friend Overridable Property lblCloseLockDC() As Label
            Get
                Return Me._lblCloseLockDC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblCloseLockDC IsNot Nothing Then
                End If
                Me._lblCloseLockDC = value
                If Me._lblCloseLockDC IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000880 RID: 2176
        ' (get) Token: 0x06001677 RID: 5751 RVA: 0x002C660C File Offset: 0x002C560C
        ' (set) Token: 0x06001676 RID: 5750 RVA: 0x002C6620 File Offset: 0x002C5620
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

        ' Token: 0x17000881 RID: 2177
        ' (get) Token: 0x06001678 RID: 5752 RVA: 0x002C663C File Offset: 0x002C563C
        ' (set) Token: 0x06001679 RID: 5753 RVA: 0x002C6650 File Offset: 0x002C5650
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

        ' Token: 0x17000882 RID: 2178
        ' (get) Token: 0x0600167A RID: 5754 RVA: 0x002C666C File Offset: 0x002C566C
        ' (set) Token: 0x0600167B RID: 5755 RVA: 0x002C6680 File Offset: 0x002C5680
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

        ' Token: 0x17000883 RID: 2179
        ' (get) Token: 0x0600167C RID: 5756 RVA: 0x002C669C File Offset: 0x002C569C
        ' (set) Token: 0x0600167D RID: 5757 RVA: 0x002C66B0 File Offset: 0x002C56B0
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

        ' Token: 0x17000884 RID: 2180
        ' (get) Token: 0x0600167E RID: 5758 RVA: 0x002C66CC File Offset: 0x002C56CC
        ' (set) Token: 0x0600167F RID: 5759 RVA: 0x002C66E0 File Offset: 0x002C56E0
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

        ' Token: 0x17000885 RID: 2181
        ' (get) Token: 0x06001680 RID: 5760 RVA: 0x002C66FC File Offset: 0x002C56FC
        ' (set) Token: 0x06001681 RID: 5761 RVA: 0x002C6710 File Offset: 0x002C5710
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

        ' Token: 0x17000886 RID: 2182
        ' (get) Token: 0x06001682 RID: 5762 RVA: 0x002C67B8 File Offset: 0x002C57B8
        ' (set) Token: 0x06001683 RID: 5763 RVA: 0x002C6764 File Offset: 0x002C5764
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

        ' Token: 0x17000887 RID: 2183
        ' (get) Token: 0x06001684 RID: 5764 RVA: 0x002C67CC File Offset: 0x002C57CC
        ' (set) Token: 0x06001685 RID: 5765 RVA: 0x002C67E0 File Offset: 0x002C57E0
        Friend Overridable Property TabPageBasic() As TabPage
            Get
                Return Me._TabPageBasic
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPageBasic IsNot Nothing Then
                End If
                Me._TabPageBasic = value
                If Me._TabPageBasic IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000888 RID: 2184
        ' (get) Token: 0x06001687 RID: 5767 RVA: 0x002C6818 File Offset: 0x002C5818
        ' (set) Token: 0x06001686 RID: 5766 RVA: 0x002C67FC File Offset: 0x002C57FC
        Friend Overridable Property TabPageScripts() As TabPage
            Get
                Return Me._TabPageScripts
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPageScripts IsNot Nothing Then
                End If
                Me._TabPageScripts = value
                If Me._TabPageScripts IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000889 RID: 2185
        ' (get) Token: 0x06001689 RID: 5769 RVA: 0x002C682C File Offset: 0x002C582C
        ' (set) Token: 0x06001688 RID: 5768 RVA: 0x002C6840 File Offset: 0x002C5840
        Friend Overridable Property TabPageTrap() As TabPage
            Get
                Return Me._TabPageTrap
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPageTrap IsNot Nothing Then
                End If
                Me._TabPageTrap = value
                If Me._TabPageTrap IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700088A RID: 2186
        ' (get) Token: 0x0600168B RID: 5771 RVA: 0x002C685C File Offset: 0x002C585C
        ' (set) Token: 0x0600168A RID: 5770 RVA: 0x002C6870 File Offset: 0x002C5870
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

        ' Token: 0x1700088B RID: 2187
        ' (get) Token: 0x0600168D RID: 5773 RVA: 0x002C688C File Offset: 0x002C588C
        ' (set) Token: 0x0600168C RID: 5772 RVA: 0x002C68A0 File Offset: 0x002C58A0
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

        ' Token: 0x1700088C RID: 2188
        ' (get) Token: 0x0600168E RID: 5774 RVA: 0x002C68BC File Offset: 0x002C58BC
        ' (set) Token: 0x0600168F RID: 5775 RVA: 0x002C68D0 File Offset: 0x002C58D0
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

        ' Token: 0x1700088D RID: 2189
        ' (get) Token: 0x06001690 RID: 5776 RVA: 0x002C68EC File Offset: 0x002C58EC
        ' (set) Token: 0x06001691 RID: 5777 RVA: 0x002C6900 File Offset: 0x002C5900
        Friend Overridable Property nudDisarmDC() As NumericUpDown
            Get
                Return Me._nudDisarmDC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudDisarmDC IsNot Nothing Then
                End If
                Me._nudDisarmDC = value
                If Me._nudDisarmDC IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700088E RID: 2190
        ' (get) Token: 0x06001692 RID: 5778 RVA: 0x002C691C File Offset: 0x002C591C
        ' (set) Token: 0x06001693 RID: 5779 RVA: 0x002C6930 File Offset: 0x002C5930
        Friend Overridable Property nudTrapDetectDC() As NumericUpDown
            Get
                Return Me._nudTrapDetectDC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudTrapDetectDC IsNot Nothing Then
                End If
                Me._nudTrapDetectDC = value
                If Me._nudTrapDetectDC IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700088F RID: 2191
        ' (get) Token: 0x06001695 RID: 5781 RVA: 0x002C694C File Offset: 0x002C594C
        ' (set) Token: 0x06001694 RID: 5780 RVA: 0x002C6960 File Offset: 0x002C5960
        Friend Overridable Property lblTrapDetectable() As Label
            Get
                Return Me._lblTrapDetectable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblTrapDetectable IsNot Nothing Then
                End If
                Me._lblTrapDetectable = value
                If Me._lblTrapDetectable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000890 RID: 2192
        ' (get) Token: 0x06001696 RID: 5782 RVA: 0x002C6998 File Offset: 0x002C5998
        ' (set) Token: 0x06001697 RID: 5783 RVA: 0x002C697C File Offset: 0x002C597C
        Friend Overridable Property nudTrapType() As NumericUpDown
            Get
                Return Me._nudTrapType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudTrapType IsNot Nothing Then
                End If
                Me._nudTrapType = value
                If Me._nudTrapType IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000891 RID: 2193
        ' (get) Token: 0x06001699 RID: 5785 RVA: 0x002C69AC File Offset: 0x002C59AC
        ' (set) Token: 0x06001698 RID: 5784 RVA: 0x002C69C0 File Offset: 0x002C59C0
        Friend Overridable Property chkbTrapDetectable() As CheckBox
            Get
                Return Me._chkbTrapDetectable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbTrapDetectable IsNot Nothing Then
                End If
                Me._chkbTrapDetectable = value
                If Me._chkbTrapDetectable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000892 RID: 2194
        ' (get) Token: 0x0600169B RID: 5787 RVA: 0x002C69DC File Offset: 0x002C59DC
        ' (set) Token: 0x0600169A RID: 5786 RVA: 0x002C69F0 File Offset: 0x002C59F0
        Friend Overridable Property chkbTrapDisarmable() As CheckBox
            Get
                Return Me._chkbTrapDisarmable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbTrapDisarmable IsNot Nothing Then
                End If
                Me._chkbTrapDisarmable = value
                If Me._chkbTrapDisarmable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000893 RID: 2195
        ' (get) Token: 0x0600169D RID: 5789 RVA: 0x002C6A0C File Offset: 0x002C5A0C
        ' (set) Token: 0x0600169C RID: 5788 RVA: 0x002C6A20 File Offset: 0x002C5A20
        Friend Overridable Property tbKeyName() As TextBox
            Get
                Return Me._tbKeyName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbKeyName IsNot Nothing Then
                End If
                Me._tbKeyName = value
                If Me._tbKeyName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000894 RID: 2196
        ' (get) Token: 0x0600169F RID: 5791 RVA: 0x002C6A3C File Offset: 0x002C5A3C
        ' (set) Token: 0x0600169E RID: 5790 RVA: 0x002C6A50 File Offset: 0x002C5A50
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

        ' Token: 0x17000895 RID: 2197
        ' (get) Token: 0x060016A0 RID: 5792 RVA: 0x002C6AC0 File Offset: 0x002C5AC0
        ' (set) Token: 0x060016A1 RID: 5793 RVA: 0x002C6A6C File Offset: 0x002C5A6C
        Friend Overridable Property btnSetNameLang() As Button
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

        ' Token: 0x17000896 RID: 2198
        ' (get) Token: 0x060016A2 RID: 5794 RVA: 0x002C6AD4 File Offset: 0x002C5AD4
        ' (set) Token: 0x060016A3 RID: 5795 RVA: 0x002C6AE8 File Offset: 0x002C5AE8
        Friend Overridable Property chkbAutoRemoveKey() As CheckBox
            Get
                Return Me._chkbAutoRemoveKey
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbAutoRemoveKey IsNot Nothing Then
                End If
                Me._chkbAutoRemoveKey = value
                If Me._chkbAutoRemoveKey IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000897 RID: 2199
        ' (get) Token: 0x060016A4 RID: 5796 RVA: 0x002C6B04 File Offset: 0x002C5B04
        ' (set) Token: 0x060016A5 RID: 5797 RVA: 0x002C6B18 File Offset: 0x002C5B18
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

        ' Token: 0x17000898 RID: 2200
        ' (get) Token: 0x060016A7 RID: 5799 RVA: 0x002C6B34 File Offset: 0x002C5B34
        ' (set) Token: 0x060016A6 RID: 5798 RVA: 0x002C6B48 File Offset: 0x002C5B48
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

        ' Token: 0x17000899 RID: 2201
        ' (get) Token: 0x060016A9 RID: 5801 RVA: 0x002C6B9C File Offset: 0x002C5B9C
        ' (set) Token: 0x060016A8 RID: 5800 RVA: 0x002C6BB0 File Offset: 0x002C5BB0
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

        ' Token: 0x1700089A RID: 2202
        ' (get) Token: 0x060016AA RID: 5802 RVA: 0x002C6BE8 File Offset: 0x002C5BE8
        ' (set) Token: 0x060016AB RID: 5803 RVA: 0x002C6BCC File Offset: 0x002C5BCC
        Friend Overridable Property tbCursor() As TextBox
            Get
                Return Me._tbCursor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCursor IsNot Nothing Then
                End If
                Me._tbCursor = value
                If Me._tbCursor IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700089B RID: 2203
        ' (get) Token: 0x060016AC RID: 5804 RVA: 0x002C6BFC File Offset: 0x002C5BFC
        ' (set) Token: 0x060016AD RID: 5805 RVA: 0x002C6C10 File Offset: 0x002C5C10
        Friend Overridable Property chkbTrapFlag() As CheckBox
            Get
                Return Me._chkbTrapFlag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbTrapFlag IsNot Nothing Then
                End If
                Me._chkbTrapFlag = value
                If Me._chkbTrapFlag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700089C RID: 2204
        ' (get) Token: 0x060016AE RID: 5806 RVA: 0x002C6C2C File Offset: 0x002C5C2C
        ' (set) Token: 0x060016AF RID: 5807 RVA: 0x002C6C40 File Offset: 0x002C5C40
        Friend Overridable Property chkbTrapOneShot() As CheckBox
            Get
                Return Me._chkbTrapOneShot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbTrapOneShot IsNot Nothing Then
                End If
                Me._chkbTrapOneShot = value
                If Me._chkbTrapOneShot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700089D RID: 2205
        ' (get) Token: 0x060016B0 RID: 5808 RVA: 0x002C6C5C File Offset: 0x002C5C5C
        ' (set) Token: 0x060016B1 RID: 5809 RVA: 0x002C6C70 File Offset: 0x002C5C70
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

        ' Token: 0x1700089E RID: 2206
        ' (get) Token: 0x060016B2 RID: 5810 RVA: 0x002C6C8C File Offset: 0x002C5C8C
        ' (set) Token: 0x060016B3 RID: 5811 RVA: 0x002C6CA0 File Offset: 0x002C5CA0
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

        ' Token: 0x1700089F RID: 2207
        ' (get) Token: 0x060016B4 RID: 5812 RVA: 0x002C6D10 File Offset: 0x002C5D10
        ' (set) Token: 0x060016B5 RID: 5813 RVA: 0x002C6CBC File Offset: 0x002C5CBC
        Friend Overridable Property cmbxType() As ComboBox
            Get
                Return Me._cmbxType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxType IsNot Nothing Then
                    RemoveHandler Me._cmbxType.SelectedIndexChanged, AddressOf Me.cmbxType_SelectedIndexChanged
                End If
                Me._cmbxType = value
                If Me._cmbxType IsNot Nothing Then
                    AddHandler Me._cmbxType.SelectedIndexChanged, AddressOf Me.cmbxType_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x170008A0 RID: 2208
        ' (get) Token: 0x060016B6 RID: 5814 RVA: 0x002C6D78 File Offset: 0x002C5D78
        ' (set) Token: 0x060016B7 RID: 5815 RVA: 0x002C6D24 File Offset: 0x002C5D24
        Friend Overridable Property btnEditScriptOnEnter() As Button
            Get
                Return Me._btnEditScriptOnEnter
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditScriptOnEnter IsNot Nothing Then
                    RemoveHandler Me._btnEditScriptOnEnter.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditScriptOnEnter = value
                If Me._btnEditScriptOnEnter IsNot Nothing Then
                    AddHandler Me._btnEditScriptOnEnter.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170008A1 RID: 2209
        ' (get) Token: 0x060016B8 RID: 5816 RVA: 0x002C6D8C File Offset: 0x002C5D8C
        ' (set) Token: 0x060016B9 RID: 5817 RVA: 0x002C6DA0 File Offset: 0x002C5DA0
        Friend Overridable Property btnEditScriptOnExit() As Button
            Get
                Return Me._btnEditScriptOnExit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditScriptOnExit IsNot Nothing Then
                    RemoveHandler Me._btnEditScriptOnExit.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditScriptOnExit = value
                If Me._btnEditScriptOnExit IsNot Nothing Then
                    AddHandler Me._btnEditScriptOnExit.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170008A2 RID: 2210
        ' (get) Token: 0x060016BA RID: 5818 RVA: 0x002C6DF4 File Offset: 0x002C5DF4
        ' (set) Token: 0x060016BB RID: 5819 RVA: 0x002C6E08 File Offset: 0x002C5E08
        Friend Overridable Property btnEditScriptUserDefine() As Button
            Get
                Return Me._btnEditScriptUserDefine
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditScriptUserDefine IsNot Nothing Then
                    RemoveHandler Me._btnEditScriptUserDefine.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditScriptUserDefine = value
                If Me._btnEditScriptUserDefine IsNot Nothing Then
                    AddHandler Me._btnEditScriptUserDefine.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170008A3 RID: 2211
        ' (get) Token: 0x060016BD RID: 5821 RVA: 0x002C6E5C File Offset: 0x002C5E5C
        ' (set) Token: 0x060016BC RID: 5820 RVA: 0x002C6E70 File Offset: 0x002C5E70
        Friend Overridable Property btnEditScriptHeartbeat() As Button
            Get
                Return Me._btnEditScriptHeartbeat
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditScriptHeartbeat IsNot Nothing Then
                    RemoveHandler Me._btnEditScriptHeartbeat.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditScriptHeartbeat = value
                If Me._btnEditScriptHeartbeat IsNot Nothing Then
                    AddHandler Me._btnEditScriptHeartbeat.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170008A4 RID: 2212
        ' (get) Token: 0x060016BF RID: 5823 RVA: 0x002C6F18 File Offset: 0x002C5F18
        ' (set) Token: 0x060016BE RID: 5822 RVA: 0x002C6EC4 File Offset: 0x002C5EC4
        Friend Overridable Property btnEditOnTrapTriggered() As Button
            Get
                Return Me._btnEditOnTrapTriggered
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnTrapTriggered IsNot Nothing Then
                    RemoveHandler Me._btnEditOnTrapTriggered.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnTrapTriggered = value
                If Me._btnEditOnTrapTriggered IsNot Nothing Then
                    AddHandler Me._btnEditOnTrapTriggered.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170008A5 RID: 2213
        ' (get) Token: 0x060016C1 RID: 5825 RVA: 0x002C6F2C File Offset: 0x002C5F2C
        ' (set) Token: 0x060016C0 RID: 5824 RVA: 0x002C6F40 File Offset: 0x002C5F40
        Friend Overridable Property btnEditOnDisarm() As Button
            Get
                Return Me._btnEditOnDisarm
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnDisarm IsNot Nothing Then
                    RemoveHandler Me._btnEditOnDisarm.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnDisarm = value
                If Me._btnEditOnDisarm IsNot Nothing Then
                    AddHandler Me._btnEditOnDisarm.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170008A6 RID: 2214
        ' (get) Token: 0x060016C3 RID: 5827 RVA: 0x002C6F94 File Offset: 0x002C5F94
        ' (set) Token: 0x060016C2 RID: 5826 RVA: 0x002C6FA8 File Offset: 0x002C5FA8
        Friend Overridable Property btnEditOnClick() As Button
            Get
                Return Me._btnEditOnClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnClick IsNot Nothing Then
                    RemoveHandler Me._btnEditOnClick.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnClick = value
                If Me._btnEditOnClick IsNot Nothing Then
                    AddHandler Me._btnEditOnClick.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x060016C5 RID: 5829 RVA: 0x002C925C File Offset: 0x002C825C
        Public Sub New(ByVal UTTClass As clsUTT, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Trigger Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            If KotorVerIndex = 1 Then
                Me.CustomizeForKotorII()
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTT = UTTClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
        End Sub

        ' Token: 0x060016C6 RID: 5830 RVA: 0x002C9318 File Offset: 0x002C8318
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x060016C7 RID: 5831 RVA: 0x002C9320 File Offset: 0x002C8320
        Public Sub Setup()
            Me.BuildComboBoxes()
            Me.UTT.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTT.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocalizedName")
            Me.UTT.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTT.SetTextBoxToNodeValue(Me.tbCursor, "Cursor")
            Me.UTT.SetTextBoxToNodeValue(Me.tbOnClick, "OnClick")
            Me.UTT.SetTextBoxToNodeValue(Me.tbOnDisarm, "OnDisarm")
            Me.UTT.SetTextBoxToNodeValue(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTT.SetTextBoxToNodeValue(Me.tbScriptHeartbeat, "ScriptHeartbeat")
            Me.UTT.SetTextBoxToNodeValue(Me.tbScriptOnEnter, "ScriptOnEnter")
            Me.UTT.SetTextBoxToNodeValue(Me.tbScriptOnExit, "ScriptOnExit")
            Me.UTT.SetTextBoxToNodeValue(Me.tbScriptUserDefine, "ScriptUserDefine")
            Me.chkbTrapDetectable.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("TrapDetectable"))
            Me.UTT.SetNumericUpDownToNodeValue(Me.nudTrapDetectDC, "TrapDetectDC", 0.0F)
            Me.chkbTrapDisarmable.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("TrapDisarmable"))
            Me.UTT.SetNumericUpDownToNodeValue(Me.nudDisarmDC, "DisarmDC", 0.0F)
            Me.chkbTrapFlag.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("TrapFlag"))
            Me.chkbTrapOneShot.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("TrapOneShot"))
            Me.UTT.SetNumericUpDownToNodeValue(Me.nudTrapType, "TrapType", 0.0F)
            Me.UTT.SetTextBoxToNodeValue(Me.tbKeyName, "KeyName")
            Me.chkbAutoRemoveKey.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("AutoRemoveKey"))
            Me.UTT.SetTextBoxToNodeValue(Me.tbComment, "Comment")
            If Me.ComboBoxSettingError Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
            If Me.KotorVersionIndex = 1 Then
                Me.CustomizeForKotorII()
            End If
        End Sub

        ' Token: 0x060016C8 RID: 5832 RVA: 0x002C956C File Offset: 0x002C856C
        Private Sub SetGFFNodeValues()
            Me.UTT.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTT.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocalizedName", Me.NameLang)
            Me.UTT.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTT.SetNodeValueFromComboBox(Me.cmbxFaction, "Faction")
            Me.UTT.SetNodeValue("Type", Me.cmbxType.SelectedIndex)
            Me.UTT.SetNodeValueFromTextBox(Me.tbCursor, "Cursor")
            Me.UTT.SetNodeValueFromTextBox(Me.tbOnClick, "OnClick")
            Me.UTT.SetNodeValueFromTextBox(Me.tbOnDisarm, "OnDisarm")
            Me.UTT.SetNodeValueFromTextBox(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTT.SetNodeValueFromTextBox(Me.tbScriptHeartbeat, "ScriptHeartbeat")
            Me.UTT.SetNodeValueFromTextBox(Me.tbScriptOnEnter, "ScriptOnEnter")
            Me.UTT.SetNodeValueFromTextBox(Me.tbScriptOnExit, "ScriptOnExit")
            Me.UTT.SetNodeValueFromTextBox(Me.tbScriptUserDefine, "ScriptUserDefine")
            If Me.cmbxType.SelectedIndex = 2 Then
                If Not Me.UTT.VerifyNodeExists("TrapDetectable") Then
                    Me.UTT.AddFieldToStruct("", "TrapDetectable", 0, 0)
                End If
                Me.UTT.SetNodeValue("TrapDetectable", Me.chkbTrapDetectable.Checked)
                If Not Me.UTT.VerifyNodeExists("TrapDetectDC") Then
                    Me.UTT.AddFieldToStruct("", "TrapDetectDC", 0, 0)
                End If
                Me.UTT.SetNodeValueFromNumericUpDown(Me.nudTrapDetectDC, "TrapDetectDC", 0.0F)
                If Not Me.UTT.VerifyNodeExists("TrapDisarmable") Then
                    Me.UTT.AddFieldToStruct("", "TrapDisarmable", 0, 0)
                End If
                Me.UTT.SetNodeValue("TrapDisarmable", Me.chkbTrapDisarmable.Checked)
                If Not Me.UTT.VerifyNodeExists("DisarmDC") Then
                    Me.UTT.AddFieldToStruct("", "DisarmDC", 0, 0)
                End If
                Me.UTT.SetNodeValueFromNumericUpDown(Me.nudDisarmDC, "DisarmDC", 0.0F)
                If Not Me.UTT.VerifyNodeExists("TrapFlag") Then
                    Me.UTT.AddFieldToStruct("", "TrapFlag", 0, 0)
                End If
                Me.UTT.SetNodeValue("TrapFlag", Me.chkbTrapFlag.Checked)
                If Not Me.UTT.VerifyNodeExists("TrapOneShot") Then
                    Me.UTT.AddFieldToStruct("", "TrapOneShot", 0, 0)
                End If
                Me.UTT.SetNodeValue("TrapOneShot", Me.chkbTrapOneShot.Checked)
                If Not Me.UTT.VerifyNodeExists("TrapType") Then
                    Me.UTT.AddFieldToStruct("", "TrapType", 0, 0)
                End If
                Me.UTT.SetNodeValueFromNumericUpDown(Me.nudTrapType, "TrapType", 0.0F)
                Me.UTT.SetNodeValueFromTextBox(Me.tbKeyName, "KeyName")
                Me.UTT.SetNodeValue("AutoRemoveKey", Me.chkbAutoRemoveKey.Checked)
            End If
            Me.UTT.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x060016C9 RID: 5833 RVA: 0x002C9918 File Offset: 0x002C8918
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

        ' Token: 0x060016CA RID: 5834 RVA: 0x002C9A54 File Offset: 0x002C8A54
        Private Sub BuildComboBoxes()
            Dim clsChitinKey As clsChitinKey = frmMain.KxChitinKey(Me.KotorVersionIndex)
            Me.FillComboBoxFrom2DA(Me.cmbxFaction, "label", "repute", clsChitinKey, Nothing)
            If Not Me.UTT.SyncComboBox(Me.cmbxFaction, "Faction") Then
                Me.ComboBoxSettingError = True
            End If
            Me.cmbxType.SelectedIndex = IntegerType.FromObject(Me.UTT.GetNodeValue("Type"))
        End Sub

        ' Token: 0x060016CB RID: 5835 RVA: 0x002C9AC4 File Offset: 0x002C8AC4
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

        ' Token: 0x060016CC RID: 5836 RVA: 0x002C9B64 File Offset: 0x002C8B64
        Private Sub CustomizeForKotorII()
            Me.nudTrapType.Maximum = 26D
        End Sub

        ' Token: 0x060016CD RID: 5837 RVA: 0x002C9B80 File Offset: 0x002C8B80
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utt", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTT.WriteFile(Me.m_EditingFilePath, "UTT")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x060016CE RID: 5838 RVA: 0x002C9C18 File Offset: 0x002C8C18
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x060016CF RID: 5839 RVA: 0x002C9C48 File Offset: 0x002C8C48
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbName.Text + ".utt"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTT.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x060016D0 RID: 5840 RVA: 0x002C9CBC File Offset: 0x002C8CBC
        Private Sub frmUTT_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060016D1 RID: 5841 RVA: 0x002C9CD0 File Offset: 0x002C8CD0
        Private Sub frmUTT_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060016D2 RID: 5842 RVA: 0x002C9CE4 File Offset: 0x002C8CE4
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Trigger Editor - " + Name
        End Sub

        ' Token: 0x060016D3 RID: 5843 RVA: 0x002C9CF8 File Offset: 0x002C8CF8
        Private Sub cmbxType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.TabPageTrap.Enabled = Me.cmbxType.SelectedIndex = 2
        End Sub

        ' Token: 0x060016D4 RID: 5844 RVA: 0x002C9D14 File Offset: 0x002C8D14
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x04000ACF RID: 2767
        <AccessedThroughProperty("nudTrapDetectDC")> _
        Private _nudTrapDetectDC As NumericUpDown

        ' Token: 0x04000AD0 RID: 2768
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000AD1 RID: 2769
        <AccessedThroughProperty("nudDisarmDC")> _
        Private _nudDisarmDC As NumericUpDown

        ' Token: 0x04000AD2 RID: 2770
        <AccessedThroughProperty("btnEditScriptHeartbeat")> _
        Private _btnEditScriptHeartbeat As Button

        ' Token: 0x04000AD3 RID: 2771
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x04000AD4 RID: 2772
        <AccessedThroughProperty("btnEditScriptUserDefine")> _
        Private _btnEditScriptUserDefine As Button

        ' Token: 0x04000AD5 RID: 2773
        <AccessedThroughProperty("chkbTrapDetectable")> _
        Private _chkbTrapDetectable As CheckBox

        ' Token: 0x04000AD6 RID: 2774
        <AccessedThroughProperty("chkbTrapDisarmable")> _
        Private _chkbTrapDisarmable As CheckBox

        ' Token: 0x04000AD7 RID: 2775
        <AccessedThroughProperty("Label39")> _
        Private _Label39 As Label

        ' Token: 0x04000AD8 RID: 2776
        <AccessedThroughProperty("TabPageTrap")> _
        Private _TabPageTrap As TabPage

        ' Token: 0x04000AD9 RID: 2777
        <AccessedThroughProperty("TabPageComments")> _
        Private _TabPageComments As TabPage

        ' Token: 0x04000ADA RID: 2778
        <AccessedThroughProperty("lblTrapDetectable")> _
        Private _lblTrapDetectable As Label

        ' Token: 0x04000ADB RID: 2779
        <AccessedThroughProperty("Label40")> _
        Private _Label40 As Label

        ' Token: 0x04000ADC RID: 2780
        <AccessedThroughProperty("nudTrapType")> _
        Private _nudTrapType As NumericUpDown

        ' Token: 0x04000ADD RID: 2781
        <AccessedThroughProperty("btnEditScriptOnExit")> _
        Private _btnEditScriptOnExit As Button

        ' Token: 0x04000ADE RID: 2782
        <AccessedThroughProperty("tbOnTrapTriggered")> _
        Private _tbOnTrapTriggered As TextBox

        ' Token: 0x04000ADF RID: 2783
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x04000AE0 RID: 2784
        <AccessedThroughProperty("btnEditScriptOnEnter")> _
        Private _btnEditScriptOnEnter As Button

        ' Token: 0x04000AE1 RID: 2785
        <AccessedThroughProperty("cmbxType")> _
        Private _cmbxType As ComboBox

        ' Token: 0x04000AE2 RID: 2786
        <AccessedThroughProperty("TabPageScripts")> _
        Private _TabPageScripts As TabPage

        ' Token: 0x04000AE3 RID: 2787
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x04000AE4 RID: 2788
        <AccessedThroughProperty("Label41")> _
        Private _Label41 As Label

        ' Token: 0x04000AE5 RID: 2789
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x04000AE6 RID: 2790
        <AccessedThroughProperty("chkbTrapFlag")> _
        Private _chkbTrapFlag As CheckBox

        ' Token: 0x04000AE7 RID: 2791
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As Button

        ' Token: 0x04000AE8 RID: 2792
        <AccessedThroughProperty("tbComment")> _
        Private _tbComment As TextBox

        ' Token: 0x04000AE9 RID: 2793
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x04000AEA RID: 2794
        <AccessedThroughProperty("tbName")> _
        Private _tbName As TextBox

        ' Token: 0x04000AEB RID: 2795
        <AccessedThroughProperty("tbKeyName")> _
        Private _tbKeyName As TextBox

        ' Token: 0x04000AEC RID: 2796
        <AccessedThroughProperty("cmbxFaction")> _
        Private _cmbxFaction As ComboBox

        ' Token: 0x04000AED RID: 2797
        <AccessedThroughProperty("tbCursor")> _
        Private _tbCursor As TextBox

        ' Token: 0x04000AEE RID: 2798
        <AccessedThroughProperty("TabPageBasic")> _
        Private _TabPageBasic As TabPage

        ' Token: 0x04000AEF RID: 2799
        <AccessedThroughProperty("tbScriptOnExit")> _
        Private _tbScriptOnExit As TextBox

        ' Token: 0x04000AF0 RID: 2800
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

        ' Token: 0x04000AF1 RID: 2801
        <AccessedThroughProperty("tbScriptOnEnter")> _
        Private _tbScriptOnEnter As TextBox

        ' Token: 0x04000AF2 RID: 2802
        <AccessedThroughProperty("tbScriptHeartbeat")> _
        Private _tbScriptHeartbeat As TextBox

        ' Token: 0x04000AF3 RID: 2803
        <AccessedThroughProperty("tbScriptUserDefine")> _
        Private _tbScriptUserDefine As TextBox

        ' Token: 0x04000AF4 RID: 2804
        <AccessedThroughProperty("chkbTrapOneShot")> _
        Private _chkbTrapOneShot As CheckBox

        ' Token: 0x04000AF5 RID: 2805
        <AccessedThroughProperty("chkbAutoRemoveKey")> _
        Private _chkbAutoRemoveKey As CheckBox

        ' Token: 0x04000AF6 RID: 2806
        <AccessedThroughProperty("btnEditOnClick")> _
        Private _btnEditOnClick As Button

        ' Token: 0x04000AF7 RID: 2807
        <AccessedThroughProperty("tbTemplateResRef")> _
        Private _tbTemplateResRef As TextBox

        ' Token: 0x04000AF8 RID: 2808
        <AccessedThroughProperty("tbOnDisarm")> _
        Private _tbOnDisarm As TextBox

        ' Token: 0x04000AF9 RID: 2809
        <AccessedThroughProperty("Label45")> _
        Private _Label45 As Label

        ' Token: 0x04000AFA RID: 2810
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000AFB RID: 2811
        <AccessedThroughProperty("btnSetNameLang")> _
        Private _btnSetNameLang As Button

        ' Token: 0x04000AFC RID: 2812
        <AccessedThroughProperty("tbOnClick")> _
        Private _tbOnClick As TextBox

        ' Token: 0x04000AFD RID: 2813
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000AFE RID: 2814
        <AccessedThroughProperty("btnEditOnDisarm")> _
        Private _btnEditOnDisarm As Button

        ' Token: 0x04000AFF RID: 2815
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x04000B00 RID: 2816
        <AccessedThroughProperty("btnEditOnTrapTriggered")> _
        Private _btnEditOnTrapTriggered As Button

        ' Token: 0x04000B01 RID: 2817
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x04000B02 RID: 2818
        <AccessedThroughProperty("Label35")> _
        Private _Label35 As Label

        ' Token: 0x04000B03 RID: 2819
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x04000B04 RID: 2820
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000B05 RID: 2821
        <AccessedThroughProperty("Label13")> _
        Private _Label13 As Label

        ' Token: 0x04000B06 RID: 2822
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000B07 RID: 2823
        <AccessedThroughProperty("Label57")> _
        Private _Label57 As Label

        ' Token: 0x04000B08 RID: 2824
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000B09 RID: 2825
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x04000B0A RID: 2826
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x04000B0B RID: 2827
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000B0C RID: 2828
        <AccessedThroughProperty("lblCloseLockDC")> _
        Private _lblCloseLockDC As Label

        ' Token: 0x04000B0E RID: 2830
        Public UTT As clsUTT

        ' Token: 0x04000B0F RID: 2831
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x04000B10 RID: 2832
        Private NameLang As Integer

        ' Token: 0x04000B11 RID: 2833
        Private ComboBoxSettingError As Boolean

        ' Token: 0x04000B12 RID: 2834
        Private m_bSaveGameMode As Boolean
    End Class
End Namespace
