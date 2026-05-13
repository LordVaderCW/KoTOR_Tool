Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.IO.Compression

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsExtractSourcePlugin.vb
    '
    ' Extracts downloaded source-only plugin archives.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Uses .NET ZIP extraction with a bundled 7-Zip fallback.
    '   - This class only extracts source archives and locates the source root.
    ' -----------------------------------------------------------------

    Public Class clsExtractSourcePlugin

        Public Event ProgressChanged(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)

        Public Function ExtractSource(ByVal context As clsSourcePluginContext) As clsSourcePluginContext

            If context Is Nothing Then
                Throw New ArgumentNullException("context")
            End If

            If context.SourceZipPath Is Nothing OrElse context.SourceZipPath.Trim().Length = 0 Then
                Throw New ArgumentException("context.SourceZipPath")
            End If

            If Not File.Exists(context.SourceZipPath) Then
                Throw New FileNotFoundException("Source plugin archive was not found.", context.SourceZipPath)
            End If

            If context.TempRoot Is Nothing OrElse context.TempRoot.Trim().Length = 0 Then
                Throw New ArgumentException("context.TempRoot")
            End If

            If context.ExtractRoot Is Nothing OrElse context.ExtractRoot.Trim().Length = 0 Then
                context.ExtractRoot = Path.Combine(context.TempRoot, "extract")
            End If

            If Directory.Exists(context.ExtractRoot) Then
                Me.NormalizeDirectoryAttributes(context.ExtractRoot)
                Directory.Delete(context.ExtractRoot, True)
            End If

            Directory.CreateDirectory(context.ExtractRoot)

            Me.ReportProgress("Extracting Source Plugin", "Extracting source archive...", 30)

            Me.ExtractZipArchive(context.SourceZipPath, context.ExtractRoot)

            Me.ReportProgress("Extracting Source Plugin", "Locating source plugin root...", 40)

            context.SourceRoot = Me.FindFileRoot(context.ExtractRoot, "build.bat")

            If context.SourceRoot Is Nothing OrElse Not Directory.Exists(context.SourceRoot) Then
                Throw New DirectoryNotFoundException("build.bat was not found inside the source plugin archive.")
            End If

            context.BuildScriptPath = Path.Combine(context.SourceRoot, "build.bat")
            context.BuildOutputDirectory = Path.Combine(context.SourceRoot, "dist")
            context.BuiltExecutablePath = Path.Combine(context.BuildOutputDirectory, "GhostRigger-K1-K2.exe")

            Me.ValidateGhostRiggerSourceRoot(context)

            Me.ReportProgress("Extracting Source Plugin", "Source archive extracted and validated.", 46)

            Return context
        End Function

        Private Sub ValidateGhostRiggerSourceRoot(ByVal context As clsSourcePluginContext)

            If Not File.Exists(context.BuildScriptPath) Then
                Throw New FileNotFoundException("GhostRigger build.bat was not found.", context.BuildScriptPath)
            End If

            If Not File.Exists(Path.Combine(context.SourceRoot, "main.py")) Then
                Throw New FileNotFoundException("GhostRigger main.py was not found.", Path.Combine(context.SourceRoot, "main.py"))
            End If

            If Not File.Exists(Path.Combine(context.SourceRoot, "requirements.txt")) Then
                Throw New FileNotFoundException("GhostRigger requirements.txt was not found.", Path.Combine(context.SourceRoot, "requirements.txt"))
            End If

        End Sub

        Private Sub ExtractZipArchive(ByVal zipPath As String,
                                      ByVal outputDirectory As String)

            If zipPath Is Nothing OrElse zipPath.Trim().Length = 0 Then
                Throw New ArgumentException("zipPath")
            End If

            If Not File.Exists(zipPath) Then
                Throw New FileNotFoundException("ZIP archive was not found.", zipPath)
            End If

            If outputDirectory Is Nothing OrElse outputDirectory.Trim().Length = 0 Then
                Throw New ArgumentException("outputDirectory")
            End If

            If Not Directory.Exists(outputDirectory) Then
                Directory.CreateDirectory(outputDirectory)
            End If

            Try
                Me.ExtractZipWithCompression(zipPath, outputDirectory)
                Return

            Catch exCompression As System.Exception
                Dim sevenZipPath As String = Me.FindSevenZipExtractor()

                If sevenZipPath Is Nothing OrElse sevenZipPath.Trim().Length = 0 Then
                    Throw New ApplicationException("Source plugin ZIP archive could not be extracted: " & exCompression.Message, exCompression)
                End If

                Me.ReportProgress("Extracting Source Plugin", "Retrying source archive extraction with 7-Zip...", 34)

                Me.RunExternalExtractor(sevenZipPath,
                                        "x -y -bd " & Me.QuoteArgument(zipPath) & " -o" & Me.QuoteArgument(outputDirectory),
                                        "7-Zip")
            End Try

            Me.ValidateExtractedFiles(outputDirectory)
        End Sub

        Private Sub ExtractZipWithCompression(ByVal zipPath As String,
                                              ByVal outputDirectory As String)

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
                        Throw New ApplicationException("Unsafe source zip entry path blocked: " & entry.FullName)
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

                    If extractedCount Mod 50 = 0 Then
                        Me.ReportProgress("Extracting Source Plugin", "Extracted " & extractedCount.ToString() & " source files...", 36)
                    End If
                Next
            End Using

            If extractedCount <= 0 Then
                Throw New ApplicationException("The source plugin ZIP archive did not contain any extractable files.")
            End If
        End Sub

        Private Function IsSafeExtractPath(ByVal rootDirectory As String,
                                           ByVal targetPath As String) As Boolean

            Dim rootFull As String = Path.GetFullPath(rootDirectory)

            If Not rootFull.EndsWith(Path.DirectorySeparatorChar.ToString()) Then
                rootFull &= Path.DirectorySeparatorChar
            End If

            Dim targetFull As String = Path.GetFullPath(targetPath)

            Return targetFull.StartsWith(rootFull, StringComparison.OrdinalIgnoreCase)
        End Function

        Private Sub ValidateExtractedFiles(ByVal outputDirectory As String)
            Dim files As String() = Directory.GetFiles(outputDirectory, "*", SearchOption.AllDirectories)

            If files Is Nothing OrElse files.Length <= 0 Then
                Throw New ApplicationException("The source archive extractor completed, but no files were extracted.")
            End If
        End Sub

        Private Function FindSevenZipExtractor() As String
            Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
            Dim candidates As String() = New String() {
                Path.Combine(baseDirectory, "7z.exe"),
                Path.Combine(baseDirectory, "7za.exe"),
                Path.Combine(baseDirectory, "Tools\7z.exe"),
                Path.Combine(baseDirectory, "Tools\7za.exe"),
                Path.Combine(baseDirectory, "Tools\7Zip\7z.exe"),
                Path.Combine(baseDirectory, "Tools\7Zip\7za.exe"),
                Path.Combine(baseDirectory, "Tools\7zip\7z.exe"),
                Path.Combine(baseDirectory, "Tools\7zip\7za.exe")
            }

            For Each candidate As String In candidates
                If candidate IsNot Nothing AndAlso candidate.Trim().Length > 0 Then
                    If File.Exists(candidate) Then
                        Return candidate
                    End If
                End If
            Next

            Return Me.FindExecutableOnPath("7z.exe")
        End Function

        Private Function FindExecutableOnPath(ByVal fileName As String) As String
            If fileName Is Nothing OrElse fileName.Trim().Length = 0 Then
                Return ""
            End If

            Dim pathText As String = Environment.GetEnvironmentVariable("PATH")

            If pathText Is Nothing OrElse pathText.Trim().Length = 0 Then
                Return ""
            End If

            For Each pathPart As String In pathText.Split(";"c)
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
                    Throw New ApplicationException(extractorName & " failed while extracting the source plugin archive. Exit code: " & extractorProcess.ExitCode.ToString())
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

        Private Function QuoteArgument(ByVal value As String) As String
            If value Is Nothing Then
                Return """"""
            End If

            Return """" & value & """"
        End Function

        Private Function FindFileRoot(ByVal rootDirectory As String,
                                      ByVal fileName As String) As String

            If rootDirectory Is Nothing OrElse rootDirectory.Trim().Length = 0 Then
                Return Nothing
            End If

            If Not Directory.Exists(rootDirectory) Then
                Return Nothing
            End If

            Dim files As String() = Directory.GetFiles(rootDirectory, fileName, SearchOption.AllDirectories)

            If files Is Nothing OrElse files.Length = 0 Then
                Return Nothing
            End If

            Return Path.GetDirectoryName(files(0))
        End Function

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

        Private Sub ReportProgress(ByVal messageText As String,
                                   ByVal statusText As String,
                                   ByVal progressValue As Integer)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs(messageText, statusText, progressValue))
        End Sub

    End Class

End Namespace
