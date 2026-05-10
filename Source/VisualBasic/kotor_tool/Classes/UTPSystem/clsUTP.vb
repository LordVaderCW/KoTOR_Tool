Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x02000031 RID: 49
	Public Class clsUTP
		Inherits clsGFF

		' Token: 0x06000140 RID: 320 RVA: 0x00225504 File Offset: 0x00224504
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x06000141 RID: 321 RVA: 0x00225514 File Offset: 0x00224514
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x06000142 RID: 322 RVA: 0x00225520 File Offset: 0x00224520
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub
	End Class
End Namespace
