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
    Partial Public Class frmImageViewer
        Inherits Form
        Private ReadOnly ImageSystem As clsImageSystem
        Private Const CustomPreviewMode As String = "Custom Zoom"
        Private Const MinPreviewZoom As Double = 0.1
        Private Const MaxPreviewZoom As Double = 16.0
        Private PreviewZoom As Double = 1.0
        Private SuppressPreviewModeChange As Boolean

        ' Token: 0x06000552 RID: 1362 RVA: 0x00242FAC File Offset: 0x00241FAC
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmImageViewer_Load
            AddHandler MyBase.Closing, AddressOf Me.frmImageViewer_Closing
            Me.ImageSystem = New clsImageSystem()
            Me.InitializeComponent()
            Me.ApplyApplicationIcon()
            Me.InitializeViewerControls()
        End Sub

        ' Token: 0x0600056F RID: 1391 RVA: 0x00243B00 File Offset: 0x00242B00
        Public Sub SetupPixelArray(ByVal data As Array)
            Me.ImageSystem.SetupPixelArray(data)
        End Sub

        ' Token: 0x06000570 RID: 1392 RVA: 0x00243B34 File Offset: 0x00242B34
        Public Sub SetupTPCData(ByVal data As Array, ByVal filename As String)
            Me.ImageSystem.SetupTPCData(data, filename)
        End Sub

        ' Token: 0x06000571 RID: 1393 RVA: 0x00243B70 File Offset: 0x00242B70
        Public Sub ShowImage(ByVal BytesPerPixel As Integer, ByVal pxFormat As PixelFormat)
            If Me.ghImage.IsAllocated Then
                Me.ghImage.Free()
            End If
            Me.ghImage = GCHandle.Alloc(Me.ImageSystem.PixelData, GCHandleType.Pinned)
            Dim intPtr As IntPtr = Me.ghImage.AddrOfPinnedObject()
            Try
                Dim bitmap As Bitmap = New Bitmap(CInt(Me.ImageSystem.XSize), CInt(Me.ImageSystem.YSize), BytesPerPixel * CInt(Me.ImageSystem.XSize), pxFormat, intPtr)
                Me.pbox.Image = bitmap
            Catch ex As System.Exception
                Interaction.MsgBox("Cannot view this image", MsgBoxStyle.Critical, "Weirdness Alert")
            End Try
            Dim pbox As Control = Me.pbox
            Dim size As Size = New Size(CInt(Me.ImageSystem.XSize), CInt(Me.ImageSystem.YSize))
            pbox.Size = size
            Me.ImageSystem.BitsPerPixel = CShort((BytesPerPixel * 8))
            Me.Text = "Image Viewer: " + Me.ImageSystem.FileName
            Me.Label2.Text = Me.ImageSystem.ImageSummary()
            Me.ApplyPreviewMode()
        End Sub

        Private Sub ApplyApplicationIcon()
            Try
                Me.Icon = My.Resources.koTOR_icn
            Catch ex As System.Exception
                'Console.WriteLine("Icon could not be applied: " & ex.Message)
            End Try
        End Sub

        Private Sub InitializeViewerControls()
            If Not Me.cmbPreviewSize.Items.Contains(CustomPreviewMode) Then
                Me.cmbPreviewSize.Items.Add(CustomPreviewMode)
            End If

            Me.cmbExportFormat.SelectedItem = "TGA"
            Me.cmbPreviewSize.SelectedItem = "Actual"
            Me.Label2.Text = ""
            Me.Panel1.TabStop = True
        End Sub

        ' Token: 0x06000572 RID: 1394 RVA: 0x00243C4C File Offset: 0x00242C4C
        Public Sub DecodeImage()
            Dim decodedImage As clsImageDecodeResult = Me.ImageSystem.DecodeImage()

            Me.ShowImage(decodedImage.BytesPerPixel, decodedImage.PixelFormat)
            Me.tbImageInfo.Text = decodedImage.ImageInfoText
            Me.lblMipMapCount.Text = StringType.FromInteger(decodedImage.MipMapCount)
            Me.lblFlag1.Text = Strings.Format(decodedImage.Flag1, "x")
            Me.lblFlag2.Text = Strings.Format(decodedImage.Flag2, "x")
            Me.lblFlag3.Text = Strings.Format(decodedImage.Flag3, "x")
            Me.lblFlag4.Text = Strings.Format(decodedImage.Flag4, "x")
        End Sub

        ' Token: 0x06000573 RID: 1395 RVA: 0x002441D8 File Offset: 0x002431D8
        Public Function MipLevel2Bytes(ByVal miplevel As Integer, ByVal dxtBytesPerTexel As Integer) As Integer
            Return New clsTPCSystem().MipLevel2Bytes(miplevel, dxtBytesPerTexel)
        End Function

        ' Token: 0x06000574 RID: 1396 RVA: 0x0024427C File Offset: 0x0024327C
        Public Sub FlipImageVertically(ByRef PixelData As Array, ByVal stride As Integer, ByVal ySize As Integer)
            clsImageSystem.FlipImageVertically(PixelData, stride, ySize)
        End Sub

        ' Token: 0x06000575 RID: 1397 RVA: 0x002442F8 File Offset: 0x002432F8
        Private Sub btnWriteFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnWriteFile.Click
            Dim exportFormat As String = CStr(If(Me.cmbExportFormat.SelectedItem, "TGA"))
            Dim extension As String = Me.ImageSystem.ExportExtension(exportFormat)
            Dim defaultName As String = Me.ImageSystem.DefaultExportName(exportFormat)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, defaultName, "Save " + exportFormat + " file...", extension, False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.ImageSystem.ExportImage(text, exportFormat)
            If Me.tbImageInfo.SelectionLength > 0 AndAlso Me.chkbExportSelectionToTXIfile.Checked Then
                Me.ImageSystem.WriteTXIFile(Path.ChangeExtension(text, ".txi"), Me.tbImageInfo.SelectedText)
            End If
        End Sub

        ' Token: 0x06000576 RID: 1398 RVA: 0x00244474 File Offset: 0x00243474
        Public Sub WriteTGAFile(ByVal outputPath As String)
            Me.ImageSystem.WriteTGAFile(outputPath)
        End Sub

        Private Sub cmbPreviewSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPreviewSize.SelectedIndexChanged
            If Me.SuppressPreviewModeChange Then
                Return
            End If

            Me.ApplyPreviewMode()
        End Sub

        Private Sub Panel1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Panel1.Resize
            Dim previewMode As String = CStr(If(Me.cmbPreviewSize.SelectedItem, ""))
            If StringType.StrCmp(previewMode, "Fit", False) = 0 Then
                Me.ApplyPreviewMode()
            Else
                Me.CenterPreviewImage()
            End If
        End Sub

        Private Sub Panel1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Panel1.MouseEnter, pbox.MouseEnter
            Me.Panel1.Focus()
        End Sub

        Private Sub Preview_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseWheel, pbox.MouseWheel
            If Me.pbox.Image Is Nothing Then
                Return
            End If

            If (Control.ModifierKeys And Keys.Control) <> Keys.Control Then
                Return
            End If

            Dim handledEventArgs As HandledMouseEventArgs = TryCast(e, HandledMouseEventArgs)
            If handledEventArgs IsNot Nothing Then
                handledEventArgs.Handled = True
            End If

            If e.Delta > 0 Then
                Me.PreviewZoom *= 1.1
            Else
                Me.PreviewZoom /= 1.1
            End If

            Me.PreviewZoom = Math.Max(MinPreviewZoom, Math.Min(MaxPreviewZoom, Me.PreviewZoom))
            Me.SuppressPreviewModeChange = True
            Me.cmbPreviewSize.SelectedItem = CustomPreviewMode
            Me.SuppressPreviewModeChange = False
            Me.ApplyZoomPreview()
        End Sub

        Private Sub ApplyPreviewMode()
            If Me.pbox.Image Is Nothing Then
                Return
            End If

            Dim previewMode As String = CStr(If(Me.cmbPreviewSize.SelectedItem, "Actual"))
            If StringType.StrCmp(previewMode, "Fit", False) = 0 Then
                Me.PreviewZoom = 1.0
                Me.pbox.SizeMode = PictureBoxSizeMode.Zoom
                Me.pbox.Size = Me.Panel1.ClientSize
            ElseIf StringType.StrCmp(previewMode, "Actual", False) = 0 Then
                Me.PreviewZoom = 1.0
                Me.pbox.SizeMode = PictureBoxSizeMode.Normal
                Me.pbox.Size = Me.pbox.Image.Size
            ElseIf StringType.StrCmp(previewMode, CustomPreviewMode, False) = 0 Then
                Me.ApplyZoomPreview()
                Return
            Else
                Dim previewSize As Size = Me.ParsePreviewSize(previewMode)
                If Not previewSize.IsEmpty Then
                    Me.PreviewZoom = 1.0
                    Me.pbox.SizeMode = PictureBoxSizeMode.Zoom
                    Me.pbox.Size = previewSize
                End If
            End If

            Me.CenterPreviewImage()
        End Sub

        Private Sub ApplyZoomPreview()
            Dim width As Integer = Math.Max(1, CInt(Math.Round(CDbl(Me.pbox.Image.Width) * Me.PreviewZoom)))
            Dim height As Integer = Math.Max(1, CInt(Math.Round(CDbl(Me.pbox.Image.Height) * Me.PreviewZoom)))

            Me.pbox.SizeMode = PictureBoxSizeMode.Zoom
            Me.pbox.Size = New Size(width, height)
            Me.CenterPreviewImage()
        End Sub

        Private Function ParsePreviewSize(ByVal previewMode As String) As Size
            Dim parts As String() = previewMode.Split(New String() {" x "}, StringSplitOptions.None)
            If parts.Length <> 2 Then
                Return Size.Empty
            End If

            Return New Size(Integer.Parse(parts(0)), Integer.Parse(parts(1)))
        End Function

        Private Sub CenterPreviewImage()
            If Me.pbox.Image Is Nothing Then
                Return
            End If

            Dim x As Integer = 0
            Dim y As Integer = 0

            Me.Panel1.AutoScrollMinSize = Me.pbox.Size

            If Me.pbox.Width < Me.Panel1.ClientSize.Width Then
                x = CInt(Math.Floor(CDbl(Me.Panel1.ClientSize.Width - Me.pbox.Width) / 2.0))
            End If

            If Me.pbox.Height < Me.Panel1.ClientSize.Height Then
                y = CInt(Math.Floor(CDbl(Me.Panel1.ClientSize.Height - Me.pbox.Height) / 2.0))
            End If

            Me.pbox.Location = New Point(x, y)
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

        ' Token: 0x040002E9 RID: 745
        Private ghImage As GCHandle
    End Class
End Namespace
