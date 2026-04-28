Namespace kotor_tool
	' Token: 0x0200003C RID: 60
	Public Partial Class frm2DAEditor
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
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


		' Token: 0x06000161 RID: 353 RVA: 0x00225B80 File Offset: 0x00224B80
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000184 RID: 388 RVA: 0x00226100 File Offset: 0x00225100
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frm2DAEditor))
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
            Me.SuspendLayout()
            Me.dg2DA.DataMember = ""
            Me.dg2DA.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.dg2DA.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Me.dg2DA.Location = New Global.System.Drawing.Point(0, 0)
            Me.dg2DA.Name = "dg2DA"
            Me.dg2DA.Size = New Global.System.Drawing.Size(560, 409)
            Me.dg2DA.TabIndex = 0
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miLoad2da, Me.miLoad2daXml, Me.MenuItem6, Me.miSave2daV2b, Me.miSave2daV2bXML, Me.MenuItem5, Me.miQuit})
            Me.MenuItem1.Text = "File"
            Me.miLoad2da.Index = 0
            Me.miLoad2da.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miLoad2da.Text = "Load 2DA v2.b file..."
            Me.miLoad2daXml.Index = 1
            Me.miLoad2daXml.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlShiftO
            Me.miLoad2daXml.Text = "Load 2DA v2.b (XML) file..."
            Me.MenuItem6.Index = 2
            Me.MenuItem6.Text = "-"
            Me.miSave2daV2b.Index = 3
            Me.miSave2daV2b.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave2daV2b.Text = "Save as 2DA v2.b..."
            Me.miSave2daV2bXML.Index = 4
            Me.miSave2daV2bXML.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlShiftS
            Me.miSave2daV2bXML.Text = "Save as 2DA v2.b (XML) ..."
            Me.MenuItem5.Index = 5
            Me.MenuItem5.Text = "-"
            Me.miQuit.Index = 6
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "Quit"
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miResetSort, Me.MenuItem4, Me.miUndoAll, Me.MenuItem3, Me.miSetKotORversion, Me.miTestFunction})
            Me.MenuItem2.Text = "Tools"
            Me.miResetSort.Index = 0
            Me.miResetSort.Shortcut = Global.System.Windows.Forms.Shortcut.F5
            Me.miResetSort.Text = "Reset Sort"
            Me.MenuItem4.Index = 1
            Me.MenuItem4.Text = "-"
            Me.miUndoAll.Index = 2
            Me.miUndoAll.Text = "Undo All Changes"
            Me.MenuItem3.Index = 3
            Me.MenuItem3.Text = "-"
            Me.miSetKotORversion.Index = 4
            Me.miSetKotORversion.Text = "Set KotOR version..."
            Me.miTestFunction.Index = 5
            Me.miTestFunction.Text = "Test function"
            Me.miTestFunction.Visible = False
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(560, 409)
            Me.Controls.Add(Me.dg2DA)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New Global.System.Drawing.Size(248, 184)
            Me.Name = "frm2DAEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "2DA Editor"
            CType(Me.dg2DA, Global.System.ComponentModel.ISupportInitialize).EndInit()

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
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
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
