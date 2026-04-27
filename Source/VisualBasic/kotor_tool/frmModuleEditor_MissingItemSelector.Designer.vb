Namespace kotor_tool
	' Token: 0x0200005F RID: 95
	Public Partial Class frmModuleEditor_MissingItemSelector
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents rbUserPalette As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbGlobalTemplates As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbTemplatesBif As Global.System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label


		' Token: 0x06000936 RID: 2358 RVA: 0x0026D1F0 File Offset: 0x0026C1F0
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x06000945 RID: 2373 RVA: 0x0026D408 File Offset: 0x0026C408
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmModuleEditor_MissingItemSelector))
            Me.rbUserPalette = New Global.System.Windows.Forms.RadioButton()
            Me.rbGlobalTemplates = New Global.System.Windows.Forms.RadioButton()
            Me.rbTemplatesBif = New Global.System.Windows.Forms.RadioButton()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.rbUserPalette.Location = New Global.System.Drawing.Point(112, 104)
            Me.rbUserPalette.Name = "rbUserPalette"
            Me.rbUserPalette.Size = New Global.System.Drawing.Size(152, 24)
            Me.rbUserPalette.TabIndex = 0
            Me.rbUserPalette.Text = "UserPalette folder"
            Me.rbGlobalTemplates.Location = New Global.System.Drawing.Point(112, 136)
            Me.rbGlobalTemplates.Name = "rbGlobalTemplates"
            Me.rbGlobalTemplates.Size = New Global.System.Drawing.Size(152, 24)
            Me.rbGlobalTemplates.TabIndex = 0
            Me.rbGlobalTemplates.Text = "Global Templates folder"
            Me.rbTemplatesBif.Location = New Global.System.Drawing.Point(112, 168)
            Me.rbTemplatesBif.Name = "rbTemplatesBif"
            Me.rbTemplatesBif.Size = New Global.System.Drawing.Size(152, 24)
            Me.rbTemplatesBif.TabIndex = 0
            Me.rbTemplatesBif.Text = "Templates.bif file"
            Me.Label1.Location = New Global.System.Drawing.Point(32, 56)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(328, 32)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "If you would like to change it to an editable instance, select the source of the template file below:"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Enabled = False
            Me.btnOK.Location = New Global.System.Drawing.Point(192, 216)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 2
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(280, 216)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Me.Label2.Location = New Global.System.Drawing.Point(32, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(332, 24)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "This item is currently a non-editable reference to a template file."
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(376, 253)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.rbUserPalette)
            Me.Controls.Add(Me.rbGlobalTemplates)
            Me.Controls.Add(Me.rbTemplatesBif)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.Label2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmModuleEditor_MissingItemSelector"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Missing Item Source Selector"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.rbUserPalette.CheckedChanged, AddressOf Me.CheckedChanged
            AddHandler Me.rbGlobalTemplates.CheckedChanged, AddressOf Me.CheckedChanged
            AddHandler Me.rbTemplatesBif.CheckedChanged, AddressOf Me.CheckedChanged
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
