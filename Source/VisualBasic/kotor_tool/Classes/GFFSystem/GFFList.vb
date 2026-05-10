Imports System
Imports System.Collections

Namespace kotor_tool
	' Token: 0x0200001E RID: 30
	Public Class GFFList
		' Token: 0x060000B5 RID: 181 RVA: 0x00220824 File Offset: 0x0021F824
		Public Sub New(count As Integer)
			Me.size = count
			Me.structIndices = New ArrayList(count)
			If count > 0 Then
				Dim num As Integer = 0
				Dim num2 As Integer = count - 1
				For i As Integer = num To num2
					Me.structIndices.Add(-1)
				Next
			End If
		End Sub

		' Token: 0x040000D7 RID: 215
		Public size As Integer

		' Token: 0x040000D8 RID: 216
		Public structIndices As ArrayList
	End Class
End Namespace
