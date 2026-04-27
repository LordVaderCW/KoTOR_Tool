Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports mystuff.Controls

Namespace kotor_tool

    Partial Public Class frmTextEditor
        Inherits Form

        Private CurrentSettings As Options
        Private fname As String = String.Empty
        Private m_rtfMode As Boolean
        Private g_findPos As Integer
        Private g_findString As String = String.Empty
        Private g_searchup As Boolean
        Private g_matchcase As Boolean
        Private g_matchwholeword As Boolean
        Private g_searchoptions As RichTextBoxFinds
        Private storedPageSettings As PageSettings
        Private streamToPrint As StringReader
        Private printFont As Font
        Private _KotorVersionIndex As Integer
        Private _IsDirectEdit As Boolean
        Private _EditingFilePath As String = String.Empty
        Private funcs As frmTextEditor.func()

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmTextEditor_Load
            AddHandler MyBase.Closing, AddressOf Me.frmTextEditor_Closing

            Me.g_findPos = 0
            Me.storedPageSettings = Nothing
            Me.funcs = New frmTextEditor.func(876) {}

            Me.InitializeComponent()

            Me.miWordWrap.Checked = frmMain.CurrentSettings.bTextEditorWordWrap
            Me.tbGeneric.WordWrap = Me.miWordWrap.Checked
            Me.CurrentSettings = UserSettings.GetSettings()
        End Sub

        Public Sub New(ByVal filename As String, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()

            Me.fname = filename
            Me.Text = "Text Editor - " & Me.fname

            If IsDirectEdit Then
                Me._IsDirectEdit = True
                Me._EditingFilePath = EditingPath
            End If
        End Sub

        Public Sub New(ByVal EditingPath As String, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False)
            Me.New()

            Me.RTFMode = False
            Me.KotorVersionIndex = KotorVerIndex
            Me._IsDirectEdit = IsDirectEdit
            Me._EditingFilePath = EditingPath

            Dim streamReader As StreamReader = New StreamReader(Me._EditingFilePath)
            Me.tbGeneric.Text = streamReader.ReadToEnd()
            Me.tbGeneric.SelectionLength = 0
            streamReader.Close()
        End Sub

#Region "Designer Control Properties"

#End Region

#Region "Public Properties"

        Public Property EditingFilePath() As String
            Get
                Return Me._EditingFilePath
            End Get
            Set(ByVal value As String)
                Me._EditingFilePath = value
            End Set
        End Property

        Public Property DirectEdit() As Boolean
            Get
                Return Me._IsDirectEdit
            End Get
            Set(ByVal value As Boolean)
                Me._IsDirectEdit = value
            End Set
        End Property

        Public Property Filename() As String
            Get
                Return Me.fname
            End Get
            Set(ByVal value As String)
                Me.fname = value
                Me.Text = "Text Editor - " & value
            End Set
        End Property

        Public Property RTFMode() As Boolean
            Get
                Return Me.m_rtfMode
            End Get
            Set(ByVal value As Boolean)
                Me.m_rtfMode = value
            End Set
        End Property

        Public Property KotorVersionIndex() As Integer
            Get
                Return Me._KotorVersionIndex
            End Get
            Set(ByVal value As Integer)
                Me._KotorVersionIndex = value

                If Me.miCompile IsNot Nothing Then
                    Me.miCompile.Enabled = True
                End If

                If Me._KotorVersionIndex = 0 Then
                    If Me.miScriptIsK1 IsNot Nothing Then
                        Me.miScriptIsK1.Checked = True
                    End If
                ElseIf Me._KotorVersionIndex = 1 Then
                    If Me.miScriptIsK2 IsNot Nothing Then
                        Me.miScriptIsK2.Checked = True
                    End If
                End If
            End Set
        End Property

#End Region

#Region "Core Form Events"

        Private Sub frmTextEditor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow()
        End Sub

        Private Sub frmTextEditor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide()
        End Sub

#End Region

#Region "Window Settings"

        Public Sub PositionWindow()
            Dim point As Point = frmMain.CurrentSettings.TextEditorWindowLoc

            If Not point.IsEmpty Then
                Me.Location = point
            End If

            If Not frmMain.CurrentSettings.TextEditorWindowSize.IsEmpty Then
                Dim requestedSize As Size = frmMain.CurrentSettings.TextEditorWindowSize
                Dim finalWidth As Integer = requestedSize.Width
                Dim finalHeight As Integer = requestedSize.Height

                If finalHeight > Screen.PrimaryScreen.WorkingArea.Height Then
                    Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Top)
                    finalHeight = Screen.PrimaryScreen.WorkingArea.Height
                End If

                If finalWidth > Screen.PrimaryScreen.WorkingArea.Width Then
                    Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Left, Me.Location.Y)
                    finalWidth = Screen.PrimaryScreen.WorkingArea.Width
                End If

                Me.Size = New Size(finalWidth, finalHeight)
            End If
        End Sub

        Public Sub SaveSettings()
            If Me.WindowState = FormWindowState.Maximized OrElse Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Normal
            End If

            Dim saveWidth As Integer = Me.Size.Width
            Dim saveHeight As Integer = Me.Size.Height

            If saveHeight >= Screen.PrimaryScreen.WorkingArea.Height Then
                saveHeight = Screen.PrimaryScreen.WorkingArea.Height - 20
            End If

            If saveWidth >= Screen.PrimaryScreen.WorkingArea.Width Then
                saveWidth = Screen.PrimaryScreen.WorkingArea.Width - 20
            End If

            Me.Size = New Size(saveWidth, saveHeight)

            Dim saveLocation As Point = New Point(Me.Location.X, Me.Location.Y)

            If saveLocation.X < 0 Then
                saveLocation.X = 0
            End If

            If saveLocation.X + Me.Size.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                saveLocation.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Size.Width - 30
            End If

            If saveLocation.Y < 0 Then
                saveLocation.Y = 0
            End If

            If saveLocation.Y + Me.Size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                saveLocation.Y = Screen.PrimaryScreen.WorkingArea.Height - Me.Size.Height - 30
            End If

            Me.Location = saveLocation

            Me.CurrentSettings.TextEditorWindowLoc = Me.Location
            Me.CurrentSettings.TextEditorWindowSize = Me.Size

            UserSettings.SaveSettings(Me.CurrentSettings)
        End Sub

