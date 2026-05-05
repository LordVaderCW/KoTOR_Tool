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

                extensionValue = Me.NormalizeExtension(extensionValue)

                If actionValue IsNot Nothing Then
                    actionValue = actionValue.Trim().ToLower()
                Else
                    actionValue = ""
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
                Dim filePath As String = Me.ResolvePluginRelativePath(plugin, fileName)

                If Not File.Exists(filePath) AndAlso Not Directory.Exists(filePath) Then
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
                Dim filePath As String = Me.ResolvePluginRelativePath(plugin, fileName)

                If Not File.Exists(filePath) AndAlso Not Directory.Exists(filePath) Then
                    missingFiles.Add(fileName)
                End If
            Next

            Return missingFiles
        End Function

        Private Function ResolvePluginRelativePath(ByVal plugin As clsPluginDefinition, ByVal relativePath As String) As String
            If relativePath Is Nothing Then
                Return ""
            End If

            Dim resolvedPath As String = relativePath.Trim()

            resolvedPath = resolvedPath.Replace("{plugin_dir}", plugin.PluginDirectory)
            resolvedPath = resolvedPath.Replace("{app_dir}", plugin.AppDirectory)
            resolvedPath = resolvedPath.Replace("{config_dir}", plugin.ConfigDirectory)
            resolvedPath = resolvedPath.Replace("{runtime_dir}", plugin.RuntimeDirectory)
            resolvedPath = resolvedPath.Replace("{tools_dir}", plugin.ToolsDirectory)

            If Path.IsPathRooted(resolvedPath) Then
                Return resolvedPath
            End If

            Return Path.Combine(plugin.PluginDirectory, resolvedPath)
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
                                      Optional ByVal actionValue As String = "") As clsPluginExecutionResult

            Dim request As clsPluginExecutionRequest = New clsPluginExecutionRequest()
            request.Plugin = plugin
            request.InputPath = inputPath
            request.OutputPath = outputPath
            request.GameNumber = gameNumber
            request.Filename = filename
            request.ResRef = resref
            request.ExtensionValue = extensionValue
            request.ActionValue = actionValue

            Return Me.ExecutePluginOnBackgroundWorker(request)
        End Function

        Private Function ExecutePluginOnBackgroundWorker(ByVal request As clsPluginExecutionRequest) As clsPluginExecutionResult
            Dim worker As BackgroundWorker = New BackgroundWorker()
            Dim waitHandle As ManualResetEvent = New ManualResetEvent(False)
            Dim result As clsPluginExecutionResult = Nothing
            Dim workerException As System.Exception = Nothing

            AddHandler worker.DoWork,
                Sub(ByVal sender As Object, ByVal e As DoWorkEventArgs)
                    Try
                        result = Me.ExecutePluginInternal(request)
                    Catch ex As System.Exception
                        workerException = ex
                    Finally
                        waitHandle.Set()
                    End Try
                End Sub

            worker.RunWorkerAsync()

            Do While Not waitHandle.WaitOne(25, False)
                Application.DoEvents()
            Loop

            waitHandle.Close()
            worker.Dispose()

            If workerException IsNot Nothing Then
                Dim failedResult As clsPluginExecutionResult = New clsPluginExecutionResult()
                failedResult.Success = False
                failedResult.ErrorMessage = workerException.Message
                Return failedResult
            End If

            If result Is Nothing Then
                result = New clsPluginExecutionResult()
                result.Success = False
                result.ErrorMessage = "Plugin execution did not return a result."
            End If

            Return result
        End Function

        Private Function ExecutePluginInternal(ByVal request As clsPluginExecutionRequest) As clsPluginExecutionResult
            Dim result As clsPluginExecutionResult = New clsPluginExecutionResult()

            result.InputPath = request.InputPath
            result.OutputPath = request.OutputPath
            result.Action = request.ActionValue
            result.Extension = Me.NormalizeExtension(request.ExtensionValue)

            If request.Plugin IsNot Nothing Then
                result.PluginId = request.Plugin.Id
                result.PluginName = request.Plugin.Name
            End If

            Try
                If request.Plugin Is Nothing Then
                    result.ErrorMessage = "Plugin definition was not supplied."
                    Return result
                End If

                If Not request.Plugin.Enabled Then
                    result.ErrorMessage = "Plugin is disabled: " & request.Plugin.Name
                    Return result
                End If

                Dim missingFiles As ArrayList = Me.GetMissingRequiredFiles(request.Plugin)
                If missingFiles.Count > 0 Then
                    result.ErrorMessage = "Plugin is missing required file(s): " & Me.JoinArrayList(missingFiles, ", ")
                    Return result
                End If

                Dim command As clsPluginCommand = Me.LoadPluginCommand(request.Plugin)
                Dim placeholders As Hashtable = Me.BuildPlaceholders(request.Plugin, request.InputPath, request.OutputPath, request.GameNumber, request.Filename, request.ResRef, request.ExtensionValue)

                Dim executableText As String = Me.ResolvePlaceholders(command.Executable, placeholders)
                Dim argumentsText As String = Me.ResolvePlaceholders(command.Arguments, placeholders)
                Dim workingDirectoryText As String = Me.ResolvePlaceholders(command.WorkingDirectory, placeholders)

                If executableText Is Nothing OrElse executableText.Trim().Length = 0 Then
                    result.ErrorMessage = "Plugin command executable is blank."
                    Return result
                End If

                If Not Path.IsPathRooted(executableText) Then
                    executableText = Path.Combine(request.Plugin.PluginDirectory, executableText)
                End If

                If workingDirectoryText Is Nothing OrElse workingDirectoryText.Trim().Length = 0 Then
                    workingDirectoryText = request.Plugin.PluginDirectory
                End If

                If Not Path.IsPathRooted(workingDirectoryText) Then
                    workingDirectoryText = Path.Combine(request.Plugin.PluginDirectory, workingDirectoryText)
                End If

                result.ExecutablePath = executableText
                result.Arguments = argumentsText
                result.WorkingDirectory = workingDirectoryText

                If Not File.Exists(executableText) Then
                    result.ErrorMessage = "Plugin executable could not be found: " & executableText
                    Return result
                End If

                If Not Directory.Exists(workingDirectoryText) Then
                    Directory.CreateDirectory(workingDirectoryText)
                End If

                If request.OutputPath IsNot Nothing AndAlso request.OutputPath.Trim().Length > 0 Then
                    Dim outputDirectory As String = Path.GetDirectoryName(request.OutputPath)

                    If outputDirectory IsNot Nothing AndAlso outputDirectory.Trim().Length > 0 Then
                        If Not Directory.Exists(outputDirectory) Then
                            Directory.CreateDirectory(outputDirectory)
                        End If
                    End If

                    If command.OverwriteOutput AndAlso File.Exists(request.OutputPath) Then
                        File.Delete(request.OutputPath)
                    End If
                End If

                Dim outputBuilder As StringBuilder = New StringBuilder()
                Dim errorBuilder As StringBuilder = New StringBuilder()

                Dim process As Process = New Process()
                process.StartInfo.FileName = executableText
                process.StartInfo.Arguments = argumentsText
                process.StartInfo.WorkingDirectory = workingDirectoryText
                process.StartInfo.UseShellExecute = False
                process.StartInfo.CreateNoWindow = Not command.ShowWindow
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                process.StartInfo.RedirectStandardOutput = command.CaptureStdOut
                process.StartInfo.RedirectStandardError = command.CaptureStdErr

                If command.CaptureStdOut Then
                    AddHandler process.OutputDataReceived,
                        Sub(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
                            If e.Data IsNot Nothing Then
                                SyncLock outputBuilder
                                    outputBuilder.AppendLine(e.Data)
                                End SyncLock
                            End If
                        End Sub
                End If

                If command.CaptureStdErr Then
                    AddHandler process.ErrorDataReceived,
                        Sub(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
                            If e.Data IsNot Nothing Then
                                SyncLock errorBuilder
                                    errorBuilder.AppendLine(e.Data)
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

                If Not process.WaitForExit(command.TimeoutMS) Then
                    result.TimedOut = True

                    Try
                        process.Kill()
                    Catch exKill As System.Exception
                    End Try

                    Try
                        process.WaitForExit()
                    Catch exWaitKill As System.Exception
                    End Try

                    result.ErrorMessage = "Plugin process timed out."
                    Return result
                End If

                Try
                    process.WaitForExit()
                Catch exFinalWait As System.Exception
                End Try

                If command.CaptureStdOut Then
                    SyncLock outputBuilder
                        result.StandardOutput = outputBuilder.ToString()
                    End SyncLock
                End If

                If command.CaptureStdErr Then
                    SyncLock errorBuilder
                        result.StandardError = errorBuilder.ToString()
                    End SyncLock
                End If

                result.ExitCode = process.ExitCode

                Try
                    process.Close()
                Catch exClose As System.Exception
                End Try

                If result.StandardOutput IsNot Nothing AndAlso result.StandardOutput.Trim().Length > 0 Then
                    result.DiagnosticMessage &= result.StandardOutput
                End If

                If result.StandardError IsNot Nothing AndAlso result.StandardError.Trim().Length > 0 Then
                    If result.DiagnosticMessage.Trim().Length > 0 Then
                        result.DiagnosticMessage &= vbCrLf & vbCrLf
                    End If

                    result.DiagnosticMessage &= result.StandardError
                End If

                If result.ExitCode = command.SuccessExitCode Then
                    If command.TreatStdErrAsFailure AndAlso result.StandardError IsNot Nothing AndAlso result.StandardError.Trim().Length > 0 Then
                        result.Success = False
                        result.ErrorMessage = "Plugin wrote to stderr and TreatStdErrAsFailure is enabled."
                        Return result
                    End If

                    If command.OutputMode IsNot Nothing AndAlso command.OutputMode.Trim().ToLower() = "file" Then
                        result.Success = File.Exists(request.OutputPath)

                        If Not result.Success Then
                            result.ErrorMessage = "Plugin finished, but the expected output file was not created."
                        End If
                    Else
                        result.Success = True
                    End If
                Else
                    result.Success = False
                    result.ErrorMessage = "Plugin exited with code " & result.ExitCode.ToString() & "."
                End If

            Catch ex As System.Exception
                result.Success = False
                result.ErrorMessage = ex.Message
            End Try

            Return result
        End Function

        Public Function ExecutePluginForResource(ByVal extensionValue As String,
                                                 ByVal actionValue As String,
                                                 ByVal inputPath As String,
                                                 ByVal outputPath As String,
                                                 ByVal gameNumber As Integer,
                                                 ByVal filename As String,
                                                 ByVal resref As String) As clsPluginExecutionResult

            Dim result As clsPluginExecutionResult = New clsPluginExecutionResult()
            result.Action = actionValue
            result.Extension = Me.NormalizeExtension(extensionValue)
            result.InputPath = inputPath
            result.OutputPath = outputPath

            Dim plugin As clsPluginDefinition = Me.FindPluginForResource(extensionValue, actionValue)

            If plugin Is Nothing Then
                result.ErrorMessage = "No plugin is registered for ." & Me.NormalizeExtension(extensionValue) & " using action '" & actionValue & "'."
                Return result
            End If

            Return Me.ExecutePlugin(plugin, inputPath, outputPath, gameNumber, filename, resref, extensionValue, actionValue)
        End Function

        Public Function BuildDefaultOutputPath(ByVal workingDirectory As String, ByVal filename As String, ByVal outputExtension As String) As String
            Dim baseName As String = Path.GetFileNameWithoutExtension(filename)
            Dim normalizedExtension As String = outputExtension

            If normalizedExtension Is Nothing OrElse normalizedExtension.Trim().Length = 0 Then
                normalizedExtension = ".txt"
            End If

            If Not normalizedExtension.StartsWith(".") Then
                normalizedExtension = "." & normalizedExtension
            End If

            Return Path.Combine(workingDirectory, baseName & normalizedExtension)
        End Function

        Private Function BuildPlaceholders(ByVal plugin As clsPluginDefinition,
                                           ByVal inputPath As String,
                                           ByVal outputPath As String,
                                           ByVal gameNumber As Integer,
                                           ByVal filename As String,
                                           ByVal resref As String,
                                           ByVal extensionValue As String) As Hashtable

            Dim placeholders As Hashtable = New Hashtable(StringComparer.OrdinalIgnoreCase)
            Dim gameName As String = "k1"
            Dim workingDirectory As String = ""
            Dim nwscriptFileName As String = "k1_nwscript.nss"
            Dim nwscriptPath As String = ""

            If gameNumber = 2 Then
                gameName = "k2"
                nwscriptFileName = "tsl_nwscript.nss"
            End If

            If inputPath IsNot Nothing AndAlso inputPath.Trim().Length > 0 Then
                workingDirectory = Path.GetDirectoryName(inputPath)
            End If

            nwscriptPath = Path.Combine(plugin.ToolsDirectory, nwscriptFileName)

            placeholders("input") = inputPath
            placeholders("output") = outputPath
            placeholders("game") = gameNumber.ToString()
            placeholders("game_name") = gameName
            placeholders("plugin_id") = plugin.Id
            placeholders("plugin_name") = plugin.Name
            placeholders("plugin_dir") = plugin.PluginDirectory
            placeholders("working_dir") = workingDirectory
            placeholders("startup_dir") = Application.StartupPath
            placeholders("filename") = filename
            placeholders("resref") = resref
            placeholders("extension") = Me.NormalizeExtension(extensionValue)
            placeholders("app_dir") = plugin.AppDirectory
            placeholders("config_dir") = plugin.ConfigDirectory
            placeholders("runtime_dir") = plugin.RuntimeDirectory
            placeholders("tools_dir") = plugin.ToolsDirectory
            placeholders("nwscript") = nwscriptPath
            placeholders("nwscript_file") = nwscriptFileName

            Return placeholders
        End Function

        Private Function ResolvePlaceholders(ByVal value As String, ByVal placeholders As Hashtable) As String
            If value Is Nothing Then
                Return ""
            End If

            Dim result As String = value

            For Each keyObj As Object In placeholders.Keys
                Dim key As String = CStr(keyObj)
                Dim replacement As String = ""

                If placeholders(keyObj) IsNot Nothing Then
                    replacement = CStr(placeholders(keyObj))
                End If

                result = result.Replace("{" & key & "}", replacement)
            Next

            Return result
        End Function

        Private Function ReadIniSection(ByVal iniPath As String, ByVal sectionName As String) As Hashtable
            Dim values As Hashtable = New Hashtable(StringComparer.OrdinalIgnoreCase)
            Dim currentSection As String = ""
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
                    currentSection = line.Substring(1, line.Length - 2).Trim()
                    Continue For
                End If

                If StringType.StrCmp(currentSection, sectionName, False) = 0 Then
                    Dim equalsIndex As Integer = line.IndexOf("="c)

                    If equalsIndex > 0 Then
                        Dim key As String = line.Substring(0, equalsIndex).Trim()
                        Dim iniValue As String = line.Substring(equalsIndex + 1).Trim()
                        values(key) = iniValue
                    End If
                End If
            Next

            Return values
        End Function

        Private Function GetIniValue(ByVal values As Hashtable, ByVal key As String, ByVal defaultValue As String) As String
            If values IsNot Nothing AndAlso values.ContainsKey(key) Then
                Return CStr(values(key))
            End If

            Return defaultValue
        End Function

        Private Function GetXmlNodeText(ByVal parentNode As XmlNode, ByVal childName As String, ByVal defaultValue As String) As String
            If parentNode Is Nothing Then
                Return defaultValue
            End If

            Dim childNode As XmlNode = parentNode.SelectSingleNode(childName)

            If childNode Is Nothing Then
                Return defaultValue
            End If

            If childNode.InnerText Is Nothing Then
                Return defaultValue
            End If

            Return childNode.InnerText.Trim()
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

        Private Function ParseBoolean(ByVal value As String, ByVal defaultValue As Boolean) As Boolean
            If value Is Nothing Then
                Return defaultValue
            End If

            Dim normalized As String = value.Trim().ToLower()

            If normalized = "true" OrElse normalized = "yes" OrElse normalized = "1" OrElse normalized = "on" Then
                Return True
            End If

            If normalized = "false" OrElse normalized = "no" OrElse normalized = "0" OrElse normalized = "off" Then
                Return False
            End If

            Return defaultValue
        End Function

        Private Function ParseInteger(ByVal value As String, ByVal defaultValue As Integer) As Integer
            Try
                Return Convert.ToInt32(value)
            Catch ex As System.Exception
                Return defaultValue
            End Try
        End Function

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

        Private Function GetEmptyPluginLibraryXml(ByVal sampleNodeName As String) As String
            Dim builder As StringBuilder = New StringBuilder()

            builder.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            builder.AppendLine("<PluginLibrary>")
            builder.AppendLine("</PluginLibrary>")

            Return builder.ToString()
        End Function

    End Class

End Namespace
