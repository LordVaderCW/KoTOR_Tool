Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmAutoDialog
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmAutoDialog.Designer.vb
        '
        ' Restored / facelifted Auto Dialog form for the KoTOR Tool Restoration.
        '
        ' Original Tool:
        '   Fred Tetra's KotOR Tool
        '
        ' Restoration Project:
        '   KoTOR Tool Restoration Project
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original control names preserved for source compatibility.
        '   - Theme colours are applied at runtime from Themes\DarkSaber.ini.
        '   - Designer keeps fallback colours only for safe VS designer display.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Timer1 As Global.System.Windows.Forms.Timer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(340, 174)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.Label1)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 58)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(18, 14, 18, 14)
            Me.pnlBody.Size = New System.Drawing.Size(338, 114)
            Me.pnlBody.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(18, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(302, 86)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "The time is being sent to the custom.dlg file in your SW:KotOR Override folder ev" &
    "ery 10 seconds. Close this window to stop."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(338, 58)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 55)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(338, 3)
            Me.lblSeparatorTop.TabIndex = 1
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 11)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(306, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Auto Dialog"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Timer1
            '
            Me.Timer1.Interval = 10000
            '
            'frmAutoDialog
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(340, 174)
            Me.Controls.Add(Me.pnlRoot)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAutoDialog"
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Auto Dialog"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace