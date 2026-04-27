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
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000047 RID: 71
	Public Partial Class frmDialogEditor
		Inherits frmParent

		' Token: 0x0600030E RID: 782 RVA: 0x00231058 File Offset: 0x00230058
		Public Sub New()
			Me.dtStunt = New DataTable()
			Me.dtAnim = New DataTable()
			Me.InitializeComponent()
			Me.m_defaultTitleText = "Conversation Editor - KotOR "
			Me.Text = Me.m_defaultTitleText
			Me.BuildStuntDataGrid()
			Me.BuildAnimDataGrid()
		End Sub

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x06000310 RID: 784 RVA: 0x002310CC File Offset: 0x002300CC
		' (set) Token: 0x06000311 RID: 785 RVA: 0x002310E0 File Offset: 0x002300E0
		Friend Overridable Property tbConversationText As TextBox
			Get
				Return Me._tbConversationText
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbConversationText IsNot Nothing Then
                End If
                Me._tbConversationText = value
                If Me._tbConversationText IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x06000312 RID: 786 RVA: 0x002310FC File Offset: 0x002300FC
		' (set) Token: 0x06000313 RID: 787 RVA: 0x00231110 File Offset: 0x00230110
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

        ' Token: 0x170000CE RID: 206
        ' (get) Token: 0x06000314 RID: 788 RVA: 0x0023112C File Offset: 0x0023012C
        ' (set) Token: 0x06000315 RID: 789 RVA: 0x00231140 File Offset: 0x00230140
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

        ' Token: 0x170000CF RID: 207
        ' (get) Token: 0x06000316 RID: 790 RVA: 0x0023115C File Offset: 0x0023015C
        ' (set) Token: 0x06000317 RID: 791 RVA: 0x00231170 File Offset: 0x00230170
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

        ' Token: 0x170000D0 RID: 208
        ' (get) Token: 0x06000319 RID: 793 RVA: 0x002311A8 File Offset: 0x002301A8
        ' (set) Token: 0x06000318 RID: 792 RVA: 0x0023118C File Offset: 0x0023018C
        Friend Overridable Property tbActionsTakenScript() As TextBox
            Get
                Return Me._tbActionsTakenScript
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbActionsTakenScript IsNot Nothing Then
                End If
                Me._tbActionsTakenScript = value
                If Me._tbActionsTakenScript IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000D1 RID: 209
        ' (get) Token: 0x0600031A RID: 794 RVA: 0x002311BC File Offset: 0x002301BC
        ' (set) Token: 0x0600031B RID: 795 RVA: 0x002311D0 File Offset: 0x002301D0
        Friend Overridable Property tvConversation() As TreeView
            Get
                Return Me._tvConversation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TreeView)
                If Me._tvConversation IsNot Nothing Then
                    RemoveHandler Me._tvConversation.AfterSelect, AddressOf Me.tvConversation_AfterSelect
                    RemoveHandler Me._tvConversation.MouseUp, AddressOf Me.tvConversation_MouseUp
                    RemoveHandler Me._tvConversation.MouseDown, AddressOf Me.tvConversation_MouseDown
                End If
                Me._tvConversation = value
                If Me._tvConversation IsNot Nothing Then
                    AddHandler Me._tvConversation.AfterSelect, AddressOf Me.tvConversation_AfterSelect
                    AddHandler Me._tvConversation.MouseUp, AddressOf Me.tvConversation_MouseUp
                    AddHandler Me._tvConversation.MouseDown, AddressOf Me.tvConversation_MouseDown
                End If
            End Set
        End Property

        ' Token: 0x170000D2 RID: 210
        ' (get) Token: 0x0600031D RID: 797 RVA: 0x002312A0 File Offset: 0x002302A0
        ' (set) Token: 0x0600031C RID: 796 RVA: 0x00231284 File Offset: 0x00230284
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

        ' Token: 0x170000D3 RID: 211
        ' (get) Token: 0x0600031E RID: 798 RVA: 0x002312B4 File Offset: 0x002302B4
        ' (set) Token: 0x0600031F RID: 799 RVA: 0x002312C8 File Offset: 0x002302C8
        Friend Overridable Property tbSound() As TextBox
            Get
                Return Me._tbSound
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbSound IsNot Nothing Then
                End If
                Me._tbSound = value
                If Me._tbSound IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000D4 RID: 212
        ' (get) Token: 0x06000321 RID: 801 RVA: 0x00231300 File Offset: 0x00230300
        ' (set) Token: 0x06000320 RID: 800 RVA: 0x002312E4 File Offset: 0x002302E4
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

        ' Token: 0x170000D5 RID: 213
        ' (get) Token: 0x06000322 RID: 802 RVA: 0x00231330 File Offset: 0x00230330
        ' (set) Token: 0x06000323 RID: 803 RVA: 0x00231314 File Offset: 0x00230314
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

        ' Token: 0x170000D6 RID: 214
        ' (get) Token: 0x06000325 RID: 805 RVA: 0x00231344 File Offset: 0x00230344
        ' (set) Token: 0x06000324 RID: 804 RVA: 0x00231358 File Offset: 0x00230358
        Friend Overridable Property btnCollapseAll() As Button
            Get
                Return Me._btnCollapseAll
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnCollapseAll IsNot Nothing Then
                    RemoveHandler Me._btnCollapseAll.Click, AddressOf Me.btnCollapseAll_Click
                End If
                Me._btnCollapseAll = value
                If Me._btnCollapseAll IsNot Nothing Then
                    AddHandler Me._btnCollapseAll.Click, AddressOf Me.btnCollapseAll_Click
                End If
            End Set
        End Property

        ' Token: 0x170000D7 RID: 215
        ' (get) Token: 0x06000327 RID: 807 RVA: 0x00231400 File Offset: 0x00230400
        ' (set) Token: 0x06000326 RID: 806 RVA: 0x002313AC File Offset: 0x002303AC
        Friend Overridable Property btnExpandAll() As Button
            Get
                Return Me._btnExpandAll
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnExpandAll IsNot Nothing Then
                    RemoveHandler Me._btnExpandAll.Click, AddressOf Me.btnExpandAll_Click
                End If
                Me._btnExpandAll = value
                If Me._btnExpandAll IsNot Nothing Then
                    AddHandler Me._btnExpandAll.Click, AddressOf Me.btnExpandAll_Click
                End If
            End Set
        End Property

        ' Token: 0x170000D8 RID: 216
        ' (get) Token: 0x06000329 RID: 809 RVA: 0x00231414 File Offset: 0x00230414
        ' (set) Token: 0x06000328 RID: 808 RVA: 0x00231428 File Offset: 0x00230428
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

        ' Token: 0x170000D9 RID: 217
        ' (get) Token: 0x0600032B RID: 811 RVA: 0x0023147C File Offset: 0x0023047C
        ' (set) Token: 0x0600032A RID: 810 RVA: 0x00231490 File Offset: 0x00230490
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

        ' Token: 0x170000DA RID: 218
        ' (get) Token: 0x0600032D RID: 813 RVA: 0x002314AC File Offset: 0x002304AC
        ' (set) Token: 0x0600032C RID: 812 RVA: 0x002314C0 File Offset: 0x002304C0
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

        ' Token: 0x170000DB RID: 219
        ' (get) Token: 0x0600032F RID: 815 RVA: 0x002314F8 File Offset: 0x002304F8
        ' (set) Token: 0x0600032E RID: 814 RVA: 0x002314DC File Offset: 0x002304DC
        Friend Overridable Property tbListener() As TextBox
            Get
                Return Me._tbListener
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbListener IsNot Nothing Then
                End If
                Me._tbListener = value
                If Me._tbListener IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000DC RID: 220
        ' (get) Token: 0x06000330 RID: 816 RVA: 0x00231528 File Offset: 0x00230528
        ' (set) Token: 0x06000331 RID: 817 RVA: 0x0023150C File Offset: 0x0023050C
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

        ' Token: 0x170000DD RID: 221
        ' (get) Token: 0x06000333 RID: 819 RVA: 0x0023153C File Offset: 0x0023053C
        ' (set) Token: 0x06000332 RID: 818 RVA: 0x00231550 File Offset: 0x00230550
        Friend Overridable Property tbVoiceOverResRef() As TextBox
            Get
                Return Me._tbVoiceOverResRef
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbVoiceOverResRef IsNot Nothing Then
                End If
                Me._tbVoiceOverResRef = value
                If Me._tbVoiceOverResRef IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000DE RID: 222
        ' (get) Token: 0x06000334 RID: 820 RVA: 0x0023156C File Offset: 0x0023056C
        ' (set) Token: 0x06000335 RID: 821 RVA: 0x00231580 File Offset: 0x00230580
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

        ' Token: 0x170000DF RID: 223
        ' (get) Token: 0x06000337 RID: 823 RVA: 0x002315B8 File Offset: 0x002305B8
        ' (set) Token: 0x06000336 RID: 822 RVA: 0x0023159C File Offset: 0x0023059C
        Friend Overridable Property lblPlotIndex() As Label
            Get
                Return Me._lblPlotIndex
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblPlotIndex IsNot Nothing Then
                End If
                Me._lblPlotIndex = value
                If Me._lblPlotIndex IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000E0 RID: 224
        ' (get) Token: 0x06000339 RID: 825 RVA: 0x002315CC File Offset: 0x002305CC
        ' (set) Token: 0x06000338 RID: 824 RVA: 0x002315E0 File Offset: 0x002305E0
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

        ' Token: 0x170000E1 RID: 225
        ' (get) Token: 0x0600033A RID: 826 RVA: 0x00231618 File Offset: 0x00230618
        ' (set) Token: 0x0600033B RID: 827 RVA: 0x002315FC File Offset: 0x002305FC
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

        ' Token: 0x170000E2 RID: 226
        ' (get) Token: 0x0600033D RID: 829 RVA: 0x00231648 File Offset: 0x00230648
        ' (set) Token: 0x0600033C RID: 828 RVA: 0x0023162C File Offset: 0x0023062C
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

        ' Token: 0x170000E3 RID: 227
        ' (get) Token: 0x0600033E RID: 830 RVA: 0x0023165C File Offset: 0x0023065C
        ' (set) Token: 0x0600033F RID: 831 RVA: 0x00231670 File Offset: 0x00230670
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

        ' Token: 0x170000E4 RID: 228
        ' (get) Token: 0x06000341 RID: 833 RVA: 0x0023168C File Offset: 0x0023068C
        ' (set) Token: 0x06000340 RID: 832 RVA: 0x002316A0 File Offset: 0x002306A0
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

        ' Token: 0x170000E5 RID: 229
        ' (get) Token: 0x06000342 RID: 834 RVA: 0x002316BC File Offset: 0x002306BC
        ' (set) Token: 0x06000343 RID: 835 RVA: 0x002316D0 File Offset: 0x002306D0
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

        ' Token: 0x170000E6 RID: 230
        ' (get) Token: 0x06000345 RID: 837 RVA: 0x00231740 File Offset: 0x00230740
        ' (set) Token: 0x06000344 RID: 836 RVA: 0x002316EC File Offset: 0x002306EC
        Friend Overridable Property btnTest() As Button
            Get
                Return Me._btnTest
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnTest IsNot Nothing Then
                    RemoveHandler Me._btnTest.Click, AddressOf Me.btnTest_Click
                End If
                Me._btnTest = value
                If Me._btnTest IsNot Nothing Then
                    AddHandler Me._btnTest.Click, AddressOf Me.btnTest_Click
                End If
            End Set
        End Property

        ' Token: 0x170000E7 RID: 231
        ' (get) Token: 0x06000347 RID: 839 RVA: 0x002317A8 File Offset: 0x002307A8
        ' (set) Token: 0x06000346 RID: 838 RVA: 0x00231754 File Offset: 0x00230754
        Friend Overridable Property btnChooseColor() As Button
            Get
                Return Me._btnChooseColor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnChooseColor IsNot Nothing Then
                    RemoveHandler Me._btnChooseColor.Click, AddressOf Me.btnChooseColor_Click
                End If
                Me._btnChooseColor = value
                If Me._btnChooseColor IsNot Nothing Then
                    AddHandler Me._btnChooseColor.Click, AddressOf Me.btnChooseColor_Click
                End If
            End Set
        End Property

        ' Token: 0x170000E8 RID: 232
        ' (get) Token: 0x06000348 RID: 840 RVA: 0x002317D8 File Offset: 0x002307D8
        ' (set) Token: 0x06000349 RID: 841 RVA: 0x002317BC File Offset: 0x002307BC
        Friend Overridable Property cmTVfunctions() As ContextMenu
            Get
                Return Me._cmTVfunctions
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ContextMenu)
                If Me._cmTVfunctions IsNot Nothing Then
                End If
                Me._cmTVfunctions = value
                If Me._cmTVfunctions IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000E9 RID: 233
        ' (get) Token: 0x0600034A RID: 842 RVA: 0x00231840 File Offset: 0x00230840
        ' (set) Token: 0x0600034B RID: 843 RVA: 0x002317EC File Offset: 0x002307EC
        Friend Overridable Property cmiTV_Add() As MenuItem
            Get
                Return Me._cmiTV_Add
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._cmiTV_Add IsNot Nothing Then
                    RemoveHandler Me._cmiTV_Add.Click, AddressOf Me.cmiTV_Add_Click
                End If
                Me._cmiTV_Add = value
                If Me._cmiTV_Add IsNot Nothing Then
                    AddHandler Me._cmiTV_Add.Click, AddressOf Me.cmiTV_Add_Click
                End If
            End Set
        End Property

        ' Token: 0x170000EA RID: 234
        ' (get) Token: 0x0600034C RID: 844 RVA: 0x00231854 File Offset: 0x00230854
        ' (set) Token: 0x0600034D RID: 845 RVA: 0x00231868 File Offset: 0x00230868
        Friend Overridable Property cmiTV_Copy() As MenuItem
            Get
                Return Me._cmiTV_Copy
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._cmiTV_Copy IsNot Nothing Then
                    RemoveHandler Me._cmiTV_Copy.Click, AddressOf Me.cmiTV_Copy_Click
                End If
                Me._cmiTV_Copy = value
                If Me._cmiTV_Copy IsNot Nothing Then
                    AddHandler Me._cmiTV_Copy.Click, AddressOf Me.cmiTV_Copy_Click
                End If
            End Set
        End Property

        ' Token: 0x170000EB RID: 235
        ' (get) Token: 0x0600034F RID: 847 RVA: 0x00231910 File Offset: 0x00230910
        ' (set) Token: 0x0600034E RID: 846 RVA: 0x002318BC File Offset: 0x002308BC
        Friend Overridable Property cmiTV_Paste() As MenuItem
            Get
                Return Me._cmiTV_Paste
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._cmiTV_Paste IsNot Nothing Then
                    RemoveHandler Me._cmiTV_Paste.Click, AddressOf Me.cmiTV_Paste_Click
                End If
                Me._cmiTV_Paste = value
                If Me._cmiTV_Paste IsNot Nothing Then
                    AddHandler Me._cmiTV_Paste.Click, AddressOf Me.cmiTV_Paste_Click
                End If
            End Set
        End Property

        ' Token: 0x170000EC RID: 236
        ' (get) Token: 0x06000350 RID: 848 RVA: 0x00231978 File Offset: 0x00230978
        ' (set) Token: 0x06000351 RID: 849 RVA: 0x00231924 File Offset: 0x00230924
        Friend Overridable Property cmiTV_PasteAsLink() As MenuItem
            Get
                Return Me._cmiTV_PasteAsLink
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._cmiTV_PasteAsLink IsNot Nothing Then
                    RemoveHandler Me._cmiTV_PasteAsLink.Click, AddressOf Me.cmiTV_PasteAsLink_Click
                End If
                Me._cmiTV_PasteAsLink = value
                If Me._cmiTV_PasteAsLink IsNot Nothing Then
                    AddHandler Me._cmiTV_PasteAsLink.Click, AddressOf Me.cmiTV_PasteAsLink_Click
                End If
            End Set
        End Property

        ' Token: 0x170000ED RID: 237
        ' (get) Token: 0x06000352 RID: 850 RVA: 0x0023198C File Offset: 0x0023098C
        ' (set) Token: 0x06000353 RID: 851 RVA: 0x002319A0 File Offset: 0x002309A0
        Friend Overridable Property cmiTV_Cut() As MenuItem
            Get
                Return Me._cmiTV_Cut
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._cmiTV_Cut IsNot Nothing Then
                    RemoveHandler Me._cmiTV_Cut.Click, AddressOf Me.cmiTV_Cut_Click
                End If
                Me._cmiTV_Cut = value
                If Me._cmiTV_Cut IsNot Nothing Then
                    AddHandler Me._cmiTV_Cut.Click, AddressOf Me.cmiTV_Cut_Click
                End If
            End Set
        End Property

        ' Token: 0x170000EE RID: 238
        ' (get) Token: 0x06000354 RID: 852 RVA: 0x002319F4 File Offset: 0x002309F4
        ' (set) Token: 0x06000355 RID: 853 RVA: 0x00231A08 File Offset: 0x00230A08
        Friend Overridable Property nudFadeColorG() As NumericUpDown
            Get
                Return Me._nudFadeColorG
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudFadeColorG IsNot Nothing Then
                End If
                Me._nudFadeColorG = value
                If Me._nudFadeColorG IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000EF RID: 239
        ' (get) Token: 0x06000357 RID: 855 RVA: 0x00231A24 File Offset: 0x00230A24
        ' (set) Token: 0x06000356 RID: 854 RVA: 0x00231A38 File Offset: 0x00230A38
        Friend Overridable Property nudFadeColorB() As NumericUpDown
            Get
                Return Me._nudFadeColorB
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudFadeColorB IsNot Nothing Then
                End If
                Me._nudFadeColorB = value
                If Me._nudFadeColorB IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F0 RID: 240
        ' (get) Token: 0x06000358 RID: 856 RVA: 0x00231A70 File Offset: 0x00230A70
        ' (set) Token: 0x06000359 RID: 857 RVA: 0x00231A54 File Offset: 0x00230A54
        Friend Overridable Property nudPlotIndex() As NumericUpDown
            Get
                Return Me._nudPlotIndex
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudPlotIndex IsNot Nothing Then
                End If
                Me._nudPlotIndex = value
                If Me._nudPlotIndex IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F1 RID: 241
        ' (get) Token: 0x0600035A RID: 858 RVA: 0x00231A84 File Offset: 0x00230A84
        ' (set) Token: 0x0600035B RID: 859 RVA: 0x00231A98 File Offset: 0x00230A98
        Friend Overridable Property nudPlotXPPercentage() As NumericUpDown
            Get
                Return Me._nudPlotXPPercentage
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudPlotXPPercentage IsNot Nothing Then
                End If
                Me._nudPlotXPPercentage = value
                If Me._nudPlotXPPercentage IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F2 RID: 242
        ' (get) Token: 0x0600035D RID: 861 RVA: 0x00231AB4 File Offset: 0x00230AB4
        ' (set) Token: 0x0600035C RID: 860 RVA: 0x00231AC8 File Offset: 0x00230AC8
        Friend Overridable Property nudCameraAngle() As NumericUpDown
            Get
                Return Me._nudCameraAngle
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCameraAngle IsNot Nothing Then
                End If
                Me._nudCameraAngle = value
                If Me._nudCameraAngle IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F3 RID: 243
        ' (get) Token: 0x0600035E RID: 862 RVA: 0x00231AE4 File Offset: 0x00230AE4
        ' (set) Token: 0x0600035F RID: 863 RVA: 0x00231AF8 File Offset: 0x00230AF8
        Friend Overridable Property nudCamHeightOffset() As NumericUpDown
            Get
                Return Me._nudCamHeightOffset
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCamHeightOffset IsNot Nothing Then
                End If
                Me._nudCamHeightOffset = value
                If Me._nudCamHeightOffset IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F4 RID: 244
        ' (get) Token: 0x06000360 RID: 864 RVA: 0x00231B14 File Offset: 0x00230B14
        ' (set) Token: 0x06000361 RID: 865 RVA: 0x00231B28 File Offset: 0x00230B28
        Friend Overridable Property nudTarHeightOffset() As NumericUpDown
            Get
                Return Me._nudTarHeightOffset
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudTarHeightOffset IsNot Nothing Then
                End If
                Me._nudTarHeightOffset = value
                If Me._nudTarHeightOffset IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F5 RID: 245
        ' (get) Token: 0x06000362 RID: 866 RVA: 0x00231B44 File Offset: 0x00230B44
        ' (set) Token: 0x06000363 RID: 867 RVA: 0x00231B58 File Offset: 0x00230B58
        Friend Overridable Property nudFadeDelay() As NumericUpDown
            Get
                Return Me._nudFadeDelay
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudFadeDelay IsNot Nothing Then
                End If
                Me._nudFadeDelay = value
                If Me._nudFadeDelay IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F6 RID: 246
        ' (get) Token: 0x06000364 RID: 868 RVA: 0x00231B74 File Offset: 0x00230B74
        ' (set) Token: 0x06000365 RID: 869 RVA: 0x00231B88 File Offset: 0x00230B88
        Friend Overridable Property nudFadeLength() As NumericUpDown
            Get
                Return Me._nudFadeLength
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudFadeLength IsNot Nothing Then
                End If
                Me._nudFadeLength = value
                If Me._nudFadeLength IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F7 RID: 247
        ' (get) Token: 0x06000367 RID: 871 RVA: 0x00231BA4 File Offset: 0x00230BA4
        ' (set) Token: 0x06000366 RID: 870 RVA: 0x00231BB8 File Offset: 0x00230BB8
        Friend Overridable Property tbLinkID() As TextBox
            Get
                Return Me._tbLinkID
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbLinkID IsNot Nothing Then
                End If
                Me._tbLinkID = value
                If Me._tbLinkID IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F8 RID: 248
        ' (get) Token: 0x06000369 RID: 873 RVA: 0x00231BD4 File Offset: 0x00230BD4
        ' (set) Token: 0x06000368 RID: 872 RVA: 0x00231BE8 File Offset: 0x00230BE8
        Friend Overridable Property tbLinkedCnt() As TextBox
            Get
                Return Me._tbLinkedCnt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbLinkedCnt IsNot Nothing Then
                End If
                Me._tbLinkedCnt = value
                If Me._tbLinkedCnt IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000F9 RID: 249
        ' (get) Token: 0x0600036A RID: 874 RVA: 0x00231C20 File Offset: 0x00230C20
        ' (set) Token: 0x0600036B RID: 875 RVA: 0x00231C04 File Offset: 0x00230C04
        Friend Overridable Property tbSharedCnt() As TextBox
            Get
                Return Me._tbSharedCnt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbSharedCnt IsNot Nothing Then
                End If
                Me._tbSharedCnt = value
                If Me._tbSharedCnt IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000FA RID: 250
        ' (get) Token: 0x0600036C RID: 876 RVA: 0x00231C50 File Offset: 0x00230C50
        ' (set) Token: 0x0600036D RID: 877 RVA: 0x00231C34 File Offset: 0x00230C34
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

        ' Token: 0x170000FB RID: 251
        ' (get) Token: 0x0600036E RID: 878 RVA: 0x00231C64 File Offset: 0x00230C64
        ' (set) Token: 0x0600036F RID: 879 RVA: 0x00231C78 File Offset: 0x00230C78
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

        ' Token: 0x170000FC RID: 252
        ' (get) Token: 0x06000370 RID: 880 RVA: 0x00231C94 File Offset: 0x00230C94
        ' (set) Token: 0x06000371 RID: 881 RVA: 0x00231CA8 File Offset: 0x00230CA8
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

        ' Token: 0x170000FD RID: 253
        ' (get) Token: 0x06000373 RID: 883 RVA: 0x00231CE0 File Offset: 0x00230CE0
        ' (set) Token: 0x06000372 RID: 882 RVA: 0x00231CC4 File Offset: 0x00230CC4
        Friend Overridable Property tbVO_ID() As TextBox
            Get
                Return Me._tbVO_ID
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbVO_ID IsNot Nothing Then
                End If
                Me._tbVO_ID = value
                If Me._tbVO_ID IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000FE RID: 254
        ' (get) Token: 0x06000375 RID: 885 RVA: 0x00231CF4 File Offset: 0x00230CF4
        ' (set) Token: 0x06000374 RID: 884 RVA: 0x00231D08 File Offset: 0x00230D08
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

        ' Token: 0x170000FF RID: 255
        ' (get) Token: 0x06000377 RID: 887 RVA: 0x00231D40 File Offset: 0x00230D40
        ' (set) Token: 0x06000376 RID: 886 RVA: 0x00231D24 File Offset: 0x00230D24
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

        ' Token: 0x17000100 RID: 256
        ' (get) Token: 0x06000379 RID: 889 RVA: 0x00231D54 File Offset: 0x00230D54
        ' (set) Token: 0x06000378 RID: 888 RVA: 0x00231D68 File Offset: 0x00230D68
        Friend Overridable Property tbEndConversation() As TextBox
            Get
                Return Me._tbEndConversation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbEndConversation IsNot Nothing Then
                End If
                Me._tbEndConversation = value
                If Me._tbEndConversation IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000101 RID: 257
        ' (get) Token: 0x0600037A RID: 890 RVA: 0x00231DA0 File Offset: 0x00230DA0
        ' (set) Token: 0x0600037B RID: 891 RVA: 0x00231D84 File Offset: 0x00230D84
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

        ' Token: 0x17000102 RID: 258
        ' (get) Token: 0x0600037C RID: 892 RVA: 0x00231DD0 File Offset: 0x00230DD0
        ' (set) Token: 0x0600037D RID: 893 RVA: 0x00231DB4 File Offset: 0x00230DB4
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

        ' Token: 0x17000103 RID: 259
        ' (get) Token: 0x0600037E RID: 894 RVA: 0x00231DE4 File Offset: 0x00230DE4
        ' (set) Token: 0x0600037F RID: 895 RVA: 0x00231DF8 File Offset: 0x00230DF8
        Friend Overridable Property tbEndConverAbort() As TextBox
            Get
                Return Me._tbEndConverAbort
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbEndConverAbort IsNot Nothing Then
                End If
                Me._tbEndConverAbort = value
                If Me._tbEndConverAbort IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000104 RID: 260
        ' (get) Token: 0x06000380 RID: 896 RVA: 0x00231E14 File Offset: 0x00230E14
        ' (set) Token: 0x06000381 RID: 897 RVA: 0x00231E28 File Offset: 0x00230E28
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

        ' Token: 0x17000105 RID: 261
        ' (get) Token: 0x06000382 RID: 898 RVA: 0x00231E60 File Offset: 0x00230E60
        ' (set) Token: 0x06000383 RID: 899 RVA: 0x00231E44 File Offset: 0x00230E44
        Friend Overridable Property tbAmbientTrack() As TextBox
            Get
                Return Me._tbAmbientTrack
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbAmbientTrack IsNot Nothing Then
                End If
                Me._tbAmbientTrack = value
                If Me._tbAmbientTrack IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000106 RID: 262
        ' (get) Token: 0x06000385 RID: 901 RVA: 0x00231E90 File Offset: 0x00230E90
        ' (set) Token: 0x06000384 RID: 900 RVA: 0x00231E74 File Offset: 0x00230E74
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

        ' Token: 0x17000107 RID: 263
        ' (get) Token: 0x06000386 RID: 902 RVA: 0x00231EA4 File Offset: 0x00230EA4
        ' (set) Token: 0x06000387 RID: 903 RVA: 0x00231EB8 File Offset: 0x00230EB8
        Friend Overridable Property chkbSkippable() As CheckBox
            Get
                Return Me._chkbSkippable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbSkippable IsNot Nothing Then
                End If
                Me._chkbSkippable = value
                If Me._chkbSkippable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000108 RID: 264
        ' (get) Token: 0x06000388 RID: 904 RVA: 0x00231ED4 File Offset: 0x00230ED4
        ' (set) Token: 0x06000389 RID: 905 RVA: 0x00231EE8 File Offset: 0x00230EE8
        Friend Overridable Property chkbUnequipItems() As CheckBox
            Get
                Return Me._chkbUnequipItems
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbUnequipItems IsNot Nothing Then
                End If
                Me._chkbUnequipItems = value
                If Me._chkbUnequipItems IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000109 RID: 265
        ' (get) Token: 0x0600038A RID: 906 RVA: 0x00231F04 File Offset: 0x00230F04
        ' (set) Token: 0x0600038B RID: 907 RVA: 0x00231F18 File Offset: 0x00230F18
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

        ' Token: 0x1700010A RID: 266
        ' (get) Token: 0x0600038C RID: 908 RVA: 0x00231F34 File Offset: 0x00230F34
        ' (set) Token: 0x0600038D RID: 909 RVA: 0x00231F48 File Offset: 0x00230F48
        Friend Overridable Property nudDelayEntry() As NumericUpDown
            Get
                Return Me._nudDelayEntry
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudDelayEntry IsNot Nothing Then
                End If
                Me._nudDelayEntry = value
                If Me._nudDelayEntry IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700010B RID: 267
        ' (get) Token: 0x0600038E RID: 910 RVA: 0x00231F64 File Offset: 0x00230F64
        ' (set) Token: 0x0600038F RID: 911 RVA: 0x00231F78 File Offset: 0x00230F78
        Friend Overridable Property nudDelayReply() As NumericUpDown
            Get
                Return Me._nudDelayReply
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudDelayReply IsNot Nothing Then
                End If
                Me._nudDelayReply = value
                If Me._nudDelayReply IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700010C RID: 268
        ' (get) Token: 0x06000390 RID: 912 RVA: 0x00231F94 File Offset: 0x00230F94
        ' (set) Token: 0x06000391 RID: 913 RVA: 0x00231FA8 File Offset: 0x00230FA8
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

        ' Token: 0x1700010D RID: 269
        ' (get) Token: 0x06000392 RID: 914 RVA: 0x00231FE0 File Offset: 0x00230FE0
        ' (set) Token: 0x06000393 RID: 915 RVA: 0x00231FC4 File Offset: 0x00230FC4
        Friend Overridable Property chkbUnequipHItem() As CheckBox
            Get
                Return Me._chkbUnequipHItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbUnequipHItem IsNot Nothing Then
                End If
                Me._chkbUnequipHItem = value
                If Me._chkbUnequipHItem IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700010E RID: 270
        ' (get) Token: 0x06000394 RID: 916 RVA: 0x00231FF4 File Offset: 0x00230FF4
        ' (set) Token: 0x06000395 RID: 917 RVA: 0x00232008 File Offset: 0x00231008
        Friend Overridable Property tbSpeaker() As TextBox
            Get
                Return Me._tbSpeaker
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbSpeaker IsNot Nothing Then
                End If
                Me._tbSpeaker = value
                If Me._tbSpeaker IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700010F RID: 271
        ' (get) Token: 0x06000397 RID: 919 RVA: 0x00232024 File Offset: 0x00231024
        ' (set) Token: 0x06000396 RID: 918 RVA: 0x00232038 File Offset: 0x00231038
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

        ' Token: 0x17000110 RID: 272
        ' (get) Token: 0x06000399 RID: 921 RVA: 0x00232054 File Offset: 0x00231054
        ' (set) Token: 0x06000398 RID: 920 RVA: 0x00232068 File Offset: 0x00231068
        Friend Overridable Property nudCameraID() As NumericUpDown
            Get
                Return Me._nudCameraID
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCameraID IsNot Nothing Then
                End If
                Me._nudCameraID = value
                If Me._nudCameraID IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000111 RID: 273
        ' (get) Token: 0x0600039A RID: 922 RVA: 0x00232084 File Offset: 0x00231084
        ' (set) Token: 0x0600039B RID: 923 RVA: 0x00232098 File Offset: 0x00231098
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

        ' Token: 0x17000112 RID: 274
        ' (get) Token: 0x0600039C RID: 924 RVA: 0x002320B4 File Offset: 0x002310B4
        ' (set) Token: 0x0600039D RID: 925 RVA: 0x002320C8 File Offset: 0x002310C8
        Friend Overridable Property tabpagActionsTaken() As TabPage
            Get
                Return Me._tabpagActionsTaken
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagActionsTaken IsNot Nothing Then
                End If
                Me._tabpagActionsTaken = value
                If Me._tabpagActionsTaken IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000113 RID: 275
        ' (get) Token: 0x0600039E RID: 926 RVA: 0x002320E4 File Offset: 0x002310E4
        ' (set) Token: 0x0600039F RID: 927 RVA: 0x002320F8 File Offset: 0x002310F8
        Friend Overridable Property tabpagCamera() As TabPage
            Get
                Return Me._tabpagCamera
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagCamera IsNot Nothing Then
                End If
                Me._tabpagCamera = value
                If Me._tabpagCamera IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000114 RID: 276
        ' (get) Token: 0x060003A0 RID: 928 RVA: 0x00232114 File Offset: 0x00231114
        ' (set) Token: 0x060003A1 RID: 929 RVA: 0x00232128 File Offset: 0x00231128
        Friend Overridable Property tabpagComment() As TabPage
            Get
                Return Me._tabpagComment
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagComment IsNot Nothing Then
                End If
                Me._tabpagComment = value
                If Me._tabpagComment IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000115 RID: 277
        ' (get) Token: 0x060003A2 RID: 930 RVA: 0x00232160 File Offset: 0x00231160
        ' (set) Token: 0x060003A3 RID: 931 RVA: 0x00232144 File Offset: 0x00231144
        Friend Overridable Property tabpagPlot() As TabPage
            Get
                Return Me._tabpagPlot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagPlot IsNot Nothing Then
                End If
                Me._tabpagPlot = value
                If Me._tabpagPlot IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000116 RID: 278
        ' (get) Token: 0x060003A4 RID: 932 RVA: 0x00232174 File Offset: 0x00231174
        ' (set) Token: 0x060003A5 RID: 933 RVA: 0x00232188 File Offset: 0x00231188
        Friend Overridable Property TabControl1() As TabControl
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

        ' Token: 0x17000117 RID: 279
        ' (get) Token: 0x060003A6 RID: 934 RVA: 0x002321A4 File Offset: 0x002311A4
        ' (set) Token: 0x060003A7 RID: 935 RVA: 0x002321B8 File Offset: 0x002311B8
        Friend Overridable Property tabpagAnimationSound() As TabPage
            Get
                Return Me._tabpagAnimationSound
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagAnimationSound IsNot Nothing Then
                End If
                Me._tabpagAnimationSound = value
                If Me._tabpagAnimationSound IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000118 RID: 280
        ' (get) Token: 0x060003A8 RID: 936 RVA: 0x002321D4 File Offset: 0x002311D4
        ' (set) Token: 0x060003A9 RID: 937 RVA: 0x002321E8 File Offset: 0x002311E8
        Friend Overridable Property tabpagDebug() As TabPage
            Get
                Return Me._tabpagDebug
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagDebug IsNot Nothing Then
                End If
                Me._tabpagDebug = value
                If Me._tabpagDebug IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000119 RID: 281
        ' (get) Token: 0x060003AA RID: 938 RVA: 0x00232258 File Offset: 0x00231258
        ' (set) Token: 0x060003AB RID: 939 RVA: 0x00232204 File Offset: 0x00231204
        Friend Overridable Property btnSave() As Button
            Get
                Return Me._btnSave
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSave IsNot Nothing Then
                    RemoveHandler Me._btnSave.Click, AddressOf Me.Button1_Click
                End If
                Me._btnSave = value
                If Me._btnSave IsNot Nothing Then
                    AddHandler Me._btnSave.Click, AddressOf Me.Button1_Click
                End If
            End Set
        End Property

        ' Token: 0x1700011A RID: 282
        ' (get) Token: 0x060003AD RID: 941 RVA: 0x0023226C File Offset: 0x0023126C
        ' (set) Token: 0x060003AC RID: 940 RVA: 0x00232280 File Offset: 0x00231280
        Friend Overridable Property btnOpen() As Button
            Get
                Return Me._btnOpen
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOpen IsNot Nothing Then
                    RemoveHandler Me._btnOpen.Click, AddressOf Me.btnOpen_Click
                End If
                Me._btnOpen = value
                If Me._btnOpen IsNot Nothing Then
                    AddHandler Me._btnOpen.Click, AddressOf Me.btnOpen_Click
                End If
            End Set
        End Property

        ' Token: 0x1700011B RID: 283
        ' (get) Token: 0x060003AE RID: 942 RVA: 0x002322D4 File Offset: 0x002312D4
        ' (set) Token: 0x060003AF RID: 943 RVA: 0x002322E8 File Offset: 0x002312E8
        Friend Overridable Property MainMenu1() As MainMenu
            Get
                Return Me._MainMenu1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MainMenu)
                If Me._MainMenu1 IsNot Nothing Then
                End If
                Me._MainMenu1 = value
                If Me._MainMenu1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700011C RID: 284
        ' (get) Token: 0x060003B1 RID: 945 RVA: 0x00232304 File Offset: 0x00231304
        ' (set) Token: 0x060003B0 RID: 944 RVA: 0x00232318 File Offset: 0x00231318
        Friend Overridable Property MenuItem1() As MenuItem
            Get
                Return Me._MenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._MenuItem1 IsNot Nothing Then
                End If
                Me._MenuItem1 = value
                If Me._MenuItem1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700011D RID: 285
        ' (get) Token: 0x060003B3 RID: 947 RVA: 0x00232334 File Offset: 0x00231334
        ' (set) Token: 0x060003B2 RID: 946 RVA: 0x00232348 File Offset: 0x00231348
        Friend Overridable Property MenuItem4() As MenuItem
            Get
                Return Me._MenuItem4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._MenuItem4 IsNot Nothing Then
                End If
                Me._MenuItem4 = value
                If Me._MenuItem4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700011E RID: 286
        ' (get) Token: 0x060003B4 RID: 948 RVA: 0x002323B8 File Offset: 0x002313B8
        ' (set) Token: 0x060003B5 RID: 949 RVA: 0x00232364 File Offset: 0x00231364
        Friend Overridable Property miOpen() As MenuItem
            Get
                Return Me._miOpen
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miOpen IsNot Nothing Then
                    RemoveHandler Me._miOpen.Click, AddressOf Me.miOpen_Click
                End If
                Me._miOpen = value
                If Me._miOpen IsNot Nothing Then
                    AddHandler Me._miOpen.Click, AddressOf Me.miOpen_Click
                End If
            End Set
        End Property

        ' Token: 0x1700011F RID: 287
        ' (get) Token: 0x060003B6 RID: 950 RVA: 0x00232420 File Offset: 0x00231420
        ' (set) Token: 0x060003B7 RID: 951 RVA: 0x002323CC File Offset: 0x002313CC
        Friend Overridable Property miSave() As MenuItem
            Get
                Return Me._miSave
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miSave IsNot Nothing Then
                    RemoveHandler Me._miSave.Click, AddressOf Me.miSave_Click
                End If
                Me._miSave = value
                If Me._miSave IsNot Nothing Then
                    AddHandler Me._miSave.Click, AddressOf Me.miSave_Click
                End If
            End Set
        End Property

        ' Token: 0x17000120 RID: 288
        ' (get) Token: 0x060003B9 RID: 953 RVA: 0x00232488 File Offset: 0x00231488
        ' (set) Token: 0x060003B8 RID: 952 RVA: 0x00232434 File Offset: 0x00231434
        Friend Overridable Property miQuit() As MenuItem
            Get
                Return Me._miQuit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miQuit IsNot Nothing Then
                    RemoveHandler Me._miQuit.Click, AddressOf Me.miQuit_Click
                End If
                Me._miQuit = value
                If Me._miQuit IsNot Nothing Then
                    AddHandler Me._miQuit.Click, AddressOf Me.miQuit_Click
                End If
            End Set
        End Property

        ' Token: 0x17000121 RID: 289
        ' (get) Token: 0x060003BA RID: 954 RVA: 0x0023249C File Offset: 0x0023149C
        ' (set) Token: 0x060003BB RID: 955 RVA: 0x002324B0 File Offset: 0x002314B0
        Friend Overridable Property tabpagThisFile1() As TabPage
            Get
                Return Me._tabpagThisFile1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagThisFile1 IsNot Nothing Then
                End If
                Me._tabpagThisFile1 = value
                If Me._tabpagThisFile1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000122 RID: 290
        ' (get) Token: 0x060003BD RID: 957 RVA: 0x002324E8 File Offset: 0x002314E8
        ' (set) Token: 0x060003BC RID: 956 RVA: 0x002324CC File Offset: 0x002314CC
        Friend Overridable Property tabpagThisFile2() As TabPage
            Get
                Return Me._tabpagThisFile2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagThisFile2 IsNot Nothing Then
                End If
                Me._tabpagThisFile2 = value
                If Me._tabpagThisFile2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000123 RID: 291
        ' (get) Token: 0x060003BE RID: 958 RVA: 0x002324FC File Offset: 0x002314FC
        ' (set) Token: 0x060003BF RID: 959 RVA: 0x00232510 File Offset: 0x00231510
        Friend Overridable Property dgStuntList() As DataGrid
            Get
                Return Me._dgStuntList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As DataGrid)
                If Me._dgStuntList IsNot Nothing Then
                End If
                Me._dgStuntList = value
                If Me._dgStuntList IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000124 RID: 292
        ' (get) Token: 0x060003C1 RID: 961 RVA: 0x0023252C File Offset: 0x0023152C
        ' (set) Token: 0x060003C0 RID: 960 RVA: 0x00232540 File Offset: 0x00231540
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

        ' Token: 0x17000125 RID: 293
        ' (get) Token: 0x060003C3 RID: 963 RVA: 0x00232578 File Offset: 0x00231578
        ' (set) Token: 0x060003C2 RID: 962 RVA: 0x0023255C File Offset: 0x0023155C
        Friend Overridable Property tbTextActiveScript() As TextBox
            Get
                Return Me._tbTextActiveScript
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTextActiveScript IsNot Nothing Then
                End If
                Me._tbTextActiveScript = value
                If Me._tbTextActiveScript IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000126 RID: 294
        ' (get) Token: 0x060003C4 RID: 964 RVA: 0x0023258C File Offset: 0x0023158C
        ' (set) Token: 0x060003C5 RID: 965 RVA: 0x002325A0 File Offset: 0x002315A0
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

        ' Token: 0x17000127 RID: 295
        ' (get) Token: 0x060003C6 RID: 966 RVA: 0x002325BC File Offset: 0x002315BC
        ' (set) Token: 0x060003C7 RID: 967 RVA: 0x002325D0 File Offset: 0x002315D0
        Friend Overridable Property dgAnimList() As DataGrid
            Get
                Return Me._dgAnimList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As DataGrid)
                If Me._dgAnimList IsNot Nothing Then
                    RemoveHandler Me._dgAnimList.Validated, AddressOf Me.dgAnimList_Validated
                    RemoveHandler Me._dgAnimList.Click, AddressOf Me.dgAnimList_Click
                End If
                Me._dgAnimList = value
                If Me._dgAnimList IsNot Nothing Then
                    AddHandler Me._dgAnimList.Validated, AddressOf Me.dgAnimList_Validated
                    AddHandler Me._dgAnimList.Click, AddressOf Me.dgAnimList_Click
                End If
            End Set
        End Property

        ' Token: 0x17000128 RID: 296
        ' (get) Token: 0x060003C8 RID: 968 RVA: 0x002326A8 File Offset: 0x002316A8
        ' (set) Token: 0x060003C9 RID: 969 RVA: 0x00232654 File Offset: 0x00231654
        Friend Overridable Property btnDeleteAnimListEntry() As Button
            Get
                Return Me._btnDeleteAnimListEntry
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnDeleteAnimListEntry IsNot Nothing Then
                    RemoveHandler Me._btnDeleteAnimListEntry.Click, AddressOf Me.btnDeleteAnimListEntry_Click
                End If
                Me._btnDeleteAnimListEntry = value
                If Me._btnDeleteAnimListEntry IsNot Nothing Then
                    AddHandler Me._btnDeleteAnimListEntry.Click, AddressOf Me.btnDeleteAnimListEntry_Click
                End If
            End Set
        End Property

        ' Token: 0x17000129 RID: 297
        ' (get) Token: 0x060003CA RID: 970 RVA: 0x002326BC File Offset: 0x002316BC
        ' (set) Token: 0x060003CB RID: 971 RVA: 0x002326D0 File Offset: 0x002316D0
        Friend Overridable Property btnAddAnimListEntry() As Button
            Get
                Return Me._btnAddAnimListEntry
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnAddAnimListEntry IsNot Nothing Then
                    RemoveHandler Me._btnAddAnimListEntry.Click, AddressOf Me.btnAddAnimListEntry_Click
                End If
                Me._btnAddAnimListEntry = value
                If Me._btnAddAnimListEntry IsNot Nothing Then
                    AddHandler Me._btnAddAnimListEntry.Click, AddressOf Me.btnAddAnimListEntry_Click
                End If
            End Set
        End Property

        ' Token: 0x1700012A RID: 298
        ' (get) Token: 0x060003CC RID: 972 RVA: 0x00232724 File Offset: 0x00231724
        ' (set) Token: 0x060003CD RID: 973 RVA: 0x00232738 File Offset: 0x00231738
        Friend Overridable Property trkbTVIndent() As TrackBar
            Get
                Return Me._trkbTVIndent
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbTVIndent IsNot Nothing Then
                    RemoveHandler Me._trkbTVIndent.Scroll, AddressOf Me.trkbTVIndent_Scroll
                End If
                Me._trkbTVIndent = value
                If Me._trkbTVIndent IsNot Nothing Then
                    AddHandler Me._trkbTVIndent.Scroll, AddressOf Me.trkbTVIndent_Scroll
                End If
            End Set
        End Property

        ' Token: 0x1700012B RID: 299
        ' (get) Token: 0x060003CE RID: 974 RVA: 0x0023278C File Offset: 0x0023178C
        ' (set) Token: 0x060003CF RID: 975 RVA: 0x002327A0 File Offset: 0x002317A0
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

        ' Token: 0x1700012C RID: 300
        ' (get) Token: 0x060003D0 RID: 976 RVA: 0x002327BC File Offset: 0x002317BC
        ' (set) Token: 0x060003D1 RID: 977 RVA: 0x002327D0 File Offset: 0x002317D0
        Friend Overridable Property miNew() As MenuItem
            Get
                Return Me._miNew
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miNew IsNot Nothing Then
                    RemoveHandler Me._miNew.Click, AddressOf Me.miNew_Click
                End If
                Me._miNew = value
                If Me._miNew IsNot Nothing Then
                    AddHandler Me._miNew.Click, AddressOf Me.miNew_Click
                End If
            End Set
        End Property

        ' Token: 0x1700012D RID: 301
        ' (get) Token: 0x060003D3 RID: 979 RVA: 0x00232840 File Offset: 0x00231840
        ' (set) Token: 0x060003D2 RID: 978 RVA: 0x00232824 File Offset: 0x00231824
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

        ' Token: 0x1700012E RID: 302
        ' (get) Token: 0x060003D5 RID: 981 RVA: 0x00232870 File Offset: 0x00231870
        ' (set) Token: 0x060003D4 RID: 980 RVA: 0x00232854 File Offset: 0x00231854
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

        ' Token: 0x1700012F RID: 303
        ' (get) Token: 0x060003D7 RID: 983 RVA: 0x00232884 File Offset: 0x00231884
        ' (set) Token: 0x060003D6 RID: 982 RVA: 0x00232898 File Offset: 0x00231898
        Friend Overridable Property trkbTVItemHeight() As TrackBar
            Get
                Return Me._trkbTVItemHeight
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TrackBar)
                If Me._trkbTVItemHeight IsNot Nothing Then
                    RemoveHandler Me._trkbTVItemHeight.Scroll, AddressOf Me.trkbTVItemHeight_Scroll
                End If
                Me._trkbTVItemHeight = value
                If Me._trkbTVItemHeight IsNot Nothing Then
                    AddHandler Me._trkbTVItemHeight.Scroll, AddressOf Me.trkbTVItemHeight_Scroll
                End If
            End Set
        End Property

        ' Token: 0x17000130 RID: 304
        ' (get) Token: 0x060003D8 RID: 984 RVA: 0x00232940 File Offset: 0x00231940
        ' (set) Token: 0x060003D9 RID: 985 RVA: 0x002328EC File Offset: 0x002318EC
        Friend Overridable Property cmiTV_PasteTree() As MenuItem
            Get
                Return Me._cmiTV_PasteTree
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._cmiTV_PasteTree IsNot Nothing Then
                    RemoveHandler Me._cmiTV_PasteTree.Click, AddressOf Me.cmiTV_PasteTree_Click
                End If
                Me._cmiTV_PasteTree = value
                If Me._cmiTV_PasteTree IsNot Nothing Then
                    AddHandler Me._cmiTV_PasteTree.Click, AddressOf Me.cmiTV_PasteTree_Click
                End If
            End Set
        End Property

        ' Token: 0x17000131 RID: 305
        ' (get) Token: 0x060003DB RID: 987 RVA: 0x00232970 File Offset: 0x00231970
        ' (set) Token: 0x060003DA RID: 986 RVA: 0x00232954 File Offset: 0x00231954
        Friend Overridable Property tbLinkDesc() As TextBox
            Get
                Return Me._tbLinkDesc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbLinkDesc IsNot Nothing Then
                End If
                Me._tbLinkDesc = value
                If Me._tbLinkDesc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000132 RID: 306
        ' (get) Token: 0x060003DD RID: 989 RVA: 0x00232984 File Offset: 0x00231984
        ' (set) Token: 0x060003DC RID: 988 RVA: 0x00232998 File Offset: 0x00231998
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

        ' Token: 0x17000133 RID: 307
        ' (get) Token: 0x060003DF RID: 991 RVA: 0x00232A08 File Offset: 0x00231A08
        ' (set) Token: 0x060003DE RID: 990 RVA: 0x002329B4 File Offset: 0x002319B4
        Friend Overridable Property cmbxConversationType() As ComboBox
            Get
                Return Me._cmbxConversationType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxConversationType IsNot Nothing Then
                    RemoveHandler Me._cmbxConversationType.SelectedIndexChanged, AddressOf Me.cmbxConversationType_SelectedIndexChanged
                End If
                Me._cmbxConversationType = value
                If Me._cmbxConversationType IsNot Nothing Then
                    AddHandler Me._cmbxConversationType.SelectedIndexChanged, AddressOf Me.cmbxConversationType_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x17000134 RID: 308
        ' (get) Token: 0x060003E0 RID: 992 RVA: 0x00232A1C File Offset: 0x00231A1C
        ' (set) Token: 0x060003E1 RID: 993 RVA: 0x00232A30 File Offset: 0x00231A30
        Friend Overridable Property cmbxComputerType() As ComboBox
            Get
                Return Me._cmbxComputerType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxComputerType IsNot Nothing Then
                End If
                Me._cmbxComputerType = value
                If Me._cmbxComputerType IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000135 RID: 309
        ' (get) Token: 0x060003E2 RID: 994 RVA: 0x00232A68 File Offset: 0x00231A68
        ' (set) Token: 0x060003E3 RID: 995 RVA: 0x00232A4C File Offset: 0x00231A4C
        Friend Overridable Property tbQuest() As TextBox
            Get
                Return Me._tbQuest
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbQuest IsNot Nothing Then
                End If
                Me._tbQuest = value
                If Me._tbQuest IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000136 RID: 310
        ' (get) Token: 0x060003E4 RID: 996 RVA: 0x00232A7C File Offset: 0x00231A7C
        ' (set) Token: 0x060003E5 RID: 997 RVA: 0x00232A90 File Offset: 0x00231A90
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

        ' Token: 0x17000137 RID: 311
        ' (get) Token: 0x060003E6 RID: 998 RVA: 0x00232AC8 File Offset: 0x00231AC8
        ' (set) Token: 0x060003E7 RID: 999 RVA: 0x00232AAC File Offset: 0x00231AAC
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

        ' Token: 0x17000138 RID: 312
        ' (get) Token: 0x060003E8 RID: 1000 RVA: 0x00232AF8 File Offset: 0x00231AF8
        ' (set) Token: 0x060003E9 RID: 1001 RVA: 0x00232ADC File Offset: 0x00231ADC
        Friend Overridable Property nudQuestEntry() As NumericUpDown
            Get
                Return Me._nudQuestEntry
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudQuestEntry IsNot Nothing Then
                End If
                Me._nudQuestEntry = value
                If Me._nudQuestEntry IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000139 RID: 313
        ' (get) Token: 0x060003EA RID: 1002 RVA: 0x00232B0C File Offset: 0x00231B0C
        ' (set) Token: 0x060003EB RID: 1003 RVA: 0x00232B20 File Offset: 0x00231B20
        Friend Overridable Property btnShowLists() As Button
            Get
                Return Me._btnShowLists
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnShowLists IsNot Nothing Then
                    RemoveHandler Me._btnShowLists.Click, AddressOf Me.btnShowLists_Click
                End If
                Me._btnShowLists = value
                If Me._btnShowLists IsNot Nothing Then
                    AddHandler Me._btnShowLists.Click, AddressOf Me.btnShowLists_Click
                End If
            End Set
        End Property

        ' Token: 0x1700013A RID: 314
        ' (get) Token: 0x060003EC RID: 1004 RVA: 0x00232B74 File Offset: 0x00231B74
        ' (set) Token: 0x060003ED RID: 1005 RVA: 0x00232B88 File Offset: 0x00231B88
        Friend Overridable Property cmbxFadeType() As ComboBox
            Get
                Return Me._cmbxFadeType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxFadeType IsNot Nothing Then
                End If
                Me._cmbxFadeType = value
                If Me._cmbxFadeType IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700013B RID: 315
        ' (get) Token: 0x060003EE RID: 1006 RVA: 0x00232BA4 File Offset: 0x00231BA4
        ' (set) Token: 0x060003EF RID: 1007 RVA: 0x00232BB8 File Offset: 0x00231BB8
        Friend Overridable Property nudFadeColorR() As NumericUpDown
            Get
                Return Me._nudFadeColorR
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudFadeColorR IsNot Nothing Then
                End If
                Me._nudFadeColorR = value
                If Me._nudFadeColorR IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700013C RID: 316
        ' (get) Token: 0x060003F0 RID: 1008 RVA: 0x00232BD4 File Offset: 0x00231BD4
        ' (set) Token: 0x060003F1 RID: 1009 RVA: 0x00232BE8 File Offset: 0x00231BE8
        Friend Overridable Property cmbxCamVidEffect() As ComboBox
            Get
                Return Me._cmbxCamVidEffect
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxCamVidEffect IsNot Nothing Then
                End If
                Me._cmbxCamVidEffect = value
                If Me._cmbxCamVidEffect IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700013D RID: 317
        ' (get) Token: 0x060003F2 RID: 1010 RVA: 0x00232C58 File Offset: 0x00231C58
        ' (set) Token: 0x060003F3 RID: 1011 RVA: 0x00232C04 File Offset: 0x00231C04
        Friend Overridable Property chkbAnimatedCut() As CheckBox
            Get
                Return Me._chkbAnimatedCut
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbAnimatedCut IsNot Nothing Then
                    RemoveHandler Me._chkbAnimatedCut.CheckedChanged, AddressOf Me.chkbAnimatedCut_CheckedChanged
                End If
                Me._chkbAnimatedCut = value
                If Me._chkbAnimatedCut IsNot Nothing Then
                    AddHandler Me._chkbAnimatedCut.CheckedChanged, AddressOf Me.chkbAnimatedCut_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x1700013E RID: 318
        ' (get) Token: 0x060003F4 RID: 1012 RVA: 0x00232C6C File Offset: 0x00231C6C
        ' (set) Token: 0x060003F5 RID: 1013 RVA: 0x00232C80 File Offset: 0x00231C80
        Friend Overridable Property tbCameraModel() As TextBox
            Get
                Return Me._tbCameraModel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCameraModel IsNot Nothing Then
                End If
                Me._tbCameraModel = value
                If Me._tbCameraModel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700013F RID: 319
        ' (get) Token: 0x060003F7 RID: 1015 RVA: 0x00232C9C File Offset: 0x00231C9C
        ' (set) Token: 0x060003F6 RID: 1014 RVA: 0x00232CB0 File Offset: 0x00231CB0
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

        ' Token: 0x17000140 RID: 320
        ' (get) Token: 0x060003F8 RID: 1016 RVA: 0x00232CCC File Offset: 0x00231CCC
        ' (set) Token: 0x060003F9 RID: 1017 RVA: 0x00232CE0 File Offset: 0x00231CE0
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

        ' Token: 0x17000141 RID: 321
        ' (get) Token: 0x060003FA RID: 1018 RVA: 0x00232D18 File Offset: 0x00231D18
        ' (set) Token: 0x060003FB RID: 1019 RVA: 0x00232CFC File Offset: 0x00231CFC
        Friend Overridable Property nudCamFieldOfView() As NumericUpDown
            Get
                Return Me._nudCamFieldOfView
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCamFieldOfView IsNot Nothing Then
                End If
                Me._nudCamFieldOfView = value
                If Me._nudCamFieldOfView IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000142 RID: 322
        ' (get) Token: 0x060003FC RID: 1020 RVA: 0x00232D48 File Offset: 0x00231D48
        ' (set) Token: 0x060003FD RID: 1021 RVA: 0x00232D2C File Offset: 0x00231D2C
        Friend Overridable Property MenuItem2() As MenuItem
            Get
                Return Me._MenuItem2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._MenuItem2 IsNot Nothing Then
                End If
                Me._MenuItem2 = value
                If Me._MenuItem2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000143 RID: 323
        ' (get) Token: 0x060003FF RID: 1023 RVA: 0x00232D5C File Offset: 0x00231D5C
        ' (set) Token: 0x060003FE RID: 1022 RVA: 0x00232D70 File Offset: 0x00231D70
        Friend Overridable Property cmiTV_MoveNodeUp() As MenuItem
            Get
                Return Me._cmiTV_MoveNodeUp
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._cmiTV_MoveNodeUp IsNot Nothing Then
                    RemoveHandler Me._cmiTV_MoveNodeUp.Click, AddressOf Me.cmiTV_MoveNodeUp_Click
                End If
                Me._cmiTV_MoveNodeUp = value
                If Me._cmiTV_MoveNodeUp IsNot Nothing Then
                    AddHandler Me._cmiTV_MoveNodeUp.Click, AddressOf Me.cmiTV_MoveNodeUp_Click
                End If
            End Set
        End Property

        ' Token: 0x17000144 RID: 324
        ' (get) Token: 0x06000401 RID: 1025 RVA: 0x00232DC4 File Offset: 0x00231DC4
        ' (set) Token: 0x06000400 RID: 1024 RVA: 0x00232DD8 File Offset: 0x00231DD8
        Friend Overridable Property cmiTV_MoveNodeDown() As MenuItem
            Get
                Return Me._cmiTV_MoveNodeDown
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._cmiTV_MoveNodeDown IsNot Nothing Then
                    RemoveHandler Me._cmiTV_MoveNodeDown.Click, AddressOf Me.cmiTV_MoveNodeDown_Click
                End If
                Me._cmiTV_MoveNodeDown = value
                If Me._cmiTV_MoveNodeDown IsNot Nothing Then
                    AddHandler Me._cmiTV_MoveNodeDown.Click, AddressOf Me.cmiTV_MoveNodeDown_Click
                End If
            End Set
        End Property

        ' Token: 0x17000145 RID: 325
        ' (get) Token: 0x06000402 RID: 1026 RVA: 0x00232E2C File Offset: 0x00231E2C
        ' (set) Token: 0x06000403 RID: 1027 RVA: 0x00232E40 File Offset: 0x00231E40
        Friend Overridable Property tabpagThisFile3() As TabPage
            Get
                Return Me._tabpagThisFile3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagThisFile3 IsNot Nothing Then
                End If
                Me._tabpagThisFile3 = value
                If Me._tabpagThisFile3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000146 RID: 326
        ' (get) Token: 0x06000405 RID: 1029 RVA: 0x00232E5C File Offset: 0x00231E5C
        ' (set) Token: 0x06000404 RID: 1028 RVA: 0x00232E70 File Offset: 0x00231E70
        Friend Overridable Property tbTextActiveScript2() As TextBox
            Get
                Return Me._tbTextActiveScript2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTextActiveScript2 IsNot Nothing Then
                End If
                Me._tbTextActiveScript2 = value
                If Me._tbTextActiveScript2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000147 RID: 327
        ' (get) Token: 0x06000407 RID: 1031 RVA: 0x00232E8C File Offset: 0x00231E8C
        ' (set) Token: 0x06000406 RID: 1030 RVA: 0x00232EA0 File Offset: 0x00231EA0
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

        ' Token: 0x17000148 RID: 328
        ' (get) Token: 0x06000409 RID: 1033 RVA: 0x00232EBC File Offset: 0x00231EBC
        ' (set) Token: 0x06000408 RID: 1032 RVA: 0x00232ED0 File Offset: 0x00231ED0
        Friend Overridable Property tbActionsTakenScript2() As TextBox
            Get
                Return Me._tbActionsTakenScript2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbActionsTakenScript2 IsNot Nothing Then
                End If
                Me._tbActionsTakenScript2 = value
                If Me._tbActionsTakenScript2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000149 RID: 329
        ' (get) Token: 0x0600040A RID: 1034 RVA: 0x00232EEC File Offset: 0x00231EEC
        ' (set) Token: 0x0600040B RID: 1035 RVA: 0x00232F00 File Offset: 0x00231F00
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

        ' Token: 0x0600040D RID: 1037 RVA: 0x002374C8 File Offset: 0x002364C8
        Public Sub New(ByVal EditingPath As String, ByVal KotorVerIndex As Integer)
            Me.New()
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(EditingPath, tvConversation, KotorVerIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.filename = Path.GetFileNameWithoutExtension(EditingPath)
            Me.EditingFilePath = EditingPath
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
        End Sub

        ' Token: 0x0600040E RID: 1038 RVA: 0x00237524 File Offset: 0x00236524
        Public Sub New(ByVal fs As FileStream, ByVal KotorVerIndex As Integer)
            Me.New()
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(fs, tvConversation, KotorVerIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.filename = Path.GetFileNameWithoutExtension(fs.Name)
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
        End Sub

        ' Token: 0x0600040F RID: 1039 RVA: 0x0023757C File Offset: 0x0023657C
        Public Sub New(ByVal bytes As Byte(), ByVal file_name As String, ByVal KotorVerIndex As Integer)
            Me.New()
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(bytes, tvConversation, KotorVerIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.filename = file_name
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
        End Sub

        ' Token: 0x06000410 RID: 1040 RVA: 0x002375CC File Offset: 0x002365CC
        Public Sub SetupForNewDialog()
            Me.tvConversation.Nodes.Clear()
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(tvConversation, Me.KotorVersionIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.gff = Me.clsdlg.dlgGff
            Me.gff.AddFieldToStruct("", "DelayEntry", 4, 0)
            Me.gff.AddFieldToStruct("", "DelayReply", 4, 0)
            Me.gff.AddFieldToStruct("", "EndConversation", 11, "")
            Me.gff.AddFieldToStruct("", "EndConverAbort", 11, "")
            Me.gff.AddFieldToStruct("", "Skippable", 0, 0)
            Me.gff.AddFieldToStruct("", "CameraModel", 11, "")
            Me.gff.AddFieldToStruct("", "VO_ID", 10, "")
            Me.gff.AddFieldToStruct("", "ConversationType", 5, 0)
            Me.gff.AddFieldToStruct("", "ComputerType", 0, 0)
            Me.gff.AddFieldToStruct("", "OldHitCheck", 0, 0)
            Me.gff.AddFieldToStruct("", "AmbientTrack", 11, "")
            Me.gff.AddFieldToStruct("", "UnequipItems", 0, 0)
            Me.gff.AddFieldToStruct("", "AnimatedCut", 0, 0)
            Me.gff.AddFieldToStruct("", "UnequipHItem", 0, 0)
        End Sub

        ' Token: 0x06000411 RID: 1041 RVA: 0x002377A4 File Offset: 0x002367A4
        Private Sub SaveFile()
            Dim cursor As Cursor = cursor.Current
            cursor.Current = Cursors.WaitCursor
            Me.EntryList = New ArrayList()
            Me.ReplyList = New ArrayList()
            Me.gff.ClearListElements("EntryList")
            Me.gff.ClearListElements("ReplyList")
            Me.gff.ClearListElements("StartingList")
            Me.gff.ClearListElements("StuntList")
            Me.SeparateNodes(CType(Me.tvConversation.Nodes(0), DLGConvListNode), "Entry")
            Dim num As Integer
            Try
                For Each obj As Object In Me.EntryList
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    Me.struct = Me.CreateGFFStructFromNode(dlgconvListNode)
                    Me.struct.type = num
                    Me.gff.AddListElement("EntryList", Me.struct)
                    Me.gff.CreateList("EntryList(" + StringType.FromInteger(num) + ")", "AnimList")
                    If dlgconvListNode.Animlist IsNot Nothing Then
                        Dim num2 As Integer = 0
                        Dim num3 As Integer = dlgconvListNode.Animlist.Count - 1
                        For i As Integer = num2 To num3
                            Dim gff_Struct As GFF_Struct = New GFF_Struct(2, 0)
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(dlgconvListNode.Animlist(i), Nothing, "Participant", New Object(-1) {}, Nothing, Nothing)))
                            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_word, "Animation", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(dlgconvListNode.Animlist(i), Nothing, "Animation", New Object(-1) {}, Nothing, Nothing)))
                            Me.gff.AddListElement("EntryList(" + StringType.FromInteger(num) + ").AnimList", gff_Struct)
                        Next
                    End If
                    Me.gff.CreateList("EntryList(" + StringType.FromInteger(num) + ")", "RepliesList")
                    num += 1
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            num = 0
            Try
                For Each obj2 As Object In Me.ReplyList
                    Dim dlgconvListNode As DLGConvListNode = CType(obj2, DLGConvListNode)
                    Me.struct = Me.CreateGFFStructFromNode(dlgconvListNode)
                    Me.struct.type = num
                    Me.gff.AddListElement("ReplyList", Me.struct)
                    Me.gff.CreateList("ReplyList(" + StringType.FromInteger(num) + ")", "EntriesList")
                    Me.gff.CreateList("ReplyList(" + StringType.FromInteger(num) + ")", "AnimList")
                    If dlgconvListNode.Animlist IsNot Nothing Then
                        Dim num4 As Integer = 0
                        Dim num5 As Integer = dlgconvListNode.Animlist.Count - 1
                        For j As Integer = num4 To num5
                            Dim gff_Struct2 As GFF_Struct = New GFF_Struct(2, 0)
                            gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(dlgconvListNode.Animlist(j), Nothing, "Participant", New Object(-1) {}, Nothing, Nothing)))
                            gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_word, "Animation", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(dlgconvListNode.Animlist(j), Nothing, "Animation", New Object(-1) {}, Nothing, Nothing)))
                            Me.gff.AddListElement("ReplyList(" + StringType.FromInteger(num) + ").AnimList", gff_Struct2)
                        Next
                    End If
                    num += 1
                Next
            Finally
                Dim enumerator2 As IEnumerator = Nothing
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj3 As Object In Me.tvConversation.Nodes(0).Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj3, DLGConvListNode)
                    Me.BuildGFFLists(dlgconvListNode, "Entry")
                    Dim gff_Struct3 As GFF_Struct = New GFF_Struct(2)
                    gff_Struct3.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.EntryList.IndexOf(dlgconvListNode))
                    Dim text As String
                    If dlgconvListNode.ActiveScript Is Nothing Then
                        text = ""
                    Else
                        text = dlgconvListNode.ActiveScript
                    End If
                    gff_Struct3.fields(1) = New GFF_Field(GFFField.GFF_CResRef, "Active", text)
                    Me.gff.AddListElement("StartingList", gff_Struct3)
                Next
            Finally
                Dim enumerator3 As IEnumerator = Nothing
                If TypeOf enumerator3 Is IDisposable Then
                    CType(enumerator3, IDisposable).Dispose()
                End If
            End Try
            Me.SetDLGRootItemsValues()
            cursor.Current = cursor
            Dim text2 As String
            If StringType.StrCmp(Me.EditingFilePath, "", False) <> 0 Then
                text2 = Me.EditingFilePath
            Else
                text2 = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, Me.filename + ".dlg", "", "", False, True))
            End If
            If StringType.StrCmp(text2, "", False) = 0 Then
                Return
            End If
            Me.gff.WriteFile(text2, "DLG")
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
            Me.Text = "Conversation Editor - " + Path.GetFileNameWithoutExtension(text2) + ".dlg"
        End Sub

        ' Token: 0x06000412 RID: 1042 RVA: 0x00237D24 File Offset: 0x00236D24
        Private Sub SetDLGRootItemsValues()
            If Not Me.gff.VerifyNodeExists("DelayEntry") Then
                Me.gff.AddFieldToStruct("", "DelayEntry", 4, 0)
            End If
            If Not Me.gff.VerifyNodeExists("DelayReply") Then
                Me.gff.AddFieldToStruct("", "DelayReply", 4, 0)
            End If
            If Not Me.gff.VerifyNodeExists("EndConversation") Then
                Me.gff.AddFieldToStruct("", "EndConversation", 11, "")
            End If
            If Not Me.gff.VerifyNodeExists("EndConverAbort") Then
                Me.gff.AddFieldToStruct("", "EndConverAbort", 11, "")
            End If
            If Not Me.gff.VerifyNodeExists("Skippable") Then
                Me.gff.AddFieldToStruct("", "Skippable", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("CameraModel") Then
                Me.gff.AddFieldToStruct("", "CameraModel", 11, "")
            End If
            If Not Me.gff.VerifyNodeExists("VO_ID") Then
                Me.gff.AddFieldToStruct("", "VO_ID", 10, "")
            End If
            If Not Me.gff.VerifyNodeExists("ConversationType") Then
                Me.gff.AddFieldToStruct("", "ConversationType", 5, 0)
            End If
            If Me.cmbxConversationType.SelectedIndex = 1 AndAlso Not Me.gff.VerifyNodeExists("ComputerType") Then
                Me.gff.AddFieldToStruct("", "ComputerType", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("OldHitCheck") Then
                Me.gff.AddFieldToStruct("", "OldHitCheck", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("AmbientTrack") Then
                Me.gff.AddFieldToStruct("", "AmbientTrack", 11, "")
            End If
            If Not Me.gff.VerifyNodeExists("UnequipItems") Then
                Me.gff.AddFieldToStruct("", "UnequipItems", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("UnequipHItem") Then
                Me.gff.AddFieldToStruct("", "UnequipHItem", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("StuntList") Then
                Me.gff.CreateList("", "StuntList")
            End If
            Me.gff.SetNodeValue("DelayEntry", Me.nudDelayEntry.Value)
            Me.gff.SetNodeValue("DelayReply", Me.nudDelayReply.Value)
            Me.gff.SetNodeValue("EndConversation", Me.tbEndConversation.Text.Trim())
            Me.gff.SetNodeValue("EndConverAbort", Me.tbEndConverAbort.Text.Trim())
            Me.gff.SetNodeValue("Skippable", Me.chkbSkippable.Checked)
            Me.gff.SetNodeValue("VO_ID", Me.tbVO_ID.Text.Trim())
            Me.gff.SetNodeValue("ConversationType", Me.cmbxConversationType.SelectedIndex)
            If Me.cmbxConversationType.SelectedIndex = 1 Then
                Me.gff.SetNodeValue("ComputerType", CByte(Me.cmbxComputerType.SelectedIndex))
            End If
            Me.gff.SetNodeValue("AmbientTrack", Me.tbAmbientTrack.Text.Trim())
            Me.gff.SetNodeValue("UnequipItems", Me.chkbUnequipItems.Checked)
            Me.gff.SetNodeValue("UnequipHItem", Me.chkbUnequipHItem.Checked)
            If Me.gff.VerifyNodeExists("AnimatedCut") Then
                Me.chkbAnimatedCut.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("AnimatedCut"))
                If Not Me.gff.VerifyNodeExists("CameraModel") Then
                    Me.gff.AddFieldToStruct("", "CameraModel", 11, "")
                End If
                Me.gff.SetNodeValueFromTextBox(Me.tbCameraModel, "CameraModel")
            ElseIf Me.chkbAnimatedCut.Checked Then
                If Not Me.gff.VerifyNodeExists("AnimatedCut") Then
                    Me.gff.AddFieldToStruct("", "AnimatedCut", 0, 0)
                End If
                Me.gff.SetNodeValue("AnimatedCut", 1)
                If Not Me.gff.VerifyNodeExists("CameraModel") Then
                    Me.gff.AddFieldToStruct("", "CameraModel", 11, "")
                End If
                Me.gff.SetNodeValueFromTextBox(Me.tbCameraModel, "CameraModel")
            End If
            Dim num As Integer = 0
            Dim num2 As Integer = Me.DViewStunt.Table.Rows.Count - 1
            For i As Integer = num To num2
                Dim gff_Struct As GFF_Struct = New GFF_Struct(2, 0)
                gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(Me.DViewStunt.Table.Rows(i)("Participant")))
                gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CResRef, "StuntModel", RuntimeHelpers.GetObjectValue(Me.DViewStunt.Table.Rows(i)("StuntModel")))
                Me.gff.AddListElement("StuntList", gff_Struct)
            Next
        End Sub

        ' Token: 0x06000413 RID: 1043 RVA: 0x002382F4 File Offset: 0x002372F4
        Private Sub SetFormToDLGRootItems()
            Me.gff.SetNumericUpDownToUIntNodeValue(Me.nudDelayEntry, "DelayEntry", 0.0F)
            Me.gff.SetNumericUpDownToUIntNodeValue(Me.nudDelayReply, "DelayReply", 0.0F)
            Me.gff.SetTextBoxToNodeValue(Me.tbEndConversation, "EndConversation")
            Me.gff.SetTextBoxToNodeValue(Me.tbEndConverAbort, "EndConverAbort")
            Me.chkbSkippable.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("Skippable"))
            Me.chkbUnequipItems.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("UnequipItems"))
            Me.chkbUnequipHItem.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("UnequipHItem"))
            Me.gff.SetTextBoxToNodeValue(Me.tbVO_ID, "VO_ID")
            Me.cmbxConversationType.SelectedIndex = IntegerType.FromObject(Me.gff.GetNodeValue("ConversationType"))
            If Me.cmbxConversationType.SelectedIndex = 1 Then
                Me.cmbxComputerType.SelectedIndex = IntegerType.FromObject(Me.gff.GetNodeValue("ComputerType"))
            End If
            Me.gff.SetTextBoxToNodeValue(Me.tbAmbientTrack, "AmbientTrack")
            Me.gff.SetTextBoxToNodeValue(Me.tbCameraModel, "CameraModel")
            Me.chkbAnimatedCut.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("AnimatedCut"))
            If Me.gff.VerifyNodeExists("StuntList") AndAlso Me.gff.GetListItemCount("StuntList") > 0 Then
                Dim num As Integer = 0
                Dim num2 As Integer = Me.gff.GetListItemCount("StuntList") - 1
                For i As Integer = num To num2
                    Dim dataRow As DataRow = Me.dtStunt.NewRow()
                    dataRow(0) = RuntimeHelpers.GetObjectValue(Me.gff.GetNodeValue("StuntList(" + StringType.FromInteger(i) + ").Participant"))
                    dataRow(1) = RuntimeHelpers.GetObjectValue(Me.gff.GetNodeValue("StuntList(" + StringType.FromInteger(i) + ").StuntModel"))
                    Me.dtStunt.Rows.Add(dataRow)
                Next
            End If
        End Sub

        ' Token: 0x06000414 RID: 1044 RVA: 0x00238534 File Offset: 0x00237534
        Private Function CreateGFFStructFromNode(ByVal tn As DLGConvListNode) As GFF_Struct
            Dim gff_Struct As GFF_Struct = New GFF_Struct()
            gff_Struct.fieldCount = 4
            gff_Struct.fields = New GFF_Field(gff_Struct.fieldCount - 1 + 1 - 1) {}
            Dim gffexoLocString As GFFExoLocString = New GFFExoLocString()
            gffexoLocString.StringCount = 1
            gffexoLocString.StringRef = -1
            gffexoLocString.subStringArr = CType(Array.CreateInstance(GetType(Object), 1), Object())
            Dim gffexoLocSubString As GFFExoLocSubString = New GFFExoLocSubString()
            gffexoLocSubString.StringID = 0
            gffexoLocSubString.StringLength = tn.InternalText.Length
            gffexoLocSubString.value = tn.InternalText
            gffexoLocString.subStringArr(0) = gffexoLocSubString
            gffexoLocString.size = 16 + tn.InternalText.Length
            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CExoLocString, "Text", gffexoLocString)
            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_dword, "Delay", 4294967295L)
            gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_dword, "WaitFlags", 0)
            gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_byte, "FadeType", tn.FadeType)
            Dim gff_Struct2 As GFF_Struct
            If StringType.StrCmp(tn.Script, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Script, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CResRef, "Script", tn.Script)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Sound, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Sound, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CResRef, "Sound", tn.Sound)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.VO_ResRef, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.VO_ResRef, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CResRef, "VO_ResRef", tn.VO_ResRef)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Speaker, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Speaker, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CExoString, "Speaker", tn.Speaker)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Comment, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Comment, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CExoString, "Comment", tn.Comment)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Listener, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Listener, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CExoString, "Listener", tn.Listener)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If tn.CameraAngle > 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_dword, "CameraAngle", tn.CameraAngle)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Quest, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Quest, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CExoString, "Quest", tn.Quest)
                gff_Struct.fields(gff_Struct.fieldCount + 1) = New GFF_Field(GFFField.GFF_dword, "QuestEntry", tn.QuestEntry)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 2
            End If
            If tn.FadeType > 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 2 + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_float, "FadeDelay", tn.FadeDelay)
                gff_Struct.fields(gff_Struct.fieldCount + 1) = New GFF_Field(GFFField.GFF_float, "FadeLength", tn.FadeLength)
                If tn.FadeColor Is Nothing Then
                    tn.FadeColor = New GFFType17()
                    tn.FadeColor.f1 = 0.0F
                    tn.FadeColor.f2 = 0.0F
                    tn.FadeColor.f3 = 0.0F
                End If
                gff_Struct.fields(gff_Struct.fieldCount + 2) = New GFF_Field(GFFField.GFF_Type17, "FadeColor", tn.FadeColor)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 3
            End If
            gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 + 1 - 1) {}), GFF_Field())
            gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_int, "CameraID", tn.CameraID)
            gff_Struct.fields(gff_Struct.fieldCount + 1) = New GFF_Field(GFFField.GFF_int, "CamVidEffect", tn.CamVidEffect)
            gff_Struct2 = gff_Struct
            gff_Struct2.fieldCount += 2
            Return gff_Struct
        End Function

        ' Token: 0x06000415 RID: 1045 RVA: 0x00238C18 File Offset: 0x00237C18
        Private Sub RemoveChildLinks(ByVal parentNode As DLGConvListNode)
            Try
                For Each obj As Object In parentNode.Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    Me.RemoveChildLinks(dlgconvListNode)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            If parentNode.IsLink > 0 Then
                parentNode.LinkedToNode.LinkedNodesList.Remove(parentNode)
            End If
        End Sub

        ' Token: 0x06000416 RID: 1046 RVA: 0x00238C90 File Offset: 0x00237C90
        Private Sub ResetChildNodesDescAfterPasteTree(ByVal parentNode As DLGConvListNode)
            Try
                For Each obj As Object In parentNode.Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    If parentNode.IsReply Then
                        dlgconvListNode.IsEntry = True
                    Else
                        dlgconvListNode.IsReply = True
                    End If
                    dlgconvListNode.ForeColor = dlgconvListNode.DialogColor
                    Me.ResetChildNodesDescAfterPasteTree(dlgconvListNode)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing

                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            If parentNode IsNot Me.tvConversation.Nodes(0) Then
                parentNode.Text = parentNode.NodeDesc
            End If
        End Sub

        ' Token: 0x06000417 RID: 1047 RVA: 0x00238D30 File Offset: 0x00237D30
        Private Sub SeparateNodes(ByVal innode As DLGConvListNode, ByVal CurrNodeType As String)
            Try
                For Each obj As Object In innode.Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    If StringType.StrCmp(CurrNodeType, "Entry", False) = 0 Then
                        Me.EntryList.Add(dlgconvListNode)
                        Me.SeparateNodes(dlgconvListNode, "Reply")
                    Else
                        Me.ReplyList.Add(dlgconvListNode)
                        Me.SeparateNodes(dlgconvListNode, "Entry")
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000418 RID: 1048 RVA: 0x00238DC8 File Offset: 0x00237DC8
        Private Sub BuildGFFLists(ByVal parentNode As DLGConvListNode, ByVal CurrNodeType As String)
            Try
                For Each obj As Object In parentNode.Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    If StringType.StrCmp(CurrNodeType, "Entry", False) = 0 Then
                        Dim gff_Struct As GFF_Struct = New GFF_Struct(3)
                        If dlgconvListNode.IsLink > 0 Then
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.ReplyList.IndexOf(dlgconvListNode.LinkedToNode))
                        Else
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.ReplyList.IndexOf(dlgconvListNode))
                        End If
                        gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CResRef, "Active", dlgconvListNode.ActiveScript)
                        gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "IsChild", dlgconvListNode.IsLink)
                        Me.gff.AddListElement("EntryList(" + StringType.FromInteger(Me.EntryList.IndexOf(parentNode)) + ").RepliesList", gff_Struct)
                        If Not dlgconvListNode.IsLink > 0 Then
                            Me.BuildGFFLists(dlgconvListNode, "Reply")
                        End If
                    Else
                        Dim gff_Struct As GFF_Struct = New GFF_Struct(3)
                        If dlgconvListNode.IsLink > 0 Then
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.EntryList.IndexOf(dlgconvListNode.LinkedToNode))
                        Else
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.EntryList.IndexOf(dlgconvListNode))
                        End If
                        gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CResRef, "Active", dlgconvListNode.ActiveScript)
                        gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "IsChild", dlgconvListNode.IsLink)
                        Me.gff.AddListElement("ReplyList(" + StringType.FromInteger(Me.ReplyList.IndexOf(parentNode)) + ").EntriesList", gff_Struct)
                        If Not dlgconvListNode.IsLink > 0 Then
                            Me.BuildGFFLists(dlgconvListNode, "Entry")
                        End If
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000419 RID: 1049 RVA: 0x00239008 File Offset: 0x00238008
        Public Sub BuildAnimDataGrid()
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgAnimList.TableStyles.Clear()
            dataGridTableStyle.MappingName = "ArrayList"
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Participant"
            dataGridTextBoxColumn.HeaderText = "Participant"
            dataGridTextBoxColumn.Alignment = HorizontalAlignment.Center
            dataGridTextBoxColumn.Width = 120
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.[ReadOnly] = False
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Animation"
            dataGridTextBoxColumn.HeaderText = "Animation"
            dataGridTextBoxColumn.Alignment = HorizontalAlignment.Center
            dataGridTextBoxColumn.Width = 75
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.CharacterCasing = CharacterCasing.Lower
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Me.dgAnimList.TableStyles.Add(dataGridTableStyle)
            Me.dgAnimList.CaptionText = "Animation List"
            Me.dgAnimList.CaptionFont = New Font("Microsoft Sans Serif", 9.0F)
        End Sub

        ' Token: 0x0600041A RID: 1050 RVA: 0x0023912C File Offset: 0x0023812C
        Public Sub BuildStuntDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Participant", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dtStunt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("StuntModel", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dtStunt.Columns.Add(dataColumn)
            Me.dtStunt.TableName = "StuntList"
        End Sub

        ' Token: 0x0600041B RID: 1051 RVA: 0x002391AC File Offset: 0x002381AC
        Public Sub BuildStuntDataGrid()
            Me.BuildStuntDataTable()
            Me.DViewStunt = Me.dtStunt.DefaultView
            Me.DViewStunt.AllowDelete = True
            Me.DViewStunt.AllowNew = True
            Me.DViewStunt.AllowEdit = True
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgStuntList.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dtStunt.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Participant"
            dataGridTextBoxColumn.HeaderText = "Participant"
            dataGridTextBoxColumn.Alignment = HorizontalAlignment.Center
            dataGridTextBoxColumn.Width = 120
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.[ReadOnly] = False
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "StuntModel"
            dataGridTextBoxColumn.HeaderText = "Model"
            dataGridTextBoxColumn.Alignment = HorizontalAlignment.Center
            dataGridTextBoxColumn.Width = 120
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.CharacterCasing = CharacterCasing.Lower
            dataGridTextBoxColumn.TextBox.MaxLength = 16
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Me.dgStuntList.TableStyles.Add(dataGridTableStyle)
            Me.dgStuntList.SetDataBinding(Me.DViewStunt, Nothing)
            Me.dgStuntList.CaptionText = "Stunt List"
            Me.dgStuntList.CaptionFont = New Font("Microsoft Sans Serif", 9.0F)
        End Sub

        ' Token: 0x0600041C RID: 1052 RVA: 0x00239330 File Offset: 0x00238330
        Private Sub btnExpandAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.tvConversation.ExpandAll()
            Me.tvConversation.SelectedNode = Me.tvConversation.Nodes(0)
        End Sub

        ' Token: 0x0600041D RID: 1053 RVA: 0x0023935C File Offset: 0x0023835C
        Private Sub btnCollapseAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.tvConversation.CollapseAll()
        End Sub

        ' Token: 0x0600041E RID: 1054 RVA: 0x0023936C File Offset: 0x0023836C
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = "dialog"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.clsdlg.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x0600041F RID: 1055 RVA: 0x002393D0 File Offset: 0x002383D0
        Private Sub btnTest_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            Dim dlgconvListNode2 As DLGConvListNode = CType(dlgconvListNode.Parent, DLGConvListNode)
            Dim num As Integer = dlgconvListNode2.Nodes.IndexOf(dlgconvListNode)
            dlgconvListNode2.Nodes.Remove(dlgconvListNode)
            dlgconvListNode2.Nodes.Insert(num - 1, dlgconvListNode)
        End Sub

        ' Token: 0x06000420 RID: 1056 RVA: 0x00239424 File Offset: 0x00238424
        Private Sub btnChooseColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim colorDialog As ColorDialog = New ColorDialog()
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            If dlgconvListNode.FadeColor Is Nothing Then
                dlgconvListNode.FadeColor = New GFFType17()
                dlgconvListNode.FadeColor.f1 = 0.0F
                dlgconvListNode.FadeColor.f2 = 0.0F
                dlgconvListNode.FadeColor.f3 = 0.0F
            End If
            colorDialog.AllowFullOpen = True
            colorDialog.FullOpen = True
            colorDialog.Color = Color.FromArgb(0, CInt(Math.Round(CDbl(dlgconvListNode.FadeColor.f1))), CInt(Math.Round(CDbl(dlgconvListNode.FadeColor.f2))), CInt(Math.Round(CDbl(dlgconvListNode.FadeColor.f3))))
            If colorDialog.ShowDialog() = DialogResult.OK Then
                Me.nudFadeColorR.Text = StringType.FromByte(colorDialog.Color.R)
                Me.nudFadeColorG.Text = StringType.FromByte(colorDialog.Color.G)
                Me.nudFadeColorB.Text = StringType.FromByte(colorDialog.Color.B)
                dlgconvListNode.FadeColor.f1 = Convert.ToSingle(colorDialog.Color.R)
                dlgconvListNode.FadeColor.f2 = Convert.ToSingle(colorDialog.Color.G)
                dlgconvListNode.FadeColor.f3 = Convert.ToSingle(colorDialog.Color.B)
            End If
        End Sub

        ' Token: 0x06000421 RID: 1057 RVA: 0x002395A0 File Offset: 0x002385A0
        Private Sub WireUpEventHandlers()
            AddHandler Me.tbConversationText.TextChanged, AddressOf Me.tbConversationText_TextChanged
            AddHandler Me.tbTextActiveScript.TextChanged, AddressOf Me.tbTextActiveScript_TextChanged
            AddHandler Me.tbActionsTakenScript.TextChanged, AddressOf Me.tbActionsTakenScript_TextChanged
            AddHandler Me.nudPlotIndex.ValueChanged, AddressOf Me.nudPlotIndex_ValueChanged
            AddHandler Me.nudPlotXPPercentage.ValueChanged, AddressOf Me.nudPlotXPPercentage_ValueChanged
            AddHandler Me.tbComments.TextChanged, AddressOf Me.tbComments_TextChanged
            AddHandler Me.nudCameraAngle.ValueChanged, AddressOf Me.nudCameraAngle_ValueChanged
            AddHandler Me.nudCamHeightOffset.ValueChanged, AddressOf Me.nudCamHeightOffset_ValueChanged
            AddHandler Me.nudTarHeightOffset.ValueChanged, AddressOf Me.nudTarHeightOffset_ValueChanged
            AddHandler Me.tbListener.TextChanged, AddressOf Me.tbListener_TextChanged
            AddHandler Me.nudFadeDelay.ValueChanged, AddressOf Me.nudFadeDelay_ValueChanged
            AddHandler Me.nudFadeLength.ValueChanged, AddressOf Me.nudFadeLength_ValueChanged
            AddHandler Me.nudFadeColorR.ValueChanged, AddressOf Me.nudFadeColorR_ValueChanged
            AddHandler Me.nudFadeColorG.ValueChanged, AddressOf Me.nudFadeColorG_ValueChanged
            AddHandler Me.nudFadeColorB.ValueChanged, AddressOf Me.nudFadeColorB_ValueChanged
            AddHandler Me.tbSound.TextChanged, AddressOf Me.tbSound_TextChanged
            AddHandler Me.tbSpeaker.TextChanged, AddressOf Me.tbSpeaker_TextChanged
            AddHandler Me.tbVoiceOverResRef.TextChanged, AddressOf Me.tbVoiceOverResRef_TextChanged
            AddHandler Me.nudCameraID.ValueChanged, AddressOf Me.nudCameraID_ValueChanged
            AddHandler Me.cmbxCamVidEffect.SelectedIndexChanged, AddressOf Me.cmbxCamVidEffect_SelectedIndexChanged
            AddHandler Me.nudPlotIndex.Validated, AddressOf Me.nudPlotIndex_ValueChanged
            AddHandler Me.nudPlotXPPercentage.Validated, AddressOf Me.nudPlotXPPercentage_ValueChanged
            AddHandler Me.nudCameraAngle.Validated, AddressOf Me.nudCameraAngle_ValueChanged
            AddHandler Me.nudCamHeightOffset.Validated, AddressOf Me.nudCamHeightOffset_ValueChanged
            AddHandler Me.nudTarHeightOffset.Validated, AddressOf Me.nudTarHeightOffset_ValueChanged
            AddHandler Me.nudFadeDelay.Validated, AddressOf Me.nudFadeDelay_ValueChanged
            AddHandler Me.nudFadeLength.Validated, AddressOf Me.nudFadeLength_ValueChanged
            AddHandler Me.nudFadeColorR.Validated, AddressOf Me.nudFadeColorR_ValueChanged
            AddHandler Me.nudFadeColorG.Validated, AddressOf Me.nudFadeColorG_ValueChanged
            AddHandler Me.nudFadeColorB.Validated, AddressOf Me.nudFadeColorB_ValueChanged
            AddHandler Me.nudCameraID.Validated, AddressOf Me.nudCameraID_ValueChanged
            AddHandler Me.nudFadeColorB.ValueChanged, AddressOf Me.nudFadeColorB_ValueChanged
            AddHandler Me.tbQuest.TextChanged, AddressOf Me.tbQuest_TextChanged
            AddHandler Me.nudQuestEntry.Validated, AddressOf Me.nudQuestEntry_ValueChanged
            AddHandler Me.cmbxFadeType.SelectedIndexChanged, AddressOf Me.cmbxFadeType_SelectedIndexChanged
            AddHandler Me.nudCamFieldOfView.ValueChanged, AddressOf Me.nudCamFieldOfView_ValueChanged
            AddHandler Me.nudCamFieldOfView.Validated, AddressOf Me.nudCamFieldOfView_ValueChanged
        End Sub

        ' Token: 0x06000422 RID: 1058 RVA: 0x00239928 File Offset: 0x00238928
        Private Sub DisconnectEventHandlers()
            RemoveHandler Me.tbConversationText.TextChanged, AddressOf Me.tbConversationText_TextChanged
            RemoveHandler Me.tbTextActiveScript.TextChanged, AddressOf Me.tbTextActiveScript_TextChanged
            RemoveHandler Me.tbActionsTakenScript.TextChanged, AddressOf Me.tbActionsTakenScript_TextChanged
            RemoveHandler Me.nudPlotIndex.ValueChanged, AddressOf Me.nudPlotIndex_ValueChanged
            RemoveHandler Me.nudPlotXPPercentage.ValueChanged, AddressOf Me.nudPlotXPPercentage_ValueChanged
            RemoveHandler Me.tbComments.TextChanged, AddressOf Me.tbComments_TextChanged
            RemoveHandler Me.nudCameraAngle.ValueChanged, AddressOf Me.nudCameraAngle_ValueChanged
            RemoveHandler Me.nudCamHeightOffset.ValueChanged, AddressOf Me.nudCamHeightOffset_ValueChanged
            RemoveHandler Me.nudTarHeightOffset.ValueChanged, AddressOf Me.nudTarHeightOffset_ValueChanged
            RemoveHandler Me.tbListener.TextChanged, AddressOf Me.tbListener_TextChanged
            RemoveHandler Me.nudFadeDelay.ValueChanged, AddressOf Me.nudFadeDelay_ValueChanged
            RemoveHandler Me.nudFadeLength.ValueChanged, AddressOf Me.nudFadeLength_ValueChanged
            RemoveHandler Me.nudFadeColorR.ValueChanged, AddressOf Me.nudFadeColorR_ValueChanged
            RemoveHandler Me.nudFadeColorG.ValueChanged, AddressOf Me.nudFadeColorG_ValueChanged
            RemoveHandler Me.nudFadeColorB.ValueChanged, AddressOf Me.nudFadeColorB_ValueChanged
            RemoveHandler Me.tbSound.TextChanged, AddressOf Me.tbSound_TextChanged
            RemoveHandler Me.tbSpeaker.TextChanged, AddressOf Me.tbSpeaker_TextChanged
            RemoveHandler Me.tbVoiceOverResRef.TextChanged, AddressOf Me.tbVoiceOverResRef_TextChanged
            RemoveHandler Me.nudCameraID.ValueChanged, AddressOf Me.nudCameraID_ValueChanged
            RemoveHandler Me.cmbxCamVidEffect.SelectedIndexChanged, AddressOf Me.cmbxCamVidEffect_SelectedIndexChanged
            RemoveHandler Me.nudPlotIndex.Validated, AddressOf Me.nudPlotIndex_ValueChanged
            RemoveHandler Me.nudPlotXPPercentage.Validated, AddressOf Me.nudPlotXPPercentage_ValueChanged
            RemoveHandler Me.nudCameraAngle.Validated, AddressOf Me.nudCameraAngle_ValueChanged
            RemoveHandler Me.nudCamHeightOffset.Validated, AddressOf Me.nudCamHeightOffset_ValueChanged
            RemoveHandler Me.nudTarHeightOffset.Validated, AddressOf Me.nudTarHeightOffset_ValueChanged
            RemoveHandler Me.nudFadeDelay.Validated, AddressOf Me.nudFadeDelay_ValueChanged
            RemoveHandler Me.nudFadeLength.Validated, AddressOf Me.nudFadeLength_ValueChanged
            RemoveHandler Me.nudFadeColorR.Validated, AddressOf Me.nudFadeColorR_ValueChanged
            RemoveHandler Me.nudFadeColorG.Validated, AddressOf Me.nudFadeColorG_ValueChanged
            RemoveHandler Me.nudFadeColorB.Validated, AddressOf Me.nudFadeColorB_ValueChanged
            RemoveHandler Me.nudCameraID.Validated, AddressOf Me.nudCameraID_ValueChanged
            RemoveHandler Me.tbQuest.TextChanged, AddressOf Me.tbQuest_TextChanged
            RemoveHandler Me.nudQuestEntry.Validated, AddressOf Me.nudQuestEntry_ValueChanged
            RemoveHandler Me.cmbxFadeType.SelectedIndexChanged, AddressOf Me.cmbxFadeType_SelectedIndexChanged
            RemoveHandler Me.nudCamFieldOfView.ValueChanged, AddressOf Me.nudCamFieldOfView_ValueChanged
            RemoveHandler Me.nudCamFieldOfView.Validated, AddressOf Me.nudCamFieldOfView_ValueChanged
        End Sub

        ' Token: 0x06000423 RID: 1059 RVA: 0x00239C98 File Offset: 0x00238C98
        Private Sub tbConversationText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.InternalText = Me.tbConversationText.Text
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
            dlgconvListNode.UpdateLinkedNodesText()
        End Sub

        ' Token: 0x06000424 RID: 1060 RVA: 0x00239CDC File Offset: 0x00238CDC
        Private Sub tbTextActiveScript_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.ActiveScript = Me.tbTextActiveScript.Text.Trim()
        End Sub

        ' Token: 0x06000425 RID: 1061 RVA: 0x00239D10 File Offset: 0x00238D10
        Private Sub tbActionsTakenScript_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Script = Me.tbActionsTakenScript.Text.Trim()
        End Sub

        ' Token: 0x06000426 RID: 1062 RVA: 0x00239D44 File Offset: 0x00238D44
        Private Sub nudPlotIndex_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.PlotIndex = IntegerType.FromString(Me.nudPlotIndex.Text.Trim())
        End Sub

        ' Token: 0x06000427 RID: 1063 RVA: 0x00239D80 File Offset: 0x00238D80
        Private Sub nudPlotXPPercentage_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.PlotXPPercentage = Me.nudPlotXPPercentage.Value
        End Sub

        ' Token: 0x06000428 RID: 1064 RVA: 0x00239DB0 File Offset: 0x00238DB0
        Private Sub tbComments_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Comment = Me.tbComments.Text.Trim()
        End Sub

        ' Token: 0x06000429 RID: 1065 RVA: 0x00239DE4 File Offset: 0x00238DE4
        Private Sub nudCameraAngle_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CameraAngle = Convert.ToInt32(Me.nudCameraAngle.Value)
            If dlgconvListNode.CameraAngle = 6 Then
                Me.cmbxCamVidEffect.Enabled = True
                Select Case dlgconvListNode.CamVidEffect
                    Case -1
                        Me.cmbxCamVidEffect.SelectedIndex = 0
                        Return
                    Case 0
                        Me.cmbxCamVidEffect.SelectedIndex = 1
                        Return
                    Case 2
                        Me.cmbxCamVidEffect.SelectedIndex = 2
                        Return
                End Select
                Me.cmbxCamVidEffect.SelectedIndex = 0
            Else
                Me.cmbxCamVidEffect.Enabled = False
                Me.cmbxCamVidEffect.SelectedIndex = 0
            End If
        End Sub

        ' Token: 0x0600042A RID: 1066 RVA: 0x00239E9C File Offset: 0x00238E9C
        Private Sub nudCamHeightOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CamHeightOffset = Me.nudCamHeightOffset.Value
        End Sub

        ' Token: 0x0600042B RID: 1067 RVA: 0x00239ECC File Offset: 0x00238ECC
        Private Sub nudTarHeightOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CamHeightOffset = Me.nudTarHeightOffset.Value
        End Sub

        ' Token: 0x0600042C RID: 1068 RVA: 0x00239EFC File Offset: 0x00238EFC
        Private Sub tbListener_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Listener = Me.tbListener.Text.Trim()
        End Sub

        ' Token: 0x0600042D RID: 1069 RVA: 0x00239F30 File Offset: 0x00238F30
        Private Sub nudFadeDelay_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.FadeDelay = Me.nudFadeDelay.Value
        End Sub

        ' Token: 0x0600042E RID: 1070 RVA: 0x00239F60 File Offset: 0x00238F60
        Private Sub nudFadeLength_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.FadeLength = Me.nudFadeLength.Value
        End Sub

        ' Token: 0x0600042F RID: 1071 RVA: 0x00239F90 File Offset: 0x00238F90
        Private Sub nudFadeColorR_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            If dlgconvListNode.FadeColor Is Nothing Then
                dlgconvListNode.FadeColor = New GFFType17()
            End If
            dlgconvListNode.FadeColor.f1 = Convert.ToSingle(Me.nudFadeColorR.Value)
            dlgconvListNode.FadeColor.f2 = Convert.ToSingle(Me.nudFadeColorG.Value)
            dlgconvListNode.FadeColor.f3 = Convert.ToSingle(Me.nudFadeColorB.Value)
        End Sub

        ' Token: 0x06000430 RID: 1072 RVA: 0x0023A014 File Offset: 0x00239014
        Private Sub nudFadeColorG_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            If dlgconvListNode.FadeColor Is Nothing Then
                dlgconvListNode.FadeColor = New GFFType17()
            End If
            dlgconvListNode.FadeColor.f1 = Convert.ToSingle(Me.nudFadeColorR.Value)
            dlgconvListNode.FadeColor.f2 = Convert.ToSingle(Me.nudFadeColorG.Value)
            dlgconvListNode.FadeColor.f3 = Convert.ToSingle(Me.nudFadeColorB.Value)
        End Sub

        ' Token: 0x06000431 RID: 1073 RVA: 0x0023A098 File Offset: 0x00239098
        Private Sub nudFadeColorB_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            If dlgconvListNode.FadeColor Is Nothing Then
                dlgconvListNode.FadeColor = New GFFType17()
            End If
            dlgconvListNode.FadeColor.f1 = Convert.ToSingle(Me.nudFadeColorR.Value)
            dlgconvListNode.FadeColor.f2 = Convert.ToSingle(Me.nudFadeColorG.Value)
            dlgconvListNode.FadeColor.f3 = Convert.ToSingle(Me.nudFadeColorB.Value)
        End Sub

        ' Token: 0x06000432 RID: 1074 RVA: 0x0023A11C File Offset: 0x0023911C
        Private Sub tbSound_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Sound = Me.tbSound.Text.Trim()
        End Sub

        ' Token: 0x06000433 RID: 1075 RVA: 0x0023A150 File Offset: 0x00239150
        Private Sub tbSpeaker_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Speaker = Me.tbSpeaker.Text.Trim()
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
        End Sub

        ' Token: 0x06000434 RID: 1076 RVA: 0x0023A190 File Offset: 0x00239190
        Private Sub tbVoiceOverResRef_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.VO_ResRef = Me.tbVoiceOverResRef.Text.Trim()
        End Sub

        ' Token: 0x06000435 RID: 1077 RVA: 0x0023A1C4 File Offset: 0x002391C4
        Private Sub nudCameraID_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CameraID = Convert.ToInt32(Me.nudCameraID.Value)
        End Sub

        ' Token: 0x06000436 RID: 1078 RVA: 0x0023A1F8 File Offset: 0x002391F8
        Private Sub nudCamFieldOfView_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CamFieldOfView = Me.nudCamFieldOfView.Value
        End Sub

        ' Token: 0x06000437 RID: 1079 RVA: 0x0023A228 File Offset: 0x00239228
        Private Sub cmbxCamVidEffect_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            Select Case Me.cmbxCamVidEffect.SelectedIndex
                Case 0
                    dlgconvListNode.CamVidEffect = -1
                Case 1
                    dlgconvListNode.CamVidEffect = 0
                Case 2
                    dlgconvListNode.CamVidEffect = 2
            End Select
        End Sub

        ' Token: 0x06000438 RID: 1080 RVA: 0x0023A280 File Offset: 0x00239280
        Private Sub tbQuest_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Quest = Me.tbQuest.Text.Trim()
            Me.nudQuestEntry.Enabled = StringType.StrCmp(Me.tbQuest.Text.Trim(), "", False) <> 0
        End Sub

        ' Token: 0x06000439 RID: 1081 RVA: 0x0023A2E0 File Offset: 0x002392E0
        Private Sub nudQuestEntry_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.QuestEntry = Convert.ToUInt32(Me.nudQuestEntry.Value)
        End Sub

        ' Token: 0x0600043A RID: 1082 RVA: 0x0023A314 File Offset: 0x00239314
        Private Sub cmbxFadeType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.FadeType = Me.cmbxFadeType.SelectedIndex
            Dim flag As Boolean = Me.cmbxFadeType.SelectedIndex > 0
            Me.nudFadeDelay.Enabled = flag
            Me.nudFadeLength.Enabled = flag
            Me.nudFadeColorR.Enabled = flag
            Me.nudFadeColorG.Enabled = flag
            Me.nudFadeColorB.Enabled = flag
        End Sub

        ' Token: 0x0600043B RID: 1083 RVA: 0x0023A390 File Offset: 0x00239390
        Private Sub tvConversation_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim point As Point = New Point(e.X, e.Y)
            Dim point2 As Point = point
            Me.LastClickedTvConversationNode = CType(Me.tvConversation.GetNodeAt(point2), DLGConvListNode)
        End Sub

        ' Token: 0x0600043C RID: 1084 RVA: 0x0023A3CC File Offset: 0x002393CC
        Private Sub tvConversation_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim point As Point = New Point(e.X, e.Y)
            Dim point2 As Point = point
            Dim lastClickedTvConversationNode As DLGConvListNode = Me.LastClickedTvConversationNode
            If lastClickedTvConversationNode IsNot Nothing Then
                Me.CurrentContextMenuTvConversationNode = lastClickedTvConversationNode
            End If
            If e.Button = MouseButtons.Right Then
                If lastClickedTvConversationNode IsNot Nothing Then
                    Me.AdjustContextMenuItems()
                    Me.cmTVfunctions.Show(Me.tvConversation, point2)
                    Me.tvConversation.SelectedNode = Me.CurrentContextMenuTvConversationNode
                End If
            ElseIf e.Button = MouseButtons.Left AndAlso lastClickedTvConversationNode IsNot Nothing AndAlso e.X < lastClickedTvConversationNode.Bounds.Left Then
                Return
            End If
        End Sub

        ' Token: 0x0600043D RID: 1085 RVA: 0x0023A464 File Offset: 0x00239464
        Private Sub tvConversation_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(CType(sender, TreeView).SelectedNode, DLGConvListNode)
            Me.AdjustTabPagesEnabledState(dlgconvListNode)
            If dlgconvListNode Is Me.tvConversation.Nodes(0) Then
                Return
            End If
            Me.tbLinkID.Text = StringType.FromInteger(dlgconvListNode.LinkID)
            If dlgconvListNode.LinkedNodesList Is Nothing Then
                Me.tbLinkedCnt.Text = "(empty)"
            Else
                Me.tbLinkedCnt.Text = StringType.FromInteger(dlgconvListNode.LinkedNodesList.Count)
            End If
            If dlgconvListNode.LinkedToNode Is Nothing Then
                Me.tbSharedCnt.Text = "(none)"
            Else
                Me.tbSharedCnt.Text = StringType.FromInteger(dlgconvListNode.LinkedToNode.LinkedNodesList.Count)
            End If
            Me.tbLinkDesc.Text = dlgconvListNode.LinkDesc
            Me.DisconnectEventHandlers()
            Me.tbConversationText.Text = dlgconvListNode.InternalText
            Me.tbTextActiveScript.Text = dlgconvListNode.ActiveScript
            Me.tbSound.Text = dlgconvListNode.Sound
            Me.tbComments.Text = dlgconvListNode.Comment
            Me.tbSound.Text = dlgconvListNode.Sound
            Me.tbActionsTakenScript.Text = dlgconvListNode.Script
            Me.tbSpeaker.Text = dlgconvListNode.Speaker
            Me.nudCameraAngle.Value = New Decimal(dlgconvListNode.CameraAngle)
            If dlgconvListNode.CameraAngle = 6 Then
                Me.cmbxCamVidEffect.Enabled = True
                Select Case dlgconvListNode.CamVidEffect
                    Case -1
                        Me.cmbxCamVidEffect.SelectedIndex = 0
                        GoTo IL_01DA
                    Case 0
                        Me.cmbxCamVidEffect.SelectedIndex = 1
                        GoTo IL_01DA
                    Case 2
                        Me.cmbxCamVidEffect.SelectedIndex = 2
                        GoTo IL_01DA
                End Select
                Me.cmbxCamVidEffect.SelectedIndex = 0
            Else
                Me.cmbxCamVidEffect.Enabled = False
                Me.cmbxCamVidEffect.SelectedIndex = 0
            End If
