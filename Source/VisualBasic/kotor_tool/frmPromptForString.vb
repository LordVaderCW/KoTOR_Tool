Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200006E RID: 110
	Public Partial Class frmPromptForString
		Inherits Form

		' Token: 0x06000E30 RID: 3632 RVA: 0x0028CF78 File Offset: 0x0028BF78
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004F0 RID: 1264
		' (get) Token: 0x06000E32 RID: 3634 RVA: 0x0028CFA8 File Offset: 0x0028BFA8
		' (set) Token: 0x06000E33 RID: 3635 RVA: 0x0028CFBC File Offset: 0x0028BFBC
		Friend Overridable Property lblMsg As Label
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

        ' Token: 0x170004F1 RID: 1265
        ' (get) Token: 0x06000E35 RID: 3637 RVA: 0x0028CFF4 File Offset: 0x0028BFF4
        ' (set) Token: 0x06000E34 RID: 3636 RVA: 0x0028CFD8 File Offset: 0x0028BFD8
        Friend Overridable Property tbValue() As TextBox
            Get
                Return Me._tbValue
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbValue IsNot Nothing Then
                End If
                Me._tbValue = value
                If Me._tbValue IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004F2 RID: 1266
        ' (get) Token: 0x06000E36 RID: 3638 RVA: 0x0028D008 File Offset: 0x0028C008
        ' (set) Token: 0x06000E37 RID: 3639 RVA: 0x0028D01C File Offset: 0x0028C01C
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

        ' Token: 0x170004F3 RID: 1267
        ' (get) Token: 0x06000E38 RID: 3640 RVA: 0x0028D038 File Offset: 0x0028C038
        ' (set) Token: 0x06000E39 RID: 3641 RVA: 0x0028D04C File Offset: 0x0028C04C
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

        ' Token: 0x06000E3B RID: 3643 RVA: 0x0028D308 File Offset: 0x0028C308
        Public Sub New(ByVal Title As String, ByVal Message As String, ByVal ValueText As String)
            Me.New()
            Me.Text = Title
            Me.lblMsg.Text = Message
            Me.tbValue.Text = ValueText
        End Sub

        ' Token: 0x040006EB RID: 1771
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040006EC RID: 1772
        <AccessedThroughProperty("lblMsg")> _
        Private _lblMsg As Label

        ' Token: 0x040006ED RID: 1773
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x040006EE RID: 1774
        <AccessedThroughProperty("tbValue")> _
        Private _tbValue As TextBox
    End Class
End Namespace
