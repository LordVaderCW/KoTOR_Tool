Imports System

Namespace kotor_tool
	' Token: 0x0200007D RID: 125
	Public Class ComboBoxListItem
		' Token: 0x060012A6 RID: 4774 RVA: 0x002AAE94 File Offset: 0x002A9E94
		Public Sub New()
		End Sub

		' Token: 0x060012A7 RID: 4775 RVA: 0x002AAE9C File Offset: 0x002A9E9C
		Public Sub New(TwoDAIndex As Integer, Text As String, Optional ListBoxName As String = "")
			Me.m_TwoDAIndex = TwoDAIndex
			Me.m_Text = Text
			Me.m_ListBoxName = ListBoxName
		End Sub

		' Token: 0x170006D7 RID: 1751
		' (get) Token: 0x060012A8 RID: 4776 RVA: 0x002AAEBC File Offset: 0x002A9EBC
		Public ReadOnly Property Text As String
			Get
				Return Me.m_Text
			End Get
		End Property

		' Token: 0x170006D8 RID: 1752
		' (get) Token: 0x060012A9 RID: 4777 RVA: 0x002AAED0 File Offset: 0x002A9ED0
		Public ReadOnly Property TwoDAIndex As Integer
			Get
				Return Me.m_TwoDAIndex
			End Get
		End Property

		' Token: 0x170006D9 RID: 1753
		' (get) Token: 0x060012AA RID: 4778 RVA: 0x002AAEE4 File Offset: 0x002A9EE4
		Public ReadOnly Property ListBoxName As String
			Get
				Return Me.m_ListBoxName
			End Get
		End Property

		' Token: 0x040008F6 RID: 2294
		Private m_TwoDAIndex As Integer

		' Token: 0x040008F7 RID: 2295
		Private m_Text As String

		' Token: 0x040008F8 RID: 2296
		Private m_ListBoxName As String
	End Class
End Namespace
