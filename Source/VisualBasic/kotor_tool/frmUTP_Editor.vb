Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
    ' Token: 0x02000081 RID: 129
    Partial Public Class frmUTP_Editor
        Inherits frmParent

        ' Token: 0x0600143F RID: 5183 RVA: 0x002B802C File Offset: 0x002B702C
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmUTP_Editor_Load
            AddHandler MyBase.Closing, AddressOf Me.frmUTP_Editor_Closing
            Me.m_bSaveGameMode = False
            Me.InitializeComponent()
        End Sub

        ' Token: 0x17000784 RID: 1924
        ' (get) Token: 0x06001441 RID: 5185 RVA: 0x002B80A4 File Offset: 0x002B70A4
        ' (set) Token: 0x06001442 RID: 5186 RVA: 0x002B8088 File Offset: 0x002B7088
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

        ' Token: 0x17000785 RID: 1925
        ' (get) Token: 0x06001443 RID: 5187 RVA: 0x002B80D4 File Offset: 0x002B70D4
        ' (set) Token: 0x06001444 RID: 5188 RVA: 0x002B80B8 File Offset: 0x002B70B8
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

        ' Token: 0x17000786 RID: 1926
        ' (get) Token: 0x06001445 RID: 5189 RVA: 0x002B80E8 File Offset: 0x002B70E8
        ' (set) Token: 0x06001446 RID: 5190 RVA: 0x002B80FC File Offset: 0x002B70FC
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

        ' Token: 0x17000787 RID: 1927
        ' (get) Token: 0x06001447 RID: 5191 RVA: 0x002B8150 File Offset: 0x002B7150
        ' (set) Token: 0x06001448 RID: 5192 RVA: 0x002B8164 File Offset: 0x002B7164
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

        ' Token: 0x17000788 RID: 1928
        ' (get) Token: 0x06001449 RID: 5193 RVA: 0x002B8180 File Offset: 0x002B7180
        ' (set) Token: 0x0600144A RID: 5194 RVA: 0x002B8194 File Offset: 0x002B7194
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

        ' Token: 0x17000789 RID: 1929
        ' (get) Token: 0x0600144B RID: 5195 RVA: 0x002B81CC File Offset: 0x002B71CC
        ' (set) Token: 0x0600144C RID: 5196 RVA: 0x002B81B0 File Offset: 0x002B71B0
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

        ' Token: 0x1700078A RID: 1930
        ' (get) Token: 0x0600144D RID: 5197 RVA: 0x002B81FC File Offset: 0x002B71FC
        ' (set) Token: 0x0600144E RID: 5198 RVA: 0x002B81E0 File Offset: 0x002B71E0
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

        ' Token: 0x1700078B RID: 1931
        ' (get) Token: 0x06001450 RID: 5200 RVA: 0x002B8210 File Offset: 0x002B7210
        ' (set) Token: 0x0600144F RID: 5199 RVA: 0x002B8224 File Offset: 0x002B7224
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

        ' Token: 0x1700078C RID: 1932
        ' (get) Token: 0x06001451 RID: 5201 RVA: 0x002B8240 File Offset: 0x002B7240
        ' (set) Token: 0x06001452 RID: 5202 RVA: 0x002B8254 File Offset: 0x002B7254
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

        ' Token: 0x1700078D RID: 1933
        ' (get) Token: 0x06001453 RID: 5203 RVA: 0x002B8270 File Offset: 0x002B7270
        ' (set) Token: 0x06001454 RID: 5204 RVA: 0x002B8284 File Offset: 0x002B7284
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

        ' Token: 0x1700078E RID: 1934
        ' (get) Token: 0x06001456 RID: 5206 RVA: 0x002B82BC File Offset: 0x002B72BC
        ' (set) Token: 0x06001455 RID: 5205 RVA: 0x002B82A0 File Offset: 0x002B72A0
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

        ' Token: 0x1700078F RID: 1935
        ' (get) Token: 0x06001457 RID: 5207 RVA: 0x002B82EC File Offset: 0x002B72EC
        ' (set) Token: 0x06001458 RID: 5208 RVA: 0x002B82D0 File Offset: 0x002B72D0
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

        ' Token: 0x17000790 RID: 1936
        ' (get) Token: 0x06001459 RID: 5209 RVA: 0x002B831C File Offset: 0x002B731C
        ' (set) Token: 0x0600145A RID: 5210 RVA: 0x002B8300 File Offset: 0x002B7300
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

        ' Token: 0x17000791 RID: 1937
        ' (get) Token: 0x0600145B RID: 5211 RVA: 0x002B834C File Offset: 0x002B734C
        ' (set) Token: 0x0600145C RID: 5212 RVA: 0x002B8330 File Offset: 0x002B7330
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

        ' Token: 0x17000792 RID: 1938
        ' (get) Token: 0x0600145E RID: 5214 RVA: 0x002B8360 File Offset: 0x002B7360
        ' (set) Token: 0x0600145D RID: 5213 RVA: 0x002B8374 File Offset: 0x002B7374
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

        ' Token: 0x17000793 RID: 1939
        ' (get) Token: 0x06001460 RID: 5216 RVA: 0x002B8390 File Offset: 0x002B7390
        ' (set) Token: 0x0600145F RID: 5215 RVA: 0x002B83A4 File Offset: 0x002B73A4
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

        ' Token: 0x17000794 RID: 1940
        ' (get) Token: 0x06001462 RID: 5218 RVA: 0x002B83DC File Offset: 0x002B73DC
        ' (set) Token: 0x06001461 RID: 5217 RVA: 0x002B83C0 File Offset: 0x002B73C0
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

        ' Token: 0x17000795 RID: 1941
        ' (get) Token: 0x06001463 RID: 5219 RVA: 0x002B840C File Offset: 0x002B740C
        ' (set) Token: 0x06001464 RID: 5220 RVA: 0x002B83F0 File Offset: 0x002B73F0
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

        ' Token: 0x17000796 RID: 1942
        ' (get) Token: 0x06001465 RID: 5221 RVA: 0x002B8420 File Offset: 0x002B7420
        ' (set) Token: 0x06001466 RID: 5222 RVA: 0x002B8434 File Offset: 0x002B7434
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

        ' Token: 0x17000797 RID: 1943
        ' (get) Token: 0x06001468 RID: 5224 RVA: 0x002B8450 File Offset: 0x002B7450
        ' (set) Token: 0x06001467 RID: 5223 RVA: 0x002B8464 File Offset: 0x002B7464
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

        ' Token: 0x17000798 RID: 1944
        ' (get) Token: 0x0600146A RID: 5226 RVA: 0x002B8480 File Offset: 0x002B7480
        ' (set) Token: 0x06001469 RID: 5225 RVA: 0x002B8494 File Offset: 0x002B7494
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

        ' Token: 0x17000799 RID: 1945
        ' (get) Token: 0x0600146B RID: 5227 RVA: 0x002B84B0 File Offset: 0x002B74B0
        ' (set) Token: 0x0600146C RID: 5228 RVA: 0x002B84C4 File Offset: 0x002B74C4
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

        ' Token: 0x1700079A RID: 1946
        ' (get) Token: 0x0600146E RID: 5230 RVA: 0x002B84FC File Offset: 0x002B74FC
        ' (set) Token: 0x0600146D RID: 5229 RVA: 0x002B84E0 File Offset: 0x002B74E0
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

        ' Token: 0x1700079B RID: 1947
        ' (get) Token: 0x06001470 RID: 5232 RVA: 0x002B852C File Offset: 0x002B752C
        ' (set) Token: 0x0600146F RID: 5231 RVA: 0x002B8510 File Offset: 0x002B7510
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

        ' Token: 0x1700079C RID: 1948
        ' (get) Token: 0x06001471 RID: 5233 RVA: 0x002B8540 File Offset: 0x002B7540
        ' (set) Token: 0x06001472 RID: 5234 RVA: 0x002B8554 File Offset: 0x002B7554
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

        ' Token: 0x1700079D RID: 1949
        ' (get) Token: 0x06001473 RID: 5235 RVA: 0x002B858C File Offset: 0x002B758C
        ' (set) Token: 0x06001474 RID: 5236 RVA: 0x002B8570 File Offset: 0x002B7570
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

        ' Token: 0x1700079E RID: 1950
        ' (get) Token: 0x06001475 RID: 5237 RVA: 0x002B85F4 File Offset: 0x002B75F4
        ' (set) Token: 0x06001476 RID: 5238 RVA: 0x002B85A0 File Offset: 0x002B75A0
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

        ' Token: 0x1700079F RID: 1951
        ' (get) Token: 0x06001477 RID: 5239 RVA: 0x002B865C File Offset: 0x002B765C
        ' (set) Token: 0x06001478 RID: 5240 RVA: 0x002B8608 File Offset: 0x002B7608
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

        ' Token: 0x170007A0 RID: 1952
        ' (get) Token: 0x06001479 RID: 5241 RVA: 0x002B868C File Offset: 0x002B768C
        ' (set) Token: 0x0600147A RID: 5242 RVA: 0x002B8670 File Offset: 0x002B7670
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

        ' Token: 0x170007A1 RID: 1953
        ' (get) Token: 0x0600147B RID: 5243 RVA: 0x002B86A0 File Offset: 0x002B76A0
        ' (set) Token: 0x0600147C RID: 5244 RVA: 0x002B86B4 File Offset: 0x002B76B4
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

        ' Token: 0x170007A2 RID: 1954
        ' (get) Token: 0x0600147E RID: 5246 RVA: 0x002B86EC File Offset: 0x002B76EC
        ' (set) Token: 0x0600147D RID: 5245 RVA: 0x002B86D0 File Offset: 0x002B76D0
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

        ' Token: 0x170007A3 RID: 1955
        ' (get) Token: 0x06001480 RID: 5248 RVA: 0x002B8700 File Offset: 0x002B7700
        ' (set) Token: 0x0600147F RID: 5247 RVA: 0x002B8714 File Offset: 0x002B7714
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

        ' Token: 0x170007A4 RID: 1956
        ' (get) Token: 0x06001482 RID: 5250 RVA: 0x002B874C File Offset: 0x002B774C
        ' (set) Token: 0x06001481 RID: 5249 RVA: 0x002B8730 File Offset: 0x002B7730
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

        ' Token: 0x170007A5 RID: 1957
        ' (get) Token: 0x06001484 RID: 5252 RVA: 0x002B8760 File Offset: 0x002B7760
        ' (set) Token: 0x06001483 RID: 5251 RVA: 0x002B8774 File Offset: 0x002B7774
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

        ' Token: 0x170007A6 RID: 1958
        ' (get) Token: 0x06001485 RID: 5253 RVA: 0x002B87AC File Offset: 0x002B77AC
        ' (set) Token: 0x06001486 RID: 5254 RVA: 0x002B8790 File Offset: 0x002B7790
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

        ' Token: 0x170007A7 RID: 1959
        ' (get) Token: 0x06001488 RID: 5256 RVA: 0x002B87DC File Offset: 0x002B77DC
        ' (set) Token: 0x06001487 RID: 5255 RVA: 0x002B87C0 File Offset: 0x002B77C0
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

        ' Token: 0x170007A8 RID: 1960
        ' (get) Token: 0x0600148A RID: 5258 RVA: 0x002B87F0 File Offset: 0x002B77F0
        ' (set) Token: 0x06001489 RID: 5257 RVA: 0x002B8804 File Offset: 0x002B7804
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

        ' Token: 0x170007A9 RID: 1961
        ' (get) Token: 0x0600148C RID: 5260 RVA: 0x002B8820 File Offset: 0x002B7820
        ' (set) Token: 0x0600148B RID: 5259 RVA: 0x002B8834 File Offset: 0x002B7834
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

        ' Token: 0x170007AA RID: 1962
        ' (get) Token: 0x0600148E RID: 5262 RVA: 0x002B886C File Offset: 0x002B786C
        ' (set) Token: 0x0600148D RID: 5261 RVA: 0x002B8850 File Offset: 0x002B7850
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

        ' Token: 0x170007AB RID: 1963
        ' (get) Token: 0x06001490 RID: 5264 RVA: 0x002B8880 File Offset: 0x002B7880
        ' (set) Token: 0x0600148F RID: 5263 RVA: 0x002B8894 File Offset: 0x002B7894
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

        ' Token: 0x170007AC RID: 1964
        ' (get) Token: 0x06001491 RID: 5265 RVA: 0x002B88B0 File Offset: 0x002B78B0
        ' (set) Token: 0x06001492 RID: 5266 RVA: 0x002B88C4 File Offset: 0x002B78C4
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

        ' Token: 0x170007AD RID: 1965
        ' (get) Token: 0x06001494 RID: 5268 RVA: 0x002B88FC File Offset: 0x002B78FC
        ' (set) Token: 0x06001493 RID: 5267 RVA: 0x002B88E0 File Offset: 0x002B78E0
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

        ' Token: 0x170007AE RID: 1966
        ' (get) Token: 0x06001496 RID: 5270 RVA: 0x002B892C File Offset: 0x002B792C
        ' (set) Token: 0x06001495 RID: 5269 RVA: 0x002B8910 File Offset: 0x002B7910
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

        ' Token: 0x170007AF RID: 1967
        ' (get) Token: 0x06001497 RID: 5271 RVA: 0x002B8940 File Offset: 0x002B7940
        ' (set) Token: 0x06001498 RID: 5272 RVA: 0x002B8954 File Offset: 0x002B7954
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

        ' Token: 0x170007B0 RID: 1968
        ' (get) Token: 0x06001499 RID: 5273 RVA: 0x002B898C File Offset: 0x002B798C
        ' (set) Token: 0x0600149A RID: 5274 RVA: 0x002B8970 File Offset: 0x002B7970
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

        ' Token: 0x170007B1 RID: 1969
        ' (get) Token: 0x0600149B RID: 5275 RVA: 0x002B89A0 File Offset: 0x002B79A0
        ' (set) Token: 0x0600149C RID: 5276 RVA: 0x002B89B4 File Offset: 0x002B79B4
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

        ' Token: 0x170007B2 RID: 1970
        ' (get) Token: 0x0600149D RID: 5277 RVA: 0x002B89EC File Offset: 0x002B79EC
        ' (set) Token: 0x0600149E RID: 5278 RVA: 0x002B89D0 File Offset: 0x002B79D0
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

        ' Token: 0x170007B3 RID: 1971
        ' (get) Token: 0x0600149F RID: 5279 RVA: 0x002B8A1C File Offset: 0x002B7A1C
        ' (set) Token: 0x060014A0 RID: 5280 RVA: 0x002B8A00 File Offset: 0x002B7A00
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

        ' Token: 0x170007B4 RID: 1972
        ' (get) Token: 0x060014A2 RID: 5282 RVA: 0x002B8A30 File Offset: 0x002B7A30
        ' (set) Token: 0x060014A1 RID: 5281 RVA: 0x002B8A44 File Offset: 0x002B7A44
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

        ' Token: 0x170007B5 RID: 1973
        ' (get) Token: 0x060014A3 RID: 5283 RVA: 0x002B8A60 File Offset: 0x002B7A60
        ' (set) Token: 0x060014A4 RID: 5284 RVA: 0x002B8A74 File Offset: 0x002B7A74
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

        ' Token: 0x170007B6 RID: 1974
        ' (get) Token: 0x060014A5 RID: 5285 RVA: 0x002B8A90 File Offset: 0x002B7A90
        ' (set) Token: 0x060014A6 RID: 5286 RVA: 0x002B8AA4 File Offset: 0x002B7AA4
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

        ' Token: 0x170007B7 RID: 1975
        ' (get) Token: 0x060014A7 RID: 5287 RVA: 0x002B8AC0 File Offset: 0x002B7AC0
        ' (set) Token: 0x060014A8 RID: 5288 RVA: 0x002B8AD4 File Offset: 0x002B7AD4
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

        ' Token: 0x170007B8 RID: 1976
        ' (get) Token: 0x060014AA RID: 5290 RVA: 0x002B8AF0 File Offset: 0x002B7AF0
        ' (set) Token: 0x060014A9 RID: 5289 RVA: 0x002B8B04 File Offset: 0x002B7B04
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

        ' Token: 0x170007B9 RID: 1977
        ' (get) Token: 0x060014AB RID: 5291 RVA: 0x002B8B20 File Offset: 0x002B7B20
        ' (set) Token: 0x060014AC RID: 5292 RVA: 0x002B8B34 File Offset: 0x002B7B34
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

        ' Token: 0x170007BA RID: 1978
        ' (get) Token: 0x060014AE RID: 5294 RVA: 0x002B8B6C File Offset: 0x002B7B6C
        ' (set) Token: 0x060014AD RID: 5293 RVA: 0x002B8B50 File Offset: 0x002B7B50
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

        ' Token: 0x170007BB RID: 1979
        ' (get) Token: 0x060014AF RID: 5295 RVA: 0x002B8B80 File Offset: 0x002B7B80
        ' (set) Token: 0x060014B0 RID: 5296 RVA: 0x002B8B94 File Offset: 0x002B7B94
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

        ' Token: 0x170007BC RID: 1980
        ' (get) Token: 0x060014B1 RID: 5297 RVA: 0x002B8BB0 File Offset: 0x002B7BB0
        ' (set) Token: 0x060014B2 RID: 5298 RVA: 0x002B8BC4 File Offset: 0x002B7BC4
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

        ' Token: 0x170007BD RID: 1981
        ' (get) Token: 0x060014B3 RID: 5299 RVA: 0x002B8BE0 File Offset: 0x002B7BE0
        ' (set) Token: 0x060014B4 RID: 5300 RVA: 0x002B8BF4 File Offset: 0x002B7BF4
        Friend Overridable Property tbFaction() As TextBox
            Get
                Return Me._tbFaction
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbFaction IsNot Nothing Then
                End If
                Me._tbFaction = value
                If Me._tbFaction IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007BE RID: 1982
        ' (get) Token: 0x060014B5 RID: 5301 RVA: 0x002B8C10 File Offset: 0x002B7C10
        ' (set) Token: 0x060014B6 RID: 5302 RVA: 0x002B8C24 File Offset: 0x002B7C24
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

        ' Token: 0x170007BF RID: 1983
        ' (get) Token: 0x060014B8 RID: 5304 RVA: 0x002B8C5C File Offset: 0x002B7C5C
        ' (set) Token: 0x060014B7 RID: 5303 RVA: 0x002B8C40 File Offset: 0x002B7C40
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

        ' Token: 0x170007C0 RID: 1984
        ' (get) Token: 0x060014B9 RID: 5305 RVA: 0x002B8C8C File Offset: 0x002B7C8C
        ' (set) Token: 0x060014BA RID: 5306 RVA: 0x002B8C70 File Offset: 0x002B7C70
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

        ' Token: 0x170007C1 RID: 1985
        ' (get) Token: 0x060014BB RID: 5307 RVA: 0x002B8CBC File Offset: 0x002B7CBC
        ' (set) Token: 0x060014BC RID: 5308 RVA: 0x002B8CA0 File Offset: 0x002B7CA0
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

        ' Token: 0x170007C2 RID: 1986
        ' (get) Token: 0x060014BD RID: 5309 RVA: 0x002B8CEC File Offset: 0x002B7CEC
        ' (set) Token: 0x060014BE RID: 5310 RVA: 0x002B8CD0 File Offset: 0x002B7CD0
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

        ' Token: 0x170007C3 RID: 1987
        ' (get) Token: 0x060014BF RID: 5311 RVA: 0x002B8D1C File Offset: 0x002B7D1C
        ' (set) Token: 0x060014C0 RID: 5312 RVA: 0x002B8D00 File Offset: 0x002B7D00
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

        ' Token: 0x170007C4 RID: 1988
        ' (get) Token: 0x060014C1 RID: 5313 RVA: 0x002B8D4C File Offset: 0x002B7D4C
        ' (set) Token: 0x060014C2 RID: 5314 RVA: 0x002B8D30 File Offset: 0x002B7D30
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

        ' Token: 0x170007C5 RID: 1989
        ' (get) Token: 0x060014C4 RID: 5316 RVA: 0x002B8D60 File Offset: 0x002B7D60
        ' (set) Token: 0x060014C3 RID: 5315 RVA: 0x002B8D74 File Offset: 0x002B7D74
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

        ' Token: 0x170007C6 RID: 1990
        ' (get) Token: 0x060014C5 RID: 5317 RVA: 0x002B8DE4 File Offset: 0x002B7DE4
        ' (set) Token: 0x060014C6 RID: 5318 RVA: 0x002B8DC8 File Offset: 0x002B7DC8
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

        ' Token: 0x170007C7 RID: 1991
        ' (get) Token: 0x060014C7 RID: 5319 RVA: 0x002B8DF8 File Offset: 0x002B7DF8
        ' (set) Token: 0x060014C8 RID: 5320 RVA: 0x002B8E0C File Offset: 0x002B7E0C
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

        ' Token: 0x170007C8 RID: 1992
        ' (get) Token: 0x060014C9 RID: 5321 RVA: 0x002B8E44 File Offset: 0x002B7E44
        ' (set) Token: 0x060014CA RID: 5322 RVA: 0x002B8E28 File Offset: 0x002B7E28
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

        ' Token: 0x170007C9 RID: 1993
        ' (get) Token: 0x060014CB RID: 5323 RVA: 0x002B8EAC File Offset: 0x002B7EAC
        ' (set) Token: 0x060014CC RID: 5324 RVA: 0x002B8E58 File Offset: 0x002B7E58
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

        ' Token: 0x170007CA RID: 1994
        ' (get) Token: 0x060014CD RID: 5325 RVA: 0x002B8EC0 File Offset: 0x002B7EC0
        ' (set) Token: 0x060014CE RID: 5326 RVA: 0x002B8ED4 File Offset: 0x002B7ED4
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

        ' Token: 0x170007CB RID: 1995
        ' (get) Token: 0x060014CF RID: 5327 RVA: 0x002B8F28 File Offset: 0x002B7F28
        ' (set) Token: 0x060014D0 RID: 5328 RVA: 0x002B8F3C File Offset: 0x002B7F3C
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

        ' Token: 0x170007CC RID: 1996
        ' (get) Token: 0x060014D1 RID: 5329 RVA: 0x002B8F58 File Offset: 0x002B7F58
        ' (set) Token: 0x060014D2 RID: 5330 RVA: 0x002B8F6C File Offset: 0x002B7F6C
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

        ' Token: 0x170007CD RID: 1997
        ' (get) Token: 0x060014D3 RID: 5331 RVA: 0x002B8FA4 File Offset: 0x002B7FA4
        ' (set) Token: 0x060014D4 RID: 5332 RVA: 0x002B8F88 File Offset: 0x002B7F88
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

        ' Token: 0x170007CE RID: 1998
        ' (get) Token: 0x060014D5 RID: 5333 RVA: 0x002B8FB8 File Offset: 0x002B7FB8
        ' (set) Token: 0x060014D6 RID: 5334 RVA: 0x002B8FCC File Offset: 0x002B7FCC
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

        ' Token: 0x170007CF RID: 1999
        ' (get) Token: 0x060014D8 RID: 5336 RVA: 0x002B8FE8 File Offset: 0x002B7FE8
        ' (set) Token: 0x060014D7 RID: 5335 RVA: 0x002B8FFC File Offset: 0x002B7FFC
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

        ' Token: 0x170007D0 RID: 2000
        ' (get) Token: 0x060014DA RID: 5338 RVA: 0x002B9034 File Offset: 0x002B8034
        ' (set) Token: 0x060014D9 RID: 5337 RVA: 0x002B9018 File Offset: 0x002B8018
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

        ' Token: 0x170007D1 RID: 2001
        ' (get) Token: 0x060014DB RID: 5339 RVA: 0x002B9048 File Offset: 0x002B8048
        ' (set) Token: 0x060014DC RID: 5340 RVA: 0x002B905C File Offset: 0x002B805C
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

        ' Token: 0x170007D2 RID: 2002
        ' (get) Token: 0x060014DE RID: 5342 RVA: 0x002B9078 File Offset: 0x002B8078
        ' (set) Token: 0x060014DD RID: 5341 RVA: 0x002B908C File Offset: 0x002B808C
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

        ' Token: 0x170007D3 RID: 2003
        ' (get) Token: 0x060014E0 RID: 5344 RVA: 0x002B90C4 File Offset: 0x002B80C4
        ' (set) Token: 0x060014DF RID: 5343 RVA: 0x002B90A8 File Offset: 0x002B80A8
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

        ' Token: 0x170007D4 RID: 2004
        ' (get) Token: 0x060014E2 RID: 5346 RVA: 0x002B90D8 File Offset: 0x002B80D8
        ' (set) Token: 0x060014E1 RID: 5345 RVA: 0x002B90EC File Offset: 0x002B80EC
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

        ' Token: 0x170007D5 RID: 2005
        ' (get) Token: 0x060014E3 RID: 5347 RVA: 0x002B9108 File Offset: 0x002B8108
        ' (set) Token: 0x060014E4 RID: 5348 RVA: 0x002B911C File Offset: 0x002B811C
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

        ' Token: 0x170007D6 RID: 2006
        ' (get) Token: 0x060014E6 RID: 5350 RVA: 0x002B9154 File Offset: 0x002B8154
        ' (set) Token: 0x060014E5 RID: 5349 RVA: 0x002B9138 File Offset: 0x002B8138
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

        ' Token: 0x170007D7 RID: 2007
        ' (get) Token: 0x060014E8 RID: 5352 RVA: 0x002B9168 File Offset: 0x002B8168
        ' (set) Token: 0x060014E7 RID: 5351 RVA: 0x002B917C File Offset: 0x002B817C
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

        ' Token: 0x170007D8 RID: 2008
        ' (get) Token: 0x060014EA RID: 5354 RVA: 0x002B9198 File Offset: 0x002B8198
        ' (set) Token: 0x060014E9 RID: 5353 RVA: 0x002B91AC File Offset: 0x002B81AC
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

        ' Token: 0x170007D9 RID: 2009
        ' (get) Token: 0x060014EB RID: 5355 RVA: 0x002B91E4 File Offset: 0x002B81E4
        ' (set) Token: 0x060014EC RID: 5356 RVA: 0x002B91C8 File Offset: 0x002B81C8
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

        ' Token: 0x170007DA RID: 2010
        ' (get) Token: 0x060014ED RID: 5357 RVA: 0x002B91F8 File Offset: 0x002B81F8
        ' (set) Token: 0x060014EE RID: 5358 RVA: 0x002B920C File Offset: 0x002B820C
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

        ' Token: 0x170007DB RID: 2011
        ' (get) Token: 0x060014F0 RID: 5360 RVA: 0x002B9244 File Offset: 0x002B8244
        ' (set) Token: 0x060014EF RID: 5359 RVA: 0x002B9228 File Offset: 0x002B8228
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

        ' Token: 0x170007DC RID: 2012
        ' (get) Token: 0x060014F1 RID: 5361 RVA: 0x002B9258 File Offset: 0x002B8258
        ' (set) Token: 0x060014F2 RID: 5362 RVA: 0x002B926C File Offset: 0x002B826C
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

        ' Token: 0x170007DD RID: 2013
        ' (get) Token: 0x060014F4 RID: 5364 RVA: 0x002B92A4 File Offset: 0x002B82A4
        ' (set) Token: 0x060014F3 RID: 5363 RVA: 0x002B9288 File Offset: 0x002B8288
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

        ' Token: 0x170007DE RID: 2014
        ' (get) Token: 0x060014F5 RID: 5365 RVA: 0x002B92D4 File Offset: 0x002B82D4
        ' (set) Token: 0x060014F6 RID: 5366 RVA: 0x002B92B8 File Offset: 0x002B82B8
        Friend Overridable Property tbType() As TextBox
            Get
                Return Me._tbType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbType IsNot Nothing Then
                End If
                Me._tbType = value
                If Me._tbType IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007DF RID: 2015
        ' (get) Token: 0x060014F7 RID: 5367 RVA: 0x002B92E8 File Offset: 0x002B82E8
        ' (set) Token: 0x060014F8 RID: 5368 RVA: 0x002B92FC File Offset: 0x002B82FC
        Friend Overridable Property tbOnUsed() As TextBox
            Get
                Return Me._tbOnUsed
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbOnUsed IsNot Nothing Then
                End If
                Me._tbOnUsed = value
                If Me._tbOnUsed IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007E0 RID: 2016
        ' (get) Token: 0x060014F9 RID: 5369 RVA: 0x002B9334 File Offset: 0x002B8334
        ' (set) Token: 0x060014FA RID: 5370 RVA: 0x002B9318 File Offset: 0x002B8318
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

        ' Token: 0x170007E1 RID: 2017
        ' (get) Token: 0x060014FB RID: 5371 RVA: 0x002B9348 File Offset: 0x002B8348
        ' (set) Token: 0x060014FC RID: 5372 RVA: 0x002B935C File Offset: 0x002B835C
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

        ' Token: 0x170007E2 RID: 2018
        ' (get) Token: 0x060014FE RID: 5374 RVA: 0x002B9378 File Offset: 0x002B8378
        ' (set) Token: 0x060014FD RID: 5373 RVA: 0x002B938C File Offset: 0x002B838C
        Friend Overridable Property tbOnEndDialogue() As TextBox
            Get
                Return Me._tbOnEndDialogue
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbOnEndDialogue IsNot Nothing Then
                End If
                Me._tbOnEndDialogue = value
                If Me._tbOnEndDialogue IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007E3 RID: 2019
        ' (get) Token: 0x060014FF RID: 5375 RVA: 0x002B93C4 File Offset: 0x002B83C4
        ' (set) Token: 0x06001500 RID: 5376 RVA: 0x002B93A8 File Offset: 0x002B83A8
        Friend Overridable Property tbOnInvDisturbed() As TextBox
            Get
                Return Me._tbOnInvDisturbed
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbOnInvDisturbed IsNot Nothing Then
                End If
                Me._tbOnInvDisturbed = value
                If Me._tbOnInvDisturbed IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007E4 RID: 2020
        ' (get) Token: 0x06001501 RID: 5377 RVA: 0x002B93D8 File Offset: 0x002B83D8
        ' (set) Token: 0x06001502 RID: 5378 RVA: 0x002B93EC File Offset: 0x002B83EC
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

        ' Token: 0x170007E5 RID: 2021
        ' (get) Token: 0x06001503 RID: 5379 RVA: 0x002B9408 File Offset: 0x002B8408
        ' (set) Token: 0x06001504 RID: 5380 RVA: 0x002B941C File Offset: 0x002B841C
        Friend Overridable Property chkbHasInventory() As CheckBox
            Get
                Return Me._chkbHasInventory
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkbHasInventory IsNot Nothing Then
                End If
                Me._chkbHasInventory = value
                If Me._chkbHasInventory IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007E6 RID: 2022
        ' (get) Token: 0x06001505 RID: 5381 RVA: 0x002B9438 File Offset: 0x002B8438
        ' (set) Token: 0x06001506 RID: 5382 RVA: 0x002B944C File Offset: 0x002B844C
        Friend Overridable Property chkbPartyInteract() As CheckBox
            Get
                Return Me._chkbPartyInteract
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkbPartyInteract IsNot Nothing Then
                End If
                Me._chkbPartyInteract = value
                If Me._chkbPartyInteract IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007E7 RID: 2023
        ' (get) Token: 0x06001508 RID: 5384 RVA: 0x002B94BC File Offset: 0x002B84BC
        ' (set) Token: 0x06001507 RID: 5383 RVA: 0x002B9468 File Offset: 0x002B8468
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

        ' Token: 0x170007E8 RID: 2024
        ' (get) Token: 0x06001509 RID: 5385 RVA: 0x002B94D0 File Offset: 0x002B84D0
        ' (set) Token: 0x0600150A RID: 5386 RVA: 0x002B94E4 File Offset: 0x002B84E4
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

        ' Token: 0x170007E9 RID: 2025
        ' (get) Token: 0x0600150B RID: 5387 RVA: 0x002B9554 File Offset: 0x002B8554
        ' (set) Token: 0x0600150C RID: 5388 RVA: 0x002B9538 File Offset: 0x002B8538
        Friend Overridable Property chkbUsable() As CheckBox
            Get
                Return Me._chkbUsable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkbUsable IsNot Nothing Then
                End If
                Me._chkbUsable = value
                If Me._chkbUsable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007EA RID: 2026
        ' (get) Token: 0x0600150D RID: 5389 RVA: 0x002B9568 File Offset: 0x002B8568
        ' (set) Token: 0x0600150E RID: 5390 RVA: 0x002B957C File Offset: 0x002B857C
        Friend Overridable Property chkbInterruptable() As CheckBox
            Get
                Return Me._chkbInterruptable
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                If Me._chkbInterruptable IsNot Nothing Then
                End If
                Me._chkbInterruptable = value
                If Me._chkbInterruptable IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170007EB RID: 2027
        ' (get) Token: 0x06001510 RID: 5392 RVA: 0x002B9598 File Offset: 0x002B8598
        ' (set) Token: 0x0600150F RID: 5391 RVA: 0x002B95AC File Offset: 0x002B85AC
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

        ' Token: 0x170007EC RID: 2028
        ' (get) Token: 0x06001511 RID: 5393 RVA: 0x002B9600 File Offset: 0x002B8600
        ' (set) Token: 0x06001512 RID: 5394 RVA: 0x002B9614 File Offset: 0x002B8614
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

        ' Token: 0x170007ED RID: 2029
        ' (get) Token: 0x06001513 RID: 5395 RVA: 0x002B96BC File Offset: 0x002B86BC
        ' (set) Token: 0x06001514 RID: 5396 RVA: 0x002B9668 File Offset: 0x002B8668
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

        ' Token: 0x170007EE RID: 2030
        ' (get) Token: 0x06001515 RID: 5397 RVA: 0x002B96D0 File Offset: 0x002B86D0
        ' (set) Token: 0x06001516 RID: 5398 RVA: 0x002B96E4 File Offset: 0x002B86E4
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

        ' Token: 0x170007EF RID: 2031
        ' (get) Token: 0x06001517 RID: 5399 RVA: 0x002B9738 File Offset: 0x002B8738
        ' (set) Token: 0x06001518 RID: 5400 RVA: 0x002B974C File Offset: 0x002B874C
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

        ' Token: 0x170007F0 RID: 2032
        ' (get) Token: 0x0600151A RID: 5402 RVA: 0x002B97F4 File Offset: 0x002B87F4
        ' (set) Token: 0x06001519 RID: 5401 RVA: 0x002B97A0 File Offset: 0x002B87A0
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

        ' Token: 0x170007F1 RID: 2033
        ' (get) Token: 0x0600151B RID: 5403 RVA: 0x002B985C File Offset: 0x002B885C
        ' (set) Token: 0x0600151C RID: 5404 RVA: 0x002B9808 File Offset: 0x002B8808
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

        ' Token: 0x170007F2 RID: 2034
        ' (get) Token: 0x0600151D RID: 5405 RVA: 0x002B98C4 File Offset: 0x002B88C4
        ' (set) Token: 0x0600151E RID: 5406 RVA: 0x002B9870 File Offset: 0x002B8870
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

        ' Token: 0x170007F3 RID: 2035
        ' (get) Token: 0x06001520 RID: 5408 RVA: 0x002B98D8 File Offset: 0x002B88D8
        ' (set) Token: 0x0600151F RID: 5407 RVA: 0x002B98EC File Offset: 0x002B88EC
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

        ' Token: 0x170007F4 RID: 2036
        ' (get) Token: 0x06001522 RID: 5410 RVA: 0x002B9994 File Offset: 0x002B8994
        ' (set) Token: 0x06001521 RID: 5409 RVA: 0x002B9940 File Offset: 0x002B8940
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

        ' Token: 0x170007F5 RID: 2037
        ' (get) Token: 0x06001524 RID: 5412 RVA: 0x002B99A8 File Offset: 0x002B89A8
        ' (set) Token: 0x06001523 RID: 5411 RVA: 0x002B99BC File Offset: 0x002B89BC
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

        ' Token: 0x170007F6 RID: 2038
        ' (get) Token: 0x06001525 RID: 5413 RVA: 0x002B9A64 File Offset: 0x002B8A64
        ' (set) Token: 0x06001526 RID: 5414 RVA: 0x002B9A10 File Offset: 0x002B8A10
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

        ' Token: 0x170007F7 RID: 2039
        ' (get) Token: 0x06001528 RID: 5416 RVA: 0x002B9A78 File Offset: 0x002B8A78
        ' (set) Token: 0x06001527 RID: 5415 RVA: 0x002B9A8C File Offset: 0x002B8A8C
        Friend Overridable Property btnEditOnUsed() As Button
            Get
                Return Me._btnEditOnUsed
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnEditOnUsed IsNot Nothing Then
                    RemoveHandler Me._btnEditOnUsed.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnUsed = value
                If Me._btnEditOnUsed IsNot Nothing Then
                    AddHandler Me._btnEditOnUsed.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170007F8 RID: 2040
        ' (get) Token: 0x06001529 RID: 5417 RVA: 0x002B9AE0 File Offset: 0x002B8AE0
        ' (set) Token: 0x0600152A RID: 5418 RVA: 0x002B9AF4 File Offset: 0x002B8AF4
        Friend Overridable Property btnEditOnInvDisturbed() As Button
            Get
                Return Me._btnEditOnInvDisturbed
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnEditOnInvDisturbed IsNot Nothing Then
                    RemoveHandler Me._btnEditOnInvDisturbed.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnInvDisturbed = value
                If Me._btnEditOnInvDisturbed IsNot Nothing Then
                    AddHandler Me._btnEditOnInvDisturbed.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x170007F9 RID: 2041
        ' (get) Token: 0x0600152C RID: 5420 RVA: 0x002B9B9C File Offset: 0x002B8B9C
        ' (set) Token: 0x0600152B RID: 5419 RVA: 0x002B9B48 File Offset: 0x002B8B48
        Friend Overridable Property btnEditOnEndDialogue() As Button
            Get
                Return Me._btnEditOnEndDialogue
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnEditOnEndDialogue IsNot Nothing Then
                    RemoveHandler Me._btnEditOnEndDialogue.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnEndDialogue = value
                If Me._btnEditOnEndDialogue IsNot Nothing Then
                    AddHandler Me._btnEditOnEndDialogue.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x0600152E RID: 5422 RVA: 0x002BDD1C File Offset: 0x002BCD1C
        Public Sub New(ByVal UTPClass As clsUTP, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Placeable Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTP = UTPClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
        End Sub

        ' Token: 0x0600152F RID: 5423 RVA: 0x002BDDCC File Offset: 0x002BCDCC
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x06001530 RID: 5424 RVA: 0x002BDDD4 File Offset: 0x002BCDD4
        Public Sub Setup()
            Me.BuildComboBoxes()
            Me.UTP.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocName")
            Me.UTP.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.chkbPlotItem.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Plot"))
            Me.chkbStatic.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Static"))
            Me.chkbMin1HP.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Min1HP"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudHardness, "Hardness", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudHP, "HP", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudFort, "Fort", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudRef, "Ref", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudWill, "Will", 0.0F)
            Me.chkbLocked.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Locked"))
            Me.chkbLockable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Lockable"))
            Me.chkbAutoRemoveKey.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("AutoRemoveKey"))
            Me.chkbKeyRequired.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("KeyRequired"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudOpenLockDC, "OpenLockDC", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudCloseLockDC, "CloseLockDC", 0.0F)
            Me.UTP.SetTextBoxToNodeValue(Me.tbKeyName, "KeyName")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnClosed, "OnClosed")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnDamaged, "OnDamaged")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnDeath, "OnDeath")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnDisarm, "OnDisarm")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnEndDialogue, "OnEndDialogue")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnHeartbeat, "OnHeartbeat")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnInvDisturbed, "OnInvDisturbed")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnLock, "OnLock")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnMeleeAttacked, "OnMeleeAttacked")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnOpen, "OnOpen")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnSpellCastAt, "OnSpellCastAt")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnUnlock, "OnUnlock")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnUsed, "OnUsed")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnUserDefined, "OnUserDefined")
            Me.UTP.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTP.SetTextBoxToNodeValue(Me.tbFaction, "Faction")
            Me.UTP.SetTextBoxToNodeValue(Me.tbConversation, "Conversation")
            Me.chkbInterruptable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Interruptable"))
            Me.UTP.SetTextBoxToNodeValue(Me.tbAnimationState, "AnimationState")
            Me.UTP.SetTextBoxToNodeValue(Me.tbType, "Type")
            Me.chkbHasInventory.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("HasInventory"))
            Me.chkbPartyInteract.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("PartyInteract"))
            Me.chkbUsable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Useable"))
            Me.chkbTrapDetectable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("TrapDetectable"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudTrapDetectDC, "TrapDetectDC", 0.0F)
            Me.chkbTrapDisarmable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("TrapDisarmable"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudDisarmDC, "DisarmDC", 0.0F)
            Me.chkbTrapFlag.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("TrapFlag"))
            Me.chkbTrapOneShot.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("TrapOneShot"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudTrapType, "TrapType", 0.0F)
            Me.UTP.SetTextBoxToNodeValue(Me.tbKeyName, "KeyName")
            Me.UTP.SetTextBoxFromCExoLocStringNodeValue(Me.tbDescription, "Description")
            Me.DescriptionLang = IntegerType.FromObject(Me.UTP.GetCExoLocStringLanguage("Description"))
            Me.tbDescription.Text = Strings.Replace(Me.tbDescription.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            Me.UTP.SetTextBoxToNodeValue(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001531 RID: 5425 RVA: 0x002BE358 File Offset: 0x002BD358
        Private Sub SetGFFNodeValues()
            Me.UTP.SetNodeValueFromComboBox(Me.cmbxAppearance, "Appearance")
            Me.UTP.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocName", Me.NameLang)
            Me.UTP.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTP.SetNodeValue("Plot", Me.chkbPlotItem.Checked)
            If Me.UTP.VerifyNodeExists("Static") Then
                Me.UTP.SetNodeValue("Static", Me.chkbStatic.Checked)
            End If
            If Me.UTP.VerifyNodeExists("Min1HP") Then
                Me.UTP.SetNodeValue("Min1HP", Me.chkbMin1HP.Checked)
            End If
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudHardness, "Hardness", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudHP, "HP", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudFort, "Fort", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudRef, "Ref", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudWill, "Will", 0.0F)
            Me.UTP.SetNodeValue("Locked", Me.chkbLocked.Checked)
            Me.UTP.SetNodeValue("Lockable", Me.chkbLockable.Checked)
            Me.UTP.SetNodeValue("AutoRemoveKey", Me.chkbAutoRemoveKey.Checked)
            Me.UTP.SetNodeValue("KeyRequired", Me.chkbKeyRequired.Checked)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudOpenLockDC, "OpenLockDC", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudCloseLockDC, "CloseLockDC", 0.0F)
            Me.UTP.SetNodeValueFromTextBox(Me.tbKeyName, "KeyName")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnClosed, "OnClosed")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnDamaged, "OnDamaged")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnDeath, "OnDeath")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnDisarm, "OnDisarm")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnEndDialogue, "OnEndDialogue")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnHeartbeat, "OnHeartbeat")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnInvDisturbed, "OnInvDisturbed")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnLock, "OnLock")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnMeleeAttacked, "OnMeleeAttacked")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnOpen, "OnOpen")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnSpellCastAt, "OnSpellCastAt")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnUnlock, "OnUnlock")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnUsed, "OnUsed")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnUserDefined, "OnUserDefined")
            Me.UTP.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTP.SetNodeValueFromTextBox(Me.tbFaction, "Faction")
            Me.UTP.SetNodeValueFromTextBox(Me.tbConversation, "Conversation")
            Me.UTP.SetNodeValue("Interruptable", Me.chkbInterruptable.Checked)
            Me.UTP.SetNodeValueFromTextBox(Me.tbAnimationState, "AnimationState")
            Me.UTP.SetNodeValueFromTextBox(Me.tbType, "Type")
            Me.UTP.SetNodeValue("HasInventory", Me.chkbHasInventory.Checked)
            Me.UTP.SetNodeValue("PartyInteract", Me.chkbPartyInteract.Checked)
            Me.UTP.SetNodeValue("Useable", Me.chkbUsable.Checked)
            Me.UTP.SetNodeValue("TrapDetectable", Me.chkbTrapDetectable.Checked)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudTrapDetectDC, "TrapDetectDC", 0.0F)
            Me.UTP.SetNodeValue("TrapDisarmable", Me.chkbTrapDisarmable.Checked)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudDisarmDC, "DisarmDC", 0.0F)
            Me.UTP.SetNodeValue("TrapFlag", Me.chkbTrapFlag.Checked)
            Me.UTP.SetNodeValue("TrapOneShot", Me.chkbTrapOneShot.Checked)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudTrapType, "TrapType", 0.0F)
            Me.UTP.SetNodeValueFromTextBox(Me.tbKeyName, "KeyName")
            Me.UTP.SetCExoLocStringNodeValueFromTextBox(Me.tbDescription, "Description", 0)
            Dim textBox As TextBox = New TextBox()
            textBox.Text = Strings.Replace(Me.tbDescription.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary)
            Me.UTP.SetCExoLocStringNodeValueFromTextBox(textBox, "Description", Me.DescriptionLang)
            Me.UTP.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001532 RID: 5426 RVA: 0x002BE910 File Offset: 0x002BD910
        Private Function BuildComboBoxes() As Object
            Me.g_clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me.FillComboBoxFrom2DA(Me.cmbxAppearance, "label", "placeables", Me.g_clsChitinKey, Nothing)
            If Not Me.UTP.SyncComboBox(Me.cmbxAppearance, "Appearance") Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
            Me.g_clsChitinKey = Nothing
            Dim obj As Object = Nothing
            Return obj
        End Function

        ' Token: 0x06001533 RID: 5427 RVA: 0x002BE988 File Offset: 0x002BD988
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

        ' Token: 0x06001534 RID: 5428 RVA: 0x002BEA28 File Offset: 0x002BDA28
        Private Sub chkbLocked_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.chkbLockable.Checked Then
                Dim flag As Boolean = BooleanType.FromObject(LateBinding.LateGet(sender, Nothing, "checked", New Object(-1) {}, Nothing, Nothing))
                Me.chkbAutoRemoveKey.Enabled = flag
                Me.chkbKeyRequired.Enabled = flag
                Me.lblOpenLockDC.Enabled = flag
                Me.lblKeyTag.Enabled = flag
                Me.tbKeyName.Enabled = flag
                Me.nudOpenLockDC.Enabled = flag
            End If
        End Sub

        ' Token: 0x06001535 RID: 5429 RVA: 0x002BEAA4 File Offset: 0x002BDAA4
        Private Sub chkbLockable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim flag As Boolean = BooleanType.FromObject(LateBinding.LateGet(sender, Nothing, "checked", New Object(-1) {}, Nothing, Nothing))
            If Not Me.chkbLocked.Checked Then
                Me.chkbAutoRemoveKey.Enabled = flag
                Me.chkbKeyRequired.Enabled = flag
                Me.lblOpenLockDC.Enabled = flag
                Me.lblKeyTag.Enabled = flag
                Me.tbKeyName.Enabled = flag
                Me.nudOpenLockDC.Enabled = flag
            End If
            Me.lblCloseLockDC.Enabled = flag
            Me.nudCloseLockDC.Enabled = flag
        End Sub

        ' Token: 0x06001536 RID: 5430 RVA: 0x002BEB38 File Offset: 0x002BDB38
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utp", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTP.WriteFile(Me.m_EditingFilePath, "UTP")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x06001537 RID: 5431 RVA: 0x002BEBD0 File Offset: 0x002BDBD0
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06001538 RID: 5432 RVA: 0x002BEC00 File Offset: 0x002BDC00
        Private Sub btnSetDescLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.DescriptionLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.DescriptionLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06001539 RID: 5433 RVA: 0x002BEC30 File Offset: 0x002BDC30
        Private Sub btnInventory_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmInventoryEditor As frmInventoryEditor = New frmInventoryEditor(Me.KotorVersionIndex)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.UTP.GetListItemCount("ItemList") - 1
            For i As Integer = num To num2
                Dim text As String = StringType.FromObject(Me.UTP.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").InventoryRes"))
                Dim flag As Boolean = Not Me.UTP.VerifyNodeExists("ItemList(" + StringType.FromInteger(i) + ").Dropable") OrElse ObjectType.ObjTst(Me.UTP.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").Dropable"), 1, False) = 0
                frmInventoryEditor.AddPackItem(text, flag)
            Next
            frmInventoryEditor.SetFormName(Me.tbTemplateResRef.Text + ".utp")
            frmInventoryEditor.ConfigureForPlaceableEditorUse()
            If frmInventoryEditor.ShowDialog() = DialogResult.OK Then
                Dim i As Integer = 0
                Me.UTP.ClearListElements("ItemList")
                Try
                    For Each obj As Object In frmInventoryEditor.GetPackItemsList()
                        Dim inventoryItem As InventoryItem = CType(obj, InventoryItem)
                        Dim num3 As Integer = 1
                        Dim quantity As Integer = inventoryItem._Quantity
                        For j As Integer = num3 To quantity
                            Dim gff_Struct As GFF_Struct = New GFF_Struct()
                            gff_Struct.type = i
                            gff_Struct.fieldCount = 4
                            gff_Struct.fields = New GFF_Field(3) {}
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "InventoryRes", inventoryItem._ResRef)
                            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_word, "Repos_PosX", i)
                            gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_word, "Repos_PosY", 0)
                            gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_byte, "Dropable", 1)
                            If Not Me.UTP.VerifyNodeExists("ItemList") Then
                                Me.UTP.CreateList("", "ItemList")
                            End If
                            Me.UTP.AddListElement("ItemList", gff_Struct)
                            i += 1
                        Next
                    Next
                Finally
                    Dim enumerator As IEnumerator = Nothing
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
        End Sub

        ' Token: 0x0600153A RID: 5434 RVA: 0x002BEE7C File Offset: 0x002BDE7C
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbName.Text + ".utp"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTP.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x0600153B RID: 5435 RVA: 0x002BEEF0 File Offset: 0x002BDEF0
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

        ' Token: 0x0600153C RID: 5436 RVA: 0x002BF02C File Offset: 0x002BE02C
        Private Sub frmUTP_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600153D RID: 5437 RVA: 0x002BF040 File Offset: 0x002BE040
        Private Sub frmUTP_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600153E RID: 5438 RVA: 0x002BF054 File Offset: 0x002BE054
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Placeable Editor - " + Name
        End Sub

        ' Token: 0x0600153F RID: 5439 RVA: 0x002BF068 File Offset: 0x002BE068
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x040009D3 RID: 2515
        <AccessedThroughProperty("Label43")> _
        Private _Label43 As Label

        ' Token: 0x040009D4 RID: 2516
        <AccessedThroughProperty("Label21")> _
        Private _Label21 As Label

        ' Token: 0x040009D5 RID: 2517
        <AccessedThroughProperty("tbKeyName")> _
        Private _tbKeyName As TextBox

        ' Token: 0x040009D6 RID: 2518
        <AccessedThroughProperty("Label42")> _
        Private _Label42 As Label

        ' Token: 0x040009D7 RID: 2519
        <AccessedThroughProperty("Label20")> _
        Private _Label20 As Label

        ' Token: 0x040009D8 RID: 2520
        <AccessedThroughProperty("tbComment")> _
        Private _tbComment As TextBox

        ' Token: 0x040009D9 RID: 2521
        <AccessedThroughProperty("Label41")> _
        Private _Label41 As Label

        ' Token: 0x040009DA RID: 2522
        <AccessedThroughProperty("Label19")> _
        Private _Label19 As Label

        ' Token: 0x040009DB RID: 2523
        <AccessedThroughProperty("tbOnUserDefined")> _
        Private _tbOnUserDefined As TextBox

        ' Token: 0x040009DC RID: 2524
        <AccessedThroughProperty("Label38")> _
        Private _Label38 As Label

        ' Token: 0x040009DD RID: 2525
        <AccessedThroughProperty("Label40")> _
        Private _Label40 As Label

        ' Token: 0x040009DE RID: 2526
        <AccessedThroughProperty("Label18")> _
        Private _Label18 As Label

        ' Token: 0x040009DF RID: 2527
        <AccessedThroughProperty("tbOnUnlock")> _
        Private _tbOnUnlock As TextBox

        ' Token: 0x040009E0 RID: 2528
        <AccessedThroughProperty("tbOnEndDialogue")> _
        Private _tbOnEndDialogue As TextBox

        ' Token: 0x040009E1 RID: 2529
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

        ' Token: 0x040009E2 RID: 2530
        <AccessedThroughProperty("tbOnUsed")> _
        Private _tbOnUsed As TextBox

        ' Token: 0x040009E3 RID: 2531
        <AccessedThroughProperty("tbType")> _
        Private _tbType As TextBox

        ' Token: 0x040009E4 RID: 2532
        <AccessedThroughProperty("Label17")> _
        Private _Label17 As Label

        ' Token: 0x040009E5 RID: 2533
        <AccessedThroughProperty("tbOnTrapTriggered")> _
        Private _tbOnTrapTriggered As TextBox

        ' Token: 0x040009E6 RID: 2534
        <AccessedThroughProperty("chkbHasInventory")> _
        Private _chkbHasInventory As CheckBox

        ' Token: 0x040009E7 RID: 2535
        <AccessedThroughProperty("chkbMin1HP")> _
        Private _chkbMin1HP As CheckBox

        ' Token: 0x040009E8 RID: 2536
        <AccessedThroughProperty("Label36")> _
        Private _Label36 As Label

        ' Token: 0x040009E9 RID: 2537
        <AccessedThroughProperty("Label39")> _
        Private _Label39 As Label

        ' Token: 0x040009EA RID: 2538
        <AccessedThroughProperty("Label16")> _
        Private _Label16 As Label

        ' Token: 0x040009EB RID: 2539
        <AccessedThroughProperty("tbOnSpellCastAt")> _
        Private _tbOnSpellCastAt As TextBox

        ' Token: 0x040009EC RID: 2540
        <AccessedThroughProperty("chkbTrapOneShot")> _
        Private _chkbTrapOneShot As CheckBox

        ' Token: 0x040009ED RID: 2541
        <AccessedThroughProperty("Label34")> _
        Private _Label34 As Label

        ' Token: 0x040009EE RID: 2542
        <AccessedThroughProperty("btnEditOnUserDefined")> _
        Private _btnEditOnUserDefined As Button

        ' Token: 0x040009EF RID: 2543
        <AccessedThroughProperty("chkbTrapFlag")> _
        Private _chkbTrapFlag As CheckBox

        ' Token: 0x040009F0 RID: 2544
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x040009F1 RID: 2545
        <AccessedThroughProperty("tbOnOpen")> _
        Private _tbOnOpen As TextBox

        ' Token: 0x040009F2 RID: 2546
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040009F3 RID: 2547
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x040009F4 RID: 2548
        <AccessedThroughProperty("tbOnMeleeAttacked")> _
        Private _tbOnMeleeAttacked As TextBox

        ' Token: 0x040009F5 RID: 2549
        <AccessedThroughProperty("chkbPartyInteract")> _
        Private _chkbPartyInteract As CheckBox

        ' Token: 0x040009F6 RID: 2550
        <AccessedThroughProperty("tbOnInvDisturbed")> _
        Private _tbOnInvDisturbed As TextBox

        ' Token: 0x040009F7 RID: 2551
        <AccessedThroughProperty("chkbUsable")> _
        Private _chkbUsable As CheckBox

        ' Token: 0x040009F8 RID: 2552
        <AccessedThroughProperty("btnEditOnUnlock")> _
        Private _btnEditOnUnlock As Button

        ' Token: 0x040009F9 RID: 2553
        <AccessedThroughProperty("nudTrapType")> _
        Private _nudTrapType As NumericUpDown

        ' Token: 0x040009FA RID: 2554
        <AccessedThroughProperty("btnEditOnOpen")> _
        Private _btnEditOnOpen As Button

        ' Token: 0x040009FB RID: 2555
        <AccessedThroughProperty("lblTrapDetectable")> _
        Private _lblTrapDetectable As Label

        ' Token: 0x040009FC RID: 2556
        <AccessedThroughProperty("Label13")> _
        Private _Label13 As Label

        ' Token: 0x040009FD RID: 2557
        <AccessedThroughProperty("tbOnLock")> _
        Private _tbOnLock As TextBox

        ' Token: 0x040009FE RID: 2558
        <AccessedThroughProperty("tbOnDisarm")> _
        Private _tbOnDisarm As TextBox

        ' Token: 0x040009FF RID: 2559
        <AccessedThroughProperty("tbOnClosed")> _
        Private _tbOnClosed As TextBox

        ' Token: 0x04000A00 RID: 2560
        <AccessedThroughProperty("chkbInterruptable")> _
        Private _chkbInterruptable As CheckBox

        ' Token: 0x04000A01 RID: 2561
        <AccessedThroughProperty("Label37")> _
        Private _Label37 As Label

        ' Token: 0x04000A02 RID: 2562
        <AccessedThroughProperty("Label35")> _
        Private _Label35 As Label

        ' Token: 0x04000A03 RID: 2563
        <AccessedThroughProperty("btnEditOnDeath")> _
        Private _btnEditOnDeath As Button

        ' Token: 0x04000A04 RID: 2564
        <AccessedThroughProperty("btnEditOnHeartbeat")> _
        Private _btnEditOnHeartbeat As Button

        ' Token: 0x04000A05 RID: 2565
        <AccessedThroughProperty("lblBodyVariation")> _
        Private _lblBodyVariation As Label

        ' Token: 0x04000A06 RID: 2566
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x04000A07 RID: 2567
        <AccessedThroughProperty("lblTextureVariation")> _
        Private _lblTextureVariation As Label

        ' Token: 0x04000A08 RID: 2568
        <AccessedThroughProperty("btnEditOnMeleeAttacked")> _
        Private _btnEditOnMeleeAttacked As Button

        ' Token: 0x04000A09 RID: 2569
        <AccessedThroughProperty("nudTrapDetectDC")> _
        Private _nudTrapDetectDC As NumericUpDown

        ' Token: 0x04000A0A RID: 2570
        <AccessedThroughProperty("Label33")> _
        Private _Label33 As Label

        ' Token: 0x04000A0B RID: 2571
        <AccessedThroughProperty("btnEditOnLock")> _
        Private _btnEditOnLock As Button

        ' Token: 0x04000A0C RID: 2572
        <AccessedThroughProperty("tbOnDeath")> _
        Private _tbOnDeath As TextBox

        ' Token: 0x04000A0D RID: 2573
        <AccessedThroughProperty("chkbTrapDisarmable")> _
        Private _chkbTrapDisarmable As CheckBox

        ' Token: 0x04000A0E RID: 2574
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000A0F RID: 2575
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000A10 RID: 2576
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000A11 RID: 2577
        <AccessedThroughProperty("chkbPlotItem")> _
        Private _chkbPlotItem As CheckBox

        ' Token: 0x04000A12 RID: 2578
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x04000A13 RID: 2579
        <AccessedThroughProperty("nudDisarmDC")> _
        Private _nudDisarmDC As NumericUpDown

        ' Token: 0x04000A14 RID: 2580
        <AccessedThroughProperty("TabPageComments")> _
        Private _TabPageComments As TabPage

        ' Token: 0x04000A15 RID: 2581
        <AccessedThroughProperty("chkbTrapDetectable")> _
        Private _chkbTrapDetectable As CheckBox

        ' Token: 0x04000A16 RID: 2582
        <AccessedThroughProperty("Label32")> _
        Private _Label32 As Label

        ' Token: 0x04000A17 RID: 2583
        <AccessedThroughProperty("btnEditOnClosed")> _
        Private _btnEditOnClosed As Button

        ' Token: 0x04000A18 RID: 2584
        <AccessedThroughProperty("TabPageDescription")> _
        Private _TabPageDescription As TabPage

        ' Token: 0x04000A19 RID: 2585
        <AccessedThroughProperty("btnEditOnEndDialogue")> _
        Private _btnEditOnEndDialogue As Button

        ' Token: 0x04000A1A RID: 2586
        <AccessedThroughProperty("btnEditOnSpellCastAt")> _
        Private _btnEditOnSpellCastAt As Button

        ' Token: 0x04000A1B RID: 2587
        <AccessedThroughProperty("TabPageTrap")> _
        Private _TabPageTrap As TabPage

        ' Token: 0x04000A1C RID: 2588
        <AccessedThroughProperty("btnEditOnUsed")> _
        Private _btnEditOnUsed As Button

        ' Token: 0x04000A1D RID: 2589
        <AccessedThroughProperty("btnEditOnDamaged")> _
        Private _btnEditOnDamaged As Button

        ' Token: 0x04000A1E RID: 2590
        <AccessedThroughProperty("tbFaction")> _
        Private _tbFaction As TextBox

        ' Token: 0x04000A1F RID: 2591
        <AccessedThroughProperty("btnEditOnDisarm")> _
        Private _btnEditOnDisarm As Button

        ' Token: 0x04000A20 RID: 2592
        <AccessedThroughProperty("tbConversation")> _
        Private _tbConversation As TextBox

        ' Token: 0x04000A21 RID: 2593
        <AccessedThroughProperty("nudCloseLockDC")> _
        Private _nudCloseLockDC As NumericUpDown

        ' Token: 0x04000A22 RID: 2594
        <AccessedThroughProperty("btnEditOnTrapTriggered")> _
        Private _btnEditOnTrapTriggered As Button

        ' Token: 0x04000A23 RID: 2595
        <AccessedThroughProperty("tbDescription")> _
        Private _tbDescription As TextBox

        ' Token: 0x04000A24 RID: 2596
        <AccessedThroughProperty("cmbxAppearance")> _
        Private _cmbxAppearance As ComboBox

        ' Token: 0x04000A25 RID: 2597
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000A26 RID: 2598
        <AccessedThroughProperty("TabPageAdvanced")> _
        Private _TabPageAdvanced As TabPage

        ' Token: 0x04000A27 RID: 2599
        <AccessedThroughProperty("TabPageScripts")> _
        Private _TabPageScripts As TabPage

        ' Token: 0x04000A28 RID: 2600
        <AccessedThroughProperty("tbTemplateResRef")> _
        Private _tbTemplateResRef As TextBox

        ' Token: 0x04000A29 RID: 2601
        <AccessedThroughProperty("Label22")> _
        Private _Label22 As Label

        ' Token: 0x04000A2A RID: 2602
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000A2B RID: 2603
        <AccessedThroughProperty("TabPageLock")> _
        Private _TabPageLock As TabPage

        ' Token: 0x04000A2C RID: 2604
        <AccessedThroughProperty("TabPageBasic")> _
        Private _TabPageBasic As TabPage

        ' Token: 0x04000A2D RID: 2605
        <AccessedThroughProperty("tbOnDamaged")> _
        Private _tbOnDamaged As TextBox

        ' Token: 0x04000A2E RID: 2606
        <AccessedThroughProperty("nudOpenLockDC")> _
        Private _nudOpenLockDC As NumericUpDown

        ' Token: 0x04000A2F RID: 2607
        <AccessedThroughProperty("tbOnHeartbeat")> _
        Private _tbOnHeartbeat As TextBox

        ' Token: 0x04000A30 RID: 2608
        <AccessedThroughProperty("btnInventory")> _
        Private _btnInventory As Button

        ' Token: 0x04000A31 RID: 2609
        <AccessedThroughProperty("chkbStatic")> _
        Private _chkbStatic As CheckBox

        ' Token: 0x04000A32 RID: 2610
        <AccessedThroughProperty("lblOpenLockDC")> _
        Private _lblOpenLockDC As Label

        ' Token: 0x04000A33 RID: 2611
        <AccessedThroughProperty("lblCloseLockDC")> _
        Private _lblCloseLockDC As Label

        ' Token: 0x04000A34 RID: 2612
        <AccessedThroughProperty("lblKeyTag")> _
        Private _lblKeyTag As Label

        ' Token: 0x04000A35 RID: 2613
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As Button

        ' Token: 0x04000A36 RID: 2614
        <AccessedThroughProperty("tbAnimationState")> _
        Private _tbAnimationState As TextBox

        ' Token: 0x04000A37 RID: 2615
        <AccessedThroughProperty("nudRef")> _
        Private _nudRef As NumericUpDown

        ' Token: 0x04000A38 RID: 2616
        <AccessedThroughProperty("chkbLockable")> _
        Private _chkbLockable As CheckBox

        ' Token: 0x04000A39 RID: 2617
        <AccessedThroughProperty("tbName")> _
        Private _tbName As TextBox

        ' Token: 0x04000A3A RID: 2618
        <AccessedThroughProperty("chkbLocked")> _
        Private _chkbLocked As CheckBox

        ' Token: 0x04000A3B RID: 2619
        <AccessedThroughProperty("nudHardness")> _
        Private _nudHardness As NumericUpDown

        ' Token: 0x04000A3C RID: 2620
        <AccessedThroughProperty("btnEditOnInvDisturbed")> _
        Private _btnEditOnInvDisturbed As Button

        ' Token: 0x04000A3D RID: 2621
        <AccessedThroughProperty("nudHP")> _
        Private _nudHP As NumericUpDown

        ' Token: 0x04000A3E RID: 2622
        <AccessedThroughProperty("nudFort")> _
        Private _nudFort As NumericUpDown

        ' Token: 0x04000A3F RID: 2623
        <AccessedThroughProperty("Label10")> _
        Private _Label10 As Label

        ' Token: 0x04000A40 RID: 2624
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x04000A41 RID: 2625
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x04000A42 RID: 2626
        <AccessedThroughProperty("chkbKeyRequired")> _
        Private _chkbKeyRequired As CheckBox

        ' Token: 0x04000A43 RID: 2627
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x04000A44 RID: 2628
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000A45 RID: 2629
        <AccessedThroughProperty("btnSetNameLang")> _
        Private _btnSetNameLang As Button

        ' Token: 0x04000A46 RID: 2630
        <AccessedThroughProperty("nudWill")> _
        Private _nudWill As NumericUpDown

        ' Token: 0x04000A47 RID: 2631
        <AccessedThroughProperty("chkbAutoRemoveKey")> _
        Private _chkbAutoRemoveKey As CheckBox

        ' Token: 0x04000A48 RID: 2632
        <AccessedThroughProperty("btnSetDescriptionLang")> _
        Private _btnSetDescriptionLang As Button

        ' Token: 0x04000A4A RID: 2634
        Public UTP As clsUTP

        ' Token: 0x04000A4B RID: 2635
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x04000A4C RID: 2636
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x04000A4D RID: 2637
        Private DescriptionLang As Integer

        ' Token: 0x04000A4E RID: 2638
        Private NameLang As Integer

        ' Token: 0x04000A4F RID: 2639
        Private m_bSaveGameMode As Boolean
    End Class
End Namespace