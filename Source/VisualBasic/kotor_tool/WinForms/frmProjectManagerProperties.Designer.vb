Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmProjectManagerProperties
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

        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents btnKotorPath As Global.System.Windows.Forms.Button
        Friend WithEvents btnReleasePath As Global.System.Windows.Forms.Button
        Friend WithEvents tbDebugPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbReleasePath As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnSelectProject As Global.System.Windows.Forms.Button
        Friend WithEvents tbProjectPath As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents tbProjectName As Global.System.Windows.Forms.TextBox
        Friend WithEvents rbKotor1 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbKotor2 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label

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
            Me.rbKotor1 = New System.Windows.Forms.RadioButton()
            Me.rbKotor2 = New System.Windows.Forms.RadioButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnSelectProject = New System.Windows.Forms.Button()
            Me.btnReleasePath = New System.Windows.Forms.Button()
            Me.btnKotorPath = New System.Windows.Forms.Button()
            Me.tbReleasePath = New System.Windows.Forms.TextBox()
            Me.tbDebugPath = New System.Windows.Forms.TextBox()
            Me.tbProjectPath = New System.Windows.Forms.TextBox()
            Me.tbProjectName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
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
            Me.pnlRoot.Size = New System.Drawing.Size(560, 408)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.rbKotor1)
            Me.pnlBody.Controls.Add(Me.rbKotor2)
            Me.pnlBody.Controls.Add(Me.Label5)
            Me.pnlBody.Controls.Add(Me.btnSelectProject)
            Me.pnlBody.Controls.Add(Me.btnReleasePath)
            Me.pnlBody.Controls.Add(Me.btnKotorPath)
            Me.pnlBody.Controls.Add(Me.tbReleasePath)
            Me.pnlBody.Controls.Add(Me.tbDebugPath)
            Me.pnlBody.Controls.Add(Me.tbProjectPath)
            Me.pnlBody.Controls.Add(Me.tbProjectName)
            Me.pnlBody.Controls.Add(Me.Label3)
            Me.pnlBody.Controls.Add(Me.Label2)
            Me.pnlBody.Controls.Add(Me.Label1)
            Me.pnlBody.Controls.Add(Me.Label4)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 88)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(28, 22, 28, 18)
            Me.pnlBody.Size = New System.Drawing.Size(560, 248)
            Me.pnlBody.TabIndex = 1
            '
            'rbKotor1
            '
            Me.rbKotor1.BackColor = System.Drawing.Color.Transparent
            Me.rbKotor1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbKotor1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.rbKotor1.Location = New System.Drawing.Point(178, 207)
            Me.rbKotor1.Name = "rbKotor1"
            Me.rbKotor1.Size = New System.Drawing.Size(80, 25)
            Me.rbKotor1.TabIndex = 7
            Me.rbKotor1.Text = "&KotOR I"
            Me.rbKotor1.UseVisualStyleBackColor = False
            '
            'rbKotor2
            '
            Me.rbKotor2.BackColor = System.Drawing.Color.Transparent
            Me.rbKotor2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbKotor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.rbKotor2.Location = New System.Drawing.Point(274, 207)
            Me.rbKotor2.Name = "rbKotor2"
            Me.rbKotor2.Size = New System.Drawing.Size(120, 25)
            Me.rbKotor2.TabIndex = 8
            Me.rbKotor2.Text = "KotOR II : &TSL"
            Me.rbKotor2.UseVisualStyleBackColor = False
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(32, 210)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(132, 18)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Target Game"
            '
            'btnSelectProject
            '
            Me.btnSelectProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSelectProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSelectProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSelectProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSelectProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSelectProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSelectProject.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSelectProject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSelectProject.Location = New System.Drawing.Point(500, 65)
            Me.btnSelectProject.Name = "btnSelectProject"
            Me.btnSelectProject.Size = New System.Drawing.Size(28, 26)
            Me.btnSelectProject.TabIndex = 2
            Me.btnSelectProject.Text = "..."
            Me.btnSelectProject.UseVisualStyleBackColor = False
            '
            'btnReleasePath
            '
            Me.btnReleasePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReleasePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnReleasePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnReleasePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnReleasePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnReleasePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReleasePath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReleasePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnReleasePath.Location = New System.Drawing.Point(500, 157)
            Me.btnReleasePath.Name = "btnReleasePath"
            Me.btnReleasePath.Size = New System.Drawing.Size(28, 26)
            Me.btnReleasePath.TabIndex = 6
            Me.btnReleasePath.Text = "..."
            Me.btnReleasePath.UseVisualStyleBackColor = False
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
            Me.btnKotorPath.Location = New System.Drawing.Point(500, 111)
            Me.btnKotorPath.Name = "btnKotorPath"
            Me.btnKotorPath.Size = New System.Drawing.Size(28, 26)
            Me.btnKotorPath.TabIndex = 4
            Me.btnKotorPath.Text = "..."
            Me.btnKotorPath.UseVisualStyleBackColor = False
            '
            'tbReleasePath
            '
            Me.tbReleasePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbReleasePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbReleasePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbReleasePath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbReleasePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbReleasePath.Location = New System.Drawing.Point(178, 158)
            Me.tbReleasePath.Name = "tbReleasePath"
            Me.tbReleasePath.Size = New System.Drawing.Size(314, 22)
            Me.tbReleasePath.TabIndex = 5
            '
            'tbDebugPath
            '
            Me.tbDebugPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbDebugPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbDebugPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDebugPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbDebugPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDebugPath.Location = New System.Drawing.Point(178, 112)
            Me.tbDebugPath.Name = "tbDebugPath"
            Me.tbDebugPath.Size = New System.Drawing.Size(314, 22)
            Me.tbDebugPath.TabIndex = 3
            '
            'tbProjectPath
            '
            Me.tbProjectPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbProjectPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbProjectPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbProjectPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbProjectPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbProjectPath.Location = New System.Drawing.Point(178, 66)
            Me.tbProjectPath.Name = "tbProjectPath"
            Me.tbProjectPath.Size = New System.Drawing.Size(314, 22)
            Me.tbProjectPath.TabIndex = 1
            '
            'tbProjectName
            '
            Me.tbProjectName.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbProjectName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbProjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbProjectName.Location = New System.Drawing.Point(178, 20)
            Me.tbProjectName.Name = "tbProjectName"
            Me.tbProjectName.Size = New System.Drawing.Size(180, 22)
            Me.tbProjectName.TabIndex = 0
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(32, 152)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(132, 42)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Release mode output and temporary data path"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(32, 115)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(140, 19)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Debug mode output path"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(32, 69)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(132, 19)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Project File"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(32, 23)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(132, 19)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "Project Name"
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 336)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(560, 72)
            Me.pnlFooter.TabIndex = 2
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
            Me.btnCancel.Location = New System.Drawing.Point(452, 23)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(76, 30)
            Me.btnCancel.TabIndex = 10
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(368, 23)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(76, 30)
            Me.btnOK.TabIndex = 9
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New System.Drawing.Size(560, 1)
            Me.lblFooterSeparator.TabIndex = 0
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
            Me.pnlHeader.Size = New System.Drawing.Size(560, 88)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(24, 48)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(504, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Configure project identity, output paths, and target game data."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(22, 17)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(504, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Project Properties"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 85)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(560, 3)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmProjectManagerProperties
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(560, 408)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.MaximumSize = New System.Drawing.Size(1600, 447)
            Me.MinimumSize = New System.Drawing.Size(568, 447)
            Me.Name = "frmProjectManagerProperties"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Project Properties"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlBody.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace