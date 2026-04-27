Imports System
Imports System.Collections
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000015 RID: 21
	Public Class clsERF
		' Token: 0x06000063 RID: 99 RVA: 0x0021C25C File Offset: 0x0021B25C
        'Public Sub New(outputFilePath As String, FileType As String, DescriptionStrRef As UInteger, ERFLocalizedStringList As ERFLocalizedString(), inputFileList As String())
        '	Dim fileStream As FileStream = New FileStream(outputFilePath, FileMode.Create, FileAccess.Write)
        '	Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)
        '	Dim array As Char() = New Char(15) {}
        '	binaryWriter.Write((Strings.UCase(Strings.Trim(FileType)) + " V1.0").ToCharArray())
        '	Dim num3 As Integer
        '	Dim j As Integer
        '	If ERFLocalizedStringList IsNot Nothing AndAlso ERFLocalizedStringList.Length > 0 Then
        '		Dim i As Integer
        '		If(StringType.StrCmp(Strings.LCase(FileType), "erf", False) = 0) Or (StringType.StrCmp(Strings.LCase(FileType), "hak", False) = 0) Then
        '			i = 1
        '		Else
        '			i = 0
        '		End If
        '		Dim num As Integer = 0
        '		Dim num2 As Integer = ERFLocalizedStringList.Length - 1
        '		j = num
        '		While j <= num2
        '			num3 += 8 + ERFLocalizedStringList(j)._StringSize + i
        '			j += 1
        '		End While
        '		binaryWriter.Write(ERFLocalizedStringList.Length)
        '	Else
        '		binaryWriter.Write(0)
        '	End If
        '	binaryWriter.Write(num3)
        '	binaryWriter.Write(inputFileList.Length)
        '	binaryWriter.Write(160)
        '	binaryWriter.Write(num3 + 160)
        '	binaryWriter.Write(num3 + inputFileList.Length * 24 + 160)
        '	binaryWriter.Write(DateAndTime.Year(DateAndTime.Now) - 1900)
        '	binaryWriter.Write(CInt(DateAndTime.DateDiff(DateInterval.DayOfYear, DateType.FromString("1/1/" + StringType.FromInteger(DateAndTime.Year(DateAndTime.Now))), DateAndTime.Now, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)))
        '	binaryWriter.Write(DescriptionStrRef)
        '	j = 1
        '	Do
        '		binaryWriter.Write(0)
        '		j += 1
        '	Loop While j <= 29
        '	fileStream.Seek(160L, SeekOrigin.Begin)
        '	If ERFLocalizedStringList IsNot Nothing AndAlso ERFLocalizedStringList.Length > 0 Then
        '		Dim i As Integer
        '		If(StringType.StrCmp(Strings.LCase(FileType), "erf", False) = 0) Or (StringType.StrCmp(Strings.LCase(FileType), "hak", False) = 0) Then
        '			i = 1
        '		Else
        '			i = 0
        '		End If
        '		Dim num4 As Integer = 0
        '		Dim num5 As Integer = ERFLocalizedStringList.Length - 1
        '		j = num4
        '		While j <= num5
        '			binaryWriter.Write(ERFLocalizedStringList(j)._LanguageID)
        '			binaryWriter.Write(ERFLocalizedStringList(j)._StringSize)
        '			Dim array2 As Char() = New Char(ERFLocalizedStringList(j)._StringSize + i - 1 + 1 - 1) {}
        '			Array.Clear(array2, 0, array2.Length)
        '			Dim num6 As Integer = 0
        '			Dim num7 As Integer = ERFLocalizedStringList(j)._StringSize - 1
        '			For k As Integer = num6 To num7
        '				array2(k) = ERFLocalizedStringList(j)._StringText(k)
        '			Next
        '			binaryWriter.Write(array2)
        '			j += 1
        '		End While
        '	End If
        '	fileStream.Seek(CLng((num3 + 160)), SeekOrigin.Begin)
        '	Dim num8 As Integer = 0
        '	Dim num9 As Integer = inputFileList.Length - 1
        '	For j As Integer = num8 To num9
        '		Dim i As Integer = 0
        '		Do
        '			array(i) = vbNullChar
        '			i += 1
        '		Loop While i <= 15
        '		Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(inputFileList(j))
        '		Dim num10 As Integer = 0
        '		Dim num11 As Integer = fileNameWithoutExtension.Length - 1
        '		i = num10
        '		While i <= num11
        '			array(i) = fileNameWithoutExtension(i)
        '			i += 1
        '		End While
        '		binaryWriter.Write(array)
        '		binaryWriter.Write(j)
        '		binaryWriter.Write(frmMain.GetIDForRsrcType(Strings.Mid(Path.GetExtension(inputFileList(j)), 2)))
        '		binaryWriter.Write(0)
        '		binaryWriter.Write(0)
        '	Next
        '	Dim num12 As UInteger = Convert.ToUInt32(fileStream.Position + CLng((inputFileList.Length * 8)))
        '	Dim num13 As Integer = 0
        '	Dim num14 As Integer = inputFileList.Length - 1
        '	For j As Integer = num13 To num14
        '		binaryWriter.Write(num12)
        '		Dim num15 As UInteger = Convert.ToUInt32(New FileInfo(inputFileList(j)).Length)
        '		binaryWriter.Write(num15)
        '		num12 = Convert.ToUInt32(Convert.ToInt64(num12) + Convert.ToInt64(num15))
        '	Next
        '	Dim num16 As Integer = 0
        '	Dim num17 As Integer = inputFileList.Length - 1
        '	For j As Integer = num16 To num17
        '		Dim fileStream2 As FileStream = New FileStream(inputFileList(j), FileMode.Open, FileAccess.Read)
        '		Dim binaryReader As BinaryReader = New BinaryReader(fileStream2)
        '		fileStream.Write(binaryReader.ReadBytes(CInt(New FileInfo(inputFileList(j)).Length)), 0, CInt(New FileInfo(inputFileList(j)).Length))
        '		binaryReader.Close()
        '	Next
        '	binaryWriter.Close()
        'End Sub

        ' Token: 0x06000063 RID: 99 RVA: 0x0021C25C File Offset: 0x0021B25C
        Public Sub New(ByVal outputFilePath As String, ByVal FileType As String, ByVal DescriptionStrRef As UInteger, ByVal ERFLocalizedStringList As ERFLocalizedString(), ByVal inputFileList As String())

            Dim fileStream As FileStream = New FileStream(outputFilePath, FileMode.Create, FileAccess.Write)
            Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)
            Dim array As Char() = New Char(15) {}

            binaryWriter.Write((Strings.UCase(Strings.Trim(FileType)) + " V1.0").ToCharArray())

            Dim num3 As Integer = 0
            Dim j As Integer
            Dim i As Integer

            If ERFLocalizedStringList IsNot Nothing AndAlso ERFLocalizedStringList.Length > 0 Then

                If (StringType.StrCmp(Strings.LCase(FileType), "erf", False) = 0) OrElse (StringType.StrCmp(Strings.LCase(FileType), "hak", False) = 0) Then
                    i = 1
                Else
                    i = 0
                End If

                Dim num As Integer = 0
                Dim num2 As Integer = ERFLocalizedStringList.Length - 1

                j = num
                While j <= num2
                    num3 += 8 + ERFLocalizedStringList(j)._StringSize + i
                    j += 1
                End While

                binaryWriter.Write(ERFLocalizedStringList.Length)

            Else

                binaryWriter.Write(0)

            End If

            binaryWriter.Write(num3)
            binaryWriter.Write(inputFileList.Length)
            binaryWriter.Write(160)
            binaryWriter.Write(num3 + 160)
            binaryWriter.Write(num3 + inputFileList.Length * 24 + 160)
            binaryWriter.Write(DateAndTime.Year(DateAndTime.Now) - 1900)
            binaryWriter.Write(CInt(DateAndTime.DateDiff(DateInterval.DayOfYear, DateType.FromString("1/1/" + StringType.FromInteger(DateAndTime.Year(DateAndTime.Now))), DateAndTime.Now, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)))
            binaryWriter.Write(DescriptionStrRef)

            j = 1
            Do
                binaryWriter.Write(0)
                j += 1
            Loop While j <= 29

            fileStream.Seek(160L, SeekOrigin.Begin)

            If ERFLocalizedStringList IsNot Nothing AndAlso ERFLocalizedStringList.Length > 0 Then

                If (StringType.StrCmp(Strings.LCase(FileType), "erf", False) = 0) OrElse (StringType.StrCmp(Strings.LCase(FileType), "hak", False) = 0) Then
                    i = 1
                Else
                    i = 0
                End If

                Dim num4 As Integer = 0
                Dim num5 As Integer = ERFLocalizedStringList.Length - 1

                j = num4
                While j <= num5
                    binaryWriter.Write(ERFLocalizedStringList(j)._LanguageID)
                    binaryWriter.Write(ERFLocalizedStringList(j)._StringSize)

                    Dim array2 As Char() = New Char(ERFLocalizedStringList(j)._StringSize + i - 1 + 1 - 1) {}
                    System.Array.Clear(array2, 0, array2.Length)

                    Dim num6 As Integer = 0
                    Dim num7 As Integer = ERFLocalizedStringList(j)._StringSize - 1

                    For k As Integer = num6 To num7
                        array2(k) = ERFLocalizedStringList(j)._StringText(k)
                    Next

                    binaryWriter.Write(array2)

                    j += 1
                End While

            End If

            fileStream.Seek(CLng((num3 + 160)), SeekOrigin.Begin)

            Dim num8 As Integer = 0
            Dim num9 As Integer = inputFileList.Length - 1

            For j = num8 To num9

                i = 0
                Do
                    array(i) = Global.Microsoft.VisualBasic.Constants.vbNullChar
                    i += 1
                Loop While i <= 15

                Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(inputFileList(j))

                Dim num10 As Integer = 0
                Dim num11 As Integer = fileNameWithoutExtension.Length - 1

                i = num10
                While i <= num11
                    array(i) = fileNameWithoutExtension(i)
                    i += 1
                End While

                binaryWriter.Write(array)
                binaryWriter.Write(j)
                binaryWriter.Write(frmMain.GetIDForRsrcType(Strings.Mid(Path.GetExtension(inputFileList(j)), 2)))
                binaryWriter.Write(0)
                binaryWriter.Write(0)

            Next

            Dim num12 As UInteger = Convert.ToUInt32(fileStream.Position + CLng((inputFileList.Length * 8)))

            Dim num13 As Integer = 0
            Dim num14 As Integer = inputFileList.Length - 1

            For j = num13 To num14
                binaryWriter.Write(num12)

                Dim num15 As UInteger = Convert.ToUInt32(New FileInfo(inputFileList(j)).Length)

                binaryWriter.Write(num15)

                num12 = Convert.ToUInt32(Convert.ToInt64(num12) + Convert.ToInt64(num15))
            Next

            Dim num16 As Integer = 0
            Dim num17 As Integer = inputFileList.Length - 1

            For j = num16 To num17
                Dim fileStream2 As FileStream = New FileStream(inputFileList(j), FileMode.Open, FileAccess.Read)
                Dim binaryReader As BinaryReader = New BinaryReader(fileStream2)

                fileStream.Write(binaryReader.ReadBytes(CInt(New FileInfo(inputFileList(j)).Length)), 0, CInt(New FileInfo(inputFileList(j)).Length))

                binaryReader.Close()
            Next

            binaryWriter.Close()

        End Sub

		' Token: 0x06000064 RID: 100 RVA: 0x0021C680 File Offset: 0x0021B680
		Public Sub New(fs As FileStream)
			Dim binaryReader As BinaryReader = New BinaryReader(fs, Encoding.ASCII)
			Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Me.fstream = fs
			fs.Seek(16L, SeekOrigin.Begin)
			Me.EntryCount = binaryReader.ReadInt32()
			fs.Seek(4L, SeekOrigin.Current)
			Me.OffKeyList = binaryReader.ReadInt32()
			Me.OffsetResList = binaryReader.ReadInt32()
			Me.KeyEntryList = New ArrayList(Me.EntryCount)
			fs.Seek(CLng(Me.OffKeyList), SeekOrigin.Begin)
			Me.KeyData = binaryReader.ReadBytes(24 * Me.EntryCount)
			Me.ResInfoData = binaryReader.ReadBytes(16 * Me.EntryCount)
			Dim num As Integer = 0
			Dim num2 As Integer = Me.EntryCount - 1
			For i As Integer = num To num2
				stringBuilder.Append(asciiencoding.GetString(Me.KeyData, i * 24, 16))
				Dim num3 As Integer = 0
				While Me.KeyData(num3 + i * 24) <> 0
					num3 += 1
					If num3 > 15 Then
						Exit While
					End If
				End While
				stringBuilder.Length = num3
				Dim text As String = stringBuilder.ToString()
				stringBuilder.Length = 0
				Dim num4 As Integer = CInt(Math.Round(CDbl(Me.KeyData(i * 24 + 16)) + CDbl(Me.KeyData(i * 24 + 17)) * 256.0 + CDbl(Me.KeyData(i * 24 + 18)) * 65536.0 + CDbl(Me.KeyData(i * 24 + 19)) * 16777216.0))
				Dim num5 As Short = CShort(Math.Round(CDbl(Me.KeyData(i * 24 + 20)) + CDbl(Me.KeyData(i * 24 + 21)) * 256.0))
				Dim num6 As Integer = CInt(Math.Round(CDbl(Me.ResInfoData(i * 8)) + CDbl(Me.ResInfoData(i * 8 + 1)) * 256.0 + CDbl(Me.ResInfoData(i * 8 + 2)) * 65536.0 + CDbl(Me.ResInfoData(i * 8 + 3)) * 16777216.0))
				Dim num7 As Integer = CInt(Math.Round(CDbl(Me.ResInfoData(i * 8 + 4)) + CDbl(Me.ResInfoData(i * 8 + 5)) * 256.0 + CDbl(Me.ResInfoData(i * 8 + 6)) * 65536.0 + CDbl(Me.ResInfoData(i * 8 + 7)) * 16777216.0))
				Dim erfkeyEntry As ERFKeyEntry = New ERFKeyEntry(text, num5, num4, num6, num7, i)
				Me.KeyEntryList.Add(erfkeyEntry)
			Next
		End Sub

		' Token: 0x06000065 RID: 101 RVA: 0x0021C920 File Offset: 0x0021B920
		Public Function getERFResource(index As Integer) As Byte()
			Dim binaryReader As BinaryReader = New BinaryReader(Me.fstream, Encoding.ASCII)
			Dim erfkeyEntry As ERFKeyEntry = CType(Me.KeyEntryList(index), ERFKeyEntry)
			Dim array As Byte() = New Byte(erfkeyEntry._Length - 1 + 1 - 1) {}
			Me.fstream.Seek(CLng(erfkeyEntry._Offset), SeekOrigin.Begin)
			Return binaryReader.ReadBytes(erfkeyEntry._Length)
		End Function

		' Token: 0x06000066 RID: 102 RVA: 0x0021C984 File Offset: 0x0021B984
		Public Function getERFResource(ResRef As String, ResType As Integer) As Byte()
			Return Me.getERFResource(Me.FindIndexForResRef(ResRef, ResType))
		End Function

		' Token: 0x06000067 RID: 103 RVA: 0x0021C9A0 File Offset: 0x0021B9A0
		Public Function FindIndexForResRef(ResRef As String, ResType As Integer) As Integer
			Dim index As Integer
			Try
				For Each obj As Object In Me.KeyEntryList
					Dim erfkeyEntry As ERFKeyEntry = CType(obj, ERFKeyEntry)
					If StringType.StrCmp(Strings.LCase(erfkeyEntry._ResourceName), Strings.LCase(ResRef), False) = 0 AndAlso CInt(erfkeyEntry._ResType) = ResType Then
						index = erfkeyEntry._Index
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return index
		End Function

		' Token: 0x06000068 RID: 104 RVA: 0x0021CA24 File Offset: 0x0021BA24
		Public Function GetERFTPCResourceHeader(index As Integer) As Byte()
			Dim binaryReader As BinaryReader = New BinaryReader(Me.fstream, Encoding.ASCII)
			Dim erfkeyEntry As ERFKeyEntry = CType(Me.KeyEntryList(index), ERFKeyEntry)
			Dim array As Byte() = New Byte(15) {}
			Me.fstream.Seek(CLng(erfkeyEntry._Offset), SeekOrigin.Begin)
			Return binaryReader.ReadBytes(16)
		End Function

		' Token: 0x04000097 RID: 151
		Public EntryCount As Integer

		' Token: 0x04000098 RID: 152
		Public OffKeyList As Integer

		' Token: 0x04000099 RID: 153
		Public OffsetResList As Integer

		' Token: 0x0400009A RID: 154
		Public KeyEntryList As ArrayList

		' Token: 0x0400009B RID: 155
		Private KeyData As Byte()

		' Token: 0x0400009C RID: 156
		Private ResInfoData As Byte()

		' Token: 0x0400009D RID: 157
		Private fstream As FileStream
	End Class
End Namespace
