Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200003E RID: 62
	Public Partial Class frmAbout
		Inherits Form

		' Token: 0x060001C3 RID: 451 RVA: 0x002288A8 File Offset: 0x002278A8
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060001C5 RID: 453 RVA: 0x002288F4 File Offset: 0x002278F4
		' (set) Token: 0x060001C6 RID: 454 RVA: 0x002288D8 File Offset: 0x002278D8
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

        ' Token: 0x1700004A RID: 74
        ' (get) Token: 0x060001C7 RID: 455 RVA: 0x00228908 File Offset: 0x00227908
        ' (set) Token: 0x060001C8 RID: 456 RVA: 0x0022891C File Offset: 0x0022791C
        Friend Overridable Property Button1() As Button
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

        ' Token: 0x1700004B RID: 75
        ' (get) Token: 0x060001C9 RID: 457 RVA: 0x00228938 File Offset: 0x00227938
        ' (set) Token: 0x060001CA RID: 458 RVA: 0x0022894C File Offset: 0x0022794C
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

        ' Token: 0x1700004C RID: 76
        ' (get) Token: 0x060001CC RID: 460 RVA: 0x00228968 File Offset: 0x00227968
        ' (set) Token: 0x060001CB RID: 459 RVA: 0x0022897C File Offset: 0x0022797C
        Friend Overridable Property PictureBox1() As PictureBox
            Get
                Return Me._PictureBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As PictureBox)
                If Me._PictureBox1 IsNot Nothing Then
                End If
                Me._PictureBox1 = value
                If Me._PictureBox1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700004D RID: 77
        ' (get) Token: 0x060001CD RID: 461 RVA: 0x002289B4 File Offset: 0x002279B4
        ' (set) Token: 0x060001CE RID: 462 RVA: 0x00228998 File Offset: 0x00227998
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

        ' Token: 0x1700004E RID: 78
        ' (get) Token: 0x060001CF RID: 463 RVA: 0x002289E4 File Offset: 0x002279E4
        ' (set) Token: 0x060001D0 RID: 464 RVA: 0x002289C8 File Offset: 0x002279C8
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

        ' Token: 0x1700004F RID: 79
        ' (get) Token: 0x060001D2 RID: 466 RVA: 0x002289F8 File Offset: 0x002279F8
        ' (set) Token: 0x060001D1 RID: 465 RVA: 0x00228A0C File Offset: 0x00227A0C
        Friend Overridable Property lblVersion() As Label
            Get
                Return Me._lblVersion
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblVersion IsNot Nothing Then
                End If
                Me._lblVersion = value
                If Me._lblVersion IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x060001D4 RID: 468 RVA: 0x00228EF0 File Offset: 0x00227EF0
        Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Process.Start(CType(sender, LinkLabel).Text)
        End Sub

        ' Token: 0x0400014C RID: 332
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x0400014D RID: 333
        <AccessedThroughProperty("PictureBox1")> _
        Private _PictureBox1 As PictureBox

        ' Token: 0x0400014E RID: 334
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x0400014F RID: 335
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x04000150 RID: 336
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000151 RID: 337
        <AccessedThroughProperty("lblVersion")> _
        Private _lblVersion As Label

        ' Token: 0x04000152 RID: 338
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label
    End Class
End Namespace
