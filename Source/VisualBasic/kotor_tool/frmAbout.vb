Imports System
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace kotor_tool

    Partial Public Class frmAbout
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Dim linkLabel As LinkLabel = TryCast(sender, LinkLabel)

            If linkLabel Is Nothing Then
                Return
            End If

            If linkLabel.Text Is Nothing OrElse linkLabel.Text.Trim().Length = 0 Then
                Return
            End If

            Process.Start(linkLabel.Text)
        End Sub

    End Class

End Namespace