Namespace kotor_tool
	' Token: 0x02000079 RID: 121
	Public Partial Class frmTextEditorFind
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents tbFindText As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnFind As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents chkbMatchCase As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbMatchWholeWord As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbSearchUp As Global.System.Windows.Forms.CheckBox


		' Token: 0x060010D1 RID: 4305 RVA: 0x0029DC90 File Offset: 0x0029CC90
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060010E0 RID: 4320 RVA: 0x0029DE00 File Offset: 0x0029CE00
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.tbFindText = New Global.System.Windows.Forms.TextBox()
            Me.btnFind = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.chkbMatchCase = New Global.System.Windows.Forms.CheckBox()
            Me.chkbMatchWholeWord = New Global.System.Windows.Forms.CheckBox()
            Me.chkbSearchUp = New Global.System.Windows.Forms.CheckBox()
            Me.SuspendLayout()
            Me.tbFindText.Location = New Global.System.Drawing.Point(96, 16)
            Me.tbFindText.Name = "tbFindText"
            Me.tbFindText.Size = New Global.System.Drawing.Size(280, 20)
            Me.tbFindText.TabIndex = 0
            Me.tbFindText.Text = ""
            Me.btnFind.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnFind.Location = New Global.System.Drawing.Point(408, 16)
            Me.btnFind.Name = "btnFind"
            Me.btnFind.TabIndex = 1
            Me.btnFind.Text = "Find"
            Me.Label1.Location = New Global.System.Drawing.Point(16, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(56, 16)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Find what:"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(408, 56)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Close"
            Me.chkbMatchCase.Location = New Global.System.Drawing.Point(24, 41)
            Me.chkbMatchCase.Name = "chkbMatchCase"
            Me.chkbMatchCase.Size = New Global.System.Drawing.Size(104, 16)
            Me.chkbMatchCase.TabIndex = 3
            Me.chkbMatchCase.Text = "Match case"
            Me.chkbMatchWholeWord.Location = New Global.System.Drawing.Point(24, 61)
            Me.chkbMatchWholeWord.Name = "chkbMatchWholeWord"
            Me.chkbMatchWholeWord.Size = New Global.System.Drawing.Size(136, 16)
            Me.chkbMatchWholeWord.TabIndex = 3
            Me.chkbMatchWholeWord.Text = "Match whole word"
            Me.chkbSearchUp.Location = New Global.System.Drawing.Point(24, 81)
            Me.chkbSearchUp.Name = "chkbSearchUp"
            Me.chkbSearchUp.Size = New Global.System.Drawing.Size(104, 16)
            Me.chkbSearchUp.TabIndex = 3
            Me.chkbSearchUp.Text = "Search up"
            Me.AcceptButton = Me.btnFind
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(496, 109)
            Me.ControlBox = False
            Me.Controls.Add(Me.chkbMatchCase)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnFind)
            Me.Controls.Add(Me.tbFindText)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.chkbMatchWholeWord)
            Me.Controls.Add(Me.chkbSearchUp)
            Me.MaximumSize = New Global.System.Drawing.Size(504, 136)
            Me.MinimumSize = New Global.System.Drawing.Size(504, 136)
            Me.Name = "frmTextEditorFind"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Find"
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
