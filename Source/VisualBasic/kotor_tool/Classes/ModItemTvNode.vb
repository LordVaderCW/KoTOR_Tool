Imports System
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200005E RID: 94
	Public Class ModItemTvNode
		Inherits TreeNode

		' Token: 0x06000933 RID: 2355 RVA: 0x0026D1CC File Offset: 0x0026C1CC
		Public Sub New()
		End Sub

		' Token: 0x06000934 RID: 2356 RVA: 0x0026D1D4 File Offset: 0x0026C1D4
		Public Sub New(text As String)
			MyBase.New(text)
		End Sub

		' Token: 0x040004C8 RID: 1224
		Public ArrayIndex As Integer

		' Token: 0x040004C9 RID: 1225
		Public ItemType As Integer
	End Class
End Namespace
