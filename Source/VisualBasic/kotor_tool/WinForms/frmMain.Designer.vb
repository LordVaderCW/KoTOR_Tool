Option Strict Off
Option Explicit On

Namespace kotor_tool

    Partial Public Class frmMain
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmMain.Designer.vb
        '
        ' Restored / facelifted main form for the KoTOR Tool Restoration.
        '
        ' Original Tool:
        '   Fred Tetra's KotOR Tool
        '
        ' Restoration Project:
        '   KoTOR Tool Restoration Project
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original control names preserved where possible.
        '   - Legacy ToolBar/ToolBarButton system replaced with a modern
        '     themed Panel + Button toolbar for better dark-theme control.
        '   - Theme colours are applied at runtime from Themes\DarkSaber.ini.
        '   - Designer keeps fallback colours only for safe VS designer display.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents TreeView As Global.System.Windows.Forms.TreeView
        Friend WithEvents btnExtract As Global.System.Windows.Forms.Button
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents miHelp As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miTools As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miAbout As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenKey As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miExtract As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miBasicHelp As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenRIM As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miManagePaths As Global.System.Windows.Forms.MenuItem
        Friend WithEvents btnHexViewer As Global.System.Windows.Forms.Button
        Friend WithEvents miOptions As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpen2DAEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenTextEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenGFFFile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenERFBuilder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miViewGFFFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miRegisterSoftware As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvCMenu As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents cmiExtractForModuleEditing As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miConversationEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCleanWorkingDir As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miRefSearch As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miFile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miRecentFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenProjectManager As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCheckForUpdates As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miGlobalVariableEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenWorkingDir As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem8 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents Button4 As Global.System.Windows.Forms.Button
        Friend WithEvents miOpenDialogTlkViewer As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenPWKEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowSupportedModEditorMaps As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem7 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenMapsFolder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenModuleEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenHexViewer As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenSSFEditor As Global.System.Windows.Forms.MenuItem
        Friend WithEvents btnCreateMapInfoBFD As Global.System.Windows.Forms.Button
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents btnExtractForModuleEditing As Global.System.Windows.Forms.Button

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlMainArea As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlActionPanel As Global.System.Windows.Forms.Panel
        Friend WithEvents lblActionHeader As Global.System.Windows.Forms.Label
        Friend WithEvents lblMainSeparator As Global.System.Windows.Forms.Label

        Friend WithEvents pnlToolBar As Global.System.Windows.Forms.Panel
        Friend WithEvents btnTool2DA As Global.System.Windows.Forms.Button
        Friend WithEvents btnToolConversation As Global.System.Windows.Forms.Button
        Friend WithEvents btnToolText As Global.System.Windows.Forms.Button
        Friend WithEvents btnToolERF As Global.System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As Global.System.Windows.Forms.ToolTip

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlMainArea = New System.Windows.Forms.Panel()
            Me.TreeView = New System.Windows.Forms.TreeView()
            Me.pnlActionPanel = New System.Windows.Forms.Panel()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.btnCreateMapInfoBFD = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnHexViewer = New System.Windows.Forms.Button()
            Me.btnExtractForModuleEditing = New System.Windows.Forms.Button()
            Me.btnExtract = New System.Windows.Forms.Button()
            Me.lblActionHeader = New System.Windows.Forms.Label()
            Me.lblMainSeparator = New System.Windows.Forms.Label()
            Me.pnlToolBar = New System.Windows.Forms.Panel()
            Me.btnToolERF = New System.Windows.Forms.Button()
            Me.btnToolText = New System.Windows.Forms.Button()
            Me.btnToolConversation = New System.Windows.Forms.Button()
            Me.btnTool2DA = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.miFile = New System.Windows.Forms.MenuItem()
            Me.miManagePaths = New System.Windows.Forms.MenuItem()
            Me.miOpenGFFFile = New System.Windows.Forms.MenuItem()
            Me.miViewGFFFiles = New System.Windows.Forms.MenuItem()
            Me.miOpenKey = New System.Windows.Forms.MenuItem()
            Me.miOpenRIM = New System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New System.Windows.Forms.MenuItem()
            Me.miRecentFiles = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.miTools = New System.Windows.Forms.MenuItem()
            Me.miExtract = New System.Windows.Forms.MenuItem()
            Me.miOpenProjectManager = New System.Windows.Forms.MenuItem()
            Me.miOpen2DAEditor = New System.Windows.Forms.MenuItem()
            Me.miConversationEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenModuleEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenDialogTlkViewer = New System.Windows.Forms.MenuItem()
            Me.miGlobalVariableEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenTextEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenPWKEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenSSFEditor = New System.Windows.Forms.MenuItem()
            Me.miOpenERFBuilder = New System.Windows.Forms.MenuItem()
            Me.miOpenByteView = New System.Windows.Forms.MenuItem()
            Me.miOpenHexViewer = New System.Windows.Forms.MenuItem()
            Me.miRefSearch = New System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New System.Windows.Forms.MenuItem()
            Me.miCleanWorkingDir = New System.Windows.Forms.MenuItem()
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miOpenWorkingDir = New System.Windows.Forms.MenuItem()
            Me.MenuItem8 = New System.Windows.Forms.MenuItem()
            Me.miShowSupportedModEditorMaps = New System.Windows.Forms.MenuItem()
            Me.miOpenMapsFolder = New System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New System.Windows.Forms.MenuItem()
            Me.miOptions = New System.Windows.Forms.MenuItem()
            Me.miHelp = New System.Windows.Forms.MenuItem()
            Me.miBasicHelp = New System.Windows.Forms.MenuItem()
            Me.miCheckForUpdates = New System.Windows.Forms.MenuItem()
            Me.miRegisterSoftware = New System.Windows.Forms.MenuItem()
            Me.miAbout = New System.Windows.Forms.MenuItem()
            Me.miPlugins = New System.Windows.Forms.MenuItem()
            Me.miOpenPluginManager = New System.Windows.Forms.MenuItem()
            Me.tvCMenu = New System.Windows.Forms.ContextMenu()
            Me.cmiExtractForModuleEditing = New System.Windows.Forms.MenuItem()
            Me.miCustomise = New System.Windows.Forms.MenuItem()
            Me.miThemeEditor = New System.Windows.Forms.MenuItem()
            Me.pnlRoot.SuspendLayout()
            Me.pnlMainArea.SuspendLayout()
            Me.pnlActionPanel.SuspendLayout()
            Me.pnlToolBar.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlMainArea)
            Me.pnlRoot.Controls.Add(Me.lblMainSeparator)
            Me.pnlRoot.Controls.Add(Me.pnlToolBar)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlRoot.Size = New System.Drawing.Size(610, 500)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlMainArea
            '
            Me.pnlMainArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlMainArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlMainArea.Controls.Add(Me.TreeView)
            Me.pnlMainArea.Controls.Add(Me.pnlActionPanel)
            Me.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMainArea.Location = New System.Drawing.Point(10, 48)
            Me.pnlMainArea.Name = "pnlMainArea"
            Me.pnlMainArea.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlMainArea.Size = New System.Drawing.Size(590, 442)
            Me.pnlMainArea.TabIndex = 5
            '
            'TreeView
            '
            Me.TreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TreeView.HideSelection = False
            Me.TreeView.Location = New System.Drawing.Point(10, 10)
            Me.TreeView.Name = "TreeView"
            Me.TreeView.Size = New System.Drawing.Size(438, 420)
            Me.TreeView.TabIndex = 1
            '
            'pnlActionPanel
            '
            Me.pnlActionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlActionPanel.Controls.Add(Me.Button4)
            Me.pnlActionPanel.Controls.Add(Me.btnCreateMapInfoBFD)
            Me.pnlActionPanel.Controls.Add(Me.Button1)
            Me.pnlActionPanel.Controls.Add(Me.btnHexViewer)
            Me.pnlActionPanel.Controls.Add(Me.btnExtractForModuleEditing)
            Me.pnlActionPanel.Controls.Add(Me.btnExtract)
            Me.pnlActionPanel.Controls.Add(Me.lblActionHeader)
            Me.pnlActionPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlActionPanel.Location = New System.Drawing.Point(448, 10)
            Me.pnlActionPanel.Name = "pnlActionPanel"
            Me.pnlActionPanel.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlActionPanel.Size = New System.Drawing.Size(130, 420)
            Me.pnlActionPanel.TabIndex = 6
            '
            'Button4
            '
            Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Button4.Location = New System.Drawing.Point(10, 238)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(108, 24)
            Me.Button4.TabIndex = 7
            Me.Button4.Text = "Parse NWScript"
            Me.Button4.UseVisualStyleBackColor = False
            Me.Button4.Visible = False
            '
            'btnCreateMapInfoBFD
            '
            Me.btnCreateMapInfoBFD.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCreateMapInfoBFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCreateMapInfoBFD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnCreateMapInfoBFD.Location = New System.Drawing.Point(10, 298)
            Me.btnCreateMapInfoBFD.Name = "btnCreateMapInfoBFD"
            Me.btnCreateMapInfoBFD.Size = New System.Drawing.Size(108, 23)
            Me.btnCreateMapInfoBFD.TabIndex = 9
            Me.btnCreateMapInfoBFD.Text = "Create MapInfo"
            Me.btnCreateMapInfoBFD.UseVisualStyleBackColor = False
            Me.btnCreateMapInfoBFD.Visible = False
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Button1.Location = New System.Drawing.Point(10, 268)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(108, 24)
            Me.Button1.TabIndex = 8
            Me.Button1.Text = "Test Getktsi"
            Me.Button1.UseVisualStyleBackColor = False
            Me.Button1.Visible = False
            '
            'btnHexViewer
            '
            Me.btnHexViewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnHexViewer.Enabled = False
            Me.btnHexViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHexViewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnHexViewer.Location = New System.Drawing.Point(10, 178)
            Me.btnHexViewer.Name = "btnHexViewer"
            Me.btnHexViewer.Size = New System.Drawing.Size(108, 50)
            Me.btnHexViewer.TabIndex = 0
            Me.btnHexViewer.Text = "Hex Viewer"
            Me.btnHexViewer.UseVisualStyleBackColor = False
            '
            'btnExtractForModuleEditing
            '
            Me.btnExtractForModuleEditing.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnExtractForModuleEditing.Enabled = False
            Me.btnExtractForModuleEditing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExtractForModuleEditing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnExtractForModuleEditing.Location = New System.Drawing.Point(10, 106)
            Me.btnExtractForModuleEditing.Name = "btnExtractForModuleEditing"
            Me.btnExtractForModuleEditing.Size = New System.Drawing.Size(108, 64)
            Me.btnExtractForModuleEditing.TabIndex = 5
            Me.btnExtractForModuleEditing.Text = "Extract for Module Editing"
            Me.btnExtractForModuleEditing.UseVisualStyleBackColor = False
            '
            'btnExtract
            '
            Me.btnExtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnExtract.Enabled = False
            Me.btnExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExtract.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnExtract.Location = New System.Drawing.Point(10, 42)
            Me.btnExtract.Name = "btnExtract"
            Me.btnExtract.Size = New System.Drawing.Size(108, 56)
            Me.btnExtract.TabIndex = 1
            Me.btnExtract.Text = "Extract"
            Me.btnExtract.UseVisualStyleBackColor = False
            '
            'lblActionHeader
            '
            Me.lblActionHeader.BackColor = System.Drawing.Color.Transparent
            Me.lblActionHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblActionHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActionHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblActionHeader.Location = New System.Drawing.Point(10, 10)
            Me.lblActionHeader.Name = "lblActionHeader"
            Me.lblActionHeader.Size = New System.Drawing.Size(108, 22)
            Me.lblActionHeader.TabIndex = 6
            Me.lblActionHeader.Text = "RESOURCE TOOLS"
            Me.lblActionHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblMainSeparator
            '
            Me.lblMainSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblMainSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblMainSeparator.Location = New System.Drawing.Point(10, 46)
            Me.lblMainSeparator.Name = "lblMainSeparator"
            Me.lblMainSeparator.Size = New System.Drawing.Size(590, 2)
            Me.lblMainSeparator.TabIndex = 10
            '
            'pnlToolBar
            '
            Me.pnlToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlToolBar.Controls.Add(Me.btnToolERF)
            Me.pnlToolBar.Controls.Add(Me.btnToolText)
            Me.pnlToolBar.Controls.Add(Me.btnToolConversation)
            Me.pnlToolBar.Controls.Add(Me.btnTool2DA)
            Me.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlToolBar.Location = New System.Drawing.Point(10, 10)
            Me.pnlToolBar.Name = "pnlToolBar"
            Me.pnlToolBar.Size = New System.Drawing.Size(590, 36)
            Me.pnlToolBar.TabIndex = 4
            '
            'btnToolERF
            '
            Me.btnToolERF.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnToolERF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToolERF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnToolERF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToolERF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnToolERF.Location = New System.Drawing.Point(336, 2)
            Me.btnToolERF.Name = "btnToolERF"
            Me.btnToolERF.Size = New System.Drawing.Size(106, 30)
            Me.btnToolERF.TabIndex = 3
            Me.btnToolERF.Text = "ERF Builder"
            Me.btnToolERF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnToolERF, "Open the ERF/MOD Builder")
            Me.btnToolERF.UseVisualStyleBackColor = False
            '
            'btnToolText
            '
            Me.btnToolText.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnToolText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToolText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnToolText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToolText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnToolText.Location = New System.Drawing.Point(224, 2)
            Me.btnToolText.Name = "btnToolText"
            Me.btnToolText.Size = New System.Drawing.Size(106, 30)
            Me.btnToolText.TabIndex = 2
            Me.btnToolText.Text = "Text Editor"
            Me.btnToolText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnToolText, "Open the Text Editor")
            Me.btnToolText.UseVisualStyleBackColor = False
            '
            'btnToolConversation
            '
            Me.btnToolConversation.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnToolConversation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToolConversation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnToolConversation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToolConversation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnToolConversation.Location = New System.Drawing.Point(112, 2)
            Me.btnToolConversation.Name = "btnToolConversation"
            Me.btnToolConversation.Size = New System.Drawing.Size(106, 30)
            Me.btnToolConversation.TabIndex = 1
            Me.btnToolConversation.Text = "Dialog Editor"
            Me.btnToolConversation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnToolConversation, "Open the Conversation Editor")
            Me.btnToolConversation.UseVisualStyleBackColor = False
            '
            'btnTool2DA
            '
            Me.btnTool2DA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnTool2DA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTool2DA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTool2DA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnTool2DA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnTool2DA.Location = New System.Drawing.Point(0, 2)
            Me.btnTool2DA.Name = "btnTool2DA"
            Me.btnTool2DA.Size = New System.Drawing.Size(106, 30)
            Me.btnTool2DA.TabIndex = 0
            Me.btnTool2DA.Text = "2DA Editor"
            Me.btnTool2DA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnTool2DA, "Open the 2DA Editor")
            Me.btnTool2DA.UseVisualStyleBackColor = False
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miFile, Me.miTools, Me.miPlugins, Me.miHelp, Me.miCustomise})
            '
            'miFile
            '
            Me.miFile.Index = 0
            Me.miFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miManagePaths, Me.miOpenGFFFile, Me.miViewGFFFiles, Me.miOpenKey, Me.miOpenRIM, Me.MenuItem5, Me.miRecentFiles, Me.MenuItem6, Me.miQuit})
            Me.miFile.Text = "&File"
            '
            'miManagePaths
            '
            Me.miManagePaths.Index = 0
            Me.miManagePaths.Text = "&Manage Paths..."
            '
            'miOpenGFFFile
            '
            Me.miOpenGFFFile.Index = 1
            Me.miOpenGFFFile.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenGFFFile.Text = "Open &GFF Files..."
            '
            'miViewGFFFiles
            '
            Me.miViewGFFFiles.Index = 2
            Me.miViewGFFFiles.Text = "&View GFF Files as Text..."
            '
            'miOpenKey
            '
            Me.miOpenKey.Index = 3
            Me.miOpenKey.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenKey.Text = "&Open Key file..."
            Me.miOpenKey.Visible = False
            '
            'miOpenRIM
            '
            Me.miOpenRIM.Index = 4
            Me.miOpenRIM.Shortcut = System.Windows.Forms.Shortcut.CtrlR
            Me.miOpenRIM.Text = "Open RIM file..."
            Me.miOpenRIM.Visible = False
            '
            'MenuItem5
            '
            Me.MenuItem5.Index = 5
            Me.MenuItem5.Text = "-"
            '
            'miRecentFiles
            '
            Me.miRecentFiles.Index = 6
            Me.miRecentFiles.Text = "Recent &Files"
            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 7
            Me.MenuItem6.Text = "-"
            '
            'miQuit
            '
            Me.miQuit.Index = 8
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'miTools
            '
            Me.miTools.Index = 1
            Me.miTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miExtract, Me.miOpenProjectManager, Me.miOpen2DAEditor, Me.miConversationEditor, Me.miOpenModuleEditor, Me.miOpenDialogTlkViewer, Me.miGlobalVariableEditor, Me.miOpenTextEditor, Me.miOpenPWKEditor, Me.miOpenSSFEditor, Me.miOpenERFBuilder, Me.miOpenByteView, Me.miOpenHexViewer, Me.miRefSearch, Me.MenuItem4, Me.miCleanWorkingDir, Me.MenuItem1, Me.miOpenWorkingDir, Me.MenuItem8, Me.miShowSupportedModEditorMaps, Me.miOpenMapsFolder, Me.MenuItem7, Me.miOptions})
            Me.miTools.Text = "&Tools"
            '
            'miExtract
            '
            Me.miExtract.Enabled = False
            Me.miExtract.Index = 0
            Me.miExtract.Text = "(nothing selected)"
            Me.miExtract.Visible = False
            '
            'miOpenProjectManager
            '
            Me.miOpenProjectManager.Index = 1
            Me.miOpenProjectManager.Shortcut = System.Windows.Forms.Shortcut.Ctrl1
            Me.miOpenProjectManager.Text = "Open Project Manager"
            '
            'miOpen2DAEditor
            '
            Me.miOpen2DAEditor.Index = 2
            Me.miOpen2DAEditor.Shortcut = System.Windows.Forms.Shortcut.Ctrl2
            Me.miOpen2DAEditor.Text = "Open &2DA file editor"
            '
            'miConversationEditor
            '
            Me.miConversationEditor.Index = 3
            Me.miConversationEditor.Shortcut = System.Windows.Forms.Shortcut.Ctrl3
            Me.miConversationEditor.Text = "Open &Conversation editor"
            '
            'miOpenModuleEditor
            '
            Me.miOpenModuleEditor.Index = 4
            Me.miOpenModuleEditor.Shortcut = System.Windows.Forms.Shortcut.F1
            Me.miOpenModuleEditor.Text = "Open &Module editor"
            '
            'miOpenDialogTlkViewer
            '
            Me.miOpenDialogTlkViewer.Index = 5
            Me.miOpenDialogTlkViewer.Text = "Open &Dialog.Tlk editor"
            '
            'miGlobalVariableEditor
            '
            Me.miGlobalVariableEditor.Index = 6
            Me.miGlobalVariableEditor.Text = "Open &Global Variable editor"
            '
            'miOpenTextEditor
            '
            Me.miOpenTextEditor.Index = 7
            Me.miOpenTextEditor.Text = "Open &Text editor"
            '
            'miOpenPWKEditor
            '
            Me.miOpenPWKEditor.Index = 8
            Me.miOpenPWKEditor.Text = "Open &PWK/DWK editor"
            '
            'miOpenSSFEditor
            '
            Me.miOpenSSFEditor.Index = 9
            Me.miOpenSSFEditor.Text = "Open &SSF editor"
            '
            'miOpenERFBuilder
            '
            Me.miOpenERFBuilder.Index = 10
            Me.miOpenERFBuilder.Text = "Open &ERF/MOD builder"
            '
            'miOpenByteView
            '
            Me.miOpenByteView.Index = 11
            Me.miOpenByteView.Text = "Open &Hex Viewer"
            '
            'miOpenHexViewer
            '
            Me.miOpenHexViewer.Index = 12
            Me.miOpenHexViewer.Text = "-"
            '
            'miRefSearch
            '
            Me.miRefSearch.Index = 13
            Me.miRefSearch.Shortcut = System.Windows.Forms.Shortcut.CtrlF
            Me.miRefSearch.Text = "Search for text in BIFs/RIMs"
            '
            'MenuItem4
            '
            Me.MenuItem4.Index = 14
            Me.MenuItem4.Text = "-"
            '
            'miCleanWorkingDir
            '
            Me.miCleanWorkingDir.Index = 15
            Me.miCleanWorkingDir.Text = "Clean Working Directory"
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 16
            Me.MenuItem1.Text = "-"
            '
            'miOpenWorkingDir
            '
            Me.miOpenWorkingDir.Index = 17
            Me.miOpenWorkingDir.Text = "Open Working Directory"
            '
            'MenuItem8
            '
            Me.MenuItem8.Index = 18
            Me.MenuItem8.Text = "-"
            '
            'miShowSupportedModEditorMaps
            '
            Me.miShowSupportedModEditorMaps.Index = 19
            Me.miShowSupportedModEditorMaps.Text = "Show Maps supported by Module editor"
            '
            'miOpenMapsFolder
            '
            Me.miOpenMapsFolder.Index = 20
            Me.miOpenMapsFolder.Text = "Explore Maps folder"
            '
            'MenuItem7
            '
            Me.MenuItem7.Index = 21
            Me.MenuItem7.Text = "-"
            '
            'miOptions
            '
            Me.miOptions.Index = 22
            Me.miOptions.Text = "&Options..."
            '
            'miHelp
            '
            Me.miHelp.Index = 3
            Me.miHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miBasicHelp, Me.miCheckForUpdates, Me.miRegisterSoftware, Me.miAbout})
            Me.miHelp.Text = "&Help"
            '
            'miBasicHelp
            '
            Me.miBasicHelp.Index = 0
            Me.miBasicHelp.Text = "Basic &Instructions..."
            '
            'miCheckForUpdates
            '
            Me.miCheckForUpdates.Index = 1
            Me.miCheckForUpdates.Text = "Check for program updates"
            '
            'miRegisterSoftware
            '
            Me.miRegisterSoftware.Index = 2
            Me.miRegisterSoftware.Text = "&Register..."
            Me.miRegisterSoftware.Visible = False
            '
            'miAbout
            '
            Me.miAbout.Index = 3
            Me.miAbout.Text = "&About..."
            '
            'miPlugins
            '
            Me.miPlugins.Index = 2
            Me.miPlugins.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miOpenPluginManager})
            Me.miPlugins.Text = "&Plugins"
            '
            'miOpenPluginManager
            '
            Me.miOpenPluginManager.Index = 0
            Me.miOpenPluginManager.Text = "Open &Manager"
            '
            'tvCMenu
            '
            Me.tvCMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmiExtractForModuleEditing})
            '
            'cmiExtractForModuleEditing
            '
            Me.cmiExtractForModuleEditing.Index = 0
            Me.cmiExtractForModuleEditing.Text = "Extract for Module editing..."
            '
            'miCustomise
            '
            Me.miCustomise.Index = 4
            Me.miCustomise.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miThemeEditor})
            Me.miCustomise.Text = "&Customize"
            '
            'miThemeEditor
            '
            Me.miThemeEditor.Index = 0
            Me.miThemeEditor.Text = "Theme Editor"
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(610, 500)
            Me.Controls.Add(Me.pnlRoot)
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New System.Drawing.Size(430, 380)
            Me.Name = "frmMain"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Kotor Tool"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlMainArea.ResumeLayout(False)
            Me.pnlActionPanel.ResumeLayout(False)
            Me.pnlToolBar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents miOpenByteView As System.Windows.Forms.MenuItem
        Friend WithEvents miPlugins As System.Windows.Forms.MenuItem
        Friend WithEvents miOpenPluginManager As System.Windows.Forms.MenuItem
        Friend WithEvents miCustomise As System.Windows.Forms.MenuItem
        Friend WithEvents miThemeEditor As System.Windows.Forms.MenuItem
    End Class

End Namespace