Namespace kotor_tool
	' Token: 0x0200006E RID: 110
	Public Partial Class frmPromptForString
		Inherits Global.System.Windows.Forms.Form

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
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmPromptForString))
            Me.lblMsg = New Global.System.Windows.Forms.Label()
            Me.tbValue = New Global.System.Windows.Forms.TextBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Dim lblMsg As Global.System.Windows.Forms.Control = Me.lblMsg
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(61, 24)
            lblMsg.Location = point
            Me.lblMsg.Name = "lblMsg"
            Dim lblMsg2 As Global.System.Windows.Forms.Control = Me.lblMsg
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(176, 32)
            lblMsg2.Size = size
            Me.lblMsg.TabIndex = 0
            Me.lblMsg.Text = "Label1"
            Me.tbValue.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbValue As Global.System.Windows.Forms.Control = Me.tbValue
            point = New Global.System.Drawing.Point(33, 72)
            tbValue.Location = point
            Me.tbValue.Name = "tbValue"
            Dim tbValue2 As Global.System.Windows.Forms.Control = Me.tbValue
            size = New Global.System.Drawing.Size(224, 20)
            tbValue2.Size = size
            Me.tbValue.TabIndex = 0
            Me.tbValue.Text = ""
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(52, 112)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 1
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(156, 112)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Me.AcceptButton = Me.btnOK
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(288, 165)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.tbValue)
            Me.Controls.Add(Me.lblMsg)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmPromptForString"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "frmPromptForString"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040006EF RID: 1775
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
