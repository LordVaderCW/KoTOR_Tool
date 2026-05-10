Option Strict Off
Option Explicit On

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
        Private _KotorVersionIndex As Integer = -1
        Private _IsDirectEdit As Boolean
        Private _EditingFilePath As String = String.Empty
        Private _isDirty As Boolean
        Private _loadingDocument As Boolean
        Private _currentEncoding As Encoding
        Private funcs As frmTextEditor.func()

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmTextEditor_Load
            AddHandler MyBase.Shown, AddressOf Me.frmTextEditor_Shown
            AddHandler MyBase.Closing, AddressOf Me.frmTextEditor_Closing

            Me.g_findPos = 0
            Me.storedPageSettings = Nothing
            Me.funcs = New frmTextEditor.func(876) {}

            Me.InitializeComponent()
            Me.ApplyApplicationIcon()
            KotorThemeApplier.ApplyToForm(Me)

            Me.miWordWrap.Checked = frmMain.CurrentSettings.bTextEditorWordWrap
            Me.tbGeneric.WordWrap = Me.miWordWrap.Checked
            Me.CurrentSettings = UserSettings.GetSettings()
            Me._currentEncoding = Encoding.ASCII
            Me.SetDirty(False)
            Me.UpdateStatus()


        End Sub

        Public Sub New(ByVal filename As String, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()

            Me.fname = filename
            Me.UpdateWindowTitle()

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

            Me.LoadDocumentFromPath(Me._EditingFilePath)
        End Sub

        Private Sub ApplyApplicationIcon()
            Try
                Me.Icon = My.Resources.koTOR_icn
            Catch ex As System.Exception
                'Console.WriteLine("Icon could not be applied: " & ex.Message)
            End Try
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
                Me.UpdateStatus()
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
                Me.UpdateWindowTitle()
                Me.UpdateStatus()
            End Set
        End Property

        Public Property RTFMode() As Boolean
            Get
                Return Me.m_rtfMode
            End Get
            Set(ByVal value As Boolean)
                Me.m_rtfMode = value
                Me.UpdateStatus()
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
                Me.UpdateStatus()
            End Set
        End Property

#End Region

#Region "Core Form Events"

        Private Sub frmTextEditor_Load(ByVal sender As Object, ByVal e As EventArgs)
            KotorThemeApplier.ApplyToForm(Me)
            Me.PositionWindow()
            Me.UpdateStatus()
        End Sub

        Private Sub frmTextEditor_Shown(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetDirty(False)
        End Sub

        Private Sub frmTextEditor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            If Me._isDirty Then
                Dim result As DialogResult = MessageBox.Show(Me, "Save changes?", "Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                If result = DialogResult.Cancel Then
                    e.Cancel = True
                    Return
                End If

                If result = DialogResult.Yes Then
                    If Me.SaveDocument(False) = False Then
                        e.Cancel = True
                        Return
                    End If
                End If
            End If

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

#Region "Dirty State And Status"

        Private Sub SetDirty(ByVal value As Boolean)
            Me._isDirty = value
            Me.UpdateWindowTitle()
            Me.UpdateStatus()
        End Sub

        Private Sub UpdateWindowTitle()
            Dim displayName As String = Me.fname

            If displayName Is Nothing OrElse displayName.Length = 0 Then
                displayName = "Untitled"
            End If

            Me.Text = "Text Editor - " & displayName & If(Me._isDirty, " *", "")
        End Sub

        Private Sub UpdateStatus()
            If Me.statusFile Is Nothing Then
                Return
            End If

            Dim displayName As String = Me.fname
            If displayName Is Nothing OrElse displayName.Length = 0 Then
                displayName = "Untitled"
            End If

            Dim lineIndex As Integer = 0
            Dim columnIndex As Integer = 0

            Try
                lineIndex = Me.tbGeneric.GetLineFromCharIndex(Me.tbGeneric.SelectionStart)
                columnIndex = Me.tbGeneric.SelectionStart - Me.tbGeneric.GetFirstCharIndexFromLine(lineIndex)
            Catch ex As System.Exception
                lineIndex = 0
                columnIndex = 0
            End Try

            Me.statusFile.Text = displayName
            Me.statusMode.Text = If(Me.RTFMode, "RTF mode", "Plain Text")
            Me.statusPosition.Text = "Ln " & (lineIndex + 1).ToString() & ", Col " & (columnIndex + 1).ToString()
            Me.statusSelection.Text = "Sel " & Me.tbGeneric.SelectionLength.ToString()
            Me.statusCharacters.Text = "Chars " & Me.tbGeneric.TextLength.ToString()
            Me.statusDirty.Text = If(Me._isDirty, "Dirty", "Saved")

            If Me._KotorVersionIndex = 0 Then
                Me.statusScriptTarget.Text = "Script: KotOR I"
            ElseIf Me._KotorVersionIndex = 1 Then
                Me.statusScriptTarget.Text = "Script: KotOR II"
            Else
                Me.statusScriptTarget.Text = "Script: Not Set"
            End If
        End Sub

        Private Sub tbGeneric_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbGeneric.TextChanged
            If Me._loadingDocument = False Then
                Me.SetDirty(True)
            Else
                Me.UpdateStatus()
            End If
        End Sub

        Private Sub tbGeneric_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbGeneric.SelectionChanged
            Me.UpdateStatus()
        End Sub

#End Region

#Region "Find Logic"

        Private Sub miFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miFind.Click
            Me.ShowFindReplaceDialog(False)
        End Sub

        Private Sub miReplace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miReplace.Click
            Me.ShowFindReplaceDialog(True)
        End Sub

        Private Sub ShowFindReplaceDialog(ByVal replaceMode As Boolean)
            Dim findDialog As frmTextEditorFind = New frmTextEditorFind()

            If Me.tbGeneric.SelectionLength > 0 Then
                findDialog.tbFindText.Text = Me.tbGeneric.SelectedText
            Else
                findDialog.tbFindText.Text = Me.g_findString
            End If

            findDialog.chkbMatchCase.Checked = Me.g_matchcase
            findDialog.chkbMatchWholeWord.Checked = Me.g_matchwholeword
            findDialog.chkbSearchUp.Checked = Me.g_searchup
            findDialog.tbReplaceText.Enabled = replaceMode
            findDialog.lblReplaceText.Enabled = replaceMode
            findDialog.btnReplace.Enabled = replaceMode
            findDialog.btnReplaceAll.Enabled = replaceMode
            findDialog.Text = If(replaceMode, "Replace", "Find")

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

                If findDialog.RequestedAction = frmTextEditorFind.TextEditorFindAction.ReplaceNext Then
                    Me.ReplaceNext(findDialog.tbReplaceText.Text)
                ElseIf findDialog.RequestedAction = frmTextEditorFind.TextEditorFindAction.ReplaceAll Then
                    Me.ReplaceAllMatches(findDialog.tbReplaceText.Text)
                Else
                    Me.FindNext(True, True)
                End If
            End If
        End Sub

        Private Sub miFindAgain_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miFindAgain.Click
            If StringType.StrCmp(Me.g_findString, "", False) = 0 Then
                Return
            End If

            Me.FindNext(True, True)
        End Sub

        Private Function FindNext(ByVal allowWrap As Boolean, ByVal showMessages As Boolean) As Boolean
            Dim previousStart As Integer = Me.tbGeneric.SelectionStart
            Dim previousLength As Integer = Me.tbGeneric.SelectionLength

            If Me.g_findString Is Nothing OrElse Me.g_findString.Length = 0 Then
                Return False
            End If

            If (Me.g_searchoptions And RichTextBoxFinds.Reverse) > RichTextBoxFinds.None Then
                Dim reverseStart As Integer = previousStart

                If reverseStart <= 0 Then
                    If allowWrap Then
                        reverseStart = Me.tbGeneric.TextLength
                    Else
                        Return False
                    End If
                End If

                If reverseStart > Me.tbGeneric.TextLength Then
                    reverseStart = Me.tbGeneric.TextLength
                End If

                Me.g_findPos = Me.tbGeneric.Find(Me.g_findString, 0, reverseStart, Me.g_searchoptions)
            Else
                Dim forwardStart As Integer = previousStart

                If previousLength > 0 Then
                    forwardStart = previousStart + previousLength
                End If

                If forwardStart > Me.tbGeneric.TextLength Then
                    forwardStart = Me.tbGeneric.TextLength
                End If

                Me.g_findPos = Me.tbGeneric.Find(Me.g_findString, forwardStart, Me.g_searchoptions)
            End If

            If Me.g_findPos = -1 Then
                If allowWrap AndAlso showMessages Then
                    If Interaction.MsgBox("No more occurrences found" & vbLf & "Start search from " & If(Me.g_searchup, "end", "beginning") & " of file?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes Then
                        Return Me.SearchFromBoundary(showMessages)
                    End If
                End If

                Me.tbGeneric.SelectionStart = previousStart
                Me.tbGeneric.SelectionLength = previousLength
                Me.tbGeneric.Focus()
                Return False
            End If

            Me.tbGeneric.SelectionStart = Me.g_findPos
            Me.tbGeneric.SelectionLength = Me.g_findString.Length
            Me.tbGeneric.Focus()
            Me.UpdateStatus()
            Return True
        End Function

        Private Function SearchFromBoundary(ByVal showMessages As Boolean) As Boolean
            Dim previousStart As Integer = Me.tbGeneric.SelectionStart
            Dim previousLength As Integer = Me.tbGeneric.SelectionLength

            If Me.g_findString Is Nothing OrElse Me.g_findString.Length = 0 Then
                Return False
            End If

            If (Me.g_searchoptions And RichTextBoxFinds.Reverse) > RichTextBoxFinds.None Then
                Me.g_findPos = Me.tbGeneric.Find(Me.g_findString, 0, Me.tbGeneric.TextLength, Me.g_searchoptions)
            Else
                Me.g_findPos = Me.tbGeneric.Find(Me.g_findString, 0, Me.g_searchoptions)
            End If

            If Me.g_findPos = -1 Then
                If showMessages Then
                    Interaction.MsgBox("Text not found", MsgBoxStyle.Information, Nothing)
                End If
                Me.tbGeneric.SelectionStart = previousStart
                Me.tbGeneric.SelectionLength = previousLength
                Me.tbGeneric.Focus()
                Return False
            End If

            Me.tbGeneric.SelectionStart = Me.g_findPos
            Me.tbGeneric.SelectionLength = Me.g_findString.Length
            Me.tbGeneric.Focus()
            Me.UpdateStatus()
            Return True
        End Function

        Private Sub SearchFromStart()
            Me.SearchFromBoundary(True)
        End Sub

        Private Function CurrentSelectionMatchesFind() As Boolean
            If Me.g_findString Is Nothing OrElse Me.g_findString.Length = 0 Then
                Return False
            End If

            If Me.tbGeneric.SelectionLength <> Me.g_findString.Length Then
                Return False
            End If

            If String.Compare(Me.tbGeneric.SelectedText, Me.g_findString, Not Me.g_matchcase) <> 0 Then
                Return False
            End If

            If Me.g_matchwholeword Then
                Dim startIndex As Integer = Me.tbGeneric.SelectionStart
                Dim endIndex As Integer = startIndex + Me.tbGeneric.SelectionLength

                If startIndex > 0 AndAlso IsWordChar(Me.tbGeneric.Text.Chars(startIndex - 1)) Then
                    Return False
                End If

                If endIndex < Me.tbGeneric.TextLength AndAlso IsWordChar(Me.tbGeneric.Text.Chars(endIndex)) Then
                    Return False
                End If
            End If

            Return True
        End Function

        Private Function IsWordChar(ByVal ch As Char) As Boolean
            Return Char.IsLetterOrDigit(ch) OrElse ch = "_"c
        End Function

        Private Sub ReplaceNext(ByVal replacementText As String)
            If Me.g_findString Is Nothing OrElse Me.g_findString.Length = 0 Then
                Return
            End If

            If Me.CurrentSelectionMatchesFind() = False Then
                If Me.FindNext(True, True) = False Then
                    Return
                End If
            End If

            Me.tbGeneric.SelectedText = replacementText
            Me.FindNext(False, False)
            Me.UpdateStatus()
        End Sub

        Private Sub ReplaceAllMatches(ByVal replacementText As String)
            If Me.g_findString Is Nothing OrElse Me.g_findString.Length = 0 Then
                Return
            End If

            Dim replaceCount As Integer = 0
            Dim searchStart As Integer = 0
            Dim foundAt As Integer
            Dim replaceOptions As RichTextBoxFinds = Me.g_searchoptions

            If (replaceOptions And RichTextBoxFinds.Reverse) > RichTextBoxFinds.None Then
                replaceOptions = replaceOptions Xor RichTextBoxFinds.Reverse
            End If

            Do
                foundAt = Me.tbGeneric.Find(Me.g_findString, searchStart, replaceOptions)

                If foundAt = -1 Then
                    Exit Do
                End If

                Me.tbGeneric.SelectionStart = foundAt
                Me.tbGeneric.SelectionLength = Me.g_findString.Length
                Me.tbGeneric.SelectedText = replacementText
                replaceCount += 1
                searchStart = foundAt + replacementText.Length

                If searchStart > Me.tbGeneric.TextLength Then
                    Exit Do
                End If
            Loop

            MessageBox.Show(Me, replaceCount.ToString() & " replacement(s) made.", "Replace All", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.UpdateStatus()
        End Sub

#End Region

#Region "Edit Menu"

        Private Sub miUndo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miUndo.Click
            Me.tbGeneric.Undo()
        End Sub

        Private Sub miRedo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miRedo.Click
            Me.tbGeneric.Redo()
        End Sub

        Private Sub miCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCut.Click
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

        Private Sub miCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCopy.Click
            If Me.RTFMode Then
                Clipboard.SetDataObject(Me.tbGeneric.SelectedRtf, True)
            Else
                Clipboard.SetDataObject(Me.tbGeneric.SelectedText, True)
            End If
        End Sub

        Private Sub miPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miPaste.Click
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

        Private Sub miSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miSelectAll.Click
            Me.tbGeneric.SelectAll()
            Me.tbGeneric.Focus()
        End Sub

        Private Sub miGoToLine_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miGoToLine.Click
            Dim input As String = Interaction.InputBox("Line number:", "Go To Line", "1")

            If input Is Nothing OrElse input.Trim().Length = 0 Then
                Return
            End If

            Dim requestedLine As Integer

            Try
                requestedLine = Integer.Parse(input.Trim())
            Catch ex As System.Exception
                MessageBox.Show(Me, "Please enter a valid line number.", "Go To Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End Try

            Dim lineCount As Integer = Me.tbGeneric.Lines.Length

            If lineCount < 1 Then
                lineCount = 1
            End If

            If requestedLine < 1 Then
                requestedLine = 1
            ElseIf requestedLine > lineCount Then
                requestedLine = lineCount
            End If

            Dim charIndex As Integer = Me.tbGeneric.GetFirstCharIndexFromLine(requestedLine - 1)

            If charIndex < 0 Then
                charIndex = Me.tbGeneric.TextLength
            End If

            Me.tbGeneric.SelectionStart = charIndex
            Me.tbGeneric.SelectionLength = 0
            Me.tbGeneric.Focus()
            Me.UpdateStatus()
        End Sub

#End Region

#Region "File Menu"

        Private Sub miOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpen.Click
            Dim selectedPath As String = StringType.FromObject(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultSaveLocation, Me.fname, "Load file...", "", False, True))

            If StringType.StrCmp(selectedPath, "", False) = 0 Then
                Return
            End If

            Me.LoadDocumentFromPath(selectedPath)
        End Sub

        Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miSave.Click
            Me.SaveDocument(False)
        End Sub

        Private Sub miSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miSaveAs.Click
            Me.SaveDocument(True)
        End Sub

        Private Function SaveDocument(ByVal forceSaveAs As Boolean) As Boolean
            Dim saveDirectory As String

            If Me._IsDirectEdit AndAlso Me._EditingFilePath IsNot Nothing AndAlso Me._EditingFilePath.Length > 0 Then
                saveDirectory = Path.GetDirectoryName(Me._EditingFilePath)
            Else
                saveDirectory = Me.CurrentSettings.TextEditorSavePath
            End If

            Dim selectedPath As String = Me._EditingFilePath

            If forceSaveAs OrElse selectedPath Is Nothing OrElse selectedPath.Length = 0 Then
                selectedPath = StringType.FromObject(frmMain.GetFilePath("save", saveDirectory, Me.fname, "Save file...", "", False, True))

                If StringType.StrCmp(selectedPath, "", False) = 0 Then
                    Return False
                End If
            End If

            Try
                If Me.m_rtfMode Then
                    Dim fileStream As FileStream = New FileStream(selectedPath, FileMode.Create, FileAccess.Write)
                    Try
                        Dim streamWriter As StreamWriter = New StreamWriter(fileStream, If(Me._currentEncoding Is Nothing, Encoding.ASCII, Me._currentEncoding))
                        Try
                            streamWriter.Write(Me.tbGeneric.Rtf)
                        Finally
                            streamWriter.Close()
                        End Try
                    Finally
                        fileStream.Close()
                    End Try
                Else
                    Dim textToWrite As String = Me.NormalizeCrLf(Me.tbGeneric.Text)
                    Dim saveEncoding As Encoding = If(Me._currentEncoding Is Nothing, Encoding.ASCII, Me._currentEncoding)
                    Dim fileStream As FileStream = New FileStream(selectedPath, FileMode.Create, FileAccess.Write)
                    Try
                        Dim streamWriter As StreamWriter = New StreamWriter(fileStream, saveEncoding)
                        Try
                            streamWriter.Write(textToWrite)
                        Finally
                            streamWriter.Close()
                        End Try
                    Finally
                        fileStream.Close()
                    End Try
                End If

                Me.CurrentSettings.TextEditorSavePath = Path.GetDirectoryName(selectedPath)
                UserSettings.SaveSettings(Me.CurrentSettings)

                Me._EditingFilePath = selectedPath
                Me.Filename = Path.GetFileName(selectedPath)
                Me.SetDirty(False)
                Return True
            Catch ex As System.Exception
                MessageBox.Show(Me, "Unable to save file:" & vbCrLf & ex.Message, "Save file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            Return False
        End Function

        Private Sub LoadDocumentFromPath(ByVal selectedPath As String)
            Try
                Me._loadingDocument = True
                Me.tbGeneric.Clear()

                If StringType.StrCmp(Strings.LCase(Path.GetExtension(selectedPath)), ".rtf", False) = 0 Then
                    Me.RTFMode = True
                    Me.tbGeneric.LoadFile(selectedPath, RichTextBoxStreamType.RichText)
                    Me._currentEncoding = Encoding.ASCII
                Else
                    Me.RTFMode = False
                    Me._currentEncoding = Me.DetectTextEncoding(selectedPath)
                    Dim streamReader As StreamReader = New StreamReader(selectedPath, Me._currentEncoding)
                    Try
                        Me.tbGeneric.Text = streamReader.ReadToEnd()
                    Finally
                        streamReader.Close()
                    End Try
                End If

                Me._EditingFilePath = selectedPath
                Me.Filename = Path.GetFileName(selectedPath)
                Me.tbGeneric.SelectionStart = 0
                Me.tbGeneric.SelectionLength = 0
                Me.SetDirty(False)
            Catch ex As System.Exception
                MessageBox.Show(Me, "Unable to open file:" & vbCrLf & ex.Message, "Open file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                Me._loadingDocument = False
                Me.UpdateStatus()
            End Try
        End Sub

        Private Function DetectTextEncoding(ByVal selectedPath As String) As Encoding
            Dim bom(3) As Byte
            Dim bytesRead As Integer = 0
            Dim fileStream As FileStream = Nothing

            Try
                fileStream = New FileStream(selectedPath, FileMode.Open, FileAccess.Read, FileShare.Read)
                bytesRead = fileStream.Read(bom, 0, bom.Length)
            Finally
                If fileStream IsNot Nothing Then
                    fileStream.Close()
                End If
            End Try

            If bytesRead >= 3 AndAlso bom(0) = &HEF AndAlso bom(1) = &HBB AndAlso bom(2) = &HBF Then
                Return Encoding.UTF8
            End If

            If bytesRead >= 2 AndAlso bom(0) = &HFF AndAlso bom(1) = &HFE Then
                Return Encoding.Unicode
            End If

            If bytesRead >= 2 AndAlso bom(0) = &HFE AndAlso bom(1) = &HFF Then
                Return Encoding.BigEndianUnicode
            End If

            Return Encoding.ASCII
        End Function

        Private Function NormalizeCrLf(ByVal value As String) As String
            Dim text As String = value.Replace(vbCrLf, vbLf)
            text = text.Replace(vbCr, vbLf)
            Return text.Replace(vbLf, vbCrLf)
        End Function

        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miQuit.Click
            Me.Close()
        End Sub

#End Region

#Region "Print Menu"

        Private Sub miPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miPrint.Click
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

        Private Sub miPageSetup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miPageSetup.Click
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

        Private Sub miFont_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miFont.Click
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

        Private Sub miWordWrap_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miWordWrap.Click
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

        Private Sub miEncountersList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miEncountersList.Click
            Me.SearchForSection("Encounter List")
        End Sub

        Private Sub miPlaceablesList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miPlaceablesList.Click
            Me.SearchForSection("Placeable List")
        End Sub

        Private Sub miCameras_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCameras.Click
            Me.SearchForSection("CameraList")
        End Sub

        Private Sub miDoorsList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miDoorsList.Click
            Me.SearchForSection("Door List")
        End Sub

        Private Sub miSoundsList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miSoundsList.Click
            Me.SearchForSection("SoundList")
        End Sub

        Private Sub miTriggersList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miTriggersList.Click
            Me.SearchForSection("TriggerList")
        End Sub

        Private Sub miWaypointsList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miWaypointsList.Click
            Me.SearchForSection("WaypointList")
        End Sub

        Private Sub miCreatureList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCreatureList.Click
            Me.SearchForSection("Creature List")
        End Sub

        Private Sub miMerchantList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miMerchantList.Click
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
            If Me._EditingFilePath Is Nothing OrElse StringType.StrCmp(Me._EditingFilePath, "", False) = 0 OrElse File.Exists(Me._EditingFilePath) = False Then
                If Me.SaveDocument(False) = False Then
                    Return String.Empty
                End If
            End If

            Dim compilerPath As String = Path.Combine(frmMain.gRootPath, "nwnnsscomp.exe")

            If File.Exists(compilerPath) = False Then
                MessageBox.Show(Me, "The NSS compiler could not be found:" & vbCrLf & compilerPath, "Compile NSS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return String.Empty
            End If

            Dim gameArg As String = "-g " & Convert.ToString(Me._KotorVersionIndex + 1)
            Dim outputPath As String = Path.ChangeExtension(Me._EditingFilePath, ".ncs")

            Try
                If File.Exists(outputPath) Then
                    File.Delete(outputPath)
                End If

                Dim process As Process = New Process()

                process.StartInfo.FileName = compilerPath
                process.StartInfo.UseShellExecute = False
                process.StartInfo.CreateNoWindow = True
                process.StartInfo.Arguments = String.Concat(New String() {"-c ", gameArg, " -o ", """", outputPath, """", " ", """", Me._EditingFilePath, """"})
                process.StartInfo.RedirectStandardOutput = True
                process.StartInfo.RedirectStandardError = True

                process.Start()

                Dim exited As Boolean = process.WaitForExit(8000)
                Dim compilerOutput As String = process.StandardOutput.ReadToEnd()
                Dim compilerError As String = process.StandardError.ReadToEnd()

                If compilerError IsNot Nothing AndAlso compilerError.Length > 0 Then
                    compilerOutput = compilerOutput & vbCrLf & compilerError
                End If

                If exited = False Then
                    Try
                        process.Kill()
                    Catch ex As System.Exception
                    End Try

                    compilerOutput = compilerOutput & vbCrLf & "Compiler timed out."
                Else
                    compilerOutput = compilerOutput & vbCrLf & "Exit code: " & process.ExitCode.ToString()
                End If

                Interaction.MsgBox(compilerOutput, MsgBoxStyle.Information, "Compiler output")

                Return compilerOutput
            Catch ex As System.Exception
                MessageBox.Show(Me, "Unable to compile NSS:" & vbCrLf & ex.Message, "Compile NSS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            Return String.Empty
        End Function

        Private Sub miCompile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCompile.Click
            If Me.SaveDocument(False) = False Then
                Return
            End If

            Me.CompileNSS()
        End Sub

        Private Sub miScriptIsK1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miScriptIsK1.Click
            Me.KotorVersionIndex = 0
            Me.miScriptIsK2.Checked = False
            Me.miCompile.Enabled = True
            Me.PrepareForScriptEditing()
            Me.UpdateStatus()
        End Sub

        Private Sub miScriptIsK2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miScriptIsK2.Click
            Me.KotorVersionIndex = 1
            Me.miScriptIsK1.Checked = False
            Me.miCompile.Enabled = True
            Me.PrepareForScriptEditing()
            Me.UpdateStatus()
        End Sub

        Public Sub PrepareForScriptEditing()
            Me.LoadNWScript(Me.KotorVersionIndex)
            Me.ShowFilterMatches()

            If Not Me.pnlFunctions.Visible Then
                Me.pnlFunctions.Visible = True
            End If

            Me.UpdateStatus()
        End Sub

        Private Sub LoadNWScript(ByVal index As Integer)
            If index < 0 OrElse index > 1 Then
                MessageBox.Show(Me, "Select a KotOR script target before loading script functions.", "Script functions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.funcs = New frmTextEditor.func(0) {}
                Return
            End If

            Dim scriptPath As String = Path.Combine(frmMain.CurrentSettings.KotorLocation(index), "override\nwscript.nss")

            If File.Exists(scriptPath) = False Then
                MessageBox.Show(Me, "Unable to load the script function list. nwscript.nss was not found at:" & vbCrLf & scriptPath, "Script functions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.funcs = New frmTextEditor.func(0) {}
                Return
            End If

            Dim fileStream As FileStream = Nothing
            Dim streamReader As StreamReader = Nothing

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

            Try
                fileStream = New FileStream(scriptPath, FileMode.Open, FileAccess.Read, FileShare.Read)
                streamReader = New StreamReader(fileStream, Encoding.ASCII)

                For i As Integer = 1 To startLine
                    If streamReader.ReadLine() Is Nothing Then
                        Exit For
                    End If
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
            Catch ex As System.Exception
                MessageBox.Show(Me, "Unable to load the script function list:" & vbCrLf & ex.Message, "Script functions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.funcs = New frmTextEditor.func(0) {}
            Finally
                If streamReader IsNot Nothing Then
                    streamReader.Close()
                End If

                If fileStream IsNot Nothing Then
                    fileStream.Close()
                End If
            End Try
        End Sub

        Private Sub ShowFilterMatches()
            Me.lbFunctions.Items.Clear()
            Me.lbFunctions.Sorted = True

            If Me.funcs Is Nothing OrElse Me.funcs.Length = 0 Then
                Me.lblMatches.Text = "Matches: 0"
                Return
            End If

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

        Private Sub tbFuncNameFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbFuncNameFilter.TextChanged
            Me.ShowFilterMatches()
        End Sub

        Private Sub lbFunctions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbFunctions.Click
            If Me.lbFunctions.SelectedItem Is Nothing Then
                Return
            End If

            If Me.funcs Is Nothing OrElse Me.funcs.Length = 0 Then
                Return
            End If

            For i As Integer = 0 To Me.funcs.GetUpperBound(0)
                If StringType.StrCmp(Me.funcs(i).name, CStr(Me.lbFunctions.SelectedItem), False) = 0 Then
                    Me.tbFuncDecl.Text = Me.funcs(i).comment & vbCrLf & Me.funcs(i).decl
                    Exit For
                End If
            Next
        End Sub

        Private Sub lbFunctions_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lbFunctions.DoubleClick
            If Me.lbFunctions.SelectedItem Is Nothing Then
                Return
            End If

            If Me.funcs Is Nothing OrElse Me.funcs.Length = 0 Then
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

        Private Sub lbFunctions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbFunctions.SelectedIndexChanged
            Me.lbFunctions_Click(Nothing, Nothing)
        End Sub

#End Region

#Region "Text Box Events"

        Private Sub tbGeneric_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles tbGeneric.GotFocus
            Me.miCut.Enabled = True
            Me.miCopy.Enabled = True
            Me.miPaste.Enabled = True
        End Sub

        Private Sub tbGeneric_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles tbGeneric.LostFocus
            'Me.miCut.Enabled = False
            'Me.miCopy.Enabled = False
            'Me.miPaste.Enabled = False
        End Sub

        Private Sub tbGeneric_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tbGeneric.MouseMove
            If e.X > 0 AndAlso e.X < 7 Then
                Cursor.Current = Cursors.Arrow
            Else
                Cursor.Current = Cursors.IBeam
            End If
        End Sub

        Private Sub tbGeneric_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tbGeneric.MouseDown
            If e.Button = MouseButtons.Right Then
                Dim targetControl As Control = CType(sender, Control)
                Dim showPoint As Point = targetControl.PointToClient(Control.MousePosition)

                Me.UpdateContextMenuState()
                Me.cmText.Show(targetControl, showPoint)
            End If
        End Sub

        Private Sub cmText_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles cmText.Popup
            Me.UpdateContextMenuState()
        End Sub

        Private Sub UpdateContextMenuState()
            Dim hasSelection As Boolean = Me.tbGeneric.SelectionLength > 0
            Dim hasClipboardText As Boolean = False

            Try
                hasClipboardText = Clipboard.ContainsText() OrElse Clipboard.ContainsData(DataFormats.Rtf)
            Catch ex As System.Exception
                hasClipboardText = False
            End Try

            Me.cmiUndo.Enabled = Me.tbGeneric.CanUndo
            Me.cmiCut.Enabled = hasSelection
            Me.cmiCopy.Enabled = hasSelection
            Me.cmiPaste.Enabled = hasClipboardText
            Me.cmiSelectAll.Enabled = Me.tbGeneric.TextLength > 0
            Me.cmiFindSelection.Enabled = hasSelection
            Me.cmiShowDefinition.Enabled = hasSelection
        End Sub

        Private Sub cmiUndo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiUndo.Click
            Me.miUndo_Click(sender, e)
        End Sub

        Private Sub cmiCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiCut.Click
            Me.miCut_Click(sender, e)
        End Sub

        Private Sub cmiCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiCopy.Click
            Me.miCopy_Click(sender, e)
        End Sub

        Private Sub cmiPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiPaste.Click
            Me.miPaste_Click(sender, e)
        End Sub

        Private Sub cmiSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiSelectAll.Click
            Me.miSelectAll_Click(sender, e)
        End Sub

        Private Sub cmiFindSelection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiFindSelection.Click
            If Me.tbGeneric.SelectionLength = 0 Then
                Return
            End If

            Me.g_findString = Me.tbGeneric.SelectedText
            Me.g_searchoptions = RichTextBoxFinds.None
            Me.g_matchcase = False
            Me.g_matchwholeword = False
            Me.g_searchup = False
            Me.FindNext(True, True)
        End Sub

        Private Sub cmiShowDefinition_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiShowDefinition.Click
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
