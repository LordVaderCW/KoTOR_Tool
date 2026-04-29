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
            Me.components = New Global.System.ComponentModel.Container()
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.Panel1 = New Global.System.Windows.Forms.Panel()
            Me.dgDialogTlk = New Global.System.Windows.Forms.DataGrid()
            Me.pnlEditor = New Global.System.Windows.Forms.Panel()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.tbString = New Global.System.Windows.Forms.TextBox()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.tbSoundResRef = New Global.System.Windows.Forms.TextBox()
            Me.btnApplyChanges = New Global.System.Windows.Forms.Button()
            Me.lblSeparatorBottom = New Global.System.Windows.Forms.Label()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.lblEntryNumber = New Global.System.Windows.Forms.Label()
            Me.nudEntryNumber = New Global.System.Windows.Forms.NumericUpDown()
            Me.btnGoToEntry = New Global.System.Windows.Forms.Button()
            Me.btnFilter = New Global.System.Windows.Forms.Button()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New Global.System.Windows.Forms.Label()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenExternal = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenK1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenK2 = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New Global.System.Windows.Forms.MenuItem()
            Me.miSave = New Global.System.Windows.Forms.MenuItem()
            Me.miSaveAsXML = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgDialogTlk, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlEditor.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            CType(Me.nudEntryNumber, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(720, 520)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.Panel1)
            Me.pnlBody.Controls.Add(Me.pnlEditor)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(14, 14, 14, 10)
            Me.pnlBody.Size = New Global.System.Drawing.Size(718, 388)
            Me.pnlBody.TabIndex = 1
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.Panel1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.dgDialogTlk)
            Me.Panel1.Location = New Global.System.Drawing.Point(14, 14)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New Global.System.Drawing.Size(690, 210)
            Me.Panel1.TabIndex = 0
            '
            'dgDialogTlk
            '
            Me.dgDialogTlk.AlternatingBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgDialogTlk.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgDialogTlk.BackgroundColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgDialogTlk.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
            Me.dgDialogTlk.CaptionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgDialogTlk.CaptionFont = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgDialogTlk.CaptionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgDialogTlk.CaptionText = "Dialog Entries"
            Me.dgDialogTlk.DataMember = ""
            Me.dgDialogTlk.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.dgDialogTlk.FlatMode = True
            Me.dgDialogTlk.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgDialogTlk.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgDialogTlk.GridLineColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dgDialogTlk.HeaderBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgDialogTlk.HeaderForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgDialogTlk.LinkColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgDialogTlk.Location = New Global.System.Drawing.Point(0, 0)
            Me.dgDialogTlk.Name = "dgDialogTlk"
            Me.dgDialogTlk.ParentRowsBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgDialogTlk.ParentRowsForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgDialogTlk.SelectionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgDialogTlk.SelectionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgDialogTlk.Size = New Global.System.Drawing.Size(688, 208)
            Me.dgDialogTlk.TabIndex = 0
            '
            'pnlEditor
            '
            Me.pnlEditor.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.pnlEditor.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlEditor.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlEditor.Controls.Add(Me.Label1)
            Me.pnlEditor.Controls.Add(Me.tbString)
            Me.pnlEditor.Controls.Add(Me.Label3)
            Me.pnlEditor.Controls.Add(Me.tbSoundResRef)
            Me.pnlEditor.Controls.Add(Me.btnApplyChanges)
            Me.pnlEditor.Location = New Global.System.Drawing.Point(14, 234)
            Me.pnlEditor.Name = "pnlEditor"
            Me.pnlEditor.Size = New Global.System.Drawing.Size(690, 134)
            Me.pnlEditor.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(14, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(96, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Dialog Text"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbString
            '
            Me.tbString.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbString.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbString.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbString.Enabled = False
            Me.tbString.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbString.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbString.Location = New Global.System.Drawing.Point(118, 14)
            Me.tbString.Multiline = True
            Me.tbString.Name = "tbString"
            Me.tbString.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbString.Size = New Global.System.Drawing.Size(552, 72)
            Me.tbString.TabIndex = 1
            Me.tbString.Text = ""
            '
            'Label3
            '
            Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label3.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label3.Location = New Global.System.Drawing.Point(14, 96)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(96, 18)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "SoundResRef"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbSoundResRef
            '
            Me.tbSoundResRef.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.tbSoundResRef.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbSoundResRef.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbSoundResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbSoundResRef.Enabled = False
            Me.tbSoundResRef.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbSoundResRef.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSoundResRef.Location = New Global.System.Drawing.Point(118, 96)
            Me.tbSoundResRef.MaxLength = 16
            Me.tbSoundResRef.Name = "tbSoundResRef"
            Me.tbSoundResRef.Size = New Global.System.Drawing.Size(176, 20)
            Me.tbSoundResRef.TabIndex = 3
            Me.tbSoundResRef.Text = ""
            '
            'btnApplyChanges
            '
            Me.btnApplyChanges.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnApplyChanges.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnApplyChanges.Enabled = False
            Me.btnApplyChanges.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnApplyChanges.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnApplyChanges.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnApplyChanges.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnApplyChanges.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnApplyChanges.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnApplyChanges.Location = New Global.System.Drawing.Point(548, 94)
            Me.btnApplyChanges.Name = "btnApplyChanges"
            Me.btnApplyChanges.Size = New Global.System.Drawing.Size(122, 25)
            Me.btnApplyChanges.TabIndex = 4
            Me.btnApplyChanges.Text = "Apply Changes"
            Me.btnApplyChanges.UseVisualStyleBackColor = False
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New Global.System.Drawing.Point(14, 376)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New Global.System.Drawing.Size(690, 2)
            Me.lblSeparatorBottom.TabIndex = 2
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblEntryNumber)
            Me.pnlFooter.Controls.Add(Me.nudEntryNumber)
            Me.pnlFooter.Controls.Add(Me.btnGoToEntry)
            Me.pnlFooter.Controls.Add(Me.btnFilter)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 464)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(718, 54)
            Me.pnlFooter.TabIndex = 2
            '
            'lblEntryNumber
            '
            Me.lblEntryNumber.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblEntryNumber.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEntryNumber.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblEntryNumber.Location = New Global.System.Drawing.Point(16, 17)
            Me.lblEntryNumber.Name = "lblEntryNumber"
            Me.lblEntryNumber.Size = New Global.System.Drawing.Size(92, 20)
            Me.lblEntryNumber.TabIndex = 0
            Me.lblEntryNumber.Text = "Entry Number"
            Me.lblEntryNumber.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudEntryNumber
            '
            Me.nudEntryNumber.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudEntryNumber.Enabled = False
            Me.nudEntryNumber.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudEntryNumber.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudEntryNumber.Location = New Global.System.Drawing.Point(114, 17)
            Me.nudEntryNumber.Name = "nudEntryNumber"
            Me.nudEntryNumber.Size = New Global.System.Drawing.Size(94, 20)
            Me.nudEntryNumber.TabIndex = 1
            Me.nudEntryNumber.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnGoToEntry
            '
            Me.btnGoToEntry.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnGoToEntry.Enabled = False
            Me.btnGoToEntry.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnGoToEntry.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnGoToEntry.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnGoToEntry.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnGoToEntry.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGoToEntry.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnGoToEntry.Location = New Global.System.Drawing.Point(218, 15)
            Me.btnGoToEntry.Name = "btnGoToEntry"
            Me.btnGoToEntry.Size = New Global.System.Drawing.Size(64, 25)
            Me.btnGoToEntry.TabIndex = 2
            Me.btnGoToEntry.Text = "Go"
            Me.btnGoToEntry.UseVisualStyleBackColor = False
            '
            'btnFilter
            '
            Me.btnFilter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnFilter.Enabled = False
            Me.btnFilter.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnFilter.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnFilter.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnFilter.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnFilter.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFilter.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnFilter.Location = New Global.System.Drawing.Point(296, 15)
            Me.btnFilter.Name = "btnFilter"
            Me.btnFilter.Size = New Global.System.Drawing.Size(104, 25)
            Me.btnFilter.TabIndex = 3
            Me.btnFilter.Text = "Filter Entries"
            Me.btnFilter.UseVisualStyleBackColor = False
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
            Me.pnlHeader.Size = New Global.System.Drawing.Size(718, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New Global.System.Drawing.Size(718, 2)
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
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(680, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Browse, filter, edit, and export KotOR Dialog.tlk string entries."
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
            Me.lblTitle.Size = New Global.System.Drawing.Size(682, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Dialog.Tlk Editor"
            Me.lblTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miOpenExternal, Me.miOpenK1, Me.miOpenK2, Me.MenuItem3, Me.miSave, Me.miSaveAsXML, Me.MenuItem5, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miOpenExternal
            '
            Me.miOpenExternal.Index = 0
            Me.miOpenExternal.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenExternal.Text = "&Open External Dialog.tlk"
            '
            'miOpenK1
            '
            Me.miOpenK1.Index = 1
            Me.miOpenK1.Shortcut = Global.System.Windows.Forms.Shortcut.Ctrl1
            Me.miOpenK1.Text = "Open KotOR Dialog.tlk"
            '
            'miOpenK2
            '
            Me.miOpenK2.Index = 2
            Me.miOpenK2.Shortcut = Global.System.Windows.Forms.Shortcut.Ctrl2
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
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
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
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'frmDialogTlk
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New Global.System.Drawing.Size(720, 520)
            Me.Controls.Add(Me.pnlRoot)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New Global.System.Drawing.Size(640, 460)
            Me.Name = "frmDialogTlk"
            Me.Text = "Dialog.Tlk Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgDialogTlk, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlEditor.ResumeLayout(False)
            Me.pnlEditor.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            CType(Me.nudEntryNumber, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHeader.ResumeLayout(False)

            AddHandler Me.dgDialogTlk.CurrentCellChanged, AddressOf Me.dgDialogTlk_CurrentCellChanged
            AddHandler Me.dgDialogTlk.Click, AddressOf Me.dgDialogTlk_Click
            AddHandler Me.nudEntryNumber.KeyUp, AddressOf Me.nudEntryNumber_KeyUp
            AddHandler Me.btnGoToEntry.Click, AddressOf Me.btnGoToEntry_Click
            AddHandler Me.btnFilter.Click, AddressOf Me.btnFilter_Click
            AddHandler Me.miOpenExternal.Click, AddressOf Me.miOpenExternal_Click
            AddHandler Me.miOpenK1.Click, AddressOf Me.miOpenK1_Click
            AddHandler Me.miOpenK2.Click, AddressOf Me.miOpenK2_Click
            AddHandler Me.miQuit.Click, AddressOf Me.miQuit_Click
            AddHandler Me.miSaveAsXML.Click, AddressOf Me.miSaveAsXML_Click
            AddHandler Me.miSave.Click, AddressOf Me.miSave_Click
            AddHandler Me.btnApplyChanges.Click, AddressOf Me.btnApplyChanges_Click

            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace