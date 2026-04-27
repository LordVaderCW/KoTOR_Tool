Namespace kotor_tool
	' Token: 0x0200004F RID: 79
	Public Partial Class frmInstanceOrRefPrompt
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600057D RID: 1405 RVA: 0x00244778 File Offset: 0x00243778
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000586 RID: 1414 RVA: 0x002448C8 File Offset: 0x002438C8
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmInstanceOrRefPrompt))
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.btnReference = New Global.System.Windows.Forms.Button()
            Me.btnInstance = New Global.System.Windows.Forms.Button()
            Me.Button3 = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(90, 16)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(120, 16)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Do you want to create:"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Dim btnReference As Global.System.Windows.Forms.Control = Me.btnReference
            point = New Global.System.Drawing.Point(42, 48)
            btnReference.Location = point
            Me.btnReference.Name = "btnReference"
            Dim btnReference2 As Global.System.Windows.Forms.Control = Me.btnReference
            size = New Global.System.Drawing.Size(208, 23)
            btnReference2.Size = size
            Me.btnReference.TabIndex = 1
            Me.btnReference.Text = "A non-editable reference to this item"
            Dim btnInstance As Global.System.Windows.Forms.Control = Me.btnInstance
            point = New Global.System.Drawing.Point(42, 88)
            btnInstance.Location = point
            Me.btnInstance.Name = "btnInstance"
            Dim btnInstance2 As Global.System.Windows.Forms.Control = Me.btnInstance
            size = New Global.System.Drawing.Size(208, 23)
            btnInstance2.Size = size
            Me.btnInstance.TabIndex = 1
            Me.btnInstance.Text = "An editable instance of this item"
            Me.Button3.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim button As Global.System.Windows.Forms.Control = Me.Button3
            point = New Global.System.Drawing.Point(106, 144)
            button.Location = point
            Me.Button3.Name = "Button3"
            Me.Button3.TabIndex = 2
            Me.Button3.Text = "Cancel"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(292, 181)
            Me.ClientSize = size
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.btnReference)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnInstance)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmInstanceOrRefPrompt"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Instance or Reference"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040002F7 RID: 759
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
