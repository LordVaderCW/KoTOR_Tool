Option Strict Off
Option Explicit On

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace kotor_tool

    Public Class DarkPictureBox
        Inherits PictureBox

        Private _borderColor As Color = Color.FromArgb(210, 184, 112)
        Private _borderColorSecondary As Color = Color.FromArgb(92, 104, 122)
        Private _outerShadowColor As Color = Color.Black
        Private _innerHighlightColor As Color = Color.FromArgb(34, 42, 52)

        Private _cornerRadius As Integer = 8
        Private _borderThickness As Integer = 2
        Private _secondaryBorderThickness As Integer = 1
        Private _outerShadowThickness As Integer = 2
        Private _innerPadding As Integer = 8
        Private _useSecondaryBorder As Boolean = True
        Private _useInnerHighlight As Boolean = True

        Public Sub New()
            MyBase.New()

            Me.BackColor = Color.FromArgb(10, 14, 20)
            Me.ForeColor = Color.FromArgb(238, 238, 230)
            Me.SizeMode = PictureBoxSizeMode.Zoom
            Me.BorderStyle = BorderStyle.None
            Me.DoubleBuffered = True
            Me.ResizeRedraw = True
        End Sub

        Public Property BorderColor() As Color
            Get
                Return _borderColor
            End Get
            Set(ByVal value As Color)
                _borderColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property BorderColorSecondary() As Color
            Get
                Return _borderColorSecondary
            End Get
            Set(ByVal value As Color)
                _borderColorSecondary = value
                Me.Invalidate()
            End Set
        End Property

        Public Property OuterShadowColor() As Color
            Get
                Return _outerShadowColor
            End Get
            Set(ByVal value As Color)
                _outerShadowColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property InnerHighlightColor() As Color
            Get
                Return _innerHighlightColor
            End Get
            Set(ByVal value As Color)
                _innerHighlightColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property CornerRadius() As Integer
            Get
                Return _cornerRadius
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                _cornerRadius = value
                Me.Invalidate()
            End Set
        End Property

        Public Property BorderThickness() As Integer
            Get
                Return _borderThickness
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                _borderThickness = value
                Me.Invalidate()
            End Set
        End Property

        Public Property SecondaryBorderThickness() As Integer
            Get
                Return _secondaryBorderThickness
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                _secondaryBorderThickness = value
                Me.Invalidate()
            End Set
        End Property

        Public Property OuterShadowThickness() As Integer
            Get
                Return _outerShadowThickness
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                _outerShadowThickness = value
                Me.Invalidate()
            End Set
        End Property

        Public Property InnerPadding() As Integer
            Get
                Return _innerPadding
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                _innerPadding = value
                Me.Invalidate()
            End Set
        End Property

        Public Property UseSecondaryBorder() As Boolean
            Get
                Return _useSecondaryBorder
            End Get
            Set(ByVal value As Boolean)
                _useSecondaryBorder = value
                Me.Invalidate()
            End Set
        End Property

        Public Property UseInnerHighlight() As Boolean
            Get
                Return _useInnerHighlight
            End Get
            Set(ByVal value As Boolean)
                _useInnerHighlight = value
                Me.Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

            If Me.Width <= 2 OrElse Me.Height <= 2 Then
                Return
            End If

            Dim outerRect As New Rectangle(1, 1, Me.Width - 3, Me.Height - 3)
            Dim borderRect As New Rectangle(3, 3, Me.Width - 7, Me.Height - 7)
            Dim secondaryRect As New Rectangle(6, 6, Me.Width - 13, Me.Height - 13)
            Dim highlightRect As New Rectangle(8, 8, Me.Width - 17, Me.Height - 17)

            Using backBrush As New SolidBrush(Me.BackColor)
                Using outerPath As GraphicsPath = CreateRoundRectPath(outerRect, _cornerRadius)
                    pe.Graphics.FillPath(backBrush, outerPath)
                End Using
            End Using

            DrawImageContent(pe.Graphics)

            Using shadowPen As New Pen(_outerShadowColor, _outerShadowThickness)
                Using shadowPath As GraphicsPath = CreateRoundRectPath(outerRect, _cornerRadius)
                    pe.Graphics.DrawPath(shadowPen, shadowPath)
                End Using
            End Using

            Using borderPen As New Pen(_borderColor, _borderThickness)
                Using borderPath As GraphicsPath = CreateRoundRectPath(borderRect, Math.Max(0, _cornerRadius - 2))
                    pe.Graphics.DrawPath(borderPen, borderPath)
                End Using
            End Using

            If _useSecondaryBorder Then
                Using secondaryPen As New Pen(_borderColorSecondary, _secondaryBorderThickness)
                    Using secondaryPath As GraphicsPath = CreateRoundRectPath(secondaryRect, Math.Max(0, _cornerRadius - 4))
                        pe.Graphics.DrawPath(secondaryPen, secondaryPath)
                    End Using
                End Using
            End If

            If _useInnerHighlight Then
                Using highlightPen As New Pen(_innerHighlightColor, 1)
                    Using highlightPath As GraphicsPath = CreateRoundRectPath(highlightRect, Math.Max(0, _cornerRadius - 5))
                        pe.Graphics.DrawPath(highlightPen, highlightPath)
                    End Using
                End Using
            End If
        End Sub

        Private Sub DrawImageContent(ByVal g As Graphics)
            If Me.Image Is Nothing Then
                Return
            End If

            Dim contentRect As New Rectangle(
                _innerPadding,
                _innerPadding,
                Me.Width - (_innerPadding * 2),
                Me.Height - (_innerPadding * 2))

            If contentRect.Width <= 0 OrElse contentRect.Height <= 0 Then
                Return
            End If

            Dim destRect As Rectangle = GetImageRectangle(contentRect)

            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.DrawImage(Me.Image, destRect)
        End Sub

        Private Function GetImageRectangle(ByVal bounds As Rectangle) As Rectangle
            If Me.Image Is Nothing Then
                Return bounds
            End If

            If Me.SizeMode = PictureBoxSizeMode.StretchImage Then
                Return bounds
            End If

            If Me.SizeMode = PictureBoxSizeMode.CenterImage Then
                Return New Rectangle(
                    bounds.X + ((bounds.Width - Me.Image.Width) \ 2),
                    bounds.Y + ((bounds.Height - Me.Image.Height) \ 2),
                    Me.Image.Width,
                    Me.Image.Height)
            End If

            Dim imageRatio As Double = CDbl(Me.Image.Width) / CDbl(Me.Image.Height)
            Dim boundsRatio As Double = CDbl(bounds.Width) / CDbl(bounds.Height)

            Dim width As Integer
            Dim height As Integer

            If imageRatio > boundsRatio Then
                width = bounds.Width
                height = CInt(bounds.Width / imageRatio)
            Else
                height = bounds.Height
                width = CInt(bounds.Height * imageRatio)
            End If

            Return New Rectangle(
                bounds.X + ((bounds.Width - width) \ 2),
                bounds.Y + ((bounds.Height - height) \ 2),
                width,
                height)
        End Function

        Private Function CreateRoundRectPath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
            Dim path As New GraphicsPath()

            If rect.Width <= 0 OrElse rect.Height <= 0 Then
                Return path
            End If

            If radius <= 0 Then
                path.AddRectangle(rect)
                path.CloseFigure()
                Return path
            End If

            Dim maxRadius As Integer = Math.Min(rect.Width, rect.Height) \ 2
            If radius > maxRadius Then
                radius = maxRadius
            End If

            Dim diameter As Integer = radius * 2

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
            path.CloseFigure()

            Return path
        End Function

    End Class

End Namespace