Namespace kotor_tool
	' Token: 0x02000043 RID: 67
	Public Partial Class frmByteViewer
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents rbHex As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbANSI As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbUnicode As Global.System.Windows.Forms.RadioButton
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button


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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmByteViewer))
            Me.rbHex = New Global.System.Windows.Forms.RadioButton()
            Me.rbANSI = New Global.System.Windows.Forms.RadioButton()
            Me.rbUnicode = New Global.System.Windows.Forms.RadioButton()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.rbHex.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.rbHex.Checked = True
            Me.rbHex.Location = New Global.System.Drawing.Point(64, 256)
            Me.rbHex.Name = "rbHex"
            Me.rbHex.Size = New Global.System.Drawing.Size(64, 16)
            Me.rbHex.TabIndex = 0
            Me.rbHex.TabStop = True
            Me.rbHex.Text = "Hex"
            Me.rbANSI.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.rbANSI.Location = New Global.System.Drawing.Point(156, 256)
            Me.rbANSI.Name = "rbANSI"
            Me.rbANSI.Size = New Global.System.Drawing.Size(64, 16)
            Me.rbANSI.TabIndex = 1
            Me.rbANSI.Text = "ANSI"
            Me.rbUnicode.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.rbUnicode.Location = New Global.System.Drawing.Point(248, 256)
            Me.rbUnicode.Name = "rbUnicode"
            Me.rbUnicode.Size = New Global.System.Drawing.Size(64, 16)
            Me.rbUnicode.TabIndex = 2
            Me.rbUnicode.Text = "Unicode"
            Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.Button1.Location = New Global.System.Drawing.Point(504, 248)
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 3
            Me.Button1.Text = "OK"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(632, 277)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.rbHex)
            Me.Controls.Add(Me.rbANSI)
            Me.Controls.Add(Me.rbUnicode)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximumSize = New Global.System.Drawing.Size(640, 1600)
            Me.MinimumSize = New Global.System.Drawing.Size(640, 200)
            Me.Name = "frmByteViewer"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Byte Viewer"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.rbHex.Click, AddressOf Me.rbHex_Click
            AddHandler Me.rbANSI.Click, AddressOf Me.rbANSI_Click
            AddHandler Me.rbUnicode.Click, AddressOf Me.rbUnicode_Click
            AddHandler Me.Button1.Click, AddressOf Me.Button1_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
