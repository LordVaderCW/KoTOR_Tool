Option Strict Off
Option Explicit On

Imports System.Drawing

Namespace kotor_tool

    Public Class KotorTheme

        Public Name As String

        Public WindowBack As Color
        Public PanelRoot As Color
        Public PanelHeader As Color
        Public PanelBody As Color
        Public PanelFooter As Color

        Public TextPrimary As Color
        Public TextSecondary As Color
        Public TextMuted As Color

        Public AccentGold As Color
        Public AccentGoldLight As Color
        Public BorderDark As Color

        Public ControlDark As Color
        Public ControlHover As Color
        Public ControlDown As Color

        Public LogoBack As Color

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

            theme.WindowBack = Color.FromArgb(18, 22, 28)
            theme.PanelRoot = Color.FromArgb(18, 22, 28)
            theme.PanelHeader = Color.FromArgb(28, 35, 44)
            theme.PanelBody = Color.FromArgb(22, 27, 34)
            theme.PanelFooter = Color.FromArgb(18, 22, 28)

            theme.TextPrimary = Color.FromArgb(238, 238, 230)
            theme.TextSecondary = Color.FromArgb(188, 198, 210)
            theme.TextMuted = Color.FromArgb(176, 186, 198)

            theme.AccentGold = Color.FromArgb(174, 136, 58)
            theme.AccentGoldLight = Color.FromArgb(230, 202, 120)
            theme.BorderDark = Color.FromArgb(62, 70, 82)

            theme.ControlDark = Color.FromArgb(46, 55, 66)
            theme.ControlHover = Color.FromArgb(60, 70, 84)
            theme.ControlDown = Color.FromArgb(82, 65, 32)

            theme.LogoBack = Color.FromArgb(10, 14, 20)

            theme.TitleFontName = "Segoe UI"
            theme.TitleFontSize = 18.0F
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

    End Class

End Namespace