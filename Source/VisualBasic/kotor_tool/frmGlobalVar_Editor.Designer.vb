Namespace kotor_tool
	' Token: 0x0200004D RID: 77
	Public Partial Class frmGlobalVar_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000504 RID: 1284 RVA: 0x00240984 File Offset: 0x0023F984
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000537 RID: 1335 RVA: 0x00240FA4 File Offset: 0x0023FFA4
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.dgBoolGlobals = New Global.System.Windows.Forms.DataGrid()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
            Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
            Me.dgNumericGlobals = New Global.System.Windows.Forms.DataGrid()
            Me.TabPage4 = New Global.System.Windows.Forms.TabPage()
            Me.dgStringGlobals = New Global.System.Windows.Forms.DataGrid()
            Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu()
            Me.MenuItem1 = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenFirst = New Global.System.Windows.Forms.MenuItem()
            Me.miOpenCompare = New Global.System.Windows.Forms.MenuItem()
            Me.miSave = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New Global.System.Windows.Forms.MenuItem()
            Me.miQuit = New Global.System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New Global.System.Windows.Forms.MenuItem()
            Me.miShowOnlyDiffs = New Global.System.Windows.Forms.MenuItem()
            Me.lblFile1 = New Global.System.Windows.Forms.Label()
            Me.lblFile2 = New Global.System.Windows.Forms.Label()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.StatusBar = New Global.System.Windows.Forms.StatusBar()
            Me.sbpLabel = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbpBool = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbpNumeric = New Global.System.Windows.Forms.StatusBarPanel()
            Me.sbpString = New Global.System.Windows.Forms.StatusBarPanel()
            CType(Me.dgBoolGlobals, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgNumericGlobals, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage4.SuspendLayout()
            CType(Me.dgStringGlobals, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpLabel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpBool, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpNumeric, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbpString, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.dgBoolGlobals.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.dgBoolGlobals.DataMember = ""
            Me.dgBoolGlobals.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Dim dgBoolGlobals As Global.System.Windows.Forms.Control = Me.dgBoolGlobals
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 8)
            dgBoolGlobals.Location = point
            Me.dgBoolGlobals.Name = "dgBoolGlobals"
            Dim dgBoolGlobals2 As Global.System.Windows.Forms.Control = Me.dgBoolGlobals
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(408, 448)
            dgBoolGlobals2.Size = size
            Me.dgBoolGlobals.TabIndex = 0
            Me.TabControl1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            point = New Global.System.Drawing.Point(8, 8)
            tabControl.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
            size = New Global.System.Drawing.Size(432, 488)
            tabControl2.Size = size
            Me.TabControl1.TabIndex = 1
            Me.TabPage1.Controls.Add(Me.dgBoolGlobals)
            Dim tabPage As Global.System.Windows.Forms.Control = Me.TabPage1
            point = New Global.System.Drawing.Point(4, 22)
            tabPage.Location = point
            Me.TabPage1.Name = "TabPage1"
            Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
            size = New Global.System.Drawing.Size(424, 462)
            tabPage2.Size = size
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Boolean Globals"
            Me.TabPage2.Controls.Add(Me.dgNumericGlobals)
            Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage2
            point = New Global.System.Drawing.Point(4, 22)
            tabPage3.Location = point
            Me.TabPage2.Name = "TabPage2"
            Dim tabPage4 As Global.System.Windows.Forms.Control = Me.TabPage2
            size = New Global.System.Drawing.Size(424, 462)
            tabPage4.Size = size
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Numeric Globals"
            Me.dgNumericGlobals.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.dgNumericGlobals.DataMember = ""
            Me.dgNumericGlobals.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Dim dgNumericGlobals As Global.System.Windows.Forms.Control = Me.dgNumericGlobals
            point = New Global.System.Drawing.Point(8, 8)
            dgNumericGlobals.Location = point
            Me.dgNumericGlobals.Name = "dgNumericGlobals"
            Dim dgNumericGlobals2 As Global.System.Windows.Forms.Control = Me.dgNumericGlobals
            size = New Global.System.Drawing.Size(408, 448)
            dgNumericGlobals2.Size = size
            Me.dgNumericGlobals.TabIndex = 0
            Me.TabPage4.Controls.Add(Me.dgStringGlobals)
            Dim tabPage5 As Global.System.Windows.Forms.Control = Me.TabPage4
            point = New Global.System.Drawing.Point(4, 22)
            tabPage5.Location = point
            Me.TabPage4.Name = "TabPage4"
            Dim tabPage6 As Global.System.Windows.Forms.Control = Me.TabPage4
            size = New Global.System.Drawing.Size(424, 462)
            tabPage6.Size = size
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "String Globals"
            Me.dgStringGlobals.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.dgStringGlobals.DataMember = ""
            Me.dgStringGlobals.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Dim dgStringGlobals As Global.System.Windows.Forms.Control = Me.dgStringGlobals
            point = New Global.System.Drawing.Point(8, 8)
            dgStringGlobals.Location = point
            Me.dgStringGlobals.Name = "dgStringGlobals"
            Dim dgStringGlobals2 As Global.System.Windows.Forms.Control = Me.dgStringGlobals
            size = New Global.System.Drawing.Size(408, 448)
            dgStringGlobals2.Size = size
            Me.dgStringGlobals.TabIndex = 1
            Me.MainMenu1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miOpenFirst, Me.miOpenCompare, Me.miSave, Me.MenuItem6, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            Me.miOpenFirst.Index = 0
            Me.miOpenFirst.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenFirst.Text = "&Open..."
            Me.miOpenCompare.Enabled = False
            Me.miOpenCompare.Index = 1
            Me.miOpenCompare.Text = "Open File to &Compare..."
            Me.miSave.Index = 2
            Me.miSave.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlS
            Me.miSave.Text = "&Save"
            Me.MenuItem6.Index = 3
            Me.MenuItem6.Text = "-"
            Me.miQuit.Index = 4
            Me.miQuit.Shortcut = Global.System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            Me.MenuItem2.Index = 1
            Me.MenuItem2.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.miShowOnlyDiffs})
            Me.MenuItem2.Text = "&View"
            Me.miShowOnlyDiffs.Enabled = False
            Me.miShowOnlyDiffs.Index = 0
            Me.miShowOnlyDiffs.Text = "&Show only differences"
            Me.lblFile1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lblFile1.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
            Me.lblFile1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
            Dim lblFile As Global.System.Windows.Forms.Control = Me.lblFile1
            point = New Global.System.Drawing.Point(72, 8)
            lblFile.Location = point
            Me.lblFile1.Name = "lblFile1"
            Dim lblFile2 As Global.System.Windows.Forms.Control = Me.lblFile1
            size = New Global.System.Drawing.Size(352, 16)
            lblFile2.Size = size
            Me.lblFile1.TabIndex = 2
            Me.lblFile2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lblFile2.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
            Me.lblFile2.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
            Dim lblFile3 As Global.System.Windows.Forms.Control = Me.lblFile2
            point = New Global.System.Drawing.Point(72, 32)
            lblFile3.Location = point
            Me.lblFile2.Name = "lblFile2"
            Dim lblFile4 As Global.System.Windows.Forms.Control = Me.lblFile2
            size = New Global.System.Drawing.Size(352, 16)
            lblFile4.Size = size
            Me.lblFile2.TabIndex = 2
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(25, 8)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(48, 16)
            label2.Size = size
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Viewing:"
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(12, 32)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(64, 16)
            label4.Size = size
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Comparing:"
            Dim statusBar As Global.System.Windows.Forms.Control = Me.StatusBar
            point = New Global.System.Drawing.Point(0, 507)
            statusBar.Location = point
            Me.StatusBar.Name = "StatusBar"
            Me.StatusBar.Panels.AddRange(New Global.System.Windows.Forms.StatusBarPanel() {Me.sbpLabel, Me.sbpBool, Me.sbpNumeric, Me.sbpString})
            Me.StatusBar.ShowPanels = True
            Dim statusBar2 As Global.System.Windows.Forms.Control = Me.StatusBar
            size = New Global.System.Drawing.Size(448, 22)
            statusBar2.Size = size
            Me.StatusBar.SizingGrip = False
            Me.StatusBar.TabIndex = 4
            Me.StatusBar.Text = "StatusBar"
            Me.StatusBar.Visible = False
            Me.sbpLabel.AutoSize = Global.System.Windows.Forms.StatusBarPanelAutoSize.Contents
            Me.sbpLabel.BorderStyle = Global.System.Windows.Forms.StatusBarPanelBorderStyle.None
            Me.sbpLabel.Text = "Differences"
            Me.sbpLabel.Width = 72
            Me.sbpBool.Alignment = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpBool.ToolTipText = "Number of differences in Boolean Globals"
            Me.sbpBool.Width = 50
            Me.sbpNumeric.Alignment = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpNumeric.ToolTipText = "Number of differences in Numeric Globals"
            Me.sbpNumeric.Width = 50
            Me.sbpString.Alignment = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.sbpString.ToolTipText = "Number of differences in String Globals"
            Me.sbpString.Width = 50
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(448, 529)
            Me.ClientSize = size
            Me.Controls.Add(Me.StatusBar)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.lblFile1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblFile2)
            Me.Controls.Add(Me.Label2)
            Me.Menu = Me.MainMenu1
            Me.Name = "frmGlobalVar_Editor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Global Variable Editor"
            CType(Me.dgBoolGlobals, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            CType(Me.dgNumericGlobals, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage4.ResumeLayout(False)
            CType(Me.dgStringGlobals, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpLabel, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpBool, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpNumeric, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbpString, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040002C7 RID: 711
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
