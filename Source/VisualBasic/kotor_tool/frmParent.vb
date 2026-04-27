Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000067 RID: 103
	Public Partial Class frmParent
		Inherits Form

		' Token: 0x06000CCB RID: 3275 RVA: 0x002838FC File Offset: 0x002828FC
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000CCE RID: 3278 RVA: 0x002839A0 File Offset: 0x002829A0
		Protected Sub WriteConsoleMsg(msg As Object)
			Console.WriteLine(RuntimeHelpers.GetObjectValue(msg))
		End Sub

		' Token: 0x1700046F RID: 1135
		' (get) Token: 0x06000CCF RID: 3279 RVA: 0x002839B0 File Offset: 0x002829B0
		' (set) Token: 0x06000CD0 RID: 3280 RVA: 0x002839C4 File Offset: 0x002829C4
		Public Property EditingFilePath As String
			Get
				Return Me.m_EditingFilePath
			End Get
			Set(value As String)
				Me.m_EditingFilePath = value
				Me.Text = Me.m_defaultTitleText
				If Me.KotorVersionIndex = 0 Then
					Me.Text += "I - "
				Else
					Me.Text += "II - "
				End If
				Me.Text += Path.GetFileName(value)
			End Set
		End Property

		' Token: 0x06000CD1 RID: 3281 RVA: 0x00283A34 File Offset: 0x00282A34
        Public Sub PositionWindow(ByVal FormClassName As String)
            Me.CurrentSettings = UserSettings.GetSettings()

            Dim point As Point = Me.CurrentSettings.WindowLoc(FormClassName)

            If (point.X < 0) OrElse (point.Y < 0) Then
                point.X = 10
                point.Y = 10
                Me.CurrentSettings.WindowLoc(FormClassName) = point
                UserSettings.SaveSettings(Me.CurrentSettings)
            End If

            Me.Location = point

            Dim size As Size = Me.CurrentSettings.WindowSize(FormClassName)

            If Not size.IsEmpty Then
                Dim height As Integer = 0
                Dim width As Integer = 0

                If size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                    Dim location As Point = Me.Location
                    Dim location2 As Point = New Point(location.X, Screen.PrimaryScreen.WorkingArea.Top)
                    Me.Location = location2
                    height = Screen.PrimaryScreen.WorkingArea.Height

                    Dim size2 As Size = Me.Size
                    Dim size3 As Size = New Size(size2.Width, height)
                    Me.Size = size3
                End If

                If size.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                    Dim left As Integer = Screen.PrimaryScreen.WorkingArea.Left
                    Dim location2 As Point = Me.Location
                    Dim location As Point = New Point(left, location2.Y)
                    Me.Location = location
                    width = Screen.PrimaryScreen.WorkingArea.Width

                    Dim size3 As Size = Me.Size
                    Dim size2 As Size = New Size(width, size3.Height)
                    Me.Size = size2
                End If

                If (width = 0) AndAlso (height = 0) Then
                    Me.Size = Me.CurrentSettings.WindowSize(FormClassName)
                End If
            End If
        End Sub

		' Token: 0x06000CD2 RID: 3282 RVA: 0x00283BD8 File Offset: 0x00282BD8
        Public Sub SaveSettings(ByVal FormClassName As String)
            Me.CurrentSettings = UserSettings.GetSettings()

            If Me.WindowState = FormWindowState.Maximized OrElse Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Normal
            End If

            Dim num As Integer = Me.Size.Width
            Dim size As Size = Me.Size
            Dim num2 As Integer = size.Height

            If num2 >= Screen.PrimaryScreen.WorkingArea.Height Then
                num2 = Screen.PrimaryScreen.WorkingArea.Height - 20
            End If

            If num >= Screen.PrimaryScreen.WorkingArea.Width Then
                num = Screen.PrimaryScreen.WorkingArea.Width - 20
            End If

            size = New Size(num, num2)
            Me.Size = size

            Dim point As Point = New Point(Me.Location.X, Me.Location.Y)

            If Me.Location.X < 0 Then
                point.X = 0
            End If

            If Me.Location.X + Me.Size.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                point.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Size.Width - 30
            End If

            If Me.Location.Y < 0 Then
                point.Y = 0
            End If

            If Me.Location.Y + Me.Size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                point.Y = Screen.PrimaryScreen.WorkingArea.Height - Me.Size.Height - 30
            End If

            Me.Location = point

            Me.CurrentSettings.WindowLoc(FormClassName) = Me.Location
            Me.CurrentSettings.WindowSize(FormClassName) = Me.Size

            UserSettings.SaveSettings(Me.CurrentSettings)
        End Sub

		' Token: 0x0400065D RID: 1629
		Public CurrentSettings As Options

		' Token: 0x0400065E RID: 1630
		Protected KotorVersionIndex As Integer

		' Token: 0x0400065F RID: 1631
		Protected m_EditingFilePath As String

		' Token: 0x04000660 RID: 1632
		Protected m_defaultTitleText As String
	End Class
End Namespace
