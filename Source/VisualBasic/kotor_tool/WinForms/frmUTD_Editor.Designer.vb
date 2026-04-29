Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmUTD_Editor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderRule As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterRule As Global.System.Windows.Forms.Label

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
        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x0600136D RID: 4973 RVA: 0x002AC600 File Offset: 0x002AB600
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUTD_Editor))
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPageBasic = New System.Windows.Forms.TabPage()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.cmbxDoorType = New System.Windows.Forms.ComboBox()
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
            Me.TabPageLock = New System.Windows.Forms.TabPage()
            Me.cmbxOpenState = New System.Windows.Forms.ComboBox()
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
            Me.lblOpenState = New System.Windows.Forms.Label()
            Me.chkbNotBlastable = New System.Windows.Forms.CheckBox()
            Me.TabPageScripts = New System.Windows.Forms.TabPage()
            Me.btnEditOnUserDefined = New System.Windows.Forms.Button()
            Me.btnEditOnHeartbeat = New System.Windows.Forms.Button()
            Me.btnEditOnSpellCastAt = New System.Windows.Forms.Button()
            Me.btnEditOnDeath = New System.Windows.Forms.Button()
            Me.btnEditOnDamaged = New System.Windows.Forms.Button()
            Me.btnEditOnTrapTriggered = New System.Windows.Forms.Button()
            Me.btnEditOnDisarm = New System.Windows.Forms.Button()
            Me.btnEditOnClick = New System.Windows.Forms.Button()
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
            Me.tbOnClick = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.tbOnFailToOpen = New System.Windows.Forms.TextBox()
            Me.btnEditOnClosed = New System.Windows.Forms.Button()
            Me.btnEditOnFailToOpen = New System.Windows.Forms.Button()
            Me.btnEditOnLock = New System.Windows.Forms.Button()
            Me.btnEditOnMeleeAttacked = New System.Windows.Forms.Button()
            Me.btnEditOnOpen = New System.Windows.Forms.Button()
            Me.btnEditOnUnlock = New System.Windows.Forms.Button()
            Me.TabPageAdvanced = New System.Windows.Forms.TabPage()
            Me.cmbxFaction = New System.Windows.Forms.ComboBox()
            Me.chkbNotInterruptable = New System.Windows.Forms.CheckBox()
            Me.tbConversation = New System.Windows.Forms.TextBox()
            Me.tbTemplateResRef = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.tbAnimationState = New System.Windows.Forms.TextBox()
            Me.TabPageDescription = New System.Windows.Forms.TabPage()
            Me.btnSetDescriptionLang = New System.Windows.Forms.Button()
            Me.tbDescription = New System.Windows.Forms.TextBox()
            Me.TabPageComments = New System.Windows.Forms.TabPage()
            Me.tbComment = New System.Windows.Forms.TextBox()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterRule = New System.Windows.Forms.Label()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderRule = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
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
            Me.TabPageScripts.SuspendLayout()
            Me.TabPageAdvanced.SuspendLayout()
            Me.TabPageDescription.SuspendLayout()
            Me.TabPageComments.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(520, 650)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Controls.Add(Me.btnDebug)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 67)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
            Me.pnlBody.Size = New System.Drawing.Size(520, 521)
            Me.pnlBody.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPageBasic)
            Me.TabControl1.Controls.Add(Me.TabPageLock)
            Me.TabControl1.Controls.Add(Me.TabPageScripts)
            Me.TabControl1.Controls.Add(Me.TabPageAdvanced)
            Me.TabControl1.Controls.Add(Me.TabPageDescription)
            Me.TabControl1.Controls.Add(Me.TabPageComments)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(12, 10)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New System.Drawing.Point(15, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(496, 501)
            Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabIndex = 0
            '
            'TabPageBasic
            '
            Me.TabPageBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.TabPageBasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageBasic.Location = New System.Drawing.Point(4, 22)
            Me.TabPageBasic.Name = "TabPageBasic"
            Me.TabPageBasic.Size = New System.Drawing.Size(488, 475)
            Me.TabPageBasic.TabIndex = 0
            Me.TabPageBasic.Text = "Basic"
            '
            'Label19
            '
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(48, 92)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(80, 19)
            Me.Label19.TabIndex = 12
            Me.Label19.Text = "Door Type"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxDoorType
            '
            Me.cmbxDoorType.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxDoorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxDoorType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxDoorType.Location = New System.Drawing.Point(128, 92)
            Me.cmbxDoorType.Name = "cmbxDoorType"
            Me.cmbxDoorType.Size = New System.Drawing.Size(200, 21)
            Me.cmbxDoorType.TabIndex = 11
            '
            'btnSetNameLang
            '
            Me.btnSetNameLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetNameLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetNameLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetNameLang.Location = New System.Drawing.Point(344, 37)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New System.Drawing.Size(96, 26)
            Me.btnSetNameLang.TabIndex = 9
            Me.btnSetNameLang.Text = "Set Language"
            Me.btnSetNameLang.UseVisualStyleBackColor = False
            '
            'Label5
            '
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(48, 231)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(104, 18)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Fortitude Save"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudWill
            '
            Me.nudWill.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudWill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudWill.Location = New System.Drawing.Point(160, 286)
            Me.nudWill.Name = "nudWill"
            Me.nudWill.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudWill.Size = New System.Drawing.Size(168, 22)
            Me.nudWill.TabIndex = 7
            Me.nudWill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudFort
            '
            Me.nudFort.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudFort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudFort.Location = New System.Drawing.Point(160, 231)
            Me.nudFort.Name = "nudFort"
            Me.nudFort.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudFort.Size = New System.Drawing.Size(168, 22)
            Me.nudFort.TabIndex = 5
            Me.nudFort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudHP
            '
            Me.nudHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudHP.Location = New System.Drawing.Point(160, 203)
            Me.nudHP.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            Me.nudHP.Name = "nudHP"
            Me.nudHP.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudHP.Size = New System.Drawing.Size(168, 22)
            Me.nudHP.TabIndex = 4
            Me.nudHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblTextureVariation
            '
            Me.lblTextureVariation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblTextureVariation.Location = New System.Drawing.Point(48, 286)
            Me.lblTextureVariation.Name = "lblTextureVariation"
            Me.lblTextureVariation.Size = New System.Drawing.Size(96, 19)
            Me.lblTextureVariation.TabIndex = 5
            Me.lblTextureVariation.Text = "Will Save"
            Me.lblTextureVariation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(48, 203)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(88, 19)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Hit Points"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudHardness
            '
            Me.nudHardness.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudHardness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudHardness.Location = New System.Drawing.Point(160, 175)
            Me.nudHardness.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudHardness.Name = "nudHardness"
            Me.nudHardness.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudHardness.Size = New System.Drawing.Size(168, 22)
            Me.nudHardness.TabIndex = 3
            Me.nudHardness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudRef
            '
            Me.nudRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudRef.Location = New System.Drawing.Point(160, 258)
            Me.nudRef.Name = "nudRef"
            Me.nudRef.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudRef.Size = New System.Drawing.Size(168, 22)
            Me.nudRef.TabIndex = 6
            Me.nudRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label12
            '
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(48, 175)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(88, 19)
            Me.Label12.TabIndex = 7
            Me.Label12.Text = "Hardness"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblBodyVariation
            '
            Me.lblBodyVariation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblBodyVariation.Location = New System.Drawing.Point(48, 258)
            Me.lblBodyVariation.Name = "lblBodyVariation"
            Me.lblBodyVariation.Size = New System.Drawing.Size(88, 19)
            Me.lblBodyVariation.TabIndex = 6
            Me.lblBodyVariation.Text = "Reflex Save"
            Me.lblBodyVariation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbPlotItem
            '
            Me.chkbPlotItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbPlotItem.Location = New System.Drawing.Point(48, 129)
            Me.chkbPlotItem.Name = "chkbPlotItem"
            Me.chkbPlotItem.Size = New System.Drawing.Size(88, 28)
            Me.chkbPlotItem.TabIndex = 2
            Me.chkbPlotItem.Text = "Plot item"
            '
            'tbTag
            '
            Me.tbTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTag.Location = New System.Drawing.Point(128, 65)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(200, 22)
            Me.tbTag.TabIndex = 1
            '
            'tbName
            '
            Me.tbName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbName.Location = New System.Drawing.Point(128, 37)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New System.Drawing.Size(200, 22)
            Me.tbName.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(48, 37)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Name"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(48, 65)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 18)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbStatic
            '
            Me.chkbStatic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbStatic.Location = New System.Drawing.Point(192, 129)
            Me.chkbStatic.Name = "chkbStatic"
            Me.chkbStatic.Size = New System.Drawing.Size(72, 28)
            Me.chkbStatic.TabIndex = 2
            Me.chkbStatic.Text = "Static"
            '
            'TabPageLock
            '
            Me.TabPageLock.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.TabPageLock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageLock.Location = New System.Drawing.Point(4, 22)
            Me.TabPageLock.Name = "TabPageLock"
            Me.TabPageLock.Size = New System.Drawing.Size(488, 475)
            Me.TabPageLock.TabIndex = 1
            Me.TabPageLock.Text = "Lock"
            '
            'cmbxOpenState
            '
            Me.cmbxOpenState.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxOpenState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxOpenState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxOpenState.Items.AddRange(New Object() {"Closed", "Opened"})
            Me.cmbxOpenState.Location = New System.Drawing.Point(176, 144)
            Me.cmbxOpenState.Name = "cmbxOpenState"
            Me.cmbxOpenState.Size = New System.Drawing.Size(121, 21)
            Me.cmbxOpenState.TabIndex = 3
            '
            'tbKeyName
            '
            Me.tbKeyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbKeyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbKeyName.Enabled = False
            Me.tbKeyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbKeyName.Location = New System.Drawing.Point(176, 351)
            Me.tbKeyName.Name = "tbKeyName"
            Me.tbKeyName.Size = New System.Drawing.Size(200, 22)
            Me.tbKeyName.TabIndex = 8
            '
            'lblKeyTag
            '
            Me.lblKeyTag.Enabled = False
            Me.lblKeyTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblKeyTag.Location = New System.Drawing.Point(52, 351)
            Me.lblKeyTag.Name = "lblKeyTag"
            Me.lblKeyTag.Size = New System.Drawing.Size(100, 18)
            Me.lblKeyTag.TabIndex = 18
            Me.lblKeyTag.Text = "Key Tag"
            Me.lblKeyTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudCloseLockDC
            '
            Me.nudCloseLockDC.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCloseLockDC.Enabled = False
            Me.nudCloseLockDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCloseLockDC.Location = New System.Drawing.Point(176, 240)
            Me.nudCloseLockDC.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCloseLockDC.Name = "nudCloseLockDC"
            Me.nudCloseLockDC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudCloseLockDC.Size = New System.Drawing.Size(121, 22)
            Me.nudCloseLockDC.TabIndex = 5
            Me.nudCloseLockDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCloseLockDC
            '
            Me.lblCloseLockDC.Enabled = False
            Me.lblCloseLockDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblCloseLockDC.Location = New System.Drawing.Point(48, 240)
            Me.lblCloseLockDC.Name = "lblCloseLockDC"
            Me.lblCloseLockDC.Size = New System.Drawing.Size(104, 18)
            Me.lblCloseLockDC.TabIndex = 14
            Me.lblCloseLockDC.Text = "Close Lock DC"
            Me.lblCloseLockDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudOpenLockDC
            '
            Me.nudOpenLockDC.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudOpenLockDC.Enabled = False
            Me.nudOpenLockDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudOpenLockDC.Location = New System.Drawing.Point(176, 194)
            Me.nudOpenLockDC.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudOpenLockDC.Name = "nudOpenLockDC"
            Me.nudOpenLockDC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudOpenLockDC.Size = New System.Drawing.Size(121, 22)
            Me.nudOpenLockDC.TabIndex = 4
            Me.nudOpenLockDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblOpenLockDC
            '
            Me.lblOpenLockDC.Enabled = False
            Me.lblOpenLockDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblOpenLockDC.Location = New System.Drawing.Point(48, 194)
            Me.lblOpenLockDC.Name = "lblOpenLockDC"
            Me.lblOpenLockDC.Size = New System.Drawing.Size(104, 18)
            Me.lblOpenLockDC.TabIndex = 15
            Me.lblOpenLockDC.Text = "Open Lock DC"
            Me.lblOpenLockDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbLockable
            '
            Me.chkbLockable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbLockable.Location = New System.Drawing.Point(48, 65)
            Me.chkbLockable.Name = "chkbLockable"
            Me.chkbLockable.Size = New System.Drawing.Size(128, 27)
            Me.chkbLockable.TabIndex = 1
            Me.chkbLockable.Text = "Can be relocked"
            '
            'chkbLocked
            '
            Me.chkbLocked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbLocked.Location = New System.Drawing.Point(48, 37)
            Me.chkbLocked.Name = "chkbLocked"
            Me.chkbLocked.Size = New System.Drawing.Size(88, 28)
            Me.chkbLocked.TabIndex = 0
            Me.chkbLocked.Text = "Locked"
            '
            'chkbKeyRequired
            '
            Me.chkbKeyRequired.Enabled = False
            Me.chkbKeyRequired.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbKeyRequired.Location = New System.Drawing.Point(48, 305)
            Me.chkbKeyRequired.Name = "chkbKeyRequired"
            Me.chkbKeyRequired.Size = New System.Drawing.Size(184, 27)
            Me.chkbKeyRequired.TabIndex = 7
            Me.chkbKeyRequired.Text = "Key required to unlock or lock"
            '
            'chkbAutoRemoveKey
            '
            Me.chkbAutoRemoveKey.Enabled = False
            Me.chkbAutoRemoveKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAutoRemoveKey.Location = New System.Drawing.Point(48, 277)
            Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
            Me.chkbAutoRemoveKey.Size = New System.Drawing.Size(224, 28)
            Me.chkbAutoRemoveKey.TabIndex = 6
            Me.chkbAutoRemoveKey.Text = "Automatically remove key after use"
            '
            'lblOpenState
            '
            Me.lblOpenState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblOpenState.Location = New System.Drawing.Point(48, 148)
            Me.lblOpenState.Name = "lblOpenState"
            Me.lblOpenState.Size = New System.Drawing.Size(88, 18)
            Me.lblOpenState.TabIndex = 15
            Me.lblOpenState.Text = "Door State"
            Me.lblOpenState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbNotBlastable
            '
            Me.chkbNotBlastable.Enabled = False
            Me.chkbNotBlastable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbNotBlastable.Location = New System.Drawing.Point(48, 92)
            Me.chkbNotBlastable.Name = "chkbNotBlastable"
            Me.chkbNotBlastable.Size = New System.Drawing.Size(112, 28)
            Me.chkbNotBlastable.TabIndex = 2
            Me.chkbNotBlastable.Text = "Not Blastable"
            '
            'TabPageScripts
            '
            Me.TabPageScripts.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.TabPageScripts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageScripts.Location = New System.Drawing.Point(4, 22)
            Me.TabPageScripts.Name = "TabPageScripts"
            Me.TabPageScripts.Size = New System.Drawing.Size(488, 475)
            Me.TabPageScripts.TabIndex = 4
            Me.TabPageScripts.Text = "Scripts"
            '
            'btnEditOnUserDefined
            '
            Me.btnEditOnUserDefined.Location = New System.Drawing.Point(392, 429)
            Me.btnEditOnUserDefined.Name = "btnEditOnUserDefined"
            Me.btnEditOnUserDefined.Size = New System.Drawing.Size(40, 27)
            Me.btnEditOnUserDefined.TabIndex = 36
            Me.btnEditOnUserDefined.Text = "Edit"
            '
            'btnEditOnHeartbeat
            '
            Me.btnEditOnHeartbeat.Location = New System.Drawing.Point(392, 203)
            Me.btnEditOnHeartbeat.Name = "btnEditOnHeartbeat"
            Me.btnEditOnHeartbeat.Size = New System.Drawing.Size(40, 27)
            Me.btnEditOnHeartbeat.TabIndex = 35
            Me.btnEditOnHeartbeat.Text = "Edit"
            '
            'btnEditOnSpellCastAt
            '
            Me.btnEditOnSpellCastAt.Location = New System.Drawing.Point(392, 332)
            Me.btnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt"
            Me.btnEditOnSpellCastAt.Size = New System.Drawing.Size(40, 27)
            Me.btnEditOnSpellCastAt.TabIndex = 34
            Me.btnEditOnSpellCastAt.Text = "Edit"
            '
            'btnEditOnDeath
            '
            Me.btnEditOnDeath.Location = New System.Drawing.Point(392, 106)
            Me.btnEditOnDeath.Name = "btnEditOnDeath"
            Me.btnEditOnDeath.Size = New System.Drawing.Size(40, 27)
            Me.btnEditOnDeath.TabIndex = 33
            Me.btnEditOnDeath.Text = "Edit"
            '
            'btnEditOnDamaged
            '
            Me.btnEditOnDamaged.Location = New System.Drawing.Point(392, 74)
            Me.btnEditOnDamaged.Name = "btnEditOnDamaged"
            Me.btnEditOnDamaged.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnDamaged.TabIndex = 32
            Me.btnEditOnDamaged.Text = "Edit"
            '
            'btnEditOnTrapTriggered
            '
            Me.btnEditOnTrapTriggered.Location = New System.Drawing.Point(392, 365)
            Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
            Me.btnEditOnTrapTriggered.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnTrapTriggered.TabIndex = 31
            Me.btnEditOnTrapTriggered.Text = "Edit"
            '
            'btnEditOnDisarm
            '
            Me.btnEditOnDisarm.Location = New System.Drawing.Point(392, 138)
            Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
            Me.btnEditOnDisarm.Size = New System.Drawing.Size(40, 27)
            Me.btnEditOnDisarm.TabIndex = 30
            Me.btnEditOnDisarm.Text = "Edit"
            '
            'btnEditOnClick
            '
            Me.btnEditOnClick.Location = New System.Drawing.Point(392, 9)
            Me.btnEditOnClick.Name = "btnEditOnClick"
            Me.btnEditOnClick.Size = New System.Drawing.Size(40, 27)
            Me.btnEditOnClick.TabIndex = 29
            Me.btnEditOnClick.Text = "Edit"
            '
            'Label34
            '
            Me.Label34.Location = New System.Drawing.Point(40, 106)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(112, 21)
            Me.Label34.TabIndex = 27
            Me.Label34.Text = "OnDeath"
            Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDeath
            '
            Me.tbOnDeath.Location = New System.Drawing.Point(160, 106)
            Me.tbOnDeath.Name = "tbOnDeath"
            Me.tbOnDeath.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDeath.TabIndex = 3
            '
            'Label33
            '
            Me.Label33.Location = New System.Drawing.Point(40, 74)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(112, 21)
            Me.Label33.TabIndex = 17
            Me.Label33.Text = "OnDamaged"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDamaged
            '
            Me.tbOnDamaged.Location = New System.Drawing.Point(160, 74)
            Me.tbOnDamaged.Name = "tbOnDamaged"
            Me.tbOnDamaged.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDamaged.TabIndex = 2
            '
            'Label32
            '
            Me.Label32.Location = New System.Drawing.Point(40, 42)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(112, 20)
            Me.Label32.TabIndex = 14
            Me.Label32.Text = "OnClosed"
            Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnClosed
            '
            Me.tbOnClosed.Location = New System.Drawing.Point(160, 42)
            Me.tbOnClosed.Name = "tbOnClosed"
            Me.tbOnClosed.Size = New System.Drawing.Size(204, 22)
            Me.tbOnClosed.TabIndex = 1
            '
            'Label35
            '
            Me.Label35.Location = New System.Drawing.Point(40, 138)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(112, 21)
            Me.Label35.TabIndex = 26
            Me.Label35.Text = "OnDisarm"
            Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDisarm
            '
            Me.tbOnDisarm.Location = New System.Drawing.Point(160, 138)
            Me.tbOnDisarm.Name = "tbOnDisarm"
            Me.tbOnDisarm.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDisarm.TabIndex = 4
            '
            'tbOnHeartbeat
            '
            Me.tbOnHeartbeat.Location = New System.Drawing.Point(160, 203)
            Me.tbOnHeartbeat.Name = "tbOnHeartbeat"
            Me.tbOnHeartbeat.Size = New System.Drawing.Size(204, 22)
            Me.tbOnHeartbeat.TabIndex = 6
            '
            'Label36
            '
            Me.Label36.Location = New System.Drawing.Point(40, 203)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(112, 21)
            Me.Label36.TabIndex = 25
            Me.Label36.Text = "OnHeartbeat"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label37
            '
            Me.Label37.Location = New System.Drawing.Point(40, 235)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(112, 21)
            Me.Label37.TabIndex = 28
            Me.Label37.Text = "OnLock"
            Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnLock
            '
            Me.tbOnLock.Location = New System.Drawing.Point(160, 235)
            Me.tbOnLock.Name = "tbOnLock"
            Me.tbOnLock.Size = New System.Drawing.Size(204, 22)
            Me.tbOnLock.TabIndex = 7
            '
            'tbOnMeleeAttacked
            '
            Me.tbOnMeleeAttacked.Location = New System.Drawing.Point(160, 268)
            Me.tbOnMeleeAttacked.Name = "tbOnMeleeAttacked"
            Me.tbOnMeleeAttacked.Size = New System.Drawing.Size(204, 22)
            Me.tbOnMeleeAttacked.TabIndex = 8
            '
            'Label38
            '
            Me.Label38.Location = New System.Drawing.Point(40, 268)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(112, 20)
            Me.Label38.TabIndex = 20
            Me.Label38.Text = "OnMeleeAttacked"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnOpen
            '
            Me.tbOnOpen.Location = New System.Drawing.Point(160, 300)
            Me.tbOnOpen.Name = "tbOnOpen"
            Me.tbOnOpen.Size = New System.Drawing.Size(204, 22)
            Me.tbOnOpen.TabIndex = 9
            '
            'Label39
            '
            Me.Label39.Location = New System.Drawing.Point(40, 300)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(112, 21)
            Me.Label39.TabIndex = 21
            Me.Label39.Text = "OnOpen"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label40
            '
            Me.Label40.Location = New System.Drawing.Point(40, 332)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(112, 21)
            Me.Label40.TabIndex = 19
            Me.Label40.Text = "OnSpellCastAt"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnSpellCastAt
            '
            Me.tbOnSpellCastAt.Location = New System.Drawing.Point(160, 332)
            Me.tbOnSpellCastAt.Name = "tbOnSpellCastAt"
            Me.tbOnSpellCastAt.Size = New System.Drawing.Size(204, 22)
            Me.tbOnSpellCastAt.TabIndex = 10
            '
            'Label41
            '
            Me.Label41.Location = New System.Drawing.Point(40, 365)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(112, 20)
            Me.Label41.TabIndex = 24
            Me.Label41.Text = "OnTrapTriggered"
            Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnTrapTriggered
            '
            Me.tbOnTrapTriggered.Location = New System.Drawing.Point(160, 365)
            Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
            Me.tbOnTrapTriggered.Size = New System.Drawing.Size(204, 22)
            Me.tbOnTrapTriggered.TabIndex = 11
            '
            'tbOnUnlock
            '
            Me.tbOnUnlock.Location = New System.Drawing.Point(160, 397)
            Me.tbOnUnlock.Name = "tbOnUnlock"
            Me.tbOnUnlock.Size = New System.Drawing.Size(204, 22)
            Me.tbOnUnlock.TabIndex = 12
            '
            'Label42
            '
            Me.Label42.Location = New System.Drawing.Point(40, 397)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(112, 21)
            Me.Label42.TabIndex = 23
            Me.Label42.Text = "OnUnlock"
            Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnUserDefined
            '
            Me.tbOnUserDefined.Location = New System.Drawing.Point(160, 429)
            Me.tbOnUserDefined.Name = "tbOnUserDefined"
            Me.tbOnUserDefined.Size = New System.Drawing.Size(204, 22)
            Me.tbOnUserDefined.TabIndex = 13
            '
            'Label43
            '
            Me.Label43.Location = New System.Drawing.Point(40, 429)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(112, 21)
            Me.Label43.TabIndex = 22
            Me.Label43.Text = "OnUserDefined"
            Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnClick
            '
            Me.tbOnClick.Location = New System.Drawing.Point(160, 9)
            Me.tbOnClick.Name = "tbOnClick"
            Me.tbOnClick.Size = New System.Drawing.Size(204, 22)
            Me.tbOnClick.TabIndex = 0
            '
            'Label9
            '
            Me.Label9.Location = New System.Drawing.Point(40, 9)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(112, 21)
            Me.Label9.TabIndex = 23
            Me.Label9.Text = "OnClick"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.Location = New System.Drawing.Point(40, 171)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(112, 21)
            Me.Label7.TabIndex = 22
            Me.Label7.Text = "OnFailToOpen"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnFailToOpen
            '
            Me.tbOnFailToOpen.Location = New System.Drawing.Point(160, 171)
            Me.tbOnFailToOpen.Name = "tbOnFailToOpen"
            Me.tbOnFailToOpen.Size = New System.Drawing.Size(204, 22)
            Me.tbOnFailToOpen.TabIndex = 5
            '
            'btnEditOnClosed
            '
            Me.btnEditOnClosed.Location = New System.Drawing.Point(392, 42)
            Me.btnEditOnClosed.Name = "btnEditOnClosed"
            Me.btnEditOnClosed.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnClosed.TabIndex = 29
            Me.btnEditOnClosed.Text = "Edit"
            '
            'btnEditOnFailToOpen
            '
            Me.btnEditOnFailToOpen.Location = New System.Drawing.Point(392, 171)
            Me.btnEditOnFailToOpen.Name = "btnEditOnFailToOpen"
            Me.btnEditOnFailToOpen.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnFailToOpen.TabIndex = 30
            Me.btnEditOnFailToOpen.Text = "Edit"
            '
            'btnEditOnLock
            '
            Me.btnEditOnLock.Location = New System.Drawing.Point(392, 235)
            Me.btnEditOnLock.Name = "btnEditOnLock"
            Me.btnEditOnLock.Size = New System.Drawing.Size(40, 27)
            Me.btnEditOnLock.TabIndex = 35
            Me.btnEditOnLock.Text = "Edit"
            '
            'btnEditOnMeleeAttacked
            '
            Me.btnEditOnMeleeAttacked.Location = New System.Drawing.Point(392, 268)
            Me.btnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked"
            Me.btnEditOnMeleeAttacked.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnMeleeAttacked.TabIndex = 35
            Me.btnEditOnMeleeAttacked.Text = "Edit"
            '
            'btnEditOnOpen
            '
            Me.btnEditOnOpen.Location = New System.Drawing.Point(392, 300)
            Me.btnEditOnOpen.Name = "btnEditOnOpen"
            Me.btnEditOnOpen.Size = New System.Drawing.Size(40, 27)
            Me.btnEditOnOpen.TabIndex = 35
            Me.btnEditOnOpen.Text = "Edit"
            '
            'btnEditOnUnlock
            '
            Me.btnEditOnUnlock.Location = New System.Drawing.Point(392, 397)
            Me.btnEditOnUnlock.Name = "btnEditOnUnlock"
            Me.btnEditOnUnlock.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnUnlock.TabIndex = 31
            Me.btnEditOnUnlock.Text = "Edit"
            '
            'TabPageAdvanced
            '
            Me.TabPageAdvanced.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPageAdvanced.Controls.Add(Me.cmbxFaction)
            Me.TabPageAdvanced.Controls.Add(Me.chkbNotInterruptable)
            Me.TabPageAdvanced.Controls.Add(Me.tbConversation)
            Me.TabPageAdvanced.Controls.Add(Me.tbTemplateResRef)
            Me.TabPageAdvanced.Controls.Add(Me.Label10)
            Me.TabPageAdvanced.Controls.Add(Me.Label11)
            Me.TabPageAdvanced.Controls.Add(Me.Label13)
            Me.TabPageAdvanced.Controls.Add(Me.Label14)
            Me.TabPageAdvanced.Controls.Add(Me.tbAnimationState)
            Me.TabPageAdvanced.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageAdvanced.Location = New System.Drawing.Point(4, 22)
            Me.TabPageAdvanced.Name = "TabPageAdvanced"
            Me.TabPageAdvanced.Size = New System.Drawing.Size(488, 475)
            Me.TabPageAdvanced.TabIndex = 5
            Me.TabPageAdvanced.Text = "Advanced"
            '
            'cmbxFaction
            '
            Me.cmbxFaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxFaction.Location = New System.Drawing.Point(168, 92)
            Me.cmbxFaction.Name = "cmbxFaction"
            Me.cmbxFaction.Size = New System.Drawing.Size(120, 21)
            Me.cmbxFaction.TabIndex = 4
            '
            'chkbNotInterruptable
            '
            Me.chkbNotInterruptable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbNotInterruptable.Location = New System.Drawing.Point(352, 157)
            Me.chkbNotInterruptable.Name = "chkbNotInterruptable"
            Me.chkbNotInterruptable.Size = New System.Drawing.Size(104, 28)
            Me.chkbNotInterruptable.TabIndex = 2
            Me.chkbNotInterruptable.Text = "No Interrupt"
            '
            'tbConversation
            '
            Me.tbConversation.Location = New System.Drawing.Point(168, 157)
            Me.tbConversation.Name = "tbConversation"
            Me.tbConversation.Size = New System.Drawing.Size(168, 22)
            Me.tbConversation.TabIndex = 1
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
            Me.Label13.Location = New System.Drawing.Point(56, 157)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(100, 18)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Conversation"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label14
            '
            Me.Label14.Location = New System.Drawing.Point(56, 212)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(100, 19)
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Animation State"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbAnimationState
            '
            Me.tbAnimationState.Location = New System.Drawing.Point(168, 212)
            Me.tbAnimationState.Name = "tbAnimationState"
            Me.tbAnimationState.Size = New System.Drawing.Size(32, 22)
            Me.tbAnimationState.TabIndex = 3
            '
            'TabPageDescription
            '
            Me.TabPageDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPageDescription.Controls.Add(Me.btnSetDescriptionLang)
            Me.TabPageDescription.Controls.Add(Me.tbDescription)
            Me.TabPageDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageDescription.Location = New System.Drawing.Point(4, 22)
            Me.TabPageDescription.Name = "TabPageDescription"
            Me.TabPageDescription.Size = New System.Drawing.Size(488, 475)
            Me.TabPageDescription.TabIndex = 6
            Me.TabPageDescription.Text = "Description"
            '
            'btnSetDescriptionLang
            '
            Me.btnSetDescriptionLang.Location = New System.Drawing.Point(40, 369)
            Me.btnSetDescriptionLang.Name = "btnSetDescriptionLang"
            Me.btnSetDescriptionLang.Size = New System.Drawing.Size(96, 27)
            Me.btnSetDescriptionLang.TabIndex = 5
            Me.btnSetDescriptionLang.Text = "Set Language"
            '
            'tbDescription
            '
            Me.tbDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDescription.Location = New System.Drawing.Point(12, 8)
            Me.tbDescription.Multiline = True
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Size = New System.Drawing.Size(464, 348)
            Me.tbDescription.TabIndex = 1
            '
            'TabPageComments
            '
            Me.TabPageComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPageComments.Controls.Add(Me.tbComment)
            Me.TabPageComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageComments.Location = New System.Drawing.Point(4, 22)
            Me.TabPageComments.Name = "TabPageComments"
            Me.TabPageComments.Size = New System.Drawing.Size(488, 475)
            Me.TabPageComments.TabIndex = 7
            Me.TabPageComments.Text = "Comments"
            '
            'tbComment
            '
            Me.tbComment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbComment.Location = New System.Drawing.Point(12, 8)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.Size = New System.Drawing.Size(464, 384)
            Me.tbComment.TabIndex = 0
            '
            'btnDebug
            '
            Me.btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnDebug.Location = New System.Drawing.Point(0, 87)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 9)
            Me.btnDebug.TabIndex = 18
            Me.btnDebug.TabStop = False
            Me.btnDebug.UseVisualStyleBackColor = False
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterRule)
            Me.pnlFooter.Controls.Add(Me.btnSave)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 588)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(520, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(520, 1)
            Me.lblFooterRule.TabIndex = 0
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSave.Location = New System.Drawing.Point(328, 18)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(80, 29)
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "&Save"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(424, 18)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(80, 29)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
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
            Me.pnlHeader.Size = New System.Drawing.Size(520, 67)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(18, 12)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(360, 23)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Door Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(20, 37)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(480, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Restored KoTOR Tool door editor."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 65)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(520, 2)
            Me.lblHeaderRule.TabIndex = 2
            '
            'frmUTD_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(520, 650)
            Me.Controls.Add(Me.pnlRoot)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(528, 668)
            Me.Name = "frmUTD_Editor"
            Me.Text = "Door Editor - KotOR "
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
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
            Me.TabPageScripts.ResumeLayout(False)
            Me.TabPageScripts.PerformLayout()
            Me.TabPageAdvanced.ResumeLayout(False)
            Me.TabPageAdvanced.PerformLayout()
            Me.TabPageDescription.ResumeLayout(False)
            Me.TabPageDescription.PerformLayout()
            Me.TabPageComments.ResumeLayout(False)
            Me.TabPageComments.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
