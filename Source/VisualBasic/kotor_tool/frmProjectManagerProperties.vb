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
	' Token: 0x0200006D RID: 109
	Public Partial Class frmProjectManagerProperties
		Inherits frmParent

		' Token: 0x06000E06 RID: 3590 RVA: 0x0028C020 File Offset: 0x0028B020
		Public Sub New()
			Me.mode = "new"
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000E07 RID: 3591 RVA: 0x0028C03C File Offset: 0x0028B03C
		Public Sub New(FormMode As String)
			Me.New()
			Me.mode = FormMode
		End Sub

		' Token: 0x170004E0 RID: 1248
		' (get) Token: 0x06000E09 RID: 3593 RVA: 0x0028C088 File Offset: 0x0028B088
		' (set) Token: 0x06000E0A RID: 3594 RVA: 0x0028C06C File Offset: 0x0028B06C
		Friend Overridable Property Label1 As Label
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

        ' Token: 0x170004E1 RID: 1249
        ' (get) Token: 0x06000E0B RID: 3595 RVA: 0x0028C09C File Offset: 0x0028B09C
        ' (set) Token: 0x06000E0C RID: 3596 RVA: 0x0028C0B0 File Offset: 0x0028B0B0
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

        ' Token: 0x170004E2 RID: 1250
        ' (get) Token: 0x06000E0E RID: 3598 RVA: 0x0028C0CC File Offset: 0x0028B0CC
        ' (set) Token: 0x06000E0D RID: 3597 RVA: 0x0028C0E0 File Offset: 0x0028B0E0
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

        ' Token: 0x170004E3 RID: 1251
        ' (get) Token: 0x06000E10 RID: 3600 RVA: 0x0028C150 File Offset: 0x0028B150
        ' (set) Token: 0x06000E0F RID: 3599 RVA: 0x0028C0FC File Offset: 0x0028B0FC
        Friend Overridable Property btnKotorPath() As Button
            Get
                Return Me._btnKotorPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnKotorPath IsNot Nothing Then
                    RemoveHandler Me._btnKotorPath.Click, AddressOf Me.btnKotorPath_Click
                End If
                Me._btnKotorPath = value
                If Me._btnKotorPath IsNot Nothing Then
                    AddHandler Me._btnKotorPath.Click, AddressOf Me.btnKotorPath_Click
                End If
            End Set
        End Property

        ' Token: 0x170004E4 RID: 1252
        ' (get) Token: 0x06000E12 RID: 3602 RVA: 0x0028C1B8 File Offset: 0x0028B1B8
        ' (set) Token: 0x06000E11 RID: 3601 RVA: 0x0028C164 File Offset: 0x0028B164
        Friend Overridable Property btnReleasePath() As Button
            Get
                Return Me._btnReleasePath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnReleasePath IsNot Nothing Then
                    RemoveHandler Me._btnReleasePath.Click, AddressOf Me.btnReleasePath_Click
                End If
                Me._btnReleasePath = value
                If Me._btnReleasePath IsNot Nothing Then
                    AddHandler Me._btnReleasePath.Click, AddressOf Me.btnReleasePath_Click
                End If
            End Set
        End Property

        ' Token: 0x170004E5 RID: 1253
        ' (get) Token: 0x06000E13 RID: 3603 RVA: 0x0028C1CC File Offset: 0x0028B1CC
        ' (set) Token: 0x06000E14 RID: 3604 RVA: 0x0028C1E0 File Offset: 0x0028B1E0
        Friend Overridable Property tbDebugPath() As TextBox
            Get
                Return Me._tbDebugPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbDebugPath IsNot Nothing Then
                End If
                Me._tbDebugPath = value
                If Me._tbDebugPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004E6 RID: 1254
        ' (get) Token: 0x06000E15 RID: 3605 RVA: 0x0028C1FC File Offset: 0x0028B1FC
        ' (set) Token: 0x06000E16 RID: 3606 RVA: 0x0028C210 File Offset: 0x0028B210
        Friend Overridable Property tbReleasePath() As TextBox
            Get
                Return Me._tbReleasePath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbReleasePath IsNot Nothing Then
                End If
                Me._tbReleasePath = value
                If Me._tbReleasePath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004E7 RID: 1255
        ' (get) Token: 0x06000E18 RID: 3608 RVA: 0x0028C22C File Offset: 0x0028B22C
        ' (set) Token: 0x06000E17 RID: 3607 RVA: 0x0028C240 File Offset: 0x0028B240
        Friend Overridable Property btnOK() As Button
            Get
                Return Me._btnOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                    RemoveHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                    AddHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
            End Set
        End Property

        ' Token: 0x170004E8 RID: 1256
        ' (get) Token: 0x06000E19 RID: 3609 RVA: 0x0028C2B0 File Offset: 0x0028B2B0
        ' (set) Token: 0x06000E1A RID: 3610 RVA: 0x0028C294 File Offset: 0x0028B294
        Friend Overridable Property btnCancel() As Button
            Get
                Return Me._btnCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnCancel IsNot Nothing Then
                End If
                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004E9 RID: 1257
        ' (get) Token: 0x06000E1C RID: 3612 RVA: 0x0028C318 File Offset: 0x0028B318
        ' (set) Token: 0x06000E1B RID: 3611 RVA: 0x0028C2C4 File Offset: 0x0028B2C4
        Friend Overridable Property btnSelectProject() As Button
            Get
                Return Me._btnSelectProject
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSelectProject IsNot Nothing Then
                    RemoveHandler Me._btnSelectProject.Click, AddressOf Me.btnSelectProject_Click
                End If
                Me._btnSelectProject = value
                If Me._btnSelectProject IsNot Nothing Then
                    AddHandler Me._btnSelectProject.Click, AddressOf Me.btnSelectProject_Click
                End If
            End Set
        End Property

        ' Token: 0x170004EA RID: 1258
        ' (get) Token: 0x06000E1E RID: 3614 RVA: 0x0028C32C File Offset: 0x0028B32C
        ' (set) Token: 0x06000E1D RID: 3613 RVA: 0x0028C340 File Offset: 0x0028B340
        Friend Overridable Property tbProjectPath() As TextBox
            Get
                Return Me._tbProjectPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbProjectPath IsNot Nothing Then
                End If
                Me._tbProjectPath = value
                If Me._tbProjectPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004EB RID: 1259
        ' (get) Token: 0x06000E20 RID: 3616 RVA: 0x0028C35C File Offset: 0x0028B35C
        ' (set) Token: 0x06000E1F RID: 3615 RVA: 0x0028C370 File Offset: 0x0028B370
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

        ' Token: 0x170004EC RID: 1260
        ' (get) Token: 0x06000E22 RID: 3618 RVA: 0x0028C38C File Offset: 0x0028B38C
        ' (set) Token: 0x06000E21 RID: 3617 RVA: 0x0028C3A0 File Offset: 0x0028B3A0
        Friend Overridable Property tbProjectName() As TextBox
            Get
                Return Me._tbProjectName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbProjectName IsNot Nothing Then
                End If
                Me._tbProjectName = value
                If Me._tbProjectName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004ED RID: 1261
        ' (get) Token: 0x06000E23 RID: 3619 RVA: 0x0028C3BC File Offset: 0x0028B3BC
        ' (set) Token: 0x06000E24 RID: 3620 RVA: 0x0028C3D0 File Offset: 0x0028B3D0
        Friend Overridable Property rbKotor1() As RadioButton
            Get
                Return Me._rbKotor1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbKotor1 IsNot Nothing Then
                End If
                Me._rbKotor1 = value
                If Me._rbKotor1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004EE RID: 1262
        ' (get) Token: 0x06000E25 RID: 3621 RVA: 0x0028C3EC File Offset: 0x0028B3EC
        ' (set) Token: 0x06000E26 RID: 3622 RVA: 0x0028C400 File Offset: 0x0028B400
        Friend Overridable Property rbKotor2() As RadioButton
            Get
                Return Me._rbKotor2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbKotor2 IsNot Nothing Then
                End If
                Me._rbKotor2 = value
                If Me._rbKotor2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170004EF RID: 1263
        ' (get) Token: 0x06000E28 RID: 3624 RVA: 0x0028C41C File Offset: 0x0028B41C
        ' (set) Token: 0x06000E27 RID: 3623 RVA: 0x0028C430 File Offset: 0x0028B430
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

        ' Token: 0x06000E2A RID: 3626 RVA: 0x0028CCE0 File Offset: 0x0028BCE0
        Private Sub BrowseForFolder(ByRef fld As TextBox)
            Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
            folderBrowserDialog.Description = "Locate folder"
            folderBrowserDialog.SelectedPath = fld.Text
            folderBrowserDialog.ShowNewFolderButton = True
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = folderBrowserDialog.SelectedPath
            End If
        End Sub

        ' Token: 0x06000E2B RID: 3627 RVA: 0x0028CD28 File Offset: 0x0028BD28
        Private Sub BrowseForFile(ByRef fld As TextBox)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Title = "Select save location and project file name..."
            openFileDialog.Filter = "Kotor Tool Project (*.ktp)|*.ktp"
            openFileDialog.InitialDirectory = fld.Text
            openFileDialog.CheckFileExists = False
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = False
            openFileDialog.RestoreDirectory = True
            openFileDialog.FileName = "Project.ktp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = Path.GetDirectoryName(openFileDialog.FileName) + "\" + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".ktp"
            End If
        End Sub

        ' Token: 0x06000E2C RID: 3628 RVA: 0x0028CDBC File Offset: 0x0028BDBC
        Private Sub btnSelectProject_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbProjectPath As TextBox = Me.tbProjectPath
            Me.BrowseForFile(tbProjectPath)
            Me.tbProjectPath = tbProjectPath
        End Sub

        ' Token: 0x06000E2D RID: 3629 RVA: 0x0028CDE0 File Offset: 0x0028BDE0
        Private Sub btnKotorPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbDebugPath As TextBox = Me.tbDebugPath
            Me.BrowseForFolder(tbDebugPath)
            Me.tbDebugPath = tbDebugPath
        End Sub

        ' Token: 0x06000E2E RID: 3630 RVA: 0x0028CE04 File Offset: 0x0028BE04
        Private Sub btnReleasePath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbReleasePath As TextBox = Me.tbReleasePath
            Me.BrowseForFolder(tbReleasePath)
            Me.tbReleasePath = tbReleasePath
        End Sub

        ' Token: 0x06000E2F RID: 3631 RVA: 0x0028CE28 File Offset: 0x0028BE28
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            If StringType.StrCmp(Me.tbProjectName.Text.Trim(), "", False) = 0 Then
                Interaction.MsgBox("Project name not specified" & vbLf & "Please check your selection", MsgBoxStyle.Critical, Nothing)
                Return
            End If
            If StringType.StrCmp(Me.tbProjectPath.Text.Trim(), "", False) = 0 OrElse (StringType.StrCmp(Me.mode, "new", False) <> 0 AndAlso Not Directory.Exists(Path.GetDirectoryName(Me.tbProjectPath.Text.Trim()))) Then
                Interaction.MsgBox("Project path not found" & vbLf & "Please check your selection", MsgBoxStyle.Critical, Nothing)
                Return
            End If
            If StringType.StrCmp(Me.tbDebugPath.Text.Trim(), "", False) = 0 OrElse Not Directory.Exists(Me.tbDebugPath.Text.Trim()) Then
                Interaction.MsgBox("Debug path not found" & vbLf & "Please check your selection", MsgBoxStyle.Critical, Nothing)
                Return
            End If
            If StringType.StrCmp(Me.tbReleasePath.Text.Trim(), "", False) = 0 OrElse Not Directory.Exists(Me.tbReleasePath.Text.Trim()) Then
                Interaction.MsgBox("Release path not found" & vbLf & "Please check your selection", MsgBoxStyle.Critical, Nothing)
                Return
            End If
            If Not (Me.rbKotor1.Checked Or Me.rbKotor2.Checked) Then
                Interaction.MsgBox("Please select the Target Game for the project", MsgBoxStyle.Critical, Nothing)
                Return
            End If
            Me.DialogResult = DialogResult.OK
        End Sub

        ' Token: 0x040006D9 RID: 1753
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040006DA RID: 1754
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x040006DB RID: 1755
        <AccessedThroughProperty("btnReleasePath")> _
        Private _btnReleasePath As Button

        ' Token: 0x040006DC RID: 1756
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x040006DD RID: 1757
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x040006DE RID: 1758
        <AccessedThroughProperty("rbKotor2")> _
        Private _rbKotor2 As RadioButton

        ' Token: 0x040006DF RID: 1759
        <AccessedThroughProperty("tbDebugPath")> _
        Private _tbDebugPath As TextBox

        ' Token: 0x040006E0 RID: 1760
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x040006E1 RID: 1761
        <AccessedThroughProperty("btnKotorPath")> _
        Private _btnKotorPath As Button

        ' Token: 0x040006E2 RID: 1762
        <AccessedThroughProperty("tbReleasePath")> _
        Private _tbReleasePath As TextBox

        ' Token: 0x040006E3 RID: 1763
        <AccessedThroughProperty("btnSelectProject")> _
        Private _btnSelectProject As Button

        ' Token: 0x040006E4 RID: 1764
        <AccessedThroughProperty("tbProjectPath")> _
        Private _tbProjectPath As TextBox

        ' Token: 0x040006E5 RID: 1765
        <AccessedThroughProperty("tbProjectName")> _
        Private _tbProjectName As TextBox

        ' Token: 0x040006E6 RID: 1766
        <AccessedThroughProperty("rbKotor1")> _
        Private _rbKotor1 As RadioButton

        ' Token: 0x040006E7 RID: 1767
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040006E8 RID: 1768
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040006E9 RID: 1769
        Private mode As String
    End Class
End Namespace
