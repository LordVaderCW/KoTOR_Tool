Imports System
Imports System.Collections
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000093 RID: 147
    Public Class Utils

        Public Shared Function CopyArray(ByVal sourceArray As Array, ByVal destinationArray As Array) As Array
            Return Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(sourceArray, destinationArray)
        End Function

        ' Token: 0x06001818 RID: 6168 RVA: 0x002CD544 File Offset: 0x002CC544
        Public Shared Function FindControl(ByVal ParentCtrl As Control, ByVal CtrlName As String) As Control
            Try
                For Each obj As Object In ParentCtrl.Controls
                    Dim control As Control = CType(obj, Control)
                    If StringType.StrCmp(control.Name, CtrlName, False) = 0 Then
                        Return control
                    End If
                    If control.Controls.Count > 0 Then
                        Dim control2 As Control = Utils.FindControl(control, CtrlName)
                        If control2 IsNot Nothing Then
                            Return control2
                        End If
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return Nothing
        End Function

        ' Token: 0x06001819 RID: 6169 RVA: 0x002CD5D0 File Offset: 0x002CC5D0
        Public Shared Sub EditScriptForTextBox(ByVal editButton As Button, ByVal EditingFilePath As String, ByVal KotorVersionIndex As Integer)
            Dim text As String = editButton.Name.Replace("btnEdit", "tb")
            Dim textBox As TextBox = CType(Utils.FindControl(editButton.Parent, text), TextBox)
            Dim biffileHash As Hashtable = frmMain.KxChitinKey(KotorVersionIndex).GetBIFFileHash("scripts")
            Dim text2 As String = textBox.Text.Trim()
            If StringType.StrCmp(text2, "", False) = 0 Then
                Return
            End If
            Dim text3 As String = Path.Combine(Path.GetDirectoryName(EditingFilePath), text2 + ".nss")
            Dim frmTextEditor As frmTextEditor = Nothing
            If File.Exists(text3) Then
                frmTextEditor = New frmTextEditor(text3, KotorVersionIndex, True)
            ElseIf biffileHash.ContainsKey(text2 + ".nss") Then
                frmTextEditor = New frmTextEditor()
                Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
                frmTextEditor.tbGeneric.Text = asciiencoding.GetString(frmMain.GetBIFFResourceData(KotorVersionIndex, text2, CInt(frmMain.GetIDForRsrcType("nss"))))
                frmTextEditor.tbGeneric.SelectionLength = 0
                frmTextEditor.KotorVersionIndex = KotorVersionIndex
                frmTextEditor.EditingFilePath = text3
                frmTextEditor.DirectEdit = True
                Interaction.MsgBox(String.Concat(New String() {"The file ", text2, ".nss already exists as a standard game resource.", vbLf, "If you save it, this module will use your modified version instead of the global one."}), MsgBoxStyle.Information, "Notice")
            Else
                Interaction.MsgBox("The file " + text2 + ".nss does not exist in the same directory as this file nor as a standard game resource.", MsgBoxStyle.Critical, "File not found")
            End If
            If frmTextEditor Is Nothing Then
                Return
            End If
            frmTextEditor.Filename = text2 + ".nss"
            frmTextEditor.ShowDialog(editButton.TopLevelControl)
            textBox.Text = Path.GetFileNameWithoutExtension(frmTextEditor.Filename)
        End Sub
    End Class
End Namespace
