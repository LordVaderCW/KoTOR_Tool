Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace kotor_tool
	' Token: 0x02000050 RID: 80
	Public Partial Class frmInventoryEditor
		Inherits Form

		' Token: 0x0600058A RID: 1418 RVA: 0x00244B6C File Offset: 0x00243B6C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmInventoryEditor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmInventoryEditor_Closing
			Me.ResRef2NameLookupList = New ArrayList()
			Me.dt = New DataTable()
			Me.MouseDoubleClickTime = LongType.FromObject(ObjectType.MulObj(Registry.CurrentUser.OpenSubKey("Control Panel\mouse").GetValue("DoubleClickSpeed"), 10000))
			Me.InitializeComponent()
		End Sub

        ' Token: 0x060005E9 RID: 1513 RVA: 0x00247A94 File Offset: 0x00246A94
        Public Sub New(ByVal KotorVerIndex As Integer)
            Me.New()
            Me.KotorVersionIndex = KotorVerIndex
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.SetEquippedPanelsToolTips()
            Me.HidePanelIndicators()
            Me.BuildTreeParents()
            Me.BuildDataGrid()
        End Sub

        ' Token: 0x060005EA RID: 1514 RVA: 0x00247B28 File Offset: 0x00246B28
        Private Sub TreeView_ItemDrag(ByVal sender As Object, ByVal e As ItemDragEventArgs)
            Dim treeNode As TreeNode = CType(e.Item, TreeNode)
            Dim text As String = treeNode.Text
            If ObjectType.ObjTst(treeNode.Tag, "", False) <> 0 Then
                text = StringType.FromObject(ObjectType.StrCatObj(text, ObjectType.StrCatObj("|", treeNode.Tag)))
            End If
            Me.DoDragDrop(text, DragDropEffects.Copy Or DragDropEffects.Move)
        End Sub

        ' Token: 0x060005EB RID: 1515 RVA: 0x00247B84 File Offset: 0x00246B84
        Private Sub pnlImplant_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00200")
            End If
        End Sub

        ' Token: 0x060005EC RID: 1516 RVA: 0x00247BAC File Offset: 0x00246BAC
        Private Sub pnlHead_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00001")
            End If
        End Sub

        ' Token: 0x060005ED RID: 1517 RVA: 0x00247BD4 File Offset: 0x00246BD4
        Private Sub pnlHands_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00008")
            End If
        End Sub

        ' Token: 0x060005EE RID: 1518 RVA: 0x00247BFC File Offset: 0x00246BFC
        Private Sub pnlLArm_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00100,0x00180")
            End If
        End Sub

        ' Token: 0x060005EF RID: 1519 RVA: 0x00247C24 File Offset: 0x00246C24
        Private Sub pnlArmor_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00002")
            End If
        End Sub

        ' Token: 0x060005F0 RID: 1520 RVA: 0x00247C4C File Offset: 0x00246C4C
        Private Sub pnlRArm_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00080,0x00180")
            End If
        End Sub

        ' Token: 0x060005F1 RID: 1521 RVA: 0x00247C74 File Offset: 0x00246C74
        Private Sub pnlLWeapon_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00020,0x00030,0x1C030")
            End If
        End Sub

        ' Token: 0x060005F2 RID: 1522 RVA: 0x00247C9C File Offset: 0x00246C9C
        Private Sub pnlBelt_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00400,0x20000")
            End If
        End Sub

        ' Token: 0x060005F3 RID: 1523 RVA: 0x00247CC4 File Offset: 0x00246CC4
        Private Sub pnlRWeapon_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x00010,0x00030,0x1C030")
            End If
        End Sub

        ' Token: 0x060005F4 RID: 1524 RVA: 0x00247CEC File Offset: 0x00246CEC
        Private Sub pnlCreatureHide_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x20000")
            End If
        End Sub

        ' Token: 0x060005F5 RID: 1525 RVA: 0x00247D14 File Offset: 0x00246D14
        Private Sub pnlCreatureItem_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = Me.ShowDragEnterPermission(e, "0x1C030")
            End If
        End Sub

        ' Token: 0x060005F6 RID: 1526 RVA: 0x00247D3C File Offset: 0x00246D3C
        Private Sub dgPackItems_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = DragDropEffects.Copy
            End If
        End Sub

        ' Token: 0x060005F7 RID: 1527 RVA: 0x00247D58 File Offset: 0x00246D58
        Private Function ShowDragEnterPermission(ByVal DragEventArgs As DragEventArgs, ByVal AllowedSlotsString As String) As DragDropEffects
            If Not DragEventArgs.Data.GetDataPresent(DataFormats.Text) Then
                Return DragDropEffects.None
            End If
            Dim array As String() = Strings.Split(StringType.FromObject(DragEventArgs.Data.GetData(GetType(String))), "|", -1, CompareMethod.Binary)
            Dim num As Integer = Strings.InStr(AllowedSlotsString, Strings.Mid(array(2), 4), CompareMethod.Binary)
            If array.Length > 2 AndAlso num > 0 Then
                Return DragDropEffects.Copy
            End If
            Return DragDropEffects.None
        End Function

        ' Token: 0x060005F8 RID: 1528 RVA: 0x00247DC4 File Offset: 0x00246DC4
        Private Sub pnlTrash_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If (e.Data.GetFormats().Length = 1) And e.Data.GetFormats()(0).ToString().EndsWith("InventoryPanel") Then
                e.Effect = DragDropEffects.Move
            End If
        End Sub

        ' Token: 0x060005F9 RID: 1529 RVA: 0x00247E0C File Offset: 0x00246E0C
        Private Sub pnl_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                Me.ManageEqInventory(StringType.FromObject(e.Data.GetData(GetType(String))), CType(sender, InventoryPanel), True)
            End If
        End Sub

        ' Token: 0x060005FA RID: 1530 RVA: 0x00247E48 File Offset: 0x00246E48
        Private Sub dgPackItems_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.Text) Then
                Dim array As String() = Strings.Split(StringType.FromObject(e.Data.GetData(GetType(String))), "|", -1, CompareMethod.Binary)
                Me.InsertToGridOrIncrement(array(0), array(1), 1, True)
            End If
        End Sub

        ' Token: 0x060005FB RID: 1531 RVA: 0x00247E9C File Offset: 0x00246E9C
        Private Sub pnlTrash_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            If (e.Data.GetFormats().Length = 1) And e.Data.GetFormats()(0).ToString().EndsWith("InventoryPanel") Then
                Dim inventoryPanel As InventoryPanel = CType(e.Data.GetData("kotor_tool.InventoryPanel"), InventoryPanel)
                Me.ToolTip1.SetToolTip(inventoryPanel, "(empty)")
                inventoryPanel.Tag = Nothing
                inventoryPanel.IsEmpty = True
                Try
                    For Each obj As Object In Me.TabPage1.Controls
                        Dim control As Control = CType(obj, Control)
                        If StringType.StrCmp(control.Name, inventoryPanel.Name + "Bkgnd", False) = 0 Then
                            control.Visible = False
                            Return
                        End If
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Try
                    For Each obj2 As Object In Me.TabPage2.Controls
                        Dim control As Control = CType(obj2, Control)
                        If StringType.StrCmp(control.Name, inventoryPanel.Name + "Bkgnd", False) = 0 Then
                            control.Visible = False
                            Exit For
                        End If
                    Next
                Finally
                    Dim enumerator2 As IEnumerator
                    If TypeOf enumerator2 Is IDisposable Then
                        CType(enumerator2, IDisposable).Dispose()
                    End If
                End Try
            End If
        End Sub

        ' Token: 0x060005FC RID: 1532 RVA: 0x00247FFC File Offset: 0x00246FFC
        Public Sub ConfigureForPlaceableEditorUse()
            Me.TabControl1.Visible = False
            Me.TabControl1.Enabled = False
            Me.pnlTrash.Visible = False
            Me.pnlTrash.Enabled = False
            Me.dgPackItems.Dock = DockStyle.Fill
            Me.dgPackItems.CaptionText = "Object Inventory"
        End Sub

        ' Token: 0x060005FD RID: 1533 RVA: 0x00248058 File Offset: 0x00247058
        Private Sub frmInventoryEditor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow()
        End Sub

        ' Token: 0x060005FE RID: 1534 RVA: 0x00248060 File Offset: 0x00247060
        Private Sub frmInventoryEditor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings()
        End Sub

        ' Token: 0x060005FF RID: 1535 RVA: 0x00248068 File Offset: 0x00247068
        Public Sub BuildDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Name", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("ResRef", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Qty", GetType(Integer))
            dataColumn.DefaultValue = 1
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Dropable", GetType(Boolean))
            dataColumn.DefaultValue = True
            Me.dt.Columns.Add(dataColumn)
        End Sub

        ' Token: 0x06000600 RID: 1536 RVA: 0x0024813C File Offset: 0x0024713C
        Public Sub BuildDataGrid()
            Me.BuildDataTable()
            Me.DView = Me.dt.DefaultView
            Me.DView.AllowDelete = True
            Me.DView.AllowNew = False
            Me.DView.AllowEdit = True
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgPackItems.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dt.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Name"
            dataGridTextBoxColumn.HeaderText = "Name"
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "ResRef"
            dataGridTextBoxColumn.HeaderText = "ResRef"
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.CharacterCasing = CharacterCasing.Lower
            dataGridTextBoxColumn.TextBox.MaxLength = 16
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Qty"
            dataGridTextBoxColumn.HeaderText = "Qty"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Dim dataGridBoolColumn As DataGridBoolColumn = New DataGridBoolColumn()
            dataGridBoolColumn.MappingName = "Dropable"
            dataGridBoolColumn.HeaderText = "Dropable"
            dataGridBoolColumn.NullValue = False
            dataGridBoolColumn.AllowNull = False
            dataGridTableStyle.GridColumnStyles.Add(dataGridBoolColumn)
            Me.dgPackItems.TableStyles.Add(dataGridTableStyle)
            Me.dgPackItems.SetDataBinding(Me.DView, Nothing)
            Me.dgPackItems.CaptionText = "Pack Inventory"
            Me.dgPackItems.CaptionFont = New Font("Microsoft Sans Serif", 9.0F)
        End Sub

        ' Token: 0x06000601 RID: 1537 RVA: 0x00248310 File Offset: 0x00247310
        Private Sub TreeView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim treeView As TreeView = Me.TreeView
            Dim treeView2 As TreeView = Me.TreeView
            Dim point As Point = New Point(e.X, e.Y)
            treeView.SelectedNode = treeView2.GetNodeAt(point)
        End Sub

        ' Token: 0x06000602 RID: 1538 RVA: 0x00248348 File Offset: 0x00247348
        Public Sub BuildTreeParents()
            Dim clsChitinKey As clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Dim array As String() = New String(1) {}
            Dim fileStream As FileStream = New FileStream(Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\data\templates.bif", FileMode.Open)
            Dim biffarchive As BIFFArchive = New BIFFArchive(fileStream)
            Dim flag As Boolean = True
            Dim array2 As Byte()
            If Me.CurrentSettings.bUseOverrideFiles Then
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\override\baseitems.2da"
                Try
                    If File.Exists(text) Then
                        Dim fileStream2 As FileStream = New FileStream(text, FileMode.Open)
                        array2 = New Byte(CInt(fileStream2.Length) + 1 - 1) {}
                        fileStream2.Read(array2, 0, CInt(fileStream2.Length))
                        fileStream2.Close()
                        flag = False
                        Console.WriteLine("Read baseitems.2da from override")
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = clsChitinKey.FindResIDForResRef("baseitems", 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + clsChitinKey.BiffList(num >> 20).filename
                array2 = biffarchive.getBIFFResource(text, num).data
                Console.WriteLine("Read baseitems.2da from 2da.bif")
            End If
            Dim clsBaseItems2DA As clsBaseItems2DA = New clsBaseItems2DA(array2)
            Dim itemNamesAndTypesList As ArrayList = clsBaseItems2DA.GetItemNamesAndTypesList(Me.g_clsDialogTlk)
            Dim num2 As Integer = -1
            Dim flag2 As Boolean = False
            Try
                For Each obj As Object In itemNamesAndTypesList
                    Dim treeBaseItem As TreeBaseItem = CType(obj, TreeBaseItem)
                    If StringType.StrCmp(treeBaseItem._itemtype, "****", False) <> 0 Then
                        Dim num3 As Integer = Convert.ToInt32(treeBaseItem._itemtype)
                        If num3 > num2 Then
                            num2 = num3
                        End If
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            num2 += 1
            Me.TreeView.BeginUpdate()
            Me.TreeView.Nodes.Clear()
            Dim num4 As Integer = 0
            Dim num5 As Integer = num2
            For i As Integer = num4 To num5
                Me.TreeView.Nodes.Add(StringType.FromInteger(i))
            Next
            Try
                For Each obj2 As Object In itemNamesAndTypesList
                    Dim treeBaseItem As TreeBaseItem = CType(obj2, TreeBaseItem)
                    If Information.IsNumeric(treeBaseItem._itemtype) Then
                        Dim treeNode As TreeNode = New TreeNode(treeBaseItem._name)
                        treeNode.Tag = "BI=" + StringType.FromInteger(treeBaseItem._index) + "|ES=" + treeBaseItem._slots
                        Me.TreeView.Nodes(IntegerType.FromString(treeBaseItem._itemtype)).Nodes.Add(treeNode)
                    ElseIf treeBaseItem._name.StartsWith("Creature") Then
                        Dim treeNode As TreeNode = New TreeNode(treeBaseItem._name)
                        treeNode.Tag = "BI=" + StringType.FromInteger(treeBaseItem._index) + "|ES=" + treeBaseItem._slots
                        Me.TreeView.Nodes(num2).Nodes.Add(treeNode)
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            Dim keysforResourceType As ArrayList = clsChitinKey.GetKeysforResourceType(frmMain.GetIDForRsrcType("uti"))
            Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
            frmProgressMeter.stepAmount = 1
            frmProgressMeter.maxvalue = keysforResourceType.Count
            frmProgressMeter.message = "Getting Inventory from Warehouse"
            frmProgressMeter.Location = New utilWindowRelativePositioner(Me, frmProgressMeter).getConcentric()
            frmProgressMeter.Show()
            Try
                For Each obj3 As Object In keysforResourceType
                    Dim keyEntry As KeyEntry = CType(obj3, KeyEntry)
                    Dim clsGFF As clsGFF = New clsGFF(biffarchive.getBIFFResource(keyEntry.ResID - (keyEntry.ResID >> 20 << 20)).data, Me.KotorVersionIndex, True)
                    Dim gffexoLocString As GFFExoLocString = CType(clsGFF.GetNodeValue("LocalizedName"), GFFExoLocString)
                    Dim text2 As String
                    If gffexoLocString.StringRef = -1 Then
                        text2 = "(no name)"
                    Else
                        text2 = Me.g_clsDialogTlk.GetString(gffexoLocString.StringRef)
                    End If
                    frmProgressMeter.status = text2
                    frmProgressMeter.stepUp()
                    Dim treeNode2 As TreeNode = New TreeNode(text2)
                    treeNode2.Tag = RuntimeHelpers.GetObjectValue(clsGFF.GetNodeValue("TemplateResRef"))
                    Me.ResRef2NameLookupList.Add(New InventoryItem(text2, StringType.FromObject(treeNode2.Tag), "", 1, True))
                    Dim num3 As Integer = IntegerType.FromObject(clsGFF.GetNodeValue("BaseItem"))
                    flag2 = False
                    Dim num6 As Integer = 0
                    Dim num7 As Integer = num2
                    For i As Integer = num6 To num7
                        Try
                            For Each obj4 As Object In Me.TreeView.Nodes(i).Nodes
                                Dim treeNode As TreeNode = CType(obj4, TreeNode)
                                array = Strings.Split(StringType.FromObject(treeNode.Tag), "|", -1, CompareMethod.Binary)
                                If StringType.StrCmp(array(0), "BI=" + StringType.FromInteger(num3), False) = 0 Then
                                    Dim treeNode3 As TreeNode = treeNode2
                                    treeNode3.Tag = ObjectType.StrCatObj(treeNode3.Tag, "|" + array(1))
                                    treeNode.Nodes.Add(treeNode2)
                                    flag2 = True
                                    Exit For
                                End If
                            Next
                        Finally
                            Dim enumerator4 As IEnumerator
                            If TypeOf enumerator4 Is IDisposable Then
                                CType(enumerator4, IDisposable).Dispose()
                            End If
                        End Try
                        If flag2 Then
                            Exit For
                        End If
                    Next
                Next
            Finally
                Dim enumerator3 As IEnumerator
                If TypeOf enumerator3 Is IDisposable Then
                    CType(enumerator3, IDisposable).Dispose()
                End If
            End Try
            frmProgressMeter.Close()
            fileStream.Close()
            Me.AssignTreeParentTitles()
            If Me.KotorVersionIndex = 0 Then
                Me.RemoveGoofyCreatureItems()
            End If
            Me.RemoveEmptyTreeParents(num2)
            Me.TreeView.EndUpdate()
        End Sub

        ' Token: 0x06000603 RID: 1539 RVA: 0x00248988 File Offset: 0x00247988
        Public Sub RemoveEmptyTreeParents(ByVal Limit As Integer)
            ' The following expression was wrapped in a checked-statement
            For i As Integer = Limit To 0 Step -1
                If Me.TreeView.Nodes(i).Nodes.Count = 0 Then
                    Me.TreeView.Nodes.RemoveAt(i)
                End If
            Next
        End Sub

        ' Token: 0x06000604 RID: 1540 RVA: 0x002489D0 File Offset: 0x002479D0
        Private Sub RemoveGoofyCreatureItems()
            Try
                For Each obj As Object In Me.TreeView.Nodes(48).Nodes
                    Dim treeNode As TreeNode = CType(obj, TreeNode)
                    Try
                        For Each obj2 As Object In treeNode.Nodes
                            Dim treeNode2 As TreeNode = CType(obj2, TreeNode)
                            If treeNode2.Tag.ToString().StartsWith("w_null") Then
                                treeNode.Nodes.Remove(treeNode2)
                            ElseIf treeNode2.Tag.ToString().StartsWith("w_lghtsbr001") Then
                                treeNode.Nodes.Remove(treeNode2)
                            ElseIf treeNode2.Tag.ToString().StartsWith("w_blhvy001") Then
                                treeNode.Nodes.Remove(treeNode2)
                            End If
                        Next
                    Finally
                        Dim enumerator2 As IEnumerator
                        If TypeOf enumerator2 Is IDisposable Then
                            CType(enumerator2, IDisposable).Dispose()
                        End If
                    End Try
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000605 RID: 1541 RVA: 0x00248AF0 File Offset: 0x00247AF0
        Private Sub AssignTreeParentTitles()
            Me.TreeView.Nodes(0).Text = "Handheld Weapons 1"
            Me.TreeView.Nodes(1).Text = "Handheld Weapons 2"
            Me.TreeView.Nodes(2).Text = "Handheld Weapons 3"
            Me.TreeView.Nodes(3).Text = "Blasters"
            Me.TreeView.Nodes(4).Text = "Rifles"
            Me.TreeView.Nodes(5).Text = "Rep. Blasters"
            Me.TreeView.Nodes(6).Text = "Grenades"
            Me.TreeView.Nodes(12).Text = "Droid Utility"
            Me.TreeView.Nodes(13).Text = "Droid Shields"
            Me.TreeView.Nodes(14).Text = "Droid Spike"
            Me.TreeView.Nodes(15).Text = "Droid Plating"
            Me.TreeView.Nodes(16).Text = "Droid Sensors"
            Me.TreeView.Nodes(18).Text = "Masks"
            Me.TreeView.Nodes(19).Text = "Gauntlets"
            Me.TreeView.Nodes(20).Text = "Forearm Bands"
            Me.TreeView.Nodes(21).Text = "Belts"
            Me.TreeView.Nodes(22).Text = "Implants"
            Me.TreeView.Nodes(23).Text = "Credits"
            Me.TreeView.Nodes(24).Text = "Datapads"
            Me.TreeView.Nodes(25).Text = "Stims"
            Me.TreeView.Nodes(26).Text = "Droid Repair"
            Me.TreeView.Nodes(27).Text = "Spikes"
            Me.TreeView.Nodes(28).Text = "Mines"
            Me.TreeView.Nodes(29).Text = "Lighting Devices"
            Me.TreeView.Nodes(30).Text = "Plot Items"
            Me.TreeView.Nodes(31).Text = "Armor Type 1"
            Me.TreeView.Nodes(32).Text = "Armor Type 2"
            Me.TreeView.Nodes(33).Text = "Armor Type 3"
            Me.TreeView.Nodes(34).Text = "Armor Type 4"
            Me.TreeView.Nodes(35).Text = "Armor Type 5"
            Me.TreeView.Nodes(36).Text = "Armor Type 6"
            Me.TreeView.Nodes(37).Text = "Clothing/Disguises"
            Me.TreeView.Nodes(38).Text = "Robes"
            Me.TreeView.Nodes(39).Text = "Double-Bladed Light Sabers"
            Me.TreeView.Nodes(40).Text = "Short Light Sabers"
            Me.TreeView.Nodes(41).Text = "Light Sabers"
            Me.TreeView.Nodes(42).Text = "Pazaak Decks"
            Me.TreeView.Nodes(43).Text = "Pazaak Side Decks"
            Me.TreeView.Nodes(44).Text = "Stealth Items"
            Me.TreeView.Nodes(45).Text = "Medical"
            Me.TreeView.Nodes(46).Text = "Light Saber Crystals"
            Me.TreeView.Nodes(47).Text = "Super Stim Item"
            If Me.KotorVersionIndex = 0 Then
                Me.TreeView.Nodes(48).Text = "Creature Item"
            ElseIf Me.KotorVersionIndex = 1 Then
                Me.TreeView.Nodes(48).Text = "Wrist Items"
                Me.TreeView.Nodes(49).Text = "Rockets"
                Me.TreeView.Nodes(50).Text = "Chemicals"
                Me.TreeView.Nodes(51).Text = "Components"
                Me.TreeView.Nodes(52).Text = "Creature Item"
            End If
        End Sub

        ' Token: 0x06000606 RID: 1542 RVA: 0x00249050 File Offset: 0x00248050
        Public Sub SetEquippedPanelsToolTips()
            Me.ToolTip1.SetToolTip(Me.pnlArmor, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlBelt, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlHands, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlHead, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlImplant, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlLArm, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlLWeapon, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlRArm, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlRWeapon, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlCreatureHide, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlCreatureItem1, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlCreatureItem2, "(empty)")
            Me.ToolTip1.SetToolTip(Me.pnlCreatureItem3, "(empty)")
        End Sub

        ' Token: 0x06000607 RID: 1543 RVA: 0x0024917C File Offset: 0x0024817C
        Private Sub HidePanelIndicators()
            Me.pnlArmorBkgnd.Visible = False
            Me.pnlBeltBkgnd.Visible = False
            Me.pnlHandsBkgnd.Visible = False
            Me.pnlHeadBkgnd.Visible = False
            Me.pnlImplantBkgnd.Visible = False
            Me.pnlLArmBkgnd.Visible = False
            Me.pnlLWeaponBkgnd.Visible = False
            Me.pnlRArmBkgnd.Visible = False
            Me.pnlRWeaponBkgnd.Visible = False
            Me.pnlCreatureHideBkgnd.Visible = False
            Me.pnlCreatureItem1Bkgnd.Visible = False
            Me.pnlCreatureItem2Bkgnd.Visible = False
            Me.pnlCreatureItem3Bkgnd.Visible = False
        End Sub

        ' Token: 0x06000608 RID: 1544 RVA: 0x00249228 File Offset: 0x00248228
        Private Sub ManageEqInventory(ByVal iteminfo As String, ByVal sender As InventoryPanel, ByVal Dropable As Boolean)
            Dim array As String() = Strings.Split(iteminfo, "|", -1, CompareMethod.Binary)
            Me.ToolTip1.SetToolTip(sender, array(0) + " (" + array(1) + ")")
            sender.Tag = array(1)
            sender.Dropable = Dropable
            sender.IsEmpty = False
            Try
                For Each obj As Object In Me.TabPage1.Controls
                    Dim control As Control = CType(obj, Control)
                    If StringType.StrCmp(control.Name, sender.Name + "Bkgnd", False) = 0 Then
                        control.Visible = True
                        Return
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.TabPage2.Controls
                    Dim control As Control = CType(obj2, Control)
                    If StringType.StrCmp(control.Name, sender.Name + "Bkgnd", False) = 0 Then
                        control.Visible = True
                        Exit For
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000609 RID: 1545 RVA: 0x0024936C File Offset: 0x0024836C
        Public Sub PositionWindow()
            Dim point As Point = frmMain.CurrentSettings.InventoryEditorWindowLoc
            If Not point.IsEmpty Then
                Me.Location = frmMain.CurrentSettings.InventoryEditorWindowLoc
            End If
            If Not frmMain.CurrentSettings.InventoryEditorWindowSize.IsEmpty Then
                Dim size As Size = frmMain.CurrentSettings.InventoryEditorWindowSize
                Dim height As Integer
                Dim size2 As Size
                If size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                    point = Me.Location
                    Dim location As Point = New Point(point.X, Screen.PrimaryScreen.WorkingArea.Top)
                    Me.Location = location
                    height = Screen.PrimaryScreen.WorkingArea.Height
                    size = Me.Size
                    size2 = New Size(size.Width, height)
                    Me.Size = size2
                End If
                size2 = frmMain.CurrentSettings.InventoryEditorWindowSize
                Dim width As Integer
                If size2.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                    Dim left As Integer = Screen.PrimaryScreen.WorkingArea.Left
                    Dim location As Point = Me.Location
                    point = New Point(left, location.Y)
                    Me.Location = point
                    width = Screen.PrimaryScreen.WorkingArea.Width
                    Dim num As Integer = width
                    size2 = Me.Size
                    size = New Size(num, size2.Height)
                    Me.Size = size
                End If
                If (width = 0) And (height = 0) Then
                    Me.Size = frmMain.CurrentSettings.InventoryEditorWindowSize
                End If
            End If
        End Sub

        ' Token: 0x0600060A RID: 1546 RVA: 0x002494E4 File Offset: 0x002484E4
        Public Sub SaveSettings()
            frmMain.CurrentSettings.InventoryEditorWindowLoc = Me.Location
            frmMain.CurrentSettings.InventoryEditorWindowSize = Me.Size
        End Sub

        ' Token: 0x0600060B RID: 1547 RVA: 0x00249508 File Offset: 0x00248508
        Public Sub AutoSizeColumns()
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1
            For i As Integer = num To num2
                Me.dgPackItems.TableStyles(0).GridColumnStyles(i).Width = Me.GetColWidth(i, Me.dt.Columns(i).Caption)
            Next
        End Sub

        ' Token: 0x0600060C RID: 1548 RVA: 0x00249574 File Offset: 0x00248574
        Protected Function GetColWidth(ByVal col As Integer, ByVal DisplayName As String) As Integer
            Dim num As Single = 0.0F
            Dim count As Integer = CType(Me.dgPackItems.DataSource, DataView).Count
            Dim graphics As Graphics = graphics.FromHwnd(Me.Handle)
            Dim stringFormat As StringFormat = New StringFormat(stringFormat.GenericTypographic)
            num = graphics.MeasureString(DisplayName, Me.dgPackItems.Font, 500, stringFormat).Width
            Try
                Dim num2 As Integer = 0
                Dim num3 As Integer = count - 1
                For i As Integer = num2 To num3
                    Dim sizeF As SizeF = graphics.MeasureString(Me.dgPackItems(i, col).ToString(), Me.dgPackItems.Font, 500, stringFormat)
                    If sizeF.Width > num Then
                        num = sizeF.Width
                    End If
                Next
                graphics.Dispose()
            Catch ex As System.Exception
                num = 75.0F
            End Try
            Return CInt(Math.Round(CDbl((num + 10.0F))))
        End Function

        ' Token: 0x0600060D RID: 1549 RVA: 0x0024966C File Offset: 0x0024866C
        Private Sub InsertToGridOrIncrement(ByVal Name As String, ByVal ResRef As String, Optional ByVal Qty As Integer = 1, Optional ByVal Dropable As Boolean = True)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Rows.Count - 1
            Dim i As Integer = num
            While i <= num2
                If ObjectType.ObjTst(Me.dgPackItems(i, 1), ResRef, False) = 0 Then
                    Dim dgPackItems As DataGrid = Me.dgPackItems
                    Dim dataGrid As DataGrid = dgPackItems
                    Dim num3 As Integer = i
                    Dim num4 As Integer = num3
                    Dim num5 As Integer = 2
                    dataGrid(num4, num5) = ObjectType.AddObj(dgPackItems(num3, num5), Qty)
                    If Dropable Then
                        Me.dgPackItems(i, 3) = True
                        Return
                    End If
                    Return
                Else
                    i += 1
                End If
            End While
            Dim dataRow As DataRow = Me.dt.NewRow()
            dataRow(0) = Name
            dataRow(1) = ResRef
            dataRow(2) = Qty
            dataRow(3) = Dropable
            Me.dt.Rows.Add(dataRow)
            Me.AutoSizeColumns()
        End Sub

        ' Token: 0x0600060E RID: 1550 RVA: 0x00249740 File Offset: 0x00248740
        Private Function FindNameForResRef(ByVal ResRef As String) As String
            Dim name As String
            Try
                For Each obj As Object In Me.ResRef2NameLookupList
                    Dim inventoryItem As InventoryItem = CType(obj, InventoryItem)
                    If StringType.StrCmp(inventoryItem._ResRef, ResRef, False) = 0 Then
                        name = inventoryItem._Name
                        Exit For
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return name
        End Function

        ' Token: 0x0600060F RID: 1551 RVA: 0x002497B0 File Offset: 0x002487B0
        Public Sub AddPackItem(ByVal ResRef As String, ByVal Dropable As Boolean)
            Me.InsertToGridOrIncrement(Me.FindNameForResRef(ResRef), ResRef, 1, Dropable)
        End Sub

        ' Token: 0x06000610 RID: 1552 RVA: 0x002497C4 File Offset: 0x002487C4
        Public Sub AddEquippedItem(ByVal ResRef As String, ByVal Slot As Integer, ByVal Dropable As Boolean)
            Dim text As String = Me.FindNameForResRef(ResRef) + "|" + ResRef
            If Slot = 512 Then
                Me.ManageEqInventory(text, Me.pnlImplant, Dropable)
            ElseIf Slot = 1 Then
                Me.ManageEqInventory(text, Me.pnlHead, Dropable)
            ElseIf Slot = 8 Then
                Me.ManageEqInventory(text, Me.pnlHands, Dropable)
            ElseIf Slot = 256 Then
                Me.ManageEqInventory(text, Me.pnlLArm, Dropable)
            ElseIf Slot = 2 Then
                Me.ManageEqInventory(text, Me.pnlArmor, Dropable)
            ElseIf Slot = 128 Then
                Me.ManageEqInventory(text, Me.pnlRArm, Dropable)
            ElseIf Slot = 32 Then
                Me.ManageEqInventory(text, Me.pnlLWeapon, Dropable)
            ElseIf Slot = 1024 Then
                Me.ManageEqInventory(text, Me.pnlBelt, Dropable)
            ElseIf Slot = 16 Then
                Me.ManageEqInventory(text, Me.pnlRWeapon, Dropable)
            ElseIf Slot = 16384 Then
                Me.ManageEqInventory(text, Me.pnlCreatureItem1, Dropable)
            ElseIf Slot = 32768 Then
                Me.ManageEqInventory(text, Me.pnlCreatureItem2, Dropable)
            ElseIf Slot = 65536 Then
                Me.ManageEqInventory(text, Me.pnlCreatureItem3, Dropable)
            ElseIf Slot = 131072 Then
                Me.ManageEqInventory(text, Me.pnlCreatureHide, Dropable)
            End If
        End Sub

        ' Token: 0x06000611 RID: 1553 RVA: 0x00249920 File Offset: 0x00248920
        Public Function GetPackItemsList() As ArrayList
            Dim arrayList As ArrayList = New ArrayList()
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Rows.Count - 1
            For i As Integer = num To num2
                arrayList.Add(New InventoryItem("", StringType.FromObject(Me.dgPackItems(i, 1)), "", IntegerType.FromObject(Me.dgPackItems(i, 2)), BooleanType.FromObject(Me.dgPackItems(i, 3))))
            Next
            Return arrayList
        End Function

        ' Token: 0x06000612 RID: 1554 RVA: 0x002499A0 File Offset: 0x002489A0
        'Public Function GetEquippedItemsList() As ArrayList
        '	Return New ArrayList() From { New InventoryItem("", StringType.FromObject(Me.pnlHead.Tag), StringType.FromInteger(1), 1, Me.pnlHead.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlArmor.Tag), StringType.FromInteger(2), 1, Me.pnlArmor.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlHands.Tag), StringType.FromInteger(8), 1, Me.pnlHands.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlRWeapon.Tag), StringType.FromInteger(16), 1, Me.pnlRWeapon.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlLWeapon.Tag), StringType.FromInteger(32), 1, Me.pnlLWeapon.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlRArm.Tag), StringType.FromInteger(128), 1, Me.pnlRArm.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlLArm.Tag), StringType.FromInteger(256), 1, Me.pnlLArm.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlImplant.Tag), StringType.FromInteger(512), 1, Me.pnlImplant.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlBelt.Tag), StringType.FromInteger(1024), 1, Me.pnlBelt.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlCreatureItem1.Tag), StringType.FromInteger(16384), 1, Me.pnlCreatureItem1.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlCreatureItem2.Tag), StringType.FromInteger(32768), 1, Me.pnlCreatureItem2.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlCreatureItem3.Tag), StringType.FromInteger(65536), 1, Me.pnlCreatureItem3.Dropable), New InventoryItem("", StringType.FromObject(Me.pnlCreatureHide.Tag), StringType.FromInteger(131072), 1, Me.pnlCreatureHide.Dropable) }
        'End Function

        ' Token: 0x06000612 RID: 1554 RVA: 0x002499A0 File Offset: 0x002489A0
        Public Function GetEquippedItemsList() As ArrayList

            Dim equippedItems As New ArrayList()

            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlHead.Tag), StringType.FromInteger(1), 1, Me.pnlHead.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlArmor.Tag), StringType.FromInteger(2), 1, Me.pnlArmor.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlHands.Tag), StringType.FromInteger(8), 1, Me.pnlHands.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlRWeapon.Tag), StringType.FromInteger(16), 1, Me.pnlRWeapon.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlLWeapon.Tag), StringType.FromInteger(32), 1, Me.pnlLWeapon.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlRArm.Tag), StringType.FromInteger(128), 1, Me.pnlRArm.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlLArm.Tag), StringType.FromInteger(256), 1, Me.pnlLArm.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlImplant.Tag), StringType.FromInteger(512), 1, Me.pnlImplant.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlBelt.Tag), StringType.FromInteger(1024), 1, Me.pnlBelt.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlCreatureItem1.Tag), StringType.FromInteger(16384), 1, Me.pnlCreatureItem1.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlCreatureItem2.Tag), StringType.FromInteger(32768), 1, Me.pnlCreatureItem2.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlCreatureItem3.Tag), StringType.FromInteger(65536), 1, Me.pnlCreatureItem3.Dropable))
            equippedItems.Add(New InventoryItem("", StringType.FromObject(Me.pnlCreatureHide.Tag), StringType.FromInteger(131072), 1, Me.pnlCreatureHide.Dropable))

            Return equippedItems

        End Function

        ' Token: 0x06000613 RID: 1555 RVA: 0x00249C70 File Offset: 0x00248C70
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Inventory Editor - Kotor "
            If Me.KotorVersionIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.Text = Me.Text + " - " + Name
        End Sub

        ' Token: 0x06000614 RID: 1556 RVA: 0x00249CD8 File Offset: 0x00248CD8
        Private Sub AskForNewCustomResRef(ByVal panel As InventoryPanel)
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.Text = "Set custom item ResRef"
            frmPromptForString.lblMsg.Text = "Enter custom item ResRef:"
            frmPromptForString.tbValue.CharacterCasing = CharacterCasing.Lower
            If frmPromptForString.ShowDialog(Me) = DialogResult.OK Then
                Me.ToolTip1.SetToolTip(panel, "Custom Item (" + Strings.Trim(frmPromptForString.tbValue.Text) + ")")
                panel.Tag = frmPromptForString.tbValue.Text
                panel.IsEmpty = False
                Try
                    For Each obj As Object In Me.TabPage1.Controls
                        Dim control As Control = CType(obj, Control)
                        If StringType.StrCmp(control.Name, panel.Name + "Bkgnd", False) = 0 Then
                            control.Visible = True
                            Exit For
                        End If
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
        End Sub

        ' Token: 0x06000615 RID: 1557 RVA: 0x00249DD8 File Offset: 0x00248DD8
        Private Sub pnlEquipped_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.AskForNewCustomResRef(CType(sender, InventoryPanel))
        End Sub

        ' Token: 0x06000616 RID: 1558 RVA: 0x00249DE8 File Offset: 0x00248DE8
        Private Sub pnl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim inventoryPanel As InventoryPanel = CType(sender, InventoryPanel)
            If Control.MouseButtons = MouseButtons.Right Then
                If Not inventoryPanel.IsEmpty Then
                    Me.cmiDropable.Checked = CType(sender, InventoryPanel).Dropable
                    Me.cmEquippedItems.Show(CType(sender, Control), CType((If(LateBinding.LateGet(sender, Nothing, "PointToClient", New Object() {Control.MousePosition}, Nothing, Nothing), Activator.CreateInstance(GetType(Point)))), Point))
                End If
            Else
                Me.HandlePanelMouseDown(CType(sender, Panel))
            End If
        End Sub

        ' Token: 0x06000617 RID: 1559 RVA: 0x00249E88 File Offset: 0x00248E88
        Private Sub HandlePanelMouseDown(ByVal sender As Panel)
            Dim ticks As Long = DateAndTime.Now.Ticks
            If ObjectType.ObjTst(ticks - Me.MouseDownTime, Me.MouseDoubleClickTime, False) < 0 Then
                Me.AskForNewCustomResRef(CType(sender, InventoryPanel))
            ElseIf ObjectType.ObjTst(sender.Tag, "", False) <> 0 Then
                Me.DoDragDrop(sender, DragDropEffects.Copy Or DragDropEffects.Move)
            End If
            Me.MouseDownTime = ticks
        End Sub

        ' Token: 0x06000618 RID: 1560 RVA: 0x00249EF4 File Offset: 0x00248EF4
        Private Sub dgPackItems_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs)
            Try
                For Each obj As Object In Me.dt.Rows
                    Dim dataRow As DataRow = CType(obj, DataRow)
                    dataRow.EndEdit()
                    Dim flag As Boolean = False
                    Dim flag2 As Boolean = False
                    Dim flag3 As Boolean = False
                    If dataRow(1) Is DBNull.Value Then
                        flag = True
                    End If
                    If dataRow(2) Is DBNull.Value Then
                        flag2 = True
                    End If
                    If ObjectType.ObjTst(dataRow(2), 1, False) < 0 Then
                        flag3 = True
                    End If
                    dataRow.ClearErrors()
                    If flag Then
                        dataRow.SetColumnError(1, "You must enter a ResRef for this item")
                    End If
                    If flag2 Then
                        dataRow.SetColumnError(2, "You must enter a Quantity for this item")
                    End If
                    If flag3 Then
                        dataRow.SetColumnError(2, "You must enter a Quantity >=1 for this item")
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000619 RID: 1561 RVA: 0x00249FD0 File Offset: 0x00248FD0
        Private Sub cmiDropable_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim inventoryPanel As InventoryPanel = CType(LateBinding.LateGet(LateBinding.LateGet(sender, Nothing, "parent", New Object(-1) {}, Nothing, Nothing), Nothing, "sourcecontrol", New Object(-1) {}, Nothing, Nothing), InventoryPanel)
            inventoryPanel.Dropable = Not inventoryPanel.Dropable
        End Sub

        ' Token: 0x0600061A RID: 1562 RVA: 0x0024A01C File Offset: 0x0024901C
        Private Sub btnExpandAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.TreeView.ExpandAll()
            Me.TreeView.SelectedNode = Me.TreeView.Nodes(0)
        End Sub

        ' Token: 0x0600061B RID: 1563 RVA: 0x0024A048 File Offset: 0x00249048
        Private Sub btnCollapseAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.TreeView.CollapseAll()
        End Sub

        ' Token: 0x04000328 RID: 808
        Public CurrentSettings As Options

        ' Token: 0x04000329 RID: 809
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x0400032A RID: 810
        Public ResRef2NameLookupList As ArrayList

        ' Token: 0x0400032B RID: 811
        Private dt As DataTable

        ' Token: 0x0400032C RID: 812
        Private DView As DataView

        ' Token: 0x0400032D RID: 813
        Private MouseDownTime As Long

        ' Token: 0x0400032E RID: 814
        Private MouseDoubleClickTime As Object

        ' Token: 0x0400032F RID: 815
        Private KotorVersionIndex As Integer
    End Class
End Namespace
