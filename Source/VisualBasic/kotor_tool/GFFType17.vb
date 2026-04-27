Imports System

Namespace kotor_tool
	' Token: 0x02000022 RID: 34
	Public Class GFFType17
		' Token: 0x060000C3 RID: 195 RVA: 0x002209C0 File Offset: 0x0021F9C0
		Public Sub New()
		End Sub

		' Token: 0x060000C4 RID: 196 RVA: 0x002209C8 File Offset: 0x0021F9C8
		Public Sub New(field1 As Single, field2 As Single, field3 As Single)
			Me.f1 = field1
			Me.f2 = field2
			Me.f3 = field3
		End Sub

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x060000C5 RID: 197 RVA: 0x002209E8 File Offset: 0x0021F9E8
		' (set) Token: 0x060000C6 RID: 198 RVA: 0x002209FC File Offset: 0x0021F9FC
		Public Property X As Single
			Get
				Return Me.f1
			End Get
			Set(value As Single)
				Me.f1 = value
			End Set
		End Property

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x060000C7 RID: 199 RVA: 0x00220A08 File Offset: 0x0021FA08
		' (set) Token: 0x060000C8 RID: 200 RVA: 0x00220A1C File Offset: 0x0021FA1C
		Public Property Y As Single
			Get
				Return Me.f2
			End Get
			Set(value As Single)
				Me.f2 = value
			End Set
		End Property

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x060000C9 RID: 201 RVA: 0x00220A28 File Offset: 0x0021FA28
		' (set) Token: 0x060000CA RID: 202 RVA: 0x00220A3C File Offset: 0x0021FA3C
		Public Property Z As Single
			Get
				Return Me.f3
			End Get
			Set(value As Single)
				Me.f3 = value
			End Set
		End Property

		' Token: 0x040000E4 RID: 228
		Public f1 As Single

		' Token: 0x040000E5 RID: 229
		Public f2 As Single

		' Token: 0x040000E6 RID: 230
		Public f3 As Single
	End Class
End Namespace
