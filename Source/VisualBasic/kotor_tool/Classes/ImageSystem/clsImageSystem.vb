Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Namespace kotor_tool
    Public Class clsImageSystem
        Private ReadOnly _jpgSystem As clsJPGSystem
        Private ReadOnly _pngSystem As clsPNGSystem
        Private ReadOnly _tgaSystem As clsTGASystem
        Private ReadOnly _tpcSystem As clsTPCSystem
        Private ReadOnly _txiSystem As clsTXISystem

        Public Sub New()
            Me._jpgSystem = New clsJPGSystem()
            Me._pngSystem = New clsPNGSystem()
            Me._tgaSystem = New clsTGASystem()
            Me._tpcSystem = New clsTPCSystem()
            Me._txiSystem = New clsTXISystem()
        End Sub

        Public Property PxData As Byte()
        Public Property TPCData As Byte()
        Public Property OriginalTPCData As Byte()
        Public Property PixelData As Byte()
        Public Property XSize As Short
        Public Property YSize As Short
        Public Property BitsPerPixel As Short
        Public Property FileName As String
        Public Property NeedToFlipForWriting As Boolean
        Public Property DataSize As Integer
        Public Property Encoding As Integer
        Public Property MipMapCount As Integer
        Public Property DecodeCommand As Integer
        Public Property Flag1 As Byte
        Public Property Flag2 As Byte
        Public Property Flag3 As Byte
        Public Property Flag4 As Byte

        Public Sub SetupPixelArray(ByVal data As Array)
            Me.PxData = CType(Array.CreateInstance(GetType(Byte), data.Length), Byte())
            Array.Copy(data, Me.PxData, data.Length)
        End Sub

        Public Sub SetupTPCData(ByVal data As Array, ByVal filename As String)
            Me.TPCData = CType(Array.CreateInstance(GetType(Byte), data.Length), Byte())
            Array.Copy(data, Me.TPCData, data.Length)
            Me.OriginalTPCData = CType(Array.CreateInstance(GetType(Byte), data.Length), Byte())
            Array.Copy(data, Me.OriginalTPCData, data.Length)
            Me.FileName = filename
        End Sub

        Public Function DecodeImage() As clsImageDecodeResult
            Dim result As clsImageDecodeResult = Me._tpcSystem.Decode(Me.TPCData)

            Me.TPCData = result.TPCData
            Me.PixelData = result.PixelData
            Me.XSize = result.XSize
            Me.YSize = result.YSize
            Me.BitsPerPixel = CShort(result.BytesPerPixel * 8)
            Me.NeedToFlipForWriting = result.NeedToFlipForWriting
            Me.DataSize = result.DataSize
            Me.Encoding = result.Encoding
            Me.MipMapCount = result.MipMapCount
            Me.Flag1 = result.Flag1
            Me.Flag2 = result.Flag2
            Me.Flag3 = result.Flag3
            Me.Flag4 = result.Flag4

            Return result
        End Function

        Public Function LoadJPGImage(ByVal imageData As Byte()) As Image
            Return Me._jpgSystem.LoadImage(imageData)
        End Function

        Public Function LoadPNGImage(ByVal imageData As Byte()) As Image
            Return Me._pngSystem.LoadImage(imageData)
        End Function

        Public Sub WriteTGAFile(ByVal outputPath As String)
            Me._tgaSystem.WriteFile(outputPath, Me.XSize, Me.YSize, Me.BitsPerPixel, Me.DataSize, Me.PixelData, Me.TPCData)
        End Sub

        Public Sub WritePNGFile(ByVal outputPath As String)
            Using bitmap As Bitmap = Me.CreateBitmap()
                Me._pngSystem.WriteFile(outputPath, bitmap)
            End Using
        End Sub

        Public Sub WriteJPGFile(ByVal outputPath As String)
            Using bitmap As Bitmap = Me.CreateBitmap()
                Me._jpgSystem.WriteFile(outputPath, bitmap)
            End Using
        End Sub

        Public Sub WriteTPCFile(ByVal outputPath As String)
            If Me.OriginalTPCData IsNot Nothing Then
                Me._tpcSystem.WriteFile(outputPath, Me.OriginalTPCData)
            Else
                Me._tpcSystem.WriteFile(outputPath, Me.TPCData)
            End If
        End Sub

        Public Sub WriteTXIFile(ByVal outputPath As String, ByVal text As String)
            Me._txiSystem.WriteFile(outputPath, text)
        End Sub

        Public Sub ExportImage(ByVal outputPath As String, ByVal formatName As String)
            Select Case formatName.ToUpperInvariant()
                Case "TGA"
                    Me.WriteTGAFile(outputPath)
                Case "PNG"
                    Me.WritePNGFile(outputPath)
                Case "JPG", "JPEG"
                    Me.WriteJPGFile(outputPath)
                Case "TPC"
                    Me.WriteTPCFile(outputPath)
                Case Else
                    Throw New NotSupportedException("Unsupported image export format: " + formatName)
            End Select
        End Sub

        Public Function DefaultExportName(ByVal formatName As String) As String
            Dim baseName As String = Path.GetFileNameWithoutExtension(Me.FileName)
            If String.IsNullOrEmpty(baseName) Then
                baseName = "image"
            End If

            Return baseName + "." + Me.ExportExtension(formatName)
        End Function

        Public Function ExportExtension(ByVal formatName As String) As String
            Select Case formatName.ToUpperInvariant()
                Case "JPG", "JPEG"
                    Return "jpg"
                Case "PNG"
                    Return "png"
                Case "TPC"
                    Return "tpc"
                Case Else
                    Return "tga"
            End Select
        End Function

        Public Function ExportDialogFilter(ByVal formatName As String) As String
            Return Me.ExportExtension(formatName)
        End Function

        Public Function ImageSummary() As String
            If Me.XSize = 0 OrElse Me.YSize = 0 Then
                Return ""
            End If

            Return String.Format("{0} x {1}  {2} bpp", Me.XSize, Me.YSize, Me.BitsPerPixel)
        End Function

        Private Function CreateBitmap() As Bitmap
            Dim pixelFormat As PixelFormat
            Dim bytesPerPixel As Integer

            If Me.BitsPerPixel = 24 Then
                pixelFormat = PixelFormat.Format24bppRgb
                bytesPerPixel = 3
            Else
                pixelFormat = PixelFormat.Format32bppArgb
                bytesPerPixel = 4
            End If

            Dim imageHandle As Runtime.InteropServices.GCHandle = Runtime.InteropServices.GCHandle.Alloc(Me.PixelData, Runtime.InteropServices.GCHandleType.Pinned)
            Try
                Using sourceBitmap As Bitmap = New Bitmap(CInt(Me.XSize), CInt(Me.YSize), bytesPerPixel * CInt(Me.XSize), pixelFormat, imageHandle.AddrOfPinnedObject())
                    Return New Bitmap(sourceBitmap)
                End Using
            Finally
                imageHandle.Free()
            End Try
        End Function

        Public Shared Sub FlipImageVertically(ByRef pixelData As Array, ByVal stride As Integer, ByVal ySize As Integer)
            Dim tempRow As Array = Array.CreateInstance(GetType(Byte), stride)
            Dim lastRowToSwap As Integer = CInt(Math.Round(CDbl(ySize) / 2.0 - 1.0))

            For i As Integer = 0 To lastRowToSwap
                Array.Copy(pixelData, i * stride, tempRow, 0, stride)
                Array.Copy(pixelData, (ySize - i - 1) * stride, pixelData, i * stride, stride)
                Array.Copy(tempRow, 0, pixelData, (ySize - i - 1) * stride, stride)
            Next
        End Sub
    End Class

    Public Class clsImageDecodeResult
        Public Property TPCData As Byte()
        Public Property PixelData As Byte()
        Public Property XSize As Short
        Public Property YSize As Short
        Public Property BytesPerPixel As Integer
        Public Property PixelFormat As PixelFormat
        Public Property ImageInfoText As String
        Public Property NeedToFlipForWriting As Boolean
        Public Property DataSize As Integer
        Public Property Encoding As Integer
        Public Property MipMapCount As Integer
        Public Property Flag1 As Byte
        Public Property Flag2 As Byte
        Public Property Flag3 As Byte
        Public Property Flag4 As Byte
    End Class
End Namespace
