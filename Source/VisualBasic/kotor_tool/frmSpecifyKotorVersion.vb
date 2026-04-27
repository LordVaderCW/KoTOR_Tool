Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000075 RID: 117
	Public Partial Class frmSpecifyKotorVersion
		Inherits Form

		' Token: 0x06000F09 RID: 3849 RVA: 0x00292420 File Offset: 0x00291420
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000545 RID: 1349
		' (get) Token: 0x06000F0C RID: 3852 RVA: 0x0029246C File Offset: 0x0029146C
		' (set) Token: 0x06000F0B RID: 3851 RVA: 0x00292450 File Offset: 0x00291450
		Friend Overridable Property btnOK As Button
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

        ' Token: 0x17000546 RID: 1350
        ' (get) Token: 0x06000F0D RID: 3853 RVA: 0x00292480 File Offset: 0x00291480
        ' (set) Token: 0x06000F0E RID: 3854 RVA: 0x00292494 File Offset: 0x00291494
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

        ' Token: 0x17000547 RID: 1351
        ' (get) Token: 0x06000F10 RID: 3856 RVA: 0x002924B0 File Offset: 0x002914B0
        ' (set) Token: 0x06000F0F RID: 3855 RVA: 0x002924C4 File Offset: 0x002914C4
        Friend Overridable Property rbKotor1() As RadioButton
            Get
                Return Me._rbKotor1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbKotor1 IsNot Nothing Then
                    RemoveHandler Me._rbKotor1.CheckedChanged, AddressOf Me.rb_CheckedChanged
                End If
                Me._rbKotor1 = value
                If Me._rbKotor1 IsNot Nothing Then
                    AddHandler Me._rbKotor1.CheckedChanged, AddressOf Me.rb_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000548 RID: 1352
        ' (get) Token: 0x06000F12 RID: 3858 RVA: 0x00292518 File Offset: 0x00291518
        ' (set) Token: 0x06000F11 RID: 3857 RVA: 0x0029252C File Offset: 0x0029152C
        Friend Overridable Property rbKotor2() As RadioButton
            Get
                Return Me._rbKotor2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbKotor2 IsNot Nothing Then
                    RemoveHandler Me._rbKotor2.CheckedChanged, AddressOf Me.rb_CheckedChanged
                End If
                Me._rbKotor2 = value
                If Me._rbKotor2 IsNot Nothing Then
                    AddHandler Me._rbKotor2.CheckedChanged, AddressOf Me.rb_CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000549 RID: 1353
        ' (get) Token: 0x06000F13 RID: 3859 RVA: 0x0029259C File Offset: 0x0029159C
        ' (set) Token: 0x06000F14 RID: 3860 RVA: 0x00292580 File Offset: 0x00291580
        Friend Overridable Property lblMsg() As Label
            Get
                Return Me._lblMsg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblMsg IsNot Nothing Then
                End If
                Me._lblMsg = value
                If Me._lblMsg IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700054A RID: 1354
        ' (get) Token: 0x06000F16 RID: 3862 RVA: 0x002925CC File Offset: 0x002915CC
        ' (set) Token: 0x06000F15 RID: 3861 RVA: 0x002925B0 File Offset: 0x002915B0
        Friend Overridable Property chkbRecordSelection() As CheckBox
            Get
                Return Me._chkbRecordSelection
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbRecordSelection IsNot Nothing Then
                End If
                Me._chkbRecordSelection = value
                If Me._chkbRecordSelection IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x06000F18 RID: 3864 RVA: 0x002929C4 File Offset: 0x002919C4
        Private Sub rb_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnOK.Enabled = True
        End Sub

        ' Token: 0x1700054B RID: 1355
        ' (get) Token: 0x06000F19 RID: 3865 RVA: 0x002929D4 File Offset: 0x002919D4
        Public ReadOnly Property KotorVerIndexSelected() As Integer
            Get
                If Me.rbKotor1.Checked Then
                    Return 0
                End If
                Return 1
            End Get
        End Property

        ' Token: 0x1700054C RID: 1356
        ' (set) Token: 0x06000F1A RID: 3866 RVA: 0x002929F4 File Offset: 0x002919F4
        Public WriteOnly Property FileName() As String
            Set(ByVal value As String)
                Dim lblMsg As Label = Me.lblMsg
                lblMsg.Text = lblMsg.Text + ": " + value
            End Set
        End Property

        ' Token: 0x0400074A RID: 1866
        <AccessedThroughProperty("rbKotor1")> _
        Private _rbKotor1 As RadioButton

        ' Token: 0x0400074B RID: 1867
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x0400074C RID: 1868
        <AccessedThroughProperty("rbKotor2")> _
        Private _rbKotor2 As RadioButton

        ' Token: 0x0400074D RID: 1869
        <AccessedThroughProperty("lblMsg")> _
        Private _lblMsg As Label

        ' Token: 0x0400074E RID: 1870
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x0400074F RID: 1871
        <AccessedThroughProperty("chkbRecordSelection")> _
        Private _chkbRecordSelection As CheckBox
    End Class
End Namespace
