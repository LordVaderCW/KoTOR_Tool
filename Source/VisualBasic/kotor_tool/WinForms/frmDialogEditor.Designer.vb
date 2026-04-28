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
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmDialogEditor))
            Me.tvConversation = New Global.System.Windows.Forms.TreeView()
            Me.tbConversationText = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.tabpagActionsTaken = New Global.System.Windows.Forms.TabPage()
            Me.tbTextActiveScript = New Global.System.Windows.Forms.TextBox()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.tbActionsTakenScript = New Global.System.Windows.Forms.TextBox()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.tbTextActiveScript2 = New Global.System.Windows.Forms.TextBox()
            Me.Label38 = New Global.System.Windows.Forms.Label()
            Me.tbActionsTakenScript2 = New Global.System.Windows.Forms.TextBox()
            Me.Label39 = New Global.System.Windows.Forms.Label()
            Me.tabpagCamera = New Global.System.Windows.Forms.TabPage()
            Me.nudCamFieldOfView = New Global.System.Windows.Forms.NumericUpDown()
            Me.cmbxCamVidEffect = New Global.System.Windows.Forms.ComboBox()
            Me.nudFadeColorG = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudFadeColorB = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudFadeColorR = New Global.System.Windows.Forms.NumericUpDown()
            Me.cmbxFadeType = New Global.System.Windows.Forms.ComboBox()
            Me.nudCameraID = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudCamHeightOffset = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudCameraAngle = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.tbListener = New Global.System.Windows.Forms.TextBox()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.Label13 = New Global.System.Windows.Forms.Label()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.Label16 = New Global.System.Windows.Forms.Label()
            Me.btnChooseColor = New Global.System.Windows.Forms.Button()
            Me.nudTarHeightOffset = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudFadeDelay = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudFadeLength = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label28 = New Global.System.Windows.Forms.Label()
            Me.Label29 = New Global.System.Windows.Forms.Label()
            Me.Label37 = New Global.System.Windows.Forms.Label()
            Me.tabpagAnimationSound = New Global.System.Windows.Forms.TabPage()
            Me.dgAnimList = New Global.System.Windows.Forms.DataGrid()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.tbSound = New Global.System.Windows.Forms.TextBox()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.tbVoiceOverResRef = New Global.System.Windows.Forms.TextBox()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.btnDeleteAnimListEntry = New Global.System.Windows.Forms.Button()
            Me.btnAddAnimListEntry = New Global.System.Windows.Forms.Button()
            Me.tabpagPlot = New Global.System.Windows.Forms.TabPage()
            Me.tbQuest = New Global.System.Windows.Forms.TextBox()
            Me.Label35 = New Global.System.Windows.Forms.Label()
            Me.nudPlotIndex = New Global.System.Windows.Forms.NumericUpDown()
            Me.lblPlotIndex = New Global.System.Windows.Forms.Label()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.nudPlotXPPercentage = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label36 = New Global.System.Windows.Forms.Label()
            Me.nudQuestEntry = New Global.System.Windows.Forms.NumericUpDown()
            Me.tabpagComment = New Global.System.Windows.Forms.TabPage()
            Me.tbComments = New Global.System.Windows.Forms.TextBox()
            Me.tabpagThisFile1 = New Global.System.Windows.Forms.TabPage()
            Me.chkbAnimatedCut = New Global.System.Windows.Forms.CheckBox()
            Me.tbCameraModel = New Global.System.Windows.Forms.TextBox()
            Me.Label31 = New Global.System.Windows.Forms.Label()
            Me.cmbxConversationType = New Global.System.Windows.Forms.ComboBox()
            Me.chkbSkippable = New Global.System.Windows.Forms.CheckBox()
            Me.tbVO_ID = New Global.System.Windows.Forms.TextBox()
            Me.Label20 = New Global.System.Windows.Forms.Label()
            Me.Label21 = New Global.System.Windows.Forms.Label()
            Me.tbEndConversation = New Global.System.Windows.Forms.TextBox()
            Me.Label22 = New Global.System.Windows.Forms.Label()
            Me.Label23 = New Global.System.Windows.Forms.Label()
            Me.tbEndConverAbort = New Global.System.Windows.Forms.TextBox()
            Me.Label24 = New Global.System.Windows.Forms.Label()
            Me.tbAmbientTrack = New Global.System.Windows.Forms.TextBox()
            Me.Label25 = New Global.System.Windows.Forms.Label()
            Me.chkbUnequipItems = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUnequipHItem = New Global.System.Windows.Forms.CheckBox()
            Me.Label26 = New Global.System.Windows.Forms.Label()
            Me.nudDelayEntry = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudDelayReply = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label27 = New Global.System.Windows.Forms.Label()
            Me.cmbxComputerType = New Global.System.Windows.Forms.ComboBox()
            Me.tabpagThisFile2 = New Global.System.Windows.Forms.TabPage()
            Me.dgStuntList = New Global.System.Windows.Forms.DataGrid()
            Me.Label30 = New Global.System.Windows.Forms.Label()
            Me.tabpagThisFile3 = New Global.System.Windows.Forms.TabPage()
            Me.tabpagDebug = New Global.System.Windows.Forms.TabPage()
            Me.trkbTVIndent = New Global.System.Windows.Forms.TrackBar()
            Me.Label17 = New Global.System.Windows.Forms.Label()
            Me.tbLinkID = New Global.System.Windows.Forms.TextBox()
            Me.tbLinkedCnt = New Global.System.Windows.Forms.TextBox()
            Me.tbSharedCnt = New Global.System.Windows.Forms.TextBox()
            Me.Label18 = New Global.System.Windows.Forms.Label()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.btnDebug = New Global.System.Windows.Forms.Button()
            Me.Label32 = New Global.System.Windows.Forms.Label()
            Me.Label33 = New Global.System.Windows.Forms.Label()
            Me.trkbTVItemHeight = New Global.System.Windows.Forms.TrackBar()
            Me.tbLinkDesc = New Global.System.Windows.Forms.TextBox()
            Me.Label34 = New Global.System.Windows.Forms.Label()
            Me.btnShowLists = New Global.System.Windows.Forms.Button()
            Me.btnCollapseAll = New Global.System.Windows.Forms.Button()
            Me.btnExpandAll = New Global.System.Windows.Forms.Button()
            Me.btnSave = New Global.System.Windows.Forms.Button()
            Me.btnTest = New Global.System.Windows.Forms.Button()
            Me.cmTVfunctions = New Global.System.Windows.Forms.ContextMenu()
            Me.cmiTV_Add = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTV_Cut = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTV_Copy = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTV_Paste = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTV_PasteTree = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTV_PasteAsLink = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTV_MoveNodeUp = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTV_MoveNodeDown = New Global.System.Windows.Forms.MenuItem()
            Me.tbSpeaker = New Global.System.Windows.Forms.TextBox()
            Me.btnOpen = New Global.System.Windows.Forms.Button()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miNew = New Global.System.Windows.Forms.MenuItem()
            Me.miOpen = New Global.System.Windows.Forms.MenuItem()
            Me.miSave = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip()
            Me.TabControl1.SuspendLayout()
            Me.tabpagActionsTaken.SuspendLayout()
            Me.tabpagCamera.SuspendLayout()
            CType(Me.nudCamFieldOfView, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeColorG, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeColorB, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeColorR, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCameraID, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCamHeightOffset, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCameraAngle, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTarHeightOffset, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeDelay, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFadeLength, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagAnimationSound.SuspendLayout()
            CType(Me.dgAnimList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagPlot.SuspendLayout()
            CType(Me.nudPlotIndex, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudPlotXPPercentage, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudQuestEntry, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagComment.SuspendLayout()
            Me.tabpagThisFile1.SuspendLayout()
            CType(Me.nudDelayEntry, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudDelayReply, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagThisFile2.SuspendLayout()
            CType(Me.dgStuntList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagDebug.SuspendLayout()
            CType(Me.trkbTVIndent, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trkbTVItemHeight, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.tvConversation.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tvConversation.HideSelection = False
            Me.tvConversation.ImageIndex = -1
            Me.tvConversation.Indent = 16
            Me.tvConversation.ItemHeight = 16
            Me.tvConversation.Location = New Global.System.Drawing.Point(32, 8)
            Me.tvConversation.Name = "tvConversation"
            Me.tvConversation.SelectedImageIndex = -1
            Me.tvConversation.Size = New Global.System.Drawing.Size(736, 272)
            Me.tvConversation.TabIndex = 0
            Me.tbConversationText.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tbConversationText.Location = New Global.System.Drawing.Point(32, 400)
            Me.tbConversationText.Multiline = True
            Me.tbConversationText.Name = "tbConversationText"
            Me.tbConversationText.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbConversationText.Size = New Global.System.Drawing.Size(240, 104)
            Me.tbConversationText.TabIndex = 4
            Me.tbConversationText.Text = ""
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label1.Location = New Global.System.Drawing.Point(32, 336)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Speaker Tag"
            Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label2.Location = New Global.System.Drawing.Point(32, 384)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Text"
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.tabpagActionsTaken)
            Me.TabControl1.Controls.Add(Me.tabpagCamera)
            Me.TabControl1.Controls.Add(Me.tabpagAnimationSound)
            Me.TabControl1.Controls.Add(Me.tabpagPlot)
            Me.TabControl1.Controls.Add(Me.tabpagComment)
            Me.TabControl1.Controls.Add(Me.tabpagThisFile1)
            Me.TabControl1.Controls.Add(Me.tabpagThisFile2)
            Me.TabControl1.Controls.Add(Me.tabpagThisFile3)
            Me.TabControl1.Controls.Add(Me.tabpagDebug)
            Me.TabControl1.Location = New Global.System.Drawing.Point(280, 296)
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New Global.System.Drawing.Point(8, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(488, 216)
            Me.TabControl1.SizeMode = Global.System.Windows.Forms.TabSizeMode.FillToRight
            Me.TabControl1.TabIndex = 5
            Me.tabpagActionsTaken.Controls.Add(Me.tbTextActiveScript)
            Me.tabpagActionsTaken.Controls.Add(Me.Label3)
            Me.tabpagActionsTaken.Controls.Add(Me.tbActionsTakenScript)
            Me.tabpagActionsTaken.Controls.Add(Me.Label4)
            Me.tabpagActionsTaken.Controls.Add(Me.tbTextActiveScript2)
            Me.tabpagActionsTaken.Controls.Add(Me.Label38)
            Me.tabpagActionsTaken.Controls.Add(Me.tbActionsTakenScript2)
            Me.tabpagActionsTaken.Controls.Add(Me.Label39)
            Me.tabpagActionsTaken.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagActionsTaken.Name = "tabpagActionsTaken"
            Me.tabpagActionsTaken.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagActionsTaken.TabIndex = 0
            Me.tabpagActionsTaken.Text = "Node Scripts"
            Me.tbTextActiveScript.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbTextActiveScript.Location = New Global.System.Drawing.Point(32, 88)
            Me.tbTextActiveScript.MaxLength = 16
            Me.tbTextActiveScript.Name = "tbTextActiveScript"
            Me.tbTextActiveScript.Size = New Global.System.Drawing.Size(120, 20)
            Me.tbTextActiveScript.TabIndex = 6
            Me.tbTextActiveScript.Text = ""
            Me.Label3.Location = New Global.System.Drawing.Point(32, 72)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(216, 24)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Script that determines if node is available"
            Me.tbActionsTakenScript.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbActionsTakenScript.Location = New Global.System.Drawing.Point(32, 32)
            Me.tbActionsTakenScript.MaxLength = 16
            Me.tbActionsTakenScript.Name = "tbActionsTakenScript"
            Me.tbActionsTakenScript.Size = New Global.System.Drawing.Size(120, 20)
            Me.tbActionsTakenScript.TabIndex = 4
            Me.tbActionsTakenScript.Text = ""
            Me.Label4.Location = New Global.System.Drawing.Point(32, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Script to run for this node"
            Me.tbTextActiveScript2.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbTextActiveScript2.Location = New Global.System.Drawing.Point(252, 88)
            Me.tbTextActiveScript2.MaxLength = 16
            Me.tbTextActiveScript2.Name = "tbTextActiveScript2"
            Me.tbTextActiveScript2.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbTextActiveScript2.TabIndex = 6
            Me.tbTextActiveScript2.Text = ""
            Me.tbTextActiveScript2.Visible = False
            Me.Label38.Location = New Global.System.Drawing.Point(252, 72)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New Global.System.Drawing.Size(232, 24)
            Me.Label38.TabIndex = 7
            Me.Label38.Text = "Script #2 that determines if node is available"
            Me.Label38.Visible = False
            Me.tbActionsTakenScript2.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbActionsTakenScript2.Location = New Global.System.Drawing.Point(252, 32)
            Me.tbActionsTakenScript2.MaxLength = 16
            Me.tbActionsTakenScript2.Name = "tbActionsTakenScript2"
            Me.tbActionsTakenScript2.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbActionsTakenScript2.TabIndex = 4
            Me.tbActionsTakenScript2.Text = ""
            Me.tbActionsTakenScript2.Visible = False
            Me.Label39.Location = New Global.System.Drawing.Point(252, 16)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New Global.System.Drawing.Size(144, 16)
            Me.Label39.TabIndex = 5
            Me.Label39.Text = "Script #2 to run for this node"
            Me.Label39.Visible = False
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
            Me.tabpagCamera.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagCamera.Name = "tabpagCamera"
            Me.tabpagCamera.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagCamera.TabIndex = 5
            Me.tabpagCamera.Text = "Camera"
            Me.nudCamFieldOfView.DecimalPlaces = 2
            Me.nudCamFieldOfView.Enabled = False
            Me.nudCamFieldOfView.Location = New Global.System.Drawing.Point(296, 80)
            Me.nudCamFieldOfView.Maximum = New Decimal(New Integer() {35999, 0, 0, 131072})
            Me.nudCamFieldOfView.Name = "nudCamFieldOfView"
            Me.nudCamFieldOfView.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudCamFieldOfView.TabIndex = 8
            Me.nudCamFieldOfView.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudCamFieldOfView, "This is the angle in degrees that the camera sees")
            Me.nudCamFieldOfView.Value = New Decimal(New Integer() {35999, 0, 0, 131072})
            Me.cmbxCamVidEffect.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxCamVidEffect.Items.AddRange(New Object() {"(none)", "Blue Filter", "Red Filter"})
            Me.cmbxCamVidEffect.Location = New Global.System.Drawing.Point(256, 48)
            Me.cmbxCamVidEffect.Name = "cmbxCamVidEffect"
            Me.cmbxCamVidEffect.Size = New Global.System.Drawing.Size(96, 21)
            Me.cmbxCamVidEffect.TabIndex = 12
            Me.ToolTip1.SetToolTip(Me.cmbxCamVidEffect, "Selecting one of the two colors will make the conversation look like it was viewed through a filter of that color")
            Me.nudFadeColorG.Enabled = False
            Me.nudFadeColorG.Location = New Global.System.Drawing.Point(368, 112)
            Me.nudFadeColorG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeColorG.Name = "nudFadeColorG"
            Me.nudFadeColorG.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudFadeColorG.TabIndex = 8
            Me.nudFadeColorG.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFadeColorB.Enabled = False
            Me.nudFadeColorB.Location = New Global.System.Drawing.Point(424, 112)
            Me.nudFadeColorB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeColorB.Name = "nudFadeColorB"
            Me.nudFadeColorB.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudFadeColorB.TabIndex = 9
            Me.nudFadeColorB.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFadeColorR.Enabled = False
            Me.nudFadeColorR.Location = New Global.System.Drawing.Point(312, 112)
            Me.nudFadeColorR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeColorR.Name = "nudFadeColorR"
            Me.nudFadeColorR.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudFadeColorR.TabIndex = 8
            Me.nudFadeColorR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.cmbxFadeType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFadeType.Items.AddRange(New Object() {"(none)", "Cut to Black", "Cut to Scene", "Fade to Scene", "Fade to Fade Color"})
            Me.cmbxFadeType.Location = New Global.System.Drawing.Point(384, 16)
            Me.cmbxFadeType.Name = "cmbxFadeType"
            Me.cmbxFadeType.Size = New Global.System.Drawing.Size(96, 21)
            Me.cmbxFadeType.TabIndex = 12
            Me.nudCameraID.Location = New Global.System.Drawing.Point(264, 16)
            Me.nudCameraID.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCameraID.Name = "nudCameraID"
            Me.nudCameraID.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudCameraID.TabIndex = 11
            Me.nudCameraID.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudCameraID, "The Camera ID indicates which Camera in a module shoould the Conversation be viewed from. It should be in the same room and the conversants.")
            Me.nudCamHeightOffset.DecimalPlaces = 2
            Me.nudCamHeightOffset.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudCamHeightOffset.Location = New Global.System.Drawing.Point(120, 48)
            Me.nudCamHeightOffset.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCamHeightOffset.Name = "nudCamHeightOffset"
            Me.nudCamHeightOffset.[ReadOnly] = True
            Me.nudCamHeightOffset.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudCamHeightOffset.TabIndex = 11
            Me.nudCamHeightOffset.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudCameraAngle.Location = New Global.System.Drawing.Point(120, 16)
            Me.nudCameraAngle.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudCameraAngle.Name = "nudCameraAngle"
            Me.nudCameraAngle.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudCameraAngle.TabIndex = 11
            Me.nudCameraAngle.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label7.Location = New Global.System.Drawing.Point(8, 16)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label7.TabIndex = 5
            Me.Label7.Text = "Camera Angle"
            Me.Label8.Location = New Global.System.Drawing.Point(320, 16)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label8.TabIndex = 5
            Me.Label8.Text = "Fade Type"
            Me.tbListener.Location = New Global.System.Drawing.Point(88, 112)
            Me.tbListener.Name = "tbListener"
            Me.tbListener.Size = New Global.System.Drawing.Size(136, 20)
            Me.tbListener.TabIndex = 3
            Me.tbListener.Text = ""
            Me.Label9.Location = New Global.System.Drawing.Point(8, 112)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label9.TabIndex = 5
            Me.Label9.Text = "Listener"
            Me.Label11.Location = New Global.System.Drawing.Point(360, 48)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label11.TabIndex = 5
            Me.Label11.Text = "Fade Delay"
            Me.Label13.Location = New Global.System.Drawing.Point(8, 48)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label13.TabIndex = 5
            Me.Label13.Text = "Camera Height Offset"
            Me.Label14.Location = New Global.System.Drawing.Point(360, 80)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(72, 16)
            Me.Label14.TabIndex = 5
            Me.Label14.Text = "Fade Length"
            Me.Label15.Location = New Global.System.Drawing.Point(248, 112)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(72, 16)
            Me.Label15.TabIndex = 5
            Me.Label15.Text = "Fade Color"
            Me.Label16.Location = New Global.System.Drawing.Point(8, 80)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label16.TabIndex = 5
            Me.Label16.Text = "Tar Height Offset"
            Me.btnChooseColor.Location = New Global.System.Drawing.Point(448, 144)
            Me.btnChooseColor.Name = "btnChooseColor"
            Me.btnChooseColor.Size = New Global.System.Drawing.Size(24, 23)
            Me.btnChooseColor.TabIndex = 10
            Me.btnChooseColor.Text = "..."
            Me.btnChooseColor.Visible = False
            Me.nudTarHeightOffset.DecimalPlaces = 2
            Me.nudTarHeightOffset.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudTarHeightOffset.Location = New Global.System.Drawing.Point(120, 80)
            Me.nudTarHeightOffset.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudTarHeightOffset.Name = "nudTarHeightOffset"
            Me.nudTarHeightOffset.[ReadOnly] = True
            Me.nudTarHeightOffset.Size = New Global.System.Drawing.Size(56, 20)
            Me.nudTarHeightOffset.TabIndex = 11
            Me.nudTarHeightOffset.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFadeDelay.DecimalPlaces = 2
            Me.nudFadeDelay.Enabled = False
            Me.nudFadeDelay.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudFadeDelay.Location = New Global.System.Drawing.Point(432, 48)
            Me.nudFadeDelay.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeDelay.Name = "nudFadeDelay"
            Me.nudFadeDelay.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudFadeDelay.TabIndex = 11
            Me.nudFadeDelay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFadeLength.DecimalPlaces = 2
            Me.nudFadeLength.Enabled = False
            Me.nudFadeLength.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
            Me.nudFadeLength.Location = New Global.System.Drawing.Point(432, 80)
            Me.nudFadeLength.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.nudFadeLength.Name = "nudFadeLength"
            Me.nudFadeLength.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudFadeLength.TabIndex = 11
            Me.nudFadeLength.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label28.Location = New Global.System.Drawing.Point(192, 16)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label28.TabIndex = 5
            Me.Label28.Text = "Camera ID"
            Me.Label29.Location = New Global.System.Drawing.Point(192, 46)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New Global.System.Drawing.Size(80, 32)
            Me.Label29.TabIndex = 5
            Me.Label29.Text = "Camera Vid Effect"
            Me.Label37.Location = New Global.System.Drawing.Point(192, 81)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label37.TabIndex = 5
            Me.Label37.Text = "Camera Field of View"
            Me.tabpagAnimationSound.Controls.Add(Me.dgAnimList)
            Me.tabpagAnimationSound.Controls.Add(Me.Label5)
            Me.tabpagAnimationSound.Controls.Add(Me.tbSound)
            Me.tabpagAnimationSound.Controls.Add(Me.Label6)
            Me.tabpagAnimationSound.Controls.Add(Me.tbVoiceOverResRef)
            Me.tabpagAnimationSound.Controls.Add(Me.Label10)
            Me.tabpagAnimationSound.Controls.Add(Me.btnDeleteAnimListEntry)
            Me.tabpagAnimationSound.Controls.Add(Me.btnAddAnimListEntry)
            Me.tabpagAnimationSound.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagAnimationSound.Name = "tabpagAnimationSound"
            Me.tabpagAnimationSound.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagAnimationSound.TabIndex = 1
            Me.tabpagAnimationSound.Text = "Animation/Sound"
            Me.dgAnimList.CaptionVisible = False
            Me.dgAnimList.DataMember = ""
            Me.dgAnimList.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Me.dgAnimList.Location = New Global.System.Drawing.Point(224, 32)
            Me.dgAnimList.Name = "dgAnimList"
            Me.dgAnimList.Size = New Global.System.Drawing.Size(248, 104)
            Me.dgAnimList.TabIndex = 8
            Me.Label5.Location = New Global.System.Drawing.Point(248, 8)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label5.TabIndex = 7
            Me.Label5.Text = "Play Animation"
            Me.tbSound.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbSound.Location = New Global.System.Drawing.Point(32, 89)
            Me.tbSound.MaxLength = 16
            Me.tbSound.Name = "tbSound"
            Me.tbSound.Size = New Global.System.Drawing.Size(120, 20)
            Me.tbSound.TabIndex = 2
            Me.tbSound.Text = ""
            Me.Label6.Location = New Global.System.Drawing.Point(32, 64)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "Play this sound (ResRef)"
            Me.tbVoiceOverResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbVoiceOverResRef.Location = New Global.System.Drawing.Point(32, 32)
            Me.tbVoiceOverResRef.MaxLength = 16
            Me.tbVoiceOverResRef.Name = "tbVoiceOverResRef"
            Me.tbVoiceOverResRef.Size = New Global.System.Drawing.Size(120, 20)
            Me.tbVoiceOverResRef.TabIndex = 3
            Me.tbVoiceOverResRef.Text = ""
            Me.Label10.Location = New Global.System.Drawing.Point(32, 8)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(184, 16)
            Me.Label10.TabIndex = 7
            Me.Label10.Text = "Play this Voice Over (ResRef)"
            Me.btnDeleteAnimListEntry.Enabled = False
            Me.btnDeleteAnimListEntry.Location = New Global.System.Drawing.Point(360, 144)
            Me.btnDeleteAnimListEntry.Name = "btnDeleteAnimListEntry"
            Me.btnDeleteAnimListEntry.Size = New Global.System.Drawing.Size(56, 23)
            Me.btnDeleteAnimListEntry.TabIndex = 6
            Me.btnDeleteAnimListEntry.Text = "Delete"
            Me.btnAddAnimListEntry.Location = New Global.System.Drawing.Point(288, 144)
            Me.btnAddAnimListEntry.Name = "btnAddAnimListEntry"
            Me.btnAddAnimListEntry.Size = New Global.System.Drawing.Size(56, 23)
            Me.btnAddAnimListEntry.TabIndex = 6
            Me.btnAddAnimListEntry.Text = "Add"
            Me.tabpagPlot.Controls.Add(Me.tbQuest)
            Me.tabpagPlot.Controls.Add(Me.Label35)
            Me.tabpagPlot.Controls.Add(Me.nudPlotIndex)
            Me.tabpagPlot.Controls.Add(Me.lblPlotIndex)
            Me.tabpagPlot.Controls.Add(Me.Label12)
            Me.tabpagPlot.Controls.Add(Me.nudPlotXPPercentage)
            Me.tabpagPlot.Controls.Add(Me.Label36)
            Me.tabpagPlot.Controls.Add(Me.nudQuestEntry)
            Me.tabpagPlot.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagPlot.Name = "tabpagPlot"
            Me.tabpagPlot.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagPlot.TabIndex = 6
            Me.tabpagPlot.Text = "Plot/Quest"
            Me.tbQuest.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbQuest.Location = New Global.System.Drawing.Point(176, 40)
            Me.tbQuest.Name = "tbQuest"
            Me.tbQuest.Size = New Global.System.Drawing.Size(224, 20)
            Me.tbQuest.TabIndex = 14
            Me.tbQuest.Text = ""
            Me.Label35.Location = New Global.System.Drawing.Point(176, 80)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label35.TabIndex = 15
            Me.Label35.Text = "Quest Entry"
            Me.nudPlotIndex.Location = New Global.System.Drawing.Point(32, 40)
            Me.nudPlotIndex.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
            Me.nudPlotIndex.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.nudPlotIndex.Name = "nudPlotIndex"
            Me.nudPlotIndex.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudPlotIndex.TabIndex = 12
            Me.nudPlotIndex.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudPlotIndex.Value = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            Me.lblPlotIndex.Location = New Global.System.Drawing.Point(32, 24)
            Me.lblPlotIndex.Name = "lblPlotIndex"
            Me.lblPlotIndex.Size = New Global.System.Drawing.Size(100, 16)
            Me.lblPlotIndex.TabIndex = 11
            Me.lblPlotIndex.Text = "Plot Index"
            Me.Label12.Location = New Global.System.Drawing.Point(32, 80)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label12.TabIndex = 10
            Me.Label12.Text = "Plot XP Percentage"
            Me.nudPlotXPPercentage.Location = New Global.System.Drawing.Point(32, 96)
            Me.nudPlotXPPercentage.Name = "nudPlotXPPercentage"
            Me.nudPlotXPPercentage.Size = New Global.System.Drawing.Size(40, 20)
            Me.nudPlotXPPercentage.TabIndex = 12
            Me.nudPlotXPPercentage.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudPlotXPPercentage.Value = New Decimal(New Integer() {100, 0, 0, 0})
            Me.Label36.Location = New Global.System.Drawing.Point(176, 24)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label36.TabIndex = 15
            Me.Label36.Text = "Quest"
            Me.nudQuestEntry.Location = New Global.System.Drawing.Point(176, 96)
            Me.nudQuestEntry.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
            Me.nudQuestEntry.Name = "nudQuestEntry"
            Me.nudQuestEntry.Size = New Global.System.Drawing.Size(88, 20)
            Me.nudQuestEntry.TabIndex = 12
            Me.nudQuestEntry.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tabpagComment.Controls.Add(Me.tbComments)
            Me.tabpagComment.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagComment.Name = "tabpagComment"
            Me.tabpagComment.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagComment.TabIndex = 2
            Me.tabpagComment.Text = "Comments"
            Me.tbComments.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbComments.Location = New Global.System.Drawing.Point(8, 16)
            Me.tbComments.Multiline = True
            Me.tbComments.Name = "tbComments"
            Me.tbComments.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbComments.Size = New Global.System.Drawing.Size(456, 136)
            Me.tbComments.TabIndex = 1
            Me.tbComments.Text = ""
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
            Me.tabpagThisFile1.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagThisFile1.Name = "tabpagThisFile1"
            Me.tabpagThisFile1.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagThisFile1.TabIndex = 3
            Me.tabpagThisFile1.Text = "This File (1)"
            Me.chkbAnimatedCut.Location = New Global.System.Drawing.Point(16, 136)
            Me.chkbAnimatedCut.Name = "chkbAnimatedCut"
            Me.chkbAnimatedCut.Size = New Global.System.Drawing.Size(128, 24)
            Me.chkbAnimatedCut.TabIndex = 16
            Me.chkbAnimatedCut.Text = "Animated Cutscene"
            Me.tbCameraModel.Enabled = False
            Me.tbCameraModel.Location = New Global.System.Drawing.Point(160, 143)
            Me.tbCameraModel.MaxLength = 16
            Me.tbCameraModel.Name = "tbCameraModel"
            Me.tbCameraModel.Size = New Global.System.Drawing.Size(120, 20)
            Me.tbCameraModel.TabIndex = 14
            Me.tbCameraModel.Text = ""
            Me.ToolTip1.SetToolTip(Me.tbCameraModel, "This is the model name of the camera to use in Animated Cutscenes")
            Me.Label31.Location = New Global.System.Drawing.Point(160, 128)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label31.TabIndex = 15
            Me.Label31.Text = "Camera Model"
            Me.cmbxConversationType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxConversationType.Items.AddRange(New Object() {"Human", "Computer", "Type 2", "Type 3", "Type 4"})
            Me.cmbxConversationType.Location = New Global.System.Drawing.Point(8, 64)
            Me.cmbxConversationType.Name = "cmbxConversationType"
            Me.cmbxConversationType.Size = New Global.System.Drawing.Size(88, 21)
            Me.cmbxConversationType.TabIndex = 12
            Me.chkbSkippable.Location = New Global.System.Drawing.Point(320, 8)
            Me.chkbSkippable.Name = "chkbSkippable"
            Me.chkbSkippable.Size = New Global.System.Drawing.Size(80, 24)
            Me.chkbSkippable.TabIndex = 11
            Me.chkbSkippable.Text = "Skippable"
            Me.tbVO_ID.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbVO_ID.Location = New Global.System.Drawing.Point(8, 24)
            Me.tbVO_ID.Name = "tbVO_ID"
            Me.tbVO_ID.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbVO_ID.TabIndex = 8
            Me.tbVO_ID.Text = ""
            Me.Label20.Location = New Global.System.Drawing.Point(8, 8)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label20.TabIndex = 9
            Me.Label20.Text = "Voice Over Family ID"
            Me.Label21.Location = New Global.System.Drawing.Point(8, 48)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label21.TabIndex = 9
            Me.Label21.Text = "Conversation Type"
            Me.tbEndConversation.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbEndConversation.Location = New Global.System.Drawing.Point(160, 24)
            Me.tbEndConversation.MaxLength = 16
            Me.tbEndConversation.Name = "tbEndConversation"
            Me.tbEndConversation.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbEndConversation.TabIndex = 8
            Me.tbEndConversation.Text = ""
            Me.Label22.Location = New Global.System.Drawing.Point(160, 8)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label22.TabIndex = 9
            Me.Label22.Text = "End Conv Normal Script"
            Me.Label23.Location = New Global.System.Drawing.Point(160, 48)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label23.TabIndex = 9
            Me.Label23.Text = "End Conv Abort Script"
            Me.tbEndConverAbort.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbEndConverAbort.Location = New Global.System.Drawing.Point(160, 64)
            Me.tbEndConverAbort.MaxLength = 16
            Me.tbEndConverAbort.Name = "tbEndConverAbort"
            Me.tbEndConverAbort.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbEndConverAbort.TabIndex = 8
            Me.tbEndConverAbort.Text = ""
            Me.Label24.Location = New Global.System.Drawing.Point(8, 88)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New Global.System.Drawing.Size(104, 16)
            Me.Label24.TabIndex = 9
            Me.Label24.Text = "Computer Type"
            Me.tbAmbientTrack.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbAmbientTrack.Location = New Global.System.Drawing.Point(160, 104)
            Me.tbAmbientTrack.MaxLength = 16
            Me.tbAmbientTrack.Name = "tbAmbientTrack"
            Me.tbAmbientTrack.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbAmbientTrack.TabIndex = 8
            Me.tbAmbientTrack.Text = ""
            Me.Label25.Location = New Global.System.Drawing.Point(160, 88)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label25.TabIndex = 9
            Me.Label25.Text = "Ambient Track"
            Me.chkbUnequipItems.Location = New Global.System.Drawing.Point(320, 32)
            Me.chkbUnequipItems.Name = "chkbUnequipItems"
            Me.chkbUnequipItems.Size = New Global.System.Drawing.Size(96, 24)
            Me.chkbUnequipItems.TabIndex = 11
            Me.chkbUnequipItems.Text = "Unequip Items"
            Me.chkbUnequipHItem.Location = New Global.System.Drawing.Point(320, 56)
            Me.chkbUnequipHItem.Name = "chkbUnequipHItem"
            Me.chkbUnequipHItem.TabIndex = 11
            Me.chkbUnequipHItem.Text = "Unequip HItem"
            Me.Label26.Location = New Global.System.Drawing.Point(307, 88)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New Global.System.Drawing.Size(64, 16)
            Me.Label26.TabIndex = 9
            Me.Label26.Text = "Delay Entry"
            Me.nudDelayEntry.Location = New Global.System.Drawing.Point(304, 104)
            Me.nudDelayEntry.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudDelayEntry.Name = "nudDelayEntry"
            Me.nudDelayEntry.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudDelayEntry.TabIndex = 10
            Me.nudDelayEntry.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudDelayReply.Location = New Global.System.Drawing.Point(400, 104)
            Me.nudDelayReply.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudDelayReply.Name = "nudDelayReply"
            Me.nudDelayReply.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudDelayReply.TabIndex = 10
            Me.nudDelayReply.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label27.Location = New Global.System.Drawing.Point(400, 88)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New Global.System.Drawing.Size(72, 16)
            Me.Label27.TabIndex = 9
            Me.Label27.Text = "Delay Reply"
            Me.cmbxComputerType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxComputerType.Enabled = False
            Me.cmbxComputerType.Items.AddRange(New Object() {"Modern", "Ancient"})
            Me.cmbxComputerType.Location = New Global.System.Drawing.Point(8, 104)
            Me.cmbxComputerType.Name = "cmbxComputerType"
            Me.cmbxComputerType.Size = New Global.System.Drawing.Size(88, 21)
            Me.cmbxComputerType.TabIndex = 12
            Me.tabpagThisFile2.Controls.Add(Me.dgStuntList)
            Me.tabpagThisFile2.Controls.Add(Me.Label30)
            Me.tabpagThisFile2.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagThisFile2.Name = "tabpagThisFile2"
            Me.tabpagThisFile2.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagThisFile2.TabIndex = 8
            Me.tabpagThisFile2.Text = "This File (2)"
            Me.dgStuntList.DataMember = ""
            Me.dgStuntList.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Me.dgStuntList.Location = New Global.System.Drawing.Point(56, 24)
            Me.dgStuntList.Name = "dgStuntList"
            Me.dgStuntList.Size = New Global.System.Drawing.Size(368, 112)
            Me.dgStuntList.TabIndex = 0
            Me.Label30.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label30.Location = New Global.System.Drawing.Point(56, 24)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label30.TabIndex = 3
            Me.Label30.Text = "(Stunt List is View-only)"
            Me.tabpagThisFile3.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagThisFile3.Name = "tabpagThisFile3"
            Me.tabpagThisFile3.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagThisFile3.TabIndex = 9
            Me.tabpagThisFile3.Text = "This File (3)"
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
            Me.tabpagDebug.Location = New Global.System.Drawing.Point(4, 40)
            Me.tabpagDebug.Name = "tabpagDebug"
            Me.tabpagDebug.Size = New Global.System.Drawing.Size(480, 172)
            Me.tabpagDebug.TabIndex = 7
            Me.tabpagDebug.Text = "Debug information/Options"
            Me.trkbTVIndent.Location = New Global.System.Drawing.Point(280, 40)
            Me.trkbTVIndent.Maximum = 30
            Me.trkbTVIndent.Minimum = 15
            Me.trkbTVIndent.Name = "trkbTVIndent"
            Me.trkbTVIndent.Size = New Global.System.Drawing.Size(120, 42)
            Me.trkbTVIndent.TabIndex = 9
            Me.trkbTVIndent.Value = 16
            Me.Label17.Location = New Global.System.Drawing.Point(56, 32)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label17.TabIndex = 8
            Me.Label17.Text = "Link ID"
            Me.tbLinkID.Location = New Global.System.Drawing.Point(168, 30)
            Me.tbLinkID.Name = "tbLinkID"
            Me.tbLinkID.Size = New Global.System.Drawing.Size(56, 20)
            Me.tbLinkID.TabIndex = 7
            Me.tbLinkID.Text = ""
            Me.tbLinkedCnt.Location = New Global.System.Drawing.Point(168, 64)
            Me.tbLinkedCnt.Name = "tbLinkedCnt"
            Me.tbLinkedCnt.Size = New Global.System.Drawing.Size(56, 20)
            Me.tbLinkedCnt.TabIndex = 7
            Me.tbLinkedCnt.Text = ""
            Me.tbSharedCnt.Location = New Global.System.Drawing.Point(168, 96)
            Me.tbSharedCnt.Name = "tbSharedCnt"
            Me.tbSharedCnt.Size = New Global.System.Drawing.Size(56, 20)
            Me.tbSharedCnt.TabIndex = 7
            Me.tbSharedCnt.Text = ""
            Me.Label18.Location = New Global.System.Drawing.Point(56, 66)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label18.TabIndex = 8
            Me.Label18.Text = "Linked to this"
            Me.Label19.Location = New Global.System.Drawing.Point(56, 98)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label19.TabIndex = 8
            Me.Label19.Text = "Nodes sharing link"
            Me.btnDebug.Location = New Global.System.Drawing.Point(280, 144)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New Global.System.Drawing.Size(120, 23)
            Me.btnDebug.TabIndex = 6
            Me.btnDebug.Text = "Show Debug Listing"
            Me.Label32.Location = New Global.System.Drawing.Point(288, 24)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label32.TabIndex = 8
            Me.Label32.Text = "Treeview indent level"
            Me.Label33.Location = New Global.System.Drawing.Point(288, 88)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label33.TabIndex = 8
            Me.Label33.Text = "Treeview item height"
            Me.trkbTVItemHeight.Location = New Global.System.Drawing.Point(280, 104)
            Me.trkbTVItemHeight.Maximum = 21
            Me.trkbTVItemHeight.Minimum = 7
            Me.trkbTVItemHeight.Name = "trkbTVItemHeight"
            Me.trkbTVItemHeight.Size = New Global.System.Drawing.Size(120, 42)
            Me.trkbTVItemHeight.TabIndex = 9
            Me.trkbTVItemHeight.Value = 9
            Me.tbLinkDesc.Location = New Global.System.Drawing.Point(168, 128)
            Me.tbLinkDesc.Name = "tbLinkDesc"
            Me.tbLinkDesc.Size = New Global.System.Drawing.Size(56, 20)
            Me.tbLinkDesc.TabIndex = 7
            Me.tbLinkDesc.Text = ""
            Me.Label34.Location = New Global.System.Drawing.Point(56, 128)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label34.TabIndex = 8
            Me.Label34.Text = "Link Desc"
            Me.btnShowLists.Location = New Global.System.Drawing.Point(448, 144)
            Me.btnShowLists.Name = "btnShowLists"
            Me.btnShowLists.Size = New Global.System.Drawing.Size(24, 23)
            Me.btnShowLists.TabIndex = 6
            Me.btnShowLists.Text = "D"
            Me.btnShowLists.Visible = False
            Me.btnCollapseAll.Image = CType(resources.GetObject("Me.btnCollapseAll.Image"), Global.System.Drawing.Image)
            Me.btnCollapseAll.Location = New Global.System.Drawing.Point(5, 240)
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Me.btnCollapseAll.Size = New Global.System.Drawing.Size(24, 23)
            Me.btnCollapseAll.TabIndex = 2
            Me.btnCollapseAll.Text = "C"
            Me.ToolTip1.SetToolTip(Me.btnCollapseAll, "Collapse all nodes in the treeview")
            Me.btnExpandAll.Image = CType(resources.GetObject("Me.btnExpandAll.Image"), Global.System.Drawing.Image)
            Me.btnExpandAll.Location = New Global.System.Drawing.Point(5, 184)
            Me.btnExpandAll.Name = "btnExpandAll"
            Me.btnExpandAll.Size = New Global.System.Drawing.Size(24, 23)
            Me.btnExpandAll.TabIndex = 1
            Me.btnExpandAll.Text = "E"
            Me.ToolTip1.SetToolTip(Me.btnExpandAll, "Expand all nodes in the treeview")
            Me.btnSave.Location = New Global.System.Drawing.Point(152, 312)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New Global.System.Drawing.Size(42, 23)
            Me.btnSave.TabIndex = 6
            Me.btnSave.Text = "Save"
            Me.btnSave.Visible = False
            Me.btnTest.Location = New Global.System.Drawing.Point(8, 312)
            Me.btnTest.Name = "btnTest"
            Me.btnTest.Size = New Global.System.Drawing.Size(40, 23)
            Me.btnTest.TabIndex = 5
            Me.btnTest.Text = "Test"
            Me.btnTest.Visible = False
            Me.cmTVfunctions.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiTV_Add, Me.cmiTV_Cut, Me.cmiTV_Copy, Me.cmiTV_Paste, Me.cmiTV_PasteTree, Me.cmiTV_PasteAsLink, Me.MenuItem2, Me.cmiTV_MoveNodeUp, Me.cmiTV_MoveNodeDown})
            Me.cmiTV_Add.Index = 0
            Me.cmiTV_Add.Text = "Add"
            Me.cmiTV_Cut.Index = 1
            Me.cmiTV_Cut.Text = "Cut"
            Me.cmiTV_Copy.Index = 2
            Me.cmiTV_Copy.Text = "Copy"
            Me.cmiTV_Paste.Index = 3
            Me.cmiTV_Paste.Text = "Paste Top Node on Clipboard"
            Me.cmiTV_PasteTree.Index = 4
            Me.cmiTV_PasteTree.Text = "Paste Tree on Clipboard"
            Me.cmiTV_PasteAsLink.Index = 5
            Me.cmiTV_PasteAsLink.Text = "Paste As Link"
            Me.MenuItem2.Index = 6
            Me.MenuItem2.Text = "-"
            Me.cmiTV_MoveNodeUp.Index = 7
            Me.cmiTV_MoveNodeUp.Text = "Move up"
            Me.cmiTV_MoveNodeDown.Index = 8
            Me.cmiTV_MoveNodeDown.Text = "Move down"
            Me.tbSpeaker.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tbSpeaker.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Me.tbSpeaker.Location = New Global.System.Drawing.Point(32, 360)
            Me.tbSpeaker.Name = "tbSpeaker"
            Me.tbSpeaker.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbSpeaker.TabIndex = 9
            Me.tbSpeaker.Text = ""
            Me.btnOpen.Location = New Global.System.Drawing.Point(88, 312)
            Me.btnOpen.Name = "btnOpen"
            Me.btnOpen.Size = New Global.System.Drawing.Size(48, 23)
            Me.btnOpen.TabIndex = 6
            Me.btnOpen.Text = "Open"
            Me.btnOpen.Visible = False
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miNew, Me.miOpen, Me.miSave, Me.MenuItem4, Me.miQuit})
            Me.MenuItem1.Text = "File"
            Me.miNew.Index = 0
            Me.miNew.Text = "New"
            Me.miOpen.Index = 1
            Me.miOpen.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpen.Text = "&Open"
            Me.miSave.Index = 2
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            Me.MenuItem4.Index = 3
            Me.MenuItem4.Text = "-"
            Me.miQuit.Index = 4
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(792, 517)
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
            Me.tabpagCamera.ResumeLayout(False)
            CType(Me.nudCamFieldOfView, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeColorG, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeColorB, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeColorR, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCameraID, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCamHeightOffset, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCameraAngle, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTarHeightOffset, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeDelay, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFadeLength, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagAnimationSound.ResumeLayout(False)
            CType(Me.dgAnimList, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagPlot.ResumeLayout(False)
            CType(Me.nudPlotIndex, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudPlotXPPercentage, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudQuestEntry, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagComment.ResumeLayout(False)
            Me.tabpagThisFile1.ResumeLayout(False)
            CType(Me.nudDelayEntry, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudDelayReply, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagThisFile2.ResumeLayout(False)
            CType(Me.dgStuntList, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagDebug.ResumeLayout(False)
            CType(Me.trkbTVIndent, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trkbTVItemHeight, Global.System.ComponentModel.ISupportInitialize).EndInit()

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.tvConversation.AfterSelect, AddressOf Me.tvConversation_AfterSelect
            AddHandler Me.tvConversation.MouseUp, AddressOf Me.tvConversation_MouseUp
            AddHandler Me.tvConversation.MouseDown, AddressOf Me.tvConversation_MouseDown
            AddHandler Me.btnCollapseAll.Click, AddressOf Me.btnCollapseAll_Click
            AddHandler Me.btnExpandAll.Click, AddressOf Me.btnExpandAll_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.btnTest.Click, AddressOf Me.btnTest_Click
            AddHandler Me.btnChooseColor.Click, AddressOf Me.btnChooseColor_Click
            AddHandler Me.cmiTV_Add.Click, AddressOf Me.cmiTV_Add_Click
            AddHandler Me.cmiTV_Copy.Click, AddressOf Me.cmiTV_Copy_Click
            AddHandler Me.cmiTV_Paste.Click, AddressOf Me.cmiTV_Paste_Click
            AddHandler Me.cmiTV_PasteAsLink.Click, AddressOf Me.cmiTV_PasteAsLink_Click
            AddHandler Me.cmiTV_Cut.Click, AddressOf Me.cmiTV_Cut_Click
            AddHandler Me.btnSave.Click, AddressOf Me.Button1_Click
            AddHandler Me.btnOpen.Click, AddressOf Me.btnOpen_Click
            AddHandler Me.miOpen.Click, AddressOf Me.miOpen_Click
            AddHandler Me.miSave.Click, AddressOf Me.miSave_Click
            AddHandler Me.miQuit.Click, AddressOf Me.miQuit_Click
            AddHandler Me.dgAnimList.Validated, AddressOf Me.dgAnimList_Validated
            AddHandler Me.dgAnimList.Click, AddressOf Me.dgAnimList_Click
            AddHandler Me.btnDeleteAnimListEntry.Click, AddressOf Me.btnDeleteAnimListEntry_Click
            AddHandler Me.btnAddAnimListEntry.Click, AddressOf Me.btnAddAnimListEntry_Click
            AddHandler Me.trkbTVIndent.Scroll, AddressOf Me.trkbTVIndent_Scroll
            AddHandler Me.miNew.Click, AddressOf Me.miNew_Click
            AddHandler Me.trkbTVItemHeight.Scroll, AddressOf Me.trkbTVItemHeight_Scroll
            AddHandler Me.cmiTV_PasteTree.Click, AddressOf Me.cmiTV_PasteTree_Click
            AddHandler Me.cmbxConversationType.SelectedIndexChanged, AddressOf Me.cmbxConversationType_SelectedIndexChanged
            AddHandler Me.btnShowLists.Click, AddressOf Me.btnShowLists_Click
            AddHandler Me.chkbAnimatedCut.CheckedChanged, AddressOf Me.chkbAnimatedCut_CheckedChanged
            AddHandler Me.cmiTV_MoveNodeUp.Click, AddressOf Me.cmiTV_MoveNodeUp_Click
            AddHandler Me.cmiTV_MoveNodeDown.Click, AddressOf Me.cmiTV_MoveNodeDown_Click
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace
