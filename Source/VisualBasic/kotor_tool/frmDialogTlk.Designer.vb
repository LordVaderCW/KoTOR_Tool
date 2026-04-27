Namespace kotor_tool
	' Token: 0x02000048 RID: 72
	Public Partial Class frmDialogTlk
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
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


		' Token: 0x06000459 RID: 1113 RVA: 0x0023B698 File Offset: 0x0023A698
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x06000482 RID: 1154 RVA: 0x0023BD10 File Offset: 0x0023AD10
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.Panel1 = New Global.System.Windows.Forms.Panel()
            Me.dgDialogTlk = New Global.System.Windows.Forms.DataGrid()
            Me.tbString = New Global.System.Windows.Forms.TextBox()
            Me.nudEntryNumber = New Global.System.Windows.Forms.NumericUpDown()
            Me.btnGoToEntry = New Global.System.Windows.Forms.Button()
            Me.btnFilter = New Global.System.Windows.Forms.Button()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenExternal = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenK1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenK2 = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New Global.System.Windows.Forms.MenuItem()
            Me.miSave = New Global.System.Windows.Forms.MenuItem()
            Me.miSaveAsXML = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.tbSoundResRef = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.btnApplyChanges = New Global.System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            CType(Me.dgDialogTlk, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudEntryNumber, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.Controls.Add(Me.dgDialogTlk)
            Me.Panel1.Location = New Global.System.Drawing.Point(16, 24)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New Global.System.Drawing.Size(608, 200)
            Me.Panel1.TabIndex = 0
            Me.dgDialogTlk.CaptionFont = New Global.System.Drawing.Font("Lucida Console", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.dgDialogTlk.DataMember = ""
            Me.dgDialogTlk.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.dgDialogTlk.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Me.dgDialogTlk.Location = New Global.System.Drawing.Point(0, 0)
            Me.dgDialogTlk.Name = "dgDialogTlk"
            Me.dgDialogTlk.Size = New Global.System.Drawing.Size(608, 200)
            Me.dgDialogTlk.TabIndex = 0
            Me.tbString.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbString.Enabled = False
            Me.tbString.Location = New Global.System.Drawing.Point(144, 248)
            Me.tbString.Multiline = True
            Me.tbString.Name = "tbString"
            Me.tbString.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbString.Size = New Global.System.Drawing.Size(480, 112)
            Me.tbString.TabIndex = 3
            Me.tbString.Text = ""
            Me.nudEntryNumber.Enabled = False
            Me.nudEntryNumber.Location = New Global.System.Drawing.Point(160, 0)
            Me.nudEntryNumber.Name = "nudEntryNumber"
            Me.nudEntryNumber.Size = New Global.System.Drawing.Size(80, 20)
            Me.nudEntryNumber.TabIndex = 0
            Me.nudEntryNumber.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.btnGoToEntry.Enabled = False
            Me.btnGoToEntry.Location = New Global.System.Drawing.Point(248, 0)
            Me.btnGoToEntry.Name = "btnGoToEntry"
            Me.btnGoToEntry.Size = New Global.System.Drawing.Size(56, 23)
            Me.btnGoToEntry.TabIndex = 1
            Me.btnGoToEntry.Text = "Go"
            Me.btnFilter.Enabled = False
            Me.btnFilter.Location = New Global.System.Drawing.Point(360, 0)
            Me.btnFilter.Name = "btnFilter"
            Me.btnFilter.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnFilter.TabIndex = 2
            Me.btnFilter.Text = "Filter Entries"
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miOpenExternal, Me.miOpenK1, Me.miOpenK2, Me.MenuItem3, Me.miSave, Me.miSaveAsXML, Me.MenuItem5, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            Me.miOpenExternal.Index = 0
            Me.miOpenExternal.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenExternal.Text = "&Open External Dialog.tlk"
            Me.miOpenK1.Index = 1
            Me.miOpenK1.Shortcut = Global.System.Windows.Forms.Shortcut.Ctrl1
            Me.miOpenK1.Text = "Open KotOR Dialog.tlk"
            Me.miOpenK2.Index = 2
            Me.miOpenK2.Shortcut = Global.System.Windows.Forms.Shortcut.Ctrl2
            Me.miOpenK2.Text = "Open KotOR II Dialog.tlk"
            Me.MenuItem3.Index = 3
            Me.MenuItem3.Text = "-"
            Me.miSave.Enabled = False
            Me.miSave.Index = 4
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "Save..."
            Me.miSaveAsXML.Enabled = False
            Me.miSaveAsXML.Index = 5
            Me.miSaveAsXML.Text = "Save as XML..."
            Me.MenuItem5.Index = 6
            Me.MenuItem5.Text = "-"
            Me.miQuit.Index = 7
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            Me.tbSoundResRef.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tbSoundResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbSoundResRef.Enabled = False
            Me.tbSoundResRef.Location = New Global.System.Drawing.Point(144, 368)
            Me.tbSoundResRef.MaxLength = 16
            Me.tbSoundResRef.Name = "tbSoundResRef"
            Me.tbSoundResRef.TabIndex = 4
            Me.tbSoundResRef.Text = ""
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label1.Location = New Global.System.Drawing.Point(32, 256)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "Dialog Text"
            Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label3.Location = New Global.System.Drawing.Point(32, 370)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "SoundResRef"
            Me.btnApplyChanges.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnApplyChanges.Enabled = False
            Me.btnApplyChanges.Location = New Global.System.Drawing.Point(488, 368)
            Me.btnApplyChanges.Name = "btnApplyChanges"
            Me.btnApplyChanges.Size = New Global.System.Drawing.Size(96, 23)
            Me.btnApplyChanges.TabIndex = 5
            Me.btnApplyChanges.Text = "Apply Changes"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(640, 401)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.tbSoundResRef)
            Me.Controls.Add(Me.btnFilter)
            Me.Controls.Add(Me.btnGoToEntry)
            Me.Controls.Add(Me.nudEntryNumber)
            Me.Controls.Add(Me.tbString)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.btnApplyChanges)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmDialogTlk"
            Me.Text = "Dialog.Tlk Editor"
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgDialogTlk, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudEntryNumber, Global.System.ComponentModel.ISupportInitialize).EndInit()

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
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
