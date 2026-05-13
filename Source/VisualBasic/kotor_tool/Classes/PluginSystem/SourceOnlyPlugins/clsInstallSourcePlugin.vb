Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Security
Imports System.Text
Imports System.Xml

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsInstallSourcePlugin.vb
    '
    ' Installs compiled source-only plugins into the KoTOR Tool
    ' Restoration Project Plugins directory.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - This class only installs a successfully compiled source plugin.
    '   - First supported profile: GhostRigger.
    ' -----------------------------------------------------------------

    Public Class clsInstallSourcePlugin

        Public Event ProgressChanged(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)

        Public Function InstallSourcePlugin(ByVal context As clsSourcePluginContext) As clsSourcePluginContext

            If context Is Nothing Then
                Throw New ArgumentNullException("context")
            End If

            If context.PluginId Is Nothing OrElse context.PluginId.Trim().Length = 0 Then
                Throw New ApplicationException("Source plugin context does not contain a PluginId.")
            End If

            If String.Compare(context.PluginId.Trim(), "ghostrigger", True) <> 0 Then
                Throw New ApplicationException("No source-only installer profile exists for plugin id: " & context.PluginId)
            End If

            Return Me.InstallGhostRigger(context)
        End Function

        Private Function InstallGhostRigger(ByVal context As clsSourcePluginContext) As clsSourcePluginContext

            If context.BuiltExecutablePath Is Nothing OrElse context.BuiltExecutablePath.Trim().Length = 0 Then
                Throw New ArgumentException("context.BuiltExecutablePath")
            End If

            If Not File.Exists(context.BuiltExecutablePath) Then
                Throw New FileNotFoundException("Compiled GhostRigger executable was not found.", context.BuiltExecutablePath)
            End If

            If context.PluginsRoot Is Nothing OrElse context.PluginsRoot.Trim().Length = 0 Then
                Throw New ArgumentException("context.PluginsRoot")
            End If

            If Not Directory.Exists(context.PluginsRoot) Then
                Directory.CreateDirectory(context.PluginsRoot)
            End If

            If context.InstallDirectory Is Nothing OrElse context.InstallDirectory.Trim().Length = 0 Then
                context.InstallDirectory = Path.Combine(context.PluginsRoot, "GhostRigger")
            End If

            context.InstalledExecutablePath = Path.Combine(context.InstallDirectory, "GhostRigger-K1-K2.exe")

            Me.ReportProgress("Installing Source Plugin", "Preparing Plugins\GhostRigger directory...", 78)

            Me.PrepareInstallDirectory(context)

            Me.ReportProgress("Installing Source Plugin", "Copying compiled GhostRigger executable...", 82)

            File.Copy(context.BuiltExecutablePath, context.InstalledExecutablePath, True)

            Me.ReportProgress("Installing Source Plugin", "Copying GhostRigger metadata and source helpers...", 86)

            Me.CopyOptionalFile(context.SourceRoot, context.InstallDirectory, "LICENSE")
            Me.CopyOptionalFile(context.SourceRoot, context.InstallDirectory, "README.md")
            Me.CopyOptionalFile(context.SourceRoot, context.InstallDirectory, "requirements.txt")
            Me.CopyOptionalFile(context.SourceRoot, context.InstallDirectory, "pyproject.toml")
            Me.CopyOptionalFile(context.SourceRoot, context.InstallDirectory, "build_log.txt")
            Me.CopyOptionalFile(context.SourceRoot, context.InstallDirectory, "KoTORTool_BuildConsole.log")

            Me.CopyGhostRiggerSourceSubset(context.SourceRoot, Path.Combine(context.InstallDirectory, "_Source"))

            Me.ReportProgress("Installing Source Plugin", "Writing GhostRigger plugin.xml...", 91)

            Me.WriteGhostRiggerPluginXml(context)

            Me.ReportProgress("Installing Source Plugin", "Writing GhostRigger command.ini...", 94)

            Me.WriteGhostRiggerCommandIni(context)

            Me.ReportProgress("Installing Source Plugin", "Registering GhostRigger in InstalledPlugins.xml...", 96)

            Me.RegisterInstalledGhostRiggerPlugin(context)

            Me.ReportProgress("Installing Source Plugin", "Source plugin installation complete.", 97)

            Return context
        End Function

        Private Sub PrepareInstallDirectory(ByVal context As clsSourcePluginContext)

            If Not Directory.Exists(context.InstallDirectory) Then
                Directory.CreateDirectory(context.InstallDirectory)
                Return
            End If

            Me.NormalizeDirectoryAttributes(context.InstallDirectory)

            For Each filePath As String In Directory.GetFiles(context.InstallDirectory)
                Try
                    File.SetAttributes(filePath, FileAttributes.Normal)
                    File.Delete(filePath)
                Catch exFile As System.Exception
                End Try
            Next

            For Each directoryPath As String In Directory.GetDirectories(context.InstallDirectory)
                Dim directoryName As String = Path.GetFileName(directoryPath)

                If directoryName IsNot Nothing AndAlso String.Compare(directoryName, "_Build", True) = 0 Then
                    Continue For
                End If

                Try
                    Me.NormalizeDirectoryAttributes(directoryPath)
                    Directory.Delete(directoryPath, True)
                Catch exDirectory As System.Exception
                End Try
            Next
        End Sub

        Private Sub WriteGhostRiggerCommandIni(ByVal context As clsSourcePluginContext)

            Dim commandPath As String = Path.Combine(context.InstallDirectory, "command.ini")
            Dim builder As StringBuilder = New StringBuilder()

            builder.AppendLine("[LaunchUI]")
            builder.AppendLine("Executable=GhostRigger-K1-K2.exe")
            builder.AppendLine("Arguments=")
            builder.AppendLine("WorkingDirectory={plugin_dir}")
            builder.AppendLine("OutputMode=None")
            builder.AppendLine("OutputExtension=")
            builder.AppendLine("CaptureStdOut=False")
            builder.AppendLine("CaptureStdErr=False")
            builder.AppendLine("TimeoutMS=0")
            builder.AppendLine("WaitForExit=False")
            builder.AppendLine("ShowWindow=True")
            builder.AppendLine("OverwriteOutput=True")
            builder.AppendLine("SuccessExitCode=0")
            builder.AppendLine("TreatStdErrAsFailure=False")
            builder.AppendLine("")
            builder.AppendLine("[Command]")
            builder.AppendLine("Executable=GhostRigger-K1-K2.exe")
            builder.AppendLine("Arguments=")
            builder.AppendLine("WorkingDirectory={plugin_dir}")
            builder.AppendLine("OutputMode=None")
            builder.AppendLine("OutputExtension=")
            builder.AppendLine("CaptureStdOut=False")
            builder.AppendLine("CaptureStdErr=False")
            builder.AppendLine("TimeoutMS=0")
            builder.AppendLine("WaitForExit=False")
            builder.AppendLine("ShowWindow=True")
            builder.AppendLine("OverwriteOutput=True")
            builder.AppendLine("SuccessExitCode=0")
            builder.AppendLine("TreatStdErrAsFailure=False")
            builder.AppendLine("")
            builder.AppendLine("; Reserved command section for future clsPluginManager named-command support.")
            builder.AppendLine("; Current stable GhostRigger CLI support is launcher-first.")
            builder.AppendLine("")
            builder.AppendLine("[InspectMDL]")
            builder.AppendLine("Executable=py.exe")
            builder.AppendLine("Arguments=-3.12 -m tools.model_inspector --mdl ""{input}"" --json")
            builder.AppendLine("WorkingDirectory={plugin_dir}\_Source")
            builder.AppendLine("OutputMode=file")
            builder.AppendLine("OutputExtension=json")
            builder.AppendLine("CaptureStdOut=True")
            builder.AppendLine("CaptureStdErr=True")
            builder.AppendLine("TimeoutMS=60000")
            builder.AppendLine("ShowWindow=False")
            builder.AppendLine("OverwriteOutput=True")
            builder.AppendLine("SuccessExitCode=0")
            builder.AppendLine("TreatStdErrAsFailure=False")
            builder.AppendLine("")
            builder.AppendLine("[ExportMDLToFBX]")
            builder.AppendLine("Enabled=False")
            builder.AppendLine("Reason=Pending GhostRigger headless conversion CLI support.")
            builder.AppendLine("Executable=GhostRiggerCLI.exe")
            builder.AppendLine("Arguments=export-mdl --game {game_name} --mdl ""{input}"" --mdx ""{sidecar_mdx}"" --format fbx --output ""{output}"" --copy-textures --texture-output ""{texture_output}"" --no-gui")
            builder.AppendLine("WorkingDirectory={plugin_dir}")
            builder.AppendLine("OutputMode=file")
            builder.AppendLine("OutputExtension=fbx")
            builder.AppendLine("CaptureStdOut=True")
            builder.AppendLine("CaptureStdErr=True")
            builder.AppendLine("TimeoutMS=300000")
            builder.AppendLine("ShowWindow=False")
            builder.AppendLine("OverwriteOutput=True")
            builder.AppendLine("SuccessExitCode=0")
            builder.AppendLine("TreatStdErrAsFailure=False")

            File.WriteAllText(commandPath, builder.ToString(), Encoding.UTF8)
        End Sub

        Private Sub WriteGhostRiggerPluginXml(ByVal context As clsSourcePluginContext)

            Dim pluginXmlPath As String = Path.Combine(context.InstallDirectory, "plugin.xml")
            Dim versionText As String = "source-genspark_ai_developer"
            Dim branchText As String = "genspark_ai_developer"

            If context.Plugin IsNot Nothing Then
                If context.Plugin.Version IsNot Nothing AndAlso context.Plugin.Version.Trim().Length > 0 Then
                    versionText = context.Plugin.Version.Trim()
                End If

                If context.Plugin.GitHubBranch IsNot Nothing AndAlso context.Plugin.GitHubBranch.Trim().Length > 0 Then
                    branchText = context.Plugin.GitHubBranch.Trim()
                End If
            End If

            Dim builder As StringBuilder = New StringBuilder()

            builder.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            builder.AppendLine("<Plugin>")
            builder.AppendLine("    <Id>ghostrigger</Id>")
            builder.AppendLine("    <Name>GhostRigger / KotOR 3D Model Converter</Name>")
            builder.AppendLine("    <Author>CrispyW0nton</Author>")
            builder.AppendLine("    <Version>" & Me.XmlEncode(versionText) & "</Version>")
            builder.AppendLine("    <Type>ExternalTool</Type>")
            builder.AppendLine("    <Enabled>True</Enabled>")
            builder.AppendLine("    <SourceOnly>True</SourceOnly>")
            builder.AppendLine("    <BuildRequired>True</BuildRequired>")
            builder.AppendLine("    <SourceZipUrl>https://github.com/CrispyW0nton/Kotor-3D-Model-Converter/archive/refs/heads/genspark_ai_developer.zip</SourceZipUrl>")
            builder.AppendLine("    <SourceBuildProfile>GhostRigger</SourceBuildProfile>")
            builder.AppendLine("    <BuildScriptName>build.bat</BuildScriptName>")
            builder.AppendLine("    <BuiltExecutableName>GhostRigger-K1-K2.exe</BuiltExecutableName>")
            builder.AppendLine("")
            builder.AppendLine("    <Description>")
            builder.AppendLine("        Source-built KotOR 1 / TSL model pipeline for viewing, inspecting, editing, and exporting Odyssey Engine MDL/MDX model assets.")
            builder.AppendLine("    </Description>")
            builder.AppendLine("")
            builder.AppendLine("    <Compatibility>")
            builder.AppendLine("        <Application>KoTOR Tool Restoration Project</Application>")
            builder.AppendLine("        <MinimumAppVersion>1.0.3.4</MinimumAppVersion>")
            builder.AppendLine("        <Framework>NET20</Framework>")
            builder.AppendLine("        <Platform>Windows</Platform>")
            builder.AppendLine("    </Compatibility>")
            builder.AppendLine("")
            builder.AppendLine("    <Project>")
            builder.AppendLine("        <GitHubRepo>https://github.com/CrispyW0nton/Kotor-3D-Model-Converter</GitHubRepo>")
            builder.AppendLine("        <GitHubBranch>" & Me.XmlEncode(branchText) & "</GitHubBranch>")
            builder.AppendLine("        <Website>https://github.com/CrispyW0nton/Kotor-3D-Model-Converter</Website>")
            builder.AppendLine("        <DownloadUrl>https://github.com/CrispyW0nton/Kotor-3D-Model-Converter/archive/refs/heads/genspark_ai_developer.zip</DownloadUrl>")
            builder.AppendLine("    </Project>")
            builder.AppendLine("")
            builder.AppendLine("    <Layout>")
            builder.AppendLine("        <Folder name=""app"">.</Folder>")
            builder.AppendLine("        <Folder name=""config"">.</Folder>")
            builder.AppendLine("        <Folder name=""runtime"">.</Folder>")
            builder.AppendLine("        <Folder name=""tools"">_Source\tools</Folder>")
            builder.AppendLine("    </Layout>")
            builder.AppendLine("")
            builder.AppendLine("    <Handles>")
            builder.AppendLine("        <Resource extension=""mdl"" action=""open"" command=""Command"" description=""Open MDL/MDX models in GhostRigger."" />")
            builder.AppendLine("        <Resource extension=""mdx"" action=""open"" command=""Command"" description=""Open MDX sidecar model data in GhostRigger."" />")
            builder.AppendLine("        <Resource extension=""wok"" action=""open"" command=""Command"" description=""Open walkmesh data in GhostRigger where supported."" />")
            builder.AppendLine("        <Resource extension=""fbx"" action=""open"" command=""Command"" description=""Open FBX models in GhostRigger where supported."" />")
            builder.AppendLine("        <Resource extension=""mdl"" action=""inspect"" command=""InspectMDL"" description=""Inspect an MDL model and emit JSON metadata."" />")
            builder.AppendLine("        <Resource extension=""mdl"" action=""export-fbx"" command=""ExportMDLToFBX"" description=""Reserved future MDL/MDX to FBX export command."" />")
            builder.AppendLine("    </Handles>")
            builder.AppendLine("")
            builder.AppendLine("    <Files>")
            builder.AppendLine("        <File required=""true"">plugin.xml</File>")
            builder.AppendLine("        <File required=""true"">command.ini</File>")
            builder.AppendLine("        <File required=""true"">GhostRigger-K1-K2.exe</File>")
            builder.AppendLine("        <File required=""false"">LICENSE</File>")
            builder.AppendLine("        <File required=""false"">README.md</File>")
            builder.AppendLine("        <File required=""false"">requirements.txt</File>")
            builder.AppendLine("        <File required=""false"">_Source\main.py</File>")
            builder.AppendLine("        <File required=""false"">_Source\tools\model_inspector.py</File>")
            builder.AppendLine("    </Files>")
            builder.AppendLine("")
            builder.AppendLine("    <CommandIni>command.ini</CommandIni>")
            builder.AppendLine("</Plugin>")

            File.WriteAllText(pluginXmlPath, builder.ToString(), Encoding.UTF8)
        End Sub

        Private Sub RegisterInstalledGhostRiggerPlugin(ByVal context As clsSourcePluginContext)

            Dim registryPath As String = Path.Combine(context.PluginsRoot, "InstalledPlugins.xml")
            Dim doc As XmlDocument = New XmlDocument()

            If File.Exists(registryPath) Then
                doc.Load(registryPath)
            Else
                doc.LoadXml("<?xml version=""1.0"" encoding=""utf-8""?><PluginLibrary></PluginLibrary>")
            End If

            Dim root As XmlNode = doc.SelectSingleNode("/PluginLibrary")

            If root Is Nothing Then
                doc.RemoveAll()
                doc.LoadXml("<?xml version=""1.0"" encoding=""utf-8""?><PluginLibrary></PluginLibrary>")
                root = doc.SelectSingleNode("/PluginLibrary")
            End If

            Dim existing As XmlNode = root.SelectSingleNode("InstalledPlugin[Id='ghostrigger']")

            If existing IsNot Nothing Then
                root.RemoveChild(existing)
            End If

            Dim versionText As String = "source-genspark_ai_developer"

            If context.Plugin IsNot Nothing AndAlso context.Plugin.Version IsNot Nothing AndAlso context.Plugin.Version.Trim().Length > 0 Then
                versionText = context.Plugin.Version.Trim()
            End If

            Dim node As XmlElement = doc.CreateElement("InstalledPlugin")

            Me.AppendTextElement(doc, node, "Id", "ghostrigger")
            Me.AppendTextElement(doc, node, "Name", "GhostRigger / KotOR 3D Model Converter")
            Me.AppendTextElement(doc, node, "Directory", "GhostRigger")
            Me.AppendTextElement(doc, node, "Enabled", "True")
            Me.AppendTextElement(doc, node, "Manifest", "plugin.xml")
            Me.AppendTextElement(doc, node, "InstalledVersion", versionText)

            root.AppendChild(node)
            doc.Save(registryPath)
        End Sub

        Private Sub CopyGhostRiggerSourceSubset(ByVal sourceRoot As String,
                                                ByVal targetSourceRoot As String)

            If sourceRoot Is Nothing OrElse sourceRoot.Trim().Length = 0 Then
                Return
            End If

            If Not Directory.Exists(sourceRoot) Then
                Return
            End If

            If Directory.Exists(targetSourceRoot) Then
                Me.NormalizeDirectoryAttributes(targetSourceRoot)
                Directory.Delete(targetSourceRoot, True)
            End If

            Directory.CreateDirectory(targetSourceRoot)

            Me.CopyOptionalFile(sourceRoot, targetSourceRoot, "main.py")
            Me.CopyOptionalFile(sourceRoot, targetSourceRoot, "requirements.txt")
            Me.CopyOptionalFile(sourceRoot, targetSourceRoot, "pyproject.toml")
            Me.CopyOptionalFile(sourceRoot, targetSourceRoot, "GhostRigger-K1-K2.spec")
            Me.CopyOptionalFile(sourceRoot, targetSourceRoot, "build.bat")
            Me.CopyOptionalFile(sourceRoot, targetSourceRoot, "LICENSE")
            Me.CopyOptionalFile(sourceRoot, targetSourceRoot, "README.md")

            Me.CopyOptionalDirectory(sourceRoot, targetSourceRoot, "tools")
            Me.CopyOptionalDirectory(sourceRoot, targetSourceRoot, "src")
            Me.CopyOptionalDirectory(sourceRoot, targetSourceRoot, "scripts")
            Me.CopyOptionalDirectory(sourceRoot, targetSourceRoot, "assets")
            Me.CopyOptionalDirectory(sourceRoot, targetSourceRoot, "templates")
            Me.CopyOptionalDirectory(sourceRoot, targetSourceRoot, "docs")
        End Sub

        Private Sub CopyOptionalFile(ByVal sourceRoot As String,
                                     ByVal targetRoot As String,
                                     ByVal fileName As String)

            If sourceRoot Is Nothing OrElse targetRoot Is Nothing OrElse fileName Is Nothing Then
                Return
            End If

            Dim sourcePath As String = Path.Combine(sourceRoot, fileName)

            If Not File.Exists(sourcePath) Then
                Return
            End If

            If Not Directory.Exists(targetRoot) Then
                Directory.CreateDirectory(targetRoot)
            End If

            File.Copy(sourcePath, Path.Combine(targetRoot, fileName), True)
        End Sub

        Private Sub CopyOptionalDirectory(ByVal sourceRoot As String,
                                          ByVal targetRoot As String,
                                          ByVal directoryName As String)

            If sourceRoot Is Nothing OrElse targetRoot Is Nothing OrElse directoryName Is Nothing Then
                Return
            End If

            Dim sourcePath As String = Path.Combine(sourceRoot, directoryName)

            If Not Directory.Exists(sourcePath) Then
                Return
            End If

            Dim targetPath As String = Path.Combine(targetRoot, directoryName)

            Me.CopyDirectoryContents(sourcePath, targetPath, True)
        End Sub

        Private Sub CopyDirectoryContents(ByVal sourceDirectory As String,
                                          ByVal targetDirectory As String,
                                          ByVal overwrite As Boolean)

            If Not Directory.Exists(targetDirectory) Then
                Directory.CreateDirectory(targetDirectory)
            End If

            Dim files As String() = Directory.GetFiles(sourceDirectory)

            For Each filePath As String In files
                Dim name As String = Path.GetFileName(filePath)

                If name Is Nothing Then
                    Continue For
                End If

                Dim loweredName As String = name.ToLowerInvariant()

                If loweredName = "kotortool_buildconsole.log" Then
                    Continue For
                End If

                Dim targetPath As String = Path.Combine(targetDirectory, name)
                File.Copy(filePath, targetPath, overwrite)
            Next

            Dim directories As String() = Directory.GetDirectories(sourceDirectory)

            For Each directoryPath As String In directories
                Dim name As String = Path.GetFileName(directoryPath)

                If name Is Nothing Then
                    Continue For
                End If

                Dim lowered As String = name.ToLowerInvariant()

                If lowered = "dist" OrElse
                   lowered = "build" OrElse
                   lowered = "__pycache__" OrElse
                   lowered = ".git" OrElse
                   lowered = ".pytest_cache" OrElse
                   lowered = ".mypy_cache" OrElse
                   lowered = ".venv" OrElse
                   lowered = "venv" Then

                    Continue For
                End If

                Me.CopyDirectoryContents(directoryPath, Path.Combine(targetDirectory, name), overwrite)
            Next
        End Sub

        Private Sub NormalizeDirectoryAttributes(ByVal directoryPath As String)

            If directoryPath Is Nothing OrElse directoryPath.Trim().Length = 0 Then
                Return
            End If

            If Not Directory.Exists(directoryPath) Then
                Return
            End If

            Try
                Dim directoryInfo As DirectoryInfo = New DirectoryInfo(directoryPath)
                directoryInfo.Attributes = FileAttributes.Directory

                Dim fileInfos As FileInfo() = directoryInfo.GetFiles("*", SearchOption.AllDirectories)

                For Each fileInfo As FileInfo In fileInfos
                    Try
                        fileInfo.Attributes = FileAttributes.Normal
                    Catch exFile As System.Exception
                    End Try
                Next

                Dim directoryInfos As DirectoryInfo() = directoryInfo.GetDirectories("*", SearchOption.AllDirectories)

                For Each childDirectory As DirectoryInfo In directoryInfos
                    Try
                        childDirectory.Attributes = FileAttributes.Directory
                    Catch exDirectory As System.Exception
                    End Try
                Next

            Catch ex As System.Exception
            End Try
        End Sub

        Private Sub AppendTextElement(ByVal doc As XmlDocument,
                                      ByVal parent As XmlElement,
                                      ByVal name As String,
                                      ByVal value As String)

            Dim child As XmlElement = doc.CreateElement(name)
            child.InnerText = value
            parent.AppendChild(child)
        End Sub

        Private Function XmlEncode(ByVal value As String) As String
            If value Is Nothing Then
                Return ""
            End If

            Dim encoded As String = SecurityElement.Escape(value)

            If encoded Is Nothing Then
                Return ""
            End If

            Return encoded
        End Function

        Private Sub ReportProgress(ByVal messageText As String,
                                   ByVal statusText As String,
                                   ByVal progressValue As Integer)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs(messageText, statusText, progressValue))
        End Sub

    End Class

End Namespace
