Imports System

Namespace kotor_tool
	' Token: 0x02000004 RID: 4
	Public Class TreeBaseItem
		' Token: 0x0600000F RID: 15 RVA: 0x00217824 File Offset: 0x00216824
		Public Sub New(index As Integer, itemtype As String, label As String, name As String, slots As String)
			Me._index = index
			Me._itemtype = itemtype
			Me._label = label
			Me._name = name
			Me._slots = slots
		End Sub

		' Token: 0x04000007 RID: 7
		Public _itemtype As String

		' Token: 0x04000008 RID: 8
		Public _label As String

		' Token: 0x04000009 RID: 9
		Public _name As String

		' Token: 0x0400000A RID: 10
		Public _slots As String

		' Token: 0x0400000B RID: 11
		Public _index As Integer
	End Class
End Namespace
