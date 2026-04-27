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

        ' Token: 0x040004D2 RID: 1234
        Private _ProjectPath As String
    End Class
End Namespace
