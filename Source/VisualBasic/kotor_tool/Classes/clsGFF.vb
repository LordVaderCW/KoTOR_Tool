Imports System
Imports System.Collections
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000018 RID: 24
	Public Class clsGFF
		' Token: 0x17000010 RID: 16
		' (get) Token: 0x0600006C RID: 108 RVA: 0x0021CAFC File Offset: 0x0021BAFC
		' (set) Token: 0x0600006D RID: 109 RVA: 0x0021CB10 File Offset: 0x0021BB10
		Public Property RTFMode As Boolean
			Get
				Return Me.g_bRTF_mode
			End Get
			Set(value As Boolean)
				Me.g_bRTF_mode = value
			End Set
		End Property

		' Token: 0x0600006E RID: 110 RVA: 0x0021CB1C File Offset: 0x0021BB1C
		Public Overrides Function ToString() As String
			Return Me.g_stringbuilder.ToString()
		End Function

		' Token: 0x0600006F RID: 111 RVA: 0x0021CB34 File Offset: 0x0021BB34
		Public Sub New(KotorVerIndex As Integer)
			Me.g_gff_ListArr = New ArrayList()
			Me.g_tabLevel = 0
			Me.g_stringbuilder = New StringBuilder()
			Me.g_bRTF_mode = True
			Me.NodeSearchLevel = 0
			Me.root_GFFStruct = New GFF_Struct()
			Me.g_fieldCountforCoding = 0
			Me.max_offset = 0
			Me.offsetCnt = 0
			Me.KotorVersionIndex = KotorVerIndex
			If KotorVerIndex > -1 Then
				Me.dialogTlk = New clsDialogTlk(UserSettings.GetSettings().KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
			End If
			Me.CreateRootStruct()
		End Sub

		' Token: 0x06000070 RID: 112 RVA: 0x0021CBC4 File Offset: 0x0021BBC4
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer, Optional RTF_Mode As Boolean = True)
			Me.g_gff_ListArr = New ArrayList()
			Me.g_tabLevel = 0
			Me.g_stringbuilder = New StringBuilder()
			Me.g_bRTF_mode = True
			Me.NodeSearchLevel = 0
			Me.root_GFFStruct = New GFF_Struct()
			Me.g_fieldCountforCoding = 0
			Me.max_offset = 0
			Me.offsetCnt = 0
			Me.KotorVersionIndex = KotorVerIndex
			If KotorVerIndex > -1 Then
				Me.dialogTlk = New clsDialogTlk(UserSettings.GetSettings().KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
			End If
			Me.g_bRTF_mode = RTF_Mode
			Me.Parse(bytes)
		End Sub

		' Token: 0x06000071 RID: 113 RVA: 0x0021CC5C File Offset: 0x0021BC5C
		Public Sub New(fs As FileStream, KotorVerIndex As Integer, Optional RTF_Mode As Boolean = True)
			Me.g_gff_ListArr = New ArrayList()
			Me.g_tabLevel = 0
			Me.g_stringbuilder = New StringBuilder()
			Me.g_bRTF_mode = True
			Me.NodeSearchLevel = 0
			Me.root_GFFStruct = New GFF_Struct()
			Me.g_fieldCountforCoding = 0
			Me.max_offset = 0
			Me.offsetCnt = 0
			Me.KotorVersionIndex = KotorVerIndex
			Dim array As Byte() = New Byte(CInt((fs.Length - 1L)) + 1 - 1) {}
			Me.g_rdr = New BinaryReader(fs, Encoding.ASCII)
			array = Me.g_rdr.ReadBytes(CInt(fs.Length))
			Me.g_rdr.Close()
			If KotorVerIndex > -1 Then
				Me.dialogTlk = New clsDialogTlk(UserSettings.GetSettings().KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
			End If
			Me.g_bRTF_mode = RTF_Mode
			Me.Parse(array)
		End Sub

		' Token: 0x06000072 RID: 114 RVA: 0x0021CD3C File Offset: 0x0021BD3C
		Public Sub New(filepath As String, KotorVerIndex As Integer, Optional RTF_Mode As Boolean = True)
			Me.New(New FileStream(filepath, FileMode.Open, FileAccess.Read), KotorVerIndex, RTF_Mode)
		End Sub

		' Token: 0x06000073 RID: 115 RVA: 0x0021CD50 File Offset: 0x0021BD50
		Public Function KotorVersIndex() As Integer
			If Me.VerifyNodeExists("KTGameVerIndex") Then
				Return IntegerType.FromObject(Me.GetNodeValue("KTGameVerIndex"))
			End If
			Return -1
		End Function

		' Token: 0x06000074 RID: 116 RVA: 0x0021CD7C File Offset: 0x0021BD7C
		Public Function getFieldTypeStr(type As Integer) As String
			Select Case type
				Case 0
					Return "byte"
				Case 1
					Return "char"
				Case 2
					Return "word"
				Case 3
					Return "short"
				Case 4
					Return "dword"
				Case 5
					Return "int"
				Case 6
					Return "dword64"
				Case 7
					Return "int64"
				Case 8
					Return "float"
				Case 9
					Return "double"
				Case 10
					Return "CExoString"
				Case 11
					Return "CResRef"
				Case 12
					Return "CExoLocString"
				Case 13
					Return "void"
				Case 14
					Return "Struct"
				Case 15
					Return "List"
				Case 16
					Return "GFF Type 16"
				Case 17
					Return "GFF Type 17"
				Case Else
					Return "Unknown type: " + type.ToString()
			End Select
		End Function

		' Token: 0x06000075 RID: 117 RVA: 0x0021CE58 File Offset: 0x0021BE58
		Public Sub Parse(fs As FileStream)
			' The following expression was wrapped in a checked-statement
			Dim array As Byte() = New Byte(CInt((fs.Length - 1L)) + 1 - 1) {}
			Me.g_rdr = New BinaryReader(fs, Encoding.ASCII)
			array = Me.g_rdr.ReadBytes(CInt(fs.Length))
			Me.g_rdr.Close()
			Me.Parse(array)
		End Sub

		' Token: 0x06000076 RID: 118 RVA: 0x0021CEB4 File Offset: 0x0021BEB4
		Public Sub Parse(bytes As Byte())
			Dim gffstructEntry As GFFStructEntry = New GFFStructEntry()
			Me.g_ms = New MemoryStream(bytes)
			Me.g_rdr = New BinaryReader(Me.g_ms, Encoding.ASCII)
			Me.g_ms.Seek(8L, SeekOrigin.Begin)
			Me.g_StructOffset = Me.g_rdr.ReadInt32()
			Me.g_StructCount = Me.g_rdr.ReadInt32()
			Me.g_structArr = Array.CreateInstance(GetType(Object), Me.g_StructCount)
			Me.g_FieldOffset = Me.g_rdr.ReadInt32()
			Me.g_FieldCount = Me.g_rdr.ReadInt32()
			Me.g_LabelOffset = Me.g_rdr.ReadInt32()
			Me.g_LabelCount = Me.g_rdr.ReadInt32()
			Me.g_FieldDataOffset = Me.g_rdr.ReadInt32()
			Me.g_FieldDataCount = Me.g_rdr.ReadInt32()
			Me.g_FieldIndicesOffset = Me.g_rdr.ReadInt32()
			Me.g_FieldIndicesCount = Me.g_rdr.ReadInt32()
			Me.g_ListIndicesOffset = Me.g_rdr.ReadInt32()
			Me.g_ListIndicesCount = Me.g_rdr.ReadInt32()
			Me.g_ms.Seek(CLng(Me.g_StructOffset), SeekOrigin.Begin)
			If Me.g_bRTF_mode Then
				Me.PrintMsg("{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fmodern\fprq1\fcharset0 Lucida Console;}{\f1\fnil\fcharset0 Lucida Console;}}", False)
				Me.PrintMsg("{\colortbl ;\red0\green0\blue255;\red0\green120\blue0;\red255\green0\blue0;\red255\green0\blue255;}", False)
				Me.PrintMsg("\viewkind4\uc1\pard\f0\fs16", False)
			End If
			gffstructEntry.Type = CType(Me.g_rdr.ReadInt32(), GFFField)
			gffstructEntry.DataOrDataOffset = Me.g_rdr.ReadInt32()
			gffstructEntry.FieldCount = Me.g_rdr.ReadInt32()
			Me.root_GFFStruct = Me.GFFReadStruct(gffstructEntry)
			LateBinding.LateIndexSet(Me.g_structArr, New Object() { 0, Me.root_GFFStruct }, Nothing)
			Me.SortStructNames()
			If Me.g_bRTF_mode Then
				Me.PrintMsg("\f1\fs17\par", False)
			End If
		End Sub

		' Token: 0x06000077 RID: 119 RVA: 0x0021D0A8 File Offset: 0x0021C0A8
		Public Function SortStructNames() As ArrayList
			Dim arrayList As ArrayList = New ArrayList()
			Dim num As Integer = 0
			Dim num2 As Integer = CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { 0 }, Nothing), GFF_Struct).fields.Length - 1
			For i As Integer = num To num2
				arrayList.Add(CType(CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { 0 }, Nothing), GFF_Struct).fields, GFF_Field())(i).label)
			Next
			arrayList.Sort()
			Return arrayList
		End Function

		' Token: 0x06000078 RID: 120 RVA: 0x0021D13C File Offset: 0x0021C13C
		Public Function GFFReadStruct(ByRef structEntry As GFFStructEntry) As GFF_Struct
			Dim gfffieldEntry As GFFFieldEntry = New GFFFieldEntry()
			Dim gff_Struct As GFF_Struct = New GFF_Struct()
			gff_Struct.fields = New GFF_Field(structEntry.FieldCount - 1 + 1 - 1) {}
			gff_Struct.fieldCount = structEntry.FieldCount
			gff_Struct.type = CInt(structEntry.Type)
			gff_Struct.DataOrDataOffset = structEntry.DataOrDataOffset
			If Me.g_bRTF_mode Then
				Me.PrintMsg(String.Concat(New String() { "\cf1 Struct\cf0 - \cf2 Type:\cf0 ", StringType.FromInteger(CInt(structEntry.Type)), " \cf2  Field count:\cf0  ", StringType.FromInteger(structEntry.FieldCount), vbLf, "\par" }), True)
			Else
				Me.PrintMsg(String.Concat(New String() { "Struct - Type: ", StringType.FromInteger(CInt(structEntry.Type)), "  Field count:  ", StringType.FromInteger(structEntry.FieldCount), vbLf }), True)
			End If
			Me.g_tabLevel += 1
			If structEntry.FieldCount = 1 Then

					' The following expression was wrapped in a checked-expression
					Me.g_ms.Seek(CLng((Me.g_FieldOffset + structEntry.DataOrDataOffset * 12)), SeekOrigin.Begin)
					gfffieldEntry.Type = CType(Me.g_rdr.ReadInt32(), GFFField)
					gfffieldEntry.LabelIndex = Me.g_rdr.ReadInt32()
					gff_Struct.fields(0) = CType(Me.GFFReadField(gfffieldEntry), GFF_Field)

			Else
				Dim num As Integer = 0
				Dim num2 As Integer = structEntry.FieldCount - 1
				For i As Integer = num To num2

						' The following expression was wrapped in a checked-expression
						Me.g_ms.Seek(CLng((Me.g_FieldIndicesOffset + structEntry.DataOrDataOffset + i * 4)), SeekOrigin.Begin)
						Dim num3 As Integer = Me.g_rdr.ReadInt32()
						Me.g_ms.Seek(CLng((Me.g_FieldOffset + num3 * 12)), SeekOrigin.Begin)
						gfffieldEntry.Type = CType(Me.g_rdr.ReadInt32(), GFFField)
						gfffieldEntry.LabelIndex = Me.g_rdr.ReadInt32()
						gff_Struct.fields(i) = CType(Me.GFFReadField(gfffieldEntry), GFF_Field)

				Next
			End If
			Me.g_tabLevel -= 1
			If Me.g_bRTF_mode Then
				Me.PrintMsg("\cf1 End of struct\cf0" & vbLf & "\par", True)
			Else
				Me.PrintMsg(" End of struct" & vbLf, True)
			End If
			Return gff_Struct
		End Function

		' Token: 0x06000079 RID: 121 RVA: 0x0021D38C File Offset: 0x0021C38C
		Public Function GFFReadField(fieldEntry As GFFFieldEntry) As Object
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim gff_Field As GFF_Field = New GFF_Field()
			Dim position As Long = Me.g_rdr.BaseStream.Position
			Me.g_ms.Seek(CLng((Me.g_LabelOffset + fieldEntry.LabelIndex * 16)), SeekOrigin.Begin)
			stringBuilder.Length = 0
			stringBuilder.Append(Me.g_rdr.ReadChars(16))
			Dim i As Integer = 0
			While Strings.Asc(stringBuilder(i)) <> 0
				i += 1
				If i > 15 Then
					Exit While
				End If
			End While
			stringBuilder.Length = i
			gff_Field.label = stringBuilder.ToString()
			If Me.g_bRTF_mode Then
				Me.PrintMsg("\cf2 Label:\cf0  " + gff_Field.label.PadRight(16), True)
			Else
				Me.PrintMsg("Label:  " + gff_Field.label.PadRight(16), True)
			End If
			Me.g_ms.Seek(position, SeekOrigin.Begin)
			If fieldEntry.Type = GFFField.GFF_dword64 OrElse fieldEntry.Type = GFFField.GFF_int64 OrElse fieldEntry.Type >= GFFField.GFF_double Then
				fieldEntry.DataOrDataOffset = Me.g_rdr.ReadInt32()
				Me.g_ms.Seek(LongType.FromObject(ObjectType.AddObj(Me.g_FieldDataOffset, fieldEntry.DataOrDataOffset)), SeekOrigin.Begin)
			End If
			gff_Field.Type = fieldEntry.Type
			Select Case fieldEntry.Type
				Case GFFField.GFF_byte
					gff_Field.value = Me.g_rdr.ReadByte()
				Case GFFField.GFF_char
					gff_Field.value = Me.g_rdr.ReadChar()
				Case GFFField.GFF_word
					gff_Field.value = Me.g_rdr.ReadUInt16()
				Case GFFField.GFF_short
					gff_Field.value = Me.g_rdr.ReadInt16()
				Case GFFField.GFF_dword
					gff_Field.value = Me.g_rdr.ReadUInt32()
				Case GFFField.GFF_int
					gff_Field.value = Me.g_rdr.ReadInt32()
				Case GFFField.GFF_dword64
					gff_Field.value = Me.g_rdr.ReadUInt64()
				Case GFFField.GFF_int64
					gff_Field.value = Me.g_rdr.ReadInt64()
				Case GFFField.GFF_float
					gff_Field.value = Me.g_rdr.ReadSingle()
				Case GFFField.GFF_double
					gff_Field.value = Me.g_rdr.ReadDouble()
				Case GFFField.GFF_CExoString
					Dim num As Integer = Me.g_rdr.ReadInt32()
					Dim array As Byte() = New Byte(num - 1 + 1 - 1) {}
					Dim encoding As Encoding = Encoding.GetEncoding(1252)
					array = Me.g_rdr.ReadBytes(num)
					gff_Field.value = encoding.GetString(array)
				Case GFFField.GFF_CResRef
					gff_Field.value = Me.g_rdr.ReadString()
				Case GFFField.GFF_CExoLocString
					Dim gffexoLocString As GFFExoLocString = New GFFExoLocString()
					gffexoLocString.size = Me.g_rdr.ReadInt32()
					gffexoLocString.StringRef = Me.g_rdr.ReadInt32()
					gffexoLocString.StringCount = Me.g_rdr.ReadInt32()
					gffexoLocString.subStringArr = CType(Array.CreateInstance(GetType(Object), gffexoLocString.StringCount), Object())
					Me.g_tabLevel += 1
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\par", False)
						Me.PrintMsg("\cf4CExoLocString\cf0 - \cf2 Substring count:\cf0  " + StringType.FromInteger(gffexoLocString.StringCount) + vbLf + "\par", True)
					Else
						Me.PrintMsg(vbLf, False)
						Me.PrintMsg("CExoLocString - Substring count:" + StringType.FromInteger(gffexoLocString.StringCount) + vbLf, True)
					End If
					Me.g_tabLevel += 1
					If gffexoLocString.StringCount > 0 Then
						Dim num2 As Integer = 0
						Dim num3 As Integer = gffexoLocString.StringCount - 1
						i = num2
						While i <= num3
							Dim gffexoLocSubString As GFFExoLocSubString = New GFFExoLocSubString()
							gffexoLocSubString.StringID = Me.g_rdr.ReadInt32()
							gffexoLocSubString.StringLength = Me.g_rdr.ReadInt32()
							Dim array2 As Byte() = New Byte(gffexoLocSubString.StringLength - 1 + 1 - 1) {}
							Dim encoding2 As Encoding = Encoding.GetEncoding(1252)
							array2 = Me.g_rdr.ReadBytes(gffexoLocSubString.StringLength)
							gffexoLocSubString.value = encoding2.GetString(array2)
							gffexoLocString.subStringArr(i) = gffexoLocSubString
							If Me.g_bRTF_mode Then
								Me.PrintMsg(String.Concat(New String() { "\cf3Substring:\cf0  ", StringType.FromInteger(i), "  \cf2 ID:\cf0  ", StringType.FromInteger(gffexoLocSubString.StringID), " \cf2 Value:\cf0  ", gffexoLocSubString.value, vbLf, "\par" }), True)
							Else
								Me.PrintMsg(String.Concat(New String() { "Substring: ", StringType.FromInteger(i), " ID: ", StringType.FromInteger(gffexoLocSubString.StringID), "  Value: ", gffexoLocSubString.value }), True)
							End If
							i += 1
						End While
					End If
					Me.g_tabLevel -= 1
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\cf4End of CExoLocString\cf0 - ", True)
					Else
						Me.PrintMsg(" End of CExoLocString - ", True)
					End If
					Me.g_tabLevel -= 1
					gff_Field.value = gffexoLocString
				Case GFFField.GFF_Void
					Dim gffvoid As GFFVoid = New GFFVoid()
					gffvoid.size = Me.g_rdr.ReadInt32()
					gffvoid.bytes = Me.g_rdr.ReadBytes(gffvoid.size)
					gff_Field.value = gffvoid
				Case GFFField.GFF_Struct
					If LateBinding.LateIndexGet(Me.g_structArr, New Object() { RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset) }, Nothing) Is Nothing Then
						Me.g_ms.Seek(LongType.FromObject(ObjectType.AddObj(Me.g_StructOffset, ObjectType.MulObj(fieldEntry.DataOrDataOffset, 12))), SeekOrigin.Begin)
						Dim gffstructEntry As GFFStructEntry = New GFFStructEntry()
						gffstructEntry.Type = CType(Me.g_rdr.ReadInt32(), GFFField)
						gffstructEntry.DataOrDataOffset = Me.g_rdr.ReadInt32()
						gffstructEntry.FieldCount = Me.g_rdr.ReadInt32()
						LateBinding.LateIndexSet(Me.g_structArr, New Object() { RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset), Me.GFFReadStruct(gffstructEntry) }, Nothing)
					End If
					gff_Field.value = RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset)
				Case GFFField.GFF_List
					Me.g_ms.Seek(LongType.FromObject(ObjectType.AddObj(Me.g_ListIndicesOffset, fieldEntry.DataOrDataOffset)), SeekOrigin.Begin)
					Dim gfflist As GFFList = New GFFList(Me.g_rdr.ReadInt32())
					If Me.g_bRTF_mode Then
						Me.PrintMsg(vbLf & "\par", False)
						Me.PrintMsg("\cf4List Contents\cf0 - \cf2 Struct Count:\cf0  " + StringType.FromInteger(gfflist.structIndices.Count) + vbLf + "\par", True)
					Else
						Me.PrintMsg("List Contents - Struct Count: " + StringType.FromInteger(gfflist.structIndices.Count) + vbLf, True)
					End If
					Me.g_tabLevel += 1
					If gfflist.structIndices.Count > 0 Then
						Dim num4 As Integer = 0
						Dim num5 As Integer = gfflist.structIndices.Count - 1
						For j As Integer = num4 To num5
							gfflist.structIndices(j) = Me.g_rdr.ReadInt32()
						Next
						Dim num6 As Integer = 0
						Dim num7 As Integer = gfflist.structIndices.Count - 1
						For j As Integer = num6 To num7
							If LateBinding.LateIndexGet(Me.g_structArr, New Object() { RuntimeHelpers.GetObjectValue(gfflist.structIndices(j)) }, Nothing) Is Nothing Then
								Me.g_ms.Seek(0L, SeekOrigin.Begin)
								Me.g_ms.Seek(LongType.FromObject(ObjectType.AddObj(Me.g_StructOffset, ObjectType.MulObj(gfflist.structIndices(j), 12))), SeekOrigin.Begin)
								Dim gffstructEntry2 As GFFStructEntry = New GFFStructEntry()
								gffstructEntry2.Type = CType(Me.g_rdr.ReadInt32(), GFFField)
								gffstructEntry2.DataOrDataOffset = Me.g_rdr.ReadInt32()
								gffstructEntry2.FieldCount = Me.g_rdr.ReadInt32()
								LateBinding.LateIndexSet(Me.g_structArr, New Object() { RuntimeHelpers.GetObjectValue(gfflist.structIndices(j)), Me.GFFReadStruct(gffstructEntry2) }, Nothing)
							End If
						Next
					End If
					Me.g_tabLevel -= 1
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\cf4End of List Contents\cf0 - ", True)
					Else
						Me.PrintMsg("End of List Contents - ", True)
					End If
					gff_Field.value = gfflist
					Me.g_gff_ListArr.Add(gfflist)
				Case GFFField.GFF_Type16
					Dim gfftype As GFFType16 = New GFFType16()
					gfftype.f1 = Me.g_rdr.ReadSingle()
					gfftype.f2 = Me.g_rdr.ReadSingle()
					gfftype.f3 = Me.g_rdr.ReadSingle()
					gfftype.f4 = Me.g_rdr.ReadSingle()
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\cf4 GFF Type16\cf0 - " & vbLf & "\par", True)
					Else
						Me.PrintMsg(" GFF Type16 - " & vbLf, True)
					End If
					Me.g_tabLevel += 1
					Me.PrintMsg(String.Concat(New String() { "f1: ", StringType.FromSingle(gfftype.f1), "  f2: ", StringType.FromSingle(gfftype.f2), "  f3: ", StringType.FromSingle(gfftype.f3), "  f4: ", StringType.FromSingle(gfftype.f4) }), True)
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\par", True)
					Else
						Me.PrintMsg(vbLf, True)
					End If
					Me.g_tabLevel -= 1
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\cf4 End of GFF Type16\cf0 - ", True)
					Else
						Me.PrintMsg(" End of GFF Type16 - ", True)
					End If
					gff_Field.value = gfftype
				Case GFFField.GFF_Type17
					Dim gfftype2 As GFFType17 = New GFFType17()
					gfftype2.f1 = Me.g_rdr.ReadSingle()
					gfftype2.f2 = Me.g_rdr.ReadSingle()
					gfftype2.f3 = Me.g_rdr.ReadSingle()
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\cf4 GFF Type17\cf0 - " & vbLf & "\par", True)
					Else
						Me.PrintMsg(" GFF Type17 - " & vbLf, True)
					End If
					Me.g_tabLevel += 1
					Me.PrintMsg(String.Concat(New String() { "f1: ", StringType.FromSingle(gfftype2.f1), "  f2: ", StringType.FromSingle(gfftype2.f2), "  f3: ", StringType.FromSingle(gfftype2.f3) }), True)
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\par", True)
					Else
						Me.PrintMsg(vbLf, True)
					End If
					Me.g_tabLevel -= 1
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\cf4 End of GFF Type17\cf0 - ", True)
					Else
						Me.PrintMsg(" End of GFF Type17 - ", True)
					End If
					gff_Field.value = gfftype2
				Case Else
					Console.WriteLine("Unknown Field type during read: " + StringType.FromInteger(CInt(fieldEntry.Type)))
			End Select
			If Me.g_bRTF_mode Then
				Me.PrintMsg("\cf3Field\cf0 - \cf2 Type:\cf0  " + Me.getFieldTypeStr(CInt(fieldEntry.Type)).PadRight(14), True)
			Else
				Me.PrintMsg("Field -  Type:  " + Me.getFieldTypeStr(CInt(fieldEntry.Type)).PadRight(14), True)
			End If
			Me.PrintViewableFieldValue(gff_Field)
			Return gff_Field
		End Function

		' Token: 0x0600007A RID: 122 RVA: 0x0021DFC4 File Offset: 0x0021CFC4
		Private Sub PrintViewableFieldValue(field As GFF_Field)
			Select Case field.Type
				Case GFFField.GFF_byte, GFFField.GFF_word, GFFField.GFF_short, GFFField.GFF_dword, GFFField.GFF_int, GFFField.GFF_dword64, GFFField.GFF_int64, GFFField.GFF_float, GFFField.GFF_double, GFFField.GFF_CExoString, GFFField.GFF_CResRef
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\cf2 Value:\cf0  ", False)
					Else
						Me.PrintMsg("Value:  ", False)
					End If
					If field.value IsNot Nothing Then
						If Me.g_bRTF_mode Then
							Me.PrintMsg(field.value.ToString() + vbLf + "\par", False)
						Else
							Me.PrintMsg(field.value.ToString() + vbLf, False)
						End If
					ElseIf Me.g_bRTF_mode Then
						Me.PrintMsg("(Nothing)" & vbLf & "\par", False)
					Else
						Me.PrintMsg("(Nothing)" & vbLf, False)
					End If
				Case GFFField.GFF_char
					Dim c As Char = CharType.FromObject(field.value)
					Dim text As String
					If Me.g_bRTF_mode Then
						text += "\cf2Value:\cf0  "
					Else
						text += "Value:  "
					End If
					If Char.IsLetterOrDigit(c) Then
						text += c.ToString()
					Else
						text = text + "chr(" + StringType.FromInteger(Strings.Asc(c)) + ")"
					End If
					text += vbLf
					Me.PrintMsg(text, False)
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\par", False)
					End If
				Case GFFField.GFF_CExoLocString
					Dim text2 As String
					If CType(field.value, GFFExoLocString).StringRef <> -1 Then
						If Me.dialogTlk IsNot Nothing Then
							text2 = Me.dialogTlk.GetString(CType(field.value, GFFExoLocString).StringRef)
						Else
							text2 = "No DialogTlk"
						End If
					End If
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\cf2Value:\cf0  " + text2 + vbLf + "\par", False)
					Else
						Me.PrintMsg("Value:  " + text2 + vbLf, False)
					End If
				Case GFFField.GFF_Void
					Me.PrintMsg(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("(Data: Size = ", LateBinding.LateGet(LateBinding.LateGet(field.value, Nothing, "bytes", New Object(-1) {}, Nothing, Nothing), Nothing, "length", New Object(-1) {}, Nothing, Nothing)), ")"), vbLf)), False)
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\par", False)
					End If
				Case Else
					Me.PrintMsg("(Complex)" & vbLf, False)
					If Me.g_bRTF_mode Then
						Me.PrintMsg("\par", False)
					End If
			End Select
		End Sub

		' Token: 0x0600007B RID: 123 RVA: 0x0021E260 File Offset: 0x0021D260
		Public Function findNode(aNode As GFF_Struct) As Object
			' The following expression was wrapped in a checked-statement
			If aNode.fields IsNot Nothing Then
				For Each gff_Field As GFF_Field In aNode.fields
					If StringType.StrCmp(gff_Field.label, Me.NodeSearchPath(Me.NodeSearchLevel), False) = 0 Then
						If Me.NodeSearchLevel = Me.NodeSearchPath.Length - 1 Then
							Return gff_Field
						End If
						Me.NodeSearchLevel += 1
						If gff_Field.Type = GFFField.GFF_Struct Then
							Return Me.findNode(CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { RuntimeHelpers.GetObjectValue(gff_Field.value) }, Nothing), GFF_Struct))
						End If
						If gff_Field.Type = GFFField.GFF_List Then
							If Me.NodeSearchLevel = Me.NodeSearchPath.Length - 1 Then
								Return gff_Field
							End If
							Return Me.findNode(Me.findListElement(CType(gff_Field.value, GFFList)))
						End If
					End If
				Next
			End If
			Return Nothing
		End Function

		' Token: 0x0600007C RID: 124 RVA: 0x0021E350 File Offset: 0x0021D350
		Public Function findListElement(List As GFFList) As GFF_Struct
			Dim gff_Struct As GFF_Struct = CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { RuntimeHelpers.GetObjectValue(List.structIndices(IntegerType.FromString(Me.NodeSearchPath(Me.NodeSearchLevel)))) }, Nothing), GFF_Struct)
			Me.NodeSearchLevel += 1
			Return gff_Struct
		End Function

		' Token: 0x0600007D RID: 125 RVA: 0x0021E3AC File Offset: 0x0021D3AC
		Public Function GetNodeValue(Path As String) As Object
			Path = Strings.Replace(Path, "(", ".", 1, -1, CompareMethod.Binary)
			Path = Strings.Replace(Path, ")", "", 1, -1, CompareMethod.Binary)
			Me.NodeSearchPath = Strings.Split(Path, ".", -1, CompareMethod.Binary)
			Me.NodeSearchLevel = 0
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.findNode(Me.root_GFFStruct))
			If objectValue Is Nothing Then
				Return objectValue
			End If
			Return CType(objectValue, GFF_Field).value
		End Function

		' Token: 0x0600007E RID: 126 RVA: 0x0021E420 File Offset: 0x0021D420
		Public Sub SetNodeValue(Path As String, value As Object)
			If Not Me.VerifyNodeExists(Path) Then
				Return
			End If
			Path = Strings.Replace(Path, "(", ".", 1, -1, CompareMethod.Binary)
			Path = Strings.Replace(Path, ")", "", 1, -1, CompareMethod.Binary)
			Me.NodeSearchPath = Strings.Split(Path, ".", -1, CompareMethod.Binary)
			Me.NodeSearchLevel = 0
			Dim gff_Field As GFF_Field = CType(Me.findNode(Me.root_GFFStruct), GFF_Field)
			If gff_Field.Type <> GFFField.GFF_List Then
				gff_Field.value = RuntimeHelpers.GetObjectValue(value)
			Else
				' The following expression was wrapped in a checked-expression
				CType(gff_Field.value, GFFList).structIndices(IntegerType.FromString(Me.NodeSearchPath(Me.NodeSearchPath.Length - 1))) = RuntimeHelpers.GetObjectValue(value)
			End If
		End Sub

		' Token: 0x0600007F RID: 127 RVA: 0x0021E4DC File Offset: 0x0021D4DC
		Public Function GetListNode(Path As String) As GFFList
			Path = Strings.Replace(Path, "(", ".", 1, -1, CompareMethod.Binary)
			Path = Strings.Replace(Path, ")", "", 1, -1, CompareMethod.Binary)
			Me.NodeSearchPath = Strings.Split(Path, ".", -1, CompareMethod.Binary)
			Me.NodeSearchLevel = 0
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.findNode(Me.root_GFFStruct))
			If objectValue Is Nothing Then
				Return New GFFList(0)
			End If
			Return CType(CType(objectValue, GFF_Field).value, GFFList)
		End Function

		' Token: 0x06000080 RID: 128 RVA: 0x0021E55C File Offset: 0x0021D55C
		Public Function VerifyNodeExists(Path As String) As Boolean
			Path = Strings.Replace(Path, "(", ".", 1, -1, CompareMethod.Binary)
			Path = Strings.Replace(Path, ")", "", 1, -1, CompareMethod.Binary)
			Me.NodeSearchPath = Strings.Split(Path, ".", -1, CompareMethod.Binary)
			Me.NodeSearchLevel = 0
			Return RuntimeHelpers.GetObjectValue(Me.findNode(Me.root_GFFStruct)) IsNot Nothing
		End Function

		' Token: 0x06000081 RID: 129 RVA: 0x0021E5C8 File Offset: 0x0021D5C8
		Public Sub AddListElement(PathToList As String, struct As GFF_Struct)
			Dim structIndices As ArrayList = Me.GetListNode(PathToList).structIndices
			Dim num As Integer = 0
			Dim num2 As Integer = Me.g_structArr.Length - 1
			Dim num3 As Integer = num
			While num3 <= num2 AndAlso LateBinding.LateIndexGet(Me.g_structArr, New Object() { num3 }, Nothing) IsNot Nothing
				num3 += 1
			End While
			If num3 < Me.g_structArr.Length Then
				structIndices.Add(num3)
				LateBinding.LateIndexSet(Me.g_structArr, New Object() { num3, struct }, Nothing)
			Else
				Dim array As Array = Array.CreateInstance(GetType(GFF_Struct), Me.g_structArr.Length + 1)
				Array.Copy(Me.g_structArr, array, Me.g_structArr.Length)
				Me.g_structArr = array
				structIndices.Add(Me.g_structArr.Length - 1)
				LateBinding.LateIndexSet(Me.g_structArr, New Object() { Me.g_structArr.Length - 1, struct }, Nothing)
			End If
		End Sub

		' Token: 0x06000082 RID: 130 RVA: 0x0021E6E0 File Offset: 0x0021D6E0
		Public Sub DeleteListElement(PathToList As String, index As Integer)
			Dim structIndices As ArrayList = Me.GetListNode(PathToList).structIndices
			Dim num As Integer = IntegerType.FromObject(structIndices(index))
			Me.GetListNode(PathToList).structIndices.RemoveAt(index)
			LateBinding.LateIndexSet(Me.g_structArr, New Object() { num, Nothing }, Nothing)
			Me.FixGffListRefs(-1)
		End Sub

		' Token: 0x06000083 RID: 131 RVA: 0x0021E744 File Offset: 0x0021D744
		Public Sub ClearListElements(PathToList As String)
			Dim listNode As GFFList = Me.GetListNode(PathToList)
			Dim structIndices As ArrayList = listNode.structIndices
			If structIndices.Count = 0 Then
				Return
			End If
			For i As Integer = structIndices.Count - 1 To 0 Step -1
				Dim num As Integer = IntegerType.FromObject(structIndices(i))
				structIndices.RemoveAt(i)
				Me.ScanStructForLists(CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { num }, Nothing), GFF_Struct))
				LateBinding.LateIndexSet(Me.g_structArr, New Object() { num, Nothing }, Nothing)
				Me.FixGffListRefs(-1)
			Next
			listNode.size = 0
		End Sub

		' Token: 0x06000084 RID: 132 RVA: 0x0021E7F0 File Offset: 0x0021D7F0
		Public Sub ClearListElements(List As GFFList)
			Dim structIndices As ArrayList = List.structIndices
			If structIndices.Count = 0 Then
				Return
			End If
			For i As Integer = structIndices.Count - 1 To 0 Step -1
				Dim num As Integer = IntegerType.FromObject(structIndices(i))
				structIndices.RemoveAt(i)
				LateBinding.LateIndexSet(Me.g_structArr, New Object() { num, Nothing }, Nothing)
				Me.FixGffListRefs(-1)
			Next
			List.size = 0
		End Sub

		' Token: 0x06000085 RID: 133 RVA: 0x0021E864 File Offset: 0x0021D864
		Public Sub FixGffListRefs(Optional removedStructIndex As Integer = -1)
			' The following expression was wrapped in a checked-statement
			Dim i As Integer
			If removedStructIndex = -1 Then
				Dim num As Integer = 0
				Dim num2 As Integer = Me.g_structArr.Length - 1
				i = num
				While i <= num2
					If LateBinding.LateIndexGet(Me.g_structArr, New Object() { i }, Nothing) Is Nothing Then
						Exit While
					End If
					i += 1
				End While
			Else
				i = removedStructIndex
			End If
			If i = Me.g_structArr.Length Then
				Return
			End If
			Try
				For Each obj As Object In Me.g_gff_ListArr
					Dim gfflist As GFFList = CType(obj, GFFList)
					If gfflist IsNot Nothing Then
						For j As Integer = gfflist.structIndices.Count - 1 To 0 Step -1
							If ObjectType.ObjTst(gfflist.structIndices(j), i, False) > 0 Then
								Dim structIndices As ArrayList = gfflist.structIndices
								Dim arrayList As ArrayList = structIndices
								Dim num3 As Integer = j
								arrayList(num3) = ObjectType.SubObj(structIndices(num3), 1)
							End If
						Next
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.CleanupStructArrayAfterDelete()
			Dim num4 As Integer = 0
			Dim num5 As Integer = Me.g_structArr.Length - 1
			For j As Integer = num4 To num5
				For Each gff_Field As GFF_Field In CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { j }, Nothing), GFF_Struct).fields
					If gff_Field.Type = GFFField.GFF_Struct AndAlso ObjectType.ObjTst(gff_Field.value, i, False) > 0 Then
						Dim gff_Field2 As GFF_Field = gff_Field
						gff_Field2.value = ObjectType.SubObj(gff_Field2.value, 1)
					End If
				Next
			Next
		End Sub

		' Token: 0x06000086 RID: 134 RVA: 0x0021EA1C File Offset: 0x0021DA1C
		Private Sub CleanupStructArrayAfterDelete()
			Dim flag As Boolean = False
			Dim num As Integer = 0
			Dim num2 As Integer = Me.g_structArr.Length - 2
			For i As Integer = num To num2
				If LateBinding.LateIndexGet(Me.g_structArr, New Object() { i }, Nothing) Is Nothing OrElse flag Then
					LateBinding.LateIndexSet(Me.g_structArr, New Object() { i, RuntimeHelpers.GetObjectValue(LateBinding.LateIndexGet(Me.g_structArr, New Object() { i + 1 }, Nothing)) }, Nothing)
					flag = True
				End If
			Next
			Dim array As Array = Array.CreateInstance(GetType(GFF_Struct), Me.g_structArr.Length - 1)
			Array.Copy(Me.g_structArr, array, Me.g_structArr.Length - 1)
			Me.g_structArr = array
		End Sub

		' Token: 0x06000087 RID: 135 RVA: 0x0021EAF4 File Offset: 0x0021DAF4
		Private Sub ScanStructForLists(struct As GFF_Struct)
			' The following expression was wrapped in a checked-statement
			For Each gff_Field As GFF_Field In struct.fields
				If gff_Field.Type = GFFField.GFF_Struct Then
					Me.ScanStructForLists(CType(gff_Field.value, GFF_Struct))
				ElseIf gff_Field.Type = GFFField.GFF_List Then
					Dim num As Integer = 0
					Dim num2 As Integer = CType(gff_Field.value, GFFList).structIndices.Count - 1
					For j As Integer = num To num2
						Me.ScanStructForLists(CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { RuntimeHelpers.GetObjectValue(CType(gff_Field.value, GFFList).structIndices(j)) }, Nothing), GFF_Struct))
					Next
					Me.ClearListElements(CType(gff_Field.value, GFFList))
				End If
			Next
		End Sub

		' Token: 0x06000088 RID: 136 RVA: 0x0021EBC4 File Offset: 0x0021DBC4
		Public Function GetListItemCount(Path As String) As Integer
			Path = Strings.Replace(Path, "(", ".", 1, -1, CompareMethod.Binary)
			Path = Strings.Replace(Path, ")", "", 1, -1, CompareMethod.Binary)
			Dim listNode As Object = Me.GetListNode(Path)
			If listNode Is Nothing Then
				Return -1
			End If
			Return CType(listNode, GFFList).structIndices.Count
		End Function

		' Token: 0x06000089 RID: 137 RVA: 0x0021EC18 File Offset: 0x0021DC18
		Public Function GetStructFieldCount(Path As String) As Integer
			Path = Strings.Replace(Path, "(", ".", 1, -1, CompareMethod.Binary)
			Path = Strings.Replace(Path, ")", "", 1, -1, CompareMethod.Binary)
			Me.NodeSearchPath = Strings.Split(Path, ".", -1, CompareMethod.Binary)
			Me.NodeSearchLevel = 0
			Return IntegerType.FromObject(LateBinding.LateGet(LateBinding.LateIndexGet(Me.g_structArr, New Object() { RuntimeHelpers.GetObjectValue(Me.findNode(Me.root_GFFStruct)) }, Nothing), Nothing, "fieldCount", New Object(-1) {}, Nothing, Nothing))
		End Function

		' Token: 0x0600008A RID: 138 RVA: 0x0021ECAC File Offset: 0x0021DCAC
		Public Function GetStructFieldType(Path As String) As Integer
			Path = Strings.Replace(Path, "(", ".", 1, -1, CompareMethod.Binary)
			Path = Strings.Replace(Path, ")", "", 1, -1, CompareMethod.Binary)
			Me.NodeSearchPath = Strings.Split(Path, ".", -1, CompareMethod.Binary)
			Me.NodeSearchLevel = 0
			Return Me.findListElement(Me.GetListNode(Path)).type
		End Function

		' Token: 0x0600008B RID: 139 RVA: 0x0021ED10 File Offset: 0x0021DD10
		Public Function GetStruct(Path As String) As GFF_Struct
			Path = Strings.Replace(Path, "(", ".", 1, -1, CompareMethod.Binary)
			Path = Strings.Replace(Path, ")", "", 1, -1, CompareMethod.Binary)
			Me.NodeSearchPath = Strings.Split(Path, ".", -1, CompareMethod.Binary)
			Me.NodeSearchLevel = 0
			Return Me.findListElement(Me.GetListNode(Path))
		End Function

		' Token: 0x0600008C RID: 140 RVA: 0x0021ED70 File Offset: 0x0021DD70
		Public Sub AddFieldToStruct(Path As String, Label As String, Type As Integer, Value As Object)
			Dim struct As GFF_Struct
			If StringType.StrCmp(Path, "", False) = 0 Then
				struct = Me.root_GFFStruct
			Else
				struct = Me.GetStruct(Path)
			End If
			struct.fields = CType(Utils.CopyArray(CType(struct.fields, Array), New GFF_Field(struct.fieldCount + 1 - 1) {}), GFF_Field())
			Dim gff_Struct As GFF_Struct = struct
			gff_Struct.fieldCount += 1
			Dim gff_Field As GFF_Field = New GFF_Field()
			gff_Field.label = Label
			gff_Field.Type = CType(Type, GFFField)
			gff_Field.value = RuntimeHelpers.GetObjectValue(Value)
			struct.fields(struct.fieldCount - 1) = gff_Field
		End Sub

		' Token: 0x0600008D RID: 141 RVA: 0x0021EE08 File Offset: 0x0021DE08
		Public Sub AddKTInfoToGFF()
			If Not Me.VerifyNodeExists("KTInfoVersion") Then
				Me.AddKTCESFieldToRootGFFStruct("KTInfoVersion", Application.ProductVersion)
			Else
				Me.SetNodeValue("KTInfoVersion", Application.ProductVersion)
			End If
			If Not Me.VerifyNodeExists("KTInfoDate") Then
				Me.AddKTCESFieldToRootGFFStruct("KTInfoDate", DateAndTime.Now.ToLongDateString() + " " + DateAndTime.Now.ToLongTimeString())
			Else
				Me.SetNodeValue("KTInfoDate", DateAndTime.Now.ToLongDateString() + " " + DateAndTime.Now.ToLongTimeString())
			End If
			If Not Me.VerifyNodeExists("KTGameVerIndex") Then
				Me.AddKTIntegerFieldToRootGFFStruct("KTGameVerIndex", Me.KotorVersionIndex)
			Else
				Me.SetNodeValue("KTGameVerIndex", Me.KotorVersionIndex)
			End If
		End Sub

		' Token: 0x0600008E RID: 142 RVA: 0x0021EEE8 File Offset: 0x0021DEE8
		Public Sub AddKTCESFieldToRootGFFStruct(label As String, value As String)
			' The following expression was wrapped in a checked-statement
			Me.root_GFFStruct.fields = CType(Utils.CopyArray(CType(Me.root_GFFStruct.fields, Array), New GFF_Field(Me.root_GFFStruct.fieldCount + 1 - 1) {}), GFF_Field())
			Dim gff_Struct As GFF_Struct = Me.root_GFFStruct
			gff_Struct.fieldCount += 1
			Dim gff_Field As GFF_Field = New GFF_Field()
			gff_Field.label = label
			gff_Field.Type = GFFField.GFF_CExoString
			gff_Field.value = value
			Me.root_GFFStruct.fields(Me.root_GFFStruct.fieldCount - 1) = gff_Field
		End Sub

		' Token: 0x0600008F RID: 143 RVA: 0x0021EF78 File Offset: 0x0021DF78
		Public Sub AddKTIntegerFieldToRootGFFStruct(label As String, value As Integer)
			' The following expression was wrapped in a checked-statement
			Me.root_GFFStruct.fields = CType(Utils.CopyArray(CType(Me.root_GFFStruct.fields, Array), New GFF_Field(Me.root_GFFStruct.fieldCount + 1 - 1) {}), GFF_Field())
			Dim gff_Struct As GFF_Struct = Me.root_GFFStruct
			gff_Struct.fieldCount += 1
			Dim gff_Field As GFF_Field = New GFF_Field()
			gff_Field.label = label
			gff_Field.Type = GFFField.GFF_int
			gff_Field.value = value
			Me.root_GFFStruct.fields(Me.root_GFFStruct.fieldCount - 1) = gff_Field
		End Sub

		' Token: 0x06000090 RID: 144 RVA: 0x0021F00C File Offset: 0x0021E00C
		Public Sub AddSimpleField(label As String, FieldType As GFFField, value As Object)
			' The following expression was wrapped in a checked-statement
			Me.root_GFFStruct.fields = CType(Utils.CopyArray(CType(Me.root_GFFStruct.fields, Array), New GFF_Field(Me.root_GFFStruct.fieldCount + 1 - 1) {}), GFF_Field())
			Dim gff_Struct As GFF_Struct = Me.root_GFFStruct
			gff_Struct.fieldCount += 1
			Dim gff_Field As GFF_Field = New GFF_Field()
			gff_Field.label = label
			gff_Field.Type = FieldType
			gff_Field.value = RuntimeHelpers.GetObjectValue(value)
			Me.root_GFFStruct.fields(Me.root_GFFStruct.fieldCount - 1) = gff_Field
		End Sub

		' Token: 0x06000091 RID: 145 RVA: 0x0021F0A0 File Offset: 0x0021E0A0
		Public Sub CreateList(path As String, Label As String)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim gfflist As GFFList
			If StringType.StrCmp(path, "", False) = 0 Then
				num = 0
			Else
				path = Strings.Replace(path, "(", ".", 1, -1, CompareMethod.Binary)
				path = Strings.Replace(path, ")", "", 1, -1, CompareMethod.Binary)
				Dim array As String() = Strings.Split(path, ".", -1, CompareMethod.Binary)
				Me.NodeSearchPath = Strings.Split(path, ".", -1, CompareMethod.Binary)
				Me.NodeSearchPath = CType(Utils.CopyArray(CType(Me.NodeSearchPath, Array), New String(array.Length - 2 + 1 - 1) {}), String())
				Me.NodeSearchLevel = 0
				gfflist = CType(CType(Me.findNode(Me.root_GFFStruct), GFF_Field).value, GFFList)
				num = IntegerType.FromObject(gfflist.structIndices(IntegerType.FromString(array(array.Length - 1))))
			End If
			Dim gff_Struct As GFF_Struct = CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { num }, Nothing), GFF_Struct)
			gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fields.Length + 1 - 1) {}), GFF_Field())
			Dim gff_Struct2 As GFF_Struct = gff_Struct
			gff_Struct2.fieldCount += 1
			gfflist = New GFFList(0)
			gff_Struct.fields(gff_Struct.fields.Length - 1) = New GFF_Field(GFFField.GFF_List, Label, gfflist)
			Me.g_gff_ListArr.Add(gfflist)
		End Sub

		' Token: 0x06000092 RID: 146 RVA: 0x0021F21C File Offset: 0x0021E21C
		Public Sub AddKTNode()
			Dim gff_Field As GFF_Field = New GFF_Field(GFFField.GFF_CResRef, "KTInfoMaj", Application.ProductVersion)
			Dim array As GFF_Field() = CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { 0 }, Nothing), GFF_Struct).fields
			array = CType(Utils.CopyArray(CType(array, Array), New GFF_Field(array.Length + 1 - 1) {}), GFF_Field())
			array(array.Length - 1) = gff_Field
			CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { 0 }, Nothing), GFF_Struct).fields = array
		End Sub

		' Token: 0x06000093 RID: 147 RVA: 0x0021F2B4 File Offset: 0x0021E2B4
		Public Sub CreateEnglishCExoLocSubStringEntry(path As String, Value As String)
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(path), GFFExoLocString)
			gffexoLocString.StringCount = 1
			gffexoLocString.StringRef = -1
			gffexoLocString.subStringArr = CType(Array.CreateInstance(GetType(Object), 1), Object())
			Dim gffexoLocSubString As GFFExoLocSubString = New GFFExoLocSubString()
			gffexoLocSubString.StringID = 0
			gffexoLocSubString.StringLength = Value.Length
			gffexoLocSubString.value = Value
			gffexoLocString.subStringArr(0) = gffexoLocSubString
			gffexoLocString.size = 16 + Value.Length
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x0021F330 File Offset: 0x0021E330
		Public Sub SetEnglishCExoLocSubStringEntry(path As String, Value As String)
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(path), GFFExoLocString)
			Dim gffexoLocSubString As GFFExoLocSubString = New GFFExoLocSubString()
			gffexoLocSubString.StringID = 0
			gffexoLocSubString.StringLength = Value.Length
			gffexoLocSubString.value = Value
			gffexoLocString.subStringArr(0) = gffexoLocSubString
			gffexoLocString.size = 16 + Value.Length
		End Sub

		' Token: 0x06000095 RID: 149 RVA: 0x0021F384 File Offset: 0x0021E384
		Public Sub CreateCExoLocSubStringEntry(path As String, Value As String, Optional LanguageID As Integer = 0)
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(path), GFFExoLocString)
			gffexoLocString.StringCount = 1
			gffexoLocString.StringRef = -1
			gffexoLocString.subStringArr = CType(Array.CreateInstance(GetType(Object), 1), Object())
			Dim gffexoLocSubString As GFFExoLocSubString = New GFFExoLocSubString()
			gffexoLocSubString.StringID = LanguageID
			gffexoLocSubString.StringLength = Value.Length
			gffexoLocSubString.value = Value
			gffexoLocString.subStringArr(0) = gffexoLocSubString
			gffexoLocString.size = 16 + Value.Length
		End Sub

		' Token: 0x06000096 RID: 150 RVA: 0x0021F400 File Offset: 0x0021E400
		Public Sub SetCExoLocSubStringEntry(path As String, Value As String, Optional LanguageID As Integer = 0)
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(path), GFFExoLocString)
			Dim gffexoLocSubString As GFFExoLocSubString = New GFFExoLocSubString()
			gffexoLocSubString.StringID = LanguageID
			gffexoLocSubString.StringLength = Value.Length
			gffexoLocSubString.value = Value
			gffexoLocString.subStringArr(0) = gffexoLocSubString
			gffexoLocString.size = 16 + Value.Length
		End Sub

		' Token: 0x06000097 RID: 151 RVA: 0x0021F454 File Offset: 0x0021E454
		Public Sub CreateRootStruct()
			Me.g_structArr = Array.CreateInstance(GetType(Object), 1)
			Me.root_GFFStruct.fields = CType(Array.CreateInstance(GetType(GFF_Field), 0), GFF_Field())
			LateBinding.LateIndexSet(Me.g_structArr, New Object() { 0, Me.root_GFFStruct }, Nothing)
		End Sub

		' Token: 0x06000098 RID: 152 RVA: 0x0021F4C0 File Offset: 0x0021E4C0
		Public Sub WriteFile(path As String, filetype As String)
			Dim fileStream As FileStream = New FileStream(path, FileMode.Create)
			Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream)
			Dim hashtable As Hashtable = New Hashtable()
			Dim num As Integer = 0
			Me.AddKTInfoToGFF()
			Dim num2 As Integer = Me.g_structArr.Length * 12
			binaryWriter.Write((Strings.UCase(Strings.Trim(filetype)) + " V3.2").ToCharArray())
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = Me.g_structArr.Length - 1
			For i As Integer = num5 To num6
				For Each gff_Field As GFF_Field In CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { i }, Nothing), GFF_Struct).fields
					num3 += 1
					If hashtable.ContainsKey(gff_Field.label) Then
						gff_Field.labelIndex = IntegerType.FromObject(hashtable(gff_Field.label))
					Else
						hashtable.Add(gff_Field.label, num4)
						gff_Field.labelIndex = num4
						num4 += 1
					End If
				Next
			Next
			Dim num7 As Integer = num3 * 12
			Dim num8 As Integer = hashtable.Count * 16
			Dim num9 As Integer = 0
			Dim num10 As Integer = 0
			Dim num11 As Integer = Me.g_structArr.Length - 1
			Dim num13 As Integer
			For i As Integer = num10 To num11
				For Each gff_Field As GFF_Field In CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { i }, Nothing), GFF_Struct).fields
					If gff_Field.Type >= GFFField.GFF_dword64 Then
						Dim num12 As Integer
						num12 += 1
						Select Case gff_Field.Type
							Case GFFField.GFF_dword64, GFFField.GFF_int64, GFFField.GFF_double
								num9 += 8
							Case GFFField.GFF_float
								num9 += 4
							Case GFFField.GFF_CExoString
								num9 += 4 + StringType.FromObject(gff_Field.value).Length
							Case GFFField.GFF_CResRef
								num9 += 1 + StringType.FromObject(gff_Field.value).Length
							Case GFFField.GFF_CExoLocString
								num9 += CType(gff_Field.value, GFFExoLocString).size + 4
							Case GFFField.GFF_Void
								num9 += 4 + CType(gff_Field.value, GFFVoid).size
							Case GFFField.GFF_Struct
							Case GFFField.GFF_List
								num13 += CType(gff_Field.value, GFFList).structIndices.Count * 4 + 4
							Case GFFField.GFF_Type16
								num9 += 16
							Case GFFField.GFF_Type17
								num9 += 12
							Case Else
								Console.WriteLine("Unknown Field type: " + StringType.FromInteger(CInt(gff_Field.Type)))
						End Select
					End If
				Next
			Next
			Dim num14 As Integer = 0
			Dim num15 As Integer = Me.g_structArr.Length - 1
			Dim num16 As Integer
			For i As Integer = num14 To num15
				If CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { i }, Nothing), GFF_Struct).fieldCount > 1 Then
					num16 += CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { i }, Nothing), GFF_Struct).fieldCount
				End If
			Next
			Dim num17 As Integer = 56
			Dim num18 As Integer = 56 + num2
			Dim num19 As Integer = num18
			Dim num20 As Integer = num18 + num7
			Dim num21 As Integer = num20
			Dim num22 As Integer = num20 + num8
			Dim num23 As Integer = num22
			Dim num24 As Integer = num22 + num9
			Dim num25 As Integer = num24
			Dim num26 As Integer = num24 + num16 * 4
			Dim num27 As Integer = num26
			binaryWriter.Seek(8, SeekOrigin.Begin)
			binaryWriter.Write(56)
			binaryWriter.Write(Me.g_structArr.Length)
			binaryWriter.Write(num18)
			binaryWriter.Write(CInt(Math.Round(CDbl(num7) / 12.0)))
			binaryWriter.Write(num20)
			binaryWriter.Write(CInt(Math.Round(CDbl(num8) / 16.0)))
			binaryWriter.Write(num22)
			binaryWriter.Write(num9)
			binaryWriter.Write(num24)
			binaryWriter.Write(num16 * 4)
			binaryWriter.Write(num26)
			binaryWriter.Write(num13)
			Dim num28 As Integer = 0
			Dim num29 As Integer = Me.g_structArr.Length - 1
			For i As Integer = num28 To num29
				Dim gff_Struct As GFF_Struct = CType(LateBinding.LateIndexGet(Me.g_structArr, New Object() { i }, Nothing), GFF_Struct)
				If gff_Struct.fieldCount = 1 Then
					gff_Struct.DataOrDataOffset = num
				Else
					gff_Struct.DataOrDataOffset = num25 - num24
				End If
				binaryWriter.Seek(num17, SeekOrigin.Begin)
				binaryWriter.Write(gff_Struct.type)
				binaryWriter.Write(gff_Struct.DataOrDataOffset)
				binaryWriter.Write(gff_Struct.fieldCount)
				num17 = CInt(fileStream.Position)
				For Each gff_Field As GFF_Field In gff_Struct.fields
					If gff_Struct.fieldCount > 1 Then
						binaryWriter.Seek(num25, SeekOrigin.Begin)
						binaryWriter.Write(num)
						num25 = CInt(fileStream.Position)
					End If
					Select Case gff_Field.Type
						Case GFFField.GFF_byte, GFFField.GFF_char, GFFField.GFF_word, GFFField.GFF_short, GFFField.GFF_dword, GFFField.GFF_int, GFFField.GFF_float, GFFField.GFF_Struct
							binaryWriter.Seek(num19, SeekOrigin.Begin)
							binaryWriter.Write(CInt(gff_Field.Type))
							binaryWriter.Write(gff_Field.labelIndex)
							If gff_Field.Type < GFFField.GFF_int Then
								binaryWriter.Write(Convert.ToUInt32(RuntimeHelpers.GetObjectValue(gff_Field.value)))
							ElseIf gff_Field.Type = GFFField.GFF_int Then
								binaryWriter.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(gff_Field.value)))
							ElseIf gff_Field.Type = GFFField.GFF_float Then
								binaryWriter.Write(Convert.ToSingle(RuntimeHelpers.GetObjectValue(gff_Field.value)))
							Else
								Dim obj As Object = binaryWriter
								Dim type As Type = Nothing
								Dim text As String = "Write"
								Dim array As Object() = New Object(0) {}
								Dim array2 As Object() = array
								Dim num30 As Integer = 0
								Dim gff_Field2 As GFF_Field = gff_Field
								array2(num30) = RuntimeHelpers.GetObjectValue(gff_Field2.value)
								Dim array3 As Object() = array
								Dim array4 As Object() = array3
								Dim array5 As String() = Nothing
								Dim array6 As Boolean() = New Boolean() { True }
								LateBinding.LateCall(obj, type, text, array4, array5, array6)
								If array6(0) Then
									gff_Field2.value = RuntimeHelpers.GetObjectValue(array3(0))
								End If
							End If
							num19 = CInt(fileStream.Position)
							num += 1
						Case GFFField.GFF_dword64, GFFField.GFF_int64, GFFField.GFF_double, GFFField.GFF_CResRef
							gff_Field.DataOffset = num23 - num22
							binaryWriter.Seek(num23, SeekOrigin.Begin)
							Dim obj2 As Object = binaryWriter
							Dim type2 As Type = Nothing
							Dim text2 As String = "Write"
							Dim array As Object() = New Object(0) {}
							Dim array7 As Object() = array
							Dim num31 As Integer = 0
							Dim gff_Field2 As GFF_Field = gff_Field
							array7(num31) = RuntimeHelpers.GetObjectValue(gff_Field2.value)
							Dim array3 As Object() = array
							Dim array8 As Object() = array3
							Dim array9 As String() = Nothing
							Dim array6 As Boolean() = New Boolean() { True }
							LateBinding.LateCall(obj2, type2, text2, array8, array9, array6)
							If array6(0) Then
								gff_Field2.value = RuntimeHelpers.GetObjectValue(array3(0))
							End If
							num23 = CInt(fileStream.Position)
							binaryWriter.Seek(num19, SeekOrigin.Begin)
							binaryWriter.Write(CInt(gff_Field.Type))
							binaryWriter.Write(gff_Field.labelIndex)
							binaryWriter.Write(gff_Field.DataOffset)
							num19 = CInt(fileStream.Position)
							num += 1
						Case GFFField.GFF_CExoString
							gff_Field.DataOffset = num23 - num22
							binaryWriter.Seek(num23, SeekOrigin.Begin)
							binaryWriter.Write(StringType.FromObject(gff_Field.value).Length)
							Dim encoding As Encoding = Encoding.GetEncoding(1252)
							Dim obj3 As Object = encoding
							Dim type3 As Type = Nothing
							Dim text3 As String = "GetBytes"
							Dim array As Object() = New Object(0) {}
							Dim array10 As Object() = array
							Dim num32 As Integer = 0
							Dim gff_Field2 As GFF_Field = gff_Field
							array10(num32) = RuntimeHelpers.GetObjectValue(gff_Field2.value)
							Dim array3 As Object() = array
							Dim array11 As Object() = array3
							Dim array12 As String() = Nothing
							Dim array6 As Boolean() = New Boolean() { True }
							Dim obj4 As Object = LateBinding.LateGet(obj3, type3, text3, array11, array12, array6)
							If array6(0) Then
								gff_Field2.value = RuntimeHelpers.GetObjectValue(array3(0))
							End If
							Dim array13 As Byte() = CType(obj4, Byte())
							binaryWriter.Write(array13)
							num23 = CInt(fileStream.Position)
							binaryWriter.Seek(num19, SeekOrigin.Begin)
							binaryWriter.Write(CInt(gff_Field.Type))
							binaryWriter.Write(gff_Field.labelIndex)
							binaryWriter.Write(gff_Field.DataOffset)
							num19 = CInt(fileStream.Position)
							num += 1
						Case GFFField.GFF_CExoLocString
							gff_Field.DataOffset = num23 - num22
							binaryWriter.Seek(num23, SeekOrigin.Begin)
							Dim gffexoLocString As GFFExoLocString = CType(gff_Field.value, GFFExoLocString)
							binaryWriter.Write(gffexoLocString.size)
							binaryWriter.Write(gffexoLocString.StringRef)
							binaryWriter.Write(gffexoLocString.StringCount)
							For Each gffexoLocSubString As GFFExoLocSubString In gffexoLocString.subStringArr
								binaryWriter.Write(gffexoLocSubString.StringID)
								binaryWriter.Write(gffexoLocSubString.StringLength)
								Dim encoding2 As Encoding = Encoding.GetEncoding(1252)
								Dim bytes As Byte() = encoding2.GetBytes(gffexoLocSubString.value)
								binaryWriter.Write(bytes)
							Next
							num23 = CInt(fileStream.Position)
							binaryWriter.Seek(num19, SeekOrigin.Begin)
							binaryWriter.Write(CInt(gff_Field.Type))
							binaryWriter.Write(gff_Field.labelIndex)
							binaryWriter.Write(gff_Field.DataOffset)
							num19 = CInt(fileStream.Position)
							num += 1
						Case GFFField.GFF_Void
							gff_Field.DataOffset = num23 - num22
							binaryWriter.Seek(num23, SeekOrigin.Begin)
							binaryWriter.Write(CType(gff_Field.value, GFFVoid).size)
							binaryWriter.Write(CType(gff_Field.value, GFFVoid).bytes)
							num23 = CInt(fileStream.Position)
							binaryWriter.Seek(num19, SeekOrigin.Begin)
							binaryWriter.Write(CInt(gff_Field.Type))
							binaryWriter.Write(gff_Field.labelIndex)
							binaryWriter.Write(gff_Field.DataOffset)
							num19 = CInt(fileStream.Position)
							num += 1
						Case GFFField.GFF_List
							gff_Field.DataOffset = num27 - num26
							binaryWriter.Seek(num27, SeekOrigin.Begin)
							binaryWriter.Write(CType(gff_Field.value, GFFList).structIndices.Count)
							Try
								For Each obj5 As Object In CType(gff_Field.value, GFFList).structIndices
									Dim num33 As Integer = IntegerType.FromObject(obj5)
									binaryWriter.Write(num33)
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									CType(enumerator, IDisposable).Dispose()
								End If
							End Try
							num27 = CInt(fileStream.Position)
							binaryWriter.Seek(num19, SeekOrigin.Begin)
							binaryWriter.Write(CInt(gff_Field.Type))
							binaryWriter.Write(gff_Field.labelIndex)
							binaryWriter.Write(gff_Field.DataOffset)
							num19 = CInt(fileStream.Position)
							num += 1
						Case GFFField.GFF_Type16
							gff_Field.DataOffset = num23 - num22
							binaryWriter.Seek(num23, SeekOrigin.Begin)
							binaryWriter.Write(CType(gff_Field.value, GFFType16).f1)
							binaryWriter.Write(CType(gff_Field.value, GFFType16).f2)
							binaryWriter.Write(CType(gff_Field.value, GFFType16).f3)
							binaryWriter.Write(CType(gff_Field.value, GFFType16).f4)
							num23 = CInt(fileStream.Position)
							binaryWriter.Seek(num19, SeekOrigin.Begin)
							binaryWriter.Write(CInt(gff_Field.Type))
							binaryWriter.Write(gff_Field.labelIndex)
							binaryWriter.Write(gff_Field.DataOffset)
							num19 = CInt(fileStream.Position)
							num += 1
						Case GFFField.GFF_Type17
							gff_Field.DataOffset = num23 - num22
							binaryWriter.Seek(num23, SeekOrigin.Begin)
							binaryWriter.Write(CType(gff_Field.value, GFFType17).f1)
							binaryWriter.Write(CType(gff_Field.value, GFFType17).f2)
							binaryWriter.Write(CType(gff_Field.value, GFFType17).f3)
							num23 = CInt(fileStream.Position)
							binaryWriter.Seek(num19, SeekOrigin.Begin)
							binaryWriter.Write(CInt(gff_Field.Type))
							binaryWriter.Write(gff_Field.labelIndex)
							binaryWriter.Write(gff_Field.DataOffset)
							num19 = CInt(fileStream.Position)
							num += 1
					End Select
				Next
			Next
			Dim array14 As Char() = New Char(15) {}
			binaryWriter.Seek(num21, SeekOrigin.Begin)
			Dim num34 As Integer = 0
			Dim num35 As Integer = hashtable.Count - 1
			For i As Integer = num34 To num35
				Dim text4 As String
				Try
					For Each obj6 As Object In hashtable.Keys
						text4 = StringType.FromObject(obj6)
						If ObjectType.ObjTst(hashtable(text4), i, False) = 0 Then
							Exit For
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						CType(enumerator2, IDisposable).Dispose()
					End If
				End Try
				Array.Clear(array14, 0, 16)
				Array.Copy(text4.ToCharArray(), array14, text4.Length)
				binaryWriter.Write(array14)
			Next
			binaryWriter.Close()
		End Sub

		' Token: 0x06000099 RID: 153 RVA: 0x0022017C File Offset: 0x0021F17C
		Public Sub SetTextBoxToNodeValue(TB As TextBox, NodePath As String)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.GetNodeValue(NodePath))
			If objectValue IsNot Nothing Then
				TB.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue))
			End If
		End Sub

		' Token: 0x0600009A RID: 154 RVA: 0x002201AC File Offset: 0x0021F1AC
		Public Function GetCExoLocStringNodeValue(NodePath As String) As String
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(NodePath), GFFExoLocString)
			If gffexoLocString Is Nothing Then
				Return "(GFF Path not found: " + NodePath + ")"
			End If
			If gffexoLocString.StringRef <> -1 Then
				Return Me.dialogTlk.GetString(gffexoLocString.StringRef)
			End If
			If gffexoLocString.StringCount > 0 Then
				Return CType(gffexoLocString.subStringArr(0), GFFExoLocSubString).value
			End If
			Dim text As String
			Return text
		End Function

		' Token: 0x0600009B RID: 155 RVA: 0x00220214 File Offset: 0x0021F214
		Public Sub SetNumericUpDownToNodeValue(NUD As NumericUpDown, NodePath As String, Optional ScaleFactor As Single = 0F)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.GetNodeValue(NodePath))
			If objectValue IsNot Nothing Then
				NUD.Value = DecimalType.FromObject(objectValue)
			End If
			If objectValue IsNot Nothing Then
				If ScaleFactor = 0F Then
					NUD.Value = DecimalType.FromObject(objectValue)
				Else
					NUD.Value = DecimalType.FromObject(ObjectType.MulObj(objectValue, ScaleFactor))
				End If
			End If
		End Sub

		' Token: 0x0600009C RID: 156 RVA: 0x00220270 File Offset: 0x0021F270
		Public Sub SetNumericUpDownToUIntNodeValue(NUD As NumericUpDown, NodePath As String, Optional ScaleFactor As Single = 0F)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.GetNodeValue(NodePath))
			If objectValue IsNot Nothing Then
				If ScaleFactor = 0F Then
					NUD.Value = New Decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)))
				Else
					NUD.Value = New Decimal(CSng(Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue))) * ScaleFactor)
				End If
			End If
		End Sub

		' Token: 0x0600009D RID: 157 RVA: 0x002202C8 File Offset: 0x0021F2C8
		Public Sub FillComboBoxFrom2DA(cmbx As ComboBox, colName As String, TwoDAName As String, ChitinKey As clsChitinKey, DialogTlk As clsDialogTlk, KotORPath As String)
			Dim num As Integer = ChitinKey.FindResIDForResRef(TwoDAName, 2017)
			Dim text As String = KotORPath + "\" + ChitinKey.BiffList(num >> 20).filename
			Dim cls2DA As cls2DA = New cls2DA(Me.GetBIFFResource(text, num).data)
			If DialogTlk IsNot Nothing Then
				Dim num2 As Integer = 0
				Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
				For i As Integer = num2 To rowsUpperBound
					Dim indiceData As Object = cls2DA.GetIndiceData(i, colName)
					If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
						cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
					Else
						cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
					End If
				Next
			Else
				Dim num3 As Integer = 0
				Dim rowsUpperBound2 As Integer = cls2DA.RowsUpperBound
				For i As Integer = num3 To rowsUpperBound2
					cmbx.Items.Add(cls2DA.GetIndiceData(i, colName))
				Next
			End If
		End Sub

		' Token: 0x0600009E RID: 158 RVA: 0x002203A0 File Offset: 0x0021F3A0
		Public Function SyncComboBox(cmbx As ComboBox, NodePath As String) As Boolean
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.GetNodeValue(NodePath))
			Dim flag As Boolean
			If objectValue IsNot Nothing Then
				' The following expression was wrapped in a checked-expression
				If Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)) > cmbx.Items.Count - 1 Then
					cmbx.BackColor = Color.Tomato
					cmbx.SelectedIndex = -1
					flag = False
				Else
					cmbx.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue))
					flag = True
				End If
			End If
			Return flag
		End Function

		' Token: 0x0600009F RID: 159 RVA: 0x00220404 File Offset: 0x0021F404
		Public Sub SetTextBoxFrom2DA(txtbx As TextBox, rowNumber As Integer, colName As String, TwoDAName As String, ChitinKey As clsChitinKey, DialogTlk As clsDialogTlk, KotORPath As String)
			Dim num As Integer = ChitinKey.FindResIDForResRef(TwoDAName, 2017)
			Dim text As String = KotORPath + "\" + ChitinKey.BiffList(num >> 20).filename
			Dim cls2DA As cls2DA = New cls2DA(Me.GetBIFFResource(text, num).data)
			If DialogTlk IsNot Nothing Then
				Dim indiceData As Object = cls2DA.GetIndiceData(rowNumber, colName)
				If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
					txtbx.Text = DialogTlk.GetString(IntegerType.FromObject(indiceData))
				Else
					txtbx.Text = StringType.FromInteger(0)
				End If
			Else
				txtbx.Text = cls2DA.GetIndiceData(rowNumber, colName)
			End If
		End Sub

		' Token: 0x060000A0 RID: 160 RVA: 0x002204A0 File Offset: 0x0021F4A0
		Public Sub SetTextBoxFromCExoLocStringNodeValue(TB As TextBox, NodePath As String, DialogTlk As clsDialogTlk)
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(NodePath), GFFExoLocString)
			If gffexoLocString Is Nothing Then
				TB.Text = "(GFF Path not found: " + NodePath + ")"
				Return
			End If
			If gffexoLocString.StringRef <> -1 Then
				TB.Text = DialogTlk.GetString(gffexoLocString.StringRef)
			ElseIf gffexoLocString.StringCount > 0 Then
				TB.Text = CType(gffexoLocString.subStringArr(0), GFFExoLocSubString).value
			End If
		End Sub

		' Token: 0x060000A1 RID: 161 RVA: 0x00220514 File Offset: 0x0021F514
		Public Sub SetTextBoxFromCExoLocStringNodeValue(TB As TextBox, NodePath As String)
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(NodePath), GFFExoLocString)
			If gffexoLocString.StringRef <> -1 Then
				TB.Text = Me.dialogTlk.GetString(gffexoLocString.StringRef)
			ElseIf gffexoLocString.StringCount > 0 Then
				TB.Text = CType(gffexoLocString.subStringArr(0), GFFExoLocSubString).value
			End If
		End Sub

		' Token: 0x060000A2 RID: 162 RVA: 0x00220574 File Offset: 0x0021F574
		Public Function GetCExoLocStringLanguage(NodePath As String) As Object
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(NodePath), GFFExoLocString)
			If gffexoLocString.StringRef <> -1 Then
				Return -1
			End If
			If gffexoLocString.StringCount > 0 Then
				Return CType(gffexoLocString.subStringArr(0), GFFExoLocSubString).StringID
			End If
			Dim obj As Object
			Return obj
		End Function

		' Token: 0x060000A3 RID: 163 RVA: 0x002205C0 File Offset: 0x0021F5C0
		Public Sub SetCExoLocStringNodeValueFromTextBox(TB As TextBox, NodePath As String, Optional LanguageID As Integer = 0)
			Dim gffexoLocString As GFFExoLocString = CType(Me.GetNodeValue(NodePath), GFFExoLocString)
			If gffexoLocString.StringRef = -1 Then
				If gffexoLocString.StringCount = 0 Then
					Me.CreateCExoLocSubStringEntry(NodePath, TB.Text, LanguageID)
				Else
					Me.SetCExoLocSubStringEntry(NodePath, TB.Text, LanguageID)
				End If
			Else
				Me.CreateCExoLocSubStringEntry(NodePath, TB.Text, LanguageID)
			End If
		End Sub

		' Token: 0x060000A4 RID: 164 RVA: 0x0022061C File Offset: 0x0021F61C
		Public Sub SetNodeValueFromTextBox(TB As TextBox, NodePath As String)
			Me.SetNodeValue(NodePath, TB.Text)
		End Sub

		' Token: 0x060000A5 RID: 165 RVA: 0x0022062C File Offset: 0x0021F62C
		Public Sub SetUInt16NodeValueFromTextBox(TB As TextBox, NodePath As String)
			Me.SetNodeValue(NodePath, Convert.ToUInt16(TB.Text))
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x00220648 File Offset: 0x0021F648
		Public Sub SetUInt32NodeValueFromTextBox(TB As TextBox, NodePath As String)
			Me.SetNodeValue(NodePath, Convert.ToUInt32(TB.Text))
		End Sub

		' Token: 0x060000A7 RID: 167 RVA: 0x00220664 File Offset: 0x0021F664
		Public Sub SetNodeValueFromComboBox(Cmbx As ComboBox, NodePath As String)
			Me.SetNodeValue(NodePath, Cmbx.SelectedIndex)
		End Sub

		' Token: 0x060000A8 RID: 168 RVA: 0x00220678 File Offset: 0x0021F678
		Public Sub SetNodeValueFromNumericUpDown(NUD As NumericUpDown, NodePath As String, Optional ScaleFactor As Single = 0F)
			If ScaleFactor = 0F Then
				Me.SetNodeValue(NodePath, NUD.Value)
			Else
				Me.SetNodeValue(NodePath, Convert.ToSingle(NUD.Value) / ScaleFactor)
			End If
		End Sub

		' Token: 0x060000A9 RID: 169 RVA: 0x002206B0 File Offset: 0x0021F6B0
		Public Sub SetUInt16NodeValueFromNumericUpDown(NUD As NumericUpDown, NodePath As String, Optional ScaleFactor As Single = 0F)
			If ScaleFactor = 0F Then
				Me.SetNodeValue(NodePath, Convert.ToUInt16(NUD.Value))
			Else
				Me.SetNodeValue(NodePath, Convert.ToUInt16(Convert.ToSingle(NUD.Value) / ScaleFactor))
			End If
		End Sub

		' Token: 0x060000AA RID: 170 RVA: 0x002206FC File Offset: 0x0021F6FC
		Public Sub SetUInt32NodeValueFromNumericUpDown(NUD As NumericUpDown, NodePath As String, Optional ScaleFactor As Single = 0F)
			If ScaleFactor = 0F Then
				Me.SetNodeValue(NodePath, Convert.ToUInt32(NUD.Value))
			Else
				Me.SetNodeValue(NodePath, Convert.ToUInt32(Convert.ToSingle(NUD.Value) / ScaleFactor))
			End If
		End Sub

		' Token: 0x060000AB RID: 171 RVA: 0x00220748 File Offset: 0x0021F748
		Private Function GetBIFFResource(biffPath As String, resourceID As Integer) As BIFFVarRsrcEntry
			Dim fileStream As FileStream = New FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
			Dim biffarchive As BIFFArchive = New BIFFArchive(fileStream)
			Return biffarchive.getBIFFResource(resourceID)
		End Function

		' Token: 0x060000AC RID: 172 RVA: 0x00220774 File Offset: 0x0021F774
		Private Sub PrintMsg(msg As String, indented As Boolean)
			If indented Then
				' The following expression was wrapped in a checked-expression
				Me.g_stringbuilder.Append(Strings.Space(Me.g_tabLevel * 3))
			End If
			Me.g_stringbuilder.Append(msg)
		End Sub

		' Token: 0x040000A8 RID: 168
		Private g_StructOffset As Integer

		' Token: 0x040000A9 RID: 169
		Private g_StructCount As Integer

		' Token: 0x040000AA RID: 170
		Private g_FieldOffset As Integer

		' Token: 0x040000AB RID: 171
		Private g_FieldCount As Integer

		' Token: 0x040000AC RID: 172
		Private g_LabelOffset As Integer

		' Token: 0x040000AD RID: 173
		Private g_LabelCount As Integer

		' Token: 0x040000AE RID: 174
		Private g_FieldDataOffset As Integer

		' Token: 0x040000AF RID: 175
		Private g_FieldDataCount As Integer

		' Token: 0x040000B0 RID: 176
		Private g_FieldIndicesOffset As Integer

		' Token: 0x040000B1 RID: 177
		Private g_FieldIndicesCount As Integer

		' Token: 0x040000B2 RID: 178
		Private g_ListIndicesOffset As Integer

		' Token: 0x040000B3 RID: 179
		Private g_ListIndicesCount As Integer

		' Token: 0x040000B4 RID: 180
		Private g_ms As MemoryStream

		' Token: 0x040000B5 RID: 181
		Private g_rdr As BinaryReader

		' Token: 0x040000B6 RID: 182
		Public g_structArr As Array

		' Token: 0x040000B7 RID: 183
		Public g_gff_ListArr As ArrayList

		' Token: 0x040000B8 RID: 184
		Private g_tabLevel As Integer

		' Token: 0x040000B9 RID: 185
		Private g_stringbuilder As StringBuilder

		' Token: 0x040000BA RID: 186
		Private g_bRTF_mode As Boolean

		' Token: 0x040000BB RID: 187
		Private NodeSearchPath As String()

		' Token: 0x040000BC RID: 188
		Private NodeSearchLevel As Integer

		' Token: 0x040000BD RID: 189
		Private root_GFFStruct As GFF_Struct

		' Token: 0x040000BE RID: 190
		Private dialogTlk As clsDialogTlk

		' Token: 0x040000BF RID: 191
		Protected KotorVersionIndex As Integer

		' Token: 0x040000C0 RID: 192
		Private g_fieldCountforCoding As Integer

		' Token: 0x040000C1 RID: 193
		Private max_offset As Integer

		' Token: 0x040000C2 RID: 194
		Private offsetCnt As Integer

		' Token: 0x040000C3 RID: 195
		Private Const sizeofGFF_Struct As Integer = 12

		' Token: 0x040000C4 RID: 196
		Private Const sizeofGFF_Field As Integer = 12
	End Class
End Namespace
