Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x02000032 RID: 50
	Public Class clsUTS
		Inherits clsGFF

		' Token: 0x06000143 RID: 323 RVA: 0x0022552C File Offset: 0x0022452C
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x06000144 RID: 324 RVA: 0x0022553C File Offset: 0x0022453C
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x06000145 RID: 325 RVA: 0x00225548 File Offset: 0x00224548
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub
	End Class
End Namespace
