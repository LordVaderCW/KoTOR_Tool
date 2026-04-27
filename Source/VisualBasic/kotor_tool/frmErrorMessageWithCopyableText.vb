Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200004B RID: 75
	Public Partial Class frmErrorMessageWithCopyableText
		Inherits Form

		' Token: 0x060004CE RID: 1230 RVA: 0x0023EBCC File Offset: 0x0023DBCC
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x060004D0 RID: 1232 RVA: 0x0023EC18 File Offset: 0x0023DC18
		' (set) Token: 0x060004D1 RID: 1233 RVA: 0x0023EBFC File Offset: 0x0023DBFC
		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._Button1 IsNot Nothing Then
                End If
                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700016C RID: 364
        ' (get) Token: 0x060004D2 RID: 1234 RVA: 0x0023EC2C File Offset: 0x0023DC2C
        ' (set) Token: 0x060004D3 RID: 1235 RVA: 0x0023EC40 File Offset: 0x0023DC40
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

        ' Token: 0x1700016D RID: 365
        ' (get) Token: 0x060004D4 RID: 1236 RVA: 0x0023EC78 File Offset: 0x0023DC78
        ' (set) Token: 0x060004D5 RID: 1237 RVA: 0x0023EC5C File Offset: 0x0023DC5C
        Friend Overridable Property tbMsg() As TextBox
            Get
                Return Me._tbMsg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbMsg IsNot Nothing Then
                End If
                Me._tbMsg = value
                If Me._tbMsg IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x0400029A RID: 666
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x0400029B RID: 667
        <AccessedThroughProperty("lblMsg")> _
        Private _lblMsg As Label

        ' Token: 0x0400029C RID: 668
        <AccessedThroughProperty("tbMsg")> _
        Private _tbMsg As TextBox
    End Class
End Namespace
