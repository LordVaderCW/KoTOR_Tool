Imports System
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000052 RID: 82
	Public Class InventoryPanel
		Inherits Panel

		' Token: 0x0600061E RID: 1566 RVA: 0x0024A0D4 File Offset: 0x002490D4
		Public Sub New()
			Me.Dropable = True
			Me.IsEmpty = True
		End Sub

		' Token: 0x04000335 RID: 821
		Public Dropable As Boolean

		' Token: 0x04000336 RID: 822
		Public IsEmpty As Boolean
	End Class
End Namespace
