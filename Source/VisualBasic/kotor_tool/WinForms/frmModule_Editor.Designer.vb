Namespace kotor_tool
	' Token: 0x0200005C RID: 92
	Public Partial Class frmModule_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Panel1 As Global.System.Windows.Forms.Panel
        Friend WithEvents pbox As Global.System.Windows.Forms.PictureBox
        Friend WithEvents nudXmul As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudYmul As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudXoff As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudYoff As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents btnTest As Global.System.Windows.Forms.Button
        Friend WithEvents btnClean As Global.System.Windows.Forms.Button
        Friend WithEvents tvModule As Global.System.Windows.Forms.TreeView
        Friend WithEvents tvPalette As Global.System.Windows.Forms.TreeView
        Friend WithEvents tvModuleContextMenuItem As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents cmiTvModuleItemProperties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents btnPalDoor As Global.System.Windows.Forms.Button
        Friend WithEvents btnPalCreature As Global.System.Windows.Forms.Button
        Friend WithEvents btnPalEncounter As Global.System.Windows.Forms.Button
        Friend WithEvents btnPalItem As Global.System.Windows.Forms.Button
        Friend WithEvents btnPalMerchant As Global.System.Windows.Forms.Button
        Friend WithEvents btnPalPlaceable As Global.System.Windows.Forms.Button
        Friend WithEvents btnPalWaypoint As Global.System.Windows.Forms.Button
        Friend WithEvents btnPalSound As Global.System.Windows.Forms.Button
        Friend WithEvents btnPalTrigger As Global.System.Windows.Forms.Button
        Friend WithEvents chkbShowResRefs As Global.System.Windows.Forms.CheckBox
        Friend WithEvents ToolTip1 As Global.System.Windows.Forms.ToolTip
        Friend WithEvents btnLogFactors As Global.System.Windows.Forms.Button
        Friend WithEvents ImageList1 As Global.System.Windows.Forms.ImageList
        Friend WithEvents pnlPalette As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlModElements As Global.System.Windows.Forms.Panel
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSave As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem3 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miClose As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowHideModuleElements As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowHidePalette As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowModulePaths As Global.System.Windows.Forms.MenuItem
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOptions As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvUserPalette As Global.System.Windows.Forms.TreeView
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents chkbShowNames As Global.System.Windows.Forms.CheckBox
        Friend WithEvents miRemoveFromOverride As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCopyToOverride As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCleanOverride As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem9 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiTvModuleItemEdit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiTvModuleItemDelete As Global.System.Windows.Forms.MenuItem
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents tbHelp As Global.System.Windows.Forms.TextBox
        Friend WithEvents tabpagUserPalette As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabctrlPalette As Global.System.Windows.Forms.TabControl
        Friend WithEvents MenuItem7 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenProject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tabpagModuleElements As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagScripts As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabctrlModule As Global.System.Windows.Forms.TabControl
        Friend WithEvents mnuView As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miExploreModuleFolder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miBuildModFile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents chkbUseFactors As Global.System.Windows.Forms.CheckBox
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miModuleProperties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowGitDump As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowAreDump As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowIfoDump As Global.System.Windows.Forms.MenuItem
        Friend WithEvents sbar As Global.System.Windows.Forms.StatusBar
        Friend WithEvents sbarpnlLocX As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbarpnlLocY As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbarpnlDesc As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbarpnlAddlInfo As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbarpnlStatus As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents ToolBarModElementsFilter As Global.System.Windows.Forms.ToolBar
        Friend WithEvents tbarbtnCreature As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbarbtnDoor As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbarbtnEncounter As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbarbtnMerchant As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbarbtnPlaceable As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbarbtnSound As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbarbtnTrigger As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents tbarbtnWaypoint As Global.System.Windows.Forms.ToolBarButton
        Friend WithEvents ilModElementsFilter As Global.System.Windows.Forms.ImageList
        Friend WithEvents miUseLargeMap As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miUseSmallMap As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem11 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowItemLabels As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmPbox As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents cmiModuleProperties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiCreateCameraHere As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiSetModuleStartPoint As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem13 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents chkbShowTags As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnTweakUp As RepeatButton
        Friend WithEvents btnTweakLeft As RepeatButton
        Friend WithEvents btnTweakRight As RepeatButton
        Friend WithEvents btnTweakDown As RepeatButton
        Friend WithEvents cmMapSurfaceItems As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents cmiProperties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiDelete As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiEditGFFFile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents cmiAddNewSpawnPoint As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowModuleEntryPoint As Global.System.Windows.Forms.MenuItem
        Friend WithEvents lbScripts As Global.System.Windows.Forms.ListBox
        Friend WithEvents tabpagDialogs As Global.System.Windows.Forms.TabPage
        Friend WithEvents lbDialogs As Global.System.Windows.Forms.ListBox
        Friend WithEvents tbMouseX As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMouseY As Global.System.Windows.Forms.TextBox
        Friend WithEvents chkbFine As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnAssignPt1 As Global.System.Windows.Forms.Button
        Friend WithEvents tb3dsMaxPt1X As Global.System.Windows.Forms.TextBox
        Friend WithEvents tb3dsMaxPt1Y As Global.System.Windows.Forms.TextBox
        Friend WithEvents tb3dsMaxPt2Y As Global.System.Windows.Forms.TextBox
        Friend WithEvents tb3dsMaxPt2X As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnAssignPt2 As Global.System.Windows.Forms.Button
        Friend WithEvents btnCalcCalibrationVals As Global.System.Windows.Forms.Button
        Friend WithEvents btnCalToolsToggle As Global.System.Windows.Forms.Button
        Friend WithEvents miFont As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miUseAltSmallMap As Global.System.Windows.Forms.MenuItem


		' Token: 0x060007A3 RID: 1955 RVA: 0x0025A3F0 File Offset: 0x002593F0
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000892 RID: 2194 RVA: 0x0025CA50 File Offset: 0x0025BA50
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmModule_Editor))
            Me.Panel1 = New Global.System.Windows.Forms.Panel()
            Me.pbox = New Global.System.Windows.Forms.PictureBox()
            Me.nudXmul = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudYmul = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudXoff = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudYoff = New Global.System.Windows.Forms.NumericUpDown()
            Me.btnTest = New Global.System.Windows.Forms.Button()
            Me.btnClean = New Global.System.Windows.Forms.Button()
            Me.tvModule = New Global.System.Windows.Forms.TreeView()
            Me.ImageList1 = New Global.System.Windows.Forms.ImageList()
            Me.tvPalette = New Global.System.Windows.Forms.TreeView()
            Me.tvModuleContextMenuItem = New Global.System.Windows.Forms.ContextMenu()
            Me.cmiTvModuleItemDelete = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTvModuleItemEdit = New Global.System.Windows.Forms.MenuItem()
            Me.cmiTvModuleItemProperties = New Global.System.Windows.Forms.MenuItem()
            Me.btnPalDoor = New Global.System.Windows.Forms.Button()
            Me.btnPalEncounter = New Global.System.Windows.Forms.Button()
            Me.btnPalItem = New Global.System.Windows.Forms.Button()
            Me.btnPalCreature = New Global.System.Windows.Forms.Button()
            Me.btnPalPlaceable = New Global.System.Windows.Forms.Button()
            Me.btnPalMerchant = New Global.System.Windows.Forms.Button()
            Me.btnPalWaypoint = New Global.System.Windows.Forms.Button()
            Me.btnPalSound = New Global.System.Windows.Forms.Button()
            Me.btnPalTrigger = New Global.System.Windows.Forms.Button()
            Me.chkbShowResRefs = New Global.System.Windows.Forms.CheckBox()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip()
            Me.btnLogFactors = New Global.System.Windows.Forms.Button()
            Me.pnlPalette = New Global.System.Windows.Forms.Panel()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.tbHelp = New Global.System.Windows.Forms.TextBox()
            Me.tabctrlPalette = New Global.System.Windows.Forms.TabControl()
            Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
            Me.chkbShowNames = New Global.System.Windows.Forms.CheckBox()
            Me.tabpagUserPalette = New Global.System.Windows.Forms.TabPage()
            Me.tvUserPalette = New Global.System.Windows.Forms.TreeView()
            Me.btnCalToolsToggle = New Global.System.Windows.Forms.Button()
            Me.pnlModElements = New Global.System.Windows.Forms.Panel()
            Me.ToolBarModElementsFilter = New Global.System.Windows.Forms.ToolBar()
            Me.tbarbtnCreature = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbarbtnDoor = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbarbtnEncounter = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbarbtnMerchant = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbarbtnPlaceable = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbarbtnSound = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbarbtnTrigger = New Global.System.Windows.Forms.ToolBarButton()
            Me.tbarbtnWaypoint = New Global.System.Windows.Forms.ToolBarButton()
            Me.ilModElementsFilter = New Global.System.Windows.Forms.ImageList()
            Me.tabctrlModule = New Global.System.Windows.Forms.TabControl()
            Me.tabpagModuleElements = New Global.System.Windows.Forms.TabPage()
            Me.tabpagScripts = New Global.System.Windows.Forms.TabPage()
            Me.lbScripts = New Global.System.Windows.Forms.ListBox()
            Me.tabpagDialogs = New Global.System.Windows.Forms.TabPage()
            Me.lbDialogs = New Global.System.Windows.Forms.ListBox()
            Me.chkbUseFactors = New Global.System.Windows.Forms.CheckBox()
            Me.chkbShowTags = New Global.System.Windows.Forms.CheckBox()
            Me.btnTweakUp = New Global.kotor_tool.RepeatButton()
            Me.btnTweakLeft = New Global.kotor_tool.RepeatButton()
            Me.btnTweakRight = New Global.kotor_tool.RepeatButton()
            Me.btnTweakDown = New Global.kotor_tool.RepeatButton()
            Me.chkbFine = New Global.System.Windows.Forms.CheckBox()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenProject = New Global.System.Windows.Forms.MenuItem()
            Me.miSave = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New Global.System.Windows.Forms.MenuItem()
            Me.miBuildModFile = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New Global.System.Windows.Forms.MenuItem()
            Me.miExploreModuleFolder = New Global.System.Windows.Forms.MenuItem()
            Me.miCopyToOverride = New Global.System.Windows.Forms.MenuItem()
            Me.miRemoveFromOverride = New Global.System.Windows.Forms.MenuItem()
            Me.miCleanOverride = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem9 = New Global.System.Windows.Forms.MenuItem()
            Me.miClose = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.miModuleProperties = New Global.System.Windows.Forms.MenuItem()
            Me.mnuView = New Global.System.Windows.Forms.MenuItem()
            Me.miShowHideModuleElements = New Global.System.Windows.Forms.MenuItem()
            Me.miShowHidePalette = New Global.System.Windows.Forms.MenuItem()
            Me.miShowItemLabels = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New Global.System.Windows.Forms.MenuItem()
            Me.miUseSmallMap = New Global.System.Windows.Forms.MenuItem()
            Me.miUseLargeMap = New Global.System.Windows.Forms.MenuItem()
            Me.miUseAltSmallMap = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem11 = New Global.System.Windows.Forms.MenuItem()
            Me.miShowModuleEntryPoint = New Global.System.Windows.Forms.MenuItem()
            Me.miShowModulePaths = New Global.System.Windows.Forms.MenuItem()
            Me.miFont = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New Global.System.Windows.Forms.MenuItem()
            Me.miShowGitDump = New Global.System.Windows.Forms.MenuItem()
            Me.miShowAreDump = New Global.System.Windows.Forms.MenuItem()
            Me.miShowIfoDump = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New Global.System.Windows.Forms.MenuItem()
            Me.miOptions = New Global.System.Windows.Forms.MenuItem()
            Me.btnDebug = New Global.System.Windows.Forms.Button()
            Me.sbar = New Global.System.Windows.Forms.StatusBar()
            Me.sbarpnlLocX = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbarpnlLocY = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbarpnlDesc = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbarpnlAddlInfo = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbarpnlStatus = New Global.System.Windows.Forms.StatusBarPanel()
            Me.cmPbox = New Global.System.Windows.Forms.ContextMenu()
            Me.cmiCreateCameraHere = New Global.System.Windows.Forms.MenuItem()
            Me.cmiSetModuleStartPoint = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem13 = New Global.System.Windows.Forms.MenuItem()
            Me.cmiModuleProperties = New Global.System.Windows.Forms.MenuItem()
            Me.cmMapSurfaceItems = New Global.System.Windows.Forms.ContextMenu()
            Me.cmiDelete = New Global.System.Windows.Forms.MenuItem()
            Me.cmiEditGFFFile = New Global.System.Windows.Forms.MenuItem()
            Me.cmiProperties = New Global.System.Windows.Forms.MenuItem()
            Me.cmiAddNewSpawnPoint = New Global.System.Windows.Forms.MenuItem()
            Me.tbMouseX = New Global.System.Windows.Forms.TextBox()
            Me.tbMouseY = New Global.System.Windows.Forms.TextBox()
            Me.btnAssignPt1 = New Global.System.Windows.Forms.Button()
            Me.btnAssignPt2 = New Global.System.Windows.Forms.Button()
            Me.tb3dsMaxPt1X = New Global.System.Windows.Forms.TextBox()
            Me.tb3dsMaxPt1Y = New Global.System.Windows.Forms.TextBox()
            Me.tb3dsMaxPt2Y = New Global.System.Windows.Forms.TextBox()
            Me.tb3dsMaxPt2X = New Global.System.Windows.Forms.TextBox()
            Me.btnCalcCalibrationVals = New Global.System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            CType(Me.nudXmul, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudYmul, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudXoff, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudYoff, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlPalette.SuspendLayout()
            Me.tabctrlPalette.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.tabpagUserPalette.SuspendLayout()
            Me.pnlModElements.SuspendLayout()
            Me.tabctrlModule.SuspendLayout()
            Me.tabpagModuleElements.SuspendLayout()
            Me.tabpagScripts.SuspendLayout()
            Me.tabpagDialogs.SuspendLayout()
            CType(Me.sbarpnlLocX, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbarpnlLocY, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbarpnlDesc, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbarpnlAddlInfo, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbarpnlStatus, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.Panel1.AllowDrop = True
            Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.AutoScroll = True
            Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.pbox)
            Me.Panel1.Enabled = False
            Me.Panel1.Location = New Global.System.Drawing.Point(200, 8)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New Global.System.Drawing.Size(424, 424)
            Me.Panel1.TabIndex = 5
            Me.pbox.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbox.Location = New Global.System.Drawing.Point(0, 0)
            Me.pbox.Name = "pbox"
            Me.pbox.Size = New Global.System.Drawing.Size(96, 80)
            Me.pbox.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbox.TabIndex = 0
            Me.pbox.TabStop = False
            Me.pbox.Visible = False
            Me.nudXmul.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.nudXmul.DecimalPlaces = 2
            Me.nudXmul.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudXmul.Location = New Global.System.Drawing.Point(8, 354)
            Me.nudXmul.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
            Me.nudXmul.Name = "nudXmul"
            Me.nudXmul.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudXmul.TabIndex = 0
            Me.nudXmul.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudXmul.Value = New Decimal(New Integer() {125, 0, 0, 65536})
            Me.nudXmul.Visible = False
            Me.nudYmul.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.nudYmul.DecimalPlaces = 2
            Me.nudYmul.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudYmul.Location = New Global.System.Drawing.Point(85, 354)
            Me.nudYmul.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
            Me.nudYmul.Name = "nudYmul"
            Me.nudYmul.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudYmul.TabIndex = 1
            Me.nudYmul.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudYmul.Value = New Decimal(New Integer() {125, 0, 0, 65536})
            Me.nudYmul.Visible = False
            Me.nudXoff.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.nudXoff.Location = New Global.System.Drawing.Point(8, 376)
            Me.nudXoff.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
            Me.nudXoff.Minimum = New Decimal(New Integer() {20000, 0, 0, Integer.MinValue})
            Me.nudXoff.Name = "nudXoff"
            Me.nudXoff.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudXoff.TabIndex = 2
            Me.nudXoff.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudXoff.Value = New Decimal(New Integer() {838, 0, 0, 0})
            Me.nudXoff.Visible = False
            Me.nudYoff.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.nudYoff.Location = New Global.System.Drawing.Point(85, 376)
            Me.nudYoff.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
            Me.nudYoff.Minimum = New Decimal(New Integer() {20000, 0, 0, Integer.MinValue})
            Me.nudYoff.Name = "nudYoff"
            Me.nudYoff.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudYoff.TabIndex = 3
            Me.nudYoff.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudYoff.Value = New Decimal(New Integer() {846, 0, 0, 0})
            Me.nudYoff.Visible = False
            Me.btnTest.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTest.Location = New Global.System.Drawing.Point(664, 440)
            Me.btnTest.Name = "btnTest"
            Me.btnTest.TabIndex = 4
            Me.btnTest.Text = "Test"
            Me.btnTest.Visible = False
            Me.btnClean.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnClean.Location = New Global.System.Drawing.Point(760, 440)
            Me.btnClean.Name = "btnClean"
            Me.btnClean.TabIndex = 4
            Me.btnClean.Text = "Clean"
            Me.btnClean.Visible = False
            Me.tvModule.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.tvModule.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.tvModule.ImageList = Me.ImageList1
            Me.tvModule.Indent = 19
            Me.tvModule.Location = New Global.System.Drawing.Point(0, 0)
            Me.tvModule.Name = "tvModule"
            Me.tvModule.Size = New Global.System.Drawing.Size(184, 216)
            Me.tvModule.TabIndex = 8
            Me.ImageList1.ImageSize = New Global.System.Drawing.Size(16, 16)
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
            Me.tvPalette.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tvPalette.ImageIndex = -1
            Me.tvPalette.Location = New Global.System.Drawing.Point(8, 40)
            Me.tvPalette.Name = "tvPalette"
            Me.tvPalette.SelectedImageIndex = -1
            Me.tvPalette.Size = New Global.System.Drawing.Size(208, 192)
            Me.tvPalette.TabIndex = 9
            Me.tvModuleContextMenuItem.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiTvModuleItemDelete, Me.cmiTvModuleItemEdit, Me.cmiTvModuleItemProperties})
            Me.cmiTvModuleItemDelete.Index = 0
            Me.cmiTvModuleItemDelete.Text = "Delete..."
            Me.cmiTvModuleItemEdit.Index = 1
            Me.cmiTvModuleItemEdit.Text = "Edit GFF File..."
            Me.cmiTvModuleItemProperties.Index = 2
            Me.cmiTvModuleItemProperties.Text = "Properties in Module..."
            Me.btnPalDoor.Image = CType(resources.GetObject("Me.btnPalDoor.Image"), Global.System.Drawing.Image)
            Me.btnPalDoor.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalDoor.Location = New Global.System.Drawing.Point(34, 8)
            Me.btnPalDoor.Name = "btnPalDoor"
            Me.btnPalDoor.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalDoor.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalDoor, "Doors")
            Me.btnPalEncounter.Image = CType(resources.GetObject("Me.btnPalEncounter.Image"), Global.System.Drawing.Image)
            Me.btnPalEncounter.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalEncounter.Location = New Global.System.Drawing.Point(61, 8)
            Me.btnPalEncounter.Name = "btnPalEncounter"
            Me.btnPalEncounter.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalEncounter.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalEncounter, "Encounters")
            Me.btnPalItem.Enabled = False
            Me.btnPalItem.Image = CType(resources.GetObject("Me.btnPalItem.Image"), Global.System.Drawing.Image)
            Me.btnPalItem.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalItem.Location = New Global.System.Drawing.Point(128, 16)
            Me.btnPalItem.Name = "btnPalItem"
            Me.btnPalItem.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalItem.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalItem, "Items")
            Me.btnPalItem.Visible = False
            Me.btnPalCreature.BackColor = Global.System.Drawing.SystemColors.Control
            Me.btnPalCreature.Image = CType(resources.GetObject("Me.btnPalCreature.Image"), Global.System.Drawing.Image)
            Me.btnPalCreature.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalCreature.Location = New Global.System.Drawing.Point(7, 8)
            Me.btnPalCreature.Name = "btnPalCreature"
            Me.btnPalCreature.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalCreature.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalCreature, "Creatures")
            Me.btnPalPlaceable.Image = CType(resources.GetObject("Me.btnPalPlaceable.Image"), Global.System.Drawing.Image)
            Me.btnPalPlaceable.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalPlaceable.Location = New Global.System.Drawing.Point(115, 8)
            Me.btnPalPlaceable.Name = "btnPalPlaceable"
            Me.btnPalPlaceable.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalPlaceable.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalPlaceable, "Placeables")
            Me.btnPalMerchant.Image = CType(resources.GetObject("Me.btnPalMerchant.Image"), Global.System.Drawing.Image)
            Me.btnPalMerchant.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalMerchant.Location = New Global.System.Drawing.Point(88, 8)
            Me.btnPalMerchant.Name = "btnPalMerchant"
            Me.btnPalMerchant.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalMerchant.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalMerchant, "Merchants")
            Me.btnPalWaypoint.Image = CType(resources.GetObject("Me.btnPalWaypoint.Image"), Global.System.Drawing.Image)
            Me.btnPalWaypoint.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalWaypoint.Location = New Global.System.Drawing.Point(195, 8)
            Me.btnPalWaypoint.Name = "btnPalWaypoint"
            Me.btnPalWaypoint.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalWaypoint.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalWaypoint, "Waypoints")
            Me.btnPalSound.Image = CType(resources.GetObject("Me.btnPalSound.Image"), Global.System.Drawing.Image)
            Me.btnPalSound.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalSound.Location = New Global.System.Drawing.Point(141, 8)
            Me.btnPalSound.Name = "btnPalSound"
            Me.btnPalSound.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalSound.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalSound, "Sounds")
            Me.btnPalTrigger.Image = CType(resources.GetObject("Me.btnPalTrigger.Image"), Global.System.Drawing.Image)
            Me.btnPalTrigger.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Me.btnPalTrigger.Location = New Global.System.Drawing.Point(168, 8)
            Me.btnPalTrigger.Name = "btnPalTrigger"
            Me.btnPalTrigger.Size = New Global.System.Drawing.Size(22, 22)
            Me.btnPalTrigger.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalTrigger, "Triggers")
            Me.chkbShowResRefs.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.chkbShowResRefs.Location = New Global.System.Drawing.Point(117, 235)
            Me.chkbShowResRefs.Name = "chkbShowResRefs"
            Me.chkbShowResRefs.Size = New Global.System.Drawing.Size(98, 24)
            Me.chkbShowResRefs.TabIndex = 11
            Me.chkbShowResRefs.Text = "Show ResRefs"
            Me.btnLogFactors.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnLogFactors.Location = New Global.System.Drawing.Point(154, 376)
            Me.btnLogFactors.Name = "btnLogFactors"
            Me.btnLogFactors.Size = New Global.System.Drawing.Size(32, 23)
            Me.btnLogFactors.TabIndex = 4
            Me.btnLogFactors.Text = "Log factors"
            Me.btnLogFactors.Visible = False
            Me.pnlPalette.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.pnlPalette.Controls.Add(Me.Label5)
            Me.pnlPalette.Controls.Add(Me.tbHelp)
            Me.pnlPalette.Controls.Add(Me.tabctrlPalette)
            Me.pnlPalette.Location = New Global.System.Drawing.Point(632, 8)
            Me.pnlPalette.Name = "pnlPalette"
            Me.pnlPalette.Size = New Global.System.Drawing.Size(232, 424)
            Me.pnlPalette.TabIndex = 13
            Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label5.Location = New Global.System.Drawing.Point(16, 312)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(56, 16)
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "Help Info"
            Me.tbHelp.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tbHelp.Location = New Global.System.Drawing.Point(8, 328)
            Me.tbHelp.Multiline = True
            Me.tbHelp.Name = "tbHelp"
            Me.tbHelp.Size = New Global.System.Drawing.Size(208, 88)
            Me.tbHelp.TabIndex = 13
            Me.tbHelp.Text = ""
            Me.tabctrlPalette.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tabctrlPalette.Controls.Add(Me.TabPage1)
            Me.tabctrlPalette.Controls.Add(Me.tabpagUserPalette)
            Me.tabctrlPalette.Enabled = False
            Me.tabctrlPalette.Location = New Global.System.Drawing.Point(0, 8)
            Me.tabctrlPalette.Name = "tabctrlPalette"
            Me.tabctrlPalette.SelectedIndex = 0
            Me.tabctrlPalette.Size = New Global.System.Drawing.Size(228, 288)
            Me.tabctrlPalette.TabIndex = 12
            Me.TabPage1.Controls.Add(Me.btnPalWaypoint)
            Me.TabPage1.Controls.Add(Me.btnPalSound)
            Me.TabPage1.Controls.Add(Me.btnPalTrigger)
            Me.TabPage1.Controls.Add(Me.btnPalDoor)
            Me.TabPage1.Controls.Add(Me.btnPalEncounter)
            Me.TabPage1.Controls.Add(Me.btnPalCreature)
            Me.TabPage1.Controls.Add(Me.btnPalPlaceable)
            Me.TabPage1.Controls.Add(Me.btnPalMerchant)
            Me.TabPage1.Controls.Add(Me.tvPalette)
            Me.TabPage1.Controls.Add(Me.chkbShowResRefs)
            Me.TabPage1.Controls.Add(Me.chkbShowNames)
            Me.TabPage1.Controls.Add(Me.btnPalItem)
            Me.TabPage1.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New Global.System.Drawing.Size(220, 262)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Standard"
            Me.chkbShowNames.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.chkbShowNames.Checked = True
            Me.chkbShowNames.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbShowNames.Location = New Global.System.Drawing.Point(11, 235)
            Me.chkbShowNames.Name = "chkbShowNames"
            Me.chkbShowNames.Size = New Global.System.Drawing.Size(96, 24)
            Me.chkbShowNames.TabIndex = 11
            Me.chkbShowNames.Text = "Show Names"
            Me.tabpagUserPalette.Controls.Add(Me.tvUserPalette)
            Me.tabpagUserPalette.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagUserPalette.Name = "tabpagUserPalette"
            Me.tabpagUserPalette.Size = New Global.System.Drawing.Size(220, 262)
            Me.tabpagUserPalette.TabIndex = 1
            Me.tabpagUserPalette.Text = "User"
            Me.tvUserPalette.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tvUserPalette.ImageIndex = -1
            Me.tvUserPalette.Location = New Global.System.Drawing.Point(8, 16)
            Me.tvUserPalette.Name = "tvUserPalette"
            Me.tvUserPalette.Nodes.AddRange(New Global.System.Windows.Forms.TreeNode() {New Global.System.Windows.Forms.TreeNode("Creatures"), New Global.System.Windows.Forms.TreeNode("Doors"), New Global.System.Windows.Forms.TreeNode("Encounters"), New Global.System.Windows.Forms.TreeNode("Stores"), New Global.System.Windows.Forms.TreeNode("Placeables"), New Global.System.Windows.Forms.TreeNode("Sounds"), New Global.System.Windows.Forms.TreeNode("Triggers")})
            Me.tvUserPalette.SelectedImageIndex = -1
            Me.tvUserPalette.Size = New Global.System.Drawing.Size(200, 232)
            Me.tvUserPalette.TabIndex = 9
            Me.btnCalToolsToggle.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCalToolsToggle.BackColor = Global.System.Drawing.SystemColors.Control
            Me.btnCalToolsToggle.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnCalToolsToggle.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnCalToolsToggle.Location = New Global.System.Drawing.Point(616, 436)
            Me.btnCalToolsToggle.Name = "btnCalToolsToggle"
            Me.btnCalToolsToggle.Size = New Global.System.Drawing.Size(8, 8)
            Me.btnCalToolsToggle.TabIndex = 8
            Me.btnCalToolsToggle.TabStop = False
            Me.pnlModElements.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.pnlModElements.Controls.Add(Me.ToolBarModElementsFilter)
            Me.pnlModElements.Controls.Add(Me.tabctrlModule)
            Me.pnlModElements.Controls.Add(Me.nudXmul)
            Me.pnlModElements.Controls.Add(Me.nudYmul)
            Me.pnlModElements.Controls.Add(Me.nudXoff)
            Me.pnlModElements.Controls.Add(Me.nudYoff)
            Me.pnlModElements.Controls.Add(Me.chkbUseFactors)
            Me.pnlModElements.Controls.Add(Me.btnLogFactors)
            Me.pnlModElements.Controls.Add(Me.chkbShowTags)
            Me.pnlModElements.Controls.Add(Me.btnTweakUp)
            Me.pnlModElements.Controls.Add(Me.btnTweakLeft)
            Me.pnlModElements.Controls.Add(Me.btnTweakRight)
            Me.pnlModElements.Controls.Add(Me.btnTweakDown)
            Me.pnlModElements.Controls.Add(Me.chkbFine)
            Me.pnlModElements.Location = New Global.System.Drawing.Point(0, 8)
            Me.pnlModElements.Name = "pnlModElements"
            Me.pnlModElements.Size = New Global.System.Drawing.Size(192, 424)
            Me.pnlModElements.TabIndex = 15
            Me.ToolBarModElementsFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.ToolBarModElementsFilter.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.ToolBarModElementsFilter.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() {Me.tbarbtnCreature, Me.tbarbtnDoor, Me.tbarbtnEncounter, Me.tbarbtnMerchant, Me.tbarbtnPlaceable, Me.tbarbtnSound, Me.tbarbtnTrigger, Me.tbarbtnWaypoint})
            Me.ToolBarModElementsFilter.Divider = False
            Me.ToolBarModElementsFilter.Dock = Global.System.Windows.Forms.DockStyle.None
            Me.ToolBarModElementsFilter.DropDownArrows = True
            Me.ToolBarModElementsFilter.Enabled = False
            Me.ToolBarModElementsFilter.ImageList = Me.ilModElementsFilter
            Me.ToolBarModElementsFilter.Location = New Global.System.Drawing.Point(16, 304)
            Me.ToolBarModElementsFilter.Name = "ToolBarModElementsFilter"
            Me.ToolBarModElementsFilter.ShowToolTips = True
            Me.ToolBarModElementsFilter.Size = New Global.System.Drawing.Size(96, 49)
            Me.ToolBarModElementsFilter.TabIndex = 18
            Me.tbarbtnCreature.ImageIndex = 0
            Me.tbarbtnCreature.Style = Global.System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnCreature.ToolTipText = "Show Creatures"
            Me.tbarbtnDoor.ImageIndex = 1
            Me.tbarbtnDoor.Style = Global.System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnDoor.ToolTipText = "Show Doors"
            Me.tbarbtnEncounter.ImageIndex = 2
            Me.tbarbtnEncounter.Style = Global.System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnEncounter.ToolTipText = "Show Encounters"
            Me.tbarbtnMerchant.ImageIndex = 3
            Me.tbarbtnMerchant.Style = Global.System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnMerchant.ToolTipText = "Show Merchants"
            Me.tbarbtnPlaceable.ImageIndex = 4
            Me.tbarbtnPlaceable.Style = Global.System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnPlaceable.ToolTipText = "Show Placeables"
            Me.tbarbtnSound.ImageIndex = 5
            Me.tbarbtnSound.Style = Global.System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnSound.ToolTipText = "Show Sounds"
            Me.tbarbtnTrigger.ImageIndex = 6
            Me.tbarbtnTrigger.Style = Global.System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnTrigger.ToolTipText = "Show Triggers"
            Me.tbarbtnWaypoint.ImageIndex = 7
            Me.tbarbtnWaypoint.Style = Global.System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnWaypoint.ToolTipText = "Show Waypoints"
            Me.ilModElementsFilter.ImageSize = New Global.System.Drawing.Size(16, 16)
            Me.ilModElementsFilter.ImageStream = CType(resources.GetObject("Me.ilModElementsFilter.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
            Me.ilModElementsFilter.TransparentColor = Global.System.Drawing.Color.Transparent
            Me.tabctrlModule.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tabctrlModule.Controls.Add(Me.tabpagModuleElements)
            Me.tabctrlModule.Controls.Add(Me.tabpagScripts)
            Me.tabctrlModule.Controls.Add(Me.tabpagDialogs)
            Me.tabctrlModule.ItemSize = New Global.System.Drawing.Size(93, 20)
            Me.tabctrlModule.Location = New Global.System.Drawing.Point(0, 8)
            Me.tabctrlModule.Multiline = True
            Me.tabctrlModule.Name = "tabctrlModule"
            Me.tabctrlModule.Padding = New Global.System.Drawing.Point(8, 3)
            Me.tabctrlModule.SelectedIndex = 0
            Me.tabctrlModule.Size = New Global.System.Drawing.Size(192, 264)
            Me.tabctrlModule.SizeMode = Global.System.Windows.Forms.TabSizeMode.FillToRight
            Me.tabctrlModule.TabIndex = 13
            Me.tabpagModuleElements.Controls.Add(Me.tvModule)
            Me.tabpagModuleElements.Location = New Global.System.Drawing.Point(4, 44)
            Me.tabpagModuleElements.Name = "tabpagModuleElements"
            Me.tabpagModuleElements.Size = New Global.System.Drawing.Size(184, 216)
            Me.tabpagModuleElements.TabIndex = 0
            Me.tabpagModuleElements.Text = "Module Elements"
            Me.tabpagScripts.Controls.Add(Me.lbScripts)
            Me.tabpagScripts.Location = New Global.System.Drawing.Point(4, 44)
            Me.tabpagScripts.Name = "tabpagScripts"
            Me.tabpagScripts.Size = New Global.System.Drawing.Size(184, 216)
            Me.tabpagScripts.TabIndex = 1
            Me.tabpagScripts.Text = "Scripts"
            Me.lbScripts.AllowDrop = True
            Me.lbScripts.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.lbScripts.Location = New Global.System.Drawing.Point(0, 0)
            Me.lbScripts.Name = "lbScripts"
            Me.lbScripts.Size = New Global.System.Drawing.Size(184, 216)
            Me.lbScripts.Sorted = True
            Me.lbScripts.TabIndex = 0
            Me.tabpagDialogs.Controls.Add(Me.lbDialogs)
            Me.tabpagDialogs.Location = New Global.System.Drawing.Point(4, 44)
            Me.tabpagDialogs.Name = "tabpagDialogs"
            Me.tabpagDialogs.Size = New Global.System.Drawing.Size(184, 216)
            Me.tabpagDialogs.TabIndex = 2
            Me.tabpagDialogs.Text = "Dialogs"
            Me.lbDialogs.AllowDrop = True
            Me.lbDialogs.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.lbDialogs.Location = New Global.System.Drawing.Point(0, 0)
            Me.lbDialogs.Name = "lbDialogs"
            Me.lbDialogs.Size = New Global.System.Drawing.Size(184, 216)
            Me.lbDialogs.Sorted = True
            Me.lbDialogs.TabIndex = 1
            Me.chkbUseFactors.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.chkbUseFactors.Location = New Global.System.Drawing.Point(8, 400)
            Me.chkbUseFactors.Name = "chkbUseFactors"
            Me.chkbUseFactors.Size = New Global.System.Drawing.Size(112, 16)
            Me.chkbUseFactors.TabIndex = 17
            Me.chkbUseFactors.Text = "Use these factors"
            Me.chkbUseFactors.Visible = False
            Me.chkbShowTags.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.chkbShowTags.Enabled = False
            Me.chkbShowTags.Location = New Global.System.Drawing.Point(56, 280)
            Me.chkbShowTags.Name = "chkbShowTags"
            Me.chkbShowTags.Size = New Global.System.Drawing.Size(80, 16)
            Me.chkbShowTags.TabIndex = 17
            Me.chkbShowTags.Text = "Show Tags"
            Me.btnTweakUp.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTweakUp.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTweakUp.Interval = 100
            Me.btnTweakUp.Location = New Global.System.Drawing.Point(160, 296)
            Me.btnTweakUp.Name = "btnTweakUp"
            Me.btnTweakUp.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnTweakUp.TabIndex = 4
            Me.btnTweakUp.Text = "^"
            Me.btnTweakUp.TextAlign = Global.System.Drawing.ContentAlignment.TopLeft
            Me.btnTweakLeft.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTweakLeft.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTweakLeft.Interval = 100
            Me.btnTweakLeft.Location = New Global.System.Drawing.Point(144, 312)
            Me.btnTweakLeft.Name = "btnTweakLeft"
            Me.btnTweakLeft.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnTweakLeft.TabIndex = 4
            Me.btnTweakLeft.Text = "<"
            Me.btnTweakLeft.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTweakRight.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTweakRight.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTweakRight.Interval = 100
            Me.btnTweakRight.Location = New Global.System.Drawing.Point(176, 312)
            Me.btnTweakRight.Name = "btnTweakRight"
            Me.btnTweakRight.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnTweakRight.TabIndex = 4
            Me.btnTweakRight.Text = ">"
            Me.btnTweakRight.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTweakDown.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTweakDown.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTweakDown.Interval = 100
            Me.btnTweakDown.Location = New Global.System.Drawing.Point(160, 328)
            Me.btnTweakDown.Name = "btnTweakDown"
            Me.btnTweakDown.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnTweakDown.TabIndex = 4
            Me.btnTweakDown.Text = "v"
            Me.btnTweakDown.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbFine.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.chkbFine.Location = New Global.System.Drawing.Point(128, 400)
            Me.chkbFine.Name = "chkbFine"
            Me.chkbFine.Size = New Global.System.Drawing.Size(48, 16)
            Me.chkbFine.TabIndex = 17
            Me.chkbFine.Text = "Fine"
            Me.chkbFine.Visible = False
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.mnuView, Me.MenuItem4})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miOpenProject, Me.miSave, Me.MenuItem3, Me.miBuildModFile, Me.MenuItem7, Me.miExploreModuleFolder, Me.miCopyToOverride, Me.miRemoveFromOverride, Me.miCleanOverride, Me.MenuItem9, Me.miClose})
            Me.MenuItem1.Text = "&File"
            Me.miOpenProject.Index = 0
            Me.miOpenProject.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenProject.Text = "&Open Module Project..."
            Me.miSave.Enabled = False
            Me.miSave.Index = 1
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save changes"
            Me.MenuItem3.Index = 2
            Me.MenuItem3.Text = "-"
            Me.miBuildModFile.Enabled = False
            Me.miBuildModFile.Index = 3
            Me.miBuildModFile.Shortcut = Global.System.Windows.Forms.Shortcut.F5
            Me.miBuildModFile.Text = "&Build Mod file..."
            Me.MenuItem7.Index = 4
            Me.MenuItem7.Text = "-"
            Me.miExploreModuleFolder.Enabled = False
            Me.miExploreModuleFolder.Index = 5
            Me.miExploreModuleFolder.Text = "Explore &Module folder"
            Me.miCopyToOverride.Index = 6
            Me.miCopyToOverride.Text = "Copy Project to Override folder"
            Me.miCopyToOverride.Visible = False
            Me.miRemoveFromOverride.Index = 7
            Me.miRemoveFromOverride.Text = "Remove Project from Override folder"
            Me.miRemoveFromOverride.Visible = False
            Me.miCleanOverride.Index = 8
            Me.miCleanOverride.Text = "Clean Override folder"
            Me.miCleanOverride.Visible = False
            Me.MenuItem9.Index = 9
            Me.MenuItem9.Text = "-"
            Me.miClose.Index = 10
            Me.miClose.Text = "&Close"
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miModuleProperties})
            Me.MenuItem2.Text = "&Edit"
            Me.miModuleProperties.Enabled = False
            Me.miModuleProperties.Index = 0
            Me.miModuleProperties.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlM
            Me.miModuleProperties.Text = "Module &Properties..."
            Me.mnuView.Index = 2
            Me.mnuView.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miShowHideModuleElements, Me.miShowHidePalette, Me.miShowItemLabels, Me.MenuItem6, Me.miUseSmallMap, Me.miUseLargeMap, Me.miUseAltSmallMap, Me.MenuItem11, Me.miShowModuleEntryPoint, Me.miShowModulePaths, Me.miFont})
            Me.mnuView.Text = "&View"
            Me.miShowHideModuleElements.Checked = True
            Me.miShowHideModuleElements.Enabled = False
            Me.miShowHideModuleElements.Index = 0
            Me.miShowHideModuleElements.Shortcut = Global.System.Windows.Forms.Shortcut.F1
            Me.miShowHideModuleElements.Text = "&Module Elements"
            Me.miShowHidePalette.Checked = True
            Me.miShowHidePalette.Enabled = False
            Me.miShowHidePalette.Index = 1
            Me.miShowHidePalette.Shortcut = Global.System.Windows.Forms.Shortcut.F2
            Me.miShowHidePalette.Text = "&Palette"
            Me.miShowItemLabels.Enabled = False
            Me.miShowItemLabels.Index = 2
            Me.miShowItemLabels.Shortcut = Global.System.Windows.Forms.Shortcut.F4
            Me.miShowItemLabels.Text = "&Item Labels"
            Me.MenuItem6.Index = 3
            Me.MenuItem6.Text = "-"
            Me.miUseSmallMap.Enabled = False
            Me.miUseSmallMap.Index = 4
            Me.miUseSmallMap.Text = "Use &small map backgound"
            Me.miUseLargeMap.Enabled = False
            Me.miUseLargeMap.Index = 5
            Me.miUseLargeMap.Text = "Use &large map backgound"
            Me.miUseAltSmallMap.Enabled = False
            Me.miUseAltSmallMap.Index = 6
            Me.miUseAltSmallMap.Text = "Use alternate map bkgnd"
            Me.MenuItem11.Index = 7
            Me.MenuItem11.Text = "-"
            Me.miShowModuleEntryPoint.Enabled = False
            Me.miShowModuleEntryPoint.Index = 8
            Me.miShowModuleEntryPoint.Text = "Show Module Entry localPoint"
            Me.miShowModulePaths.Enabled = False
            Me.miShowModulePaths.Index = 9
            Me.miShowModulePaths.Text = "&Show Module Paths"
            Me.miFont.Index = 10
            Me.miFont.Text = "Label Font..."
            Me.MenuItem4.Index = 3
            Me.MenuItem4.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miShowGitDump, Me.miShowAreDump, Me.miShowIfoDump, Me.MenuItem5, Me.miOptions})
            Me.MenuItem4.Text = "&Tools"
            Me.miShowGitDump.Enabled = False
            Me.miShowGitDump.Index = 0
            Me.miShowGitDump.Text = "Show GIT dump"
            Me.miShowAreDump.Enabled = False
            Me.miShowAreDump.Index = 1
            Me.miShowAreDump.Text = "Show ARE dump"
            Me.miShowIfoDump.Enabled = False
            Me.miShowIfoDump.Index = 2
            Me.miShowIfoDump.Text = "Show IFO dump"
            Me.MenuItem5.Index = 3
            Me.MenuItem5.Text = "-"
            Me.miOptions.Enabled = False
            Me.miOptions.Index = 4
            Me.miOptions.Text = "&Options..."
            Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnDebug.Location = New Global.System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New Global.System.Drawing.Size(8, 8)
            Me.btnDebug.TabIndex = 16
            Me.btnDebug.TabStop = False
            Me.sbar.Location = New Global.System.Drawing.Point(0, 451)
            Me.sbar.Name = "sbar"
            Me.sbar.Panels.AddRange(New Global.System.Windows.Forms.StatusBarPanel() {Me.sbarpnlLocX, Me.sbarpnlLocY, Me.sbarpnlDesc, Me.sbarpnlAddlInfo, Me.sbarpnlStatus})
            Me.sbar.ShowPanels = True
            Me.sbar.Size = New Global.System.Drawing.Size(864, 22)
            Me.sbar.TabIndex = 18
            Me.sbar.Text = "StatusBar1"
            Me.sbarpnlLocX.Width = 70
            Me.sbarpnlLocY.Width = 70
            Me.sbarpnlDesc.Width = 120
            Me.sbarpnlAddlInfo.Width = 180
            Me.sbarpnlStatus.AutoSize = Global.System.Windows.Forms.StatusBarPanelAutoSize.Spring
            Me.sbarpnlStatus.Width = 408
            Me.cmPbox.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiCreateCameraHere, Me.cmiSetModuleStartPoint, Me.MenuItem13, Me.cmiModuleProperties})
            Me.cmiCreateCameraHere.Index = 0
            Me.cmiCreateCameraHere.Text = "Create Camera here"
            Me.cmiSetModuleStartPoint.Index = 1
            Me.cmiSetModuleStartPoint.Text = "Set as Module starting localPoint"
            Me.MenuItem13.Index = 2
            Me.MenuItem13.Text = "-"
            Me.cmiModuleProperties.Index = 3
            Me.cmiModuleProperties.Text = "Module Properties..."
            Me.cmMapSurfaceItems.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiDelete, Me.cmiEditGFFFile, Me.cmiProperties, Me.cmiAddNewSpawnPoint})
            Me.cmiDelete.Index = 0
            Me.cmiDelete.Text = "Delete from Module..."
            Me.cmiEditGFFFile.Index = 1
            Me.cmiEditGFFFile.Text = "Edit GFF File..."
            Me.cmiProperties.Index = 2
            Me.cmiProperties.Text = "Properties in Module..."
            Me.cmiAddNewSpawnPoint.Index = 3
            Me.cmiAddNewSpawnPoint.Text = "Add New SpawnPoint"
            Me.tbMouseX.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tbMouseX.Location = New Global.System.Drawing.Point(0, 432)
            Me.tbMouseX.Name = "tbMouseX"
            Me.tbMouseX.Size = New Global.System.Drawing.Size(64, 20)
            Me.tbMouseX.TabIndex = 0
            Me.tbMouseX.Text = ""
            Me.tbMouseX.Visible = False
            Me.tbMouseY.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tbMouseY.Location = New Global.System.Drawing.Point(88, 432)
            Me.tbMouseY.Name = "tbMouseY"
            Me.tbMouseY.Size = New Global.System.Drawing.Size(64, 20)
            Me.tbMouseY.TabIndex = 1
            Me.tbMouseY.Text = ""
            Me.tbMouseY.Visible = False
            Me.btnAssignPt1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnAssignPt1.Location = New Global.System.Drawing.Point(160, 435)
            Me.btnAssignPt1.Name = "btnAssignPt1"
            Me.btnAssignPt1.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnAssignPt1.TabIndex = 2
            Me.btnAssignPt1.Text = "1"
            Me.btnAssignPt1.Visible = False
            Me.btnAssignPt2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnAssignPt2.Location = New Global.System.Drawing.Point(184, 435)
            Me.btnAssignPt2.Name = "btnAssignPt2"
            Me.btnAssignPt2.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnAssignPt2.TabIndex = 3
            Me.btnAssignPt2.Text = "2"
            Me.btnAssignPt2.Visible = False
            Me.tb3dsMaxPt1X.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tb3dsMaxPt1X.Location = New Global.System.Drawing.Point(264, 432)
            Me.tb3dsMaxPt1X.Name = "tb3dsMaxPt1X"
            Me.tb3dsMaxPt1X.Size = New Global.System.Drawing.Size(64, 20)
            Me.tb3dsMaxPt1X.TabIndex = 4
            Me.tb3dsMaxPt1X.Text = "110.516"
            Me.tb3dsMaxPt1X.Visible = False
            Me.tb3dsMaxPt1Y.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tb3dsMaxPt1Y.Location = New Global.System.Drawing.Point(344, 432)
            Me.tb3dsMaxPt1Y.Name = "tb3dsMaxPt1Y"
            Me.tb3dsMaxPt1Y.Size = New Global.System.Drawing.Size(64, 20)
            Me.tb3dsMaxPt1Y.TabIndex = 5
            Me.tb3dsMaxPt1Y.Text = "133.604"
            Me.tb3dsMaxPt1Y.Visible = False
            Me.tb3dsMaxPt2Y.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tb3dsMaxPt2Y.Location = New Global.System.Drawing.Point(528, 432)
            Me.tb3dsMaxPt2Y.Name = "tb3dsMaxPt2Y"
            Me.tb3dsMaxPt2Y.Size = New Global.System.Drawing.Size(64, 20)
            Me.tb3dsMaxPt2Y.TabIndex = 7
            Me.tb3dsMaxPt2Y.Text = "78.001"
            Me.tb3dsMaxPt2Y.Visible = False
            Me.tb3dsMaxPt2X.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tb3dsMaxPt2X.Location = New Global.System.Drawing.Point(448, 432)
            Me.tb3dsMaxPt2X.Name = "tb3dsMaxPt2X"
            Me.tb3dsMaxPt2X.Size = New Global.System.Drawing.Size(64, 20)
            Me.tb3dsMaxPt2X.TabIndex = 6
            Me.tb3dsMaxPt2X.Text = "105.987"
            Me.tb3dsMaxPt2X.Visible = False
            Me.btnCalcCalibrationVals.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnCalcCalibrationVals.Enabled = False
            Me.btnCalcCalibrationVals.Location = New Global.System.Drawing.Point(208, 435)
            Me.btnCalcCalibrationVals.Name = "btnCalcCalibrationVals"
            Me.btnCalcCalibrationVals.Size = New Global.System.Drawing.Size(16, 16)
            Me.btnCalcCalibrationVals.TabIndex = 8
            Me.btnCalcCalibrationVals.Text = "C"
            Me.btnCalcCalibrationVals.Visible = False
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(864, 473)
            Me.Controls.Add(Me.btnAssignPt1)
            Me.Controls.Add(Me.tbMouseX)
            Me.Controls.Add(Me.sbar)
            Me.Controls.Add(Me.btnDebug)
            Me.Controls.Add(Me.pnlModElements)
            Me.Controls.Add(Me.pnlPalette)
            Me.Controls.Add(Me.btnTest)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.btnClean)
            Me.Controls.Add(Me.tbMouseY)
            Me.Controls.Add(Me.btnAssignPt2)
            Me.Controls.Add(Me.tb3dsMaxPt1X)
            Me.Controls.Add(Me.tb3dsMaxPt1Y)
            Me.Controls.Add(Me.tb3dsMaxPt2Y)
            Me.Controls.Add(Me.tb3dsMaxPt2X)
            Me.Controls.Add(Me.btnCalcCalibrationVals)
            Me.Controls.Add(Me.btnCalToolsToggle)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New Global.System.Drawing.Size(576, 480)
            Me.Name = "frmModule_Editor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Module Editor"
            Me.Panel1.ResumeLayout(False)
            CType(Me.nudXmul, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudYmul, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudXoff, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudYoff, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlPalette.ResumeLayout(False)
            Me.tabctrlPalette.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.tabpagUserPalette.ResumeLayout(False)
            Me.pnlModElements.ResumeLayout(False)
            Me.tabctrlModule.ResumeLayout(False)
            Me.tabpagModuleElements.ResumeLayout(False)
            Me.tabpagScripts.ResumeLayout(False)
            Me.tabpagDialogs.ResumeLayout(False)
            CType(Me.sbarpnlLocX, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbarpnlLocY, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbarpnlDesc, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbarpnlAddlInfo, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbarpnlStatus, Global.System.ComponentModel.ISupportInitialize).EndInit()

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.Panel1.DragEnter, AddressOf Me.Panel1_DragEnter
            AddHandler Me.Panel1.DragDrop, AddressOf Me.Panel1_DragDrop
            AddHandler Me.pbox.MouseLeave, AddressOf Me.pbox_MouseLeave
            AddHandler Me.pbox.MouseUp, AddressOf Me.pbox_MouseUp
            AddHandler Me.pbox.MouseMove, AddressOf Me.pbox_MouseMove
            AddHandler Me.pbox.MouseDown, AddressOf Me.pbox_MouseDown
            AddHandler Me.nudXmul.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
            AddHandler Me.nudYmul.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
            AddHandler Me.nudXoff.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
            AddHandler Me.nudYoff.ValueChanged, AddressOf Me.nudMulOff_ValueChanged
            AddHandler Me.btnTest.Click, AddressOf Me.btnTest_Click
            AddHandler Me.btnClean.Click, AddressOf Me.btnClean_Click
            AddHandler Me.tvModule.BeforeCollapse, AddressOf Me.tvModule_BeforeCollapse
            AddHandler Me.tvModule.BeforeExpand, AddressOf Me.tvModule_BeforeExpand
            AddHandler Me.tvModule.KeyUp, AddressOf Me.tvModule_KeyUp
            AddHandler Me.tvModule.MouseUp, AddressOf Me.tvModule_MouseUp
            AddHandler Me.tvModule.MouseDown, AddressOf Me.tvModule_MouseDown
            AddHandler Me.tvPalette.ItemDrag, AddressOf Me.tvPalette_ItemDrag
            AddHandler Me.cmiTvModuleItemProperties.Click, AddressOf Me.cmiTvModuleItemProperties_Click
            AddHandler Me.btnPalDoor.Click, AddressOf Me.btnPalDoor_Click
            AddHandler Me.btnPalCreature.Click, AddressOf Me.btnPalCreature_Click
            AddHandler Me.btnPalEncounter.Click, AddressOf Me.btnPalEncounter_Click
            AddHandler Me.btnPalItem.Click, AddressOf Me.btnPalItem_Click
            AddHandler Me.btnPalMerchant.Click, AddressOf Me.btnPalMerchant_Click
            AddHandler Me.btnPalPlaceable.Click, AddressOf Me.btnPalPlaceable_Click
            AddHandler Me.btnPalWaypoint.Click, AddressOf Me.btnPalWaypoint_Click
            AddHandler Me.btnPalSound.Click, AddressOf Me.btnPalSound_Click
            AddHandler Me.btnPalTrigger.Click, AddressOf Me.btnPalTrigger_Click
            AddHandler Me.chkbShowResRefs.CheckedChanged, AddressOf Me.chkbShowResRefs_CheckedChanged
            AddHandler Me.btnLogFactors.Click, AddressOf Me.btnLogFactors_Click
            AddHandler Me.miSave.Click, AddressOf Me.miSave_Click
            AddHandler Me.miClose.Click, AddressOf Me.miClose_Click
            AddHandler Me.miShowHideModuleElements.Click, AddressOf Me.miShowHideModuleElements_Click
            AddHandler Me.miShowHidePalette.Click, AddressOf Me.miShowHidePalette_Click
            AddHandler Me.miShowModulePaths.Click, AddressOf Me.miShowModulePaths_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
            AddHandler Me.miOptions.Click, AddressOf Me.miOptions_Click
            AddHandler Me.tvUserPalette.ItemDrag, AddressOf Me.tvUserPalette_ItemDrag
            AddHandler Me.chkbShowNames.CheckedChanged, AddressOf Me.chkbShowNames_CheckedChanged
            AddHandler Me.cmiTvModuleItemEdit.Click, AddressOf Me.cmiTvModuleItemEdit_Click
            AddHandler Me.cmiTvModuleItemDelete.Click, AddressOf Me.cmiTvModuleItemDelete_Click
            AddHandler Me.tabctrlPalette.SelectedIndexChanged, AddressOf Me.TabControl1_SelectedIndexChanged
            AddHandler Me.miOpenProject.Click, AddressOf Me.miOpenProject_Click
            AddHandler Me.miExploreModuleFolder.Click, AddressOf Me.miExploreModuleFolder_Click
            AddHandler Me.miBuildModFile.Click, AddressOf Me.miBuildModFile_Click
            AddHandler Me.miModuleProperties.Click, AddressOf Me.miModuleProperties_Click
            AddHandler Me.miShowGitDump.Click, AddressOf Me.miShowGffDump_Click
            AddHandler Me.miShowAreDump.Click, AddressOf Me.miShowGffDump_Click
            AddHandler Me.miShowIfoDump.Click, AddressOf Me.miShowGffDump_Click
            AddHandler Me.ToolBarModElementsFilter.ButtonClick, AddressOf Me.ToolBarModElementsFilter_ButtonClick
            AddHandler Me.miUseLargeMap.Click, AddressOf Me.miUseLargeMap_Click
            AddHandler Me.miUseSmallMap.Click, AddressOf Me.miUseSmallMap_Click
            AddHandler Me.miShowItemLabels.Click, AddressOf Me.miShowItemLabels_Click
            AddHandler Me.cmiModuleProperties.Click, AddressOf Me.cmiModuleProperties_Click
            AddHandler Me.cmiCreateCameraHere.Click, AddressOf Me.cmiCreateCameraHere_Click
            AddHandler Me.cmiSetModuleStartPoint.Click, AddressOf Me.cmiSetModuleStartPoint_Click
            AddHandler Me.btnTweakUp.Click, AddressOf Me.btnTweakUp_Click
            AddHandler Me.btnTweakLeft.Click, AddressOf Me.btnTweakLeft_Click
            AddHandler Me.btnTweakRight.Click, AddressOf Me.btnTweakRight_Click
            AddHandler Me.btnTweakDown.Click, AddressOf Me.btnTweakDown_Click
            AddHandler Me.cmiProperties.Click, AddressOf Me.cmiProperties_Click
            AddHandler Me.cmiDelete.Click, AddressOf Me.cmiDelete_Click
            AddHandler Me.cmiEditGFFFile.Click, AddressOf Me.cmiEdit_Click
            AddHandler Me.cmiAddNewSpawnPoint.Click, AddressOf Me.cmiAddNewSpawnPoint_Click
            AddHandler Me.miShowModuleEntryPoint.Click, AddressOf Me.miShowModuleEntryPoint_Click
            AddHandler Me.lbScripts.DoubleClick, AddressOf Me.lbScripts_DoubleClick
            AddHandler Me.lbDialogs.DoubleClick, AddressOf Me.lbDialogs_DoubleClick
            AddHandler Me.chkbFine.CheckedChanged, AddressOf Me.chkbFine_CheckedChanged
            AddHandler Me.btnAssignPt1.Click, AddressOf Me.btnAssignPt1_Click
            AddHandler Me.btnAssignPt2.Click, AddressOf Me.btnAssignPt2_Click
            AddHandler Me.btnCalcCalibrationVals.Click, AddressOf Me.btnCalcCalibrationVals_Click
            AddHandler Me.btnCalToolsToggle.MouseDown, AddressOf Me.btnCalToolsToggle_MouseDown
            AddHandler Me.miFont.Click, AddressOf Me.miFont_Click
            AddHandler Me.miUseAltSmallMap.Click, AddressOf Me.miUseAltSmallMap_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
