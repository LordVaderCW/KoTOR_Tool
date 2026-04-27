Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000084 RID: 132
	Public Partial Class frmUTT_Editor
		Inherits frmParent

		' Token: 0x06001646 RID: 5702 RVA: 0x002C614C File Offset: 0x002C514C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTT_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTT_Editor_Closing
			Me.ComboBoxSettingError = False
			Me.m_bSaveGameMode = False
			Me.InitializeComponent()
		End Sub

        ' Token: 0x060016C5 RID: 5829 RVA: 0x002C925C File Offset: 0x002C825C
        Public Sub New(ByVal UTTClass As clsUTT, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Trigger Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            If KotorVerIndex = 1 Then
                Me.CustomizeForKotorII()
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTT = UTTClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
        End Sub

        ' Token: 0x060016C6 RID: 5830 RVA: 0x002C9318 File Offset: 0x002C8318
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x060016C7 RID: 5831 RVA: 0x002C9320 File Offset: 0x002C8320
        Public Sub Setup()
            Me.BuildComboBoxes()
            Me.UTT.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTT.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocalizedName")
            Me.UTT.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTT.SetTextBoxToNodeValue(Me.tbCursor, "Cursor")
            Me.UTT.SetTextBoxToNodeValue(Me.tbOnClick, "OnClick")
            Me.UTT.SetTextBoxToNodeValue(Me.tbOnDisarm, "OnDisarm")
            Me.UTT.SetTextBoxToNodeValue(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTT.SetTextBoxToNodeValue(Me.tbScriptHeartbeat, "ScriptHeartbeat")
            Me.UTT.SetTextBoxToNodeValue(Me.tbScriptOnEnter, "ScriptOnEnter")
            Me.UTT.SetTextBoxToNodeValue(Me.tbScriptOnExit, "ScriptOnExit")
            Me.UTT.SetTextBoxToNodeValue(Me.tbScriptUserDefine, "ScriptUserDefine")
            Me.chkbTrapDetectable.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("TrapDetectable"))
            Me.UTT.SetNumericUpDownToNodeValue(Me.nudTrapDetectDC, "TrapDetectDC", 0.0F)
            Me.chkbTrapDisarmable.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("TrapDisarmable"))
            Me.UTT.SetNumericUpDownToNodeValue(Me.nudDisarmDC, "DisarmDC", 0.0F)
            Me.chkbTrapFlag.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("TrapFlag"))
            Me.chkbTrapOneShot.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("TrapOneShot"))
            Me.UTT.SetNumericUpDownToNodeValue(Me.nudTrapType, "TrapType", 0.0F)
            Me.UTT.SetTextBoxToNodeValue(Me.tbKeyName, "KeyName")
            Me.chkbAutoRemoveKey.Checked = BooleanType.FromObject(Me.UTT.GetNodeValue("AutoRemoveKey"))
            Me.UTT.SetTextBoxToNodeValue(Me.tbComment, "Comment")
            If Me.ComboBoxSettingError Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
            If Me.KotorVersionIndex = 1 Then
                Me.CustomizeForKotorII()
            End If
        End Sub

        ' Token: 0x060016C8 RID: 5832 RVA: 0x002C956C File Offset: 0x002C856C
        Private Sub SetGFFNodeValues()
            Me.UTT.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTT.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocalizedName", Me.NameLang)
            Me.UTT.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTT.SetNodeValueFromComboBox(Me.cmbxFaction, "Faction")
            Me.UTT.SetNodeValue("Type", Me.cmbxType.SelectedIndex)
            Me.UTT.SetNodeValueFromTextBox(Me.tbCursor, "Cursor")
            Me.UTT.SetNodeValueFromTextBox(Me.tbOnClick, "OnClick")
            Me.UTT.SetNodeValueFromTextBox(Me.tbOnDisarm, "OnDisarm")
            Me.UTT.SetNodeValueFromTextBox(Me.tbOnTrapTriggered, "OnTrapTriggered")
            Me.UTT.SetNodeValueFromTextBox(Me.tbScriptHeartbeat, "ScriptHeartbeat")
            Me.UTT.SetNodeValueFromTextBox(Me.tbScriptOnEnter, "ScriptOnEnter")
            Me.UTT.SetNodeValueFromTextBox(Me.tbScriptOnExit, "ScriptOnExit")
            Me.UTT.SetNodeValueFromTextBox(Me.tbScriptUserDefine, "ScriptUserDefine")
            If Me.cmbxType.SelectedIndex = 2 Then
                If Not Me.UTT.VerifyNodeExists("TrapDetectable") Then
                    Me.UTT.AddFieldToStruct("", "TrapDetectable", 0, 0)
                End If
                Me.UTT.SetNodeValue("TrapDetectable", Me.chkbTrapDetectable.Checked)
                If Not Me.UTT.VerifyNodeExists("TrapDetectDC") Then
                    Me.UTT.AddFieldToStruct("", "TrapDetectDC", 0, 0)
                End If
                Me.UTT.SetNodeValueFromNumericUpDown(Me.nudTrapDetectDC, "TrapDetectDC", 0.0F)
                If Not Me.UTT.VerifyNodeExists("TrapDisarmable") Then
                    Me.UTT.AddFieldToStruct("", "TrapDisarmable", 0, 0)
                End If
                Me.UTT.SetNodeValue("TrapDisarmable", Me.chkbTrapDisarmable.Checked)
                If Not Me.UTT.VerifyNodeExists("DisarmDC") Then
                    Me.UTT.AddFieldToStruct("", "DisarmDC", 0, 0)
                End If
                Me.UTT.SetNodeValueFromNumericUpDown(Me.nudDisarmDC, "DisarmDC", 0.0F)
                If Not Me.UTT.VerifyNodeExists("TrapFlag") Then
                    Me.UTT.AddFieldToStruct("", "TrapFlag", 0, 0)
                End If
                Me.UTT.SetNodeValue("TrapFlag", Me.chkbTrapFlag.Checked)
                If Not Me.UTT.VerifyNodeExists("TrapOneShot") Then
                    Me.UTT.AddFieldToStruct("", "TrapOneShot", 0, 0)
                End If
                Me.UTT.SetNodeValue("TrapOneShot", Me.chkbTrapOneShot.Checked)
                If Not Me.UTT.VerifyNodeExists("TrapType") Then
                    Me.UTT.AddFieldToStruct("", "TrapType", 0, 0)
                End If
                Me.UTT.SetNodeValueFromNumericUpDown(Me.nudTrapType, "TrapType", 0.0F)
                Me.UTT.SetNodeValueFromTextBox(Me.tbKeyName, "KeyName")
                Me.UTT.SetNodeValue("AutoRemoveKey", Me.chkbAutoRemoveKey.Checked)
            End If
            Me.UTT.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x060016C9 RID: 5833 RVA: 0x002C9918 File Offset: 0x002C8918
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

        ' Token: 0x060016CA RID: 5834 RVA: 0x002C9A54 File Offset: 0x002C8A54
        Private Sub BuildComboBoxes()
            Dim clsChitinKey As clsChitinKey = frmMain.KxChitinKey(Me.KotorVersionIndex)
            Me.FillComboBoxFrom2DA(Me.cmbxFaction, "label", "repute", clsChitinKey, Nothing)
            If Not Me.UTT.SyncComboBox(Me.cmbxFaction, "Faction") Then
                Me.ComboBoxSettingError = True
            End If
            Me.cmbxType.SelectedIndex = IntegerType.FromObject(Me.UTT.GetNodeValue("Type"))
        End Sub

        ' Token: 0x060016CB RID: 5835 RVA: 0x002C9AC4 File Offset: 0x002C8AC4
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

        ' Token: 0x060016CC RID: 5836 RVA: 0x002C9B64 File Offset: 0x002C8B64
        Private Sub CustomizeForKotorII()
            Me.nudTrapType.Maximum = 26D
        End Sub

        ' Token: 0x060016CD RID: 5837 RVA: 0x002C9B80 File Offset: 0x002C8B80
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utt", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTT.WriteFile(Me.m_EditingFilePath, "UTT")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x060016CE RID: 5838 RVA: 0x002C9C18 File Offset: 0x002C8C18
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x060016CF RID: 5839 RVA: 0x002C9C48 File Offset: 0x002C8C48
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbName.Text + ".utt"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTT.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x060016D0 RID: 5840 RVA: 0x002C9CBC File Offset: 0x002C8CBC
        Private Sub frmUTT_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060016D1 RID: 5841 RVA: 0x002C9CD0 File Offset: 0x002C8CD0
        Private Sub frmUTT_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060016D2 RID: 5842 RVA: 0x002C9CE4 File Offset: 0x002C8CE4
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Trigger Editor - " + Name
        End Sub

        ' Token: 0x060016D3 RID: 5843 RVA: 0x002C9CF8 File Offset: 0x002C8CF8
        Private Sub cmbxType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.TabPageTrap.Enabled = Me.cmbxType.SelectedIndex = 2
        End Sub

        ' Token: 0x060016D4 RID: 5844 RVA: 0x002C9D14 File Offset: 0x002C8D14
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x04000B0E RID: 2830
        Public UTT As clsUTT

        ' Token: 0x04000B0F RID: 2831
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x04000B10 RID: 2832
        Private NameLang As Integer

        ' Token: 0x04000B11 RID: 2833
        Private ComboBoxSettingError As Boolean

        ' Token: 0x04000B12 RID: 2834
        Private m_bSaveGameMode As Boolean
    End Class
End Namespace
