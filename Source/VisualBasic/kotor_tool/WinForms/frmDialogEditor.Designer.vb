Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x02000047 RID: 71
    Partial Public Class frmDialogEditor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents tbConversationText As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents tbActionsTakenScript As Global.System.Windows.Forms.TextBox
        Friend WithEvents tvConversation As Global.System.Windows.Forms.TreeView
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents tbSound As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents tbComments As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnCollapseAll As Global.System.Windows.Forms.Button
        Friend WithEvents btnExpandAll As Global.System.Windows.Forms.Button
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents tbListener As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents tbVoiceOverResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents lblPlotIndex As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents btnTest As Global.System.Windows.Forms.Button
        Friend WithEvents btnChooseColor As Global.System.Windows.Forms.Button
        Friend WithEvents cmTVfunctions As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents cmiTV_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiTV_Copy As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiTV_Paste As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiTV_PasteAsLink As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiTV_Cut As Global.System.Windows.Forms.MenuItem
        Friend WithEvents nudFadeColorG As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFadeColorB As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudPlotIndex As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudPlotXPPercentage As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCameraAngle As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCamHeightOffset As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudTarHeightOffset As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFadeDelay As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFadeLength As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbLinkID As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbLinkedCnt As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbSharedCnt As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents tbVO_ID As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents tbEndConversation As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents tbEndConverAbort As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents tbAmbientTrack As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbSkippable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUnequipItems As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label26 As Global.System.Windows.Forms.Label
        Friend WithEvents nudDelayEntry As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudDelayReply As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label27 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbUnequipHItem As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tbSpeaker As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label28 As Global.System.Windows.Forms.Label
        Friend WithEvents nudCameraID As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label29 As Global.System.Windows.Forms.Label
        Friend WithEvents tabpagActionsTaken As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagCamera As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagComment As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagPlot As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents tabpagAnimationSound As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagDebug As Global.System.Windows.Forms.TabPage
        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnOpen As Global.System.Windows.Forms.Button
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpen As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSave As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tabpagThisFile1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagThisFile2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents dgStuntList As DataGrid
        Friend WithEvents Label30 As Global.System.Windows.Forms.Label
        Friend WithEvents tbTextActiveScript As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents dgAnimList As DataGrid
        Friend WithEvents btnDeleteAnimListEntry As Global.System.Windows.Forms.Button
        Friend WithEvents btnAddAnimListEntry As Global.System.Windows.Forms.Button
        Friend WithEvents trkbTVIndent As TrackBar
        Friend WithEvents Label32 As Global.System.Windows.Forms.Label
        Friend WithEvents miNew As Global.System.Windows.Forms.MenuItem
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents Label33 As Global.System.Windows.Forms.Label
        Friend WithEvents trkbTVItemHeight As TrackBar
        Friend WithEvents cmiTV_PasteTree As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tbLinkDesc As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label34 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxConversationType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxComputerType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbQuest As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label35 As Global.System.Windows.Forms.Label
        Friend WithEvents Label36 As Global.System.Windows.Forms.Label
        Friend WithEvents nudQuestEntry As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents btnShowLists As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxFadeType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents nudFadeColorR As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents cmbxCamVidEffect As Global.System.Windows.Forms.ComboBox
        Friend WithEvents chkbAnimatedCut As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tbCameraModel As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label31 As Global.System.Windows.Forms.Label
        Friend WithEvents Label37 As Global.System.Windows.Forms.Label
        Friend WithEvents nudCamFieldOfView As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiTV_MoveNodeUp As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiTV_MoveNodeDown As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tabpagThisFile3 As Global.System.Windows.Forms.TabPage
        Friend WithEvents tbTextActiveScript2 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label38 As Global.System.Windows.Forms.Label
        Friend WithEvents tbActionsTakenScript2 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label39 As Global.System.Windows.Forms.Label
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderSeparator As Global.System.Windows.Forms.Label

        ' Token: 0x0600030F RID: 783 RVA: 0x002310AC File Offset: 0x002300AC
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x0600040C RID: 1036 RVA: 0x00232F1C File Offset: 0x00231F1C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.tvConversation = New System.Windows.Forms.TreeView()
            Me.tbConversationText = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.tabpagActionsTaken = New System.Windows.Forms.TabPage()
            Me.tbTextActiveScript = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.tbActionsTakenScript = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.tbTextActiveScript2 = New System.Windows.Forms.TextBox()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.tbActionsTakenScript2 = New System.Windows.Forms.TextBox()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.tabpagCamera = New System.Windows.Forms.TabPage()
            Me.nudCamFieldOfView = New System.Windows.Forms.NumericUpDown()
            Me.cmbxCamVidEffect = New System.Windows.Forms.ComboBox()
            Me.nudFadeColorG = New System.Windows.Forms.NumericUpDown()
            Me.nudFadeColorB = New System.Windows.Forms.NumericUpDown()
            Me.nudFadeColorR = New System.Windows.Forms.NumericUpDown()
            Me.cmbxFadeType = New System.Windows.Forms.ComboBox()
            Me.nudCameraID = New System.Windows.Forms.NumericUpDown()
            Me.nudCamHeightOffset = New System.Windows.Forms.NumericUpDown()
            Me.nudCameraAngle = New System.Windows.Forms.NumericUpDown()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.tbListener = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.btnChooseColor = New System.Windows.Forms.Button()
            Me.nudTarHeightOffset = New System.Windows.Forms.NumericUpDown()
            Me.nudFadeDelay = New System.Windows.Forms.NumericUpDown()
            Me.nudFadeLength = New System.Windows.Forms.NumericUpDown()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.tabpagAnimationSound = New System.Windows.Forms.TabPage()
            Me.dgAnimList = New System.Windows.Forms.DataGrid()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.tbSound = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.tbVoiceOverResRef = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.btnDeleteAnimListEntry = New System.Windows.Forms.Button()
            Me.btnAddAnimListEntry = New System.Windows.Forms.Button()
            Me.tabpagPlot = New System.Windows.Forms.TabPage()
            Me.tbQuest = New System.Windows.Forms.TextBox()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.nudPlotIndex = New System.Windows.Forms.NumericUpDown()
            Me.lblPlotIndex = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.nudPlotXPPercentage = New System.Windows.Forms.NumericUpDown()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.nudQuestEntry = New System.Windows.Forms.NumericUpDown()
            Me.tabpagComment = New System.Windows.Forms.TabPage()
            Me.tbComments = New System.Windows.Forms.TextBox()
            Me.tabpagThisFile1 = New System.Windows.Forms.TabPage()
            Me.chkbAnimatedCut = New System.Windows.Forms.CheckBox()
            Me.tbCameraModel = New System.Windows.Forms.TextBox()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.cmbxConversationType = New System.Windows.Forms.ComboBox()
            Me.chkbSkippable = New System.Windows.Forms.CheckBox()
            Me.tbVO_ID = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.tbEndConversation = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.tbEndConverAbort = New System.Windows.Forms.TextBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.tbAmbientTrack = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.chkbUnequipItems = New System.Windows.Forms.CheckBox()
            Me.chkbUnequipHItem = New System.Windows.Forms.CheckBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.nudDelayEntry = New System.Windows.Forms.NumericUpDown()
            Me.nudDelayReply = New System.Windows.Forms.NumericUpDown()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.cmbxComputerType = New System.Windows.Forms.ComboBox()
            Me.tabpagThisFile2 = New System.Windows.Forms.TabPage()
            Me.dgStuntList = New System.Windows.Forms.DataGrid()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.tabpagThisFile3 = New System.Windows.Forms.TabPage()
            Me.tabpagDebug = New System.Windows.Forms.TabPage()
            Me.trkbTVIndent = New System.Windows.Forms.TrackBar()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.tbLinkID = New System.Windows.Forms.TextBox()
            Me.tbLinkedCnt = New System.Windows.Forms.TextBox()
            Me.tbSharedCnt = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.trkbTVItemHeight = New System.Windows.Forms.TrackBar()
            Me.tbLinkDesc = New System.Windows.Forms.TextBox()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.btnShowLists = New System.Windows.Forms.Button()
            Me.btnCollapseAll = New System.Windows.Forms.Button()
            Me.btnExpandAll = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnTest = New System.Windows.Forms.Button()
            Me.cmTVfunctions = New System.Windows.Forms.ContextMenu()
            Me.cmiTV_Add = New System.Windows.Forms.MenuItem()
            Me.cmiTV_Cut = New System.Windows.Forms.MenuItem()
            Me.cmiTV_Copy = New System.Windows.Forms.MenuItem()
            Me.cmiTV_Paste = New System.Windows.Forms.MenuItem()
            Me.cmiTV_PasteTree = New System.Windows.Forms.MenuItem()
            Me.cmiTV_PasteAsLink = New System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New System.Windows.Forms.MenuItem()
            Me.cmiTV_MoveNodeUp = New System.Windows.Forms.MenuItem()
            Me.cmiTV_MoveNodeDown = New System.Windows.Forms.MenuItem()
            Me.tbSpeaker = New System.Windows.Forms.TextBox()
            Me.btnOpen = New System.Windows.Forms.Button()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miNew = New System.Windows.Forms.MenuItem()
            Me.miOpen = New System.Windows.Forms.MenuItem()
            Me.miSave = New System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New System.Windows.Forms.Label()
            Me.TabControl1.SuspendLayout()
            Me.tabpagActionsTaken.SuspendLayout()
            Me.tabpagCamera.SuspendLayout()
            CType(Me.nudCamFieldOfView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeColorG, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeColorB, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeColorR, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCameraID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCamHeightOffset, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCameraAngle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTarHeightOffset, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeDelay, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeLength, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAnimationSound.SuspendLayout()
            CType(Me.dgAnimList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagPlot.SuspendLayout()
            CType(Me.nudPlotIndex, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudPlotXPPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudQuestEntry, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagComment.SuspendLayout()
            Me.tabpagThisFile1.SuspendLayout()
            CType(Me.nudDelayEntry, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDelayReply, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagThisFile2.SuspendLayout()
            CType(Me.dgStuntList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagDebug.SuspendLayout()
            CType(Me.trkbTVIndent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbTVItemHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'tvConversation
            '
            Me.tvConversation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tvConversation.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tvConversation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tvConversation.HideSelection = False
            Me.tvConversation.Indent = 16
            Me.tvConversation.ItemHeight = 16
            Me.tvConversation.Location = New System.Drawing.Point(107, 124)
            Me.tvConversation.Name = "tvConversation"
            Me.tvConversation.Size = New System.Drawing.Size(830, 198)
            Me.tvConversation.TabIndex = 0
            '
            'tbConversationText
            '
            Me.tbConversationText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tbConversationText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbConversationText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbConversationText.Location = New System.Drawing.Point(12, 408)
            Me.tbConversationText.Multiline = True
            Me.tbConversationText.Name = "tbConversationText"
            Me.tbConversationText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbConversationText.Size = New System.Drawing.Size(260, 169)
            Me.tbConversationText.TabIndex = 4
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(12, 328)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(260, 18)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Speaker Tag"
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(12, 386)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(260, 19)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Text"
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.tabpagActionsTaken)
            Me.TabControl1.Controls.Add(Me.tabpagCamera)
            Me.TabControl1.Controls.Add(Me.tabpagAnimationSound)
            Me.TabControl1.Controls.Add(Me.tabpagPlot)
            Me.TabControl1.Controls.Add(Me.tabpagComment)
            Me.TabControl1.Controls.Add(Me.tabpagThisFile1)
            Me.TabControl1.Controls.Add(Me.tabpagThisFile2)
            Me.TabControl1.Controls.Add(Me.tabpagThisFile3)
            Me.TabControl1.Controls.Add(Me.tabpagDebug)
            Me.TabControl1.Location = New System.Drawing.Point(280, 328)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New System.Drawing.Point(8, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(657, 249)
            Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabIndex = 5
            '
            'tabpagActionsTaken
            '
            Me.tabpagActionsTaken.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagActionsTaken.Controls.Add(Me.tbTextActiveScript)
            Me.tabpagActionsTaken.Controls.Add(Me.Label3)
            Me.tabpagActionsTaken.Controls.Add(Me.tbActionsTakenScript)
            Me.tabpagActionsTaken.Controls.Add(Me.Label4)
            Me.tabpagActionsTaken.Controls.Add(Me.tbTextActiveScript2)
            Me.tabpagActionsTaken.Controls.Add(Me.Label38)
            Me.tabpagActionsTaken.Controls.Add(Me.tbActionsTakenScript2)
            Me.tabpagActionsTaken.Controls.Add(Me.Label39)
            Me.tabpagActionsTaken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagActionsTaken.Location = New System.Drawing.Point(4, 40)
            Me.tabpagActionsTaken.Name = "tabpagActionsTaken"
            Me.tabpagActionsTaken.Size = New System.Drawing.Size(649, 205)
            Me.tabpagActionsTaken.TabIndex = 0
            Me.tabpagActionsTaken.Text = "Node Scripts"
            '
            'tbTextActiveScript
            '
            Me.tbTextActiveScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbTextActiveScript.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbTextActiveScript.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTextActiveScript.Location = New System.Drawing.Point(32, 114)
            Me.tbTextActiveScript.MaxLength = 16
            Me.tbTextActiveScript.Name = "tbTextActiveScript"
            Me.tbTextActiveScript.Size = New System.Drawing.Size(120, 22)
            Me.tbTextActiveScript.TabIndex = 6
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(32, 83)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(216, 28)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Script that determines if node is available"
            '
            'tbActionsTakenScript
            '
            Me.tbActionsTakenScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbActionsTakenScript.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbActionsTakenScript.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbActionsTakenScript.Location = New System.Drawing.Point(32, 37)
            Me.tbActionsTakenScript.MaxLength = 16
            Me.tbActionsTakenScript.Name = "tbActionsTakenScript"
            Me.tbActionsTakenScript.Size = New System.Drawing.Size(120, 22)
            Me.tbActionsTakenScript.TabIndex = 4
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(32, 18)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(136, 19)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Script to run for this node"
            '
            'tbTextActiveScript2
            '
            Me.tbTextActiveScript2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbTextActiveScript2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbTextActiveScript2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTextActiveScript2.Location = New System.Drawing.Point(252, 114)
            Me.tbTextActiveScript2.MaxLength = 16
            Me.tbTextActiveScript2.Name = "tbTextActiveScript2"
            Me.tbTextActiveScript2.Size = New System.Drawing.Size(128, 22)
            Me.tbTextActiveScript2.TabIndex = 6
            Me.tbTextActiveScript2.Visible = False
            '
            'Label38
            '
            Me.Label38.BackColor = System.Drawing.Color.Transparent
            Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label38.Location = New System.Drawing.Point(252, 83)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(232, 28)
            Me.Label38.TabIndex = 7
            Me.Label38.Text = "Script #2 that determines if node is available"
            Me.Label38.Visible = False
            '
            'tbActionsTakenScript2
            '
            Me.tbActionsTakenScript2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbActionsTakenScript2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbActionsTakenScript2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbActionsTakenScript2.Location = New System.Drawing.Point(252, 37)
            Me.tbActionsTakenScript2.MaxLength = 16
            Me.tbActionsTakenScript2.Name = "tbActionsTakenScript2"
            Me.tbActionsTakenScript2.Size = New System.Drawing.Size(128, 22)
            Me.tbActionsTakenScript2.TabIndex = 4
            Me.tbActionsTakenScript2.Visible = False
            '
            'Label39
            '
            Me.Label39.BackColor = System.Drawing.Color.Transparent
            Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label39.Location = New System.Drawing.Point(252, 18)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(144, 19)
            Me.Label39.TabIndex = 5
            Me.Label39.Text = "Script #2 to run for this node"
            Me.Label39.Visible = False
            '
            'tabpagCamera
            '
            Me.tabpagCamera.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagCamera.Controls.Add(Me.nudCamFieldOfView)
            Me.tabpagCamera.Controls.Add(Me.cmbxCamVidEffect)
            Me.tabpagCamera.Controls.Add(Me.nudFadeColorG)
            Me.tabpagCamera.Controls.Add(Me.nudFadeColorB)
            Me.tabpagCamera.Controls.Add(Me.nudFadeColorR)
            Me.tabpagCamera.Controls.Add(Me.cmbxFadeType)
            Me.tabpagCamera.Controls.Add(Me.nudCameraID)
            Me.tabpagCamera.Controls.Add(Me.nudCamHeightOffset)
            Me.tabpagCamera.Controls.Add(Me.nudCameraAngle)
            Me.tabpagCamera.Controls.Add(Me.Label7)
            Me.tabpagCamera.Controls.Add(Me.Label8)
            Me.tabpagCamera.Controls.Add(Me.tbListener)
            Me.tabpagCamera.Controls.Add(Me.Label9)
            Me.tabpagCamera.Controls.Add(Me.Label11)
            Me.tabpagCamera.Controls.Add(Me.Label13)
            Me.tabpagCamera.Controls.Add(Me.Label14)
            Me.tabpagCamera.Controls.Add(Me.Label15)
            Me.tabpagCamera.Controls.Add(Me.Label16)
            Me.tabpagCamera.Controls.Add(Me.btnChooseColor)
            Me.tabpagCamera.Controls.Add(Me.nudTarHeightOffset)
            Me.tabpagCamera.Controls.Add(Me.nudFadeDelay)
            Me.tabpagCamera.Controls.Add(Me.nudFadeLength)
            Me.tabpagCamera.Controls.Add(Me.Label28)
            Me.tabpagCamera.Controls.Add(Me.Label29)
            Me.tabpagCamera.Controls.Add(Me.Label37)
            Me.tabpagCamera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagCamera.Location = New System.Drawing.Point(4, 40)
            Me.tabpagCamera.Name = "tabpagCamera"
            Me.tabpagCamera.Size = New System.Drawing.Size(649, 205)
            Me.tabpagCamera.TabIndex = 5
            Me.tabpagCamera.Text = "Camera"
            '
            'nudCamFieldOfView
            '
            Me.nudCamFieldOfView.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudCamFieldOfView.DecimalPlaces = 2
            Me.nudCamFieldOfView.Enabled = False
            Me.nudCamFieldOfView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCamFieldOfView.Location = New System.Drawing.Point(296, 92)
            Me.nudCamFieldOfView.Maximum = New Decimal(New Integer() {35999, 0, 0, 131072})
            Me.nudCamFieldOfView.Name = "nudCamFieldOfView"
            Me.nudCamFieldOfView.Size = New System.Drawing.Size(56, 22)
            Me.nudCamFieldOfView.TabIndex = 8
            Me.nudCamFieldOfView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudCamFieldOfView, "This is the angle in degrees that the camera sees")
            Me.nudCamFieldOfView.Value = New Decimal(New Integer() {35999, 0, 0, 131072})
            '
            'cmbxCamVidEffect
            '
            Me.cmbxCamVidEffect.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.cmbxCamVidEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxCamVidEffect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxCamVidEffect.Items.AddRange(New Object() {"(none)", "Blue Filter", "Red Filter"})
            Me.cmbxCamVidEffect.Location = New System.Drawing.Point(256, 55)
            Me.cmbxCamVidEffect.Name = "cmbxCamVidEffect"
            Me.cmbxCamVidEffect.Size = New System.Drawing.Size(96, 21)
            Me.cmbxCamVidEffect.TabIndex = 12
            Me.ToolTip1.SetToolTip(Me.cmbxCamVidEffect, "Selecting one of the two colors will make the conversation look like it was viewe" &
        "d through a filter of that color")
            '
            'nudFadeColorG
            '
            Me.nudFadeColorG.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudFadeColorG.Enabled = False
            Me.nudFadeColorG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudFadeColorG.Location = New System.Drawing.Point(368, 129)
            Me.nudFadeColorG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeColorG.Name = "nudFadeColorG"
            Me.nudFadeColorG.Size = New System.Drawing.Size(48, 22)
            Me.nudFadeColorG.TabIndex = 8
            Me.nudFadeColorG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudFadeColorB
            '
            Me.nudFadeColorB.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudFadeColorB.Enabled = False
            Me.nudFadeColorB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudFadeColorB.Location = New System.Drawing.Point(424, 129)
            Me.nudFadeColorB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeColorB.Name = "nudFadeColorB"
            Me.nudFadeColorB.Size = New System.Drawing.Size(48, 22)
            Me.nudFadeColorB.TabIndex = 9
            Me.nudFadeColorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudFadeColorR
            '
            Me.nudFadeColorR.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudFadeColorR.Enabled = False
            Me.nudFadeColorR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudFadeColorR.Location = New System.Drawing.Point(312, 129)
            Me.nudFadeColorR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeColorR.Name = "nudFadeColorR"
            Me.nudFadeColorR.Size = New System.Drawing.Size(48, 22)
            Me.nudFadeColorR.TabIndex = 8
            Me.nudFadeColorR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'cmbxFadeType
            '
            Me.cmbxFadeType.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.cmbxFadeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFadeType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxFadeType.Items.AddRange(New Object() {"(none)", "Cut to Black", "Cut to Scene", "Fade to Scene", "Fade to Fade Color"})
            Me.cmbxFadeType.Location = New System.Drawing.Point(384, 18)
            Me.cmbxFadeType.Name = "cmbxFadeType"
            Me.cmbxFadeType.Size = New System.Drawing.Size(96, 21)
            Me.cmbxFadeType.TabIndex = 12
            '
            'nudCameraID
            '
            Me.nudCameraID.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudCameraID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCameraID.Location = New System.Drawing.Point(264, 18)
            Me.nudCameraID.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCameraID.Name = "nudCameraID"
            Me.nudCameraID.Size = New System.Drawing.Size(40, 22)
            Me.nudCameraID.TabIndex = 11
            Me.nudCameraID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudCameraID, "The Camera ID indicates which Camera in a module shoould the Conversation be view" &
        "ed from. It should be in the same room and the conversants.")
            '
            'nudCamHeightOffset
            '
            Me.nudCamHeightOffset.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudCamHeightOffset.DecimalPlaces = 2
            Me.nudCamHeightOffset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCamHeightOffset.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudCamHeightOffset.Location = New System.Drawing.Point(120, 55)
            Me.nudCamHeightOffset.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCamHeightOffset.Name = "nudCamHeightOffset"
            Me.nudCamHeightOffset.ReadOnly = True
            Me.nudCamHeightOffset.Size = New System.Drawing.Size(56, 22)
            Me.nudCamHeightOffset.TabIndex = 11
            Me.nudCamHeightOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudCameraAngle
            '
            Me.nudCameraAngle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudCameraAngle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCameraAngle.Location = New System.Drawing.Point(120, 18)
            Me.nudCameraAngle.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCameraAngle.Name = "nudCameraAngle"
            Me.nudCameraAngle.Size = New System.Drawing.Size(40, 22)
            Me.nudCameraAngle.TabIndex = 11
            Me.nudCameraAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(8, 18)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(100, 19)
            Me.Label7.TabIndex = 5
            Me.Label7.Text = "Camera Angle"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(320, 18)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(64, 19)
            Me.Label8.TabIndex = 5
            Me.Label8.Text = "Fade Type"
            '
            'tbListener
            '
            Me.tbListener.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbListener.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbListener.Location = New System.Drawing.Point(88, 129)
            Me.tbListener.Name = "tbListener"
            Me.tbListener.Size = New System.Drawing.Size(136, 22)
            Me.tbListener.TabIndex = 3
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(8, 129)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(48, 19)
            Me.Label9.TabIndex = 5
            Me.Label9.Text = "Listener"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(360, 55)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(64, 19)
            Me.Label11.TabIndex = 5
            Me.Label11.Text = "Fade Delay"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.Transparent
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(8, 55)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(120, 19)
            Me.Label13.TabIndex = 5
            Me.Label13.Text = "Camera Height Offset"
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.Transparent
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(360, 92)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(72, 19)
            Me.Label14.TabIndex = 5
            Me.Label14.Text = "Fade Length"
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.Transparent
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(248, 129)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(72, 19)
            Me.Label15.TabIndex = 5
            Me.Label15.Text = "Fade Color"
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label16.Location = New System.Drawing.Point(8, 92)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(96, 19)
            Me.Label16.TabIndex = 5
            Me.Label16.Text = "Tar Height Offset"
            '
            'btnChooseColor
            '
            Me.btnChooseColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnChooseColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnChooseColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnChooseColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnChooseColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnChooseColor.Location = New System.Drawing.Point(448, 166)
            Me.btnChooseColor.Name = "btnChooseColor"
            Me.btnChooseColor.Size = New System.Drawing.Size(24, 27)
            Me.btnChooseColor.TabIndex = 10
            Me.btnChooseColor.Text = "..."
            Me.btnChooseColor.UseVisualStyleBackColor = False
            Me.btnChooseColor.Visible = False
            '
            'nudTarHeightOffset
            '
            Me.nudTarHeightOffset.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudTarHeightOffset.DecimalPlaces = 2
            Me.nudTarHeightOffset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudTarHeightOffset.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudTarHeightOffset.Location = New System.Drawing.Point(120, 92)
            Me.nudTarHeightOffset.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudTarHeightOffset.Name = "nudTarHeightOffset"
            Me.nudTarHeightOffset.ReadOnly = True
            Me.nudTarHeightOffset.Size = New System.Drawing.Size(56, 22)
            Me.nudTarHeightOffset.TabIndex = 11
            Me.nudTarHeightOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudFadeDelay
            '
            Me.nudFadeDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudFadeDelay.DecimalPlaces = 2
            Me.nudFadeDelay.Enabled = False
            Me.nudFadeDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudFadeDelay.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudFadeDelay.Location = New System.Drawing.Point(432, 55)
            Me.nudFadeDelay.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeDelay.Name = "nudFadeDelay"
            Me.nudFadeDelay.Size = New System.Drawing.Size(48, 22)
            Me.nudFadeDelay.TabIndex = 11
            Me.nudFadeDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudFadeLength
            '
            Me.nudFadeLength.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudFadeLength.DecimalPlaces = 2
            Me.nudFadeLength.Enabled = False
            Me.nudFadeLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudFadeLength.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudFadeLength.Location = New System.Drawing.Point(432, 92)
            Me.nudFadeLength.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeLength.Name = "nudFadeLength"
            Me.nudFadeLength.Size = New System.Drawing.Size(48, 22)
            Me.nudFadeLength.TabIndex = 11
            Me.nudFadeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label28
            '
            Me.Label28.BackColor = System.Drawing.Color.Transparent
            Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label28.Location = New System.Drawing.Point(192, 18)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(80, 19)
            Me.Label28.TabIndex = 5
            Me.Label28.Text = "Camera ID"
            '
            'Label29
            '
            Me.Label29.BackColor = System.Drawing.Color.Transparent
            Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label29.Location = New System.Drawing.Point(192, 53)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(80, 37)
            Me.Label29.TabIndex = 5
            Me.Label29.Text = "Camera Vid Effect"
            '
            'Label37
            '
            Me.Label37.BackColor = System.Drawing.Color.Transparent
            Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label37.Location = New System.Drawing.Point(192, 93)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(112, 19)
            Me.Label37.TabIndex = 5
            Me.Label37.Text = "Camera Field of View"
            '
            'tabpagAnimationSound
            '
            Me.tabpagAnimationSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagAnimationSound.Controls.Add(Me.dgAnimList)
            Me.tabpagAnimationSound.Controls.Add(Me.Label5)
            Me.tabpagAnimationSound.Controls.Add(Me.tbSound)
            Me.tabpagAnimationSound.Controls.Add(Me.Label6)
            Me.tabpagAnimationSound.Controls.Add(Me.tbVoiceOverResRef)
            Me.tabpagAnimationSound.Controls.Add(Me.Label10)
            Me.tabpagAnimationSound.Controls.Add(Me.btnDeleteAnimListEntry)
            Me.tabpagAnimationSound.Controls.Add(Me.btnAddAnimListEntry)
            Me.tabpagAnimationSound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagAnimationSound.Location = New System.Drawing.Point(4, 40)
            Me.tabpagAnimationSound.Name = "tabpagAnimationSound"
            Me.tabpagAnimationSound.Size = New System.Drawing.Size(649, 205)
            Me.tabpagAnimationSound.TabIndex = 1
            Me.tabpagAnimationSound.Text = "Animation/Sound"
            '
            'dgAnimList
            '
            Me.dgAnimList.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.dgAnimList.CaptionVisible = False
            Me.dgAnimList.DataMember = ""
            Me.dgAnimList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgAnimList.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.dgAnimList.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgAnimList.Location = New System.Drawing.Point(224, 37)
            Me.dgAnimList.Name = "dgAnimList"
            Me.dgAnimList.Size = New System.Drawing.Size(248, 120)
            Me.dgAnimList.TabIndex = 8
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(248, 9)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(100, 19)
            Me.Label5.TabIndex = 7
            Me.Label5.Text = "Play Animation"
            '
            'tbSound
            '
            Me.tbSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbSound.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbSound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSound.Location = New System.Drawing.Point(32, 103)
            Me.tbSound.MaxLength = 16
            Me.tbSound.Name = "tbSound"
            Me.tbSound.Size = New System.Drawing.Size(120, 22)
            Me.tbSound.TabIndex = 2
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(32, 74)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(136, 18)
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "Play this sound (ResRef)"
            '
            'tbVoiceOverResRef
            '
            Me.tbVoiceOverResRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbVoiceOverResRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbVoiceOverResRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbVoiceOverResRef.Location = New System.Drawing.Point(32, 37)
            Me.tbVoiceOverResRef.MaxLength = 16
            Me.tbVoiceOverResRef.Name = "tbVoiceOverResRef"
            Me.tbVoiceOverResRef.Size = New System.Drawing.Size(120, 22)
            Me.tbVoiceOverResRef.TabIndex = 3
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(32, 9)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(184, 19)
            Me.Label10.TabIndex = 7
            Me.Label10.Text = "Play this Voice Over (ResRef)"
            '
            'btnDeleteAnimListEntry
            '
            Me.btnDeleteAnimListEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnDeleteAnimListEntry.Enabled = False
            Me.btnDeleteAnimListEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnDeleteAnimListEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnDeleteAnimListEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnDeleteAnimListEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDeleteAnimListEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnDeleteAnimListEntry.Location = New System.Drawing.Point(360, 166)
            Me.btnDeleteAnimListEntry.Name = "btnDeleteAnimListEntry"
            Me.btnDeleteAnimListEntry.Size = New System.Drawing.Size(56, 27)
            Me.btnDeleteAnimListEntry.TabIndex = 6
            Me.btnDeleteAnimListEntry.Text = "Delete"
            Me.btnDeleteAnimListEntry.UseVisualStyleBackColor = False
            '
            'btnAddAnimListEntry
            '
            Me.btnAddAnimListEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAddAnimListEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAddAnimListEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAddAnimListEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAddAnimListEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddAnimListEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnAddAnimListEntry.Location = New System.Drawing.Point(288, 166)
            Me.btnAddAnimListEntry.Name = "btnAddAnimListEntry"
            Me.btnAddAnimListEntry.Size = New System.Drawing.Size(56, 27)
            Me.btnAddAnimListEntry.TabIndex = 6
            Me.btnAddAnimListEntry.Text = "Add"
            Me.btnAddAnimListEntry.UseVisualStyleBackColor = False
            '
            'tabpagPlot
            '
            Me.tabpagPlot.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagPlot.Controls.Add(Me.tbQuest)
            Me.tabpagPlot.Controls.Add(Me.Label35)
            Me.tabpagPlot.Controls.Add(Me.nudPlotIndex)
            Me.tabpagPlot.Controls.Add(Me.lblPlotIndex)
            Me.tabpagPlot.Controls.Add(Me.Label12)
            Me.tabpagPlot.Controls.Add(Me.nudPlotXPPercentage)
            Me.tabpagPlot.Controls.Add(Me.Label36)
            Me.tabpagPlot.Controls.Add(Me.nudQuestEntry)
            Me.tabpagPlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagPlot.Location = New System.Drawing.Point(4, 40)
            Me.tabpagPlot.Name = "tabpagPlot"
            Me.tabpagPlot.Size = New System.Drawing.Size(649, 205)
            Me.tabpagPlot.TabIndex = 6
            Me.tabpagPlot.Text = "Plot/Quest"
            '
            'tbQuest
            '
            Me.tbQuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbQuest.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbQuest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbQuest.Location = New System.Drawing.Point(176, 46)
            Me.tbQuest.Name = "tbQuest"
            Me.tbQuest.Size = New System.Drawing.Size(224, 22)
            Me.tbQuest.TabIndex = 14
            '
            'Label35
            '
            Me.Label35.BackColor = System.Drawing.Color.Transparent
            Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label35.Location = New System.Drawing.Point(176, 92)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(128, 19)
            Me.Label35.TabIndex = 15
            Me.Label35.Text = "Quest Entry"
            '
            'nudPlotIndex
            '
            Me.nudPlotIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudPlotIndex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudPlotIndex.Location = New System.Drawing.Point(32, 46)
            Me.nudPlotIndex.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
            Me.nudPlotIndex.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.nudPlotIndex.Name = "nudPlotIndex"
            Me.nudPlotIndex.Size = New System.Drawing.Size(40, 22)
            Me.nudPlotIndex.TabIndex = 12
            Me.nudPlotIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudPlotIndex.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
            '
            'lblPlotIndex
            '
            Me.lblPlotIndex.BackColor = System.Drawing.Color.Transparent
            Me.lblPlotIndex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblPlotIndex.Location = New System.Drawing.Point(32, 28)
            Me.lblPlotIndex.Name = "lblPlotIndex"
            Me.lblPlotIndex.Size = New System.Drawing.Size(100, 18)
            Me.lblPlotIndex.TabIndex = 11
            Me.lblPlotIndex.Text = "Plot Index"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(32, 92)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(120, 19)
            Me.Label12.TabIndex = 10
            Me.Label12.Text = "Plot XP Percentage"
            '
            'nudPlotXPPercentage
            '
            Me.nudPlotXPPercentage.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudPlotXPPercentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudPlotXPPercentage.Location = New System.Drawing.Point(32, 111)
            Me.nudPlotXPPercentage.Name = "nudPlotXPPercentage"
            Me.nudPlotXPPercentage.Size = New System.Drawing.Size(40, 22)
            Me.nudPlotXPPercentage.TabIndex = 12
            Me.nudPlotXPPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudPlotXPPercentage.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label36
            '
            Me.Label36.BackColor = System.Drawing.Color.Transparent
            Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label36.Location = New System.Drawing.Point(176, 28)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(128, 18)
            Me.Label36.TabIndex = 15
            Me.Label36.Text = "Quest"
            '
            'nudQuestEntry
            '
            Me.nudQuestEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudQuestEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudQuestEntry.Location = New System.Drawing.Point(176, 111)
            Me.nudQuestEntry.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
            Me.nudQuestEntry.Name = "nudQuestEntry"
            Me.nudQuestEntry.Size = New System.Drawing.Size(88, 22)
            Me.nudQuestEntry.TabIndex = 12
            Me.nudQuestEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'tabpagComment
            '
            Me.tabpagComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagComment.Controls.Add(Me.tbComments)
            Me.tabpagComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagComment.Location = New System.Drawing.Point(4, 40)
            Me.tabpagComment.Name = "tabpagComment"
            Me.tabpagComment.Size = New System.Drawing.Size(649, 205)
            Me.tabpagComment.TabIndex = 2
            Me.tabpagComment.Text = "Comments"
            '
            'tbComments
            '
            Me.tbComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbComments.Location = New System.Drawing.Point(8, 18)
            Me.tbComments.Multiline = True
            Me.tbComments.Name = "tbComments"
            Me.tbComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbComments.Size = New System.Drawing.Size(625, 157)
            Me.tbComments.TabIndex = 1
            '
            'tabpagThisFile1
            '
            Me.tabpagThisFile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagThisFile1.Controls.Add(Me.chkbAnimatedCut)
            Me.tabpagThisFile1.Controls.Add(Me.tbCameraModel)
            Me.tabpagThisFile1.Controls.Add(Me.Label31)
            Me.tabpagThisFile1.Controls.Add(Me.cmbxConversationType)
            Me.tabpagThisFile1.Controls.Add(Me.chkbSkippable)
            Me.tabpagThisFile1.Controls.Add(Me.tbVO_ID)
            Me.tabpagThisFile1.Controls.Add(Me.Label20)
            Me.tabpagThisFile1.Controls.Add(Me.Label21)
            Me.tabpagThisFile1.Controls.Add(Me.tbEndConversation)
            Me.tabpagThisFile1.Controls.Add(Me.Label22)
            Me.tabpagThisFile1.Controls.Add(Me.Label23)
            Me.tabpagThisFile1.Controls.Add(Me.tbEndConverAbort)
            Me.tabpagThisFile1.Controls.Add(Me.Label24)
            Me.tabpagThisFile1.Controls.Add(Me.tbAmbientTrack)
            Me.tabpagThisFile1.Controls.Add(Me.Label25)
            Me.tabpagThisFile1.Controls.Add(Me.chkbUnequipItems)
            Me.tabpagThisFile1.Controls.Add(Me.chkbUnequipHItem)
            Me.tabpagThisFile1.Controls.Add(Me.Label26)
            Me.tabpagThisFile1.Controls.Add(Me.nudDelayEntry)
            Me.tabpagThisFile1.Controls.Add(Me.nudDelayReply)
            Me.tabpagThisFile1.Controls.Add(Me.Label27)
            Me.tabpagThisFile1.Controls.Add(Me.cmbxComputerType)
            Me.tabpagThisFile1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagThisFile1.Location = New System.Drawing.Point(4, 40)
            Me.tabpagThisFile1.Name = "tabpagThisFile1"
            Me.tabpagThisFile1.Size = New System.Drawing.Size(649, 205)
            Me.tabpagThisFile1.TabIndex = 3
            Me.tabpagThisFile1.Text = "This File (1)"
            '
            'chkbAnimatedCut
            '
            Me.chkbAnimatedCut.BackColor = System.Drawing.Color.Transparent
            Me.chkbAnimatedCut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAnimatedCut.Location = New System.Drawing.Point(16, 157)
            Me.chkbAnimatedCut.Name = "chkbAnimatedCut"
            Me.chkbAnimatedCut.Size = New System.Drawing.Size(128, 28)
            Me.chkbAnimatedCut.TabIndex = 16
            Me.chkbAnimatedCut.Text = "Animated Cutscene"
            Me.chkbAnimatedCut.UseVisualStyleBackColor = False
            '
            'tbCameraModel
            '
            Me.tbCameraModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbCameraModel.Enabled = False
            Me.tbCameraModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCameraModel.Location = New System.Drawing.Point(160, 165)
            Me.tbCameraModel.MaxLength = 16
            Me.tbCameraModel.Name = "tbCameraModel"
            Me.tbCameraModel.Size = New System.Drawing.Size(120, 22)
            Me.tbCameraModel.TabIndex = 14
            Me.ToolTip1.SetToolTip(Me.tbCameraModel, "This is the model name of the camera to use in Animated Cutscenes")
            '
            'Label31
            '
            Me.Label31.BackColor = System.Drawing.Color.Transparent
            Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label31.Location = New System.Drawing.Point(160, 148)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(80, 18)
            Me.Label31.TabIndex = 15
            Me.Label31.Text = "Camera Model"
            '
            'cmbxConversationType
            '
            Me.cmbxConversationType.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.cmbxConversationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxConversationType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxConversationType.Items.AddRange(New Object() {"Human", "Computer", "Type 2", "Type 3", "Type 4"})
            Me.cmbxConversationType.Location = New System.Drawing.Point(8, 74)
            Me.cmbxConversationType.Name = "cmbxConversationType"
            Me.cmbxConversationType.Size = New System.Drawing.Size(88, 21)
            Me.cmbxConversationType.TabIndex = 12
            '
            'chkbSkippable
            '
            Me.chkbSkippable.BackColor = System.Drawing.Color.Transparent
            Me.chkbSkippable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbSkippable.Location = New System.Drawing.Point(320, 9)
            Me.chkbSkippable.Name = "chkbSkippable"
            Me.chkbSkippable.Size = New System.Drawing.Size(80, 28)
            Me.chkbSkippable.TabIndex = 11
            Me.chkbSkippable.Text = "Skippable"
            Me.chkbSkippable.UseVisualStyleBackColor = False
            '
            'tbVO_ID
            '
            Me.tbVO_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbVO_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbVO_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbVO_ID.Location = New System.Drawing.Point(8, 28)
            Me.tbVO_ID.Name = "tbVO_ID"
            Me.tbVO_ID.Size = New System.Drawing.Size(128, 22)
            Me.tbVO_ID.TabIndex = 8
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.Transparent
            Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label20.Location = New System.Drawing.Point(8, 9)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(112, 19)
            Me.Label20.TabIndex = 9
            Me.Label20.Text = "Voice Over Family ID"
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.Transparent
            Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label21.Location = New System.Drawing.Point(8, 55)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(104, 19)
            Me.Label21.TabIndex = 9
            Me.Label21.Text = "Conversation Type"
            '
            'tbEndConversation
            '
            Me.tbEndConversation.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbEndConversation.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbEndConversation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbEndConversation.Location = New System.Drawing.Point(160, 28)
            Me.tbEndConversation.MaxLength = 16
            Me.tbEndConversation.Name = "tbEndConversation"
            Me.tbEndConversation.Size = New System.Drawing.Size(128, 22)
            Me.tbEndConversation.TabIndex = 8
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.Transparent
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(160, 9)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(128, 19)
            Me.Label22.TabIndex = 9
            Me.Label22.Text = "End Conv Normal Script"
            '
            'Label23
            '
            Me.Label23.BackColor = System.Drawing.Color.Transparent
            Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label23.Location = New System.Drawing.Point(160, 55)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(128, 19)
            Me.Label23.TabIndex = 9
            Me.Label23.Text = "End Conv Abort Script"
            '
            'tbEndConverAbort
            '
            Me.tbEndConverAbort.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbEndConverAbort.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbEndConverAbort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbEndConverAbort.Location = New System.Drawing.Point(160, 74)
            Me.tbEndConverAbort.MaxLength = 16
            Me.tbEndConverAbort.Name = "tbEndConverAbort"
            Me.tbEndConverAbort.Size = New System.Drawing.Size(128, 22)
            Me.tbEndConverAbort.TabIndex = 8
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.Transparent
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(8, 102)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(104, 18)
            Me.Label24.TabIndex = 9
            Me.Label24.Text = "Computer Type"
            '
            'tbAmbientTrack
            '
            Me.tbAmbientTrack.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbAmbientTrack.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbAmbientTrack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbAmbientTrack.Location = New System.Drawing.Point(160, 120)
            Me.tbAmbientTrack.MaxLength = 16
            Me.tbAmbientTrack.Name = "tbAmbientTrack"
            Me.tbAmbientTrack.Size = New System.Drawing.Size(128, 22)
            Me.tbAmbientTrack.TabIndex = 8
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.Transparent
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(160, 102)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(128, 18)
            Me.Label25.TabIndex = 9
            Me.Label25.Text = "Ambient Track"
            '
            'chkbUnequipItems
            '
            Me.chkbUnequipItems.BackColor = System.Drawing.Color.Transparent
            Me.chkbUnequipItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUnequipItems.Location = New System.Drawing.Point(320, 37)
            Me.chkbUnequipItems.Name = "chkbUnequipItems"
            Me.chkbUnequipItems.Size = New System.Drawing.Size(96, 28)
            Me.chkbUnequipItems.TabIndex = 11
            Me.chkbUnequipItems.Text = "Unequip Items"
            Me.chkbUnequipItems.UseVisualStyleBackColor = False
            '
            'chkbUnequipHItem
            '
            Me.chkbUnequipHItem.BackColor = System.Drawing.Color.Transparent
            Me.chkbUnequipHItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUnequipHItem.Location = New System.Drawing.Point(320, 65)
            Me.chkbUnequipHItem.Name = "chkbUnequipHItem"
            Me.chkbUnequipHItem.Size = New System.Drawing.Size(104, 27)
            Me.chkbUnequipHItem.TabIndex = 11
            Me.chkbUnequipHItem.Text = "Unequip HItem"
            Me.chkbUnequipHItem.UseVisualStyleBackColor = False
            '
            'Label26
            '
            Me.Label26.BackColor = System.Drawing.Color.Transparent
            Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label26.Location = New System.Drawing.Point(307, 102)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(64, 18)
            Me.Label26.TabIndex = 9
            Me.Label26.Text = "Delay Entry"
            '
            'nudDelayEntry
            '
            Me.nudDelayEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudDelayEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudDelayEntry.Location = New System.Drawing.Point(304, 120)
            Me.nudDelayEntry.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudDelayEntry.Name = "nudDelayEntry"
            Me.nudDelayEntry.Size = New System.Drawing.Size(64, 22)
            Me.nudDelayEntry.TabIndex = 10
            Me.nudDelayEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudDelayReply
            '
            Me.nudDelayReply.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.nudDelayReply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudDelayReply.Location = New System.Drawing.Point(400, 120)
            Me.nudDelayReply.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudDelayReply.Name = "nudDelayReply"
            Me.nudDelayReply.Size = New System.Drawing.Size(64, 22)
            Me.nudDelayReply.TabIndex = 10
            Me.nudDelayReply.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label27
            '
            Me.Label27.BackColor = System.Drawing.Color.Transparent
            Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label27.Location = New System.Drawing.Point(400, 102)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(72, 18)
            Me.Label27.TabIndex = 9
            Me.Label27.Text = "Delay Reply"
            '
            'cmbxComputerType
            '
            Me.cmbxComputerType.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.cmbxComputerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxComputerType.Enabled = False
            Me.cmbxComputerType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxComputerType.Items.AddRange(New Object() {"Modern", "Ancient"})
            Me.cmbxComputerType.Location = New System.Drawing.Point(8, 120)
            Me.cmbxComputerType.Name = "cmbxComputerType"
            Me.cmbxComputerType.Size = New System.Drawing.Size(88, 21)
            Me.cmbxComputerType.TabIndex = 12
            '
            'tabpagThisFile2
            '
            Me.tabpagThisFile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagThisFile2.Controls.Add(Me.dgStuntList)
            Me.tabpagThisFile2.Controls.Add(Me.Label30)
            Me.tabpagThisFile2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagThisFile2.Location = New System.Drawing.Point(4, 40)
            Me.tabpagThisFile2.Name = "tabpagThisFile2"
            Me.tabpagThisFile2.Size = New System.Drawing.Size(649, 205)
            Me.tabpagThisFile2.TabIndex = 8
            Me.tabpagThisFile2.Text = "This File (2)"
            '
            'dgStuntList
            '
            Me.dgStuntList.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.dgStuntList.DataMember = ""
            Me.dgStuntList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgStuntList.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.dgStuntList.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgStuntList.Location = New System.Drawing.Point(3, 13)
            Me.dgStuntList.Name = "dgStuntList"
            Me.dgStuntList.Size = New System.Drawing.Size(643, 189)
            Me.dgStuntList.TabIndex = 0
            '
            'Label30
            '
            Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label30.BackColor = System.Drawing.Color.Transparent
            Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label30.Location = New System.Drawing.Point(56, 28)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(136, 18)
            Me.Label30.TabIndex = 3
            Me.Label30.Text = "(Stunt List is View-only)"
            '
            'tabpagThisFile3
            '
            Me.tabpagThisFile3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagThisFile3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagThisFile3.Location = New System.Drawing.Point(4, 40)
            Me.tabpagThisFile3.Name = "tabpagThisFile3"
            Me.tabpagThisFile3.Size = New System.Drawing.Size(649, 205)
            Me.tabpagThisFile3.TabIndex = 9
            Me.tabpagThisFile3.Text = "This File (3)"
            '
            'tabpagDebug
            '
            Me.tabpagDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagDebug.Controls.Add(Me.trkbTVIndent)
            Me.tabpagDebug.Controls.Add(Me.Label17)
            Me.tabpagDebug.Controls.Add(Me.tbLinkID)
            Me.tabpagDebug.Controls.Add(Me.tbLinkedCnt)
            Me.tabpagDebug.Controls.Add(Me.tbSharedCnt)
            Me.tabpagDebug.Controls.Add(Me.Label18)
            Me.tabpagDebug.Controls.Add(Me.Label19)
            Me.tabpagDebug.Controls.Add(Me.btnDebug)
            Me.tabpagDebug.Controls.Add(Me.Label32)
            Me.tabpagDebug.Controls.Add(Me.Label33)
            Me.tabpagDebug.Controls.Add(Me.trkbTVItemHeight)
            Me.tabpagDebug.Controls.Add(Me.tbLinkDesc)
            Me.tabpagDebug.Controls.Add(Me.Label34)
            Me.tabpagDebug.Controls.Add(Me.btnShowLists)
            Me.tabpagDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagDebug.Location = New System.Drawing.Point(4, 40)
            Me.tabpagDebug.Name = "tabpagDebug"
            Me.tabpagDebug.Size = New System.Drawing.Size(649, 205)
            Me.tabpagDebug.TabIndex = 7
            Me.tabpagDebug.Text = "Debug information/Options"
            '
            'trkbTVIndent
            '
            Me.trkbTVIndent.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.trkbTVIndent.Location = New System.Drawing.Point(280, 46)
            Me.trkbTVIndent.Maximum = 30
            Me.trkbTVIndent.Minimum = 15
            Me.trkbTVIndent.Name = "trkbTVIndent"
            Me.trkbTVIndent.Size = New System.Drawing.Size(120, 45)
            Me.trkbTVIndent.TabIndex = 9
            Me.trkbTVIndent.Value = 16
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.Transparent
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(56, 37)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(100, 18)
            Me.Label17.TabIndex = 8
            Me.Label17.Text = "Link ID"
            '
            'tbLinkID
            '
            Me.tbLinkID.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbLinkID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbLinkID.Location = New System.Drawing.Point(168, 35)
            Me.tbLinkID.Name = "tbLinkID"
            Me.tbLinkID.Size = New System.Drawing.Size(56, 22)
            Me.tbLinkID.TabIndex = 7
            '
            'tbLinkedCnt
            '
            Me.tbLinkedCnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbLinkedCnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbLinkedCnt.Location = New System.Drawing.Point(168, 74)
            Me.tbLinkedCnt.Name = "tbLinkedCnt"
            Me.tbLinkedCnt.Size = New System.Drawing.Size(56, 22)
            Me.tbLinkedCnt.TabIndex = 7
            '
            'tbSharedCnt
            '
            Me.tbSharedCnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbSharedCnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSharedCnt.Location = New System.Drawing.Point(168, 111)
            Me.tbSharedCnt.Name = "tbSharedCnt"
            Me.tbSharedCnt.Size = New System.Drawing.Size(56, 22)
            Me.tbSharedCnt.TabIndex = 7
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.Transparent
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(56, 76)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(80, 19)
            Me.Label18.TabIndex = 8
            Me.Label18.Text = "Linked to this"
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.Transparent
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(56, 113)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(100, 19)
            Me.Label19.TabIndex = 8
            Me.Label19.Text = "Nodes sharing link"
            '
            'btnDebug
            '
            Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnDebug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnDebug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnDebug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnDebug.Location = New System.Drawing.Point(280, 166)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(120, 27)
            Me.btnDebug.TabIndex = 6
            Me.btnDebug.Text = "Show Debug Listing"
            Me.btnDebug.UseVisualStyleBackColor = False
            '
            'Label32
            '
            Me.Label32.BackColor = System.Drawing.Color.Transparent
            Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label32.Location = New System.Drawing.Point(288, 28)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(112, 18)
            Me.Label32.TabIndex = 8
            Me.Label32.Text = "Treeview indent level"
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.Transparent
            Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label33.Location = New System.Drawing.Point(288, 102)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(112, 18)
            Me.Label33.TabIndex = 8
            Me.Label33.Text = "Treeview item height"
            '
            'trkbTVItemHeight
            '
            Me.trkbTVItemHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.trkbTVItemHeight.Location = New System.Drawing.Point(280, 120)
            Me.trkbTVItemHeight.Maximum = 21
            Me.trkbTVItemHeight.Minimum = 7
            Me.trkbTVItemHeight.Name = "trkbTVItemHeight"
            Me.trkbTVItemHeight.Size = New System.Drawing.Size(120, 45)
            Me.trkbTVItemHeight.TabIndex = 9
            Me.trkbTVItemHeight.Value = 9
            '
            'tbLinkDesc
            '
            Me.tbLinkDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbLinkDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbLinkDesc.Location = New System.Drawing.Point(168, 148)
            Me.tbLinkDesc.Name = "tbLinkDesc"
            Me.tbLinkDesc.Size = New System.Drawing.Size(56, 22)
            Me.tbLinkDesc.TabIndex = 7
            '
            'Label34
            '
            Me.Label34.BackColor = System.Drawing.Color.Transparent
            Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label34.Location = New System.Drawing.Point(56, 148)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(100, 18)
            Me.Label34.TabIndex = 8
            Me.Label34.Text = "Link Desc"
            '
            'btnShowLists
            '
            Me.btnShowLists.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnShowLists.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnShowLists.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnShowLists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnShowLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnShowLists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnShowLists.Location = New System.Drawing.Point(448, 166)
            Me.btnShowLists.Name = "btnShowLists"
            Me.btnShowLists.Size = New System.Drawing.Size(24, 27)
            Me.btnShowLists.TabIndex = 6
            Me.btnShowLists.Text = "D"
            Me.btnShowLists.UseVisualStyleBackColor = False
            Me.btnShowLists.Visible = False
            '
            'btnCollapseAll
            '
            Me.btnCollapseAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCollapseAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCollapseAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCollapseAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCollapseAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCollapseAll.Location = New System.Drawing.Point(5, 157)
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Me.btnCollapseAll.Size = New System.Drawing.Size(96, 26)
            Me.btnCollapseAll.TabIndex = 2
            Me.btnCollapseAll.Text = "Collapse All"
            Me.ToolTip1.SetToolTip(Me.btnCollapseAll, "Collapse all nodes in the treeview")
            Me.btnCollapseAll.UseVisualStyleBackColor = False
            '
            'btnExpandAll
            '
            Me.btnExpandAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnExpandAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnExpandAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnExpandAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExpandAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnExpandAll.Location = New System.Drawing.Point(5, 124)
            Me.btnExpandAll.Name = "btnExpandAll"
            Me.btnExpandAll.Size = New System.Drawing.Size(96, 27)
            Me.btnExpandAll.TabIndex = 1
            Me.btnExpandAll.Text = "Expand All"
            Me.ToolTip1.SetToolTip(Me.btnExpandAll, "Expand all nodes in the treeview")
            Me.btnExpandAll.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSave.Location = New System.Drawing.Point(59, 91)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(42, 27)
            Me.btnSave.TabIndex = 6
            Me.btnSave.Text = "Save"
            Me.btnSave.UseVisualStyleBackColor = False
            Me.btnSave.Visible = False
            '
            'btnTest
            '
            Me.btnTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnTest.Location = New System.Drawing.Point(107, 91)
            Me.btnTest.Name = "btnTest"
            Me.btnTest.Size = New System.Drawing.Size(40, 27)
            Me.btnTest.TabIndex = 5
            Me.btnTest.Text = "Test"
            Me.btnTest.UseVisualStyleBackColor = False
            Me.btnTest.Visible = False
            '
            'cmiTV_Add
            '
            Me.cmiTV_Add.Index = -1
            Me.cmiTV_Add.Text = ""
            '
            'cmiTV_Cut
            '
            Me.cmiTV_Cut.Index = -1
            Me.cmiTV_Cut.Text = ""
            '
            'cmiTV_Copy
            '
            Me.cmiTV_Copy.Index = -1
            Me.cmiTV_Copy.Text = ""
            '
            'cmiTV_Paste
            '
            Me.cmiTV_Paste.Index = -1
            Me.cmiTV_Paste.Text = ""
            '
            'cmiTV_PasteTree
            '
            Me.cmiTV_PasteTree.Index = -1
            Me.cmiTV_PasteTree.Text = ""
            '
            'cmiTV_PasteAsLink
            '
            Me.cmiTV_PasteAsLink.Index = -1
            Me.cmiTV_PasteAsLink.Text = ""
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = -1
            Me.MenuItem2.Text = ""
            '
            'cmiTV_MoveNodeUp
            '
            Me.cmiTV_MoveNodeUp.Index = -1
            Me.cmiTV_MoveNodeUp.Text = ""
            '
            'cmiTV_MoveNodeDown
            '
            Me.cmiTV_MoveNodeDown.Index = -1
            Me.cmiTV_MoveNodeDown.Text = ""
            '
            'tbSpeaker
            '
            Me.tbSpeaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tbSpeaker.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
            Me.tbSpeaker.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbSpeaker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSpeaker.Location = New System.Drawing.Point(12, 353)
            Me.tbSpeaker.Name = "tbSpeaker"
            Me.tbSpeaker.Size = New System.Drawing.Size(260, 22)
            Me.tbSpeaker.TabIndex = 9
            '
            'btnOpen
            '
            Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOpen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOpen.Location = New System.Drawing.Point(5, 91)
            Me.btnOpen.Name = "btnOpen"
            Me.btnOpen.Size = New System.Drawing.Size(48, 27)
            Me.btnOpen.TabIndex = 6
            Me.btnOpen.Text = "Open"
            Me.btnOpen.UseVisualStyleBackColor = False
            Me.btnOpen.Visible = False
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNew, Me.miOpen, Me.miSave, Me.MenuItem4, Me.miQuit})
            Me.MenuItem1.Text = "File"
            '
            'miNew
            '
            Me.miNew.Index = 0
            Me.miNew.Text = "New"
            '
            'miOpen
            '
            Me.miOpen.Index = 1
            Me.miOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpen.Text = "&Open"
            '
            'miSave
            '
            Me.miSave.Index = 2
            Me.miSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            '
            'MenuItem4
            '
            Me.MenuItem4.Index = 3
            Me.MenuItem4.Text = "-"
            '
            'miQuit
            '
            Me.miQuit.Index = 4
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'pnlHeader
            '
            Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderSeparator)
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(961, 79)
            Me.pnlHeader.TabIndex = 40
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(560, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Conversation Editor"
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 45)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(760, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Edit DLG conversation trees, node scripts, camera settings, animations, sounds, p" &
    "lot data, and file-level metadata."
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 75)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(961, 3)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmDialogEditor
            '
            Me.AcceptButton = Me.btnTest
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(961, 596)
            Me.Controls.Add(Me.pnlHeader)
            Me.Controls.Add(Me.tbSpeaker)
            Me.Controls.Add(Me.tbConversationText)
            Me.Controls.Add(Me.btnCollapseAll)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.tvConversation)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnExpandAll)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnTest)
            Me.Controls.Add(Me.btnOpen)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmDialogEditor"
            Me.Text = "Conversation Editor"
            Me.TabControl1.ResumeLayout(False)
            Me.tabpagActionsTaken.ResumeLayout(False)
            Me.tabpagActionsTaken.PerformLayout()
            Me.tabpagCamera.ResumeLayout(False)
            Me.tabpagCamera.PerformLayout()
            CType(Me.nudCamFieldOfView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeColorG, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeColorB, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeColorR, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCameraID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCamHeightOffset, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCameraAngle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTarHeightOffset, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeDelay, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeLength, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAnimationSound.ResumeLayout(False)
            Me.tabpagAnimationSound.PerformLayout()
            CType(Me.dgAnimList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagPlot.ResumeLayout(False)
            Me.tabpagPlot.PerformLayout()
            CType(Me.nudPlotIndex, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudPlotXPPercentage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudQuestEntry, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagComment.ResumeLayout(False)
            Me.tabpagComment.PerformLayout()
            Me.tabpagThisFile1.ResumeLayout(False)
            Me.tabpagThisFile1.PerformLayout()
            CType(Me.nudDelayEntry, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDelayReply, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagThisFile2.ResumeLayout(False)
            CType(Me.dgStuntList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagDebug.ResumeLayout(False)
            Me.tabpagDebug.PerformLayout()
            CType(Me.trkbTVIndent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbTVItemHeight, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

    End Class
End Namespace