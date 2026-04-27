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
	' Token: 0x0200007E RID: 126
	Public Partial Class frmUTD_Editor
		Inherits frmParent

		' Token: 0x060012AB RID: 4779 RVA: 0x002AAEF8 File Offset: 0x002A9EF8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTD_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTD_Editor_Closing
			Me.ComboBoxSettingError = False
			Me.m_bSaveGameMode = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x170006DA RID: 1754
		' (get) Token: 0x060012AE RID: 4782 RVA: 0x002AAF68 File Offset: 0x002A9F68
		' (set) Token: 0x060012AD RID: 4781 RVA: 0x002AAF7C File Offset: 0x002A9F7C
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

        ' Token: 0x170006DB RID: 1755
        ' (get) Token: 0x060012AF RID: 4783 RVA: 0x002AAFB4 File Offset: 0x002A9FB4
        ' (set) Token: 0x060012B0 RID: 4784 RVA: 0x002AAF98 File Offset: 0x002A9F98
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

        ' Token: 0x170006DC RID: 1756
        ' (get) Token: 0x060012B1 RID: 4785 RVA: 0x002AAFE4 File Offset: 0x002A9FE4
        ' (set) Token: 0x060012B2 RID: 4786 RVA: 0x002AAFC8 File Offset: 0x002A9FC8
        Friend Overridable Property TabPageLock() As TabPage
            Get
                Return Me._TabPageLock
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPageLock IsNot Nothing Then
                End If
                Me._TabPageLock = value
                If Me._TabPageLock IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006DD RID: 1757
        ' (get) Token: 0x060012B3 RID: 4787 RVA: 0x002AAFF8 File Offset: 0x002A9FF8
        ' (set) Token: 0x060012B4 RID: 4788 RVA: 0x002AB00C File Offset: 0x002AA00C
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

        ' Token: 0x170006DE RID: 1758
        ' (get) Token: 0x060012B5 RID: 4789 RVA: 0x002AB028 File Offset: 0x002AA028
        ' (set) Token: 0x060012B6 RID: 4790 RVA: 0x002AB03C File Offset: 0x002AA03C
        Friend Overridable Property TabPageAdvanced() As TabPage
            Get
                Return Me._TabPageAdvanced
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPageAdvanced IsNot Nothing Then
                End If
                Me._TabPageAdvanced = value
                If Me._TabPageAdvanced IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006DF RID: 1759
        ' (get) Token: 0x060012B8 RID: 4792 RVA: 0x002AB074 File Offset: 0x002AA074
        ' (set) Token: 0x060012B7 RID: 4791 RVA: 0x002AB058 File Offset: 0x002AA058
        Friend Overridable Property TabPageDescription() As TabPage
            Get
                Return Me._TabPageDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPageDescription IsNot Nothing Then
                End If
                Me._TabPageDescription = value
                If Me._TabPageDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006E0 RID: 1760
        ' (get) Token: 0x060012BA RID: 4794 RVA: 0x002AB088 File Offset: 0x002AA088
        ' (set) Token: 0x060012B9 RID: 4793 RVA: 0x002AB09C File Offset: 0x002AA09C
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

        ' Token: 0x170006E1 RID: 1761
        ' (get) Token: 0x060012BC RID: 4796 RVA: 0x002AB0D4 File Offset: 0x002AA0D4
        ' (set) Token: 0x060012BB RID: 4795 RVA: 0x002AB0B8 File Offset: 0x002AA0B8
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

        ' Token: 0x170006E2 RID: 1762
        ' (get) Token: 0x060012BE RID: 4798 RVA: 0x002AB104 File Offset: 0x002AA104
        ' (set) Token: 0x060012BD RID: 4797 RVA: 0x002AB0E8 File Offset: 0x002AA0E8
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

        ' Token: 0x170006E3 RID: 1763
        ' (get) Token: 0x060012BF RID: 4799 RVA: 0x002AB134 File Offset: 0x002AA134
        ' (set) Token: 0x060012C0 RID: 4800 RVA: 0x002AB118 File Offset: 0x002AA118
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

        ' Token: 0x170006E4 RID: 1764
        ' (get) Token: 0x060012C2 RID: 4802 RVA: 0x002AB148 File Offset: 0x002AA148
        ' (set) Token: 0x060012C1 RID: 4801 RVA: 0x002AB15C File Offset: 0x002AA15C
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

        ' Token: 0x170006E5 RID: 1765
        ' (get) Token: 0x060012C3 RID: 4803 RVA: 0x002AB194 File Offset: 0x002AA194
        ' (set) Token: 0x060012C4 RID: 4804 RVA: 0x002AB178 File Offset: 0x002AA178
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

        ' Token: 0x170006E6 RID: 1766
        ' (get) Token: 0x060012C5 RID: 4805 RVA: 0x002AB1C4 File Offset: 0x002AA1C4
        ' (set) Token: 0x060012C6 RID: 4806 RVA: 0x002AB1A8 File Offset: 0x002AA1A8
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

        ' Token: 0x170006E7 RID: 1767
        ' (get) Token: 0x060012C8 RID: 4808 RVA: 0x002AB1F4 File Offset: 0x002AA1F4
        ' (set) Token: 0x060012C7 RID: 4807 RVA: 0x002AB1D8 File Offset: 0x002AA1D8
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

        ' Token: 0x170006E8 RID: 1768
        ' (get) Token: 0x060012C9 RID: 4809 RVA: 0x002AB224 File Offset: 0x002AA224
        ' (set) Token: 0x060012CA RID: 4810 RVA: 0x002AB208 File Offset: 0x002AA208
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

        ' Token: 0x170006E9 RID: 1769
        ' (get) Token: 0x060012CC RID: 4812 RVA: 0x002AB254 File Offset: 0x002AA254
        ' (set) Token: 0x060012CB RID: 4811 RVA: 0x002AB238 File Offset: 0x002AA238
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

        ' Token: 0x170006EA RID: 1770
        ' (get) Token: 0x060012CD RID: 4813 RVA: 0x002AB268 File Offset: 0x002AA268
        ' (set) Token: 0x060012CE RID: 4814 RVA: 0x002AB27C File Offset: 0x002AA27C
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

        ' Token: 0x170006EB RID: 1771
        ' (get) Token: 0x060012CF RID: 4815 RVA: 0x002AB298 File Offset: 0x002AA298
        ' (set) Token: 0x060012D0 RID: 4816 RVA: 0x002AB2AC File Offset: 0x002AA2AC
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

        ' Token: 0x170006EC RID: 1772
        ' (get) Token: 0x060012D2 RID: 4818 RVA: 0x002AB2C8 File Offset: 0x002AA2C8
        ' (set) Token: 0x060012D1 RID: 4817 RVA: 0x002AB2DC File Offset: 0x002AA2DC
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

        ' Token: 0x170006ED RID: 1773
        ' (get) Token: 0x060012D3 RID: 4819 RVA: 0x002AB2F8 File Offset: 0x002AA2F8
        ' (set) Token: 0x060012D4 RID: 4820 RVA: 0x002AB30C File Offset: 0x002AA30C
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

        ' Token: 0x170006EE RID: 1774
        ' (get) Token: 0x060012D6 RID: 4822 RVA: 0x002AB344 File Offset: 0x002AA344
        ' (set) Token: 0x060012D5 RID: 4821 RVA: 0x002AB328 File Offset: 0x002AA328
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

        ' Token: 0x170006EF RID: 1775
        ' (get) Token: 0x060012D7 RID: 4823 RVA: 0x002AB374 File Offset: 0x002AA374
        ' (set) Token: 0x060012D8 RID: 4824 RVA: 0x002AB358 File Offset: 0x002AA358
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

        ' Token: 0x170006F0 RID: 1776
        ' (get) Token: 0x060012DA RID: 4826 RVA: 0x002AB388 File Offset: 0x002AA388
        ' (set) Token: 0x060012D9 RID: 4825 RVA: 0x002AB39C File Offset: 0x002AA39C
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

        ' Token: 0x170006F1 RID: 1777
        ' (get) Token: 0x060012DB RID: 4827 RVA: 0x002AB3D4 File Offset: 0x002AA3D4
        ' (set) Token: 0x060012DC RID: 4828 RVA: 0x002AB3B8 File Offset: 0x002AA3B8
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

        ' Token: 0x170006F2 RID: 1778
        ' (get) Token: 0x060012DE RID: 4830 RVA: 0x002AB404 File Offset: 0x002AA404
        ' (set) Token: 0x060012DD RID: 4829 RVA: 0x002AB3E8 File Offset: 0x002AA3E8
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

        ' Token: 0x170006F3 RID: 1779
        ' (get) Token: 0x060012E0 RID: 4832 RVA: 0x002AB418 File Offset: 0x002AA418
        ' (set) Token: 0x060012DF RID: 4831 RVA: 0x002AB42C File Offset: 0x002AA42C
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

        ' Token: 0x170006F4 RID: 1780
        ' (get) Token: 0x060012E1 RID: 4833 RVA: 0x002AB464 File Offset: 0x002AA464
        ' (set) Token: 0x060012E2 RID: 4834 RVA: 0x002AB448 File Offset: 0x002AA448
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

        ' Token: 0x170006F5 RID: 1781
        ' (get) Token: 0x060012E3 RID: 4835 RVA: 0x002AB478 File Offset: 0x002AA478
        ' (set) Token: 0x060012E4 RID: 4836 RVA: 0x002AB48C File Offset: 0x002AA48C
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

        ' Token: 0x170006F6 RID: 1782
        ' (get) Token: 0x060012E5 RID: 4837 RVA: 0x002AB4A8 File Offset: 0x002AA4A8
        ' (set) Token: 0x060012E6 RID: 4838 RVA: 0x002AB4BC File Offset: 0x002AA4BC
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

        ' Token: 0x170006F7 RID: 1783
        ' (get) Token: 0x060012E7 RID: 4839 RVA: 0x002AB4D8 File Offset: 0x002AA4D8
        ' (set) Token: 0x060012E8 RID: 4840 RVA: 0x002AB4EC File Offset: 0x002AA4EC
        Friend Overridable Property tbOnClosed() As TextBox
            Get
                Return Me._tbOnClosed
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnClosed IsNot Nothing Then
                End If
                Me._tbOnClosed = value
                If Me._tbOnClosed IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006F8 RID: 1784
        ' (get) Token: 0x060012E9 RID: 4841 RVA: 0x002AB524 File Offset: 0x002AA524
        ' (set) Token: 0x060012EA RID: 4842 RVA: 0x002AB508 File Offset: 0x002AA508
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

        ' Token: 0x170006F9 RID: 1785
        ' (get) Token: 0x060012EC RID: 4844 RVA: 0x002AB538 File Offset: 0x002AA538
        ' (set) Token: 0x060012EB RID: 4843 RVA: 0x002AB54C File Offset: 0x002AA54C
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

        ' Token: 0x170006FA RID: 1786
        ' (get) Token: 0x060012ED RID: 4845 RVA: 0x002AB584 File Offset: 0x002AA584
        ' (set) Token: 0x060012EE RID: 4846 RVA: 0x002AB568 File Offset: 0x002AA568
        Friend Overridable Property tbOnLock() As TextBox
            Get
                Return Me._tbOnLock
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnLock IsNot Nothing Then
                End If
                Me._tbOnLock = value
                If Me._tbOnLock IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006FB RID: 1787
        ' (get) Token: 0x060012F0 RID: 4848 RVA: 0x002AB5B4 File Offset: 0x002AA5B4
        ' (set) Token: 0x060012EF RID: 4847 RVA: 0x002AB598 File Offset: 0x002AA598
        Friend Overridable Property tbOnMeleeAttacked() As TextBox
            Get
                Return Me._tbOnMeleeAttacked
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnMeleeAttacked IsNot Nothing Then
                End If
                Me._tbOnMeleeAttacked = value
                If Me._tbOnMeleeAttacked IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006FC RID: 1788
        ' (get) Token: 0x060012F1 RID: 4849 RVA: 0x002AB5E4 File Offset: 0x002AA5E4
        ' (set) Token: 0x060012F2 RID: 4850 RVA: 0x002AB5C8 File Offset: 0x002AA5C8
        Friend Overridable Property tbOnOpen() As TextBox
            Get
                Return Me._tbOnOpen
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnOpen IsNot Nothing Then
                End If
                Me._tbOnOpen = value
                If Me._tbOnOpen IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006FD RID: 1789
        ' (get) Token: 0x060012F4 RID: 4852 RVA: 0x002AB5F8 File Offset: 0x002AA5F8
        ' (set) Token: 0x060012F3 RID: 4851 RVA: 0x002AB60C File Offset: 0x002AA60C
        Friend Overridable Property tbOnSpellCastAt() As TextBox
            Get
                Return Me._tbOnSpellCastAt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnSpellCastAt IsNot Nothing Then
                End If
                Me._tbOnSpellCastAt = value
                If Me._tbOnSpellCastAt IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170006FE RID: 1790
        ' (get) Token: 0x060012F6 RID: 4854 RVA: 0x002AB628 File Offset: 0x002AA628
        ' (set) Token: 0x060012F5 RID: 4853 RVA: 0x002AB63C File Offset: 0x002AA63C
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

        ' Token: 0x170006FF RID: 1791
        ' (get) Token: 0x060012F8 RID: 4856 RVA: 0x002AB658 File Offset: 0x002AA658
        ' (set) Token: 0x060012F7 RID: 4855 RVA: 0x002AB66C File Offset: 0x002AA66C
        Friend Overridable Property tbOnUnlock() As TextBox
            Get
                Return Me._tbOnUnlock
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnUnlock IsNot Nothing Then
                End If
                Me._tbOnUnlock = value
                If Me._tbOnUnlock IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000700 RID: 1792
        ' (get) Token: 0x060012F9 RID: 4857 RVA: 0x002AB688 File Offset: 0x002AA688
        ' (set) Token: 0x060012FA RID: 4858 RVA: 0x002AB69C File Offset: 0x002AA69C
        Friend Overridable Property tbOnUserDefined() As TextBox
            Get
                Return Me._tbOnUserDefined
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnUserDefined IsNot Nothing Then
                End If
                Me._tbOnUserDefined = value
                If Me._tbOnUserDefined IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000701 RID: 1793
        ' (get) Token: 0x060012FB RID: 4859 RVA: 0x002AB6D4 File Offset: 0x002AA6D4
        ' (set) Token: 0x060012FC RID: 4860 RVA: 0x002AB6B8 File Offset: 0x002AA6B8
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

        ' Token: 0x17000702 RID: 1794
        ' (get) Token: 0x060012FD RID: 4861 RVA: 0x002AB704 File Offset: 0x002AA704
        ' (set) Token: 0x060012FE RID: 4862 RVA: 0x002AB6E8 File Offset: 0x002AA6E8
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

        ' Token: 0x17000703 RID: 1795
        ' (get) Token: 0x060012FF RID: 4863 RVA: 0x002AB734 File Offset: 0x002AA734
        ' (set) Token: 0x06001300 RID: 4864 RVA: 0x002AB718 File Offset: 0x002AA718
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

        ' Token: 0x17000704 RID: 1796
        ' (get) Token: 0x06001301 RID: 4865 RVA: 0x002AB748 File Offset: 0x002AA748
        ' (set) Token: 0x06001302 RID: 4866 RVA: 0x002AB75C File Offset: 0x002AA75C
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

        ' Token: 0x17000705 RID: 1797
        ' (get) Token: 0x06001303 RID: 4867 RVA: 0x002AB778 File Offset: 0x002AA778
        ' (set) Token: 0x06001304 RID: 4868 RVA: 0x002AB78C File Offset: 0x002AA78C
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

        ' Token: 0x17000706 RID: 1798
        ' (get) Token: 0x06001306 RID: 4870 RVA: 0x002AB7C4 File Offset: 0x002AA7C4
        ' (set) Token: 0x06001305 RID: 4869 RVA: 0x002AB7A8 File Offset: 0x002AA7A8
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

        ' Token: 0x17000707 RID: 1799
        ' (get) Token: 0x06001307 RID: 4871 RVA: 0x002AB7D8 File Offset: 0x002AA7D8
        ' (set) Token: 0x06001308 RID: 4872 RVA: 0x002AB7EC File Offset: 0x002AA7EC
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

        ' Token: 0x17000708 RID: 1800
        ' (get) Token: 0x06001309 RID: 4873 RVA: 0x002AB808 File Offset: 0x002AA808
        ' (set) Token: 0x0600130A RID: 4874 RVA: 0x002AB81C File Offset: 0x002AA81C
        Friend Overridable Property nudCloseLockDC() As NumericUpDown
            Get
                Return Me._nudCloseLockDC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCloseLockDC IsNot Nothing Then
                End If
                Me._nudCloseLockDC = value
                If Me._nudCloseLockDC IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000709 RID: 1801
        ' (get) Token: 0x0600130C RID: 4876 RVA: 0x002AB838 File Offset: 0x002AA838
        ' (set) Token: 0x0600130B RID: 4875 RVA: 0x002AB84C File Offset: 0x002AA84C
        Friend Overridable Property nudOpenLockDC() As NumericUpDown
            Get
                Return Me._nudOpenLockDC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudOpenLockDC IsNot Nothing Then
                End If
                Me._nudOpenLockDC = value
                If Me._nudOpenLockDC IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700070A RID: 1802
        ' (get) Token: 0x0600130D RID: 4877 RVA: 0x002AB868 File Offset: 0x002AA868
        ' (set) Token: 0x0600130E RID: 4878 RVA: 0x002AB87C File Offset: 0x002AA87C
        Friend Overridable Property chkbLockable() As CheckBox
            Get
                Return Me._chkbLockable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbLockable IsNot Nothing Then
                    RemoveHandler Me._chkbLockable.CheckedChanged, AddressOf Me.chkbLockable_CheckedChanged
                End If
                Me._chkbLockable = value
                If Me._chkbLockable IsNot Nothing Then
                    AddHandler Me._chkbLockable.CheckedChanged, AddressOf Me.chkbLockable_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x1700070B RID: 1803
        ' (get) Token: 0x06001310 RID: 4880 RVA: 0x002AB8D0 File Offset: 0x002AA8D0
        ' (set) Token: 0x0600130F RID: 4879 RVA: 0x002AB8E4 File Offset: 0x002AA8E4
        Friend Overridable Property chkbLocked() As CheckBox
            Get
                Return Me._chkbLocked
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbLocked IsNot Nothing Then
                    RemoveHandler Me._chkbLocked.CheckedChanged, AddressOf Me.chkbLocked_CheckedChanged
                End If
                Me._chkbLocked = value
                If Me._chkbLocked IsNot Nothing Then
                    AddHandler Me._chkbLocked.CheckedChanged, AddressOf Me.chkbLocked_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x1700070C RID: 1804
        ' (get) Token: 0x06001312 RID: 4882 RVA: 0x002AB954 File Offset: 0x002AA954
        ' (set) Token: 0x06001311 RID: 4881 RVA: 0x002AB938 File Offset: 0x002AA938
        Friend Overridable Property chkbKeyRequired() As CheckBox
            Get
                Return Me._chkbKeyRequired
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbKeyRequired IsNot Nothing Then
                End If
                Me._chkbKeyRequired = value
                If Me._chkbKeyRequired IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700070D RID: 1805
        ' (get) Token: 0x06001313 RID: 4883 RVA: 0x002AB968 File Offset: 0x002AA968
        ' (set) Token: 0x06001314 RID: 4884 RVA: 0x002AB97C File Offset: 0x002AA97C
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

        ' Token: 0x1700070E RID: 1806
        ' (get) Token: 0x06001315 RID: 4885 RVA: 0x002AB998 File Offset: 0x002AA998
        ' (set) Token: 0x06001316 RID: 4886 RVA: 0x002AB9AC File Offset: 0x002AA9AC
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

        ' Token: 0x1700070F RID: 1807
        ' (get) Token: 0x06001317 RID: 4887 RVA: 0x002AB9E4 File Offset: 0x002AA9E4
        ' (set) Token: 0x06001318 RID: 4888 RVA: 0x002AB9C8 File Offset: 0x002AA9C8
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

        ' Token: 0x17000710 RID: 1808
        ' (get) Token: 0x06001319 RID: 4889 RVA: 0x002AB9F8 File Offset: 0x002AA9F8
        ' (set) Token: 0x0600131A RID: 4890 RVA: 0x002ABA0C File Offset: 0x002AAA0C
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

        ' Token: 0x17000711 RID: 1809
        ' (get) Token: 0x0600131B RID: 4891 RVA: 0x002ABA44 File Offset: 0x002AAA44
        ' (set) Token: 0x0600131C RID: 4892 RVA: 0x002ABA28 File Offset: 0x002AAA28
        Friend Overridable Property nudWill() As NumericUpDown
            Get
                Return Me._nudWill
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudWill IsNot Nothing Then
                End If
                Me._nudWill = value
                If Me._nudWill IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000712 RID: 1810
        ' (get) Token: 0x0600131E RID: 4894 RVA: 0x002ABA58 File Offset: 0x002AAA58
        ' (set) Token: 0x0600131D RID: 4893 RVA: 0x002ABA6C File Offset: 0x002AAA6C
        Friend Overridable Property nudFort() As NumericUpDown
            Get
                Return Me._nudFort
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudFort IsNot Nothing Then
                End If
                Me._nudFort = value
                If Me._nudFort IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000713 RID: 1811
        ' (get) Token: 0x0600131F RID: 4895 RVA: 0x002ABA88 File Offset: 0x002AAA88
        ' (set) Token: 0x06001320 RID: 4896 RVA: 0x002ABA9C File Offset: 0x002AAA9C
        Friend Overridable Property nudHP() As NumericUpDown
            Get
                Return Me._nudHP
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudHP IsNot Nothing Then
                End If
                Me._nudHP = value
                If Me._nudHP IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000714 RID: 1812
        ' (get) Token: 0x06001322 RID: 4898 RVA: 0x002ABAB8 File Offset: 0x002AAAB8
        ' (set) Token: 0x06001321 RID: 4897 RVA: 0x002ABACC File Offset: 0x002AAACC
        Friend Overridable Property nudHardness() As NumericUpDown
            Get
                Return Me._nudHardness
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudHardness IsNot Nothing Then
                End If
                Me._nudHardness = value
                If Me._nudHardness IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000715 RID: 1813
        ' (get) Token: 0x06001323 RID: 4899 RVA: 0x002ABAE8 File Offset: 0x002AAAE8
        ' (set) Token: 0x06001324 RID: 4900 RVA: 0x002ABAFC File Offset: 0x002AAAFC
        Friend Overridable Property nudRef() As NumericUpDown
            Get
                Return Me._nudRef
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudRef IsNot Nothing Then
                End If
                Me._nudRef = value
                If Me._nudRef IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000716 RID: 1814
        ' (get) Token: 0x06001325 RID: 4901 RVA: 0x002ABB34 File Offset: 0x002AAB34
        ' (set) Token: 0x06001326 RID: 4902 RVA: 0x002ABB18 File Offset: 0x002AAB18
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

        ' Token: 0x17000717 RID: 1815
        ' (get) Token: 0x06001328 RID: 4904 RVA: 0x002ABB64 File Offset: 0x002AAB64
        ' (set) Token: 0x06001327 RID: 4903 RVA: 0x002ABB48 File Offset: 0x002AAB48
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

        ' Token: 0x17000718 RID: 1816
        ' (get) Token: 0x0600132A RID: 4906 RVA: 0x002ABBCC File Offset: 0x002AABCC
        ' (set) Token: 0x06001329 RID: 4905 RVA: 0x002ABB78 File Offset: 0x002AAB78
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

        ' Token: 0x17000719 RID: 1817
        ' (get) Token: 0x0600132B RID: 4907 RVA: 0x002ABC34 File Offset: 0x002AAC34
        ' (set) Token: 0x0600132C RID: 4908 RVA: 0x002ABBE0 File Offset: 0x002AABE0
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

        ' Token: 0x1700071A RID: 1818
        ' (get) Token: 0x0600132D RID: 4909 RVA: 0x002ABC64 File Offset: 0x002AAC64
        ' (set) Token: 0x0600132E RID: 4910 RVA: 0x002ABC48 File Offset: 0x002AAC48
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

        ' Token: 0x1700071B RID: 1819
        ' (get) Token: 0x0600132F RID: 4911 RVA: 0x002ABC78 File Offset: 0x002AAC78
        ' (set) Token: 0x06001330 RID: 4912 RVA: 0x002ABC8C File Offset: 0x002AAC8C
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

        ' Token: 0x1700071C RID: 1820
        ' (get) Token: 0x06001331 RID: 4913 RVA: 0x002ABCC4 File Offset: 0x002AACC4
        ' (set) Token: 0x06001332 RID: 4914 RVA: 0x002ABCA8 File Offset: 0x002AACA8
        Friend Overridable Property tbOnFailToOpen() As TextBox
            Get
                Return Me._tbOnFailToOpen
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnFailToOpen IsNot Nothing Then
                End If
                Me._tbOnFailToOpen = value
                If Me._tbOnFailToOpen IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700071D RID: 1821
        ' (get) Token: 0x06001334 RID: 4916 RVA: 0x002ABCF4 File Offset: 0x002AACF4
        ' (set) Token: 0x06001333 RID: 4915 RVA: 0x002ABCD8 File Offset: 0x002AACD8
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

        ' Token: 0x1700071E RID: 1822
        ' (get) Token: 0x06001335 RID: 4917 RVA: 0x002ABD08 File Offset: 0x002AAD08
        ' (set) Token: 0x06001336 RID: 4918 RVA: 0x002ABD1C File Offset: 0x002AAD1C
        Friend Overridable Property tbAnimationState() As TextBox
            Get
                Return Me._tbAnimationState
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbAnimationState IsNot Nothing Then
                End If
                Me._tbAnimationState = value
                If Me._tbAnimationState IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700071F RID: 1823
        ' (get) Token: 0x06001337 RID: 4919 RVA: 0x002ABD38 File Offset: 0x002AAD38
        ' (set) Token: 0x06001338 RID: 4920 RVA: 0x002ABD4C File Offset: 0x002AAD4C
        Friend Overridable Property lblKeyTag() As Label
            Get
                Return Me._lblKeyTag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblKeyTag IsNot Nothing Then
                End If
                Me._lblKeyTag = value
                If Me._lblKeyTag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000720 RID: 1824
        ' (get) Token: 0x06001339 RID: 4921 RVA: 0x002ABD68 File Offset: 0x002AAD68
        ' (set) Token: 0x0600133A RID: 4922 RVA: 0x002ABD7C File Offset: 0x002AAD7C
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

        ' Token: 0x17000721 RID: 1825
        ' (get) Token: 0x0600133C RID: 4924 RVA: 0x002ABD98 File Offset: 0x002AAD98
        ' (set) Token: 0x0600133B RID: 4923 RVA: 0x002ABDAC File Offset: 0x002AADAC
        Friend Overridable Property lblOpenLockDC() As Label
            Get
                Return Me._lblOpenLockDC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblOpenLockDC IsNot Nothing Then
                End If
                Me._lblOpenLockDC = value
                If Me._lblOpenLockDC IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000722 RID: 1826
        ' (get) Token: 0x0600133E RID: 4926 RVA: 0x002ABDE4 File Offset: 0x002AADE4
        ' (set) Token: 0x0600133D RID: 4925 RVA: 0x002ABDC8 File Offset: 0x002AADC8
        Friend Overridable Property chkbStatic() As CheckBox
            Get
                Return Me._chkbStatic
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbStatic IsNot Nothing Then
                End If
                Me._chkbStatic = value
                If Me._chkbStatic IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000723 RID: 1827
        ' (get) Token: 0x0600133F RID: 4927 RVA: 0x002ABDF8 File Offset: 0x002AADF8
        ' (set) Token: 0x06001340 RID: 4928 RVA: 0x002ABE0C File Offset: 0x002AAE0C
        Friend Overridable Property btnSetDescriptionLang() As Button
            Get
                Return Me._btnSetDescriptionLang
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetDescriptionLang IsNot Nothing Then
                    RemoveHandler Me._btnSetDescriptionLang.Click, AddressOf Me.btnSetDescLang_Click
                End If
                Me._btnSetDescriptionLang = value
                If Me._btnSetDescriptionLang IsNot Nothing Then
                    AddHandler Me._btnSetDescriptionLang.Click, AddressOf Me.btnSetDescLang_Click
                End If
            End Set
        End Property

        ' Token: 0x17000724 RID: 1828
        ' (get) Token: 0x06001341 RID: 4929 RVA: 0x002ABE60 File Offset: 0x002AAE60
        ' (set) Token: 0x06001342 RID: 4930 RVA: 0x002ABE74 File Offset: 0x002AAE74
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

        ' Token: 0x17000725 RID: 1829
        ' (get) Token: 0x06001344 RID: 4932 RVA: 0x002ABEC8 File Offset: 0x002AAEC8
        ' (set) Token: 0x06001343 RID: 4931 RVA: 0x002ABEDC File Offset: 0x002AAEDC
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

        ' Token: 0x17000726 RID: 1830
        ' (get) Token: 0x06001346 RID: 4934 RVA: 0x002ABF4C File Offset: 0x002AAF4C
        ' (set) Token: 0x06001345 RID: 4933 RVA: 0x002ABF30 File Offset: 0x002AAF30
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

        ' Token: 0x17000727 RID: 1831
        ' (get) Token: 0x06001348 RID: 4936 RVA: 0x002ABF60 File Offset: 0x002AAF60
        ' (set) Token: 0x06001347 RID: 4935 RVA: 0x002ABF74 File Offset: 0x002AAF74
        Friend Overridable Property cmbxDoorType() As ComboBox
            Get
                Return Me._cmbxDoorType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxDoorType IsNot Nothing Then
                End If
                Me._cmbxDoorType = value
                If Me._cmbxDoorType IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000728 RID: 1832
        ' (get) Token: 0x0600134A RID: 4938 RVA: 0x002ABF90 File Offset: 0x002AAF90
        ' (set) Token: 0x06001349 RID: 4937 RVA: 0x002ABFA4 File Offset: 0x002AAFA4
        Friend Overridable Property cmbxOpenState() As ComboBox
            Get
                Return Me._cmbxOpenState
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxOpenState IsNot Nothing Then
                End If
                Me._cmbxOpenState = value
                If Me._cmbxOpenState IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000729 RID: 1833
        ' (get) Token: 0x0600134B RID: 4939 RVA: 0x002ABFC0 File Offset: 0x002AAFC0
        ' (set) Token: 0x0600134C RID: 4940 RVA: 0x002ABFD4 File Offset: 0x002AAFD4
        Friend Overridable Property chkbNotBlastable() As CheckBox
            Get
                Return Me._chkbNotBlastable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbNotBlastable IsNot Nothing Then
                End If
                Me._chkbNotBlastable = value
                If Me._chkbNotBlastable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700072A RID: 1834
        ' (get) Token: 0x0600134E RID: 4942 RVA: 0x002ABFF0 File Offset: 0x002AAFF0
        ' (set) Token: 0x0600134D RID: 4941 RVA: 0x002AC004 File Offset: 0x002AB004
        Friend Overridable Property lblOpenState() As Label
            Get
                Return Me._lblOpenState
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblOpenState IsNot Nothing Then
                End If
                Me._lblOpenState = value
                If Me._lblOpenState IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700072B RID: 1835
        ' (get) Token: 0x0600134F RID: 4943 RVA: 0x002AC020 File Offset: 0x002AB020
        ' (set) Token: 0x06001350 RID: 4944 RVA: 0x002AC034 File Offset: 0x002AB034
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

        ' Token: 0x1700072C RID: 1836
        ' (get) Token: 0x06001351 RID: 4945 RVA: 0x002AC0A4 File Offset: 0x002AB0A4
        ' (set) Token: 0x06001352 RID: 4946 RVA: 0x002AC050 File Offset: 0x002AB050
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

        ' Token: 0x1700072D RID: 1837
        ' (get) Token: 0x06001353 RID: 4947 RVA: 0x002AC0B8 File Offset: 0x002AB0B8
        ' (set) Token: 0x06001354 RID: 4948 RVA: 0x002AC0CC File Offset: 0x002AB0CC
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

        ' Token: 0x1700072E RID: 1838
        ' (get) Token: 0x06001355 RID: 4949 RVA: 0x002AC174 File Offset: 0x002AB174
        ' (set) Token: 0x06001356 RID: 4950 RVA: 0x002AC120 File Offset: 0x002AB120
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

        ' Token: 0x1700072F RID: 1839
        ' (get) Token: 0x06001358 RID: 4952 RVA: 0x002AC1DC File Offset: 0x002AB1DC
        ' (set) Token: 0x06001357 RID: 4951 RVA: 0x002AC188 File Offset: 0x002AB188
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

        ' Token: 0x17000730 RID: 1840
        ' (get) Token: 0x0600135A RID: 4954 RVA: 0x002AC244 File Offset: 0x002AB244
        ' (set) Token: 0x06001359 RID: 4953 RVA: 0x002AC1F0 File Offset: 0x002AB1F0
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

        ' Token: 0x17000731 RID: 1841
        ' (get) Token: 0x0600135B RID: 4955 RVA: 0x002AC2AC File Offset: 0x002AB2AC
        ' (set) Token: 0x0600135C RID: 4956 RVA: 0x002AC258 File Offset: 0x002AB258
        Friend Overridable Property btnEditOnSpellCastAt() As Button
            Get
                Return Me._btnEditOnSpellCastAt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnSpellCastAt IsNot Nothing Then
                    RemoveHandler Me._btnEditOnSpellCastAt.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnSpellCastAt = value
                If Me._btnEditOnSpellCastAt IsNot Nothing Then
                    AddHandler Me._btnEditOnSpellCastAt.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x17000732 RID: 1842
        ' (get) Token: 0x0600135E RID: 4958 RVA: 0x002AC2C0 File Offset: 0x002AB2C0
        ' (set) Token: 0x0600135D RID: 4957 RVA: 0x002AC2D4 File Offset: 0x002AB2D4
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

        ' Token: 0x17000733 RID: 1843
        ' (get) Token: 0x0600135F RID: 4959 RVA: 0x002AC328 File Offset: 0x002AB328
        ' (set) Token: 0x06001360 RID: 4960 RVA: 0x002AC33C File Offset: 0x002AB33C
        Friend Overridable Property btnEditOnClosed() As Button
            Get
                Return Me._btnEditOnClosed
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnClosed IsNot Nothing Then
                    RemoveHandler Me._btnEditOnClosed.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnClosed = value
                If Me._btnEditOnClosed IsNot Nothing Then
                    AddHandler Me._btnEditOnClosed.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x17000734 RID: 1844
        ' (get) Token: 0x06001362 RID: 4962 RVA: 0x002AC3E4 File Offset: 0x002AB3E4
        ' (set) Token: 0x06001361 RID: 4961 RVA: 0x002AC390 File Offset: 0x002AB390
        Friend Overridable Property btnEditOnFailToOpen() As Button
            Get
                Return Me._btnEditOnFailToOpen
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnFailToOpen IsNot Nothing Then
                    RemoveHandler Me._btnEditOnFailToOpen.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnFailToOpen = value
                If Me._btnEditOnFailToOpen IsNot Nothing Then
                    AddHandler Me._btnEditOnFailToOpen.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x17000735 RID: 1845
        ' (get) Token: 0x06001363 RID: 4963 RVA: 0x002AC3F8 File Offset: 0x002AB3F8
        ' (set) Token: 0x06001364 RID: 4964 RVA: 0x002AC40C File Offset: 0x002AB40C
        Friend Overridable Property btnEditOnLock() As Button
            Get
                Return Me._btnEditOnLock
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnLock IsNot Nothing Then
                    RemoveHandler Me._btnEditOnLock.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnLock = value
                If Me._btnEditOnLock IsNot Nothing Then
                    AddHandler Me._btnEditOnLock.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x17000736 RID: 1846
        ' (get) Token: 0x06001366 RID: 4966 RVA: 0x002AC460 File Offset: 0x002AB460
        ' (set) Token: 0x06001365 RID: 4965 RVA: 0x002AC474 File Offset: 0x002AB474
        Friend Overridable Property btnEditOnMeleeAttacked() As Button
            Get
                Return Me._btnEditOnMeleeAttacked
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnMeleeAttacked IsNot Nothing Then
                    RemoveHandler Me._btnEditOnMeleeAttacked.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnMeleeAttacked = value
                If Me._btnEditOnMeleeAttacked IsNot Nothing Then
                    AddHandler Me._btnEditOnMeleeAttacked.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x17000737 RID: 1847
        ' (get) Token: 0x06001367 RID: 4967 RVA: 0x002AC4C8 File Offset: 0x002AB4C8
        ' (set) Token: 0x06001368 RID: 4968 RVA: 0x002AC4DC File Offset: 0x002AB4DC
        Friend Overridable Property btnEditOnOpen() As Button
            Get
                Return Me._btnEditOnOpen
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnOpen IsNot Nothing Then
                    RemoveHandler Me._btnEditOnOpen.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnOpen = value
                If Me._btnEditOnOpen IsNot Nothing Then
                    AddHandler Me._btnEditOnOpen.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x17000738 RID: 1848
        ' (get) Token: 0x06001369 RID: 4969 RVA: 0x002AC530 File Offset: 0x002AB530
        ' (set) Token: 0x0600136A RID: 4970 RVA: 0x002AC544 File Offset: 0x002AB544
        Friend Overridable Property btnEditOnUnlock() As Button
            Get
                Return Me._btnEditOnUnlock
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnUnlock IsNot Nothing Then
                    RemoveHandler Me._btnEditOnUnlock.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnUnlock = value
                If Me._btnEditOnUnlock IsNot Nothing Then
                    AddHandler Me._btnEditOnUnlock.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x17000739 RID: 1849
        ' (get) Token: 0x0600136C RID: 4972 RVA: 0x002AC5EC File Offset: 0x002AB5EC
        ' (set) Token: 0x0600136B RID: 4971 RVA: 0x002AC598 File Offset: 0x002AB598
        Friend Overridable Property btnEditOnUserDefined() As Button
            Get
                Return Me._btnEditOnUserDefined
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnUserDefined IsNot Nothing Then
                    RemoveHandler Me._btnEditOnUserDefined.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnUserDefined = value
                If Me._btnEditOnUserDefined IsNot Nothing Then
                    AddHandler Me._btnEditOnUserDefined.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x0600136E RID: 4974 RVA: 0x002AFCA4 File Offset: 0x002AECA4
        Public Sub New(ByVal UTDClass As clsUTD, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Door Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTD = UTDClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
        End Sub

        ' Token: 0x0600136F RID: 4975 RVA: 0x002AFD54 File Offset: 0x002AED54
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x06001370 RID: 4976 RVA: 0x002AFD5C File Offset: 0x002AED5C
        Public Sub Setup()
            Me.BuildComboBoxes()
            Me.UTD.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocName")
            Me.UTD.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudHardness, "Hardness", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudHP, "HP", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudFort, "Fort", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudRef, "Ref", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudWill, "Will", 0.0F)
            Me.chkbStatic.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("Static"))
            Me.chkbLocked.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("Locked"))
            Me.chkbLockable.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("Lockable"))
            Me.chkbAutoRemoveKey.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("AutoRemoveKey"))
            Me.chkbKeyRequired.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("KeyRequired"))
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudOpenLockDC, "OpenLockDC", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudCloseLockDC, "CloseLockDC", 0.0F)
            Me.UTD.SetTextBoxToNodeValue(Me.tbKeyName, "KeyName")
            If Me.KotorVersionIndex = 1 Then
                Dim num As Integer = IntegerType.FromObject(Me.UTD.GetNodeValue("OpenState"))
                If num > 1 Then
                    Me.cmbxOpenState.BackColor = Color.Tomato
                    Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
                Else
                    Me.cmbxOpenState.SelectedIndex = num
                End If
                Me.chkbNotBlastable.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("NotBlastable"))
            Else
                Me.cmbxOpenState.Visible = False
                Me.chkbNotBlastable.Visible = False
                Me.lblOpenState.Visible = False
            End If
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnClick, "OnClick")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnClosed, "OnClosed")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnDamaged, "OnDamaged")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnDeath, "OnDeath")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnDisarm, "OnDisarm")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnFailToOpen, "OnFailToOpen")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnHeartbeat, "OnHeartbeat")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnLock, "OnLock")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnMeleeAttacked, "OnMeleeAttacked")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnOpen, "OnOpen")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnSpellCastAt, "OnSpellCastAt")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnUnlock, "OnUnlock")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnUserDefined, "OnUserDefined")
            Me.UTD.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTD.SetTextBoxToNodeValue(Me.tbConversation, "Conversation")
            Me.chkbNotInterruptable.Checked = BooleanType.FromObject(ObjectType.NotObj(Me.UTD.GetNodeValue("Interruptable")))
            Me.UTD.SetTextBoxToNodeValue(Me.tbAnimationState, "AnimationState")
            Me.UTD.SetTextBoxFromCExoLocStringNodeValue(Me.tbDescription, "Description")
            Me.DescriptionLang = IntegerType.FromObject(Me.UTD.GetCExoLocStringLanguage("Description"))
            Me.tbDescription.Text = Strings.Replace(Me.tbDescription.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            Me.UTD.SetTextBoxToNodeValue(Me.tbComment, "Comment")
            If Me.ComboBoxSettingError Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
        End Sub

        ' Token: 0x06001371 RID: 4977 RVA: 0x002B01CC File Offset: 0x002AF1CC
        Private Sub SetGFFNodeValues()
            Me.UTD.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocName", Me.NameLang)
            Me.UTD.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudHardness, "Hardness", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudHP, "HP", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudFort, "Fort", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudRef, "Ref", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudWill, "Will", 0.0F)
            If Not Me.UTD.VerifyNodeExists("Static") Then
                Me.UTD.AddFieldToStruct("", "Static", 0, Me.chkbStatic.Checked)
            Else
                Me.UTD.SetNodeValue("Static", Me.chkbStatic.Checked)
            End If
            Me.UTD.SetNodeValueFromComboBox(Me.cmbxDoorType, "GenericType")
            Me.UTD.SetNodeValue("Locked", Me.chkbLocked.Checked)
            Me.UTD.SetNodeValue("Lockable", Me.chkbLockable.Checked)
            Me.UTD.SetNodeValue("AutoRemoveKey", Me.chkbAutoRemoveKey.Checked)
            Me.UTD.SetNodeValue("KeyRequired", Me.chkbKeyRequired.Checked)
            Me.UTD.SetNodeValueFromTextBox(Me.tbKeyName, "KeyName")
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudOpenLockDC, "OpenLockDC", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudCloseLockDC, "CloseLockDC", 0.0F)
            If Me.KotorVersionIndex = 1 Then
                Me.UTD.SetNodeValue("NotBlastable", Me.chkbNotBlastable.Checked)
                Me.UTD.SetNodeValue("OpenState", Me.cmbxOpenState.SelectedIndex)
            End If
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnClick, "OnClick")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnClosed, "OnClosed")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnDamaged, "OnDamaged")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnDeath, "OnDeath")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnDisarm, "OnDisarm")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnFailToOpen, "OnFailToOpen")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnHeartbeat, "OnHeartbeat")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnLock, "OnLock")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnMeleeAttacked, "OnMeleeAttacked")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnOpen, "OnOpen")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnSpellCastAt, "OnSpellCastAt")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnUnlock, "OnUnlock")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnUserDefined, "OnUserDefined")
            Me.UTD.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTD.SetNodeValueFromComboBox(Me.cmbxFaction, "Faction")
            Me.UTD.SetNodeValueFromTextBox(Me.tbConversation, "Conversation")
            Me.UTD.SetNodeValue("Interruptable", Not Me.chkbNotInterruptable.Checked)
            Me.UTD.SetNodeValueFromTextBox(Me.tbAnimationState, "AnimationState")
            Me.UTD.SetCExoLocStringNodeValueFromTextBox(Me.tbDescription, "Description", 0)
            Dim textBox As TextBox = New TextBox()
            textBox.Text = Strings.Replace(Me.tbDescription.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary)
            Me.UTD.SetCExoLocStringNodeValueFromTextBox(textBox, "Description", Me.DescriptionLang)
            Me.UTD.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001372 RID: 4978 RVA: 0x002B0634 File Offset: 0x002AF634
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

        ' Token: 0x06001373 RID: 4979 RVA: 0x002B0770 File Offset: 0x002AF770
        Private Sub BuildComboBoxes()
            Me.g_clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me.FillComboBoxFrom2DA(Me.cmbxDoorType, "label", "genericdoors", Me.g_clsChitinKey, Nothing)
            If Not Me.UTD.SyncComboBox(Me.cmbxDoorType, "GenericType") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxFaction, "label", "repute", Me.g_clsChitinKey, Nothing)
            If Not Me.UTD.SyncComboBox(Me.cmbxFaction, "Faction") Then
                Me.ComboBoxSettingError = True
            End If
            Me.g_clsChitinKey = Nothing
        End Sub

        ' Token: 0x06001374 RID: 4980 RVA: 0x002B0818 File Offset: 0x002AF818
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

        ' Token: 0x06001375 RID: 4981 RVA: 0x002B08B8 File Offset: 0x002AF8B8
        Private Sub chkbLocked_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.chkbLockable.Checked Then
                Dim flag As Boolean = BooleanType.FromObject(LateBinding.LateGet(sender, Nothing, "checked", New Object(-1) {}, Nothing, Nothing))
                Me.chkbAutoRemoveKey.Enabled = flag
                Me.chkbKeyRequired.Enabled = flag
                Me.lblOpenLockDC.Enabled = flag
                Me.lblKeyTag.Enabled = flag
                Me.tbKeyName.Enabled = flag
                Me.nudOpenLockDC.Enabled = flag
                Me.chkbNotBlastable.Enabled = flag
            End If
        End Sub

        ' Token: 0x06001376 RID: 4982 RVA: 0x002B0940 File Offset: 0x002AF940
        Private Sub chkbLockable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim flag As Boolean = BooleanType.FromObject(LateBinding.LateGet(sender, Nothing, "checked", New Object(-1) {}, Nothing, Nothing))
            If Not Me.chkbLocked.Checked Then
                Me.chkbAutoRemoveKey.Enabled = flag
                Me.chkbKeyRequired.Enabled = flag
                Me.lblOpenLockDC.Enabled = flag
                Me.lblKeyTag.Enabled = flag
                Me.tbKeyName.Enabled = flag
                Me.nudOpenLockDC.Enabled = flag
                Me.chkbNotBlastable.Enabled = flag
            End If
            Me.lblCloseLockDC.Enabled = flag
            Me.nudCloseLockDC.Enabled = flag
        End Sub

        ' Token: 0x06001377 RID: 4983 RVA: 0x002B09E0 File Offset: 0x002AF9E0
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utd", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTD.WriteFile(Me.m_EditingFilePath, "UTD")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x06001378 RID: 4984 RVA: 0x002B0A78 File Offset: 0x002AFA78
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06001379 RID: 4985 RVA: 0x002B0AA8 File Offset: 0x002AFAA8
        Private Sub btnSetDescLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.DescriptionLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.DescriptionLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x0600137A RID: 4986 RVA: 0x002B0AD8 File Offset: 0x002AFAD8
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbName.Text + ".utd"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTD.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x0600137B RID: 4987 RVA: 0x002B0B4C File Offset: 0x002AFB4C
        Private Sub frmUTD_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600137C RID: 4988 RVA: 0x002B0B60 File Offset: 0x002AFB60
        Private Sub frmUTD_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600137D RID: 4989 RVA: 0x002B0B74 File Offset: 0x002AFB74
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Door Editor - " + Name
        End Sub

        ' Token: 0x0600137E RID: 4990 RVA: 0x002B0B88 File Offset: 0x002AFB88
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x040008F9 RID: 2297
        <AccessedThroughProperty("lblCloseLockDC")> _
        Private _lblCloseLockDC As Label

        ' Token: 0x040008FA RID: 2298
        <AccessedThroughProperty("lblOpenLockDC")> _
        Private _lblOpenLockDC As Label

        ' Token: 0x040008FB RID: 2299
        <AccessedThroughProperty("chkbStatic")> _
        Private _chkbStatic As CheckBox

        ' Token: 0x040008FC RID: 2300
        <AccessedThroughProperty("cmbxDoorType")> _
        Private _cmbxDoorType As ComboBox

        ' Token: 0x040008FD RID: 2301
        <AccessedThroughProperty("lblKeyTag")> _
        Private _lblKeyTag As Label

        ' Token: 0x040008FE RID: 2302
        <AccessedThroughProperty("cmbxOpenState")> _
        Private _cmbxOpenState As ComboBox

        ' Token: 0x040008FF RID: 2303
        <AccessedThroughProperty("chkbNotBlastable")> _
        Private _chkbNotBlastable As CheckBox

        ' Token: 0x04000900 RID: 2304
        <AccessedThroughProperty("lblOpenState")> _
        Private _lblOpenState As Label

        ' Token: 0x04000901 RID: 2305
        <AccessedThroughProperty("btnEditOnTrapTriggered")> _
        Private _btnEditOnTrapTriggered As Button

        ' Token: 0x04000902 RID: 2306
        <AccessedThroughProperty("tbAnimationState")> _
        Private _tbAnimationState As TextBox

        ' Token: 0x04000903 RID: 2307
        <AccessedThroughProperty("tbOnFailToOpen")> _
        Private _tbOnFailToOpen As TextBox

        ' Token: 0x04000904 RID: 2308
        <AccessedThroughProperty("chkbNotInterruptable")> _
        Private _chkbNotInterruptable As CheckBox

        ' Token: 0x04000905 RID: 2309
        <AccessedThroughProperty("tbOnClick")> _
        Private _tbOnClick As TextBox

        ' Token: 0x04000906 RID: 2310
        <AccessedThroughProperty("btnSetNameLang")> _
        Private _btnSetNameLang As Button

        ' Token: 0x04000907 RID: 2311
        <AccessedThroughProperty("nudRef")> _
        Private _nudRef As NumericUpDown

        ' Token: 0x04000908 RID: 2312
        <AccessedThroughProperty("nudHardness")> _
        Private _nudHardness As NumericUpDown

        ' Token: 0x04000909 RID: 2313
        <AccessedThroughProperty("btnEditOnDisarm")> _
        Private _btnEditOnDisarm As Button

        ' Token: 0x0400090A RID: 2314
        <AccessedThroughProperty("tbOnDeath")> _
        Private _tbOnDeath As TextBox

        ' Token: 0x0400090B RID: 2315
        <AccessedThroughProperty("nudHP")> _
        Private _nudHP As NumericUpDown

        ' Token: 0x0400090C RID: 2316
        <AccessedThroughProperty("nudFort")> _
        Private _nudFort As NumericUpDown

        ' Token: 0x0400090D RID: 2317
        <AccessedThroughProperty("Label39")> _
        Private _Label39 As Label

        ' Token: 0x0400090E RID: 2318
        <AccessedThroughProperty("btnEditOnClick")> _
        Private _btnEditOnClick As Button

        ' Token: 0x0400090F RID: 2319
        <AccessedThroughProperty("nudWill")> _
        Private _nudWill As NumericUpDown

        ' Token: 0x04000910 RID: 2320
        <AccessedThroughProperty("chkbAutoRemoveKey")> _
        Private _chkbAutoRemoveKey As CheckBox

        ' Token: 0x04000911 RID: 2321
        <AccessedThroughProperty("Label38")> _
        Private _Label38 As Label

        ' Token: 0x04000912 RID: 2322
        <AccessedThroughProperty("chkbKeyRequired")> _
        Private _chkbKeyRequired As CheckBox

        ' Token: 0x04000913 RID: 2323
        <AccessedThroughProperty("btnEditOnSpellCastAt")> _
        Private _btnEditOnSpellCastAt As Button

        ' Token: 0x04000914 RID: 2324
        <AccessedThroughProperty("btnEditOnClosed")> _
        Private _btnEditOnClosed As Button

        ' Token: 0x04000915 RID: 2325
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x04000916 RID: 2326
        <AccessedThroughProperty("btnEditOnFailToOpen")> _
        Private _btnEditOnFailToOpen As Button

        ' Token: 0x04000917 RID: 2327
        <AccessedThroughProperty("chkbLocked")> _
        Private _chkbLocked As CheckBox

        ' Token: 0x04000918 RID: 2328
        <AccessedThroughProperty("btnEditOnLock")> _
        Private _btnEditOnLock As Button

        ' Token: 0x04000919 RID: 2329
        <AccessedThroughProperty("chkbLockable")> _
        Private _chkbLockable As CheckBox

        ' Token: 0x0400091A RID: 2330
        <AccessedThroughProperty("tbOnDamaged")> _
        Private _tbOnDamaged As TextBox

        ' Token: 0x0400091B RID: 2331
        <AccessedThroughProperty("nudOpenLockDC")> _
        Private _nudOpenLockDC As NumericUpDown

        ' Token: 0x0400091C RID: 2332
        <AccessedThroughProperty("nudCloseLockDC")> _
        Private _nudCloseLockDC As NumericUpDown

        ' Token: 0x0400091D RID: 2333
        <AccessedThroughProperty("btnEditOnMeleeAttacked")> _
        Private _btnEditOnMeleeAttacked As Button

        ' Token: 0x0400091E RID: 2334
        <AccessedThroughProperty("tbKeyName")> _
        Private _tbKeyName As TextBox

        ' Token: 0x0400091F RID: 2335
        <AccessedThroughProperty("Label37")> _
        Private _Label37 As Label

        ' Token: 0x04000920 RID: 2336
        <AccessedThroughProperty("tbComment")> _
        Private _tbComment As TextBox

        ' Token: 0x04000921 RID: 2337
        <AccessedThroughProperty("tbOnHeartbeat")> _
        Private _tbOnHeartbeat As TextBox

        ' Token: 0x04000922 RID: 2338
        <AccessedThroughProperty("btnEditOnOpen")> _
        Private _btnEditOnOpen As Button

        ' Token: 0x04000923 RID: 2339
        <AccessedThroughProperty("btnEditOnUnlock")> _
        Private _btnEditOnUnlock As Button

        ' Token: 0x04000924 RID: 2340
        <AccessedThroughProperty("btnEditOnUserDefined")> _
        Private _btnEditOnUserDefined As Button

        ' Token: 0x04000925 RID: 2341
        <AccessedThroughProperty("tbTemplateResRef")> _
        Private _tbTemplateResRef As TextBox

        ' Token: 0x04000926 RID: 2342
        <AccessedThroughProperty("tbOnUserDefined")> _
        Private _tbOnUserDefined As TextBox

        ' Token: 0x04000927 RID: 2343
        <AccessedThroughProperty("tbOnUnlock")> _
        Private _tbOnUnlock As TextBox

        ' Token: 0x04000928 RID: 2344
        <AccessedThroughProperty("tbConversation")> _
        Private _tbConversation As TextBox

        ' Token: 0x04000929 RID: 2345
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x0400092A RID: 2346
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As Button

        ' Token: 0x0400092B RID: 2347
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x0400092C RID: 2348
        <AccessedThroughProperty("tbOnTrapTriggered")> _
        Private _tbOnTrapTriggered As TextBox

        ' Token: 0x0400092D RID: 2349
        <AccessedThroughProperty("Label40")> _
        Private _Label40 As Label

        ' Token: 0x0400092E RID: 2350
        <AccessedThroughProperty("Label41")> _
        Private _Label41 As Label

        ' Token: 0x0400092F RID: 2351
        <AccessedThroughProperty("Label42")> _
        Private _Label42 As Label

        ' Token: 0x04000930 RID: 2352
        <AccessedThroughProperty("Label43")> _
        Private _Label43 As Label

        ' Token: 0x04000931 RID: 2353
        <AccessedThroughProperty("btnEditOnDamaged")> _
        Private _btnEditOnDamaged As Button

        ' Token: 0x04000932 RID: 2354
        <AccessedThroughProperty("tbOnSpellCastAt")> _
        Private _tbOnSpellCastAt As TextBox

        ' Token: 0x04000933 RID: 2355
        <AccessedThroughProperty("Label19")> _
        Private _Label19 As Label

        ' Token: 0x04000934 RID: 2356
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000935 RID: 2357
        <AccessedThroughProperty("btnEditOnHeartbeat")> _
        Private _btnEditOnHeartbeat As Button

        ' Token: 0x04000936 RID: 2358
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x04000937 RID: 2359
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000938 RID: 2360
        <AccessedThroughProperty("tbOnOpen")> _
        Private _tbOnOpen As TextBox

        ' Token: 0x04000939 RID: 2361
        <AccessedThroughProperty("tbOnMeleeAttacked")> _
        Private _tbOnMeleeAttacked As TextBox

        ' Token: 0x0400093A RID: 2362
        <AccessedThroughProperty("btnSetDescriptionLang")> _
        Private _btnSetDescriptionLang As Button

        ' Token: 0x0400093B RID: 2363
        <AccessedThroughProperty("tbOnLock")> _
        Private _tbOnLock As TextBox

        ' Token: 0x0400093C RID: 2364
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x0400093D RID: 2365
        <AccessedThroughProperty("btnEditOnDeath")> _
        Private _btnEditOnDeath As Button

        ' Token: 0x0400093E RID: 2366
        <AccessedThroughProperty("tbOnDisarm")> _
        Private _tbOnDisarm As TextBox

        ' Token: 0x0400093F RID: 2367
        <AccessedThroughProperty("Label36")> _
        Private _Label36 As Label

        ' Token: 0x04000940 RID: 2368
        <AccessedThroughProperty("tbName")> _
        Private _tbName As TextBox

        ' Token: 0x04000941 RID: 2369
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

        ' Token: 0x04000942 RID: 2370
        <AccessedThroughProperty("cmbxFaction")> _
        Private _cmbxFaction As ComboBox

        ' Token: 0x04000943 RID: 2371
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000944 RID: 2372
        <AccessedThroughProperty("tbOnClosed")> _
        Private _tbOnClosed As TextBox

        ' Token: 0x04000945 RID: 2373
        <AccessedThroughProperty("Label35")> _
        Private _Label35 As Label

        ' Token: 0x04000946 RID: 2374
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x04000947 RID: 2375
        <AccessedThroughProperty("lblBodyVariation")> _
        Private _lblBodyVariation As Label

        ' Token: 0x04000948 RID: 2376
        <AccessedThroughProperty("Label13")> _
        Private _Label13 As Label

        ' Token: 0x04000949 RID: 2377
        <AccessedThroughProperty("lblTextureVariation")> _
        Private _lblTextureVariation As Label

        ' Token: 0x0400094A RID: 2378
        <AccessedThroughProperty("chkbPlotItem")> _
        Private _chkbPlotItem As CheckBox

        ' Token: 0x0400094B RID: 2379
        <AccessedThroughProperty("tbDescription")> _
        Private _tbDescription As TextBox

        ' Token: 0x0400094C RID: 2380
        <AccessedThroughProperty("Label34")> _
        Private _Label34 As Label

        ' Token: 0x0400094D RID: 2381
        <AccessedThroughProperty("TabPageComments")> _
        Private _TabPageComments As TabPage

        ' Token: 0x0400094E RID: 2382
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x0400094F RID: 2383
        <AccessedThroughProperty("TabPageDescription")> _
        Private _TabPageDescription As TabPage

        ' Token: 0x04000950 RID: 2384
        <AccessedThroughProperty("TabPageAdvanced")> _
        Private _TabPageAdvanced As TabPage

        ' Token: 0x04000951 RID: 2385
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x04000952 RID: 2386
        <AccessedThroughProperty("TabPageScripts")> _
        Private _TabPageScripts As TabPage

        ' Token: 0x04000953 RID: 2387
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000954 RID: 2388
        <AccessedThroughProperty("Label33")> _
        Private _Label33 As Label

        ' Token: 0x04000955 RID: 2389
        <AccessedThroughProperty("TabPageLock")> _
        Private _TabPageLock As TabPage

        ' Token: 0x04000956 RID: 2390
        <AccessedThroughProperty("TabPageBasic")> _
        Private _TabPageBasic As TabPage

        ' Token: 0x04000957 RID: 2391
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000958 RID: 2392
        <AccessedThroughProperty("Label32")> _
        Private _Label32 As Label

        ' Token: 0x0400095A RID: 2394
        Public UTD As clsUTD

        ' Token: 0x0400095B RID: 2395
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x0400095C RID: 2396
        Private ComboBoxSettingError As Boolean

        ' Token: 0x0400095D RID: 2397
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x0400095E RID: 2398
        Private DescriptionLang As Integer

        ' Token: 0x0400095F RID: 2399
        Private NameLang As Integer

        ' Token: 0x04000960 RID: 2400
        Private m_bSaveGameMode As Boolean
    End Class
End Namespace
