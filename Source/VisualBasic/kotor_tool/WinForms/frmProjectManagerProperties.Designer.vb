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
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.rbKotor1 = New Global.System.Windows.Forms.RadioButton()
            Me.rbKotor2 = New Global.System.Windows.Forms.RadioButton()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.btnSelectProject = New Global.System.Windows.Forms.Button()
            Me.btnReleasePath = New Global.System.Windows.Forms.Button()
            Me.btnKotorPath = New Global.System.Windows.Forms.Button()
            Me.tbReleasePath = New Global.System.Windows.Forms.TextBox()
            Me.tbDebugPath = New Global.System.Windows.Forms.TextBox()
            Me.tbProjectPath = New Global.System.Windows.Forms.TextBox()
            Me.tbProjectName = New Global.System.Windows.Forms.TextBox()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.lblFooterSeparator = New Global.System.Windows.Forms.Label()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New Global.System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(560, 360)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(28, 22, 28, 18)
            Me.pnlBody.Size = New Global.System.Drawing.Size(560, 222)
            Me.pnlBody.TabIndex = 1
            '
            'rbKotor1
            '
            Me.rbKotor1.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbKotor1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.rbKotor1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbKotor1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.rbKotor1.Location = New Global.System.Drawing.Point(178, 179)
            Me.rbKotor1.Name = "rbKotor1"
            Me.rbKotor1.Size = New Global.System.Drawing.Size(80, 22)
            Me.rbKotor1.TabIndex = 7
            Me.rbKotor1.Text = "&KotOR I"
            Me.rbKotor1.UseVisualStyleBackColor = False
            '
            'rbKotor2
            '
            Me.rbKotor2.BackColor = Global.System.Drawing.Color.Transparent
            Me.rbKotor2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.rbKotor2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbKotor2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.rbKotor2.Location = New Global.System.Drawing.Point(274, 179)
            Me.rbKotor2.Name = "rbKotor2"
            Me.rbKotor2.Size = New Global.System.Drawing.Size(120, 22)
            Me.rbKotor2.TabIndex = 8
            Me.rbKotor2.Text = "KotOR II : &TSL"
            Me.rbKotor2.UseVisualStyleBackColor = False
            '
            'Label5
            '
            Me.Label5.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label5.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label5.Location = New Global.System.Drawing.Point(32, 182)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(132, 16)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Target Game"
            '
            'btnSelectProject
            '
            Me.btnSelectProject.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnSelectProject.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSelectProject.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSelectProject.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSelectProject.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSelectProject.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnSelectProject.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSelectProject.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSelectProject.Location = New Global.System.Drawing.Point(500, 56)
            Me.btnSelectProject.Name = "btnSelectProject"
            Me.btnSelectProject.Size = New Global.System.Drawing.Size(28, 23)
            Me.btnSelectProject.TabIndex = 2
            Me.btnSelectProject.Text = "..."
            Me.btnSelectProject.UseVisualStyleBackColor = False
            '
            'btnReleasePath
            '
            Me.btnReleasePath.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnReleasePath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnReleasePath.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnReleasePath.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnReleasePath.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnReleasePath.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnReleasePath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReleasePath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnReleasePath.Location = New Global.System.Drawing.Point(500, 136)
            Me.btnReleasePath.Name = "btnReleasePath"
            Me.btnReleasePath.Size = New Global.System.Drawing.Size(28, 23)
            Me.btnReleasePath.TabIndex = 6
            Me.btnReleasePath.Text = "..."
            Me.btnReleasePath.UseVisualStyleBackColor = False
            '
            'btnKotorPath
            '
            Me.btnKotorPath.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnKotorPath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnKotorPath.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnKotorPath.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnKotorPath.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnKotorPath.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnKotorPath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnKotorPath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnKotorPath.Location = New Global.System.Drawing.Point(500, 96)
            Me.btnKotorPath.Name = "btnKotorPath"
            Me.btnKotorPath.Size = New Global.System.Drawing.Size(28, 23)
            Me.btnKotorPath.TabIndex = 4
            Me.btnKotorPath.Text = "..."
            Me.btnKotorPath.UseVisualStyleBackColor = False
            '
            'tbReleasePath
            '
            Me.tbReleasePath.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbReleasePath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbReleasePath.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbReleasePath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbReleasePath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbReleasePath.Location = New Global.System.Drawing.Point(178, 137)
            Me.tbReleasePath.Name = "tbReleasePath"
            Me.tbReleasePath.Size = New Global.System.Drawing.Size(314, 22)
            Me.tbReleasePath.TabIndex = 5
            Me.tbReleasePath.Text = ""
            '
            'tbDebugPath
            '
            Me.tbDebugPath.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbDebugPath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbDebugPath.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDebugPath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbDebugPath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDebugPath.Location = New Global.System.Drawing.Point(178, 97)
            Me.tbDebugPath.Name = "tbDebugPath"
            Me.tbDebugPath.Size = New Global.System.Drawing.Size(314, 22)
            Me.tbDebugPath.TabIndex = 3
            Me.tbDebugPath.Text = ""
            '
            'tbProjectPath
            '
            Me.tbProjectPath.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbProjectPath.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbProjectPath.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbProjectPath.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbProjectPath.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbProjectPath.Location = New Global.System.Drawing.Point(178, 57)
            Me.tbProjectPath.Name = "tbProjectPath"
            Me.tbProjectPath.Size = New Global.System.Drawing.Size(314, 22)
            Me.tbProjectPath.TabIndex = 1
            Me.tbProjectPath.Text = ""
            '
            'tbProjectName
            '
            Me.tbProjectName.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbProjectName.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbProjectName.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbProjectName.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbProjectName.Location = New Global.System.Drawing.Point(178, 17)
            Me.tbProjectName.Name = "tbProjectName"
            Me.tbProjectName.Size = New Global.System.Drawing.Size(180, 22)
            Me.tbProjectName.TabIndex = 0
            Me.tbProjectName.Text = ""
            '
            'Label3
            '
            Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label3.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label3.Location = New Global.System.Drawing.Point(32, 132)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(132, 36)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Release mode output and temporary data path"
            '
            'Label2
            '
            Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New Global.System.Drawing.Point(32, 100)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(140, 16)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Debug mode output path"
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(32, 60)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(132, 16)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Project File"
            '
            'Label4
            '
            Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label4.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label4.Location = New Global.System.Drawing.Point(32, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(132, 16)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "Project Name"
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 298)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(560, 62)
            Me.pnlFooter.TabIndex = 2
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
            Me.btnCancel.Location = New Global.System.Drawing.Point(452, 20)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New Global.System.Drawing.Size(76, 26)
            Me.btnCancel.TabIndex = 10
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
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
            Me.btnOK.Location = New Global.System.Drawing.Point(368, 20)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New Global.System.Drawing.Size(76, 26)
            Me.btnOK.TabIndex = 9
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New Global.System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New Global.System.Drawing.Size(560, 1)
            Me.lblFooterSeparator.TabIndex = 0
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderSeparator)
            Me.pnlHeader.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New Global.System.Drawing.Size(560, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(24, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(504, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Configure project identity, output paths, and target game data."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(22, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(504, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Project Properties"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New Global.System.Drawing.Size(560, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmProjectManagerProperties
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(560, 360)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.MaximumSize = New Global.System.Drawing.Size(1600, 387)
            Me.MinimumSize = New Global.System.Drawing.Size(568, 387)
            Me.Name = "frmProjectManagerProperties"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Project Properties"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlBody.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)

            AddHandler Me.btnKotorPath.Click, AddressOf Me.btnKotorPath_Click
            AddHandler Me.btnReleasePath.Click, AddressOf Me.btnReleasePath_Click
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.btnSelectProject.Click, AddressOf Me.btnSelectProject_Click

            Me.ResumeLayout(False)
        End Sub

    End Class

End Namespace