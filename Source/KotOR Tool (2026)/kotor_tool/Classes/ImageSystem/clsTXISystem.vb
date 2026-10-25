Imports System.IO
Imports System.Text

Namespace kotor_tool
    Public Class clsTXISystem
        Public Sub WriteFile(ByVal outputPath As String, ByVal text As String)
            Dim fileStream As FileStream = New FileStream(outputPath, FileMode.Create)
            Dim streamWriter As StreamWriter = New StreamWriter(fileStream, Encoding.ASCII)
            streamWriter.Write(text)
            streamWriter.Close()
        End Sub
    End Class
End Namespace
