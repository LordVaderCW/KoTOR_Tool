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

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x06000555 RID: 1365 RVA: 0x00243000 File Offset: 0x00242000
		' (set) Token: 0x06000554 RID: 1364 RVA: 0x00243014 File Offset: 0x00242014
		Friend Overridable Property pbox As PictureBox
			Get
				Return Me._pbox
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As PictureBox)
                If Me._pbox IsNot Nothing Then
                End If
                Me._pbox = value
                If Me._pbox IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000194 RID: 404
        ' (get) Token: 0x06000556 RID: 1366 RVA: 0x00243030 File Offset: 0x00242030
        ' (set) Token: 0x06000557 RID: 1367 RVA: 0x00243044 File Offset: 0x00242044
        Friend Overridable Property btnOK() As Button
            Get
                Return Me._btnOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                    RemoveHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                    AddHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
            End Set
        End Property

        ' Token: 0x17000195 RID: 405
        ' (get) Token: 0x06000558 RID: 1368 RVA: 0x002430B4 File Offset: 0x002420B4
        ' (set) Token: 0x06000559 RID: 1369 RVA: 0x00243098 File Offset: 0x00242098
        Friend Overridable Property Panel1() As Panel
            Get
                Return Me._Panel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Panel)
                If Me._Panel1 IsNot Nothing Then
                End If
                Me._Panel1 = value
                If Me._Panel1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000196 RID: 406
        ' (get) Token: 0x0600055B RID: 1371 RVA: 0x002430C8 File Offset: 0x002420C8
        ' (set) Token: 0x0600055A RID: 1370 RVA: 0x002430DC File Offset: 0x002420DC
        Friend Overridable Property tbImageInfo() As TextBox
            Get
                Return Me._tbImageInfo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbImageInfo IsNot Nothing Then
                End If
                Me._tbImageInfo = value
                If Me._tbImageInfo IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000197 RID: 407
        ' (get) Token: 0x0600055D RID: 1373 RVA: 0x002430F8 File Offset: 0x002420F8
        ' (set) Token: 0x0600055C RID: 1372 RVA: 0x0024310C File Offset: 0x0024210C
        Friend Overridable Property Label1() As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label1 IsNot Nothing Then
                End If
                Me._Label1 = value
                If Me._Label1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000198 RID: 408
        ' (get) Token: 0x0600055E RID: 1374 RVA: 0x00243144 File Offset: 0x00242144
        ' (set) Token: 0x0600055F RID: 1375 RVA: 0x00243128 File Offset: 0x00242128
        Friend Overridable Property lblMipMapCount() As Label
            Get
                Return Me._lblMipMapCount
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblMipMapCount IsNot Nothing Then
                End If
                Me._lblMipMapCount = value
                If Me._lblMipMapCount IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000199 RID: 409
        ' (get) Token: 0x06000561 RID: 1377 RVA: 0x00243174 File Offset: 0x00242174
        ' (set) Token: 0x06000560 RID: 1376 RVA: 0x00243158 File Offset: 0x00242158
        Friend Overridable Property Label2() As Label
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label2 IsNot Nothing Then
                End If
                Me._Label2 = value
                If Me._Label2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700019A RID: 410
        ' (get) Token: 0x06000563 RID: 1379 RVA: 0x00243188 File Offset: 0x00242188
        ' (set) Token: 0x06000562 RID: 1378 RVA: 0x0024319C File Offset: 0x0024219C
        Friend Overridable Property btnWriteFile() As Button
            Get
                Return Me._btnWriteFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnWriteFile IsNot Nothing Then
                    RemoveHandler Me._btnWriteFile.Click, AddressOf Me.btnWriteFile_Click
                End If
                Me._btnWriteFile = value
                If Me._btnWriteFile IsNot Nothing Then
                    AddHandler Me._btnWriteFile.Click, AddressOf Me.btnWriteFile_Click
                End If
            End Set
        End Property

        ' Token: 0x1700019B RID: 411
        ' (get) Token: 0x06000565 RID: 1381 RVA: 0x0024320C File Offset: 0x0024220C
        ' (set) Token: 0x06000564 RID: 1380 RVA: 0x002431F0 File Offset: 0x002421F0
        Friend Overridable Property lblFlag1() As Label
            Get
                Return Me._lblFlag1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblFlag1 IsNot Nothing Then
                End If
                Me._lblFlag1 = value
                If Me._lblFlag1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700019C RID: 412
        ' (get) Token: 0x06000566 RID: 1382 RVA: 0x00243220 File Offset: 0x00242220
        ' (set) Token: 0x06000567 RID: 1383 RVA: 0x00243234 File Offset: 0x00242234
        Friend Overridable Property lblFlag2() As Label
            Get
                Return Me._lblFlag2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblFlag2 IsNot Nothing Then
                End If
                Me._lblFlag2 = value
                If Me._lblFlag2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700019D RID: 413
        ' (get) Token: 0x06000569 RID: 1385 RVA: 0x0024326C File Offset: 0x0024226C
        ' (set) Token: 0x06000568 RID: 1384 RVA: 0x00243250 File Offset: 0x00242250
        Friend Overridable Property lblFlag3() As Label
            Get
                Return Me._lblFlag3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblFlag3 IsNot Nothing Then
                End If
                Me._lblFlag3 = value
                If Me._lblFlag3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700019E RID: 414
        ' (get) Token: 0x0600056B RID: 1387 RVA: 0x00243280 File Offset: 0x00242280
        ' (set) Token: 0x0600056A RID: 1386 RVA: 0x00243294 File Offset: 0x00242294
        Friend Overridable Property lblFlag4() As Label
            Get
                Return Me._lblFlag4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblFlag4 IsNot Nothing Then
                End If
                Me._lblFlag4 = value
                If Me._lblFlag4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700019F RID: 415
        ' (get) Token: 0x0600056C RID: 1388 RVA: 0x002432B0 File Offset: 0x002422B0
        ' (set) Token: 0x0600056D RID: 1389 RVA: 0x002432C4 File Offset: 0x002422C4
        Friend Overridable Property chkbExportSelectionToTXIfile() As CheckBox
            Get
                Return Me._chkbExportSelectionToTXIfile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbExportSelectionToTXIfile IsNot Nothing Then
                End If
                Me._chkbExportSelectionToTXIfile = value
                If Me._chkbExportSelectionToTXIfile IsNot Nothing Then
                End If
            End Set
        End Property

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
        Private Sub btnWriteFile_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
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

        ' Token: 0x040002D4 RID: 724
        <AccessedThroughProperty("btnWriteFile")> _
        Private _btnWriteFile As Button

        ' Token: 0x040002D5 RID: 725
        <AccessedThroughProperty("lblMipMapCount")> _
        Private _lblMipMapCount As Label

        ' Token: 0x040002D6 RID: 726
        <AccessedThroughProperty("lblFlag1")> _
        Private _lblFlag1 As Label

        ' Token: 0x040002D7 RID: 727
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040002D8 RID: 728
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040002D9 RID: 729
        <AccessedThroughProperty("lblFlag2")> _
        Private _lblFlag2 As Label

        ' Token: 0x040002DA RID: 730
        <AccessedThroughProperty("Panel1")> _
        Private _Panel1 As Panel

        ' Token: 0x040002DB RID: 731
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x040002DC RID: 732
        <AccessedThroughProperty("tbImageInfo")> _
        Private _tbImageInfo As TextBox

        ' Token: 0x040002DD RID: 733
        <AccessedThroughProperty("chkbExportSelectionToTXIfile")> _
        Private _chkbExportSelectionToTXIfile As CheckBox

        ' Token: 0x040002DE RID: 734
        <AccessedThroughProperty("pbox")> _
        Private _pbox As PictureBox

        ' Token: 0x040002DF RID: 735
        <AccessedThroughProperty("lblFlag3")> _
        Private _lblFlag3 As Label

        ' Token: 0x040002E0 RID: 736
        <AccessedThroughProperty("lblFlag4")> _
        Private _lblFlag4 As Label

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
