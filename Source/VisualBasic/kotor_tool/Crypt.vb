Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace kotor_tool
	' Token: 0x0200003B RID: 59
	Public Class Crypt
		' Token: 0x0600015D RID: 349 RVA: 0x00225870 File Offset: 0x00224870
		Public Sub New()
			Me.TheKey = New Byte() { 136, 21, 221, 65, 1, 37, Byte.MaxValue, 171 }
			Me.Vector = New Byte() { 23, 100, 38, 174, 24, 37, 61, 65, 26, 37, Byte.MaxValue, 171, 224 }
		End Sub

		' Token: 0x0600015E RID: 350 RVA: 0x00225924 File Offset: 0x00224924
		Public Function Encrypt(inName As String) As String
            Dim text2 As String = Nothing
			Try
				Dim array As Byte() = New Byte(4096) {}
				Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
				Dim memoryStream As MemoryStream = New MemoryStream(1024)
				array = asciiencoding.GetBytes(inName)
				Dim descryptoServiceProvider As DESCryptoServiceProvider = New DESCryptoServiceProvider()
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, descryptoServiceProvider.CreateEncryptor(Me.TheKey, Me.Vector), CryptoStreamMode.Write)
				Dim length As Integer = inName.Length
				cryptoStream.Write(array, 0, length)
				cryptoStream.FlushFinalBlock()
				Dim text As String = Convert.ToBase64String(memoryStream.ToArray())
				cryptoStream.Close()
				text2 = text
            Catch ex As System.Exception

            End Try
			Return text2
		End Function

		' Token: 0x0600015F RID: 351 RVA: 0x002259D0 File Offset: 0x002249D0
		Public Function Decrypt(InStr As String) As String
			' The following expression was wrapped in a checked-statement
            Dim text As String = Nothing
			Try
				Dim array As Byte() = Convert.FromBase64String(InStr)
				Dim array2 As Byte() = New Byte(1024) {}
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim descryptoServiceProvider As DESCryptoServiceProvider = New DESCryptoServiceProvider()
				memoryStream.Write(array, 0, array.Length)
				memoryStream.Seek(0L, SeekOrigin.Begin)
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, descryptoServiceProvider.CreateDecryptor(Me.TheKey, Me.Vector), CryptoStreamMode.Read)
				Dim stringBuilder As StringBuilder = New StringBuilder()
				Dim num As Integer
				Do
					num = cryptoStream.Read(array2, 0, 64)
					Dim num2 As Integer = 0
					Dim num3 As Integer = num - 1
					For i As Integer = num2 To num3
						stringBuilder.Append(Convert.ToChar(array2(i)))
					Next
				Loop While num <> 0
				cryptoStream.Close()
				text = stringBuilder.ToString()
            Catch ex As System.Exception
            End Try
			Return text
		End Function

		' Token: 0x04000120 RID: 288
		Public TheKey As Byte()

		' Token: 0x04000121 RID: 289
		Private Vector As Byte()
	End Class
End Namespace
