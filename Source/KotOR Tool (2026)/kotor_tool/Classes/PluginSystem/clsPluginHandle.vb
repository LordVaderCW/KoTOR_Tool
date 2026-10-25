Option Strict Off
Option Explicit On

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsPluginHandle.vb
    '
    ' Resource/action handler mapping for the KoTOR Tool Restoration
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
    '   - Represents one plugin capability loaded from plugin.xml.
    '   - Example: extension="ncs", action="decompile".
    '   - CommandSection links a resource/action to a named command.ini
    '     section such as [Command], [InspectMDL], or [ExportMDLToFBX].
    ' -----------------------------------------------------------------

    Public Class clsPluginHandle

        Public Extension As String
        Public Action As String
        Public Description As String
        Public CommandSection As String

        Public Sub New()
            Me.Extension = ""
            Me.Action = ""
            Me.Description = ""
            Me.CommandSection = "Command"
        End Sub

        Public Sub New(ByVal extensionValue As String, ByVal actionValue As String)
            Me.New(extensionValue, actionValue, "", "Command")
        End Sub

        Public Sub New(ByVal extensionValue As String,
                       ByVal actionValue As String,
                       ByVal descriptionValue As String)

            Me.New(extensionValue, actionValue, descriptionValue, "Command")
        End Sub

        Public Sub New(ByVal extensionValue As String,
                       ByVal actionValue As String,
                       ByVal descriptionValue As String,
                       ByVal commandSectionValue As String)

            Me.Extension = clsPluginHandle.NormalizeExtension(extensionValue)
            Me.Action = clsPluginHandle.NormalizeAction(actionValue)

            If descriptionValue Is Nothing Then
                Me.Description = ""
            Else
                Me.Description = descriptionValue.Trim()
            End If

            If commandSectionValue Is Nothing OrElse commandSectionValue.Trim().Length = 0 Then
                Me.CommandSection = "Command"
            Else
                Me.CommandSection = commandSectionValue.Trim()
            End If
        End Sub

        Public Shared Function NormalizeExtension(ByVal extensionValue As String) As String
            If extensionValue Is Nothing Then
                Return ""
            End If

            Dim result As String = extensionValue.Trim().ToLower()

            If result.StartsWith(".") Then
                result = result.Substring(1)
            End If

            Return result
        End Function

        Public Shared Function NormalizeAction(ByVal actionValue As String) As String
            If actionValue Is Nothing Then
                Return ""
            End If

            Return actionValue.Trim().ToLower()
        End Function

        Public Function Matches(ByVal extensionValue As String, ByVal actionValue As String) As Boolean
            Return String.Compare(Me.Extension, clsPluginHandle.NormalizeExtension(extensionValue), True) = 0 AndAlso
                   String.Compare(Me.Action, clsPluginHandle.NormalizeAction(actionValue), True) = 0
        End Function

        Public Overrides Function ToString() As String
            Dim textValue As String = ""

            If Me.Extension Is Nothing OrElse Me.Extension.Trim().Length = 0 Then
                textValue = Me.Action
            ElseIf Me.Action Is Nothing OrElse Me.Action.Trim().Length = 0 Then
                textValue = "." & Me.Extension
            Else
                textValue = "." & Me.Extension & " / " & Me.Action
            End If

            If Me.CommandSection IsNot Nothing AndAlso Me.CommandSection.Trim().Length > 0 AndAlso
               String.Compare(Me.CommandSection.Trim(), "Command", True) <> 0 Then

                textValue &= " -> [" & Me.CommandSection.Trim() & "]"
            End If

            Return textValue
        End Function

    End Class

End Namespace