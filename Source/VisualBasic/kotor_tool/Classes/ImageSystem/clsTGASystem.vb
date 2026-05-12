Imports System
Imports System.IO
Imports System.Text

Namespace kotor_tool
    Public Class clsTGASystem
        Public Sub WriteFile(ByVal outputPath As String, ByVal xSize As Short, ByVal ySize As Short, ByVal bitsPerPixel As Short, ByVal dataSize As Integer, ByVal pixelData As Byte(), ByVal tpcData As Byte())
            Dim fileStream As FileStream = New FileStream(outputPath, FileMode.Create)
            Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)

            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(2)
            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(xSize)
            binaryWriter.Write(ySize)
            binaryWriter.Write(bitsPerPixel)

            If dataSize > 0 Then
                Dim exportBytes As Byte() = CType(Array.CreateInstance(GetType(Byte), pixelData.Length), Byte())
                Array.Copy(pixelData, exportBytes, pixelData.Length)
                Dim exportPixelData As Array = exportBytes
                clsImageSystem.FlipImageVertically(exportPixelData, CInt((4S * xSize)), CInt(ySize))
                binaryWriter.Write(CType(exportPixelData, Byte()))
            Else
                binaryWriter.Write(tpcData)
            End If

            binaryWriter.Close()
        End Sub
    End Class
End Namespace
