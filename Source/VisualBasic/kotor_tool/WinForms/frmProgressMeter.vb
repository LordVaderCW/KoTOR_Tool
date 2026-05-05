Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool

    Partial Public Class frmProgressMeter
        Inherits Form

        Private _cancelRequested As Boolean
        Private _detailsVisible As Boolean
        Private _startedAt As DateTime
        Private _elapsedTimer As Timer

        Public Event CancelRequested(ByVal sender As Object, ByVal e As EventArgs)

        Public Sub New()
            Me.InitializeComponent()

            Me._cancelRequested = False
            Me._detailsVisible = True
            Me._startedAt = DateTime.Now

            Me.pnlDetailsHost.Visible = True

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

        Public WriteOnly Property progress() As Integer
            Set(ByVal value As Integer)
                If value < Me.pbar.Minimum Then
                    value = Me.pbar.Minimum
                End If

                If value > Me.pbar.Maximum Then
                    value = Me.pbar.Maximum
                End If

                Me.pbar.Value = value
                Me.UpdatePercentLabel()
                Application.DoEvents()
            End Set
        End Property

        Public WriteOnly Property stepAmount() As Integer
            Set(ByVal value As Integer)
                Me.pbar.[Step] = value
            End Set
        End Property

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

        Public WriteOnly Property maxvalue() As Integer
            Set(ByVal value As Integer)
                If value < 1 Then
                    value = 1
                End If

                Me.pbar.Maximum = value

                If Me.pbar.Value > Me.pbar.Maximum Then
                    Me.pbar.Value = Me.pbar.Maximum
                End If

                Me.UpdatePercentLabel()
                Application.DoEvents()
            End Set
        End Property

        Public Sub stepUp()
            If Me.pbar.Value + Me.pbar.[Step] > Me.pbar.Maximum Then
                Me.pbar.Value = Me.pbar.Maximum
            Else
                Me.pbar.PerformStep()
            End If

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
            Me.SetDetailsVisible(True)
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
            Me._detailsVisible = True
            Me.pnlDetailsHost.Visible = True
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