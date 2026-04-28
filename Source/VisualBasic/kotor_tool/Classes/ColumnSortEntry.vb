Imports System

Namespace kotor_tool
	' Token: 0x02000037 RID: 55
	Public Class ColumnSortEntry
		Inherits ColumnEntry

		' Token: 0x06000153 RID: 339 RVA: 0x0022561C File Offset: 0x0022461C
		Public Sub New(NativeColumnName As String, DisplayColumnName As String, dir As String)
			MyBase.New(NativeColumnName, DisplayColumnName)
			Me.sort_direction = dir
		End Sub

		' Token: 0x0400011D RID: 285
		Public sort_direction As String
	End Class
End Namespace
