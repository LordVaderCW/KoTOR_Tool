Namespace kotor_tool
	' Token: 0x02000044 RID: 68
	Public Partial Class frmCExoLocStringLanguagePicker
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxLanguage As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxGender As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button


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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmCExoLocStringLanguagePicker))
            Me.cmbxLanguage = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxGender = New Global.System.Windows.Forms.ComboBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.cmbxLanguage.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxLanguage.Items.AddRange(New Object() {"English", "French", "German", "Italian", "Spanish", "Polish"})
            Me.cmbxLanguage.Location = New Global.System.Drawing.Point(64, 40)
            Me.cmbxLanguage.Name = "cmbxLanguage"
            Me.cmbxLanguage.Size = New Global.System.Drawing.Size(160, 21)
            Me.cmbxLanguage.TabIndex = 0
            Me.cmbxGender.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxGender.Items.AddRange(New Object() {"Neuter/Masculine", "Feminine"})
            Me.cmbxGender.Location = New Global.System.Drawing.Point(64, 96)
            Me.cmbxGender.Name = "cmbxGender"
            Me.cmbxGender.Size = New Global.System.Drawing.Size(136, 21)
            Me.cmbxGender.TabIndex = 0
            Me.btnOK.Location = New Global.System.Drawing.Point(57, 144)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 1
            Me.btnOK.Text = "OK"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(161, 144)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.Label1.Location = New Global.System.Drawing.Point(64, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Language"
            Me.Label2.Location = New Global.System.Drawing.Point(64, 80)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Gender"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(292, 197)
            Me.ControlBox = False
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.cmbxLanguage)
            Me.Controls.Add(Me.cmbxGender)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.Label2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximumSize = New Global.System.Drawing.Size(300, 224)
            Me.MinimumSize = New Global.System.Drawing.Size(300, 224)
            Me.Name = "frmCExoLocStringLanguagePicker"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Language Selector"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
