Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x02000069 RID: 105
    Partial Public Class frmProgressMeter
        Inherits Form

        ' -----------------------------------------------------------------
        ' frmProgressMeter.vb
        '
        ' Legacy progress meter backend preserved for KoTOR Tool source
        ' compatibility. Additional facelift controls are updated only where
        ' safe and do not replace the original public API.
        ' -----------------------------------------------------------------

        Private _cancelRequested As Boolean
        Private _detailsVisible As Boolean
        Private _startedAt As DateTime
        Private _elapsedTimer As Timer

        Public Event CancelRequested(ByVal sender As Object, ByVal e As EventArgs)

        ' Token: 0x06000D19 RID: 3353 RVA: 0x002858A8 File Offset: 0x002848A8
        Public Sub New()
            Me.InitializeComponent()

            Me._cancelRequested = False
            Me._detailsVisible = False
            Me._startedAt = DateTime.Now

            Me._elapsedTimer = New Timer()
            Me._elapsedTimer.Interval = 500
            AddHandler Me._elapsedTimer.Tick, AddressOf Me.ElapsedTimer_Tick
            Me._elapsedTimer.Start()

            Me.UpdatePercentLabel()
            Me.UpdateElapsedLabel()
        End Sub

        Protected Overrides Sub OnFormClosed(ByVal e As FormClosedEventArgs)
            Me.CleanupRuntimeObjects()
            MyBase.OnFormClosed(e)
        End Sub

        Public ReadOnly Property CancelWasRequested() As Boolean
            Get
                Return Me._cancelRequested
            End Get
        End Property

        Public Property AllowCancel() As Boolean
            Get
                Return Me.btnCancel.Enabled AndAlso Me.btnCancel.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btnCancel.Enabled = value
                Me.btnCancel.Visible = value

                If value Then
                    Me.CancelButton = Me.btnCancel
                Else
                    Me.CancelButton = Nothing
                End If
            End Set
        End Property

        Public Property OperationTitle() As String
            Get
                Return Me.lblTitle.Text
            End Get
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If

                Me.lblTitle.Text = value
                Me.Text = value
                Application.DoEvents()
            End Set
        End Property

        Public Property OperationSubtitle() As String
            Get
                Return Me.lblSubtitle.Text
            End Get
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If

                Me.lblSubtitle.Text = value
                Application.DoEvents()
            End Set
        End Property

        Public WriteOnly Property Operation() As String
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If

                Me.lblOperation.Text = value

                If value.Length > 0 Then
                    Me.AppendDetail("Operation: " & value)
                Else
                    Application.DoEvents()
                End If
            End Set
        End Property

        ' Token: 0x1700048E RID: 1166
        ' (set) Token: 0x06000D22 RID: 3362 RVA: 0x00285B20 File Offset: 0x00284B20
        Public WriteOnly Property progress() As Integer
            Set(ByVal value As Integer)
                Me.pbar.Value = value
                Me.UpdatePercentLabel()
            End Set
        End Property

        ' Token: 0x1700048F RID: 1167
        ' (set) Token: 0x06000D23 RID: 3363 RVA: 0x00285B30 File Offset: 0x00284B30
        Public WriteOnly Property stepAmount() As Integer
            Set(ByVal value As Integer)
                Me.pbar.[Step] = value
            End Set
        End Property

        ' Token: 0x17000490 RID: 1168
        ' (set) Token: 0x06000D24 RID: 3364 RVA: 0x00285B40 File Offset: 0x00284B40
        Public WriteOnly Property message() As String
            Set(ByVal value As String)
                Me.lblMsg.Text = value

                If value IsNot Nothing AndAlso value.Length > 0 Then
                    Me.AppendDetail("Message: " & value)
                Else
                    Application.DoEvents()
                End If
            End Set
        End Property

        ' Token: 0x17000491 RID: 1169
        ' (set) Token: 0x06000D25 RID: 3365 RVA: 0x00285B54 File Offset: 0x00284B54
        Public WriteOnly Property status() As String
            Set(ByVal value As String)
                Me.lblStatus.Text = value

                If value IsNot Nothing AndAlso value.Length > 0 Then
                    Me.AppendDetail("Status: " & value)
                Else
                    Application.DoEvents()
                End If
            End Set
        End Property

        ' Token: 0x17000492 RID: 1170
        ' (set) Token: 0x06000D26 RID: 3366 RVA: 0x00285B68 File Offset: 0x00284B68
        Public WriteOnly Property maxvalue() As Integer
            Set(ByVal value As Integer)
                Me.pbar.Maximum = value
                Me.UpdatePercentLabel()
            End Set
        End Property

        ' Token: 0x06000D27 RID: 3367 RVA: 0x00285B78 File Offset: 0x00284B78
        Public Sub stepUp()
            Me.pbar.PerformStep()
            Me.UpdatePercentLabel()
            Application.DoEvents()
        End Sub

        Public Sub AppendDetail(ByVal text As String)
            If text Is Nothing Then
                text = String.Empty
            End If

            If Me.tbDetails.TextLength > 0 Then
                Me.tbDetails.AppendText(Environment.NewLine)
            End If

            Me.tbDetails.AppendText("[" & DateTime.Now.ToString("HH:mm:ss") & "] " & text)
            Me.tbDetails.SelectionStart = Me.tbDetails.TextLength
            Me.tbDetails.ScrollToCaret()
            Application.DoEvents()
        End Sub

        Public Sub ClearDetails()
            Me.tbDetails.Clear()
            Application.DoEvents()
        End Sub

        Public Sub ShowDetailsPanel()
            Me.SetDetailsVisible(True)
        End Sub

        Public Sub HideDetailsPanel()
            Me.SetDetailsVisible(False)
        End Sub

        Private Sub btnDetails_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDetails.Click
            Me.SetDetailsVisible(Not Me._detailsVisible)
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
            If Not Me.btnCancel.Enabled Then
                Return
            End If

            Me._cancelRequested = True
            Me.btnCancel.Enabled = False
            Me.lblOperation.Text = "Cancellation requested..."
            Me.AppendDetail("Cancellation requested by user.")
            RaiseEvent CancelRequested(Me, EventArgs.Empty)
            Application.DoEvents()
        End Sub

        Private Sub ElapsedTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateElapsedLabel()
        End Sub

        Private Sub SetDetailsVisible(ByVal visible As Boolean)
            Me._detailsVisible = visible
            Me.pnlDetailsHost.Visible = visible

            If visible Then
                Me.pnlDetailsHost.Height = 150
                Me.ClientSize = New Size(Me.ClientSize.Width, 386)
                Me.lblDetailsCaption.Location = New Point(18, 7)
                Me.tbDetails.Location = New Point(18, 28)
                Me.tbDetails.Size = New Size(Me.pnlDetailsHost.ClientSize.Width - 36, 86)
                Me.btnDetails.Text = "Hide Details"
            Else
                Me.pnlDetailsHost.Height = 0
                Me.ClientSize = New Size(Me.ClientSize.Width, 236)
                Me.btnDetails.Text = "Details"
            End If

            Application.DoEvents()
        End Sub

        Private Sub UpdatePercentLabel()
            Dim range As Integer = Me.pbar.Maximum - Me.pbar.Minimum
            Dim percent As Integer = 0

            If range > 0 Then
                percent = CInt(Math.Round(((CDbl(Me.pbar.Value - Me.pbar.Minimum) / CDbl(range)) * 100.0R), 0))
            End If

            If percent < 0 Then
                percent = 0
            End If

            If percent > 100 Then
                percent = 100
            End If

            Me.lblPercent.Text = percent.ToString() & "%"
        End Sub

        Private Sub UpdateElapsedLabel()
            Dim elapsed As TimeSpan = DateTime.Now.Subtract(Me._startedAt)

            If elapsed.TotalHours >= 1.0R Then
                Me.lblElapsed.Text = elapsed.Hours.ToString("00") & ":" & elapsed.Minutes.ToString("00") & ":" & elapsed.Seconds.ToString("00")
            Else
                Me.lblElapsed.Text = elapsed.Minutes.ToString("00") & ":" & elapsed.Seconds.ToString("00")
            End If
        End Sub

        Private Sub CleanupRuntimeObjects()
            If Me._elapsedTimer IsNot Nothing Then
                RemoveHandler Me._elapsedTimer.Tick, AddressOf Me.ElapsedTimer_Tick
                Me._elapsedTimer.Stop()
                Me._elapsedTimer.Dispose()
                Me._elapsedTimer = Nothing
            End If
        End Sub

    End Class
End Namespace
