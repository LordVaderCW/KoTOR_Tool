Option Strict Off
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms

Namespace kotor_tool

    Public Class KotorTheme

        Public Name As String
        Public Author As String
        Public Description As String
        Public Version As String

        Public WindowBack As Color
        Public PanelRoot As Color
        Public PanelHeader As Color
        Public PanelBody As Color
        Public PanelFooter As Color

        Public TextPrimary As Color
        Public TextSecondary As Color
        Public TextMuted As Color
        Public HeaderTitleText As Color
        Public HeaderSubtitleText As Color

        Public AccentGold As Color
        Public AccentGoldLight As Color
        Public BorderDark As Color
        Public HeaderSeparator As Color
        Public FooterSeparator As Color
        Public GroupBorder As Color

        Public ControlDark As Color
        Public ControlHover As Color
        Public ControlDown As Color
        Public InputBack As Color
        Public InputText As Color
        Public InputBorder As Color
        Public InputBackAlt As Color
        Public DisabledText As Color

        Public LogoBack As Color

        Public DataGridBack As Color
        Public DataGridBackground As Color
        Public DataGridAlternatingBack As Color
        Public DataGridGridLine As Color
        Public DataGridHeaderBack As Color
        Public DataGridHeaderText As Color
        Public DataGridSelectionBack As Color
        Public DataGridSelectionText As Color
        Public DataGridLink As Color

        Public ByteViewerBack As Color
        Public ByteViewerAltRow As Color
        Public ByteViewerSelectionBack As Color
        Public ByteViewerCurrentBack As Color
        Public ByteViewerNullBack As Color
        Public ByteViewerControlBack As Color
        Public ByteViewerHighAsciiBack As Color
        Public ByteViewerNonPrintableBack As Color

        Public PictureBorder As Color
        Public PictureBorderSecondary As Color
        Public PictureOuterShadow As Color
        Public PictureInnerHighlight As Color

        Public ProgressBorderDark As Color
        Public ProgressBorderAccent As Color
        Public ProgressTrackTop As Color
        Public ProgressTrackBottom As Color
        Public ProgressFillTop As Color
        Public ProgressFillMiddle As Color
        Public ProgressFillBottom As Color
        Public ProgressShineTop As Color
        Public ProgressShineBottom As Color
        Public ProgressEdgeLight As Color
        Public ProgressBottomGlow As Color
        Public ProgressInsetHighlight As Color
        Public ProgressTrackShadow As Color
        Public ProgressSweep As Color

        Public ValidationErrorBack As Color

        Public ErrorTitleText As Color
        Public ErrorSubtitleText As Color
        Public ErrorAccent As Color
        Public ErrorSummaryBack As Color
        Public ErrorSummaryBorder As Color
        Public ErrorSummaryText As Color
        Public ErrorFieldLabelText As Color
        Public ErrorValueText As Color

        Public TabControlBack As Color
        Public TabStripBack As Color
        Public TabPageBack As Color
        Public TabNormalBack As Color
        Public TabSelectedBack As Color
        Public TabNormalText As Color
        Public TabSelectedText As Color
        Public TabDivider As Color
        Public TabBorder As Color
        Public TabSelectedBorder As Color
        Public TabChromeBack As Color
        Public TabNativeBorderBack As Color
        Public TabPageChromeBack As Color
        Public TabPageEdgeBack As Color
        Public TabOuterNativeBorderBack As Color

        Public TitleFontName As String
        Public TitleFontSize As Single
        Public TitleFontStyle As FontStyle

        Public BodyFontName As String
        Public BodyFontSize As Single
        Public BodyFontStyle As FontStyle

        Public MonoFontName As String
        Public MonoFontSize As Single
        Public MonoFontStyle As FontStyle

        Public LogoFontName As String
        Public LogoFontSize As Single
        Public LogoFontStyle As FontStyle

        Public Shared Function CreateDefault() As KotorTheme
            Dim theme As KotorTheme = New KotorTheme()

            theme.Name = "DarkSaber"
            theme.Author = "LordVaderCW"
            theme.Description = "Dark restored KotOR-style interface theme."
            theme.Version = "1"

            theme.WindowBack = Color.FromArgb(18, 22, 28)
            theme.PanelRoot = Color.FromArgb(18, 22, 28)
            theme.PanelHeader = Color.FromArgb(28, 35, 44)
            theme.PanelBody = Color.FromArgb(22, 27, 34)
            theme.PanelFooter = Color.FromArgb(18, 22, 28)

            theme.TextPrimary = Color.FromArgb(238, 238, 230)
            theme.TextSecondary = Color.FromArgb(188, 198, 210)
            theme.TextMuted = Color.FromArgb(176, 186, 198)
            theme.HeaderTitleText = Color.FromArgb(210, 184, 112)
            theme.HeaderSubtitleText = Color.FromArgb(176, 186, 198)

            theme.AccentGold = Color.FromArgb(174, 136, 58)
            theme.AccentGoldLight = Color.FromArgb(230, 202, 120)
            theme.BorderDark = Color.FromArgb(62, 70, 82)
            theme.HeaderSeparator = Color.FromArgb(174, 136, 58)
            theme.FooterSeparator = Color.FromArgb(62, 70, 82)
            theme.GroupBorder = Color.FromArgb(188, 198, 210)

            theme.ControlDark = Color.FromArgb(46, 55, 66)
            theme.ControlHover = Color.FromArgb(60, 70, 84)
            theme.ControlDown = Color.FromArgb(82, 65, 32)
            theme.InputBack = Color.FromArgb(28, 35, 44)
            theme.InputText = Color.FromArgb(238, 238, 230)
            theme.InputBorder = Color.FromArgb(90, 100, 115)
            theme.InputBackAlt = Color.FromArgb(31, 38, 47)
            theme.DisabledText = Color.FromArgb(130, 140, 154)

            theme.LogoBack = Color.FromArgb(10, 14, 20)

            theme.DataGridBack = Color.FromArgb(18, 22, 28)
            theme.DataGridBackground = Color.FromArgb(10, 14, 20)
            theme.DataGridAlternatingBack = Color.FromArgb(26, 31, 38)
            theme.DataGridGridLine = Color.FromArgb(74, 84, 98)
            theme.DataGridHeaderBack = Color.FromArgb(28, 35, 44)
            theme.DataGridHeaderText = Color.FromArgb(238, 238, 230)
            theme.DataGridSelectionBack = Color.FromArgb(82, 65, 32)
            theme.DataGridSelectionText = Color.FromArgb(238, 238, 230)
            theme.DataGridLink = Color.FromArgb(210, 184, 112)

            theme.ByteViewerBack = Color.FromArgb(12, 17, 24)
            theme.ByteViewerAltRow = Color.FromArgb(16, 22, 31)
            theme.ByteViewerSelectionBack = Color.FromArgb(70, 90, 120)
            theme.ByteViewerCurrentBack = Color.FromArgb(92, 70, 34)
            theme.ByteViewerNullBack = Color.FromArgb(44, 32, 32)
            theme.ByteViewerControlBack = Color.FromArgb(44, 38, 28)
            theme.ByteViewerHighAsciiBack = Color.FromArgb(28, 42, 46)
            theme.ByteViewerNonPrintableBack = Color.FromArgb(38, 30, 46)

            theme.PictureBorder = Color.FromArgb(210, 184, 112)
            theme.PictureBorderSecondary = Color.FromArgb(92, 104, 122)
            theme.PictureOuterShadow = Color.Black
            theme.PictureInnerHighlight = Color.FromArgb(34, 42, 52)

            theme.ProgressBorderDark = Color.FromArgb(8, 10, 14)
            theme.ProgressBorderAccent = Color.FromArgb(174, 136, 58)
            theme.ProgressTrackTop = Color.FromArgb(13, 18, 25)
            theme.ProgressTrackBottom = Color.FromArgb(7, 10, 15)
            theme.ProgressFillTop = Color.FromArgb(238, 214, 132)
            theme.ProgressFillMiddle = Color.FromArgb(210, 184, 112)
            theme.ProgressFillBottom = Color.FromArgb(142, 101, 38)
            theme.ProgressShineTop = Color.FromArgb(135, 255, 246, 190)
            theme.ProgressShineBottom = Color.FromArgb(15, 255, 246, 190)
            theme.ProgressEdgeLight = Color.FromArgb(210, 255, 232, 150)
            theme.ProgressBottomGlow = Color.FromArgb(90, 88, 55, 20)
            theme.ProgressInsetHighlight = Color.FromArgb(45, 255, 255, 255)
            theme.ProgressTrackShadow = Color.FromArgb(120, 0, 0, 0)
            theme.ProgressSweep = Color.FromArgb(255, 245, 180)

            theme.ValidationErrorBack = Color.MistyRose

            theme.ErrorTitleText = theme.TextPrimary
            theme.ErrorSubtitleText = theme.HeaderSubtitleText
            theme.ErrorAccent = theme.HeaderSeparator
            theme.ErrorSummaryBack = theme.InputBackAlt
            theme.ErrorSummaryBorder = theme.BorderDark
            theme.ErrorSummaryText = theme.TextPrimary
            theme.ErrorFieldLabelText = theme.AccentGoldLight
            theme.ErrorValueText = theme.TextPrimary

            theme.TabControlBack = Color.FromArgb(22, 27, 34)
            theme.TabStripBack = Color.FromArgb(22, 27, 34)
            theme.TabPageBack = Color.FromArgb(22, 27, 34)
            theme.TabNormalBack = Color.FromArgb(28, 35, 44)
            theme.TabSelectedBack = Color.FromArgb(22, 27, 34)
            theme.TabNormalText = Color.FromArgb(188, 198, 210)
            theme.TabSelectedText = Color.FromArgb(238, 238, 230)
            theme.TabDivider = Color.FromArgb(62, 70, 82)
            theme.TabBorder = Color.FromArgb(90, 100, 115)
            theme.TabSelectedBorder = Color.FromArgb(174, 136, 58)
            theme.TabChromeBack = Color.FromArgb(18, 22, 28)
            theme.TabNativeBorderBack = Color.FromArgb(22, 27, 34)
            theme.TabPageChromeBack = Color.FromArgb(22, 27, 34)
            theme.TabPageEdgeBack = Color.FromArgb(22, 27, 34)
            theme.TabOuterNativeBorderBack = Color.FromArgb(18, 22, 28)

            theme.TitleFontName = "Segoe UI"
            theme.TitleFontSize = 12.75F
            theme.TitleFontStyle = FontStyle.Bold

            theme.BodyFontName = "Segoe UI"
            theme.BodyFontSize = 8.25F
            theme.BodyFontStyle = FontStyle.Regular

            theme.MonoFontName = "Consolas"
            theme.MonoFontSize = 8.25F
            theme.MonoFontStyle = FontStyle.Regular

            theme.LogoFontName = "Georgia"
            theme.LogoFontSize = 26.0F
            theme.LogoFontStyle = FontStyle.Bold

            Return theme
        End Function

        Private Function CreateSafeFont(ByVal preferredFontName As String, ByVal fallbackFontName As String, ByVal fontSize As Single, ByVal fontStyle As FontStyle) As Font
            Try
                If preferredFontName IsNot Nothing AndAlso preferredFontName.Trim().Length > 0 Then
                    Return New Font(preferredFontName, fontSize, fontStyle, GraphicsUnit.Point)
                End If
            Catch ex As System.Exception
            End Try

            Try
                Return New Font(fallbackFontName, fontSize, fontStyle, GraphicsUnit.Point)
            Catch ex As System.Exception
            End Try

            Return SystemFonts.DefaultFont
        End Function

        Public Function CreateTitleFont() As Font
            Return Me.CreateSafeFont(Me.TitleFontName, "Segoe UI", Me.TitleFontSize, Me.TitleFontStyle)
        End Function

        Public Function CreateBodyFont() As Font
            Return Me.CreateSafeFont(Me.BodyFontName, "Segoe UI", Me.BodyFontSize, Me.BodyFontStyle)
        End Function

        Public Function CreateMonoFont() As Font
            Return Me.CreateSafeFont(Me.MonoFontName, "Consolas", Me.MonoFontSize, Me.MonoFontStyle)
        End Function

        Public Function CreateLogoFont() As Font
            Return Me.CreateSafeFont(Me.LogoFontName, "Georgia", Me.LogoFontSize, Me.LogoFontStyle)
        End Function

        Public Sub ApplyToCustomTabControl(ByVal tabControl As CustomTabControl)
            If tabControl Is Nothing Then
                Return
            End If

            tabControl.AccentColor = Me.AccentGold
            tabControl.ControlBackColor = Me.TabControlBack
            tabControl.TabStripBackColor = Me.TabStripBack
            tabControl.TabPageBackColor = Me.TabPageBack
            tabControl.NormalTabBackColor = Me.TabNormalBack
            tabControl.SelectedTabBackColor = Me.TabSelectedBack
            tabControl.NormalTextColor = Me.TabNormalText
            tabControl.SelectedTextColor = Me.TabSelectedText
            tabControl.DividerColor = Me.TabDivider
            tabControl.DarkBorderColor = Me.BorderDark
            tabControl.TabBorderColor = Me.TabBorder
            tabControl.SelectedTabBorderColor = Me.TabSelectedBorder
            tabControl.TabButtonBorderColor = Me.TabBorder
            tabControl.SelectedTabButtonBorderColor = Me.TabSelectedBorder
            tabControl.TabChromeBackColor = Me.TabChromeBack
            tabControl.TabNativeBorderBackColor = Me.TabNativeBorderBack
            tabControl.TabNativeInsetBorderColor = Me.BorderDark
            tabControl.PageInsetBorderColor = Me.BorderDark
            tabControl.PageChromeBackColor = Me.TabPageChromeBack
            tabControl.PageEdgeArtifactBackColor = Me.TabPageEdgeBack
            tabControl.OuterNativeBorderBackColor = Me.TabOuterNativeBorderBack

            For Each page As TabPage In tabControl.TabPages
                page.BackColor = Me.TabPageBack
                page.ForeColor = Me.TextPrimary
            Next
        End Sub

        Public Sub ApplyToCustomProgressBar(ByVal progressBar As CustomProgressBar)
            If progressBar Is Nothing Then
                Return
            End If

            progressBar.BackColor = Me.LogoBack
            progressBar.ForeColor = Me.HeaderTitleText
            progressBar.BorderDarkColor = Me.ProgressBorderDark
            progressBar.BorderGoldColor = Me.ProgressBorderAccent
            progressBar.TrackTopColor = Me.ProgressTrackTop
            progressBar.TrackBottomColor = Me.ProgressTrackBottom
            progressBar.FillTopColor = Me.ProgressFillTop
            progressBar.FillMiddleColor = Me.ProgressFillMiddle
            progressBar.FillBottomColor = Me.ProgressFillBottom
            progressBar.ShineTopColor = Me.ProgressShineTop
            progressBar.ShineBottomColor = Me.ProgressShineBottom
            progressBar.EdgeLightColor = Me.ProgressEdgeLight
            progressBar.BottomGlowColor = Me.ProgressBottomGlow
            progressBar.InsetHighlightColor = Me.ProgressInsetHighlight
            progressBar.TrackShadowColor = Me.ProgressTrackShadow
            progressBar.SweepColor = Me.ProgressSweep
        End Sub

        Public Sub ApplyToDarkPictureBox(ByVal pictureBox As DarkPictureBox)
            If pictureBox Is Nothing Then
                Return
            End If

            pictureBox.BackColor = Me.LogoBack
            pictureBox.ForeColor = Me.TextPrimary
            pictureBox.BorderColor = Me.PictureBorder
            pictureBox.BorderColorSecondary = Me.PictureBorderSecondary
            pictureBox.OuterShadowColor = Me.PictureOuterShadow
            pictureBox.InnerHighlightColor = Me.PictureInnerHighlight
        End Sub

    End Class

End Namespace
