Namespace kotor_tool
	' Token: 0x0200005B RID: 91
	Public Partial Class frmMdlOpsSwitches
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents chkbExtractAnimations As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbConvertSkin As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents nudNumberToExtract As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbEachModelInOwnDir As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbCleanWorkingDir As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tbModelExtractionPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnModuleExportPath As Global.System.Windows.Forms.Button
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbMdlAlignDataOnly As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbExportMdlAlignData As Global.System.Windows.Forms.CheckBox


        ' Token: 0x0600077E RID: 1918 RVA: 0x00259630 File Offset: 0x00258630
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x0600079B RID: 1947 RVA: 0x00259998 File Offset: 0x00258998
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.chkbExtractAnimations = New System.Windows.Forms.CheckBox()
            Me.chkbConvertSkin = New System.Windows.Forms.CheckBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.nudNumberToExtract = New System.Windows.Forms.NumericUpDown()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.chkbEachModelInOwnDir = New System.Windows.Forms.CheckBox()
            Me.chkbCleanWorkingDir = New System.Windows.Forms.CheckBox()
            Me.tbModelExtractionPath = New System.Windows.Forms.TextBox()
            Me.btnModuleExportPath = New System.Windows.Forms.Button()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.chkbMdlAlignDataOnly = New System.Windows.Forms.CheckBox()
            Me.chkbExportMdlAlignData = New System.Windows.Forms.CheckBox()
            CType(Me.nudNumberToExtract, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chkbExtractAnimations
            '
            Me.chkbExtractAnimations.Checked = True
            Me.chkbExtractAnimations.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbExtractAnimations.Location = New System.Drawing.Point(24, 56)
            Me.chkbExtractAnimations.Name = "chkbExtractAnimations"
            Me.chkbExtractAnimations.Size = New System.Drawing.Size(144, 24)
            Me.chkbExtractAnimations.TabIndex = 0
            Me.chkbExtractAnimations.Text = "Extract animations"
            '
            'chkbConvertSkin
            '
            Me.chkbConvertSkin.Checked = True
            Me.chkbConvertSkin.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbConvertSkin.Location = New System.Drawing.Point(24, 88)
            Me.chkbConvertSkin.Name = "chkbConvertSkin"
            Me.chkbConvertSkin.Size = New System.Drawing.Size(144, 24)
            Me.chkbConvertSkin.TabIndex = 2
            Me.chkbConvertSkin.Text = "Convert skin to trimesh"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.Label1.Location = New System.Drawing.Point(24, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(456, 44)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Select model extraction options"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(304, 206)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(75, 23)
            Me.btnOK.TabIndex = 7
            Me.btnOK.Text = "OK"
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(397, 206)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 8
            Me.btnCancel.Text = "Cancel"
            '
            'nudNumberToExtract
            '
            Me.nudNumberToExtract.Location = New System.Drawing.Point(248, 126)
            Me.nudNumberToExtract.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.nudNumberToExtract.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudNumberToExtract.Name = "nudNumberToExtract"
            Me.nudNumberToExtract.Size = New System.Drawing.Size(56, 20)
            Me.nudNumberToExtract.TabIndex = 4
            Me.nudNumberToExtract.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudNumberToExtract.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(24, 128)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(216, 24)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Number of consecutive models to extract"
            '
            'chkbEachModelInOwnDir
            '
            Me.chkbEachModelInOwnDir.Checked = True
            Me.chkbEachModelInOwnDir.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbEachModelInOwnDir.Location = New System.Drawing.Point(200, 88)
            Me.chkbEachModelInOwnDir.Name = "chkbEachModelInOwnDir"
            Me.chkbEachModelInOwnDir.Size = New System.Drawing.Size(168, 24)
            Me.chkbEachModelInOwnDir.TabIndex = 3
            Me.chkbEachModelInOwnDir.Text = "Each model in own directory"
            '
            'chkbCleanWorkingDir
            '
            Me.chkbCleanWorkingDir.Location = New System.Drawing.Point(200, 56)
            Me.chkbCleanWorkingDir.Name = "chkbCleanWorkingDir"
            Me.chkbCleanWorkingDir.Size = New System.Drawing.Size(272, 24)
            Me.chkbCleanWorkingDir.TabIndex = 1
            Me.chkbCleanWorkingDir.Text = "Clean Model Export directory before export starts"
            '
            'tbModelExtractionPath
            '
            Me.tbModelExtractionPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbModelExtractionPath.Location = New System.Drawing.Point(24, 176)
            Me.tbModelExtractionPath.Name = "tbModelExtractionPath"
            Me.tbModelExtractionPath.Size = New System.Drawing.Size(416, 20)
            Me.tbModelExtractionPath.TabIndex = 5
            '
            'btnModuleExportPath
            '
            Me.btnModuleExportPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnModuleExportPath.Location = New System.Drawing.Point(448, 176)
            Me.btnModuleExportPath.Name = "btnModuleExportPath"
            Me.btnModuleExportPath.Size = New System.Drawing.Size(24, 20)
            Me.btnModuleExportPath.TabIndex = 6
            Me.btnModuleExportPath.Text = "..."
            '
            'Label15
            '
            Me.Label15.Location = New System.Drawing.Point(24, 160)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(96, 16)
            Me.Label15.TabIndex = 20
            Me.Label15.Text = "Model Export path"
            '
            'chkbMdlAlignDataOnly
            '
            Me.chkbMdlAlignDataOnly.Location = New System.Drawing.Point(312, 136)
            Me.chkbMdlAlignDataOnly.Name = "chkbMdlAlignDataOnly"
            Me.chkbMdlAlignDataOnly.Size = New System.Drawing.Size(168, 16)
            Me.chkbMdlAlignDataOnly.TabIndex = 3
            Me.chkbMdlAlignDataOnly.Text = "Alignment data only"
            Me.chkbMdlAlignDataOnly.Visible = False
            '
            'chkbExportMdlAlignData
            '
            Me.chkbExportMdlAlignData.Location = New System.Drawing.Point(312, 112)
            Me.chkbExportMdlAlignData.Name = "chkbExportMdlAlignData"
            Me.chkbExportMdlAlignData.Size = New System.Drawing.Size(168, 16)
            Me.chkbExportMdlAlignData.TabIndex = 3
            Me.chkbExportMdlAlignData.Text = "Create model alignment data"
            Me.chkbExportMdlAlignData.Visible = False
            '
            'frmMdlOpsSwitches
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(504, 241)
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
            Me.MaximumSize = New System.Drawing.Size(1600, 280)
            Me.MinimumSize = New System.Drawing.Size(488, 280)
            Me.Name = "frmMdlOpsSwitches"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Model Extraction Options"
            CType(Me.nudNumberToExtract, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

    End Class
End Namespace
