Namespace kotor_tool
	' Token: 0x02000040 RID: 64
	Public Partial Class frmAutoDialog
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000269 RID: 617 RVA: 0x0022CA54 File Offset: 0x0022BA54
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600026E RID: 622 RVA: 0x0022CB0C File Offset: 0x0022BB0C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmAutoDialog))
            Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.Timer1.Interval = 10000
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(32, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(224, 40)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "The time is being sent to the custom.dlg file in your SW:KotOR Override folder every 10 seconds. Close this window to stop."
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(292, 93)
            Me.ClientSize = size
            Me.Controls.Add(Me.Label1)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmAutoDialog"
            Me.Text = "Auto Dialog"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x0400019A RID: 410
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
