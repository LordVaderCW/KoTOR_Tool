Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
    ' Token: 0x02000081 RID: 129
    Partial Public Class frmUTP_Editor
        Inherits frmParent

        ' Token: 0x0600143F RID: 5183 RVA: 0x002B802C File Offset: 0x002B702C
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmUTP_Editor_Load
            AddHandler MyBase.Closing, AddressOf Me.frmUTP_Editor_Closing
            Me.m_bSaveGameMode = False
            Me.InitializeComponent()
        End Sub

        ' Token: 0x0600152E RID: 5422 RVA: 0x002BDD1C File Offset: 0x002BCD1C
        Public Sub New(ByVal UTPClass As clsUTP, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Placeable Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTP = UTPClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
        End Sub

        ' Token: 0x0600152F RID: 5423 RVA: 0x002BDDCC File Offset: 0x002BCDCC
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x06001530 RID: 5424 RVA: 0x002BDDD4 File Offset: 0x002BCDD4
        Public Sub Setup()
            Me.BuildComboBoxes()
            Me.UTP.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocName")
            Me.UTP.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.chkbPlotItem.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Plot"))
            Me.chkbStatic.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Static"))
            Me.chkbMin1HP.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Min1HP"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudHardness, "Hardness", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudHP, "HP", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudFort, "Fort", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudRef, "Ref", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudWill, "Will", 0.0F)
            Me.chkbLocked.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Locked"))
            Me.chkbLockable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Lockable"))
            Me.chkbAutoRemoveKey.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("AutoRemoveKey"))
            Me.chkbKeyRequired.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("KeyRequired"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudOpenLockDC, "OpenLockDC", 0.0F)
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudCloseLockDC, "CloseLockDC", 0.0F)
            Me.UTP.SetTextBoxToNodeValue(Me.tbKeyName, "KeyName")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnClosed, "OnClosed")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnDamaged, "OnDamaged")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnDeath, "OnDeath")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnDisarm, "OnDisarm")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnEndDialogue, "OnEndDialogue")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnHeartbeat, "OnHeartbeat")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnInvDisturbed, "OnInvDisturbed")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnLock, "OnLock")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnMeleeAttacked, "OnMeleeAttacked")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnOpen, "OnOpen")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnSpellCastAt, "OnSpellCastAt")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnUnlock, "OnUnlock")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnUsed, "OnUsed")
            Me.UTP.SetTextBoxToNodeValue(Me.tbOnUserDefined, "OnUserDefined")
            Me.UTP.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTP.SetTextBoxToNodeValue(Me.tbFaction, "Faction")
            Me.UTP.SetTextBoxToNodeValue(Me.tbConversation, "Conversation")
            Me.chkbInterruptable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Interruptable"))
            Me.UTP.SetTextBoxToNodeValue(Me.tbAnimationState, "AnimationState")
            Me.UTP.SetTextBoxToNodeValue(Me.tbType, "Type")
            Me.chkbHasInventory.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("HasInventory"))
            Me.chkbPartyInteract.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("PartyInteract"))
            Me.chkbUsable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("Useable"))
            Me.chkbTrapDetectable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("TrapDetectable"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudTrapDetectDC, "TrapDetectDC", 0.0F)
            Me.chkbTrapDisarmable.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("TrapDisarmable"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudDisarmDC, "DisarmDC", 0.0F)
            Me.chkbTrapFlag.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("TrapFlag"))
            Me.chkbTrapOneShot.Checked = BooleanType.FromObject(Me.UTP.GetNodeValue("TrapOneShot"))
            Me.UTP.SetNumericUpDownToNodeValue(Me.nudTrapType, "TrapType", 0.0F)
            Me.UTP.SetTextBoxToNodeValue(Me.tbKeyName, "KeyName")
            Me.UTP.SetTextBoxFromCExoLocStringNodeValue(Me.tbDescription, "Description")
            Me.DescriptionLang = IntegerType.FromObject(Me.UTP.GetCExoLocStringLanguage("Description"))
            Me.tbDescription.Text = Strings.Replace(Me.tbDescription.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            Me.UTP.SetTextBoxToNodeValue(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001531 RID: 5425 RVA: 0x002BE358 File Offset: 0x002BD358
        Private Sub SetGFFNodeValues()
            Me.UTP.SetNodeValueFromComboBox(Me.cmbxAppearance, "Appearance")
            Me.UTP.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocName", Me.NameLang)
            Me.UTP.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTP.SetNodeValue("Plot", Me.chkbPlotItem.Checked)
            If Me.UTP.VerifyNodeExists("Static") Then
                Me.UTP.SetNodeValue("Static", Me.chkbStatic.Checked)
            End If
            If Me.UTP.VerifyNodeExists("Min1HP") Then
                Me.UTP.SetNodeValue("Min1HP", Me.chkbMin1HP.Checked)
            End If
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudHardness, "Hardness", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudHP, "HP", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudFort, "Fort", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudRef, "Ref", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudWill, "Will", 0.0F)
            Me.UTP.SetNodeValue("Locked", Me.chkbLocked.Checked)
            Me.UTP.SetNodeValue("Lockable", Me.chkbLockable.Checked)
            Me.UTP.SetNodeValue("AutoRemoveKey", Me.chkbAutoRemoveKey.Checked)
            Me.UTP.SetNodeValue("KeyRequired", Me.chkbKeyRequired.Checked)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudOpenLockDC, "OpenLockDC", 0.0F)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudCloseLockDC, "CloseLockDC", 0.0F)
            Me.UTP.SetNodeValueFromTextBox(Me.tbKeyName, "KeyName")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnClosed, "OnClosed")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnDamaged, "OnDamaged")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnDeath, "OnDeath")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnDisarm, "OnDisarm")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnEndDialogue, "OnEndDialogue")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnHeartbeat, "OnHeartbeat")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnInvDisturbed, "OnInvDisturbed")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnLock, "OnLock")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnMeleeAttacked, "OnMeleeAttacked")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnOpen, "OnOpen")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnSpellCastAt, "OnSpellCastAt")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnUnlock, "OnUnlock")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnUsed, "OnUsed")
            Me.UTP.SetNodeValueFromTextBox(Me.tbOnUserDefined, "OnUserDefined")
            Me.UTP.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTP.SetNodeValueFromTextBox(Me.tbFaction, "Faction")
            Me.UTP.SetNodeValueFromTextBox(Me.tbConversation, "Conversation")
            Me.UTP.SetNodeValue("Interruptable", Me.chkbInterruptable.Checked)
            Me.UTP.SetNodeValueFromTextBox(Me.tbAnimationState, "AnimationState")
            Me.UTP.SetNodeValueFromTextBox(Me.tbType, "Type")
            Me.UTP.SetNodeValue("HasInventory", Me.chkbHasInventory.Checked)
            Me.UTP.SetNodeValue("PartyInteract", Me.chkbPartyInteract.Checked)
            Me.UTP.SetNodeValue("Useable", Me.chkbUsable.Checked)
            Me.UTP.SetNodeValue("TrapDetectable", Me.chkbTrapDetectable.Checked)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudTrapDetectDC, "TrapDetectDC", 0.0F)
            Me.UTP.SetNodeValue("TrapDisarmable", Me.chkbTrapDisarmable.Checked)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudDisarmDC, "DisarmDC", 0.0F)
            Me.UTP.SetNodeValue("TrapFlag", Me.chkbTrapFlag.Checked)
            Me.UTP.SetNodeValue("TrapOneShot", Me.chkbTrapOneShot.Checked)
            Me.UTP.SetNodeValueFromNumericUpDown(Me.nudTrapType, "TrapType", 0.0F)
            Me.UTP.SetNodeValueFromTextBox(Me.tbKeyName, "KeyName")
            Me.UTP.SetCExoLocStringNodeValueFromTextBox(Me.tbDescription, "Description", 0)
            Dim textBox As TextBox = New TextBox()
            textBox.Text = Strings.Replace(Me.tbDescription.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary)
            Me.UTP.SetCExoLocStringNodeValueFromTextBox(textBox, "Description", Me.DescriptionLang)
            Me.UTP.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001532 RID: 5426 RVA: 0x002BE910 File Offset: 0x002BD910
        Private Function BuildComboBoxes() As Object
            Me.g_clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me.FillComboBoxFrom2DA(Me.cmbxAppearance, "label", "placeables", Me.g_clsChitinKey, Nothing)
            If Not Me.UTP.SyncComboBox(Me.cmbxAppearance, "Appearance") Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
            Me.g_clsChitinKey = Nothing
            Dim obj As Object = Nothing
            Return obj
        End Function

        ' Token: 0x06001533 RID: 5427 RVA: 0x002BE988 File Offset: 0x002BD988
        Private Sub FillComboBoxFrom2DA(ByVal cmbx As ComboBox, ByVal colName As String, ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA(TwoDAName, ChitinKey)
            If DialogTlk IsNot Nothing Then
                Dim num As Integer = 0
                Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
                For i As Integer = num To rowsUpperBound
                    Dim indiceData As Object = cls2DA.GetIndiceData(i, colName)
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
                        cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
                    Else
                        cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
                    End If
                Next
            Else
                Dim num2 As Integer = 0
                Dim rowsUpperBound2 As Integer = cls2DA.RowsUpperBound
                For i As Integer = num2 To rowsUpperBound2
                    cmbx.Items.Add(cls2DA.GetIndiceData(i, colName))
                Next
            End If
        End Sub

        ' Token: 0x06001534 RID: 5428 RVA: 0x002BEA28 File Offset: 0x002BDA28
        Private Sub chkbLocked_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.chkbLockable.Checked Then
                Dim flag As Boolean = BooleanType.FromObject(LateBinding.LateGet(sender, Nothing, "checked", New Object(-1) {}, Nothing, Nothing))
                Me.chkbAutoRemoveKey.Enabled = flag
                Me.chkbKeyRequired.Enabled = flag
                Me.lblOpenLockDC.Enabled = flag
                Me.lblKeyTag.Enabled = flag
                Me.tbKeyName.Enabled = flag
                Me.nudOpenLockDC.Enabled = flag
            End If
        End Sub

        ' Token: 0x06001535 RID: 5429 RVA: 0x002BEAA4 File Offset: 0x002BDAA4
        Private Sub chkbLockable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim flag As Boolean = BooleanType.FromObject(LateBinding.LateGet(sender, Nothing, "checked", New Object(-1) {}, Nothing, Nothing))
            If Not Me.chkbLocked.Checked Then
                Me.chkbAutoRemoveKey.Enabled = flag
                Me.chkbKeyRequired.Enabled = flag
                Me.lblOpenLockDC.Enabled = flag
                Me.lblKeyTag.Enabled = flag
                Me.tbKeyName.Enabled = flag
                Me.nudOpenLockDC.Enabled = flag
            End If
            Me.lblCloseLockDC.Enabled = flag
            Me.nudCloseLockDC.Enabled = flag
        End Sub

        ' Token: 0x06001536 RID: 5430 RVA: 0x002BEB38 File Offset: 0x002BDB38
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utp", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTP.WriteFile(Me.m_EditingFilePath, "UTP")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x06001537 RID: 5431 RVA: 0x002BEBD0 File Offset: 0x002BDBD0
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06001538 RID: 5432 RVA: 0x002BEC00 File Offset: 0x002BDC00
        Private Sub btnSetDescLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.DescriptionLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.DescriptionLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06001539 RID: 5433 RVA: 0x002BEC30 File Offset: 0x002BDC30
        Private Sub btnInventory_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmInventoryEditor As frmInventoryEditor = New frmInventoryEditor(Me.KotorVersionIndex)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.UTP.GetListItemCount("ItemList") - 1
            For i As Integer = num To num2
                Dim text As String = StringType.FromObject(Me.UTP.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").InventoryRes"))
                Dim flag As Boolean = Not Me.UTP.VerifyNodeExists("ItemList(" + StringType.FromInteger(i) + ").Dropable") OrElse ObjectType.ObjTst(Me.UTP.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").Dropable"), 1, False) = 0
                frmInventoryEditor.AddPackItem(text, flag)
            Next
            frmInventoryEditor.SetFormName(Me.tbTemplateResRef.Text + ".utp")
            frmInventoryEditor.ConfigureForPlaceableEditorUse()
            If frmInventoryEditor.ShowDialog() = DialogResult.OK Then
                Dim i As Integer = 0
                Me.UTP.ClearListElements("ItemList")
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
                            If Not Me.UTP.VerifyNodeExists("ItemList") Then
                                Me.UTP.CreateList("", "ItemList")
                            End If
                            Me.UTP.AddListElement("ItemList", gff_Struct)
                            i += 1
                        Next
                    Next
                Finally
                    Dim enumerator As IEnumerator = Nothing
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
        End Sub

        ' Token: 0x0600153A RID: 5434 RVA: 0x002BEE7C File Offset: 0x002BDE7C
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbName.Text + ".utp"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTP.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x0600153B RID: 5435 RVA: 0x002BEEF0 File Offset: 0x002BDEF0
        Public Function ReadCls2DA(ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey) As cls2DA
            Dim flag As Boolean = True
            Dim array As Byte() = Nothing
            If Me.CurrentSettings.bUseOverrideFiles Then
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\override\" + TwoDAName + ".2da"
                Try
                    If File.Exists(text) Then
                        Dim fileStream As FileStream = New FileStream(text, FileMode.Open)
                        array = New Byte(CInt(fileStream.Length) + 1 - 1) {}
                        fileStream.Read(array, 0, CInt(fileStream.Length))
                        fileStream.Close()
                        flag = False
                        Console.WriteLine("Read " + TwoDAName + ".2da from override")
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = ChitinKey.FindResIDForResRef(TwoDAName, 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + ChitinKey.BiffList(num >> 20).filename
                array = BIFFArchive.getBIFFResource(text, num).data
                Console.WriteLine("Read " + TwoDAName + ".2da from 2da.bif")
            End If
            Return New cls2DA(array)
        End Function

        ' Token: 0x0600153C RID: 5436 RVA: 0x002BF02C File Offset: 0x002BE02C
        Private Sub frmUTP_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600153D RID: 5437 RVA: 0x002BF040 File Offset: 0x002BE040
        Private Sub frmUTP_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600153E RID: 5438 RVA: 0x002BF054 File Offset: 0x002BE054
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Placeable Editor - " + Name
        End Sub

        ' Token: 0x0600153F RID: 5439 RVA: 0x002BF068 File Offset: 0x002BE068
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x04000A4A RID: 2634
        Public UTP As clsUTP

        ' Token: 0x04000A4B RID: 2635
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x04000A4C RID: 2636
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x04000A4D RID: 2637
        Private DescriptionLang As Integer

        ' Token: 0x04000A4E RID: 2638
        Private NameLang As Integer

        ' Token: 0x04000A4F RID: 2639
        Private m_bSaveGameMode As Boolean
    End Class
End Namespace