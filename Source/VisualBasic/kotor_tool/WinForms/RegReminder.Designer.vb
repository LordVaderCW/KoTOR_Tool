Option Strict Off
Option Explicit On

Imports System.Windows.Forms.Timer
Imports System.Windows.Forms

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class RegReminder
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

        Friend WithEvents lblRegHeader As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents Timer1 As Timer
        Friend WithEvents lblTimeMsg As Global.System.Windows.Forms.Label
        Friend WithEvents Button2 As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.RegReminder))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.lblTimeMsg = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.lblRegHeader = New Global.System.Windows.Forms.Label()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.Button2 = New Global.System.Windows.Forms.Button()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.lblFooterSeparator = New Global.System.Windows.Forms.Label()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.lblHeaderSeparator = New Global.System.Windows.Forms.Label()
            Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
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
            Me.pnlRoot.Size = New Global.System.Drawing.Size(390, 350)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.Label1)
            Me.pnlBody.Controls.Add(Me.lblTimeMsg)
            Me.pnlBody.Controls.Add(Me.Label2)
            Me.pnlBody.Controls.Add(Me.lblRegHeader)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(26, 22, 26, 18)
            Me.pnlBody.Size = New Global.System.Drawing.Size(390, 212)
            Me.pnlBody.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 9.0!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(38, 100)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(314, 48)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Use the Registration option on the Help menu to start the registration process."
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            '
            'lblTimeMsg
            '
            Me.lblTimeMsg.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTimeMsg.Font = New Global.System.Drawing.Font("Segoe UI", 9.75!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTimeMsg.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTimeMsg.Location = New Global.System.Drawing.Point(38, 160)
            Me.lblTimeMsg.Name = "lblTimeMsg"
            Me.lblTimeMsg.Size = New Global.System.Drawing.Size(314, 24)
            Me.lblTimeMsg.TabIndex = 3
            Me.lblTimeMsg.Text = "Please wait .. "
            Me.lblTimeMsg.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 9.0!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New Global.System.Drawing.Point(38, 55)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(314, 42)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Registration removes this reminder screen and unlocks additional features."
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            '
            'lblRegHeader
            '
            Me.lblRegHeader.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblRegHeader.Font = New Global.System.Drawing.Font("Segoe UI", 11.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegHeader.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblRegHeader.Location = New Global.System.Drawing.Point(26, 22)
            Me.lblRegHeader.Name = "lblRegHeader"
            Me.lblRegHeader.Size = New Global.System.Drawing.Size(338, 24)
            Me.lblRegHeader.TabIndex = 0
            Me.lblRegHeader.Text = "This copy of Kotor Tool is not registered"
            Me.lblRegHeader.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.Button2)
            Me.pnlFooter.Controls.Add(Me.Button1)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 288)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(390, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'Button2
            '
            Me.Button2.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.Button2.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button2.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.Button2.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button2.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button2.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button2.Location = New Global.System.Drawing.Point(283, 20)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New Global.System.Drawing.Size(76, 26)
            Me.Button2.TabIndex = 1
            Me.Button2.Text = "Cancel"
            Me.Button2.UseVisualStyleBackColor = False
            '
            'Button1
            '
            Me.Button1.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button1.Enabled = False
            Me.Button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button1.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button1.Location = New Global.System.Drawing.Point(199, 20)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New Global.System.Drawing.Size(76, 26)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "OK"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New Global.System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New Global.System.Drawing.Size(390, 1)
            Me.lblFooterSeparator.TabIndex = 2
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
            Me.pnlHeader.Size = New Global.System.Drawing.Size(390, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(24, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(340, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Registration reminder for the restored KoTOR Tool interface."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(22, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(340, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Reminder"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New Global.System.Drawing.Size(390, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'Timer1
            '
            Me.Timer1.Interval = 800
            '
            'RegReminder
            '
            Me.AcceptButton = Me.Button1
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.Button2
            Me.ClientSize = New Global.System.Drawing.Size(390, 350)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(390, 350)
            Me.Name = "RegReminder"
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Reminder"
            Me.TopMost = True
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)

            AddHandler Me.Button1.Click, AddressOf Me.Button1_Click
            AddHandler Me.Timer1.Tick, AddressOf Me.Timer1_Tick
            AddHandler Me.Button2.Click, AddressOf Me.Button2_Click

            Me.ResumeLayout(False)
        End Sub

    End Class

End Namespace