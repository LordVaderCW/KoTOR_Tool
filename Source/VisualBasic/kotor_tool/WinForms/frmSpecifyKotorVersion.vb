Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000075 RID: 117
	Public Partial Class frmSpecifyKotorVersion
		Inherits Form

		' Token: 0x06000F09 RID: 3849 RVA: 0x00292420 File Offset: 0x00291420
		Public Sub New()
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06000F18 RID: 3864 RVA: 0x002929C4 File Offset: 0x002919C4
        Private Sub rb_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnOK.Enabled = True
        End Sub

        ' Token: 0x1700054B RID: 1355
        ' (get) Token: 0x06000F19 RID: 3865 RVA: 0x002929D4 File Offset: 0x002919D4
        Public ReadOnly Property KotorVerIndexSelected() As Integer
            Get
                If Me.rbKotor1.Checked Then
                    Return 0
                End If
                Return 1
            End Get
        End Property

        ' Token: 0x1700054C RID: 1356
        ' (set) Token: 0x06000F1A RID: 3866 RVA: 0x002929F4 File Offset: 0x002919F4
        Public WriteOnly Property FileName() As String
            Set(ByVal value As String)
                Dim lblMsg As Label = Me.lblMsg
                lblMsg.Text = lblMsg.Text + ": " + value
            End Set
        End Property
    End Class
End Namespace
