Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmProjectManager
        Inherits Global.kotor_tool.frmParent

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderRule As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterRule As Global.System.Windows.Forms.Label

        Friend WithEvents TreeView As Global.System.Windows.Forms.TreeView
        Friend WithEvents MainMenu1 As Global.System.Windows.Forms.MainMenu
        Friend WithEvents MenuItem1 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem4 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem7 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmOverrideRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmOverrideChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmModulesRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmModulesParent As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmModulesChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmLipsModulesRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmLipsModulesParent As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmLipsModulesChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmiOverrideRoot_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiOverrideChild_Exclude As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesRoot_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesParent_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesChild_Exclude As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesRoot_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesParent_Add As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesChild_Exclude As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miProjectProperties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miNewPoject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miDebug As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miRelease As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miOpenProject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miSaveProject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miQuit As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miBuildProject As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem3 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiOverrideRoot_RemoveAll As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesParent_RemoveAll As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesParent_RemoveAll As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem2 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem5 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesRoot_RemoveAllModules As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesRoot_RemoveAllModules As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesParent_RemoveSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesParent_RemoveSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmProjectRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmiProperties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miExploreReleaseFolder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miExploreDebugFolder As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem10 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiModulesParent_RenameSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiLipsModulesParent_RenameSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem9 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem8 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCleanDebugPrjFilesOnly As Global.System.Windows.Forms.MenuItem
        Friend WithEvents miCleanReleasePrjFilesOnly As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem11 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem12 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmStreamWavesRoot As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmStreamWavesModulesParent As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmStreamWavesModulesChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmStreamWavesFileChild As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents tvcmiStreamWavesRoot_AddFile As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesRoot_AddModule As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem13 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesRoot_RemoveAllFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesRoot_RemoveAllModules As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesRoot_RemoveEverything As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModuleParent_AddFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModuleParent_ExcludeAllFiles As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem14 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModuleParent_RenameSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem15 As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModulesParent_RemoveSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesModulesChild_ExcludeSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents tvcmiStreamWavesFileChild_ExcludeSelf As Global.System.Windows.Forms.MenuItem
        Friend WithEvents ilistTree As Global.System.Windows.Forms.ImageList
        Friend WithEvents lblStatus As Global.System.Windows.Forms.Label
        Friend WithEvents tvcmiModulesParent_Properties As Global.System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem16 As Global.System.Windows.Forms.MenuItem

        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TreeView = New System.Windows.Forms.TreeView()
            Me.ilistTree = New System.Windows.Forms.ImageList(Me.components)
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterRule = New System.Windows.Forms.Label()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderRule = New System.Windows.Forms.Label()
            Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.MenuItem1 = New System.Windows.Forms.MenuItem()
            Me.miNewPoject = New System.Windows.Forms.MenuItem()
            Me.miOpenProject = New System.Windows.Forms.MenuItem()
            Me.miSaveProject = New System.Windows.Forms.MenuItem()
            Me.MenuItem4 = New System.Windows.Forms.MenuItem()
            Me.miProjectProperties = New System.Windows.Forms.MenuItem()
            Me.MenuItem7 = New System.Windows.Forms.MenuItem()
            Me.miExploreDebugFolder = New System.Windows.Forms.MenuItem()
            Me.miExploreReleaseFolder = New System.Windows.Forms.MenuItem()
            Me.MenuItem10 = New System.Windows.Forms.MenuItem()
            Me.miQuit = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.miBuildProject = New System.Windows.Forms.MenuItem()
            Me.MenuItem3 = New System.Windows.Forms.MenuItem()
            Me.miDebug = New System.Windows.Forms.MenuItem()
            Me.miRelease = New System.Windows.Forms.MenuItem()
            Me.MenuItem8 = New System.Windows.Forms.MenuItem()
            Me.miCleanDebugPrjFilesOnly = New System.Windows.Forms.MenuItem()
            Me.miCleanReleasePrjFilesOnly = New System.Windows.Forms.MenuItem()
            Me.tvcmOverrideRoot = New System.Windows.Forms.ContextMenu()
            Me.tvcmiOverrideRoot_Add = New System.Windows.Forms.MenuItem()
            Me.tvcmiOverrideRoot_RemoveAll = New System.Windows.Forms.MenuItem()
            Me.tvcmOverrideChild = New System.Windows.Forms.ContextMenu()
            Me.tvcmiOverrideChild_Exclude = New System.Windows.Forms.MenuItem()
            Me.tvcmModulesRoot = New System.Windows.Forms.ContextMenu()
            Me.tvcmiModulesRoot_Add = New System.Windows.Forms.MenuItem()
            Me.MenuItem11 = New System.Windows.Forms.MenuItem()
            Me.tvcmiModulesRoot_RemoveAllModules = New System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New System.Windows.Forms.MenuItem()
            Me.tvcmLipsModulesRoot = New System.Windows.Forms.ContextMenu()
            Me.tvcmiLipsModulesRoot_Add = New System.Windows.Forms.MenuItem()
            Me.MenuItem12 = New System.Windows.Forms.MenuItem()
            Me.tvcmiLipsModulesRoot_RemoveAllModules = New System.Windows.Forms.MenuItem()
            Me.tvcmModulesParent = New System.Windows.Forms.ContextMenu()
            Me.tvcmiModulesParent_Add = New System.Windows.Forms.MenuItem()
            Me.tvcmiModulesParent_RemoveAll = New System.Windows.Forms.MenuItem()
            Me.tvcmiModulesParent_RenameSelf = New System.Windows.Forms.MenuItem()
            Me.tvcmiModulesParent_RemoveSelf = New System.Windows.Forms.MenuItem()
            Me.MenuItem16 = New System.Windows.Forms.MenuItem()
            Me.tvcmiModulesParent_Properties = New System.Windows.Forms.MenuItem()
            Me.MenuItem2 = New System.Windows.Forms.MenuItem()
            Me.MenuItem9 = New System.Windows.Forms.MenuItem()
            Me.tvcmLipsModulesParent = New System.Windows.Forms.ContextMenu()
            Me.tvcmiLipsModulesParent_Add = New System.Windows.Forms.MenuItem()
            Me.tvcmiLipsModulesParent_RemoveAll = New System.Windows.Forms.MenuItem()
            Me.tvcmiLipsModulesParent_RenameSelf = New System.Windows.Forms.MenuItem()
            Me.tvcmiLipsModulesParent_RemoveSelf = New System.Windows.Forms.MenuItem()
            Me.tvcmModulesChild = New System.Windows.Forms.ContextMenu()
            Me.tvcmiModulesChild_Exclude = New System.Windows.Forms.MenuItem()
            Me.tvcmLipsModulesChild = New System.Windows.Forms.ContextMenu()
            Me.tvcmiLipsModulesChild_Exclude = New System.Windows.Forms.MenuItem()
            Me.tvcmProjectRoot = New System.Windows.Forms.ContextMenu()
            Me.tvcmiProperties = New System.Windows.Forms.MenuItem()
            Me.tvcmStreamWavesRoot = New System.Windows.Forms.ContextMenu()
            Me.tvcmiStreamWavesRoot_AddFile = New System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesRoot_AddModule = New System.Windows.Forms.MenuItem()
            Me.MenuItem13 = New System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesRoot_RemoveAllFiles = New System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesRoot_RemoveAllModules = New System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesRoot_RemoveEverything = New System.Windows.Forms.MenuItem()
            Me.tvcmStreamWavesModulesParent = New System.Windows.Forms.ContextMenu()
            Me.tvcmiStreamWavesModuleParent_AddFiles = New System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles = New System.Windows.Forms.MenuItem()
            Me.MenuItem14 = New System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesModuleParent_RenameSelf = New System.Windows.Forms.MenuItem()
            Me.MenuItem15 = New System.Windows.Forms.MenuItem()
            Me.tvcmiStreamWavesModulesParent_RemoveSelf = New System.Windows.Forms.MenuItem()
            Me.tvcmStreamWavesModulesChild = New System.Windows.Forms.ContextMenu()
            Me.tvcmiStreamWavesModulesChild_ExcludeSelf = New System.Windows.Forms.MenuItem()
            Me.tvcmStreamWavesFileChild = New System.Windows.Forms.ContextMenu()
            Me.tvcmiStreamWavesFileChild_ExcludeSelf = New System.Windows.Forms.MenuItem()

            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(360, 492)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TreeView)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(12)
            Me.pnlBody.Size = New System.Drawing.Size(358, 354)
            Me.pnlBody.TabIndex = 1
            '
            'TreeView
            '
            Me.TreeView.AllowDrop = True
            Me.TreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TreeView.HideSelection = False
            Me.TreeView.ImageIndex = 0
            Me.TreeView.ImageList = Me.ilistTree
            Me.TreeView.Indent = 19
            Me.TreeView.LineColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.TreeView.Location = New System.Drawing.Point(12, 12)
            Me.TreeView.Name = "TreeView"
            Me.TreeView.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TreeView.SelectedImageIndex = 0
            Me.TreeView.Size = New System.Drawing.Size(334, 330)
            Me.TreeView.TabIndex = 0
            '
            'ilistTree
            '
            Me.ilistTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.ilistTree.ImageSize = New System.Drawing.Size(16, 16)
            Me.ilistTree.TransparentColor = System.Drawing.Color.Transparent
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterRule)
            Me.pnlFooter.Controls.Add(Me.lblStatus)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 430)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Padding = New System.Windows.Forms.Padding(12, 10, 12, 12)
            Me.pnlFooter.Size = New System.Drawing.Size(358, 60)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(12, 10)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(334, 1)
            Me.lblFooterRule.TabIndex = 0
            '
            'lblStatus
            '
            Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblStatus.Location = New System.Drawing.Point(12, 19)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
            Me.lblStatus.Size = New System.Drawing.Size(334, 29)
            Me.lblStatus.TabIndex = 1
            Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderRule)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(358, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 8)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(320, 32)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Project Manager"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(318, 20)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Manage project files, modules, lips, and stream waves."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 73)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(358, 3)
            Me.lblHeaderRule.TabIndex = 2
            '
            'MainMenu1
            '
            Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem6})
            '
            'MenuItem1
            '
            Me.MenuItem1.Index = 0
            Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNewPoject, Me.miOpenProject, Me.miSaveProject, Me.MenuItem4, Me.miProjectProperties, Me.MenuItem7, Me.miExploreDebugFolder, Me.miExploreReleaseFolder, Me.MenuItem10, Me.miQuit})
            Me.MenuItem1.Text = "&File"
            '
            'miNewPoject
            '
            Me.miNewPoject.Index = 0
            Me.miNewPoject.Shortcut = System.Windows.Forms.Shortcut.CtrlN
            Me.miNewPoject.Text = "&New Project..."
            '
            'miOpenProject
            '
            Me.miOpenProject.Index = 1
            Me.miOpenProject.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.miOpenProject.Text = "&Open Project..."
            '
            'miSaveProject
            '
            Me.miSaveProject.Enabled = False
            Me.miSaveProject.Index = 2
            Me.miSaveProject.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.miSaveProject.Text = "&Save Project"
            '
            'MenuItem4
            '
            Me.MenuItem4.Index = 3
            Me.MenuItem4.Text = "-"
            '
            'miProjectProperties
            '
            Me.miProjectProperties.Enabled = False
            Me.miProjectProperties.Index = 4
            Me.miProjectProperties.Text = "&Project Properties..."
            '
            'MenuItem7
            '
            Me.MenuItem7.Index = 5
            Me.MenuItem7.Text = "-"
            '
            'miExploreDebugFolder
            '
            Me.miExploreDebugFolder.Enabled = False
            Me.miExploreDebugFolder.Index = 6
            Me.miExploreDebugFolder.Text = "Open &Debug Folder"
            '
            'miExploreReleaseFolder
            '
            Me.miExploreReleaseFolder.Enabled = False
            Me.miExploreReleaseFolder.Index = 7
            Me.miExploreReleaseFolder.Text = "Open &Release Folder"
            '
            'MenuItem10
            '
            Me.MenuItem10.Index = 8
            Me.MenuItem10.Text = "-"
            '
            'miQuit
            '
            Me.miQuit.Index = 9
            Me.miQuit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
            Me.miQuit.Text = "&Quit"
            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 1
            Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miBuildProject, Me.MenuItem3, Me.miDebug, Me.miRelease, Me.MenuItem8, Me.miCleanDebugPrjFilesOnly, Me.miCleanReleasePrjFilesOnly})
            Me.MenuItem6.Text = "&Build"
            '
            'miBuildProject
            '
            Me.miBuildProject.Enabled = False
            Me.miBuildProject.Index = 0
            Me.miBuildProject.Shortcut = System.Windows.Forms.Shortcut.F5
            Me.miBuildProject.Text = "B&uild Project"
            '
            'MenuItem3
            '
            Me.MenuItem3.Index = 1
            Me.MenuItem3.Text = "-"
            '
            'miDebug
            '
            Me.miDebug.Checked = True
            Me.miDebug.Index = 2
            Me.miDebug.Text = "&Debug"
            '
            'miRelease
            '
            Me.miRelease.Index = 3
            Me.miRelease.Text = "&Release"
            '
            'MenuItem8
            '
            Me.MenuItem8.Index = 4
            Me.MenuItem8.Text = "-"
            '
            'miCleanDebugPrjFilesOnly
            '
            Me.miCleanDebugPrjFilesOnly.Enabled = False
            Me.miCleanDebugPrjFilesOnly.Index = 5
            Me.miCleanDebugPrjFilesOnly.Text = "Clean Debug Directory - Project Files Only"
            '
            'miCleanReleasePrjFilesOnly
            '
            Me.miCleanReleasePrjFilesOnly.Enabled = False
            Me.miCleanReleasePrjFilesOnly.Index = 6
            Me.miCleanReleasePrjFilesOnly.Text = "Clean Release Directory - Project Files Only"
            '
            'tvcmOverrideRoot
            '
            Me.tvcmOverrideRoot.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiOverrideRoot_Add, Me.tvcmiOverrideRoot_RemoveAll})
            '
            'tvcmiOverrideRoot_Add
            '
            Me.tvcmiOverrideRoot_Add.Index = 0
            Me.tvcmiOverrideRoot_Add.Text = "Add Files..."
            '
            'tvcmiOverrideRoot_RemoveAll
            '
            Me.tvcmiOverrideRoot_RemoveAll.Enabled = False
            Me.tvcmiOverrideRoot_RemoveAll.Index = 1
            Me.tvcmiOverrideRoot_RemoveAll.Text = "Exclude All Files..."
            '
            'tvcmOverrideChild
            '
            Me.tvcmOverrideChild.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiOverrideChild_Exclude})
            '
            'tvcmiOverrideChild_Exclude
            '
            Me.tvcmiOverrideChild_Exclude.Index = 0
            Me.tvcmiOverrideChild_Exclude.Text = "Exclude file from Project"
            '
            'tvcmModulesRoot
            '
            Me.tvcmModulesRoot.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiModulesRoot_Add, Me.MenuItem11, Me.tvcmiModulesRoot_RemoveAllModules})
            '
            'tvcmiModulesRoot_Add
            '
            Me.tvcmiModulesRoot_Add.Index = 0
            Me.tvcmiModulesRoot_Add.Text = "Add New Package..."
            '
            'MenuItem11
            '
            Me.MenuItem11.Index = 1
            Me.MenuItem11.Text = "-"
            '
            'tvcmiModulesRoot_RemoveAllModules
            '
            Me.tvcmiModulesRoot_RemoveAllModules.Enabled = False
            Me.tvcmiModulesRoot_RemoveAllModules.Index = 2
            Me.tvcmiModulesRoot_RemoveAllModules.Text = "Remove All Packages..."
            '
            'MenuItem5
            '
            Me.MenuItem5.Index = -1
            Me.MenuItem5.Text = "-"
            '
            'tvcmModulesParent
            '
            Me.tvcmModulesParent.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiModulesParent_Add, Me.tvcmiModulesParent_RemoveAll, Me.tvcmiModulesParent_RenameSelf, Me.tvcmiModulesParent_RemoveSelf, Me.MenuItem16, Me.tvcmiModulesParent_Properties})
            '
            'tvcmiModulesParent_Add
            '
            Me.tvcmiModulesParent_Add.Index = 0
            Me.tvcmiModulesParent_Add.Text = "Add Files..."
            '
            'tvcmiModulesParent_RemoveAll
            '
            Me.tvcmiModulesParent_RemoveAll.Enabled = False
            Me.tvcmiModulesParent_RemoveAll.Index = 1
            Me.tvcmiModulesParent_RemoveAll.Text = "Exclude All Files..."
            '
            'tvcmiModulesParent_RenameSelf
            '
            Me.tvcmiModulesParent_RenameSelf.Index = 2
            Me.tvcmiModulesParent_RenameSelf.Text = "Rename"
            '
            'tvcmiModulesParent_RemoveSelf
            '
            Me.tvcmiModulesParent_RemoveSelf.Index = 3
            Me.tvcmiModulesParent_RemoveSelf.Text = "Remove Package"
            '
            'MenuItem16
            '
            Me.MenuItem16.Index = 4
            Me.MenuItem16.Text = "-"
            '
            'tvcmiModulesParent_Properties
            '
            Me.tvcmiModulesParent_Properties.Index = 5
            Me.tvcmiModulesParent_Properties.Text = "Properties"
            '
            'tvcmModulesChild
            '
            Me.tvcmModulesChild.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiModulesChild_Exclude})
            '
            'tvcmiModulesChild_Exclude
            '
            Me.tvcmiModulesChild_Exclude.Index = 0
            Me.tvcmiModulesChild_Exclude.Text = "Exclude file from Project"
            '
            'tvcmLipsModulesRoot
            '
            Me.tvcmLipsModulesRoot.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiLipsModulesRoot_Add, Me.MenuItem12, Me.tvcmiLipsModulesRoot_RemoveAllModules})
            '
            'tvcmiLipsModulesRoot_Add
            '
            Me.tvcmiLipsModulesRoot_Add.Index = 0
            Me.tvcmiLipsModulesRoot_Add.Text = "Add New Module..."
            '
            'MenuItem12
            '
            Me.MenuItem12.Index = 1
            Me.MenuItem12.Text = "-"
            '
            'tvcmiLipsModulesRoot_RemoveAllModules
            '
            Me.tvcmiLipsModulesRoot_RemoveAllModules.Enabled = False
            Me.tvcmiLipsModulesRoot_RemoveAllModules.Index = 2
            Me.tvcmiLipsModulesRoot_RemoveAllModules.Text = "Remove All Modules..."
            '
            'tvcmLipsModulesParent
            '
            Me.tvcmLipsModulesParent.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiLipsModulesParent_Add, Me.tvcmiLipsModulesParent_RemoveAll, Me.MenuItem2, Me.tvcmiLipsModulesParent_RenameSelf, Me.MenuItem9, Me.tvcmiLipsModulesParent_RemoveSelf})
            '
            'tvcmiLipsModulesParent_Add
            '
            Me.tvcmiLipsModulesParent_Add.Index = 0
            Me.tvcmiLipsModulesParent_Add.Text = "Add Files..."
            '
            'tvcmiLipsModulesParent_RemoveAll
            '
            Me.tvcmiLipsModulesParent_RemoveAll.Enabled = False
            Me.tvcmiLipsModulesParent_RemoveAll.Index = 1
            Me.tvcmiLipsModulesParent_RemoveAll.Text = "Exclude All Files..."
            '
            'MenuItem2
            '
            Me.MenuItem2.Index = 2
            Me.MenuItem2.Text = "-"
            '
            'tvcmiLipsModulesParent_RenameSelf
            '
            Me.tvcmiLipsModulesParent_RenameSelf.Index = 3
            Me.tvcmiLipsModulesParent_RenameSelf.Text = "Rename"
            '
            'MenuItem9
            '
            Me.MenuItem9.Index = 4
            Me.MenuItem9.Text = "-"
            '
            'tvcmiLipsModulesParent_RemoveSelf
            '
            Me.tvcmiLipsModulesParent_RemoveSelf.Index = 5
            Me.tvcmiLipsModulesParent_RemoveSelf.Text = "Remove Module"
            '
            'tvcmLipsModulesChild
            '
            Me.tvcmLipsModulesChild.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiLipsModulesChild_Exclude})
            '
            'tvcmiLipsModulesChild_Exclude
            '
            Me.tvcmiLipsModulesChild_Exclude.Index = 0
            Me.tvcmiLipsModulesChild_Exclude.Text = "Exclude file from Project"
            '
            'tvcmProjectRoot
            '
            Me.tvcmProjectRoot.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiProperties})
            '
            'tvcmiProperties
            '
            Me.tvcmiProperties.Index = 0
            Me.tvcmiProperties.Text = "Properties"
            '
            'tvcmStreamWavesRoot
            '
            Me.tvcmStreamWavesRoot.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiStreamWavesRoot_AddFile, Me.tvcmiStreamWavesRoot_AddModule, Me.MenuItem13, Me.tvcmiStreamWavesRoot_RemoveAllFiles, Me.tvcmiStreamWavesRoot_RemoveAllModules, Me.tvcmiStreamWavesRoot_RemoveEverything})
            '
            'tvcmiStreamWavesRoot_AddFile
            '
            Me.tvcmiStreamWavesRoot_AddFile.Index = 0
            Me.tvcmiStreamWavesRoot_AddFile.Text = "Add Files..."
            '
            'tvcmiStreamWavesRoot_AddModule
            '
            Me.tvcmiStreamWavesRoot_AddModule.Index = 1
            Me.tvcmiStreamWavesRoot_AddModule.Text = "Add Module..."
            '
            'MenuItem13
            '
            Me.MenuItem13.Index = 2
            Me.MenuItem13.Text = "-"
            '
            'tvcmiStreamWavesRoot_RemoveAllFiles
            '
            Me.tvcmiStreamWavesRoot_RemoveAllFiles.Index = 3
            Me.tvcmiStreamWavesRoot_RemoveAllFiles.Text = "Remove all root-level files..."
            '
            'tvcmiStreamWavesRoot_RemoveAllModules
            '
            Me.tvcmiStreamWavesRoot_RemoveAllModules.Index = 4
            Me.tvcmiStreamWavesRoot_RemoveAllModules.Text = "Remove All Modules..."
            '
            'tvcmiStreamWavesRoot_RemoveEverything
            '
            Me.tvcmiStreamWavesRoot_RemoveEverything.Index = 5
            Me.tvcmiStreamWavesRoot_RemoveEverything.Text = "Remove Everything..."
            '
            'tvcmStreamWavesModulesParent
            '
            Me.tvcmStreamWavesModulesParent.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiStreamWavesModuleParent_AddFiles, Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles, Me.MenuItem14, Me.tvcmiStreamWavesModuleParent_RenameSelf, Me.MenuItem15, Me.tvcmiStreamWavesModulesParent_RemoveSelf})
            '
            'tvcmiStreamWavesModuleParent_AddFiles
            '
            Me.tvcmiStreamWavesModuleParent_AddFiles.Index = 0
            Me.tvcmiStreamWavesModuleParent_AddFiles.Text = "Add Files..."
            '
            'tvcmiStreamWavesModuleParent_ExcludeAllFiles
            '
            Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Enabled = False
            Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Index = 1
            Me.tvcmiStreamWavesModuleParent_ExcludeAllFiles.Text = "Exclude All Files..."
            '
            'MenuItem14
            '
            Me.MenuItem14.Index = 2
            Me.MenuItem14.Text = "-"
            '
            'tvcmiStreamWavesModuleParent_RenameSelf
            '
            Me.tvcmiStreamWavesModuleParent_RenameSelf.Index = 3
            Me.tvcmiStreamWavesModuleParent_RenameSelf.Text = "Rename"
            '
            'MenuItem15
            '
            Me.MenuItem15.Index = 4
            Me.MenuItem15.Text = "-"
            '
            'tvcmiStreamWavesModulesParent_RemoveSelf
            '
            Me.tvcmiStreamWavesModulesParent_RemoveSelf.Index = 5
            Me.tvcmiStreamWavesModulesParent_RemoveSelf.Text = "Remove Module"
            '
            'tvcmStreamWavesModulesChild
            '
            Me.tvcmStreamWavesModulesChild.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiStreamWavesModulesChild_ExcludeSelf})
            '
            'tvcmiStreamWavesModulesChild_ExcludeSelf
            '
            Me.tvcmiStreamWavesModulesChild_ExcludeSelf.Index = 0
            Me.tvcmiStreamWavesModulesChild_ExcludeSelf.Text = "Exclude file from Project"
            '
            'tvcmStreamWavesFileChild
            '
            Me.tvcmStreamWavesFileChild.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.tvcmiStreamWavesFileChild_ExcludeSelf})
            '
            'tvcmiStreamWavesFileChild_ExcludeSelf
            '
            Me.tvcmiStreamWavesFileChild_ExcludeSelf.Index = 0
            Me.tvcmiStreamWavesFileChild_ExcludeSelf.Text = "Exclude file from Project"
            '
            'frmProjectManager
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(360, 492)
            Me.Controls.Add(Me.pnlRoot)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Menu = Me.MainMenu1
            Me.MinimumSize = New System.Drawing.Size(376, 531)
            Me.Name = "frmProjectManager"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Project Manager"

            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace