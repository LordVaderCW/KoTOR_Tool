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

        Friend Overridable Property chkbGIT() As CheckBox
            Get
                Return Me._chkbGIT
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbGIT = value
            End Set
        End Property

        Friend Overridable Property chkbARE() As CheckBox
            Get
                Return Me._chkbARE
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbARE = value
            End Set
        End Property

        Friend Overridable Property chkbIFO() As CheckBox
            Get
                Return Me._chkbIFO
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbIFO = value
            End Set
        End Property

        Friend Overridable Property chkbPTH() As CheckBox
            Get
                Return Me._chkbPTH
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbPTH = value
            End Set
        End Property

        Friend Overridable Property chkbUTD() As CheckBox
            Get
                Return Me._chkbUTD
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbUTD = value
            End Set
        End Property

        Friend Overridable Property chkbUTM() As CheckBox
            Get
                Return Me._chkbUTM
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbUTM = value
            End Set
        End Property

        Friend Overridable Property chkbUTT() As CheckBox
            Get
                Return Me._chkbUTT
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbUTT = value
            End Set
        End Property

        Friend Overridable Property chkbUTC() As CheckBox
            Get
                Return Me._chkbUTC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbUTC = value
            End Set
        End Property

        Friend Overridable Property chkbUTW() As CheckBox
            Get
                Return Me._chkbUTW
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbUTW = value
            End Set
        End Property

        Friend Overridable Property chkbUTE() As CheckBox
            Get
                Return Me._chkbUTE
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbUTE = value
            End Set
        End Property

        Friend Overridable Property chkbUTS() As CheckBox
            Get
                Return Me._chkbUTS
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbUTS = value
            End Set
        End Property

        Friend Overridable Property chkbUTP() As CheckBox
            Get
                Return Me._chkbUTP
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbUTP = value
            End Set
        End Property

        Friend Overridable Property btnOK() As Button
            Get
                Return Me._btnOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                Me._btnOK = value
            End Set
        End Property

        Friend Overridable Property btnCancel() As Button
            Get
                Return Me._btnCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                Me._btnCancel = value
            End Set
        End Property

        Friend Overridable Property Label1() As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                Me._Label1 = value
            End Set
        End Property

        Friend Overridable Property chkbNCS() As CheckBox
            Get
                Return Me._chkbNCS
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As CheckBox)
                Me._chkbNCS = value
            End Set
        End Property

        Friend Overridable Property btnSelectAll() As Button
            Get
                Return Me._btnSelectAll
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnSelectAll IsNot Nothing Then
                    RemoveHandler Me._btnSelectAll.Click, AddressOf Me.btnSelectAll_Click
                End If

                Me._btnSelectAll = value

                If Me._btnSelectAll IsNot Nothing Then
                    AddHandler Me._btnSelectAll.Click, AddressOf Me.btnSelectAll_Click
                End If
            End Set
        End Property

        Friend Overridable Property btnClear() As Button
            Get
                Return Me._btnClear
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._btnClear IsNot Nothing Then
                    RemoveHandler Me._btnClear.Click, AddressOf Me.btnClear_Click
                End If

                Me._btnClear = value

                If Me._btnClear IsNot Nothing Then
                    AddHandler Me._btnClear.Click, AddressOf Me.btnClear_Click
                End If
            End Set
        End Property

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

        Private Sub btnSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetCheckboxesState(True)
        End Sub

        Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
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

        <AccessedThroughProperty("btnClear")> _
        Private _btnClear As Button

        <AccessedThroughProperty("btnSelectAll")> _
        Private _btnSelectAll As Button

        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        <AccessedThroughProperty("chkbNCS")> _
        Private _chkbNCS As CheckBox

        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        <AccessedThroughProperty("chkbUTP")> _
        Private _chkbUTP As CheckBox

        <AccessedThroughProperty("chkbUTS")> _
        Private _chkbUTS As CheckBox

        <AccessedThroughProperty("chkbUTE")> _
        Private _chkbUTE As CheckBox

        <AccessedThroughProperty("chkbUTW")> _
        Private _chkbUTW As CheckBox

        <AccessedThroughProperty("chkbPTH")> _
        Private _chkbPTH As CheckBox

        <AccessedThroughProperty("chkbGIT")> _
        Private _chkbGIT As CheckBox

        <AccessedThroughProperty("chkbUTC")> _
        Private _chkbUTC As CheckBox

        <AccessedThroughProperty("chkbARE")> _
        Private _chkbARE As CheckBox

        <AccessedThroughProperty("chkbUTT")> _
        Private _chkbUTT As CheckBox

        <AccessedThroughProperty("chkbIFO")> _
        Private _chkbIFO As CheckBox

        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        <AccessedThroughProperty("chkbUTM")> _
        Private _chkbUTM As CheckBox

        <AccessedThroughProperty("chkbUTD")> _
        Private _chkbUTD As CheckBox

#End Region

    End Class

End Namespace