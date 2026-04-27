Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000063 RID: 99
	Public Partial Class frmModuleItem_Base_Editor
		Inherits frmParent

		' Token: 0x06000B8F RID: 2959 RVA: 0x0027B7FC File Offset: 0x0027A7FC
		Public Sub New()
			Me.bmpXY = New Bitmap(50, 50)
			Me.bmpXYSpawnPointBearing = New Bitmap(50, 50)
			Me._XYAngle = 0.0
			Me._SpawnPointXYAngle = 0.0
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06000C4A RID: 3146 RVA: 0x00280214 File Offset: 0x0027F214
        Public Sub SetupOrientationIndicators()
            Dim num As Single = CSng(Math.Atan2(CDbl(Me._YOrientation), CDbl(Me._XOrientation)))
            Me._XYAngle = Math.Atan2(CDbl(Me._YOrientation), CDbl((Me._XOrientation * -1.0F))) * 180.0 / 3.1415926535897931 - 90.0
            If Me._XYAngle < 0.0 Then
                Me._XYAngle += 360.0
            End If
            Me.nudXY.Value = New Decimal(Me._XYAngle)
            Me.DrawXYOrientation()
        End Sub

        ' Token: 0x06000C4B RID: 3147 RVA: 0x002802B8 File Offset: 0x0027F2B8
        Public Sub SetupOrientationIndicators(ByVal XOrientation As Single, ByVal YOrientation As Single)
            Me._XOrientation = XOrientation
            Me._YOrientation = YOrientation
            Me.SetupOrientationIndicators()
        End Sub

        ' Token: 0x06000C4C RID: 3148 RVA: 0x002802D0 File Offset: 0x0027F2D0
        Private Sub DrawXYOrientation()
            Dim graphics As Graphics = graphics.FromImage(Me.bmpXY)
            graphics.FillEllipse(Brushes.White, 0, 0, 49, 49)
            graphics.DrawArc(New Pen(Color.Black), 0, 0, 49, 49, 0, 360)
            graphics.DrawPie(New Pen(Color.Black), 0.0F, 0.0F, 49.0F, 49.0F, CSng(Me._XYAngle), 1.0F)
            Me.bmpXY.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Me.pboxXY.Image = Me.bmpXY
        End Sub

        ' Token: 0x06000C4D RID: 3149 RVA: 0x00280364 File Offset: 0x0027F364
        Public Sub SetupOrientationIndicatorsSpawnPointBearing()
            Dim num As Single = CSng(Math.Atan2(CDbl(Me._YOrientation), CDbl(Me._XOrientation)))
            Me._XYAngle = Math.Atan2(CDbl(Me._YOrientation), CDbl((Me._XOrientation * -1.0F))) * 180.0 / 3.1415926535897931 - 90.0
            If Me._XYAngle < 0.0 Then
                Me._XYAngle += 360.0
            End If
            Me.nudXYSpawnPointBearing.Value = New Decimal(Me._XYAngle)
            Me.DrawXYOrientationSpawnPointBearing()
        End Sub

        ' Token: 0x06000C4E RID: 3150 RVA: 0x00280408 File Offset: 0x0027F408
        Public Sub SetupOrientationIndicatorsSpawnPointBearing(ByVal XOrientation As Single, ByVal YOrientation As Single)
            Me._XOrientation = XOrientation
            Me._YOrientation = YOrientation
            Me.SetupOrientationIndicatorsSpawnPointBearing()
        End Sub

        ' Token: 0x06000C4F RID: 3151 RVA: 0x00280420 File Offset: 0x0027F420
        Private Sub DrawXYOrientationSpawnPointBearing()
            Dim graphics As Graphics = graphics.FromImage(Me.bmpXYSpawnPointBearing)
            graphics.FillEllipse(Brushes.White, 0, 0, 49, 49)
            graphics.DrawArc(New Pen(Color.Black), 0, 0, 49, 49, 0, 360)
            graphics.DrawPie(New Pen(Color.Black), 0.0F, 0.0F, 49.0F, 49.0F, CSng(Me._SpawnPointXYAngle), 1.0F)
            Me.bmpXYSpawnPointBearing.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Me.pboxXYSpawnPointBearing.Image = Me.bmpXYSpawnPointBearing
        End Sub

        ' Token: 0x06000C50 RID: 3152 RVA: 0x002804B4 File Offset: 0x0027F4B4
        Public Sub SetupForItemType(ByVal type As Integer)
            If type <> 2042 AndAlso type <> 2058 Then
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
            End If
            If type = 6 Then
                Me.Text = "Camera Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.lblBearing)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.nudXY)
            ElseIf type = 2027 Then
                Me.Text = "Creature Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
            ElseIf type = 2042 Then
                Me.Text = "Door Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.gbTriggerNode.Visible = False
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
            ElseIf type = 2032 Then
                Me.Text = "Trigger Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.lblBearing)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.nudXY)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
            ElseIf type = 2044 Then
                Me.Text = "Placeable Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
            ElseIf type = 2035 Then
                Me.Text = "Sound Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.lblBearing)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.nudXY)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
            ElseIf type = 2051 Then
                Me.Text = "Merchant Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
                Me.lblResRef.Text = "ResRef"
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
            ElseIf type = 2058 Then
                Me.Text = "Waypoint Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
            ElseIf type = 2040 Then
                Me.Text = "Encounter Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
                Me.tabctrl.TabPages(0).Controls.Remove(Me.lblBearing)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.pboxXY)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.nudXY)
            End If
            Me.tabctrl.SelectedTab = Me.tabpagGeneral
        End Sub

        ' Token: 0x06000C51 RID: 3153 RVA: 0x00280A2C File Offset: 0x0027FA2C
        Public Sub DisableLinkedToFields()
            Me.lblDoorLinkedTo.Enabled = False
            Me.lblDoorLinkedToFlags.Enabled = False
            Me.lblDoorLinkedToModule.Enabled = False
            Me.lblDoorLinkedToTransitionDestin.Enabled = False
            Me.tbDoorLinkedTo.Enabled = False
            Me.cmbxDoorLinkedToFlags.Enabled = False
            Me.tbDoorLinkedToModule.Enabled = False
            Me.tbDoorLinkedToTransitionDestin.Enabled = False
            Me.lblTransitionMsg.Visible = True
        End Sub

        ' Token: 0x17000440 RID: 1088
        ' (get) Token: 0x06000C52 RID: 3154 RVA: 0x00280AA8 File Offset: 0x0027FAA8
        ' (set) Token: 0x06000C53 RID: 3155 RVA: 0x00280ABC File Offset: 0x0027FABC
        Public Property XOrientation() As Single
            Get
                Return Me._XOrientation
            End Get
            Set(ByVal value As Single)
                Me._XOrientation = value
            End Set
        End Property

        ' Token: 0x17000441 RID: 1089
        ' (get) Token: 0x06000C54 RID: 3156 RVA: 0x00280AC8 File Offset: 0x0027FAC8
        ' (set) Token: 0x06000C55 RID: 3157 RVA: 0x00280ADC File Offset: 0x0027FADC
        Public Property YOrientation() As Single
            Get
                Return Me._YOrientation
            End Get
            Set(ByVal value As Single)
                Me._YOrientation = value
            End Set
        End Property

        ' Token: 0x17000442 RID: 1090
        ' (get) Token: 0x06000C56 RID: 3158 RVA: 0x00280AE8 File Offset: 0x0027FAE8
        ' (set) Token: 0x06000C57 RID: 3159 RVA: 0x00280BC4 File Offset: 0x0027FBC4
        Public Property Bearing(ByVal ModItemType As Integer) As Single
            Get
                If ModItemType = 2044 Then
                    If Me._XYAngle > 90.0 Then
                        Return CSng(((270.0 - Me._XYAngle) / 180.0 * 3.1415926535897931))
                    End If
                    Return CSng((-CSng((Me._XYAngle + 90.0)) / 180.0 * 3.1415926535897931))
                Else
                    If ModItemType <> 2042 Then
                        Dim num As Single
                        Return num
                    End If
                    If Me._XYAngle > 180.0 Then
                        Return CSng((-CSng((Me._XYAngle - 180.0)) / 180.0 * 3.1415926535897931))
                    End If
                    Return CSng(((180.0 - Me._XYAngle) / 180.0 * 3.1415926535897931))
                End If
            End Get
            Set(ByVal value As Single)
                If ModItemType = 2042 Then
                    Me.SetupOrientationIndicators(CSng(Math.Sin(CDbl(value))), CSng((-CSng(Math.Cos(CDbl(value))))))
                ElseIf ModItemType = 2044 Then
                    Me.SetupOrientationIndicators(CSng((-CSng(Math.Cos(CDbl(value))))), CSng((-CSng(Math.Sin(CDbl(value))))))
                End If
                Me._Bearing = value
                Me.tbBearing.Text = StringType.FromSingle(value)
            End Set
        End Property

        ' Token: 0x17000443 RID: 1091
        ' (get) Token: 0x06000C58 RID: 3160 RVA: 0x00280C2C File Offset: 0x0027FC2C
        ' (set) Token: 0x06000C59 RID: 3161 RVA: 0x00280C40 File Offset: 0x0027FC40
        Public Property XYAngle() As Single
            Get
                Return CSng(Me._XYAngle)
            End Get
            Set(ByVal value As Single)
                Me._XYAngle = CDbl(value)
            End Set
        End Property

        ' Token: 0x17000444 RID: 1092
        ' (get) Token: 0x06000C5A RID: 3162 RVA: 0x00280C4C File Offset: 0x0027FC4C
        ' (set) Token: 0x06000C5B RID: 3163 RVA: 0x00280C60 File Offset: 0x0027FC60
        Public Property SpawnPointBearing() As Single
            Get
                Return Me._Bearing
            End Get
            Set(ByVal value As Single)
                Me._Bearing = value
                If Me._Bearing < 0.0F Then
                    Me._SpawnPointXYAngle = CDbl(Me._Bearing) / 3.1415926535897931 * 180.0 + 360.0
                Else
                    Me._SpawnPointXYAngle = CDbl(Me._Bearing) / 3.1415926535897931 * 180.0
                End If
                Me.DrawXYOrientationSpawnPointBearing()
                Me.tbBearing.Text = StringType.FromSingle(value)
                RemoveHandler Me.nudXYSpawnPointBearing.ValueChanged, AddressOf Me.nudXYSpawnPointBearing_ValueChanged
                Me.nudXYSpawnPointBearing.Value = New Decimal(Me._SpawnPointXYAngle)
                AddHandler Me.nudXYSpawnPointBearing.ValueChanged, AddressOf Me.nudXYSpawnPointBearing_ValueChanged
            End Set
        End Property

        ' Token: 0x17000445 RID: 1093
        ' (get) Token: 0x06000C5C RID: 3164 RVA: 0x00280D2C File Offset: 0x0027FD2C
        ' (set) Token: 0x06000C5D RID: 3165 RVA: 0x00280D40 File Offset: 0x0027FD40
        Public Property SpawnPointXYAngle() As Single
            Get
                Return CSng(Me._SpawnPointXYAngle)
            End Get
            Set(ByVal value As Single)
                Me._SpawnPointXYAngle = CDbl(value)
            End Set
        End Property

        ' Token: 0x17000446 RID: 1094
        ' (get) Token: 0x06000C5E RID: 3166 RVA: 0x00280D4C File Offset: 0x0027FD4C
        ' (set) Token: 0x06000C5F RID: 3167 RVA: 0x00280D60 File Offset: 0x0027FD60
        Public Property SpawnPoints() As GFFType16()
            Get
                Return Me._SpawnPoints
            End Get
            Set(ByVal value As GFFType16())
                Me._SpawnPoints = value
                Dim num As Integer = 1
                Dim length As Integer = Me._SpawnPoints.Length
                For i As Integer = num To length
                    Me.lbSpawnPoints.Items.Add(i)
                Next
            End Set
        End Property

        ' Token: 0x17000447 RID: 1095
        ' (get) Token: 0x06000C60 RID: 3168 RVA: 0x00280DA4 File Offset: 0x0027FDA4
        ' (set) Token: 0x06000C61 RID: 3169 RVA: 0x00280DB8 File Offset: 0x0027FDB8
        Public Property NameLang() As Integer
            Get
                Return Me._nameLang
            End Get
            Set(ByVal value As Integer)
                Me._nameLang = value
            End Set
        End Property

        ' Token: 0x17000448 RID: 1096
        ' (get) Token: 0x06000C62 RID: 3170 RVA: 0x00280DC4 File Offset: 0x0027FDC4
        ' (set) Token: 0x06000C63 RID: 3171 RVA: 0x00280F8C File Offset: 0x0027FF8C
        Public Property CameraOrientationQuat() As GFFType16
            Get
                Dim gfftype As GFFType16 = New GFFType16()
                Dim num As Double = Convert.ToDouble(Me.nudCamOrientationX.Value) * 3.1415926535897931 / 180.0
                Dim num2 As Double = Convert.ToDouble(Me.nudCamOrientationY.Value) * 3.1415926535897931 / 180.0
                Dim num3 As Double = Convert.ToDouble(Me.nudCamOrientationZ.Value) * 3.1415926535897931 / 180.0
                Dim num4 As Double = Math.Cos(num3 / 2.0)
                Dim num5 As Double = Math.Cos(num2 / 2.0)
                Dim num6 As Double = Math.Cos(num / 2.0)
                Dim num7 As Double = Math.Sin(num3 / 2.0)
                Dim num8 As Double = Math.Sin(num2 / 2.0)
                Dim num9 As Double = Math.Sin(num / 2.0)
                Dim num10 As Double = num4 * num5 * num6 - num7 * num8 * num9
                Dim num11 As Double = num4 * num5 * num9 - num7 * num8 * num6
                Dim num12 As Double = num4 * num8 * num6 + num7 * num5 * num9
                Dim num13 As Double = num7 * num5 * num6 - num4 * num8 * num9
                Dim num14 As Double = Math.Sqrt(Math.Pow(num10, 2.0) + Math.Pow(num11, 2.0) + Math.Pow(num12, 2.0) + Math.Pow(num13, 2.0))
                gfftype.W = Convert.ToSingle(num10 / num14)
                gfftype.X = Convert.ToSingle(num11 / num14)
                gfftype.Y = Convert.ToSingle(num12 / num14)
                gfftype.Z = Convert.ToSingle(num13 / num14)
                Return gfftype
            End Get
            Set(ByVal value As GFFType16)
                Me.tbCamOrientationF1.Text = StringType.FromSingle(value.W)
                Me.tbCamOrientationF2.Text = StringType.FromSingle(value.X)
                Me.tbCamOrientationF3.Text = StringType.FromSingle(value.Y)
                Me.tbCamOrientationF4.Text = StringType.FromSingle(value.Z)
            End Set
        End Property

        ' Token: 0x17000449 RID: 1097
        ' (get) Token: 0x06000C65 RID: 3173 RVA: 0x00281044 File Offset: 0x00280044
        ' (set) Token: 0x06000C64 RID: 3172 RVA: 0x00280FF4 File Offset: 0x0027FFF4
        Public Property CameraOrientationEulerAngles() As GFFType17
            Get
                Return New GFFType17() With {.X = Convert.ToSingle(Me.nudCamOrientationX.Value), .Y = Convert.ToSingle(Me.nudCamOrientationY.Value), .Z = Convert.ToSingle(Me.nudCamOrientationZ.Value)}
            End Get
            Set(ByVal value As GFFType17)
                Me.nudCamOrientationX.Value = New Decimal(value.X)
                Me.nudCamOrientationY.Value = New Decimal(value.Y)
                Me.nudCamOrientationZ.Value = New Decimal(value.Z)
            End Set
        End Property

        ' Token: 0x06000C66 RID: 3174 RVA: 0x0028109C File Offset: 0x0028009C
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06000C67 RID: 3175 RVA: 0x002810CC File Offset: 0x002800CC
        Private Sub nudXY_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Me._XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientation()
            Me._XOrientation = -CSng(Math.Round(Math.Cos((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me._YOrientation = CSng(Math.Round(Math.Sin((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me.tbxo.Text = StringType.FromSingle(Me._XOrientation)
            Me.tbyo.Text = StringType.FromSingle(Me._YOrientation)
        End Sub

        ' Token: 0x06000C68 RID: 3176 RVA: 0x0028119C File Offset: 0x0028019C
        Private Sub nudXY_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me._XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientation()
            Me._XOrientation = -CSng(Math.Round(Math.Cos((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me._YOrientation = CSng(Math.Round(Math.Sin((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me.tbxo.Text = StringType.FromSingle(Me._XOrientation)
            Me.tbyo.Text = StringType.FromSingle(Me._YOrientation)
        End Sub

        ' Token: 0x06000C69 RID: 3177 RVA: 0x0028126C File Offset: 0x0028026C
        Private Sub nudXYSpawnPointBearing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me._SpawnPointXYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientationSpawnPointBearing()
            If Me._SpawnPointXYAngle <= 180.0 Then
                Me._Bearing = CSng((Me._SpawnPointXYAngle / 180.0 * 3.1415926535897931))
            Else
                Me._Bearing = CSng(((Me._SpawnPointXYAngle - 360.0) / 180.0 * 3.1415926535897931))
            End If
            If Me.lbSpawnPoints.SelectedIndex <> -1 Then
                Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).W = Me._Bearing
            End If
            Me.tbBearing.Text = StringType.FromSingle(Me._Bearing)
        End Sub

        ' Token: 0x06000C6A RID: 3178 RVA: 0x00281340 File Offset: 0x00280340
        Private Sub btnShowQuaternion_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.tbCamOrientationF1.Visible = True
            Me.tbCamOrientationF2.Visible = True
            Me.tbCamOrientationF3.Visible = True
            Me.tbCamOrientationF4.Visible = True
            Me.lblQuaternionW.Visible = True
        End Sub

        ' Token: 0x06000C6B RID: 3179 RVA: 0x00281380 File Offset: 0x00280380
        Private Sub btnShowQuaternion_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.tbCamOrientationF1.Visible = False
            Me.tbCamOrientationF2.Visible = False
            Me.tbCamOrientationF3.Visible = False
            Me.tbCamOrientationF4.Visible = False
            Me.lblQuaternionW.Visible = False
        End Sub

        ' Token: 0x06000C6C RID: 3180 RVA: 0x002813C0 File Offset: 0x002803C0
        Private Sub nudCamOrientation_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ErrorProvider1.SetError(Me.nudCamOrientationX, "")
        End Sub

        ' Token: 0x06000C6D RID: 3181 RVA: 0x002813D8 File Offset: 0x002803D8
        Private Sub lbSpawnPoints_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.nudSpawnPointX.Enabled = True
            Me.nudSpawnPointY.Enabled = True
            Me.nudSpawnPointZ.Enabled = True
            Me.nudXYSpawnPointBearing.Enabled = True
            Me.nudSpawnPointX.Value = New Decimal(Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).X)
            Me.nudSpawnPointY.Value = New Decimal(Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).Y)
            Me.nudSpawnPointZ.Value = New Decimal(Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).Z)
            Me.SpawnPointBearing = Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).W
        End Sub

        ' Token: 0x06000C6E RID: 3182 RVA: 0x002814A8 File Offset: 0x002804A8
        Private Sub nudXYSpawnPointBearing_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Me.nudXYSpawnPointBearing.Value = Me.nudXYSpawnPointBearing.Value
        End Sub

        ' Token: 0x04000629 RID: 1577
        Private bmpXY As Bitmap

        ' Token: 0x0400062A RID: 1578
        Private bmpXYSpawnPointBearing As Bitmap

        ' Token: 0x0400062B RID: 1579
        Private _XYAngle As Double

        ' Token: 0x0400062C RID: 1580
        Private _SpawnPointXYAngle As Double

        ' Token: 0x0400062D RID: 1581
        Private _XOrientation As Single

        ' Token: 0x0400062E RID: 1582
        Private _YOrientation As Single

        ' Token: 0x0400062F RID: 1583
        Private _ZOrientation As Single

        ' Token: 0x04000630 RID: 1584
        Private _Bearing As Single

        ' Token: 0x04000631 RID: 1585
        Private _SpawnPoints As GFFType16()

        ' Token: 0x04000632 RID: 1586
        Private _nameLang As Integer
    End Class
End Namespace
