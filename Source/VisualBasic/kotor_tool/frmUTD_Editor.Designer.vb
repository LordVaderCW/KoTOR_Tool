Namespace kotor_tool
	' Token: 0x0200007E RID: 126
	Public Partial Class frmUTD_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x060012AC RID: 4780 RVA: 0x002AAF48 File Offset: 0x002A9F48
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600136D RID: 4973 RVA: 0x002AC600 File Offset: 0x002AB600
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUTD_Editor))
            Me.btnSave = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPageBasic = New Global.System.Windows.Forms.TabPage()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.cmbxDoorType = New Global.System.Windows.Forms.ComboBox()
            Me.btnSetNameLang = New Global.System.Windows.Forms.Button()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.nudWill = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudFort = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudHP = New Global.System.Windows.Forms.NumericUpDown()
            Me.lblTextureVariation = New Global.System.Windows.Forms.Label()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.nudHardness = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudRef = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.lblBodyVariation = New Global.System.Windows.Forms.Label()
            Me.chkbPlotItem = New Global.System.Windows.Forms.CheckBox()
            Me.tbTag = New Global.System.Windows.Forms.TextBox()
            Me.tbName = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.chkbStatic = New Global.System.Windows.Forms.CheckBox()
            Me.TabPageLock = New Global.System.Windows.Forms.TabPage()
            Me.cmbxOpenState = New Global.System.Windows.Forms.ComboBox()
            Me.tbKeyName = New Global.System.Windows.Forms.TextBox()
            Me.lblKeyTag = New Global.System.Windows.Forms.Label()
            Me.nudCloseLockDC = New Global.System.Windows.Forms.NumericUpDown()
            Me.lblCloseLockDC = New Global.System.Windows.Forms.Label()
            Me.nudOpenLockDC = New Global.System.Windows.Forms.NumericUpDown()
            Me.lblOpenLockDC = New Global.System.Windows.Forms.Label()
            Me.chkbLockable = New Global.System.Windows.Forms.CheckBox()
            Me.chkbLocked = New Global.System.Windows.Forms.CheckBox()
            Me.chkbKeyRequired = New Global.System.Windows.Forms.CheckBox()
            Me.chkbAutoRemoveKey = New Global.System.Windows.Forms.CheckBox()
            Me.lblOpenState = New Global.System.Windows.Forms.Label()
            Me.chkbNotBlastable = New Global.System.Windows.Forms.CheckBox()
            Me.TabPageScripts = New Global.System.Windows.Forms.TabPage()
            Me.btnEditOnUserDefined = New Global.System.Windows.Forms.Button()
            Me.btnEditOnHeartbeat = New Global.System.Windows.Forms.Button()
            Me.btnEditOnSpellCastAt = New Global.System.Windows.Forms.Button()
            Me.btnEditOnDeath = New Global.System.Windows.Forms.Button()
            Me.btnEditOnDamaged = New Global.System.Windows.Forms.Button()
            Me.btnEditOnTrapTriggered = New Global.System.Windows.Forms.Button()
            Me.btnEditOnDisarm = New Global.System.Windows.Forms.Button()
            Me.btnEditOnClick = New Global.System.Windows.Forms.Button()
            Me.Label34 = New Global.System.Windows.Forms.Label()
            Me.tbOnDeath = New Global.System.Windows.Forms.TextBox()
            Me.Label33 = New Global.System.Windows.Forms.Label()
            Me.tbOnDamaged = New Global.System.Windows.Forms.TextBox()
            Me.Label32 = New Global.System.Windows.Forms.Label()
            Me.tbOnClosed = New Global.System.Windows.Forms.TextBox()
            Me.Label35 = New Global.System.Windows.Forms.Label()
            Me.tbOnDisarm = New Global.System.Windows.Forms.TextBox()
            Me.tbOnHeartbeat = New Global.System.Windows.Forms.TextBox()
            Me.Label36 = New Global.System.Windows.Forms.Label()
            Me.Label37 = New Global.System.Windows.Forms.Label()
            Me.tbOnLock = New Global.System.Windows.Forms.TextBox()
            Me.tbOnMeleeAttacked = New Global.System.Windows.Forms.TextBox()
            Me.Label38 = New Global.System.Windows.Forms.Label()
            Me.tbOnOpen = New Global.System.Windows.Forms.TextBox()
            Me.Label39 = New Global.System.Windows.Forms.Label()
            Me.Label40 = New Global.System.Windows.Forms.Label()
            Me.tbOnSpellCastAt = New Global.System.Windows.Forms.TextBox()
            Me.Label41 = New Global.System.Windows.Forms.Label()
            Me.tbOnTrapTriggered = New Global.System.Windows.Forms.TextBox()
            Me.tbOnUnlock = New Global.System.Windows.Forms.TextBox()
            Me.Label42 = New Global.System.Windows.Forms.Label()
            Me.tbOnUserDefined = New Global.System.Windows.Forms.TextBox()
            Me.Label43 = New Global.System.Windows.Forms.Label()
            Me.tbOnClick = New Global.System.Windows.Forms.TextBox()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.tbOnFailToOpen = New Global.System.Windows.Forms.TextBox()
            Me.btnEditOnClosed = New Global.System.Windows.Forms.Button()
            Me.btnEditOnFailToOpen = New Global.System.Windows.Forms.Button()
            Me.btnEditOnLock = New Global.System.Windows.Forms.Button()
            Me.btnEditOnMeleeAttacked = New Global.System.Windows.Forms.Button()
            Me.btnEditOnOpen = New Global.System.Windows.Forms.Button()
            Me.btnEditOnUnlock = New Global.System.Windows.Forms.Button()
            Me.TabPageAdvanced = New Global.System.Windows.Forms.TabPage()
            Me.cmbxFaction = New Global.System.Windows.Forms.ComboBox()
            Me.chkbNotInterruptable = New Global.System.Windows.Forms.CheckBox()
            Me.tbConversation = New Global.System.Windows.Forms.TextBox()
            Me.tbTemplateResRef = New Global.System.Windows.Forms.TextBox()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.Label13 = New Global.System.Windows.Forms.Label()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.tbAnimationState = New Global.System.Windows.Forms.TextBox()
            Me.TabPageDescription = New Global.System.Windows.Forms.TabPage()
            Me.btnSetDescriptionLang = New Global.System.Windows.Forms.Button()
            Me.tbDescription = New Global.System.Windows.Forms.TextBox()
            Me.TabPageComments = New Global.System.Windows.Forms.TabPage()
            Me.tbComment = New Global.System.Windows.Forms.TextBox()
            Me.btnDebug = New Global.System.Windows.Forms.Button()
            Me.TabControl1.SuspendLayout()
            Me.TabPageBasic.SuspendLayout()
            CType(Me.nudWill, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFort, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudHP, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudHardness, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRef, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPageLock.SuspendLayout()
            CType(Me.nudCloseLockDC, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudOpenLockDC, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPageScripts.SuspendLayout()
            Me.TabPageAdvanced.SuspendLayout()
            Me.TabPageDescription.SuspendLayout()
            Me.TabPageComments.SuspendLayout()
            Me.SuspendLayout()
            Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(304, 464)
            btnSave.Location = point
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "&Save"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(400, 464)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancel"
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.TabPageBasic)
            Me.TabControl1.Controls.Add(Me.TabPageLock)
            Me.TabControl1.Controls.Add(Me.TabPageScripts)
            Me.TabControl1.Controls.Add(Me.TabPageAdvanced)
            Me.TabControl1.Controls.Add(Me.TabPageDescription)
            Me.TabControl1.Controls.Add(Me.TabPageComments)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            point = New Global.System.Drawing.Point(16, 8)
            tabControl.Location = point
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Dim tabControl2 As Global.System.Windows.Forms.TabControl = Me.TabControl1
            point = New Global.System.Drawing.Point(15, 3)
            tabControl2.Padding = point
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl3 As Global.System.Windows.Forms.Control = Me.TabControl1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(456, 440)
            tabControl3.Size = size
            Me.TabControl1.SizeMode = Global.System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabIndex = 0
            Me.TabPageBasic.Controls.Add(Me.Label19)
            Me.TabPageBasic.Controls.Add(Me.cmbxDoorType)
            Me.TabPageBasic.Controls.Add(Me.btnSetNameLang)
            Me.TabPageBasic.Controls.Add(Me.Label5)
            Me.TabPageBasic.Controls.Add(Me.nudWill)
            Me.TabPageBasic.Controls.Add(Me.nudFort)
            Me.TabPageBasic.Controls.Add(Me.nudHP)
            Me.TabPageBasic.Controls.Add(Me.lblTextureVariation)
            Me.TabPageBasic.Controls.Add(Me.Label8)
            Me.TabPageBasic.Controls.Add(Me.nudHardness)
            Me.TabPageBasic.Controls.Add(Me.nudRef)
            Me.TabPageBasic.Controls.Add(Me.Label12)
            Me.TabPageBasic.Controls.Add(Me.lblBodyVariation)
            Me.TabPageBasic.Controls.Add(Me.chkbPlotItem)
            Me.TabPageBasic.Controls.Add(Me.tbTag)
            Me.TabPageBasic.Controls.Add(Me.tbName)
            Me.TabPageBasic.Controls.Add(Me.Label1)
            Me.TabPageBasic.Controls.Add(Me.Label2)
            Me.TabPageBasic.Controls.Add(Me.chkbStatic)
            Dim tabPageBasic As Global.System.Windows.Forms.Control = Me.TabPageBasic
            point = New Global.System.Drawing.Point(4, 22)
            tabPageBasic.Location = point
            Me.TabPageBasic.Name = "TabPageBasic"
            Dim tabPageBasic2 As Global.System.Windows.Forms.Control = Me.TabPageBasic
            size = New Global.System.Drawing.Size(448, 414)
            tabPageBasic2.Size = size
            Me.TabPageBasic.TabIndex = 0
            Me.TabPageBasic.Text = "Basic"
            Dim label As Global.System.Windows.Forms.Control = Me.Label19
            point = New Global.System.Drawing.Point(48, 80)
            label.Location = point
            Me.Label19.Name = "Label19"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label19
            size = New Global.System.Drawing.Size(80, 16)
            label2.Size = size
            Me.Label19.TabIndex = 12
            Me.Label19.Text = "Door Type"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxDoorType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxDoorType As Global.System.Windows.Forms.Control = Me.cmbxDoorType
            point = New Global.System.Drawing.Point(128, 80)
            cmbxDoorType.Location = point
            Me.cmbxDoorType.Name = "cmbxDoorType"
            Dim cmbxDoorType2 As Global.System.Windows.Forms.Control = Me.cmbxDoorType
            size = New Global.System.Drawing.Size(200, 21)
            cmbxDoorType2.Size = size
            Me.cmbxDoorType.TabIndex = 11
            Dim btnSetNameLang As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            point = New Global.System.Drawing.Point(344, 32)
            btnSetNameLang.Location = point
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Dim btnSetNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetNameLang2.Size = size
            Me.btnSetNameLang.TabIndex = 9
            Me.btnSetNameLang.Text = "Set Language"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(48, 200)
            label3.Location = point
            Me.Label5.Name = "Label5"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(88, 16)
            label4.Size = size
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Fortitude Save"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudWill As Global.System.Windows.Forms.Control = Me.nudWill
            point = New Global.System.Drawing.Point(192, 248)
            nudWill.Location = point
            Me.nudWill.Name = "nudWill"
            Me.nudWill.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudWill2 As Global.System.Windows.Forms.Control = Me.nudWill
            size = New Global.System.Drawing.Size(48, 20)
            nudWill2.Size = size
            Me.nudWill.TabIndex = 7
            Me.nudWill.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudFort As Global.System.Windows.Forms.Control = Me.nudFort
            point = New Global.System.Drawing.Point(192, 200)
            nudFort.Location = point
            Me.nudFort.Name = "nudFort"
            Me.nudFort.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudFort2 As Global.System.Windows.Forms.Control = Me.nudFort
            size = New Global.System.Drawing.Size(48, 20)
            nudFort2.Size = size
            Me.nudFort.TabIndex = 5
            Me.nudFort.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudHP As Global.System.Windows.Forms.Control = Me.nudHP
            point = New Global.System.Drawing.Point(192, 176)
            nudHP.Location = point
            Dim nudHP2 As Global.System.Windows.Forms.NumericUpDown = Me.nudHP
            Dim num As Decimal = New Decimal(New Integer() {99999, 0, 0, 0})
            nudHP2.Maximum = num
            Me.nudHP.Name = "nudHP"
            Me.nudHP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudHP3 As Global.System.Windows.Forms.Control = Me.nudHP
            size = New Global.System.Drawing.Size(48, 20)
            nudHP3.Size = size
            Me.nudHP.TabIndex = 4
            Me.nudHP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim lblTextureVariation As Global.System.Windows.Forms.Control = Me.lblTextureVariation
            point = New Global.System.Drawing.Point(48, 248)
            lblTextureVariation.Location = point
            Me.lblTextureVariation.Name = "lblTextureVariation"
            Dim lblTextureVariation2 As Global.System.Windows.Forms.Control = Me.lblTextureVariation
            size = New Global.System.Drawing.Size(96, 16)
            lblTextureVariation2.Size = size
            Me.lblTextureVariation.TabIndex = 5
            Me.lblTextureVariation.Text = "Will Save"
            Me.lblTextureVariation.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(48, 176)
            label5.Location = point
            Me.Label8.Name = "Label8"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(88, 16)
            label6.Size = size
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Hit Points"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudHardness As Global.System.Windows.Forms.Control = Me.nudHardness
            point = New Global.System.Drawing.Point(192, 152)
            nudHardness.Location = point
            Dim nudHardness2 As Global.System.Windows.Forms.NumericUpDown = Me.nudHardness
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudHardness2.Maximum = num
            Me.nudHardness.Name = "nudHardness"
            Me.nudHardness.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudHardness3 As Global.System.Windows.Forms.Control = Me.nudHardness
            size = New Global.System.Drawing.Size(48, 20)
            nudHardness3.Size = size
            Me.nudHardness.TabIndex = 3
            Me.nudHardness.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudRef As Global.System.Windows.Forms.Control = Me.nudRef
            point = New Global.System.Drawing.Point(192, 224)
            nudRef.Location = point
            Me.nudRef.Name = "nudRef"
            Me.nudRef.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudRef2 As Global.System.Windows.Forms.Control = Me.nudRef
            size = New Global.System.Drawing.Size(48, 20)
            nudRef2.Size = size
            Me.nudRef.TabIndex = 6
            Me.nudRef.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(48, 152)
            label7.Location = point
            Me.Label12.Name = "Label12"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(88, 16)
            label8.Size = size
            Me.Label12.TabIndex = 7
            Me.Label12.Text = "Hardness"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim lblBodyVariation As Global.System.Windows.Forms.Control = Me.lblBodyVariation
            point = New Global.System.Drawing.Point(48, 224)
            lblBodyVariation.Location = point
            Me.lblBodyVariation.Name = "lblBodyVariation"
            Dim lblBodyVariation2 As Global.System.Windows.Forms.Control = Me.lblBodyVariation
            size = New Global.System.Drawing.Size(88, 16)
            lblBodyVariation2.Size = size
            Me.lblBodyVariation.TabIndex = 6
            Me.lblBodyVariation.Text = "Reflex Save"
            Me.lblBodyVariation.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbPlotItem As Global.System.Windows.Forms.Control = Me.chkbPlotItem
            point = New Global.System.Drawing.Point(48, 112)
            chkbPlotItem.Location = point
            Me.chkbPlotItem.Name = "chkbPlotItem"
            Dim chkbPlotItem2 As Global.System.Windows.Forms.Control = Me.chkbPlotItem
            size = New Global.System.Drawing.Size(72, 24)
            chkbPlotItem2.Size = size
            Me.chkbPlotItem.TabIndex = 2
            Me.chkbPlotItem.Text = "Plot item"
            Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
            point = New Global.System.Drawing.Point(128, 56)
            tbTag.Location = point
            Me.tbTag.Name = "tbTag"
            Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
            size = New Global.System.Drawing.Size(200, 20)
            tbTag2.Size = size
            Me.tbTag.TabIndex = 1
            Me.tbTag.Text = ""
            Dim tbName As Global.System.Windows.Forms.Control = Me.tbName
            point = New Global.System.Drawing.Point(128, 32)
            tbName.Location = point
            Me.tbName.Name = "tbName"
            Dim tbName2 As Global.System.Windows.Forms.Control = Me.tbName
            size = New Global.System.Drawing.Size(200, 20)
            tbName2.Size = size
            Me.tbName.TabIndex = 0
            Me.tbName.Text = ""
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(48, 32)
            label9.Location = point
            Me.Label1.Name = "Label1"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(100, 16)
            label10.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Name"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(48, 56)
            label11.Location = point
            Me.Label2.Name = "Label2"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(100, 16)
            label12.Size = size
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbStatic As Global.System.Windows.Forms.Control = Me.chkbStatic
            point = New Global.System.Drawing.Point(192, 112)
            chkbStatic.Location = point
            Me.chkbStatic.Name = "chkbStatic"
            Dim chkbStatic2 As Global.System.Windows.Forms.Control = Me.chkbStatic
            size = New Global.System.Drawing.Size(72, 24)
            chkbStatic2.Size = size
            Me.chkbStatic.TabIndex = 2
            Me.chkbStatic.Text = "Static"
            Me.TabPageLock.Controls.Add(Me.cmbxOpenState)
            Me.TabPageLock.Controls.Add(Me.tbKeyName)
            Me.TabPageLock.Controls.Add(Me.lblKeyTag)
            Me.TabPageLock.Controls.Add(Me.nudCloseLockDC)
            Me.TabPageLock.Controls.Add(Me.lblCloseLockDC)
            Me.TabPageLock.Controls.Add(Me.nudOpenLockDC)
            Me.TabPageLock.Controls.Add(Me.lblOpenLockDC)
            Me.TabPageLock.Controls.Add(Me.chkbLockable)
            Me.TabPageLock.Controls.Add(Me.chkbLocked)
            Me.TabPageLock.Controls.Add(Me.chkbKeyRequired)
            Me.TabPageLock.Controls.Add(Me.chkbAutoRemoveKey)
            Me.TabPageLock.Controls.Add(Me.lblOpenState)
            Me.TabPageLock.Controls.Add(Me.chkbNotBlastable)
            Dim tabPageLock As Global.System.Windows.Forms.Control = Me.TabPageLock
            point = New Global.System.Drawing.Point(4, 22)
            tabPageLock.Location = point
            Me.TabPageLock.Name = "TabPageLock"
            Dim tabPageLock2 As Global.System.Windows.Forms.Control = Me.TabPageLock
            size = New Global.System.Drawing.Size(448, 414)
            tabPageLock2.Size = size
            Me.TabPageLock.TabIndex = 1
            Me.TabPageLock.Text = "Lock"
            Me.cmbxOpenState.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxOpenState.Items.AddRange(New Object() {"Closed", "Opened"})
            Dim cmbxOpenState As Global.System.Windows.Forms.Control = Me.cmbxOpenState
            point = New Global.System.Drawing.Point(176, 125)
            cmbxOpenState.Location = point
            Me.cmbxOpenState.Name = "cmbxOpenState"
            Dim cmbxOpenState2 As Global.System.Windows.Forms.Control = Me.cmbxOpenState
            size = New Global.System.Drawing.Size(121, 21)
            cmbxOpenState2.Size = size
            Me.cmbxOpenState.TabIndex = 3
            Me.tbKeyName.Enabled = False
            Dim tbKeyName As Global.System.Windows.Forms.Control = Me.tbKeyName
            point = New Global.System.Drawing.Point(176, 304)
            tbKeyName.Location = point
            Me.tbKeyName.Name = "tbKeyName"
            Dim tbKeyName2 As Global.System.Windows.Forms.Control = Me.tbKeyName
            size = New Global.System.Drawing.Size(200, 20)
            tbKeyName2.Size = size
            Me.tbKeyName.TabIndex = 8
            Me.tbKeyName.Text = ""
            Me.lblKeyTag.Enabled = False
            Dim lblKeyTag As Global.System.Windows.Forms.Control = Me.lblKeyTag
            point = New Global.System.Drawing.Point(52, 304)
            lblKeyTag.Location = point
            Me.lblKeyTag.Name = "lblKeyTag"
            Dim lblKeyTag2 As Global.System.Windows.Forms.Control = Me.lblKeyTag
            size = New Global.System.Drawing.Size(100, 16)
            lblKeyTag2.Size = size
            Me.lblKeyTag.TabIndex = 18
            Me.lblKeyTag.Text = "Key Tag"
            Me.lblKeyTag.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudCloseLockDC.Enabled = False
            Dim nudCloseLockDC As Global.System.Windows.Forms.Control = Me.nudCloseLockDC
            point = New Global.System.Drawing.Point(176, 208)
            nudCloseLockDC.Location = point
            Dim nudCloseLockDC2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCloseLockDC
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudCloseLockDC2.Maximum = num
            Me.nudCloseLockDC.Name = "nudCloseLockDC"
            Me.nudCloseLockDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudCloseLockDC3 As Global.System.Windows.Forms.Control = Me.nudCloseLockDC
            size = New Global.System.Drawing.Size(48, 20)
            nudCloseLockDC3.Size = size
            Me.nudCloseLockDC.TabIndex = 5
            Me.nudCloseLockDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblCloseLockDC.Enabled = False
            Dim lblCloseLockDC As Global.System.Windows.Forms.Control = Me.lblCloseLockDC
            point = New Global.System.Drawing.Point(48, 208)
            lblCloseLockDC.Location = point
            Me.lblCloseLockDC.Name = "lblCloseLockDC"
            Dim lblCloseLockDC2 As Global.System.Windows.Forms.Control = Me.lblCloseLockDC
            size = New Global.System.Drawing.Size(88, 16)
            lblCloseLockDC2.Size = size
            Me.lblCloseLockDC.TabIndex = 14
            Me.lblCloseLockDC.Text = "Close Lock DC"
            Me.lblCloseLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudOpenLockDC.Enabled = False
            Dim nudOpenLockDC As Global.System.Windows.Forms.Control = Me.nudOpenLockDC
            point = New Global.System.Drawing.Point(176, 168)
            nudOpenLockDC.Location = point
            Dim nudOpenLockDC2 As Global.System.Windows.Forms.NumericUpDown = Me.nudOpenLockDC
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudOpenLockDC2.Maximum = num
            Me.nudOpenLockDC.Name = "nudOpenLockDC"
            Me.nudOpenLockDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudOpenLockDC3 As Global.System.Windows.Forms.Control = Me.nudOpenLockDC
            size = New Global.System.Drawing.Size(48, 20)
            nudOpenLockDC3.Size = size
            Me.nudOpenLockDC.TabIndex = 4
            Me.nudOpenLockDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblOpenLockDC.Enabled = False
            Dim lblOpenLockDC As Global.System.Windows.Forms.Control = Me.lblOpenLockDC
            point = New Global.System.Drawing.Point(48, 168)
            lblOpenLockDC.Location = point
            Me.lblOpenLockDC.Name = "lblOpenLockDC"
            Dim lblOpenLockDC2 As Global.System.Windows.Forms.Control = Me.lblOpenLockDC
            size = New Global.System.Drawing.Size(88, 16)
            lblOpenLockDC2.Size = size
            Me.lblOpenLockDC.TabIndex = 15
            Me.lblOpenLockDC.Text = "Open Lock DC"
            Me.lblOpenLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbLockable As Global.System.Windows.Forms.Control = Me.chkbLockable
            point = New Global.System.Drawing.Point(48, 56)
            chkbLockable.Location = point
            Me.chkbLockable.Name = "chkbLockable"
            Dim chkbLockable2 As Global.System.Windows.Forms.Control = Me.chkbLockable
            size = New Global.System.Drawing.Size(112, 24)
            chkbLockable2.Size = size
            Me.chkbLockable.TabIndex = 1
            Me.chkbLockable.Text = "Can be relocked"
            Dim chkbLocked As Global.System.Windows.Forms.Control = Me.chkbLocked
            point = New Global.System.Drawing.Point(48, 32)
            chkbLocked.Location = point
            Me.chkbLocked.Name = "chkbLocked"
            Dim chkbLocked2 As Global.System.Windows.Forms.Control = Me.chkbLocked
            size = New Global.System.Drawing.Size(72, 24)
            chkbLocked2.Size = size
            Me.chkbLocked.TabIndex = 0
            Me.chkbLocked.Text = "Locked"
            Me.chkbKeyRequired.Enabled = False
            Dim chkbKeyRequired As Global.System.Windows.Forms.Control = Me.chkbKeyRequired
            point = New Global.System.Drawing.Point(48, 264)
            chkbKeyRequired.Location = point
            Me.chkbKeyRequired.Name = "chkbKeyRequired"
            Dim chkbKeyRequired2 As Global.System.Windows.Forms.Control = Me.chkbKeyRequired
            size = New Global.System.Drawing.Size(184, 24)
            chkbKeyRequired2.Size = size
            Me.chkbKeyRequired.TabIndex = 7
            Me.chkbKeyRequired.Text = "Key required to unlock or lock"
            Me.chkbAutoRemoveKey.Enabled = False
            Dim chkbAutoRemoveKey As Global.System.Windows.Forms.Control = Me.chkbAutoRemoveKey
            point = New Global.System.Drawing.Point(48, 240)
            chkbAutoRemoveKey.Location = point
            Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
            Dim chkbAutoRemoveKey2 As Global.System.Windows.Forms.Control = Me.chkbAutoRemoveKey
            size = New Global.System.Drawing.Size(200, 24)
            chkbAutoRemoveKey2.Size = size
            Me.chkbAutoRemoveKey.TabIndex = 6
            Me.chkbAutoRemoveKey.Text = "Automatically remove key after use"
            Dim lblOpenState As Global.System.Windows.Forms.Control = Me.lblOpenState
            point = New Global.System.Drawing.Point(48, 128)
            lblOpenState.Location = point
            Me.lblOpenState.Name = "lblOpenState"
            Dim lblOpenState2 As Global.System.Windows.Forms.Control = Me.lblOpenState
            size = New Global.System.Drawing.Size(88, 16)
            lblOpenState2.Size = size
            Me.lblOpenState.TabIndex = 15
            Me.lblOpenState.Text = "Door State"
            Me.lblOpenState.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbNotBlastable.Enabled = False
            Dim chkbNotBlastable As Global.System.Windows.Forms.Control = Me.chkbNotBlastable
            point = New Global.System.Drawing.Point(48, 80)
            chkbNotBlastable.Location = point
            Me.chkbNotBlastable.Name = "chkbNotBlastable"
            Dim chkbNotBlastable2 As Global.System.Windows.Forms.Control = Me.chkbNotBlastable
            size = New Global.System.Drawing.Size(112, 24)
            chkbNotBlastable2.Size = size
            Me.chkbNotBlastable.TabIndex = 2
            Me.chkbNotBlastable.Text = "Not Blastable"
            Me.TabPageScripts.Controls.Add(Me.btnEditOnUserDefined)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnHeartbeat)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnSpellCastAt)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnDeath)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnDamaged)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnTrapTriggered)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnDisarm)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnClick)
            Me.TabPageScripts.Controls.Add(Me.Label34)
            Me.TabPageScripts.Controls.Add(Me.tbOnDeath)
            Me.TabPageScripts.Controls.Add(Me.Label33)
            Me.TabPageScripts.Controls.Add(Me.tbOnDamaged)
            Me.TabPageScripts.Controls.Add(Me.Label32)
            Me.TabPageScripts.Controls.Add(Me.tbOnClosed)
            Me.TabPageScripts.Controls.Add(Me.Label35)
            Me.TabPageScripts.Controls.Add(Me.tbOnDisarm)
            Me.TabPageScripts.Controls.Add(Me.tbOnHeartbeat)
            Me.TabPageScripts.Controls.Add(Me.Label36)
            Me.TabPageScripts.Controls.Add(Me.Label37)
            Me.TabPageScripts.Controls.Add(Me.tbOnLock)
            Me.TabPageScripts.Controls.Add(Me.tbOnMeleeAttacked)
            Me.TabPageScripts.Controls.Add(Me.Label38)
            Me.TabPageScripts.Controls.Add(Me.tbOnOpen)
            Me.TabPageScripts.Controls.Add(Me.Label39)
            Me.TabPageScripts.Controls.Add(Me.Label40)
            Me.TabPageScripts.Controls.Add(Me.tbOnSpellCastAt)
            Me.TabPageScripts.Controls.Add(Me.Label41)
            Me.TabPageScripts.Controls.Add(Me.tbOnTrapTriggered)
            Me.TabPageScripts.Controls.Add(Me.tbOnUnlock)
            Me.TabPageScripts.Controls.Add(Me.Label42)
            Me.TabPageScripts.Controls.Add(Me.tbOnUserDefined)
            Me.TabPageScripts.Controls.Add(Me.Label43)
            Me.TabPageScripts.Controls.Add(Me.tbOnClick)
            Me.TabPageScripts.Controls.Add(Me.Label9)
            Me.TabPageScripts.Controls.Add(Me.Label7)
            Me.TabPageScripts.Controls.Add(Me.tbOnFailToOpen)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnClosed)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnFailToOpen)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnLock)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnMeleeAttacked)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnOpen)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnUnlock)
            Dim tabPageScripts As Global.System.Windows.Forms.Control = Me.TabPageScripts
            point = New Global.System.Drawing.Point(4, 22)
            tabPageScripts.Location = point
            Me.TabPageScripts.Name = "TabPageScripts"
            Dim tabPageScripts2 As Global.System.Windows.Forms.Control = Me.TabPageScripts
            size = New Global.System.Drawing.Size(448, 414)
            tabPageScripts2.Size = size
            Me.TabPageScripts.TabIndex = 4
            Me.TabPageScripts.Text = "Scripts"
            Dim btnEditOnUserDefined As Global.System.Windows.Forms.Control = Me.btnEditOnUserDefined
            point = New Global.System.Drawing.Point(392, 372)
            btnEditOnUserDefined.Location = point
            Me.btnEditOnUserDefined.Name = "btnEditOnUserDefined"
            Dim btnEditOnUserDefined2 As Global.System.Windows.Forms.Control = Me.btnEditOnUserDefined
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnUserDefined2.Size = size
            Me.btnEditOnUserDefined.TabIndex = 36
            Me.btnEditOnUserDefined.Text = "Edit"
            Me.btnEditOnUserDefined.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnHeartbeat As Global.System.Windows.Forms.Control = Me.btnEditOnHeartbeat
            point = New Global.System.Drawing.Point(392, 176)
            btnEditOnHeartbeat.Location = point
            Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
            Dim btnEditOnHeartbeat2 As Global.System.Windows.Forms.Control = Me.btnEditOnHeartbeat
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnHeartbeat2.Size = size
            Me.btnEditOnHeartbeat.TabIndex = 35
            Me.btnEditOnHeartbeat.Text = "Edit"
            Me.btnEditOnHeartbeat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnSpellCastAt As Global.System.Windows.Forms.Control = Me.btnEditOnSpellCastAt
            point = New Global.System.Drawing.Point(392, 288)
            btnEditOnSpellCastAt.Location = point
            Me.btnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt"
            Dim btnEditOnSpellCastAt2 As Global.System.Windows.Forms.Control = Me.btnEditOnSpellCastAt
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnSpellCastAt2.Size = size
            Me.btnEditOnSpellCastAt.TabIndex = 34
            Me.btnEditOnSpellCastAt.Text = "Edit"
            Me.btnEditOnSpellCastAt.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnDeath As Global.System.Windows.Forms.Control = Me.btnEditOnDeath
            point = New Global.System.Drawing.Point(392, 92)
            btnEditOnDeath.Location = point
            Me.btnEditOnDeath.Name = "btnEditOnDeath"
            Dim btnEditOnDeath2 As Global.System.Windows.Forms.Control = Me.btnEditOnDeath
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnDeath2.Size = size
            Me.btnEditOnDeath.TabIndex = 33
            Me.btnEditOnDeath.Text = "Edit"
            Me.btnEditOnDeath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnDamaged As Global.System.Windows.Forms.Control = Me.btnEditOnDamaged
            point = New Global.System.Drawing.Point(392, 64)
            btnEditOnDamaged.Location = point
            Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
            Dim btnEditOnDamaged2 As Global.System.Windows.Forms.Control = Me.btnEditOnDamaged
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnDamaged2.Size = size
            Me.btnEditOnDamaged.TabIndex = 32
            Me.btnEditOnDamaged.Text = "Edit"
            Me.btnEditOnDamaged.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnTrapTriggered As Global.System.Windows.Forms.Control = Me.btnEditOnTrapTriggered
            point = New Global.System.Drawing.Point(392, 316)
            btnEditOnTrapTriggered.Location = point
            Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
            Dim btnEditOnTrapTriggered2 As Global.System.Windows.Forms.Control = Me.btnEditOnTrapTriggered
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnTrapTriggered2.Size = size
            Me.btnEditOnTrapTriggered.TabIndex = 31
            Me.btnEditOnTrapTriggered.Text = "Edit"
            Me.btnEditOnTrapTriggered.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnDisarm As Global.System.Windows.Forms.Control = Me.btnEditOnDisarm
            point = New Global.System.Drawing.Point(392, 120)
            btnEditOnDisarm.Location = point
            Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
            Dim btnEditOnDisarm2 As Global.System.Windows.Forms.Control = Me.btnEditOnDisarm
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnDisarm2.Size = size
            Me.btnEditOnDisarm.TabIndex = 30
            Me.btnEditOnDisarm.Text = "Edit"
            Me.btnEditOnDisarm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnClick As Global.System.Windows.Forms.Control = Me.btnEditOnClick
            point = New Global.System.Drawing.Point(392, 8)
            btnEditOnClick.Location = point
            Me.btnEditOnClick.Name = "btnEditOnClick"
            Dim btnEditOnClick2 As Global.System.Windows.Forms.Control = Me.btnEditOnClick
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnClick2.Size = size
            Me.btnEditOnClick.TabIndex = 29
            Me.btnEditOnClick.Text = "Edit"
            Me.btnEditOnClick.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label34
            point = New Global.System.Drawing.Point(40, 92)
            label13.Location = point
            Me.Label34.Name = "Label34"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label34
            size = New Global.System.Drawing.Size(112, 18)
            label14.Size = size
            Me.Label34.TabIndex = 27
            Me.Label34.Text = "OnDeath"
            Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnDeath As Global.System.Windows.Forms.Control = Me.tbOnDeath
            point = New Global.System.Drawing.Point(160, 92)
            tbOnDeath.Location = point
            Me.tbOnDeath.Name = "tbOnDeath"
            Dim tbOnDeath2 As Global.System.Windows.Forms.Control = Me.tbOnDeath
            size = New Global.System.Drawing.Size(204, 20)
            tbOnDeath2.Size = size
            Me.tbOnDeath.TabIndex = 3
            Me.tbOnDeath.Text = ""
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label33
            point = New Global.System.Drawing.Point(40, 64)
            label15.Location = point
            Me.Label33.Name = "Label33"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label33
            size = New Global.System.Drawing.Size(112, 18)
            label16.Size = size
            Me.Label33.TabIndex = 17
            Me.Label33.Text = "OnDamaged"
            Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnDamaged As Global.System.Windows.Forms.Control = Me.tbOnDamaged
            point = New Global.System.Drawing.Point(160, 64)
            tbOnDamaged.Location = point
            Me.tbOnDamaged.Name = "tbOnDamaged"
            Dim tbOnDamaged2 As Global.System.Windows.Forms.Control = Me.tbOnDamaged
            size = New Global.System.Drawing.Size(204, 20)
            tbOnDamaged2.Size = size
            Me.tbOnDamaged.TabIndex = 2
            Me.tbOnDamaged.Text = ""
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label32
            point = New Global.System.Drawing.Point(40, 36)
            label17.Location = point
            Me.Label32.Name = "Label32"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label32
            size = New Global.System.Drawing.Size(112, 18)
            label18.Size = size
            Me.Label32.TabIndex = 14
            Me.Label32.Text = "OnClosed"
            Me.Label32.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnClosed As Global.System.Windows.Forms.Control = Me.tbOnClosed
            point = New Global.System.Drawing.Point(160, 36)
            tbOnClosed.Location = point
            Me.tbOnClosed.Name = "tbOnClosed"
            Dim tbOnClosed2 As Global.System.Windows.Forms.Control = Me.tbOnClosed
            size = New Global.System.Drawing.Size(204, 20)
            tbOnClosed2.Size = size
            Me.tbOnClosed.TabIndex = 1
            Me.tbOnClosed.Text = ""
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label35
            point = New Global.System.Drawing.Point(40, 120)
            label19.Location = point
            Me.Label35.Name = "Label35"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label35
            size = New Global.System.Drawing.Size(112, 18)
            label20.Size = size
            Me.Label35.TabIndex = 26
            Me.Label35.Text = "OnDisarm"
            Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnDisarm As Global.System.Windows.Forms.Control = Me.tbOnDisarm
            point = New Global.System.Drawing.Point(160, 120)
            tbOnDisarm.Location = point
            Me.tbOnDisarm.Name = "tbOnDisarm"
            Dim tbOnDisarm2 As Global.System.Windows.Forms.Control = Me.tbOnDisarm
            size = New Global.System.Drawing.Size(204, 20)
            tbOnDisarm2.Size = size
            Me.tbOnDisarm.TabIndex = 4
            Me.tbOnDisarm.Text = ""
            Dim tbOnHeartbeat As Global.System.Windows.Forms.Control = Me.tbOnHeartbeat
            point = New Global.System.Drawing.Point(160, 176)
            tbOnHeartbeat.Location = point
            Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
            Dim tbOnHeartbeat2 As Global.System.Windows.Forms.Control = Me.tbOnHeartbeat
            size = New Global.System.Drawing.Size(204, 20)
            tbOnHeartbeat2.Size = size
            Me.tbOnHeartbeat.TabIndex = 6
            Me.tbOnHeartbeat.Text = ""
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label36
            point = New Global.System.Drawing.Point(40, 176)
            label21.Location = point
            Me.Label36.Name = "Label36"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label36
            size = New Global.System.Drawing.Size(112, 18)
            label22.Size = size
            Me.Label36.TabIndex = 25
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label37
            point = New Global.System.Drawing.Point(40, 204)
            label23.Location = point
            Me.Label37.Name = "Label37"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label37
            size = New Global.System.Drawing.Size(112, 18)
            label24.Size = size
            Me.Label37.TabIndex = 28
            Me.Label37.Text = "OnLock"
            Me.Label37.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnLock As Global.System.Windows.Forms.Control = Me.tbOnLock
            point = New Global.System.Drawing.Point(160, 204)
            tbOnLock.Location = point
            Me.tbOnLock.Name = "tbOnLock"
            Dim tbOnLock2 As Global.System.Windows.Forms.Control = Me.tbOnLock
            size = New Global.System.Drawing.Size(204, 20)
            tbOnLock2.Size = size
            Me.tbOnLock.TabIndex = 7
            Me.tbOnLock.Text = ""
            Dim tbOnMeleeAttacked As Global.System.Windows.Forms.Control = Me.tbOnMeleeAttacked
            point = New Global.System.Drawing.Point(160, 232)
            tbOnMeleeAttacked.Location = point
            Me.tbOnMeleeAttacked.Name = "tbOnMeleeAttacked"
            Dim tbOnMeleeAttacked2 As Global.System.Windows.Forms.Control = Me.tbOnMeleeAttacked
            size = New Global.System.Drawing.Size(204, 20)
            tbOnMeleeAttacked2.Size = size
            Me.tbOnMeleeAttacked.TabIndex = 8
            Me.tbOnMeleeAttacked.Text = ""
            Dim label25 As Global.System.Windows.Forms.Control = Me.Label38
            point = New Global.System.Drawing.Point(40, 232)
            label25.Location = point
            Me.Label38.Name = "Label38"
            Dim label26 As Global.System.Windows.Forms.Control = Me.Label38
            size = New Global.System.Drawing.Size(112, 18)
            label26.Size = size
            Me.Label38.TabIndex = 20
            Me.Label38.Text = "OnMeleeAttacked"
            Me.Label38.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnOpen As Global.System.Windows.Forms.Control = Me.tbOnOpen
            point = New Global.System.Drawing.Point(160, 260)
            tbOnOpen.Location = point
            Me.tbOnOpen.Name = "tbOnOpen"
            Dim tbOnOpen2 As Global.System.Windows.Forms.Control = Me.tbOnOpen
            size = New Global.System.Drawing.Size(204, 20)
            tbOnOpen2.Size = size
            Me.tbOnOpen.TabIndex = 9
            Me.tbOnOpen.Text = ""
            Dim label27 As Global.System.Windows.Forms.Control = Me.Label39
            point = New Global.System.Drawing.Point(40, 260)
            label27.Location = point
            Me.Label39.Name = "Label39"
            Dim label28 As Global.System.Windows.Forms.Control = Me.Label39
            size = New Global.System.Drawing.Size(112, 18)
            label28.Size = size
            Me.Label39.TabIndex = 21
            Me.Label39.Text = "OnOpen"
            Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label29 As Global.System.Windows.Forms.Control = Me.Label40
            point = New Global.System.Drawing.Point(40, 288)
            label29.Location = point
            Me.Label40.Name = "Label40"
            Dim label30 As Global.System.Windows.Forms.Control = Me.Label40
            size = New Global.System.Drawing.Size(112, 18)
            label30.Size = size
            Me.Label40.TabIndex = 19
            Me.Label40.Text = "OnSpellCastAt"
            Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnSpellCastAt As Global.System.Windows.Forms.Control = Me.tbOnSpellCastAt
            point = New Global.System.Drawing.Point(160, 288)
            tbOnSpellCastAt.Location = point
            Me.tbOnSpellCastAt.Name = "tbOnSpellCastAt"
            Dim tbOnSpellCastAt2 As Global.System.Windows.Forms.Control = Me.tbOnSpellCastAt
            size = New Global.System.Drawing.Size(204, 20)
            tbOnSpellCastAt2.Size = size
            Me.tbOnSpellCastAt.TabIndex = 10
            Me.tbOnSpellCastAt.Text = ""
            Dim label31 As Global.System.Windows.Forms.Control = Me.Label41
            point = New Global.System.Drawing.Point(40, 316)
            label31.Location = point
            Me.Label41.Name = "Label41"
            Dim label32 As Global.System.Windows.Forms.Control = Me.Label41
            size = New Global.System.Drawing.Size(112, 18)
            label32.Size = size
            Me.Label41.TabIndex = 24
            Me.Label41.Text = "OnTrapTriggered"
            Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnTrapTriggered As Global.System.Windows.Forms.Control = Me.tbOnTrapTriggered
            point = New Global.System.Drawing.Point(160, 316)
            tbOnTrapTriggered.Location = point
            Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
            Dim tbOnTrapTriggered2 As Global.System.Windows.Forms.Control = Me.tbOnTrapTriggered
            size = New Global.System.Drawing.Size(204, 20)
            tbOnTrapTriggered2.Size = size
            Me.tbOnTrapTriggered.TabIndex = 11
            Me.tbOnTrapTriggered.Text = ""
            Dim tbOnUnlock As Global.System.Windows.Forms.Control = Me.tbOnUnlock
            point = New Global.System.Drawing.Point(160, 344)
            tbOnUnlock.Location = point
            Me.tbOnUnlock.Name = "tbOnUnlock"
            Dim tbOnUnlock2 As Global.System.Windows.Forms.Control = Me.tbOnUnlock
            size = New Global.System.Drawing.Size(204, 20)
            tbOnUnlock2.Size = size
            Me.tbOnUnlock.TabIndex = 12
            Me.tbOnUnlock.Text = ""
            Dim label33 As Global.System.Windows.Forms.Control = Me.Label42
            point = New Global.System.Drawing.Point(40, 344)
            label33.Location = point
            Me.Label42.Name = "Label42"
            Dim label34 As Global.System.Windows.Forms.Control = Me.Label42
            size = New Global.System.Drawing.Size(112, 18)
            label34.Size = size
            Me.Label42.TabIndex = 23
            Me.Label42.Text = "OnUnlock"
            Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnUserDefined As Global.System.Windows.Forms.Control = Me.tbOnUserDefined
            point = New Global.System.Drawing.Point(160, 372)
            tbOnUserDefined.Location = point
            Me.tbOnUserDefined.Name = "tbOnUserDefined"
            Dim tbOnUserDefined2 As Global.System.Windows.Forms.Control = Me.tbOnUserDefined
            size = New Global.System.Drawing.Size(204, 20)
            tbOnUserDefined2.Size = size
            Me.tbOnUserDefined.TabIndex = 13
            Me.tbOnUserDefined.Text = ""
            Dim label35 As Global.System.Windows.Forms.Control = Me.Label43
            point = New Global.System.Drawing.Point(40, 372)
            label35.Location = point
            Me.Label43.Name = "Label43"
            Dim label36 As Global.System.Windows.Forms.Control = Me.Label43
            size = New Global.System.Drawing.Size(112, 18)
            label36.Size = size
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUserDefined"
            Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnClick As Global.System.Windows.Forms.Control = Me.tbOnClick
            point = New Global.System.Drawing.Point(160, 8)
            tbOnClick.Location = point
            Me.tbOnClick.Name = "tbOnClick"
            Dim tbOnClick2 As Global.System.Windows.Forms.Control = Me.tbOnClick
            size = New Global.System.Drawing.Size(204, 20)
            tbOnClick2.Size = size
            Me.tbOnClick.TabIndex = 0
            Me.tbOnClick.Text = ""
            Dim label37 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(40, 8)
            label37.Location = point
            Me.Label9.Name = "Label9"
            Dim label38 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(112, 18)
            label38.Size = size
            Me.Label9.TabIndex = 23
            Me.Label9.Text = "OnClick"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label39 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(40, 148)
            label39.Location = point
            Me.Label7.Name = "Label7"
            Dim label40 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(112, 18)
            label40.Size = size
            Me.Label7.TabIndex = 22
            Me.Label7.Text = "OnFailToOpen"
            Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnFailToOpen As Global.System.Windows.Forms.Control = Me.tbOnFailToOpen
            point = New Global.System.Drawing.Point(160, 148)
            tbOnFailToOpen.Location = point
            Me.tbOnFailToOpen.Name = "tbOnFailToOpen"
            Dim tbOnFailToOpen2 As Global.System.Windows.Forms.Control = Me.tbOnFailToOpen
            size = New Global.System.Drawing.Size(204, 20)
            tbOnFailToOpen2.Size = size
            Me.tbOnFailToOpen.TabIndex = 5
            Me.tbOnFailToOpen.Text = ""
            Dim btnEditOnClosed As Global.System.Windows.Forms.Control = Me.btnEditOnClosed
            point = New Global.System.Drawing.Point(392, 36)
            btnEditOnClosed.Location = point
            Me.btnEditOnClosed.Name = "btnEditOnClosed"
            Dim btnEditOnClosed2 As Global.System.Windows.Forms.Control = Me.btnEditOnClosed
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnClosed2.Size = size
            Me.btnEditOnClosed.TabIndex = 29
            Me.btnEditOnClosed.Text = "Edit"
            Me.btnEditOnClosed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnFailToOpen As Global.System.Windows.Forms.Control = Me.btnEditOnFailToOpen
            point = New Global.System.Drawing.Point(392, 148)
            btnEditOnFailToOpen.Location = point
            Me.btnEditOnFailToOpen.Name = "btnEditOnFailToOpen"
            Dim btnEditOnFailToOpen2 As Global.System.Windows.Forms.Control = Me.btnEditOnFailToOpen
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnFailToOpen2.Size = size
            Me.btnEditOnFailToOpen.TabIndex = 30
            Me.btnEditOnFailToOpen.Text = "Edit"
            Me.btnEditOnFailToOpen.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnLock As Global.System.Windows.Forms.Control = Me.btnEditOnLock
            point = New Global.System.Drawing.Point(392, 204)
            btnEditOnLock.Location = point
            Me.btnEditOnLock.Name = "btnEditOnLock"
            Dim btnEditOnLock2 As Global.System.Windows.Forms.Control = Me.btnEditOnLock
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnLock2.Size = size
            Me.btnEditOnLock.TabIndex = 35
            Me.btnEditOnLock.Text = "Edit"
            Me.btnEditOnLock.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnMeleeAttacked As Global.System.Windows.Forms.Control = Me.btnEditOnMeleeAttacked
            point = New Global.System.Drawing.Point(392, 232)
            btnEditOnMeleeAttacked.Location = point
            Me.btnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked"
            Dim btnEditOnMeleeAttacked2 As Global.System.Windows.Forms.Control = Me.btnEditOnMeleeAttacked
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnMeleeAttacked2.Size = size
            Me.btnEditOnMeleeAttacked.TabIndex = 35
            Me.btnEditOnMeleeAttacked.Text = "Edit"
            Me.btnEditOnMeleeAttacked.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnOpen As Global.System.Windows.Forms.Control = Me.btnEditOnOpen
            point = New Global.System.Drawing.Point(392, 260)
            btnEditOnOpen.Location = point
            Me.btnEditOnOpen.Name = "btnEditOnOpen"
            Dim btnEditOnOpen2 As Global.System.Windows.Forms.Control = Me.btnEditOnOpen
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnOpen2.Size = size
            Me.btnEditOnOpen.TabIndex = 35
            Me.btnEditOnOpen.Text = "Edit"
            Me.btnEditOnOpen.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnUnlock As Global.System.Windows.Forms.Control = Me.btnEditOnUnlock
            point = New Global.System.Drawing.Point(392, 344)
            btnEditOnUnlock.Location = point
            Me.btnEditOnUnlock.Name = "btnEditOnUnlock"
            Dim btnEditOnUnlock2 As Global.System.Windows.Forms.Control = Me.btnEditOnUnlock
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnUnlock2.Size = size
            Me.btnEditOnUnlock.TabIndex = 31
            Me.btnEditOnUnlock.Text = "Edit"
            Me.btnEditOnUnlock.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.TabPageAdvanced.Controls.Add(Me.cmbxFaction)
            Me.TabPageAdvanced.Controls.Add(Me.chkbNotInterruptable)
            Me.TabPageAdvanced.Controls.Add(Me.tbConversation)
            Me.TabPageAdvanced.Controls.Add(Me.tbTemplateResRef)
            Me.TabPageAdvanced.Controls.Add(Me.Label10)
            Me.TabPageAdvanced.Controls.Add(Me.Label11)
            Me.TabPageAdvanced.Controls.Add(Me.Label13)
            Me.TabPageAdvanced.Controls.Add(Me.Label14)
            Me.TabPageAdvanced.Controls.Add(Me.tbAnimationState)
            Dim tabPageAdvanced As Global.System.Windows.Forms.Control = Me.TabPageAdvanced
            point = New Global.System.Drawing.Point(4, 22)
            tabPageAdvanced.Location = point
            Me.TabPageAdvanced.Name = "TabPageAdvanced"
            Dim tabPageAdvanced2 As Global.System.Windows.Forms.Control = Me.TabPageAdvanced
            size = New Global.System.Drawing.Size(448, 414)
            tabPageAdvanced2.Size = size
            Me.TabPageAdvanced.TabIndex = 5
            Me.TabPageAdvanced.Text = "Advanced"
            Me.cmbxFaction.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxFaction As Global.System.Windows.Forms.Control = Me.cmbxFaction
            point = New Global.System.Drawing.Point(168, 80)
            cmbxFaction.Location = point
            Me.cmbxFaction.Name = "cmbxFaction"
            Dim cmbxFaction2 As Global.System.Windows.Forms.Control = Me.cmbxFaction
            size = New Global.System.Drawing.Size(120, 21)
            cmbxFaction2.Size = size
            Me.cmbxFaction.TabIndex = 4
            Dim chkbNotInterruptable As Global.System.Windows.Forms.Control = Me.chkbNotInterruptable
            point = New Global.System.Drawing.Point(352, 136)
            chkbNotInterruptable.Location = point
            Me.chkbNotInterruptable.Name = "chkbNotInterruptable"
            Dim chkbNotInterruptable2 As Global.System.Windows.Forms.Control = Me.chkbNotInterruptable
            size = New Global.System.Drawing.Size(84, 24)
            chkbNotInterruptable2.Size = size
            Me.chkbNotInterruptable.TabIndex = 2
            Me.chkbNotInterruptable.Text = "No Interrupt"
            Dim tbConversation As Global.System.Windows.Forms.Control = Me.tbConversation
            point = New Global.System.Drawing.Point(168, 136)
            tbConversation.Location = point
            Me.tbConversation.Name = "tbConversation"
            Dim tbConversation2 As Global.System.Windows.Forms.Control = Me.tbConversation
            size = New Global.System.Drawing.Size(168, 20)
            tbConversation2.Size = size
            Me.tbConversation.TabIndex = 1
            Me.tbConversation.Text = ""
            Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbTemplateResRef As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
            point = New Global.System.Drawing.Point(168, 32)
            tbTemplateResRef.Location = point
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Dim tbTemplateResRef2 As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
            size = New Global.System.Drawing.Size(200, 20)
            tbTemplateResRef2.Size = size
            Me.tbTemplateResRef.TabIndex = 3
            Me.tbTemplateResRef.Text = ""
            Dim label41 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(52, 32)
            label41.Location = point
            Me.Label10.Name = "Label10"
            Dim label42 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(100, 16)
            label42.Size = size
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Template ResRef"
            Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label43 As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(56, 80)
            label43.Location = point
            Me.Label11.Name = "Label11"
            Dim label44 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(100, 16)
            label44.Size = size
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Faction"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label45 As Global.System.Windows.Forms.Control = Me.Label13
            point = New Global.System.Drawing.Point(56, 136)
            label45.Location = point
            Me.Label13.Name = "Label13"
            Dim label46 As Global.System.Windows.Forms.Control = Me.Label13
            size = New Global.System.Drawing.Size(100, 16)
            label46.Size = size
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Conversation"
            Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label47 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(56, 184)
            label47.Location = point
            Me.Label14.Name = "Label14"
            Dim label48 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(100, 16)
            label48.Size = size
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Animation State"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbAnimationState As Global.System.Windows.Forms.Control = Me.tbAnimationState
            point = New Global.System.Drawing.Point(168, 184)
            tbAnimationState.Location = point
            Me.tbAnimationState.Name = "tbAnimationState"
            Dim tbAnimationState2 As Global.System.Windows.Forms.Control = Me.tbAnimationState
            size = New Global.System.Drawing.Size(32, 20)
            tbAnimationState2.Size = size
            Me.tbAnimationState.TabIndex = 3
            Me.tbAnimationState.Text = ""
            Me.TabPageDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.TabPageDescription.Controls.Add(Me.tbDescription)
            Dim tabPageDescription As Global.System.Windows.Forms.Control = Me.TabPageDescription
            point = New Global.System.Drawing.Point(4, 22)
            tabPageDescription.Location = point
            Me.TabPageDescription.Name = "TabPageDescription"
            Dim tabPageDescription2 As Global.System.Windows.Forms.Control = Me.TabPageDescription
            size = New Global.System.Drawing.Size(448, 414)
            tabPageDescription2.Size = size
            Me.TabPageDescription.TabIndex = 6
            Me.TabPageDescription.Text = "Description"
            Dim btnSetDescriptionLang As Global.System.Windows.Forms.Control = Me.btnSetDescriptionLang
            point = New Global.System.Drawing.Point(40, 320)
            btnSetDescriptionLang.Location = point
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Dim btnSetDescriptionLang2 As Global.System.Windows.Forms.Control = Me.btnSetDescriptionLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetDescriptionLang2.Size = size
            Me.btnSetDescriptionLang.TabIndex = 5
            Me.btnSetDescriptionLang.Text = "Set Language"
            Dim tbDescription As Global.System.Windows.Forms.Control = Me.tbDescription
            point = New Global.System.Drawing.Point(12, 7)
            tbDescription.Location = point
            Me.tbDescription.Multiline = True
            Me.tbDescription.Name = "tbDescription"
            Dim tbDescription2 As Global.System.Windows.Forms.Control = Me.tbDescription
            size = New Global.System.Drawing.Size(424, 305)
            tbDescription2.Size = size
            Me.tbDescription.TabIndex = 1
            Me.tbDescription.Text = ""
            Me.TabPageComments.Controls.Add(Me.tbComment)
            Dim tabPageComments As Global.System.Windows.Forms.Control = Me.TabPageComments
            point = New Global.System.Drawing.Point(4, 22)
            tabPageComments.Location = point
            Me.TabPageComments.Name = "TabPageComments"
            Dim tabPageComments2 As Global.System.Windows.Forms.Control = Me.TabPageComments
            size = New Global.System.Drawing.Size(448, 414)
            tabPageComments2.Size = size
            Me.TabPageComments.TabIndex = 7
            Me.TabPageComments.Text = "Comments"
            Dim tbComment As Global.System.Windows.Forms.Control = Me.tbComment
            point = New Global.System.Drawing.Point(12, 7)
            tbComment.Location = point
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Dim tbComment2 As Global.System.Windows.Forms.Control = Me.tbComment
            size = New Global.System.Drawing.Size(424, 336)
            tbComment2.Size = size
            Me.tbComment.TabIndex = 0
            Me.tbComment.Text = ""
            Me.btnDebug.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
            point = New Global.System.Drawing.Point(0, 64)
            btnDebug.Location = point
            Me.btnDebug.Name = "btnDebug"
            Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
            size = New Global.System.Drawing.Size(8, 8)
            btnDebug2.Size = size
            Me.btnDebug.TabIndex = 18
            Me.btnDebug.TabStop = False
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(496, 501)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmUTD_Editor"
            Me.Text = "Door Editor - KotOR "
            Me.TabControl1.ResumeLayout(False)
            Me.TabPageBasic.ResumeLayout(False)
            CType(Me.nudWill, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFort, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudHP, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudHardness, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRef, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPageLock.ResumeLayout(False)
            CType(Me.nudCloseLockDC, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudOpenLockDC, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPageScripts.ResumeLayout(False)
            Me.TabPageAdvanced.ResumeLayout(False)
            Me.TabPageDescription.ResumeLayout(False)
            Me.TabPageComments.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000959 RID: 2393
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
