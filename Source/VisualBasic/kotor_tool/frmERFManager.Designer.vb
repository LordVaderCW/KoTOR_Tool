Namespace kotor_tool
	' Token: 0x0200004A RID: 74
	Public Partial Class frmERFManager
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents ERFContentFiles As Global.System.Windows.Forms.ListBox
        Friend WithEvents btnAddFile As Global.System.Windows.Forms.Button
        Friend WithEvents btnRemoveItem As Global.System.Windows.Forms.Button
        Friend WithEvents btnMoveUp As Global.System.Windows.Forms.Button
        Friend WithEvents btnMoveDown As Global.System.Windows.Forms.Button
        Friend WithEvents btnBuild As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents tbErfName As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbxErfType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnSelectOutputFile As Global.System.Windows.Forms.Button
        Friend WithEvents btnAddDirectory As Global.System.Windows.Forms.Button


		' Token: 0x0600049D RID: 1181 RVA: 0x0023D5B4 File Offset: 0x0023C5B4
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x060004B8 RID: 1208 RVA: 0x0023DB6C File Offset: 0x0023CB6C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmERFManager))
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
            Me.Label1.Location = New Global.System.Drawing.Point(48, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Output file name"
            Me.tbErfName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbErfName.Location = New Global.System.Drawing.Point(24, 40)
            Me.tbErfName.Name = "tbErfName"
            Me.tbErfName.Size = New Global.System.Drawing.Size(248, 20)
            Me.tbErfName.TabIndex = 1
            Me.tbErfName.Text = ""
            Me.cmbxErfType.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.cmbxErfType.Items.AddRange(New Object() {"MOD", "ERF", "HAK", "SAV"})
            Me.cmbxErfType.Location = New Global.System.Drawing.Point(352, 40)
            Me.cmbxErfType.Name = "cmbxErfType"
            Me.cmbxErfType.Size = New Global.System.Drawing.Size(48, 21)
            Me.cmbxErfType.TabIndex = 2
            Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Label2.Location = New Global.System.Drawing.Point(336, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(80, 24)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Output file type"
            Me.ERFContentFiles.AllowDrop = True
            Me.ERFContentFiles.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.ERFContentFiles.HorizontalScrollbar = True
            Me.ERFContentFiles.Location = New Global.System.Drawing.Point(24, 80)
            Me.ERFContentFiles.Name = "ERFContentFiles"
            Me.ERFContentFiles.SelectionMode = Global.System.Windows.Forms.SelectionMode.MultiExtended
            Me.ERFContentFiles.Size = New Global.System.Drawing.Size(288, 290)
            Me.ERFContentFiles.TabIndex = 3
            Me.btnAddFile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnAddFile.Location = New Global.System.Drawing.Point(336, 96)
            Me.btnAddFile.Name = "btnAddFile"
            Me.btnAddFile.TabIndex = 4
            Me.btnAddFile.Text = "Add Files..."
            Me.btnRemoveItem.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnRemoveItem.Enabled = False
            Me.btnRemoveItem.Location = New Global.System.Drawing.Point(336, 160)
            Me.btnRemoveItem.Name = "btnRemoveItem"
            Me.btnRemoveItem.TabIndex = 4
            Me.btnRemoveItem.Text = "Remove"
            Me.btnMoveUp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnMoveUp.Enabled = False
            Me.btnMoveUp.Location = New Global.System.Drawing.Point(336, 224)
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.TabIndex = 4
            Me.btnMoveUp.Text = "Move Up"
            Me.btnMoveDown.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnMoveDown.Enabled = False
            Me.btnMoveDown.Location = New Global.System.Drawing.Point(336, 264)
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.TabIndex = 4
            Me.btnMoveDown.Text = "Move Down"
            Me.btnBuild.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnBuild.Enabled = False
            Me.btnBuild.Location = New Global.System.Drawing.Point(336, 320)
            Me.btnBuild.Name = "btnBuild"
            Me.btnBuild.TabIndex = 4
            Me.btnBuild.Text = "Build ..."
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(336, 360)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "Cancel"
            Me.btnSelectOutputFile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSelectOutputFile.Location = New Global.System.Drawing.Point(280, 39)
            Me.btnSelectOutputFile.Name = "btnSelectOutputFile"
            Me.btnSelectOutputFile.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnSelectOutputFile.TabIndex = 4
            Me.btnSelectOutputFile.Text = "..."
            Me.btnAddDirectory.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnAddDirectory.Location = New Global.System.Drawing.Point(336, 128)
            Me.btnAddDirectory.Name = "btnAddDirectory"
            Me.btnAddDirectory.TabIndex = 4
            Me.btnAddDirectory.Text = "Add Dir..."
            Me.AllowDrop = True
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(424, 405)
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
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(432, 424)
            Me.Name = "frmERFManager"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "ERF Builder"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.ERFContentFiles.KeyUp, AddressOf Me.ERFContentFiles_KeyUp
            AddHandler Me.ERFContentFiles.SelectedIndexChanged, AddressOf Me.ERFContentFiles_SelectedIndexChanged
            AddHandler Me.ERFContentFiles.DragDrop, AddressOf Me.ERFContentFiles_DragDrop
            AddHandler Me.ERFContentFiles.DragEnter, AddressOf Me.ERFContentFiles_DragEnter
            AddHandler Me.btnAddFile.Click, AddressOf Me.btnAddFile_Click
            AddHandler Me.btnRemoveItem.Click, AddressOf Me.btnRemoveItem_Click
            AddHandler Me.btnMoveUp.Click, AddressOf Me.btnMoveUp_Click
            AddHandler Me.btnMoveDown.Click, AddressOf Me.btnMoveDown_Click
            AddHandler Me.btnBuild.Click, AddressOf Me.btnBuild_Click
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.tbErfName.TextChanged, AddressOf Me.tbErfName_TextChanged
            AddHandler Me.tbErfName.ModifiedChanged, AddressOf Me.tbErfName_ModifiedChanged
            AddHandler Me.cmbxErfType.SelectedIndexChanged, AddressOf Me.cmbxErfType_SelectedIndexChanged
            AddHandler Me.btnSelectOutputFile.Click, AddressOf Me.btnSelectOutputFile_Click
            AddHandler Me.btnAddDirectory.Click, AddressOf Me.btnAddDirectory_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
