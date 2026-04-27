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

        ' Token: 0x1700060D RID: 1549
        ' (get) Token: 0x060010F0 RID: 4336 RVA: 0x0029E5FC File Offset: 0x0029D5FC
        ' (set) Token: 0x060010F1 RID: 4337 RVA: 0x0029E610 File Offset: 0x0029D610
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

        ' Token: 0x1700060E RID: 1550
        ' (get) Token: 0x060010F3 RID: 4339 RVA: 0x0029E62C File Offset: 0x0029D62C
        ' (set) Token: 0x060010F2 RID: 4338 RVA: 0x0029E640 File Offset: 0x0029D640
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

        ' Token: 0x1700060F RID: 1551
        ' (get) Token: 0x060010F4 RID: 4340 RVA: 0x0029E65C File Offset: 0x0029D65C
        ' (set) Token: 0x060010F5 RID: 4341 RVA: 0x0029E670 File Offset: 0x0029D670
        Friend Overridable Property Label3() As Label
            Get
                Return Me._Label3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._Label3 IsNot Nothing Then
                End If
                Me._Label3 = value
                If Me._Label3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000610 RID: 1552
        ' (get) Token: 0x060010F6 RID: 4342 RVA: 0x0029E6A8 File Offset: 0x0029D6A8
        ' (set) Token: 0x060010F7 RID: 4343 RVA: 0x0029E68C File Offset: 0x0029D68C
        Friend Overridable Property Label4() As Label
            Get
                Return Me._Label4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._Label4 IsNot Nothing Then
                End If
                Me._Label4 = value
                If Me._Label4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000611 RID: 1553
        ' (get) Token: 0x060010F9 RID: 4345 RVA: 0x0029E6BC File Offset: 0x0029D6BC
        ' (set) Token: 0x060010F8 RID: 4344 RVA: 0x0029E6D0 File Offset: 0x0029D6D0
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

        ' Token: 0x17000612 RID: 1554
        ' (get) Token: 0x060010FB RID: 4347 RVA: 0x0029E724 File Offset: 0x0029D724
        ' (set) Token: 0x060010FA RID: 4346 RVA: 0x0029E738 File Offset: 0x0029D738
        Friend Overridable Property Label5() As Label
            Get
                Return Me._Label5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._Label5 IsNot Nothing Then
                End If
                Me._Label5 = value
                If Me._Label5 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000613 RID: 1555
        ' (get) Token: 0x060010FD RID: 4349 RVA: 0x0029E754 File Offset: 0x0029D754
        ' (set) Token: 0x060010FC RID: 4348 RVA: 0x0029E768 File Offset: 0x0029D768
        Friend Overridable Property Label6() As Label
            Get
                Return Me._Label6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._Label6 IsNot Nothing Then
                End If
                Me._Label6 = value
                If Me._Label6 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000614 RID: 1556
        ' (get) Token: 0x060010FE RID: 4350 RVA: 0x0029E784 File Offset: 0x0029D784
        ' (set) Token: 0x060010FF RID: 4351 RVA: 0x0029E798 File Offset: 0x0029D798
        Friend Overridable Property Label7() As Label
            Get
                Return Me._Label7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._Label7 IsNot Nothing Then
                End If
                Me._Label7 = value
                If Me._Label7 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000615 RID: 1557
        ' (get) Token: 0x06001100 RID: 4352 RVA: 0x0029E7D0 File Offset: 0x0029D7D0
        ' (set) Token: 0x06001101 RID: 4353 RVA: 0x0029E7B4 File Offset: 0x0029D7B4
        Friend Overridable Property Label8() As Label
            Get
                Return Me._Label8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Label)
                If Me._Label8 IsNot Nothing Then
                End If
                Me._Label8 = value
                If Me._Label8 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000616 RID: 1558
        ' (get) Token: 0x06001102 RID: 4354 RVA: 0x0029E7E4 File Offset: 0x0029D7E4
        ' (set) Token: 0x06001103 RID: 4355 RVA: 0x0029E7F8 File Offset: 0x0029D7F8
        Friend Overridable Property Button2() As Button
            Get
                Return Me._Button2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As Button)
                If Me._Button2 IsNot Nothing Then
                    RemoveHandler Me._Button2.Click, AddressOf Me.Button2_Click
                End If
                Me._Button2 = value
                If Me._Button2 IsNot Nothing Then
                    AddHandler Me._Button2.Click, AddressOf Me.Button2_Click
                End If
            End Set
        End Property

        ' Token: 0x17000617 RID: 1559
        ' (get) Token: 0x06001105 RID: 4357 RVA: 0x0029E84C File Offset: 0x0029D84C
        ' (set) Token: 0x06001104 RID: 4356 RVA: 0x0029E860 File Offset: 0x0029D860
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

        ' Token: 0x06001107 RID: 4359 RVA: 0x0029EED4 File Offset: 0x0029DED4
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
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

        ' Token: 0x04000827 RID: 2087
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x04000828 RID: 2088
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000829 RID: 2089
        <AccessedThroughProperty("Button2")> _
        Private _Button2 As Button

        ' Token: 0x0400082A RID: 2090
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x0400082B RID: 2091
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x0400082C RID: 2092
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x0400082D RID: 2093
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x0400082E RID: 2094
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x0400082F RID: 2095
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000830 RID: 2096
        <AccessedThroughProperty("Label8")> _
        Private _Label8 As Label

        ' Token: 0x04000831 RID: 2097
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label
    End Class
End Namespace