Option Strict Off
Option Explicit On

Imports System.Windows.Forms

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmBWMEditor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' frmBWMEditor.Designer.vb
        '
        ' Restored / facelifted PWK/DWK Editor for the KoTOR Tool Restoration.
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

        Friend WithEvents nudUnk2x As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk2y As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk2z As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk1 As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk3x As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk3y As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk3z As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk5x As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk4x As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk5z As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk4y As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk5y As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudUnk4z As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenBinary As Global.System.Windows.Forms.MenuItem
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents miOpenAscii As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tbInfo As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbFilepath As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents ToolTip1 As Global.System.Windows.Forms.ToolTip
        Friend WithEvents miSaveAsBinary As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSaveAsASCII As Global.System.Windows.Forms.MenuItem
        Friend WithEvents lblNotSupported As Global.System.Windows.Forms.Label

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFile As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlInfo As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label
        Friend WithEvents lblInfoTitle As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.pnlInfo = New System.Windows.Forms.Panel()
            Me.tbInfo = New System.Windows.Forms.TextBox()
            Me.lblInfoTitle = New System.Windows.Forms.Label()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.nudUnk3y = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk3x = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk1 = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk2z = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk2y = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk2x = New System.Windows.Forms.NumericUpDown()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.nudUnk4z = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk5y = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk4y = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk5z = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk4x = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk5x = New System.Windows.Forms.NumericUpDown()
            Me.nudUnk3z = New System.Windows.Forms.NumericUpDown()
            Me.lblNotSupported = New System.Windows.Forms.Label()
            Me.pnlFile = New System.Windows.Forms.Panel()
            Me.tbFilepath = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miOpenBinary = New System.Windows.Forms.MenuItem()
            Me.miOpenAscii = New System.Windows.Forms.MenuItem()
            Me.miSaveAsBinary = New System.Windows.Forms.MenuItem()
            Me.miSaveAsASCII = New System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlInfo.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.nudUnk3y, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk3x, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk2z, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk2y, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk2x, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk4z, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk5y, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk4y, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk5z, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk4x, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk5x, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk3z, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFile.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFile)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(456, 582)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.pnlInfo)
            Me.pnlBody.Controls.Add(Me.GroupBox1)
            Me.pnlBody.Controls.Add(Me.lblNotSupported)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 140)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(18, 14, 18, 14)
            Me.pnlBody.Size = New System.Drawing.Size(454, 440)
            Me.pnlBody.TabIndex = 2
            '
            'pnlInfo
            '
            Me.pnlInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlInfo.Controls.Add(Me.tbInfo)
            Me.pnlInfo.Controls.Add(Me.lblInfoTitle)
            Me.pnlInfo.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlInfo.Location = New System.Drawing.Point(28, 198)
            Me.pnlInfo.Name = "pnlInfo"
            Me.pnlInfo.Padding = New System.Windows.Forms.Padding(12, 28, 12, 12)
            Me.pnlInfo.Size = New System.Drawing.Size(400, 225)
            Me.pnlInfo.TabIndex = 5
            '
            'tbInfo
            '
            Me.tbInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbInfo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbInfo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbInfo.Location = New System.Drawing.Point(12, 28)
            Me.tbInfo.Multiline = True
            Me.tbInfo.Name = "tbInfo"
            Me.tbInfo.ReadOnly = True
            Me.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbInfo.Size = New System.Drawing.Size(374, 181)
            Me.tbInfo.TabIndex = 5
            '
            'lblInfoTitle
            '
            Me.lblInfoTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblInfoTitle.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblInfoTitle.Location = New System.Drawing.Point(12, 28)
            Me.lblInfoTitle.Name = "lblInfoTitle"
            Me.lblInfoTitle.Size = New System.Drawing.Size(374, 0)
            Me.lblInfoTitle.TabIndex = 6
            Me.lblInfoTitle.Text = "File Information"
            Me.lblInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(12, 209)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(374, 2)
            Me.lblSeparatorBottom.TabIndex = 7
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.GroupBox1.Controls.Add(Me.nudUnk3y)
            Me.GroupBox1.Controls.Add(Me.nudUnk3x)
            Me.GroupBox1.Controls.Add(Me.nudUnk1)
            Me.GroupBox1.Controls.Add(Me.nudUnk2z)
            Me.GroupBox1.Controls.Add(Me.nudUnk2y)
            Me.GroupBox1.Controls.Add(Me.nudUnk2x)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.nudUnk4z)
            Me.GroupBox1.Controls.Add(Me.nudUnk5y)
            Me.GroupBox1.Controls.Add(Me.nudUnk4y)
            Me.GroupBox1.Controls.Add(Me.nudUnk5z)
            Me.GroupBox1.Controls.Add(Me.nudUnk4x)
            Me.GroupBox1.Controls.Add(Me.nudUnk5x)
            Me.GroupBox1.Controls.Add(Me.nudUnk3z)
            Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox1.Location = New System.Drawing.Point(28, 20)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(400, 166)
            Me.GroupBox1.TabIndex = 7
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Unknown data"
            Me.ToolTip1.SetToolTip(Me.GroupBox1, "This box contains data the purpose of which is unknown. You can edit these values" &
        " and see what effect they have in the game.")
            '
            'nudUnk3y
            '
            Me.nudUnk3y.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk3y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk3y.DecimalPlaces = 6
            Me.nudUnk3y.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk3y.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk3y.Location = New System.Drawing.Point(192, 79)
            Me.nudUnk3y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk3y.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk3y.Name = "nudUnk3y"
            Me.nudUnk3y.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk3y.TabIndex = 2
            Me.nudUnk3y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk3x
            '
            Me.nudUnk3x.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk3x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk3x.DecimalPlaces = 6
            Me.nudUnk3x.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk3x.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk3x.Location = New System.Drawing.Point(96, 79)
            Me.nudUnk3x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk3x.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk3x.Name = "nudUnk3x"
            Me.nudUnk3x.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk3x.TabIndex = 3
            Me.nudUnk3x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk1
            '
            Me.nudUnk1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk1.DecimalPlaces = 6
            Me.nudUnk1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk1.Location = New System.Drawing.Point(96, 25)
            Me.nudUnk1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk1.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk1.Name = "nudUnk1"
            Me.nudUnk1.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk1.TabIndex = 0
            Me.nudUnk1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk2z
            '
            Me.nudUnk2z.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk2z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk2z.DecimalPlaces = 6
            Me.nudUnk2z.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk2z.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk2z.Location = New System.Drawing.Point(288, 52)
            Me.nudUnk2z.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk2z.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk2z.Name = "nudUnk2z"
            Me.nudUnk2z.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk2z.TabIndex = 0
            Me.nudUnk2z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk2y
            '
            Me.nudUnk2y.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk2y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk2y.DecimalPlaces = 6
            Me.nudUnk2y.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk2y.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk2y.Location = New System.Drawing.Point(192, 52)
            Me.nudUnk2y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk2y.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk2y.Name = "nudUnk2y"
            Me.nudUnk2y.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk2y.TabIndex = 0
            Me.nudUnk2y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk2x
            '
            Me.nudUnk2x.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk2x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk2x.DecimalPlaces = 6
            Me.nudUnk2x.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk2x.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk2x.Location = New System.Drawing.Point(96, 52)
            Me.nudUnk2x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk2x.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk2x.Name = "nudUnk2x"
            Me.nudUnk2x.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk2x.TabIndex = 0
            Me.nudUnk2x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(24, 25)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(56, 18)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "1"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(24, 52)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(56, 19)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "2"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(24, 79)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(56, 19)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "3"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(24, 106)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(56, 18)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "4"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(24, 133)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(56, 19)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "5"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'nudUnk4z
            '
            Me.nudUnk4z.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk4z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk4z.DecimalPlaces = 6
            Me.nudUnk4z.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk4z.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk4z.Location = New System.Drawing.Point(288, 106)
            Me.nudUnk4z.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk4z.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk4z.Name = "nudUnk4z"
            Me.nudUnk4z.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk4z.TabIndex = 0
            Me.nudUnk4z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk5y
            '
            Me.nudUnk5y.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk5y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk5y.DecimalPlaces = 6
            Me.nudUnk5y.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk5y.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk5y.Location = New System.Drawing.Point(192, 133)
            Me.nudUnk5y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk5y.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk5y.Name = "nudUnk5y"
            Me.nudUnk5y.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk5y.TabIndex = 2
            Me.nudUnk5y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk4y
            '
            Me.nudUnk4y.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk4y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk4y.DecimalPlaces = 6
            Me.nudUnk4y.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk4y.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk4y.Location = New System.Drawing.Point(192, 106)
            Me.nudUnk4y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk4y.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk4y.Name = "nudUnk4y"
            Me.nudUnk4y.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk4y.TabIndex = 0
            Me.nudUnk4y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk5z
            '
            Me.nudUnk5z.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk5z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk5z.DecimalPlaces = 6
            Me.nudUnk5z.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk5z.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk5z.Location = New System.Drawing.Point(288, 133)
            Me.nudUnk5z.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk5z.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk5z.Name = "nudUnk5z"
            Me.nudUnk5z.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk5z.TabIndex = 1
            Me.nudUnk5z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk4x
            '
            Me.nudUnk4x.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk4x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk4x.DecimalPlaces = 6
            Me.nudUnk4x.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk4x.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk4x.Location = New System.Drawing.Point(96, 106)
            Me.nudUnk4x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk4x.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk4x.Name = "nudUnk4x"
            Me.nudUnk4x.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk4x.TabIndex = 0
            Me.nudUnk4x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk5x
            '
            Me.nudUnk5x.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk5x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk5x.DecimalPlaces = 6
            Me.nudUnk5x.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk5x.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk5x.Location = New System.Drawing.Point(96, 133)
            Me.nudUnk5x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk5x.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk5x.Name = "nudUnk5x"
            Me.nudUnk5x.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk5x.TabIndex = 3
            Me.nudUnk5x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudUnk3z
            '
            Me.nudUnk3z.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudUnk3z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.nudUnk3z.DecimalPlaces = 6
            Me.nudUnk3z.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudUnk3z.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudUnk3z.Location = New System.Drawing.Point(288, 79)
            Me.nudUnk3z.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk3z.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.nudUnk3z.Name = "nudUnk3z"
            Me.nudUnk3z.Size = New System.Drawing.Size(88, 20)
            Me.nudUnk3z.TabIndex = 1
            Me.nudUnk3z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNotSupported
            '
            Me.lblNotSupported.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblNotSupported.BackColor = System.Drawing.Color.Transparent
            Me.lblNotSupported.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNotSupported.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblNotSupported.Location = New System.Drawing.Point(112, 4)
            Me.lblNotSupported.Name = "lblNotSupported"
            Me.lblNotSupported.Size = New System.Drawing.Size(232, 18)
            Me.lblNotSupported.TabIndex = 8
            Me.lblNotSupported.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlFile
            '
            Me.pnlFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFile.Controls.Add(Me.tbFilepath)
            Me.pnlFile.Controls.Add(Me.Label6)
            Me.pnlFile.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlFile.Location = New System.Drawing.Point(0, 88)
            Me.pnlFile.Name = "pnlFile"
            Me.pnlFile.Size = New System.Drawing.Size(454, 52)
            Me.pnlFile.TabIndex = 1
            '
            'tbFilepath
            '
            Me.tbFilepath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbFilepath.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbFilepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFilepath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbFilepath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFilepath.Location = New System.Drawing.Point(108, 15)
            Me.tbFilepath.Name = "tbFilepath"
            Me.tbFilepath.Size = New System.Drawing.Size(320, 22)
            Me.tbFilepath.TabIndex = 6
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(28, 15)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(72, 22)
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "File name"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
            Me.pnlHeader.Size = New System.Drawing.Size(454, 88)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 85)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(454, 3)
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
            Me.lblSubtitle.Size = New System.Drawing.Size(418, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Open, inspect, and save walkmesh PWK/DWK unknown data values."
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
            Me.lblTitle.Size = New System.Drawing.Size(420, 39)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "PWK/DWK Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miOpenBinary, Me.miOpenAscii, Me.miSaveAsBinary, Me.miSaveAsASCII, Me.MenuItem4, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miOpenBinary
            '
            Me.miOpenBinary.Index = 0
            Me.miOpenBinary.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenBinary.Text = "&Open Binary PWK..."
            '
            'miOpenAscii
            '
            Me.miOpenAscii.Index = 1
            Me.miOpenAscii.Text = "Open &ASCII PWK..."
            '
            'miSaveAsBinary
            '
            Me.miSaveAsBinary.Enabled = False
            Me.miSaveAsBinary.Index = 2
            Me.miSaveAsBinary.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.miSaveAsBinary.Text = "&Save as Binary..."
            '
            'miSaveAsASCII
            '
            Me.miSaveAsASCII.Enabled = False
            Me.miSaveAsASCII.Index = 3
            Me.miSaveAsASCII.Text = "Save as AS&CII..."
            '
            'MenuItem4
            '
            Me.MenuItem4.Index = 4
            Me.MenuItem4.Text = "-"
            '
            'miQuit
            '
            Me.miQuit.Index = 5
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'frmBWMEditor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(456, 582)
            Me.Controls.Add(Me.pnlRoot)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmBWMEditor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "PWK/DWK Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlInfo.ResumeLayout(False)
            Me.pnlInfo.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.nudUnk3y, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk3x, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk2z, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk2y, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk2x, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk4z, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk5y, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk4y, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk5z, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk4x, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk5x, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk3z, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFile.ResumeLayout(False)
            Me.pnlFile.PerformLayout()
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace