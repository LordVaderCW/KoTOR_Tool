Namespace kotor_tool
	' Token: 0x02000077 RID: 119
	Public Partial Class frmTextEditor
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001032 RID: 4146 RVA: 0x0029A4D4 File Offset: 0x002994D4
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06001093 RID: 4243 RVA: 0x0029B5E4 File Offset: 0x0029A5E4
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmTextEditor))
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
            Dim tbGeneric As Global.System.Windows.Forms.Control = Me.tbGeneric
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(16, 8)
            tbGeneric.Location = point
            Me.tbGeneric.Name = "tbGeneric"
            Me.tbGeneric.ShowSelectionMargin = True
            Dim tbGeneric2 As Global.System.Windows.Forms.Control = Me.tbGeneric
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(904, 584)
            tbGeneric2.Size = size
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
            Dim lbFunctions As Global.System.Windows.Forms.Control = Me.lbFunctions
            point = New Global.System.Drawing.Point(700, 40)
            lbFunctions.Location = point
            Me.lbFunctions.Name = "lbFunctions"
            Dim lbFunctions2 As Global.System.Windows.Forms.Control = Me.lbFunctions
            size = New Global.System.Drawing.Size(208, 82)
            lbFunctions2.Size = size
            Me.lbFunctions.TabIndex = 6
            Me.tbFuncNameFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbFuncNameFilter As Global.System.Windows.Forms.Control = Me.tbFuncNameFilter
            point = New Global.System.Drawing.Point(700, 16)
            tbFuncNameFilter.Location = point
            Me.tbFuncNameFilter.Name = "tbFuncNameFilter"
            Dim tbFuncNameFilter2 As Global.System.Windows.Forms.Control = Me.tbFuncNameFilter
            size = New Global.System.Drawing.Size(208, 20)
            tbFuncNameFilter2.Size = size
            Me.tbFuncNameFilter.TabIndex = 7
            Me.tbFuncNameFilter.Text = ""
            Me.tbFuncDecl.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbFuncDecl As Global.System.Windows.Forms.Control = Me.tbFuncDecl
            point = New Global.System.Drawing.Point(8, 1)
            tbFuncDecl.Location = point
            Me.tbFuncDecl.Multiline = True
            Me.tbFuncDecl.Name = "tbFuncDecl"
            Me.tbFuncDecl.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Dim tbFuncDecl2 As Global.System.Windows.Forms.Control = Me.tbFuncDecl
            size = New Global.System.Drawing.Size(680, 120)
            tbFuncDecl2.Size = size
            Me.tbFuncDecl.TabIndex = 8
            Me.tbFuncDecl.Text = ""
            Me.pnlFunctions.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.pnlFunctions.Controls.Add(Me.tbFuncDecl)
            Me.pnlFunctions.Controls.Add(Me.tbFuncNameFilter)
            Me.pnlFunctions.Controls.Add(Me.lbFunctions)
            Me.pnlFunctions.Controls.Add(Me.Label1)
            Me.pnlFunctions.Controls.Add(Me.lblMatches)
            Dim pnlFunctions As Global.System.Windows.Forms.Control = Me.pnlFunctions
            point = New Global.System.Drawing.Point(8, 472)
            pnlFunctions.Location = point
            Me.pnlFunctions.Name = "pnlFunctions"
            Dim pnlFunctions2 As Global.System.Windows.Forms.Control = Me.pnlFunctions
            size = New Global.System.Drawing.Size(912, 136)
            pnlFunctions2.Size = size
            Me.pnlFunctions.TabIndex = 10
            Me.pnlFunctions.Visible = False
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(700, 0)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(76, 16)
            label2.Size = size
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Function filter"
            Me.lblMatches.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lblMatches.ForeColor = Global.System.Drawing.SystemColors.Highlight
            Dim lblMatches As Global.System.Windows.Forms.Control = Me.lblMatches
            point = New Global.System.Drawing.Point(824, 0)
            lblMatches.Location = point
            Me.lblMatches.Name = "lblMatches"
            Dim lblMatches2 As Global.System.Windows.Forms.Control = Me.lblMatches
            size = New Global.System.Drawing.Size(76, 16)
            lblMatches2.Size = size
            Me.lblMatches.TabIndex = 9
            Me.lblMatches.Text = "Matches: "
            Me.cmText.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiShowDefinition})
            Me.cmiShowDefinition.Index = 0
            Me.cmiShowDefinition.Text = "Show Definition..."
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(936, 601)
            Me.ClientSize = size
            Me.Controls.Add(Me.tbGeneric)
            Me.Controls.Add(Me.pnlFunctions)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmTextEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Text Editor"
            Me.pnlFunctions.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000805 RID: 2053
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
