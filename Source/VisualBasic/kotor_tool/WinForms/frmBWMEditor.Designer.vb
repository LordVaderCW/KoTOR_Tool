Imports System.Windows.Forms


Namespace kotor_tool
    ' Token: 0x02000042 RID: 66
    Partial Public Class frmBWMEditor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
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
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents miSaveAsBinary As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSaveAsASCII As Global.System.Windows.Forms.MenuItem
        Friend WithEvents lblNotSupported As Global.System.Windows.Forms.Label


        ' Token: 0x0600027E RID: 638 RVA: 0x0022CFA4 File Offset: 0x0022BFA4
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x060002BF RID: 703 RVA: 0x0022D6DC File Offset: 0x0022C6DC
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Me.nudUnk2x = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk2y = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk2z = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk1 = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk3x = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk3y = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk3z = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk5x = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk4x = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk5z = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk4y = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk5y = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudUnk4z = New Global.System.Windows.Forms.NumericUpDown()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenBinary = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenAscii = New Global.System.Windows.Forms.MenuItem()
            Me.miSaveAsBinary = New Global.System.Windows.Forms.MenuItem()
            Me.miSaveAsASCII = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.tbInfo = New Global.System.Windows.Forms.TextBox()
            Me.tbFilepath = New Global.System.Windows.Forms.TextBox()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip()
            Me.lblNotSupported = New Global.System.Windows.Forms.Label()
            CType(Me.nudUnk2x, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk2y, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk2z, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk3x, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk3y, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk3z, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk5x, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk4x, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk5z, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk4y, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk5y, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudUnk4z, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            Me.nudUnk2x.DecimalPlaces = 6
            Me.nudUnk2x.Location = New Global.System.Drawing.Point(96, 48)
            Me.nudUnk2x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk2x.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk2x.Name = "nudUnk2x"
            Me.nudUnk2x.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk2x.TabIndex = 0
            Me.nudUnk2x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk2y.DecimalPlaces = 6
            Me.nudUnk2y.Location = New Global.System.Drawing.Point(192, 48)
            Me.nudUnk2y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk2y.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk2y.Name = "nudUnk2y"
            Me.nudUnk2y.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk2y.TabIndex = 0
            Me.nudUnk2y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk2z.DecimalPlaces = 6
            Me.nudUnk2z.Location = New Global.System.Drawing.Point(288, 48)
            Me.nudUnk2z.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk2z.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk2z.Name = "nudUnk2z"
            Me.nudUnk2z.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk2z.TabIndex = 0
            Me.nudUnk2z.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk1.DecimalPlaces = 6
            Me.nudUnk1.Location = New Global.System.Drawing.Point(96, 24)
            Me.nudUnk1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk1.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk1.Name = "nudUnk1"
            Me.nudUnk1.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk1.TabIndex = 0
            Me.nudUnk1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk3x.DecimalPlaces = 6
            Me.nudUnk3x.Location = New Global.System.Drawing.Point(96, 72)
            Me.nudUnk3x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk3x.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk3x.Name = "nudUnk3x"
            Me.nudUnk3x.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk3x.TabIndex = 3
            Me.nudUnk3x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk3y.DecimalPlaces = 6
            Me.nudUnk3y.Location = New Global.System.Drawing.Point(192, 72)
            Me.nudUnk3y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk3y.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk3y.Name = "nudUnk3y"
            Me.nudUnk3y.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk3y.TabIndex = 2
            Me.nudUnk3y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk3z.DecimalPlaces = 6
            Me.nudUnk3z.Location = New Global.System.Drawing.Point(288, 72)
            Me.nudUnk3z.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk3z.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk3z.Name = "nudUnk3z"
            Me.nudUnk3z.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk3z.TabIndex = 1
            Me.nudUnk3z.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk5x.DecimalPlaces = 6
            Me.nudUnk5x.Location = New Global.System.Drawing.Point(96, 120)
            Me.nudUnk5x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk5x.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk5x.Name = "nudUnk5x"
            Me.nudUnk5x.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk5x.TabIndex = 3
            Me.nudUnk5x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk4x.DecimalPlaces = 6
            Me.nudUnk4x.Location = New Global.System.Drawing.Point(96, 96)
            Me.nudUnk4x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk4x.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk4x.Name = "nudUnk4x"
            Me.nudUnk4x.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk4x.TabIndex = 0
            Me.nudUnk4x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk5z.DecimalPlaces = 6
            Me.nudUnk5z.Location = New Global.System.Drawing.Point(288, 120)
            Me.nudUnk5z.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk5z.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk5z.Name = "nudUnk5z"
            Me.nudUnk5z.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk5z.TabIndex = 1
            Me.nudUnk5z.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk4y.DecimalPlaces = 6
            Me.nudUnk4y.Location = New Global.System.Drawing.Point(192, 96)
            Me.nudUnk4y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk4y.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk4y.Name = "nudUnk4y"
            Me.nudUnk4y.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk4y.TabIndex = 0
            Me.nudUnk4y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk5y.DecimalPlaces = 6
            Me.nudUnk5y.Location = New Global.System.Drawing.Point(192, 120)
            Me.nudUnk5y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk5y.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk5y.Name = "nudUnk5y"
            Me.nudUnk5y.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk5y.TabIndex = 2
            Me.nudUnk5y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk4z.DecimalPlaces = 6
            Me.nudUnk4z.Location = New Global.System.Drawing.Point(288, 96)
            Me.nudUnk4z.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudUnk4z.Minimum = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            Me.nudUnk4z.Name = "nudUnk4z"
            Me.nudUnk4z.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudUnk4z.TabIndex = 0
            Me.nudUnk4z.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miOpenBinary, Me.miOpenAscii, Me.miSaveAsBinary, Me.miSaveAsASCII, Me.MenuItem4, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            Me.miOpenBinary.Index = 0
            Me.miOpenBinary.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenBinary.Text = "&Open Binary PWK..."
            Me.miOpenAscii.Index = 1
            Me.miOpenAscii.Text = "Open &ASCII PWK..."
            Me.miSaveAsBinary.Enabled = False
            Me.miSaveAsBinary.Index = 2
            Me.miSaveAsBinary.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSaveAsBinary.Text = "&Save as Binary..."
            Me.miSaveAsASCII.Enabled = False
            Me.miSaveAsASCII.Index = 3
            Me.miSaveAsASCII.Text = "Save as AS&CII..."
            Me.MenuItem4.Index = 4
            Me.MenuItem4.Text = "-"
            Me.miQuit.Index = 5
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            Me.Label1.Location = New Global.System.Drawing.Point(24, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(56, 16)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "1"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label2.Location = New Global.System.Drawing.Point(24, 48)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(56, 16)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "2"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label3.Location = New Global.System.Drawing.Point(24, 72)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(56, 16)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "3"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label4.Location = New Global.System.Drawing.Point(24, 96)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(56, 16)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "4"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label5.Location = New Global.System.Drawing.Point(24, 120)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(56, 16)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "5"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.tbInfo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbInfo.Font = New Global.System.Drawing.Font("Courier New", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.tbInfo.Location = New Global.System.Drawing.Point(56, 240)
            Me.tbInfo.Multiline = True
            Me.tbInfo.Name = "tbInfo"
            Me.tbInfo.[ReadOnly] = True
            Me.tbInfo.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbInfo.Size = New Global.System.Drawing.Size(344, 200)
            Me.tbInfo.TabIndex = 5
            Me.tbInfo.Text = ""
            Me.tbFilepath.Location = New Global.System.Drawing.Point(108, 8)
            Me.tbFilepath.Name = "tbFilepath"
            Me.tbFilepath.Size = New Global.System.Drawing.Size(240, 20)
            Me.tbFilepath.TabIndex = 6
            Me.tbFilepath.Text = ""
            Me.Label6.Location = New Global.System.Drawing.Point(32, 8)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(56, 16)
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "File name"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
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
            Me.GroupBox1.Location = New Global.System.Drawing.Point(28, 64)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New Global.System.Drawing.Size(400, 160)
            Me.GroupBox1.TabIndex = 7
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Unknown data"
            Me.ToolTip1.SetToolTip(Me.GroupBox1, "This box contains data the purpose of which is unknown. You can edit these values and see what effect they have in the game.")
            Me.lblNotSupported.Location = New Global.System.Drawing.Point(120, 40)
            Me.lblNotSupported.Name = "lblNotSupported"
            Me.lblNotSupported.Size = New Global.System.Drawing.Size(216, 16)
            Me.lblNotSupported.TabIndex = 8
            Me.lblNotSupported.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(456, 457)
            Me.Controls.Add(Me.lblNotSupported)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.tbFilepath)
            Me.Controls.Add(Me.tbInfo)
            Me.Controls.Add(Me.Label6)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmBWMEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "PWK/DWK Editor"
            CType(Me.nudUnk2x, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk2y, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk2z, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk1, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk3x, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk3y, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk3z, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk5x, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk4x, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk5z, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk4y, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk5y, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudUnk4z, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.miQuit.Click, AddressOf Me.miQuit_Click
            AddHandler Me.miOpenBinary.Click, AddressOf Me.miOpenBinary_Click
            AddHandler Me.miOpenAscii.Click, AddressOf Me.miOpenAscii_Click
            AddHandler Me.miSaveAsBinary.Click, AddressOf Me.miSaveAsBinary_Click
            AddHandler Me.miSaveAsASCII.Click, AddressOf Me.miSaveAsASCII_Click
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace
