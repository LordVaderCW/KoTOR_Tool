Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmResourceTypeSelector
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

        Friend WithEvents chkbGIT As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbARE As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbIFO As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbPTH As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTD As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTM As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTT As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTC As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTW As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTE As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTS As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTP As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbNCS As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnSelectAll As Global.System.Windows.Forms.Button
        Friend WithEvents btnClear As Global.System.Windows.Forms.Button

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
            Me.btnClear = New System.Windows.Forms.Button()
            Me.btnSelectAll = New System.Windows.Forms.Button()
            Me.chkbNCS = New System.Windows.Forms.CheckBox()
            Me.chkbUTS = New System.Windows.Forms.CheckBox()
            Me.chkbUTE = New System.Windows.Forms.CheckBox()
            Me.chkbUTT = New System.Windows.Forms.CheckBox()
            Me.chkbUTM = New System.Windows.Forms.CheckBox()
            Me.chkbUTC = New System.Windows.Forms.CheckBox()
            Me.chkbUTW = New System.Windows.Forms.CheckBox()
            Me.chkbUTP = New System.Windows.Forms.CheckBox()
            Me.chkbUTD = New System.Windows.Forms.CheckBox()
            Me.chkbPTH = New System.Windows.Forms.CheckBox()
            Me.chkbIFO = New System.Windows.Forms.CheckBox()
            Me.chkbARE = New System.Windows.Forms.CheckBox()
            Me.chkbGIT = New System.Windows.Forms.CheckBox()
            Me.Label1 = New System.Windows.Forms.Label()
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
            Me.pnlRoot.Size = New System.Drawing.Size(440, 410)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.btnClear)
            Me.pnlBody.Controls.Add(Me.btnSelectAll)
            Me.pnlBody.Controls.Add(Me.chkbNCS)
            Me.pnlBody.Controls.Add(Me.chkbUTS)
            Me.pnlBody.Controls.Add(Me.chkbUTE)
            Me.pnlBody.Controls.Add(Me.chkbUTT)
            Me.pnlBody.Controls.Add(Me.chkbUTM)
            Me.pnlBody.Controls.Add(Me.chkbUTC)
            Me.pnlBody.Controls.Add(Me.chkbUTW)
            Me.pnlBody.Controls.Add(Me.chkbUTP)
            Me.pnlBody.Controls.Add(Me.chkbUTD)
            Me.pnlBody.Controls.Add(Me.chkbPTH)
            Me.pnlBody.Controls.Add(Me.chkbIFO)
            Me.pnlBody.Controls.Add(Me.chkbARE)
            Me.pnlBody.Controls.Add(Me.chkbGIT)
            Me.pnlBody.Controls.Add(Me.Label1)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(28, 20, 28, 18)
            Me.pnlBody.Size = New System.Drawing.Size(440, 272)
            Me.pnlBody.TabIndex = 1
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnClear.Location = New System.Drawing.Point(52, 224)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(84, 26)
            Me.btnClear.TabIndex = 15
            Me.btnClear.Text = "Clear"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            'btnSelectAll
            '
            Me.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSelectAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSelectAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSelectAll.Location = New System.Drawing.Point(52, 190)
            Me.btnSelectAll.Name = "btnSelectAll"
            Me.btnSelectAll.Size = New System.Drawing.Size(84, 26)
            Me.btnSelectAll.TabIndex = 14
            Me.btnSelectAll.Text = "Select All"
            Me.btnSelectAll.UseVisualStyleBackColor = False
            '
            'chkbNCS
            '
            Me.chkbNCS.BackColor = System.Drawing.Color.Transparent
            Me.chkbNCS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbNCS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbNCS.Location = New System.Drawing.Point(236, 226)
            Me.chkbNCS.Name = "chkbNCS"
            Me.chkbNCS.Size = New System.Drawing.Size(142, 18)
            Me.chkbNCS.TabIndex = 12
            Me.chkbNCS.Text = "Compiled Scripts"
            Me.chkbNCS.UseVisualStyleBackColor = False
            '
            'chkbUTS
            '
            Me.chkbUTS.BackColor = System.Drawing.Color.Transparent
            Me.chkbUTS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUTS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUTS.Location = New System.Drawing.Point(236, 204)
            Me.chkbUTS.Name = "chkbUTS"
            Me.chkbUTS.Size = New System.Drawing.Size(142, 18)
            Me.chkbUTS.TabIndex = 11
            Me.chkbUTS.Text = "Sounds"
            Me.chkbUTS.UseVisualStyleBackColor = False
            '
            'chkbUTE
            '
            Me.chkbUTE.BackColor = System.Drawing.Color.Transparent
            Me.chkbUTE.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUTE.Location = New System.Drawing.Point(236, 182)
            Me.chkbUTE.Name = "chkbUTE"
            Me.chkbUTE.Size = New System.Drawing.Size(142, 18)
            Me.chkbUTE.TabIndex = 10
            Me.chkbUTE.Text = "Encounters"
            Me.chkbUTE.UseVisualStyleBackColor = False
            '
            'chkbUTT
            '
            Me.chkbUTT.BackColor = System.Drawing.Color.Transparent
            Me.chkbUTT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUTT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUTT.Location = New System.Drawing.Point(236, 160)
            Me.chkbUTT.Name = "chkbUTT"
            Me.chkbUTT.Size = New System.Drawing.Size(142, 18)
            Me.chkbUTT.TabIndex = 9
            Me.chkbUTT.Text = "Triggers"
            Me.chkbUTT.UseVisualStyleBackColor = False
            '
            'chkbUTM
            '
            Me.chkbUTM.BackColor = System.Drawing.Color.Transparent
            Me.chkbUTM.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUTM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUTM.Location = New System.Drawing.Point(236, 138)
            Me.chkbUTM.Name = "chkbUTM"
            Me.chkbUTM.Size = New System.Drawing.Size(142, 18)
            Me.chkbUTM.TabIndex = 8
            Me.chkbUTM.Text = "Merchants"
            Me.chkbUTM.UseVisualStyleBackColor = False
            '
            'chkbUTC
            '
            Me.chkbUTC.BackColor = System.Drawing.Color.Transparent
            Me.chkbUTC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUTC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUTC.Location = New System.Drawing.Point(236, 116)
            Me.chkbUTC.Name = "chkbUTC"
            Me.chkbUTC.Size = New System.Drawing.Size(142, 18)
            Me.chkbUTC.TabIndex = 7
            Me.chkbUTC.Text = "Creatures"
            Me.chkbUTC.UseVisualStyleBackColor = False
            '
            'chkbUTW
            '
            Me.chkbUTW.BackColor = System.Drawing.Color.Transparent
            Me.chkbUTW.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUTW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUTW.Location = New System.Drawing.Point(236, 94)
            Me.chkbUTW.Name = "chkbUTW"
            Me.chkbUTW.Size = New System.Drawing.Size(142, 18)
            Me.chkbUTW.TabIndex = 6
            Me.chkbUTW.Text = "Waypoints"
            Me.chkbUTW.UseVisualStyleBackColor = False
            '
            'chkbUTP
            '
            Me.chkbUTP.BackColor = System.Drawing.Color.Transparent
            Me.chkbUTP.Checked = True
            Me.chkbUTP.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbUTP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUTP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUTP.Location = New System.Drawing.Point(236, 72)
            Me.chkbUTP.Name = "chkbUTP"
            Me.chkbUTP.Size = New System.Drawing.Size(142, 18)
            Me.chkbUTP.TabIndex = 5
            Me.chkbUTP.Text = "Placeables"
            Me.chkbUTP.UseVisualStyleBackColor = False
            '
            'chkbUTD
            '
            Me.chkbUTD.BackColor = System.Drawing.Color.Transparent
            Me.chkbUTD.Checked = True
            Me.chkbUTD.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbUTD.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbUTD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbUTD.Location = New System.Drawing.Point(236, 50)
            Me.chkbUTD.Name = "chkbUTD"
            Me.chkbUTD.Size = New System.Drawing.Size(142, 18)
            Me.chkbUTD.TabIndex = 4
            Me.chkbUTD.Text = "Doors"
            Me.chkbUTD.UseVisualStyleBackColor = False
            '
            'chkbPTH
            '
            Me.chkbPTH.BackColor = System.Drawing.Color.Transparent
            Me.chkbPTH.Checked = True
            Me.chkbPTH.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbPTH.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbPTH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbPTH.Location = New System.Drawing.Point(52, 116)
            Me.chkbPTH.Name = "chkbPTH"
            Me.chkbPTH.Size = New System.Drawing.Size(154, 18)
            Me.chkbPTH.TabIndex = 3
            Me.chkbPTH.Text = "Path Info"
            Me.chkbPTH.UseVisualStyleBackColor = False
            '
            'chkbIFO
            '
            Me.chkbIFO.BackColor = System.Drawing.Color.Transparent
            Me.chkbIFO.Checked = True
            Me.chkbIFO.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbIFO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbIFO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbIFO.Location = New System.Drawing.Point(52, 94)
            Me.chkbIFO.Name = "chkbIFO"
            Me.chkbIFO.Size = New System.Drawing.Size(154, 18)
            Me.chkbIFO.TabIndex = 2
            Me.chkbIFO.Text = "Module.ifo"
            Me.chkbIFO.UseVisualStyleBackColor = False
            '
            'chkbARE
            '
            Me.chkbARE.BackColor = System.Drawing.Color.Transparent
            Me.chkbARE.Checked = True
            Me.chkbARE.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbARE.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbARE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbARE.Location = New System.Drawing.Point(52, 72)
            Me.chkbARE.Name = "chkbARE"
            Me.chkbARE.Size = New System.Drawing.Size(154, 18)
            Me.chkbARE.TabIndex = 1
            Me.chkbARE.Text = "Static Module Info"
            Me.chkbARE.UseVisualStyleBackColor = False
            '
            'chkbGIT
            '
            Me.chkbGIT.BackColor = System.Drawing.Color.Transparent
            Me.chkbGIT.Checked = True
            Me.chkbGIT.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbGIT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbGIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbGIT.Location = New System.Drawing.Point(52, 50)
            Me.chkbGIT.Name = "chkbGIT"
            Me.chkbGIT.Size = New System.Drawing.Size(154, 18)
            Me.chkbGIT.TabIndex = 0
            Me.chkbGIT.Text = "Dynamic Module Info"
            Me.chkbGIT.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(52, 20)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(326, 18)
            Me.Label1.TabIndex = 16
            Me.Label1.Text = "Select the resource types to extract:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 348)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(440, 62)
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
            Me.btnCancel.Location = New System.Drawing.Point(332, 20)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(76, 26)
            Me.btnCancel.TabIndex = 14
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
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
            Me.btnOK.Location = New System.Drawing.Point(240, 20)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(84, 26)
            Me.btnOK.TabIndex = 13
            Me.btnOK.Text = "Next >>"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New System.Drawing.Size(440, 1)
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
            Me.pnlHeader.Size = New System.Drawing.Size(440, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(24, 42)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(384, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Choose which module resource categories should be extracted."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(22, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(384, 24)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Resource Type Selector"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 74)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(440, 2)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmResourceTypeSelector
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(440, 410)
            Me.Controls.Add(Me.pnlRoot)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmResourceTypeSelector"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Resource Type Selector"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace