Namespace kotor_tool
	' Token: 0x02000073 RID: 115
	Public Partial Class frmSoundChooser
		Inherits Global.System.Windows.Forms.Form

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
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmSoundChooser))
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
            Dim btnPlaySound As Global.System.Windows.Forms.Control = Me.btnPlaySound
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(184, 8)
            btnPlaySound.Location = point
            Me.btnPlaySound.Name = "btnPlaySound"
            Dim btnPlaySound2 As Global.System.Windows.Forms.Control = Me.btnPlaySound
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(80, 23)
            btnPlaySound2.Size = size
            Me.btnPlaySound.TabIndex = 21
            Me.btnPlaySound.Text = "Play Sound"
            Me.btnStopSound.Enabled = False
            Dim btnStopSound As Global.System.Windows.Forms.Control = Me.btnStopSound
            point = New Global.System.Drawing.Point(272, 8)
            btnStopSound.Location = point
            Me.btnStopSound.Name = "btnStopSound"
            Dim btnStopSound2 As Global.System.Windows.Forms.Control = Me.btnStopSound
            size = New Global.System.Drawing.Size(80, 23)
            btnStopSound2.Size = size
            Me.btnStopSound.TabIndex = 20
            Me.btnStopSound.Text = "Stop"
            Me.lbSounds.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim lbSounds As Global.System.Windows.Forms.Control = Me.lbSounds
            point = New Global.System.Drawing.Point(16, 40)
            lbSounds.Location = point
            Me.lbSounds.MultiColumn = True
            Me.lbSounds.Name = "lbSounds"
            Me.lbSounds.SelectionMode = Global.System.Windows.Forms.SelectionMode.MultiExtended
            Dim lbSounds2 As Global.System.Windows.Forms.Control = Me.lbSounds
            size = New Global.System.Drawing.Size(496, 160)
            lbSounds2.Size = size
            Me.lbSounds.TabIndex = 22
            Me.chkbLookSoundsBif.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.chkbLookSoundsBif.Checked = True
            Me.chkbLookSoundsBif.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbLookSoundsBif As Global.System.Windows.Forms.Control = Me.chkbLookSoundsBif
            point = New Global.System.Drawing.Point(32, 240)
            chkbLookSoundsBif.Location = point
            Me.chkbLookSoundsBif.Name = "chkbLookSoundsBif"
            Dim chkbLookSoundsBif2 As Global.System.Windows.Forms.Control = Me.chkbLookSoundsBif
            size = New Global.System.Drawing.Size(104, 16)
            chkbLookSoundsBif2.Size = size
            Me.chkbLookSoundsBif.TabIndex = 23
            Me.chkbLookSoundsBif.Text = "Sounds.bif"
            Me.chkbLookStreamSounds.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.chkbLookStreamSounds.Checked = True
            Me.chkbLookStreamSounds.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbLookStreamSounds As Global.System.Windows.Forms.Control = Me.chkbLookStreamSounds
            point = New Global.System.Drawing.Point(32, 264)
            chkbLookStreamSounds.Location = point
            Me.chkbLookStreamSounds.Name = "chkbLookStreamSounds"
            Dim chkbLookStreamSounds2 As Global.System.Windows.Forms.Control = Me.chkbLookStreamSounds
            size = New Global.System.Drawing.Size(104, 16)
            chkbLookStreamSounds2.Size = size
            Me.chkbLookStreamSounds.TabIndex = 23
            Me.chkbLookStreamSounds.Text = "StreamSounds"
            Me.tbFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbFilter As Global.System.Windows.Forms.Control = Me.tbFilter
            point = New Global.System.Drawing.Point(208, 232)
            tbFilter.Location = point
            Me.tbFilter.Name = "tbFilter"
            Dim tbFilter2 As Global.System.Windows.Forms.Control = Me.tbFilter
            size = New Global.System.Drawing.Size(136, 20)
            tbFilter2.Size = size
            Me.tbFilter.TabIndex = 24
            Me.tbFilter.Text = ""
            Me.cmbxFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.cmbxFilter.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxFilter As Global.System.Windows.Forms.Control = Me.cmbxFilter
            point = New Global.System.Drawing.Point(208, 280)
            cmbxFilter.Location = point
            Me.cmbxFilter.MaxDropDownItems = 16
            Me.cmbxFilter.Name = "cmbxFilter"
            Dim cmbxFilter2 As Global.System.Windows.Forms.Control = Me.cmbxFilter
            size = New Global.System.Drawing.Size(200, 21)
            cmbxFilter2.Size = size
            Me.cmbxFilter.TabIndex = 25
            Me.lblSoundCount.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lblSoundCount.ForeColor = Global.System.Drawing.SystemColors.Highlight
            Dim lblSoundCount As Global.System.Windows.Forms.Control = Me.lblSoundCount
            point = New Global.System.Drawing.Point(408, 12)
            lblSoundCount.Location = point
            Me.lblSoundCount.Name = "lblSoundCount"
            Dim lblSoundCount2 As Global.System.Windows.Forms.Control = Me.lblSoundCount
            size = New Global.System.Drawing.Size(100, 16)
            lblSoundCount2.Size = size
            Me.lblSoundCount.TabIndex = 26
            Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim label As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(32, 216)
            label.Location = point
            Me.Label2.Name = "Label2"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(112, 16)
            label2.Size = size
            Me.Label2.TabIndex = 26
            Me.Label2.Text = "Show sounds from:"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(432, 224)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Dim btnOK2 As Global.System.Windows.Forms.Control = Me.btnOK
            size = New Global.System.Drawing.Size(80, 23)
            btnOK2.Size = size
            Me.btnOK.TabIndex = 21
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(432, 272)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Dim btnCancel2 As Global.System.Windows.Forms.Control = Me.btnCancel
            size = New Global.System.Drawing.Size(80, 23)
            btnCancel2.Size = size
            Me.btnCancel.TabIndex = 21
            Me.btnCancel.Text = "Cancel"
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(208, 216)
            label3.Location = point
            Me.Label1.Name = "Label1"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(112, 16)
            label4.Size = size
            Me.Label1.TabIndex = 26
            Me.Label1.Text = "Name Filter"
            Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(208, 264)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(112, 16)
            label6.Size = size
            Me.Label3.TabIndex = 26
            Me.Label3.Text = "Sound Type Filter"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(536, 309)
            Me.ClientSize = size
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
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(504, 232)
            Me.MinimumSize = size
            Me.Name = "frmSoundChooser"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Sound Selector"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000743 RID: 1859
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
