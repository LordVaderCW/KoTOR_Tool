Namespace kotor_tool
	' Token: 0x0200007C RID: 124
	Public Partial Class frmUTC_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x0600110A RID: 4362 RVA: 0x0029F218 File Offset: 0x0029E218
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06001285 RID: 4741 RVA: 0x002A1AE8 File Offset: 0x002A0AE8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUTC_Editor))
			Me.tabCtrl1 = New Global.System.Windows.Forms.TabControl()
			Me.tpBasic = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.chkbNotInterruptable = New Global.System.Windows.Forms.CheckBox()
			Me.tbConversation = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbxPortrait = New Global.System.Windows.Forms.ComboBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbxRace = New Global.System.Windows.Forms.ComboBox()
			Me.tbFirstName = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.tbLastName = New Global.System.Windows.Forms.TextBox()
			Me.tbTag = New Global.System.Windows.Forms.TextBox()
			Me.tbDescription = New Global.System.Windows.Forms.TextBox()
			Me.cmbxAppearance = New Global.System.Windows.Forms.ComboBox()
			Me.cmbxPhenotype = New Global.System.Windows.Forms.ComboBox()
			Me.cmbxGender = New Global.System.Windows.Forms.ComboBox()
			Me.cmbxBodyBag = New Global.System.Windows.Forms.ComboBox()
			Me.Label53 = New Global.System.Windows.Forms.Label()
			Me.tpStatistics = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox7 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbxMovementRate = New Global.System.Windows.Forms.ComboBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.gb2 = New Global.System.Windows.Forms.GroupBox()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.Label21 = New Global.System.Windows.Forms.Label()
			Me.nudWillBonus = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudFortBonus = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudRefBonus = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label22 = New Global.System.Windows.Forms.Label()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.nudStrength = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.nudDexterity = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudConstitution = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudIntelligence = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudWisdom = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudCharisma = New Global.System.Windows.Forms.NumericUpDown()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.nudNaturalAC = New Global.System.Windows.Forms.NumericUpDown()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.nudBaseHP = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label49 = New Global.System.Windows.Forms.Label()
			Me.nudCurrentHP = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudMaxHP = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label50 = New Global.System.Windows.Forms.Label()
			Me.tpSkills = New Global.System.Windows.Forms.TabPage()
			Me.nudComputerUse = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label24 = New Global.System.Windows.Forms.Label()
			Me.Label25 = New Global.System.Windows.Forms.Label()
			Me.Label26 = New Global.System.Windows.Forms.Label()
			Me.Label27 = New Global.System.Windows.Forms.Label()
			Me.Label28 = New Global.System.Windows.Forms.Label()
			Me.Label29 = New Global.System.Windows.Forms.Label()
			Me.nudDemolitions = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudStealth = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudAwareness = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudPersuade = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudRepair = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label30 = New Global.System.Windows.Forms.Label()
			Me.nudSecurity = New Global.System.Windows.Forms.NumericUpDown()
			Me.nudTreatInjury = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label31 = New Global.System.Windows.Forms.Label()
			Me.tpAdvanced = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox12 = New Global.System.Windows.Forms.GroupBox()
			Me.tbChallengeRating = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox11 = New Global.System.Windows.Forms.GroupBox()
			Me.nudMultiplierSet = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label51 = New Global.System.Windows.Forms.Label()
			Me.chkbDisarmable = New Global.System.Windows.Forms.CheckBox()
			Me.chkbPlot = New Global.System.Windows.Forms.CheckBox()
			Me.chkbNoPermDeath = New Global.System.Windows.Forms.CheckBox()
			Me.Label52 = New Global.System.Windows.Forms.Label()
			Me.tbDeity = New Global.System.Windows.Forms.TextBox()
			Me.chkbIsPC = New Global.System.Windows.Forms.CheckBox()
			Me.cmbxSubrace = New Global.System.Windows.Forms.ComboBox()
			Me.chkbIsHologram = New Global.System.Windows.Forms.CheckBox()
			Me.chkbNotReorienting = New Global.System.Windows.Forms.CheckBox()
			Me.chkbIgnoreCrePath = New Global.System.Windows.Forms.CheckBox()
			Me.lblMultiplierSet = New Global.System.Windows.Forms.Label()
			Me.lblBlindSpot = New Global.System.Windows.Forms.Label()
			Me.nudBlindSpot = New Global.System.Windows.Forms.NumericUpDown()
			Me.chkbMin1HP = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox13 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbxSoundSet = New Global.System.Windows.Forms.ComboBox()
			Me.GroupBox14 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbxPerceptionRange = New Global.System.Windows.Forms.ComboBox()
			Me.GroupBox15 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbxFaction = New Global.System.Windows.Forms.ComboBox()
			Me.GroupBox18 = New Global.System.Windows.Forms.GroupBox()
			Me.tbTemplateResRef = New Global.System.Windows.Forms.TextBox()
			Me.Label56 = New Global.System.Windows.Forms.Label()
			Me.Label57 = New Global.System.Windows.Forms.Label()
			Me.cmbxTreasureModel = New Global.System.Windows.Forms.ComboBox()
			Me.tpFeats = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox10 = New Global.System.Windows.Forms.GroupBox()
			Me.tbFeatSummary = New Global.System.Windows.Forms.TextBox()
			Me.chklbFeats = New Global.System.Windows.Forms.CheckedListBox()
			Me.toForcePowers = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox19 = New Global.System.Windows.Forms.GroupBox()
			Me.tbForcePowerSummary = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox17 = New Global.System.Windows.Forms.GroupBox()
			Me.chklbForcePowers = New Global.System.Windows.Forms.CheckedListBox()
			Me.btnSelectAllPowers = New Global.System.Windows.Forms.Button()
			Me.btnClearAllPowers = New Global.System.Windows.Forms.Button()
			Me.GroupBox16 = New Global.System.Windows.Forms.GroupBox()
			Me.nudForcePoints = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label54 = New Global.System.Windows.Forms.Label()
			Me.Label55 = New Global.System.Windows.Forms.Label()
			Me.nudCurrentForce = New Global.System.Windows.Forms.NumericUpDown()
			Me.tpClasses = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox9 = New Global.System.Windows.Forms.GroupBox()
			Me.Label46 = New Global.System.Windows.Forms.Label()
			Me.nudClassLevel = New Global.System.Windows.Forms.NumericUpDown()
			Me.cmbxClass = New Global.System.Windows.Forms.ComboBox()
			Me.Label23 = New Global.System.Windows.Forms.Label()
			Me.GroupBox8 = New Global.System.Windows.Forms.GroupBox()
			Me.nudAlignment = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label47 = New Global.System.Windows.Forms.Label()
			Me.trkbarAlignment = New Global.System.Windows.Forms.TrackBar()
			Me.Label48 = New Global.System.Windows.Forms.Label()
			Me.tpSpecialAbilities = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox20 = New Global.System.Windows.Forms.GroupBox()
			Me.chklbSpecialAbilities = New Global.System.Windows.Forms.CheckedListBox()
			Me.tpScripts = New Global.System.Windows.Forms.TabPage()
			Me.btnEditOnEndDialogu = New Global.System.Windows.Forms.Button()
			Me.btnEditOnDialogue = New Global.System.Windows.Forms.Button()
			Me.btnEditOnUserDefine = New Global.System.Windows.Forms.Button()
			Me.btnEditOnHeartbeat = New Global.System.Windows.Forms.Button()
			Me.btnEditOnDisturbed = New Global.System.Windows.Forms.Button()
			Me.btnEditOnDamaged = New Global.System.Windows.Forms.Button()
			Me.btnEditOnAttacked = New Global.System.Windows.Forms.Button()
			Me.Label34 = New Global.System.Windows.Forms.Label()
			Me.tbOnSpellAt = New Global.System.Windows.Forms.TextBox()
			Me.Label33 = New Global.System.Windows.Forms.Label()
			Me.tbOnNotice = New Global.System.Windows.Forms.TextBox()
			Me.Label32 = New Global.System.Windows.Forms.Label()
			Me.tbOnHeartbeat = New Global.System.Windows.Forms.TextBox()
			Me.Label35 = New Global.System.Windows.Forms.Label()
			Me.tbOnAttacked = New Global.System.Windows.Forms.TextBox()
			Me.tbOnDamaged = New Global.System.Windows.Forms.TextBox()
			Me.Label36 = New Global.System.Windows.Forms.Label()
			Me.Label37 = New Global.System.Windows.Forms.Label()
			Me.tbOnDisturbed = New Global.System.Windows.Forms.TextBox()
			Me.tbOnEndRound = New Global.System.Windows.Forms.TextBox()
			Me.Label38 = New Global.System.Windows.Forms.Label()
			Me.tbOnEndDialogu = New Global.System.Windows.Forms.TextBox()
			Me.Label39 = New Global.System.Windows.Forms.Label()
			Me.Label40 = New Global.System.Windows.Forms.Label()
			Me.tbOnDialogue = New Global.System.Windows.Forms.TextBox()
			Me.Label41 = New Global.System.Windows.Forms.Label()
			Me.tbOnSpawn = New Global.System.Windows.Forms.TextBox()
			Me.tbOnRested = New Global.System.Windows.Forms.TextBox()
			Me.Label42 = New Global.System.Windows.Forms.Label()
			Me.tbOnDeath = New Global.System.Windows.Forms.TextBox()
			Me.Label43 = New Global.System.Windows.Forms.Label()
			Me.Label44 = New Global.System.Windows.Forms.Label()
			Me.tbOnBlocked = New Global.System.Windows.Forms.TextBox()
			Me.tbOnUserDefine = New Global.System.Windows.Forms.TextBox()
			Me.Label45 = New Global.System.Windows.Forms.Label()
			Me.btnEditOnNotice = New Global.System.Windows.Forms.Button()
			Me.btnEditOnSpellAt = New Global.System.Windows.Forms.Button()
			Me.btnEditOnSpawn = New Global.System.Windows.Forms.Button()
			Me.btnEditOnDeath = New Global.System.Windows.Forms.Button()
			Me.btnEditOnBlocked = New Global.System.Windows.Forms.Button()
			Me.btnEditOnRested = New Global.System.Windows.Forms.Button()
			Me.btnEditOnEndRound = New Global.System.Windows.Forms.Button()
			Me.tpComments = New Global.System.Windows.Forms.TabPage()
			Me.tbComments = New Global.System.Windows.Forms.TextBox()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.btnWriteFile = New Global.System.Windows.Forms.Button()
			Me.btnInventory = New Global.System.Windows.Forms.Button()
			Me.btnDebug = New Global.System.Windows.Forms.Button()
			Me.tabCtrl1.SuspendLayout()
			Me.tpBasic.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.tpStatistics.SuspendLayout()
			Me.GroupBox7.SuspendLayout()
			Me.gb2.SuspendLayout()
			CType(Me.nudWillBonus, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudFortBonus, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudRefBonus, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox4.SuspendLayout()
			CType(Me.nudStrength, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudDexterity, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudConstitution, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudIntelligence, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudWisdom, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudCharisma, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox6.SuspendLayout()
			CType(Me.nudNaturalAC, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox5.SuspendLayout()
			CType(Me.nudBaseHP, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudCurrentHP, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudMaxHP, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpSkills.SuspendLayout()
			CType(Me.nudComputerUse, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudDemolitions, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudStealth, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudAwareness, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudPersuade, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudRepair, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudSecurity, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudTreatInjury, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpAdvanced.SuspendLayout()
			Me.GroupBox12.SuspendLayout()
			Me.GroupBox11.SuspendLayout()
			CType(Me.nudMultiplierSet, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudBlindSpot, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox13.SuspendLayout()
			Me.GroupBox14.SuspendLayout()
			Me.GroupBox15.SuspendLayout()
			Me.GroupBox18.SuspendLayout()
			Me.tpFeats.SuspendLayout()
			Me.GroupBox10.SuspendLayout()
			Me.toForcePowers.SuspendLayout()
			Me.GroupBox19.SuspendLayout()
			Me.GroupBox17.SuspendLayout()
			Me.GroupBox16.SuspendLayout()
			CType(Me.nudForcePoints, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nudCurrentForce, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpClasses.SuspendLayout()
			Me.GroupBox9.SuspendLayout()
			CType(Me.nudClassLevel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox8.SuspendLayout()
			CType(Me.nudAlignment, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trkbarAlignment, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpSpecialAbilities.SuspendLayout()
			Me.GroupBox20.SuspendLayout()
			Me.tpScripts.SuspendLayout()
			Me.tpComments.SuspendLayout()
			Me.SuspendLayout()
			Me.tabCtrl1.Controls.Add(Me.tpBasic)
			Me.tabCtrl1.Controls.Add(Me.tpStatistics)
			Me.tabCtrl1.Controls.Add(Me.tpSkills)
			Me.tabCtrl1.Controls.Add(Me.tpAdvanced)
			Me.tabCtrl1.Controls.Add(Me.tpFeats)
			Me.tabCtrl1.Controls.Add(Me.toForcePowers)
			Me.tabCtrl1.Controls.Add(Me.tpClasses)
			Me.tabCtrl1.Controls.Add(Me.tpSpecialAbilities)
			Me.tabCtrl1.Controls.Add(Me.tpScripts)
			Me.tabCtrl1.Controls.Add(Me.tpComments)
			Dim tabCtrl As Global.System.Windows.Forms.Control = Me.tabCtrl1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 32)
			tabCtrl.Location = point
			Me.tabCtrl1.Multiline = True
			Me.tabCtrl1.Name = "tabCtrl1"
			Dim tabCtrl2 As Global.System.Windows.Forms.TabControl = Me.tabCtrl1
			point = New Global.System.Drawing.Point(14, 3)
			tabCtrl2.Padding = point
			Me.tabCtrl1.SelectedIndex = 0
			Dim tabCtrl3 As Global.System.Windows.Forms.Control = Me.tabCtrl1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(416, 536)
			tabCtrl3.Size = size
			Me.tabCtrl1.SizeMode = Global.System.Windows.Forms.TabSizeMode.FillToRight
			Me.tabCtrl1.TabIndex = 0
			Me.tpBasic.Controls.Add(Me.GroupBox3)
			Me.tpBasic.Controls.Add(Me.GroupBox2)
			Me.tpBasic.Controls.Add(Me.GroupBox1)
			Dim tpBasic As Global.System.Windows.Forms.Control = Me.tpBasic
			point = New Global.System.Drawing.Point(4, 40)
			tpBasic.Location = point
			Me.tpBasic.Name = "tpBasic"
			Dim tpBasic2 As Global.System.Windows.Forms.Control = Me.tpBasic
			size = New Global.System.Drawing.Size(408, 492)
			tpBasic2.Size = size
			Me.tpBasic.TabIndex = 0
			Me.tpBasic.Text = "Basic"
			Me.GroupBox3.Controls.Add(Me.chkbNotInterruptable)
			Me.GroupBox3.Controls.Add(Me.tbConversation)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox3
			point = New Global.System.Drawing.Point(8, 432)
			groupBox.Location = point
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(392, 56)
			groupBox2.Size = size
			Me.GroupBox3.TabIndex = 2
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Conversation"
			Dim chkbNotInterruptable As Global.System.Windows.Forms.Control = Me.chkbNotInterruptable
			point = New Global.System.Drawing.Point(300, 24)
			chkbNotInterruptable.Location = point
			Me.chkbNotInterruptable.Name = "chkbNotInterruptable"
			Dim chkbNotInterruptable2 As Global.System.Windows.Forms.Control = Me.chkbNotInterruptable
			size = New Global.System.Drawing.Size(84, 24)
			chkbNotInterruptable2.Size = size
			Me.chkbNotInterruptable.TabIndex = 1
			Me.chkbNotInterruptable.Text = "No Interrupt"
			Dim tbConversation As Global.System.Windows.Forms.Control = Me.tbConversation
			point = New Global.System.Drawing.Point(24, 24)
			tbConversation.Location = point
			Me.tbConversation.Name = "tbConversation"
			Dim tbConversation2 As Global.System.Windows.Forms.Control = Me.tbConversation
			size = New Global.System.Drawing.Size(168, 20)
			tbConversation2.Size = size
			Me.tbConversation.TabIndex = 0
			Me.tbConversation.Text = ""
			Me.GroupBox2.Controls.Add(Me.cmbxPortrait)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(8, 312)
			groupBox3.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(392, 120)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Portrait"
			Me.cmbxPortrait.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxPortrait As Global.System.Windows.Forms.Control = Me.cmbxPortrait
			point = New Global.System.Drawing.Point(174, 54)
			cmbxPortrait.Location = point
			Me.cmbxPortrait.Name = "cmbxPortrait"
			Dim cmbxPortrait2 As Global.System.Windows.Forms.Control = Me.cmbxPortrait
			size = New Global.System.Drawing.Size(184, 21)
			cmbxPortrait2.Size = size
			Me.cmbxPortrait.TabIndex = 0
			Me.GroupBox1.Controls.Add(Me.cmbxRace)
			Me.GroupBox1.Controls.Add(Me.tbFirstName)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.tbLastName)
			Me.GroupBox1.Controls.Add(Me.tbTag)
			Me.GroupBox1.Controls.Add(Me.tbDescription)
			Me.GroupBox1.Controls.Add(Me.cmbxAppearance)
			Me.GroupBox1.Controls.Add(Me.cmbxPhenotype)
			Me.GroupBox1.Controls.Add(Me.cmbxGender)
			Me.GroupBox1.Controls.Add(Me.cmbxBodyBag)
			Me.GroupBox1.Controls.Add(Me.Label53)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(8, 8)
			groupBox5.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(392, 304)
			groupBox6.Size = size
			Me.GroupBox1.TabIndex = 0
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Profile"
			Me.cmbxRace.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxRace As Global.System.Windows.Forms.Control = Me.cmbxRace
			point = New Global.System.Drawing.Point(104, 104)
			cmbxRace.Location = point
			Me.cmbxRace.Name = "cmbxRace"
			Dim cmbxRace2 As Global.System.Windows.Forms.Control = Me.cmbxRace
			size = New Global.System.Drawing.Size(184, 21)
			cmbxRace2.Size = size
			Me.cmbxRace.TabIndex = 3
			Dim tbFirstName As Global.System.Windows.Forms.Control = Me.tbFirstName
			point = New Global.System.Drawing.Point(104, 20)
			tbFirstName.Location = point
			Me.tbFirstName.Name = "tbFirstName"
			Dim tbFirstName2 As Global.System.Windows.Forms.Control = Me.tbFirstName
			size = New Global.System.Drawing.Size(184, 20)
			tbFirstName2.Size = size
			Me.tbFirstName.TabIndex = 0
			Me.tbFirstName.Text = ""
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(16, 22)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(80, 16)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "First Name:"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(16, 50)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(80, 16)
			label4.Size = size
			Me.Label2.TabIndex = 0
			Me.Label2.Text = "Last Name:"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(16, 78)
			label5.Location = point
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(80, 16)
			label6.Size = size
			Me.Label3.TabIndex = 0
			Me.Label3.Text = "Tag"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(16, 106)
			label7.Location = point
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(80, 16)
			label8.Size = size
			Me.Label4.TabIndex = 0
			Me.Label4.Text = "Race"
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(16, 138)
			label9.Location = point
			Me.Label5.Name = "Label5"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(80, 16)
			label10.Size = size
			Me.Label5.TabIndex = 0
			Me.Label5.Text = "Appearance"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(16, 170)
			label11.Location = point
			Me.Label6.Name = "Label6"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(80, 16)
			label12.Size = size
			Me.Label6.TabIndex = 0
			Me.Label6.Text = "Phenotype"
			Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(16, 234)
			label13.Location = point
			Me.Label7.Name = "Label7"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(80, 16)
			label14.Size = size
			Me.Label7.TabIndex = 0
			Me.Label7.Text = "Description"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(16, 202)
			label15.Location = point
			Me.Label9.Name = "Label9"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(80, 16)
			label16.Size = size
			Me.Label9.TabIndex = 0
			Me.Label9.Text = "Gender"
			Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbLastName As Global.System.Windows.Forms.Control = Me.tbLastName
			point = New Global.System.Drawing.Point(104, 48)
			tbLastName.Location = point
			Me.tbLastName.Name = "tbLastName"
			Me.tbLastName.[ReadOnly] = True
			Dim tbLastName2 As Global.System.Windows.Forms.Control = Me.tbLastName
			size = New Global.System.Drawing.Size(184, 20)
			tbLastName2.Size = size
			Me.tbLastName.TabIndex = 1
			Me.tbLastName.Text = ""
			Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
			point = New Global.System.Drawing.Point(104, 76)
			tbTag.Location = point
			Me.tbTag.Name = "tbTag"
			Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
			size = New Global.System.Drawing.Size(184, 20)
			tbTag2.Size = size
			Me.tbTag.TabIndex = 2
			Me.tbTag.Text = ""
			Dim tbDescription As Global.System.Windows.Forms.Control = Me.tbDescription
			point = New Global.System.Drawing.Point(104, 232)
			tbDescription.Location = point
			Me.tbDescription.Name = "tbDescription"
			Dim tbDescription2 As Global.System.Windows.Forms.Control = Me.tbDescription
			size = New Global.System.Drawing.Size(184, 20)
			tbDescription2.Size = size
			Me.tbDescription.TabIndex = 7
			Me.tbDescription.Text = ""
			Me.cmbxAppearance.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxAppearance As Global.System.Windows.Forms.Control = Me.cmbxAppearance
			point = New Global.System.Drawing.Point(104, 136)
			cmbxAppearance.Location = point
			Me.cmbxAppearance.Name = "cmbxAppearance"
			Dim cmbxAppearance2 As Global.System.Windows.Forms.Control = Me.cmbxAppearance
			size = New Global.System.Drawing.Size(184, 21)
			cmbxAppearance2.Size = size
			Me.cmbxAppearance.TabIndex = 4
			Me.cmbxPhenotype.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxPhenotype As Global.System.Windows.Forms.Control = Me.cmbxPhenotype
			point = New Global.System.Drawing.Point(104, 168)
			cmbxPhenotype.Location = point
			Me.cmbxPhenotype.Name = "cmbxPhenotype"
			Dim cmbxPhenotype2 As Global.System.Windows.Forms.Control = Me.cmbxPhenotype
			size = New Global.System.Drawing.Size(184, 21)
			cmbxPhenotype2.Size = size
			Me.cmbxPhenotype.TabIndex = 5
			Me.cmbxGender.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxGender As Global.System.Windows.Forms.Control = Me.cmbxGender
			point = New Global.System.Drawing.Point(104, 200)
			cmbxGender.Location = point
			Me.cmbxGender.Name = "cmbxGender"
			Dim cmbxGender2 As Global.System.Windows.Forms.Control = Me.cmbxGender
			size = New Global.System.Drawing.Size(184, 21)
			cmbxGender2.Size = size
			Me.cmbxGender.TabIndex = 6
			Me.cmbxBodyBag.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxBodyBag As Global.System.Windows.Forms.Control = Me.cmbxBodyBag
			point = New Global.System.Drawing.Point(104, 268)
			cmbxBodyBag.Location = point
			Me.cmbxBodyBag.Name = "cmbxBodyBag"
			Dim cmbxBodyBag2 As Global.System.Windows.Forms.Control = Me.cmbxBodyBag
			size = New Global.System.Drawing.Size(184, 21)
			cmbxBodyBag2.Size = size
			Me.cmbxBodyBag.TabIndex = 4
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label53
			point = New Global.System.Drawing.Point(16, 270)
			label17.Location = point
			Me.Label53.Name = "Label53"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label53
			size = New Global.System.Drawing.Size(80, 16)
			label18.Size = size
			Me.Label53.TabIndex = 0
			Me.Label53.Text = "BodyBag"
			Me.Label53.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tpStatistics.Controls.Add(Me.GroupBox7)
			Me.tpStatistics.Controls.Add(Me.gb2)
			Me.tpStatistics.Controls.Add(Me.GroupBox4)
			Me.tpStatistics.Controls.Add(Me.GroupBox6)
			Me.tpStatistics.Controls.Add(Me.GroupBox5)
			Dim tpStatistics As Global.System.Windows.Forms.Control = Me.tpStatistics
			point = New Global.System.Drawing.Point(4, 40)
			tpStatistics.Location = point
			Me.tpStatistics.Name = "tpStatistics"
			Dim tpStatistics2 As Global.System.Windows.Forms.Control = Me.tpStatistics
			size = New Global.System.Drawing.Size(408, 492)
			tpStatistics2.Size = size
			Me.tpStatistics.TabIndex = 1
			Me.tpStatistics.Text = "Statistics"
			Me.GroupBox7.Controls.Add(Me.cmbxMovementRate)
			Me.GroupBox7.Controls.Add(Me.Label18)
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox7
			point = New Global.System.Drawing.Point(210, 432)
			groupBox7.Location = point
			Me.GroupBox7.Name = "GroupBox7"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox7
			size = New Global.System.Drawing.Size(192, 48)
			groupBox8.Size = size
			Me.GroupBox7.TabIndex = 3
			Me.GroupBox7.TabStop = False
			Me.GroupBox7.Text = "Speed"
			Me.cmbxMovementRate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxMovementRate As Global.System.Windows.Forms.Control = Me.cmbxMovementRate
			point = New Global.System.Drawing.Point(102, 18)
			cmbxMovementRate.Location = point
			Me.cmbxMovementRate.Name = "cmbxMovementRate"
			Dim cmbxMovementRate2 As Global.System.Windows.Forms.Control = Me.cmbxMovementRate
			size = New Global.System.Drawing.Size(72, 21)
			cmbxMovementRate2.Size = size
			Me.cmbxMovementRate.TabIndex = 0
			Dim label19 As Global.System.Windows.Forms.Control = Me.Label18
			point = New Global.System.Drawing.Point(12, 20)
			label19.Location = point
			Me.Label18.Name = "Label18"
			Dim label20 As Global.System.Windows.Forms.Control = Me.Label18
			size = New Global.System.Drawing.Size(84, 18)
			label20.Size = size
			Me.Label18.TabIndex = 1
			Me.Label18.Text = "Movement Rate"
			Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.gb2.Controls.Add(Me.Label19)
			Me.gb2.Controls.Add(Me.Label20)
			Me.gb2.Controls.Add(Me.Label21)
			Me.gb2.Controls.Add(Me.nudWillBonus)
			Me.gb2.Controls.Add(Me.nudFortBonus)
			Me.gb2.Controls.Add(Me.nudRefBonus)
			Me.gb2.Controls.Add(Me.Label22)
			Dim gb As Global.System.Windows.Forms.Control = Me.gb2
			point = New Global.System.Drawing.Point(6, 210)
			gb.Location = point
			Me.gb2.Name = "gb2"
			Dim gb2 As Global.System.Windows.Forms.Control = Me.gb2
			size = New Global.System.Drawing.Size(396, 108)
			gb2.Size = size
			Me.gb2.TabIndex = 2
			Me.gb2.TabStop = False
			Me.gb2.Text = "Saves"
			Dim label21 As Global.System.Windows.Forms.Control = Me.Label19
			point = New Global.System.Drawing.Point(32, 59)
			label21.Location = point
			Me.Label19.Name = "Label19"
			Dim label22 As Global.System.Windows.Forms.Control = Me.Label19
			size = New Global.System.Drawing.Size(66, 18)
			label22.Size = size
			Me.Label19.TabIndex = 0
			Me.Label19.Text = "Reflex"
			Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label23 As Global.System.Windows.Forms.Control = Me.Label20
			point = New Global.System.Drawing.Point(32, 83)
			label23.Location = point
			Me.Label20.Name = "Label20"
			Dim label24 As Global.System.Windows.Forms.Control = Me.Label20
			size = New Global.System.Drawing.Size(66, 18)
			label24.Size = size
			Me.Label20.TabIndex = 0
			Me.Label20.Text = "Will"
			Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label25 As Global.System.Windows.Forms.Control = Me.Label21
			point = New Global.System.Drawing.Point(32, 35)
			label25.Location = point
			Me.Label21.Name = "Label21"
			Dim label26 As Global.System.Windows.Forms.Control = Me.Label21
			size = New Global.System.Drawing.Size(66, 18)
			label26.Size = size
			Me.Label21.TabIndex = 0
			Me.Label21.Text = "Fortitude"
			Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudWillBonus As Global.System.Windows.Forms.Control = Me.nudWillBonus
			point = New Global.System.Drawing.Point(126, 83)
			nudWillBonus.Location = point
			Dim nudWillBonus2 As Global.System.Windows.Forms.NumericUpDown = Me.nudWillBonus
			Dim num As Decimal = New Decimal(New Integer() { 250, 0, 0, 0 })
			nudWillBonus2.Maximum = num
			Me.nudWillBonus.Name = "nudWillBonus"
			Dim nudWillBonus3 As Global.System.Windows.Forms.Control = Me.nudWillBonus
			size = New Global.System.Drawing.Size(42, 20)
			nudWillBonus3.Size = size
			Me.nudWillBonus.TabIndex = 2
			Me.nudWillBonus.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudFortBonus As Global.System.Windows.Forms.Control = Me.nudFortBonus
			point = New Global.System.Drawing.Point(126, 35)
			nudFortBonus.Location = point
			Dim nudFortBonus2 As Global.System.Windows.Forms.NumericUpDown = Me.nudFortBonus
			num = New Decimal(New Integer() { 250, 0, 0, 0 })
			nudFortBonus2.Maximum = num
			Me.nudFortBonus.Name = "nudFortBonus"
			Dim nudFortBonus3 As Global.System.Windows.Forms.Control = Me.nudFortBonus
			size = New Global.System.Drawing.Size(42, 20)
			nudFortBonus3.Size = size
			Me.nudFortBonus.TabIndex = 0
			Me.nudFortBonus.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudRefBonus As Global.System.Windows.Forms.Control = Me.nudRefBonus
			point = New Global.System.Drawing.Point(126, 59)
			nudRefBonus.Location = point
			Dim nudRefBonus2 As Global.System.Windows.Forms.NumericUpDown = Me.nudRefBonus
			num = New Decimal(New Integer() { 250, 0, 0, 0 })
			nudRefBonus2.Maximum = num
			Me.nudRefBonus.Name = "nudRefBonus"
			Dim nudRefBonus3 As Global.System.Windows.Forms.Control = Me.nudRefBonus
			size = New Global.System.Drawing.Size(42, 20)
			nudRefBonus3.Size = size
			Me.nudRefBonus.TabIndex = 1
			Me.nudRefBonus.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim label27 As Global.System.Windows.Forms.Control = Me.Label22
			point = New Global.System.Drawing.Point(126, 16)
			label27.Location = point
			Me.Label22.Name = "Label22"
			Dim label28 As Global.System.Windows.Forms.Control = Me.Label22
			size = New Global.System.Drawing.Size(66, 18)
			label28.Size = size
			Me.Label22.TabIndex = 0
			Me.Label22.Text = "Bonus"
			Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.GroupBox4.Controls.Add(Me.nudStrength)
			Me.GroupBox4.Controls.Add(Me.Label14)
			Me.GroupBox4.Controls.Add(Me.Label10)
			Me.GroupBox4.Controls.Add(Me.Label11)
			Me.GroupBox4.Controls.Add(Me.Label13)
			Me.GroupBox4.Controls.Add(Me.Label8)
			Me.GroupBox4.Controls.Add(Me.Label12)
			Me.GroupBox4.Controls.Add(Me.Label15)
			Me.GroupBox4.Controls.Add(Me.nudDexterity)
			Me.GroupBox4.Controls.Add(Me.nudConstitution)
			Me.GroupBox4.Controls.Add(Me.nudIntelligence)
			Me.GroupBox4.Controls.Add(Me.nudWisdom)
			Me.GroupBox4.Controls.Add(Me.nudCharisma)
			Dim groupBox9 As Global.System.Windows.Forms.Control = Me.GroupBox4
			point = New Global.System.Drawing.Point(6, 12)
			groupBox9.Location = point
			Me.GroupBox4.Name = "GroupBox4"
			Dim groupBox10 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(396, 186)
			groupBox10.Size = size
			Me.GroupBox4.TabIndex = 1
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Ability Score"
			Dim nudStrength As Global.System.Windows.Forms.Control = Me.nudStrength
			point = New Global.System.Drawing.Point(126, 30)
			nudStrength.Location = point
			Dim nudStrength2 As Global.System.Windows.Forms.NumericUpDown = Me.nudStrength
			num = New Decimal(New Integer() { 3, 0, 0, 0 })
			nudStrength2.Minimum = num
			Me.nudStrength.Name = "nudStrength"
			Dim nudStrength3 As Global.System.Windows.Forms.Control = Me.nudStrength
			size = New Global.System.Drawing.Size(42, 20)
			nudStrength3.Size = size
			Me.nudStrength.TabIndex = 0
			Me.nudStrength.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudStrength4 As Global.System.Windows.Forms.NumericUpDown = Me.nudStrength
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudStrength4.Value = num
			Dim label29 As Global.System.Windows.Forms.Control = Me.Label14
			point = New Global.System.Drawing.Point(30, 151)
			label29.Location = point
			Me.Label14.Name = "Label14"
			Dim label30 As Global.System.Windows.Forms.Control = Me.Label14
			size = New Global.System.Drawing.Size(66, 18)
			label30.Size = size
			Me.Label14.TabIndex = 0
			Me.Label14.Text = "Charisma"
			Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label31 As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(30, 55)
			label31.Location = point
			Me.Label10.Name = "Label10"
			Dim label32 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(66, 18)
			label32.Size = size
			Me.Label10.TabIndex = 0
			Me.Label10.Text = "Dexterity"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label33 As Global.System.Windows.Forms.Control = Me.Label11
			point = New Global.System.Drawing.Point(30, 79)
			label33.Location = point
			Me.Label11.Name = "Label11"
			Dim label34 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(66, 18)
			label34.Size = size
			Me.Label11.TabIndex = 0
			Me.Label11.Text = "Constitution"
			Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label35 As Global.System.Windows.Forms.Control = Me.Label13
			point = New Global.System.Drawing.Point(30, 127)
			label35.Location = point
			Me.Label13.Name = "Label13"
			Dim label36 As Global.System.Windows.Forms.Control = Me.Label13
			size = New Global.System.Drawing.Size(66, 18)
			label36.Size = size
			Me.Label13.TabIndex = 0
			Me.Label13.Text = "Wisdom"
			Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label37 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(30, 31)
			label37.Location = point
			Me.Label8.Name = "Label8"
			Dim label38 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(66, 18)
			label38.Size = size
			Me.Label8.TabIndex = 0
			Me.Label8.Text = "Strength"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label39 As Global.System.Windows.Forms.Control = Me.Label12
			point = New Global.System.Drawing.Point(30, 103)
			label39.Location = point
			Me.Label12.Name = "Label12"
			Dim label40 As Global.System.Windows.Forms.Control = Me.Label12
			size = New Global.System.Drawing.Size(66, 18)
			label40.Size = size
			Me.Label12.TabIndex = 0
			Me.Label12.Text = "Intelligence"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label41 As Global.System.Windows.Forms.Control = Me.Label15
			point = New Global.System.Drawing.Point(126, 12)
			label41.Location = point
			Me.Label15.Name = "Label15"
			Dim label42 As Global.System.Windows.Forms.Control = Me.Label15
			size = New Global.System.Drawing.Size(42, 18)
			label42.Size = size
			Me.Label15.TabIndex = 0
			Me.Label15.Text = "Score"
			Dim nudDexterity As Global.System.Windows.Forms.Control = Me.nudDexterity
			point = New Global.System.Drawing.Point(126, 54)
			nudDexterity.Location = point
			Dim nudDexterity2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDexterity
			num = New Decimal(New Integer() { 3, 0, 0, 0 })
			nudDexterity2.Minimum = num
			Me.nudDexterity.Name = "nudDexterity"
			Dim nudDexterity3 As Global.System.Windows.Forms.Control = Me.nudDexterity
			size = New Global.System.Drawing.Size(42, 20)
			nudDexterity3.Size = size
			Me.nudDexterity.TabIndex = 1
			Me.nudDexterity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudDexterity4 As Global.System.Windows.Forms.NumericUpDown = Me.nudDexterity
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudDexterity4.Value = num
			Dim nudConstitution As Global.System.Windows.Forms.Control = Me.nudConstitution
			point = New Global.System.Drawing.Point(126, 78)
			nudConstitution.Location = point
			Dim nudConstitution2 As Global.System.Windows.Forms.NumericUpDown = Me.nudConstitution
			num = New Decimal(New Integer() { 3, 0, 0, 0 })
			nudConstitution2.Minimum = num
			Me.nudConstitution.Name = "nudConstitution"
			Dim nudConstitution3 As Global.System.Windows.Forms.Control = Me.nudConstitution
			size = New Global.System.Drawing.Size(42, 20)
			nudConstitution3.Size = size
			Me.nudConstitution.TabIndex = 2
			Me.nudConstitution.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudConstitution4 As Global.System.Windows.Forms.NumericUpDown = Me.nudConstitution
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudConstitution4.Value = num
			Dim nudIntelligence As Global.System.Windows.Forms.Control = Me.nudIntelligence
			point = New Global.System.Drawing.Point(126, 102)
			nudIntelligence.Location = point
			Dim nudIntelligence2 As Global.System.Windows.Forms.NumericUpDown = Me.nudIntelligence
			num = New Decimal(New Integer() { 3, 0, 0, 0 })
			nudIntelligence2.Minimum = num
			Me.nudIntelligence.Name = "nudIntelligence"
			Dim nudIntelligence3 As Global.System.Windows.Forms.Control = Me.nudIntelligence
			size = New Global.System.Drawing.Size(42, 20)
			nudIntelligence3.Size = size
			Me.nudIntelligence.TabIndex = 3
			Me.nudIntelligence.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudIntelligence4 As Global.System.Windows.Forms.NumericUpDown = Me.nudIntelligence
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudIntelligence4.Value = num
			Dim nudWisdom As Global.System.Windows.Forms.Control = Me.nudWisdom
			point = New Global.System.Drawing.Point(126, 126)
			nudWisdom.Location = point
			Dim nudWisdom2 As Global.System.Windows.Forms.NumericUpDown = Me.nudWisdom
			num = New Decimal(New Integer() { 3, 0, 0, 0 })
			nudWisdom2.Minimum = num
			Me.nudWisdom.Name = "nudWisdom"
			Dim nudWisdom3 As Global.System.Windows.Forms.Control = Me.nudWisdom
			size = New Global.System.Drawing.Size(42, 20)
			nudWisdom3.Size = size
			Me.nudWisdom.TabIndex = 4
			Me.nudWisdom.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudWisdom4 As Global.System.Windows.Forms.NumericUpDown = Me.nudWisdom
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudWisdom4.Value = num
			Dim nudCharisma As Global.System.Windows.Forms.Control = Me.nudCharisma
			point = New Global.System.Drawing.Point(126, 150)
			nudCharisma.Location = point
			Dim nudCharisma2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCharisma
			num = New Decimal(New Integer() { 3, 0, 0, 0 })
			nudCharisma2.Minimum = num
			Me.nudCharisma.Name = "nudCharisma"
			Dim nudCharisma3 As Global.System.Windows.Forms.Control = Me.nudCharisma
			size = New Global.System.Drawing.Size(42, 20)
			nudCharisma3.Size = size
			Me.nudCharisma.TabIndex = 5
			Me.nudCharisma.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudCharisma4 As Global.System.Windows.Forms.NumericUpDown = Me.nudCharisma
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudCharisma4.Value = num
			Me.GroupBox6.Controls.Add(Me.Label16)
			Me.GroupBox6.Controls.Add(Me.nudNaturalAC)
			Dim groupBox11 As Global.System.Windows.Forms.Control = Me.GroupBox6
			point = New Global.System.Drawing.Point(6, 324)
			groupBox11.Location = point
			Me.GroupBox6.Name = "GroupBox6"
			Dim groupBox12 As Global.System.Windows.Forms.Control = Me.GroupBox6
			size = New Global.System.Drawing.Size(198, 156)
			groupBox12.Size = size
			Me.GroupBox6.TabIndex = 2
			Me.GroupBox6.TabStop = False
			Me.GroupBox6.Text = "Armor Class"
			Dim label43 As Global.System.Windows.Forms.Control = Me.Label16
			point = New Global.System.Drawing.Point(8, 25)
			label43.Location = point
			Me.Label16.Name = "Label16"
			Dim label44 As Global.System.Windows.Forms.Control = Me.Label16
			size = New Global.System.Drawing.Size(66, 18)
			label44.Size = size
			Me.Label16.TabIndex = 1
			Me.Label16.Text = "Natural AC"
			Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudNaturalAC As Global.System.Windows.Forms.Control = Me.nudNaturalAC
			point = New Global.System.Drawing.Point(114, 24)
			nudNaturalAC.Location = point
			Dim nudNaturalAC2 As Global.System.Windows.Forms.NumericUpDown = Me.nudNaturalAC
			num = New Decimal(New Integer() { 1000, 0, 0, 0 })
			nudNaturalAC2.Maximum = num
			Me.nudNaturalAC.Name = "nudNaturalAC"
			Dim nudNaturalAC3 As Global.System.Windows.Forms.Control = Me.nudNaturalAC
			size = New Global.System.Drawing.Size(48, 20)
			nudNaturalAC3.Size = size
			Me.nudNaturalAC.TabIndex = 0
			Me.nudNaturalAC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudNaturalAC4 As Global.System.Windows.Forms.NumericUpDown = Me.nudNaturalAC
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudNaturalAC4.Value = num
			Me.GroupBox5.Controls.Add(Me.Label17)
			Me.GroupBox5.Controls.Add(Me.nudBaseHP)
			Me.GroupBox5.Controls.Add(Me.Label49)
			Me.GroupBox5.Controls.Add(Me.nudCurrentHP)
			Me.GroupBox5.Controls.Add(Me.nudMaxHP)
			Me.GroupBox5.Controls.Add(Me.Label50)
			Dim groupBox13 As Global.System.Windows.Forms.Control = Me.GroupBox5
			point = New Global.System.Drawing.Point(210, 324)
			groupBox13.Location = point
			Me.GroupBox5.Name = "GroupBox5"
			Dim groupBox14 As Global.System.Windows.Forms.Control = Me.GroupBox5
			size = New Global.System.Drawing.Size(192, 108)
			groupBox14.Size = size
			Me.GroupBox5.TabIndex = 2
			Me.GroupBox5.TabStop = False
			Me.GroupBox5.Text = "Hit Points"
			Dim label45 As Global.System.Windows.Forms.Control = Me.Label17
			point = New Global.System.Drawing.Point(19, 24)
			label45.Location = point
			Me.Label17.Name = "Label17"
			Dim label46 As Global.System.Windows.Forms.Control = Me.Label17
			size = New Global.System.Drawing.Size(85, 18)
			label46.Size = size
			Me.Label17.TabIndex = 3
			Me.Label17.Text = "Base Hit Points"
			Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudBaseHP As Global.System.Windows.Forms.Control = Me.nudBaseHP
			point = New Global.System.Drawing.Point(125, 24)
			nudBaseHP.Location = point
			Dim nudBaseHP2 As Global.System.Windows.Forms.NumericUpDown = Me.nudBaseHP
			num = New Decimal(New Integer() { 9999, 0, 0, 0 })
			nudBaseHP2.Maximum = num
			Dim nudBaseHP3 As Global.System.Windows.Forms.NumericUpDown = Me.nudBaseHP
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			nudBaseHP3.Minimum = num
			Me.nudBaseHP.Name = "nudBaseHP"
			Dim nudBaseHP4 As Global.System.Windows.Forms.Control = Me.nudBaseHP
			size = New Global.System.Drawing.Size(48, 20)
			nudBaseHP4.Size = size
			Me.nudBaseHP.TabIndex = 0
			Me.nudBaseHP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudBaseHP5 As Global.System.Windows.Forms.NumericUpDown = Me.nudBaseHP
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudBaseHP5.Value = num
			Dim label47 As Global.System.Windows.Forms.Control = Me.Label49
			point = New Global.System.Drawing.Point(19, 49)
			label47.Location = point
			Me.Label49.Name = "Label49"
			Dim label48 As Global.System.Windows.Forms.Control = Me.Label49
			size = New Global.System.Drawing.Size(96, 18)
			label48.Size = size
			Me.Label49.TabIndex = 3
			Me.Label49.Text = "Current Hit Points"
			Me.Label49.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudCurrentHP As Global.System.Windows.Forms.Control = Me.nudCurrentHP
			point = New Global.System.Drawing.Point(125, 48)
			nudCurrentHP.Location = point
			Dim nudCurrentHP2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCurrentHP
			num = New Decimal(New Integer() { 9999, 0, 0, 0 })
			nudCurrentHP2.Maximum = num
			Dim nudCurrentHP3 As Global.System.Windows.Forms.NumericUpDown = Me.nudCurrentHP
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			nudCurrentHP3.Minimum = num
			Me.nudCurrentHP.Name = "nudCurrentHP"
			Dim nudCurrentHP4 As Global.System.Windows.Forms.Control = Me.nudCurrentHP
			size = New Global.System.Drawing.Size(48, 20)
			nudCurrentHP4.Size = size
			Me.nudCurrentHP.TabIndex = 1
			Me.nudCurrentHP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudCurrentHP5 As Global.System.Windows.Forms.NumericUpDown = Me.nudCurrentHP
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudCurrentHP5.Value = num
			Dim nudMaxHP As Global.System.Windows.Forms.Control = Me.nudMaxHP
			point = New Global.System.Drawing.Point(125, 72)
			nudMaxHP.Location = point
			Dim nudMaxHP2 As Global.System.Windows.Forms.NumericUpDown = Me.nudMaxHP
			num = New Decimal(New Integer() { 9999, 0, 0, 0 })
			nudMaxHP2.Maximum = num
			Dim nudMaxHP3 As Global.System.Windows.Forms.NumericUpDown = Me.nudMaxHP
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			nudMaxHP3.Minimum = num
			Me.nudMaxHP.Name = "nudMaxHP"
			Dim nudMaxHP4 As Global.System.Windows.Forms.Control = Me.nudMaxHP
			size = New Global.System.Drawing.Size(48, 20)
			nudMaxHP4.Size = size
			Me.nudMaxHP.TabIndex = 2
			Me.nudMaxHP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudMaxHP5 As Global.System.Windows.Forms.NumericUpDown = Me.nudMaxHP
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudMaxHP5.Value = num
			Dim label49 As Global.System.Windows.Forms.Control = Me.Label50
			point = New Global.System.Drawing.Point(19, 73)
			label49.Location = point
			Me.Label50.Name = "Label50"
			Dim label50 As Global.System.Windows.Forms.Control = Me.Label50
			size = New Global.System.Drawing.Size(85, 18)
			label50.Size = size
			Me.Label50.TabIndex = 3
			Me.Label50.Text = "Max Hit Points"
			Me.Label50.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tpSkills.Controls.Add(Me.nudComputerUse)
			Me.tpSkills.Controls.Add(Me.Label24)
			Me.tpSkills.Controls.Add(Me.Label25)
			Me.tpSkills.Controls.Add(Me.Label26)
			Me.tpSkills.Controls.Add(Me.Label27)
			Me.tpSkills.Controls.Add(Me.Label28)
			Me.tpSkills.Controls.Add(Me.Label29)
			Me.tpSkills.Controls.Add(Me.nudDemolitions)
			Me.tpSkills.Controls.Add(Me.nudStealth)
			Me.tpSkills.Controls.Add(Me.nudAwareness)
			Me.tpSkills.Controls.Add(Me.nudPersuade)
			Me.tpSkills.Controls.Add(Me.nudRepair)
			Me.tpSkills.Controls.Add(Me.Label30)
			Me.tpSkills.Controls.Add(Me.nudSecurity)
			Me.tpSkills.Controls.Add(Me.nudTreatInjury)
			Me.tpSkills.Controls.Add(Me.Label31)
			Dim tpSkills As Global.System.Windows.Forms.Control = Me.tpSkills
			point = New Global.System.Drawing.Point(4, 40)
			tpSkills.Location = point
			Me.tpSkills.Name = "tpSkills"
			Dim tpSkills2 As Global.System.Windows.Forms.Control = Me.tpSkills
			size = New Global.System.Drawing.Size(408, 492)
			tpSkills2.Size = size
			Me.tpSkills.TabIndex = 4
			Me.tpSkills.Text = "Skills"
			Dim nudComputerUse As Global.System.Windows.Forms.Control = Me.nudComputerUse
			point = New Global.System.Drawing.Point(186, 60)
			nudComputerUse.Location = point
			Me.nudComputerUse.Name = "nudComputerUse"
			Dim nudComputerUse2 As Global.System.Windows.Forms.Control = Me.nudComputerUse
			size = New Global.System.Drawing.Size(42, 20)
			nudComputerUse2.Size = size
			Me.nudComputerUse.TabIndex = 0
			Me.nudComputerUse.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudComputerUse3 As Global.System.Windows.Forms.NumericUpDown = Me.nudComputerUse
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudComputerUse3.Value = num
			Dim label51 As Global.System.Windows.Forms.Control = Me.Label24
			point = New Global.System.Drawing.Point(96, 180)
			label51.Location = point
			Me.Label24.Name = "Label24"
			Dim label52 As Global.System.Windows.Forms.Control = Me.Label24
			size = New Global.System.Drawing.Size(84, 18)
			label52.Size = size
			Me.Label24.TabIndex = 6
			Me.Label24.Text = "Repair"
			Me.Label24.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label53 As Global.System.Windows.Forms.Control = Me.Label25
			point = New Global.System.Drawing.Point(96, 84)
			label53.Location = point
			Me.Label25.Name = "Label25"
			Dim label54 As Global.System.Windows.Forms.Control = Me.Label25
			size = New Global.System.Drawing.Size(84, 18)
			label54.Size = size
			Me.Label25.TabIndex = 7
			Me.Label25.Text = "Demolitions"
			Me.Label25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label55 As Global.System.Windows.Forms.Control = Me.Label26
			point = New Global.System.Drawing.Point(96, 108)
			label55.Location = point
			Me.Label26.Name = "Label26"
			Dim label56 As Global.System.Windows.Forms.Control = Me.Label26
			size = New Global.System.Drawing.Size(84, 18)
			label56.Size = size
			Me.Label26.TabIndex = 5
			Me.Label26.Text = "Stealth"
			Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label57 As Global.System.Windows.Forms.Control = Me.Label27
			point = New Global.System.Drawing.Point(96, 156)
			label57.Location = point
			Me.Label27.Name = "Label27"
			Dim label58 As Global.System.Windows.Forms.Control = Me.Label27
			size = New Global.System.Drawing.Size(84, 18)
			label58.Size = size
			Me.Label27.TabIndex = 2
			Me.Label27.Text = "Persuade"
			Me.Label27.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label59 As Global.System.Windows.Forms.Control = Me.Label28
			point = New Global.System.Drawing.Point(96, 60)
			label59.Location = point
			Me.Label28.Name = "Label28"
			Dim label60 As Global.System.Windows.Forms.Control = Me.Label28
			size = New Global.System.Drawing.Size(84, 18)
			label60.Size = size
			Me.Label28.TabIndex = 3
			Me.Label28.Text = "Computer Use"
			Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label61 As Global.System.Windows.Forms.Control = Me.Label29
			point = New Global.System.Drawing.Point(96, 132)
			label61.Location = point
			Me.Label29.Name = "Label29"
			Dim label62 As Global.System.Windows.Forms.Control = Me.Label29
			size = New Global.System.Drawing.Size(84, 18)
			label62.Size = size
			Me.Label29.TabIndex = 4
			Me.Label29.Text = "Awareness"
			Me.Label29.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudDemolitions As Global.System.Windows.Forms.Control = Me.nudDemolitions
			point = New Global.System.Drawing.Point(186, 84)
			nudDemolitions.Location = point
			Me.nudDemolitions.Name = "nudDemolitions"
			Dim nudDemolitions2 As Global.System.Windows.Forms.Control = Me.nudDemolitions
			size = New Global.System.Drawing.Size(42, 20)
			nudDemolitions2.Size = size
			Me.nudDemolitions.TabIndex = 1
			Me.nudDemolitions.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudDemolitions3 As Global.System.Windows.Forms.NumericUpDown = Me.nudDemolitions
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudDemolitions3.Value = num
			Dim nudStealth As Global.System.Windows.Forms.Control = Me.nudStealth
			point = New Global.System.Drawing.Point(186, 108)
			nudStealth.Location = point
			Me.nudStealth.Name = "nudStealth"
			Dim nudStealth2 As Global.System.Windows.Forms.Control = Me.nudStealth
			size = New Global.System.Drawing.Size(42, 20)
			nudStealth2.Size = size
			Me.nudStealth.TabIndex = 2
			Me.nudStealth.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudStealth3 As Global.System.Windows.Forms.NumericUpDown = Me.nudStealth
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudStealth3.Value = num
			Dim nudAwareness As Global.System.Windows.Forms.Control = Me.nudAwareness
			point = New Global.System.Drawing.Point(186, 132)
			nudAwareness.Location = point
			Me.nudAwareness.Name = "nudAwareness"
			Dim nudAwareness2 As Global.System.Windows.Forms.Control = Me.nudAwareness
			size = New Global.System.Drawing.Size(42, 20)
			nudAwareness2.Size = size
			Me.nudAwareness.TabIndex = 3
			Me.nudAwareness.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudAwareness3 As Global.System.Windows.Forms.NumericUpDown = Me.nudAwareness
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudAwareness3.Value = num
			Dim nudPersuade As Global.System.Windows.Forms.Control = Me.nudPersuade
			point = New Global.System.Drawing.Point(186, 156)
			nudPersuade.Location = point
			Me.nudPersuade.Name = "nudPersuade"
			Dim nudPersuade2 As Global.System.Windows.Forms.Control = Me.nudPersuade
			size = New Global.System.Drawing.Size(42, 20)
			nudPersuade2.Size = size
			Me.nudPersuade.TabIndex = 4
			Me.nudPersuade.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudPersuade3 As Global.System.Windows.Forms.NumericUpDown = Me.nudPersuade
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudPersuade3.Value = num
			Dim nudRepair As Global.System.Windows.Forms.Control = Me.nudRepair
			point = New Global.System.Drawing.Point(186, 180)
			nudRepair.Location = point
			Me.nudRepair.Name = "nudRepair"
			Dim nudRepair2 As Global.System.Windows.Forms.Control = Me.nudRepair
			size = New Global.System.Drawing.Size(42, 20)
			nudRepair2.Size = size
			Me.nudRepair.TabIndex = 5
			Me.nudRepair.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudRepair3 As Global.System.Windows.Forms.NumericUpDown = Me.nudRepair
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudRepair3.Value = num
			Dim label63 As Global.System.Windows.Forms.Control = Me.Label30
			point = New Global.System.Drawing.Point(96, 204)
			label63.Location = point
			Me.Label30.Name = "Label30"
			Dim label64 As Global.System.Windows.Forms.Control = Me.Label30
			size = New Global.System.Drawing.Size(84, 18)
			label64.Size = size
			Me.Label30.TabIndex = 2
			Me.Label30.Text = "Security"
			Me.Label30.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudSecurity As Global.System.Windows.Forms.Control = Me.nudSecurity
			point = New Global.System.Drawing.Point(186, 204)
			nudSecurity.Location = point
			Me.nudSecurity.Name = "nudSecurity"
			Dim nudSecurity2 As Global.System.Windows.Forms.Control = Me.nudSecurity
			size = New Global.System.Drawing.Size(42, 20)
			nudSecurity2.Size = size
			Me.nudSecurity.TabIndex = 6
			Me.nudSecurity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudSecurity3 As Global.System.Windows.Forms.NumericUpDown = Me.nudSecurity
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudSecurity3.Value = num
			Dim nudTreatInjury As Global.System.Windows.Forms.Control = Me.nudTreatInjury
			point = New Global.System.Drawing.Point(186, 228)
			nudTreatInjury.Location = point
			Me.nudTreatInjury.Name = "nudTreatInjury"
			Dim nudTreatInjury2 As Global.System.Windows.Forms.Control = Me.nudTreatInjury
			size = New Global.System.Drawing.Size(42, 20)
			nudTreatInjury2.Size = size
			Me.nudTreatInjury.TabIndex = 7
			Me.nudTreatInjury.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim nudTreatInjury3 As Global.System.Windows.Forms.NumericUpDown = Me.nudTreatInjury
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudTreatInjury3.Value = num
			Dim label65 As Global.System.Windows.Forms.Control = Me.Label31
			point = New Global.System.Drawing.Point(96, 228)
			label65.Location = point
			Me.Label31.Name = "Label31"
			Dim label66 As Global.System.Windows.Forms.Control = Me.Label31
			size = New Global.System.Drawing.Size(84, 18)
			label66.Size = size
			Me.Label31.TabIndex = 6
			Me.Label31.Text = "Treat Injury"
			Me.Label31.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tpAdvanced.Controls.Add(Me.GroupBox12)
			Me.tpAdvanced.Controls.Add(Me.GroupBox11)
			Me.tpAdvanced.Controls.Add(Me.GroupBox13)
			Me.tpAdvanced.Controls.Add(Me.GroupBox14)
			Me.tpAdvanced.Controls.Add(Me.GroupBox15)
			Me.tpAdvanced.Controls.Add(Me.GroupBox18)
			Dim tpAdvanced As Global.System.Windows.Forms.Control = Me.tpAdvanced
			point = New Global.System.Drawing.Point(4, 40)
			tpAdvanced.Location = point
			Me.tpAdvanced.Name = "tpAdvanced"
			Dim tpAdvanced2 As Global.System.Windows.Forms.Control = Me.tpAdvanced
			size = New Global.System.Drawing.Size(408, 492)
			tpAdvanced2.Size = size
			Me.tpAdvanced.TabIndex = 6
			Me.tpAdvanced.Text = "Advanced"
			Me.GroupBox12.Controls.Add(Me.tbChallengeRating)
			Dim groupBox15 As Global.System.Windows.Forms.Control = Me.GroupBox12
			point = New Global.System.Drawing.Point(12, 384)
			groupBox15.Location = point
			Me.GroupBox12.Name = "GroupBox12"
			Dim groupBox16 As Global.System.Windows.Forms.Control = Me.GroupBox12
			size = New Global.System.Drawing.Size(186, 48)
			groupBox16.Size = size
			Me.GroupBox12.TabIndex = 3
			Me.GroupBox12.TabStop = False
			Me.GroupBox12.Text = "Challenge Rating"
			Dim tbChallengeRating As Global.System.Windows.Forms.Control = Me.tbChallengeRating
			point = New Global.System.Drawing.Point(36, 15)
			tbChallengeRating.Location = point
			Me.tbChallengeRating.Name = "tbChallengeRating"
			Dim tbChallengeRating2 As Global.System.Windows.Forms.Control = Me.tbChallengeRating
			size = New Global.System.Drawing.Size(42, 20)
			tbChallengeRating2.Size = size
			Me.tbChallengeRating.TabIndex = 0
			Me.tbChallengeRating.Text = ""
			Me.GroupBox11.Controls.Add(Me.nudMultiplierSet)
			Me.GroupBox11.Controls.Add(Me.Label51)
			Me.GroupBox11.Controls.Add(Me.chkbDisarmable)
			Me.GroupBox11.Controls.Add(Me.chkbPlot)
			Me.GroupBox11.Controls.Add(Me.chkbNoPermDeath)
			Me.GroupBox11.Controls.Add(Me.Label52)
			Me.GroupBox11.Controls.Add(Me.tbDeity)
			Me.GroupBox11.Controls.Add(Me.chkbIsPC)
			Me.GroupBox11.Controls.Add(Me.cmbxSubrace)
			Me.GroupBox11.Controls.Add(Me.chkbIsHologram)
			Me.GroupBox11.Controls.Add(Me.chkbNotReorienting)
			Me.GroupBox11.Controls.Add(Me.chkbIgnoreCrePath)
			Me.GroupBox11.Controls.Add(Me.lblMultiplierSet)
			Me.GroupBox11.Controls.Add(Me.lblBlindSpot)
			Me.GroupBox11.Controls.Add(Me.nudBlindSpot)
			Me.GroupBox11.Controls.Add(Me.chkbMin1HP)
			Dim groupBox17 As Global.System.Windows.Forms.Control = Me.GroupBox11
			point = New Global.System.Drawing.Point(12, 114)
			groupBox17.Location = point
			Me.GroupBox11.Name = "GroupBox11"
			Dim groupBox18 As Global.System.Windows.Forms.Control = Me.GroupBox11
			size = New Global.System.Drawing.Size(384, 246)
			groupBox18.Size = size
			Me.GroupBox11.TabIndex = 2
			Me.GroupBox11.TabStop = False
			Me.GroupBox11.Text = "Special"
			Dim nudMultiplierSet As Global.System.Windows.Forms.Control = Me.nudMultiplierSet
			point = New Global.System.Drawing.Point(318, 156)
			nudMultiplierSet.Location = point
			Me.nudMultiplierSet.Name = "nudMultiplierSet"
			Dim nudMultiplierSet2 As Global.System.Windows.Forms.Control = Me.nudMultiplierSet
			size = New Global.System.Drawing.Size(48, 20)
			nudMultiplierSet2.Size = size
			Me.nudMultiplierSet.TabIndex = 7
			Me.nudMultiplierSet.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudMultiplierSet.Visible = False
			Dim label67 As Global.System.Windows.Forms.Control = Me.Label51
			point = New Global.System.Drawing.Point(30, 192)
			label67.Location = point
			Me.Label51.Name = "Label51"
			Dim label68 As Global.System.Windows.Forms.Control = Me.Label51
			size = New Global.System.Drawing.Size(100, 18)
			label68.Size = size
			Me.Label51.TabIndex = 1
			Me.Label51.Text = "Subrace"
			Dim chkbDisarmable As Global.System.Windows.Forms.Control = Me.chkbDisarmable
			point = New Global.System.Drawing.Point(30, 30)
			chkbDisarmable.Location = point
			Me.chkbDisarmable.Name = "chkbDisarmable"
			Dim chkbDisarmable2 As Global.System.Windows.Forms.Control = Me.chkbDisarmable
			size = New Global.System.Drawing.Size(104, 18)
			chkbDisarmable2.Size = size
			Me.chkbDisarmable.TabIndex = 0
			Me.chkbDisarmable.Text = "Disarmable"
			Dim chkbPlot As Global.System.Windows.Forms.Control = Me.chkbPlot
			point = New Global.System.Drawing.Point(30, 78)
			chkbPlot.Location = point
			Me.chkbPlot.Name = "chkbPlot"
			Dim chkbPlot2 As Global.System.Windows.Forms.Control = Me.chkbPlot
			size = New Global.System.Drawing.Size(66, 18)
			chkbPlot2.Size = size
			Me.chkbPlot.TabIndex = 2
			Me.chkbPlot.Text = "Plot"
			Dim chkbNoPermDeath As Global.System.Windows.Forms.Control = Me.chkbNoPermDeath
			point = New Global.System.Drawing.Point(30, 54)
			chkbNoPermDeath.Location = point
			Me.chkbNoPermDeath.Name = "chkbNoPermDeath"
			Dim chkbNoPermDeath2 As Global.System.Windows.Forms.Control = Me.chkbNoPermDeath
			size = New Global.System.Drawing.Size(132, 18)
			chkbNoPermDeath2.Size = size
			Me.chkbNoPermDeath.TabIndex = 1
			Me.chkbNoPermDeath.Text = "No Permanent Death"
			Dim label69 As Global.System.Windows.Forms.Control = Me.Label52
			point = New Global.System.Drawing.Point(30, 210)
			label69.Location = point
			Me.Label52.Name = "Label52"
			Dim label70 As Global.System.Windows.Forms.Control = Me.Label52
			size = New Global.System.Drawing.Size(100, 18)
			label70.Size = size
			Me.Label52.TabIndex = 1
			Me.Label52.Text = "Deity"
			Me.Label52.Visible = False
			Dim tbDeity As Global.System.Windows.Forms.Control = Me.tbDeity
			point = New Global.System.Drawing.Point(144, 210)
			tbDeity.Location = point
			Me.tbDeity.Name = "tbDeity"
			Dim tbDeity2 As Global.System.Windows.Forms.Control = Me.tbDeity
			size = New Global.System.Drawing.Size(144, 20)
			tbDeity2.Size = size
			Me.tbDeity.TabIndex = 9
			Me.tbDeity.Text = ""
			Me.tbDeity.Visible = False
			Dim chkbIsPC As Global.System.Windows.Forms.Control = Me.chkbIsPC
			point = New Global.System.Drawing.Point(30, 102)
			chkbIsPC.Location = point
			Me.chkbIsPC.Name = "chkbIsPC"
			Dim chkbIsPC2 As Global.System.Windows.Forms.Control = Me.chkbIsPC
			size = New Global.System.Drawing.Size(60, 18)
			chkbIsPC2.Size = size
			Me.chkbIsPC.TabIndex = 3
			Me.chkbIsPC.Text = "Is PC"
			Me.cmbxSubrace.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxSubrace As Global.System.Windows.Forms.Control = Me.cmbxSubrace
			point = New Global.System.Drawing.Point(144, 192)
			cmbxSubrace.Location = point
			Me.cmbxSubrace.Name = "cmbxSubrace"
			Dim cmbxSubrace2 As Global.System.Windows.Forms.Control = Me.cmbxSubrace
			size = New Global.System.Drawing.Size(144, 21)
			cmbxSubrace2.Size = size
			Me.cmbxSubrace.TabIndex = 8
			Dim chkbIsHologram As Global.System.Windows.Forms.Control = Me.chkbIsHologram
			point = New Global.System.Drawing.Point(174, 78)
			chkbIsHologram.Location = point
			Me.chkbIsHologram.Name = "chkbIsHologram"
			Dim chkbIsHologram2 As Global.System.Windows.Forms.Control = Me.chkbIsHologram
			size = New Global.System.Drawing.Size(104, 18)
			chkbIsHologram2.Size = size
			Me.chkbIsHologram.TabIndex = 5
			Me.chkbIsHologram.Text = "Is Hologram"
			Me.chkbIsHologram.Visible = False
			Dim chkbNotReorienting As Global.System.Windows.Forms.Control = Me.chkbNotReorienting
			point = New Global.System.Drawing.Point(174, 30)
			chkbNotReorienting.Location = point
			Me.chkbNotReorienting.Name = "chkbNotReorienting"
			Dim chkbNotReorienting2 As Global.System.Windows.Forms.Control = Me.chkbNotReorienting
			size = New Global.System.Drawing.Size(144, 18)
			chkbNotReorienting2.Size = size
			Me.chkbNotReorienting.TabIndex = 3
			Me.chkbNotReorienting.Text = "Doesn't Reorient on PC"
			Me.chkbNotReorienting.Visible = False
			Dim chkbIgnoreCrePath As Global.System.Windows.Forms.Control = Me.chkbIgnoreCrePath
			point = New Global.System.Drawing.Point(174, 54)
			chkbIgnoreCrePath.Location = point
			Me.chkbIgnoreCrePath.Name = "chkbIgnoreCrePath"
			Dim chkbIgnoreCrePath2 As Global.System.Windows.Forms.Control = Me.chkbIgnoreCrePath
			size = New Global.System.Drawing.Size(114, 18)
			chkbIgnoreCrePath2.Size = size
			Me.chkbIgnoreCrePath.TabIndex = 4
			Me.chkbIgnoreCrePath.Text = "Doesn't Block PC"
			Me.chkbIgnoreCrePath.Visible = False
			Dim lblMultiplierSet As Global.System.Windows.Forms.Control = Me.lblMultiplierSet
			point = New Global.System.Drawing.Point(204, 156)
			lblMultiplierSet.Location = point
			Me.lblMultiplierSet.Name = "lblMultiplierSet"
			Dim lblMultiplierSet2 As Global.System.Windows.Forms.Control = Me.lblMultiplierSet
			size = New Global.System.Drawing.Size(100, 18)
			lblMultiplierSet2.Size = size
			Me.lblMultiplierSet.TabIndex = 1
			Me.lblMultiplierSet.Text = "Multiplier Set"
			Me.lblMultiplierSet.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblMultiplierSet.Visible = False
			Dim lblBlindSpot As Global.System.Windows.Forms.Control = Me.lblBlindSpot
			point = New Global.System.Drawing.Point(30, 156)
			lblBlindSpot.Location = point
			Me.lblBlindSpot.Name = "lblBlindSpot"
			Dim lblBlindSpot2 As Global.System.Windows.Forms.Control = Me.lblBlindSpot
			size = New Global.System.Drawing.Size(100, 18)
			lblBlindSpot2.Size = size
			Me.lblBlindSpot.TabIndex = 1
			Me.lblBlindSpot.Text = "Blind Spot"
			Me.lblBlindSpot.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblBlindSpot.Visible = False
			Me.nudBlindSpot.DecimalPlaces = 1
			Dim nudBlindSpot As Global.System.Windows.Forms.Control = Me.nudBlindSpot
			point = New Global.System.Drawing.Point(144, 156)
			nudBlindSpot.Location = point
			Dim nudBlindSpot2 As Global.System.Windows.Forms.NumericUpDown = Me.nudBlindSpot
			num = New Decimal(New Integer() { 3599, 0, 0, 65536 })
			nudBlindSpot2.Maximum = num
			Me.nudBlindSpot.Name = "nudBlindSpot"
			Dim nudBlindSpot3 As Global.System.Windows.Forms.Control = Me.nudBlindSpot
			size = New Global.System.Drawing.Size(48, 20)
			nudBlindSpot3.Size = size
			Me.nudBlindSpot.TabIndex = 6
			Me.nudBlindSpot.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudBlindSpot.Visible = False
			Dim chkbMin1HP As Global.System.Windows.Forms.Control = Me.chkbMin1HP
			point = New Global.System.Drawing.Point(30, 126)
			chkbMin1HP.Location = point
			Me.chkbMin1HP.Name = "chkbMin1HP"
			Dim chkbMin1HP2 As Global.System.Windows.Forms.Control = Me.chkbMin1HP
			size = New Global.System.Drawing.Size(108, 18)
			chkbMin1HP2.Size = size
			Me.chkbMin1HP.TabIndex = 3
			Me.chkbMin1HP.Text = "Minimum 1 HP"
			Me.GroupBox13.Controls.Add(Me.cmbxSoundSet)
			Dim groupBox19 As Global.System.Windows.Forms.Control = Me.GroupBox13
			point = New Global.System.Drawing.Point(210, 384)
			groupBox19.Location = point
			Me.GroupBox13.Name = "GroupBox13"
			Dim groupBox20 As Global.System.Windows.Forms.Control = Me.GroupBox13
			size = New Global.System.Drawing.Size(186, 48)
			groupBox20.Size = size
			Me.GroupBox13.TabIndex = 4
			Me.GroupBox13.TabStop = False
			Me.GroupBox13.Text = "Sound Set"
			Me.cmbxSoundSet.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxSoundSet As Global.System.Windows.Forms.Control = Me.cmbxSoundSet
			point = New Global.System.Drawing.Point(24, 16)
			cmbxSoundSet.Location = point
			Me.cmbxSoundSet.Name = "cmbxSoundSet"
			Dim cmbxSoundSet2 As Global.System.Windows.Forms.Control = Me.cmbxSoundSet
			size = New Global.System.Drawing.Size(144, 21)
			cmbxSoundSet2.Size = size
			Me.cmbxSoundSet.TabIndex = 0
			Me.GroupBox14.Controls.Add(Me.cmbxPerceptionRange)
			Dim groupBox21 As Global.System.Windows.Forms.Control = Me.GroupBox14
			point = New Global.System.Drawing.Point(210, 438)
			groupBox21.Location = point
			Me.GroupBox14.Name = "GroupBox14"
			Dim groupBox22 As Global.System.Windows.Forms.Control = Me.GroupBox14
			size = New Global.System.Drawing.Size(186, 48)
			groupBox22.Size = size
			Me.GroupBox14.TabIndex = 5
			Me.GroupBox14.TabStop = False
			Me.GroupBox14.Text = "Perception Range"
			Me.cmbxPerceptionRange.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxPerceptionRange.Items.AddRange(New Object() { "Short", "Medium", "Long", "Default", "Player", "Monster" })
			Dim cmbxPerceptionRange As Global.System.Windows.Forms.Control = Me.cmbxPerceptionRange
			point = New Global.System.Drawing.Point(24, 16)
			cmbxPerceptionRange.Location = point
			Me.cmbxPerceptionRange.Name = "cmbxPerceptionRange"
			Dim cmbxPerceptionRange2 As Global.System.Windows.Forms.Control = Me.cmbxPerceptionRange
			size = New Global.System.Drawing.Size(144, 21)
			cmbxPerceptionRange2.Size = size
			Me.cmbxPerceptionRange.TabIndex = 0
			Me.GroupBox15.Controls.Add(Me.cmbxFaction)
			Dim groupBox23 As Global.System.Windows.Forms.Control = Me.GroupBox15
			point = New Global.System.Drawing.Point(12, 438)
			groupBox23.Location = point
			Me.GroupBox15.Name = "GroupBox15"
			Dim groupBox24 As Global.System.Windows.Forms.Control = Me.GroupBox15
			size = New Global.System.Drawing.Size(186, 48)
			groupBox24.Size = size
			Me.GroupBox15.TabIndex = 1
			Me.GroupBox15.TabStop = False
			Me.GroupBox15.Text = "Faction"
			Me.cmbxFaction.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxFaction As Global.System.Windows.Forms.Control = Me.cmbxFaction
			point = New Global.System.Drawing.Point(24, 16)
			cmbxFaction.Location = point
			Me.cmbxFaction.Name = "cmbxFaction"
			Dim cmbxFaction2 As Global.System.Windows.Forms.Control = Me.cmbxFaction
			size = New Global.System.Drawing.Size(144, 21)
			cmbxFaction2.Size = size
			Me.cmbxFaction.TabIndex = 1
			Me.GroupBox18.Controls.Add(Me.tbTemplateResRef)
			Me.GroupBox18.Controls.Add(Me.Label56)
			Me.GroupBox18.Controls.Add(Me.Label57)
			Me.GroupBox18.Controls.Add(Me.cmbxTreasureModel)
			Dim groupBox25 As Global.System.Windows.Forms.Control = Me.GroupBox18
			point = New Global.System.Drawing.Point(12, 12)
			groupBox25.Location = point
			Me.GroupBox18.Name = "GroupBox18"
			Dim groupBox26 As Global.System.Windows.Forms.Control = Me.GroupBox18
			size = New Global.System.Drawing.Size(384, 90)
			groupBox26.Size = size
			Me.GroupBox18.TabIndex = 0
			Me.GroupBox18.TabStop = False
			Me.GroupBox18.Text = "Info"
			Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
			Dim tbTemplateResRef As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
			point = New Global.System.Drawing.Point(144, 24)
			tbTemplateResRef.Location = point
			Me.tbTemplateResRef.MaxLength = 16
			Me.tbTemplateResRef.Name = "tbTemplateResRef"
			Dim tbTemplateResRef2 As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
			size = New Global.System.Drawing.Size(176, 20)
			tbTemplateResRef2.Size = size
			Me.tbTemplateResRef.TabIndex = 2
			Me.tbTemplateResRef.Text = ""
			Dim label71 As Global.System.Windows.Forms.Control = Me.Label56
			point = New Global.System.Drawing.Point(24, 57)
			label71.Location = point
			Me.Label56.Name = "Label56"
			Dim label72 As Global.System.Windows.Forms.Control = Me.Label56
			size = New Global.System.Drawing.Size(100, 18)
			label72.Size = size
			Me.Label56.TabIndex = 1
			Me.Label56.Text = "Treasure Model"
			Me.Label56.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label56.Visible = False
			Dim label73 As Global.System.Windows.Forms.Control = Me.Label57
			point = New Global.System.Drawing.Point(24, 25)
			label73.Location = point
			Me.Label57.Name = "Label57"
			Dim label74 As Global.System.Windows.Forms.Control = Me.Label57
			size = New Global.System.Drawing.Size(100, 18)
			label74.Size = size
			Me.Label57.TabIndex = 1
			Me.Label57.Text = "Template ResRef"
			Me.Label57.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbxTreasureModel.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxTreasureModel.Items.AddRange(New Object() { "Short", "Medium", "Long", "Default", "Player", "Monster" })
			Dim cmbxTreasureModel As Global.System.Windows.Forms.Control = Me.cmbxTreasureModel
			point = New Global.System.Drawing.Point(144, 56)
			cmbxTreasureModel.Location = point
			Me.cmbxTreasureModel.Name = "cmbxTreasureModel"
			Dim cmbxTreasureModel2 As Global.System.Windows.Forms.Control = Me.cmbxTreasureModel
			size = New Global.System.Drawing.Size(176, 21)
			cmbxTreasureModel2.Size = size
			Me.cmbxTreasureModel.TabIndex = 0
			Me.cmbxTreasureModel.Visible = False
			Me.tpFeats.Controls.Add(Me.GroupBox10)
			Me.tpFeats.Controls.Add(Me.chklbFeats)
			Dim tpFeats As Global.System.Windows.Forms.Control = Me.tpFeats
			point = New Global.System.Drawing.Point(4, 40)
			tpFeats.Location = point
			Me.tpFeats.Name = "tpFeats"
			Dim tpFeats2 As Global.System.Windows.Forms.Control = Me.tpFeats
			size = New Global.System.Drawing.Size(408, 492)
			tpFeats2.Size = size
			Me.tpFeats.TabIndex = 7
			Me.tpFeats.Text = "Feats"
			Me.GroupBox10.Controls.Add(Me.tbFeatSummary)
			Dim groupBox27 As Global.System.Windows.Forms.Control = Me.GroupBox10
			point = New Global.System.Drawing.Point(6, 354)
			groupBox27.Location = point
			Me.GroupBox10.Name = "GroupBox10"
			Dim groupBox28 As Global.System.Windows.Forms.Control = Me.GroupBox10
			size = New Global.System.Drawing.Size(396, 132)
			groupBox28.Size = size
			Me.GroupBox10.TabIndex = 2
			Me.GroupBox10.TabStop = False
			Me.GroupBox10.Text = "Feats Selection Summary"
			Dim tbFeatSummary As Global.System.Windows.Forms.Control = Me.tbFeatSummary
			point = New Global.System.Drawing.Point(18, 24)
			tbFeatSummary.Location = point
			Me.tbFeatSummary.Multiline = True
			Me.tbFeatSummary.Name = "tbFeatSummary"
			Me.tbFeatSummary.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Dim tbFeatSummary2 As Global.System.Windows.Forms.Control = Me.tbFeatSummary
			size = New Global.System.Drawing.Size(360, 96)
			tbFeatSummary2.Size = size
			Me.tbFeatSummary.TabIndex = 1
			Me.tbFeatSummary.Text = ""
			Me.tbFeatSummary.WordWrap = False
			Dim chklbFeats As Global.System.Windows.Forms.Control = Me.chklbFeats
			point = New Global.System.Drawing.Point(72, 36)
			chklbFeats.Location = point
			Me.chklbFeats.Name = "chklbFeats"
			Dim chklbFeats2 As Global.System.Windows.Forms.Control = Me.chklbFeats
			size = New Global.System.Drawing.Size(264, 289)
			chklbFeats2.Size = size
			Me.chklbFeats.TabIndex = 0
			Me.chklbFeats.ThreeDCheckBoxes = True
			Me.toForcePowers.Controls.Add(Me.GroupBox19)
			Me.toForcePowers.Controls.Add(Me.GroupBox17)
			Me.toForcePowers.Controls.Add(Me.GroupBox16)
			Dim toForcePowers As Global.System.Windows.Forms.Control = Me.toForcePowers
			point = New Global.System.Drawing.Point(4, 40)
			toForcePowers.Location = point
			Me.toForcePowers.Name = "toForcePowers"
			Dim toForcePowers2 As Global.System.Windows.Forms.Control = Me.toForcePowers
			size = New Global.System.Drawing.Size(408, 492)
			toForcePowers2.Size = size
			Me.toForcePowers.TabIndex = 8
			Me.toForcePowers.Text = "Force Powers"
			Me.GroupBox19.Controls.Add(Me.tbForcePowerSummary)
			Dim groupBox29 As Global.System.Windows.Forms.Control = Me.GroupBox19
			point = New Global.System.Drawing.Point(6, 366)
			groupBox29.Location = point
			Me.GroupBox19.Name = "GroupBox19"
			Dim groupBox30 As Global.System.Windows.Forms.Control = Me.GroupBox19
			size = New Global.System.Drawing.Size(396, 120)
			groupBox30.Size = size
			Me.GroupBox19.TabIndex = 3
			Me.GroupBox19.TabStop = False
			Me.GroupBox19.Text = "Force Power Selection Summary"
			Dim tbForcePowerSummary As Global.System.Windows.Forms.Control = Me.tbForcePowerSummary
			point = New Global.System.Drawing.Point(18, 16)
			tbForcePowerSummary.Location = point
			Me.tbForcePowerSummary.Multiline = True
			Me.tbForcePowerSummary.Name = "tbForcePowerSummary"
			Me.tbForcePowerSummary.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Dim tbForcePowerSummary2 As Global.System.Windows.Forms.Control = Me.tbForcePowerSummary
			size = New Global.System.Drawing.Size(360, 96)
			tbForcePowerSummary2.Size = size
			Me.tbForcePowerSummary.TabIndex = 1
			Me.tbForcePowerSummary.Text = ""
			Me.tbForcePowerSummary.WordWrap = False
			Me.GroupBox17.Controls.Add(Me.chklbForcePowers)
			Me.GroupBox17.Controls.Add(Me.btnSelectAllPowers)
			Me.GroupBox17.Controls.Add(Me.btnClearAllPowers)
			Dim groupBox31 As Global.System.Windows.Forms.Control = Me.GroupBox17
			point = New Global.System.Drawing.Point(6, 72)
			groupBox31.Location = point
			Me.GroupBox17.Name = "GroupBox17"
			Dim groupBox32 As Global.System.Windows.Forms.Control = Me.GroupBox17
			size = New Global.System.Drawing.Size(396, 288)
			groupBox32.Size = size
			Me.GroupBox17.TabIndex = 1
			Me.GroupBox17.TabStop = False
			Me.GroupBox17.Text = "Force Powers"
			Dim chklbForcePowers As Global.System.Windows.Forms.Control = Me.chklbForcePowers
			point = New Global.System.Drawing.Point(66, 18)
			chklbForcePowers.Location = point
			Me.chklbForcePowers.Name = "chklbForcePowers"
			Dim chklbForcePowers2 As Global.System.Windows.Forms.Control = Me.chklbForcePowers
			size = New Global.System.Drawing.Size(264, 229)
			chklbForcePowers2.Size = size
			Me.chklbForcePowers.TabIndex = 0
			Me.chklbForcePowers.ThreeDCheckBoxes = True
			Dim btnSelectAllPowers As Global.System.Windows.Forms.Control = Me.btnSelectAllPowers
			point = New Global.System.Drawing.Point(84, 258)
			btnSelectAllPowers.Location = point
			Me.btnSelectAllPowers.Name = "btnSelectAllPowers"
			Dim btnSelectAllPowers2 As Global.System.Windows.Forms.Control = Me.btnSelectAllPowers
			size = New Global.System.Drawing.Size(102, 24)
			btnSelectAllPowers2.Size = size
			Me.btnSelectAllPowers.TabIndex = 1
			Me.btnSelectAllPowers.Text = "Select All Powers"
			Me.btnClearAllPowers.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Dim btnClearAllPowers As Global.System.Windows.Forms.Control = Me.btnClearAllPowers
			point = New Global.System.Drawing.Point(216, 258)
			btnClearAllPowers.Location = point
			Me.btnClearAllPowers.Name = "btnClearAllPowers"
			Dim btnClearAllPowers2 As Global.System.Windows.Forms.Control = Me.btnClearAllPowers
			size = New Global.System.Drawing.Size(96, 24)
			btnClearAllPowers2.Size = size
			Me.btnClearAllPowers.TabIndex = 2
			Me.btnClearAllPowers.Text = "Clear All Powers"
			Me.GroupBox16.Controls.Add(Me.nudForcePoints)
			Me.GroupBox16.Controls.Add(Me.Label54)
			Me.GroupBox16.Controls.Add(Me.Label55)
			Me.GroupBox16.Controls.Add(Me.nudCurrentForce)
			Dim groupBox33 As Global.System.Windows.Forms.Control = Me.GroupBox16
			point = New Global.System.Drawing.Point(6, 6)
			groupBox33.Location = point
			Me.GroupBox16.Name = "GroupBox16"
			Dim groupBox34 As Global.System.Windows.Forms.Control = Me.GroupBox16
			size = New Global.System.Drawing.Size(396, 60)
			groupBox34.Size = size
			Me.GroupBox16.TabIndex = 0
			Me.GroupBox16.TabStop = False
			Me.GroupBox16.Text = "Force Points"
			Dim nudForcePoints As Global.System.Windows.Forms.Control = Me.nudForcePoints
			point = New Global.System.Drawing.Point(120, 25)
			nudForcePoints.Location = point
			Dim nudForcePoints2 As Global.System.Windows.Forms.NumericUpDown = Me.nudForcePoints
			num = New Decimal(New Integer() { 9999, 0, 0, 0 })
			nudForcePoints2.Maximum = num
			Me.nudForcePoints.Name = "nudForcePoints"
			Dim nudForcePoints3 As Global.System.Windows.Forms.Control = Me.nudForcePoints
			size = New Global.System.Drawing.Size(48, 20)
			nudForcePoints3.Size = size
			Me.nudForcePoints.TabIndex = 0
			Dim nudForcePoints4 As Global.System.Windows.Forms.NumericUpDown = Me.nudForcePoints
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudForcePoints4.Value = num
			Dim label75 As Global.System.Windows.Forms.Control = Me.Label54
			point = New Global.System.Drawing.Point(18, 26)
			label75.Location = point
			Me.Label54.Name = "Label54"
			Dim label76 As Global.System.Windows.Forms.Control = Me.Label54
			size = New Global.System.Drawing.Size(96, 18)
			label76.Size = size
			Me.Label54.TabIndex = 0
			Me.Label54.Text = "Max Force Points"
			Me.Label54.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label77 As Global.System.Windows.Forms.Control = Me.Label55
			point = New Global.System.Drawing.Point(204, 26)
			label77.Location = point
			Me.Label55.Name = "Label55"
			Dim label78 As Global.System.Windows.Forms.Control = Me.Label55
			size = New Global.System.Drawing.Size(108, 18)
			label78.Size = size
			Me.Label55.TabIndex = 0
			Me.Label55.Text = "Current Force Points"
			Me.Label55.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudCurrentForce As Global.System.Windows.Forms.Control = Me.nudCurrentForce
			point = New Global.System.Drawing.Point(312, 25)
			nudCurrentForce.Location = point
			Dim nudCurrentForce2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCurrentForce
			num = New Decimal(New Integer() { 9999, 0, 0, 0 })
			nudCurrentForce2.Maximum = num
			Me.nudCurrentForce.Name = "nudCurrentForce"
			Dim nudCurrentForce3 As Global.System.Windows.Forms.Control = Me.nudCurrentForce
			size = New Global.System.Drawing.Size(48, 20)
			nudCurrentForce3.Size = size
			Me.nudCurrentForce.TabIndex = 1
			Dim nudCurrentForce4 As Global.System.Windows.Forms.NumericUpDown = Me.nudCurrentForce
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			nudCurrentForce4.Value = num
			Me.tpClasses.Controls.Add(Me.GroupBox9)
			Me.tpClasses.Controls.Add(Me.GroupBox8)
			Dim tpClasses As Global.System.Windows.Forms.Control = Me.tpClasses
			point = New Global.System.Drawing.Point(4, 40)
			tpClasses.Location = point
			Me.tpClasses.Name = "tpClasses"
			Dim tpClasses2 As Global.System.Windows.Forms.Control = Me.tpClasses
			size = New Global.System.Drawing.Size(408, 492)
			tpClasses2.Size = size
			Me.tpClasses.TabIndex = 3
			Me.tpClasses.Text = "Class"
			Me.GroupBox9.Controls.Add(Me.Label46)
			Me.GroupBox9.Controls.Add(Me.nudClassLevel)
			Me.GroupBox9.Controls.Add(Me.cmbxClass)
			Me.GroupBox9.Controls.Add(Me.Label23)
			Dim groupBox35 As Global.System.Windows.Forms.Control = Me.GroupBox9
			point = New Global.System.Drawing.Point(6, 114)
			groupBox35.Location = point
			Me.GroupBox9.Name = "GroupBox9"
			Dim groupBox36 As Global.System.Windows.Forms.Control = Me.GroupBox9
			size = New Global.System.Drawing.Size(396, 108)
			groupBox36.Size = size
			Me.GroupBox9.TabIndex = 7
			Me.GroupBox9.TabStop = False
			Me.GroupBox9.Text = "Classes"
			Dim label79 As Global.System.Windows.Forms.Control = Me.Label46
			point = New Global.System.Drawing.Point(18, 66)
			label79.Location = point
			Me.Label46.Name = "Label46"
			Dim label80 As Global.System.Windows.Forms.Control = Me.Label46
			size = New Global.System.Drawing.Size(42, 16)
			label80.Size = size
			Me.Label46.TabIndex = 3
			Me.Label46.Text = "Level"
			Me.Label46.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim nudClassLevel As Global.System.Windows.Forms.Control = Me.nudClassLevel
			point = New Global.System.Drawing.Point(78, 66)
			nudClassLevel.Location = point
			Dim nudClassLevel2 As Global.System.Windows.Forms.NumericUpDown = Me.nudClassLevel
			num = New Decimal(New Integer() { 250, 0, 0, 0 })
			nudClassLevel2.Maximum = num
			Me.nudClassLevel.Name = "nudClassLevel"
			Dim nudClassLevel3 As Global.System.Windows.Forms.Control = Me.nudClassLevel
			size = New Global.System.Drawing.Size(42, 20)
			nudClassLevel3.Size = size
			Me.nudClassLevel.TabIndex = 1
			Me.cmbxClass.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Dim cmbxClass As Global.System.Windows.Forms.Control = Me.cmbxClass
			point = New Global.System.Drawing.Point(60, 30)
			cmbxClass.Location = point
			Me.cmbxClass.Name = "cmbxClass"
			Dim cmbxClass2 As Global.System.Windows.Forms.Control = Me.cmbxClass
			size = New Global.System.Drawing.Size(184, 21)
			cmbxClass2.Size = size
			Me.cmbxClass.TabIndex = 0
			Dim label81 As Global.System.Windows.Forms.Control = Me.Label23
			point = New Global.System.Drawing.Point(18, 30)
			label81.Location = point
			Me.Label23.Name = "Label23"
			Dim label82 As Global.System.Windows.Forms.Control = Me.Label23
			size = New Global.System.Drawing.Size(42, 16)
			label82.Size = size
			Me.Label23.TabIndex = 3
			Me.Label23.Text = "Class"
			Me.Label23.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.GroupBox8.Controls.Add(Me.nudAlignment)
			Me.GroupBox8.Controls.Add(Me.Label47)
			Me.GroupBox8.Controls.Add(Me.trkbarAlignment)
			Me.GroupBox8.Controls.Add(Me.Label48)
			Dim groupBox37 As Global.System.Windows.Forms.Control = Me.GroupBox8
			point = New Global.System.Drawing.Point(6, 6)
			groupBox37.Location = point
			Me.GroupBox8.Name = "GroupBox8"
			Dim groupBox38 As Global.System.Windows.Forms.Control = Me.GroupBox8
			size = New Global.System.Drawing.Size(396, 102)
			groupBox38.Size = size
			Me.GroupBox8.TabIndex = 6
			Me.GroupBox8.TabStop = False
			Me.GroupBox8.Text = "Alignment"
			Dim nudAlignment As Global.System.Windows.Forms.Control = Me.nudAlignment
			point = New Global.System.Drawing.Point(186, 72)
			nudAlignment.Location = point
			Me.nudAlignment.Name = "nudAlignment"
			Me.nudAlignment.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim nudAlignment2 As Global.System.Windows.Forms.Control = Me.nudAlignment
			size = New Global.System.Drawing.Size(42, 20)
			nudAlignment2.Size = size
			Me.nudAlignment.TabIndex = 1
			Me.nudAlignment.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim label83 As Global.System.Windows.Forms.Control = Me.Label47
			point = New Global.System.Drawing.Point(12, 36)
			label83.Location = point
			Me.Label47.Name = "Label47"
			Dim label84 As Global.System.Windows.Forms.Control = Me.Label47
			size = New Global.System.Drawing.Size(36, 18)
			label84.Size = size
			Me.Label47.TabIndex = 1
			Me.Label47.Text = "Evil"
			Dim trkbarAlignment As Global.System.Windows.Forms.Control = Me.trkbarAlignment
			point = New Global.System.Drawing.Point(66, 24)
			trkbarAlignment.Location = point
			Me.trkbarAlignment.Maximum = 100
			Me.trkbarAlignment.Name = "trkbarAlignment"
			Dim trkbarAlignment2 As Global.System.Windows.Forms.Control = Me.trkbarAlignment
			size = New Global.System.Drawing.Size(276, 42)
			trkbarAlignment2.Size = size
			Me.trkbarAlignment.TabIndex = 0
			Me.trkbarAlignment.TickFrequency = 5
			Dim label85 As Global.System.Windows.Forms.Control = Me.Label48
			point = New Global.System.Drawing.Point(348, 36)
			label85.Location = point
			Me.Label48.Name = "Label48"
			Dim label86 As Global.System.Windows.Forms.Control = Me.Label48
			size = New Global.System.Drawing.Size(36, 18)
			label86.Size = size
			Me.Label48.TabIndex = 1
			Me.Label48.Text = "Good"
			Me.tpSpecialAbilities.Controls.Add(Me.GroupBox20)
			Dim tpSpecialAbilities As Global.System.Windows.Forms.Control = Me.tpSpecialAbilities
			point = New Global.System.Drawing.Point(4, 40)
			tpSpecialAbilities.Location = point
			Me.tpSpecialAbilities.Name = "tpSpecialAbilities"
			Dim tpSpecialAbilities2 As Global.System.Windows.Forms.Control = Me.tpSpecialAbilities
			size = New Global.System.Drawing.Size(408, 492)
			tpSpecialAbilities2.Size = size
			Me.tpSpecialAbilities.TabIndex = 9
			Me.tpSpecialAbilities.Text = "Special Abilities"
			Me.GroupBox20.Controls.Add(Me.chklbSpecialAbilities)
			Dim groupBox39 As Global.System.Windows.Forms.Control = Me.GroupBox20
			point = New Global.System.Drawing.Point(6, 6)
			groupBox39.Location = point
			Me.GroupBox20.Name = "GroupBox20"
			Dim groupBox40 As Global.System.Windows.Forms.Control = Me.GroupBox20
			size = New Global.System.Drawing.Size(396, 306)
			groupBox40.Size = size
			Me.GroupBox20.TabIndex = 3
			Me.GroupBox20.TabStop = False
			Me.GroupBox20.Text = "Special Abilities"
			Dim chklbSpecialAbilities As Global.System.Windows.Forms.Control = Me.chklbSpecialAbilities
			point = New Global.System.Drawing.Point(66, 12)
			chklbSpecialAbilities.Location = point
			Me.chklbSpecialAbilities.Name = "chklbSpecialAbilities"
			Dim chklbSpecialAbilities2 As Global.System.Windows.Forms.Control = Me.chklbSpecialAbilities
			size = New Global.System.Drawing.Size(264, 274)
			chklbSpecialAbilities2.Size = size
			Me.chklbSpecialAbilities.TabIndex = 2
			Me.chklbSpecialAbilities.ThreeDCheckBoxes = True
			Me.tpScripts.Controls.Add(Me.btnEditOnEndDialogu)
			Me.tpScripts.Controls.Add(Me.btnEditOnDialogue)
			Me.tpScripts.Controls.Add(Me.btnEditOnUserDefine)
			Me.tpScripts.Controls.Add(Me.btnEditOnHeartbeat)
			Me.tpScripts.Controls.Add(Me.btnEditOnDisturbed)
			Me.tpScripts.Controls.Add(Me.btnEditOnDamaged)
			Me.tpScripts.Controls.Add(Me.btnEditOnAttacked)
			Me.tpScripts.Controls.Add(Me.Label34)
			Me.tpScripts.Controls.Add(Me.tbOnSpellAt)
			Me.tpScripts.Controls.Add(Me.Label33)
			Me.tpScripts.Controls.Add(Me.tbOnNotice)
			Me.tpScripts.Controls.Add(Me.Label32)
			Me.tpScripts.Controls.Add(Me.tbOnHeartbeat)
			Me.tpScripts.Controls.Add(Me.Label35)
			Me.tpScripts.Controls.Add(Me.tbOnAttacked)
			Me.tpScripts.Controls.Add(Me.tbOnDamaged)
			Me.tpScripts.Controls.Add(Me.Label36)
			Me.tpScripts.Controls.Add(Me.Label37)
			Me.tpScripts.Controls.Add(Me.tbOnDisturbed)
			Me.tpScripts.Controls.Add(Me.tbOnEndRound)
			Me.tpScripts.Controls.Add(Me.Label38)
			Me.tpScripts.Controls.Add(Me.tbOnEndDialogu)
			Me.tpScripts.Controls.Add(Me.Label39)
			Me.tpScripts.Controls.Add(Me.Label40)
			Me.tpScripts.Controls.Add(Me.tbOnDialogue)
			Me.tpScripts.Controls.Add(Me.Label41)
			Me.tpScripts.Controls.Add(Me.tbOnSpawn)
			Me.tpScripts.Controls.Add(Me.tbOnRested)
			Me.tpScripts.Controls.Add(Me.Label42)
			Me.tpScripts.Controls.Add(Me.tbOnDeath)
			Me.tpScripts.Controls.Add(Me.Label43)
			Me.tpScripts.Controls.Add(Me.Label44)
			Me.tpScripts.Controls.Add(Me.tbOnBlocked)
			Me.tpScripts.Controls.Add(Me.tbOnUserDefine)
			Me.tpScripts.Controls.Add(Me.Label45)
			Me.tpScripts.Controls.Add(Me.btnEditOnNotice)
			Me.tpScripts.Controls.Add(Me.btnEditOnSpellAt)
			Me.tpScripts.Controls.Add(Me.btnEditOnSpawn)
			Me.tpScripts.Controls.Add(Me.btnEditOnDeath)
			Me.tpScripts.Controls.Add(Me.btnEditOnBlocked)
			Me.tpScripts.Controls.Add(Me.btnEditOnRested)
			Me.tpScripts.Controls.Add(Me.btnEditOnEndRound)
			Dim tpScripts As Global.System.Windows.Forms.Control = Me.tpScripts
			point = New Global.System.Drawing.Point(4, 40)
			tpScripts.Location = point
			Me.tpScripts.Name = "tpScripts"
			Dim tpScripts2 As Global.System.Windows.Forms.Control = Me.tpScripts
			size = New Global.System.Drawing.Size(408, 492)
			tpScripts2.Size = size
			Me.tpScripts.TabIndex = 5
			Me.tpScripts.Text = "Scripts"
			Dim btnEditOnEndDialogu As Global.System.Windows.Forms.Control = Me.btnEditOnEndDialogu
			point = New Global.System.Drawing.Point(342, 252)
			btnEditOnEndDialogu.Location = point
			Me.btnEditOnEndDialogu.Name = "btnEditOnEndDialogu"
			Dim btnEditOnEndDialogu2 As Global.System.Windows.Forms.Control = Me.btnEditOnEndDialogu
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnEndDialogu2.Size = size
			Me.btnEditOnEndDialogu.TabIndex = 15
			Me.btnEditOnEndDialogu.Text = "Edit"
			Me.btnEditOnEndDialogu.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnDialogue As Global.System.Windows.Forms.Control = Me.btnEditOnDialogue
			point = New Global.System.Drawing.Point(342, 282)
			btnEditOnDialogue.Location = point
			Me.btnEditOnDialogue.Name = "btnEditOnDialogue"
			Dim btnEditOnDialogue2 As Global.System.Windows.Forms.Control = Me.btnEditOnDialogue
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnDialogue2.Size = size
			Me.btnEditOnDialogue.TabIndex = 17
			Me.btnEditOnDialogue.Text = "Edit"
			Me.btnEditOnDialogue.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnUserDefine As Global.System.Windows.Forms.Control = Me.btnEditOnUserDefine
			point = New Global.System.Drawing.Point(342, 432)
			btnEditOnUserDefine.Location = point
			Me.btnEditOnUserDefine.Name = "btnEditOnUserDefine"
			Dim btnEditOnUserDefine2 As Global.System.Windows.Forms.Control = Me.btnEditOnUserDefine
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnUserDefine2.Size = size
			Me.btnEditOnUserDefine.TabIndex = 27
			Me.btnEditOnUserDefine.Text = "Edit"
			Me.btnEditOnUserDefine.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnHeartbeat As Global.System.Windows.Forms.Control = Me.btnEditOnHeartbeat
			point = New Global.System.Drawing.Point(342, 42)
			btnEditOnHeartbeat.Location = point
			Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
			Dim btnEditOnHeartbeat2 As Global.System.Windows.Forms.Control = Me.btnEditOnHeartbeat
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnHeartbeat2.Size = size
			Me.btnEditOnHeartbeat.TabIndex = 1
			Me.btnEditOnHeartbeat.Text = "Edit"
			Me.btnEditOnHeartbeat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnDisturbed As Global.System.Windows.Forms.Control = Me.btnEditOnDisturbed
			point = New Global.System.Drawing.Point(342, 192)
			btnEditOnDisturbed.Location = point
			Me.btnEditOnDisturbed.Name = "btnEditOnDisturbed"
			Dim btnEditOnDisturbed2 As Global.System.Windows.Forms.Control = Me.btnEditOnDisturbed
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnDisturbed2.Size = size
			Me.btnEditOnDisturbed.TabIndex = 11
			Me.btnEditOnDisturbed.Text = "Edit"
			Me.btnEditOnDisturbed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnDamaged As Global.System.Windows.Forms.Control = Me.btnEditOnDamaged
			point = New Global.System.Drawing.Point(342, 162)
			btnEditOnDamaged.Location = point
			Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
			Dim btnEditOnDamaged2 As Global.System.Windows.Forms.Control = Me.btnEditOnDamaged
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnDamaged2.Size = size
			Me.btnEditOnDamaged.TabIndex = 9
			Me.btnEditOnDamaged.Text = "Edit"
			Me.btnEditOnDamaged.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnAttacked As Global.System.Windows.Forms.Control = Me.btnEditOnAttacked
			point = New Global.System.Drawing.Point(342, 132)
			btnEditOnAttacked.Location = point
			Me.btnEditOnAttacked.Name = "btnEditOnAttacked"
			Dim btnEditOnAttacked2 As Global.System.Windows.Forms.Control = Me.btnEditOnAttacked
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnAttacked2.Size = size
			Me.btnEditOnAttacked.TabIndex = 7
			Me.btnEditOnAttacked.Text = "Edit"
			Me.btnEditOnAttacked.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label87 As Global.System.Windows.Forms.Control = Me.Label34
			point = New Global.System.Drawing.Point(30, 102)
			label87.Location = point
			Me.Label34.Name = "Label34"
			Dim label88 As Global.System.Windows.Forms.Control = Me.Label34
			size = New Global.System.Drawing.Size(84, 18)
			label88.Size = size
			Me.Label34.TabIndex = 5
			Me.Label34.Text = "OnSpellAt"
			Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnSpellAt As Global.System.Windows.Forms.Control = Me.tbOnSpellAt
			point = New Global.System.Drawing.Point(114, 102)
			tbOnSpellAt.Location = point
			Me.tbOnSpellAt.Name = "tbOnSpellAt"
			Dim tbOnSpellAt2 As Global.System.Windows.Forms.Control = Me.tbOnSpellAt
			size = New Global.System.Drawing.Size(204, 20)
			tbOnSpellAt2.Size = size
			Me.tbOnSpellAt.TabIndex = 4
			Me.tbOnSpellAt.Text = ""
			Dim label89 As Global.System.Windows.Forms.Control = Me.Label33
			point = New Global.System.Drawing.Point(30, 72)
			label89.Location = point
			Me.Label33.Name = "Label33"
			Dim label90 As Global.System.Windows.Forms.Control = Me.Label33
			size = New Global.System.Drawing.Size(84, 18)
			label90.Size = size
			Me.Label33.TabIndex = 3
			Me.Label33.Text = "OnNotice"
			Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnNotice As Global.System.Windows.Forms.Control = Me.tbOnNotice
			point = New Global.System.Drawing.Point(114, 72)
			tbOnNotice.Location = point
			Me.tbOnNotice.Name = "tbOnNotice"
			Dim tbOnNotice2 As Global.System.Windows.Forms.Control = Me.tbOnNotice
			size = New Global.System.Drawing.Size(204, 20)
			tbOnNotice2.Size = size
			Me.tbOnNotice.TabIndex = 2
			Me.tbOnNotice.Text = ""
			Dim label91 As Global.System.Windows.Forms.Control = Me.Label32
			point = New Global.System.Drawing.Point(30, 42)
			label91.Location = point
			Me.Label32.Name = "Label32"
			Dim label92 As Global.System.Windows.Forms.Control = Me.Label32
			size = New Global.System.Drawing.Size(84, 18)
			label92.Size = size
			Me.Label32.TabIndex = 1
			Me.Label32.Text = "OnHeartbeat"
			Me.Label32.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnHeartbeat As Global.System.Windows.Forms.Control = Me.tbOnHeartbeat
			point = New Global.System.Drawing.Point(114, 42)
			tbOnHeartbeat.Location = point
			Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
			Dim tbOnHeartbeat2 As Global.System.Windows.Forms.Control = Me.tbOnHeartbeat
			size = New Global.System.Drawing.Size(204, 20)
			tbOnHeartbeat2.Size = size
			Me.tbOnHeartbeat.TabIndex = 0
			Me.tbOnHeartbeat.Text = ""
			Dim label93 As Global.System.Windows.Forms.Control = Me.Label35
			point = New Global.System.Drawing.Point(30, 132)
			label93.Location = point
			Me.Label35.Name = "Label35"
			Dim label94 As Global.System.Windows.Forms.Control = Me.Label35
			size = New Global.System.Drawing.Size(84, 18)
			label94.Size = size
			Me.Label35.TabIndex = 5
			Me.Label35.Text = "OnAttacked"
			Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnAttacked As Global.System.Windows.Forms.Control = Me.tbOnAttacked
			point = New Global.System.Drawing.Point(114, 132)
			tbOnAttacked.Location = point
			Me.tbOnAttacked.Name = "tbOnAttacked"
			Dim tbOnAttacked2 As Global.System.Windows.Forms.Control = Me.tbOnAttacked
			size = New Global.System.Drawing.Size(204, 20)
			tbOnAttacked2.Size = size
			Me.tbOnAttacked.TabIndex = 6
			Me.tbOnAttacked.Text = ""
			Dim tbOnDamaged As Global.System.Windows.Forms.Control = Me.tbOnDamaged
			point = New Global.System.Drawing.Point(114, 162)
			tbOnDamaged.Location = point
			Me.tbOnDamaged.Name = "tbOnDamaged"
			Dim tbOnDamaged2 As Global.System.Windows.Forms.Control = Me.tbOnDamaged
			size = New Global.System.Drawing.Size(204, 20)
			tbOnDamaged2.Size = size
			Me.tbOnDamaged.TabIndex = 8
			Me.tbOnDamaged.Text = ""
			Dim label95 As Global.System.Windows.Forms.Control = Me.Label36
			point = New Global.System.Drawing.Point(30, 162)
			label95.Location = point
			Me.Label36.Name = "Label36"
			Dim label96 As Global.System.Windows.Forms.Control = Me.Label36
			size = New Global.System.Drawing.Size(84, 18)
			label96.Size = size
			Me.Label36.TabIndex = 5
			Me.Label36.Text = "OnDamaged"
			Me.Label36.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label97 As Global.System.Windows.Forms.Control = Me.Label37
			point = New Global.System.Drawing.Point(30, 192)
			label97.Location = point
			Me.Label37.Name = "Label37"
			Dim label98 As Global.System.Windows.Forms.Control = Me.Label37
			size = New Global.System.Drawing.Size(84, 18)
			label98.Size = size
			Me.Label37.TabIndex = 5
			Me.Label37.Text = "OnDisturbed"
			Me.Label37.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnDisturbed As Global.System.Windows.Forms.Control = Me.tbOnDisturbed
			point = New Global.System.Drawing.Point(114, 192)
			tbOnDisturbed.Location = point
			Me.tbOnDisturbed.Name = "tbOnDisturbed"
			Dim tbOnDisturbed2 As Global.System.Windows.Forms.Control = Me.tbOnDisturbed
			size = New Global.System.Drawing.Size(204, 20)
			tbOnDisturbed2.Size = size
			Me.tbOnDisturbed.TabIndex = 10
			Me.tbOnDisturbed.Text = ""
			Dim tbOnEndRound As Global.System.Windows.Forms.Control = Me.tbOnEndRound
			point = New Global.System.Drawing.Point(114, 222)
			tbOnEndRound.Location = point
			Me.tbOnEndRound.Name = "tbOnEndRound"
			Dim tbOnEndRound2 As Global.System.Windows.Forms.Control = Me.tbOnEndRound
			size = New Global.System.Drawing.Size(204, 20)
			tbOnEndRound2.Size = size
			Me.tbOnEndRound.TabIndex = 12
			Me.tbOnEndRound.Text = ""
			Dim label99 As Global.System.Windows.Forms.Control = Me.Label38
			point = New Global.System.Drawing.Point(30, 222)
			label99.Location = point
			Me.Label38.Name = "Label38"
			Dim label100 As Global.System.Windows.Forms.Control = Me.Label38
			size = New Global.System.Drawing.Size(84, 18)
			label100.Size = size
			Me.Label38.TabIndex = 5
			Me.Label38.Text = "OnEndRound"
			Me.Label38.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnEndDialogu As Global.System.Windows.Forms.Control = Me.tbOnEndDialogu
			point = New Global.System.Drawing.Point(114, 252)
			tbOnEndDialogu.Location = point
			Me.tbOnEndDialogu.Name = "tbOnEndDialogu"
			Dim tbOnEndDialogu2 As Global.System.Windows.Forms.Control = Me.tbOnEndDialogu
			size = New Global.System.Drawing.Size(204, 20)
			tbOnEndDialogu2.Size = size
			Me.tbOnEndDialogu.TabIndex = 14
			Me.tbOnEndDialogu.Text = ""
			Dim label101 As Global.System.Windows.Forms.Control = Me.Label39
			point = New Global.System.Drawing.Point(30, 252)
			label101.Location = point
			Me.Label39.Name = "Label39"
			Dim label102 As Global.System.Windows.Forms.Control = Me.Label39
			size = New Global.System.Drawing.Size(84, 18)
			label102.Size = size
			Me.Label39.TabIndex = 5
			Me.Label39.Text = "OnEndDialogu"
			Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label103 As Global.System.Windows.Forms.Control = Me.Label40
			point = New Global.System.Drawing.Point(30, 282)
			label103.Location = point
			Me.Label40.Name = "Label40"
			Dim label104 As Global.System.Windows.Forms.Control = Me.Label40
			size = New Global.System.Drawing.Size(84, 18)
			label104.Size = size
			Me.Label40.TabIndex = 5
			Me.Label40.Text = "OnDialogue"
			Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnDialogue As Global.System.Windows.Forms.Control = Me.tbOnDialogue
			point = New Global.System.Drawing.Point(114, 282)
			tbOnDialogue.Location = point
			Me.tbOnDialogue.Name = "tbOnDialogue"
			Dim tbOnDialogue2 As Global.System.Windows.Forms.Control = Me.tbOnDialogue
			size = New Global.System.Drawing.Size(204, 20)
			tbOnDialogue2.Size = size
			Me.tbOnDialogue.TabIndex = 16
			Me.tbOnDialogue.Text = ""
			Dim label105 As Global.System.Windows.Forms.Control = Me.Label41
			point = New Global.System.Drawing.Point(30, 312)
			label105.Location = point
			Me.Label41.Name = "Label41"
			Dim label106 As Global.System.Windows.Forms.Control = Me.Label41
			size = New Global.System.Drawing.Size(84, 18)
			label106.Size = size
			Me.Label41.TabIndex = 5
			Me.Label41.Text = "OnSpawn"
			Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnSpawn As Global.System.Windows.Forms.Control = Me.tbOnSpawn
			point = New Global.System.Drawing.Point(114, 312)
			tbOnSpawn.Location = point
			Me.tbOnSpawn.Name = "tbOnSpawn"
			Dim tbOnSpawn2 As Global.System.Windows.Forms.Control = Me.tbOnSpawn
			size = New Global.System.Drawing.Size(204, 20)
			tbOnSpawn2.Size = size
			Me.tbOnSpawn.TabIndex = 18
			Me.tbOnSpawn.Text = ""
			Dim tbOnRested As Global.System.Windows.Forms.Control = Me.tbOnRested
			point = New Global.System.Drawing.Point(114, 342)
			tbOnRested.Location = point
			Me.tbOnRested.Name = "tbOnRested"
			Dim tbOnRested2 As Global.System.Windows.Forms.Control = Me.tbOnRested
			size = New Global.System.Drawing.Size(204, 20)
			tbOnRested2.Size = size
			Me.tbOnRested.TabIndex = 20
			Me.tbOnRested.Text = ""
			Dim label107 As Global.System.Windows.Forms.Control = Me.Label42
			point = New Global.System.Drawing.Point(30, 342)
			label107.Location = point
			Me.Label42.Name = "Label42"
			Dim label108 As Global.System.Windows.Forms.Control = Me.Label42
			size = New Global.System.Drawing.Size(84, 18)
			label108.Size = size
			Me.Label42.TabIndex = 5
			Me.Label42.Text = "OnRested"
			Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnDeath As Global.System.Windows.Forms.Control = Me.tbOnDeath
			point = New Global.System.Drawing.Point(114, 372)
			tbOnDeath.Location = point
			Me.tbOnDeath.Name = "tbOnDeath"
			Dim tbOnDeath2 As Global.System.Windows.Forms.Control = Me.tbOnDeath
			size = New Global.System.Drawing.Size(204, 20)
			tbOnDeath2.Size = size
			Me.tbOnDeath.TabIndex = 22
			Me.tbOnDeath.Text = ""
			Dim label109 As Global.System.Windows.Forms.Control = Me.Label43
			point = New Global.System.Drawing.Point(30, 372)
			label109.Location = point
			Me.Label43.Name = "Label43"
			Dim label110 As Global.System.Windows.Forms.Control = Me.Label43
			size = New Global.System.Drawing.Size(84, 18)
			label110.Size = size
			Me.Label43.TabIndex = 5
			Me.Label43.Text = "OnDeath"
			Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label111 As Global.System.Windows.Forms.Control = Me.Label44
			point = New Global.System.Drawing.Point(30, 402)
			label111.Location = point
			Me.Label44.Name = "Label44"
			Dim label112 As Global.System.Windows.Forms.Control = Me.Label44
			size = New Global.System.Drawing.Size(84, 18)
			label112.Size = size
			Me.Label44.TabIndex = 5
			Me.Label44.Text = "OnBlocked"
			Me.Label44.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbOnBlocked As Global.System.Windows.Forms.Control = Me.tbOnBlocked
			point = New Global.System.Drawing.Point(114, 402)
			tbOnBlocked.Location = point
			Me.tbOnBlocked.Name = "tbOnBlocked"
			Dim tbOnBlocked2 As Global.System.Windows.Forms.Control = Me.tbOnBlocked
			size = New Global.System.Drawing.Size(204, 20)
			tbOnBlocked2.Size = size
			Me.tbOnBlocked.TabIndex = 24
			Me.tbOnBlocked.Text = ""
			Dim tbOnUserDefine As Global.System.Windows.Forms.Control = Me.tbOnUserDefine
			point = New Global.System.Drawing.Point(114, 432)
			tbOnUserDefine.Location = point
			Me.tbOnUserDefine.Name = "tbOnUserDefine"
			Dim tbOnUserDefine2 As Global.System.Windows.Forms.Control = Me.tbOnUserDefine
			size = New Global.System.Drawing.Size(204, 20)
			tbOnUserDefine2.Size = size
			Me.tbOnUserDefine.TabIndex = 26
			Me.tbOnUserDefine.Text = ""
			Dim label113 As Global.System.Windows.Forms.Control = Me.Label45
			point = New Global.System.Drawing.Point(30, 432)
			label113.Location = point
			Me.Label45.Name = "Label45"
			Dim label114 As Global.System.Windows.Forms.Control = Me.Label45
			size = New Global.System.Drawing.Size(84, 18)
			label114.Size = size
			Me.Label45.TabIndex = 5
			Me.Label45.Text = "OnUserDefine"
			Me.Label45.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnNotice As Global.System.Windows.Forms.Control = Me.btnEditOnNotice
			point = New Global.System.Drawing.Point(342, 72)
			btnEditOnNotice.Location = point
			Me.btnEditOnNotice.Name = "btnEditOnNotice"
			Dim btnEditOnNotice2 As Global.System.Windows.Forms.Control = Me.btnEditOnNotice
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnNotice2.Size = size
			Me.btnEditOnNotice.TabIndex = 3
			Me.btnEditOnNotice.Text = "Edit"
			Me.btnEditOnNotice.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnSpellAt As Global.System.Windows.Forms.Control = Me.btnEditOnSpellAt
			point = New Global.System.Drawing.Point(342, 102)
			btnEditOnSpellAt.Location = point
			Me.btnEditOnSpellAt.Name = "btnEditOnSpellAt"
			Dim btnEditOnSpellAt2 As Global.System.Windows.Forms.Control = Me.btnEditOnSpellAt
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnSpellAt2.Size = size
			Me.btnEditOnSpellAt.TabIndex = 5
			Me.btnEditOnSpellAt.Text = "Edit"
			Me.btnEditOnSpellAt.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnSpawn As Global.System.Windows.Forms.Control = Me.btnEditOnSpawn
			point = New Global.System.Drawing.Point(342, 312)
			btnEditOnSpawn.Location = point
			Me.btnEditOnSpawn.Name = "btnEditOnSpawn"
			Dim btnEditOnSpawn2 As Global.System.Windows.Forms.Control = Me.btnEditOnSpawn
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnSpawn2.Size = size
			Me.btnEditOnSpawn.TabIndex = 19
			Me.btnEditOnSpawn.Text = "Edit"
			Me.btnEditOnSpawn.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnDeath As Global.System.Windows.Forms.Control = Me.btnEditOnDeath
			point = New Global.System.Drawing.Point(342, 372)
			btnEditOnDeath.Location = point
			Me.btnEditOnDeath.Name = "btnEditOnDeath"
			Dim btnEditOnDeath2 As Global.System.Windows.Forms.Control = Me.btnEditOnDeath
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnDeath2.Size = size
			Me.btnEditOnDeath.TabIndex = 23
			Me.btnEditOnDeath.Text = "Edit"
			Me.btnEditOnDeath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnBlocked As Global.System.Windows.Forms.Control = Me.btnEditOnBlocked
			point = New Global.System.Drawing.Point(342, 402)
			btnEditOnBlocked.Location = point
			Me.btnEditOnBlocked.Name = "btnEditOnBlocked"
			Dim btnEditOnBlocked2 As Global.System.Windows.Forms.Control = Me.btnEditOnBlocked
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnBlocked2.Size = size
			Me.btnEditOnBlocked.TabIndex = 25
			Me.btnEditOnBlocked.Text = "Edit"
			Me.btnEditOnBlocked.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnRested As Global.System.Windows.Forms.Control = Me.btnEditOnRested
			point = New Global.System.Drawing.Point(342, 342)
			btnEditOnRested.Location = point
			Me.btnEditOnRested.Name = "btnEditOnRested"
			Dim btnEditOnRested2 As Global.System.Windows.Forms.Control = Me.btnEditOnRested
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnRested2.Size = size
			Me.btnEditOnRested.TabIndex = 21
			Me.btnEditOnRested.Text = "Edit"
			Me.btnEditOnRested.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim btnEditOnEndRound As Global.System.Windows.Forms.Control = Me.btnEditOnEndRound
			point = New Global.System.Drawing.Point(342, 222)
			btnEditOnEndRound.Location = point
			Me.btnEditOnEndRound.Name = "btnEditOnEndRound"
			Dim btnEditOnEndRound2 As Global.System.Windows.Forms.Control = Me.btnEditOnEndRound
			size = New Global.System.Drawing.Size(32, 23)
			btnEditOnEndRound2.Size = size
			Me.btnEditOnEndRound.TabIndex = 13
			Me.btnEditOnEndRound.Text = "Edit"
			Me.btnEditOnEndRound.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tpComments.Controls.Add(Me.tbComments)
			Dim tpComments As Global.System.Windows.Forms.Control = Me.tpComments
			point = New Global.System.Drawing.Point(4, 40)
			tpComments.Location = point
			Me.tpComments.Name = "tpComments"
			Dim tpComments2 As Global.System.Windows.Forms.Control = Me.tpComments
			size = New Global.System.Drawing.Size(408, 492)
			tpComments2.Size = size
			Me.tpComments.TabIndex = 10
			Me.tpComments.Text = "Comments"
			Dim tbComments As Global.System.Windows.Forms.Control = Me.tbComments
			point = New Global.System.Drawing.Point(24, 18)
			tbComments.Location = point
			Me.tbComments.Multiline = True
			Me.tbComments.Name = "tbComments"
			Dim tbComments2 As Global.System.Windows.Forms.Control = Me.tbComments
			size = New Global.System.Drawing.Size(354, 456)
			tbComments2.Size = size
			Me.tbComments.TabIndex = 0
			Me.tbComments.Text = ""
			Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			point = New Global.System.Drawing.Point(328, 579)
			btnCancel.Location = point
			Me.btnCancel.Name = "btnCancel"
			Dim btnCancel2 As Global.System.Windows.Forms.Control = Me.btnCancel
			size = New Global.System.Drawing.Size(72, 24)
			btnCancel2.Size = size
			Me.btnCancel.TabIndex = 1
			Me.btnCancel.Text = "&Cancel"
			Dim btnWriteFile As Global.System.Windows.Forms.Control = Me.btnWriteFile
			point = New Global.System.Drawing.Point(240, 579)
			btnWriteFile.Location = point
			Me.btnWriteFile.Name = "btnWriteFile"
			Dim btnWriteFile2 As Global.System.Windows.Forms.Control = Me.btnWriteFile
			size = New Global.System.Drawing.Size(72, 24)
			btnWriteFile2.Size = size
			Me.btnWriteFile.TabIndex = 1
			Me.btnWriteFile.Text = "&Save"
			Dim btnInventory As Global.System.Windows.Forms.Control = Me.btnInventory
			point = New Global.System.Drawing.Point(64, 579)
			btnInventory.Location = point
			Me.btnInventory.Name = "btnInventory"
			Dim btnInventory2 As Global.System.Windows.Forms.Control = Me.btnInventory
			size = New Global.System.Drawing.Size(72, 24)
			btnInventory2.Size = size
			Me.btnInventory.TabIndex = 1
			Me.btnInventory.Text = "&Inventory"
			Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
			Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
			point = New Global.System.Drawing.Point(0, 0)
			btnDebug.Location = point
			Me.btnDebug.Name = "btnDebug"
			Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
			size = New Global.System.Drawing.Size(8, 8)
			btnDebug2.Size = size
			Me.btnDebug.TabIndex = 2
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.btnCancel
			size = New Global.System.Drawing.Size(432, 613)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnDebug)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.tabCtrl1)
			Me.Controls.Add(Me.btnWriteFile)
			Me.Controls.Add(Me.btnInventory)
			Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			size = New Global.System.Drawing.Size(440, 640)
			Me.MaximumSize = size
			size = New Global.System.Drawing.Size(440, 640)
			Me.MinimumSize = size
			Me.Name = "frmUTC_Editor"
			Me.Text = "Creature Editor - KotOR "
			Me.tabCtrl1.ResumeLayout(False)
			Me.tpBasic.ResumeLayout(False)
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.tpStatistics.ResumeLayout(False)
			Me.GroupBox7.ResumeLayout(False)
			Me.gb2.ResumeLayout(False)
			CType(Me.nudWillBonus, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudFortBonus, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudRefBonus, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.nudStrength, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudDexterity, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudConstitution, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudIntelligence, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudWisdom, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudCharisma, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox6.ResumeLayout(False)
			CType(Me.nudNaturalAC, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox5.ResumeLayout(False)
			CType(Me.nudBaseHP, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudCurrentHP, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudMaxHP, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpSkills.ResumeLayout(False)
			CType(Me.nudComputerUse, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudDemolitions, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudStealth, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudAwareness, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudPersuade, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudRepair, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudSecurity, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudTreatInjury, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpAdvanced.ResumeLayout(False)
			Me.GroupBox12.ResumeLayout(False)
			Me.GroupBox11.ResumeLayout(False)
			CType(Me.nudMultiplierSet, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudBlindSpot, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox13.ResumeLayout(False)
			Me.GroupBox14.ResumeLayout(False)
			Me.GroupBox15.ResumeLayout(False)
			Me.GroupBox18.ResumeLayout(False)
			Me.tpFeats.ResumeLayout(False)
			Me.GroupBox10.ResumeLayout(False)
			Me.toForcePowers.ResumeLayout(False)
			Me.GroupBox19.ResumeLayout(False)
			Me.GroupBox17.ResumeLayout(False)
			Me.GroupBox16.ResumeLayout(False)
			CType(Me.nudForcePoints, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nudCurrentForce, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpClasses.ResumeLayout(False)
			Me.GroupBox9.ResumeLayout(False)
			CType(Me.nudClassLevel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox8.ResumeLayout(False)
			CType(Me.nudAlignment, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trkbarAlignment, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpSpecialAbilities.ResumeLayout(False)
			Me.GroupBox20.ResumeLayout(False)
			Me.tpScripts.ResumeLayout(False)
			Me.tpComments.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040008F0 RID: 2288
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
