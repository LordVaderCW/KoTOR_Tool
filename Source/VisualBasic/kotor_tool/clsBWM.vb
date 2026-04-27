Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200000A RID: 10
	Public Class clsBWM
		' Token: 0x06000023 RID: 35 RVA: 0x00217E3C File Offset: 0x00216E3C
		Public Sub New()
			Me.unk_singles = New Single(13) {}
			Me.g_abbbIndex = 0
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x00217E58 File Offset: 0x00216E58
		Public Sub New(v As clsBWM.vert(), f As clsBWM.face())
			Me.unk_singles = New Single(13) {}
			Me.g_abbbIndex = 0
			Me.verts = New clsBWM.vert(v.GetUpperBound(0) + 1 - 1) {}
			Me.faces = New clsBWM.face(f.GetUpperBound(0) + 1 - 1) {}
			Array.Copy(v, Me.verts, v.Length)
			Array.Copy(f, Me.faces, f.Length)
			Me.vert_count = Convert.ToUInt32(Me.verts.Length)
			Me.face_count = Convert.ToUInt32(Me.faces.Length)
		End Sub

		' Token: 0x06000025 RID: 37 RVA: 0x00217EF8 File Offset: 0x00216EF8
		Public Sub New(filepath As String)
			Me.New(New FileStream(filepath, FileMode.Open))
		End Sub

		' Token: 0x06000026 RID: 38 RVA: 0x00217F08 File Offset: 0x00216F08
		Public Sub New(Data As Byte())
			Me.unk_singles = New Single(13) {}
			Me.g_abbbIndex = 0
			Dim memoryStream As MemoryStream = New MemoryStream(Data)
			Me.ReadFromStream(memoryStream)
		End Sub

		' Token: 0x06000027 RID: 39 RVA: 0x00217F40 File Offset: 0x00216F40
		Public Sub New(ms As MemoryStream)
			Me.unk_singles = New Single(13) {}
			Me.g_abbbIndex = 0
			Me.ReadFromStream(ms)
		End Sub

		' Token: 0x06000028 RID: 40 RVA: 0x00217F64 File Offset: 0x00216F64
		Public Sub New(fs As FileStream)
			Me.unk_singles = New Single(13) {}
			Me.g_abbbIndex = 0
			Dim binaryReader As BinaryReader = New BinaryReader(fs)
			Dim array As Byte() = New Byte(CInt((fs.Length - 1L)) + 1 - 1) {}
			array = binaryReader.ReadBytes(CInt(fs.Length))
			binaryReader.Close()
			Dim memoryStream As MemoryStream = New MemoryStream(array)
			Me.ReadFromStream(memoryStream)
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x00217FD0 File Offset: 0x00216FD0
		Private Sub ReadFromStream(ms As MemoryStream)
			Dim binaryReader As BinaryReader = New BinaryReader(ms)
			binaryReader.BaseStream.Seek(8L, SeekOrigin.Begin)
			Me.i = 0
			Do
				Me.unk_singles(Me.i) = binaryReader.ReadSingle()
				Me.i += 1
			Loop While Me.i <= 12
			Me.Position.x = binaryReader.ReadSingle()
			Me.Position.y = binaryReader.ReadSingle()
			Me.Position.z = binaryReader.ReadSingle()
			Me.vert_count = binaryReader.ReadUInt32()
			Me.verts_offset = binaryReader.ReadUInt32()
			Me.face_count = binaryReader.ReadUInt32()
			Me.faces_offset = binaryReader.ReadUInt32()
			Me.WalkType_Offset = binaryReader.ReadInt32()
			Me.unkXYZ_offset = binaryReader.ReadInt32()
			Me.unk3_offset = binaryReader.ReadInt32()
			Me.AABB_Count = binaryReader.ReadInt32()
			Me.AABB_Offset = binaryReader.ReadInt32()
			Me.unkInt32_1 = binaryReader.ReadInt32()
			Me.unk5_count = binaryReader.ReadInt32()
			Me.unk5_offset = binaryReader.ReadInt32()
			Me.unk6_count = binaryReader.ReadInt32()
			Me.unk6_offset = binaryReader.ReadInt32()
			Me.unk7_count = binaryReader.ReadInt32()
			Me.unk7_offset = binaryReader.ReadInt32()
			Me.verts = New clsBWM.vert(Convert.ToInt32(Me.vert_count) - 1 + 1 - 1) {}
			binaryReader.BaseStream.Seek(Convert.ToInt64(Me.verts_offset), SeekOrigin.Begin)
			Dim num As Integer = 0
			Dim num2 As Integer = Convert.ToInt32(Me.vert_count) - 1
			Me.i = num
			While Me.i <= num2
				Me.verts(Me.i).x = binaryReader.ReadSingle()
				Me.verts(Me.i).y = binaryReader.ReadSingle()
				Me.verts(Me.i).z = binaryReader.ReadSingle()
				Me.i += 1
			End While
			Me.faces = New clsBWM.face(Convert.ToInt32(Me.face_count) - 1 + 1 - 1) {}
			binaryReader.BaseStream.Seek(Convert.ToInt64(Me.faces_offset), SeekOrigin.Begin)
			Dim num3 As Integer = 0
			Dim num4 As Integer = Convert.ToInt32(Me.face_count) - 1
			Me.i = num3
			While Me.i <= num4
				Me.faces(Me.i).v1 = binaryReader.ReadInt32()
				Me.faces(Me.i).v2 = binaryReader.ReadInt32()
				Me.faces(Me.i).v3 = binaryReader.ReadInt32()
				Me.i += 1
			End While
			Me.WalkTypes = New Integer(Convert.ToInt32(Me.face_count) - 1 + 1 - 1) {}
			binaryReader.BaseStream.Seek(CLng(Me.WalkType_Offset), SeekOrigin.Begin)
			Dim num5 As Integer = 0
			Dim num6 As Integer = Convert.ToInt32(Me.face_count) - 1
			Me.i = num5
			While Me.i <= num6
				Me.WalkTypes(Me.i) = binaryReader.ReadInt32()
				Me.i += 1
			End While
			Me.AABB_Nodes = New clsBWM.AABB_Node(Me.AABB_Count - 1 + 1 - 1) {}
			binaryReader.BaseStream.Seek(CLng(Me.AABB_Offset), SeekOrigin.Begin)
			Dim num7 As Integer = 0
			Dim num8 As Integer = Me.AABB_Count - 1
			Me.i = num7
			While Me.i <= num8
				Dim num9 As Integer = Me.i
				Me.AABB_Nodes(num9).BBox_Min.x = binaryReader.ReadSingle()
				Me.AABB_Nodes(num9).BBox_Min.y = binaryReader.ReadSingle()
				Me.AABB_Nodes(num9).BBox_Min.z = binaryReader.ReadSingle()
				Me.AABB_Nodes(num9).BBox_Max.x = binaryReader.ReadSingle()
				Me.AABB_Nodes(num9).BBox_Max.y = binaryReader.ReadSingle()
				Me.AABB_Nodes(num9).BBox_Max.z = binaryReader.ReadSingle()
				Me.AABB_Nodes(num9).LeafFacePartNumber = binaryReader.ReadInt32()
				Me.AABB_Nodes(num9).Always4 = binaryReader.ReadInt32()
				Me.AABB_Nodes(num9).MostSignifPlane = binaryReader.ReadInt32()
				Me.AABB_Nodes(num9).LeftNodeArrayIndex = binaryReader.ReadInt32()
				Me.AABB_Nodes(num9).RightNodeArrayIndex = binaryReader.ReadInt32()
				Me.i += 1
			End While
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00218474 File Offset: 0x00217474
		Public Sub WriteBinary(filepath As String)
			Dim fileStream As FileStream = New FileStream(filepath, FileMode.Create)
			Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream)
			binaryWriter.Write("BWM V1.0".ToCharArray())
			Dim i As Integer = 0
			Do
				binaryWriter.Write(Me.unk_singles(i))
				i += 1
			Loop While i <= 12
			binaryWriter.Write(Me.Position.x)
			binaryWriter.Write(Me.Position.y)
			binaryWriter.Write(Me.Position.z)
			binaryWriter.Write(Me.verts.Length)
			binaryWriter.Write(Convert.ToUInt32(136))
			binaryWriter.Write(Me.faces.Length)
			binaryWriter.Write(Convert.ToUInt32(0))
			binaryWriter.Seek(136, SeekOrigin.Begin)
			Dim num As Integer = 0
			Dim num2 As Integer = Me.verts.Length - 1
			i = num
			While i <= num2
				binaryWriter.Write(Me.verts(i).x)
				binaryWriter.Write(Me.verts(i).y)
				binaryWriter.Write(Me.verts(i).z)
				i += 1
			End While
			Me.faces_offset = Convert.ToUInt32(binaryWriter.BaseStream.Position)
			Dim num3 As Integer = 0
			Dim num4 As Integer = Me.faces.Length - 1
			i = num3
			While i <= num4
				binaryWriter.Write(Me.faces(i).v1)
				binaryWriter.Write(Me.faces(i).v2)
				binaryWriter.Write(Me.faces(i).v3)
				i += 1
			End While
			Me.WalkType_Offset = Convert.ToInt32(binaryWriter.BaseStream.Position)
			Dim num5 As Integer = 0
			Dim num6 As Integer = Me.faces.Length - 1
			i = num5
			While i <= num6
				binaryWriter.Write(Convert.ToInt32(Me.WalkTypes(i)))
				i += 1
			End While
			Me.unkXYZ_offset = Convert.ToInt32(binaryWriter.BaseStream.Position)
			Dim num7 As Integer = 0
			Dim num8 As Integer = Me.faces.Length - 1
			i = num7
			While i <= num8
				binaryWriter.Write(Convert.ToInt32(0))
				binaryWriter.Write(Convert.ToInt32(0))
				binaryWriter.Write(Convert.ToInt32(0))
				i += 1
			End While
			Me.unk3_offset = Convert.ToInt32(binaryWriter.BaseStream.Position)
			Dim num9 As Integer = 0
			Dim num10 As Integer = Me.faces.Length - 1
			i = num9
			While i <= num10
				binaryWriter.Write(Convert.ToInt32(0))
				i += 1
			End While
			binaryWriter.Seek(84, SeekOrigin.Begin)
			binaryWriter.Write(Me.faces_offset)
			binaryWriter.Write(Me.WalkType_Offset)
			binaryWriter.Write(Me.unkXYZ_offset)
			binaryWriter.Write(Me.unk3_offset)
			binaryWriter.Close()
		End Sub

		' Token: 0x0600002B RID: 43 RVA: 0x00218728 File Offset: 0x00217728
		Public Sub ParseASCIIWalkMesh(filepath As String)
			Dim fileStream As FileStream = New FileStream(filepath, FileMode.Open)
			Dim streamReader As StreamReader = New StreamReader(fileStream)
			If streamReader.ReadLine().StartsWith("BWM") Then
				streamReader.Close()
                Throw New System.Exception("Not an ASCII file")
			End If
			Dim text As String
			Do
				text = streamReader.ReadLine()
				Console.WriteLine(text)
				Dim array As String() = Me.RemoveExcessWhitespace(text.Trim()).Split(New Char() { " "c })
				Dim text2 As String = array(0).ToLower()
				If StringType.StrCmp(text2, "position", False) = 0 Then
					If array.Length <> 4 Then
						Console.WriteLine("Wrong number of values for Position: " + StringType.FromInteger(array.Length - 1))
					Else
						Me.Position.x = Convert.ToSingle(array(1))
						Me.Position.y = Convert.ToSingle(array(2))
						Me.Position.z = Convert.ToSingle(array(3))
					End If
				ElseIf StringType.StrCmp(text2, "verts", False) = 0 Then
					If array.Length <> 2 Then
						Console.WriteLine("Wrong number of values for Verts header: " + StringType.FromInteger(array.Length - 1))
					ElseIf Not Information.IsNumeric(array(1)) Then
						Console.WriteLine("Value for Verts count non-numeric")
					Else
						Me.verts = New clsBWM.vert(Convert.ToInt32(array(1)) - 1 + 1 - 1) {}
						Dim num As Integer = 0
						Dim num2 As Integer = Convert.ToInt32(array(1)) - 1
						For i As Integer = num To num2
							text = streamReader.ReadLine()
							Console.WriteLine(text)
							array = Me.RemoveExcessWhitespace(text.Trim()).Split(New Char() { " "c })
							Me.verts(i).x = Convert.ToSingle(array(0))
							Me.verts(i).y = Convert.ToSingle(array(1))
							Me.verts(i).z = Convert.ToSingle(array(2))
						Next
					End If
				ElseIf StringType.StrCmp(text2, "faces", False) = 0 Then
					If array.Length <> 2 Then
						Console.WriteLine("Wrong number of values for Faces header: " + StringType.FromInteger(array.Length - 1))
					ElseIf Not Information.IsNumeric(array(1)) Then
						Console.WriteLine("Value for Faces count non-numeric")
					Else
						Me.faces = New clsBWM.face(Convert.ToInt32(array(1)) - 1 + 1 - 1) {}
						Me.WalkTypes = New Integer(Convert.ToInt32(array(1)) - 1 + 1 - 1) {}
						Dim num3 As Integer = 0
						Dim num4 As Integer = Convert.ToInt32(array(1)) - 1
						For i As Integer = num3 To num4
							text = streamReader.ReadLine()
							Console.WriteLine(text)
							array = Me.RemoveExcessWhitespace(text.Trim()).Split(New Char() { " "c })
							Me.faces(i).v1 = Convert.ToInt32(array(0))
							Me.faces(i).v2 = Convert.ToInt32(array(1))
							Me.faces(i).v3 = Convert.ToInt32(array(2))
							Me.WalkTypes(i) = Convert.ToInt32(array(7))
						Next
					End If
				ElseIf StringType.StrCmp(text2, "aabb", False) = 0 Then
					Me.AABB_Nodes = New clsBWM.AABB_Node(99) {}
					Dim num6 As Integer
					Dim num5 As Integer = num6
					Me.AABB_Nodes(num5).BBox_Min.x = SingleType.FromString(array(1))
					Me.AABB_Nodes(num5).BBox_Min.y = SingleType.FromString(array(2))
					Me.AABB_Nodes(num5).BBox_Min.z = SingleType.FromString(array(3))
					Me.AABB_Nodes(num5).BBox_Max.x = SingleType.FromString(array(4))
					Me.AABB_Nodes(num5).BBox_Max.y = SingleType.FromString(array(5))
					Me.AABB_Nodes(num5).BBox_Max.z = SingleType.FromString(array(6))
					Me.AABB_Nodes(num5).Always4 = 4
					Me.AABB_Nodes(num5).LeafFacePartNumber = IntegerType.FromString(array(7))
					num6 += 1
					Do
						text = streamReader.ReadLine()
						Console.WriteLine(text)
						array = Me.RemoveExcessWhitespace(text.Trim()).Split(New Char() { " "c })
						If Not Information.IsNumeric(array(0)) Then
							Exit Do
						End If
						Dim num7 As Integer = num6
						Me.AABB_Nodes(num7).BBox_Min.x = SingleType.FromString(array(0))
						Me.AABB_Nodes(num7).BBox_Min.y = SingleType.FromString(array(1))
						Me.AABB_Nodes(num7).BBox_Min.z = SingleType.FromString(array(2))
						Me.AABB_Nodes(num7).BBox_Max.x = SingleType.FromString(array(3))
						Me.AABB_Nodes(num7).BBox_Max.y = SingleType.FromString(array(4))
						Me.AABB_Nodes(num7).BBox_Max.z = SingleType.FromString(array(5))
						Me.AABB_Nodes(num7).LeafFacePartNumber = IntegerType.FromString(array(6))
						Me.AABB_Nodes(num7).Always4 = 4
						num6 += 1
						If num6 = Me.AABB_Nodes.Length Then
							Me.AABB_Nodes = CType(Utils.CopyArray(CType(Me.AABB_Nodes, Array), New clsBWM.AABB_Node(Me.AABB_Nodes.Length + 100 + 1 - 1) {}), clsBWM.AABB_Node())
						End If
					Loop While Information.IsNumeric(array(0))
					Dim num8 As Integer = 0
					Dim num9 As Integer = Me.AABB_Nodes.Length - 1
					Dim i As Integer = num8
					While i <= num9 AndAlso Me.AABB_Nodes(i).Always4 <> 0
						i += 1
					End While
					If i < Me.AABB_Nodes.Length Then
						Me.AABB_Nodes = CType(Utils.CopyArray(CType(Me.AABB_Nodes, Array), New clsBWM.AABB_Node(i - 1 + 1 - 1) {}), clsBWM.AABB_Node())
					End If
					Me.g_abbbIndex = 0
					Me.SetAABBNode(Me.AABB_Nodes(0), Me.AABB_Nodes)
					text = Nothing
				ElseIf StringType.StrCmp(text2, "endnode", False) = 0 Then
					Exit Do
				End If
			Loop While text IsNot Nothing
			streamReader.Close()
		End Sub

		' Token: 0x0600002C RID: 44 RVA: 0x00218DB0 File Offset: 0x00217DB0
		Public Sub WriteASCII(filepath As String, Optional parentname As String = "walk_parent")
			Dim fileStream As FileStream = New FileStream(filepath, FileMode.Create)
			Dim streamWriter As StreamWriter = New StreamWriter(fileStream, Encoding.ASCII)
			Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(filepath)
			streamWriter.WriteLine("# Written by Kotor Tool v" + Application.ProductVersion)
			streamWriter.WriteLine("node trimesh PWK")
			streamWriter.WriteLine("  parent " + parentname)
			streamWriter.WriteLine(String.Concat(New String() { "  position ", StringType.FromSingle(Me.Position.x), " ", StringType.FromSingle(Me.Position.y), " ", StringType.FromSingle(Me.Position.z) }))
			streamWriter.WriteLine("  orientation 1.0 0.0 0.0 0.0")
			streamWriter.WriteLine("  wirecolor 0.694118 0.580392 0.101961")
			streamWriter.WriteLine("  multimaterial 20")
			streamWriter.WriteLine("    Dirt")
			streamWriter.WriteLine("    Obscuring")
			streamWriter.WriteLine("    Grass")
			streamWriter.WriteLine("    Stone")
			streamWriter.WriteLine("    Wood")
			streamWriter.WriteLine("    Water")
			streamWriter.WriteLine("    Nonwalk")
			streamWriter.WriteLine("    Transparent")
			streamWriter.WriteLine("    Carpet")
			streamWriter.WriteLine("    Metal")
			streamWriter.WriteLine("    Puddles")
			streamWriter.WriteLine("    Swamp")
			streamWriter.WriteLine("    Mud")
			streamWriter.WriteLine("    Leaves")
			streamWriter.WriteLine("    Lava")
			streamWriter.WriteLine("    BottomlessPit")
			streamWriter.WriteLine("    DeepWater")
			streamWriter.WriteLine("    Door")
			streamWriter.WriteLine("    Snow")
			streamWriter.WriteLine("    Sand")
			streamWriter.WriteLine("  ambient 0.588 0.588 0.588")
			streamWriter.WriteLine("  diffuse 0.705882 0.0 1.0")
			streamWriter.WriteLine("  specular 0.0 0.0 0.0")
			streamWriter.WriteLine("  selfillumcolor 0.0 0.0 0.0")
			streamWriter.WriteLine("  bitmap NULL")
			streamWriter.WriteLine("  verts " + StringType.FromInteger(Me.verts.Length))
			Dim num As Integer = 0
			Dim num2 As Integer = Me.verts.Length - 1
			Me.i = num
			While Me.i <= num2
				streamWriter.WriteLine(String.Concat(New String() { "  ", StringType.FromSingle(Me.verts(Me.i).x), " ", StringType.FromSingle(Me.verts(Me.i).y), " ", StringType.FromSingle(Me.verts(Me.i).z) }))
				Me.i += 1
			End While
			streamWriter.WriteLine("  faces " + StringType.FromInteger(Me.faces.Length))
			Dim num3 As Integer = 0
			Dim num4 As Integer = Me.faces.Length - 1
			Me.i = num3
			While Me.i <= num4
				streamWriter.WriteLine(String.Concat(New String() { "  ", StringType.FromInteger(Me.faces(Me.i).v1), " ", StringType.FromInteger(Me.faces(Me.i).v2), " ", StringType.FromInteger(Me.faces(Me.i).v3), " 1 0 0 0 ", StringType.FromInteger(Me.WalkTypes(Me.i)) }))
				Me.i += 1
			End While
			streamWriter.WriteLine("endnode")
			streamWriter.Close()
		End Sub

		' Token: 0x0600002D RID: 45 RVA: 0x002191A0 File Offset: 0x002181A0
		Private Sub SetAABBNode(ByRef node As clsBWM.AABB_Node, aabbArray As clsBWM.AABB_Node())
			If Me.g_abbbIndex > aabbArray.Length Then
				Return
			End If
			If node.LeafFacePartNumber = -1 Then
				Me.g_abbbIndex += 1
				node.LeftNodeArrayIndex = Me.g_abbbIndex
				Me.SetAABBNode(aabbArray(Me.g_abbbIndex), aabbArray)
				Me.g_abbbIndex += 1
				node.RightNodeArrayIndex = Me.g_abbbIndex
				Me.SetAABBNode(aabbArray(Me.g_abbbIndex), aabbArray)
			Else
				node.LeftNodeArrayIndex = -1
				node.RightNodeArrayIndex = -1
			End If
		End Sub

		' Token: 0x0600002E RID: 46 RVA: 0x00219230 File Offset: 0x00218230
        'Private Function RemoveExcessWhitespace(src As String) As String
        '	Dim num As Integer = 0
        '	Dim num2 As Integer = src.Length - 1
        '	Dim text2 As String
        '	For i As Integer = num To num2
        '		Dim text As String = src.Substring(i, 1)
        '		Dim flag As Boolean
        '		If StringType.StrCmp(text, " ", False) <> 0 Then
        '			flag = False
        '			text2 += text
        '		ElseIf Not flag Then
        '			flag = True
        '			text2 += text
        '		End If
        '	Next
        '	Return text2
        'End Function


        ' Token: 0x0600002E RID: 46 RVA: 0x00219230 File Offset: 0x00218230
        Private Function RemoveExcessWhitespace(ByVal src As String) As String
            Dim result As String = ""
            Dim previousWasSpace As Boolean = False

            If src Is Nothing Then
                Return result
            End If

            Dim num As Integer = 0
            Dim num2 As Integer = src.Length - 1

            For i As Integer = num To num2
                Dim ch As String = src.Substring(i, 1)

                If StringType.StrCmp(ch, " ", False) <> 0 Then
                    previousWasSpace = False
                    result &= ch
                ElseIf Not previousWasSpace Then
                    previousWasSpace = True
                    result &= ch
                End If
            Next

            Return result
        End Function

		' Token: 0x04000023 RID: 35
		Public unk_singles As Single()

		' Token: 0x04000024 RID: 36
		Public vert_count As UInteger

		' Token: 0x04000025 RID: 37
		Public verts_offset As UInteger

		' Token: 0x04000026 RID: 38
		Public face_count As UInteger

		' Token: 0x04000027 RID: 39
		Public faces_offset As UInteger

		' Token: 0x04000028 RID: 40
		Public WalkType_Offset As Integer

		' Token: 0x04000029 RID: 41
		Public unkXYZ_offset As Integer

		' Token: 0x0400002A RID: 42
		Public unk3_offset As Integer

		' Token: 0x0400002B RID: 43
		Public AABB_Offset As Integer

		' Token: 0x0400002C RID: 44
		Public unk5_offset As Integer

		' Token: 0x0400002D RID: 45
		Public unk6_offset As Integer

		' Token: 0x0400002E RID: 46
		Public unk7_offset As Integer

		' Token: 0x0400002F RID: 47
		Private AABB_Count As Integer

		' Token: 0x04000030 RID: 48
		Private unkInt32_1 As Integer

		' Token: 0x04000031 RID: 49
		Private unk5_count As Integer

		' Token: 0x04000032 RID: 50
		Private unk6_count As Integer

		' Token: 0x04000033 RID: 51
		Private unk7_count As Integer

		' Token: 0x04000034 RID: 52
		Public WalkTypes As Integer()

		' Token: 0x04000035 RID: 53
		Public unk5 As Integer()

		' Token: 0x04000036 RID: 54
		Public unk2 As Single()

		' Token: 0x04000037 RID: 55
		Public unk3 As Single()

		' Token: 0x04000038 RID: 56
		Public unk4 As Single()

		' Token: 0x04000039 RID: 57
		Public unk6 As clsBWM.unkIntPair()

		' Token: 0x0400003A RID: 58
		Public Position As clsBWM.vert

		' Token: 0x0400003B RID: 59
		Public AABB_Nodes As clsBWM.AABB_Node()

		' Token: 0x0400003C RID: 60
		Public verts As clsBWM.vert()

		' Token: 0x0400003D RID: 61
		Public faces As clsBWM.face()

		' Token: 0x0400003E RID: 62
		Private i As Integer

		' Token: 0x0400003F RID: 63
		Private g_abbbIndex As Integer

		' Token: 0x0200000B RID: 11
		Public Structure vert
			' Token: 0x04000040 RID: 64
			Public x As Single

			' Token: 0x04000041 RID: 65
			Public y As Single

			' Token: 0x04000042 RID: 66
			Public z As Single
		End Structure

		' Token: 0x0200000C RID: 12
		Public Structure face
			' Token: 0x04000043 RID: 67
			Public v1 As Integer

			' Token: 0x04000044 RID: 68
			Public v2 As Integer

			' Token: 0x04000045 RID: 69
			Public v3 As Integer
		End Structure

		' Token: 0x0200000D RID: 13
		Public Structure unkIntPair
			' Token: 0x04000046 RID: 70
			Public int1 As Integer

			' Token: 0x04000047 RID: 71
			Public int2 As Integer
		End Structure

		' Token: 0x0200000E RID: 14
		Public Structure AABB_Node
			' Token: 0x04000048 RID: 72
			Public BBox_Min As clsBWM.vert

			' Token: 0x04000049 RID: 73
			Public BBox_Max As clsBWM.vert

			' Token: 0x0400004A RID: 74
			Public LeafFacePartNumber As Integer

			' Token: 0x0400004B RID: 75
			Public LeftNodeArrayIndex As Integer

			' Token: 0x0400004C RID: 76
			Public RightNodeArrayIndex As Integer

			' Token: 0x0400004D RID: 77
			Public Always4 As Integer

			' Token: 0x0400004E RID: 78
			Public MostSignifPlane As Integer
		End Structure
	End Class
End Namespace
