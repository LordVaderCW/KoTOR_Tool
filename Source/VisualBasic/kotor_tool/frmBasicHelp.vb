Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000041 RID: 65
	Public Partial Class frmBasicHelp
		Inherits Form

		' Token: 0x06000274 RID: 628 RVA: 0x0022CCB8 File Offset: 0x0022BCB8
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x06000276 RID: 630 RVA: 0x0022CCE8 File Offset: 0x0022BCE8
		' (set) Token: 0x06000277 RID: 631 RVA: 0x0022CCFC File Offset: 0x0022BCFC
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

        ' Token: 0x17000095 RID: 149
        ' (get) Token: 0x06000278 RID: 632 RVA: 0x0022CD18 File Offset: 0x0022BD18
        ' (set) Token: 0x06000279 RID: 633 RVA: 0x0022CD2C File Offset: 0x0022BD2C
        Friend Overridable Property TextBox1() As TextBox
            Get
                Return Me._TextBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._TextBox1 IsNot Nothing Then
                End If
                Me._TextBox1 = value
                If Me._TextBox1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000096 RID: 150
        ' (get) Token: 0x0600027B RID: 635 RVA: 0x0022CD64 File Offset: 0x0022BD64
        ' (set) Token: 0x0600027A RID: 634 RVA: 0x0022CD48 File Offset: 0x0022BD48
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

        ' Token: 0x0400019C RID: 412
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x0400019D RID: 413
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x0400019E RID: 414
        <AccessedThroughProperty("TextBox1")> _
        Private _TextBox1 As TextBox
    End Class
End Namespace
