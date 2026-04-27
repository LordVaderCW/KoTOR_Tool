Imports System
Imports System.Runtime.CompilerServices
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000002 RID: 2
	Public Class cls2DA
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000001 RID: 1 RVA: 0x002171A0 File Offset: 0x002161A0
		Public ReadOnly Property RowCount As Integer
			Get
				Return Me.numRows
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000002 RID: 2 RVA: 0x002171B4 File Offset: 0x002161B4
		Public ReadOnly Property RowsUpperBound As Integer
			Get
				' The following expression was wrapped in a checked-expression
				Return Me.numRows - 1
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000003 RID: 3 RVA: 0x002171CC File Offset: 0x002161CC
		Public ReadOnly Property ColumnCount As Integer
			Get
				Return Me.numColumns
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000004 RID: 4 RVA: 0x002171E0 File Offset: 0x002161E0
		Public ReadOnly Property ColumnUpperBound As Integer
			Get
				' The following expression was wrapped in a checked-expression
				Return Me.numColumns - 1
			End Get
		End Property

		' Token: 0x06000005 RID: 5 RVA: 0x002171F8 File Offset: 0x002161F8
		Public Sub New(raw2daData As Byte())
			Me.ary2da = raw2daData
			Me.CreateDataTable()
		End Sub

		' Token: 0x06000006 RID: 6 RVA: 0x00217210 File Offset: 0x00216210
		Public Sub CreateDataTable()
			Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
			Dim num As Integer = 9
			Dim num2 As Integer = Me.ary2da.Length - 1
			Dim i As Integer = num
			While i <= num2 AndAlso Me.ary2da(i) <> 0
				i += 1
			End While
			Dim num3 As Integer = i + 1
			Me.numRows = CInt(Math.Round(CDbl(Me.ary2da(num3)) + CDbl(Me.ary2da(num3 + 1)) * 256.0 + CDbl(Me.ary2da(num3 + 2)) * 65536.0 + CDbl(Me.ary2da(num3 + 3)) * 16777216.0))
			Me.ColNames = Strings.Split(asciiencoding.GetString(Me.ary2da, 9, i - 10), vbTab, -1, CompareMethod.Binary)
			Me.numColumns = Me.ColNames.Length
			Me.ary2daStrings = Array.CreateInstance(GetType(String), Me.numRows, Me.numColumns + 1)
			Dim j As Integer = 0
			Dim num4 As Integer = num3 + 4
			Dim num5 As Integer = Me.ary2da.Length - 1
			i = num4
			While i <= num5
				If Me.ary2da(i) = 9 Then
					j += 1
					If j = Me.numRows Then
						Exit While
					End If
				End If
				i += 1
			End While
			i += 1
			Dim num6 As Integer = i
			Me.RowLabels = Strings.Split(asciiencoding.GetString(Me.ary2da, num3 + 4, i - num3 - 5), vbTab, -1, CompareMethod.Binary)
			Dim num7 As Integer = i + (Me.numRows * Me.numColumns + 1) * 2
			Dim num8 As Integer = 0
			Dim num9 As Integer = Me.numRows - 1
			i = num8
			While i <= num9
				LateBinding.LateIndexSet(Me.ary2daStrings, New Object() { i, 0, Me.RowLabels(i) }, Nothing)
				Dim num10 As Integer = 0
				Dim num11 As Integer = Me.ColNames.Length - 1
				j = num10
				While j <= num11
					Dim num12 As Integer = (j + i * Me.numColumns) * 2 + num6
					Dim num13 As Integer = num7 + CInt(Me.ary2da(num12)) + 256 * CInt(Me.ary2da(num12 + 1))
					Dim num14 As Integer = num13
					Dim num15 As Integer = Me.ary2da.Length - 1
					Dim num16 As Integer = num14
					While num16 <= num15 AndAlso Me.ary2da(num16) <> 0
						num16 += 1
					End While
					Dim text As String
					If num16 > num13 Then
						text = asciiencoding.GetString(Me.ary2da, num13, num16 - num13)
					Else
						text = "****"
					End If
					LateBinding.LateIndexSet(Me.ary2daStrings, New Object() { i, j + 1, text }, Nothing)
					j += 1
				End While
				i += 1
			End While
		End Sub

		' Token: 0x06000007 RID: 7 RVA: 0x002174C8 File Offset: 0x002164C8
		Public Function GetRow(rowNumber As Object) As Array
			' The following expression was wrapped in a checked-statement
			If Me.ary2daStrings IsNot Nothing Then
				Dim array As String() = New String(Me.numColumns + 1 - 1) {}
				Dim num As Integer = 0
				Dim num2 As Integer = Me.numColumns - 1
				For i As Integer = num To num2
					array(i) = StringType.FromObject(LateBinding.LateIndexGet(Me.ary2daStrings, New Object() { RuntimeHelpers.GetObjectValue(rowNumber), i }, Nothing))
				Next
				Return array
			End If
			Dim array2 As Array
			Return array2
		End Function

		' Token: 0x06000008 RID: 8 RVA: 0x00217534 File Offset: 0x00216534
		Public Function GetIndiceData(rowNumber As Integer, colNumber As Integer) As String
			If Me.ary2daStrings IsNot Nothing Then
				Return StringType.FromObject(LateBinding.LateIndexGet(Me.ary2daStrings, New Object() { rowNumber, colNumber }, Nothing))
			End If
			Dim text As String
			Return text
		End Function

		' Token: 0x06000009 RID: 9 RVA: 0x00217578 File Offset: 0x00216578
		Public Function GetIndiceData(rowNumber As Integer, colName As String) As String
			Dim num As Integer = Array.IndexOf(Me.ColNames, colName)
			Dim text As String
			Try
				If Me.ary2daStrings IsNot Nothing AndAlso num <> -1 Then
					' The following expression was wrapped in a checked-expression
					text = StringType.FromObject(LateBinding.LateIndexGet(Me.ary2daStrings, New Object() { rowNumber, num + 1 }, Nothing))
				End If
            Catch ex As System.Exception
                text = "ERROR"
			End Try
			Return text
		End Function

		' Token: 0x0600000A RID: 10 RVA: 0x002175F8 File Offset: 0x002165F8
		Public Function GetIndiceData(rowName As String, colNumber As Integer) As String
			Dim num As Integer = Array.IndexOf(Me.RowLabels, rowName)
			If Me.ary2daStrings IsNot Nothing AndAlso num <> -1 Then
				' The following expression was wrapped in a checked-expression
				Return StringType.FromObject(LateBinding.LateIndexGet(Me.ary2daStrings, New Object() { num + 1, colNumber }, Nothing))
			End If
			Dim text As String
			Return text
		End Function

		' Token: 0x0600000B RID: 11 RVA: 0x00217650 File Offset: 0x00216650
		Public Function GetIndiceData(rowName As String, colName As String) As String
			Dim num As Integer = Array.IndexOf(Me.ColNames, colName)
			Dim num2 As Integer = Array.IndexOf(Me.RowLabels, rowName)
			If Me.ary2daStrings IsNot Nothing AndAlso num <> -1 AndAlso num2 <> -1 Then
				' The following expression was wrapped in a checked-expression
				Return StringType.FromObject(LateBinding.LateIndexGet(Me.ary2daStrings, New Object() { num2 + 1, num + 1 }, Nothing))
			End If
			Dim text As String
			Return text
		End Function

		' Token: 0x04000001 RID: 1
		Protected ary2da As Byte()

		' Token: 0x04000002 RID: 2
		Protected ary2daStrings As Array

		' Token: 0x04000003 RID: 3
		Public RowLabels As String()

		' Token: 0x04000004 RID: 4
		Public ColNames As String()

		' Token: 0x04000005 RID: 5
		Protected numRows As Integer

		' Token: 0x04000006 RID: 6
		Protected numColumns As Integer
	End Class
End Namespace
