Option Strict Off
Option Explicit On

Imports System
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms

Namespace kotor_tool

    Public Class frmThemeEditor

        Private _theme As KotorTheme
        Private _isLoading As Boolean

        Public Sub New()
            MyBase.New()
            InitializeComponent()
            FillFonts()

            If cmbFontRole.Items.Count = 0 Then
                cmbFontRole.Items.AddRange(New Object() {"Title", "Body", "Mono", "Logo"})
            End If

            If cmbFontRole.SelectedIndex < 0 AndAlso cmbFontRole.Items.Count > 0 Then
                cmbFontRole.SelectedIndex = 0
            End If
        End Sub

        Private Sub frmThemeEditor_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            LoadThemeList()
        End Sub

        Private Sub LoadThemeList()
            _isLoading = True
            cmbThemes.Items.Clear()
            cmbThemes.Items.AddRange(KotorThemeManager.GetAvailableThemeNames())

            If cmbThemes.Items.Count > 0 Then
                Dim activeThemeName As String = KotorThemeManager.GetActiveThemeName()
                Dim selectedIndex As Integer = FindThemeIndex(activeThemeName)

                If selectedIndex < 0 Then
                    selectedIndex = 0
                End If

                cmbThemes.SelectedIndex = selectedIndex
            Else
                cmbThemes.Items.Add("DarkSaber")
                cmbThemes.SelectedIndex = 0
            End If

            Dim themeName As String = cmbThemes.SelectedItem.ToString()
            _isLoading = False
            LoadTheme(themeName)
        End Sub

        Private Sub LoadTheme(ByVal themeName As String)
            _theme = KotorThemeManager.LoadTheme(themeName)
            PopulateThemeControls()
        End Sub

        Private Sub PopulateThemeControls()
            If _theme Is Nothing Then
                Return
            End If

            _isLoading = True
            tbName.Text = _theme.Name
            tbAuthor.Text = _theme.Author
            tbVersion.Text = _theme.Version
            tbDescription.Text = _theme.Description

            lbColors.Items.Clear()
            lbColors.Items.Add(New ThemeColorEntry("WindowBack", "Window Back"))
            lbColors.Items.Add(New ThemeColorEntry("PanelRoot", "Panel Root"))
            lbColors.Items.Add(New ThemeColorEntry("PanelHeader", "Panel Header"))
            lbColors.Items.Add(New ThemeColorEntry("PanelBody", "Panel Body"))
            lbColors.Items.Add(New ThemeColorEntry("PanelFooter", "Panel Footer"))
            lbColors.Items.Add(New ThemeColorEntry("TextPrimary", "Text Primary"))
            lbColors.Items.Add(New ThemeColorEntry("TextSecondary", "Text Secondary"))
            lbColors.Items.Add(New ThemeColorEntry("TextMuted", "Text Muted"))
            lbColors.Items.Add(New ThemeColorEntry("HeaderTitleText", "Header Title Text"))
            lbColors.Items.Add(New ThemeColorEntry("HeaderSubtitleText", "Header Subtitle Text"))
            lbColors.Items.Add(New ThemeColorEntry("AccentGold", "Accent Gold"))
            lbColors.Items.Add(New ThemeColorEntry("AccentGoldLight", "Accent Gold Light"))
            lbColors.Items.Add(New ThemeColorEntry("BorderDark", "Border Dark"))
            lbColors.Items.Add(New ThemeColorEntry("HeaderSeparator", "Header Separator"))
            lbColors.Items.Add(New ThemeColorEntry("FooterSeparator", "Footer Separator"))
            lbColors.Items.Add(New ThemeColorEntry("GroupBorder", "Group Border"))
            lbColors.Items.Add(New ThemeColorEntry("ControlDark", "Control Dark"))
            lbColors.Items.Add(New ThemeColorEntry("ControlHover", "Control Hover"))
            lbColors.Items.Add(New ThemeColorEntry("ControlDown", "Control Down"))
            lbColors.Items.Add(New ThemeColorEntry("InputBack", "Input Back"))
            lbColors.Items.Add(New ThemeColorEntry("InputText", "Input Text"))
            lbColors.Items.Add(New ThemeColorEntry("InputBorder", "Input Border"))
            lbColors.Items.Add(New ThemeColorEntry("InputBackAlt", "Input Back Alt"))
            lbColors.Items.Add(New ThemeColorEntry("DisabledText", "Disabled Text"))
            lbColors.Items.Add(New ThemeColorEntry("LogoBack", "Logo Back"))
            lbColors.Items.Add(New ThemeColorEntry("ValidationErrorBack", "Validation Error Back"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridBack", "Data Grid Back"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridBackground", "Data Grid Background"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridAlternatingBack", "Data Grid Alternating Back"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridGridLine", "Data Grid Line"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridHeaderBack", "Data Grid Header Back"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridHeaderText", "Data Grid Header Text"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridSelectionBack", "Data Grid Selection Back"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridSelectionText", "Data Grid Selection Text"))
            lbColors.Items.Add(New ThemeColorEntry("DataGridLink", "Data Grid Link"))
            lbColors.Items.Add(New ThemeColorEntry("ByteViewerBack", "Byte Viewer Back"))
            lbColors.Items.Add(New ThemeColorEntry("ByteViewerAltRow", "Byte Viewer Alt Row"))
            lbColors.Items.Add(New ThemeColorEntry("ByteViewerSelectionBack", "Byte Viewer Selection Back"))
            lbColors.Items.Add(New ThemeColorEntry("ByteViewerCurrentBack", "Byte Viewer Current Back"))
            lbColors.Items.Add(New ThemeColorEntry("ByteViewerNullBack", "Byte Viewer Null Back"))
            lbColors.Items.Add(New ThemeColorEntry("ByteViewerControlBack", "Byte Viewer Control Back"))
            lbColors.Items.Add(New ThemeColorEntry("ByteViewerHighAsciiBack", "Byte Viewer High ASCII Back"))
            lbColors.Items.Add(New ThemeColorEntry("ByteViewerNonPrintableBack", "Byte Viewer Non Printable Back"))
            lbColors.Items.Add(New ThemeColorEntry("PictureBorder", "Picture Border"))
            lbColors.Items.Add(New ThemeColorEntry("PictureBorderSecondary", "Picture Border Secondary"))
            lbColors.Items.Add(New ThemeColorEntry("PictureOuterShadow", "Picture Outer Shadow"))
            lbColors.Items.Add(New ThemeColorEntry("PictureInnerHighlight", "Picture Inner Highlight"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressBorderDark", "Progress Border Dark"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressBorderAccent", "Progress Border Accent"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressTrackTop", "Progress Track Top"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressTrackBottom", "Progress Track Bottom"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressFillTop", "Progress Fill Top"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressFillMiddle", "Progress Fill Middle"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressFillBottom", "Progress Fill Bottom"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressShineTop", "Progress Shine Top"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressShineBottom", "Progress Shine Bottom"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressEdgeLight", "Progress Edge Light"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressBottomGlow", "Progress Bottom Glow"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressInsetHighlight", "Progress Inset Highlight"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressTrackShadow", "Progress Track Shadow"))
            lbColors.Items.Add(New ThemeColorEntry("ProgressSweep", "Progress Sweep"))
            lbColors.Items.Add(New ThemeColorEntry("TabControlBack", "Tab Control Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabStripBack", "Tab Strip Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabPageBack", "Tab Page Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabNormalBack", "Tab Normal Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabSelectedBack", "Tab Selected Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabNormalText", "Tab Normal Text"))
            lbColors.Items.Add(New ThemeColorEntry("TabSelectedText", "Tab Selected Text"))
            lbColors.Items.Add(New ThemeColorEntry("TabDivider", "Tab Divider"))
            lbColors.Items.Add(New ThemeColorEntry("TabBorder", "Tab Border"))
            lbColors.Items.Add(New ThemeColorEntry("TabSelectedBorder", "Tab Selected Border"))
            lbColors.Items.Add(New ThemeColorEntry("TabChromeBack", "Tab Chrome Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabNativeBorderBack", "Tab Native Border Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabPageChromeBack", "Tab Page Chrome Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabPageEdgeBack", "Tab Page Edge Back"))
            lbColors.Items.Add(New ThemeColorEntry("TabOuterNativeBorderBack", "Tab Outer Native Border Back"))
            lbColors.SelectedIndex = 0

            cmbFontRole.SelectedIndex = 0
            LoadSelectedFontRole()
            _isLoading = False

            ApplyPreview()
        End Sub

        Private Sub cmbThemes_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbThemes.SelectedIndexChanged
            If _isLoading Then
                Return
            End If

            If cmbThemes.SelectedItem IsNot Nothing Then
                LoadTheme(cmbThemes.SelectedItem.ToString())
            End If
        End Sub

        Private Sub btnReload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReload.Click
            If cmbThemes.SelectedItem IsNot Nothing Then
                LoadTheme(cmbThemes.SelectedItem.ToString())
            End If
        End Sub

        Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
            _theme = KotorTheme.CreateDefault()
            PopulateThemeControls()
        End Sub

        Private Sub btnApplyTheme_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplyTheme.Click
            If _theme Is Nothing Then
                Return
            End If

            UpdateThemeFromControls()
            Dim appliedThemeName As String = _theme.Name

            KotorThemeManager.SaveTheme(_theme)
            KotorThemeManager.SetActiveThemeName(appliedThemeName)
            KotorThemeApplier.ReloadAndApplyOpenForms()

            MessageBox.Show(Me, "Theme applied.", "Theme Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadThemeList()
            SelectThemeName(appliedThemeName)
        End Sub

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
            UpdateThemeFromControls()
            Dim savedThemeName As String = _theme.Name
            KotorThemeManager.SaveTheme(_theme)
            KotorThemeApplier.ReloadAndApplyOpenForms()
            MessageBox.Show(Me, "Theme saved.", "Theme Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadThemeList()
            SelectThemeName(savedThemeName)
        End Sub

        Private Sub btnSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveAs.Click
            UpdateThemeFromControls()

            Dim saveDialog As SaveFileDialog = New SaveFileDialog()
            saveDialog.Filter = "Theme files (*.ini)|*.ini|All files (*.*)|*.*"
            saveDialog.InitialDirectory = KotorThemeManager.GetThemesDirectory()
            saveDialog.FileName = _theme.Name & ".ini"

            If saveDialog.ShowDialog(Me) = DialogResult.OK Then
                KotorThemeManager.SaveTheme(_theme, saveDialog.FileName)
                KotorThemeApplier.ReloadAndApplyOpenForms()
                MessageBox.Show(Me, "Theme saved.", "Theme Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadThemeList()
                SelectThemeName(Path.GetFileNameWithoutExtension(saveDialog.FileName))
            End If

            saveDialog.Dispose()
        End Sub

        Private Sub SelectThemeName(ByVal themeName As String)
            Dim selectedIndex As Integer = FindThemeIndex(themeName)

            If selectedIndex >= 0 Then
                cmbThemes.SelectedIndex = selectedIndex
            End If
        End Sub

        Private Function FindThemeIndex(ByVal themeName As String) As Integer
            For i As Integer = 0 To cmbThemes.Items.Count - 1
                If String.Compare(cmbThemes.Items(i).ToString(), themeName, True, CultureInfo.InvariantCulture) = 0 Then
                    Return i
                End If
            Next

            Return -1
        End Function

        Private Sub MetadataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbVersion.TextChanged, tbName.TextChanged, tbDescription.TextChanged, tbAuthor.TextChanged
            If _isLoading Then
                Return
            End If

            UpdateThemeFromControls()
            ApplyPreview()
        End Sub

        Private Sub lbColors_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbColors.SelectedIndexChanged
            If lbColors.SelectedItem Is Nothing OrElse _theme Is Nothing Then
                Return
            End If

            Dim colorValue As Color = GetThemeColor(CType(lbColors.SelectedItem, ThemeColorEntry).Key)
            _isLoading = True
            nudAlpha.Value = colorValue.A
            nudRed.Value = colorValue.R
            nudGreen.Value = colorValue.G
            nudBlue.Value = colorValue.B
            pnlSwatch.BackColor = colorValue
            _isLoading = False
        End Sub

        Private Sub ColorValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudAlpha.ValueChanged, nudRed.ValueChanged, nudGreen.ValueChanged, nudBlue.ValueChanged
            If _isLoading OrElse lbColors.SelectedItem Is Nothing Then
                Return
            End If

            Dim colorValue As Color = Color.FromArgb(CInt(nudAlpha.Value), CInt(nudRed.Value), CInt(nudGreen.Value), CInt(nudBlue.Value))
            Dim colorKey As String = CType(lbColors.SelectedItem, ThemeColorEntry).Key
            SetThemeColor(colorKey, colorValue)
            pnlSwatch.BackColor = colorValue
            If IsProgressColorKey(colorKey) Then
                ApplyProgressPreview()
            Else
                ApplyPreview()
            End If
        End Sub

        Private Sub btnPickColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPickColor.Click
            If lbColors.SelectedItem Is Nothing Then
                Return
            End If

            Dim dialog As ColorDialog = New ColorDialog()
            dialog.FullOpen = True
            dialog.Color = GetThemeColor(CType(lbColors.SelectedItem, ThemeColorEntry).Key)

            If dialog.ShowDialog(Me) = DialogResult.OK Then
                Dim currentColor As Color = GetThemeColor(CType(lbColors.SelectedItem, ThemeColorEntry).Key)
                _isLoading = True
                nudAlpha.Value = currentColor.A
                nudRed.Value = dialog.Color.R
                nudGreen.Value = dialog.Color.G
                nudBlue.Value = dialog.Color.B
                _isLoading = False
                Dim pickedColor As Color = Color.FromArgb(currentColor.A, dialog.Color.R, dialog.Color.G, dialog.Color.B)
                Dim colorKey As String = CType(lbColors.SelectedItem, ThemeColorEntry).Key
                SetThemeColor(colorKey, pickedColor)
                pnlSwatch.BackColor = pickedColor
                If IsProgressColorKey(colorKey) Then
                    ApplyProgressPreview()
                Else
                    ApplyPreview()
                End If
            End If

            dialog.Dispose()
        End Sub

        Private Sub cmbFontRole_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFontRole.SelectedIndexChanged
            LoadSelectedFontRole()
        End Sub

        Private Sub LoadSelectedFontRole()
            If _theme Is Nothing OrElse cmbFontRole.SelectedItem Is Nothing Then
                Return
            End If

            _isLoading = True

            Select Case cmbFontRole.SelectedItem.ToString()
                Case "Title"
                    SelectFontName(_theme.TitleFontName)
                    nudFontSize.Value = CDec(_theme.TitleFontSize)
                    SetFontStyleChecks(_theme.TitleFontStyle)
                Case "Body"
                    SelectFontName(_theme.BodyFontName)
                    nudFontSize.Value = CDec(_theme.BodyFontSize)
                    SetFontStyleChecks(_theme.BodyFontStyle)
                Case "Mono"
                    SelectFontName(_theme.MonoFontName)
                    nudFontSize.Value = CDec(_theme.MonoFontSize)
                    SetFontStyleChecks(_theme.MonoFontStyle)
                Case "Logo"
                    SelectFontName(_theme.LogoFontName)
                    nudFontSize.Value = CDec(_theme.LogoFontSize)
                    SetFontStyleChecks(_theme.LogoFontStyle)
            End Select

            _isLoading = False
        End Sub

        Private Sub FontValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudFontSize.ValueChanged, cmbFontName.SelectedIndexChanged, chkbUnderline.CheckedChanged, chkbStrikeout.CheckedChanged, chkbItalic.CheckedChanged, chkbBold.CheckedChanged
            If _isLoading OrElse _theme Is Nothing OrElse cmbFontRole.SelectedItem Is Nothing OrElse cmbFontName.SelectedItem Is Nothing Then
                Return
            End If

            Dim style As FontStyle = GetCheckedFontStyle()
            Dim fontName As String = cmbFontName.SelectedItem.ToString()
            Dim fontSize As Single = CSng(nudFontSize.Value)

            Select Case cmbFontRole.SelectedItem.ToString()
                Case "Title"
                    _theme.TitleFontName = fontName
                    _theme.TitleFontSize = fontSize
                    _theme.TitleFontStyle = style
                Case "Body"
                    _theme.BodyFontName = fontName
                    _theme.BodyFontSize = fontSize
                    _theme.BodyFontStyle = style
                Case "Mono"
                    _theme.MonoFontName = fontName
                    _theme.MonoFontSize = fontSize
                    _theme.MonoFontStyle = style
                Case "Logo"
                    _theme.LogoFontName = fontName
                    _theme.LogoFontSize = fontSize
                    _theme.LogoFontStyle = style
            End Select

            ApplyPreview()
        End Sub

        Private Sub UpdateThemeFromControls()
            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            _theme.Name = If(tbName.Text.Trim().Length = 0, "DarkSaber", tbName.Text.Trim())
            _theme.Author = tbAuthor.Text.Trim()
            _theme.Version = tbVersion.Text.Trim()
            _theme.Description = tbDescription.Text.Trim()
        End Sub

        Private Sub ApplyPreview()
            If _theme Is Nothing Then
                Return
            End If

            pnlPreviewRoot.BackColor = _theme.PanelRoot
            pnlPreviewHeader.BackColor = _theme.PanelHeader
            pnlPreviewBody.BackColor = _theme.PanelBody
            pnlPreviewFooter.BackColor = _theme.PanelFooter
            lblPreviewHeaderSeparator.BackColor = _theme.HeaderSeparator
            lblPreviewFooterSeparator.BackColor = _theme.FooterSeparator

            lblPreviewTitle.Text = _theme.Name
            lblPreviewTitle.ForeColor = _theme.HeaderTitleText
            lblPreviewTitle.Font = _theme.CreateTitleFont()
            lblPreviewSubtitle.ForeColor = _theme.HeaderSubtitleText
            lblPreviewSubtitle.Font = _theme.CreateBodyFont()

            lblPreviewBody.ForeColor = _theme.TextPrimary
            lblPreviewBody.Font = _theme.CreateBodyFont()
            lblPreviewMuted.ForeColor = _theme.TextMuted
            lblPreviewMuted.Font = _theme.CreateBodyFont()

            btnPreview.BackColor = _theme.ControlDark
            btnPreview.ForeColor = _theme.TextPrimary
            btnPreview.FlatStyle = FlatStyle.Flat
            btnPreview.FlatAppearance.BorderColor = _theme.BorderDark
            btnPreview.Font = _theme.CreateBodyFont()

            txtPreview.BackColor = _theme.WindowBack
            txtPreview.BackColor = _theme.InputBack
            txtPreview.ForeColor = _theme.InputText
            txtPreview.Font = _theme.CreateMonoFont()
            txtPreview.BorderStyle = BorderStyle.FixedSingle

            tbPreviewPath.BackColor = _theme.InputBack
            tbPreviewPath.ForeColor = _theme.InputText
            tbPreviewPath.Font = _theme.CreateBodyFont()
            tbPreviewPath.BorderStyle = BorderStyle.FixedSingle

            grpPreview.ForeColor = _theme.GroupBorder
            chkPreview.ForeColor = _theme.TextSecondary
            rbPreviewInternal.ForeColor = _theme.TextSecondary
            rbPreviewExternal.ForeColor = _theme.TextSecondary

            btnPreviewBrowse.BackColor = _theme.ControlDark
            btnPreviewBrowse.ForeColor = _theme.TextPrimary
            btnPreviewBrowse.FlatStyle = FlatStyle.Flat
            btnPreviewBrowse.FlatAppearance.BorderColor = _theme.AccentGold
            btnPreviewBrowse.FlatAppearance.MouseOverBackColor = _theme.ControlHover
            btnPreviewBrowse.FlatAppearance.MouseDownBackColor = _theme.ControlDown
            btnPreviewBrowse.Font = _theme.CreateBodyFont()

            _theme.ApplyToCustomTabControl(tabPreview)
            ApplyProgressPreview()
        End Sub

        Private Sub ApplyProgressPreview()
            If _theme Is Nothing OrElse progressPreview Is Nothing Then
                Return
            End If

            _theme.ApplyToCustomProgressBar(progressPreview)
            progressPreview.Value = 68
            progressPreview.SnapToValue()
            progressPreview.BringToFront()
            progressPreview.Invalidate()
            progressPreview.Update()
        End Sub

        Private Function IsProgressColorKey(ByVal key As String) As Boolean
            If key Is Nothing Then
                Return False
            End If

            Return key.StartsWith("Progress", StringComparison.OrdinalIgnoreCase)
        End Function

        Private Function GetThemeColor(ByVal key As String) As Color
            Select Case key
                Case "WindowBack" : Return _theme.WindowBack
                Case "PanelRoot" : Return _theme.PanelRoot
                Case "PanelHeader" : Return _theme.PanelHeader
                Case "PanelBody" : Return _theme.PanelBody
                Case "PanelFooter" : Return _theme.PanelFooter
                Case "TextPrimary" : Return _theme.TextPrimary
                Case "TextSecondary" : Return _theme.TextSecondary
                Case "TextMuted" : Return _theme.TextMuted
                Case "HeaderTitleText" : Return _theme.HeaderTitleText
                Case "HeaderSubtitleText" : Return _theme.HeaderSubtitleText
                Case "AccentGold" : Return _theme.AccentGold
                Case "AccentGoldLight" : Return _theme.AccentGoldLight
                Case "BorderDark" : Return _theme.BorderDark
                Case "HeaderSeparator" : Return _theme.HeaderSeparator
                Case "FooterSeparator" : Return _theme.FooterSeparator
                Case "GroupBorder" : Return _theme.GroupBorder
                Case "ControlDark" : Return _theme.ControlDark
                Case "ControlHover" : Return _theme.ControlHover
                Case "ControlDown" : Return _theme.ControlDown
                Case "InputBack" : Return _theme.InputBack
                Case "InputText" : Return _theme.InputText
                Case "InputBorder" : Return _theme.InputBorder
                Case "InputBackAlt" : Return _theme.InputBackAlt
                Case "DisabledText" : Return _theme.DisabledText
                Case "LogoBack" : Return _theme.LogoBack
                Case "ValidationErrorBack" : Return _theme.ValidationErrorBack
                Case "DataGridBack" : Return _theme.DataGridBack
                Case "DataGridBackground" : Return _theme.DataGridBackground
                Case "DataGridAlternatingBack" : Return _theme.DataGridAlternatingBack
                Case "DataGridGridLine" : Return _theme.DataGridGridLine
                Case "DataGridHeaderBack" : Return _theme.DataGridHeaderBack
                Case "DataGridHeaderText" : Return _theme.DataGridHeaderText
                Case "DataGridSelectionBack" : Return _theme.DataGridSelectionBack
                Case "DataGridSelectionText" : Return _theme.DataGridSelectionText
                Case "DataGridLink" : Return _theme.DataGridLink
                Case "ByteViewerBack" : Return _theme.ByteViewerBack
                Case "ByteViewerAltRow" : Return _theme.ByteViewerAltRow
                Case "ByteViewerSelectionBack" : Return _theme.ByteViewerSelectionBack
                Case "ByteViewerCurrentBack" : Return _theme.ByteViewerCurrentBack
                Case "ByteViewerNullBack" : Return _theme.ByteViewerNullBack
                Case "ByteViewerControlBack" : Return _theme.ByteViewerControlBack
                Case "ByteViewerHighAsciiBack" : Return _theme.ByteViewerHighAsciiBack
                Case "ByteViewerNonPrintableBack" : Return _theme.ByteViewerNonPrintableBack
                Case "PictureBorder" : Return _theme.PictureBorder
                Case "PictureBorderSecondary" : Return _theme.PictureBorderSecondary
                Case "PictureOuterShadow" : Return _theme.PictureOuterShadow
                Case "PictureInnerHighlight" : Return _theme.PictureInnerHighlight
                Case "ProgressBorderDark" : Return _theme.ProgressBorderDark
                Case "ProgressBorderAccent" : Return _theme.ProgressBorderAccent
                Case "ProgressTrackTop" : Return _theme.ProgressTrackTop
                Case "ProgressTrackBottom" : Return _theme.ProgressTrackBottom
                Case "ProgressFillTop" : Return _theme.ProgressFillTop
                Case "ProgressFillMiddle" : Return _theme.ProgressFillMiddle
                Case "ProgressFillBottom" : Return _theme.ProgressFillBottom
                Case "ProgressShineTop" : Return _theme.ProgressShineTop
                Case "ProgressShineBottom" : Return _theme.ProgressShineBottom
                Case "ProgressEdgeLight" : Return _theme.ProgressEdgeLight
                Case "ProgressBottomGlow" : Return _theme.ProgressBottomGlow
                Case "ProgressInsetHighlight" : Return _theme.ProgressInsetHighlight
                Case "ProgressTrackShadow" : Return _theme.ProgressTrackShadow
                Case "ProgressSweep" : Return _theme.ProgressSweep
                Case "TabControlBack" : Return _theme.TabControlBack
                Case "TabStripBack" : Return _theme.TabStripBack
                Case "TabPageBack" : Return _theme.TabPageBack
                Case "TabNormalBack" : Return _theme.TabNormalBack
                Case "TabSelectedBack" : Return _theme.TabSelectedBack
                Case "TabNormalText" : Return _theme.TabNormalText
                Case "TabSelectedText" : Return _theme.TabSelectedText
                Case "TabDivider" : Return _theme.TabDivider
                Case "TabBorder" : Return _theme.TabBorder
                Case "TabSelectedBorder" : Return _theme.TabSelectedBorder
                Case "TabChromeBack" : Return _theme.TabChromeBack
                Case "TabNativeBorderBack" : Return _theme.TabNativeBorderBack
                Case "TabPageChromeBack" : Return _theme.TabPageChromeBack
                Case "TabPageEdgeBack" : Return _theme.TabPageEdgeBack
                Case "TabOuterNativeBorderBack" : Return _theme.TabOuterNativeBorderBack
            End Select

            Return Color.Black
        End Function

        Private Sub SetThemeColor(ByVal key As String, ByVal value As Color)
            Select Case key
                Case "WindowBack" : _theme.WindowBack = value
                Case "PanelRoot" : _theme.PanelRoot = value
                Case "PanelHeader" : _theme.PanelHeader = value
                Case "PanelBody" : _theme.PanelBody = value
                Case "PanelFooter" : _theme.PanelFooter = value
                Case "TextPrimary" : _theme.TextPrimary = value
                Case "TextSecondary" : _theme.TextSecondary = value
                Case "TextMuted" : _theme.TextMuted = value
                Case "HeaderTitleText" : _theme.HeaderTitleText = value
                Case "HeaderSubtitleText" : _theme.HeaderSubtitleText = value
                Case "AccentGold" : _theme.AccentGold = value
                Case "AccentGoldLight" : _theme.AccentGoldLight = value
                Case "BorderDark" : _theme.BorderDark = value
                Case "HeaderSeparator" : _theme.HeaderSeparator = value
                Case "FooterSeparator" : _theme.FooterSeparator = value
                Case "GroupBorder" : _theme.GroupBorder = value
                Case "ControlDark" : _theme.ControlDark = value
                Case "ControlHover" : _theme.ControlHover = value
                Case "ControlDown" : _theme.ControlDown = value
                Case "InputBack" : _theme.InputBack = value
                Case "InputText" : _theme.InputText = value
                Case "InputBorder" : _theme.InputBorder = value
                Case "InputBackAlt" : _theme.InputBackAlt = value
                Case "DisabledText" : _theme.DisabledText = value
                Case "LogoBack" : _theme.LogoBack = value
                Case "ValidationErrorBack" : _theme.ValidationErrorBack = value
                Case "DataGridBack" : _theme.DataGridBack = value
                Case "DataGridBackground" : _theme.DataGridBackground = value
                Case "DataGridAlternatingBack" : _theme.DataGridAlternatingBack = value
                Case "DataGridGridLine" : _theme.DataGridGridLine = value
                Case "DataGridHeaderBack" : _theme.DataGridHeaderBack = value
                Case "DataGridHeaderText" : _theme.DataGridHeaderText = value
                Case "DataGridSelectionBack" : _theme.DataGridSelectionBack = value
                Case "DataGridSelectionText" : _theme.DataGridSelectionText = value
                Case "DataGridLink" : _theme.DataGridLink = value
                Case "ByteViewerBack" : _theme.ByteViewerBack = value
                Case "ByteViewerAltRow" : _theme.ByteViewerAltRow = value
                Case "ByteViewerSelectionBack" : _theme.ByteViewerSelectionBack = value
                Case "ByteViewerCurrentBack" : _theme.ByteViewerCurrentBack = value
                Case "ByteViewerNullBack" : _theme.ByteViewerNullBack = value
                Case "ByteViewerControlBack" : _theme.ByteViewerControlBack = value
                Case "ByteViewerHighAsciiBack" : _theme.ByteViewerHighAsciiBack = value
                Case "ByteViewerNonPrintableBack" : _theme.ByteViewerNonPrintableBack = value
                Case "PictureBorder" : _theme.PictureBorder = value
                Case "PictureBorderSecondary" : _theme.PictureBorderSecondary = value
                Case "PictureOuterShadow" : _theme.PictureOuterShadow = value
                Case "PictureInnerHighlight" : _theme.PictureInnerHighlight = value
                Case "ProgressBorderDark" : _theme.ProgressBorderDark = value
                Case "ProgressBorderAccent" : _theme.ProgressBorderAccent = value
                Case "ProgressTrackTop" : _theme.ProgressTrackTop = value
                Case "ProgressTrackBottom" : _theme.ProgressTrackBottom = value
                Case "ProgressFillTop" : _theme.ProgressFillTop = value
                Case "ProgressFillMiddle" : _theme.ProgressFillMiddle = value
                Case "ProgressFillBottom" : _theme.ProgressFillBottom = value
                Case "ProgressShineTop" : _theme.ProgressShineTop = value
                Case "ProgressShineBottom" : _theme.ProgressShineBottom = value
                Case "ProgressEdgeLight" : _theme.ProgressEdgeLight = value
                Case "ProgressBottomGlow" : _theme.ProgressBottomGlow = value
                Case "ProgressInsetHighlight" : _theme.ProgressInsetHighlight = value
                Case "ProgressTrackShadow" : _theme.ProgressTrackShadow = value
                Case "ProgressSweep" : _theme.ProgressSweep = value
                Case "TabControlBack" : _theme.TabControlBack = value
                Case "TabStripBack" : _theme.TabStripBack = value
                Case "TabPageBack" : _theme.TabPageBack = value
                Case "TabNormalBack" : _theme.TabNormalBack = value
                Case "TabSelectedBack" : _theme.TabSelectedBack = value
                Case "TabNormalText" : _theme.TabNormalText = value
                Case "TabSelectedText" : _theme.TabSelectedText = value
                Case "TabDivider" : _theme.TabDivider = value
                Case "TabBorder" : _theme.TabBorder = value
                Case "TabSelectedBorder" : _theme.TabSelectedBorder = value
                Case "TabChromeBack" : _theme.TabChromeBack = value
                Case "TabNativeBorderBack" : _theme.TabNativeBorderBack = value
                Case "TabPageChromeBack" : _theme.TabPageChromeBack = value
                Case "TabPageEdgeBack" : _theme.TabPageEdgeBack = value
                Case "TabOuterNativeBorderBack" : _theme.TabOuterNativeBorderBack = value
            End Select
        End Sub

        Private Sub FillFonts()
            Dim fonts As InstalledFontCollection = New InstalledFontCollection()

            For Each family As FontFamily In fonts.Families
                cmbFontName.Items.Add(family.Name)
            Next
        End Sub

        Private Sub SelectFontName(ByVal fontName As String)
            For i As Integer = 0 To cmbFontName.Items.Count - 1
                If String.Compare(cmbFontName.Items(i).ToString(), fontName, True, CultureInfo.InvariantCulture) = 0 Then
                    cmbFontName.SelectedIndex = i
                    Return
                End If
            Next

            If cmbFontName.Items.Count > 0 Then
                cmbFontName.SelectedIndex = 0
            End If
        End Sub

        Private Sub SetFontStyleChecks(ByVal style As FontStyle)
            chkbBold.Checked = ((style And FontStyle.Bold) = FontStyle.Bold)
            chkbItalic.Checked = ((style And FontStyle.Italic) = FontStyle.Italic)
            chkbUnderline.Checked = ((style And FontStyle.Underline) = FontStyle.Underline)
            chkbStrikeout.Checked = ((style And FontStyle.Strikeout) = FontStyle.Strikeout)
        End Sub

        Private Function GetCheckedFontStyle() As FontStyle
            Dim style As FontStyle = FontStyle.Regular

            If chkbBold.Checked Then
                style = style Or FontStyle.Bold
            End If

            If chkbItalic.Checked Then
                style = style Or FontStyle.Italic
            End If

            If chkbUnderline.Checked Then
                style = style Or FontStyle.Underline
            End If

            If chkbStrikeout.Checked Then
                style = style Or FontStyle.Strikeout
            End If

            Return style
        End Function

        Private Class ThemeColorEntry
            Public Key As String
            Private ReadOnly _displayName As String

            Public Sub New(ByVal key As String, ByVal displayName As String)
                Me.Key = key
                Me._displayName = displayName
            End Sub

            Public Overrides Function ToString() As String
                Return _displayName
            End Function
        End Class

    End Class

End Namespace
