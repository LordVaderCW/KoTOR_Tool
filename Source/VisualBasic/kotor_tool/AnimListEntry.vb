Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000014 RID: 20
	Public Class AnimListEntry
		' Token: 0x0600005D RID: 93 RVA: 0x0021C1F0 File Offset: 0x0021B1F0
		Public Sub New()
		End Sub

		' Token: 0x0600005E RID: 94 RVA: 0x0021C1F8 File Offset: 0x0021B1F8
		Public Sub New(Participant As String, Animation As Integer)
			Me.m_Participant = Participant
			Me.m_Animation = Animation
		End Sub

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x0600005F RID: 95 RVA: 0x0021C210 File Offset: 0x0021B210
		' (set) Token: 0x06000060 RID: 96 RVA: 0x0021C224 File Offset: 0x0021B224
		Public Property Participant As Object
			Get
				Return Me.m_Participant
			End Get
			Set(value As Object)
				Me.m_Participant = StringType.FromObject(value)
			End Set
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000061 RID: 97 RVA: 0x0021C234 File Offset: 0x0021B234
		' (set) Token: 0x06000062 RID: 98 RVA: 0x0021C24C File Offset: 0x0021B24C
		Public Property Animation As Object
			Get
				Return Me.m_Animation
			End Get
			Set(value As Object)
				Me.m_Animation = IntegerType.FromObject(value)
			End Set
		End Property

		' Token: 0x04000095 RID: 149
		Private m_Participant As String

		' Token: 0x04000096 RID: 150
		Private m_Animation As Integer
	End Class
End Namespace
