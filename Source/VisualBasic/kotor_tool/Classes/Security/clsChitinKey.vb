Imports System
Imports System.Collections
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200000F RID: 15
	Public Class clsChitinKey
		' Token: 0x0600002F RID: 47 RVA: 0x0021928C File Offset: 0x0021828C
		Public Sub New(KeyPath As String)
			Me.htBIF = New Hashtable()
			Me.BiffListInfo = New Hashtable()
			Me.keyfs = New FileStream(KeyPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 570000)
			Dim array As Byte() = New Byte(CInt((Me.keyfs.Length - 1L)) + 1 - 1) {}
			Me.Llength = Me.keyfs.Length
			Me.rdr = New BinaryReader(Me.keyfs, Encoding.ASCII)
			array = Me.rdr.ReadBytes(CInt(Me.keyfs.Length))
			Me.rdr.Close()
			Me.g_ms = New MemoryStream(array)
			Me.rdr = New BinaryReader(Me.g_ms, Encoding.ASCII)
			For Each value As Byte In array
				Me.Lsum += CLng(value)
			Next
			Console.WriteLine("chitin.key sum = " + StringType.FromLong(Me.Lsum))
			Me.g_ms.Seek(8L, SeekOrigin.Begin)
			Me.BIFCount = Me.rdr.ReadInt32()
			Me.KeyCount = Me.rdr.ReadInt32()
			Me.FileTableOff = Me.rdr.ReadInt32()
			Me.KeyTableOff = Me.rdr.ReadInt32()
			Me.BiffList = CType(Array.CreateInstance(GetType(BIFFEntry), Me.BIFCount), BIFFEntry())
			Dim num4 As Integer = 0
			Dim num5 As Integer = Me.BIFCount - 1
			For i As Integer = num4 To num5
				Me.BiffList(i) = New BIFFEntry(i, Me.g_ms, Me.FileTableOff + 12 * i)
				Me.BiffListInfo.Add(Me.BiffList(i).BIFname, Me.BiffList(i))
				If Me.htBIF.ContainsKey(Me.BiffList(i).filename) Then
					Interaction.MsgBox("Your chitin.key file appears to contain multiple entries of the same BIF archive." & vbLf & "You may want to reinstall KotOR to fix this.", MsgBoxStyle.Exclamation, "Questionable chitin.key file")
				Else
					Me.htBIF.Add(Me.BiffList(i).filename, Me.BiffList(i).filelength)
				End If
			Next
		End Sub

		' Token: 0x06000030 RID: 48 RVA: 0x002194FC File Offset: 0x002184FC
		Public Function GetBIFFileHash(BifName As String) As Hashtable
			' The following expression was wrapped in a checked-statement
			If Me.htResRefPlusID Is Nothing OrElse StringType.StrCmp(Me.LastRequestedBifNameHash, BifName, False) <> 0 Then
				Dim stringBuilder As StringBuilder = New StringBuilder()
				Me.htResRefPlusID = New Hashtable()
				Dim num As Integer = 0
				Dim upperBound As Integer = Me.BiffList.GetUpperBound(0)
				Dim num2 As Integer
				Dim flag As Boolean
				For i As Integer = num To upperBound
					If StringType.StrCmp(Me.BiffList(i).BIFname.ToLower(), BifName.ToLower(), False) = 0 Then
						num2 = i
						flag = True
						Exit For
					End If
				Next
				If Not flag Then
					Return Nothing
				End If
				Me.LastRequestedBifNameHash = BifName
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.KeyCount - 1
				For i As Integer = num3 To num4
					Dim num5 As Integer

						' The following expression was wrapped in a checked-expression
						Me.g_ms.Seek(CLng((Me.KeyTableOff + 22 * i)), SeekOrigin.Begin)
						stringBuilder.Length = 0
						stringBuilder.Append(Me.rdr.ReadChars(16))
						num5 = 15

					While Strings.Asc(stringBuilder(num5)) = 0
						num5 += -1
						If num5 < 0 Then
							Exit While
						End If
					End While
					stringBuilder.Length = num5 + 1
					Dim text As String = stringBuilder.ToString()
					Dim num6 As Integer = Convert.ToInt32(Me.rdr.ReadUInt16())
					Dim num7 As Integer = Me.rdr.ReadInt32()
					If num7 >> 20 = num2 Then
						Me.htResRefPlusID.Add(text + "." + frmMain.GetRsrcTypeForID(num6), num7 And 1048575)
					End If
				Next
			End If
			Return Me.htResRefPlusID
		End Function

		' Token: 0x06000031 RID: 49 RVA: 0x00219664 File Offset: 0x00218664
		Public Function FindResIDForResRef(ResRef As String, ResType As Integer) As Integer
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim num As Integer = 0
			Dim num2 As Integer = Me.KeyCount - 1
			For i As Integer = num To num2
				Dim num3 As Integer

					' The following expression was wrapped in a checked-expression
					Me.g_ms.Seek(CLng((Me.KeyTableOff + 22 * i)), SeekOrigin.Begin)
					stringBuilder.Length = 0
					stringBuilder.Append(Me.rdr.ReadChars(16))
					num3 = 15

				While Strings.Asc(stringBuilder(num3)) = 0
					num3 += -1
					If num3 < 0 Then
						Exit While
					End If
				End While
				stringBuilder.Length = num3 + 1
				If StringType.StrCmp(Strings.LCase(ResRef), Strings.LCase(stringBuilder.ToString()), False) = 0 AndAlso Convert.ToInt32(Me.rdr.ReadUInt16()) = ResType Then
					Return Me.rdr.ReadInt32()
				End If
			Next
			Return -1
		End Function

		' Token: 0x06000032 RID: 50 RVA: 0x00219728 File Offset: 0x00218728
		Public Function GetKeysforResourceType(ResType As Short) As ArrayList
			Dim arrayList As ArrayList = New ArrayList()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim num As Integer = 0
			Dim num2 As Integer = Me.KeyCount - 1
			For i As Integer = num To num2
				Dim num3 As Integer

					' The following expression was wrapped in a checked-expression
					Me.g_ms.Seek(CLng((Me.KeyTableOff + 22 * i)), SeekOrigin.Begin)
					stringBuilder.Length = 0
					stringBuilder.Append(Me.rdr.ReadChars(16))
					num3 = 15

				While Strings.Asc(stringBuilder(num3)) = 0
					num3 += -1
					If num3 < 0 Then
						Exit While
					End If
				End While
				stringBuilder.Length = num3 + 1
				If Me.rdr.ReadInt16() = ResType Then
					arrayList.Add(New KeyEntry(stringBuilder.ToString(), ResType, Me.rdr.ReadInt32()))
				End If
			Next
			Return arrayList
		End Function

		' Token: 0x06000033 RID: 51 RVA: 0x002197E8 File Offset: 0x002187E8
		Public Function IsValid(index As Integer) As Boolean
			If index = 0 Then
				Return Me.htBIF.ContainsKey("data\2da.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\2da.bif"), 431840, False) = 0 AndAlso Me.htBIF.ContainsKey("data\gui.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\gui.bif"), 1621224, False) = 0 AndAlso Me.htBIF.ContainsKey("data\items.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\items.bif"), 16362316, False) = 0 AndAlso Me.htBIF.ContainsKey("data\layouts.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\layouts.bif"), 141915, False) = 0 AndAlso Me.htBIF.ContainsKey("data\legacy.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\legacy.bif"), 196688, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps.bif"), 3811348, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps10.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps10.bif"), 4945347, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps11.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps11.bif"), 6972364, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps12.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps12.bif"), 5192454, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps13.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps13.bif"), 23308504, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps2.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps2.bif"), 2177180, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps3.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps3.bif"), 3630567, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps4.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps4.bif"), 19326133, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps5.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps5.bif"), 9694141, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps6.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps6.bif"), 12061343, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps7.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps7.bif"), 7490884, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps8.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps8.bif"), 11259740, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps9.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps9.bif"), 4121097, False) = 0 AndAlso Me.htBIF.ContainsKey("data\models.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\models.bif"), 954052730, False) = 0 AndAlso Me.htBIF.ContainsKey("data\party.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\party.bif"), 6862196, False) = 0 AndAlso Me.htBIF.ContainsKey("data\player.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\player.bif"), 15791965, False) = 0 AndAlso Me.htBIF.ContainsKey("data\scripts.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\scripts.bif"), 4723499, False) = 0 AndAlso Me.htBIF.ContainsKey("data\sounds.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\sounds.bif"), 194679056, False) = 0 AndAlso Me.htBIF.ContainsKey("data\templates.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\templates.bif"), 6259440, False) = 0 AndAlso Me.htBIF.ContainsKey("data\_newbif.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\_newbif.bif"), 77337, False) = 0 AndAlso Me.htBIF.ContainsKey("data\textures.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\textures.bif"), 920772, False) = 0
			End If
			Return index = 1 AndAlso Me.htBIF.ContainsKey("data\2da.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\2da.bif"), 908682, False) = 0 AndAlso Not BooleanType.FromObject(If((BooleanType.FromObject(Not Me.htBIF.ContainsKey("data\dialogs.bif")) OrElse BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(Me.htBIF("data\dialogs.bif"), 12059157, False) <> 0, ObjectType.ObjTst(Me.htBIF("data\dialogs.bif"), 12061533, False) <> 0))), True, False)) AndAlso Me.htBIF.ContainsKey("data\templates.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\templates.bif"), 4255689, False) = 0 AndAlso Me.htBIF.ContainsKey("data\lightmaps.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\lightmaps.bif"), 91195876, False) = 0 AndAlso Me.htBIF.ContainsKey("data\models.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\models.bif"), 866238402, False) = 0 AndAlso Me.htBIF.ContainsKey("data\textures.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\textures.bif"), 592529, False) = 0 AndAlso Me.htBIF.ContainsKey("data\gui.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\gui.bif"), 3163669, False) = 0 AndAlso Me.htBIF.ContainsKey("data\layouts.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\layouts.bif"), 153782, False) = 0 AndAlso Me.htBIF.ContainsKey("data\legacy.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\legacy.bif"), 196688, False) = 0 AndAlso Not BooleanType.FromObject(If((BooleanType.FromObject(Not Me.htBIF.ContainsKey("data\scripts.bif")) OrElse BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(Me.htBIF("data\scripts.bif"), 5412777, False) <> 0, ObjectType.ObjTst(Me.htBIF("data\scripts.bif"), 5415098, False) <> 0))), True, False)) AndAlso Me.htBIF.ContainsKey("data\sounds.bif") AndAlso ObjectType.ObjTst(Me.htBIF("data\sounds.bif"), 259696688, False) = 0
		End Function

		' Token: 0x0400004F RID: 79
		Private keyfs As FileStream

		' Token: 0x04000050 RID: 80
		Private g_ms As MemoryStream

		' Token: 0x04000051 RID: 81
		Private rdr As BinaryReader

		' Token: 0x04000052 RID: 82
		Private BIFCount As Integer

		' Token: 0x04000053 RID: 83
		Private KeyCount As Integer

		' Token: 0x04000054 RID: 84
		Private FileTableOff As Integer

		' Token: 0x04000055 RID: 85
		Private KeyTableOff As Integer

		' Token: 0x04000056 RID: 86
		Public Lsum As Long

		' Token: 0x04000057 RID: 87
		Public Llength As Long

		' Token: 0x04000058 RID: 88
		Public BiffList As BIFFEntry()

		' Token: 0x04000059 RID: 89
		Private htBIF As Hashtable

		' Token: 0x0400005A RID: 90
		Private htResRefPlusID As Hashtable

		' Token: 0x0400005B RID: 91
		Private LastRequestedBifNameHash As String

		' Token: 0x0400005C RID: 92
		Public BiffListInfo As Hashtable
	End Class
End Namespace
