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

        Friend Overridable Property Label1() As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                Me._Label1 = value
            End Set
        End Property

        Friend Overridable Property btnReference() As Button
            Get
                Return Me._btnReference
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnReference IsNot Nothing Then
                    RemoveHandler Me._btnReference.Click, AddressOf Me.btnReference_Click
                End If

                Me._btnReference = value

                If Me._btnReference IsNot Nothing Then
                    AddHandler Me._btnReference.Click, AddressOf Me.btnReference_Click
                End If
            End Set
        End Property

        Friend Overridable Property btnInstance() As Button
            Get
                Return Me._btnInstance
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnInstance IsNot Nothing Then
                    RemoveHandler Me._btnInstance.Click, AddressOf Me.btnInstance_Click
                End If

                Me._btnInstance = value

                If Me._btnInstance IsNot Nothing Then
                    AddHandler Me._btnInstance.Click, AddressOf Me.btnInstance_Click
                End If
            End Set
        End Property

        Friend Overridable Property Button3() As Button
            Get
                Return Me._Button3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                Me._Button3 = value
            End Set
        End Property

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

        <AccessedThroughProperty("btnInstance")> _
        Private _btnInstance As Button

        <AccessedThroughProperty("btnReference")> _
        Private _btnReference As Button

        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        <AccessedThroughProperty("Button3")> _
        Private _Button3 As Button

#End Region

    End Class

End Namespace