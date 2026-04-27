Namespace kotor_tool
	' Token: 0x0200005B RID: 91
	Public Partial Class frmMdlOpsSwitches
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600077E RID: 1918 RVA: 0x00259630 File Offset: 0x00258630
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600079B RID: 1947 RVA: 0x00259998 File Offset: 0x00258998
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmMdlOpsSwitches))
            Me.chkbExtractAnimations = New Global.System.Windows.Forms.CheckBox()
            Me.chkbConvertSkin = New Global.System.Windows.Forms.CheckBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.nudNumberToExtract = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.chkbEachModelInOwnDir = New Global.System.Windows.Forms.CheckBox()
            Me.chkbCleanWorkingDir = New Global.System.Windows.Forms.CheckBox()
            Me.tbModelExtractionPath = New Global.System.Windows.Forms.TextBox()
            Me.btnModuleExportPath = New Global.System.Windows.Forms.Button()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.chkbMdlAlignDataOnly = New Global.System.Windows.Forms.CheckBox()
            Me.chkbExportMdlAlignData = New Global.System.Windows.Forms.CheckBox()
            CType(Me.nudNumberToExtract, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.chkbExtractAnimations.Checked = True
            Me.chkbExtractAnimations.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbExtractAnimations As Global.System.Windows.Forms.Control = Me.chkbExtractAnimations
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(24, 56)
            chkbExtractAnimations.Location = point
            Me.chkbExtractAnimations.Name = "chkbExtractAnimations"
            Dim chkbExtractAnimations2 As Global.System.Windows.Forms.Control = Me.chkbExtractAnimations
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(144, 24)
            chkbExtractAnimations2.Size = size
            Me.chkbExtractAnimations.TabIndex = 0
            Me.chkbExtractAnimations.Text = "Extract animations"
            Me.chkbConvertSkin.Checked = True
            Me.chkbConvertSkin.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbConvertSkin As Global.System.Windows.Forms.Control = Me.chkbConvertSkin
            point = New Global.System.Drawing.Point(24, 88)
            chkbConvertSkin.Location = point
            Me.chkbConvertSkin.Name = "chkbConvertSkin"
            Dim chkbConvertSkin2 As Global.System.Windows.Forms.Control = Me.chkbConvertSkin
            size = New Global.System.Drawing.Size(144, 24)
            chkbConvertSkin2.Size = size
            Me.chkbConvertSkin.TabIndex = 2
            Me.chkbConvertSkin.Text = "Convert skin to trimesh"
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(152, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(168, 23)
            label2.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Select model extraction options"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(280, 216)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 7
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(384, 216)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 8
            Me.btnCancel.Text = "Cancel"
            Dim nudNumberToExtract As Global.System.Windows.Forms.Control = Me.nudNumberToExtract
            point = New Global.System.Drawing.Point(248, 126)
            nudNumberToExtract.Location = point
            Dim nudNumberToExtract2 As Global.System.Windows.Forms.NumericUpDown = Me.nudNumberToExtract
            Dim num As Decimal = New Decimal(New Integer() {10000, 0, 0, 0})
            nudNumberToExtract2.Maximum = num
            Dim nudNumberToExtract3 As Global.System.Windows.Forms.NumericUpDown = Me.nudNumberToExtract
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudNumberToExtract3.Minimum = num
            Me.nudNumberToExtract.Name = "nudNumberToExtract"
            Dim nudNumberToExtract4 As Global.System.Windows.Forms.Control = Me.nudNumberToExtract
            size = New Global.System.Drawing.Size(56, 20)
            nudNumberToExtract4.Size = size
            Me.nudNumberToExtract.TabIndex = 4
            Me.nudNumberToExtract.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudNumberToExtract5 As Global.System.Windows.Forms.NumericUpDown = Me.nudNumberToExtract
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudNumberToExtract5.Value = num
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(24, 128)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(216, 24)
            label4.Size = size
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Number of consecutive models to extract"
            Me.chkbEachModelInOwnDir.Checked = True
            Me.chkbEachModelInOwnDir.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbEachModelInOwnDir As Global.System.Windows.Forms.Control = Me.chkbEachModelInOwnDir
            point = New Global.System.Drawing.Point(200, 88)
            chkbEachModelInOwnDir.Location = point
            Me.chkbEachModelInOwnDir.Name = "chkbEachModelInOwnDir"
            Dim chkbEachModelInOwnDir2 As Global.System.Windows.Forms.Control = Me.chkbEachModelInOwnDir
            size = New Global.System.Drawing.Size(168, 24)
            chkbEachModelInOwnDir2.Size = size
            Me.chkbEachModelInOwnDir.TabIndex = 3
            Me.chkbEachModelInOwnDir.Text = "Each model in own directory"
            Dim chkbCleanWorkingDir As Global.System.Windows.Forms.Control = Me.chkbCleanWorkingDir
            point = New Global.System.Drawing.Point(200, 56)
            chkbCleanWorkingDir.Location = point
            Me.chkbCleanWorkingDir.Name = "chkbCleanWorkingDir"
            Dim chkbCleanWorkingDir2 As Global.System.Windows.Forms.Control = Me.chkbCleanWorkingDir
            size = New Global.System.Drawing.Size(272, 24)
            chkbCleanWorkingDir2.Size = size
            Me.chkbCleanWorkingDir.TabIndex = 1
            Me.chkbCleanWorkingDir.Text = "Clean Model Export directory before export starts"
            Me.tbModelExtractionPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbModelExtractionPath As Global.System.Windows.Forms.Control = Me.tbModelExtractionPath
            point = New Global.System.Drawing.Point(24, 176)
            tbModelExtractionPath.Location = point
            Me.tbModelExtractionPath.Name = "tbModelExtractionPath"
            Dim tbModelExtractionPath2 As Global.System.Windows.Forms.Control = Me.tbModelExtractionPath
            size = New Global.System.Drawing.Size(392, 20)
            tbModelExtractionPath2.Size = size
            Me.tbModelExtractionPath.TabIndex = 5
            Me.tbModelExtractionPath.Text = ""
            Me.btnModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnModuleExportPath As Global.System.Windows.Forms.Control = Me.btnModuleExportPath
            point = New Global.System.Drawing.Point(424, 176)
            btnModuleExportPath.Location = point
            Me.btnModuleExportPath.Name = "btnModuleExportPath"
            Dim btnModuleExportPath2 As Global.System.Windows.Forms.Control = Me.btnModuleExportPath
            size = New Global.System.Drawing.Size(24, 20)
            btnModuleExportPath2.Size = size
            Me.btnModuleExportPath.TabIndex = 6
            Me.btnModuleExportPath.Text = "..."
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(24, 160)
            label5.Location = point
            Me.Label15.Name = "Label15"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(96, 16)
            label6.Size = size
            Me.Label15.TabIndex = 20
            Me.Label15.Text = "Model Export path"
            Dim chkbMdlAlignDataOnly As Global.System.Windows.Forms.Control = Me.chkbMdlAlignDataOnly
            point = New Global.System.Drawing.Point(312, 136)
            chkbMdlAlignDataOnly.Location = point
            Me.chkbMdlAlignDataOnly.Name = "chkbMdlAlignDataOnly"
            Dim chkbMdlAlignDataOnly2 As Global.System.Windows.Forms.Control = Me.chkbMdlAlignDataOnly
            size = New Global.System.Drawing.Size(168, 16)
            chkbMdlAlignDataOnly2.Size = size
            Me.chkbMdlAlignDataOnly.TabIndex = 3
            Me.chkbMdlAlignDataOnly.Text = "Alignment data only"
            Me.chkbMdlAlignDataOnly.Visible = False
            Dim chkbExportMdlAlignData As Global.System.Windows.Forms.Control = Me.chkbExportMdlAlignData
            point = New Global.System.Drawing.Point(312, 112)
            chkbExportMdlAlignData.Location = point
            Me.chkbExportMdlAlignData.Name = "chkbExportMdlAlignData"
            Dim chkbExportMdlAlignData2 As Global.System.Windows.Forms.Control = Me.chkbExportMdlAlignData
            size = New Global.System.Drawing.Size(168, 16)
            chkbExportMdlAlignData2.Size = size
            Me.chkbExportMdlAlignData.TabIndex = 3
            Me.chkbExportMdlAlignData.Text = "Create model alignment data"
            Me.chkbExportMdlAlignData.Visible = False
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(480, 253)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.btnModuleExportPath)
            Me.Controls.Add(Me.tbModelExtractionPath)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.nudNumberToExtract)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.chkbExtractAnimations)
            Me.Controls.Add(Me.chkbConvertSkin)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.chkbEachModelInOwnDir)
            Me.Controls.Add(Me.chkbCleanWorkingDir)
            Me.Controls.Add(Me.chkbMdlAlignDataOnly)
            Me.Controls.Add(Me.chkbExportMdlAlignData)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(1600, 280)
            Me.MaximumSize = size
            size = New Global.System.Drawing.Size(488, 280)
            Me.MinimumSize = size
            Me.Name = "frmMdlOpsSwitches"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Model Extraction Options"
            CType(Me.nudNumberToExtract, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040003E7 RID: 999
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
