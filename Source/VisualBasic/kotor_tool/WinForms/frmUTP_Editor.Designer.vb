Namespace kotor_tool
	' Token: 0x02000081 RID: 129
	Public Partial Class frmUTP_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPageBasic As Global.System.Windows.Forms.TabPage
        Friend WithEvents btnSetNameLang As Global.System.Windows.Forms.Button
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents nudWill As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFort As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudHP As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblTextureVariation As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents nudHardness As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRef As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents lblBodyVariation As Global.System.Windows.Forms.Label
        Friend WithEvents chkbPlotItem As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbStatic As Global.System.Windows.Forms.CheckBox
        Friend WithEvents TabPageLock As Global.System.Windows.Forms.TabPage
        Friend WithEvents tbKeyName As Global.System.Windows.Forms.TextBox
        Friend WithEvents lblKeyTag As Global.System.Windows.Forms.Label
        Friend WithEvents nudCloseLockDC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblCloseLockDC As Global.System.Windows.Forms.Label
        Friend WithEvents nudOpenLockDC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblOpenLockDC As Global.System.Windows.Forms.Label
        Friend WithEvents chkbLockable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbLocked As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbKeyRequired As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbAutoRemoveKey As Global.System.Windows.Forms.CheckBox
        Friend WithEvents TabPageScripts As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label34 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnDeath As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label33 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnDamaged As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label32 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnClosed As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label35 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnDisarm As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnHeartbeat As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label36 As Global.System.Windows.Forms.Label
        Friend WithEvents Label37 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnLock As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnMeleeAttacked As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label38 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnOpen As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label39 As Global.System.Windows.Forms.Label
        Friend WithEvents Label40 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnSpellCastAt As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label41 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnTrapTriggered As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnUnlock As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label42 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnUserDefined As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label43 As Global.System.Windows.Forms.Label
        Friend WithEvents TabPageAdvanced As Global.System.Windows.Forms.TabPage
        Friend WithEvents tbConversation As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbFaction As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTemplateResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents tbAnimationState As Global.System.Windows.Forms.TextBox
        Friend WithEvents TabPageDescription As Global.System.Windows.Forms.TabPage
        Friend WithEvents btnSetDescriptionLang As Global.System.Windows.Forms.Button
        Friend WithEvents tbDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents TabPageComments As Global.System.Windows.Forms.TabPage
        Friend WithEvents tbComment As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents chkbMin1HP As Global.System.Windows.Forms.CheckBox
        Friend WithEvents TabPageTrap As Global.System.Windows.Forms.TabPage
        Friend WithEvents chkbTrapDisarmable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbTrapDetectable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents nudDisarmDC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents nudTrapDetectDC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents lblTrapDetectable As Global.System.Windows.Forms.Label
        Friend WithEvents nudTrapType As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbTrapFlag As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbTrapOneShot As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxAppearance As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents tbType As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnUsed As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnEndDialogue As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnInvDisturbed As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbHasInventory As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbPartyInteract As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnInventory As Global.System.Windows.Forms.Button
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents chkbUsable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbInterruptable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnEditOnClosed As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDamaged As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDeath As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDisarm As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnHeartbeat As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnLock As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnMeleeAttacked As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnOpen As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnSpellCastAt As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnTrapTriggered As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnUserDefined As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnUnlock As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnUsed As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnInvDisturbed As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnEndDialogue As Global.System.Windows.Forms.Button


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
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPageBasic = New System.Windows.Forms.TabPage()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.cmbxAppearance = New System.Windows.Forms.ComboBox()
            Me.btnSetNameLang = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.nudWill = New System.Windows.Forms.NumericUpDown()
            Me.nudFort = New System.Windows.Forms.NumericUpDown()
            Me.nudHP = New System.Windows.Forms.NumericUpDown()
            Me.lblTextureVariation = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.nudHardness = New System.Windows.Forms.NumericUpDown()
            Me.nudRef = New System.Windows.Forms.NumericUpDown()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.lblBodyVariation = New System.Windows.Forms.Label()
            Me.chkbPlotItem = New System.Windows.Forms.CheckBox()
            Me.tbTag = New System.Windows.Forms.TextBox()
            Me.tbName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.chkbStatic = New System.Windows.Forms.CheckBox()
            Me.chkbMin1HP = New System.Windows.Forms.CheckBox()
            Me.TabPageLock = New System.Windows.Forms.TabPage()
            Me.tbKeyName = New System.Windows.Forms.TextBox()
            Me.lblKeyTag = New System.Windows.Forms.Label()
            Me.nudCloseLockDC = New System.Windows.Forms.NumericUpDown()
            Me.lblCloseLockDC = New System.Windows.Forms.Label()
            Me.nudOpenLockDC = New System.Windows.Forms.NumericUpDown()
            Me.lblOpenLockDC = New System.Windows.Forms.Label()
            Me.chkbLockable = New System.Windows.Forms.CheckBox()
            Me.chkbLocked = New System.Windows.Forms.CheckBox()
            Me.chkbKeyRequired = New System.Windows.Forms.CheckBox()
            Me.chkbAutoRemoveKey = New System.Windows.Forms.CheckBox()
            Me.TabPageAdvanced = New System.Windows.Forms.TabPage()
            Me.chkbPartyInteract = New System.Windows.Forms.CheckBox()
            Me.chkbHasInventory = New System.Windows.Forms.CheckBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.tbType = New System.Windows.Forms.TextBox()
            Me.chkbInterruptable = New System.Windows.Forms.CheckBox()
            Me.tbConversation = New System.Windows.Forms.TextBox()
            Me.tbFaction = New System.Windows.Forms.TextBox()
            Me.tbTemplateResRef = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.tbAnimationState = New System.Windows.Forms.TextBox()
            Me.chkbUsable = New System.Windows.Forms.CheckBox()
            Me.TabPageScripts = New System.Windows.Forms.TabPage()
            Me.btnEditOnUserDefined = New System.Windows.Forms.Button()
            Me.btnEditOnUnlock = New System.Windows.Forms.Button()
            Me.btnEditOnSpellCastAt = New System.Windows.Forms.Button()
            Me.btnEditOnTrapTriggered = New System.Windows.Forms.Button()
            Me.btnEditOnMeleeAttacked = New System.Windows.Forms.Button()
            Me.btnEditOnOpen = New System.Windows.Forms.Button()
            Me.btnEditOnLock = New System.Windows.Forms.Button()
            Me.btnEditOnHeartbeat = New System.Windows.Forms.Button()
            Me.btnEditOnDeath = New System.Windows.Forms.Button()
            Me.btnEditOnDisarm = New System.Windows.Forms.Button()
            Me.btnEditOnDamaged = New System.Windows.Forms.Button()
            Me.btnEditOnClosed = New System.Windows.Forms.Button()
            Me.tbOnUsed = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.tbOnDeath = New System.Windows.Forms.TextBox()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.tbOnDamaged = New System.Windows.Forms.TextBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.tbOnClosed = New System.Windows.Forms.TextBox()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.tbOnDisarm = New System.Windows.Forms.TextBox()
            Me.tbOnHeartbeat = New System.Windows.Forms.TextBox()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.tbOnLock = New System.Windows.Forms.TextBox()
            Me.tbOnMeleeAttacked = New System.Windows.Forms.TextBox()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.tbOnOpen = New System.Windows.Forms.TextBox()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.tbOnSpellCastAt = New System.Windows.Forms.TextBox()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.tbOnTrapTriggered = New System.Windows.Forms.TextBox()
            Me.tbOnUnlock = New System.Windows.Forms.TextBox()
            Me.Label42 = New System.Windows.Forms.Label()
            Me.tbOnUserDefined = New System.Windows.Forms.TextBox()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.tbOnEndDialogue = New System.Windows.Forms.TextBox()
            Me.tbOnInvDisturbed = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.btnEditOnUsed = New System.Windows.Forms.Button()
            Me.btnEditOnInvDisturbed = New System.Windows.Forms.Button()
            Me.btnEditOnEndDialogue = New System.Windows.Forms.Button()
            Me.TabPageDescription = New System.Windows.Forms.TabPage()
            Me.btnSetDescriptionLang = New System.Windows.Forms.Button()
            Me.tbDescription = New System.Windows.Forms.TextBox()
            Me.TabPageComments = New System.Windows.Forms.TabPage()
            Me.tbComment = New System.Windows.Forms.TextBox()
            Me.TabPageTrap = New System.Windows.Forms.TabPage()
            Me.chkbTrapDisarmable = New System.Windows.Forms.CheckBox()
            Me.chkbTrapDetectable = New System.Windows.Forms.CheckBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.nudDisarmDC = New System.Windows.Forms.NumericUpDown()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.nudTrapDetectDC = New System.Windows.Forms.NumericUpDown()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.lblTrapDetectable = New System.Windows.Forms.Label()
            Me.nudTrapType = New System.Windows.Forms.NumericUpDown()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.chkbTrapFlag = New System.Windows.Forms.CheckBox()
            Me.chkbTrapOneShot = New System.Windows.Forms.CheckBox()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnInventory = New System.Windows.Forms.Button()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.TabControl1.SuspendLayout()
            Me.TabPageBasic.SuspendLayout()
            CType(Me.nudWill, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFort, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudHP, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudHardness, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRef, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPageLock.SuspendLayout()
            CType(Me.nudCloseLockDC, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudOpenLockDC, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPageAdvanced.SuspendLayout()
            Me.TabPageScripts.SuspendLayout()
            Me.TabPageDescription.SuspendLayout()
            Me.TabPageComments.SuspendLayout()
            Me.TabPageTrap.SuspendLayout()
            CType(Me.nudDisarmDC, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTrapDetectDC, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTrapType, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPageBasic)
            Me.TabControl1.Controls.Add(Me.TabPageLock)
            Me.TabControl1.Controls.Add(Me.TabPageAdvanced)
            Me.TabControl1.Controls.Add(Me.TabPageScripts)
            Me.TabControl1.Controls.Add(Me.TabPageDescription)
            Me.TabControl1.Controls.Add(Me.TabPageComments)
            Me.TabControl1.Controls.Add(Me.TabPageTrap)
            Me.TabControl1.Location = New System.Drawing.Point(19, 13)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New System.Drawing.Point(15, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(456, 452)
            Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabIndex = 0
            '
            'TabPageBasic
            '
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
            Me.TabPageBasic.Location = New System.Drawing.Point(4, 40)
            Me.TabPageBasic.Name = "TabPageBasic"
            Me.TabPageBasic.Size = New System.Drawing.Size(448, 408)
            Me.TabPageBasic.TabIndex = 0
            Me.TabPageBasic.Text = "Basic"
            '
            'Label19
            '
            Me.Label19.Location = New System.Drawing.Point(48, 92)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(80, 19)
            Me.Label19.TabIndex = 10
            Me.Label19.Text = "Appearance"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxAppearance
            '
            Me.cmbxAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxAppearance.Location = New System.Drawing.Point(128, 92)
            Me.cmbxAppearance.Name = "cmbxAppearance"
            Me.cmbxAppearance.Size = New System.Drawing.Size(184, 21)
            Me.cmbxAppearance.TabIndex = 3
            '
            'btnSetNameLang
            '
            Me.btnSetNameLang.Location = New System.Drawing.Point(344, 37)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New System.Drawing.Size(88, 26)
            Me.btnSetNameLang.TabIndex = 1
            Me.btnSetNameLang.Text = "Set Language"
            '
            'Label5
            '
            Me.Label5.Location = New System.Drawing.Point(48, 231)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(88, 18)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Fortitude Save"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudWill
            '
            Me.nudWill.Location = New System.Drawing.Point(192, 286)
            Me.nudWill.Name = "nudWill"
            Me.nudWill.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudWill.Size = New System.Drawing.Size(48, 22)
            Me.nudWill.TabIndex = 11
            Me.nudWill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudFort
            '
            Me.nudFort.Location = New System.Drawing.Point(192, 231)
            Me.nudFort.Name = "nudFort"
            Me.nudFort.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudFort.Size = New System.Drawing.Size(48, 22)
            Me.nudFort.TabIndex = 9
            Me.nudFort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudHP
            '
            Me.nudHP.Location = New System.Drawing.Point(192, 203)
            Me.nudHP.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudHP.Name = "nudHP"
            Me.nudHP.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudHP.Size = New System.Drawing.Size(48, 22)
            Me.nudHP.TabIndex = 8
            Me.nudHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTextureVariation
            '
            Me.lblTextureVariation.Location = New System.Drawing.Point(48, 286)
            Me.lblTextureVariation.Name = "lblTextureVariation"
            Me.lblTextureVariation.Size = New System.Drawing.Size(96, 19)
            Me.lblTextureVariation.TabIndex = 5
            Me.lblTextureVariation.Text = "Will Save"
            Me.lblTextureVariation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.Location = New System.Drawing.Point(48, 203)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(88, 19)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Hit Points"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudHardness
            '
            Me.nudHardness.Location = New System.Drawing.Point(192, 175)
            Me.nudHardness.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudHardness.Name = "nudHardness"
            Me.nudHardness.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudHardness.Size = New System.Drawing.Size(48, 22)
            Me.nudHardness.TabIndex = 7
            Me.nudHardness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudRef
            '
            Me.nudRef.Location = New System.Drawing.Point(192, 258)
            Me.nudRef.Name = "nudRef"
            Me.nudRef.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudRef.Size = New System.Drawing.Size(48, 22)
            Me.nudRef.TabIndex = 10
            Me.nudRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label12
            '
            Me.Label12.Location = New System.Drawing.Point(48, 175)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(88, 19)
            Me.Label12.TabIndex = 7
            Me.Label12.Text = "Hardness"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblBodyVariation
            '
            Me.lblBodyVariation.Location = New System.Drawing.Point(48, 258)
            Me.lblBodyVariation.Name = "lblBodyVariation"
            Me.lblBodyVariation.Size = New System.Drawing.Size(88, 19)
            Me.lblBodyVariation.TabIndex = 6
            Me.lblBodyVariation.Text = "Reflex Save"
            Me.lblBodyVariation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbPlotItem
            '
            Me.chkbPlotItem.Location = New System.Drawing.Point(48, 129)
            Me.chkbPlotItem.Name = "chkbPlotItem"
            Me.chkbPlotItem.Size = New System.Drawing.Size(72, 28)
            Me.chkbPlotItem.TabIndex = 4
            Me.chkbPlotItem.Text = "Plot item"
            '
            'tbTag
            '
            Me.tbTag.Location = New System.Drawing.Point(128, 65)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(200, 22)
            Me.tbTag.TabIndex = 2
            '
            'tbName
            '
            Me.tbName.Location = New System.Drawing.Point(128, 37)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New System.Drawing.Size(200, 22)
            Me.tbName.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(48, 37)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Name"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(48, 65)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 18)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbStatic
            '
            Me.chkbStatic.Location = New System.Drawing.Point(192, 129)
            Me.chkbStatic.Name = "chkbStatic"
            Me.chkbStatic.Size = New System.Drawing.Size(72, 28)
            Me.chkbStatic.TabIndex = 5
            Me.chkbStatic.Text = "Static"
            '
            'chkbMin1HP
            '
            Me.chkbMin1HP.Location = New System.Drawing.Point(296, 129)
            Me.chkbMin1HP.Name = "chkbMin1HP"
            Me.chkbMin1HP.Size = New System.Drawing.Size(72, 28)
            Me.chkbMin1HP.TabIndex = 6
            Me.chkbMin1HP.Text = "Min1HP"
            '
            'TabPageLock
            '
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
            Me.TabPageLock.Location = New System.Drawing.Point(4, 40)
            Me.TabPageLock.Name = "TabPageLock"
            Me.TabPageLock.Size = New System.Drawing.Size(448, 488)
            Me.TabPageLock.TabIndex = 1
            Me.TabPageLock.Text = "Lock"
            Me.TabPageLock.Visible = False
            '
            'tbKeyName
            '
            Me.tbKeyName.Enabled = False
            Me.tbKeyName.Location = New System.Drawing.Point(176, 295)
            Me.tbKeyName.Name = "tbKeyName"
            Me.tbKeyName.Size = New System.Drawing.Size(200, 22)
            Me.tbKeyName.TabIndex = 6
            '
            'lblKeyTag
            '
            Me.lblKeyTag.Enabled = False
            Me.lblKeyTag.Location = New System.Drawing.Point(52, 295)
            Me.lblKeyTag.Name = "lblKeyTag"
            Me.lblKeyTag.Size = New System.Drawing.Size(100, 19)
            Me.lblKeyTag.TabIndex = 18
            Me.lblKeyTag.Text = "Key Tag"
            Me.lblKeyTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudCloseLockDC
            '
            Me.nudCloseLockDC.Enabled = False
            Me.nudCloseLockDC.Location = New System.Drawing.Point(176, 249)
            Me.nudCloseLockDC.Name = "nudCloseLockDC"
            Me.nudCloseLockDC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudCloseLockDC.Size = New System.Drawing.Size(48, 22)
            Me.nudCloseLockDC.TabIndex = 5
            Me.nudCloseLockDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblCloseLockDC
            '
            Me.lblCloseLockDC.Enabled = False
            Me.lblCloseLockDC.Location = New System.Drawing.Point(48, 249)
            Me.lblCloseLockDC.Name = "lblCloseLockDC"
            Me.lblCloseLockDC.Size = New System.Drawing.Size(88, 19)
            Me.lblCloseLockDC.TabIndex = 14
            Me.lblCloseLockDC.Text = "Close Lock DC"
            Me.lblCloseLockDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudOpenLockDC
            '
            Me.nudOpenLockDC.Enabled = False
            Me.nudOpenLockDC.Location = New System.Drawing.Point(176, 203)
            Me.nudOpenLockDC.Name = "nudOpenLockDC"
            Me.nudOpenLockDC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudOpenLockDC.Size = New System.Drawing.Size(48, 22)
            Me.nudOpenLockDC.TabIndex = 4
            Me.nudOpenLockDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblOpenLockDC
            '
            Me.lblOpenLockDC.Enabled = False
            Me.lblOpenLockDC.Location = New System.Drawing.Point(48, 203)
            Me.lblOpenLockDC.Name = "lblOpenLockDC"
            Me.lblOpenLockDC.Size = New System.Drawing.Size(88, 19)
            Me.lblOpenLockDC.TabIndex = 15
            Me.lblOpenLockDC.Text = "Open Lock DC"
            Me.lblOpenLockDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbLockable
            '
            Me.chkbLockable.Location = New System.Drawing.Point(48, 76)
            Me.chkbLockable.Name = "chkbLockable"
            Me.chkbLockable.Size = New System.Drawing.Size(112, 28)
            Me.chkbLockable.TabIndex = 1
            Me.chkbLockable.Text = "Can be relocked"
            '
            'chkbLocked
            '
            Me.chkbLocked.Location = New System.Drawing.Point(48, 37)
            Me.chkbLocked.Name = "chkbLocked"
            Me.chkbLocked.Size = New System.Drawing.Size(72, 28)
            Me.chkbLocked.TabIndex = 0
            Me.chkbLocked.Text = "Locked"
            '
            'chkbKeyRequired
            '
            Me.chkbKeyRequired.Enabled = False
            Me.chkbKeyRequired.Location = New System.Drawing.Point(48, 155)
            Me.chkbKeyRequired.Name = "chkbKeyRequired"
            Me.chkbKeyRequired.Size = New System.Drawing.Size(184, 27)
            Me.chkbKeyRequired.TabIndex = 3
            Me.chkbKeyRequired.Text = "Key required to unlock or lock"
            '
            'chkbAutoRemoveKey
            '
            Me.chkbAutoRemoveKey.Enabled = False
            Me.chkbAutoRemoveKey.Location = New System.Drawing.Point(48, 115)
            Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
            Me.chkbAutoRemoveKey.Size = New System.Drawing.Size(200, 28)
            Me.chkbAutoRemoveKey.TabIndex = 2
            Me.chkbAutoRemoveKey.Text = "Automatically remove key after use"
            '
            'TabPageAdvanced
            '
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
            Me.TabPageAdvanced.Location = New System.Drawing.Point(4, 40)
            Me.TabPageAdvanced.Name = "TabPageAdvanced"
            Me.TabPageAdvanced.Size = New System.Drawing.Size(448, 488)
            Me.TabPageAdvanced.TabIndex = 5
            Me.TabPageAdvanced.Text = "Advanced"
            Me.TabPageAdvanced.Visible = False
            '
            'chkbPartyInteract
            '
            Me.chkbPartyInteract.Location = New System.Drawing.Point(168, 277)
            Me.chkbPartyInteract.Name = "chkbPartyInteract"
            Me.chkbPartyInteract.Size = New System.Drawing.Size(184, 28)
            Me.chkbPartyInteract.TabIndex = 6
            Me.chkbPartyInteract.Text = "Party Interact"
            '
            'chkbHasInventory
            '
            Me.chkbHasInventory.Location = New System.Drawing.Point(168, 240)
            Me.chkbHasInventory.Name = "chkbHasInventory"
            Me.chkbHasInventory.Size = New System.Drawing.Size(184, 28)
            Me.chkbHasInventory.TabIndex = 5
            Me.chkbHasInventory.Text = "Has Inventory"
            '
            'Label20
            '
            Me.Label20.Location = New System.Drawing.Point(56, 203)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(48, 19)
            Me.Label20.TabIndex = 5
            Me.Label20.Text = "Type"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbType
            '
            Me.tbType.Location = New System.Drawing.Point(168, 203)
            Me.tbType.Name = "tbType"
            Me.tbType.Size = New System.Drawing.Size(72, 22)
            Me.tbType.TabIndex = 4
            '
            'chkbInterruptable
            '
            Me.chkbInterruptable.Location = New System.Drawing.Point(352, 129)
            Me.chkbInterruptable.Name = "chkbInterruptable"
            Me.chkbInterruptable.Size = New System.Drawing.Size(88, 28)
            Me.chkbInterruptable.TabIndex = 2
            Me.chkbInterruptable.Text = "Interruptable"
            '
            'tbConversation
            '
            Me.tbConversation.Location = New System.Drawing.Point(168, 129)
            Me.tbConversation.Name = "tbConversation"
            Me.tbConversation.Size = New System.Drawing.Size(168, 22)
            Me.tbConversation.TabIndex = 1
            '
            'tbFaction
            '
            Me.tbFaction.Location = New System.Drawing.Point(168, 92)
            Me.tbFaction.Name = "tbFaction"
            Me.tbFaction.Size = New System.Drawing.Size(30, 22)
            Me.tbFaction.TabIndex = 0
            '
            'tbTemplateResRef
            '
            Me.tbTemplateResRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbTemplateResRef.Location = New System.Drawing.Point(168, 37)
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Me.tbTemplateResRef.Size = New System.Drawing.Size(200, 22)
            Me.tbTemplateResRef.TabIndex = 3
            '
            'Label10
            '
            Me.Label10.Location = New System.Drawing.Point(52, 37)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(100, 18)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Template ResRef"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label11
            '
            Me.Label11.Location = New System.Drawing.Point(56, 92)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(100, 19)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Faction"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label13
            '
            Me.Label13.Location = New System.Drawing.Point(56, 129)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(100, 19)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Conversation"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label14
            '
            Me.Label14.Location = New System.Drawing.Point(56, 166)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(100, 19)
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Animation State"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbAnimationState
            '
            Me.tbAnimationState.Location = New System.Drawing.Point(168, 166)
            Me.tbAnimationState.Name = "tbAnimationState"
            Me.tbAnimationState.Size = New System.Drawing.Size(32, 22)
            Me.tbAnimationState.TabIndex = 3
            '
            'chkbUsable
            '
            Me.chkbUsable.Location = New System.Drawing.Point(168, 314)
            Me.chkbUsable.Name = "chkbUsable"
            Me.chkbUsable.Size = New System.Drawing.Size(184, 28)
            Me.chkbUsable.TabIndex = 6
            Me.chkbUsable.Text = "Usable"
            '
            'TabPageScripts
            '
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
            Me.TabPageScripts.Location = New System.Drawing.Point(4, 40)
            Me.TabPageScripts.Name = "TabPageScripts"
            Me.TabPageScripts.Size = New System.Drawing.Size(448, 488)
            Me.TabPageScripts.TabIndex = 4
            Me.TabPageScripts.Text = "Scripts"
            Me.TabPageScripts.Visible = False
            '
            'btnEditOnUserDefined
            '
            Me.btnEditOnUserDefined.Location = New System.Drawing.Point(384, 438)
            Me.btnEditOnUserDefined.Name = "btnEditOnUserDefined"
            Me.btnEditOnUserDefined.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnUserDefined.TabIndex = 29
            Me.btnEditOnUserDefined.Text = "Edit"
            Me.btnEditOnUserDefined.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnUnlock
            '
            Me.btnEditOnUnlock.Location = New System.Drawing.Point(384, 378)
            Me.btnEditOnUnlock.Name = "btnEditOnUnlock"
            Me.btnEditOnUnlock.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnUnlock.TabIndex = 25
            Me.btnEditOnUnlock.Text = "Edit"
            Me.btnEditOnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnSpellCastAt
            '
            Me.btnEditOnSpellCastAt.Location = New System.Drawing.Point(384, 318)
            Me.btnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt"
            Me.btnEditOnSpellCastAt.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnSpellCastAt.TabIndex = 21
            Me.btnEditOnSpellCastAt.Text = "Edit"
            Me.btnEditOnSpellCastAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnTrapTriggered
            '
            Me.btnEditOnTrapTriggered.Location = New System.Drawing.Point(384, 348)
            Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
            Me.btnEditOnTrapTriggered.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnTrapTriggered.TabIndex = 23
            Me.btnEditOnTrapTriggered.Text = "Edit"
            Me.btnEditOnTrapTriggered.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnMeleeAttacked
            '
            Me.btnEditOnMeleeAttacked.Location = New System.Drawing.Point(384, 258)
            Me.btnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked"
            Me.btnEditOnMeleeAttacked.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnMeleeAttacked.TabIndex = 17
            Me.btnEditOnMeleeAttacked.Text = "Edit"
            Me.btnEditOnMeleeAttacked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnOpen
            '
            Me.btnEditOnOpen.Location = New System.Drawing.Point(384, 288)
            Me.btnEditOnOpen.Name = "btnEditOnOpen"
            Me.btnEditOnOpen.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnOpen.TabIndex = 19
            Me.btnEditOnOpen.Text = "Edit"
            Me.btnEditOnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnLock
            '
            Me.btnEditOnLock.Location = New System.Drawing.Point(384, 228)
            Me.btnEditOnLock.Name = "btnEditOnLock"
            Me.btnEditOnLock.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnLock.TabIndex = 15
            Me.btnEditOnLock.Text = "Edit"
            Me.btnEditOnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnHeartbeat
            '
            Me.btnEditOnHeartbeat.Location = New System.Drawing.Point(384, 168)
            Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
            Me.btnEditOnHeartbeat.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnHeartbeat.TabIndex = 11
            Me.btnEditOnHeartbeat.Text = "Edit"
            Me.btnEditOnHeartbeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnDeath
            '
            Me.btnEditOnDeath.Location = New System.Drawing.Point(384, 78)
            Me.btnEditOnDeath.Name = "btnEditOnDeath"
            Me.btnEditOnDeath.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnDeath.TabIndex = 5
            Me.btnEditOnDeath.Text = "Edit"
            Me.btnEditOnDeath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnDisarm
            '
            Me.btnEditOnDisarm.Location = New System.Drawing.Point(384, 108)
            Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
            Me.btnEditOnDisarm.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnDisarm.TabIndex = 7
            Me.btnEditOnDisarm.Text = "Edit"
            Me.btnEditOnDisarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnDamaged
            '
            Me.btnEditOnDamaged.Location = New System.Drawing.Point(384, 48)
            Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
            Me.btnEditOnDamaged.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnDamaged.TabIndex = 3
            Me.btnEditOnDamaged.Text = "Edit"
            Me.btnEditOnDamaged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnClosed
            '
            Me.btnEditOnClosed.Location = New System.Drawing.Point(384, 18)
            Me.btnEditOnClosed.Name = "btnEditOnClosed"
            Me.btnEditOnClosed.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnClosed.TabIndex = 1
            Me.btnEditOnClosed.Text = "Edit"
            Me.btnEditOnClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnUsed
            '
            Me.tbOnUsed.Location = New System.Drawing.Point(160, 408)
            Me.tbOnUsed.Name = "tbOnUsed"
            Me.tbOnUsed.Size = New System.Drawing.Size(204, 22)
            Me.tbOnUsed.TabIndex = 26
            '
            'Label18
            '
            Me.Label18.Location = New System.Drawing.Point(40, 408)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(112, 21)
            Me.Label18.TabIndex = 30
            Me.Label18.Text = "OnUsed"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label34
            '
            Me.Label34.Location = New System.Drawing.Point(40, 78)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(112, 21)
            Me.Label34.TabIndex = 27
            Me.Label34.Text = "OnDeath"
            Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDeath
            '
            Me.tbOnDeath.Location = New System.Drawing.Point(160, 78)
            Me.tbOnDeath.Name = "tbOnDeath"
            Me.tbOnDeath.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDeath.TabIndex = 4
            '
            'Label33
            '
            Me.Label33.Location = New System.Drawing.Point(40, 48)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(112, 21)
            Me.Label33.TabIndex = 17
            Me.Label33.Text = "OnDamaged"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDamaged
            '
            Me.tbOnDamaged.Location = New System.Drawing.Point(160, 48)
            Me.tbOnDamaged.Name = "tbOnDamaged"
            Me.tbOnDamaged.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDamaged.TabIndex = 2
            '
            'Label32
            '
            Me.Label32.Location = New System.Drawing.Point(40, 18)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(112, 21)
            Me.Label32.TabIndex = 14
            Me.Label32.Text = "OnClosed"
            Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnClosed
            '
            Me.tbOnClosed.Location = New System.Drawing.Point(160, 18)
            Me.tbOnClosed.Name = "tbOnClosed"
            Me.tbOnClosed.Size = New System.Drawing.Size(204, 22)
            Me.tbOnClosed.TabIndex = 0
            '
            'Label35
            '
            Me.Label35.Location = New System.Drawing.Point(40, 108)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(112, 21)
            Me.Label35.TabIndex = 26
            Me.Label35.Text = "OnDisarm"
            Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDisarm
            '
            Me.tbOnDisarm.Location = New System.Drawing.Point(160, 108)
            Me.tbOnDisarm.Name = "tbOnDisarm"
            Me.tbOnDisarm.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDisarm.TabIndex = 6
            '
            'tbOnHeartbeat
            '
            Me.tbOnHeartbeat.Location = New System.Drawing.Point(160, 168)
            Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
            Me.tbOnHeartbeat.Size = New System.Drawing.Size(204, 22)
            Me.tbOnHeartbeat.TabIndex = 10
            '
            'Label36
            '
            Me.Label36.Location = New System.Drawing.Point(40, 168)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(112, 21)
            Me.Label36.TabIndex = 25
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label37
            '
            Me.Label37.Location = New System.Drawing.Point(40, 228)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(112, 21)
            Me.Label37.TabIndex = 28
            Me.Label37.Text = "OnLock"
            Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnLock
            '
            Me.tbOnLock.Location = New System.Drawing.Point(160, 228)
            Me.tbOnLock.Name = "tbOnLock"
            Me.tbOnLock.Size = New System.Drawing.Size(204, 22)
            Me.tbOnLock.TabIndex = 14
            '
            'tbOnMeleeAttacked
            '
            Me.tbOnMeleeAttacked.Location = New System.Drawing.Point(160, 258)
            Me.tbOnMeleeAttacked.Name = "tbOnMeleeAttacked"
            Me.tbOnMeleeAttacked.Size = New System.Drawing.Size(204, 22)
            Me.tbOnMeleeAttacked.TabIndex = 16
            '
            'Label38
            '
            Me.Label38.Location = New System.Drawing.Point(40, 258)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(112, 21)
            Me.Label38.TabIndex = 20
            Me.Label38.Text = "OnMeleeAttacked"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnOpen
            '
            Me.tbOnOpen.Location = New System.Drawing.Point(160, 288)
            Me.tbOnOpen.Name = "tbOnOpen"
            Me.tbOnOpen.Size = New System.Drawing.Size(204, 22)
            Me.tbOnOpen.TabIndex = 18
            '
            'Label39
            '
            Me.Label39.Location = New System.Drawing.Point(40, 288)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(112, 21)
            Me.Label39.TabIndex = 21
            Me.Label39.Text = "OnOpen"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label40
            '
            Me.Label40.Location = New System.Drawing.Point(40, 318)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(112, 21)
            Me.Label40.TabIndex = 19
            Me.Label40.Text = "OnSpellCastAt"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnSpellCastAt
            '
            Me.tbOnSpellCastAt.Location = New System.Drawing.Point(160, 318)
            Me.tbOnSpellCastAt.Name = "tbOnSpellCastAt"
            Me.tbOnSpellCastAt.Size = New System.Drawing.Size(204, 22)
            Me.tbOnSpellCastAt.TabIndex = 20
            '
            'Label41
            '
            Me.Label41.Location = New System.Drawing.Point(40, 348)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(112, 21)
            Me.Label41.TabIndex = 24
            Me.Label41.Text = "OnTrapTriggered"
            Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnTrapTriggered
            '
            Me.tbOnTrapTriggered.Location = New System.Drawing.Point(160, 348)
            Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
            Me.tbOnTrapTriggered.Size = New System.Drawing.Size(204, 22)
            Me.tbOnTrapTriggered.TabIndex = 22
            '
            'tbOnUnlock
            '
            Me.tbOnUnlock.Location = New System.Drawing.Point(160, 378)
            Me.tbOnUnlock.Name = "tbOnUnlock"
            Me.tbOnUnlock.Size = New System.Drawing.Size(204, 22)
            Me.tbOnUnlock.TabIndex = 24
            '
            'Label42
            '
            Me.Label42.Location = New System.Drawing.Point(40, 378)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(112, 21)
            Me.Label42.TabIndex = 23
            Me.Label42.Text = "OnUnlock"
            Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnUserDefined
            '
            Me.tbOnUserDefined.Location = New System.Drawing.Point(160, 438)
            Me.tbOnUserDefined.Name = "tbOnUserDefined"
            Me.tbOnUserDefined.Size = New System.Drawing.Size(204, 22)
            Me.tbOnUserDefined.TabIndex = 28
            '
            'Label43
            '
            Me.Label43.Location = New System.Drawing.Point(40, 438)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(112, 21)
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUserDefined"
            Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label21
            '
            Me.Label21.Location = New System.Drawing.Point(40, 138)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(112, 21)
            Me.Label21.TabIndex = 30
            Me.Label21.Text = "OnEndDialogue"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnEndDialogue
            '
            Me.tbOnEndDialogue.Location = New System.Drawing.Point(160, 138)
            Me.tbOnEndDialogue.Name = "tbOnEndDialogue"
            Me.tbOnEndDialogue.Size = New System.Drawing.Size(204, 22)
            Me.tbOnEndDialogue.TabIndex = 8
            '
            'tbOnInvDisturbed
            '
            Me.tbOnInvDisturbed.Location = New System.Drawing.Point(160, 198)
            Me.tbOnInvDisturbed.Name = "tbOnInvDisturbed"
            Me.tbOnInvDisturbed.Size = New System.Drawing.Size(204, 22)
            Me.tbOnInvDisturbed.TabIndex = 12
            '
            'Label22
            '
            Me.Label22.Location = New System.Drawing.Point(40, 198)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(112, 21)
            Me.Label22.TabIndex = 30
            Me.Label22.Text = "OnInvDisturbed"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnUsed
            '
            Me.btnEditOnUsed.Location = New System.Drawing.Point(384, 408)
            Me.btnEditOnUsed.Name = "btnEditOnUsed"
            Me.btnEditOnUsed.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnUsed.TabIndex = 27
            Me.btnEditOnUsed.Text = "Edit"
            Me.btnEditOnUsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnInvDisturbed
            '
            Me.btnEditOnInvDisturbed.Location = New System.Drawing.Point(384, 198)
            Me.btnEditOnInvDisturbed.Name = "btnEditOnInvDisturbed"
            Me.btnEditOnInvDisturbed.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnInvDisturbed.TabIndex = 13
            Me.btnEditOnInvDisturbed.Text = "Edit"
            Me.btnEditOnInvDisturbed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnEndDialogue
            '
            Me.btnEditOnEndDialogue.Location = New System.Drawing.Point(384, 138)
            Me.btnEditOnEndDialogue.Name = "btnEditOnEndDialogue"
            Me.btnEditOnEndDialogue.Size = New System.Drawing.Size(32, 27)
            Me.btnEditOnEndDialogue.TabIndex = 9
            Me.btnEditOnEndDialogue.Text = "Edit"
            Me.btnEditOnEndDialogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TabPageDescription
            '
            Me.TabPageDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.TabPageDescription.Controls.Add(Me.tbDescription)
            Me.TabPageDescription.Location = New System.Drawing.Point(4, 40)
            Me.TabPageDescription.Name = "TabPageDescription"
            Me.TabPageDescription.Size = New System.Drawing.Size(448, 488)
            Me.TabPageDescription.TabIndex = 6
            Me.TabPageDescription.Text = "Description"
            Me.TabPageDescription.Visible = False
            '
            'btnSetDescriptionLang
            '
            Me.btnSetDescriptionLang.Location = New System.Drawing.Point(40, 369)
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Me.btnSetDescriptionLang.Size = New System.Drawing.Size(88, 27)
            Me.btnSetDescriptionLang.TabIndex = 1
            Me.btnSetDescriptionLang.Text = "Set Language"
            '
            'tbDescription
            '
            Me.tbDescription.Location = New System.Drawing.Point(12, 8)
            Me.tbDescription.Multiline = True
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Size = New System.Drawing.Size(424, 352)
            Me.tbDescription.TabIndex = 0
            '
            'TabPageComments
            '
            Me.TabPageComments.Controls.Add(Me.tbComment)
            Me.TabPageComments.Location = New System.Drawing.Point(4, 40)
            Me.TabPageComments.Name = "TabPageComments"
            Me.TabPageComments.Size = New System.Drawing.Size(448, 488)
            Me.TabPageComments.TabIndex = 7
            Me.TabPageComments.Text = "Comments"
            Me.TabPageComments.Visible = False
            '
            'tbComment
            '
            Me.tbComment.Location = New System.Drawing.Point(12, 8)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New System.Drawing.Size(424, 388)
            Me.tbComment.TabIndex = 0
            '
            'TabPageTrap
            '
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
            Me.TabPageTrap.Location = New System.Drawing.Point(4, 40)
            Me.TabPageTrap.Name = "TabPageTrap"
            Me.TabPageTrap.Size = New System.Drawing.Size(448, 488)
            Me.TabPageTrap.TabIndex = 10
            Me.TabPageTrap.Text = "Trap"
            '
            'chkbTrapDisarmable
            '
            Me.chkbTrapDisarmable.Location = New System.Drawing.Point(192, 98)
            Me.chkbTrapDisarmable.Name = "chkbTrapDisarmable"
            Me.chkbTrapDisarmable.Size = New System.Drawing.Size(24, 28)
            Me.chkbTrapDisarmable.TabIndex = 2
            '
            'chkbTrapDetectable
            '
            Me.chkbTrapDetectable.Location = New System.Drawing.Point(192, 24)
            Me.chkbTrapDetectable.Name = "chkbTrapDetectable"
            Me.chkbTrapDetectable.Size = New System.Drawing.Size(24, 28)
            Me.chkbTrapDetectable.TabIndex = 0
            '
            'Label6
            '
            Me.Label6.Location = New System.Drawing.Point(48, 212)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(88, 19)
            Me.Label6.TabIndex = 26
            Me.Label6.Text = "TrapOneShot"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.Location = New System.Drawing.Point(48, 175)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(88, 19)
            Me.Label3.TabIndex = 27
            Me.Label3.Text = "TrapFlag"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudDisarmDC
            '
            Me.nudDisarmDC.Location = New System.Drawing.Point(176, 138)
            Me.nudDisarmDC.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudDisarmDC.Name = "nudDisarmDC"
            Me.nudDisarmDC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudDisarmDC.Size = New System.Drawing.Size(48, 22)
            Me.nudDisarmDC.TabIndex = 3
            Me.nudDisarmDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.Location = New System.Drawing.Point(48, 138)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 19)
            Me.Label4.TabIndex = 22
            Me.Label4.Text = "DisarmDC"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label15
            '
            Me.Label15.Location = New System.Drawing.Point(48, 102)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(88, 18)
            Me.Label15.TabIndex = 23
            Me.Label15.Text = "TrapDisarmable"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudTrapDetectDC
            '
            Me.nudTrapDetectDC.Location = New System.Drawing.Point(176, 65)
            Me.nudTrapDetectDC.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudTrapDetectDC.Name = "nudTrapDetectDC"
            Me.nudTrapDetectDC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudTrapDetectDC.Size = New System.Drawing.Size(48, 22)
            Me.nudTrapDetectDC.TabIndex = 1
            Me.nudTrapDetectDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label16
            '
            Me.Label16.Location = New System.Drawing.Point(48, 65)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(88, 18)
            Me.Label16.TabIndex = 18
            Me.Label16.Text = "TrapDetectDC"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTrapDetectable
            '
            Me.lblTrapDetectable.Location = New System.Drawing.Point(48, 28)
            Me.lblTrapDetectable.Name = "lblTrapDetectable"
            Me.lblTrapDetectable.Size = New System.Drawing.Size(88, 18)
            Me.lblTrapDetectable.TabIndex = 19
            Me.lblTrapDetectable.Text = "TrapDetectable"
            Me.lblTrapDetectable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudTrapType
            '
            Me.nudTrapType.Location = New System.Drawing.Point(176, 249)
            Me.nudTrapType.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.nudTrapType.Name = "nudTrapType"
            Me.nudTrapType.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudTrapType.Size = New System.Drawing.Size(48, 22)
            Me.nudTrapType.TabIndex = 6
            Me.nudTrapType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label17
            '
            Me.Label17.Location = New System.Drawing.Point(48, 249)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(88, 19)
            Me.Label17.TabIndex = 26
            Me.Label17.Text = "TrapType"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbTrapFlag
            '
            Me.chkbTrapFlag.Location = New System.Drawing.Point(192, 175)
            Me.chkbTrapFlag.Name = "chkbTrapFlag"
            Me.chkbTrapFlag.Size = New System.Drawing.Size(24, 28)
            Me.chkbTrapFlag.TabIndex = 4
            '
            'chkbTrapOneShot
            '
            Me.chkbTrapOneShot.Location = New System.Drawing.Point(192, 212)
            Me.chkbTrapOneShot.Name = "chkbTrapOneShot"
            Me.chkbTrapOneShot.Size = New System.Drawing.Size(24, 28)
            Me.chkbTrapOneShot.TabIndex = 5
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.Location = New System.Drawing.Point(312, 474)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 26)
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "&Save"
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.Location = New System.Drawing.Point(408, 474)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 26)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "&Cancel"
            '
            'btnInventory
            '
            Me.btnInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnInventory.Location = New System.Drawing.Point(64, 474)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New System.Drawing.Size(72, 28)
            Me.btnInventory.TabIndex = 9
            Me.btnInventory.Text = "&Inventory"
            '
            'btnDebug
            '
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 10)
            Me.btnDebug.TabIndex = 19
            Me.btnDebug.TabStop = False
            '
            'frmUTP_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.ClientSize = New System.Drawing.Size(496, 517)
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnInventory)
            Me.Name = "frmUTP_Editor"
            Me.Text = "Placeable Editor - KotOR "
            Me.TabControl1.ResumeLayout(False)
            Me.TabPageBasic.ResumeLayout(False)
            Me.TabPageBasic.PerformLayout()
            CType(Me.nudWill, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFort, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudHP, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudHardness, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRef, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPageLock.ResumeLayout(False)
            Me.TabPageLock.PerformLayout()
            CType(Me.nudCloseLockDC, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudOpenLockDC, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPageAdvanced.ResumeLayout(False)
            Me.TabPageAdvanced.PerformLayout()
            Me.TabPageScripts.ResumeLayout(False)
            Me.TabPageScripts.PerformLayout()
            Me.TabPageDescription.ResumeLayout(False)
            Me.TabPageDescription.PerformLayout()
            Me.TabPageComments.ResumeLayout(False)
            Me.TabPageComments.PerformLayout()
            Me.TabPageTrap.ResumeLayout(False)
            CType(Me.nudDisarmDC, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTrapDetectDC, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTrapType, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
