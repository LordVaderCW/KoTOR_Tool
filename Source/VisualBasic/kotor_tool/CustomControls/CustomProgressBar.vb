Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace kotor_tool

    <ToolboxItem(True)>
    <DefaultProperty("Value")>
    <DefaultEvent("Click")>
    Public Class CustomProgressBar
        Inherits Control

        Private _minimum As Integer = 0
        Private _maximum As Integer = 100
        Private _value As Integer = 0
        Private _displayValue As Double = 0.0R
        Private _step As Integer = 10

        Private _animationEnabled As Boolean = True
        Private _animationSpeed As Double = 0.18R
        Private _animationInterval As Integer = 35
        Private _sweepSpeed As Integer = 3
        Private _sweepOpacity As Integer = 95
        Private _sweepWidth As Integer = 0
        Private _animationOffset As Integer = 0
        Private WithEvents _animationTimer As Timer

        Private _borderDark As Color = Color.FromArgb(8, 10, 14)
        Private _borderGold As Color = Color.FromArgb(174, 136, 58)
        Private _trackTop As Color = Color.FromArgb(13, 18, 25)
        Private _trackBottom As Color = Color.FromArgb(7, 10, 15)
        Private _fillTop As Color = Color.FromArgb(238, 214, 132)
        Private _fillMid As Color = Color.FromArgb(210, 184, 112)
        Private _fillBottom As Color = Color.FromArgb(142, 101, 38)
        Private _shineTop As Color = Color.FromArgb(135, 255, 246, 190)
        Private _shineBottom As Color = Color.FromArgb(15, 255, 246, 190)
        Private _edgeLight As Color = Color.FromArgb(210, 255, 232, 150)
        Private _bottomGlow As Color = Color.FromArgb(90, 88, 55, 20)
        Private _insetHighlight As Color = Color.FromArgb(45, 255, 255, 255)
        Private _trackShadow As Color = Color.FromArgb(120, 0, 0, 0)
        Private _sweepColor As Color = Color.FromArgb(255, 245, 180)

        Private _outerBorderSize As Integer = 1
        Private _goldBorderSize As Integer = 1
        Private _trackPadding As Integer = 2
        Private _fillPadding As Integer = 3
        Private _showTrackHighlight As Boolean = True
        Private _showTrackShadow As Boolean = True
        Private _showFillShine As Boolean = True
        Private _showLeadingEdge As Boolean = True
        Private _showBottomGlow As Boolean = True

        Public Sub New()
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                        ControlStyles.UserPaint Or
                        ControlStyles.OptimizedDoubleBuffer Or
                        ControlStyles.ResizeRedraw Or
                        ControlStyles.SupportsTransparentBackColor, True)

            Me.BackColor = Color.FromArgb(10, 14, 20)
            Me.ForeColor = Color.FromArgb(210, 184, 112)
            Me.Size = New Size(248, 18)
            Me.MinimumSize = New Size(40, 12)

            Me._animationTimer = New Timer()
            Me._animationTimer.Interval = _animationInterval
            Me._animationTimer.Start()
        End Sub

        <Category("Progress")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("The minimum progress value.")>
        <DefaultValue(0)>
        Public Property Minimum() As Integer
            Get
                Return _minimum
            End Get
            Set(ByVal value As Integer)
                _minimum = value
                If _maximum < _minimum Then _maximum = _minimum
                If _value < _minimum Then _value = _minimum
                If _displayValue < CDbl(_minimum) Then _displayValue = CDbl(_minimum)
                Me.Invalidate()
            End Set
        End Property

        <Category("Progress")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("The maximum progress value.")>
        <DefaultValue(100)>
        Public Property Maximum() As Integer
            Get
                Return _maximum
            End Get
            Set(ByVal value As Integer)
                _maximum = value
                If _maximum < _minimum Then _minimum = _maximum
                If _value > _maximum Then _value = _maximum
                If _displayValue > CDbl(_maximum) Then _displayValue = CDbl(_maximum)
                Me.Invalidate()
            End Set
        End Property

        <Category("Progress")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("The current target progress value. The rendered bar animates toward this value.")>
        <DefaultValue(0)>
        Public Property Value() As Integer
            Get
                Return _value
            End Get
            Set(ByVal value As Integer)
                If value < _minimum Then
                    _value = _minimum
                ElseIf value > _maximum Then
                    _value = _maximum
                Else
                    _value = value
                End If

                If Not _animationEnabled Then
                    _displayValue = CDbl(_value)
                End If

                If _animationTimer IsNot Nothing AndAlso _animationEnabled Then
                    _animationTimer.Start()
                End If

                Me.Invalidate()
            End Set
        End Property

        <Category("Progress")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("The amount added by PerformStep.")>
        <DefaultValue(10)>
        Public Property [Step]() As Integer
            Get
                Return _step
            End Get
            Set(ByVal value As Integer)
                _step = value
            End Set
        End Property

        <Category("Animation")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Enables the smooth count-up/count-down and sweep animation.")>
        <DefaultValue(True)>
        Public Property AnimationEnabled() As Boolean
            Get
                Return _animationEnabled
            End Get
            Set(ByVal value As Boolean)
                _animationEnabled = value

                If _animationTimer IsNot Nothing Then
                    If _animationEnabled Then
                        _animationTimer.Start()
                    Else
                        _animationTimer.Stop()
                        _displayValue = CDbl(_value)
                    End If
                End If

                Me.Invalidate()
            End Set
        End Property

        <Category("Animation")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Controls how quickly the displayed progress catches the target value. Valid range: 0.01 to 1.0.")>
        <DefaultValue(0.18R)>
        Public Property AnimationSpeed() As Double
            Get
                Return _animationSpeed
            End Get
            Set(ByVal value As Double)
                If value < 0.01R Then
                    _animationSpeed = 0.01R
                ElseIf value > 1.0R Then
                    _animationSpeed = 1.0R
                Else
                    _animationSpeed = value
                End If
            End Set
        End Property

        <Category("Animation")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Timer interval in milliseconds. Lower values animate more smoothly but repaint more often.")>
        <DefaultValue(35)>
        Public Property AnimationInterval() As Integer
            Get
                Return _animationInterval
            End Get
            Set(ByVal value As Integer)
                If value < 10 Then
                    _animationInterval = 10
                ElseIf value > 500 Then
                    _animationInterval = 500
                Else
                    _animationInterval = value
                End If

                If _animationTimer IsNot Nothing Then
                    _animationTimer.Interval = _animationInterval
                End If
            End Set
        End Property

        <Category("Animation")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Horizontal speed of the moving sweep highlight.")>
        <DefaultValue(3)>
        Public Property SweepSpeed() As Integer
            Get
                Return _sweepSpeed
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then
                    _sweepSpeed = 1
                ElseIf value > 50 Then
                    _sweepSpeed = 50
                Else
                    _sweepSpeed = value
                End If
            End Set
        End Property

        <Category("Animation")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Opacity of the moving sweep highlight. Valid range: 0 to 255.")>
        <DefaultValue(95)>
        Public Property SweepOpacity() As Integer
            Get
                Return _sweepOpacity
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    _sweepOpacity = 0
                ElseIf value > 255 Then
                    _sweepOpacity = 255
                Else
                    _sweepOpacity = value
                End If
                Me.Invalidate()
            End Set
        End Property

        <Category("Animation")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Width of the sweep highlight. Set to 0 to use automatic width based on control height.")>
        <DefaultValue(0)>
        Public Property SweepWidth() As Integer
            Get
                Return _sweepWidth
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    _sweepWidth = 0
                Else
                    _sweepWidth = value
                End If
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Outer dark border colour.")>
        Public Property BorderDarkColor() As Color
            Get
                Return _borderDark
            End Get
            Set(ByVal value As Color)
                _borderDark = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Gold accent border colour.")>
        Public Property BorderGoldColor() As Color
            Get
                Return _borderGold
            End Get
            Set(ByVal value As Color)
                _borderGold = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Top colour of the empty track gradient.")>
        Public Property TrackTopColor() As Color
            Get
                Return _trackTop
            End Get
            Set(ByVal value As Color)
                _trackTop = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Bottom colour of the empty track gradient.")>
        Public Property TrackBottomColor() As Color
            Get
                Return _trackBottom
            End Get
            Set(ByVal value As Color)
                _trackBottom = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Top colour of the filled progress gradient.")>
        Public Property FillTopColor() As Color
            Get
                Return _fillTop
            End Get
            Set(ByVal value As Color)
                _fillTop = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Middle colour of the filled progress gradient.")>
        Public Property FillMiddleColor() As Color
            Get
                Return _fillMid
            End Get
            Set(ByVal value As Color)
                _fillMid = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Bottom colour of the filled progress gradient.")>
        Public Property FillBottomColor() As Color
            Get
                Return _fillBottom
            End Get
            Set(ByVal value As Color)
                _fillBottom = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Top colour of the fill shine overlay.")>
        Public Property ShineTopColor() As Color
            Get
                Return _shineTop
            End Get
            Set(ByVal value As Color)
                _shineTop = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Bottom colour of the fill shine overlay.")>
        Public Property ShineBottomColor() As Color
            Get
                Return _shineBottom
            End Get
            Set(ByVal value As Color)
                _shineBottom = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Bright leading-edge colour at the end of the filled region.")>
        Public Property EdgeLightColor() As Color
            Get
                Return _edgeLight
            End Get
            Set(ByVal value As Color)
                _edgeLight = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Bottom glow/shadow colour for the filled region.")>
        Public Property BottomGlowColor() As Color
            Get
                Return _bottomGlow
            End Get
            Set(ByVal value As Color)
                _bottomGlow = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Top inset highlight colour for the track.")>
        Public Property InsetHighlightColor() As Color
            Get
                Return _insetHighlight
            End Get
            Set(ByVal value As Color)
                _insetHighlight = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Bottom shadow colour for the track.")>
        Public Property TrackShadowColor() As Color
            Get
                Return _trackShadow
            End Get
            Set(ByVal value As Color)
                _trackShadow = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Colours")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Colour used by the moving sweep highlight.")>
        Public Property SweepColor() As Color
            Get
                Return _sweepColor
            End Get
            Set(ByVal value As Color)
                _sweepColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Layout")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Thickness of the outer dark border.")>
        <DefaultValue(1)>
        Public Property OuterBorderSize() As Integer
            Get
                Return _outerBorderSize
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    _outerBorderSize = 0
                ElseIf value > 6 Then
                    _outerBorderSize = 6
                Else
                    _outerBorderSize = value
                End If
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Layout")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Thickness of the gold accent border.")>
        <DefaultValue(1)>
        Public Property GoldBorderSize() As Integer
            Get
                Return _goldBorderSize
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    _goldBorderSize = 0
                ElseIf value > 6 Then
                    _goldBorderSize = 6
                Else
                    _goldBorderSize = value
                End If
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Layout")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Padding between the border and empty track.")>
        <DefaultValue(2)>
        Public Property TrackPadding() As Integer
            Get
                Return _trackPadding
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    _trackPadding = 0
                ElseIf value > 20 Then
                    _trackPadding = 20
                Else
                    _trackPadding = value
                End If
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Layout")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Padding used for the filled progress region.")>
        <DefaultValue(3)>
        Public Property FillPadding() As Integer
            Get
                Return _fillPadding
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    _fillPadding = 0
                ElseIf value > 20 Then
                    _fillPadding = 20
                Else
                    _fillPadding = value
                End If
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Effects")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Shows the upper inset highlight on the empty track.")>
        <DefaultValue(True)>
        Public Property ShowTrackHighlight() As Boolean
            Get
                Return _showTrackHighlight
            End Get
            Set(ByVal value As Boolean)
                _showTrackHighlight = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Effects")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Shows the lower shadow line on the empty track.")>
        <DefaultValue(True)>
        Public Property ShowTrackShadow() As Boolean
            Get
                Return _showTrackShadow
            End Get
            Set(ByVal value As Boolean)
                _showTrackShadow = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Effects")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Shows the upper shine overlay on the filled progress region.")>
        <DefaultValue(True)>
        Public Property ShowFillShine() As Boolean
            Get
                Return _showFillShine
            End Get
            Set(ByVal value As Boolean)
                _showFillShine = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Effects")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Shows the bright leading edge at the end of the filled progress region.")>
        <DefaultValue(True)>
        Public Property ShowLeadingEdge() As Boolean
            Get
                Return _showLeadingEdge
            End Get
            Set(ByVal value As Boolean)
                _showLeadingEdge = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber Effects")>
        <Browsable(True)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        <Description("Shows the lower glow/shadow line on the filled progress region.")>
        <DefaultValue(True)>
        Public Property ShowBottomGlow() As Boolean
            Get
                Return _showBottomGlow
            End Get
            Set(ByVal value As Boolean)
                _showBottomGlow = value
                Me.Invalidate()
            End Set
        End Property

        Public Sub PerformStep()
            Me.Value = _value + _step
        End Sub

        Public Sub ResetProgress()
            _value = _minimum
            _displayValue = CDbl(_minimum)
            _animationOffset = 0
            Me.Invalidate()
        End Sub

        Public Sub SnapToValue()
            _displayValue = CDbl(_value)
            Me.Invalidate()
        End Sub

        Private Sub AnimationTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles _animationTimer.Tick
            If Not _animationEnabled Then Return
            If Not Me.Visible Then Return

            _animationOffset += _sweepSpeed

            If _animationOffset > Me.Width * 2 Then
                _animationOffset = 0
            End If

            Dim delta As Double = CDbl(_value) - _displayValue

            If Math.Abs(delta) < 0.35R Then
                _displayValue = CDbl(_value)
            Else
                _displayValue += delta * _animationSpeed
            End If

            Me.Invalidate()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If _animationTimer IsNot Nothing Then
                    _animationTimer.Stop()
                    _animationTimer.Dispose()
                    _animationTimer = Nothing
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

            Dim outerRect As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            If outerRect.Width <= 0 OrElse outerRect.Height <= 0 Then Return

            Dim trackInset As Integer = Math.Max(0, _trackPadding)
            Dim fillInset As Integer = Math.Max(0, _fillPadding)

            Dim trackRect As Rectangle = New Rectangle(trackInset, trackInset, Me.Width - (trackInset * 2) - 1, Me.Height - (trackInset * 2) - 1)
            Dim innerRect As Rectangle = New Rectangle(fillInset, fillInset, Me.Width - (fillInset * 2) - 1, Me.Height - (fillInset * 2) - 1)

            If trackRect.Width <= 0 OrElse trackRect.Height <= 0 Then Return
            If innerRect.Width <= 0 OrElse innerRect.Height <= 0 Then Return

            Using bgBrush As New SolidBrush(Me.BackColor)
                e.Graphics.FillRectangle(bgBrush, outerRect)
            End Using

            If _outerBorderSize > 0 Then
                Using outerPen As New Pen(_borderDark, _outerBorderSize)
                    e.Graphics.DrawRectangle(outerPen, outerRect)
                End Using
            End If

            If _goldBorderSize > 0 Then
                Using goldPen As New Pen(_borderGold, _goldBorderSize)
                    e.Graphics.DrawRectangle(goldPen, New Rectangle(1, 1, Me.Width - 3, Me.Height - 3))
                End Using
            End If

            Using trackBrush As New LinearGradientBrush(trackRect, _trackTop, _trackBottom, LinearGradientMode.Vertical)
                e.Graphics.FillRectangle(trackBrush, trackRect)
            End Using

            If _showTrackHighlight Then
                Using insetPen As New Pen(_insetHighlight)
                    e.Graphics.DrawLine(insetPen, trackRect.Left + 1, trackRect.Top + 1, trackRect.Right - 1, trackRect.Top + 1)
                End Using
            End If

            If _showTrackShadow Then
                Using shadowPen As New Pen(_trackShadow)
                    e.Graphics.DrawLine(shadowPen, trackRect.Left + 1, trackRect.Bottom - 1, trackRect.Right - 1, trackRect.Bottom - 1)
                End Using
            End If

            Dim range As Integer = _maximum - _minimum
            If range <= 0 Then Return

            Dim percent As Double

            If _animationEnabled Then
                percent = (_displayValue - CDbl(_minimum)) / CDbl(range)
            Else
                percent = (CDbl(_value) - CDbl(_minimum)) / CDbl(range)
            End If

            If percent < 0.0R Then percent = 0.0R
            If percent > 1.0R Then percent = 1.0R

            Dim fillWidth As Integer = CInt(Math.Floor(innerRect.Width * percent))
            If fillWidth <= 0 Then Return

            Dim fillRect As Rectangle = New Rectangle(innerRect.X, innerRect.Y, fillWidth, innerRect.Height)
            If fillRect.Width <= 0 OrElse fillRect.Height <= 0 Then Return

            Using fillBrush As New LinearGradientBrush(fillRect, _fillTop, _fillBottom, LinearGradientMode.Vertical)
                Dim blend As New ColorBlend()
                blend.Positions = New Single() {0.0F, 0.48F, 1.0F}
                blend.Colors = New Color() {_fillTop, _fillMid, _fillBottom}
                fillBrush.InterpolationColors = blend
                e.Graphics.FillRectangle(fillBrush, fillRect)
            End Using

            If _showFillShine Then
                Using shineBrush As New LinearGradientBrush(
                    New Rectangle(fillRect.X, fillRect.Y, fillRect.Width, Math.Max(1, fillRect.Height \ 2)),
                    _shineTop,
                    _shineBottom,
                    LinearGradientMode.Vertical)

                    e.Graphics.FillRectangle(shineBrush, fillRect.X + 1, fillRect.Y + 1, Math.Max(0, fillRect.Width - 2), Math.Max(1, fillRect.Height \ 2))
                End Using
            End If

            If _animationEnabled AndAlso _sweepOpacity > 0 AndAlso fillRect.Width > 12 Then
                Dim calculatedSweepWidth As Integer

                If _sweepWidth <= 0 Then
                    calculatedSweepWidth = Math.Max(18, Me.Height * 3)
                Else
                    calculatedSweepWidth = _sweepWidth
                End If

                Dim sweepX As Integer = fillRect.X + (_animationOffset Mod (fillRect.Width + calculatedSweepWidth)) - calculatedSweepWidth
                Dim sweepRect As Rectangle = New Rectangle(sweepX, fillRect.Y, calculatedSweepWidth, fillRect.Height)

                Using path As New GraphicsPath()
                    path.AddPolygon(New Point() {
                        New Point(sweepRect.Left + calculatedSweepWidth \ 3, sweepRect.Top),
                        New Point(sweepRect.Right, sweepRect.Top),
                        New Point(sweepRect.Right - calculatedSweepWidth \ 3, sweepRect.Bottom),
                        New Point(sweepRect.Left, sweepRect.Bottom)
                    })

                    Dim oldClip As Region = e.Graphics.Clip
                    e.Graphics.SetClip(fillRect)

                    Using sweepBrush As New LinearGradientBrush(sweepRect,
                        Color.FromArgb(0, _sweepColor),
                        Color.FromArgb(_sweepOpacity, _sweepColor),
                        LinearGradientMode.Horizontal)

                        e.Graphics.FillPath(sweepBrush, path)
                    End Using

                    e.Graphics.Clip = oldClip
                End Using
            End If

            If _showLeadingEdge Then
                Using edgePen As New Pen(_edgeLight)
                    e.Graphics.DrawLine(edgePen, fillRect.Right - 1, fillRect.Top + 1, fillRect.Right - 1, fillRect.Bottom - 1)
                End Using
            End If

            If _showBottomGlow Then
                Using bottomGlowPen As New Pen(_bottomGlow)
                    e.Graphics.DrawLine(bottomGlowPen, fillRect.Left + 1, fillRect.Bottom - 1, fillRect.Right - 2, fillRect.Bottom - 1)
                End Using
            End If
        End Sub

    End Class

End Namespace