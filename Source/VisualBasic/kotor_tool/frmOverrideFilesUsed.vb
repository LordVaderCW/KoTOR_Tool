Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000065 RID: 101
	Public Partial Class frmOverrideFilesUsed
		Inherits frmParent

		' Token: 0x06000CB3 RID: 3251 RVA: 0x002831D8 File Offset: 0x002821D8
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000CB4 RID: 3252 RVA: 0x002831E8 File Offset: 0x002821E8
		Public Sub New(f As Form)
			Me.New()
		End Sub

		' Token: 0x17000467 RID: 1127
		' (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00283264 File Offset: 0x00282264
		' (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00283210 File Offset: 0x00282210
		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, AddressOf Me.Button1_Click
                End If
                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, AddressOf Me.Button1_Click
                End If
            End Set
        End Property

        ' Token: 0x17000468 RID: 1128
        ' (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00283278 File Offset: 0x00282278
        ' (set) Token: 0x06000CB9 RID: 3257 RVA: 0x0028328C File Offset: 0x0028228C
        Friend Overridable Property lblDesc() As Label
            Get
                Return Me._lblDesc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblDesc IsNot Nothing Then
                End If
                Me._lblDesc = value
                If Me._lblDesc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000469 RID: 1129
        ' (get) Token: 0x06000CBA RID: 3258 RVA: 0x002832C4 File Offset: 0x002822C4
        ' (set) Token: 0x06000CBB RID: 3259 RVA: 0x002832A8 File Offset: 0x002822A8
        Friend Overridable Property lbOverrideFiles() As ListBox
            Get
                Return Me._lbOverrideFiles
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ListBox)
                If Me._lbOverrideFiles IsNot Nothing Then
                End If
                Me._lbOverrideFiles = value
                If Me._lbOverrideFiles IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x06000CBD RID: 3261 RVA: 0x002834EC File Offset: 0x002824EC
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x04000652 RID: 1618
        <AccessedThroughProperty("lbOverrideFiles")> _
        Private _lbOverrideFiles As ListBox

        ' Token: 0x04000653 RID: 1619
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x04000654 RID: 1620
        <AccessedThroughProperty("lblDesc")> _
        Private _lblDesc As Label

        ' Token: 0x04000655 RID: 1621
        Private mainform As frmMain
    End Class
End Namespace