#End Region

#Region "Find Logic"

        Private Sub miFind_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim findDialog As frmTextEditorFind = New frmTextEditorFind()

            If Me.tbGeneric.SelectionLength > 0 Then
                findDialog.tbFindText.Text = Me.tbGeneric.SelectedText
            Else
                findDialog.tbFindText.Text = Me.g_findString
            End If

            findDialog.chkbMatchCase.Checked = Me.g_matchcase
            findDialog.chkbMatchWholeWord.Checked = Me.g_matchwholeword
            findDialog.chkbSearchUp.Checked = Me.g_searchup

            If findDialog.ShowDialog(Me) = DialogResult.OK Then
                If StringType.StrCmp(findDialog.tbFindText.Text, "", False) = 0 Then
                    Return
                End If

                Me.g_findString = findDialog.tbFindText.Text
                Me.g_searchoptions = RichTextBoxFinds.None
                Me.g_matchcase = findDialog.chkbMatchCase.Checked
                Me.g_matchwholeword = findDialog.chkbMatchWholeWord.Checked
                Me.g_searchup = findDialog.chkbSearchUp.Checked

                If Me.g_matchcase Then
                    Me.g_searchoptions = Me.g_searchoptions Or RichTextBoxFinds.MatchCase
                End If

                If Me.g_matchwholeword Then
                    Me.g_searchoptions = Me.g_searchoptions Or RichTextBoxFinds.WholeWord
                End If

                If Me.g_searchup Then
                    Me.g_searchoptions = Me.g_searchoptions Or RichTextBoxFinds.Reverse
                End If

                Me.SearchFromStart()
            End If
        End Sub

        Private Sub miFindAgain_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim previousFindPos As Integer = Me.g_findPos

            If StringType.StrCmp(Me.g_findString, "", False) = 0 Then
                Return
            End If

            If (Me.g_searchoptions And RichTextBoxFinds.Reverse) > RichTextBoxFinds.None Then
                Dim reverseStart As Integer

                If previousFindPos = -1 Then
                    reverseStart = Me.tbGeneric.TextLength
                Else
                    reverseStart = Me.g_findPos - 1
                End If

                Me.g_findPos = Me.tbGeneric.Find(Me.g_findString, 0, reverseStart, Me.g_searchoptions)
            Else
                Me.g_findPos = Me.tbGeneric.Find(Me.g_findString, Me.g_findPos + 1, Me.g_searchoptions)
            End If

            If Me.g_findPos = -1 Then
                If Interaction.MsgBox("No more occurrences found" & vbLf & "Start search from beginning of file?", MsgBoxStyle.YesNo, Nothing) <> MsgBoxResult.Yes Then
                    Me.tbGeneric.SelectionStart = previousFindPos
                    Me.tbGeneric.SelectionLength = Me.g_findString.Length
                    Me.tbGeneric.Focus()
                    Return
                End If

                Me.SearchFromStart()
            End If

            Me.tbGeneric.SelectionStart = Me.g_findPos
            Me.tbGeneric.SelectionLength = Me.g_findString.Length
            Me.tbGeneric.Focus()
        End Sub

        Private Sub SearchFromStart()
            Me.g_findPos = Me.tbGeneric.Find(Me.g_findString, Me.g_searchoptions)

            If Me.g_findPos = -1 Then
                Interaction.MsgBox("Text not found", MsgBoxStyle.Information, Nothing)
                Me.tbGeneric.SelectionStart = 0
                Me.tbGeneric.SelectionLength = 0
                Return
            End If

            Me.tbGeneric.SelectionStart = Me.g_findPos
            Me.tbGeneric.SelectionLength = Me.g_findString.Length
            Me.tbGeneric.Focus()
        End Sub

