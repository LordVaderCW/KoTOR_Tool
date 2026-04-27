Imports System

Namespace kotor_tool
	' Token: 0x0200001C RID: 28
	Public Class GFFFieldEntry
		' Token: 0x060000B3 RID: 179 RVA: 0x0022080C File Offset: 0x0021F80C
		Public Sub New()
			Me.FieldDataIndex = -1
		End Sub

		' Token: 0x040000D1 RID: 209
		Public Type As GFFField

		' Token: 0x040000D2 RID: 210
		Public LabelIndex As Integer

		' Token: 0x040000D3 RID: 211
		Public DataOrDataOffset As Object

		' Token: 0x040000D4 RID: 212
		Public FieldDataIndex As Integer
	End Class
End Namespace
