Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000071 RID: 113
	Public Partial Class frmRefSearchResults
		Inherits frmParent

		' Token: 0x06000EA0 RID: 3744 RVA: 0x0028FC48 File Offset: 0x0028EC48
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000EA1 RID: 3745 RVA: 0x0028FC58 File Offset: 0x0028EC58
		Public Sub New(f As Form)
			Me.New()
			Me.mainform = CType(f, frmMain)
		End Sub

		' Token: 0x1700051E RID: 1310
		' (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0028FD10 File Offset: 0x0028ED10
		' (set) Token: 0x06000EA3 RID: 3747 RVA: 0x0028FC8C File Offset: 0x0028EC8C
		Friend Overridable Property lbMatches As ListBox
			Get
				Return Me._lbMatches
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ListBox)
                If Me._lbMatches IsNot Nothing Then
                    RemoveHandler Me._lbMatches.DoubleClick, AddressOf Me.lbMatches_DoubleClick
                    RemoveHandler Me._lbMatches.SelectedIndexChanged, AddressOf Me.lbMatches_SelectedIndexChanged
                End If
                Me._lbMatches = value
                If Me._lbMatches IsNot Nothing Then
                    AddHandler Me._lbMatches.DoubleClick, AddressOf Me.lbMatches_DoubleClick
                    AddHandler Me._lbMatches.SelectedIndexChanged, AddressOf Me.lbMatches_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x1700051F RID: 1311
        ' (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0028FD24 File Offset: 0x0028ED24
        ' (set) Token: 0x06000EA6 RID: 3750 RVA: 0x0028FD38 File Offset: 0x0028ED38
        Friend Overridable Property Button1() As Button
            Get
                Return Me._Button1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, AddressOf Me.Button1_Click
                End If
                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, AddressOf Me.Button1_Click
                End If
            End Set
        End Property

        ' Token: 0x17000520 RID: 1312
        ' (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0028FD8C File Offset: 0x0028ED8C
        ' (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0028FDA0 File Offset: 0x0028EDA0
        Friend Overridable Property lblNoMatchesFound() As Label
            Get
                Return Me._lblNoMatchesFound
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblNoMatchesFound IsNot Nothing Then
                End If
                Me._lblNoMatchesFound = value
                If Me._lblNoMatchesFound IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000521 RID: 1313
        ' (get) Token: 0x06000EAA RID: 3754 RVA: 0x0028FDBC File Offset: 0x0028EDBC
        ' (set) Token: 0x06000EA9 RID: 3753 RVA: 0x0028FDD0 File Offset: 0x0028EDD0
        Friend Overridable Property lblDesc() As Label
            Get
                Return Me._lblDesc
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblDesc IsNot Nothing Then
                End If
                Me._lblDesc = value
                If Me._lblDesc IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x06000EAC RID: 3756 RVA: 0x002900A4 File Offset: 0x0028F0A4
        Private Sub lbMatches_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        ' Token: 0x06000EAD RID: 3757 RVA: 0x002900A8 File Offset: 0x0028F0A8
        Private Sub lbMatches_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lbMatches.SelectedIndex = -1 Then
                Return
            End If
            Me.mainform.HandleDataByNodeType(CType(Me.lbMatches.SelectedItem, KotorTreeNode), Nothing)
        End Sub

        ' Token: 0x06000EAE RID: 3758 RVA: 0x002900D8 File Offset: 0x0028F0D8
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x0400071D RID: 1821
        <AccessedThroughProperty("lblDesc")> _
        Private _lblDesc As Label

        ' Token: 0x0400071E RID: 1822
        <AccessedThroughProperty("lblNoMatchesFound")> _
        Private _lblNoMatchesFound As Label

        ' Token: 0x0400071F RID: 1823
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x04000720 RID: 1824
        <AccessedThroughProperty("lbMatches")> _
        Private _lbMatches As ListBox

        ' Token: 0x04000721 RID: 1825
        Private mainform As frmMain
    End Class
End Namespace
