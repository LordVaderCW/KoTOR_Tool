Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmGlobalVar_Editor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' frmGlobalVar_Editor.Designer.vb
        '
        ' Restored / facelifted Global Variable Editor for the KoTOR Tool
        ' Restoration Project.
        '
        ' Original Tool:
        '   Fred Tetra's KotOR Tool
        '
        ' Restoration Project:
        '   KoTOR Tool Restoration Project
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original control names preserved for source compatibility.
        '   - Theme colours are applied at runtime from Themes\DarkSaber.ini.
        '   - Designer keeps fallback colours only for safe VS designer display.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents dgBoolGlobals As Global.System.Windows.Forms.DataGrid
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents dgNumericGlobals As Global.System.Windows.Forms.DataGrid
        Friend WithEvents TabPage4 As Global.System.Windows.Forms.TabPage
        Friend WithEvents dgStringGlobals As Global.System.Windows.Forms.DataGrid
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenFirst As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenCompare As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSave As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowOnlyDiffs As Global.System.Windows.Forms.MenuItem
        Friend WithEvents lblFile1 As Global.System.Windows.Forms.Label
        Friend WithEvents lblFile2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents StatusBar As Global.System.Windows.Forms.StatusBar
        Friend WithEvents sbpBool As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbpNumeric As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbpString As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbpLabel As Global.System.Windows.Forms.StatusBarPanel

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFileInfo As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenFirst = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenCompare = New Global.System.Windows.Forms.MenuItem()
            Me.miSave = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.miShowOnlyDiffs = New Global.System.Windows.Forms.MenuItem()
            Me.StatusBar = New Global.System.Windows.Forms.StatusBar()
            Me.sbpLabel = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbpBool = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbpNumeric = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbpString = New Global.System.Windows.Forms.StatusBarPanel()
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
            Me.dgBoolGlobals = New Global.System.Windows.Forms.DataGrid()
            Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
            Me.dgNumericGlobals = New Global.System.Windows.Forms.DataGrid()
            Me.TabPage4 = New Global.System.Windows.Forms.TabPage()
            Me.dgStringGlobals = New Global.System.Windows.Forms.DataGrid()
            Me.lblSeparatorBottom = New Global.System.Windows.Forms.Label()
            Me.pnlFileInfo = New Global.System.Windows.Forms.Panel()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.lblFile1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.lblFile2 = New Global.System.Windows.Forms.Label()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New Global.System.Windows.Forms.Label()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            CType(Me.sbpLabel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpBool, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpNumeric, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpString, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.dgBoolGlobals, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgNumericGlobals, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage4.SuspendLayout()
            CType(Me.dgStringGlobals, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFileInfo.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miOpenFirst, Me.miOpenCompare, Me.miSave, Me.MenuItem6, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miOpenFirst
            '
            Me.miOpenFirst.Index = 0
            Me.miOpenFirst.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenFirst.Text = "&Open..."
            '
            'miOpenCompare
            '
            Me.miOpenCompare.Enabled = False
            Me.miOpenCompare.Index = 1
            Me.miOpenCompare.Text = "Open File to &Compare..."
            '
            'miSave
            '
            Me.miSave.Index = 2
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 3
            Me.MenuItem6.Text = "-"
            '
            'miQuit
            '
            Me.miQuit.Index = 4
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miShowOnlyDiffs})
            Me.MenuItem2.Text = "&View"
            '
            'miShowOnlyDiffs
            '
            Me.miShowOnlyDiffs.Enabled = False
            Me.miShowOnlyDiffs.Index = 0
            Me.miShowOnlyDiffs.Text = "&Show only differences"
            '
            'StatusBar
            '
            Me.StatusBar.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.StatusBar.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.StatusBar.Location = New Global.System.Drawing.Point(0, 558)
            Me.StatusBar.Name = "StatusBar"
            Me.StatusBar.Panels.AddRange(New Global.System.Windows.Forms.StatusBarPanel() {Me.sbpLabel, Me.sbpBool, Me.sbpNumeric, Me.sbpString})
            Me.StatusBar.ShowPanels = True
            Me.StatusBar.Size = New Global.System.Drawing.Size(640, 22)
            Me.StatusBar.SizingGrip = False
            Me.StatusBar.TabIndex = 1
            Me.StatusBar.Text = "StatusBar"
            Me.StatusBar.Visible = False
            '
            'sbpLabel
            '
            Me.sbpLabel.AutoSize = Global.System.Windows.Forms.StatusBarPanelAutoSize.Contents
            Me.sbpLabel.BorderStyle = Global.System.Windows.Forms.StatusBarPanelBorderStyle.None
            Me.sbpLabel.Name = "sbpLabel"
            Me.sbpLabel.Text = "Differences"
            Me.sbpLabel.Width = 72
            '
            'sbpBool
            '
            Me.sbpBool.Alignment = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpBool.Name = "sbpBool"
            Me.sbpBool.ToolTipText = "Number of differences in Boolean Globals"
            Me.sbpBool.Width = 50
            '
            'sbpNumeric
            '
            Me.sbpNumeric.Alignment = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpNumeric.Name = "sbpNumeric"
            Me.sbpNumeric.ToolTipText = "Number of differences in Numeric Globals"
            Me.sbpNumeric.Width = 50
            '
            'sbpString
            '
            Me.sbpString.Alignment = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpString.Name = "sbpString"
            Me.sbpString.ToolTipText = "Number of differences in String Globals"
            Me.sbpString.Width = 50
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFileInfo)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(640, 580)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 148)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(14, 14, 14, 12)
            Me.pnlBody.Size = New Global.System.Drawing.Size(638, 430)
            Me.pnlBody.TabIndex = 2
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Me.TabControl1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New Global.System.Drawing.Point(14, 14)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(610, 392)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.dgBoolGlobals)
            Me.TabPage1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New Global.System.Windows.Forms.Padding(8)
            Me.TabPage1.Size = New Global.System.Drawing.Size(602, 366)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Boolean Globals"
            '
            'dgBoolGlobals
            '
            Me.dgBoolGlobals.AlternatingBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgBoolGlobals.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.dgBoolGlobals.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgBoolGlobals.BackgroundColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgBoolGlobals.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgBoolGlobals.CaptionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgBoolGlobals.CaptionFont = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgBoolGlobals.CaptionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgBoolGlobals.CaptionText = "Boolean Globals"
            Me.dgBoolGlobals.DataMember = ""
            Me.dgBoolGlobals.FlatMode = True
            Me.dgBoolGlobals.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgBoolGlobals.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgBoolGlobals.GridLineColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dgBoolGlobals.HeaderBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgBoolGlobals.HeaderForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgBoolGlobals.LinkColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgBoolGlobals.Location = New Global.System.Drawing.Point(8, 8)
            Me.dgBoolGlobals.Name = "dgBoolGlobals"
            Me.dgBoolGlobals.ParentRowsBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgBoolGlobals.ParentRowsForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgBoolGlobals.SelectionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgBoolGlobals.SelectionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgBoolGlobals.Size = New Global.System.Drawing.Size(586, 350)
            Me.dgBoolGlobals.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.dgNumericGlobals)
            Me.TabPage2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage2.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New Global.System.Windows.Forms.Padding(8)
            Me.TabPage2.Size = New Global.System.Drawing.Size(602, 366)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Numeric Globals"
            '
            'dgNumericGlobals
            '
            Me.dgNumericGlobals.AlternatingBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgNumericGlobals.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.dgNumericGlobals.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgNumericGlobals.BackgroundColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgNumericGlobals.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgNumericGlobals.CaptionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgNumericGlobals.CaptionFont = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgNumericGlobals.CaptionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgNumericGlobals.CaptionText = "Numeric Globals"
            Me.dgNumericGlobals.DataMember = ""
            Me.dgNumericGlobals.FlatMode = True
            Me.dgNumericGlobals.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgNumericGlobals.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgNumericGlobals.GridLineColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dgNumericGlobals.HeaderBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgNumericGlobals.HeaderForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgNumericGlobals.LinkColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgNumericGlobals.Location = New Global.System.Drawing.Point(8, 8)
            Me.dgNumericGlobals.Name = "dgNumericGlobals"
            Me.dgNumericGlobals.ParentRowsBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgNumericGlobals.ParentRowsForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgNumericGlobals.SelectionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgNumericGlobals.SelectionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgNumericGlobals.Size = New Global.System.Drawing.Size(586, 350)
            Me.dgNumericGlobals.TabIndex = 0
            '
            'TabPage4
            '
            Me.TabPage4.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage4.Controls.Add(Me.dgStringGlobals)
            Me.TabPage4.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage4.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New Global.System.Windows.Forms.Padding(8)
            Me.TabPage4.Size = New Global.System.Drawing.Size(602, 366)
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "String Globals"
            '
            'dgStringGlobals
            '
            Me.dgStringGlobals.AlternatingBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgStringGlobals.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.dgStringGlobals.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgStringGlobals.BackgroundColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgStringGlobals.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgStringGlobals.CaptionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgStringGlobals.CaptionFont = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgStringGlobals.CaptionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgStringGlobals.CaptionText = "String Globals"
            Me.dgStringGlobals.DataMember = ""
            Me.dgStringGlobals.FlatMode = True
            Me.dgStringGlobals.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgStringGlobals.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgStringGlobals.GridLineColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dgStringGlobals.HeaderBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgStringGlobals.HeaderForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgStringGlobals.LinkColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgStringGlobals.Location = New Global.System.Drawing.Point(8, 8)
            Me.dgStringGlobals.Name = "dgStringGlobals"
            Me.dgStringGlobals.ParentRowsBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgStringGlobals.ParentRowsForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgStringGlobals.SelectionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgStringGlobals.SelectionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgStringGlobals.Size = New Global.System.Drawing.Size(586, 350)
            Me.dgStringGlobals.TabIndex = 1
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New Global.System.Drawing.Point(14, 416)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New Global.System.Drawing.Size(610, 2)
            Me.lblSeparatorBottom.TabIndex = 1
            '
            'pnlFileInfo
            '
            Me.pnlFileInfo.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFileInfo.Controls.Add(Me.Label1)
            Me.pnlFileInfo.Controls.Add(Me.lblFile1)
            Me.pnlFileInfo.Controls.Add(Me.Label2)
            Me.pnlFileInfo.Controls.Add(Me.lblFile2)
            Me.pnlFileInfo.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.pnlFileInfo.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlFileInfo.Name = "pnlFileInfo"
            Me.pnlFileInfo.Padding = New Global.System.Windows.Forms.Padding(16, 12, 16, 12)
            Me.pnlFileInfo.Size = New Global.System.Drawing.Size(638, 72)
            Me.pnlFileInfo.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(18, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(82, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Viewing:"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFile1
            '
            Me.lblFile1.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblFile1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFile1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFile1.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFile1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblFile1.Location = New Global.System.Drawing.Point(104, 12)
            Me.lblFile1.Name = "lblFile1"
            Me.lblFile1.Size = New Global.System.Drawing.Size(516, 20)
            Me.lblFile1.TabIndex = 1
            Me.lblFile1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New Global.System.Drawing.Point(18, 39)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(82, 18)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Comparing:"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFile2
            '
            Me.lblFile2.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblFile2.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFile2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFile2.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFile2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblFile2.Location = New Global.System.Drawing.Point(104, 38)
            Me.lblFile2.Name = "lblFile2"
            Me.lblFile2.Size = New Global.System.Drawing.Size(516, 20)
            Me.lblFile2.TabIndex = 3
            Me.lblFile2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New Global.System.Drawing.Size(638, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New Global.System.Drawing.Size(638, 2)
            Me.lblSeparatorTop.TabIndex = 2
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New Global.System.Drawing.Font("Segoe UI", 8.75!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(18, 45)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(600, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Open, compare, inspect, and save Boolean, Numeric, and String global variables."
            Me.lblSubtitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 18.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(602, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Global Variable Editor"
            Me.lblTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmGlobalVar_Editor
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New Global.System.Drawing.Size(640, 580)
            Me.Controls.Add(Me.StatusBar)
            Me.Controls.Add(Me.pnlRoot)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New Global.System.Drawing.Size(520, 500)
            Me.Name = "frmGlobalVar_Editor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Global Variable Editor"
            CType(Me.sbpLabel, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpBool, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpNumeric, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpString, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            CType(Me.dgBoolGlobals, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.dgNumericGlobals, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage4.ResumeLayout(False)
            CType(Me.dgStringGlobals, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFileInfo.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace