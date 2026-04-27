Imports System
Imports System.Collections
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000003 RID: 3
	Public Class clsBaseItems2DA
		Inherits cls2DA

		' Token: 0x0600000C RID: 12 RVA: 0x002176B8 File Offset: 0x002166B8
		Public Sub New(raw2daData As Byte())
			MyBase.New(raw2daData)
		End Sub

		' Token: 0x0600000D RID: 13 RVA: 0x002176C4 File Offset: 0x002166C4
		Public Sub printItemNamesAndTypes(dialogtlk As clsDialogTlk)
			Dim num As Integer = 0
			Dim rowsUpperBound As Integer = Me.RowsUpperBound
			For i As Integer = num To rowsUpperBound
				Dim obj As Object = Me.GetIndiceData(i, "name")
				If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = dialogtlk.GetString(IntegerType.FromObject(obj))
				Else
					obj = "****"
				End If
				Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(Me.GetIndiceData(i, "itemtype") + "," + Me.GetIndiceData(i, "label") + ",", obj), ","), Me.GetIndiceData(i, "equipableslots")))
			Next
		End Sub

		' Token: 0x0600000E RID: 14 RVA: 0x00217770 File Offset: 0x00216770
		Public Function GetItemNamesAndTypesList(dialogtlk As clsDialogTlk) As ArrayList
			Dim arrayList As ArrayList = New ArrayList()
			Dim num As Integer = 0
			Dim rowsUpperBound As Integer = Me.RowsUpperBound
			For i As Integer = num To rowsUpperBound
				Dim obj As Object = Me.GetIndiceData(i, "name")
				If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = dialogtlk.GetString(IntegerType.FromObject(obj))
				Else
					obj = "(" + Me.GetIndiceData(i, "label") + ")"
				End If
				arrayList.Add(New TreeBaseItem(i, Me.GetIndiceData(i, "itemtype"), Me.GetIndiceData(i, "label"), StringType.FromObject(obj), Me.GetIndiceData(i, "equipableslots")))
			Next
			Return arrayList
		End Function
	End Class
End Namespace
