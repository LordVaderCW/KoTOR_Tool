Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x02000030 RID: 48
	Public Class clsUTM
		Inherits clsGFF

		' Token: 0x0600013D RID: 317 RVA: 0x002254DC File Offset: 0x002244DC
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x0600013E RID: 318 RVA: 0x002254EC File Offset: 0x002244EC
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x0600013F RID: 319 RVA: 0x002254F8 File Offset: 0x002244F8
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub
	End Class
End Namespace
