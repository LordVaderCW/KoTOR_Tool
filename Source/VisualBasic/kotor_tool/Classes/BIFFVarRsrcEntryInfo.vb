Imports System

Namespace kotor_tool
	' Token: 0x02000008 RID: 8
	Public Class BIFFVarRsrcEntryInfo
		' Token: 0x06000021 RID: 33 RVA: 0x00217E0C File Offset: 0x00216E0C
		Public Sub New(ResID As Integer, Offset As Integer, FileSize As Integer, ResourceType As Integer)
			Me.ResID = ResID
			Me.Offset = Offset
			Me.FileSize = FileSize
			Me.ResourceType = ResourceType
		End Sub

		' Token: 0x0400001E RID: 30
		Public ResID As Integer

		' Token: 0x0400001F RID: 31
		Public Offset As Integer

		' Token: 0x04000020 RID: 32
		Public FileSize As Integer

		' Token: 0x04000021 RID: 33
		Public ResourceType As Integer
	End Class
End Namespace
