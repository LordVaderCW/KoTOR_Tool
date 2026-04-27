Namespace kotor_tool
	' Token: 0x0200004F RID: 79
	Public Partial Class frmInstanceOrRefPrompt
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents btnReference As Global.System.Windows.Forms.Button
        Friend WithEvents btnInstance As Global.System.Windows.Forms.Button
        Friend WithEvents Button3 As Global.System.Windows.Forms.Button


		' Token: 0x0600057D RID: 1405 RVA: 0x00244778 File Offset: 0x00243778
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x06000586 RID: 1414 RVA: 0x002448C8 File Offset: 0x002438C8
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmInstanceOrRefPrompt))
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.btnReference = New Global.System.Windows.Forms.Button()
            Me.btnInstance = New Global.System.Windows.Forms.Button()
            Me.Button3 = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.Label1.Location = New Global.System.Drawing.Point(90, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Do you want to create:"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.btnReference.Location = New Global.System.Drawing.Point(42, 48)
            Me.btnReference.Name = "btnReference"
            Me.btnReference.Size = New Global.System.Drawing.Size(208, 23)
            Me.btnReference.TabIndex = 1
            Me.btnReference.Text = "A non-editable reference to this item"
            Me.btnInstance.Location = New Global.System.Drawing.Point(42, 88)
            Me.btnInstance.Name = "btnInstance"
            Me.btnInstance.Size = New Global.System.Drawing.Size(208, 23)
            Me.btnInstance.TabIndex = 1
            Me.btnInstance.Text = "An editable instance of this item"
            Me.Button3.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.Button3.Location = New Global.System.Drawing.Point(106, 144)
            Me.Button3.Name = "Button3"
            Me.Button3.TabIndex = 2
            Me.Button3.Text = "Cancel"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(292, 181)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.btnReference)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnInstance)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmInstanceOrRefPrompt"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Instance or Reference"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnReference.Click, AddressOf Me.btnReference_Click
            AddHandler Me.btnInstance.Click, AddressOf Me.btnInstance_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
