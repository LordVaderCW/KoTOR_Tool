Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000060 RID: 96
	Public Partial Class frmModuleEditorOptions
		Inherits Form

		' Token: 0x06000951 RID: 2385 RVA: 0x0026D910 File Offset: 0x0026C910
		Public Sub New()
			Me.InitializeComponent()
		End Sub

        ' Token: 0x170002E3 RID: 739
        ' (get) Token: 0x0600096A RID: 2410 RVA: 0x0026E254 File Offset: 0x0026D254
        ' (set) Token: 0x0600096B RID: 2411 RVA: 0x0026E26C File Offset: 0x0026D26C
        Public Property ModuleElementIndicatorSize() As Decimal
            Get
                Return Me.nudDotSize.Value
            End Get
            Set(ByVal value As Decimal)
                If Convert.ToDouble(value) < 1.0 Then
                    value = 1D
                End If
                If Convert.ToDouble(value) > 4.0 Then
                    value = 4D
                End If
                Me.nudDotSize.Value = value
            End Set
        End Property

        ' Token: 0x170002E4 RID: 740
        ' (get) Token: 0x0600096C RID: 2412 RVA: 0x0026E2C0 File Offset: 0x0026D2C0
        ' (set) Token: 0x0600096D RID: 2413 RVA: 0x0026E2D8 File Offset: 0x0026D2D8
        Public Property ConfirmDeletes() As Boolean
            Get
                Return Me.chkbConfirmDeletes.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkbConfirmDeletes.Checked = value
            End Set
        End Property

        ' Token: 0x170002E5 RID: 741
        ' (get) Token: 0x0600096E RID: 2414 RVA: 0x0026E2E8 File Offset: 0x0026D2E8
        ' (set) Token: 0x0600096F RID: 2415 RVA: 0x0026E300 File Offset: 0x0026D300
        Public Property ShowLocatorRay() As Boolean
            Get
                Return Me.chkbShowLocatorRay.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkbShowLocatorRay.Checked = value
            End Set
        End Property

        ' Token: 0x170002E6 RID: 742
        ' (get) Token: 0x06000970 RID: 2416 RVA: 0x0026E310 File Offset: 0x0026D310
        ' (set) Token: 0x06000971 RID: 2417 RVA: 0x0026E330 File Offset: 0x0026D330
        Public Property ModuleExportPath() As String
            Get
                Return Me.tbModuleExportPath.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbModuleExportPath.Text = value
            End Set
        End Property

        ' Token: 0x06000972 RID: 2418 RVA: 0x0026E340 File Offset: 0x0026D340
        Private Sub btnModuleExportPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbModuleExportPath As TextBox = Me.tbModuleExportPath
            Me.BrowseForModFile(tbModuleExportPath)
            Me.tbModuleExportPath = tbModuleExportPath
        End Sub

        ' Token: 0x06000973 RID: 2419 RVA: 0x0026E364 File Offset: 0x0026D364
        Private Sub BrowseForModFile(ByRef fld As TextBox)
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
            Dim saveFileDialog2 As SaveFileDialog = saveFileDialog
            saveFileDialog2.Title = "Select Module file to export to..."
            saveFileDialog2.Filter = "Module Files (*.mod)|*.mod"
            saveFileDialog2.ValidateNames = True
            saveFileDialog2.DefaultExt = ".mod"
            saveFileDialog2.CheckPathExists = True
            saveFileDialog2.AddExtension = True
            saveFileDialog2.CheckFileExists = False
            saveFileDialog2.CreatePrompt = False
            saveFileDialog2.FilterIndex = 1
            saveFileDialog2.RestoreDirectory = True
            If StringType.StrCmp(fld.Text, "", False) <> 0 Then
                saveFileDialog.InitialDirectory = Strings.Mid(fld.Text, 1, fld.Text.LastIndexOf("\"))
                saveFileDialog.FileName = Strings.Mid(fld.Text, fld.Text.LastIndexOf("\") + 2)
            End If
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = saveFileDialog.FileName
            End If
        End Sub
    End Class
End Namespace
