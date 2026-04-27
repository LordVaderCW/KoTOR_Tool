Namespace kotor_tool
	' Token: 0x02000050 RID: 80
	Public Partial Class frmInventoryEditor
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600058B RID: 1419 RVA: 0x00244BFC File Offset: 0x00243BFC
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060005E8 RID: 1512 RVA: 0x00246034 File Offset: 0x00245034
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmInventoryEditor))
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
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
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
            Dim treeView As Global.System.Windows.Forms.Control = Me.TreeView
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
            treeView.Location = point
            Me.TreeView.Name = "TreeView"
            Me.TreeView.SelectedImageIndex = -1
            Dim treeView2 As Global.System.Windows.Forms.Control = Me.TreeView
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(184, 390)
            treeView2.Size = size
            Me.TreeView.TabIndex = 0
            Me.pnlImplant.AllowDrop = True
            Me.pnlImplant.BackgroundImage = CType(resourceManager.GetObject("pnlImplant.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlImplant As Global.System.Windows.Forms.Control = Me.pnlImplant
            point = New Global.System.Drawing.Point(15, 14)
            pnlImplant.Location = point
            Me.pnlImplant.Name = "pnlImplant"
            Dim pnlImplant2 As Global.System.Windows.Forms.Control = Me.pnlImplant
            size = New Global.System.Drawing.Size(64, 64)
            pnlImplant2.Size = size
            Me.pnlImplant.TabIndex = 2
            Me.cmEquippedItems.MenuItems.AddRange(New Global.System.Windows.Forms.MenuItem() {Me.cmiDropable})
            Me.cmiDropable.Checked = True
            Me.cmiDropable.Index = 0
            Me.cmiDropable.Text = "Dropable"
            Me.pnlHead.AllowDrop = True
            Me.pnlHead.BackgroundImage = CType(resourceManager.GetObject("pnlHead.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlHead As Global.System.Windows.Forms.Control = Me.pnlHead
            point = New Global.System.Drawing.Point(90, 14)
            pnlHead.Location = point
            Me.pnlHead.Name = "pnlHead"
            Dim pnlHead2 As Global.System.Windows.Forms.Control = Me.pnlHead
            size = New Global.System.Drawing.Size(64, 64)
            pnlHead2.Size = size
            Me.pnlHead.TabIndex = 2
            Me.pnlHands.AllowDrop = True
            Me.pnlHands.BackgroundImage = CType(resourceManager.GetObject("pnlHands.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlHands As Global.System.Windows.Forms.Control = Me.pnlHands
            point = New Global.System.Drawing.Point(165, 14)
            pnlHands.Location = point
            Me.pnlHands.Name = "pnlHands"
            Dim pnlHands2 As Global.System.Windows.Forms.Control = Me.pnlHands
            size = New Global.System.Drawing.Size(64, 64)
            pnlHands2.Size = size
            Me.pnlHands.TabIndex = 2
            Me.pnlRArm.AllowDrop = True
            Me.pnlRArm.BackgroundImage = CType(resourceManager.GetObject("pnlRArm.BackgroundImage"), Global.System.Drawing.Image)
            Me.pnlRArm.Controls.Add(Me.Panel8)
            Dim pnlRArm As Global.System.Windows.Forms.Control = Me.pnlRArm
            point = New Global.System.Drawing.Point(165, 88)
            pnlRArm.Location = point
            Me.pnlRArm.Name = "pnlRArm"
            Dim pnlRArm2 As Global.System.Windows.Forms.Control = Me.pnlRArm
            size = New Global.System.Drawing.Size(64, 64)
            pnlRArm2.Size = size
            Me.pnlRArm.TabIndex = 2
            Me.Panel8.AllowDrop = True
            Me.Panel8.BackgroundImage = CType(resourceManager.GetObject("Panel8.BackgroundImage"), Global.System.Drawing.Image)
            Dim panel As Global.System.Windows.Forms.Control = Me.Panel8
            point = New Global.System.Drawing.Point(-144, -8)
            panel.Location = point
            Me.Panel8.Name = "Panel8"
            Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel8
            size = New Global.System.Drawing.Size(94, 70)
            panel2.Size = size
            Me.Panel8.TabIndex = 2
            Me.pnlLArm.AllowDrop = True
            Me.pnlLArm.BackgroundImage = CType(resourceManager.GetObject("pnlLArm.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlLArm As Global.System.Windows.Forms.Control = Me.pnlLArm
            point = New Global.System.Drawing.Point(15, 88)
            pnlLArm.Location = point
            Me.pnlLArm.Name = "pnlLArm"
            Dim pnlLArm2 As Global.System.Windows.Forms.Control = Me.pnlLArm
            size = New Global.System.Drawing.Size(64, 64)
            pnlLArm2.Size = size
            Me.pnlLArm.TabIndex = 2
            Me.pnlArmor.AllowDrop = True
            Me.pnlArmor.BackgroundImage = CType(resourceManager.GetObject("pnlArmor.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlArmor As Global.System.Windows.Forms.Control = Me.pnlArmor
            point = New Global.System.Drawing.Point(90, 88)
            pnlArmor.Location = point
            Me.pnlArmor.Name = "pnlArmor"
            Dim pnlArmor2 As Global.System.Windows.Forms.Control = Me.pnlArmor
            size = New Global.System.Drawing.Size(64, 64)
            pnlArmor2.Size = size
            Me.pnlArmor.TabIndex = 2
            Me.pnlRWeapon.AllowDrop = True
            Me.pnlRWeapon.BackgroundImage = CType(resourceManager.GetObject("pnlRWeapon.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlRWeapon As Global.System.Windows.Forms.Control = Me.pnlRWeapon
            point = New Global.System.Drawing.Point(165, 162)
            pnlRWeapon.Location = point
            Me.pnlRWeapon.Name = "pnlRWeapon"
            Dim pnlRWeapon2 As Global.System.Windows.Forms.Control = Me.pnlRWeapon
            size = New Global.System.Drawing.Size(64, 64)
            pnlRWeapon2.Size = size
            Me.pnlRWeapon.TabIndex = 2
            Me.pnlLWeapon.AllowDrop = True
            Me.pnlLWeapon.BackgroundImage = CType(resourceManager.GetObject("pnlLWeapon.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlLWeapon As Global.System.Windows.Forms.Control = Me.pnlLWeapon
            point = New Global.System.Drawing.Point(15, 162)
            pnlLWeapon.Location = point
            Me.pnlLWeapon.Name = "pnlLWeapon"
            Dim pnlLWeapon2 As Global.System.Windows.Forms.Control = Me.pnlLWeapon
            size = New Global.System.Drawing.Size(64, 64)
            pnlLWeapon2.Size = size
            Me.pnlLWeapon.TabIndex = 2
            Me.pnlBelt.AllowDrop = True
            Me.pnlBelt.BackgroundImage = CType(resourceManager.GetObject("pnlBelt.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlBelt As Global.System.Windows.Forms.Control = Me.pnlBelt
            point = New Global.System.Drawing.Point(90, 162)
            pnlBelt.Location = point
            Me.pnlBelt.Name = "pnlBelt"
            Dim pnlBelt2 As Global.System.Windows.Forms.Control = Me.pnlBelt
            size = New Global.System.Drawing.Size(64, 64)
            pnlBelt2.Size = size
            Me.pnlBelt.TabIndex = 2
            Me.ToolTip1.AutoPopDelay = 5000
            Me.ToolTip1.InitialDelay = 250
            Me.ToolTip1.ReshowDelay = 100
            Me.btnCollapseAll.Image = CType(resourceManager.GetObject("btnCollapseAll.Image"), Global.System.Drawing.Image)
            Dim btnCollapseAll As Global.System.Windows.Forms.Control = Me.btnCollapseAll
            point = New Global.System.Drawing.Point(5, 104)
            btnCollapseAll.Location = point
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Dim btnCollapseAll2 As Global.System.Windows.Forms.Control = Me.btnCollapseAll
            size = New Global.System.Drawing.Size(24, 23)
            btnCollapseAll2.Size = size
            Me.btnCollapseAll.TabIndex = 12
            Me.btnCollapseAll.Text = "C"
            Me.ToolTip1.SetToolTip(Me.btnCollapseAll, "Collapse all nodes in the treeview")
            Me.btnExpandAll.Image = CType(resourceManager.GetObject("btnExpandAll.Image"), Global.System.Drawing.Image)
            Dim btnExpandAll As Global.System.Windows.Forms.Control = Me.btnExpandAll
            point = New Global.System.Drawing.Point(5, 48)
            btnExpandAll.Location = point
            Me.btnExpandAll.Name = "btnExpandAll"
            Dim btnExpandAll2 As Global.System.Windows.Forms.Control = Me.btnExpandAll
            size = New Global.System.Drawing.Size(24, 23)
            btnExpandAll2.Size = size
            Me.btnExpandAll.TabIndex = 11
            Me.btnExpandAll.Text = "E"
            Me.ToolTip1.SetToolTip(Me.btnExpandAll, "Expand all nodes in the treeview")
            Me.dgPackItems.AllowDrop = True
            Me.dgPackItems.DataMember = ""
            Me.dgPackItems.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Dim dgPackItems As Global.System.Windows.Forms.Control = Me.dgPackItems
            point = New Global.System.Drawing.Point(0, 296)
            dgPackItems.Location = point
            Me.dgPackItems.Name = "dgPackItems"
            Dim dgPackItems2 As Global.System.Windows.Forms.Control = Me.dgPackItems
            size = New Global.System.Drawing.Size(352, 120)
            dgPackItems2.Size = size
            Me.dgPackItems.TabIndex = 4
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(392, 440)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 5
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(488, 440)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "Cancel"
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
            point = New Global.System.Drawing.Point(16, 0)
            tabControl.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
            size = New Global.System.Drawing.Size(256, 288)
            tabControl2.Size = size
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
            Dim tabPage As Global.System.Windows.Forms.Control = Me.TabPage1
            point = New Global.System.Drawing.Point(4, 22)
            tabPage.Location = point
            Me.TabPage1.Name = "TabPage1"
            Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
            size = New Global.System.Drawing.Size(248, 262)
            tabPage2.Size = size
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Standard Items"
            Me.pnlImplantBkgnd.AllowDrop = True
            Me.pnlImplantBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlImplantBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlImplantBkgnd As Global.System.Windows.Forms.Control = Me.pnlImplantBkgnd
            point = New Global.System.Drawing.Point(12, 11)
            pnlImplantBkgnd.Location = point
            Me.pnlImplantBkgnd.Name = "pnlImplantBkgnd"
            Dim pnlImplantBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlImplantBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlImplantBkgnd2.Size = size
            Me.pnlImplantBkgnd.TabIndex = 2
            Me.pnlHeadBkgnd.AllowDrop = True
            Me.pnlHeadBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlHeadBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlHeadBkgnd As Global.System.Windows.Forms.Control = Me.pnlHeadBkgnd
            point = New Global.System.Drawing.Point(87, 11)
            pnlHeadBkgnd.Location = point
            Me.pnlHeadBkgnd.Name = "pnlHeadBkgnd"
            Dim pnlHeadBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlHeadBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlHeadBkgnd2.Size = size
            Me.pnlHeadBkgnd.TabIndex = 2
            Me.pnlHandsBkgnd.AllowDrop = True
            Me.pnlHandsBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlHandsBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlHandsBkgnd As Global.System.Windows.Forms.Control = Me.pnlHandsBkgnd
            point = New Global.System.Drawing.Point(162, 11)
            pnlHandsBkgnd.Location = point
            Me.pnlHandsBkgnd.Name = "pnlHandsBkgnd"
            Dim pnlHandsBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlHandsBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlHandsBkgnd2.Size = size
            Me.pnlHandsBkgnd.TabIndex = 2
            Me.pnlLArmBkgnd.AllowDrop = True
            Me.pnlLArmBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlLArmBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlLArmBkgnd As Global.System.Windows.Forms.Control = Me.pnlLArmBkgnd
            point = New Global.System.Drawing.Point(12, 85)
            pnlLArmBkgnd.Location = point
            Me.pnlLArmBkgnd.Name = "pnlLArmBkgnd"
            Dim pnlLArmBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlLArmBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlLArmBkgnd2.Size = size
            Me.pnlLArmBkgnd.TabIndex = 5
            Me.pnlArmorBkgnd.AllowDrop = True
            Me.pnlArmorBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlArmorBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlArmorBkgnd As Global.System.Windows.Forms.Control = Me.pnlArmorBkgnd
            point = New Global.System.Drawing.Point(87, 85)
            pnlArmorBkgnd.Location = point
            Me.pnlArmorBkgnd.Name = "pnlArmorBkgnd"
            Dim pnlArmorBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlArmorBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlArmorBkgnd2.Size = size
            Me.pnlArmorBkgnd.TabIndex = 4
            Me.pnlRArmBkgnd.AllowDrop = True
            Me.pnlRArmBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlRArmBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlRArmBkgnd As Global.System.Windows.Forms.Control = Me.pnlRArmBkgnd
            point = New Global.System.Drawing.Point(162, 85)
            pnlRArmBkgnd.Location = point
            Me.pnlRArmBkgnd.Name = "pnlRArmBkgnd"
            Dim pnlRArmBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlRArmBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlRArmBkgnd2.Size = size
            Me.pnlRArmBkgnd.TabIndex = 3
            Me.pnlLWeaponBkgnd.AllowDrop = True
            Me.pnlLWeaponBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlLWeaponBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlLWeaponBkgnd As Global.System.Windows.Forms.Control = Me.pnlLWeaponBkgnd
            point = New Global.System.Drawing.Point(12, 159)
            pnlLWeaponBkgnd.Location = point
            Me.pnlLWeaponBkgnd.Name = "pnlLWeaponBkgnd"
            Dim pnlLWeaponBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlLWeaponBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlLWeaponBkgnd2.Size = size
            Me.pnlLWeaponBkgnd.TabIndex = 8
            Me.pnlBeltBkgnd.AllowDrop = True
            Me.pnlBeltBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlBeltBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlBeltBkgnd As Global.System.Windows.Forms.Control = Me.pnlBeltBkgnd
            point = New Global.System.Drawing.Point(87, 159)
            pnlBeltBkgnd.Location = point
            Me.pnlBeltBkgnd.Name = "pnlBeltBkgnd"
            Dim pnlBeltBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlBeltBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlBeltBkgnd2.Size = size
            Me.pnlBeltBkgnd.TabIndex = 7
            Me.pnlRWeaponBkgnd.AllowDrop = True
            Me.pnlRWeaponBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlRWeaponBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlRWeaponBkgnd As Global.System.Windows.Forms.Control = Me.pnlRWeaponBkgnd
            point = New Global.System.Drawing.Point(162, 159)
            pnlRWeaponBkgnd.Location = point
            Me.pnlRWeaponBkgnd.Name = "pnlRWeaponBkgnd"
            Dim pnlRWeaponBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlRWeaponBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlRWeaponBkgnd2.Size = size
            Me.pnlRWeaponBkgnd.TabIndex = 6
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem1)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem3)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem2)
            Me.TabPage2.Controls.Add(Me.pnlCreatureHide)
            Me.TabPage2.Controls.Add(Me.pnlCreatureHideBkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem1Bkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem2Bkgnd)
            Me.TabPage2.Controls.Add(Me.pnlCreatureItem3Bkgnd)
            Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage2
            point = New Global.System.Drawing.Point(4, 22)
            tabPage3.Location = point
            Me.TabPage2.Name = "TabPage2"
            Dim tabPage4 As Global.System.Windows.Forms.Control = Me.TabPage2
            size = New Global.System.Drawing.Size(248, 262)
            tabPage4.Size = size
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Natural Items"
            Me.pnlCreatureItem1.AllowDrop = True
            Me.pnlCreatureItem1.BackgroundImage = CType(resourceManager.GetObject("pnlCreatureItem1.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlCreatureItem As Global.System.Windows.Forms.Control = Me.pnlCreatureItem1
            point = New Global.System.Drawing.Point(15, 14)
            pnlCreatureItem.Location = point
            Me.pnlCreatureItem1.Name = "pnlCreatureItem1"
            Dim pnlCreatureItem2 As Global.System.Windows.Forms.Control = Me.pnlCreatureItem1
            size = New Global.System.Drawing.Size(64, 64)
            pnlCreatureItem2.Size = size
            Me.pnlCreatureItem1.TabIndex = 4
            Me.pnlCreatureItem3.AllowDrop = True
            Me.pnlCreatureItem3.BackgroundImage = CType(resourceManager.GetObject("pnlCreatureItem3.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlCreatureItem3 As Global.System.Windows.Forms.Control = Me.pnlCreatureItem3
            point = New Global.System.Drawing.Point(165, 14)
            pnlCreatureItem3.Location = point
            Me.pnlCreatureItem3.Name = "pnlCreatureItem3"
            Dim pnlCreatureItem4 As Global.System.Windows.Forms.Control = Me.pnlCreatureItem3
            size = New Global.System.Drawing.Size(64, 64)
            pnlCreatureItem4.Size = size
            Me.pnlCreatureItem3.TabIndex = 3
            Me.pnlCreatureItem2.AllowDrop = True
            Me.pnlCreatureItem2.BackgroundImage = CType(resourceManager.GetObject("pnlCreatureItem2.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlCreatureItem5 As Global.System.Windows.Forms.Control = Me.pnlCreatureItem2
            point = New Global.System.Drawing.Point(90, 14)
            pnlCreatureItem5.Location = point
            Me.pnlCreatureItem2.Name = "pnlCreatureItem2"
            Dim pnlCreatureItem6 As Global.System.Windows.Forms.Control = Me.pnlCreatureItem2
            size = New Global.System.Drawing.Size(64, 64)
            pnlCreatureItem6.Size = size
            Me.pnlCreatureItem2.TabIndex = 4
            Me.pnlCreatureHide.AllowDrop = True
            Me.pnlCreatureHide.BackgroundImage = CType(resourceManager.GetObject("pnlCreatureHide.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlCreatureHide As Global.System.Windows.Forms.Control = Me.pnlCreatureHide
            point = New Global.System.Drawing.Point(90, 88)
            pnlCreatureHide.Location = point
            Me.pnlCreatureHide.Name = "pnlCreatureHide"
            Dim pnlCreatureHide2 As Global.System.Windows.Forms.Control = Me.pnlCreatureHide
            size = New Global.System.Drawing.Size(64, 64)
            pnlCreatureHide2.Size = size
            Me.pnlCreatureHide.TabIndex = 4
            Me.pnlCreatureHideBkgnd.AllowDrop = True
            Me.pnlCreatureHideBkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlCreatureHideBkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlCreatureHideBkgnd As Global.System.Windows.Forms.Control = Me.pnlCreatureHideBkgnd
            point = New Global.System.Drawing.Point(87, 85)
            pnlCreatureHideBkgnd.Location = point
            Me.pnlCreatureHideBkgnd.Name = "pnlCreatureHideBkgnd"
            Dim pnlCreatureHideBkgnd2 As Global.System.Windows.Forms.Control = Me.pnlCreatureHideBkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlCreatureHideBkgnd2.Size = size
            Me.pnlCreatureHideBkgnd.TabIndex = 6
            Me.pnlCreatureItem1Bkgnd.AllowDrop = True
            Me.pnlCreatureItem1Bkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlCreatureItem1Bkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlCreatureItem1Bkgnd As Global.System.Windows.Forms.Control = Me.pnlCreatureItem1Bkgnd
            point = New Global.System.Drawing.Point(12, 11)
            pnlCreatureItem1Bkgnd.Location = point
            Me.pnlCreatureItem1Bkgnd.Name = "pnlCreatureItem1Bkgnd"
            Dim pnlCreatureItem1Bkgnd2 As Global.System.Windows.Forms.Control = Me.pnlCreatureItem1Bkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlCreatureItem1Bkgnd2.Size = size
            Me.pnlCreatureItem1Bkgnd.TabIndex = 6
            Me.pnlCreatureItem2Bkgnd.AllowDrop = True
            Me.pnlCreatureItem2Bkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlCreatureItem2Bkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlCreatureItem2Bkgnd As Global.System.Windows.Forms.Control = Me.pnlCreatureItem2Bkgnd
            point = New Global.System.Drawing.Point(87, 11)
            pnlCreatureItem2Bkgnd.Location = point
            Me.pnlCreatureItem2Bkgnd.Name = "pnlCreatureItem2Bkgnd"
            Dim pnlCreatureItem2Bkgnd2 As Global.System.Windows.Forms.Control = Me.pnlCreatureItem2Bkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlCreatureItem2Bkgnd2.Size = size
            Me.pnlCreatureItem2Bkgnd.TabIndex = 6
            Me.pnlCreatureItem3Bkgnd.AllowDrop = True
            Me.pnlCreatureItem3Bkgnd.BackgroundImage = CType(resourceManager.GetObject("pnlCreatureItem3Bkgnd.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlCreatureItem3Bkgnd As Global.System.Windows.Forms.Control = Me.pnlCreatureItem3Bkgnd
            point = New Global.System.Drawing.Point(162, 11)
            pnlCreatureItem3Bkgnd.Location = point
            Me.pnlCreatureItem3Bkgnd.Name = "pnlCreatureItem3Bkgnd"
            Dim pnlCreatureItem3Bkgnd2 As Global.System.Windows.Forms.Control = Me.pnlCreatureItem3Bkgnd
            size = New Global.System.Drawing.Size(70, 70)
            pnlCreatureItem3Bkgnd2.Size = size
            Me.pnlCreatureItem3Bkgnd.TabIndex = 6
            Me.pnlTrash.AllowDrop = True
            Me.pnlTrash.BackgroundImage = CType(resourceManager.GetObject("pnlTrash.BackgroundImage"), Global.System.Drawing.Image)
            Dim pnlTrash As Global.System.Windows.Forms.Control = Me.pnlTrash
            point = New Global.System.Drawing.Point(288, 184)
            pnlTrash.Location = point
            Me.pnlTrash.Name = "pnlTrash"
            Dim pnlTrash2 As Global.System.Windows.Forms.Control = Me.pnlTrash
            size = New Global.System.Drawing.Size(64, 64)
            pnlTrash2.Size = size
            Me.pnlTrash.TabIndex = 2
            Me.TabControl2.Controls.Add(Me.TabPage3)
            Me.TabControl2.Controls.Add(Me.TabPage4)
            Me.TabControl2.Dock = Global.System.Windows.Forms.DockStyle.Left
            Dim tabControl3 As Global.System.Windows.Forms.Control = Me.TabControl2
            point = New Global.System.Drawing.Point(0, 0)
            tabControl3.Location = point
            Me.TabControl2.Name = "TabControl2"
            Me.TabControl2.SelectedIndex = 0
            Dim tabControl4 As Global.System.Windows.Forms.Control = Me.TabControl2
            size = New Global.System.Drawing.Size(192, 416)
            tabControl4.Size = size
            Me.TabControl2.TabIndex = 8
            Me.TabPage3.Controls.Add(Me.TreeView)
            Dim tabPage5 As Global.System.Windows.Forms.Control = Me.TabPage3
            point = New Global.System.Drawing.Point(4, 22)
            tabPage5.Location = point
            Me.TabPage3.Name = "TabPage3"
            Dim tabPage6 As Global.System.Windows.Forms.Control = Me.TabPage3
            size = New Global.System.Drawing.Size(184, 390)
            tabPage6.Size = size
            Me.TabPage3.TabIndex = 0
            Me.TabPage3.Text = "Game Items"
            Dim tabPage7 As Global.System.Windows.Forms.Control = Me.TabPage4
            point = New Global.System.Drawing.Point(4, 22)
            tabPage7.Location = point
            Me.TabPage4.Name = "TabPage4"
            Dim tabPage8 As Global.System.Windows.Forms.Control = Me.TabPage4
            size = New Global.System.Drawing.Size(184, 406)
            tabPage8.Size = size
            Me.TabPage4.TabIndex = 1
            Me.TabPage4.Text = "Custom Items"
            Me.pnlRightSide.AutoScroll = True
            Me.pnlRightSide.Controls.Add(Me.TabControl1)
            Me.pnlRightSide.Controls.Add(Me.pnlTrash)
            Me.pnlRightSide.Controls.Add(Me.dgPackItems)
            Me.pnlRightSide.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Dim pnlRightSide As Global.System.Windows.Forms.Control = Me.pnlRightSide
            point = New Global.System.Drawing.Point(192, 0)
            pnlRightSide.Location = point
            Me.pnlRightSide.Name = "pnlRightSide"
            Dim pnlRightSide2 As Global.System.Windows.Forms.Control = Me.pnlRightSide
            size = New Global.System.Drawing.Size(352, 416)
            pnlRightSide2.Size = size
            Me.pnlRightSide.TabIndex = 9
            Me.pnlRoot.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.pnlRoot.Controls.Add(Me.Splitter1)
            Me.pnlRoot.Controls.Add(Me.pnlRightSide)
            Me.pnlRoot.Controls.Add(Me.TabControl2)
            Dim pnlRoot As Global.System.Windows.Forms.Control = Me.pnlRoot
            point = New Global.System.Drawing.Point(32, 16)
            pnlRoot.Location = point
            Me.pnlRoot.Name = "pnlRoot"
            Dim pnlRoot2 As Global.System.Windows.Forms.Control = Me.pnlRoot
            size = New Global.System.Drawing.Size(544, 416)
            pnlRoot2.Size = size
            Me.pnlRoot.TabIndex = 10
            Dim splitter As Global.System.Windows.Forms.Control = Me.Splitter1
            point = New Global.System.Drawing.Point(192, 0)
            splitter.Location = point
            Me.Splitter1.MinSize = 192
            Me.Splitter1.Name = "Splitter1"
            Dim splitter2 As Global.System.Windows.Forms.Control = Me.Splitter1
            size = New Global.System.Drawing.Size(3, 416)
            splitter2.Size = size
            Me.Splitter1.TabIndex = 10
            Me.Splitter1.TabStop = False
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(600, 469)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnCollapseAll)
            Me.Controls.Add(Me.btnExpandAll)
            Me.Controls.Add(Me.pnlRoot)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(608, 496)
            Me.MinimumSize = size
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
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000327 RID: 807
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
