Imports System
Imports System.Runtime.CompilerServices

Namespace kotor_tool
	' Token: 0x0200001B RID: 27
	Public Class GFF_Field
		' Token: 0x060000B1 RID: 177 RVA: 0x002207E0 File Offset: 0x0021F7E0
		Public Sub New()
		End Sub

		' Token: 0x060000B2 RID: 178 RVA: 0x002207E8 File Offset: 0x0021F7E8
		Public Sub New(FieldType As GFFField, FieldLabel As String, FieldValue As Object)
			Me.Type = FieldType
			Me.label = FieldLabel
			Me.value = RuntimeHelpers.GetObjectValue(FieldValue)
		End Sub

		' Token: 0x040000CC RID: 204
		Public Type As GFFField

		' Token: 0x040000CD RID: 205
		Public labelIndex As Integer

		' Token: 0x040000CE RID: 206
		Public label As String

		' Token: 0x040000CF RID: 207
		Public value As Object

		' Token: 0x040000D0 RID: 208
		Public DataOffset As Integer
	End Class
End Namespace
