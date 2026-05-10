Imports System

Namespace kotor_tool
	' Token: 0x0200001F RID: 31
	Public Class GFFExoLocString
		' Token: 0x060000B6 RID: 182 RVA: 0x00220870 File Offset: 0x0021F870
		Public Sub New()
		End Sub

		' Token: 0x060000B7 RID: 183 RVA: 0x00220878 File Offset: 0x0021F878
		Public Sub New(Text As String, Optional LanguageID As Integer = 0)
			If Text Is Nothing OrElse Text.Length = 0 Then
				Me.StringCount = 0
				Me.StringRef = -1
			Else
				Me.StringCount = 1
				Me.StringRef = -1
				Me.subStringArr = CType(Array.CreateInstance(GetType(Object), 1), Object())
				Dim gffexoLocSubString As GFFExoLocSubString = New GFFExoLocSubString()
				gffexoLocSubString.StringID = LanguageID
				gffexoLocSubString.StringLength = Text.Length
				gffexoLocSubString.value = Text
				Me.subStringArr(0) = gffexoLocSubString
				Me.size = 16 + Text.Length
			End If
		End Sub

		' Token: 0x040000D9 RID: 217
		Public size As Integer

		' Token: 0x040000DA RID: 218
		Public StringRef As Integer

		' Token: 0x040000DB RID: 219
		Public StringCount As Integer

		' Token: 0x040000DC RID: 220
		Public subStringArr As Object()
	End Class
End Namespace
