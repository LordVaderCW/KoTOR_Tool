Imports System

Namespace kotor_tool
	' Token: 0x02000035 RID: 53
	Public Class ColumnEntry
		' Token: 0x1700002D RID: 45
		' (get) Token: 0x0600014C RID: 332 RVA: 0x002255A4 File Offset: 0x002245A4
		Public ReadOnly Property nativeColName As String
			Get
				Return Me.col_name
			End Get
		End Property

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x0600014D RID: 333 RVA: 0x002255B8 File Offset: 0x002245B8
		Public ReadOnly Property displayColName As String
			Get
				Return Me.display_name
			End Get
		End Property

		' Token: 0x0600014E RID: 334 RVA: 0x002255CC File Offset: 0x002245CC
		Public Sub New()
		End Sub

		' Token: 0x0600014F RID: 335 RVA: 0x002255D4 File Offset: 0x002245D4
		Public Sub New(NativeColumnName As String, DisplayColumnName As String)
			Me.col_name = NativeColumnName
			Me.display_name = DisplayColumnName
		End Sub

		' Token: 0x06000150 RID: 336 RVA: 0x002255EC File Offset: 0x002245EC
		Public Sub New(NativeColumnName As String, DisplayColumnName As String, DataType As Type)
			Me.New(NativeColumnName, DisplayColumnName)
			Me.data_type = DataType
		End Sub

		' Token: 0x04000118 RID: 280
		Public col_name As String

		' Token: 0x04000119 RID: 281
		Public display_name As String

		' Token: 0x0400011A RID: 282
		Public data_type As Type
	End Class
End Namespace
