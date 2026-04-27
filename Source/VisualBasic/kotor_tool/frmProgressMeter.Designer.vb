Namespace kotor_tool
	' Token: 0x02000069 RID: 105
	Public Partial Class frmProgressMeter
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents pbar As Global.System.Windows.Forms.ProgressBar
        Friend WithEvents lblStatus As Global.System.Windows.Forms.Label
        Friend WithEvents lblMsg As Global.System.Windows.Forms.Label


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
            Me.pbar.Location = New Global.System.Drawing.Point(42, 48)
            Me.pbar.Name = "pbar"
            Me.pbar.Size = New Global.System.Drawing.Size(203, 16)
            Me.pbar.TabIndex = 0
            Me.lblStatus.Location = New Global.System.Drawing.Point(27, 80)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New Global.System.Drawing.Size(232, 23)
            Me.lblStatus.TabIndex = 1
            Me.lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblMsg.Location = New Global.System.Drawing.Point(32, 8)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New Global.System.Drawing.Size(224, 23)
            Me.lblMsg.TabIndex = 2
            Me.lblMsg.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(286, 115)
            Me.ControlBox = False
            Me.Controls.AddRange(New Global.System.Windows.Forms.Control() {Me.lblMsg, Me.lblStatus, Me.pbar})
            Me.Name = "frmProgressMeter"
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
