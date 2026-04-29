Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmMapInfoStatus
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmMapInfoStatus.Designer.vb
        '
        ' Restored / facelifted MapInfo Status viewer for the KoTOR Tool
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
        '   - Original control names preserved for source compatibility.
        '   - Theme colours are applied at runtime from Themes\DarkSaber.ini.
        '   - Designer keeps fallback colours only for safe VS designer display.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents dgMapInfoStatus As Global.System.Windows.Forms.DataGrid

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmMapInfoStatus))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.dgMapInfoStatus = New Global.System.Windows.Forms.DataGrid()
            Me.lblSeparatorBottom = New Global.System.Windows.Forms.Label()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New Global.System.Windows.Forms.Label()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            CType(Me.dgMapInfoStatus, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(640, 420)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.dgMapInfoStatus)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(14, 14, 14, 12)
            Me.pnlBody.Size = New Global.System.Drawing.Size(638, 342)
            Me.pnlBody.TabIndex = 1
            '
            'dgMapInfoStatus
            '
            Me.dgMapInfoStatus.AlternatingBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.dgMapInfoStatus.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.dgMapInfoStatus.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.dgMapInfoStatus.BackgroundColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.dgMapInfoStatus.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgMapInfoStatus.CaptionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgMapInfoStatus.CaptionFont = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgMapInfoStatus.CaptionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgMapInfoStatus.CaptionText = "MapInfo Status"
            Me.dgMapInfoStatus.CaptionVisible = False
            Me.dgMapInfoStatus.DataMember = ""
            Me.dgMapInfoStatus.FlatMode = True
            Me.dgMapInfoStatus.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgMapInfoStatus.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgMapInfoStatus.GridLineColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.dgMapInfoStatus.HeaderBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.dgMapInfoStatus.HeaderForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgMapInfoStatus.LinkColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.dgMapInfoStatus.Location = New Global.System.Drawing.Point(14, 14)
            Me.dgMapInfoStatus.Name = "dgMapInfoStatus"
            Me.dgMapInfoStatus.ParentRowsBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.dgMapInfoStatus.ParentRowsForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.dgMapInfoStatus.SelectionBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.dgMapInfoStatus.SelectionForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.dgMapInfoStatus.Size = New Global.System.Drawing.Size(610, 304)
            Me.dgMapInfoStatus.TabIndex = 0
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New Global.System.Drawing.Point(14, 328)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New Global.System.Drawing.Size(610, 2)
            Me.lblSeparatorBottom.TabIndex = 1
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New Global.System.Drawing.Size(638, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New Global.System.Drawing.Size(638, 2)
            Me.lblSeparatorTop.TabIndex = 2
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New Global.System.Drawing.Font("Segoe UI", 8.75!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(18, 45)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(602, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Review module map information status entries."
            Me.lblSubtitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 18.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(604, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "MapInfo Status"
            Me.lblTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmMapInfoStatus
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New Global.System.Drawing.Size(640, 420)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(560, 340)
            Me.Name = "frmMapInfoStatus"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "MapInfo Status"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            CType(Me.dgMapInfoStatus, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace