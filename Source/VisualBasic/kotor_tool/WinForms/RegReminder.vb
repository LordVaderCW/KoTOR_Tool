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

        ' Token: 0x04000BB9 RID: 3001
        Private m_sec As Object

        ' Token: 0x04000BBA RID: 3002
        Public btnClicked As String
    End Class
End Namespace
