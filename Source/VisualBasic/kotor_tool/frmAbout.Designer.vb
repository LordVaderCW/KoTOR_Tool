Namespace kotor_tool
	' Token: 0x0200003E RID: 62
	Public Partial Class frmAbout
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001C4 RID: 452 RVA: 0x002288B8 File Offset: 0x002278B8
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060001D3 RID: 467 RVA: 0x00228A28 File Offset: 0x00227A28
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmAbout))
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.lblVersion = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.Label1.Font = New Global.System.Drawing.Font("Comic Sans MS", 15.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(138, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(124, 32)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "KotOR Tool"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.Button1.BackColor = Global.System.Drawing.SystemColors.Control
            Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim button As Global.System.Windows.Forms.Control = Me.Button1
            point = New Global.System.Drawing.Point(304, 224)
            button.Location = point
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "OK"
            Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(72, 112)
            label3.Location = point
            Me.Label3.Name = "Label3"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(256, 23)
            label4.Size = size
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Email: FredTetra@hotmail.com"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.PictureBox1.Image = CType(resourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
            Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
            point = New Global.System.Drawing.Point(72, 16)
            pictureBox.Location = point
            Me.PictureBox1.Name = "PictureBox1"
            Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
            size = New Global.System.Drawing.Size(48, 48)
            pictureBox2.Size = size
            Me.PictureBox1.TabIndex = 4
            Me.PictureBox1.TabStop = False
            Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(48, 192)
            label5.Location = point
            Me.Label4.Name = "Label4"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(307, 23)
            label6.Size = size
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Thanks to Eiz for his dxt1/5 converter code!"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(38, 144)
            label7.Location = point
            Me.Label5.Name = "Label5"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(325, 40)
            label8.Size = size
            Me.Label5.TabIndex = 3
            Me.Label5.Text = "Thanks to Achilles, illuzion69, CDRSeadog, Darth333, death_disco, ChAiNz.2da, Guardian Archon, Gsccc, Uchiha Itachi, and everyone else for their support!"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblVersion.Font = New Global.System.Drawing.Font("Courier New", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim lblVersion As Global.System.Windows.Forms.Control = Me.lblVersion
            point = New Global.System.Drawing.Point(92, 72)
            lblVersion.Location = point
            Me.lblVersion.Name = "lblVersion"
            Dim lblVersion2 As Global.System.Windows.Forms.Control = Me.lblVersion
            size = New Global.System.Drawing.Size(216, 16)
            lblVersion2.Size = size
            Me.lblVersion.TabIndex = 5
            Me.lblVersion.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
            size = New Global.System.Drawing.Size(400, 261)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.lblVersion)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label5)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmAbout"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "About Kotor Tool"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000153 RID: 339
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
