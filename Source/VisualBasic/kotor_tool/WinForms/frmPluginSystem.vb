Option Strict Off
Option Explicit On

Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.IO
Imports System.Text
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
    '   - Uses clsPluginManager, clsPluginDefinition, clsPluginCommand,
    '     clsPluginHandle, and clsPluginExecutionResult.
    '   - Designer layout belongs in frmPluginSystem.Designer.vb.
    ' -----------------------------------------------------------------

    Private _pluginManager As clsPluginManager
    Private _selectedPlugin As clsPluginDefinition
    Private _selectedPluginIsInstalled As Boolean

    Private Sub frmPluginSystem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me._pluginManager = New clsPluginManager()
        Me._selectedPlugin = Nothing
        Me._selectedPluginIsInstalled = False

        Me.LoadPluginList()
    End Sub

    Private Sub lbPlugins_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbPlugins.SelectedIndexChanged
        If Me.lbPlugins.SelectedItem Is Nothing Then
            Me.ShowPluginDetails(Nothing, True)
            Return
        End If

        If Me.lbAvailablePlugins IsNot Nothing AndAlso Me.lbAvailablePlugins.SelectedIndex >= 0 Then
            Me.lbAvailablePlugins.ClearSelected()
        End If

        Me.ShowPluginDetails(CType(Me.lbPlugins.SelectedItem, clsPluginDefinition), True)
    End Sub

    Private Sub lbAvailablePlugins_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbAvailablePlugins.SelectedIndexChanged
        If Me.lbAvailablePlugins.SelectedItem Is Nothing Then
            Return
        End If

        If Me.lbPlugins IsNot Nothing AndAlso Me.lbPlugins.SelectedIndex >= 0 Then
            Me.lbPlugins.ClearSelected()
        End If

        Me.ShowPluginDetails(CType(Me.lbAvailablePlugins.SelectedItem, clsPluginDefinition), False)
    End Sub

    Private Sub btnReload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReload.Click
        Me.LoadPluginList()
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

            Me._pluginManager.LoadPlugins()
            Me._pluginManager.LoadAvailablePlugins()

            For Each pluginObject As Object In Me._pluginManager.Plugins
                Me.lbPlugins.Items.Add(pluginObject)
            Next

            For Each availableObject As Object In Me._pluginManager.AvailablePlugins
                Me.lbAvailablePlugins.Items.Add(availableObject)
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

    Private Sub ShowPluginDetails(ByVal plugin As clsPluginDefinition, ByVal isInstalledPlugin As Boolean)
        Me._selectedPlugin = plugin
        Me._selectedPluginIsInstalled = isInstalledPlugin

        If plugin Is Nothing Then
            Me.tbDetails.Text = ""
            Me.tbCommand.Text = ""
            Me.lblStatus.Text = "Ready."
            Return
        End If

        If isInstalledPlugin Then
            Me.ShowInstalledPluginDetails(plugin)
        Else
            Me.ShowAvailablePluginDetails(plugin)
        End If
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

        If plugin.Description IsNot Nothing AndAlso plugin.Description.Trim().Length > 0 Then
            details.AppendLine("")
            details.AppendLine("DESCRIPTION")
            details.AppendLine(plugin.Description.Trim())
        End If

        Me.tbDetails.Text = details.ToString()
        Me.tbCommand.Text = "This plugin is listed in AvailablePlugins.xml." & vbCrLf & vbCrLf &
                            "Install or copy its files into the Plugins folder, then add it to InstalledPlugins.xml to activate it."
        Me.lblStatus.Text = plugin.Name & " is available but not selected as an installed plugin."
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
