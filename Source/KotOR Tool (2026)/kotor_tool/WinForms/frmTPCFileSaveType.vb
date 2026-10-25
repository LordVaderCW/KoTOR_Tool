Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x0200007A RID: 122
    Partial Public Class frmTPCFileSaveType
        Inherits Form

        ' Token: 0x060010E1 RID: 4321 RVA: 0x0029E1E4 File Offset: 0x0029D1E4
        Public Sub New()
            Me.InitializeComponent()
        End Sub

        ' This method is called by frmMain to set the maximum number and update the label
        Public Sub ConfigureTextureContext(ByVal count As Integer)
            If count < 1 Then count = 1

            ' Make sure we don't crash if the designer hasn't compiled the new controls yet
            If Me.nudNumberToExtract IsNot Nothing Then
                Me.nudNumberToExtract.Maximum = count
                Me.nudNumberToExtract.Value = 1 ' Default to 1
            End If

            If Me.lblDetectedTextureCount IsNot Nothing Then
                Me.lblDetectedTextureCount.Text = "Detected textures: " & count.ToString()
            End If
        End Sub

        ' Public property for frmMain to read the chosen number
        Public ReadOnly Property NumberOfTexturesToExtract As Integer
            Get
                If Me.nudNumberToExtract IsNot Nothing Then
                    Return CInt(Me.nudNumberToExtract.Value)
                End If
                Return 1
            End Get
        End Property


        ' Token: 0x060010EC RID: 4332 RVA: 0x0029E5AC File Offset: 0x0029D5AC
        Private Sub btnTPC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTPC.Click
            Me.saveType = "tpc"
        End Sub

        ' Token: 0x060010ED RID: 4333 RVA: 0x0029E5BC File Offset: 0x0029D5BC
        Private Sub btnTGA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTGA.Click
            Me.saveType = "tga"
        End Sub

        ' Token: 0x04000826 RID: 2086
        Public saveType As String

        Private Sub btnPNG_Click(sender As Object, e As EventArgs) Handles btnPNG.Click
            Me.saveType = "png"
        End Sub

        Private Sub btnJPG_Click(sender As Object, e As EventArgs) Handles btnJPG.Click
            Me.saveType = "jpg"
        End Sub
    End Class
End Namespace
