Namespace kotor_tool
	' Token: 0x0200004D RID: 77
	Public Partial Class frmGlobalVar_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents dgBoolGlobals As Global.System.Windows.Forms.DataGrid
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents dgNumericGlobals As Global.System.Windows.Forms.DataGrid
        Friend WithEvents TabPage4 As Global.System.Windows.Forms.TabPage
        Friend WithEvents dgStringGlobals As Global.System.Windows.Forms.DataGrid
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenFirst As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenCompare As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSave As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miShowOnlyDiffs As Global.System.Windows.Forms.MenuItem
        Friend WithEvents lblFile1 As Global.System.Windows.Forms.Label
        Friend WithEvents lblFile2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents StatusBar As Global.System.Windows.Forms.StatusBar
        Friend WithEvents sbpBool As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbpNumeric As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbpString As Global.System.Windows.Forms.StatusBarPanel
        Friend WithEvents sbpLabel As Global.System.Windows.Forms.StatusBarPanel


        ' Token: 0x06000504 RID: 1284 RVA: 0x00240984 File Offset: 0x0023F984
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x06000537 RID: 1335 RVA: 0x00240FA4 File Offset: 0x0023FFA4
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miOpenFirst = New System.Windows.Forms.MenuItem()
            Me.miOpenCompare = New System.Windows.Forms.MenuItem()
            Me.miSave = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New System.Windows.Forms.MenuItem()
            Me.miShowOnlyDiffs = New System.Windows.Forms.MenuItem()
            Me.StatusBar = New System.Windows.Forms.StatusBar()
            Me.sbpLabel = New System.Windows.Forms.StatusBarPanel()
            Me.sbpBool = New System.Windows.Forms.StatusBarPanel()
            Me.sbpNumeric = New System.Windows.Forms.StatusBarPanel()
            Me.sbpString = New System.Windows.Forms.StatusBarPanel()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.dgBoolGlobals = New System.Windows.Forms.DataGrid()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.dgNumericGlobals = New System.Windows.Forms.DataGrid()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.dgStringGlobals = New System.Windows.Forms.DataGrid()
            Me.lblFile1 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblFile2 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            CType(Me.sbpLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpBool, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpString, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.dgBoolGlobals, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgNumericGlobals, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage4.SuspendLayout()
            CType(Me.dgStringGlobals, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miOpenFirst, Me.miOpenCompare, Me.miSave, Me.MenuItem6, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miOpenFirst
            '
            Me.miOpenFirst.Index = 0
            Me.miOpenFirst.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenFirst.Text = "&Open..."
            '
            'miOpenCompare
            '
            Me.miOpenCompare.Enabled = False
            Me.miOpenCompare.Index = 1
            Me.miOpenCompare.Text = "Open File to &Compare..."
            '
            'miSave
            '
            Me.miSave.Index = 2
            Me.miSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 3
            Me.MenuItem6.Text = "-"
            '
            'miQuit
            '
            Me.miQuit.Index = 4
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miShowOnlyDiffs})
            Me.MenuItem2.Text = "&View"
            '
            'miShowOnlyDiffs
            '
            Me.miShowOnlyDiffs.Enabled = False
            Me.miShowOnlyDiffs.Index = 0
            Me.miShowOnlyDiffs.Text = "&Show only differences"
            '
            'StatusBar
            '
            Me.StatusBar.Location = New System.Drawing.Point(0, 486)
            Me.StatusBar.Name = "StatusBar"
            Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sbpLabel, Me.sbpBool, Me.sbpNumeric, Me.sbpString})
            Me.StatusBar.ShowPanels = True
            Me.StatusBar.Size = New System.Drawing.Size(448, 22)
            Me.StatusBar.SizingGrip = False
            Me.StatusBar.TabIndex = 4
            Me.StatusBar.Text = "StatusBar"
            Me.StatusBar.Visible = False
            '
            'sbpLabel
            '
            Me.sbpLabel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
            Me.sbpLabel.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
            Me.sbpLabel.Name = "sbpLabel"
            Me.sbpLabel.Text = "Differences"
            Me.sbpLabel.Width = 72
            '
            'sbpBool
            '
            Me.sbpBool.Alignment = System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpBool.Name = "sbpBool"
            Me.sbpBool.ToolTipText = "Number of differences in Boolean Globals"
            Me.sbpBool.Width = 50
            '
            'sbpNumeric
            '
            Me.sbpNumeric.Alignment = System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpNumeric.Name = "sbpNumeric"
            Me.sbpNumeric.ToolTipText = "Number of differences in Numeric Globals"
            Me.sbpNumeric.Width = 50
            '
            'sbpString
            '
            Me.sbpString.Alignment = System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpString.Name = "sbpString"
            Me.sbpString.ToolTipText = "Number of differences in String Globals"
            Me.sbpString.Width = 50
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Me.TabControl1.Location = New System.Drawing.Point(8, 8)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(432, 467)
            Me.TabControl1.TabIndex = 1
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.dgBoolGlobals)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New System.Drawing.Size(424, 441)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Boolean Globals"
            '
            'dgBoolGlobals
            '
            Me.dgBoolGlobals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgBoolGlobals.DataMember = ""
            Me.dgBoolGlobals.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgBoolGlobals.Location = New System.Drawing.Point(8, 8)
            Me.dgBoolGlobals.Name = "dgBoolGlobals"
            Me.dgBoolGlobals.Size = New System.Drawing.Size(408, 427)
            Me.dgBoolGlobals.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.dgNumericGlobals)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New System.Drawing.Size(424, 462)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Numeric Globals"
            '
            'dgNumericGlobals
            '
            Me.dgNumericGlobals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgNumericGlobals.DataMember = ""
            Me.dgNumericGlobals.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgNumericGlobals.Location = New System.Drawing.Point(8, 8)
            Me.dgNumericGlobals.Name = "dgNumericGlobals"
            Me.dgNumericGlobals.Size = New System.Drawing.Size(408, 448)
            Me.dgNumericGlobals.TabIndex = 0
            '
            'TabPage4
            '
            Me.TabPage4.Controls.Add(Me.dgStringGlobals)
            Me.TabPage4.Location = New System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Size = New System.Drawing.Size(424, 462)
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "String Globals"
            '
            'dgStringGlobals
            '
            Me.dgStringGlobals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgStringGlobals.DataMember = ""
            Me.dgStringGlobals.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dgStringGlobals.Location = New System.Drawing.Point(8, 8)
            Me.dgStringGlobals.Name = "dgStringGlobals"
            Me.dgStringGlobals.Size = New System.Drawing.Size(408, 448)
            Me.dgStringGlobals.TabIndex = 1
            '
            'lblFile1
            '
            Me.lblFile1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFile1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.lblFile1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFile1.Location = New System.Drawing.Point(72, 8)
            Me.lblFile1.Name = "lblFile1"
            Me.lblFile1.Size = New System.Drawing.Size(352, 16)
            Me.lblFile1.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.Location = New System.Drawing.Point(25, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(48, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Viewing:"
            '
            'lblFile2
            '
            Me.lblFile2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFile2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.lblFile2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFile2.Location = New System.Drawing.Point(72, 32)
            Me.lblFile2.Name = "lblFile2"
            Me.lblFile2.Size = New System.Drawing.Size(352, 16)
            Me.lblFile2.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(12, 32)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(64, 16)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Comparing:"
            '
            'frmGlobalVar_Editor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(448, 508)
            Me.Controls.Add(Me.StatusBar)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.lblFile1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblFile2)
            Me.Controls.Add(Me.Label2)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmGlobalVar_Editor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Global Variable Editor"
            CType(Me.sbpLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpBool, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpNumeric, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpString, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            CType(Me.dgBoolGlobals, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.dgNumericGlobals, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage4.ResumeLayout(False)
            CType(Me.dgStringGlobals, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
