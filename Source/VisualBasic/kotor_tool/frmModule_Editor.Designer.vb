Namespace kotor_tool
	' Token: 0x0200005C RID: 92
	Public Partial Class frmModule_Editor
		Inherits Global.kotor_tool.frmParent

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
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmModule_Editor))
            Me.Panel1 = New Global.System.Windows.Forms.Panel()
            Me.pbox = New Global.System.Windows.Forms.PictureBox()
            Me.nudXmul = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudYmul = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudXoff = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudYoff = New Global.System.Windows.Forms.NumericUpDown()
            Me.btnTest = New Global.System.Windows.Forms.Button()
            Me.btnClean = New Global.System.Windows.Forms.Button()
            Me.tvModule = New Global.System.Windows.Forms.TreeView()
            Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
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
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
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
            Me.ilModElementsFilter = New Global.System.Windows.Forms.ImageList(Me.components)
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
            Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(200, 8)
            panel.Location = point
            Me.Panel1.Name = "Panel1"
            Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(424, 424)
            panel2.Size = size
            Me.Panel1.TabIndex = 5
            Me.pbox.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Dim pbox As Global.System.Windows.Forms.Control = Me.pbox
            point = New Global.System.Drawing.Point(0, 0)
            pbox.Location = point
            Me.pbox.Name = "pbox"
            Dim pbox2 As Global.System.Windows.Forms.Control = Me.pbox
            size = New Global.System.Drawing.Size(96, 80)
            pbox2.Size = size
            Me.pbox.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbox.TabIndex = 0
            Me.pbox.TabStop = False
            Me.pbox.Visible = False
            Me.nudXmul.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.nudXmul.DecimalPlaces = 2
            Dim nudXmul As Global.System.Windows.Forms.NumericUpDown = Me.nudXmul
            Dim num As Decimal = New Decimal(New Integer() {1, 0, 0, 131072})
            nudXmul.Increment = num
            Dim nudXmul2 As Global.System.Windows.Forms.Control = Me.nudXmul
            point = New Global.System.Drawing.Point(8, 354)
            nudXmul2.Location = point
            Dim nudXmul3 As Global.System.Windows.Forms.NumericUpDown = Me.nudXmul
            num = New Decimal(New Integer() {1, 0, 0, 262144})
            nudXmul3.Minimum = num
            Me.nudXmul.Name = "nudXmul"
            Dim nudXmul4 As Global.System.Windows.Forms.Control = Me.nudXmul
            size = New Global.System.Drawing.Size(64, 20)
            nudXmul4.Size = size
            Me.nudXmul.TabIndex = 0
            Me.nudXmul.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudXmul5 As Global.System.Windows.Forms.NumericUpDown = Me.nudXmul
            num = New Decimal(New Integer() {125, 0, 0, 65536})
            nudXmul5.Value = num
            Me.nudXmul.Visible = False
            Me.nudYmul.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.nudYmul.DecimalPlaces = 2
            Dim nudYmul As Global.System.Windows.Forms.NumericUpDown = Me.nudYmul
            num = New Decimal(New Integer() {1, 0, 0, 131072})
            nudYmul.Increment = num
            Dim nudYmul2 As Global.System.Windows.Forms.Control = Me.nudYmul
            point = New Global.System.Drawing.Point(85, 354)
            nudYmul2.Location = point
            Dim nudYmul3 As Global.System.Windows.Forms.NumericUpDown = Me.nudYmul
            num = New Decimal(New Integer() {1, 0, 0, 262144})
            nudYmul3.Minimum = num
            Me.nudYmul.Name = "nudYmul"
            Dim nudYmul4 As Global.System.Windows.Forms.Control = Me.nudYmul
            size = New Global.System.Drawing.Size(64, 20)
            nudYmul4.Size = size
            Me.nudYmul.TabIndex = 1
            Me.nudYmul.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudYmul5 As Global.System.Windows.Forms.NumericUpDown = Me.nudYmul
            num = New Decimal(New Integer() {125, 0, 0, 65536})
            nudYmul5.Value = num
            Me.nudYmul.Visible = False
            Me.nudXoff.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim nudXoff As Global.System.Windows.Forms.Control = Me.nudXoff
            point = New Global.System.Drawing.Point(8, 376)
            nudXoff.Location = point
            Dim nudXoff2 As Global.System.Windows.Forms.NumericUpDown = Me.nudXoff
            num = New Decimal(New Integer() {20000, 0, 0, 0})
            nudXoff2.Maximum = num
            Dim nudXoff3 As Global.System.Windows.Forms.NumericUpDown = Me.nudXoff
            num = New Decimal(New Integer() {20000, 0, 0, Integer.MinValue})
            nudXoff3.Minimum = num
            Me.nudXoff.Name = "nudXoff"
            Dim nudXoff4 As Global.System.Windows.Forms.Control = Me.nudXoff
            size = New Global.System.Drawing.Size(64, 20)
            nudXoff4.Size = size
            Me.nudXoff.TabIndex = 2
            Me.nudXoff.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudXoff5 As Global.System.Windows.Forms.NumericUpDown = Me.nudXoff
            num = New Decimal(New Integer() {838, 0, 0, 0})
            nudXoff5.Value = num
            Me.nudXoff.Visible = False
            Me.nudYoff.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim nudYoff As Global.System.Windows.Forms.Control = Me.nudYoff
            point = New Global.System.Drawing.Point(85, 376)
            nudYoff.Location = point
            Dim nudYoff2 As Global.System.Windows.Forms.NumericUpDown = Me.nudYoff
            num = New Decimal(New Integer() {20000, 0, 0, 0})
            nudYoff2.Maximum = num
            Dim nudYoff3 As Global.System.Windows.Forms.NumericUpDown = Me.nudYoff
            num = New Decimal(New Integer() {20000, 0, 0, Integer.MinValue})
            nudYoff3.Minimum = num
            Me.nudYoff.Name = "nudYoff"
            Dim nudYoff4 As Global.System.Windows.Forms.Control = Me.nudYoff
            size = New Global.System.Drawing.Size(64, 20)
            nudYoff4.Size = size
            Me.nudYoff.TabIndex = 3
            Me.nudYoff.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudYoff5 As Global.System.Windows.Forms.NumericUpDown = Me.nudYoff
            num = New Decimal(New Integer() {846, 0, 0, 0})
            nudYoff5.Value = num
            Me.nudYoff.Visible = False
            Me.btnTest.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim btnTest As Global.System.Windows.Forms.Control = Me.btnTest
            point = New Global.System.Drawing.Point(664, 440)
            btnTest.Location = point
            Me.btnTest.Name = "btnTest"
            Me.btnTest.TabIndex = 4
            Me.btnTest.Text = "Test"
            Me.btnTest.Visible = False
            Me.btnClean.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim btnClean As Global.System.Windows.Forms.Control = Me.btnClean
            point = New Global.System.Drawing.Point(760, 440)
            btnClean.Location = point
            Me.btnClean.Name = "btnClean"
            Me.btnClean.TabIndex = 4
            Me.btnClean.Text = "Clean"
            Me.btnClean.Visible = False
            Me.tvModule.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.tvModule.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.tvModule.ImageList = Me.ImageList1
            Me.tvModule.Indent = 19
            Dim tvModule As Global.System.Windows.Forms.Control = Me.tvModule
            point = New Global.System.Drawing.Point(0, 0)
            tvModule.Location = point
            Me.tvModule.Name = "tvModule"
            Dim tvModule2 As Global.System.Windows.Forms.Control = Me.tvModule
            size = New Global.System.Drawing.Size(184, 216)
            tvModule2.Size = size
            Me.tvModule.TabIndex = 8
            Dim imageList As Global.System.Windows.Forms.ImageList = Me.ImageList1
            size = New Global.System.Drawing.Size(16, 16)
            imageList.ImageSize = size
            Me.ImageList1.ImageStream = CType(resourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
            Me.tvPalette.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tvPalette.ImageIndex = -1
            Dim tvPalette As Global.System.Windows.Forms.Control = Me.tvPalette
            point = New Global.System.Drawing.Point(8, 40)
            tvPalette.Location = point
            Me.tvPalette.Name = "tvPalette"
            Me.tvPalette.SelectedImageIndex = -1
            Dim tvPalette2 As Global.System.Windows.Forms.Control = Me.tvPalette
            size = New Global.System.Drawing.Size(208, 192)
            tvPalette2.Size = size
            Me.tvPalette.TabIndex = 9
            Me.tvModuleContextMenuItem.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiTvModuleItemDelete, Me.cmiTvModuleItemEdit, Me.cmiTvModuleItemProperties})
            Me.cmiTvModuleItemDelete.Index = 0
            Me.cmiTvModuleItemDelete.Text = "Delete..."
            Me.cmiTvModuleItemEdit.Index = 1
            Me.cmiTvModuleItemEdit.Text = "Edit GFF File..."
            Me.cmiTvModuleItemProperties.Index = 2
            Me.cmiTvModuleItemProperties.Text = "Properties in Module..."
            Me.btnPalDoor.Image = CType(resourceManager.GetObject("btnPalDoor.Image"), Global.System.Drawing.Image)
            Me.btnPalDoor.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalDoor As Global.System.Windows.Forms.Control = Me.btnPalDoor
            point = New Global.System.Drawing.Point(34, 8)
            btnPalDoor.Location = point
            Me.btnPalDoor.Name = "btnPalDoor"
            Dim btnPalDoor2 As Global.System.Windows.Forms.Control = Me.btnPalDoor
            size = New Global.System.Drawing.Size(22, 22)
            btnPalDoor2.Size = size
            Me.btnPalDoor.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalDoor, "Doors")
            Me.btnPalEncounter.Image = CType(resourceManager.GetObject("btnPalEncounter.Image"), Global.System.Drawing.Image)
            Me.btnPalEncounter.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalEncounter As Global.System.Windows.Forms.Control = Me.btnPalEncounter
            point = New Global.System.Drawing.Point(61, 8)
            btnPalEncounter.Location = point
            Me.btnPalEncounter.Name = "btnPalEncounter"
            Dim btnPalEncounter2 As Global.System.Windows.Forms.Control = Me.btnPalEncounter
            size = New Global.System.Drawing.Size(22, 22)
            btnPalEncounter2.Size = size
            Me.btnPalEncounter.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalEncounter, "Encounters")
            Me.btnPalItem.Enabled = False
            Me.btnPalItem.Image = CType(resourceManager.GetObject("btnPalItem.Image"), Global.System.Drawing.Image)
            Me.btnPalItem.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalItem As Global.System.Windows.Forms.Control = Me.btnPalItem
            point = New Global.System.Drawing.Point(128, 16)
            btnPalItem.Location = point
            Me.btnPalItem.Name = "btnPalItem"
            Dim btnPalItem2 As Global.System.Windows.Forms.Control = Me.btnPalItem
            size = New Global.System.Drawing.Size(22, 22)
            btnPalItem2.Size = size
            Me.btnPalItem.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalItem, "Items")
            Me.btnPalItem.Visible = False
            Me.btnPalCreature.BackColor = Global.System.Drawing.SystemColors.Control
            Me.btnPalCreature.Image = CType(resourceManager.GetObject("btnPalCreature.Image"), Global.System.Drawing.Image)
            Me.btnPalCreature.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalCreature As Global.System.Windows.Forms.Control = Me.btnPalCreature
            point = New Global.System.Drawing.Point(7, 8)
            btnPalCreature.Location = point
            Me.btnPalCreature.Name = "btnPalCreature"
            Dim btnPalCreature2 As Global.System.Windows.Forms.Control = Me.btnPalCreature
            size = New Global.System.Drawing.Size(22, 22)
            btnPalCreature2.Size = size
            Me.btnPalCreature.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalCreature, "Creatures")
            Me.btnPalPlaceable.Image = CType(resourceManager.GetObject("btnPalPlaceable.Image"), Global.System.Drawing.Image)
            Me.btnPalPlaceable.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalPlaceable As Global.System.Windows.Forms.Control = Me.btnPalPlaceable
            point = New Global.System.Drawing.Point(115, 8)
            btnPalPlaceable.Location = point
            Me.btnPalPlaceable.Name = "btnPalPlaceable"
            Dim btnPalPlaceable2 As Global.System.Windows.Forms.Control = Me.btnPalPlaceable
            size = New Global.System.Drawing.Size(22, 22)
            btnPalPlaceable2.Size = size
            Me.btnPalPlaceable.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalPlaceable, "Placeables")
            Me.btnPalMerchant.Image = CType(resourceManager.GetObject("btnPalMerchant.Image"), Global.System.Drawing.Image)
            Me.btnPalMerchant.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalMerchant As Global.System.Windows.Forms.Control = Me.btnPalMerchant
            point = New Global.System.Drawing.Point(88, 8)
            btnPalMerchant.Location = point
            Me.btnPalMerchant.Name = "btnPalMerchant"
            Dim btnPalMerchant2 As Global.System.Windows.Forms.Control = Me.btnPalMerchant
            size = New Global.System.Drawing.Size(22, 22)
            btnPalMerchant2.Size = size
            Me.btnPalMerchant.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalMerchant, "Merchants")
            Me.btnPalWaypoint.Image = CType(resourceManager.GetObject("btnPalWaypoint.Image"), Global.System.Drawing.Image)
            Me.btnPalWaypoint.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalWaypoint As Global.System.Windows.Forms.Control = Me.btnPalWaypoint
            point = New Global.System.Drawing.Point(195, 8)
            btnPalWaypoint.Location = point
            Me.btnPalWaypoint.Name = "btnPalWaypoint"
            Dim btnPalWaypoint2 As Global.System.Windows.Forms.Control = Me.btnPalWaypoint
            size = New Global.System.Drawing.Size(22, 22)
            btnPalWaypoint2.Size = size
            Me.btnPalWaypoint.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalWaypoint, "Waypoints")
            Me.btnPalSound.Image = CType(resourceManager.GetObject("btnPalSound.Image"), Global.System.Drawing.Image)
            Me.btnPalSound.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalSound As Global.System.Windows.Forms.Control = Me.btnPalSound
            point = New Global.System.Drawing.Point(141, 8)
            btnPalSound.Location = point
            Me.btnPalSound.Name = "btnPalSound"
            Dim btnPalSound2 As Global.System.Windows.Forms.Control = Me.btnPalSound
            size = New Global.System.Drawing.Size(22, 22)
            btnPalSound2.Size = size
            Me.btnPalSound.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalSound, "Sounds")
            Me.btnPalTrigger.Image = CType(resourceManager.GetObject("btnPalTrigger.Image"), Global.System.Drawing.Image)
            Me.btnPalTrigger.ImageAlign = Global.System.Drawing.ContentAlignment.BottomRight
            Dim btnPalTrigger As Global.System.Windows.Forms.Control = Me.btnPalTrigger
            point = New Global.System.Drawing.Point(168, 8)
            btnPalTrigger.Location = point
            Me.btnPalTrigger.Name = "btnPalTrigger"
            Dim btnPalTrigger2 As Global.System.Windows.Forms.Control = Me.btnPalTrigger
            size = New Global.System.Drawing.Size(22, 22)
            btnPalTrigger2.Size = size
            Me.btnPalTrigger.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalTrigger, "Triggers")
            Me.chkbShowResRefs.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim chkbShowResRefs As Global.System.Windows.Forms.Control = Me.chkbShowResRefs
            point = New Global.System.Drawing.Point(117, 235)
            chkbShowResRefs.Location = point
            Me.chkbShowResRefs.Name = "chkbShowResRefs"
            Dim chkbShowResRefs2 As Global.System.Windows.Forms.Control = Me.chkbShowResRefs
            size = New Global.System.Drawing.Size(98, 24)
            chkbShowResRefs2.Size = size
            Me.chkbShowResRefs.TabIndex = 11
            Me.chkbShowResRefs.Text = "Show ResRefs"
            Me.btnLogFactors.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnLogFactors As Global.System.Windows.Forms.Control = Me.btnLogFactors
            point = New Global.System.Drawing.Point(154, 376)
            btnLogFactors.Location = point
            Me.btnLogFactors.Name = "btnLogFactors"
            Dim btnLogFactors2 As Global.System.Windows.Forms.Control = Me.btnLogFactors
            size = New Global.System.Drawing.Size(32, 23)
            btnLogFactors2.Size = size
            Me.btnLogFactors.TabIndex = 4
            Me.btnLogFactors.Text = "Log factors"
            Me.btnLogFactors.Visible = False
            Me.pnlPalette.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.pnlPalette.Controls.Add(Me.Label5)
            Me.pnlPalette.Controls.Add(Me.tbHelp)
            Me.pnlPalette.Controls.Add(Me.tabctrlPalette)
            Dim pnlPalette As Global.System.Windows.Forms.Control = Me.pnlPalette
            point = New Global.System.Drawing.Point(632, 8)
            pnlPalette.Location = point
            Me.pnlPalette.Name = "pnlPalette"
            Dim pnlPalette2 As Global.System.Windows.Forms.Control = Me.pnlPalette
            size = New Global.System.Drawing.Size(232, 424)
            pnlPalette2.Size = size
            Me.pnlPalette.TabIndex = 13
            Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim label As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(16, 312)
            label.Location = point
            Me.Label5.Name = "Label5"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(56, 16)
            label2.Size = size
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "Help Info"
            Me.tbHelp.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim tbHelp As Global.System.Windows.Forms.Control = Me.tbHelp
            point = New Global.System.Drawing.Point(8, 328)
            tbHelp.Location = point
            Me.tbHelp.Multiline = True
            Me.tbHelp.Name = "tbHelp"
            Dim tbHelp2 As Global.System.Windows.Forms.Control = Me.tbHelp
            size = New Global.System.Drawing.Size(208, 88)
            tbHelp2.Size = size
            Me.tbHelp.TabIndex = 13
            Me.tbHelp.Text = ""
            Me.tabctrlPalette.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tabctrlPalette.Controls.Add(Me.TabPage1)
            Me.tabctrlPalette.Controls.Add(Me.tabpagUserPalette)
            Me.tabctrlPalette.Enabled = False
            Dim tabctrlPalette As Global.System.Windows.Forms.Control = Me.tabctrlPalette
            point = New Global.System.Drawing.Point(0, 8)
            tabctrlPalette.Location = point
            Me.tabctrlPalette.Name = "tabctrlPalette"
            Me.tabctrlPalette.SelectedIndex = 0
            Dim tabctrlPalette2 As Global.System.Windows.Forms.Control = Me.tabctrlPalette
            size = New Global.System.Drawing.Size(228, 288)
            tabctrlPalette2.Size = size
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
            Dim tabPage As Global.System.Windows.Forms.Control = Me.TabPage1
            point = New Global.System.Drawing.Point(4, 22)
            tabPage.Location = point
            Me.TabPage1.Name = "TabPage1"
            Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
            size = New Global.System.Drawing.Size(220, 262)
            tabPage2.Size = size
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Standard"
            Me.chkbShowNames.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.chkbShowNames.Checked = True
            Me.chkbShowNames.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbShowNames As Global.System.Windows.Forms.Control = Me.chkbShowNames
            point = New Global.System.Drawing.Point(11, 235)
            chkbShowNames.Location = point
            Me.chkbShowNames.Name = "chkbShowNames"
            Dim chkbShowNames2 As Global.System.Windows.Forms.Control = Me.chkbShowNames
            size = New Global.System.Drawing.Size(96, 24)
            chkbShowNames2.Size = size
            Me.chkbShowNames.TabIndex = 11
            Me.chkbShowNames.Text = "Show Names"
            Me.tabpagUserPalette.Controls.Add(Me.tvUserPalette)
            Dim tabpagUserPalette As Global.System.Windows.Forms.Control = Me.tabpagUserPalette
            point = New Global.System.Drawing.Point(4, 22)
            tabpagUserPalette.Location = point
            Me.tabpagUserPalette.Name = "tabpagUserPalette"
            Dim tabpagUserPalette2 As Global.System.Windows.Forms.Control = Me.tabpagUserPalette
            size = New Global.System.Drawing.Size(220, 262)
            tabpagUserPalette2.Size = size
            Me.tabpagUserPalette.TabIndex = 1
            Me.tabpagUserPalette.Text = "User"
            Me.tvUserPalette.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tvUserPalette.ImageIndex = -1
            Dim tvUserPalette As Global.System.Windows.Forms.Control = Me.tvUserPalette
            point = New Global.System.Drawing.Point(8, 16)
            tvUserPalette.Location = point
            Me.tvUserPalette.Name = "tvUserPalette"
            Me.tvUserPalette.Nodes.AddRange(New Global.System.Windows.Forms.TreeNode() {New Global.System.Windows.Forms.TreeNode("Creatures"), New Global.System.Windows.Forms.TreeNode("Doors"), New Global.System.Windows.Forms.TreeNode("Encounters"), New Global.System.Windows.Forms.TreeNode("Stores"), New Global.System.Windows.Forms.TreeNode("Placeables"), New Global.System.Windows.Forms.TreeNode("Sounds"), New Global.System.Windows.Forms.TreeNode("Triggers")})
            Me.tvUserPalette.SelectedImageIndex = -1
            Dim tvUserPalette2 As Global.System.Windows.Forms.Control = Me.tvUserPalette
            size = New Global.System.Drawing.Size(200, 232)
            tvUserPalette2.Size = size
            Me.tvUserPalette.TabIndex = 9
            Me.btnCalToolsToggle.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCalToolsToggle.BackColor = Global.System.Drawing.SystemColors.Control
            Me.btnCalToolsToggle.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnCalToolsToggle.ForeColor = Global.System.Drawing.SystemColors.Control
            Dim btnCalToolsToggle As Global.System.Windows.Forms.Control = Me.btnCalToolsToggle
            point = New Global.System.Drawing.Point(616, 436)
            btnCalToolsToggle.Location = point
            Me.btnCalToolsToggle.Name = "btnCalToolsToggle"
            Dim btnCalToolsToggle2 As Global.System.Windows.Forms.Control = Me.btnCalToolsToggle
            size = New Global.System.Drawing.Size(8, 8)
            btnCalToolsToggle2.Size = size
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
            Dim pnlModElements As Global.System.Windows.Forms.Control = Me.pnlModElements
            point = New Global.System.Drawing.Point(0, 8)
            pnlModElements.Location = point
            Me.pnlModElements.Name = "pnlModElements"
            Dim pnlModElements2 As Global.System.Windows.Forms.Control = Me.pnlModElements
            size = New Global.System.Drawing.Size(192, 424)
            pnlModElements2.Size = size
            Me.pnlModElements.TabIndex = 15
            Me.ToolBarModElementsFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.ToolBarModElementsFilter.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.ToolBarModElementsFilter.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() {Me.tbarbtnCreature, Me.tbarbtnDoor, Me.tbarbtnEncounter, Me.tbarbtnMerchant, Me.tbarbtnPlaceable, Me.tbarbtnSound, Me.tbarbtnTrigger, Me.tbarbtnWaypoint})
            Me.ToolBarModElementsFilter.Divider = False
            Me.ToolBarModElementsFilter.Dock = Global.System.Windows.Forms.DockStyle.None
            Me.ToolBarModElementsFilter.DropDownArrows = True
            Me.ToolBarModElementsFilter.Enabled = False
            Me.ToolBarModElementsFilter.ImageList = Me.ilModElementsFilter
            Dim toolBarModElementsFilter As Global.System.Windows.Forms.Control = Me.ToolBarModElementsFilter
            point = New Global.System.Drawing.Point(16, 304)
            toolBarModElementsFilter.Location = point
            Me.ToolBarModElementsFilter.Name = "ToolBarModElementsFilter"
            Me.ToolBarModElementsFilter.ShowToolTips = True
            Dim toolBarModElementsFilter2 As Global.System.Windows.Forms.Control = Me.ToolBarModElementsFilter
            size = New Global.System.Drawing.Size(96, 49)
            toolBarModElementsFilter2.Size = size
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
            Dim ilModElementsFilter As Global.System.Windows.Forms.ImageList = Me.ilModElementsFilter
            size = New Global.System.Drawing.Size(16, 16)
            ilModElementsFilter.ImageSize = size
            Me.ilModElementsFilter.ImageStream = CType(resourceManager.GetObject("ilModElementsFilter.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
            Me.ilModElementsFilter.TransparentColor = Global.System.Drawing.Color.Transparent
            Me.tabctrlModule.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tabctrlModule.Controls.Add(Me.tabpagModuleElements)
            Me.tabctrlModule.Controls.Add(Me.tabpagScripts)
            Me.tabctrlModule.Controls.Add(Me.tabpagDialogs)
            Dim tabctrlModule As Global.System.Windows.Forms.TabControl = Me.tabctrlModule
            size = New Global.System.Drawing.Size(93, 20)
            tabctrlModule.ItemSize = size
            Dim tabctrlModule2 As Global.System.Windows.Forms.Control = Me.tabctrlModule
            point = New Global.System.Drawing.Point(0, 8)
            tabctrlModule2.Location = point
            Me.tabctrlModule.Multiline = True
            Me.tabctrlModule.Name = "tabctrlModule"
            Dim tabctrlModule3 As Global.System.Windows.Forms.TabControl = Me.tabctrlModule
            point = New Global.System.Drawing.Point(8, 3)
            tabctrlModule3.Padding = point
            Me.tabctrlModule.SelectedIndex = 0
            Dim tabctrlModule4 As Global.System.Windows.Forms.Control = Me.tabctrlModule
            size = New Global.System.Drawing.Size(192, 264)
            tabctrlModule4.Size = size
            Me.tabctrlModule.SizeMode = Global.System.Windows.Forms.TabSizeMode.FillToRight
            Me.tabctrlModule.TabIndex = 13
            Me.tabpagModuleElements.Controls.Add(Me.tvModule)
            Dim tabpagModuleElements As Global.System.Windows.Forms.Control = Me.tabpagModuleElements
            point = New Global.System.Drawing.Point(4, 44)
            tabpagModuleElements.Location = point
            Me.tabpagModuleElements.Name = "tabpagModuleElements"
            Dim tabpagModuleElements2 As Global.System.Windows.Forms.Control = Me.tabpagModuleElements
            size = New Global.System.Drawing.Size(184, 216)
            tabpagModuleElements2.Size = size
            Me.tabpagModuleElements.TabIndex = 0
            Me.tabpagModuleElements.Text = "Module Elements"
            Me.tabpagScripts.Controls.Add(Me.lbScripts)
            Dim tabpagScripts As Global.System.Windows.Forms.Control = Me.tabpagScripts
            point = New Global.System.Drawing.Point(4, 44)
            tabpagScripts.Location = point
            Me.tabpagScripts.Name = "tabpagScripts"
            Dim tabpagScripts2 As Global.System.Windows.Forms.Control = Me.tabpagScripts
            size = New Global.System.Drawing.Size(184, 216)
            tabpagScripts2.Size = size
            Me.tabpagScripts.TabIndex = 1
            Me.tabpagScripts.Text = "Scripts"
            Me.lbScripts.AllowDrop = True
            Me.lbScripts.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Dim lbScripts As Global.System.Windows.Forms.Control = Me.lbScripts
            point = New Global.System.Drawing.Point(0, 0)
            lbScripts.Location = point
            Me.lbScripts.Name = "lbScripts"
            Dim lbScripts2 As Global.System.Windows.Forms.Control = Me.lbScripts
            size = New Global.System.Drawing.Size(184, 216)
            lbScripts2.Size = size
            Me.lbScripts.Sorted = True
            Me.lbScripts.TabIndex = 0
            Me.tabpagDialogs.Controls.Add(Me.lbDialogs)
            Dim tabpagDialogs As Global.System.Windows.Forms.Control = Me.tabpagDialogs
            point = New Global.System.Drawing.Point(4, 44)
            tabpagDialogs.Location = point
            Me.tabpagDialogs.Name = "tabpagDialogs"
            Dim tabpagDialogs2 As Global.System.Windows.Forms.Control = Me.tabpagDialogs
            size = New Global.System.Drawing.Size(184, 216)
            tabpagDialogs2.Size = size
            Me.tabpagDialogs.TabIndex = 2
            Me.tabpagDialogs.Text = "Dialogs"
            Me.lbDialogs.AllowDrop = True
            Me.lbDialogs.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Dim lbDialogs As Global.System.Windows.Forms.Control = Me.lbDialogs
            point = New Global.System.Drawing.Point(0, 0)
            lbDialogs.Location = point
            Me.lbDialogs.Name = "lbDialogs"
            Dim lbDialogs2 As Global.System.Windows.Forms.Control = Me.lbDialogs
            size = New Global.System.Drawing.Size(184, 216)
            lbDialogs2.Size = size
            Me.lbDialogs.Sorted = True
            Me.lbDialogs.TabIndex = 1
            Me.chkbUseFactors.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim chkbUseFactors As Global.System.Windows.Forms.Control = Me.chkbUseFactors
            point = New Global.System.Drawing.Point(8, 400)
            chkbUseFactors.Location = point
            Me.chkbUseFactors.Name = "chkbUseFactors"
            Dim chkbUseFactors2 As Global.System.Windows.Forms.Control = Me.chkbUseFactors
            size = New Global.System.Drawing.Size(112, 16)
            chkbUseFactors2.Size = size
            Me.chkbUseFactors.TabIndex = 17
            Me.chkbUseFactors.Text = "Use these factors"
            Me.chkbUseFactors.Visible = False
            Me.chkbShowTags.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.chkbShowTags.Enabled = False
            Dim chkbShowTags As Global.System.Windows.Forms.Control = Me.chkbShowTags
            point = New Global.System.Drawing.Point(56, 280)
            chkbShowTags.Location = point
            Me.chkbShowTags.Name = "chkbShowTags"
            Dim chkbShowTags2 As Global.System.Windows.Forms.Control = Me.chkbShowTags
            size = New Global.System.Drawing.Size(80, 16)
            chkbShowTags2.Size = size
            Me.chkbShowTags.TabIndex = 17
            Me.chkbShowTags.Text = "Show Tags"
            Me.btnTweakUp.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTweakUp.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTweakUp.Interval = 100
            Dim btnTweakUp As Global.System.Windows.Forms.Control = Me.btnTweakUp
            point = New Global.System.Drawing.Point(160, 296)
            btnTweakUp.Location = point
            Me.btnTweakUp.Name = "btnTweakUp"
            Dim btnTweakUp2 As Global.System.Windows.Forms.Control = Me.btnTweakUp
            size = New Global.System.Drawing.Size(16, 16)
            btnTweakUp2.Size = size
            Me.btnTweakUp.TabIndex = 4
            Me.btnTweakUp.Text = "^"
            Me.btnTweakUp.TextAlign = Global.System.Drawing.ContentAlignment.TopLeft
            Me.btnTweakLeft.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTweakLeft.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTweakLeft.Interval = 100
            Dim btnTweakLeft As Global.System.Windows.Forms.Control = Me.btnTweakLeft
            point = New Global.System.Drawing.Point(144, 312)
            btnTweakLeft.Location = point
            Me.btnTweakLeft.Name = "btnTweakLeft"
            Dim btnTweakLeft2 As Global.System.Windows.Forms.Control = Me.btnTweakLeft
            size = New Global.System.Drawing.Size(16, 16)
            btnTweakLeft2.Size = size
            Me.btnTweakLeft.TabIndex = 4
            Me.btnTweakLeft.Text = "<"
            Me.btnTweakLeft.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTweakRight.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTweakRight.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTweakRight.Interval = 100
            Dim btnTweakRight As Global.System.Windows.Forms.Control = Me.btnTweakRight
            point = New Global.System.Drawing.Point(176, 312)
            btnTweakRight.Location = point
            Me.btnTweakRight.Name = "btnTweakRight"
            Dim btnTweakRight2 As Global.System.Windows.Forms.Control = Me.btnTweakRight
            size = New Global.System.Drawing.Size(16, 16)
            btnTweakRight2.Size = size
            Me.btnTweakRight.TabIndex = 4
            Me.btnTweakRight.Text = ">"
            Me.btnTweakRight.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTweakDown.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnTweakDown.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTweakDown.Interval = 100
            Dim btnTweakDown As Global.System.Windows.Forms.Control = Me.btnTweakDown
            point = New Global.System.Drawing.Point(160, 328)
            btnTweakDown.Location = point
            Me.btnTweakDown.Name = "btnTweakDown"
            Dim btnTweakDown2 As Global.System.Windows.Forms.Control = Me.btnTweakDown
            size = New Global.System.Drawing.Size(16, 16)
            btnTweakDown2.Size = size
            Me.btnTweakDown.TabIndex = 4
            Me.btnTweakDown.Text = "v"
            Me.btnTweakDown.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbFine.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim chkbFine As Global.System.Windows.Forms.Control = Me.chkbFine
            point = New Global.System.Drawing.Point(128, 400)
            chkbFine.Location = point
            Me.chkbFine.Name = "chkbFine"
            Dim chkbFine2 As Global.System.Windows.Forms.Control = Me.chkbFine
            size = New Global.System.Drawing.Size(48, 16)
            chkbFine2.Size = size
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
            Me.miShowModuleEntryPoint.Text = "Show Module Entry Point"
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
            Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
            point = New Global.System.Drawing.Point(0, 0)
            btnDebug.Location = point
            Me.btnDebug.Name = "btnDebug"
            Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
            size = New Global.System.Drawing.Size(8, 8)
            btnDebug2.Size = size
            Me.btnDebug.TabIndex = 16
            Me.btnDebug.TabStop = False
            Dim sbar As Global.System.Windows.Forms.Control = Me.sbar
            point = New Global.System.Drawing.Point(0, 451)
            sbar.Location = point
            Me.sbar.Name = "sbar"
            Me.sbar.Panels.AddRange(New Global.System.Windows.Forms.StatusBarPanel() {Me.sbarpnlLocX, Me.sbarpnlLocY, Me.sbarpnlDesc, Me.sbarpnlAddlInfo, Me.sbarpnlStatus})
            Me.sbar.ShowPanels = True
            Dim sbar2 As Global.System.Windows.Forms.Control = Me.sbar
            size = New Global.System.Drawing.Size(864, 22)
            sbar2.Size = size
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
            Me.cmiSetModuleStartPoint.Text = "Set as Module starting point"
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
            Dim tbMouseX As Global.System.Windows.Forms.Control = Me.tbMouseX
            point = New Global.System.Drawing.Point(0, 432)
            tbMouseX.Location = point
            Me.tbMouseX.Name = "tbMouseX"
            Dim tbMouseX2 As Global.System.Windows.Forms.Control = Me.tbMouseX
            size = New Global.System.Drawing.Size(64, 20)
            tbMouseX2.Size = size
            Me.tbMouseX.TabIndex = 0
            Me.tbMouseX.Text = ""
            Me.tbMouseX.Visible = False
            Me.tbMouseY.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim tbMouseY As Global.System.Windows.Forms.Control = Me.tbMouseY
            point = New Global.System.Drawing.Point(88, 432)
            tbMouseY.Location = point
            Me.tbMouseY.Name = "tbMouseY"
            Dim tbMouseY2 As Global.System.Windows.Forms.Control = Me.tbMouseY
            size = New Global.System.Drawing.Size(64, 20)
            tbMouseY2.Size = size
            Me.tbMouseY.TabIndex = 1
            Me.tbMouseY.Text = ""
            Me.tbMouseY.Visible = False
            Me.btnAssignPt1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim btnAssignPt As Global.System.Windows.Forms.Control = Me.btnAssignPt1
            point = New Global.System.Drawing.Point(160, 435)
            btnAssignPt.Location = point
            Me.btnAssignPt1.Name = "btnAssignPt1"
            Dim btnAssignPt2 As Global.System.Windows.Forms.Control = Me.btnAssignPt1
            size = New Global.System.Drawing.Size(16, 16)
            btnAssignPt2.Size = size
            Me.btnAssignPt1.TabIndex = 2
            Me.btnAssignPt1.Text = "1"
            Me.btnAssignPt1.Visible = False
            Me.btnAssignPt2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim btnAssignPt3 As Global.System.Windows.Forms.Control = Me.btnAssignPt2
            point = New Global.System.Drawing.Point(184, 435)
            btnAssignPt3.Location = point
            Me.btnAssignPt2.Name = "btnAssignPt2"
            Dim btnAssignPt4 As Global.System.Windows.Forms.Control = Me.btnAssignPt2
            size = New Global.System.Drawing.Size(16, 16)
            btnAssignPt4.Size = size
            Me.btnAssignPt2.TabIndex = 3
            Me.btnAssignPt2.Text = "2"
            Me.btnAssignPt2.Visible = False
            Me.tb3dsMaxPt1X.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim tb3dsMaxPt1X As Global.System.Windows.Forms.Control = Me.tb3dsMaxPt1X
            point = New Global.System.Drawing.Point(264, 432)
            tb3dsMaxPt1X.Location = point
            Me.tb3dsMaxPt1X.Name = "tb3dsMaxPt1X"
            Dim tb3dsMaxPt1X2 As Global.System.Windows.Forms.Control = Me.tb3dsMaxPt1X
            size = New Global.System.Drawing.Size(64, 20)
            tb3dsMaxPt1X2.Size = size
            Me.tb3dsMaxPt1X.TabIndex = 4
            Me.tb3dsMaxPt1X.Text = "110.516"
            Me.tb3dsMaxPt1X.Visible = False
            Me.tb3dsMaxPt1Y.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim tb3dsMaxPt1Y As Global.System.Windows.Forms.Control = Me.tb3dsMaxPt1Y
            point = New Global.System.Drawing.Point(344, 432)
            tb3dsMaxPt1Y.Location = point
            Me.tb3dsMaxPt1Y.Name = "tb3dsMaxPt1Y"
            Dim tb3dsMaxPt1Y2 As Global.System.Windows.Forms.Control = Me.tb3dsMaxPt1Y
            size = New Global.System.Drawing.Size(64, 20)
            tb3dsMaxPt1Y2.Size = size
            Me.tb3dsMaxPt1Y.TabIndex = 5
            Me.tb3dsMaxPt1Y.Text = "133.604"
            Me.tb3dsMaxPt1Y.Visible = False
            Me.tb3dsMaxPt2Y.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim tb3dsMaxPt2Y As Global.System.Windows.Forms.Control = Me.tb3dsMaxPt2Y
            point = New Global.System.Drawing.Point(528, 432)
            tb3dsMaxPt2Y.Location = point
            Me.tb3dsMaxPt2Y.Name = "tb3dsMaxPt2Y"
            Dim tb3dsMaxPt2Y2 As Global.System.Windows.Forms.Control = Me.tb3dsMaxPt2Y
            size = New Global.System.Drawing.Size(64, 20)
            tb3dsMaxPt2Y2.Size = size
            Me.tb3dsMaxPt2Y.TabIndex = 7
            Me.tb3dsMaxPt2Y.Text = "78.001"
            Me.tb3dsMaxPt2Y.Visible = False
            Me.tb3dsMaxPt2X.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim tb3dsMaxPt2X As Global.System.Windows.Forms.Control = Me.tb3dsMaxPt2X
            point = New Global.System.Drawing.Point(448, 432)
            tb3dsMaxPt2X.Location = point
            Me.tb3dsMaxPt2X.Name = "tb3dsMaxPt2X"
            Dim tb3dsMaxPt2X2 As Global.System.Windows.Forms.Control = Me.tb3dsMaxPt2X
            size = New Global.System.Drawing.Size(64, 20)
            tb3dsMaxPt2X2.Size = size
            Me.tb3dsMaxPt2X.TabIndex = 6
            Me.tb3dsMaxPt2X.Text = "105.987"
            Me.tb3dsMaxPt2X.Visible = False
            Me.btnCalcCalibrationVals.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnCalcCalibrationVals.Enabled = False
            Dim btnCalcCalibrationVals As Global.System.Windows.Forms.Control = Me.btnCalcCalibrationVals
            point = New Global.System.Drawing.Point(208, 435)
            btnCalcCalibrationVals.Location = point
            Me.btnCalcCalibrationVals.Name = "btnCalcCalibrationVals"
            Dim btnCalcCalibrationVals2 As Global.System.Windows.Forms.Control = Me.btnCalcCalibrationVals
            size = New Global.System.Drawing.Size(16, 16)
            btnCalcCalibrationVals2.Size = size
            Me.btnCalcCalibrationVals.TabIndex = 8
            Me.btnCalcCalibrationVals.Text = "C"
            Me.btnCalcCalibrationVals.Visible = False
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(864, 473)
            Me.ClientSize = size
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
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Menu = Me.MainMenu1
            size = New Global.System.Drawing.Size(576, 480)
            Me.MinimumSize = size
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
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x0400045F RID: 1119
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
