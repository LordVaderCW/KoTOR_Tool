Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmThemeEditor
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmThemeEditor.Designer.vb
        '
        ' Restored Theme Editor designer surface for the KoTOR Tool
        ' Restoration Project.
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Designer keeps fallback colours only for safe VS display.
        '   - Runtime behaviour remains in frmThemeEditor.vb.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderSeparator As Global.System.Windows.Forms.Label
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblFooterSeparator As Global.System.Windows.Forms.Label

        Friend WithEvents lblThemePicker As Global.System.Windows.Forms.Label
        Friend WithEvents cmbThemes As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnApplyTheme As Global.System.Windows.Forms.Button
        Friend WithEvents btnReload As Global.System.Windows.Forms.Button
        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnSaveAs As Global.System.Windows.Forms.Button
        Friend WithEvents btnReset As Global.System.Windows.Forms.Button

        Friend WithEvents splitMain As Global.System.Windows.Forms.SplitContainer
        Friend WithEvents grpTheme As Global.System.Windows.Forms.GroupBox
        Friend WithEvents lblName As Global.System.Windows.Forms.Label
        Friend WithEvents lblAuthor As Global.System.Windows.Forms.Label
        Friend WithEvents lblVersion As Global.System.Windows.Forms.Label
        Friend WithEvents lblDescription As Global.System.Windows.Forms.Label
        Friend WithEvents tbName As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbAuthor As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbVersion As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbDescription As Global.System.Windows.Forms.TextBox

        Friend WithEvents grpColors As Global.System.Windows.Forms.GroupBox
        Friend WithEvents lbColors As Global.System.Windows.Forms.ListBox
        Friend WithEvents pnlColorEditor As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlSwatch As Global.System.Windows.Forms.Panel
        Friend WithEvents lblAlpha As Global.System.Windows.Forms.Label
        Friend WithEvents lblRed As Global.System.Windows.Forms.Label
        Friend WithEvents lblGreen As Global.System.Windows.Forms.Label
        Friend WithEvents lblBlue As Global.System.Windows.Forms.Label
        Friend WithEvents nudAlpha As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRed As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudGreen As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudBlue As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents btnPickColor As Global.System.Windows.Forms.Button

        Friend WithEvents grpFonts As Global.System.Windows.Forms.GroupBox
        Friend WithEvents lblFontRole As Global.System.Windows.Forms.Label
        Friend WithEvents lblFontFace As Global.System.Windows.Forms.Label
        Friend WithEvents lblFontSize As Global.System.Windows.Forms.Label
        Friend WithEvents cmbFontRole As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbFontName As Global.System.Windows.Forms.ComboBox
        Friend WithEvents nudFontSize As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents chkbBold As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbItalic As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUnderline As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbStrikeout As Global.System.Windows.Forms.CheckBox

        Friend WithEvents pnlPreviewRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlPreviewHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlPreviewBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlPreviewFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblPreviewTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblPreviewSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblPreviewHeaderSeparator As Global.System.Windows.Forms.Label
        Friend WithEvents lblPreviewBody As Global.System.Windows.Forms.Label
        Friend WithEvents lblPreviewMuted As Global.System.Windows.Forms.Label
        Friend WithEvents progressPreview As Global.kotor_tool.CustomProgressBar
        Friend WithEvents btnPreview As Global.System.Windows.Forms.Button
        Friend WithEvents txtPreview As Global.System.Windows.Forms.TextBox
        Friend WithEvents tabPreview As Global.kotor_tool.CustomTabControl
        Friend WithEvents tabPreviewOne As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabPreviewTwo As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabPreviewThree As Global.System.Windows.Forms.TabPage
        Friend WithEvents grpPreview As Global.System.Windows.Forms.GroupBox
        Friend WithEvents chkPreview As Global.System.Windows.Forms.CheckBox
        Friend WithEvents rbPreviewInternal As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbPreviewExternal As Global.System.Windows.Forms.RadioButton
        Friend WithEvents tbPreviewPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnPreviewBrowse As Global.System.Windows.Forms.Button
        Friend WithEvents lblPreviewFooterSeparator As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.splitMain = New System.Windows.Forms.SplitContainer()
            Me.grpColors = New System.Windows.Forms.GroupBox()
            Me.lbColors = New System.Windows.Forms.ListBox()
            Me.pnlColorEditor = New System.Windows.Forms.Panel()
            Me.btnPickColor = New System.Windows.Forms.Button()
            Me.nudBlue = New System.Windows.Forms.NumericUpDown()
            Me.nudGreen = New System.Windows.Forms.NumericUpDown()
            Me.nudRed = New System.Windows.Forms.NumericUpDown()
            Me.nudAlpha = New System.Windows.Forms.NumericUpDown()
            Me.lblBlue = New System.Windows.Forms.Label()
            Me.lblGreen = New System.Windows.Forms.Label()
            Me.lblRed = New System.Windows.Forms.Label()
            Me.lblAlpha = New System.Windows.Forms.Label()
            Me.pnlSwatch = New System.Windows.Forms.Panel()
            Me.grpFonts = New System.Windows.Forms.GroupBox()
            Me.chkbStrikeout = New System.Windows.Forms.CheckBox()
            Me.chkbUnderline = New System.Windows.Forms.CheckBox()
            Me.chkbItalic = New System.Windows.Forms.CheckBox()
            Me.chkbBold = New System.Windows.Forms.CheckBox()
            Me.nudFontSize = New System.Windows.Forms.NumericUpDown()
            Me.cmbFontName = New System.Windows.Forms.ComboBox()
            Me.cmbFontRole = New System.Windows.Forms.ComboBox()
            Me.lblFontSize = New System.Windows.Forms.Label()
            Me.lblFontFace = New System.Windows.Forms.Label()
            Me.lblFontRole = New System.Windows.Forms.Label()
            Me.grpTheme = New System.Windows.Forms.GroupBox()
            Me.tbDescription = New System.Windows.Forms.TextBox()
            Me.tbVersion = New System.Windows.Forms.TextBox()
            Me.tbAuthor = New System.Windows.Forms.TextBox()
            Me.tbName = New System.Windows.Forms.TextBox()
            Me.lblDescription = New System.Windows.Forms.Label()
            Me.lblVersion = New System.Windows.Forms.Label()
            Me.lblAuthor = New System.Windows.Forms.Label()
            Me.lblName = New System.Windows.Forms.Label()
            Me.pnlPreviewRoot = New System.Windows.Forms.Panel()
            Me.pnlPreviewBody = New System.Windows.Forms.Panel()
            Me.tabPreview = New kotor_tool.CustomTabControl()
            Me.tabPreviewOne = New System.Windows.Forms.TabPage()
            Me.grpPreview = New System.Windows.Forms.GroupBox()
            Me.btnPreviewBrowse = New System.Windows.Forms.Button()
            Me.tbPreviewPath = New System.Windows.Forms.TextBox()
            Me.rbPreviewExternal = New System.Windows.Forms.RadioButton()
            Me.rbPreviewInternal = New System.Windows.Forms.RadioButton()
            Me.chkPreview = New System.Windows.Forms.CheckBox()
            Me.tabPreviewTwo = New System.Windows.Forms.TabPage()
            Me.tabPreviewThree = New System.Windows.Forms.TabPage()
            Me.txtPreview = New System.Windows.Forms.TextBox()
            Me.progressPreview = New kotor_tool.CustomProgressBar()
            Me.lblPreviewMuted = New System.Windows.Forms.Label()
            Me.lblPreviewBody = New System.Windows.Forms.Label()
            Me.pnlPreviewFooter = New System.Windows.Forms.Panel()
            Me.btnPreview = New System.Windows.Forms.Button()
            Me.lblPreviewFooterSeparator = New System.Windows.Forms.Label()
            Me.pnlPreviewHeader = New System.Windows.Forms.Panel()
            Me.lblPreviewSubtitle = New System.Windows.Forms.Label()
            Me.lblPreviewHeaderSeparator = New System.Windows.Forms.Label()
            Me.lblPreviewTitle = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnSaveAs = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnApplyTheme = New System.Windows.Forms.Button()
            Me.btnReload = New System.Windows.Forms.Button()
            Me.cmbThemes = New System.Windows.Forms.ComboBox()
            Me.lblThemePicker = New System.Windows.Forms.Label()
            Me.lblFooterSeparator = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitMain.Panel1.SuspendLayout()
            Me.splitMain.Panel2.SuspendLayout()
            Me.splitMain.SuspendLayout()
            Me.grpColors.SuspendLayout()
            Me.pnlColorEditor.SuspendLayout()
            CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRed, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpFonts.SuspendLayout()
            CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpTheme.SuspendLayout()
            Me.pnlPreviewRoot.SuspendLayout()
            Me.pnlPreviewBody.SuspendLayout()
            Me.tabPreview.SuspendLayout()
            Me.tabPreviewOne.SuspendLayout()
            Me.grpPreview.SuspendLayout()
            Me.pnlPreviewFooter.SuspendLayout()
            Me.pnlPreviewHeader.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(984, 715)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.splitMain)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 86)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(16)
            Me.pnlBody.Size = New System.Drawing.Size(984, 564)
            Me.pnlBody.TabIndex = 1
            '
            'splitMain
            '
            Me.splitMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
            Me.splitMain.Location = New System.Drawing.Point(16, 16)
            Me.splitMain.Name = "splitMain"
            '
            'splitMain.Panel1
            '
            Me.splitMain.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.splitMain.Panel1.Controls.Add(Me.grpColors)
            Me.splitMain.Panel1.Controls.Add(Me.grpFonts)
            Me.splitMain.Panel1.Controls.Add(Me.grpTheme)
            '
            'splitMain.Panel2
            '
            Me.splitMain.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.splitMain.Panel2.Controls.Add(Me.pnlPreviewRoot)
            Me.splitMain.Size = New System.Drawing.Size(952, 532)
            Me.splitMain.SplitterDistance = 366
            Me.splitMain.TabIndex = 0
            '
            'grpColors
            '
            Me.grpColors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpColors.Controls.Add(Me.lbColors)
            Me.grpColors.Controls.Add(Me.pnlColorEditor)
            Me.grpColors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpColors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.grpColors.Location = New System.Drawing.Point(0, 148)
            Me.grpColors.Name = "grpColors"
            Me.grpColors.Padding = New System.Windows.Forms.Padding(10, 18, 10, 10)
            Me.grpColors.Size = New System.Drawing.Size(360, 228)
            Me.grpColors.TabIndex = 1
            Me.grpColors.TabStop = False
            Me.grpColors.Text = "Colors"
            '
            'lbColors
            '
            Me.lbColors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbColors.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.lbColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbColors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbColors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbColors.FormattingEnabled = True
            Me.lbColors.Location = New System.Drawing.Point(13, 25)
            Me.lbColors.Name = "lbColors"
            Me.lbColors.Size = New System.Drawing.Size(185, 184)
            Me.lbColors.TabIndex = 0
            '
            'pnlColorEditor
            '
            Me.pnlColorEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlColorEditor.Controls.Add(Me.btnPickColor)
            Me.pnlColorEditor.Controls.Add(Me.nudBlue)
            Me.pnlColorEditor.Controls.Add(Me.nudGreen)
            Me.pnlColorEditor.Controls.Add(Me.nudRed)
            Me.pnlColorEditor.Controls.Add(Me.nudAlpha)
            Me.pnlColorEditor.Controls.Add(Me.lblBlue)
            Me.pnlColorEditor.Controls.Add(Me.lblGreen)
            Me.pnlColorEditor.Controls.Add(Me.lblRed)
            Me.pnlColorEditor.Controls.Add(Me.lblAlpha)
            Me.pnlColorEditor.Controls.Add(Me.pnlSwatch)
            Me.pnlColorEditor.Location = New System.Drawing.Point(207, 25)
            Me.pnlColorEditor.Name = "pnlColorEditor"
            Me.pnlColorEditor.Size = New System.Drawing.Size(140, 183)
            Me.pnlColorEditor.TabIndex = 1
            '
            'btnPickColor
            '
            Me.btnPickColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPickColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPickColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPickColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPickColor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPickColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPickColor.Location = New System.Drawing.Point(9, 146)
            Me.btnPickColor.Name = "btnPickColor"
            Me.btnPickColor.Size = New System.Drawing.Size(123, 25)
            Me.btnPickColor.TabIndex = 7
            Me.btnPickColor.Text = "Pick Color"
            Me.btnPickColor.UseVisualStyleBackColor = False
            '
            'nudBlue
            '
            Me.nudBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.nudBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudBlue.Location = New System.Drawing.Point(42, 119)
            Me.nudBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudBlue.Name = "nudBlue"
            Me.nudBlue.Size = New System.Drawing.Size(90, 22)
            Me.nudBlue.TabIndex = 6
            '
            'nudGreen
            '
            Me.nudGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.nudGreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudGreen.Location = New System.Drawing.Point(42, 93)
            Me.nudGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudGreen.Name = "nudGreen"
            Me.nudGreen.Size = New System.Drawing.Size(90, 22)
            Me.nudGreen.TabIndex = 5
            '
            'nudRed
            '
            Me.nudRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.nudRed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudRed.Location = New System.Drawing.Point(42, 67)
            Me.nudRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudRed.Name = "nudRed"
            Me.nudRed.Size = New System.Drawing.Size(90, 22)
            Me.nudRed.TabIndex = 4
            '
            'nudAlpha
            '
            Me.nudAlpha.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.nudAlpha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudAlpha.Location = New System.Drawing.Point(42, 41)
            Me.nudAlpha.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudAlpha.Name = "nudAlpha"
            Me.nudAlpha.Size = New System.Drawing.Size(90, 22)
            Me.nudAlpha.TabIndex = 3
            Me.nudAlpha.Value = New Decimal(New Integer() {255, 0, 0, 0})
            '
            'lblBlue
            '
            Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblBlue.Location = New System.Drawing.Point(9, 119)
            Me.lblBlue.Name = "lblBlue"
            Me.lblBlue.Size = New System.Drawing.Size(28, 22)
            Me.lblBlue.TabIndex = 3
            Me.lblBlue.Text = "B"
            Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblGreen
            '
            Me.lblGreen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblGreen.Location = New System.Drawing.Point(9, 93)
            Me.lblGreen.Name = "lblGreen"
            Me.lblGreen.Size = New System.Drawing.Size(28, 22)
            Me.lblGreen.TabIndex = 2
            Me.lblGreen.Text = "G"
            Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblRed
            '
            Me.lblRed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblRed.Location = New System.Drawing.Point(9, 67)
            Me.lblRed.Name = "lblRed"
            Me.lblRed.Size = New System.Drawing.Size(28, 22)
            Me.lblRed.TabIndex = 1
            Me.lblRed.Text = "R"
            Me.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblAlpha
            '
            Me.lblAlpha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAlpha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblAlpha.Location = New System.Drawing.Point(9, 41)
            Me.lblAlpha.Name = "lblAlpha"
            Me.lblAlpha.Size = New System.Drawing.Size(28, 22)
            Me.lblAlpha.TabIndex = 1
            Me.lblAlpha.Text = "A"
            Me.lblAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlSwatch
            '
            Me.pnlSwatch.BackColor = System.Drawing.Color.Black
            Me.pnlSwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlSwatch.Location = New System.Drawing.Point(9, 10)
            Me.pnlSwatch.Name = "pnlSwatch"
            Me.pnlSwatch.Size = New System.Drawing.Size(123, 25)
            Me.pnlSwatch.TabIndex = 0
            '
            'grpFonts
            '
            Me.grpFonts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpFonts.Controls.Add(Me.chkbStrikeout)
            Me.grpFonts.Controls.Add(Me.chkbUnderline)
            Me.grpFonts.Controls.Add(Me.chkbItalic)
            Me.grpFonts.Controls.Add(Me.chkbBold)
            Me.grpFonts.Controls.Add(Me.nudFontSize)
            Me.grpFonts.Controls.Add(Me.cmbFontName)
            Me.grpFonts.Controls.Add(Me.cmbFontRole)
            Me.grpFonts.Controls.Add(Me.lblFontSize)
            Me.grpFonts.Controls.Add(Me.lblFontFace)
            Me.grpFonts.Controls.Add(Me.lblFontRole)
            Me.grpFonts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpFonts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.grpFonts.Location = New System.Drawing.Point(0, 385)
            Me.grpFonts.Name = "grpFonts"
            Me.grpFonts.Padding = New System.Windows.Forms.Padding(10)
            Me.grpFonts.Size = New System.Drawing.Size(360, 147)
            Me.grpFonts.TabIndex = 2
            Me.grpFonts.TabStop = False
            Me.grpFonts.Text = "Fonts"
            '
            'chkbStrikeout
            '
            Me.chkbStrikeout.AutoSize = True
            Me.chkbStrikeout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbStrikeout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbStrikeout.Location = New System.Drawing.Point(260, 111)
            Me.chkbStrikeout.Name = "chkbStrikeout"
            Me.chkbStrikeout.Size = New System.Drawing.Size(32, 17)
            Me.chkbStrikeout.TabIndex = 9
            Me.chkbStrikeout.Text = "S"
            Me.chkbStrikeout.UseVisualStyleBackColor = True
            '
            'chkbUnderline
            '
            Me.chkbUnderline.AutoSize = True
            Me.chkbUnderline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUnderline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbUnderline.Location = New System.Drawing.Point(197, 111)
            Me.chkbUnderline.Name = "chkbUnderline"
            Me.chkbUnderline.Size = New System.Drawing.Size(34, 17)
            Me.chkbUnderline.TabIndex = 8
            Me.chkbUnderline.Text = "U"
            Me.chkbUnderline.UseVisualStyleBackColor = True
            '
            'chkbItalic
            '
            Me.chkbItalic.AutoSize = True
            Me.chkbItalic.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbItalic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbItalic.Location = New System.Drawing.Point(134, 111)
            Me.chkbItalic.Name = "chkbItalic"
            Me.chkbItalic.Size = New System.Drawing.Size(29, 17)
            Me.chkbItalic.TabIndex = 7
            Me.chkbItalic.Text = "I"
            Me.chkbItalic.UseVisualStyleBackColor = True
            '
            'chkbBold
            '
            Me.chkbBold.AutoSize = True
            Me.chkbBold.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbBold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbBold.Location = New System.Drawing.Point(71, 111)
            Me.chkbBold.Name = "chkbBold"
            Me.chkbBold.Size = New System.Drawing.Size(32, 17)
            Me.chkbBold.TabIndex = 6
            Me.chkbBold.Text = "B"
            Me.chkbBold.UseVisualStyleBackColor = True
            '
            'nudFontSize
            '
            Me.nudFontSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.nudFontSize.DecimalPlaces = 2
            Me.nudFontSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudFontSize.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
            Me.nudFontSize.Location = New System.Drawing.Point(71, 82)
            Me.nudFontSize.Maximum = New Decimal(New Integer() {96, 0, 0, 0})
            Me.nudFontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
            Me.nudFontSize.Name = "nudFontSize"
            Me.nudFontSize.Size = New System.Drawing.Size(80, 22)
            Me.nudFontSize.TabIndex = 5
            Me.nudFontSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
            '
            'cmbFontName
            '
            Me.cmbFontName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbFontName.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.cmbFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFontName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbFontName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbFontName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbFontName.FormattingEnabled = True
            Me.cmbFontName.Location = New System.Drawing.Point(71, 53)
            Me.cmbFontName.Name = "cmbFontName"
            Me.cmbFontName.Size = New System.Drawing.Size(276, 21)
            Me.cmbFontName.TabIndex = 4
            '
            'cmbFontRole
            '
            Me.cmbFontRole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbFontRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.cmbFontRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFontRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbFontRole.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbFontRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbFontRole.FormattingEnabled = True
            Me.cmbFontRole.Items.AddRange(New Object() {"Title", "Body", "Mono", "Logo"})
            Me.cmbFontRole.Location = New System.Drawing.Point(71, 24)
            Me.cmbFontRole.Name = "cmbFontRole"
            Me.cmbFontRole.Size = New System.Drawing.Size(276, 21)
            Me.cmbFontRole.TabIndex = 3
            '
            'lblFontSize
            '
            Me.lblFontSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFontSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblFontSize.Location = New System.Drawing.Point(13, 82)
            Me.lblFontSize.Name = "lblFontSize"
            Me.lblFontSize.Size = New System.Drawing.Size(52, 21)
            Me.lblFontSize.TabIndex = 2
            Me.lblFontSize.Text = "Size"
            Me.lblFontSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFontFace
            '
            Me.lblFontFace.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFontFace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblFontFace.Location = New System.Drawing.Point(13, 53)
            Me.lblFontFace.Name = "lblFontFace"
            Me.lblFontFace.Size = New System.Drawing.Size(52, 21)
            Me.lblFontFace.TabIndex = 1
            Me.lblFontFace.Text = "Face"
            Me.lblFontFace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFontRole
            '
            Me.lblFontRole.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFontRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblFontRole.Location = New System.Drawing.Point(13, 24)
            Me.lblFontRole.Name = "lblFontRole"
            Me.lblFontRole.Size = New System.Drawing.Size(52, 21)
            Me.lblFontRole.TabIndex = 0
            Me.lblFontRole.Text = "Role"
            Me.lblFontRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'grpTheme
            '
            Me.grpTheme.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpTheme.Controls.Add(Me.tbDescription)
            Me.grpTheme.Controls.Add(Me.tbVersion)
            Me.grpTheme.Controls.Add(Me.tbAuthor)
            Me.grpTheme.Controls.Add(Me.tbName)
            Me.grpTheme.Controls.Add(Me.lblDescription)
            Me.grpTheme.Controls.Add(Me.lblVersion)
            Me.grpTheme.Controls.Add(Me.lblAuthor)
            Me.grpTheme.Controls.Add(Me.lblName)
            Me.grpTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpTheme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.grpTheme.Location = New System.Drawing.Point(0, 0)
            Me.grpTheme.Name = "grpTheme"
            Me.grpTheme.Padding = New System.Windows.Forms.Padding(10)
            Me.grpTheme.Size = New System.Drawing.Size(360, 139)
            Me.grpTheme.TabIndex = 0
            Me.grpTheme.TabStop = False
            Me.grpTheme.Text = "Theme"
            '
            'tbDescription
            '
            Me.tbDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDescription.Location = New System.Drawing.Point(91, 101)
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Size = New System.Drawing.Size(256, 22)
            Me.tbDescription.TabIndex = 7
            '
            'tbVersion
            '
            Me.tbVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbVersion.Location = New System.Drawing.Point(91, 73)
            Me.tbVersion.Name = "tbVersion"
            Me.tbVersion.Size = New System.Drawing.Size(256, 22)
            Me.tbVersion.TabIndex = 6
            '
            'tbAuthor
            '
            Me.tbAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbAuthor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbAuthor.Location = New System.Drawing.Point(91, 45)
            Me.tbAuthor.Name = "tbAuthor"
            Me.tbAuthor.Size = New System.Drawing.Size(256, 22)
            Me.tbAuthor.TabIndex = 5
            '
            'tbName
            '
            Me.tbName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbName.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbName.Location = New System.Drawing.Point(91, 17)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New System.Drawing.Size(256, 22)
            Me.tbName.TabIndex = 4
            '
            'lblDescription
            '
            Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblDescription.Location = New System.Drawing.Point(13, 101)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(72, 22)
            Me.lblDescription.TabIndex = 3
            Me.lblDescription.Text = "Description"
            Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblVersion
            '
            Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblVersion.Location = New System.Drawing.Point(13, 73)
            Me.lblVersion.Name = "lblVersion"
            Me.lblVersion.Size = New System.Drawing.Size(72, 22)
            Me.lblVersion.TabIndex = 2
            Me.lblVersion.Text = "Version"
            Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblAuthor
            '
            Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblAuthor.Location = New System.Drawing.Point(13, 45)
            Me.lblAuthor.Name = "lblAuthor"
            Me.lblAuthor.Size = New System.Drawing.Size(72, 22)
            Me.lblAuthor.TabIndex = 1
            Me.lblAuthor.Text = "Author"
            Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblName
            '
            Me.lblName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblName.Location = New System.Drawing.Point(13, 17)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(72, 22)
            Me.lblName.TabIndex = 0
            Me.lblName.Text = "Name"
            Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPreviewRoot
            '
            Me.pnlPreviewRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlPreviewRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlPreviewRoot.Controls.Add(Me.pnlPreviewBody)
            Me.pnlPreviewRoot.Controls.Add(Me.pnlPreviewFooter)
            Me.pnlPreviewRoot.Controls.Add(Me.pnlPreviewHeader)
            Me.pnlPreviewRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlPreviewRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlPreviewRoot.Name = "pnlPreviewRoot"
            Me.pnlPreviewRoot.Padding = New System.Windows.Forms.Padding(14)
            Me.pnlPreviewRoot.Size = New System.Drawing.Size(582, 532)
            Me.pnlPreviewRoot.TabIndex = 0
            '
            'pnlPreviewBody
            '
            Me.pnlPreviewBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlPreviewBody.Controls.Add(Me.tabPreview)
            Me.pnlPreviewBody.Controls.Add(Me.txtPreview)
            Me.pnlPreviewBody.Controls.Add(Me.progressPreview)
            Me.pnlPreviewBody.Controls.Add(Me.lblPreviewMuted)
            Me.pnlPreviewBody.Controls.Add(Me.lblPreviewBody)
            Me.pnlPreviewBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlPreviewBody.Location = New System.Drawing.Point(14, 110)
            Me.pnlPreviewBody.Name = "pnlPreviewBody"
            Me.pnlPreviewBody.Padding = New System.Windows.Forms.Padding(16)
            Me.pnlPreviewBody.Size = New System.Drawing.Size(552, 352)
            Me.pnlPreviewBody.TabIndex = 1
            '
            'tabPreview
            '
            Me.tabPreview.AccentColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.tabPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabPreview.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreview.Controls.Add(Me.tabPreviewOne)
            Me.tabPreview.Controls.Add(Me.tabPreviewTwo)
            Me.tabPreview.Controls.Add(Me.tabPreviewThree)
            Me.tabPreview.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tabPreview.DividerColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tabPreview.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
            Me.tabPreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabPreview.ItemSize = New System.Drawing.Size(90, 31)
            Me.tabPreview.Location = New System.Drawing.Point(19, 164)
            Me.tabPreview.Multiline = True
            Me.tabPreview.Name = "tabPreview"
            Me.tabPreview.NormalTabBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tabPreview.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.tabPreview.OuterNativeBorderBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.tabPreview.Padding = New System.Drawing.Point(10, 3)
            Me.tabPreview.PageChromeBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreview.PageEdgeArtifactBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreview.PageInsetBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tabPreview.SelectedIndex = 0
            Me.tabPreview.SelectedTabBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreview.SelectedTabBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.tabPreview.SelectedTabButtonBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.tabPreview.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabPreview.Size = New System.Drawing.Size(514, 170)
            Me.tabPreview.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.tabPreview.TabBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(115, Byte), Integer))
            Me.tabPreview.TabButtonBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(115, Byte), Integer))
            Me.tabPreview.TabChromeBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.tabPreview.TabIndex = 3
            Me.tabPreview.TabNativeBorderBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreview.TabNativeInsetBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tabPreview.TabPageBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreview.TabStripBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            '
            'tabPreviewOne
            '
            Me.tabPreviewOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreviewOne.Controls.Add(Me.grpPreview)
            Me.tabPreviewOne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabPreviewOne.Location = New System.Drawing.Point(4, 35)
            Me.tabPreviewOne.Name = "tabPreviewOne"
            Me.tabPreviewOne.Padding = New System.Windows.Forms.Padding(12)
            Me.tabPreviewOne.Size = New System.Drawing.Size(506, 131)
            Me.tabPreviewOne.TabIndex = 0
            Me.tabPreviewOne.Text = "Project Manager"
            '
            'grpPreview
            '
            Me.grpPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpPreview.Controls.Add(Me.btnPreviewBrowse)
            Me.grpPreview.Controls.Add(Me.tbPreviewPath)
            Me.grpPreview.Controls.Add(Me.rbPreviewExternal)
            Me.grpPreview.Controls.Add(Me.rbPreviewInternal)
            Me.grpPreview.Controls.Add(Me.chkPreview)
            Me.grpPreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.grpPreview.Location = New System.Drawing.Point(18, 16)
            Me.grpPreview.Name = "grpPreview"
            Me.grpPreview.Size = New System.Drawing.Size(468, 88)
            Me.grpPreview.TabIndex = 0
            Me.grpPreview.TabStop = False
            Me.grpPreview.Text = "Fake Border Group"
            '
            'btnPreviewBrowse
            '
            Me.btnPreviewBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnPreviewBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPreviewBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPreviewBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPreviewBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPreviewBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPreviewBrowse.Location = New System.Drawing.Point(430, 50)
            Me.btnPreviewBrowse.Name = "btnPreviewBrowse"
            Me.btnPreviewBrowse.Size = New System.Drawing.Size(26, 22)
            Me.btnPreviewBrowse.TabIndex = 4
            Me.btnPreviewBrowse.Text = "..."
            Me.btnPreviewBrowse.UseVisualStyleBackColor = False
            '
            'tbPreviewPath
            '
            Me.tbPreviewPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbPreviewPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbPreviewPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbPreviewPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbPreviewPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbPreviewPath.Location = New System.Drawing.Point(122, 50)
            Me.tbPreviewPath.Name = "tbPreviewPath"
            Me.tbPreviewPath.Size = New System.Drawing.Size(302, 22)
            Me.tbPreviewPath.TabIndex = 3
            '
            'rbPreviewExternal
            '
            Me.rbPreviewExternal.BackColor = System.Drawing.Color.Transparent
            Me.rbPreviewExternal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbPreviewExternal.Location = New System.Drawing.Point(22, 50)
            Me.rbPreviewExternal.Name = "rbPreviewExternal"
            Me.rbPreviewExternal.Size = New System.Drawing.Size(90, 22)
            Me.rbPreviewExternal.TabIndex = 2
            Me.rbPreviewExternal.Text = "External"
            Me.rbPreviewExternal.UseVisualStyleBackColor = False
            '
            'rbPreviewInternal
            '
            Me.rbPreviewInternal.BackColor = System.Drawing.Color.Transparent
            Me.rbPreviewInternal.Checked = True
            Me.rbPreviewInternal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbPreviewInternal.Location = New System.Drawing.Point(22, 22)
            Me.rbPreviewInternal.Name = "rbPreviewInternal"
            Me.rbPreviewInternal.Size = New System.Drawing.Size(90, 22)
            Me.rbPreviewInternal.TabIndex = 1
            Me.rbPreviewInternal.TabStop = True
            Me.rbPreviewInternal.Text = "Internal"
            Me.rbPreviewInternal.UseVisualStyleBackColor = False
            '
            'chkPreview
            '
            Me.chkPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chkPreview.BackColor = System.Drawing.Color.Transparent
            Me.chkPreview.Checked = True
            Me.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkPreview.Location = New System.Drawing.Point(276, 22)
            Me.chkPreview.Name = "chkPreview"
            Me.chkPreview.Size = New System.Drawing.Size(180, 22)
            Me.chkPreview.TabIndex = 0
            Me.chkPreview.Text = "Preview checkbox"
            Me.chkPreview.UseVisualStyleBackColor = False
            '
            'tabPreviewTwo
            '
            Me.tabPreviewTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreviewTwo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabPreviewTwo.Location = New System.Drawing.Point(4, 35)
            Me.tabPreviewTwo.Name = "tabPreviewTwo"
            Me.tabPreviewTwo.Padding = New System.Windows.Forms.Padding(12)
            Me.tabPreviewTwo.Size = New System.Drawing.Size(506, 93)
            Me.tabPreviewTwo.TabIndex = 1
            Me.tabPreviewTwo.Text = "Other"
            '
            'tabPreviewThree
            '
            Me.tabPreviewThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabPreviewThree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabPreviewThree.Location = New System.Drawing.Point(4, 35)
            Me.tabPreviewThree.Name = "tabPreviewThree"
            Me.tabPreviewThree.Padding = New System.Windows.Forms.Padding(12)
            Me.tabPreviewThree.Size = New System.Drawing.Size(506, 93)
            Me.tabPreviewThree.TabIndex = 2
            Me.tabPreviewThree.Text = "Treeview"
            '
            'txtPreview
            '
            Me.txtPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPreview.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.txtPreview.Location = New System.Drawing.Point(19, 98)
            Me.txtPreview.Name = "txtPreview"
            Me.txtPreview.Size = New System.Drawing.Size(514, 20)
            Me.txtPreview.TabIndex = 2
            Me.txtPreview.Text = "Input preview"
            '
            'progressPreview
            '
            Me.progressPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.progressPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.progressPreview.BorderDarkColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
            Me.progressPreview.BorderGoldColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.progressPreview.BottomGlowColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.progressPreview.EdgeLightColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(150, Byte), Integer))
            Me.progressPreview.FillBottomColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.progressPreview.FillMiddleColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.progressPreview.FillTopColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(132, Byte), Integer))
            Me.progressPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.progressPreview.InsetHighlightColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.progressPreview.Location = New System.Drawing.Point(19, 130)
            Me.progressPreview.MinimumSize = New System.Drawing.Size(40, 12)
            Me.progressPreview.Name = "progressPreview"
            Me.progressPreview.ShineBottomColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.progressPreview.ShineTopColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.progressPreview.Size = New System.Drawing.Size(514, 22)
            Me.progressPreview.SweepColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer))
            Me.progressPreview.TabIndex = 4
            Me.progressPreview.TrackBottomColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(15, Byte), Integer))
            Me.progressPreview.TrackShadowColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.progressPreview.TrackTopColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer))
            Me.progressPreview.Value = 68
            '
            'lblPreviewMuted
            '
            Me.lblPreviewMuted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPreviewMuted.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPreviewMuted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblPreviewMuted.Location = New System.Drawing.Point(16, 64)
            Me.lblPreviewMuted.Name = "lblPreviewMuted"
            Me.lblPreviewMuted.Size = New System.Drawing.Size(517, 28)
            Me.lblPreviewMuted.TabIndex = 1
            Me.lblPreviewMuted.Text = "Secondary and muted text"
            Me.lblPreviewMuted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblPreviewBody
            '
            Me.lblPreviewBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPreviewBody.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPreviewBody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblPreviewBody.Location = New System.Drawing.Point(16, 16)
            Me.lblPreviewBody.Name = "lblPreviewBody"
            Me.lblPreviewBody.Size = New System.Drawing.Size(517, 44)
            Me.lblPreviewBody.TabIndex = 0
            Me.lblPreviewBody.Text = "Theme colors and fonts update here before you save."
            Me.lblPreviewBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPreviewFooter
            '
            Me.pnlPreviewFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlPreviewFooter.Controls.Add(Me.btnPreview)
            Me.pnlPreviewFooter.Controls.Add(Me.lblPreviewFooterSeparator)
            Me.pnlPreviewFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPreviewFooter.Location = New System.Drawing.Point(14, 462)
            Me.pnlPreviewFooter.Name = "pnlPreviewFooter"
            Me.pnlPreviewFooter.Padding = New System.Windows.Forms.Padding(14)
            Me.pnlPreviewFooter.Size = New System.Drawing.Size(552, 54)
            Me.pnlPreviewFooter.TabIndex = 2
            '
            'btnPreview
            '
            Me.btnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPreview.Location = New System.Drawing.Point(213, 20)
            Me.btnPreview.Name = "btnPreview"
            Me.btnPreview.Size = New System.Drawing.Size(120, 26)
            Me.btnPreview.TabIndex = 0
            Me.btnPreview.Text = "Preview Button"
            Me.btnPreview.UseVisualStyleBackColor = False
            '
            'lblPreviewFooterSeparator
            '
            Me.lblPreviewFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblPreviewFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblPreviewFooterSeparator.Location = New System.Drawing.Point(14, 14)
            Me.lblPreviewFooterSeparator.Name = "lblPreviewFooterSeparator"
            Me.lblPreviewFooterSeparator.Size = New System.Drawing.Size(524, 1)
            Me.lblPreviewFooterSeparator.TabIndex = 1
            '
            'pnlPreviewHeader
            '
            Me.pnlPreviewHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlPreviewHeader.Controls.Add(Me.lblPreviewSubtitle)
            Me.pnlPreviewHeader.Controls.Add(Me.lblPreviewHeaderSeparator)
            Me.pnlPreviewHeader.Controls.Add(Me.lblPreviewTitle)
            Me.pnlPreviewHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlPreviewHeader.Location = New System.Drawing.Point(14, 14)
            Me.pnlPreviewHeader.Name = "pnlPreviewHeader"
            Me.pnlPreviewHeader.Padding = New System.Windows.Forms.Padding(14)
            Me.pnlPreviewHeader.Size = New System.Drawing.Size(552, 96)
            Me.pnlPreviewHeader.TabIndex = 0
            '
            'lblPreviewSubtitle
            '
            Me.lblPreviewSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPreviewSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPreviewSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblPreviewSubtitle.Location = New System.Drawing.Point(17, 52)
            Me.lblPreviewSubtitle.Name = "lblPreviewSubtitle"
            Me.lblPreviewSubtitle.Size = New System.Drawing.Size(518, 18)
            Me.lblPreviewSubtitle.TabIndex = 1
            Me.lblPreviewSubtitle.Text = "Header subtitle preview with themed separator."
            '
            'lblPreviewHeaderSeparator
            '
            Me.lblPreviewHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblPreviewHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblPreviewHeaderSeparator.Location = New System.Drawing.Point(14, 80)
            Me.lblPreviewHeaderSeparator.Name = "lblPreviewHeaderSeparator"
            Me.lblPreviewHeaderSeparator.Size = New System.Drawing.Size(524, 2)
            Me.lblPreviewHeaderSeparator.TabIndex = 2
            '
            'lblPreviewTitle
            '
            Me.lblPreviewTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPreviewTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.lblPreviewTitle.Location = New System.Drawing.Point(14, 14)
            Me.lblPreviewTitle.Name = "lblPreviewTitle"
            Me.lblPreviewTitle.Size = New System.Drawing.Size(524, 35)
            Me.lblPreviewTitle.TabIndex = 0
            Me.lblPreviewTitle.Text = "DarkSaber"
            Me.lblPreviewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderSeparator)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(984, 86)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(24, 54)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(936, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Edit theme metadata, colour tokens, fonts, and the INI-backed preview."
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(24, 17)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(936, 31)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Theme Editor"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 84)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(984, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnReset)
            Me.pnlFooter.Controls.Add(Me.btnSaveAs)
            Me.pnlFooter.Controls.Add(Me.btnSave)
            Me.pnlFooter.Controls.Add(Me.btnApplyTheme)
            Me.pnlFooter.Controls.Add(Me.btnReload)
            Me.pnlFooter.Controls.Add(Me.cmbThemes)
            Me.pnlFooter.Controls.Add(Me.lblThemePicker)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 650)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(984, 65)
            Me.pnlFooter.TabIndex = 2
            '
            'btnReset
            '
            Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnReset.Location = New System.Drawing.Point(835, 22)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(125, 26)
            Me.btnReset.TabIndex = 5
            Me.btnReset.Text = "Reset Defaults"
            Me.btnReset.UseVisualStyleBackColor = False
            '
            'btnSaveAs
            '
            Me.btnSaveAs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSaveAs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveAs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSaveAs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSaveAs.Location = New System.Drawing.Point(743, 22)
            Me.btnSaveAs.Name = "btnSaveAs"
            Me.btnSaveAs.Size = New System.Drawing.Size(86, 26)
            Me.btnSaveAs.TabIndex = 4
            Me.btnSaveAs.Text = "Save As"
            Me.btnSaveAs.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSave.Location = New System.Drawing.Point(661, 22)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(76, 26)
            Me.btnSave.TabIndex = 3
            Me.btnSave.Text = "Save"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnApplyTheme
            '
            Me.btnApplyTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnApplyTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnApplyTheme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnApplyTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnApplyTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnApplyTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnApplyTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnApplyTheme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnApplyTheme.Location = New System.Drawing.Point(447, 22)
            Me.btnApplyTheme.Name = "btnApplyTheme"
            Me.btnApplyTheme.Size = New System.Drawing.Size(126, 26)
            Me.btnApplyTheme.TabIndex = 2
            Me.btnApplyTheme.Text = "Apply Theme"
            Me.btnApplyTheme.UseVisualStyleBackColor = False
            '
            'btnReload
            '
            Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReload.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnReload.Location = New System.Drawing.Point(579, 22)
            Me.btnReload.Name = "btnReload"
            Me.btnReload.Size = New System.Drawing.Size(76, 26)
            Me.btnReload.TabIndex = 2
            Me.btnReload.Text = "Reload"
            Me.btnReload.UseVisualStyleBackColor = False
            '
            'cmbThemes
            '
            Me.cmbThemes.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.cmbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbThemes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbThemes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbThemes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbThemes.FormattingEnabled = True
            Me.cmbThemes.Location = New System.Drawing.Point(75, 25)
            Me.cmbThemes.Name = "cmbThemes"
            Me.cmbThemes.Size = New System.Drawing.Size(220, 21)
            Me.cmbThemes.TabIndex = 1
            '
            'lblThemePicker
            '
            Me.lblThemePicker.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblThemePicker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblThemePicker.Location = New System.Drawing.Point(24, 24)
            Me.lblThemePicker.Name = "lblThemePicker"
            Me.lblThemePicker.Size = New System.Drawing.Size(45, 23)
            Me.lblThemePicker.TabIndex = 0
            Me.lblThemePicker.Text = "Theme"
            Me.lblThemePicker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New System.Drawing.Size(984, 1)
            Me.lblFooterSeparator.TabIndex = 6
            '
            'frmThemeEditor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(984, 715)
            Me.Controls.Add(Me.pnlRoot)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(900, 620)
            Me.Name = "frmThemeEditor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Theme Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.splitMain.Panel1.ResumeLayout(False)
            Me.splitMain.Panel2.ResumeLayout(False)
            CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitMain.ResumeLayout(False)
            Me.grpColors.ResumeLayout(False)
            Me.pnlColorEditor.ResumeLayout(False)
            CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRed, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudAlpha, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpFonts.ResumeLayout(False)
            Me.grpFonts.PerformLayout()
            CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpTheme.ResumeLayout(False)
            Me.grpTheme.PerformLayout()
            Me.pnlPreviewRoot.ResumeLayout(False)
            Me.pnlPreviewBody.ResumeLayout(False)
            Me.pnlPreviewBody.PerformLayout()
            Me.tabPreview.ResumeLayout(False)
            Me.tabPreviewOne.ResumeLayout(False)
            Me.grpPreview.ResumeLayout(False)
            Me.grpPreview.PerformLayout()
            Me.pnlPreviewFooter.ResumeLayout(False)
            Me.pnlPreviewHeader.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace
