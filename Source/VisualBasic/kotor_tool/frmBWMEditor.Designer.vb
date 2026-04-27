Namespace kotor_tool
	' Token: 0x02000042 RID: 66
	Public Partial Class frmBWMEditor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x0600027E RID: 638 RVA: 0x0022CFA4 File Offset: 0x0022BFA4
		Protected Overrides Sub Dispose(disposing As Boolean)
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
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
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
            Dim nudUnk2x As Global.System.Windows.Forms.Control = Me.nudUnk2x
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(96, 48)
            nudUnk2x.Location = point
            Dim nudUnk2x2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk2x
            Dim num As Decimal = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk2x2.Maximum = num
            Dim nudUnk2x3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk2x
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk2x3.Minimum = num
            Me.nudUnk2x.Name = "nudUnk2x"
            Dim nudUnk2x4 As Global.System.Windows.Forms.Control = Me.nudUnk2x
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(88, 20)
            nudUnk2x4.Size = size
            Me.nudUnk2x.TabIndex = 0
            Me.nudUnk2x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk2y.DecimalPlaces = 6
            Dim nudUnk2y As Global.System.Windows.Forms.Control = Me.nudUnk2y
            point = New Global.System.Drawing.Point(192, 48)
            nudUnk2y.Location = point
            Dim nudUnk2y2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk2y
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk2y2.Maximum = num
            Dim nudUnk2y3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk2y
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk2y3.Minimum = num
            Me.nudUnk2y.Name = "nudUnk2y"
            Dim nudUnk2y4 As Global.System.Windows.Forms.Control = Me.nudUnk2y
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk2y4.Size = size
            Me.nudUnk2y.TabIndex = 0
            Me.nudUnk2y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk2z.DecimalPlaces = 6
            Dim nudUnk2z As Global.System.Windows.Forms.Control = Me.nudUnk2z
            point = New Global.System.Drawing.Point(288, 48)
            nudUnk2z.Location = point
            Dim nudUnk2z2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk2z
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk2z2.Maximum = num
            Dim nudUnk2z3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk2z
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk2z3.Minimum = num
            Me.nudUnk2z.Name = "nudUnk2z"
            Dim nudUnk2z4 As Global.System.Windows.Forms.Control = Me.nudUnk2z
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk2z4.Size = size
            Me.nudUnk2z.TabIndex = 0
            Me.nudUnk2z.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk1.DecimalPlaces = 6
            Dim nudUnk As Global.System.Windows.Forms.Control = Me.nudUnk1
            point = New Global.System.Drawing.Point(96, 24)
            nudUnk.Location = point
            Dim nudUnk2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk1
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk2.Maximum = num
            Dim nudUnk3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk1
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk3.Minimum = num
            Me.nudUnk1.Name = "nudUnk1"
            Dim nudUnk4 As Global.System.Windows.Forms.Control = Me.nudUnk1
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk4.Size = size
            Me.nudUnk1.TabIndex = 0
            Me.nudUnk1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk3x.DecimalPlaces = 6
            Dim nudUnk3x As Global.System.Windows.Forms.Control = Me.nudUnk3x
            point = New Global.System.Drawing.Point(96, 72)
            nudUnk3x.Location = point
            Dim nudUnk3x2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk3x
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk3x2.Maximum = num
            Dim nudUnk3x3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk3x
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk3x3.Minimum = num
            Me.nudUnk3x.Name = "nudUnk3x"
            Dim nudUnk3x4 As Global.System.Windows.Forms.Control = Me.nudUnk3x
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk3x4.Size = size
            Me.nudUnk3x.TabIndex = 3
            Me.nudUnk3x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk3y.DecimalPlaces = 6
            Dim nudUnk3y As Global.System.Windows.Forms.Control = Me.nudUnk3y
            point = New Global.System.Drawing.Point(192, 72)
            nudUnk3y.Location = point
            Dim nudUnk3y2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk3y
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk3y2.Maximum = num
            Dim nudUnk3y3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk3y
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk3y3.Minimum = num
            Me.nudUnk3y.Name = "nudUnk3y"
            Dim nudUnk3y4 As Global.System.Windows.Forms.Control = Me.nudUnk3y
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk3y4.Size = size
            Me.nudUnk3y.TabIndex = 2
            Me.nudUnk3y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk3z.DecimalPlaces = 6
            Dim nudUnk3z As Global.System.Windows.Forms.Control = Me.nudUnk3z
            point = New Global.System.Drawing.Point(288, 72)
            nudUnk3z.Location = point
            Dim nudUnk3z2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk3z
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk3z2.Maximum = num
            Dim nudUnk3z3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk3z
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk3z3.Minimum = num
            Me.nudUnk3z.Name = "nudUnk3z"
            Dim nudUnk3z4 As Global.System.Windows.Forms.Control = Me.nudUnk3z
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk3z4.Size = size
            Me.nudUnk3z.TabIndex = 1
            Me.nudUnk3z.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk5x.DecimalPlaces = 6
            Dim nudUnk5x As Global.System.Windows.Forms.Control = Me.nudUnk5x
            point = New Global.System.Drawing.Point(96, 120)
            nudUnk5x.Location = point
            Dim nudUnk5x2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk5x
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk5x2.Maximum = num
            Dim nudUnk5x3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk5x
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk5x3.Minimum = num
            Me.nudUnk5x.Name = "nudUnk5x"
            Dim nudUnk5x4 As Global.System.Windows.Forms.Control = Me.nudUnk5x
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk5x4.Size = size
            Me.nudUnk5x.TabIndex = 3
            Me.nudUnk5x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk4x.DecimalPlaces = 6
            Dim nudUnk4x As Global.System.Windows.Forms.Control = Me.nudUnk4x
            point = New Global.System.Drawing.Point(96, 96)
            nudUnk4x.Location = point
            Dim nudUnk4x2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk4x
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk4x2.Maximum = num
            Dim nudUnk4x3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk4x
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk4x3.Minimum = num
            Me.nudUnk4x.Name = "nudUnk4x"
            Dim nudUnk4x4 As Global.System.Windows.Forms.Control = Me.nudUnk4x
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk4x4.Size = size
            Me.nudUnk4x.TabIndex = 0
            Me.nudUnk4x.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk5z.DecimalPlaces = 6
            Dim nudUnk5z As Global.System.Windows.Forms.Control = Me.nudUnk5z
            point = New Global.System.Drawing.Point(288, 120)
            nudUnk5z.Location = point
            Dim nudUnk5z2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk5z
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk5z2.Maximum = num
            Dim nudUnk5z3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk5z
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk5z3.Minimum = num
            Me.nudUnk5z.Name = "nudUnk5z"
            Dim nudUnk5z4 As Global.System.Windows.Forms.Control = Me.nudUnk5z
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk5z4.Size = size
            Me.nudUnk5z.TabIndex = 1
            Me.nudUnk5z.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk4y.DecimalPlaces = 6
            Dim nudUnk4y As Global.System.Windows.Forms.Control = Me.nudUnk4y
            point = New Global.System.Drawing.Point(192, 96)
            nudUnk4y.Location = point
            Dim nudUnk4y2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk4y
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk4y2.Maximum = num
            Dim nudUnk4y3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk4y
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk4y3.Minimum = num
            Me.nudUnk4y.Name = "nudUnk4y"
            Dim nudUnk4y4 As Global.System.Windows.Forms.Control = Me.nudUnk4y
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk4y4.Size = size
            Me.nudUnk4y.TabIndex = 0
            Me.nudUnk4y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk5y.DecimalPlaces = 6
            Dim nudUnk5y As Global.System.Windows.Forms.Control = Me.nudUnk5y
            point = New Global.System.Drawing.Point(192, 120)
            nudUnk5y.Location = point
            Dim nudUnk5y2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk5y
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk5y2.Maximum = num
            Dim nudUnk5y3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk5y
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk5y3.Minimum = num
            Me.nudUnk5y.Name = "nudUnk5y"
            Dim nudUnk5y4 As Global.System.Windows.Forms.Control = Me.nudUnk5y
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk5y4.Size = size
            Me.nudUnk5y.TabIndex = 2
            Me.nudUnk5y.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudUnk4z.DecimalPlaces = 6
            Dim nudUnk4z As Global.System.Windows.Forms.Control = Me.nudUnk4z
            point = New Global.System.Drawing.Point(288, 96)
            nudUnk4z.Location = point
            Dim nudUnk4z2 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk4z
            num = New Decimal(New Integer() {1000, 0, 0, 0})
            nudUnk4z2.Maximum = num
            Dim nudUnk4z3 As Global.System.Windows.Forms.NumericUpDown = Me.nudUnk4z
            num = New Decimal(New Integer() {1000, 0, 0, Integer.MinValue})
            nudUnk4z3.Minimum = num
            Me.nudUnk4z.Name = "nudUnk4z"
            Dim nudUnk4z4 As Global.System.Windows.Forms.Control = Me.nudUnk4z
            size = New Global.System.Drawing.Size(88, 20)
            nudUnk4z4.Size = size
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
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(24, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(56, 16)
            label2.Size = size
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "1"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(24, 48)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(56, 16)
            label4.Size = size
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "2"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(24, 72)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(56, 16)
            label6.Size = size
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "3"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(24, 96)
            label7.Location = point
            Me.Label4.Name = "Label4"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(56, 16)
            label8.Size = size
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "4"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(24, 120)
            label9.Location = point
            Me.Label5.Name = "Label5"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(56, 16)
            label10.Size = size
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "5"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.tbInfo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbInfo.Font = New Global.System.Drawing.Font("Courier New", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim tbInfo As Global.System.Windows.Forms.Control = Me.tbInfo
            point = New Global.System.Drawing.Point(56, 240)
            tbInfo.Location = point
            Me.tbInfo.Multiline = True
            Me.tbInfo.Name = "tbInfo"
            Me.tbInfo.[ReadOnly] = True
            Me.tbInfo.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Dim tbInfo2 As Global.System.Windows.Forms.Control = Me.tbInfo
            size = New Global.System.Drawing.Size(344, 200)
            tbInfo2.Size = size
            Me.tbInfo.TabIndex = 5
            Me.tbInfo.Text = ""
            Dim tbFilepath As Global.System.Windows.Forms.Control = Me.tbFilepath
            point = New Global.System.Drawing.Point(108, 8)
            tbFilepath.Location = point
            Me.tbFilepath.Name = "tbFilepath"
            Dim tbFilepath2 As Global.System.Windows.Forms.Control = Me.tbFilepath
            size = New Global.System.Drawing.Size(240, 20)
            tbFilepath2.Size = size
            Me.tbFilepath.TabIndex = 6
            Me.tbFilepath.Text = ""
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(32, 8)
            label11.Location = point
            Me.Label6.Name = "Label6"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(56, 16)
            label12.Size = size
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
            Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
            point = New Global.System.Drawing.Point(28, 64)
            groupBox.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
            size = New Global.System.Drawing.Size(400, 160)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 7
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Unknown data"
            Me.ToolTip1.SetToolTip(Me.GroupBox1, "This box contains data the purpose of which is unknown. You can edit these values and see what effect they have in the game.")
            Dim lblNotSupported As Global.System.Windows.Forms.Control = Me.lblNotSupported
            point = New Global.System.Drawing.Point(120, 40)
            lblNotSupported.Location = point
            Me.lblNotSupported.Name = "lblNotSupported"
            Dim lblNotSupported2 As Global.System.Windows.Forms.Control = Me.lblNotSupported
            size = New Global.System.Drawing.Size(216, 16)
            lblNotSupported2.Size = size
            Me.lblNotSupported.TabIndex = 8
            Me.lblNotSupported.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(456, 457)
            Me.ClientSize = size
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
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040001C0 RID: 448
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
