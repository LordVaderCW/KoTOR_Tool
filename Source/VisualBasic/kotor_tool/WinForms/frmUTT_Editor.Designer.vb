Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmUTT_Editor
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
        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x060016C4 RID: 5828 RVA: 0x002C6FFC File Offset: 0x002C5FFC
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPageBasic = New System.Windows.Forms.TabPage()
            Me.cmbxType = New System.Windows.Forms.ComboBox()
            Me.cmbxFaction = New System.Windows.Forms.ComboBox()
            Me.btnSetNameLang = New System.Windows.Forms.Button()
            Me.tbName = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.tbTemplateResRef = New System.Windows.Forms.TextBox()
            Me.Label57 = New System.Windows.Forms.Label()
            Me.tbTag = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.tbCursor = New System.Windows.Forms.TextBox()
            Me.TabPageScripts = New System.Windows.Forms.TabPage()
            Me.btnEditScriptOnEnter = New System.Windows.Forms.Button()
            Me.tbScriptHeartbeat = New System.Windows.Forms.TextBox()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.tbScriptOnEnter = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.tbScriptOnExit = New System.Windows.Forms.TextBox()
            Me.tbScriptUserDefine = New System.Windows.Forms.TextBox()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.tbOnDisarm = New System.Windows.Forms.TextBox()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.tbOnTrapTriggered = New System.Windows.Forms.TextBox()
            Me.tbOnClick = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.btnEditScriptOnExit = New System.Windows.Forms.Button()
            Me.btnEditScriptUserDefine = New System.Windows.Forms.Button()
            Me.btnEditScriptHeartbeat = New System.Windows.Forms.Button()
            Me.btnEditOnTrapTriggered = New System.Windows.Forms.Button()
            Me.btnEditOnDisarm = New System.Windows.Forms.Button()
            Me.btnEditOnClick = New System.Windows.Forms.Button()
            Me.TabPageTrap = New System.Windows.Forms.TabPage()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.chkbAutoRemoveKey = New System.Windows.Forms.CheckBox()
            Me.tbKeyName = New System.Windows.Forms.TextBox()
            Me.chkbTrapDisarmable = New System.Windows.Forms.CheckBox()
            Me.chkbTrapDetectable = New System.Windows.Forms.CheckBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.nudDisarmDC = New System.Windows.Forms.NumericUpDown()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.nudTrapDetectDC = New System.Windows.Forms.NumericUpDown()
            Me.lblCloseLockDC = New System.Windows.Forms.Label()
            Me.lblTrapDetectable = New System.Windows.Forms.Label()
            Me.nudTrapType = New System.Windows.Forms.NumericUpDown()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.chkbTrapFlag = New System.Windows.Forms.CheckBox()
            Me.chkbTrapOneShot = New System.Windows.Forms.CheckBox()
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
            Me.TabPageScripts.SuspendLayout()
            Me.TabPageTrap.SuspendLayout()
            CType(Me.nudDisarmDC, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTrapDetectDC, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTrapType, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.pnlRoot.Size = New System.Drawing.Size(504, 551)
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
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(16, 12, 16, 10)
            Me.pnlBody.Size = New System.Drawing.Size(504, 422)
            Me.pnlBody.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPageBasic)
            Me.TabControl1.Controls.Add(Me.TabPageScripts)
            Me.TabControl1.Controls.Add(Me.TabPageTrap)
            Me.TabControl1.Controls.Add(Me.TabPageComments)
            Me.TabControl1.Location = New System.Drawing.Point(16, 14)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(472, 396)
            Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabIndex = 0
            '
            'TabPageBasic
            '
            Me.TabPageBasic.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.TabPageBasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageBasic.Location = New System.Drawing.Point(4, 22)
            Me.TabPageBasic.Name = "TabPageBasic"
            Me.TabPageBasic.Size = New System.Drawing.Size(464, 370)
            Me.TabPageBasic.TabIndex = 0
            Me.TabPageBasic.Text = "Basic"
            '
            'cmbxType
            '
            Me.cmbxType.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxType.Items.AddRange(New Object() {"Generic", "Transition", "Trap"})
            Me.cmbxType.Location = New System.Drawing.Point(160, 175)
            Me.cmbxType.Name = "cmbxType"
            Me.cmbxType.Size = New System.Drawing.Size(176, 21)
            Me.cmbxType.TabIndex = 10
            '
            'cmbxFaction
            '
            Me.cmbxFaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxFaction.Location = New System.Drawing.Point(160, 138)
            Me.cmbxFaction.Name = "cmbxFaction"
            Me.cmbxFaction.Size = New System.Drawing.Size(176, 21)
            Me.cmbxFaction.TabIndex = 9
            '
            'btnSetNameLang
            '
            Me.btnSetNameLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSetNameLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetNameLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSetNameLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetNameLang.Location = New System.Drawing.Point(344, 65)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New System.Drawing.Size(96, 26)
            Me.btnSetNameLang.TabIndex = 1
            Me.btnSetNameLang.Text = "Set Language"
            Me.btnSetNameLang.UseVisualStyleBackColor = False
            '
            'tbName
            '
            Me.tbName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbName.Location = New System.Drawing.Point(160, 65)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New System.Drawing.Size(176, 22)
            Me.tbName.TabIndex = 0
            '
            'Label11
            '
            Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(48, 65)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(100, 18)
            Me.Label11.TabIndex = 8
            Me.Label11.Text = "Name"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbTemplateResRef
            '
            Me.tbTemplateResRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTemplateResRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTemplateResRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbTemplateResRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTemplateResRef.Location = New System.Drawing.Point(160, 28)
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Me.tbTemplateResRef.Size = New System.Drawing.Size(176, 22)
            Me.tbTemplateResRef.TabIndex = 6
            '
            'Label57
            '
            Me.Label57.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label57.Location = New System.Drawing.Point(48, 28)
            Me.Label57.Name = "Label57"
            Me.Label57.Size = New System.Drawing.Size(100, 20)
            Me.Label57.TabIndex = 5
            Me.Label57.Text = "Template ResRef"
            Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbTag
            '
            Me.tbTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTag.Location = New System.Drawing.Point(160, 102)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(176, 22)
            Me.tbTag.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(48, 102)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 18)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(48, 138)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(80, 19)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Faction"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(48, 175)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(80, 19)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Type"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label14
            '
            Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(48, 212)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(80, 19)
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Cursor"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbCursor
            '
            Me.tbCursor.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCursor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCursor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCursor.Location = New System.Drawing.Point(160, 212)
            Me.tbCursor.Name = "tbCursor"
            Me.tbCursor.Size = New System.Drawing.Size(30, 22)
            Me.tbCursor.TabIndex = 4
            '
            'TabPageScripts
            '
            Me.TabPageScripts.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.TabPageScripts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageScripts.Location = New System.Drawing.Point(4, 22)
            Me.TabPageScripts.Name = "TabPageScripts"
            Me.TabPageScripts.Size = New System.Drawing.Size(464, 370)
            Me.TabPageScripts.TabIndex = 1
            Me.TabPageScripts.Text = "Scripts"
            '
            'btnEditScriptOnEnter
            '
            Me.btnEditScriptOnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnEditScriptOnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnEditScriptOnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnEditScriptOnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnEditScriptOnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditScriptOnEnter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditScriptOnEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditScriptOnEnter.Location = New System.Drawing.Point(392, 175)
            Me.btnEditScriptOnEnter.Name = "btnEditScriptOnEnter"
            Me.btnEditScriptOnEnter.Size = New System.Drawing.Size(40, 27)
            Me.btnEditScriptOnEnter.TabIndex = 9
            Me.btnEditScriptOnEnter.Text = "Edit"
            Me.btnEditScriptOnEnter.UseVisualStyleBackColor = False
            '
            'tbScriptHeartbeat
            '
            Me.tbScriptHeartbeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbScriptHeartbeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbScriptHeartbeat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbScriptHeartbeat.Location = New System.Drawing.Point(168, 138)
            Me.tbScriptHeartbeat.Name = "tbScriptHeartbeat"
            Me.tbScriptHeartbeat.Size = New System.Drawing.Size(204, 22)
            Me.tbScriptHeartbeat.TabIndex = 6
            '
            'Label39
            '
            Me.Label39.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label39.Location = New System.Drawing.Point(48, 138)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(112, 21)
            Me.Label39.TabIndex = 39
            Me.Label39.Text = "ScriptHeartbeat"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label40
            '
            Me.Label40.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label40.Location = New System.Drawing.Point(48, 175)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(112, 21)
            Me.Label40.TabIndex = 38
            Me.Label40.Text = "ScriptOnEnter"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbScriptOnEnter
            '
            Me.tbScriptOnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbScriptOnEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbScriptOnEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbScriptOnEnter.Location = New System.Drawing.Point(168, 175)
            Me.tbScriptOnEnter.Name = "tbScriptOnEnter"
            Me.tbScriptOnEnter.Size = New System.Drawing.Size(204, 22)
            Me.tbScriptOnEnter.TabIndex = 8
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(48, 212)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(112, 21)
            Me.Label3.TabIndex = 40
            Me.Label3.Text = "ScriptOnExit"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbScriptOnExit
            '
            Me.tbScriptOnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbScriptOnExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbScriptOnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbScriptOnExit.Location = New System.Drawing.Point(168, 212)
            Me.tbScriptOnExit.Name = "tbScriptOnExit"
            Me.tbScriptOnExit.Size = New System.Drawing.Size(204, 22)
            Me.tbScriptOnExit.TabIndex = 10
            '
            'tbScriptUserDefine
            '
            Me.tbScriptUserDefine.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbScriptUserDefine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbScriptUserDefine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbScriptUserDefine.Location = New System.Drawing.Point(168, 249)
            Me.tbScriptUserDefine.Name = "tbScriptUserDefine"
            Me.tbScriptUserDefine.Size = New System.Drawing.Size(204, 22)
            Me.tbScriptUserDefine.TabIndex = 12
            '
            'Label45
            '
            Me.Label45.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label45.Location = New System.Drawing.Point(48, 249)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(112, 21)
            Me.Label45.TabIndex = 33
            Me.Label45.Text = "ScriptUserDefine"
            Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label35
            '
            Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label35.Location = New System.Drawing.Point(48, 65)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(112, 20)
            Me.Label35.TabIndex = 32
            Me.Label35.Text = "OnDisarm"
            Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnDisarm
            '
            Me.tbOnDisarm.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnDisarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnDisarm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnDisarm.Location = New System.Drawing.Point(168, 65)
            Me.tbOnDisarm.Name = "tbOnDisarm"
            Me.tbOnDisarm.Size = New System.Drawing.Size(204, 22)
            Me.tbOnDisarm.TabIndex = 2
            '
            'Label41
            '
            Me.Label41.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label41.Location = New System.Drawing.Point(48, 102)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(112, 20)
            Me.Label41.TabIndex = 31
            Me.Label41.Text = "OnTrapTriggered"
            Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbOnTrapTriggered
            '
            Me.tbOnTrapTriggered.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnTrapTriggered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnTrapTriggered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnTrapTriggered.Location = New System.Drawing.Point(168, 102)
            Me.tbOnTrapTriggered.Name = "tbOnTrapTriggered"
            Me.tbOnTrapTriggered.Size = New System.Drawing.Size(204, 22)
            Me.tbOnTrapTriggered.TabIndex = 4
            '
            'tbOnClick
            '
            Me.tbOnClick.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbOnClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbOnClick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbOnClick.Location = New System.Drawing.Point(168, 28)
            Me.tbOnClick.Name = "tbOnClick"
            Me.tbOnClick.Size = New System.Drawing.Size(204, 22)
            Me.tbOnClick.TabIndex = 0
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(48, 28)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(112, 20)
            Me.Label9.TabIndex = 30
            Me.Label9.Text = "OnClick"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnEditScriptOnExit
            '
            Me.btnEditScriptOnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnEditScriptOnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnEditScriptOnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnEditScriptOnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnEditScriptOnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditScriptOnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditScriptOnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditScriptOnExit.Location = New System.Drawing.Point(392, 212)
            Me.btnEditScriptOnExit.Name = "btnEditScriptOnExit"
            Me.btnEditScriptOnExit.Size = New System.Drawing.Size(40, 27)
            Me.btnEditScriptOnExit.TabIndex = 11
            Me.btnEditScriptOnExit.Text = "Edit"
            Me.btnEditScriptOnExit.UseVisualStyleBackColor = False
            '
            'btnEditScriptUserDefine
            '
            Me.btnEditScriptUserDefine.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnEditScriptUserDefine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnEditScriptUserDefine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnEditScriptUserDefine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnEditScriptUserDefine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditScriptUserDefine.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditScriptUserDefine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditScriptUserDefine.Location = New System.Drawing.Point(392, 249)
            Me.btnEditScriptUserDefine.Name = "btnEditScriptUserDefine"
            Me.btnEditScriptUserDefine.Size = New System.Drawing.Size(40, 27)
            Me.btnEditScriptUserDefine.TabIndex = 13
            Me.btnEditScriptUserDefine.Text = "Edit"
            Me.btnEditScriptUserDefine.UseVisualStyleBackColor = False
            '
            'btnEditScriptHeartbeat
            '
            Me.btnEditScriptHeartbeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnEditScriptHeartbeat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnEditScriptHeartbeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnEditScriptHeartbeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnEditScriptHeartbeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditScriptHeartbeat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditScriptHeartbeat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditScriptHeartbeat.Location = New System.Drawing.Point(392, 138)
            Me.btnEditScriptHeartbeat.Name = "btnEditScriptHeartbeat"
            Me.btnEditScriptHeartbeat.Size = New System.Drawing.Size(40, 27)
            Me.btnEditScriptHeartbeat.TabIndex = 7
            Me.btnEditScriptHeartbeat.Text = "Edit"
            Me.btnEditScriptHeartbeat.UseVisualStyleBackColor = False
            '
            'btnEditOnTrapTriggered
            '
            Me.btnEditOnTrapTriggered.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnEditOnTrapTriggered.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnEditOnTrapTriggered.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnEditOnTrapTriggered.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnEditOnTrapTriggered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnTrapTriggered.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditOnTrapTriggered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnTrapTriggered.Location = New System.Drawing.Point(392, 102)
            Me.btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered"
            Me.btnEditOnTrapTriggered.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnTrapTriggered.TabIndex = 5
            Me.btnEditOnTrapTriggered.Text = "Edit"
            Me.btnEditOnTrapTriggered.UseVisualStyleBackColor = False
            '
            'btnEditOnDisarm
            '
            Me.btnEditOnDisarm.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnEditOnDisarm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnEditOnDisarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnEditOnDisarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnEditOnDisarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnDisarm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditOnDisarm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnDisarm.Location = New System.Drawing.Point(392, 65)
            Me.btnEditOnDisarm.Name = "btnEditOnDisarm"
            Me.btnEditOnDisarm.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnDisarm.TabIndex = 3
            Me.btnEditOnDisarm.Text = "Edit"
            Me.btnEditOnDisarm.UseVisualStyleBackColor = False
            '
            'btnEditOnClick
            '
            Me.btnEditOnClick.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnEditOnClick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnEditOnClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnEditOnClick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnEditOnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditOnClick.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditOnClick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnEditOnClick.Location = New System.Drawing.Point(392, 28)
            Me.btnEditOnClick.Name = "btnEditOnClick"
            Me.btnEditOnClick.Size = New System.Drawing.Size(40, 26)
            Me.btnEditOnClick.TabIndex = 1
            Me.btnEditOnClick.Text = "Edit"
            Me.btnEditOnClick.UseVisualStyleBackColor = False
            '
            'TabPageTrap
            '
            Me.TabPageTrap.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.TabPageTrap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageTrap.Location = New System.Drawing.Point(4, 22)
            Me.TabPageTrap.Name = "TabPageTrap"
            Me.TabPageTrap.Size = New System.Drawing.Size(464, 370)
            Me.TabPageTrap.TabIndex = 9
            Me.TabPageTrap.Text = "Trap"
            '
            'Label15
            '
            Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(249, 254)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(168, 23)
            Me.Label15.TabIndex = 28
            Me.Label15.Text = "This is an index into traps.2da"
            Me.Label15.Visible = False
            '
            'chkbAutoRemoveKey
            '
            Me.chkbAutoRemoveKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbAutoRemoveKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAutoRemoveKey.Location = New System.Drawing.Point(232, 320)
            Me.chkbAutoRemoveKey.Name = "chkbAutoRemoveKey"
            Me.chkbAutoRemoveKey.Size = New System.Drawing.Size(24, 27)
            Me.chkbAutoRemoveKey.TabIndex = 8
            '
            'tbKeyName
            '
            Me.tbKeyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbKeyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbKeyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbKeyName.Location = New System.Drawing.Point(176, 286)
            Me.tbKeyName.Name = "tbKeyName"
            Me.tbKeyName.Size = New System.Drawing.Size(136, 22)
            Me.tbKeyName.TabIndex = 7
            '
            'chkbTrapDisarmable
            '
            Me.chkbTrapDisarmable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbTrapDisarmable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbTrapDisarmable.Location = New System.Drawing.Point(192, 98)
            Me.chkbTrapDisarmable.Name = "chkbTrapDisarmable"
            Me.chkbTrapDisarmable.Size = New System.Drawing.Size(24, 28)
            Me.chkbTrapDisarmable.TabIndex = 2
            '
            'chkbTrapDetectable
            '
            Me.chkbTrapDetectable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbTrapDetectable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbTrapDetectable.Location = New System.Drawing.Point(192, 24)
            Me.chkbTrapDetectable.Name = "chkbTrapDetectable"
            Me.chkbTrapDetectable.Size = New System.Drawing.Size(24, 28)
            Me.chkbTrapDetectable.TabIndex = 0
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(48, 212)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(112, 19)
            Me.Label6.TabIndex = 26
            Me.Label6.Text = "TrapOneShot"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(48, 175)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(112, 19)
            Me.Label7.TabIndex = 27
            Me.Label7.Text = "TrapFlag"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudDisarmDC
            '
            Me.nudDisarmDC.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudDisarmDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudDisarmDC.Location = New System.Drawing.Point(176, 138)
            Me.nudDisarmDC.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudDisarmDC.Name = "nudDisarmDC"
            Me.nudDisarmDC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudDisarmDC.Size = New System.Drawing.Size(48, 22)
            Me.nudDisarmDC.TabIndex = 3
            Me.nudDisarmDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(48, 138)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(112, 19)
            Me.Label4.TabIndex = 22
            Me.Label4.Text = "DisarmDC"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(48, 102)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(112, 18)
            Me.Label5.TabIndex = 23
            Me.Label5.Text = "TrapDisarmable"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudTrapDetectDC
            '
            Me.nudTrapDetectDC.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudTrapDetectDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudTrapDetectDC.Location = New System.Drawing.Point(176, 65)
            Me.nudTrapDetectDC.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
            Me.nudTrapDetectDC.Name = "nudTrapDetectDC"
            Me.nudTrapDetectDC.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudTrapDetectDC.Size = New System.Drawing.Size(48, 22)
            Me.nudTrapDetectDC.TabIndex = 1
            Me.nudTrapDetectDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCloseLockDC
            '
            Me.lblCloseLockDC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCloseLockDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblCloseLockDC.Location = New System.Drawing.Point(48, 65)
            Me.lblCloseLockDC.Name = "lblCloseLockDC"
            Me.lblCloseLockDC.Size = New System.Drawing.Size(112, 18)
            Me.lblCloseLockDC.TabIndex = 18
            Me.lblCloseLockDC.Text = "TrapDetectDC"
            Me.lblCloseLockDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTrapDetectable
            '
            Me.lblTrapDetectable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTrapDetectable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblTrapDetectable.Location = New System.Drawing.Point(48, 28)
            Me.lblTrapDetectable.Name = "lblTrapDetectable"
            Me.lblTrapDetectable.Size = New System.Drawing.Size(112, 18)
            Me.lblTrapDetectable.TabIndex = 19
            Me.lblTrapDetectable.Text = "TrapDetectable"
            Me.lblTrapDetectable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'nudTrapType
            '
            Me.nudTrapType.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudTrapType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudTrapType.Location = New System.Drawing.Point(176, 249)
            Me.nudTrapType.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
            Me.nudTrapType.Name = "nudTrapType"
            Me.nudTrapType.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.nudTrapType.Size = New System.Drawing.Size(48, 22)
            Me.nudTrapType.TabIndex = 6
            Me.nudTrapType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(48, 249)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(112, 19)
            Me.Label8.TabIndex = 26
            Me.Label8.Text = "TrapType"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label12
            '
            Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(48, 286)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(112, 19)
            Me.Label12.TabIndex = 26
            Me.Label12.Text = "KeyName"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label13
            '
            Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(48, 323)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(184, 19)
            Me.Label13.TabIndex = 26
            Me.Label13.Text = "Automatically remove key after use"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbTrapFlag
            '
            Me.chkbTrapFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbTrapFlag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbTrapFlag.Location = New System.Drawing.Point(192, 175)
            Me.chkbTrapFlag.Name = "chkbTrapFlag"
            Me.chkbTrapFlag.Size = New System.Drawing.Size(24, 28)
            Me.chkbTrapFlag.TabIndex = 2
            '
            'chkbTrapOneShot
            '
            Me.chkbTrapOneShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbTrapOneShot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbTrapOneShot.Location = New System.Drawing.Point(192, 212)
            Me.chkbTrapOneShot.Name = "chkbTrapOneShot"
            Me.chkbTrapOneShot.Size = New System.Drawing.Size(24, 28)
            Me.chkbTrapOneShot.TabIndex = 2
            '
            'TabPageComments
            '
            Me.TabPageComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPageComments.Controls.Add(Me.tbComment)
            Me.TabPageComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPageComments.Location = New System.Drawing.Point(4, 22)
            Me.TabPageComments.Name = "TabPageComments"
            Me.TabPageComments.Size = New System.Drawing.Size(464, 370)
            Me.TabPageComments.TabIndex = 8
            Me.TabPageComments.Text = "Comments"
            '
            'tbComment
            '
            Me.tbComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbComment.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbComment.Location = New System.Drawing.Point(0, 0)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbComment.Size = New System.Drawing.Size(464, 370)
            Me.tbComment.TabIndex = 0
            '
            'btnDebug
            '
            Me.btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnDebug.Location = New System.Drawing.Point(0, 32)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 9)
            Me.btnDebug.TabIndex = 17
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
            Me.pnlFooter.Location = New System.Drawing.Point(0, 489)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(504, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(504, 1)
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
            Me.btnSave.Location = New System.Drawing.Point(316, 18)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(80, 29)
            Me.btnSave.TabIndex = 3
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
            Me.btnCancel.Location = New System.Drawing.Point(408, 18)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(80, 29)
            Me.btnCancel.TabIndex = 4
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
            Me.pnlHeader.Size = New System.Drawing.Size(504, 67)
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
            Me.lblTitle.Text = "Trigger Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(20, 37)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(440, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Restored KoTOR Tool trigger properties, scripts, traps, and comments."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 65)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(504, 2)
            Me.lblHeaderRule.TabIndex = 2
            '
            'frmUTT_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(504, 551)
            Me.Controls.Add(Me.pnlRoot)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.MinimumSize = New System.Drawing.Size(512, 550)
            Me.Name = "frmUTT_Editor"
            Me.Text = "Trigger Editor - KotOR "
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPageBasic.ResumeLayout(False)
            Me.TabPageBasic.PerformLayout()
            Me.TabPageScripts.ResumeLayout(False)
            Me.TabPageScripts.PerformLayout()
            Me.TabPageTrap.ResumeLayout(False)
            Me.TabPageTrap.PerformLayout()
            CType(Me.nudDisarmDC, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTrapDetectDC, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTrapType, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPageComments.ResumeLayout(False)
            Me.TabPageComments.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
