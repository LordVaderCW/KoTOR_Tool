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
        Private Sub btnSelectProject_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectProject.Click
            Dim tbProjectPath As TextBox = Me.tbProjectPath
            Me.BrowseForFile(tbProjectPath)
            Me.tbProjectPath = tbProjectPath
        End Sub

        ' Token: 0x06000E2D RID: 3629 RVA: 0x0028CDE0 File Offset: 0x0028BDE0
        Private Sub btnKotorPath_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnKotorPath.Click
            Dim tbDebugPath As TextBox = Me.tbDebugPath
            Me.BrowseForFolder(tbDebugPath)
            Me.tbDebugPath = tbDebugPath
        End Sub

        ' Token: 0x06000E2E RID: 3630 RVA: 0x0028CE04 File Offset: 0x0028BE04
        Private Sub btnReleasePath_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReleasePath.Click
            Dim tbReleasePath As TextBox = Me.tbReleasePath
            Me.BrowseForFolder(tbReleasePath)
            Me.tbReleasePath = tbReleasePath
        End Sub

        ' Token: 0x06000E2F RID: 3631 RVA: 0x0028CE28 File Offset: 0x0028BE28
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
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

        ' Token: 0x040006E9 RID: 1769
        Private mode As String
    End Class
End Namespace
