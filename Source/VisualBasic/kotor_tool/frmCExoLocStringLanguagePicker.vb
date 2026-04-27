Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000044 RID: 68
	Public Partial Class frmCExoLocStringLanguagePicker
		Inherits Form

		' Token: 0x060002E2 RID: 738 RVA: 0x0022FF1C File Offset: 0x0022EF1C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmCExoLocStringLanguagePicker_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x060002E4 RID: 740 RVA: 0x0022FF7C File Offset: 0x0022EF7C
		' (set) Token: 0x060002E5 RID: 741 RVA: 0x0022FF60 File Offset: 0x0022EF60
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

        ' Token: 0x170000BD RID: 189
        ' (get) Token: 0x060002E6 RID: 742 RVA: 0x0022FFAC File Offset: 0x0022EFAC
        ' (set) Token: 0x060002E7 RID: 743 RVA: 0x0022FF90 File Offset: 0x0022EF90
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

        ' Token: 0x170000BE RID: 190
        ' (get) Token: 0x060002E9 RID: 745 RVA: 0x0022FFC0 File Offset: 0x0022EFC0
        ' (set) Token: 0x060002E8 RID: 744 RVA: 0x0022FFD4 File Offset: 0x0022EFD4
        Friend Overridable Property cmbxLanguage() As ComboBox
            Get
                Return Me._cmbxLanguage
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxLanguage IsNot Nothing Then
                End If
                Me._cmbxLanguage = value
                If Me._cmbxLanguage IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170000BF RID: 191
        ' (get) Token: 0x060002EA RID: 746 RVA: 0x0023000C File Offset: 0x0022F00C
        ' (set) Token: 0x060002EB RID: 747 RVA: 0x0022FFF0 File Offset: 0x0022EFF0
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

        ' Token: 0x170000C0 RID: 192
        ' (get) Token: 0x060002ED RID: 749 RVA: 0x00230020 File Offset: 0x0022F020
        ' (set) Token: 0x060002EC RID: 748 RVA: 0x00230034 File Offset: 0x0022F034
        Friend Overridable Property btnOK() As Button
            Get
                Return Me._btnOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                    RemoveHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                    AddHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
            End Set
        End Property

        ' Token: 0x170000C1 RID: 193
        ' (get) Token: 0x060002EF RID: 751 RVA: 0x002300A4 File Offset: 0x0022F0A4
        ' (set) Token: 0x060002EE RID: 750 RVA: 0x00230088 File Offset: 0x0022F088
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

        ' Token: 0x170000C2 RID: 194
        ' (get) Token: 0x060002F1 RID: 753 RVA: 0x00230498 File Offset: 0x0022F498
        ' (set) Token: 0x060002F2 RID: 754 RVA: 0x002304AC File Offset: 0x0022F4AC
        Public Property LanguageID() As Integer
            Get
                Return Me.m_LanguageID
            End Get
            Set(ByVal value As Integer)
                Me.m_LanguageID = value
            End Set
        End Property

        ' Token: 0x060002F3 RID: 755 RVA: 0x002304B8 File Offset: 0x0022F4B8
        Public Sub New(ByVal LanguageID As Integer)
            Me.New()
            Me.m_LanguageID = LanguageID
        End Sub

        ' Token: 0x060002F4 RID: 756 RVA: 0x002304C8 File Offset: 0x0022F4C8
        Private Sub frmCExoLocStringLanguagePicker_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.cmbxLanguage.SelectedIndex = Me.m_LanguageID / 2
            Me.cmbxGender.SelectedIndex = Me.m_LanguageID Mod 2
        End Sub

        ' Token: 0x060002F5 RID: 757 RVA: 0x002304F0 File Offset: 0x0022F4F0
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' The following expression was wrapped in a checked-expression
            Me.m_LanguageID = Me.cmbxLanguage.SelectedIndex * 2 + Me.cmbxGender.SelectedIndex
            Me.DialogResult = DialogResult.OK
        End Sub

        ' Token: 0x040001CB RID: 459
        <AccessedThroughProperty("cmbxGender")> _
  Private _cmbxGender As ComboBox

        ' Token: 0x040001CC RID: 460
        <AccessedThroughProperty("btnOK")> _
  Private _btnOK As Button

        ' Token: 0x040001CD RID: 461
        <AccessedThroughProperty("Label2")> _
  Private _Label2 As Label

        ' Token: 0x040001CE RID: 462
        <AccessedThroughProperty("btnCancel")> _
  Private _btnCancel As Button

        ' Token: 0x040001CF RID: 463
        <AccessedThroughProperty("Label1")> _
  Private _Label1 As Label

        ' Token: 0x040001D0 RID: 464
        <AccessedThroughProperty("cmbxLanguage")> _
  Private _cmbxLanguage As ComboBox

        ' Token: 0x040001D2 RID: 466
        Private m_LanguageID As Integer
    End Class
End Namespace
