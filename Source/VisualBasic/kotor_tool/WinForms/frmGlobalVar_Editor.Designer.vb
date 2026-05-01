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
            Me.components = New System.ComponentModel.Container()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miOpenFirst = New System.Windows.Forms.MenuItem()
            Me.miOpenCompare = New System.Windows.Forms.MenuItem()
            Me.miSave = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New System.Windows.Forms.MenuItem()
            Me.miShowOnlyDiffs = New System.Windows.Forms.MenuItem()
            Me.StatusBar = New System.Windows.Forms.StatusBar()
            Me.sbpLabel = New System.Windows.Forms.StatusBarPanel()
            Me.sbpBool = New System.Windows.Forms.StatusBarPanel()
            Me.sbpNumeric = New System.Windows.Forms.StatusBarPanel()
            Me.sbpString = New System.Windows.Forms.StatusBarPanel()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.dgBoolGlobals = New System.Windows.Forms.DataGrid()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.dgNumericGlobals = New System.Windows.Forms.DataGrid()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.dgStringGlobals = New System.Windows.Forms.DataGrid()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFileInfo = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblFile1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblFile2 = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            CType(Me.sbpLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpBool, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpString, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.dgBoolGlobals, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgNumericGlobals, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage4.SuspendLayout()
            CType(Me.dgStringGlobals, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFileInfo.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()






            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miOpenFirst, Me.miOpenCompare, Me.miSave, Me.MenuItem6, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miOpenFirst
            '
            Me.miOpenFirst.Index = 0
            Me.miOpenFirst.Shortcut = System.Windows.Forms.Shortcut.CtrlO
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
            Me.miSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
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
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miShowOnlyDiffs})
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
            Me.StatusBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.StatusBar.Location = New System.Drawing.Point(0, 739)
            Me.StatusBar.Name = "StatusBar"
            Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sbpLabel, Me.sbpBool, Me.sbpNumeric, Me.sbpString})
            Me.StatusBar.ShowPanels = True
            Me.StatusBar.Size = New System.Drawing.Size(586, 25)
            Me.StatusBar.SizingGrip = False
            Me.StatusBar.TabIndex = 1
            Me.StatusBar.Text = "StatusBar"
            Me.StatusBar.Visible = False
            '
            'sbpLabel
            '
            Me.sbpLabel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
            Me.sbpLabel.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
            Me.sbpLabel.Name = "sbpLabel"
            Me.sbpLabel.Text = "Differences"
            Me.sbpLabel.Width = 72
            '
            'sbpBool
            '
            Me.sbpBool.Alignment = System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpBool.Name = "sbpBool"
            Me.sbpBool.ToolTipText = "Number of differences in Boolean Globals"
            Me.sbpBool.Width = 50
            '
            'sbpNumeric
            '
            Me.sbpNumeric.Alignment = System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpNumeric.Name = "sbpNumeric"
            Me.sbpNumeric.ToolTipText = "Number of differences in Numeric Globals"
            Me.sbpNumeric.Width = 50
            '
            'sbpString
            '
            Me.sbpString.Alignment = System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpString.Name = "sbpString"
            Me.sbpString.ToolTipText = "Number of differences in String Globals"
            Me.sbpString.Width = 50
            ' -----------------------------------------------------------------
            ' Designer preview data for Global Variable Editor grids.
            '
            ' Place this block near the top of InitializeComponent(), after control
            ' instantiation and before the pnlRoot / pnlBody / TabControl / DataGrid
            ' property blocks.
            '
            ' Runtime code still replaces this with real tables through SetDataBinding.
            ' -----------------------------------------------------------------
            Dim dtDesignBool As System.Data.DataTable = New System.Data.DataTable("DesignBoolGlobals")
            Dim dtDesignNumeric As System.Data.DataTable = New System.Data.DataTable("DesignNumericGlobals")
            Dim dtDesignString As System.Data.DataTable = New System.Data.DataTable("DesignStringGlobals")

            Dim boolTableStyle As System.Windows.Forms.DataGridTableStyle = New System.Windows.Forms.DataGridTableStyle()
            Dim boolVariableColumn As System.Windows.Forms.DataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn()
            Dim boolActiveColumn As System.Windows.Forms.DataGridBoolColumn = New System.Windows.Forms.DataGridBoolColumn()

            Dim numericTableStyle As System.Windows.Forms.DataGridTableStyle = New System.Windows.Forms.DataGridTableStyle()
            Dim numericVariableColumn As System.Windows.Forms.DataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn()
            Dim numericValueColumn As System.Windows.Forms.DataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn()

            Dim stringTableStyle As System.Windows.Forms.DataGridTableStyle = New System.Windows.Forms.DataGridTableStyle()
            Dim stringVariableColumn As System.Windows.Forms.DataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn()
            Dim stringValueColumn As System.Windows.Forms.DataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn()

            '
            ' Design preview data tables
            '
            dtDesignBool.Columns.Add("Variable", GetType(String))
            dtDesignBool.Columns.Add("Active", GetType(Boolean))
            dtDesignBool.Rows.Add("Tar_GortonAI", False)
            dtDesignBool.Rows.Add("Dan_Blaster", True)
            dtDesignBool.Rows.Add("UNK_GUARD_DOWN", False)
            dtDesignBool.Rows.Add("tat_SharinaPaidFull", True)
            dtDesignBool.Rows.Add("Lev_Rescue", False)
            dtDesignBool.Rows.Add("k_vis_manaan2", True)
            dtDesignBool.Rows.Add("k_vis_Dantooine", False)
            dtDesignBool.Rows.Add("DAN_VANDARJ_DONE", True)
            dtDesignBool.Rows.Add("MAN_GLUUPEV_DONE", False)
            dtDesignBool.Rows.Add("K_SWG_DAVIN", True)

            dtDesignNumeric.Columns.Add("Variable", GetType(String))
            dtDesignNumeric.Columns.Add("Value", GetType(Byte))
            dtDesignNumeric.Rows.Add("G_Party_Init_Trig", CType(0, Byte))
            dtDesignNumeric.Rows.Add("KOR_KNOW_EXCAV", CType(1, Byte))
            dtDesignNumeric.Rows.Add("MIN_TIME_MIN", CType(12, Byte))
            dtDesignNumeric.Rows.Add("KOR_PRESTIGE", CType(25, Byte))
            dtDesignNumeric.Rows.Add("MAN_RODIAN_PLOT", CType(50, Byte))
            dtDesignNumeric.Rows.Add("DAN_BOLOOK_ANGER", CType(75, Byte))
            dtDesignNumeric.Rows.Add("K_SWG_HK47_FIX", CType(100, Byte))
            dtDesignNumeric.Rows.Add("K_SWG_BASTILA_LEVEL", CType(125, Byte))
            dtDesignNumeric.Rows.Add("KOR_DANEL", CType(200, Byte))
            dtDesignNumeric.Rows.Add("MAN_MISSING_PLOT", CType(255, Byte))

            dtDesignString.Columns.Add("Variable", GetType(String))
            dtDesignString.Columns.Add("Value", GetType(String))
            dtDesignString.Rows.Add("K_CURRENT_PLANET", "Dantooine")
            dtDesignString.Rows.Add("K_LAST_MODULE", "danm13")
            dtDesignString.Rows.Add("K_PLAYER_ALIGNMENT", "Light")
            dtDesignString.Rows.Add("K_ACTIVE_QUEST", "Jedi Trials")
            dtDesignString.Rows.Add("K_DIALOG_STATE", "Complete")
            dtDesignString.Rows.Add("K_COMPANION_ACTIVE", "Bastila")
            dtDesignString.Rows.Add("K_SHIP_LOCATION", "Ebon Hawk")
            dtDesignString.Rows.Add("K_SAVE_TAG", "Runtime preview")
            dtDesignString.Rows.Add("K_FACTION_STATE", "Republic")
            dtDesignString.Rows.Add("K_DEBUG_NOTE", "Designer only")

            '
            ' Boolean design-time table style
            '
            boolTableStyle.MappingName = "DesignBoolGlobals"
            boolTableStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            boolTableStyle.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            boolTableStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            boolTableStyle.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
            boolTableStyle.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            boolTableStyle.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            boolTableStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            boolTableStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))

            boolVariableColumn.MappingName = "Variable"
            boolVariableColumn.HeaderText = "Variable"
            boolVariableColumn.Width = 382
            boolTableStyle.GridColumnStyles.Add(boolVariableColumn)

            boolActiveColumn.MappingName = "Active"
            boolActiveColumn.HeaderText = "Active"
            boolActiveColumn.AllowNull = False
            boolActiveColumn.Width = 105
            boolTableStyle.GridColumnStyles.Add(boolActiveColumn)

            '
            ' Numeric design-time table style
            '
            numericTableStyle.MappingName = "DesignNumericGlobals"
            numericTableStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            numericTableStyle.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            numericTableStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            numericTableStyle.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
            numericTableStyle.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            numericTableStyle.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            numericTableStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            numericTableStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))

            numericVariableColumn.MappingName = "Variable"
            numericVariableColumn.HeaderText = "Variable"
            numericVariableColumn.Width = 382
            numericTableStyle.GridColumnStyles.Add(numericVariableColumn)

            numericValueColumn.MappingName = "Value"
            numericValueColumn.HeaderText = "Value"
            numericValueColumn.Width = 105
            numericTableStyle.GridColumnStyles.Add(numericValueColumn)

            '
            ' String design-time table style
            '
            stringTableStyle.MappingName = "DesignStringGlobals"
            stringTableStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            stringTableStyle.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            stringTableStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            stringTableStyle.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
            stringTableStyle.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            stringTableStyle.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            stringTableStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            stringTableStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))

            stringVariableColumn.MappingName = "Variable"
            stringVariableColumn.HeaderText = "Variable"
            stringVariableColumn.Width = 250
            stringTableStyle.GridColumnStyles.Add(stringVariableColumn)

            stringValueColumn.MappingName = "Value"
            stringValueColumn.HeaderText = "Value"
            stringValueColumn.Width = 237
            stringTableStyle.GridColumnStyles.Add(stringValueColumn)

            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFileInfo)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(586, 764)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 171)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(14, 14, 14, 12)
            Me.pnlBody.Size = New System.Drawing.Size(584, 591)
            Me.pnlBody.TabIndex = 2
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
Or System.Windows.Forms.AnchorStyles.Left) _
Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(14, 16)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(556, 537)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.dgBoolGlobals)
            Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(8)
            Me.TabPage1.Size = New System.Drawing.Size(548, 511)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Boolean Globals"
            '
            'dgBoolGlobals
            '
            Me.dgBoolGlobals.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgBoolGlobals.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgBoolGlobals.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgBoolGlobals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgBoolGlobals.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgBoolGlobals.CaptionFont = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.dgBoolGlobals.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgBoolGlobals.CaptionText = "Boolean Globals"
            Me.dgBoolGlobals.DataMember = ""
            Me.dgBoolGlobals.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgBoolGlobals.FlatMode = False
            Me.dgBoolGlobals.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgBoolGlobals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgBoolGlobals.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
            Me.dgBoolGlobals.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgBoolGlobals.HeaderFont = New System.Drawing.Font("Segoe UI", 10.25!)
            Me.dgBoolGlobals.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgBoolGlobals.LinkColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgBoolGlobals.Location = New System.Drawing.Point(8, 8)
            Me.dgBoolGlobals.Name = "dgBoolGlobals"
            Me.dgBoolGlobals.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgBoolGlobals.ParentRowsForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgBoolGlobals.PreferredColumnWidth = 90
            Me.dgBoolGlobals.PreferredRowHeight = 22
            Me.dgBoolGlobals.RowHeaderWidth = 40
            Me.dgBoolGlobals.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgBoolGlobals.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgBoolGlobals.Size = New System.Drawing.Size(532, 495)
            Me.dgBoolGlobals.TabIndex = 0
            Me.dgBoolGlobals.TableStyles.Clear()
            Me.dgBoolGlobals.TableStyles.Add(boolTableStyle)
            Me.dgBoolGlobals.DataSource = dtDesignBool
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.dgNumericGlobals)
            Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(8)
            Me.TabPage2.Size = New System.Drawing.Size(602, 511)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Numeric Globals"
            '
            'dgNumericGlobals
            '
            Me.dgNumericGlobals.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgNumericGlobals.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgNumericGlobals.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgNumericGlobals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgNumericGlobals.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgNumericGlobals.CaptionFont = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
            Me.dgNumericGlobals.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgNumericGlobals.CaptionText = "Numeric Globals"
            Me.dgNumericGlobals.DataMember = ""
            Me.dgNumericGlobals.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgNumericGlobals.FlatMode = False
            Me.dgNumericGlobals.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgNumericGlobals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgNumericGlobals.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
            Me.dgNumericGlobals.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgNumericGlobals.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgNumericGlobals.LinkColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgNumericGlobals.Location = New System.Drawing.Point(8, 8)
            Me.dgNumericGlobals.Name = "dgNumericGlobals"
            Me.dgNumericGlobals.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgNumericGlobals.ParentRowsForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgNumericGlobals.PreferredColumnWidth = 90
            Me.dgNumericGlobals.PreferredRowHeight = 22
            Me.dgNumericGlobals.RowHeaderWidth = 40
            Me.dgNumericGlobals.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgNumericGlobals.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgNumericGlobals.Size = New System.Drawing.Size(586, 495)
            Me.dgNumericGlobals.TabIndex = 0
            Me.dgNumericGlobals.TableStyles.Clear()
            Me.dgNumericGlobals.TableStyles.Add(numericTableStyle)
            Me.dgNumericGlobals.DataSource = dtDesignNumeric
            '
            'TabPage4
            '
            Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage4.Controls.Add(Me.dgStringGlobals)
            Me.TabPage4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage4.Location = New System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(8)
            Me.TabPage4.Size = New System.Drawing.Size(602, 511)
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "String Globals"
            '
            'dgStringGlobals
            '
            Me.dgStringGlobals.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgStringGlobals.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgStringGlobals.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgStringGlobals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgStringGlobals.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgStringGlobals.CaptionFont = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgStringGlobals.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgStringGlobals.CaptionText = "String Globals"
            Me.dgStringGlobals.DataMember = ""
            Me.dgStringGlobals.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgStringGlobals.FlatMode = False
            Me.dgStringGlobals.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgStringGlobals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgStringGlobals.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(98, Byte), Integer))
            Me.dgStringGlobals.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgStringGlobals.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgStringGlobals.LinkColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgStringGlobals.Location = New System.Drawing.Point(8, 8)
            Me.dgStringGlobals.Name = "dgStringGlobals"
            Me.dgStringGlobals.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgStringGlobals.ParentRowsForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgStringGlobals.PreferredColumnWidth = 90
            Me.dgStringGlobals.PreferredRowHeight = 22
            Me.dgStringGlobals.RowHeaderWidth = 40
            Me.dgStringGlobals.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgStringGlobals.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgStringGlobals.Size = New System.Drawing.Size(586, 489)
            Me.dgStringGlobals.TabIndex = 1
            Me.dgStringGlobals.TableStyles.Clear()
            Me.dgStringGlobals.TableStyles.Add(stringTableStyle)
            Me.dgStringGlobals.DataSource = dtDesignString

            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(14, 577)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(556, 2)
            Me.lblSeparatorBottom.TabIndex = 1
            '
            'pnlFileInfo
            '
            Me.pnlFileInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFileInfo.Controls.Add(Me.Label1)
            Me.pnlFileInfo.Controls.Add(Me.lblFile1)
            Me.pnlFileInfo.Controls.Add(Me.Label2)
            Me.pnlFileInfo.Controls.Add(Me.lblFile2)
            Me.pnlFileInfo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlFileInfo.Location = New System.Drawing.Point(0, 88)
            Me.pnlFileInfo.Name = "pnlFileInfo"
            Me.pnlFileInfo.Padding = New System.Windows.Forms.Padding(16, 12, 16, 12)
            Me.pnlFileInfo.Size = New System.Drawing.Size(584, 83)
            Me.pnlFileInfo.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(18, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 21)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Viewing:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFile1
            '
            Me.lblFile1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFile1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFile1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblFile1.Location = New System.Drawing.Point(104, 14)
            Me.lblFile1.Name = "lblFile1"
            Me.lblFile1.Size = New System.Drawing.Size(462, 23)
            Me.lblFile1.TabIndex = 1
            Me.lblFile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(18, 45)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(82, 21)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Comparing:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFile2
            '
            Me.lblFile2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFile2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFile2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFile2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblFile2.Location = New System.Drawing.Point(104, 44)
            Me.lblFile2.Name = "lblFile2"
            Me.lblFile2.Size = New System.Drawing.Size(462, 23)
            Me.lblFile2.TabIndex = 3
            Me.lblFile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(584, 88)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 85)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(584, 3)
            Me.lblSeparatorTop.TabIndex = 2
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 52)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(546, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Open, compare, inspect, and save Boolean, Numeric, and String global variables."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 12)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(548, 39)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Global Variable Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmGlobalVar_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(586, 764)
            Me.Controls.Add(Me.StatusBar)
            Me.Controls.Add(Me.pnlRoot)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New System.Drawing.Size(520, 577)
            Me.Name = "frmGlobalVar_Editor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Global Variable Editor"
            CType(Me.sbpLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpBool, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpNumeric, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpString, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            CType(Me.dgBoolGlobals, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.dgNumericGlobals, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage4.ResumeLayout(False)
            CType(Me.dgStringGlobals, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFileInfo.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace