Namespace kotor_tool
	' Token: 0x02000079 RID: 121
	Public Partial Class frmTextEditorFind
		Inherits Global.System.Windows.Forms.Form

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
            Dim tbFindText As Global.System.Windows.Forms.Control = Me.tbFindText
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(96, 16)
            tbFindText.Location = point
            Me.tbFindText.Name = "tbFindText"
            Dim tbFindText2 As Global.System.Windows.Forms.Control = Me.tbFindText
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(280, 20)
            tbFindText2.Size = size
            Me.tbFindText.TabIndex = 0
            Me.tbFindText.Text = ""
            Me.btnFind.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnFind As Global.System.Windows.Forms.Control = Me.btnFind
            point = New Global.System.Drawing.Point(408, 16)
            btnFind.Location = point
            Me.btnFind.Name = "btnFind"
            Me.btnFind.TabIndex = 1
            Me.btnFind.Text = "Find"
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(16, 16)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(56, 16)
            label2.Size = size
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Find what:"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(408, 56)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Close"
            Dim chkbMatchCase As Global.System.Windows.Forms.Control = Me.chkbMatchCase
            point = New Global.System.Drawing.Point(24, 41)
            chkbMatchCase.Location = point
            Me.chkbMatchCase.Name = "chkbMatchCase"
            Dim chkbMatchCase2 As Global.System.Windows.Forms.Control = Me.chkbMatchCase
            size = New Global.System.Drawing.Size(104, 16)
            chkbMatchCase2.Size = size
            Me.chkbMatchCase.TabIndex = 3
            Me.chkbMatchCase.Text = "Match case"
            Dim chkbMatchWholeWord As Global.System.Windows.Forms.Control = Me.chkbMatchWholeWord
            point = New Global.System.Drawing.Point(24, 61)
            chkbMatchWholeWord.Location = point
            Me.chkbMatchWholeWord.Name = "chkbMatchWholeWord"
            Dim chkbMatchWholeWord2 As Global.System.Windows.Forms.Control = Me.chkbMatchWholeWord
            size = New Global.System.Drawing.Size(136, 16)
            chkbMatchWholeWord2.Size = size
            Me.chkbMatchWholeWord.TabIndex = 3
            Me.chkbMatchWholeWord.Text = "Match whole word"
            Dim chkbSearchUp As Global.System.Windows.Forms.Control = Me.chkbSearchUp
            point = New Global.System.Drawing.Point(24, 81)
            chkbSearchUp.Location = point
            Me.chkbSearchUp.Name = "chkbSearchUp"
            Dim chkbSearchUp2 As Global.System.Windows.Forms.Control = Me.chkbSearchUp
            size = New Global.System.Drawing.Size(104, 16)
            chkbSearchUp2.Size = size
            Me.chkbSearchUp.TabIndex = 3
            Me.chkbSearchUp.Text = "Search up"
            Me.AcceptButton = Me.btnFind
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(496, 109)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.chkbMatchCase)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnFind)
            Me.Controls.Add(Me.tbFindText)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.chkbMatchWholeWord)
            Me.Controls.Add(Me.chkbSearchUp)
            size = New Global.System.Drawing.Size(504, 136)
            Me.MaximumSize = size
            size = New Global.System.Drawing.Size(504, 136)
            Me.MinimumSize = size
            Me.Name = "frmTextEditorFind"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Find"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000820 RID: 2080
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
