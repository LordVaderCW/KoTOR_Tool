Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmRefSearchResults
        Inherits Global.kotor_tool.frmParent

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderSeparator As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterSeparator As Global.System.Windows.Forms.Label

        Friend WithEvents lbMatches As Global.System.Windows.Forms.ListBox
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents lblNoMatchesFound As Global.System.Windows.Forms.Label
        Friend WithEvents lblDesc As Global.System.Windows.Forms.Label

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
            Me.lbMatches = New System.Windows.Forms.ListBox()
            Me.lblNoMatchesFound = New System.Windows.Forms.Label()
            Me.lblDesc = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.lblFooterSeparator = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(420, 430)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.lbMatches)
            Me.pnlBody.Controls.Add(Me.lblNoMatchesFound)
            Me.pnlBody.Controls.Add(Me.lblDesc)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 88)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
            Me.pnlBody.Size = New System.Drawing.Size(420, 271)
            Me.pnlBody.TabIndex = 1
            '
            'lbMatches
            '
            Me.lbMatches.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbMatches.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.lbMatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbMatches.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbMatches.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbMatches.Location = New System.Drawing.Point(24, 72)
            Me.lbMatches.Name = "lbMatches"
            Me.lbMatches.ScrollAlwaysVisible = True
            Me.lbMatches.Size = New System.Drawing.Size(372, 158)
            Me.lbMatches.TabIndex = 0
            '
            'lblNoMatchesFound
            '
            Me.lblNoMatchesFound.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.lblNoMatchesFound.BackColor = System.Drawing.Color.Transparent
            Me.lblNoMatchesFound.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNoMatchesFound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblNoMatchesFound.Location = New System.Drawing.Point(72, 142)
            Me.lblNoMatchesFound.Name = "lblNoMatchesFound"
            Me.lblNoMatchesFound.Size = New System.Drawing.Size(276, 37)
            Me.lblNoMatchesFound.TabIndex = 2
            Me.lblNoMatchesFound.Text = "No Matches Found"
            Me.lblNoMatchesFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblNoMatchesFound.Visible = False
            '
            'lblDesc
            '
            Me.lblDesc.BackColor = System.Drawing.Color.Transparent
            Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblDesc.Location = New System.Drawing.Point(24, 23)
            Me.lblDesc.Name = "lblDesc"
            Me.lblDesc.Size = New System.Drawing.Size(372, 39)
            Me.lblDesc.TabIndex = 1
            Me.lblDesc.Text = "Double click an item in the list to launch the viewer or editor for it"
            Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.Button1)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 359)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(420, 71)
            Me.pnlFooter.TabIndex = 2
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button1.Location = New System.Drawing.Point(320, 23)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(76, 30)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "OK"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New System.Drawing.Size(420, 1)
            Me.lblFooterSeparator.TabIndex = 2
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
            Me.pnlHeader.Size = New System.Drawing.Size(420, 88)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(24, 48)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(372, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Reference search matches found in selected resources."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(22, 17)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(372, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Search Results"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 85)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(420, 3)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmRefSearchResults
            '
            Me.AcceptButton = Me.Button1
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.Button1
            Me.ClientSize = New System.Drawing.Size(420, 430)
            Me.Controls.Add(Me.pnlRoot)
            Me.MinimumSize = New System.Drawing.Size(428, 447)
            Me.Name = "frmRefSearchResults"
            Me.Text = "Search Results"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace