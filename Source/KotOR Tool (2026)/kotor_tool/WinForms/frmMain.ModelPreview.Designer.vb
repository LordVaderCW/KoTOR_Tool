Option Strict On
Option Explicit On

Namespace kotor_tool
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmModelPreview
        Inherits Global.System.Windows.Forms.Form

        Private components As Global.System.ComponentModel.IContainer

        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing Then
                    If previewController IsNot Nothing Then previewController.Dispose()
                    If components IsNot Nothing Then components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.previewSplit = New System.Windows.Forms.SplitContainer()
            Me.viewportPanel = New System.Windows.Forms.Panel()
            Me.viewportPlaceholder = New System.Windows.Forms.Label()
            Me.sidebarLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.animationHeading = New System.Windows.Forms.Label()
            Me.clipSummary = New System.Windows.Forms.Label()
            Me.animationList = New System.Windows.Forms.ListBox()
            Me.playbackButtons = New System.Windows.Forms.FlowLayoutPanel()
            Me.playButton = New System.Windows.Forms.Button()
            Me.stopButton = New System.Windows.Forms.Button()
            Me.loopCheck = New System.Windows.Forms.CheckBox()
            Me.animationHelp = New System.Windows.Forms.Label()
            Me.exportButton = New System.Windows.Forms.Button()
            Me.status = New System.Windows.Forms.Label()
            Me.loading = New System.Windows.Forms.Panel()
            CType(Me.previewSplit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.previewSplit.Panel1.SuspendLayout()
            Me.previewSplit.Panel2.SuspendLayout()
            Me.previewSplit.SuspendLayout()
            Me.viewportPanel.SuspendLayout()
            Me.sidebarLayout.SuspendLayout()
            Me.playbackButtons.SuspendLayout()
            Me.SuspendLayout()
            Me.previewSplit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.previewSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
            Me.previewSplit.Name = "previewSplit"
            Me.previewSplit.Size = New System.Drawing.Size(1100,682)
            Me.previewSplit.SplitterDistance = 824
            Me.previewSplit.Panel1MinSize = 400
            Me.previewSplit.Panel2MinSize = 220
            Me.previewSplit.Panel1.Controls.Add(Me.viewportPanel)
            Me.previewSplit.Panel2.Controls.Add(Me.sidebarLayout)
            Me.viewportPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.viewportPanel.Name = "viewportPanel"
            Me.viewportPanel.Controls.Add(Me.viewportPlaceholder)
            Me.viewportPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill
            Me.viewportPlaceholder.Text = "3D MODEL VIEWPORT" & Global.Microsoft.VisualBasic.vbCrLf & "WebView2 is created only when previewing a model."
            Me.viewportPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.viewportPlaceholder.Name = "viewportPlaceholder"
            Me.sidebarLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidebarLayout.Name = "sidebarLayout"
            Me.sidebarLayout.Padding = New System.Windows.Forms.Padding(12)
            Me.sidebarLayout.ColumnCount = 1
            Me.sidebarLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,100))
            Me.sidebarLayout.RowCount = 6
            Me.sidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute,32))
            Me.sidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute,42))
            Me.sidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,100))
            Me.sidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute,42))
            Me.sidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute,30))
            Me.sidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute,78))
            Me.sidebarLayout.Controls.Add(Me.animationHeading,0,0)
            Me.sidebarLayout.Controls.Add(Me.clipSummary,0,1)
            Me.sidebarLayout.Controls.Add(Me.animationList,0,2)
            Me.sidebarLayout.Controls.Add(Me.playbackButtons,0,3)
            Me.sidebarLayout.Controls.Add(Me.loopCheck,0,4)
            Me.sidebarLayout.Controls.Add(Me.animationHelp,0,5)
            Me.animationHeading.Text = "ANIMATION CLIPS"
            Me.animationHeading.Dock = System.Windows.Forms.DockStyle.Fill
            Me.animationHeading.ForeColor = System.Drawing.Color.FromArgb(223,189,92)
            Me.animationHeading.Name = "animationHeading"
            Me.clipSummary.Text = "Open a model to list its animations"
            Me.clipSummary.Dock = System.Windows.Forms.DockStyle.Fill
            Me.clipSummary.Name = "clipSummary"
            Me.animationList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.animationList.IntegralHeight = False
            Me.animationList.BackColor = System.Drawing.Color.FromArgb(16,21,28)
            Me.animationList.ForeColor = System.Drawing.Color.Gainsboro
            Me.animationList.Name = "animationList"
            Me.animationList.AccessibleName = "Animation clips"
            Me.playbackButtons.Dock = System.Windows.Forms.DockStyle.Fill
            Me.playbackButtons.Controls.Add(Me.playButton)
            Me.playbackButtons.Controls.Add(Me.stopButton)
            Me.playbackButtons.Name = "playbackButtons"
            Me.playButton.Text = "Play / Pause"
            Me.playButton.Size = New System.Drawing.Size(110,30)
            Me.playButton.Enabled = False
            Me.playButton.Name = "playButton"
            Me.stopButton.Text = "Stop"
            Me.stopButton.Size = New System.Drawing.Size(80,30)
            Me.stopButton.Enabled = False
            Me.stopButton.Name = "stopButton"
            Me.loopCheck.Text = "Loop clip"
            Me.loopCheck.Checked = True
            Me.loopCheck.Dock = System.Windows.Forms.DockStyle.Fill
            Me.loopCheck.Name = "loopCheck"
            Me.animationHelp.Text = "Select a clip to play. Stop restores the model pose." & Global.Microsoft.VisualBasic.vbCrLf & "Transform animation preview; skin deformation and effects are not yet supported."
            Me.animationHelp.Dock = System.Windows.Forms.DockStyle.Fill
            Me.animationHelp.Name = "animationHelp"
            Me.exportButton.Text = "Export glTF…"
            Me.exportButton.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.exportButton.Height = 32
            Me.exportButton.Name = "exportButton"
            Me.status.Dock = System.Windows.Forms.DockStyle.Top
            Me.status.Height = 40
            Me.status.Visible = False
            Me.status.Name = "status"
            Me.loading.Dock = System.Windows.Forms.DockStyle.Top
            Me.loading.Height = 6
            Me.loading.BackColor = System.Drawing.Color.FromArgb(45,153,255)
            Me.loading.Name = "loading"
            Me.loading.AccessibleName = "Loading model"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F,15F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Font = New System.Drawing.Font("Segoe UI",9F)
            Me.BackColor = System.Drawing.Color.FromArgb(28,34,42)
            Me.ForeColor = System.Drawing.Color.Gainsboro
            Me.ClientSize = New System.Drawing.Size(1100,720)
            Me.MinimumSize = New System.Drawing.Size(850,500)
            Me.Controls.Add(Me.previewSplit)
            Me.Controls.Add(Me.status)
            Me.Controls.Add(Me.loading)
            Me.Controls.Add(Me.exportButton)
            Me.Name = "frmModelPreview"
            Me.Text = "Model preview"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.previewSplit.Panel1.ResumeLayout(False)
            Me.previewSplit.Panel2.ResumeLayout(False)
            CType(Me.previewSplit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.previewSplit.ResumeLayout(False)
            Me.viewportPanel.ResumeLayout(False)
            Me.sidebarLayout.ResumeLayout(False)
            Me.playbackButtons.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Friend WithEvents previewSplit As System.Windows.Forms.SplitContainer
        Friend WithEvents viewportPanel As System.Windows.Forms.Panel
        Friend WithEvents viewportPlaceholder As System.Windows.Forms.Label
        Friend WithEvents sidebarLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents animationHeading As System.Windows.Forms.Label
        Friend WithEvents clipSummary As System.Windows.Forms.Label
        Friend WithEvents animationHelp As System.Windows.Forms.Label
        Friend WithEvents animationList As System.Windows.Forms.ListBox
        Friend WithEvents playbackButtons As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents playButton As System.Windows.Forms.Button
        Friend WithEvents stopButton As System.Windows.Forms.Button
        Friend WithEvents exportButton As System.Windows.Forms.Button
        Friend WithEvents loopCheck As System.Windows.Forms.CheckBox
        Friend WithEvents status As System.Windows.Forms.Label
        Friend WithEvents loading As System.Windows.Forms.Panel
    End Class
End Namespace
