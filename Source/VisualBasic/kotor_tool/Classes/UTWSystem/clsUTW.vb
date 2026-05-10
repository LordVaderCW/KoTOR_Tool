Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x02000034 RID: 52
	Public Class clsUTW
		Inherits clsGFF

		' Token: 0x06000149 RID: 329 RVA: 0x0022557C File Offset: 0x0022457C
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x0600014A RID: 330 RVA: 0x0022558C File Offset: 0x0022458C
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x0600014B RID: 331 RVA: 0x00225598 File Offset: 0x00224598
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub
	End Class
End Namespace
