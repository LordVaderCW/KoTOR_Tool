Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmAppearanceWizard
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' frmAppearanceWizard.Designer.vb
        '
        ' Restored / facelifted Appearance Wizard for the KoTOR Tool Restoration.
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
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents tbName As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbxGender As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxSizes As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxEnvMap As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxMovementRate As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxModelType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbHitRadius As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbPerspace As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbprefatkdist As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCreperspace As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxModelNaming As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbBaseModelName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents tbHeadNum As Global.System.Windows.Forms.TextBox
        Friend WithEvents TabControl1 As Global.System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As Global.System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label13 As Global.System.Windows.Forms.Label
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents tbMa As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTa As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMb As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTb As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTd As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMd As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMc As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTc As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTf As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMf As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMe As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTe As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTg As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMg As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMh As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTh As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTi As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMi As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbMj As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTj As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbEvilTexture As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents chkbAutoCreateSeqEntries As Global.System.Windows.Forms.CheckBox

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label

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
            Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.kotor_tool.frmAppearanceWizard))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
            Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
            Me.chkbAutoCreateSeqEntries = New Global.System.Windows.Forms.CheckBox()
            Me.tbName = New Global.System.Windows.Forms.TextBox()
            Me.tbHeadNum = New Global.System.Windows.Forms.TextBox()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.cmbxModelNaming = New Global.System.Windows.Forms.ComboBox()
            Me.tbBaseModelName = New Global.System.Windows.Forms.TextBox()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.tbCreperspace = New Global.System.Windows.Forms.TextBox()
            Me.tbprefatkdist = New Global.System.Windows.Forms.TextBox()
            Me.tbPerspace = New Global.System.Windows.Forms.TextBox()
            Me.tbHitRadius = New Global.System.Windows.Forms.TextBox()
            Me.Label10 = New Global.System.Windows.Forms.Label()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.cmbxModelType = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxMovementRate = New Global.System.Windows.Forms.ComboBox()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.cmbxEnvMap = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxSizes = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxGender = New Global.System.Windows.Forms.ComboBox()
            Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.Label13 = New Global.System.Windows.Forms.Label()
            Me.tbMa = New Global.System.Windows.Forms.TextBox()
            Me.tbTa = New Global.System.Windows.Forms.TextBox()
            Me.tbMb = New Global.System.Windows.Forms.TextBox()
            Me.tbTb = New Global.System.Windows.Forms.TextBox()
            Me.tbTd = New Global.System.Windows.Forms.TextBox()
            Me.tbMd = New Global.System.Windows.Forms.TextBox()
            Me.tbMc = New Global.System.Windows.Forms.TextBox()
            Me.tbTc = New Global.System.Windows.Forms.TextBox()
            Me.tbTf = New Global.System.Windows.Forms.TextBox()
            Me.tbMf = New Global.System.Windows.Forms.TextBox()
            Me.tbMe = New Global.System.Windows.Forms.TextBox()
            Me.tbTe = New Global.System.Windows.Forms.TextBox()
            Me.tbTg = New Global.System.Windows.Forms.TextBox()
            Me.tbMg = New Global.System.Windows.Forms.TextBox()
            Me.tbMh = New Global.System.Windows.Forms.TextBox()
            Me.tbTh = New Global.System.Windows.Forms.TextBox()
            Me.tbTi = New Global.System.Windows.Forms.TextBox()
            Me.tbMi = New Global.System.Windows.Forms.TextBox()
            Me.tbMj = New Global.System.Windows.Forms.TextBox()
            Me.tbTj = New Global.System.Windows.Forms.TextBox()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.Label16 = New Global.System.Windows.Forms.Label()
            Me.Label17 = New Global.System.Windows.Forms.Label()
            Me.Label18 = New Global.System.Windows.Forms.Label()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.Label20 = New Global.System.Windows.Forms.Label()
            Me.Label21 = New Global.System.Windows.Forms.Label()
            Me.Label22 = New Global.System.Windows.Forms.Label()
            Me.Label23 = New Global.System.Windows.Forms.Label()
            Me.Label24 = New Global.System.Windows.Forms.Label()
            Me.tbEvilTexture = New Global.System.Windows.Forms.TextBox()
            Me.Label25 = New Global.System.Windows.Forms.Label()
            Me.lblSeparatorBottom = New Global.System.Windows.Forms.Label()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New Global.System.Windows.Forms.Label()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(482, 652)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.TabControl1)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 88)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(16, 16, 16, 12)
            Me.pnlBody.Size = New Global.System.Drawing.Size(480, 504)
            Me.pnlBody.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabControl1.Location = New Global.System.Drawing.Point(16, 16)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Padding = New Global.System.Drawing.Point(10, 3)
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Global.System.Drawing.Size(448, 474)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.chkbAutoCreateSeqEntries)
            Me.TabPage1.Controls.Add(Me.tbName)
            Me.TabPage1.Controls.Add(Me.tbHeadNum)
            Me.TabPage1.Controls.Add(Me.Label12)
            Me.TabPage1.Controls.Add(Me.cmbxModelNaming)
            Me.TabPage1.Controls.Add(Me.tbBaseModelName)
            Me.TabPage1.Controls.Add(Me.Label11)
            Me.TabPage1.Controls.Add(Me.tbCreperspace)
            Me.TabPage1.Controls.Add(Me.tbprefatkdist)
            Me.TabPage1.Controls.Add(Me.tbPerspace)
            Me.TabPage1.Controls.Add(Me.tbHitRadius)
            Me.TabPage1.Controls.Add(Me.Label10)
            Me.TabPage1.Controls.Add(Me.Label9)
            Me.TabPage1.Controls.Add(Me.Label8)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.Label6)
            Me.TabPage1.Controls.Add(Me.cmbxModelType)
            Me.TabPage1.Controls.Add(Me.cmbxMovementRate)
            Me.TabPage1.Controls.Add(Me.Label5)
            Me.TabPage1.Controls.Add(Me.Label4)
            Me.TabPage1.Controls.Add(Me.Label3)
            Me.TabPage1.Controls.Add(Me.Label2)
            Me.TabPage1.Controls.Add(Me.Label1)
            Me.TabPage1.Controls.Add(Me.cmbxEnvMap)
            Me.TabPage1.Controls.Add(Me.cmbxSizes)
            Me.TabPage1.Controls.Add(Me.cmbxGender)
            Me.TabPage1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New Global.System.Windows.Forms.Padding(8)
            Me.TabPage1.Size = New Global.System.Drawing.Size(440, 448)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "General"
            '
            'chkbAutoCreateSeqEntries
            '
            Me.chkbAutoCreateSeqEntries.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbAutoCreateSeqEntries.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbAutoCreateSeqEntries.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.chkbAutoCreateSeqEntries.Location = New Global.System.Drawing.Point(240, 156)
            Me.chkbAutoCreateSeqEntries.Name = "chkbAutoCreateSeqEntries"
            Me.chkbAutoCreateSeqEntries.Size = New Global.System.Drawing.Size(184, 19)
            Me.chkbAutoCreateSeqEntries.TabIndex = 13
            Me.chkbAutoCreateSeqEntries.Text = "Auto-create sequential entries"
            Me.chkbAutoCreateSeqEntries.UseVisualStyleBackColor = False
            Me.chkbAutoCreateSeqEntries.Visible = False
            '
            'tbName
            '
            Me.tbName.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbName.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbName.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbName.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbName.Location = New Global.System.Drawing.Point(168, 24)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New Global.System.Drawing.Size(256, 22)
            Me.tbName.TabIndex = 0
            '
            'tbHeadNum
            '
            Me.tbHeadNum.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbHeadNum.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbHeadNum.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbHeadNum.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbHeadNum.Location = New Global.System.Drawing.Point(168, 92)
            Me.tbHeadNum.Name = "tbHeadNum"
            Me.tbHeadNum.Size = New Global.System.Drawing.Size(256, 22)
            Me.tbHeadNum.TabIndex = 2
            Me.tbHeadNum.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label12
            '
            Me.Label12.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label12.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label12.Location = New Global.System.Drawing.Point(16, 92)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(136, 18)
            Me.Label12.TabIndex = 3
            Me.Label12.Text = "Head Number"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxModelNaming
            '
            Me.cmbxModelNaming.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxModelNaming.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxModelNaming.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxModelNaming.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxModelNaming.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxModelNaming.Items.AddRange(New Object() {"Use name for all model entries", "Create sequential model entries"})
            Me.cmbxModelNaming.Location = New Global.System.Drawing.Point(240, 126)
            Me.cmbxModelNaming.Name = "cmbxModelNaming"
            Me.cmbxModelNaming.Size = New Global.System.Drawing.Size(184, 21)
            Me.cmbxModelNaming.TabIndex = 4
            '
            'tbBaseModelName
            '
            Me.tbBaseModelName.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbBaseModelName.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbBaseModelName.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbBaseModelName.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbBaseModelName.Location = New Global.System.Drawing.Point(168, 126)
            Me.tbBaseModelName.Name = "tbBaseModelName"
            Me.tbBaseModelName.Size = New Global.System.Drawing.Size(56, 22)
            Me.tbBaseModelName.TabIndex = 3
            '
            'Label11
            '
            Me.Label11.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label11.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label11.Location = New Global.System.Drawing.Point(16, 126)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(136, 19)
            Me.Label11.TabIndex = 3
            Me.Label11.Text = "Base Model Name"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbCreperspace
            '
            Me.tbCreperspace.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbCreperspace.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCreperspace.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbCreperspace.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCreperspace.Location = New Global.System.Drawing.Point(168, 382)
            Me.tbCreperspace.Name = "tbCreperspace"
            Me.tbCreperspace.Size = New Global.System.Drawing.Size(72, 20)
            Me.tbCreperspace.TabIndex = 11
            Me.tbCreperspace.Text = "****"
            Me.tbCreperspace.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbprefatkdist
            '
            Me.tbprefatkdist.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbprefatkdist.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbprefatkdist.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbprefatkdist.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbprefatkdist.Location = New Global.System.Drawing.Point(168, 416)
            Me.tbprefatkdist.Name = "tbprefatkdist"
            Me.tbprefatkdist.Size = New Global.System.Drawing.Size(72, 20)
            Me.tbprefatkdist.TabIndex = 12
            Me.tbprefatkdist.Text = "****"
            Me.tbprefatkdist.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbPerspace
            '
            Me.tbPerspace.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbPerspace.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbPerspace.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbPerspace.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbPerspace.Location = New Global.System.Drawing.Point(168, 348)
            Me.tbPerspace.Name = "tbPerspace"
            Me.tbPerspace.Size = New Global.System.Drawing.Size(72, 20)
            Me.tbPerspace.TabIndex = 10
            Me.tbPerspace.Text = "****"
            Me.tbPerspace.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbHitRadius
            '
            Me.tbHitRadius.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbHitRadius.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbHitRadius.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbHitRadius.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbHitRadius.Location = New Global.System.Drawing.Point(168, 314)
            Me.tbHitRadius.Name = "tbHitRadius"
            Me.tbHitRadius.Size = New Global.System.Drawing.Size(72, 20)
            Me.tbHitRadius.TabIndex = 9
            Me.tbHitRadius.Text = "****"
            Me.tbHitRadius.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label10
            '
            Me.Label10.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label10.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label10.Location = New Global.System.Drawing.Point(16, 280)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Global.System.Drawing.Size(136, 18)
            Me.Label10.TabIndex = 3
            Me.Label10.Text = "Model Type"
            Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label9
            '
            Me.Label9.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label9.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label9.Location = New Global.System.Drawing.Point(16, 416)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(146, 19)
            Me.Label9.TabIndex = 3
            Me.Label9.Text = "Preferred Attack Distance"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label8.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label8.Location = New Global.System.Drawing.Point(16, 382)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(146, 19)
            Me.Label8.TabIndex = 3
            Me.Label8.Text = "CRep Personal Space"
            Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label7
            '
            Me.Label7.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label7.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label7.Location = New Global.System.Drawing.Point(16, 348)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(136, 19)
            Me.Label7.TabIndex = 3
            Me.Label7.Text = "Personal Space"
            Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label6
            '
            Me.Label6.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label6.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label6.Location = New Global.System.Drawing.Point(16, 314)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(136, 18)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "Hit Radius"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxModelType
            '
            Me.cmbxModelType.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxModelType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxModelType.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxModelType.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxModelType.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxModelType.Items.AddRange(New Object() {"B", "F", "L", "S"})
            Me.cmbxModelType.Location = New Global.System.Drawing.Point(168, 280)
            Me.cmbxModelType.Name = "cmbxModelType"
            Me.cmbxModelType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.cmbxModelType.Size = New Global.System.Drawing.Size(256, 21)
            Me.cmbxModelType.TabIndex = 8
            '
            'cmbxMovementRate
            '
            Me.cmbxMovementRate.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxMovementRate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMovementRate.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxMovementRate.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxMovementRate.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxMovementRate.Items.AddRange(New Object() {"No Movement", "Wee Folk", "Very Slow", "Slow", "Norm/Default", "Fast", "Very Fast", "Player", "Huge", "Giant", "Fastest"})
            Me.cmbxMovementRate.Location = New Global.System.Drawing.Point(168, 246)
            Me.cmbxMovementRate.Name = "cmbxMovementRate"
            Me.cmbxMovementRate.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.cmbxMovementRate.Size = New Global.System.Drawing.Size(256, 21)
            Me.cmbxMovementRate.TabIndex = 7
            '
            'Label5
            '
            Me.Label5.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label5.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label5.Location = New Global.System.Drawing.Point(16, 246)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(136, 18)
            Me.Label5.TabIndex = 3
            Me.Label5.Text = "Movement Rate"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label4.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label4.Location = New Global.System.Drawing.Point(16, 212)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(136, 18)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Environment Map"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label3.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label3.Location = New Global.System.Drawing.Point(16, 178)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(146, 18)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Number of Sizes to create"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New Global.System.Drawing.Point(16, 58)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(136, 18)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Gender"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(16, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(136, 18)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Name"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxEnvMap
            '
            Me.cmbxEnvMap.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxEnvMap.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxEnvMap.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxEnvMap.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxEnvMap.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxEnvMap.Items.AddRange(New Object() {"DEFAULT", "CM_BareMetal", "CM_MANUN"})
            Me.cmbxEnvMap.Location = New Global.System.Drawing.Point(168, 212)
            Me.cmbxEnvMap.Name = "cmbxEnvMap"
            Me.cmbxEnvMap.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.cmbxEnvMap.Size = New Global.System.Drawing.Size(256, 21)
            Me.cmbxEnvMap.TabIndex = 6
            '
            'cmbxSizes
            '
            Me.cmbxSizes.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxSizes.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSizes.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxSizes.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxSizes.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxSizes.Items.AddRange(New Object() {"1", "3"})
            Me.cmbxSizes.Location = New Global.System.Drawing.Point(168, 178)
            Me.cmbxSizes.Name = "cmbxSizes"
            Me.cmbxSizes.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
            Me.cmbxSizes.Size = New Global.System.Drawing.Size(256, 21)
            Me.cmbxSizes.TabIndex = 5
            '
            'cmbxGender
            '
            Me.cmbxGender.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxGender.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxGender.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxGender.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxGender.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxGender.Items.AddRange(New Object() {"Male", "Female"})
            Me.cmbxGender.Location = New Global.System.Drawing.Point(168, 58)
            Me.cmbxGender.Name = "cmbxGender"
            Me.cmbxGender.Size = New Global.System.Drawing.Size(256, 21)
            Me.cmbxGender.TabIndex = 1
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.Button1)
            Me.TabPage2.Controls.Add(Me.Label15)
            Me.TabPage2.Controls.Add(Me.Label13)
            Me.TabPage2.Controls.Add(Me.tbMa)
            Me.TabPage2.Controls.Add(Me.tbTa)
            Me.TabPage2.Controls.Add(Me.tbMb)
            Me.TabPage2.Controls.Add(Me.tbTb)
            Me.TabPage2.Controls.Add(Me.tbTd)
            Me.TabPage2.Controls.Add(Me.tbMd)
            Me.TabPage2.Controls.Add(Me.tbMc)
            Me.TabPage2.Controls.Add(Me.tbTc)
            Me.TabPage2.Controls.Add(Me.tbTf)
            Me.TabPage2.Controls.Add(Me.tbMf)
            Me.TabPage2.Controls.Add(Me.tbMe)
            Me.TabPage2.Controls.Add(Me.tbTe)
            Me.TabPage2.Controls.Add(Me.tbTg)
            Me.TabPage2.Controls.Add(Me.tbMg)
            Me.TabPage2.Controls.Add(Me.tbMh)
            Me.TabPage2.Controls.Add(Me.tbTh)
            Me.TabPage2.Controls.Add(Me.tbTi)
            Me.TabPage2.Controls.Add(Me.tbMi)
            Me.TabPage2.Controls.Add(Me.tbMj)
            Me.TabPage2.Controls.Add(Me.tbTj)
            Me.TabPage2.Controls.Add(Me.Label14)
            Me.TabPage2.Controls.Add(Me.Label16)
            Me.TabPage2.Controls.Add(Me.Label17)
            Me.TabPage2.Controls.Add(Me.Label18)
            Me.TabPage2.Controls.Add(Me.Label19)
            Me.TabPage2.Controls.Add(Me.Label20)
            Me.TabPage2.Controls.Add(Me.Label21)
            Me.TabPage2.Controls.Add(Me.Label22)
            Me.TabPage2.Controls.Add(Me.Label23)
            Me.TabPage2.Controls.Add(Me.Label24)
            Me.TabPage2.Controls.Add(Me.tbEvilTexture)
            Me.TabPage2.Controls.Add(Me.Label25)
            Me.TabPage2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage2.Location = New Global.System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New Global.System.Windows.Forms.Padding(8)
            Me.TabPage2.Size = New Global.System.Drawing.Size(440, 448)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Model/Texture Names"
            '
            'Button1
            '
            Me.Button1.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button1.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button1.Location = New Global.System.Drawing.Point(112, 406)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New Global.System.Drawing.Size(224, 27)
            Me.Button1.TabIndex = 21
            Me.Button1.Text = "Show samples from Base Model Name"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'Label15
            '
            Me.Label15.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label15.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label15.Location = New Global.System.Drawing.Point(80, 37)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(24, 18)
            Me.Label15.TabIndex = 2
            Me.Label15.Text = "A"
            Me.Label15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label13
            '
            Me.Label13.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label13.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label13.Location = New Global.System.Drawing.Point(144, 9)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New Global.System.Drawing.Size(52, 19)
            Me.Label13.TabIndex = 1
            Me.Label13.Text = "Model"
            Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMa
            '
            Me.tbMa.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMa.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMa.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMa.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMa.Location = New Global.System.Drawing.Point(112, 37)
            Me.tbMa.Name = "tbMa"
            Me.tbMa.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMa.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMa.TabIndex = 0
            '
            'tbTa
            '
            Me.tbTa.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTa.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTa.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTa.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTa.Location = New Global.System.Drawing.Point(232, 37)
            Me.tbTa.Name = "tbTa"
            Me.tbTa.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTa.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTa.TabIndex = 1
            '
            'tbMb
            '
            Me.tbMb.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMb.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMb.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMb.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMb.Location = New Global.System.Drawing.Point(112, 72)
            Me.tbMb.Name = "tbMb"
            Me.tbMb.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMb.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMb.TabIndex = 2
            '
            'tbTb
            '
            Me.tbTb.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTb.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTb.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTb.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTb.Location = New Global.System.Drawing.Point(232, 72)
            Me.tbTb.Name = "tbTb"
            Me.tbTb.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTb.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTb.TabIndex = 3
            '
            'tbTd
            '
            Me.tbTd.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTd.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTd.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTd.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTd.Location = New Global.System.Drawing.Point(232, 142)
            Me.tbTd.Name = "tbTd"
            Me.tbTd.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTd.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTd.TabIndex = 7
            '
            'tbMd
            '
            Me.tbMd.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMd.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMd.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMd.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMd.Location = New Global.System.Drawing.Point(112, 142)
            Me.tbMd.Name = "tbMd"
            Me.tbMd.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMd.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMd.TabIndex = 6
            '
            'tbMc
            '
            Me.tbMc.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMc.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMc.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMc.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMc.Location = New Global.System.Drawing.Point(112, 107)
            Me.tbMc.Name = "tbMc"
            Me.tbMc.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMc.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMc.TabIndex = 4
            '
            'tbTc
            '
            Me.tbTc.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTc.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTc.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTc.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTc.Location = New Global.System.Drawing.Point(232, 107)
            Me.tbTc.Name = "tbTc"
            Me.tbTc.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTc.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTc.TabIndex = 5
            '
            'tbTf
            '
            Me.tbTf.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTf.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTf.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTf.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTf.Location = New Global.System.Drawing.Point(232, 212)
            Me.tbTf.Name = "tbTf"
            Me.tbTf.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTf.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTf.TabIndex = 11
            '
            'tbMf
            '
            Me.tbMf.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMf.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMf.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMf.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMf.Location = New Global.System.Drawing.Point(112, 212)
            Me.tbMf.Name = "tbMf"
            Me.tbMf.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMf.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMf.TabIndex = 10
            '
            'tbMe
            '
            Me.tbMe.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMe.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMe.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMe.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMe.Location = New Global.System.Drawing.Point(112, 177)
            Me.tbMe.Name = "tbMe"
            Me.tbMe.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMe.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMe.TabIndex = 8
            '
            'tbTe
            '
            Me.tbTe.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTe.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTe.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTe.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTe.Location = New Global.System.Drawing.Point(232, 177)
            Me.tbTe.Name = "tbTe"
            Me.tbTe.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTe.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTe.TabIndex = 9
            '
            'tbTg
            '
            Me.tbTg.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTg.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTg.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTg.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTg.Location = New Global.System.Drawing.Point(232, 247)
            Me.tbTg.Name = "tbTg"
            Me.tbTg.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTg.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTg.TabIndex = 13
            '
            'tbMg
            '
            Me.tbMg.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMg.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMg.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMg.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMg.Location = New Global.System.Drawing.Point(112, 247)
            Me.tbMg.Name = "tbMg"
            Me.tbMg.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMg.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMg.TabIndex = 12
            '
            'tbMh
            '
            Me.tbMh.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMh.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMh.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMh.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMh.Location = New Global.System.Drawing.Point(112, 282)
            Me.tbMh.Name = "tbMh"
            Me.tbMh.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMh.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMh.TabIndex = 14
            '
            'tbTh
            '
            Me.tbTh.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTh.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTh.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTh.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTh.Location = New Global.System.Drawing.Point(232, 282)
            Me.tbTh.Name = "tbTh"
            Me.tbTh.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTh.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTh.TabIndex = 15
            '
            'tbTi
            '
            Me.tbTi.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTi.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTi.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTi.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTi.Location = New Global.System.Drawing.Point(232, 317)
            Me.tbTi.Name = "tbTi"
            Me.tbTi.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTi.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTi.TabIndex = 17
            '
            'tbMi
            '
            Me.tbMi.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMi.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMi.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMi.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMi.Location = New Global.System.Drawing.Point(112, 317)
            Me.tbMi.Name = "tbMi"
            Me.tbMi.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMi.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMi.TabIndex = 16
            '
            'tbMj
            '
            Me.tbMj.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMj.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMj.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMj.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMj.Location = New Global.System.Drawing.Point(112, 352)
            Me.tbMj.Name = "tbMj"
            Me.tbMj.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbMj.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbMj.TabIndex = 18
            '
            'tbTj
            '
            Me.tbTj.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbTj.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTj.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbTj.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTj.Location = New Global.System.Drawing.Point(232, 352)
            Me.tbTj.Name = "tbTj"
            Me.tbTj.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbTj.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbTj.TabIndex = 19
            '
            'Label14
            '
            Me.Label14.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label14.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label14.Location = New Global.System.Drawing.Point(256, 9)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(64, 19)
            Me.Label14.TabIndex = 1
            Me.Label14.Text = "Texture"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label16
            '
            Me.Label16.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label16.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label16.Location = New Global.System.Drawing.Point(80, 72)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Global.System.Drawing.Size(24, 18)
            Me.Label16.TabIndex = 2
            Me.Label16.Text = "B"
            Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label17
            '
            Me.Label17.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label17.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label17.Location = New Global.System.Drawing.Point(80, 107)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Global.System.Drawing.Size(24, 18)
            Me.Label17.TabIndex = 2
            Me.Label17.Text = "C"
            Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label18
            '
            Me.Label18.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label18.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label18.Location = New Global.System.Drawing.Point(80, 142)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Global.System.Drawing.Size(24, 18)
            Me.Label18.TabIndex = 2
            Me.Label18.Text = "D"
            Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label19
            '
            Me.Label19.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label19.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label19.Location = New Global.System.Drawing.Point(80, 282)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(24, 19)
            Me.Label19.TabIndex = 2
            Me.Label19.Text = "H"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label20
            '
            Me.Label20.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label20.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label20.Location = New Global.System.Drawing.Point(80, 212)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Global.System.Drawing.Size(24, 18)
            Me.Label20.TabIndex = 2
            Me.Label20.Text = "F"
            Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label21
            '
            Me.Label21.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label21.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label21.Location = New Global.System.Drawing.Point(80, 247)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Global.System.Drawing.Size(24, 19)
            Me.Label21.TabIndex = 2
            Me.Label21.Text = "G"
            Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label22
            '
            Me.Label22.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label22.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label22.Location = New Global.System.Drawing.Point(80, 177)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Global.System.Drawing.Size(24, 18)
            Me.Label22.TabIndex = 2
            Me.Label22.Text = "E"
            Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label23
            '
            Me.Label23.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label23.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label23.Location = New Global.System.Drawing.Point(80, 352)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New Global.System.Drawing.Size(24, 19)
            Me.Label23.TabIndex = 2
            Me.Label23.Text = "J"
            Me.Label23.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label24
            '
            Me.Label24.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label24.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label24.Location = New Global.System.Drawing.Point(80, 317)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New Global.System.Drawing.Size(24, 19)
            Me.Label24.TabIndex = 2
            Me.Label24.Text = "I"
            Me.Label24.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbEvilTexture
            '
            Me.tbEvilTexture.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbEvilTexture.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbEvilTexture.Font = New Global.System.Drawing.Font("Consolas", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbEvilTexture.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbEvilTexture.Location = New Global.System.Drawing.Point(112, 382)
            Me.tbEvilTexture.Name = "tbEvilTexture"
            Me.tbEvilTexture.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
            Me.tbEvilTexture.Size = New Global.System.Drawing.Size(100, 20)
            Me.tbEvilTexture.TabIndex = 20
            '
            'Label25
            '
            Me.Label25.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label25.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label25.Location = New Global.System.Drawing.Point(24, 382)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New Global.System.Drawing.Size(80, 19)
            Me.Label25.TabIndex = 1
            Me.Label25.Text = "Evil Texture"
            Me.Label25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New Global.System.Drawing.Point(16, 490)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New Global.System.Drawing.Size(448, 2)
            Me.lblSeparatorBottom.TabIndex = 1
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 592)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(480, 58)
            Me.pnlFooter.TabIndex = 2
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New Global.System.Drawing.Point(306, 16)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New Global.System.Drawing.Size(75, 27)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCancel.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCancel.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCancel.Location = New Global.System.Drawing.Point(389, 16)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New Global.System.Drawing.Size(75, 27)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
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
            Me.pnlHeader.Size = New Global.System.Drawing.Size(480, 88)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New Global.System.Drawing.Point(0, 85)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New Global.System.Drawing.Size(480, 3)
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
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(18, 52)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(444, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Create appearance.2da rows with model, texture, creature, and movement values."
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
            Me.lblTitle.Location = New Global.System.Drawing.Point(16, 12)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(446, 39)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Appearance Wizard"
            Me.lblTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmAppearanceWizard
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 15)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(482, 652)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAppearanceWizard"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Appearance Wizard"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace
