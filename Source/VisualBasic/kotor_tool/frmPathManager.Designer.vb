Namespace kotor_tool
	' Token: 0x02000068 RID: 104
	Public Partial Class frmPathManager
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents tbKotorPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnKotorPath As Global.System.Windows.Forms.Button
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As Global.System.Windows.Forms.ToolTip
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents tbKotorPath2 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents btnImportPath As Global.System.Windows.Forms.Button
        Friend WithEvents btnSavePath As Global.System.Windows.Forms.Button
        Friend WithEvents tbSavePath As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents tbImageViewerPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnImageViewerPath As Global.System.Windows.Forms.Button
        Friend WithEvents tbImportPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnKotorPath2 As Global.System.Windows.Forms.Button
        Friend WithEvents btnAutoDetectKotor1 As Global.System.Windows.Forms.Button
        Friend WithEvents btnAutoDetectKotor2 As Global.System.Windows.Forms.Button
        Friend WithEvents TabPage3 As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents tbModuleExportPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnModuleExportPath As Global.System.Windows.Forms.Button


		' Token: 0x06000CD4 RID: 3284 RVA: 0x00283DF8 File Offset: 0x00282DF8
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000D0B RID: 3339 RVA: 0x00284520 File Offset: 0x00283520
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmPathManager))
            Me.tbKotorPath = New Global.System.Windows.Forms.TextBox()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.btnKotorPath = New Global.System.Windows.Forms.Button()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip()
            Me.btnKotorPath2 = New Global.System.Windows.Forms.Button()
            Me.btnSavePath = New Global.System.Windows.Forms.Button()
            Me.btnImageViewerPath = New Global.System.Windows.Forms.Button()
            Me.btnModuleExportPath = New Global.System.Windows.Forms.Button()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
            Me.btnAutoDetectKotor1 = New Global.System.Windows.Forms.Button()
            Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
            Me.btnAutoDetectKotor2 = New Global.System.Windows.Forms.Button()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.tbKotorPath2 = New Global.System.Windows.Forms.TextBox()
            Me.TabPage3 = New Global.System.Windows.Forms.TabPage()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.btnImportPath = New Global.System.Windows.Forms.Button()
            Me.tbSavePath = New Global.System.Windows.Forms.TextBox()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.tbImageViewerPath = New Global.System.Windows.Forms.TextBox()
            Me.tbImportPath = New Global.System.Windows.Forms.TextBox()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.tbModuleExportPath = New Global.System.Windows.Forms.TextBox()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.SuspendLayout()
            Me.tbKotorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbKotorPath.Location = New Global.System.Drawing.Point(128, 16)
            Me.tbKotorPath.Name = "tbKotorPath"
            Me.tbKotorPath.Size = New Global.System.Drawing.Size(336, 20)
            Me.tbKotorPath.TabIndex = 0
            Me.tbKotorPath.Text = ""
            Me.Label7.Location = New Global.System.Drawing.Point(32, 16)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "KotOR root path"
            Me.btnKotorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnKotorPath.Location = New Global.System.Drawing.Point(488, 16)
            Me.btnKotorPath.Name = "btnKotorPath"
            Me.btnKotorPath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnKotorPath.TabIndex = 2
            Me.btnKotorPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnKotorPath, "Click to select a new root path for your KotOR installation")
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(376, 208)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 19
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(464, 208)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 20
            Me.btnCancel.Text = "Cancel"
            Me.btnKotorPath2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnKotorPath2.Location = New Global.System.Drawing.Point(488, 16)
            Me.btnKotorPath2.Name = "btnKotorPath2"
            Me.btnKotorPath2.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnKotorPath2.TabIndex = 22
            Me.btnKotorPath2.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnKotorPath2, "Click to select a new root path for your KotOR installation")
            Me.btnSavePath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSavePath.Location = New Global.System.Drawing.Point(488, 48)
            Me.btnSavePath.Name = "btnSavePath"
            Me.btnSavePath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnSavePath.TabIndex = 16
            Me.btnSavePath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnSavePath, "Click to select a new path for saving extracted files")
            Me.btnImageViewerPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnImageViewerPath.Location = New Global.System.Drawing.Point(488, 80)
            Me.btnImageViewerPath.Name = "btnImageViewerPath"
            Me.btnImageViewerPath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnImageViewerPath.TabIndex = 18
            Me.btnImageViewerPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnImageViewerPath, "Click to select a new path for the KotOR override directory")
            Me.btnModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnModuleExportPath.Location = New Global.System.Drawing.Point(488, 112)
            Me.btnModuleExportPath.Name = "btnModuleExportPath"
            Me.btnModuleExportPath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnModuleExportPath.TabIndex = 18
            Me.btnModuleExportPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnModuleExportPath, "Click to select a new path for the KotOR override directory")
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Location = New Global.System.Drawing.Point(24, 16)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(544, 176)
            Me.TabControl1.TabIndex = 21
            Me.TabPage1.Controls.Add(Me.btnAutoDetectKotor1)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.btnKotorPath)
            Me.TabPage1.Controls.Add(Me.tbKotorPath)
            Me.TabPage1.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New Global.System.Drawing.Size(536, 150)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "SW:KotOR"
            Me.btnAutoDetectKotor1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnAutoDetectKotor1.Location = New Global.System.Drawing.Point(328, 56)
            Me.btnAutoDetectKotor1.Name = "btnAutoDetectKotor1"
            Me.btnAutoDetectKotor1.Size = New Global.System.Drawing.Size(136, 23)
            Me.btnAutoDetectKotor1.TabIndex = 13
            Me.btnAutoDetectKotor1.Text = "Auto Detect KotOR"
            Me.TabPage2.Controls.Add(Me.btnAutoDetectKotor2)
            Me.TabPage2.Controls.Add(Me.Label14)
            Me.TabPage2.Controls.Add(Me.btnKotorPath2)
            Me.TabPage2.Controls.Add(Me.tbKotorPath2)
            Me.TabPage2.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New Global.System.Drawing.Size(536, 150)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "SW:Kotor II TSL"
            Me.btnAutoDetectKotor2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnAutoDetectKotor2.Location = New Global.System.Drawing.Point(328, 56)
            Me.btnAutoDetectKotor2.Name = "btnAutoDetectKotor2"
            Me.btnAutoDetectKotor2.Size = New Global.System.Drawing.Size(136, 23)
            Me.btnAutoDetectKotor2.TabIndex = 41
            Me.btnAutoDetectKotor2.Text = "Auto Detect KotOR II"
            Me.Label14.Location = New Global.System.Drawing.Point(8, 16)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label14.TabIndex = 40
            Me.Label14.Text = "KotOR:TSL root path"
            Me.tbKotorPath2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbKotorPath2.Location = New Global.System.Drawing.Point(128, 16)
            Me.tbKotorPath2.Name = "tbKotorPath2"
            Me.tbKotorPath2.Size = New Global.System.Drawing.Size(336, 20)
            Me.tbKotorPath2.TabIndex = 19
            Me.tbKotorPath2.Text = ""
            Me.TabPage3.Controls.Add(Me.Label6)
            Me.TabPage3.Controls.Add(Me.btnImportPath)
            Me.TabPage3.Controls.Add(Me.tbSavePath)
            Me.TabPage3.Controls.Add(Me.Label5)
            Me.TabPage3.Controls.Add(Me.Label3)
            Me.TabPage3.Controls.Add(Me.tbImageViewerPath)
            Me.TabPage3.Controls.Add(Me.tbImportPath)
            Me.TabPage3.Controls.Add(Me.btnSavePath)
            Me.TabPage3.Controls.Add(Me.btnImageViewerPath)
            Me.TabPage3.Controls.Add(Me.Label15)
            Me.TabPage3.Controls.Add(Me.tbModuleExportPath)
            Me.TabPage3.Controls.Add(Me.btnModuleExportPath)
            Me.TabPage3.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New Global.System.Drawing.Size(536, 150)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Other Paths"
            Me.Label6.Location = New Global.System.Drawing.Point(24, 48)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "Save path"
            Me.btnImportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnImportPath.Location = New Global.System.Drawing.Point(488, 16)
            Me.btnImportPath.Name = "btnImportPath"
            Me.btnImportPath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnImportPath.TabIndex = 14
            Me.btnImportPath.Text = "..."
            Me.tbSavePath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbSavePath.Location = New Global.System.Drawing.Point(128, 48)
            Me.tbSavePath.Name = "tbSavePath"
            Me.tbSavePath.Size = New Global.System.Drawing.Size(336, 20)
            Me.tbSavePath.TabIndex = 15
            Me.tbSavePath.Text = ""
            Me.Label5.Location = New Global.System.Drawing.Point(24, 16)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Import path"
            Me.Label3.Location = New Global.System.Drawing.Point(24, 80)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Image Viewer path"
            Me.tbImageViewerPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbImageViewerPath.Location = New Global.System.Drawing.Point(128, 80)
            Me.tbImageViewerPath.Name = "tbImageViewerPath"
            Me.tbImageViewerPath.Size = New Global.System.Drawing.Size(336, 20)
            Me.tbImageViewerPath.TabIndex = 17
            Me.tbImageViewerPath.Text = ""
            Me.tbImportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbImportPath.Location = New Global.System.Drawing.Point(128, 16)
            Me.tbImportPath.Name = "tbImportPath"
            Me.tbImportPath.Size = New Global.System.Drawing.Size(336, 20)
            Me.tbImportPath.TabIndex = 13
            Me.tbImportPath.Text = ""
            Me.Label15.Location = New Global.System.Drawing.Point(24, 112)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label15.TabIndex = 4
            Me.Label15.Text = "Model Export path"
            Me.tbModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbModuleExportPath.Location = New Global.System.Drawing.Point(128, 112)
            Me.tbModuleExportPath.Name = "tbModuleExportPath"
            Me.tbModuleExportPath.Size = New Global.System.Drawing.Size(336, 20)
            Me.tbModuleExportPath.TabIndex = 17
            Me.tbModuleExportPath.Text = ""
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(592, 245)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New Global.System.Drawing.Size(1600, 376)
            Me.MinimizeBox = False
            Me.MinimumSize = New Global.System.Drawing.Size(600, 272)
            Me.Name = "frmPathManager"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Path Manager"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnKotorPath.Click, AddressOf Me.btnKotorPath_Click
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.btnImportPath.Click, AddressOf Me.btnImportPath_Click
            AddHandler Me.btnSavePath.Click, AddressOf Me.btnSavePath_Click
            AddHandler Me.btnImageViewerPath.Click, AddressOf Me.btnImageViewerPath_Click
            AddHandler Me.btnKotorPath2.Click, AddressOf Me.btnKotorPath2_Click
            AddHandler Me.btnAutoDetectKotor1.Click, AddressOf Me.btnAutoDetectKotor1_Click
            AddHandler Me.btnAutoDetectKotor2.Click, AddressOf Me.btnAutoDetectKotor2_Click
            AddHandler Me.btnModuleExportPath.Click, AddressOf Me.btnModuleExportPath_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
