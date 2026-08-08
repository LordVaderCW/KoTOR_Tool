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

        ' Token: 0x060010EC RID: 4332 RVA: 0x0029E5AC File Offset: 0x0029D5AC
        Private Sub btnTPC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTPC.Click
            Me.saveType = "tpc"
        End Sub

        ' Token: 0x060010ED RID: 4333 RVA: 0x0029E5BC File Offset: 0x0029D5BC
        Private Sub btnTGA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTGA.Click
            Me.saveType = "tga"
        End Sub

        ' Token: 0x04000826 RID: 2086
        Public saveType As String
    End Class
End Namespace
