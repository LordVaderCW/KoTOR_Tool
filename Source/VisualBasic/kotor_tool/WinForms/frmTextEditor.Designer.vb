Imports mystuff.Controls

Namespace kotor_tool
    ' Token: 0x02000077 RID: 119
    Partial Public Class frmTextEditor
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
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


        ' Token: 0x06001032 RID: 4146 RVA: 0x0029A4D4 File Offset: 0x002994D4
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x06001093 RID: 4243 RVA: 0x0029B5E4 File Offset: 0x0029A5E4
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmTextEditor))
            Me.tbGeneric = New Global.mystuff.Controls.LinenumberTextBox()
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
            Me.lbFunctions = New Global.System.Windows.Forms.ListBox()
            Me.tbFuncNameFilter = New Global.System.Windows.Forms.TextBox()
            Me.tbFuncDecl = New Global.System.Windows.Forms.TextBox()
            Me.pnlFunctions = New Global.System.Windows.Forms.Panel()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.lblMatches = New Global.System.Windows.Forms.Label()
            Me.cmText = New Global.System.Windows.Forms.ContextMenu()
            Me.cmiShowDefinition = New Global.System.Windows.Forms.MenuItem()
            Me.pnlFunctions.SuspendLayout()
            Me.SuspendLayout()
            Me.tbGeneric.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbGeneric.Font = New Global.System.Drawing.Font("Lucida Console", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.tbGeneric.Location = New Global.System.Drawing.Point(16, 8)
            Me.tbGeneric.Name = "tbGeneric"
            Me.tbGeneric.ShowSelectionMargin = True
            Me.tbGeneric.Size = New Global.System.Drawing.Size(904, 584)
            Me.tbGeneric.TabIndex = 5
            Me.tbGeneric.Text = ""
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem5, Me.MenuItem6, Me.MenuItem8})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miOpen, Me.miSave, Me.miSaveAs, Me.MenuItem4, Me.miPageSetup, Me.miPrint, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            Me.miOpen.Index = 0
            Me.miOpen.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpen.Text = "&Open..."
            Me.miSave.Index = 1
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            Me.miSaveAs.Index = 2
            Me.miSaveAs.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlShiftS
            Me.miSaveAs.Text = "Save &As..."
            Me.MenuItem4.Index = 3
            Me.MenuItem4.Text = "-"
            Me.miPageSetup.Index = 4
            Me.miPageSetup.Text = "Page Set&up"
            Me.miPrint.Index = 5
            Me.miPrint.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlP
            Me.miPrint.Text = "&Print"
            Me.miQuit.Index = 6
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miUndo, Me.miRedo, Me.MenuItem3, Me.miCut, Me.miCopy, Me.miPaste, Me.MenuItem9, Me.miSelectAll, Me.MenuItem7, Me.miFind, Me.miFindAgain})
            Me.MenuItem2.Text = "&Edit"
            Me.miUndo.Index = 0
            Me.miUndo.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlZ
            Me.miUndo.Text = "&Undo"
            Me.miRedo.Index = 1
            Me.miRedo.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlY
            Me.miRedo.Text = "&Redo"
            Me.MenuItem3.Index = 2
            Me.MenuItem3.Text = "-"
            Me.miCut.Index = 3
            Me.miCut.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlX
            Me.miCut.Text = "Cu&t"
            Me.miCopy.Index = 4
            Me.miCopy.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlC
            Me.miCopy.Text = "&Copy"
            Me.miPaste.Index = 5
            Me.miPaste.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlV
            Me.miPaste.Text = "&Paste"
            Me.MenuItem9.Index = 6
            Me.MenuItem9.Text = "-"
            Me.miSelectAll.Index = 7
            Me.miSelectAll.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlA
            Me.miSelectAll.Text = "Select &All"
            Me.MenuItem7.Index = 8
            Me.MenuItem7.Text = "-"
            Me.miFind.Index = 9
            Me.miFind.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlF
            Me.miFind.Text = "&Find..."
            Me.miFindAgain.Index = 10
            Me.miFindAgain.Shortcut = Global.System.Windows.Forms.Shortcut.F3
            Me.miFindAgain.Text = "Find &Next"
            Me.MenuItem5.Index = 2
            Me.MenuItem5.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miWordWrap, Me.miFont})
            Me.MenuItem5.Text = "F&ormat"
            Me.miWordWrap.Checked = True
            Me.miWordWrap.Index = 0
            Me.miWordWrap.Text = "&Word Wrap"
            Me.miFont.Index = 1
            Me.miFont.Text = "&Font..."
            Me.MenuItem6.Index = 3
            Me.MenuItem6.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miCameras, Me.miCreatureList, Me.miDoorsList, Me.miEncountersList, Me.miMerchantList, Me.miPlaceablesList, Me.miSoundsList, Me.miTriggersList, Me.miWaypointsList})
            Me.MenuItem6.Text = "&Quick"
            Me.miCameras.Index = 0
            Me.miCameras.Text = "C&ameras"
            Me.miCreatureList.Index = 1
            Me.miCreatureList.Text = "&Creature List"
            Me.miDoorsList.Index = 2
            Me.miDoorsList.Text = "&Doors List"
            Me.miEncountersList.Index = 3
            Me.miEncountersList.Text = "&Encounters List"
            Me.miMerchantList.Index = 4
            Me.miMerchantList.Text = "&Merchant List"
            Me.miPlaceablesList.Index = 5
            Me.miPlaceablesList.Text = "&Placeables List"
            Me.miSoundsList.Index = 6
            Me.miSoundsList.Text = "&Sounds List"
            Me.miTriggersList.Index = 7
            Me.miTriggersList.Text = "&Triggers List"
            Me.miWaypointsList.Index = 8
            Me.miWaypointsList.Text = "&Waypoints List"
            Me.MenuItem8.Index = 4
            Me.MenuItem8.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miScriptIsK1, Me.miScriptIsK2, Me.MenuItem12, Me.miCompile})
            Me.MenuItem8.Text = "&Script"
            Me.miScriptIsK1.Index = 0
            Me.miScriptIsK1.Text = "Script is for KotOR I"
            Me.miScriptIsK2.Index = 1
            Me.miScriptIsK2.Text = "Script is for KotOR II"
            Me.MenuItem12.Index = 2
            Me.MenuItem12.Text = "-"
            Me.miCompile.Enabled = False
            Me.miCompile.Index = 3
            Me.miCompile.Shortcut = Global.System.Windows.Forms.Shortcut.F5
            Me.miCompile.Text = "&Compile"
            Me.lbFunctions.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lbFunctions.Location = New Global.System.Drawing.Point(700, 40)
            Me.lbFunctions.Name = "lbFunctions"
            Me.lbFunctions.Size = New Global.System.Drawing.Size(208, 82)
            Me.lbFunctions.TabIndex = 6
            Me.tbFuncNameFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbFuncNameFilter.Location = New Global.System.Drawing.Point(700, 16)
            Me.tbFuncNameFilter.Name = "tbFuncNameFilter"
            Me.tbFuncNameFilter.Size = New Global.System.Drawing.Size(208, 20)
            Me.tbFuncNameFilter.TabIndex = 7
            Me.tbFuncNameFilter.Text = ""
            Me.tbFuncDecl.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbFuncDecl.Location = New Global.System.Drawing.Point(8, 1)
            Me.tbFuncDecl.Multiline = True
            Me.tbFuncDecl.Name = "tbFuncDecl"
            Me.tbFuncDecl.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbFuncDecl.Size = New Global.System.Drawing.Size(680, 120)
            Me.tbFuncDecl.TabIndex = 8
            Me.tbFuncDecl.Text = ""
            Me.pnlFunctions.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.pnlFunctions.Controls.Add(Me.tbFuncDecl)
            Me.pnlFunctions.Controls.Add(Me.tbFuncNameFilter)
            Me.pnlFunctions.Controls.Add(Me.lbFunctions)
            Me.pnlFunctions.Controls.Add(Me.Label1)
            Me.pnlFunctions.Controls.Add(Me.lblMatches)
            Me.pnlFunctions.Location = New Global.System.Drawing.Point(8, 472)
            Me.pnlFunctions.Name = "pnlFunctions"
            Me.pnlFunctions.Size = New Global.System.Drawing.Size(912, 136)
            Me.pnlFunctions.TabIndex = 10
            Me.pnlFunctions.Visible = False
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Label1.Location = New Global.System.Drawing.Point(700, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(76, 16)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Function filter"
            Me.lblMatches.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lblMatches.ForeColor = Global.System.Drawing.SystemColors.Highlight
            Me.lblMatches.Location = New Global.System.Drawing.Point(824, 0)
            Me.lblMatches.Name = "lblMatches"
            Me.lblMatches.Size = New Global.System.Drawing.Size(76, 16)
            Me.lblMatches.TabIndex = 9
            Me.lblMatches.Text = "Matches: "
            Me.cmText.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiShowDefinition})
            Me.cmiShowDefinition.Index = 0
            Me.cmiShowDefinition.Text = "Show Definition..."
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(936, 601)
            Me.Controls.Add(Me.tbGeneric)
            Me.Controls.Add(Me.pnlFunctions)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmTextEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Text Editor"
            Me.pnlFunctions.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
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
