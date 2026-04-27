Namespace kotor_tool
	' Token: 0x02000084 RID: 132
	Public Partial Class frmUTT_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06001647 RID: 5703 RVA: 0x002C619C File Offset: 0x002C519C
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060016C4 RID: 5828 RVA: 0x002C6FFC File Offset: 0x002C5FFC
		<Global.System.Diagnostics.DebuggerStepThrough()>
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
			Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(16, 8)
			tabControl.Location = point
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(448, 344)
			tabControl2.Size = size
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
			Dim tabPageBasic As Global.System.Windows.Forms.Control = Me.TabPageBasic
			point = New Global.System.Drawing.Point(4, 22)
			tabPageBasic.Location = point
			Me.TabPageBasic.Name = "TabPageBasic"
			Dim tabPageBasic2 As Global.System.Windows.Forms.Control = Me.TabPageBasic
			size = New Global.System.Drawing.Size(440, 318)
			tabPageBasic2.Size = size
			Me.TabPageBasic.TabIndex = 0
			Me.TabPageBasic.Text = "Basic"
			Me.cmbxType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxType.Items.AddRange(New Object() { "Generic", "Transition", "Trap" })
			Dim cmbxType As Global.System.Windows.Forms.Control = Me.cmbxType
			point = New Global.System.Drawing.Point(160, 152)
			cmbxType.Location = point
			Me.cmbxType.Name = "cmbxType"
			Dim cmbxType2 As Global.System.Windows.Forms.Control = Me.cmbxType
			size = New Global.System.Drawing.Size(121, 21)
			cmbxType2.Size = size
			Me.cmbxType.TabIndex = 10
			Me.cmbxFaction.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxFaction As Global.System.Windows.Forms.Control = Me.cmbxFaction
			point = New Global.System.Drawing.Point(160, 120)
			cmbxFaction.Location = point
			Me.cmbxFaction.Name = "cmbxFaction"
			Dim cmbxFaction2 As Global.System.Windows.Forms.Control = Me.cmbxFaction
			size = New Global.System.Drawing.Size(120, 21)
			cmbxFaction2.Size = size
			Me.cmbxFaction.TabIndex = 9
			Dim btnSetNameLang As Global.System.Windows.Forms.Control = Me.btnSetNameLang
			point = New Global.System.Drawing.Point(344, 56)
			btnSetNameLang.Location = point
			Me.btnSetNameLang.Name = "btnSetNameLang"
			Dim btnSetNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetNameLang
			size = New Global.System.Drawing.Size(88, 23)
			btnSetNameLang2.Size = size
			Me.btnSetNameLang.TabIndex = 1
			Me.btnSetNameLang.Text = "Set Language"
			Dim tbName As Global.System.Windows.Forms.Control = Me.tbName
			point = New Global.System.Drawing.Point(160, 56)
			tbName.Location = point
			Me.tbName.Name = "tbName"
			Dim tbName2 As Global.System.Windows.Forms.Control = Me.tbName
			size = New Global.System.Drawing.Size(176, 20)
			tbName2.Size = size
			Me.tbName.TabIndex = 0
			Me.tbName.Text = ""
			Dim label As Global.System.Windows.Forms.Control = Me.Label11
			point = New Global.System.Drawing.Point(48, 56)
			label.Location = point
			Me.Label11.Name = "Label11"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(100, 16)
			label2.Size = size
			Me.Label11.TabIndex = 8
			Me.Label11.Text = "Name"
			Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
			Dim tbTemplateResRef As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
			point = New Global.System.Drawing.Point(160, 24)
			tbTemplateResRef.Location = point
			Me.tbTemplateResRef.MaxLength = 16
			Me.tbTemplateResRef.Name = "tbTemplateResRef"
			Dim tbTemplateResRef2 As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
			size = New Global.System.Drawing.Size(176, 20)
			tbTemplateResRef2.Size = size
			Me.tbTemplateResRef.TabIndex = 6
			Me.tbTemplateResRef.Text = ""
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label57
			point = New Global.System.Drawing.Point(48, 24)
			label3.Location = point
			Me.Label57.Name = "Label57"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label57
			size = New Global.System.Drawing.Size(100, 18)
			label4.Size = size
			Me.Label57.TabIndex = 5
			Me.Label57.Text = "Template ResRef"
			Me.Label57.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
			point = New Global.System.Drawing.Point(160, 88)
			tbTag.Location = point
			Me.tbTag.Name = "tbTag"
			Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
			size = New Global.System.Drawing.Size(176, 20)
			tbTag2.Size = size
			Me.tbTag.TabIndex = 2
			Me.tbTag.Text = ""
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(48, 88)
			label5.Location = point
			Me.Label2.Name = "Label2"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(100, 16)
			label6.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Tag"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(48, 120)
			label7.Location = point
			Me.Label1.Name = "Label1"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(48, 16)
			label8.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Faction"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(48, 152)
			label9.Location = point
			Me.Label10.Name = "Label10"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(48, 16)
			label10.Size = size
			Me.Label10.TabIndex = 2
			Me.Label10.Text = "Type"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label14
			point = New Global.System.Drawing.Point(48, 184)
			label11.Location = point
			Me.Label14.Name = "Label14"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label14
			size = New Global.System.Drawing.Size(48, 16)
			label12.Size = size
			Me.Label14.TabIndex = 2
			Me.Label14.Text = "Cursor"
			Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbCursor As Global.System.Windows.Forms.Control = Me.tbCursor
			point = New Global.System.Drawing.Point(160, 184)
			tbCursor.Location = point
			Me.tbCursor.Name = "tbCursor"
			Dim tbCursor2 As Global.System.Windows.Forms.Control = Me.tbCursor
			size = New Global.System.Drawing.Size(30, 20)
			tbCursor2.Size = size
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
			Dim tabPageScripts As Global.System.Windows.Forms.Control = Me.TabPageScripts
			point = New Global.System.Drawing.Point(4, 22)
			tabPageScripts.Location = point
			Me.TabPageScripts.Name = "TabPageScripts"
			Dim tabPageScripts2 As Global.System.Windows.Forms.Control = Me.TabPageScripts
			size = New Global.System.Drawing.Size(440, 318)
			tabPageScripts2.Size = size
			Me.TabPageScripts.TabIndex = 1
			Me.TabPageScripts.Text = "Scripts"
			Dim btnEditScriptOnEnter As Global.System.Windows.Forms.Control = Me.btnEditScriptOnEnter
			point = New Global.System.Drawing.Point(392, 152)
			btnEditScriptOnEnter.Location = point
			Me.btnEditScriptOnEnter.Name = "btnEditScriptOnEnter"
			Dim btnEditScriptOnEnter2 As Global.System.Windows.Forms.Control = Me.btnEditScriptOnEnter
			size = New Global.System.Drawing.Size(32, 23)
			btnEditScriptOnEnter2.Size = size
			Me.btnEditScriptOnEnter.TabIndex = 9
			Me.btnEditScriptOnEnter.Text = "Edit"
			Me.btnEditScriptOnEnter.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbScriptHeartbeat As Global.System.Windows.Forms.Control = Me.tbScriptHeartbeat
			point = New Global.System.Drawing.Point(168, 120)
			tbScriptHeartbeat.Location = point
			Me.tbScriptHeartbeat.Name = "tbScriptHeartbeat"
			Dim tbScriptHeartbeat2 As Global.System.Windows.Forms.Control = Me.tbScriptHeartbeat
			size = New Global.System.Drawing.Size(204, 20)
			tbScriptHeartbeat2.Size = size
			Me.tbScriptHeartbeat.TabIndex = 6
			Me.tbScriptHeartbeat.Text = ""
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label39
			point = New Global.System.Drawing.Point(48, 120)
			label13.Location = point
			Me.Label39.Name = "Label39"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label39
			size = New Global.System.Drawing.Size(112, 18)
			label14.Size = size
			Me.Label39.TabIndex = 39
			Me.Label39.Text = "ScriptHeartbeat"
			Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label40
			point = New Global.System.Drawing.Point(48, 152)
			label15.Location = point
			Me.Label40.Name = "Label40"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label40
			size = New Global.System.Drawing.Size(112, 18)
			label16.Size = size
			Me.Label40.TabIndex = 38
			Me.Label40.Text = "ScriptOnEnter"
			Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbScriptOnEnter As Global.System.Windows.Forms.Control = Me.tbScriptOnEnter
			point = New Global.System.Drawing.Point(168, 152)
			tbScriptOnEnter.Location = point
			Me.tbScriptOnEnter.Name = "tbScriptOnEnter"
			Dim tbScriptOnEnter2 As Global.System.Windows.Forms.Control = Me.tbScriptOnEnter
			size = New Global.System.Drawing.Size(204, 20)
			tbScriptOnEnter2.Size = size
			Me.tbScriptOnEnter.TabIndex = 8
			Me.tbScriptOnEnter.Text = ""
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(48, 184)
			label17.Location = point
			Me.Label3.Name = "Label3"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(112, 18)
			label18.Size = size
			Me.Label3.TabIndex = 40
			Me.Label3.Text = "ScriptOnExit"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbScriptOnExit As Global.System.Windows.Forms.Control = Me.tbScriptOnExit
			point = New Global.System.Drawing.Point(168, 184)
			tbScriptOnExit.Location = point
			Me.tbScriptOnExit.Name = "tbScriptOnExit"
			Dim tbScriptOnExit2 As Global.System.Windows.Forms.Control = Me.tbScriptOnExit
			size = New Global.System.Drawing.Size(204, 20)
			tbScriptOnExit2.Size = size
			Me.tbScriptOnExit.TabIndex = 10
			Me.tbScriptOnExit.Text = ""
			Dim tbScriptUserDefine As Global.System.Windows.Forms.Control = Me.tbScriptUserDefine
			point = New Global.System.Drawing.Point(168, 216)
			tbScriptUserDefine.Location = point
			Me.tbScriptUserDefine.Name = "tbScriptUserDefine"
			Dim tbScriptUserDefine2 As Global.System.Windows.Forms.Control = Me.tbScriptUserDefine
			size = New Global.System.Drawing.Size(204, 20)
			tbScriptUserDefine2.Size = size
			Me.tbScriptUserDefine.TabIndex = 12
			Me.tbScriptUserDefine.Text = ""
			Dim label19 As Global.System.Windows.Forms.Control = Me.Label45
			point = New Global.System.Drawing.Point(48, 216)
			label19.Location = point
			Me.Label45.Name = "Label45"
			Dim label20 As Global.System.Windows.Forms.Control = Me.Label45
			size = New Global.System.Drawing.Size(96, 18)
			label20.Size = size
			Me.Label45.TabIndex = 33
			Me.Label45.Text = "ScriptUserDefine"
			Me.Label45.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label21 As Global.System.Windows.Forms.Control = Me.Label35
			point = New Global.System.Drawing.Point(48, 56)
			label21.Location = point
			Me.Label35.Name = "Label35"
			Dim label22 As Global.System.Windows.Forms.Control = Me.Label35
			size = New Global.System.Drawing.Size(112, 18)
			label22.Size = size
			Me.Label35.TabIndex = 32
			Me.Label35.Text = "OnDisarm"
			Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnDisarm As Global.System.Windows.Forms.Control = Me.tbOnDisarm
			point = New Global.System.Drawing.Point(168, 56)
			tbOnDisarm.Location = point
			Me.tbOnDisarm.Name = "tbOnDisarm"
			Dim tbOnDisarm2 As Global.System.Windows.Forms.Control = Me.tbOnDisarm
			size = New Global.System.Drawing.Size(204, 20)
			tbOnDisarm2.Size = size
			Me.tbOnDisarm.TabIndex = 2
			Me.tbOnDisarm.Text = ""
			Dim label23 As Global.System.Windows.Forms.Control = Me.Label41
			point = New Global.System.Drawing.Point(48, 88)
			label23.Location = point
			Me.Label41.Name = "Label41"
			Dim label24 As Global.System.Windows.Forms.Control = Me.Label41
			size = New Global.System.Drawing.Size(112, 18)
			label24.Size = size
			Me.Label41.TabIndex = 31
			Me.Label41.Text = "OnTrapTriggered"
			Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnTrapTriggered As Global.System.Windows.Forms.Control = Me.tbOnTrapTriggered
			point = New Global.System.Drawing.Point(168, 88)
			tbOnTrapTriggered.Location = point
			Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
			Dim tbOnTrapTriggered2 As Global.System.Windows.Forms.Control = Me.tbOnTrapTriggered
			size = New Global.System.Drawing.Size(204, 20)
			tbOnTrapTriggered2.Size = size
			Me.tbOnTrapTriggered.TabIndex = 4
			Me.tbOnTrapTriggered.Text = ""
			Dim tbOnClick As Global.System.Windows.Forms.Control = Me.tbOnClick
			point = New Global.System.Drawing.Point(168, 24)
			tbOnClick.Location = point
			Me.tbOnClick.Name = "tbOnClick"
			Dim tbOnClick2 As Global.System.Windows.Forms.Control = Me.tbOnClick
			size = New Global.System.Drawing.Size(204, 20)
			tbOnClick2.Size = size
			Me.tbOnClick.TabIndex = 0
			Me.tbOnClick.Text = ""
			Dim label25 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(48, 24)
			label25.Location = point
			Me.Label9.Name = "Label9"
			Dim label26 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(112, 18)
			label26.Size = size
			Me.Label9.TabIndex = 30
			Me.Label9.Text = "OnClick"
			Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditScriptOnExit As Global.System.Windows.Forms.Control = Me.btnEditScriptOnExit
			point = New Global.System.Drawing.Point(392, 184)
			btnEditScriptOnExit.Location = point
			Me.btnEditScriptOnExit.Name = "btnEditScriptOnExit"
			Dim btnEditScriptOnExit2 As Global.System.Windows.Forms.Control = Me.btnEditScriptOnExit
			size = New Global.System.Drawing.Size(32, 23)
			btnEditScriptOnExit2.Size = size
			Me.btnEditScriptOnExit.TabIndex = 11
			Me.btnEditScriptOnExit.Text = "Edit"
			Me.btnEditScriptOnExit.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditScriptUserDefine As Global.System.Windows.Forms.Control = Me.btnEditScriptUserDefine
			point = New Global.System.Drawing.Point(392, 216)
			btnEditScriptUserDefine.Location = point
			Me.btnEditScriptUserDefine.Name = "btnEditScriptUserDefine"
			Dim btnEditScriptUserDefine2 As Global.System.Windows.Forms.Control = Me.btnEditScriptUserDefine
			size = New Global.System.Drawing.Size(32, 23)
			btnEditScriptUserDefine2.Size = size
			Me.btnEditScriptUserDefine.TabIndex = 13
			Me.btnEditScriptUserDefine.Text = "Edit"
			Me.btnEditScriptUserDefine.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditScriptHeartbeat As Global.System.Windows.Forms.Control = Me.btnEditScriptHeartbeat
			point = New Global.System.Drawing.Point(392, 120)
			btnEditScriptHeartbeat.Location = point
			Me.btnEditScriptHeartbeat.Name = "btnEditScriptHeartbeat"
			Dim btnEditScriptHeartbeat2 As Global.System.Windows.Forms.Control = Me.btnEditScriptHeartbeat
			size = New Global.System.Drawing.Size(32, 23)
			btnEditScriptHeartbeat2.Size = size
			Me.btnEditScriptHeartbeat.TabIndex = 7
			Me.btnEditScriptHeartbeat.Text = "Edit"
			Me.btnEditScriptHeartbeat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnTrapTriggered As Global.System.Windows.Forms.Control = Me.btnEditOnTrapTriggered
			point = New Global.System.Drawing.Point(392, 88)
			btnEditOnTrapTriggered.Location = point
			Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
			Dim btnEditOnTrapTriggered2 As Global.System.Windows.Forms.Control = Me.btnEditOnTrapTriggered
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnTrapTriggered2.Size = size
			Me.btnEditOnTrapTriggered.TabIndex = 5
			Me.btnEditOnTrapTriggered.Text = "Edit"
			Me.btnEditOnTrapTriggered.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnDisarm As Global.System.Windows.Forms.Control = Me.btnEditOnDisarm
			point = New Global.System.Drawing.Point(392, 56)
			btnEditOnDisarm.Location = point
			Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
			Dim btnEditOnDisarm2 As Global.System.Windows.Forms.Control = Me.btnEditOnDisarm
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnDisarm2.Size = size
			Me.btnEditOnDisarm.TabIndex = 3
			Me.btnEditOnDisarm.Text = "Edit"
			Me.btnEditOnDisarm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnClick As Global.System.Windows.Forms.Control = Me.btnEditOnClick
			point = New Global.System.Drawing.Point(392, 24)
			btnEditOnClick.Location = point
			Me.btnEditOnClick.Name = "btnEditOnClick"
			Dim btnEditOnClick2 As Global.System.Windows.Forms.Control = Me.btnEditOnClick
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnClick2.Size = size
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
			Dim tabPageTrap As Global.System.Windows.Forms.Control = Me.TabPageTrap
			point = New Global.System.Drawing.Point(4, 22)
			tabPageTrap.Location = point
			Me.TabPageTrap.Name = "TabPageTrap"
			Dim tabPageTrap2 As Global.System.Windows.Forms.Control = Me.TabPageTrap
			size = New Global.System.Drawing.Size(440, 318)
			tabPageTrap2.Size = size
			Me.TabPageTrap.TabIndex = 9
			Me.TabPageTrap.Text = "Trap"
			Dim label27 As Global.System.Windows.Forms.Control = Me.Label15
			point = New Global.System.Drawing.Point(249, 220)
			label27.Location = point
			Me.Label15.Name = "Label15"
			Dim label28 As Global.System.Windows.Forms.Control = Me.Label15
			size = New Global.System.Drawing.Size(168, 20)
			label28.Size = size
			Me.Label15.TabIndex = 28
			Me.Label15.Text = "This is an index into traps.2da"
			Me.Label15.Visible = False
			Dim chkbAutoRemoveKey As Global.System.Windows.Forms.Control = Me.chkbAutoRemoveKey
			point = New Global.System.Drawing.Point(232, 277)
			chkbAutoRemoveKey.Location = point
			Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
			Dim chkbAutoRemoveKey2 As Global.System.Windows.Forms.Control = Me.chkbAutoRemoveKey
			size = New Global.System.Drawing.Size(24, 24)
			chkbAutoRemoveKey2.Size = size
			Me.chkbAutoRemoveKey.TabIndex = 8
			Dim tbKeyName As Global.System.Windows.Forms.Control = Me.tbKeyName
			point = New Global.System.Drawing.Point(176, 248)
			tbKeyName.Location = point
			Me.tbKeyName.Name = "tbKeyName"
			Dim tbKeyName2 As Global.System.Windows.Forms.Control = Me.tbKeyName
			size = New Global.System.Drawing.Size(136, 20)
			tbKeyName2.Size = size
			Me.tbKeyName.TabIndex = 7
			Me.tbKeyName.Text = ""
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
			Dim label29 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(48, 184)
			label29.Location = point
			Me.Label6.Name = "Label6"
			Dim label30 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(88, 16)
			label30.Size = size
			Me.Label6.TabIndex = 26
			Me.Label6.Text = "TrapOneShot"
			Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label31 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(48, 152)
			label31.Location = point
			Me.Label7.Name = "Label7"
			Dim label32 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(88, 16)
			label32.Size = size
			Me.Label7.TabIndex = 27
			Me.Label7.Text = "TrapFlag"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudDisarmDC As Global.System.Windows.Forms.Control = Me.nudDisarmDC
			point = New Global.System.Drawing.Point(176, 120)
			nudDisarmDC.Location = point
			Dim nudDisarmDC2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDisarmDC
			Dim num As Decimal = New Decimal(New Integer() { 250, 0, 0, 0 })
			nudDisarmDC2.Maximum = num
			Me.nudDisarmDC.Name = "nudDisarmDC"
			Me.nudDisarmDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim nudDisarmDC3 As Global.System.Windows.Forms.Control = Me.nudDisarmDC
			size = New Global.System.Drawing.Size(48, 20)
			nudDisarmDC3.Size = size
			Me.nudDisarmDC.TabIndex = 3
			Me.nudDisarmDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim label33 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(48, 120)
			label33.Location = point
			Me.Label4.Name = "Label4"
			Dim label34 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(88, 16)
			label34.Size = size
			Me.Label4.TabIndex = 22
			Me.Label4.Text = "DisarmDC"
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label35 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(48, 88)
			label35.Location = point
			Me.Label5.Name = "Label5"
			Dim label36 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(88, 16)
			label36.Size = size
			Me.Label5.TabIndex = 23
			Me.Label5.Text = "TrapDisarmable"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudTrapDetectDC As Global.System.Windows.Forms.Control = Me.nudTrapDetectDC
			point = New Global.System.Drawing.Point(176, 56)
			nudTrapDetectDC.Location = point
			Dim nudTrapDetectDC2 As Global.System.Windows.Forms.NumericUpDown = Me.nudTrapDetectDC
			num = New Decimal(New Integer() { 250, 0, 0, 0 })
			nudTrapDetectDC2.Maximum = num
			Me.nudTrapDetectDC.Name = "nudTrapDetectDC"
			Me.nudTrapDetectDC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim nudTrapDetectDC3 As Global.System.Windows.Forms.Control = Me.nudTrapDetectDC
			size = New Global.System.Drawing.Size(48, 20)
			nudTrapDetectDC3.Size = size
			Me.nudTrapDetectDC.TabIndex = 1
			Me.nudTrapDetectDC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim lblCloseLockDC As Global.System.Windows.Forms.Control = Me.lblCloseLockDC
			point = New Global.System.Drawing.Point(48, 56)
			lblCloseLockDC.Location = point
			Me.lblCloseLockDC.Name = "lblCloseLockDC"
			Dim lblCloseLockDC2 As Global.System.Windows.Forms.Control = Me.lblCloseLockDC
			size = New Global.System.Drawing.Size(88, 16)
			lblCloseLockDC2.Size = size
			Me.lblCloseLockDC.TabIndex = 18
			Me.lblCloseLockDC.Text = "TrapDetectDC"
			Me.lblCloseLockDC.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
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
			num = New Decimal(New Integer() { 13, 0, 0, 0 })
			nudTrapType2.Maximum = num
			Me.nudTrapType.Name = "nudTrapType"
			Me.nudTrapType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim nudTrapType3 As Global.System.Windows.Forms.Control = Me.nudTrapType
			size = New Global.System.Drawing.Size(48, 20)
			nudTrapType3.Size = size
			Me.nudTrapType.TabIndex = 6
			Me.nudTrapType.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim label37 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(48, 216)
			label37.Location = point
			Me.Label8.Name = "Label8"
			Dim label38 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(88, 16)
			label38.Size = size
			Me.Label8.TabIndex = 26
			Me.Label8.Text = "TrapType"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label39 As Global.System.Windows.Forms.Control = Me.Label12
			point = New Global.System.Drawing.Point(48, 248)
			label39.Location = point
			Me.Label12.Name = "Label12"
			Dim label40 As Global.System.Windows.Forms.Control = Me.Label12
			size = New Global.System.Drawing.Size(88, 16)
			label40.Size = size
			Me.Label12.TabIndex = 26
			Me.Label12.Text = "KeyName"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label41 As Global.System.Windows.Forms.Control = Me.Label13
			point = New Global.System.Drawing.Point(48, 280)
			label41.Location = point
			Me.Label13.Name = "Label13"
			Dim label42 As Global.System.Windows.Forms.Control = Me.Label13
			size = New Global.System.Drawing.Size(184, 16)
			label42.Size = size
			Me.Label13.TabIndex = 26
			Me.Label13.Text = "Automatically remove key after use"
			Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim chkbTrapFlag As Global.System.Windows.Forms.Control = Me.chkbTrapFlag
			point = New Global.System.Drawing.Point(192, 152)
			chkbTrapFlag.Location = point
			Me.chkbTrapFlag.Name = "chkbTrapFlag"
			Dim chkbTrapFlag2 As Global.System.Windows.Forms.Control = Me.chkbTrapFlag
			size = New Global.System.Drawing.Size(24, 24)
			chkbTrapFlag2.Size = size
			Me.chkbTrapFlag.TabIndex = 2
			Dim chkbTrapOneShot As Global.System.Windows.Forms.Control = Me.chkbTrapOneShot
			point = New Global.System.Drawing.Point(192, 184)
			chkbTrapOneShot.Location = point
			Me.chkbTrapOneShot.Name = "chkbTrapOneShot"
			Dim chkbTrapOneShot2 As Global.System.Windows.Forms.Control = Me.chkbTrapOneShot
			size = New Global.System.Drawing.Size(24, 24)
			chkbTrapOneShot2.Size = size
			Me.chkbTrapOneShot.TabIndex = 2
			Me.TabPageComments.Controls.Add(Me.tbComment)
			Dim tabPageComments As Global.System.Windows.Forms.Control = Me.TabPageComments
			point = New Global.System.Drawing.Point(4, 22)
			tabPageComments.Location = point
			Me.TabPageComments.Name = "TabPageComments"
			Dim tabPageComments2 As Global.System.Windows.Forms.Control = Me.TabPageComments
			size = New Global.System.Drawing.Size(440, 318)
			tabPageComments2.Size = size
			Me.TabPageComments.TabIndex = 8
			Me.TabPageComments.Text = "Comments"
			Me.tbComment.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim tbComment As Global.System.Windows.Forms.Control = Me.tbComment
			point = New Global.System.Drawing.Point(0, 0)
			tbComment.Location = point
			Me.tbComment.Multiline = True
			Me.tbComment.Name = "tbComment"
			Dim tbComment2 As Global.System.Windows.Forms.Control = Me.tbComment
			size = New Global.System.Drawing.Size(440, 318)
			tbComment2.Size = size
			Me.tbComment.TabIndex = 0
			Me.tbComment.Text = ""
			Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
			point = New Global.System.Drawing.Point(288, 368)
			btnSave.Location = point
			Me.btnSave.Name = "btnSave"
			Me.btnSave.TabIndex = 3
			Me.btnSave.Text = "&Save"
			Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			point = New Global.System.Drawing.Point(384, 368)
			btnCancel.Location = point
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.TabIndex = 4
			Me.btnCancel.Text = "&Cancel"
			Me.btnDebug.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
			Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
			point = New Global.System.Drawing.Point(0, 0)
			btnDebug.Location = point
			Me.btnDebug.Name = "btnDebug"
			Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
			size = New Global.System.Drawing.Size(8, 8)
			btnDebug2.Size = size
			Me.btnDebug.TabIndex = 17
			Me.btnDebug.TabStop = False
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.btnCancel
			size = New Global.System.Drawing.Size(480, 405)
			Me.ClientSize = size
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
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000B0D RID: 2829
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
