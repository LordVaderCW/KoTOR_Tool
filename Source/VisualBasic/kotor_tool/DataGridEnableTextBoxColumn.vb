Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000049 RID: 73
	Public Class DataGridEnableTextBoxColumn
		Inherits DataGridTextBoxColumn

		' Token: 0x06000499 RID: 1177 RVA: 0x0023D558 File Offset: 0x0023C558
		Public Sub New()
		End Sub

		' Token: 0x0600049A RID: 1178 RVA: 0x0023D560 File Offset: 0x0023C560
		Public Sub New(column As Integer)
			Me._col = column
		End Sub

		' Token: 0x0600049B RID: 1179 RVA: 0x0023D570 File Offset: 0x0023C570
		Protected Overrides Sub Edit(source As CurrencyManager, rowNum As Integer, bounds As Rectangle, [readOnly] As Boolean, instantText As String, cellIsVisible As Boolean)
		End Sub

		' Token: 0x0400028A RID: 650
		Private _col As Integer
	End Class
End Namespace
