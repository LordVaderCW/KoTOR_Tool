Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmPathManager
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmPathManager.Designer.vb
        '
        ' Restored / facelifted Path Manager form for the KoTOR Tool
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
        '   - Designer keeps fallback colours only for safe VS designer display.
        '   - Runtime behaviour remains in frmPathManager.vb.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents tbKotorPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnKotorPath As Global.System.Windows.Forms.Button
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As Global.System.Windows.Forms.ToolTip
        Friend WithEvents TabControl1 As Global.kotor_tool.CustomTabControl
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents tbKotorPath2 As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents btnImportPath As Global.System.Windows.Forms.Button
        Friend WithEvents btnSavePath As Global.System.Windows.Forms.Button
        Friend WithEvents tbSavePath As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents tbImageViewerPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnImageViewerPath As Global.System.Windows.Forms.Button
        Friend WithEvents tbImportPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnKotorPath2 As Global.System.Windows.Forms.Button
        Friend WithEvents btnAutoDetectKotor1 As Global.System.Windows.Forms.Button
        Friend WithEvents btnAutoDetectKotor2 As Global.System.Windows.Forms.Button
        Friend WithEvents TabPage3 As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents tbModuleExportPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnModuleExportPath As Global.System.Windows.Forms.Button

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderSeparator As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterSeparator As Global.System.Windows.Forms.Label

        ' Token: 0x06000CD4 RID: 3284 RVA: 0x00283DF8 File Offset: 0x00282DF8
        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x06000D0B RID: 3339 RVA: 0x00284520 File Offset: 0x00283520
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.TabControl1 = New kotor_tool.CustomTabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.btnAutoDetectKotor1 = New System.Windows.Forms.Button()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.btnKotorPath = New System.Windows.Forms.Button()
            Me.tbKotorPath = New System.Windows.Forms.TextBox()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.btnAutoDetectKotor2 = New System.Windows.Forms.Button()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.btnKotorPath2 = New System.Windows.Forms.Button()
            Me.tbKotorPath2 = New System.Windows.Forms.TextBox()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.btnImportPath = New System.Windows.Forms.Button()
            Me.tbSavePath = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.tbImageViewerPath = New System.Windows.Forms.TextBox()
            Me.tbImportPath = New System.Windows.Forms.TextBox()
            Me.btnSavePath = New System.Windows.Forms.Button()
            Me.btnImageViewerPath = New System.Windows.Forms.Button()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.tbModuleExportPath = New System.Windows.Forms.TextBox()
            Me.btnModuleExportPath = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.lblFooterSeparator = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(584, 379)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 70)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(24, 18, 24, 16)
            Me.pnlBody.Size = New System.Drawing.Size(584, 244)
            Me.pnlBody.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(24, 18)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(536, 210)
            Me.TabControl1.TabIndex = 21
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.btnAutoDetectKotor1)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.btnKotorPath)
            Me.TabPage1.Controls.Add(Me.tbKotorPath)
            Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(12)
            Me.TabPage1.Size = New System.Drawing.Size(528, 184)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "SW:KotOR"
            '
            'btnAutoDetectKotor1
            '
            Me.btnAutoDetectKotor1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAutoDetectKotor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAutoDetectKotor1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAutoDetectKotor1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAutoDetectKotor1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAutoDetectKotor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAutoDetectKotor1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAutoDetectKotor1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnAutoDetectKotor1.Location = New System.Drawing.Point(18, 48)
            Me.btnAutoDetectKotor1.Name = "btnAutoDetectKotor1"
            Me.btnAutoDetectKotor1.Size = New System.Drawing.Size(486, 26)
            Me.btnAutoDetectKotor1.TabIndex = 13
            Me.btnAutoDetectKotor1.Text = "Auto Detect KotOR"
            Me.btnAutoDetectKotor1.UseVisualStyleBackColor = False
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(15, 21)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(57, 19)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "KotOR:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnKotorPath
            '
            Me.btnKotorPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnKotorPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnKotorPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnKotorPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnKotorPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnKotorPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnKotorPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnKotorPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnKotorPath.Location = New System.Drawing.Point(462, 18)
            Me.btnKotorPath.Name = "btnKotorPath"
            Me.btnKotorPath.Size = New System.Drawing.Size(42, 24)
            Me.btnKotorPath.TabIndex = 2
            Me.btnKotorPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnKotorPath, "Click to select a new root path for your KotOR installation")
            Me.btnKotorPath.UseVisualStyleBackColor = False
            '
            'tbKotorPath
            '
            Me.tbKotorPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbKotorPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbKotorPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbKotorPath.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbKotorPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbKotorPath.Location = New System.Drawing.Point(78, 20)
            Me.tbKotorPath.Name = "tbKotorPath"
            Me.tbKotorPath.Size = New System.Drawing.Size(378, 20)
            Me.tbKotorPath.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.btnAutoDetectKotor2)
            Me.TabPage2.Controls.Add(Me.Label14)
            Me.TabPage2.Controls.Add(Me.btnKotorPath2)
            Me.TabPage2.Controls.Add(Me.tbKotorPath2)
            Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(12)
            Me.TabPage2.Size = New System.Drawing.Size(528, 184)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "SW:Kotor II TSL"
            '
            'btnAutoDetectKotor2
            '
            Me.btnAutoDetectKotor2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAutoDetectKotor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAutoDetectKotor2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAutoDetectKotor2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAutoDetectKotor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAutoDetectKotor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAutoDetectKotor2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAutoDetectKotor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnAutoDetectKotor2.Location = New System.Drawing.Point(18, 48)
            Me.btnAutoDetectKotor2.Name = "btnAutoDetectKotor2"
            Me.btnAutoDetectKotor2.Size = New System.Drawing.Size(486, 26)
            Me.btnAutoDetectKotor2.TabIndex = 41
            Me.btnAutoDetectKotor2.Text = "Auto Detect KotOR II"
            Me.btnAutoDetectKotor2.UseVisualStyleBackColor = False
            '
            'Label14
            '
            Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(15, 21)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(67, 19)
            Me.Label14.TabIndex = 40
            Me.Label14.Text = "KotOR:TSL"
            '
            'btnKotorPath2
            '
            Me.btnKotorPath2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnKotorPath2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnKotorPath2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnKotorPath2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnKotorPath2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnKotorPath2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnKotorPath2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnKotorPath2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnKotorPath2.Location = New System.Drawing.Point(462, 18)
            Me.btnKotorPath2.Name = "btnKotorPath2"
            Me.btnKotorPath2.Size = New System.Drawing.Size(42, 24)
            Me.btnKotorPath2.TabIndex = 22
            Me.btnKotorPath2.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnKotorPath2, "Click to select a new root path for your KotOR installation")
            Me.btnKotorPath2.UseVisualStyleBackColor = False
            '
            'tbKotorPath2
            '
            Me.tbKotorPath2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbKotorPath2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbKotorPath2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbKotorPath2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbKotorPath2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbKotorPath2.Location = New System.Drawing.Point(88, 20)
            Me.tbKotorPath2.Name = "tbKotorPath2"
            Me.tbKotorPath2.Size = New System.Drawing.Size(368, 20)
            Me.tbKotorPath2.TabIndex = 19
            '
            'TabPage3
            '
            Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage3.Controls.Add(Me.Label6)
            Me.TabPage3.Controls.Add(Me.btnImportPath)
            Me.TabPage3.Controls.Add(Me.tbSavePath)
            Me.TabPage3.Controls.Add(Me.Label5)
            Me.TabPage3.Controls.Add(Me.Label3)
            Me.TabPage3.Controls.Add(Me.tbImageViewerPath)
            Me.TabPage3.Controls.Add(Me.tbImportPath)
            Me.TabPage3.Controls.Add(Me.btnSavePath)
            Me.TabPage3.Controls.Add(Me.btnImageViewerPath)
            Me.TabPage3.Controls.Add(Me.Label15)
            Me.TabPage3.Controls.Add(Me.tbModuleExportPath)
            Me.TabPage3.Controls.Add(Me.btnModuleExportPath)
            Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(12)
            Me.TabPage3.Size = New System.Drawing.Size(528, 184)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Other Paths"
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(24, 55)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(88, 19)
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "Save path"
            '
            'btnImportPath
            '
            Me.btnImportPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnImportPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnImportPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnImportPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnImportPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnImportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnImportPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImportPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnImportPath.Location = New System.Drawing.Point(462, 18)
            Me.btnImportPath.Name = "btnImportPath"
            Me.btnImportPath.Size = New System.Drawing.Size(42, 24)
            Me.btnImportPath.TabIndex = 14
            Me.btnImportPath.Text = "..."
            Me.btnImportPath.UseVisualStyleBackColor = False
            '
            'tbSavePath
            '
            Me.tbSavePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbSavePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbSavePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbSavePath.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbSavePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSavePath.Location = New System.Drawing.Point(128, 55)
            Me.tbSavePath.Name = "tbSavePath"
            Me.tbSavePath.Size = New System.Drawing.Size(328, 20)
            Me.tbSavePath.TabIndex = 15
            '
            'Label5
            '
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(24, 18)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(88, 19)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Import path"
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(24, 92)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(96, 19)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Image Viewer path"
            '
            'tbImageViewerPath
            '
            Me.tbImageViewerPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbImageViewerPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbImageViewerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbImageViewerPath.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbImageViewerPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbImageViewerPath.Location = New System.Drawing.Point(128, 92)
            Me.tbImageViewerPath.Name = "tbImageViewerPath"
            Me.tbImageViewerPath.Size = New System.Drawing.Size(328, 20)
            Me.tbImageViewerPath.TabIndex = 17
            '
            'tbImportPath
            '
            Me.tbImportPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbImportPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbImportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbImportPath.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbImportPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbImportPath.Location = New System.Drawing.Point(128, 18)
            Me.tbImportPath.Name = "tbImportPath"
            Me.tbImportPath.Size = New System.Drawing.Size(328, 20)
            Me.tbImportPath.TabIndex = 13
            '
            'btnSavePath
            '
            Me.btnSavePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSavePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSavePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSavePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSavePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSavePath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSavePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSavePath.Location = New System.Drawing.Point(462, 55)
            Me.btnSavePath.Name = "btnSavePath"
            Me.btnSavePath.Size = New System.Drawing.Size(42, 23)
            Me.btnSavePath.TabIndex = 16
            Me.btnSavePath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnSavePath, "Click to select a new path for saving extracted files")
            Me.btnSavePath.UseVisualStyleBackColor = False
            '
            'btnImageViewerPath
            '
            Me.btnImageViewerPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnImageViewerPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnImageViewerPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnImageViewerPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnImageViewerPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnImageViewerPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnImageViewerPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImageViewerPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnImageViewerPath.Location = New System.Drawing.Point(462, 92)
            Me.btnImageViewerPath.Name = "btnImageViewerPath"
            Me.btnImageViewerPath.Size = New System.Drawing.Size(42, 23)
            Me.btnImageViewerPath.TabIndex = 18
            Me.btnImageViewerPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnImageViewerPath, "Click to select a new path for the KotOR override directory")
            Me.btnImageViewerPath.UseVisualStyleBackColor = False
            '
            'Label15
            '
            Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(24, 129)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(96, 19)
            Me.Label15.TabIndex = 4
            Me.Label15.Text = "Model Export path"
            '
            'tbModuleExportPath
            '
            Me.tbModuleExportPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbModuleExportPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbModuleExportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbModuleExportPath.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbModuleExportPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbModuleExportPath.Location = New System.Drawing.Point(128, 129)
            Me.tbModuleExportPath.Name = "tbModuleExportPath"
            Me.tbModuleExportPath.Size = New System.Drawing.Size(328, 20)
            Me.tbModuleExportPath.TabIndex = 17
            '
            'btnModuleExportPath
            '
            Me.btnModuleExportPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnModuleExportPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnModuleExportPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnModuleExportPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnModuleExportPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnModuleExportPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnModuleExportPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModuleExportPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnModuleExportPath.Location = New System.Drawing.Point(462, 129)
            Me.btnModuleExportPath.Name = "btnModuleExportPath"
            Me.btnModuleExportPath.Size = New System.Drawing.Size(42, 23)
            Me.btnModuleExportPath.TabIndex = 18
            Me.btnModuleExportPath.Text = "..."
            Me.ToolTip1.SetToolTip(Me.btnModuleExportPath, "Click to select a new path for the KotOR override directory")
            Me.btnModuleExportPath.UseVisualStyleBackColor = False
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
            Me.pnlHeader.Size = New System.Drawing.Size(584, 70)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(24, 43)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(536, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Configure game roots, import locations, save folders, viewers, and model export p" & _
                "aths."
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(24, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(536, 25)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Path Manager"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 68)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(584, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 314)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(584, 65)
            Me.pnlFooter.TabIndex = 2
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(332, 21)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(111, 26)
            Me.btnOK.TabIndex = 19
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New System.Drawing.Point(449, 21)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(111, 26)
            Me.btnCancel.TabIndex = 20
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New System.Drawing.Size(584, 1)
            Me.lblFooterSeparator.TabIndex = 21
            '
            'frmPathManager
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(584, 379)
            Me.Controls.Add(Me.pnlRoot)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(1600, 434)
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(600, 314)
            Me.Name = "frmPathManager"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Path Manager"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnKotorPath.Click, AddressOf Me.btnKotorPath_Click
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.btnImportPath.Click, AddressOf Me.btnImportPath_Click
            AddHandler Me.btnSavePath.Click, AddressOf Me.btnSavePath_Click
            AddHandler Me.btnImageViewerPath.Click, AddressOf Me.btnImageViewerPath_Click
            AddHandler Me.btnKotorPath2.Click, AddressOf Me.btnKotorPath2_Click
            AddHandler Me.btnAutoDetectKotor1.Click, AddressOf Me.btnAutoDetectKotor1_Click
            AddHandler Me.btnAutoDetectKotor2.Click, AddressOf Me.btnAutoDetectKotor2_Click
            AddHandler Me.btnModuleExportPath.Click, AddressOf Me.btnModuleExportPath_Click

        End Sub

    End Class
End Namespace
