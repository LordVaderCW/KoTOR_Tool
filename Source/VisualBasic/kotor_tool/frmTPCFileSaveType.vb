Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200007A RID: 122
	Public Partial Class frmTPCFileSaveType
		Inherits Form

		' Token: 0x060010E1 RID: 4321 RVA: 0x0029E1E4 File Offset: 0x0029D1E4
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000609 RID: 1545
		' (get) Token: 0x060010E4 RID: 4324 RVA: 0x0029E268 File Offset: 0x0029D268
		' (set) Token: 0x060010E3 RID: 4323 RVA: 0x0029E214 File Offset: 0x0029D214
		Friend Overridable Property btnTPC As Button
			Get
				Return Me._btnTPC
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnTPC IsNot Nothing Then
                    RemoveHandler Me._btnTPC.Click, AddressOf Me.btnTPC_Click
                End If
                Me._btnTPC = value
                If Me._btnTPC IsNot Nothing Then
                    AddHandler Me._btnTPC.Click, AddressOf Me.btnTPC_Click
                End If
            End Set
        End Property

        ' Token: 0x1700060A RID: 1546
        ' (get) Token: 0x060010E5 RID: 4325 RVA: 0x0029E27C File Offset: 0x0029D27C
        ' (set) Token: 0x060010E6 RID: 4326 RVA: 0x0029E290 File Offset: 0x0029D290
        Friend Overridable Property btnTGA() As Button
            Get
                Return Me._btnTGA
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnTGA IsNot Nothing Then
                    RemoveHandler Me._btnTGA.Click, AddressOf Me.btnTGA_Click
                End If
                Me._btnTGA = value
                If Me._btnTGA IsNot Nothing Then
                    AddHandler Me._btnTGA.Click, AddressOf Me.btnTGA_Click
                End If
            End Set
        End Property

        ' Token: 0x1700060B RID: 1547
        ' (get) Token: 0x060010E8 RID: 4328 RVA: 0x0029E2E4 File Offset: 0x0029D2E4
        ' (set) Token: 0x060010E7 RID: 4327 RVA: 0x0029E2F8 File Offset: 0x0029D2F8
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

        ' Token: 0x1700060C RID: 1548
        ' (get) Token: 0x060010E9 RID: 4329 RVA: 0x0029E314 File Offset: 0x0029D314
        ' (set) Token: 0x060010EA RID: 4330 RVA: 0x0029E328 File Offset: 0x0029D328
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

        ' Token: 0x060010EC RID: 4332 RVA: 0x0029E5AC File Offset: 0x0029D5AC
        Private Sub btnTPC_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.saveType = "tpc"
        End Sub

        ' Token: 0x060010ED RID: 4333 RVA: 0x0029E5BC File Offset: 0x0029D5BC
        Private Sub btnTGA_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.saveType = "tga"
        End Sub

        ' Token: 0x04000821 RID: 2081
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000822 RID: 2082
        <AccessedThroughProperty("btnTGA")> _
        Private _btnTGA As Button

        ' Token: 0x04000823 RID: 2083
        <AccessedThroughProperty("btnTPC")> _
        Private _btnTPC As Button

        ' Token: 0x04000824 RID: 2084
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000826 RID: 2086
        Public saveType As String
    End Class
End Namespace
