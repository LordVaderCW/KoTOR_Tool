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

        ' -----------------------------------------------------------------
        ' CustomTabControl
        ' Copyright (C) LordVaderCW, MIT Licence, the usual stuff. Credit me if you use it. 
        '
        ' DarkSaber owner-drawn TabControl/ Renders better in Standard, complete control over Standard appearance. 
        '
        ' Purpose:
        '   - Removes the default white Windows TabControl background.
        '   - Allows the main TabControl background to be styled.
        '   - Allows the native tab strip background to be styled.
        '   - Allows TabPage backgrounds to be styled.
        '   - Draws tabs manually using dark colours.
        '   - Adds a custom optional outer border.
        '   - Erases, suppresses, or repaints the native inner page inset.
        '   - Allows custom tab border, corner radius, bevel strength, and bevel angle.
        '
        ' Notes:
        '   - This control is intentionally kept WinForms / .NET 4.0 friendly.
        '   - OwnerDrawFixed paints the tab buttons only.
        '   - The empty strip behind the tabs is still painted natively.
        '   - WM_PAINT is used to repaint native areas that TabControl keeps.
        '   - TabPages are forced to UseVisualStyleBackColor = False so that
        '     the designer/runtime does not restore the pale system colour.
        ' -----------------------------------------------------------------
        ' -----------------------------------------------------------------
        ' Default DarkSaber Integrated Tab Layout
        '
        ' These defaults are intentionally tuned together.
        '
        ' Recommended baseline:
        '
        '   CustomBorderStyle          = Accent
        '
        '   ControlBackColor           = 18, 22, 28
        '   TabStripBackColor          = 22, 27, 34
        '   TabPageBackColor           = 22, 27, 34
        '
        '   NormalTabBackColor         = 28, 35, 44
        '   SelectedTabBackColor       = 22, 27, 34
        '
        '   NormalTextColor            = 188, 198, 210
        '   SelectedTextColor          = 238, 238, 230
        '
        '   AccentColor                = 174, 136, 58
        '   DarkBorderColor            = 62, 70, 82
        '
        '   ShowTabBorder              = False
        '   ShowTabButtonBorder        = False
        '   ShowTabChromeErase         = False
        '   ShowTabDivider             = False
        '   ShowTabNativeInsetBorder   = False
        '   ShowPageInsetBorder        = False
        '
        '   PageInsetErasePadding      = 1
        '   PageChromeErasePadding     = 4
        '   PageEdgeArtifactThickness  = 2
        '   PageEdgeArtifactOffset     = 0
        '
        ' The accent outer border visually integrates the tab strip with the
        ' surrounding editor panel without needing extra native-border hacks.
        ' -----------------------------------------------------------------
        ' DarkSaber CustomTabControl - Tuned Default Property Documentation
        ' -----------------------------------------------------------------
        '
        ' This block documents the tuned integrated tab layout defaults.
        ' These values are intended for the current DarkSaber appearance used by
        ' the KoTOR Tool restoration forms.
        '
        ' Recommended Behaviour Properties:
        '
        '   Appearance = TabAppearance.Normal
        '     Purpose:
        '       Uses the standard tab rendering mode. This gives the cleanest
        '       integrated result with the current owner-drawn DarkSaber painter.
        '     Example:
        '       Me.TabControl1.Appearance = TabAppearance.Normal
        '
        '   DrawMode = TabDrawMode.OwnerDrawFixed
        '     Purpose:
        '       Required. Allows the control to paint the tab headers manually.
        '     Example:
        '       Me.TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        '
        '   ItemSize = New Size(88, 31)
        '     Purpose:
        '       Controls the fixed tab header dimensions.
        '     Example:
        '       Me.TabControl1.ItemSize = New Size(88, 31)
        '
        '   Multiline = True
        '     Purpose:
        '       Allows multiple rows of tab headers.
        '     Example:
        '       Me.TabControl1.Multiline = True
        '
        '   Padding = New Point(10, 3)
        '     Purpose:
        '       Controls inner tab text/header spacing.
        '     Example:
        '       Me.TabControl1.Padding = New Point(10, 3)
        '
        '   SizeMode = TabSizeMode.FillToRight
        '     Purpose:
        '       Allows tabs to fill available horizontal header space.
        '     Example:
        '       Me.TabControl1.SizeMode = TabSizeMode.FillToRight
        '
        '
        ' -----------------------------------------------------------------
        ' DarkSaber Colour Defaults
        ' -----------------------------------------------------------------
        '
        '   AccentColor = Color.FromArgb(174, 136, 58)
        '     Purpose:
        '       Gold highlight used for selected underline and accent borders.
        '     Example:
        '       Me.TabControl1.AccentColor = Color.FromArgb(174, 136, 58)
        '
        '   ControlBackColor = Color.FromArgb(22, 27, 34)
        '     Purpose:
        '       Main visible background of the control surface.
        '     Example:
        '       Me.TabControl1.ControlBackColor = Color.FromArgb(22, 27, 34)
        '
        '   DarkBorderColor = Color.FromArgb(62, 70, 82)
        '     Purpose:
        '       Standard dark border colour when CustomBorderStyle = Dark.
        '     Example:
        '       Me.TabControl1.DarkBorderColor = Color.FromArgb(62, 70, 82)
        '
        '   DividerColor = Color.FromArgb(62, 70, 82)
        '     Purpose:
        '       Optional divider-line colour between tabs.
        '     Example:
        '       Me.TabControl1.DividerColor = Color.FromArgb(62, 70, 82)
        '
        '   NormalTabBackColor = Color.FromArgb(28, 35, 44)
        '     Purpose:
        '       Background colour for unselected tabs.
        '     Example:
        '       Me.TabControl1.NormalTabBackColor = Color.FromArgb(28, 35, 44)
        '
        '   SelectedTabBackColor = Color.FromArgb(22, 27, 34)
        '     Purpose:
        '       Background colour for the selected tab.
        '     Example:
        '       Me.TabControl1.SelectedTabBackColor = Color.FromArgb(22, 27, 34)
        '
        '   NormalTextColor = Color.FromArgb(188, 198, 210)
        '     Purpose:
        '       Text colour for unselected tabs.
        '     Example:
        '       Me.TabControl1.NormalTextColor = Color.FromArgb(188, 198, 210)
        '
        '   SelectedTextColor = Color.FromArgb(238, 238, 230)
        '     Purpose:
        '       Text colour for selected tabs.
        '     Example:
        '       Me.TabControl1.SelectedTextColor = Color.FromArgb(238, 238, 230)
        '
        '   TabPageBackColor = Color.FromArgb(22, 27, 34)
        '     Purpose:
        '       Background colour applied to each TabPage.
        '     Example:
        '       Me.TabControl1.TabPageBackColor = Color.FromArgb(22, 27, 34)
        '
        '   TabStripBackColor = Color.FromArgb(22, 27, 34)
        '     Purpose:
        '       Background behind the tab headers.
        '     Example:
        '       Me.TabControl1.TabStripBackColor = Color.FromArgb(22, 27, 34)
        '
        '
        ' -----------------------------------------------------------------
        ' Control Border Defaults
        ' -----------------------------------------------------------------
        '
        '   CustomBorderStyle = CustomTabBorderStyle.Accent
        '     Purpose:
        '       Paints the outer TabControl border using AccentColor.
        '       This is the main trick that visually integrates the tab area
        '       with the surrounding editor panel.
        '     Example:
        '       Me.TabControl1.CustomBorderStyle = CustomTabBorderStyle.Accent
        '
        '   ShowOuterNativeBorderErase = True
        '     Purpose:
        '       Enables cleanup of remaining native outer TabControl artefacts.
        '     Example:
        '       Me.TabControl1.ShowOuterNativeBorderErase = True
        '
        '   OuterNativeBorderBackColor = Color.FromArgb(18, 22, 28)
        '     Purpose:
        '       Colour used to erase native outer border fragments.
        '     Example:
        '       Me.TabControl1.OuterNativeBorderBackColor = Color.FromArgb(18, 22, 28)
        '
        '   OuterNativeBorderErasePadding = 3
        '     Purpose:
        '       Thickness of the native outer border erase pass.
        '     Example:
        '       Me.TabControl1.OuterNativeBorderErasePadding = 3
        '
        '
        ' -----------------------------------------------------------------
        ' Page / Container Border Defaults
        ' -----------------------------------------------------------------
        '
        '   ShowPageInsetBorder = False
        '     Purpose:
        '       Leaves the inner page inset border disabled for a cleaner integrated
        '       look.
        '     Example:
        '       Me.TabControl1.ShowPageInsetBorder = False
        '
        '   PageInsetBorderColor = Color.FromArgb(62, 70, 82)
        '     Purpose:
        '       Colour used if ShowPageInsetBorder is enabled.
        '     Example:
        '       Me.TabControl1.PageInsetBorderColor = Color.FromArgb(62, 70, 82)
        '
        '   PageInsetBorderThickness = 1
        '     Purpose:
        '       Thickness used if ShowPageInsetBorder is enabled.
        '     Example:
        '       Me.TabControl1.PageInsetBorderThickness = 1
        '
        '   PageInsetErasePadding = 1
        '     Purpose:
        '       Padding used to erase the native inner inset border.
        '     Example:
        '       Me.TabControl1.PageInsetErasePadding = 1
        '
        '   ShowPageChromeErase = True
        '     Purpose:
        '       Enables cleanup of native page chrome fragments.
        '     Example:
        '       Me.TabControl1.ShowPageChromeErase = True
        '
        '   PageChromeBackColor = Color.FromArgb(22, 27, 34)
        '     Purpose:
        '       Colour used for broad page chrome cleanup.
        '     Example:
        '       Me.TabControl1.PageChromeBackColor = Color.FromArgb(22, 27, 34)
        '
        '   PageChromeErasePadding = 4
        '     Purpose:
        '       Padding used for the page chrome erase pass.
        '     Example:
        '       Me.TabControl1.PageChromeErasePadding = 4
        '
        '   ShowPageEdgeArtifactErase = True
        '     Purpose:
        '       Enables targeted cleanup of stubborn vertical and bottom edge artefacts.
        '     Example:
        '       Me.TabControl1.ShowPageEdgeArtifactErase = True
        '
        '   PageEdgeArtifactBackColor = Color.FromArgb(22, 27, 34)
        '     Purpose:
        '       Colour used to erase page-edge artefacts.
        '     Example:
        '       Me.TabControl1.PageEdgeArtifactBackColor = Color.FromArgb(22, 27, 34)
        '
        '   PageEdgeArtifactOffset = 0
        '     Purpose:
        '       Offset used when targeting page-edge artefact cleanup.
        '     Example:
        '       Me.TabControl1.PageEdgeArtifactOffset = 0
        '
        '   PageEdgeArtifactThickness = 2
        '     Purpose:
        '       Thickness of the targeted page-edge artefact erase pass.
        '     Example:
        '       Me.TabControl1.PageEdgeArtifactThickness = 2
        '
        '
        ' -----------------------------------------------------------------
        ' Tab Border Defaults
        ' -----------------------------------------------------------------
        '
        '   ShowTabBorder = False
        '     Purpose:
        '       Disables the main custom tab body border for a flatter integrated
        '       appearance.
        '     Example:
        '       Me.TabControl1.ShowTabBorder = False
        '
        '   TabBorderColor = Color.FromArgb(90, 100, 115)
        '     Purpose:
        '       Border colour used if ShowTabBorder is enabled.
        '     Example:
        '       Me.TabControl1.TabBorderColor = Color.FromArgb(90, 100, 115)
        '
        '   SelectedTabBorderColor = Color.FromArgb(174, 136, 58)
        '     Purpose:
        '       Selected tab body border colour if ShowTabBorder is enabled.
        '     Example:
        '       Me.TabControl1.SelectedTabBorderColor = Color.FromArgb(174, 136, 58)
        '
        '   TabBorderThickness = 1
        '     Purpose:
        '       Thickness of the main custom tab body border.
        '     Example:
        '       Me.TabControl1.TabBorderThickness = 1
        '
        '   ShowTabButtonBorder = False
        '     Purpose:
        '       Disables button-style tab borders for the tuned normal appearance.
        '     Example:
        '       Me.TabControl1.ShowTabButtonBorder = False
        '
        '   TabButtonBorderColor = Color.FromArgb(90, 100, 115)
        '     Purpose:
        '       Button-style border colour if ShowTabButtonBorder is enabled.
        '     Example:
        '       Me.TabControl1.TabButtonBorderColor = Color.FromArgb(90, 100, 115)
        '
        '   SelectedTabButtonBorderColor = Color.FromArgb(174, 136, 58)
        '     Purpose:
        '       Selected button-style border colour if ShowTabButtonBorder is enabled.
        '     Example:
        '       Me.TabControl1.SelectedTabButtonBorderColor = Color.FromArgb(174, 136, 58)
        '
        '   TabButtonBorderInset = 0
        '     Purpose:
        '       Inset applied to the button-style border rectangle.
        '     Example:
        '       Me.TabControl1.TabButtonBorderInset = 0
        '
        '   TabButtonBorderThickness = 1
        '     Purpose:
        '       Thickness of the button-style tab border.
        '     Example:
        '       Me.TabControl1.TabButtonBorderThickness = 1
        '
        '   ShowTabChromeErase = False
        '     Purpose:
        '       Disabled in the tuned integrated layout because the current normal
        '       appearance does not require full tab-row chrome erasing.
        '     Example:
        '       Me.TabControl1.ShowTabChromeErase = False
        '
        '   TabChromeBackColor = Color.FromArgb(18, 22, 28)
        '     Purpose:
        '       Colour used if ShowTabChromeErase is enabled.
        '     Example:
        '       Me.TabControl1.TabChromeBackColor = Color.FromArgb(18, 22, 28)
        '
        '   TabChromeErasePadding = 4
        '     Purpose:
        '       Padding used if ShowTabChromeErase is enabled.
        '     Example:
        '       Me.TabControl1.TabChromeErasePadding = 4
        '
        '   TabCornerRadius = 0
        '     Purpose:
        '       Keeps tabs square and consistent with the DarkSaber editor style.
        '     Example:
        '       Me.TabControl1.TabCornerRadius = 0
        '
        '   TabBevelAngle = 90.0!
        '     Purpose:
        '       Gradient angle used only when TabBevelStrength is above 0.
        '     Example:
        '       Me.TabControl1.TabBevelAngle = 90.0!
        '
        '   TabBevelStrength = 0
        '     Purpose:
        '       Disables bevel/gradient fill for a clean flat tab appearance.
        '     Example:
        '       Me.TabControl1.TabBevelStrength = 0
        '
        '
        ' -----------------------------------------------------------------
        ' Tab Native / Divider Defaults
        ' -----------------------------------------------------------------
        '
        '   ShowTabDivider = False
        '     Purpose:
        '       Disables divider lines between tabs.
        '     Example:
        '       Me.TabControl1.ShowTabDivider = False
        '
        '   TabDividerInsetTop = 6
        '     Purpose:
        '       Top inset used if ShowTabDivider is enabled.
        '     Example:
        '       Me.TabControl1.TabDividerInsetTop = 6
        '
        '   TabDividerInsetBottom = 6
        '     Purpose:
        '       Bottom inset used if ShowTabDivider is enabled.
        '     Example:
        '       Me.TabControl1.TabDividerInsetBottom = 6
        '
        '   TabDividerOffsetX = -2
        '     Purpose:
        '       Horizontal offset used if ShowTabDivider is enabled.
        '     Example:
        '       Me.TabControl1.TabDividerOffsetX = -2
        '
        '   ShowTabNativeInsetBorder = False
        '     Purpose:
        '       Disables optional native-style tab inset repainting.
        '     Example:
        '       Me.TabControl1.ShowTabNativeInsetBorder = False
        '
        '   TabNativeInsetBorderColor = Color.FromArgb(62, 70, 82)
        '     Purpose:
        '       Colour used if ShowTabNativeInsetBorder is enabled.
        '     Example:
        '       Me.TabControl1.TabNativeInsetBorderColor = Color.FromArgb(62, 70, 82)
        '
        '   TabNativeInsetBorderThickness = 1
        '     Purpose:
        '       Thickness used if ShowTabNativeInsetBorder is enabled.
        '     Example:
        '       Me.TabControl1.TabNativeInsetBorderThickness = 1
        '
        '   TabNativeBorderBackColor = Color.FromArgb(22, 27, 34)
        '     Purpose:
        '       Colour used to erase native tab border pixels.
        '     Example:
        '       Me.TabControl1.TabNativeBorderBackColor = Color.FromArgb(22, 27, 34)
        '
        '   TabNativeBorderErasePadding = 3
        '     Purpose:
        '       Padding used to erase native tab border pixels.
        '     Example:
        '       Me.TabControl1.TabNativeBorderErasePadding = 3
        '
        ' -----------------------------------------------------------------
        ' Full Tuned Usage Block
        ' -----------------------------------------------------------------
        '
        '   Me.TabControl1.Appearance = TabAppearance.Normal
        '   Me.TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        '   Me.TabControl1.ItemSize = New Size(88, 31)
        '   Me.TabControl1.Multiline = True
        '   Me.TabControl1.Padding = New Point(10, 3)
        '   Me.TabControl1.SizeMode = TabSizeMode.FillToRight
        '
        '   Me.TabControl1.AccentColor = Color.FromArgb(174, 136, 58)
        '   Me.TabControl1.ControlBackColor = Color.FromArgb(22, 27, 34)
        '   Me.TabControl1.CustomBorderStyle = CustomTabBorderStyle.Accent
        '   Me.TabControl1.DarkBorderColor = Color.FromArgb(62, 70, 82)
        '   Me.TabControl1.DividerColor = Color.FromArgb(62, 70, 82)
        '   Me.TabControl1.NormalTabBackColor = Color.FromArgb(28, 35, 44)
        '   Me.TabControl1.NormalTextColor = Color.FromArgb(188, 198, 210)
        '   Me.TabControl1.SelectedTabBackColor = Color.FromArgb(22, 27, 34)
        '   Me.TabControl1.SelectedTextColor = Color.FromArgb(238, 238, 230)
        '   Me.TabControl1.TabPageBackColor = Color.FromArgb(22, 27, 34)
        '   Me.TabControl1.TabStripBackColor = Color.FromArgb(22, 27, 34)
        '
        '   Me.TabControl1.OuterNativeBorderBackColor = Color.FromArgb(18, 22, 28)
        '   Me.TabControl1.OuterNativeBorderErasePadding = 3
        '   Me.TabControl1.ShowOuterNativeBorderErase = True
        '
        '   Me.TabControl1.PageChromeBackColor = Color.FromArgb(22, 27, 34)
        '   Me.TabControl1.PageChromeErasePadding = 4
        '   Me.TabControl1.ShowPageChromeErase = True
        '
        '   Me.TabControl1.PageEdgeArtifactBackColor = Color.FromArgb(22, 27, 34)
        '   Me.TabControl1.PageEdgeArtifactOffset = 0
        '   Me.TabControl1.PageEdgeArtifactThickness = 2
        '   Me.TabControl1.ShowPageEdgeArtifactErase = True
        '
        '   Me.TabControl1.PageInsetBorderColor = Color.FromArgb(62, 70, 82)
        '   Me.TabControl1.PageInsetBorderThickness = 1
        '   Me.TabControl1.PageInsetErasePadding = 1
        '   Me.TabControl1.ShowPageInsetBorder = False
        '
        '   Me.TabControl1.SelectedTabBorderColor = Color.FromArgb(174, 136, 58)
        '   Me.TabControl1.ShowTabBorder = False
        '   Me.TabControl1.TabBorderColor = Color.FromArgb(90, 100, 115)
        '   Me.TabControl1.TabBorderThickness = 1
        '
        '   Me.TabControl1.SelectedTabButtonBorderColor = Color.FromArgb(174, 136, 58)
        '   Me.TabControl1.ShowTabButtonBorder = False
        '   Me.TabControl1.TabButtonBorderColor = Color.FromArgb(90, 100, 115)
        '   Me.TabControl1.TabButtonBorderInset = 0
        '   Me.TabControl1.TabButtonBorderThickness = 1
        '
        '   Me.TabControl1.ShowTabChromeErase = False
        '   Me.TabControl1.TabChromeBackColor = Color.FromArgb(18, 22, 28)
        '   Me.TabControl1.TabChromeErasePadding = 4
        '
        '   Me.TabControl1.ShowTabDivider = False
        '   Me.TabControl1.TabDividerInsetBottom = 6
        '   Me.TabControl1.TabDividerInsetTop = 6
        '   Me.TabControl1.TabDividerOffsetX = -2
        '
        '   Me.TabControl1.ShowTabNativeInsetBorder = False
        '   Me.TabControl1.TabNativeBorderBackColor = Color.FromArgb(22, 27, 34)
        '   Me.TabControl1.TabNativeBorderErasePadding = 3
        '   Me.TabControl1.TabNativeInsetBorderColor = Color.FromArgb(62, 70, 82)
        '   Me.TabControl1.TabNativeInsetBorderThickness = 1
        '
        '   Me.TabControl1.TabBevelAngle = 90.0!
        '   Me.TabControl1.TabBevelStrength = 0
        '   Me.TabControl1.TabCornerRadius = 0
        ' -----------------------------------------------------------------

        Private Const WM_PAINT As Integer = &HF

        Private _customBorderStyle As CustomTabBorderStyle = CustomTabBorderStyle.Accent

        Private _controlBackColor As Color = Color.FromArgb(22, 27, 34)
        Private _tabStripBackColor As Color = Color.FromArgb(22, 27, 34)
        Private _tabPageBackColor As Color = Color.FromArgb(22, 27, 34)

        Private _normalTabBackColor As Color = Color.FromArgb(28, 35, 44)
        Private _selectedTabBackColor As Color = Color.FromArgb(22, 27, 34)

        Private _normalTextColor As Color = Color.FromArgb(188, 198, 210)
        Private _selectedTextColor As Color = Color.FromArgb(238, 238, 230)

        Private _dividerColor As Color = Color.FromArgb(62, 70, 82)
        Private _darkBorderColor As Color = Color.FromArgb(62, 70, 82)
        Private _accentColor As Color = Color.FromArgb(174, 136, 58)

        Private _showPageInsetBorder As Boolean = False
        Private _pageInsetBorderColor As Color = Color.FromArgb(62, 70, 82)
        Private _pageInsetBorderThickness As Integer = 1
        Private _pageInsetErasePadding As Integer = 1

        Private _showTabBorder As Boolean = False
        Private _tabBorderColor As Color = Color.FromArgb(90, 100, 115)
        Private _selectedTabBorderColor As Color = Color.FromArgb(174, 136, 58)
        Private _tabBorderThickness As Integer = 1
        Private _tabCornerRadius As Integer = 0
        Private _tabBevelStrength As Integer = 0
        Private _tabBevelAngle As Single = 90.0!

        Private _tabNativeBorderBackColor As Color = Color.FromArgb(22, 27, 34)
        Private _tabNativeBorderErasePadding As Integer = 3
        Private _showTabNativeInsetBorder As Boolean = False
        Private _tabNativeInsetBorderColor As Color = Color.FromArgb(62, 70, 82)
        Private _tabNativeInsetBorderThickness As Integer = 1

        Private _showTabButtonBorder As Boolean = False
        Private _tabButtonBorderColor As Color = Color.FromArgb(90, 100, 115)
        Private _selectedTabButtonBorderColor As Color = Color.FromArgb(174, 136, 58)
        Private _tabButtonBorderThickness As Integer = 1
        Private _tabButtonBorderInset As Integer = 0

        Private _showTabChromeErase As Boolean = False
        Private _tabChromeBackColor As Color = Color.FromArgb(18, 22, 28)
        Private _tabChromeErasePadding As Integer = 4

        Private _showTabDivider As Boolean = False
        Private _tabDividerInsetTop As Integer = 6
        Private _tabDividerInsetBottom As Integer = 6
        Private _tabDividerOffsetX As Integer = -2

        Private _showOuterNativeBorderErase As Boolean = True
        Private _outerNativeBorderBackColor As Color = Color.FromArgb(18, 22, 28)
        Private _outerNativeBorderErasePadding As Integer = 3

        Private _showPageChromeErase As Boolean = True
        Private _pageChromeBackColor As Color = Color.FromArgb(22, 27, 34)
        Private _pageChromeErasePadding As Integer = 4

        Private _showPageEdgeArtifactErase As Boolean = True
        Private _pageEdgeArtifactBackColor As Color = Color.FromArgb(22, 27, 34)
        Private _pageEdgeArtifactThickness As Integer = 2
        Private _pageEdgeArtifactOffset As Integer = 0

        <Category("DarkSaber")>
        <Description("Controls whether the inner native-style page inset border is repainted after being erased.")>
        <DefaultValue(False)>
        Public Property ShowPageInsetBorder() As Boolean
            Get
                Return _showPageInsetBorder
            End Get
            Set(ByVal value As Boolean)
                _showPageInsetBorder = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the custom colour used when the optional inner page inset border is painted.")>
        Public Property PageInsetBorderColor() As Color
            Get
                Return _pageInsetBorderColor
            End Get
            Set(ByVal value As Color)
                _pageInsetBorderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the thickness of the optional inner page inset border.")>
        <DefaultValue(1)>
        Public Property PageInsetBorderThickness() As Integer
            Get
                Return _pageInsetBorderThickness
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                If value > 8 Then value = 8

                _pageInsetBorderThickness = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls how aggressively the native inner page inset border is erased before optional repainting.")>
        <DefaultValue(1)>
        Public Property PageInsetErasePadding() As Integer
            Get
                Return _pageInsetErasePadding
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                If value > 20 Then value = 20

                _pageInsetErasePadding = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls whether each tab header receives a custom painted border.")>
        <DefaultValue(False)>
        Public Property ShowTabBorder() As Boolean
            Get
                Return _showTabBorder
            End Get
            Set(ByVal value As Boolean)
                _showTabBorder = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the border colour around unselected tab headers.")>
        Public Property TabBorderColor() As Color
            Get
                Return _tabBorderColor
            End Get
            Set(ByVal value As Color)
                _tabBorderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the border colour around the selected tab header.")>
        Public Property SelectedTabBorderColor() As Color
            Get
                Return _selectedTabBorderColor
            End Get
            Set(ByVal value As Color)
                _selectedTabBorderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the border thickness around tab headers.")>
        <DefaultValue(1)>
        Public Property TabBorderThickness() As Integer
            Get
                Return _tabBorderThickness
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                If value > 8 Then value = 8

                _tabBorderThickness = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the corner radius of the custom tab header shape. Use 0 for square WinForms-style tabs.")>
        <DefaultValue(0)>
        Public Property TabCornerRadius() As Integer
            Get
                Return _tabCornerRadius
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                If value > 18 Then value = 18

                _tabCornerRadius = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the bevel/gradient strength of tab headers. Use 0 for a flat fill.")>
        <DefaultValue(0)>
        Public Property TabBevelStrength() As Integer
            Get
                Return _tabBevelStrength
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                If value > 100 Then value = 100

                _tabBevelStrength = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the angle of the tab bevel gradient in degrees.")>
        <DefaultValue(GetType(Single), "90")>
        Public Property TabBevelAngle() As Single
            Get
                Return _tabBevelAngle
            End Get
            Set(ByVal value As Single)
                _tabBevelAngle = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the background colour used to erase native borders around the tab headers.")>
        Public Property TabNativeBorderBackColor() As Color
            Get
                Return _tabNativeBorderBackColor
            End Get
            Set(ByVal value As Color)
                _tabNativeBorderBackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls how aggressively the native border around each tab header is erased.")>
        <DefaultValue(3)>
        Public Property TabNativeBorderErasePadding() As Integer
            Get
                Return _tabNativeBorderErasePadding
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                If value > 12 Then value = 12

                _tabNativeBorderErasePadding = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls whether a custom native-style inset border is painted around each tab header after the native border is erased.")>
        <DefaultValue(False)>
        Public Property ShowTabNativeInsetBorder() As Boolean
            Get
                Return _showTabNativeInsetBorder
            End Get
            Set(ByVal value As Boolean)
                _showTabNativeInsetBorder = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the custom inset border colour painted around each tab header when enabled.")>
        Public Property TabNativeInsetBorderColor() As Color
            Get
                Return _tabNativeInsetBorderColor
            End Get
            Set(ByVal value As Color)
                _tabNativeInsetBorderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the custom inset border thickness painted around each tab header when enabled.")>
        <DefaultValue(1)>
        Public Property TabNativeInsetBorderThickness() As Integer
            Get
                Return _tabNativeInsetBorderThickness
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                If value > 8 Then value = 8

                _tabNativeInsetBorderThickness = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls whether the button-style tab border is painted around each tab header.")>
        <DefaultValue(False)>
        Public Property ShowTabButtonBorder() As Boolean
            Get
                Return _showTabButtonBorder
            End Get
            Set(ByVal value As Boolean)
                _showTabButtonBorder = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the button-style border colour around unselected tab headers.")>
        Public Property TabButtonBorderColor() As Color
            Get
                Return _tabButtonBorderColor
            End Get
            Set(ByVal value As Color)
                _tabButtonBorderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the button-style border colour around the selected tab header.")>
        Public Property SelectedTabButtonBorderColor() As Color
            Get
                Return _selectedTabButtonBorderColor
            End Get
            Set(ByVal value As Color)
                _selectedTabButtonBorderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the thickness of the button-style border around tab headers.")>
        <DefaultValue(1)>
        Public Property TabButtonBorderThickness() As Integer
            Get
                Return _tabButtonBorderThickness
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                If value > 8 Then value = 8

                _tabButtonBorderThickness = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the inset of the button-style border inside the tab rectangle.")>
        <DefaultValue(0)>
        Public Property TabButtonBorderInset() As Integer
            Get
                Return _tabButtonBorderInset
            End Get
            Set(ByVal value As Integer)
                If value < -4 Then value = -4
                If value > 8 Then value = 8

                _tabButtonBorderInset = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls whether the remaining native tab chrome border around the tab row is erased and the tabs are redrawn.")>
        <DefaultValue(False)>
        Public Property ShowTabChromeErase() As Boolean
            Get
                Return _showTabChromeErase
            End Get
            Set(ByVal value As Boolean)
                _showTabChromeErase = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the background colour used to erase the remaining native tab chrome border around the tab row.")>
        Public Property TabChromeBackColor() As Color
            Get
                Return _tabChromeBackColor
            End Get
            Set(ByVal value As Color)
                _tabChromeBackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls how aggressively the remaining native tab chrome border around the tab row is erased.")>
        <DefaultValue(4)>
        Public Property TabChromeErasePadding() As Integer
            Get
                Return _tabChromeErasePadding
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                If value > 16 Then value = 16

                _tabChromeErasePadding = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls whether a divider line is painted between tab headers.")>
        <DefaultValue(False)>
        Public Property ShowTabDivider() As Boolean
            Get
                Return _showTabDivider
            End Get
            Set(ByVal value As Boolean)
                _showTabDivider = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the top inset of the optional divider line between tab headers.")>
        <DefaultValue(6)>
        Public Property TabDividerInsetTop() As Integer
            Get
                Return _tabDividerInsetTop
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                If value > 24 Then value = 24

                _tabDividerInsetTop = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the bottom inset of the optional divider line between tab headers.")>
        <DefaultValue(6)>
        Public Property TabDividerInsetBottom() As Integer
            Get
                Return _tabDividerInsetBottom
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then value = 0
                If value > 24 Then value = 24

                _tabDividerInsetBottom = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the horizontal offset of the optional divider line between tab headers.")>
        <DefaultValue(-2)>
        Public Property TabDividerOffsetX() As Integer
            Get
                Return _tabDividerOffsetX
            End Get
            Set(ByVal value As Integer)
                If value < -12 Then value = -12
                If value > 12 Then value = 12

                _tabDividerOffsetX = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls whether the remaining native page chrome border fragments are erased before optional page inset repainting.")>
        <DefaultValue(True)>
        Public Property ShowPageChromeErase() As Boolean
            Get
                Return _showPageChromeErase
            End Get
            Set(ByVal value As Boolean)
                _showPageChromeErase = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the background colour used to erase remaining native page chrome border fragments.")>
        Public Property PageChromeBackColor() As Color
            Get
                Return _pageChromeBackColor
            End Get
            Set(ByVal value As Color)
                _pageChromeBackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls how aggressively the remaining native page chrome border fragments are erased.")>
        <DefaultValue(4)>
        Public Property PageChromeErasePadding() As Integer
            Get
                Return _pageChromeErasePadding
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                If value > 20 Then value = 20

                _pageChromeErasePadding = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls whether stubborn native vertical and bottom page-edge artefacts are erased after native painting.")>
        <DefaultValue(True)>
        Public Property ShowPageEdgeArtifactErase() As Boolean
            Get
                Return _showPageEdgeArtifactErase
            End Get
            Set(ByVal value As Boolean)
                _showPageEdgeArtifactErase = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the colour used to erase stubborn native vertical and bottom page-edge artefacts.")>
        Public Property PageEdgeArtifactBackColor() As Color
            Get
                Return _pageEdgeArtifactBackColor
            End Get
            Set(ByVal value As Color)
                _pageEdgeArtifactBackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the thickness of the stubborn native page-edge artefact erase pass.")>
        <DefaultValue(2)>
        Public Property PageEdgeArtifactThickness() As Integer
            Get
                Return _pageEdgeArtifactThickness
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                If value > 12 Then value = 12

                _pageEdgeArtifactThickness = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the offset used when erasing stubborn native page-edge artefacts.")>
        <DefaultValue(0)>
        Public Property PageEdgeArtifactOffset() As Integer
            Get
                Return _pageEdgeArtifactOffset
            End Get
            Set(ByVal value As Integer)
                If value < -8 Then value = -8
                If value > 8 Then value = 8

                _pageEdgeArtifactOffset = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls whether the remaining native outer TabControl border is erased before the custom outer border is painted.")>
        <DefaultValue(True)>
        Public Property ShowOuterNativeBorderErase() As Boolean
            Get
                Return _showOuterNativeBorderErase
            End Get
            Set(ByVal value As Boolean)
                _showOuterNativeBorderErase = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the background colour used to erase the remaining native outer TabControl border.")>
        Public Property OuterNativeBorderBackColor() As Color
            Get
                Return _outerNativeBorderBackColor
            End Get
            Set(ByVal value As Color)
                _outerNativeBorderBackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls how aggressively the remaining native outer TabControl border is erased.")>
        <DefaultValue(3)>
        Public Property OuterNativeBorderErasePadding() As Integer
            Get
                Return _outerNativeBorderErasePadding
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                If value > 20 Then value = 20

                _outerNativeBorderErasePadding = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the custom painted outer border around the tab control.")>
        <DefaultValue(GetType(CustomTabBorderStyle), "Accent")>
        Public Property CustomBorderStyle() As CustomTabBorderStyle
            Get
                Return _customBorderStyle
            End Get
            Set(ByVal value As CustomTabBorderStyle)
                _customBorderStyle = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the main background colour of the tab control surface.")>
        Public Property ControlBackColor() As Color
            Get
                Return _controlBackColor
            End Get
            Set(ByVal value As Color)
                _controlBackColor = value
                Me.BackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the native background colour behind the tab headers.")>
        Public Property TabStripBackColor() As Color
            Get
                Return _tabStripBackColor
            End Get
            Set(ByVal value As Color)
                _tabStripBackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the background colour applied to all TabPage pages.")>
        Public Property TabPageBackColor() As Color
            Get
                Return _tabPageBackColor
            End Get
            Set(ByVal value As Color)
                _tabPageBackColor = value
                ApplyTabPageStyle()
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the background colour of unselected tabs.")>
        Public Property NormalTabBackColor() As Color
            Get
                Return _normalTabBackColor
            End Get
            Set(ByVal value As Color)
                _normalTabBackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the background colour of the selected tab.")>
        Public Property SelectedTabBackColor() As Color
            Get
                Return _selectedTabBackColor
            End Get
            Set(ByVal value As Color)
                _selectedTabBackColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the text colour of unselected tabs.")>
        Public Property NormalTextColor() As Color
            Get
                Return _normalTextColor
            End Get
            Set(ByVal value As Color)
                _normalTextColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the text colour of the selected tab.")>
        Public Property SelectedTextColor() As Color
            Get
                Return _selectedTextColor
            End Get
            Set(ByVal value As Color)
                _selectedTextColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the divider colour between tab headers.")>
        Public Property DividerColor() As Color
            Get
                Return _dividerColor
            End Get
            Set(ByVal value As Color)
                _dividerColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the standard dark outer border colour.")>
        Public Property DarkBorderColor() As Color
            Get
                Return _darkBorderColor
            End Get
            Set(ByVal value As Color)
                _darkBorderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("DarkSaber")>
        <Description("Controls the accent colour used for the selected tab underline and accent border.")>
        Public Property AccentColor() As Color
            Get
                Return _accentColor
            End Get
            Set(ByVal value As Color)
                _accentColor = value
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
            Me.Padding = New Point(10, 3)
            Me.Font = New Font("Segoe UI", 8.25!, FontStyle.Bold)
            Me.BackColor = _controlBackColor

            ' -------------------------------------------------------------
            ' Flicker reduction.
            '
            ' AllPaintingInWmPaint:
            '   Reduces separate background erase passes.
            '
            ' OptimizedDoubleBuffer:
            '   Helps reduce flicker during resize and tab switching.
            '
            ' ResizeRedraw:
            '   Forces repaint when the control dimensions change.
            ' -------------------------------------------------------------
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                        ControlStyles.OptimizedDoubleBuffer Or
                        ControlStyles.ResizeRedraw, True)

            Me.UpdateStyles()
        End Sub

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()

            ' -------------------------------------------------------------
            ' Apply page styling when the control handle exists.
            ' This catches TabPages created by the WinForms designer.
            ' -------------------------------------------------------------
            ApplyTabPageStyle()
        End Sub

        Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
            MyBase.OnControlAdded(e)

            ' -------------------------------------------------------------
            ' Apply page styling to TabPages added at runtime.
            ' -------------------------------------------------------------
            Dim page As TabPage = TryCast(e.Control, TabPage)

            If page IsNot Nothing Then
                ApplySingleTabPageStyle(page)
            End If
        End Sub

        Private Sub ApplyTabPageStyle()
            ' -------------------------------------------------------------
            ' Force every existing page to use the custom page background.
            ' -------------------------------------------------------------
            For Each page As TabPage In Me.TabPages
                ApplySingleTabPageStyle(page)
            Next
        End Sub

        Private Sub ApplySingleTabPageStyle(ByVal page As TabPage)
            If page Is Nothing Then Return

            ' -------------------------------------------------------------
            ' UseVisualStyleBackColor must be False, otherwise Windows can
            ' repaint the page using the current OS visual style colour.
            ' -------------------------------------------------------------
            page.UseVisualStyleBackColor = False
            page.BackColor = Me.TabPageBackColor
            page.ForeColor = Me.SelectedTextColor
        End Sub

        Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
            ' -------------------------------------------------------------
            ' Paint the raw TabControl client area.
            ' This prevents white flashing during designer/runtime repaints.
            ' -------------------------------------------------------------
            Using b As New SolidBrush(Me.ControlBackColor)
                pevent.Graphics.FillRectangle(b, Me.ClientRectangle)
            End Using
        End Sub

        Private Sub PaintTabStripBackground(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Me.TabPages.Count = 0 Then Return

            ' -------------------------------------------------------------
            ' Paint only the exposed native tab strip area.
            '
            ' OwnerDrawFixed gives us each tab button through OnDrawItem,
            ' but the empty area behind/right of the tab buttons remains
            ' native and otherwise appears grey.
            ' -------------------------------------------------------------
            Dim stripRect As Rectangle

            If Me.Alignment = TabAlignment.Top Then
                stripRect = New Rectangle(0, 0, Me.Width, Me.DisplayRectangle.Top)
            Else
                ' ---------------------------------------------------------
                ' DarkSaber currently targets top-aligned tabs.
                ' This fallback avoids invalid painting for other alignments.
                ' ---------------------------------------------------------
                stripRect = New Rectangle(0, 0, Me.Width, Me.Height)
            End If

            If stripRect.Width <= 0 OrElse stripRect.Height <= 0 Then Return

            Using rgn As New Region(stripRect)

                For i As Integer = 0 To Me.TabPages.Count - 1
                    Dim tabRect As Rectangle = Me.GetTabRect(i)

                    ' -----------------------------------------------------
                    ' Inflate slightly to avoid one-pixel native grey seams.
                    ' -----------------------------------------------------
                    tabRect.Inflate(2, 2)
                    rgn.Exclude(tabRect)
                Next

                Using b As New SolidBrush(Me.TabStripBackColor)
                    g.FillRegion(b, rgn)
                End Using

            End Using
        End Sub

        Private Sub PaintPageChromeBackground(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Not Me.ShowPageChromeErase Then Return

            ' -------------------------------------------------------------
            ' Erases the remaining native page chrome fragments.
            '
            ' The earlier PageInsetBorder pass targets the DisplayRectangle
            ' edge. Some themes still leave fragments slightly outside that
            ' area, especially on the left and bottom edges. This method uses
            ' one clean rectangular scrub over the full page chrome area,
            ' then the optional page inset and outer border are redrawn after.
            '
            ' This is intentionally simpler and more predictable than chasing
            ' separate one-pixel native artefacts with multiple unrelated
            ' correction methods.
            ' -------------------------------------------------------------
            Dim r As Rectangle = Me.DisplayRectangle
            If r.Width <= 0 OrElse r.Height <= 0 Then Return

            Dim pad As Integer = Me.PageChromeErasePadding
            If pad < 1 Then pad = 1

            r.Inflate(pad, pad)

            If r.Left < Me.ClientRectangle.Left Then r.X = Me.ClientRectangle.Left
            If r.Top < Me.ClientRectangle.Top Then r.Y = Me.ClientRectangle.Top
            If r.Right > Me.ClientRectangle.Right Then r.Width = Me.ClientRectangle.Right - r.Left
            If r.Bottom > Me.ClientRectangle.Bottom Then r.Height = Me.ClientRectangle.Bottom - r.Top

            If r.Width <= 0 OrElse r.Height <= 0 Then Return

            Using b As New SolidBrush(Me.PageChromeBackColor)
                g.FillRectangle(b, r)
            End Using
        End Sub

        Private Sub PaintPageInsetBorder(ByVal g As Graphics)
            If g Is Nothing Then Return

            ' -------------------------------------------------------------
            ' DisplayRectangle is the native content/page frame area.
            '
            ' WinForms TabControl can leave more than one native artefact
            ' around this area:
            '   - The obvious inset frame line.
            '   - A secondary inner edge/seam just inside the page frame.
            '   - A left-side native vertical edge on some themes.
            '
            ' The safest approach is not to chase a single line with one
            ' DrawRectangle call. Instead, this method fills controlled bands
            ' around the DisplayRectangle. The erase size is exposed through
            ' PageInsetErasePadding so stubborn theme artefacts can be fully
            ' suppressed from the designer.
            ' -------------------------------------------------------------
            Dim pageRect As Rectangle = Me.DisplayRectangle

            If pageRect.Width <= 0 OrElse pageRect.Height <= 0 Then Return

            Dim pad As Integer = Me.PageInsetErasePadding
            If pad < 1 Then pad = 1

            ' -------------------------------------------------------------
            ' Clamp the erase rectangle to the client area.
            ' This keeps the correction safe during resize and design-time
            ' layout changes.
            ' -------------------------------------------------------------
            Dim eraseLeft As Integer = Math.Max(Me.ClientRectangle.Left, pageRect.Left - pad)
            Dim eraseTop As Integer = Math.Max(Me.ClientRectangle.Top, pageRect.Top - pad)
            Dim eraseRight As Integer = Math.Min(Me.ClientRectangle.Right, pageRect.Right + pad)
            Dim eraseBottom As Integer = Math.Min(Me.ClientRectangle.Bottom, pageRect.Bottom + pad)

            If eraseRight <= eraseLeft OrElse eraseBottom <= eraseTop Then Return

            Using b As New SolidBrush(Me.TabPageBackColor)

                ' ---------------------------------------------------------
                ' Top band: clears the native horizontal line above the page.
                ' ---------------------------------------------------------
                g.FillRectangle(b,
                                eraseLeft,
                                eraseTop,
                                eraseRight - eraseLeft,
                                Math.Max(1, pageRect.Top - eraseTop + pad))

                ' ---------------------------------------------------------
                ' Left band: clears the stubborn native vertical edge on the
                ' left side of the page frame.
                ' ---------------------------------------------------------
                g.FillRectangle(b,
                                eraseLeft,
                                eraseTop,
                                Math.Max(1, pageRect.Left - eraseLeft + pad),
                                eraseBottom - eraseTop)

                ' ---------------------------------------------------------
                ' Right band: clears the right native page edge.
                ' ---------------------------------------------------------
                g.FillRectangle(b,
                                Math.Max(eraseLeft, pageRect.Right - pad),
                                eraseTop,
                                Math.Max(1, eraseRight - (pageRect.Right - pad)),
                                eraseBottom - eraseTop)

                ' ---------------------------------------------------------
                ' Bottom band: clears the bottom native page edge.
                ' ---------------------------------------------------------
                g.FillRectangle(b,
                                eraseLeft,
                                Math.Max(eraseTop, pageRect.Bottom - pad),
                                eraseRight - eraseLeft,
                                Math.Max(1, eraseBottom - (pageRect.Bottom - pad)))

            End Using

            ' -------------------------------------------------------------
            ' Repaint controlled inset border only when requested.
            ' -------------------------------------------------------------
            If Not Me.ShowPageInsetBorder Then Return

            Using p As New Pen(Me.PageInsetBorderColor, CSng(Me.PageInsetBorderThickness))
                Dim borderRect As Rectangle = pageRect
                borderRect.X -= 1
                borderRect.Y -= 1
                borderRect.Width += 1
                borderRect.Height += 1

                g.DrawRectangle(p, borderRect)
            End Using
        End Sub

        Private Sub PaintTabNativeBorderBackground(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Me.TabPages.Count = 0 Then Return

            ' -------------------------------------------------------------
            ' OwnerDrawFixed paints the tab content, but Windows can still
            ' leave native tab frame/inset pixels around each tab header.
            '
            ' This pass erases those native pixels by painting a slightly
            ' larger rectangle behind each tab, then OnDrawItem paints the
            ' actual custom tab body on top.
            ' -------------------------------------------------------------
            Dim pad As Integer = Me.TabNativeBorderErasePadding
            If pad < 0 Then pad = 0

            Using b As New SolidBrush(Me.TabNativeBorderBackColor)
                For i As Integer = 0 To Me.TabPages.Count - 1
                    Dim tabRect As Rectangle = Me.GetTabRect(i)
                    tabRect.Inflate(pad, pad)
                    g.FillRectangle(b, tabRect)
                Next
            End Using
        End Sub

        Private Sub PaintTabNativeInsetBorder(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Not Me.ShowTabNativeInsetBorder Then Return
            If Me.TabPages.Count = 0 Then Return

            ' -------------------------------------------------------------
            ' Optional controlled replacement for the native tab inset.
            ' This is separate from ShowTabBorder, which controls the main
            ' custom tab body border drawn inside OnDrawItem.
            ' -------------------------------------------------------------
            Using p As New Pen(Me.TabNativeInsetBorderColor, CSng(Me.TabNativeInsetBorderThickness))
                For i As Integer = 0 To Me.TabPages.Count - 1
                    Dim tabRect As Rectangle = Me.GetTabRect(i)
                    tabRect.Inflate(1, 1)
                    tabRect.Width -= 1
                    tabRect.Height -= 1
                    g.DrawRectangle(p, tabRect)
                Next
            End Using
        End Sub

        Private Sub PaintTabChromeBackground(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Not Me.ShowTabChromeErase Then Return
            If Me.TabPages.Count = 0 Then Return

            ' -------------------------------------------------------------
            ' Erases the final native tab chrome frame.
            '
            ' In Normal, Buttons, and FlatButtons modes, Windows can still
            ' paint a native frame around the tab-row union. This is not the
            ' same thing as the tab strip background and not the same thing
            ' as the owner-drawn tab body border.
            '
            ' The solution is:
            '   1. Erase the entire union rectangle around all tabs.
            '   2. Redraw our owner-drawn tabs immediately afterwards.
            '
            ' That is why this method must always be followed by
            ' PaintAllTabHeaders().
            ' -------------------------------------------------------------
            Dim chromeRect As Rectangle = Me.GetTabRect(0)

            For i As Integer = 1 To Me.TabPages.Count - 1
                chromeRect = Rectangle.Union(chromeRect, Me.GetTabRect(i))
            Next

            Dim pad As Integer = Me.TabChromeErasePadding
            If pad < 0 Then pad = 0

            chromeRect.Inflate(pad, pad)

            If chromeRect.Left < Me.ClientRectangle.Left Then chromeRect.X = Me.ClientRectangle.Left
            If chromeRect.Top < Me.ClientRectangle.Top Then chromeRect.Y = Me.ClientRectangle.Top
            If chromeRect.Right > Me.ClientRectangle.Right Then chromeRect.Width = Me.ClientRectangle.Right - chromeRect.Left
            If chromeRect.Bottom > Me.ClientRectangle.Bottom Then chromeRect.Height = Me.ClientRectangle.Bottom - chromeRect.Top

            If chromeRect.Width <= 0 OrElse chromeRect.Height <= 0 Then Return

            Using b As New SolidBrush(Me.TabChromeBackColor)
                g.FillRectangle(b, chromeRect)
            End Using
        End Sub

        Private Function CreateTabPath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
            ' -------------------------------------------------------------
            ' Creates a tab body path.
            '
            ' Radius 0 preserves the classic square WinForms-style tab.
            ' A radius above 0 gives controlled bevel/rounded styling.
            ' -------------------------------------------------------------
            Dim path As New GraphicsPath()

            If radius <= 0 Then
                path.AddRectangle(rect)
                path.CloseFigure()
                Return path
            End If

            Dim d As Integer = radius * 2

            If d > rect.Width Then d = rect.Width
            If d > rect.Height Then d = rect.Height

            path.AddArc(rect.Left, rect.Top, d, d, 180, 90)
            path.AddArc(rect.Right - d, rect.Top, d, d, 270, 90)
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
            path.AddArc(rect.Left, rect.Bottom - d, d, d, 90, 90)
            path.CloseFigure()

            Return path
        End Function

        Private Function CreateTabFillBrush(ByVal rect As Rectangle, ByVal baseColor As Color) As Brush
            ' -------------------------------------------------------------
            ' Creates either a flat brush or a bevel/gradient brush.
            '
            ' Explicit Color variables are used here to avoid VB overload
            ' resolution issues with LinearGradientBrush.
            ' -------------------------------------------------------------
            If Me.TabBevelStrength <= 0 Then
                Return New SolidBrush(baseColor)
            End If

            Dim bevelAmount As Single = CSng(Me.TabBevelStrength) / 100.0!
            Dim lightColor As Color = ControlPaint.Light(baseColor, bevelAmount)
            Dim darkColor As Color = ControlPaint.Dark(baseColor, bevelAmount)

            Return New LinearGradientBrush(rect, lightColor, darkColor, Me.TabBevelAngle)
        End Function

        Private Sub PaintTabHeader(ByVal g As Graphics, ByVal index As Integer)
            If g Is Nothing Then Return
            If index < 0 OrElse index >= Me.TabPages.Count Then Return

            g.SmoothingMode = SmoothingMode.AntiAlias

            ' -------------------------------------------------------------
            ' Erase native tab frame/background around this tab before
            ' drawing the custom tab body. This tackles the stubborn native
            ' tab border artefact that behaves like the tab strip background.
            ' -------------------------------------------------------------
            Dim nativeRect As Rectangle = Me.GetTabRect(index)
            nativeRect.Inflate(Me.TabNativeBorderErasePadding, Me.TabNativeBorderErasePadding)

            Using nativeBack As New SolidBrush(Me.TabNativeBorderBackColor)
                g.FillRectangle(nativeBack, nativeRect)
            End Using

            Dim rect As Rectangle = Me.GetTabRect(index)
            Dim selected As Boolean = (index = Me.SelectedIndex)

            Dim tabBack As Color = If(selected, Me.SelectedTabBackColor, Me.NormalTabBackColor)
            Dim textColor As Color = If(selected, Me.SelectedTextColor, Me.NormalTextColor)
            Dim tabBorder As Color = If(selected, Me.SelectedTabBorderColor, Me.TabBorderColor)
            Dim buttonBorder As Color = If(selected, Me.SelectedTabButtonBorderColor, Me.TabButtonBorderColor)

            ' -------------------------------------------------------------
            ' Button-mode border layer.
            ' -------------------------------------------------------------
            If Me.ShowTabButtonBorder Then
                Dim buttonRect As Rectangle = rect

                If Me.TabButtonBorderInset <> 0 Then
                    buttonRect.Inflate(-Me.TabButtonBorderInset, -Me.TabButtonBorderInset)
                End If

                buttonRect.Width -= 1
                buttonRect.Height -= 1

                Using p As New Pen(buttonBorder, CSng(Me.TabButtonBorderThickness))
                    g.DrawRectangle(p, buttonRect)
                End Using
            End If

            ' -------------------------------------------------------------
            ' Shrink the custom tab shape slightly so the border is fully
            ' visible and does not clip into the native tab rectangle.
            ' -------------------------------------------------------------
            Dim drawRect As Rectangle = rect
            drawRect.Inflate(-1, -1)

            ' -------------------------------------------------------------
            ' Fill and border the tab body using the controlled custom path.
            ' -------------------------------------------------------------
            Using path As GraphicsPath = CreateTabPath(drawRect, Me.TabCornerRadius)

                Using b As Brush = CreateTabFillBrush(drawRect, tabBack)
                    g.FillPath(b, path)
                End Using

                If Me.ShowTabBorder Then
                    Using p As New Pen(tabBorder, CSng(Me.TabBorderThickness))
                        g.DrawPath(p, path)
                    End Using
                End If

            End Using

            ' -------------------------------------------------------------
            ' Optional divider line between tab headers.
            '
            ' This was the small vertical glitch visible on the right side
            ' of each tab. It is now fully controllable and disabled by
            ' default because the custom button/body borders already provide
            ' separation.
            ' -------------------------------------------------------------
            If Me.ShowTabDivider Then
                Dim dividerX As Integer = rect.Right + Me.TabDividerOffsetX

                Using p As New Pen(Me.DividerColor)
                    g.DrawLine(p,
                               dividerX,
                               rect.Top + Me.TabDividerInsetTop,
                               dividerX,
                               rect.Bottom - Me.TabDividerInsetBottom)
                End Using
            End If

            ' -------------------------------------------------------------
            ' Selected tab underline.
            ' -------------------------------------------------------------
            If selected Then
                Using p As New Pen(Me.AccentColor, 3.0!)
                    g.DrawLine(p,
                               rect.Left + 10,
                               rect.Bottom - 3,
                               rect.Right - 10,
                               rect.Bottom - 3)
                End Using
            End If

            ' -------------------------------------------------------------
            ' Draw tab text using TextRenderer for clean WinForms text.
            ' -------------------------------------------------------------
            TextRenderer.DrawText(g,
                                  Me.TabPages(index).Text,
                                  Me.Font,
                                  rect,
                                  textColor,
                                  TextFormatFlags.HorizontalCenter Or
                                  TextFormatFlags.VerticalCenter)
        End Sub

        Private Sub PaintAllTabHeaders(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Me.TabPages.Count = 0 Then Return

            ' -------------------------------------------------------------
            ' Redraws all owner-drawn tabs after native chrome erasure.
            ' This is the missing step needed when we erase the remaining
            ' native tab-row/button/flat-button border artefacts.
            ' -------------------------------------------------------------
            For i As Integer = 0 To Me.TabPages.Count - 1
                PaintTabHeader(g, i)
            Next
        End Sub

        Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
            PaintTabHeader(e.Graphics, e.Index)
        End Sub

        Private Sub PaintPageEdgeArtifactBackground(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Not Me.ShowPageEdgeArtifactErase Then Return

            ' -------------------------------------------------------------
            ' Final targeted scrub for the stubborn native vertical and
            ' bottom page-edge lines.
            '
            ' These artefacts can survive broader DisplayRectangle erasing
            ' because the native TabControl paints them just inside/outside
            ' the page chrome depending on Appearance and visual style.
            '
            ' This pass deliberately targets only:
            '   - The left vertical page edge.
            '   - The right vertical page edge.
            '   - The bottom horizontal page edge.
            '
            ' It does not touch the tab headers.
            ' -------------------------------------------------------------
            Dim r As Rectangle = Me.DisplayRectangle
            If r.Width <= 0 OrElse r.Height <= 0 Then Return

            Dim t As Integer = Me.PageEdgeArtifactThickness
            If t < 1 Then t = 1

            Dim o As Integer = Me.PageEdgeArtifactOffset

            Using b As New SolidBrush(Me.PageEdgeArtifactBackColor)

                ' Left vertical native artefact.
                g.FillRectangle(b,
                                r.Left + o,
                                r.Top,
                                t,
                                r.Height)

                ' Right vertical native artefact.
                g.FillRectangle(b,
                                r.Right - t - o,
                                r.Top,
                                t,
                                r.Height)

                ' Bottom horizontal native artefact.
                g.FillRectangle(b,
                                r.Left,
                                r.Bottom - t - o,
                                r.Width,
                                t)

            End Using
        End Sub

        Private Sub PaintOuterNativeBorderBackground(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Not Me.ShowOuterNativeBorderErase Then Return

            ' -------------------------------------------------------------
            ' Erases the final native TabControl outer-frame artefacts.
            '
            ' These appear as broken native border fragments, commonly on
            ' the left and bottom edges after the inner page frame and tab
            ' chrome have already been corrected.
            '
            ' The custom outer border is painted separately afterwards by
            ' PaintCustomBorder(), so this method only suppresses the native
            ' leftovers rather than defining the final visual border.
            ' -------------------------------------------------------------
            Dim pad As Integer = Me.OuterNativeBorderErasePadding
            If pad < 1 Then pad = 1

            Dim r As Rectangle = Me.ClientRectangle
            If r.Width <= 0 OrElse r.Height <= 0 Then Return

            Using b As New SolidBrush(Me.OuterNativeBorderBackColor)

                ' Top native edge.
                g.FillRectangle(b,
                                r.Left,
                                r.Top,
                                r.Width,
                                pad)

                ' Left native edge.
                g.FillRectangle(b,
                                r.Left,
                                r.Top,
                                pad,
                                r.Height)

                ' Right native edge.
                g.FillRectangle(b,
                                r.Right - pad,
                                r.Top,
                                pad,
                                r.Height)

                ' Bottom native edge.
                g.FillRectangle(b,
                                r.Left,
                                r.Bottom - pad,
                                r.Width,
                                pad)

            End Using
        End Sub

        Private Sub PaintCustomBorder(ByVal g As Graphics)
            If g Is Nothing Then Return
            If Me.CustomBorderStyle = CustomTabBorderStyle.None Then Return

            ' -------------------------------------------------------------
            ' Paint the custom outer border of the TabControl.
            ' This is separate from the optional inner page inset border.
            ' -------------------------------------------------------------
            Dim borderColor As Color = Me.DarkBorderColor

            If Me.CustomBorderStyle = CustomTabBorderStyle.Accent Then
                borderColor = Me.AccentColor
            End If

            Using p As New Pen(borderColor)
                Dim r As Rectangle = Me.ClientRectangle
                r.Width -= 1
                r.Height -= 1
                g.DrawRectangle(p, r)
            End Using
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)

            ' -------------------------------------------------------------
            ' Paint order matters:
            '   1. Tab strip correction.
            '   2. Native page inset erase / optional repaint.
            '   3. Optional controlled tab native inset overlay.
            '   4. Outer control border.
            '
            ' Important:
            '   Do NOT call PaintTabNativeBorderBackground here.
            '   That method erases the native tab border background and must
            '   only run inside OnDrawItem before each tab is redrawn.
            '   Calling it after native paint wipes the tabs themselves.
            ' -------------------------------------------------------------
            PaintTabStripBackground(e.Graphics)
            PaintTabChromeBackground(e.Graphics)
            PaintAllTabHeaders(e.Graphics)
            PaintPageChromeBackground(e.Graphics)
            PaintPageInsetBorder(e.Graphics)
            PaintPageEdgeArtifactBackground(e.Graphics)
            PaintTabNativeInsetBorder(e.Graphics)
            PaintOuterNativeBorderBackground(e.Graphics)
            PaintCustomBorder(e.Graphics)
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)

            ' -------------------------------------------------------------
            ' Let the native TabControl paint first.
            ' This keeps normal TabControl behaviour intact.
            ' -------------------------------------------------------------
            MyBase.WndProc(m)

            ' -------------------------------------------------------------
            ' Post-paint correction for native TabControl artefacts.
            '
            ' OwnerDrawFixed does not give us full ownership of:
            '   - The empty tab strip behind/right of tab buttons.
            '   - The native inset frame around DisplayRectangle.
            '
            ' Repainting after WM_PAINT removes those native grey/system
            ' artefacts while keeping the owner-drawn tab headers intact.
            '
            ' Important:
            '   Do NOT call PaintTabNativeBorderBackground here.
            '   It is a pre-tab erase pass and must only run inside OnDrawItem.
            ' -------------------------------------------------------------
            If m.Msg = WM_PAINT Then
                If Me.IsHandleCreated AndAlso Not Me.IsDisposed Then
                    Using g As Graphics = Graphics.FromHwnd(Me.Handle)
                        PaintTabStripBackground(g)
                        PaintTabChromeBackground(g)
                        PaintAllTabHeaders(g)
                        PaintPageChromeBackground(g)
                        PaintPageInsetBorder(g)
                        PaintPageEdgeArtifactBackground(g)
                        PaintTabNativeInsetBorder(g)
                        PaintOuterNativeBorderBackground(g)
                        PaintCustomBorder(g)
                    End Using
                End If
            End If

        End Sub

    End Class

End Namespace
