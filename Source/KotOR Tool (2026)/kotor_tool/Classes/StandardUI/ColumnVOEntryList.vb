Imports System
Imports System.Collections

Namespace kotor_tool
	' Token: 0x0200003A RID: 58
	Public Class ColumnVOEntryList
		Inherits ColumnEntryList

		' Token: 0x0600015C RID: 348 RVA: 0x00225800 File Offset: 0x00224800
		Public Overloads Sub Copy(theCopy As ColumnVOEntryList)
				For Each obj As Object In Me
					Dim columnVOEntry As ColumnVOEntry = CType(obj, ColumnVOEntry)
					theCopy.Add(New ColumnVOEntry(columnVOEntry.col_name, columnVOEntry.display_name, columnVOEntry.visible))
				Next
		End Sub
	End Class
End Namespace
