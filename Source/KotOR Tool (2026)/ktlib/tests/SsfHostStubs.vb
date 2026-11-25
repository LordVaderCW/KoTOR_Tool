' Isolated host substitutes: no registry, settings files, game data, UI or audio.
Namespace kotor_tool
    Public Class Options
        Public KotorLocation As String() = {"fixture-k1", "fixture-k2"}
    End Class
    Public Class UserSettings
        Public Shared Function GetSettings() As Options
            Return New Options()
        End Function
    End Class
    Public Class clsDialogTlk
        Public Sub New(Optional path As String = Nothing, Optional memoryResident As Boolean = False)
        End Sub
        Public Function GetString(value As Integer) As String
            Return "text:" & value.ToString()
        End Function
        Public Function GetSoundResRef(value As Integer) As String
            Return "sound:" & value.ToString()
        End Function
    End Class
End Namespace
