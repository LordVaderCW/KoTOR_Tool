Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmInventoryEditor
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmInventoryEditor.Designer.vb
        '
        ' Restored / facelifted Inventory Editor for the KoTOR Tool
        ' Restoration Project.
        '
        ' Original Tool:
        '   Fred Tetra's KotOR Tool
        '
        ' Restoration Project:
        '   KoTOR Tool Restoration Project
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original control names preserved for source compatibility.
        '   - Theme colours are applied at runtime from Themes\DarkSaber.ini.
        '   - Designer keeps fallback colours only for safe VS designer display.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents TreeView As Global.System.Windows.Forms.TreeView
        Friend WithEvents pnlImplant As InventoryPanel
        Friend WithEvents pnlHead As InventoryPanel
        Friend WithEvents pnlHands As InventoryPanel
        Friend WithEvents pnlRArm As InventoryPanel
        Friend WithEvents pnlLArm As InventoryPanel
        Friend WithEvents pnlArmor As InventoryPanel
        Friend WithEvents pnlRWeapon As InventoryPanel
        Friend WithEvents pnlLWeapon As InventoryPanel
        Friend WithEvents pnlBelt As InventoryPanel
        Friend WithEvents ToolTip1 As Global.System.Windows.Forms.ToolTip
        Friend WithEvents dgPackItems As Global.System.Windows.Forms.DataGrid
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents Panel8 As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlImplantBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeadBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHandsBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlLArmBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlArmorBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlRArmBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlLWeaponBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBeltBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlRWeaponBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlTrash As Global.System.Windows.Forms.Panel
        Friend WithEvents TabControl2 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPage3 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage4 As Global.System.Windows.Forms.TabPage
        Friend WithEvents cmEquippedItems As Global.System.Windows.Forms.ContextMenu
        Friend WithEvents cmiDropable As Global.System.Windows.Forms.MenuItem
        Friend WithEvents pnlCreatureItem1 As InventoryPanel
        Friend WithEvents pnlCreatureItem3 As InventoryPanel
        Friend WithEvents pnlCreatureItem2 As InventoryPanel
        Friend WithEvents pnlCreatureHide As InventoryPanel
        Friend WithEvents pnlCreatureHideBkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlCreatureItem1Bkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlCreatureItem2Bkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlCreatureItem3Bkgnd As Global.System.Windows.Forms.Panel
        Friend WithEvents Splitter1 As Global.System.Windows.Forms.Splitter
        Friend WithEvents btnCollapseAll As Global.System.Windows.Forms.Button
        Friend WithEvents btnExpandAll As Global.System.Windows.Forms.Button
        Friend WithEvents pnlRightSide As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel

        Friend WithEvents pnlOuterRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlTreeTools As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label
        Friend WithEvents lblPackItems As Global.System.Windows.Forms.Label

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
            Me.TreeView = New System.Windows.Forms.TreeView()
            Me.pnlImplant = New kotor_tool.InventoryPanel()
            Me.cmEquippedItems = New System.Windows.Forms.ContextMenu()
            Me.cmiDropable = New System.Windows.Forms.MenuItem()
            Me.pnlHead = New kotor_tool.InventoryPanel()
            Me.pnlHands = New kotor_tool.InventoryPanel()
            Me.pnlRArm = New kotor_tool.InventoryPanel()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.pnlLArm = New kotor_tool.InventoryPanel()
            Me.pnlArmor = New kotor_tool.InventoryPanel()
            Me.pnlRWeapon = New kotor_tool.InventoryPanel()
            Me.pnlLWeapon = New kotor_tool.InventoryPanel()
            Me.pnlBelt = New kotor_tool.InventoryPanel()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnCollapseAll = New System.Windows.Forms.Button()
            Me.btnExpandAll = New System.Windows.Forms.Button()
            Me.dgPackItems = New System.Windows.Forms.DataGrid()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.pnlImplantBkgnd = New System.Windows.Forms.Panel()
            Me.pnlHeadBkgnd = New System.Windows.Forms.Panel()
            Me.pnlHandsBkgnd = New System.Windows.Forms.Panel()
            Me.pnlLArmBkgnd = New System.Windows.Forms.Panel()
            Me.pnlArmorBkgnd = New System.Windows.Forms.Panel()
            Me.pnlRArmBkgnd = New System.Windows.Forms.Panel()
            Me.pnlLWeaponBkgnd = New System.Windows.Forms.Panel()
            Me.pnlBeltBkgnd = New System.Windows.Forms.Panel()
            Me.pnlRWeaponBkgnd = New System.Windows.Forms.Panel()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.pnlCreatureItem1 = New kotor_tool.InventoryPanel()
            Me.pnlCreatureItem3 = New kotor_tool.InventoryPanel()
            Me.pnlCreatureItem2 = New kotor_tool.InventoryPanel()
            Me.pnlCreatureHide = New kotor_tool.InventoryPanel()
            Me.pnlCreatureHideBkgnd = New System.Windows.Forms.Panel()
            Me.pnlCreatureItem1Bkgnd = New System.Windows.Forms.Panel()
            Me.pnlCreatureItem2Bkgnd = New System.Windows.Forms.Panel()
            Me.pnlCreatureItem3Bkgnd = New System.Windows.Forms.Panel()
            Me.pnlTrash = New System.Windows.Forms.Panel()
            Me.TabControl2 = New System.Windows.Forms.TabControl()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.pnlRightSide = New System.Windows.Forms.Panel()
            Me.lblPackItems = New System.Windows.Forms.Label()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.Splitter1 = New System.Windows.Forms.Splitter()
            Me.pnlOuterRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.pnlTreeTools = New System.Windows.Forms.Panel()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.pnlRArm.SuspendLayout()
            CType(Me.dgPackItems, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabControl2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.pnlRightSide.SuspendLayout()
            Me.pnlRoot.SuspendLayout()
            Me.pnlOuterRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlTreeTools.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'TreeView
            '
            Me.TreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeView.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TreeView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TreeView.HideSelection = False
            Me.TreeView.LineColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.TreeView.Location = New System.Drawing.Point(0, 0)
            Me.TreeView.Name = "TreeView"
            Me.TreeView.Size = New System.Drawing.Size(214, 428)
            Me.TreeView.TabIndex = 0
            '
            'pnlImplant
            '
            Me.pnlImplant.AllowDrop = True
            Me.pnlImplant.Location = New System.Drawing.Point(15, 14)
            Me.pnlImplant.Name = "pnlImplant"
            Me.pnlImplant.Size = New System.Drawing.Size(64, 64)
            Me.pnlImplant.TabIndex = 2
            '
            'cmEquippedItems
            '
            Me.cmEquippedItems.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmiDropable})
            '
            'cmiDropable
            '
            Me.cmiDropable.Checked = True
            Me.cmiDropable.Index = 0
            Me.cmiDropable.Text = "Dropable"
            '
            'pnlHead
            '
            Me.pnlHead.AllowDrop = True
            Me.pnlHead.Location = New System.Drawing.Point(90, 14)
            Me.pnlHead.Name = "pnlHead"
            Me.pnlHead.Size = New System.Drawing.Size(64, 64)
            Me.pnlHead.TabIndex = 2
            '
            'pnlHands
            '
            Me.pnlHands.AllowDrop = True
            Me.pnlHands.Location = New System.Drawing.Point(165, 14)
            Me.pnlHands.Name = "pnlHands"
            Me.pnlHands.Size = New System.Drawing.Size(64, 64)
            Me.pnlHands.TabIndex = 2
            '
            'pnlRArm
            '
            Me.pnlRArm.AllowDrop = True
            Me.pnlRArm.Controls.Add(Me.Panel8)
            Me.pnlRArm.Location = New System.Drawing.Point(165, 88)
            Me.pnlRArm.Name = "pnlRArm"
            Me.pnlRArm.Size = New System.Drawing.Size(64, 64)
            Me.pnlRArm.TabIndex = 2
            '
            'Panel8
            '
            Me.Panel8.AllowDrop = True
            Me.Panel8.Location = New System.Drawing.Point(-144, -8)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(94, 70)
            Me.Panel8.TabIndex = 2
            '
            'pnlLArm
            '
            Me.pnlLArm.AllowDrop = True
            Me.pnlLArm.Location = New System.Drawing.Point(15, 88)
            Me.pnlLArm.Name = "pnlLArm"
            Me.pnlLArm.Size = New System.Drawing.Size(64, 64)
            Me.pnlLArm.TabIndex = 2
            '
            'pnlArmor
            '
            Me.pnlArmor.AllowDrop = True
            Me.pnlArmor.Location = New System.Drawing.Point(90, 88)
            Me.pnlArmor.Name = "pnlArmor"
            Me.pnlArmor.Size = New System.Drawing.Size(64, 64)
            Me.pnlArmor.TabIndex = 2
            '
            'pnlRWeapon
            '
            Me.pnlRWeapon.AllowDrop = True
            Me.pnlRWeapon.Location = New System.Drawing.Point(165, 162)
            Me.pnlRWeapon.Name = "pnlRWeapon"
            Me.pnlRWeapon.Size = New System.Drawing.Size(64, 64)
            Me.pnlRWeapon.TabIndex = 2
            '
            'pnlLWeapon
            '
            Me.pnlLWeapon.AllowDrop = True
            Me.pnlLWeapon.Location = New System.Drawing.Point(15, 162)
            Me.pnlLWeapon.Name = "pnlLWeapon"
            Me.pnlLWeapon.Size = New System.Drawing.Size(64, 64)
            Me.pnlLWeapon.TabIndex = 2
            '
            'pnlBelt
            '
            Me.pnlBelt.AllowDrop = True
            Me.pnlBelt.Location = New System.Drawing.Point(90, 162)
            Me.pnlBelt.Name = "pnlBelt"
            Me.pnlBelt.Size = New System.Drawing.Size(64, 64)
            Me.pnlBelt.TabIndex = 2
            '
            'ToolTip1
            '
            Me.ToolTip1.AutoPopDelay = 5000
            Me.ToolTip1.InitialDelay = 250
            Me.ToolTip1.ReshowDelay = 100
            '
            'btnCollapseAll
            '
            Me.btnCollapseAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCollapseAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCollapseAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCollapseAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCollapseAll.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCollapseAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCollapseAll.Location = New System.Drawing.Point(8, 46)
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Me.btnCollapseAll.Size = New System.Drawing.Size(28, 26)
            Me.btnCollapseAll.TabIndex = 1
            Me.btnCollapseAll.Text = "C"
            Me.ToolTip1.SetToolTip(Me.btnCollapseAll, "Collapse all nodes in the treeview")
            Me.btnCollapseAll.UseVisualStyleBackColor = False
            '
            'btnExpandAll
            '
            Me.btnExpandAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnExpandAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnExpandAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnExpandAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExpandAll.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExpandAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnExpandAll.Location = New System.Drawing.Point(8, 12)
            Me.btnExpandAll.Name = "btnExpandAll"
            Me.btnExpandAll.Size = New System.Drawing.Size(28, 26)
            Me.btnExpandAll.TabIndex = 0
            Me.btnExpandAll.Text = "E"
            Me.ToolTip1.SetToolTip(Me.btnExpandAll, "Expand all nodes in the treeview")
            Me.btnExpandAll.UseVisualStyleBackColor = False
            '
            'dgPackItems
            '
            Me.dgPackItems.AllowDrop = True
            Me.dgPackItems.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgPackItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgPackItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgPackItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgPackItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgPackItems.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgPackItems.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgPackItems.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgPackItems.CaptionText = "Pack Items"
            Me.dgPackItems.DataMember = ""
            Me.dgPackItems.FlatMode = True
            Me.dgPackItems.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgPackItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgPackItems.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dgPackItems.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgPackItems.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgPackItems.LinkColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgPackItems.Location = New System.Drawing.Point(12, 307)
            Me.dgPackItems.Name = "dgPackItems"
            Me.dgPackItems.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgPackItems.ParentRowsForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgPackItems.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgPackItems.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgPackItems.Size = New System.Drawing.Size(426, 143)
            Me.dgPackItems.TabIndex = 2
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(510, 6)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(84, 25)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(604, 6)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(84, 25)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(12, 12)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(256, 271)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.pnlImplant)
            Me.TabPage1.Controls.Add(Me.pnlLWeapon)
            Me.TabPage1.Controls.Add(Me.pnlBelt)
            Me.TabPage1.Controls.Add(Me.pnlHead)
            Me.TabPage1.Controls.Add(Me.pnlHands)
            Me.TabPage1.Controls.Add(Me.pnlRArm)
            Me.TabPage1.Controls.Add(Me.pnlLArm)
            Me.TabPage1.Controls.Add(Me.pnlArmor)
            Me.TabPage1.Controls.Add(Me.pnlRWeapon)
            Me.TabPage1.Controls.Add(Me.pnlImplantBkgnd)
            Me.TabPage1.Controls.Add(Me.pnlHeadBkgnd)
            Me.TabPage1.Controls.Add(Me.pnlHandsBkgnd)
            Me.TabPage1.Controls.Add(Me.pnlLArmBkgnd)
            Me.TabPage1.Controls.Add(Me.pnlArmorBkgnd)
            Me.TabPage1.Controls.Add(Me.pnlRArmBkgnd)
            Me.TabPage1.Controls.Add(Me.pnlLWeaponBkgnd)
            Me.TabPage1.Controls.Add(Me.pnlBeltBkgnd)
            Me.TabPage1.Controls.Add(Me.pnlRWeaponBkgnd)
            Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New System.Drawing.Size(248, 245)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Standard Items"
            '
            'pnlImplantBkgnd
            '
            Me.pnlImplantBkgnd.AllowDrop = True
            Me.pnlImplantBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlImplantBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlImplantBkgnd.Location = New System.Drawing.Point(12, 11)
            Me.pnlImplantBkgnd.Name = "pnlImplantBkgnd"
            Me.pnlImplantBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlImplantBkgnd.TabIndex = 2
            '
            'pnlHeadBkgnd
            '
            Me.pnlHeadBkgnd.AllowDrop = True
            Me.pnlHeadBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlHeadBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHeadBkgnd.Location = New System.Drawing.Point(87, 11)
            Me.pnlHeadBkgnd.Name = "pnlHeadBkgnd"
            Me.pnlHeadBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlHeadBkgnd.TabIndex = 2
            '
            'pnlHandsBkgnd
            '
            Me.pnlHandsBkgnd.AllowDrop = True
            Me.pnlHandsBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlHandsBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHandsBkgnd.Location = New System.Drawing.Point(162, 11)
            Me.pnlHandsBkgnd.Name = "pnlHandsBkgnd"
            Me.pnlHandsBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlHandsBkgnd.TabIndex = 2
            '
            'pnlLArmBkgnd
            '
            Me.pnlLArmBkgnd.AllowDrop = True
            Me.pnlLArmBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlLArmBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlLArmBkgnd.Location = New System.Drawing.Point(12, 85)
            Me.pnlLArmBkgnd.Name = "pnlLArmBkgnd"
            Me.pnlLArmBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlLArmBkgnd.TabIndex = 5
            '
            'pnlArmorBkgnd
            '
            Me.pnlArmorBkgnd.AllowDrop = True
            Me.pnlArmorBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlArmorBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlArmorBkgnd.Location = New System.Drawing.Point(87, 85)
            Me.pnlArmorBkgnd.Name = "pnlArmorBkgnd"
            Me.pnlArmorBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlArmorBkgnd.TabIndex = 4
            '
            'pnlRArmBkgnd
            '
            Me.pnlRArmBkgnd.AllowDrop = True
            Me.pnlRArmBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlRArmBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRArmBkgnd.Location = New System.Drawing.Point(162, 85)
            Me.pnlRArmBkgnd.Name = "pnlRArmBkgnd"
            Me.pnlRArmBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlRArmBkgnd.TabIndex = 3
            '
            'pnlLWeaponBkgnd
            '
            Me.pnlLWeaponBkgnd.AllowDrop = True
            Me.pnlLWeaponBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlLWeaponBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlLWeaponBkgnd.Location = New System.Drawing.Point(12, 159)
            Me.pnlLWeaponBkgnd.Name = "pnlLWeaponBkgnd"
            Me.pnlLWeaponBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlLWeaponBkgnd.TabIndex = 8
            '
            'pnlBeltBkgnd
            '
            Me.pnlBeltBkgnd.AllowDrop = True
            Me.pnlBeltBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlBeltBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlBeltBkgnd.Location = New System.Drawing.Point(87, 159)
            Me.pnlBeltBkgnd.Name = "pnlBeltBkgnd"
            Me.pnlBeltBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlBeltBkgnd.TabIndex = 7
            '
            'pnlRWeaponBkgnd
            '
            Me.pnlRWeaponBkgnd.AllowDrop = True
            Me.pnlRWeaponBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlRWeaponBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRWeaponBkgnd.Location = New System.Drawing.Point(162, 159)
            Me.pnlRWeaponBkgnd.Name = "pnlRWeaponBkgnd"
            Me.pnlRWeaponBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlRWeaponBkgnd.TabIndex = 6
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem1)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem3)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem2)
            Me.TabPage2.Controls.Add(Me.pnlCreatureHide)
            Me.TabPage2.Controls.Add(Me.pnlCreatureHideBkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem1Bkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem2Bkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem3Bkgnd)
            Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New System.Drawing.Size(248, 245)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Natural Items"
            '
            'pnlCreatureItem1
            '
            Me.pnlCreatureItem1.AllowDrop = True
            Me.pnlCreatureItem1.Location = New System.Drawing.Point(15, 14)
            Me.pnlCreatureItem1.Name = "pnlCreatureItem1"
            Me.pnlCreatureItem1.Size = New System.Drawing.Size(64, 64)
            Me.pnlCreatureItem1.TabIndex = 4
            '
            'pnlCreatureItem3
            '
            Me.pnlCreatureItem3.AllowDrop = True
            Me.pnlCreatureItem3.Location = New System.Drawing.Point(165, 14)
            Me.pnlCreatureItem3.Name = "pnlCreatureItem3"
            Me.pnlCreatureItem3.Size = New System.Drawing.Size(64, 64)
            Me.pnlCreatureItem3.TabIndex = 3
            '
            'pnlCreatureItem2
            '
            Me.pnlCreatureItem2.AllowDrop = True
            Me.pnlCreatureItem2.Location = New System.Drawing.Point(90, 14)
            Me.pnlCreatureItem2.Name = "pnlCreatureItem2"
            Me.pnlCreatureItem2.Size = New System.Drawing.Size(64, 64)
            Me.pnlCreatureItem2.TabIndex = 4
            '
            'pnlCreatureHide
            '
            Me.pnlCreatureHide.AllowDrop = True
            Me.pnlCreatureHide.Location = New System.Drawing.Point(90, 88)
            Me.pnlCreatureHide.Name = "pnlCreatureHide"
            Me.pnlCreatureHide.Size = New System.Drawing.Size(64, 64)
            Me.pnlCreatureHide.TabIndex = 4
            '
            'pnlCreatureHideBkgnd
            '
            Me.pnlCreatureHideBkgnd.AllowDrop = True
            Me.pnlCreatureHideBkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlCreatureHideBkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCreatureHideBkgnd.Location = New System.Drawing.Point(87, 85)
            Me.pnlCreatureHideBkgnd.Name = "pnlCreatureHideBkgnd"
            Me.pnlCreatureHideBkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlCreatureHideBkgnd.TabIndex = 6
            '
            'pnlCreatureItem1Bkgnd
            '
            Me.pnlCreatureItem1Bkgnd.AllowDrop = True
            Me.pnlCreatureItem1Bkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlCreatureItem1Bkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCreatureItem1Bkgnd.Location = New System.Drawing.Point(12, 11)
            Me.pnlCreatureItem1Bkgnd.Name = "pnlCreatureItem1Bkgnd"
            Me.pnlCreatureItem1Bkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlCreatureItem1Bkgnd.TabIndex = 6
            '
            'pnlCreatureItem2Bkgnd
            '
            Me.pnlCreatureItem2Bkgnd.AllowDrop = True
            Me.pnlCreatureItem2Bkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlCreatureItem2Bkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCreatureItem2Bkgnd.Location = New System.Drawing.Point(87, 11)
            Me.pnlCreatureItem2Bkgnd.Name = "pnlCreatureItem2Bkgnd"
            Me.pnlCreatureItem2Bkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlCreatureItem2Bkgnd.TabIndex = 6
            '
            'pnlCreatureItem3Bkgnd
            '
            Me.pnlCreatureItem3Bkgnd.AllowDrop = True
            Me.pnlCreatureItem3Bkgnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlCreatureItem3Bkgnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCreatureItem3Bkgnd.Location = New System.Drawing.Point(162, 11)
            Me.pnlCreatureItem3Bkgnd.Name = "pnlCreatureItem3Bkgnd"
            Me.pnlCreatureItem3Bkgnd.Size = New System.Drawing.Size(70, 70)
            Me.pnlCreatureItem3Bkgnd.TabIndex = 6
            '
            'pnlTrash
            '
            Me.pnlTrash.AllowDrop = True
            Me.pnlTrash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTrash.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlTrash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTrash.Location = New System.Drawing.Point(356, 192)
            Me.pnlTrash.Name = "pnlTrash"
            Me.pnlTrash.Size = New System.Drawing.Size(64, 64)
            Me.pnlTrash.TabIndex = 1
            '
            'TabControl2
            '
            Me.TabControl2.Controls.Add(Me.TabPage3)
            Me.TabControl2.Controls.Add(Me.TabPage4)
            Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Left
            Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl2.Location = New System.Drawing.Point(0, 0)
            Me.TabControl2.Name = "TabControl2"
            Me.TabControl2.SelectedIndex = 0
            Me.TabControl2.Size = New System.Drawing.Size(222, 454)
            Me.TabControl2.TabIndex = 0
            '
            'TabPage3
            '
            Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage3.Controls.Add(Me.TreeView)
            Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New System.Drawing.Size(214, 428)
            Me.TabPage3.TabIndex = 0
            Me.TabPage3.Text = "Game Items"
            '
            'TabPage4
            '
            Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage4.Location = New System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Size = New System.Drawing.Size(214, 394)
            Me.TabPage4.TabIndex = 1
            Me.TabPage4.Text = "Custom Items"
            '
            'pnlRightSide
            '
            Me.pnlRightSide.AutoScroll = True
            Me.pnlRightSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlRightSide.Controls.Add(Me.lblPackItems)
            Me.pnlRightSide.Controls.Add(Me.TabControl1)
            Me.pnlRightSide.Controls.Add(Me.pnlTrash)
            Me.pnlRightSide.Controls.Add(Me.dgPackItems)
            Me.pnlRightSide.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRightSide.Location = New System.Drawing.Point(222, 0)
            Me.pnlRightSide.Name = "pnlRightSide"
            Me.pnlRightSide.Size = New System.Drawing.Size(450, 454)
            Me.pnlRightSide.TabIndex = 2
            '
            'lblPackItems
            '
            Me.lblPackItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPackItems.BackColor = System.Drawing.Color.Transparent
            Me.lblPackItems.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPackItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblPackItems.Location = New System.Drawing.Point(12, 286)
            Me.lblPackItems.Name = "lblPackItems"
            Me.lblPackItems.Size = New System.Drawing.Size(426, 18)
            Me.lblPackItems.TabIndex = 3
            Me.lblPackItems.Text = "Pack Inventory"
            Me.lblPackItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlRoot
            '
            Me.pnlRoot.Controls.Add(Me.Splitter1)
            Me.pnlRoot.Controls.Add(Me.pnlRightSide)
            Me.pnlRoot.Controls.Add(Me.TabControl2)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(48, 14)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(672, 454)
            Me.pnlRoot.TabIndex = 0
            '
            'Splitter1
            '
            Me.Splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.Splitter1.Location = New System.Drawing.Point(222, 0)
            Me.Splitter1.MinSize = 192
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(3, 454)
            Me.Splitter1.TabIndex = 1
            Me.Splitter1.TabStop = False
            '
            'pnlOuterRoot
            '
            Me.pnlOuterRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlOuterRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlOuterRoot.Controls.Add(Me.pnlBody)
            Me.pnlOuterRoot.Controls.Add(Me.pnlFooter)
            Me.pnlOuterRoot.Controls.Add(Me.pnlHeader)
            Me.pnlOuterRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlOuterRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlOuterRoot.Name = "pnlOuterRoot"
            Me.pnlOuterRoot.Size = New System.Drawing.Size(736, 594)
            Me.pnlOuterRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.pnlRoot)
            Me.pnlBody.Controls.Add(Me.pnlTreeTools)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(14, 14, 14, 12)
            Me.pnlBody.Size = New System.Drawing.Size(734, 482)
            Me.pnlBody.TabIndex = 1
            '
            'pnlTreeTools
            '
            Me.pnlTreeTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlTreeTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTreeTools.Controls.Add(Me.btnExpandAll)
            Me.pnlTreeTools.Controls.Add(Me.btnCollapseAll)
            Me.pnlTreeTools.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlTreeTools.Location = New System.Drawing.Point(14, 14)
            Me.pnlTreeTools.Name = "pnlTreeTools"
            Me.pnlTreeTools.Size = New System.Drawing.Size(34, 454)
            Me.pnlTreeTools.TabIndex = 1
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(14, 468)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(706, 2)
            Me.lblSeparatorBottom.TabIndex = 2
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 558)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(734, 34)
            Me.pnlFooter.TabIndex = 2
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
            Me.pnlHeader.Size = New System.Drawing.Size(734, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(734, 2)
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
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 45)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(698, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Assign equipped items, natural creature slots, and pack inventory entries."
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
            Me.lblTitle.Location = New System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(700, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Inventory Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmInventoryEditor
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(736, 594)
            Me.Controls.Add(Me.pnlOuterRoot)
            Me.MinimumSize = New System.Drawing.Size(608, 496)
            Me.Name = "frmInventoryEditor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Inventory Editor - KotOR "
            Me.pnlRArm.ResumeLayout(False)
            CType(Me.dgPackItems, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.TabControl2.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            Me.pnlRightSide.ResumeLayout(False)
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlOuterRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlTreeTools.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace