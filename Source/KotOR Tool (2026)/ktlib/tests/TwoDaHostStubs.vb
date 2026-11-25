Namespace kotor_tool
    Public Class clsDialogTlk
        Public Function GetString(reference As Integer) As String
            Return "text:" & reference.ToString(System.Globalization.CultureInfo.InvariantCulture)
        End Function
    End Class
End Namespace
