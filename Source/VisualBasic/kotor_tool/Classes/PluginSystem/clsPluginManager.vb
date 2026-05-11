Option Strict Off
Option Explicit On

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Xml
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsPluginManager.vb
    '
    ' External tool plugin manager for the KoTOR Tool Restoration Project.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Loads installed plugin registry from Plugins\InstalledPlugins.xml.
    '   - Loads available plugin catalogue from Plugins\AvailablePlugins.xml.
    '   - Loads each plugin manifest from Plugins\[Directory]\plugin.xml.
    '   - Loads editable command-line data from command.ini.
    '   - Resolves placeholders such as {input}, {output}, {game},
    '     {plugin_dir}, {working_dir}, {filename}, and {resref}.
    '   - Plugin process execution is run through a BackgroundWorker wrapper
    '     to keep the WinForms UI responsive.
    '   - stdout/stderr are captured asynchronously to avoid pipe deadlocks.
    ' -----------------------------------------------------------------

    Public Class clsPluginManager

        Private _pluginsRoot As String
        Private _installedPluginsPath As String
        Private _availablePluginsPath As String
        Private _plugins As ArrayList
        Private _availablePlugins As ArrayList

        Private Class clsPluginExecutionRequest
            Public Plugin As clsPluginDefinition
            Public InputPath As String
            Public OutputPath As String
            Public GameNumber As Integer
            Public Filename As String
            Public ResRef As String
            Public ExtensionValue As String
            Public ActionValue As String
            Public ExtraArguments As String
        End Class

        Public Sub New()
            Me.New(Path.Combine(Application.StartupPath, "Plugins"))
        End Sub

        Public Sub New(ByVal pluginsRoot As String)
            Me._pluginsRoot = pluginsRoot
            Me._installedPluginsPath = Path.Combine(Me._pluginsRoot, "InstalledPlugins.xml")
            Me._availablePluginsPath = Path.Combine(Me._pluginsRoot, "AvailablePlugins.xml")
            Me._plugins = New ArrayList()
            Me._availablePlugins = New ArrayList()
        End Sub

        Public ReadOnly Property PluginsRoot() As String
            Get
                Return Me._pluginsRoot
            End Get
        End Property

        Public ReadOnly Property InstalledPluginsPath() As String
            Get
                Return Me._installedPluginsPath
            End Get
        End Property

        Public ReadOnly Property AvailablePluginsPath() As String
            Get
                Return Me._availablePluginsPath
            End Get
        End Property

        Public ReadOnly Property Plugins() As ArrayList
            Get
                Return Me._plugins
            End Get
        End Property

        Public ReadOnly Property AvailablePlugins() As ArrayList
            Get
                Return Me._availablePlugins
            End Get
        End Property

        Public Sub EnsurePluginsRootExists()
            If Not Directory.Exists(Me._pluginsRoot) Then
                Directory.CreateDirectory(Me._pluginsRoot)
            End If

            If Not File.Exists(Me._installedPluginsPath) Then
                File.WriteAllText(Me._installedPluginsPath, Me.GetEmptyPluginLibraryXml("InstalledPlugin"), Encoding.UTF8)
            End If

            If Not File.Exists(Me._availablePluginsPath) Then
                File.WriteAllText(Me._availablePluginsPath, Me.GetEmptyPluginLibraryXml("AvailablePlugin"), Encoding.UTF8)
            End If
        End Sub

        Public Sub LoadPlugins()
            Me._plugins.Clear()
            Me.EnsurePluginsRootExists()

            Dim installedDocument As XmlDocument = New XmlDocument()
            installedDocument.Load(Me._installedPluginsPath)

            Dim installedNodes As XmlNodeList = installedDocument.SelectNodes("/PluginLibrary/InstalledPlugin")

            For Each installedNode As XmlNode In installedNodes
                Try
                    Dim installedPlugin As clsPluginDefinition = Me.LoadInstalledPluginRecord(installedNode)

                    If installedPlugin IsNot Nothing Then
                        If installedPlugin.Enabled Then
                            Dim manifestPath As String = installedPlugin.ManifestPath

                            If File.Exists(manifestPath) Then
                                Dim plugin As clsPluginDefinition = Me.LoadPluginDefinition(manifestPath, installedPlugin)

                                If plugin IsNot Nothing Then
                                    Me._plugins.Add(plugin)
                                End If
                            Else
                                Console.WriteLine("Plugin manifest missing: " & manifestPath)
                            End If
                        End If
                    End If

                Catch ex As System.Exception
                    Console.WriteLine("Installed plugin load failed: " & ex.Message)
                End Try
            Next
        End Sub

        Public Sub LoadAvailablePlugins()
            Me._availablePlugins.Clear()
            Me.EnsurePluginsRootExists()

            Dim availableDocument As XmlDocument = New XmlDocument()
            availableDocument.Load(Me._availablePluginsPath)

            Dim availableNodes As XmlNodeList = availableDocument.SelectNodes("/PluginLibrary/AvailablePlugin")

            For Each availableNode As XmlNode In availableNodes
                Try
                    Dim plugin As clsPluginDefinition = New clsPluginDefinition()
                    plugin.Id = Me.GetXmlNodeText(availableNode, "Id", "")
                    plugin.Name = Me.GetXmlNodeText(availableNode, "Name", plugin.Id)
                    plugin.Version = Me.GetXmlNodeText(availableNode, "Version", "")
                    plugin.PluginType = Me.GetXmlNodeText(availableNode, "Type", "ExternalTool")
                    plugin.Description = Me.GetXmlNodeText(availableNode, "Description", "")
                    plugin.GitHubRepo = Me.GetXmlNodeText(availableNode, "GitHubRepo", "")
                    plugin.GitHubBranch = Me.GetXmlNodeText(availableNode, "GitHubBranch", "")
                    plugin.Website = Me.GetXmlNodeText(availableNode, "Website", "")
                    plugin.DownloadUrl = Me.GetXmlNodeText(availableNode, "DownloadUrl", "")
                    plugin.InstalledDirectory = Me.GetXmlNodeText(availableNode, "Directory", "")
                    plugin.Enabled = Me.ParseBoolean(Me.GetXmlNodeText(availableNode, "Enabled", "True"), True)

                    Me._availablePlugins.Add(plugin)

                Catch ex As System.Exception
                    Console.WriteLine("Available plugin load failed: " & ex.Message)
                End Try
            Next
        End Sub

        Public Function LoadInstalledPluginRecord(ByVal installedNode As XmlNode) As clsPluginDefinition
            If installedNode Is Nothing Then
                Return Nothing
            End If

            Dim installedPlugin As clsPluginDefinition = New clsPluginDefinition()

            installedPlugin.InstalledId = Me.GetXmlNodeText(installedNode, "Id", "")
            installedPlugin.InstalledName = Me.GetXmlNodeText(installedNode, "Name", installedPlugin.InstalledId)
            installedPlugin.InstalledDirectory = Me.GetXmlNodeText(installedNode, "Directory", installedPlugin.InstalledName)
            installedPlugin.Enabled = Me.ParseBoolean(Me.GetXmlNodeText(installedNode, "Enabled", "True"), True)
            installedPlugin.ManifestFileName = Me.GetXmlNodeText(installedNode, "Manifest", "plugin.xml")
            installedPlugin.InstalledVersion = Me.GetXmlNodeText(installedNode, "InstalledVersion", "")

            If installedPlugin.InstalledDirectory Is Nothing OrElse installedPlugin.InstalledDirectory.Trim().Length = 0 Then
                installedPlugin.InstalledDirectory = installedPlugin.InstalledName
            End If

            installedPlugin.PluginDirectory = Path.Combine(Me._pluginsRoot, installedPlugin.InstalledDirectory)
            installedPlugin.ManifestPath = Path.Combine(installedPlugin.PluginDirectory, installedPlugin.ManifestFileName)

            Return installedPlugin
        End Function

        Public Function LoadPluginDefinition(ByVal pluginXmlPath As String) As clsPluginDefinition
            Return Me.LoadPluginDefinition(pluginXmlPath, Nothing)
        End Function

        Public Function LoadPluginDefinition(ByVal pluginXmlPath As String, ByVal installedRecord As clsPluginDefinition) As clsPluginDefinition
            Dim pluginDirectory As String = Path.GetDirectoryName(pluginXmlPath)
            Dim xmlDocument As XmlDocument = New XmlDocument()
            xmlDocument.Load(pluginXmlPath)

            Dim pluginNode As XmlNode = xmlDocument.SelectSingleNode("/Plugin")

            If pluginNode Is Nothing Then
                Throw New ApplicationException("Invalid plugin.xml. Missing root Plugin node.")
            End If

            Dim plugin As clsPluginDefinition = New clsPluginDefinition()

            If installedRecord IsNot Nothing Then
                plugin.InstalledId = installedRecord.InstalledId
                plugin.InstalledName = installedRecord.InstalledName
                plugin.InstalledDirectory = installedRecord.InstalledDirectory
                plugin.InstalledVersion = installedRecord.InstalledVersion
                plugin.ManifestFileName = installedRecord.ManifestFileName
                plugin.ManifestPath = installedRecord.ManifestPath
                plugin.Enabled = installedRecord.Enabled
            End If

            plugin.PluginDirectory = pluginDirectory
            plugin.ManifestPath = pluginXmlPath

            plugin.Id = Me.GetXmlNodeText(pluginNode, "Id", If(plugin.InstalledId.Trim().Length > 0, plugin.InstalledId, Path.GetFileName(pluginDirectory)))
            plugin.Name = Me.GetXmlNodeText(pluginNode, "Name", If(plugin.InstalledName.Trim().Length > 0, plugin.InstalledName, plugin.Id))
            plugin.Author = Me.GetXmlNodeText(pluginNode, "Author", "")
            plugin.Version = Me.GetXmlNodeText(pluginNode, "Version", "")
            plugin.PluginType = Me.GetXmlNodeText(pluginNode, "Type", "ExternalTool")
            plugin.Description = Me.GetXmlNodeText(pluginNode, "Description", "")

            If installedRecord Is Nothing Then
                plugin.Enabled = Me.ParseBoolean(Me.GetXmlNodeText(pluginNode, "Enabled", "True"), True)
            Else
                Dim manifestEnabled As Boolean = Me.ParseBoolean(Me.GetXmlNodeText(pluginNode, "Enabled", plugin.Enabled.ToString()), plugin.Enabled)
                plugin.Enabled = plugin.Enabled AndAlso manifestEnabled
            End If

            plugin.CompatibleApplication = Me.GetXmlNodeText(pluginNode, "Compatibility/Application", "")
            plugin.MinimumAppVersion = Me.GetXmlNodeText(pluginNode, "Compatibility/MinimumAppVersion", "")
            plugin.Framework = Me.GetXmlNodeText(pluginNode, "Compatibility/Framework", "")
            plugin.Platform = Me.GetXmlNodeText(pluginNode, "Compatibility/Platform", "")

            plugin.GitHubRepo = Me.GetXmlNodeText(pluginNode, "Project/GitHubRepo", Me.GetXmlNodeText(pluginNode, "GitHubRepo", ""))
            plugin.GitHubBranch = Me.GetXmlNodeText(pluginNode, "Project/GitHubBranch", Me.GetXmlNodeText(pluginNode, "GitHubBranch", ""))
            plugin.Website = Me.GetXmlNodeText(pluginNode, "Project/Website", Me.GetXmlNodeText(pluginNode, "Website", ""))
            plugin.DownloadUrl = Me.GetXmlNodeText(pluginNode, "Project/DownloadUrl", Me.GetXmlNodeText(pluginNode, "DownloadUrl", ""))

            plugin.AppFolderName = Me.GetXmlNodeText(pluginNode, "Layout/Folder[@name='app']", "app")
            plugin.ConfigFolderName = Me.GetXmlNodeText(pluginNode, "Layout/Folder[@name='config']", "config")
            plugin.RuntimeFolderName = Me.GetXmlNodeText(pluginNode, "Layout/Folder[@name='runtime']", "runtime")
            plugin.ToolsFolderName = Me.GetXmlNodeText(pluginNode, "Layout/Folder[@name='tools']", "tools")

            plugin.AppDirectory = Path.Combine(plugin.PluginDirectory, plugin.AppFolderName)
            plugin.ConfigDirectory = Path.Combine(plugin.PluginDirectory, plugin.ConfigFolderName)
            plugin.RuntimeDirectory = Path.Combine(plugin.PluginDirectory, plugin.RuntimeFolderName)
            plugin.ToolsDirectory = Path.Combine(plugin.PluginDirectory, plugin.ToolsFolderName)

            Dim commandIniName As String = Me.GetXmlNodeText(pluginNode, "CommandIni", "command.ini")
            plugin.CommandIniFileName = commandIniName
            plugin.CommandIniPath = Path.Combine(pluginDirectory, commandIniName)

            Me.LoadPluginHandles(plugin, pluginNode)
            Me.LoadPluginFiles(plugin, pluginNode)

            Return plugin
        End Function

        Private Sub LoadPluginHandles(ByVal plugin As clsPluginDefinition, ByVal pluginNode As XmlNode)
            plugin.ResourceHandles.Clear()

            Dim handleNodes As XmlNodeList = pluginNode.SelectNodes("Handles/Resource")

            For Each handleNode As XmlNode In handleNodes
                Dim extensionValue As String = ""
                Dim actionValue As String = ""
                Dim descriptionValue As String = ""

                If handleNode.Attributes IsNot Nothing Then
                    If handleNode.Attributes("extension") IsNot Nothing Then
                        extensionValue = handleNode.Attributes("extension").Value
                    End If

                    If handleNode.Attributes("action") IsNot Nothing Then
                        actionValue = handleNode.Attributes("action").Value
                    End If

                    If handleNode.Attributes("description") IsNot Nothing Then
                        descriptionValue = handleNode.Attributes("description").Value
                    End If
                End If

                If extensionValue.Length > 0 AndAlso actionValue.Length > 0 Then
                    plugin.ResourceHandles.Add(New clsPluginHandle(extensionValue, actionValue, descriptionValue))
                End If
            Next
        End Sub

        Private Sub LoadPluginFiles(ByVal plugin As clsPluginDefinition, ByVal pluginNode As XmlNode)
            plugin.RequiredFiles.Clear()
            plugin.OptionalFiles.Clear()

            Dim fileNodes As XmlNodeList = pluginNode.SelectNodes("Files/File")

            For Each fileNode As XmlNode In fileNodes
                Dim fileName As String = ""
                Dim requiredValue As Boolean = True

                If fileNode.InnerText IsNot Nothing Then
                    fileName = fileNode.InnerText.Trim()
                End If

                If fileNode.Attributes IsNot Nothing Then
                    If fileNode.Attributes("required") IsNot Nothing Then
                        requiredValue = Me.ParseBoolean(fileNode.Attributes("required").Value, True)
                    End If
                End If

                If fileName.Length > 0 Then
                    If requiredValue Then
                        plugin.RequiredFiles.Add(fileName)
                    Else
                        plugin.OptionalFiles.Add(fileName)
                    End If
                End If
            Next
        End Sub

        Public Function ValidatePluginFiles(ByVal plugin As clsPluginDefinition) As Boolean
            If plugin Is Nothing Then
                Return False
            End If

            For Each fileObj As Object In plugin.RequiredFiles
                Dim fileName As String = CStr(fileObj)
                Dim filePath As String = Path.Combine(plugin.PluginDirectory, fileName)

                If Not File.Exists(filePath) Then
                    Return False
                End If
            Next

            Return True
        End Function

        Public Function GetMissingRequiredFiles(ByVal plugin As clsPluginDefinition) As ArrayList
            Dim missingFiles As ArrayList = New ArrayList()

            If plugin Is Nothing Then
                Return missingFiles
            End If

            For Each fileObj As Object In plugin.RequiredFiles
                Dim fileName As String = CStr(fileObj)
                Dim filePath As String = Path.Combine(plugin.PluginDirectory, fileName)

                If Not File.Exists(filePath) Then
                    missingFiles.Add(fileName)
                End If
            Next

            Return missingFiles
        End Function

        Public Function FindPluginForResource(ByVal extensionValue As String, ByVal actionValue As String) As clsPluginDefinition
            Dim normalizedExtension As String = Me.NormalizeExtension(extensionValue)
            Dim normalizedAction As String = ""

            If actionValue IsNot Nothing Then
                normalizedAction = actionValue.Trim().ToLower()
            End If

            For Each obj As Object In Me._plugins
                Dim plugin As clsPluginDefinition = CType(obj, clsPluginDefinition)

                If plugin.Enabled Then
                    For Each handleObj As Object In plugin.ResourceHandles
                        Dim handle As clsPluginHandle = CType(handleObj, clsPluginHandle)

                        If handle.Matches(normalizedExtension, normalizedAction) Then
                            Return plugin
                        End If
                    Next
                End If
            Next

            Return Nothing
        End Function

        Public Function LoadPluginCommand(ByVal plugin As clsPluginDefinition) As clsPluginCommand
            If plugin Is Nothing Then
                Throw New ArgumentNullException("plugin")
            End If

            If Not File.Exists(plugin.CommandIniPath) Then
                Throw New FileNotFoundException("Plugin command.ini could not be found.", plugin.CommandIniPath)
            End If

            Dim command As clsPluginCommand = New clsPluginCommand()
            Dim values As Hashtable = Me.ReadIniSection(plugin.CommandIniPath, "Command")

            command.Executable = Me.GetIniValue(values, "Executable", command.Executable)
            command.Arguments = Me.GetIniValue(values, "Arguments", command.Arguments)
            command.WorkingDirectory = Me.GetIniValue(values, "WorkingDirectory", command.WorkingDirectory)
            command.OutputMode = Me.GetIniValue(values, "OutputMode", command.OutputMode)
            command.OutputExtension = Me.GetIniValue(values, "OutputExtension", command.OutputExtension)
            command.CaptureStdOut = Me.ParseBoolean(Me.GetIniValue(values, "CaptureStdOut", command.CaptureStdOut.ToString()), command.CaptureStdOut)
            command.CaptureStdErr = Me.ParseBoolean(Me.GetIniValue(values, "CaptureStdErr", command.CaptureStdErr.ToString()), command.CaptureStdErr)
            command.TimeoutMS = Me.ParseInteger(Me.GetIniValue(values, "TimeoutMS", command.TimeoutMS.ToString()), command.TimeoutMS)
            command.ShowWindow = Me.ParseBoolean(Me.GetIniValue(values, "ShowWindow", command.ShowWindow.ToString()), command.ShowWindow)
            command.OverwriteOutput = Me.ParseBoolean(Me.GetIniValue(values, "OverwriteOutput", command.OverwriteOutput.ToString()), command.OverwriteOutput)
            command.SuccessExitCode = Me.ParseInteger(Me.GetIniValue(values, "SuccessExitCode", command.SuccessExitCode.ToString()), command.SuccessExitCode)
            command.TreatStdErrAsFailure = Me.ParseBoolean(Me.GetIniValue(values, "TreatStdErrAsFailure", command.TreatStdErrAsFailure.ToString()), command.TreatStdErrAsFailure)

            Return command
        End Function

        Public Function ExecutePlugin(ByVal plugin As clsPluginDefinition,
                                      ByVal inputPath As String,
                                      ByVal outputPath As String,
                                      ByVal gameNumber As Integer,
                                      ByVal filename As String,
                                      ByVal resref As String,
                                      ByVal extensionValue As String,
                                      Optional ByVal actionValue As String = "",
                                      Optional ByVal extraArguments As String = "") As clsPluginExecutionResult

            Dim request As clsPluginExecutionRequest = New clsPluginExecutionRequest()
            request.Plugin = plugin
            request.InputPath = inputPath
            request.OutputPath = outputPath
            request.GameNumber = gameNumber
            request.Filename = filename
            request.ResRef = resref
            request.ExtensionValue = extensionValue
            request.ActionValue = actionValue
            request.ExtraArguments = extraArguments

            Dim worker As BackgroundWorker = New BackgroundWorker()
            Dim completed As AutoResetEvent = New AutoResetEvent(False)
            Dim workerResult As clsPluginExecutionResult = Nothing
            Dim workerError As System.Exception = Nothing

            AddHandler worker.DoWork, Sub(ByVal sender As Object, ByVal e As DoWorkEventArgs)
                                          e.Result = Me.ExecutePluginInternal(CType(e.Argument, clsPluginExecutionRequest))
                                      End Sub

            AddHandler worker.RunWorkerCompleted, Sub(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
                                                      If e.Error IsNot Nothing Then
                                                          workerError = e.Error
                                                      Else
                                                          workerResult = CType(e.Result, clsPluginExecutionResult)
                                                      End If

                                                      completed.Set()
                                                  End Sub

            worker.RunWorkerAsync(request)

            Do While Not completed.WaitOne(50, False)
                Application.DoEvents()
            Loop

            worker.Dispose()

            If workerError IsNot Nothing Then
                Dim result As clsPluginExecutionResult = New clsPluginExecutionResult()
                result.PluginId = If(plugin IsNot Nothing, plugin.Id, "")
                result.PluginName = If(plugin IsNot Nothing, plugin.Name, "")
                result.InputPath = inputPath
                result.OutputPath = outputPath
                result.Extension = Me.NormalizeExtension(extensionValue)
                result.Action = If(actionValue IsNot Nothing, actionValue.Trim().ToLower(), "")
                result.ErrorMessage = workerError.Message
                result.DiagnosticMessage = workerError.ToString()
                Return result
            End If

            Return workerResult
        End Function

        Private Function ExecutePluginInternal(ByVal request As clsPluginExecutionRequest) As clsPluginExecutionResult
            Dim plugin As clsPluginDefinition = request.Plugin
            Dim inputPath As String = request.InputPath
            Dim outputPath As String = request.OutputPath
            Dim gameNumber As Integer = request.GameNumber
            Dim filename As String = request.Filename
            Dim resref As String = request.ResRef
            Dim extensionValue As String = request.ExtensionValue
            Dim actionValue As String = request.ActionValue
            Dim extraArguments As String = request.ExtraArguments

            Dim result As clsPluginExecutionResult = New clsPluginExecutionResult()
            result.InputPath = inputPath
            result.OutputPath = outputPath
            result.Extension = Me.NormalizeExtension(extensionValue)

            If actionValue IsNot Nothing Then
                result.Action = actionValue.Trim().ToLower()
            End If

            If plugin Is Nothing Then
                result.ErrorMessage = "No plugin was supplied."
                Return result
            End If

            result.PluginId = plugin.Id
            result.PluginName = plugin.Name

            If Not plugin.Enabled Then
                result.ErrorMessage = "Plugin is disabled."
                Return result
            End If

            If Not File.Exists(inputPath) Then
                result.ErrorMessage = "Input file could not be found."
                result.DiagnosticMessage = inputPath
                Return result
            End If

            If Not Me.ValidatePluginFiles(plugin) Then
                result.ErrorMessage = "Plugin is missing required files."
                result.DiagnosticMessage = Me.FormatMissingFiles(plugin)
                Return result
            End If

            Dim command As clsPluginCommand = Nothing

            Try
                command = Me.LoadPluginCommand(plugin)
            Catch ex As System.Exception
                result.ErrorMessage = ex.Message
                result.DiagnosticMessage = ex.ToString()
                Return result
            End Try

            Dim resolvedExecutable As String = Me.ResolvePluginPath(plugin, command.Executable)
            Dim resolvedWorkingDirectory As String = Me.ResolvePluginPath(plugin, command.WorkingDirectory)

            If resolvedWorkingDirectory Is Nothing OrElse resolvedWorkingDirectory.Trim().Length = 0 Then
                resolvedWorkingDirectory = plugin.PluginDirectory
            End If

            Dim resolvedArguments As String = Me.ResolveCommandArguments(plugin,
                                                                         command.Arguments,
                                                                         inputPath,
                                                                         outputPath,
                                                                         gameNumber,
                                                                         filename,
                                                                         resref,
                                                                         extensionValue,
                                                                         actionValue,
                                                                         extraArguments)

            result.ExecutablePath = resolvedExecutable
            result.Arguments = resolvedArguments
            result.WorkingDirectory = resolvedWorkingDirectory

            If Not File.Exists(resolvedExecutable) Then
                result.ErrorMessage = "Plugin executable could not be found."
                result.DiagnosticMessage = resolvedExecutable
                Return result
            End If

            Try
                If outputPath IsNot Nothing AndAlso outputPath.Trim().Length > 0 Then
                    Dim outputDirectory As String = Path.GetDirectoryName(outputPath)

                    If outputDirectory IsNot Nothing AndAlso outputDirectory.Trim().Length > 0 Then
                        If Not Directory.Exists(outputDirectory) Then
                            Directory.CreateDirectory(outputDirectory)
                        End If
                    End If

                    If File.Exists(outputPath) AndAlso command.OverwriteOutput Then
                        File.Delete(outputPath)
                    End If
                End If
            Catch exOutput As System.Exception
                result.ErrorMessage = "Unable to prepare plugin output path."
                result.DiagnosticMessage = exOutput.ToString()
                Return result
            End Try

            Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
            startInfo.FileName = resolvedExecutable
            startInfo.Arguments = resolvedArguments
            startInfo.WorkingDirectory = resolvedWorkingDirectory
            startInfo.UseShellExecute = False
            startInfo.RedirectStandardOutput = command.CaptureStdOut
            startInfo.RedirectStandardError = command.CaptureStdErr
            startInfo.CreateNoWindow = Not command.ShowWindow

            Dim process As Process = New Process()
            process.StartInfo = startInfo
            process.EnableRaisingEvents = True

            Dim stdoutBuilder As StringBuilder = New StringBuilder()
            Dim stderrBuilder As StringBuilder = New StringBuilder()
            Dim stdoutClosed As AutoResetEvent = New AutoResetEvent(Not command.CaptureStdOut)
            Dim stderrClosed As AutoResetEvent = New AutoResetEvent(Not command.CaptureStdErr)

            Try
                If command.CaptureStdOut Then
                    AddHandler process.OutputDataReceived, Sub(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
                                                               If e.Data Is Nothing Then
                                                                   stdoutClosed.Set()
                                                               Else
                                                                   SyncLock stdoutBuilder
                                                                       stdoutBuilder.AppendLine(e.Data)
                                                                   End SyncLock
                                                               End If
                                                           End Sub
                End If

                If command.CaptureStdErr Then
                    AddHandler process.ErrorDataReceived, Sub(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
                                                              If e.Data Is Nothing Then
                                                                  stderrClosed.Set()
                                                              Else
                                                                  SyncLock stderrBuilder
                                                                      stderrBuilder.AppendLine(e.Data)
                                                                  End SyncLock
                                                              End If
                                                          End Sub
                End If

                process.Start()

                If command.CaptureStdOut Then
                    process.BeginOutputReadLine()
                End If

                If command.CaptureStdErr Then
                    process.BeginErrorReadLine()
                End If

                If command.TimeoutMS > 0 Then
                    If Not process.WaitForExit(command.TimeoutMS) Then
                        result.TimedOut = True

                        Try
                            process.Kill()
                        Catch exKill As System.Exception
                        End Try

                        result.ErrorMessage = "Plugin execution timed out."
                    End If
                Else
                    process.WaitForExit()
                End If

                If Not result.TimedOut Then
                    stdoutClosed.WaitOne(5000, False)
                    stderrClosed.WaitOne(5000, False)

                    result.ExitCode = process.ExitCode

                    SyncLock stdoutBuilder
                        result.StandardOutput = stdoutBuilder.ToString()
                    End SyncLock

                    SyncLock stderrBuilder
                        result.StandardError = stderrBuilder.ToString()
                    End SyncLock

                    result.Success = (result.ExitCode = command.SuccessExitCode)

                    If command.TreatStdErrAsFailure AndAlso result.StandardError.Trim().Length > 0 Then
                        result.Success = False
                    End If

                    If Not result.Success AndAlso result.ErrorMessage.Trim().Length = 0 Then
                        result.ErrorMessage = "Plugin process failed with exit code " & result.ExitCode.ToString() & "."
                    End If
                Else
                    SyncLock stdoutBuilder
                        result.StandardOutput = stdoutBuilder.ToString()
                    End SyncLock

                    SyncLock stderrBuilder
                        result.StandardError = stderrBuilder.ToString()
                    End SyncLock
                End If

            Catch ex As System.Exception
                result.Success = False
                result.ErrorMessage = ex.Message
                result.DiagnosticMessage = ex.ToString()
            Finally
                Try
                    If process IsNot Nothing Then
                        process.Close()
                        process.Dispose()
                    End If
                Catch exDispose As System.Exception
                End Try
            End Try

            Return result
        End Function

        Private Function ResolvePluginPath(ByVal plugin As clsPluginDefinition, ByVal value As String) As String
            If value Is Nothing Then
                Return ""
            End If

            Dim result As String = value.Trim()

            result = result.Replace("{plugin_dir}", plugin.PluginDirectory)
            result = result.Replace("{working_dir}", plugin.PluginDirectory)
            result = result.Replace("{app_dir}", plugin.AppDirectory)
            result = result.Replace("{config_dir}", plugin.ConfigDirectory)
            result = result.Replace("{runtime_dir}", plugin.RuntimeDirectory)
            result = result.Replace("{tools_dir}", plugin.ToolsDirectory)

            If Path.IsPathRooted(result) Then
                Return result
            End If

            Return Path.Combine(plugin.PluginDirectory, result)
        End Function

        Private Function ResolveCommandArguments(ByVal plugin As clsPluginDefinition,
                                                 ByVal arguments As String,
                                                 ByVal inputPath As String,
                                                 ByVal outputPath As String,
                                                 ByVal gameNumber As Integer,
                                                 ByVal filename As String,
                                                 ByVal resref As String,
                                                 ByVal extensionValue As String,
                                                 ByVal actionValue As String,
                                                 Optional ByVal extraArguments As String = "") As String

            If arguments Is Nothing Then
                arguments = ""
            End If

            If extraArguments Is Nothing Then
                extraArguments = ""
            End If

            Dim gameName As String = "k1"

            If gameNumber = 2 Then
                gameName = "tsl"
            End If

            Dim normalizedExtension As String = Me.NormalizeExtension(extensionValue)
            Dim normalizedAction As String = ""

            If actionValue IsNot Nothing Then
                normalizedAction = actionValue.Trim().ToLower()
            End If

            Dim result As String = arguments
            Dim hadExtraArgumentsPlaceholder As Boolean = (result.IndexOf("{extra_args}", StringComparison.OrdinalIgnoreCase) >= 0)
            result = result.Replace("{input}", inputPath)
            result = result.Replace("{output}", outputPath)
            result = result.Replace("{game}", gameNumber.ToString())
            result = result.Replace("{game_number}", gameNumber.ToString())
            result = result.Replace("{game_name}", gameName)
            result = result.Replace("{filename}", filename)
            result = result.Replace("{resref}", resref)
            result = result.Replace("{extension}", normalizedExtension)
            result = result.Replace("{action}", normalizedAction)
            result = result.Replace("{extra_args}", extraArguments.Trim())
            result = result.Replace("{plugin_dir}", plugin.PluginDirectory)
            result = result.Replace("{working_dir}", plugin.PluginDirectory)
            result = result.Replace("{app_dir}", plugin.AppDirectory)
            result = result.Replace("{config_dir}", plugin.ConfigDirectory)
            result = result.Replace("{runtime_dir}", plugin.RuntimeDirectory)
            result = result.Replace("{tools_dir}", plugin.ToolsDirectory)

            If Not hadExtraArgumentsPlaceholder AndAlso extraArguments.Trim().Length > 0 Then
                result = extraArguments.Trim() & " " & result
            End If

            Return result
        End Function

        Private Function FormatMissingFiles(ByVal plugin As clsPluginDefinition) As String
            Dim missingFiles As ArrayList = Me.GetMissingRequiredFiles(plugin)
            Dim builder As StringBuilder = New StringBuilder()

            For Each missing As Object In missingFiles
                builder.AppendLine(CStr(missing))
            Next

            Return builder.ToString()
        End Function

        Private Function ReadIniSection(ByVal iniPath As String, ByVal sectionName As String) As Hashtable
            Dim values As Hashtable = New Hashtable(StringComparer.OrdinalIgnoreCase)

            If Not File.Exists(iniPath) Then
                Return values
            End If

            Dim inRequestedSection As Boolean = False
            Dim lines As String() = File.ReadAllLines(iniPath)

            For Each rawLine As String In lines
                Dim line As String = rawLine.Trim()

                If line.Length = 0 Then
                    Continue For
                End If

                If line.StartsWith(";") OrElse line.StartsWith("#") Then
                    Continue For
                End If

                If line.StartsWith("[") AndAlso line.EndsWith("]") Then
                    Dim currentSection As String = line.Substring(1, line.Length - 2).Trim()
                    inRequestedSection = (String.Compare(currentSection, sectionName, True) = 0)
                    Continue For
                End If

                If inRequestedSection Then
                    Dim equalsIndex As Integer = line.IndexOf("="c)

                    If equalsIndex > -1 Then
                        Dim key As String = line.Substring(0, equalsIndex).Trim()
                        Dim value As String = line.Substring(equalsIndex + 1).Trim()

                        If key.Length > 0 Then
                            values(key) = value
                        End If
                    End If
                End If
            Next

            Return values
        End Function

        Private Function GetIniValue(ByVal values As Hashtable, ByVal key As String, ByVal defaultValue As String) As String
            If values Is Nothing Then
                Return defaultValue
            End If

            If values.ContainsKey(key) Then
                Return CStr(values(key))
            End If

            Return defaultValue
        End Function

        Private Function GetXmlNodeText(ByVal parentNode As XmlNode, ByVal xPath As String, ByVal defaultValue As String) As String
            If parentNode Is Nothing Then
                Return defaultValue
            End If

            Dim node As XmlNode = parentNode.SelectSingleNode(xPath)

            If node Is Nothing Then
                Return defaultValue
            End If

            If node.InnerText Is Nothing Then
                Return defaultValue
            End If

            Return node.InnerText.Trim()
        End Function

        Private Function ParseBoolean(ByVal value As String, ByVal defaultValue As Boolean) As Boolean
            If value Is Nothing Then
                Return defaultValue
            End If

            Dim normalized As String = value.Trim().ToLower()

            If normalized = "true" OrElse normalized = "1" OrElse normalized = "yes" OrElse normalized = "enabled" Then
                Return True
            End If

            If normalized = "false" OrElse normalized = "0" OrElse normalized = "no" OrElse normalized = "disabled" Then
                Return False
            End If

            Return defaultValue
        End Function

        Private Function ParseInteger(ByVal value As String, ByVal defaultValue As Integer) As Integer
            If value Is Nothing Then
                Return defaultValue
            End If

            Try
                Return Integer.Parse(value.Trim())
            Catch ex As System.Exception
                Return defaultValue
            End Try
        End Function

        Private Function NormalizeExtension(ByVal extensionValue As String) As String
            If extensionValue Is Nothing Then
                Return ""
            End If

            Dim result As String = extensionValue.Trim().ToLower()

            If result.StartsWith(".") Then
                result = result.Substring(1)
            End If

            Return result
        End Function

        Private Function GetEmptyPluginLibraryXml(ByVal nodeName As String) As String
            Return "<?xml version=""1.0"" encoding=""utf-8""?>" & vbCrLf &
                   "<PluginLibrary>" & vbCrLf &
                   "</PluginLibrary>" & vbCrLf
        End Function

    End Class

End Namespace
