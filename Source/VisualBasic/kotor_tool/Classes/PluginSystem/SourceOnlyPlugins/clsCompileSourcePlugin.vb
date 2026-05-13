Option Strict Off
Option Explicit On

Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.Win32

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsCompileSourcePlugin.vb
    '
    ' Compiles extracted source-only plugins.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - This class only runs the source build process.
    '   - For GhostRigger, this runs build.bat and validates
    '     dist\GhostRigger-K1-K2.exe.
    ' -----------------------------------------------------------------

    Public Class clsCompileSourcePlugin

        Public Event ProgressChanged(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)

        Private Const BuildTimeoutMS As Integer = 1800000
        Private _buildConsoleLogPath As String = ""

        Public Function CompileSource(ByVal context As clsSourcePluginContext) As clsSourcePluginContext

            If context Is Nothing Then
                Throw New ArgumentNullException("context")
            End If

            If context.SourceRoot Is Nothing OrElse context.SourceRoot.Trim().Length = 0 Then
                Throw New ArgumentException("context.SourceRoot")
            End If

            If Not Directory.Exists(context.SourceRoot) Then
                Throw New DirectoryNotFoundException("Source root was not found: " & context.SourceRoot)
            End If

            If context.BuildScriptPath Is Nothing OrElse context.BuildScriptPath.Trim().Length = 0 Then
                context.BuildScriptPath = Path.Combine(context.SourceRoot, "build.bat")
            End If

            If Not File.Exists(context.BuildScriptPath) Then
                Throw New FileNotFoundException("Source plugin build script was not found.", context.BuildScriptPath)
            End If

            If context.BuildOutputDirectory Is Nothing OrElse context.BuildOutputDirectory.Trim().Length = 0 Then
                context.BuildOutputDirectory = Path.Combine(context.SourceRoot, "dist")
            End If

            If context.BuiltExecutablePath Is Nothing OrElse context.BuiltExecutablePath.Trim().Length = 0 Then
                context.BuiltExecutablePath = Path.Combine(context.BuildOutputDirectory, "GhostRigger-K1-K2.exe")
            End If

            Me.ReportProgress("Compiling Source Plugin", "Running GhostRigger build.bat...", 50)

            Me.PrepareBuildScriptPythonRuntime(context)

            Me.RunBuildScript(context)

            Me.ReportProgress("Compiling Source Plugin", "Validating compiled GhostRigger executable...", 72)

            Dim resolvedExecutablePath As String = Me.ResolveBuiltExecutablePath(context)

            If resolvedExecutablePath Is Nothing OrElse resolvedExecutablePath.Trim().Length = 0 Then
                Throw New FileNotFoundException("GhostRigger build completed, but GhostRigger-K1-K2.exe was not found in dist, the source build folder, or Plugins\GhostRigger. Temporary build folder was preserved: " & context.SourceRoot, context.BuiltExecutablePath)
            End If

            context.BuiltExecutablePath = resolvedExecutablePath

            Me.ReportProgress("Compiling Source Plugin", "Source plugin compilation complete.", 75)

            Return context
        End Function

        Private Sub RunBuildScript(ByVal context As clsSourcePluginContext)

            Dim consoleLogPath As String = Path.Combine(context.SourceRoot, "KoTORTool_BuildConsole.log")

            Me.DeleteIfExists(consoleLogPath)
            Me._buildConsoleLogPath = consoleLogPath

            Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
            startInfo.FileName = "cmd.exe"
            startInfo.Arguments = "/c call ""build.bat"" < nul"
            startInfo.WorkingDirectory = context.SourceRoot
            startInfo.UseShellExecute = False
            startInfo.CreateNoWindow = True
            startInfo.RedirectStandardOutput = True
            startInfo.RedirectStandardError = True

            Dim process As Process = New Process()
            process.StartInfo = startInfo
            AddHandler process.OutputDataReceived, AddressOf Me.BuildOutputDataReceived
            AddHandler process.ErrorDataReceived, AddressOf Me.BuildOutputDataReceived

            Try
                process.Start()
                process.BeginOutputReadLine()
                process.BeginErrorReadLine()

                If Not process.WaitForExit(BuildTimeoutMS) Then
                    Try
                        process.Kill()
                    Catch exKill As System.Exception
                    End Try

                    Throw New ApplicationException("GhostRigger build timed out. Check KoTORTool_BuildConsole.log and build_log.txt.")
                End If

                If process.ExitCode <> 0 Then
                    Dim messageText As String = "GhostRigger build.bat failed with exit code " & process.ExitCode.ToString() & "."

                    Dim buildLogPath As String = Path.Combine(context.SourceRoot, "build_log.txt")

                    If File.Exists(buildLogPath) Then
                        messageText &= vbCrLf & vbCrLf & Me.ReadTail(buildLogPath, 7000)
                    ElseIf File.Exists(consoleLogPath) Then
                        messageText &= vbCrLf & vbCrLf & Me.ReadTail(consoleLogPath, 7000)
                    End If

                    Throw New ApplicationException(messageText)
                End If

            Finally
                Try
                    RemoveHandler process.OutputDataReceived, AddressOf Me.BuildOutputDataReceived
                    RemoveHandler process.ErrorDataReceived, AddressOf Me.BuildOutputDataReceived
                Catch exHandler As System.Exception
                End Try

                Try
                    process.Close()
                    process.Dispose()
                Catch exDispose As System.Exception
                End Try
            End Try
        End Sub

        Private Sub BuildOutputDataReceived(ByVal sender As Object,
                                            ByVal e As DataReceivedEventArgs)

            If e Is Nothing OrElse e.Data Is Nothing Then
                Return
            End If

            Dim lineText As String = e.Data.Trim()

            If lineText.Length = 0 Then
                Return
            End If

            Try
                If Me._buildConsoleLogPath IsNot Nothing AndAlso Me._buildConsoleLogPath.Trim().Length > 0 Then
                    File.AppendAllText(Me._buildConsoleLogPath, lineText & Environment.NewLine, Encoding.UTF8)
                End If
            Catch exLog As System.Exception
            End Try

            If Not Me.ShouldReportBuildOutputLine(lineText) Then
                Return
            End If

            Me.ReportProgress("Compiling Source Plugin", lineText, Me.MapBuildOutputProgress(lineText))
        End Sub

        Private Function ShouldReportBuildOutputLine(ByVal lineText As String) As Boolean
            Dim normalized As String = lineText.ToLowerInvariant()

            If normalized.StartsWith("[step ") Then
                Return True
            End If

            If normalized.StartsWith("installing ") Then
                Return True
            End If

            If normalized.IndexOf("[ok]") >= 0 OrElse normalized.IndexOf("[warn]") >= 0 OrElse normalized.IndexOf("error:") >= 0 Then
                Return True
            End If

            If normalized.IndexOf("python ") = 0 OrElse normalized.IndexOf("running pyinstaller") >= 0 OrElse normalized.IndexOf("build complete") >= 0 Then
                Return True
            End If

            Return False
        End Function

        Private Function MapBuildOutputProgress(ByVal lineText As String) As Integer
            Dim normalized As String = lineText.ToLowerInvariant()

            If normalized.IndexOf("step 2/6") >= 0 Then
                Return 44
            End If

            If normalized.IndexOf("step 3/6") >= 0 OrElse normalized.StartsWith("installing ") Then
                Return 50
            End If

            If normalized.IndexOf("step 4/6") >= 0 Then
                Return 60
            End If

            If normalized.IndexOf("step 5/6") >= 0 Then
                Return 66
            End If

            If normalized.IndexOf("step 6/6") >= 0 OrElse normalized.IndexOf("running pyinstaller") >= 0 Then
                Return 69
            End If

            If normalized.IndexOf("build complete") >= 0 Then
                Return 71
            End If

            Return 50
        End Function

        Private Function ResolveBuiltExecutablePath(ByVal context As clsSourcePluginContext) As String
            Dim executableName As String = "GhostRigger-K1-K2.exe"

            If context.BuiltExecutablePath IsNot Nothing AndAlso context.BuiltExecutablePath.Trim().Length > 0 Then
                If File.Exists(context.BuiltExecutablePath) Then
                    Return context.BuiltExecutablePath
                End If
            End If

            Dim foundPath As String = Me.FindExecutableByName(context.BuildOutputDirectory, executableName)

            If foundPath.Length > 0 Then
                Return foundPath
            End If

            foundPath = Me.FindExecutableByName(context.SourceRoot, executableName)

            If foundPath.Length > 0 Then
                Return foundPath
            End If

            foundPath = Me.FindExecutableByName(context.InstallDirectory, executableName)

            If foundPath.Length > 0 Then
                Return Me.PromoteInstalledExecutableToSource(context, foundPath)
            End If

            Return ""
        End Function

        Private Function FindExecutableByName(ByVal rootDirectory As String,
                                              ByVal executableName As String) As String

            If rootDirectory Is Nothing OrElse rootDirectory.Trim().Length = 0 Then
                Return ""
            End If

            If Not Directory.Exists(rootDirectory) Then
                Return ""
            End If

            Dim directPath As String = Path.Combine(rootDirectory, executableName)

            If File.Exists(directPath) Then
                Return directPath
            End If

            Try
                Dim exactMatches As String() = Directory.GetFiles(rootDirectory, executableName, SearchOption.AllDirectories)

                If exactMatches IsNot Nothing AndAlso exactMatches.Length > 0 Then
                    Return exactMatches(0)
                End If

                Dim exeMatches As String() = Directory.GetFiles(rootDirectory, "*.exe", SearchOption.AllDirectories)

                For Each exePath As String In exeMatches
                    Dim name As String = Path.GetFileNameWithoutExtension(exePath)

                    If name IsNot Nothing AndAlso name.ToLowerInvariant().IndexOf("ghostrigger") >= 0 Then
                        Return exePath
                    End If
                Next

            Catch ex As System.Exception
            End Try

            Return ""
        End Function

        Private Function PromoteInstalledExecutableToSource(ByVal context As clsSourcePluginContext,
                                                           ByVal installedExecutablePath As String) As String

            If installedExecutablePath Is Nothing OrElse Not File.Exists(installedExecutablePath) Then
                Return ""
            End If

            Dim promotedPath As String = Path.Combine(context.SourceRoot, "GhostRigger-K1-K2.exe")

            Try
                File.Copy(installedExecutablePath, promotedPath, True)
                Return promotedPath
            Catch ex As System.Exception
                Return installedExecutablePath
            End Try
        End Function

        Private Sub PrepareBuildScriptPythonRuntime(ByVal context As clsSourcePluginContext)
            Dim pythonPath As String = Me.FindPythonRuntime()

            If pythonPath Is Nothing OrElse pythonPath.Trim().Length = 0 Then
                Return
            End If

            Dim shimPath As String = Path.Combine(context.SourceRoot, "py.cmd")

            Try
                If File.Exists(shimPath) Then
                    File.SetAttributes(shimPath, FileAttributes.Normal)
                    File.Delete(shimPath)
                End If
            Catch exShim As System.Exception
            End Try

            If context.BuildScriptPath Is Nothing OrElse Not File.Exists(context.BuildScriptPath) Then
                Return
            End If

            Dim buildScriptText As String = File.ReadAllText(context.BuildScriptPath)
            Dim pythonCommand As String = """" & pythonPath & """"

            buildScriptText = buildScriptText.Replace("py -3.12", pythonCommand)
            buildScriptText = buildScriptText.Replace("py -3.13", pythonCommand)

            File.WriteAllText(context.BuildScriptPath, buildScriptText)
        End Sub

        Private Function FindPythonRuntime() As String
            Dim candidates As ArrayList = New ArrayList()
            Dim pythonEnvironment As String = Environment.GetEnvironmentVariable("PYTHON")

            If pythonEnvironment IsNot Nothing AndAlso pythonEnvironment.Trim().Length > 0 Then
                candidates.Add(pythonEnvironment.Trim())
            End If

            Me.AddPathCandidates(candidates, Environment.GetEnvironmentVariable("PATH"))

            Try
                Me.AddPathCandidates(candidates, Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User))
            Catch exUserPath As System.Exception
            End Try

            Try
                Me.AddPathCandidates(candidates, Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine))
            Catch exMachinePath As System.Exception
            End Try

            Me.AddKnownPythonCandidates(candidates)
            Me.AddPythonAppPathCandidates(candidates)

            For Each item As Object In candidates
                Dim candidate As String = CStr(item)

                If candidate IsNot Nothing AndAlso candidate.Trim().Length > 0 Then
                    candidate = Environment.ExpandEnvironmentVariables(candidate.Trim())

                    If Directory.Exists(candidate) Then
                        candidate = Path.Combine(candidate, "python.exe")
                    End If

                    If File.Exists(candidate) Then
                        Return candidate
                    End If
                End If
            Next

            Return ""
        End Function

        Private Sub AddPathCandidates(ByVal candidates As ArrayList,
                                      ByVal pathText As String)

            If pathText Is Nothing OrElse pathText.Trim().Length = 0 Then
                Return
            End If

            For Each pathPart As String In pathText.Split(";"c)
                Try
                    If pathPart IsNot Nothing AndAlso pathPart.Trim().Length > 0 Then
                        candidates.Add(Path.Combine(pathPart.Trim(), "python.exe"))
                    End If
                Catch ex As System.Exception
                End Try
            Next
        End Sub

        Private Sub AddKnownPythonCandidates(ByVal candidates As ArrayList)
            Dim localAppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

            If localAppData IsNot Nothing AndAlso localAppData.Trim().Length > 0 Then
                candidates.Add(Path.Combine(localAppData, "Programs\Python\Python313\python.exe"))
                candidates.Add(Path.Combine(localAppData, "Programs\Python\Python312\python.exe"))
                candidates.Add(Path.Combine(localAppData, "Programs\Python\Python311\python.exe"))
            End If

            Me.AddProgramFilesPythonCandidate(candidates, "Python313\python.exe")
            Me.AddProgramFilesPythonCandidate(candidates, "Python312\python.exe")
            Me.AddProgramFilesPythonCandidate(candidates, "Python311\python.exe")
        End Sub

        Private Sub AddProgramFilesPythonCandidate(ByVal candidates As ArrayList,
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

        Private Sub AddPythonAppPathCandidates(ByVal candidates As ArrayList)
            Me.AddPythonAppPathCandidate(candidates, Registry.CurrentUser)
            Me.AddPythonAppPathCandidate(candidates, Registry.LocalMachine)
        End Sub

        Private Sub AddPythonAppPathCandidate(ByVal candidates As ArrayList,
                                              ByVal baseKey As RegistryKey)

            Try
                Using key As RegistryKey = baseKey.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\App Paths\python.exe")
                    If key IsNot Nothing Then
                        Dim value As Object = key.GetValue("")

                        If value IsNot Nothing Then
                            candidates.Add(CStr(value))
                        End If
                    End If
                End Using
            Catch ex As System.Exception
            End Try
        End Sub

        Private Function ReadTail(ByVal filePath As String,
                                  ByVal maxCharacters As Integer) As String

            If Not File.Exists(filePath) Then
                Return ""
            End If

            Dim text As String = File.ReadAllText(filePath)

            If text.Length <= maxCharacters Then
                Return text
            End If

            Return text.Substring(text.Length - maxCharacters)
        End Function

        Private Sub DeleteIfExists(ByVal filePath As String)

            If filePath Is Nothing OrElse filePath.Trim().Length = 0 Then
                Return
            End If

            If File.Exists(filePath) Then
                File.SetAttributes(filePath, FileAttributes.Normal)
                File.Delete(filePath)
            End If
        End Sub

        Private Sub ReportProgress(ByVal messageText As String,
                                   ByVal statusText As String,
                                   ByVal progressValue As Integer)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs(messageText, statusText, progressValue))
        End Sub

    End Class

End Namespace
