Namespace kotor_tool
	' Token: 0x02000044 RID: 68
	Public Partial Class frmCExoLocStringLanguagePicker
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002E3 RID: 739 RVA: 0x0022FF40 File Offset: 0x0022EF40
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060002F0 RID: 752 RVA: 0x002300B8 File Offset: 0x0022F0B8
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmCExoLocStringLanguagePicker))
            Me.cmbxLanguage = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxGender = New Global.System.Windows.Forms.ComboBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.cmbxLanguage.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxLanguage.Items.AddRange(New Object() {"English", "French", "German", "Italian", "Spanish", "Polish"})
            Dim cmbxLanguage As Global.System.Windows.Forms.Control = Me.cmbxLanguage
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(64, 40)
            cmbxLanguage.Location = point
            Me.cmbxLanguage.Name = "cmbxLanguage"
            Dim cmbxLanguage2 As Global.System.Windows.Forms.Control = Me.cmbxLanguage
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(160, 21)
            cmbxLanguage2.Size = size
            Me.cmbxLanguage.TabIndex = 0
            Me.cmbxGender.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxGender.Items.AddRange(New Object() {"Neuter/Masculine", "Feminine"})
            Dim cmbxGender As Global.System.Windows.Forms.Control = Me.cmbxGender
            point = New Global.System.Drawing.Point(64, 96)
            cmbxGender.Location = point
            Me.cmbxGender.Name = "cmbxGender"
            Dim cmbxGender2 As Global.System.Windows.Forms.Control = Me.cmbxGender
            size = New Global.System.Drawing.Size(136, 21)
            cmbxGender2.Size = size
            Me.cmbxGender.TabIndex = 0
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(57, 144)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 1
            Me.btnOK.Text = "OK"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(161, 144)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(64, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(100, 16)
            label2.Size = size
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Language"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(64, 80)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(100, 16)
            label4.Size = size
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Gender"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(292, 197)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.cmbxLanguage)
            Me.Controls.Add(Me.cmbxGender)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.Label2)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(300, 224)
            Me.MaximumSize = size
            size = New Global.System.Drawing.Size(300, 224)
            Me.MinimumSize = size
            Me.Name = "frmCExoLocStringLanguagePicker"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Language Selector"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040001D1 RID: 465
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
