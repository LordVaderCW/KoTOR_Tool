Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x0200002E RID: 46
	Public Class clsUTD
		Inherits clsGFF

		' Token: 0x06000137 RID: 311 RVA: 0x0022548C File Offset: 0x0022448C
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x06000138 RID: 312 RVA: 0x0022549C File Offset: 0x0022449C
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x06000139 RID: 313 RVA: 0x002254A8 File Offset: 0x002244A8
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub
	End Class
End Namespace
