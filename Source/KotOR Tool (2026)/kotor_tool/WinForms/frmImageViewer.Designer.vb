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
        Friend WithEvents cmbExportFormat As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbPreviewSize As Global.System.Windows.Forms.ComboBox
        Friend WithEvents lblExportFormat As Global.System.Windows.Forms.Label
        Friend WithEvents lblPreviewSize As Global.System.Windows.Forms.Label

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
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
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pbox = New System.Windows.Forms.PictureBox()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.tbImageInfo = New System.Windows.Forms.TextBox()
            Me.cmbPreviewSize = New System.Windows.Forms.ComboBox()
            Me.pnlFlags = New System.Windows.Forms.Panel()
            Me.lblFlagsTitle = New System.Windows.Forms.Label()
            Me.lblFlag1 = New System.Windows.Forms.Label()
            Me.lblFlag2 = New System.Windows.Forms.Label()
            Me.lblFlag3 = New System.Windows.Forms.Label()
            Me.lblFlag4 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblMipMapCount = New System.Windows.Forms.Label()
            Me.lblPreviewSize = New System.Windows.Forms.Label()
            Me.cmbExportFormat = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblExportFormat = New System.Windows.Forms.Label()
            Me.chkbExportSelectionToTXIfile = New System.Windows.Forms.CheckBox()
            Me.btnWriteFile = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.pbox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFooter.SuspendLayout()
            Me.pnlFlags.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(784, 714)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.Panel1)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 118)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(14, 14, 14, 12)
            Me.pnlBody.Size = New System.Drawing.Size(782, 456)
            Me.pnlBody.TabIndex = 1
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel1.AutoScroll = True
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.pbox)
            Me.Panel1.Location = New System.Drawing.Point(14, 14)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(754, 416)
            Me.Panel1.TabIndex = 0
            Me.Panel1.TabStop = True
            '
            'pbox
            '
            Me.pbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbox.Location = New System.Drawing.Point(328, 188)
            Me.pbox.Name = "pbox"
            Me.pbox.Size = New System.Drawing.Size(96, 80)
            Me.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbox.TabIndex = 0
            Me.pbox.TabStop = False
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(14, 442)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(754, 2)
            Me.lblSeparatorBottom.TabIndex = 1
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.tbImageInfo)
            Me.pnlFooter.Controls.Add(Me.cmbPreviewSize)
            Me.pnlFooter.Controls.Add(Me.pnlFlags)
            Me.pnlFooter.Controls.Add(Me.Label1)
            Me.pnlFooter.Controls.Add(Me.lblMipMapCount)
            Me.pnlFooter.Controls.Add(Me.lblPreviewSize)
            Me.pnlFooter.Controls.Add(Me.cmbExportFormat)
            Me.pnlFooter.Controls.Add(Me.Label2)
            Me.pnlFooter.Controls.Add(Me.lblExportFormat)
            Me.pnlFooter.Controls.Add(Me.chkbExportSelectionToTXIfile)
            Me.pnlFooter.Controls.Add(Me.btnWriteFile)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 574)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(782, 138)
            Me.pnlFooter.TabIndex = 3
            '
            'tbImageInfo
            '
            Me.tbImageInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tbImageInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbImageInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbImageInfo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbImageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbImageInfo.Location = New System.Drawing.Point(494, 17)
            Me.tbImageInfo.Multiline = True
            Me.tbImageInfo.Name = "tbImageInfo"
            Me.tbImageInfo.Size = New System.Drawing.Size(270, 59)
            Me.tbImageInfo.TabIndex = 0
            '
            'cmbPreviewSize
            '
            Me.cmbPreviewSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbPreviewSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.cmbPreviewSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPreviewSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPreviewSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPreviewSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbPreviewSize.FormattingEnabled = True
            Me.cmbPreviewSize.Items.AddRange(New Object() {"Actual", "Fit", "1024 x 768", "1280 x 720", "1280 x 1024", "1600 x 900", "1920 x 1080", "Custom Zoom"})
            Me.cmbPreviewSize.Location = New System.Drawing.Point(446, 100)
            Me.cmbPreviewSize.Name = "cmbPreviewSize"
            Me.cmbPreviewSize.Size = New System.Drawing.Size(120, 21)
            Me.cmbPreviewSize.TabIndex = 4
            '
            'pnlFlags
            '
            Me.pnlFlags.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlFlags.Controls.Add(Me.lblFlagsTitle)
            Me.pnlFlags.Controls.Add(Me.lblFlag1)
            Me.pnlFlags.Controls.Add(Me.lblFlag2)
            Me.pnlFlags.Controls.Add(Me.lblFlag3)
            Me.pnlFlags.Controls.Add(Me.lblFlag4)
            Me.pnlFlags.Location = New System.Drawing.Point(259, 17)
            Me.pnlFlags.Name = "pnlFlags"
            Me.pnlFlags.Size = New System.Drawing.Size(218, 59)
            Me.pnlFlags.TabIndex = 4
            '
            'lblFlagsTitle
            '
            Me.lblFlagsTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblFlagsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblFlagsTitle.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlagsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblFlagsTitle.Location = New System.Drawing.Point(8, 10)
            Me.lblFlagsTitle.Name = "lblFlagsTitle"
            Me.lblFlagsTitle.Size = New System.Drawing.Size(87, 38)
            Me.lblFlagsTitle.TabIndex = 0
            Me.lblFlagsTitle.Text = "Flags:"
            Me.lblFlagsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblFlag1
            '
            Me.lblFlag1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFlag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFlag1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlag1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblFlag1.Location = New System.Drawing.Point(101, 19)
            Me.lblFlag1.Name = "lblFlag1"
            Me.lblFlag1.Size = New System.Drawing.Size(24, 20)
            Me.lblFlag1.TabIndex = 1
            Me.lblFlag1.Text = "AA"
            Me.lblFlag1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblFlag2
            '
            Me.lblFlag2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFlag2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFlag2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlag2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblFlag2.Location = New System.Drawing.Point(127, 19)
            Me.lblFlag2.Name = "lblFlag2"
            Me.lblFlag2.Size = New System.Drawing.Size(24, 20)
            Me.lblFlag2.TabIndex = 2
            Me.lblFlag2.Text = "AA"
            Me.lblFlag2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblFlag3
            '
            Me.lblFlag3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFlag3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFlag3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlag3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblFlag3.Location = New System.Drawing.Point(153, 19)
            Me.lblFlag3.Name = "lblFlag3"
            Me.lblFlag3.Size = New System.Drawing.Size(24, 20)
            Me.lblFlag3.TabIndex = 3
            Me.lblFlag3.Text = "AA"
            Me.lblFlag3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblFlag4
            '
            Me.lblFlag4.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblFlag4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblFlag4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFlag4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblFlag4.Location = New System.Drawing.Point(179, 19)
            Me.lblFlag4.Name = "lblFlag4"
            Me.lblFlag4.Size = New System.Drawing.Size(24, 20)
            Me.lblFlag4.TabIndex = 4
            Me.lblFlag4.Text = "AA"
            Me.lblFlag4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(15, 45)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(134, 18)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Number of mipmaps:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMipMapCount
            '
            Me.lblMipMapCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.lblMipMapCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblMipMapCount.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMipMapCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblMipMapCount.Location = New System.Drawing.Point(155, 44)
            Me.lblMipMapCount.Name = "lblMipMapCount"
            Me.lblMipMapCount.Size = New System.Drawing.Size(42, 20)
            Me.lblMipMapCount.TabIndex = 2
            Me.lblMipMapCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblPreviewSize
            '
            Me.lblPreviewSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPreviewSize.BackColor = System.Drawing.Color.Transparent
            Me.lblPreviewSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPreviewSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblPreviewSize.Location = New System.Drawing.Point(394, 102)
            Me.lblPreviewSize.Name = "lblPreviewSize"
            Me.lblPreviewSize.Size = New System.Drawing.Size(48, 18)
            Me.lblPreviewSize.TabIndex = 3
            Me.lblPreviewSize.Text = "Preview"
            Me.lblPreviewSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbExportFormat
            '
            Me.cmbExportFormat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbExportFormat.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.cmbExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbExportFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbExportFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbExportFormat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbExportFormat.FormattingEnabled = True
            Me.cmbExportFormat.Items.AddRange(New Object() {"TGA", "PNG", "JPG", "TPC"})
            Me.cmbExportFormat.Location = New System.Drawing.Point(304, 100)
            Me.cmbExportFormat.Name = "cmbExportFormat"
            Me.cmbExportFormat.Size = New System.Drawing.Size(74, 21)
            Me.cmbExportFormat.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
            Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(15, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(182, 18)
            Me.Label2.TabIndex = 3
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblExportFormat
            '
            Me.lblExportFormat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblExportFormat.BackColor = System.Drawing.Color.Transparent
            Me.lblExportFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExportFormat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblExportFormat.Location = New System.Drawing.Point(256, 102)
            Me.lblExportFormat.Name = "lblExportFormat"
            Me.lblExportFormat.Size = New System.Drawing.Size(44, 18)
            Me.lblExportFormat.TabIndex = 1
            Me.lblExportFormat.Text = "Format"
            Me.lblExportFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbExportSelectionToTXIfile
            '
            Me.chkbExportSelectionToTXIfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.chkbExportSelectionToTXIfile.BackColor = System.Drawing.Color.Transparent
            Me.chkbExportSelectionToTXIfile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbExportSelectionToTXIfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbExportSelectionToTXIfile.Location = New System.Drawing.Point(18, 102)
            Me.chkbExportSelectionToTXIfile.Name = "chkbExportSelectionToTXIfile"
            Me.chkbExportSelectionToTXIfile.Size = New System.Drawing.Size(190, 18)
            Me.chkbExportSelectionToTXIfile.TabIndex = 0
            Me.chkbExportSelectionToTXIfile.Text = "Export Selection to TXI file"
            Me.chkbExportSelectionToTXIfile.UseVisualStyleBackColor = False
            '
            'btnWriteFile
            '
            Me.btnWriteFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnWriteFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnWriteFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnWriteFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnWriteFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnWriteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnWriteFile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnWriteFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnWriteFile.Location = New System.Drawing.Point(582, 98)
            Me.btnWriteFile.Name = "btnWriteFile"
            Me.btnWriteFile.Size = New System.Drawing.Size(88, 25)
            Me.btnWriteFile.TabIndex = 5
            Me.btnWriteFile.Text = "Export"
            Me.btnWriteFile.UseVisualStyleBackColor = False
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(680, 98)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(84, 25)
            Me.btnOK.TabIndex = 6
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.Label3)
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(782, 118)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 116)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(782, 2)
            Me.lblSeparatorTop.TabIndex = 2
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 45)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(746, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Preview texture assets, inspect image metadata, and export texture files."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(748, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Image Viewer"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoEllipsis = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(19, 73)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(294, 18)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Zoom Controls: Left CTRL + Mouse Wheel Up/Down"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmImageViewer
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnOK
            Me.ClientSize = New System.Drawing.Size(784, 714)
            Me.Controls.Add(Me.pnlRoot)
            Me.MinimumSize = New System.Drawing.Size(800, 600)
            Me.Name = "frmImageViewer"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Image Viewer"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.pbox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlFooter.PerformLayout()
            Me.pnlFlags.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Label3 As System.Windows.Forms.Label
    End Class

End Namespace
