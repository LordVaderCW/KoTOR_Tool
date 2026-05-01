Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace kotor_tool

    Public Enum CustomTabBorderStyle
        None = 0
        Dark = 1
        Accent = 2
    End Enum

    Public Class CustomTabControl
        Inherits TabControl

        Private _customBorderStyle As CustomTabBorderStyle = CustomTabBorderStyle.Dark

        <Category("DarkSaber")>
        <Description("Controls the custom painted border around the tab control.")>
        <DefaultValue(GetType(CustomTabBorderStyle), "Dark")>
        Public Property CustomBorderStyle() As CustomTabBorderStyle
            Get
                Return _customBorderStyle
            End Get
            Set(ByVal value As CustomTabBorderStyle)
                _customBorderStyle = value
                Me.Invalidate()
            End Set
        End Property

        Public Sub New()
            MyBase.New()

            Me.Appearance = TabAppearance.Normal
            Me.DrawMode = TabDrawMode.OwnerDrawFixed
            Me.SizeMode = TabSizeMode.FillToRight
            Me.Multiline = True
            Me.ItemSize = New Size(88, 31)
            Me.Padding = New Point(0, 0)
            Me.Font = New Font("Segoe UI", 8.25!, FontStyle.Bold)

            ' 🔥 CRITICAL: Flicker fix
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                        ControlStyles.OptimizedDoubleBuffer Or
                        ControlStyles.ResizeRedraw, True)
        End Sub

        Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
            ' 🔥 Prevent default white flash
            Using b As New SolidBrush(Color.FromArgb(18, 22, 28))
                pevent.Graphics.FillRectangle(b, Me.ClientRectangle)
            End Using
        End Sub

        Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
            If e.Index < 0 OrElse e.Index >= Me.TabPages.Count Then Return

            Dim g As Graphics = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias

            Dim rect As Rectangle = Me.GetTabRect(e.Index)
            Dim selected As Boolean = (e.Index = Me.SelectedIndex)

            Dim normalBack As Color = Color.FromArgb(28, 35, 44)
            Dim selectedBack As Color = Color.FromArgb(22, 27, 34)
            Dim dividerColor As Color = Color.FromArgb(62, 70, 82)
            Dim accentGold As Color = Color.FromArgb(174, 136, 58)

            Dim textColor As Color = If(selected,
                Color.FromArgb(238, 238, 230),
                Color.FromArgb(188, 198, 210))

            Dim tabBack As Color = If(selected, selectedBack, normalBack)

            ' Fill tab
            Using b As New SolidBrush(tabBack)
                g.FillRectangle(b, rect)
            End Using

            ' Divider line
            Using p As New Pen(dividerColor)
                g.DrawLine(p, rect.Right - 1, rect.Top + 6, rect.Right - 1, rect.Bottom - 6)
            End Using

            ' Selected underline
            If selected Then
                Using p As New Pen(accentGold, 3.0!)
                    g.DrawLine(p, rect.Left + 10, rect.Bottom - 3, rect.Right - 10, rect.Bottom - 3)
                End Using
            End If

            ' Text
            TextRenderer.DrawText(g, Me.TabPages(e.Index).Text, Me.Font, rect, textColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)

            ' 🔥 Custom border drawn SAFELY (no CreateGraphics)
            If Me.CustomBorderStyle = CustomTabBorderStyle.None Then Return

            Dim borderColor As Color = Color.FromArgb(62, 70, 82)

            If Me.CustomBorderStyle = CustomTabBorderStyle.Accent Then
                borderColor = Color.FromArgb(174, 136, 58)
            End If

            Using p As New Pen(borderColor)
                Dim r As Rectangle = Me.ClientRectangle
                r.Width -= 1
                r.Height -= 1
                e.Graphics.DrawRectangle(p, r)
            End Using
        End Sub

    End Class

End Namespace