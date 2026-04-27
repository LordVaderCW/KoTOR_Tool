Namespace kotor_tool
	' Token: 0x02000043 RID: 67
	Public Partial Class frmByteViewer
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002CD RID: 717 RVA: 0x0022F71C File Offset: 0x0022E71C
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060002D6 RID: 726 RVA: 0x0022F8DC File Offset: 0x0022E8DC
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmByteViewer))
            Me.rbHex = New Global.System.Windows.Forms.RadioButton()
            Me.rbANSI = New Global.System.Windows.Forms.RadioButton()
            Me.rbUnicode = New Global.System.Windows.Forms.RadioButton()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.rbHex.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.rbHex.Checked = True
            Dim rbHex As Global.System.Windows.Forms.Control = Me.rbHex
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(64, 256)
            rbHex.Location = point
            Me.rbHex.Name = "rbHex"
            Dim rbHex2 As Global.System.Windows.Forms.Control = Me.rbHex
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(64, 16)
            rbHex2.Size = size
            Me.rbHex.TabIndex = 0
            Me.rbHex.TabStop = True
            Me.rbHex.Text = "Hex"
            Me.rbANSI.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Dim rbANSI As Global.System.Windows.Forms.Control = Me.rbANSI
            point = New Global.System.Drawing.Point(156, 256)
            rbANSI.Location = point
            Me.rbANSI.Name = "rbANSI"
            Dim rbANSI2 As Global.System.Windows.Forms.Control = Me.rbANSI
            size = New Global.System.Drawing.Size(64, 16)
            rbANSI2.Size = size
            Me.rbANSI.TabIndex = 1
            Me.rbANSI.Text = "ANSI"
            Me.rbUnicode.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Dim rbUnicode As Global.System.Windows.Forms.Control = Me.rbUnicode
            point = New Global.System.Drawing.Point(248, 256)
            rbUnicode.Location = point
            Me.rbUnicode.Name = "rbUnicode"
            Dim rbUnicode2 As Global.System.Windows.Forms.Control = Me.rbUnicode
            size = New Global.System.Drawing.Size(64, 16)
            rbUnicode2.Size = size
            Me.rbUnicode.TabIndex = 2
            Me.rbUnicode.Text = "Unicode"
            Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim button As Global.System.Windows.Forms.Control = Me.Button1
            point = New Global.System.Drawing.Point(504, 248)
            button.Location = point
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 3
            Me.Button1.Text = "OK"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(632, 277)
            Me.ClientSize = size
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.rbHex)
            Me.Controls.Add(Me.rbANSI)
            Me.Controls.Add(Me.rbUnicode)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(640, 1600)
            Me.MaximumSize = size
            size = New Global.System.Drawing.Size(640, 200)
            Me.MinimumSize = size
            Me.Name = "frmByteViewer"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Byte Viewer"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040001CA RID: 458
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
