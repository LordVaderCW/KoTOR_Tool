Namespace kotor_tool
	' Token: 0x0200005F RID: 95
	Public Partial Class frmModuleEditor_MissingItemSelector
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000936 RID: 2358 RVA: 0x0026D1F0 File Offset: 0x0026C1F0
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000945 RID: 2373 RVA: 0x0026D408 File Offset: 0x0026C408
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmModuleEditor_MissingItemSelector))
            Me.rbUserPalette = New Global.System.Windows.Forms.RadioButton()
            Me.rbGlobalTemplates = New Global.System.Windows.Forms.RadioButton()
            Me.rbTemplatesBif = New Global.System.Windows.Forms.RadioButton()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Dim rbUserPalette As Global.System.Windows.Forms.Control = Me.rbUserPalette
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(112, 104)
            rbUserPalette.Location = point
            Me.rbUserPalette.Name = "rbUserPalette"
            Dim rbUserPalette2 As Global.System.Windows.Forms.Control = Me.rbUserPalette
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(152, 24)
            rbUserPalette2.Size = size
            Me.rbUserPalette.TabIndex = 0
            Me.rbUserPalette.Text = "UserPalette folder"
            Dim rbGlobalTemplates As Global.System.Windows.Forms.Control = Me.rbGlobalTemplates
            point = New Global.System.Drawing.Point(112, 136)
            rbGlobalTemplates.Location = point
            Me.rbGlobalTemplates.Name = "rbGlobalTemplates"
            Dim rbGlobalTemplates2 As Global.System.Windows.Forms.Control = Me.rbGlobalTemplates
            size = New Global.System.Drawing.Size(152, 24)
            rbGlobalTemplates2.Size = size
            Me.rbGlobalTemplates.TabIndex = 0
            Me.rbGlobalTemplates.Text = "Global Templates folder"
            Dim rbTemplatesBif As Global.System.Windows.Forms.Control = Me.rbTemplatesBif
            point = New Global.System.Drawing.Point(112, 168)
            rbTemplatesBif.Location = point
            Me.rbTemplatesBif.Name = "rbTemplatesBif"
            Dim rbTemplatesBif2 As Global.System.Windows.Forms.Control = Me.rbTemplatesBif
            size = New Global.System.Drawing.Size(152, 24)
            rbTemplatesBif2.Size = size
            Me.rbTemplatesBif.TabIndex = 0
            Me.rbTemplatesBif.Text = "Templates.bif file"
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(32, 56)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(328, 32)
            label2.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "If you would like to change it to an editable instance, select the source of the template file below:"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Enabled = False
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(192, 216)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 2
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(280, 216)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(32, 24)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(332, 24)
            label4.Size = size
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "This item is currently a non-editable reference to a template file."
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(376, 253)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.rbUserPalette)
            Me.Controls.Add(Me.rbGlobalTemplates)
            Me.Controls.Add(Me.rbTemplatesBif)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.Label2)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmModuleEditor_MissingItemSelector"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Missing Item Source Selector"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040004D1 RID: 1233
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
