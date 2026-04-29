Namespace kotor_tool
    ' Token: 0x02000043 RID: 67
    Partial Public Class frmByteViewer
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        '
        ' Theme notes:
        '   - This Designer uses hard-coded fallback colours only.
        '   - Runtime theme loading should remain in frmByteViewer.vb.
        '   - No helper methods are used, to avoid VS2010 CodeDom issues.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents rbHex As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbANSI As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbUnicode As Global.System.Windows.Forms.RadioButton
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmByteViewer))
            Me.rbHex = New Global.System.Windows.Forms.RadioButton()
            Me.rbANSI = New Global.System.Windows.Forms.RadioButton()
            Me.rbUnicode = New Global.System.Windows.Forms.RadioButton()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()

            '
            'rbHex
            '
            Me.rbHex.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.rbHex.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbHex.Checked = True
            Me.rbHex.ForeColor = Global.System.Drawing.Color.FromArgb(176, 186, 198)
            Me.rbHex.Location = New Global.System.Drawing.Point(64, 256)
            Me.rbHex.Name = "rbHex"
            Me.rbHex.Size = New Global.System.Drawing.Size(64, 16)
            Me.rbHex.TabIndex = 0
            Me.rbHex.TabStop = True
            Me.rbHex.Text = "Hex"
            Me.rbHex.UseVisualStyleBackColor = False

            '
            'rbANSI
            '
            Me.rbANSI.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.rbANSI.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbANSI.ForeColor = Global.System.Drawing.Color.FromArgb(176, 186, 198)
            Me.rbANSI.Location = New Global.System.Drawing.Point(156, 256)
            Me.rbANSI.Name = "rbANSI"
            Me.rbANSI.Size = New Global.System.Drawing.Size(64, 16)
            Me.rbANSI.TabIndex = 1
            Me.rbANSI.Text = "ANSI"
            Me.rbANSI.UseVisualStyleBackColor = False

            '
            'rbUnicode
            '
            Me.rbUnicode.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.rbUnicode.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbUnicode.ForeColor = Global.System.Drawing.Color.FromArgb(176, 186, 198)
            Me.rbUnicode.Location = New Global.System.Drawing.Point(248, 256)
            Me.rbUnicode.Name = "rbUnicode"
            Me.rbUnicode.Size = New Global.System.Drawing.Size(64, 16)
            Me.rbUnicode.TabIndex = 2
            Me.rbUnicode.Text = "Unicode"
            Me.rbUnicode.UseVisualStyleBackColor = False

            '
            'Button1
            '
            Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(46, 55, 66)
            Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.Button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(174, 136, 58)
            Me.Button1.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(82, 65, 32)
            Me.Button1.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(60, 70, 84)
            Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(238, 238, 230)
            Me.Button1.Location = New Global.System.Drawing.Point(504, 248)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New Global.System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 3
            Me.Button1.Text = "OK"
            Me.Button1.UseVisualStyleBackColor = False

            '
            'frmByteViewer
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(18, 22, 28)
            Me.ClientSize = New Global.System.Drawing.Size(632, 277)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.rbHex)
            Me.Controls.Add(Me.rbANSI)
            Me.Controls.Add(Me.rbUnicode)
            Me.ForeColor = Global.System.Drawing.Color.FromArgb(238, 238, 230)
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