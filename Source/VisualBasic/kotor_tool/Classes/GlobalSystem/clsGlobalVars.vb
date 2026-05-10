Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x02000024 RID: 36
	Public Class clsGlobalVars
		Inherits clsGFF

		' Token: 0x060000CB RID: 203 RVA: 0x00220A48 File Offset: 0x0021FA48
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x060000CC RID: 204 RVA: 0x00220A58 File Offset: 0x0021FA58
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x060000CD RID: 205 RVA: 0x00220A64 File Offset: 0x0021FA64
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub
	End Class
End Namespace
