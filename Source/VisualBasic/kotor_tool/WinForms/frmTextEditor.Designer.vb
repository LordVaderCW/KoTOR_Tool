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
            Me.components = New System.ComponentModel.Container()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlEditorHost = New System.Windows.Forms.Panel()
            Me.tbGeneric = New mystuff.Controls.LinenumberTextBox()
            Me.cmText = New System.Windows.Forms.ContextMenu()
            Me.cmiShowDefinition = New System.Windows.Forms.MenuItem()
            Me.pnlFunctions = New System.Windows.Forms.Panel()
            Me.tbFuncDecl = New System.Windows.Forms.TextBox()
            Me.tbFuncNameFilter = New System.Windows.Forms.TextBox()
            Me.lbFunctions = New System.Windows.Forms.ListBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblMatches = New System.Windows.Forms.Label()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miOpen = New System.Windows.Forms.MenuItem()
            Me.miSave = New System.Windows.Forms.MenuItem()
            Me.miSaveAs = New System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New System.Windows.Forms.MenuItem()
            Me.miPageSetup = New System.Windows.Forms.MenuItem()
            Me.miPrint = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New System.Windows.Forms.MenuItem()
            Me.miUndo = New System.Windows.Forms.MenuItem()
            Me.miRedo = New System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New System.Windows.Forms.MenuItem()
            Me.miCut = New System.Windows.Forms.MenuItem()
            Me.miCopy = New System.Windows.Forms.MenuItem()
            Me.miPaste = New System.Windows.Forms.MenuItem()
            Me.MenuItem9 = New System.Windows.Forms.MenuItem()
            Me.miSelectAll = New System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New System.Windows.Forms.MenuItem()
            Me.miFind = New System.Windows.Forms.MenuItem()
            Me.miFindAgain = New System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New System.Windows.Forms.MenuItem()
            Me.miWordWrap = New System.Windows.Forms.MenuItem()
            Me.miFont = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.miCameras = New System.Windows.Forms.MenuItem()
            Me.miCreatureList = New System.Windows.Forms.MenuItem()
            Me.miDoorsList = New System.Windows.Forms.MenuItem()
            Me.miEncountersList = New System.Windows.Forms.MenuItem()
            Me.miMerchantList = New System.Windows.Forms.MenuItem()
            Me.miPlaceablesList = New System.Windows.Forms.MenuItem()
            Me.miSoundsList = New System.Windows.Forms.MenuItem()
            Me.miTriggersList = New System.Windows.Forms.MenuItem()
            Me.miWaypointsList = New System.Windows.Forms.MenuItem()
            Me.MenuItem8 = New System.Windows.Forms.MenuItem()
            Me.miScriptIsK1 = New System.Windows.Forms.MenuItem()
            Me.miScriptIsK2 = New System.Windows.Forms.MenuItem()
            Me.MenuItem12 = New System.Windows.Forms.MenuItem()
            Me.miCompile = New System.Windows.Forms.MenuItem()
            Me.pnlRoot.SuspendLayout()
            Me.pnlEditorHost.SuspendLayout()
            Me.pnlFunctions.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlEditorHost)
            Me.pnlRoot.Controls.Add(Me.pnlFunctions)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlRoot.Size = New System.Drawing.Size(936, 674)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlEditorHost
            '
            Me.pnlEditorHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlEditorHost.Controls.Add(Me.tbGeneric)
            Me.pnlEditorHost.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlEditorHost.Location = New System.Drawing.Point(10, 10)
            Me.pnlEditorHost.Name = "pnlEditorHost"
            Me.pnlEditorHost.Padding = New System.Windows.Forms.Padding(8)
            Me.pnlEditorHost.Size = New System.Drawing.Size(916, 518)
            Me.pnlEditorHost.TabIndex = 0
            '
            'tbGeneric
            '
            Me.tbGeneric.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.tbGeneric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbGeneric.ContextMenu = Me.cmText
            Me.tbGeneric.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbGeneric.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbGeneric.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbGeneric.Location = New System.Drawing.Point(8, 8)
            Me.tbGeneric.Name = "tbGeneric"
            Me.tbGeneric.ShowSelectionMargin = True
            Me.tbGeneric.Size = New System.Drawing.Size(900, 502)
            Me.tbGeneric.TabIndex = 5
            Me.tbGeneric.Text = ""
            '
            'cmText
            '
            Me.cmText.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmiShowDefinition})
            '
            'cmiShowDefinition
            '
            Me.cmiShowDefinition.Index = 0
            Me.cmiShowDefinition.Text = "Show Definition..."
            '
            'pnlFunctions
            '
            Me.pnlFunctions.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlFunctions.Controls.Add(Me.tbFuncDecl)
            Me.pnlFunctions.Controls.Add(Me.tbFuncNameFilter)
            Me.pnlFunctions.Controls.Add(Me.lbFunctions)
            Me.pnlFunctions.Controls.Add(Me.Label1)
            Me.pnlFunctions.Controls.Add(Me.lblMatches)
            Me.pnlFunctions.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFunctions.Location = New System.Drawing.Point(10, 528)
            Me.pnlFunctions.Name = "pnlFunctions"
            Me.pnlFunctions.Padding = New System.Windows.Forms.Padding(8)
            Me.pnlFunctions.Size = New System.Drawing.Size(916, 136)
            Me.pnlFunctions.TabIndex = 10
            Me.pnlFunctions.Visible = False
            '
            'tbFuncDecl
            '
            Me.tbFuncDecl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbFuncDecl.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.tbFuncDecl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFuncDecl.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbFuncDecl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFuncDecl.Location = New System.Drawing.Point(8, 8)
            Me.tbFuncDecl.Multiline = True
            Me.tbFuncDecl.Name = "tbFuncDecl"
            Me.tbFuncDecl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbFuncDecl.Size = New System.Drawing.Size(680, 120)
            Me.tbFuncDecl.TabIndex = 8
            '
            'tbFuncNameFilter
            '
            Me.tbFuncNameFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbFuncNameFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.tbFuncNameFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFuncNameFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbFuncNameFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFuncNameFilter.Location = New System.Drawing.Point(700, 24)
            Me.tbFuncNameFilter.Name = "tbFuncNameFilter"
            Me.tbFuncNameFilter.Size = New System.Drawing.Size(208, 22)
            Me.tbFuncNameFilter.TabIndex = 7
            '
            'lbFunctions
            '
            Me.lbFunctions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbFunctions.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.lbFunctions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbFunctions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbFunctions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbFunctions.Location = New System.Drawing.Point(700, 50)
            Me.lbFunctions.Name = "lbFunctions"
            Me.lbFunctions.Size = New System.Drawing.Size(208, 67)
            Me.lbFunctions.TabIndex = 6
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(700, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(96, 16)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Function filter"
            '
            'lblMatches
            '
            Me.lblMatches.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblMatches.BackColor = System.Drawing.Color.Transparent
            Me.lblMatches.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMatches.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblMatches.Location = New System.Drawing.Point(824, 6)
            Me.lblMatches.Name = "lblMatches"
            Me.lblMatches.Size = New System.Drawing.Size(84, 16)
            Me.lblMatches.TabIndex = 10
            Me.lblMatches.Text = "Matches: "
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem5, Me.MenuItem6, Me.MenuItem8})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miOpen, Me.miSave, Me.miSaveAs, Me.MenuItem4, Me.miPageSetup, Me.miPrint, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miOpen
            '
            Me.miOpen.Index = 0
            Me.miOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpen.Text = "&Open..."
            '
            'miSave
            '
            Me.miSave.Index = 1
            Me.miSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            '
            'miSaveAs
            '
            Me.miSaveAs.Index = 2
            Me.miSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
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
            Me.miPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP
            Me.miPrint.Text = "&Print"
            '
            'miQuit
            '
            Me.miQuit.Index = 6
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miUndo, Me.miRedo, Me.MenuItem3, Me.miCut, Me.miCopy, Me.miPaste, Me.MenuItem9, Me.miSelectAll, Me.MenuItem7, Me.miFind, Me.miFindAgain})
            Me.MenuItem2.Text = "&Edit"
            '
            'miUndo
            '
            Me.miUndo.Index = 0
            Me.miUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
            Me.miUndo.Text = "&Undo"
            '
            'miRedo
            '
            Me.miRedo.Index = 1
            Me.miRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY
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
            Me.miCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX
            Me.miCut.Text = "Cu&t"
            '
            'miCopy
            '
            Me.miCopy.Index = 4
            Me.miCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC
            Me.miCopy.Text = "&Copy"
            '
            'miPaste
            '
            Me.miPaste.Index = 5
            Me.miPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV
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
            Me.miSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA
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
            Me.miFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF
            Me.miFind.Text = "&Find..."
            '
            'miFindAgain
            '
            Me.miFindAgain.Index = 10
            Me.miFindAgain.Shortcut = System.Windows.Forms.Shortcut.F3
            Me.miFindAgain.Text = "Find &Next"
            '
            'MenuItem5
            '
            Me.MenuItem5.Index = 2
            Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miWordWrap, Me.miFont})
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
            Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miCameras, Me.miCreatureList, Me.miDoorsList, Me.miEncountersList, Me.miMerchantList, Me.miPlaceablesList, Me.miSoundsList, Me.miTriggersList, Me.miWaypointsList})
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
            Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miScriptIsK1, Me.miScriptIsK2, Me.MenuItem12, Me.miCompile})
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
            Me.miCompile.Shortcut = System.Windows.Forms.Shortcut.F5
            Me.miCompile.Text = "&Compile"
            '
            'frmTextEditor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(936, 674)
            Me.Controls.Add(Me.pnlRoot)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmTextEditor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Text Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlEditorHost.ResumeLayout(False)
            Me.pnlFunctions.ResumeLayout(False)
            Me.pnlFunctions.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace