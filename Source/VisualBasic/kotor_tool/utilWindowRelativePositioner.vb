Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000094 RID: 148
	Public Class utilWindowRelativePositioner
		' Token: 0x0600181A RID: 6170 RVA: 0x002CD76C File Offset: 0x002CC76C
		Public Sub New()
		End Sub

		' Token: 0x0600181B RID: 6171 RVA: 0x002CD774 File Offset: 0x002CC774
		Public Sub New(parentForm As Form, childForm As Form)
			Me.pForm = parentForm
			Me.cForm = childForm
		End Sub

		' Token: 0x0600181C RID: 6172 RVA: 0x002CD78C File Offset: 0x002CC78C
		Public Function getConcentric() As Point
			Dim point As Point = Nothing
			Dim size As Size = Me.cForm.Size
			Dim rectangle As Rectangle = Me.pForm.RectangleToScreen(Me.pForm.ClientRectangle)
			Dim workingArea As Rectangle = Screen.GetWorkingArea(Me.pForm)
			point.X = CInt(Math.Round(CDbl((rectangle.Left + rectangle.Right - size.Width)) / 2.0))
			If point.X < workingArea.X Then
				point.X = workingArea.X
			ElseIf point.X + size.Width > workingArea.X + workingArea.Width Then
				point.X = workingArea.X + workingArea.Width - size.Width
			End If
			point.Y = CInt(Math.Round(CDbl((rectangle.Top + rectangle.Bottom - size.Height)) / 2.0))
			If point.Y < workingArea.Y Then
				point.Y = workingArea.Y
			ElseIf point.Y + size.Height > workingArea.Y + workingArea.Height Then
				point.Y = workingArea.Y + workingArea.Height - size.Height
			End If
			Return point
		End Function

		' Token: 0x0600181D RID: 6173 RVA: 0x002CD8EC File Offset: 0x002CC8EC
		Public Sub SetLocationConcentric()
			Me.cForm.Location = Me.getConcentric()
		End Sub

		' Token: 0x04000BC6 RID: 3014
		Private pForm As Form

		' Token: 0x04000BC7 RID: 3015
		Private cForm As Form
	End Class
End Namespace
