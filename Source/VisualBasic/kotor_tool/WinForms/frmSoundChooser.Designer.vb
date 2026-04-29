Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmSoundChooser
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

        Friend WithEvents btnPlaySound As Global.System.Windows.Forms.Button
        Friend WithEvents btnStopSound As Global.System.Windows.Forms.Button
        Friend WithEvents lbSounds As Global.System.Windows.Forms.ListBox
        Friend WithEvents chkbLookSoundsBif As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbLookStreamSounds As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tbFilter As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbxFilter As Global.System.Windows.Forms.ComboBox
        Friend WithEvents lblSoundCount As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmSoundChooser))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.lblSoundCount = New Global.System.Windows.Forms.Label()
            Me.btnStopSound = New Global.System.Windows.Forms.Button()
            Me.btnPlaySound = New Global.System.Windows.Forms.Button()
            Me.lbSounds = New Global.System.Windows.Forms.ListBox()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.cmbxFilter = New Global.System.Windows.Forms.ComboBox()
            Me.tbFilter = New Global.System.Windows.Forms.TextBox()
            Me.chkbLookStreamSounds = New Global.System.Windows.Forms.CheckBox()
            Me.chkbLookSoundsBif = New Global.System.Windows.Forms.CheckBox()
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
            Me.pnlRoot.Size = New Global.System.Drawing.Size(620, 430)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.lblSoundCount)
            Me.pnlBody.Controls.Add(Me.btnStopSound)
            Me.pnlBody.Controls.Add(Me.btnPlaySound)
            Me.pnlBody.Controls.Add(Me.lbSounds)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(20, 16, 20, 16)
            Me.pnlBody.Size = New Global.System.Drawing.Size(620, 228)
            Me.pnlBody.TabIndex = 1
            '
            'lblSoundCount
            '
            Me.lblSoundCount.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblSoundCount.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSoundCount.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSoundCount.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblSoundCount.Location = New Global.System.Drawing.Point(494, 18)
            Me.lblSoundCount.Name = "lblSoundCount"
            Me.lblSoundCount.Size = New Global.System.Drawing.Size(100, 18)
            Me.lblSoundCount.TabIndex = 3
            '
            'btnStopSound
            '
            Me.btnStopSound.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnStopSound.Enabled = False
            Me.btnStopSound.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnStopSound.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnStopSound.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnStopSound.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnStopSound.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnStopSound.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnStopSound.Location = New Global.System.Drawing.Point(300, 14)
            Me.btnStopSound.Name = "btnStopSound"
            Me.btnStopSound.Size = New Global.System.Drawing.Size(86, 26)
            Me.btnStopSound.TabIndex = 1
            Me.btnStopSound.Text = "Stop"
            Me.btnStopSound.UseVisualStyleBackColor = False
            '
            'btnPlaySound
            '
            Me.btnPlaySound.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnPlaySound.Enabled = False
            Me.btnPlaySound.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnPlaySound.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnPlaySound.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnPlaySound.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnPlaySound.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPlaySound.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnPlaySound.Location = New Global.System.Drawing.Point(204, 14)
            Me.btnPlaySound.Name = "btnPlaySound"
            Me.btnPlaySound.Size = New Global.System.Drawing.Size(86, 26)
            Me.btnPlaySound.TabIndex = 0
            Me.btnPlaySound.Text = "Play Sound"
            Me.btnPlaySound.UseVisualStyleBackColor = False
            '
            'lbSounds
            '
            Me.lbSounds.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                        Or Global.System.Windows.Forms.AnchorStyles.Left) _
                        Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lbSounds.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.lbSounds.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbSounds.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbSounds.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbSounds.Location = New Global.System.Drawing.Point(20, 50)
            Me.lbSounds.MultiColumn = True
            Me.lbSounds.Name = "lbSounds"
            Me.lbSounds.SelectionMode = Global.System.Windows.Forms.SelectionMode.MultiExtended
            Me.lbSounds.Size = New Global.System.Drawing.Size(574, 158)
            Me.lbSounds.TabIndex = 2
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.Label3)
            Me.pnlFooter.Controls.Add(Me.Label1)
            Me.pnlFooter.Controls.Add(Me.Label2)
            Me.pnlFooter.Controls.Add(Me.cmbxFilter)
            Me.pnlFooter.Controls.Add(Me.tbFilter)
            Me.pnlFooter.Controls.Add(Me.chkbLookStreamSounds)
            Me.pnlFooter.Controls.Add(Me.chkbLookSoundsBif)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 304)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(620, 126)
            Me.pnlFooter.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label3.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label3.Location = New Global.System.Drawing.Point(252, 68)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(128, 16)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Sound Type Filter"
            '
            'Label1
            '
            Me.Label1.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(252, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Name Filter"
            '
            'Label2
            '
            Me.Label2.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New Global.System.Drawing.Point(28, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(132, 16)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Show sounds from:"
            '
            'cmbxFilter
            '
            Me.cmbxFilter.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.cmbxFilter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.cmbxFilter.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxFilter.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxFilter.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxFilter.Location = New Global.System.Drawing.Point(252, 86)
            Me.cmbxFilter.MaxDropDownItems = 16
            Me.cmbxFilter.Name = "cmbxFilter"
            Me.cmbxFilter.Size = New Global.System.Drawing.Size(220, 21)
            Me.cmbxFilter.TabIndex = 8
            '
            'tbFilter
            '
            Me.tbFilter.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbFilter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbFilter.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFilter.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbFilter.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFilter.Location = New Global.System.Drawing.Point(252, 38)
            Me.tbFilter.Name = "tbFilter"
            Me.tbFilter.Size = New Global.System.Drawing.Size(220, 22)
            Me.tbFilter.TabIndex = 5
            Me.tbFilter.Text = ""
            '
            'chkbLookStreamSounds
            '
            Me.chkbLookStreamSounds.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.chkbLookStreamSounds.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbLookStreamSounds.Checked = True
            Me.chkbLookStreamSounds.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbLookStreamSounds.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbLookStreamSounds.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbLookStreamSounds.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbLookStreamSounds.Location = New Global.System.Drawing.Point(44, 70)
            Me.chkbLookStreamSounds.Name = "chkbLookStreamSounds"
            Me.chkbLookStreamSounds.Size = New Global.System.Drawing.Size(126, 18)
            Me.chkbLookStreamSounds.TabIndex = 2
            Me.chkbLookStreamSounds.Text = "StreamSounds"
            Me.chkbLookStreamSounds.UseVisualStyleBackColor = False
            '
            'chkbLookSoundsBif
            '
            Me.chkbLookSoundsBif.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left), Global.System.Windows.Forms.AnchorStyles)
            Me.chkbLookSoundsBif.BackColor = Global.System.Drawing.Color.Transparent
            Me.chkbLookSoundsBif.Checked = True
            Me.chkbLookSoundsBif.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbLookSoundsBif.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.chkbLookSoundsBif.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbLookSoundsBif.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbLookSoundsBif.Location = New Global.System.Drawing.Point(44, 46)
            Me.chkbLookSoundsBif.Name = "chkbLookSoundsBif"
            Me.chkbLookSoundsBif.Size = New Global.System.Drawing.Size(126, 18)
            Me.chkbLookSoundsBif.TabIndex = 1
            Me.chkbLookSoundsBif.Text = "Sounds.bif"
            Me.chkbLookSoundsBif.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New Global.System.Drawing.Point(516, 76)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New Global.System.Drawing.Size(78, 26)
            Me.btnCancel.TabIndex = 10
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
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
            Me.btnOK.Location = New Global.System.Drawing.Point(516, 38)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New Global.System.Drawing.Size(78, 26)
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
            Me.lblFooterSeparator.Size = New Global.System.Drawing.Size(620, 1)
            Me.lblFooterSeparator.TabIndex = 11
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
            Me.pnlHeader.Size = New Global.System.Drawing.Size(620, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(24, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(570, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Select, filter, and preview available KoTOR sound resources."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblTitle.Font = New Global.System.Drawing.Font("Segoe UI", 12.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New Global.System.Drawing.Point(22, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(570, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Sound Selector"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New Global.System.Drawing.Size(620, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmSoundChooser
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(620, 430)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(560, 360)
            Me.Name = "frmSoundChooser"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Sound Selector"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlFooter.PerformLayout()
            Me.pnlHeader.ResumeLayout(False)

            AddHandler Me.btnPlaySound.Click, AddressOf Me.btnPlaySound_Click
            AddHandler Me.btnStopSound.Click, AddressOf Me.btnStopSound_Click
            AddHandler Me.lbSounds.SelectedIndexChanged, AddressOf Me.lbSounds_SelectedIndexChanged
            AddHandler Me.chkbLookSoundsBif.CheckedChanged, AddressOf Me.LookForSoundsChkBxsChanged
            AddHandler Me.chkbLookStreamSounds.CheckedChanged, AddressOf Me.LookForSoundsChkBxsChanged
            AddHandler Me.tbFilter.TextChanged, AddressOf Me.tbFilter_TextChanged
            AddHandler Me.cmbxFilter.SelectedIndexChanged, AddressOf Me.cmbxFilter_SelectedIndexChanged

            Me.ResumeLayout(False)
        End Sub

    End Class

End Namespace