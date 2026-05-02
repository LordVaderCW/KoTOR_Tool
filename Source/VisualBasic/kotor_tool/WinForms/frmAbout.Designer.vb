Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmAbout
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmAbout.Designer.vb
        '
        ' Restored / facelifted About form for the KoTOR Tool Restoration.
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
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents lblOriginalAuthor As Global.System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As Global.System.Windows.Forms.PictureBox
        Friend WithEvents lblSpecialCredits As Global.System.Windows.Forms.Label
        Friend WithEvents lblVersion As Global.System.Windows.Forms.Label

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblProjectName As Global.System.Windows.Forms.Label
        Friend WithEvents lblOriginalCredit As Global.System.Windows.Forms.Label
        Friend WithEvents lblRestorationCredit As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If

                If disposing AndAlso Me.PictureBox1 IsNot Nothing AndAlso Me.PictureBox1.Image IsNot Nothing Then
                    Me.PictureBox1.Image.Dispose()
                    Me.PictureBox1.Image = Nothing
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.MSSLogoPB = New System.Windows.Forms.PictureBox()
            Me.lblSpecialCreditTxt = New System.Windows.Forms.Label()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.lblSpecialCredits = New System.Windows.Forms.Label()
            Me.lblRestorationCredit = New System.Windows.Forms.Label()
            Me.lblOriginalCredit = New System.Windows.Forms.Label()
            Me.lblOriginalAuthor = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.LordVaderCW_PB1 = New System.Windows.Forms.PictureBox()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblVersion = New System.Windows.Forms.Label()
            Me.lblProjectName = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.BWLogoPB = New System.Windows.Forms.PictureBox()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            CType(Me.MSSLogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            CType(Me.LordVaderCW_PB1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BWLogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.pnlRoot.Size = New System.Drawing.Size(480, 459)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.BWLogoPB)
            Me.pnlBody.Controls.Add(Me.Label2)
            Me.pnlBody.Controls.Add(Me.MSSLogoPB)
            Me.pnlBody.Controls.Add(Me.lblSpecialCreditTxt)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Controls.Add(Me.lblSpecialCredits)
            Me.pnlBody.Controls.Add(Me.lblRestorationCredit)
            Me.pnlBody.Controls.Add(Me.lblOriginalCredit)
            Me.pnlBody.Controls.Add(Me.lblOriginalAuthor)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 104)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Size = New System.Drawing.Size(478, 303)
            Me.pnlBody.TabIndex = 1
            '
            'MSSLogoPB
            '
            Me.MSSLogoPB.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.MSSLogoPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MSSLogoPB.Location = New System.Drawing.Point(13, 110)
            Me.MSSLogoPB.Name = "MSSLogoPB"
            Me.MSSLogoPB.Size = New System.Drawing.Size(86, 86)
            Me.MSSLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.MSSLogoPB.TabIndex = 14
            Me.MSSLogoPB.TabStop = False
            '
            'lblSpecialCreditTxt
            '
            Me.lblSpecialCreditTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSpecialCreditTxt.BackColor = System.Drawing.Color.Transparent
            Me.lblSpecialCreditTxt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSpecialCreditTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblSpecialCreditTxt.Location = New System.Drawing.Point(28, 209)
            Me.lblSpecialCreditTxt.Name = "lblSpecialCreditTxt"
            Me.lblSpecialCreditTxt.Size = New System.Drawing.Size(422, 20)
            Me.lblSpecialCreditTxt.TabIndex = 13
            Me.lblSpecialCreditTxt.Text = "Special Credits:"
            Me.lblSpecialCreditTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(0, 301)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(478, 2)
            Me.lblSeparatorBottom.TabIndex = 12
            '
            'lblSpecialCredits
            '
            Me.lblSpecialCredits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSpecialCredits.BackColor = System.Drawing.Color.Transparent
            Me.lblSpecialCredits.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSpecialCredits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSpecialCredits.Location = New System.Drawing.Point(28, 229)
            Me.lblSpecialCredits.Name = "lblSpecialCredits"
            Me.lblSpecialCredits.Size = New System.Drawing.Size(422, 59)
            Me.lblSpecialCredits.TabIndex = 7
            Me.lblSpecialCredits.Text = resources.GetString("lblSpecialCredits.Text")
            Me.lblSpecialCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblRestorationCredit
            '
            Me.lblRestorationCredit.BackColor = System.Drawing.Color.Transparent
            Me.lblRestorationCredit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRestorationCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblRestorationCredit.Location = New System.Drawing.Point(28, 76)
            Me.lblRestorationCredit.Name = "lblRestorationCredit"
            Me.lblRestorationCredit.Size = New System.Drawing.Size(422, 20)
            Me.lblRestorationCredit.TabIndex = 11
            Me.lblRestorationCredit.Text = "Restored, repaired, and maintained by LordVaderCW."
            Me.lblRestorationCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblOriginalCredit
            '
            Me.lblOriginalCredit.BackColor = System.Drawing.Color.Transparent
            Me.lblOriginalCredit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOriginalCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblOriginalCredit.Location = New System.Drawing.Point(28, 43)
            Me.lblOriginalCredit.Name = "lblOriginalCredit"
            Me.lblOriginalCredit.Size = New System.Drawing.Size(422, 32)
            Me.lblOriginalCredit.TabIndex = 10
            Me.lblOriginalCredit.Text = "This restored build honours Fred Tetra's original KotOR Tool and the community th" &
    "at kept it alive. Thank You Fred. "
            Me.lblOriginalCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblOriginalAuthor
            '
            Me.lblOriginalAuthor.AutoEllipsis = True
            Me.lblOriginalAuthor.BackColor = System.Drawing.Color.Transparent
            Me.lblOriginalAuthor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOriginalAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.lblOriginalAuthor.Location = New System.Drawing.Point(24, 16)
            Me.lblOriginalAuthor.Name = "lblOriginalAuthor"
            Me.lblOriginalAuthor.Size = New System.Drawing.Size(430, 22)
            Me.lblOriginalAuthor.TabIndex = 3
            Me.lblOriginalAuthor.Text = "KoTOR Tool Original Author: Fred Tetra  "
            Me.lblOriginalAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.Button1)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 407)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(478, 50)
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
            Me.Button1.Location = New System.Drawing.Point(370, 13)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(84, 25)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "OK"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.LordVaderCW_PB1)
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblVersion)
            Me.pnlHeader.Controls.Add(Me.lblProjectName)
            Me.pnlHeader.Controls.Add(Me.Label1)
            Me.pnlHeader.Controls.Add(Me.PictureBox1)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(478, 104)
            Me.pnlHeader.TabIndex = 0
            '
            'LordVaderCW_PB1
            '
            Me.LordVaderCW_PB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.LordVaderCW_PB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LordVaderCW_PB1.Image = Global.My.Resources.Resources.LordVaderCW_Circle
            Me.LordVaderCW_PB1.Location = New System.Drawing.Point(379, 3)
            Me.LordVaderCW_PB1.Name = "LordVaderCW_PB1"
            Me.LordVaderCW_PB1.Size = New System.Drawing.Size(96, 96)
            Me.LordVaderCW_PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.LordVaderCW_PB1.TabIndex = 10
            Me.LordVaderCW_PB1.TabStop = False
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 102)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(478, 2)
            Me.lblSeparatorTop.TabIndex = 9
            '
            'lblVersion
            '
            Me.lblVersion.AutoEllipsis = True
            Me.lblVersion.BackColor = System.Drawing.Color.Transparent
            Me.lblVersion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblVersion.Location = New System.Drawing.Point(105, 70)
            Me.lblVersion.Name = "lblVersion"
            Me.lblVersion.Size = New System.Drawing.Size(268, 18)
            Me.lblVersion.TabIndex = 5
            Me.lblVersion.Text = "Version 1.0.3.1"
            Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblProjectName
            '
            Me.lblProjectName.AutoEllipsis = True
            Me.lblProjectName.BackColor = System.Drawing.Color.Transparent
            Me.lblProjectName.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblProjectName.Location = New System.Drawing.Point(105, 50)
            Me.lblProjectName.Name = "lblProjectName"
            Me.lblProjectName.Size = New System.Drawing.Size(268, 20)
            Me.lblProjectName.TabIndex = 8
            Me.lblProjectName.Text = "KoTOR Tool Restoration Project"
            Me.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.AutoEllipsis = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(102, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(271, 34)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "KotOR Tool"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Image = Global.My.Resources.Resources.koTOR_icon
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 4
            Me.PictureBox1.TabStop = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(103, 110)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(270, 86)
            Me.Label2.TabIndex = 15
            Me.Label2.Text = "Uses Miles Sound System from RAD Game Tools (C) Copyright Epic Games. (Pending Li" &
    "cence) Uses GFF Editor for NeverWinter Nights from Bioware, Inc."
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'BWLogoPB
            '
            Me.BWLogoPB.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.BWLogoPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.BWLogoPB.Location = New System.Drawing.Point(381, 110)
            Me.BWLogoPB.Name = "BWLogoPB"
            Me.BWLogoPB.Size = New System.Drawing.Size(86, 86)
            Me.BWLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.BWLogoPB.TabIndex = 16
            Me.BWLogoPB.TabStop = False
            '
            'frmAbout
            '
            Me.AcceptButton = Me.Button1
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(480, 459)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAbout"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "About KotOR Tool"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            CType(Me.MSSLogoPB, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            CType(Me.LordVaderCW_PB1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BWLogoPB, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MSSLogoPB As System.Windows.Forms.PictureBox
        Friend WithEvents lblSpecialCreditTxt As System.Windows.Forms.Label
        Friend WithEvents LordVaderCW_PB1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents BWLogoPB As System.Windows.Forms.PictureBox
    End Class

End Namespace