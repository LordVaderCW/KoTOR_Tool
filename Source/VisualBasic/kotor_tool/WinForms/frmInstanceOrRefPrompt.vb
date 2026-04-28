Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool

    Partial Public Class frmInstanceOrRefPrompt
        Inherits Form

        Private _itemclass As String = String.Empty

        Public Sub New()
            Me.InitializeComponent()
        End Sub

#Region "Designer Control Properties"

#End Region

#Region "Public Properties"

        Public ReadOnly Property ItemClass() As String
            Get
                Return Me._itemclass
            End Get
        End Property

#End Region

#Region "Button Events"

        Private Sub btnReference_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me._itemclass = "reference"
            Me.DialogResult = DialogResult.OK
        End Sub

        Private Sub btnInstance_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me._itemclass = "instance"
            Me.DialogResult = DialogResult.OK
        End Sub

#End Region

#Region "Backing Fields"

#End Region

    End Class

End Namespace