Option Strict Off
Option Explicit On

Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports kotor_tool
Imports Microsoft.VisualBasic

Partial Class frmPluginSystem

    ' -----------------------------------------------------------------
    ' frmPluginSystem.vb
    '
    ' Backend logic for the KoTOR Tool Restoration Project Plugin System.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Installed plugins are shown only in the Installed Plugins list.
    '   - Available plugins are shown only when they are not already installed.
    '   - Download Plugin is enabled only for available, not-installed plugins.
    ' -----------------------------------------------------------------

    Private _pluginManager As clsPluginManager
    Private _selectedPlugin As clsPluginDefinition
    Private _selectedPluginIsInstalled As Boolean
    Private _activePluginProgressMeter As frmProgressMeter
    Private _pluginOperationThread As Thread
    Private _pluginOperationInProgress As Boolean
    Private _lastPluginProgressMessage As String
    Private _lastPluginProgressStatus As String
    Private _lastPluginProgressValue As Integer


    Private Class PluginInstallState
        Public Plugin As clsPluginDefinition
        Public DownloadRoot As String
        Public PluginsRoot As String
        Public InstalledPath As String
        Public ErrorObject As System.Exception
    End Class

    Private Delegate Sub PluginProgressDelegate(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)
    Private Delegate Sub PluginInstallCompletedDelegate(ByVal state As PluginInstallState)

    Private Sub frmPluginSystem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me._pluginManager = New clsPluginManager()
        Me._selectedPlugin = Nothing
        Me._selectedPluginIsInstalled = False
        Me._activePluginProgressMeter = Nothing
        Me._pluginOperationThread = Nothing
        Me._pluginOperationInProgress = False
        Me._lastPluginProgressMessage = ""
        Me._lastPluginProgressStatus = ""
        Me._lastPluginProgressValue = -1

        Me.LoadPluginList()
    End Sub

    Private Sub lbPlugins_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbPlugins.SelectedIndexChanged
        If Me.lbPlugins.SelectedItem Is Nothing Then
            If Me.lbAvailablePlugins.SelectedItem Is Nothing Then
                Me.ShowPluginDetails(Nothing, True)
            End If
            Return
        End If

        If Me.lbAvailablePlugins IsNot Nothing AndAlso Me.lbAvailablePlugins.SelectedIndex >= 0 Then
            Me.lbAvailablePlugins.ClearSelected()
        End If

        Me.ShowPluginDetails(CType(Me.lbPlugins.SelectedItem, clsPluginDefinition), True)
    End Sub

    Private Sub lbAvailablePlugins_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbAvailablePlugins.SelectedIndexChanged
        If Me.lbAvailablePlugins.SelectedItem Is Nothing Then
            If Me.lbPlugins.SelectedItem Is Nothing Then
                Me.ShowPluginDetails(Nothing, False)
            End If
            Return
        End If

        If Me.lbPlugins IsNot Nothing AndAlso Me.lbPlugins.SelectedIndex >= 0 Then
            Me.lbPlugins.ClearSelected()
        End If

        Me.ShowPluginDetails(CType(Me.lbAvailablePlugins.SelectedItem, clsPluginDefinition), False)
    End Sub

    Private Sub btnReload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReload.Click
        If Me._pluginOperationInProgress Then
            Return
        End If

        Me.LoadPluginList()
    End Sub

    Private Sub btnDownloadPlugin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDownloadPlugin.Click
        If Me._pluginOperationInProgress Then
            Interaction.MsgBox("A plugin operation is already running.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        If Me._selectedPlugin Is Nothing Then
            Interaction.MsgBox("No available plugin is selected.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        If Me._selectedPluginIsInstalled Then
            Interaction.MsgBox("The selected plugin is already installed.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        If Me.IsAvailablePluginInstalled(Me._selectedPlugin) Then
            Interaction.MsgBox("The selected plugin is already installed.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Me.LoadPluginList()
            Return
        End If

        Dim meter As frmProgressMeter = New frmProgressMeter()

        Try
            meter.stepAmount = 1
            meter.maxvalue = 100
            meter.progress = 0
            meter.message = "Downloading Plugin"
            meter.status = "Preparing selected plugin..."

            Me._lastPluginProgressMessage = ""
            Me._lastPluginProgressStatus = ""
            Me._lastPluginProgressValue = -1

            Try
                meter.Location = New utilWindowRelativePositioner(Me, meter).getConcentric()
            Catch exPosition As System.Exception
                meter.StartPosition = FormStartPosition.CenterParent
            End Try

            Me._activePluginProgressMeter = meter
            Me._pluginOperationInProgress = True

            Me.btnDownloadPlugin.Enabled = False
            Me.btnReload.Enabled = False
            Me.btnOpenPluginFolder.Enabled = False
            Me.btnEditPluginXml.Enabled = False
            Me.btnEditCommandIni.Enabled = False
            Me.lbPlugins.Enabled = False
            Me.lbAvailablePlugins.Enabled = False

            meter.Show(Me)

            Dim state As PluginInstallState = New PluginInstallState()
            state.Plugin = Me._selectedPlugin
            state.DownloadRoot = Path.Combine(Me._pluginManager.PluginsRoot, "_Downloads")
            state.PluginsRoot = Me._pluginManager.PluginsRoot
            state.InstalledPath = ""
            state.ErrorObject = Nothing

            Me._pluginOperationThread = New Thread(New ParameterizedThreadStart(AddressOf Me.DownloadPluginWorker))
            Me._pluginOperationThread.IsBackground = True
            Me._pluginOperationThread.SetApartmentState(ApartmentState.STA)
            Me._pluginOperationThread.Start(state)

        Catch ex As System.Exception
            Me._pluginOperationInProgress = False
            Me._pluginOperationThread = Nothing
            Me._activePluginProgressMeter = Nothing

            Try
                If meter IsNot Nothing Then
                    meter.Close()
                    meter.Dispose()
                End If
            Catch exClose As System.Exception
            End Try

            Me.btnReload.Enabled = True
            Me.lbPlugins.Enabled = True
            Me.lbAvailablePlugins.Enabled = True
            Me.UpdateActionButtons()

            Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Plugin System")
        End Try
    End Sub

    Private Sub DownloadPluginWorker(ByVal stateObject As Object)
        Dim state As PluginInstallState = CType(stateObject, PluginInstallState)
        Dim downloader As clsDownloadPlugin = Nothing
        Dim installer As clsInstallPlugin = Nothing

        Try
            downloader = New clsDownloadPlugin()
            AddHandler downloader.ProgressChanged, AddressOf Me.PluginProgressChanged

            Dim zipPath As String = downloader.DownloadPlugin(state.Plugin, state.DownloadRoot)

            RemoveHandler downloader.ProgressChanged, AddressOf Me.PluginProgressChanged
            downloader = Nothing

            installer = New clsInstallPlugin()
            AddHandler installer.ProgressChanged, AddressOf Me.PluginProgressChanged

            state.InstalledPath = installer.InstallPlugin(state.Plugin, zipPath, state.PluginsRoot)

            RemoveHandler installer.ProgressChanged, AddressOf Me.PluginProgressChanged
            installer = Nothing

        Catch ex As System.Exception
            state.ErrorObject = ex

            Try
                If downloader IsNot Nothing Then
                    RemoveHandler downloader.ProgressChanged, AddressOf Me.PluginProgressChanged
                End If
            Catch exRemoveDownloader As System.Exception
            End Try

            Try
                If installer IsNot Nothing Then
                    RemoveHandler installer.ProgressChanged, AddressOf Me.PluginProgressChanged
                End If
            Catch exRemoveInstaller As System.Exception
            End Try
        End Try

        Me.PluginInstallCompleted(state)
    End Sub

    Private Sub PluginProgressChanged(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)
        If e Is Nothing Then
            Return
        End If

        If Me.InvokeRequired Then
            Try
                Me.BeginInvoke(New PluginProgressDelegate(AddressOf Me.PluginProgressChanged), New Object() {sender, e})
            Catch exInvoke As System.Exception
            End Try
            Return
        End If

        Dim messageText As String = e.Message
        Dim statusText As String = e.Status
        Dim progressValue As Integer = e.Progress

        If messageText Is Nothing Then
            messageText = ""
        End If

        If statusText Is Nothing Then
            statusText = ""
        End If

        If progressValue < 0 Then
            progressValue = 0
        End If

        If progressValue > 100 Then
            progressValue = 100
        End If

        If messageText = Me._lastPluginProgressMessage AndAlso
       statusText = Me._lastPluginProgressStatus AndAlso
       progressValue = Me._lastPluginProgressValue Then
            Return
        End If

        Dim meter As frmProgressMeter = Me._activePluginProgressMeter

        If meter IsNot Nothing AndAlso Not meter.IsDisposed Then
            If messageText <> Me._lastPluginProgressMessage Then
                meter.message = messageText
            End If

            If statusText <> Me._lastPluginProgressStatus Then
                meter.status = statusText
            End If

            If progressValue <> Me._lastPluginProgressValue Then
                meter.progress = progressValue
            End If
        End If

        If Me.lblStatus IsNot Nothing AndAlso statusText <> Me._lastPluginProgressStatus Then
            Me.lblStatus.Text = statusText
        End If

        Me._lastPluginProgressMessage = messageText
        Me._lastPluginProgressStatus = statusText
        Me._lastPluginProgressValue = progressValue
    End Sub

    Private Sub PluginInstallCompleted(ByVal state As PluginInstallState)
        If Me.InvokeRequired Then
            Try
                Me.BeginInvoke(New PluginInstallCompletedDelegate(AddressOf Me.PluginInstallCompleted), New Object() {state})
            Catch exInvoke As System.Exception
            End Try
            Return
        End If

        Try
            If state IsNot Nothing AndAlso state.ErrorObject Is Nothing Then
                If Me._activePluginProgressMeter IsNot Nothing Then
                    Me._activePluginProgressMeter.progress = 100
                    Me._activePluginProgressMeter.status = "Plugin installed successfully."
                End If

                Me.LoadPluginList()

                Interaction.MsgBox(
                    "Plugin installed successfully:" & vbCrLf & vbCrLf & state.InstalledPath,
                    MsgBoxStyle.Information Or MsgBoxStyle.OkOnly,
                    "Plugin System"
                )
            Else
                If Me._activePluginProgressMeter IsNot Nothing Then
                    Me._activePluginProgressMeter.status = "Plugin installation failed."
                End If

                If state IsNot Nothing AndAlso state.ErrorObject IsNot Nothing Then
                    Interaction.MsgBox(state.ErrorObject.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Plugin System")
                Else
                    Interaction.MsgBox("Plugin installation failed.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Plugin System")
                End If
            End If

        Finally
            Try
                If Me._activePluginProgressMeter IsNot Nothing Then
                    Me._activePluginProgressMeter.Close()
                    Me._activePluginProgressMeter.Dispose()
                End If
            Catch exClose As System.Exception
            End Try

            Me._activePluginProgressMeter = Nothing
            Me._pluginOperationThread = Nothing
            Me._pluginOperationInProgress = False

            Me.btnReload.Enabled = True
            Me.lbPlugins.Enabled = True
            Me.lbAvailablePlugins.Enabled = True

            Me._lastPluginProgressMessage = ""
            Me._lastPluginProgressStatus = ""
            Me._lastPluginProgressValue = -1
            Me.UpdateActionButtons()
        End Try
    End Sub

    Private Sub btnOpenPluginsFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenPluginsFolder.Click
        If Me._pluginManager Is Nothing Then
            Me._pluginManager = New clsPluginManager()
        End If

        Me.OpenFolder(Me._pluginManager.PluginsRoot)
    End Sub

    Private Sub btnOpenPluginFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenPluginFolder.Click
        If Me._selectedPlugin Is Nothing Then
            Interaction.MsgBox("No plugin is selected.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        If Not Me._selectedPluginIsInstalled Then
            Interaction.MsgBox("The selected plugin is listed as available, but it is not installed locally.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        Me.OpenFolder(Me._selectedPlugin.PluginDirectory)
    End Sub

    Private Sub btnEditPluginXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditPluginXml.Click
        If Me._selectedPlugin Is Nothing Then
            Interaction.MsgBox("No plugin is selected.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        If Not Me._selectedPluginIsInstalled Then
            Interaction.MsgBox("The selected plugin is available-only and has no local plugin.xml manifest to edit.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        Me.OpenFile(Me._selectedPlugin.ManifestPath)
    End Sub

    Private Sub btnEditCommandIni_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditCommandIni.Click
        If Me._selectedPlugin Is Nothing Then
            Interaction.MsgBox("No plugin is selected.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        If Not Me._selectedPluginIsInstalled Then
            Interaction.MsgBox("The selected plugin is available-only and has no local command.ini file to edit.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Plugin System")
            Return
        End If

        Me.OpenFile(Me._selectedPlugin.CommandIniPath)
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub LoadPluginList()
        Try
            If Me._pluginManager Is Nothing Then
                Me._pluginManager = New clsPluginManager()
            End If

            Me.lbPlugins.BeginUpdate()
            Me.lbAvailablePlugins.BeginUpdate()

            Me.lbPlugins.Items.Clear()
            Me.lbAvailablePlugins.Items.Clear()
            Me.tbDetails.Text = ""
            Me.tbCommand.Text = ""
            Me._selectedPlugin = Nothing
            Me._selectedPluginIsInstalled = False
            Me.UpdateActionButtons()

            Me._pluginManager.LoadPlugins()
            Me._pluginManager.LoadAvailablePlugins()

            For Each pluginObject As Object In Me._pluginManager.Plugins
                Me.lbPlugins.Items.Add(pluginObject)
            Next

            For Each availableObject As Object In Me._pluginManager.AvailablePlugins
                Dim availablePlugin As clsPluginDefinition = CType(availableObject, clsPluginDefinition)

                If Not Me.IsAvailablePluginInstalled(availablePlugin) Then
                    Me.lbAvailablePlugins.Items.Add(availablePlugin)
                End If
            Next

            Me.lbPlugins.EndUpdate()
            Me.lbAvailablePlugins.EndUpdate()

            Me.lblStatus.Text = "Loaded " & Me.lbPlugins.Items.Count.ToString() & " installed plugin(s), " & Me.lbAvailablePlugins.Items.Count.ToString() & " available plugin(s)."

            If Me.lbPlugins.Items.Count > 0 Then
                Me.lbPlugins.SelectedIndex = 0
            ElseIf Me.lbAvailablePlugins.Items.Count > 0 Then
                Me.lbAvailablePlugins.SelectedIndex = 0
            Else
                Me.tbDetails.Text = "No installed or available plugins were loaded." & vbCrLf & vbCrLf &
                                  "Installed Registry:" & vbCrLf &
                                  Me._pluginManager.InstalledPluginsPath & vbCrLf & vbCrLf &
                                  "Available Catalogue:" & vbCrLf &
                                  Me._pluginManager.AvailablePluginsPath

                Me.tbCommand.Text = "Plugin folders are expected under:" & vbCrLf &
                                    Me._pluginManager.PluginsRoot
                Me.UpdateActionButtons()
            End If

        Catch ex As System.Exception
            Try
                Me.lbPlugins.EndUpdate()
            Catch exEndUpdate As System.Exception
            End Try

            Try
                Me.lbAvailablePlugins.EndUpdate()
            Catch exAvailableEndUpdate As System.Exception
            End Try

            Me.lblStatus.Text = "Plugin load failed."
            Me.tbDetails.Text = ex.Message
            Me.tbCommand.Text = ""
            Me.UpdateActionButtons()

            Interaction.MsgBox(
                "Unable to load plugin libraries." & vbCrLf & vbCrLf &
                "Plugin root:" & vbCrLf &
                Me._pluginManager.PluginsRoot & vbCrLf & vbCrLf &
                "Installed Registry:" & vbCrLf &
                Me._pluginManager.InstalledPluginsPath & vbCrLf & vbCrLf &
                "Available Catalogue:" & vbCrLf &
                Me._pluginManager.AvailablePluginsPath & vbCrLf & vbCrLf &
                "Error:" & vbCrLf &
                ex.Message,
                MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly,
                "Plugin System"
            )
        End Try
    End Sub

    Private Function IsAvailablePluginInstalled(ByVal availablePlugin As clsPluginDefinition) As Boolean
        If availablePlugin Is Nothing OrElse Me._pluginManager Is Nothing Then
            Return False
        End If

        Dim availableId As String = Me.NormalizePluginKey(availablePlugin.Id)
        Dim availableName As String = Me.NormalizePluginKey(availablePlugin.Name)
        Dim availableDirectory As String = Me.NormalizePluginKey(availablePlugin.InstalledDirectory)

        For Each installedObject As Object In Me._pluginManager.Plugins
            Dim installedPlugin As clsPluginDefinition = CType(installedObject, clsPluginDefinition)

            If availableId.Length > 0 Then
                If availableId = Me.NormalizePluginKey(installedPlugin.Id) OrElse
                   availableId = Me.NormalizePluginKey(installedPlugin.InstalledId) Then
                    Return True
                End If
            End If

            If availableName.Length > 0 Then
                If availableName = Me.NormalizePluginKey(installedPlugin.Name) OrElse
                   availableName = Me.NormalizePluginKey(installedPlugin.InstalledName) Then
                    Return True
                End If
            End If

            If availableDirectory.Length > 0 Then
                If availableDirectory = Me.NormalizePluginKey(installedPlugin.InstalledDirectory) OrElse
                   availableDirectory = Me.NormalizePluginKey(Path.GetFileName(installedPlugin.PluginDirectory)) Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function

    Private Function NormalizePluginKey(ByVal value As String) As String
        If value Is Nothing Then
            Return ""
        End If

        Return value.Trim().ToLower()
    End Function

    Private Sub ShowPluginDetails(ByVal plugin As clsPluginDefinition, ByVal isInstalledPlugin As Boolean)
        Me._selectedPlugin = plugin
        Me._selectedPluginIsInstalled = isInstalledPlugin

        If plugin Is Nothing Then
            Me.tbDetails.Text = ""
            Me.tbCommand.Text = ""
            Me.lblStatus.Text = "Ready."
            Me.UpdateActionButtons()
            Return
        End If

        If isInstalledPlugin Then
            Me.ShowInstalledPluginDetails(plugin)
        Else
            Me.ShowAvailablePluginDetails(plugin)
        End If

        Me.UpdateActionButtons()
    End Sub

    Private Sub ShowPluginDetails(ByVal plugin As clsPluginDefinition)
        Me.ShowPluginDetails(plugin, True)
    End Sub

    Private Sub ShowInstalledPluginDetails(ByVal plugin As clsPluginDefinition)
        Dim details As StringBuilder = New StringBuilder()

        details.AppendLine("INSTALLED PLUGIN")
        details.AppendLine("Id: " & plugin.Id)
        details.AppendLine("Name: " & plugin.Name)
        details.AppendLine("Author: " & plugin.Author)
        details.AppendLine("Version: " & plugin.Version)
        details.AppendLine("Type: " & plugin.PluginType)
        details.AppendLine("Enabled: " & plugin.Enabled.ToString())
        details.AppendLine("")

        details.AppendLine("REGISTRY")
        details.AppendLine("Installed Id: " & plugin.InstalledId)
        details.AppendLine("Installed Name: " & plugin.InstalledName)
        details.AppendLine("Installed Version: " & plugin.InstalledVersion)
        details.AppendLine("Directory: " & plugin.InstalledDirectory)
        details.AppendLine("")

        details.AppendLine("PATHS")
        details.AppendLine("Plugin Directory: " & plugin.PluginDirectory)
        details.AppendLine("Manifest: " & plugin.ManifestPath)
        details.AppendLine("Command INI: " & plugin.CommandIniPath)
        details.AppendLine("")

        details.AppendLine("COMPATIBILITY")
        details.AppendLine("Application: " & plugin.CompatibleApplication)
        details.AppendLine("Minimum App Version: " & plugin.MinimumAppVersion)
        details.AppendLine("Framework: " & plugin.Framework)
        details.AppendLine("Platform: " & plugin.Platform)
        details.AppendLine("")

        details.AppendLine("PROJECT")
        details.AppendLine("GitHub Repo: " & plugin.GitHubRepo)
        details.AppendLine("GitHub Branch: " & plugin.GitHubBranch)
        details.AppendLine("Website: " & plugin.Website)
        details.AppendLine("Download Url: " & plugin.DownloadUrl)
        details.AppendLine("")

        details.AppendLine("HANDLES")
        If plugin.ResourceHandles IsNot Nothing AndAlso plugin.ResourceHandles.Count > 0 Then
            For Each handleObject As Object In plugin.ResourceHandles
                details.AppendLine("  " & handleObject.ToString())
            Next
        Else
            details.AppendLine("  None")
        End If
        details.AppendLine("")

        details.AppendLine("REQUIRED FILES")
        If plugin.RequiredFiles IsNot Nothing AndAlso plugin.RequiredFiles.Count > 0 Then
            For Each fileObject As Object In plugin.RequiredFiles
                details.AppendLine("  " & CStr(fileObject))
            Next
        Else
            details.AppendLine("  None")
        End If
        details.AppendLine("")

        details.AppendLine("OPTIONAL FILES")
        If plugin.OptionalFiles IsNot Nothing AndAlso plugin.OptionalFiles.Count > 0 Then
            For Each fileObject As Object In plugin.OptionalFiles
                details.AppendLine("  " & CStr(fileObject))
            Next
        Else
            details.AppendLine("  None")
        End If

        If plugin.Description IsNot Nothing AndAlso plugin.Description.Trim().Length > 0 Then
            details.AppendLine("")
            details.AppendLine("DESCRIPTION")
            details.AppendLine(plugin.Description.Trim())
        End If

        Me.tbDetails.Text = details.ToString()
        Me.ShowCommandDetails(plugin)
        Me.UpdatePluginStatus(plugin)
    End Sub

    Private Sub ShowAvailablePluginDetails(ByVal plugin As clsPluginDefinition)
        Dim details As StringBuilder = New StringBuilder()

        details.AppendLine("AVAILABLE PLUGIN")
        details.AppendLine("Id: " & plugin.Id)
        details.AppendLine("Name: " & plugin.Name)
        details.AppendLine("Version: " & plugin.Version)
        details.AppendLine("Type: " & plugin.PluginType)
        details.AppendLine("Enabled: " & plugin.Enabled.ToString())
        details.AppendLine("")

        details.AppendLine("CATALOGUE")
        details.AppendLine("Suggested Directory: " & plugin.InstalledDirectory)
        details.AppendLine("")

        details.AppendLine("PROJECT")
        details.AppendLine("GitHub Repo: " & plugin.GitHubRepo)
        details.AppendLine("GitHub Branch: " & plugin.GitHubBranch)
        details.AppendLine("Website: " & plugin.Website)
        details.AppendLine("Download Url: " & plugin.DownloadUrl)

        If plugin.Description IsNot Nothing AndAlso plugin.Description.Trim().Length > 0 Then
            details.AppendLine("")
            details.AppendLine("DESCRIPTION")
            details.AppendLine(plugin.Description.Trim())
        End If

        Me.tbDetails.Text = details.ToString()
        Me.tbCommand.Text = "This plugin is listed in AvailablePlugins.xml and is not installed locally." & vbCrLf & vbCrLf &
                            "Press Download Plugin to download and install the selected plugin."
        Me.lblStatus.Text = plugin.Name & " is available for installation."
    End Sub

    Private Sub ShowCommandDetails(ByVal plugin As clsPluginDefinition)
        If plugin Is Nothing Then
            Me.tbCommand.Text = ""
            Return
        End If

        If Me._pluginManager Is Nothing Then
            Me._pluginManager = New clsPluginManager()
        End If

        If Not File.Exists(plugin.CommandIniPath) Then
            Me.tbCommand.Text = "command.ini was not found:" & vbCrLf & vbCrLf & plugin.CommandIniPath
            Return
        End If

        Try
            Dim command As clsPluginCommand = Me._pluginManager.LoadPluginCommand(plugin)
            Dim commandText As StringBuilder = New StringBuilder()

            commandText.AppendLine("COMMAND")
            commandText.AppendLine("Executable: " & command.Executable)
            commandText.AppendLine("Arguments: " & command.Arguments)
            commandText.AppendLine("Working Directory: " & command.WorkingDirectory)
            commandText.AppendLine("")

            commandText.AppendLine("OUTPUT")
            commandText.AppendLine("Output Mode: " & command.OutputMode)
            commandText.AppendLine("Output Extension: " & command.OutputExtension)
            commandText.AppendLine("Overwrite Output: " & command.OverwriteOutput.ToString())
            commandText.AppendLine("")

            commandText.AppendLine("PROCESS")
            commandText.AppendLine("Capture StdOut: " & command.CaptureStdOut.ToString())
            commandText.AppendLine("Capture StdErr: " & command.CaptureStdErr.ToString())
            commandText.AppendLine("Timeout MS: " & command.TimeoutMS.ToString())
            commandText.AppendLine("Show Window: " & command.ShowWindow.ToString())
            commandText.AppendLine("Success Exit Code: " & command.SuccessExitCode.ToString())
            commandText.AppendLine("Treat StdErr As Failure: " & command.TreatStdErrAsFailure.ToString())
            commandText.AppendLine("")

            commandText.AppendLine("PLACEHOLDERS")
            commandText.AppendLine("{input}")
            commandText.AppendLine("{output}")
            commandText.AppendLine("{game}")
            commandText.AppendLine("{game_name}")
            commandText.AppendLine("{plugin_id}")
            commandText.AppendLine("{plugin_name}")
            commandText.AppendLine("{plugin_dir}")
            commandText.AppendLine("{working_dir}")
            commandText.AppendLine("{startup_dir}")
            commandText.AppendLine("{filename}")
            commandText.AppendLine("{resref}")
            commandText.AppendLine("{extension}")

            Me.tbCommand.Text = commandText.ToString()

        Catch ex As System.Exception
            Me.tbCommand.Text = "Unable to read command.ini:" & vbCrLf & vbCrLf & ex.Message
        End Try
    End Sub

    Private Sub UpdatePluginStatus(ByVal plugin As clsPluginDefinition)
        If plugin Is Nothing Then
            Me.lblStatus.Text = "Ready."
            Return
        End If

        If Me._pluginManager Is Nothing Then
            Me._pluginManager = New clsPluginManager()
        End If

        Dim missingFiles As ArrayList = Me._pluginManager.GetMissingRequiredFiles(plugin)

        If missingFiles.Count > 0 Then
            Me.lblStatus.Text = plugin.Name & " is missing required file(s): " & Me.JoinArrayList(missingFiles, ", ")
        Else
            Me.lblStatus.Text = plugin.Name & " loaded successfully."
        End If
    End Sub

    Private Sub UpdateActionButtons()
        Dim hasSelection As Boolean = (Me._selectedPlugin IsNot Nothing)
        Dim canDownload As Boolean = False
        Dim canUseInstalledActions As Boolean = False

        If Me._pluginOperationInProgress Then
            Me.btnDownloadPlugin.Enabled = False
            Me.btnOpenPluginFolder.Enabled = False
            Me.btnEditPluginXml.Enabled = False
            Me.btnEditCommandIni.Enabled = False
            Return
        End If

        If hasSelection Then
            canUseInstalledActions = Me._selectedPluginIsInstalled
            canDownload = Not Me._selectedPluginIsInstalled

            If canDownload Then
                If Me.IsAvailablePluginInstalled(Me._selectedPlugin) Then
                    canDownload = False
                End If

                If Me._selectedPlugin.DownloadUrl Is Nothing OrElse Me._selectedPlugin.DownloadUrl.Trim().Length = 0 Then
                    canDownload = False
                End If
            End If
        End If

        Me.btnDownloadPlugin.Enabled = canDownload
        Me.btnOpenPluginFolder.Enabled = canUseInstalledActions
        Me.btnEditPluginXml.Enabled = canUseInstalledActions
        Me.btnEditCommandIni.Enabled = canUseInstalledActions
    End Sub

    Private Sub OpenFolder(ByVal folderPath As String)
        Try
            If folderPath Is Nothing OrElse folderPath.Trim().Length = 0 Then
                Interaction.MsgBox("Folder path is blank.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Plugin System")
                Return
            End If

            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Process.Start(folderPath)

        Catch ex As System.Exception
            Interaction.MsgBox(
                "Unable to open folder:" & vbCrLf & vbCrLf &
                folderPath & vbCrLf & vbCrLf &
                ex.Message,
                MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly,
                "Plugin System"
            )
        End Try
    End Sub

    Private Sub OpenFile(ByVal filePath As String)
        Try
            If filePath Is Nothing OrElse filePath.Trim().Length = 0 Then
                Interaction.MsgBox("File path is blank.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Plugin System")
                Return
            End If

            If Not File.Exists(filePath) Then
                Interaction.MsgBox(
                    "File was not found:" & vbCrLf & vbCrLf &
                    filePath,
                    MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly,
                    "Plugin System"
                )
                Return
            End If

            Process.Start(filePath)

        Catch ex As System.Exception
            Interaction.MsgBox(
                "Unable to open file:" & vbCrLf & vbCrLf &
                filePath & vbCrLf & vbCrLf &
                ex.Message,
                MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly,
                "Plugin System"
            )
        End Try
    End Sub

    Private Function JoinArrayList(ByVal list As ArrayList, ByVal separator As String) As String
        If list Is Nothing OrElse list.Count = 0 Then
            Return ""
        End If

        Dim builder As StringBuilder = New StringBuilder()

        For i As Integer = 0 To list.Count - 1
            If i > 0 Then
                builder.Append(separator)
            End If

            builder.Append(CStr(list(i)))
        Next

        Return builder.ToString()
    End Function

End Class
