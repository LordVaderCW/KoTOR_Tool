Namespace kotor_tool
	' Token: 0x0200007A RID: 122
	Public Partial Class frmTPCFileSaveType
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060010E2 RID: 4322 RVA: 0x0029E1F4 File Offset: 0x0029D1F4
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060010EB RID: 4331 RVA: 0x0029E344 File Offset: 0x0029D344
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.btnTPC = New Global.System.Windows.Forms.Button()
            Me.btnTGA = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.btnTPC.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnTPC As Global.System.Windows.Forms.Control = Me.btnTPC
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(143, 96)
            btnTPC.Location = point
            Me.btnTPC.Name = "btnTPC"
            Dim btnTPC2 As Global.System.Windows.Forms.Control = Me.btnTPC
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(80, 23)
            btnTPC2.Size = size
            Me.btnTPC.TabIndex = 1
            Me.btnTPC.Text = "Save as TPC"
            Me.btnTGA.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnTGA As Global.System.Windows.Forms.Control = Me.btnTGA
            point = New Global.System.Drawing.Point(39, 96)
            btnTGA.Location = point
            Me.btnTGA.Name = "btnTGA"
            Dim btnTGA2 As Global.System.Windows.Forms.Control = Me.btnTGA
            size = New Global.System.Drawing.Size(80, 23)
            btnTGA2.Size = size
            Me.btnTGA.TabIndex = 0
            Me.btnTGA.Text = "Save as TGA"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(247, 96)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(52, 24)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(256, 40)
            label2.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Do you want save this file as TPC (native) format or convert it to TGA?"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(360, 133)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnTPC)
            Me.Controls.Add(Me.btnTGA)
            Me.Controls.Add(Me.btnCancel)
            Me.Name = "frmTPCFileSaveType"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "TPC File Output Format"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000825 RID: 2085
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
