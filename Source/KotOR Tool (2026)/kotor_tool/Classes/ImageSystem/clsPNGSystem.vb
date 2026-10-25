Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Namespace kotor_tool
    Public Class clsPNGSystem
        Public Function LoadImage(ByVal imageData As Byte()) As Image
            Using stream As MemoryStream = New MemoryStream(imageData)
                Using image As Image = Image.FromStream(stream)
                    Return New Bitmap(image)
                End Using
            End Using
        End Function

        Public Sub WriteFile(ByVal outputPath As String, ByVal image As Image)
            image.Save(outputPath, ImageFormat.Png)
        End Sub
    End Class
End Namespace
