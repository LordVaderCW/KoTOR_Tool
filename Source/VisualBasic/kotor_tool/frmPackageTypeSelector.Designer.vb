Namespace kotor_tool
	' Token: 0x02000066 RID: 102
	Public Partial Class frmPackageTypeSelector
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000CBF RID: 3263 RVA: 0x00283504 File Offset: 0x00282504
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000CC8 RID: 3272 RVA: 0x002835E4 File Offset: 0x002825E4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmPackageTypeSelector))
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.cmbxErfType = New Global.System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(31, 116)
			btnOK.Location = point
			Me.btnOK.Name = "btnOK"
			Me.btnOK.TabIndex = 0
			Me.btnOK.Text = "OK"
			Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			point = New Global.System.Drawing.Point(119, 116)
			btnCancel.Location = point
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.TabIndex = 0
			Me.btnCancel.Text = "Cancel"
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(24, 16)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(168, 23)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Select the type for this Package"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.cmbxErfType.Items.AddRange(New Object() { "MOD", "ERF", "HAK", "SAV" })
			Dim cmbxErfType As Global.System.Windows.Forms.Control = Me.cmbxErfType
			point = New Global.System.Drawing.Point(88, 56)
			cmbxErfType.Location = point
			Me.cmbxErfType.Name = "cmbxErfType"
			Dim cmbxErfType2 As Global.System.Windows.Forms.Control = Me.cmbxErfType
			size = New Global.System.Drawing.Size(48, 21)
			cmbxErfType2.Size = size
			Me.cmbxErfType.TabIndex = 3
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(224, 149)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.cmbxErfType)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.btnCancel)
			Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			size = New Global.System.Drawing.Size(232, 176)
			Me.MaximumSize = size
			size = New Global.System.Drawing.Size(232, 176)
			Me.MinimumSize = size
			Me.Name = "frmPackageTypeSelector"
			Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Package Type Selector"
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400065B RID: 1627
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