IL_01DA:
            Me.nudCameraID.Value = New Decimal(dlgconvListNode.CameraID)
            Me.cmbxFadeType.SelectedIndex = dlgconvListNode.FadeType
            Dim flag As Boolean = Me.cmbxFadeType.SelectedIndex > 0
            Me.nudFadeDelay.Enabled = flag
            Me.nudFadeLength.Enabled = flag
            Me.nudFadeColorR.Enabled = flag
            Me.nudFadeColorG.Enabled = flag
            Me.nudFadeColorB.Enabled = flag
            Me.tbListener.Text = dlgconvListNode.Listener
            Me.nudPlotIndex.Value = New Decimal(dlgconvListNode.PlotIndex)
            Me.nudPlotXPPercentage.Value = dlgconvListNode.PlotXPPercentage
            Me.tbVoiceOverResRef.Text = dlgconvListNode.VO_ResRef
            Me.nudCamHeightOffset.Value = dlgconvListNode.CamHeightOffset
            Me.nudTarHeightOffset.Value = dlgconvListNode.TarHeightOffset
            Me.nudFadeDelay.Value = dlgconvListNode.FadeDelay
            Me.nudFadeLength.Value = dlgconvListNode.FadeLength
            If dlgconvListNode.FadeColor IsNot Nothing Then
                Me.nudFadeColorR.Text = StringType.FromByte(Convert.ToByte(dlgconvListNode.FadeColor.f1))
                Me.nudFadeColorG.Text = StringType.FromByte(Convert.ToByte(dlgconvListNode.FadeColor.f2))
                Me.nudFadeColorB.Text = StringType.FromByte(Convert.ToByte(dlgconvListNode.FadeColor.f3))
            Else
                Me.nudFadeColorR.Text = ""
                Me.nudFadeColorG.Text = ""
                Me.nudFadeColorB.Text = ""
            End If
            Me.dgAnimList.SetDataBinding(dlgconvListNode.Animlist, Nothing)
            Me.dgAnimList.DataSource = dlgconvListNode.Animlist
            If StringType.StrCmp(dlgconvListNode.Quest, Nothing, False) = 0 Then
                Me.tbQuest.Text = ""
                Me.nudQuestEntry.Value = 0D
                Me.nudQuestEntry.Enabled = False
            Else
                Me.tbQuest.Text = dlgconvListNode.Quest
                Me.nudQuestEntry.Value = Convert.ToDecimal(dlgconvListNode.QuestEntry)
                Me.nudQuestEntry.Enabled = True
            End If
            If Me.chkbAnimatedCut.Checked Then
                Me.nudCamFieldOfView.Value = dlgconvListNode.CamFieldOfView
            End If
            Me.WireUpEventHandlers()
        End Sub

        ' Token: 0x0600043E RID: 1086 RVA: 0x0023A89C File Offset: 0x0023989C
        Private Sub cmiTV_Add_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.LastClickedTvConversationNode.IsLink > 0 Then
                Return
            End If
            Dim dlgconvListNode As DLGConvListNode = New DLGConvListNode()
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.tbValue.Multiline = True
            frmPromptForString.tbValue.AcceptsReturn = False
            frmPromptForString.tbValue.AcceptsTab = False
            Dim form As Form = frmPromptForString
            Dim size As Size = New Size(300, 272)
            form.Size = size
            Dim tbValue As Control = frmPromptForString.tbValue
            size = New Size(232, 96)
            tbValue.Size = size
            If Me.LastClickedTvConversationNode.IsReply Then
                frmPromptForString.lblMsg.Text = "Enter what the NPC says:"
            Else
                frmPromptForString.lblMsg.Text = "Enter what the PC says:"
            End If
            If frmPromptForString.ShowDialog(Me) = DialogResult.OK Then
                dlgconvListNode.InternalText = frmPromptForString.tbValue.Text.Trim()
                If Me.LastClickedTvConversationNode.IsReply Then
                    dlgconvListNode.IsEntry = True
                Else
                    dlgconvListNode.IsReply = True
                    dlgconvListNode.Speaker = ""
                End If
                dlgconvListNode.Text = dlgconvListNode.NodeDesc
                dlgconvListNode.ForeColor = dlgconvListNode.DialogColor
                Me.LastClickedTvConversationNode.Nodes.Add(dlgconvListNode)
                If Me.LastClickedTvConversationNode IsNot Me.tvConversation.Nodes(0) Then
                    Me.LastClickedTvConversationNode.Text = Me.LastClickedTvConversationNode.NodeDesc
                End If
                dlgconvListNode.EnsureVisible()
                Me.tvConversation.SelectedNode = dlgconvListNode
            End If
        End Sub

        ' Token: 0x0600043F RID: 1087 RVA: 0x0023AA04 File Offset: 0x00239A04
        Private Sub cmiTV_Copy_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ClipBoardNode = Me.CurrentContextMenuTvConversationNode
        End Sub

        ' Token: 0x06000440 RID: 1088 RVA: 0x0023AA14 File Offset: 0x00239A14
        Private Sub cmiTV_Paste_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = Me.ClipBoardNode.Copy()
            If Me.LastClickedTvConversationNode.IsReply Then
                dlgconvListNode.IsEntry = True
            Else
                dlgconvListNode.IsReply = True
                dlgconvListNode.Speaker = ""
            End If
            dlgconvListNode.ForeColor = dlgconvListNode.DialogColor
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
            dlgconvListNode.LinkedNodesList = Nothing
            If dlgconvListNode.IsLink > 0 Then
                If Me.ClipBoardNode.LinkedToNode.LinkedNodesList Is Nothing Then
                    Me.ClipBoardNode.LinkedToNode.LinkedNodesList = New ArrayList()
                End If
                Me.ClipBoardNode.LinkedToNode.LinkedNodesList.Add(dlgconvListNode)
            End If
            Me.LastClickedTvConversationNode.Nodes.Add(dlgconvListNode)
            Me.LastClickedTvConversationNode.Text = Me.LastClickedTvConversationNode.NodeDesc
            dlgconvListNode.EnsureVisible()
        End Sub

        ' Token: 0x06000441 RID: 1089 RVA: 0x0023AAEC File Offset: 0x00239AEC
        Private Sub cmiTV_PasteTree_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim clipBoardNode As DLGConvListNode = Me.ClipBoardNode
            If Me.LastClickedTvConversationNode.IsReply Then
                clipBoardNode.IsEntry = True
            Else
                clipBoardNode.IsReply = True
                clipBoardNode.Speaker = ""
            End If
            clipBoardNode.ForeColor = clipBoardNode.DialogColor
            clipBoardNode.Text = clipBoardNode.NodeDesc
            clipBoardNode.LinkedNodesList = Nothing
            If clipBoardNode.IsLink > 0 Then
                If Me.ClipBoardNode.LinkedToNode.LinkedNodesList Is Nothing Then
                    Me.ClipBoardNode.LinkedToNode.LinkedNodesList = New ArrayList()
                End If
                Me.ClipBoardNode.LinkedToNode.LinkedNodesList.Add(clipBoardNode)
            End If
            Me.LastClickedTvConversationNode.Nodes.Add(clipBoardNode)
            Me.LastClickedTvConversationNode.Text = Me.LastClickedTvConversationNode.NodeDesc
            clipBoardNode.EnsureVisible()
            Me.ClipBoardNode = Nothing
            Me.ResetChildNodesDescAfterPasteTree(Me.LastClickedTvConversationNode)
        End Sub

        ' Token: 0x06000442 RID: 1090 RVA: 0x0023ABD4 File Offset: 0x00239BD4
        Private Sub cmiTV_PasteAsLink_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = Me.ClipBoardNode.Copy()
            dlgconvListNode.IsLink = Byte.MaxValue
            dlgconvListNode.LinkedNodesList = Nothing
            dlgconvListNode.LinkedToNode = Me.ClipBoardNode
            If Me.ClipBoardNode.LinkedNodesList Is Nothing Then
                Me.ClipBoardNode.LinkedNodesList = New ArrayList()
            End If
            Me.ClipBoardNode.LinkedNodesList.Add(dlgconvListNode)
            dlgconvListNode.ForeColor = dlgconvListNode.DialogColor
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
            Me.LastClickedTvConversationNode.Nodes.Add(dlgconvListNode)
            Me.LastClickedTvConversationNode.Text = Me.LastClickedTvConversationNode.NodeDesc
            Me.LastClickedTvConversationNode.ForeColor = Me.LastClickedTvConversationNode.DialogColor
            dlgconvListNode.EnsureVisible()
        End Sub

        ' Token: 0x06000443 RID: 1091 RVA: 0x0023AC98 File Offset: 0x00239C98
        Private Sub cmiTV_Cut_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ClipBoardNode = Me.CurrentContextMenuTvConversationNode
            Me.RemoveChildLinks(Me.ClipBoardNode)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.ClipBoardNode.Parent, DLGConvListNode)
            Me.ClipBoardNode.Parent.Nodes.Remove(Me.ClipBoardNode)
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
        End Sub

        ' Token: 0x06000444 RID: 1092 RVA: 0x0023ACF8 File Offset: 0x00239CF8
        Private Sub AdjustContextMenuItems()
            Me.cmiTV_Add.Enabled = Not Me.LastClickedTvConversationNode.IsLink > 0
            Me.cmiTV_Copy.Enabled = Me.LastClickedTvConversationNode IsNot Me.tvConversation.Nodes(0)
            Me.cmiTV_Cut.Enabled = Me.LastClickedTvConversationNode IsNot Me.tvConversation.Nodes(0)
            Me.cmiTV_Paste.Enabled = Me.ClipBoardNode IsNot Nothing AndAlso Not Me.LastClickedTvConversationNode.IsLink > 0
            Me.cmiTV_PasteTree.Enabled = Me.ClipBoardNode IsNot Nothing AndAlso Not Me.LastClickedTvConversationNode.IsLink > 0
            Me.cmiTV_PasteAsLink.Enabled = Me.ClipBoardNode IsNot Nothing AndAlso Not Me.ClipBoardNode.IsLink > 0 AndAlso Not Me.LastClickedTvConversationNode.IsLink > 0 AndAlso Me.LastClickedTvConversationNode.IsReply
            If Me.LastClickedTvConversationNode Is Me.tvConversation.Nodes(0) Then
                Me.cmiTV_MoveNodeUp.Enabled = False
                Me.cmiTV_MoveNodeDown.Enabled = False
            Else
                Dim dlgconvListNode As DLGConvListNode = CType(Me.LastClickedTvConversationNode.Parent, DLGConvListNode)
                Me.cmiTV_MoveNodeUp.Enabled = dlgconvListNode.Nodes.IndexOf(Me.LastClickedTvConversationNode) > 0
                Me.cmiTV_MoveNodeDown.Enabled = dlgconvListNode.Nodes.IndexOf(Me.LastClickedTvConversationNode) < dlgconvListNode.Nodes.Count - 1
            End If
        End Sub

        ' Token: 0x06000445 RID: 1093 RVA: 0x0023AE98 File Offset: 0x00239E98
        Private Sub AdjustTabPagesEnabledState(ByVal node As DLGConvListNode)
            If (If((-If(((node Is Me.tvConversation.Nodes(0)) > False), 1S, 0S)), 1S, 0S) Or CShort(node.IsLink)) <> 0S Then
                Me.tabpagActionsTaken.Enabled = False
                Me.tabpagAnimationSound.Enabled = False
                Me.tabpagCamera.Enabled = False
                Me.tabpagComment.Enabled = False
                Me.tabpagPlot.Enabled = False
            Else
                Me.tabpagActionsTaken.Enabled = True
                Me.tabpagAnimationSound.Enabled = True
                Me.tabpagCamera.Enabled = True
                Me.tabpagComment.Enabled = True
                Me.tabpagPlot.Enabled = True
            End If
        End Sub

        ' Token: 0x06000446 RID: 1094 RVA: 0x0023AF44 File Offset: 0x00239F44
        Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenFile()
        End Sub

        ' Token: 0x06000447 RID: 1095 RVA: 0x0023AF4C File Offset: 0x00239F4C
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SaveFile()
        End Sub

        ' Token: 0x06000448 RID: 1096 RVA: 0x0023AF54 File Offset: 0x00239F54
        Private Sub OpenFile()
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultImportLocation, "", "Open DLG files...", "dlg", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim gfffileKotorVersionIndex As Integer = frmMain.GetGFFFileKotorVersionIndex(text)
            Dim fileStream As FileStream = New FileStream(text, FileMode.Open, FileAccess.Read)
            Me.SetupForNewDialog()
            Me.tvConversation.Nodes.Clear()
            Dim fileStream2 As FileStream = fileStream
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(fileStream2, tvConversation, gfffileKotorVersionIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.filename = Path.GetFileNameWithoutExtension(fileStream.Name)
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
            Me.Text = "Conversation Editor - " + Me.filename + ".dlg"
        End Sub

        ' Token: 0x06000449 RID: 1097 RVA: 0x0023B024 File Offset: 0x0023A024
        Private Sub miNew_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetupForNewDialog()
        End Sub

        ' Token: 0x0600044A RID: 1098 RVA: 0x0023B02C File Offset: 0x0023A02C
        Private Sub miOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenFile()
        End Sub

        ' Token: 0x0600044B RID: 1099 RVA: 0x0023B034 File Offset: 0x0023A034
        Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SaveFile()
        End Sub

        ' Token: 0x0600044C RID: 1100 RVA: 0x0023B03C File Offset: 0x0023A03C
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x0600044D RID: 1101 RVA: 0x0023B044 File Offset: 0x0023A044
        Private Sub btnAddAnimListEntry_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.LastClickedTvConversationNode.Animlist Is Nothing Then
                Me.LastClickedTvConversationNode.Animlist = New ArrayList(1)
            End If
            Dim frmCreateAnimListEntry As frmCreateAnimListEntry = New frmCreateAnimListEntry()
            If frmCreateAnimListEntry.ShowDialog(Me) = DialogResult.OK Then
                Me.LastClickedTvConversationNode.Animlist.Add(New AnimListEntry(frmCreateAnimListEntry.Participant, frmCreateAnimListEntry.AnimationNumber))
                Me.dgAnimList.SetDataBinding(Me.LastClickedTvConversationNode.Animlist, Nothing)
                Dim currencyManager As CurrencyManager = CType(Me.dgAnimList.BindingContext(RuntimeHelpers.GetObjectValue(Me.dgAnimList.DataSource)), CurrencyManager)
                If currencyManager IsNot Nothing Then
                    currencyManager.Refresh()
                End If
                Me.dgAnimList.Refresh()
            End If
        End Sub

        ' Token: 0x0600044E RID: 1102 RVA: 0x0023B0F4 File Offset: 0x0023A0F4
        Private Sub btnDeleteAnimListEntry_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim currencyManager As CurrencyManager = CType(Me.dgAnimList.BindingContext(RuntimeHelpers.GetObjectValue(Me.dgAnimList.DataSource)), CurrencyManager)
            Dim position As Integer = currencyManager.Position
            Me.LastClickedTvConversationNode.Animlist.RemoveAt(position)
            If currencyManager IsNot Nothing Then
                currencyManager.Refresh()
            End If
            Me.btnDeleteAnimListEntry.Enabled = False
        End Sub

        ' Token: 0x0600044F RID: 1103 RVA: 0x0023B154 File Offset: 0x0023A154
        Private Sub dgAnimList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dataGrid As DataGrid = CType(sender, DataGrid)
            Dim hitTestInfo As DataGrid.HitTestInfo = dataGrid.HitTest(dataGrid.PointToClient(Control.MousePosition).X, dataGrid.PointToClient(Control.MousePosition).Y)
            If (hitTestInfo.Type = dataGrid.HitTestType.RowHeader) Or (hitTestInfo.Type = dataGrid.HitTestType.Cell) Then
                Me.dgAnimList.[Select](hitTestInfo.Row)
                Me.btnDeleteAnimListEntry.Enabled = True
            End If
        End Sub

        ' Token: 0x06000450 RID: 1104 RVA: 0x0023B1C8 File Offset: 0x0023A1C8
        Private Sub dgAnimList_Validated(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnDeleteAnimListEntry.Enabled = False
        End Sub

        ' Token: 0x06000451 RID: 1105 RVA: 0x0023B1D8 File Offset: 0x0023A1D8
        Private Sub trkbTVIndent_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            Me.tvConversation.Indent = Me.trkbTVIndent.Value
        End Sub

        ' Token: 0x06000452 RID: 1106 RVA: 0x0023B1F0 File Offset: 0x0023A1F0
        Private Sub trkbTVItemHeight_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            ' The following expression was wrapped in a checked-expression
            Me.tvConversation.ItemHeight = Me.trkbTVItemHeight.Value * 2
        End Sub

        ' Token: 0x06000453 RID: 1107 RVA: 0x0023B20C File Offset: 0x0023A20C
        Private Sub cmbxConversationType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.cmbxComputerType.Enabled = Me.cmbxConversationType.SelectedIndex = 1
        End Sub

        ' Token: 0x06000454 RID: 1108 RVA: 0x0023B228 File Offset: 0x0023A228
        Private Sub btnShowLists_Click(ByVal sender As Object, ByVal e As EventArgs)
            Console.WriteLine("-----------------------------------------")
            Console.WriteLine("Entries")
            Console.WriteLine("-----------------------------------------")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.gff.GetListItemCount("EntryList") - 1
            For i As Integer = num To num2
                Console.Write("Entry " + StringType.FromInteger(i) + ": ")
                If Me.gff.GetListItemCount("EntryList(" + StringType.FromInteger(i) + ").RepliesList") > 0 Then
                    Dim num3 As Integer = 0
                    Dim num4 As Integer = Me.gff.GetListItemCount("EntryList(" + StringType.FromInteger(i) + ").RepliesList") - 1
                    For j As Integer = num3 To num4
                        Console.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.gff.GetNodeValue(String.Concat(New String() {"EntryList(", StringType.FromInteger(i), ").RepliesList(", StringType.FromInteger(j), ").Index"})))))
                        If ObjectType.ObjTst(Me.gff.GetNodeValue(String.Concat(New String() {"EntryList(", StringType.FromInteger(i), ").RepliesList(", StringType.FromInteger(j), ").IsChild"})), 0, False) > 0 Then
                            Console.Write(" (L), ")
                        Else
                            Console.Write(", ")
                        End If
                    Next
                End If
                Console.WriteLine()
            Next
            Console.WriteLine("-----------------------------------------")
            Console.WriteLine("Replies")
            Console.WriteLine("-----------------------------------------")
            Dim num5 As Integer = 0
            Dim num6 As Integer = Me.gff.GetListItemCount("ReplyList") - 1
            For i As Integer = num5 To num6
                Console.Write("Entry " + StringType.FromInteger(i) + ": ")
                If Me.gff.GetListItemCount("ReplyList(" + StringType.FromInteger(i) + ").EntriesList") > 0 Then
                    Dim num7 As Integer = 0
                    Dim num8 As Integer = Me.gff.GetListItemCount("ReplyList(" + StringType.FromInteger(i) + ").EntriesList") - 1
                    For j As Integer = num7 To num8
                        Console.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.gff.GetNodeValue(String.Concat(New String() {"ReplyList(", StringType.FromInteger(i), ").EntriesList(", StringType.FromInteger(j), ").Index"})))))
                        If ObjectType.ObjTst(Me.gff.GetNodeValue(String.Concat(New String() {"ReplyList(", StringType.FromInteger(i), ").EntriesList(", StringType.FromInteger(j), ").IsChild"})), 0, False) > 0 Then
                            Console.Write(" (L), ")
                        Else
                            Console.Write(", ")
                        End If
                    Next
                End If
                Console.WriteLine()
            Next
            Console.WriteLine("-----------------------------------------")
        End Sub

        ' Token: 0x06000455 RID: 1109 RVA: 0x0023B54C File Offset: 0x0023A54C
        Private Sub chkbAnimatedCut_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.tbCameraModel.Enabled = CType(sender, CheckBox).Checked
            Me.nudCamFieldOfView.Enabled = CType(sender, CheckBox).Checked
        End Sub

        ' Token: 0x06000456 RID: 1110 RVA: 0x0023B57C File Offset: 0x0023A57C
        Private Sub cmiTV_MoveNodeUp_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            Dim dlgconvListNode2 As DLGConvListNode = CType(dlgconvListNode.Parent, DLGConvListNode)
            Dim num As Integer = dlgconvListNode2.Nodes.IndexOf(dlgconvListNode)
            dlgconvListNode2.Nodes.Remove(dlgconvListNode)
            dlgconvListNode2.Nodes.Insert(num - 1, dlgconvListNode)
            Me.tvConversation.SelectedNode = dlgconvListNode
        End Sub

        ' Token: 0x06000457 RID: 1111 RVA: 0x0023B5DC File Offset: 0x0023A5DC
        Private Sub cmiTV_MoveNodeDown_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            Dim dlgconvListNode2 As DLGConvListNode = CType(dlgconvListNode.Parent, DLGConvListNode)
            Dim num As Integer = dlgconvListNode2.Nodes.IndexOf(dlgconvListNode)
            dlgconvListNode2.Nodes.Remove(dlgconvListNode)
            If num = dlgconvListNode2.Nodes.Count - 1 Then
                dlgconvListNode2.Nodes.Add(dlgconvListNode)
            Else
                dlgconvListNode2.Nodes.Insert(num + 1, dlgconvListNode)
            End If
            Me.tvConversation.SelectedNode = dlgconvListNode
        End Sub

        ' Token: 0x040001E0 RID: 480
        <AccessedThroughProperty("nudCameraID")> _
        Private _nudCameraID As NumericUpDown

        ' Token: 0x040001E1 RID: 481
        <AccessedThroughProperty("Label13")> _
        Private _Label13 As Label

        ' Token: 0x040001E2 RID: 482
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x040001E3 RID: 483
        <AccessedThroughProperty("nudPlotIndex")> _
        Private _nudPlotIndex As NumericUpDown

        ' Token: 0x040001E4 RID: 484
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x040001E5 RID: 485
        <AccessedThroughProperty("Label16")> _
        Private _Label16 As Label

        ' Token: 0x040001E6 RID: 486
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x040001E7 RID: 487
        <AccessedThroughProperty("Label17")> _
        Private _Label17 As Label

        ' Token: 0x040001E8 RID: 488
        <AccessedThroughProperty("Label18")> _
        Private _Label18 As Label

        ' Token: 0x040001E9 RID: 489
        <AccessedThroughProperty("tbListener")> _
        Private _tbListener As TextBox

        ' Token: 0x040001EA RID: 490
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x040001EB RID: 491
        <AccessedThroughProperty("Label19")> _
        Private _Label19 As Label

        ' Token: 0x040001EC RID: 492
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x040001ED RID: 493
        <AccessedThroughProperty("Label20")> _
        Private _Label20 As Label

        ' Token: 0x040001EE RID: 494
        <AccessedThroughProperty("nudPlotXPPercentage")> _
        Private _nudPlotXPPercentage As NumericUpDown

        ' Token: 0x040001EF RID: 495
        <AccessedThroughProperty("Label21")> _
        Private _Label21 As Label

        ' Token: 0x040001F0 RID: 496
        <AccessedThroughProperty("Label22")> _
        Private _Label22 As Label

        ' Token: 0x040001F1 RID: 497
        <AccessedThroughProperty("btnExpandAll")> _
        Private _btnExpandAll As Button

        ' Token: 0x040001F2 RID: 498
        <AccessedThroughProperty("Label23")> _
        Private _Label23 As Label

        ' Token: 0x040001F3 RID: 499
        <AccessedThroughProperty("nudCamHeightOffset")> _
        Private _nudCamHeightOffset As NumericUpDown

        ' Token: 0x040001F4 RID: 500
        <AccessedThroughProperty("Label24")> _
        Private _Label24 As Label

        ' Token: 0x040001F5 RID: 501
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x040001F6 RID: 502
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x040001F7 RID: 503
        <AccessedThroughProperty("tbVoiceOverResRef")> _
        Private _tbVoiceOverResRef As TextBox

        ' Token: 0x040001F8 RID: 504
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x040001F9 RID: 505
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x040001FA RID: 506
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x040001FB RID: 507
        <AccessedThroughProperty("nudFadeColorB")> _
        Private _nudFadeColorB As NumericUpDown

        ' Token: 0x040001FC RID: 508
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040001FD RID: 509
        <AccessedThroughProperty("Label39")> _
        Private _Label39 As Label

        ' Token: 0x040001FE RID: 510
        <AccessedThroughProperty("tbActionsTakenScript2")> _
        Private _tbActionsTakenScript2 As TextBox

        ' Token: 0x040001FF RID: 511
        <AccessedThroughProperty("btnCollapseAll")> _
        Private _btnCollapseAll As Button

        ' Token: 0x04000200 RID: 512
        <AccessedThroughProperty("Label38")> _
        Private _Label38 As Label

        ' Token: 0x04000201 RID: 513
        <AccessedThroughProperty("tbTextActiveScript2")> _
        Private _tbTextActiveScript2 As TextBox

        ' Token: 0x04000202 RID: 514
        <AccessedThroughProperty("nudTarHeightOffset")> _
        Private _nudTarHeightOffset As NumericUpDown

        ' Token: 0x04000203 RID: 515
        <AccessedThroughProperty("tabpagThisFile3")> _
        Private _tabpagThisFile3 As TabPage

        ' Token: 0x04000204 RID: 516
        <AccessedThroughProperty("cmiTV_MoveNodeDown")> _
        Private _cmiTV_MoveNodeDown As MenuItem

        ' Token: 0x04000205 RID: 517
        <AccessedThroughProperty("cmiTV_MoveNodeUp")> _
        Private _cmiTV_MoveNodeUp As MenuItem

        ' Token: 0x04000206 RID: 518
        <AccessedThroughProperty("lblPlotIndex")> _
        Private _lblPlotIndex As Label

        ' Token: 0x04000207 RID: 519
        <AccessedThroughProperty("nudCamFieldOfView")> _
        Private _nudCamFieldOfView As NumericUpDown

        ' Token: 0x04000208 RID: 520
        <AccessedThroughProperty("Label37")> _
        Private _Label37 As Label

        ' Token: 0x04000209 RID: 521
        <AccessedThroughProperty("Label31")> _
        Private _Label31 As Label

        ' Token: 0x0400020A RID: 522
        <AccessedThroughProperty("nudFadeColorG")> _
        Private _nudFadeColorG As NumericUpDown

        ' Token: 0x0400020B RID: 523
        <AccessedThroughProperty("tbCameraModel")> _
        Private _tbCameraModel As TextBox

        ' Token: 0x0400020C RID: 524
        <AccessedThroughProperty("chkbAnimatedCut")> _
        Private _chkbAnimatedCut As CheckBox

        ' Token: 0x0400020D RID: 525
        <AccessedThroughProperty("tbComments")> _
        Private _tbComments As TextBox

        ' Token: 0x0400020E RID: 526
        <AccessedThroughProperty("cmbxCamVidEffect")> _
        Private _cmbxCamVidEffect As ComboBox

        ' Token: 0x0400020F RID: 527
        <AccessedThroughProperty("nudFadeColorR")> _
        Private _nudFadeColorR As NumericUpDown

        ' Token: 0x04000210 RID: 528
        <AccessedThroughProperty("cmbxFadeType")> _
        Private _cmbxFadeType As ComboBox

        ' Token: 0x04000211 RID: 529
        <AccessedThroughProperty("btnShowLists")> _
        Private _btnShowLists As Button

        ' Token: 0x04000212 RID: 530
        <AccessedThroughProperty("nudQuestEntry")> _
        Private _nudQuestEntry As NumericUpDown

        ' Token: 0x04000213 RID: 531
        <AccessedThroughProperty("nudFadeDelay")> _
        Private _nudFadeDelay As NumericUpDown

        ' Token: 0x04000214 RID: 532
        <AccessedThroughProperty("Label36")> _
        Private _Label36 As Label

        ' Token: 0x04000215 RID: 533
        <AccessedThroughProperty("btnTest")> _
        Private _btnTest As Button

        ' Token: 0x04000216 RID: 534
        <AccessedThroughProperty("Label35")> _
        Private _Label35 As Label

        ' Token: 0x04000217 RID: 535
        <AccessedThroughProperty("tbQuest")> _
        Private _tbQuest As TextBox

        ' Token: 0x04000218 RID: 536
        <AccessedThroughProperty("cmbxComputerType")> _
        Private _cmbxComputerType As ComboBox

        ' Token: 0x04000219 RID: 537
        <AccessedThroughProperty("cmbxConversationType")> _
        Private _cmbxConversationType As ComboBox

        ' Token: 0x0400021A RID: 538
        <AccessedThroughProperty("nudFadeLength")> _
        Private _nudFadeLength As NumericUpDown

        ' Token: 0x0400021B RID: 539
        <AccessedThroughProperty("cmiTV_Cut")> _
        Private _cmiTV_Cut As MenuItem

        ' Token: 0x0400021C RID: 540
        <AccessedThroughProperty("tbLinkID")> _
        Private _tbLinkID As TextBox

        ' Token: 0x0400021D RID: 541
        <AccessedThroughProperty("tbLinkedCnt")> _
        Private _tbLinkedCnt As TextBox

        ' Token: 0x0400021E RID: 542
        <AccessedThroughProperty("tbSharedCnt")> _
        Private _tbSharedCnt As TextBox

        ' Token: 0x0400021F RID: 543
        <AccessedThroughProperty("ToolTip1")> _
        Private _ToolTip1 As ToolTip

        ' Token: 0x04000220 RID: 544
        <AccessedThroughProperty("Label34")> _
        Private _Label34 As Label

        ' Token: 0x04000221 RID: 545
        <AccessedThroughProperty("tbLinkDesc")> _
        Private _tbLinkDesc As TextBox

        ' Token: 0x04000222 RID: 546
        <AccessedThroughProperty("tbSound")> _
        Private _tbSound As TextBox

        ' Token: 0x04000223 RID: 547
        <AccessedThroughProperty("cmiTV_PasteTree")> _
        Private _cmiTV_PasteTree As MenuItem

        ' Token: 0x04000224 RID: 548
        <AccessedThroughProperty("trkbTVItemHeight")> _
        Private _trkbTVItemHeight As TrackBar

        ' Token: 0x04000225 RID: 549
        <AccessedThroughProperty("Label33")> _
        Private _Label33 As Label

        ' Token: 0x04000226 RID: 550
        <AccessedThroughProperty("miNew")> _
        Private _miNew As MenuItem

        ' Token: 0x04000227 RID: 551
        <AccessedThroughProperty("Label25")> _
        Private _Label25 As Label

        ' Token: 0x04000228 RID: 552
        <AccessedThroughProperty("tbVO_ID")> _
        Private _tbVO_ID As TextBox

        ' Token: 0x04000229 RID: 553
        <AccessedThroughProperty("Label32")> _
        Private _Label32 As Label

        ' Token: 0x0400022A RID: 554
        <AccessedThroughProperty("trkbTVIndent")> _
        Private _trkbTVIndent As TrackBar

        ' Token: 0x0400022B RID: 555
        <AccessedThroughProperty("btnChooseColor")> _
        Private _btnChooseColor As Button

        ' Token: 0x0400022C RID: 556
        <AccessedThroughProperty("btnAddAnimListEntry")> _
        Private _btnAddAnimListEntry As Button

        ' Token: 0x0400022D RID: 557
        <AccessedThroughProperty("btnDeleteAnimListEntry")> _
        Private _btnDeleteAnimListEntry As Button

        ' Token: 0x0400022E RID: 558
        <AccessedThroughProperty("dgAnimList")> _
        Private _dgAnimList As DataGrid

        ' Token: 0x0400022F RID: 559
        <AccessedThroughProperty("cmiTV_PasteAsLink")> _
        Private _cmiTV_PasteAsLink As MenuItem

        ' Token: 0x04000230 RID: 560
        <AccessedThroughProperty("tvConversation")> _
        Private _tvConversation As TreeView

        ' Token: 0x04000231 RID: 561
        <AccessedThroughProperty("tbTextActiveScript")> _
        Private _tbTextActiveScript As TextBox

        ' Token: 0x04000232 RID: 562
        <AccessedThroughProperty("Label30")> _
        Private _Label30 As Label

        ' Token: 0x04000233 RID: 563
        <AccessedThroughProperty("dgStuntList")> _
        Private _dgStuntList As DataGrid

        ' Token: 0x04000234 RID: 564
        <AccessedThroughProperty("MenuItem4")> _
        Private _MenuItem4 As MenuItem

        ' Token: 0x04000235 RID: 565
        <AccessedThroughProperty("tabpagThisFile2")> _
        Private _tabpagThisFile2 As TabPage

        ' Token: 0x04000236 RID: 566
        <AccessedThroughProperty("tabpagThisFile1")> _
        Private _tabpagThisFile1 As TabPage

        ' Token: 0x04000237 RID: 567
        <AccessedThroughProperty("tbEndConversation")> _
        Private _tbEndConversation As TextBox

        ' Token: 0x04000238 RID: 568
        <AccessedThroughProperty("MenuItem2")> _
        Private _MenuItem2 As MenuItem

        ' Token: 0x04000239 RID: 569
        <AccessedThroughProperty("miSave")> _
        Private _miSave As MenuItem

        ' Token: 0x0400023A RID: 570
        <AccessedThroughProperty("miQuit")> _
        Private _miQuit As MenuItem

        ' Token: 0x0400023B RID: 571
        <AccessedThroughProperty("miOpen")> _
        Private _miOpen As MenuItem

        ' Token: 0x0400023C RID: 572
        <AccessedThroughProperty("btnOpen")> _
        Private _btnOpen As Button

        ' Token: 0x0400023D RID: 573
        <AccessedThroughProperty("cmTVfunctions")> _
        Private _cmTVfunctions As ContextMenu

        ' Token: 0x0400023E RID: 574
        <AccessedThroughProperty("tbEndConverAbort")> _
        Private _tbEndConverAbort As TextBox

        ' Token: 0x0400023F RID: 575
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000240 RID: 576
        <AccessedThroughProperty("tbAmbientTrack")> _
        Private _tbAmbientTrack As TextBox

        ' Token: 0x04000241 RID: 577
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As Button

        ' Token: 0x04000242 RID: 578
        <AccessedThroughProperty("chkbSkippable")> _
        Private _chkbSkippable As CheckBox

        ' Token: 0x04000243 RID: 579
        <AccessedThroughProperty("chkbUnequipItems")> _
        Private _chkbUnequipItems As CheckBox

        ' Token: 0x04000244 RID: 580
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000245 RID: 581
        <AccessedThroughProperty("tbActionsTakenScript")> _
        Private _tbActionsTakenScript As TextBox

        ' Token: 0x04000246 RID: 582
        <AccessedThroughProperty("Label26")> _
        Private _Label26 As Label

        ' Token: 0x04000247 RID: 583
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000248 RID: 584
        <AccessedThroughProperty("nudDelayEntry")> _
        Private _nudDelayEntry As NumericUpDown

        ' Token: 0x04000249 RID: 585
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x0400024A RID: 586
        <AccessedThroughProperty("nudDelayReply")> _
        Private _nudDelayReply As NumericUpDown

        ' Token: 0x0400024B RID: 587
        <AccessedThroughProperty("Label27")> _
        Private _Label27 As Label

        ' Token: 0x0400024C RID: 588
        <AccessedThroughProperty("cmiTV_Add")> _
        Private _cmiTV_Add As MenuItem

        ' Token: 0x0400024D RID: 589
        <AccessedThroughProperty("chkbUnequipHItem")> _
        Private _chkbUnequipHItem As CheckBox

        ' Token: 0x0400024E RID: 590
        <AccessedThroughProperty("tbSpeaker")> _
        Private _tbSpeaker As TextBox

        ' Token: 0x0400024F RID: 591
        <AccessedThroughProperty("Label28")> _
        Private _Label28 As Label

        ' Token: 0x04000250 RID: 592
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x04000251 RID: 593
        <AccessedThroughProperty("cmiTV_Paste")> _
        Private _cmiTV_Paste As MenuItem

        ' Token: 0x04000252 RID: 594
        <AccessedThroughProperty("tabpagDebug")> _
        Private _tabpagDebug As TabPage

        ' Token: 0x04000253 RID: 595
        <AccessedThroughProperty("tabpagAnimationSound")> _
        Private _tabpagAnimationSound As TabPage

        ' Token: 0x04000254 RID: 596
        <AccessedThroughProperty("MenuItem1")> _
        Private _MenuItem1 As MenuItem

        ' Token: 0x04000255 RID: 597
        <AccessedThroughProperty("tabpagPlot")> _
        Private _tabpagPlot As TabPage

        ' Token: 0x04000256 RID: 598
        <AccessedThroughProperty("tbConversationText")> _
        Private _tbConversationText As TextBox

        ' Token: 0x04000257 RID: 599
        <AccessedThroughProperty("MainMenu1")> _
        Private _MainMenu1 As MainMenu

        ' Token: 0x04000258 RID: 600
        <AccessedThroughProperty("Label29")> _
        Private _Label29 As Label

        ' Token: 0x04000259 RID: 601
        <AccessedThroughProperty("tabpagComment")> _
        Private _tabpagComment As TabPage

        ' Token: 0x0400025A RID: 602
        <AccessedThroughProperty("tabpagCamera")> _
        Private _tabpagCamera As TabPage

        ' Token: 0x0400025B RID: 603
        <AccessedThroughProperty("tabpagActionsTaken")> _
        Private _tabpagActionsTaken As TabPage

        ' Token: 0x0400025C RID: 604
        <AccessedThroughProperty("nudCameraAngle")> _
        Private _nudCameraAngle As NumericUpDown

        ' Token: 0x0400025D RID: 605
        <AccessedThroughProperty("cmiTV_Copy")> _
        Private _cmiTV_Copy As MenuItem

        ' Token: 0x0400025F RID: 607
        Private clsdlg As clsDLG

        ' Token: 0x04000260 RID: 608
        Private EntryIndex As Integer

        ' Token: 0x04000261 RID: 609
        Private ReplyIndex As Integer

        ' Token: 0x04000262 RID: 610
        Private EntryList As ArrayList

        ' Token: 0x04000263 RID: 611
        Private ReplyList As ArrayList

        ' Token: 0x04000264 RID: 612
        Private gff As clsGFF

        ' Token: 0x04000265 RID: 613
        Private struct As GFF_Struct

        ' Token: 0x04000266 RID: 614
        Private LastClickedTvConversationNode As DLGConvListNode

        ' Token: 0x04000267 RID: 615
        Private CurrentContextMenuTvConversationNode As DLGConvListNode

        ' Token: 0x04000268 RID: 616
        Private ClipBoardNode As DLGConvListNode

        ' Token: 0x04000269 RID: 617
        Private filename As String

        ' Token: 0x0400026A RID: 618
        Private dtStunt As DataTable

        ' Token: 0x0400026B RID: 619
        Private DViewStunt As DataView

        ' Token: 0x0400026C RID: 620
        Private dtAnim As DataTable

        ' Token: 0x0400026D RID: 621
        Private DViewAnim As DataView
    End Class
End Namespace
