Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace kotor_tool

    Public NotInheritable Class KotorThemeManager

        Private Sub New()
        End Sub

        Public Shared Function LoadTheme(ByVal themeName As String) As KotorTheme
            Dim basePath As String = Application.StartupPath
            Dim themePath As String = Path.Combine(basePath, "Themes\" & themeName & ".ini")

            If File.Exists(themePath) = False Then
                Return KotorTheme.CreateDefault()
            End If

            Dim data As Dictionary(Of String, Dictionary(Of String, String)) = ReadIniFile(themePath)
            Dim theme As KotorTheme = KotorTheme.CreateDefault()

            theme.Name = GetValue(data, "Theme", "Name", theme.Name)

            theme.WindowBack = GetColor(data, "Colors", "WindowBack", theme.WindowBack)
            theme.PanelRoot = GetColor(data, "Colors", "PanelRoot", theme.PanelRoot)
            theme.PanelHeader = GetColor(data, "Colors", "PanelHeader", theme.PanelHeader)
            theme.PanelBody = GetColor(data, "Colors", "PanelBody", theme.PanelBody)
            theme.PanelFooter = GetColor(data, "Colors", "PanelFooter", theme.PanelFooter)

            theme.TextPrimary = GetColor(data, "Colors", "TextPrimary", theme.TextPrimary)
            theme.TextSecondary = GetColor(data, "Colors", "TextSecondary", theme.TextSecondary)
            theme.TextMuted = GetColor(data, "Colors", "TextMuted", theme.TextMuted)

            theme.AccentGold = GetColor(data, "Colors", "AccentGold", theme.AccentGold)
            theme.AccentGoldLight = GetColor(data, "Colors", "AccentGoldLight", theme.AccentGoldLight)
            theme.BorderDark = GetColor(data, "Colors", "BorderDark", theme.BorderDark)

            theme.ControlDark = GetColor(data, "Colors", "ControlDark", theme.ControlDark)
            theme.ControlHover = GetColor(data, "Colors", "ControlHover", theme.ControlHover)
            theme.ControlDown = GetColor(data, "Colors", "ControlDown", theme.ControlDown)

            theme.LogoBack = GetColor(data, "Colors", "LogoBack", theme.LogoBack)

            theme.TitleFontName = GetValue(data, "Fonts", "TitleFontName", theme.TitleFontName)
            theme.TitleFontSize = GetSingle(data, "Fonts", "TitleFontSize", theme.TitleFontSize)
            theme.TitleFontStyle = GetFontStyle(data, "Fonts", "TitleFontStyle", theme.TitleFontStyle)

            theme.BodyFontName = GetValue(data, "Fonts", "BodyFontName", theme.BodyFontName)
            theme.BodyFontSize = GetSingle(data, "Fonts", "BodyFontSize", theme.BodyFontSize)
            theme.BodyFontStyle = GetFontStyle(data, "Fonts", "BodyFontStyle", theme.BodyFontStyle)

            theme.MonoFontName = GetValue(data, "Fonts", "MonoFontName", theme.MonoFontName)
            theme.MonoFontSize = GetSingle(data, "Fonts", "MonoFontSize", theme.MonoFontSize)
            theme.MonoFontStyle = GetFontStyle(data, "Fonts", "MonoFontStyle", theme.MonoFontStyle)

            theme.LogoFontName = GetValue(data, "Fonts", "LogoFontName", theme.LogoFontName)
            theme.LogoFontSize = GetSingle(data, "Fonts", "LogoFontSize", theme.LogoFontSize)
            theme.LogoFontStyle = GetFontStyle(data, "Fonts", "LogoFontStyle", theme.LogoFontStyle)

            Return theme
        End Function

        Private Shared Function ReadIniFile(ByVal filePath As String) As Dictionary(Of String, Dictionary(Of String, String))
            Dim result As New Dictionary(Of String, Dictionary(Of String, String))(StringComparer.OrdinalIgnoreCase)
            Dim currentSection As String = "General"

            result(currentSection) = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

            Dim lines() As String = File.ReadAllLines(filePath)

            For Each rawLine As String In lines
                Dim line As String = rawLine.Trim()

                If line.Length = 0 Then
                    Continue For
                End If

                If line.StartsWith(";") OrElse line.StartsWith("#") Then
                    Continue For
                End If

                If line.StartsWith("[") AndAlso line.EndsWith("]") Then
                    currentSection = line.Substring(1, line.Length - 2).Trim()

                    If result.ContainsKey(currentSection) = False Then
                        result(currentSection) = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
                    End If

                    Continue For
                End If

                Dim eqIndex As Integer = line.IndexOf("="c)

                If eqIndex <= 0 Then
                    Continue For
                End If

                Dim key As String = line.Substring(0, eqIndex).Trim()
                Dim value As String = line.Substring(eqIndex + 1).Trim()

                result(currentSection)(key) = value
            Next

            Return result
        End Function

        Private Shared Function GetValue(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultValue As String) As String
            If data.ContainsKey(section) = False Then
                Return defaultValue
            End If

            If data(section).ContainsKey(key) = False Then
                Return defaultValue
            End If

            Return data(section)(key)
        End Function

        Private Shared Function GetColor(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultColor As Color) As Color
            Dim value As String = GetValue(data, section, key, "")

            If value.Length = 0 Then
                Return defaultColor
            End If

            Dim parts() As String = value.Split(","c)

            If parts.Length <> 3 Then
                Return defaultColor
            End If

            Try
                Dim r As Integer = Math.Max(0, Math.Min(255, Convert.ToInt32(parts(0).Trim())))
                Dim g As Integer = Math.Max(0, Math.Min(255, Convert.ToInt32(parts(1).Trim())))
                Dim b As Integer = Math.Max(0, Math.Min(255, Convert.ToInt32(parts(2).Trim())))

                Return Color.FromArgb(r, g, b)
            Catch
                Return defaultColor
            End Try
        End Function

        Private Shared Function GetSingle(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultValue As Single) As Single
            Dim value As String = GetValue(data, section, key, "")

            If value.Length = 0 Then
                Return defaultValue
            End If

            Try
                Return Convert.ToSingle(value, Globalization.CultureInfo.InvariantCulture)
            Catch
                Return defaultValue
            End Try
        End Function

        Private Shared Function GetFontStyle(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultStyle As FontStyle) As FontStyle
            Dim value As String = GetValue(data, section, key, "")

            Select Case value.Trim().ToLowerInvariant()
                Case "bold"
                    Return FontStyle.Bold
                Case "italic"
                    Return FontStyle.Italic
                Case "underline"
                    Return FontStyle.Underline
                Case "strikeout"
                    Return FontStyle.Strikeout
                Case "regular"
                    Return FontStyle.Regular
            End Select

            Return defaultStyle
        End Function

    End Class

End Namespace