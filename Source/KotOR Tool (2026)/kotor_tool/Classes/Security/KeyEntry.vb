Imports System
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic

Namespace kotor_tool
	' Token: 0x02000006 RID: 6
    <Serializable()> _
 Public Class KeyEntry
        ' Token: 0x17000005 RID: 5
        ' (get) Token: 0x06000012 RID: 18 RVA: 0x00217A4C File Offset: 0x00216A4C
        Public ReadOnly Property text() As Object
            Get
                Return Me.ResRef
            End Get
        End Property

        ' Token: 0x06000013 RID: 19 RVA: 0x00217A60 File Offset: 0x00216A60
        Public Sub New(ByVal sResRef As String, ByVal iResourceType As Short, ByVal iResID As Integer)
            Me.ResRef = sResRef
            Me.ResourceType = iResourceType
            Me.ResID = iResID
        End Sub

        ' Token: 0x06000014 RID: 20 RVA: 0x00217A80 File Offset: 0x00216A80
        Public Sub New(ByVal index As Integer, ByVal fs As FileStream, ByVal offset As Integer)
            Dim binaryReader As BinaryReader = New BinaryReader(fs, Encoding.ASCII)
            Dim array As Char() = New Char(15) {}
            Me.index = index
            fs.Seek(CLng(offset), SeekOrigin.Begin)
            array = binaryReader.ReadChars(16)
            Dim num As Integer = 0
            While array(num) <> vbNullChar
                num += 1
                If num > 15 Then
                    Exit While
                End If
            End While
            Me.ResRef = New StringBuilder(New String(array)) With {.Length = num}.ToString()
            Me.ResourceType = binaryReader.ReadInt16()
            Me.ResID = binaryReader.ReadInt32()
        End Sub

        ' Token: 0x06000015 RID: 21 RVA: 0x00217B0C File Offset: 0x00216B0C
        Public Sub New(ByVal index As Integer, ByVal data As Byte(), ByVal offset As Integer)
            Dim array As Byte() = New Byte(15) {}
            Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
            Me.index = index
            Dim stringBuilder As StringBuilder = New StringBuilder(asciiencoding.GetString(data, offset, 16))
            Dim num As Integer = 0
            While stringBuilder(num) <> vbNullChar
                num += 1
                If num > 15 Then
                    Exit While
                End If
            End While
            stringBuilder.Length = num
            Me.ResRef = stringBuilder.ToString()
            Me.ResourceType = Me.GetInt16FromArray(data, offset + 16)
            Me.ResID = Me.GetInt32FromArray(data, offset + 18)
        End Sub

        ' Token: 0x06000016 RID: 22 RVA: 0x00217B90 File Offset: 0x00216B90
        Private Function GetInt16FromArray(ByVal Arr As Byte(), ByVal offset As Integer) As Short
            ' The following expression was wrapped in a checked-statement
            Return CShort(Math.Round(CDbl(Arr(offset)) + CDbl(Arr(offset + 1)) * 256.0))
        End Function

        ' Token: 0x06000017 RID: 23 RVA: 0x00217BB8 File Offset: 0x00216BB8
        Private Function GetInt32FromArray(ByVal Arr As Byte(), ByVal offset As Integer) As Integer
            ' The following expression was wrapped in a checked-statement
            Return CInt(Math.Round(CDbl(Arr(offset)) + CDbl(Arr(offset + 1)) * 256.0 + CDbl(Arr(offset + 2)) * 65536.0 + CDbl(Arr(offset + 3)) * 16777216.0))
        End Function

        ' Token: 0x06000018 RID: 24 RVA: 0x00217C04 File Offset: 0x00216C04
        Private Sub backlup()
        End Sub

        ' Token: 0x04000013 RID: 19
        Public index As Integer

        ' Token: 0x04000014 RID: 20
        Public ResRef As String

        ' Token: 0x04000015 RID: 21
        Public ResourceType As Short

        ' Token: 0x04000016 RID: 22
        Public ResID As Integer
    End Class
End Namespace
