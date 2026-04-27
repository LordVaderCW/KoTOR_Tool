Namespace kotor_tool
	' Token: 0x02000066 RID: 102
	Public Partial Class frmPackageTypeSelector
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxErfType As Global.System.Windows.Forms.ComboBox


		' Token: 0x06000CBF RID: 3263 RVA: 0x00283504 File Offset: 0x00282504
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000CC8 RID: 3272 RVA: 0x002835E4 File Offset: 0x002825E4
		<Global.System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmPackageTypeSelector))
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.cmbxErfType = New Global.System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Me.btnOK.Location = New Global.System.Drawing.Point(31, 116)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.TabIndex = 0
			Me.btnOK.Text = "OK"
			Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New Global.System.Drawing.Point(119, 116)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.TabIndex = 0
			Me.btnCancel.Text = "Cancel"
			Me.Label1.Location = New Global.System.Drawing.Point(24, 16)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(168, 23)
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Select the type for this Package"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.cmbxErfType.Items.AddRange(New Object() { "MOD", "ERF", "HAK", "SAV" })
			Me.cmbxErfType.Location = New Global.System.Drawing.Point(88, 56)
			Me.cmbxErfType.Name = "cmbxErfType"
			Me.cmbxErfType.Size = New Global.System.Drawing.Size(48, 21)
			Me.cmbxErfType.TabIndex = 3
			Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
			Me.ClientSize = New Global.System.Drawing.Size(224, 149)
			Me.ControlBox = False
			Me.Controls.Add(Me.cmbxErfType)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.btnCancel)
			Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximumSize = New Global.System.Drawing.Size(232, 176)
			Me.MinimumSize = New Global.System.Drawing.Size(232, 176)
			Me.Name = "frmPackageTypeSelector"
			Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Package Type Selector"
			Me.ResumeLayout(False)
		End Sub

	End Class
End Namespace
