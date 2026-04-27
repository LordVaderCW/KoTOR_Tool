Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x02000005 RID: 5
	Public Class BIFFEntry
		' Token: 0x06000010 RID: 16 RVA: 0x00217854 File Offset: 0x00216854
		Public Sub New(index As Integer, fs As FileStream, offset As Integer)
			Dim binaryReader As BinaryReader = New BinaryReader(fs)
			Me.index = index
			fs.Seek(CLng(offset), SeekOrigin.Begin)
			Me.filelength = binaryReader.ReadInt32()
			Me.stringoffset = binaryReader.ReadInt32()
			Me.stringlength = CInt(binaryReader.ReadInt16())
			Me.location = CInt(binaryReader.ReadInt16())
			fs.Seek(CLng(Me.stringoffset), SeekOrigin.Begin)
			Me.filename = New String(binaryReader.ReadChars(Me.stringlength - 1))
			If Me.filename.StartsWith("\\") Then
				Me.filename = Me.filename.Substring(1)
			End If
			Me.filename = Me.filename.Replace("\\", "\").Replace(":", "\")
			Me.BIFname = Me.filename.Replace("data\", "").Replace(".bif", "")
		End Sub

		' Token: 0x06000011 RID: 17 RVA: 0x00217950 File Offset: 0x00216950
		Public Sub New(index As Integer, ms As MemoryStream, offset As Integer)
			Dim binaryReader As BinaryReader = New BinaryReader(ms)
			Me.index = index
			ms.Seek(CLng(offset), SeekOrigin.Begin)
			Me.filelength = binaryReader.ReadInt32()
			Me.stringoffset = binaryReader.ReadInt32()
			Me.stringlength = CInt(binaryReader.ReadInt16())
			Me.location = CInt(binaryReader.ReadInt16())
			ms.Seek(CLng(Me.stringoffset), SeekOrigin.Begin)
			Me.filename = New String(binaryReader.ReadChars(Me.stringlength - 1))
			If Me.filename.StartsWith("\\") Then
				Me.filename = Me.filename.Substring(1)
			End If
			Me.filename = Me.filename.Replace("\\", "\").Replace(":", "\")
			Me.BIFname = Me.filename.Replace("data\", "").Replace(".bif", "")
		End Sub

		' Token: 0x0400000C RID: 12
		Public index As Integer

		' Token: 0x0400000D RID: 13
		Public filelength As Integer

		' Token: 0x0400000E RID: 14
		Public stringoffset As Integer

		' Token: 0x0400000F RID: 15
		Public stringlength As Integer

		' Token: 0x04000010 RID: 16
		Public location As Integer

		' Token: 0x04000011 RID: 17
		Public filename As String

		' Token: 0x04000012 RID: 18
		Public BIFname As String
	End Class
End Namespace
