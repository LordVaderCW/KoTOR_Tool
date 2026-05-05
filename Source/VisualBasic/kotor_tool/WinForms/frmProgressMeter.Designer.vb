Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmProgressMeter
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmProgressMeter.Designer.vb
        '
        ' Restored / facelifted operation progress dialog for the KoTOR Tool
        ' Restoration Project.
        '
        ' Original Tool:
        '   Fred Tetra's KotOR Tool
        '
        ' Restoration Project:
        '   KoTOR Tool Restoration Project
        '
        ' Notes:
        '   - VS2010 / .NET Framework 2.0 compatible.
        '   - Original public-facing progress meter controls preserved.
        '   - Details log is now always visible; no expanding details button.
        '   - Designer keeps fallback DarkSaber colours only for safe VS display.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlDetailsHost As Global.System.Windows.Forms.Panel

        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderSeparator As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterSeparator As Global.System.Windows.Forms.Label
        Friend WithEvents lblDetailsSeparator As Global.System.Windows.Forms.Label

        Friend WithEvents pbar As Global.kotor_tool.CustomProgressBar
        Friend WithEvents lblStatus As Global.System.Windows.Forms.Label
        Friend WithEvents lblMsg As Global.System.Windows.Forms.Label
        Friend WithEvents lblPercent As Global.System.Windows.Forms.Label
        Friend WithEvents lblOperation As Global.System.Windows.Forms.Label
        Friend WithEvents lblElapsed As Global.System.Windows.Forms.Label
        Friend WithEvents lblDetailsCaption As Global.System.Windows.Forms.Label

        Friend WithEvents tbDetails As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button

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
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.lblElapsed = New System.Windows.Forms.Label()
            Me.lblOperation = New System.Windows.Forms.Label()
            Me.lblPercent = New System.Windows.Forms.Label()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.pbar = New kotor_tool.CustomProgressBar()
            Me.lblMsg = New System.Windows.Forms.Label()
            Me.pnlDetailsHost = New System.Windows.Forms.Panel()
            Me.tbDetails = New System.Windows.Forms.TextBox()
            Me.lblDetailsCaption = New System.Windows.Forms.Label()
            Me.lblDetailsSeparator = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterSeparator = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlDetailsHost.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlDetailsHost)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(424, 388)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.lblElapsed)
            Me.pnlBody.Controls.Add(Me.lblOperation)
            Me.pnlBody.Controls.Add(Me.lblPercent)
            Me.pnlBody.Controls.Add(Me.lblStatus)
            Me.pnlBody.Controls.Add(Me.pbar)
            Me.pnlBody.Controls.Add(Me.lblMsg)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 72)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(18, 16, 18, 12)
            Me.pnlBody.Size = New System.Drawing.Size(422, 122)
            Me.pnlBody.TabIndex = 1
            '
            'lblElapsed
            '
            Me.lblElapsed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblElapsed.BackColor = System.Drawing.Color.Transparent
            Me.lblElapsed.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblElapsed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblElapsed.Location = New System.Drawing.Point(287, 97)
            Me.lblElapsed.Name = "lblElapsed"
            Me.lblElapsed.Size = New System.Drawing.Size(117, 18)
            Me.lblElapsed.TabIndex = 5
            Me.lblElapsed.Text = "00:00"
            Me.lblElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblOperation
            '
            Me.lblOperation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblOperation.AutoEllipsis = True
            Me.lblOperation.BackColor = System.Drawing.Color.Transparent
            Me.lblOperation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOperation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblOperation.Location = New System.Drawing.Point(18, 97)
            Me.lblOperation.Name = "lblOperation"
            Me.lblOperation.Size = New System.Drawing.Size(263, 18)
            Me.lblOperation.TabIndex = 4
            Me.lblOperation.Text = "Preparing operation..."
            Me.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblPercent
            '
            Me.lblPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPercent.BackColor = System.Drawing.Color.Transparent
            Me.lblPercent.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPercent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblPercent.Location = New System.Drawing.Point(339, 14)
            Me.lblPercent.Name = "lblPercent"
            Me.lblPercent.Size = New System.Drawing.Size(65, 21)
            Me.lblPercent.TabIndex = 3
            Me.lblPercent.Text = "0%"
            Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblStatus
            '
            Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblStatus.AutoEllipsis = True
            Me.lblStatus.BackColor = System.Drawing.Color.Transparent
            Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblStatus.Location = New System.Drawing.Point(18, 34)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(386, 18)
            Me.lblStatus.TabIndex = 1
            Me.lblStatus.Text = "Waiting for task..."
            Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pbar
            '
            Me.pbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
            Me.pbar.Location = New System.Drawing.Point(18, 55)
            Me.pbar.MinimumSize = New System.Drawing.Size(40, 12)
            Me.pbar.Name = "pbar"
            Me.pbar.ShineBottomColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.pbar.ShineTopColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.pbar.Size = New System.Drawing.Size(386, 17)
            Me.pbar.SweepColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(180, Byte), Integer))
            Me.pbar.TabIndex = 2
            Me.pbar.TrackBottomColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(15, Byte), Integer))
            Me.pbar.TrackShadowColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.pbar.TrackTopColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer))
            '
            'lblMsg
            '
            Me.lblMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblMsg.AutoEllipsis = True
            Me.lblMsg.BackColor = System.Drawing.Color.Transparent
            Me.lblMsg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblMsg.Location = New System.Drawing.Point(18, 12)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New System.Drawing.Size(315, 22)
            Me.lblMsg.TabIndex = 0
            Me.lblMsg.Text = "Processing"
            Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlDetailsHost
            '
            Me.pnlDetailsHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlDetailsHost.Controls.Add(Me.tbDetails)
            Me.pnlDetailsHost.Controls.Add(Me.lblDetailsCaption)
            Me.pnlDetailsHost.Controls.Add(Me.lblDetailsSeparator)
            Me.pnlDetailsHost.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlDetailsHost.Location = New System.Drawing.Point(0, 194)
            Me.pnlDetailsHost.Name = "pnlDetailsHost"
            Me.pnlDetailsHost.Padding = New System.Windows.Forms.Padding(18, 10, 18, 12)
            Me.pnlDetailsHost.Size = New System.Drawing.Size(422, 130)
            Me.pnlDetailsHost.TabIndex = 2
            Me.pnlDetailsHost.Visible = True
            '
            'tbDetails
            '
            Me.tbDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDetails.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbDetails.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDetails.Location = New System.Drawing.Point(18, 35)
            Me.tbDetails.Multiline = True
            Me.tbDetails.Name = "tbDetails"
            Me.tbDetails.ReadOnly = True
            Me.tbDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbDetails.Size = New System.Drawing.Size(386, 83)
            Me.tbDetails.TabIndex = 2
            '
            'lblDetailsCaption
            '
            Me.lblDetailsCaption.AutoEllipsis = True
            Me.lblDetailsCaption.BackColor = System.Drawing.Color.Transparent
            Me.lblDetailsCaption.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblDetailsCaption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetailsCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblDetailsCaption.Location = New System.Drawing.Point(18, 11)
            Me.lblDetailsCaption.Name = "lblDetailsCaption"
            Me.lblDetailsCaption.Size = New System.Drawing.Size(386, 24)
            Me.lblDetailsCaption.TabIndex = 1
            Me.lblDetailsCaption.Text = "Operation Log"
            Me.lblDetailsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDetailsSeparator
            '
            Me.lblDetailsSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblDetailsSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblDetailsSeparator.Location = New System.Drawing.Point(18, 10)
            Me.lblDetailsSeparator.Name = "lblDetailsSeparator"
            Me.lblDetailsSeparator.Size = New System.Drawing.Size(386, 1)
            Me.lblDetailsSeparator.TabIndex = 0
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 324)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(422, 62)
            Me.pnlFooter.TabIndex = 3
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New System.Drawing.Size(422, 1)
            Me.lblFooterSeparator.TabIndex = 0
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(320, 18)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(84, 29)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderSeparator)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(422, 72)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 39)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(386, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Please wait while KoTOR Tool completes the current task."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 11)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(388, 27)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Operation Progress"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 70)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(422, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmProgressMeter
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(424, 388)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(426, 390)
            Me.Name = "frmProgressMeter"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Operation Progress"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlDetailsHost.ResumeLayout(False)
            Me.pnlDetailsHost.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace
