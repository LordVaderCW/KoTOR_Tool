Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200004E RID: 78
	Public Partial Class frmImageViewer
		Inherits Form

		' Token: 0x06000552 RID: 1362 RVA: 0x00242FAC File Offset: 0x00241FAC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmImageViewer_Load
			AddHandler MyBase.Closing, AddressOf Me.frmImageViewer_Closing
			Me.InitializeComponent()
		End Sub

        ' Token: 0x0600056F RID: 1391 RVA: 0x00243B00 File Offset: 0x00242B00
        Public Sub SetupPixelArray(ByVal data As Array)
            Me.PxData = CType(Array.CreateInstance(GetType(Byte), data.Length), Byte())
            Array.Copy(data, Me.PxData, data.Length)
        End Sub

        ' Token: 0x06000570 RID: 1392 RVA: 0x00243B34 File Offset: 0x00242B34
        Public Sub SetupTPCData(ByVal data As Array, ByVal filename As String)
            Me.TPCData = CType(Array.CreateInstance(GetType(Byte), data.Length), Byte())
            Array.Copy(data, Me.TPCData, data.Length)
            Me.fname = filename
        End Sub

        ' Token: 0x06000571 RID: 1393 RVA: 0x00243B70 File Offset: 0x00242B70
        Public Sub ShowImage(ByVal BytesPerPixel As Integer, ByVal pxFormat As PixelFormat)
            If Me.ghImage.IsAllocated Then
                Me.ghImage.Free()
            End If
            Me.ghImage = GCHandle.Alloc(Me.Pixeldata, GCHandleType.Pinned)
            Dim intPtr As IntPtr = Me.ghImage.AddrOfPinnedObject()
            Try
                Dim bitmap As Bitmap = New Bitmap(CInt(Me._xSize), CInt(Me._ySize), BytesPerPixel * CInt(Me._xSize), pxFormat, intPtr)
                Me.pbox.Image = bitmap
            Catch ex As System.Exception
                Interaction.MsgBox("Cannot view this image", MsgBoxStyle.Critical, "Weirdness Alert")
            End Try
            Dim pbox As Control = Me.pbox
            Dim size As Size = New Size(CInt(Me._xSize), CInt(Me._ySize))
            pbox.Size = size
            Me._BitsPerPixel = CShort((BytesPerPixel * 8))
            Me.Text = "Image Viewer: " + Me.fname
        End Sub

        ' Token: 0x06000572 RID: 1394 RVA: 0x00243C4C File Offset: 0x00242C4C
        'Public Sub DecodeImage()
        '    ' The following expression was wrapped in a checked-statement
        '    Me.dataSize = CInt(Math.Round(CDbl(Me.TPCData(0)) + CDbl(Me.TPCData(1)) * 256.0 + CDbl(Me.TPCData(2)) * 65536.0 + CDbl(Me.TPCData(3)) * 16777216.0))
        '    Me.flag1 = Me.TPCData(4)
        '    Me.flag2 = Me.TPCData(5)
        '    Me.flag3 = Me.TPCData(6)
        '    Me.flag4 = Me.TPCData(7)
        '    Me._xSize = CShort((CInt(Me.TPCData(8)) + CInt(Me.TPCData(9)) * 256))
        '    Me._ySize = CShort((CInt(Me.TPCData(10)) + CInt(Me.TPCData(11)) * 256))
        '    Me.encoding1 = CInt(Me.TPCData(12))
        '    Me.mipmapCnt = CInt(Me.TPCData(13))
        '    Array.Copy(Me.TPCData, 128, Me.TPCData, 0, Me.TPCData.Length - 128)
        '    Dim num7 As Integer
        '    If (Me.dataSize = 0) And (Me.encoding1 = 2) And (Me.mipmapCnt = 1) Then
        '        Me.bNeedToFlipForWriting = False
        '        Dim num As Integer = 0
        '        Dim num2 As Integer = CInt((Me._xSize * Me._ySize - 1S))
        '        For i As Integer = num To num2
        '            Dim b As Byte = Me.TPCData(i * 3)
        '            Me.TPCData(i * 3) = Me.TPCData(i * 3 + 2)
        '            Me.TPCData(i * 3 + 2) = b
        '        Next
        '        Me.Pixeldata = CType(array.CreateInstance(GetType(Byte), Me.TPCData.Length), Byte())
        '        array.Copy(Me.TPCData, Me.Pixeldata, Me.TPCData.Length)
        '        Dim array As Array = Me.Pixeldata
        '        Me.FlipImageVertically(array, CInt((3S * Me._xSize)), CInt(Me._ySize))
        '        Me.Pixeldata = CType(array, Byte())
        '    ElseIf (Me.dataSize = 0) And (Me.encoding1 = 4) And (Me.mipmapCnt = 1) Then
        '        Me.bNeedToFlipForWriting = False
        '        Dim num3 As Integer = CInt(Me._xSize)
        '        num3 *= CInt(Me._ySize)
        '        Dim num4 As Integer = 0
        '        Dim num5 As Integer = num3 - 1
        '        For j As Integer = num4 To num5
        '            Dim b2 As Byte = Me.TPCData(j * 4)
        '            Me.TPCData(j * 4) = Me.TPCData(j * 4 + 2)
        '            Me.TPCData(j * 4 + 2) = b2
        '        Next
        '        Me.Pixeldata = CType(array.CreateInstance(GetType(Byte), Me.TPCData.Length), Byte())
        '        array.Copy(Me.TPCData, Me.Pixeldata, Me.TPCData.Length)
        '        Dim array As Array = Me.Pixeldata
        '        Me.FlipImageVertically(array, CInt((4S * Me._xSize)), CInt(Me._ySize))
        '        Me.Pixeldata = CType(array, Byte())
        '    ElseIf (Me.encoding1 = 2) Or (Me.encoding1 = 4) Then
        '        Me.bNeedToFlipForWriting = True
        '        Dim array2 As Long() = New Long() {CLng(Me._xSize)}
        '        Dim array3 As Long() = array2
        '        Dim num6 As Integer = 0
        '        array3(num6) = array2(num6) * CLng(Me._ySize)
        '        Dim array4 As Long() = array2
        '        num6 = 0
        '        array4(num6) = array2(num6) * 4L
        '        Me.Pixeldata = CType(Array.CreateInstance(GetType(Byte), array2), Byte())
        '        If Me.encoding1 = 2 Then
        '            num7 = 1
        '        ElseIf Me.encoding1 = 4 Then
        '            num7 = 5
        '        End If
        '    End If
        '    If (Me.dataSize > 0) And ((Me.encoding1 = 2) Or (Me.encoding1 = 4)) Then
        '        Dim tpcTool As TpcTool = New TpcTool()
        '        Dim gchandle As GCHandle = gchandle.Alloc(Me.TPCData, GCHandleType.Pinned)
        '        Dim gchandle2 As GCHandle = gchandle.Alloc(Me.Pixeldata, GCHandleType.Pinned)
        '        Dim intPtr As IntPtr = gchandle.AddrOfPinnedObject()
        '        Dim intPtr2 As IntPtr = gchandle2.AddrOfPinnedObject()
        '        tpcTool.foo(intPtr, intPtr2, CInt(Me._xSize), CInt(Me._ySize), num7)
        '        gchandle.Free()
        '        gchandle2.Free()
        '    End If
        '    If (Me.dataSize = 0) And (Me.encoding1 = 2) And (Me.mipmapCnt = 1) Then
        '        Me.ShowImage(3, PixelFormat.Format24bppRgb)
        '    ElseIf (Me.dataSize = 0) And (Me.encoding1 = 4) And (Me.mipmapCnt = 1) Then
        '        Me.ShowImage(4, PixelFormat.Format32bppArgb)
        '    Else
        '        Me.ShowImage(4, PixelFormat.Format32bppArgb)
        '        Dim num8 As Integer = 128 + Me.MipLevel2Bytes(Me.mipmapCnt, Me.encoding1 * 4)
        '        Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
        '        Dim obj As Object = Me.TPCData.Length - num8
        '        If ObjectType.ObjTst(obj, 0, False) > 0 Then
        '            Dim [string] As String = asciiencoding.GetString(Me.TPCData, num8, IntegerType.FromObject(obj))
        '            Me.tbImageInfo.Text = [string]
        '        Else
        '            Me.tbImageInfo.Text = ""
        '        End If
        '    End If
        '    Me.lblMipMapCount.Text = StringType.FromInteger(Me.mipmapCnt)
        '    Me.lblFlag1.Text = Strings.Format(Me.flag1, "x")
        '    Me.lblFlag2.Text = Strings.Format(Me.flag2, "x")
        '    Me.lblFlag3.Text = Strings.Format(Me.flag3, "x")
        '    Me.lblFlag4.Text = Strings.Format(Me.flag4, "x")
        'End Sub


        ' Token: 0x06000572 RID: 1394 RVA: 0x00243C4C File Offset: 0x00242C4C
        Public Sub DecodeImage()
            ' The following expression was wrapped in a checked-statement

            Me.dataSize = CInt(Math.Round(CDbl(Me.TPCData(0)) + CDbl(Me.TPCData(1)) * 256.0 + CDbl(Me.TPCData(2)) * 65536.0 + CDbl(Me.TPCData(3)) * 16777216.0))
            Me.flag1 = Me.TPCData(4)
            Me.flag2 = Me.TPCData(5)
            Me.flag3 = Me.TPCData(6)
            Me.flag4 = Me.TPCData(7)

            Me._xSize = CShort((CInt(Me.TPCData(8)) + CInt(Me.TPCData(9)) * 256))
            Me._ySize = CShort((CInt(Me.TPCData(10)) + CInt(Me.TPCData(11)) * 256))

            Me.encoding1 = CInt(Me.TPCData(12))
            Me.mipmapCnt = CInt(Me.TPCData(13))

            System.Array.Copy(Me.TPCData, 128, Me.TPCData, 0, Me.TPCData.Length - 128)

            Dim num7 As Integer = 0

            If (Me.dataSize = 0) And (Me.encoding1 = 2) And (Me.mipmapCnt = 1) Then

                Me.bNeedToFlipForWriting = False

                Dim num As Integer = 0
                Dim num2 As Integer = CInt((Me._xSize * Me._ySize - 1S))

                For i As Integer = num To num2
                    Dim b As Byte = Me.TPCData(i * 3)
                    Me.TPCData(i * 3) = Me.TPCData(i * 3 + 2)
                    Me.TPCData(i * 3 + 2) = b
                Next

                Me.Pixeldata = CType(System.Array.CreateInstance(GetType(Byte), Me.TPCData.Length), Byte())
                System.Array.Copy(Me.TPCData, Me.Pixeldata, Me.TPCData.Length)

                Dim pixelArray As Array = Me.Pixeldata
                Me.FlipImageVertically(pixelArray, CInt((3S * Me._xSize)), CInt(Me._ySize))
                Me.Pixeldata = CType(pixelArray, Byte())

            ElseIf (Me.dataSize = 0) And (Me.encoding1 = 4) And (Me.mipmapCnt = 1) Then

                Me.bNeedToFlipForWriting = False

                Dim num3 As Integer = CInt(Me._xSize)
                num3 *= CInt(Me._ySize)

                Dim num4 As Integer = 0
                Dim num5 As Integer = num3 - 1

                For j As Integer = num4 To num5
                    Dim b2 As Byte = Me.TPCData(j * 4)
                    Me.TPCData(j * 4) = Me.TPCData(j * 4 + 2)
                    Me.TPCData(j * 4 + 2) = b2
                Next

                Me.Pixeldata = CType(System.Array.CreateInstance(GetType(Byte), Me.TPCData.Length), Byte())
                System.Array.Copy(Me.TPCData, Me.Pixeldata, Me.TPCData.Length)

                Dim pixelArray As Array = Me.Pixeldata
                Me.FlipImageVertically(pixelArray, CInt((4S * Me._xSize)), CInt(Me._ySize))
                Me.Pixeldata = CType(pixelArray, Byte())

            ElseIf (Me.encoding1 = 2) Or (Me.encoding1 = 4) Then

                Me.bNeedToFlipForWriting = True

                Dim array2 As Long() = New Long() {CLng(Me._xSize)}
                Dim array3 As Long() = array2

                Dim num6 As Integer = 0
                array3(num6) = array2(num6) * CLng(Me._ySize)

                Dim array4 As Long() = array2
                num6 = 0
                array4(num6) = array2(num6) * 4L

                Me.Pixeldata = CType(System.Array.CreateInstance(GetType(Byte), array2), Byte())

                If Me.encoding1 = 2 Then
                    num7 = 1
                ElseIf Me.encoding1 = 4 Then
                    num7 = 5
                End If

            End If

            If (Me.dataSize > 0) And ((Me.encoding1 = 2) Or (Me.encoding1 = 4)) Then

                Dim tpcTool As TpcTool = New TpcTool()

                Dim gchandle As GCHandle = GCHandle.Alloc(Me.TPCData, GCHandleType.Pinned)
                Dim gchandle2 As GCHandle = GCHandle.Alloc(Me.Pixeldata, GCHandleType.Pinned)

                Dim intPtr As IntPtr = gchandle.AddrOfPinnedObject()
                Dim intPtr2 As IntPtr = gchandle2.AddrOfPinnedObject()

                tpcTool.foo(intPtr, intPtr2, CInt(Me._xSize), CInt(Me._ySize), num7)

                gchandle.Free()
                gchandle2.Free()

            End If

            If (Me.dataSize = 0) And (Me.encoding1 = 2) And (Me.mipmapCnt = 1) Then

                Me.ShowImage(3, PixelFormat.Format24bppRgb)

            ElseIf (Me.dataSize = 0) And (Me.encoding1 = 4) And (Me.mipmapCnt = 1) Then

                Me.ShowImage(4, PixelFormat.Format32bppArgb)

            Else

                Me.ShowImage(4, PixelFormat.Format32bppArgb)

                Dim num8 As Integer = 128 + Me.MipLevel2Bytes(Me.mipmapCnt, Me.encoding1 * 4)
                Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
                Dim obj As Object = Me.TPCData.Length - num8

                If ObjectType.ObjTst(obj, 0, False) > 0 Then
                    Dim imageInfoText As String = asciiencoding.GetString(Me.TPCData, num8, IntegerType.FromObject(obj))
                    Me.tbImageInfo.Text = imageInfoText
                Else
                    Me.tbImageInfo.Text = ""
                End If

            End If

            Me.lblMipMapCount.Text = StringType.FromInteger(Me.mipmapCnt)
            Me.lblFlag1.Text = Strings.Format(Me.flag1, "x")
            Me.lblFlag2.Text = Strings.Format(Me.flag2, "x")
            Me.lblFlag3.Text = Strings.Format(Me.flag3, "x")
            Me.lblFlag4.Text = Strings.Format(Me.flag4, "x")

        End Sub

        ' Token: 0x06000573 RID: 1395 RVA: 0x002441D8 File Offset: 0x002431D8
        Public Function MipLevel2Bytes(ByVal miplevel As Integer, ByVal dxtBytesPerTexel As Integer) As Integer
            Dim num As Integer
            Select Case miplevel
                Case 1
                    num = 16
                Case 2
                    num = 32
                Case 3
                    num = 48
                Case 4
                    num = 112
                Case 5
                    num = 368
                Case 6
                    num = 1392
                Case 7
                    num = 5488
                Case 8
                    num = 21872
                Case 9
                    num = 87408
                Case 10
                    num = 349552
                Case 11
                    num = 1398128
            End Select
            Return CInt(Math.Round(CDbl(num) / (16.0 / CDbl(dxtBytesPerTexel))))
        End Function

        '' Token: 0x06000574 RID: 1396 RVA: 0x0024427C File Offset: 0x0024327C
        'Public Sub FlipImageVertically(ByRef PixelData As Array, ByVal stride As Integer, ByVal ySize As Integer)
        '    Dim array As Array = array.CreateInstance(GetType(Byte), stride)
        '    Dim num As Integer = 0
        '    Dim num2 As Integer = CInt(Math.Round(CDbl(ySize) / 2.0 - 1.0))
        '    For i As Integer = num To num2
        '        array.Copy(PixelData, i * stride, array, 0, stride)
        '        array.Copy(PixelData, (ySize - i - 1) * stride, PixelData, i * stride, stride)
        '        array.Copy(array, 0, PixelData, (ySize - i - 1) * stride, stride)
        '    Next
        'End Sub

        ' Token: 0x06000574 RID: 1396 RVA: 0x0024427C File Offset: 0x0024327C
        Public Sub FlipImageVertically(ByRef PixelData As Array, ByVal stride As Integer, ByVal ySize As Integer)

            Dim tempRow As Array = System.Array.CreateInstance(GetType(Byte), stride)

            Dim num As Integer = 0
            Dim num2 As Integer = CInt(Math.Round(CDbl(ySize) / 2.0 - 1.0))

            For i As Integer = num To num2
                System.Array.Copy(PixelData, i * stride, tempRow, 0, stride)
                System.Array.Copy(PixelData, (ySize - i - 1) * stride, PixelData, i * stride, stride)
                System.Array.Copy(tempRow, 0, PixelData, (ySize - i - 1) * stride, stride)
            Next

        End Sub

        ' Token: 0x06000575 RID: 1397 RVA: 0x002442F8 File Offset: 0x002432F8
        Private Sub btnWriteFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnWriteFile.Click
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, Strings.Mid(Me.fname, 1, Me.fname.IndexOf(".")) + ".tga", "Save TGA file...", "tga", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim fileStream As FileStream = New FileStream(text, FileMode.Create)
            Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)
            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(2)
            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(Me._xSize)
            binaryWriter.Write(Me._ySize)
            binaryWriter.Write(Me._BitsPerPixel)
            If Me.dataSize > 0 Then
                Dim pixeldata As Array = Me.Pixeldata
                Me.FlipImageVertically(pixeldata, CInt((4S * Me._xSize)), CInt(Me._ySize))
                Me.Pixeldata = CType(pixeldata, Byte())
                binaryWriter.Write(Me.Pixeldata)
            Else
                binaryWriter.Write(Me.TPCData)
            End If
            binaryWriter.Close()
            If Me.tbImageInfo.SelectionLength > 0 AndAlso Me.chkbExportSelectionToTXIfile.Checked Then
                text = Strings.Replace(text, ".tga", ".txi", 1, -1, CompareMethod.Binary)
                fileStream = New FileStream(text, FileMode.Create)
                Dim streamWriter As StreamWriter = New StreamWriter(fileStream, Encoding.ASCII)
                streamWriter.Write(Me.tbImageInfo.SelectedText)
                streamWriter.Close()
            End If
        End Sub

        ' Token: 0x06000576 RID: 1398 RVA: 0x00244474 File Offset: 0x00243474
        Public Sub WriteTGAFile(ByVal outputPath As String)
            Dim fileStream As FileStream = New FileStream(outputPath, FileMode.Create)
            Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)
            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(2)
            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(0)
            binaryWriter.Write(Me._xSize)
            binaryWriter.Write(Me._ySize)
            binaryWriter.Write(Me._BitsPerPixel)
            If Me.dataSize > 0 Then
                Dim pixeldata As Array = Me.Pixeldata
                Me.FlipImageVertically(pixeldata, CInt((4S * Me._xSize)), CInt(Me._ySize))
                Me.Pixeldata = CType(pixeldata, Byte())
                binaryWriter.Write(Me.Pixeldata)
            Else
                binaryWriter.Write(Me.TPCData)
            End If
            binaryWriter.Close()
        End Sub

        ' Token: 0x06000577 RID: 1399 RVA: 0x00244538 File Offset: 0x00243538
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            If Me.ghImage.IsAllocated Then
                Me.ghImage.Free()
            End If
            Me.Hide()
        End Sub

        ' Token: 0x06000578 RID: 1400 RVA: 0x00244558 File Offset: 0x00243558
        Public Sub PositionWindow()
            If Not frmMain.CurrentSettings.ImageViewerWindowLoc.IsEmpty Then
                Dim imageViewerWindowLoc As Point = frmMain.CurrentSettings.ImageViewerWindowLoc
                Dim point As Point
                If imageViewerWindowLoc.X < 0 Then
                    Dim currentSettings As Options = frmMain.CurrentSettings
                    point = New Point(10, 10)
                    currentSettings.ImageViewerWindowLoc = point
                End If
                point = frmMain.CurrentSettings.ImageViewerWindowLoc
                If point.Y < 0 Then
                    Dim currentSettings2 As Options = frmMain.CurrentSettings
                    imageViewerWindowLoc = New Point(10, 10)
                    currentSettings2.ImageViewerWindowLoc = imageViewerWindowLoc
                End If
                Me.Location = frmMain.CurrentSettings.ImageViewerWindowLoc
            End If
            If Not frmMain.CurrentSettings.ImageViewerWindowSize.IsEmpty Then
                Dim size As Size = frmMain.CurrentSettings.ImageViewerWindowSize
                Dim height As Integer
                Dim size2 As Size
                If size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                    Dim point As Point = Me.Location
                    Dim imageViewerWindowLoc As Point = New Point(point.X, Screen.PrimaryScreen.WorkingArea.Top)
                    Me.Location = imageViewerWindowLoc
                    height = Screen.PrimaryScreen.WorkingArea.Height
                    size = Me.Size
                    size2 = New Size(size.Width, height)
                    Me.Size = size2
                End If
                size2 = frmMain.CurrentSettings.ImageViewerWindowSize
                Dim width As Integer
                If size2.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                    Dim left As Integer = Screen.PrimaryScreen.WorkingArea.Left
                    Dim point As Point = Me.Location
                    Dim imageViewerWindowLoc As Point = New Point(left, point.Y)
                    Me.Location = imageViewerWindowLoc
                    width = Screen.PrimaryScreen.WorkingArea.Width
                    Dim num As Integer = width
                    size2 = Me.Size
                    size = New Size(num, size2.Height)
                    Me.Size = size
                End If
                If (width = 0) And (height = 0) Then
                    Me.Size = frmMain.CurrentSettings.ImageViewerWindowSize
                End If
            End If
        End Sub

        ' Token: 0x06000579 RID: 1401 RVA: 0x00244728 File Offset: 0x00243728
        Public Sub SaveSettings()
            frmMain.CurrentSettings.ImageViewerWindowLoc = Me.Location
            frmMain.CurrentSettings.ImageViewerWindowSize = Me.Size
        End Sub

        ' Token: 0x0600057A RID: 1402 RVA: 0x0024474C File Offset: 0x0024374C
        Private Sub frmImageViewer_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow()
        End Sub

        ' Token: 0x0600057B RID: 1403 RVA: 0x00244754 File Offset: 0x00243754
        Private Sub frmImageViewer_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings()
        End Sub

        ' Token: 0x040002E2 RID: 738
        Public PxData As Byte()

        ' Token: 0x040002E3 RID: 739
        Public TPCData As Byte()

        ' Token: 0x040002E4 RID: 740
        Public Pixeldata As Byte()

        ' Token: 0x040002E5 RID: 741
        Private _xSize As Short

        ' Token: 0x040002E6 RID: 742
        Private _ySize As Short

        ' Token: 0x040002E7 RID: 743
        Private _BitsPerPixel As Short

        ' Token: 0x040002E8 RID: 744
        Private fname As String

        ' Token: 0x040002E9 RID: 745
        Private ghImage As GCHandle

        ' Token: 0x040002EA RID: 746
        Private bNeedToFlipForWriting As Boolean

        ' Token: 0x040002EB RID: 747
        Private dataSize As Integer

        ' Token: 0x040002EC RID: 748
        Private encoding1 As Integer

        ' Token: 0x040002ED RID: 749
        Private mipmapCnt As Integer

        ' Token: 0x040002EE RID: 750
        Private decode_cmd As Integer

        ' Token: 0x040002EF RID: 751
        Private flag1 As Byte

        ' Token: 0x040002F0 RID: 752
        Private flag2 As Byte

        ' Token: 0x040002F1 RID: 753
        Private flag3 As Byte

        ' Token: 0x040002F2 RID: 754
        Private flag4 As Byte
    End Class
End Namespace
