Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000066 RID: 102
	Public Partial Class frmPackageTypeSelector
		Inherits Form

		' Token: 0x06000CBE RID: 3262 RVA: 0x002834F4 File Offset: 0x002824F4
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700046A RID: 1130
		' (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00283524 File Offset: 0x00282524
		' (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00283538 File Offset: 0x00282538
		Friend Overridable Property btnOK As Button
			Get
				Return Me._btnOK
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700046B RID: 1131
        ' (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00283570 File Offset: 0x00282570
        ' (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00283554 File Offset: 0x00282554
        Friend Overridable Property btnCancel() As Button
            Get
                Return Me._btnCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnCancel IsNot Nothing Then
                End If
                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700046C RID: 1132
        ' (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00283584 File Offset: 0x00282584
        ' (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00283598 File Offset: 0x00282598
        Friend Overridable Property Label1() As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label1 IsNot Nothing Then
                End If
                Me._Label1 = value
                If Me._Label1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700046D RID: 1133
        ' (get) Token: 0x06000CC6 RID: 3270 RVA: 0x002835D0 File Offset: 0x002825D0
        ' (set) Token: 0x06000CC7 RID: 3271 RVA: 0x002835B4 File Offset: 0x002825B4
        Friend Overridable Property cmbxErfType() As ComboBox
            Get
                Return Me._cmbxErfType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxErfType IsNot Nothing Then
                End If
                Me._cmbxErfType = value
                If Me._cmbxErfType IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x06000CC9 RID: 3273 RVA: 0x002838BC File Offset: 0x002828BC
        Public Sub New(ByVal PackageType As String)
            Me.New()
            Me.cmbxErfType.SelectedIndex = Me.cmbxErfType.FindStringExact(PackageType)
        End Sub

        ' Token: 0x1700046E RID: 1134
        ' (get) Token: 0x06000CCA RID: 3274 RVA: 0x002838DC File Offset: 0x002828DC
        Public ReadOnly Property PackageType() As String
            Get
                Return StringType.FromObject(Me.cmbxErfType.SelectedItem)
            End Get
        End Property

        ' Token: 0x04000657 RID: 1623
        <AccessedThroughProperty("cmbxErfType")> _
        Private _cmbxErfType As ComboBox

        ' Token: 0x04000658 RID: 1624
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x04000659 RID: 1625
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x0400065A RID: 1626
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button
    End Class
End Namespace
