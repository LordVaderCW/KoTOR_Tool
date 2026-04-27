Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool

    Partial Public Class frmBWMEditor
        Inherits frmParent

        Private walk As clsBWM
        Private filepath As String = String.Empty

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Public Sub New(ByVal Data As Byte(), ByVal filename As String)
            Me.New()

            Me.walk = New clsBWM(Data)
            Me.DisplayInfo()

            Me.tbFilepath.Text = filename
            Me.filepath = filename

            Me.ShowMsgIfNotSupported(filename)
            Me.EnableSaveMenus()
        End Sub

#Region "Designer Control Properties"

#End Region

#Region "Menu Events"

        Private Sub miOpenBinary_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim defaultImportLocation As String = Me.GetDefaultImportLocation()

            Me.filepath = CStr(frmMain.GetFilePath("load", defaultImportLocation, "*.pwk", "Select a binary PWK/DWK file", "pwk", False, True))

            If String.IsNullOrEmpty(Me.filepath) Then
                Return
            End If

            Try
                Me.walk = New clsBWM(Me.filepath)
            Catch ex As System.Exception
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "PWK Editor Error")
                Return
            End Try

            Me.DisplayInfo()
            Me.tbFilepath.Text = Me.filepath
            Me.ShowMsgIfNotSupported(Me.filepath)
            Me.EnableSaveMenus()
        End Sub

        Private Sub miOpenAscii_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim defaultImportLocation As String = Me.GetDefaultImportLocation()

            Me.filepath = CStr(frmMain.GetFilePath("load", defaultImportLocation, "", "Select an ASCII PWK/DWK/WOK file", "pwk", False, True))

            If String.IsNullOrEmpty(Me.filepath) Then
                Return
            End If

            Me.walk = New clsBWM()

            Try
                Me.walk.ParseASCIIWalkMesh(Me.filepath)
            Catch ex As System.Exception
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "PWK Editor Error")
                Return
            End Try

            Me.DisplayInfo()
            Me.tbFilepath.Text = Me.filepath
            Me.ShowMsgIfNotSupported(Me.filepath)
            Me.EnableSaveMenus()
        End Sub

        Private Sub miSaveAsBinary_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.walk Is Nothing Then
                Return
            End If

            Dim saveDirectory As String = String.Empty
            Dim saveFileName As String = String.Empty

            Me.GetDefaultSaveInfo(saveDirectory, saveFileName)

            Me.filepath = CStr(frmMain.GetFilePath("save", saveDirectory, saveFileName, "Save binary PWK/DWK file", "pwk", False, True))

            If String.IsNullOrEmpty(Me.filepath) Then
                Return
            End If

            Me.walk.WriteBinary(Me.filepath)
            Me.tbFilepath.Text = Me.filepath
        End Sub

        Private Sub miSaveAsASCII_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.walk Is Nothing Then
                Return
            End If

            Dim saveDirectory As String = String.Empty
            Dim saveFileName As String = String.Empty

            Me.GetDefaultSaveInfo(saveDirectory, saveFileName)

            Me.filepath = CStr(frmMain.GetFilePath("save", saveDirectory, saveFileName, "Save ASCII PWK/DWK file", "pwk", False, True))

            If String.IsNullOrEmpty(Me.filepath) Then
                Return
            End If

            Dim prompt As frmPromptForString = New frmPromptForString()
            prompt.lblMsg.Text = "Enter name to use for Walkmesh Parent or click OK to use default"

            If prompt.ShowDialog() = DialogResult.OK Then
                Dim parentName As String = prompt.tbValue.Text.Trim()

                If String.IsNullOrEmpty(parentName) Then
                    parentName = "walk_parent"
                End If

                Me.walk.WriteASCII(Me.filepath, parentName)
            End If
        End Sub

        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

#End Region

