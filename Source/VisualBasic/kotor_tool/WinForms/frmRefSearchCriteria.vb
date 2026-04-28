Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000070 RID: 112
	Public Partial Class frmRefSearchCriteria
		Inherits frmParent

		' Token: 0x06000E4D RID: 3661 RVA: 0x0028D878 File Offset: 0x0028C878
		Public Sub New()
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06000E96 RID: 3734 RVA: 0x0028F5DC File Offset: 0x0028E5DC
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.htFileTypes = New Hashtable()
            If StringType.StrCmp(Me.tbSearchString.Text, "", False) = 0 Then
                Interaction.MsgBox("Please enter a search string", MsgBoxStyle.Critical, Nothing)
                Return
            End If
            Try
                For Each obj As Object In Me.gboxGFF.Controls
                    Dim control As Control = CType(obj, Control)
                    If ((StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0) And control.Parent.Enabled) AndAlso CType(control, CheckBox).Checked Then
                        Me.htFileTypes.Add(control.Text, "")
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.gboxScript.Controls
                    Dim control2 As Control = CType(obj2, Control)
                    If ((StringType.StrCmp(control2.[GetType]().Name, "CheckBox", False) = 0) And control2.Parent.Enabled) AndAlso CType(control2, CheckBox).Checked Then
                        Me.htFileTypes.Add(control2.Text, "")
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            If Me.htFileTypes.Count = 0 Then
                Interaction.MsgBox("Select at least one file type to search for the string in", MsgBoxStyle.Critical, Nothing)
            Else
                Me.DialogResult = DialogResult.OK
            End If
        End Sub

        ' Token: 0x06000E97 RID: 3735 RVA: 0x0028F76C File Offset: 0x0028E76C
        Private Sub btnSetAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                For Each obj As Object In Me.gboxGFF.Controls
                    Dim control As Control = CType(obj, Control)
                    If StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0 Then
                        CType(control, CheckBox).Checked = True
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.gboxScript.Controls
                    Dim control2 As Control = CType(obj2, Control)
                    If StringType.StrCmp(control2.[GetType]().Name, "CheckBox", False) = 0 Then
                        CType(control2, CheckBox).Checked = True
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000E98 RID: 3736 RVA: 0x0028F85C File Offset: 0x0028E85C
        Private Sub btnClearAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                For Each obj As Object In Me.gboxGFF.Controls
                    Dim control As Control = CType(obj, Control)
                    If StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0 Then
                        CType(control, CheckBox).Checked = False
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj2 As Object In Me.gboxScript.Controls
                    Dim control2 As Control = CType(obj2, Control)
                    If StringType.StrCmp(control2.[GetType]().Name, "CheckBox", False) = 0 Then
                        CType(control2, CheckBox).Checked = False
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000E99 RID: 3737 RVA: 0x0028F94C File Offset: 0x0028E94C
        Private Sub chkbTemplates_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.gboxGFF.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbAllBifs.Checked
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9A RID: 3738 RVA: 0x0028F9C4 File Offset: 0x0028E9C4
        Private Sub chkbRIMs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.gboxGFF.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbAllBifs.Checked
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9B RID: 3739 RVA: 0x0028FA3C File Offset: 0x0028EA3C
        Private Sub chkbScripts_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9C RID: 3740 RVA: 0x0028FA78 File Offset: 0x0028EA78
        Private Sub chkbAllBifs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.chkbAllBifs.Checked Then
                Me.chkbScripts.Checked = Me.chkbAllBifs.Checked
                Me.chkbTemplates.Checked = Me.chkbScripts.Checked
            End If
            Me.gboxGFF.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbAllBifs.Checked
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9D RID: 3741 RVA: 0x0028FB28 File Offset: 0x0028EB28
        Private Sub SetFileTypeGBsState()
            Me.chkbScripts.Checked = Me.chkbAllBifs.Checked
            Me.chkbTemplates.Checked = Me.chkbScripts.Checked
            Me.gboxGFF.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbAllBifs.Checked
            Me.gboxScript.Enabled = Me.chkbTemplates.Checked Or Me.chkbRIMs.Checked Or Me.chkbScripts.Checked Or Me.chkbAllBifs.Checked
        End Sub

        ' Token: 0x06000E9E RID: 3742 RVA: 0x0028FBCC File Offset: 0x0028EBCC
        Private Sub rbSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.rbSearchKotor1.Checked Or Me.rbSearchKotor2.Checked Then
                Me.gboxCaseSens.Enabled = True
                Me.gboxSearchString.Enabled = True
            End If
        End Sub

        ' Token: 0x06000E9F RID: 3743 RVA: 0x0028FC00 File Offset: 0x0028EC00
        Private Sub tbSearchString_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim flag As Boolean = Me.tbSearchString.Text.Length > 0
            Me.gboxFileTypes.Enabled = flag
            Me.gboxArchiveTypes.Enabled = flag
            Me.btnOK.Enabled = flag
        End Sub

        ' Token: 0x0400071B RID: 1819
        Public htFileTypes As Hashtable
    End Class
End Namespace
