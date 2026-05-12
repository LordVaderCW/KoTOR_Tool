Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsNCS.vb
    '
    ' NCS script interface layer for the KoTOR Tool Restoration Project.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Provides the bridge between frmMain resource clicks and the
    '     external plugin system.
    '   - Uses the DeNCS plugin through clsPluginManager.
    '   - Writes the selected NCS resource to the working folder, invokes
    '     the registered NCS decompile plugin, then opens the generated NSS
    '     source in frmTextEditor.
    ' -----------------------------------------------------------------

    Public Class clsNCS

        Private Const NCS_EXTENSION As String = "ncs"
        Private Const DECOMPILE_ACTION As String = "decompile"

        Public Shared Function DecompileAndOpen(ByVal owner As Form,
                                                ByVal ncsBytes As Byte(),
                                                ByVal filename As String,
                                                ByVal resref As String,
                                                ByVal kotorVersionIndex As Integer) As Boolean

            Dim progress As frmProgressMeter = Nothing

            Try
                If ncsBytes Is Nothing OrElse ncsBytes.Length = 0 Then
                    Interaction.MsgBox(
                        "The selected NCS resource contains no data.",
                        MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly,
                        "NCS Decompiler"
                    )
                    Return False
                End If

                Dim cleanFileName As String = clsNCS.GetSafeFileName(filename, "script.ncs")
                Dim baseName As String = Path.GetFileNameWithoutExtension(cleanFileName)

                If resref Is Nothing OrElse resref.Trim().Length = 0 Then
                    resref = baseName
                End If

                Dim gameNumber As Integer = clsNCS.NormalizeGameNumber(kotorVersionIndex)
                Dim workingDirectory As String = clsNCS.GetNCSWorkingDirectory()
                Dim inputPath As String = Path.Combine(workingDirectory, baseName & ".ncs")
                Dim outputPath As String = Path.Combine(workingDirectory, "decomp_" & baseName & ".nss")

                progress = clsNCS.CreateProgress(owner, "Decompiling NCS script", "Preparing NCS decompile workspace")
                clsNCS.StepProgress(progress, "Creating NCS working directory")

                If Not Directory.Exists(workingDirectory) Then
                    Directory.CreateDirectory(workingDirectory)
                End If

                clsNCS.StepProgress(progress, "Writing temporary NCS file")
                frmMain.WriteByteArray(inputPath, ncsBytes)

                clsNCS.StepProgress(progress, "Checking installed NCS decompiler plugin")

                Dim pluginManager As clsPluginManager = New clsPluginManager()
                pluginManager.LoadPlugins()

                Dim plugin As clsPluginDefinition = pluginManager.FindPluginForResource(NCS_EXTENSION, DECOMPILE_ACTION)

                If plugin Is Nothing Then
                    clsNCS.CloseProgress(progress)
                    progress = Nothing

                    Interaction.MsgBox(
                        "No installed plugin is registered for NCS decompilation." & vbCrLf & vbCrLf &
                        "Expected plugin handle:" & vbCrLf &
                        ".ncs / decompile" & vbCrLf & vbCrLf &
                        "Check Plugins\InstalledPlugins.xml and the DeNCS plugin.xml manifest.",
                        MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly,
                        "NCS Decompiler"
                    )

                    Return False
                End If

                Dim missingFiles As System.Collections.ArrayList = pluginManager.GetMissingRequiredFiles(plugin)

                If missingFiles IsNot Nothing AndAlso missingFiles.Count > 0 Then
                    clsNCS.CloseProgress(progress)
                    progress = Nothing

                    Interaction.MsgBox(
                        "The NCS decompiler plugin is installed but incomplete." & vbCrLf & vbCrLf &
                        "Plugin:" & vbCrLf &
                        plugin.Name & vbCrLf & vbCrLf &
                        "Missing required file(s):" & vbCrLf &
                        clsNCS.JoinArrayList(missingFiles, vbCrLf),
                        MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly,
                        "NCS Decompiler"
                    )

                    Return False
                End If

                If File.Exists(outputPath) Then
                    File.Delete(outputPath)
                End If

                clsNCS.StepProgress(progress, "Running " & plugin.Name & " for KoTOR game index " & gameNumber.ToString())

                Dim result As clsPluginExecutionResult = pluginManager.ExecutePlugin(
                    plugin,
                    inputPath,
                    outputPath,
                    gameNumber,
                    cleanFileName,
                    resref,
                    NCS_EXTENSION,
                    DECOMPILE_ACTION
                )

                If result Is Nothing OrElse Not result.Success Then
                    clsNCS.CloseProgress(progress)
                    progress = Nothing

                    clsNCS.ShowPluginFailure(result, plugin, inputPath, outputPath)
                    Return False
                End If

                clsNCS.StepProgress(progress, "Opening decompiled NSS source")

                If Not File.Exists(outputPath) Then
                    clsNCS.CloseProgress(progress)
                    progress = Nothing

                    Interaction.MsgBox(
                        "The NCS decompiler reported success, but the expected NSS output file was not found." & vbCrLf & vbCrLf &
                        outputPath,
                        MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly,
                        "NCS Decompiler"
                    )

                    Return False
                End If

                Dim sourceText As String = clsNCS.ReadTextFile(outputPath)
                Dim editor As frmTextEditor = New frmTextEditor(cleanFileName, False, "")

                editor.Filename = Path.GetFileName(outputPath)
                editor.Text = "NCS Decompiled Source - " & Path.GetFileName(outputPath)
                editor.tbGeneric.Text = sourceText
                editor.tbGeneric.SelectionLength = 0
                editor.KotorVersionIndex = gameNumber

                ' Do not call PrepareForScriptEditing() here. This is not required, as we are not editing scripts,
                ' So it should not be looking or try to look for the override folders etc. 
                ' Decompiled NCS viewing should not require nwscript.nss from the game Override folder.
                ' The DeNCS plugin already used its own nwscript file from Plugins\DeNCS\tools.

                editor.Show()

                clsNCS.StepProgress(progress, "NCS decompile complete")
                clsNCS.CloseProgress(progress)
                progress = Nothing

                Return True

            Catch ex As System.Exception
                clsNCS.CloseProgress(progress)
                progress = Nothing

                Interaction.MsgBox(
                    "NCS decompile failed." & vbCrLf & vbCrLf &
                    "Error:" & vbCrLf &
                    ex.Message,
                    MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly,
                    "NCS Decompiler"
                )

                Return False
            End Try
        End Function

        Private Shared Function GetNCSWorkingDirectory() As String
            Dim rootWorkingDirectory As String = ""

            Try
                rootWorkingDirectory = frmMain.GetWorkingDirectoryPath()
            Catch ex As System.Exception
                rootWorkingDirectory = Path.Combine(Application.StartupPath, "working")
            End Try

            If rootWorkingDirectory Is Nothing OrElse rootWorkingDirectory.Trim().Length = 0 Then
                rootWorkingDirectory = Path.Combine(Application.StartupPath, "working")
            End If

            Return Path.Combine(rootWorkingDirectory, "NCSDecompile")
        End Function

        Private Shared Function NormalizeGameNumber(ByVal kotorVersionIndex As Integer) As Integer
            If kotorVersionIndex = 1 OrElse kotorVersionIndex = 2 Then
                Return 2
            End If

            Return 1
        End Function

        Private Shared Function GetSafeFileName(ByVal filename As String, ByVal fallbackFileName As String) As String
            Dim result As String = ""

            If filename Is Nothing OrElse filename.Trim().Length = 0 Then
                result = fallbackFileName
            Else
                result = Path.GetFileName(filename.Trim())
            End If

            If result Is Nothing OrElse result.Trim().Length = 0 Then
                result = fallbackFileName
            End If

            If Path.GetExtension(result).Trim().Length = 0 Then
                result &= ".ncs"
            End If

            For Each invalidChar As Char In Path.GetInvalidFileNameChars()
                result = result.Replace(invalidChar, "_"c)
            Next

            Return result
        End Function

        Private Shared Function ReadTextFile(ByVal filePath As String) As String
            Try
                Return File.ReadAllText(filePath, Encoding.GetEncoding(1252))
            Catch ex As System.Exception
                Return File.ReadAllText(filePath, Encoding.ASCII)
            End Try
        End Function

        Private Shared Function CreateProgress(ByVal owner As Form, ByVal messageText As String, ByVal statusText As String) As frmProgressMeter
            Dim progress As frmProgressMeter = New frmProgressMeter()

            progress.stepAmount = 1
            progress.maxvalue = 6
            progress.message = messageText
            progress.status = statusText

            If owner IsNot Nothing Then
                Try
                    progress.Location = New utilWindowRelativePositioner(owner, progress).getConcentric()
                Catch ex As System.Exception
                    progress.StartPosition = FormStartPosition.CenterScreen
                End Try
            Else
                progress.StartPosition = FormStartPosition.CenterScreen
            End If

            progress.Show()
            Application.DoEvents()

            Return progress
        End Function

        Private Shared Sub StepProgress(ByVal progress As frmProgressMeter, ByVal statusText As String)
            If progress Is Nothing Then
                Return
            End If

            Try
                progress.status = statusText
                progress.stepUp()
                Application.DoEvents()
            Catch ex As System.Exception
            End Try
        End Sub

        Private Shared Sub CloseProgress(ByVal progress As frmProgressMeter)
            If progress Is Nothing Then
                Return
            End If

            Try
                progress.Close()
            Catch ex As System.Exception
            End Try
        End Sub

        Private Shared Sub ShowPluginFailure(ByVal result As clsPluginExecutionResult,
                                            ByVal plugin As clsPluginDefinition,
                                            ByVal inputPath As String,
                                            ByVal outputPath As String)

            Dim builder As StringBuilder = New StringBuilder()

            builder.AppendLine("The NCS decompiler plugin failed.")
            builder.AppendLine("")

            If plugin IsNot Nothing Then
                builder.AppendLine("Plugin:")
                builder.AppendLine(plugin.Name)
                builder.AppendLine("")
            End If

            builder.AppendLine("Input:")
            builder.AppendLine(inputPath)
            builder.AppendLine("")
            builder.AppendLine("Expected Output:")
            builder.AppendLine(outputPath)
            builder.AppendLine("")

            If result IsNot Nothing Then
                If result.ErrorMessage IsNot Nothing AndAlso result.ErrorMessage.Trim().Length > 0 Then
                    builder.AppendLine("Error:")
                    builder.AppendLine(result.ErrorMessage)
                    builder.AppendLine("")
                End If

                builder.AppendLine("Executable:")
                builder.AppendLine(result.ExecutablePath)
                builder.AppendLine("")
                builder.AppendLine("Arguments:")
                builder.AppendLine(result.Arguments)
                builder.AppendLine("")
                builder.AppendLine("Working Directory:")
                builder.AppendLine(result.WorkingDirectory)
                builder.AppendLine("")

                If result.StandardOutput IsNot Nothing AndAlso result.StandardOutput.Trim().Length > 0 Then
                    builder.AppendLine("Standard Output:")
                    builder.AppendLine(result.StandardOutput)
                    builder.AppendLine("")
                End If

                If result.StandardError IsNot Nothing AndAlso result.StandardError.Trim().Length > 0 Then
                    builder.AppendLine("Standard Error:")
                    builder.AppendLine(result.StandardError)
                    builder.AppendLine("")
                End If
            Else
                builder.AppendLine("No execution result was returned by the plugin manager.")
            End If

            Interaction.MsgBox(
                builder.ToString(),
                MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly,
                "NCS Decompiler"
            )
        End Sub

        Private Shared Function JoinArrayList(ByVal list As System.Collections.ArrayList, ByVal separator As String) As String
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

End Namespace
