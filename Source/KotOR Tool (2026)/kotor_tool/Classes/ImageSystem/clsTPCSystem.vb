Imports System
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
    Public Class clsTPCSystem
        Public Function Decode(ByVal sourceData As Byte()) As clsImageDecodeResult
            Dim result As clsImageDecodeResult = New clsImageDecodeResult()
            Dim tpcData As Byte() = CType(Array.CreateInstance(GetType(Byte), sourceData.Length), Byte())
            Array.Copy(sourceData, tpcData, sourceData.Length)

            result.DataSize = CInt(Math.Round(CDbl(tpcData(0)) + CDbl(tpcData(1)) * 256.0 + CDbl(tpcData(2)) * 65536.0 + CDbl(tpcData(3)) * 16777216.0))
            result.Flag1 = tpcData(4)
            result.Flag2 = tpcData(5)
            result.Flag3 = tpcData(6)
            result.Flag4 = tpcData(7)
            result.XSize = CShort((CInt(tpcData(8)) + CInt(tpcData(9)) * 256))
            result.YSize = CShort((CInt(tpcData(10)) + CInt(tpcData(11)) * 256))
            result.Encoding = CInt(tpcData(12))
            result.MipMapCount = CInt(tpcData(13))

            Array.Copy(tpcData, 128, tpcData, 0, tpcData.Length - 128)

            Dim decodeCommand As Integer = 0

            If (result.DataSize = 0) And (result.Encoding = 2) And (result.MipMapCount = 1) Then
                result.NeedToFlipForWriting = False
                Me.SwapRedBlueChannels(tpcData, CInt(result.XSize * result.YSize), 3)
                result.PixelData = CType(Array.CreateInstance(GetType(Byte), tpcData.Length), Byte())
                Array.Copy(tpcData, result.PixelData, tpcData.Length)

                Dim pixelArray As Array = result.PixelData
                clsImageSystem.FlipImageVertically(pixelArray, CInt((3S * result.XSize)), CInt(result.YSize))
                result.PixelData = CType(pixelArray, Byte())
            ElseIf (result.DataSize = 0) And (result.Encoding = 4) And (result.MipMapCount = 1) Then
                result.NeedToFlipForWriting = False
                Me.SwapRedBlueChannels(tpcData, CInt(result.XSize) * CInt(result.YSize), 4)
                result.PixelData = CType(Array.CreateInstance(GetType(Byte), tpcData.Length), Byte())
                Array.Copy(tpcData, result.PixelData, tpcData.Length)

                Dim pixelArray As Array = result.PixelData
                clsImageSystem.FlipImageVertically(pixelArray, CInt((4S * result.XSize)), CInt(result.YSize))
                result.PixelData = CType(pixelArray, Byte())
            ElseIf (result.Encoding = 2) Or (result.Encoding = 4) Then
                result.NeedToFlipForWriting = True

                Dim pixelDataLength As Long() = New Long() {CLng(result.XSize)}
                pixelDataLength(0) = pixelDataLength(0) * CLng(result.YSize)
                pixelDataLength(0) = pixelDataLength(0) * 4L
                result.PixelData = CType(Array.CreateInstance(GetType(Byte), pixelDataLength), Byte())

                If result.Encoding = 2 Then
                    decodeCommand = 1
                ElseIf result.Encoding = 4 Then
                    decodeCommand = 5
                End If
            End If

            If (result.DataSize > 0) And ((result.Encoding = 2) Or (result.Encoding = 4)) Then
                Dim tpcTool As TpcTool = New TpcTool()
                Dim sourceHandle As GCHandle = GCHandle.Alloc(tpcData, GCHandleType.Pinned)
                Dim outputHandle As GCHandle = GCHandle.Alloc(result.PixelData, GCHandleType.Pinned)

                Try
                    tpcTool.foo(sourceHandle.AddrOfPinnedObject(), outputHandle.AddrOfPinnedObject(), CInt(result.XSize), CInt(result.YSize), decodeCommand)
                Finally
                    sourceHandle.Free()
                    outputHandle.Free()
                End Try
            End If

            If (result.DataSize = 0) And (result.Encoding = 2) And (result.MipMapCount = 1) Then
                result.BytesPerPixel = 3
                result.PixelFormat = PixelFormat.Format24bppRgb
            ElseIf (result.DataSize = 0) And (result.Encoding = 4) And (result.MipMapCount = 1) Then
                result.BytesPerPixel = 4
                result.PixelFormat = PixelFormat.Format32bppArgb
            Else
                result.BytesPerPixel = 4
                result.PixelFormat = PixelFormat.Format32bppArgb
                result.ImageInfoText = Me.ReadImageInfoText(tpcData, result.MipMapCount, result.Encoding)
            End If

            result.TPCData = tpcData
            Return result
        End Function

        Public Function MipLevel2Bytes(ByVal mipLevel As Integer, ByVal dxtBytesPerTexel As Integer) As Integer
            Dim value As Integer = 0

            Select Case mipLevel
                Case 1
                    value = 16
                Case 2
                    value = 32
                Case 3
                    value = 48
                Case 4
                    value = 112
                Case 5
                    value = 368
                Case 6
                    value = 1392
                Case 7
                    value = 5488
                Case 8
                    value = 21872
                Case 9
                    value = 87408
                Case 10
                    value = 349552
                Case 11
                    value = 1398128
            End Select

            Return CInt(Math.Round(CDbl(value) / (16.0 / CDbl(dxtBytesPerTexel))))
        End Function

        Public Sub WriteFile(ByVal outputPath As String, ByVal tpcData As Byte())
            File.WriteAllBytes(outputPath, tpcData)
        End Sub

        Private Sub SwapRedBlueChannels(ByVal pixelData As Byte(), ByVal pixelCount As Integer, ByVal bytesPerPixel As Integer)
            For i As Integer = 0 To pixelCount - 1
                Dim pixelOffset As Integer = i * bytesPerPixel
                Dim blue As Byte = pixelData(pixelOffset)
                pixelData(pixelOffset) = pixelData(pixelOffset + 2)
                pixelData(pixelOffset + 2) = blue
            Next
        End Sub

        Private Function ReadImageInfoText(ByVal tpcData As Byte(), ByVal mipMapCount As Integer, ByVal encoding As Integer) As String
            Dim imageInfoOffset As Integer = 128 + Me.MipLevel2Bytes(mipMapCount, encoding * 4)
            Dim imageInfoLength As Object = tpcData.Length - imageInfoOffset

            If ObjectType.ObjTst(imageInfoLength, 0, False) > 0 Then
                Dim asciiEncoding As ASCIIEncoding = New ASCIIEncoding()
                Return asciiEncoding.GetString(tpcData, imageInfoOffset, IntegerType.FromObject(imageInfoLength))
            End If

            Return ""
        End Function
    End Class
End Namespace
