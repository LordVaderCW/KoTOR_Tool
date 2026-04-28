Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x0200002F RID: 47
	Public Class clsUTI
		Inherits clsGFF

		' Token: 0x0600013A RID: 314 RVA: 0x002254B4 File Offset: 0x002244B4
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x0600013B RID: 315 RVA: 0x002254C4 File Offset: 0x002244C4
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x0600013C RID: 316 RVA: 0x002254D0 File Offset: 0x002244D0
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub
	End Class
End Namespace
