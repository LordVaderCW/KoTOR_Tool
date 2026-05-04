Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmUTC_Editor
        Inherits Global.kotor_tool.frmParent

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel

        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderRule As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterRule As Global.System.Windows.Forms.Label

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
        Friend WithEvents GroupBox4 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox5 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox6 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox7 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox8 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox9 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox10 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox11 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox12 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox13 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox14 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox15 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox16 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox17 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox18 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox19 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox20 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents gb2 As Global.System.Windows.Forms.GroupBox

        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents Label26 As Global.System.Windows.Forms.Label
        Friend WithEvents Label27 As Global.System.Windows.Forms.Label
        Friend WithEvents Label28 As Global.System.Windows.Forms.Label
        Friend WithEvents Label29 As Global.System.Windows.Forms.Label
        Friend WithEvents Label30 As Global.System.Windows.Forms.Label
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
        Friend WithEvents Label45 As Global.System.Windows.Forms.Label
        Friend WithEvents Label46 As Global.System.Windows.Forms.Label
        Friend WithEvents Label47 As Global.System.Windows.Forms.Label
        Friend WithEvents Label48 As Global.System.Windows.Forms.Label
        Friend WithEvents Label49 As Global.System.Windows.Forms.Label
        Friend WithEvents Label50 As Global.System.Windows.Forms.Label
        Friend WithEvents Label51 As Global.System.Windows.Forms.Label
        Friend WithEvents Label52 As Global.System.Windows.Forms.Label
        Friend WithEvents Label53 As Global.System.Windows.Forms.Label
        Friend WithEvents Label54 As Global.System.Windows.Forms.Label
        Friend WithEvents Label55 As Global.System.Windows.Forms.Label
        Friend WithEvents Label56 As Global.System.Windows.Forms.Label
        Friend WithEvents Label57 As Global.System.Windows.Forms.Label
        Friend WithEvents lblMultiplierSet As Global.System.Windows.Forms.Label
        Friend WithEvents lblBlindSpot As Global.System.Windows.Forms.Label

        Friend WithEvents tabCtrl1 As Global.kotor_tool.CustomTabControl

        Friend WithEvents tbConversation As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbFirstName As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbLastName As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbChallengeRating As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbDeity As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTemplateResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbFeatSummary As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbForcePowerSummary As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbComments As Global.System.Windows.Forms.TextBox

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

        Friend WithEvents cmbxRace As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxAppearance As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxGender As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxPhenotype As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxMovementRate As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxClass As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxPerceptionRange As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxTreasureModel As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxSoundSet As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxPortrait As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxSubrace As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxBodyBag As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxFaction As Global.System.Windows.Forms.ComboBox

        Friend WithEvents nudStrength As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudDexterity As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudConstitution As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudIntelligence As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudWisdom As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCharisma As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudBaseHP As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudNaturalAC As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudWillBonus As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFortBonus As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRefBonus As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudClassLevel As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudAlignment As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCurrentHP As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudMaxHP As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudForcePoints As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCurrentForce As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudMultiplierSet As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudBlindSpot As Global.System.Windows.Forms.NumericUpDown

        Friend WithEvents nudComputerUse As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudDemolitions As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudStealth As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudAwareness As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudPersuade As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudRepair As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudSecurity As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudTreatInjury As Global.System.Windows.Forms.NumericUpDown

        Friend WithEvents chkbNotInterruptable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbDisarmable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbPlot As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbNoPermDeath As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbIsHologram As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbNotReorienting As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbIgnoreCrePath As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbMin1HP As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbIsPC As Global.System.Windows.Forms.CheckBox

        Friend WithEvents trkbarAlignment As Global.System.Windows.Forms.TrackBar
        Friend WithEvents chklbFeats As Global.System.Windows.Forms.CheckedListBox
        Friend WithEvents chklbForcePowers As Global.System.Windows.Forms.CheckedListBox
        Friend WithEvents chklbSpecialAbilities As Global.System.Windows.Forms.CheckedListBox

        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnWriteFile As Global.System.Windows.Forms.Button
        Friend WithEvents btnClearAllPowers As Global.System.Windows.Forms.Button
        Friend WithEvents btnSelectAllPowers As Global.System.Windows.Forms.Button
        Friend WithEvents btnInventory As Global.System.Windows.Forms.Button
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button

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

        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUTC_Editor))
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.tabCtrl1 = New kotor_tool.CustomTabControl()
            Me.tpBasic = New System.Windows.Forms.TabPage()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.chkbNotInterruptable = New System.Windows.Forms.CheckBox()
            Me.tbConversation = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cmbxPortrait = New System.Windows.Forms.ComboBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbxRace = New System.Windows.Forms.ComboBox()
            Me.tbFirstName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.tbLastName = New System.Windows.Forms.TextBox()
            Me.tbTag = New System.Windows.Forms.TextBox()
            Me.tbDescription = New System.Windows.Forms.TextBox()
            Me.cmbxAppearance = New System.Windows.Forms.ComboBox()
            Me.cmbxPhenotype = New System.Windows.Forms.ComboBox()
            Me.cmbxGender = New System.Windows.Forms.ComboBox()
            Me.cmbxBodyBag = New System.Windows.Forms.ComboBox()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.tpStatistics = New System.Windows.Forms.TabPage()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.cmbxMovementRate = New System.Windows.Forms.ComboBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.gb2 = New System.Windows.Forms.GroupBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.nudWillBonus = New System.Windows.Forms.NumericUpDown()
            Me.nudFortBonus = New System.Windows.Forms.NumericUpDown()
            Me.nudRefBonus = New System.Windows.Forms.NumericUpDown()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.nudStrength = New System.Windows.Forms.NumericUpDown()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.nudDexterity = New System.Windows.Forms.NumericUpDown()
            Me.nudConstitution = New System.Windows.Forms.NumericUpDown()
            Me.nudIntelligence = New System.Windows.Forms.NumericUpDown()
            Me.nudWisdom = New System.Windows.Forms.NumericUpDown()
            Me.nudCharisma = New System.Windows.Forms.NumericUpDown()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.nudNaturalAC = New System.Windows.Forms.NumericUpDown()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.nudBaseHP = New System.Windows.Forms.NumericUpDown()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.nudCurrentHP = New System.Windows.Forms.NumericUpDown()
            Me.nudMaxHP = New System.Windows.Forms.NumericUpDown()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.tpSkills = New System.Windows.Forms.TabPage()
            Me.nudComputerUse = New System.Windows.Forms.NumericUpDown()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.nudDemolitions = New System.Windows.Forms.NumericUpDown()
            Me.nudStealth = New System.Windows.Forms.NumericUpDown()
            Me.nudAwareness = New System.Windows.Forms.NumericUpDown()
            Me.nudPersuade = New System.Windows.Forms.NumericUpDown()
            Me.nudRepair = New System.Windows.Forms.NumericUpDown()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.nudSecurity = New System.Windows.Forms.NumericUpDown()
            Me.nudTreatInjury = New System.Windows.Forms.NumericUpDown()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.tpAdvanced = New System.Windows.Forms.TabPage()
            Me.GroupBox12 = New System.Windows.Forms.GroupBox()
            Me.tbChallengeRating = New System.Windows.Forms.TextBox()
            Me.GroupBox11 = New System.Windows.Forms.GroupBox()
            Me.nudMultiplierSet = New System.Windows.Forms.NumericUpDown()
            Me.Label51 = New System.Windows.Forms.Label()
            Me.chkbDisarmable = New System.Windows.Forms.CheckBox()
            Me.chkbPlot = New System.Windows.Forms.CheckBox()
            Me.chkbNoPermDeath = New System.Windows.Forms.CheckBox()
            Me.Label52 = New System.Windows.Forms.Label()
            Me.tbDeity = New System.Windows.Forms.TextBox()
            Me.chkbIsPC = New System.Windows.Forms.CheckBox()
            Me.cmbxSubrace = New System.Windows.Forms.ComboBox()
            Me.chkbIsHologram = New System.Windows.Forms.CheckBox()
            Me.chkbNotReorienting = New System.Windows.Forms.CheckBox()
            Me.chkbIgnoreCrePath = New System.Windows.Forms.CheckBox()
            Me.lblMultiplierSet = New System.Windows.Forms.Label()
            Me.lblBlindSpot = New System.Windows.Forms.Label()
            Me.nudBlindSpot = New System.Windows.Forms.NumericUpDown()
            Me.chkbMin1HP = New System.Windows.Forms.CheckBox()
            Me.GroupBox13 = New System.Windows.Forms.GroupBox()
            Me.cmbxSoundSet = New System.Windows.Forms.ComboBox()
            Me.GroupBox14 = New System.Windows.Forms.GroupBox()
            Me.cmbxPerceptionRange = New System.Windows.Forms.ComboBox()
            Me.GroupBox15 = New System.Windows.Forms.GroupBox()
            Me.cmbxFaction = New System.Windows.Forms.ComboBox()
            Me.GroupBox18 = New System.Windows.Forms.GroupBox()
            Me.tbTemplateResRef = New System.Windows.Forms.TextBox()
            Me.Label56 = New System.Windows.Forms.Label()
            Me.Label57 = New System.Windows.Forms.Label()
            Me.cmbxTreasureModel = New System.Windows.Forms.ComboBox()
            Me.tpFeats = New System.Windows.Forms.TabPage()
            Me.GroupBox10 = New System.Windows.Forms.GroupBox()
            Me.tbFeatSummary = New System.Windows.Forms.TextBox()
            Me.chklbFeats = New System.Windows.Forms.CheckedListBox()
            Me.toForcePowers = New System.Windows.Forms.TabPage()
            Me.GroupBox19 = New System.Windows.Forms.GroupBox()
            Me.tbForcePowerSummary = New System.Windows.Forms.TextBox()
            Me.GroupBox17 = New System.Windows.Forms.GroupBox()
            Me.chklbForcePowers = New System.Windows.Forms.CheckedListBox()
            Me.btnSelectAllPowers = New System.Windows.Forms.Button()
            Me.btnClearAllPowers = New System.Windows.Forms.Button()
            Me.GroupBox16 = New System.Windows.Forms.GroupBox()
            Me.nudForcePoints = New System.Windows.Forms.NumericUpDown()
            Me.Label54 = New System.Windows.Forms.Label()
            Me.Label55 = New System.Windows.Forms.Label()
            Me.nudCurrentForce = New System.Windows.Forms.NumericUpDown()
            Me.tpClasses = New System.Windows.Forms.TabPage()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.nudClassLevel = New System.Windows.Forms.NumericUpDown()
            Me.cmbxClass = New System.Windows.Forms.ComboBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.nudAlignment = New System.Windows.Forms.NumericUpDown()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.trkbarAlignment = New System.Windows.Forms.TrackBar()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.tpSpecialAbilities = New System.Windows.Forms.TabPage()
            Me.GroupBox20 = New System.Windows.Forms.GroupBox()
            Me.chklbSpecialAbilities = New System.Windows.Forms.CheckedListBox()
            Me.tpScripts = New System.Windows.Forms.TabPage()
            Me.btnEditOnEndDialogu = New System.Windows.Forms.Button()
            Me.btnEditOnDialogue = New System.Windows.Forms.Button()
            Me.btnEditOnUserDefine = New System.Windows.Forms.Button()
            Me.btnEditOnHeartbeat = New System.Windows.Forms.Button()
            Me.btnEditOnDisturbed = New System.Windows.Forms.Button()
            Me.btnEditOnDamaged = New System.Windows.Forms.Button()
            Me.btnEditOnAttacked = New System.Windows.Forms.Button()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.tbOnSpellAt = New System.Windows.Forms.TextBox()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.tbOnNotice = New System.Windows.Forms.TextBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.tbOnHeartbeat = New System.Windows.Forms.TextBox()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.tbOnAttacked = New System.Windows.Forms.TextBox()
            Me.tbOnDamaged = New System.Windows.Forms.TextBox()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.tbOnDisturbed = New System.Windows.Forms.TextBox()
            Me.tbOnEndRound = New System.Windows.Forms.TextBox()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.tbOnEndDialogu = New System.Windows.Forms.TextBox()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.tbOnDialogue = New System.Windows.Forms.TextBox()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.tbOnSpawn = New System.Windows.Forms.TextBox()
            Me.tbOnRested = New System.Windows.Forms.TextBox()
            Me.Label42 = New System.Windows.Forms.Label()
            Me.tbOnDeath = New System.Windows.Forms.TextBox()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.tbOnBlocked = New System.Windows.Forms.TextBox()
            Me.tbOnUserDefine = New System.Windows.Forms.TextBox()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.btnEditOnNotice = New System.Windows.Forms.Button()
            Me.btnEditOnSpellAt = New System.Windows.Forms.Button()
            Me.btnEditOnSpawn = New System.Windows.Forms.Button()
            Me.btnEditOnDeath = New System.Windows.Forms.Button()
            Me.btnEditOnBlocked = New System.Windows.Forms.Button()
            Me.btnEditOnRested = New System.Windows.Forms.Button()
            Me.btnEditOnEndRound = New System.Windows.Forms.Button()
            Me.tpComments = New System.Windows.Forms.TabPage()
            Me.tbComments = New System.Windows.Forms.TextBox()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterRule = New System.Windows.Forms.Label()
            Me.btnInventory = New System.Windows.Forms.Button()
            Me.btnWriteFile = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderRule = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.tabCtrl1.SuspendLayout()
            Me.tpBasic.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.tpStatistics.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.gb2.SuspendLayout()
            CType(Me.nudWillBonus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFortBonus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRefBonus, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            CType(Me.nudStrength, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDexterity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudConstitution, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudIntelligence, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudWisdom, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCharisma, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox6.SuspendLayout()
            CType(Me.nudNaturalAC, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox5.SuspendLayout()
            CType(Me.nudBaseHP, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCurrentHP, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMaxHP, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpSkills.SuspendLayout()
            CType(Me.nudComputerUse, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDemolitions, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudStealth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudAwareness, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudPersuade, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRepair, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTreatInjury, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpAdvanced.SuspendLayout()
            Me.GroupBox12.SuspendLayout()
            Me.GroupBox11.SuspendLayout()
            CType(Me.nudMultiplierSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudBlindSpot, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.nudForcePoints, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCurrentForce, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpClasses.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            CType(Me.nudClassLevel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox8.SuspendLayout()
            CType(Me.nudAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbarAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpSpecialAbilities.SuspendLayout()
            Me.GroupBox20.SuspendLayout()
            Me.tpScripts.SuspendLayout()
            Me.tpComments.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(469, 813)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.tabCtrl1)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(12)
            Me.pnlBody.Size = New System.Drawing.Size(467, 675)
            Me.pnlBody.TabIndex = 1
            '
            'tabCtrl1
            '
            Me.tabCtrl1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.tabCtrl1.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
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
            Me.tabCtrl1.CustomBorderStyle = kotor_tool.CustomTabBorderStyle.Accent
            Me.tabCtrl1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tabCtrl1.DividerColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tabCtrl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabCtrl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabCtrl1.ItemSize = New System.Drawing.Size(112, 32)
            Me.tabCtrl1.Location = New System.Drawing.Point(12, 12)
            Me.tabCtrl1.Multiline = True
            Me.tabCtrl1.Name = "tabCtrl1"
            Me.tabCtrl1.NormalTabBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tabCtrl1.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.tabCtrl1.OuterNativeBorderBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.tabCtrl1.Padding = New System.Drawing.Point(14, 3)
            Me.tabCtrl1.PageChromeBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabCtrl1.PageEdgeArtifactBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabCtrl1.PageInsetBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tabCtrl1.SelectedIndex = 0
            Me.tabCtrl1.SelectedTabBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabCtrl1.SelectedTabBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.tabCtrl1.SelectedTabButtonBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.tabCtrl1.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabCtrl1.ShowPageChromeErase = False
            Me.tabCtrl1.ShowPageEdgeArtifactErase = False
            Me.tabCtrl1.ShowTabBorder = False
            Me.tabCtrl1.ShowTabButtonBorder = False
            Me.tabCtrl1.Size = New System.Drawing.Size(443, 651)
            Me.tabCtrl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.tabCtrl1.TabBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(115, Byte), Integer))
            Me.tabCtrl1.TabButtonBorderColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(115, Byte), Integer))
            Me.tabCtrl1.TabChromeBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.tabCtrl1.TabIndex = 0
            Me.tabCtrl1.TabNativeBorderBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.tabCtrl1.TabNativeInsetBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tabCtrl1.TabPageBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabCtrl1.TabStripBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            '
            'tpBasic
            '
            Me.tpBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tpBasic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tpBasic.Controls.Add(Me.GroupBox3)
            Me.tpBasic.Controls.Add(Me.GroupBox2)
            Me.tpBasic.Controls.Add(Me.GroupBox1)
            Me.tpBasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpBasic.Location = New System.Drawing.Point(4, 68)
            Me.tpBasic.Name = "tpBasic"
            Me.tpBasic.Size = New System.Drawing.Size(435, 579)
            Me.tpBasic.TabIndex = 0
            Me.tpBasic.Text = "Basic"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox3.Controls.Add(Me.chkbNotInterruptable)
            Me.GroupBox3.Controls.Add(Me.tbConversation)
            Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox3.Location = New System.Drawing.Point(10, 445)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(410, 66)
            Me.GroupBox3.TabIndex = 2
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Conversation"
            '
            'chkbNotInterruptable
            '
            Me.chkbNotInterruptable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbNotInterruptable.Location = New System.Drawing.Point(311, 24)
            Me.chkbNotInterruptable.Name = "chkbNotInterruptable"
            Me.chkbNotInterruptable.Size = New System.Drawing.Size(93, 22)
            Me.chkbNotInterruptable.TabIndex = 1
            Me.chkbNotInterruptable.Text = "No Interrupt"
            '
            'tbConversation
            '
            Me.tbConversation.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbConversation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbConversation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbConversation.Location = New System.Drawing.Point(12, 24)
            Me.tbConversation.Name = "tbConversation"
            Me.tbConversation.Size = New System.Drawing.Size(293, 22)
            Me.tbConversation.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.cmbxPortrait)
            Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox2.Location = New System.Drawing.Point(10, 351)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(410, 87)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Portrait"
            '
            'cmbxPortrait
            '
            Me.cmbxPortrait.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxPortrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxPortrait.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxPortrait.Location = New System.Drawing.Point(116, 35)
            Me.cmbxPortrait.Name = "cmbxPortrait"
            Me.cmbxPortrait.Size = New System.Drawing.Size(198, 21)
            Me.cmbxPortrait.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
            Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(410, 337)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Profile"
            '
            'cmbxRace
            '
            Me.cmbxRace.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxRace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxRace.Location = New System.Drawing.Point(116, 120)
            Me.cmbxRace.Name = "cmbxRace"
            Me.cmbxRace.Size = New System.Drawing.Size(198, 21)
            Me.cmbxRace.TabIndex = 3
            '
            'tbFirstName
            '
            Me.tbFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFirstName.Location = New System.Drawing.Point(116, 23)
            Me.tbFirstName.Name = "tbFirstName"
            Me.tbFirstName.Size = New System.Drawing.Size(198, 22)
            Me.tbFirstName.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(18, 25)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(92, 21)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "First Name:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(18, 58)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(92, 20)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Last Name:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(18, 90)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 21)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Tag"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(18, 122)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(92, 21)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Race"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(18, 159)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(92, 21)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Appearance"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(18, 196)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(92, 21)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Phenotype"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(18, 270)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(92, 21)
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "Description"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(18, 233)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(92, 21)
            Me.Label9.TabIndex = 0
            Me.Label9.Text = "Gender"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbLastName
            '
            Me.tbLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(188, Byte), Integer))
            Me.tbLastName.Location = New System.Drawing.Point(116, 55)
            Me.tbLastName.Name = "tbLastName"
            Me.tbLastName.ReadOnly = True
            Me.tbLastName.Size = New System.Drawing.Size(198, 22)
            Me.tbLastName.TabIndex = 1
            '
            'tbTag
            '
            Me.tbTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTag.Location = New System.Drawing.Point(116, 88)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(198, 22)
            Me.tbTag.TabIndex = 2
            '
            'tbDescription
            '
            Me.tbDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDescription.Location = New System.Drawing.Point(116, 268)
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Size = New System.Drawing.Size(198, 22)
            Me.tbDescription.TabIndex = 7
            '
            'cmbxAppearance
            '
            Me.cmbxAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxAppearance.Location = New System.Drawing.Point(116, 157)
            Me.cmbxAppearance.Name = "cmbxAppearance"
            Me.cmbxAppearance.Size = New System.Drawing.Size(198, 21)
            Me.cmbxAppearance.TabIndex = 4
            '
            'cmbxPhenotype
            '
            Me.cmbxPhenotype.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxPhenotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxPhenotype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxPhenotype.Location = New System.Drawing.Point(116, 194)
            Me.cmbxPhenotype.Name = "cmbxPhenotype"
            Me.cmbxPhenotype.Size = New System.Drawing.Size(198, 21)
            Me.cmbxPhenotype.TabIndex = 5
            '
            'cmbxGender
            '
            Me.cmbxGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxGender.Location = New System.Drawing.Point(116, 231)
            Me.cmbxGender.Name = "cmbxGender"
            Me.cmbxGender.Size = New System.Drawing.Size(198, 21)
            Me.cmbxGender.TabIndex = 6
            '
            'cmbxBodyBag
            '
            Me.cmbxBodyBag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxBodyBag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxBodyBag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxBodyBag.Location = New System.Drawing.Point(116, 300)
            Me.cmbxBodyBag.Name = "cmbxBodyBag"
            Me.cmbxBodyBag.Size = New System.Drawing.Size(198, 21)
            Me.cmbxBodyBag.TabIndex = 8
            '
            'Label53
            '
            Me.Label53.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label53.Location = New System.Drawing.Point(18, 302)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(92, 21)
            Me.Label53.TabIndex = 0
            Me.Label53.Text = "BodyBag"
            Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tpStatistics
            '
            Me.tpStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tpStatistics.Controls.Add(Me.GroupBox7)
            Me.tpStatistics.Controls.Add(Me.gb2)
            Me.tpStatistics.Controls.Add(Me.GroupBox4)
            Me.tpStatistics.Controls.Add(Me.GroupBox6)
            Me.tpStatistics.Controls.Add(Me.GroupBox5)
            Me.tpStatistics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpStatistics.Location = New System.Drawing.Point(4, 36)
            Me.tpStatistics.Name = "tpStatistics"
            Me.tpStatistics.Size = New System.Drawing.Size(435, 611)
            Me.tpStatistics.TabIndex = 1
            Me.tpStatistics.Text = "Statistics"
            '
            'GroupBox7
            '
            Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox7.Controls.Add(Me.cmbxMovementRate)
            Me.GroupBox7.Controls.Add(Me.Label18)
            Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox7.Location = New System.Drawing.Point(10, 492)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(410, 48)
            Me.GroupBox7.TabIndex = 5
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Speed"
            '
            'cmbxMovementRate
            '
            Me.cmbxMovementRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxMovementRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMovementRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxMovementRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxMovementRate.Location = New System.Drawing.Point(138, 18)
            Me.cmbxMovementRate.Name = "cmbxMovementRate"
            Me.cmbxMovementRate.Size = New System.Drawing.Size(150, 21)
            Me.cmbxMovementRate.TabIndex = 0
            '
            'Label18
            '
            Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(18, 20)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(100, 20)
            Me.Label18.TabIndex = 1
            Me.Label18.Text = "Movement Rate"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'gb2
            '
            Me.gb2.BackColor = System.Drawing.Color.Transparent
            Me.gb2.Controls.Add(Me.Label19)
            Me.gb2.Controls.Add(Me.Label20)
            Me.gb2.Controls.Add(Me.Label21)
            Me.gb2.Controls.Add(Me.nudWillBonus)
            Me.gb2.Controls.Add(Me.nudFortBonus)
            Me.gb2.Controls.Add(Me.nudRefBonus)
            Me.gb2.Controls.Add(Me.Label22)
            Me.gb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gb2.Location = New System.Drawing.Point(10, 235)
            Me.gb2.Name = "gb2"
            Me.gb2.Size = New System.Drawing.Size(410, 125)
            Me.gb2.TabIndex = 2
            Me.gb2.TabStop = False
            Me.gb2.Text = "Saves"
            '
            'Label19
            '
            Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(30, 68)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(90, 21)
            Me.Label19.TabIndex = 0
            Me.Label19.Text = "Reflex"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label20
            '
            Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label20.Location = New System.Drawing.Point(30, 96)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(90, 21)
            Me.Label20.TabIndex = 0
            Me.Label20.Text = "Will"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label21
            '
            Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label21.Location = New System.Drawing.Point(30, 40)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(90, 21)
            Me.Label21.TabIndex = 0
            Me.Label21.Text = "Fortitude"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudWillBonus
            '
            Me.nudWillBonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudWillBonus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudWillBonus.Location = New System.Drawing.Point(138, 96)
            Me.nudWillBonus.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudWillBonus.Name = "nudWillBonus"
            Me.nudWillBonus.Size = New System.Drawing.Size(48, 22)
            Me.nudWillBonus.TabIndex = 2
            Me.nudWillBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudFortBonus
            '
            Me.nudFortBonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudFortBonus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudFortBonus.Location = New System.Drawing.Point(138, 40)
            Me.nudFortBonus.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudFortBonus.Name = "nudFortBonus"
            Me.nudFortBonus.Size = New System.Drawing.Size(48, 22)
            Me.nudFortBonus.TabIndex = 0
            Me.nudFortBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudRefBonus
            '
            Me.nudRefBonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudRefBonus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudRefBonus.Location = New System.Drawing.Point(138, 68)
            Me.nudRefBonus.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudRefBonus.Name = "nudRefBonus"
            Me.nudRefBonus.Size = New System.Drawing.Size(48, 22)
            Me.nudRefBonus.TabIndex = 1
            Me.nudRefBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label22
            '
            Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(138, 18)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(66, 21)
            Me.Label22.TabIndex = 0
            Me.Label22.Text = "Bonus"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
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
            Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox4.Location = New System.Drawing.Point(10, 12)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(410, 214)
            Me.GroupBox4.TabIndex = 1
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Ability Score"
            '
            'nudStrength
            '
            Me.nudStrength.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudStrength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudStrength.Location = New System.Drawing.Point(138, 35)
            Me.nudStrength.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.nudStrength.Name = "nudStrength"
            Me.nudStrength.Size = New System.Drawing.Size(48, 22)
            Me.nudStrength.TabIndex = 0
            Me.nudStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudStrength.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label14
            '
            Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(30, 174)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(90, 21)
            Me.Label14.TabIndex = 0
            Me.Label14.Text = "Charisma"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(30, 63)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(90, 21)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "Dexterity"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label11
            '
            Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(30, 91)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(90, 21)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "Constitution"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label13
            '
            Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(30, 147)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(90, 20)
            Me.Label13.TabIndex = 0
            Me.Label13.Text = "Wisdom"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(30, 36)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(90, 21)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "Strength"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label12
            '
            Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(30, 119)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(90, 21)
            Me.Label12.TabIndex = 0
            Me.Label12.Text = "Intelligence"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label15
            '
            Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(138, 14)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(42, 21)
            Me.Label15.TabIndex = 0
            Me.Label15.Text = "Score"
            '
            'nudDexterity
            '
            Me.nudDexterity.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudDexterity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudDexterity.Location = New System.Drawing.Point(138, 62)
            Me.nudDexterity.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.nudDexterity.Name = "nudDexterity"
            Me.nudDexterity.Size = New System.Drawing.Size(48, 22)
            Me.nudDexterity.TabIndex = 1
            Me.nudDexterity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudDexterity.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudConstitution
            '
            Me.nudConstitution.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudConstitution.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudConstitution.Location = New System.Drawing.Point(138, 90)
            Me.nudConstitution.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.nudConstitution.Name = "nudConstitution"
            Me.nudConstitution.Size = New System.Drawing.Size(48, 22)
            Me.nudConstitution.TabIndex = 2
            Me.nudConstitution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudConstitution.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudIntelligence
            '
            Me.nudIntelligence.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudIntelligence.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudIntelligence.Location = New System.Drawing.Point(138, 118)
            Me.nudIntelligence.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.nudIntelligence.Name = "nudIntelligence"
            Me.nudIntelligence.Size = New System.Drawing.Size(48, 22)
            Me.nudIntelligence.TabIndex = 3
            Me.nudIntelligence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudIntelligence.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudWisdom
            '
            Me.nudWisdom.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudWisdom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudWisdom.Location = New System.Drawing.Point(138, 145)
            Me.nudWisdom.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.nudWisdom.Name = "nudWisdom"
            Me.nudWisdom.Size = New System.Drawing.Size(48, 22)
            Me.nudWisdom.TabIndex = 4
            Me.nudWisdom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudWisdom.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudCharisma
            '
            Me.nudCharisma.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCharisma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCharisma.Location = New System.Drawing.Point(138, 173)
            Me.nudCharisma.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.nudCharisma.Name = "nudCharisma"
            Me.nudCharisma.Size = New System.Drawing.Size(48, 22)
            Me.nudCharisma.TabIndex = 5
            Me.nudCharisma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudCharisma.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'GroupBox6
            '
            Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox6.Controls.Add(Me.Label16)
            Me.GroupBox6.Controls.Add(Me.nudNaturalAC)
            Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox6.Location = New System.Drawing.Point(10, 369)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(198, 116)
            Me.GroupBox6.TabIndex = 3
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Armor Class"
            '
            'Label16
            '
            Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label16.Location = New System.Drawing.Point(12, 32)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(90, 21)
            Me.Label16.TabIndex = 1
            Me.Label16.Text = "Natural AC"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudNaturalAC
            '
            Me.nudNaturalAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudNaturalAC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudNaturalAC.Location = New System.Drawing.Point(120, 30)
            Me.nudNaturalAC.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.nudNaturalAC.Name = "nudNaturalAC"
            Me.nudNaturalAC.Size = New System.Drawing.Size(56, 22)
            Me.nudNaturalAC.TabIndex = 0
            Me.nudNaturalAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudNaturalAC.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'GroupBox5
            '
            Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox5.Controls.Add(Me.Label17)
            Me.GroupBox5.Controls.Add(Me.nudBaseHP)
            Me.GroupBox5.Controls.Add(Me.Label49)
            Me.GroupBox5.Controls.Add(Me.nudCurrentHP)
            Me.GroupBox5.Controls.Add(Me.nudMaxHP)
            Me.GroupBox5.Controls.Add(Me.Label50)
            Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox5.Location = New System.Drawing.Point(216, 369)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(204, 116)
            Me.GroupBox5.TabIndex = 4
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Hit Points"
            '
            'Label17
            '
            Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(12, 28)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(104, 20)
            Me.Label17.TabIndex = 3
            Me.Label17.Text = "Base Hit Points"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudBaseHP
            '
            Me.nudBaseHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudBaseHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudBaseHP.Location = New System.Drawing.Point(128, 25)
            Me.nudBaseHP.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.nudBaseHP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudBaseHP.Name = "nudBaseHP"
            Me.nudBaseHP.Size = New System.Drawing.Size(56, 22)
            Me.nudBaseHP.TabIndex = 0
            Me.nudBaseHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudBaseHP.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label49
            '
            Me.Label49.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label49.Location = New System.Drawing.Point(12, 57)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(112, 20)
            Me.Label49.TabIndex = 3
            Me.Label49.Text = "Current Hit Points"
            Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudCurrentHP
            '
            Me.nudCurrentHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCurrentHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCurrentHP.Location = New System.Drawing.Point(128, 54)
            Me.nudCurrentHP.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.nudCurrentHP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudCurrentHP.Name = "nudCurrentHP"
            Me.nudCurrentHP.Size = New System.Drawing.Size(56, 22)
            Me.nudCurrentHP.TabIndex = 1
            Me.nudCurrentHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudCurrentHP.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudMaxHP
            '
            Me.nudMaxHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudMaxHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudMaxHP.Location = New System.Drawing.Point(128, 83)
            Me.nudMaxHP.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.nudMaxHP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxHP.Name = "nudMaxHP"
            Me.nudMaxHP.Size = New System.Drawing.Size(56, 22)
            Me.nudMaxHP.TabIndex = 2
            Me.nudMaxHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudMaxHP.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label50
            '
            Me.Label50.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label50.Location = New System.Drawing.Point(12, 85)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(104, 21)
            Me.Label50.TabIndex = 3
            Me.Label50.Text = "Max Hit Points"
            Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tpSkills
            '
            Me.tpSkills.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tpSkills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpSkills.Location = New System.Drawing.Point(4, 36)
            Me.tpSkills.Name = "tpSkills"
            Me.tpSkills.Size = New System.Drawing.Size(435, 611)
            Me.tpSkills.TabIndex = 4
            Me.tpSkills.Text = "Skills"
            '
            'nudComputerUse
            '
            Me.nudComputerUse.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudComputerUse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudComputerUse.Location = New System.Drawing.Point(214, 67)
            Me.nudComputerUse.Name = "nudComputerUse"
            Me.nudComputerUse.Size = New System.Drawing.Size(48, 22)
            Me.nudComputerUse.TabIndex = 0
            Me.nudComputerUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudComputerUse.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label24
            '
            Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(104, 219)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(100, 21)
            Me.Label24.TabIndex = 6
            Me.Label24.Text = "Repair"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(104, 99)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(100, 21)
            Me.Label25.TabIndex = 7
            Me.Label25.Text = "Demolitions"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label26
            '
            Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label26.Location = New System.Drawing.Point(104, 129)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(100, 21)
            Me.Label26.TabIndex = 5
            Me.Label26.Text = "Stealth"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label27
            '
            Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label27.Location = New System.Drawing.Point(104, 189)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(100, 21)
            Me.Label27.TabIndex = 2
            Me.Label27.Text = "Persuade"
            Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label28
            '
            Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label28.Location = New System.Drawing.Point(104, 69)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(100, 21)
            Me.Label28.TabIndex = 3
            Me.Label28.Text = "Computer Use"
            Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label29
            '
            Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label29.Location = New System.Drawing.Point(104, 159)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(100, 21)
            Me.Label29.TabIndex = 4
            Me.Label29.Text = "Awareness"
            Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudDemolitions
            '
            Me.nudDemolitions.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudDemolitions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudDemolitions.Location = New System.Drawing.Point(214, 97)
            Me.nudDemolitions.Name = "nudDemolitions"
            Me.nudDemolitions.Size = New System.Drawing.Size(48, 22)
            Me.nudDemolitions.TabIndex = 1
            Me.nudDemolitions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudDemolitions.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudStealth
            '
            Me.nudStealth.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudStealth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudStealth.Location = New System.Drawing.Point(214, 127)
            Me.nudStealth.Name = "nudStealth"
            Me.nudStealth.Size = New System.Drawing.Size(48, 22)
            Me.nudStealth.TabIndex = 2
            Me.nudStealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudStealth.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudAwareness
            '
            Me.nudAwareness.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudAwareness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudAwareness.Location = New System.Drawing.Point(214, 157)
            Me.nudAwareness.Name = "nudAwareness"
            Me.nudAwareness.Size = New System.Drawing.Size(48, 22)
            Me.nudAwareness.TabIndex = 3
            Me.nudAwareness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudAwareness.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudPersuade
            '
            Me.nudPersuade.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudPersuade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudPersuade.Location = New System.Drawing.Point(214, 187)
            Me.nudPersuade.Name = "nudPersuade"
            Me.nudPersuade.Size = New System.Drawing.Size(48, 22)
            Me.nudPersuade.TabIndex = 4
            Me.nudPersuade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudPersuade.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudRepair
            '
            Me.nudRepair.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudRepair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudRepair.Location = New System.Drawing.Point(214, 217)
            Me.nudRepair.Name = "nudRepair"
            Me.nudRepair.Size = New System.Drawing.Size(48, 22)
            Me.nudRepair.TabIndex = 5
            Me.nudRepair.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudRepair.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label30
            '
            Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label30.Location = New System.Drawing.Point(104, 249)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(100, 21)
            Me.Label30.TabIndex = 2
            Me.Label30.Text = "Security"
            Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudSecurity
            '
            Me.nudSecurity.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudSecurity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudSecurity.Location = New System.Drawing.Point(214, 247)
            Me.nudSecurity.Name = "nudSecurity"
            Me.nudSecurity.Size = New System.Drawing.Size(48, 22)
            Me.nudSecurity.TabIndex = 6
            Me.nudSecurity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudSecurity.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'nudTreatInjury
            '
            Me.nudTreatInjury.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudTreatInjury.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudTreatInjury.Location = New System.Drawing.Point(214, 277)
            Me.nudTreatInjury.Name = "nudTreatInjury"
            Me.nudTreatInjury.Size = New System.Drawing.Size(48, 22)
            Me.nudTreatInjury.TabIndex = 7
            Me.nudTreatInjury.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudTreatInjury.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label31
            '
            Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label31.Location = New System.Drawing.Point(104, 279)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(100, 21)
            Me.Label31.TabIndex = 6
            Me.Label31.Text = "Treat Injury"
            Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tpAdvanced
            '
            Me.tpAdvanced.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tpAdvanced.Controls.Add(Me.GroupBox12)
            Me.tpAdvanced.Controls.Add(Me.GroupBox11)
            Me.tpAdvanced.Controls.Add(Me.GroupBox13)
            Me.tpAdvanced.Controls.Add(Me.GroupBox14)
            Me.tpAdvanced.Controls.Add(Me.GroupBox15)
            Me.tpAdvanced.Controls.Add(Me.GroupBox18)
            Me.tpAdvanced.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpAdvanced.Location = New System.Drawing.Point(4, 36)
            Me.tpAdvanced.Name = "tpAdvanced"
            Me.tpAdvanced.Size = New System.Drawing.Size(435, 611)
            Me.tpAdvanced.TabIndex = 6
            Me.tpAdvanced.Text = "Advanced"
            '
            'GroupBox12
            '
            Me.GroupBox12.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox12.Controls.Add(Me.tbChallengeRating)
            Me.GroupBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox12.Location = New System.Drawing.Point(12, 395)
            Me.GroupBox12.Name = "GroupBox12"
            Me.GroupBox12.Size = New System.Drawing.Size(198, 67)
            Me.GroupBox12.TabIndex = 3
            Me.GroupBox12.TabStop = False
            Me.GroupBox12.Text = "Challenge Rating"
            '
            'tbChallengeRating
            '
            Me.tbChallengeRating.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbChallengeRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbChallengeRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbChallengeRating.Location = New System.Drawing.Point(24, 25)
            Me.tbChallengeRating.Name = "tbChallengeRating"
            Me.tbChallengeRating.Size = New System.Drawing.Size(56, 22)
            Me.tbChallengeRating.TabIndex = 0
            '
            'GroupBox11
            '
            Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
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
            Me.GroupBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox11.Location = New System.Drawing.Point(12, 125)
            Me.GroupBox11.Name = "GroupBox11"
            Me.GroupBox11.Size = New System.Drawing.Size(406, 260)
            Me.GroupBox11.TabIndex = 2
            Me.GroupBox11.TabStop = False
            Me.GroupBox11.Text = "Special"
            '
            'nudMultiplierSet
            '
            Me.nudMultiplierSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudMultiplierSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudMultiplierSet.Location = New System.Drawing.Point(320, 178)
            Me.nudMultiplierSet.Name = "nudMultiplierSet"
            Me.nudMultiplierSet.Size = New System.Drawing.Size(56, 22)
            Me.nudMultiplierSet.TabIndex = 9
            Me.nudMultiplierSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudMultiplierSet.Visible = False
            '
            'Label51
            '
            Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label51.Location = New System.Drawing.Point(30, 217)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(100, 21)
            Me.Label51.TabIndex = 1
            Me.Label51.Text = "Subrace"
            '
            'chkbDisarmable
            '
            Me.chkbDisarmable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbDisarmable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbDisarmable.Location = New System.Drawing.Point(30, 35)
            Me.chkbDisarmable.Name = "chkbDisarmable"
            Me.chkbDisarmable.Size = New System.Drawing.Size(104, 20)
            Me.chkbDisarmable.TabIndex = 0
            Me.chkbDisarmable.Text = "Disarmable"
            '
            'chkbPlot
            '
            Me.chkbPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbPlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbPlot.Location = New System.Drawing.Point(30, 90)
            Me.chkbPlot.Name = "chkbPlot"
            Me.chkbPlot.Size = New System.Drawing.Size(66, 21)
            Me.chkbPlot.TabIndex = 2
            Me.chkbPlot.Text = "Plot"
            '
            'chkbNoPermDeath
            '
            Me.chkbNoPermDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbNoPermDeath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbNoPermDeath.Location = New System.Drawing.Point(30, 62)
            Me.chkbNoPermDeath.Name = "chkbNoPermDeath"
            Me.chkbNoPermDeath.Size = New System.Drawing.Size(144, 21)
            Me.chkbNoPermDeath.TabIndex = 1
            Me.chkbNoPermDeath.Text = "No Permanent Death"
            '
            'Label52
            '
            Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label52.Location = New System.Drawing.Point(30, 242)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(100, 21)
            Me.Label52.TabIndex = 1
            Me.Label52.Text = "Deity"
            Me.Label52.Visible = False
            '
            'tbDeity
            '
            Me.tbDeity.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbDeity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDeity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDeity.Location = New System.Drawing.Point(144, 240)
            Me.tbDeity.Name = "tbDeity"
            Me.tbDeity.Size = New System.Drawing.Size(144, 22)
            Me.tbDeity.TabIndex = 11
            Me.tbDeity.Visible = False
            '
            'chkbIsPC
            '
            Me.chkbIsPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbIsPC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbIsPC.Location = New System.Drawing.Point(30, 118)
            Me.chkbIsPC.Name = "chkbIsPC"
            Me.chkbIsPC.Size = New System.Drawing.Size(60, 20)
            Me.chkbIsPC.TabIndex = 3
            Me.chkbIsPC.Text = "Is PC"
            '
            'cmbxSubrace
            '
            Me.cmbxSubrace.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxSubrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSubrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxSubrace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxSubrace.Location = New System.Drawing.Point(144, 215)
            Me.cmbxSubrace.Name = "cmbxSubrace"
            Me.cmbxSubrace.Size = New System.Drawing.Size(144, 21)
            Me.cmbxSubrace.TabIndex = 10
            '
            'chkbIsHologram
            '
            Me.chkbIsHologram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbIsHologram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbIsHologram.Location = New System.Drawing.Point(190, 90)
            Me.chkbIsHologram.Name = "chkbIsHologram"
            Me.chkbIsHologram.Size = New System.Drawing.Size(104, 21)
            Me.chkbIsHologram.TabIndex = 7
            Me.chkbIsHologram.Text = "Is Hologram"
            Me.chkbIsHologram.Visible = False
            '
            'chkbNotReorienting
            '
            Me.chkbNotReorienting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbNotReorienting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbNotReorienting.Location = New System.Drawing.Point(190, 35)
            Me.chkbNotReorienting.Name = "chkbNotReorienting"
            Me.chkbNotReorienting.Size = New System.Drawing.Size(156, 20)
            Me.chkbNotReorienting.TabIndex = 5
            Me.chkbNotReorienting.Text = "Doesn't Reorient on PC"
            Me.chkbNotReorienting.Visible = False
            '
            'chkbIgnoreCrePath
            '
            Me.chkbIgnoreCrePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbIgnoreCrePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbIgnoreCrePath.Location = New System.Drawing.Point(190, 62)
            Me.chkbIgnoreCrePath.Name = "chkbIgnoreCrePath"
            Me.chkbIgnoreCrePath.Size = New System.Drawing.Size(130, 21)
            Me.chkbIgnoreCrePath.TabIndex = 6
            Me.chkbIgnoreCrePath.Text = "Doesn't Block PC"
            Me.chkbIgnoreCrePath.Visible = False
            '
            'lblMultiplierSet
            '
            Me.lblMultiplierSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblMultiplierSet.Location = New System.Drawing.Point(210, 180)
            Me.lblMultiplierSet.Name = "lblMultiplierSet"
            Me.lblMultiplierSet.Size = New System.Drawing.Size(100, 21)
            Me.lblMultiplierSet.TabIndex = 1
            Me.lblMultiplierSet.Text = "Multiplier Set"
            Me.lblMultiplierSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblMultiplierSet.Visible = False
            '
            'lblBlindSpot
            '
            Me.lblBlindSpot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblBlindSpot.Location = New System.Drawing.Point(30, 180)
            Me.lblBlindSpot.Name = "lblBlindSpot"
            Me.lblBlindSpot.Size = New System.Drawing.Size(100, 21)
            Me.lblBlindSpot.TabIndex = 1
            Me.lblBlindSpot.Text = "Blind Spot"
            Me.lblBlindSpot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblBlindSpot.Visible = False
            '
            'nudBlindSpot
            '
            Me.nudBlindSpot.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudBlindSpot.DecimalPlaces = 1
            Me.nudBlindSpot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudBlindSpot.Location = New System.Drawing.Point(144, 178)
            Me.nudBlindSpot.Maximum = New Decimal(New Integer() {3599, 0, 0, 65536})
            Me.nudBlindSpot.Name = "nudBlindSpot"
            Me.nudBlindSpot.Size = New System.Drawing.Size(56, 22)
            Me.nudBlindSpot.TabIndex = 8
            Me.nudBlindSpot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudBlindSpot.Visible = False
            '
            'chkbMin1HP
            '
            Me.chkbMin1HP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbMin1HP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbMin1HP.Location = New System.Drawing.Point(30, 145)
            Me.chkbMin1HP.Name = "chkbMin1HP"
            Me.chkbMin1HP.Size = New System.Drawing.Size(108, 21)
            Me.chkbMin1HP.TabIndex = 4
            Me.chkbMin1HP.Text = "Minimum 1 HP"
            '
            'GroupBox13
            '
            Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox13.Controls.Add(Me.cmbxSoundSet)
            Me.GroupBox13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox13.Location = New System.Drawing.Point(220, 395)
            Me.GroupBox13.Name = "GroupBox13"
            Me.GroupBox13.Size = New System.Drawing.Size(198, 67)
            Me.GroupBox13.TabIndex = 4
            Me.GroupBox13.TabStop = False
            Me.GroupBox13.Text = "Sound Set"
            '
            'cmbxSoundSet
            '
            Me.cmbxSoundSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxSoundSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSoundSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxSoundSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxSoundSet.Location = New System.Drawing.Point(20, 25)
            Me.cmbxSoundSet.Name = "cmbxSoundSet"
            Me.cmbxSoundSet.Size = New System.Drawing.Size(158, 21)
            Me.cmbxSoundSet.TabIndex = 0
            '
            'GroupBox14
            '
            Me.GroupBox14.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox14.Controls.Add(Me.cmbxPerceptionRange)
            Me.GroupBox14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox14.Location = New System.Drawing.Point(220, 471)
            Me.GroupBox14.Name = "GroupBox14"
            Me.GroupBox14.Size = New System.Drawing.Size(198, 67)
            Me.GroupBox14.TabIndex = 6
            Me.GroupBox14.TabStop = False
            Me.GroupBox14.Text = "Perception Range"
            '
            'cmbxPerceptionRange
            '
            Me.cmbxPerceptionRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxPerceptionRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxPerceptionRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxPerceptionRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxPerceptionRange.Items.AddRange(New Object() {"Short", "Medium", "Long", "Default", "Player", "Monster"})
            Me.cmbxPerceptionRange.Location = New System.Drawing.Point(20, 25)
            Me.cmbxPerceptionRange.Name = "cmbxPerceptionRange"
            Me.cmbxPerceptionRange.Size = New System.Drawing.Size(158, 21)
            Me.cmbxPerceptionRange.TabIndex = 0
            '
            'GroupBox15
            '
            Me.GroupBox15.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox15.Controls.Add(Me.cmbxFaction)
            Me.GroupBox15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox15.Location = New System.Drawing.Point(12, 471)
            Me.GroupBox15.Name = "GroupBox15"
            Me.GroupBox15.Size = New System.Drawing.Size(198, 67)
            Me.GroupBox15.TabIndex = 5
            Me.GroupBox15.TabStop = False
            Me.GroupBox15.Text = "Faction"
            '
            'cmbxFaction
            '
            Me.cmbxFaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxFaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxFaction.Location = New System.Drawing.Point(20, 25)
            Me.cmbxFaction.Name = "cmbxFaction"
            Me.cmbxFaction.Size = New System.Drawing.Size(158, 21)
            Me.cmbxFaction.TabIndex = 1
            '
            'GroupBox18
            '
            Me.GroupBox18.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox18.Controls.Add(Me.tbTemplateResRef)
            Me.GroupBox18.Controls.Add(Me.Label56)
            Me.GroupBox18.Controls.Add(Me.Label57)
            Me.GroupBox18.Controls.Add(Me.cmbxTreasureModel)
            Me.GroupBox18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox18.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox18.Name = "GroupBox18"
            Me.GroupBox18.Size = New System.Drawing.Size(406, 103)
            Me.GroupBox18.TabIndex = 0
            Me.GroupBox18.TabStop = False
            Me.GroupBox18.Text = "Info"
            '
            'tbTemplateResRef
            '
            Me.tbTemplateResRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTemplateResRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTemplateResRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbTemplateResRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTemplateResRef.Location = New System.Drawing.Point(154, 27)
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Me.tbTemplateResRef.Size = New System.Drawing.Size(176, 22)
            Me.tbTemplateResRef.TabIndex = 2
            '
            'Label56
            '
            Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label56.Location = New System.Drawing.Point(24, 66)
            Me.Label56.Name = "Label56"
            Me.Label56.Size = New System.Drawing.Size(112, 21)
            Me.Label56.TabIndex = 1
            Me.Label56.Text = "Treasure Model"
            Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label56.Visible = False
            '
            'Label57
            '
            Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label57.Location = New System.Drawing.Point(24, 29)
            Me.Label57.Name = "Label57"
            Me.Label57.Size = New System.Drawing.Size(112, 21)
            Me.Label57.TabIndex = 1
            Me.Label57.Text = "Template ResRef"
            Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxTreasureModel
            '
            Me.cmbxTreasureModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxTreasureModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxTreasureModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxTreasureModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxTreasureModel.Items.AddRange(New Object() {"Short", "Medium", "Long", "Default", "Player", "Monster"})
            Me.cmbxTreasureModel.Location = New System.Drawing.Point(154, 63)
            Me.cmbxTreasureModel.Name = "cmbxTreasureModel"
            Me.cmbxTreasureModel.Size = New System.Drawing.Size(176, 21)
            Me.cmbxTreasureModel.TabIndex = 0
            Me.cmbxTreasureModel.Visible = False
            '
            'tpFeats
            '
            Me.tpFeats.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tpFeats.Controls.Add(Me.GroupBox10)
            Me.tpFeats.Controls.Add(Me.chklbFeats)
            Me.tpFeats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpFeats.Location = New System.Drawing.Point(4, 36)
            Me.tpFeats.Name = "tpFeats"
            Me.tpFeats.Size = New System.Drawing.Size(435, 611)
            Me.tpFeats.TabIndex = 7
            Me.tpFeats.Text = "Feats"
            '
            'GroupBox10
            '
            Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox10.Controls.Add(Me.tbFeatSummary)
            Me.GroupBox10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox10.Location = New System.Drawing.Point(10, 395)
            Me.GroupBox10.Name = "GroupBox10"
            Me.GroupBox10.Size = New System.Drawing.Size(410, 145)
            Me.GroupBox10.TabIndex = 2
            Me.GroupBox10.TabStop = False
            Me.GroupBox10.Text = "Feats Selection Summary"
            '
            'tbFeatSummary
            '
            Me.tbFeatSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbFeatSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFeatSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFeatSummary.Location = New System.Drawing.Point(16, 25)
            Me.tbFeatSummary.Multiline = True
            Me.tbFeatSummary.Name = "tbFeatSummary"
            Me.tbFeatSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbFeatSummary.Size = New System.Drawing.Size(378, 107)
            Me.tbFeatSummary.TabIndex = 1
            Me.tbFeatSummary.WordWrap = False
            '
            'chklbFeats
            '
            Me.chklbFeats.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.chklbFeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.chklbFeats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chklbFeats.Location = New System.Drawing.Point(26, 32)
            Me.chklbFeats.Name = "chklbFeats"
            Me.chklbFeats.Size = New System.Drawing.Size(378, 359)
            Me.chklbFeats.TabIndex = 0
            Me.chklbFeats.ThreeDCheckBoxes = True
            '
            'toForcePowers
            '
            Me.toForcePowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.toForcePowers.Controls.Add(Me.GroupBox19)
            Me.toForcePowers.Controls.Add(Me.GroupBox17)
            Me.toForcePowers.Controls.Add(Me.GroupBox16)
            Me.toForcePowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.toForcePowers.Location = New System.Drawing.Point(4, 68)
            Me.toForcePowers.Name = "toForcePowers"
            Me.toForcePowers.Size = New System.Drawing.Size(435, 579)
            Me.toForcePowers.TabIndex = 8
            Me.toForcePowers.Text = "Force Powers"
            '
            'GroupBox19
            '
            Me.GroupBox19.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox19.Controls.Add(Me.tbForcePowerSummary)
            Me.GroupBox19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox19.Location = New System.Drawing.Point(10, 415)
            Me.GroupBox19.Name = "GroupBox19"
            Me.GroupBox19.Size = New System.Drawing.Size(410, 125)
            Me.GroupBox19.TabIndex = 3
            Me.GroupBox19.TabStop = False
            Me.GroupBox19.Text = "Force Power Selection Summary"
            '
            'tbForcePowerSummary
            '
            Me.tbForcePowerSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbForcePowerSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbForcePowerSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbForcePowerSummary.Location = New System.Drawing.Point(16, 21)
            Me.tbForcePowerSummary.Multiline = True
            Me.tbForcePowerSummary.Name = "tbForcePowerSummary"
            Me.tbForcePowerSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbForcePowerSummary.Size = New System.Drawing.Size(378, 92)
            Me.tbForcePowerSummary.TabIndex = 1
            Me.tbForcePowerSummary.WordWrap = False
            '
            'GroupBox17
            '
            Me.GroupBox17.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox17.Controls.Add(Me.chklbForcePowers)
            Me.GroupBox17.Controls.Add(Me.btnSelectAllPowers)
            Me.GroupBox17.Controls.Add(Me.btnClearAllPowers)
            Me.GroupBox17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox17.Location = New System.Drawing.Point(10, 88)
            Me.GroupBox17.Name = "GroupBox17"
            Me.GroupBox17.Size = New System.Drawing.Size(410, 318)
            Me.GroupBox17.TabIndex = 1
            Me.GroupBox17.TabStop = False
            Me.GroupBox17.Text = "Force Powers"
            '
            'chklbForcePowers
            '
            Me.chklbForcePowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.chklbForcePowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.chklbForcePowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chklbForcePowers.Location = New System.Drawing.Point(72, 21)
            Me.chklbForcePowers.Name = "chklbForcePowers"
            Me.chklbForcePowers.Size = New System.Drawing.Size(286, 223)
            Me.chklbForcePowers.TabIndex = 0
            Me.chklbForcePowers.ThreeDCheckBoxes = True
            '
            'btnSelectAllPowers
            '
            Me.btnSelectAllPowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnSelectAllPowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSelectAllPowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSelectAllPowers.Location = New System.Drawing.Point(92, 279)
            Me.btnSelectAllPowers.Name = "btnSelectAllPowers"
            Me.btnSelectAllPowers.Size = New System.Drawing.Size(112, 28)
            Me.btnSelectAllPowers.TabIndex = 1
            Me.btnSelectAllPowers.Text = "Select All Powers"
            Me.btnSelectAllPowers.UseVisualStyleBackColor = False
            '
            'btnClearAllPowers
            '
            Me.btnClearAllPowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnClearAllPowers.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClearAllPowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClearAllPowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnClearAllPowers.Location = New System.Drawing.Point(224, 279)
            Me.btnClearAllPowers.Name = "btnClearAllPowers"
            Me.btnClearAllPowers.Size = New System.Drawing.Size(112, 28)
            Me.btnClearAllPowers.TabIndex = 2
            Me.btnClearAllPowers.Text = "Clear All Powers"
            Me.btnClearAllPowers.UseVisualStyleBackColor = False
            '
            'GroupBox16
            '
            Me.GroupBox16.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox16.Controls.Add(Me.nudForcePoints)
            Me.GroupBox16.Controls.Add(Me.Label54)
            Me.GroupBox16.Controls.Add(Me.Label55)
            Me.GroupBox16.Controls.Add(Me.nudCurrentForce)
            Me.GroupBox16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox16.Location = New System.Drawing.Point(10, 9)
            Me.GroupBox16.Name = "GroupBox16"
            Me.GroupBox16.Size = New System.Drawing.Size(410, 69)
            Me.GroupBox16.TabIndex = 0
            Me.GroupBox16.TabStop = False
            Me.GroupBox16.Text = "Force Points"
            '
            'nudForcePoints
            '
            Me.nudForcePoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudForcePoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudForcePoints.Location = New System.Drawing.Point(126, 28)
            Me.nudForcePoints.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.nudForcePoints.Name = "nudForcePoints"
            Me.nudForcePoints.Size = New System.Drawing.Size(56, 22)
            Me.nudForcePoints.TabIndex = 0
            Me.nudForcePoints.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label54
            '
            Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label54.Location = New System.Drawing.Point(18, 30)
            Me.Label54.Name = "Label54"
            Me.Label54.Size = New System.Drawing.Size(104, 21)
            Me.Label54.TabIndex = 0
            Me.Label54.Text = "Max Force Points"
            Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label55
            '
            Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label55.Location = New System.Drawing.Point(206, 30)
            Me.Label55.Name = "Label55"
            Me.Label55.Size = New System.Drawing.Size(112, 21)
            Me.Label55.TabIndex = 0
            Me.Label55.Text = "Current Force Points"
            Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudCurrentForce
            '
            Me.nudCurrentForce.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCurrentForce.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCurrentForce.Location = New System.Drawing.Point(322, 28)
            Me.nudCurrentForce.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.nudCurrentForce.Name = "nudCurrentForce"
            Me.nudCurrentForce.Size = New System.Drawing.Size(56, 22)
            Me.nudCurrentForce.TabIndex = 1
            Me.nudCurrentForce.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'tpClasses
            '
            Me.tpClasses.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tpClasses.Controls.Add(Me.GroupBox9)
            Me.tpClasses.Controls.Add(Me.GroupBox8)
            Me.tpClasses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpClasses.Location = New System.Drawing.Point(4, 68)
            Me.tpClasses.Name = "tpClasses"
            Me.tpClasses.Size = New System.Drawing.Size(435, 579)
            Me.tpClasses.TabIndex = 3
            Me.tpClasses.Text = "Class"
            '
            'GroupBox9
            '
            Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox9.Controls.Add(Me.Label46)
            Me.GroupBox9.Controls.Add(Me.nudClassLevel)
            Me.GroupBox9.Controls.Add(Me.cmbxClass)
            Me.GroupBox9.Controls.Add(Me.Label23)
            Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox9.Location = New System.Drawing.Point(10, 136)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(410, 125)
            Me.GroupBox9.TabIndex = 7
            Me.GroupBox9.TabStop = False
            Me.GroupBox9.Text = "Classes"
            '
            'Label46
            '
            Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label46.Location = New System.Drawing.Point(24, 76)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(56, 21)
            Me.Label46.TabIndex = 3
            Me.Label46.Text = "Level"
            Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudClassLevel
            '
            Me.nudClassLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudClassLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudClassLevel.Location = New System.Drawing.Point(90, 74)
            Me.nudClassLevel.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudClassLevel.Name = "nudClassLevel"
            Me.nudClassLevel.Size = New System.Drawing.Size(56, 22)
            Me.nudClassLevel.TabIndex = 1
            '
            'cmbxClass
            '
            Me.cmbxClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxClass.Location = New System.Drawing.Point(90, 32)
            Me.cmbxClass.Name = "cmbxClass"
            Me.cmbxClass.Size = New System.Drawing.Size(198, 21)
            Me.cmbxClass.TabIndex = 0
            '
            'Label23
            '
            Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label23.Location = New System.Drawing.Point(24, 35)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(56, 20)
            Me.Label23.TabIndex = 3
            Me.Label23.Text = "Class"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox8
            '
            Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox8.Controls.Add(Me.nudAlignment)
            Me.GroupBox8.Controls.Add(Me.Label47)
            Me.GroupBox8.Controls.Add(Me.trkbarAlignment)
            Me.GroupBox8.Controls.Add(Me.Label48)
            Me.GroupBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox8.Location = New System.Drawing.Point(10, 9)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(410, 118)
            Me.GroupBox8.TabIndex = 6
            Me.GroupBox8.TabStop = False
            Me.GroupBox8.Text = "Alignment"
            '
            'nudAlignment
            '
            Me.nudAlignment.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudAlignment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudAlignment.Location = New System.Drawing.Point(190, 81)
            Me.nudAlignment.Name = "nudAlignment"
            Me.nudAlignment.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudAlignment.Size = New System.Drawing.Size(48, 22)
            Me.nudAlignment.TabIndex = 1
            Me.nudAlignment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label47
            '
            Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label47.Location = New System.Drawing.Point(18, 42)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(36, 20)
            Me.Label47.TabIndex = 1
            Me.Label47.Text = "Evil"
            '
            'trkbarAlignment
            '
            Me.trkbarAlignment.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.trkbarAlignment.Location = New System.Drawing.Point(66, 28)
            Me.trkbarAlignment.Maximum = 100
            Me.trkbarAlignment.Name = "trkbarAlignment"
            Me.trkbarAlignment.Size = New System.Drawing.Size(276, 45)
            Me.trkbarAlignment.TabIndex = 0
            Me.trkbarAlignment.TickFrequency = 5
            '
            'Label48
            '
            Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label48.Location = New System.Drawing.Point(350, 42)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(44, 20)
            Me.Label48.TabIndex = 1
            Me.Label48.Text = "Good"
            '
            'tpSpecialAbilities
            '
            Me.tpSpecialAbilities.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tpSpecialAbilities.Controls.Add(Me.GroupBox20)
            Me.tpSpecialAbilities.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpSpecialAbilities.Location = New System.Drawing.Point(4, 68)
            Me.tpSpecialAbilities.Name = "tpSpecialAbilities"
            Me.tpSpecialAbilities.Size = New System.Drawing.Size(435, 579)
            Me.tpSpecialAbilities.TabIndex = 9
            Me.tpSpecialAbilities.Text = "Special Abilities"
            '
            'GroupBox20
            '
            Me.GroupBox20.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox20.Controls.Add(Me.chklbSpecialAbilities)
            Me.GroupBox20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox20.Location = New System.Drawing.Point(10, 9)
            Me.GroupBox20.Name = "GroupBox20"
            Me.GroupBox20.Size = New System.Drawing.Size(410, 551)
            Me.GroupBox20.TabIndex = 3
            Me.GroupBox20.TabStop = False
            Me.GroupBox20.Text = "Special Abilities"
            '
            'chklbSpecialAbilities
            '
            Me.chklbSpecialAbilities.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.chklbSpecialAbilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.chklbSpecialAbilities.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chklbSpecialAbilities.Location = New System.Drawing.Point(18, 21)
            Me.chklbSpecialAbilities.Name = "chklbSpecialAbilities"
            Me.chklbSpecialAbilities.Size = New System.Drawing.Size(376, 512)
            Me.chklbSpecialAbilities.TabIndex = 2
            Me.chklbSpecialAbilities.ThreeDCheckBoxes = True
            '
            'tpScripts
            '
            Me.tpScripts.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tpScripts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpScripts.Location = New System.Drawing.Point(4, 68)
            Me.tpScripts.Name = "tpScripts"
            Me.tpScripts.Size = New System.Drawing.Size(435, 579)
            Me.tpScripts.TabIndex = 5
            Me.tpScripts.Text = "Scripts"
            '
            'btnEditOnEndDialogu
            '
            Me.btnEditOnEndDialogu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnEndDialogu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnEndDialogu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnEndDialogu.Location = New System.Drawing.Point(344, 270)
            Me.btnEditOnEndDialogu.Name = "btnEditOnEndDialogu"
            Me.btnEditOnEndDialogu.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnEndDialogu.TabIndex = 15
            Me.btnEditOnEndDialogu.Text = "Edit"
            Me.btnEditOnEndDialogu.UseVisualStyleBackColor = False
            '
            'btnEditOnDialogue
            '
            Me.btnEditOnDialogue.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnDialogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnDialogue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnDialogue.Location = New System.Drawing.Point(344, 305)
            Me.btnEditOnDialogue.Name = "btnEditOnDialogue"
            Me.btnEditOnDialogue.Size = New System.Drawing.Size(48, 27)
            Me.btnEditOnDialogue.TabIndex = 17
            Me.btnEditOnDialogue.Text = "Edit"
            Me.btnEditOnDialogue.UseVisualStyleBackColor = False
            '
            'btnEditOnUserDefine
            '
            Me.btnEditOnUserDefine.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnUserDefine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnUserDefine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnUserDefine.Location = New System.Drawing.Point(344, 478)
            Me.btnEditOnUserDefine.Name = "btnEditOnUserDefine"
            Me.btnEditOnUserDefine.Size = New System.Drawing.Size(48, 27)
            Me.btnEditOnUserDefine.TabIndex = 27
            Me.btnEditOnUserDefine.Text = "Edit"
            Me.btnEditOnUserDefine.UseVisualStyleBackColor = False
            '
            'btnEditOnHeartbeat
            '
            Me.btnEditOnHeartbeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnHeartbeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnHeartbeat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnHeartbeat.Location = New System.Drawing.Point(344, 28)
            Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
            Me.btnEditOnHeartbeat.Size = New System.Drawing.Size(48, 27)
            Me.btnEditOnHeartbeat.TabIndex = 1
            Me.btnEditOnHeartbeat.Text = "Edit"
            Me.btnEditOnHeartbeat.UseVisualStyleBackColor = False
            '
            'btnEditOnDisturbed
            '
            Me.btnEditOnDisturbed.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnDisturbed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnDisturbed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnDisturbed.Location = New System.Drawing.Point(344, 201)
            Me.btnEditOnDisturbed.Name = "btnEditOnDisturbed"
            Me.btnEditOnDisturbed.Size = New System.Drawing.Size(48, 27)
            Me.btnEditOnDisturbed.TabIndex = 11
            Me.btnEditOnDisturbed.Text = "Edit"
            Me.btnEditOnDisturbed.UseVisualStyleBackColor = False
            '
            'btnEditOnDamaged
            '
            Me.btnEditOnDamaged.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnDamaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnDamaged.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnDamaged.Location = New System.Drawing.Point(344, 166)
            Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
            Me.btnEditOnDamaged.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnDamaged.TabIndex = 9
            Me.btnEditOnDamaged.Text = "Edit"
            Me.btnEditOnDamaged.UseVisualStyleBackColor = False
            '
            'btnEditOnAttacked
            '
            Me.btnEditOnAttacked.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnAttacked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnAttacked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnAttacked.Location = New System.Drawing.Point(344, 132)
            Me.btnEditOnAttacked.Name = "btnEditOnAttacked"
            Me.btnEditOnAttacked.Size = New System.Drawing.Size(48, 27)
            Me.btnEditOnAttacked.TabIndex = 7
            Me.btnEditOnAttacked.Text = "Edit"
            Me.btnEditOnAttacked.UseVisualStyleBackColor = False
            '
            'Label34
            '
            Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label34.Location = New System.Drawing.Point(30, 102)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(92, 20)
            Me.Label34.TabIndex = 5
            Me.Label34.Text = "OnSpellAt"
            Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnSpellAt
            '
            Me.tbOnSpellAt.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnSpellAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnSpellAt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnSpellAt.Location = New System.Drawing.Point(126, 99)
            Me.tbOnSpellAt.Name = "tbOnSpellAt"
            Me.tbOnSpellAt.Size = New System.Drawing.Size(204, 22)
            Me.tbOnSpellAt.TabIndex = 4
            '
            'Label33
            '
            Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label33.Location = New System.Drawing.Point(30, 67)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(92, 21)
            Me.Label33.TabIndex = 3
            Me.Label33.Text = "OnNotice"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnNotice
            '
            Me.tbOnNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnNotice.Location = New System.Drawing.Point(126, 65)
            Me.tbOnNotice.Name = "tbOnNotice"
            Me.tbOnNotice.Size = New System.Drawing.Size(204, 22)
            Me.tbOnNotice.TabIndex = 2
            '
            'Label32
            '
            Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label32.Location = New System.Drawing.Point(30, 32)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(92, 21)
            Me.Label32.TabIndex = 1
            Me.Label32.Text = "OnHeartbeat"
            Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnHeartbeat
            '
            Me.tbOnHeartbeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnHeartbeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnHeartbeat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnHeartbeat.Location = New System.Drawing.Point(126, 30)
            Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
            Me.tbOnHeartbeat.Size = New System.Drawing.Size(204, 22)
            Me.tbOnHeartbeat.TabIndex = 0
            '
            'Label35
            '
            Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label35.Location = New System.Drawing.Point(30, 136)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(92, 21)
            Me.Label35.TabIndex = 5
            Me.Label35.Text = "OnAttacked"
            Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnAttacked
            '
            Me.tbOnAttacked.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnAttacked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnAttacked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnAttacked.Location = New System.Drawing.Point(126, 134)
            Me.tbOnAttacked.Name = "tbOnAttacked"
            Me.tbOnAttacked.Size = New System.Drawing.Size(204, 22)
            Me.tbOnAttacked.TabIndex = 6
            '
            'tbOnDamaged
            '
            Me.tbOnDamaged.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnDamaged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnDamaged.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnDamaged.Location = New System.Drawing.Point(126, 168)
            Me.tbOnDamaged.Name = "tbOnDamaged"
            Me.tbOnDamaged.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDamaged.TabIndex = 8
            '
            'Label36
            '
            Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label36.Location = New System.Drawing.Point(30, 171)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(92, 21)
            Me.Label36.TabIndex = 5
            Me.Label36.Text = "OnDamaged"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label37
            '
            Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label37.Location = New System.Drawing.Point(30, 205)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(92, 21)
            Me.Label37.TabIndex = 5
            Me.Label37.Text = "OnDisturbed"
            Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDisturbed
            '
            Me.tbOnDisturbed.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnDisturbed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnDisturbed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnDisturbed.Location = New System.Drawing.Point(126, 203)
            Me.tbOnDisturbed.Name = "tbOnDisturbed"
            Me.tbOnDisturbed.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDisturbed.TabIndex = 10
            '
            'tbOnEndRound
            '
            Me.tbOnEndRound.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnEndRound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnEndRound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnEndRound.Location = New System.Drawing.Point(126, 238)
            Me.tbOnEndRound.Name = "tbOnEndRound"
            Me.tbOnEndRound.Size = New System.Drawing.Size(204, 22)
            Me.tbOnEndRound.TabIndex = 12
            '
            'Label38
            '
            Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label38.Location = New System.Drawing.Point(30, 240)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(92, 21)
            Me.Label38.TabIndex = 5
            Me.Label38.Text = "OnEndRound"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnEndDialogu
            '
            Me.tbOnEndDialogu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnEndDialogu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnEndDialogu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnEndDialogu.Location = New System.Drawing.Point(126, 272)
            Me.tbOnEndDialogu.Name = "tbOnEndDialogu"
            Me.tbOnEndDialogu.Size = New System.Drawing.Size(204, 22)
            Me.tbOnEndDialogu.TabIndex = 14
            '
            'Label39
            '
            Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label39.Location = New System.Drawing.Point(30, 275)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(92, 20)
            Me.Label39.TabIndex = 5
            Me.Label39.Text = "OnEndDialogu"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label40
            '
            Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label40.Location = New System.Drawing.Point(30, 309)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(92, 21)
            Me.Label40.TabIndex = 5
            Me.Label40.Text = "OnDialogue"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDialogue
            '
            Me.tbOnDialogue.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnDialogue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnDialogue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnDialogue.Location = New System.Drawing.Point(126, 307)
            Me.tbOnDialogue.Name = "tbOnDialogue"
            Me.tbOnDialogue.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDialogue.TabIndex = 16
            '
            'Label41
            '
            Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label41.Location = New System.Drawing.Point(30, 344)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(92, 21)
            Me.Label41.TabIndex = 5
            Me.Label41.Text = "OnSpawn"
            Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnSpawn
            '
            Me.tbOnSpawn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnSpawn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnSpawn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnSpawn.Location = New System.Drawing.Point(126, 342)
            Me.tbOnSpawn.Name = "tbOnSpawn"
            Me.tbOnSpawn.Size = New System.Drawing.Size(204, 22)
            Me.tbOnSpawn.TabIndex = 18
            '
            'tbOnRested
            '
            Me.tbOnRested.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnRested.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnRested.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnRested.Location = New System.Drawing.Point(126, 376)
            Me.tbOnRested.Name = "tbOnRested"
            Me.tbOnRested.Size = New System.Drawing.Size(204, 22)
            Me.tbOnRested.TabIndex = 20
            '
            'Label42
            '
            Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label42.Location = New System.Drawing.Point(30, 378)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(92, 21)
            Me.Label42.TabIndex = 5
            Me.Label42.Text = "OnRested"
            Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDeath
            '
            Me.tbOnDeath.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnDeath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnDeath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnDeath.Location = New System.Drawing.Point(126, 411)
            Me.tbOnDeath.Name = "tbOnDeath"
            Me.tbOnDeath.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDeath.TabIndex = 22
            '
            'Label43
            '
            Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label43.Location = New System.Drawing.Point(30, 413)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(92, 21)
            Me.Label43.TabIndex = 5
            Me.Label43.Text = "OnDeath"
            Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label44
            '
            Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label44.Location = New System.Drawing.Point(30, 448)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(92, 20)
            Me.Label44.TabIndex = 5
            Me.Label44.Text = "OnBlocked"
            Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnBlocked
            '
            Me.tbOnBlocked.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnBlocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnBlocked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnBlocked.Location = New System.Drawing.Point(126, 445)
            Me.tbOnBlocked.Name = "tbOnBlocked"
            Me.tbOnBlocked.Size = New System.Drawing.Size(204, 22)
            Me.tbOnBlocked.TabIndex = 24
            '
            'tbOnUserDefine
            '
            Me.tbOnUserDefine.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnUserDefine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnUserDefine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnUserDefine.Location = New System.Drawing.Point(126, 480)
            Me.tbOnUserDefine.Name = "tbOnUserDefine"
            Me.tbOnUserDefine.Size = New System.Drawing.Size(204, 22)
            Me.tbOnUserDefine.TabIndex = 26
            '
            'Label45
            '
            Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label45.Location = New System.Drawing.Point(30, 482)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(92, 21)
            Me.Label45.TabIndex = 5
            Me.Label45.Text = "OnUserDefine"
            Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditOnNotice
            '
            Me.btnEditOnNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnNotice.Location = New System.Drawing.Point(344, 62)
            Me.btnEditOnNotice.Name = "btnEditOnNotice"
            Me.btnEditOnNotice.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnNotice.TabIndex = 3
            Me.btnEditOnNotice.Text = "Edit"
            Me.btnEditOnNotice.UseVisualStyleBackColor = False
            '
            'btnEditOnSpellAt
            '
            Me.btnEditOnSpellAt.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnSpellAt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnSpellAt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnSpellAt.Location = New System.Drawing.Point(344, 97)
            Me.btnEditOnSpellAt.Name = "btnEditOnSpellAt"
            Me.btnEditOnSpellAt.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnSpellAt.TabIndex = 5
            Me.btnEditOnSpellAt.Text = "Edit"
            Me.btnEditOnSpellAt.UseVisualStyleBackColor = False
            '
            'btnEditOnSpawn
            '
            Me.btnEditOnSpawn.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnSpawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnSpawn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnSpawn.Location = New System.Drawing.Point(344, 339)
            Me.btnEditOnSpawn.Name = "btnEditOnSpawn"
            Me.btnEditOnSpawn.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnSpawn.TabIndex = 19
            Me.btnEditOnSpawn.Text = "Edit"
            Me.btnEditOnSpawn.UseVisualStyleBackColor = False
            '
            'btnEditOnDeath
            '
            Me.btnEditOnDeath.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnDeath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnDeath.Location = New System.Drawing.Point(344, 408)
            Me.btnEditOnDeath.Name = "btnEditOnDeath"
            Me.btnEditOnDeath.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnDeath.TabIndex = 23
            Me.btnEditOnDeath.Text = "Edit"
            Me.btnEditOnDeath.UseVisualStyleBackColor = False
            '
            'btnEditOnBlocked
            '
            Me.btnEditOnBlocked.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnBlocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnBlocked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnBlocked.Location = New System.Drawing.Point(344, 443)
            Me.btnEditOnBlocked.Name = "btnEditOnBlocked"
            Me.btnEditOnBlocked.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnBlocked.TabIndex = 25
            Me.btnEditOnBlocked.Text = "Edit"
            Me.btnEditOnBlocked.UseVisualStyleBackColor = False
            '
            'btnEditOnRested
            '
            Me.btnEditOnRested.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnRested.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnRested.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnRested.Location = New System.Drawing.Point(344, 374)
            Me.btnEditOnRested.Name = "btnEditOnRested"
            Me.btnEditOnRested.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnRested.TabIndex = 21
            Me.btnEditOnRested.Text = "Edit"
            Me.btnEditOnRested.UseVisualStyleBackColor = False
            '
            'btnEditOnEndRound
            '
            Me.btnEditOnEndRound.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnEditOnEndRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnEndRound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnEndRound.Location = New System.Drawing.Point(344, 235)
            Me.btnEditOnEndRound.Name = "btnEditOnEndRound"
            Me.btnEditOnEndRound.Size = New System.Drawing.Size(48, 28)
            Me.btnEditOnEndRound.TabIndex = 13
            Me.btnEditOnEndRound.Text = "Edit"
            Me.btnEditOnEndRound.UseVisualStyleBackColor = False
            '
            'tpComments
            '
            Me.tpComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tpComments.Controls.Add(Me.tbComments)
            Me.tpComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tpComments.Location = New System.Drawing.Point(4, 68)
            Me.tpComments.Name = "tpComments"
            Me.tpComments.Size = New System.Drawing.Size(435, 579)
            Me.tpComments.TabIndex = 10
            Me.tpComments.Text = "Comments"
            '
            'tbComments
            '
            Me.tbComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbComments.Location = New System.Drawing.Point(18, 21)
            Me.tbComments.Multiline = True
            Me.tbComments.Name = "tbComments"
            Me.tbComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbComments.Size = New System.Drawing.Size(392, 507)
            Me.tbComments.TabIndex = 0
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterRule)
            Me.pnlFooter.Controls.Add(Me.btnInventory)
            Me.pnlFooter.Controls.Add(Me.btnWriteFile)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnDebug)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 751)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Padding = New System.Windows.Forms.Padding(12, 10, 12, 12)
            Me.pnlFooter.Size = New System.Drawing.Size(467, 60)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(12, 10)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(443, 1)
            Me.lblFooterRule.TabIndex = 0
            '
            'btnInventory
            '
            Me.btnInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnInventory.Location = New System.Drawing.Point(12, 20)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New System.Drawing.Size(96, 32)
            Me.btnInventory.TabIndex = 1
            Me.btnInventory.Text = "&Inventory"
            Me.btnInventory.UseVisualStyleBackColor = False
            '
            'btnWriteFile
            '
            Me.btnWriteFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnWriteFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.btnWriteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnWriteFile.ForeColor = System.Drawing.Color.White
            Me.btnWriteFile.Location = New System.Drawing.Point(255, 20)
            Me.btnWriteFile.Name = "btnWriteFile"
            Me.btnWriteFile.Size = New System.Drawing.Size(96, 32)
            Me.btnWriteFile.TabIndex = 2
            Me.btnWriteFile.Text = "&Save"
            Me.btnWriteFile.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(359, 20)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(96, 32)
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnDebug
            '
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.Transparent
            Me.btnDebug.Location = New System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 9)
            Me.btnDebug.TabIndex = 4
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderRule)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(467, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 8)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(430, 32)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Creature Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(428, 20)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Edit UTC creature profile, statistics, scripts, powers, feats, and metadata."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 73)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(467, 3)
            Me.lblHeaderRule.TabIndex = 2
            '
            'frmUTC_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(469, 813)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(460, 762)
            Me.Name = "frmUTC_Editor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Creature Editor - KotOR"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.tabCtrl1.ResumeLayout(False)
            Me.tpBasic.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.tpStatistics.ResumeLayout(False)
            Me.GroupBox7.ResumeLayout(False)
            Me.gb2.ResumeLayout(False)
            CType(Me.nudWillBonus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFortBonus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRefBonus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.nudStrength, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDexterity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudConstitution, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudIntelligence, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudWisdom, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCharisma, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox6.ResumeLayout(False)
            CType(Me.nudNaturalAC, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox5.ResumeLayout(False)
            CType(Me.nudBaseHP, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCurrentHP, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMaxHP, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpSkills.ResumeLayout(False)
            CType(Me.nudComputerUse, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDemolitions, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudStealth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudAwareness, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudPersuade, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRepair, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSecurity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTreatInjury, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpAdvanced.ResumeLayout(False)
            Me.GroupBox12.ResumeLayout(False)
            Me.GroupBox12.PerformLayout()
            Me.GroupBox11.ResumeLayout(False)
            Me.GroupBox11.PerformLayout()
            CType(Me.nudMultiplierSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudBlindSpot, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox13.ResumeLayout(False)
            Me.GroupBox14.ResumeLayout(False)
            Me.GroupBox15.ResumeLayout(False)
            Me.GroupBox18.ResumeLayout(False)
            Me.GroupBox18.PerformLayout()
            Me.tpFeats.ResumeLayout(False)
            Me.GroupBox10.ResumeLayout(False)
            Me.GroupBox10.PerformLayout()
            Me.toForcePowers.ResumeLayout(False)
            Me.GroupBox19.ResumeLayout(False)
            Me.GroupBox19.PerformLayout()
            Me.GroupBox17.ResumeLayout(False)
            Me.GroupBox16.ResumeLayout(False)
            CType(Me.nudForcePoints, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCurrentForce, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpClasses.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            CType(Me.nudClassLevel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            CType(Me.nudAlignment, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbarAlignment, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpSpecialAbilities.ResumeLayout(False)
            Me.GroupBox20.ResumeLayout(False)
            Me.tpScripts.ResumeLayout(False)
            Me.tpScripts.PerformLayout()
            Me.tpComments.ResumeLayout(False)
            Me.tpComments.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace