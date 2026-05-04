Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000064 RID: 100
	Public Partial Class frmOptions
		Inherits Form

		' Token: 0x06000C6F RID: 3183 RVA: 0x002814C0 File Offset: 0x002804C0
		Public Sub New()
			Me.InitializeComponent()
			Me.Setup()
		End Sub

        ' Token: 0x06000CAC RID: 3244 RVA: 0x00282C78 File Offset: 0x00281C78
        Public Sub Setup()
            Me.options = UserSettings.GetSettings()
            Me.chkbBuildBIFTreeAtStartup.Checked = Me.options.bBuildBIFFtreeOnStartup
            Me.chkbBuildModelsBifNode.Checked = Me.options.bBuildModelsBifNode
            Me.chkbAlwaysUnknownGFFasText.Checked = Me.options.bAlwaysUnknownGFFasText
            Me.chkbAlwaysConvertTPC2TGA.Checked = Me.options.bAlwaysConvertTPC2TGA
            Me.chkbDockImageViewer.Checked = Me.options.bDockImageViewer
            Me.chkbTextEditorWordWrap.Checked = Me.options.bTextEditorWordWrap
            Me.chkbShowModuleDescriptions.Checked = Me.options.bShowModuleDescriptions
            Me.chkbShowModuleLocations.Checked = Me.options.bShowModuleLocations
            Me.chkbCheckForUpdatesAtStartup.Checked = Me.options.bCheckForUpdatesAtStartup
            Me.chkbDownloadUpdatesAutomatically.Checked = Me.options.bDownloadUpdatesAutomatically And Me.chkbCheckForUpdatesAtStartup.Checked
            Me.chkbRememberLastTreeNode.Checked = Me.options.bRememberLastTreeNode
            Me.chkbRememberTreeViewState.Checked = Me.options.bRememberTreeViewState
            Me.chkbUseOverrideFiles.Checked = Me.options.bUseOverrideFiles
            If Me.options.bProjMgrUseExternTxtEditor AndAlso StringType.StrCmp(Me.options.ProjMgrTxtEditorPath, "", False) <> 0 Then
                Me.rbProjMgrUseExternTxtEditor.Checked = True
                Me.tbProjMgrTxtEditorPath.Text = Me.options.ProjMgrTxtEditorPath
            Else
                Me.rbProjMgrUseInternTxtEditor.Checked = True
            End If
            If Me.options.bProjMgrUseExternDLGEditor AndAlso StringType.StrCmp(Me.options.ProjMgrDLGEditorPath, "", False) <> 0 Then
                Me.rbProjMgrUseExternDLGEditor.Checked = True
                Me.tbProjMgrDLGEditorPath.Text = Me.options.ProjMgrDLGEditorPath
            Else
                Me.rbProjMgrUseInternDLGEditor.Checked = True
            End If
        End Sub

        ' Token: 0x06000CAD RID: 3245 RVA: 0x00282E68 File Offset: 0x00281E68
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            Me.options.bBuildBIFFtreeOnStartup = Me.chkbBuildBIFTreeAtStartup.Checked
            Me.options.bBuildModelsBifNode = Me.chkbBuildModelsBifNode.Checked
            Me.options.bAlwaysUnknownGFFasText = Me.chkbAlwaysUnknownGFFasText.Checked
            Me.options.bAlwaysConvertTPC2TGA = Me.chkbAlwaysConvertTPC2TGA.Checked
            Me.options.bDockImageViewer = Me.chkbDockImageViewer.Checked
            Me.options.bTextEditorWordWrap = Me.chkbTextEditorWordWrap.Checked
            Me.options.bShowModuleDescriptions = Me.chkbShowModuleDescriptions.Checked
            Me.options.bShowModuleLocations = Me.chkbShowModuleLocations.Checked
            Me.options.bCheckForUpdatesAtStartup = Me.chkbCheckForUpdatesAtStartup.Checked
            Me.options.bDownloadUpdatesAutomatically = Me.chkbDownloadUpdatesAutomatically.Checked
            If Not Me.options.bRememberLastTreeNode And Me.chkbRememberLastTreeNode.Checked Then
                Me.options.LastClickedTVNodePath = ""
            End If
            Me.options.bRememberLastTreeNode = Me.chkbRememberLastTreeNode.Checked
            Me.options.bRememberTreeViewState = Me.chkbRememberTreeViewState.Checked
            Me.options.bUseOverrideFiles = Me.chkbUseOverrideFiles.Checked
            If Me.rbProjMgrUseExternTxtEditor.Checked AndAlso StringType.StrCmp(Me.tbProjMgrTxtEditorPath.Text.Trim(), "", False) <> 0 Then
                Me.options.bProjMgrUseExternTxtEditor = True
                Me.options.ProjMgrTxtEditorPath = Me.tbProjMgrTxtEditorPath.Text
            Else
                Me.options.bProjMgrUseExternTxtEditor = False
                Me.options.ProjMgrTxtEditorPath = ""
            End If
            If Me.rbProjMgrUseExternDLGEditor.Checked AndAlso StringType.StrCmp(Me.tbProjMgrDLGEditorPath.Text.Trim(), "", False) <> 0 Then
                Me.options.bProjMgrUseExternDLGEditor = True
                Me.options.ProjMgrDLGEditorPath = Me.tbProjMgrDLGEditorPath.Text
            Else
                Me.options.bProjMgrUseExternDLGEditor = False
                Me.options.ProjMgrDLGEditorPath = ""
            End If
            UserSettings.SaveSettings(Me.options)
        End Sub

        ' Token: 0x06000CAE RID: 3246 RVA: 0x002830A0 File Offset: 0x002820A0
        Private Sub chkbCheckForUpdatesAtStartup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkbCheckForUpdatesAtStartup.CheckedChanged
            Me.chkbDownloadUpdatesAutomatically.Enabled = Me.chkbCheckForUpdatesAtStartup.Checked
            Me.chkbDownloadUpdatesAutomatically.Checked = Me.chkbCheckForUpdatesAtStartup.Checked
        End Sub

        ' Token: 0x06000CAF RID: 3247 RVA: 0x002830D0 File Offset: 0x002820D0
        Private Sub btnBrowseProjMgrDLGEditorPath_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowseProjMgrDLGEditorPath.Click
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", "C:\", "*.exe", "Select the Dialog Editor you wish to use", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.tbProjMgrDLGEditorPath.Text = text
        End Sub

        ' Token: 0x06000CB0 RID: 3248 RVA: 0x00283120 File Offset: 0x00282120
        Private Sub btnBrowseProjMgrTxtEditorPath_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowseProjMgrTxtEditorPath.Click
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", "C:\", "*.exe", "Select the Text Editor you wish to use", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.tbProjMgrTxtEditorPath.Text = text
        End Sub

        ' Token: 0x06000CB1 RID: 3249 RVA: 0x00283170 File Offset: 0x00282170
        Private Sub rbProjMgrUseExternDLGEditor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbProjMgrUseExternDLGEditor.CheckedChanged
            Dim checked As Boolean = CType(sender, RadioButton).Checked
            Me.tbProjMgrDLGEditorPath.Enabled = checked
            Me.btnBrowseProjMgrDLGEditorPath.Enabled = checked
        End Sub

        ' Token: 0x06000CB2 RID: 3250 RVA: 0x002831A4 File Offset: 0x002821A4
        Private Sub rbProjMgrUseExternTxtEditor_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles rbProjMgrUseExternTxtEditor.CheckedChanged
            Dim checked As Boolean = CType(sender, RadioButton).Checked
            Me.tbProjMgrTxtEditorPath.Enabled = checked
            Me.btnBrowseProjMgrTxtEditorPath.Enabled = checked
        End Sub

        ' Token: 0x04000651 RID: 1617
        Private options As Options
    End Class
End Namespace
