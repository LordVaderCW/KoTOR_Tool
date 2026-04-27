Namespace kotor_tool
	' Token: 0x0200006D RID: 109
	Public Partial Class frmProjectManagerProperties
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000E08 RID: 3592 RVA: 0x0028C04C File Offset: 0x0028B04C
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000E29 RID: 3625 RVA: 0x0028C44C File Offset: 0x0028B44C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.tbProjectPath = New Global.System.Windows.Forms.TextBox()
            Me.tbDebugPath = New Global.System.Windows.Forms.TextBox()
            Me.tbReleasePath = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.btnKotorPath = New Global.System.Windows.Forms.Button()
            Me.btnReleasePath = New Global.System.Windows.Forms.Button()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnSelectProject = New Global.System.Windows.Forms.Button()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.tbProjectName = New Global.System.Windows.Forms.TextBox()
            Me.rbKotor1 = New Global.System.Windows.Forms.RadioButton()
            Me.rbKotor2 = New Global.System.Windows.Forms.RadioButton()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.tbProjectPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbProjectPath As Global.System.Windows.Forms.Control = Me.tbProjectPath
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(168, 56)
            tbProjectPath.Location = point
            Me.tbProjectPath.Name = "tbProjectPath"
            Dim tbProjectPath2 As Global.System.Windows.Forms.Control = Me.tbProjectPath
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(200, 20)
            tbProjectPath2.Size = size
            Me.tbProjectPath.TabIndex = 1
            Me.tbProjectPath.Text = ""
            Me.tbDebugPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbDebugPath As Global.System.Windows.Forms.Control = Me.tbDebugPath
            point = New Global.System.Drawing.Point(168, 96)
            tbDebugPath.Location = point
            Me.tbDebugPath.Name = "tbDebugPath"
            Dim tbDebugPath2 As Global.System.Windows.Forms.Control = Me.tbDebugPath
            size = New Global.System.Drawing.Size(200, 20)
            tbDebugPath2.Size = size
            Me.tbDebugPath.TabIndex = 3
            Me.tbDebugPath.Text = ""
            Me.tbReleasePath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbReleasePath As Global.System.Windows.Forms.Control = Me.tbReleasePath
            point = New Global.System.Drawing.Point(168, 136)
            tbReleasePath.Location = point
            Me.tbReleasePath.Name = "tbReleasePath"
            Dim tbReleasePath2 As Global.System.Windows.Forms.Control = Me.tbReleasePath
            size = New Global.System.Drawing.Size(200, 20)
            tbReleasePath2.Size = size
            Me.tbReleasePath.TabIndex = 5
            Me.tbReleasePath.Text = ""
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(24, 56)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(100, 16)
            label2.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Project File"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(24, 96)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(160, 16)
            label4.Size = size
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Debug mode output path"
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(24, 133)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(128, 26)
            label6.Size = size
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Release mode output and temporary data path"
            Me.btnKotorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnKotorPath As Global.System.Windows.Forms.Control = Me.btnKotorPath
            point = New Global.System.Drawing.Point(400, 97)
            btnKotorPath.Location = point
            Me.btnKotorPath.Name = "btnKotorPath"
            Dim btnKotorPath2 As Global.System.Windows.Forms.Control = Me.btnKotorPath
            size = New Global.System.Drawing.Size(24, 20)
            btnKotorPath2.Size = size
            Me.btnKotorPath.TabIndex = 4
            Me.btnKotorPath.Text = "..."
            Me.btnReleasePath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnReleasePath As Global.System.Windows.Forms.Control = Me.btnReleasePath
            point = New Global.System.Drawing.Point(400, 137)
            btnReleasePath.Location = point
            Me.btnReleasePath.Name = "btnReleasePath"
            Dim btnReleasePath2 As Global.System.Windows.Forms.Control = Me.btnReleasePath
            size = New Global.System.Drawing.Size(24, 20)
            btnReleasePath2.Size = size
            Me.btnReleasePath.TabIndex = 6
            Me.btnReleasePath.Text = "..."
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(264, 232)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 9
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(352, 232)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 10
            Me.btnCancel.Text = "Cancel"
            Me.btnSelectProject.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSelectProject As Global.System.Windows.Forms.Control = Me.btnSelectProject
            point = New Global.System.Drawing.Point(400, 57)
            btnSelectProject.Location = point
            Me.btnSelectProject.Name = "btnSelectProject"
            Dim btnSelectProject2 As Global.System.Windows.Forms.Control = Me.btnSelectProject
            size = New Global.System.Drawing.Size(24, 20)
            btnSelectProject2.Size = size
            Me.btnSelectProject.TabIndex = 2
            Me.btnSelectProject.Text = "..."
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(24, 16)
            label7.Location = point
            Me.Label4.Name = "Label4"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(100, 16)
            label8.Size = size
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Project Name"
            Dim tbProjectName As Global.System.Windows.Forms.Control = Me.tbProjectName
            point = New Global.System.Drawing.Point(168, 16)
            tbProjectName.Location = point
            Me.tbProjectName.Name = "tbProjectName"
            Dim tbProjectName2 As Global.System.Windows.Forms.Control = Me.tbProjectName
            size = New Global.System.Drawing.Size(128, 20)
            tbProjectName2.Size = size
            Me.tbProjectName.TabIndex = 0
            Me.tbProjectName.Text = ""
            Dim rbKotor As Global.System.Windows.Forms.Control = Me.rbKotor1
            point = New Global.System.Drawing.Point(168, 184)
            rbKotor.Location = point
            Me.rbKotor1.Name = "rbKotor1"
            Dim rbKotor2 As Global.System.Windows.Forms.Control = Me.rbKotor1
            size = New Global.System.Drawing.Size(72, 20)
            rbKotor2.Size = size
            Me.rbKotor1.TabIndex = 7
            Me.rbKotor1.Text = "&KotOR I"
            Dim rbKotor3 As Global.System.Windows.Forms.Control = Me.rbKotor2
            point = New Global.System.Drawing.Point(256, 184)
            rbKotor3.Location = point
            Me.rbKotor2.Name = "rbKotor2"
            Dim rbKotor4 As Global.System.Windows.Forms.Control = Me.rbKotor2
            size = New Global.System.Drawing.Size(106, 20)
            rbKotor4.Size = size
            Me.rbKotor2.TabIndex = 8
            Me.rbKotor2.Text = "KotOR II : &TSL"
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(24, 184)
            label9.Location = point
            Me.Label5.Name = "Label5"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(128, 16)
            label10.Size = size
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Target Game"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(464, 277)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.rbKotor1)
            Me.Controls.Add(Me.rbKotor2)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnKotorPath)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.tbProjectPath)
            Me.Controls.Add(Me.tbDebugPath)
            Me.Controls.Add(Me.tbReleasePath)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.btnReleasePath)
            Me.Controls.Add(Me.btnSelectProject)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.tbProjectName)
            Me.Controls.Add(Me.Label5)
            size = New Global.System.Drawing.Size(1600, 304)
            Me.MaximumSize = size
            size = New Global.System.Drawing.Size(472, 304)
            Me.MinimumSize = size
            Me.Name = "frmProjectManagerProperties"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Project Properties"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040006EA RID: 1770
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
