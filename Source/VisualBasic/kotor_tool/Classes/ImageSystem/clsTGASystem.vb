Imports System
Imports System.IO
Imports System.Text

Namespace kotor_tool
    Public Class clsTGASystem
        'Public Sub WriteFile(ByVal outputPath As String, ByVal xSize As Short, ByVal ySize As Short, ByVal bitsPerPixel As Short, ByVal dataSize As Integer, ByVal pixelData As Byte(), ByVal tpcData As Byte())
        '    Dim fileStream As FileStream = New FileStream(outputPath, FileMode.Create)
        '    Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)

        '    binaryWriter.Write(0)
        '    binaryWriter.Write(0)
        '    binaryWriter.Write(2)
        '    binaryWriter.Write(0)
        '    binaryWriter.Write(0)
        '    binaryWriter.Write(0)
        '    binaryWriter.Write(xSize)
        '    binaryWriter.Write(ySize)
        '    binaryWriter.Write(bitsPerPixel)

        '    If dataSize > 0 Then
        '        Dim exportBytes As Byte() = CType(Array.CreateInstance(GetType(Byte), pixelData.Length), Byte())
        '        Array.Copy(pixelData, exportBytes, pixelData.Length)
        '        Dim exportPixelData As Array = exportBytes
        '        clsImageSystem.FlipImageVertically(exportPixelData, CInt((4S * xSize)), CInt(ySize))
        '        binaryWriter.Write(CType(exportPixelData, Byte()))
        '    Else
        '        binaryWriter.Write(tpcData)
        '    End If

        '    binaryWriter.Close()
        'End Sub
        Public Sub WriteFile(ByVal outputPath As String, ByVal xSize As Short, ByVal ySize As Short, ByVal bitsPerPixel As Short, ByVal dataSize As Integer, ByVal pixelData As Byte(), ByVal tpcData As Byte())
            Using fileStream As New FileStream(outputPath, FileMode.Create)
                Using binaryWriter As New BinaryWriter(fileStream, Encoding.ASCII)

                    ' --- TGA Header (Must be exactly 18 bytes) ---
                    binaryWriter.Write(CByte(0))      ' 0: ID Length
                    binaryWriter.Write(CByte(0))      ' 1: Color Map Type (0 = none)
                    binaryWriter.Write(CByte(2))      ' 2: Image Type (2 = Uncompressed True-Color)

                    ' 3-7: Color Map Spec (5 bytes, all 0 since no color map)
                    binaryWriter.Write(CByte(0))      ' 3: First Entry Index LSB
                    binaryWriter.Write(CByte(0))      ' 4: First Entry Index MSB
                    binaryWriter.Write(CByte(0))      ' 5: Color Map Length LSB
                    binaryWriter.Write(CByte(0))      ' 6: Color Map Length MSB
                    binaryWriter.Write(CByte(0))      ' 7: Color Map Entry Size

                    ' 8-11: Image Origins
                    binaryWriter.Write(CShort(0))     ' 8-9: X-origin
                    binaryWriter.Write(CShort(0))     ' 10-11: Y-origin

                    ' 12-15: Image Dimensions
                    binaryWriter.Write(CShort(xSize)) ' 12-13: Width
                    binaryWriter.Write(CShort(ySize)) ' 14-15: Height

                    ' 16: Pixel Depth
                    binaryWriter.Write(CByte(bitsPerPixel)) ' 16: Bits per pixel (e.g., 24 or 32)

                    ' 17: Image Descriptor
                    Dim descriptor As Byte = 0
                    If bitsPerPixel = 32 Then descriptor = 8 ' 8 bits of alpha
                    binaryWriter.Write(descriptor)    ' 17: Descriptor (0 = bottom-left origin)

                    ' --- Pixel Data ---
                    If dataSize > 0 Then
                        Dim exportBytes As Byte() = CType(pixelData.Clone(), Byte())

                        ' Calculate the correct stride based on bits per pixel (3 for 24-bit, 4 for 32-bit)
                        Dim stride As Integer = (bitsPerPixel \ 8) * xSize

                        ' Flip vertically because standard TGA uses bottom-left origin
                        clsImageSystem.FlipImageVertically(exportBytes, stride, CInt(ySize))

                        binaryWriter.Write(exportBytes)
                    Else
                        binaryWriter.Write(tpcData)
                    End If

                End Using
            End Using
        End Sub

    End Class
End Namespace
