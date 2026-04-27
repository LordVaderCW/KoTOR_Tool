Namespace kotor_tool
	' Token: 0x02000048 RID: 72
	Public Partial Class frmDialogTlk
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000459 RID: 1113 RVA: 0x0023B698 File Offset: 0x0023A698
		Protected Overrides Sub Dispose(disposing As Boolean)
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
            Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(16, 24)
            panel.Location = point
            Me.Panel1.Name = "Panel1"
            Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(608, 200)
            panel2.Size = size
            Me.Panel1.TabIndex = 0
            Me.dgDialogTlk.CaptionFont = New Global.System.Drawing.Font("Lucida Console", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.dgDialogTlk.DataMember = ""
            Me.dgDialogTlk.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.dgDialogTlk.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Dim dgDialogTlk As Global.System.Windows.Forms.Control = Me.dgDialogTlk
            point = New Global.System.Drawing.Point(0, 0)
            dgDialogTlk.Location = point
            Me.dgDialogTlk.Name = "dgDialogTlk"
            Dim dgDialogTlk2 As Global.System.Windows.Forms.Control = Me.dgDialogTlk
            size = New Global.System.Drawing.Size(608, 200)
            dgDialogTlk2.Size = size
            Me.dgDialogTlk.TabIndex = 0
            Me.tbString.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbString.Enabled = False
            Dim tbString As Global.System.Windows.Forms.Control = Me.tbString
            point = New Global.System.Drawing.Point(144, 248)
            tbString.Location = point
            Me.tbString.Multiline = True
            Me.tbString.Name = "tbString"
            Me.tbString.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Dim tbString2 As Global.System.Windows.Forms.Control = Me.tbString
            size = New Global.System.Drawing.Size(480, 112)
            tbString2.Size = size
            Me.tbString.TabIndex = 3
            Me.tbString.Text = ""
            Me.nudEntryNumber.Enabled = False
            Dim nudEntryNumber As Global.System.Windows.Forms.Control = Me.nudEntryNumber
            point = New Global.System.Drawing.Point(160, 0)
            nudEntryNumber.Location = point
            Me.nudEntryNumber.Name = "nudEntryNumber"
            Dim nudEntryNumber2 As Global.System.Windows.Forms.Control = Me.nudEntryNumber
            size = New Global.System.Drawing.Size(80, 20)
            nudEntryNumber2.Size = size
            Me.nudEntryNumber.TabIndex = 0
            Me.nudEntryNumber.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.btnGoToEntry.Enabled = False
            Dim btnGoToEntry As Global.System.Windows.Forms.Control = Me.btnGoToEntry
            point = New Global.System.Drawing.Point(248, 0)
            btnGoToEntry.Location = point
            Me.btnGoToEntry.Name = "btnGoToEntry"
            Dim btnGoToEntry2 As Global.System.Windows.Forms.Control = Me.btnGoToEntry
            size = New Global.System.Drawing.Size(56, 23)
            btnGoToEntry2.Size = size
            Me.btnGoToEntry.TabIndex = 1
            Me.btnGoToEntry.Text = "Go"
            Me.btnFilter.Enabled = False
            Dim btnFilter As Global.System.Windows.Forms.Control = Me.btnFilter
            point = New Global.System.Drawing.Point(360, 0)
            btnFilter.Location = point
            Me.btnFilter.Name = "btnFilter"
            Dim btnFilter2 As Global.System.Windows.Forms.Control = Me.btnFilter
            size = New Global.System.Drawing.Size(80, 23)
            btnFilter2.Size = size
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
            Dim tbSoundResRef As Global.System.Windows.Forms.Control = Me.tbSoundResRef
            point = New Global.System.Drawing.Point(144, 368)
            tbSoundResRef.Location = point
            Me.tbSoundResRef.MaxLength = 16
            Me.tbSoundResRef.Name = "tbSoundResRef"
            Me.tbSoundResRef.TabIndex = 4
            Me.tbSoundResRef.Text = ""
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(32, 256)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(88, 16)
            label2.Size = size
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "Dialog Text"
            Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(32, 370)
            label3.Location = point
            Me.Label3.Name = "Label3"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(96, 16)
            label4.Size = size
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "SoundResRef"
            Me.btnApplyChanges.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnApplyChanges.Enabled = False
            Dim btnApplyChanges As Global.System.Windows.Forms.Control = Me.btnApplyChanges
            point = New Global.System.Drawing.Point(488, 368)
            btnApplyChanges.Location = point
            Me.btnApplyChanges.Name = "btnApplyChanges"
            Dim btnApplyChanges2 As Global.System.Windows.Forms.Control = Me.btnApplyChanges
            size = New Global.System.Drawing.Size(96, 23)
            btnApplyChanges2.Size = size
            Me.btnApplyChanges.TabIndex = 5
            Me.btnApplyChanges.Text = "Apply Changes"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(640, 401)
            Me.ClientSize = size
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
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000282 RID: 642
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
