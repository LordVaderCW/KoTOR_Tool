Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200005F RID: 95
	Public Partial Class frmModuleEditor_MissingItemSelector
		Inherits Form

		' Token: 0x06000935 RID: 2357 RVA: 0x0026D1E0 File Offset: 0x0026C1E0
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170002CA RID: 714
		' (get) Token: 0x06000937 RID: 2359 RVA: 0x0026D210 File Offset: 0x0026C210
		' (set) Token: 0x06000938 RID: 2360 RVA: 0x0026D224 File Offset: 0x0026C224
		Friend Overridable Property rbUserPalette As RadioButton
			Get
				Return Me._rbUserPalette
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbUserPalette IsNot Nothing Then
                    RemoveHandler Me._rbUserPalette.CheckedChanged, AddressOf Me.CheckedChanged
                End If
                Me._rbUserPalette = value
                If Me._rbUserPalette IsNot Nothing Then
                    AddHandler Me._rbUserPalette.CheckedChanged, AddressOf Me.CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x170002CB RID: 715
        ' (get) Token: 0x06000939 RID: 2361 RVA: 0x0026D2CC File Offset: 0x0026C2CC
        ' (set) Token: 0x0600093A RID: 2362 RVA: 0x0026D278 File Offset: 0x0026C278
        Friend Overridable Property rbGlobalTemplates() As RadioButton
            Get
                Return Me._rbGlobalTemplates
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbGlobalTemplates IsNot Nothing Then
                    RemoveHandler Me._rbGlobalTemplates.CheckedChanged, AddressOf Me.CheckedChanged
                End If
                Me._rbGlobalTemplates = value
                If Me._rbGlobalTemplates IsNot Nothing Then
                    AddHandler Me._rbGlobalTemplates.CheckedChanged, AddressOf Me.CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x170002CC RID: 716
        ' (get) Token: 0x0600093B RID: 2363 RVA: 0x0026D334 File Offset: 0x0026C334
        ' (set) Token: 0x0600093C RID: 2364 RVA: 0x0026D2E0 File Offset: 0x0026C2E0
        Friend Overridable Property rbTemplatesBif() As RadioButton
            Get
                Return Me._rbTemplatesBif
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As RadioButton)
                If Me._rbTemplatesBif IsNot Nothing Then
                    RemoveHandler Me._rbTemplatesBif.CheckedChanged, AddressOf Me.CheckedChanged
                End If
                Me._rbTemplatesBif = value
                If Me._rbTemplatesBif IsNot Nothing Then
                    AddHandler Me._rbTemplatesBif.CheckedChanged, AddressOf Me.CheckedChanged
                End If
            End Set
        End Property

        ' Token: 0x170002CD RID: 717
        ' (get) Token: 0x0600093D RID: 2365 RVA: 0x0026D364 File Offset: 0x0026C364
        ' (set) Token: 0x0600093E RID: 2366 RVA: 0x0026D348 File Offset: 0x0026C348
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

        ' Token: 0x170002CE RID: 718
        ' (get) Token: 0x0600093F RID: 2367 RVA: 0x0026D378 File Offset: 0x0026C378
        ' (set) Token: 0x06000940 RID: 2368 RVA: 0x0026D38C File Offset: 0x0026C38C
        Friend Overridable Property btnOK() As Button
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

        ' Token: 0x170002CF RID: 719
        ' (get) Token: 0x06000942 RID: 2370 RVA: 0x0026D3C4 File Offset: 0x0026C3C4
        ' (set) Token: 0x06000941 RID: 2369 RVA: 0x0026D3A8 File Offset: 0x0026C3A8
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

        ' Token: 0x170002D0 RID: 720
        ' (get) Token: 0x06000943 RID: 2371 RVA: 0x0026D3F4 File Offset: 0x0026C3F4
        ' (set) Token: 0x06000944 RID: 2372 RVA: 0x0026D3D8 File Offset: 0x0026C3D8
        Friend Overridable Property Label2() As Label
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label2 IsNot Nothing Then
                End If
                Me._Label2 = value
                If Me._Label2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002D1 RID: 721
        ' (set) Token: 0x06000946 RID: 2374 RVA: 0x0026D7FC File Offset: 0x0026C7FC
        Public WriteOnly Property ProjectPath() As String
            Set(ByVal value As String)
                Me._ProjectPath = value
                If Not Me._ProjectPath.EndsWith("\") Then
                    Me._ProjectPath += "\"
                End If
            End Set
        End Property

        ' Token: 0x06000947 RID: 2375 RVA: 0x0026D830 File Offset: 0x0026C830
        Private Sub CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnOK.Enabled = Me.rbGlobalTemplates.Checked OrElse Me.rbTemplatesBif.Checked OrElse Me.rbUserPalette.Checked
        End Sub

        ' Token: 0x170002D2 RID: 722
        ' (get) Token: 0x06000948 RID: 2376 RVA: 0x0026D868 File Offset: 0x0026C868
        ' (set) Token: 0x06000949 RID: 2377 RVA: 0x0026D880 File Offset: 0x0026C880
        Public Property UserPaletteChecked() As Boolean
            Get
                Return Me.rbUserPalette.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.rbUserPalette.Checked = value
            End Set
        End Property

        ' Token: 0x170002D3 RID: 723
        ' (get) Token: 0x0600094A RID: 2378 RVA: 0x0026D890 File Offset: 0x0026C890
        ' (set) Token: 0x0600094B RID: 2379 RVA: 0x0026D8A8 File Offset: 0x0026C8A8
        Public Property GlobalTemplatesChecked() As Boolean
            Get
                Return Me.rbGlobalTemplates.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.rbGlobalTemplates.Checked = value
            End Set
        End Property

        ' Token: 0x170002D4 RID: 724
        ' (get) Token: 0x0600094C RID: 2380 RVA: 0x0026D8B8 File Offset: 0x0026C8B8
        ' (set) Token: 0x0600094D RID: 2381 RVA: 0x0026D8D0 File Offset: 0x0026C8D0
        Public Property TemplatesBifChecked() As Boolean
            Get
                Return Me.rbTemplatesBif.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.rbTemplatesBif.Checked = value
            End Set
        End Property

        ' Token: 0x170002D5 RID: 725
        ' (set) Token: 0x0600094E RID: 2382 RVA: 0x0026D8E0 File Offset: 0x0026C8E0
        Public WriteOnly Property UserPaletteAvailable() As Boolean
            Set(ByVal value As Boolean)
                Me.rbUserPalette.Enabled = value
            End Set
        End Property

        ' Token: 0x170002D6 RID: 726
        ' (set) Token: 0x0600094F RID: 2383 RVA: 0x0026D8F0 File Offset: 0x0026C8F0
        Public WriteOnly Property GlobalTemplatesAvailable() As Boolean
            Set(ByVal value As Boolean)
                Me.rbGlobalTemplates.Enabled = value
            End Set
        End Property

        ' Token: 0x170002D7 RID: 727
        ' (set) Token: 0x06000950 RID: 2384 RVA: 0x0026D900 File Offset: 0x0026C900
        Public WriteOnly Property TemplatesBifAvailable() As Boolean
            Set(ByVal value As Boolean)
                Me.rbTemplatesBif.Enabled = value
            End Set
        End Property

        ' Token: 0x040004CA RID: 1226
        <AccessedThroughProperty("rbTemplatesBif")> _
        Private _rbTemplatesBif As RadioButton

        ' Token: 0x040004CB RID: 1227
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040004CC RID: 1228
        <AccessedThroughProperty("rbGlobalTemplates")> _
        Private _rbGlobalTemplates As RadioButton

        ' Token: 0x040004CD RID: 1229
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x040004CE RID: 1230
        <AccessedThroughProperty("rbUserPalette")> _
        Private _rbUserPalette As RadioButton

        ' Token: 0x040004CF RID: 1231
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040004D0 RID: 1232
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040004D2 RID: 1234
        Private _ProjectPath As String
    End Class
End Namespace
