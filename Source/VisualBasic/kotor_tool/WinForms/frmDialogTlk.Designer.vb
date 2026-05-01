Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmDialogTlk
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' frmDialogTlk.Designer.vb
        '
        ' Restored / facelifted Dialog.tlk editor for the KoTOR Tool
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

        Friend WithEvents Panel1 As Global.System.Windows.Forms.Panel
        Friend WithEvents dgDialogTlk As Global.System.Windows.Forms.DataGrid
        Friend WithEvents tbString As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudEntryNumber As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents btnGoToEntry As Global.System.Windows.Forms.Button
        Friend WithEvents btnFilter As Global.System.Windows.Forms.Button
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenExternal As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenK1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenK2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSaveAsXML As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem3 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tbSoundResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents miSave As Global.System.Windows.Forms.MenuItem
        Friend WithEvents btnApplyChanges As Global.System.Windows.Forms.Button

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlEditor As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label
        Friend WithEvents lblEntryNumber As Global.System.Windows.Forms.Label

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
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.dgDialogTlk = New System.Windows.Forms.DataGrid()
            Me.pnlEditor = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.tbString = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.tbSoundResRef = New System.Windows.Forms.TextBox()
            Me.btnApplyChanges = New System.Windows.Forms.Button()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblEntryNumber = New System.Windows.Forms.Label()
            Me.nudEntryNumber = New System.Windows.Forms.NumericUpDown()
            Me.btnGoToEntry = New System.Windows.Forms.Button()
            Me.btnFilter = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miOpenExternal = New System.Windows.Forms.MenuItem()
            Me.miOpenK1 = New System.Windows.Forms.MenuItem()
            Me.miOpenK2 = New System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New System.Windows.Forms.MenuItem()
            Me.miSave = New System.Windows.Forms.MenuItem()
            Me.miSaveAsXML = New System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgDialogTlk, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlEditor.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            CType(Me.nudEntryNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(720, 520)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.Panel1)
            Me.pnlBody.Controls.Add(Me.pnlEditor)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 65)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(14, 14, 14, 10)
            Me.pnlBody.Size = New System.Drawing.Size(718, 390)
            Me.pnlBody.TabIndex = 1
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.dgDialogTlk)
            Me.Panel1.Location = New System.Drawing.Point(14, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(690, 185)
            Me.Panel1.TabIndex = 0
            '
            'dgDialogTlk
            '
            Me.dgDialogTlk.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgDialogTlk.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgDialogTlk.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgDialogTlk.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgDialogTlk.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgDialogTlk.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgDialogTlk.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgDialogTlk.CaptionText = "Dialog Entries"
            Me.dgDialogTlk.DataMember = ""
            Me.dgDialogTlk.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgDialogTlk.FlatMode = True
            Me.dgDialogTlk.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgDialogTlk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgDialogTlk.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dgDialogTlk.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgDialogTlk.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgDialogTlk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgDialogTlk.Location = New System.Drawing.Point(0, 0)
            Me.dgDialogTlk.Name = "dgDialogTlk"
            Me.dgDialogTlk.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgDialogTlk.ParentRowsForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgDialogTlk.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgDialogTlk.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgDialogTlk.Size = New System.Drawing.Size(688, 183)
            Me.dgDialogTlk.TabIndex = 0
            '
            'pnlEditor
            '
            Me.pnlEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlEditor.Controls.Add(Me.Label1)
            Me.pnlEditor.Controls.Add(Me.tbString)
            Me.pnlEditor.Controls.Add(Me.Label3)
            Me.pnlEditor.Controls.Add(Me.tbSoundResRef)
            Me.pnlEditor.Controls.Add(Me.btnApplyChanges)
            Me.pnlEditor.Location = New System.Drawing.Point(14, 213)
            Me.pnlEditor.Name = "pnlEditor"
            Me.pnlEditor.Size = New System.Drawing.Size(690, 155)
            Me.pnlEditor.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(14, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(96, 21)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Dialog Text"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbString
            '
            Me.tbString.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbString.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbString.Enabled = False
            Me.tbString.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbString.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbString.Location = New System.Drawing.Point(118, 16)
            Me.tbString.Multiline = True
            Me.tbString.Name = "tbString"
            Me.tbString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbString.Size = New System.Drawing.Size(552, 83)
            Me.tbString.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(14, 111)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(96, 21)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "SoundResRef"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbSoundResRef
            '
            Me.tbSoundResRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tbSoundResRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbSoundResRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbSoundResRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbSoundResRef.Enabled = False
            Me.tbSoundResRef.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbSoundResRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSoundResRef.Location = New System.Drawing.Point(118, 111)
            Me.tbSoundResRef.MaxLength = 16
            Me.tbSoundResRef.Name = "tbSoundResRef"
            Me.tbSoundResRef.Size = New System.Drawing.Size(176, 20)
            Me.tbSoundResRef.TabIndex = 3
            '
            'btnApplyChanges
            '
            Me.btnApplyChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnApplyChanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnApplyChanges.Enabled = False
            Me.btnApplyChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnApplyChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnApplyChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnApplyChanges.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnApplyChanges.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnApplyChanges.Location = New System.Drawing.Point(548, 108)
            Me.btnApplyChanges.Name = "btnApplyChanges"
            Me.btnApplyChanges.Size = New System.Drawing.Size(122, 29)
            Me.btnApplyChanges.TabIndex = 4
            Me.btnApplyChanges.Text = "Apply Changes"
            Me.btnApplyChanges.UseVisualStyleBackColor = False
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(14, 378)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(690, 2)
            Me.lblSeparatorBottom.TabIndex = 2
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblEntryNumber)
            Me.pnlFooter.Controls.Add(Me.nudEntryNumber)
            Me.pnlFooter.Controls.Add(Me.btnGoToEntry)
            Me.pnlFooter.Controls.Add(Me.btnFilter)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 455)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(718, 63)
            Me.pnlFooter.TabIndex = 2
            '
            'lblEntryNumber
            '
            Me.lblEntryNumber.BackColor = System.Drawing.Color.Transparent
            Me.lblEntryNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEntryNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblEntryNumber.Location = New System.Drawing.Point(16, 20)
            Me.lblEntryNumber.Name = "lblEntryNumber"
            Me.lblEntryNumber.Size = New System.Drawing.Size(92, 23)
            Me.lblEntryNumber.TabIndex = 0
            Me.lblEntryNumber.Text = "Entry Number"
            Me.lblEntryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudEntryNumber
            '
            Me.nudEntryNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudEntryNumber.Enabled = False
            Me.nudEntryNumber.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudEntryNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudEntryNumber.Location = New System.Drawing.Point(114, 20)
            Me.nudEntryNumber.Name = "nudEntryNumber"
            Me.nudEntryNumber.Size = New System.Drawing.Size(94, 20)
            Me.nudEntryNumber.TabIndex = 1
            Me.nudEntryNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnGoToEntry
            '
            Me.btnGoToEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnGoToEntry.Enabled = False
            Me.btnGoToEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnGoToEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnGoToEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnGoToEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGoToEntry.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGoToEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnGoToEntry.Location = New System.Drawing.Point(218, 17)
            Me.btnGoToEntry.Name = "btnGoToEntry"
            Me.btnGoToEntry.Size = New System.Drawing.Size(64, 29)
            Me.btnGoToEntry.TabIndex = 2
            Me.btnGoToEntry.Text = "Go"
            Me.btnGoToEntry.UseVisualStyleBackColor = False
            '
            'btnFilter
            '
            Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnFilter.Enabled = False
            Me.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnFilter.Location = New System.Drawing.Point(296, 17)
            Me.btnFilter.Name = "btnFilter"
            Me.btnFilter.Size = New System.Drawing.Size(104, 29)
            Me.btnFilter.TabIndex = 3
            Me.btnFilter.Text = "Filter Entries"
            Me.btnFilter.UseVisualStyleBackColor = False
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
            Me.pnlHeader.Size = New System.Drawing.Size(718, 65)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 62)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(718, 3)
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
            Me.lblSubtitle.Location = New System.Drawing.Point(15, 37)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(680, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Browse, filter, edit, and export KotOR Dialog.tlk string entries."
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
            Me.lblTitle.Location = New System.Drawing.Point(13, -3)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(682, 40)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Dialog.Tlk Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miOpenExternal, Me.miOpenK1, Me.miOpenK2, Me.MenuItem3, Me.miSave, Me.miSaveAsXML, Me.MenuItem5, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miOpenExternal
            '
            Me.miOpenExternal.Index = 0
            Me.miOpenExternal.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenExternal.Text = "&Open External Dialog.tlk"
            '
            'miOpenK1
            '
            Me.miOpenK1.Index = 1
            Me.miOpenK1.Shortcut = System.Windows.Forms.Shortcut.Ctrl1
            Me.miOpenK1.Text = "Open KotOR Dialog.tlk"
            '
            'miOpenK2
            '
            Me.miOpenK2.Index = 2
            Me.miOpenK2.Shortcut = System.Windows.Forms.Shortcut.Ctrl2
            Me.miOpenK2.Text = "Open KotOR II Dialog.tlk"
            '
            'MenuItem3
            '
            Me.MenuItem3.Index = 3
            Me.MenuItem3.Text = "-"
            '
            'miSave
            '
            Me.miSave.Enabled = False
            Me.miSave.Index = 4
            Me.miSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "Save..."
            '
            'miSaveAsXML
            '
            Me.miSaveAsXML.Enabled = False
            Me.miSaveAsXML.Index = 5
            Me.miSaveAsXML.Text = "Save as XML..."
            '
            'MenuItem5
            '
            Me.MenuItem5.Index = 6
            Me.MenuItem5.Text = "-"
            '
            'miQuit
            '
            Me.miQuit.Index = 7
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'frmDialogTlk
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(720, 520)
            Me.Controls.Add(Me.pnlRoot)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New System.Drawing.Size(640, 531)
            Me.Name = "frmDialogTlk"
            Me.Text = "Dialog.Tlk Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgDialogTlk, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlEditor.ResumeLayout(False)
            Me.pnlEditor.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            CType(Me.nudEntryNumber, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace