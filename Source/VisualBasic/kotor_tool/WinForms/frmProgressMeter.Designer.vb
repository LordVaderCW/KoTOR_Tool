Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmProgressMeter
        Inherits Global.System.Windows.Forms.Form

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents lblHeaderSeparator As Global.System.Windows.Forms.Label

        Friend WithEvents pbar As Global.kotor_tool.CustomProgressBar
        Friend WithEvents lblStatus As Global.System.Windows.Forms.Label
        Friend WithEvents lblMsg As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.lblMsg = New System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New System.Windows.Forms.Label()
            Me.pbar = New kotor_tool.CustomProgressBar()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlRoot.Size = New System.Drawing.Size(340, 150)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.lblStatus)
            Me.pnlBody.Controls.Add(Me.pbar)
            Me.pnlBody.Controls.Add(Me.lblMsg)
            Me.pnlBody.Controls.Add(Me.lblHeaderSeparator)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(10, 10)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Size = New System.Drawing.Size(320, 130)
            Me.pnlBody.TabIndex = 0
            '
            'lblStatus
            '
            Me.lblStatus.BackColor = System.Drawing.Color.Transparent
            Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblStatus.Location = New System.Drawing.Point(24, 88)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(272, 23)
            Me.lblStatus.TabIndex = 1
            Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblMsg
            '
            Me.lblMsg.BackColor = System.Drawing.Color.Transparent
            Me.lblMsg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblMsg.Location = New System.Drawing.Point(24, 18)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New System.Drawing.Size(272, 24)
            Me.lblMsg.TabIndex = 2
            Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(320, 2)
            Me.lblHeaderSeparator.TabIndex = 3
            '
            'pbar
            '
            Me.pbar.BackColor = System.Drawing.Color.Transparent
            Me.pbar.BorderDarkColor = System.Drawing.Color.Transparent
            Me.pbar.BorderGoldColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.pbar.BottomGlowColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pbar.EdgeLightColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(150, Byte), Integer))
            Me.pbar.FillBottomColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.pbar.FillMiddleColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.pbar.FillTopColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(132, Byte), Integer))
            Me.pbar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.pbar.InsetHighlightColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pbar.Location = New System.Drawing.Point(36, 58)
            Me.pbar.MinimumSize = New System.Drawing.Size(40, 12)
            Me.pbar.Name = "pbar"
            Me.pbar.ShineBottomColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.pbar.ShineTopColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.pbar.Size = New System.Drawing.Size(248, 17)
            Me.pbar.SweepColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer))
            Me.pbar.TabIndex = 0
            Me.pbar.TrackBottomColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(15, Byte), Integer))
            Me.pbar.TrackShadowColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.pbar.TrackTopColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer))
            Me.pbar.Value = 50
            '
            'frmProgressMeter
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(340, 150)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "frmProgressMeter"
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace