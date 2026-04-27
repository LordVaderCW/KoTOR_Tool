Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000080 RID: 128
	Public Partial Class frmUTM_Editor
		Inherits frmParent

		' Token: 0x060013FC RID: 5116 RVA: 0x002B6448 File Offset: 0x002B5448
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTM_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTM_Editor_Closing
			Me.m_bSaveGameMode = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700076A RID: 1898
		' (get) Token: 0x060013FF RID: 5119 RVA: 0x002B64F8 File Offset: 0x002B54F8
		' (set) Token: 0x060013FE RID: 5118 RVA: 0x002B64A4 File Offset: 0x002B54A4
		Friend Overridable Property btnSave As Button
			Get
				Return Me._btnSave
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSave IsNot Nothing Then
                    RemoveHandler Me._btnSave.Click, AddressOf Me.btnSave_Click
                End If
                Me._btnSave = value
                If Me._btnSave IsNot Nothing Then
                    AddHandler Me._btnSave.Click, AddressOf Me.btnSave_Click
                End If
            End Set
        End Property

        ' Token: 0x1700076B RID: 1899
        ' (get) Token: 0x06001400 RID: 5120 RVA: 0x002B6560 File Offset: 0x002B5560
        ' (set) Token: 0x06001401 RID: 5121 RVA: 0x002B650C File Offset: 0x002B550C
        Friend Overridable Property btnCancel() As Button
            Get
                Return Me._btnCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, AddressOf Me.btnCancel_Click
                End If
                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, AddressOf Me.btnCancel_Click
                End If
            End Set
        End Property

        ' Token: 0x1700076C RID: 1900
        ' (get) Token: 0x06001402 RID: 5122 RVA: 0x002B6574 File Offset: 0x002B5574
        ' (set) Token: 0x06001403 RID: 5123 RVA: 0x002B6588 File Offset: 0x002B5588
        Friend Overridable Property btnInventory() As Button
            Get
                Return Me._btnInventory
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnInventory IsNot Nothing Then
                    RemoveHandler Me._btnInventory.Click, AddressOf Me.btnInventory_Click
                End If
                Me._btnInventory = value
                If Me._btnInventory IsNot Nothing Then
                    AddHandler Me._btnInventory.Click, AddressOf Me.btnInventory_Click
                End If
            End Set
        End Property

        ' Token: 0x1700076D RID: 1901
        ' (get) Token: 0x06001404 RID: 5124 RVA: 0x002B65DC File Offset: 0x002B55DC
        ' (set) Token: 0x06001405 RID: 5125 RVA: 0x002B65F0 File Offset: 0x002B55F0
        Friend Overridable Property btnSetNameLang() As Button
            Get
                Return Me._btnSetNameLang
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetNameLang IsNot Nothing Then
                    RemoveHandler Me._btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
                End If
                Me._btnSetNameLang = value
                If Me._btnSetNameLang IsNot Nothing Then
                    AddHandler Me._btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
                End If
            End Set
        End Property

        ' Token: 0x1700076E RID: 1902
        ' (get) Token: 0x06001406 RID: 5126 RVA: 0x002B6660 File Offset: 0x002B5660
        ' (set) Token: 0x06001407 RID: 5127 RVA: 0x002B6644 File Offset: 0x002B5644
        Friend Overridable Property tbTag() As TextBox
            Get
                Return Me._tbTag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTag IsNot Nothing Then
                End If
                Me._tbTag = value
                If Me._tbTag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700076F RID: 1903
        ' (get) Token: 0x06001409 RID: 5129 RVA: 0x002B6674 File Offset: 0x002B5674
        ' (set) Token: 0x06001408 RID: 5128 RVA: 0x002B6688 File Offset: 0x002B5688
        Friend Overridable Property tbLocName() As TextBox
            Get
                Return Me._tbLocName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbLocName IsNot Nothing Then
                End If
                Me._tbLocName = value
                If Me._tbLocName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000770 RID: 1904
        ' (get) Token: 0x0600140B RID: 5131 RVA: 0x002B66C0 File Offset: 0x002B56C0
        ' (set) Token: 0x0600140A RID: 5130 RVA: 0x002B66A4 File Offset: 0x002B56A4
        Friend Overridable Property Label1() As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label1 IsNot Nothing Then
                End If
                Me._Label1 = value
                If Me._Label1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000771 RID: 1905
        ' (get) Token: 0x0600140C RID: 5132 RVA: 0x002B66D4 File Offset: 0x002B56D4
        ' (set) Token: 0x0600140D RID: 5133 RVA: 0x002B66E8 File Offset: 0x002B56E8
        Friend Overridable Property Label2() As Label
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label2 IsNot Nothing Then
                End If
                Me._Label2 = value
                If Me._Label2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000772 RID: 1906
        ' (get) Token: 0x0600140E RID: 5134 RVA: 0x002B6704 File Offset: 0x002B5704
        ' (set) Token: 0x0600140F RID: 5135 RVA: 0x002B6718 File Offset: 0x002B5718
        Friend Overridable Property Label3() As Label
            Get
                Return Me._Label3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label3 IsNot Nothing Then
                End If
                Me._Label3 = value
                If Me._Label3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000773 RID: 1907
        ' (get) Token: 0x06001411 RID: 5137 RVA: 0x002B6734 File Offset: 0x002B5734
        ' (set) Token: 0x06001410 RID: 5136 RVA: 0x002B6748 File Offset: 0x002B5748
        Friend Overridable Property Label8() As Label
            Get
                Return Me._Label8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label8 IsNot Nothing Then
                End If
                Me._Label8 = value
                If Me._Label8 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000774 RID: 1908
        ' (get) Token: 0x06001413 RID: 5139 RVA: 0x002B6780 File Offset: 0x002B5780
        ' (set) Token: 0x06001412 RID: 5138 RVA: 0x002B6764 File Offset: 0x002B5764
        Friend Overridable Property Label12() As Label
            Get
                Return Me._Label12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label12 IsNot Nothing Then
                End If
                Me._Label12 = value
                If Me._Label12 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000775 RID: 1909
        ' (get) Token: 0x06001414 RID: 5140 RVA: 0x002B67B0 File Offset: 0x002B57B0
        ' (set) Token: 0x06001415 RID: 5141 RVA: 0x002B6794 File Offset: 0x002B5794
        Friend Overridable Property Label4() As Label
            Get
                Return Me._Label4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label4 IsNot Nothing Then
                End If
                Me._Label4 = value
                If Me._Label4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000776 RID: 1910
        ' (get) Token: 0x06001417 RID: 5143 RVA: 0x002B67C4 File Offset: 0x002B57C4
        ' (set) Token: 0x06001416 RID: 5142 RVA: 0x002B67D8 File Offset: 0x002B57D8
        Friend Overridable Property Label5() As Label
            Get
                Return Me._Label5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label5 IsNot Nothing Then
                End If
                Me._Label5 = value
                If Me._Label5 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000777 RID: 1911
        ' (get) Token: 0x06001418 RID: 5144 RVA: 0x002B67F4 File Offset: 0x002B57F4
        ' (set) Token: 0x06001419 RID: 5145 RVA: 0x002B6808 File Offset: 0x002B5808
        Friend Overridable Property TabControl1() As TabControl
            Get
                Return Me._TabControl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._TabControl1 IsNot Nothing Then
                End If
                Me._TabControl1 = value
                If Me._TabControl1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000778 RID: 1912
        ' (get) Token: 0x0600141A RID: 5146 RVA: 0x002B6840 File Offset: 0x002B5840
        ' (set) Token: 0x0600141B RID: 5147 RVA: 0x002B6824 File Offset: 0x002B5824
        Friend Overridable Property TabPage1() As TabPage
            Get
                Return Me._TabPage1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage1 IsNot Nothing Then
                End If
                Me._TabPage1 = value
                If Me._TabPage1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000779 RID: 1913
        ' (get) Token: 0x0600141C RID: 5148 RVA: 0x002B6870 File Offset: 0x002B5870
        ' (set) Token: 0x0600141D RID: 5149 RVA: 0x002B6854 File Offset: 0x002B5854
        Friend Overridable Property TabPage2() As TabPage
            Get
                Return Me._TabPage2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage2 IsNot Nothing Then
                End If
                Me._TabPage2 = value
                If Me._TabPage2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700077A RID: 1914
        ' (get) Token: 0x0600141E RID: 5150 RVA: 0x002B6884 File Offset: 0x002B5884
        ' (set) Token: 0x0600141F RID: 5151 RVA: 0x002B6898 File Offset: 0x002B5898
        Friend Overridable Property tbComment() As TextBox
            Get
                Return Me._tbComment
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbComment IsNot Nothing Then
                End If
                Me._tbComment = value
                If Me._tbComment IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700077B RID: 1915
        ' (get) Token: 0x06001420 RID: 5152 RVA: 0x002B68D0 File Offset: 0x002B58D0
        ' (set) Token: 0x06001421 RID: 5153 RVA: 0x002B68B4 File Offset: 0x002B58B4
        Friend Overridable Property nudMarkDown() As NumericUpDown
            Get
                Return Me._nudMarkDown
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudMarkDown IsNot Nothing Then
                End If
                Me._nudMarkDown = value
                If Me._nudMarkDown IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700077C RID: 1916
        ' (get) Token: 0x06001423 RID: 5155 RVA: 0x002B6900 File Offset: 0x002B5900
        ' (set) Token: 0x06001422 RID: 5154 RVA: 0x002B68E4 File Offset: 0x002B58E4
        Friend Overridable Property nudMarkUp() As NumericUpDown
            Get
                Return Me._nudMarkUp
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudMarkUp IsNot Nothing Then
                End If
                Me._nudMarkUp = value
                If Me._nudMarkUp IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700077D RID: 1917
        ' (get) Token: 0x06001425 RID: 5157 RVA: 0x002B6930 File Offset: 0x002B5930
        ' (set) Token: 0x06001424 RID: 5156 RVA: 0x002B6914 File Offset: 0x002B5914
        Friend Overridable Property tbOnOpenStore() As TextBox
            Get
                Return Me._tbOnOpenStore
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbOnOpenStore IsNot Nothing Then
                End If
                Me._tbOnOpenStore = value
                If Me._tbOnOpenStore IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700077E RID: 1918
        ' (get) Token: 0x06001426 RID: 5158 RVA: 0x002B6944 File Offset: 0x002B5944
        ' (set) Token: 0x06001427 RID: 5159 RVA: 0x002B6958 File Offset: 0x002B5958
        Friend Overridable Property tbID() As TextBox
            Get
                Return Me._tbID
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbID IsNot Nothing Then
                End If
                Me._tbID = value
                If Me._tbID IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700077F RID: 1919
        ' (get) Token: 0x06001428 RID: 5160 RVA: 0x002B6990 File Offset: 0x002B5990
        ' (set) Token: 0x06001429 RID: 5161 RVA: 0x002B6974 File Offset: 0x002B5974
        Friend Overridable Property Label6() As Label
            Get
                Return Me._Label6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label6 IsNot Nothing Then
                End If
                Me._Label6 = value
                If Me._Label6 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000780 RID: 1920
        ' (get) Token: 0x0600142B RID: 5163 RVA: 0x002B69C0 File Offset: 0x002B59C0
        ' (set) Token: 0x0600142A RID: 5162 RVA: 0x002B69A4 File Offset: 0x002B59A4
        Friend Overridable Property tbResRef() As TextBox
            Get
                Return Me._tbResRef
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbResRef IsNot Nothing Then
                End If
                Me._tbResRef = value
                If Me._tbResRef IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000781 RID: 1921
        ' (get) Token: 0x0600142D RID: 5165 RVA: 0x002B69D4 File Offset: 0x002B59D4
        ' (set) Token: 0x0600142C RID: 5164 RVA: 0x002B69E8 File Offset: 0x002B59E8
        Friend Overridable Property btnDebug() As Button
            Get
                Return Me._btnDebug
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnDebug IsNot Nothing Then
                    RemoveHandler Me._btnDebug.Click, AddressOf Me.btnDebug_Click
                End If
                Me._btnDebug = value
                If Me._btnDebug IsNot Nothing Then
                    AddHandler Me._btnDebug.Click, AddressOf Me.btnDebug_Click
                End If
            End Set
        End Property

        ' Token: 0x17000782 RID: 1922
        ' (get) Token: 0x0600142F RID: 5167 RVA: 0x002B6A3C File Offset: 0x002B5A3C
        ' (set) Token: 0x0600142E RID: 5166 RVA: 0x002B6A50 File Offset: 0x002B5A50
        Friend Overridable Property cmbxBuySellType() As ComboBox
            Get
                Return Me._cmbxBuySellType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxBuySellType IsNot Nothing Then
                End If
                Me._cmbxBuySellType = value
                If Me._cmbxBuySellType IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000783 RID: 1923
        ' (get) Token: 0x06001430 RID: 5168 RVA: 0x002B6AC0 File Offset: 0x002B5AC0
        ' (set) Token: 0x06001431 RID: 5169 RVA: 0x002B6A6C File Offset: 0x002B5A6C
        Friend Overridable Property btnEditOnOpenStore() As Button
            Get
                Return Me._btnEditOnOpenStore
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnEditOnOpenStore IsNot Nothing Then
                    RemoveHandler Me._btnEditOnOpenStore.Click, AddressOf Me.btnEditScript_Click
                End If
                Me._btnEditOnOpenStore = value
                If Me._btnEditOnOpenStore IsNot Nothing Then
                    AddHandler Me._btnEditOnOpenStore.Click, AddressOf Me.btnEditScript_Click
                End If
            End Set
        End Property

        ' Token: 0x06001433 RID: 5171 RVA: 0x002B79EC File Offset: 0x002B69EC
        Public Sub New(ByVal UTMClass As clsUTM, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Merchant Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTM = UTMClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
        End Sub

        ' Token: 0x06001434 RID: 5172 RVA: 0x002B7A9C File Offset: 0x002B6A9C
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x06001435 RID: 5173 RVA: 0x002B7AA4 File Offset: 0x002B6AA4
        Public Sub Setup()
            Me.UTM.SetTextBoxFromCExoLocStringNodeValue(Me.tbLocName, "LocName")
            Me.UTM.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTM.SetTextBoxToNodeValue(Me.tbResRef, "ResRef")
            Me.UTM.SetTextBoxToNodeValue(Me.tbOnOpenStore, "OnOpenStore")
            Dim num As Integer = IntegerType.FromObject(Me.UTM.GetNodeValue("BuySellFlag"))
            Me.cmbxBuySellType.SelectedIndex = num - 1
            Me.UTM.SetTextBoxToNodeValue(Me.tbID, "ID")
            Me.UTM.SetNumericUpDownToNodeValue(Me.nudMarkUp, "MarkUp", 0.0F)
            Me.UTM.SetNumericUpDownToNodeValue(Me.nudMarkDown, "MarkDown", 0.0F)
            Me.UTM.SetTextBoxToNodeValue(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001436 RID: 5174 RVA: 0x002B7B90 File Offset: 0x002B6B90
        Private Sub SetGFFNodeValues()
            Me.UTM.SetCExoLocStringNodeValueFromTextBox(Me.tbLocName, "LocName", Me.NameLang)
            Me.UTM.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTM.SetNodeValueFromTextBox(Me.tbResRef, "ResRef")
            Me.UTM.SetNodeValueFromTextBox(Me.tbOnOpenStore, "OnOpenStore")
            Me.UTM.SetNodeValue("BuySellFlag", Me.cmbxBuySellType.SelectedIndex + 1)
            Me.UTM.SetNodeValueFromTextBox(Me.tbID, "ID")
            Me.UTM.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001437 RID: 5175 RVA: 0x002B7C4C File Offset: 0x002B6C4C
        Private Sub btnInventory_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmInventoryEditor As frmInventoryEditor = New frmInventoryEditor(Me.KotorVersionIndex)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.UTM.GetListItemCount("ItemList") - 1
            For i As Integer = num To num2
                Dim text As String = StringType.FromObject(Me.UTM.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").InventoryRes"))
                Dim flag As Boolean = Not Me.UTM.VerifyNodeExists("ItemList(" + StringType.FromInteger(i) + ").Dropable") OrElse ObjectType.ObjTst(Me.UTM.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").Dropable"), 1, False) = 0
                frmInventoryEditor.AddPackItem(text, flag)
            Next
            frmInventoryEditor.SetFormName(Me.tbResRef.Text + ".utm")
            frmInventoryEditor.ConfigureForPlaceableEditorUse()
            If frmInventoryEditor.ShowDialog() = DialogResult.OK Then
                Dim i As Integer = 0
                Me.UTM.ClearListElements("ItemList")
                Try
                    For Each obj As Object In frmInventoryEditor.GetPackItemsList()
                        Dim inventoryItem As InventoryItem = CType(obj, InventoryItem)
                        Dim num3 As Integer = 1
                        Dim quantity As Integer = inventoryItem._Quantity
                        For j As Integer = num3 To quantity
                            Dim gff_Struct As GFF_Struct = New GFF_Struct()
                            gff_Struct.type = i
                            gff_Struct.fieldCount = 4
                            gff_Struct.fields = New GFF_Field(3) {}
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "InventoryRes", inventoryItem._ResRef)
                            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_word, "Repos_PosX", i)
                            gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_word, "Repos_PosY", 0)
                            gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_byte, "Dropable", 1)
                            If Not Me.UTM.VerifyNodeExists("ItemList") Then
                                Me.UTM.CreateList("", "ItemList")
                            End If
                            Me.UTM.AddListElement("ItemList", gff_Struct)
                            i += 1
                        Next
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
        End Sub

        ' Token: 0x06001438 RID: 5176 RVA: 0x002B7E98 File Offset: 0x002B6E98
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utm", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTM.WriteFile(Me.m_EditingFilePath, "UTM")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x06001439 RID: 5177 RVA: 0x002B7F30 File Offset: 0x002B6F30
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x0600143A RID: 5178 RVA: 0x002B7F60 File Offset: 0x002B6F60
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbResRef.Text + ".utm"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTM.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x0600143B RID: 5179 RVA: 0x002B7FD4 File Offset: 0x002B6FD4
        Private Sub frmUTM_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600143C RID: 5180 RVA: 0x002B7FE8 File Offset: 0x002B6FE8
        Private Sub frmUTM_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600143D RID: 5181 RVA: 0x002B7FFC File Offset: 0x002B6FFC
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Merchant Editor - " + Name
        End Sub

        ' Token: 0x0600143E RID: 5182 RVA: 0x002B8010 File Offset: 0x002B7010
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x040009B3 RID: 2483
        <AccessedThroughProperty("btnSetNameLang")> _
        Private _btnSetNameLang As Button

        ' Token: 0x040009B4 RID: 2484
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x040009B5 RID: 2485
        <AccessedThroughProperty("TabPage2")> _
        Private _TabPage2 As TabPage

        ' Token: 0x040009B6 RID: 2486
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As Button

        ' Token: 0x040009B7 RID: 2487
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x040009B8 RID: 2488
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040009B9 RID: 2489
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x040009BA RID: 2490
        <AccessedThroughProperty("TabPage1")> _
        Private _TabPage1 As TabPage

        ' Token: 0x040009BB RID: 2491
        <AccessedThroughProperty("btnEditOnOpenStore")> _
        Private _btnEditOnOpenStore As Button

        ' Token: 0x040009BC RID: 2492
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x040009BD RID: 2493
        <AccessedThroughProperty("btnInventory")> _
        Private _btnInventory As Button

        ' Token: 0x040009BE RID: 2494
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x040009BF RID: 2495
        <AccessedThroughProperty("tbComment")> _
        Private _tbComment As TextBox

        ' Token: 0x040009C0 RID: 2496
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x040009C1 RID: 2497
        <AccessedThroughProperty("cmbxBuySellType")> _
        Private _cmbxBuySellType As ComboBox

        ' Token: 0x040009C2 RID: 2498
        <AccessedThroughProperty("tbID")> _
        Private _tbID As TextBox

        ' Token: 0x040009C3 RID: 2499
        <AccessedThroughProperty("tbResRef")> _
        Private _tbResRef As TextBox

        ' Token: 0x040009C4 RID: 2500
        <AccessedThroughProperty("tbLocName")> _
        Private _tbLocName As TextBox

        ' Token: 0x040009C5 RID: 2501
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040009C6 RID: 2502
        <AccessedThroughProperty("nudMarkDown")> _
        Private _nudMarkDown As NumericUpDown

        ' Token: 0x040009C7 RID: 2503
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x040009C8 RID: 2504
        <AccessedThroughProperty("nudMarkUp")> _
        Private _nudMarkUp As NumericUpDown

        ' Token: 0x040009C9 RID: 2505
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x040009CA RID: 2506
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

        ' Token: 0x040009CB RID: 2507
        <AccessedThroughProperty("tbOnOpenStore")> _
        Private _tbOnOpenStore As TextBox

        ' Token: 0x040009CC RID: 2508
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040009CE RID: 2510
        Public UTM As clsUTM

        ' Token: 0x040009CF RID: 2511
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x040009D0 RID: 2512
        Private DescriptionLang As Integer

        ' Token: 0x040009D1 RID: 2513
        Private NameLang As Integer

        ' Token: 0x040009D2 RID: 2514
        Private m_bSaveGameMode As Boolean
    End Class
End Namespace
