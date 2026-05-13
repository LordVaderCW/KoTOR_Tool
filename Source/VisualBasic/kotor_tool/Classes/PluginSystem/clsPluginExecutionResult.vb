Option Strict Off
Option Explicit On

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsPluginExecutionResult.vb
    '
    ' Result object returned after executing a plugin command.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Used by clsPluginManager to return structured execution data.
    ' -----------------------------------------------------------------

    Public Class clsPluginExecutionResult

        Public Success As Boolean
        Public TimedOut As Boolean
        Public ExitCode As Integer

        Public PluginId As String
        Public PluginName As String
        Public Action As String
        Public Extension As String

        Public StandardOutput As String
        Public StandardError As String

        Public InputPath As String
        Public OutputPath As String

        Public ExecutablePath As String
        Public Arguments As String
        Public WorkingDirectory As String

        Public ErrorMessage As String
        Public DiagnosticMessage As String


        Public CommandSection As String
        Public OutputMode As String
        Public OutputCreated As Boolean
        Public CommandDisabled As Boolean
        Public DisabledReason As String


        Public Sub New()
            Me.Success = False
            Me.TimedOut = False
            Me.ExitCode = -1

            Me.PluginId = ""
            Me.PluginName = ""
            Me.Action = ""
            Me.Extension = ""

            Me.StandardOutput = ""
            Me.StandardError = ""

            Me.InputPath = ""
            Me.OutputPath = ""

            Me.ExecutablePath = ""
            Me.Arguments = ""
            Me.WorkingDirectory = ""

            Me.ErrorMessage = ""
            Me.DiagnosticMessage = ""

            Me.CommandSection = "Command"
            Me.OutputMode = ""
            Me.OutputCreated = False
            Me.CommandDisabled = False
            Me.DisabledReason = ""
        End Sub

        Public Overrides Function ToString() As String
            If Me.Success Then
                Return "Success"
            End If

            If Me.CommandDisabled Then
                If Me.DisabledReason IsNot Nothing AndAlso Me.DisabledReason.Trim().Length > 0 Then
                    Return Me.DisabledReason
                End If

                Return "Command Disabled"
            End If

            If Me.TimedOut Then
                Return "Timed Out"
            End If

            If Me.ErrorMessage IsNot Nothing AndAlso Me.ErrorMessage.Trim().Length > 0 Then
                Return Me.ErrorMessage
            End If

            Return "Failed"
        End Function

    End Class

End Namespace