#End Region

#Region "Edit Menu"

        Private Sub miUndo_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.tbGeneric.Undo()
        End Sub

        Private Sub miRedo_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.tbGeneric.Redo()
        End Sub

        Private Sub miCut_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.tbGeneric.SelectedText.Equals("") Then
                Return
            End If

            If Me.RTFMode Then
                Clipboard.SetDataObject(Me.tbGeneric.SelectedRtf, True)
                Me.tbGeneric.SelectedRtf = ""
            Else
                Clipboard.SetDataObject(Me.tbGeneric.SelectedText, True)
                Me.tbGeneric.SelectedText = ""
            End If
        End Sub

        Private Sub miCopy_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RTFMode Then
                Clipboard.SetDataObject(Me.tbGeneric.SelectedRtf, True)
            Else
                Clipboard.SetDataObject(Me.tbGeneric.SelectedText, True)
            End If
        End Sub

        Private Sub miPaste_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim dataObject As DataObject = CType(Clipboard.GetDataObject(), DataObject)

                If dataObject.GetDataPresent(DataFormats.Rtf) Then
                    Dim rtfText As String = StringType.FromObject(dataObject.GetData(DataFormats.Rtf))

                    If Not rtfText.Equals("") Then
                        Me.tbGeneric.SelectedRtf = rtfText
                    End If
                ElseIf dataObject.GetDataPresent(DataFormats.Text) AndAlso Not Me.RTFMode Then
                    Dim plainText As String = StringType.FromObject(dataObject.GetData(DataFormats.Text))

                    If Not plainText.Equals("") Then
                        Me.tbGeneric.SelectedText = plainText
                    End If
                ElseIf dataObject.GetDataPresent(DataFormats.Text) Then
                    Dim textData As String = StringType.FromObject(dataObject.GetData(DataFormats.Text))

                    If Not textData.Equals("") Then
                        Me.tbGeneric.SelectedRtf = textData
                    End If
                End If
            Catch ex As System.Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub miSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.tbGeneric.SelectAll()
            Me.tbGeneric.Focus()
        End Sub

