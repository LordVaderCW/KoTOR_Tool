Option Strict Off
Option Explicit On

Imports System
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace kotor_tool

    Public Enum DarkByteViewerDisplayMode
        Hexdump = 0
        Ansi = 1
        Unicode = 2
    End Enum

    Public Class DarkByteViewerControl
        Inherits UserControl

        ' -----------------------------------------------------------------
        ' DarkByteViewerControl.vb
        '
        ' Custom dark byte rendering surface for the KoTOR Tool Restoration
        ' Byte Viewer.
        '
        ' Patch 1.0.3.3:
        '   - Restored reliable scrollbar support.
        '   - Added public JumpToOffset support.
        '   - Added public SelectRange / ClearSelection support.
        '   - Added mouse click and drag byte selection in Hexdump mode.
        '   - Added selected byte/current byte events for frmByteViewer.
        '   - Added visible range event support for status readouts.
        '   - Added alternate row shading.
        '   - Added NULL / control / high ASCII / non-printable highlighting.
        '   - Header remains visually frozen because only data rows scroll.
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Hexdump mode is the primary inspection mode.
        '   - ANSI / Unicode modes retain scrollable text rendering.
        ' -----------------------------------------------------------------

        Public Event CurrentByteChanged(ByVal offset As Integer, ByVal value As Byte)
        Public Event SelectionChanged(ByVal startOffset As Integer, ByVal length As Integer)
        Public Event VisibleRangeChanged(ByVal firstOffset As Integer, ByVal lastOffset As Integer)

        Private _bytes As Byte() = New Byte() {}
        Private _lines As New VScrollBar()
        Private _lineHeight As Integer = 16
        Private _firstLine As Integer = 0
        Private _bytesPerLine As Integer = 16
        Private _displayMode As DarkByteViewerDisplayMode = DarkByteViewerDisplayMode.Hexdump

        Private _currentOffset As Integer = -1
        Private _selectionStart As Integer = -1
        Private _selectionLength As Integer = 0
        Private _selectionAnchor As Integer = -1
        Private _isSelecting As Boolean = False

        Private _alternateRows As Boolean = True
        Private _freezeHeader As Boolean = True
        Private _highlightNullBytes As Boolean = False
        Private _highlightControlBytes As Boolean = False
        Private _highlightHighAsciiBytes As Boolean = False
        Private _highlightNonPrintableBytes As Boolean = False

        Private _xOffset As Integer = 8
        Private _xHex As Integer = 92
        Private _xAscii As Integer = 430
        Private _headerY As Integer = 8
        Private _dataStartY As Integer = 28
        Private _hexCellWidth As Integer = 21
        Private _asciiCellWidth As Integer = 8

        Public Property DisplayMode As DarkByteViewerDisplayMode
            Get
                Return Me._displayMode
            End Get
            Set(ByVal value As DarkByteViewerDisplayMode)
                Me._displayMode = value
                Me._firstLine = 0
                Me._currentOffset = -1
                Me.ClearSelection()
                Me.UpdateScrollBar()
                Me.RaiseVisibleRangeChanged()
                Me.Invalidate()
            End Set
        End Property

        Public Property AlternateRows() As Boolean
            Get
                Return Me._alternateRows
            End Get
            Set(ByVal value As Boolean)
                Me._alternateRows = value
                Me.Invalidate()
            End Set
        End Property

        Public Property FreezeHeader() As Boolean
            Get
                Return Me._freezeHeader
            End Get
            Set(ByVal value As Boolean)
                Me._freezeHeader = value
                Me.Invalidate()
            End Set
        End Property

        Public Property HighlightNullBytes() As Boolean
            Get
                Return Me._highlightNullBytes
            End Get
            Set(ByVal value As Boolean)
                Me._highlightNullBytes = value
                Me.Invalidate()
            End Set
        End Property

        Public Property HighlightControlBytes() As Boolean
            Get
                Return Me._highlightControlBytes
            End Get
            Set(ByVal value As Boolean)
                Me._highlightControlBytes = value
                Me.Invalidate()
            End Set
        End Property

        Public Property HighlightHighAsciiBytes() As Boolean
            Get
                Return Me._highlightHighAsciiBytes
            End Get
            Set(ByVal value As Boolean)
                Me._highlightHighAsciiBytes = value
                Me.Invalidate()
            End Set
        End Property

        Public Property HighlightNonPrintableBytes() As Boolean
            Get
                Return Me._highlightNonPrintableBytes
            End Get
            Set(ByVal value As Boolean)
                Me._highlightNonPrintableBytes = value
                Me.Invalidate()
            End Set
        End Property

        Public ReadOnly Property CurrentOffset() As Integer
            Get
                Return Me._currentOffset
            End Get
        End Property

        Public ReadOnly Property SelectionStart() As Integer
            Get
                Return Me._selectionStart
            End Get
        End Property

        Public ReadOnly Property SelectionLength() As Integer
            Get
                Return Me._selectionLength
            End Get
        End Property

        Public ReadOnly Property FirstVisibleOffset() As Integer
            Get
                Return Me.GetFirstVisibleOffset()
            End Get
        End Property

        Public ReadOnly Property LastVisibleOffset() As Integer
            Get
                Return Me.GetLastVisibleOffset()
            End Get
        End Property

        Public Sub New()
            Me.DoubleBuffered = True
            Me.BackColor = Color.FromArgb(12, 17, 24)
            Me.ForeColor = Color.FromArgb(238, 238, 230)
            Me.Font = New Font("Consolas", 8.0F)
            Me.TabStop = True

            Me.SetStyle(ControlStyles.Selectable, True)
            Me.SetStyle(ControlStyles.UserPaint, True)
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

            Me._lines.Dock = DockStyle.Right
            AddHandler Me._lines.Scroll, AddressOf Me.ScrollBar_Scroll
            Me.Controls.Add(Me._lines)
        End Sub

        Public Sub SetBytes(ByVal bytes As Byte())
            If bytes Is Nothing Then
                Me._bytes = New Byte() {}
            Else
                Me._bytes = bytes
            End If

            Me._firstLine = 0
            Me._currentOffset = If(Me._bytes.Length > 0, 0, -1)
            Me._selectionStart = -1
            Me._selectionLength = 0
            Me._selectionAnchor = -1
            Me._isSelecting = False

            Me.UpdateScrollBar()
            Me.RaiseCurrentByteChanged()
            Me.RaiseSelectionChanged()
            Me.RaiseVisibleRangeChanged()
            Me.Invalidate()
        End Sub

        Public Sub JumpToOffset(ByVal offset As Integer)
            If Me._bytes Is Nothing OrElse Me._bytes.Length = 0 Then
                Return
            End If

            If offset < 0 Then
                offset = 0
            End If

            If offset >= Me._bytes.Length Then
                offset = Me._bytes.Length - 1
            End If

            Dim targetLine As Integer = Me.GetLineForOffset(offset)
            Dim visibleLines As Integer = Me.GetVisibleDataLines()

            If targetLine < Me._firstLine Then
                Me.SetFirstLine(targetLine)
            ElseIf targetLine >= Me._firstLine + visibleLines Then
                Me.SetFirstLine(targetLine - visibleLines + 1)
            End If

            Me._currentOffset = offset
            Me.RaiseCurrentByteChanged()
            Me.RaiseVisibleRangeChanged()
            Me.Invalidate()
        End Sub

        Public Sub SelectRange(ByVal startOffset As Integer, ByVal length As Integer)
            If Me._bytes Is Nothing OrElse Me._bytes.Length = 0 Then
                Me.ClearSelection()
                Return
            End If

            If startOffset < 0 Then
                startOffset = 0
            End If

            If startOffset >= Me._bytes.Length Then
                startOffset = Me._bytes.Length - 1
            End If

            If length < 0 Then
                length = 0
            End If

            If startOffset + length > Me._bytes.Length Then
                length = Me._bytes.Length - startOffset
            End If

            Me._selectionStart = startOffset
            Me._selectionLength = length
            Me._currentOffset = startOffset

            Me.JumpToOffset(startOffset)
            Me.RaiseSelectionChanged()
            Me.RaiseCurrentByteChanged()
            Me.Invalidate()
        End Sub

        Public Sub ClearSelection()
            Me._selectionStart = -1
            Me._selectionLength = 0
            Me._selectionAnchor = -1
            Me._isSelecting = False
            Me.RaiseSelectionChanged()
            Me.Invalidate()
        End Sub

        Private Sub ScrollBar_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
            Me._firstLine = Me.GetScrollValueAsFirstLine()
            Me.RaiseVisibleRangeChanged()
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Me.UpdateScrollBar()
            Me.RaiseVisibleRangeChanged()
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            Me.Focus()
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)

            If e.Button <> MouseButtons.Left Then
                Return
            End If

            Me.Focus()

            Dim offset As Integer = Me.HitTestOffset(e.Location)
            If offset < 0 Then
                Return
            End If

            Me._isSelecting = True
            Me._selectionAnchor = offset
            Me._currentOffset = offset
            Me._selectionStart = offset
            Me._selectionLength = 1

            Me.Capture = True
            Me.RaiseCurrentByteChanged()
            Me.RaiseSelectionChanged()
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)

            If Not Me._isSelecting Then
                Return
            End If

            Dim offset As Integer = Me.HitTestOffset(e.Location)
            If offset < 0 Then
                Return
            End If

            Me.UpdateDragSelection(Me._selectionAnchor, offset)
            Me._currentOffset = offset
            Me.RaiseCurrentByteChanged()
            Me.RaiseSelectionChanged()
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)

            If e.Button = MouseButtons.Left Then
                Me._isSelecting = False
                Me.Capture = False
            End If
        End Sub

        Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
            MyBase.OnMouseWheel(e)

            If Not Me._lines.Enabled Then
                Return
            End If

            Dim deltaLines As Integer = -(e.Delta \ 120)
            If deltaLines = 0 Then
                If e.Delta < 0 Then
                    deltaLines = 1
                ElseIf e.Delta > 0 Then
                    deltaLines = -1
                End If
            End If

            Me.SetFirstLine(Me._firstLine + deltaLines)
        End Sub

        Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean
            Select Case keyData
                Case Keys.Up, Keys.Down, Keys.PageUp, Keys.PageDown, Keys.Home, Keys.End, Keys.Left, Keys.Right
                    Return True
            End Select

            Return MyBase.IsInputKey(keyData)
        End Function

        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            MyBase.OnKeyDown(e)

            Select Case e.KeyCode
                Case Keys.Up
                    Me.MoveCurrentOffset(-Me.GetUnitsPerLine(), e.Shift)
                    e.Handled = True

                Case Keys.Down
                    Me.MoveCurrentOffset(Me.GetUnitsPerLine(), e.Shift)
                    e.Handled = True

                Case Keys.Left
                    Me.MoveCurrentOffset(-1, e.Shift)
                    e.Handled = True

                Case Keys.Right
                    Me.MoveCurrentOffset(1, e.Shift)
                    e.Handled = True

                Case Keys.PageUp
                    Me.SetFirstLine(Me._firstLine - Me.GetVisibleDataLines())
                    e.Handled = True

                Case Keys.PageDown
                    Me.SetFirstLine(Me._firstLine + Me.GetVisibleDataLines())
                    e.Handled = True

                Case Keys.Home
                    Me.JumpToOffset(0)
                    e.Handled = True

                Case Keys.End
                    If Me._bytes IsNot Nothing AndAlso Me._bytes.Length > 0 Then
                        Me.JumpToOffset(Me._bytes.Length - 1)
                    End If
                    e.Handled = True
            End Select
        End Sub

        Private Sub MoveCurrentOffset(ByVal delta As Integer, ByVal extendSelection As Boolean)
            If Me._bytes Is Nothing OrElse Me._bytes.Length = 0 Then
                Return
            End If

            If Me._currentOffset < 0 Then
                Me._currentOffset = 0
            End If

            Dim oldOffset As Integer = Me._currentOffset
            Dim newOffset As Integer = oldOffset + delta

            If newOffset < 0 Then newOffset = 0
            If newOffset >= Me._bytes.Length Then newOffset = Me._bytes.Length - 1

            Me._currentOffset = newOffset

            If extendSelection Then
                If Me._selectionAnchor < 0 Then
                    Me._selectionAnchor = oldOffset
                End If
                Me.UpdateDragSelection(Me._selectionAnchor, newOffset)
            Else
                Me._selectionAnchor = newOffset
                Me._selectionStart = newOffset
                Me._selectionLength = 1
            End If

            Me.JumpToOffset(newOffset)
            Me.RaiseCurrentByteChanged()
            Me.RaiseSelectionChanged()
            Me.Invalidate()
        End Sub

        Private Sub UpdateDragSelection(ByVal anchorOffset As Integer, ByVal currentOffset As Integer)
            If anchorOffset < 0 OrElse currentOffset < 0 Then
                Return
            End If

            If currentOffset < anchorOffset Then
                Me._selectionStart = currentOffset
                Me._selectionLength = anchorOffset - currentOffset + 1
            Else
                Me._selectionStart = anchorOffset
                Me._selectionLength = currentOffset - anchorOffset + 1
            End If
        End Sub

        Private Sub SetFirstLine(ByVal value As Integer)
            Dim maxFirstLine As Integer = Me.GetMaxFirstLine()

            If value < 0 Then value = 0
            If value > maxFirstLine Then value = maxFirstLine

            Me._firstLine = value

            If Me._lines.Enabled Then
                Dim scrollValue As Integer = Me.GetFirstLineAsScrollValue(value)
                If Me._lines.Value <> scrollValue Then
                    Me._lines.Value = scrollValue
                End If
            End If

            Me.RaiseVisibleRangeChanged()
            Me.Invalidate()
        End Sub

        Private Sub UpdateScrollBar()
            Dim totalLines As Integer = Me.GetTotalLines()
            Dim visibleLines As Integer = Me.GetVisibleDataLines()
            Dim maxFirstLine As Integer = Math.Max(0, totalLines - visibleLines)

            Me._lines.Minimum = 0
            Me._lines.SmallChange = 1
            Me._lines.LargeChange = Math.Max(1, visibleLines)
            Me._lines.Maximum = maxFirstLine + Me._lines.LargeChange - 1
            Me._lines.Enabled = (totalLines > visibleLines)

            If Me._firstLine > maxFirstLine Then Me._firstLine = maxFirstLine
            If Me._firstLine < 0 Then Me._firstLine = 0

            If Me._lines.Enabled Then
                Me._lines.Value = Me.GetFirstLineAsScrollValue(Me._firstLine)
            Else
                Me._lines.Value = 0
                Me._firstLine = 0
            End If
        End Sub

        Private Function GetFirstLineAsScrollValue(ByVal firstLine As Integer) As Integer
            Dim maxValue As Integer = Me._lines.Maximum - Me._lines.LargeChange + 1
            Return Math.Max(Me._lines.Minimum, Math.Min(firstLine, maxValue))
        End Function

        Private Function GetScrollValueAsFirstLine() As Integer
            Return Math.Max(0, Math.Min(Me._lines.Value, Me.GetMaxFirstLine()))
        End Function

        Private Function GetVisibleDataLines() As Integer
            Dim headerHeight As Integer = Me._lineHeight + 12
            Dim availableHeight As Integer = Me.ClientSize.Height - headerHeight - 8

            If availableHeight < Me._lineHeight Then
                Return 1
            End If

            Return Math.Max(1, CInt(Math.Floor(availableHeight / CDbl(Me._lineHeight))))
        End Function

        Private Function GetMaxFirstLine() As Integer
            Return Math.Max(0, Me.GetTotalLines() - Me.GetVisibleDataLines())
        End Function

        Private Function GetUnitsPerLine() As Integer
            Select Case Me._displayMode
                Case DarkByteViewerDisplayMode.Ansi
                    Return 80
                Case DarkByteViewerDisplayMode.Unicode
                    Return 160
                Case Else
                    Return Me._bytesPerLine
            End Select
        End Function

        Private Function GetLineForOffset(ByVal offset As Integer) As Integer
            Select Case Me._displayMode
                Case DarkByteViewerDisplayMode.Ansi
                    Return offset \ 80
                Case DarkByteViewerDisplayMode.Unicode
                    Return (offset \ 2) \ 80
                Case Else
                    Return offset \ Me._bytesPerLine
            End Select
        End Function

        Private Function GetOffsetForLine(ByVal line As Integer) As Integer
            Select Case Me._displayMode
                Case DarkByteViewerDisplayMode.Ansi
                    Return line * 80
                Case DarkByteViewerDisplayMode.Unicode
                    Return line * 80 * 2
                Case Else
                    Return line * Me._bytesPerLine
            End Select
        End Function

        Private Function GetTotalLines() As Integer
            Select Case Me._displayMode
                Case DarkByteViewerDisplayMode.Ansi
                    Return Math.Max(1, CInt(Math.Ceiling(Me._bytes.Length / 80.0R)))

                Case DarkByteViewerDisplayMode.Unicode
                    Dim charCount As Integer = 0
                    If Me._bytes IsNot Nothing AndAlso Me._bytes.Length > 1 Then
                        charCount = Me._bytes.Length \ 2
                    End If
                    Return Math.Max(1, CInt(Math.Ceiling(charCount / 80.0R)))

                Case Else
                    Return Math.Max(1, CInt(Math.Ceiling(Me._bytes.Length / CDbl(Me._bytesPerLine))))
            End Select
        End Function

        Private Function GetFirstVisibleOffset() As Integer
            If Me._bytes Is Nothing OrElse Me._bytes.Length = 0 Then
                Return 0
            End If

            Return Math.Max(0, Math.Min(Me.GetOffsetForLine(Me._firstLine), Me._bytes.Length - 1))
        End Function

        Private Function GetLastVisibleOffset() As Integer
            If Me._bytes Is Nothing OrElse Me._bytes.Length = 0 Then
                Return 0
            End If

            Dim lastLine As Integer = Me._firstLine + Me.GetVisibleDataLines() - 1
            Dim lastOffset As Integer = Me.GetOffsetForLine(lastLine) + Me.GetUnitsPerLine() - 1
            Return Math.Max(0, Math.Min(lastOffset, Me._bytes.Length - 1))
        End Function

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)

            Select Case Me._displayMode
                Case DarkByteViewerDisplayMode.Ansi
                    Me.PaintAnsi(e.Graphics)

                Case DarkByteViewerDisplayMode.Unicode
                    Me.PaintUnicode(e.Graphics)

                Case Else
                    Me.PaintHexdump(e.Graphics)
            End Select
        End Sub

        Private Sub PaintHexdump(ByVal g As Graphics)
            Dim fontMain As Font = Me.Font
            Dim brushText As New SolidBrush(Color.FromArgb(238, 238, 230))
            Dim brushMuted As New SolidBrush(Color.FromArgb(188, 198, 210))
            Dim brushGold As New SolidBrush(Color.FromArgb(210, 184, 112))
            Dim brushAltRow As New SolidBrush(Color.FromArgb(16, 22, 31))
            Dim brushSelected As New SolidBrush(Color.FromArgb(70, 90, 120))
            Dim brushCurrent As New SolidBrush(Color.FromArgb(92, 70, 34))
            Dim brushNull As New SolidBrush(Color.FromArgb(44, 32, 32))
            Dim brushControl As New SolidBrush(Color.FromArgb(44, 38, 28))
            Dim brushHighAscii As New SolidBrush(Color.FromArgb(28, 42, 46))
            Dim brushNonPrintable As New SolidBrush(Color.FromArgb(38, 30, 46))

            Dim y As Integer = Me._headerY

            g.DrawString("OFFSET", fontMain, brushGold, Me._xOffset, y)
            g.DrawString("00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F", fontMain, brushGold, Me._xHex, y)
            g.DrawString("ASCII", fontMain, brushGold, Me._xAscii, y)

            y = Me._dataStartY

            Dim visibleLines As Integer = Me.GetVisibleDataLines()
            Dim lineIndex As Integer

            For lineIndex = 0 To visibleLines - 1
                Dim byteOffset As Integer = (Me._firstLine + lineIndex) * Me._bytesPerLine

                If byteOffset >= Me._bytes.Length Then
                    Exit For
                End If

                If Me._alternateRows AndAlso ((Me._firstLine + lineIndex) Mod 2) = 1 Then
                    g.FillRectangle(brushAltRow, 0, y - 1, Me.ClientSize.Width - Me._lines.Width, Me._lineHeight)
                End If

                g.DrawString(byteOffset.ToString("X8"), fontMain, brushText, Me._xOffset, y)

                Dim i As Integer
                For i = 0 To Me._bytesPerLine - 1
                    Dim idx As Integer = byteOffset + i
                    If idx >= Me._bytes.Length Then
                        Exit For
                    End If

                    Dim b As Byte = Me._bytes(idx)
                    Dim hexX As Integer = Me._xHex + (i * Me._hexCellWidth)
                    Dim asciiX As Integer = Me._xAscii + (i * Me._asciiCellWidth)

                    Me.PaintByteBackground(g, idx, b, hexX, asciiX, y, brushSelected, brushCurrent, brushNull, brushControl, brushHighAscii, brushNonPrintable)

                    g.DrawString(b.ToString("X2"), fontMain, brushMuted, hexX, y)
                    g.DrawString(Me.ToPrintableAscii(b).ToString(), fontMain, brushText, asciiX, y)
                Next

                y += Me._lineHeight
            Next

            brushText.Dispose()
            brushMuted.Dispose()
            brushGold.Dispose()
            brushAltRow.Dispose()
            brushSelected.Dispose()
            brushCurrent.Dispose()
            brushNull.Dispose()
            brushControl.Dispose()
            brushHighAscii.Dispose()
            brushNonPrintable.Dispose()
        End Sub

        Private Sub PaintByteBackground(ByVal g As Graphics, ByVal offset As Integer, ByVal value As Byte, ByVal hexX As Integer, ByVal asciiX As Integer, ByVal y As Integer, ByVal brushSelected As Brush, ByVal brushCurrent As Brush, ByVal brushNull As Brush, ByVal brushControl As Brush, ByVal brushHighAscii As Brush, ByVal brushNonPrintable As Brush)
            Dim brushToUse As Brush = Nothing

            If Me.IsOffsetSelected(offset) Then
                brushToUse = brushSelected
            ElseIf offset = Me._currentOffset Then
                brushToUse = brushCurrent
            ElseIf Me._highlightNullBytes AndAlso value = 0 Then
                brushToUse = brushNull
            ElseIf Me._highlightControlBytes AndAlso value < 32 AndAlso value <> 0 Then
                brushToUse = brushControl
            ElseIf Me._highlightHighAsciiBytes AndAlso value >= 128 Then
                brushToUse = brushHighAscii
            ElseIf Me._highlightNonPrintableBytes AndAlso Not Me.IsPrintableAscii(value) Then
                brushToUse = brushNonPrintable
            End If

            If brushToUse IsNot Nothing Then
                g.FillRectangle(brushToUse, hexX - 1, y - 1, 18, Me._lineHeight)
                g.FillRectangle(brushToUse, asciiX - 1, y - 1, 8, Me._lineHeight)
            End If
        End Sub

        Private Sub PaintAnsi(ByVal g As Graphics)
            Dim brushText As New SolidBrush(Color.FromArgb(238, 238, 230))
            Dim brushGold As New SolidBrush(Color.FromArgb(210, 184, 112))
            Dim brushAltRow As New SolidBrush(Color.FromArgb(16, 22, 31))
            Dim y As Integer = 8
            Dim charsPerLine As Integer = 80

            g.DrawString("ANSI TEXT VIEW", Me.Font, brushGold, 8, y)
            y += Me._lineHeight + 4

            Dim visibleLines As Integer = Me.GetVisibleDataLines()
            Dim lineIndex As Integer

            For lineIndex = 0 To visibleLines - 1
                Dim byteOffset As Integer = (Me._firstLine + lineIndex) * charsPerLine

                If byteOffset >= Me._bytes.Length Then
                    Exit For
                End If

                If Me._alternateRows AndAlso ((Me._firstLine + lineIndex) Mod 2) = 1 Then
                    g.FillRectangle(brushAltRow, 0, y - 1, Me.ClientSize.Width - Me._lines.Width, Me._lineHeight)
                End If

                Dim textLine As New StringBuilder()
                Dim i As Integer

                For i = 0 To charsPerLine - 1
                    Dim idx As Integer = byteOffset + i

                    If idx < Me._bytes.Length Then
                        textLine.Append(Me.ToPrintableAscii(Me._bytes(idx)))
                    End If
                Next

                g.DrawString(textLine.ToString(), Me.Font, brushText, 8, y)
                y += Me._lineHeight
            Next

            brushText.Dispose()
            brushGold.Dispose()
            brushAltRow.Dispose()
        End Sub

        Private Sub PaintUnicode(ByVal g As Graphics)
            Dim brushText As New SolidBrush(Color.FromArgb(238, 238, 230))
            Dim brushGold As New SolidBrush(Color.FromArgb(210, 184, 112))
            Dim brushAltRow As New SolidBrush(Color.FromArgb(16, 22, 31))
            Dim y As Integer = 8
            Dim charsPerLine As Integer = 80
            Dim text As String = ""

            If Me._bytes.Length > 1 Then
                Try
                    text = Encoding.Unicode.GetString(Me._bytes)
                Catch
                    text = ""
                End Try
            End If

            g.DrawString("UNICODE TEXT VIEW", Me.Font, brushGold, 8, y)
            y += Me._lineHeight + 4

            Dim visibleLines As Integer = Me.GetVisibleDataLines()
            Dim lineIndex As Integer

            For lineIndex = 0 To visibleLines - 1
                Dim charOffset As Integer = (Me._firstLine + lineIndex) * charsPerLine

                If charOffset >= text.Length Then
                    Exit For
                End If

                If Me._alternateRows AndAlso ((Me._firstLine + lineIndex) Mod 2) = 1 Then
                    g.FillRectangle(brushAltRow, 0, y - 1, Me.ClientSize.Width - Me._lines.Width, Me._lineHeight)
                End If

                Dim takeCount As Integer = Math.Min(charsPerLine, text.Length - charOffset)
                Dim line As String = text.Substring(charOffset, takeCount)
                line = Me.SanitiseTextLine(line)

                g.DrawString(line, Me.Font, brushText, 8, y)
                y += Me._lineHeight
            Next

            brushText.Dispose()
            brushGold.Dispose()
            brushAltRow.Dispose()
        End Sub

        Private Function HitTestOffset(ByVal point As Point) As Integer
            If Me._displayMode <> DarkByteViewerDisplayMode.Hexdump Then
                Return -1
            End If

            If point.Y < Me._dataStartY Then
                Return -1
            End If

            Dim lineIndex As Integer = (point.Y - Me._dataStartY) \ Me._lineHeight
            If lineIndex < 0 OrElse lineIndex >= Me.GetVisibleDataLines() Then
                Return -1
            End If

            Dim byteColumn As Integer = -1

            If point.X >= Me._xHex AndAlso point.X < Me._xHex + (Me._bytesPerLine * Me._hexCellWidth) Then
                byteColumn = (point.X - Me._xHex) \ Me._hexCellWidth
            ElseIf point.X >= Me._xAscii AndAlso point.X < Me._xAscii + (Me._bytesPerLine * Me._asciiCellWidth) Then
                byteColumn = (point.X - Me._xAscii) \ Me._asciiCellWidth
            End If

            If byteColumn < 0 OrElse byteColumn >= Me._bytesPerLine Then
                Return -1
            End If

            Dim offset As Integer = ((Me._firstLine + lineIndex) * Me._bytesPerLine) + byteColumn
            If offset < 0 OrElse offset >= Me._bytes.Length Then
                Return -1
            End If

            Return offset
        End Function

        Private Function IsOffsetSelected(ByVal offset As Integer) As Boolean
            If Me._selectionStart < 0 OrElse Me._selectionLength <= 0 Then
                Return False
            End If

            Return offset >= Me._selectionStart AndAlso offset < (Me._selectionStart + Me._selectionLength)
        End Function

        Private Function IsPrintableAscii(ByVal value As Byte) As Boolean
            Return value >= 32 AndAlso value <= 126
        End Function

        Private Function ToPrintableAscii(ByVal value As Byte) As Char
            If Me.IsPrintableAscii(value) Then
                Return Convert.ToChar(value)
            End If

            Return "."c
        End Function

        Private Function SanitiseTextLine(ByVal value As String) As String
            If value Is Nothing Then
                Return ""
            End If

            Dim sb As New StringBuilder()
            Dim i As Integer

            For i = 0 To value.Length - 1
                Dim ch As Char = value.Chars(i)

                If Char.IsControl(ch) Then
                    sb.Append("."c)
                Else
                    sb.Append(ch)
                End If
            Next

            Return sb.ToString()
        End Function

        Private Sub RaiseCurrentByteChanged()
            If Me._bytes Is Nothing OrElse Me._bytes.Length = 0 Then
                Return
            End If

            If Me._currentOffset < 0 OrElse Me._currentOffset >= Me._bytes.Length Then
                Return
            End If

            RaiseEvent CurrentByteChanged(Me._currentOffset, Me._bytes(Me._currentOffset))
        End Sub

        Private Sub RaiseSelectionChanged()
            RaiseEvent SelectionChanged(Me._selectionStart, Me._selectionLength)
        End Sub

        Private Sub RaiseVisibleRangeChanged()
            RaiseEvent VisibleRangeChanged(Me.GetFirstVisibleOffset(), Me.GetLastVisibleOffset())
        End Sub

    End Class

End Namespace
