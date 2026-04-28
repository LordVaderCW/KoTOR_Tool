Namespace kotor_tool
	' Token: 0x0200006F RID: 111
	Public Partial Class frmQueryUserInfo
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents tbUserName As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbUserEmail As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label


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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmQueryUserInfo))
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.tbUserName = New Global.System.Windows.Forms.TextBox()
            Me.tbUserEmail = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.Label2.Location = New Global.System.Drawing.Point(40, 64)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "Name"
            Me.Label3.Location = New Global.System.Drawing.Point(40, 96)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Email Address"
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(88, 136)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 9
            Me.btnOK.Text = "OK"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(176, 136)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 9
            Me.btnCancel.Text = "Cancel"
            Me.tbUserName.Location = New Global.System.Drawing.Point(152, 64)
            Me.tbUserName.Name = "tbUserName"
            Me.tbUserName.Size = New Global.System.Drawing.Size(160, 20)
            Me.tbUserName.TabIndex = 11
            Me.tbUserName.Text = ""
            Me.tbUserEmail.Location = New Global.System.Drawing.Point(152, 96)
            Me.tbUserEmail.Name = "tbUserEmail"
            Me.tbUserEmail.Size = New Global.System.Drawing.Size(160, 20)
            Me.tbUserEmail.TabIndex = 11
            Me.tbUserEmail.Text = ""
            Me.Label1.Location = New Global.System.Drawing.Point(48, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(248, 32)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Please enter your name and the email address you would like to be contacted at."
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(352, 189)
            Me.Controls.Add(Me.tbUserName)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.tbUserEmail)
            Me.Controls.Add(Me.Label1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmQueryUserInfo"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Create User Info File"
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
