Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmMdlOpsSwitches
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmMdlOpsSwitches.Designer.vb
        '
        ' Restored / facelifted Model Extraction Options dialog for the
        ' KoTOR Tool Restoration Project.
        '
        ' Original Tool:
        '   Fred Tetra's KotOR Tool
        '
        ' Restoration Project:
        '   KoTOR Tool Restoration Project
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original control names preserved for source compatibility.
        '   - Theme colours are applied at runtime from Themes\DarkSaber.ini.
        '   - Designer keeps fallback colours only for safe VS designer display.
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
        Friend WithEvents chkbExportTextures As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbKeepIntermediateFiles As Global.System.Windows.Forms.CheckBox
        Friend WithEvents cmbxOutputFormat As Global.System.Windows.Forms.ComboBox
        Friend WithEvents lblDetectedModelCount As Global.System.Windows.Forms.Label

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlOptions As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlPath As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblDetectedModelCount = New System.Windows.Forms.Label()
            Me.cmbxOutputFormat = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.nudNumberToExtract = New System.Windows.Forms.NumericUpDown()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.pnlOptions = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.chkbExtractAnimations = New System.Windows.Forms.CheckBox()
            Me.chkbCleanWorkingDir = New System.Windows.Forms.CheckBox()
            Me.chkbConvertSkin = New System.Windows.Forms.CheckBox()
            Me.chkbEachModelInOwnDir = New System.Windows.Forms.CheckBox()
            Me.chkbExportTextures = New System.Windows.Forms.CheckBox()
            Me.chkbKeepIntermediateFiles = New System.Windows.Forms.CheckBox()
            Me.chkbExportMdlAlignData = New System.Windows.Forms.CheckBox()
            Me.chkbMdlAlignDataOnly = New System.Windows.Forms.CheckBox()
            Me.pnlPath = New System.Windows.Forms.Panel()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.tbModelExtractionPath = New System.Windows.Forms.TextBox()
            Me.btnModuleExportPath = New System.Windows.Forms.Button()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.nudNumberToExtract, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlOptions.SuspendLayout()
            Me.pnlPath.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(563, 561)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.Label4)
            Me.pnlBody.Controls.Add(Me.Panel1)
            Me.pnlBody.Controls.Add(Me.pnlOptions)
            Me.pnlBody.Controls.Add(Me.pnlPath)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(14, 14, 14, 12)
            Me.pnlBody.Size = New System.Drawing.Size(561, 431)
            Me.pnlBody.TabIndex = 1
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(14, 334)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(533, 2)
            Me.Label4.TabIndex = 4
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblDetectedModelCount)
            Me.Panel1.Controls.Add(Me.cmbxOutputFormat)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.nudNumberToExtract)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Location = New System.Drawing.Point(287, 14)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(260, 309)
            Me.Panel1.TabIndex = 3
            '
            'lblDetectedModelCount
            '
            Me.lblDetectedModelCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetectedModelCount.ForeColor = System.Drawing.SystemColors.Control
            Me.lblDetectedModelCount.Location = New System.Drawing.Point(23, 90)
            Me.lblDetectedModelCount.Name = "lblDetectedModelCount"
            Me.lblDetectedModelCount.Size = New System.Drawing.Size(215, 20)
            Me.lblDetectedModelCount.TabIndex = 7
            Me.lblDetectedModelCount.Text = "Detected models: 1"
            Me.lblDetectedModelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'cmbxOutputFormat
            '
            Me.cmbxOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxOutputFormat.FormattingEnabled = True
            Me.cmbxOutputFormat.Items.AddRange(New Object() {"MDLOps ASCII MDL", "Binary MDL/MDX only", "OBJ Export (planned)"})
            Me.cmbxOutputFormat.Location = New System.Drawing.Point(23, 145)
            Me.cmbxOutputFormat.Name = "cmbxOutputFormat"
            Me.cmbxOutputFormat.Size = New System.Drawing.Size(215, 21)
            Me.cmbxOutputFormat.TabIndex = 6
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.SystemColors.Control
            Me.Label5.Location = New System.Drawing.Point(20, 122)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(215, 20)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "Output Format:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(0, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(258, 30)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Extra Options:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'nudNumberToExtract
            '
            Me.nudNumberToExtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudNumberToExtract.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudNumberToExtract.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudNumberToExtract.Location = New System.Drawing.Point(23, 65)
            Me.nudNumberToExtract.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.nudNumberToExtract.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudNumberToExtract.Name = "nudNumberToExtract"
            Me.nudNumberToExtract.Size = New System.Drawing.Size(215, 20)
            Me.nudNumberToExtract.TabIndex = 4
            Me.nudNumberToExtract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudNumberToExtract.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(20, 42)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(215, 20)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Number of Models To Extract:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlOptions
            '
            Me.pnlOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlOptions.Controls.Add(Me.Label1)
            Me.pnlOptions.Controls.Add(Me.chkbExtractAnimations)
            Me.pnlOptions.Controls.Add(Me.chkbCleanWorkingDir)
            Me.pnlOptions.Controls.Add(Me.chkbConvertSkin)
            Me.pnlOptions.Controls.Add(Me.chkbEachModelInOwnDir)
            Me.pnlOptions.Controls.Add(Me.chkbExportTextures)
            Me.pnlOptions.Controls.Add(Me.chkbKeepIntermediateFiles)
            Me.pnlOptions.Controls.Add(Me.chkbExportMdlAlignData)
            Me.pnlOptions.Controls.Add(Me.chkbMdlAlignDataOnly)
            Me.pnlOptions.Location = New System.Drawing.Point(14, 14)
            Me.pnlOptions.Name = "pnlOptions"
            Me.pnlOptions.Size = New System.Drawing.Size(260, 309)
            Me.pnlOptions.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(258, 30)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Model Extraction Options:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'chkbExtractAnimations
            '
            Me.chkbExtractAnimations.BackColor = System.Drawing.Color.Transparent
            Me.chkbExtractAnimations.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkbExtractAnimations.Checked = True
            Me.chkbExtractAnimations.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbExtractAnimations.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbExtractAnimations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbExtractAnimations.Location = New System.Drawing.Point(22, 42)
            Me.chkbExtractAnimations.Name = "chkbExtractAnimations"
            Me.chkbExtractAnimations.Size = New System.Drawing.Size(215, 20)
            Me.chkbExtractAnimations.TabIndex = 0
            Me.chkbExtractAnimations.Text = "Extract Animation:"
            Me.chkbExtractAnimations.UseVisualStyleBackColor = False
            '
            'chkbCleanWorkingDir
            '
            Me.chkbCleanWorkingDir.BackColor = System.Drawing.Color.Transparent
            Me.chkbCleanWorkingDir.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkbCleanWorkingDir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbCleanWorkingDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbCleanWorkingDir.Location = New System.Drawing.Point(22, 124)
            Me.chkbCleanWorkingDir.Name = "chkbCleanWorkingDir"
            Me.chkbCleanWorkingDir.Size = New System.Drawing.Size(215, 20)
            Me.chkbCleanWorkingDir.TabIndex = 1
            Me.chkbCleanWorkingDir.Text = "Clean Export Directory:"
            Me.chkbCleanWorkingDir.UseVisualStyleBackColor = False
            '
            'chkbConvertSkin
            '
            Me.chkbConvertSkin.BackColor = System.Drawing.Color.Transparent
            Me.chkbConvertSkin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkbConvertSkin.Checked = True
            Me.chkbConvertSkin.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbConvertSkin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbConvertSkin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbConvertSkin.Location = New System.Drawing.Point(22, 70)
            Me.chkbConvertSkin.Name = "chkbConvertSkin"
            Me.chkbConvertSkin.Size = New System.Drawing.Size(215, 20)
            Me.chkbConvertSkin.TabIndex = 2
            Me.chkbConvertSkin.Text = "Convert Skin to Trimesh:"
            Me.chkbConvertSkin.UseVisualStyleBackColor = False
            '
            'chkbEachModelInOwnDir
            '
            Me.chkbEachModelInOwnDir.BackColor = System.Drawing.Color.Transparent
            Me.chkbEachModelInOwnDir.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkbEachModelInOwnDir.Checked = True
            Me.chkbEachModelInOwnDir.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbEachModelInOwnDir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbEachModelInOwnDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbEachModelInOwnDir.Location = New System.Drawing.Point(22, 98)
            Me.chkbEachModelInOwnDir.Name = "chkbEachModelInOwnDir"
            Me.chkbEachModelInOwnDir.Size = New System.Drawing.Size(215, 20)
            Me.chkbEachModelInOwnDir.TabIndex = 3
            Me.chkbEachModelInOwnDir.Text = "Directory Per .MDL Model:"
            Me.chkbEachModelInOwnDir.UseVisualStyleBackColor = False
            '
            'chkbExportTextures
            '
            Me.chkbExportTextures.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkbExportTextures.Checked = True
            Me.chkbExportTextures.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbExportTextures.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbExportTextures.ForeColor = System.Drawing.SystemColors.Control
            Me.chkbExportTextures.Location = New System.Drawing.Point(22, 152)
            Me.chkbExportTextures.Name = "chkbExportTextures"
            Me.chkbExportTextures.Size = New System.Drawing.Size(215, 20)
            Me.chkbExportTextures.TabIndex = 4
            Me.chkbExportTextures.Text = "Export Related Textures:"
            Me.chkbExportTextures.UseVisualStyleBackColor = True
            '
            'chkbKeepIntermediateFiles
            '
            Me.chkbKeepIntermediateFiles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkbKeepIntermediateFiles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbKeepIntermediateFiles.ForeColor = System.Drawing.SystemColors.Control
            Me.chkbKeepIntermediateFiles.Location = New System.Drawing.Point(22, 180)
            Me.chkbKeepIntermediateFiles.Name = "chkbKeepIntermediateFiles"
            Me.chkbKeepIntermediateFiles.Size = New System.Drawing.Size(215, 20)
            Me.chkbKeepIntermediateFiles.TabIndex = 7
            Me.chkbKeepIntermediateFiles.Text = "Keep Intermediate Files:"
            Me.chkbKeepIntermediateFiles.UseVisualStyleBackColor = True
            '
            'chkbExportMdlAlignData
            '
            Me.chkbExportMdlAlignData.BackColor = System.Drawing.Color.Transparent
            Me.chkbExportMdlAlignData.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkbExportMdlAlignData.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbExportMdlAlignData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbExportMdlAlignData.Location = New System.Drawing.Point(22, 224)
            Me.chkbExportMdlAlignData.Name = "chkbExportMdlAlignData"
            Me.chkbExportMdlAlignData.Size = New System.Drawing.Size(215, 20)
            Me.chkbExportMdlAlignData.TabIndex = 8
            Me.chkbExportMdlAlignData.Text = "Extract Model Alignment Data:"
            Me.chkbExportMdlAlignData.UseVisualStyleBackColor = False
            Me.chkbExportMdlAlignData.Visible = False
            '
            'chkbMdlAlignDataOnly
            '
            Me.chkbMdlAlignDataOnly.BackColor = System.Drawing.Color.Transparent
            Me.chkbMdlAlignDataOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkbMdlAlignDataOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbMdlAlignDataOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbMdlAlignDataOnly.Location = New System.Drawing.Point(22, 248)
            Me.chkbMdlAlignDataOnly.Name = "chkbMdlAlignDataOnly"
            Me.chkbMdlAlignDataOnly.Size = New System.Drawing.Size(215, 20)
            Me.chkbMdlAlignDataOnly.TabIndex = 9
            Me.chkbMdlAlignDataOnly.Text = "Alignment Data Only:"
            Me.chkbMdlAlignDataOnly.UseVisualStyleBackColor = False
            Me.chkbMdlAlignDataOnly.Visible = False
            '
            'pnlPath
            '
            Me.pnlPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlPath.Controls.Add(Me.Label15)
            Me.pnlPath.Controls.Add(Me.tbModelExtractionPath)
            Me.pnlPath.Controls.Add(Me.btnModuleExportPath)
            Me.pnlPath.Location = New System.Drawing.Point(14, 346)
            Me.pnlPath.Name = "pnlPath"
            Me.pnlPath.Size = New System.Drawing.Size(533, 59)
            Me.pnlPath.TabIndex = 1
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.Transparent
            Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(11, 7)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(128, 16)
            Me.Label15.TabIndex = 0
            Me.Label15.Text = "Model Export path"
            '
            'tbModelExtractionPath
            '
            Me.tbModelExtractionPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbModelExtractionPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbModelExtractionPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbModelExtractionPath.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbModelExtractionPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbModelExtractionPath.Location = New System.Drawing.Point(14, 26)
            Me.tbModelExtractionPath.Name = "tbModelExtractionPath"
            Me.tbModelExtractionPath.Size = New System.Drawing.Size(469, 20)
            Me.tbModelExtractionPath.TabIndex = 5
            '
            'btnModuleExportPath
            '
            Me.btnModuleExportPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnModuleExportPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnModuleExportPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnModuleExportPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnModuleExportPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnModuleExportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnModuleExportPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModuleExportPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnModuleExportPath.Location = New System.Drawing.Point(491, 25)
            Me.btnModuleExportPath.Name = "btnModuleExportPath"
            Me.btnModuleExportPath.Size = New System.Drawing.Size(28, 22)
            Me.btnModuleExportPath.TabIndex = 6
            Me.btnModuleExportPath.Text = "..."
            Me.btnModuleExportPath.UseVisualStyleBackColor = False
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(14, 417)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(533, 2)
            Me.lblSeparatorBottom.TabIndex = 2
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 507)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(561, 52)
            Me.pnlFooter.TabIndex = 2
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(358, 13)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(84, 25)
            Me.btnOK.TabIndex = 7
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(459, 13)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(84, 25)
            Me.btnCancel.TabIndex = 8
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(561, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(561, 2)
            Me.lblSeparatorTop.TabIndex = 2
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 45)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(525, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Choose MDLOps export behaviour, batch extraction count, and destination path."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(527, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Model Extraction Options"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmMdlOpsSwitches
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(563, 561)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.MaximumSize = New System.Drawing.Size(1600, 600)
            Me.MinimumSize = New System.Drawing.Size(488, 360)
            Me.Name = "frmMdlOpsSwitches"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Model Extraction Options"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.nudNumberToExtract, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlOptions.ResumeLayout(False)
            Me.pnlPath.ResumeLayout(False)
            Me.pnlPath.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label

    End Class

End Namespace
