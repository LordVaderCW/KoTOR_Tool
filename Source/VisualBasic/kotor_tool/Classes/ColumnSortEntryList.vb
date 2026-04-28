Imports System
Imports System.Collections

Namespace kotor_tool
	' Token: 0x02000039 RID: 57
	Public Class ColumnSortEntryList
		Inherits ColumnEntryList

		' Token: 0x0600015A RID: 346 RVA: 0x00225788 File Offset: 0x00224788
        Public Sub Copy(ByVal theCopy As ColumnSortEntryList)
            Try
                For Each obj As Object In Me
                    Dim columnSortEntry As ColumnSortEntry = CType(obj, ColumnSortEntry)
                    theCopy.Add(New ColumnSortEntry(columnSortEntry.col_name, columnSortEntry.display_name, columnSortEntry.sort_direction))
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub
	End Class
End Namespace
