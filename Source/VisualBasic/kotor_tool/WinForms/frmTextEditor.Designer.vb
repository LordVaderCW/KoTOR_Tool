Option Strict Off
Option Explicit On

Imports mystuff.Controls

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmTextEditor
        Inherits Global.System.Windows.Forms.Form

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlEditorHost As Global.System.Windows.Forms.Panel
        Friend WithEvents tbGeneric As LinenumberTextBox
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miFind As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miFindAgain As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miUndo As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miRedo As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem3 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCut As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem7 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem9 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCopy As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miPaste As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSelectAll As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSaveAs As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpen As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miPrint As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miPageSetup As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miFont As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miWordWrap As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miPlaceablesList As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miEncountersList As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miWaypointsList As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSoundsList As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miTriggersList As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miDoorsList As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCameras As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCreatureList As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miMerchantList As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSave As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem8 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miScriptIsK1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miScriptIsK2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem12 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCompile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents lbFunctions As Global.System.Windows.Forms.ListBox
        Friend WithEvents tbFuncNameFilter As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbFuncDecl As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents pnlFunctions As Global.System.Windows.Forms.Panel
        Friend WithEvents lblMatches As Global.System.Windows.Forms.Label
        Friend WithEvents cmText As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents cmiShowDefinition As Global.System.Windows.Forms.MenuItem

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmTextEditor))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlEditorHost = New Global.System.Windows.Forms.Panel()
            Me.tbGeneric = New Global.mystuff.Controls.LinenumberTextBox()
            Me.pnlFunctions = New Global.System.Windows.Forms.Panel()
            Me.tbFuncDecl = New Global.System.Windows.Forms.TextBox()
            Me.tbFuncNameFilter = New Global.System.Windows.Forms.TextBox()
            Me.lbFunctions = New Global.System.Windows.Forms.ListBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.lblMatches = New Global.System.Windows.Forms.Label()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpen = New Global.System.Windows.Forms.MenuItem()
            Me.miSave = New Global.System.Windows.Forms.MenuItem()
            Me.miSaveAs = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New Global.System.Windows.Forms.MenuItem()
            Me.miPageSetup = New Global.System.Windows.Forms.MenuItem()
            Me.miPrint = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.miUndo = New Global.System.Windows.Forms.MenuItem()
            Me.miRedo = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New Global.System.Windows.Forms.MenuItem()
            Me.miCut = New Global.System.Windows.Forms.MenuItem()
            Me.miCopy = New Global.System.Windows.Forms.MenuItem()
            Me.miPaste = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem9 = New Global.System.Windows.Forms.MenuItem()
            Me.miSelectAll = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New Global.System.Windows.Forms.MenuItem()
            Me.miFind = New Global.System.Windows.Forms.MenuItem()
            Me.miFindAgain = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New Global.System.Windows.Forms.MenuItem()
            Me.miWordWrap = New Global.System.Windows.Forms.MenuItem()
            Me.miFont = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New Global.System.Windows.Forms.MenuItem()
            Me.miCameras = New Global.System.Windows.Forms.MenuItem()
            Me.miCreatureList = New Global.System.Windows.Forms.MenuItem()
            Me.miDoorsList = New Global.System.Windows.Forms.MenuItem()
            Me.miEncountersList = New Global.System.Windows.Forms.MenuItem()
            Me.miMerchantList = New Global.System.Windows.Forms.MenuItem()
            Me.miPlaceablesList = New Global.System.Windows.Forms.MenuItem()
            Me.miSoundsList = New Global.System.Windows.Forms.MenuItem()
            Me.miTriggersList = New Global.System.Windows.Forms.MenuItem()
            Me.miWaypointsList = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem8 = New Global.System.Windows.Forms.MenuItem()
            Me.miScriptIsK1 = New Global.System.Windows.Forms.MenuItem()
            Me.miScriptIsK2 = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem12 = New Global.System.Windows.Forms.MenuItem()
            Me.miCompile = New Global.System.Windows.Forms.MenuItem()
            Me.cmText = New Global.System.Windows.Forms.ContextMenu()
            Me.cmiShowDefinition = New Global.System.Windows.Forms.MenuItem()
            Me.pnlRoot.SuspendLayout()
            Me.pnlEditorHost.SuspendLayout()
            Me.pnlFunctions.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlEditorHost)
            Me.pnlRoot.Controls.Add(Me.pnlFunctions)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Padding = New Global.System.Windows.Forms.Padding(10, 10, 10, 10)
            Me.pnlRoot.Size = New Global.System.Drawing.Size(936, 601)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlEditorHost
            '
            Me.pnlEditorHost.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlEditorHost.Controls.Add(Me.tbGeneric)
            Me.pnlEditorHost.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlEditorHost.Location = New Global.System.Drawing.Point(10, 10)
            Me.pnlEditorHost.Name = "pnlEditorHost"
            Me.pnlEditorHost.Padding = New Global.System.Windows.Forms.Padding(8, 8, 8, 8)
            Me.pnlEditorHost.Size = New Global.System.Drawing.Size(916, 581)
            Me.pnlEditorHost.TabIndex = 0
            '
            'tbGeneric
            '
            Me.tbGeneric.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.tbGeneric.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbGeneric.ContextMenu = Me.cmText
            Me.tbGeneric.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.tbGeneric.Font = New Global.System.Drawing.Font("Consolas", 9.0!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbGeneric.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbGeneric.Location = New Global.System.Drawing.Point(8, 8)
            Me.tbGeneric.Name = "tbGeneric"
            Me.tbGeneric.ShowSelectionMargin = True
            Me.tbGeneric.Size = New Global.System.Drawing.Size(900, 565)
            Me.tbGeneric.TabIndex = 5
            Me.tbGeneric.Text = ""
            '
            'pnlFunctions
            '
            Me.pnlFunctions.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlFunctions.Controls.Add(Me.tbFuncDecl)
            Me.pnlFunctions.Controls.Add(Me.tbFuncNameFilter)
            Me.pnlFunctions.Controls.Add(Me.lbFunctions)
            Me.pnlFunctions.Controls.Add(Me.Label1)
            Me.pnlFunctions.Controls.Add(Me.lblMatches)
            Me.pnlFunctions.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFunctions.Location = New Global.System.Drawing.Point(10, 455)
            Me.pnlFunctions.Name = "pnlFunctions"
            Me.pnlFunctions.Padding = New Global.System.Windows.Forms.Padding(8, 8, 8, 8)
            Me.pnlFunctions.Size = New Global.System.Drawing.Size(916, 136)
            Me.pnlFunctions.TabIndex = 10
            Me.pnlFunctions.Visible = False
            '
            'tbFuncDecl
            '
            Me.tbFuncDecl.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                        Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbFuncDecl.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.tbFuncDecl.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFuncDecl.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbFuncDecl.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFuncDecl.Location = New Global.System.Drawing.Point(8, 8)
            Me.tbFuncDecl.Multiline = True
            Me.tbFuncDecl.Name = "tbFuncDecl"
            Me.tbFuncDecl.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbFuncDecl.Size = New Global.System.Drawing.Size(680, 120)
            Me.tbFuncDecl.TabIndex = 8
            Me.tbFuncDecl.Text = ""
            '
            'tbFuncNameFilter
            '
            Me.tbFuncNameFilter.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbFuncNameFilter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.tbFuncNameFilter.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFuncNameFilter.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbFuncNameFilter.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFuncNameFilter.Location = New Global.System.Drawing.Point(700, 24)
            Me.tbFuncNameFilter.Name = "tbFuncNameFilter"
            Me.tbFuncNameFilter.Size = New Global.System.Drawing.Size(208, 22)
            Me.tbFuncNameFilter.TabIndex = 7
            Me.tbFuncNameFilter.Text = ""
            '
            'lbFunctions
            '
            Me.lbFunctions.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lbFunctions.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.lbFunctions.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbFunctions.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbFunctions.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbFunctions.Location = New Global.System.Drawing.Point(700, 50)
            Me.lbFunctions.Name = "lbFunctions"
            Me.lbFunctions.Size = New Global.System.Drawing.Size(208, 67)
            Me.lbFunctions.TabIndex = 6
            '
            'Label1
            '
            Me.Label1.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(700, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Function filter"
            '
            'lblMatches
            '
            Me.lblMatches.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblMatches.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblMatches.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMatches.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblMatches.Location = New Global.System.Drawing.Point(824, 6)
            Me.lblMatches.Name = "lblMatches"
            Me.lblMatches.Size = New Global.System.Drawing.Size(84, 16)
            Me.lblMatches.TabIndex = 10
            Me.lblMatches.Text = "Matches: "
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem5, Me.MenuItem6, Me.MenuItem8})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miOpen, Me.miSave, Me.miSaveAs, Me.MenuItem4, Me.miPageSetup, Me.miPrint, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miOpen
            '
            Me.miOpen.Index = 0
            Me.miOpen.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpen.Text = "&Open..."
            '
            'miSave
            '
            Me.miSave.Index = 1
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            '
            'miSaveAs
            '
            Me.miSaveAs.Index = 2
            Me.miSaveAs.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlShiftS
            Me.miSaveAs.Text = "Save &As..."
            '
            'MenuItem4
            '
            Me.MenuItem4.Index = 3
            Me.MenuItem4.Text = "-"
            '
            'miPageSetup
            '
            Me.miPageSetup.Index = 4
            Me.miPageSetup.Text = "Page Set&up"
            '
            'miPrint
            '
            Me.miPrint.Index = 5
            Me.miPrint.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlP
            Me.miPrint.Text = "&Print"
            '
            'miQuit
            '
            Me.miQuit.Index = 6
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miUndo, Me.miRedo, Me.MenuItem3, Me.miCut, Me.miCopy, Me.miPaste, Me.MenuItem9, Me.miSelectAll, Me.MenuItem7, Me.miFind, Me.miFindAgain})
            Me.MenuItem2.Text = "&Edit"
            '
            'miUndo
            '
            Me.miUndo.Index = 0
            Me.miUndo.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlZ
            Me.miUndo.Text = "&Undo"
            '
            'miRedo
            '
            Me.miRedo.Index = 1
            Me.miRedo.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlY
            Me.miRedo.Text = "&Redo"
            '
            'MenuItem3
            '
            Me.MenuItem3.Index = 2
            Me.MenuItem3.Text = "-"
            '
            'miCut
            '
            Me.miCut.Index = 3
            Me.miCut.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlX
            Me.miCut.Text = "Cu&t"
            '
            'miCopy
            '
            Me.miCopy.Index = 4
            Me.miCopy.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlC
            Me.miCopy.Text = "&Copy"
            '
            'miPaste
            '
            Me.miPaste.Index = 5
            Me.miPaste.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlV
            Me.miPaste.Text = "&Paste"
            '
            'MenuItem9
            '
            Me.MenuItem9.Index = 6
            Me.MenuItem9.Text = "-"
            '
            'miSelectAll
            '
            Me.miSelectAll.Index = 7
            Me.miSelectAll.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlA
            Me.miSelectAll.Text = "Select &All"
            '
            'MenuItem7
            '
            Me.MenuItem7.Index = 8
            Me.MenuItem7.Text = "-"
            '
            'miFind
            '
            Me.miFind.Index = 9
            Me.miFind.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlF
            Me.miFind.Text = "&Find..."
            '
            'miFindAgain
            '
            Me.miFindAgain.Index = 10
            Me.miFindAgain.Shortcut = Global.System.Windows.Forms.Shortcut.F3
            Me.miFindAgain.Text = "Find &Next"
            '
            'MenuItem5
            '
            Me.MenuItem5.Index = 2
            Me.MenuItem5.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miWordWrap, Me.miFont})
            Me.MenuItem5.Text = "F&ormat"
            '
            'miWordWrap
            '
            Me.miWordWrap.Checked = True
            Me.miWordWrap.Index = 0
            Me.miWordWrap.Text = "&Word Wrap"
            '
            'miFont
            '
            Me.miFont.Index = 1
            Me.miFont.Text = "&Font..."
            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 3
            Me.MenuItem6.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miCameras, Me.miCreatureList, Me.miDoorsList, Me.miEncountersList, Me.miMerchantList, Me.miPlaceablesList, Me.miSoundsList, Me.miTriggersList, Me.miWaypointsList})
            Me.MenuItem6.Text = "&Quick"
            '
            'miCameras
            '
            Me.miCameras.Index = 0
            Me.miCameras.Text = "C&ameras"
            '
            'miCreatureList
            '
            Me.miCreatureList.Index = 1
            Me.miCreatureList.Text = "&Creature List"
            '
            'miDoorsList
            '
            Me.miDoorsList.Index = 2
            Me.miDoorsList.Text = "&Doors List"
            '
            'miEncountersList
            '
            Me.miEncountersList.Index = 3
            Me.miEncountersList.Text = "&Encounters List"
            '
            'miMerchantList
            '
            Me.miMerchantList.Index = 4
            Me.miMerchantList.Text = "&Merchant List"
            '
            'miPlaceablesList
            '
            Me.miPlaceablesList.Index = 5
            Me.miPlaceablesList.Text = "&Placeables List"
            '
            'miSoundsList
            '
            Me.miSoundsList.Index = 6
            Me.miSoundsList.Text = "&Sounds List"
            '
            'miTriggersList
            '
            Me.miTriggersList.Index = 7
            Me.miTriggersList.Text = "&Triggers List"
            '
            'miWaypointsList
            '
            Me.miWaypointsList.Index = 8
            Me.miWaypointsList.Text = "&Waypoints List"
            '
            'MenuItem8
            '
            Me.MenuItem8.Index = 4
            Me.MenuItem8.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miScriptIsK1, Me.miScriptIsK2, Me.MenuItem12, Me.miCompile})
            Me.MenuItem8.Text = "&Script"
            '
            'miScriptIsK1
            '
            Me.miScriptIsK1.Index = 0
            Me.miScriptIsK1.Text = "Script is for KotOR I"
            '
            'miScriptIsK2
            '
            Me.miScriptIsK2.Index = 1
            Me.miScriptIsK2.Text = "Script is for KotOR II"
            '
            'MenuItem12
            '
            Me.MenuItem12.Index = 2
            Me.MenuItem12.Text = "-"
            '
            'miCompile
            '
            Me.miCompile.Enabled = False
            Me.miCompile.Index = 3
            Me.miCompile.Shortcut = Global.System.Windows.Forms.Shortcut.F5
            Me.miCompile.Text = "&Compile"
            '
            'cmText
            '
            Me.cmText.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiShowDefinition})
            '
            'cmiShowDefinition
            '
            Me.cmiShowDefinition.Index = 0
            Me.cmiShowDefinition.Text = "Show Definition..."
            '
            'frmTextEditor
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New Global.System.Drawing.Size(936, 601)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmTextEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Text Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlEditorHost.ResumeLayout(False)
            Me.pnlEditorHost.PerformLayout()
            Me.pnlFunctions.ResumeLayout(False)
            Me.pnlFunctions.PerformLayout()

            AddHandler Me.tbGeneric.MouseDown, AddressOf Me.tbGeneric_MouseDown
            AddHandler Me.tbGeneric.LostFocus, AddressOf Me.tbGeneric_LostFocus
            AddHandler Me.tbGeneric.GotFocus, AddressOf Me.tbGeneric_GotFocus
            AddHandler Me.tbGeneric.MouseMove, AddressOf Me.tbGeneric_MouseMove
            AddHandler Me.miFind.Click, AddressOf Me.miFind_Click
            AddHandler Me.miFindAgain.Click, AddressOf Me.miFindAgain_Click
            AddHandler Me.miUndo.Click, AddressOf Me.miUndo_Click
            AddHandler Me.miRedo.Click, AddressOf Me.miRedo_Click
            AddHandler Me.miCut.Click, AddressOf Me.miCut_Click
            AddHandler Me.miCopy.Click, AddressOf Me.miCopy_Click
            AddHandler Me.miPaste.Click, AddressOf Me.miPaste_Click
            AddHandler Me.miSelectAll.Click, AddressOf Me.miSelectAll_Click
            AddHandler Me.miSaveAs.Click, AddressOf Me.miSaveAs_Click
            AddHandler Me.miQuit.Click, AddressOf Me.miQuit_Click
            AddHandler Me.miOpen.Click, AddressOf Me.miOpen_Click
            AddHandler Me.miPrint.Click, AddressOf Me.miPrint_Click
            AddHandler Me.miPageSetup.Click, AddressOf Me.miPageSetup_Click
            AddHandler Me.miFont.Click, AddressOf Me.miFont_Click
            AddHandler Me.miWordWrap.Click, AddressOf Me.miWordWrap_Click
            AddHandler Me.miPlaceablesList.Click, AddressOf Me.miPlaceablesList_Click
            AddHandler Me.miEncountersList.Click, AddressOf Me.miEncountersList_Click
            AddHandler Me.miWaypointsList.Click, AddressOf Me.miWaypointsList_Click
            AddHandler Me.miSoundsList.Click, AddressOf Me.miSoundsList_Click
            AddHandler Me.miTriggersList.Click, AddressOf Me.miTriggersList_Click
            AddHandler Me.miDoorsList.Click, AddressOf Me.miDoorsList_Click
            AddHandler Me.miCameras.Click, AddressOf Me.miCameras_Click
            AddHandler Me.miCreatureList.Click, AddressOf Me.miCreatureList_Click
            AddHandler Me.miMerchantList.Click, AddressOf Me.miMerchantList_Click
            AddHandler Me.miSave.Click, AddressOf Me.miSave_Click
            AddHandler Me.miScriptIsK1.Click, AddressOf Me.miScriptIsK1_Click
            AddHandler Me.miScriptIsK2.Click, AddressOf Me.miScriptIsK2_Click
            AddHandler Me.miCompile.Click, AddressOf Me.miCompile_Click
            AddHandler Me.lbFunctions.SelectedIndexChanged, AddressOf Me.lbFunctions_SelectedIndexChanged
            AddHandler Me.lbFunctions.DoubleClick, AddressOf Me.lbFunctions_DoubleClick
            AddHandler Me.lbFunctions.Click, AddressOf Me.lbFunctions_Click
            AddHandler Me.tbFuncNameFilter.TextChanged, AddressOf Me.tbFuncNameFilter_TextChanged
            AddHandler Me.cmiShowDefinition.Click, AddressOf Me.cmiShowDefinition_Click

            Me.ResumeLayout(False)
        End Sub

    End Class

End Namespace