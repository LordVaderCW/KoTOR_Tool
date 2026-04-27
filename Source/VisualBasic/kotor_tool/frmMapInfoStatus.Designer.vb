Namespace kotor_tool
	' Token: 0x02000059 RID: 89
	Public Partial Class frmMapInfoStatus
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents dgMapInfoStatus As Global.System.Windows.Forms.DataGrid


		' Token: 0x0600076C RID: 1900 RVA: 0x00258BC0 File Offset: 0x00257BC0
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x0600076F RID: 1903 RVA: 0x00258C10 File Offset: 0x00257C10
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmMapInfoStatus))
            Me.dgMapInfoStatus = New Global.System.Windows.Forms.DataGrid()
            CType(Me.dgMapInfoStatus, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.dgMapInfoStatus.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.dgMapInfoStatus.CaptionVisible = False
            Me.dgMapInfoStatus.DataMember = ""
            Me.dgMapInfoStatus.HeaderForeColor = Global.System.Drawing.SystemColors.ControlText
            Me.dgMapInfoStatus.Location = New Global.System.Drawing.Point(8, 8)
            Me.dgMapInfoStatus.Name = "dgMapInfoStatus"
            Me.dgMapInfoStatus.Size = New Global.System.Drawing.Size(536, 280)
            Me.dgMapInfoStatus.TabIndex = 0
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(552, 309)
            Me.Controls.Add(Me.dgMapInfoStatus)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmMapInfoStatus"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "MapInfo Status"
            CType(Me.dgMapInfoStatus, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
