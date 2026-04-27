Namespace kotor_tool
	' Token: 0x02000065 RID: 101
	Public Partial Class frmOverrideFilesUsed
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000CB5 RID: 3253 RVA: 0x002831F0 File Offset: 0x002821F0
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000CBC RID: 3260 RVA: 0x002832D8 File Offset: 0x002822D8
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.lbOverrideFiles = New Global.System.Windows.Forms.ListBox()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.lblDesc = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.lbOverrideFiles.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim lbOverrideFiles As Global.System.Windows.Forms.Control = Me.lbOverrideFiles
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(24, 24)
            lbOverrideFiles.Location = point
            Me.lbOverrideFiles.Name = "lbOverrideFiles"
            Me.lbOverrideFiles.ScrollAlwaysVisible = True
            Dim lbOverrideFiles2 As Global.System.Windows.Forms.Control = Me.lbOverrideFiles
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(208, 121)
            lbOverrideFiles2.Size = size
            Me.lbOverrideFiles.TabIndex = 0
            Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Dim button As Global.System.Windows.Forms.Control = Me.Button1
            point = New Global.System.Drawing.Point(95, 160)
            button.Location = point
            Me.Button1.Name = "Button1"
            Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
            size = New Global.System.Drawing.Size(67, 23)
            button2.Size = size
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "OK"
            Dim lblDesc As Global.System.Windows.Forms.Control = Me.lblDesc
            point = New Global.System.Drawing.Point(24, 8)
            lblDesc.Location = point
            Me.lblDesc.Name = "lblDesc"
            Dim lblDesc2 As Global.System.Windows.Forms.Control = Me.lblDesc
            size = New Global.System.Drawing.Size(240, 32)
            lblDesc2.Size = size
            Me.lblDesc.TabIndex = 2
            Me.lblDesc.Text = "Double click an item in the list to launch the viewer or editor for it"
            Me.lblDesc.Visible = False
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(256, 197)
            Me.ClientSize = size
            Me.Controls.Add(Me.lbOverrideFiles)
            Me.Controls.Add(Me.lblDesc)
            Me.Controls.Add(Me.Button1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            size = New Global.System.Drawing.Size(264, 216)
            Me.MinimumSize = size
            Me.Name = "frmOverrideFilesUsed"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Files used from Override folder"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000656 RID: 1622
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
