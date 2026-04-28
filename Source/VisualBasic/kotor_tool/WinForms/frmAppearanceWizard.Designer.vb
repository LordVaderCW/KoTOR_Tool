Namespace kotor_tool
	' Token: 0x0200003F RID: 63
	Public Partial Class frmAppearanceWizard
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


		' Token: 0x060001D6 RID: 470 RVA: 0x00228F28 File Offset: 0x00227F28
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600025B RID: 603 RVA: 0x00229C50 File Offset: 0x00228C50
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmAppearanceWizard))
            Me.tbName = New Global.System.Windows.Forms.TextBox()
            Me.cmbxGender = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxSizes = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxEnvMap = New Global.System.Windows.Forms.ComboBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.cmbxMovementRate = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxModelType = New Global.System.Windows.Forms.ComboBox()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.tbHitRadius = New Global.System.Windows.Forms.TextBox()
            Me.tbPerspace = New Global.System.Windows.Forms.TextBox()
            Me.tbprefatkdist = New Global.System.Windows.Forms.TextBox()
            Me.tbCreperspace = New Global.System.Windows.Forms.TextBox()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.tbBaseModelName = New Global.System.Windows.Forms.TextBox()
            Me.cmbxModelNaming = New Global.System.Windows.Forms.ComboBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.tbHeadNum = New Global.System.Windows.Forms.TextBox()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
            Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.Label13 = New Global.System.Windows.Forms.Label()
            Me.tbMa = New Global.System.Windows.Forms.TextBox()
            Me.tbTa = New Global.System.Windows.Forms.TextBox()
            Me.tbMb = New Global.System.Windows.Forms.TextBox()
            Me.tbTb = New Global.System.Windows.Forms.TextBox()
            Me.tbTd = New Global.System.Windows.Forms.TextBox()
            Me.tbMd = New Global.System.Windows.Forms.TextBox()
            Me.tbMc = New Global.System.Windows.Forms.TextBox()
            Me.tbTc = New Global.System.Windows.Forms.TextBox()
            Me.tbTf = New Global.System.Windows.Forms.TextBox()
            Me.tbMf = New Global.System.Windows.Forms.TextBox()
            Me.tbMe = New Global.System.Windows.Forms.TextBox()
            Me.tbTe = New Global.System.Windows.Forms.TextBox()
            Me.tbTg = New Global.System.Windows.Forms.TextBox()
            Me.tbMg = New Global.System.Windows.Forms.TextBox()
            Me.tbMh = New Global.System.Windows.Forms.TextBox()
            Me.tbTh = New Global.System.Windows.Forms.TextBox()
            Me.tbTi = New Global.System.Windows.Forms.TextBox()
            Me.tbMi = New Global.System.Windows.Forms.TextBox()
            Me.tbMj = New Global.System.Windows.Forms.TextBox()
            Me.tbTj = New Global.System.Windows.Forms.TextBox()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.Label16 = New Global.System.Windows.Forms.Label()
            Me.Label17 = New Global.System.Windows.Forms.Label()
            Me.Label18 = New Global.System.Windows.Forms.Label()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.Label20 = New Global.System.Windows.Forms.Label()
            Me.Label21 = New Global.System.Windows.Forms.Label()
            Me.Label22 = New Global.System.Windows.Forms.Label()
            Me.Label23 = New Global.System.Windows.Forms.Label()
            Me.Label24 = New Global.System.Windows.Forms.Label()
            Me.tbEvilTexture = New Global.System.Windows.Forms.TextBox()
            Me.Label25 = New Global.System.Windows.Forms.Label()
            Me.chkbAutoCreateSeqEntries = New Global.System.Windows.Forms.CheckBox()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.SuspendLayout()
            Me.tbName.Location = New Global.System.Drawing.Point(160, 24)
            Me.tbName.Name = "tbName"
            Me.tbName.TabIndex = 0
            Me.tbName.Text = ""
            Me.cmbxGender.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxGender.Items.AddRange(New Object() {"Male", "Female"})
            Me.cmbxGender.Location = New Global.System.Drawing.Point(160, 56)
            Me.cmbxGender.Name = "cmbxGender"
            Me.cmbxGender.Size = New Global.System.Drawing.Size(56, 21)
            Me.cmbxGender.TabIndex = 1
            Me.cmbxSizes.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSizes.Items.AddRange(New Object() {"1", "3"})
            Me.cmbxSizes.Location = New Global.System.Drawing.Point(160, 168)
            Me.cmbxSizes.Name = "cmbxSizes"
            Me.cmbxSizes.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.cmbxSizes.Size = New Global.System.Drawing.Size(56, 21)
            Me.cmbxSizes.TabIndex = 5
            Me.cmbxEnvMap.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxEnvMap.Items.AddRange(New Object() {"DEFAULT", "CM_BareMetal", "CM_MANUN"})
            Me.cmbxEnvMap.Location = New Global.System.Drawing.Point(160, 200)
            Me.cmbxEnvMap.Name = "cmbxEnvMap"
            Me.cmbxEnvMap.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.cmbxEnvMap.Size = New Global.System.Drawing.Size(128, 21)
            Me.cmbxEnvMap.TabIndex = 6
            Me.Label1.Location = New Global.System.Drawing.Point(16, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Name"
            Me.Label2.Location = New Global.System.Drawing.Point(16, 56)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Gender"
            Me.Label3.Location = New Global.System.Drawing.Point(16, 168)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Number of Sizes to create"
            Me.Label4.Location = New Global.System.Drawing.Point(16, 200)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Environment Map"
            Me.Label5.Location = New Global.System.Drawing.Point(16, 232)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label5.TabIndex = 3
            Me.Label5.Text = "Movement Rate"
            Me.cmbxMovementRate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMovementRate.Items.AddRange(New Object() {"No Movement", "Wee Folk", "Very Slow", "Slow", "Norm/Default", "Fast", "Very Fast", "Player", "Huge", "Giant", "Fastest"})
            Me.cmbxMovementRate.Location = New Global.System.Drawing.Point(160, 232)
            Me.cmbxMovementRate.Name = "cmbxMovementRate"
            Me.cmbxMovementRate.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.cmbxMovementRate.Size = New Global.System.Drawing.Size(128, 21)
            Me.cmbxMovementRate.TabIndex = 7
            Me.cmbxModelType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxModelType.Items.AddRange(New Object() {"B", "F", "L", "S"})
            Me.cmbxModelType.Location = New Global.System.Drawing.Point(160, 264)
            Me.cmbxModelType.Name = "cmbxModelType"
            Me.cmbxModelType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.cmbxModelType.Size = New Global.System.Drawing.Size(128, 21)
            Me.cmbxModelType.TabIndex = 8
            Me.Label6.Location = New Global.System.Drawing.Point(16, 296)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "Hit Radius"
            Me.Label7.Location = New Global.System.Drawing.Point(16, 328)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "Personal Space"
            Me.Label8.Location = New Global.System.Drawing.Point(16, 360)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "CRep Personal Space"
            Me.Label9.Location = New Global.System.Drawing.Point(16, 392)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label9.TabIndex = 3
            Me.Label9.Text = "Preferred Attack Distance"
            Me.Label10.Location = New Global.System.Drawing.Point(16, 264)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label10.TabIndex = 3
            Me.Label10.Text = "Model Type"
            Me.tbHitRadius.Location = New Global.System.Drawing.Point(160, 296)
            Me.tbHitRadius.Name = "tbHitRadius"
            Me.tbHitRadius.Size = New Global.System.Drawing.Size(32, 20)
            Me.tbHitRadius.TabIndex = 9
            Me.tbHitRadius.Text = "****"
            Me.tbHitRadius.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbPerspace.Location = New Global.System.Drawing.Point(160, 328)
            Me.tbPerspace.Name = "tbPerspace"
            Me.tbPerspace.Size = New Global.System.Drawing.Size(32, 20)
            Me.tbPerspace.TabIndex = 10
            Me.tbPerspace.Text = "****"
            Me.tbPerspace.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbprefatkdist.Location = New Global.System.Drawing.Point(160, 392)
            Me.tbprefatkdist.Name = "tbprefatkdist"
            Me.tbprefatkdist.Size = New Global.System.Drawing.Size(32, 20)
            Me.tbprefatkdist.TabIndex = 12
            Me.tbprefatkdist.Text = "****"
            Me.tbprefatkdist.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCreperspace.Location = New Global.System.Drawing.Point(160, 360)
            Me.tbCreperspace.Name = "tbCreperspace"
            Me.tbCreperspace.Size = New Global.System.Drawing.Size(32, 20)
            Me.tbCreperspace.TabIndex = 11
            Me.tbCreperspace.Text = "****"
            Me.tbCreperspace.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label11.Location = New Global.System.Drawing.Point(16, 120)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label11.TabIndex = 3
            Me.Label11.Text = "Base Model Name"
            Me.tbBaseModelName.Location = New Global.System.Drawing.Point(160, 120)
            Me.tbBaseModelName.Name = "tbBaseModelName"
            Me.tbBaseModelName.Size = New Global.System.Drawing.Size(56, 20)
            Me.tbBaseModelName.TabIndex = 3
            Me.tbBaseModelName.Text = ""
            Me.cmbxModelNaming.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxModelNaming.Items.AddRange(New Object() {"Use name for all model entries", "Create sequential model entries"})
            Me.cmbxModelNaming.Location = New Global.System.Drawing.Point(232, 120)
            Me.cmbxModelNaming.Name = "cmbxModelNaming"
            Me.cmbxModelNaming.Size = New Global.System.Drawing.Size(184, 21)
            Me.cmbxModelNaming.TabIndex = 4
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.Location = New Global.System.Drawing.Point(280, 488)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(368, 488)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.Label12.Location = New Global.System.Drawing.Point(16, 88)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label12.TabIndex = 3
            Me.Label12.Text = "Head Number"
            Me.tbHeadNum.Location = New Global.System.Drawing.Point(160, 88)
            Me.tbHeadNum.Name = "tbHeadNum"
            Me.tbHeadNum.Size = New Global.System.Drawing.Size(40, 20)
            Me.tbHeadNum.TabIndex = 2
            Me.tbHeadNum.Text = ""
            Me.tbHeadNum.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New Global.System.Drawing.Point(16, 16)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New Global.System.Drawing.Point(10, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(432, 448)
            Me.TabControl1.TabIndex = 0
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
            Me.TabPage1.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New Global.System.Drawing.Size(424, 422)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "General"
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
            Me.TabPage2.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New Global.System.Drawing.Size(424, 422)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Model/Texture Names"
            Me.Button1.Location = New Global.System.Drawing.Point(112, 384)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New Global.System.Drawing.Size(224, 23)
            Me.Button1.TabIndex = 21
            Me.Button1.Text = "Show samples from Base Model Name"
            Me.Label15.Location = New Global.System.Drawing.Point(80, 32)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label15.TabIndex = 2
            Me.Label15.Text = "A"
            Me.Label13.Location = New Global.System.Drawing.Point(144, 8)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Global.System.Drawing.Size(40, 16)
            Me.Label13.TabIndex = 1
            Me.Label13.Text = "Model"
            Me.tbMa.Location = New Global.System.Drawing.Point(112, 32)
            Me.tbMa.Name = "tbMa"
            Me.tbMa.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMa.TabIndex = 0
            Me.tbMa.Text = ""
            Me.tbTa.Location = New Global.System.Drawing.Point(232, 32)
            Me.tbTa.Name = "tbTa"
            Me.tbTa.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTa.TabIndex = 1
            Me.tbTa.Text = ""
            Me.tbMb.Location = New Global.System.Drawing.Point(112, 64)
            Me.tbMb.Name = "tbMb"
            Me.tbMb.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMb.TabIndex = 2
            Me.tbMb.Text = ""
            Me.tbTb.Location = New Global.System.Drawing.Point(232, 64)
            Me.tbTb.Name = "tbTb"
            Me.tbTb.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTb.TabIndex = 3
            Me.tbTb.Text = ""
            Me.tbTd.Location = New Global.System.Drawing.Point(232, 128)
            Me.tbTd.Name = "tbTd"
            Me.tbTd.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTd.TabIndex = 7
            Me.tbTd.Text = ""
            Me.tbMd.Location = New Global.System.Drawing.Point(112, 128)
            Me.tbMd.Name = "tbMd"
            Me.tbMd.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMd.TabIndex = 6
            Me.tbMd.Text = ""
            Me.tbMc.Location = New Global.System.Drawing.Point(112, 96)
            Me.tbMc.Name = "tbMc"
            Me.tbMc.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMc.TabIndex = 4
            Me.tbMc.Text = ""
            Me.tbTc.Location = New Global.System.Drawing.Point(232, 96)
            Me.tbTc.Name = "tbTc"
            Me.tbTc.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTc.TabIndex = 5
            Me.tbTc.Text = ""
            Me.tbTf.Location = New Global.System.Drawing.Point(232, 192)
            Me.tbTf.Name = "tbTf"
            Me.tbTf.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTf.TabIndex = 11
            Me.tbTf.Text = ""
            Me.tbMf.Location = New Global.System.Drawing.Point(112, 192)
            Me.tbMf.Name = "tbMf"
            Me.tbMf.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMf.TabIndex = 10
            Me.tbMf.Text = ""
            Me.tbMe.Location = New Global.System.Drawing.Point(112, 160)
            Me.tbMe.Name = "tbMe"
            Me.tbMe.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMe.TabIndex = 8
            Me.tbMe.Text = ""
            Me.tbTe.Location = New Global.System.Drawing.Point(232, 160)
            Me.tbTe.Name = "tbTe"
            Me.tbTe.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTe.TabIndex = 9
            Me.tbTe.Text = ""
            Me.tbTg.Location = New Global.System.Drawing.Point(232, 224)
            Me.tbTg.Name = "tbTg"
            Me.tbTg.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTg.TabIndex = 13
            Me.tbTg.Text = ""
            Me.tbMg.Location = New Global.System.Drawing.Point(112, 224)
            Me.tbMg.Name = "tbMg"
            Me.tbMg.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMg.TabIndex = 12
            Me.tbMg.Text = ""
            Me.tbMh.Location = New Global.System.Drawing.Point(112, 256)
            Me.tbMh.Name = "tbMh"
            Me.tbMh.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMh.TabIndex = 14
            Me.tbMh.Text = ""
            Me.tbTh.Location = New Global.System.Drawing.Point(232, 256)
            Me.tbTh.Name = "tbTh"
            Me.tbTh.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTh.TabIndex = 15
            Me.tbTh.Text = ""
            Me.tbTi.Location = New Global.System.Drawing.Point(232, 288)
            Me.tbTi.Name = "tbTi"
            Me.tbTi.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTi.TabIndex = 17
            Me.tbTi.Text = ""
            Me.tbMi.Location = New Global.System.Drawing.Point(112, 288)
            Me.tbMi.Name = "tbMi"
            Me.tbMi.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMi.TabIndex = 16
            Me.tbMi.Text = ""
            Me.tbMj.Location = New Global.System.Drawing.Point(112, 320)
            Me.tbMj.Name = "tbMj"
            Me.tbMj.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMj.TabIndex = 18
            Me.tbMj.Text = ""
            Me.tbTj.Location = New Global.System.Drawing.Point(232, 320)
            Me.tbTj.Name = "tbTj"
            Me.tbTj.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTj.TabIndex = 19
            Me.tbTj.Text = ""
            Me.Label14.Location = New Global.System.Drawing.Point(256, 8)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label14.TabIndex = 1
            Me.Label14.Text = "Texture"
            Me.Label16.Location = New Global.System.Drawing.Point(80, 64)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label16.TabIndex = 2
            Me.Label16.Text = "B"
            Me.Label17.Location = New Global.System.Drawing.Point(80, 96)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label17.TabIndex = 2
            Me.Label17.Text = "C"
            Me.Label18.Location = New Global.System.Drawing.Point(80, 128)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label18.TabIndex = 2
            Me.Label18.Text = "D"
            Me.Label19.Location = New Global.System.Drawing.Point(80, 256)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label19.TabIndex = 2
            Me.Label19.Text = "H"
            Me.Label20.Location = New Global.System.Drawing.Point(80, 192)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label20.TabIndex = 2
            Me.Label20.Text = "F"
            Me.Label21.Location = New Global.System.Drawing.Point(80, 224)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label21.TabIndex = 2
            Me.Label21.Text = "G"
            Me.Label22.Location = New Global.System.Drawing.Point(80, 160)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label22.TabIndex = 2
            Me.Label22.Text = "E"
            Me.Label23.Location = New Global.System.Drawing.Point(80, 320)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label23.TabIndex = 2
            Me.Label23.Text = "J"
            Me.Label24.Location = New Global.System.Drawing.Point(80, 288)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label24.TabIndex = 2
            Me.Label24.Text = "I"
            Me.tbEvilTexture.Location = New Global.System.Drawing.Point(112, 352)
            Me.tbEvilTexture.Name = "tbEvilTexture"
            Me.tbEvilTexture.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbEvilTexture.TabIndex = 20
            Me.tbEvilTexture.Text = ""
            Me.Label25.Location = New Global.System.Drawing.Point(32, 352)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label25.TabIndex = 1
            Me.Label25.Text = "Evil Texture"
            Me.chkbAutoCreateSeqEntries.Location = New Global.System.Drawing.Point(232, 144)
            Me.chkbAutoCreateSeqEntries.Name = "chkbAutoCreateSeqEntries"
            Me.chkbAutoCreateSeqEntries.Size = New Global.System.Drawing.Size(184, 16)
            Me.chkbAutoCreateSeqEntries.TabIndex = 13
            Me.chkbAutoCreateSeqEntries.Text = "Auto-create sequential entries"
            Me.chkbAutoCreateSeqEntries.Visible = False
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(464, 517)
            Me.ControlBox = False
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmAppearanceWizard"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.Text = "Appearance Wizard"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.cmbxModelNaming.SelectedIndexChanged, AddressOf Me.cmbxModelNaming_SelectedIndexChanged
            AddHandler Me.TabControl1.SelectedIndexChanged, AddressOf Me.TabControl1_SelectedIndexChanged
            AddHandler Me.chkbAutoCreateSeqEntries.CheckedChanged, AddressOf Me.chkbAutoCreateSeqEntires_CheckedChanged
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
