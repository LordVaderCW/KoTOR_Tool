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
            Me.TabControl1.Location = New Global.System.Drawing.Point(19, 11)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New Global.System.Drawing.Point(15, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(456, 461)
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
            Me.TabPageBasic.Location = New Global.System.Drawing.Point(4, 40)
            Me.TabPageBasic.Name = "TabPageBasic"
            Me.TabPageBasic.Size = New Global.System.Drawing.Size(448, 393)
            Me.TabPageBasic.TabIndex = 0
            Me.TabPageBasic.Text = "Basic"
            Me.Label19.Location = New Global.System.Drawing.Point(48, 80)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label19.TabIndex = 10
            Me.Label19.Text = "Appearance"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxAppearance.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxAppearance.Location = New Global.System.Drawing.Point(128, 80)
            Me.cmbxAppearance.Name = "cmbxAppearance"
            Me.cmbxAppearance.Size = New Global.System.Drawing.Size(184, 21)
            Me.cmbxAppearance.TabIndex = 3
            Me.btnSetNameLang.Location = New Global.System.Drawing.Point(344, 32)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetNameLang.TabIndex = 1
            Me.btnSetNameLang.Text = "Set Language"
            Me.Label5.Location = New Global.System.Drawing.Point(48, 200)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Fortitude Save"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudWill.Location = New Global.System.Drawing.Point(192, 248)
            Me.nudWill.Name = "nudWill"
            Me.nudWill.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudWill.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudWill.TabIndex = 11
            Me.nudWill.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFort.Location = New Global.System.Drawing.Point(192, 200)
            Me.nudFort.Name = "nudFort"
            Me.nudFort.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudFort.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudFort.TabIndex = 9
            Me.nudFort.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudHP.Location = New Global.System.Drawing.Point(192, 176)
            Me.nudHP.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudHP.Name = "nudHP"
            Me.nudHP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudHP.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudHP.TabIndex = 8
            Me.nudHP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblTextureVariation.Location = New Global.System.Drawing.Point(48, 248)
            Me.lblTextureVariation.Name = "lblTextureVariation"
            Me.lblTextureVariation.Size = New Global.System.Drawing.Size(96, 16)
            Me.lblTextureVariation.TabIndex = 5
            Me.lblTextureVariation.Text = "Will Save"
            Me.lblTextureVariation.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label8.Location = New Global.System.Drawing.Point(48, 176)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Hit Points"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudHardness.Location = New Global.System.Drawing.Point(192, 152)
            Me.nudHardness.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudHardness.Name = "nudHardness"
            Me.nudHardness.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudHardness.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudHardness.TabIndex = 7
            Me.nudHardness.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudRef.Location = New Global.System.Drawing.Point(192, 224)
            Me.nudRef.Name = "nudRef"
            Me.nudRef.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudRef.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudRef.TabIndex = 10
            Me.nudRef.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label12.Location = New Global.System.Drawing.Point(48, 152)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label12.TabIndex = 7
            Me.Label12.Text = "Hardness"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblBodyVariation.Location = New Global.System.Drawing.Point(48, 224)
            Me.lblBodyVariation.Name = "lblBodyVariation"
            Me.lblBodyVariation.Size = New Global.System.Drawing.Size(88, 16)
            Me.lblBodyVariation.TabIndex = 6
            Me.lblBodyVariation.Text = "Reflex Save"
            Me.lblBodyVariation.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbPlotItem.Location = New Global.System.Drawing.Point(48, 112)
            Me.chkbPlotItem.Name = "chkbPlotItem"
            Me.chkbPlotItem.Size = New Global.System.Drawing.Size(72, 24)
            Me.chkbPlotItem.TabIndex = 4
            Me.chkbPlotItem.Text = "Plot item"
            Me.tbTag.Location = New Global.System.Drawing.Point(128, 56)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbTag.TabIndex = 2
            Me.tbTag.Text = ""
            Me.tbName.Location = New Global.System.Drawing.Point(128, 32)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbName.TabIndex = 0
            Me.tbName.Text = ""
            Me.Label1.Location = New Global.System.Drawing.Point(48, 32)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Name"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label2.Location = New Global.System.Drawing.Point(48, 56)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbStatic.Location = New Global.System.Drawing.Point(192, 112)
            Me.chkbStatic.Name = "chkbStatic"
            Me.chkbStatic.Size = New Global.System.Drawing.Size(72, 24)
            Me.chkbStatic.TabIndex = 5
            Me.chkbStatic.Text = "Static"
            Me.chkbMin1HP.Location = New Global.System.Drawing.Point(296, 112)
            Me.chkbMin1HP.Name = "chkbMin1HP"
            Me.chkbMin1HP.Size = New Global.System.Drawing.Size(72, 24)
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
            Me.TabPageLock.Location = New Global.System.Drawing.Point(4, 40)
            Me.TabPageLock.Name = "TabPageLock"
            Me.TabPageLock.Size = New Global.System.Drawing.Size(448, 393)
            Me.TabPageLock.TabIndex = 1
            Me.TabPageLock.Text = "Lock"
            Me.TabPageLock.Visible = False
            Me.tbKeyName.Enabled = False
            Me.tbKeyName.Location = New Global.System.Drawing.Point(176, 256)
            Me.tbKeyName.Name = "tbKeyName"
            Me.tbKeyName.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbKeyName.TabIndex = 6
            Me.tbKeyName.Text = ""
            Me.lblKeyTag.Enabled = False
            Me.lblKeyTag.Location = New Global.System.Drawing.Point(52, 256)
            Me.lblKeyTag.Name = "lblKeyTag"
            Me.lblKeyTag.Size = New Global.System.Drawing.Size(100, 16)
            Me.lblKeyTag.TabIndex = 18
            Me.lblKeyTag.Text = "Key Tag"
            Me.lblKeyTag.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudCloseLockDC.Enabled = False
            Me.nudCloseLockDC.Location = New Global.System.Drawing.Point(176, 216)
            Me.nudCloseLockDC.Name = "nudCloseLockDC"
            Me.nudCloseLockDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudCloseLockDC.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudCloseLockDC.TabIndex = 5
            Me.nudCloseLockDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblCloseLockDC.Enabled = False
            Me.lblCloseLockDC.Location = New Global.System.Drawing.Point(48, 216)
            Me.lblCloseLockDC.Name = "lblCloseLockDC"
            Me.lblCloseLockDC.Size = New Global.System.Drawing.Size(88, 16)
            Me.lblCloseLockDC.TabIndex = 14
            Me.lblCloseLockDC.Text = "Close Lock DC"
            Me.lblCloseLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudOpenLockDC.Enabled = False
            Me.nudOpenLockDC.Location = New Global.System.Drawing.Point(176, 176)
            Me.nudOpenLockDC.Name = "nudOpenLockDC"
            Me.nudOpenLockDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudOpenLockDC.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudOpenLockDC.TabIndex = 4
            Me.nudOpenLockDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblOpenLockDC.Enabled = False
            Me.lblOpenLockDC.Location = New Global.System.Drawing.Point(48, 176)
            Me.lblOpenLockDC.Name = "lblOpenLockDC"
            Me.lblOpenLockDC.Size = New Global.System.Drawing.Size(88, 16)
            Me.lblOpenLockDC.TabIndex = 15
            Me.lblOpenLockDC.Text = "Open Lock DC"
            Me.lblOpenLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbLockable.Location = New Global.System.Drawing.Point(48, 66)
            Me.chkbLockable.Name = "chkbLockable"
            Me.chkbLockable.Size = New Global.System.Drawing.Size(112, 24)
            Me.chkbLockable.TabIndex = 1
            Me.chkbLockable.Text = "Can be relocked"
            Me.chkbLocked.Location = New Global.System.Drawing.Point(48, 32)
            Me.chkbLocked.Name = "chkbLocked"
            Me.chkbLocked.Size = New Global.System.Drawing.Size(72, 24)
            Me.chkbLocked.TabIndex = 0
            Me.chkbLocked.Text = "Locked"
            Me.chkbKeyRequired.Enabled = False
            Me.chkbKeyRequired.Location = New Global.System.Drawing.Point(48, 134)
            Me.chkbKeyRequired.Name = "chkbKeyRequired"
            Me.chkbKeyRequired.Size = New Global.System.Drawing.Size(184, 24)
            Me.chkbKeyRequired.TabIndex = 3
            Me.chkbKeyRequired.Text = "Key required to unlock or lock"
            Me.chkbAutoRemoveKey.Enabled = False
            Me.chkbAutoRemoveKey.Location = New Global.System.Drawing.Point(48, 100)
            Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
            Me.chkbAutoRemoveKey.Size = New Global.System.Drawing.Size(200, 24)
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
            Me.TabPageAdvanced.Location = New Global.System.Drawing.Point(4, 40)
            Me.TabPageAdvanced.Name = "TabPageAdvanced"
            Me.TabPageAdvanced.Size = New Global.System.Drawing.Size(448, 393)
            Me.TabPageAdvanced.TabIndex = 5
            Me.TabPageAdvanced.Text = "Advanced"
            Me.TabPageAdvanced.Visible = False
            Me.chkbPartyInteract.Location = New Global.System.Drawing.Point(168, 240)
            Me.chkbPartyInteract.Name = "chkbPartyInteract"
            Me.chkbPartyInteract.Size = New Global.System.Drawing.Size(184, 24)
            Me.chkbPartyInteract.TabIndex = 6
            Me.chkbPartyInteract.Text = "Party Interact"
            Me.chkbHasInventory.Location = New Global.System.Drawing.Point(168, 208)
            Me.chkbHasInventory.Name = "chkbHasInventory"
            Me.chkbHasInventory.Size = New Global.System.Drawing.Size(184, 24)
            Me.chkbHasInventory.TabIndex = 5
            Me.chkbHasInventory.Text = "Has Inventory"
            Me.Label20.Location = New Global.System.Drawing.Point(56, 176)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label20.TabIndex = 5
            Me.Label20.Text = "Type"
            Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbType.Location = New Global.System.Drawing.Point(168, 176)
            Me.tbType.Name = "tbType"
            Me.tbType.Size = New Global.System.Drawing.Size(72, 20)
            Me.tbType.TabIndex = 4
            Me.tbType.Text = ""
            Me.chkbInterruptable.Location = New Global.System.Drawing.Point(352, 112)
            Me.chkbInterruptable.Name = "chkbInterruptable"
            Me.chkbInterruptable.Size = New Global.System.Drawing.Size(88, 24)
            Me.chkbInterruptable.TabIndex = 2
            Me.chkbInterruptable.Text = "Interruptable"
            Me.tbConversation.Location = New Global.System.Drawing.Point(168, 112)
            Me.tbConversation.Name = "tbConversation"
            Me.tbConversation.Size = New Global.System.Drawing.Size(168, 20)
            Me.tbConversation.TabIndex = 1
            Me.tbConversation.Text = ""
            Me.tbFaction.Location = New Global.System.Drawing.Point(168, 80)
            Me.tbFaction.Name = "tbFaction"
            Me.tbFaction.Size = New Global.System.Drawing.Size(30, 20)
            Me.tbFaction.TabIndex = 0
            Me.tbFaction.Text = ""
            Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbTemplateResRef.Location = New Global.System.Drawing.Point(168, 32)
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Me.tbTemplateResRef.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbTemplateResRef.TabIndex = 3
            Me.tbTemplateResRef.Text = ""
            Me.Label10.Location = New Global.System.Drawing.Point(52, 32)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Template ResRef"
            Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label11.Location = New Global.System.Drawing.Point(56, 80)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Faction"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label13.Location = New Global.System.Drawing.Point(56, 112)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Conversation"
            Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label14.Location = New Global.System.Drawing.Point(56, 144)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Animation State"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbAnimationState.Location = New Global.System.Drawing.Point(168, 144)
            Me.tbAnimationState.Name = "tbAnimationState"
            Me.tbAnimationState.Size = New Global.System.Drawing.Size(32, 20)
            Me.tbAnimationState.TabIndex = 3
            Me.tbAnimationState.Text = ""
            Me.chkbUsable.Location = New Global.System.Drawing.Point(168, 272)
            Me.chkbUsable.Name = "chkbUsable"
            Me.chkbUsable.Size = New Global.System.Drawing.Size(184, 24)
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
            Me.TabPageScripts.Location = New Global.System.Drawing.Point(4, 40)
            Me.TabPageScripts.Name = "TabPageScripts"
            Me.TabPageScripts.Size = New Global.System.Drawing.Size(448, 417)
            Me.TabPageScripts.TabIndex = 4
            Me.TabPageScripts.Text = "Scripts"
            Me.TabPageScripts.Visible = False
            Me.tbOnUsed.Location = New Global.System.Drawing.Point(160, 354)
            Me.tbOnUsed.Name = "tbOnUsed"
            Me.tbOnUsed.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnUsed.TabIndex = 26
            Me.tbOnUsed.Text = ""
            Me.Label18.Location = New Global.System.Drawing.Point(40, 354)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label18.TabIndex = 30
            Me.Label18.Text = "OnUsed"
            Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label34.Location = New Global.System.Drawing.Point(40, 68)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label34.TabIndex = 27
            Me.Label34.Text = "OnDeath"
            Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnDeath.Location = New Global.System.Drawing.Point(160, 68)
            Me.tbOnDeath.Name = "tbOnDeath"
            Me.tbOnDeath.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnDeath.TabIndex = 4
            Me.tbOnDeath.Text = ""
            Me.Label33.Location = New Global.System.Drawing.Point(40, 42)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label33.TabIndex = 17
            Me.Label33.Text = "OnDamaged"
            Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnDamaged.Location = New Global.System.Drawing.Point(160, 42)
            Me.tbOnDamaged.Name = "tbOnDamaged"
            Me.tbOnDamaged.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnDamaged.TabIndex = 2
            Me.tbOnDamaged.Text = ""
            Me.Label32.Location = New Global.System.Drawing.Point(40, 16)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label32.TabIndex = 14
            Me.Label32.Text = "OnClosed"
            Me.Label32.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnClosed.Location = New Global.System.Drawing.Point(160, 16)
            Me.tbOnClosed.Name = "tbOnClosed"
            Me.tbOnClosed.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnClosed.TabIndex = 0
            Me.tbOnClosed.Text = ""
            Me.Label35.Location = New Global.System.Drawing.Point(40, 94)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label35.TabIndex = 26
            Me.Label35.Text = "OnDisarm"
            Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnDisarm.Location = New Global.System.Drawing.Point(160, 94)
            Me.tbOnDisarm.Name = "tbOnDisarm"
            Me.tbOnDisarm.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnDisarm.TabIndex = 6
            Me.tbOnDisarm.Text = ""
            Me.tbOnHeartbeat.Location = New Global.System.Drawing.Point(160, 146)
            Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
            Me.tbOnHeartbeat.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnHeartbeat.TabIndex = 10
            Me.tbOnHeartbeat.Text = ""
            Me.Label36.Location = New Global.System.Drawing.Point(40, 146)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label36.TabIndex = 25
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label37.Location = New Global.System.Drawing.Point(40, 198)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label37.TabIndex = 28
            Me.Label37.Text = "OnLock"
            Me.Label37.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnLock.Location = New Global.System.Drawing.Point(160, 198)
            Me.tbOnLock.Name = "tbOnLock"
            Me.tbOnLock.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnLock.TabIndex = 14
            Me.tbOnLock.Text = ""
            Me.tbOnMeleeAttacked.Location = New Global.System.Drawing.Point(160, 224)
            Me.tbOnMeleeAttacked.Name = "tbOnMeleeAttacked"
            Me.tbOnMeleeAttacked.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnMeleeAttacked.TabIndex = 16
            Me.tbOnMeleeAttacked.Text = ""
            Me.Label38.Location = New Global.System.Drawing.Point(40, 224)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label38.TabIndex = 20
            Me.Label38.Text = "OnMeleeAttacked"
            Me.Label38.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnOpen.Location = New Global.System.Drawing.Point(160, 250)
            Me.tbOnOpen.Name = "tbOnOpen"
            Me.tbOnOpen.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnOpen.TabIndex = 18
            Me.tbOnOpen.Text = ""
            Me.Label39.Location = New Global.System.Drawing.Point(40, 250)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label39.TabIndex = 21
            Me.Label39.Text = "OnOpen"
            Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label40.Location = New Global.System.Drawing.Point(40, 276)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label40.TabIndex = 19
            Me.Label40.Text = "OnSpellCastAt"
            Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnSpellCastAt.Location = New Global.System.Drawing.Point(160, 276)
            Me.tbOnSpellCastAt.Name = "tbOnSpellCastAt"
            Me.tbOnSpellCastAt.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnSpellCastAt.TabIndex = 20
            Me.tbOnSpellCastAt.Text = ""
            Me.Label41.Location = New Global.System.Drawing.Point(40, 302)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label41.TabIndex = 24
            Me.Label41.Text = "OnTrapTriggered"
            Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnTrapTriggered.Location = New Global.System.Drawing.Point(160, 302)
            Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
            Me.tbOnTrapTriggered.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnTrapTriggered.TabIndex = 22
            Me.tbOnTrapTriggered.Text = ""
            Me.tbOnUnlock.Location = New Global.System.Drawing.Point(160, 328)
            Me.tbOnUnlock.Name = "tbOnUnlock"
            Me.tbOnUnlock.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnUnlock.TabIndex = 24
            Me.tbOnUnlock.Text = ""
            Me.Label42.Location = New Global.System.Drawing.Point(40, 328)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label42.TabIndex = 23
            Me.Label42.Text = "OnUnlock"
            Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnUserDefined.Location = New Global.System.Drawing.Point(160, 380)
            Me.tbOnUserDefined.Name = "tbOnUserDefined"
            Me.tbOnUserDefined.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnUserDefined.TabIndex = 28
            Me.tbOnUserDefined.Text = ""
            Me.Label43.Location = New Global.System.Drawing.Point(40, 380)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUserDefined"
            Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label21.Location = New Global.System.Drawing.Point(40, 120)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label21.TabIndex = 30
            Me.Label21.Text = "OnEndDialogue"
            Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnEndDialogue.Location = New Global.System.Drawing.Point(160, 120)
            Me.tbOnEndDialogue.Name = "tbOnEndDialogue"
            Me.tbOnEndDialogue.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnEndDialogue.TabIndex = 8
            Me.tbOnEndDialogue.Text = ""
            Me.tbOnInvDisturbed.Location = New Global.System.Drawing.Point(160, 172)
            Me.tbOnInvDisturbed.Name = "tbOnInvDisturbed"
            Me.tbOnInvDisturbed.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnInvDisturbed.TabIndex = 12
            Me.tbOnInvDisturbed.Text = ""
            Me.Label22.Location = New Global.System.Drawing.Point(40, 172)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label22.TabIndex = 30
            Me.Label22.Text = "OnInvDisturbed"
            Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.TabPageDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.TabPageDescription.Controls.Add(Me.tbDescription)
            Me.TabPageDescription.Location = New Global.System.Drawing.Point(4, 40)
            Me.TabPageDescription.Name = "TabPageDescription"
            Me.TabPageDescription.Size = New Global.System.Drawing.Size(448, 393)
            Me.TabPageDescription.TabIndex = 6
            Me.TabPageDescription.Text = "Description"
            Me.TabPageDescription.Visible = False
            Me.btnSetDescriptionLang.Location = New Global.System.Drawing.Point(40, 320)
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Me.btnSetDescriptionLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetDescriptionLang.TabIndex = 1
            Me.btnSetDescriptionLang.Text = "Set Language"
            Me.tbDescription.Location = New Global.System.Drawing.Point(12, 7)
            Me.tbDescription.Multiline = True
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Size = New Global.System.Drawing.Size(424, 305)
            Me.tbDescription.TabIndex = 0
            Me.tbDescription.Text = ""
            Me.TabPageComments.Controls.Add(Me.tbComment)
            Me.TabPageComments.Location = New Global.System.Drawing.Point(4, 40)
            Me.TabPageComments.Name = "TabPageComments"
            Me.TabPageComments.Size = New Global.System.Drawing.Size(448, 393)
            Me.TabPageComments.TabIndex = 7
            Me.TabPageComments.Text = "Comments"
            Me.TabPageComments.Visible = False
            Me.tbComment.Location = New Global.System.Drawing.Point(12, 7)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New Global.System.Drawing.Size(424, 336)
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
            Me.TabPageTrap.Location = New Global.System.Drawing.Point(4, 40)
            Me.TabPageTrap.Name = "TabPageTrap"
            Me.TabPageTrap.Size = New Global.System.Drawing.Size(448, 393)
            Me.TabPageTrap.TabIndex = 10
            Me.TabPageTrap.Text = "Trap"
            Me.chkbTrapDisarmable.Location = New Global.System.Drawing.Point(192, 85)
            Me.chkbTrapDisarmable.Name = "chkbTrapDisarmable"
            Me.chkbTrapDisarmable.Size = New Global.System.Drawing.Size(24, 24)
            Me.chkbTrapDisarmable.TabIndex = 2
            Me.chkbTrapDetectable.Location = New Global.System.Drawing.Point(192, 21)
            Me.chkbTrapDetectable.Name = "chkbTrapDetectable"
            Me.chkbTrapDetectable.Size = New Global.System.Drawing.Size(24, 24)
            Me.chkbTrapDetectable.TabIndex = 0
            Me.Label6.Location = New Global.System.Drawing.Point(48, 184)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label6.TabIndex = 26
            Me.Label6.Text = "TrapOneShot"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label3.Location = New Global.System.Drawing.Point(48, 152)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label3.TabIndex = 27
            Me.Label3.Text = "TrapFlag"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudDisarmDC.Location = New Global.System.Drawing.Point(176, 120)
            Me.nudDisarmDC.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudDisarmDC.Name = "nudDisarmDC"
            Me.nudDisarmDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudDisarmDC.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudDisarmDC.TabIndex = 3
            Me.nudDisarmDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label4.Location = New Global.System.Drawing.Point(48, 120)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label4.TabIndex = 22
            Me.Label4.Text = "DisarmDC"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label15.Location = New Global.System.Drawing.Point(48, 88)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label15.TabIndex = 23
            Me.Label15.Text = "TrapDisarmable"
            Me.Label15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudTrapDetectDC.Location = New Global.System.Drawing.Point(176, 56)
            Me.nudTrapDetectDC.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudTrapDetectDC.Name = "nudTrapDetectDC"
            Me.nudTrapDetectDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudTrapDetectDC.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudTrapDetectDC.TabIndex = 1
            Me.nudTrapDetectDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label16.Location = New Global.System.Drawing.Point(48, 56)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label16.TabIndex = 18
            Me.Label16.Text = "TrapDetectDC"
            Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblTrapDetectable.Location = New Global.System.Drawing.Point(48, 24)
            Me.lblTrapDetectable.Name = "lblTrapDetectable"
            Me.lblTrapDetectable.Size = New Global.System.Drawing.Size(88, 16)
            Me.lblTrapDetectable.TabIndex = 19
            Me.lblTrapDetectable.Text = "TrapDetectable"
            Me.lblTrapDetectable.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudTrapType.Location = New Global.System.Drawing.Point(176, 216)
            Me.nudTrapType.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.nudTrapType.Name = "nudTrapType"
            Me.nudTrapType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudTrapType.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudTrapType.TabIndex = 6
            Me.nudTrapType.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label17.Location = New Global.System.Drawing.Point(48, 216)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label17.TabIndex = 26
            Me.Label17.Text = "TrapType"
            Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbTrapFlag.Location = New Global.System.Drawing.Point(192, 152)
            Me.chkbTrapFlag.Name = "chkbTrapFlag"
            Me.chkbTrapFlag.Size = New Global.System.Drawing.Size(24, 24)
            Me.chkbTrapFlag.TabIndex = 4
            Me.chkbTrapOneShot.Location = New Global.System.Drawing.Point(192, 184)
            Me.chkbTrapOneShot.Name = "chkbTrapOneShot"
            Me.chkbTrapOneShot.Size = New Global.System.Drawing.Size(24, 24)
            Me.chkbTrapOneShot.TabIndex = 5
            Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSave.Location = New Global.System.Drawing.Point(312, 480)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "&Save"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.Location = New Global.System.Drawing.Point(408, 480)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "&Cancel"
            Me.btnInventory.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnInventory.Location = New Global.System.Drawing.Point(64, 480)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New Global.System.Drawing.Size(72, 24)
            Me.btnInventory.TabIndex = 9
            Me.btnInventory.Text = "&Inventory"
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New Global.System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New Global.System.Drawing.Size(8, 9)
            Me.btnDebug.TabIndex = 19
            Me.btnDebug.TabStop = False
            Me.btnEditOnClosed.Location = New Global.System.Drawing.Point(384, 16)
            Me.btnEditOnClosed.Name = "btnEditOnClosed"
            Me.btnEditOnClosed.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnClosed.TabIndex = 1
            Me.btnEditOnClosed.Text = "Edit"
            Me.btnEditOnClosed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnDamaged.Location = New Global.System.Drawing.Point(384, 42)
            Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
            Me.btnEditOnDamaged.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnDamaged.TabIndex = 3
            Me.btnEditOnDamaged.Text = "Edit"
            Me.btnEditOnDamaged.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnDeath.Location = New Global.System.Drawing.Point(384, 68)
            Me.btnEditOnDeath.Name = "btnEditOnDeath"
            Me.btnEditOnDeath.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnDeath.TabIndex = 5
            Me.btnEditOnDeath.Text = "Edit"
            Me.btnEditOnDeath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnDisarm.Location = New Global.System.Drawing.Point(384, 94)
            Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
            Me.btnEditOnDisarm.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnDisarm.TabIndex = 7
            Me.btnEditOnDisarm.Text = "Edit"
            Me.btnEditOnDisarm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnHeartbeat.Location = New Global.System.Drawing.Point(384, 146)
            Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
            Me.btnEditOnHeartbeat.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnHeartbeat.TabIndex = 11
            Me.btnEditOnHeartbeat.Text = "Edit"
            Me.btnEditOnHeartbeat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnLock.Location = New Global.System.Drawing.Point(384, 198)
            Me.btnEditOnLock.Name = "btnEditOnLock"
            Me.btnEditOnLock.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnLock.TabIndex = 15
            Me.btnEditOnLock.Text = "Edit"
            Me.btnEditOnLock.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnMeleeAttacked.Location = New Global.System.Drawing.Point(384, 224)
            Me.btnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked"
            Me.btnEditOnMeleeAttacked.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnMeleeAttacked.TabIndex = 17
            Me.btnEditOnMeleeAttacked.Text = "Edit"
            Me.btnEditOnMeleeAttacked.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnOpen.Location = New Global.System.Drawing.Point(384, 250)
            Me.btnEditOnOpen.Name = "btnEditOnOpen"
            Me.btnEditOnOpen.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnOpen.TabIndex = 19
            Me.btnEditOnOpen.Text = "Edit"
            Me.btnEditOnOpen.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnSpellCastAt.Location = New Global.System.Drawing.Point(384, 276)
            Me.btnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt"
            Me.btnEditOnSpellCastAt.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnSpellCastAt.TabIndex = 21
            Me.btnEditOnSpellCastAt.Text = "Edit"
            Me.btnEditOnSpellCastAt.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnTrapTriggered.Location = New Global.System.Drawing.Point(384, 302)
            Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
            Me.btnEditOnTrapTriggered.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnTrapTriggered.TabIndex = 23
            Me.btnEditOnTrapTriggered.Text = "Edit"
            Me.btnEditOnTrapTriggered.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnUserDefined.Location = New Global.System.Drawing.Point(384, 380)
            Me.btnEditOnUserDefined.Name = "btnEditOnUserDefined"
            Me.btnEditOnUserDefined.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnUserDefined.TabIndex = 29
            Me.btnEditOnUserDefined.Text = "Edit"
            Me.btnEditOnUserDefined.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnUnlock.Location = New Global.System.Drawing.Point(384, 328)
            Me.btnEditOnUnlock.Name = "btnEditOnUnlock"
            Me.btnEditOnUnlock.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnUnlock.TabIndex = 25
            Me.btnEditOnUnlock.Text = "Edit"
            Me.btnEditOnUnlock.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnUsed.Location = New Global.System.Drawing.Point(384, 354)
            Me.btnEditOnUsed.Name = "btnEditOnUsed"
            Me.btnEditOnUsed.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnUsed.TabIndex = 27
            Me.btnEditOnUsed.Text = "Edit"
            Me.btnEditOnUsed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnInvDisturbed.Location = New Global.System.Drawing.Point(384, 172)
            Me.btnEditOnInvDisturbed.Name = "btnEditOnInvDisturbed"
            Me.btnEditOnInvDisturbed.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnInvDisturbed.TabIndex = 13
            Me.btnEditOnInvDisturbed.Text = "Edit"
            Me.btnEditOnInvDisturbed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnEndDialogue.Location = New Global.System.Drawing.Point(384, 120)
            Me.btnEditOnEndDialogue.Name = "btnEditOnEndDialogue"
            Me.btnEditOnEndDialogue.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnEndDialogue.TabIndex = 9
            Me.btnEditOnEndDialogue.Text = "Edit"
            Me.btnEditOnEndDialogue.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(496, 517)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
            AddHandler Me.chkbLockable.CheckedChanged, AddressOf Me.chkbLockable_CheckedChanged
            AddHandler Me.chkbLocked.CheckedChanged, AddressOf Me.chkbLocked_CheckedChanged
            AddHandler Me.btnSetDescriptionLang.Click, AddressOf Me.btnSetDescLang_Click
            AddHandler Me.btnSave.Click, AddressOf Me.btnSave_Click
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.btnInventory.Click, AddressOf Me.btnInventory_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.btnEditOnClosed.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDamaged.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDeath.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDisarm.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnHeartbeat.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnLock.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnMeleeAttacked.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnOpen.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnSpellCastAt.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnTrapTriggered.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnUserDefined.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnUnlock.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnUsed.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnInvDisturbed.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnEndDialogue.Click, AddressOf Me.btnEditScript_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
