Namespace kotor_tool
	' Token: 0x0200006F RID: 111
	Public Partial Class frmQueryUserInfo
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E3D RID: 3645 RVA: 0x0028D340 File Offset: 0x0028C340
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000E4C RID: 3660 RVA: 0x0028D4B0 File Offset: 0x0028C4B0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmQueryUserInfo))
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.tbUserName = New Global.System.Windows.Forms.TextBox()
            Me.tbUserEmail = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Dim label As Global.System.Windows.Forms.Control = Me.Label2
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(40, 64)
            label.Location = point
            Me.Label2.Name = "Label2"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label2
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(64, 16)
            label2.Size = size
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "Name"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(40, 96)
            label3.Location = point
            Me.Label3.Name = "Label3"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(88, 16)
            label4.Size = size
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Email Address"
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(88, 136)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 9
            Me.btnOK.Text = "OK"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(176, 136)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 9
            Me.btnCancel.Text = "Cancel"
            Dim tbUserName As Global.System.Windows.Forms.Control = Me.tbUserName
            point = New Global.System.Drawing.Point(152, 64)
            tbUserName.Location = point
            Me.tbUserName.Name = "tbUserName"
            Dim tbUserName2 As Global.System.Windows.Forms.Control = Me.tbUserName
            size = New Global.System.Drawing.Size(160, 20)
            tbUserName2.Size = size
            Me.tbUserName.TabIndex = 11
            Me.tbUserName.Text = ""
            Dim tbUserEmail As Global.System.Windows.Forms.Control = Me.tbUserEmail
            point = New Global.System.Drawing.Point(152, 96)
            tbUserEmail.Location = point
            Me.tbUserEmail.Name = "tbUserEmail"
            Dim tbUserEmail2 As Global.System.Windows.Forms.Control = Me.tbUserEmail
            size = New Global.System.Drawing.Size(160, 20)
            tbUserEmail2.Size = size
            Me.tbUserEmail.TabIndex = 11
            Me.tbUserEmail.Text = ""
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(48, 16)
            label5.Location = point
            Me.Label1.Name = "Label1"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(248, 32)
            label6.Size = size
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Please enter your name and the email address you would like to be contacted at."
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(352, 189)
            Me.ClientSize = size
            Me.Controls.Add(Me.tbUserName)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.tbUserEmail)
            Me.Controls.Add(Me.Label1)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmQueryUserInfo"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Create User Info File"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040006F7 RID: 1783
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
