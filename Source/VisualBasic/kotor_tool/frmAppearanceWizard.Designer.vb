Namespace kotor_tool
	' Token: 0x0200003F RID: 63
	Public Partial Class frmAppearanceWizard
		Inherits Global.kotor_tool.frmParent

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
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmAppearanceWizard))
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
            Dim tbName As Global.System.Windows.Forms.Control = Me.tbName
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(160, 24)
            tbName.Location = point
            Me.tbName.Name = "tbName"
            Me.tbName.TabIndex = 0
            Me.tbName.Text = ""
            Me.cmbxGender.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxGender.Items.AddRange(New Object() {"Male", "Female"})
            Dim cmbxGender As Global.System.Windows.Forms.Control = Me.cmbxGender
            point = New Global.System.Drawing.Point(160, 56)
            cmbxGender.Location = point
            Me.cmbxGender.Name = "cmbxGender"
            Dim cmbxGender2 As Global.System.Windows.Forms.Control = Me.cmbxGender
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(56, 21)
            cmbxGender2.Size = size
            Me.cmbxGender.TabIndex = 1
            Me.cmbxSizes.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSizes.Items.AddRange(New Object() {"1", "3"})
            Dim cmbxSizes As Global.System.Windows.Forms.Control = Me.cmbxSizes
            point = New Global.System.Drawing.Point(160, 168)
            cmbxSizes.Location = point
            Me.cmbxSizes.Name = "cmbxSizes"
            Me.cmbxSizes.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim cmbxSizes2 As Global.System.Windows.Forms.Control = Me.cmbxSizes
            size = New Global.System.Drawing.Size(56, 21)
            cmbxSizes2.Size = size
            Me.cmbxSizes.TabIndex = 5
            Me.cmbxEnvMap.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxEnvMap.Items.AddRange(New Object() {"DEFAULT", "CM_BareMetal", "CM_MANUN"})
            Dim cmbxEnvMap As Global.System.Windows.Forms.Control = Me.cmbxEnvMap
            point = New Global.System.Drawing.Point(160, 200)
            cmbxEnvMap.Location = point
            Me.cmbxEnvMap.Name = "cmbxEnvMap"
            Me.cmbxEnvMap.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim cmbxEnvMap2 As Global.System.Windows.Forms.Control = Me.cmbxEnvMap
            size = New Global.System.Drawing.Size(128, 21)
            cmbxEnvMap2.Size = size
            Me.cmbxEnvMap.TabIndex = 6
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(16, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(100, 16)
            label2.Size = size
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Name"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(16, 56)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(100, 16)
            label4.Size = size
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Gender"
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(16, 168)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(136, 16)
            label6.Size = size
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Number of Sizes to create"
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(16, 200)
            label7.Location = point
            Me.Label4.Name = "Label4"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(100, 16)
            label8.Size = size
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Environment Map"
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(16, 232)
            label9.Location = point
            Me.Label5.Name = "Label5"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(100, 16)
            label10.Size = size
            Me.Label5.TabIndex = 3
            Me.Label5.Text = "Movement Rate"
            Me.cmbxMovementRate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMovementRate.Items.AddRange(New Object() {"No Movement", "Wee Folk", "Very Slow", "Slow", "Norm/Default", "Fast", "Very Fast", "Player", "Huge", "Giant", "Fastest"})
            Dim cmbxMovementRate As Global.System.Windows.Forms.Control = Me.cmbxMovementRate
            point = New Global.System.Drawing.Point(160, 232)
            cmbxMovementRate.Location = point
            Me.cmbxMovementRate.Name = "cmbxMovementRate"
            Me.cmbxMovementRate.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim cmbxMovementRate2 As Global.System.Windows.Forms.Control = Me.cmbxMovementRate
            size = New Global.System.Drawing.Size(128, 21)
            cmbxMovementRate2.Size = size
            Me.cmbxMovementRate.TabIndex = 7
            Me.cmbxModelType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxModelType.Items.AddRange(New Object() {"B", "F", "L", "S"})
            Dim cmbxModelType As Global.System.Windows.Forms.Control = Me.cmbxModelType
            point = New Global.System.Drawing.Point(160, 264)
            cmbxModelType.Location = point
            Me.cmbxModelType.Name = "cmbxModelType"
            Me.cmbxModelType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim cmbxModelType2 As Global.System.Windows.Forms.Control = Me.cmbxModelType
            size = New Global.System.Drawing.Size(128, 21)
            cmbxModelType2.Size = size
            Me.cmbxModelType.TabIndex = 8
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(16, 296)
            label11.Location = point
            Me.Label6.Name = "Label6"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(100, 16)
            label12.Size = size
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "Hit Radius"
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(16, 328)
            label13.Location = point
            Me.Label7.Name = "Label7"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(100, 16)
            label14.Size = size
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "Personal Space"
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(16, 360)
            label15.Location = point
            Me.Label8.Name = "Label8"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(128, 16)
            label16.Size = size
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "CRep Personal Space"
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(16, 392)
            label17.Location = point
            Me.Label9.Name = "Label9"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(136, 16)
            label18.Size = size
            Me.Label9.TabIndex = 3
            Me.Label9.Text = "Preferred Attack Distance"
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(16, 264)
            label19.Location = point
            Me.Label10.Name = "Label10"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(100, 16)
            label20.Size = size
            Me.Label10.TabIndex = 3
            Me.Label10.Text = "Model Type"
            Dim tbHitRadius As Global.System.Windows.Forms.Control = Me.tbHitRadius
            point = New Global.System.Drawing.Point(160, 296)
            tbHitRadius.Location = point
            Me.tbHitRadius.Name = "tbHitRadius"
            Dim tbHitRadius2 As Global.System.Windows.Forms.Control = Me.tbHitRadius
            size = New Global.System.Drawing.Size(32, 20)
            tbHitRadius2.Size = size
            Me.tbHitRadius.TabIndex = 9
            Me.tbHitRadius.Text = "****"
            Me.tbHitRadius.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim tbPerspace As Global.System.Windows.Forms.Control = Me.tbPerspace
            point = New Global.System.Drawing.Point(160, 328)
            tbPerspace.Location = point
            Me.tbPerspace.Name = "tbPerspace"
            Dim tbPerspace2 As Global.System.Windows.Forms.Control = Me.tbPerspace
            size = New Global.System.Drawing.Size(32, 20)
            tbPerspace2.Size = size
            Me.tbPerspace.TabIndex = 10
            Me.tbPerspace.Text = "****"
            Me.tbPerspace.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim tbprefatkdist As Global.System.Windows.Forms.Control = Me.tbprefatkdist
            point = New Global.System.Drawing.Point(160, 392)
            tbprefatkdist.Location = point
            Me.tbprefatkdist.Name = "tbprefatkdist"
            Dim tbprefatkdist2 As Global.System.Windows.Forms.Control = Me.tbprefatkdist
            size = New Global.System.Drawing.Size(32, 20)
            tbprefatkdist2.Size = size
            Me.tbprefatkdist.TabIndex = 12
            Me.tbprefatkdist.Text = "****"
            Me.tbprefatkdist.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim tbCreperspace As Global.System.Windows.Forms.Control = Me.tbCreperspace
            point = New Global.System.Drawing.Point(160, 360)
            tbCreperspace.Location = point
            Me.tbCreperspace.Name = "tbCreperspace"
            Dim tbCreperspace2 As Global.System.Windows.Forms.Control = Me.tbCreperspace
            size = New Global.System.Drawing.Size(32, 20)
            tbCreperspace2.Size = size
            Me.tbCreperspace.TabIndex = 11
            Me.tbCreperspace.Text = "****"
            Me.tbCreperspace.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(16, 120)
            label21.Location = point
            Me.Label11.Name = "Label11"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(100, 16)
            label22.Size = size
            Me.Label11.TabIndex = 3
            Me.Label11.Text = "Base Model Name"
            Dim tbBaseModelName As Global.System.Windows.Forms.Control = Me.tbBaseModelName
            point = New Global.System.Drawing.Point(160, 120)
            tbBaseModelName.Location = point
            Me.tbBaseModelName.Name = "tbBaseModelName"
            Dim tbBaseModelName2 As Global.System.Windows.Forms.Control = Me.tbBaseModelName
            size = New Global.System.Drawing.Size(56, 20)
            tbBaseModelName2.Size = size
            Me.tbBaseModelName.TabIndex = 3
            Me.tbBaseModelName.Text = ""
            Me.cmbxModelNaming.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxModelNaming.Items.AddRange(New Object() {"Use name for all model entries", "Create sequential model entries"})
            Dim cmbxModelNaming As Global.System.Windows.Forms.Control = Me.cmbxModelNaming
            point = New Global.System.Drawing.Point(232, 120)
            cmbxModelNaming.Location = point
            Me.cmbxModelNaming.Name = "cmbxModelNaming"
            Dim cmbxModelNaming2 As Global.System.Windows.Forms.Control = Me.cmbxModelNaming
            size = New Global.System.Drawing.Size(184, 21)
            cmbxModelNaming2.Size = size
            Me.cmbxModelNaming.TabIndex = 4
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(280, 488)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(368, 488)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(16, 88)
            label23.Location = point
            Me.Label12.Name = "Label12"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(136, 16)
            label24.Size = size
            Me.Label12.TabIndex = 3
            Me.Label12.Text = "Head Number"
            Dim tbHeadNum As Global.System.Windows.Forms.Control = Me.tbHeadNum
            point = New Global.System.Drawing.Point(160, 88)
            tbHeadNum.Location = point
            Me.tbHeadNum.Name = "tbHeadNum"
            Dim tbHeadNum2 As Global.System.Windows.Forms.Control = Me.tbHeadNum
            size = New Global.System.Drawing.Size(40, 20)
            tbHeadNum2.Size = size
            Me.tbHeadNum.TabIndex = 2
            Me.tbHeadNum.Text = ""
            Me.tbHeadNum.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            point = New Global.System.Drawing.Point(16, 16)
            tabControl.Location = point
            Me.TabControl1.Name = "TabControl1"
            Dim tabControl2 As Global.System.Windows.Forms.TabControl = Me.TabControl1
            point = New Global.System.Drawing.Point(10, 3)
            tabControl2.Padding = point
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl3 As Global.System.Windows.Forms.Control = Me.TabControl1
            size = New Global.System.Drawing.Size(432, 448)
            tabControl3.Size = size
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
            Dim tabPage As Global.System.Windows.Forms.Control = Me.TabPage1
            point = New Global.System.Drawing.Point(4, 22)
            tabPage.Location = point
            Me.TabPage1.Name = "TabPage1"
            Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
            size = New Global.System.Drawing.Size(424, 422)
            tabPage2.Size = size
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
            Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage2
            point = New Global.System.Drawing.Point(4, 22)
            tabPage3.Location = point
            Me.TabPage2.Name = "TabPage2"
            Dim tabPage4 As Global.System.Windows.Forms.Control = Me.TabPage2
            size = New Global.System.Drawing.Size(424, 422)
            tabPage4.Size = size
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Model/Texture Names"
            Dim button As Global.System.Windows.Forms.Control = Me.Button1
            point = New Global.System.Drawing.Point(112, 384)
            button.Location = point
            Me.Button1.Name = "Button1"
            Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
            size = New Global.System.Drawing.Size(224, 23)
            button2.Size = size
            Me.Button1.TabIndex = 21
            Me.Button1.Text = "Show samples from Base Model Name"
            Dim label25 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(80, 32)
            label25.Location = point
            Me.Label15.Name = "Label15"
            Dim label26 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(24, 16)
            label26.Size = size
            Me.Label15.TabIndex = 2
            Me.Label15.Text = "A"
            Dim label27 As Global.System.Windows.Forms.Control = Me.Label13
            point = New Global.System.Drawing.Point(144, 8)
            label27.Location = point
            Me.Label13.Name = "Label13"
            Dim label28 As Global.System.Windows.Forms.Control = Me.Label13
            size = New Global.System.Drawing.Size(40, 16)
            label28.Size = size
            Me.Label13.TabIndex = 1
            Me.Label13.Text = "Model"
            Dim tbMa As Global.System.Windows.Forms.Control = Me.tbMa
            point = New Global.System.Drawing.Point(112, 32)
            tbMa.Location = point
            Me.tbMa.Name = "tbMa"
            Me.tbMa.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMa.TabIndex = 0
            Me.tbMa.Text = ""
            Dim tbTa As Global.System.Windows.Forms.Control = Me.tbTa
            point = New Global.System.Drawing.Point(232, 32)
            tbTa.Location = point
            Me.tbTa.Name = "tbTa"
            Me.tbTa.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTa.TabIndex = 1
            Me.tbTa.Text = ""
            Dim tbMb As Global.System.Windows.Forms.Control = Me.tbMb
            point = New Global.System.Drawing.Point(112, 64)
            tbMb.Location = point
            Me.tbMb.Name = "tbMb"
            Me.tbMb.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMb.TabIndex = 2
            Me.tbMb.Text = ""
            Dim tbTb As Global.System.Windows.Forms.Control = Me.tbTb
            point = New Global.System.Drawing.Point(232, 64)
            tbTb.Location = point
            Me.tbTb.Name = "tbTb"
            Me.tbTb.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTb.TabIndex = 3
            Me.tbTb.Text = ""
            Dim tbTd As Global.System.Windows.Forms.Control = Me.tbTd
            point = New Global.System.Drawing.Point(232, 128)
            tbTd.Location = point
            Me.tbTd.Name = "tbTd"
            Me.tbTd.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTd.TabIndex = 7
            Me.tbTd.Text = ""
            Dim tbMd As Global.System.Windows.Forms.Control = Me.tbMd
            point = New Global.System.Drawing.Point(112, 128)
            tbMd.Location = point
            Me.tbMd.Name = "tbMd"
            Me.tbMd.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMd.TabIndex = 6
            Me.tbMd.Text = ""
            Dim tbMc As Global.System.Windows.Forms.Control = Me.tbMc
            point = New Global.System.Drawing.Point(112, 96)
            tbMc.Location = point
            Me.tbMc.Name = "tbMc"
            Me.tbMc.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMc.TabIndex = 4
            Me.tbMc.Text = ""
            Dim tbTc As Global.System.Windows.Forms.Control = Me.tbTc
            point = New Global.System.Drawing.Point(232, 96)
            tbTc.Location = point
            Me.tbTc.Name = "tbTc"
            Me.tbTc.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTc.TabIndex = 5
            Me.tbTc.Text = ""
            Dim tbTf As Global.System.Windows.Forms.Control = Me.tbTf
            point = New Global.System.Drawing.Point(232, 192)
            tbTf.Location = point
            Me.tbTf.Name = "tbTf"
            Me.tbTf.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTf.TabIndex = 11
            Me.tbTf.Text = ""
            Dim tbMf As Global.System.Windows.Forms.Control = Me.tbMf
            point = New Global.System.Drawing.Point(112, 192)
            tbMf.Location = point
            Me.tbMf.Name = "tbMf"
            Me.tbMf.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMf.TabIndex = 10
            Me.tbMf.Text = ""
            Dim tbMe As Global.System.Windows.Forms.Control = Me.tbMe
            point = New Global.System.Drawing.Point(112, 160)
            tbMe.Location = point
            Me.tbMe.Name = "tbMe"
            Me.tbMe.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMe.TabIndex = 8
            Me.tbMe.Text = ""
            Dim tbTe As Global.System.Windows.Forms.Control = Me.tbTe
            point = New Global.System.Drawing.Point(232, 160)
            tbTe.Location = point
            Me.tbTe.Name = "tbTe"
            Me.tbTe.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTe.TabIndex = 9
            Me.tbTe.Text = ""
            Dim tbTg As Global.System.Windows.Forms.Control = Me.tbTg
            point = New Global.System.Drawing.Point(232, 224)
            tbTg.Location = point
            Me.tbTg.Name = "tbTg"
            Me.tbTg.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTg.TabIndex = 13
            Me.tbTg.Text = ""
            Dim tbMg As Global.System.Windows.Forms.Control = Me.tbMg
            point = New Global.System.Drawing.Point(112, 224)
            tbMg.Location = point
            Me.tbMg.Name = "tbMg"
            Me.tbMg.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMg.TabIndex = 12
            Me.tbMg.Text = ""
            Dim tbMh As Global.System.Windows.Forms.Control = Me.tbMh
            point = New Global.System.Drawing.Point(112, 256)
            tbMh.Location = point
            Me.tbMh.Name = "tbMh"
            Me.tbMh.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMh.TabIndex = 14
            Me.tbMh.Text = ""
            Dim tbTh As Global.System.Windows.Forms.Control = Me.tbTh
            point = New Global.System.Drawing.Point(232, 256)
            tbTh.Location = point
            Me.tbTh.Name = "tbTh"
            Me.tbTh.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTh.TabIndex = 15
            Me.tbTh.Text = ""
            Dim tbTi As Global.System.Windows.Forms.Control = Me.tbTi
            point = New Global.System.Drawing.Point(232, 288)
            tbTi.Location = point
            Me.tbTi.Name = "tbTi"
            Me.tbTi.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTi.TabIndex = 17
            Me.tbTi.Text = ""
            Dim tbMi As Global.System.Windows.Forms.Control = Me.tbMi
            point = New Global.System.Drawing.Point(112, 288)
            tbMi.Location = point
            Me.tbMi.Name = "tbMi"
            Me.tbMi.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMi.TabIndex = 16
            Me.tbMi.Text = ""
            Dim tbMj As Global.System.Windows.Forms.Control = Me.tbMj
            point = New Global.System.Drawing.Point(112, 320)
            tbMj.Location = point
            Me.tbMj.Name = "tbMj"
            Me.tbMj.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMj.TabIndex = 18
            Me.tbMj.Text = ""
            Dim tbTj As Global.System.Windows.Forms.Control = Me.tbTj
            point = New Global.System.Drawing.Point(232, 320)
            tbTj.Location = point
            Me.tbTj.Name = "tbTj"
            Me.tbTj.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTj.TabIndex = 19
            Me.tbTj.Text = ""
            Dim label29 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(256, 8)
            label29.Location = point
            Me.Label14.Name = "Label14"
            Dim label30 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(48, 16)
            label30.Size = size
            Me.Label14.TabIndex = 1
            Me.Label14.Text = "Texture"
            Dim label31 As Global.System.Windows.Forms.Control = Me.Label16
            point = New Global.System.Drawing.Point(80, 64)
            label31.Location = point
            Me.Label16.Name = "Label16"
            Dim label32 As Global.System.Windows.Forms.Control = Me.Label16
            size = New Global.System.Drawing.Size(24, 16)
            label32.Size = size
            Me.Label16.TabIndex = 2
            Me.Label16.Text = "B"
            Dim label33 As Global.System.Windows.Forms.Control = Me.Label17
            point = New Global.System.Drawing.Point(80, 96)
            label33.Location = point
            Me.Label17.Name = "Label17"
            Dim label34 As Global.System.Windows.Forms.Control = Me.Label17
            size = New Global.System.Drawing.Size(24, 16)
            label34.Size = size
            Me.Label17.TabIndex = 2
            Me.Label17.Text = "C"
            Dim label35 As Global.System.Windows.Forms.Control = Me.Label18
            point = New Global.System.Drawing.Point(80, 128)
            label35.Location = point
            Me.Label18.Name = "Label18"
            Dim label36 As Global.System.Windows.Forms.Control = Me.Label18
            size = New Global.System.Drawing.Size(24, 16)
            label36.Size = size
            Me.Label18.TabIndex = 2
            Me.Label18.Text = "D"
            Dim label37 As Global.System.Windows.Forms.Control = Me.Label19
            point = New Global.System.Drawing.Point(80, 256)
            label37.Location = point
            Me.Label19.Name = "Label19"
            Dim label38 As Global.System.Windows.Forms.Control = Me.Label19
            size = New Global.System.Drawing.Size(24, 16)
            label38.Size = size
            Me.Label19.TabIndex = 2
            Me.Label19.Text = "H"
            Dim label39 As Global.System.Windows.Forms.Control = Me.Label20
            point = New Global.System.Drawing.Point(80, 192)
            label39.Location = point
            Me.Label20.Name = "Label20"
            Dim label40 As Global.System.Windows.Forms.Control = Me.Label20
            size = New Global.System.Drawing.Size(24, 16)
            label40.Size = size
            Me.Label20.TabIndex = 2
            Me.Label20.Text = "F"
            Dim label41 As Global.System.Windows.Forms.Control = Me.Label21
            point = New Global.System.Drawing.Point(80, 224)
            label41.Location = point
            Me.Label21.Name = "Label21"
            Dim label42 As Global.System.Windows.Forms.Control = Me.Label21
            size = New Global.System.Drawing.Size(24, 16)
            label42.Size = size
            Me.Label21.TabIndex = 2
            Me.Label21.Text = "G"
            Dim label43 As Global.System.Windows.Forms.Control = Me.Label22
            point = New Global.System.Drawing.Point(80, 160)
            label43.Location = point
            Me.Label22.Name = "Label22"
            Dim label44 As Global.System.Windows.Forms.Control = Me.Label22
            size = New Global.System.Drawing.Size(24, 16)
            label44.Size = size
            Me.Label22.TabIndex = 2
            Me.Label22.Text = "E"
            Dim label45 As Global.System.Windows.Forms.Control = Me.Label23
            point = New Global.System.Drawing.Point(80, 320)
            label45.Location = point
            Me.Label23.Name = "Label23"
            Dim label46 As Global.System.Windows.Forms.Control = Me.Label23
            size = New Global.System.Drawing.Size(24, 16)
            label46.Size = size
            Me.Label23.TabIndex = 2
            Me.Label23.Text = "J"
            Dim label47 As Global.System.Windows.Forms.Control = Me.Label24
            point = New Global.System.Drawing.Point(80, 288)
            label47.Location = point
            Me.Label24.Name = "Label24"
            Dim label48 As Global.System.Windows.Forms.Control = Me.Label24
            size = New Global.System.Drawing.Size(24, 16)
            label48.Size = size
            Me.Label24.TabIndex = 2
            Me.Label24.Text = "I"
            Dim tbEvilTexture As Global.System.Windows.Forms.Control = Me.tbEvilTexture
            point = New Global.System.Drawing.Point(112, 352)
            tbEvilTexture.Location = point
            Me.tbEvilTexture.Name = "tbEvilTexture"
            Me.tbEvilTexture.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbEvilTexture.TabIndex = 20
            Me.tbEvilTexture.Text = ""
            Dim label49 As Global.System.Windows.Forms.Control = Me.Label25
            point = New Global.System.Drawing.Point(32, 352)
            label49.Location = point
            Me.Label25.Name = "Label25"
            Dim label50 As Global.System.Windows.Forms.Control = Me.Label25
            size = New Global.System.Drawing.Size(64, 16)
            label50.Size = size
            Me.Label25.TabIndex = 1
            Me.Label25.Text = "Evil Texture"
            Dim chkbAutoCreateSeqEntries As Global.System.Windows.Forms.Control = Me.chkbAutoCreateSeqEntries
            point = New Global.System.Drawing.Point(232, 144)
            chkbAutoCreateSeqEntries.Location = point
            Me.chkbAutoCreateSeqEntries.Name = "chkbAutoCreateSeqEntries"
            Dim chkbAutoCreateSeqEntries2 As Global.System.Windows.Forms.Control = Me.chkbAutoCreateSeqEntries
            size = New Global.System.Drawing.Size(184, 16)
            chkbAutoCreateSeqEntries2.Size = size
            Me.chkbAutoCreateSeqEntries.TabIndex = 13
            Me.chkbAutoCreateSeqEntries.Text = "Auto-create sequential entries"
            Me.chkbAutoCreateSeqEntries.Visible = False
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(464, 517)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmAppearanceWizard"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.Text = "Appearance Wizard"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000196 RID: 406
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
