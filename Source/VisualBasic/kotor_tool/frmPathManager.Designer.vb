Namespace kotor_tool
	' Token: 0x02000068 RID: 104
	Public Partial Class frmPathManager
		Inherits Global.System.Windows.Forms.Form

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
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmPathManager))
            Me.tbKotorPath = New Global.System.Windows.Forms.TextBox()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.btnKotorPath = New Global.System.Windows.Forms.Button()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
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
            Dim tbKotorPath As Global.System.Windows.Forms.Control = Me.tbKotorPath
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(128, 16)
            tbKotorPath.Location = point
            Me.tbKotorPath.Name = "tbKotorPath"
            Dim tbKotorPath2 As Global.System.Windows.Forms.Control = Me.tbKotorPath
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(336, 20)
            tbKotorPath2.Size = size
            Me.tbKotorPath.TabIndex = 0
            Me.tbKotorPath.Text = ""
            Dim label As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(32, 16)
            label.Location = point
            Me.Label7.Name = "Label7"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(88, 16)
            label2.Size = size
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "KotOR root path"
            Me.btnKotorPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnKotorPath As Global.System.Windows.Forms.Control = Me.btnKotorPath
            point = New Global.System.Drawing.Point(488, 16)
            btnKotorPath.Location = point
            Me.btnKotorPath.Name = "btnKotorPath"
            Dim btnKotorPath2 As Global.System.Windows.Forms.Control = Me.btnKotorPath
            size = New Global.System.Drawing.Size(24, 20)
            btnKotorPath2.Size = size
            Me.btnKotorPath.TabIndex = 2
            Me.btnKotorPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnKotorPath, "Click to select a new root path for your KotOR installation")
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(376, 208)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 19
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(464, 208)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 20
            Me.btnCancel.Text = "Cancel"
            Me.btnKotorPath2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnKotorPath3 As Global.System.Windows.Forms.Control = Me.btnKotorPath2
            point = New Global.System.Drawing.Point(488, 16)
            btnKotorPath3.Location = point
            Me.btnKotorPath2.Name = "btnKotorPath2"
            Dim btnKotorPath4 As Global.System.Windows.Forms.Control = Me.btnKotorPath2
            size = New Global.System.Drawing.Size(24, 20)
            btnKotorPath4.Size = size
            Me.btnKotorPath2.TabIndex = 22
            Me.btnKotorPath2.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnKotorPath2, "Click to select a new root path for your KotOR installation")
            Me.btnSavePath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSavePath As Global.System.Windows.Forms.Control = Me.btnSavePath
            point = New Global.System.Drawing.Point(488, 48)
            btnSavePath.Location = point
            Me.btnSavePath.Name = "btnSavePath"
            Dim btnSavePath2 As Global.System.Windows.Forms.Control = Me.btnSavePath
            size = New Global.System.Drawing.Size(24, 20)
            btnSavePath2.Size = size
            Me.btnSavePath.TabIndex = 16
            Me.btnSavePath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnSavePath, "Click to select a new path for saving extracted files")
            Me.btnImageViewerPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnImageViewerPath As Global.System.Windows.Forms.Control = Me.btnImageViewerPath
            point = New Global.System.Drawing.Point(488, 80)
            btnImageViewerPath.Location = point
            Me.btnImageViewerPath.Name = "btnImageViewerPath"
            Dim btnImageViewerPath2 As Global.System.Windows.Forms.Control = Me.btnImageViewerPath
            size = New Global.System.Drawing.Size(24, 20)
            btnImageViewerPath2.Size = size
            Me.btnImageViewerPath.TabIndex = 18
            Me.btnImageViewerPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnImageViewerPath, "Click to select a new path for the KotOR override directory")
            Me.btnModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnModuleExportPath As Global.System.Windows.Forms.Control = Me.btnModuleExportPath
            point = New Global.System.Drawing.Point(488, 112)
            btnModuleExportPath.Location = point
            Me.btnModuleExportPath.Name = "btnModuleExportPath"
            Dim btnModuleExportPath2 As Global.System.Windows.Forms.Control = Me.btnModuleExportPath
            size = New Global.System.Drawing.Size(24, 20)
            btnModuleExportPath2.Size = size
            Me.btnModuleExportPath.TabIndex = 18
            Me.btnModuleExportPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnModuleExportPath, "Click to select a new path for the KotOR override directory")
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            point = New Global.System.Drawing.Point(24, 16)
            tabControl.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
            size = New Global.System.Drawing.Size(544, 176)
            tabControl2.Size = size
            Me.TabControl1.TabIndex = 21
            Me.TabPage1.Controls.Add(Me.btnAutoDetectKotor1)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.btnKotorPath)
            Me.TabPage1.Controls.Add(Me.tbKotorPath)
            Dim tabPage As Global.System.Windows.Forms.Control = Me.TabPage1
            point = New Global.System.Drawing.Point(4, 22)
            tabPage.Location = point
            Me.TabPage1.Name = "TabPage1"
            Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
            size = New Global.System.Drawing.Size(536, 150)
            tabPage2.Size = size
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "SW:KotOR"
            Me.btnAutoDetectKotor1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnAutoDetectKotor As Global.System.Windows.Forms.Control = Me.btnAutoDetectKotor1
            point = New Global.System.Drawing.Point(328, 56)
            btnAutoDetectKotor.Location = point
            Me.btnAutoDetectKotor1.Name = "btnAutoDetectKotor1"
            Dim btnAutoDetectKotor2 As Global.System.Windows.Forms.Control = Me.btnAutoDetectKotor1
            size = New Global.System.Drawing.Size(136, 23)
            btnAutoDetectKotor2.Size = size
            Me.btnAutoDetectKotor1.TabIndex = 13
            Me.btnAutoDetectKotor1.Text = "Auto Detect KotOR"
            Me.TabPage2.Controls.Add(Me.btnAutoDetectKotor2)
            Me.TabPage2.Controls.Add(Me.Label14)
            Me.TabPage2.Controls.Add(Me.btnKotorPath2)
            Me.TabPage2.Controls.Add(Me.tbKotorPath2)
            Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage2
            point = New Global.System.Drawing.Point(4, 22)
            tabPage3.Location = point
            Me.TabPage2.Name = "TabPage2"
            Dim tabPage4 As Global.System.Windows.Forms.Control = Me.TabPage2
            size = New Global.System.Drawing.Size(536, 150)
            tabPage4.Size = size
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "SW:Kotor II TSL"
            Me.btnAutoDetectKotor2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnAutoDetectKotor3 As Global.System.Windows.Forms.Control = Me.btnAutoDetectKotor2
            point = New Global.System.Drawing.Point(328, 56)
            btnAutoDetectKotor3.Location = point
            Me.btnAutoDetectKotor2.Name = "btnAutoDetectKotor2"
            Dim btnAutoDetectKotor4 As Global.System.Windows.Forms.Control = Me.btnAutoDetectKotor2
            size = New Global.System.Drawing.Size(136, 23)
            btnAutoDetectKotor4.Size = size
            Me.btnAutoDetectKotor2.TabIndex = 41
            Me.btnAutoDetectKotor2.Text = "Auto Detect KotOR II"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(8, 16)
            label3.Location = point
            Me.Label14.Name = "Label14"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(112, 16)
            label4.Size = size
            Me.Label14.TabIndex = 40
            Me.Label14.Text = "KotOR:TSL root path"
            Me.tbKotorPath2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbKotorPath3 As Global.System.Windows.Forms.Control = Me.tbKotorPath2
            point = New Global.System.Drawing.Point(128, 16)
            tbKotorPath3.Location = point
            Me.tbKotorPath2.Name = "tbKotorPath2"
            Dim tbKotorPath4 As Global.System.Windows.Forms.Control = Me.tbKotorPath2
            size = New Global.System.Drawing.Size(336, 20)
            tbKotorPath4.Size = size
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
            Dim tabPage5 As Global.System.Windows.Forms.Control = Me.TabPage3
            point = New Global.System.Drawing.Point(4, 22)
            tabPage5.Location = point
            Me.TabPage3.Name = "TabPage3"
            Dim tabPage6 As Global.System.Windows.Forms.Control = Me.TabPage3
            size = New Global.System.Drawing.Size(536, 150)
            tabPage6.Size = size
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Other Paths"
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(24, 48)
            label5.Location = point
            Me.Label6.Name = "Label6"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(88, 16)
            label6.Size = size
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "Save path"
            Me.btnImportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnImportPath As Global.System.Windows.Forms.Control = Me.btnImportPath
            point = New Global.System.Drawing.Point(488, 16)
            btnImportPath.Location = point
            Me.btnImportPath.Name = "btnImportPath"
            Dim btnImportPath2 As Global.System.Windows.Forms.Control = Me.btnImportPath
            size = New Global.System.Drawing.Size(24, 20)
            btnImportPath2.Size = size
            Me.btnImportPath.TabIndex = 14
            Me.btnImportPath.Text = "..."
            Me.tbSavePath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbSavePath As Global.System.Windows.Forms.Control = Me.tbSavePath
            point = New Global.System.Drawing.Point(128, 48)
            tbSavePath.Location = point
            Me.tbSavePath.Name = "tbSavePath"
            Dim tbSavePath2 As Global.System.Windows.Forms.Control = Me.tbSavePath
            size = New Global.System.Drawing.Size(336, 20)
            tbSavePath2.Size = size
            Me.tbSavePath.TabIndex = 15
            Me.tbSavePath.Text = ""
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(24, 16)
            label7.Location = point
            Me.Label5.Name = "Label5"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(88, 16)
            label8.Size = size
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Import path"
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(24, 80)
            label9.Location = point
            Me.Label3.Name = "Label3"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(96, 16)
            label10.Size = size
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Image Viewer path"
            Me.tbImageViewerPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbImageViewerPath As Global.System.Windows.Forms.Control = Me.tbImageViewerPath
            point = New Global.System.Drawing.Point(128, 80)
            tbImageViewerPath.Location = point
            Me.tbImageViewerPath.Name = "tbImageViewerPath"
            Dim tbImageViewerPath2 As Global.System.Windows.Forms.Control = Me.tbImageViewerPath
            size = New Global.System.Drawing.Size(336, 20)
            tbImageViewerPath2.Size = size
            Me.tbImageViewerPath.TabIndex = 17
            Me.tbImageViewerPath.Text = ""
            Me.tbImportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbImportPath As Global.System.Windows.Forms.Control = Me.tbImportPath
            point = New Global.System.Drawing.Point(128, 16)
            tbImportPath.Location = point
            Me.tbImportPath.Name = "tbImportPath"
            Dim tbImportPath2 As Global.System.Windows.Forms.Control = Me.tbImportPath
            size = New Global.System.Drawing.Size(336, 20)
            tbImportPath2.Size = size
            Me.tbImportPath.TabIndex = 13
            Me.tbImportPath.Text = ""
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(24, 112)
            label11.Location = point
            Me.Label15.Name = "Label15"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(96, 16)
            label12.Size = size
            Me.Label15.TabIndex = 4
            Me.Label15.Text = "Model Export path"
            Me.tbModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbModuleExportPath As Global.System.Windows.Forms.Control = Me.tbModuleExportPath
            point = New Global.System.Drawing.Point(128, 112)
            tbModuleExportPath.Location = point
            Me.tbModuleExportPath.Name = "tbModuleExportPath"
            Dim tbModuleExportPath2 As Global.System.Windows.Forms.Control = Me.tbModuleExportPath
            size = New Global.System.Drawing.Size(336, 20)
            tbModuleExportPath2.Size = size
            Me.tbModuleExportPath.TabIndex = 17
            Me.tbModuleExportPath.Text = ""
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(592, 245)
            Me.ClientSize = size
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            size = New Global.System.Drawing.Size(1600, 376)
            Me.MaximumSize = size
            Me.MinimizeBox = False
            size = New Global.System.Drawing.Size(600, 272)
            Me.MinimumSize = size
            Me.Name = "frmPathManager"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Path Manager"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x0400067C RID: 1660
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
