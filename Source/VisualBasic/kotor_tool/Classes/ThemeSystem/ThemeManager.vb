Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Text
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

            Dim themePath As String = FindThemeFilePath(themeName)

            If File.Exists(themePath) = False Then
                Return theme
            End If

            Try
                Dim data As Dictionary(Of String, Dictionary(Of String, String)) = ReadIniFile(themePath)

                theme.Name = GetValue(data, "Theme", "Name", theme.Name)
                theme.Author = GetValue(data, "Theme", "Author", theme.Author)
                theme.Description = GetValue(data, "Theme", "Description", theme.Description)
                theme.Version = GetValue(data, "Theme", "Version", theme.Version)

                theme.WindowBack = GetColor(data, "Colors", "WindowBack", theme.WindowBack)
                theme.PanelRoot = GetColor(data, "Colors", "PanelRoot", theme.PanelRoot)
                theme.PanelHeader = GetColor(data, "Colors", "PanelHeader", theme.PanelHeader)
                theme.PanelBody = GetColor(data, "Colors", "PanelBody", theme.PanelBody)
                theme.PanelFooter = GetColor(data, "Colors", "PanelFooter", theme.PanelFooter)

                theme.TextPrimary = GetColor(data, "Colors", "TextPrimary", theme.TextPrimary)
                theme.TextSecondary = GetColor(data, "Colors", "TextSecondary", theme.TextSecondary)
                theme.TextMuted = GetColor(data, "Colors", "TextMuted", theme.TextMuted)
                theme.HeaderTitleText = GetColor(data, "Colors", "HeaderTitleText", theme.HeaderTitleText)
                theme.HeaderSubtitleText = GetColor(data, "Colors", "HeaderSubtitleText", theme.HeaderSubtitleText)

                theme.AccentGold = GetColor(data, "Colors", "AccentGold", theme.AccentGold)
                theme.AccentGoldLight = GetColor(data, "Colors", "AccentGoldLight", theme.AccentGoldLight)
                theme.BorderDark = GetColor(data, "Colors", "BorderDark", theme.BorderDark)
                theme.HeaderSeparator = GetColor(data, "Colors", "HeaderSeparator", theme.HeaderSeparator)
                theme.FooterSeparator = GetColor(data, "Colors", "FooterSeparator", theme.FooterSeparator)
                theme.GroupBorder = GetColor(data, "Colors", "GroupBorder", theme.GroupBorder)

                theme.ControlDark = GetColor(data, "Colors", "ControlDark", theme.ControlDark)
                theme.ControlHover = GetColor(data, "Colors", "ControlHover", theme.ControlHover)
                theme.ControlDown = GetColor(data, "Colors", "ControlDown", theme.ControlDown)
                theme.InputBack = GetColor(data, "Colors", "InputBack", theme.InputBack)
                theme.InputText = GetColor(data, "Colors", "InputText", theme.InputText)
                theme.InputBorder = GetColor(data, "Colors", "InputBorder", theme.InputBorder)
                theme.InputBackAlt = GetColor(data, "Colors", "InputBackAlt", theme.InputBackAlt)
                theme.DisabledText = GetColor(data, "Colors", "DisabledText", theme.DisabledText)

                theme.LogoBack = GetColor(data, "Colors", "LogoBack", theme.LogoBack)
                theme.ValidationErrorBack = GetColor(data, "Colors", "ValidationErrorBack", theme.ValidationErrorBack)

                theme.DataGridBack = GetColor(data, "DataGrid", "Back", theme.DataGridBack)
                theme.DataGridBackground = GetColor(data, "DataGrid", "Background", theme.DataGridBackground)
                theme.DataGridAlternatingBack = GetColor(data, "DataGrid", "AlternatingBack", theme.DataGridAlternatingBack)
                theme.DataGridGridLine = GetColor(data, "DataGrid", "GridLine", theme.DataGridGridLine)
                theme.DataGridHeaderBack = GetColor(data, "DataGrid", "HeaderBack", theme.DataGridHeaderBack)
                theme.DataGridHeaderText = GetColor(data, "DataGrid", "HeaderText", theme.DataGridHeaderText)
                theme.DataGridSelectionBack = GetColor(data, "DataGrid", "SelectionBack", theme.DataGridSelectionBack)
                theme.DataGridSelectionText = GetColor(data, "DataGrid", "SelectionText", theme.DataGridSelectionText)
                theme.DataGridLink = GetColor(data, "DataGrid", "Link", theme.DataGridLink)

                theme.ByteViewerBack = GetColor(data, "ByteViewer", "Back", theme.ByteViewerBack)
                theme.ByteViewerAltRow = GetColor(data, "ByteViewer", "AltRow", theme.ByteViewerAltRow)
                theme.ByteViewerSelectionBack = GetColor(data, "ByteViewer", "SelectionBack", theme.ByteViewerSelectionBack)
                theme.ByteViewerCurrentBack = GetColor(data, "ByteViewer", "CurrentBack", theme.ByteViewerCurrentBack)
                theme.ByteViewerNullBack = GetColor(data, "ByteViewer", "NullBack", theme.ByteViewerNullBack)
                theme.ByteViewerControlBack = GetColor(data, "ByteViewer", "ControlBack", theme.ByteViewerControlBack)
                theme.ByteViewerHighAsciiBack = GetColor(data, "ByteViewer", "HighAsciiBack", theme.ByteViewerHighAsciiBack)
                theme.ByteViewerNonPrintableBack = GetColor(data, "ByteViewer", "NonPrintableBack", theme.ByteViewerNonPrintableBack)

                theme.PictureBorder = GetColor(data, "PictureBox", "Border", theme.PictureBorder)
                theme.PictureBorderSecondary = GetColor(data, "PictureBox", "BorderSecondary", theme.PictureBorderSecondary)
                theme.PictureOuterShadow = GetColor(data, "PictureBox", "OuterShadow", theme.PictureOuterShadow)
                theme.PictureInnerHighlight = GetColor(data, "PictureBox", "InnerHighlight", theme.PictureInnerHighlight)

                theme.ProgressBorderDark = GetColor(data, "ProgressBar", "BorderDark", theme.ProgressBorderDark)
                theme.ProgressBorderAccent = GetColor(data, "ProgressBar", "BorderAccent", theme.ProgressBorderAccent)
                theme.ProgressTrackTop = GetColor(data, "ProgressBar", "TrackTop", theme.ProgressTrackTop)
                theme.ProgressTrackBottom = GetColor(data, "ProgressBar", "TrackBottom", theme.ProgressTrackBottom)
                theme.ProgressFillTop = GetColor(data, "ProgressBar", "FillTop", theme.ProgressFillTop)
                theme.ProgressFillMiddle = GetColor(data, "ProgressBar", "FillMiddle", theme.ProgressFillMiddle)
                theme.ProgressFillBottom = GetColor(data, "ProgressBar", "FillBottom", theme.ProgressFillBottom)
                theme.ProgressShineTop = GetColor(data, "ProgressBar", "ShineTop", theme.ProgressShineTop)
                theme.ProgressShineBottom = GetColor(data, "ProgressBar", "ShineBottom", theme.ProgressShineBottom)
                theme.ProgressEdgeLight = GetColor(data, "ProgressBar", "EdgeLight", theme.ProgressEdgeLight)
                theme.ProgressBottomGlow = GetColor(data, "ProgressBar", "BottomGlow", theme.ProgressBottomGlow)
                theme.ProgressInsetHighlight = GetColor(data, "ProgressBar", "InsetHighlight", theme.ProgressInsetHighlight)
                theme.ProgressTrackShadow = GetColor(data, "ProgressBar", "TrackShadow", theme.ProgressTrackShadow)
                theme.ProgressSweep = GetColor(data, "ProgressBar", "Sweep", theme.ProgressSweep)

                theme.TabControlBack = GetColor(data, "Tabs", "ControlBack", theme.TabControlBack)
                theme.TabStripBack = GetColor(data, "Tabs", "StripBack", theme.TabStripBack)
                theme.TabPageBack = GetColor(data, "Tabs", "PageBack", theme.TabPageBack)
                theme.TabNormalBack = GetColor(data, "Tabs", "NormalBack", theme.TabNormalBack)
                theme.TabSelectedBack = GetColor(data, "Tabs", "SelectedBack", theme.TabSelectedBack)
                theme.TabNormalText = GetColor(data, "Tabs", "NormalText", theme.TabNormalText)
                theme.TabSelectedText = GetColor(data, "Tabs", "SelectedText", theme.TabSelectedText)
                theme.TabDivider = GetColor(data, "Tabs", "Divider", theme.TabDivider)
                theme.TabBorder = GetColor(data, "Tabs", "Border", theme.TabBorder)
                theme.TabSelectedBorder = GetColor(data, "Tabs", "SelectedBorder", theme.TabSelectedBorder)
                theme.TabChromeBack = GetColor(data, "Tabs", "ChromeBack", theme.TabChromeBack)
                theme.TabNativeBorderBack = GetColor(data, "Tabs", "NativeBorderBack", theme.TabNativeBorderBack)
                theme.TabPageChromeBack = GetColor(data, "Tabs", "PageChromeBack", theme.TabPageChromeBack)
                theme.TabPageEdgeBack = GetColor(data, "Tabs", "PageEdgeBack", theme.TabPageEdgeBack)
                theme.TabOuterNativeBorderBack = GetColor(data, "Tabs", "OuterNativeBorderBack", theme.TabOuterNativeBorderBack)

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

        Public Shared Function GetThemesDirectory() As String
            Return Path.Combine(Application.StartupPath, "Themes")
        End Function

        Private Shared Function GetSourceThemesDirectory() As String
            Try
                Dim currentDirectory As DirectoryInfo = New DirectoryInfo(Application.StartupPath)

                While currentDirectory IsNot Nothing
                    Dim candidate As String = Path.Combine(currentDirectory.FullName, "Themes")

                    If Directory.Exists(candidate) AndAlso File.Exists(Path.Combine(currentDirectory.FullName, "kotor_tool.vbproj")) Then
                        Return candidate
                    End If

                    currentDirectory = currentDirectory.Parent
                End While

            Catch ex As System.Exception
            End Try

            Return ""
        End Function

        Public Shared Function GetThemeFilePath(ByVal themeName As String) As String
            Dim safeThemeName As String = SanitizeThemeName(themeName)
            Return Path.Combine(GetThemesDirectory(), safeThemeName & ".ini")
        End Function

        Public Shared Function FindThemeFilePath(ByVal themeName As String) As String
            Dim safeThemeName As String = SanitizeThemeName(themeName)
            Dim fileName As String = safeThemeName & ".ini"
            Dim startupThemePath As String = Path.Combine(GetThemesDirectory(), fileName)

            If File.Exists(startupThemePath) Then
                Return startupThemePath
            End If

            Dim sourceThemesDirectory As String = GetSourceThemesDirectory()

            If sourceThemesDirectory.Length > 0 Then
                Dim sourceThemePath As String = Path.Combine(sourceThemesDirectory, fileName)

                If File.Exists(sourceThemePath) Then
                    Return sourceThemePath
                End If
            End If

            Return startupThemePath
        End Function

        Public Shared Function GetAvailableThemeNames() As String()
            Dim names As List(Of String) = New List(Of String)()

            AddThemeNames(names, GetThemesDirectory())
            AddThemeNames(names, GetSourceThemesDirectory())

            If names.Count = 0 Then
                names.Add("DarkSaber")
            End If

            names.Sort()
            Return names.ToArray()
        End Function

        Private Shared Sub AddThemeNames(ByVal names As List(Of String), ByVal themesDirectory As String)
            If names Is Nothing Then
                Return
            End If

            If themesDirectory Is Nothing OrElse themesDirectory.Trim().Length = 0 Then
                Return
            End If

            If Directory.Exists(themesDirectory) = False Then
                Return
            End If

            Dim files() As String = Directory.GetFiles(themesDirectory, "*.ini")

            For Each filePath As String In files
                Dim themeName As String = Path.GetFileNameWithoutExtension(filePath)

                If ContainsThemeName(names, themeName) = False Then
                    names.Add(themeName)
                End If
            Next
        End Sub

        Private Shared Function ContainsThemeName(ByVal names As List(Of String), ByVal themeName As String) As Boolean
            If names Is Nothing OrElse themeName Is Nothing Then
                Return False
            End If

            For Each existingName As String In names
                If String.Compare(existingName, themeName, True, CultureInfo.InvariantCulture) = 0 Then
                    Return True
                End If
            Next

            Return False
        End Function

        Public Shared Sub SaveTheme(ByVal theme As KotorTheme)
            If theme Is Nothing Then
                Throw New ArgumentNullException("theme")
            End If

            SaveTheme(theme, GetThemeFilePath(theme.Name))
        End Sub

        Public Shared Sub SaveTheme(ByVal theme As KotorTheme, ByVal filePath As String)
            If theme Is Nothing Then
                Throw New ArgumentNullException("theme")
            End If

            If filePath Is Nothing OrElse filePath.Trim().Length = 0 Then
                Throw New ArgumentException("A theme file path is required.", "filePath")
            End If

            Dim directoryPath As String = Path.GetDirectoryName(filePath)

            If Directory.Exists(directoryPath) = False Then
                Directory.CreateDirectory(directoryPath)
            End If

            File.WriteAllText(filePath, BuildThemeIni(theme), Encoding.UTF8)
        End Sub

        Private Shared Function BuildThemeIni(ByVal theme As KotorTheme) As String
            Dim sb As StringBuilder = New StringBuilder()

            sb.AppendLine("; -----------------------------------------------------------------")
            sb.AppendLine("; KoTOR Tool Theme File")
            sb.AppendLine("; Theme: " & SafeIniValue(theme.Name))
            sb.AppendLine("; Compatible With: KoTOR Tool Restoration Project")
            sb.AppendLine("; Format Version: " & SafeIniValue(theme.Version))
            sb.AppendLine("; -----------------------------------------------------------------")
            sb.AppendLine()
            sb.AppendLine("[Theme]")
            sb.AppendLine("Name=" & SafeIniValue(theme.Name))
            sb.AppendLine("Author=" & SafeIniValue(theme.Author))
            sb.AppendLine("Description=" & SafeIniValue(theme.Description))
            sb.AppendLine("Version=" & SafeIniValue(theme.Version))
            sb.AppendLine()
            sb.AppendLine("[Colors]")
            sb.AppendLine("WindowBack=" & ColorToIni(theme.WindowBack))
            sb.AppendLine("PanelRoot=" & ColorToIni(theme.PanelRoot))
            sb.AppendLine("PanelHeader=" & ColorToIni(theme.PanelHeader))
            sb.AppendLine("PanelBody=" & ColorToIni(theme.PanelBody))
            sb.AppendLine("PanelFooter=" & ColorToIni(theme.PanelFooter))
            sb.AppendLine()
            sb.AppendLine("TextPrimary=" & ColorToIni(theme.TextPrimary))
            sb.AppendLine("TextSecondary=" & ColorToIni(theme.TextSecondary))
            sb.AppendLine("TextMuted=" & ColorToIni(theme.TextMuted))
            sb.AppendLine("HeaderTitleText=" & ColorToIni(theme.HeaderTitleText))
            sb.AppendLine("HeaderSubtitleText=" & ColorToIni(theme.HeaderSubtitleText))
            sb.AppendLine("AccentGold=" & ColorToIni(theme.AccentGold))
            sb.AppendLine("AccentGoldLight=" & ColorToIni(theme.AccentGoldLight))
            sb.AppendLine("BorderDark=" & ColorToIni(theme.BorderDark))
            sb.AppendLine("HeaderSeparator=" & ColorToIni(theme.HeaderSeparator))
            sb.AppendLine("FooterSeparator=" & ColorToIni(theme.FooterSeparator))
            sb.AppendLine("GroupBorder=" & ColorToIni(theme.GroupBorder))
            sb.AppendLine("ControlDark=" & ColorToIni(theme.ControlDark))
            sb.AppendLine("ControlHover=" & ColorToIni(theme.ControlHover))
            sb.AppendLine("ControlDown=" & ColorToIni(theme.ControlDown))
            sb.AppendLine("InputBack=" & ColorToIni(theme.InputBack))
            sb.AppendLine("InputText=" & ColorToIni(theme.InputText))
            sb.AppendLine("InputBorder=" & ColorToIni(theme.InputBorder))
            sb.AppendLine("InputBackAlt=" & ColorToIni(theme.InputBackAlt))
            sb.AppendLine("DisabledText=" & ColorToIni(theme.DisabledText))
            sb.AppendLine("LogoBack=" & ColorToIni(theme.LogoBack))
            sb.AppendLine("ValidationErrorBack=" & ColorToIni(theme.ValidationErrorBack))
            sb.AppendLine()
            sb.AppendLine("[DataGrid]")
            sb.AppendLine("Back=" & ColorToIni(theme.DataGridBack))
            sb.AppendLine("Background=" & ColorToIni(theme.DataGridBackground))
            sb.AppendLine("AlternatingBack=" & ColorToIni(theme.DataGridAlternatingBack))
            sb.AppendLine("GridLine=" & ColorToIni(theme.DataGridGridLine))
            sb.AppendLine("HeaderBack=" & ColorToIni(theme.DataGridHeaderBack))
            sb.AppendLine("HeaderText=" & ColorToIni(theme.DataGridHeaderText))
            sb.AppendLine("SelectionBack=" & ColorToIni(theme.DataGridSelectionBack))
            sb.AppendLine("SelectionText=" & ColorToIni(theme.DataGridSelectionText))
            sb.AppendLine("Link=" & ColorToIni(theme.DataGridLink))
            sb.AppendLine()
            sb.AppendLine("[ByteViewer]")
            sb.AppendLine("Back=" & ColorToIni(theme.ByteViewerBack))
            sb.AppendLine("AltRow=" & ColorToIni(theme.ByteViewerAltRow))
            sb.AppendLine("SelectionBack=" & ColorToIni(theme.ByteViewerSelectionBack))
            sb.AppendLine("CurrentBack=" & ColorToIni(theme.ByteViewerCurrentBack))
            sb.AppendLine("NullBack=" & ColorToIni(theme.ByteViewerNullBack))
            sb.AppendLine("ControlBack=" & ColorToIni(theme.ByteViewerControlBack))
            sb.AppendLine("HighAsciiBack=" & ColorToIni(theme.ByteViewerHighAsciiBack))
            sb.AppendLine("NonPrintableBack=" & ColorToIni(theme.ByteViewerNonPrintableBack))
            sb.AppendLine()
            sb.AppendLine("[PictureBox]")
            sb.AppendLine("Border=" & ColorToIni(theme.PictureBorder))
            sb.AppendLine("BorderSecondary=" & ColorToIni(theme.PictureBorderSecondary))
            sb.AppendLine("OuterShadow=" & ColorToIni(theme.PictureOuterShadow))
            sb.AppendLine("InnerHighlight=" & ColorToIni(theme.PictureInnerHighlight))
            sb.AppendLine()
            sb.AppendLine("[ProgressBar]")
            sb.AppendLine("BorderDark=" & ColorToIni(theme.ProgressBorderDark))
            sb.AppendLine("BorderAccent=" & ColorToIni(theme.ProgressBorderAccent))
            sb.AppendLine("TrackTop=" & ColorToIni(theme.ProgressTrackTop))
            sb.AppendLine("TrackBottom=" & ColorToIni(theme.ProgressTrackBottom))
            sb.AppendLine("FillTop=" & ColorToIni(theme.ProgressFillTop))
            sb.AppendLine("FillMiddle=" & ColorToIni(theme.ProgressFillMiddle))
            sb.AppendLine("FillBottom=" & ColorToIni(theme.ProgressFillBottom))
            sb.AppendLine("ShineTop=" & ColorToIni(theme.ProgressShineTop))
            sb.AppendLine("ShineBottom=" & ColorToIni(theme.ProgressShineBottom))
            sb.AppendLine("EdgeLight=" & ColorToIni(theme.ProgressEdgeLight))
            sb.AppendLine("BottomGlow=" & ColorToIni(theme.ProgressBottomGlow))
            sb.AppendLine("InsetHighlight=" & ColorToIni(theme.ProgressInsetHighlight))
            sb.AppendLine("TrackShadow=" & ColorToIni(theme.ProgressTrackShadow))
            sb.AppendLine("Sweep=" & ColorToIni(theme.ProgressSweep))
            sb.AppendLine()
            sb.AppendLine("[Tabs]")
            sb.AppendLine("ControlBack=" & ColorToIni(theme.TabControlBack))
            sb.AppendLine("StripBack=" & ColorToIni(theme.TabStripBack))
            sb.AppendLine("PageBack=" & ColorToIni(theme.TabPageBack))
            sb.AppendLine("NormalBack=" & ColorToIni(theme.TabNormalBack))
            sb.AppendLine("SelectedBack=" & ColorToIni(theme.TabSelectedBack))
            sb.AppendLine("NormalText=" & ColorToIni(theme.TabNormalText))
            sb.AppendLine("SelectedText=" & ColorToIni(theme.TabSelectedText))
            sb.AppendLine("Divider=" & ColorToIni(theme.TabDivider))
            sb.AppendLine("Border=" & ColorToIni(theme.TabBorder))
            sb.AppendLine("SelectedBorder=" & ColorToIni(theme.TabSelectedBorder))
            sb.AppendLine("ChromeBack=" & ColorToIni(theme.TabChromeBack))
            sb.AppendLine("NativeBorderBack=" & ColorToIni(theme.TabNativeBorderBack))
            sb.AppendLine("PageChromeBack=" & ColorToIni(theme.TabPageChromeBack))
            sb.AppendLine("PageEdgeBack=" & ColorToIni(theme.TabPageEdgeBack))
            sb.AppendLine("OuterNativeBorderBack=" & ColorToIni(theme.TabOuterNativeBorderBack))
            sb.AppendLine()
            sb.AppendLine("[Fonts]")
            sb.AppendLine("TitleFontName=" & SafeIniValue(theme.TitleFontName))
            sb.AppendLine("TitleFontSize=" & SingleToIni(theme.TitleFontSize))
            sb.AppendLine("TitleFontStyle=" & FontStyleToIni(theme.TitleFontStyle))
            sb.AppendLine()
            sb.AppendLine("BodyFontName=" & SafeIniValue(theme.BodyFontName))
            sb.AppendLine("BodyFontSize=" & SingleToIni(theme.BodyFontSize))
            sb.AppendLine("BodyFontStyle=" & FontStyleToIni(theme.BodyFontStyle))
            sb.AppendLine()
            sb.AppendLine("MonoFontName=" & SafeIniValue(theme.MonoFontName))
            sb.AppendLine("MonoFontSize=" & SingleToIni(theme.MonoFontSize))
            sb.AppendLine("MonoFontStyle=" & FontStyleToIni(theme.MonoFontStyle))
            sb.AppendLine()
            sb.AppendLine("LogoFontName=" & SafeIniValue(theme.LogoFontName))
            sb.AppendLine("LogoFontSize=" & SingleToIni(theme.LogoFontSize))
            sb.AppendLine("LogoFontStyle=" & FontStyleToIni(theme.LogoFontStyle))

            Return sb.ToString()
        End Function

        Private Shared Function SanitizeThemeName(ByVal themeName As String) As String
            Dim value As String = themeName

            If value Is Nothing OrElse value.Trim().Length = 0 Then
                value = "DarkSaber"
            End If

            For Each invalidChar As Char In Path.GetInvalidFileNameChars()
                value = value.Replace(invalidChar, "_"c)
            Next

            Return value.Trim()
        End Function

        Private Shared Function SafeIniValue(ByVal value As String) As String
            If value Is Nothing Then
                Return ""
            End If

            Return value.Replace(Convert.ToChar(13), " "c).Replace(Convert.ToChar(10), " "c).Trim()
        End Function

        Private Shared Function ColorToIni(ByVal value As Color) As String
            If value.A <> 255 Then
                Return String.Format(CultureInfo.InvariantCulture, "{0},{1},{2},{3}", value.A, value.R, value.G, value.B)
            End If

            Return String.Format(CultureInfo.InvariantCulture, "{0},{1},{2}", value.R, value.G, value.B)
        End Function

        Private Shared Function SingleToIni(ByVal value As Single) As String
            Return value.ToString("0.##", CultureInfo.InvariantCulture)
        End Function

        Private Shared Function FontStyleToIni(ByVal value As FontStyle) As String
            If value = FontStyle.Regular Then
                Return "Regular"
            End If

            Dim parts As List(Of String) = New List(Of String)()

            If (value And FontStyle.Bold) = FontStyle.Bold Then
                parts.Add("Bold")
            End If

            If (value And FontStyle.Italic) = FontStyle.Italic Then
                parts.Add("Italic")
            End If

            If (value And FontStyle.Underline) = FontStyle.Underline Then
                parts.Add("Underline")
            End If

            If (value And FontStyle.Strikeout) = FontStyle.Strikeout Then
                parts.Add("Strikeout")
            End If

            If parts.Count = 0 Then
                Return "Regular"
            End If

            Return String.Join(",", parts.ToArray())
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
