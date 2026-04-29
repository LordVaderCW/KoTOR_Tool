Namespace kotor_tool
    ' Token: 0x0200003F RID: 63
    Partial Public Class frmAppearanceWizard
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled AccessedThroughProperty
        ' wrappers.
        '
        ' Theme notes:
        '   - This Designer uses hard-coded fallback colours only.
        '   - Runtime theme loading should remain in frmAppearanceWizard.vb.
        '   - Original control names preserved for source compatibility.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents tbName As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbxGender As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxSizes As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxEnvMap As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxMovementRate As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxModelType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbHitRadius As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbPerspace As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbprefatkdist As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCreperspace As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxModelNaming As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbBaseModelName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents tbHeadNum As Global.System.Windows.Forms.TextBox
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents tbMa As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTa As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMb As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTb As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTd As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMd As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMc As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTc As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTf As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMf As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMe As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTe As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTg As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMg As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMh As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTh As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTi As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMi As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMj As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTj As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbEvilTexture As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents chkbAutoCreateSeqEntries As Global.System.Windows.Forms.CheckBox

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppearanceWizard))
            Me.tbName = New System.Windows.Forms.TextBox()
            Me.cmbxGender = New System.Windows.Forms.ComboBox()
            Me.cmbxSizes = New System.Windows.Forms.ComboBox()
            Me.cmbxEnvMap = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cmbxMovementRate = New System.Windows.Forms.ComboBox()
            Me.cmbxModelType = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.tbHitRadius = New System.Windows.Forms.TextBox()
            Me.tbPerspace = New System.Windows.Forms.TextBox()
            Me.tbprefatkdist = New System.Windows.Forms.TextBox()
            Me.tbCreperspace = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.tbBaseModelName = New System.Windows.Forms.TextBox()
            Me.cmbxModelNaming = New System.Windows.Forms.ComboBox()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.tbHeadNum = New System.Windows.Forms.TextBox()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.chkbAutoCreateSeqEntries = New System.Windows.Forms.CheckBox()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.tbMa = New System.Windows.Forms.TextBox()
            Me.tbTa = New System.Windows.Forms.TextBox()
            Me.tbMb = New System.Windows.Forms.TextBox()
            Me.tbTb = New System.Windows.Forms.TextBox()
            Me.tbTd = New System.Windows.Forms.TextBox()
            Me.tbMd = New System.Windows.Forms.TextBox()
            Me.tbMc = New System.Windows.Forms.TextBox()
            Me.tbTc = New System.Windows.Forms.TextBox()
            Me.tbTf = New System.Windows.Forms.TextBox()
            Me.tbMf = New System.Windows.Forms.TextBox()
            Me.tbMe = New System.Windows.Forms.TextBox()
            Me.tbTe = New System.Windows.Forms.TextBox()
            Me.tbTg = New System.Windows.Forms.TextBox()
            Me.tbMg = New System.Windows.Forms.TextBox()
            Me.tbMh = New System.Windows.Forms.TextBox()
            Me.tbTh = New System.Windows.Forms.TextBox()
            Me.tbTi = New System.Windows.Forms.TextBox()
            Me.tbMi = New System.Windows.Forms.TextBox()
            Me.tbMj = New System.Windows.Forms.TextBox()
            Me.tbTj = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.tbEvilTexture = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'tbName
            '
            Me.tbName.Location = New System.Drawing.Point(160, 24)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New System.Drawing.Size(256, 20)
            Me.tbName.TabIndex = 0
            '
            'cmbxGender
            '
            Me.cmbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxGender.Items.AddRange(New Object() {"Male", "Female"})
            Me.cmbxGender.Location = New System.Drawing.Point(160, 56)
            Me.cmbxGender.Name = "cmbxGender"
            Me.cmbxGender.Size = New System.Drawing.Size(256, 21)
            Me.cmbxGender.TabIndex = 1
            '
            'cmbxSizes
            '
            Me.cmbxSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSizes.Items.AddRange(New Object() {"1", "3"})
            Me.cmbxSizes.Location = New System.Drawing.Point(160, 168)
            Me.cmbxSizes.Name = "cmbxSizes"
            Me.cmbxSizes.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmbxSizes.Size = New System.Drawing.Size(256, 21)
            Me.cmbxSizes.TabIndex = 5
            '
            'cmbxEnvMap
            '
            Me.cmbxEnvMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxEnvMap.Items.AddRange(New Object() {"DEFAULT", "CM_BareMetal", "CM_MANUN"})
            Me.cmbxEnvMap.Location = New System.Drawing.Point(160, 200)
            Me.cmbxEnvMap.Name = "cmbxEnvMap"
            Me.cmbxEnvMap.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmbxEnvMap.Size = New System.Drawing.Size(256, 21)
            Me.cmbxEnvMap.TabIndex = 6
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(16, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Name"
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(16, 56)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 16)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Gender"
            '
            'Label3
            '
            Me.Label3.Location = New System.Drawing.Point(16, 168)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(136, 16)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Number of Sizes to create"
            '
            'Label4
            '
            Me.Label4.Location = New System.Drawing.Point(16, 200)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(100, 16)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Environment Map"
            '
            'Label5
            '
            Me.Label5.Location = New System.Drawing.Point(16, 232)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(100, 16)
            Me.Label5.TabIndex = 3
            Me.Label5.Text = "Movement Rate"
            '
            'cmbxMovementRate
            '
            Me.cmbxMovementRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMovementRate.Items.AddRange(New Object() {"No Movement", "Wee Folk", "Very Slow", "Slow", "Norm/Default", "Fast", "Very Fast", "Player", "Huge", "Giant", "Fastest"})
            Me.cmbxMovementRate.Location = New System.Drawing.Point(160, 232)
            Me.cmbxMovementRate.Name = "cmbxMovementRate"
            Me.cmbxMovementRate.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmbxMovementRate.Size = New System.Drawing.Size(256, 21)
            Me.cmbxMovementRate.TabIndex = 7
            '
            'cmbxModelType
            '
            Me.cmbxModelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxModelType.Items.AddRange(New Object() {"B", "F", "L", "S"})
            Me.cmbxModelType.Location = New System.Drawing.Point(160, 264)
            Me.cmbxModelType.Name = "cmbxModelType"
            Me.cmbxModelType.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmbxModelType.Size = New System.Drawing.Size(256, 21)
            Me.cmbxModelType.TabIndex = 8
            '
            'Label6
            '
            Me.Label6.Location = New System.Drawing.Point(16, 296)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(100, 16)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "Hit Radius"
            '
            'Label7
            '
            Me.Label7.Location = New System.Drawing.Point(16, 328)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(100, 16)
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "Personal Space"
            '
            'Label8
            '
            Me.Label8.Location = New System.Drawing.Point(16, 360)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(128, 16)
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "CRep Personal Space"
            '
            'Label9
            '
            Me.Label9.Location = New System.Drawing.Point(16, 392)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(136, 16)
            Me.Label9.TabIndex = 3
            Me.Label9.Text = "Preferred Attack Distance"
            '
            'Label10
            '
            Me.Label10.Location = New System.Drawing.Point(16, 264)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(100, 16)
            Me.Label10.TabIndex = 3
            Me.Label10.Text = "Model Type"
            '
            'tbHitRadius
            '
            Me.tbHitRadius.Location = New System.Drawing.Point(160, 296)
            Me.tbHitRadius.Name = "tbHitRadius"
            Me.tbHitRadius.Size = New System.Drawing.Size(72, 20)
            Me.tbHitRadius.TabIndex = 9
            Me.tbHitRadius.Text = "****"
            Me.tbHitRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbPerspace
            '
            Me.tbPerspace.Location = New System.Drawing.Point(160, 328)
            Me.tbPerspace.Name = "tbPerspace"
            Me.tbPerspace.Size = New System.Drawing.Size(72, 20)
            Me.tbPerspace.TabIndex = 10
            Me.tbPerspace.Text = "****"
            Me.tbPerspace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbprefatkdist
            '
            Me.tbprefatkdist.Location = New System.Drawing.Point(160, 392)
            Me.tbprefatkdist.Name = "tbprefatkdist"
            Me.tbprefatkdist.Size = New System.Drawing.Size(72, 20)
            Me.tbprefatkdist.TabIndex = 12
            Me.tbprefatkdist.Text = "****"
            Me.tbprefatkdist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbCreperspace
            '
            Me.tbCreperspace.Location = New System.Drawing.Point(160, 360)
            Me.tbCreperspace.Name = "tbCreperspace"
            Me.tbCreperspace.Size = New System.Drawing.Size(72, 20)
            Me.tbCreperspace.TabIndex = 11
            Me.tbCreperspace.Text = "****"
            Me.tbCreperspace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label11
            '
            Me.Label11.Location = New System.Drawing.Point(16, 120)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(100, 16)
            Me.Label11.TabIndex = 3
            Me.Label11.Text = "Base Model Name"
            '
            'tbBaseModelName
            '
            Me.tbBaseModelName.Location = New System.Drawing.Point(160, 120)
            Me.tbBaseModelName.Name = "tbBaseModelName"
            Me.tbBaseModelName.Size = New System.Drawing.Size(56, 20)
            Me.tbBaseModelName.TabIndex = 3
            '
            'cmbxModelNaming
            '
            Me.cmbxModelNaming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxModelNaming.Items.AddRange(New Object() {"Use name for all model entries", "Create sequential model entries"})
            Me.cmbxModelNaming.Location = New System.Drawing.Point(232, 120)
            Me.cmbxModelNaming.Name = "cmbxModelNaming"
            Me.cmbxModelNaming.Size = New System.Drawing.Size(184, 21)
            Me.cmbxModelNaming.TabIndex = 4
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(281, 488)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(75, 23)
            Me.btnOK.TabIndex = 0
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
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(369, 488)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'Label12
            '
            Me.Label12.Location = New System.Drawing.Point(16, 88)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(136, 16)
            Me.Label12.TabIndex = 3
            Me.Label12.Text = "Head Number"
            '
            'tbHeadNum
            '
            Me.tbHeadNum.Location = New System.Drawing.Point(160, 88)
            Me.tbHeadNum.Name = "tbHeadNum"
            Me.tbHeadNum.Size = New System.Drawing.Size(256, 20)
            Me.tbHeadNum.TabIndex = 2
            Me.tbHeadNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabControl1.Location = New System.Drawing.Point(16, 16)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New System.Drawing.Point(10, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(432, 448)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.chkbAutoCreateSeqEntries)
            Me.TabPage1.Controls.Add(Me.tbName)
            Me.TabPage1.Controls.Add(Me.tbHeadNum)
            Me.TabPage1.Controls.Add(Me.Label12)
            Me.TabPage1.Controls.Add(Me.cmbxModelNaming)
            Me.TabPage1.Controls.Add(Me.tbBaseModelName)
            Me.TabPage1.Controls.Add(Me.Label11)
            Me.TabPage1.Controls.Add(Me.tbCreperspace)
            Me.TabPage1.Controls.Add(Me.tbprefatkdist)
            Me.TabPage1.Controls.Add(Me.tbPerspace)
            Me.TabPage1.Controls.Add(Me.tbHitRadius)
            Me.TabPage1.Controls.Add(Me.Label10)
            Me.TabPage1.Controls.Add(Me.Label9)
            Me.TabPage1.Controls.Add(Me.Label8)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.Label6)
            Me.TabPage1.Controls.Add(Me.cmbxModelType)
            Me.TabPage1.Controls.Add(Me.cmbxMovementRate)
            Me.TabPage1.Controls.Add(Me.Label5)
            Me.TabPage1.Controls.Add(Me.Label4)
            Me.TabPage1.Controls.Add(Me.Label3)
            Me.TabPage1.Controls.Add(Me.Label2)
            Me.TabPage1.Controls.Add(Me.Label1)
            Me.TabPage1.Controls.Add(Me.cmbxEnvMap)
            Me.TabPage1.Controls.Add(Me.cmbxSizes)
            Me.TabPage1.Controls.Add(Me.cmbxGender)
            Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New System.Drawing.Size(424, 422)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "General"
            '
            'chkbAutoCreateSeqEntries
            '
            Me.chkbAutoCreateSeqEntries.BackColor = System.Drawing.Color.Transparent
            Me.chkbAutoCreateSeqEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.chkbAutoCreateSeqEntries.Location = New System.Drawing.Point(232, 144)
            Me.chkbAutoCreateSeqEntries.Name = "chkbAutoCreateSeqEntries"
            Me.chkbAutoCreateSeqEntries.Size = New System.Drawing.Size(184, 16)
            Me.chkbAutoCreateSeqEntries.TabIndex = 13
            Me.chkbAutoCreateSeqEntries.Text = "Auto-create sequential entries"
            Me.chkbAutoCreateSeqEntries.UseVisualStyleBackColor = False
            Me.chkbAutoCreateSeqEntries.Visible = False
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.Button1)
            Me.TabPage2.Controls.Add(Me.Label15)
            Me.TabPage2.Controls.Add(Me.Label13)
            Me.TabPage2.Controls.Add(Me.tbMa)
            Me.TabPage2.Controls.Add(Me.tbTa)
            Me.TabPage2.Controls.Add(Me.tbMb)
            Me.TabPage2.Controls.Add(Me.tbTb)
            Me.TabPage2.Controls.Add(Me.tbTd)
            Me.TabPage2.Controls.Add(Me.tbMd)
            Me.TabPage2.Controls.Add(Me.tbMc)
            Me.TabPage2.Controls.Add(Me.tbTc)
            Me.TabPage2.Controls.Add(Me.tbTf)
            Me.TabPage2.Controls.Add(Me.tbMf)
            Me.TabPage2.Controls.Add(Me.tbMe)
            Me.TabPage2.Controls.Add(Me.tbTe)
            Me.TabPage2.Controls.Add(Me.tbTg)
            Me.TabPage2.Controls.Add(Me.tbMg)
            Me.TabPage2.Controls.Add(Me.tbMh)
            Me.TabPage2.Controls.Add(Me.tbTh)
            Me.TabPage2.Controls.Add(Me.tbTi)
            Me.TabPage2.Controls.Add(Me.tbMi)
            Me.TabPage2.Controls.Add(Me.tbMj)
            Me.TabPage2.Controls.Add(Me.tbTj)
            Me.TabPage2.Controls.Add(Me.Label14)
            Me.TabPage2.Controls.Add(Me.Label16)
            Me.TabPage2.Controls.Add(Me.Label17)
            Me.TabPage2.Controls.Add(Me.Label18)
            Me.TabPage2.Controls.Add(Me.Label19)
            Me.TabPage2.Controls.Add(Me.Label20)
            Me.TabPage2.Controls.Add(Me.Label21)
            Me.TabPage2.Controls.Add(Me.Label22)
            Me.TabPage2.Controls.Add(Me.Label23)
            Me.TabPage2.Controls.Add(Me.Label24)
            Me.TabPage2.Controls.Add(Me.tbEvilTexture)
            Me.TabPage2.Controls.Add(Me.Label25)
            Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New System.Drawing.Size(424, 422)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Model/Texture Names"
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button1.Location = New System.Drawing.Point(112, 384)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(224, 23)
            Me.Button1.TabIndex = 21
            Me.Button1.Text = "Show samples from Base Model Name"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'Label15
            '
            Me.Label15.Location = New System.Drawing.Point(80, 32)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(24, 16)
            Me.Label15.TabIndex = 2
            Me.Label15.Text = "A"
            '
            'Label13
            '
            Me.Label13.Location = New System.Drawing.Point(144, 8)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(40, 16)
            Me.Label13.TabIndex = 1
            Me.Label13.Text = "Model"
            '
            'tbMa
            '
            Me.tbMa.Location = New System.Drawing.Point(112, 32)
            Me.tbMa.Name = "tbMa"
            Me.tbMa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMa.Size = New System.Drawing.Size(100, 20)
            Me.tbMa.TabIndex = 0
            '
            'tbTa
            '
            Me.tbTa.Location = New System.Drawing.Point(232, 32)
            Me.tbTa.Name = "tbTa"
            Me.tbTa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTa.Size = New System.Drawing.Size(100, 20)
            Me.tbTa.TabIndex = 1
            '
            'tbMb
            '
            Me.tbMb.Location = New System.Drawing.Point(112, 64)
            Me.tbMb.Name = "tbMb"
            Me.tbMb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMb.Size = New System.Drawing.Size(100, 20)
            Me.tbMb.TabIndex = 2
            '
            'tbTb
            '
            Me.tbTb.Location = New System.Drawing.Point(232, 64)
            Me.tbTb.Name = "tbTb"
            Me.tbTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTb.Size = New System.Drawing.Size(100, 20)
            Me.tbTb.TabIndex = 3
            '
            'tbTd
            '
            Me.tbTd.Location = New System.Drawing.Point(232, 128)
            Me.tbTd.Name = "tbTd"
            Me.tbTd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTd.Size = New System.Drawing.Size(100, 20)
            Me.tbTd.TabIndex = 7
            '
            'tbMd
            '
            Me.tbMd.Location = New System.Drawing.Point(112, 128)
            Me.tbMd.Name = "tbMd"
            Me.tbMd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMd.Size = New System.Drawing.Size(100, 20)
            Me.tbMd.TabIndex = 6
            '
            'tbMc
            '
            Me.tbMc.Location = New System.Drawing.Point(112, 96)
            Me.tbMc.Name = "tbMc"
            Me.tbMc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMc.Size = New System.Drawing.Size(100, 20)
            Me.tbMc.TabIndex = 4
            '
            'tbTc
            '
            Me.tbTc.Location = New System.Drawing.Point(232, 96)
            Me.tbTc.Name = "tbTc"
            Me.tbTc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTc.Size = New System.Drawing.Size(100, 20)
            Me.tbTc.TabIndex = 5
            '
            'tbTf
            '
            Me.tbTf.Location = New System.Drawing.Point(232, 192)
            Me.tbTf.Name = "tbTf"
            Me.tbTf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTf.Size = New System.Drawing.Size(100, 20)
            Me.tbTf.TabIndex = 11
            '
            'tbMf
            '
            Me.tbMf.Location = New System.Drawing.Point(112, 192)
            Me.tbMf.Name = "tbMf"
            Me.tbMf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMf.Size = New System.Drawing.Size(100, 20)
            Me.tbMf.TabIndex = 10
            '
            'tbMe
            '
            Me.tbMe.Location = New System.Drawing.Point(112, 160)
            Me.tbMe.Name = "tbMe"
            Me.tbMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMe.Size = New System.Drawing.Size(100, 20)
            Me.tbMe.TabIndex = 8
            '
            'tbTe
            '
            Me.tbTe.Location = New System.Drawing.Point(232, 160)
            Me.tbTe.Name = "tbTe"
            Me.tbTe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTe.Size = New System.Drawing.Size(100, 20)
            Me.tbTe.TabIndex = 9
            '
            'tbTg
            '
            Me.tbTg.Location = New System.Drawing.Point(232, 224)
            Me.tbTg.Name = "tbTg"
            Me.tbTg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTg.Size = New System.Drawing.Size(100, 20)
            Me.tbTg.TabIndex = 13
            '
            'tbMg
            '
            Me.tbMg.Location = New System.Drawing.Point(112, 224)
            Me.tbMg.Name = "tbMg"
            Me.tbMg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMg.Size = New System.Drawing.Size(100, 20)
            Me.tbMg.TabIndex = 12
            '
            'tbMh
            '
            Me.tbMh.Location = New System.Drawing.Point(112, 256)
            Me.tbMh.Name = "tbMh"
            Me.tbMh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMh.Size = New System.Drawing.Size(100, 20)
            Me.tbMh.TabIndex = 14
            '
            'tbTh
            '
            Me.tbTh.Location = New System.Drawing.Point(232, 256)
            Me.tbTh.Name = "tbTh"
            Me.tbTh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTh.Size = New System.Drawing.Size(100, 20)
            Me.tbTh.TabIndex = 15
            '
            'tbTi
            '
            Me.tbTi.Location = New System.Drawing.Point(232, 288)
            Me.tbTi.Name = "tbTi"
            Me.tbTi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTi.Size = New System.Drawing.Size(100, 20)
            Me.tbTi.TabIndex = 17
            '
            'tbMi
            '
            Me.tbMi.Location = New System.Drawing.Point(112, 288)
            Me.tbMi.Name = "tbMi"
            Me.tbMi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMi.Size = New System.Drawing.Size(100, 20)
            Me.tbMi.TabIndex = 16
            '
            'tbMj
            '
            Me.tbMj.Location = New System.Drawing.Point(112, 320)
            Me.tbMj.Name = "tbMj"
            Me.tbMj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbMj.Size = New System.Drawing.Size(100, 20)
            Me.tbMj.TabIndex = 18
            '
            'tbTj
            '
            Me.tbTj.Location = New System.Drawing.Point(232, 320)
            Me.tbTj.Name = "tbTj"
            Me.tbTj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbTj.Size = New System.Drawing.Size(100, 20)
            Me.tbTj.TabIndex = 19
            '
            'Label14
            '
            Me.Label14.Location = New System.Drawing.Point(256, 8)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(48, 16)
            Me.Label14.TabIndex = 1
            Me.Label14.Text = "Texture"
            '
            'Label16
            '
            Me.Label16.Location = New System.Drawing.Point(80, 64)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(24, 16)
            Me.Label16.TabIndex = 2
            Me.Label16.Text = "B"
            '
            'Label17
            '
            Me.Label17.Location = New System.Drawing.Point(80, 96)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(24, 16)
            Me.Label17.TabIndex = 2
            Me.Label17.Text = "C"
            '
            'Label18
            '
            Me.Label18.Location = New System.Drawing.Point(80, 128)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(24, 16)
            Me.Label18.TabIndex = 2
            Me.Label18.Text = "D"
            '
            'Label19
            '
            Me.Label19.Location = New System.Drawing.Point(80, 256)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(24, 16)
            Me.Label19.TabIndex = 2
            Me.Label19.Text = "H"
            '
            'Label20
            '
            Me.Label20.Location = New System.Drawing.Point(80, 192)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(24, 16)
            Me.Label20.TabIndex = 2
            Me.Label20.Text = "F"
            '
            'Label21
            '
            Me.Label21.Location = New System.Drawing.Point(80, 224)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(24, 16)
            Me.Label21.TabIndex = 2
            Me.Label21.Text = "G"
            '
            'Label22
            '
            Me.Label22.Location = New System.Drawing.Point(80, 160)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(24, 16)
            Me.Label22.TabIndex = 2
            Me.Label22.Text = "E"
            '
            'Label23
            '
            Me.Label23.Location = New System.Drawing.Point(80, 320)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(24, 16)
            Me.Label23.TabIndex = 2
            Me.Label23.Text = "J"
            '
            'Label24
            '
            Me.Label24.Location = New System.Drawing.Point(80, 288)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(24, 16)
            Me.Label24.TabIndex = 2
            Me.Label24.Text = "I"
            '
            'tbEvilTexture
            '
            Me.tbEvilTexture.Location = New System.Drawing.Point(112, 352)
            Me.tbEvilTexture.Name = "tbEvilTexture"
            Me.tbEvilTexture.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.tbEvilTexture.Size = New System.Drawing.Size(100, 20)
            Me.tbEvilTexture.TabIndex = 20
            '
            'Label25
            '
            Me.Label25.Location = New System.Drawing.Point(32, 352)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(64, 16)
            Me.Label25.TabIndex = 1
            Me.Label25.Text = "Evil Texture"
            '
            'frmAppearanceWizard
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(465, 517)
            Me.ControlBox = False
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAppearanceWizard"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Appearance Wizard"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Private Sub ApplyDesignerFallbackColours()
            Me.ApplyLabelFallback(Me.Label1)
            Me.ApplyLabelFallback(Me.Label2)
            Me.ApplyLabelFallback(Me.Label3)
            Me.ApplyLabelFallback(Me.Label4)
            Me.ApplyLabelFallback(Me.Label5)
            Me.ApplyLabelFallback(Me.Label6)
            Me.ApplyLabelFallback(Me.Label7)
            Me.ApplyLabelFallback(Me.Label8)
            Me.ApplyLabelFallback(Me.Label9)
            Me.ApplyLabelFallback(Me.Label10)
            Me.ApplyLabelFallback(Me.Label11)
            Me.ApplyLabelFallback(Me.Label12)
            Me.ApplyLabelFallback(Me.Label13)
            Me.ApplyLabelFallback(Me.Label14)
            Me.ApplyLabelFallback(Me.Label15)
            Me.ApplyLabelFallback(Me.Label16)
            Me.ApplyLabelFallback(Me.Label17)
            Me.ApplyLabelFallback(Me.Label18)
            Me.ApplyLabelFallback(Me.Label19)
            Me.ApplyLabelFallback(Me.Label20)
            Me.ApplyLabelFallback(Me.Label21)
            Me.ApplyLabelFallback(Me.Label22)
            Me.ApplyLabelFallback(Me.Label23)
            Me.ApplyLabelFallback(Me.Label24)
            Me.ApplyLabelFallback(Me.Label25)

            Me.ApplyTextBoxFallback(Me.tbName)
            Me.ApplyTextBoxFallback(Me.tbHitRadius)
            Me.ApplyTextBoxFallback(Me.tbPerspace)
            Me.ApplyTextBoxFallback(Me.tbprefatkdist)
            Me.ApplyTextBoxFallback(Me.tbCreperspace)
            Me.ApplyTextBoxFallback(Me.tbBaseModelName)
            Me.ApplyTextBoxFallback(Me.tbHeadNum)
            Me.ApplyTextBoxFallback(Me.tbMa)
            Me.ApplyTextBoxFallback(Me.tbTa)
            Me.ApplyTextBoxFallback(Me.tbMb)
            Me.ApplyTextBoxFallback(Me.tbTb)
            Me.ApplyTextBoxFallback(Me.tbTd)
            Me.ApplyTextBoxFallback(Me.tbMd)
            Me.ApplyTextBoxFallback(Me.tbMc)
            Me.ApplyTextBoxFallback(Me.tbTc)
            Me.ApplyTextBoxFallback(Me.tbTf)
            Me.ApplyTextBoxFallback(Me.tbMf)
            Me.ApplyTextBoxFallback(Me.tbMe)
            Me.ApplyTextBoxFallback(Me.tbTe)
            Me.ApplyTextBoxFallback(Me.tbTg)
            Me.ApplyTextBoxFallback(Me.tbMg)
            Me.ApplyTextBoxFallback(Me.tbMh)
            Me.ApplyTextBoxFallback(Me.tbTh)
            Me.ApplyTextBoxFallback(Me.tbTi)
            Me.ApplyTextBoxFallback(Me.tbMi)
            Me.ApplyTextBoxFallback(Me.tbMj)
            Me.ApplyTextBoxFallback(Me.tbTj)
            Me.ApplyTextBoxFallback(Me.tbEvilTexture)

            Me.ApplyComboBoxFallback(Me.cmbxGender)
            Me.ApplyComboBoxFallback(Me.cmbxSizes)
            Me.ApplyComboBoxFallback(Me.cmbxEnvMap)
            Me.ApplyComboBoxFallback(Me.cmbxMovementRate)
            Me.ApplyComboBoxFallback(Me.cmbxModelType)
            Me.ApplyComboBoxFallback(Me.cmbxModelNaming)
        End Sub

        Private Sub ApplyLabelFallback(ByVal labelControl As Global.System.Windows.Forms.Label)
            labelControl.BackColor = Global.System.Drawing.Color.Transparent
            labelControl.ForeColor = Global.System.Drawing.Color.FromArgb(176, 186, 198)
        End Sub

        Private Sub ApplyTextBoxFallback(ByVal textBoxControl As Global.System.Windows.Forms.TextBox)
            textBoxControl.BackColor = Global.System.Drawing.Color.FromArgb(10, 14, 20)
            textBoxControl.ForeColor = Global.System.Drawing.Color.FromArgb(238, 238, 230)
            textBoxControl.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
        End Sub

        Private Sub ApplyComboBoxFallback(ByVal comboBoxControl As Global.System.Windows.Forms.ComboBox)
            comboBoxControl.BackColor = Global.System.Drawing.Color.FromArgb(10, 14, 20)
            comboBoxControl.ForeColor = Global.System.Drawing.Color.FromArgb(238, 238, 230)
        End Sub
    End Class
End Namespace