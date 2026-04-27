Namespace kotor_tool
	' Token: 0x02000065 RID: 101
	Public Partial Class frmOverrideFilesUsed
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents lblDesc As Global.System.Windows.Forms.Label
        Friend WithEvents lbOverrideFiles As Global.System.Windows.Forms.ListBox


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
            Me.lbOverrideFiles.Location = New Global.System.Drawing.Point(24, 24)
            Me.lbOverrideFiles.Name = "lbOverrideFiles"
            Me.lbOverrideFiles.ScrollAlwaysVisible = True
            Me.lbOverrideFiles.Size = New Global.System.Drawing.Size(208, 121)
            Me.lbOverrideFiles.TabIndex = 0
            Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.Button1.Location = New Global.System.Drawing.Point(95, 160)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New Global.System.Drawing.Size(67, 23)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "OK"
            Me.lblDesc.Location = New Global.System.Drawing.Point(24, 8)
            Me.lblDesc.Name = "lblDesc"
            Me.lblDesc.Size = New Global.System.Drawing.Size(240, 32)
            Me.lblDesc.TabIndex = 2
            Me.lblDesc.Text = "Double click an item in the list to launch the viewer or editor for it"
            Me.lblDesc.Visible = False
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(256, 197)
            Me.Controls.Add(Me.lbOverrideFiles)
            Me.Controls.Add(Me.lblDesc)
            Me.Controls.Add(Me.Button1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New Global.System.Drawing.Size(264, 216)
            Me.Name = "frmOverrideFilesUsed"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Files used from Override folder"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.Button1.Click, AddressOf Me.Button1_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
