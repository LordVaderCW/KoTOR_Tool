Imports System
Imports System.Collections
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
	' Token: 0x0200004A RID: 74
	Public Partial Class frmERFManager
		Inherits frmParent

		' Token: 0x0600049C RID: 1180 RVA: 0x0023D574 File Offset: 0x0023C574
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmERFManager_Load
			AddHandler MyBase.Closing, AddressOf Me.frmERFManager_Closing
            Me.InitializeComponent()
            Me.ApplyApplicationIcon()
            Me.CurrentSettings = UserSettings.GetSettings()
		End Sub

        ' Token: 0x060004B9 RID: 1209 RVA: 0x0023E2D0 File Offset: 0x0023D2D0
        Private Sub ERFContentFiles_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles ERFContentFiles.DragEnter
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.All
            End If
        End Sub

        ' Token: 0x060004BA RID: 1210 RVA: 0x0023E2F0 File Offset: 0x0023D2F0
        Private Sub ERFContentFiles_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles ERFContentFiles.DragDrop
            ' The following expression was wrapped in a checked-statement
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim array As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
                Dim num As Integer = 0
                Dim num2 As Integer = array.Length - 1
                For i As Integer = num To num2
                    If Path.GetFileNameWithoutExtension(array(i)).Length > 16 Then
                        Interaction.MsgBox(String.Concat(New String() {"The file """, array(i), """", " must be renamed to be no more than 16 characters long, not including the extension, to be used.", vbLf, vbLf, "The file will not be added."}), MsgBoxStyle.Critical, "Filename too long")
                    Else
                        Me.ERFContentFiles.Items.Add(array(i))
                    End If
                Next
            End If
            Me.checkFieldsForBuild()
        End Sub

        ' Token: 0x060004BB RID: 1211 RVA: 0x0023E3BC File Offset: 0x0023D3BC
        Private Sub btnMoveUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoveUp.Click
            Dim selectedIndex As Integer = Me.ERFContentFiles.SelectedIndex
            If selectedIndex > 0 Then
                Dim text As String = StringType.FromObject(Me.ERFContentFiles.SelectedItem)
                Me.ERFContentFiles.Items(selectedIndex) = RuntimeHelpers.GetObjectValue(Me.ERFContentFiles.Items(selectedIndex - 1))
                Me.ERFContentFiles.Items(selectedIndex - 1) = text
                Dim erfcontentFiles As ListBox = Me.ERFContentFiles
                erfcontentFiles.SelectedIndex -= 1
            End If
        End Sub

        ' Token: 0x060004BC RID: 1212 RVA: 0x0023E43C File Offset: 0x0023D43C
        Private Sub btnMoveDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoveDown.Click
            Dim selectedIndex As Integer = Me.ERFContentFiles.SelectedIndex
            If selectedIndex < Me.ERFContentFiles.Items.Count - 1 Then
                Dim text As String = StringType.FromObject(Me.ERFContentFiles.SelectedItem)
                Me.ERFContentFiles.Items(selectedIndex) = RuntimeHelpers.GetObjectValue(Me.ERFContentFiles.Items(selectedIndex + 1))
                Me.ERFContentFiles.Items(selectedIndex + 1) = text
                Dim erfcontentFiles As ListBox = Me.ERFContentFiles
                erfcontentFiles.SelectedIndex += 1
            End If
        End Sub

        Private Sub ApplyApplicationIcon()
            Try
                Me.Icon = My.Resources.koTOR_icn
            Catch ex As System.Exception
                'Console.WriteLine("Icon could not be applied: " & ex.Message)
            End Try
        End Sub

        ' Token: 0x060004BD RID: 1213 RVA: 0x0023E4D0 File Offset: 0x0023D4D0
        Private Sub ERFContentFiles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ERFContentFiles.SelectedIndexChanged
            If Me.ERFContentFiles.SelectedIndex = -1 Then
                Me.btnMoveUp.Enabled = False
                Me.btnMoveDown.Enabled = False
                Me.btnRemoveItem.Enabled = False
            Else
                Me.btnRemoveItem.Enabled = True
                If (Me.ERFContentFiles.Items.Count = 1) Or (Me.ERFContentFiles.SelectedIndices.Count > 1) Then
                    Me.btnMoveUp.Enabled = False
                    Me.btnMoveDown.Enabled = False
                ElseIf Me.ERFContentFiles.SelectedIndices.Count = 1 Then
                    ' The following expression was wrapped in a checked-expression
                    If Me.ERFContentFiles.SelectedIndex = Me.ERFContentFiles.Items.Count - 1 Then
                        Me.btnMoveUp.Enabled = True
                        Me.btnMoveDown.Enabled = False
                    ElseIf Me.ERFContentFiles.SelectedIndex = 0 Then
                        Me.btnMoveUp.Enabled = False
                        Me.btnMoveDown.Enabled = True
                    Else
                        Me.btnMoveUp.Enabled = True
                        Me.btnMoveDown.Enabled = True
                    End If
                End If
            End If
        End Sub

        ' Token: 0x060004BE RID: 1214 RVA: 0x0023E5F4 File Offset: 0x0023D5F4
        Private Sub btnRemoveItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveItem.Click
            ' The following expression was wrapped in a checked-statement
            If Me.ERFContentFiles.SelectedIndices.Count = 1 Then
                Me.RemoveItem()
            ElseIf Me.ERFContentFiles.SelectedIndices.Count > 1 AndAlso Interaction.MsgBox("Remove all " + StringType.FromInteger(Me.ERFContentFiles.SelectedIndices.Count) + " files?", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Confirm removal") = MsgBoxResult.Ok Then
                For i As Integer = Me.ERFContentFiles.SelectedIndices.Count - 1 To 0 Step -1
                    Me.ERFContentFiles.Items.RemoveAt(Me.ERFContentFiles.SelectedIndices(i))
                Next
            End If
            Me.checkFieldsForBuild()
        End Sub

        ' Token: 0x060004BF RID: 1215 RVA: 0x0023E6AC File Offset: 0x0023D6AC
        Private Sub btnSelectOutputFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectOutputFile.Click
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, "", "Save ERF file...", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.tbErfName.Text = text
        End Sub

        ' Token: 0x060004C0 RID: 1216 RVA: 0x0023E700 File Offset: 0x0023D700
        Private Sub btnAddFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddFile.Click
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.InitialDirectory = frmMain.CurrentSettings.defaultImportLocation
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = True
            openFileDialog.RestoreDirectory = True
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                For Each text As String In openFileDialog.FileNames
                    If Path.GetFileNameWithoutExtension(text).Length > 16 Then
                        Interaction.MsgBox(String.Concat(New String() {"The file """, text, """", " must be renamed to be no more than 16 characters long, not including the extension, to be used.", vbLf, vbLf, "The file will not be added."}), MsgBoxStyle.Critical, "Filename too long")
                    Else
                        Me.ERFContentFiles.Items.Add(text)
                    End If
                Next
            End If
            Me.checkFieldsForBuild()
        End Sub

        ' Token: 0x060004C1 RID: 1217 RVA: 0x0023E7DC File Offset: 0x0023D7DC
        Private Sub btnAddDirectory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddDirectory.Click
            Dim text As String = Me.BrowseForFolder()
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim arrayList As ArrayList = New ArrayList()
            If Interaction.MsgBox("Do you want to filter out unknown file types?", MsgBoxStyle.YesNo, "Filter files") = MsgBoxResult.No Then
                Me.AddFileNamesToList(text, arrayList, "*.*")
            Else
                Me.AddFileNamesToList(text, arrayList, "*.git")
                Me.AddFileNamesToList(text, arrayList, "*.are")
                Me.AddFileNamesToList(text, arrayList, "*.ifo")
                Me.AddFileNamesToList(text, arrayList, "*.pth")
                Me.AddFileNamesToList(text, arrayList, "*.u??")
                Me.AddFileNamesToList(text, arrayList, "*.ncs")
                Me.AddFileNamesToList(text, arrayList, "*.dlg")
            End If
            Try
                For Each obj As Object In arrayList
                    Dim text2 As String = StringType.FromObject(obj)
                    Me.ERFContentFiles.Items.Add(text2)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x060004C2 RID: 1218 RVA: 0x0023E8E0 File Offset: 0x0023D8E0
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        ' Token: 0x060004C3 RID: 1219 RVA: 0x0023E8E8 File Offset: 0x0023D8E8
        Private Sub btnBuild_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuild.Click
            ' The following expression was wrapped in a checked-statement
            Dim array As String() = New String(Me.ERFContentFiles.Items.Count - 1 + 1 - 1) {}
            Dim num As Integer = 0
            Dim num2 As Integer = Me.ERFContentFiles.Items.Count - 1
            For i As Integer = num To num2
                array(i) = StringType.FromObject(Me.ERFContentFiles.Items(i))
            Next
            Dim clsERF As clsERF = New clsERF(Me.tbErfName.Text, StringType.FromObject(Me.cmbxErfType.SelectedItem), Convert.ToUInt32(0), Nothing, array)
            Interaction.MsgBox("ERF Build Complete", MsgBoxStyle.OkOnly, Nothing)
            Me.btnCancel.Text = "Done"
            Me.btnCancel.Focus()
        End Sub

        ' Token: 0x060004C4 RID: 1220 RVA: 0x0023E99C File Offset: 0x0023D99C
        Private Sub ERFContentFiles_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ERFContentFiles.KeyUp
            ' The following expression was wrapped in a checked-statement
            If e.KeyCode = Keys.Delete AndAlso Me.ERFContentFiles.SelectedIndices.Count > 0 Then
                If Me.ERFContentFiles.SelectedIndices.Count > 1 Then
                    If Interaction.MsgBox("Remove all " + StringType.FromInteger(Me.ERFContentFiles.SelectedIndices.Count) + "files?", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Confirm removal") = MsgBoxResult.Ok Then
                        For i As Integer = Me.ERFContentFiles.SelectedIndices.Count - 1 To 0 Step -1
                            Me.ERFContentFiles.Items.RemoveAt(Me.ERFContentFiles.SelectedIndices(i))
                        Next
                    End If
                Else
                    Me.RemoveItem()
                End If
            End If
        End Sub

        ' Token: 0x060004C5 RID: 1221 RVA: 0x0023EA5C File Offset: 0x0023DA5C
        Private Sub tbErfName_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbErfName.ModifiedChanged
            Me.checkFieldsForBuild()
        End Sub

        ' Token: 0x060004C6 RID: 1222 RVA: 0x0023EA64 File Offset: 0x0023DA64
        Private Sub cmbxErfType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxErfType.SelectedIndexChanged
            Me.checkFieldsForBuild()
            Me.btnBuild.Text = StringType.FromObject(ObjectType.StrCatObj("Build ", Me.cmbxErfType.SelectedItem))
        End Sub

        ' Token: 0x060004C7 RID: 1223 RVA: 0x0023EA94 File Offset: 0x0023DA94
        Private Sub tbErfName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbErfName.TextChanged
            Me.checkFieldsForBuild()
        End Sub

        ' Token: 0x060004C8 RID: 1224 RVA: 0x0023EA9C File Offset: 0x0023DA9C
        Private Sub frmERFManager_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060004C9 RID: 1225 RVA: 0x0023EAB0 File Offset: 0x0023DAB0
        Private Sub frmERFManager_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060004CA RID: 1226 RVA: 0x0023EAC4 File Offset: 0x0023DAC4
        Public Sub checkFieldsForBuild()
            If Me.ERFContentFiles.Items.Count > 0 AndAlso StringType.StrCmp(Me.tbErfName.Text, "", False) <> 0 AndAlso Me.cmbxErfType.SelectedIndex <> -1 Then
                Me.btnBuild.Enabled = True
            Else
                Me.btnBuild.Enabled = False
            End If
        End Sub

        ' Token: 0x060004CB RID: 1227 RVA: 0x0023EB28 File Offset: 0x0023DB28
        Private Sub RemoveItem()
            Me.ERFContentFiles.Items.RemoveAt(Me.ERFContentFiles.SelectedIndex)
        End Sub

        ' Token: 0x060004CC RID: 1228 RVA: 0x0023EB48 File Offset: 0x0023DB48
        Private Function BrowseForFolder() As String
            Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
            folderBrowserDialog.Description = "Locate folder"
            folderBrowserDialog.SelectedPath = Me.CurrentSettings.defaultImportLocation
            folderBrowserDialog.ShowNewFolderButton = False
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Return folderBrowserDialog.SelectedPath
            End If
            Dim text As String
            Return text
        End Function

        ' Token: 0x060004CD RID: 1229 RVA: 0x0023EB90 File Offset: 0x0023DB90
        Private Sub AddFileNamesToList(ByVal path As String, ByRef list As ArrayList, ByVal wildcard As String)
            Dim files As String() = Directory.GetFiles(path, wildcard)
            If files.Length > 0 Then
                For Each text As String In files
                    list.Add(text)
                Next
            End If
        End Sub

        ' Token: 0x04000299 RID: 665
        Public ERFContentFilesList As ArrayList
    End Class
End Namespace
