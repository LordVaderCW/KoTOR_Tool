Namespace kotor_tool
	' Token: 0x02000047 RID: 71
	Public Partial Class frmDialogEditor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x0600030F RID: 783 RVA: 0x002310AC File Offset: 0x002300AC
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600040C RID: 1036 RVA: 0x00232F1C File Offset: 0x00231F1C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmDialogEditor))
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
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
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
            Dim tvConversation As Global.System.Windows.Forms.Control = Me.tvConversation
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(32, 8)
            tvConversation.Location = point
            Me.tvConversation.Name = "tvConversation"
            Me.tvConversation.SelectedImageIndex = -1
            Dim tvConversation2 As Global.System.Windows.Forms.Control = Me.tvConversation
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(736, 272)
            tvConversation2.Size = size
            Me.tvConversation.TabIndex = 0
            Me.tbConversationText.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim tbConversationText As Global.System.Windows.Forms.Control = Me.tbConversationText
            point = New Global.System.Drawing.Point(32, 400)
            tbConversationText.Location = point
            Me.tbConversationText.Multiline = True
            Me.tbConversationText.Name = "tbConversationText"
            Me.tbConversationText.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Dim tbConversationText2 As Global.System.Windows.Forms.Control = Me.tbConversationText
            size = New Global.System.Drawing.Size(240, 104)
            tbConversationText2.Size = size
            Me.tbConversationText.TabIndex = 4
            Me.tbConversationText.Text = ""
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(32, 336)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(100, 16)
            label2.Size = size
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Speaker Tag"
            Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(32, 384)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(100, 16)
            label4.Size = size
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
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            point = New Global.System.Drawing.Point(280, 296)
            tabControl.Location = point
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Dim tabControl2 As Global.System.Windows.Forms.TabControl = Me.TabControl1
            point = New Global.System.Drawing.Point(8, 3)
            tabControl2.Padding = point
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl3 As Global.System.Windows.Forms.Control = Me.TabControl1
            size = New Global.System.Drawing.Size(488, 216)
            tabControl3.Size = size
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
            Dim tabpagActionsTaken As Global.System.Windows.Forms.Control = Me.tabpagActionsTaken
            point = New Global.System.Drawing.Point(4, 40)
            tabpagActionsTaken.Location = point
            Me.tabpagActionsTaken.Name = "tabpagActionsTaken"
            Dim tabpagActionsTaken2 As Global.System.Windows.Forms.Control = Me.tabpagActionsTaken
            size = New Global.System.Drawing.Size(480, 172)
            tabpagActionsTaken2.Size = size
            Me.tabpagActionsTaken.TabIndex = 0
            Me.tabpagActionsTaken.Text = "Node Scripts"
            Me.tbTextActiveScript.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbTextActiveScript As Global.System.Windows.Forms.Control = Me.tbTextActiveScript
            point = New Global.System.Drawing.Point(32, 88)
            tbTextActiveScript.Location = point
            Me.tbTextActiveScript.MaxLength = 16
            Me.tbTextActiveScript.Name = "tbTextActiveScript"
            Dim tbTextActiveScript2 As Global.System.Windows.Forms.Control = Me.tbTextActiveScript
            size = New Global.System.Drawing.Size(120, 20)
            tbTextActiveScript2.Size = size
            Me.tbTextActiveScript.TabIndex = 6
            Me.tbTextActiveScript.Text = ""
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(32, 72)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(216, 24)
            label6.Size = size
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Script that determines if node is available"
            Me.tbActionsTakenScript.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbActionsTakenScript As Global.System.Windows.Forms.Control = Me.tbActionsTakenScript
            point = New Global.System.Drawing.Point(32, 32)
            tbActionsTakenScript.Location = point
            Me.tbActionsTakenScript.MaxLength = 16
            Me.tbActionsTakenScript.Name = "tbActionsTakenScript"
            Dim tbActionsTakenScript2 As Global.System.Windows.Forms.Control = Me.tbActionsTakenScript
            size = New Global.System.Drawing.Size(120, 20)
            tbActionsTakenScript2.Size = size
            Me.tbActionsTakenScript.TabIndex = 4
            Me.tbActionsTakenScript.Text = ""
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(32, 16)
            label7.Location = point
            Me.Label4.Name = "Label4"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(136, 16)
            label8.Size = size
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "Script to run for this node"
            Me.tbTextActiveScript2.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbTextActiveScript3 As Global.System.Windows.Forms.Control = Me.tbTextActiveScript2
            point = New Global.System.Drawing.Point(252, 88)
            tbTextActiveScript3.Location = point
            Me.tbTextActiveScript2.MaxLength = 16
            Me.tbTextActiveScript2.Name = "tbTextActiveScript2"
            Dim tbTextActiveScript4 As Global.System.Windows.Forms.Control = Me.tbTextActiveScript2
            size = New Global.System.Drawing.Size(128, 20)
            tbTextActiveScript4.Size = size
            Me.tbTextActiveScript2.TabIndex = 6
            Me.tbTextActiveScript2.Text = ""
            Me.tbTextActiveScript2.Visible = False
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label38
            point = New Global.System.Drawing.Point(252, 72)
            label9.Location = point
            Me.Label38.Name = "Label38"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label38
            size = New Global.System.Drawing.Size(232, 24)
            label10.Size = size
            Me.Label38.TabIndex = 7
            Me.Label38.Text = "Script #2 that determines if node is available"
            Me.Label38.Visible = False
            Me.tbActionsTakenScript2.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbActionsTakenScript3 As Global.System.Windows.Forms.Control = Me.tbActionsTakenScript2
            point = New Global.System.Drawing.Point(252, 32)
            tbActionsTakenScript3.Location = point
            Me.tbActionsTakenScript2.MaxLength = 16
            Me.tbActionsTakenScript2.Name = "tbActionsTakenScript2"
            Dim tbActionsTakenScript4 As Global.System.Windows.Forms.Control = Me.tbActionsTakenScript2
            size = New Global.System.Drawing.Size(128, 20)
            tbActionsTakenScript4.Size = size
            Me.tbActionsTakenScript2.TabIndex = 4
            Me.tbActionsTakenScript2.Text = ""
            Me.tbActionsTakenScript2.Visible = False
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label39
            point = New Global.System.Drawing.Point(252, 16)
            label11.Location = point
            Me.Label39.Name = "Label39"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label39
            size = New Global.System.Drawing.Size(144, 16)
            label12.Size = size
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
            Dim tabpagCamera As Global.System.Windows.Forms.Control = Me.tabpagCamera
            point = New Global.System.Drawing.Point(4, 40)
            tabpagCamera.Location = point
            Me.tabpagCamera.Name = "tabpagCamera"
            Dim tabpagCamera2 As Global.System.Windows.Forms.Control = Me.tabpagCamera
            size = New Global.System.Drawing.Size(480, 172)
            tabpagCamera2.Size = size
            Me.tabpagCamera.TabIndex = 5
            Me.tabpagCamera.Text = "Camera"
            Me.nudCamFieldOfView.DecimalPlaces = 2
            Me.nudCamFieldOfView.Enabled = False
            Dim nudCamFieldOfView As Global.System.Windows.Forms.Control = Me.nudCamFieldOfView
            point = New Global.System.Drawing.Point(296, 80)
            nudCamFieldOfView.Location = point
            Dim nudCamFieldOfView2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamFieldOfView
            Dim num As Decimal = New Decimal(New Integer() {35999, 0, 0, 131072})
            nudCamFieldOfView2.Maximum = num
            Me.nudCamFieldOfView.Name = "nudCamFieldOfView"
            Dim nudCamFieldOfView3 As Global.System.Windows.Forms.Control = Me.nudCamFieldOfView
            size = New Global.System.Drawing.Size(56, 20)
            nudCamFieldOfView3.Size = size
            Me.nudCamFieldOfView.TabIndex = 8
            Me.nudCamFieldOfView.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudCamFieldOfView, "This is the angle in degrees that the camera sees")
            Dim nudCamFieldOfView4 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamFieldOfView
            num = New Decimal(New Integer() {35999, 0, 0, 131072})
            nudCamFieldOfView4.Value = num
            Me.cmbxCamVidEffect.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxCamVidEffect.Items.AddRange(New Object() {"(none)", "Blue Filter", "Red Filter"})
            Dim cmbxCamVidEffect As Global.System.Windows.Forms.Control = Me.cmbxCamVidEffect
            point = New Global.System.Drawing.Point(256, 48)
            cmbxCamVidEffect.Location = point
            Me.cmbxCamVidEffect.Name = "cmbxCamVidEffect"
            Dim cmbxCamVidEffect2 As Global.System.Windows.Forms.Control = Me.cmbxCamVidEffect
            size = New Global.System.Drawing.Size(96, 21)
            cmbxCamVidEffect2.Size = size
            Me.cmbxCamVidEffect.TabIndex = 12
            Me.ToolTip1.SetToolTip(Me.cmbxCamVidEffect, "Selecting one of the two colors will make the conversation look like it was viewed through a filter of that color")
            Me.nudFadeColorG.Enabled = False
            Dim nudFadeColorG As Global.System.Windows.Forms.Control = Me.nudFadeColorG
            point = New Global.System.Drawing.Point(368, 112)
            nudFadeColorG.Location = point
            Dim nudFadeColorG2 As Global.System.Windows.Forms.NumericUpDown = Me.nudFadeColorG
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudFadeColorG2.Maximum = num
            Me.nudFadeColorG.Name = "nudFadeColorG"
            Dim nudFadeColorG3 As Global.System.Windows.Forms.Control = Me.nudFadeColorG
            size = New Global.System.Drawing.Size(48, 20)
            nudFadeColorG3.Size = size
            Me.nudFadeColorG.TabIndex = 8
            Me.nudFadeColorG.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFadeColorB.Enabled = False
            Dim nudFadeColorB As Global.System.Windows.Forms.Control = Me.nudFadeColorB
            point = New Global.System.Drawing.Point(424, 112)
            nudFadeColorB.Location = point
            Dim nudFadeColorB2 As Global.System.Windows.Forms.NumericUpDown = Me.nudFadeColorB
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudFadeColorB2.Maximum = num
            Me.nudFadeColorB.Name = "nudFadeColorB"
            Dim nudFadeColorB3 As Global.System.Windows.Forms.Control = Me.nudFadeColorB
            size = New Global.System.Drawing.Size(48, 20)
            nudFadeColorB3.Size = size
            Me.nudFadeColorB.TabIndex = 9
            Me.nudFadeColorB.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFadeColorR.Enabled = False
            Dim nudFadeColorR As Global.System.Windows.Forms.Control = Me.nudFadeColorR
            point = New Global.System.Drawing.Point(312, 112)
            nudFadeColorR.Location = point
            Dim nudFadeColorR2 As Global.System.Windows.Forms.NumericUpDown = Me.nudFadeColorR
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudFadeColorR2.Maximum = num
            Me.nudFadeColorR.Name = "nudFadeColorR"
            Dim nudFadeColorR3 As Global.System.Windows.Forms.Control = Me.nudFadeColorR
            size = New Global.System.Drawing.Size(48, 20)
            nudFadeColorR3.Size = size
            Me.nudFadeColorR.TabIndex = 8
            Me.nudFadeColorR.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.cmbxFadeType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFadeType.Items.AddRange(New Object() {"(none)", "Cut to Black", "Cut to Scene", "Fade to Scene", "Fade to Fade Color"})
            Dim cmbxFadeType As Global.System.Windows.Forms.Control = Me.cmbxFadeType
            point = New Global.System.Drawing.Point(384, 16)
            cmbxFadeType.Location = point
            Me.cmbxFadeType.Name = "cmbxFadeType"
            Dim cmbxFadeType2 As Global.System.Windows.Forms.Control = Me.cmbxFadeType
            size = New Global.System.Drawing.Size(96, 21)
            cmbxFadeType2.Size = size
            Me.cmbxFadeType.TabIndex = 12
            Dim nudCameraID As Global.System.Windows.Forms.Control = Me.nudCameraID
            point = New Global.System.Drawing.Point(264, 16)
            nudCameraID.Location = point
            Dim nudCameraID2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCameraID
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudCameraID2.Maximum = num
            Me.nudCameraID.Name = "nudCameraID"
            Dim nudCameraID3 As Global.System.Windows.Forms.Control = Me.nudCameraID
            size = New Global.System.Drawing.Size(40, 20)
            nudCameraID3.Size = size
            Me.nudCameraID.TabIndex = 11
            Me.nudCameraID.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.ToolTip1.SetToolTip(Me.nudCameraID, "The Camera ID indicates which Camera in a module shoould the Conversation be viewed from. It should be in the same room and the conversants.")
            Me.nudCamHeightOffset.DecimalPlaces = 2
            Dim nudCamHeightOffset As Global.System.Windows.Forms.NumericUpDown = Me.nudCamHeightOffset
            num = New Decimal(New Integer() {5, 0, 0, 131072})
            nudCamHeightOffset.Increment = num
            Dim nudCamHeightOffset2 As Global.System.Windows.Forms.Control = Me.nudCamHeightOffset
            point = New Global.System.Drawing.Point(120, 48)
            nudCamHeightOffset2.Location = point
            Dim nudCamHeightOffset3 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamHeightOffset
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudCamHeightOffset3.Maximum = num
            Me.nudCamHeightOffset.Name = "nudCamHeightOffset"
            Me.nudCamHeightOffset.[ReadOnly] = True
            Dim nudCamHeightOffset4 As Global.System.Windows.Forms.Control = Me.nudCamHeightOffset
            size = New Global.System.Drawing.Size(56, 20)
            nudCamHeightOffset4.Size = size
            Me.nudCamHeightOffset.TabIndex = 11
            Me.nudCamHeightOffset.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudCameraAngle As Global.System.Windows.Forms.Control = Me.nudCameraAngle
            point = New Global.System.Drawing.Point(120, 16)
            nudCameraAngle.Location = point
            Dim nudCameraAngle2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCameraAngle
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudCameraAngle2.Maximum = num
            Me.nudCameraAngle.Name = "nudCameraAngle"
            Dim nudCameraAngle3 As Global.System.Windows.Forms.Control = Me.nudCameraAngle
            size = New Global.System.Drawing.Size(40, 20)
            nudCameraAngle3.Size = size
            Me.nudCameraAngle.TabIndex = 11
            Me.nudCameraAngle.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(8, 16)
            label13.Location = point
            Me.Label7.Name = "Label7"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(100, 16)
            label14.Size = size
            Me.Label7.TabIndex = 5
            Me.Label7.Text = "Camera Angle"
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label8
            point = New Global.System.Drawing.Point(320, 16)
            label15.Location = point
            Me.Label8.Name = "Label8"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label8
            size = New Global.System.Drawing.Size(64, 16)
            label16.Size = size
            Me.Label8.TabIndex = 5
            Me.Label8.Text = "Fade Type"
            Dim tbListener As Global.System.Windows.Forms.Control = Me.tbListener
            point = New Global.System.Drawing.Point(88, 112)
            tbListener.Location = point
            Me.tbListener.Name = "tbListener"
            Dim tbListener2 As Global.System.Windows.Forms.Control = Me.tbListener
            size = New Global.System.Drawing.Size(136, 20)
            tbListener2.Size = size
            Me.tbListener.TabIndex = 3
            Me.tbListener.Text = ""
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(8, 112)
            label17.Location = point
            Me.Label9.Name = "Label9"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(48, 16)
            label18.Size = size
            Me.Label9.TabIndex = 5
            Me.Label9.Text = "Listener"
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(360, 48)
            label19.Location = point
            Me.Label11.Name = "Label11"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(64, 16)
            label20.Size = size
            Me.Label11.TabIndex = 5
            Me.Label11.Text = "Fade Delay"
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label13
            point = New Global.System.Drawing.Point(8, 48)
            label21.Location = point
            Me.Label13.Name = "Label13"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label13
            size = New Global.System.Drawing.Size(120, 16)
            label22.Size = size
            Me.Label13.TabIndex = 5
            Me.Label13.Text = "Camera Height Offset"
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(360, 80)
            label23.Location = point
            Me.Label14.Name = "Label14"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(72, 16)
            label24.Size = size
            Me.Label14.TabIndex = 5
            Me.Label14.Text = "Fade Length"
            Dim label25 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(248, 112)
            label25.Location = point
            Me.Label15.Name = "Label15"
            Dim label26 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(72, 16)
            label26.Size = size
            Me.Label15.TabIndex = 5
            Me.Label15.Text = "Fade Color"
            Dim label27 As Global.System.Windows.Forms.Control = Me.Label16
            point = New Global.System.Drawing.Point(8, 80)
            label27.Location = point
            Me.Label16.Name = "Label16"
            Dim label28 As Global.System.Windows.Forms.Control = Me.Label16
            size = New Global.System.Drawing.Size(96, 16)
            label28.Size = size
            Me.Label16.TabIndex = 5
            Me.Label16.Text = "Tar Height Offset"
            Dim btnChooseColor As Global.System.Windows.Forms.Control = Me.btnChooseColor
            point = New Global.System.Drawing.Point(448, 144)
            btnChooseColor.Location = point
            Me.btnChooseColor.Name = "btnChooseColor"
            Dim btnChooseColor2 As Global.System.Windows.Forms.Control = Me.btnChooseColor
            size = New Global.System.Drawing.Size(24, 23)
            btnChooseColor2.Size = size
            Me.btnChooseColor.TabIndex = 10
            Me.btnChooseColor.Text = "..."
            Me.btnChooseColor.Visible = False
            Me.nudTarHeightOffset.DecimalPlaces = 2
            Dim nudTarHeightOffset As Global.System.Windows.Forms.NumericUpDown = Me.nudTarHeightOffset
            num = New Decimal(New Integer() {5, 0, 0, 131072})
            nudTarHeightOffset.Increment = num
            Dim nudTarHeightOffset2 As Global.System.Windows.Forms.Control = Me.nudTarHeightOffset
            point = New Global.System.Drawing.Point(120, 80)
            nudTarHeightOffset2.Location = point
            Dim nudTarHeightOffset3 As Global.System.Windows.Forms.NumericUpDown = Me.nudTarHeightOffset
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudTarHeightOffset3.Maximum = num
            Me.nudTarHeightOffset.Name = "nudTarHeightOffset"
            Me.nudTarHeightOffset.[ReadOnly] = True
            Dim nudTarHeightOffset4 As Global.System.Windows.Forms.Control = Me.nudTarHeightOffset
            size = New Global.System.Drawing.Size(56, 20)
            nudTarHeightOffset4.Size = size
            Me.nudTarHeightOffset.TabIndex = 11
            Me.nudTarHeightOffset.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFadeDelay.DecimalPlaces = 2
            Me.nudFadeDelay.Enabled = False
            Dim nudFadeDelay As Global.System.Windows.Forms.NumericUpDown = Me.nudFadeDelay
            num = New Decimal(New Integer() {5, 0, 0, 131072})
            nudFadeDelay.Increment = num
            Dim nudFadeDelay2 As Global.System.Windows.Forms.Control = Me.nudFadeDelay
            point = New Global.System.Drawing.Point(432, 48)
            nudFadeDelay2.Location = point
            Dim nudFadeDelay3 As Global.System.Windows.Forms.NumericUpDown = Me.nudFadeDelay
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudFadeDelay3.Maximum = num
            Me.nudFadeDelay.Name = "nudFadeDelay"
            Dim nudFadeDelay4 As Global.System.Windows.Forms.Control = Me.nudFadeDelay
            size = New Global.System.Drawing.Size(48, 20)
            nudFadeDelay4.Size = size
            Me.nudFadeDelay.TabIndex = 11
            Me.nudFadeDelay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudFadeLength.DecimalPlaces = 2
            Me.nudFadeLength.Enabled = False
            Dim nudFadeLength As Global.System.Windows.Forms.NumericUpDown = Me.nudFadeLength
            num = New Decimal(New Integer() {5, 0, 0, 131072})
            nudFadeLength.Increment = num
            Dim nudFadeLength2 As Global.System.Windows.Forms.Control = Me.nudFadeLength
            point = New Global.System.Drawing.Point(432, 80)
            nudFadeLength2.Location = point
            Dim nudFadeLength3 As Global.System.Windows.Forms.NumericUpDown = Me.nudFadeLength
            num = New Decimal(New Integer() {255, 0, 0, 0})
            nudFadeLength3.Maximum = num
            Me.nudFadeLength.Name = "nudFadeLength"
            Dim nudFadeLength4 As Global.System.Windows.Forms.Control = Me.nudFadeLength
            size = New Global.System.Drawing.Size(48, 20)
            nudFadeLength4.Size = size
            Me.nudFadeLength.TabIndex = 11
            Me.nudFadeLength.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label29 As Global.System.Windows.Forms.Control = Me.Label28
            point = New Global.System.Drawing.Point(192, 16)
            label29.Location = point
            Me.Label28.Name = "Label28"
            Dim label30 As Global.System.Windows.Forms.Control = Me.Label28
            size = New Global.System.Drawing.Size(80, 16)
            label30.Size = size
            Me.Label28.TabIndex = 5
            Me.Label28.Text = "Camera ID"
            Dim label31 As Global.System.Windows.Forms.Control = Me.Label29
            point = New Global.System.Drawing.Point(192, 46)
            label31.Location = point
            Me.Label29.Name = "Label29"
            Dim label32 As Global.System.Windows.Forms.Control = Me.Label29
            size = New Global.System.Drawing.Size(80, 32)
            label32.Size = size
            Me.Label29.TabIndex = 5
            Me.Label29.Text = "Camera Vid Effect"
            Dim label33 As Global.System.Windows.Forms.Control = Me.Label37
            point = New Global.System.Drawing.Point(192, 81)
            label33.Location = point
            Me.Label37.Name = "Label37"
            Dim label34 As Global.System.Windows.Forms.Control = Me.Label37
            size = New Global.System.Drawing.Size(112, 16)
            label34.Size = size
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
            Dim tabpagAnimationSound As Global.System.Windows.Forms.Control = Me.tabpagAnimationSound
            point = New Global.System.Drawing.Point(4, 40)
            tabpagAnimationSound.Location = point
            Me.tabpagAnimationSound.Name = "tabpagAnimationSound"
            Dim tabpagAnimationSound2 As Global.System.Windows.Forms.Control = Me.tabpagAnimationSound
            size = New Global.System.Drawing.Size(480, 172)
            tabpagAnimationSound2.Size = size
            Me.tabpagAnimationSound.TabIndex = 1
            Me.tabpagAnimationSound.Text = "Animation/Sound"
            Me.dgAnimList.CaptionVisible = False
            Me.dgAnimList.DataMember = ""
            Me.dgAnimList.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Dim dgAnimList As Global.System.Windows.Forms.Control = Me.dgAnimList
            point = New Global.System.Drawing.Point(224, 32)
            dgAnimList.Location = point
            Me.dgAnimList.Name = "dgAnimList"
            Dim dgAnimList2 As Global.System.Windows.Forms.Control = Me.dgAnimList
            size = New Global.System.Drawing.Size(248, 104)
            dgAnimList2.Size = size
            Me.dgAnimList.TabIndex = 8
            Dim label35 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(248, 8)
            label35.Location = point
            Me.Label5.Name = "Label5"
            Dim label36 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(100, 16)
            label36.Size = size
            Me.Label5.TabIndex = 7
            Me.Label5.Text = "Play Animation"
            Me.tbSound.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbSound As Global.System.Windows.Forms.Control = Me.tbSound
            point = New Global.System.Drawing.Point(32, 89)
            tbSound.Location = point
            Me.tbSound.MaxLength = 16
            Me.tbSound.Name = "tbSound"
            Dim tbSound2 As Global.System.Windows.Forms.Control = Me.tbSound
            size = New Global.System.Drawing.Size(120, 20)
            tbSound2.Size = size
            Me.tbSound.TabIndex = 2
            Me.tbSound.Text = ""
            Dim label37 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(32, 64)
            label37.Location = point
            Me.Label6.Name = "Label6"
            Dim label38 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(136, 16)
            label38.Size = size
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "Play this sound (ResRef)"
            Me.tbVoiceOverResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbVoiceOverResRef As Global.System.Windows.Forms.Control = Me.tbVoiceOverResRef
            point = New Global.System.Drawing.Point(32, 32)
            tbVoiceOverResRef.Location = point
            Me.tbVoiceOverResRef.MaxLength = 16
            Me.tbVoiceOverResRef.Name = "tbVoiceOverResRef"
            Dim tbVoiceOverResRef2 As Global.System.Windows.Forms.Control = Me.tbVoiceOverResRef
            size = New Global.System.Drawing.Size(120, 20)
            tbVoiceOverResRef2.Size = size
            Me.tbVoiceOverResRef.TabIndex = 3
            Me.tbVoiceOverResRef.Text = ""
            Dim label39 As Global.System.Windows.Forms.Control = Me.Label10
            point = New Global.System.Drawing.Point(32, 8)
            label39.Location = point
            Me.Label10.Name = "Label10"
            Dim label40 As Global.System.Windows.Forms.Control = Me.Label10
            size = New Global.System.Drawing.Size(184, 16)
            label40.Size = size
            Me.Label10.TabIndex = 7
            Me.Label10.Text = "Play this Voice Over (ResRef)"
            Me.btnDeleteAnimListEntry.Enabled = False
            Dim btnDeleteAnimListEntry As Global.System.Windows.Forms.Control = Me.btnDeleteAnimListEntry
            point = New Global.System.Drawing.Point(360, 144)
            btnDeleteAnimListEntry.Location = point
            Me.btnDeleteAnimListEntry.Name = "btnDeleteAnimListEntry"
            Dim btnDeleteAnimListEntry2 As Global.System.Windows.Forms.Control = Me.btnDeleteAnimListEntry
            size = New Global.System.Drawing.Size(56, 23)
            btnDeleteAnimListEntry2.Size = size
            Me.btnDeleteAnimListEntry.TabIndex = 6
            Me.btnDeleteAnimListEntry.Text = "Delete"
            Dim btnAddAnimListEntry As Global.System.Windows.Forms.Control = Me.btnAddAnimListEntry
            point = New Global.System.Drawing.Point(288, 144)
            btnAddAnimListEntry.Location = point
            Me.btnAddAnimListEntry.Name = "btnAddAnimListEntry"
            Dim btnAddAnimListEntry2 As Global.System.Windows.Forms.Control = Me.btnAddAnimListEntry
            size = New Global.System.Drawing.Size(56, 23)
            btnAddAnimListEntry2.Size = size
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
            Dim tabpagPlot As Global.System.Windows.Forms.Control = Me.tabpagPlot
            point = New Global.System.Drawing.Point(4, 40)
            tabpagPlot.Location = point
            Me.tabpagPlot.Name = "tabpagPlot"
            Dim tabpagPlot2 As Global.System.Windows.Forms.Control = Me.tabpagPlot
            size = New Global.System.Drawing.Size(480, 172)
            tabpagPlot2.Size = size
            Me.tabpagPlot.TabIndex = 6
            Me.tabpagPlot.Text = "Plot/Quest"
            Me.tbQuest.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbQuest As Global.System.Windows.Forms.Control = Me.tbQuest
            point = New Global.System.Drawing.Point(176, 40)
            tbQuest.Location = point
            Me.tbQuest.Name = "tbQuest"
            Dim tbQuest2 As Global.System.Windows.Forms.Control = Me.tbQuest
            size = New Global.System.Drawing.Size(224, 20)
            tbQuest2.Size = size
            Me.tbQuest.TabIndex = 14
            Me.tbQuest.Text = ""
            Dim label41 As Global.System.Windows.Forms.Control = Me.Label35
            point = New Global.System.Drawing.Point(176, 80)
            label41.Location = point
            Me.Label35.Name = "Label35"
            Dim label42 As Global.System.Windows.Forms.Control = Me.Label35
            size = New Global.System.Drawing.Size(128, 16)
            label42.Size = size
            Me.Label35.TabIndex = 15
            Me.Label35.Text = "Quest Entry"
            Dim nudPlotIndex As Global.System.Windows.Forms.Control = Me.nudPlotIndex
            point = New Global.System.Drawing.Point(32, 40)
            nudPlotIndex.Location = point
            Dim nudPlotIndex2 As Global.System.Windows.Forms.NumericUpDown = Me.nudPlotIndex
            num = New Decimal(New Integer() {999, 0, 0, 0})
            nudPlotIndex2.Maximum = num
            Dim nudPlotIndex3 As Global.System.Windows.Forms.NumericUpDown = Me.nudPlotIndex
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudPlotIndex3.Minimum = num
            Me.nudPlotIndex.Name = "nudPlotIndex"
            Dim nudPlotIndex4 As Global.System.Windows.Forms.Control = Me.nudPlotIndex
            size = New Global.System.Drawing.Size(40, 20)
            nudPlotIndex4.Size = size
            Me.nudPlotIndex.TabIndex = 12
            Me.nudPlotIndex.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudPlotIndex5 As Global.System.Windows.Forms.NumericUpDown = Me.nudPlotIndex
            num = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
            nudPlotIndex5.Value = num
            Dim lblPlotIndex As Global.System.Windows.Forms.Control = Me.lblPlotIndex
            point = New Global.System.Drawing.Point(32, 24)
            lblPlotIndex.Location = point
            Me.lblPlotIndex.Name = "lblPlotIndex"
            Dim lblPlotIndex2 As Global.System.Windows.Forms.Control = Me.lblPlotIndex
            size = New Global.System.Drawing.Size(100, 16)
            lblPlotIndex2.Size = size
            Me.lblPlotIndex.TabIndex = 11
            Me.lblPlotIndex.Text = "Plot Index"
            Dim label43 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(32, 80)
            label43.Location = point
            Me.Label12.Name = "Label12"
            Dim label44 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(120, 16)
            label44.Size = size
            Me.Label12.TabIndex = 10
            Me.Label12.Text = "Plot XP Percentage"
            Dim nudPlotXPPercentage As Global.System.Windows.Forms.Control = Me.nudPlotXPPercentage
            point = New Global.System.Drawing.Point(32, 96)
            nudPlotXPPercentage.Location = point
            Me.nudPlotXPPercentage.Name = "nudPlotXPPercentage"
            Dim nudPlotXPPercentage2 As Global.System.Windows.Forms.Control = Me.nudPlotXPPercentage
            size = New Global.System.Drawing.Size(40, 20)
            nudPlotXPPercentage2.Size = size
            Me.nudPlotXPPercentage.TabIndex = 12
            Me.nudPlotXPPercentage.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudPlotXPPercentage3 As Global.System.Windows.Forms.NumericUpDown = Me.nudPlotXPPercentage
            num = New Decimal(New Integer() {100, 0, 0, 0})
            nudPlotXPPercentage3.Value = num
            Dim label45 As Global.System.Windows.Forms.Control = Me.Label36
            point = New Global.System.Drawing.Point(176, 24)
            label45.Location = point
            Me.Label36.Name = "Label36"
            Dim label46 As Global.System.Windows.Forms.Control = Me.Label36
            size = New Global.System.Drawing.Size(128, 16)
            label46.Size = size
            Me.Label36.TabIndex = 15
            Me.Label36.Text = "Quest"
            Dim nudQuestEntry As Global.System.Windows.Forms.Control = Me.nudQuestEntry
            point = New Global.System.Drawing.Point(176, 96)
            nudQuestEntry.Location = point
            Dim nudQuestEntry2 As Global.System.Windows.Forms.NumericUpDown = Me.nudQuestEntry
            num = New Decimal(New Integer() {-1, 0, 0, 0})
            nudQuestEntry2.Maximum = num
            Me.nudQuestEntry.Name = "nudQuestEntry"
            Dim nudQuestEntry3 As Global.System.Windows.Forms.Control = Me.nudQuestEntry
            size = New Global.System.Drawing.Size(88, 20)
            nudQuestEntry3.Size = size
            Me.nudQuestEntry.TabIndex = 12
            Me.nudQuestEntry.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tabpagComment.Controls.Add(Me.tbComments)
            Dim tabpagComment As Global.System.Windows.Forms.Control = Me.tabpagComment
            point = New Global.System.Drawing.Point(4, 40)
            tabpagComment.Location = point
            Me.tabpagComment.Name = "tabpagComment"
            Dim tabpagComment2 As Global.System.Windows.Forms.Control = Me.tabpagComment
            size = New Global.System.Drawing.Size(480, 172)
            tabpagComment2.Size = size
            Me.tabpagComment.TabIndex = 2
            Me.tabpagComment.Text = "Comments"
            Me.tbComments.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbComments As Global.System.Windows.Forms.Control = Me.tbComments
            point = New Global.System.Drawing.Point(8, 16)
            tbComments.Location = point
            Me.tbComments.Multiline = True
            Me.tbComments.Name = "tbComments"
            Me.tbComments.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Dim tbComments2 As Global.System.Windows.Forms.Control = Me.tbComments
            size = New Global.System.Drawing.Size(456, 136)
            tbComments2.Size = size
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
            Dim tabpagThisFile As Global.System.Windows.Forms.Control = Me.tabpagThisFile1
            point = New Global.System.Drawing.Point(4, 40)
            tabpagThisFile.Location = point
            Me.tabpagThisFile1.Name = "tabpagThisFile1"
            Dim tabpagThisFile2 As Global.System.Windows.Forms.Control = Me.tabpagThisFile1
            size = New Global.System.Drawing.Size(480, 172)
            tabpagThisFile2.Size = size
            Me.tabpagThisFile1.TabIndex = 3
            Me.tabpagThisFile1.Text = "This File (1)"
            Dim chkbAnimatedCut As Global.System.Windows.Forms.Control = Me.chkbAnimatedCut
            point = New Global.System.Drawing.Point(16, 136)
            chkbAnimatedCut.Location = point
            Me.chkbAnimatedCut.Name = "chkbAnimatedCut"
            Dim chkbAnimatedCut2 As Global.System.Windows.Forms.Control = Me.chkbAnimatedCut
            size = New Global.System.Drawing.Size(128, 24)
            chkbAnimatedCut2.Size = size
            Me.chkbAnimatedCut.TabIndex = 16
            Me.chkbAnimatedCut.Text = "Animated Cutscene"
            Me.tbCameraModel.Enabled = False
            Dim tbCameraModel As Global.System.Windows.Forms.Control = Me.tbCameraModel
            point = New Global.System.Drawing.Point(160, 143)
            tbCameraModel.Location = point
            Me.tbCameraModel.MaxLength = 16
            Me.tbCameraModel.Name = "tbCameraModel"
            Dim tbCameraModel2 As Global.System.Windows.Forms.Control = Me.tbCameraModel
            size = New Global.System.Drawing.Size(120, 20)
            tbCameraModel2.Size = size
            Me.tbCameraModel.TabIndex = 14
            Me.tbCameraModel.Text = ""
            Me.ToolTip1.SetToolTip(Me.tbCameraModel, "This is the model name of the camera to use in Animated Cutscenes")
            Dim label47 As Global.System.Windows.Forms.Control = Me.Label31
            point = New Global.System.Drawing.Point(160, 128)
            label47.Location = point
            Me.Label31.Name = "Label31"
            Dim label48 As Global.System.Windows.Forms.Control = Me.Label31
            size = New Global.System.Drawing.Size(80, 16)
            label48.Size = size
            Me.Label31.TabIndex = 15
            Me.Label31.Text = "Camera Model"
            Me.cmbxConversationType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxConversationType.Items.AddRange(New Object() {"Human", "Computer", "Type 2", "Type 3", "Type 4"})
            Dim cmbxConversationType As Global.System.Windows.Forms.Control = Me.cmbxConversationType
            point = New Global.System.Drawing.Point(8, 64)
            cmbxConversationType.Location = point
            Me.cmbxConversationType.Name = "cmbxConversationType"
            Dim cmbxConversationType2 As Global.System.Windows.Forms.Control = Me.cmbxConversationType
            size = New Global.System.Drawing.Size(88, 21)
            cmbxConversationType2.Size = size
            Me.cmbxConversationType.TabIndex = 12
            Dim chkbSkippable As Global.System.Windows.Forms.Control = Me.chkbSkippable
            point = New Global.System.Drawing.Point(320, 8)
            chkbSkippable.Location = point
            Me.chkbSkippable.Name = "chkbSkippable"
            Dim chkbSkippable2 As Global.System.Windows.Forms.Control = Me.chkbSkippable
            size = New Global.System.Drawing.Size(80, 24)
            chkbSkippable2.Size = size
            Me.chkbSkippable.TabIndex = 11
            Me.chkbSkippable.Text = "Skippable"
            Me.tbVO_ID.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbVO_ID As Global.System.Windows.Forms.Control = Me.tbVO_ID
            point = New Global.System.Drawing.Point(8, 24)
            tbVO_ID.Location = point
            Me.tbVO_ID.Name = "tbVO_ID"
            Dim tbVO_ID2 As Global.System.Windows.Forms.Control = Me.tbVO_ID
            size = New Global.System.Drawing.Size(128, 20)
            tbVO_ID2.Size = size
            Me.tbVO_ID.TabIndex = 8
            Me.tbVO_ID.Text = ""
            Dim label49 As Global.System.Windows.Forms.Control = Me.Label20
            point = New Global.System.Drawing.Point(8, 8)
            label49.Location = point
            Me.Label20.Name = "Label20"
            Dim label50 As Global.System.Windows.Forms.Control = Me.Label20
            size = New Global.System.Drawing.Size(112, 16)
            label50.Size = size
            Me.Label20.TabIndex = 9
            Me.Label20.Text = "Voice Over Family ID"
            Dim label51 As Global.System.Windows.Forms.Control = Me.Label21
            point = New Global.System.Drawing.Point(8, 48)
            label51.Location = point
            Me.Label21.Name = "Label21"
            Dim label52 As Global.System.Windows.Forms.Control = Me.Label21
            size = New Global.System.Drawing.Size(104, 16)
            label52.Size = size
            Me.Label21.TabIndex = 9
            Me.Label21.Text = "Conversation Type"
            Me.tbEndConversation.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbEndConversation As Global.System.Windows.Forms.Control = Me.tbEndConversation
            point = New Global.System.Drawing.Point(160, 24)
            tbEndConversation.Location = point
            Me.tbEndConversation.MaxLength = 16
            Me.tbEndConversation.Name = "tbEndConversation"
            Dim tbEndConversation2 As Global.System.Windows.Forms.Control = Me.tbEndConversation
            size = New Global.System.Drawing.Size(128, 20)
            tbEndConversation2.Size = size
            Me.tbEndConversation.TabIndex = 8
            Me.tbEndConversation.Text = ""
            Dim label53 As Global.System.Windows.Forms.Control = Me.Label22
            point = New Global.System.Drawing.Point(160, 8)
            label53.Location = point
            Me.Label22.Name = "Label22"
            Dim label54 As Global.System.Windows.Forms.Control = Me.Label22
            size = New Global.System.Drawing.Size(128, 16)
            label54.Size = size
            Me.Label22.TabIndex = 9
            Me.Label22.Text = "End Conv Normal Script"
            Dim label55 As Global.System.Windows.Forms.Control = Me.Label23
            point = New Global.System.Drawing.Point(160, 48)
            label55.Location = point
            Me.Label23.Name = "Label23"
            Dim label56 As Global.System.Windows.Forms.Control = Me.Label23
            size = New Global.System.Drawing.Size(128, 16)
            label56.Size = size
            Me.Label23.TabIndex = 9
            Me.Label23.Text = "End Conv Abort Script"
            Me.tbEndConverAbort.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbEndConverAbort As Global.System.Windows.Forms.Control = Me.tbEndConverAbort
            point = New Global.System.Drawing.Point(160, 64)
            tbEndConverAbort.Location = point
            Me.tbEndConverAbort.MaxLength = 16
            Me.tbEndConverAbort.Name = "tbEndConverAbort"
            Dim tbEndConverAbort2 As Global.System.Windows.Forms.Control = Me.tbEndConverAbort
            size = New Global.System.Drawing.Size(128, 20)
            tbEndConverAbort2.Size = size
            Me.tbEndConverAbort.TabIndex = 8
            Me.tbEndConverAbort.Text = ""
            Dim label57 As Global.System.Windows.Forms.Control = Me.Label24
            point = New Global.System.Drawing.Point(8, 88)
            label57.Location = point
            Me.Label24.Name = "Label24"
            Dim label58 As Global.System.Windows.Forms.Control = Me.Label24
            size = New Global.System.Drawing.Size(104, 16)
            label58.Size = size
            Me.Label24.TabIndex = 9
            Me.Label24.Text = "Computer Type"
            Me.tbAmbientTrack.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
            Dim tbAmbientTrack As Global.System.Windows.Forms.Control = Me.tbAmbientTrack
            point = New Global.System.Drawing.Point(160, 104)
            tbAmbientTrack.Location = point
            Me.tbAmbientTrack.MaxLength = 16
            Me.tbAmbientTrack.Name = "tbAmbientTrack"
            Dim tbAmbientTrack2 As Global.System.Windows.Forms.Control = Me.tbAmbientTrack
            size = New Global.System.Drawing.Size(128, 20)
            tbAmbientTrack2.Size = size
            Me.tbAmbientTrack.TabIndex = 8
            Me.tbAmbientTrack.Text = ""
            Dim label59 As Global.System.Windows.Forms.Control = Me.Label25
            point = New Global.System.Drawing.Point(160, 88)
            label59.Location = point
            Me.Label25.Name = "Label25"
            Dim label60 As Global.System.Windows.Forms.Control = Me.Label25
            size = New Global.System.Drawing.Size(128, 16)
            label60.Size = size
            Me.Label25.TabIndex = 9
            Me.Label25.Text = "Ambient Track"
            Dim chkbUnequipItems As Global.System.Windows.Forms.Control = Me.chkbUnequipItems
            point = New Global.System.Drawing.Point(320, 32)
            chkbUnequipItems.Location = point
            Me.chkbUnequipItems.Name = "chkbUnequipItems"
            Dim chkbUnequipItems2 As Global.System.Windows.Forms.Control = Me.chkbUnequipItems
            size = New Global.System.Drawing.Size(96, 24)
            chkbUnequipItems2.Size = size
            Me.chkbUnequipItems.TabIndex = 11
            Me.chkbUnequipItems.Text = "Unequip Items"
            Dim chkbUnequipHItem As Global.System.Windows.Forms.Control = Me.chkbUnequipHItem
            point = New Global.System.Drawing.Point(320, 56)
            chkbUnequipHItem.Location = point
            Me.chkbUnequipHItem.Name = "chkbUnequipHItem"
            Me.chkbUnequipHItem.TabIndex = 11
            Me.chkbUnequipHItem.Text = "Unequip HItem"
            Dim label61 As Global.System.Windows.Forms.Control = Me.Label26
            point = New Global.System.Drawing.Point(307, 88)
            label61.Location = point
            Me.Label26.Name = "Label26"
            Dim label62 As Global.System.Windows.Forms.Control = Me.Label26
            size = New Global.System.Drawing.Size(64, 16)
            label62.Size = size
            Me.Label26.TabIndex = 9
            Me.Label26.Text = "Delay Entry"
            Dim nudDelayEntry As Global.System.Windows.Forms.Control = Me.nudDelayEntry
            point = New Global.System.Drawing.Point(304, 104)
            nudDelayEntry.Location = point
            Dim nudDelayEntry2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDelayEntry
            num = New Decimal(New Integer() {100000, 0, 0, 0})
            nudDelayEntry2.Maximum = num
            Me.nudDelayEntry.Name = "nudDelayEntry"
            Dim nudDelayEntry3 As Global.System.Windows.Forms.Control = Me.nudDelayEntry
            size = New Global.System.Drawing.Size(64, 20)
            nudDelayEntry3.Size = size
            Me.nudDelayEntry.TabIndex = 10
            Me.nudDelayEntry.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudDelayReply As Global.System.Windows.Forms.Control = Me.nudDelayReply
            point = New Global.System.Drawing.Point(400, 104)
            nudDelayReply.Location = point
            Dim nudDelayReply2 As Global.System.Windows.Forms.NumericUpDown = Me.nudDelayReply
            num = New Decimal(New Integer() {100000, 0, 0, 0})
            nudDelayReply2.Maximum = num
            Me.nudDelayReply.Name = "nudDelayReply"
            Dim nudDelayReply3 As Global.System.Windows.Forms.Control = Me.nudDelayReply
            size = New Global.System.Drawing.Size(64, 20)
            nudDelayReply3.Size = size
            Me.nudDelayReply.TabIndex = 10
            Me.nudDelayReply.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label63 As Global.System.Windows.Forms.Control = Me.Label27
            point = New Global.System.Drawing.Point(400, 88)
            label63.Location = point
            Me.Label27.Name = "Label27"
            Dim label64 As Global.System.Windows.Forms.Control = Me.Label27
            size = New Global.System.Drawing.Size(72, 16)
            label64.Size = size
            Me.Label27.TabIndex = 9
            Me.Label27.Text = "Delay Reply"
            Me.cmbxComputerType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxComputerType.Enabled = False
            Me.cmbxComputerType.Items.AddRange(New Object() {"Modern", "Ancient"})
            Dim cmbxComputerType As Global.System.Windows.Forms.Control = Me.cmbxComputerType
            point = New Global.System.Drawing.Point(8, 104)
            cmbxComputerType.Location = point
            Me.cmbxComputerType.Name = "cmbxComputerType"
            Dim cmbxComputerType2 As Global.System.Windows.Forms.Control = Me.cmbxComputerType
            size = New Global.System.Drawing.Size(88, 21)
            cmbxComputerType2.Size = size
            Me.cmbxComputerType.TabIndex = 12
            Me.tabpagThisFile2.Controls.Add(Me.dgStuntList)
            Me.tabpagThisFile2.Controls.Add(Me.Label30)
            Dim tabpagThisFile3 As Global.System.Windows.Forms.Control = Me.tabpagThisFile2
            point = New Global.System.Drawing.Point(4, 40)
            tabpagThisFile3.Location = point
            Me.tabpagThisFile2.Name = "tabpagThisFile2"
            Dim tabpagThisFile4 As Global.System.Windows.Forms.Control = Me.tabpagThisFile2
            size = New Global.System.Drawing.Size(480, 172)
            tabpagThisFile4.Size = size
            Me.tabpagThisFile2.TabIndex = 8
            Me.tabpagThisFile2.Text = "This File (2)"
            Me.dgStuntList.DataMember = ""
            Me.dgStuntList.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Dim dgStuntList As Global.System.Windows.Forms.Control = Me.dgStuntList
            point = New Global.System.Drawing.Point(56, 24)
            dgStuntList.Location = point
            Me.dgStuntList.Name = "dgStuntList"
            Dim dgStuntList2 As Global.System.Windows.Forms.Control = Me.dgStuntList
            size = New Global.System.Drawing.Size(368, 112)
            dgStuntList2.Size = size
            Me.dgStuntList.TabIndex = 0
            Me.Label30.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim label65 As Global.System.Windows.Forms.Control = Me.Label30
            point = New Global.System.Drawing.Point(56, 24)
            label65.Location = point
            Me.Label30.Name = "Label30"
            Dim label66 As Global.System.Windows.Forms.Control = Me.Label30
            size = New Global.System.Drawing.Size(136, 16)
            label66.Size = size
            Me.Label30.TabIndex = 3
            Me.Label30.Text = "(Stunt List is View-only)"
            Dim tabpagThisFile5 As Global.System.Windows.Forms.Control = Me.tabpagThisFile3
            point = New Global.System.Drawing.Point(4, 40)
            tabpagThisFile5.Location = point
            Me.tabpagThisFile3.Name = "tabpagThisFile3"
            Dim tabpagThisFile6 As Global.System.Windows.Forms.Control = Me.tabpagThisFile3
            size = New Global.System.Drawing.Size(480, 172)
            tabpagThisFile6.Size = size
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
            Dim tabpagDebug As Global.System.Windows.Forms.Control = Me.tabpagDebug
            point = New Global.System.Drawing.Point(4, 40)
            tabpagDebug.Location = point
            Me.tabpagDebug.Name = "tabpagDebug"
            Dim tabpagDebug2 As Global.System.Windows.Forms.Control = Me.tabpagDebug
            size = New Global.System.Drawing.Size(480, 172)
            tabpagDebug2.Size = size
            Me.tabpagDebug.TabIndex = 7
            Me.tabpagDebug.Text = "Debug information/Options"
            Dim trkbTVIndent As Global.System.Windows.Forms.Control = Me.trkbTVIndent
            point = New Global.System.Drawing.Point(280, 40)
            trkbTVIndent.Location = point
            Me.trkbTVIndent.Maximum = 30
            Me.trkbTVIndent.Minimum = 15
            Me.trkbTVIndent.Name = "trkbTVIndent"
            Dim trkbTVIndent2 As Global.System.Windows.Forms.Control = Me.trkbTVIndent
            size = New Global.System.Drawing.Size(120, 42)
            trkbTVIndent2.Size = size
            Me.trkbTVIndent.TabIndex = 9
            Me.trkbTVIndent.Value = 16
            Dim label67 As Global.System.Windows.Forms.Control = Me.Label17
            point = New Global.System.Drawing.Point(56, 32)
            label67.Location = point
            Me.Label17.Name = "Label17"
            Dim label68 As Global.System.Windows.Forms.Control = Me.Label17
            size = New Global.System.Drawing.Size(100, 16)
            label68.Size = size
            Me.Label17.TabIndex = 8
            Me.Label17.Text = "Link ID"
            Dim tbLinkID As Global.System.Windows.Forms.Control = Me.tbLinkID
            point = New Global.System.Drawing.Point(168, 30)
            tbLinkID.Location = point
            Me.tbLinkID.Name = "tbLinkID"
            Dim tbLinkID2 As Global.System.Windows.Forms.Control = Me.tbLinkID
            size = New Global.System.Drawing.Size(56, 20)
            tbLinkID2.Size = size
            Me.tbLinkID.TabIndex = 7
            Me.tbLinkID.Text = ""
            Dim tbLinkedCnt As Global.System.Windows.Forms.Control = Me.tbLinkedCnt
            point = New Global.System.Drawing.Point(168, 64)
            tbLinkedCnt.Location = point
            Me.tbLinkedCnt.Name = "tbLinkedCnt"
            Dim tbLinkedCnt2 As Global.System.Windows.Forms.Control = Me.tbLinkedCnt
            size = New Global.System.Drawing.Size(56, 20)
            tbLinkedCnt2.Size = size
            Me.tbLinkedCnt.TabIndex = 7
            Me.tbLinkedCnt.Text = ""
            Dim tbSharedCnt As Global.System.Windows.Forms.Control = Me.tbSharedCnt
            point = New Global.System.Drawing.Point(168, 96)
            tbSharedCnt.Location = point
            Me.tbSharedCnt.Name = "tbSharedCnt"
            Dim tbSharedCnt2 As Global.System.Windows.Forms.Control = Me.tbSharedCnt
            size = New Global.System.Drawing.Size(56, 20)
            tbSharedCnt2.Size = size
            Me.tbSharedCnt.TabIndex = 7
            Me.tbSharedCnt.Text = ""
            Dim label69 As Global.System.Windows.Forms.Control = Me.Label18
            point = New Global.System.Drawing.Point(56, 66)
            label69.Location = point
            Me.Label18.Name = "Label18"
            Dim label70 As Global.System.Windows.Forms.Control = Me.Label18
            size = New Global.System.Drawing.Size(80, 16)
            label70.Size = size
            Me.Label18.TabIndex = 8
            Me.Label18.Text = "Linked to this"
            Dim label71 As Global.System.Windows.Forms.Control = Me.Label19
            point = New Global.System.Drawing.Point(56, 98)
            label71.Location = point
            Me.Label19.Name = "Label19"
            Dim label72 As Global.System.Windows.Forms.Control = Me.Label19
            size = New Global.System.Drawing.Size(100, 16)
            label72.Size = size
            Me.Label19.TabIndex = 8
            Me.Label19.Text = "Nodes sharing link"
            Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
            point = New Global.System.Drawing.Point(280, 144)
            btnDebug.Location = point
            Me.btnDebug.Name = "btnDebug"
            Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
            size = New Global.System.Drawing.Size(120, 23)
            btnDebug2.Size = size
            Me.btnDebug.TabIndex = 6
            Me.btnDebug.Text = "Show Debug Listing"
            Dim label73 As Global.System.Windows.Forms.Control = Me.Label32
            point = New Global.System.Drawing.Point(288, 24)
            label73.Location = point
            Me.Label32.Name = "Label32"
            Dim label74 As Global.System.Windows.Forms.Control = Me.Label32
            size = New Global.System.Drawing.Size(112, 16)
            label74.Size = size
            Me.Label32.TabIndex = 8
            Me.Label32.Text = "Treeview indent level"
            Dim label75 As Global.System.Windows.Forms.Control = Me.Label33
            point = New Global.System.Drawing.Point(288, 88)
            label75.Location = point
            Me.Label33.Name = "Label33"
            Dim label76 As Global.System.Windows.Forms.Control = Me.Label33
            size = New Global.System.Drawing.Size(112, 16)
            label76.Size = size
            Me.Label33.TabIndex = 8
            Me.Label33.Text = "Treeview item height"
            Dim trkbTVItemHeight As Global.System.Windows.Forms.Control = Me.trkbTVItemHeight
            point = New Global.System.Drawing.Point(280, 104)
            trkbTVItemHeight.Location = point
            Me.trkbTVItemHeight.Maximum = 21
            Me.trkbTVItemHeight.Minimum = 7
            Me.trkbTVItemHeight.Name = "trkbTVItemHeight"
            Dim trkbTVItemHeight2 As Global.System.Windows.Forms.Control = Me.trkbTVItemHeight
            size = New Global.System.Drawing.Size(120, 42)
            trkbTVItemHeight2.Size = size
            Me.trkbTVItemHeight.TabIndex = 9
            Me.trkbTVItemHeight.Value = 9
            Dim tbLinkDesc As Global.System.Windows.Forms.Control = Me.tbLinkDesc
            point = New Global.System.Drawing.Point(168, 128)
            tbLinkDesc.Location = point
            Me.tbLinkDesc.Name = "tbLinkDesc"
            Dim tbLinkDesc2 As Global.System.Windows.Forms.Control = Me.tbLinkDesc
            size = New Global.System.Drawing.Size(56, 20)
            tbLinkDesc2.Size = size
            Me.tbLinkDesc.TabIndex = 7
            Me.tbLinkDesc.Text = ""
            Dim label77 As Global.System.Windows.Forms.Control = Me.Label34
            point = New Global.System.Drawing.Point(56, 128)
            label77.Location = point
            Me.Label34.Name = "Label34"
            Dim label78 As Global.System.Windows.Forms.Control = Me.Label34
            size = New Global.System.Drawing.Size(100, 16)
            label78.Size = size
            Me.Label34.TabIndex = 8
            Me.Label34.Text = "Link Desc"
            Dim btnShowLists As Global.System.Windows.Forms.Control = Me.btnShowLists
            point = New Global.System.Drawing.Point(448, 144)
            btnShowLists.Location = point
            Me.btnShowLists.Name = "btnShowLists"
            Dim btnShowLists2 As Global.System.Windows.Forms.Control = Me.btnShowLists
            size = New Global.System.Drawing.Size(24, 23)
            btnShowLists2.Size = size
            Me.btnShowLists.TabIndex = 6
            Me.btnShowLists.Text = "D"
            Me.btnShowLists.Visible = False
            Me.btnCollapseAll.Image = CType(resourceManager.GetObject("btnCollapseAll.Image"), Global.System.Drawing.Image)
            Dim btnCollapseAll As Global.System.Windows.Forms.Control = Me.btnCollapseAll
            point = New Global.System.Drawing.Point(5, 240)
            btnCollapseAll.Location = point
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Dim btnCollapseAll2 As Global.System.Windows.Forms.Control = Me.btnCollapseAll
            size = New Global.System.Drawing.Size(24, 23)
            btnCollapseAll2.Size = size
            Me.btnCollapseAll.TabIndex = 2
            Me.btnCollapseAll.Text = "C"
            Me.ToolTip1.SetToolTip(Me.btnCollapseAll, "Collapse all nodes in the treeview")
            Me.btnExpandAll.Image = CType(resourceManager.GetObject("btnExpandAll.Image"), Global.System.Drawing.Image)
            Dim btnExpandAll As Global.System.Windows.Forms.Control = Me.btnExpandAll
            point = New Global.System.Drawing.Point(5, 184)
            btnExpandAll.Location = point
            Me.btnExpandAll.Name = "btnExpandAll"
            Dim btnExpandAll2 As Global.System.Windows.Forms.Control = Me.btnExpandAll
            size = New Global.System.Drawing.Size(24, 23)
            btnExpandAll2.Size = size
            Me.btnExpandAll.TabIndex = 1
            Me.btnExpandAll.Text = "E"
            Me.ToolTip1.SetToolTip(Me.btnExpandAll, "Expand all nodes in the treeview")
            Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
            point = New Global.System.Drawing.Point(152, 312)
            btnSave.Location = point
            Me.btnSave.Name = "btnSave"
            Dim btnSave2 As Global.System.Windows.Forms.Control = Me.btnSave
            size = New Global.System.Drawing.Size(42, 23)
            btnSave2.Size = size
            Me.btnSave.TabIndex = 6
            Me.btnSave.Text = "Save"
            Me.btnSave.Visible = False
            Dim btnTest As Global.System.Windows.Forms.Control = Me.btnTest
            point = New Global.System.Drawing.Point(8, 312)
            btnTest.Location = point
            Me.btnTest.Name = "btnTest"
            Dim btnTest2 As Global.System.Windows.Forms.Control = Me.btnTest
            size = New Global.System.Drawing.Size(40, 23)
            btnTest2.Size = size
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
            Dim tbSpeaker As Global.System.Windows.Forms.Control = Me.tbSpeaker
            point = New Global.System.Drawing.Point(32, 360)
            tbSpeaker.Location = point
            Me.tbSpeaker.Name = "tbSpeaker"
            Dim tbSpeaker2 As Global.System.Windows.Forms.Control = Me.tbSpeaker
            size = New Global.System.Drawing.Size(128, 20)
            tbSpeaker2.Size = size
            Me.tbSpeaker.TabIndex = 9
            Me.tbSpeaker.Text = ""
            Dim btnOpen As Global.System.Windows.Forms.Control = Me.btnOpen
            point = New Global.System.Drawing.Point(88, 312)
            btnOpen.Location = point
            Me.btnOpen.Name = "btnOpen"
            Dim btnOpen2 As Global.System.Windows.Forms.Control = Me.btnOpen
            size = New Global.System.Drawing.Size(48, 23)
            btnOpen2.Size = size
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
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(792, 517)
            Me.ClientSize = size
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
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x0400025E RID: 606
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
