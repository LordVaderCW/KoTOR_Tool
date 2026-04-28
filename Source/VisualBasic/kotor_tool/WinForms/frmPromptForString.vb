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

        ' Token: 0x06000E3B RID: 3643 RVA: 0x0028D308 File Offset: 0x0028C308
        Public Sub New(ByVal Title As String, ByVal Message As String, ByVal ValueText As String)
            Me.New()
            Me.Text = Title
            Me.lblMsg.Text = Message
            Me.tbValue.Text = ValueText
        End Sub
    End Class
End Namespace
