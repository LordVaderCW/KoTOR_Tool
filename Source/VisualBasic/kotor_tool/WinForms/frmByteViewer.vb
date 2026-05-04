Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool

    Partial Public Class frmByteViewer
        Inherits Form

        ' -----------------------------------------------------------------
        ' frmByteViewer.vb
        '
        ' Restored / facelifted Byte Viewer backend for the KoTOR Tool
        ' Restoration Project.
        '
        ' Patch 1.0.3.3:
        '   - Fully wires frmByteViewer to DarkByteViewerControl.
        '   - Find / Go To now scrolls and selects in the byte surface.
        '   - Copy Selected now uses the real control selection state.
        '   - Highlight toggles now drive the renderer properties.
        '   - Visible range now uses DarkByteViewerControl events.
        '   - Inspector now updates from control byte selection events.
        '   - Export Visible now uses the real visible range.
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original constructors and legacy settings behaviour preserved.
        ' -----------------------------------------------------------------

        Public filepath As String = ""
        Public data As Byte() = New Byte() {}

        Private _viewerBytes As Byte() = New Byte() {}
        Private _lastFindOffset As Integer = -1
        Private _currentOffset As Integer = 0
        Private _selectionStart As Integer = -1
        Private _selectionLength As Integer = 0
        Private _firstVisibleOffset As Integer = 0
        Private _lastVisibleOffset As Integer = 0

        Public Sub New()
            AddHandler MyBase.Resize, AddressOf Me.frmByteViewer_Resize
            AddHandler MyBase.Closing, AddressOf Me.frmByteViewer_Closing
            AddHandler MyBase.Load, AddressOf Me.Form1_Load

            Me.InitializeComponent()

            Me.ApplyApplicationIcon()

            ' -------------------------------------------------------------
            ' Legacy display mode buttons.
            ' -------------------------------------------------------------
            AddHandler Me.rbHex.Click, AddressOf Me.rbHex_Click
            AddHandler Me.rbANSI.Click, AddressOf Me.rbANSI_Click
            AddHandler Me.rbUnicode.Click, AddressOf Me.rbUnicode_Click
            AddHandler Me.Button1.Click, AddressOf Me.Button1_Click

            ' -------------------------------------------------------------
            ' Toolbar bindings.
            ' -------------------------------------------------------------
            AddHandler Me.btnFind.Click, AddressOf Me.btnFind_Click
            AddHandler Me.btnFindNext.Click, AddressOf Me.btnFindNext_Click
            AddHandler Me.btnGotoOffset.Click, AddressOf Me.btnGotoOffset_Click
            AddHandler Me.btnCopyOffset.Click, AddressOf Me.btnCopyOffset_Click
            AddHandler Me.btnCopyHex.Click, AddressOf Me.btnCopyHex_Click
            AddHandler Me.btnCopyAscii.Click, AddressOf Me.btnCopyAscii_Click
            AddHandler Me.btnCopySelected.Click, AddressOf Me.btnCopySelected_Click
            AddHandler Me.btnExportDump.Click, AddressOf Me.btnExportDump_Click
            AddHandler Me.btnExportVisible.Click, AddressOf Me.btnExportVisible_Click
            AddHandler Me.cmbEncoding.SelectedIndexChanged, AddressOf Me.cmbEncoding_SelectedIndexChanged
            AddHandler Me.cmbFindMode.SelectedIndexChanged, AddressOf Me.cmbFindMode_SelectedIndexChanged
            AddHandler Me.tbFind.KeyDown, AddressOf Me.tbFind_KeyDown
            AddHandler Me.tbGotoOffset.KeyDown, AddressOf Me.tbGotoOffset_KeyDown

            ' -------------------------------------------------------------
            ' Renderer option bindings.
            ' -------------------------------------------------------------
            AddHandler Me.chkbFreezeHeader.CheckedChanged, AddressOf Me.ByteVisualOption_Changed
            AddHandler Me.chkbAlternateRows.CheckedChanged, AddressOf Me.ByteVisualOption_Changed
            AddHandler Me.chkbHighlightNull.CheckedChanged, AddressOf Me.ByteVisualOption_Changed
            AddHandler Me.chkbHighlightControl.CheckedChanged, AddressOf Me.ByteVisualOption_Changed
            AddHandler Me.chkbHighlightHighAscii.CheckedChanged, AddressOf Me.ByteVisualOption_Changed
            AddHandler Me.chkbHighlightNonPrintable.CheckedChanged, AddressOf Me.ByteVisualOption_Changed

            ' -------------------------------------------------------------
            ' DarkByteViewerControl event bindings.
            ' -------------------------------------------------------------
            AddHandler Me.bv.CurrentByteChanged, AddressOf Me.bv_CurrentByteChanged
            AddHandler Me.bv.SelectionChanged, AddressOf Me.bv_SelectionChanged
            AddHandler Me.bv.VisibleRangeChanged, AddressOf Me.bv_VisibleRangeChanged


        End Sub

        Public Sub New(ByVal path As String)
            Me.New()
            Me.filepath = path
        End Sub

        Public Sub New(ByVal bytes As Byte())
            Me.New()

            If bytes Is Nothing Then
                Me.data = New Byte() {}
            Else
                Me.data = bytes
            End If
        End Sub
        Private Sub ApplyApplicationIcon()
            Try
                Me.Icon = My.Resources.koTOR_icn
            Catch ex As System.Exception
                'Console.WriteLine("Icon could not be applied: " & ex.Message)
            End Try
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim bytesToShow As Byte() = New Byte() {}

            Me.bv.Dock = DockStyle.Fill
            Me.bv.Font = New Font("Consolas", 8.0F)
            Me.bv.ForeColor = Color.FromArgb(238, 238, 230)
            Me.bv.BackColor = Color.FromArgb(12, 17, 24)
            Me.bv.Visible = True

            Me.pnlByteSurface.Controls.Clear()
            Me.pnlByteSurface.Controls.Add(Me.bv)
            Me.bv.BringToFront()

            If Me.filepath IsNot Nothing AndAlso Me.filepath.Length > 0 AndAlso File.Exists(Me.filepath) Then
                bytesToShow = File.ReadAllBytes(Me.filepath)
            ElseIf Me.data IsNot Nothing AndAlso Me.data.Length > 0 Then
                bytesToShow = Me.data
            End If

            Me._viewerBytes = bytesToShow
            Me._currentOffset = 0
            Me._selectionStart = -1
            Me._selectionLength = 0
            Me._firstVisibleOffset = 0
            Me._lastVisibleOffset = Math.Max(0, Math.Min(255, bytesToShow.Length - 1))

            Me.InitialiseToolbarDefaults()

            Me.bv.SetBytes(bytesToShow)
            Me.bv.DisplayMode = DarkByteViewerDisplayMode.Hexdump
            Me.ApplyVisualOptionsToViewer()

            Me.lblDetectedType.Text = Me.DetectResourceType(bytesToShow)
            Me.UpdateInspector(Me._currentOffset)
            Me.UpdateStatus("Ready")

            Me.PositionWindow()
            Me.bv.Focus()
            Me.bv.Invalidate()
        End Sub

        Private Sub InitialiseToolbarDefaults()
            If Me.cmbFindMode IsNot Nothing AndAlso Me.cmbFindMode.Items.Count > 0 Then
                Me.cmbFindMode.SelectedIndex = 0
            End If

            If Me.cmbEncoding IsNot Nothing AndAlso Me.cmbEncoding.Items.Count > 0 Then
                Me.cmbEncoding.SelectedIndex = 0
            End If

            If Me.tbGotoOffset IsNot Nothing Then
                Me.tbGotoOffset.Text = "0x00000000"
            End If

            If Me.lblSelectionValue IsNot Nothing Then
                Me.lblSelectionValue.Text = "0 bytes"
            End If

            If Me.lblVisibleValue IsNot Nothing Then
                Me.lblVisibleValue.Text = Me.GetVisibleRangeText()
            End If
        End Sub

        ' -----------------------------------------------------------------
        ' DarkByteViewerControl event handlers.
        ' -----------------------------------------------------------------

        Private Sub bv_CurrentByteChanged(ByVal offset As Integer, ByVal value As Byte)
            Me._currentOffset = offset
            Me.tbGotoOffset.Text = "0x" & offset.ToString("X8")
            Me.UpdateInspector(offset)
            Me.UpdateStatus("")
        End Sub

        Private Sub bv_SelectionChanged(ByVal startOffset As Integer, ByVal length As Integer)
            Me._selectionStart = startOffset
            Me._selectionLength = length

            If Me.lblSelectionValue IsNot Nothing Then
                If startOffset >= 0 AndAlso length > 0 Then
                    Me.lblSelectionValue.Text = length.ToString() & " bytes"
                Else
                    Me.lblSelectionValue.Text = "0 bytes"
                End If
            End If

            Me.UpdateStatus("")
        End Sub

        Private Sub bv_VisibleRangeChanged(ByVal firstOffset As Integer, ByVal lastOffset As Integer)
            Me._firstVisibleOffset = firstOffset
            Me._lastVisibleOffset = lastOffset
            Me.UpdateVisibleRangeOnly()
            Me.UpdateStatus("")
        End Sub

        ' -----------------------------------------------------------------
        ' Display mode handling.
        ' -----------------------------------------------------------------

        Private Sub rbANSI_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbANSI.Click
            Me.SetDisplayMode(DarkByteViewerDisplayMode.Ansi, "ANSI")
        End Sub

        Private Sub rbHex_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbHex.Click
            Me.SetDisplayMode(DarkByteViewerDisplayMode.Hexdump, "Hexdump")
        End Sub

        Private Sub rbUnicode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbUnicode.Click
            Me.SetDisplayMode(DarkByteViewerDisplayMode.Unicode, "UTF-16 LE")
        End Sub

        Private Sub SetDisplayMode(ByVal mode As DarkByteViewerDisplayMode, ByVal encodingName As String)
            Me.bv.DisplayMode = mode
            Me._lastFindOffset = -1
            Me._selectionStart = -1
            Me._selectionLength = 0

            If Me.cmbEncoding IsNot Nothing Then
                Dim index As Integer = Me.cmbEncoding.FindStringExact(encodingName)
                If index >= 0 AndAlso Me.cmbEncoding.SelectedIndex <> index Then
                    Me.cmbEncoding.SelectedIndex = index
                End If
            End If

            Me.UpdateStatus(encodingName & " view")
            Me.bv.Invalidate()
        End Sub

        Private Sub cmbEncoding_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.cmbEncoding.SelectedItem Is Nothing Then
                Return
            End If

            Dim value As String = Me.cmbEncoding.SelectedItem.ToString()

            Select Case value
                Case "Hexdump"
                    Me.bv.DisplayMode = DarkByteViewerDisplayMode.Hexdump
                    Me.rbHex.Checked = True

                Case "ANSI"
                    Me.bv.DisplayMode = DarkByteViewerDisplayMode.Ansi
                    Me.rbANSI.Checked = True

                Case "UTF-8"
                    Me.bv.DisplayMode = DarkByteViewerDisplayMode.Ansi
                    Me.rbANSI.Checked = True

                Case "UTF-16 LE"
                    Me.bv.DisplayMode = DarkByteViewerDisplayMode.Unicode
                    Me.rbUnicode.Checked = True

                Case "UTF-16 BE"
                    Me.bv.DisplayMode = DarkByteViewerDisplayMode.Unicode
                    Me.rbUnicode.Checked = True
            End Select

            Me._lastFindOffset = -1
            Me.bv.ClearSelection()
            Me.UpdateStatus(value & " view")
            Me.bv.Invalidate()
        End Sub

        Private Sub cmbFindMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me._lastFindOffset = -1
        End Sub

        Private Sub frmByteViewer_Resize(ByVal sender As Object, ByVal e As EventArgs)
            If Me.bv IsNot Nothing Then
                Me.UpdateVisibleRangeOnly()
                Me.bv.Invalidate()
            End If
        End Sub

        ' -----------------------------------------------------------------
        ' Legacy window placement persistence.
        ' -----------------------------------------------------------------

        Public Sub PositionWindow()
            Dim point As Point = frmMain.CurrentSettings.ByteViewerWindowLoc
            If Not point.IsEmpty Then
                Me.Location = frmMain.CurrentSettings.ByteViewerWindowLoc
            End If
            If Not frmMain.CurrentSettings.ByteViewerWindowSize.IsEmpty Then
                Dim size As Size = frmMain.CurrentSettings.ByteViewerWindowSize
                Dim height As Integer = 0
                Dim size2 As Size
                If size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                    point = Me.Location
                    Dim location As Point = New Point(point.X, Screen.PrimaryScreen.WorkingArea.Top)
                    Me.Location = location
                    height = Screen.PrimaryScreen.WorkingArea.Height
                    size = Me.Size
                    size2 = New Size(size.Width, height)
                    Me.Size = size2
                End If
                size2 = frmMain.CurrentSettings.ByteViewerWindowSize
                Dim width As Integer = 0
                If size2.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                    Dim left As Integer = Screen.PrimaryScreen.WorkingArea.Left
                    Dim location As Point = Me.Location
                    point = New Point(left, location.Y)
                    Me.Location = point
                    width = Screen.PrimaryScreen.WorkingArea.Width
                    Dim num As Integer = width
                    size2 = Me.Size
                    size = New Size(num, size2.Height)
                    Me.Size = size
                End If
                If (width = 0) AndAlso (height = 0) Then
                    Me.Size = frmMain.CurrentSettings.ByteViewerWindowSize
                End If
            End If
        End Sub

        Public Sub SaveSettings()
            frmMain.CurrentSettings.ByteViewerWindowLoc = Me.Location
            frmMain.CurrentSettings.ByteViewerWindowSize = Me.Size
        End Sub

        Private Sub frmByteViewer_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings()
        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
            Me.Close()
        End Sub

        ' -----------------------------------------------------------------
        ' Toolbar event handlers.
        ' -----------------------------------------------------------------

        Private Sub tbFind_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Me.RunFind(False)
            End If
        End Sub

        Private Sub tbGotoOffset_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Me.RunGotoOffset()
            End If
        End Sub

        Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.RunFind(False)
        End Sub

        Private Sub btnFindNext_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.RunFind(True)
        End Sub

        Private Sub btnGotoOffset_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.RunGotoOffset()
        End Sub

        Private Sub btnCopyOffset_Click(ByVal sender As Object, ByVal e As EventArgs)
            Clipboard.SetText("0x" & Me._currentOffset.ToString("X8"))
            Me.UpdateStatus("Offset copied")
        End Sub

        Private Sub btnCopyHex_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me._viewerBytes Is Nothing OrElse Me._viewerBytes.Length = 0 Then
                Me.UpdateStatus("Nothing to copy")
                Return
            End If

            Clipboard.SetText(Me.BuildHexDumpText(Me._viewerBytes, 0, Me._viewerBytes.Length))
            Me.UpdateStatus("Hex dump copied")
        End Sub

        Private Sub btnCopyAscii_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me._viewerBytes Is Nothing OrElse Me._viewerBytes.Length = 0 Then
                Me.UpdateStatus("Nothing to copy")
                Return
            End If

            Clipboard.SetText(Me.BuildAsciiText(Me._viewerBytes, 0, Me._viewerBytes.Length))
            Me.UpdateStatus("ASCII copied")
        End Sub

        Private Sub btnCopySelected_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me._viewerBytes Is Nothing OrElse Me._viewerBytes.Length = 0 Then
                Me.UpdateStatus("Nothing to copy")
                Return
            End If

            Dim startOffset As Integer = Me.GetEffectiveSelectionStart()
            Dim length As Integer = Me.GetEffectiveSelectionLength()

            If startOffset < 0 OrElse length <= 0 Then
                Me.UpdateStatus("No selection")
                Return
            End If

            Clipboard.SetText(Me.BuildHexDumpText(Me._viewerBytes, startOffset, length))
            Me.UpdateStatus("Selected bytes copied")
        End Sub

        Private Sub btnExportDump_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ExportDump(False)
        End Sub

        Private Sub btnExportVisible_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ExportDump(True)
        End Sub

        Private Sub ByteVisualOption_Changed(ByVal sender As Object, ByVal e As EventArgs)
            Me.ApplyVisualOptionsToViewer()
        End Sub

        Private Sub ApplyVisualOptionsToViewer()
            If Me.bv Is Nothing Then
                Return
            End If

            Me.bv.FreezeHeader = Me.chkbFreezeHeader.Checked
            Me.bv.AlternateRows = Me.chkbAlternateRows.Checked
            Me.bv.HighlightNullBytes = Me.chkbHighlightNull.Checked
            Me.bv.HighlightControlBytes = Me.chkbHighlightControl.Checked
            Me.bv.HighlightHighAsciiBytes = Me.chkbHighlightHighAscii.Checked
            Me.bv.HighlightNonPrintableBytes = Me.chkbHighlightNonPrintable.Checked
            Me.bv.Invalidate()
        End Sub

        ' -----------------------------------------------------------------
        ' Find / Go To Offset helpers.
        ' -----------------------------------------------------------------

        Private Sub RunFind(ByVal findNext As Boolean)
            If Me._viewerBytes Is Nothing OrElse Me._viewerBytes.Length = 0 Then
                Me.UpdateStatus("No bytes loaded")
                Return
            End If

            Dim findText As String = Me.tbFind.Text
            If findText Is Nothing OrElse findText.Trim().Length = 0 Then
                Me.UpdateStatus("Enter search text")
                Return
            End If

            Dim pattern As Byte() = Me.BuildFindPattern(findText.Trim())
            If pattern Is Nothing OrElse pattern.Length = 0 Then
                Me.UpdateStatus("Invalid search")
                Return
            End If

            Dim startOffset As Integer
            If findNext Then
                startOffset = Me._lastFindOffset + 1
            Else
                startOffset = 0
            End If

            If startOffset < 0 OrElse startOffset >= Me._viewerBytes.Length Then
                startOffset = 0
            End If

            Dim foundOffset As Integer = Me.FindBytes(Me._viewerBytes, pattern, startOffset)
            If foundOffset < 0 AndAlso startOffset > 0 Then
                foundOffset = Me.FindBytes(Me._viewerBytes, pattern, 0)
            End If

            If foundOffset >= 0 Then
                Me._lastFindOffset = foundOffset
                Me._currentOffset = foundOffset
                Me._selectionStart = foundOffset
                Me._selectionLength = pattern.Length

                Me.tbGotoOffset.Text = "0x" & foundOffset.ToString("X8")
                Me.UpdateInspector(foundOffset)
                Me.UpdateStatus("Found at 0x" & foundOffset.ToString("X8"))

                Me.bv.JumpToOffset(foundOffset)
                Me.bv.SelectRange(foundOffset, pattern.Length)
                Me.bv.Focus()
            Else
                Me.UpdateStatus("Not found")
            End If
        End Sub

        Private Sub RunGotoOffset()
            If Me._viewerBytes Is Nothing OrElse Me._viewerBytes.Length = 0 Then
                Me.UpdateStatus("No bytes loaded")
                Return
            End If

            Dim offset As Integer
            If Not Me.TryParseOffset(Me.tbGotoOffset.Text, offset) Then
                Me.UpdateStatus("Invalid offset")
                Return
            End If

            If offset < 0 OrElse offset >= Me._viewerBytes.Length Then
                Me.UpdateStatus("Offset out of range")
                Return
            End If

            Me._currentOffset = offset
            Me._lastFindOffset = offset
            Me._selectionStart = offset
            Me._selectionLength = 1

            Me.tbGotoOffset.Text = "0x" & offset.ToString("X8")
            Me.UpdateInspector(offset)
            Me.UpdateStatus("Offset 0x" & offset.ToString("X8"))

            Me.bv.JumpToOffset(offset)
            Me.bv.SelectRange(offset, 1)
            Me.bv.Focus()
        End Sub

        Private Function BuildFindPattern(ByVal findText As String) As Byte()
            Dim mode As String = ""

            If Me.cmbFindMode IsNot Nothing AndAlso Me.cmbFindMode.SelectedItem IsNot Nothing Then
                mode = Me.cmbFindMode.SelectedItem.ToString()
            End If

            If mode.Length = 0 Then
                If Me.bv.DisplayMode = DarkByteViewerDisplayMode.Hexdump Then
                    mode = "Hex"
                ElseIf Me.bv.DisplayMode = DarkByteViewerDisplayMode.Unicode Then
                    mode = "Unicode"
                Else
                    mode = "ANSI"
                End If
            End If

            Select Case mode
                Case "Hex"
                    Return Me.ParseHexPattern(findText)

                Case "Unicode"
                    Return Encoding.Unicode.GetBytes(findText)

                Case Else
                    Return Encoding.Default.GetBytes(findText)
            End Select
        End Function

        Private Function ParseHexPattern(ByVal text As String) As Byte()
            Dim cleaned As String = text.Replace("0x", "")
            cleaned = cleaned.Replace("0X", "")
            cleaned = cleaned.Replace(" ", "")
            cleaned = cleaned.Replace("-", "")
            cleaned = cleaned.Replace(",", "")
            cleaned = cleaned.Replace(vbTab, "")

            If cleaned.Length = 0 OrElse (cleaned.Length Mod 2) <> 0 Then
                Return New Byte() {}
            End If

            Dim result((cleaned.Length \ 2) - 1) As Byte
            Dim i As Integer
            For i = 0 To result.Length - 1
                Dim token As String = cleaned.Substring(i * 2, 2)
                If Not IsHexByte(token) Then
                    Return New Byte() {}
                End If
                result(i) = Convert.ToByte(token, 16)
            Next

            Return result
        End Function

        Private Function IsHexByte(ByVal token As String) As Boolean
            If token Is Nothing OrElse token.Length <> 2 Then
                Return False
            End If

            Dim i As Integer
            For i = 0 To token.Length - 1
                Dim ch As Char = token.Chars(i)
                If Not ((ch >= "0"c AndAlso ch <= "9"c) OrElse
                        (ch >= "A"c AndAlso ch <= "F"c) OrElse
                        (ch >= "a"c AndAlso ch <= "f"c)) Then
                    Return False
                End If
            Next

            Return True
        End Function

        Private Function FindBytes(ByVal source As Byte(), ByVal pattern As Byte(), ByVal startOffset As Integer) As Integer
            If source Is Nothing OrElse pattern Is Nothing Then
                Return -1
            End If

            If pattern.Length = 0 OrElse source.Length = 0 OrElse pattern.Length > source.Length Then
                Return -1
            End If

            If startOffset < 0 Then
                startOffset = 0
            End If

            Dim i As Integer
            For i = startOffset To source.Length - pattern.Length
                Dim matched As Boolean = True
                Dim j As Integer

                For j = 0 To pattern.Length - 1
                    If source(i + j) <> pattern(j) Then
                        matched = False
                        Exit For
                    End If
                Next

                If matched Then
                    Return i
                End If
            Next

            Return -1
        End Function

        Private Function TryParseOffset(ByVal text As String, ByRef offset As Integer) As Boolean
            offset = 0

            If text Is Nothing Then
                Return False
            End If

            Dim cleaned As String = text.Trim()
            If cleaned.Length = 0 Then
                Return False
            End If

            Try
                If cleaned.StartsWith("0x", StringComparison.OrdinalIgnoreCase) Then
                    offset = Convert.ToInt32(cleaned.Substring(2), 16)
                    Return True
                End If

                If cleaned.EndsWith("h", StringComparison.OrdinalIgnoreCase) Then
                    offset = Convert.ToInt32(cleaned.Substring(0, cleaned.Length - 1), 16)
                    Return True
                End If

                offset = Convert.ToInt32(cleaned, 10)
                Return True
            Catch ex As System.Exception
                Return False
            End Try
        End Function

        ' -----------------------------------------------------------------
        ' Resource detection and inspector helpers.
        ' -----------------------------------------------------------------

        Private Function DetectResourceType(ByVal bytes As Byte()) As String
            If bytes Is Nothing OrElse bytes.Length < 4 Then
                Return "Unknown"
            End If

            Dim magic As String = Encoding.ASCII.GetString(bytes, 0, Math.Min(4, bytes.Length))

            Select Case magic
                Case "GFF "
                    Return "GFF"
                Case "ERF "
                    Return "ERF"
                Case "RIM "
                    Return "RIM"
                Case "BIF "
                    Return "BIF"
                Case "TLK "
                    Return "TLK"
                Case "2DA "
                    Return "2DA"
                Case "TPC "
                    Return "TPC"
                Case "WAV "
                    Return "WAV"
                Case "RIFF"
                    Return "RIFF/WAV"
            End Select

            If bytes.Length >= 8 Then
                Dim magic8 As String = Encoding.ASCII.GetString(bytes, 0, 8)
                If magic8.StartsWith("BM") Then
                    Return "Bitmap"
                End If
            End If

            Return "Unknown"
        End Function

        Private Sub UpdateInspector(ByVal offset As Integer)
            If Me._viewerBytes Is Nothing OrElse Me._viewerBytes.Length = 0 Then
                Me.SetInspectorEmpty()
                Return
            End If

            If offset < 0 Then
                offset = 0
            End If

            If offset >= Me._viewerBytes.Length Then
                offset = Me._viewerBytes.Length - 1
            End If

            Me._currentOffset = offset

            Dim value As Byte = Me._viewerBytes(offset)
            Dim signedValue As Integer = value
            If signedValue > 127 Then
                signedValue -= 256
            End If

            Me.lblOffsetValue.Text = "0x" & offset.ToString("X8")
            Me.lblByteValue.Text = "0x" & value.ToString("X2")
            Me.lblUInt8Value.Text = value.ToString()
            Me.lblInt8Value.Text = signedValue.ToString()
            Me.lblAsciiValue.Text = Me.ToPrintableAscii(value).ToString()
            Me.lblBinaryValue.Text = Convert.ToString(value, 2).PadLeft(8, "0"c)
            Me.lblSelectionValue.Text = Me.GetEffectiveSelectionLength().ToString() & " bytes"
            Me.lblVisibleValue.Text = Me.GetVisibleRangeText()
        End Sub

        Private Sub SetInspectorEmpty()
            If Me.lblOffsetValue IsNot Nothing Then Me.lblOffsetValue.Text = "0x00000000"
            If Me.lblByteValue IsNot Nothing Then Me.lblByteValue.Text = "0x00"
            If Me.lblUInt8Value IsNot Nothing Then Me.lblUInt8Value.Text = "0"
            If Me.lblInt8Value IsNot Nothing Then Me.lblInt8Value.Text = "0"
            If Me.lblAsciiValue IsNot Nothing Then Me.lblAsciiValue.Text = "."
            If Me.lblBinaryValue IsNot Nothing Then Me.lblBinaryValue.Text = "00000000"
            If Me.lblSelectionValue IsNot Nothing Then Me.lblSelectionValue.Text = "0 bytes"
            If Me.lblVisibleValue IsNot Nothing Then Me.lblVisibleValue.Text = "0x00000000-0x00000000"
        End Sub

        Private Sub UpdateVisibleRangeOnly()
            If Me.lblVisibleValue IsNot Nothing Then
                Me.lblVisibleValue.Text = Me.GetVisibleRangeText()
            End If
        End Sub

        Private Function GetVisibleRangeText() As String
            If Me._viewerBytes Is Nothing OrElse Me._viewerBytes.Length = 0 Then
                Return "0x00000000-0x00000000"
            End If

            Return "0x" & Me._firstVisibleOffset.ToString("X8") & "-0x" & Me._lastVisibleOffset.ToString("X8")
        End Function

        Private Function GetEffectiveSelectionStart() As Integer
            If Me.bv IsNot Nothing AndAlso Me.bv.SelectionStart >= 0 Then
                Return Me.bv.SelectionStart
            End If

            If Me._selectionStart >= 0 Then
                Return Me._selectionStart
            End If

            Return -1
        End Function

        Private Function GetEffectiveSelectionLength() As Integer
            If Me.bv IsNot Nothing AndAlso Me.bv.SelectionLength > 0 Then
                Return Me.bv.SelectionLength
            End If

            If Me._selectionLength > 0 Then
                Return Me._selectionLength
            End If

            Return 0
        End Function

        ' -----------------------------------------------------------------
        ' Dump/export helpers.
        ' -----------------------------------------------------------------

        Private Sub ExportDump(ByVal visibleOnly As Boolean)
            If Me._viewerBytes Is Nothing OrElse Me._viewerBytes.Length = 0 Then
                Me.UpdateStatus("Nothing to export")
                Return
            End If

            Dim startOffset As Integer = 0
            Dim length As Integer = Me._viewerBytes.Length

            If visibleOnly Then
                startOffset = Math.Max(0, Math.Min(Me._firstVisibleOffset, Me._viewerBytes.Length - 1))
                length = Math.Max(0, Me._lastVisibleOffset - startOffset + 1)
            End If

            Using dialog As New SaveFileDialog()
                dialog.Title = "Export Byte Viewer Dump"
                dialog.Filter = "Text Dump (*.txt)|*.txt|All Files (*.*)|*.*"
                dialog.DefaultExt = "txt"
                dialog.AddExtension = True

                If visibleOnly Then
                    dialog.FileName = "byte_visible_dump.txt"
                Else
                    dialog.FileName = "byte_dump.txt"
                End If

                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    File.WriteAllText(dialog.FileName, Me.BuildHexDumpText(Me._viewerBytes, startOffset, length), Encoding.ASCII)

                    If visibleOnly Then
                        Me.UpdateStatus("Visible dump exported")
                    Else
                        Me.UpdateStatus("Dump exported")
                    End If
                End If
            End Using
        End Sub

        Private Function BuildHexDumpText(ByVal bytes As Byte(), ByVal startOffset As Integer, ByVal length As Integer) As String
            Dim sb As New StringBuilder()

            sb.AppendLine("OFFSET    00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F    ASCII")
            sb.AppendLine("--------  -----------------------------------------------    ----------------")

            If bytes Is Nothing OrElse bytes.Length = 0 Then
                Return sb.ToString()
            End If

            If startOffset < 0 Then startOffset = 0
            If startOffset >= bytes.Length Then Return sb.ToString()
            If length < 0 Then length = 0

            Dim endOffset As Integer = Math.Min(bytes.Length, startOffset + length)
            Dim offset As Integer = startOffset - (startOffset Mod 16)

            While offset < endOffset
                Dim hexPart As New StringBuilder()
                Dim asciiPart As New StringBuilder()

                Dim i As Integer
                For i = 0 To 15
                    Dim index As Integer = offset + i

                    If index >= startOffset AndAlso index < endOffset AndAlso index < bytes.Length Then
                        Dim value As Byte = bytes(index)
                        hexPart.Append(value.ToString("X2"))
                        asciiPart.Append(Me.ToPrintableAscii(value))
                    Else
                        hexPart.Append("  ")
                        asciiPart.Append(" ")
                    End If

                    If i < 15 Then
                        hexPart.Append(" ")
                    End If
                Next

                sb.Append(offset.ToString("X8"))
                sb.Append("  ")
                sb.Append(hexPart.ToString())
                sb.Append("    ")
                sb.AppendLine(asciiPart.ToString())

                offset += 16
            End While

            Return sb.ToString()
        End Function

        Private Function BuildAsciiText(ByVal bytes As Byte(), ByVal startOffset As Integer, ByVal length As Integer) As String
            If bytes Is Nothing OrElse bytes.Length = 0 Then
                Return ""
            End If

            If startOffset < 0 Then startOffset = 0
            If startOffset >= bytes.Length Then Return ""
            If length < 0 Then length = 0

            Dim endOffset As Integer = Math.Min(bytes.Length, startOffset + length)
            Dim sb As New StringBuilder()
            Dim i As Integer

            For i = startOffset To endOffset - 1
                sb.Append(Me.ToPrintableAscii(bytes(i)))
            Next

            Return sb.ToString()
        End Function

        Private Function ToPrintableAscii(ByVal value As Byte) As Char
            If value >= 32 AndAlso value <= 126 Then
                Return Convert.ToChar(value)
            End If

            Return "."c
        End Function

        Private Sub UpdateStatus(ByVal message As String)
            If Me.lblStatus Is Nothing Then
                Return
            End If

            Dim byteCount As Integer = 0
            If Me._viewerBytes IsNot Nothing Then
                byteCount = Me._viewerBytes.Length
            End If

            Dim status As String = "Size: " & byteCount.ToString() & " bytes"
            status &= " | Offset: 0x" & Math.Max(0, Me._currentOffset).ToString("X8")
            status &= " | Visible: " & Me.GetVisibleRangeText()
            status &= " | Selected: " & Me.GetEffectiveSelectionLength().ToString()

            If message IsNot Nothing AndAlso message.Length > 0 Then
                status &= " | " & message
            End If

            Me.lblStatus.Text = status
        End Sub

    End Class
End Namespace
