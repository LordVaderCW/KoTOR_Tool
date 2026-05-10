Imports System

Namespace kotor_tool
	' Token: 0x02000021 RID: 33
	Public Class GFFType16
		' Token: 0x060000B9 RID: 185 RVA: 0x00220910 File Offset: 0x0021F910
		Public Sub New()
		End Sub

		' Token: 0x060000BA RID: 186 RVA: 0x00220918 File Offset: 0x0021F918
		Public Sub New(field1 As Single, field2 As Single, field3 As Single, field4 As Single)
			Me.f1 = field1
			Me.f2 = field2
			Me.f3 = field3
			Me.f4 = field4
		End Sub

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x060000BB RID: 187 RVA: 0x00220940 File Offset: 0x0021F940
		' (set) Token: 0x060000BC RID: 188 RVA: 0x00220954 File Offset: 0x0021F954
		Public Property W As Single
			Get
				Return Me.f1
			End Get
			Set(value As Single)
				Me.f1 = value
			End Set
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x060000BD RID: 189 RVA: 0x00220960 File Offset: 0x0021F960
		' (set) Token: 0x060000BE RID: 190 RVA: 0x00220974 File Offset: 0x0021F974
		Public Property X As Single
			Get
				Return Me.f2
			End Get
			Set(value As Single)
				Me.f2 = value
			End Set
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x060000BF RID: 191 RVA: 0x00220980 File Offset: 0x0021F980
		' (set) Token: 0x060000C0 RID: 192 RVA: 0x00220994 File Offset: 0x0021F994
		Public Property Y As Single
			Get
				Return Me.f3
			End Get
			Set(value As Single)
				Me.f3 = value
			End Set
		End Property

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x060000C1 RID: 193 RVA: 0x002209A0 File Offset: 0x0021F9A0
		' (set) Token: 0x060000C2 RID: 194 RVA: 0x002209B4 File Offset: 0x0021F9B4
		Public Property Z As Single
			Get
				Return Me.f4
			End Get
			Set(value As Single)
				Me.f4 = value
			End Set
		End Property

		' Token: 0x040000E0 RID: 224
		Public f1 As Single

		' Token: 0x040000E1 RID: 225
		Public f2 As Single

		' Token: 0x040000E2 RID: 226
		Public f3 As Single

		' Token: 0x040000E3 RID: 227
		Public f4 As Single
	End Class
End Namespace
