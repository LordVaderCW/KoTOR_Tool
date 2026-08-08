Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x02000033 RID: 51
	Public Class clsUTT
		Inherits clsGFF

		' Token: 0x06000146 RID: 326 RVA: 0x00225554 File Offset: 0x00224554
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x06000147 RID: 327 RVA: 0x00225564 File Offset: 0x00224564
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x06000148 RID: 328 RVA: 0x00225570 File Offset: 0x00224570
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub
	End Class
End Namespace
