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
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
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
        Private Sub btnInventory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInventory.Click
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
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
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
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetNameLang.Click
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x0600143A RID: 5178 RVA: 0x002B7F60 File Offset: 0x002B6F60
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDebug.Click
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
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditOnOpenStore.Click
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

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
