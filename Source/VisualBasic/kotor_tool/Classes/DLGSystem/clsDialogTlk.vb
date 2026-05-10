Imports System
Imports System.Collections
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic

Namespace kotor_tool
	' Token: 0x02000010 RID: 16
	Public Class clsDialogTlk
		' Token: 0x06000034 RID: 52 RVA: 0x0021A0C0 File Offset: 0x002190C0
		Public Sub New()
		End Sub

		' Token: 0x06000035 RID: 53 RVA: 0x0021A0C8 File Offset: 0x002190C8
		Public Sub New(path As String, Optional memoryResident As Boolean = False)
			Me.fs = New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
			Me.rdr = New BinaryReader(Me.fs, Encoding.ASCII)
			Me.fs.Seek(12L, SeekOrigin.Begin)
			Me.StringCount = Me.rdr.ReadInt32()
			Me.StringEntriesOffset = Me.rdr.ReadInt32()
			If memoryResident Then
				Me.fs.Seek(0L, SeekOrigin.Begin)
				Me.bytes = New Byte(CInt((Me.fs.Length - 1L)) + 1 - 1) {}
				Me.bytes = Me.rdr.ReadBytes(CInt(Me.fs.Length))
				Me.rdr.Close()
				Me.g_ms = New MemoryStream(Me.bytes, False)
				Me.rdr = New BinaryReader(Me.g_ms, Encoding.ASCII)
			End If
		End Sub

		' Token: 0x06000036 RID: 54 RVA: 0x0021A1C8 File Offset: 0x002191C8
		Public Sub Close()
			Me.fs.Close()
		End Sub

		' Token: 0x06000037 RID: 55 RVA: 0x0021A1D8 File Offset: 0x002191D8
		Public Function GetString(StringRef As Integer) As String
			' The following expression was wrapped in a checked-expression
			If StringRef > Me.StringCount - 1 Then
				Return ""
			End If
			Me.rdr.BaseStream.Seek(CLng((20 + StringRef * 40)), SeekOrigin.Begin)
			If(Me.rdr.ReadInt32() And 1) <> 0 Then
				Dim stringBuilder As StringBuilder = New StringBuilder()
				Me.rdr.BaseStream.Seek(24L, SeekOrigin.Current)
				Dim num As Integer = Me.rdr.ReadInt32()
				Dim num2 As Integer = Me.rdr.ReadInt32()
				Me.rdr.BaseStream.Seek(CLng((Me.StringEntriesOffset + num)), SeekOrigin.Begin)
				stringBuilder.Append(Me.rdr.ReadChars(num2))
				Return stringBuilder.ToString()
			End If
			Return ""
		End Function

		' Token: 0x06000038 RID: 56 RVA: 0x0021A298 File Offset: 0x00219298
		Public Function GetSoundResRef(StringRef As Integer) As String
			' The following expression was wrapped in a checked-expression
			If StringRef > Me.StringCount - 1 Then
				Return ""
			End If
			Me.rdr.BaseStream.Seek(0L, SeekOrigin.Begin)
			Me.rdr.BaseStream.Seek(CLng((20 + StringRef * 40)), SeekOrigin.Begin)
			If(Me.rdr.ReadInt32() And 2) <> 0 Then
				Dim stringBuilder As StringBuilder = New StringBuilder()
				stringBuilder.Append(Me.rdr.ReadChars(16))
				Dim num As Integer = 0
				While Strings.Asc(stringBuilder(num)) <> 0
					num += 1
					If num > 15 Then
						Exit While
					End If
				End While
				stringBuilder.Length = num
				Return stringBuilder.ToString()
			End If
			Return ""
		End Function

		' Token: 0x06000039 RID: 57 RVA: 0x0021A344 File Offset: 0x00219344
		Public Function GetSoundLength(StringRef As Integer) As Single
			' The following expression was wrapped in a checked-expression
			If StringRef > Me.StringCount - 1 Then
				Return 0F
			End If
			Me.fs.Seek(0L, SeekOrigin.Begin)
			Me.fs.Seek(CLng((20 + StringRef * 40)), SeekOrigin.Begin)
			If(Me.rdr.ReadInt32() And 4) <> 0 Then
				Me.fs.Seek(28L, SeekOrigin.Current)
				Return Me.rdr.ReadSingle()
			End If
			Return 0F
		End Function

		' Token: 0x0600003A RID: 58 RVA: 0x0021A3C8 File Offset: 0x002193C8
		Public Function GetStringDataElement(StringRef As Integer) As DialogTlkStrDataElement
			Dim num As Integer
			Dim dialogTlkStrDataElement As DialogTlkStrDataElement
			If StringRef > Me.StringCount - 1 Then
				Return Nothing
			End If
			num = 20 + StringRef * 40
			Me.rdr.BaseStream.Seek(CLng(num), SeekOrigin.Begin)
			dialogTlkStrDataElement = New DialogTlkStrDataElement()
			dialogTlkStrDataElement.Flags = Me.rdr.ReadInt32()
			If StringRef = 31483 Then
			End If
			If(dialogTlkStrDataElement.Flags And 2) <> 0 Then
				Dim stringBuilder As StringBuilder = New StringBuilder()
				stringBuilder.Append(Me.rdr.ReadChars(16))
				Dim num2 As Integer = 0
				While Strings.Asc(stringBuilder(num2)) <> 0
					num2 += 1
					If num2 > 15 Then
						Exit While
					End If
				End While
				stringBuilder.Length = num2
				dialogTlkStrDataElement.SoundResRef = stringBuilder.ToString()
			End If
			If(dialogTlkStrDataElement.Flags And 4) <> 0 Then
				' The following expression was wrapped in a checked-expression
				Me.rdr.BaseStream.Seek(CLng((num + 36)), SeekOrigin.Begin)
				dialogTlkStrDataElement.SoundLength = Me.rdr.ReadSingle()
			End If
			If(dialogTlkStrDataElement.Flags And 1) <> 0 Then
				Dim stringBuilder2 As StringBuilder = New StringBuilder()
				Me.rdr.BaseStream.Seek(CLng((num + 28)), SeekOrigin.Begin)
				Dim num3 As Integer = Me.rdr.ReadInt32()
				Dim num4 As Integer = Me.rdr.ReadInt32()
				Me.rdr.BaseStream.Seek(CLng((Me.StringEntriesOffset + num3)), SeekOrigin.Begin)
				stringBuilder2.Append(Me.rdr.ReadChars(num4))
				dialogTlkStrDataElement.Text = stringBuilder2.ToString()
			End If
			Return dialogTlkStrDataElement
		End Function

		' Token: 0x0600003B RID: 59 RVA: 0x0021A538 File Offset: 0x00219538
		Public Sub BuildTalkEntryList()
		End Sub

		' Token: 0x0600003C RID: 60 RVA: 0x0021A53C File Offset: 0x0021953C
		Public Sub AddTalkEntry(TalkEntry As DialogTlkStrDataElement)
			If Me.TalkEntryList Is Nothing Then
				Me.TalkEntryList = New ArrayList()
			End If
			Me.TalkEntryList.Add(TalkEntry)
		End Sub

		' Token: 0x0600003D RID: 61 RVA: 0x0021A560 File Offset: 0x00219560
		Public Sub AddTalkEntry(Flags As Integer, Text As String, SoundResRef As String, Optional SoundLength As Single = 0F)
			If Me.TalkEntryList Is Nothing Then
				Me.TalkEntryList = New ArrayList()
			End If
			Me.TalkEntryList.Add(New DialogTlkStrDataElement(Flags, Text, SoundResRef, SoundLength))
		End Sub

		' Token: 0x0600003E RID: 62 RVA: 0x0021A58C File Offset: 0x0021958C
		Public Sub ClearTalkEntryList()
			If Me.TalkEntryList IsNot Nothing Then
				Me.TalkEntryList.Clear()
			End If
		End Sub

		' Token: 0x0600003F RID: 63 RVA: 0x0021A5A4 File Offset: 0x002195A4
		Public Sub WriteListToFile(path As String)
			Dim fileStream As FileStream = New FileStream(path, FileMode.Create)
			Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream)
			Dim num As Integer = 20 + Me.TalkEntryList.Count * 40
			Dim num2 As Integer = num
			binaryWriter.Write("TLK V3.0".ToCharArray())
			binaryWriter.Write(Convert.ToInt32(0))
			binaryWriter.Write(Convert.ToInt32(Me.TalkEntryList.Count))
			binaryWriter.Write(Convert.ToInt32(num2))
			Dim num3 As Integer = 0
			Dim num4 As Integer = Me.TalkEntryList.Count - 1
			For i As Integer = num3 To num4
				binaryWriter.Seek(20 + i * 40, SeekOrigin.Begin)
				Dim dialogTlkStrDataElement As DialogTlkStrDataElement = CType(Me.TalkEntryList(i), DialogTlkStrDataElement)
				binaryWriter.Write(dialogTlkStrDataElement.Flags)
				binaryWriter.Write(dialogTlkStrDataElement.SoundResRef.PadRight(16, vbNullChar).ToCharArray())
				binaryWriter.Write(Convert.ToInt32(0))
				binaryWriter.Write(Convert.ToInt32(0))
				If(dialogTlkStrDataElement.Flags And 1) <> 0 Then
					binaryWriter.Write(num2 - num)
				Else
					binaryWriter.Write(Convert.ToInt32(0))
				End If
				binaryWriter.Write(Convert.ToInt32(dialogTlkStrDataElement.Text.Length))
				binaryWriter.Write(dialogTlkStrDataElement.SoundLength)
				binaryWriter.Seek(num2, SeekOrigin.Begin)
				binaryWriter.Write(dialogTlkStrDataElement.Text.ToCharArray())
				num2 += dialogTlkStrDataElement.Text.Length
			Next
			binaryWriter.Close()
		End Sub

		' Token: 0x0400005D RID: 93
		Private fs As FileStream

		' Token: 0x0400005E RID: 94
		Private rdr As BinaryReader

		' Token: 0x0400005F RID: 95
		Private sr As StreamReader

		' Token: 0x04000060 RID: 96
		Public StringCount As Integer

		' Token: 0x04000061 RID: 97
		Private StringEntriesOffset As Integer

		' Token: 0x04000062 RID: 98
		Private g_ms As MemoryStream

		' Token: 0x04000063 RID: 99
		Private bytes As Byte()

		' Token: 0x04000064 RID: 100
		Private TalkEntryList As ArrayList
	End Class
End Namespace
