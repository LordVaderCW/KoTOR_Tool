Namespace kotor_tool
	' Token: 0x02000073 RID: 115
	Public Partial Class frmSoundChooser
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents btnPlaySound As Global.System.Windows.Forms.Button
        Friend WithEvents btnStopSound As Global.System.Windows.Forms.Button
        Friend WithEvents lbSounds As Global.System.Windows.Forms.ListBox
        Friend WithEvents chkbLookSoundsBif As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbLookStreamSounds As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tbFilter As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbxFilter As Global.System.Windows.Forms.ComboBox
        Friend WithEvents lblSoundCount As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label


		' Token: 0x06000EDB RID: 3803 RVA: 0x002911D4 File Offset: 0x002901D4
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000EF6 RID: 3830 RVA: 0x002915EC File Offset: 0x002905EC
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmSoundChooser))
            Me.btnPlaySound = New Global.System.Windows.Forms.Button()
            Me.btnStopSound = New Global.System.Windows.Forms.Button()
            Me.lbSounds = New Global.System.Windows.Forms.ListBox()
            Me.chkbLookSoundsBif = New Global.System.Windows.Forms.CheckBox()
            Me.chkbLookStreamSounds = New Global.System.Windows.Forms.CheckBox()
            Me.tbFilter = New Global.System.Windows.Forms.TextBox()
            Me.cmbxFilter = New Global.System.Windows.Forms.ComboBox()
            Me.lblSoundCount = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.btnPlaySound.Enabled = False
            Me.btnPlaySound.Location = New Global.System.Drawing.Point(184, 8)
            Me.btnPlaySound.Name = "btnPlaySound"
            Me.btnPlaySound.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnPlaySound.TabIndex = 21
            Me.btnPlaySound.Text = "Play Sound"
            Me.btnStopSound.Enabled = False
            Me.btnStopSound.Location = New Global.System.Drawing.Point(272, 8)
            Me.btnStopSound.Name = "btnStopSound"
            Me.btnStopSound.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnStopSound.TabIndex = 20
            Me.btnStopSound.Text = "Stop"
            Me.lbSounds.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lbSounds.Location = New Global.System.Drawing.Point(16, 40)
            Me.lbSounds.MultiColumn = True
            Me.lbSounds.Name = "lbSounds"
            Me.lbSounds.SelectionMode = Global.System.Windows.Forms.SelectionMode.MultiExtended
            Me.lbSounds.Size = New Global.System.Drawing.Size(496, 160)
            Me.lbSounds.TabIndex = 22
            Me.chkbLookSoundsBif.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.chkbLookSoundsBif.Checked = True
            Me.chkbLookSoundsBif.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbLookSoundsBif.Location = New Global.System.Drawing.Point(32, 240)
            Me.chkbLookSoundsBif.Name = "chkbLookSoundsBif"
            Me.chkbLookSoundsBif.Size = New Global.System.Drawing.Size(104, 16)
            Me.chkbLookSoundsBif.TabIndex = 23
            Me.chkbLookSoundsBif.Text = "Sounds.bif"
            Me.chkbLookStreamSounds.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.chkbLookStreamSounds.Checked = True
            Me.chkbLookStreamSounds.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbLookStreamSounds.Location = New Global.System.Drawing.Point(32, 264)
            Me.chkbLookStreamSounds.Name = "chkbLookStreamSounds"
            Me.chkbLookStreamSounds.Size = New Global.System.Drawing.Size(104, 16)
            Me.chkbLookStreamSounds.TabIndex = 23
            Me.chkbLookStreamSounds.Text = "StreamSounds"
            Me.tbFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbFilter.Location = New Global.System.Drawing.Point(208, 232)
            Me.tbFilter.Name = "tbFilter"
            Me.tbFilter.Size = New Global.System.Drawing.Size(136, 20)
            Me.tbFilter.TabIndex = 24
            Me.tbFilter.Text = ""
            Me.cmbxFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.cmbxFilter.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFilter.Location = New Global.System.Drawing.Point(208, 280)
            Me.cmbxFilter.MaxDropDownItems = 16
            Me.cmbxFilter.Name = "cmbxFilter"
            Me.cmbxFilter.Size = New Global.System.Drawing.Size(200, 21)
            Me.cmbxFilter.TabIndex = 25
            Me.lblSoundCount.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lblSoundCount.ForeColor = Global.System.Drawing.SystemColors.Highlight
            Me.lblSoundCount.Location = New Global.System.Drawing.Point(408, 12)
            Me.lblSoundCount.Name = "lblSoundCount"
            Me.lblSoundCount.Size = New Global.System.Drawing.Size(100, 16)
            Me.lblSoundCount.TabIndex = 26
            Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label2.Location = New Global.System.Drawing.Point(32, 216)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label2.TabIndex = 26
            Me.Label2.Text = "Show sounds from:"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(432, 224)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnOK.TabIndex = 21
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(432, 272)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnCancel.TabIndex = 21
            Me.btnCancel.Text = "Cancel"
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Label1.Location = New Global.System.Drawing.Point(208, 216)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label1.TabIndex = 26
            Me.Label1.Text = "Name Filter"
            Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Label3.Location = New Global.System.Drawing.Point(208, 264)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label3.TabIndex = 26
            Me.Label3.Text = "Sound Type Filter"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(536, 309)
            Me.Controls.Add(Me.lblSoundCount)
            Me.Controls.Add(Me.cmbxFilter)
            Me.Controls.Add(Me.tbFilter)
            Me.Controls.Add(Me.chkbLookSoundsBif)
            Me.Controls.Add(Me.lbSounds)
            Me.Controls.Add(Me.btnPlaySound)
            Me.Controls.Add(Me.btnStopSound)
            Me.Controls.Add(Me.chkbLookStreamSounds)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label3)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(504, 232)
            Me.Name = "frmSoundChooser"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Sound Selector"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnPlaySound.Click, AddressOf Me.btnPlaySound_Click
            AddHandler Me.btnStopSound.Click, AddressOf Me.btnStopSound_Click
            AddHandler Me.lbSounds.SelectedIndexChanged, AddressOf Me.lbSounds_SelectedIndexChanged
            AddHandler Me.chkbLookSoundsBif.CheckedChanged, AddressOf Me.LookForSoundsChkBxsChanged
            AddHandler Me.chkbLookStreamSounds.CheckedChanged, AddressOf Me.LookForSoundsChkBxsChanged
            AddHandler Me.tbFilter.TextChanged, AddressOf Me.tbFilter_TextChanged
            AddHandler Me.cmbxFilter.SelectedIndexChanged, AddressOf Me.cmbxFilter_SelectedIndexChanged
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
