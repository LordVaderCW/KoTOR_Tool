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

		' Token: 0x170008A7 RID: 2215
		' (get) Token: 0x060016D8 RID: 5848 RVA: 0x002C9DA0 File Offset: 0x002C8DA0
		' (set) Token: 0x060016D7 RID: 5847 RVA: 0x002C9DB4 File Offset: 0x002C8DB4
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

        ' Token: 0x170008A8 RID: 2216
        ' (get) Token: 0x060016D9 RID: 5849 RVA: 0x002C9E5C File Offset: 0x002C8E5C
        ' (set) Token: 0x060016DA RID: 5850 RVA: 0x002C9E08 File Offset: 0x002C8E08
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

        ' Token: 0x170008A9 RID: 2217
        ' (get) Token: 0x060016DB RID: 5851 RVA: 0x002C9E70 File Offset: 0x002C8E70
        ' (set) Token: 0x060016DC RID: 5852 RVA: 0x002C9E84 File Offset: 0x002C8E84
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

        ' Token: 0x170008AA RID: 2218
        ' (get) Token: 0x060016DE RID: 5854 RVA: 0x002C9F2C File Offset: 0x002C8F2C
        ' (set) Token: 0x060016DD RID: 5853 RVA: 0x002C9ED8 File Offset: 0x002C8ED8
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

        ' Token: 0x170008AB RID: 2219
        ' (get) Token: 0x060016E0 RID: 5856 RVA: 0x002C9F40 File Offset: 0x002C8F40
        ' (set) Token: 0x060016DF RID: 5855 RVA: 0x002C9F54 File Offset: 0x002C8F54
        Friend Overridable Property tbName() As TextBox
            Get
                Return Me._tbName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbName IsNot Nothing Then
                End If
                Me._tbName = value
                If Me._tbName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008AC RID: 2220
        ' (get) Token: 0x060016E2 RID: 5858 RVA: 0x002C9F70 File Offset: 0x002C8F70
        ' (set) Token: 0x060016E1 RID: 5857 RVA: 0x002C9F84 File Offset: 0x002C8F84
        Friend Overridable Property Label11() As Label
            Get
                Return Me._Label11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label11 IsNot Nothing Then
                End If
                Me._Label11 = value
                If Me._Label11 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008AD RID: 2221
        ' (get) Token: 0x060016E4 RID: 5860 RVA: 0x002C9FBC File Offset: 0x002C8FBC
        ' (set) Token: 0x060016E3 RID: 5859 RVA: 0x002C9FA0 File Offset: 0x002C8FA0
        Friend Overridable Property tbTemplateResRef() As TextBox
            Get
                Return Me._tbTemplateResRef
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTemplateResRef IsNot Nothing Then
                End If
                Me._tbTemplateResRef = value
                If Me._tbTemplateResRef IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008AE RID: 2222
        ' (get) Token: 0x060016E6 RID: 5862 RVA: 0x002C9FEC File Offset: 0x002C8FEC
        ' (set) Token: 0x060016E5 RID: 5861 RVA: 0x002C9FD0 File Offset: 0x002C8FD0
        Friend Overridable Property Label57() As Label
            Get
                Return Me._Label57
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label57 IsNot Nothing Then
                End If
                Me._Label57 = value
                If Me._Label57 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008AF RID: 2223
        ' (get) Token: 0x060016E8 RID: 5864 RVA: 0x002CA01C File Offset: 0x002C901C
        ' (set) Token: 0x060016E7 RID: 5863 RVA: 0x002CA000 File Offset: 0x002C9000
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

        ' Token: 0x170008B0 RID: 2224
        ' (get) Token: 0x060016EA RID: 5866 RVA: 0x002CA04C File Offset: 0x002C904C
        ' (set) Token: 0x060016E9 RID: 5865 RVA: 0x002CA030 File Offset: 0x002C9030
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

        ' Token: 0x170008B1 RID: 2225
        ' (get) Token: 0x060016EC RID: 5868 RVA: 0x002CA060 File Offset: 0x002C9060
        ' (set) Token: 0x060016EB RID: 5867 RVA: 0x002CA074 File Offset: 0x002C9074
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

        ' Token: 0x170008B2 RID: 2226
        ' (get) Token: 0x060016ED RID: 5869 RVA: 0x002CA090 File Offset: 0x002C9090
        ' (set) Token: 0x060016EE RID: 5870 RVA: 0x002CA0A4 File Offset: 0x002C90A4
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

        ' Token: 0x170008B3 RID: 2227
        ' (get) Token: 0x060016F0 RID: 5872 RVA: 0x002CA0DC File Offset: 0x002C90DC
        ' (set) Token: 0x060016EF RID: 5871 RVA: 0x002CA0C0 File Offset: 0x002C90C0
        Friend Overridable Property chkbHasMapNote() As CheckBox
            Get
                Return Me._chkbHasMapNote
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbHasMapNote IsNot Nothing Then
                End If
                Me._chkbHasMapNote = value
                If Me._chkbHasMapNote IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008B4 RID: 2228
        ' (get) Token: 0x060016F1 RID: 5873 RVA: 0x002CA0F0 File Offset: 0x002C90F0
        ' (set) Token: 0x060016F2 RID: 5874 RVA: 0x002CA104 File Offset: 0x002C9104
        Friend Overridable Property Label9() As Label
            Get
                Return Me._Label9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label9 IsNot Nothing Then
                End If
                Me._Label9 = value
                If Me._Label9 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008B5 RID: 2229
        ' (get) Token: 0x060016F3 RID: 5875 RVA: 0x002CA120 File Offset: 0x002C9120
        ' (set) Token: 0x060016F4 RID: 5876 RVA: 0x002CA134 File Offset: 0x002C9134
        Friend Overridable Property tbWPLinkedTo() As TextBox
            Get
                Return Me._tbWPLinkedTo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbWPLinkedTo IsNot Nothing Then
                End If
                Me._tbWPLinkedTo = value
                If Me._tbWPLinkedTo IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008B6 RID: 2230
        ' (get) Token: 0x060016F5 RID: 5877 RVA: 0x002CA150 File Offset: 0x002C9150
        ' (set) Token: 0x060016F6 RID: 5878 RVA: 0x002CA164 File Offset: 0x002C9164
        Friend Overridable Property tbWpDescription() As TextBox
            Get
                Return Me._tbWpDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbWpDescription IsNot Nothing Then
                End If
                Me._tbWpDescription = value
                If Me._tbWpDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008B7 RID: 2231
        ' (get) Token: 0x060016F7 RID: 5879 RVA: 0x002CA19C File Offset: 0x002C919C
        ' (set) Token: 0x060016F8 RID: 5880 RVA: 0x002CA180 File Offset: 0x002C9180
        Friend Overridable Property tbWpMapNote() As TextBox
            Get
                Return Me._tbWpMapNote
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbWpMapNote IsNot Nothing Then
                End If
                Me._tbWpMapNote = value
                If Me._tbWpMapNote IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170008B8 RID: 2232
        ' (get) Token: 0x060016F9 RID: 5881 RVA: 0x002CA1CC File Offset: 0x002C91CC
        ' (set) Token: 0x060016FA RID: 5882 RVA: 0x002CA1B0 File Offset: 0x002C91B0
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

        ' Token: 0x170008B9 RID: 2233
        ' (get) Token: 0x060016FC RID: 5884 RVA: 0x002CA1FC File Offset: 0x002C91FC
        ' (set) Token: 0x060016FB RID: 5883 RVA: 0x002CA1E0 File Offset: 0x002C91E0
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

        ' Token: 0x170008BA RID: 2234
        ' (get) Token: 0x060016FD RID: 5885 RVA: 0x002CA22C File Offset: 0x002C922C
        ' (set) Token: 0x060016FE RID: 5886 RVA: 0x002CA210 File Offset: 0x002C9210
        Friend Overridable Property chkbMapNoteEnabled() As CheckBox
            Get
                Return Me._chkbMapNoteEnabled
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbMapNoteEnabled IsNot Nothing Then
                End If
                Me._chkbMapNoteEnabled = value
                If Me._chkbMapNoteEnabled IsNot Nothing Then
                End If
            End Set
        End Property

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
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06001706 RID: 5894 RVA: 0x002CB0F0 File Offset: 0x002CA0F0
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
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

        ' Token: 0x04000B13 RID: 2835
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000B14 RID: 2836
        <AccessedThroughProperty("tbTemplateResRef")> _
        Private _tbTemplateResRef As TextBox

        ' Token: 0x04000B15 RID: 2837
        <AccessedThroughProperty("tbName")> _
        Private _tbName As TextBox

        ' Token: 0x04000B16 RID: 2838
        <AccessedThroughProperty("chkbMapNoteEnabled")> _
        Private _chkbMapNoteEnabled As CheckBox

        ' Token: 0x04000B17 RID: 2839
        <AccessedThroughProperty("tbComment")> _
        Private _tbComment As TextBox

        ' Token: 0x04000B18 RID: 2840
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As Button

        ' Token: 0x04000B19 RID: 2841
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x04000B1A RID: 2842
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000B1B RID: 2843
        <AccessedThroughProperty("tbWpMapNote")> _
        Private _tbWpMapNote As TextBox

        ' Token: 0x04000B1C RID: 2844
        <AccessedThroughProperty("chkbHasMapNote")> _
        Private _chkbHasMapNote As CheckBox

        ' Token: 0x04000B1D RID: 2845
        <AccessedThroughProperty("btnDebug")> _
        Private _btnDebug As Button

        ' Token: 0x04000B1E RID: 2846 _
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000B1F RID: 2847
        <AccessedThroughProperty("tbWpDescription")> _
        Private _tbWpDescription As TextBox

        ' Token: 0x04000B20 RID: 2848
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000B21 RID: 2849
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000B22 RID: 2850
        <AccessedThroughProperty("btnSetNameLang")> _
        Private _btnSetNameLang As Button

        ' Token: 0x04000B23 RID: 2851
        <AccessedThroughProperty("Label57")> _
        Private _Label57 As Label

        ' Token: 0x04000B24 RID: 2852
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x04000B25 RID: 2853
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

        ' Token: 0x04000B26 RID: 2854
        <AccessedThroughProperty("tbWPLinkedTo")> _
        Private _tbWPLinkedTo As TextBox

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
