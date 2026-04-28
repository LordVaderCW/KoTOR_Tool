Imports System
Imports System.IO

Namespace kotor_tool
	' Token: 0x02000007 RID: 7
	Public Class BIFFArchive
		' Token: 0x06000019 RID: 25 RVA: 0x00217C08 File Offset: 0x00216C08
		Public Sub New()
		End Sub

		' Token: 0x0600001A RID: 26 RVA: 0x00217C10 File Offset: 0x00216C10
		Public Sub New(fsin As FileStream)
			Me.fs = fsin
			Me.readBIFFHeader(Me.fs)
		End Sub

		' Token: 0x0600001B RID: 27 RVA: 0x00217C2C File Offset: 0x00216C2C
		Private Sub readBIFFHeader(fs As FileStream)
			Dim binaryReader As BinaryReader = New BinaryReader(fs)
			Me.signature = New String(binaryReader.ReadChars(4))
			Me.version = New String(binaryReader.ReadChars(4))
			Me.VarResCnt = binaryReader.ReadInt32()
			Me.FixedResCnt = binaryReader.ReadInt32()
			Me.VarResEntryOff = binaryReader.ReadInt32()
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x00217C88 File Offset: 0x00216C88
		Public Function getBIFFResourceInfo(offset As Integer) As BIFFVarRsrcEntryInfo
			Dim binaryReader As BinaryReader = New BinaryReader(Me.fs)
			Me.fs.Seek(CLng((Me.VarResEntryOff + 16 * offset)), SeekOrigin.Begin)
			Return New BIFFVarRsrcEntryInfo(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32())
		End Function

		' Token: 0x0600001D RID: 29 RVA: 0x00217CD8 File Offset: 0x00216CD8
		Public Shared Function GetBIFFResourceInfoList(biffPath As String) As BIFFVarRsrcEntryInfo()
			Dim fileStream As FileStream = New FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
			Dim binaryReader As BinaryReader = New BinaryReader(fileStream)
			binaryReader.ReadChars(8)
			Dim num As Integer = binaryReader.ReadInt32()
			binaryReader.ReadInt32()
			Dim num2 As Integer = binaryReader.ReadInt32()
            Dim array As BIFFVarRsrcEntryInfo() = CType(System.Array.CreateInstance(GetType(BIFFVarRsrcEntryInfo), num), BIFFVarRsrcEntryInfo())
			Dim num3 As Integer = 0
			Dim num4 As Integer = num - 1
			For i As Integer = num3 To num4

					' The following expression was wrapped in a checked-expression
					fileStream.Seek(CLng((num2 + 16 * i)), SeekOrigin.Begin)
					array(i) = New BIFFVarRsrcEntryInfo(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32())

			Next
			Return array
		End Function

		' Token: 0x0600001E RID: 30 RVA: 0x00217D80 File Offset: 0x00216D80
		Public Function getBIFFResource(offset As Integer) As BIFFVarRsrcEntry
			Dim binaryReader As BinaryReader = New BinaryReader(Me.fs)
			Dim biffvarRsrcEntry As BIFFVarRsrcEntry = New BIFFVarRsrcEntry()
			Dim biffresourceInfo As BIFFVarRsrcEntryInfo = Me.getBIFFResourceInfo(offset)
			Me.fs.Seek(CLng(biffresourceInfo.Offset), SeekOrigin.Begin)
			biffvarRsrcEntry.data = binaryReader.ReadBytes(biffresourceInfo.FileSize)
			Return biffvarRsrcEntry
		End Function

		' Token: 0x0600001F RID: 31 RVA: 0x00217DD0 File Offset: 0x00216DD0
		Public Shared Function getBIFFResource(biffPath As String, resourceID As Integer) As BIFFVarRsrcEntry
			Dim fileStream As FileStream = New FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
			Return New BIFFArchive(fileStream).getBIFFResource(resourceID)
		End Function

		' Token: 0x17000006 RID: 6
		' (get) Token: 0x06000020 RID: 32 RVA: 0x00217DF8 File Offset: 0x00216DF8
		Public ReadOnly Property ResCount As Integer
			Get
				Return Me.VarResCnt
			End Get
		End Property

		' Token: 0x04000017 RID: 23
		Private VarResCnt As Integer

		' Token: 0x04000018 RID: 24
		Private FixedResCnt As Integer

		' Token: 0x04000019 RID: 25
		Private VarResEntryOff As Integer

		' Token: 0x0400001A RID: 26
		Private FixedResEntryOff As Integer

		' Token: 0x0400001B RID: 27
		Private fs As FileStream

		' Token: 0x0400001C RID: 28
		Private signature As String

		' Token: 0x0400001D RID: 29
		Private version As String
	End Class
End Namespace
