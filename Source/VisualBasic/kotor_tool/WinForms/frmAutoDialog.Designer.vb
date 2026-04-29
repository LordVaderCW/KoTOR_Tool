Namespace kotor_tool
    ' Token: 0x02000040 RID: 64
    Partial Public Class frmAutoDialog
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmAutoDialog.Designer.vb
        '
        ' Restored / themed Auto Dialog form.
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original control names preserved.
        '   - Designer uses fallback DarkSaber-style colours only.
        '   - Runtime theme loading belongs in frmAutoDialog.vb.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Timer1 As Global.System.Windows.Forms.Timer

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.kotor_tool.frmAutoDialog))
            Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'Timer1
            '
            Me.Timer1.Interval = 10000
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(24, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(244, 54)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "The time is being sent to the custom.dlg file in your SW:KotOR Override folder every 10 seconds. Close this window to stop."
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            '
            'frmAutoDialog
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New Global.System.Drawing.Size(292, 93)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAutoDialog"
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Auto Dialog"
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace