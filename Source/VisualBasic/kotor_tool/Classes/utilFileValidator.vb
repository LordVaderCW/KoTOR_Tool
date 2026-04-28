Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace kotor_tool
	' Token: 0x02000092 RID: 146
	Public Class utilFileValidator
		' Token: 0x06001812 RID: 6162 RVA: 0x002CD408 File Offset: 0x002CC408
		Public Sub Init(key As String)
			Me._key = Convert.FromBase64String(key)
		End Sub

		' Token: 0x06001813 RID: 6163 RVA: 0x002CD418 File Offset: 0x002CC418
		Public Function GenerateBase64Key(ClearTextKey As String) As String
			Return Convert.ToBase64String(New ASCIIEncoding().GetBytes(ClearTextKey))
		End Function

		' Token: 0x06001814 RID: 6164 RVA: 0x002CD438 File Offset: 0x002CC438
		Public Function Validate(filePath As String, signature As String) As Boolean
			Dim array As Byte() = Convert.FromBase64String(signature)
			Dim fileStream As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
			Dim keyedHashAlgorithm As KeyedHashAlgorithm = KeyedHashAlgorithm.Create()
			keyedHashAlgorithm.Key = Me._key
			Dim array2 As Byte() = keyedHashAlgorithm.ComputeHash(fileStream)
			fileStream.Close()
			Return Me.compareKeys(array2, array)
		End Function

		' Token: 0x06001815 RID: 6165 RVA: 0x002CD480 File Offset: 0x002CC480
		Public Function Sign(filepath As String, key As String) As String
            Dim array As Byte() = Nothing
			Try
				Dim fileStream As FileStream = New FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read)
				Dim keyedHashAlgorithm As KeyedHashAlgorithm = KeyedHashAlgorithm.Create()
				keyedHashAlgorithm.Key = Convert.FromBase64String(key)
				array = keyedHashAlgorithm.ComputeHash(fileStream)
            Catch ex As System.Exception
                Console.WriteLine(ex.ToString())
			Finally
                Dim fileStream As FileStream = Nothing
				If fileStream IsNot Nothing Then
					fileStream.Close()
				End If
			End Try
			Return Convert.ToBase64String(array)
		End Function

		' Token: 0x06001816 RID: 6166 RVA: 0x002CD4FC File Offset: 0x002CC4FC
		Private Function compareKeys(firstKey As Byte(), secondKey As Byte()) As Boolean
			If firstKey.Length <> secondKey.Length Then
				Return False
			End If
			Dim num As Integer = 0
			Dim num2 As Integer = firstKey.Length - 1
			For i As Integer = num To num2
				If firstKey(i) <> secondKey(i) Then
					Return False
				End If
			Next
			Return True
		End Function

		' Token: 0x04000BC5 RID: 3013
		Private _key As Byte()
	End Class
End Namespace
