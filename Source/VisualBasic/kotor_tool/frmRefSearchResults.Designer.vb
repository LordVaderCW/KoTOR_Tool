Namespace kotor_tool
	' Token: 0x02000071 RID: 113
	Public Partial Class frmRefSearchResults
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents lbMatches As Global.System.Windows.Forms.ListBox
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents lblNoMatchesFound As Global.System.Windows.Forms.Label
        Friend WithEvents lblDesc As Global.System.Windows.Forms.Label


		' Token: 0x06000EA2 RID: 3746 RVA: 0x0028FC6C File Offset: 0x0028EC6C
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000EAB RID: 3755 RVA: 0x0028FDEC File Offset: 0x0028EDEC
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.lbMatches = New Global.System.Windows.Forms.ListBox()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.lblDesc = New Global.System.Windows.Forms.Label()
            Me.lblNoMatchesFound = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.lbMatches.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.lbMatches.Location = New Global.System.Drawing.Point(24, 56)
            Me.lbMatches.Name = "lbMatches"
            Me.lbMatches.ScrollAlwaysVisible = True
            Me.lbMatches.Size = New Global.System.Drawing.Size(208, 186)
            Me.lbMatches.TabIndex = 0
            Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.Button1.Location = New Global.System.Drawing.Point(95, 288)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New Global.System.Drawing.Size(67, 23)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "OK"
            Me.lblDesc.Location = New Global.System.Drawing.Point(24, 8)
            Me.lblDesc.Name = "lblDesc"
            Me.lblDesc.Size = New Global.System.Drawing.Size(240, 32)
            Me.lblDesc.TabIndex = 2
            Me.lblDesc.Text = "Double click an item in the list to launch the viewer or editor for it"
            Me.lblNoMatchesFound.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.lblNoMatchesFound.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 14.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.lblNoMatchesFound.Location = New Global.System.Drawing.Point(32, 208)
            Me.lblNoMatchesFound.Name = "lblNoMatchesFound"
            Me.lblNoMatchesFound.Size = New Global.System.Drawing.Size(192, 32)
            Me.lblNoMatchesFound.TabIndex = 3
            Me.lblNoMatchesFound.Text = "No Matches Found"
            Me.lblNoMatchesFound.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblNoMatchesFound.Visible = False
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(256, 333)
            Me.Controls.Add(Me.lblDesc)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.lbMatches)
            Me.Controls.Add(Me.lblNoMatchesFound)
            Me.MinimumSize = New Global.System.Drawing.Size(264, 216)
            Me.Name = "frmRefSearchResults"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Search Results"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.lbMatches.DoubleClick, AddressOf Me.lbMatches_DoubleClick
            AddHandler Me.lbMatches.SelectedIndexChanged, AddressOf Me.lbMatches_SelectedIndexChanged
            AddHandler Me.Button1.Click, AddressOf Me.Button1_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
