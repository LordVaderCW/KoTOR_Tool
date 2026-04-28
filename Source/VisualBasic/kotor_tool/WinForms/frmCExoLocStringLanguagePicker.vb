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

        ' Token: 0x040001D2 RID: 466
        Private m_LanguageID As Integer
    End Class
End Namespace
