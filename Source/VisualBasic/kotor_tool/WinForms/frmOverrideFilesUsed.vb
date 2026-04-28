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

        ' Token: 0x06000CBD RID: 3261 RVA: 0x002834EC File Offset: 0x002824EC
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x04000655 RID: 1621
        Private mainform As frmMain
    End Class
End Namespace
