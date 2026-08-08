Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000079 RID: 121
	Public Partial Class frmTextEditorFind
		Inherits Form

        Public Enum TextEditorFindAction
            FindNext
            ReplaceNext
            ReplaceAll
            Cancel
        End Enum

        Private _requestedAction As TextEditorFindAction

		' Token: 0x060010D0 RID: 4304 RVA: 0x0029DC80 File Offset: 0x0029CC80
		Public Sub New()
			Me.InitializeComponent()
            Me.RequestedAction = TextEditorFindAction.Cancel
            KotorThemeApplier.ApplyToForm(Me)
		End Sub

        Public Property RequestedAction() As TextEditorFindAction
            Get
                Return Me._requestedAction
            End Get
            Set(ByVal value As TextEditorFindAction)
                Me._requestedAction = value
            End Set
        End Property

        Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
            Me.RequestedAction = TextEditorFindAction.FindNext
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnReplace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReplace.Click
            Me.RequestedAction = TextEditorFindAction.ReplaceNext
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnReplaceAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReplaceAll.Click
            Me.RequestedAction = TextEditorFindAction.ReplaceAll
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
            Me.RequestedAction = TextEditorFindAction.Cancel
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub
    End Class
End Namespace
