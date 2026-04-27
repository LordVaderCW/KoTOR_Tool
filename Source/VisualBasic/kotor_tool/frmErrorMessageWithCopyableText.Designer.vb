Namespace kotor_tool
	' Token: 0x0200004B RID: 75
	Public Partial Class frmErrorMessageWithCopyableText
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060004CF RID: 1231 RVA: 0x0023EBDC File Offset: 0x0023DBDC
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060004D6 RID: 1238 RVA: 0x0023EC8C File Offset: 0x0023DC8C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmErrorMessageWithCopyableText))
            Me.lblMsg = New Global.System.Windows.Forms.Label()
            Me.tbMsg = New Global.System.Windows.Forms.TextBox()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.lblMsg.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim lblMsg As Global.System.Windows.Forms.Control = Me.lblMsg
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(36, 16)
            lblMsg.Location = point
            Me.lblMsg.Name = "lblMsg"
            Dim lblMsg2 As Global.System.Windows.Forms.Control = Me.lblMsg
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(296, 96)
            lblMsg2.Size = size
            Me.lblMsg.TabIndex = 0
            Me.lblMsg.Text = "Kotor Tool has either detected a problem with your SW:KotOR installation or is having a problem with one of its own files. Please report this status code by copying it and pasting it into an email to FredTetra@hotmail.com. Thank you!"
            Dim tbMsg As Global.System.Windows.Forms.Control = Me.tbMsg
            point = New Global.System.Drawing.Point(56, 120)
            tbMsg.Location = point
            Me.tbMsg.Multiline = True
            Me.tbMsg.Name = "tbMsg"
            Me.tbMsg.[ReadOnly] = True
            Me.tbMsg.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Dim tbMsg2 As Global.System.Windows.Forms.Control = Me.tbMsg
            size = New Global.System.Drawing.Size(256, 88)
            tbMsg2.Size = size
            Me.tbMsg.TabIndex = 1
            Me.tbMsg.Text = ""
            Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim button As Global.System.Windows.Forms.Control = Me.Button1
            point = New Global.System.Drawing.Point(147, 224)
            button.Location = point
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "Sorry!"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(360, 269)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.tbMsg)
            Me.Controls.Add(Me.lblMsg)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmErrorMessageWithCopyableText"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "An error has occurred"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x0400029D RID: 669
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
