Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool

    Partial Public Class frmResourceTypeSelector
        Inherits Form

        Public Sub New()
            Me.InitializeComponent()
        End Sub

#Region "Designer Control Properties"

#End Region

#Region "Public Properties"

        Public ReadOnly Property SelectedResTypes() As Hashtable
            Get
                Dim selectedTypes As Hashtable = New Hashtable()

                AddResourceTypeIfChecked(selectedTypes, Me.chkbARE, "are")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbGIT, "git")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbIFO, "ifo")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbNCS, "ncs")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbPTH, "pth")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbUTC, "utc")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbUTD, "utd")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbUTE, "ute")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbUTM, "utm")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbUTP, "utp")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbUTS, "uts")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbUTT, "utt")
                AddResourceTypeIfChecked(selectedTypes, Me.chkbUTW, "utw")

                If selectedTypes.Count = 0 Then
                    Return Nothing
                End If

                Return selectedTypes
            End Get
        End Property

#End Region

#Region "Button Events"

        Private Sub btnSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectAll.Click
            Me.SetCheckboxesState(True)
        End Sub

        Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
            Me.SetCheckboxesState(False)
        End Sub

#End Region

#Region "Internal Logic"

        Private Sub AddResourceTypeIfChecked(ByVal table As Hashtable, ByVal checkBox As CheckBox, ByVal resourceType As String)
            If table Is Nothing Then
                Return
            End If

            If checkBox Is Nothing Then
                Return
            End If

            If checkBox.Checked Then
                table.Add(frmMain.GetIDForRsrcType(resourceType), 0)
            End If
        End Sub

        Private Sub SetCheckboxesState(ByVal isChecked As Boolean)
            If Me.chkbARE IsNot Nothing Then Me.chkbARE.Checked = isChecked
            If Me.chkbGIT IsNot Nothing Then Me.chkbGIT.Checked = isChecked
            If Me.chkbIFO IsNot Nothing Then Me.chkbIFO.Checked = isChecked
            If Me.chkbNCS IsNot Nothing Then Me.chkbNCS.Checked = isChecked
            If Me.chkbPTH IsNot Nothing Then Me.chkbPTH.Checked = isChecked
            If Me.chkbUTC IsNot Nothing Then Me.chkbUTC.Checked = isChecked
            If Me.chkbUTD IsNot Nothing Then Me.chkbUTD.Checked = isChecked
            If Me.chkbUTE IsNot Nothing Then Me.chkbUTE.Checked = isChecked
            If Me.chkbUTM IsNot Nothing Then Me.chkbUTM.Checked = isChecked
            If Me.chkbUTP IsNot Nothing Then Me.chkbUTP.Checked = isChecked
            If Me.chkbUTS IsNot Nothing Then Me.chkbUTS.Checked = isChecked
            If Me.chkbUTT IsNot Nothing Then Me.chkbUTT.Checked = isChecked
            If Me.chkbUTW IsNot Nothing Then Me.chkbUTW.Checked = isChecked
        End Sub

#End Region

#Region "Backing Fields"

#End Region

    End Class

End Namespace