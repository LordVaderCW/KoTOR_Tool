Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000043 RID: 67
	Public Partial Class frmByteViewer
		Inherits Form

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x060002CA RID: 714 RVA: 0x0022F6A8 File Offset: 0x0022E6A8
		' (set) Token: 0x060002CB RID: 715 RVA: 0x0022F68C File Offset: 0x0022E68C
		Public Overridable Property bv As ByteViewer
			Get
				Return Me._bv
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ByteViewer)
                If Me._bv IsNot Nothing Then
                End If
                Me._bv = value
                If Me._bv IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x060002CC RID: 716 RVA: 0x0022F6BC File Offset: 0x0022E6BC
        Public Sub New()
            AddHandler MyBase.Resize, AddressOf Me.frmByteViewer_Resize
            AddHandler MyBase.Closing, AddressOf Me.frmByteViewer_Closing
            AddHandler MyBase.Load, AddressOf Me.Form1_Load
            Me.bv = New ByteViewer()
            Me.InitializeComponent()
        End Sub

        ' Token: 0x060002D7 RID: 727 RVA: 0x0022FBBC File Offset: 0x0022EBBC
        Public Sub New(ByVal path As String)
            Me.New()
            Me.filepath = path
        End Sub

        ' Token: 0x060002D8 RID: 728 RVA: 0x0022FBCC File Offset: 0x0022EBCC
        Public Sub New(ByVal bytes As Byte())
            Me.New()
            Me.data = bytes
        End Sub

        ' Token: 0x060002D9 RID: 729 RVA: 0x0022FBDC File Offset: 0x0022EBDC
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim bv As Control = Me.bv
            Dim size As Size = New Size(638, 250)
            bv.Size = size
            Me.bv.Anchor = AnchorStyles.Top
            Me.bv.ForeColor = Color.Black
            Me.bv.BackColor = Control.DefaultBackColor
            Me.bv.Visible = True
            Me.Controls.Add(Me.bv)
            If StringType.StrCmp(Me.filepath, "", False) <> 0 Then
                Me.bv.SetFile(Me.filepath)
            ElseIf Me.data.Length > 0 Then
                Me.bv.SetBytes(Me.data)
            End If
            Me.bv.SetDisplayMode(DisplayMode.Hexdump)
            Me.PositionWindow()
            Me.bv.Height = CInt(Math.Round(Conversion.Int(CDbl((Me.Height - 80)) / 21.0) * 21.0 + 21.0))
        End Sub

        ' Token: 0x060002DA RID: 730 RVA: 0x0022FCE8 File Offset: 0x0022ECE8
        Private Sub rbANSI_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.bv.SetDisplayMode(DisplayMode.Ansi)
            Me.bv.Font = New Font("Lucida Console", 8.0F)
        End Sub

        ' Token: 0x060002DB RID: 731 RVA: 0x0022FD10 File Offset: 0x0022ED10
        Private Sub rbHex_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.bv.SetDisplayMode(DisplayMode.Hexdump)
        End Sub

        ' Token: 0x060002DC RID: 732 RVA: 0x0022FD20 File Offset: 0x0022ED20
        Private Sub rbUnicode_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.bv.SetDisplayMode(DisplayMode.Unicode)
        End Sub

        ' Token: 0x060002DD RID: 733 RVA: 0x0022FD30 File Offset: 0x0022ED30
        Private Sub frmByteViewer_Resize(ByVal sender As Object, ByVal e As EventArgs)
            ' The following expression was wrapped in a checked-statement
            Me.bv.Height = CInt(Math.Round(Conversion.Int(CDbl((Me.Height - 80)) / 21.0) * 21.0 + 21.0))
        End Sub

        ' Token: 0x060002DE RID: 734 RVA: 0x0022FD70 File Offset: 0x0022ED70
        Public Sub PositionWindow()
            Dim point As Point = frmMain.CurrentSettings.ByteViewerWindowLoc
            If Not point.IsEmpty Then
                Me.Location = frmMain.CurrentSettings.ByteViewerWindowLoc
            End If
            If Not frmMain.CurrentSettings.ByteViewerWindowSize.IsEmpty Then
                Dim size As Size = frmMain.CurrentSettings.ByteViewerWindowSize
                Dim height As Integer
                Dim size2 As Size
                If size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                    point = Me.Location
                    Dim location As Point = New Point(point.X, Screen.PrimaryScreen.WorkingArea.Top)
                    Me.Location = location
                    height = Screen.PrimaryScreen.WorkingArea.Height
                    size = Me.Size
                    size2 = New Size(size.Width, height)
                    Me.Size = size2
                End If
                size2 = frmMain.CurrentSettings.ByteViewerWindowSize
                Dim width As Integer
                If size2.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                    Dim left As Integer = Screen.PrimaryScreen.WorkingArea.Left
                    Dim location As Point = Me.Location
                    point = New Point(left, location.Y)
                    Me.Location = point
                    width = Screen.PrimaryScreen.WorkingArea.Width
                    Dim num As Integer = width
                    size2 = Me.Size
                    size = New Size(num, size2.Height)
                    Me.Size = size
                End If
                If (width = 0) And (height = 0) Then
                    Me.Size = frmMain.CurrentSettings.ByteViewerWindowSize
                End If
            End If
        End Sub

        ' Token: 0x060002DF RID: 735 RVA: 0x0022FEE8 File Offset: 0x0022EEE8
        Public Sub SaveSettings()
            frmMain.CurrentSettings.ByteViewerWindowLoc = Me.Location
            frmMain.CurrentSettings.ByteViewerWindowSize = Me.Size
        End Sub

        ' Token: 0x060002E0 RID: 736 RVA: 0x0022FF0C File Offset: 0x0022EF0C
        Private Sub frmByteViewer_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings()
        End Sub

        ' Token: 0x060002E1 RID: 737 RVA: 0x0022FF14 File Offset: 0x0022EF14
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x040001C3 RID: 451
        <AccessedThroughProperty("bv")> _
        Private _bv As ByteViewer

        ' Token: 0x040001C8 RID: 456
        Public filepath As String

        ' Token: 0x040001C9 RID: 457
        Public data As Byte()
    End Class
End Namespace
