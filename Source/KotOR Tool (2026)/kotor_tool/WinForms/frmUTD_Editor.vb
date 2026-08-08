Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200007E RID: 126
	Public Partial Class frmUTD_Editor
		Inherits frmParent

		' Token: 0x060012AB RID: 4779 RVA: 0x002AAEF8 File Offset: 0x002A9EF8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTD_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTD_Editor_Closing
			Me.ComboBoxSettingError = False
			Me.m_bSaveGameMode = False
			Me.InitializeComponent()
		End Sub

        ' Token: 0x0600136E RID: 4974 RVA: 0x002AFCA4 File Offset: 0x002AECA4
        Public Sub New(ByVal UTDClass As clsUTD, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Door Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTD = UTDClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
        End Sub

        ' Token: 0x0600136F RID: 4975 RVA: 0x002AFD54 File Offset: 0x002AED54
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        ' Token: 0x06001370 RID: 4976 RVA: 0x002AFD5C File Offset: 0x002AED5C
        Public Sub Setup()
            Me.BuildComboBoxes()
            Me.UTD.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocName")
            Me.UTD.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudHardness, "Hardness", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudHP, "HP", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudFort, "Fort", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudRef, "Ref", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudWill, "Will", 0.0F)
            Me.chkbStatic.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("Static"))
            Me.chkbLocked.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("Locked"))
            Me.chkbLockable.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("Lockable"))
            Me.chkbAutoRemoveKey.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("AutoRemoveKey"))
            Me.chkbKeyRequired.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("KeyRequired"))
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudOpenLockDC, "OpenLockDC", 0.0F)
            Me.UTD.SetNumericUpDownToNodeValue(Me.nudCloseLockDC, "CloseLockDC", 0.0F)
            Me.UTD.SetTextBoxToNodeValue(Me.tbKeyName, "KeyName")
            If Me.KotorVersionIndex = 1 Then
                Dim num As Integer = IntegerType.FromObject(Me.UTD.GetNodeValue("OpenState"))
                If num > 1 Then
                    Me.cmbxOpenState.BackColor = Color.Tomato
                    Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
                Else
                    Me.cmbxOpenState.SelectedIndex = num
                End If
                Me.chkbNotBlastable.Checked = BooleanType.FromObject(Me.UTD.GetNodeValue("NotBlastable"))
            Else
                Me.cmbxOpenState.Visible = False
                Me.chkbNotBlastable.Visible = False
                Me.lblOpenState.Visible = False
            End If
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnClick, "OnClick")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnClosed, "OnClosed")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnDamaged, "OnDamaged")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnDeath, "OnDeath")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnDisarm, "OnDisarm")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnFailToOpen, "OnFailToOpen")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnHeartbeat, "OnHeartbeat")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnLock, "OnLock")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnMeleeAttacked, "OnMeleeAttacked")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnOpen, "OnOpen")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnSpellCastAt, "OnSpellCastAt")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnUnlock, "OnUnlock")
            Me.UTD.SetTextBoxToNodeValue(Me.tbOnUserDefined, "OnUserDefined")
            Me.UTD.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTD.SetTextBoxToNodeValue(Me.tbConversation, "Conversation")
            Me.chkbNotInterruptable.Checked = BooleanType.FromObject(ObjectType.NotObj(Me.UTD.GetNodeValue("Interruptable")))
            Me.UTD.SetTextBoxToNodeValue(Me.tbAnimationState, "AnimationState")
            Me.UTD.SetTextBoxFromCExoLocStringNodeValue(Me.tbDescription, "Description")
            Me.DescriptionLang = IntegerType.FromObject(Me.UTD.GetCExoLocStringLanguage("Description"))
            Me.tbDescription.Text = Strings.Replace(Me.tbDescription.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            Me.UTD.SetTextBoxToNodeValue(Me.tbComment, "Comment")
            If Me.ComboBoxSettingError Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
        End Sub

        ' Token: 0x06001371 RID: 4977 RVA: 0x002B01CC File Offset: 0x002AF1CC
        Private Sub SetGFFNodeValues()
            Me.UTD.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocName", Me.NameLang)
            Me.UTD.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudHardness, "Hardness", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudHP, "HP", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudFort, "Fort", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudRef, "Ref", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudWill, "Will", 0.0F)
            If Not Me.UTD.VerifyNodeExists("Static") Then
                Me.UTD.AddFieldToStruct("", "Static", 0, Me.chkbStatic.Checked)
            Else
                Me.UTD.SetNodeValue("Static", Me.chkbStatic.Checked)
            End If
            Me.UTD.SetNodeValueFromComboBox(Me.cmbxDoorType, "GenericType")
            Me.UTD.SetNodeValue("Locked", Me.chkbLocked.Checked)
            Me.UTD.SetNodeValue("Lockable", Me.chkbLockable.Checked)
            Me.UTD.SetNodeValue("AutoRemoveKey", Me.chkbAutoRemoveKey.Checked)
            Me.UTD.SetNodeValue("KeyRequired", Me.chkbKeyRequired.Checked)
            Me.UTD.SetNodeValueFromTextBox(Me.tbKeyName, "KeyName")
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudOpenLockDC, "OpenLockDC", 0.0F)
            Me.UTD.SetNodeValueFromNumericUpDown(Me.nudCloseLockDC, "CloseLockDC", 0.0F)
            If Me.KotorVersionIndex = 1 Then
                Me.UTD.SetNodeValue("NotBlastable", Me.chkbNotBlastable.Checked)
                Me.UTD.SetNodeValue("OpenState", Me.cmbxOpenState.SelectedIndex)
            End If
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnClick, "OnClick")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnClosed, "OnClosed")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnDamaged, "OnDamaged")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnDeath, "OnDeath")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnDisarm, "OnDisarm")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnFailToOpen, "OnFailToOpen")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnHeartbeat, "OnHeartbeat")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnLock, "OnLock")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnMeleeAttacked, "OnMeleeAttacked")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnOpen, "OnOpen")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnSpellCastAt, "OnSpellCastAt")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnUnlock, "OnUnlock")
            Me.UTD.SetNodeValueFromTextBox(Me.tbOnUserDefined, "OnUserDefined")
            Me.UTD.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTD.SetNodeValueFromComboBox(Me.cmbxFaction, "Faction")
            Me.UTD.SetNodeValueFromTextBox(Me.tbConversation, "Conversation")
            Me.UTD.SetNodeValue("Interruptable", Not Me.chkbNotInterruptable.Checked)
            Me.UTD.SetNodeValueFromTextBox(Me.tbAnimationState, "AnimationState")
            Me.UTD.SetCExoLocStringNodeValueFromTextBox(Me.tbDescription, "Description", 0)
            Dim textBox As TextBox = New TextBox()
            textBox.Text = Strings.Replace(Me.tbDescription.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary)
            Me.UTD.SetCExoLocStringNodeValueFromTextBox(textBox, "Description", Me.DescriptionLang)
            Me.UTD.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001372 RID: 4978 RVA: 0x002B0634 File Offset: 0x002AF634
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

        ' Token: 0x06001373 RID: 4979 RVA: 0x002B0770 File Offset: 0x002AF770
        Private Sub BuildComboBoxes()
            Me.g_clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me.FillComboBoxFrom2DA(Me.cmbxDoorType, "label", "genericdoors", Me.g_clsChitinKey, Nothing)
            If Not Me.UTD.SyncComboBox(Me.cmbxDoorType, "GenericType") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxFaction, "label", "repute", Me.g_clsChitinKey, Nothing)
            If Not Me.UTD.SyncComboBox(Me.cmbxFaction, "Faction") Then
                Me.ComboBoxSettingError = True
            End If
            Me.g_clsChitinKey = Nothing
        End Sub

        ' Token: 0x06001374 RID: 4980 RVA: 0x002B0818 File Offset: 0x002AF818
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

        ' Token: 0x06001375 RID: 4981 RVA: 0x002B08B8 File Offset: 0x002AF8B8
        Private Sub chkbLocked_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkbLocked.CheckedChanged
            If Not Me.chkbLockable.Checked Then
                Dim flag As Boolean = BooleanType.FromObject(LateBinding.LateGet(sender, Nothing, "checked", New Object(-1) {}, Nothing, Nothing))
                Me.chkbAutoRemoveKey.Enabled = flag
                Me.chkbKeyRequired.Enabled = flag
                Me.lblOpenLockDC.Enabled = flag
                Me.lblKeyTag.Enabled = flag
                Me.tbKeyName.Enabled = flag
                Me.nudOpenLockDC.Enabled = flag
                Me.chkbNotBlastable.Enabled = flag
            End If
        End Sub

        ' Token: 0x06001376 RID: 4982 RVA: 0x002B0940 File Offset: 0x002AF940
        Private Sub chkbLockable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkbLockable.CheckedChanged
            Dim flag As Boolean = BooleanType.FromObject(LateBinding.LateGet(sender, Nothing, "checked", New Object(-1) {}, Nothing, Nothing))
            If Not Me.chkbLocked.Checked Then
                Me.chkbAutoRemoveKey.Enabled = flag
                Me.chkbKeyRequired.Enabled = flag
                Me.lblOpenLockDC.Enabled = flag
                Me.lblKeyTag.Enabled = flag
                Me.tbKeyName.Enabled = flag
                Me.nudOpenLockDC.Enabled = flag
                Me.chkbNotBlastable.Enabled = flag
            End If
            Me.lblCloseLockDC.Enabled = flag
            Me.nudCloseLockDC.Enabled = flag
        End Sub

        ' Token: 0x06001377 RID: 4983 RVA: 0x002B09E0 File Offset: 0x002AF9E0
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utd", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTD.WriteFile(Me.m_EditingFilePath, "UTD")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x06001378 RID: 4984 RVA: 0x002B0A78 File Offset: 0x002AFA78
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetNameLang.Click
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06001379 RID: 4985 RVA: 0x002B0AA8 File Offset: 0x002AFAA8
        Private Sub btnSetDescLang_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetDescriptionLang.Click
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.DescriptionLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.DescriptionLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x0600137A RID: 4986 RVA: 0x002B0AD8 File Offset: 0x002AFAD8
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDebug.Click
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbName.Text + ".utd"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTD.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x0600137B RID: 4987 RVA: 0x002B0B4C File Offset: 0x002AFB4C
        Private Sub frmUTD_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600137C RID: 4988 RVA: 0x002B0B60 File Offset: 0x002AFB60
        Private Sub frmUTD_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x0600137D RID: 4989 RVA: 0x002B0B74 File Offset: 0x002AFB74
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Door Editor - " + Name
        End Sub

        ' Token: 0x0600137E RID: 4990 RVA: 0x002B0B88 File Offset: 0x002AFB88
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditOnUserDefined.Click, btnEditOnUnlock.Click, btnEditOnTrapTriggered.Click, btnEditOnSpellCastAt.Click, btnEditOnOpen.Click, btnEditOnMeleeAttacked.Click, btnEditOnLock.Click, btnEditOnHeartbeat.Click, btnEditOnFailToOpen.Click, btnEditOnDisarm.Click, btnEditOnDeath.Click, btnEditOnDamaged.Click, btnEditOnClosed.Click, btnEditOnClick.Click
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x0400095A RID: 2394
        Public UTD As clsUTD

        ' Token: 0x0400095B RID: 2395
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x0400095C RID: 2396
        Private ComboBoxSettingError As Boolean

        ' Token: 0x0400095D RID: 2397
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x0400095E RID: 2398
        Private DescriptionLang As Integer

        ' Token: 0x0400095F RID: 2399
        Private NameLang As Integer

        ' Token: 0x04000960 RID: 2400
        Private m_bSaveGameMode As Boolean
    End Class
End Namespace