#End Region

#Region "File Menu"

        Private Sub miOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selectedPath As String = StringType.FromObject(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultSaveLocation, Me.fname, "Load file...", "", False, True))

            If StringType.StrCmp(selectedPath, "", False) = 0 Then
                Return
            End If

            Dim streamType As RichTextBoxStreamType

            If StringType.StrCmp(Strings.LCase(Path.GetExtension(selectedPath)), ".rtf", False) = 0 Then
                streamType = RichTextBoxStreamType.RichText
            Else
                streamType = RichTextBoxStreamType.PlainText
            End If

            Try
                Me.tbGeneric.Rtf = ""
                Me.tbGeneric.LoadFile(selectedPath, streamType)
            Catch ex As System.ArgumentException
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            If StringType.StrCmp(Me._EditingFilePath, "", False) = 0 Then
                Me._EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.TextEditorSavePath, Me.fname, "Save file...", "", False, True))

                If StringType.StrCmp(Me._EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If

            Dim fileStream As FileStream = New FileStream(Me._EditingFilePath, FileMode.Create)
            Dim streamWriter As StreamWriter = New StreamWriter(fileStream, Encoding.ASCII)

            streamWriter.Write(Strings.Replace(Me.tbGeneric.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary))
            streamWriter.Close()

            Me.CurrentSettings.TextEditorSavePath = Path.GetDirectoryName(Me._EditingFilePath)
            UserSettings.SaveSettings(Me.CurrentSettings)

            Me.Filename = Path.GetFileName(Me._EditingFilePath)
        End Sub

        Private Sub miSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim saveDirectory As String

            If Me._IsDirectEdit Then
                saveDirectory = Path.GetDirectoryName(Me._EditingFilePath)
            Else
                saveDirectory = Me.CurrentSettings.TextEditorSavePath
            End If

            Dim selectedPath As String = StringType.FromObject(frmMain.GetFilePath("save", saveDirectory, Me.fname, "Save file...", "", False, True))

            If StringType.StrCmp(selectedPath, "", False) = 0 Then
                Return
            End If

            Me.CurrentSettings.TextEditorSavePath = Path.GetDirectoryName(selectedPath)
            UserSettings.SaveSettings(Me.CurrentSettings)

            Dim fileStream As FileStream = New FileStream(selectedPath, FileMode.Create)
            Dim streamWriter As StreamWriter = New StreamWriter(fileStream, Encoding.ASCII)

            If Me.m_rtfMode Then
                streamWriter.Write(Me.tbGeneric.Rtf)
            Else
                streamWriter.Write(Strings.Replace(Me.tbGeneric.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary))
            End If

            streamWriter.Close()

            Me._EditingFilePath = selectedPath
            Me.Filename = Path.GetFileName(selectedPath)
        End Sub

        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

#End Region

#Region "Print Menu"

        Private Sub miPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.streamToPrint = New StringReader(Me.tbGeneric.Text)

            Try
                Try
                    Me.printFont = Me.tbGeneric.Font

                    Dim printDocument As PrintDocument = New PrintDocument()
                    AddHandler printDocument.PrintPage, AddressOf Me.pd_PrintPage

                    If Me.storedPageSettings IsNot Nothing Then
                        printDocument.DefaultPageSettings = Me.storedPageSettings
                    End If

                    Dim printDialog As PrintDialog = New PrintDialog()
                    printDialog.Document = printDocument

                    If printDialog.ShowDialog(Me) = DialogResult.OK Then
                        printDocument.Print()
                    End If
                Finally
                    If Me.streamToPrint IsNot Nothing Then
                        Me.streamToPrint.Close()
                    End If
                End Try
            Catch ex As System.Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
            Dim lineCount As Integer = 0
            Dim leftMargin As Single = CSng(ev.MarginBounds.Left)
            Dim topMargin As Single = CSng(ev.MarginBounds.Top)
            Dim line As String = Nothing
            Dim linesPerPage As Single = CSng(ev.MarginBounds.Height) / Me.printFont.GetHeight(ev.Graphics)

            While CSng(lineCount) < linesPerPage
                line = Me.streamToPrint.ReadLine()

                If line Is Nothing Then
                    Exit While
                End If

                Dim yPosition As Single = topMargin + CSng(lineCount) * Me.printFont.GetHeight(ev.Graphics)
                ev.Graphics.DrawString(line, Me.printFont, Brushes.Black, leftMargin, yPosition, New StringFormat())
                lineCount += 1
            End While

            ev.HasMorePages = line IsNot Nothing
        End Sub

        Private Sub miPageSetup_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim pageSetupDialog As PageSetupDialog = New PageSetupDialog()

                If Me.storedPageSettings Is Nothing Then
                    Me.storedPageSettings = New PageSettings()
                End If

                pageSetupDialog.PageSettings = Me.storedPageSettings
                pageSetupDialog.ShowDialog()
            Catch ex As System.Exception
                MessageBox.Show("An error occurred - " & ex.Message)
            End Try
        End Sub

        Private Sub miFont_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim fontDialog As FontDialog = New FontDialog()

            fontDialog.ShowColor = True
            fontDialog.Font = Me.tbGeneric.SelectionFont

            If fontDialog.ShowDialog() = DialogResult.OK Then
                If Me.tbGeneric.SelectionLength = 0 Then
                    Me.tbGeneric.Font = fontDialog.Font
                Else
                    Me.tbGeneric.SelectionFont = fontDialog.Font
                End If

                Me.tbGeneric.SelectionColor = fontDialog.Color
            End If
        End Sub

        Private Sub miWordWrap_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As MenuItem = CType(sender, MenuItem)

            If item.Checked Then
                Me.tbGeneric.WordWrap = False
                item.Checked = False
            Else
                Me.tbGeneric.WordWrap = True
                item.Checked = True
            End If
        End Sub

#End Region

#Region "Script Navigation"

        Private Sub miEncountersList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("Encounter List")
        End Sub

        Private Sub miPlaceablesList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("Placeable List")
        End Sub

        Private Sub miCameras_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("CameraList")
        End Sub

        Private Sub miDoorsList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("Door List")
        End Sub

        Private Sub miSoundsList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("SoundList")
        End Sub

        Private Sub miTriggersList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("TriggerList")
        End Sub

        Private Sub miWaypointsList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("WaypointList")
        End Sub

        Private Sub miCreatureList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("Creature List")
        End Sub

        Private Sub miMerchantList_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SearchForSection("StoreList")
        End Sub

        Private Sub SearchForSection(ByVal sectionName As String)
            Me.g_findString = sectionName
            Me.g_searchoptions = RichTextBoxFinds.None
            Me.g_matchcase = False
            Me.g_searchup = False
            Me.g_matchwholeword = False
            Me.SearchFromStart()
        End Sub

#End Region

#Region "Script Compile And Function Browser"

        Private Function CompileNSS() As String
            If Me._EditingFilePath IsNot Nothing AndAlso StringType.StrCmp(Me._EditingFilePath, "", False) <> 0 Then
                Dim gameArg As String = "-g " & Convert.ToString(Me._KotorVersionIndex + 1)
                Dim outputPath As String = Path.ChangeExtension(Me._EditingFilePath, ".ncs")

                If File.Exists(outputPath) Then
                    File.Delete(outputPath)
                End If

                Dim process As Process = New Process()

                process.StartInfo.FileName = frmMain.gRootPath & "nwnnsscomp.exe"
                process.StartInfo.UseShellExecute = False
                process.StartInfo.CreateNoWindow = True
                process.StartInfo.Arguments = String.Concat(New String() {"-c ", gameArg, " -o ", """", outputPath, """", " ", """", Me._EditingFilePath, """"})
                process.StartInfo.RedirectStandardOutput = True

                process.Start()

                Dim compilerOutput As String = process.StandardOutput.ReadToEnd()

                process.WaitForExit(4000)

                Interaction.MsgBox(compilerOutput, MsgBoxStyle.Information, "Compiler output")

                Return compilerOutput
            End If

            Return String.Empty
        End Function

        Private Sub miCompile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.miSave_Click(Nothing, Nothing)
            Me.CompileNSS()
        End Sub

        Private Sub miScriptIsK1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.KotorVersionIndex = 0
            Me.miScriptIsK2.Checked = False
            Me.miCompile.Enabled = True
            Me.PrepareForScriptEditing()
        End Sub

        Private Sub miScriptIsK2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.KotorVersionIndex = 1
            Me.miScriptIsK1.Checked = False
            Me.miCompile.Enabled = True
            Me.PrepareForScriptEditing()
        End Sub

        Public Sub PrepareForScriptEditing()
            Me.LoadNWScript(Me.KotorVersionIndex)
            Me.ShowFilterMatches()

            If Not Me.pnlFunctions.Visible Then
                Me.pnlFunctions.Visible = True
                Me.tbGeneric.Size = New Size(Me.tbGeneric.Size.Width, Me.tbGeneric.Size.Height - 128)
            End If
        End Sub

        Private Sub LoadNWScript(ByVal index As Integer)
            Dim scriptPath As String = Path.Combine(frmMain.CurrentSettings.KotorLocation(index), "override\nwscript.nss")
            Dim fileStream As FileStream = New FileStream(scriptPath, FileMode.Open)
            Dim streamReader As StreamReader = New StreamReader(fileStream)

            Dim startLine As Integer = 0
            Dim endLine As Integer = 0

            Select Case index
                Case 0
                    startLine = 1666
                    endLine = 3507
                    Me.funcs = New frmTextEditor.func(771) {}
                Case 1
                    startLine = 2044
                    endLine = 4277
                    Me.funcs = New frmTextEditor.func(876) {}
            End Select

            For i As Integer = 1 To startLine
                streamReader.ReadLine()
            Next

            Dim functionIndex As Integer = 0

            For i As Integer = 1 To endLine
                Dim line As String = streamReader.ReadLine()

                If line Is Nothing Then
                    Exit For
                End If

                If line.StartsWith("//") Then
                    If functionIndex >= 0 AndAlso functionIndex <= Me.funcs.GetUpperBound(0) Then
                        Me.funcs(functionIndex).comment = Me.funcs(functionIndex).comment & line & vbCrLf
                    End If
                ElseIf line.Length <> 0 Then
                    If functionIndex > Me.funcs.GetUpperBound(0) Then
                        Exit For
                    End If

                    Me.funcs(functionIndex).decl = line

                    Dim parts As String() = Strings.Split(line.Replace("(", " "), " ", -1, CompareMethod.Binary)
                    Dim nameIndex As Integer = 1

                    While nameIndex < parts.Length AndAlso StringType.StrCmp(parts(nameIndex), "", False) = 0
                        nameIndex += 1
                    End While

                    If nameIndex < parts.Length Then
                        Me.funcs(functionIndex).name = parts(nameIndex)
                    End If

                    functionIndex += 1
                End If
            Next

            streamReader.Close()
            fileStream.Close()
        End Sub

        Private Sub ShowFilterMatches()
            Me.lbFunctions.Items.Clear()
            Me.lbFunctions.Sorted = True

            Dim matches As String() = New String(Me.funcs.GetUpperBound(0)) {}
            Dim matchCount As Integer = 0
            Dim filterText As String = Me.tbFuncNameFilter.Text.Trim().ToLower()

            For i As Integer = 0 To Me.funcs.GetUpperBound(0)
                If Me.funcs(i).name Is Nothing Then
                    Continue For
                End If

                If filterText = String.Empty OrElse Me.funcs(i).name.ToLower().IndexOf(filterText) > -1 Then
                    matches(matchCount) = Me.funcs(i).name
                    matchCount += 1
                End If
            Next

            If matchCount > 0 Then
                Dim finalMatches As String() = New String(matchCount - 1) {}

                For i As Integer = 0 To matchCount - 1
                    finalMatches(i) = matches(i)
                Next

                Me.lbFunctions.Items.AddRange(finalMatches)

                If matchCount = 1 Then
                    Me.lbFunctions.SelectedIndex = 0
                    Me.lbFunctions_Click(Nothing, Nothing)
                End If
            End If

            Me.lblMatches.Text = "Matches: " & Me.lbFunctions.Items.Count.ToString()
        End Sub

        Private Sub tbFuncNameFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ShowFilterMatches()
        End Sub

        Private Sub lbFunctions_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lbFunctions.SelectedItem Is Nothing Then
                Return
            End If

            For i As Integer = 0 To Me.funcs.GetUpperBound(0)
                If StringType.StrCmp(Me.funcs(i).name, CStr(Me.lbFunctions.SelectedItem), False) = 0 Then
                    Me.tbFuncDecl.Text = Me.funcs(i).comment & vbCrLf & Me.funcs(i).decl
                    Exit For
                End If
            Next
        End Sub

        Private Sub lbFunctions_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lbFunctions.SelectedItem Is Nothing Then
                Return
            End If

            For i As Integer = 0 To Me.funcs.GetUpperBound(0)
                If StringType.StrCmp(Me.funcs(i).name, CStr(Me.lbFunctions.SelectedItem), False) = 0 Then
                    If (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
                        Me.tbGeneric.SelectedText = Me.funcs(i).decl
                    Else
                        Me.tbGeneric.SelectedText = Me.funcs(i).name & "("
                    End If

                    Me.tbGeneric.Focus()
                    Exit For
                End If
            Next
        End Sub

        Private Sub lbFunctions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.lbFunctions_Click(Nothing, Nothing)
        End Sub

#End Region

#Region "Text Box Events"

        Private Sub tbGeneric_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
            Me.miCut.Enabled = True
            Me.miCopy.Enabled = True
            Me.miPaste.Enabled = True
        End Sub

        Private Sub tbGeneric_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
            Me.miCut.Enabled = False
            Me.miCopy.Enabled = False
            Me.miPaste.Enabled = False
        End Sub

        Private Sub tbGeneric_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.X > 0 AndAlso e.X < 7 Then
                Cursor.Current = Cursors.Arrow
            Else
                Cursor.Current = Cursors.IBeam
            End If
        End Sub

        Private Sub tbGeneric_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Right Then
                If Me.tbGeneric.SelectionLength = 0 Then
                    Return
                End If

                Dim targetControl As Control = CType(sender, Control)
                Dim showPoint As Point = targetControl.PointToClient(Control.MousePosition)

                Me.cmText.Show(targetControl, showPoint)
            End If
        End Sub

        Private Sub cmiShowDefinition_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.tbFuncNameFilter.Text = Me.tbGeneric.SelectedText
        End Sub

#End Region

#Region "Backing Fields"

#End Region

        Public Structure func
            Public comment As String
            Public decl As String
            Public name As String
        End Structure

    End Class

End Namespace