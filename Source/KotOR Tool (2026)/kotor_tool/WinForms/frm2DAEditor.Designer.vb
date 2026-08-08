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
            Me.components = New System.ComponentModel.Container()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlGridHost = New System.Windows.Forms.Panel()
            Me.dg2DA = New kotor_tool.frm2DAEditor.TwoDADataGrid()
            Me.lblBottomSeparator = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubTitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miLoad2da = New System.Windows.Forms.MenuItem()
            Me.miLoad2daXml = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.miSave2daV2b = New System.Windows.Forms.MenuItem()
            Me.miSave2daV2bXML = New System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New System.Windows.Forms.MenuItem()
            Me.miResetSort = New System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New System.Windows.Forms.MenuItem()
            Me.miUndoAll = New System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New System.Windows.Forms.MenuItem()
            Me.miSetKotORversion = New System.Windows.Forms.MenuItem()
            Me.miTestFunction = New System.Windows.Forms.MenuItem()
            Me.pnlRoot.SuspendLayout()
            Me.pnlGridHost.SuspendLayout()
            CType(Me.dg2DA, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlGridHost)
            Me.pnlRoot.Controls.Add(Me.lblBottomSeparator)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlRoot.Size = New System.Drawing.Size(560, 572)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlGridHost
            '
            Me.pnlGridHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlGridHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlGridHost.Controls.Add(Me.dg2DA)
            Me.pnlGridHost.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGridHost.Location = New System.Drawing.Point(10, 66)
            Me.pnlGridHost.Name = "pnlGridHost"
            Me.pnlGridHost.Padding = New System.Windows.Forms.Padding(8)
            Me.pnlGridHost.Size = New System.Drawing.Size(540, 496)
            Me.pnlGridHost.TabIndex = 3
            '
            'dg2DA
            '
            Me.dg2DA.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dg2DA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dg2DA.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dg2DA.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.dg2DA.DataMember = ""
            Me.dg2DA.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dg2DA.FlatMode = True
            Me.dg2DA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dg2DA.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dg2DA.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.dg2DA.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dg2DA.LinkColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.dg2DA.Location = New System.Drawing.Point(8, 8)
            Me.dg2DA.Name = "dg2DA"
            Me.dg2DA.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dg2DA.ParentRowsForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dg2DA.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dg2DA.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dg2DA.Size = New System.Drawing.Size(522, 478)
            Me.dg2DA.TabIndex = 0
            '
            'lblBottomSeparator
            '
            Me.lblBottomSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblBottomSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblBottomSeparator.Location = New System.Drawing.Point(10, 64)
            Me.lblBottomSeparator.Name = "lblBottomSeparator"
            Me.lblBottomSeparator.Size = New System.Drawing.Size(540, 2)
            Me.lblBottomSeparator.TabIndex = 2
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHeader.Controls.Add(Me.lblSubTitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(10, 10)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(540, 54)
            Me.pnlHeader.TabIndex = 1
            '
            'lblSubTitle
            '
            Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubTitle.Location = New System.Drawing.Point(12, 30)
            Me.lblSubTitle.Name = "lblSubTitle"
            Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
            Me.lblSubTitle.TabIndex = 1
            Me.lblSubTitle.Text = "Edit KoTOR 2DA v2.b tables, XML exports, string references, and row data."
            Me.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(10, 6)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(250, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "2DA EDITOR"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miLoad2da, Me.miLoad2daXml, Me.MenuItem6, Me.miSave2daV2b, Me.miSave2daV2bXML, Me.MenuItem5, Me.miQuit})
            Me.MenuItem1.Text = "File"
            '
            'miLoad2da
            '
            Me.miLoad2da.Index = 0
            Me.miLoad2da.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miLoad2da.Text = "Load 2DA v2.b file..."
            '
            'miLoad2daXml
            '
            Me.miLoad2daXml.Index = 1
            Me.miLoad2daXml.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftO
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
            Me.miSave2daV2b.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.miSave2daV2b.Text = "Save as 2DA v2.b..."
            '
            'miSave2daV2bXML
            '
            Me.miSave2daV2bXML.Index = 4
            Me.miSave2daV2bXML.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
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
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "Quit"
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miResetSort, Me.MenuItem4, Me.miUndoAll, Me.MenuItem3, Me.miSetKotORversion, Me.miTestFunction})
            Me.MenuItem2.Text = "Tools"
            '
            'miResetSort
            '
            Me.miResetSort.Index = 0
            Me.miResetSort.Shortcut = System.Windows.Forms.Shortcut.F5
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
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(560, 572)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = Global.My.Resources.Resources.koTOR_icn
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New System.Drawing.Size(360, 260)
            Me.Name = "frm2DAEditor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "2DA Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlGridHost.ResumeLayout(False)
            CType(Me.dg2DA, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace