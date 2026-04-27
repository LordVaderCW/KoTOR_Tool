Imports System
Imports System.Collections
Imports System.Text

Namespace kotor_tool
	' Token: 0x0200002A RID: 42
	Public Class clsRIM
		' Token: 0x06000121 RID: 289 RVA: 0x002243CC File Offset: 0x002233CC
		Public Sub New(indata As Byte())
			Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Me.data = indata
			Me.EntryCount = CInt(Math.Round(CDbl(Me.data(12)) + CDbl(Me.data(13)) * 256.0 + CDbl(Me.data(14)) * 65536.0 + CDbl(Me.data(15)) * 16777216.0))
			Me.OffKeyList = CInt(Math.Round(CDbl(Me.data(16)) + CDbl(Me.data(17)) * 256.0 + CDbl(Me.data(18)) * 65536.0 + CDbl(Me.data(19)) * 16777216.0))
			Me.KeyEntryList = New ArrayList(Me.EntryCount)
			Dim num As Integer = 0
			Dim num2 As Integer = Me.EntryCount - 1
			For i As Integer = num To num2
				stringBuilder.Append(asciiencoding.GetString(Me.data, Me.OffKeyList + i * 32, 16))
				Dim num3 As Integer = 0
				While Me.data(Me.OffKeyList + num3 + i * 32) <> 0
					num3 += 1
					If num3 > 15 Then
						Exit While
					End If
				End While
				stringBuilder.Length = num3
				Dim text As String = stringBuilder.ToString()
				stringBuilder.Length = 0
				Dim num4 As Short = CShort(Math.Round(CDbl(Me.data(Me.OffKeyList + i * 32 + 16)) + CDbl(Me.data(Me.OffKeyList + i * 32 + 17)) * 256.0))
				Dim num5 As Short = CShort(Math.Round(CDbl(Me.data(Me.OffKeyList + i * 32 + 18)) + CDbl(Me.data(Me.OffKeyList + i * 32 + 19)) * 256.0))
				Dim num6 As Integer = CInt(Math.Round(CDbl(Me.data(Me.OffKeyList + i * 32 + 24)) + CDbl(Me.data(Me.OffKeyList + i * 32 + 25)) * 256.0 + CDbl(Me.data(Me.OffKeyList + i * 32 + 26)) * 65536.0 + CDbl(Me.data(Me.OffKeyList + i * 32 + 27)) * 16777216.0))
				Dim num7 As Integer = CInt(Math.Round(CDbl(Me.data(Me.OffKeyList + i * 32 + 28)) + CDbl(Me.data(Me.OffKeyList + i * 32 + 29)) * 256.0 + CDbl(Me.data(Me.OffKeyList + i * 32 + 30)) * 65536.0 + CDbl(Me.data(Me.OffKeyList + i * 32 + 31)) * 16777216.0))
				Dim rimkeyEntry As RIMKeyEntry = New RIMKeyEntry(text, num4, num5, num6, num7, i)
				Me.KeyEntryList.Add(rimkeyEntry)
			Next
		End Sub

		' Token: 0x06000122 RID: 290 RVA: 0x002246C8 File Offset: 0x002236C8
		Public Function GetRIMResource(index As Integer) As Byte()
			Dim rimkeyEntry As RIMKeyEntry = CType(Me.KeyEntryList(index), RIMKeyEntry)
			Dim array As Byte() = New Byte(rimkeyEntry._Length - 1 + 1 - 1) {}
			Array.Copy(Me.data, rimkeyEntry._Offset, array, 0, rimkeyEntry._Length)
			Return array
		End Function

		' Token: 0x04000109 RID: 265
		Public EntryCount As Integer

		' Token: 0x0400010A RID: 266
		Public OffKeyList As Integer

		' Token: 0x0400010B RID: 267
		Public KeyEntryList As ArrayList

		' Token: 0x0400010C RID: 268
		Private data As Byte()
	End Class
End Namespace
