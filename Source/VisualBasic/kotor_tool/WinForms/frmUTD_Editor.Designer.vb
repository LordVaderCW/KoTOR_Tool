Namespace kotor_tool
	' Token: 0x0200007E RID: 126
	Public Partial Class frmUTD_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPageBasic As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPageLock As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPageScripts As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPageAdvanced As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPageDescription As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPageComments As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents chkbPlotItem As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents lblTextureVariation As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents lblBodyVariation As Global.System.Windows.Forms.Label
        Friend WithEvents Label34 As Global.System.Windows.Forms.Label
        Friend WithEvents Label33 As Global.System.Windows.Forms.Label
        Friend WithEvents Label32 As Global.System.Windows.Forms.Label
        Friend WithEvents Label35 As Global.System.Windows.Forms.Label
        Friend WithEvents Label36 As Global.System.Windows.Forms.Label
        Friend WithEvents Label37 As Global.System.Windows.Forms.Label
        Friend WithEvents Label38 As Global.System.Windows.Forms.Label
        Friend WithEvents Label39 As Global.System.Windows.Forms.Label
        Friend WithEvents Label40 As Global.System.Windows.Forms.Label
        Friend WithEvents Label41 As Global.System.Windows.Forms.Label
        Friend WithEvents Label42 As Global.System.Windows.Forms.Label
        Friend WithEvents Label43 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnDamaged As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnClosed As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnDisarm As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnHeartbeat As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnLock As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnMeleeAttacked As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnOpen As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnSpellCastAt As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnTrapTriggered As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnUnlock As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnUserDefined As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents tbComment As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTemplateResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents tbKeyName As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudCloseLockDC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudOpenLockDC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents chkbLockable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbLocked As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbKeyRequired As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbAutoRemoveKey As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbNotInterruptable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tbConversation As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents nudWill As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFort As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudHP As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudHardness As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRef As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents tbDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnClick As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnFailToOpen As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnDeath As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbAnimationState As Global.System.Windows.Forms.TextBox
        Friend WithEvents lblKeyTag As Global.System.Windows.Forms.Label
        Friend WithEvents lblCloseLockDC As Global.System.Windows.Forms.Label
        Friend WithEvents lblOpenLockDC As Global.System.Windows.Forms.Label
        Friend WithEvents chkbStatic As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnSetDescriptionLang As Global.System.Windows.Forms.Button
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents btnSetNameLang As Global.System.Windows.Forms.Button
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxDoorType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxOpenState As Global.System.Windows.Forms.ComboBox
        Friend WithEvents chkbNotBlastable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents lblOpenState As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxFaction As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnEditOnTrapTriggered As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDisarm As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnClick As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDamaged As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDeath As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnSpellCastAt As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnHeartbeat As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnClosed As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnFailToOpen As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnLock As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnMeleeAttacked As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnOpen As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnUnlock As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnUserDefined As Global.System.Windows.Forms.Button


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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUTD_Editor))
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
            Me.btnSave.Location = New Global.System.Drawing.Point(304, 464)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "&Save"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(400, 464)
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
            Me.TabControl1.Location = New Global.System.Drawing.Point(16, 8)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New Global.System.Drawing.Point(15, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(456, 440)
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
            Me.TabPageBasic.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPageBasic.Name = "TabPageBasic"
            Me.TabPageBasic.Size = New Global.System.Drawing.Size(448, 414)
            Me.TabPageBasic.TabIndex = 0
            Me.TabPageBasic.Text = "Basic"
            Me.Label19.Location = New Global.System.Drawing.Point(48, 80)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label19.TabIndex = 12
            Me.Label19.Text = "Door Type"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxDoorType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxDoorType.Location = New Global.System.Drawing.Point(128, 80)
            Me.cmbxDoorType.Name = "cmbxDoorType"
            Me.cmbxDoorType.Size = New Global.System.Drawing.Size(200, 21)
            Me.cmbxDoorType.TabIndex = 11
            Me.btnSetNameLang.Location = New Global.System.Drawing.Point(344, 32)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetNameLang.TabIndex = 9
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
            Me.nudWill.TabIndex = 7
            Me.nudWill.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFort.Location = New Global.System.Drawing.Point(192, 200)
            Me.nudFort.Name = "nudFort"
            Me.nudFort.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudFort.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudFort.TabIndex = 5
            Me.nudFort.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudHP.Location = New Global.System.Drawing.Point(192, 176)
            Me.nudHP.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudHP.Name = "nudHP"
            Me.nudHP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudHP.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudHP.TabIndex = 4
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
            Me.nudHardness.TabIndex = 3
            Me.nudHardness.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudRef.Location = New Global.System.Drawing.Point(192, 224)
            Me.nudRef.Name = "nudRef"
            Me.nudRef.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudRef.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudRef.TabIndex = 6
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
            Me.chkbPlotItem.TabIndex = 2
            Me.chkbPlotItem.Text = "Plot item"
            Me.tbTag.Location = New Global.System.Drawing.Point(128, 56)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbTag.TabIndex = 1
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
            Me.TabPageLock.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPageLock.Name = "TabPageLock"
            Me.TabPageLock.Size = New Global.System.Drawing.Size(448, 414)
            Me.TabPageLock.TabIndex = 1
            Me.TabPageLock.Text = "Lock"
            Me.cmbxOpenState.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxOpenState.Items.AddRange(New Object() {"Closed", "Opened"})
            Me.cmbxOpenState.Location = New Global.System.Drawing.Point(176, 125)
            Me.cmbxOpenState.Name = "cmbxOpenState"
            Me.cmbxOpenState.Size = New Global.System.Drawing.Size(121, 21)
            Me.cmbxOpenState.TabIndex = 3
            Me.tbKeyName.Enabled = False
            Me.tbKeyName.Location = New Global.System.Drawing.Point(176, 304)
            Me.tbKeyName.Name = "tbKeyName"
            Me.tbKeyName.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbKeyName.TabIndex = 8
            Me.tbKeyName.Text = ""
            Me.lblKeyTag.Enabled = False
            Me.lblKeyTag.Location = New Global.System.Drawing.Point(52, 304)
            Me.lblKeyTag.Name = "lblKeyTag"
            Me.lblKeyTag.Size = New Global.System.Drawing.Size(100, 16)
            Me.lblKeyTag.TabIndex = 18
            Me.lblKeyTag.Text = "Key Tag"
            Me.lblKeyTag.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudCloseLockDC.Enabled = False
            Me.nudCloseLockDC.Location = New Global.System.Drawing.Point(176, 208)
            Me.nudCloseLockDC.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCloseLockDC.Name = "nudCloseLockDC"
            Me.nudCloseLockDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudCloseLockDC.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudCloseLockDC.TabIndex = 5
            Me.nudCloseLockDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblCloseLockDC.Enabled = False
            Me.lblCloseLockDC.Location = New Global.System.Drawing.Point(48, 208)
            Me.lblCloseLockDC.Name = "lblCloseLockDC"
            Me.lblCloseLockDC.Size = New Global.System.Drawing.Size(88, 16)
            Me.lblCloseLockDC.TabIndex = 14
            Me.lblCloseLockDC.Text = "Close Lock DC"
            Me.lblCloseLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.nudOpenLockDC.Enabled = False
            Me.nudOpenLockDC.Location = New Global.System.Drawing.Point(176, 168)
            Me.nudOpenLockDC.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudOpenLockDC.Name = "nudOpenLockDC"
            Me.nudOpenLockDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.nudOpenLockDC.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudOpenLockDC.TabIndex = 4
            Me.nudOpenLockDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.lblOpenLockDC.Enabled = False
            Me.lblOpenLockDC.Location = New Global.System.Drawing.Point(48, 168)
            Me.lblOpenLockDC.Name = "lblOpenLockDC"
            Me.lblOpenLockDC.Size = New Global.System.Drawing.Size(88, 16)
            Me.lblOpenLockDC.TabIndex = 15
            Me.lblOpenLockDC.Text = "Open Lock DC"
            Me.lblOpenLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbLockable.Location = New Global.System.Drawing.Point(48, 56)
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
            Me.chkbKeyRequired.Location = New Global.System.Drawing.Point(48, 264)
            Me.chkbKeyRequired.Name = "chkbKeyRequired"
            Me.chkbKeyRequired.Size = New Global.System.Drawing.Size(184, 24)
            Me.chkbKeyRequired.TabIndex = 7
            Me.chkbKeyRequired.Text = "Key required to unlock or lock"
            Me.chkbAutoRemoveKey.Enabled = False
            Me.chkbAutoRemoveKey.Location = New Global.System.Drawing.Point(48, 240)
            Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
            Me.chkbAutoRemoveKey.Size = New Global.System.Drawing.Size(200, 24)
            Me.chkbAutoRemoveKey.TabIndex = 6
            Me.chkbAutoRemoveKey.Text = "Automatically remove key after use"
            Me.lblOpenState.Location = New Global.System.Drawing.Point(48, 128)
            Me.lblOpenState.Name = "lblOpenState"
            Me.lblOpenState.Size = New Global.System.Drawing.Size(88, 16)
            Me.lblOpenState.TabIndex = 15
            Me.lblOpenState.Text = "Door State"
            Me.lblOpenState.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbNotBlastable.Enabled = False
            Me.chkbNotBlastable.Location = New Global.System.Drawing.Point(48, 80)
            Me.chkbNotBlastable.Name = "chkbNotBlastable"
            Me.chkbNotBlastable.Size = New Global.System.Drawing.Size(112, 24)
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
            Me.TabPageScripts.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPageScripts.Name = "TabPageScripts"
            Me.TabPageScripts.Size = New Global.System.Drawing.Size(448, 414)
            Me.TabPageScripts.TabIndex = 4
            Me.TabPageScripts.Text = "Scripts"
            Me.btnEditOnUserDefined.Location = New Global.System.Drawing.Point(392, 372)
            Me.btnEditOnUserDefined.Name = "btnEditOnUserDefined"
            Me.btnEditOnUserDefined.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnUserDefined.TabIndex = 36
            Me.btnEditOnUserDefined.Text = "Edit"
            Me.btnEditOnUserDefined.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnHeartbeat.Location = New Global.System.Drawing.Point(392, 176)
            Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
            Me.btnEditOnHeartbeat.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnHeartbeat.TabIndex = 35
            Me.btnEditOnHeartbeat.Text = "Edit"
            Me.btnEditOnHeartbeat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnSpellCastAt.Location = New Global.System.Drawing.Point(392, 288)
            Me.btnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt"
            Me.btnEditOnSpellCastAt.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnSpellCastAt.TabIndex = 34
            Me.btnEditOnSpellCastAt.Text = "Edit"
            Me.btnEditOnSpellCastAt.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnDeath.Location = New Global.System.Drawing.Point(392, 92)
            Me.btnEditOnDeath.Name = "btnEditOnDeath"
            Me.btnEditOnDeath.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnDeath.TabIndex = 33
            Me.btnEditOnDeath.Text = "Edit"
            Me.btnEditOnDeath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnDamaged.Location = New Global.System.Drawing.Point(392, 64)
            Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
            Me.btnEditOnDamaged.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnDamaged.TabIndex = 32
            Me.btnEditOnDamaged.Text = "Edit"
            Me.btnEditOnDamaged.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnTrapTriggered.Location = New Global.System.Drawing.Point(392, 316)
            Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
            Me.btnEditOnTrapTriggered.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnTrapTriggered.TabIndex = 31
            Me.btnEditOnTrapTriggered.Text = "Edit"
            Me.btnEditOnTrapTriggered.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnDisarm.Location = New Global.System.Drawing.Point(392, 120)
            Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
            Me.btnEditOnDisarm.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnDisarm.TabIndex = 30
            Me.btnEditOnDisarm.Text = "Edit"
            Me.btnEditOnDisarm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnClick.Location = New Global.System.Drawing.Point(392, 8)
            Me.btnEditOnClick.Name = "btnEditOnClick"
            Me.btnEditOnClick.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnClick.TabIndex = 29
            Me.btnEditOnClick.Text = "Edit"
            Me.btnEditOnClick.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label34.Location = New Global.System.Drawing.Point(40, 92)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label34.TabIndex = 27
            Me.Label34.Text = "OnDeath"
            Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnDeath.Location = New Global.System.Drawing.Point(160, 92)
            Me.tbOnDeath.Name = "tbOnDeath"
            Me.tbOnDeath.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnDeath.TabIndex = 3
            Me.tbOnDeath.Text = ""
            Me.Label33.Location = New Global.System.Drawing.Point(40, 64)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label33.TabIndex = 17
            Me.Label33.Text = "OnDamaged"
            Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnDamaged.Location = New Global.System.Drawing.Point(160, 64)
            Me.tbOnDamaged.Name = "tbOnDamaged"
            Me.tbOnDamaged.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnDamaged.TabIndex = 2
            Me.tbOnDamaged.Text = ""
            Me.Label32.Location = New Global.System.Drawing.Point(40, 36)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label32.TabIndex = 14
            Me.Label32.Text = "OnClosed"
            Me.Label32.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnClosed.Location = New Global.System.Drawing.Point(160, 36)
            Me.tbOnClosed.Name = "tbOnClosed"
            Me.tbOnClosed.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnClosed.TabIndex = 1
            Me.tbOnClosed.Text = ""
            Me.Label35.Location = New Global.System.Drawing.Point(40, 120)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label35.TabIndex = 26
            Me.Label35.Text = "OnDisarm"
            Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnDisarm.Location = New Global.System.Drawing.Point(160, 120)
            Me.tbOnDisarm.Name = "tbOnDisarm"
            Me.tbOnDisarm.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnDisarm.TabIndex = 4
            Me.tbOnDisarm.Text = ""
            Me.tbOnHeartbeat.Location = New Global.System.Drawing.Point(160, 176)
            Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
            Me.tbOnHeartbeat.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnHeartbeat.TabIndex = 6
            Me.tbOnHeartbeat.Text = ""
            Me.Label36.Location = New Global.System.Drawing.Point(40, 176)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label36.TabIndex = 25
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label37.Location = New Global.System.Drawing.Point(40, 204)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label37.TabIndex = 28
            Me.Label37.Text = "OnLock"
            Me.Label37.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnLock.Location = New Global.System.Drawing.Point(160, 204)
            Me.tbOnLock.Name = "tbOnLock"
            Me.tbOnLock.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnLock.TabIndex = 7
            Me.tbOnLock.Text = ""
            Me.tbOnMeleeAttacked.Location = New Global.System.Drawing.Point(160, 232)
            Me.tbOnMeleeAttacked.Name = "tbOnMeleeAttacked"
            Me.tbOnMeleeAttacked.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnMeleeAttacked.TabIndex = 8
            Me.tbOnMeleeAttacked.Text = ""
            Me.Label38.Location = New Global.System.Drawing.Point(40, 232)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label38.TabIndex = 20
            Me.Label38.Text = "OnMeleeAttacked"
            Me.Label38.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnOpen.Location = New Global.System.Drawing.Point(160, 260)
            Me.tbOnOpen.Name = "tbOnOpen"
            Me.tbOnOpen.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnOpen.TabIndex = 9
            Me.tbOnOpen.Text = ""
            Me.Label39.Location = New Global.System.Drawing.Point(40, 260)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label39.TabIndex = 21
            Me.Label39.Text = "OnOpen"
            Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label40.Location = New Global.System.Drawing.Point(40, 288)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label40.TabIndex = 19
            Me.Label40.Text = "OnSpellCastAt"
            Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnSpellCastAt.Location = New Global.System.Drawing.Point(160, 288)
            Me.tbOnSpellCastAt.Name = "tbOnSpellCastAt"
            Me.tbOnSpellCastAt.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnSpellCastAt.TabIndex = 10
            Me.tbOnSpellCastAt.Text = ""
            Me.Label41.Location = New Global.System.Drawing.Point(40, 316)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label41.TabIndex = 24
            Me.Label41.Text = "OnTrapTriggered"
            Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnTrapTriggered.Location = New Global.System.Drawing.Point(160, 316)
            Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
            Me.tbOnTrapTriggered.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnTrapTriggered.TabIndex = 11
            Me.tbOnTrapTriggered.Text = ""
            Me.tbOnUnlock.Location = New Global.System.Drawing.Point(160, 344)
            Me.tbOnUnlock.Name = "tbOnUnlock"
            Me.tbOnUnlock.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnUnlock.TabIndex = 12
            Me.tbOnUnlock.Text = ""
            Me.Label42.Location = New Global.System.Drawing.Point(40, 344)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label42.TabIndex = 23
            Me.Label42.Text = "OnUnlock"
            Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnUserDefined.Location = New Global.System.Drawing.Point(160, 372)
            Me.tbOnUserDefined.Name = "tbOnUserDefined"
            Me.tbOnUserDefined.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnUserDefined.TabIndex = 13
            Me.tbOnUserDefined.Text = ""
            Me.Label43.Location = New Global.System.Drawing.Point(40, 372)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUserDefined"
            Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnClick.Location = New Global.System.Drawing.Point(160, 8)
            Me.tbOnClick.Name = "tbOnClick"
            Me.tbOnClick.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnClick.TabIndex = 0
            Me.tbOnClick.Text = ""
            Me.Label9.Location = New Global.System.Drawing.Point(40, 8)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label9.TabIndex = 23
            Me.Label9.Text = "OnClick"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label7.Location = New Global.System.Drawing.Point(40, 148)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(112, 18)
            Me.Label7.TabIndex = 22
            Me.Label7.Text = "OnFailToOpen"
            Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbOnFailToOpen.Location = New Global.System.Drawing.Point(160, 148)
            Me.tbOnFailToOpen.Name = "tbOnFailToOpen"
            Me.tbOnFailToOpen.Size = New Global.System.Drawing.Size(204, 20)
            Me.tbOnFailToOpen.TabIndex = 5
            Me.tbOnFailToOpen.Text = ""
            Me.btnEditOnClosed.Location = New Global.System.Drawing.Point(392, 36)
            Me.btnEditOnClosed.Name = "btnEditOnClosed"
            Me.btnEditOnClosed.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnClosed.TabIndex = 29
            Me.btnEditOnClosed.Text = "Edit"
            Me.btnEditOnClosed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnFailToOpen.Location = New Global.System.Drawing.Point(392, 148)
            Me.btnEditOnFailToOpen.Name = "btnEditOnFailToOpen"
            Me.btnEditOnFailToOpen.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnFailToOpen.TabIndex = 30
            Me.btnEditOnFailToOpen.Text = "Edit"
            Me.btnEditOnFailToOpen.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnLock.Location = New Global.System.Drawing.Point(392, 204)
            Me.btnEditOnLock.Name = "btnEditOnLock"
            Me.btnEditOnLock.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnLock.TabIndex = 35
            Me.btnEditOnLock.Text = "Edit"
            Me.btnEditOnLock.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnMeleeAttacked.Location = New Global.System.Drawing.Point(392, 232)
            Me.btnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked"
            Me.btnEditOnMeleeAttacked.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnMeleeAttacked.TabIndex = 35
            Me.btnEditOnMeleeAttacked.Text = "Edit"
            Me.btnEditOnMeleeAttacked.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnOpen.Location = New Global.System.Drawing.Point(392, 260)
            Me.btnEditOnOpen.Name = "btnEditOnOpen"
            Me.btnEditOnOpen.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnEditOnOpen.TabIndex = 35
            Me.btnEditOnOpen.Text = "Edit"
            Me.btnEditOnOpen.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditOnUnlock.Location = New Global.System.Drawing.Point(392, 344)
            Me.btnEditOnUnlock.Name = "btnEditOnUnlock"
            Me.btnEditOnUnlock.Size = New Global.System.Drawing.Size(32, 23)
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
            Me.TabPageAdvanced.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPageAdvanced.Name = "TabPageAdvanced"
            Me.TabPageAdvanced.Size = New Global.System.Drawing.Size(448, 414)
            Me.TabPageAdvanced.TabIndex = 5
            Me.TabPageAdvanced.Text = "Advanced"
            Me.cmbxFaction.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFaction.Location = New Global.System.Drawing.Point(168, 80)
            Me.cmbxFaction.Name = "cmbxFaction"
            Me.cmbxFaction.Size = New Global.System.Drawing.Size(120, 21)
            Me.cmbxFaction.TabIndex = 4
            Me.chkbNotInterruptable.Location = New Global.System.Drawing.Point(352, 136)
            Me.chkbNotInterruptable.Name = "chkbNotInterruptable"
            Me.chkbNotInterruptable.Size = New Global.System.Drawing.Size(84, 24)
            Me.chkbNotInterruptable.TabIndex = 2
            Me.chkbNotInterruptable.Text = "No Interrupt"
            Me.tbConversation.Location = New Global.System.Drawing.Point(168, 136)
            Me.tbConversation.Name = "tbConversation"
            Me.tbConversation.Size = New Global.System.Drawing.Size(168, 20)
            Me.tbConversation.TabIndex = 1
            Me.tbConversation.Text = ""
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
            Me.Label13.Location = New Global.System.Drawing.Point(56, 136)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Conversation"
            Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label14.Location = New Global.System.Drawing.Point(56, 184)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Animation State"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbAnimationState.Location = New Global.System.Drawing.Point(168, 184)
            Me.tbAnimationState.Name = "tbAnimationState"
            Me.tbAnimationState.Size = New Global.System.Drawing.Size(32, 20)
            Me.tbAnimationState.TabIndex = 3
            Me.tbAnimationState.Text = ""
            Me.TabPageDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.TabPageDescription.Controls.Add(Me.tbDescription)
            Me.TabPageDescription.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPageDescription.Name = "TabPageDescription"
            Me.TabPageDescription.Size = New Global.System.Drawing.Size(448, 414)
            Me.TabPageDescription.TabIndex = 6
            Me.TabPageDescription.Text = "Description"
            Me.btnSetDescriptionLang.Location = New Global.System.Drawing.Point(40, 320)
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Me.btnSetDescriptionLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetDescriptionLang.TabIndex = 5
            Me.btnSetDescriptionLang.Text = "Set Language"
            Me.tbDescription.Location = New Global.System.Drawing.Point(12, 7)
            Me.tbDescription.Multiline = True
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Size = New Global.System.Drawing.Size(424, 305)
            Me.tbDescription.TabIndex = 1
            Me.tbDescription.Text = ""
            Me.TabPageComments.Controls.Add(Me.tbComment)
            Me.TabPageComments.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPageComments.Name = "TabPageComments"
            Me.TabPageComments.Size = New Global.System.Drawing.Size(448, 414)
            Me.TabPageComments.TabIndex = 7
            Me.TabPageComments.Text = "Comments"
            Me.tbComment.Location = New Global.System.Drawing.Point(12, 7)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New Global.System.Drawing.Size(424, 336)
            Me.tbComment.TabIndex = 0
            Me.tbComment.Text = ""
            Me.btnDebug.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New Global.System.Drawing.Point(0, 64)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New Global.System.Drawing.Size(8, 8)
            Me.btnDebug.TabIndex = 18
            Me.btnDebug.TabStop = False
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(496, 501)
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.chkbLockable.CheckedChanged, AddressOf Me.chkbLockable_CheckedChanged
            AddHandler Me.chkbLocked.CheckedChanged, AddressOf Me.chkbLocked_CheckedChanged
            AddHandler Me.btnSave.Click, AddressOf Me.btnSave_Click
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.btnSetDescriptionLang.Click, AddressOf Me.btnSetDescLang_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
            AddHandler Me.btnEditOnTrapTriggered.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDisarm.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnClick.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDamaged.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDeath.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnSpellCastAt.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnHeartbeat.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnClosed.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnFailToOpen.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnLock.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnMeleeAttacked.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnOpen.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnUnlock.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnUserDefined.Click, AddressOf Me.btnEditScript_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
