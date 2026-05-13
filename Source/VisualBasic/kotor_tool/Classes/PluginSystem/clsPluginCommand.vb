Option Strict Off
Option Explicit On

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsPluginCommand.vb
    '
    ' External command execution settings for the KoTOR Tool Restoration
    ' Project plugin system.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Loaded from each plugin command.ini file.
    '   - Placeholder values are resolved by clsPluginManager before launch.
    ' -----------------------------------------------------------------

    Public Class clsPluginCommand

        Public Executable As String
        Public Arguments As String
        Public WorkingDirectory As String

        Public OutputMode As String
        Public OutputExtension As String

        Public CaptureStdOut As Boolean
        Public CaptureStdErr As Boolean

        Public TimeoutMS As Integer
        Public WaitForExit As Boolean
        Public ShowWindow As Boolean
        Public OverwriteOutput As Boolean

        Public SuccessExitCode As Integer
        Public TreatStdErrAsFailure As Boolean

        Public SectionName As String
        Public Enabled As Boolean
        Public DisabledReason As String

        Public Sub New()
            Me.Executable = ""
            Me.Arguments = ""
            Me.WorkingDirectory = "{plugin_dir}"

            Me.OutputMode = "File"
            Me.OutputExtension = ".txt"

            Me.CaptureStdOut = True
            Me.CaptureStdErr = True

            Me.TimeoutMS = 15000
            Me.WaitForExit = True
            Me.ShowWindow = False
            Me.OverwriteOutput = True

            Me.SuccessExitCode = 0
            Me.TreatStdErrAsFailure = False

            Me.SectionName = "Command"
            Me.Enabled = True
            Me.DisabledReason = ""
        End Sub

        Public Overrides Function ToString() As String
            If Me.Executable Is Nothing Then
                Return ""
            End If

            Return Me.Executable
        End Function

    End Class

End Namespace
