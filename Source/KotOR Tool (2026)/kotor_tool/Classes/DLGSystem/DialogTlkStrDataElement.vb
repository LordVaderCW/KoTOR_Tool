Imports System

Namespace kotor_tool
	' Token: 0x02000011 RID: 17
	Public Class DialogTlkStrDataElement
		' Token: 0x06000040 RID: 64 RVA: 0x0021A710 File Offset: 0x00219710
		Public Sub New()
			Me.Text = ""
			Me.SoundResRef = ""
			Me.SoundLength = 0F
		End Sub

		' Token: 0x06000041 RID: 65 RVA: 0x0021A73C File Offset: 0x0021973C
		Public Sub New(EntryFlags As Integer, EntryText As String, EntrySoundResRef As String, Optional EntrySoundLength As Single = 0F)
			Me.Text = ""
			Me.SoundResRef = ""
			Me.SoundLength = 0F
			Me.Flags = EntryFlags
			Me.Text = EntryText
			Me.SoundResRef = EntrySoundResRef
			Me.SoundLength = EntrySoundLength
		End Sub

		' Token: 0x04000065 RID: 101
		Public Flags As Integer

		' Token: 0x04000066 RID: 102
		Public Text As String

		' Token: 0x04000067 RID: 103
		Public SoundResRef As String

		' Token: 0x04000068 RID: 104
		Public SoundLength As Single
	End Class
End Namespace
