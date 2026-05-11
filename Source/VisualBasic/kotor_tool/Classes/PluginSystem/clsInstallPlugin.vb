Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports Microsoft.VisualBasic
Imports System.IO.Compression
Imports System.Collections
Imports System.Diagnostics

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
    ' Patch Notes:
    '   - Preserves the existing DeNCS / NCSDecompCLI install profile.
    '   - Adds a dedicated MDLOps install profile.
    '   - Adds reusable archive extraction dispatch for ZIP, 7Z, and RAR.
    '   - ZIP extraction still routes through the existing internal ZIP path.
    '   - 7Z and RAR extraction use an external extractor where required.
    '   - Does not modify the working DeNCS extraction workflow.
    '
    ' Notes:
    '   - VS2010 compatible VB.NET syntax.
    '   - Uses ZipArchive for ZIP packages, as already implemented.
    '   - 7Z support requires 7z.exe or 7za.exe to be available.
    '   - RAR support prefers 7-Zip, then falls back to UnRAR / WinRAR.
    '   - Plugin-specific install profiles remain intentionally explicit.
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

            If plugin.Id IsNot Nothing AndAlso String.Compare(plugin.Id.Trim(), "mdlops", True) = 0 Then
                Return Me.InstallMDLOps(zipPath, pluginsRoot)
            End If

            If plugin.Name IsNot Nothing AndAlso String.Compare(plugin.Name.Trim(), "MDLOps", True) = 0 Then
                Return Me.InstallMDLOps(zipPath, pluginsRoot)
            End If

            Throw New ApplicationException("No installer profile exists for the selected plugin: " & plugin.ToString())
        End Function

        ' -----------------------------------------------------------------
        ' Install Profiles for Plugins.
        '
        ' Use a custom install profile for unique plugins. This is the best
        ' workflow because it lets each plugin preserve its own package layout,
        ' generated manifest, command.ini structure, and validation rules.
        ' -----------------------------------------------------------------

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

        Public Function InstallMDLOps(ByVal packagePath As String,
                                      ByVal pluginsRoot As String) As String

            If packagePath Is Nothing OrElse packagePath.Trim().Length = 0 Then
                Throw New ArgumentException("packagePath")
            End If

            If Not File.Exists(packagePath) Then
                Throw New FileNotFoundException("Plugin package was not found.", packagePath)
            End If

            If pluginsRoot Is Nothing OrElse pluginsRoot.Trim().Length = 0 Then
                Throw New ArgumentException("pluginsRoot")
            End If

            If Not Directory.Exists(pluginsRoot) Then
                Directory.CreateDirectory(pluginsRoot)
            End If

            Dim tempRoot As String = Path.Combine(Path.GetTempPath(), "KoTORTool_PluginInstall_" & Guid.NewGuid().ToString("N"))
            Dim targetRoot As String = Path.Combine(pluginsRoot, "MDLOps")

            Directory.CreateDirectory(tempRoot)

            Try
                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Extracting MDLOps plugin package...", 60))

                Me.ExtractArchivePackage(packagePath, tempRoot)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Locating MDLOps payload...", 72))

                Dim mdlopsRoot As String = Me.FindFileRoot(tempRoot, "mdlops.exe")

                If mdlopsRoot Is Nothing OrElse Not Directory.Exists(mdlopsRoot) Then
                    Throw New DirectoryNotFoundException("mdlops.exe was not found inside the downloaded MDLOps package.")
                End If

                If Not File.Exists(Path.Combine(mdlopsRoot, "MDLOpsM.pm")) Then
                    Throw New FileNotFoundException("MDLOpsM.pm was not found inside the downloaded MDLOps package.", Path.Combine(mdlopsRoot, "MDLOpsM.pm"))
                End If

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Preparing Plugins\MDLOps directory...", 78))

                If Not Directory.Exists(targetRoot) Then
                    Directory.CreateDirectory(targetRoot)
                End If

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Copying MDLOps files into Plugins\MDLOps...", 84))

                Me.CopyDirectoryContents(mdlopsRoot, targetRoot, True)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Generating MDLOps plugin.xml...", 91))

                Me.WriteMDLOpsPluginXml(targetRoot)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Generating MDLOps command.ini...", 94))

                Me.WriteMDLOpsCommandIni(targetRoot)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Registering installed MDLOps plugin...", 97))

                Me.RegisterInstalledMDLOpsPlugin(pluginsRoot)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Cleaning downloaded package...", 98))

                Me.CleanupDownloadedPackage(packagePath)

                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "MDLOps installation complete.", 100))

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

        Private Sub CleanupDownloadedPackage(ByVal packagePath As String)
            If packagePath Is Nothing OrElse packagePath.Trim().Length = 0 Then
                Return
            End If

            Try
                If File.Exists(packagePath) Then
                    File.SetAttributes(packagePath, FileAttributes.Normal)
                    File.Delete(packagePath)
                End If
            Catch exDelete As System.Exception
            End Try

            Try
                Dim downloadDirectory As String = Path.GetDirectoryName(packagePath)

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

        ' -----------------------------------------------------------------
        ' Generic Archive Extraction
        '
        ' DeNCS still uses ExtractZipWithShell directly.
        ' New install profiles can call ExtractArchivePackage when the package
        ' format may be ZIP, 7Z, or RAR.
        ' -----------------------------------------------------------------

        Private Sub ExtractArchivePackage(ByVal packagePath As String,
                                          ByVal outputDirectory As String)

            Me.ValidateArchivePackageArguments(packagePath, outputDirectory)

            Dim extensionText As String = Path.GetExtension(packagePath).ToLowerInvariant()

            If extensionText = ".zip" Then
                Me.ExtractZipPackage(packagePath, outputDirectory)
                Return
            End If

            If extensionText = ".7z" Then
                Me.Extract7zPackage(packagePath, outputDirectory)
                Return
            End If

            If extensionText = ".rar" Then
                Me.ExtractRarPackage(packagePath, outputDirectory)
                Return
            End If

            Throw New ApplicationException("Unsupported plugin archive format: " & extensionText & ". Supported formats are ZIP, 7Z, and RAR.")
        End Sub

        Private Sub ValidateArchivePackageArguments(ByVal packagePath As String,
                                                    ByVal outputDirectory As String)

            If packagePath Is Nothing OrElse packagePath.Trim().Length = 0 Then
                Throw New ArgumentException("packagePath")
            End If

            If Not File.Exists(packagePath) Then
                Throw New FileNotFoundException("Plugin package was not found.", packagePath)
            End If

            If outputDirectory Is Nothing OrElse outputDirectory.Trim().Length = 0 Then
                Throw New ArgumentException("outputDirectory")
            End If

            If Not Directory.Exists(outputDirectory) Then
                Directory.CreateDirectory(outputDirectory)
            End If
        End Sub

        Private Sub ExtractZipPackage(ByVal packagePath As String,
                                      ByVal outputDirectory As String)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Extracting ZIP archive...", 62))

            Me.ExtractZipWithShell(packagePath, outputDirectory)
            Me.ValidateExtractedPackage(outputDirectory)
        End Sub

        Private Sub Extract7zPackage(ByVal packagePath As String,
                                     ByVal outputDirectory As String)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Locating 7-Zip extractor...", 61))

            Dim sevenZipPath As String = Me.FindSevenZipExtractor()

            If sevenZipPath Is Nothing OrElse sevenZipPath.Trim().Length = 0 Then
                Throw New ApplicationException("7Z plugin package could not be extracted because 7-Zip was not found. Install 7-Zip or place 7z.exe beside KoTOR Tool, in Tools\7z.exe, or in Tools\7zip\7z.exe.")
            End If

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Extracting 7Z archive...", 64))

            Me.RunExternalExtractor(sevenZipPath,
                                    "x -y -bd " & Me.QuoteArgument(packagePath) & " -o" & Me.QuoteArgument(outputDirectory),
                                    "7-Zip")

            Me.ValidateExtractedPackage(outputDirectory)
        End Sub

        Private Sub ExtractRarPackage(ByVal packagePath As String,
                                      ByVal outputDirectory As String)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Locating RAR extractor...", 61))

            Dim sevenZipPath As String = Me.FindSevenZipExtractor()

            If sevenZipPath IsNot Nothing AndAlso sevenZipPath.Trim().Length > 0 Then
                RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Extracting RAR archive with 7-Zip...", 64))

                Me.RunExternalExtractor(sevenZipPath,
                                        "x -y -bd " & Me.QuoteArgument(packagePath) & " -o" & Me.QuoteArgument(outputDirectory),
                                        "7-Zip")

                Me.ValidateExtractedPackage(outputDirectory)
                Return
            End If

            Dim rarExtractorPath As String = Me.FindRarExtractor()

            If rarExtractorPath Is Nothing OrElse rarExtractorPath.Trim().Length = 0 Then
                Throw New ApplicationException("RAR plugin package could not be extracted because 7-Zip, UnRAR, or WinRAR was not found.")
            End If

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs("Installing Plugin", "Extracting RAR archive...", 64))

            Dim extractorName As String = Path.GetFileName(rarExtractorPath).ToLowerInvariant()
            Dim arguments As String

            If extractorName = "unrar.exe" Then
                arguments = "x -y " & Me.QuoteArgument(packagePath) & " " & Me.QuoteArgument(Me.EnsureTrailingDirectorySeparator(outputDirectory))
            Else
                arguments = "x -ibck -o+ " & Me.QuoteArgument(packagePath) & " " & Me.QuoteArgument(Me.EnsureTrailingDirectorySeparator(outputDirectory))
            End If

            Me.RunExternalExtractor(rarExtractorPath, arguments, "RAR extractor")
            Me.ValidateExtractedPackage(outputDirectory)
        End Sub

        Private Function FindSevenZipExtractor() As String
            Dim candidates As ArrayList = New ArrayList()
            Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory

            candidates.Add(Path.Combine(baseDirectory, "7z.exe"))
            candidates.Add(Path.Combine(baseDirectory, "7za.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Tools\7z.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Tools\7za.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Tools\7zip\7z.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Tools\7zip\7za.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Plugins\_Tools\7zip\7z.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Plugins\_Tools\7zip\7za.exe"))

            Me.AddProgramFilesCandidate(candidates, "7-Zip\7z.exe")
            Me.AddProgramFilesCandidate(candidates, "7-Zip\7za.exe")

            Dim pathResult As String = Me.FindExecutableOnPath("7z.exe")

            If pathResult.Length > 0 Then
                candidates.Add(pathResult)
            End If

            pathResult = Me.FindExecutableOnPath("7za.exe")

            If pathResult.Length > 0 Then
                candidates.Add(pathResult)
            End If

            For Each item As Object In candidates
                Dim candidate As String = CStr(item)

                If candidate IsNot Nothing AndAlso candidate.Trim().Length > 0 Then
                    If File.Exists(candidate) Then
                        Return candidate
                    End If
                End If
            Next

            Return ""
        End Function

        Private Function FindRarExtractor() As String
            Dim candidates As ArrayList = New ArrayList()
            Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory

            candidates.Add(Path.Combine(baseDirectory, "unrar.exe"))
            candidates.Add(Path.Combine(baseDirectory, "WinRAR.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Tools\unrar.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Tools\WinRAR.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Tools\rar\unrar.exe"))
            candidates.Add(Path.Combine(baseDirectory, "Tools\rar\WinRAR.exe"))

            Me.AddProgramFilesCandidate(candidates, "WinRAR\UnRAR.exe")
            Me.AddProgramFilesCandidate(candidates, "WinRAR\WinRAR.exe")

            Dim pathResult As String = Me.FindExecutableOnPath("unrar.exe")

            If pathResult.Length > 0 Then
                candidates.Add(pathResult)
            End If

            pathResult = Me.FindExecutableOnPath("WinRAR.exe")

            If pathResult.Length > 0 Then
                candidates.Add(pathResult)
            End If

            For Each item As Object In candidates
                Dim candidate As String = CStr(item)

                If candidate IsNot Nothing AndAlso candidate.Trim().Length > 0 Then
                    If File.Exists(candidate) Then
                        Return candidate
                    End If
                End If
            Next

            Return ""
        End Function

        Private Sub AddProgramFilesCandidate(ByVal candidates As ArrayList,
                                             ByVal relativePath As String)

            Dim programFiles As String = Environment.GetEnvironmentVariable("ProgramFiles")

            If programFiles IsNot Nothing AndAlso programFiles.Trim().Length > 0 Then
                candidates.Add(Path.Combine(programFiles, relativePath))
            End If

            programFiles = Environment.GetEnvironmentVariable("ProgramFiles(x86)")

            If programFiles IsNot Nothing AndAlso programFiles.Trim().Length > 0 Then
                candidates.Add(Path.Combine(programFiles, relativePath))
            End If

            programFiles = Environment.GetEnvironmentVariable("ProgramW6432")

            If programFiles IsNot Nothing AndAlso programFiles.Trim().Length > 0 Then
                candidates.Add(Path.Combine(programFiles, relativePath))
            End If
        End Sub

        Private Function FindExecutableOnPath(ByVal fileName As String) As String
            If fileName Is Nothing OrElse fileName.Trim().Length = 0 Then
                Return ""
            End If

            Dim pathText As String = Environment.GetEnvironmentVariable("PATH")

            If pathText Is Nothing OrElse pathText.Trim().Length = 0 Then
                Return ""
            End If

            Dim pathParts As String() = pathText.Split(";"c)

            For Each pathPart As String In pathParts
                Try
                    If pathPart IsNot Nothing AndAlso pathPart.Trim().Length > 0 Then
                        Dim candidate As String = Path.Combine(pathPart.Trim(), fileName)

                        If File.Exists(candidate) Then
                            Return candidate
                        End If
                    End If
                Catch ex As System.Exception
                End Try
            Next

            Return ""
        End Function

        Private Sub RunExternalExtractor(ByVal extractorPath As String,
                                         ByVal arguments As String,
                                         ByVal extractorName As String)

            If extractorPath Is Nothing OrElse extractorPath.Trim().Length = 0 Then
                Throw New ArgumentException("extractorPath")
            End If

            If Not File.Exists(extractorPath) Then
                Throw New FileNotFoundException("Archive extractor was not found.", extractorPath)
            End If

            Dim processInfo As ProcessStartInfo = New ProcessStartInfo()
            processInfo.FileName = extractorPath
            processInfo.Arguments = arguments
            processInfo.WorkingDirectory = Path.GetDirectoryName(extractorPath)
            processInfo.UseShellExecute = False
            processInfo.CreateNoWindow = True
            processInfo.WindowStyle = ProcessWindowStyle.Hidden
            processInfo.RedirectStandardOutput = False
            processInfo.RedirectStandardError = False

            Dim extractorProcess As Process = Nothing

            Try
                extractorProcess = Process.Start(processInfo)

                If extractorProcess Is Nothing Then
                    Throw New ApplicationException("Could not start " & extractorName & ".")
                End If

                Dim completed As Boolean = extractorProcess.WaitForExit(300000)

                If Not completed Then
                    Try
                        extractorProcess.Kill()
                    Catch exKill As System.Exception
                    End Try

                    Throw New ApplicationException(extractorName & " did not finish within the extraction timeout.")
                End If

                If extractorProcess.ExitCode <> 0 Then
                    Throw New ApplicationException(extractorName & " failed while extracting the plugin archive. Exit code: " & extractorProcess.ExitCode.ToString())
                End If

            Finally
                Try
                    If extractorProcess IsNot Nothing Then
                        extractorProcess.Close()
                    End If
                Catch exClose As System.Exception
                End Try
            End Try
        End Sub

        Private Sub ValidateExtractedPackage(ByVal outputDirectory As String)
            If outputDirectory Is Nothing OrElse outputDirectory.Trim().Length = 0 Then
                Throw New ArgumentException("outputDirectory")
            End If

            If Not Directory.Exists(outputDirectory) Then
                Throw New DirectoryNotFoundException(outputDirectory)
            End If

            Dim files As String() = Directory.GetFiles(outputDirectory, "*", SearchOption.AllDirectories)

            If files Is Nothing OrElse files.Length <= 0 Then
                Throw New ApplicationException("The archive extractor completed, but no files were extracted.")
            End If
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

        Private Function FindFileRoot(ByVal root As String,
                                      ByVal fileName As String) As String

            If root Is Nothing OrElse Not Directory.Exists(root) Then
                Return Nothing
            End If

            If fileName Is Nothing OrElse fileName.Trim().Length = 0 Then
                Return Nothing
            End If

            Dim directPath As String = Path.Combine(root, fileName)

            If File.Exists(directPath) Then
                Return root
            End If

            Dim files As String() = Directory.GetFiles(root, fileName, SearchOption.AllDirectories)

            If files IsNot Nothing AndAlso files.Length > 0 Then
                Return Path.GetDirectoryName(files(0))
            End If

            Return Nothing
        End Function

        Private Function QuoteArgument(ByVal value As String) As String
            If value Is Nothing Then
                Return """"""
            End If

            Return """" & value & """"
        End Function

        Private Function EnsureTrailingDirectorySeparator(ByVal directoryPath As String) As String
            If directoryPath Is Nothing Then
                Return ""
            End If

            If directoryPath.EndsWith(Path.DirectorySeparatorChar.ToString()) Then
                Return directoryPath
            End If

            Return directoryPath & Path.DirectorySeparatorChar
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

        ' -----------------------------------------------------------------
        ' DeNCS Manifest / Command Writers
        ' -----------------------------------------------------------------

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

        ' -----------------------------------------------------------------
        ' MDLOps Manifest / Command Writers
        ' -----------------------------------------------------------------

        Private Sub WriteMDLOpsCommandIni(ByVal pluginDirectory As String)
            Dim commandPath As String = Path.Combine(pluginDirectory, "command.ini")
            Dim builder As New StringBuilder()

            builder.AppendLine("[Command]")
            builder.AppendLine("Executable=mdlops.exe")
            builder.AppendLine("Arguments={extra_args} -k{game_number} ""{input}""")
            builder.AppendLine("WorkingDirectory={plugin_dir}")
            builder.AppendLine("OutputMode=file")
            builder.AppendLine("OutputExtension=mdl")
            builder.AppendLine("CaptureStdOut=True")
            builder.AppendLine("CaptureStdErr=True")
            builder.AppendLine("TimeoutMS=300000")
            builder.AppendLine("ShowWindow=False")
            builder.AppendLine("OverwriteOutput=True")
            builder.AppendLine("SuccessExitCode=0")
            builder.AppendLine("TreatStdErrAsFailure=False")

            File.WriteAllText(commandPath, builder.ToString(), Encoding.UTF8)
        End Sub

        Private Sub WriteMDLOpsPluginXml(ByVal pluginDirectory As String)
            Dim pluginXmlPath As String = Path.Combine(pluginDirectory, "plugin.xml")
            Dim builder As New StringBuilder()

            builder.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
            builder.AppendLine("<Plugin>")
            builder.AppendLine("    <Id>mdlops</Id>")
            builder.AppendLine("    <Name>MDLOps</Name>")
            builder.AppendLine("    <Author>Chuck Chargin Jr. / JdNoa / VP / Fair Strides / ndix UR</Author>")
            builder.AppendLine("    <Version>1.0.2</Version>")
            builder.AppendLine("    <Type>ExternalTool</Type>")
            builder.AppendLine("    <Enabled>True</Enabled>")
            builder.AppendLine("")
            builder.AppendLine("    <Description>")
            builder.AppendLine("        Compiles and decompiles KotOR and TSL MDL/MDX models and supported walkmesh files using MDLOps.")
            builder.AppendLine("    </Description>")
            builder.AppendLine("")
            builder.AppendLine("    <Compatibility>")
            builder.AppendLine("        <Application>KoTOR Tool Restoration Project</Application>")
            builder.AppendLine("        <MinimumAppVersion>1.0.3.3</MinimumAppVersion>")
            builder.AppendLine("        <Framework>NET20</Framework>")
            builder.AppendLine("        <Platform>Windows</Platform>")
            builder.AppendLine("    </Compatibility>")
            builder.AppendLine("")
            builder.AppendLine("    <Project>")
            builder.AppendLine("        <GitHubRepo>https://github.com/ndixUR/mdlops</GitHubRepo>")
            builder.AppendLine("        <GitHubBranch>v1.0.2</GitHubBranch>")
            builder.AppendLine("        <Website>https://github.com/ndixUR/mdlops</Website>")
            builder.AppendLine("        <DownloadUrl>https://github.com/ndixUR/mdlops/releases/download/v1.0.2/mdlops-1.0.2.7z</DownloadUrl>")
            builder.AppendLine("    </Project>")
            builder.AppendLine("")
            builder.AppendLine("    <Layout>")
            builder.AppendLine("        <Folder name=""app"">.</Folder>")
            builder.AppendLine("        <Folder name=""config"">.</Folder>")
            builder.AppendLine("        <Folder name=""runtime"">.</Folder>")
            builder.AppendLine("        <Folder name=""tools"">.</Folder>")
            builder.AppendLine("    </Layout>")
            builder.AppendLine("")
            builder.AppendLine("    <Handles>")
            builder.AppendLine("        <Resource extension=""mdl"" action=""decompile"" description=""Convert binary MDL/MDX model files to ASCII MDL."" />")
            builder.AppendLine("        <Resource extension=""mdl"" action=""compile"" description=""Compile ASCII MDL files back to binary MDL/MDX."" />")
            builder.AppendLine("        <Resource extension=""wok"" action=""decompile"" description=""Convert walkmesh files supported by MDLOps."" />")
            builder.AppendLine("        <Resource extension=""wok"" action=""compile"" description=""Compile walkmesh files supported by MDLOps."" />")
            builder.AppendLine("        <Resource extension=""pwk"" action=""decompile"" description=""Convert placeable walkmesh files supported by MDLOps."" />")
            builder.AppendLine("        <Resource extension=""pwk"" action=""compile"" description=""Compile placeable walkmesh files supported by MDLOps."" />")
            builder.AppendLine("        <Resource extension=""dwk"" action=""decompile"" description=""Convert door walkmesh files supported by MDLOps."" />")
            builder.AppendLine("        <Resource extension=""dwk"" action=""compile"" description=""Compile door walkmesh files supported by MDLOps."" />")
            builder.AppendLine("    </Handles>")
            builder.AppendLine("")
            builder.AppendLine("    <Files>")
            builder.AppendLine("        <File required=""true"">plugin.xml</File>")
            builder.AppendLine("        <File required=""true"">command.ini</File>")
            builder.AppendLine("        <File required=""true"">mdlops.exe</File>")
            builder.AppendLine("        <File required=""true"">defaults.json</File>")
            builder.AppendLine("        <File required=""true"">MDLOpsM.pm</File>")
            builder.AppendLine("        <File required=""true"">LICENSE</File>")
            builder.AppendLine("        <File required=""true"">readme_MDLOps.txt</File>")
            builder.AppendLine("")
            builder.AppendLine("        <File required=""false"">mdlops.pl</File>")
            builder.AppendLine("        <File required=""false"">icon.bmp</File>")
            builder.AppendLine("        <File required=""false"">README.md</File>")
            builder.AppendLine("        <File required=""false"">KotOR_Tutorial.txt</File>")
            builder.AppendLine("        <File required=""false"">Quick_tutorial.txt</File>")
            builder.AppendLine("        <File required=""false"">replacer_tutorial.txt</File>")
            builder.AppendLine("    </Files>")
            builder.AppendLine("")
            builder.AppendLine("    <CommandIni>command.ini</CommandIni>")
            builder.AppendLine("</Plugin>")

            File.WriteAllText(pluginXmlPath, builder.ToString(), Encoding.UTF8)
        End Sub

        Private Sub RegisterInstalledMDLOpsPlugin(ByVal pluginsRoot As String)
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

            Dim existing As XmlNode = root.SelectSingleNode("InstalledPlugin[Id='mdlops']")

            If existing IsNot Nothing Then
                root.RemoveChild(existing)
            End If

            Dim node As XmlElement = doc.CreateElement("InstalledPlugin")
            Me.AppendTextElement(doc, node, "Id", "mdlops")
            Me.AppendTextElement(doc, node, "Name", "MDLOps")
            Me.AppendTextElement(doc, node, "Directory", "MDLOps")
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
