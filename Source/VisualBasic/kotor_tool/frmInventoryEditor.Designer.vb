Namespace kotor_tool
	' Token: 0x02000050 RID: 80
	Public Partial Class frmInventoryEditor
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
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


		' Token: 0x0600058B RID: 1419 RVA: 0x00244BFC File Offset: 0x00243BFC
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x060005E8 RID: 1512 RVA: 0x00246034 File Offset: 0x00245034
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmInventoryEditor))
            Me.TreeView = New Global.System.Windows.Forms.TreeView()
            Me.pnlImplant = New Global.kotor_tool.InventoryPanel()
            Me.cmEquippedItems = New Global.System.Windows.Forms.ContextMenu()
            Me.cmiDropable = New Global.System.Windows.Forms.MenuItem()
            Me.pnlHead = New Global.kotor_tool.InventoryPanel()
            Me.pnlHands = New Global.kotor_tool.InventoryPanel()
            Me.pnlRArm = New Global.kotor_tool.InventoryPanel()
            Me.Panel8 = New Global.System.Windows.Forms.Panel()
            Me.pnlLArm = New Global.kotor_tool.InventoryPanel()
            Me.pnlArmor = New Global.kotor_tool.InventoryPanel()
            Me.pnlRWeapon = New Global.kotor_tool.InventoryPanel()
            Me.pnlLWeapon = New Global.kotor_tool.InventoryPanel()
            Me.pnlBelt = New Global.kotor_tool.InventoryPanel()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip()
            Me.btnCollapseAll = New Global.System.Windows.Forms.Button()
            Me.btnExpandAll = New Global.System.Windows.Forms.Button()
            Me.dgPackItems = New Global.System.Windows.Forms.DataGrid()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
            Me.pnlImplantBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlHeadBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlHandsBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlLArmBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlArmorBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlRArmBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlLWeaponBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlBeltBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlRWeaponBkgnd = New Global.System.Windows.Forms.Panel()
            Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
            Me.pnlCreatureItem1 = New Global.kotor_tool.InventoryPanel()
            Me.pnlCreatureItem3 = New Global.kotor_tool.InventoryPanel()
            Me.pnlCreatureItem2 = New Global.kotor_tool.InventoryPanel()
            Me.pnlCreatureHide = New Global.kotor_tool.InventoryPanel()
            Me.pnlCreatureHideBkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlCreatureItem1Bkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlCreatureItem2Bkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlCreatureItem3Bkgnd = New Global.System.Windows.Forms.Panel()
            Me.pnlTrash = New Global.System.Windows.Forms.Panel()
            Me.TabControl2 = New Global.System.Windows.Forms.TabControl()
            Me.TabPage3 = New Global.System.Windows.Forms.TabPage()
            Me.TabPage4 = New Global.System.Windows.Forms.TabPage()
            Me.pnlRightSide = New Global.System.Windows.Forms.Panel()
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.Splitter1 = New Global.System.Windows.Forms.Splitter()
            Me.pnlRArm.SuspendLayout()
            CType(Me.dgPackItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabControl2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.pnlRightSide.SuspendLayout()
            Me.pnlRoot.SuspendLayout()
            Me.SuspendLayout()
            Me.TreeView.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.TreeView.HideSelection = False
            Me.TreeView.ImageIndex = -1
            Me.TreeView.Location = New Global.System.Drawing.Point(0, 0)
            Me.TreeView.Name = "TreeView"
            Me.TreeView.SelectedImageIndex = -1
            Me.TreeView.Size = New Global.System.Drawing.Size(184, 390)
            Me.TreeView.TabIndex = 0
            Me.pnlImplant.AllowDrop = True
            Me.pnlImplant.BackgroundImage = CType(resources.GetObject("Me.pnlImplant.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlImplant.Location = New Global.System.Drawing.Point(15, 14)
            Me.pnlImplant.Name = "pnlImplant"
            Me.pnlImplant.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlImplant.TabIndex = 2
            Me.cmEquippedItems.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiDropable})
            Me.cmiDropable.Checked = True
            Me.cmiDropable.Index = 0
            Me.cmiDropable.Text = "Dropable"
            Me.pnlHead.AllowDrop = True
            Me.pnlHead.BackgroundImage = CType(resources.GetObject("Me.pnlHead.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlHead.Location = New Global.System.Drawing.Point(90, 14)
            Me.pnlHead.Name = "pnlHead"
            Me.pnlHead.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlHead.TabIndex = 2
            Me.pnlHands.AllowDrop = True
            Me.pnlHands.BackgroundImage = CType(resources.GetObject("Me.pnlHands.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlHands.Location = New Global.System.Drawing.Point(165, 14)
            Me.pnlHands.Name = "pnlHands"
            Me.pnlHands.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlHands.TabIndex = 2
            Me.pnlRArm.AllowDrop = True
            Me.pnlRArm.BackgroundImage = CType(resources.GetObject("Me.pnlRArm.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlRArm.Controls.Add(Me.Panel8)
            Me.pnlRArm.Location = New Global.System.Drawing.Point(165, 88)
            Me.pnlRArm.Name = "pnlRArm"
            Me.pnlRArm.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlRArm.TabIndex = 2
            Me.Panel8.AllowDrop = True
            Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Global.System.Drawing.Image)
            Me.Panel8.Location = New Global.System.Drawing.Point(-144, -8)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New Global.System.Drawing.Size(94, 70)
            Me.Panel8.TabIndex = 2
            Me.pnlLArm.AllowDrop = True
            Me.pnlLArm.BackgroundImage = CType(resources.GetObject("Me.pnlLArm.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlLArm.Location = New Global.System.Drawing.Point(15, 88)
            Me.pnlLArm.Name = "pnlLArm"
            Me.pnlLArm.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlLArm.TabIndex = 2
            Me.pnlArmor.AllowDrop = True
            Me.pnlArmor.BackgroundImage = CType(resources.GetObject("Me.pnlArmor.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlArmor.Location = New Global.System.Drawing.Point(90, 88)
            Me.pnlArmor.Name = "pnlArmor"
            Me.pnlArmor.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlArmor.TabIndex = 2
            Me.pnlRWeapon.AllowDrop = True
            Me.pnlRWeapon.BackgroundImage = CType(resources.GetObject("Me.pnlRWeapon.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlRWeapon.Location = New Global.System.Drawing.Point(165, 162)
            Me.pnlRWeapon.Name = "pnlRWeapon"
            Me.pnlRWeapon.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlRWeapon.TabIndex = 2
            Me.pnlLWeapon.AllowDrop = True
            Me.pnlLWeapon.BackgroundImage = CType(resources.GetObject("Me.pnlLWeapon.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlLWeapon.Location = New Global.System.Drawing.Point(15, 162)
            Me.pnlLWeapon.Name = "pnlLWeapon"
            Me.pnlLWeapon.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlLWeapon.TabIndex = 2
            Me.pnlBelt.AllowDrop = True
            Me.pnlBelt.BackgroundImage = CType(resources.GetObject("Me.pnlBelt.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlBelt.Location = New Global.System.Drawing.Point(90, 162)
            Me.pnlBelt.Name = "pnlBelt"
            Me.pnlBelt.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlBelt.TabIndex = 2
            Me.ToolTip1.AutoPopDelay = 5000
            Me.ToolTip1.InitialDelay = 250
            Me.ToolTip1.ReshowDelay = 100
            Me.btnCollapseAll.Image = CType(resources.GetObject("Me.btnCollapseAll.Image"), Global.System.Drawing.Image)
            Me.btnCollapseAll.Location = New Global.System.Drawing.Point(5, 104)
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Me.btnCollapseAll.Size = New Global.System.Drawing.Size(24, 23)
            Me.btnCollapseAll.TabIndex = 12
            Me.btnCollapseAll.Text = "C"
            Me.ToolTip1.SetToolTip(Me.btnCollapseAll, "Collapse all nodes in the treeview")
            Me.btnExpandAll.Image = CType(resources.GetObject("Me.btnExpandAll.Image"), Global.System.Drawing.Image)
            Me.btnExpandAll.Location = New Global.System.Drawing.Point(5, 48)
            Me.btnExpandAll.Name = "btnExpandAll"
            Me.btnExpandAll.Size = New Global.System.Drawing.Size(24, 23)
            Me.btnExpandAll.TabIndex = 11
            Me.btnExpandAll.Text = "E"
            Me.ToolTip1.SetToolTip(Me.btnExpandAll, "Expand all nodes in the treeview")
            Me.dgPackItems.AllowDrop = True
            Me.dgPackItems.DataMember = ""
            Me.dgPackItems.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Me.dgPackItems.Location = New Global.System.Drawing.Point(0, 296)
            Me.dgPackItems.Name = "dgPackItems"
            Me.dgPackItems.Size = New Global.System.Drawing.Size(352, 120)
            Me.dgPackItems.TabIndex = 4
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(392, 440)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 5
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(488, 440)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "Cancel"
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New Global.System.Drawing.Point(16, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(256, 288)
            Me.TabControl1.TabIndex = 7
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
            Me.TabPage1.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Size = New Global.System.Drawing.Size(248, 262)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Standard Items"
            Me.pnlImplantBkgnd.AllowDrop = True
            Me.pnlImplantBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlImplantBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlImplantBkgnd.Location = New Global.System.Drawing.Point(12, 11)
            Me.pnlImplantBkgnd.Name = "pnlImplantBkgnd"
            Me.pnlImplantBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlImplantBkgnd.TabIndex = 2
            Me.pnlHeadBkgnd.AllowDrop = True
            Me.pnlHeadBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlHeadBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlHeadBkgnd.Location = New Global.System.Drawing.Point(87, 11)
            Me.pnlHeadBkgnd.Name = "pnlHeadBkgnd"
            Me.pnlHeadBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlHeadBkgnd.TabIndex = 2
            Me.pnlHandsBkgnd.AllowDrop = True
            Me.pnlHandsBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlHandsBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlHandsBkgnd.Location = New Global.System.Drawing.Point(162, 11)
            Me.pnlHandsBkgnd.Name = "pnlHandsBkgnd"
            Me.pnlHandsBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlHandsBkgnd.TabIndex = 2
            Me.pnlLArmBkgnd.AllowDrop = True
            Me.pnlLArmBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlLArmBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlLArmBkgnd.Location = New Global.System.Drawing.Point(12, 85)
            Me.pnlLArmBkgnd.Name = "pnlLArmBkgnd"
            Me.pnlLArmBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlLArmBkgnd.TabIndex = 5
            Me.pnlArmorBkgnd.AllowDrop = True
            Me.pnlArmorBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlArmorBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlArmorBkgnd.Location = New Global.System.Drawing.Point(87, 85)
            Me.pnlArmorBkgnd.Name = "pnlArmorBkgnd"
            Me.pnlArmorBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlArmorBkgnd.TabIndex = 4
            Me.pnlRArmBkgnd.AllowDrop = True
            Me.pnlRArmBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlRArmBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlRArmBkgnd.Location = New Global.System.Drawing.Point(162, 85)
            Me.pnlRArmBkgnd.Name = "pnlRArmBkgnd"
            Me.pnlRArmBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlRArmBkgnd.TabIndex = 3
            Me.pnlLWeaponBkgnd.AllowDrop = True
            Me.pnlLWeaponBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlLWeaponBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlLWeaponBkgnd.Location = New Global.System.Drawing.Point(12, 159)
            Me.pnlLWeaponBkgnd.Name = "pnlLWeaponBkgnd"
            Me.pnlLWeaponBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlLWeaponBkgnd.TabIndex = 8
            Me.pnlBeltBkgnd.AllowDrop = True
            Me.pnlBeltBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlBeltBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlBeltBkgnd.Location = New Global.System.Drawing.Point(87, 159)
            Me.pnlBeltBkgnd.Name = "pnlBeltBkgnd"
            Me.pnlBeltBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlBeltBkgnd.TabIndex = 7
            Me.pnlRWeaponBkgnd.AllowDrop = True
            Me.pnlRWeaponBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlRWeaponBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlRWeaponBkgnd.Location = New Global.System.Drawing.Point(162, 159)
            Me.pnlRWeaponBkgnd.Name = "pnlRWeaponBkgnd"
            Me.pnlRWeaponBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlRWeaponBkgnd.TabIndex = 6
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem1)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem3)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem2)
            Me.TabPage2.Controls.Add(Me.pnlCreatureHide)
            Me.TabPage2.Controls.Add(Me.pnlCreatureHideBkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem1Bkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem2Bkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem3Bkgnd)
            Me.TabPage2.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New Global.System.Drawing.Size(248, 262)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Natural Items"
            Me.pnlCreatureItem1.AllowDrop = True
            Me.pnlCreatureItem1.BackgroundImage = CType(resources.GetObject("pnlCreatureItem1.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlCreatureItem1.Location = New Global.System.Drawing.Point(15, 14)
            Me.pnlCreatureItem1.Name = "pnlCreatureItem1"
            Me.pnlCreatureItem1.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlCreatureItem1.TabIndex = 4
            Me.pnlCreatureItem3.AllowDrop = True
            Me.pnlCreatureItem3.BackgroundImage = CType(resources.GetObject("Me.pnlCreatureItem3.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlCreatureItem3.Location = New Global.System.Drawing.Point(165, 14)
            Me.pnlCreatureItem3.Name = "pnlCreatureItem3"
            Me.pnlCreatureItem3.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlCreatureItem3.TabIndex = 3
            Me.pnlCreatureItem2.AllowDrop = True
            Me.pnlCreatureItem2.BackgroundImage = CType(resources.GetObject("Me.pnlCreatureItem1.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlCreatureItem2.Location = New Global.System.Drawing.Point(90, 14)
            Me.pnlCreatureItem2.Name = "pnlCreatureItem2"
            Me.pnlCreatureItem2.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlCreatureItem2.TabIndex = 4
            Me.pnlCreatureHide.AllowDrop = True
            Me.pnlCreatureHide.BackgroundImage = CType(resources.GetObject("Me.pnlCreatureHide.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlCreatureHide.Location = New Global.System.Drawing.Point(90, 88)
            Me.pnlCreatureHide.Name = "pnlCreatureHide"
            Me.pnlCreatureHide.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlCreatureHide.TabIndex = 4
            Me.pnlCreatureHideBkgnd.AllowDrop = True
            Me.pnlCreatureHideBkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlCreatureHideBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlCreatureHideBkgnd.Location = New Global.System.Drawing.Point(87, 85)
            Me.pnlCreatureHideBkgnd.Name = "pnlCreatureHideBkgnd"
            Me.pnlCreatureHideBkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlCreatureHideBkgnd.TabIndex = 6
            Me.pnlCreatureItem1Bkgnd.AllowDrop = True
            Me.pnlCreatureItem1Bkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlCreatureItem1Bkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlCreatureItem1Bkgnd.Location = New Global.System.Drawing.Point(12, 11)
            Me.pnlCreatureItem1Bkgnd.Name = "pnlCreatureItem1Bkgnd"
            Me.pnlCreatureItem1Bkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlCreatureItem1Bkgnd.TabIndex = 6
            Me.pnlCreatureItem2Bkgnd.AllowDrop = True
            Me.pnlCreatureItem2Bkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlCreatureItem2Bkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlCreatureItem2Bkgnd.Location = New Global.System.Drawing.Point(87, 11)
            Me.pnlCreatureItem2Bkgnd.Name = "pnlCreatureItem2Bkgnd"
            Me.pnlCreatureItem2Bkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlCreatureItem2Bkgnd.TabIndex = 6
            Me.pnlCreatureItem3Bkgnd.AllowDrop = True
            Me.pnlCreatureItem3Bkgnd.BackgroundImage = CType(resources.GetObject("Me.pnlCreatureItem3Bkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlCreatureItem3Bkgnd.Location = New Global.System.Drawing.Point(162, 11)
            Me.pnlCreatureItem3Bkgnd.Name = "pnlCreatureItem3Bkgnd"
            Me.pnlCreatureItem3Bkgnd.Size = New Global.System.Drawing.Size(70, 70)
            Me.pnlCreatureItem3Bkgnd.TabIndex = 6
            Me.pnlTrash.AllowDrop = True
            Me.pnlTrash.BackgroundImage = CType(resources.GetObject("Me.pnlTrash.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlTrash.Location = New Global.System.Drawing.Point(288, 184)
            Me.pnlTrash.Name = "pnlTrash"
            Me.pnlTrash.Size = New Global.System.Drawing.Size(64, 64)
            Me.pnlTrash.TabIndex = 2
            Me.TabControl2.Controls.Add(Me.TabPage3)
            Me.TabControl2.Controls.Add(Me.TabPage4)
            Me.TabControl2.Dock = Global.System.Windows.Forms.DockStyle.Left
            Me.TabControl2.Location = New Global.System.Drawing.Point(0, 0)
            Me.TabControl2.Name = "TabControl2"
            Me.TabControl2.SelectedIndex = 0
            Me.TabControl2.Size = New Global.System.Drawing.Size(192, 416)
            Me.TabControl2.TabIndex = 8
            Me.TabPage3.Controls.Add(Me.TreeView)
            Me.TabPage3.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Size = New Global.System.Drawing.Size(184, 390)
            Me.TabPage3.TabIndex = 0
            Me.TabPage3.Text = "Game Items"
            Me.TabPage4.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Size = New Global.System.Drawing.Size(184, 406)
            Me.TabPage4.TabIndex = 1
            Me.TabPage4.Text = "Custom Items"
            Me.pnlRightSide.AutoScroll = True
            Me.pnlRightSide.Controls.Add(Me.TabControl1)
            Me.pnlRightSide.Controls.Add(Me.pnlTrash)
            Me.pnlRightSide.Controls.Add(Me.dgPackItems)
            Me.pnlRightSide.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRightSide.Location = New Global.System.Drawing.Point(192, 0)
            Me.pnlRightSide.Name = "pnlRightSide"
            Me.pnlRightSide.Size = New Global.System.Drawing.Size(352, 416)
            Me.pnlRightSide.TabIndex = 9
            Me.pnlRoot.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.pnlRoot.Controls.Add(Me.Splitter1)
            Me.pnlRoot.Controls.Add(Me.pnlRightSide)
            Me.pnlRoot.Controls.Add(Me.TabControl2)
            Me.pnlRoot.Location = New Global.System.Drawing.Point(32, 16)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(544, 416)
            Me.pnlRoot.TabIndex = 10
            Me.Splitter1.Location = New Global.System.Drawing.Point(192, 0)
            Me.Splitter1.MinSize = 192
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New Global.System.Drawing.Size(3, 416)
            Me.Splitter1.TabIndex = 10
            Me.Splitter1.TabStop = False
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(600, 469)
            Me.Controls.Add(Me.btnCollapseAll)
            Me.Controls.Add(Me.btnExpandAll)
            Me.Controls.Add(Me.pnlRoot)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(608, 496)
            Me.Name = "frmInventoryEditor"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Inventory Editor - KotOR "
            Me.pnlRArm.ResumeLayout(False)
            CType(Me.dgPackItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.TabControl2.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            Me.pnlRightSide.ResumeLayout(False)
            Me.pnlRoot.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.TreeView.MouseDown, AddressOf Me.TreeView1_MouseDown
            AddHandler Me.TreeView.ItemDrag, AddressOf Me.TreeView_ItemDrag
            AddHandler Me.pnlImplant.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlImplant.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlImplant.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlImplant.DragEnter, AddressOf Me.pnlImplant_DragEnter
            AddHandler Me.pnlHead.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlHead.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlHead.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlHead.DragEnter, AddressOf Me.pnlHead_DragEnter
            AddHandler Me.pnlHands.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlHands.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlHands.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlHands.DragEnter, AddressOf Me.pnlHands_DragEnter
            AddHandler Me.pnlRArm.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlRArm.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlRArm.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlRArm.DragEnter, AddressOf Me.pnlRArm_DragEnter
            AddHandler Me.pnlLArm.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlLArm.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlLArm.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlLArm.DragEnter, AddressOf Me.pnlLArm_DragEnter
            AddHandler Me.pnlArmor.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlArmor.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlArmor.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlArmor.DragEnter, AddressOf Me.pnlArmor_DragEnter
            AddHandler Me.pnlRWeapon.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlRWeapon.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlRWeapon.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlRWeapon.DragEnter, AddressOf Me.pnlRWeapon_DragEnter
            AddHandler Me.pnlLWeapon.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlLWeapon.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlLWeapon.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlLWeapon.DragEnter, AddressOf Me.pnlLWeapon_DragEnter
            AddHandler Me.pnlBelt.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlBelt.DoubleClick, AddressOf Me.pnlEquipped_DoubleClick
            AddHandler Me.pnlBelt.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlBelt.DragEnter, AddressOf Me.pnlBelt_DragEnter
            AddHandler Me.dgPackItems.CurrentCellChanged, AddressOf Me.dgPackItems_CurrentCellChanged
            AddHandler Me.dgPackItems.DragDrop, AddressOf Me.dgPackItems_DragDrop
            AddHandler Me.dgPackItems.DragEnter, AddressOf Me.dgPackItems_DragEnter
            AddHandler Me.pnlTrash.DragDrop, AddressOf Me.pnlTrash_DragDrop
            AddHandler Me.pnlTrash.DragEnter, AddressOf Me.pnlTrash_DragEnter
            AddHandler Me.cmiDropable.Click, AddressOf Me.cmiDropable_Click
            AddHandler Me.pnlCreatureItem1.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlCreatureItem1.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlCreatureItem1.DragEnter, AddressOf Me.pnlCreatureItem_DragEnter
            AddHandler Me.pnlCreatureItem3.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlCreatureItem3.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlCreatureItem3.DragEnter, AddressOf Me.pnlCreatureItem_DragEnter
            AddHandler Me.pnlCreatureItem2.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlCreatureItem2.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlCreatureItem2.DragEnter, AddressOf Me.pnlCreatureItem_DragEnter
            AddHandler Me.pnlCreatureHide.MouseDown, AddressOf Me.pnl_MouseDown
            AddHandler Me.pnlCreatureHide.DragDrop, AddressOf Me.pnl_DragDrop
            AddHandler Me.pnlCreatureHide.DragEnter, AddressOf Me.pnlCreatureHide_DragEnter
            AddHandler Me.btnCollapseAll.Click, AddressOf Me.btnCollapseAll_Click
            AddHandler Me.btnExpandAll.Click, AddressOf Me.btnExpandAll_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
