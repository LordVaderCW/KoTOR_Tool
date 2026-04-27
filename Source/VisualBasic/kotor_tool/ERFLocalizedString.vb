Imports System

Namespace kotor_tool
	' Token: 0x02000017 RID: 23
	Public Class ERFLocalizedString
		' Token: 0x0600006B RID: 107 RVA: 0x0021CAD0 File Offset: 0x0021BAD0
		Public Sub New(LanguageID As Integer, StringText As String)
			Me._LanguageID = Me._LanguageID
			Me._StringSize = StringText.Length
			Me._StringText = StringText.ToCharArray()
		End Sub

		' Token: 0x040000A5 RID: 165
		Public _LanguageID As Integer

		' Token: 0x040000A6 RID: 166
		Public _StringSize As Integer

		' Token: 0x040000A7 RID: 167
		Public _StringText As Char()
	End Class
End Namespace
