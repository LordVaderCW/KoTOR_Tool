Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200006F RID: 111
	Public Partial Class frmQueryUserInfo
		Inherits Form

		' Token: 0x06000E3C RID: 3644 RVA: 0x0028D330 File Offset: 0x0028C330
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004F4 RID: 1268
		' (get) Token: 0x06000E3F RID: 3647 RVA: 0x0028D37C File Offset: 0x0028C37C
		' (set) Token: 0x06000E3E RID: 3646 RVA: 0x0028D360 File Offset: 0x0028C360
		Friend Overridable Property Label2 As Label
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

        ' Token: 0x170004F5 RID: 1269
        ' (get) Token: 0x06000E41 RID: 3649 RVA: 0x0028D3AC File Offset: 0x0028C3AC
        ' (set) Token: 0x06000E40 RID: 3648 RVA: 0x0028D390 File Offset: 0x0028C390
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

        ' Token: 0x170004F6 RID: 1270
        ' (get) Token: 0x06000E43 RID: 3651 RVA: 0x0028D3DC File Offset: 0x0028C3DC
        ' (set) Token: 0x06000E42 RID: 3650 RVA: 0x0028D3C0 File Offset: 0x0028C3C0
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

        ' Token: 0x170004F7 RID: 1271
        ' (get) Token: 0x06000E44 RID: 3652 RVA: 0x0028D40C File Offset: 0x0028C40C
        ' (set) Token: 0x06000E45 RID: 3653 RVA: 0x0028D3F0 File Offset: 0x0028C3F0
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

        ' Token: 0x170004F8 RID: 1272
        ' (get) Token: 0x06000E46 RID: 3654 RVA: 0x0028D420 File Offset: 0x0028C420
        ' (set) Token: 0x06000E47 RID: 3655 RVA: 0x0028D434 File Offset: 0x0028C434
        Friend Overridable Property tbUserName() As TextBox
            Get
                Return Me._tbUserName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbUserName IsNot Nothing Then
                End If
                Me._tbUserName = value
                If Me._tbUserName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004F9 RID: 1273
        ' (get) Token: 0x06000E49 RID: 3657 RVA: 0x0028D46C File Offset: 0x0028C46C
        ' (set) Token: 0x06000E48 RID: 3656 RVA: 0x0028D450 File Offset: 0x0028C450
        Friend Overridable Property tbUserEmail() As TextBox
            Get
                Return Me._tbUserEmail
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbUserEmail IsNot Nothing Then
                End If
                Me._tbUserEmail = value
                If Me._tbUserEmail IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004FA RID: 1274
        ' (get) Token: 0x06000E4B RID: 3659 RVA: 0x0028D480 File Offset: 0x0028C480
        ' (set) Token: 0x06000E4A RID: 3658 RVA: 0x0028D494 File Offset: 0x0028C494
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

        ' Token: 0x040006F0 RID: 1776
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x040006F1 RID: 1777
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040006F2 RID: 1778
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040006F3 RID: 1779
        <AccessedThroughProperty("tbUserEmail")> _
        Private _tbUserEmail As TextBox

        ' Token: 0x040006F4 RID: 1780
        <AccessedThroughProperty("tbUserName")> _
        Private _tbUserName As TextBox

        ' Token: 0x040006F5 RID: 1781
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x040006F6 RID: 1782
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button
    End Class
End Namespace
