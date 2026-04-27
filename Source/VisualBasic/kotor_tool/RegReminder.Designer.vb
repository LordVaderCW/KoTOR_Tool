Namespace kotor_tool
	' Token: 0x0200008D RID: 141
	Public Partial Class RegReminder
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060017DF RID: 6111 RVA: 0x002CC7BC File Offset: 0x002CB7BC
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060017EE RID: 6126 RVA: 0x002CC9D4 File Offset: 0x002CB9D4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.RegReminder))
			Me.lblRegHeader = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.lblTimeMsg = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.lblRegHeader.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblRegHeader As Global.System.Windows.Forms.Control = Me.lblRegHeader
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(15, 32)
			lblRegHeader.Location = point
			Me.lblRegHeader.Name = "lblRegHeader"
			Dim lblRegHeader2 As Global.System.Windows.Forms.Control = Me.lblRegHeader
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(300, 23)
			lblRegHeader2.Size = size
			Me.lblRegHeader.TabIndex = 0
			Me.lblRegHeader.Text = "This copy of Kotor Tool is not registered"
			Me.lblRegHeader.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(16, 72)
			label.Location = point
			Me.Label2.Name = "Label2"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(288, 48)
			label2.Size = size
			Me.Label2.TabIndex = 0
			Me.Label2.Text = "Registration removes this nag screen and unlocks additional features"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.lblTimeMsg.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblTimeMsg As Global.System.Windows.Forms.Control = Me.lblTimeMsg
			point = New Global.System.Drawing.Point(80, 192)
			lblTimeMsg.Location = point
			Me.lblTimeMsg.Name = "lblTimeMsg"
			Dim lblTimeMsg2 As Global.System.Windows.Forms.Control = Me.lblTimeMsg
			size = New Global.System.Drawing.Size(144, 23)
			lblTimeMsg2.Size = size
			Me.lblTimeMsg.TabIndex = 0
			Me.lblTimeMsg.Text = "Please wait .. "
			Me.Button1.Enabled = False
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(72, 240)
			button.Location = point
			Me.Button1.Name = "Button1"
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "OK"
			Me.Timer1.Interval = 800
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(176, 240)
			button2.Location = point
			Me.Button2.Name = "Button2"
			Me.Button2.TabIndex = 2
			Me.Button2.Text = "Cancel"
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(16, 128)
			label3.Location = point
			Me.Label1.Name = "Label1"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(312, 48)
			label4.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "Use the Registration option on the Help menu to start the registration process"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(336, 304)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.lblRegHeader)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.lblTimeMsg)
			Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			size = New Global.System.Drawing.Size(328, 312)
			Me.MinimumSize = size
			Me.Name = "RegReminder"
			Me.ShowInTaskbar = False
			Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Reminder"
			Me.TopMost = True
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000BB8 RID: 3000
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
