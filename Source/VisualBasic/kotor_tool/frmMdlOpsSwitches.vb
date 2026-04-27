Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200005B RID: 91
	Public Partial Class frmMdlOpsSwitches
		Inherits Form

		' Token: 0x0600077D RID: 1917 RVA: 0x0025960C File Offset: 0x0025860C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmMdlOpsSwitches_Load
			Me.InitializeComponent()
		End Sub

        ' Token: 0x1700023D RID: 573
        ' (get) Token: 0x0600079C RID: 1948 RVA: 0x0025A238 File Offset: 0x00259238
        Public ReadOnly Property ExtractAnimations() As Boolean
            Get
                Return Me.chkbExtractAnimations.Checked
            End Get
        End Property

        ' Token: 0x1700023E RID: 574
        ' (get) Token: 0x0600079D RID: 1949 RVA: 0x0025A250 File Offset: 0x00259250
        Public ReadOnly Property ConvertSkin() As Boolean
            Get
                Return Me.chkbConvertSkin.Checked
            End Get
        End Property

        ' Token: 0x0600079E RID: 1950 RVA: 0x0025A268 File Offset: 0x00259268
        Private Sub btnModuleExportPath_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModuleExportPath.Click
            Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
            folderBrowserDialog.Description = "Locate folder to store exported models in"
            folderBrowserDialog.SelectedPath = Me.tbModelExtractionPath.Text
            folderBrowserDialog.ShowNewFolderButton = True
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Me.tbModelExtractionPath.Text = folderBrowserDialog.SelectedPath
            End If
        End Sub

        ' Token: 0x0600079F RID: 1951 RVA: 0x0025A2B8 File Offset: 0x002592B8
        Private Sub chkbExportMdlAlignData_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkbExportMdlAlignData.CheckedChanged
            Me.chkbMdlAlignDataOnly.Checked = Not Me.chkbExportMdlAlignData.Checked
        End Sub

        ' Token: 0x060007A0 RID: 1952 RVA: 0x0025A2D4 File Offset: 0x002592D4
        Private Sub chkbMdlAlignDataOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkbMdlAlignDataOnly.CheckedChanged
            Me.chkbExportMdlAlignData.Checked = Not Me.chkbMdlAlignDataOnly.Checked
        End Sub

        ' Token: 0x060007A1 RID: 1953 RVA: 0x0025A2F0 File Offset: 0x002592F0
        Private Sub frmMdlOpsSwitches_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace
