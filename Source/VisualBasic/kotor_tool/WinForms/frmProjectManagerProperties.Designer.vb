Namespace kotor_tool
	' Token: 0x0200006D RID: 109
	Public Partial Class frmProjectManagerProperties
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents btnKotorPath As Global.System.Windows.Forms.Button
        Friend WithEvents btnReleasePath As Global.System.Windows.Forms.Button
        Friend WithEvents tbDebugPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbReleasePath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnSelectProject As Global.System.Windows.Forms.Button
        Friend WithEvents tbProjectPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents tbProjectName As Global.System.Windows.Forms.TextBox
        Friend WithEvents rbKotor1 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbKotor2 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label


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
            Me.tbProjectPath.Location = New Global.System.Drawing.Point(168, 56)
            Me.tbProjectPath.Name = "tbProjectPath"
            Me.tbProjectPath.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbProjectPath.TabIndex = 1
            Me.tbProjectPath.Text = ""
            Me.tbDebugPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbDebugPath.Location = New Global.System.Drawing.Point(168, 96)
            Me.tbDebugPath.Name = "tbDebugPath"
            Me.tbDebugPath.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbDebugPath.TabIndex = 3
            Me.tbDebugPath.Text = ""
            Me.tbReleasePath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbReleasePath.Location = New Global.System.Drawing.Point(168, 136)
            Me.tbReleasePath.Name = "tbReleasePath"
            Me.tbReleasePath.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbReleasePath.TabIndex = 5
            Me.tbReleasePath.Text = ""
            Me.Label1.Location = New Global.System.Drawing.Point(24, 56)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Project File"
            Me.Label2.Location = New Global.System.Drawing.Point(24, 96)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(160, 16)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Debug mode output path"
            Me.Label3.Location = New Global.System.Drawing.Point(24, 133)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(128, 26)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Release mode output and temporary data path"
            Me.btnKotorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnKotorPath.Location = New Global.System.Drawing.Point(400, 97)
            Me.btnKotorPath.Name = "btnKotorPath"
            Me.btnKotorPath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnKotorPath.TabIndex = 4
            Me.btnKotorPath.Text = "..."
            Me.btnReleasePath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnReleasePath.Location = New Global.System.Drawing.Point(400, 137)
            Me.btnReleasePath.Name = "btnReleasePath"
            Me.btnReleasePath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnReleasePath.TabIndex = 6
            Me.btnReleasePath.Text = "..."
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.Location = New Global.System.Drawing.Point(264, 232)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 9
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(352, 232)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 10
            Me.btnCancel.Text = "Cancel"
            Me.btnSelectProject.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSelectProject.Location = New Global.System.Drawing.Point(400, 57)
            Me.btnSelectProject.Name = "btnSelectProject"
            Me.btnSelectProject.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnSelectProject.TabIndex = 2
            Me.btnSelectProject.Text = "..."
            Me.Label4.Location = New Global.System.Drawing.Point(24, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Project Name"
            Me.tbProjectName.Location = New Global.System.Drawing.Point(168, 16)
            Me.tbProjectName.Name = "tbProjectName"
            Me.tbProjectName.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbProjectName.TabIndex = 0
            Me.tbProjectName.Text = ""
            Me.rbKotor1.Location = New Global.System.Drawing.Point(168, 184)
            Me.rbKotor1.Name = "rbKotor1"
            Me.rbKotor1.Size = New Global.System.Drawing.Size(72, 20)
            Me.rbKotor1.TabIndex = 7
            Me.rbKotor1.Text = "&KotOR I"
            Me.rbKotor2.Location = New Global.System.Drawing.Point(256, 184)
            Me.rbKotor2.Name = "rbKotor2"
            Me.rbKotor2.Size = New Global.System.Drawing.Size(106, 20)
            Me.rbKotor2.TabIndex = 8
            Me.rbKotor2.Text = "KotOR II : &TSL"
            Me.Label5.Location = New Global.System.Drawing.Point(24, 184)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label5.TabIndex = 1
            Me.Label5.Text = "Target Game"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(464, 277)
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
            Me.MaximumSize = New Global.System.Drawing.Size(1600, 304)
            Me.MinimumSize = New Global.System.Drawing.Size(472, 304)
            Me.Name = "frmProjectManagerProperties"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Project Properties"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnKotorPath.Click, AddressOf Me.btnKotorPath_Click
            AddHandler Me.btnReleasePath.Click, AddressOf Me.btnReleasePath_Click
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.btnSelectProject.Click, AddressOf Me.btnSelectProject_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
