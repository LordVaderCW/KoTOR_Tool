Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000071 RID: 113
	Public Partial Class frmRefSearchResults
		Inherits frmParent

		' Token: 0x06000EA0 RID: 3744 RVA: 0x0028FC48 File Offset: 0x0028EC48
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000EA1 RID: 3745 RVA: 0x0028FC58 File Offset: 0x0028EC58
		Public Sub New(f As Form)
			Me.New()
			Me.mainform = CType(f, frmMain)
		End Sub

        ' Token: 0x06000EAC RID: 3756 RVA: 0x002900A4 File Offset: 0x0028F0A4
        Private Sub lbMatches_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        ' Token: 0x06000EAD RID: 3757 RVA: 0x002900A8 File Offset: 0x0028F0A8
        Private Sub lbMatches_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lbMatches.SelectedIndex = -1 Then
                Return
            End If
            Me.mainform.HandleDataByNodeType(CType(Me.lbMatches.SelectedItem, KotorTreeNode), Nothing)
        End Sub

        ' Token: 0x06000EAE RID: 3758 RVA: 0x002900D8 File Offset: 0x0028F0D8
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x04000721 RID: 1825
        Private mainform As frmMain
    End Class
End Namespace
