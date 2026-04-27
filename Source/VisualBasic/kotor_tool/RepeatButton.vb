Imports System
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200008E RID: 142
	Public Class RepeatButton
		Inherits Button

		' Token: 0x060017F3 RID: 6131 RVA: 0x002CCEE0 File Offset: 0x002CBEE0
		Public Sub New()
			AddHandler MyBase.MouseUp, AddressOf Me.RepeatButton_MouseUp
			AddHandler MyBase.MouseDown, AddressOf Me.RepeatButton_MouseDown
			Me.Timer = New Timer()
			AddHandler Me.Timer.Tick, AddressOf Me.OnTimer
			Me.Timer.Interval = 200
			Me.Timer.Enabled = False
		End Sub

		' Token: 0x17000925 RID: 2341
		' (get) Token: 0x060017F4 RID: 6132 RVA: 0x002CCF58 File Offset: 0x002CBF58
		' (set) Token: 0x060017F5 RID: 6133 RVA: 0x002CCF70 File Offset: 0x002CBF70
		Public Property Interval As Integer
			Get
				Return Me.Timer.Interval
			End Get
			Set(value As Integer)
				Me.Timer.Interval = value
			End Set
		End Property

		' Token: 0x060017F6 RID: 6134 RVA: 0x002CCF80 File Offset: 0x002CBF80
		Private Sub OnTimer(sender As Object, e As EventArgs)
			Me.OnClick(EventArgs.Empty)
		End Sub

		' Token: 0x060017F7 RID: 6135 RVA: 0x002CCF90 File Offset: 0x002CBF90
		Private Sub RepeatButton_MouseDown(sender As Object, e As MouseEventArgs)
			Me.Timer.Enabled = True
		End Sub

		' Token: 0x060017F8 RID: 6136 RVA: 0x002CCFA0 File Offset: 0x002CBFA0
		Private Sub RepeatButton_MouseUp(sender As Object, e As MouseEventArgs)
			Me.Timer.Enabled = False
		End Sub

		' Token: 0x04000BBB RID: 3003
		Public Timer As Timer
	End Class
End Namespace
