Namespace kotor_tool
	' Token: 0x0200007C RID: 124
	Public Partial Class frmUTC_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents tpBasic As Global.System.Windows.Forms.TabPage
        Friend WithEvents tpStatistics As Global.System.Windows.Forms.TabPage
        Friend WithEvents tpClasses As Global.System.Windows.Forms.TabPage
        Friend WithEvents tpSkills As Global.System.Windows.Forms.TabPage
        Friend WithEvents tpScripts As Global.System.Windows.Forms.TabPage
        Friend WithEvents tpAdvanced As Global.System.Windows.Forms.TabPage
        Friend WithEvents tpFeats As Global.System.Windows.Forms.TabPage
        Friend WithEvents toForcePowers As Global.System.Windows.Forms.TabPage
        Friend WithEvents tpSpecialAbilities As Global.System.Windows.Forms.TabPage
        Friend WithEvents tpComments As Global.System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents tbConversation As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbxRace As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbFirstName As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbLastName As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbxAppearance As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxGender As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tabCtrl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents cmbxPhenotype As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents GroupBox4 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents nudStrength As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudDexterity As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudConstitution As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudIntelligence As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudWisdom As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCharisma As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents gb2 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox6 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox5 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents nudBaseHP As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents GroupBox7 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents nudNaturalAC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents nudWillBonus As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFortBonus As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRefBonus As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxMovementRate As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxClass As Global.System.Windows.Forms.ComboBox
        Friend WithEvents nudComputerUse As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents Label26 As Global.System.Windows.Forms.Label
        Friend WithEvents Label27 As Global.System.Windows.Forms.Label
        Friend WithEvents Label28 As Global.System.Windows.Forms.Label
        Friend WithEvents Label29 As Global.System.Windows.Forms.Label
        Friend WithEvents nudDemolitions As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudStealth As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudAwareness As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudPersuade As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRepair As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label30 As Global.System.Windows.Forms.Label
        Friend WithEvents nudSecurity As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudTreatInjury As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label31 As Global.System.Windows.Forms.Label
        Friend WithEvents Label32 As Global.System.Windows.Forms.Label
        Friend WithEvents Label33 As Global.System.Windows.Forms.Label
        Friend WithEvents Label34 As Global.System.Windows.Forms.Label
        Friend WithEvents Label35 As Global.System.Windows.Forms.Label
        Friend WithEvents Label36 As Global.System.Windows.Forms.Label
        Friend WithEvents Label37 As Global.System.Windows.Forms.Label
        Friend WithEvents Label38 As Global.System.Windows.Forms.Label
        Friend WithEvents Label39 As Global.System.Windows.Forms.Label
        Friend WithEvents Label40 As Global.System.Windows.Forms.Label
        Friend WithEvents Label41 As Global.System.Windows.Forms.Label
        Friend WithEvents Label42 As Global.System.Windows.Forms.Label
        Friend WithEvents Label43 As Global.System.Windows.Forms.Label
        Friend WithEvents Label44 As Global.System.Windows.Forms.Label
        Friend WithEvents tbOnHeartbeat As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnNotice As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnSpellAt As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnAttacked As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnDamaged As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnDisturbed As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnEndRound As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnEndDialogu As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnDialogue As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnSpawn As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnRested As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnDeath As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnBlocked As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbOnUserDefine As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label45 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbNotInterruptable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label46 As Global.System.Windows.Forms.Label
        Friend WithEvents nudClassLevel As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents GroupBox8 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox9 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents trkbarAlignment As Global.System.Windows.Forms.TrackBar
        Friend WithEvents Label47 As Global.System.Windows.Forms.Label
        Friend WithEvents Label48 As Global.System.Windows.Forms.Label
        Friend WithEvents nudAlignment As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents chklbFeats As Global.System.Windows.Forms.CheckedListBox
        Friend WithEvents tbFeatSummary As Global.System.Windows.Forms.TextBox
        Friend WithEvents GroupBox10 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents Label49 As Global.System.Windows.Forms.Label
        Friend WithEvents nudCurrentHP As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudMaxHP As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label50 As Global.System.Windows.Forms.Label
        Friend WithEvents tbComments As Global.System.Windows.Forms.TextBox
        Friend WithEvents GroupBox11 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents Label51 As Global.System.Windows.Forms.Label
        Friend WithEvents Label52 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbDisarmable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbPlot As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbNoPermDeath As Global.System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox12 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox13 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox14 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents tbChallengeRating As Global.System.Windows.Forms.TextBox
        Friend WithEvents GroupBox15 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents cmbxPerceptionRange As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbDeity As Global.System.Windows.Forms.TextBox
        Friend WithEvents GroupBox16 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox17 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents chklbForcePowers As Global.System.Windows.Forms.CheckedListBox
        Friend WithEvents Label54 As Global.System.Windows.Forms.Label
        Friend WithEvents Label55 As Global.System.Windows.Forms.Label
        Friend WithEvents nudForcePoints As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCurrentForce As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents chklbSpecialAbilities As Global.System.Windows.Forms.CheckedListBox
        Friend WithEvents GroupBox18 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents tbTemplateResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label56 As Global.System.Windows.Forms.Label
        Friend WithEvents Label57 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxTreasureModel As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnWriteFile As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxSoundSet As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxPortrait As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxSubrace As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnClearAllPowers As Global.System.Windows.Forms.Button
        Friend WithEvents btnSelectAllPowers As Global.System.Windows.Forms.Button
        Friend WithEvents btnInventory As Global.System.Windows.Forms.Button
        Friend WithEvents GroupBox19 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents tbForcePowerSummary As Global.System.Windows.Forms.TextBox
        Friend WithEvents GroupBox20 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxBodyBag As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label53 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbIsHologram As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbNotReorienting As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbIgnoreCrePath As Global.System.Windows.Forms.CheckBox
        Friend WithEvents nudMultiplierSet As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblMultiplierSet As Global.System.Windows.Forms.Label
        Friend WithEvents lblBlindSpot As Global.System.Windows.Forms.Label
        Friend WithEvents nudBlindSpot As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents chkbMin1HP As Global.System.Windows.Forms.CheckBox
        Friend WithEvents cmbxFaction As Global.System.Windows.Forms.ComboBox
        Friend WithEvents chkbIsPC As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnEditOnEndDialogu As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDialogue As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnUserDefine As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnHeartbeat As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDisturbed As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDamaged As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnAttacked As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnNotice As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnSpellAt As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnSpawn As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnDeath As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnBlocked As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnRested As Global.System.Windows.Forms.Button
        Friend WithEvents btnEditOnEndRound As Global.System.Windows.Forms.Button


		' Token: 0x0600110A RID: 4362 RVA: 0x0029F218 File Offset: 0x0029E218
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06001285 RID: 4741 RVA: 0x002A1AE8 File Offset: 0x002A0AE8
		<Global.System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUTC_Editor))
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
			Me.tabCtrl1.Location = New Global.System.Drawing.Point(8, 32)
			Me.tabCtrl1.Multiline = True
			Me.tabCtrl1.Name = "tabCtrl1"
			Me.tabCtrl1.Padding = New Global.System.Drawing.Point(14, 3)
			Me.tabCtrl1.SelectedIndex = 0
			Me.tabCtrl1.Size = New Global.System.Drawing.Size(416, 536)
			Me.tabCtrl1.SizeMode = Global.System.Windows.Forms.TabSizeMode.FillToRight
			Me.tabCtrl1.TabIndex = 0
			Me.tpBasic.Controls.Add(Me.GroupBox3)
			Me.tpBasic.Controls.Add(Me.GroupBox2)
			Me.tpBasic.Controls.Add(Me.GroupBox1)
			Me.tpBasic.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpBasic.Name = "tpBasic"
			Me.tpBasic.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpBasic.TabIndex = 0
			Me.tpBasic.Text = "Basic"
			Me.GroupBox3.Controls.Add(Me.chkbNotInterruptable)
			Me.GroupBox3.Controls.Add(Me.tbConversation)
			Me.GroupBox3.Location = New Global.System.Drawing.Point(8, 432)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.Size = New Global.System.Drawing.Size(392, 56)
			Me.GroupBox3.TabIndex = 2
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Conversation"
			Me.chkbNotInterruptable.Location = New Global.System.Drawing.Point(300, 24)
			Me.chkbNotInterruptable.Name = "chkbNotInterruptable"
			Me.chkbNotInterruptable.Size = New Global.System.Drawing.Size(84, 24)
			Me.chkbNotInterruptable.TabIndex = 1
			Me.chkbNotInterruptable.Text = "No Interrupt"
			Me.tbConversation.Location = New Global.System.Drawing.Point(24, 24)
			Me.tbConversation.Name = "tbConversation"
			Me.tbConversation.Size = New Global.System.Drawing.Size(168, 20)
			Me.tbConversation.TabIndex = 0
			Me.tbConversation.Text = ""
			Me.GroupBox2.Controls.Add(Me.cmbxPortrait)
			Me.GroupBox2.Location = New Global.System.Drawing.Point(8, 312)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Global.System.Drawing.Size(392, 120)
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Portrait"
			Me.cmbxPortrait.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxPortrait.Location = New Global.System.Drawing.Point(174, 54)
			Me.cmbxPortrait.Name = "cmbxPortrait"
			Me.cmbxPortrait.Size = New Global.System.Drawing.Size(184, 21)
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
			Me.GroupBox1.Location = New Global.System.Drawing.Point(8, 8)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Global.System.Drawing.Size(392, 304)
			Me.GroupBox1.TabIndex = 0
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Profile"
			Me.cmbxRace.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxRace.Location = New Global.System.Drawing.Point(104, 104)
			Me.cmbxRace.Name = "cmbxRace"
			Me.cmbxRace.Size = New Global.System.Drawing.Size(184, 21)
			Me.cmbxRace.TabIndex = 3
			Me.tbFirstName.Location = New Global.System.Drawing.Point(104, 20)
			Me.tbFirstName.Name = "tbFirstName"
			Me.tbFirstName.Size = New Global.System.Drawing.Size(184, 20)
			Me.tbFirstName.TabIndex = 0
			Me.tbFirstName.Text = ""
			Me.Label1.Location = New Global.System.Drawing.Point(16, 22)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "First Name:"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label2.Location = New Global.System.Drawing.Point(16, 50)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label2.TabIndex = 0
			Me.Label2.Text = "Last Name:"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label3.Location = New Global.System.Drawing.Point(16, 78)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label3.TabIndex = 0
			Me.Label3.Text = "Tag"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label4.Location = New Global.System.Drawing.Point(16, 106)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label4.TabIndex = 0
			Me.Label4.Text = "Race"
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label5.Location = New Global.System.Drawing.Point(16, 138)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label5.TabIndex = 0
			Me.Label5.Text = "Appearance"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label6.Location = New Global.System.Drawing.Point(16, 170)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label6.TabIndex = 0
			Me.Label6.Text = "Phenotype"
			Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label7.Location = New Global.System.Drawing.Point(16, 234)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label7.TabIndex = 0
			Me.Label7.Text = "Description"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label9.Location = New Global.System.Drawing.Point(16, 202)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label9.TabIndex = 0
			Me.Label9.Text = "Gender"
			Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbLastName.Location = New Global.System.Drawing.Point(104, 48)
			Me.tbLastName.Name = "tbLastName"
			Me.tbLastName.[ReadOnly] = True
			Me.tbLastName.Size = New Global.System.Drawing.Size(184, 20)
			Me.tbLastName.TabIndex = 1
			Me.tbLastName.Text = ""
			Me.tbTag.Location = New Global.System.Drawing.Point(104, 76)
			Me.tbTag.Name = "tbTag"
			Me.tbTag.Size = New Global.System.Drawing.Size(184, 20)
			Me.tbTag.TabIndex = 2
			Me.tbTag.Text = ""
			Me.tbDescription.Location = New Global.System.Drawing.Point(104, 232)
			Me.tbDescription.Name = "tbDescription"
			Me.tbDescription.Size = New Global.System.Drawing.Size(184, 20)
			Me.tbDescription.TabIndex = 7
			Me.tbDescription.Text = ""
			Me.cmbxAppearance.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxAppearance.Location = New Global.System.Drawing.Point(104, 136)
			Me.cmbxAppearance.Name = "cmbxAppearance"
			Me.cmbxAppearance.Size = New Global.System.Drawing.Size(184, 21)
			Me.cmbxAppearance.TabIndex = 4
			Me.cmbxPhenotype.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxPhenotype.Location = New Global.System.Drawing.Point(104, 168)
			Me.cmbxPhenotype.Name = "cmbxPhenotype"
			Me.cmbxPhenotype.Size = New Global.System.Drawing.Size(184, 21)
			Me.cmbxPhenotype.TabIndex = 5
			Me.cmbxGender.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxGender.Location = New Global.System.Drawing.Point(104, 200)
			Me.cmbxGender.Name = "cmbxGender"
			Me.cmbxGender.Size = New Global.System.Drawing.Size(184, 21)
			Me.cmbxGender.TabIndex = 6
			Me.cmbxBodyBag.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxBodyBag.Location = New Global.System.Drawing.Point(104, 268)
			Me.cmbxBodyBag.Name = "cmbxBodyBag"
			Me.cmbxBodyBag.Size = New Global.System.Drawing.Size(184, 21)
			Me.cmbxBodyBag.TabIndex = 4
			Me.Label53.Location = New Global.System.Drawing.Point(16, 270)
			Me.Label53.Name = "Label53"
			Me.Label53.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label53.TabIndex = 0
			Me.Label53.Text = "BodyBag"
			Me.Label53.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tpStatistics.Controls.Add(Me.GroupBox7)
			Me.tpStatistics.Controls.Add(Me.gb2)
			Me.tpStatistics.Controls.Add(Me.GroupBox4)
			Me.tpStatistics.Controls.Add(Me.GroupBox6)
			Me.tpStatistics.Controls.Add(Me.GroupBox5)
			Me.tpStatistics.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpStatistics.Name = "tpStatistics"
			Me.tpStatistics.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpStatistics.TabIndex = 1
			Me.tpStatistics.Text = "Statistics"
			Me.GroupBox7.Controls.Add(Me.cmbxMovementRate)
			Me.GroupBox7.Controls.Add(Me.Label18)
			Me.GroupBox7.Location = New Global.System.Drawing.Point(210, 432)
			Me.GroupBox7.Name = "GroupBox7"
			Me.GroupBox7.Size = New Global.System.Drawing.Size(192, 48)
			Me.GroupBox7.TabIndex = 3
			Me.GroupBox7.TabStop = False
			Me.GroupBox7.Text = "Speed"
			Me.cmbxMovementRate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxMovementRate.Location = New Global.System.Drawing.Point(102, 18)
			Me.cmbxMovementRate.Name = "cmbxMovementRate"
			Me.cmbxMovementRate.Size = New Global.System.Drawing.Size(72, 21)
			Me.cmbxMovementRate.TabIndex = 0
			Me.Label18.Location = New Global.System.Drawing.Point(12, 20)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(84, 18)
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
			Me.gb2.Location = New Global.System.Drawing.Point(6, 210)
			Me.gb2.Name = "gb2"
			Me.gb2.Size = New Global.System.Drawing.Size(396, 108)
			Me.gb2.TabIndex = 2
			Me.gb2.TabStop = False
			Me.gb2.Text = "Saves"
			Me.Label19.Location = New Global.System.Drawing.Point(32, 59)
			Me.Label19.Name = "Label19"
			Me.Label19.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label19.TabIndex = 0
			Me.Label19.Text = "Reflex"
			Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label20.Location = New Global.System.Drawing.Point(32, 83)
			Me.Label20.Name = "Label20"
			Me.Label20.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label20.TabIndex = 0
			Me.Label20.Text = "Will"
			Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label21.Location = New Global.System.Drawing.Point(32, 35)
			Me.Label21.Name = "Label21"
			Me.Label21.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label21.TabIndex = 0
			Me.Label21.Text = "Fortitude"
			Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudWillBonus.Location = New Global.System.Drawing.Point(126, 83)
			Me.nudWillBonus.Maximum = New Decimal(New Integer() { 250, 0, 0, 0 })
			Me.nudWillBonus.Name = "nudWillBonus"
			Me.nudWillBonus.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudWillBonus.TabIndex = 2
			Me.nudWillBonus.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudFortBonus.Location = New Global.System.Drawing.Point(126, 35)
			Me.nudFortBonus.Maximum = New Decimal(New Integer() { 250, 0, 0, 0 })
			Me.nudFortBonus.Name = "nudFortBonus"
			Me.nudFortBonus.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudFortBonus.TabIndex = 0
			Me.nudFortBonus.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudRefBonus.Location = New Global.System.Drawing.Point(126, 59)
			Me.nudRefBonus.Maximum = New Decimal(New Integer() { 250, 0, 0, 0 })
			Me.nudRefBonus.Name = "nudRefBonus"
			Me.nudRefBonus.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudRefBonus.TabIndex = 1
			Me.nudRefBonus.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Label22.Location = New Global.System.Drawing.Point(126, 16)
			Me.Label22.Name = "Label22"
			Me.Label22.Size = New Global.System.Drawing.Size(66, 18)
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
			Me.GroupBox4.Location = New Global.System.Drawing.Point(6, 12)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.Size = New Global.System.Drawing.Size(396, 186)
			Me.GroupBox4.TabIndex = 1
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Ability Score"
			Me.nudStrength.Location = New Global.System.Drawing.Point(126, 30)
			Me.nudStrength.Minimum = New Decimal(New Integer() { 3, 0, 0, 0 })
			Me.nudStrength.Name = "nudStrength"
			Me.nudStrength.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudStrength.TabIndex = 0
			Me.nudStrength.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudStrength.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.Label14.Location = New Global.System.Drawing.Point(30, 151)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label14.TabIndex = 0
			Me.Label14.Text = "Charisma"
			Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label10.Location = New Global.System.Drawing.Point(30, 55)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label10.TabIndex = 0
			Me.Label10.Text = "Dexterity"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label11.Location = New Global.System.Drawing.Point(30, 79)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label11.TabIndex = 0
			Me.Label11.Text = "Constitution"
			Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label13.Location = New Global.System.Drawing.Point(30, 127)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label13.TabIndex = 0
			Me.Label13.Text = "Wisdom"
			Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label8.Location = New Global.System.Drawing.Point(30, 31)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label8.TabIndex = 0
			Me.Label8.Text = "Strength"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label12.Location = New Global.System.Drawing.Point(30, 103)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label12.TabIndex = 0
			Me.Label12.Text = "Intelligence"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label15.Location = New Global.System.Drawing.Point(126, 12)
			Me.Label15.Name = "Label15"
			Me.Label15.Size = New Global.System.Drawing.Size(42, 18)
			Me.Label15.TabIndex = 0
			Me.Label15.Text = "Score"
			Me.nudDexterity.Location = New Global.System.Drawing.Point(126, 54)
			Me.nudDexterity.Minimum = New Decimal(New Integer() { 3, 0, 0, 0 })
			Me.nudDexterity.Name = "nudDexterity"
			Me.nudDexterity.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudDexterity.TabIndex = 1
			Me.nudDexterity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudDexterity.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudConstitution.Location = New Global.System.Drawing.Point(126, 78)
			Me.nudConstitution.Minimum = New Decimal(New Integer() { 3, 0, 0, 0 })
			Me.nudConstitution.Name = "nudConstitution"
			Me.nudConstitution.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudConstitution.TabIndex = 2
			Me.nudConstitution.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudConstitution.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudIntelligence.Location = New Global.System.Drawing.Point(126, 102)
			Me.nudIntelligence.Minimum = New Decimal(New Integer() { 3, 0, 0, 0 })
			Me.nudIntelligence.Name = "nudIntelligence"
			Me.nudIntelligence.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudIntelligence.TabIndex = 3
			Me.nudIntelligence.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudIntelligence.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudWisdom.Location = New Global.System.Drawing.Point(126, 126)
			Me.nudWisdom.Minimum = New Decimal(New Integer() { 3, 0, 0, 0 })
			Me.nudWisdom.Name = "nudWisdom"
			Me.nudWisdom.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudWisdom.TabIndex = 4
			Me.nudWisdom.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudWisdom.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudCharisma.Location = New Global.System.Drawing.Point(126, 150)
			Me.nudCharisma.Minimum = New Decimal(New Integer() { 3, 0, 0, 0 })
			Me.nudCharisma.Name = "nudCharisma"
			Me.nudCharisma.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudCharisma.TabIndex = 5
			Me.nudCharisma.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudCharisma.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.GroupBox6.Controls.Add(Me.Label16)
			Me.GroupBox6.Controls.Add(Me.nudNaturalAC)
			Me.GroupBox6.Location = New Global.System.Drawing.Point(6, 324)
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.Size = New Global.System.Drawing.Size(198, 156)
			Me.GroupBox6.TabIndex = 2
			Me.GroupBox6.TabStop = False
			Me.GroupBox6.Text = "Armor Class"
			Me.Label16.Location = New Global.System.Drawing.Point(8, 25)
			Me.Label16.Name = "Label16"
			Me.Label16.Size = New Global.System.Drawing.Size(66, 18)
			Me.Label16.TabIndex = 1
			Me.Label16.Text = "Natural AC"
			Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudNaturalAC.Location = New Global.System.Drawing.Point(114, 24)
			Me.nudNaturalAC.Maximum = New Decimal(New Integer() { 1000, 0, 0, 0 })
			Me.nudNaturalAC.Name = "nudNaturalAC"
			Me.nudNaturalAC.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudNaturalAC.TabIndex = 0
			Me.nudNaturalAC.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudNaturalAC.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.GroupBox5.Controls.Add(Me.Label17)
			Me.GroupBox5.Controls.Add(Me.nudBaseHP)
			Me.GroupBox5.Controls.Add(Me.Label49)
			Me.GroupBox5.Controls.Add(Me.nudCurrentHP)
			Me.GroupBox5.Controls.Add(Me.nudMaxHP)
			Me.GroupBox5.Controls.Add(Me.Label50)
			Me.GroupBox5.Location = New Global.System.Drawing.Point(210, 324)
			Me.GroupBox5.Name = "GroupBox5"
			Me.GroupBox5.Size = New Global.System.Drawing.Size(192, 108)
			Me.GroupBox5.TabIndex = 2
			Me.GroupBox5.TabStop = False
			Me.GroupBox5.Text = "Hit Points"
			Me.Label17.Location = New Global.System.Drawing.Point(19, 24)
			Me.Label17.Name = "Label17"
			Me.Label17.Size = New Global.System.Drawing.Size(85, 18)
			Me.Label17.TabIndex = 3
			Me.Label17.Text = "Base Hit Points"
			Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudBaseHP.Location = New Global.System.Drawing.Point(125, 24)
			Me.nudBaseHP.Maximum = New Decimal(New Integer() { 9999, 0, 0, 0 })
			Me.nudBaseHP.Minimum = New Decimal(New Integer() { 1, 0, 0, 0 })
			Me.nudBaseHP.Name = "nudBaseHP"
			Me.nudBaseHP.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudBaseHP.TabIndex = 0
			Me.nudBaseHP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudBaseHP.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.Label49.Location = New Global.System.Drawing.Point(19, 49)
			Me.Label49.Name = "Label49"
			Me.Label49.Size = New Global.System.Drawing.Size(96, 18)
			Me.Label49.TabIndex = 3
			Me.Label49.Text = "Current Hit Points"
			Me.Label49.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudCurrentHP.Location = New Global.System.Drawing.Point(125, 48)
			Me.nudCurrentHP.Maximum = New Decimal(New Integer() { 9999, 0, 0, 0 })
			Me.nudCurrentHP.Minimum = New Decimal(New Integer() { 1, 0, 0, 0 })
			Me.nudCurrentHP.Name = "nudCurrentHP"
			Me.nudCurrentHP.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudCurrentHP.TabIndex = 1
			Me.nudCurrentHP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudCurrentHP.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudMaxHP.Location = New Global.System.Drawing.Point(125, 72)
			Me.nudMaxHP.Maximum = New Decimal(New Integer() { 9999, 0, 0, 0 })
			Me.nudMaxHP.Minimum = New Decimal(New Integer() { 1, 0, 0, 0 })
			Me.nudMaxHP.Name = "nudMaxHP"
			Me.nudMaxHP.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudMaxHP.TabIndex = 2
			Me.nudMaxHP.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudMaxHP.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.Label50.Location = New Global.System.Drawing.Point(19, 73)
			Me.Label50.Name = "Label50"
			Me.Label50.Size = New Global.System.Drawing.Size(85, 18)
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
			Me.tpSkills.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpSkills.Name = "tpSkills"
			Me.tpSkills.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpSkills.TabIndex = 4
			Me.tpSkills.Text = "Skills"
			Me.nudComputerUse.Location = New Global.System.Drawing.Point(186, 60)
			Me.nudComputerUse.Name = "nudComputerUse"
			Me.nudComputerUse.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudComputerUse.TabIndex = 0
			Me.nudComputerUse.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudComputerUse.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.Label24.Location = New Global.System.Drawing.Point(96, 180)
			Me.Label24.Name = "Label24"
			Me.Label24.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label24.TabIndex = 6
			Me.Label24.Text = "Repair"
			Me.Label24.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label25.Location = New Global.System.Drawing.Point(96, 84)
			Me.Label25.Name = "Label25"
			Me.Label25.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label25.TabIndex = 7
			Me.Label25.Text = "Demolitions"
			Me.Label25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label26.Location = New Global.System.Drawing.Point(96, 108)
			Me.Label26.Name = "Label26"
			Me.Label26.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label26.TabIndex = 5
			Me.Label26.Text = "Stealth"
			Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label27.Location = New Global.System.Drawing.Point(96, 156)
			Me.Label27.Name = "Label27"
			Me.Label27.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label27.TabIndex = 2
			Me.Label27.Text = "Persuade"
			Me.Label27.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label28.Location = New Global.System.Drawing.Point(96, 60)
			Me.Label28.Name = "Label28"
			Me.Label28.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label28.TabIndex = 3
			Me.Label28.Text = "Computer Use"
			Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label29.Location = New Global.System.Drawing.Point(96, 132)
			Me.Label29.Name = "Label29"
			Me.Label29.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label29.TabIndex = 4
			Me.Label29.Text = "Awareness"
			Me.Label29.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudDemolitions.Location = New Global.System.Drawing.Point(186, 84)
			Me.nudDemolitions.Name = "nudDemolitions"
			Me.nudDemolitions.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudDemolitions.TabIndex = 1
			Me.nudDemolitions.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudDemolitions.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudStealth.Location = New Global.System.Drawing.Point(186, 108)
			Me.nudStealth.Name = "nudStealth"
			Me.nudStealth.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudStealth.TabIndex = 2
			Me.nudStealth.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudStealth.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudAwareness.Location = New Global.System.Drawing.Point(186, 132)
			Me.nudAwareness.Name = "nudAwareness"
			Me.nudAwareness.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudAwareness.TabIndex = 3
			Me.nudAwareness.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudAwareness.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudPersuade.Location = New Global.System.Drawing.Point(186, 156)
			Me.nudPersuade.Name = "nudPersuade"
			Me.nudPersuade.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudPersuade.TabIndex = 4
			Me.nudPersuade.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudPersuade.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudRepair.Location = New Global.System.Drawing.Point(186, 180)
			Me.nudRepair.Name = "nudRepair"
			Me.nudRepair.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudRepair.TabIndex = 5
			Me.nudRepair.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudRepair.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.Label30.Location = New Global.System.Drawing.Point(96, 204)
			Me.Label30.Name = "Label30"
			Me.Label30.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label30.TabIndex = 2
			Me.Label30.Text = "Security"
			Me.Label30.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudSecurity.Location = New Global.System.Drawing.Point(186, 204)
			Me.nudSecurity.Name = "nudSecurity"
			Me.nudSecurity.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudSecurity.TabIndex = 6
			Me.nudSecurity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudSecurity.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.nudTreatInjury.Location = New Global.System.Drawing.Point(186, 228)
			Me.nudTreatInjury.Name = "nudTreatInjury"
			Me.nudTreatInjury.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudTreatInjury.TabIndex = 7
			Me.nudTreatInjury.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudTreatInjury.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.Label31.Location = New Global.System.Drawing.Point(96, 228)
			Me.Label31.Name = "Label31"
			Me.Label31.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label31.TabIndex = 6
			Me.Label31.Text = "Treat Injury"
			Me.Label31.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tpAdvanced.Controls.Add(Me.GroupBox12)
			Me.tpAdvanced.Controls.Add(Me.GroupBox11)
			Me.tpAdvanced.Controls.Add(Me.GroupBox13)
			Me.tpAdvanced.Controls.Add(Me.GroupBox14)
			Me.tpAdvanced.Controls.Add(Me.GroupBox15)
			Me.tpAdvanced.Controls.Add(Me.GroupBox18)
			Me.tpAdvanced.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpAdvanced.Name = "tpAdvanced"
			Me.tpAdvanced.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpAdvanced.TabIndex = 6
			Me.tpAdvanced.Text = "Advanced"
			Me.GroupBox12.Controls.Add(Me.tbChallengeRating)
			Me.GroupBox12.Location = New Global.System.Drawing.Point(12, 384)
			Me.GroupBox12.Name = "GroupBox12"
			Me.GroupBox12.Size = New Global.System.Drawing.Size(186, 48)
			Me.GroupBox12.TabIndex = 3
			Me.GroupBox12.TabStop = False
			Me.GroupBox12.Text = "Challenge Rating"
			Me.tbChallengeRating.Location = New Global.System.Drawing.Point(36, 15)
			Me.tbChallengeRating.Name = "tbChallengeRating"
			Me.tbChallengeRating.Size = New Global.System.Drawing.Size(42, 20)
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
			Me.GroupBox11.Location = New Global.System.Drawing.Point(12, 114)
			Me.GroupBox11.Name = "GroupBox11"
			Me.GroupBox11.Size = New Global.System.Drawing.Size(384, 246)
			Me.GroupBox11.TabIndex = 2
			Me.GroupBox11.TabStop = False
			Me.GroupBox11.Text = "Special"
			Me.nudMultiplierSet.Location = New Global.System.Drawing.Point(318, 156)
			Me.nudMultiplierSet.Name = "nudMultiplierSet"
			Me.nudMultiplierSet.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudMultiplierSet.TabIndex = 7
			Me.nudMultiplierSet.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudMultiplierSet.Visible = False
			Me.Label51.Location = New Global.System.Drawing.Point(30, 192)
			Me.Label51.Name = "Label51"
			Me.Label51.Size = New Global.System.Drawing.Size(100, 18)
			Me.Label51.TabIndex = 1
			Me.Label51.Text = "Subrace"
			Me.chkbDisarmable.Location = New Global.System.Drawing.Point(30, 30)
			Me.chkbDisarmable.Name = "chkbDisarmable"
			Me.chkbDisarmable.Size = New Global.System.Drawing.Size(104, 18)
			Me.chkbDisarmable.TabIndex = 0
			Me.chkbDisarmable.Text = "Disarmable"
			Me.chkbPlot.Location = New Global.System.Drawing.Point(30, 78)
			Me.chkbPlot.Name = "chkbPlot"
			Me.chkbPlot.Size = New Global.System.Drawing.Size(66, 18)
			Me.chkbPlot.TabIndex = 2
			Me.chkbPlot.Text = "Plot"
			Me.chkbNoPermDeath.Location = New Global.System.Drawing.Point(30, 54)
			Me.chkbNoPermDeath.Name = "chkbNoPermDeath"
			Me.chkbNoPermDeath.Size = New Global.System.Drawing.Size(132, 18)
			Me.chkbNoPermDeath.TabIndex = 1
			Me.chkbNoPermDeath.Text = "No Permanent Death"
			Me.Label52.Location = New Global.System.Drawing.Point(30, 210)
			Me.Label52.Name = "Label52"
			Me.Label52.Size = New Global.System.Drawing.Size(100, 18)
			Me.Label52.TabIndex = 1
			Me.Label52.Text = "Deity"
			Me.Label52.Visible = False
			Me.tbDeity.Location = New Global.System.Drawing.Point(144, 210)
			Me.tbDeity.Name = "tbDeity"
			Me.tbDeity.Size = New Global.System.Drawing.Size(144, 20)
			Me.tbDeity.TabIndex = 9
			Me.tbDeity.Text = ""
			Me.tbDeity.Visible = False
			Me.chkbIsPC.Location = New Global.System.Drawing.Point(30, 102)
			Me.chkbIsPC.Name = "chkbIsPC"
			Me.chkbIsPC.Size = New Global.System.Drawing.Size(60, 18)
			Me.chkbIsPC.TabIndex = 3
			Me.chkbIsPC.Text = "Is PC"
			Me.cmbxSubrace.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxSubrace.Location = New Global.System.Drawing.Point(144, 192)
			Me.cmbxSubrace.Name = "cmbxSubrace"
			Me.cmbxSubrace.Size = New Global.System.Drawing.Size(144, 21)
			Me.cmbxSubrace.TabIndex = 8
			Me.chkbIsHologram.Location = New Global.System.Drawing.Point(174, 78)
			Me.chkbIsHologram.Name = "chkbIsHologram"
			Me.chkbIsHologram.Size = New Global.System.Drawing.Size(104, 18)
			Me.chkbIsHologram.TabIndex = 5
			Me.chkbIsHologram.Text = "Is Hologram"
			Me.chkbIsHologram.Visible = False
			Me.chkbNotReorienting.Location = New Global.System.Drawing.Point(174, 30)
			Me.chkbNotReorienting.Name = "chkbNotReorienting"
			Me.chkbNotReorienting.Size = New Global.System.Drawing.Size(144, 18)
			Me.chkbNotReorienting.TabIndex = 3
			Me.chkbNotReorienting.Text = "Doesn't Reorient on PC"
			Me.chkbNotReorienting.Visible = False
			Me.chkbIgnoreCrePath.Location = New Global.System.Drawing.Point(174, 54)
			Me.chkbIgnoreCrePath.Name = "chkbIgnoreCrePath"
			Me.chkbIgnoreCrePath.Size = New Global.System.Drawing.Size(114, 18)
			Me.chkbIgnoreCrePath.TabIndex = 4
			Me.chkbIgnoreCrePath.Text = "Doesn't Block PC"
			Me.chkbIgnoreCrePath.Visible = False
			Me.lblMultiplierSet.Location = New Global.System.Drawing.Point(204, 156)
			Me.lblMultiplierSet.Name = "lblMultiplierSet"
			Me.lblMultiplierSet.Size = New Global.System.Drawing.Size(100, 18)
			Me.lblMultiplierSet.TabIndex = 1
			Me.lblMultiplierSet.Text = "Multiplier Set"
			Me.lblMultiplierSet.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblMultiplierSet.Visible = False
			Me.lblBlindSpot.Location = New Global.System.Drawing.Point(30, 156)
			Me.lblBlindSpot.Name = "lblBlindSpot"
			Me.lblBlindSpot.Size = New Global.System.Drawing.Size(100, 18)
			Me.lblBlindSpot.TabIndex = 1
			Me.lblBlindSpot.Text = "Blind Spot"
			Me.lblBlindSpot.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblBlindSpot.Visible = False
			Me.nudBlindSpot.DecimalPlaces = 1
			Me.nudBlindSpot.Location = New Global.System.Drawing.Point(144, 156)
			Me.nudBlindSpot.Maximum = New Decimal(New Integer() { 3599, 0, 0, 65536 })
			Me.nudBlindSpot.Name = "nudBlindSpot"
			Me.nudBlindSpot.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudBlindSpot.TabIndex = 6
			Me.nudBlindSpot.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.nudBlindSpot.Visible = False
			Me.chkbMin1HP.Location = New Global.System.Drawing.Point(30, 126)
			Me.chkbMin1HP.Name = "chkbMin1HP"
			Me.chkbMin1HP.Size = New Global.System.Drawing.Size(108, 18)
			Me.chkbMin1HP.TabIndex = 3
			Me.chkbMin1HP.Text = "Minimum 1 HP"
			Me.GroupBox13.Controls.Add(Me.cmbxSoundSet)
			Me.GroupBox13.Location = New Global.System.Drawing.Point(210, 384)
			Me.GroupBox13.Name = "GroupBox13"
			Me.GroupBox13.Size = New Global.System.Drawing.Size(186, 48)
			Me.GroupBox13.TabIndex = 4
			Me.GroupBox13.TabStop = False
			Me.GroupBox13.Text = "Sound Set"
			Me.cmbxSoundSet.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxSoundSet.Location = New Global.System.Drawing.Point(24, 16)
			Me.cmbxSoundSet.Name = "cmbxSoundSet"
			Me.cmbxSoundSet.Size = New Global.System.Drawing.Size(144, 21)
			Me.cmbxSoundSet.TabIndex = 0
			Me.GroupBox14.Controls.Add(Me.cmbxPerceptionRange)
			Me.GroupBox14.Location = New Global.System.Drawing.Point(210, 438)
			Me.GroupBox14.Name = "GroupBox14"
			Me.GroupBox14.Size = New Global.System.Drawing.Size(186, 48)
			Me.GroupBox14.TabIndex = 5
			Me.GroupBox14.TabStop = False
			Me.GroupBox14.Text = "Perception Range"
			Me.cmbxPerceptionRange.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxPerceptionRange.Items.AddRange(New Object() { "Short", "Medium", "Long", "Default", "Player", "Monster" })
			Me.cmbxPerceptionRange.Location = New Global.System.Drawing.Point(24, 16)
			Me.cmbxPerceptionRange.Name = "cmbxPerceptionRange"
			Me.cmbxPerceptionRange.Size = New Global.System.Drawing.Size(144, 21)
			Me.cmbxPerceptionRange.TabIndex = 0
			Me.GroupBox15.Controls.Add(Me.cmbxFaction)
			Me.GroupBox15.Location = New Global.System.Drawing.Point(12, 438)
			Me.GroupBox15.Name = "GroupBox15"
			Me.GroupBox15.Size = New Global.System.Drawing.Size(186, 48)
			Me.GroupBox15.TabIndex = 1
			Me.GroupBox15.TabStop = False
			Me.GroupBox15.Text = "Faction"
			Me.cmbxFaction.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxFaction.Location = New Global.System.Drawing.Point(24, 16)
			Me.cmbxFaction.Name = "cmbxFaction"
			Me.cmbxFaction.Size = New Global.System.Drawing.Size(144, 21)
			Me.cmbxFaction.TabIndex = 1
			Me.GroupBox18.Controls.Add(Me.tbTemplateResRef)
			Me.GroupBox18.Controls.Add(Me.Label56)
			Me.GroupBox18.Controls.Add(Me.Label57)
			Me.GroupBox18.Controls.Add(Me.cmbxTreasureModel)
			Me.GroupBox18.Location = New Global.System.Drawing.Point(12, 12)
			Me.GroupBox18.Name = "GroupBox18"
			Me.GroupBox18.Size = New Global.System.Drawing.Size(384, 90)
			Me.GroupBox18.TabIndex = 0
			Me.GroupBox18.TabStop = False
			Me.GroupBox18.Text = "Info"
			Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
			Me.tbTemplateResRef.Location = New Global.System.Drawing.Point(144, 24)
			Me.tbTemplateResRef.MaxLength = 16
			Me.tbTemplateResRef.Name = "tbTemplateResRef"
			Me.tbTemplateResRef.Size = New Global.System.Drawing.Size(176, 20)
			Me.tbTemplateResRef.TabIndex = 2
			Me.tbTemplateResRef.Text = ""
			Me.Label56.Location = New Global.System.Drawing.Point(24, 57)
			Me.Label56.Name = "Label56"
			Me.Label56.Size = New Global.System.Drawing.Size(100, 18)
			Me.Label56.TabIndex = 1
			Me.Label56.Text = "Treasure Model"
			Me.Label56.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label56.Visible = False
			Me.Label57.Location = New Global.System.Drawing.Point(24, 25)
			Me.Label57.Name = "Label57"
			Me.Label57.Size = New Global.System.Drawing.Size(100, 18)
			Me.Label57.TabIndex = 1
			Me.Label57.Text = "Template ResRef"
			Me.Label57.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbxTreasureModel.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxTreasureModel.Items.AddRange(New Object() { "Short", "Medium", "Long", "Default", "Player", "Monster" })
			Me.cmbxTreasureModel.Location = New Global.System.Drawing.Point(144, 56)
			Me.cmbxTreasureModel.Name = "cmbxTreasureModel"
			Me.cmbxTreasureModel.Size = New Global.System.Drawing.Size(176, 21)
			Me.cmbxTreasureModel.TabIndex = 0
			Me.cmbxTreasureModel.Visible = False
			Me.tpFeats.Controls.Add(Me.GroupBox10)
			Me.tpFeats.Controls.Add(Me.chklbFeats)
			Me.tpFeats.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpFeats.Name = "tpFeats"
			Me.tpFeats.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpFeats.TabIndex = 7
			Me.tpFeats.Text = "Feats"
			Me.GroupBox10.Controls.Add(Me.tbFeatSummary)
			Me.GroupBox10.Location = New Global.System.Drawing.Point(6, 354)
			Me.GroupBox10.Name = "GroupBox10"
			Me.GroupBox10.Size = New Global.System.Drawing.Size(396, 132)
			Me.GroupBox10.TabIndex = 2
			Me.GroupBox10.TabStop = False
			Me.GroupBox10.Text = "Feats Selection Summary"
			Me.tbFeatSummary.Location = New Global.System.Drawing.Point(18, 24)
			Me.tbFeatSummary.Multiline = True
			Me.tbFeatSummary.Name = "tbFeatSummary"
			Me.tbFeatSummary.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.tbFeatSummary.Size = New Global.System.Drawing.Size(360, 96)
			Me.tbFeatSummary.TabIndex = 1
			Me.tbFeatSummary.Text = ""
			Me.tbFeatSummary.WordWrap = False
			Me.chklbFeats.Location = New Global.System.Drawing.Point(72, 36)
			Me.chklbFeats.Name = "chklbFeats"
			Me.chklbFeats.Size = New Global.System.Drawing.Size(264, 289)
			Me.chklbFeats.TabIndex = 0
			Me.chklbFeats.ThreeDCheckBoxes = True
			Me.toForcePowers.Controls.Add(Me.GroupBox19)
			Me.toForcePowers.Controls.Add(Me.GroupBox17)
			Me.toForcePowers.Controls.Add(Me.GroupBox16)
			Me.toForcePowers.Location = New Global.System.Drawing.Point(4, 40)
			Me.toForcePowers.Name = "toForcePowers"
			Me.toForcePowers.Size = New Global.System.Drawing.Size(408, 492)
			Me.toForcePowers.TabIndex = 8
			Me.toForcePowers.Text = "Force Powers"
			Me.GroupBox19.Controls.Add(Me.tbForcePowerSummary)
			Me.GroupBox19.Location = New Global.System.Drawing.Point(6, 366)
			Me.GroupBox19.Name = "GroupBox19"
			Me.GroupBox19.Size = New Global.System.Drawing.Size(396, 120)
			Me.GroupBox19.TabIndex = 3
			Me.GroupBox19.TabStop = False
			Me.GroupBox19.Text = "Force Power Selection Summary"
			Me.tbForcePowerSummary.Location = New Global.System.Drawing.Point(18, 16)
			Me.tbForcePowerSummary.Multiline = True
			Me.tbForcePowerSummary.Name = "tbForcePowerSummary"
			Me.tbForcePowerSummary.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.tbForcePowerSummary.Size = New Global.System.Drawing.Size(360, 96)
			Me.tbForcePowerSummary.TabIndex = 1
			Me.tbForcePowerSummary.Text = ""
			Me.tbForcePowerSummary.WordWrap = False
			Me.GroupBox17.Controls.Add(Me.chklbForcePowers)
			Me.GroupBox17.Controls.Add(Me.btnSelectAllPowers)
			Me.GroupBox17.Controls.Add(Me.btnClearAllPowers)
			Me.GroupBox17.Location = New Global.System.Drawing.Point(6, 72)
			Me.GroupBox17.Name = "GroupBox17"
			Me.GroupBox17.Size = New Global.System.Drawing.Size(396, 288)
			Me.GroupBox17.TabIndex = 1
			Me.GroupBox17.TabStop = False
			Me.GroupBox17.Text = "Force Powers"
			Me.chklbForcePowers.Location = New Global.System.Drawing.Point(66, 18)
			Me.chklbForcePowers.Name = "chklbForcePowers"
			Me.chklbForcePowers.Size = New Global.System.Drawing.Size(264, 229)
			Me.chklbForcePowers.TabIndex = 0
			Me.chklbForcePowers.ThreeDCheckBoxes = True
			Me.btnSelectAllPowers.Location = New Global.System.Drawing.Point(84, 258)
			Me.btnSelectAllPowers.Name = "btnSelectAllPowers"
			Me.btnSelectAllPowers.Size = New Global.System.Drawing.Size(102, 24)
			Me.btnSelectAllPowers.TabIndex = 1
			Me.btnSelectAllPowers.Text = "Select All Powers"
			Me.btnClearAllPowers.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.btnClearAllPowers.Location = New Global.System.Drawing.Point(216, 258)
			Me.btnClearAllPowers.Name = "btnClearAllPowers"
			Me.btnClearAllPowers.Size = New Global.System.Drawing.Size(96, 24)
			Me.btnClearAllPowers.TabIndex = 2
			Me.btnClearAllPowers.Text = "Clear All Powers"
			Me.GroupBox16.Controls.Add(Me.nudForcePoints)
			Me.GroupBox16.Controls.Add(Me.Label54)
			Me.GroupBox16.Controls.Add(Me.Label55)
			Me.GroupBox16.Controls.Add(Me.nudCurrentForce)
			Me.GroupBox16.Location = New Global.System.Drawing.Point(6, 6)
			Me.GroupBox16.Name = "GroupBox16"
			Me.GroupBox16.Size = New Global.System.Drawing.Size(396, 60)
			Me.GroupBox16.TabIndex = 0
			Me.GroupBox16.TabStop = False
			Me.GroupBox16.Text = "Force Points"
			Me.nudForcePoints.Location = New Global.System.Drawing.Point(120, 25)
			Me.nudForcePoints.Maximum = New Decimal(New Integer() { 9999, 0, 0, 0 })
			Me.nudForcePoints.Name = "nudForcePoints"
			Me.nudForcePoints.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudForcePoints.TabIndex = 0
			Me.nudForcePoints.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.Label54.Location = New Global.System.Drawing.Point(18, 26)
			Me.Label54.Name = "Label54"
			Me.Label54.Size = New Global.System.Drawing.Size(96, 18)
			Me.Label54.TabIndex = 0
			Me.Label54.Text = "Max Force Points"
			Me.Label54.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label55.Location = New Global.System.Drawing.Point(204, 26)
			Me.Label55.Name = "Label55"
			Me.Label55.Size = New Global.System.Drawing.Size(108, 18)
			Me.Label55.TabIndex = 0
			Me.Label55.Text = "Current Force Points"
			Me.Label55.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudCurrentForce.Location = New Global.System.Drawing.Point(312, 25)
			Me.nudCurrentForce.Maximum = New Decimal(New Integer() { 9999, 0, 0, 0 })
			Me.nudCurrentForce.Name = "nudCurrentForce"
			Me.nudCurrentForce.Size = New Global.System.Drawing.Size(48, 20)
			Me.nudCurrentForce.TabIndex = 1
			Me.nudCurrentForce.Value = New Decimal(New Integer() { 100, 0, 0, 0 })
			Me.tpClasses.Controls.Add(Me.GroupBox9)
			Me.tpClasses.Controls.Add(Me.GroupBox8)
			Me.tpClasses.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpClasses.Name = "tpClasses"
			Me.tpClasses.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpClasses.TabIndex = 3
			Me.tpClasses.Text = "Class"
			Me.GroupBox9.Controls.Add(Me.Label46)
			Me.GroupBox9.Controls.Add(Me.nudClassLevel)
			Me.GroupBox9.Controls.Add(Me.cmbxClass)
			Me.GroupBox9.Controls.Add(Me.Label23)
			Me.GroupBox9.Location = New Global.System.Drawing.Point(6, 114)
			Me.GroupBox9.Name = "GroupBox9"
			Me.GroupBox9.Size = New Global.System.Drawing.Size(396, 108)
			Me.GroupBox9.TabIndex = 7
			Me.GroupBox9.TabStop = False
			Me.GroupBox9.Text = "Classes"
			Me.Label46.Location = New Global.System.Drawing.Point(18, 66)
			Me.Label46.Name = "Label46"
			Me.Label46.Size = New Global.System.Drawing.Size(42, 16)
			Me.Label46.TabIndex = 3
			Me.Label46.Text = "Level"
			Me.Label46.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.nudClassLevel.Location = New Global.System.Drawing.Point(78, 66)
			Me.nudClassLevel.Maximum = New Decimal(New Integer() { 250, 0, 0, 0 })
			Me.nudClassLevel.Name = "nudClassLevel"
			Me.nudClassLevel.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudClassLevel.TabIndex = 1
			Me.cmbxClass.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbxClass.Location = New Global.System.Drawing.Point(60, 30)
			Me.cmbxClass.Name = "cmbxClass"
			Me.cmbxClass.Size = New Global.System.Drawing.Size(184, 21)
			Me.cmbxClass.TabIndex = 0
			Me.Label23.Location = New Global.System.Drawing.Point(18, 30)
			Me.Label23.Name = "Label23"
			Me.Label23.Size = New Global.System.Drawing.Size(42, 16)
			Me.Label23.TabIndex = 3
			Me.Label23.Text = "Class"
			Me.Label23.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.GroupBox8.Controls.Add(Me.nudAlignment)
			Me.GroupBox8.Controls.Add(Me.Label47)
			Me.GroupBox8.Controls.Add(Me.trkbarAlignment)
			Me.GroupBox8.Controls.Add(Me.Label48)
			Me.GroupBox8.Location = New Global.System.Drawing.Point(6, 6)
			Me.GroupBox8.Name = "GroupBox8"
			Me.GroupBox8.Size = New Global.System.Drawing.Size(396, 102)
			Me.GroupBox8.TabIndex = 6
			Me.GroupBox8.TabStop = False
			Me.GroupBox8.Text = "Alignment"
			Me.nudAlignment.Location = New Global.System.Drawing.Point(186, 72)
			Me.nudAlignment.Name = "nudAlignment"
			Me.nudAlignment.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.nudAlignment.Size = New Global.System.Drawing.Size(42, 20)
			Me.nudAlignment.TabIndex = 1
			Me.nudAlignment.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Label47.Location = New Global.System.Drawing.Point(12, 36)
			Me.Label47.Name = "Label47"
			Me.Label47.Size = New Global.System.Drawing.Size(36, 18)
			Me.Label47.TabIndex = 1
			Me.Label47.Text = "Evil"
			Me.trkbarAlignment.Location = New Global.System.Drawing.Point(66, 24)
			Me.trkbarAlignment.Maximum = 100
			Me.trkbarAlignment.Name = "trkbarAlignment"
			Me.trkbarAlignment.Size = New Global.System.Drawing.Size(276, 42)
			Me.trkbarAlignment.TabIndex = 0
			Me.trkbarAlignment.TickFrequency = 5
			Me.Label48.Location = New Global.System.Drawing.Point(348, 36)
			Me.Label48.Name = "Label48"
			Me.Label48.Size = New Global.System.Drawing.Size(36, 18)
			Me.Label48.TabIndex = 1
			Me.Label48.Text = "Good"
			Me.tpSpecialAbilities.Controls.Add(Me.GroupBox20)
			Me.tpSpecialAbilities.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpSpecialAbilities.Name = "tpSpecialAbilities"
			Me.tpSpecialAbilities.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpSpecialAbilities.TabIndex = 9
			Me.tpSpecialAbilities.Text = "Special Abilities"
			Me.GroupBox20.Controls.Add(Me.chklbSpecialAbilities)
			Me.GroupBox20.Location = New Global.System.Drawing.Point(6, 6)
			Me.GroupBox20.Name = "GroupBox20"
			Me.GroupBox20.Size = New Global.System.Drawing.Size(396, 306)
			Me.GroupBox20.TabIndex = 3
			Me.GroupBox20.TabStop = False
			Me.GroupBox20.Text = "Special Abilities"
			Me.chklbSpecialAbilities.Location = New Global.System.Drawing.Point(66, 12)
			Me.chklbSpecialAbilities.Name = "chklbSpecialAbilities"
			Me.chklbSpecialAbilities.Size = New Global.System.Drawing.Size(264, 274)
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
			Me.tpScripts.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpScripts.Name = "tpScripts"
			Me.tpScripts.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpScripts.TabIndex = 5
			Me.tpScripts.Text = "Scripts"
			Me.btnEditOnEndDialogu.Location = New Global.System.Drawing.Point(342, 252)
			Me.btnEditOnEndDialogu.Name = "btnEditOnEndDialogu"
			Me.btnEditOnEndDialogu.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnEndDialogu.TabIndex = 15
			Me.btnEditOnEndDialogu.Text = "Edit"
			Me.btnEditOnEndDialogu.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnDialogue.Location = New Global.System.Drawing.Point(342, 282)
			Me.btnEditOnDialogue.Name = "btnEditOnDialogue"
			Me.btnEditOnDialogue.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnDialogue.TabIndex = 17
			Me.btnEditOnDialogue.Text = "Edit"
			Me.btnEditOnDialogue.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnUserDefine.Location = New Global.System.Drawing.Point(342, 432)
			Me.btnEditOnUserDefine.Name = "btnEditOnUserDefine"
			Me.btnEditOnUserDefine.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnUserDefine.TabIndex = 27
			Me.btnEditOnUserDefine.Text = "Edit"
			Me.btnEditOnUserDefine.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnHeartbeat.Location = New Global.System.Drawing.Point(342, 42)
			Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
			Me.btnEditOnHeartbeat.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnHeartbeat.TabIndex = 1
			Me.btnEditOnHeartbeat.Text = "Edit"
			Me.btnEditOnHeartbeat.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnDisturbed.Location = New Global.System.Drawing.Point(342, 192)
			Me.btnEditOnDisturbed.Name = "btnEditOnDisturbed"
			Me.btnEditOnDisturbed.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnDisturbed.TabIndex = 11
			Me.btnEditOnDisturbed.Text = "Edit"
			Me.btnEditOnDisturbed.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnDamaged.Location = New Global.System.Drawing.Point(342, 162)
			Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
			Me.btnEditOnDamaged.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnDamaged.TabIndex = 9
			Me.btnEditOnDamaged.Text = "Edit"
			Me.btnEditOnDamaged.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnAttacked.Location = New Global.System.Drawing.Point(342, 132)
			Me.btnEditOnAttacked.Name = "btnEditOnAttacked"
			Me.btnEditOnAttacked.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnAttacked.TabIndex = 7
			Me.btnEditOnAttacked.Text = "Edit"
			Me.btnEditOnAttacked.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label34.Location = New Global.System.Drawing.Point(30, 102)
			Me.Label34.Name = "Label34"
			Me.Label34.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label34.TabIndex = 5
			Me.Label34.Text = "OnSpellAt"
			Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnSpellAt.Location = New Global.System.Drawing.Point(114, 102)
			Me.tbOnSpellAt.Name = "tbOnSpellAt"
			Me.tbOnSpellAt.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnSpellAt.TabIndex = 4
			Me.tbOnSpellAt.Text = ""
			Me.Label33.Location = New Global.System.Drawing.Point(30, 72)
			Me.Label33.Name = "Label33"
			Me.Label33.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label33.TabIndex = 3
			Me.Label33.Text = "OnNotice"
			Me.Label33.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnNotice.Location = New Global.System.Drawing.Point(114, 72)
			Me.tbOnNotice.Name = "tbOnNotice"
			Me.tbOnNotice.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnNotice.TabIndex = 2
			Me.tbOnNotice.Text = ""
			Me.Label32.Location = New Global.System.Drawing.Point(30, 42)
			Me.Label32.Name = "Label32"
			Me.Label32.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label32.TabIndex = 1
			Me.Label32.Text = "OnHeartbeat"
			Me.Label32.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnHeartbeat.Location = New Global.System.Drawing.Point(114, 42)
			Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
			Me.tbOnHeartbeat.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnHeartbeat.TabIndex = 0
			Me.tbOnHeartbeat.Text = ""
			Me.Label35.Location = New Global.System.Drawing.Point(30, 132)
			Me.Label35.Name = "Label35"
			Me.Label35.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label35.TabIndex = 5
			Me.Label35.Text = "OnAttacked"
			Me.Label35.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnAttacked.Location = New Global.System.Drawing.Point(114, 132)
			Me.tbOnAttacked.Name = "tbOnAttacked"
			Me.tbOnAttacked.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnAttacked.TabIndex = 6
			Me.tbOnAttacked.Text = ""
			Me.tbOnDamaged.Location = New Global.System.Drawing.Point(114, 162)
			Me.tbOnDamaged.Name = "tbOnDamaged"
			Me.tbOnDamaged.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnDamaged.TabIndex = 8
			Me.tbOnDamaged.Text = ""
			Me.Label36.Location = New Global.System.Drawing.Point(30, 162)
			Me.Label36.Name = "Label36"
			Me.Label36.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label36.TabIndex = 5
			Me.Label36.Text = "OnDamaged"
			Me.Label36.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label37.Location = New Global.System.Drawing.Point(30, 192)
			Me.Label37.Name = "Label37"
			Me.Label37.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label37.TabIndex = 5
			Me.Label37.Text = "OnDisturbed"
			Me.Label37.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnDisturbed.Location = New Global.System.Drawing.Point(114, 192)
			Me.tbOnDisturbed.Name = "tbOnDisturbed"
			Me.tbOnDisturbed.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnDisturbed.TabIndex = 10
			Me.tbOnDisturbed.Text = ""
			Me.tbOnEndRound.Location = New Global.System.Drawing.Point(114, 222)
			Me.tbOnEndRound.Name = "tbOnEndRound"
			Me.tbOnEndRound.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnEndRound.TabIndex = 12
			Me.tbOnEndRound.Text = ""
			Me.Label38.Location = New Global.System.Drawing.Point(30, 222)
			Me.Label38.Name = "Label38"
			Me.Label38.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label38.TabIndex = 5
			Me.Label38.Text = "OnEndRound"
			Me.Label38.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnEndDialogu.Location = New Global.System.Drawing.Point(114, 252)
			Me.tbOnEndDialogu.Name = "tbOnEndDialogu"
			Me.tbOnEndDialogu.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnEndDialogu.TabIndex = 14
			Me.tbOnEndDialogu.Text = ""
			Me.Label39.Location = New Global.System.Drawing.Point(30, 252)
			Me.Label39.Name = "Label39"
			Me.Label39.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label39.TabIndex = 5
			Me.Label39.Text = "OnEndDialogu"
			Me.Label39.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label40.Location = New Global.System.Drawing.Point(30, 282)
			Me.Label40.Name = "Label40"
			Me.Label40.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label40.TabIndex = 5
			Me.Label40.Text = "OnDialogue"
			Me.Label40.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnDialogue.Location = New Global.System.Drawing.Point(114, 282)
			Me.tbOnDialogue.Name = "tbOnDialogue"
			Me.tbOnDialogue.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnDialogue.TabIndex = 16
			Me.tbOnDialogue.Text = ""
			Me.Label41.Location = New Global.System.Drawing.Point(30, 312)
			Me.Label41.Name = "Label41"
			Me.Label41.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label41.TabIndex = 5
			Me.Label41.Text = "OnSpawn"
			Me.Label41.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnSpawn.Location = New Global.System.Drawing.Point(114, 312)
			Me.tbOnSpawn.Name = "tbOnSpawn"
			Me.tbOnSpawn.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnSpawn.TabIndex = 18
			Me.tbOnSpawn.Text = ""
			Me.tbOnRested.Location = New Global.System.Drawing.Point(114, 342)
			Me.tbOnRested.Name = "tbOnRested"
			Me.tbOnRested.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnRested.TabIndex = 20
			Me.tbOnRested.Text = ""
			Me.Label42.Location = New Global.System.Drawing.Point(30, 342)
			Me.Label42.Name = "Label42"
			Me.Label42.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label42.TabIndex = 5
			Me.Label42.Text = "OnRested"
			Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnDeath.Location = New Global.System.Drawing.Point(114, 372)
			Me.tbOnDeath.Name = "tbOnDeath"
			Me.tbOnDeath.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnDeath.TabIndex = 22
			Me.tbOnDeath.Text = ""
			Me.Label43.Location = New Global.System.Drawing.Point(30, 372)
			Me.Label43.Name = "Label43"
			Me.Label43.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label43.TabIndex = 5
			Me.Label43.Text = "OnDeath"
			Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label44.Location = New Global.System.Drawing.Point(30, 402)
			Me.Label44.Name = "Label44"
			Me.Label44.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label44.TabIndex = 5
			Me.Label44.Text = "OnBlocked"
			Me.Label44.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbOnBlocked.Location = New Global.System.Drawing.Point(114, 402)
			Me.tbOnBlocked.Name = "tbOnBlocked"
			Me.tbOnBlocked.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnBlocked.TabIndex = 24
			Me.tbOnBlocked.Text = ""
			Me.tbOnUserDefine.Location = New Global.System.Drawing.Point(114, 432)
			Me.tbOnUserDefine.Name = "tbOnUserDefine"
			Me.tbOnUserDefine.Size = New Global.System.Drawing.Size(204, 20)
			Me.tbOnUserDefine.TabIndex = 26
			Me.tbOnUserDefine.Text = ""
			Me.Label45.Location = New Global.System.Drawing.Point(30, 432)
			Me.Label45.Name = "Label45"
			Me.Label45.Size = New Global.System.Drawing.Size(84, 18)
			Me.Label45.TabIndex = 5
			Me.Label45.Text = "OnUserDefine"
			Me.Label45.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnNotice.Location = New Global.System.Drawing.Point(342, 72)
			Me.btnEditOnNotice.Name = "btnEditOnNotice"
			Me.btnEditOnNotice.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnNotice.TabIndex = 3
			Me.btnEditOnNotice.Text = "Edit"
			Me.btnEditOnNotice.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnSpellAt.Location = New Global.System.Drawing.Point(342, 102)
			Me.btnEditOnSpellAt.Name = "btnEditOnSpellAt"
			Me.btnEditOnSpellAt.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnSpellAt.TabIndex = 5
			Me.btnEditOnSpellAt.Text = "Edit"
			Me.btnEditOnSpellAt.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnSpawn.Location = New Global.System.Drawing.Point(342, 312)
			Me.btnEditOnSpawn.Name = "btnEditOnSpawn"
			Me.btnEditOnSpawn.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnSpawn.TabIndex = 19
			Me.btnEditOnSpawn.Text = "Edit"
			Me.btnEditOnSpawn.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnDeath.Location = New Global.System.Drawing.Point(342, 372)
			Me.btnEditOnDeath.Name = "btnEditOnDeath"
			Me.btnEditOnDeath.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnDeath.TabIndex = 23
			Me.btnEditOnDeath.Text = "Edit"
			Me.btnEditOnDeath.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnBlocked.Location = New Global.System.Drawing.Point(342, 402)
			Me.btnEditOnBlocked.Name = "btnEditOnBlocked"
			Me.btnEditOnBlocked.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnBlocked.TabIndex = 25
			Me.btnEditOnBlocked.Text = "Edit"
			Me.btnEditOnBlocked.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnRested.Location = New Global.System.Drawing.Point(342, 342)
			Me.btnEditOnRested.Name = "btnEditOnRested"
			Me.btnEditOnRested.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnRested.TabIndex = 21
			Me.btnEditOnRested.Text = "Edit"
			Me.btnEditOnRested.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnEditOnEndRound.Location = New Global.System.Drawing.Point(342, 222)
			Me.btnEditOnEndRound.Name = "btnEditOnEndRound"
			Me.btnEditOnEndRound.Size = New Global.System.Drawing.Size(32, 23)
			Me.btnEditOnEndRound.TabIndex = 13
			Me.btnEditOnEndRound.Text = "Edit"
			Me.btnEditOnEndRound.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tpComments.Controls.Add(Me.tbComments)
			Me.tpComments.Location = New Global.System.Drawing.Point(4, 40)
			Me.tpComments.Name = "tpComments"
			Me.tpComments.Size = New Global.System.Drawing.Size(408, 492)
			Me.tpComments.TabIndex = 10
			Me.tpComments.Text = "Comments"
			Me.tbComments.Location = New Global.System.Drawing.Point(24, 18)
			Me.tbComments.Multiline = True
			Me.tbComments.Name = "tbComments"
			Me.tbComments.Size = New Global.System.Drawing.Size(354, 456)
			Me.tbComments.TabIndex = 0
			Me.tbComments.Text = ""
			Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New Global.System.Drawing.Point(328, 579)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnCancel.TabIndex = 1
			Me.btnCancel.Text = "&Cancel"
			Me.btnWriteFile.Location = New Global.System.Drawing.Point(240, 579)
			Me.btnWriteFile.Name = "btnWriteFile"
			Me.btnWriteFile.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnWriteFile.TabIndex = 1
			Me.btnWriteFile.Text = "&Save"
			Me.btnInventory.Location = New Global.System.Drawing.Point(64, 579)
			Me.btnInventory.Name = "btnInventory"
			Me.btnInventory.Size = New Global.System.Drawing.Size(72, 24)
			Me.btnInventory.TabIndex = 1
			Me.btnInventory.Text = "&Inventory"
			Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.btnDebug.Location = New Global.System.Drawing.Point(0, 0)
			Me.btnDebug.Name = "btnDebug"
			Me.btnDebug.Size = New Global.System.Drawing.Size(8, 8)
			Me.btnDebug.TabIndex = 2
			Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Global.System.Drawing.Size(432, 613)
			Me.Controls.Add(Me.btnDebug)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.tabCtrl1)
			Me.Controls.Add(Me.btnWriteFile)
			Me.Controls.Add(Me.btnInventory)
			Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximumSize = New Global.System.Drawing.Size(440, 640)
			Me.MinimumSize = New Global.System.Drawing.Size(440, 640)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.trkbarAlignment.Scroll, AddressOf Me.trkbarAlignment_Scroll
            AddHandler Me.nudAlignment.ValueChanged, AddressOf Me.nudAlignment_ValueChanged
            AddHandler Me.chklbFeats.MouseMove, AddressOf Me.chklbFeats_MouseMove
            AddHandler Me.chklbForcePowers.MouseMove, AddressOf Me.chklbForcePowers_MouseMove
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.btnWriteFile.Click, AddressOf Me.btnWriteFile_Click
            AddHandler Me.btnClearAllPowers.Click, AddressOf Me.btnClearAllPowers_Click
            AddHandler Me.btnSelectAllPowers.Click, AddressOf Me.btnSelectAllPowers_Click
            AddHandler Me.btnInventory.Click, AddressOf Me.btnInventory_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.btnEditOnEndDialogu.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDialogue.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnUserDefine.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnHeartbeat.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDisturbed.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDamaged.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnAttacked.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnNotice.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnSpellAt.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnSpawn.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnDeath.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnBlocked.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnRested.Click, AddressOf Me.btnEditScript_Click
            AddHandler Me.btnEditOnEndRound.Click, AddressOf Me.btnEditScript_Click
			Me.ResumeLayout(False)
		End Sub

	End Class
End Namespace
