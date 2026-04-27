Namespace kotor_tool
	' Token: 0x0200007B RID: 123
	Public Partial Class frmUserRegistration
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Button2 As Global.System.Windows.Forms.Button
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button


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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUserRegistration))
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
            Me.Label1.Location = New Global.System.Drawing.Point(32, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(368, 23)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Complete the steps below to register your copy of Kotor Tool"
            Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.Location = New Global.System.Drawing.Point(40, 72)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "1."
            Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.Location = New Global.System.Drawing.Point(40, 120)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "2."
            Me.Label4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.Location = New Global.System.Drawing.Point(40, 168)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "3."
            Me.Button1.Location = New Global.System.Drawing.Point(80, 72)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New Global.System.Drawing.Size(264, 23)
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "Enter User Registration Info"
            Me.Label5.Location = New Global.System.Drawing.Point(72, 112)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label5.TabIndex = 3
            Me.Label5.Text = "Mail the"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
            Me.Label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.Label6.Location = New Global.System.Drawing.Point(120, 112)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(72, 16)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "user reg.info"
            Me.Label7.Location = New Global.System.Drawing.Point(192, 112)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(168, 16)
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "file (in your Kotor Tool directory)"
            Me.Label8.Location = New Global.System.Drawing.Point(80, 126)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(272, 34)
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "to fredtetra@hotmail.com for further details on the registration process."
            Me.Button2.Location = New Global.System.Drawing.Point(80, 168)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New Global.System.Drawing.Size(264, 23)
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "Import User Registration Key"
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(176, 224)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 8
            Me.btnOK.Text = "OK"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(424, 269)
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
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmUserRegistration"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "User Registration"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.Button1.Click, AddressOf Me.Button1_Click
            AddHandler Me.Button2.Click, AddressOf Me.Button2_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
