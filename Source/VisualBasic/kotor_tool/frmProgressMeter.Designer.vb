Namespace kotor_tool
	' Token: 0x02000069 RID: 105
	Public Partial Class frmProgressMeter
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000D1A RID: 3354 RVA: 0x002858B8 File Offset: 0x002848B8
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000D21 RID: 3361 RVA: 0x00285968 File Offset: 0x00284968
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.pbar = New Global.System.Windows.Forms.ProgressBar()
            Me.lblStatus = New Global.System.Windows.Forms.Label()
            Me.lblMsg = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Dim pbar As Global.System.Windows.Forms.Control = Me.pbar
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(42, 48)
            pbar.Location = point
            Me.pbar.Name = "pbar"
            Dim pbar2 As Global.System.Windows.Forms.Control = Me.pbar
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(203, 16)
            pbar2.Size = size
            Me.pbar.TabIndex = 0
            Dim lblStatus As Global.System.Windows.Forms.Control = Me.lblStatus
            point = New Global.System.Drawing.Point(27, 80)
            lblStatus.Location = point
            Me.lblStatus.Name = "lblStatus"
            Dim lblStatus2 As Global.System.Windows.Forms.Control = Me.lblStatus
            size = New Global.System.Drawing.Size(232, 23)
            lblStatus2.Size = size
            Me.lblStatus.TabIndex = 1
            Me.lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Dim lblMsg As Global.System.Windows.Forms.Control = Me.lblMsg
            point = New Global.System.Drawing.Point(32, 8)
            lblMsg.Location = point
            Me.lblMsg.Name = "lblMsg"
            Dim lblMsg2 As Global.System.Windows.Forms.Control = Me.lblMsg
            size = New Global.System.Drawing.Size(224, 23)
            lblMsg2.Size = size
            Me.lblMsg.TabIndex = 2
            Me.lblMsg.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(286, 115)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.AddRange(New Global.System.Windows.Forms.Control() {Me.lblMsg, Me.lblStatus, Me.pbar})
            Me.Name = "frmProgressMeter"
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000681 RID: 1665
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
