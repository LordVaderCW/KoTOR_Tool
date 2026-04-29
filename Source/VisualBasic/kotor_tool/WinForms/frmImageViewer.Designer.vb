Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmImageViewer
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmImageViewer.Designer.vb
        '
        ' Restored / facelifted Image Viewer for the KoTOR Tool Restoration.
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

        Friend WithEvents pbox As Global.System.Windows.Forms.PictureBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents Panel1 As Global.System.Windows.Forms.Panel
        Friend WithEvents tbImageInfo As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents lblMipMapCount As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents btnWriteFile As Global.System.Windows.Forms.Button
        Friend WithEvents lblFlag1 As Global.System.Windows.Forms.Label
        Friend WithEvents lblFlag2 As Global.System.Windows.Forms.Label
        Friend WithEvents lblFlag3 As Global.System.Windows.Forms.Label
        Friend WithEvents lblFlag4 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbExportSelectionToTXIfile As Global.System.Windows.Forms.CheckBox

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlInfo As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFlags As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label
        Friend WithEvents lblFlagsTitle As Global.System.Windows.Forms.Label

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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmImageViewer))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.Panel1 = New Global.System.Windows.Forms.Panel()
            Me.pbox = New Global.System.Windows.Forms.PictureBox()
            Me.lblSeparatorBottom = New Global.System.Windows.Forms.Label()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.chkbExportSelectionToTXIfile = New Global.System.Windows.Forms.CheckBox()
            Me.btnWriteFile = New Global.System.Windows.Forms.Button()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.pnlInfo = New Global.System.Windows.Forms.Panel()
            Me.tbImageInfo = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.lblMipMapCount = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.pnlFlags = New Global.System.Windows.Forms.Panel()
            Me.lblFlagsTitle = New Global.System.Windows.Forms.Label()
            Me.lblFlag1 = New Global.System.Windows.Forms.Label()
            Me.lblFlag2 = New Global.System.Windows.Forms.Label()
            Me.lblFlag3 = New Global.System.Windows.Forms.Label()
            Me.lblFlag4 = New Global.System.Windows.Forms.Label()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New Global.System.Windows.Forms.Label()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.pbox, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFooter.SuspendLayout()
            Me.pnlInfo.SuspendLayout()
            Me.pnlFlags.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlInfo)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(560, 620)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.Panel1)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(14, 14, 14, 12)
            Me.pnlBody.Size = New Global.System.Drawing.Size(558, 358)
            Me.pnlBody.TabIndex = 1
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.Panel1.AutoScroll = True
            Me.Panel1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.pbox)
            Me.Panel1.Location = New Global.System.Drawing.Point(14, 14)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New Global.System.Drawing.Size(530, 318)
            Me.Panel1.TabIndex = 0
            '
            'pbox
            '
            Me.pbox.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pbox.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbox.Location = New Global.System.Drawing.Point(0, 0)
            Me.pbox.Name = "pbox"
            Me.pbox.Size = New Global.System.Drawing.Size(96, 80)
            Me.pbox.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbox.TabIndex = 0
            Me.pbox.TabStop = False
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New Global.System.Drawing.Point(14, 344)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New Global.System.Drawing.Size(530, 2)
            Me.lblSeparatorBottom.TabIndex = 1
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.chkbExportSelectionToTXIfile)
            Me.pnlFooter.Controls.Add(Me.btnWriteFile)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 564)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(558, 54)
            Me.pnlFooter.TabIndex = 3
            '
            'chkbExportSelectionToTXIfile
            '
            Me.chkbExportSelectionToTXIfile.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.chkbExportSelectionToTXIfile.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbExportSelectionToTXIfile.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbExportSelectionToTXIfile.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbExportSelectionToTXIfile.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbExportSelectionToTXIfile.Location = New Global.System.Drawing.Point(18, 18)
            Me.chkbExportSelectionToTXIfile.Name = "chkbExportSelectionToTXIfile"
            Me.chkbExportSelectionToTXIfile.Size = New Global.System.Drawing.Size(190, 18)
            Me.chkbExportSelectionToTXIfile.TabIndex = 0
            Me.chkbExportSelectionToTXIfile.Text = "Export Selection to TXI file"
            '
            'btnWriteFile
            '
            Me.btnWriteFile.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnWriteFile.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnWriteFile.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnWriteFile.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnWriteFile.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnWriteFile.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnWriteFile.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnWriteFile.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnWriteFile.Location = New Global.System.Drawing.Point(358, 14)
            Me.btnWriteFile.Name = "btnWriteFile"
            Me.btnWriteFile.Size = New Global.System.Drawing.Size(88, 25)
            Me.btnWriteFile.TabIndex = 1
            Me.btnWriteFile.Text = "Write File"
            Me.btnWriteFile.UseVisualStyleBackColor = False
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnOK.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New Global.System.Drawing.Point(456, 14)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New Global.System.Drawing.Size(84, 25)
            Me.btnOK.TabIndex = 2
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'pnlInfo
            '
            Me.pnlInfo.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlInfo.Controls.Add(Me.tbImageInfo)
            Me.pnlInfo.Controls.Add(Me.Label1)
            Me.pnlInfo.Controls.Add(Me.lblMipMapCount)
            Me.pnlInfo.Controls.Add(Me.Label2)
            Me.pnlInfo.Controls.Add(Me.pnlFlags)
            Me.pnlInfo.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlInfo.Location = New Global.System.Drawing.Point(0, 434)
            Me.pnlInfo.Name = "pnlInfo"
            Me.pnlInfo.Padding = New Global.System.Windows.Forms.Padding(16, 12, 16, 12)
            Me.pnlInfo.Size = New Global.System.Drawing.Size(558, 130)
            Me.pnlInfo.TabIndex = 2
            '
            'tbImageInfo
            '
            Me.tbImageInfo.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.tbImageInfo.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbImageInfo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbImageInfo.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbImageInfo.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbImageInfo.Location = New Global.System.Drawing.Point(16, 16)
            Me.tbImageInfo.Multiline = True
            Me.tbImageInfo.Name = "tbImageInfo"
            Me.tbImageInfo.Size = New Global.System.Drawing.Size(190, 94)
            Me.tbImageInfo.TabIndex = 0
            Me.tbImageInfo.Text = ""
            '
            'Label1
            '
            Me.Label1.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(224, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(138, 18)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Number of mipmaps:"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMipMapCount
            '
            Me.lblMipMapCount.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.lblMipMapCount.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblMipMapCount.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblMipMapCount.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMipMapCount.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblMipMapCount.Location = New Global.System.Drawing.Point(364, 17)
            Me.lblMipMapCount.Name = "lblMipMapCount"
            Me.lblMipMapCount.Size = New Global.System.Drawing.Size(42, 20)
            Me.lblMipMapCount.TabIndex = 2
            Me.lblMipMapCount.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label2.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label2.Location = New Global.System.Drawing.Point(224, 42)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(182, 18)
            Me.Label2.TabIndex = 3
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlFlags
            '
            Me.pnlFlags.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.pnlFlags.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlFlags.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlFlags.Controls.Add(Me.lblFlagsTitle)
            Me.pnlFlags.Controls.Add(Me.lblFlag1)
            Me.pnlFlags.Controls.Add(Me.lblFlag2)
            Me.pnlFlags.Controls.Add(Me.lblFlag3)
            Me.pnlFlags.Controls.Add(Me.lblFlag4)
            Me.pnlFlags.Location = New Global.System.Drawing.Point(224, 66)
            Me.pnlFlags.Name = "pnlFlags"
            Me.pnlFlags.Size = New Global.System.Drawing.Size(182, 44)
            Me.pnlFlags.TabIndex = 4
            '
            'lblFlagsTitle
            '
            Me.lblFlagsTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblFlagsTitle.Font = New Global.System.Drawing.Font("Segoe UI", 7.75!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlagsTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblFlagsTitle.Location = New Global.System.Drawing.Point(8, 11)
            Me.lblFlagsTitle.Name = "lblFlagsTitle"
            Me.lblFlagsTitle.Size = New Global.System.Drawing.Size(54, 18)
            Me.lblFlagsTitle.TabIndex = 0
            Me.lblFlagsTitle.Text = "Flags:"
            Me.lblFlagsTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFlag1
            '
            Me.lblFlag1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFlag1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFlag1.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlag1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblFlag1.Location = New Global.System.Drawing.Point(66, 10)
            Me.lblFlag1.Name = "lblFlag1"
            Me.lblFlag1.Size = New Global.System.Drawing.Size(24, 20)
            Me.lblFlag1.TabIndex = 1
            Me.lblFlag1.Text = "AA"
            Me.lblFlag1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblFlag2
            '
            Me.lblFlag2.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFlag2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFlag2.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlag2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblFlag2.Location = New Global.System.Drawing.Point(92, 10)
            Me.lblFlag2.Name = "lblFlag2"
            Me.lblFlag2.Size = New Global.System.Drawing.Size(24, 20)
            Me.lblFlag2.TabIndex = 2
            Me.lblFlag2.Text = "AA"
            Me.lblFlag2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblFlag3
            '
            Me.lblFlag3.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFlag3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFlag3.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlag3.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblFlag3.Location = New Global.System.Drawing.Point(118, 10)
            Me.lblFlag3.Name = "lblFlag3"
            Me.lblFlag3.Size = New Global.System.Drawing.Size(24, 20)
            Me.lblFlag3.TabIndex = 3
            Me.lblFlag3.Text = "AA"
            Me.lblFlag3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblFlag4
            '
            Me.lblFlag4.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFlag4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFlag4.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlag4.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblFlag4.Location = New Global.System.Drawing.Point(144, 10)
            Me.lblFlag4.Name = "lblFlag4"
            Me.lblFlag4.Size = New Global.System.Drawing.Size(24, 20)
            Me.lblFlag4.TabIndex = 4
            Me.lblFlag4.Text = "AA"
            Me.lblFlag4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
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
            Me.pnlHeader.Size = New Global.System.Drawing.Size(558, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New Global.System.Drawing.Size(558, 2)
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
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(522, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Preview texture assets, inspect image metadata, and export texture files."
            Me.lblSubtitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 18.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(524, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Image Viewer"
            Me.lblTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmImageViewer
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnOK
            Me.ClientSize = New Global.System.Drawing.Size(560, 620)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(456, 472)
            Me.Name = "frmImageViewer"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Image Viewer"

            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.btnWriteFile.Click, AddressOf Me.btnWriteFile_Click

            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.pbox, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlInfo.ResumeLayout(False)
            Me.pnlInfo.PerformLayout()
            Me.pnlFlags.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace