Namespace kotor_tool
	' Token: 0x02000040 RID: 64
	Public Partial Class frmAutoDialog
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Timer1 As Global.System.Windows.Forms.Timer


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
            Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmAutoDialog))
            Me.Timer1 = New Global.System.Windows.Forms.Timer()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.Timer1.Interval = 10000
            Me.Label1.Location = New Global.System.Drawing.Point(32, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(224, 40)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "The time is being sent to the custom.dlg file in your SW:KotOR Override folder every 10 seconds. Close this window to stop."
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(292, 93)
            Me.Controls.Add(Me.Label1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmAutoDialog"
            Me.Text = "Auto Dialog"
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace