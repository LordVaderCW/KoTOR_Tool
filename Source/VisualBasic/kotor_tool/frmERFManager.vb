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
			Me.CurrentSettings = UserSettings.GetSettings()
		End Sub

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x0600049E RID: 1182 RVA: 0x0023D5F0 File Offset: 0x0023C5F0
		' (set) Token: 0x0600049F RID: 1183 RVA: 0x0023D5D4 File Offset: 0x0023C5D4
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

        ' Token: 0x1700015F RID: 351
        ' (get) Token: 0x060004A0 RID: 1184 RVA: 0x0023D604 File Offset: 0x0023C604
        ' (set) Token: 0x060004A1 RID: 1185 RVA: 0x0023D618 File Offset: 0x0023C618
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

        ' Token: 0x17000160 RID: 352
        ' (get) Token: 0x060004A3 RID: 1187 RVA: 0x0023D634 File Offset: 0x0023C634
        ' (set) Token: 0x060004A2 RID: 1186 RVA: 0x0023D648 File Offset: 0x0023C648
        Friend Overridable Property ERFContentFiles() As ListBox
            Get
                Return Me._ERFContentFiles
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ListBox)
                If Me._ERFContentFiles IsNot Nothing Then
                    RemoveHandler Me._ERFContentFiles.KeyUp, AddressOf Me.ERFContentFiles_KeyUp
                    RemoveHandler Me._ERFContentFiles.SelectedIndexChanged, AddressOf Me.ERFContentFiles_SelectedIndexChanged
                    RemoveHandler Me._ERFContentFiles.DragDrop, AddressOf Me.ERFContentFiles_DragDrop
                    RemoveHandler Me._ERFContentFiles.DragEnter, AddressOf Me.ERFContentFiles_DragEnter
                End If
                Me._ERFContentFiles = value
                If Me._ERFContentFiles IsNot Nothing Then
                    AddHandler Me._ERFContentFiles.KeyUp, AddressOf Me.ERFContentFiles_KeyUp
                    AddHandler Me._ERFContentFiles.SelectedIndexChanged, AddressOf Me.ERFContentFiles_SelectedIndexChanged
                    AddHandler Me._ERFContentFiles.DragDrop, AddressOf Me.ERFContentFiles_DragDrop
                    AddHandler Me._ERFContentFiles.DragEnter, AddressOf Me.ERFContentFiles_DragEnter
                End If
            End Set
        End Property

        ' Token: 0x17000161 RID: 353
        ' (get) Token: 0x060004A4 RID: 1188 RVA: 0x0023D72C File Offset: 0x0023C72C
        ' (set) Token: 0x060004A5 RID: 1189 RVA: 0x0023D740 File Offset: 0x0023C740
        Friend Overridable Property btnAddFile() As Button
            Get
                Return Me._btnAddFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnAddFile IsNot Nothing Then
                    RemoveHandler Me._btnAddFile.Click, AddressOf Me.btnAddFile_Click
                End If
                Me._btnAddFile = value
                If Me._btnAddFile IsNot Nothing Then
                    AddHandler Me._btnAddFile.Click, AddressOf Me.btnAddFile_Click
                End If
            End Set
        End Property

        ' Token: 0x17000162 RID: 354
        ' (get) Token: 0x060004A6 RID: 1190 RVA: 0x0023D794 File Offset: 0x0023C794
        ' (set) Token: 0x060004A7 RID: 1191 RVA: 0x0023D7A8 File Offset: 0x0023C7A8
        Friend Overridable Property btnRemoveItem() As Button
            Get
                Return Me._btnRemoveItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnRemoveItem IsNot Nothing Then
                    RemoveHandler Me._btnRemoveItem.Click, AddressOf Me.btnRemoveItem_Click
                End If
                Me._btnRemoveItem = value
                If Me._btnRemoveItem IsNot Nothing Then
                    AddHandler Me._btnRemoveItem.Click, AddressOf Me.btnRemoveItem_Click
                End If
            End Set
        End Property

        ' Token: 0x17000163 RID: 355
        ' (get) Token: 0x060004A8 RID: 1192 RVA: 0x0023D850 File Offset: 0x0023C850
        ' (set) Token: 0x060004A9 RID: 1193 RVA: 0x0023D7FC File Offset: 0x0023C7FC
        Friend Overridable Property btnMoveUp() As Button
            Get
                Return Me._btnMoveUp
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnMoveUp IsNot Nothing Then
                    RemoveHandler Me._btnMoveUp.Click, AddressOf Me.btnMoveUp_Click
                End If
                Me._btnMoveUp = value
                If Me._btnMoveUp IsNot Nothing Then
                    AddHandler Me._btnMoveUp.Click, AddressOf Me.btnMoveUp_Click
                End If
            End Set
        End Property

        ' Token: 0x17000164 RID: 356
        ' (get) Token: 0x060004AB RID: 1195 RVA: 0x0023D8B8 File Offset: 0x0023C8B8
        ' (set) Token: 0x060004AA RID: 1194 RVA: 0x0023D864 File Offset: 0x0023C864
        Friend Overridable Property btnMoveDown() As Button
            Get
                Return Me._btnMoveDown
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnMoveDown IsNot Nothing Then
                    RemoveHandler Me._btnMoveDown.Click, AddressOf Me.btnMoveDown_Click
                End If
                Me._btnMoveDown = value
                If Me._btnMoveDown IsNot Nothing Then
                    AddHandler Me._btnMoveDown.Click, AddressOf Me.btnMoveDown_Click
                End If
            End Set
        End Property

        ' Token: 0x17000165 RID: 357
        ' (get) Token: 0x060004AC RID: 1196 RVA: 0x0023D8CC File Offset: 0x0023C8CC
        ' (set) Token: 0x060004AD RID: 1197 RVA: 0x0023D8E0 File Offset: 0x0023C8E0
        Friend Overridable Property btnBuild() As Button
            Get
                Return Me._btnBuild
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnBuild IsNot Nothing Then
                    RemoveHandler Me._btnBuild.Click, AddressOf Me.btnBuild_Click
                End If
                Me._btnBuild = value
                If Me._btnBuild IsNot Nothing Then
                    AddHandler Me._btnBuild.Click, AddressOf Me.btnBuild_Click
                End If
            End Set
        End Property

        ' Token: 0x17000166 RID: 358
        ' (get) Token: 0x060004AE RID: 1198 RVA: 0x0023D988 File Offset: 0x0023C988
        ' (set) Token: 0x060004AF RID: 1199 RVA: 0x0023D934 File Offset: 0x0023C934
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

        ' Token: 0x17000167 RID: 359
        ' (get) Token: 0x060004B0 RID: 1200 RVA: 0x0023D99C File Offset: 0x0023C99C
        ' (set) Token: 0x060004B1 RID: 1201 RVA: 0x0023D9B0 File Offset: 0x0023C9B0
        Friend Overridable Property tbErfName() As TextBox
            Get
                Return Me._tbErfName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbErfName IsNot Nothing Then
                    RemoveHandler Me._tbErfName.TextChanged, AddressOf Me.tbErfName_TextChanged
                    RemoveHandler Me._tbErfName.ModifiedChanged, AddressOf Me.tbErfName_ModifiedChanged
                End If
                Me._tbErfName = value
                If Me._tbErfName IsNot Nothing Then
                    AddHandler Me._tbErfName.TextChanged, AddressOf Me.tbErfName_TextChanged
                    AddHandler Me._tbErfName.ModifiedChanged, AddressOf Me.tbErfName_ModifiedChanged
                End If
            End Set
        End Property

        ' Token: 0x17000168 RID: 360
        ' (get) Token: 0x060004B3 RID: 1203 RVA: 0x0023DA34 File Offset: 0x0023CA34
        ' (set) Token: 0x060004B2 RID: 1202 RVA: 0x0023DA48 File Offset: 0x0023CA48
        Friend Overridable Property cmbxErfType() As ComboBox
            Get
                Return Me._cmbxErfType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxErfType IsNot Nothing Then
                    RemoveHandler Me._cmbxErfType.SelectedIndexChanged, AddressOf Me.cmbxErfType_SelectedIndexChanged
                End If
                Me._cmbxErfType = value
                If Me._cmbxErfType IsNot Nothing Then
                    AddHandler Me._cmbxErfType.SelectedIndexChanged, AddressOf Me.cmbxErfType_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x17000169 RID: 361
        ' (get) Token: 0x060004B4 RID: 1204 RVA: 0x0023DA9C File Offset: 0x0023CA9C
        ' (set) Token: 0x060004B5 RID: 1205 RVA: 0x0023DAB0 File Offset: 0x0023CAB0
        Friend Overridable Property btnSelectOutputFile() As Button
            Get
                Return Me._btnSelectOutputFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSelectOutputFile IsNot Nothing Then
                    RemoveHandler Me._btnSelectOutputFile.Click, AddressOf Me.btnSelectOutputFile_Click
                End If
                Me._btnSelectOutputFile = value
                If Me._btnSelectOutputFile IsNot Nothing Then
                    AddHandler Me._btnSelectOutputFile.Click, AddressOf Me.btnSelectOutputFile_Click
                End If
            End Set
        End Property

        ' Token: 0x1700016A RID: 362
        ' (get) Token: 0x060004B6 RID: 1206 RVA: 0x0023DB04 File Offset: 0x0023CB04
        ' (set) Token: 0x060004B7 RID: 1207 RVA: 0x0023DB18 File Offset: 0x0023CB18
        Friend Overridable Property btnAddDirectory() As Button
            Get
                Return Me._btnAddDirectory
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnAddDirectory IsNot Nothing Then
                    RemoveHandler Me._btnAddDirectory.Click, AddressOf Me.btnAddDirectory_Click
                End If
                Me._btnAddDirectory = value
                If Me._btnAddDirectory IsNot Nothing Then
                    AddHandler Me._btnAddDirectory.Click, AddressOf Me.btnAddDirectory_Click
                End If
            End Set
        End Property

        ' Token: 0x060004B9 RID: 1209 RVA: 0x0023E2D0 File Offset: 0x0023D2D0
        Private Sub ERFContentFiles_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.All
            End If
        End Sub

        ' Token: 0x060004BA RID: 1210 RVA: 0x0023E2F0 File Offset: 0x0023D2F0
        Private Sub ERFContentFiles_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
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
        Private Sub btnMoveUp_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub btnMoveDown_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selectedIndex As Integer = Me.ERFContentFiles.SelectedIndex
            If selectedIndex < Me.ERFContentFiles.Items.Count - 1 Then
                Dim text As String = StringType.FromObject(Me.ERFContentFiles.SelectedItem)
                Me.ERFContentFiles.Items(selectedIndex) = RuntimeHelpers.GetObjectValue(Me.ERFContentFiles.Items(selectedIndex + 1))
                Me.ERFContentFiles.Items(selectedIndex + 1) = text
                Dim erfcontentFiles As ListBox = Me.ERFContentFiles
                erfcontentFiles.SelectedIndex += 1
            End If
        End Sub

        ' Token: 0x060004BD RID: 1213 RVA: 0x0023E4D0 File Offset: 0x0023D4D0
        Private Sub ERFContentFiles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub btnRemoveItem_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub btnSelectOutputFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, "", "Save ERF file...", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.tbErfName.Text = text
        End Sub

        ' Token: 0x060004C0 RID: 1216 RVA: 0x0023E700 File Offset: 0x0023D700
        Private Sub btnAddFile_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub btnAddDirectory_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x060004C3 RID: 1219 RVA: 0x0023E8E8 File Offset: 0x0023D8E8
        Private Sub btnBuild_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub ERFContentFiles_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
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
        Private Sub tbErfName_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.checkFieldsForBuild()
        End Sub

        ' Token: 0x060004C6 RID: 1222 RVA: 0x0023EA64 File Offset: 0x0023DA64
        Private Sub cmbxErfType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.checkFieldsForBuild()
            Me.btnBuild.Text = StringType.FromObject(ObjectType.StrCatObj("Build ", Me.cmbxErfType.SelectedItem))
        End Sub

        ' Token: 0x060004C7 RID: 1223 RVA: 0x0023EA94 File Offset: 0x0023DA94
        Private Sub tbErfName_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
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

        ' Token: 0x0400028B RID: 651
        <AccessedThroughProperty("btnRemoveItem")> _
        Private _btnRemoveItem As Button

        ' Token: 0x0400028C RID: 652
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x0400028D RID: 653
        <AccessedThroughProperty("btnAddDirectory")> _
        Private _btnAddDirectory As Button

        ' Token: 0x0400028E RID: 654
        <AccessedThroughProperty("btnSelectOutputFile")> _
        Private _btnSelectOutputFile As Button

        ' Token: 0x0400028F RID: 655
        <AccessedThroughProperty("cmbxErfType")> _
        Private _cmbxErfType As ComboBox

        ' Token: 0x04000290 RID: 656
        <AccessedThroughProperty("tbErfName")> _
        Private _tbErfName As TextBox

        ' Token: 0x04000291 RID: 657
        <AccessedThroughProperty("btnBuild")> _
        Private _btnBuild As Button

        ' Token: 0x04000292 RID: 658
        <AccessedThroughProperty("btnMoveDown")> _
        Private _btnMoveDown As Button

        ' Token: 0x04000293 RID: 659
        <AccessedThroughProperty("btnMoveUp")> _
        Private _btnMoveUp As Button

        ' Token: 0x04000294 RID: 660
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000295 RID: 661
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000296 RID: 662
        <AccessedThroughProperty("btnAddFile")> _
        Private _btnAddFile As Button

        ' Token: 0x04000297 RID: 663
        <AccessedThroughProperty("ERFContentFiles")> _
        Private _ERFContentFiles As ListBox

        ' Token: 0x04000299 RID: 665
        Public ERFContentFilesList As ArrayList
    End Class
End Namespace
