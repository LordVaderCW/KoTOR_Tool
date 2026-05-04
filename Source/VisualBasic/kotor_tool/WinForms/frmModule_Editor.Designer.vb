Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmModule_Editor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' frmModule_Editor.Designer.vb
        '
        ' Restored / facelifted Module Editor for the KoTOR Tool Restoration.
        '
        ' Original Tool:
        '   Fred Tetra's KotOR Tool
        '
        ' Restoration Project:
        '   KoTOR Tool REBORN
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original control names preserved for source compatibility.
        '   - Theme colours are applied at runtime from Themes\DarkSaber.ini.
        '   - Designer keeps fallback colours only for safe VS designer display.
        '
        '   - Added global new head for window. 
        '
        '   - 01.05.26
        '   - LordVaderCW.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer


        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
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
        Friend WithEvents tabctrlPalette As Global.kotor_tool.CustomTabControl

        Friend WithEvents MenuItem7 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenProject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tabpagModuleElements As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagScripts As Global.System.Windows.Forms.TabPage

        Friend WithEvents tabctrlModule As Global.kotor_tool.CustomTabControl
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


        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Creatures")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doors")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Encounters")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stores")
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Placeables")
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sounds")
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Triggers")
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModule_Editor))
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.btnAssignPt1 = New System.Windows.Forms.Button()
            Me.tbMouseX = New System.Windows.Forms.TextBox()
            Me.sbar = New System.Windows.Forms.StatusBar()
            Me.sbarpnlLocX = New System.Windows.Forms.StatusBarPanel()
            Me.sbarpnlLocY = New System.Windows.Forms.StatusBarPanel()
            Me.sbarpnlDesc = New System.Windows.Forms.StatusBarPanel()
            Me.sbarpnlAddlInfo = New System.Windows.Forms.StatusBarPanel()
            Me.sbarpnlStatus = New System.Windows.Forms.StatusBarPanel()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.pnlModElements = New System.Windows.Forms.Panel()
            Me.ToolBarModElementsFilter = New System.Windows.Forms.ToolBar()
            Me.tbarbtnCreature = New System.Windows.Forms.ToolBarButton()
            Me.tbarbtnDoor = New System.Windows.Forms.ToolBarButton()
            Me.tbarbtnEncounter = New System.Windows.Forms.ToolBarButton()
            Me.tbarbtnMerchant = New System.Windows.Forms.ToolBarButton()
            Me.tbarbtnPlaceable = New System.Windows.Forms.ToolBarButton()
            Me.tbarbtnSound = New System.Windows.Forms.ToolBarButton()
            Me.tbarbtnTrigger = New System.Windows.Forms.ToolBarButton()
            Me.tbarbtnWaypoint = New System.Windows.Forms.ToolBarButton()
            Me.ilModElementsFilter = New System.Windows.Forms.ImageList(Me.components)
            Me.tabctrlModule = New kotor_tool.CustomTabControl()
            Me.tabpagModuleElements = New System.Windows.Forms.TabPage()
            Me.tvModule = New System.Windows.Forms.TreeView()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.tabpagScripts = New System.Windows.Forms.TabPage()
            Me.lbScripts = New System.Windows.Forms.ListBox()
            Me.tabpagDialogs = New System.Windows.Forms.TabPage()
            Me.lbDialogs = New System.Windows.Forms.ListBox()
            Me.nudXmul = New System.Windows.Forms.NumericUpDown()
            Me.nudYmul = New System.Windows.Forms.NumericUpDown()
            Me.nudXoff = New System.Windows.Forms.NumericUpDown()
            Me.nudYoff = New System.Windows.Forms.NumericUpDown()
            Me.chkbUseFactors = New System.Windows.Forms.CheckBox()
            Me.btnLogFactors = New System.Windows.Forms.Button()
            Me.chkbShowTags = New System.Windows.Forms.CheckBox()
            Me.btnTweakUp = New kotor_tool.RepeatButton()
            Me.btnTweakLeft = New kotor_tool.RepeatButton()
            Me.btnTweakRight = New kotor_tool.RepeatButton()
            Me.btnTweakDown = New kotor_tool.RepeatButton()
            Me.chkbFine = New System.Windows.Forms.CheckBox()
            Me.pnlPalette = New System.Windows.Forms.Panel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.tbHelp = New System.Windows.Forms.TextBox()
            Me.tabctrlPalette = New kotor_tool.CustomTabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.btnPalWaypoint = New System.Windows.Forms.Button()
            Me.btnPalSound = New System.Windows.Forms.Button()
            Me.btnPalTrigger = New System.Windows.Forms.Button()
            Me.btnPalDoor = New System.Windows.Forms.Button()
            Me.btnPalEncounter = New System.Windows.Forms.Button()
            Me.btnPalCreature = New System.Windows.Forms.Button()
            Me.btnPalPlaceable = New System.Windows.Forms.Button()
            Me.btnPalMerchant = New System.Windows.Forms.Button()
            Me.tvPalette = New System.Windows.Forms.TreeView()
            Me.chkbShowResRefs = New System.Windows.Forms.CheckBox()
            Me.chkbShowNames = New System.Windows.Forms.CheckBox()
            Me.btnPalItem = New System.Windows.Forms.Button()
            Me.tabpagUserPalette = New System.Windows.Forms.TabPage()
            Me.tvUserPalette = New System.Windows.Forms.TreeView()
            Me.btnTest = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pbox = New System.Windows.Forms.PictureBox()
            Me.btnClean = New System.Windows.Forms.Button()
            Me.tbMouseY = New System.Windows.Forms.TextBox()
            Me.btnAssignPt2 = New System.Windows.Forms.Button()
            Me.tb3dsMaxPt1X = New System.Windows.Forms.TextBox()
            Me.tb3dsMaxPt1Y = New System.Windows.Forms.TextBox()
            Me.tb3dsMaxPt2Y = New System.Windows.Forms.TextBox()
            Me.tb3dsMaxPt2X = New System.Windows.Forms.TextBox()
            Me.btnCalcCalibrationVals = New System.Windows.Forms.Button()
            Me.btnCalToolsToggle = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.tvModuleContextMenuItem = New System.Windows.Forms.ContextMenu()
            Me.cmiTvModuleItemDelete = New System.Windows.Forms.MenuItem()
            Me.cmiTvModuleItemEdit = New System.Windows.Forms.MenuItem()
            Me.cmiTvModuleItemProperties = New System.Windows.Forms.MenuItem()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miOpenProject = New System.Windows.Forms.MenuItem()
            Me.miSave = New System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New System.Windows.Forms.MenuItem()
            Me.miBuildModFile = New System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New System.Windows.Forms.MenuItem()
            Me.miExploreModuleFolder = New System.Windows.Forms.MenuItem()
            Me.miCopyToOverride = New System.Windows.Forms.MenuItem()
            Me.miRemoveFromOverride = New System.Windows.Forms.MenuItem()
            Me.miCleanOverride = New System.Windows.Forms.MenuItem()
            Me.MenuItem9 = New System.Windows.Forms.MenuItem()
            Me.miClose = New System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New System.Windows.Forms.MenuItem()
            Me.miModuleProperties = New System.Windows.Forms.MenuItem()
            Me.mnuView = New System.Windows.Forms.MenuItem()
            Me.miShowHideModuleElements = New System.Windows.Forms.MenuItem()
            Me.miShowHidePalette = New System.Windows.Forms.MenuItem()
            Me.miShowItemLabels = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.miUseSmallMap = New System.Windows.Forms.MenuItem()
            Me.miUseLargeMap = New System.Windows.Forms.MenuItem()
            Me.miUseAltSmallMap = New System.Windows.Forms.MenuItem()
            Me.MenuItem11 = New System.Windows.Forms.MenuItem()
            Me.miShowModuleEntryPoint = New System.Windows.Forms.MenuItem()
            Me.miShowModulePaths = New System.Windows.Forms.MenuItem()
            Me.miFont = New System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New System.Windows.Forms.MenuItem()
            Me.miShowGitDump = New System.Windows.Forms.MenuItem()
            Me.miShowAreDump = New System.Windows.Forms.MenuItem()
            Me.miShowIfoDump = New System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New System.Windows.Forms.MenuItem()
            Me.miOptions = New System.Windows.Forms.MenuItem()
            Me.cmPbox = New System.Windows.Forms.ContextMenu()
            Me.cmiCreateCameraHere = New System.Windows.Forms.MenuItem()
            Me.cmiSetModuleStartPoint = New System.Windows.Forms.MenuItem()
            Me.MenuItem13 = New System.Windows.Forms.MenuItem()
            Me.cmiModuleProperties = New System.Windows.Forms.MenuItem()
            Me.cmMapSurfaceItems = New System.Windows.Forms.ContextMenu()
            Me.cmiDelete = New System.Windows.Forms.MenuItem()
            Me.cmiEditGFFFile = New System.Windows.Forms.MenuItem()
            Me.cmiProperties = New System.Windows.Forms.MenuItem()
            Me.cmiAddNewSpawnPoint = New System.Windows.Forms.MenuItem()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            CType(Me.sbarpnlLocX, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbarpnlLocY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbarpnlDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbarpnlAddlInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbarpnlStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlModElements.SuspendLayout()
            Me.tabctrlModule.SuspendLayout()
            Me.tabpagModuleElements.SuspendLayout()
            Me.tabpagScripts.SuspendLayout()
            Me.tabpagDialogs.SuspendLayout()
            CType(Me.nudXmul, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudYmul, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudXoff, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudYoff, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlPalette.SuspendLayout()
            Me.tabctrlPalette.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.tabpagUserPalette.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.pbox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(1000, 673)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.btnAssignPt1)
            Me.pnlBody.Controls.Add(Me.tbMouseX)
            Me.pnlBody.Controls.Add(Me.sbar)
            Me.pnlBody.Controls.Add(Me.btnDebug)
            Me.pnlBody.Controls.Add(Me.pnlModElements)
            Me.pnlBody.Controls.Add(Me.pnlPalette)
            Me.pnlBody.Controls.Add(Me.btnTest)
            Me.pnlBody.Controls.Add(Me.Panel1)
            Me.pnlBody.Controls.Add(Me.btnClean)
            Me.pnlBody.Controls.Add(Me.tbMouseY)
            Me.pnlBody.Controls.Add(Me.btnAssignPt2)
            Me.pnlBody.Controls.Add(Me.tb3dsMaxPt1X)
            Me.pnlBody.Controls.Add(Me.tb3dsMaxPt1Y)
            Me.pnlBody.Controls.Add(Me.tb3dsMaxPt2Y)
            Me.pnlBody.Controls.Add(Me.tb3dsMaxPt2X)
            Me.pnlBody.Controls.Add(Me.btnCalcCalibrationVals)
            Me.pnlBody.Controls.Add(Me.btnCalToolsToggle)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 74)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Size = New System.Drawing.Size(998, 597)
            Me.pnlBody.TabIndex = 1
            '
            'btnAssignPt1
            '
            Me.btnAssignPt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAssignPt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAssignPt1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAssignPt1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAssignPt1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAssignPt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAssignPt1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAssignPt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnAssignPt1.Location = New System.Drawing.Point(160, 618)
            Me.btnAssignPt1.Name = "btnAssignPt1"
            Me.btnAssignPt1.Size = New System.Drawing.Size(32, 32)
            Me.btnAssignPt1.TabIndex = 2
            Me.btnAssignPt1.Text = "1"
            Me.btnAssignPt1.UseVisualStyleBackColor = False
            Me.btnAssignPt1.Visible = False
            '
            'tbMouseX
            '
            Me.tbMouseX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tbMouseX.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMouseX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMouseX.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMouseX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMouseX.Location = New System.Drawing.Point(9, 623)
            Me.tbMouseX.Name = "tbMouseX"
            Me.tbMouseX.Size = New System.Drawing.Size(64, 20)
            Me.tbMouseX.TabIndex = 0
            Me.tbMouseX.Visible = False
            '
            'sbar
            '
            Me.sbar.Location = New System.Drawing.Point(0, 572)
            Me.sbar.Name = "sbar"
            Me.sbar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sbarpnlLocX, Me.sbarpnlLocY, Me.sbarpnlDesc, Me.sbarpnlAddlInfo, Me.sbarpnlStatus})
            Me.sbar.ShowPanels = True
            Me.sbar.Size = New System.Drawing.Size(998, 25)
            Me.sbar.TabIndex = 18
            Me.sbar.Text = "StatusBar1"
            '
            'sbarpnlLocX
            '
            Me.sbarpnlLocX.Name = "sbarpnlLocX"
            Me.sbarpnlLocX.Width = 70
            '
            'sbarpnlLocY
            '
            Me.sbarpnlLocY.Name = "sbarpnlLocY"
            Me.sbarpnlLocY.Width = 70
            '
            'sbarpnlDesc
            '
            Me.sbarpnlDesc.Name = "sbarpnlDesc"
            Me.sbarpnlDesc.Width = 120
            '
            'sbarpnlAddlInfo
            '
            Me.sbarpnlAddlInfo.Name = "sbarpnlAddlInfo"
            Me.sbarpnlAddlInfo.Width = 180
            '
            'sbarpnlStatus
            '
            Me.sbarpnlStatus.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
            Me.sbarpnlStatus.Name = "sbarpnlStatus"
            Me.sbarpnlStatus.Width = 541
            '
            'btnDebug
            '
            Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnDebug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnDebug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnDebug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnDebug.Location = New System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 9)
            Me.btnDebug.TabIndex = 16
            Me.btnDebug.TabStop = False
            Me.btnDebug.UseVisualStyleBackColor = False
            '
            'pnlModElements
            '
            Me.pnlModElements.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pnlModElements.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlModElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
            Me.pnlModElements.Location = New System.Drawing.Point(0, 9)
            Me.pnlModElements.Name = "pnlModElements"
            Me.pnlModElements.Size = New System.Drawing.Size(211, 557)
            Me.pnlModElements.TabIndex = 15
            '
            'ToolBarModElementsFilter
            '
            Me.ToolBarModElementsFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.ToolBarModElementsFilter.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
            Me.ToolBarModElementsFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ToolBarModElementsFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ToolBarModElementsFilter.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbarbtnCreature, Me.tbarbtnDoor, Me.tbarbtnEncounter, Me.tbarbtnMerchant, Me.tbarbtnPlaceable, Me.tbarbtnSound, Me.tbarbtnTrigger, Me.tbarbtnWaypoint})
            Me.ToolBarModElementsFilter.Divider = False
            Me.ToolBarModElementsFilter.Dock = System.Windows.Forms.DockStyle.None
            Me.ToolBarModElementsFilter.DropDownArrows = True
            Me.ToolBarModElementsFilter.Enabled = False
            Me.ToolBarModElementsFilter.ImageList = Me.ilModElementsFilter
            Me.ToolBarModElementsFilter.Location = New System.Drawing.Point(11, 381)
            Me.ToolBarModElementsFilter.Name = "ToolBarModElementsFilter"
            Me.ToolBarModElementsFilter.ShowToolTips = True
            Me.ToolBarModElementsFilter.Size = New System.Drawing.Size(96, 49)
            Me.ToolBarModElementsFilter.TabIndex = 18
            '
            'tbarbtnCreature
            '
            Me.tbarbtnCreature.ImageIndex = 0
            Me.tbarbtnCreature.Name = "tbarbtnCreature"
            Me.tbarbtnCreature.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnCreature.ToolTipText = "Show Creatures"
            '
            'tbarbtnDoor
            '
            Me.tbarbtnDoor.ImageIndex = 1
            Me.tbarbtnDoor.Name = "tbarbtnDoor"
            Me.tbarbtnDoor.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnDoor.ToolTipText = "Show Doors"
            '
            'tbarbtnEncounter
            '
            Me.tbarbtnEncounter.ImageIndex = 2
            Me.tbarbtnEncounter.Name = "tbarbtnEncounter"
            Me.tbarbtnEncounter.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnEncounter.ToolTipText = "Show Encounters"
            '
            'tbarbtnMerchant
            '
            Me.tbarbtnMerchant.ImageIndex = 3
            Me.tbarbtnMerchant.Name = "tbarbtnMerchant"
            Me.tbarbtnMerchant.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnMerchant.ToolTipText = "Show Merchants"
            '
            'tbarbtnPlaceable
            '
            Me.tbarbtnPlaceable.ImageIndex = 4
            Me.tbarbtnPlaceable.Name = "tbarbtnPlaceable"
            Me.tbarbtnPlaceable.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnPlaceable.ToolTipText = "Show Placeables"
            '
            'tbarbtnSound
            '
            Me.tbarbtnSound.ImageIndex = 5
            Me.tbarbtnSound.Name = "tbarbtnSound"
            Me.tbarbtnSound.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnSound.ToolTipText = "Show Sounds"
            '
            'tbarbtnTrigger
            '
            Me.tbarbtnTrigger.ImageIndex = 6
            Me.tbarbtnTrigger.Name = "tbarbtnTrigger"
            Me.tbarbtnTrigger.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnTrigger.ToolTipText = "Show Triggers"
            '
            'tbarbtnWaypoint
            '
            Me.tbarbtnWaypoint.ImageIndex = 7
            Me.tbarbtnWaypoint.Name = "tbarbtnWaypoint"
            Me.tbarbtnWaypoint.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.tbarbtnWaypoint.ToolTipText = "Show Waypoints"
            '
            'ilModElementsFilter
            '
            Me.ilModElementsFilter.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.ilModElementsFilter.ImageSize = New System.Drawing.Size(16, 16)
            Me.ilModElementsFilter.TransparentColor = System.Drawing.Color.Transparent
            '
            'tabctrlModule
            '
            Me.tabctrlModule.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tabctrlModule.Controls.Add(Me.tabpagModuleElements)
            Me.tabctrlModule.Controls.Add(Me.tabpagScripts)
            Me.tabctrlModule.Controls.Add(Me.tabpagDialogs)
            Me.tabctrlModule.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabctrlModule.ItemSize = New System.Drawing.Size(93, 20)
            Me.tabctrlModule.Location = New System.Drawing.Point(3, 9)
            Me.tabctrlModule.Multiline = True
            Me.tabctrlModule.Name = "tabctrlModule"
            Me.tabctrlModule.Padding = New System.Drawing.Point(8, 3)
            Me.tabctrlModule.SelectedIndex = 0
            Me.tabctrlModule.Size = New System.Drawing.Size(202, 335)
            Me.tabctrlModule.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
            Me.tabctrlModule.TabIndex = 13
            '
            'tabpagModuleElements
            '
            Me.tabpagModuleElements.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagModuleElements.Controls.Add(Me.tvModule)
            Me.tabpagModuleElements.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagModuleElements.Location = New System.Drawing.Point(4, 44)
            Me.tabpagModuleElements.Name = "tabpagModuleElements"
            Me.tabpagModuleElements.Size = New System.Drawing.Size(194, 287)
            Me.tabpagModuleElements.TabIndex = 0
            Me.tabpagModuleElements.Text = "Module Elements"
            '
            'tvModule
            '
            Me.tvModule.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tvModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tvModule.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvModule.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tvModule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tvModule.HideSelection = False
            Me.tvModule.ImageIndex = 0
            Me.tvModule.ImageList = Me.ImageList1
            Me.tvModule.Indent = 19
            Me.tvModule.LineColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tvModule.Location = New System.Drawing.Point(0, 0)
            Me.tvModule.Name = "tvModule"
            Me.tvModule.SelectedImageIndex = 0
            Me.tvModule.Size = New System.Drawing.Size(194, 287)
            Me.tvModule.TabIndex = 8
            '
            'ImageList1
            '
            Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            '
            'tabpagScripts
            '
            Me.tabpagScripts.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagScripts.Controls.Add(Me.lbScripts)
            Me.tabpagScripts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagScripts.Location = New System.Drawing.Point(4, 44)
            Me.tabpagScripts.Name = "tabpagScripts"
            Me.tabpagScripts.Size = New System.Drawing.Size(184, 161)
            Me.tabpagScripts.TabIndex = 1
            Me.tabpagScripts.Text = "Scripts"
            '
            'lbScripts
            '
            Me.lbScripts.AllowDrop = True
            Me.lbScripts.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lbScripts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbScripts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbScripts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbScripts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbScripts.Location = New System.Drawing.Point(0, 0)
            Me.lbScripts.Name = "lbScripts"
            Me.lbScripts.Size = New System.Drawing.Size(184, 161)
            Me.lbScripts.Sorted = True
            Me.lbScripts.TabIndex = 0
            '
            'tabpagDialogs
            '
            Me.tabpagDialogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagDialogs.Controls.Add(Me.lbDialogs)
            Me.tabpagDialogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagDialogs.Location = New System.Drawing.Point(4, 44)
            Me.tabpagDialogs.Name = "tabpagDialogs"
            Me.tabpagDialogs.Size = New System.Drawing.Size(184, 161)
            Me.tabpagDialogs.TabIndex = 2
            Me.tabpagDialogs.Text = "Dialogs"
            '
            'lbDialogs
            '
            Me.lbDialogs.AllowDrop = True
            Me.lbDialogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lbDialogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbDialogs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbDialogs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbDialogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbDialogs.Location = New System.Drawing.Point(0, 0)
            Me.lbDialogs.Name = "lbDialogs"
            Me.lbDialogs.Size = New System.Drawing.Size(184, 161)
            Me.lbDialogs.Sorted = True
            Me.lbDialogs.TabIndex = 1
            '
            'nudXmul
            '
            Me.nudXmul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.nudXmul.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudXmul.DecimalPlaces = 2
            Me.nudXmul.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudXmul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudXmul.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudXmul.Location = New System.Drawing.Point(3, 449)
            Me.nudXmul.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
            Me.nudXmul.Name = "nudXmul"
            Me.nudXmul.Size = New System.Drawing.Size(64, 20)
            Me.nudXmul.TabIndex = 0
            Me.nudXmul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudXmul.Value = New Decimal(New Integer() {125, 0, 0, 65536})
            Me.nudXmul.Visible = False
            '
            'nudYmul
            '
            Me.nudYmul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.nudYmul.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudYmul.DecimalPlaces = 2
            Me.nudYmul.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudYmul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudYmul.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudYmul.Location = New System.Drawing.Point(73, 449)
            Me.nudYmul.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
            Me.nudYmul.Name = "nudYmul"
            Me.nudYmul.Size = New System.Drawing.Size(64, 20)
            Me.nudYmul.TabIndex = 1
            Me.nudYmul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudYmul.Value = New Decimal(New Integer() {125, 0, 0, 65536})
            Me.nudYmul.Visible = False
            '
            'nudXoff
            '
            Me.nudXoff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.nudXoff.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudXoff.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudXoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudXoff.Location = New System.Drawing.Point(3, 474)
            Me.nudXoff.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
            Me.nudXoff.Minimum = New Decimal(New Integer() {20000, 0, 0, -2147483648})
            Me.nudXoff.Name = "nudXoff"
            Me.nudXoff.Size = New System.Drawing.Size(64, 20)
            Me.nudXoff.TabIndex = 2
            Me.nudXoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudXoff.Value = New Decimal(New Integer() {838, 0, 0, 0})
            Me.nudXoff.Visible = False
            '
            'nudYoff
            '
            Me.nudYoff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.nudYoff.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudYoff.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudYoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudYoff.Location = New System.Drawing.Point(73, 474)
            Me.nudYoff.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
            Me.nudYoff.Minimum = New Decimal(New Integer() {20000, 0, 0, -2147483648})
            Me.nudYoff.Name = "nudYoff"
            Me.nudYoff.Size = New System.Drawing.Size(64, 20)
            Me.nudYoff.TabIndex = 3
            Me.nudYoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.nudYoff.Value = New Decimal(New Integer() {846, 0, 0, 0})
            Me.nudYoff.Visible = False
            '
            'chkbUseFactors
            '
            Me.chkbUseFactors.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chkbUseFactors.BackColor = System.Drawing.Color.Transparent
            Me.chkbUseFactors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbUseFactors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUseFactors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbUseFactors.Location = New System.Drawing.Point(3, 502)
            Me.chkbUseFactors.Name = "chkbUseFactors"
            Me.chkbUseFactors.Size = New System.Drawing.Size(134, 18)
            Me.chkbUseFactors.TabIndex = 17
            Me.chkbUseFactors.Text = "Use these factors"
            Me.chkbUseFactors.UseVisualStyleBackColor = False
            Me.chkbUseFactors.Visible = False
            '
            'btnLogFactors
            '
            Me.btnLogFactors.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnLogFactors.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnLogFactors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnLogFactors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnLogFactors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnLogFactors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogFactors.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLogFactors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnLogFactors.Location = New System.Drawing.Point(143, 449)
            Me.btnLogFactors.Name = "btnLogFactors"
            Me.btnLogFactors.Size = New System.Drawing.Size(58, 45)
            Me.btnLogFactors.TabIndex = 4
            Me.btnLogFactors.Text = "Log factors"
            Me.btnLogFactors.UseVisualStyleBackColor = False
            Me.btnLogFactors.Visible = False
            '
            'chkbShowTags
            '
            Me.chkbShowTags.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chkbShowTags.BackColor = System.Drawing.Color.Transparent
            Me.chkbShowTags.Enabled = False
            Me.chkbShowTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbShowTags.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbShowTags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbShowTags.Location = New System.Drawing.Point(11, 357)
            Me.chkbShowTags.Name = "chkbShowTags"
            Me.chkbShowTags.Size = New System.Drawing.Size(96, 18)
            Me.chkbShowTags.TabIndex = 17
            Me.chkbShowTags.Text = "Show Tags"
            Me.chkbShowTags.UseVisualStyleBackColor = False
            '
            'btnTweakUp
            '
            Me.btnTweakUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnTweakUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnTweakUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnTweakUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnTweakUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnTweakUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTweakUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTweakUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnTweakUp.Interval = 100
            Me.btnTweakUp.Location = New System.Drawing.Point(156, 367)
            Me.btnTweakUp.Name = "btnTweakUp"
            Me.btnTweakUp.Size = New System.Drawing.Size(22, 22)
            Me.btnTweakUp.TabIndex = 4
            Me.btnTweakUp.Text = "^"
            Me.btnTweakUp.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.btnTweakUp.UseVisualStyleBackColor = False
            '
            'btnTweakLeft
            '
            Me.btnTweakLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnTweakLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnTweakLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnTweakLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnTweakLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnTweakLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTweakLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTweakLeft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnTweakLeft.Interval = 100
            Me.btnTweakLeft.Location = New System.Drawing.Point(133, 390)
            Me.btnTweakLeft.Name = "btnTweakLeft"
            Me.btnTweakLeft.Size = New System.Drawing.Size(22, 22)
            Me.btnTweakLeft.TabIndex = 4
            Me.btnTweakLeft.Text = "<"
            Me.btnTweakLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTweakLeft.UseVisualStyleBackColor = False
            '
            'btnTweakRight
            '
            Me.btnTweakRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnTweakRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnTweakRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnTweakRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnTweakRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnTweakRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTweakRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTweakRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnTweakRight.Interval = 100
            Me.btnTweakRight.Location = New System.Drawing.Point(179, 390)
            Me.btnTweakRight.Name = "btnTweakRight"
            Me.btnTweakRight.Size = New System.Drawing.Size(22, 22)
            Me.btnTweakRight.TabIndex = 4
            Me.btnTweakRight.Text = ">"
            Me.btnTweakRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTweakRight.UseVisualStyleBackColor = False
            '
            'btnTweakDown
            '
            Me.btnTweakDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnTweakDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnTweakDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnTweakDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnTweakDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnTweakDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTweakDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTweakDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnTweakDown.Interval = 100
            Me.btnTweakDown.Location = New System.Drawing.Point(156, 414)
            Me.btnTweakDown.Name = "btnTweakDown"
            Me.btnTweakDown.Size = New System.Drawing.Size(22, 22)
            Me.btnTweakDown.TabIndex = 4
            Me.btnTweakDown.Text = "v"
            Me.btnTweakDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTweakDown.UseVisualStyleBackColor = False
            '
            'chkbFine
            '
            Me.chkbFine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chkbFine.BackColor = System.Drawing.Color.Transparent
            Me.chkbFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbFine.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbFine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbFine.Location = New System.Drawing.Point(143, 502)
            Me.chkbFine.Name = "chkbFine"
            Me.chkbFine.Size = New System.Drawing.Size(58, 18)
            Me.chkbFine.TabIndex = 17
            Me.chkbFine.Text = "Fine"
            Me.chkbFine.UseVisualStyleBackColor = False
            Me.chkbFine.Visible = False
            '
            'pnlPalette
            '
            Me.pnlPalette.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlPalette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlPalette.Controls.Add(Me.Label5)
            Me.pnlPalette.Controls.Add(Me.tbHelp)
            Me.pnlPalette.Controls.Add(Me.tabctrlPalette)
            Me.pnlPalette.Location = New System.Drawing.Point(720, 9)
            Me.pnlPalette.Name = "pnlPalette"
            Me.pnlPalette.Size = New System.Drawing.Size(280, 557)
            Me.pnlPalette.TabIndex = 13
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(6, 378)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(265, 19)
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "Help Info"
            '
            'tbHelp
            '
            Me.tbHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tbHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbHelp.Location = New System.Drawing.Point(6, 403)
            Me.tbHelp.Multiline = True
            Me.tbHelp.Name = "tbHelp"
            Me.tbHelp.Size = New System.Drawing.Size(265, 149)
            Me.tbHelp.TabIndex = 13
            '
            'tabctrlPalette
            '
            Me.tabctrlPalette.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tabctrlPalette.Controls.Add(Me.TabPage1)
            Me.tabctrlPalette.Controls.Add(Me.tabpagUserPalette)
            Me.tabctrlPalette.Enabled = False
            Me.tabctrlPalette.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabctrlPalette.Location = New System.Drawing.Point(6, 9)
            Me.tabctrlPalette.Name = "tabctrlPalette"
            Me.tabctrlPalette.SelectedIndex = 0
            Me.tabctrlPalette.Size = New System.Drawing.Size(265, 362)
            Me.tabctrlPalette.TabIndex = 12
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New System.Drawing.Size(257, 336)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Standard"
            '
            'btnPalWaypoint
            '
            Me.btnPalWaypoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalWaypoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalWaypoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalWaypoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalWaypoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalWaypoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalWaypoint.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalWaypoint.Location = New System.Drawing.Point(195, 9)
            Me.btnPalWaypoint.Name = "btnPalWaypoint"
            Me.btnPalWaypoint.Size = New System.Drawing.Size(22, 26)
            Me.btnPalWaypoint.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalWaypoint, "Waypoints")
            Me.btnPalWaypoint.UseVisualStyleBackColor = False
            '
            'btnPalSound
            '
            Me.btnPalSound.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalSound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalSound.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalSound.Location = New System.Drawing.Point(141, 9)
            Me.btnPalSound.Name = "btnPalSound"
            Me.btnPalSound.Size = New System.Drawing.Size(22, 26)
            Me.btnPalSound.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalSound, "Sounds")
            Me.btnPalSound.UseVisualStyleBackColor = False
            '
            'btnPalTrigger
            '
            Me.btnPalTrigger.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalTrigger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalTrigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalTrigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalTrigger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalTrigger.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalTrigger.Location = New System.Drawing.Point(168, 9)
            Me.btnPalTrigger.Name = "btnPalTrigger"
            Me.btnPalTrigger.Size = New System.Drawing.Size(22, 26)
            Me.btnPalTrigger.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalTrigger, "Triggers")
            Me.btnPalTrigger.UseVisualStyleBackColor = False
            '
            'btnPalDoor
            '
            Me.btnPalDoor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalDoor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalDoor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalDoor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalDoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalDoor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalDoor.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalDoor.Location = New System.Drawing.Point(34, 9)
            Me.btnPalDoor.Name = "btnPalDoor"
            Me.btnPalDoor.Size = New System.Drawing.Size(22, 26)
            Me.btnPalDoor.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalDoor, "Doors")
            Me.btnPalDoor.UseVisualStyleBackColor = False
            '
            'btnPalEncounter
            '
            Me.btnPalEncounter.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalEncounter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalEncounter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalEncounter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalEncounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalEncounter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalEncounter.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalEncounter.Location = New System.Drawing.Point(61, 9)
            Me.btnPalEncounter.Name = "btnPalEncounter"
            Me.btnPalEncounter.Size = New System.Drawing.Size(22, 26)
            Me.btnPalEncounter.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalEncounter, "Encounters")
            Me.btnPalEncounter.UseVisualStyleBackColor = False
            '
            'btnPalCreature
            '
            Me.btnPalCreature.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalCreature.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalCreature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalCreature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalCreature.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalCreature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalCreature.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalCreature.Location = New System.Drawing.Point(7, 9)
            Me.btnPalCreature.Name = "btnPalCreature"
            Me.btnPalCreature.Size = New System.Drawing.Size(22, 26)
            Me.btnPalCreature.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalCreature, "Creatures")
            Me.btnPalCreature.UseVisualStyleBackColor = False
            '
            'btnPalPlaceable
            '
            Me.btnPalPlaceable.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalPlaceable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalPlaceable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalPlaceable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalPlaceable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalPlaceable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalPlaceable.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalPlaceable.Location = New System.Drawing.Point(115, 9)
            Me.btnPalPlaceable.Name = "btnPalPlaceable"
            Me.btnPalPlaceable.Size = New System.Drawing.Size(22, 26)
            Me.btnPalPlaceable.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalPlaceable, "Placeables")
            Me.btnPalPlaceable.UseVisualStyleBackColor = False
            '
            'btnPalMerchant
            '
            Me.btnPalMerchant.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalMerchant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalMerchant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalMerchant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalMerchant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalMerchant.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalMerchant.Location = New System.Drawing.Point(88, 9)
            Me.btnPalMerchant.Name = "btnPalMerchant"
            Me.btnPalMerchant.Size = New System.Drawing.Size(22, 26)
            Me.btnPalMerchant.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalMerchant, "Merchants")
            Me.btnPalMerchant.UseVisualStyleBackColor = False
            '
            'tvPalette
            '
            Me.tvPalette.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tvPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tvPalette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tvPalette.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tvPalette.HideSelection = False
            Me.tvPalette.LineColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tvPalette.Location = New System.Drawing.Point(8, 41)
            Me.tvPalette.Name = "tvPalette"
            Me.tvPalette.Size = New System.Drawing.Size(237, 256)
            Me.tvPalette.TabIndex = 9
            '
            'chkbShowResRefs
            '
            Me.chkbShowResRefs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkbShowResRefs.BackColor = System.Drawing.Color.Transparent
            Me.chkbShowResRefs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbShowResRefs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbShowResRefs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbShowResRefs.Location = New System.Drawing.Point(147, 300)
            Me.chkbShowResRefs.Name = "chkbShowResRefs"
            Me.chkbShowResRefs.Size = New System.Drawing.Size(98, 28)
            Me.chkbShowResRefs.TabIndex = 11
            Me.chkbShowResRefs.Text = "Show ResRefs"
            Me.chkbShowResRefs.UseVisualStyleBackColor = False
            '
            'chkbShowNames
            '
            Me.chkbShowNames.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkbShowNames.BackColor = System.Drawing.Color.Transparent
            Me.chkbShowNames.Checked = True
            Me.chkbShowNames.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbShowNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbShowNames.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbShowNames.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.chkbShowNames.Location = New System.Drawing.Point(11, 300)
            Me.chkbShowNames.Name = "chkbShowNames"
            Me.chkbShowNames.Size = New System.Drawing.Size(96, 28)
            Me.chkbShowNames.TabIndex = 11
            Me.chkbShowNames.Text = "Show Names"
            Me.chkbShowNames.UseVisualStyleBackColor = False
            '
            'btnPalItem
            '
            Me.btnPalItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPalItem.Enabled = False
            Me.btnPalItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPalItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPalItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPalItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPalItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPalItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.btnPalItem.Location = New System.Drawing.Point(223, 9)
            Me.btnPalItem.Name = "btnPalItem"
            Me.btnPalItem.Size = New System.Drawing.Size(22, 26)
            Me.btnPalItem.TabIndex = 10
            Me.ToolTip1.SetToolTip(Me.btnPalItem, "Items")
            Me.btnPalItem.UseVisualStyleBackColor = False
            Me.btnPalItem.Visible = False
            '
            'tabpagUserPalette
            '
            Me.tabpagUserPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.tabpagUserPalette.Controls.Add(Me.tvUserPalette)
            Me.tabpagUserPalette.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagUserPalette.Location = New System.Drawing.Point(4, 22)
            Me.tabpagUserPalette.Name = "tabpagUserPalette"
            Me.tabpagUserPalette.Size = New System.Drawing.Size(254, 336)
            Me.tabpagUserPalette.TabIndex = 1
            Me.tabpagUserPalette.Text = "User"
            '
            'tvUserPalette
            '
            Me.tvUserPalette.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tvUserPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tvUserPalette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tvUserPalette.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tvUserPalette.HideSelection = False
            Me.tvUserPalette.LineColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.tvUserPalette.Location = New System.Drawing.Point(8, 18)
            Me.tvUserPalette.Name = "tvUserPalette"
            TreeNode1.Name = ""
            TreeNode1.Text = "Creatures"
            TreeNode2.Name = ""
            TreeNode2.Text = "Doors"
            TreeNode3.Name = ""
            TreeNode3.Text = "Encounters"
            TreeNode4.Name = ""
            TreeNode4.Text = "Stores"
            TreeNode5.Name = ""
            TreeNode5.Text = "Placeables"
            TreeNode6.Name = ""
            TreeNode6.Text = "Sounds"
            TreeNode7.Name = ""
            TreeNode7.Text = "Triggers"
            Me.tvUserPalette.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
            Me.tvUserPalette.Size = New System.Drawing.Size(200, 297)
            Me.tvUserPalette.TabIndex = 9
            '
            'btnTest
            '
            Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTest.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnTest.Location = New System.Drawing.Point(745, 618)
            Me.btnTest.Name = "btnTest"
            Me.btnTest.Size = New System.Drawing.Size(75, 27)
            Me.btnTest.TabIndex = 4
            Me.btnTest.Text = "Test"
            Me.btnTest.UseVisualStyleBackColor = False
            Me.btnTest.Visible = False
            '
            'Panel1
            '
            Me.Panel1.AllowDrop = True
            Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel1.AutoScroll = True
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.pbox)
            Me.Panel1.Enabled = False
            Me.Panel1.Location = New System.Drawing.Point(217, 9)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(497, 557)
            Me.Panel1.TabIndex = 5
            '
            'pbox
            '
            Me.pbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbox.Location = New System.Drawing.Point(0, 0)
            Me.pbox.Name = "pbox"
            Me.pbox.Size = New System.Drawing.Size(96, 92)
            Me.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbox.TabIndex = 0
            Me.pbox.TabStop = False
            Me.pbox.Visible = False
            '
            'btnClean
            '
            Me.btnClean.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnClean.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClean.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnClean.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnClean.Location = New System.Drawing.Point(826, 618)
            Me.btnClean.Name = "btnClean"
            Me.btnClean.Size = New System.Drawing.Size(75, 27)
            Me.btnClean.TabIndex = 4
            Me.btnClean.Text = "Clean"
            Me.btnClean.UseVisualStyleBackColor = False
            Me.btnClean.Visible = False
            '
            'tbMouseY
            '
            Me.tbMouseY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tbMouseY.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMouseY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMouseY.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMouseY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMouseY.Location = New System.Drawing.Point(86, 623)
            Me.tbMouseY.Name = "tbMouseY"
            Me.tbMouseY.Size = New System.Drawing.Size(64, 20)
            Me.tbMouseY.TabIndex = 1
            Me.tbMouseY.Visible = False
            '
            'btnAssignPt2
            '
            Me.btnAssignPt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAssignPt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAssignPt2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAssignPt2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAssignPt2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAssignPt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAssignPt2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAssignPt2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnAssignPt2.Location = New System.Drawing.Point(198, 618)
            Me.btnAssignPt2.Name = "btnAssignPt2"
            Me.btnAssignPt2.Size = New System.Drawing.Size(32, 32)
            Me.btnAssignPt2.TabIndex = 3
            Me.btnAssignPt2.Text = "2"
            Me.btnAssignPt2.UseVisualStyleBackColor = False
            Me.btnAssignPt2.Visible = False
            '
            'tb3dsMaxPt1X
            '
            Me.tb3dsMaxPt1X.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tb3dsMaxPt1X.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tb3dsMaxPt1X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tb3dsMaxPt1X.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tb3dsMaxPt1X.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tb3dsMaxPt1X.Location = New System.Drawing.Point(307, 623)
            Me.tb3dsMaxPt1X.Name = "tb3dsMaxPt1X"
            Me.tb3dsMaxPt1X.Size = New System.Drawing.Size(64, 20)
            Me.tb3dsMaxPt1X.TabIndex = 4
            Me.tb3dsMaxPt1X.Text = "110.516"
            Me.tb3dsMaxPt1X.Visible = False
            '
            'tb3dsMaxPt1Y
            '
            Me.tb3dsMaxPt1Y.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tb3dsMaxPt1Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tb3dsMaxPt1Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tb3dsMaxPt1Y.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tb3dsMaxPt1Y.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tb3dsMaxPt1Y.Location = New System.Drawing.Point(377, 623)
            Me.tb3dsMaxPt1Y.Name = "tb3dsMaxPt1Y"
            Me.tb3dsMaxPt1Y.Size = New System.Drawing.Size(64, 20)
            Me.tb3dsMaxPt1Y.TabIndex = 5
            Me.tb3dsMaxPt1Y.Text = "133.604"
            Me.tb3dsMaxPt1Y.Visible = False
            '
            'tb3dsMaxPt2Y
            '
            Me.tb3dsMaxPt2Y.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tb3dsMaxPt2Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tb3dsMaxPt2Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tb3dsMaxPt2Y.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tb3dsMaxPt2Y.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tb3dsMaxPt2Y.Location = New System.Drawing.Point(517, 623)
            Me.tb3dsMaxPt2Y.Name = "tb3dsMaxPt2Y"
            Me.tb3dsMaxPt2Y.Size = New System.Drawing.Size(64, 20)
            Me.tb3dsMaxPt2Y.TabIndex = 7
            Me.tb3dsMaxPt2Y.Text = "78.001"
            Me.tb3dsMaxPt2Y.Visible = False
            '
            'tb3dsMaxPt2X
            '
            Me.tb3dsMaxPt2X.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tb3dsMaxPt2X.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tb3dsMaxPt2X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tb3dsMaxPt2X.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tb3dsMaxPt2X.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tb3dsMaxPt2X.Location = New System.Drawing.Point(447, 623)
            Me.tb3dsMaxPt2X.Name = "tb3dsMaxPt2X"
            Me.tb3dsMaxPt2X.Size = New System.Drawing.Size(64, 20)
            Me.tb3dsMaxPt2X.TabIndex = 6
            Me.tb3dsMaxPt2X.Text = "105.987"
            Me.tb3dsMaxPt2X.Visible = False
            '
            'btnCalcCalibrationVals
            '
            Me.btnCalcCalibrationVals.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnCalcCalibrationVals.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCalcCalibrationVals.Enabled = False
            Me.btnCalcCalibrationVals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCalcCalibrationVals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCalcCalibrationVals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCalcCalibrationVals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCalcCalibrationVals.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCalcCalibrationVals.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCalcCalibrationVals.Location = New System.Drawing.Point(236, 618)
            Me.btnCalcCalibrationVals.Name = "btnCalcCalibrationVals"
            Me.btnCalcCalibrationVals.Size = New System.Drawing.Size(32, 32)
            Me.btnCalcCalibrationVals.TabIndex = 8
            Me.btnCalcCalibrationVals.Text = "C"
            Me.btnCalcCalibrationVals.UseVisualStyleBackColor = False
            Me.btnCalcCalibrationVals.Visible = False
            '
            'btnCalToolsToggle
            '
            Me.btnCalToolsToggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCalToolsToggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnCalToolsToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnCalToolsToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnCalToolsToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnCalToolsToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCalToolsToggle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnCalToolsToggle.Location = New System.Drawing.Point(752, 645)
            Me.btnCalToolsToggle.Name = "btnCalToolsToggle"
            Me.btnCalToolsToggle.Size = New System.Drawing.Size(8, 9)
            Me.btnCalToolsToggle.TabIndex = 8
            Me.btnCalToolsToggle.TabStop = False
            Me.btnCalToolsToggle.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(998, 74)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 71)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(998, 3)
            Me.lblSeparatorTop.TabIndex = 2
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 44)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(962, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Inspect, edit, and manage module maps, palettes, scripts, dialogs, and placed mod" &
    "ule elements."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 4)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(964, 39)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Module Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tvModuleContextMenuItem
            '
            Me.tvModuleContextMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmiTvModuleItemDelete, Me.cmiTvModuleItemEdit, Me.cmiTvModuleItemProperties})
            '
            'cmiTvModuleItemDelete
            '
            Me.cmiTvModuleItemDelete.Index = 0
            Me.cmiTvModuleItemDelete.Text = "Delete..."
            '
            'cmiTvModuleItemEdit
            '
            Me.cmiTvModuleItemEdit.Index = 1
            Me.cmiTvModuleItemEdit.Text = "Edit GFF File..."
            '
            'cmiTvModuleItemProperties
            '
            Me.cmiTvModuleItemProperties.Index = 2
            Me.cmiTvModuleItemProperties.Text = "Properties in Module..."
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.mnuView, Me.MenuItem4})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miOpenProject, Me.miSave, Me.MenuItem3, Me.miBuildModFile, Me.MenuItem7, Me.miExploreModuleFolder, Me.miCopyToOverride, Me.miRemoveFromOverride, Me.miCleanOverride, Me.MenuItem9, Me.miClose})
            Me.MenuItem1.Text = "&File"
            '
            'miOpenProject
            '
            Me.miOpenProject.Index = 0
            Me.miOpenProject.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenProject.Text = "&Open Module Project..."
            '
            'miSave
            '
            Me.miSave.Enabled = False
            Me.miSave.Index = 1
            Me.miSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save changes"
            '
            'MenuItem3
            '
            Me.MenuItem3.Index = 2
            Me.MenuItem3.Text = "-"
            '
            'miBuildModFile
            '
            Me.miBuildModFile.Enabled = False
            Me.miBuildModFile.Index = 3
            Me.miBuildModFile.Shortcut = System.Windows.Forms.Shortcut.F5
            Me.miBuildModFile.Text = "&Build Mod file..."
            '
            'MenuItem7
            '
            Me.MenuItem7.Index = 4
            Me.MenuItem7.Text = "-"
            '
            'miExploreModuleFolder
            '
            Me.miExploreModuleFolder.Enabled = False
            Me.miExploreModuleFolder.Index = 5
            Me.miExploreModuleFolder.Text = "Explore &Module folder"
            '
            'miCopyToOverride
            '
            Me.miCopyToOverride.Index = 6
            Me.miCopyToOverride.Text = "Copy Project to Override folder"
            Me.miCopyToOverride.Visible = False
            '
            'miRemoveFromOverride
            '
            Me.miRemoveFromOverride.Index = 7
            Me.miRemoveFromOverride.Text = "Remove Project from Override folder"
            Me.miRemoveFromOverride.Visible = False
            '
            'miCleanOverride
            '
            Me.miCleanOverride.Index = 8
            Me.miCleanOverride.Text = "Clean Override folder"
            Me.miCleanOverride.Visible = False
            '
            'MenuItem9
            '
            Me.MenuItem9.Index = 9
            Me.MenuItem9.Text = "-"
            '
            'miClose
            '
            Me.miClose.Index = 10
            Me.miClose.Text = "&Close"
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miModuleProperties})
            Me.MenuItem2.Text = "&Edit"
            '
            'miModuleProperties
            '
            Me.miModuleProperties.Enabled = False
            Me.miModuleProperties.Index = 0
            Me.miModuleProperties.Shortcut = System.Windows.Forms.Shortcut.CtrlM
            Me.miModuleProperties.Text = "Module &Properties..."
            '
            'mnuView
            '
            Me.mnuView.Index = 2
            Me.mnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miShowHideModuleElements, Me.miShowHidePalette, Me.miShowItemLabels, Me.MenuItem6, Me.miUseSmallMap, Me.miUseLargeMap, Me.miUseAltSmallMap, Me.MenuItem11, Me.miShowModuleEntryPoint, Me.miShowModulePaths, Me.miFont})
            Me.mnuView.Text = "&View"
            '
            'miShowHideModuleElements
            '
            Me.miShowHideModuleElements.Checked = True
            Me.miShowHideModuleElements.Enabled = False
            Me.miShowHideModuleElements.Index = 0
            Me.miShowHideModuleElements.Shortcut = System.Windows.Forms.Shortcut.F1
            Me.miShowHideModuleElements.Text = "&Module Elements"
            '
            'miShowHidePalette
            '
            Me.miShowHidePalette.Checked = True
            Me.miShowHidePalette.Enabled = False
            Me.miShowHidePalette.Index = 1
            Me.miShowHidePalette.Shortcut = System.Windows.Forms.Shortcut.F2
            Me.miShowHidePalette.Text = "&Palette"
            '
            'miShowItemLabels
            '
            Me.miShowItemLabels.Enabled = False
            Me.miShowItemLabels.Index = 2
            Me.miShowItemLabels.Shortcut = System.Windows.Forms.Shortcut.F4
            Me.miShowItemLabels.Text = "&Item Labels"
            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 3
            Me.MenuItem6.Text = "-"
            '
            'miUseSmallMap
            '
            Me.miUseSmallMap.Enabled = False
            Me.miUseSmallMap.Index = 4
            Me.miUseSmallMap.Text = "Use &small map backgound"
            '
            'miUseLargeMap
            '
            Me.miUseLargeMap.Enabled = False
            Me.miUseLargeMap.Index = 5
            Me.miUseLargeMap.Text = "Use &large map backgound"
            '
            'miUseAltSmallMap
            '
            Me.miUseAltSmallMap.Enabled = False
            Me.miUseAltSmallMap.Index = 6
            Me.miUseAltSmallMap.Text = "Use alternate map bkgnd"
            '
            'MenuItem11
            '
            Me.MenuItem11.Index = 7
            Me.MenuItem11.Text = "-"
            '
            'miShowModuleEntryPoint
            '
            Me.miShowModuleEntryPoint.Enabled = False
            Me.miShowModuleEntryPoint.Index = 8
            Me.miShowModuleEntryPoint.Text = "Show Module Entry localPoint"
            '
            'miShowModulePaths
            '
            Me.miShowModulePaths.Enabled = False
            Me.miShowModulePaths.Index = 9
            Me.miShowModulePaths.Text = "&Show Module Paths"
            '
            'miFont
            '
            Me.miFont.Index = 10
            Me.miFont.Text = "Label Font..."
            '
            'MenuItem4
            '
            Me.MenuItem4.Index = 3
            Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miShowGitDump, Me.miShowAreDump, Me.miShowIfoDump, Me.MenuItem5, Me.miOptions})
            Me.MenuItem4.Text = "&Tools"
            '
            'miShowGitDump
            '
            Me.miShowGitDump.Enabled = False
            Me.miShowGitDump.Index = 0
            Me.miShowGitDump.Text = "Show GIT dump"
            '
            'miShowAreDump
            '
            Me.miShowAreDump.Enabled = False
            Me.miShowAreDump.Index = 1
            Me.miShowAreDump.Text = "Show ARE dump"
            '
            'miShowIfoDump
            '
            Me.miShowIfoDump.Enabled = False
            Me.miShowIfoDump.Index = 2
            Me.miShowIfoDump.Text = "Show IFO dump"
            '
            'MenuItem5
            '
            Me.MenuItem5.Index = 3
            Me.MenuItem5.Text = "-"
            '
            'miOptions
            '
            Me.miOptions.Enabled = False
            Me.miOptions.Index = 4
            Me.miOptions.Text = "&Options..."
            '
            'cmPbox
            '
            Me.cmPbox.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmiCreateCameraHere, Me.cmiSetModuleStartPoint, Me.MenuItem13, Me.cmiModuleProperties})
            '
            'cmiCreateCameraHere
            '
            Me.cmiCreateCameraHere.Index = 0
            Me.cmiCreateCameraHere.Text = "Create Camera here"
            '
            'cmiSetModuleStartPoint
            '
            Me.cmiSetModuleStartPoint.Index = 1
            Me.cmiSetModuleStartPoint.Text = "Set as Module starting localPoint"
            '
            'MenuItem13
            '
            Me.MenuItem13.Index = 2
            Me.MenuItem13.Text = "-"
            '
            'cmiModuleProperties
            '
            Me.cmiModuleProperties.Index = 3
            Me.cmiModuleProperties.Text = "Module Properties..."
            '
            'cmMapSurfaceItems
            '
            Me.cmMapSurfaceItems.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmiDelete, Me.cmiEditGFFFile, Me.cmiProperties, Me.cmiAddNewSpawnPoint})
            '
            'cmiDelete
            '
            Me.cmiDelete.Index = 0
            Me.cmiDelete.Text = "Delete from Module..."
            '
            'cmiEditGFFFile
            '
            Me.cmiEditGFFFile.Index = 1
            Me.cmiEditGFFFile.Text = "Edit GFF File..."
            '
            'cmiProperties
            '
            Me.cmiProperties.Index = 2
            Me.cmiProperties.Text = "Properties in Module..."
            '
            'cmiAddNewSpawnPoint
            '
            Me.cmiAddNewSpawnPoint.Index = 3
            Me.cmiAddNewSpawnPoint.Text = "Add New SpawnPoint"
            '
            'frmModule_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1000, 673)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New System.Drawing.Size(576, 554)
            Me.Name = "frmModule_Editor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Module Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlBody.PerformLayout()
            CType(Me.sbarpnlLocX, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbarpnlLocY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbarpnlDesc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbarpnlAddlInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbarpnlStatus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlModElements.ResumeLayout(False)
            Me.pnlModElements.PerformLayout()
            Me.tabctrlModule.ResumeLayout(False)
            Me.tabpagModuleElements.ResumeLayout(False)
            Me.tabpagScripts.ResumeLayout(False)
            Me.tabpagDialogs.ResumeLayout(False)
            CType(Me.nudXmul, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudYmul, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudXoff, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudYoff, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlPalette.ResumeLayout(False)
            Me.pnlPalette.PerformLayout()
            Me.tabctrlPalette.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.tabpagUserPalette.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.pbox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace