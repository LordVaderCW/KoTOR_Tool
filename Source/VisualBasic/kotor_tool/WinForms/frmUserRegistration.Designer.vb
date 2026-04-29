Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmUserRegistration
        Inherits Global.System.Windows.Forms.Form

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
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents Button2 As Global.System.Windows.Forms.Button
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmUserRegistration))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.Button2 = New Global.System.Windows.Forms.Button()
            Me.Label8 = New Global.System.Windows.Forms.Label()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
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
            Me.pnlRoot.Size = New Global.System.Drawing.Size(500, 350)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.Button2)
            Me.pnlBody.Controls.Add(Me.Label8)
            Me.pnlBody.Controls.Add(Me.Label7)
            Me.pnlBody.Controls.Add(Me.Label6)
            Me.pnlBody.Controls.Add(Me.Label5)
            Me.pnlBody.Controls.Add(Me.Button1)
            Me.pnlBody.Controls.Add(Me.Label4)
            Me.pnlBody.Controls.Add(Me.Label3)
            Me.pnlBody.Controls.Add(Me.Label2)
            Me.pnlBody.Controls.Add(Me.Label1)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(28, 22, 28, 18)
            Me.pnlBody.Size = New Global.System.Drawing.Size(500, 212)
            Me.pnlBody.TabIndex = 1
            '
            'Button2
            '
            Me.Button2.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.Button2.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button2.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button2.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button2.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button2.Location = New Global.System.Drawing.Point(96, 163)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New Global.System.Drawing.Size(292, 26)
            Me.Button2.TabIndex = 9
            Me.Button2.Text = "Import User Registration Key"
            Me.Button2.UseVisualStyleBackColor = False
            '
            'Label8
            '
            Me.Label8.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label8.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label8.Location = New Global.System.Drawing.Point(96, 124)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Global.System.Drawing.Size(320, 32)
            Me.Label8.TabIndex = 8
            Me.Label8.Text = "to fredtetra@hotmail.com for further details on the registration process."
            '
            'Label7
            '
            Me.Label7.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label7.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label7.Location = New Global.System.Drawing.Point(218, 105)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(198, 18)
            Me.Label7.TabIndex = 7
            Me.Label7.Text = "file (in your Kotor Tool directory)"
            '
            'Label6
            '
            Me.Label6.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label6.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label6.Location = New Global.System.Drawing.Point(135, 105)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(84, 18)
            Me.Label6.TabIndex = 6
            Me.Label6.Text = "user reg.info"
            '
            'Label5
            '
            Me.Label5.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label5.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New Global.System.Drawing.Point(80, 105)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(54, 18)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "Mail the"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
            '
            'Button1
            '
            Me.Button1.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button1.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button1.Location = New Global.System.Drawing.Point(96, 62)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New Global.System.Drawing.Size(292, 26)
            Me.Button1.TabIndex = 4
            Me.Button1.Text = "Enter User Registration Info"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'Label4
            '
            Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label4.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label4.Location = New Global.System.Drawing.Point(54, 163)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(30, 24)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "3."
            '
            'Label3
            '
            Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label3.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label3.Location = New Global.System.Drawing.Point(54, 105)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(30, 24)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "2."
            '
            'Label2
            '
            Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New Global.System.Drawing.Point(54, 62)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(30, 24)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "1."
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 9.0!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(32, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(428, 24)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Complete the steps below to register your copy of Kotor Tool"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 288)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(500, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New Global.System.Drawing.Point(392, 20)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New Global.System.Drawing.Size(76, 26)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New Global.System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New Global.System.Drawing.Size(500, 1)
            Me.lblFooterSeparator.TabIndex = 1
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
            Me.pnlHeader.Size = New Global.System.Drawing.Size(500, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(24, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(440, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Manage legacy user registration details and imported registration keys."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(22, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(440, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "User Registration"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New Global.System.Drawing.Size(500, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmUserRegistration
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnOK
            Me.ClientSize = New Global.System.Drawing.Size(500, 350)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(500, 350)
            Me.Name = "frmUserRegistration"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "User Registration"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)

            AddHandler Me.Button1.Click, AddressOf Me.Button1_Click
            AddHandler Me.Button2.Click, AddressOf Me.Button2_Click

            Me.ResumeLayout(False)
        End Sub

    End Class

End Namespace