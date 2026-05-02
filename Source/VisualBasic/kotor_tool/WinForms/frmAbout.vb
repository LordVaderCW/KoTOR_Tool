Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms

Namespace kotor_tool

    Partial Public Class frmAbout
        Inherits Form

        Private _theme As KotorTheme

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            LoadAndApplyTheme()
            'DrawAboutLogo()
        End Sub

        Private Sub LoadAndApplyTheme()
            Try
                _theme = KotorThemeManager.LoadTheme("DarkSaber")
            Catch
                _theme = KotorTheme.CreateDefault()
            End Try

            ApplyAboutTheme()
        End Sub

        Private Sub ApplyAboutTheme()
            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            Me.BackColor = _theme.WindowBack

            If Me.pnlRoot IsNot Nothing Then
                Me.pnlRoot.BackColor = _theme.PanelRoot
            End If

            If Me.pnlHeader IsNot Nothing Then
                Me.pnlHeader.BackColor = _theme.PanelHeader
            End If

            If Me.pnlBody IsNot Nothing Then
                Me.pnlBody.BackColor = _theme.PanelBody
            End If

            If Me.pnlFooter IsNot Nothing Then
                Me.pnlFooter.BackColor = _theme.PanelFooter
            End If

            If Me.lblSeparatorTop IsNot Nothing Then
                Me.lblSeparatorTop.BackColor = _theme.AccentGold
            End If

            If Me.lblSeparatorBottom IsNot Nothing Then
                Me.lblSeparatorBottom.BackColor = _theme.BorderDark
            End If

            If Me.PictureBox1 IsNot Nothing Then
                Me.PictureBox1.BackColor = _theme.LogoBack
            End If

            If Me.Label1 IsNot Nothing Then
                Me.Label1.ForeColor = _theme.TextPrimary
                Me.Label1.Font = _theme.CreateTitleFont()
            End If

            If Me.lblProjectName IsNot Nothing Then
                Me.lblProjectName.ForeColor = _theme.TextSecondary
                Me.lblProjectName.Font = _theme.CreateBodyFont()
            End If

            If Me.lblVersion IsNot Nothing Then
                Me.lblVersion.ForeColor = _theme.AccentGoldLight
                Me.lblVersion.Font = _theme.CreateMonoFont()
            End If

            If Me.lblOriginalAuthor IsNot Nothing Then
                Me.lblOriginalAuthor.ForeColor = _theme.TextPrimary
                Me.lblOriginalAuthor.Font = _theme.CreateBodyFont()
            End If

            If Me.lblOriginalCredit IsNot Nothing Then
                Me.lblOriginalCredit.ForeColor = _theme.TextSecondary
                Me.lblOriginalCredit.Font = _theme.CreateBodyFont()
            End If

            If Me.lblRestorationCredit IsNot Nothing Then
                Me.lblRestorationCredit.ForeColor = _theme.AccentGoldLight
                Me.lblRestorationCredit.Font = _theme.CreateBodyFont()
            End If

            If Me.lblSpecialCredits IsNot Nothing Then
                Me.lblSpecialCredits.ForeColor = _theme.TextMuted
                Me.lblSpecialCredits.Font = _theme.CreateBodyFont()
            End If

            If Me.Label4 IsNot Nothing Then
                Me.Label4.ForeColor = _theme.TextMuted
                Me.Label4.Font = _theme.CreateBodyFont()
            End If

            If Me.Button1 IsNot Nothing Then
                Me.Button1.BackColor = _theme.ControlDark
                Me.Button1.ForeColor = _theme.TextPrimary
                Me.Button1.FlatStyle = FlatStyle.Flat
                Me.Button1.UseVisualStyleBackColor = False
                Me.Button1.FlatAppearance.BorderColor = _theme.AccentGold
                Me.Button1.FlatAppearance.MouseOverBackColor = _theme.ControlHover
                Me.Button1.FlatAppearance.MouseDownBackColor = _theme.ControlDown
            End If
        End Sub

        Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Dim linkLabel As LinkLabel = TryCast(sender, LinkLabel)

            If linkLabel Is Nothing Then
                Return
            End If

            If linkLabel.Text Is Nothing OrElse linkLabel.Text.Trim().Length = 0 Then
                Return
            End If

            Try
                Process.Start(linkLabel.Text)
            Catch
            End Try
        End Sub

        Private Sub DrawAboutLogo()
            If Me.PictureBox1 Is Nothing Then
                Return
            End If

            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            Dim bmp As New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)

            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(_theme.LogoBack)
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

                Using borderPen As New Pen(_theme.AccentGold, 2.0F)
                    g.DrawRectangle(borderPen, 2, 2, bmp.Width - 5, bmp.Height - 5)
                End Using

                Using innerPen As New Pen(_theme.BorderDark, 1.0F)
                    g.DrawRectangle(innerPen, 7, 7, bmp.Width - 15, bmp.Height - 15)
                End Using

                Using titleFont As Font = _theme.CreateLogoFont()
                    Using titleBrush As New SolidBrush(_theme.AccentGoldLight)
                        Dim sf As New StringFormat()
                        sf.Alignment = StringAlignment.Center
                        sf.LineAlignment = StringAlignment.Center

                        g.DrawString("Kt", titleFont, titleBrush, New RectangleF(0, 0, bmp.Width, bmp.Height), sf)
                    End Using
                End Using
            End Using

            If Me.PictureBox1.Image IsNot Nothing Then
                Me.PictureBox1.Image.Dispose()
            End If

            Me.PictureBox1.Image = bmp
        End Sub

    End Class

End Namespace