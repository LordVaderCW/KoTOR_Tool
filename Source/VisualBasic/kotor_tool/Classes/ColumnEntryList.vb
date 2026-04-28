Imports System
Imports System.Collections
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000038 RID: 56
	Public Class ColumnEntryList
		Inherits ArrayList

		' Token: 0x06000155 RID: 341 RVA: 0x00225638 File Offset: 0x00224638
		Public Sub Copy(theCopy As ColumnEntryList)
			Try
				For Each obj As Object In Me
					Dim columnEntry As ColumnEntry = CType(obj, ColumnEntry)
					theCopy.Add(New ColumnEntry(columnEntry.col_name, columnEntry.display_name))
				Next
			Finally
                Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

        ' Token: 0x06000156 RID: 342 RVA: 0x002256A0 File Offset: 0x002246A0
        Public Shadows Function IndexOf(ByVal searchStr As String, Optional ByVal column As Integer = 1) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.Count - 1

            For i As Integer = num To num2
                Dim columnEntry As ColumnEntry = CType(Me(i), ColumnEntry)

                If column = 1 Then
                    If StringType.StrCmp(Strings.LCase(columnEntry.col_name), Strings.LCase(searchStr), False) = 0 Then
                        Return i
                    End If
                ElseIf column = 2 AndAlso StringType.StrCmp(Strings.LCase(columnEntry.display_name), Strings.LCase(searchStr), False) = 0 Then
                    Return i
                End If
            Next

            Return -1
        End Function

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000157 RID: 343 RVA: 0x00225710 File Offset: 0x00224710
		' (set) Token: 0x06000158 RID: 344 RVA: 0x00225744 File Offset: 0x00224744
		Public Property ColumnVisible(ColumnName As String) As Boolean
			Get
				Return BooleanType.FromObject(LateBinding.LateGet(Me(Me.IndexOf(ColumnName, 1)), Nothing, "visible", New Object(-1) {}, Nothing, Nothing))
			End Get
			Set(value As Boolean)
				LateBinding.LateSetComplex(Me(Me.IndexOf(ColumnName, 1)), Nothing, "visible", New Object() { value }, Nothing, False, True)
			End Set
		End Property

		' Token: 0x0400011E RID: 286
		Public Const NativeColumnName As Integer = 1

		' Token: 0x0400011F RID: 287
		Public Const DisplayColumnName As Integer = 2
	End Class
End Namespace
