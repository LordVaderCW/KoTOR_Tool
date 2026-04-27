Namespace kotor_tool
	' Token: 0x0200007B RID: 123
	Public Partial Class frmUserRegistration
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060010EF RID: 4335 RVA: 0x0029E5DC File Offset: 0x0029D5DC
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06001106 RID: 4358 RVA: 0x0029E87C File Offset: 0x0029D87C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUserRegistration))
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.Button2 = New Global.System.Windows.Forms.Button()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(32, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(368, 23)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Complete the steps below to register your copy of Kotor Tool"
            Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(40, 72)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(24, 16)
            label4.Size = size
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "1."
            Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(40, 120)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(24, 16)
            label6.Size = size
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "2."
            Me.Label4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(40, 168)
            label7.Location = point
            Me.Label4.Name = "Label4"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(24, 16)
            label8.Size = size
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "3."
            Dim button As Global.System.Windows.Forms.Control = Me.Button1
            point = New Global.System.Drawing.Point(80, 72)
            button.Location = point
            Me.Button1.Name = "Button1"
            Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
            size = New Global.System.Drawing.Size(264, 23)
            button2.Size = size
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "Enter User Registration Info"
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(72, 112)
            label9.Location = point
            Me.Label5.Name = "Label5"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(48, 16)
            label10.Size = size
            Me.Label5.TabIndex = 3
            Me.Label5.Text = "Mail the"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
            Me.Label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(120, 112)
            label11.Location = point
            Me.Label6.Name = "Label6"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(72, 16)
            label12.Size = size
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "user reg.info"
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(192, 112)
            label13.Location = point
            Me.Label7.Name = "Label7"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(168, 16)
            label14.Size = size
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "file (in your Kotor Tool directory)"
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(80, 126)
            label15.Location = point
            Me.Label8.Name = "Label8"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(272, 34)
            label16.Size = size
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "to fredtetra@hotmail.com for further details on the registration process."
            Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
            point = New Global.System.Drawing.Point(80, 168)
            button3.Location = point
            Me.Button2.Name = "Button2"
            Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
            size = New Global.System.Drawing.Size(264, 23)
            button4.Size = size
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "Import User Registration Key"
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(176, 224)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 8
            Me.btnOK.Text = "OK"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(424, 269)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Button2)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmUserRegistration"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "User Registration"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000832 RID: 2098
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
