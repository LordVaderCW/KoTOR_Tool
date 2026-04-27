Namespace kotor_tool
	' Token: 0x02000081 RID: 129
	Public Partial Class frmUTP_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06001440 RID: 5184 RVA: 0x002B8068 File Offset: 0x002B7068
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600152D RID: 5421 RVA: 0x002B9BB0 File Offset: 0x002B8BB0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPageBasic = New Global.System.Windows.Forms.TabPage()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.cmbxAppearance = New Global.System.Windows.Forms.ComboBox()
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
            Me.chkbMin1HP = New Global.System.Windows.Forms.CheckBox()
            Me.TabPageLock = New Global.System.Windows.Forms.TabPage()
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
            Me.TabPageAdvanced = New Global.System.Windows.Forms.TabPage()
            Me.chkbPartyInteract = New Global.System.Windows.Forms.CheckBox()
            Me.chkbHasInventory = New Global.System.Windows.Forms.CheckBox()
            Me.Label20 = New Global.System.Windows.Forms.Label()
            Me.tbType = New Global.System.Windows.Forms.TextBox()
            Me.chkbInterruptable = New Global.System.Windows.Forms.CheckBox()
            Me.tbConversation = New Global.System.Windows.Forms.TextBox()
            Me.tbFaction = New Global.System.Windows.Forms.TextBox()
            Me.tbTemplateResRef = New Global.System.Windows.Forms.TextBox()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.Label13 = New Global.System.Windows.Forms.Label()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.tbAnimationState = New Global.System.Windows.Forms.TextBox()
            Me.chkbUsable = New Global.System.Windows.Forms.CheckBox()
            Me.TabPageScripts = New Global.System.Windows.Forms.TabPage()
            Me.tbOnUsed = New Global.System.Windows.Forms.TextBox()
            Me.Label18 = New Global.System.Windows.Forms.Label()
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
            Me.Label21 = New Global.System.Windows.Forms.Label()
            Me.tbOnEndDialogue = New Global.System.Windows.Forms.TextBox()
            Me.tbOnInvDisturbed = New Global.System.Windows.Forms.TextBox()
            Me.Label22 = New Global.System.Windows.Forms.Label()
            Me.TabPageDescription = New Global.System.Windows.Forms.TabPage()
            Me.btnSetDescriptionLang = New Global.System.Windows.Forms.Button()
            Me.tbDescription = New Global.System.Windows.Forms.TextBox()
            Me.TabPageComments = New Global.System.Windows.Forms.TabPage()
            Me.tbComment = New Global.System.Windows.Forms.TextBox()
            Me.TabPageTrap = New Global.System.Windows.Forms.TabPage()
            Me.chkbTrapDisarmable = New Global.System.Windows.Forms.CheckBox()
            Me.chkbTrapDetectable = New Global.System.Windows.Forms.CheckBox()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.nudDisarmDC = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.nudTrapDetectDC = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label16 = New Global.System.Windows.Forms.Label()
            Me.lblTrapDetectable = New Global.System.Windows.Forms.Label()
            Me.nudTrapType = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label17 = New Global.System.Windows.Forms.Label()
            Me.chkbTrapFlag = New Global.System.Windows.Forms.CheckBox()
            Me.chkbTrapOneShot = New Global.System.Windows.Forms.CheckBox()
            Me.btnSave = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnInventory = New Global.System.Windows.Forms.Button()
            Me.btnDebug = New Global.System.Windows.Forms.Button()
            Me.btnEditOnClosed = New Global.System.Windows.Forms.Button()
            Me.btnEditOnDamaged = New Global.System.Windows.Forms.Button()
            Me.btnEditOnDeath = New Global.System.Windows.Forms.Button()
            Me.btnEditOnDisarm = New Global.System.Windows.Forms.Button()
            Me.btnEditOnHeartbeat = New Global.System.Windows.Forms.Button()
            Me.btnEditOnLock = New Global.System.Windows.Forms.Button()
            Me.btnEditOnMeleeAttacked = New Global.System.Windows.Forms.Button()
            Me.btnEditOnOpen = New Global.System.Windows.Forms.Button()
            Me.btnEditOnSpellCastAt = New Global.System.Windows.Forms.Button()
            Me.btnEditOnTrapTriggered = New Global.System.Windows.Forms.Button()
            Me.btnEditOnUserDefined = New Global.System.Windows.Forms.Button()
            Me.btnEditOnUnlock = New Global.System.Windows.Forms.Button()
            Me.btnEditOnUsed = New Global.System.Windows.Forms.Button()
            Me.btnEditOnInvDisturbed = New Global.System.Windows.Forms.Button()
            Me.btnEditOnEndDialogue = New Global.System.Windows.Forms.Button()
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
            Me.TabPageAdvanced.SuspendLayout()
            Me.TabPageScripts.SuspendLayout()
            Me.TabPageDescription.SuspendLayout()
            Me.TabPageComments.SuspendLayout()
            Me.TabPageTrap.SuspendLayout()
            CType(Me.nudDisarmDC, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTrapDetectDC, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTrapType, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.TabPageBasic)
            Me.TabControl1.Controls.Add(Me.TabPageLock)
            Me.TabControl1.Controls.Add(Me.TabPageAdvanced)
            Me.TabControl1.Controls.Add(Me.TabPageScripts)
            Me.TabControl1.Controls.Add(Me.TabPageDescription)
            Me.TabControl1.Controls.Add(Me.TabPageComments)
            Me.TabControl1.Controls.Add(Me.TabPageTrap)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(19, 11)
            tabControl.Location = point
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Dim tabControl2 As Global.System.Windows.Forms.TabControl = Me.TabControl1
            point = New Global.System.Drawing.Point(15, 3)
            tabControl2.Padding = point
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl3 As Global.System.Windows.Forms.Control = Me.TabControl1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(456, 461)
            tabControl3.Size = size
            Me.TabControl1.SizeMode = Global.System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabIndex = 0
            Me.TabPageBasic.Controls.Add(Me.Label19)
            Me.TabPageBasic.Controls.Add(Me.cmbxAppearance)
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
            Me.TabPageBasic.Controls.Add(Me.chkbMin1HP)
            Dim tabPageBasic As Global.System.Windows.Forms.Control = Me.TabPageBasic
            point = New Global.System.Drawing.Point(4, 40)
            tabPageBasic.Location = point
            Me.TabPageBasic.Name = "TabPageBasic"
            Dim tabPageBasic2 As Global.System.Windows.Forms.Control = Me.TabPageBasic
            size = New Global.System.Drawing.Size(448, 393)
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
            Me.Label19.TabIndex = 10
            Me.Label19.Text = "Appearance"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxAppearance.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Dim cmbxAppearance As Global.System.Windows.Forms.Control = Me.cmbxAppearance
            point = New Global.System.Drawing.Point(128, 80)
            cmbxAppearance.Location = point
            Me.cmbxAppearance.Name = "cmbxAppearance"
            Dim cmbxAppearance2 As Global.System.Windows.Forms.Control = Me.cmbxAppearance
            size = New Global.System.Drawing.Size(184, 21)
            cmbxAppearance2.Size = size
            Me.cmbxAppearance.TabIndex = 3
            Dim btnSetNameLang As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            point = New Global.System.Drawing.Point(344, 32)
            btnSetNameLang.Location = point
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Dim btnSetNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetNameLang2.Size = size
            Me.btnSetNameLang.TabIndex = 1
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
            Me.nudWill.TabIndex = 11
            Me.nudWill.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudFort As Global.System.Windows.Forms.Control = Me.nudFort
            point = New Global.System.Drawing.Point(192, 200)
            nudFort.Location = point
            Me.nudFort.Name = "nudFort"
            Me.nudFort.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudFort2 As Global.System.Windows.Forms.Control = Me.nudFort
            size = New Global.System.Drawing.Size(48, 20)
            nudFort2.Size = size
            Me.nudFort.TabIndex = 9
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
            Me.nudHP.TabIndex = 8
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
            Me.nudHardness.TabIndex = 7
            Me.nudHardness.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudRef As Global.System.Windows.Forms.Control = Me.nudRef
            point = New Global.System.Drawing.Point(192, 224)
            nudRef.Location = point
            Me.nudRef.Name = "nudRef"
            Me.nudRef.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudRef2 As Global.System.Windows.Forms.Control = Me.nudRef
            size = New Global.System.Drawing.Size(48, 20)
            nudRef2.Size = size
            Me.nudRef.TabIndex = 10
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
            Me.chkbPlotItem.TabIndex = 4
            Me.chkbPlotItem.Text = "Plot item"
            Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
            point = New Global.System.Drawing.Point(128, 56)
            tbTag.Location = point
            Me.tbTag.Name = "tbTag"
            Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
            size = New Global.System.Drawing.Size(200, 20)
            tbTag2.Size = size
            Me.tbTag.TabIndex = 2
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
            Me.chkbStatic.TabIndex = 5
            Me.chkbStatic.Text = "Static"
            Dim chkbMin1HP As Global.System.Windows.Forms.Control = Me.chkbMin1HP
            point = New Global.System.Drawing.Point(296, 112)
            chkbMin1HP.Location = point
            Me.chkbMin1HP.Name = "chkbMin1HP"
            Dim chkbMin1HP2 As Global.System.Windows.Forms.Control = Me.chkbMin1HP
            size = New Global.System.Drawing.Size(72, 24)
            chkbMin1HP2.Size = size
            Me.chkbMin1HP.TabIndex = 6
            Me.chkbMin1HP.Text = "Min1HP"
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
            Dim tabPageLock As Global.System.Windows.Forms.Control = Me.TabPageLock
            point = New Global.System.Drawing.Point(4, 40)
            tabPageLock.Location = point
            Me.TabPageLock.Name = "TabPageLock"
            Dim tabPageLock2 As Global.System.Windows.Forms.Control = Me.TabPageLock
            size = New Global.System.Drawing.Size(448, 393)
            tabPageLock2.Size = size
            Me.TabPageLock.TabIndex = 1
            Me.TabPageLock.Text = "Lock"
            Me.TabPageLock.Visible = False
            Me.tbKeyName.Enabled = False
            Dim tbKeyName As Global.System.Windows.Forms.Control = Me.tbKeyName
            point = New Global.System.Drawing.Point(176, 256)
            tbKeyName.Location = point
            Me.tbKeyName.Name = "tbKeyName"
            Dim tbKeyName2 As Global.System.Windows.Forms.Control = Me.tbKeyName
            size = New Global.System.Drawing.Size(200, 20)
            tbKeyName2.Size = size
            Me.tbKeyName.TabIndex = 6
            Me.tbKeyName.Text = ""
            Me.lblKeyTag.Enabled = False
            Dim lblKeyTag As Global.System.Windows.Forms.Control = Me.lblKeyTag
            point = New Global.System.Drawing.Point(52, 256)
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
            point = New Global.System.Drawing.Point(176, 216)
            nudCloseLockDC.Location = point
            Me.nudCloseLockDC.Name = "nudCloseLockDC"
            Me.nudCloseLockDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudCloseLockDC2 As Global.System.Windows.Forms.Control = Me.nudCloseLockDC
            size = New Global.System.Drawing.Size(48, 20)
            nudCloseLockDC2.Size = size
            Me.nudCloseLockDC.TabIndex = 5
            Me.nudCloseLockDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblCloseLockDC.Enabled = False
            Dim lblCloseLockDC As Global.System.Windows.Forms.Control = Me.lblCloseLockDC
            point = New Global.System.Drawing.Point(48, 216)
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
            point = New Global.System.Drawing.Point(176, 176)
            nudOpenLockDC.Location = point
            Me.nudOpenLockDC.Name = "nudOpenLockDC"
            Me.nudOpenLockDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudOpenLockDC2 As Global.System.Windows.Forms.Control = Me.nudOpenLockDC
            size = New Global.System.Drawing.Size(48, 20)
            nudOpenLockDC2.Size = size
            Me.nudOpenLockDC.TabIndex = 4
            Me.nudOpenLockDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblOpenLockDC.Enabled = False
            Dim lblOpenLockDC As Global.System.Windows.Forms.Control = Me.lblOpenLockDC
            point = New Global.System.Drawing.Point(48, 176)
            lblOpenLockDC.Location = point
            Me.lblOpenLockDC.Name = "lblOpenLockDC"
            Dim lblOpenLockDC2 As Global.System.Windows.Forms.Control = Me.lblOpenLockDC
            size = New Global.System.Drawing.Size(88, 16)
            lblOpenLockDC2.Size = size
            Me.lblOpenLockDC.TabIndex = 15
            Me.lblOpenLockDC.Text = "Open Lock DC"
            Me.lblOpenLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbLockable As Global.System.Windows.Forms.Control = Me.chkbLockable
            point = New Global.System.Drawing.Point(48, 66)
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
            point = New Global.System.Drawing.Point(48, 134)
            chkbKeyRequired.Location = point
            Me.chkbKeyRequired.Name = "chkbKeyRequired"
            Dim chkbKeyRequired2 As Global.System.Windows.Forms.Control = Me.chkbKeyRequired
            size = New Global.System.Drawing.Size(184, 24)
            chkbKeyRequired2.Size = size
            Me.chkbKeyRequired.TabIndex = 3
            Me.chkbKeyRequired.Text = "Key required to unlock or lock"
            Me.chkbAutoRemoveKey.Enabled = False
            Dim chkbAutoRemoveKey As Global.System.Windows.Forms.Control = Me.chkbAutoRemoveKey
            point = New Global.System.Drawing.Point(48, 100)
            chkbAutoRemoveKey.Location = point
            Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
            Dim chkbAutoRemoveKey2 As Global.System.Windows.Forms.Control = Me.chkbAutoRemoveKey
            size = New Global.System.Drawing.Size(200, 24)
            chkbAutoRemoveKey2.Size = size
            Me.chkbAutoRemoveKey.TabIndex = 2
            Me.chkbAutoRemoveKey.Text = "Automatically remove key after use"
            Me.TabPageAdvanced.Controls.Add(Me.chkbPartyInteract)
            Me.TabPageAdvanced.Controls.Add(Me.chkbHasInventory)
            Me.TabPageAdvanced.Controls.Add(Me.Label20)
            Me.TabPageAdvanced.Controls.Add(Me.tbType)
            Me.TabPageAdvanced.Controls.Add(Me.chkbInterruptable)
            Me.TabPageAdvanced.Controls.Add(Me.tbConversation)
            Me.TabPageAdvanced.Controls.Add(Me.tbFaction)
            Me.TabPageAdvanced.Controls.Add(Me.tbTemplateResRef)
            Me.TabPageAdvanced.Controls.Add(Me.Label10)
            Me.TabPageAdvanced.Controls.Add(Me.Label11)
            Me.TabPageAdvanced.Controls.Add(Me.Label13)
            Me.TabPageAdvanced.Controls.Add(Me.Label14)
            Me.TabPageAdvanced.Controls.Add(Me.tbAnimationState)
            Me.TabPageAdvanced.Controls.Add(Me.chkbUsable)
            Dim tabPageAdvanced As Global.System.Windows.Forms.Control = Me.TabPageAdvanced
            point = New Global.System.Drawing.Point(4, 40)
            tabPageAdvanced.Location = point
            Me.TabPageAdvanced.Name = "TabPageAdvanced"
            Dim tabPageAdvanced2 As Global.System.Windows.Forms.Control = Me.TabPageAdvanced
            size = New Global.System.Drawing.Size(448, 393)
            tabPageAdvanced2.Size = size
            Me.TabPageAdvanced.TabIndex = 5
            Me.TabPageAdvanced.Text = "Advanced"
            Me.TabPageAdvanced.Visible = False
            Dim chkbPartyInteract As Global.System.Windows.Forms.Control = Me.chkbPartyInteract
            point = New Global.System.Drawing.Point(168, 240)
            chkbPartyInteract.Location = point
            Me.chkbPartyInteract.Name = "chkbPartyInteract"
            Dim chkbPartyInteract2 As Global.System.Windows.Forms.Control = Me.chkbPartyInteract
            size = New Global.System.Drawing.Size(184, 24)
            chkbPartyInteract2.Size = size
            Me.chkbPartyInteract.TabIndex = 6
            Me.chkbPartyInteract.Text = "Party Interact"
            Dim chkbHasInventory As Global.System.Windows.Forms.Control = Me.chkbHasInventory
            point = New Global.System.Drawing.Point(168, 208)
            chkbHasInventory.Location = point
            Me.chkbHasInventory.Name = "chkbHasInventory"
            Dim chkbHasInventory2 As Global.System.Windows.Forms.Control = Me.chkbHasInventory
            size = New Global.System.Drawing.Size(184, 24)
            chkbHasInventory2.Size = size
            Me.chkbHasInventory.TabIndex = 5
            Me.chkbHasInventory.Text = "Has Inventory"
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label20
            point = New Global.System.Drawing.Point(56, 176)
            label13.Location = point
            Me.Label20.Name = "Label20"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label20
            size = New Global.System.Drawing.Size(48, 16)
            label14.Size = size
            Me.Label20.TabIndex = 5
            Me.Label20.Text = "Type"
            Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbType As Global.System.Windows.Forms.Control = Me.tbType
            point = New Global.System.Drawing.Point(168, 176)
            tbType.Location = point
            Me.tbType.Name = "tbType"
            Dim tbType2 As Global.System.Windows.Forms.Control = Me.tbType
            size = New Global.System.Drawing.Size(72, 20)
            tbType2.Size = size
            Me.tbType.TabIndex = 4
            Me.tbType.Text = ""
            Dim chkbInterruptable As Global.System.Windows.Forms.Control = Me.chkbInterruptable
            point = New Global.System.Drawing.Point(352, 112)
            chkbInterruptable.Location = point
            Me.chkbInterruptable.Name = "chkbInterruptable"
            Dim chkbInterruptable2 As Global.System.Windows.Forms.Control = Me.chkbInterruptable
            size = New Global.System.Drawing.Size(88, 24)
            chkbInterruptable2.Size = size
            Me.chkbInterruptable.TabIndex = 2
            Me.chkbInterruptable.Text = "Interruptable"
            Dim tbConversation As Global.System.Windows.Forms.Control = Me.tbConversation
            point = New Global.System.Drawing.Point(168, 112)
            tbConversation.Location = point
            Me.tbConversation.Name = "tbConversation"
            Dim tbConversation2 As Global.System.Windows.Forms.Control = Me.tbConversation
            size = New Global.System.Drawing.Size(168, 20)
            tbConversation2.Size = size
            Me.tbConversation.TabIndex = 1
            Me.tbConversation.Text = ""
            Dim tbFaction As Global.System.Windows.Forms.Control = Me.tbFaction
            point = New Global.System.Drawing.Point(168, 80)
            tbFaction.Location = point
            Me.tbFaction.Name = "tbFaction"
            Dim tbFaction2 As Global.System.Windows.Forms.Control = Me.tbFaction
            size = New Global.System.Drawing.Size(30, 20)
            tbFaction2.Size = size
            Me.tbFaction.TabIndex = 0
            Me.tbFaction.Text = ""
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
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(52, 32)
            label15.Location = point
            Me.Label10.Name = "Label10"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(100, 16)
            label16.Size = size
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Template ResRef"
            Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(56, 80)
            label17.Location = point
            Me.Label11.Name = "Label11"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(100, 16)
            label18.Size = size
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Faction"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label13
            point = New Global.System.Drawing.Point(56, 112)
            label19.Location = point
            Me.Label13.Name = "Label13"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label13
            size = New Global.System.Drawing.Size(100, 16)
            label20.Size = size
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Conversation"
            Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(56, 144)
            label21.Location = point
            Me.Label14.Name = "Label14"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(100, 16)
            label22.Size = size
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Animation State"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbAnimationState As Global.System.Windows.Forms.Control = Me.tbAnimationState
            point = New Global.System.Drawing.Point(168, 144)
            tbAnimationState.Location = point
            Me.tbAnimationState.Name = "tbAnimationState"
            Dim tbAnimationState2 As Global.System.Windows.Forms.Control = Me.tbAnimationState
            size = New Global.System.Drawing.Size(32, 20)
            tbAnimationState2.Size = size
            Me.tbAnimationState.TabIndex = 3
            Me.tbAnimationState.Text = ""
            Dim chkbUsable As Global.System.Windows.Forms.Control = Me.chkbUsable
            point = New Global.System.Drawing.Point(168, 272)
            chkbUsable.Location = point
            Me.chkbUsable.Name = "chkbUsable"
            Dim chkbUsable2 As Global.System.Windows.Forms.Control = Me.chkbUsable
            size = New Global.System.Drawing.Size(184, 24)
            chkbUsable2.Size = size
            Me.chkbUsable.TabIndex = 6
            Me.chkbUsable.Text = "Usable"
            Me.TabPageScripts.Controls.Add(Me.btnEditOnUserDefined)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnUnlock)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnSpellCastAt)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnTrapTriggered)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnMeleeAttacked)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnOpen)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnLock)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnHeartbeat)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnDeath)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnDisarm)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnDamaged)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnClosed)
            Me.TabPageScripts.Controls.Add(Me.tbOnUsed)
            Me.TabPageScripts.Controls.Add(Me.Label18)
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
            Me.TabPageScripts.Controls.Add(Me.Label21)
            Me.TabPageScripts.Controls.Add(Me.tbOnEndDialogue)
            Me.TabPageScripts.Controls.Add(Me.tbOnInvDisturbed)
            Me.TabPageScripts.Controls.Add(Me.Label22)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnUsed)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnInvDisturbed)
            Me.TabPageScripts.Controls.Add(Me.btnEditOnEndDialogue)
            Dim tabPageScripts As Global.System.Windows.Forms.Control = Me.TabPageScripts
            point = New Global.System.Drawing.Point(4, 40)
            tabPageScripts.Location = point
            Me.TabPageScripts.Name = "TabPageScripts"
            Dim tabPageScripts2 As Global.System.Windows.Forms.Control = Me.TabPageScripts
            size = New Global.System.Drawing.Size(448, 417)
            tabPageScripts2.Size = size
            Me.TabPageScripts.TabIndex = 4
            Me.TabPageScripts.Text = "Scripts"
            Me.TabPageScripts.Visible = False
            Dim tbOnUsed As Global.System.Windows.Forms.Control = Me.tbOnUsed
            point = New Global.System.Drawing.Point(160, 354)
            tbOnUsed.Location = point
            Me.tbOnUsed.Name = "tbOnUsed"
            Dim tbOnUsed2 As Global.System.Windows.Forms.Control = Me.tbOnUsed
            size = New Global.System.Drawing.Size(204, 20)
            tbOnUsed2.Size = size
            Me.tbOnUsed.TabIndex = 26
            Me.tbOnUsed.Text = ""
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label18
            point = New Global.System.Drawing.Point(40, 354)
            label23.Location = point
            Me.Label18.Name = "Label18"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label18
            size = New Global.System.Drawing.Size(112, 18)
            label24.Size = size
            Me.Label18.TabIndex = 30
            Me.Label18.Text = "OnUsed"
            Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label25 As Global.System.Windows.Forms.Control = Me.Label34
            point = New Global.System.Drawing.Point(40, 68)
            label25.Location = point
            Me.Label34.Name = "Label34"
            Dim label26 As Global.System.Windows.Forms.Control = Me.Label34
            size = New Global.System.Drawing.Size(112, 18)
            label26.Size = size
            Me.Label34.TabIndex = 27
            Me.Label34.Text = "OnDeath"
            Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnDeath As Global.System.Windows.Forms.Control = Me.tbOnDeath
            point = New Global.System.Drawing.Point(160, 68)
            tbOnDeath.Location = point
            Me.tbOnDeath.Name = "tbOnDeath"
            Dim tbOnDeath2 As Global.System.Windows.Forms.Control = Me.tbOnDeath
            size = New Global.System.Drawing.Size(204, 20)
            tbOnDeath2.Size = size
            Me.tbOnDeath.TabIndex = 4
            Me.tbOnDeath.Text = ""
            Dim label27 As Global.System.Windows.Forms.Control = Me.Label33
            point = New Global.System.Drawing.Point(40, 42)
            label27.Location = point
            Me.Label33.Name = "Label33"
            Dim label28 As Global.System.Windows.Forms.Control = Me.Label33
            size = New Global.System.Drawing.Size(112, 18)
            label28.Size = size
            Me.Label33.TabIndex = 17
            Me.Label33.Text = "OnDamaged"
            Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnDamaged As Global.System.Windows.Forms.Control = Me.tbOnDamaged
            point = New Global.System.Drawing.Point(160, 42)
            tbOnDamaged.Location = point
            Me.tbOnDamaged.Name = "tbOnDamaged"
            Dim tbOnDamaged2 As Global.System.Windows.Forms.Control = Me.tbOnDamaged
            size = New Global.System.Drawing.Size(204, 20)
            tbOnDamaged2.Size = size
            Me.tbOnDamaged.TabIndex = 2
            Me.tbOnDamaged.Text = ""
            Dim label29 As Global.System.Windows.Forms.Control = Me.Label32
            point = New Global.System.Drawing.Point(40, 16)
            label29.Location = point
            Me.Label32.Name = "Label32"
            Dim label30 As Global.System.Windows.Forms.Control = Me.Label32
            size = New Global.System.Drawing.Size(112, 18)
            label30.Size = size
            Me.Label32.TabIndex = 14
            Me.Label32.Text = "OnClosed"
            Me.Label32.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnClosed As Global.System.Windows.Forms.Control = Me.tbOnClosed
            point = New Global.System.Drawing.Point(160, 16)
            tbOnClosed.Location = point
            Me.tbOnClosed.Name = "tbOnClosed"
            Dim tbOnClosed2 As Global.System.Windows.Forms.Control = Me.tbOnClosed
            size = New Global.System.Drawing.Size(204, 20)
            tbOnClosed2.Size = size
            Me.tbOnClosed.TabIndex = 0
            Me.tbOnClosed.Text = ""
            Dim label31 As Global.System.Windows.Forms.Control = Me.Label35
            point = New Global.System.Drawing.Point(40, 94)
            label31.Location = point
            Me.Label35.Name = "Label35"
            Dim label32 As Global.System.Windows.Forms.Control = Me.Label35
            size = New Global.System.Drawing.Size(112, 18)
            label32.Size = size
            Me.Label35.TabIndex = 26
            Me.Label35.Text = "OnDisarm"
            Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnDisarm As Global.System.Windows.Forms.Control = Me.tbOnDisarm
            point = New Global.System.Drawing.Point(160, 94)
            tbOnDisarm.Location = point
            Me.tbOnDisarm.Name = "tbOnDisarm"
            Dim tbOnDisarm2 As Global.System.Windows.Forms.Control = Me.tbOnDisarm
            size = New Global.System.Drawing.Size(204, 20)
            tbOnDisarm2.Size = size
            Me.tbOnDisarm.TabIndex = 6
            Me.tbOnDisarm.Text = ""
            Dim tbOnHeartbeat As Global.System.Windows.Forms.Control = Me.tbOnHeartbeat
            point = New Global.System.Drawing.Point(160, 146)
            tbOnHeartbeat.Location = point
            Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
            Dim tbOnHeartbeat2 As Global.System.Windows.Forms.Control = Me.tbOnHeartbeat
            size = New Global.System.Drawing.Size(204, 20)
            tbOnHeartbeat2.Size = size
            Me.tbOnHeartbeat.TabIndex = 10
            Me.tbOnHeartbeat.Text = ""
            Dim label33 As Global.System.Windows.Forms.Control = Me.Label36
            point = New Global.System.Drawing.Point(40, 146)
            label33.Location = point
            Me.Label36.Name = "Label36"
            Dim label34 As Global.System.Windows.Forms.Control = Me.Label36
            size = New Global.System.Drawing.Size(112, 18)
            label34.Size = size
            Me.Label36.TabIndex = 25
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label35 As Global.System.Windows.Forms.Control = Me.Label37
            point = New Global.System.Drawing.Point(40, 198)
            label35.Location = point
            Me.Label37.Name = "Label37"
            Dim label36 As Global.System.Windows.Forms.Control = Me.Label37
            size = New Global.System.Drawing.Size(112, 18)
            label36.Size = size
            Me.Label37.TabIndex = 28
            Me.Label37.Text = "OnLock"
            Me.Label37.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnLock As Global.System.Windows.Forms.Control = Me.tbOnLock
            point = New Global.System.Drawing.Point(160, 198)
            tbOnLock.Location = point
            Me.tbOnLock.Name = "tbOnLock"
            Dim tbOnLock2 As Global.System.Windows.Forms.Control = Me.tbOnLock
            size = New Global.System.Drawing.Size(204, 20)
            tbOnLock2.Size = size
            Me.tbOnLock.TabIndex = 14
            Me.tbOnLock.Text = ""
            Dim tbOnMeleeAttacked As Global.System.Windows.Forms.Control = Me.tbOnMeleeAttacked
            point = New Global.System.Drawing.Point(160, 224)
            tbOnMeleeAttacked.Location = point
            Me.tbOnMeleeAttacked.Name = "tbOnMeleeAttacked"
            Dim tbOnMeleeAttacked2 As Global.System.Windows.Forms.Control = Me.tbOnMeleeAttacked
            size = New Global.System.Drawing.Size(204, 20)
            tbOnMeleeAttacked2.Size = size
            Me.tbOnMeleeAttacked.TabIndex = 16
            Me.tbOnMeleeAttacked.Text = ""
            Dim label37 As Global.System.Windows.Forms.Control = Me.Label38
            point = New Global.System.Drawing.Point(40, 224)
            label37.Location = point
            Me.Label38.Name = "Label38"
            Dim label38 As Global.System.Windows.Forms.Control = Me.Label38
            size = New Global.System.Drawing.Size(112, 18)
            label38.Size = size
            Me.Label38.TabIndex = 20
            Me.Label38.Text = "OnMeleeAttacked"
            Me.Label38.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnOpen As Global.System.Windows.Forms.Control = Me.tbOnOpen
            point = New Global.System.Drawing.Point(160, 250)
            tbOnOpen.Location = point
            Me.tbOnOpen.Name = "tbOnOpen"
            Dim tbOnOpen2 As Global.System.Windows.Forms.Control = Me.tbOnOpen
            size = New Global.System.Drawing.Size(204, 20)
            tbOnOpen2.Size = size
            Me.tbOnOpen.TabIndex = 18
            Me.tbOnOpen.Text = ""
            Dim label39 As Global.System.Windows.Forms.Control = Me.Label39
            point = New Global.System.Drawing.Point(40, 250)
            label39.Location = point
            Me.Label39.Name = "Label39"
            Dim label40 As Global.System.Windows.Forms.Control = Me.Label39
            size = New Global.System.Drawing.Size(112, 18)
            label40.Size = size
            Me.Label39.TabIndex = 21
            Me.Label39.Text = "OnOpen"
            Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label41 As Global.System.Windows.Forms.Control = Me.Label40
            point = New Global.System.Drawing.Point(40, 276)
            label41.Location = point
            Me.Label40.Name = "Label40"
            Dim label42 As Global.System.Windows.Forms.Control = Me.Label40
            size = New Global.System.Drawing.Size(112, 18)
            label42.Size = size
            Me.Label40.TabIndex = 19
            Me.Label40.Text = "OnSpellCastAt"
            Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnSpellCastAt As Global.System.Windows.Forms.Control = Me.tbOnSpellCastAt
            point = New Global.System.Drawing.Point(160, 276)
            tbOnSpellCastAt.Location = point
            Me.tbOnSpellCastAt.Name = "tbOnSpellCastAt"
            Dim tbOnSpellCastAt2 As Global.System.Windows.Forms.Control = Me.tbOnSpellCastAt
            size = New Global.System.Drawing.Size(204, 20)
            tbOnSpellCastAt2.Size = size
            Me.tbOnSpellCastAt.TabIndex = 20
            Me.tbOnSpellCastAt.Text = ""
            Dim label43 As Global.System.Windows.Forms.Control = Me.Label41
            point = New Global.System.Drawing.Point(40, 302)
            label43.Location = point
            Me.Label41.Name = "Label41"
            Dim label44 As Global.System.Windows.Forms.Control = Me.Label41
            size = New Global.System.Drawing.Size(112, 18)
            label44.Size = size
            Me.Label41.TabIndex = 24
            Me.Label41.Text = "OnTrapTriggered"
            Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnTrapTriggered As Global.System.Windows.Forms.Control = Me.tbOnTrapTriggered
            point = New Global.System.Drawing.Point(160, 302)
            tbOnTrapTriggered.Location = point
            Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
            Dim tbOnTrapTriggered2 As Global.System.Windows.Forms.Control = Me.tbOnTrapTriggered
            size = New Global.System.Drawing.Size(204, 20)
            tbOnTrapTriggered2.Size = size
            Me.tbOnTrapTriggered.TabIndex = 22
            Me.tbOnTrapTriggered.Text = ""
            Dim tbOnUnlock As Global.System.Windows.Forms.Control = Me.tbOnUnlock
            point = New Global.System.Drawing.Point(160, 328)
            tbOnUnlock.Location = point
            Me.tbOnUnlock.Name = "tbOnUnlock"
            Dim tbOnUnlock2 As Global.System.Windows.Forms.Control = Me.tbOnUnlock
            size = New Global.System.Drawing.Size(204, 20)
            tbOnUnlock2.Size = size
            Me.tbOnUnlock.TabIndex = 24
            Me.tbOnUnlock.Text = ""
            Dim label45 As Global.System.Windows.Forms.Control = Me.Label42
            point = New Global.System.Drawing.Point(40, 328)
            label45.Location = point
            Me.Label42.Name = "Label42"
            Dim label46 As Global.System.Windows.Forms.Control = Me.Label42
            size = New Global.System.Drawing.Size(112, 18)
            label46.Size = size
            Me.Label42.TabIndex = 23
            Me.Label42.Text = "OnUnlock"
            Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnUserDefined As Global.System.Windows.Forms.Control = Me.tbOnUserDefined
            point = New Global.System.Drawing.Point(160, 380)
            tbOnUserDefined.Location = point
            Me.tbOnUserDefined.Name = "tbOnUserDefined"
            Dim tbOnUserDefined2 As Global.System.Windows.Forms.Control = Me.tbOnUserDefined
            size = New Global.System.Drawing.Size(204, 20)
            tbOnUserDefined2.Size = size
            Me.tbOnUserDefined.TabIndex = 28
            Me.tbOnUserDefined.Text = ""
            Dim label47 As Global.System.Windows.Forms.Control = Me.Label43
            point = New Global.System.Drawing.Point(40, 380)
            label47.Location = point
            Me.Label43.Name = "Label43"
            Dim label48 As Global.System.Windows.Forms.Control = Me.Label43
            size = New Global.System.Drawing.Size(112, 18)
            label48.Size = size
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUserDefined"
            Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label49 As Global.System.Windows.Forms.Control = Me.Label21
            point = New Global.System.Drawing.Point(40, 120)
            label49.Location = point
            Me.Label21.Name = "Label21"
            Dim label50 As Global.System.Windows.Forms.Control = Me.Label21
            size = New Global.System.Drawing.Size(112, 18)
            label50.Size = size
            Me.Label21.TabIndex = 30
            Me.Label21.Text = "OnEndDialogue"
            Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbOnEndDialogue As Global.System.Windows.Forms.Control = Me.tbOnEndDialogue
            point = New Global.System.Drawing.Point(160, 120)
            tbOnEndDialogue.Location = point
            Me.tbOnEndDialogue.Name = "tbOnEndDialogue"
            Dim tbOnEndDialogue2 As Global.System.Windows.Forms.Control = Me.tbOnEndDialogue
            size = New Global.System.Drawing.Size(204, 20)
            tbOnEndDialogue2.Size = size
            Me.tbOnEndDialogue.TabIndex = 8
            Me.tbOnEndDialogue.Text = ""
            Dim tbOnInvDisturbed As Global.System.Windows.Forms.Control = Me.tbOnInvDisturbed
            point = New Global.System.Drawing.Point(160, 172)
            tbOnInvDisturbed.Location = point
            Me.tbOnInvDisturbed.Name = "tbOnInvDisturbed"
            Dim tbOnInvDisturbed2 As Global.System.Windows.Forms.Control = Me.tbOnInvDisturbed
            size = New Global.System.Drawing.Size(204, 20)
            tbOnInvDisturbed2.Size = size
            Me.tbOnInvDisturbed.TabIndex = 12
            Me.tbOnInvDisturbed.Text = ""
            Dim label51 As Global.System.Windows.Forms.Control = Me.Label22
            point = New Global.System.Drawing.Point(40, 172)
            label51.Location = point
            Me.Label22.Name = "Label22"
            Dim label52 As Global.System.Windows.Forms.Control = Me.Label22
            size = New Global.System.Drawing.Size(112, 18)
            label52.Size = size
            Me.Label22.TabIndex = 30
            Me.Label22.Text = "OnInvDisturbed"
            Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.TabPageDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.TabPageDescription.Controls.Add(Me.tbDescription)
            Dim tabPageDescription As Global.System.Windows.Forms.Control = Me.TabPageDescription
            point = New Global.System.Drawing.Point(4, 40)
            tabPageDescription.Location = point
            Me.TabPageDescription.Name = "TabPageDescription"
            Dim tabPageDescription2 As Global.System.Windows.Forms.Control = Me.TabPageDescription
            size = New Global.System.Drawing.Size(448, 393)
            tabPageDescription2.Size = size
            Me.TabPageDescription.TabIndex = 6
            Me.TabPageDescription.Text = "Description"
            Me.TabPageDescription.Visible = False
            Dim btnSetDescriptionLang As Global.System.Windows.Forms.Control = Me.btnSetDescriptionLang
            point = New Global.System.Drawing.Point(40, 320)
            btnSetDescriptionLang.Location = point
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Dim btnSetDescriptionLang2 As Global.System.Windows.Forms.Control = Me.btnSetDescriptionLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetDescriptionLang2.Size = size
            Me.btnSetDescriptionLang.TabIndex = 1
            Me.btnSetDescriptionLang.Text = "Set Language"
            Dim tbDescription As Global.System.Windows.Forms.Control = Me.tbDescription
            point = New Global.System.Drawing.Point(12, 7)
            tbDescription.Location = point
            Me.tbDescription.Multiline = True
            Me.tbDescription.Name = "tbDescription"
            Dim tbDescription2 As Global.System.Windows.Forms.Control = Me.tbDescription
            size = New Global.System.Drawing.Size(424, 305)
            tbDescription2.Size = size
            Me.tbDescription.TabIndex = 0
            Me.tbDescription.Text = ""
            Me.TabPageComments.Controls.Add(Me.tbComment)
            Dim tabPageComments As Global.System.Windows.Forms.Control = Me.TabPageComments
            point = New Global.System.Drawing.Point(4, 40)
            tabPageComments.Location = point
            Me.TabPageComments.Name = "TabPageComments"
            Dim tabPageComments2 As Global.System.Windows.Forms.Control = Me.TabPageComments
            size = New Global.System.Drawing.Size(448, 393)
            tabPageComments2.Size = size
            Me.TabPageComments.TabIndex = 7
            Me.TabPageComments.Text = "Comments"
            Me.TabPageComments.Visible = False
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
            Me.TabPageTrap.Controls.Add(Me.chkbTrapDisarmable)
            Me.TabPageTrap.Controls.Add(Me.chkbTrapDetectable)
            Me.TabPageTrap.Controls.Add(Me.Label6)
            Me.TabPageTrap.Controls.Add(Me.Label3)
            Me.TabPageTrap.Controls.Add(Me.nudDisarmDC)
            Me.TabPageTrap.Controls.Add(Me.Label4)
            Me.TabPageTrap.Controls.Add(Me.Label15)
            Me.TabPageTrap.Controls.Add(Me.nudTrapDetectDC)
            Me.TabPageTrap.Controls.Add(Me.Label16)
            Me.TabPageTrap.Controls.Add(Me.lblTrapDetectable)
            Me.TabPageTrap.Controls.Add(Me.nudTrapType)
            Me.TabPageTrap.Controls.Add(Me.Label17)
            Me.TabPageTrap.Controls.Add(Me.chkbTrapFlag)
            Me.TabPageTrap.Controls.Add(Me.chkbTrapOneShot)
            Dim tabPageTrap As Global.System.Windows.Forms.Control = Me.TabPageTrap
            point = New Global.System.Drawing.Point(4, 40)
            tabPageTrap.Location = point
            Me.TabPageTrap.Name = "TabPageTrap"
            Dim tabPageTrap2 As Global.System.Windows.Forms.Control = Me.TabPageTrap
            size = New Global.System.Drawing.Size(448, 393)
            tabPageTrap2.Size = size
            Me.TabPageTrap.TabIndex = 10
            Me.TabPageTrap.Text = "Trap"
            Dim chkbTrapDisarmable As Global.System.Windows.Forms.Control = Me.chkbTrapDisarmable
            point = New Global.System.Drawing.Point(192, 85)
            chkbTrapDisarmable.Location = point
            Me.chkbTrapDisarmable.Name = "chkbTrapDisarmable"
            Dim chkbTrapDisarmable2 As Global.System.Windows.Forms.Control = Me.chkbTrapDisarmable
            size = New Global.System.Drawing.Size(24, 24)
            chkbTrapDisarmable2.Size = size
            Me.chkbTrapDisarmable.TabIndex = 2
            Dim chkbTrapDetectable As Global.System.Windows.Forms.Control = Me.chkbTrapDetectable
            point = New Global.System.Drawing.Point(192, 21)
            chkbTrapDetectable.Location = point
            Me.chkbTrapDetectable.Name = "chkbTrapDetectable"
            Dim chkbTrapDetectable2 As Global.System.Windows.Forms.Control = Me.chkbTrapDetectable
            size = New Global.System.Drawing.Size(24, 24)
            chkbTrapDetectable2.Size = size
            Me.chkbTrapDetectable.TabIndex = 0
            Dim label53 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(48, 184)
            label53.Location = point
            Me.Label6.Name = "Label6"
            Dim label54 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(88, 16)
            label54.Size = size
            Me.Label6.TabIndex = 26
            Me.Label6.Text = "TrapOneShot"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label55 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(48, 152)
            label55.Location = point
            Me.Label3.Name = "Label3"
            Dim label56 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(88, 16)
            label56.Size = size
            Me.Label3.TabIndex = 27
            Me.Label3.Text = "TrapFlag"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudDisarmDC As Global.System.Windows.Forms.Control = Me.nudDisarmDC
            point = New Global.System.Drawing.Point(176, 120)
            nudDisarmDC.Location = point
            Dim nudDisarmDC2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDisarmDC
            num = New Decimal(New Integer() {250, 0, 0, 0})
            nudDisarmDC2.Maximum = num
            Me.nudDisarmDC.Name = "nudDisarmDC"
            Me.nudDisarmDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudDisarmDC3 As Global.System.Windows.Forms.Control = Me.nudDisarmDC
            size = New Global.System.Drawing.Size(48, 20)
            nudDisarmDC3.Size = size
            Me.nudDisarmDC.TabIndex = 3
            Me.nudDisarmDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label57 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(48, 120)
            label57.Location = point
            Me.Label4.Name = "Label4"
            Dim label58 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(88, 16)
            label58.Size = size
            Me.Label4.TabIndex = 22
            Me.Label4.Text = "DisarmDC"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label59 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(48, 88)
            label59.Location = point
            Me.Label15.Name = "Label15"
            Dim label60 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(88, 16)
            label60.Size = size
            Me.Label15.TabIndex = 23
            Me.Label15.Text = "TrapDisarmable"
            Me.Label15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudTrapDetectDC As Global.System.Windows.Forms.Control = Me.nudTrapDetectDC
            point = New Global.System.Drawing.Point(176, 56)
            nudTrapDetectDC.Location = point
            Dim nudTrapDetectDC2 As Global.System.Windows.Forms.NumericUpDown = Me.nudTrapDetectDC
            num = New Decimal(New Integer() {250, 0, 0, 0})
            nudTrapDetectDC2.Maximum = num
            Me.nudTrapDetectDC.Name = "nudTrapDetectDC"
            Me.nudTrapDetectDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudTrapDetectDC3 As Global.System.Windows.Forms.Control = Me.nudTrapDetectDC
            size = New Global.System.Drawing.Size(48, 20)
            nudTrapDetectDC3.Size = size
            Me.nudTrapDetectDC.TabIndex = 1
            Me.nudTrapDetectDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label61 As Global.System.Windows.Forms.Control = Me.Label16
            point = New Global.System.Drawing.Point(48, 56)
            label61.Location = point
            Me.Label16.Name = "Label16"
            Dim label62 As Global.System.Windows.Forms.Control = Me.Label16
            size = New Global.System.Drawing.Size(88, 16)
            label62.Size = size
            Me.Label16.TabIndex = 18
            Me.Label16.Text = "TrapDetectDC"
            Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim lblTrapDetectable As Global.System.Windows.Forms.Control = Me.lblTrapDetectable
            point = New Global.System.Drawing.Point(48, 24)
            lblTrapDetectable.Location = point
            Me.lblTrapDetectable.Name = "lblTrapDetectable"
            Dim lblTrapDetectable2 As Global.System.Windows.Forms.Control = Me.lblTrapDetectable
            size = New Global.System.Drawing.Size(88, 16)
            lblTrapDetectable2.Size = size
            Me.lblTrapDetectable.TabIndex = 19
            Me.lblTrapDetectable.Text = "TrapDetectable"
            Me.lblTrapDetectable.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim nudTrapType As Global.System.Windows.Forms.Control = Me.nudTrapType
            point = New Global.System.Drawing.Point(176, 216)
            nudTrapType.Location = point
            Dim nudTrapType2 As Global.System.Windows.Forms.NumericUpDown = Me.nudTrapType
            num = New Decimal(New Integer() {2, 0, 0, 0})
            nudTrapType2.Maximum = num
            Me.nudTrapType.Name = "nudTrapType"
            Me.nudTrapType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Dim nudTrapType3 As Global.System.Windows.Forms.Control = Me.nudTrapType
            size = New Global.System.Drawing.Size(48, 20)
            nudTrapType3.Size = size
            Me.nudTrapType.TabIndex = 6
            Me.nudTrapType.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label63 As Global.System.Windows.Forms.Control = Me.Label17
            point = New Global.System.Drawing.Point(48, 216)
            label63.Location = point
            Me.Label17.Name = "Label17"
            Dim label64 As Global.System.Windows.Forms.Control = Me.Label17
            size = New Global.System.Drawing.Size(88, 16)
            label64.Size = size
            Me.Label17.TabIndex = 26
            Me.Label17.Text = "TrapType"
            Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbTrapFlag As Global.System.Windows.Forms.Control = Me.chkbTrapFlag
            point = New Global.System.Drawing.Point(192, 152)
            chkbTrapFlag.Location = point
            Me.chkbTrapFlag.Name = "chkbTrapFlag"
            Dim chkbTrapFlag2 As Global.System.Windows.Forms.Control = Me.chkbTrapFlag
            size = New Global.System.Drawing.Size(24, 24)
            chkbTrapFlag2.Size = size
            Me.chkbTrapFlag.TabIndex = 4
            Dim chkbTrapOneShot As Global.System.Windows.Forms.Control = Me.chkbTrapOneShot
            point = New Global.System.Drawing.Point(192, 184)
            chkbTrapOneShot.Location = point
            Me.chkbTrapOneShot.Name = "chkbTrapOneShot"
            Dim chkbTrapOneShot2 As Global.System.Windows.Forms.Control = Me.chkbTrapOneShot
            size = New Global.System.Drawing.Size(24, 24)
            chkbTrapOneShot2.Size = size
            Me.chkbTrapOneShot.TabIndex = 5
            Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
            point = New Global.System.Drawing.Point(312, 480)
            btnSave.Location = point
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "&Save"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(408, 480)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "&Cancel"
            Me.btnInventory.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim btnInventory As Global.System.Windows.Forms.Control = Me.btnInventory
            point = New Global.System.Drawing.Point(64, 480)
            btnInventory.Location = point
            Me.btnInventory.Name = "btnInventory"
            Dim btnInventory2 As Global.System.Windows.Forms.Control = Me.btnInventory
            size = New Global.System.Drawing.Size(72, 24)
            btnInventory2.Size = size
            Me.btnInventory.TabIndex = 9
            Me.btnInventory.Text = "&Inventory"
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
            point = New Global.System.Drawing.Point(0, 0)
            btnDebug.Location = point
            Me.btnDebug.Name = "btnDebug"
            Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
            size = New Global.System.Drawing.Size(8, 9)
            btnDebug2.Size = size
            Me.btnDebug.TabIndex = 19
            Me.btnDebug.TabStop = False
            Dim btnEditOnClosed As Global.System.Windows.Forms.Control = Me.btnEditOnClosed
            point = New Global.System.Drawing.Point(384, 16)
            btnEditOnClosed.Location = point
            Me.btnEditOnClosed.Name = "btnEditOnClosed"
            Dim btnEditOnClosed2 As Global.System.Windows.Forms.Control = Me.btnEditOnClosed
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnClosed2.Size = size
            Me.btnEditOnClosed.TabIndex = 1
            Me.btnEditOnClosed.Text = "Edit"
            Me.btnEditOnClosed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnDamaged As Global.System.Windows.Forms.Control = Me.btnEditOnDamaged
            point = New Global.System.Drawing.Point(384, 42)
            btnEditOnDamaged.Location = point
            Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
            Dim btnEditOnDamaged2 As Global.System.Windows.Forms.Control = Me.btnEditOnDamaged
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnDamaged2.Size = size
            Me.btnEditOnDamaged.TabIndex = 3
            Me.btnEditOnDamaged.Text = "Edit"
            Me.btnEditOnDamaged.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnDeath As Global.System.Windows.Forms.Control = Me.btnEditOnDeath
            point = New Global.System.Drawing.Point(384, 68)
            btnEditOnDeath.Location = point
            Me.btnEditOnDeath.Name = "btnEditOnDeath"
            Dim btnEditOnDeath2 As Global.System.Windows.Forms.Control = Me.btnEditOnDeath
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnDeath2.Size = size
            Me.btnEditOnDeath.TabIndex = 5
            Me.btnEditOnDeath.Text = "Edit"
            Me.btnEditOnDeath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnDisarm As Global.System.Windows.Forms.Control = Me.btnEditOnDisarm
            point = New Global.System.Drawing.Point(384, 94)
            btnEditOnDisarm.Location = point
            Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
            Dim btnEditOnDisarm2 As Global.System.Windows.Forms.Control = Me.btnEditOnDisarm
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnDisarm2.Size = size
            Me.btnEditOnDisarm.TabIndex = 7
            Me.btnEditOnDisarm.Text = "Edit"
            Me.btnEditOnDisarm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnHeartbeat As Global.System.Windows.Forms.Control = Me.btnEditOnHeartbeat
            point = New Global.System.Drawing.Point(384, 146)
            btnEditOnHeartbeat.Location = point
            Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
            Dim btnEditOnHeartbeat2 As Global.System.Windows.Forms.Control = Me.btnEditOnHeartbeat
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnHeartbeat2.Size = size
            Me.btnEditOnHeartbeat.TabIndex = 11
            Me.btnEditOnHeartbeat.Text = "Edit"
            Me.btnEditOnHeartbeat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnLock As Global.System.Windows.Forms.Control = Me.btnEditOnLock
            point = New Global.System.Drawing.Point(384, 198)
            btnEditOnLock.Location = point
            Me.btnEditOnLock.Name = "btnEditOnLock"
            Dim btnEditOnLock2 As Global.System.Windows.Forms.Control = Me.btnEditOnLock
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnLock2.Size = size
            Me.btnEditOnLock.TabIndex = 15
            Me.btnEditOnLock.Text = "Edit"
            Me.btnEditOnLock.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnMeleeAttacked As Global.System.Windows.Forms.Control = Me.btnEditOnMeleeAttacked
            point = New Global.System.Drawing.Point(384, 224)
            btnEditOnMeleeAttacked.Location = point
            Me.btnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked"
            Dim btnEditOnMeleeAttacked2 As Global.System.Windows.Forms.Control = Me.btnEditOnMeleeAttacked
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnMeleeAttacked2.Size = size
            Me.btnEditOnMeleeAttacked.TabIndex = 17
            Me.btnEditOnMeleeAttacked.Text = "Edit"
            Me.btnEditOnMeleeAttacked.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnOpen As Global.System.Windows.Forms.Control = Me.btnEditOnOpen
            point = New Global.System.Drawing.Point(384, 250)
            btnEditOnOpen.Location = point
            Me.btnEditOnOpen.Name = "btnEditOnOpen"
            Dim btnEditOnOpen2 As Global.System.Windows.Forms.Control = Me.btnEditOnOpen
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnOpen2.Size = size
            Me.btnEditOnOpen.TabIndex = 19
            Me.btnEditOnOpen.Text = "Edit"
            Me.btnEditOnOpen.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnSpellCastAt As Global.System.Windows.Forms.Control = Me.btnEditOnSpellCastAt
            point = New Global.System.Drawing.Point(384, 276)
            btnEditOnSpellCastAt.Location = point
            Me.btnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt"
            Dim btnEditOnSpellCastAt2 As Global.System.Windows.Forms.Control = Me.btnEditOnSpellCastAt
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnSpellCastAt2.Size = size
            Me.btnEditOnSpellCastAt.TabIndex = 21
            Me.btnEditOnSpellCastAt.Text = "Edit"
            Me.btnEditOnSpellCastAt.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnTrapTriggered As Global.System.Windows.Forms.Control = Me.btnEditOnTrapTriggered
            point = New Global.System.Drawing.Point(384, 302)
            btnEditOnTrapTriggered.Location = point
            Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
            Dim btnEditOnTrapTriggered2 As Global.System.Windows.Forms.Control = Me.btnEditOnTrapTriggered
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnTrapTriggered2.Size = size
            Me.btnEditOnTrapTriggered.TabIndex = 23
            Me.btnEditOnTrapTriggered.Text = "Edit"
            Me.btnEditOnTrapTriggered.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnUserDefined As Global.System.Windows.Forms.Control = Me.btnEditOnUserDefined
            point = New Global.System.Drawing.Point(384, 380)
            btnEditOnUserDefined.Location = point
            Me.btnEditOnUserDefined.Name = "btnEditOnUserDefined"
            Dim btnEditOnUserDefined2 As Global.System.Windows.Forms.Control = Me.btnEditOnUserDefined
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnUserDefined2.Size = size
            Me.btnEditOnUserDefined.TabIndex = 29
            Me.btnEditOnUserDefined.Text = "Edit"
            Me.btnEditOnUserDefined.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnUnlock As Global.System.Windows.Forms.Control = Me.btnEditOnUnlock
            point = New Global.System.Drawing.Point(384, 328)
            btnEditOnUnlock.Location = point
            Me.btnEditOnUnlock.Name = "btnEditOnUnlock"
            Dim btnEditOnUnlock2 As Global.System.Windows.Forms.Control = Me.btnEditOnUnlock
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnUnlock2.Size = size
            Me.btnEditOnUnlock.TabIndex = 25
            Me.btnEditOnUnlock.Text = "Edit"
            Me.btnEditOnUnlock.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnUsed As Global.System.Windows.Forms.Control = Me.btnEditOnUsed
            point = New Global.System.Drawing.Point(384, 354)
            btnEditOnUsed.Location = point
            Me.btnEditOnUsed.Name = "btnEditOnUsed"
            Dim btnEditOnUsed2 As Global.System.Windows.Forms.Control = Me.btnEditOnUsed
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnUsed2.Size = size
            Me.btnEditOnUsed.TabIndex = 27
            Me.btnEditOnUsed.Text = "Edit"
            Me.btnEditOnUsed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnInvDisturbed As Global.System.Windows.Forms.Control = Me.btnEditOnInvDisturbed
            point = New Global.System.Drawing.Point(384, 172)
            btnEditOnInvDisturbed.Location = point
            Me.btnEditOnInvDisturbed.Name = "btnEditOnInvDisturbed"
            Dim btnEditOnInvDisturbed2 As Global.System.Windows.Forms.Control = Me.btnEditOnInvDisturbed
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnInvDisturbed2.Size = size
            Me.btnEditOnInvDisturbed.TabIndex = 13
            Me.btnEditOnInvDisturbed.Text = "Edit"
            Me.btnEditOnInvDisturbed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim btnEditOnEndDialogue As Global.System.Windows.Forms.Control = Me.btnEditOnEndDialogue
            point = New Global.System.Drawing.Point(384, 120)
            btnEditOnEndDialogue.Location = point
            Me.btnEditOnEndDialogue.Name = "btnEditOnEndDialogue"
            Dim btnEditOnEndDialogue2 As Global.System.Windows.Forms.Control = Me.btnEditOnEndDialogue
            size = New Global.System.Drawing.Size(32, 23)
            btnEditOnEndDialogue2.Size = size
            Me.btnEditOnEndDialogue.TabIndex = 9
            Me.btnEditOnEndDialogue.Text = "Edit"
            Me.btnEditOnEndDialogue.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(496, 517)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnInventory)
            Me.Name = "frmUTP_Editor"
            Me.Text = "Placeable Editor - KotOR "
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
            Me.TabPageAdvanced.ResumeLayout(False)
            Me.TabPageScripts.ResumeLayout(False)
            Me.TabPageDescription.ResumeLayout(False)
            Me.TabPageComments.ResumeLayout(False)
            Me.TabPageTrap.ResumeLayout(False)
            CType(Me.nudDisarmDC, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTrapDetectDC, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTrapType, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000A49 RID: 2633
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
