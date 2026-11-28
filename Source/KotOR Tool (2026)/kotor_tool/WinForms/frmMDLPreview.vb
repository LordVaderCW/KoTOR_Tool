Option Strict On
Option Explicit On

Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Text.RegularExpressions

Namespace kotor_tool
    Public Partial Class frmMDLPreview
        Public Event SendToMax(ByVal includeAnimations As Boolean)
        Private previewCloseReady As Boolean
        Private previewClosePending As Boolean

        Public Async Function PrepareForCloseAsync() As System.Threading.Tasks.Task
            ' Let the original Closing event return before issuing the final Close.
            Await System.Threading.Tasks.Task.Yield()
            StopPreviewSound()
            If previewController IsNot Nothing Then Await previewController.PrepareCloseAsync()
            previewCloseReady = True
        End Function

        Private Async Sub PrepareViewerClose(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If previewCloseReady OrElse e.CloseReason <> System.Windows.Forms.CloseReason.UserClosing Then Return
            e.Cancel = True
            If previewClosePending Then Return
            previewClosePending = True
            Try
                Await PrepareForCloseAsync()
            Finally
                previewCloseReady = True
                If Not IsDisposed Then Close()
            End Try
        End Sub

        Private Sub SendMaxClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sendMaxButton.Click
            RaiseEvent SendToMax(includeAnimationsCheck.Checked)
        End Sub

        Private soundPlayer As clsAnimationSoundPlayer
        Private soundGame As Integer
        Private soundReader As Func(Of String, Byte())
        Private soundPaused As Boolean
        Private audioReader As Func(Of String, Integer, Byte())
        Private audioModel As String
        Private audioTables As New Dictionary(Of String, cls2DA)(StringComparer.OrdinalIgnoreCase)
        Private changingAudio As Boolean
        Private Class SoundSetItem
            Public Name As String
            Public ResRef As String
            Public Sounds As List(Of SoundItem)
            Public Suggested As Boolean
            Public Overrides Function ToString() As String
                Return Name & If(String.IsNullOrEmpty(ResRef), "", " [" & ResRef & "]") & If(Suggested, " (model match)", "")
            End Function
        End Class
        Private Class SoundItem
            Public Label As String
            Public ResRef As String
            Public Overrides Function ToString() As String
                Return Label & If(String.IsNullOrEmpty(ResRef), " — unavailable", " — " & ResRef)
            End Function
        End Class
        Private Shared ReadOnly SoundLabels As String() = {
            "Battlecry 1", "Battlecry 2", "Battlecry 3", "Battlecry 4", "Battlecry 5", "Battlecry 6",
            "Select 1", "Select 2", "Select 3", "Attack grunt 1", "Attack grunt 2", "Attack grunt 3",
            "Pain grunt 1", "Pain grunt 2", "Low health", "Dead", "Critical hit", "Target immune",
            "Lay mine", "Disarm mine", "Begin stealth", "Begin search", "Begin unlock", "Unlock failed",
            "Unlock success", "Separated from party", "Rejoined party", "Poisoned"}

        Private Shared Function AudioName(ByVal value As String) As Boolean
            Return value IsNot Nothing AndAlso Regex.IsMatch(value, "^[a-zA-Z0-9_-]{1,64}$")
        End Function

        Private Function AudioTable(ByVal name As String) As cls2DA
            If Not audioTables.ContainsKey(name) Then
                Dim bytes As Byte() = audioReader(name, 2017)
                audioTables(name) = If(bytes Is Nothing, Nothing, New cls2DA(bytes))
            End If
            Return audioTables(name)
        End Function

        Private Shared Function Cell(ByVal table As cls2DA, ByVal row As Integer, ByVal column As String) As String
            If table Is Nothing OrElse row < 0 OrElse row >= table.RowCount Then Return ""
            Dim actual As String = Array.Find(table.ColNames, Function(c) c.Equals(column, StringComparison.OrdinalIgnoreCase))
            Return If(actual Is Nothing, "", table.GetIndiceData(row, actual))
        End Function

        Private Function ModelMatches(ByVal table As cls2DA, ByVal row As Integer, ByVal column As String) As Boolean
            Return String.Equals(Cell(table, row, column), audioModel, StringComparison.OrdinalIgnoreCase)
        End Function

        Private Shared Function AudioEventLabel(ByVal column As String) As String
            Select Case column.ToLowerInvariant()
                Case "opened" : Return "Open"
                Case "closed" : Return "Close"
                Case "destroyed" : Return "Destroy"
                Case "used" : Return "Use"
                Case "locked" : Return "Locked"
                Case "inventorysound" : Return "Inventory"
                Case "powerupsnd" : Return "Power up"
                Case "powerdownsnd" : Return "Power down"
                Case "poweredsnd" : Return "Powered loop"
                Case "resource", "soundresref" : Return "Sound"
            End Select
            Return Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Regex.Replace(column, "([a-z])([0-9])", "$1 $2"))
        End Function

        Private Sub AddAudioColumns(ByVal sounds As List(Of SoundItem), ByVal table As cls2DA, ByVal row As Integer, ByVal columns As IEnumerable(Of String), Optional ByVal prefix As String = "")
            For Each col As String In columns
                Dim name As String = Cell(table, row, col)
                sounds.Add(New SoundItem With {.Label = prefix & AudioEventLabel(col), .ResRef = If(AudioName(name), name, "")})
            Next
        End Sub

        Private Sub AddLinkedSounds(ByVal sounds As List(Of SoundItem), ByVal tableName As String, ByVal rowLabel As String, ByVal columns As IEnumerable(Of String), ByVal prefix As String)
            Dim table As cls2DA = AudioTable(tableName)
            If table Is Nothing OrElse String.IsNullOrEmpty(rowLabel) OrElse rowLabel = "****" Then Return
            Dim row As Integer = Array.IndexOf(table.RowLabels, rowLabel)
            If row >= 0 Then AddAudioColumns(sounds, table, row, columns, prefix)
        End Sub

        Public Sub ConfigureAudio(ByVal game As Integer, ByVal modelName As String, ByVal reader As Func(Of String, Integer, Byte()))
            StopPreviewSound()
            changingAudio = True
            audioReader = reader
            audioModel = modelName
            audioTables.Clear()
            soundGame = game
            soundWithClip.Checked = False
            soundLoop.Checked = False
            soundCategory.SelectedIndex = 0
            changingAudio = False
            ' Only exact model references select a category automatically.
            Try
                For Each mapping As String() In New String()() {New String() {"genericdoors", "modelname", "1"}, New String() {"placeables", "modelname", "2"}, New String() {"baseitems", "defaultmodel", "3"}}
                    Dim table As cls2DA = AudioTable(mapping(0))
                    If table Is Nothing Then Continue For
                    For row As Integer = 0 To table.RowCount - 1
                        If ModelMatches(table, row, mapping(1)) Then
                            changingAudio = True
                            soundCategory.SelectedIndex = Integer.Parse(mapping(2), Globalization.CultureInfo.InvariantCulture)
                            changingAudio = False
                            Exit For
                        End If
                    Next
                    If soundCategory.SelectedIndex <> 0 Then Exit For
                Next
            Catch ex As System.Exception
                ' A missing category table must not prevent browsing other audio.
            End Try
            LoadAudioCategory()
        End Sub

        Private Sub AudioCategoryChanged() Handles soundCategory.SelectedIndexChanged
            If Not changingAudio AndAlso audioReader IsNot Nothing Then LoadAudioCategory()
        End Sub

        Private Sub LoadAudioCategory()
            StopPreviewSound()
            soundSetList.Items.Clear()
            soundList.Items.Clear()
            soundPlay.Enabled = False
            soundWithClip.Checked = False
            soundLoop.Checked = False
            soundSidebar.Enabled = True
            Try
                If soundCategory.SelectedIndex = 0 Then
                    ConfigureSoundsets(soundGame, audioModel, audioReader("soundset", 2017), Function(name) audioReader(name, 2060))
                    Return
                End If
                Dim category As Integer = soundCategory.SelectedIndex
                If category = 1 OrElse category = 2 Then
                    Dim table As cls2DA = AudioTable(If(category = 1, "genericdoors", "placeables"))
                    If table IsNot Nothing Then
                        For row As Integer = 0 To table.RowCount - 1
                            Dim sounds As New List(Of SoundItem)
                            AddLinkedSounds(sounds, "placeableobjsnds", Cell(table, row, "soundapptype"), {"opened", "closed", "destroyed", "used", "locked"}, "")
                            soundSetList.Items.Add(New SoundSetItem With {.Name = Cell(table, row, "label"), .ResRef = Cell(table, row, "modelname"), .Sounds = sounds, .Suggested = ModelMatches(table, row, "modelname")})
                        Next
                    End If
                    ' Expose the sound definitions too, including entries with no model mapping.
                    AddTableGroups("placeableobjsnds", {"opened", "closed", "destroyed", "used", "locked"})
                ElseIf category = 3 Then
                    Dim table As cls2DA = AudioTable("baseitems")
                    Dim weapons As cls2DA = AudioTable("weaponsounds")
                    Dim weaponColumns As New List(Of String)
                    If weapons IsNot Nothing Then
                        For Each col As String In weapons.ColNames
                            If Not col.Equals("label", StringComparison.OrdinalIgnoreCase) AndAlso Not col.Equals("pitchoffset", StringComparison.OrdinalIgnoreCase) Then weaponColumns.Add(col)
                        Next
                    End If
                    If table IsNot Nothing Then
                        For row As Integer = 0 To table.RowCount - 1
                            Dim sounds As New List(Of SoundItem)
                            AddLinkedSounds(sounds, "inventorysnds", Cell(table, row, "invsoundtype"), {"inventorysound"}, "")
                            AddLinkedSounds(sounds, "weaponsounds", Cell(table, row, "weaponmattype"), weaponColumns, "Impact / ")
                            AddAudioColumns(sounds, table, row, {"powerupsnd", "powerdownsnd", "poweredsnd"})
                            soundSetList.Items.Add(New SoundSetItem With {.Name = Cell(table, row, "label"), .Sounds = sounds, .Suggested = ModelMatches(table, row, "defaultmodel")})
                        Next
                    End If
                    AddTableGroups("inventorysnds", {"inventorysound"})
                    AddTableGroups("weaponsounds", weaponColumns)
                ElseIf category = 4 Then
                    AddTableGroups("ambientsound", {"resource"})
                    AddTableGroups("ambientmusic", {"resource", "stinger1", "stinger2", "stinger3"})
                ElseIf category = 5 Then
                    AddTableGroups("guisounds", {"soundresref"})
                End If
                Dim match As Integer = -1
                For index As Integer = 0 To soundSetList.Items.Count - 1
                    If CType(soundSetList.Items(index), SoundSetItem).Suggested Then
                        If match >= 0 Then
                            match = -1
                            Exit For
                        End If
                        match = index
                    End If
                Next
                If match >= 0 Then soundSetList.SelectedIndex = match
                If soundSetList.Items.Count = 0 Then
                    soundInfo.Text = "No definitions available for this category in the selected game."
                ElseIf match < 0 Then
                    soundInfo.Text = "Choose an audio definition and event. No unique model mapping was selected."
                End If
            Catch ex As System.Exception
                soundInfo.Text = "Audio definitions unavailable: " & ex.Message
            End Try
        End Sub

        Private Sub AddTableGroups(ByVal tableName As String, ByVal columns As IEnumerable(Of String))
            Dim table As cls2DA = AudioTable(tableName)
            If table Is Nothing Then Return
            For row As Integer = 0 To table.RowCount - 1
                Dim sounds As New List(Of SoundItem)
                AddAudioColumns(sounds, table, row, columns)
                Dim label As String = Cell(table, row, "label")
                Dim strref As Integer
                If Integer.TryParse(Cell(table, row, "description"), strref) AndAlso strref >= 0 Then
                    Dim tlk As clsDialogTlk = Nothing
                    Try
                        tlk = New clsDialogTlk(Path.Combine(frmMain.CurrentSettings.KotorLocation(soundGame), "dialog.tlk"), False)
                        label = tlk.GetString(strref)
                    Catch ex As System.Exception
                        ' Resource names remain usable if localized descriptions are unavailable.
                    Finally
                        If tlk IsNot Nothing Then tlk.Close()
                    End Try
                End If
                If String.IsNullOrEmpty(label) OrElse label = "****" Then label = Cell(table, row, "resource")
                soundSetList.Items.Add(New SoundSetItem With {.Name = label.Replace("_", " "), .Sounds = sounds})
            Next
        End Sub

        Public Sub ConfigureSoundsets(ByVal game As Integer, ByVal modelName As String, ByVal tableBytes As Byte(), ByVal reader As Func(Of String, Byte()))
            StopPreviewSound()
            soundReader = Nothing
            soundSetList.Items.Clear()
            soundList.Items.Clear()
            soundWithClip.Checked = False
            soundGame = game
            soundSidebar.Enabled = True
            soundPlay.Enabled = False
            Try
                If tableBytes Is Nothing Then Throw New InvalidDataException("soundset.2da is unavailable.")
                Dim table As New cls2DA(tableBytes)
                Dim labelColumn As String = Array.Find(table.ColNames, Function(c) c.Equals("label", StringComparison.OrdinalIgnoreCase))
                Dim resrefColumn As String = Array.Find(table.ColNames, Function(c) c.Equals("resref", StringComparison.OrdinalIgnoreCase))
                If resrefColumn Is Nothing Then Throw New InvalidDataException("soundset.2da has no resref column.")
                Dim suggested As Integer = -1
                For row As Integer = 0 To table.RowCount - 1
                    Dim name As String = table.GetIndiceData(row, resrefColumn)
                    If name Is Nothing OrElse Not Regex.IsMatch(name, "^[a-zA-Z0-9_-]{1,64}$") Then Continue For
                    Dim label As String = If(labelColumn Is Nothing, name, table.GetIndiceData(row, labelColumn))
                    Dim index As Integer = soundSetList.Items.Add(New SoundSetItem With {.Name = label, .ResRef = name})
                    If name.Equals(modelName, StringComparison.OrdinalIgnoreCase) Then suggested = index
                Next
                soundReader = reader
                If suggested >= 0 Then
                    soundSetList.SelectedIndex = suggested
                    soundInfo.Text = "Suggested by matching resource name. Choose the creature's soundset and a sound event; enable Play with animation to audition together."
                Else
                    soundInfo.Text = "Choose the creature's soundset and a sound event. An MDL alone does not specify SoundSetFile. Play with animation repeats the selected sound at each clip start."
                End If
            Catch ex As System.Exception
                soundInfo.Text = "Soundsets unavailable: " & ex.Message
            End Try
        End Sub

        Private Sub SoundSetChanged(ByVal sender As Object, ByVal e As EventArgs) Handles soundSetList.SelectedIndexChanged
            StopPreviewSound()
            soundList.Items.Clear()
            soundPlay.Enabled = False
            Dim selected As SoundSetItem = TryCast(soundSetList.SelectedItem, SoundSetItem)
            If selected Is Nothing Then Return
            If selected.Sounds IsNot Nothing Then
                For Each item As SoundItem In selected.Sounds
                    soundList.Items.Add(item)
                Next
                soundInfo.Text = If(selected.Suggested, "Linked through the model's game-table entry. ", "") & If(selected.Sounds.Count = 0, "No sound mapping is defined. Choose a sound definition manually.", "Choose an event; audition independently, loop audio, or pair with animation.")
                Return
            End If
            If soundReader Is Nothing Then Return
            Try
                Dim bytes As Byte() = soundReader(selected.ResRef)
                If bytes Is Nothing Then Throw New FileNotFoundException("Soundset resource not found.")
                Using stream As New MemoryStream(bytes), ssf As New BinaryReader(stream)
                    If bytes.Length < 12 OrElse Encoding.ASCII.GetString(ssf.ReadBytes(8)) <> "SSF V1.1" Then Throw New InvalidDataException("Invalid SSF header.")
                    Dim offset As Long = ssf.ReadUInt32()
                    If offset < 12 OrElse offset + 28L * 4 > bytes.Length Then Throw New InvalidDataException("Truncated SSF sound table.")
                    stream.Position = offset
                    Dim tlk As New clsDialogTlk(Path.Combine(frmMain.CurrentSettings.KotorLocation(soundGame), "dialog.tlk"), False)
                    Try
                        For slot As Integer = 0 To 27
                            Dim strref As Integer = ssf.ReadInt32()
                            Dim resref As String = If(strref < 0, "", tlk.GetSoundResRef(strref))
                            If Not Regex.IsMatch(resref, "^[a-zA-Z0-9_-]{1,64}$") Then resref = ""
                            soundList.Items.Add(New SoundItem With {.Label = SoundLabels(slot), .ResRef = resref})
                        Next
                    Finally
                        tlk.Close()
                    End Try
                End Using
                soundInfo.Text = "Select a sound event. Play with animation auditions it at clip starts and loops; this is not the game's event timing."
            Catch ex As System.Exception
                soundList.Items.Clear()
                soundInfo.Text = "Soundset unavailable: " & ex.Message
            End Try
        End Sub

        Private Sub SoundSelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles soundList.SelectedIndexChanged
            StopPreviewSound()
            Dim item As SoundItem = TryCast(soundList.SelectedItem, SoundItem)
            soundPlay.Enabled = item IsNot Nothing AndAlso Not String.IsNullOrEmpty(item.ResRef)
        End Sub

        Private Sub PlayPreviewSound() Handles soundPlay.Click, soundList.DoubleClick
            StopPreviewSound()
            Dim item As SoundItem = TryCast(soundList.SelectedItem, SoundItem)
            If item Is Nothing OrElse String.IsNullOrEmpty(item.ResRef) Then Return
            Try
                If soundPlayer Is Nothing Then soundPlayer = New clsAnimationSoundPlayer()
                If soundPlayer.PlayResRef(item.ResRef, soundGame, soundLoop.Checked AndAlso Not soundWithClip.Checked) Then
                    soundInfo.Text = "Playing " & item.Label & ": " & item.ResRef
                Else
                    soundInfo.Text = "Audio missing or unsupported: " & item.ResRef
                End If
            Catch ex As System.Exception
                StopPreviewSound()
                soundInfo.Text = "Audio unavailable: " & ex.Message
            End Try
        End Sub

        Private Sub StopPreviewSound() Handles soundStop.Click
            soundPaused = False
            If soundPlayer IsNot Nothing Then soundPlayer.StopSound()
        End Sub

        Private Sub SoundLinkChanged() Handles soundWithClip.CheckedChanged, soundLoop.CheckedChanged
            StopPreviewSound()
            soundLoop.Enabled = Not soundWithClip.Checked
        End Sub

        Private Sub SoundPlaybackChanged(ByVal reason As String, ByVal playing As Boolean)
            If Not soundWithClip.Checked OrElse Not soundSidebar.Enabled Then Return
            If reason = "stop" OrElse reason = "finished" OrElse reason = "seek" Then
                StopPreviewSound()
            ElseIf reason = "select" OrElse reason = "loop" Then
                PlayPreviewSound()
            ElseIf reason = "toggle" Then
                If Not playing Then
                    If soundPlayer IsNot Nothing Then soundPlayer.PauseSound(True)
                    soundPaused = True
                ElseIf soundPaused Then
                    If soundPlayer IsNot Nothing Then soundPlayer.PauseSound(False)
                    soundPaused = False
                Else
                    PlayPreviewSound()
                End If
            End If
        End Sub

        Private previewController As ModelPreview.PreviewController

        Public Sub New()
            InitializeComponent()
            Me.ShowInTaskbar = True
        End Sub

        Public Sub New(ByVal directory As String, ByVal modelName As String)
            Me.New()
            previewController = New ModelPreview.PreviewController(Me, directory, modelName,
                viewportPanel, status, loading, animationList, clipSummary,
                playButton, stopButton, loopCheck, exportButton)
            AddHandler previewController.PlaybackChanged, AddressOf SoundPlaybackChanged
        End Sub

        Public Sub ShowLoading(ByVal modelName As String)
            StopPreviewSound()
            soundSidebar.Enabled = False
            sendMaxButton.Enabled = False
            If previewController IsNot Nothing Then previewController.ShowLoading(modelName)
        End Sub

        Public Sub ShowLoadError(ByVal message As String)
            StopPreviewSound()
            If previewController IsNot Nothing Then previewController.ShowLoadError(message)
        End Sub

        Public Sub CancelLoading()
            soundSidebar.Enabled = True
            sendMaxButton.Enabled = True
            If previewController IsNot Nothing Then previewController.CancelLoading()
        End Sub

        Public Sub ReplaceModel(ByVal directory As String, ByVal modelName As String)
            StopPreviewSound()
            soundSidebar.Enabled = True
            sendMaxButton.Enabled = True
            If previewController IsNot Nothing Then previewController.ReplaceModel(directory, modelName)
        End Sub
    End Class
End Namespace
