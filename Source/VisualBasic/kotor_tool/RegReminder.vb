Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200008D RID: 141
	Public Partial Class RegReminder
		Inherits Form

		' Token: 0x060017DE RID: 6110 RVA: 0x002CC78C File Offset: 0x002CB78C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.RegReminder_Load
			Me.m_sec = 10
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700091E RID: 2334
		' (get) Token: 0x060017E1 RID: 6113 RVA: 0x002CC7DC File Offset: 0x002CB7DC
		' (set) Token: 0x060017E0 RID: 6112 RVA: 0x002CC7F0 File Offset: 0x002CB7F0
		Friend Overridable Property lblRegHeader As Label
			Get
				Return Me._lblRegHeader
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblRegHeader IsNot Nothing Then
                End If
                Me._lblRegHeader = value
                If Me._lblRegHeader IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700091F RID: 2335
        ' (get) Token: 0x060017E3 RID: 6115 RVA: 0x002CC828 File Offset: 0x002CB828
        ' (set) Token: 0x060017E2 RID: 6114 RVA: 0x002CC80C File Offset: 0x002CB80C
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

        ' Token: 0x17000920 RID: 2336
        ' (get) Token: 0x060017E4 RID: 6116 RVA: 0x002CC83C File Offset: 0x002CB83C
        ' (set) Token: 0x060017E5 RID: 6117 RVA: 0x002CC850 File Offset: 0x002CB850
        Friend Overridable Property Button1() As Button
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

        ' Token: 0x17000921 RID: 2337
        ' (get) Token: 0x060017E6 RID: 6118 RVA: 0x002CC8F8 File Offset: 0x002CB8F8
        ' (set) Token: 0x060017E7 RID: 6119 RVA: 0x002CC8A4 File Offset: 0x002CB8A4
        Friend Overridable Property Timer1() As Timer
            Get
                Return Me._Timer1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Timer)
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, AddressOf Me.Timer1_Tick
                End If
                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, AddressOf Me.Timer1_Tick
                End If
            End Set
        End Property

        ' Token: 0x17000922 RID: 2338
        ' (get) Token: 0x060017E9 RID: 6121 RVA: 0x002CC928 File Offset: 0x002CB928
        ' (set) Token: 0x060017E8 RID: 6120 RVA: 0x002CC90C File Offset: 0x002CB90C
        Friend Overridable Property lblTimeMsg() As Label
            Get
                Return Me._lblTimeMsg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblTimeMsg IsNot Nothing Then
                End If
                Me._lblTimeMsg = value
                If Me._lblTimeMsg IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000923 RID: 2339
        ' (get) Token: 0x060017EA RID: 6122 RVA: 0x002CC990 File Offset: 0x002CB990
        ' (set) Token: 0x060017EB RID: 6123 RVA: 0x002CC93C File Offset: 0x002CB93C
        Friend Overridable Property Button2() As Button
            Get
                Return Me._Button2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._Button2 IsNot Nothing Then
                    RemoveHandler Me._Button2.Click, AddressOf Me.Button2_Click
                End If
                Me._Button2 = value
                If Me._Button2 IsNot Nothing Then
                    AddHandler Me._Button2.Click, AddressOf Me.Button2_Click
                End If
            End Set
        End Property

        ' Token: 0x17000924 RID: 2340
        ' (get) Token: 0x060017EC RID: 6124 RVA: 0x002CC9A4 File Offset: 0x002CB9A4
        ' (set) Token: 0x060017ED RID: 6125 RVA: 0x002CC9B8 File Offset: 0x002CB9B8
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

        ' Token: 0x060017EF RID: 6127 RVA: 0x002CCE10 File Offset: 0x002CBE10
        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Me.lblTimeMsg.Text = StringType.FromObject(ObjectType.StrCatObj("Please wait ... ", Me.m_sec))
            Me.m_sec = ObjectType.SubObj(Me.m_sec, 1)
            If ObjectType.ObjTst(Me.m_sec, -1, False) = 0 Then
                Me.Timer1.[Stop]()
                Me.Button1.Enabled = True
            End If
        End Sub

        ' Token: 0x060017F0 RID: 6128 RVA: 0x002CCE80 File Offset: 0x002CBE80
        Private Sub RegReminder_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.lblTimeMsg.Text = "Please wait ... 10"
            Me.Timer1.Start()
        End Sub

        ' Token: 0x060017F1 RID: 6129 RVA: 0x002CCEA0 File Offset: 0x002CBEA0
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If ObjectType.ObjTst(Me.m_sec, 0, False) <= 0 Then
                Me.DialogResult = DialogResult.OK
                Me.btnClicked = "OK"
            End If
        End Sub

        ' Token: 0x060017F2 RID: 6130 RVA: 0x002CCECC File Offset: 0x002CBECC
        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DialogResult = DialogResult.Cancel
            Me.btnClicked = "Cancel"
        End Sub

        ' Token: 0x04000BB1 RID: 2993
        <AccessedThroughProperty("lblRegHeader")> _
        Private _lblRegHeader As Label

        ' Token: 0x04000BB2 RID: 2994
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000BB3 RID: 2995
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000BB4 RID: 2996
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x04000BB5 RID: 2997
        <AccessedThroughProperty("lblTimeMsg")> _
        Private _lblTimeMsg As Label

        ' Token: 0x04000BB6 RID: 2998
        <AccessedThroughProperty("Button2")> _
        Private _Button2 As Button

        ' Token: 0x04000BB7 RID: 2999
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer

        ' Token: 0x04000BB9 RID: 3001
        Private m_sec As Object

        ' Token: 0x04000BBA RID: 3002
        Public btnClicked As String
    End Class
End Namespace
