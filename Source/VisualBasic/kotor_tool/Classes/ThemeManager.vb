Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows.Forms

Namespace kotor_tool

    Public NotInheritable Class KotorThemeManager

        Private Sub New()
        End Sub

        Public Shared Function LoadTheme(ByVal themeName As String) As KotorTheme
            Dim theme As KotorTheme = KotorTheme.CreateDefault()

            If themeName Is Nothing OrElse themeName.Trim().Length = 0 Then
                Return theme
            End If

            Dim basePath As String = Application.StartupPath
            Dim themePath As String = Path.Combine(basePath, "Themes\" & themeName & ".ini")

            If File.Exists(themePath) = False Then
                Return theme
            End If

            Try
                Dim data As Dictionary(Of String, Dictionary(Of String, String)) = ReadIniFile(themePath)

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
                theme.TitleFontSize = GetSingle(data, "Fonts", "TitleFontSize", theme.TitleFontSize, 6.0F, 72.0F)
                theme.TitleFontStyle = GetFontStyle(data, "Fonts", "TitleFontStyle", theme.TitleFontStyle)

                theme.BodyFontName = GetValue(data, "Fonts", "BodyFontName", theme.BodyFontName)
                theme.BodyFontSize = GetSingle(data, "Fonts", "BodyFontSize", theme.BodyFontSize, 6.0F, 32.0F)
                theme.BodyFontStyle = GetFontStyle(data, "Fonts", "BodyFontStyle", theme.BodyFontStyle)

                theme.MonoFontName = GetValue(data, "Fonts", "MonoFontName", theme.MonoFontName)
                theme.MonoFontSize = GetSingle(data, "Fonts", "MonoFontSize", theme.MonoFontSize, 6.0F, 32.0F)
                theme.MonoFontStyle = GetFontStyle(data, "Fonts", "MonoFontStyle", theme.MonoFontStyle)

                theme.LogoFontName = GetValue(data, "Fonts", "LogoFontName", theme.LogoFontName)
                theme.LogoFontSize = GetSingle(data, "Fonts", "LogoFontSize", theme.LogoFontSize, 6.0F, 96.0F)
                theme.LogoFontStyle = GetFontStyle(data, "Fonts", "LogoFontStyle", theme.LogoFontStyle)

                Return theme

            Catch ex As System.Exception
                Return KotorTheme.CreateDefault()
            End Try
        End Function

        Private Shared Function ReadIniFile(ByVal filePath As String) As Dictionary(Of String, Dictionary(Of String, String))
            Dim result As Dictionary(Of String, Dictionary(Of String, String)) = New Dictionary(Of String, Dictionary(Of String, String))(StringComparer.OrdinalIgnoreCase)
            Dim currentSection As String = "General"

            result(currentSection) = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

            Dim lines() As String = File.ReadAllLines(filePath)

            For Each rawLine As String In lines
                If rawLine Is Nothing Then
                    Continue For
                End If

                Dim line As String = rawLine.Trim()

                If line.Length = 0 Then
                    Continue For
                End If

                If line.StartsWith(";") OrElse line.StartsWith("#") Then
                    Continue For
                End If

                If line.StartsWith("[") AndAlso line.EndsWith("]") Then
                    currentSection = line.Substring(1, line.Length - 2).Trim()

                    If currentSection.Length = 0 Then
                        currentSection = "General"
                    End If

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

                If key.Length = 0 Then
                    Continue For
                End If

                result(currentSection)(key) = value
            Next

            Return result
        End Function

        Private Shared Function GetValue(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultValue As String) As String
            If data Is Nothing Then
                Return defaultValue
            End If

            If data.ContainsKey(section) = False Then
                Return defaultValue
            End If

            If data(section).ContainsKey(key) = False Then
                Return defaultValue
            End If

            Dim value As String = data(section)(key)

            If value Is Nothing Then
                Return defaultValue
            End If

            If value.Trim().Length = 0 Then
                Return defaultValue
            End If

            Return value.Trim()
        End Function

        Private Shared Function GetColor(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultColor As Color) As Color
            Dim value As String = GetValue(data, section, key, "")

            If value.Length = 0 Then
                Return defaultColor
            End If

            value = value.Trim()

            If value.StartsWith("#") Then
                Try
                    Return ColorTranslator.FromHtml(value)
                Catch ex As System.Exception
                    Return defaultColor
                End Try
            End If

            Dim parts() As String = value.Split(","c)

            Try
                If parts.Length = 3 Then
                    Dim r As Integer = ClampByte(Convert.ToInt32(parts(0).Trim(), CultureInfo.InvariantCulture))
                    Dim g As Integer = ClampByte(Convert.ToInt32(parts(1).Trim(), CultureInfo.InvariantCulture))
                    Dim b As Integer = ClampByte(Convert.ToInt32(parts(2).Trim(), CultureInfo.InvariantCulture))

                    Return Color.FromArgb(r, g, b)
                End If

                If parts.Length = 4 Then
                    Dim a As Integer = ClampByte(Convert.ToInt32(parts(0).Trim(), CultureInfo.InvariantCulture))
                    Dim r As Integer = ClampByte(Convert.ToInt32(parts(1).Trim(), CultureInfo.InvariantCulture))
                    Dim g As Integer = ClampByte(Convert.ToInt32(parts(2).Trim(), CultureInfo.InvariantCulture))
                    Dim b As Integer = ClampByte(Convert.ToInt32(parts(3).Trim(), CultureInfo.InvariantCulture))

                    Return Color.FromArgb(a, r, g, b)
                End If

            Catch ex As System.Exception
                Return defaultColor
            End Try

            Return defaultColor
        End Function

        Private Shared Function ClampByte(ByVal value As Integer) As Integer
            If value < 0 Then
                Return 0
            End If

            If value > 255 Then
                Return 255
            End If

            Return value
        End Function

        Private Shared Function GetSingle(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultValue As Single) As Single
            Return GetSingle(data, section, key, defaultValue, 1.0F, 96.0F)
        End Function

        Private Shared Function GetSingle(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultValue As Single, ByVal minimumValue As Single, ByVal maximumValue As Single) As Single
            Dim value As String = GetValue(data, section, key, "")

            If value.Length = 0 Then
                Return defaultValue
            End If

            Try
                Dim parsedValue As Single = Convert.ToSingle(value, CultureInfo.InvariantCulture)

                If parsedValue < minimumValue Then
                    Return defaultValue
                End If

                If parsedValue > maximumValue Then
                    Return defaultValue
                End If

                Return parsedValue

            Catch ex As System.Exception
                Return defaultValue
            End Try
        End Function

        Private Shared Function GetFontStyle(ByVal data As Dictionary(Of String, Dictionary(Of String, String)), ByVal section As String, ByVal key As String, ByVal defaultStyle As FontStyle) As FontStyle
            Dim value As String = GetValue(data, section, key, "")

            If value.Length = 0 Then
                Return defaultStyle
            End If

            Dim style As FontStyle = FontStyle.Regular
            Dim foundKnownStyle As Boolean = False

            Dim parts() As String = value.Replace("|", ",").Replace(";", ",").Split(","c)

            For Each rawPart As String In parts
                If rawPart Is Nothing Then
                    Continue For
                End If

                Dim part As String = rawPart.Trim().ToLowerInvariant()

                Select Case part
                    Case "regular"
                        style = FontStyle.Regular
                        foundKnownStyle = True

                    Case "bold"
                        style = style Or FontStyle.Bold
                        foundKnownStyle = True

                    Case "italic"
                        style = style Or FontStyle.Italic
                        foundKnownStyle = True

                    Case "underline"
                        style = style Or FontStyle.Underline
                        foundKnownStyle = True

                    Case "strikeout"
                        style = style Or FontStyle.Strikeout
                        foundKnownStyle = True
                End Select
            Next

            If foundKnownStyle = False Then
                Return defaultStyle
            End If

            Return style
        End Function

    End Class

End Namespace