Namespace kotor_tool
	' Token: 0x02000075 RID: 117
	Public Partial Class frmSpecifyKotorVersion
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000F0A RID: 3850 RVA: 0x00292430 File Offset: 0x00291430
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000F17 RID: 3863 RVA: 0x002925E0 File Offset: 0x002915E0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmSpecifyKotorVersion))
            Me.rbKotor1 = New Global.System.Windows.Forms.RadioButton()
            Me.rbKotor2 = New Global.System.Windows.Forms.RadioButton()
            Me.lblMsg = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.chkbRecordSelection = New Global.System.Windows.Forms.CheckBox()
            Me.SuspendLayout()
            Dim rbKotor As Global.System.Windows.Forms.Control = Me.rbKotor1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(134, 72)
            rbKotor.Location = point
            Me.rbKotor1.Name = "rbKotor1"
            Dim rbKotor2 As Global.System.Windows.Forms.Control = Me.rbKotor1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(72, 20)
            rbKotor2.Size = size
            Me.rbKotor1.TabIndex = 0
            Me.rbKotor1.Text = "&KotOR I"
            Dim rbKotor3 As Global.System.Windows.Forms.Control = Me.rbKotor2
            point = New Global.System.Drawing.Point(134, 96)
            rbKotor3.Location = point
            Me.rbKotor2.Name = "rbKotor2"
            Dim rbKotor4 As Global.System.Windows.Forms.Control = Me.rbKotor2
            size = New Global.System.Drawing.Size(106, 20)
            rbKotor4.Size = size
            Me.rbKotor2.TabIndex = 1
            Me.rbKotor2.Text = "KotOR II : &TSL"
            Dim lblMsg As Global.System.Windows.Forms.Control = Me.lblMsg
            point = New Global.System.Drawing.Point(48, 24)
            lblMsg.Location = point
            Me.lblMsg.Name = "lblMsg"
            Dim lblMsg2 As Global.System.Windows.Forms.Control = Me.lblMsg
            size = New Global.System.Drawing.Size(256, 32)
            lblMsg2.Size = size
            Me.lblMsg.TabIndex = 3
            Me.lblMsg.Text = "Please indicate which game's data should be used for this file"
            Me.lblMsg.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Enabled = False
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(168, 136)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 3
            Me.btnOK.Text = "&OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(264, 136)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "&Cancel"
            Me.chkbRecordSelection.Checked = True
            Me.chkbRecordSelection.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbRecordSelection As Global.System.Windows.Forms.Control = Me.chkbRecordSelection
            point = New Global.System.Drawing.Point(8, 160)
            chkbRecordSelection.Location = point
            Me.chkbRecordSelection.Name = "chkbRecordSelection"
            Dim chkbRecordSelection2 As Global.System.Windows.Forms.Control = Me.chkbRecordSelection
            size = New Global.System.Drawing.Size(160, 16)
            chkbRecordSelection2.Size = size
            Me.chkbRecordSelection.TabIndex = 2
            Me.chkbRecordSelection.Text = "&Record selection in file"
            Me.chkbRecordSelection.Visible = False
            Me.AcceptButton = Me.btnOK
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(352, 173)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.lblMsg)
            Me.Controls.Add(Me.rbKotor1)
            Me.Controls.Add(Me.rbKotor2)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.chkbRecordSelection)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(360, 240)
            Me.MaximumSize = size
            Me.Name = "frmSpecifyKotorVersion"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Specify KotOR Version"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000750 RID: 1872
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
