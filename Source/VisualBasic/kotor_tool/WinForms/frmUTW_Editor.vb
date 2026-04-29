Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000085 RID: 133
	Public Partial Class frmUTW_Editor
		Inherits frmParent

		' Token: 0x060016D5 RID: 5845 RVA: 0x002C9D30 File Offset: 0x002C8D30
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTW_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTW_Editor_Closing
			Me.ComboBoxSettingError = False
			Me.m_bSaveGameMode = False
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06001700 RID: 5888 RVA: 0x002CAD68 File Offset: 0x002C9D68
        Public Sub New(ByVal UTWClass As clsUTW, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Waypoint Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTW = UTWClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
        End Sub

        ' Token: 0x06001701 RID: 5889 RVA: 0x002CAE18 File Offset: 0x002C9E18
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        ' Token: 0x06001702 RID: 5890 RVA: 0x002CAE20 File Offset: 0x002C9E20
        Public Sub Setup()
            Me.UTW.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTW.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocalizedName")
            Me.UTW.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTW.SetTextBoxToNodeValue(Me.tbWPLinkedTo, "LinkedTo")
            Me.UTW.SetTextBoxFromCExoLocStringNodeValue(Me.tbWpDescription, "Description")
            If Me.UTW.VerifyNodeExists("MapNote") Then
                Me.UTW.SetTextBoxFromCExoLocStringNodeValue(Me.tbWpMapNote, "MapNote")
            End If
            Me.chkbHasMapNote.Checked = BooleanType.FromObject(Me.UTW.GetNodeValue("HasMapNote"))
            Me.chkbMapNoteEnabled.Checked = BooleanType.FromObject(Me.UTW.GetNodeValue("MapNoteEnabled"))
            Me.UTW.SetTextBoxToNodeValue(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001703 RID: 5891 RVA: 0x002CAF1C File Offset: 0x002C9F1C
        Private Sub SetGFFNodeValues()
            Me.UTW.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTW.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocalizedName", Me.NameLang)
            Me.UTW.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTW.SetNodeValueFromTextBox(Me.tbWPLinkedTo, "LinkedTo")
            Me.UTW.SetCExoLocStringNodeValueFromTextBox(Me.tbWpDescription, "Description", Me.NameLang)
            If Me.UTW.VerifyNodeExists("MapNote") Then
                Me.UTW.SetCExoLocStringNodeValueFromTextBox(Me.tbWpMapNote, "MapNote", Me.NameLang)
            End If
            Me.UTW.SetNodeValue("HasMapNote", Me.chkbHasMapNote.Checked)
            Me.UTW.SetNodeValue("MapNoteEnabled", Me.chkbMapNoteEnabled.Checked)
            Me.UTW.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x06001704 RID: 5892 RVA: 0x002CB028 File Offset: 0x002CA028
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utw", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTW.WriteFile(Me.m_EditingFilePath, "UTW")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x06001705 RID: 5893 RVA: 0x002CB0C0 File Offset: 0x002CA0C0
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetNameLang.Click
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06001706 RID: 5894 RVA: 0x002CB0F0 File Offset: 0x002CA0F0
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDebug.Click
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbName.Text + ".utt"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTW.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x06001707 RID: 5895 RVA: 0x002CB164 File Offset: 0x002CA164
        Private Sub frmUTW_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x06001708 RID: 5896 RVA: 0x002CB178 File Offset: 0x002CA178
        Private Sub frmUTW_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x06001709 RID: 5897 RVA: 0x002CB18C File Offset: 0x002CA18C
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Waypoint Editor - " + Name
        End Sub

        ' Token: 0x04000B28 RID: 2856
        Public UTW As clsUTW

        ' Token: 0x04000B29 RID: 2857
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x04000B2A RID: 2858
        Private NameLang As Integer

        ' Token: 0x04000B2B RID: 2859
        Private ComboBoxSettingError As Boolean

        ' Token: 0x04000B2C RID: 2860
        Private m_bSaveGameMode As Boolean
    End Class
End Namespace
