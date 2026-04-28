Namespace kotor_tool
	' Token: 0x0200006E RID: 110
	Public Partial Class frmPromptForString
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents lblMsg As Global.System.Windows.Forms.Label
        Friend WithEvents tbValue As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button


		' Token: 0x06000E31 RID: 3633 RVA: 0x0028CF88 File Offset: 0x0028BF88
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000E3A RID: 3642 RVA: 0x0028D068 File Offset: 0x0028C068
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmPromptForString))
            Me.lblMsg = New Global.System.Windows.Forms.Label()
            Me.tbValue = New Global.System.Windows.Forms.TextBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.lblMsg.Location = New Global.System.Drawing.Point(61, 24)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New Global.System.Drawing.Size(176, 32)
            Me.lblMsg.TabIndex = 0
            Me.lblMsg.Text = "Label1"
            Me.tbValue.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbValue.Location = New Global.System.Drawing.Point(33, 72)
            Me.tbValue.Name = "tbValue"
            Me.tbValue.Size = New Global.System.Drawing.Size(224, 20)
            Me.tbValue.TabIndex = 0
            Me.tbValue.Text = ""
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(52, 112)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 1
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(156, 112)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(288, 165)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.tbValue)
            Me.Controls.Add(Me.lblMsg)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmPromptForString"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "frmPromptForString"
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
