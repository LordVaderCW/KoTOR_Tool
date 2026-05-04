Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Management
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
    ' Token: 0x0200007B RID: 123
    Partial Public Class frmUserRegistration
        Inherits Form

        ' Token: 0x060010EE RID: 4334 RVA: 0x0029E5CC File Offset: 0x0029D5CC
        Public Sub New()
            Me.InitializeComponent()
        End Sub

        ' Token: 0x06001107 RID: 4359 RVA: 0x0029EED4 File Offset: 0x0029DED4
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
            Dim frmQueryUserInfo As frmQueryUserInfo = New frmQueryUserInfo()
            Dim text As String = "paddingpaddingpaddingpaddingpaddingpadding|1|paddingpadding|User name|paddingpaddingpaddingpaddingpaddingpadding|paddingpaddingpaddingpaddingpaddingpadding|user@user.com|paddingpaddingpaddingpaddingpaddingpadding|8-2-2004|paddingpaddingpaddingpaddingpaddingpadding|00:00:0a:01:02:03|paddingpaddingpaddingpaddingpaddingpadding|00:00:0f:05:06:07|paddingpaddingpaddingpaddingpaddingpadding"
            If frmQueryUserInfo.ShowDialog(Me) = DialogResult.OK Then
                text = String.Concat(New String() {"paddingpaddingpaddingpaddingpaddingpadding|1|paddingpadding|", frmQueryUserInfo.tbUserName.Text.Trim(), "|paddingpaddingpaddingpaddingpaddingpadding|paddingpaddingpaddingpaddingpaddingpadding|", frmQueryUserInfo.tbUserEmail.Text.Trim(), "|paddingpaddingpaddingpaddingpaddingpadding|", StringType.FromDate(DateTime.Now)})
                Try
                    Dim managementClass As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
                    Dim instances As ManagementObjectCollection = managementClass.GetInstances()
                    Try
                        For Each managementBaseObject As ManagementBaseObject In instances
                            Dim managementObject As ManagementObject = CType(managementBaseObject, ManagementObject)
                            If ObjectType.ObjTst(managementObject("IPEnabled"), True, False) = 0 Then
                                Console.WriteLine(managementObject("MacAddress").ToString())
                                text = text + "|paddingpaddingpaddingpaddingpaddingpadding|" + managementObject("MacAddress").ToString()
                                Console.WriteLine(managementObject("Description").ToString())
                                Console.WriteLine(managementObject("ServiceName").ToString())
                            End If
                        Next
                    Finally
                        Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator
                        If enumerator IsNot Nothing Then
                            CType(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                Catch ex As System.Exception
                    Interaction.MsgBox(ex.Message + ex.StackTrace, MsgBoxStyle.OkOnly, Nothing)
                End Try
                text += "|paddingpaddingpaddingpaddingpaddingpadding"
                Dim crypt As Crypt = New Crypt()
                crypt.TheKey(0) = 11
                crypt.TheKey(1) = 19
                crypt.TheKey(2) = 19
                crypt.TheKey(3) = 63
                crypt.TheKey(4) = 9
                crypt.TheKey(5) = 19
                crypt.TheKey(6) = 19
                crypt.TheKey(7) = 65
                Dim text2 As String = crypt.Encrypt(text)
                Dim fileStream As FileStream = New FileStream("user reg.info", FileMode.Create)
                Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)
                binaryWriter.Write(text2)
                binaryWriter.Close()
                Interaction.MsgBox("Your User Registration info file has been generated and placed in the same folder as Kotor Tool." & vbLf & "Email this file to author to continue the registration process.", MsgBoxStyle.Information, Nothing)
            End If
        End Sub

        ' Token: 0x06001108 RID: 4360 RVA: 0x0029F11C File Offset: 0x0029E11C
        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            Dim frmMain As frmMain = New frmMain()
            openFileDialog.Title = "Select key file..."
            openFileDialog.Filter = "User key files (*.key)|*.key"
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = False
            openFileDialog.RestoreDirectory = True
            openFileDialog.FileName = "*.key"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim fileStream As FileStream = New FileStream(openFileDialog.FileName, FileMode.Open)
                Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
                Dim text As String = binaryReader.ReadString()
                binaryReader.Close()
                frmMain.CurrentSettings.Key = text
                frmMain.SaveSettings()
                Interaction.MsgBox("The key file has been imported into your settings.xml file." & vbLf & vbLf & "Thank you for registering your copy of Kotor Tool.", MsgBoxStyle.OkOnly, Nothing)
                Me.Close()
            End If
        End Sub
    End Class
End Namespace