#Region "Editor Logic"

        Private Function GetDefaultImportLocation() As String
            If String.IsNullOrEmpty(Me.filepath) Then
                Dim settings As Options = UserSettings.GetSettings()
                Return settings.defaultImportLocation
            End If

            Return Me.filepath
        End Function

        Private Sub GetDefaultSaveInfo(ByRef saveDirectory As String, ByRef saveFileName As String)
            If String.IsNullOrEmpty(Me.filepath) Then
                Dim settings As Options = UserSettings.GetSettings()
                saveDirectory = settings.defaultSaveLocation
                saveFileName = "*.pwk"
            Else
                saveDirectory = Path.GetDirectoryName(Me.filepath)
                saveFileName = Path.GetFileName(Me.filepath)
            End If
        End Sub

        Private Sub ShowMsgIfNotSupported(ByVal sourceFilepath As Object)
            Dim path As String = String.Empty

            If sourceFilepath IsNot Nothing Then
                path = sourceFilepath.ToString()
            End If

            If path.ToLowerInvariant().EndsWith("dwk") Then
                Me.lblNotSupported.Text = "DWK files are not fully supported"
            Else
                Me.lblNotSupported.Text = String.Empty
            End If
        End Sub

        Private Sub EnableSaveMenus()
            If Me.miSaveAsASCII IsNot Nothing Then
                Me.miSaveAsASCII.Enabled = True
            End If

            If Me.miSaveAsBinary IsNot Nothing Then
                Me.miSaveAsBinary.Enabled = True
            End If
        End Sub

        Private Sub DisplayInfo()
            If Me.walk Is Nothing Then
                Return
            End If

            Dim builder As StringBuilder = New StringBuilder(300)

            Me.SetUnknownNumericValues()

            If Me.tbInfo IsNot Nothing Then
                Me.tbInfo.Text = String.Empty
            End If

            builder.Append("Verts: " & Me.walk.verts.Length.ToString() & vbCrLf)

            For index As Integer = 0 To Me.walk.verts.Length - 1
                builder.AppendFormat("{0,10:f4}", Me.walk.verts(index).x)
                builder.AppendFormat("{0,10:f4}", Me.walk.verts(index).y)
                builder.AppendFormat("{0,10:f4}", Me.walk.verts(index).z)
                builder.Append(vbCrLf)
            Next

            builder.Append(vbCrLf)
            builder.Append("Faces: " & Me.walk.faces.Length.ToString() & vbCrLf)

            For index As Integer = 0 To Me.walk.faces.Length - 1
                builder.AppendFormat("{0,4:d}", Me.walk.faces(index).v1)
                builder.AppendFormat("{0,4:d}", Me.walk.faces(index).v2)
                builder.AppendFormat("{0,4:d}", Me.walk.faces(index).v3)
                builder.Append(vbCrLf)
            Next

            builder.Append(vbCrLf)
            builder.Append("Walk Types: " & Me.walk.faces.Length.ToString() & vbCrLf)

            For index As Integer = 0 To Me.walk.faces.Length - 1
                builder.Append(Me.walk.WalkTypes(index).ToString())
                builder.Append(" (")
                builder.Append(Me.WalkTypeString(Me.walk.WalkTypes(index)))
                builder.Append(")")
                builder.Append(vbCrLf)
            Next

            builder.Append(vbCrLf)

            If Me.walk.AABB_Nodes IsNot Nothing AndAlso Me.walk.AABB_Nodes.Length > 0 Then
                builder.Append("AABB Nodes: " & Me.walk.AABB_Nodes.Length.ToString() & vbCrLf)

                For index As Integer = 0 To Me.walk.AABB_Nodes.Length - 1
                    builder.AppendFormat("{0,10:f4}", Me.walk.AABB_Nodes(index).BBox_Min.x)
                    builder.AppendFormat("{0,10:f4}", Me.walk.AABB_Nodes(index).BBox_Min.y)
                    builder.AppendFormat("{0,10:f4}", Me.walk.AABB_Nodes(index).BBox_Min.z)

                    builder.AppendFormat("{0,10:f4}", Me.walk.AABB_Nodes(index).BBox_Max.x)
                    builder.AppendFormat("{0,10:f4}", Me.walk.AABB_Nodes(index).BBox_Max.y)
                    builder.AppendFormat("{0,10:f4}", Me.walk.AABB_Nodes(index).BBox_Max.z)

                    builder.AppendFormat("{0,3:d}", Me.walk.AABB_Nodes(index).LeafFacePartNumber)
                    builder.Append(vbCrLf)
                Next
            End If

            If Me.tbInfo IsNot Nothing Then
                Me.tbInfo.Text = builder.ToString()
                Me.tbInfo.SelectionLength = 0
            End If
        End Sub

        Private Sub SetUnknownNumericValues()
            If Me.walk Is Nothing OrElse Me.walk.unk_singles Is Nothing Then
                Return
            End If

            If Me.walk.unk_singles.Length < 13 Then
                Return
            End If

            Me.nudUnk1.Value = New Decimal(Me.walk.unk_singles(0))

            Me.nudUnk2x.Value = New Decimal(Me.walk.unk_singles(1))
            Me.nudUnk2y.Value = New Decimal(Me.walk.unk_singles(2))
            Me.nudUnk2z.Value = New Decimal(Me.walk.unk_singles(3))

            Me.nudUnk3x.Value = New Decimal(Me.walk.unk_singles(4))
            Me.nudUnk3y.Value = New Decimal(Me.walk.unk_singles(5))
            Me.nudUnk3z.Value = New Decimal(Me.walk.unk_singles(6))

            Me.nudUnk4x.Value = New Decimal(Me.walk.unk_singles(7))
            Me.nudUnk4y.Value = New Decimal(Me.walk.unk_singles(8))
            Me.nudUnk4z.Value = New Decimal(Me.walk.unk_singles(9))

            Me.nudUnk5x.Value = New Decimal(Me.walk.unk_singles(10))
            Me.nudUnk5y.Value = New Decimal(Me.walk.unk_singles(11))
            Me.nudUnk5z.Value = New Decimal(Me.walk.unk_singles(12))
        End Sub

        Private Function WalkTypeString(ByVal walktype As Integer) As String
            Select Case walktype
                Case 0
                    Return "Not Defined"
                Case 1
                    Return "Dirt"
                Case 2
                    Return "Obscuring"
                Case 3
                    Return "Grass"
                Case 4
                    Return "Stone"
                Case 5
                    Return "Wood"
                Case 6
                    Return "Water"
                Case 7
                    Return "Non-walk"
                Case 8
                    Return "Transparent"
                Case 9
                    Return "Carpet"
                Case 10
                    Return "Metal"
                Case 11
                    Return "Puddles"
                Case 12
                    Return "Swamp"
                Case 13
                    Return "Mud"
                Case 14
                    Return "Leaves"
                Case 15
                    Return "Lava"
                Case 16
                    Return "BottomlessPit"
                Case 17
                    Return "DeepWater"
                Case 18
                    Return "Door"
                Case 19
                    Return "NonWalkGrass"
                Case Else
                    Return "Unknown"
            End Select
        End Function

#End Region

#Region "Backing Fields"

#End Region

    End Class

End Namespace