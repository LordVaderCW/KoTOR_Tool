Namespace kotor_tool
	' Token: 0x02000075 RID: 117
	Public Partial Class frmSpecifyKotorVersion
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents rbKotor1 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbKotor2 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents lblMsg As Global.System.Windows.Forms.Label
        Friend WithEvents chkbRecordSelection As Global.System.Windows.Forms.CheckBox


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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmSpecifyKotorVersion))
            Me.rbKotor1 = New Global.System.Windows.Forms.RadioButton()
            Me.rbKotor2 = New Global.System.Windows.Forms.RadioButton()
            Me.lblMsg = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.chkbRecordSelection = New Global.System.Windows.Forms.CheckBox()
            Me.SuspendLayout()
            Me.rbKotor1.Location = New Global.System.Drawing.Point(134, 72)
            Me.rbKotor1.Name = "rbKotor1"
            Me.rbKotor1.Size = New Global.System.Drawing.Size(72, 20)
            Me.rbKotor1.TabIndex = 0
            Me.rbKotor1.Text = "&KotOR I"
            Me.rbKotor2.Location = New Global.System.Drawing.Point(134, 96)
            Me.rbKotor2.Name = "rbKotor2"
            Me.rbKotor2.Size = New Global.System.Drawing.Size(106, 20)
            Me.rbKotor2.TabIndex = 1
            Me.rbKotor2.Text = "KotOR II : &TSL"
            Me.lblMsg.Location = New Global.System.Drawing.Point(48, 24)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New Global.System.Drawing.Size(256, 32)
            Me.lblMsg.TabIndex = 3
            Me.lblMsg.Text = "Please indicate which game's data should be used for this file"
            Me.lblMsg.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Enabled = False
            Me.btnOK.Location = New Global.System.Drawing.Point(168, 136)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 3
            Me.btnOK.Text = "&OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(264, 136)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "&Cancel"
            Me.chkbRecordSelection.Checked = True
            Me.chkbRecordSelection.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbRecordSelection.Location = New Global.System.Drawing.Point(8, 160)
            Me.chkbRecordSelection.Name = "chkbRecordSelection"
            Me.chkbRecordSelection.Size = New Global.System.Drawing.Size(160, 16)
            Me.chkbRecordSelection.TabIndex = 2
            Me.chkbRecordSelection.Text = "&Record selection in file"
            Me.chkbRecordSelection.Visible = False
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(352, 173)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.lblMsg)
            Me.Controls.Add(Me.rbKotor1)
            Me.Controls.Add(Me.rbKotor2)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.chkbRecordSelection)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximumSize = New Global.System.Drawing.Size(360, 240)
            Me.Name = "frmSpecifyKotorVersion"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Specify KotOR Version"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.rbKotor1.CheckedChanged, AddressOf Me.rb_CheckedChanged
            AddHandler Me.rbKotor2.CheckedChanged, AddressOf Me.rb_CheckedChanged
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
