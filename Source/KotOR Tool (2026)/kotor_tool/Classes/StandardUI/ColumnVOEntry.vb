Imports System

Namespace kotor_tool
	' Token: 0x02000036 RID: 54
	Public Class ColumnVOEntry
		Inherits ColumnEntry

		' Token: 0x06000151 RID: 337 RVA: 0x00225600 File Offset: 0x00224600
		Public Sub New()
		End Sub

		' Token: 0x06000152 RID: 338 RVA: 0x00225608 File Offset: 0x00224608
		Public Sub New(NativeColumnName As String, DisplayColumnName As String, vis As Boolean)
			MyBase.New(NativeColumnName, DisplayColumnName)
			Me.visible = vis
		End Sub

		' Token: 0x0400011B RID: 283
		Public display_index As Integer

		' Token: 0x0400011C RID: 284
		Public visible As Boolean
	End Class
End Namespace
