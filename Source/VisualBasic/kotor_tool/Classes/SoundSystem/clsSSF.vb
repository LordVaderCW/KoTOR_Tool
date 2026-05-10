Imports System
Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200002C RID: 44
	Public Class clsSSF
		' Token: 0x06000125 RID: 293 RVA: 0x00224768 File Offset: 0x00223768
		Public Sub New()
			Me.m_RefArray = New Integer(40) {}
			Me.usetting = New UserSettings()
			Me.CurrentSettings = UserSettings.GetSettings()
		End Sub

		' Token: 0x06000126 RID: 294 RVA: 0x00224794 File Offset: 0x00223794
		Public Sub New(KotorVerIndex As Integer)
			Me.New()
			Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
		End Sub

		' Token: 0x06000127 RID: 295 RVA: 0x002247C0 File Offset: 0x002237C0
		Public Sub New(DialogTlk As clsDialogTlk)
			Me.New()
			Me.g_clsDialogTlk = DialogTlk
		End Sub

		' Token: 0x06000128 RID: 296 RVA: 0x002247D0 File Offset: 0x002237D0
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			Me.New(KotorVerIndex)
			Dim binaryReader As BinaryReader = New BinaryReader(fs)
			binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin)
			Dim num As Integer = 0
			Do
				Me.m_RefArray(num) = binaryReader.ReadInt32()
				num += 1
			Loop While num <= 39
			binaryReader.Close()
		End Sub

		' Token: 0x06000129 RID: 297 RVA: 0x00224820 File Offset: 0x00223820
		Public Sub New(fs As FileStream, DialogTlk As clsDialogTlk)
			Me.New(DialogTlk)
			Dim binaryReader As BinaryReader = New BinaryReader(fs)
			binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin)
			Dim num As Integer = 0
			Do
				Me.m_RefArray(num) = binaryReader.ReadInt32()
				num += 1
			Loop While num <= 39
			binaryReader.Close()
		End Sub

		' Token: 0x0600012A RID: 298 RVA: 0x00224870 File Offset: 0x00223870
		Public Sub New(data As Byte(), KotorVerIndex As Integer)
			Me.New(KotorVerIndex)
			Dim memoryStream As MemoryStream = New MemoryStream(data)
			Dim binaryReader As BinaryReader = New BinaryReader(memoryStream)
			binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin)
			Dim num As Integer = 0
			Do
				Me.m_RefArray(num) = binaryReader.ReadInt32()
				num += 1
			Loop While num <= 39
		End Sub

		' Token: 0x0600012B RID: 299 RVA: 0x002248C4 File Offset: 0x002238C4
		Public Sub New(data As Byte(), DialogTlk As clsDialogTlk)
			Me.New(DialogTlk)
			Dim memoryStream As MemoryStream = New MemoryStream(data)
			Dim binaryReader As BinaryReader = New BinaryReader(memoryStream)
			binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin)
			Dim num As Integer = 0
			Do
				Me.m_RefArray(num) = binaryReader.ReadInt32()
				num += 1
			Loop While num <= 39
		End Sub

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x0600012C RID: 300 RVA: 0x00224918 File Offset: 0x00223918
		' (set) Token: 0x0600012D RID: 301 RVA: 0x00224978 File Offset: 0x00223978
		Public Property RefArray(index As Object) As Integer
			Get
				If BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, False) >= 0, ObjectType.ObjTst(index, 39, False) <= 0)) Then
					Return Me.m_RefArray(IntegerType.FromObject(index))
				End If
				Return -999
			End Get
			Set(value As Integer)
				If BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, False) >= 0, ObjectType.ObjTst(index, 39, False) <= 0)) Then
					Me.m_RefArray(IntegerType.FromObject(index)) = value
				End If
			End Set
		End Property

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x0600012E RID: 302 RVA: 0x002249D0 File Offset: 0x002239D0
		Public ReadOnly Property RefArrayString(index As Object) As String
			Get
				If Not BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, False) >= 0, ObjectType.ObjTst(index, 39, False) <= 0)) Then
					Return "Invalid clsSSF array index!"
				End If
				If Me.m_RefArray(IntegerType.FromObject(index)) <> -1 Then
					Return Me.g_clsDialogTlk.GetString(Me.m_RefArray(IntegerType.FromObject(index)))
				End If
				Return ""
			End Get
		End Property

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x0600012F RID: 303 RVA: 0x00224A50 File Offset: 0x00223A50
		Public ReadOnly Property RefArraySoundResRef(index As Object) As String
			Get
				If Me.m_RefArray(IntegerType.FromObject(index)) <> -1 Then
					Return Me.g_clsDialogTlk.GetSoundResRef(Me.m_RefArray(IntegerType.FromObject(index)))
				End If
				Return ""
			End Get
		End Property

		' Token: 0x06000130 RID: 304 RVA: 0x00224A8C File Offset: 0x00223A8C
		Public Sub WriteFile(filepath As String)
			Dim fileStream As FileStream = New FileStream(filepath, FileMode.Create)
			Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream)
			binaryWriter.Write("SSF V1.1".ToCharArray())
			binaryWriter.Write(12)
			Dim num As Integer = 0
			Do
				binaryWriter.Write(Me.m_RefArray(num))
				num += 1
			Loop While num <= 39
			binaryWriter.Close()
		End Sub

		' Token: 0x04000114 RID: 276
		Private m_RefArray As Integer()

		' Token: 0x04000115 RID: 277
		Private CurrentSettings As Options

		' Token: 0x04000116 RID: 278
		Private g_clsDialogTlk As clsDialogTlk

		' Token: 0x04000117 RID: 279
		Private usetting As UserSettings
	End Class
End Namespace
