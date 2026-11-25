Namespace kotor_tool
    Public Class frmMain
        Public Shared Function GetRsrcTypeForID(value As Integer) As String
            Return "type-" & value.ToString()
        End Function
        Public Shared Function GetIDForRsrcType(value As String) As Short
            Select Case value.ToLowerInvariant()
                Case "bin" : Return 11
                Case "txt" : Return 10
                Case Else : Throw New System.ArgumentException("Unexpected fixture extension.")
            End Select
        End Function
    End Class
End Namespace
