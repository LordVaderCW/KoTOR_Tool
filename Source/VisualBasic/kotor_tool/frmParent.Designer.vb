Namespace kotor_tool
	' Token: 0x02000067 RID: 103
	Public Partial Class frmParent
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000CCC RID: 3276 RVA: 0x0028390C File Offset: 0x0028290C
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000CCD RID: 3277 RVA: 0x0028392C File Offset: 0x0028292C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmParent))
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(292, 273)
            Me.ClientSize = size
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmParent"
            Me.Text = "frmParent"
        End Sub

		' Token: 0x0400065C RID: 1628
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
