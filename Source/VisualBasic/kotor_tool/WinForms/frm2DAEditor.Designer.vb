Namespace kotor_tool

    Partial Public Class frm2DAEditor
        Inherits Global.System.Windows.Forms.Form

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents dg2DA As frm2DAEditor.TwoDADataGrid
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miLoad2da As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSave2daV2b As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSave2daV2bXML As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miResetSort As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miUndoAll As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miLoad2daXml As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem3 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSetKotORversion As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miTestFunction As Global.System.Windows.Forms.MenuItem

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubTitle As Global.System.Windows.Forms.Label
        Friend WithEvents pnlGridHost As Global.System.Windows.Forms.Panel
        Friend WithEvents lblBottomSeparator As Global.System.Windows.Forms.Label

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frm2DAEditor))

            Me.components = New Global.System.ComponentModel.Container()

            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.lblSubTitle = New Global.System.Windows.Forms.Label()
            Me.lblBottomSeparator = New Global.System.Windows.Forms.Label()
            Me.pnlGridHost = New Global.System.Windows.Forms.Panel()
            Me.dg2DA = New Global.kotor_tool.frm2DAEditor.TwoDADataGrid()

            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miLoad2da = New Global.System.Windows.Forms.MenuItem()
            Me.miLoad2daXml = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New Global.System.Windows.Forms.MenuItem()
            Me.miSave2daV2b = New Global.System.Windows.Forms.MenuItem()
            Me.miSave2daV2bXML = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.miResetSort = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New Global.System.Windows.Forms.MenuItem()
            Me.miUndoAll = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New Global.System.Windows.Forms.MenuItem()
            Me.miSetKotORversion = New Global.System.Windows.Forms.MenuItem()
            Me.miTestFunction = New Global.System.Windows.Forms.MenuItem()

            CType(Me.dg2DA, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlRoot.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.pnlGridHost.SuspendLayout()
            Me.SuspendLayout()

            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlGridHost)
            Me.pnlRoot.Controls.Add(Me.lblBottomSeparator)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Padding = New Global.System.Windows.Forms.Padding(10)
            Me.pnlRoot.Size = New Global.System.Drawing.Size(560, 409)
            Me.pnlRoot.TabIndex = 0

            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHeader.Controls.Add(Me.lblSubTitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New Global.System.Drawing.Point(10, 10)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New Global.System.Drawing.Size(540, 54)
            Me.pnlHeader.TabIndex = 1

            '
            'lblTitle
            '
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(10, 6)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(250, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "2DA EDITOR"
            Me.lblTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft

            '
            'lblSubTitle
            '
            Me.lblSubTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSubTitle.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubTitle.Location = New Global.System.Drawing.Point(12, 30)
            Me.lblSubTitle.Name = "lblSubTitle"
            Me.lblSubTitle.Size = New Global.System.Drawing.Size(500, 18)
            Me.lblSubTitle.TabIndex = 1
            Me.lblSubTitle.Text = "Edit KoTOR 2DA v2.b tables, XML exports, string references, and row data."
            Me.lblSubTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft

            '
            'lblBottomSeparator
            '
            Me.lblBottomSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblBottomSeparator.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.lblBottomSeparator.Location = New Global.System.Drawing.Point(10, 64)
            Me.lblBottomSeparator.Name = "lblBottomSeparator"
            Me.lblBottomSeparator.Size = New Global.System.Drawing.Size(540, 2)
            Me.lblBottomSeparator.TabIndex = 2

            '
            'pnlGridHost
            '
            Me.pnlGridHost.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlGridHost.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlGridHost.Controls.Add(Me.dg2DA)
            Me.pnlGridHost.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlGridHost.Location = New Global.System.Drawing.Point(10, 66)
            Me.pnlGridHost.Name = "pnlGridHost"
            Me.pnlGridHost.Padding = New Global.System.Windows.Forms.Padding(8)
            Me.pnlGridHost.Size = New Global.System.Drawing.Size(540, 333)
            Me.pnlGridHost.TabIndex = 3

            '
            'dg2DA
            '
            Me.dg2DA.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dg2DA.BackgroundColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dg2DA.CaptionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dg2DA.CaptionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.dg2DA.DataMember = ""
            Me.dg2DA.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.dg2DA.FlatMode = True
            Me.dg2DA.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dg2DA.GridLineColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dg2DA.HeaderBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.dg2DA.HeaderForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dg2DA.LinkColor = Global.System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.dg2DA.Location = New Global.System.Drawing.Point(8, 8)
            Me.dg2DA.Name = "dg2DA"
            Me.dg2DA.ParentRowsBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dg2DA.ParentRowsForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dg2DA.SelectionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dg2DA.SelectionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dg2DA.Size = New Global.System.Drawing.Size(522, 315)
            Me.dg2DA.TabIndex = 0

            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})

            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miLoad2da, Me.miLoad2daXml, Me.MenuItem6, Me.miSave2daV2b, Me.miSave2daV2bXML, Me.MenuItem5, Me.miQuit})
            Me.MenuItem1.Text = "File"

            '
            'miLoad2da
            '
            Me.miLoad2da.Index = 0
            Me.miLoad2da.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miLoad2da.Text = "Load 2DA v2.b file..."

            '
            'miLoad2daXml
            '
            Me.miLoad2daXml.Index = 1
            Me.miLoad2daXml.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlShiftO
            Me.miLoad2daXml.Text = "Load 2DA v2.b (XML) file..."

            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 2
            Me.MenuItem6.Text = "-"

            '
            'miSave2daV2b
            '
            Me.miSave2daV2b.Index = 3
            Me.miSave2daV2b.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave2daV2b.Text = "Save as 2DA v2.b..."

            '
            'miSave2daV2bXML
            '
            Me.miSave2daV2bXML.Index = 4
            Me.miSave2daV2bXML.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlShiftS
            Me.miSave2daV2bXML.Text = "Save as 2DA v2.b (XML) ..."

            '
            'MenuItem5
            '
            Me.MenuItem5.Index = 5
            Me.MenuItem5.Text = "-"

            '
            'miQuit
            '
            Me.miQuit.Index = 6
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "Quit"

            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miResetSort, Me.MenuItem4, Me.miUndoAll, Me.MenuItem3, Me.miSetKotORversion, Me.miTestFunction})
            Me.MenuItem2.Text = "Tools"

            '
            'miResetSort
            '
            Me.miResetSort.Index = 0
            Me.miResetSort.Shortcut = Global.System.Windows.Forms.Shortcut.F5
            Me.miResetSort.Text = "Reset Sort"

            '
            'MenuItem4
            '
            Me.MenuItem4.Index = 1
            Me.MenuItem4.Text = "-"

            '
            'miUndoAll
            '
            Me.miUndoAll.Index = 2
            Me.miUndoAll.Text = "Undo All Changes"

            '
            'MenuItem3
            '
            Me.MenuItem3.Index = 3
            Me.MenuItem3.Text = "-"

            '
            'miSetKotORversion
            '
            Me.miSetKotORversion.Index = 4
            Me.miSetKotORversion.Text = "Set KotOR version..."

            '
            'miTestFunction
            '
            Me.miTestFunction.Index = 5
            Me.miTestFunction.Text = "Test function"
            Me.miTestFunction.Visible = False

            '
            'frm2DAEditor
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New Global.System.Drawing.Size(560, 409)
            Me.Controls.Add(Me.pnlRoot)

            Try
                Me.Icon = My.Resources.koTOR_icn
            Catch
                Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            End Try

            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New Global.System.Drawing.Size(360, 260)
            Me.Name = "frm2DAEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "2DA Editor"

            CType(Me.dg2DA, Global.System.ComponentModel.ISupportInitialize).EndInit()

            AddHandler Me.dg2DA.MouseUp, AddressOf Me.dg_MouseUp
            AddHandler Me.miLoad2da.Click, AddressOf Me.miLoad2da_Click
            AddHandler Me.miSave2daV2b.Click, AddressOf Me.miSave2daV2b_Click
            AddHandler Me.miSave2daV2bXML.Click, AddressOf Me.miSave2daV2bXML_Click
            AddHandler Me.miQuit.Click, AddressOf Me.miQuit_Click
            AddHandler Me.miResetSort.Click, AddressOf Me.miResetSort_Click
            AddHandler Me.miUndoAll.Click, AddressOf Me.miUndoAll_Click
            AddHandler Me.miLoad2daXml.Click, AddressOf Me.miLoad2daXml_Click
            AddHandler Me.miSetKotORversion.Click, AddressOf Me.miSetKotORversion_Click
            AddHandler Me.miTestFunction.Click, AddressOf Me.miTestFunction_Click

            Me.pnlGridHost.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlRoot.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace