' The original entry constructor asks the UI for a display extension.
' Keep that lookup outside the codec; this host never loads a form or game data.
Namespace kotor_tool
    Public Class frmMain
        Public Shared Function GetRsrcTypeForID(value As Integer) As String
            Return "type-" & value.ToString()
        End Function
    End Class
End Namespace
