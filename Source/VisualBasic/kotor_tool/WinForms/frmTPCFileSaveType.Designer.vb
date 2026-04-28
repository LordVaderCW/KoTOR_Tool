Namespace kotor_tool
	' Token: 0x0200007A RID: 122
	Public Partial Class frmTPCFileSaveType
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents btnTPC As Global.System.Windows.Forms.Button
        Friend WithEvents btnTGA As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label


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
            Me.btnTPC.Location = New Global.System.Drawing.Point(143, 96)
            Me.btnTPC.Name = "btnTPC"
            Me.btnTPC.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnTPC.TabIndex = 1
            Me.btnTPC.Text = "Save as TPC"
            Me.btnTGA.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnTGA.Location = New Global.System.Drawing.Point(39, 96)
            Me.btnTGA.Name = "btnTGA"
            Me.btnTGA.Size = New Global.System.Drawing.Size(80, 23)
            Me.btnTGA.TabIndex = 0
            Me.btnTGA.Text = "Save as TGA"
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(247, 96)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Me.Label1.Location = New Global.System.Drawing.Point(52, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(256, 40)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Do you want save this file as TPC (native) format or convert it to TGA?"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(360, 133)
            Me.ControlBox = False
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnTPC)
            Me.Controls.Add(Me.btnTGA)
            Me.Controls.Add(Me.btnCancel)
            Me.Name = "frmTPCFileSaveType"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "TPC File Output Format"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnTPC.Click, AddressOf Me.btnTPC_Click
            AddHandler Me.btnTGA.Click, AddressOf Me.btnTGA_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
