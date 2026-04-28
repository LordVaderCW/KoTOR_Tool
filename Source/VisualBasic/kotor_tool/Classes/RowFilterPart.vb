Imports System
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200008F RID: 143
	Public Class RowFilterPart
		' Token: 0x060017F9 RID: 6137 RVA: 0x002CCFB0 File Offset: 0x002CBFB0
		Public Sub New()
		End Sub

		' Token: 0x060017FA RID: 6138 RVA: 0x002CCFB8 File Offset: 0x002CBFB8
		Public Sub New(nativeColName As String, displayColName As String, matchOper As String, filterText As String, concatOper As String, dataType As String)
			Me.m_nativeColName = nativeColName
			Me.m_displayColName = displayColName
			Me.m_matchOper = matchOper
			Me.m_filterText = filterText
			Me.m_concatOper = concatOper
			Me.m_datatype = dataType
		End Sub

		' Token: 0x17000926 RID: 2342
		' (get) Token: 0x060017FB RID: 6139 RVA: 0x002CCFF0 File Offset: 0x002CBFF0
		' (set) Token: 0x060017FC RID: 6140 RVA: 0x002CD004 File Offset: 0x002CC004
		Public Property nativeColumnName As String
			Get
				Return Me.m_nativeColName
			End Get
			Set(value As String)
				Me.m_nativeColName = value
			End Set
		End Property

		' Token: 0x17000927 RID: 2343
		' (get) Token: 0x060017FD RID: 6141 RVA: 0x002CD010 File Offset: 0x002CC010
		' (set) Token: 0x060017FE RID: 6142 RVA: 0x002CD024 File Offset: 0x002CC024
		Public Property displayColumnName As String
			Get
				Return Me.m_displayColName
			End Get
			Set(value As String)
				Me.m_displayColName = value
			End Set
		End Property

		' Token: 0x17000928 RID: 2344
		' (get) Token: 0x060017FF RID: 6143 RVA: 0x002CD030 File Offset: 0x002CC030
		' (set) Token: 0x06001800 RID: 6144 RVA: 0x002CD044 File Offset: 0x002CC044
		Public Property matchOperator As String
			Get
				Return Me.m_matchOper
			End Get
			Set(value As String)
				Me.m_matchOper = value
			End Set
		End Property

		' Token: 0x17000929 RID: 2345
		' (get) Token: 0x06001801 RID: 6145 RVA: 0x002CD050 File Offset: 0x002CC050
		' (set) Token: 0x06001802 RID: 6146 RVA: 0x002CD064 File Offset: 0x002CC064
		Public Property filterText As String
			Get
				Return Me.m_filterText
			End Get
			Set(value As String)
				Me.m_filterText = value
			End Set
		End Property

		' Token: 0x1700092A RID: 2346
		' (get) Token: 0x06001803 RID: 6147 RVA: 0x002CD070 File Offset: 0x002CC070
		' (set) Token: 0x06001804 RID: 6148 RVA: 0x002CD084 File Offset: 0x002CC084
		Public Property concatOperator As String
			Get
				Return Me.m_concatOper
			End Get
			Set(value As String)
				Me.m_concatOper = value
			End Set
		End Property

		' Token: 0x1700092B RID: 2347
		' (get) Token: 0x06001805 RID: 6149 RVA: 0x002CD090 File Offset: 0x002CC090
		' (set) Token: 0x06001806 RID: 6150 RVA: 0x002CD0A4 File Offset: 0x002CC0A4
		Public Property datatype As String
			Get
				Return Me.m_datatype
			End Get
			Set(value As String)
				Me.m_datatype = value
			End Set
		End Property

		' Token: 0x1700092C RID: 2348
		' (get) Token: 0x06001807 RID: 6151 RVA: 0x002CD0B0 File Offset: 0x002CC0B0
        <XmlIgnore()> _
  Public ReadOnly Property quotedFilterText() As String
            Get
                Return Me.quoteFilterText()
            End Get
        End Property

		' Token: 0x1700092D RID: 2349
		' (get) Token: 0x06001808 RID: 6152 RVA: 0x002CD0C4 File Offset: 0x002CC0C4
        <XmlIgnore()> _
  Public ReadOnly Property filterString() As String
            Get
                Return String.Concat(New String() {Me.m_nativeColName, " ", Me.m_matchOper, " ", Me.quoteFilterText(), " ", Me.m_concatOper})
            End Get
        End Property

		' Token: 0x06001809 RID: 6153 RVA: 0x002CD11C File Offset: 0x002CC11C
		Private Function quoteFilterText() As String
			Dim text As String
			If StringType.StrCmp(Me.m_matchOper, "IN", False) = 0 OrElse StringType.StrCmp(Me.m_matchOper, "NOT IN", False) = 0 OrElse StringType.StrCmp(Me.m_datatype, "Int32", False) = 0 Then
				text = Me.m_filterText
			ElseIf StringType.StrCmp(Me.datatype, "Date", False) = 0 Then
				text = "#" + Me.m_filterText + "#"
			ElseIf StringType.StrCmp(Me.datatype, "String", False) = 0 Then
				text = "'" + Me.m_filterText + "'"
			End If
			Return text
		End Function

		' Token: 0x04000BBC RID: 3004
		Private m_nativeColName As String

		' Token: 0x04000BBD RID: 3005
		Private m_displayColName As String

		' Token: 0x04000BBE RID: 3006
		Private m_filterText As String

		' Token: 0x04000BBF RID: 3007
		Private m_matchOper As String

		' Token: 0x04000BC0 RID: 3008
		Private m_concatOper As String

		' Token: 0x04000BC1 RID: 3009
		Private m_datatype As String
	End Class
End Namespace
