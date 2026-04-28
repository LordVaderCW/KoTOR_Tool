Namespace kotor_tool
	' Token: 0x02000084 RID: 132
	Public Partial Class frmUTT_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents tbTemplateResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label57 As Global.System.Windows.Forms.Label
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label35 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnDisarm As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label41 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnTrapTriggered As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnClick As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents tbScriptUserDefine As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label45 As Global.System.Windows.Forms.Label
        Friend WithEvents TabPageComments As Global.System.Windows.Forms.TabPage
        Friend WithEvents tbComment As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbScriptHeartbeat As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label39 As Global.System.Windows.Forms.Label
        Friend WithEvents Label40 As Global.System.Windows.Forms.Label
        Friend WithEvents tbScriptOnEnter As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents tbScriptOnExit As Global.System.Windows.Forms.TextBox
        Friend WithEvents lblCloseLockDC As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents TabPageBasic As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPageScripts As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPageTrap As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents tbName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents nudDisarmDC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudTrapDetectDC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblTrapDetectable As Global.System.Windows.Forms.Label
        Friend WithEvents nudTrapType As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents chkbTrapDetectable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbTrapDisarmable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tbKeyName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents btnSetNameLang As Global.System.Windows.Forms.Button
        Friend WithEvents chkbAutoRemoveKey As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents tbCursor As Global.System.Windows.Forms.TextBox
        Friend WithEvents chkbTrapFlag As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbTrapOneShot As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxFaction As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnEditScriptOnEnter As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditScriptOnExit As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditScriptUserDefine As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditScriptHeartbeat As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnTrapTriggered As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDisarm As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnClick As Global.System.Windows.Forms.Button


		' Token: 0x06001647 RID: 5703 RVA: 0x002C619C File Offset: 0x002C519C
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060016C4 RID: 5828 RVA: 0x002C6FFC File Offset: 0x002C5FFC
		<Global.System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPageBasic = New Global.System.Windows.Forms.TabPage()
			Me.cmbxType = New Global.System.Windows.Forms.ComboBox()
			Me.cmbxFaction = New Global.System.Windows.Forms.ComboBox()
			Me.btnSetNameLang = New Global.System.Windows.Forms.Button()
			Me.tbName = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.tbTemplateResRef = New Global.System.Windows.Forms.TextBox()
			Me.Label57 = New Global.System.Windows.Forms.Label()
			Me.tbTag = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.tbCursor = New Global.System.Windows.Forms.TextBox()
			Me.TabPageScripts = New Global.System.Windows.Forms.TabPage()
			Me.btnEditScriptOnEnter = New Global.System.Windows.Forms.Button()
			Me.tbScriptHeartbeat = New Global.System.Windows.Forms.TextBox()
			Me.Label39 = New Global.System.Windows.Forms.Label()
			Me.Label40 = New Global.System.Windows.Forms.Label()
			Me.tbScriptOnEnter = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.tbScriptOnExit = New Global.System.Windows.Forms.TextBox()
			Me.tbScriptUserDefine = New Global.System.Windows.Forms.TextBox()
			Me.Label45 = New Global.System.Windows.Forms.Label()
			Me.Label35 = New Global.System.Windows.Forms.Label()
			Me.tbOnDisarm = New Global.System.Windows.Forms.TextBox()
			Me.Label41 = New Global.System.Windows.Forms.Label()
			Me.tbOnTrapTriggered = New Global.System.Windows.Forms.TextBox()
			Me.tbOnClick = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.btnEditScriptOnExit = New Global.System.Windows.Forms.Button()
			Me.btnEditScriptUserDefine = New Global.System.Windows.Forms.Button()
			Me.btnEditScriptHeartbeat = New Global.System.Windows.Forms.Button()
			Me.btnEditOnTrapTriggered = New Global.System.Windows.Forms.Button()
			Me.btnEditOnDisarm = New Global.System.Windows.Forms.Button()
			Me.btnEditOnClick = New Global.System.Windows.Forms.Button()
			Me.TabPageTrap = New Global.System.Windows.Forms.TabPage()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.chkbAutoRemoveKey = New Global.System.Windows.Forms.CheckBox()
			Me.tbKeyName = New Global.System.Windows.Forms.TextBox()
			Me.chkbTrapDisarmable = New Global.System.Windows.Forms.CheckBox()
			Me.chkbTrapDetectable = New Global.System.Windows.Forms.CheckBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.nudDisarmDC = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.nudTrapDetectDC = New Global.System.Windows.Forms.NumericUpDown()
			Me.lblCloseLockDC = New Global.System.Windows.Forms.Label()
			Me.lblTrapDetectable = New Global.System.Windows.Forms.Label()
			Me.nudTrapType = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.chkbTrapFlag = New Global.System.Windows.Forms.CheckBox()
			Me.chkbTrapOneShot = New Global.System.Windows.Forms.CheckBox()
			Me.TabPageComments = New Global.System.Windows.Forms.TabPage()
			Me.tbComment = New Global.System.Windows.Forms.TextBox()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.btnDebug = New Global.System.Windows.Forms.Button()
			Me.TabControl1.SuspendLayout()
			Me.TabPageBasic.SuspendLayout()
			Me.TabPageScripts.SuspendLayout()
			Me.TabPageTrap.SuspendLayout()
			CType(Me.nudDisarmDC, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudTrapDetectDC, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudTrapType, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.TabPageComments.SuspendLayout()
			Me.SuspendLayout()
			Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.TabControl1.Controls.Add(Me.TabPageBasic)
			Me.TabControl1.Controls.Add(Me.TabPageScripts)
			Me.TabControl1.Controls.Add(Me.TabPageTrap)
			Me.TabControl1.Controls.Add(Me.TabPageComments)
			Me.TabControl1.Location = New Global.System.Drawing.Point(16, 8)
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Me.TabControl1.Size = New Global.System.Drawing.Size(448, 344)
			Me.TabControl1.SizeMode = Global.System.Windows.Forms.TabSizeMode.FillToRight
			Me.TabControl1.TabIndex = 0
			Me.TabPageBasic.Controls.Add(Me.cmbxType)
			Me.TabPageBasic.Controls.Add(Me.cmbxFaction)
			Me.TabPageBasic.Controls.Add(Me.btnSetNameLang)
			Me.TabPageBasic.Controls.Add(Me.tbName)
			Me.TabPageBasic.Controls.Add(Me.Label11)
			Me.TabPageBasic.Controls.Add(Me.tbTemplateResRef)
			Me.TabPageBasic.Controls.Add(Me.Label57)
			Me.TabPageBasic.Controls.Add(Me.tbTag)
			Me.TabPageBasic.Controls.Add(Me.Label2)
			Me.TabPageBasic.Controls.Add(Me.Label1)
			Me.TabPageBasic.Controls.Add(Me.Label10)
			Me.TabPageBasic.Controls.Add(Me.Label14)
			Me.TabPageBasic.Controls.Add(Me.tbCursor)
			Me.TabPageBasic.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPageBasic.Name = "TabPageBasic"
			Me.TabPageBasic.Size = New Global.System.Drawing.Size(440, 318)
			Me.TabPageBasic.TabIndex = 0
			Me.TabPageBasic.Text = "Basic"
			Me.cmbxType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxType.Items.AddRange(New Object() { "Generic", "Transition", "Trap" })
			Me.cmbxType.Location = New Global.System.Drawing.Point(160, 152)
			Me.cmbxType.Name = "cmbxType"
			Me.cmbxType.Size = New Global.System.Drawing.Size(121, 21)
			Me.cmbxType.TabIndex = 10
			Me.cmbxFaction.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxFaction.Location = New Global.System.Drawing.Point(160, 120)
			Me.cmbxFaction.Name = "cmbxFaction"
			Me.cmbxFaction.Size = New Global.System.Drawing.Size(120, 21)
			Me.cmbxFaction.TabIndex = 9
			Me.btnSetNameLang.Location = New Global.System.Drawing.Point(344, 56)
			Me.btnSetNameLang.Name = "btnSetNameLang"
			Me.btnSetNameLang.Size = New Global.System.Drawing.Size(88, 23)
			Me.btnSetNameLang.TabIndex = 1
			Me.btnSetNameLang.Text = "Set Language"
			Me.tbName.Location = New Global.System.Drawing.Point(160, 56)
			Me.tbName.Name = "tbName"
			Me.tbName.Size = New Global.System.Drawing.Size(176, 20)
			Me.tbName.TabIndex = 0
			Me.tbName.Text = ""
			Me.Label11.Location = New Global.System.Drawing.Point(48, 56)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(100, 16)
			Me.Label11.TabIndex = 8
			Me.Label11.Text = "Name"
			Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
			Me.tbTemplateResRef.Location = New Global.System.Drawing.Point(160, 24)
			Me.tbTemplateResRef.MaxLength = 16
			Me.tbTemplateResRef.Name = "tbTemplateResRef"
			Me.tbTemplateResRef.Size = New Global.System.Drawing.Size(176, 20)
			Me.tbTemplateResRef.TabIndex = 6
			Me.tbTemplateResRef.Text = ""
			Me.Label57.Location = New Global.System.Drawing.Point(48, 24)
			Me.Label57.Name = "Label57"
			Me.Label57.Size = New Global.System.Drawing.Size(100, 18)
			Me.Label57.TabIndex = 5
			Me.Label57.Text = "Template ResRef"
			Me.Label57.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbTag.Location = New Global.System.Drawing.Point(160, 88)
			Me.tbTag.Name = "tbTag"
			Me.tbTag.Size = New Global.System.Drawing.Size(176, 20)
			Me.tbTag.TabIndex = 2
			Me.tbTag.Text = ""
			Me.Label2.Location = New Global.System.Drawing.Point(48, 88)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(100, 16)
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Tag"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label1.Location = New Global.System.Drawing.Point(48, 120)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(48, 16)
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Faction"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label10.Location = New Global.System.Drawing.Point(48, 152)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(48, 16)
			Me.Label10.TabIndex = 2
			Me.Label10.Text = "Type"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label14.Location = New Global.System.Drawing.Point(48, 184)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Global.System.Drawing.Size(48, 16)
			Me.Label14.TabIndex = 2
			Me.Label14.Text = "Cursor"
			Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbCursor.Location = New Global.System.Drawing.Point(160, 184)
			Me.tbCursor.Name = "tbCursor"
			Me.tbCursor.Size = New Global.System.Drawing.Size(30, 20)
			Me.tbCursor.TabIndex = 4
			Me.tbCursor.Text = ""
			Me.TabPageScripts.Controls.Add(Me.btnEditScriptOnEnter)
			Me.TabPageScripts.Controls.Add(Me.tbScriptHeartbeat)
			Me.TabPageScripts.Controls.Add(Me.Label39)
			Me.TabPageScripts.Controls.Add(Me.Label40)
			Me.TabPageScripts.Controls.Add(Me.tbScriptOnEnter)
			Me.TabPageScripts.Controls.Add(Me.Label3)
			Me.TabPageScripts.Controls.Add(Me.tbScriptOnExit)
			Me.TabPageScripts.Controls.Add(Me.tbScriptUserDefine)
			Me.TabPageScripts.Controls.Add(Me.Label45)
			Me.TabPageScripts.Controls.Add(Me.Label35)
			Me.TabPageScripts.Controls.Add(Me.tbOnDisarm)
			Me.TabPageScripts.Controls.Add(Me.Label41)
			Me.TabPageScripts.Controls.Add(Me.tbOnTrapTriggered)
			Me.TabPageScripts.Controls.Add(Me.tbOnClick)
			Me.TabPageScripts.Controls.Add(Me.Label9)
			Me.TabPageScripts.Controls.Add(Me.btnEditScriptOnExit)
			Me.TabPageScripts.Controls.Add(Me.btnEditScriptUserDefine)
			Me.TabPageScripts.Controls.Add(Me.btnEditScriptHeartbeat)
			Me.TabPageScripts.Controls.Add(Me.btnEditOnTrapTriggered)
			Me.TabPageScripts.Controls.Add(Me.btnEditOnDisarm)
			Me.TabPageScripts.Controls.Add(Me.btnEditOnClick)
			Me.TabPageScripts.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPageScripts.Name = "TabPageScripts"
			Me.TabPageScripts.Size = New Global.System.Drawing.Size(440, 318)
			Me.TabPageScripts.TabIndex = 1
			Me.TabPageScripts.Text = "Scripts"
			Me.btnEditScriptOnEnter.Location = New Global.System.Drawing.Point(392, 152)
			Me.btnEditScriptOnEnter.Name = "btnEditScriptOnEnter"
			Me.btnEditScriptOnEnter.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditScriptOnEnter.TabIndex = 9
			Me.btnEditScriptOnEnter.Text = "Edit"
			Me.btnEditScriptOnEnter.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbScriptHeartbeat.Location = New Global.System.Drawing.Point(168, 120)
			Me.tbScriptHeartbeat.Name = "tbScriptHeartbeat"
			Me.tbScriptHeartbeat.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbScriptHeartbeat.TabIndex = 6
			Me.tbScriptHeartbeat.Text = ""
			Me.Label39.Location = New Global.System.Drawing.Point(48, 120)
			Me.Label39.Name = "Label39"
			Me.Label39.Size = New Global.System.Drawing.Size(112, 18)
			Me.Label39.TabIndex = 39
			Me.Label39.Text = "ScriptHeartbeat"
			Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label40.Location = New Global.System.Drawing.Point(48, 152)
			Me.Label40.Name = "Label40"
			Me.Label40.Size = New Global.System.Drawing.Size(112, 18)
			Me.Label40.TabIndex = 38
			Me.Label40.Text = "ScriptOnEnter"
			Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbScriptOnEnter.Location = New Global.System.Drawing.Point(168, 152)
			Me.tbScriptOnEnter.Name = "tbScriptOnEnter"
			Me.tbScriptOnEnter.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbScriptOnEnter.TabIndex = 8
			Me.tbScriptOnEnter.Text = ""
			Me.Label3.Location = New Global.System.Drawing.Point(48, 184)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(112, 18)
			Me.Label3.TabIndex = 40
			Me.Label3.Text = "ScriptOnExit"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbScriptOnExit.Location = New Global.System.Drawing.Point(168, 184)
			Me.tbScriptOnExit.Name = "tbScriptOnExit"
			Me.tbScriptOnExit.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbScriptOnExit.TabIndex = 10
			Me.tbScriptOnExit.Text = ""
			Me.tbScriptUserDefine.Location = New Global.System.Drawing.Point(168, 216)
			Me.tbScriptUserDefine.Name = "tbScriptUserDefine"
			Me.tbScriptUserDefine.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbScriptUserDefine.TabIndex = 12
			Me.tbScriptUserDefine.Text = ""
			Me.Label45.Location = New Global.System.Drawing.Point(48, 216)
			Me.Label45.Name = "Label45"
			Me.Label45.Size = New Global.System.Drawing.Size(96, 18)
			Me.Label45.TabIndex = 33
			Me.Label45.Text = "ScriptUserDefine"
			Me.Label45.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label35.Location = New Global.System.Drawing.Point(48, 56)
			Me.Label35.Name = "Label35"
			Me.Label35.Size = New Global.System.Drawing.Size(112, 18)
			Me.Label35.TabIndex = 32
			Me.Label35.Text = "OnDisarm"
			Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnDisarm.Location = New Global.System.Drawing.Point(168, 56)
			Me.tbOnDisarm.Name = "tbOnDisarm"
			Me.tbOnDisarm.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnDisarm.TabIndex = 2
			Me.tbOnDisarm.Text = ""
			Me.Label41.Location = New Global.System.Drawing.Point(48, 88)
			Me.Label41.Name = "Label41"
			Me.Label41.Size = New Global.System.Drawing.Size(112, 18)
			Me.Label41.TabIndex = 31
			Me.Label41.Text = "OnTrapTriggered"
			Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnTrapTriggered.Location = New Global.System.Drawing.Point(168, 88)
			Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
			Me.tbOnTrapTriggered.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnTrapTriggered.TabIndex = 4
			Me.tbOnTrapTriggered.Text = ""
			Me.tbOnClick.Location = New Global.System.Drawing.Point(168, 24)
			Me.tbOnClick.Name = "tbOnClick"
			Me.tbOnClick.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnClick.TabIndex = 0
			Me.tbOnClick.Text = ""
			Me.Label9.Location = New Global.System.Drawing.Point(48, 24)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(112, 18)
			Me.Label9.TabIndex = 30
			Me.Label9.Text = "OnClick"
			Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditScriptOnExit.Location = New Global.System.Drawing.Point(392, 184)
			Me.btnEditScriptOnExit.Name = "btnEditScriptOnExit"
			Me.btnEditScriptOnExit.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditScriptOnExit.TabIndex = 11
			Me.btnEditScriptOnExit.Text = "Edit"
			Me.btnEditScriptOnExit.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditScriptUserDefine.Location = New Global.System.Drawing.Point(392, 216)
			Me.btnEditScriptUserDefine.Name = "btnEditScriptUserDefine"
			Me.btnEditScriptUserDefine.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditScriptUserDefine.TabIndex = 13
			Me.btnEditScriptUserDefine.Text = "Edit"
			Me.btnEditScriptUserDefine.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditScriptHeartbeat.Location = New Global.System.Drawing.Point(392, 120)
			Me.btnEditScriptHeartbeat.Name = "btnEditScriptHeartbeat"
			Me.btnEditScriptHeartbeat.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditScriptHeartbeat.TabIndex = 7
			Me.btnEditScriptHeartbeat.Text = "Edit"
			Me.btnEditScriptHeartbeat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnTrapTriggered.Location = New Global.System.Drawing.Point(392, 88)
			Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
			Me.btnEditOnTrapTriggered.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnTrapTriggered.TabIndex = 5
			Me.btnEditOnTrapTriggered.Text = "Edit"
			Me.btnEditOnTrapTriggered.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnDisarm.Location = New Global.System.Drawing.Point(392, 56)
			Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
			Me.btnEditOnDisarm.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnDisarm.TabIndex = 3
			Me.btnEditOnDisarm.Text = "Edit"
			Me.btnEditOnDisarm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnClick.Location = New Global.System.Drawing.Point(392, 24)
			Me.btnEditOnClick.Name = "btnEditOnClick"
			Me.btnEditOnClick.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnClick.TabIndex = 1
			Me.btnEditOnClick.Text = "Edit"
			Me.btnEditOnClick.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.TabPageTrap.Controls.Add(Me.Label15)
			Me.TabPageTrap.Controls.Add(Me.chkbAutoRemoveKey)
			Me.TabPageTrap.Controls.Add(Me.tbKeyName)
			Me.TabPageTrap.Controls.Add(Me.chkbTrapDisarmable)
			Me.TabPageTrap.Controls.Add(Me.chkbTrapDetectable)
			Me.TabPageTrap.Controls.Add(Me.Label6)
			Me.TabPageTrap.Controls.Add(Me.Label7)
			Me.TabPageTrap.Controls.Add(Me.nudDisarmDC)
			Me.TabPageTrap.Controls.Add(Me.Label4)
			Me.TabPageTrap.Controls.Add(Me.Label5)
			Me.TabPageTrap.Controls.Add(Me.nudTrapDetectDC)
			Me.TabPageTrap.Controls.Add(Me.lblCloseLockDC)
			Me.TabPageTrap.Controls.Add(Me.lblTrapDetectable)
			Me.TabPageTrap.Controls.Add(Me.nudTrapType)
			Me.TabPageTrap.Controls.Add(Me.Label8)
			Me.TabPageTrap.Controls.Add(Me.Label12)
			Me.TabPageTrap.Controls.Add(Me.Label13)
			Me.TabPageTrap.Controls.Add(Me.chkbTrapFlag)
			Me.TabPageTrap.Controls.Add(Me.chkbTrapOneShot)
			Me.TabPageTrap.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPageTrap.Name = "TabPageTrap"
			Me.TabPageTrap.Size = New Global.System.Drawing.Size(440, 318)
			Me.TabPageTrap.TabIndex = 9
			Me.TabPageTrap.Text = "Trap"
			Me.Label15.Location = New Global.System.Drawing.Point(249, 220)
			Me.Label15.Name = "Label15"
			Me.Label15.Size = New Global.System.Drawing.Size(168, 20)
			Me.Label15.TabIndex = 28
			Me.Label15.Text = "This is an index into traps.2da"
			Me.Label15.Visible = False
			Me.chkbAutoRemoveKey.Location = New Global.System.Drawing.Point(232, 277)
			Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
			Me.chkbAutoRemoveKey.Size = New Global.System.Drawing.Size(24, 24)
			Me.chkbAutoRemoveKey.TabIndex = 8
			Me.tbKeyName.Location = New Global.System.Drawing.Point(176, 248)
			Me.tbKeyName.Name = "tbKeyName"
			Me.tbKeyName.Size = New Global.System.Drawing.Size(136, 20)
			Me.tbKeyName.TabIndex = 7
			Me.tbKeyName.Text = ""
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
			Me.Label7.Location = New Global.System.Drawing.Point(48, 152)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(88, 16)
			Me.Label7.TabIndex = 27
			Me.Label7.Text = "TrapFlag"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudDisarmDC.Location = New Global.System.Drawing.Point(176, 120)
			Me.nudDisarmDC.Maximum = New Decimal(New Integer() { 250, 0, 0, 0 })
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
			Me.Label5.Location = New Global.System.Drawing.Point(48, 88)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(88, 16)
			Me.Label5.TabIndex = 23
			Me.Label5.Text = "TrapDisarmable"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudTrapDetectDC.Location = New Global.System.Drawing.Point(176, 56)
			Me.nudTrapDetectDC.Maximum = New Decimal(New Integer() { 250, 0, 0, 0 })
			Me.nudTrapDetectDC.Name = "nudTrapDetectDC"
			Me.nudTrapDetectDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.nudTrapDetectDC.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudTrapDetectDC.TabIndex = 1
			Me.nudTrapDetectDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.lblCloseLockDC.Location = New Global.System.Drawing.Point(48, 56)
			Me.lblCloseLockDC.Name = "lblCloseLockDC"
			Me.lblCloseLockDC.Size = New Global.System.Drawing.Size(88, 16)
			Me.lblCloseLockDC.TabIndex = 18
			Me.lblCloseLockDC.Text = "TrapDetectDC"
			Me.lblCloseLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblTrapDetectable.Location = New Global.System.Drawing.Point(48, 24)
			Me.lblTrapDetectable.Name = "lblTrapDetectable"
			Me.lblTrapDetectable.Size = New Global.System.Drawing.Size(88, 16)
			Me.lblTrapDetectable.TabIndex = 19
			Me.lblTrapDetectable.Text = "TrapDetectable"
			Me.lblTrapDetectable.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudTrapType.Location = New Global.System.Drawing.Point(176, 216)
			Me.nudTrapType.Maximum = New Decimal(New Integer() { 13, 0, 0, 0 })
			Me.nudTrapType.Name = "nudTrapType"
			Me.nudTrapType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.nudTrapType.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudTrapType.TabIndex = 6
			Me.nudTrapType.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Label8.Location = New Global.System.Drawing.Point(48, 216)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(88, 16)
			Me.Label8.TabIndex = 26
			Me.Label8.Text = "TrapType"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label12.Location = New Global.System.Drawing.Point(48, 248)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(88, 16)
			Me.Label12.TabIndex = 26
			Me.Label12.Text = "KeyName"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label13.Location = New Global.System.Drawing.Point(48, 280)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(184, 16)
			Me.Label13.TabIndex = 26
			Me.Label13.Text = "Automatically remove key after use"
			Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.chkbTrapFlag.Location = New Global.System.Drawing.Point(192, 152)
			Me.chkbTrapFlag.Name = "chkbTrapFlag"
			Me.chkbTrapFlag.Size = New Global.System.Drawing.Size(24, 24)
			Me.chkbTrapFlag.TabIndex = 2
			Me.chkbTrapOneShot.Location = New Global.System.Drawing.Point(192, 184)
			Me.chkbTrapOneShot.Name = "chkbTrapOneShot"
			Me.chkbTrapOneShot.Size = New Global.System.Drawing.Size(24, 24)
			Me.chkbTrapOneShot.TabIndex = 2
			Me.TabPageComments.Controls.Add(Me.tbComment)
			Me.TabPageComments.Location = New Global.System.Drawing.Point(4, 22)
			Me.TabPageComments.Name = "TabPageComments"
			Me.TabPageComments.Size = New Global.System.Drawing.Size(440, 318)
			Me.TabPageComments.TabIndex = 8
			Me.TabPageComments.Text = "Comments"
			Me.tbComment.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.tbComment.Location = New Global.System.Drawing.Point(0, 0)
			Me.tbComment.Multiline = True
			Me.tbComment.Name = "tbComment"
			Me.tbComment.Size = New Global.System.Drawing.Size(440, 318)
			Me.tbComment.TabIndex = 0
			Me.tbComment.Text = ""
			Me.btnSave.Location = New Global.System.Drawing.Point(288, 368)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.TabIndex = 3
			Me.btnSave.Text = "&Save"
			Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New Global.System.Drawing.Point(384, 368)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.TabIndex = 4
			Me.btnCancel.Text = "&Cancel"
			Me.btnDebug.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.btnDebug.Location = New Global.System.Drawing.Point(0, 0)
			Me.btnDebug.Name = "btnDebug"
			Me.btnDebug.Size = New Global.System.Drawing.Size(8, 8)
			Me.btnDebug.TabIndex = 17
			Me.btnDebug.TabStop = False
			Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Global.System.Drawing.Size(480, 405)
			Me.Controls.Add(Me.btnDebug)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.TabControl1)
			Me.Name = "frmUTT_Editor"
			Me.Text = "Trigger Editor - KotOR "
			Me.TabControl1.ResumeLayout(False)
			Me.TabPageBasic.ResumeLayout(False)
			Me.TabPageScripts.ResumeLayout(False)
			Me.TabPageTrap.ResumeLayout(False)
			CType(Me.nudDisarmDC, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudTrapDetectDC, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudTrapType, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.TabPageComments.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnSave.Click, AddressOf Me.btnSave_Click
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.cmbxType.SelectedIndexChanged, AddressOf Me.cmbxType_SelectedIndexChanged
            AddHandler Me.btnEditScriptOnEnter.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditScriptOnExit.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditScriptUserDefine.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditScriptHeartbeat.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnTrapTriggered.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDisarm.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnClick.Click, AddressOf Me.btnEditScript_Click
			Me.ResumeLayout(False)
		End Sub

	End Class
End Namespace
