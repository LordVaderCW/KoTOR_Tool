Imports System

Namespace kotor_tool
	' Token: 0x0200001A RID: 26
	Public Class GFF_Struct
		' Token: 0x060000AE RID: 174 RVA: 0x002207A8 File Offset: 0x0021F7A8
		Public Sub New()
		End Sub

		' Token: 0x060000AF RID: 175 RVA: 0x002207B0 File Offset: 0x0021F7B0
		Public Sub New(InitialFieldCount As Integer)
			Me.fieldCount = InitialFieldCount
			Me.fields = New GFF_Field(InitialFieldCount - 1 + 1 - 1) {}
		End Sub

		' Token: 0x060000B0 RID: 176 RVA: 0x002207D0 File Offset: 0x0021F7D0
		Public Sub New(InitialFieldCount As Integer, StructType As Integer)
			Me.New(InitialFieldCount)
			Me.type = StructType
		End Sub

		' Token: 0x040000C8 RID: 200
		Public type As Integer

		' Token: 0x040000C9 RID: 201
		Public fieldCount As Integer

		' Token: 0x040000CA RID: 202
		Public DataOrDataOffset As Integer

		' Token: 0x040000CB RID: 203
		Public fields As GFF_Field()
	End Class
End Namespace
