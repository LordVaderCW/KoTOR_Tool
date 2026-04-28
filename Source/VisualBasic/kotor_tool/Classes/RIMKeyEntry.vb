Imports System

Namespace kotor_tool
	' Token: 0x0200002B RID: 43
	Public Class RIMKeyEntry
		' Token: 0x06000123 RID: 291 RVA: 0x00224714 File Offset: 0x00223714
		Public Sub New()
		End Sub

		' Token: 0x06000124 RID: 292 RVA: 0x0022471C File Offset: 0x0022371C
		Public Sub New(ResourceName As String, ResType As Short, ResourceID As Short, Offset As Integer, Length As Integer, index As Integer)
			Me._ResourceName = ResourceName
			Me._ResType = ResType
			Me._ResTypeStr = frmMain.GetRsrcTypeForID(CInt(ResType))
			Me._ResourceID = ResourceID
			Me._Offset = Offset
			Me._Length = Length
			Me._Index = index
		End Sub

		' Token: 0x0400010D RID: 269
		Public _ResourceName As String

		' Token: 0x0400010E RID: 270
		Public _ResType As Short

		' Token: 0x0400010F RID: 271
		Public _ResTypeStr As String

		' Token: 0x04000110 RID: 272
		Public _ResourceID As Short

		' Token: 0x04000111 RID: 273
		Public _Offset As Integer

		' Token: 0x04000112 RID: 274
		Public _Length As Integer

		' Token: 0x04000113 RID: 275
		Public _Index As Integer
	End Class
End Namespace
