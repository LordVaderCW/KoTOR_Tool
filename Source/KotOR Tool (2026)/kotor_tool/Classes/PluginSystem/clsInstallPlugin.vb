Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports Microsoft.VisualBasic
Imports System.IO.Compression

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsInstallPlugin.vb
    '
    ' Installs downloaded external tool plugin packages into the KoTOR
    ' Tool Restoration Project Plugins directory.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Uses Windows Shell zip extraction for broad legacy compatibility.
    '   - The first supported install profile is DeNCS / NCSDecompCLI.
    '   - Copies only the contents of the extracted NCSDecompCLI folder into
    '     Plugins\DeNCS, then writes plugin.xml and command.ini.
    ' -----------------------------------------------------------------

    Public Class clsInstallPlugin

        Public Event ProgressChanged(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)

        Public Function InstallPlugin(ByVal plugin As clsPluginDefinition,
                                      ByVal zipPath As String,
                                      ByVal pluginsRoot As String) As String

            If plugin Is Nothing Then
                Throw New ArgumentNullException("plugin")
            End If

            If plugin.Id IsNot Nothing AndAlso String.Compare(plugin.Id.Trim(), "ncsdecomp", True) = 0 Then
                Return Me.InstallDeNCS(zipPath, pluginsRoot)
            End If

            If plugin.Name IsNot Nothing AndAlso String.Compare(plugin.Name.Trim(), "DeNCS", True) = 0 Then
                Return Me.InstallDeNCS(zipPath, pluginsRoot)
            End If

            Throw New ApplicationException("No installer profile exists for the selected plugin: " & plugin.ToString())
        End Function

        Public Function InstallDeNCS(ByVal zipPath As String,
                                     ByVal pluginsRoot As String) As String

            If zipPath Is Nothing OrElse zipPath.Trim().Length = 0 Then
                Throw New ArgumentException("zipPath")
            End If

            If Not File.Exists(zipPath) Then
                Throw New FileNotFoundException("Plugin package was not found.", zipPath)
            End If

            If pluginsRoot Is Nothing OrElse pluginsRoot.Trim().Length = 0 Then
                Throw New ArgumentException("pluginsRoot")
            End If

            If Not Directory.Exists(pluginsRoot) Then
                Directory.CreateDirectory(pluginsRoot)
            End If

            Dim tempRoot As String = Path.Combine(Path.GetTempPath(), "KoTORTool_PluginInstall_" & Guid.NewGuid().ToString("N"))
            Dim targetRoot As String = Path.Combine(pluginsRoot, "DeNCS")

            Directory.CreateDirectory(tempRoot)

            Try
                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Extracting plugin package...", 60))

                Me.ExtractZipWithShell(zipPath, tempRoot)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Locating NCSDecompCLI payload...", 70))

                Dim cliRoot As String = Me.FindDirectory(tempRoot, "NCSDecompCLI")

                If cliRoot Is Nothing OrElse Not Directory.Exists(cliRoot) Then
                    Throw New DirectoryNotFoundException("The NCSDecompCLI folder was not found inside the downloaded package.")
                End If

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Preparing Plugins\DeNCS directory...", 75))

                If Not Directory.Exists(targetRoot) Then
                    Directory.CreateDirectory(targetRoot)
                End If

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Copying plugin files into Plugins\DeNCS...", 82))

                Me.CopyDirectoryContents(cliRoot, targetRoot, True)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Generating plugin.xml...", 90))

                Me.WritePluginXml(targetRoot)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Generating command.ini...", 93))

                Me.WriteCommandIni(targetRoot)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Registering installed plugin...", 96))

                Me.RegisterInstalledPlugin(pluginsRoot)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Cleaning downloaded package...", 98))

                Me.CleanupDownloadedPackage(zipPath)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Installation complete.", 100))

                Return targetRoot

            Finally
                Try
                    If Directory.Exists(tempRoot) Then
                        Directory.Delete(tempRoot, True)
                    End If
                Catch exCleanup As System.Exception
                End Try
            End Try
        End Function

        Private Sub CleanupDownloadedPackage(ByVal zipPath As String)
            If zipPath Is Nothing OrElse zipPath.Trim().Length = 0 Then
                Return
            End If

            Try
                If File.Exists(zipPath) Then
                    File.SetAttributes(zipPath, FileAttributes.Normal)
                    File.Delete(zipPath)
                End If
            Catch exDelete As System.Exception
            End Try

            Try
                Dim downloadDirectory As String = Path.GetDirectoryName(zipPath)

                If downloadDirectory Is Nothing OrElse downloadDirectory.Trim().Length = 0 Then
                    Return
                End If

                If String.Compare(Path.GetFileName(downloadDirectory), "_Downloads", True) <> 0 Then
                    Return
                End If

                If Directory.Exists(downloadDirectory) Then
                    If Directory.GetFiles(downloadDirectory, "*", SearchOption.AllDirectories).Length = 0 AndAlso
               Directory.GetDirectories(downloadDirectory, "*", SearchOption.AllDirectories).Length = 0 Then

                        Directory.Delete(downloadDirectory, False)
                    End If
                End If

            Catch exDirectory As System.Exception
            End Try
        End Sub

        Private Sub ExtractZipWithShell(ByVal zipPath As String, ByVal outputDirectory As String)
            Me.ExtractZipWithCompression(zipPath, outputDirectory)
        End Sub

        Private Sub ExtractZipWithCompression(ByVal zipPath As String, ByVal outputDirectory As String)
            If zipPath Is Nothing OrElse zipPath.Trim().Length = 0 Then
                Throw New ArgumentException("zipPath")
            End If

            If Not File.Exists(zipPath) Then
                Throw New FileNotFoundException("Plugin zip package was not found.", zipPath)
            End If

            If outputDirectory Is Nothing OrElse outputDirectory.Trim().Length = 0 Then
                Throw New ArgumentException("outputDirectory")
            End If

            If Not Directory.Exists(outputDirectory) Then
                Directory.CreateDirectory(outputDirectory)
            End If

            Dim extractedCount As Integer = 0

            Using archive As ZipArchive = ZipFile.OpenRead(zipPath)
                For Each entry As ZipArchiveEntry In archive.Entries
                    If entry Is Nothing OrElse entry.FullName Is Nothing Then
                        Continue For
                    End If

                    Dim relativePath As String = entry.FullName.Replace("/"c, Path.DirectorySeparatorChar)

                    If relativePath.Trim().Length = 0 Then
                        Continue For
                    End If

                    Dim targetPath As String = Path.Combine(outputDirectory, relativePath)

                    If Not Me.IsSafeExtractPath(outputDirectory, targetPath) Then
                        Throw New ApplicationException("Unsafe zip entry path blocked: " & entry.FullName)
                    End If

                    If entry.FullName.EndsWith("/") OrElse entry.FullName.EndsWith("\") Then
                        If Not Directory.Exists(targetPath) Then
                            Directory.CreateDirectory(targetPath)
                        End If
                        Continue For
                    End If

                    Dim targetDirectory As String = Path.GetDirectoryName(targetPath)

                    If targetDirectory IsNot Nothing AndAlso targetDirectory.Trim().Length > 0 Then
                        If Not Directory.Exists(targetDirectory) Then
                            Directory.CreateDirectory(targetDirectory)
                        End If
                    End If

                    entry.ExtractToFile(targetPath, True)
                    extractedCount += 1

                    If extractedCount Mod 25 = 0 Then
                        RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Extracted " & extractedCount.ToString() & " files...", 65))
                    End If
                Next
            End Using

            If extractedCount <= 0 Then
                Throw New ApplicationException("The plugin package did not contain any extractable files.")
            End If
        End Sub

        Private Function IsSafeExtractPath(ByVal rootDirectory As String, ByVal targetPath As String) As Boolean
            Dim rootFull As String = Path.GetFullPath(rootDirectory)

            If Not rootFull.EndsWith(Path.DirectorySeparatorChar.ToString()) Then
                rootFull &= Path.DirectorySeparatorChar
            End If

            Dim targetFull As String = Path.GetFullPath(targetPath)

            Return targetFull.StartsWith(rootFull, StringComparison.OrdinalIgnoreCase)
        End Function

        Private Function FindDirectory(ByVal root As String, ByVal directoryName As String) As String
            If root Is Nothing OrElse Not Directory.Exists(root) Then
                Return Nothing
            End If

            If String.Compare(Path.GetFileName(root), directoryName, True) = 0 Then
                Return root
            End If

            For Each dir As String In Directory.GetDirectories(root, "*", SearchOption.AllDirectories)
                If String.Compare(Path.GetFileName(dir), directoryName, True) = 0 Then
                    Return dir
                End If
            Next

            Return Nothing
        End Function

        Private Sub CopyDirectoryContents(ByVal sourceDirectory As String,
                                          ByVal targetDirectory As String,
                                          ByVal overwrite As Boolean)

            If Not Directory.Exists(sourceDirectory) Then
                Throw New DirectoryNotFoundException(sourceDirectory)
            End If

            If Not Directory.Exists(targetDirectory) Then
                Directory.CreateDirectory(targetDirectory)
            End If

            For Each sourceFile As String In Directory.GetFiles(sourceDirectory)
                Dim targetFile As String = Path.Combine(targetDirectory, Path.GetFileName(sourceFile))
                File.Copy(sourceFile, targetFile, overwrite)
            Next

            For Each sourceSubDirectory As String In Directory.GetDirectories(sourceDirectory)
                Dim targetSubDirectory As String = Path.Combine(targetDirectory, Path.GetFileName(sourceSubDirectory))
                Me.CopyDirectoryContents(sourceSubDirectory, targetSubDirectory, overwrite)
            Next
        End Sub

        Private Sub WriteCommandIni(ByVal pluginDirectory As String)
            Dim commandPath As String = Path.Combine(pluginDirectory, "command.ini")
            Dim builder As New StringBuilder()

            builder.AppendLine("[Command]")
            builder.AppendLine("Executable=NCSDecompCLI.exe")
            builder.AppendLine("Arguments=-g {game_name} -i ""{input}"" -o ""{output}""")
            builder.AppendLine("WorkingDirectory={plugin_dir}")
            builder.AppendLine("OutputMode=file")
            builder.AppendLine("OutputExtension=nss")
            builder.AppendLine("CaptureStdOut=True")
            builder.AppendLine("CaptureStdErr=True")
            builder.AppendLine("TimeoutMS=120000")
            builder.AppendLine("ShowWindow=False")
            builder.AppendLine("OverwriteOutput=True")
            builder.AppendLine("SuccessExitCode=0")
            builder.AppendLine("TreatStdErrAsFailure=False")

            File.WriteAllText(commandPath, builder.ToString(), Encoding.UTF8)
        End Sub

        Private Sub WritePluginXml(ByVal pluginDirectory As String)
            Dim pluginXmlPath As String = Path.Combine(pluginDirectory, "plugin.xml")
            Dim xml As String = "<?xml version=""1.0"" encoding=""utf-8""?>" & vbCrLf &
"<Plugin>" & vbCrLf &
"    <Id>ncsdecomp</Id>" & vbCrLf &
"    <Name>DeNCS</Name>" & vbCrLf &
"    <Author>JdNoa / Dashus / th3w1zard1</Author>" & vbCrLf &
"    <Version>1.0.2</Version>" & vbCrLf &
"    <Type>ExternalTool</Type>" & vbCrLf &
"    <Enabled>True</Enabled>" & vbCrLf & vbCrLf &
"    <Description>Decompiles compiled KotOR NCS scripts into readable NSS source using NCSDecompCLI.</Description>" & vbCrLf & vbCrLf &
"    <Compatibility>" & vbCrLf &
"        <Application>KoTOR Tool Restoration Project</Application>" & vbCrLf &
"        <MinimumAppVersion>1.0.3.3</MinimumAppVersion>" & vbCrLf &
"        <Framework>NET20</Framework>" & vbCrLf &
"        <Platform>Windows</Platform>" & vbCrLf &
"    </Compatibility>" & vbCrLf & vbCrLf &
"    <Project>" & vbCrLf &
"        <GitHubRepo>https://github.com/OpenKotOR/DeNCS</GitHubRepo>" & vbCrLf &
"        <GitHubBranch>v1.0.2</GitHubBranch>" & vbCrLf &
"        <Website>https://github.com/OpenKotOR/DeNCS</Website>" & vbCrLf &
"        <DownloadUrl>https://github.com/OpenKotOR/DeNCS/releases/download/v1.0.2/DeNCS-v1.0.2-Windows.zip</DownloadUrl>" & vbCrLf &
"    </Project>" & vbCrLf & vbCrLf &
"    <Layout>" & vbCrLf &
"        <Folder name=""app"">app</Folder>" & vbCrLf &
"        <Folder name=""config"">config</Folder>" & vbCrLf &
"        <Folder name=""runtime"">runtime</Folder>" & vbCrLf &
"        <Folder name=""tools"">tools</Folder>" & vbCrLf &
"    </Layout>" & vbCrLf & vbCrLf &
"    <Handles>" & vbCrLf &
"        <Resource extension=""ncs"" action=""decompile"" />" & vbCrLf &
"    </Handles>" & vbCrLf & vbCrLf &
"    <Files>" & vbCrLf &
"        <File required=""true"">plugin.xml</File>" & vbCrLf &
"        <File required=""true"">command.ini</File>" & vbCrLf &
"        <File required=""true"">NCSDecompCLI.exe</File>" & vbCrLf & vbCrLf &
"        <File required=""true"">tools\k1_nwscript.nss</File>" & vbCrLf &
"        <File required=""true"">tools\tsl_nwscript.nss</File>" & vbCrLf &
"        <File required=""true"">tools\nwnnsscomp_kscript.exe</File>" & vbCrLf &
"        <File required=""true"">tools\nwnnsscomp_ktool.exe</File>" & vbCrLf & vbCrLf &
"        <File required=""false"">NCSDecompCLI.jar</File>" & vbCrLf &
"    </Files>" & vbCrLf & vbCrLf &
"    <CommandIni>command.ini</CommandIni>" & vbCrLf &
"</Plugin>"

            File.WriteAllText(pluginXmlPath, xml, Encoding.UTF8)
        End Sub

        Private Sub RegisterInstalledPlugin(ByVal pluginsRoot As String)
            Dim registryPath As String = Path.Combine(pluginsRoot, "InstalledPlugins.xml")
            Dim doc As New XmlDocument()

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

            Dim existing As XmlNode = root.SelectSingleNode("InstalledPlugin[Id='ncsdecomp']")

            If existing IsNot Nothing Then
                root.RemoveChild(existing)
            End If

            Dim node As XmlElement = doc.CreateElement("InstalledPlugin")
            Me.AppendTextElement(doc, node, "Id", "ncsdecomp")
            Me.AppendTextElement(doc, node, "Name", "DeNCS")
            Me.AppendTextElement(doc, node, "Directory", "DeNCS")
            Me.AppendTextElement(doc, node, "Enabled", "True")
            Me.AppendTextElement(doc, node, "Manifest", "plugin.xml")
            Me.AppendTextElement(doc, node, "InstalledVersion", "1.0.2")

            root.AppendChild(node)
            doc.Save(registryPath)
        End Sub

        Private Sub AppendTextElement(ByVal doc As XmlDocument,
                                      ByVal parent As XmlElement,
                                      ByVal name As String,
                                      ByVal value As String)

            Dim child As XmlElement = doc.CreateElement(name)
            child.InnerText = value
            parent.AppendChild(child)
        End Sub

    End Class

End Namespace
