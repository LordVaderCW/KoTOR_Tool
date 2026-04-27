Namespace kotor_tool
	' Token: 0x0200004A RID: 74
	Public Partial Class frmERFManager
		Inherits Global.kotor_tool.frmParent

		' Token: 0x0600049D RID: 1181 RVA: 0x0023D5B4 File Offset: 0x0023C5B4
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060004B8 RID: 1208 RVA: 0x0023DB6C File Offset: 0x0023CB6C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmERFManager))
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.tbErfName = New Global.System.Windows.Forms.TextBox()
            Me.cmbxErfType = New Global.System.Windows.Forms.ComboBox()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.ERFContentFiles = New Global.System.Windows.Forms.ListBox()
            Me.btnAddFile = New Global.System.Windows.Forms.Button()
            Me.btnRemoveItem = New Global.System.Windows.Forms.Button()
            Me.btnMoveUp = New Global.System.Windows.Forms.Button()
            Me.btnMoveDown = New Global.System.Windows.Forms.Button()
            Me.btnBuild = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnSelectOutputFile = New Global.System.Windows.Forms.Button()
            Me.btnAddDirectory = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(48, 16)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(104, 16)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Output file name"
            Me.tbErfName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbErfName As Global.System.Windows.Forms.Control = Me.tbErfName
            point = New Global.System.Drawing.Point(24, 40)
            tbErfName.Location = point
            Me.tbErfName.Name = "tbErfName"
            Dim tbErfName2 As Global.System.Windows.Forms.Control = Me.tbErfName
            size = New Global.System.Drawing.Size(248, 20)
            tbErfName2.Size = size
            Me.tbErfName.TabIndex = 1
            Me.tbErfName.Text = ""
            Me.cmbxErfType.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.cmbxErfType.Items.AddRange(New Object() {"MOD", "ERF", "HAK", "SAV"})
            Dim cmbxErfType As Global.System.Windows.Forms.Control = Me.cmbxErfType
            point = New Global.System.Drawing.Point(352, 40)
            cmbxErfType.Location = point
            Me.cmbxErfType.Name = "cmbxErfType"
            Dim cmbxErfType2 As Global.System.Windows.Forms.Control = Me.cmbxErfType
            size = New Global.System.Drawing.Size(48, 21)
            cmbxErfType2.Size = size
            Me.cmbxErfType.TabIndex = 2
            Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(336, 16)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(80, 24)
            label4.Size = size
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Output file type"
            Me.ERFContentFiles.AllowDrop = True
            Me.ERFContentFiles.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.ERFContentFiles.HorizontalScrollbar = True
            Dim erfcontentFiles As Global.System.Windows.Forms.Control = Me.ERFContentFiles
            point = New Global.System.Drawing.Point(24, 80)
            erfcontentFiles.Location = point
            Me.ERFContentFiles.Name = "ERFContentFiles"
            Me.ERFContentFiles.SelectionMode = Global.System.Windows.Forms.SelectionMode.MultiExtended
            Dim erfcontentFiles2 As Global.System.Windows.Forms.Control = Me.ERFContentFiles
            size = New Global.System.Drawing.Size(288, 290)
            erfcontentFiles2.Size = size
            Me.ERFContentFiles.TabIndex = 3
            Me.btnAddFile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnAddFile As Global.System.Windows.Forms.Control = Me.btnAddFile
            point = New Global.System.Drawing.Point(336, 96)
            btnAddFile.Location = point
            Me.btnAddFile.Name = "btnAddFile"
            Me.btnAddFile.TabIndex = 4
            Me.btnAddFile.Text = "Add Files..."
            Me.btnRemoveItem.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnRemoveItem.Enabled = False
            Dim btnRemoveItem As Global.System.Windows.Forms.Control = Me.btnRemoveItem
            point = New Global.System.Drawing.Point(336, 160)
            btnRemoveItem.Location = point
            Me.btnRemoveItem.Name = "btnRemoveItem"
            Me.btnRemoveItem.TabIndex = 4
            Me.btnRemoveItem.Text = "Remove"
            Me.btnMoveUp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnMoveUp.Enabled = False
            Dim btnMoveUp As Global.System.Windows.Forms.Control = Me.btnMoveUp
            point = New Global.System.Drawing.Point(336, 224)
            btnMoveUp.Location = point
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.TabIndex = 4
            Me.btnMoveUp.Text = "Move Up"
            Me.btnMoveDown.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnMoveDown.Enabled = False
            Dim btnMoveDown As Global.System.Windows.Forms.Control = Me.btnMoveDown
            point = New Global.System.Drawing.Point(336, 264)
            btnMoveDown.Location = point
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.TabIndex = 4
            Me.btnMoveDown.Text = "Move Down"
            Me.btnBuild.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnBuild.Enabled = False
            Dim btnBuild As Global.System.Windows.Forms.Control = Me.btnBuild
            point = New Global.System.Drawing.Point(336, 320)
            btnBuild.Location = point
            Me.btnBuild.Name = "btnBuild"
            Me.btnBuild.TabIndex = 4
            Me.btnBuild.Text = "Build ..."
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(336, 360)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "Cancel"
            Me.btnSelectOutputFile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSelectOutputFile As Global.System.Windows.Forms.Control = Me.btnSelectOutputFile
            point = New Global.System.Drawing.Point(280, 39)
            btnSelectOutputFile.Location = point
            Me.btnSelectOutputFile.Name = "btnSelectOutputFile"
            Dim btnSelectOutputFile2 As Global.System.Windows.Forms.Control = Me.btnSelectOutputFile
            size = New Global.System.Drawing.Size(32, 23)
            btnSelectOutputFile2.Size = size
            Me.btnSelectOutputFile.TabIndex = 4
            Me.btnSelectOutputFile.Text = "..."
            Me.btnAddDirectory.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnAddDirectory As Global.System.Windows.Forms.Control = Me.btnAddDirectory
            point = New Global.System.Drawing.Point(336, 128)
            btnAddDirectory.Location = point
            Me.btnAddDirectory.Name = "btnAddDirectory"
            Me.btnAddDirectory.TabIndex = 4
            Me.btnAddDirectory.Text = "Add Dir..."
            Me.AllowDrop = True
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(424, 405)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnAddFile)
            Me.Controls.Add(Me.ERFContentFiles)
            Me.Controls.Add(Me.cmbxErfType)
            Me.Controls.Add(Me.tbErfName)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnRemoveItem)
            Me.Controls.Add(Me.btnMoveUp)
            Me.Controls.Add(Me.btnMoveDown)
            Me.Controls.Add(Me.btnBuild)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSelectOutputFile)
            Me.Controls.Add(Me.btnAddDirectory)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(432, 424)
            Me.MinimumSize = size
            Me.Name = "frmERFManager"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "ERF Builder"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000298 RID: 664
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
