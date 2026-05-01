Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmRefSearchCriteria
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

        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents tbSearchString As Global.System.Windows.Forms.TextBox
        Friend WithEvents CheckBox1 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox2 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox3 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox4 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox5 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox6 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox7 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox8 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox11 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox12 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox13 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox16 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox18 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnSetAll As Global.System.Windows.Forms.Button
        Friend WithEvents btnClearAll As Global.System.Windows.Forms.Button
        Friend WithEvents rbtnSensitive As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbtnInsensitive As Global.System.Windows.Forms.RadioButton
        Friend WithEvents gboxFileTypes As Global.System.Windows.Forms.GroupBox
        Friend WithEvents gboxArchiveTypes As Global.System.Windows.Forms.GroupBox
        Friend WithEvents chkbScripts As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbTemplates As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbRIMs As Global.System.Windows.Forms.CheckBox
        Friend WithEvents gboxGFF As Global.System.Windows.Forms.GroupBox
        Friend WithEvents CheckBox22 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox23 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents gboxScript As Global.System.Windows.Forms.GroupBox
        Friend WithEvents chkbAllBifs As Global.System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox2 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents rbSearchKotor1 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbSearchKotor2 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents gboxCaseSens As Global.System.Windows.Forms.GroupBox
        Friend WithEvents gboxSearchString As Global.System.Windows.Forms.GroupBox

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
            Me.gboxSearchString = New System.Windows.Forms.GroupBox()
            Me.tbSearchString = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rbSearchKotor1 = New System.Windows.Forms.RadioButton()
            Me.rbSearchKotor2 = New System.Windows.Forms.RadioButton()
            Me.gboxCaseSens = New System.Windows.Forms.GroupBox()
            Me.rbtnSensitive = New System.Windows.Forms.RadioButton()
            Me.rbtnInsensitive = New System.Windows.Forms.RadioButton()
            Me.gboxArchiveTypes = New System.Windows.Forms.GroupBox()
            Me.chkbScripts = New System.Windows.Forms.CheckBox()
            Me.chkbTemplates = New System.Windows.Forms.CheckBox()
            Me.chkbRIMs = New System.Windows.Forms.CheckBox()
            Me.chkbAllBifs = New System.Windows.Forms.CheckBox()
            Me.gboxFileTypes = New System.Windows.Forms.GroupBox()
            Me.btnSetAll = New System.Windows.Forms.Button()
            Me.btnClearAll = New System.Windows.Forms.Button()
            Me.gboxGFF = New System.Windows.Forms.GroupBox()
            Me.CheckBox2 = New System.Windows.Forms.CheckBox()
            Me.CheckBox3 = New System.Windows.Forms.CheckBox()
            Me.CheckBox4 = New System.Windows.Forms.CheckBox()
            Me.CheckBox5 = New System.Windows.Forms.CheckBox()
            Me.CheckBox6 = New System.Windows.Forms.CheckBox()
            Me.CheckBox7 = New System.Windows.Forms.CheckBox()
            Me.CheckBox8 = New System.Windows.Forms.CheckBox()
            Me.CheckBox11 = New System.Windows.Forms.CheckBox()
            Me.CheckBox13 = New System.Windows.Forms.CheckBox()
            Me.CheckBox16 = New System.Windows.Forms.CheckBox()
            Me.CheckBox18 = New System.Windows.Forms.CheckBox()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            Me.CheckBox12 = New System.Windows.Forms.CheckBox()
            Me.gboxScript = New System.Windows.Forms.GroupBox()
            Me.CheckBox22 = New System.Windows.Forms.CheckBox()
            Me.CheckBox23 = New System.Windows.Forms.CheckBox()
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
            Me.gboxSearchString.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.gboxCaseSens.SuspendLayout()
            Me.gboxArchiveTypes.SuspendLayout()
            Me.gboxFileTypes.SuspendLayout()
            Me.gboxGFF.SuspendLayout()
            Me.gboxScript.SuspendLayout()
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
            Me.pnlRoot.Size = New System.Drawing.Size(430, 722)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.gboxSearchString)
            Me.pnlBody.Controls.Add(Me.GroupBox2)
            Me.pnlBody.Controls.Add(Me.gboxCaseSens)
            Me.pnlBody.Controls.Add(Me.gboxArchiveTypes)
            Me.pnlBody.Controls.Add(Me.gboxFileTypes)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 88)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(18, 16, 18, 16)
            Me.pnlBody.Size = New System.Drawing.Size(430, 563)
            Me.pnlBody.TabIndex = 1
            '
            'gboxSearchString
            '
            Me.gboxSearchString.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.gboxSearchString.Controls.Add(Me.tbSearchString)
            Me.gboxSearchString.Enabled = False
            Me.gboxSearchString.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gboxSearchString.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gboxSearchString.Location = New System.Drawing.Point(22, 102)
            Me.gboxSearchString.Name = "gboxSearchString"
            Me.gboxSearchString.Size = New System.Drawing.Size(220, 73)
            Me.gboxSearchString.TabIndex = 1
            Me.gboxSearchString.TabStop = False
            Me.gboxSearchString.Text = "String to search for"
            '
            'tbSearchString
            '
            Me.tbSearchString.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.tbSearchString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbSearchString.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbSearchString.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSearchString.Location = New System.Drawing.Point(16, 28)
            Me.tbSearchString.Name = "tbSearchString"
            Me.tbSearchString.Size = New System.Drawing.Size(188, 22)
            Me.tbSearchString.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.GroupBox2.Controls.Add(Me.rbSearchKotor1)
            Me.GroupBox2.Controls.Add(Me.rbSearchKotor2)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.GroupBox2.Location = New System.Drawing.Point(22, 18)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(368, 74)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search within"
            '
            'rbSearchKotor1
            '
            Me.rbSearchKotor1.BackColor = System.Drawing.Color.Transparent
            Me.rbSearchKotor1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbSearchKotor1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbSearchKotor1.Location = New System.Drawing.Point(24, 18)
            Me.rbSearchKotor1.Name = "rbSearchKotor1"
            Me.rbSearchKotor1.Size = New System.Drawing.Size(86, 24)
            Me.rbSearchKotor1.TabIndex = 0
            Me.rbSearchKotor1.Text = "KotOR I"
            Me.rbSearchKotor1.UseVisualStyleBackColor = False
            '
            'rbSearchKotor2
            '
            Me.rbSearchKotor2.BackColor = System.Drawing.Color.Transparent
            Me.rbSearchKotor2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbSearchKotor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbSearchKotor2.Location = New System.Drawing.Point(24, 46)
            Me.rbSearchKotor2.Name = "rbSearchKotor2"
            Me.rbSearchKotor2.Size = New System.Drawing.Size(86, 23)
            Me.rbSearchKotor2.TabIndex = 1
            Me.rbSearchKotor2.Text = "KotOR II"
            Me.rbSearchKotor2.UseVisualStyleBackColor = False
            '
            'gboxCaseSens
            '
            Me.gboxCaseSens.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.gboxCaseSens.Controls.Add(Me.rbtnSensitive)
            Me.gboxCaseSens.Controls.Add(Me.rbtnInsensitive)
            Me.gboxCaseSens.Enabled = False
            Me.gboxCaseSens.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gboxCaseSens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gboxCaseSens.Location = New System.Drawing.Point(258, 102)
            Me.gboxCaseSens.Name = "gboxCaseSens"
            Me.gboxCaseSens.Size = New System.Drawing.Size(132, 73)
            Me.gboxCaseSens.TabIndex = 2
            Me.gboxCaseSens.TabStop = False
            Me.gboxCaseSens.Text = "Case"
            '
            'rbtnSensitive
            '
            Me.rbtnSensitive.BackColor = System.Drawing.Color.Transparent
            Me.rbtnSensitive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtnSensitive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbtnSensitive.Location = New System.Drawing.Point(20, 18)
            Me.rbtnSensitive.Name = "rbtnSensitive"
            Me.rbtnSensitive.Size = New System.Drawing.Size(96, 24)
            Me.rbtnSensitive.TabIndex = 0
            Me.rbtnSensitive.Text = "Sensitive"
            Me.rbtnSensitive.UseVisualStyleBackColor = False
            '
            'rbtnInsensitive
            '
            Me.rbtnInsensitive.BackColor = System.Drawing.Color.Transparent
            Me.rbtnInsensitive.Checked = True
            Me.rbtnInsensitive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtnInsensitive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.rbtnInsensitive.Location = New System.Drawing.Point(20, 44)
            Me.rbtnInsensitive.Name = "rbtnInsensitive"
            Me.rbtnInsensitive.Size = New System.Drawing.Size(96, 23)
            Me.rbtnInsensitive.TabIndex = 1
            Me.rbtnInsensitive.TabStop = True
            Me.rbtnInsensitive.Text = "Insensitive"
            Me.rbtnInsensitive.UseVisualStyleBackColor = False
            '
            'gboxArchiveTypes
            '
            Me.gboxArchiveTypes.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.gboxArchiveTypes.Controls.Add(Me.chkbScripts)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbTemplates)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbRIMs)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbAllBifs)
            Me.gboxArchiveTypes.Enabled = False
            Me.gboxArchiveTypes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gboxArchiveTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gboxArchiveTypes.Location = New System.Drawing.Point(22, 187)
            Me.gboxArchiveTypes.Name = "gboxArchiveTypes"
            Me.gboxArchiveTypes.Size = New System.Drawing.Size(368, 111)
            Me.gboxArchiveTypes.TabIndex = 3
            Me.gboxArchiveTypes.TabStop = False
            Me.gboxArchiveTypes.Text = "Archive types to search in"
            '
            'chkbScripts
            '
            Me.chkbScripts.BackColor = System.Drawing.Color.Transparent
            Me.chkbScripts.Checked = True
            Me.chkbScripts.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbScripts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbScripts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbScripts.Location = New System.Drawing.Point(82, 74)
            Me.chkbScripts.Name = "chkbScripts"
            Me.chkbScripts.Size = New System.Drawing.Size(98, 28)
            Me.chkbScripts.TabIndex = 2
            Me.chkbScripts.Text = "Scripts.bif"
            Me.chkbScripts.UseVisualStyleBackColor = False
            '
            'chkbTemplates
            '
            Me.chkbTemplates.BackColor = System.Drawing.Color.Transparent
            Me.chkbTemplates.Checked = True
            Me.chkbTemplates.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbTemplates.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbTemplates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbTemplates.Location = New System.Drawing.Point(82, 46)
            Me.chkbTemplates.Name = "chkbTemplates"
            Me.chkbTemplates.Size = New System.Drawing.Size(112, 28)
            Me.chkbTemplates.TabIndex = 1
            Me.chkbTemplates.Text = "Templates.bif"
            Me.chkbTemplates.UseVisualStyleBackColor = False
            '
            'chkbRIMs
            '
            Me.chkbRIMs.BackColor = System.Drawing.Color.Transparent
            Me.chkbRIMs.Checked = True
            Me.chkbRIMs.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbRIMs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbRIMs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbRIMs.Location = New System.Drawing.Point(244, 18)
            Me.chkbRIMs.Name = "chkbRIMs"
            Me.chkbRIMs.Size = New System.Drawing.Size(80, 28)
            Me.chkbRIMs.TabIndex = 3
            Me.chkbRIMs.Text = "RIMs"
            Me.chkbRIMs.UseVisualStyleBackColor = False
            '
            'chkbAllBifs
            '
            Me.chkbAllBifs.BackColor = System.Drawing.Color.Transparent
            Me.chkbAllBifs.Checked = True
            Me.chkbAllBifs.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbAllBifs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbAllBifs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAllBifs.Location = New System.Drawing.Point(82, 18)
            Me.chkbAllBifs.Name = "chkbAllBifs"
            Me.chkbAllBifs.Size = New System.Drawing.Size(92, 28)
            Me.chkbAllBifs.TabIndex = 0
            Me.chkbAllBifs.Text = "All BIFs"
            Me.chkbAllBifs.UseVisualStyleBackColor = False
            '
            'gboxFileTypes
            '
            Me.gboxFileTypes.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.gboxFileTypes.Controls.Add(Me.btnSetAll)
            Me.gboxFileTypes.Controls.Add(Me.btnClearAll)
            Me.gboxFileTypes.Controls.Add(Me.gboxGFF)
            Me.gboxFileTypes.Controls.Add(Me.gboxScript)
            Me.gboxFileTypes.Enabled = False
            Me.gboxFileTypes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gboxFileTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gboxFileTypes.Location = New System.Drawing.Point(22, 316)
            Me.gboxFileTypes.Name = "gboxFileTypes"
            Me.gboxFileTypes.Size = New System.Drawing.Size(368, 219)
            Me.gboxFileTypes.TabIndex = 4
            Me.gboxFileTypes.TabStop = False
            Me.gboxFileTypes.Text = "File types to search in"
            '
            'btnSetAll
            '
            Me.btnSetAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSetAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSetAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSetAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetAll.Location = New System.Drawing.Point(164, 178)
            Me.btnSetAll.Name = "btnSetAll"
            Me.btnSetAll.Size = New System.Drawing.Size(84, 30)
            Me.btnSetAll.TabIndex = 2
            Me.btnSetAll.Text = "Set All"
            Me.btnSetAll.UseVisualStyleBackColor = False
            '
            'btnClearAll
            '
            Me.btnClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnClearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClearAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnClearAll.Location = New System.Drawing.Point(260, 178)
            Me.btnClearAll.Name = "btnClearAll"
            Me.btnClearAll.Size = New System.Drawing.Size(84, 30)
            Me.btnClearAll.TabIndex = 3
            Me.btnClearAll.Text = "Clear All"
            Me.btnClearAll.UseVisualStyleBackColor = False
            '
            'gboxGFF
            '
            Me.gboxGFF.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.gboxGFF.Controls.Add(Me.CheckBox2)
            Me.gboxGFF.Controls.Add(Me.CheckBox3)
            Me.gboxGFF.Controls.Add(Me.CheckBox4)
            Me.gboxGFF.Controls.Add(Me.CheckBox5)
            Me.gboxGFF.Controls.Add(Me.CheckBox6)
            Me.gboxGFF.Controls.Add(Me.CheckBox7)
            Me.gboxGFF.Controls.Add(Me.CheckBox8)
            Me.gboxGFF.Controls.Add(Me.CheckBox11)
            Me.gboxGFF.Controls.Add(Me.CheckBox13)
            Me.gboxGFF.Controls.Add(Me.CheckBox16)
            Me.gboxGFF.Controls.Add(Me.CheckBox18)
            Me.gboxGFF.Controls.Add(Me.CheckBox1)
            Me.gboxGFF.Controls.Add(Me.CheckBox12)
            Me.gboxGFF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gboxGFF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gboxGFF.Location = New System.Drawing.Point(16, 32)
            Me.gboxGFF.Name = "gboxGFF"
            Me.gboxGFF.Size = New System.Drawing.Size(244, 139)
            Me.gboxGFF.TabIndex = 0
            Me.gboxGFF.TabStop = False
            Me.gboxGFF.Text = "GFF-based files"
            '
            'CheckBox2
            '
            Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox2.Checked = True
            Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox2.Location = New System.Drawing.Point(8, 106)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox2.TabIndex = 3
            Me.CheckBox2.Text = "dlg"
            Me.CheckBox2.UseVisualStyleBackColor = False
            '
            'CheckBox3
            '
            Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox3.Checked = True
            Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox3.Location = New System.Drawing.Point(62, 28)
            Me.CheckBox3.Name = "CheckBox3"
            Me.CheckBox3.Size = New System.Drawing.Size(52, 20)
            Me.CheckBox3.TabIndex = 4
            Me.CheckBox3.Text = "utc"
            Me.CheckBox3.UseVisualStyleBackColor = False
            '
            'CheckBox4
            '
            Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox4.Checked = True
            Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox4.Location = New System.Drawing.Point(62, 54)
            Me.CheckBox4.Name = "CheckBox4"
            Me.CheckBox4.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox4.TabIndex = 5
            Me.CheckBox4.Text = "utd"
            Me.CheckBox4.UseVisualStyleBackColor = False
            '
            'CheckBox5
            '
            Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox5.Checked = True
            Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox5.Location = New System.Drawing.Point(62, 106)
            Me.CheckBox5.Name = "CheckBox5"
            Me.CheckBox5.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox5.TabIndex = 7
            Me.CheckBox5.Text = "uti"
            Me.CheckBox5.UseVisualStyleBackColor = False
            '
            'CheckBox6
            '
            Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox6.Checked = True
            Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox6.Location = New System.Drawing.Point(118, 28)
            Me.CheckBox6.Name = "CheckBox6"
            Me.CheckBox6.Size = New System.Drawing.Size(52, 20)
            Me.CheckBox6.TabIndex = 8
            Me.CheckBox6.Text = "utm"
            Me.CheckBox6.UseVisualStyleBackColor = False
            '
            'CheckBox7
            '
            Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox7.Checked = True
            Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox7.Location = New System.Drawing.Point(62, 81)
            Me.CheckBox7.Name = "CheckBox7"
            Me.CheckBox7.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox7.TabIndex = 6
            Me.CheckBox7.Text = "ute"
            Me.CheckBox7.UseVisualStyleBackColor = False
            '
            'CheckBox8
            '
            Me.CheckBox8.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox8.Checked = True
            Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox8.Location = New System.Drawing.Point(118, 106)
            Me.CheckBox8.Name = "CheckBox8"
            Me.CheckBox8.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox8.TabIndex = 11
            Me.CheckBox8.Text = "utt"
            Me.CheckBox8.UseVisualStyleBackColor = False
            '
            'CheckBox11
            '
            Me.CheckBox11.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox11.Checked = True
            Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox11.Location = New System.Drawing.Point(118, 54)
            Me.CheckBox11.Name = "CheckBox11"
            Me.CheckBox11.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox11.TabIndex = 9
            Me.CheckBox11.Text = "utp"
            Me.CheckBox11.UseVisualStyleBackColor = False
            '
            'CheckBox13
            '
            Me.CheckBox13.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox13.Checked = True
            Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox13.Location = New System.Drawing.Point(118, 81)
            Me.CheckBox13.Name = "CheckBox13"
            Me.CheckBox13.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox13.TabIndex = 10
            Me.CheckBox13.Text = "uts"
            Me.CheckBox13.UseVisualStyleBackColor = False
            '
            'CheckBox16
            '
            Me.CheckBox16.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox16.Checked = True
            Me.CheckBox16.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox16.Location = New System.Drawing.Point(8, 81)
            Me.CheckBox16.Name = "CheckBox16"
            Me.CheckBox16.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox16.TabIndex = 2
            Me.CheckBox16.Text = "ifo"
            Me.CheckBox16.UseVisualStyleBackColor = False
            '
            'CheckBox18
            '
            Me.CheckBox18.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox18.Checked = True
            Me.CheckBox18.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox18.Location = New System.Drawing.Point(8, 54)
            Me.CheckBox18.Name = "CheckBox18"
            Me.CheckBox18.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox18.TabIndex = 1
            Me.CheckBox18.Text = "git"
            Me.CheckBox18.UseVisualStyleBackColor = False
            '
            'CheckBox1
            '
            Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox1.Checked = True
            Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox1.Location = New System.Drawing.Point(8, 28)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(52, 20)
            Me.CheckBox1.TabIndex = 0
            Me.CheckBox1.Text = "are"
            Me.CheckBox1.UseVisualStyleBackColor = False
            '
            'CheckBox12
            '
            Me.CheckBox12.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox12.Checked = True
            Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox12.Location = New System.Drawing.Point(174, 28)
            Me.CheckBox12.Name = "CheckBox12"
            Me.CheckBox12.Size = New System.Drawing.Size(52, 20)
            Me.CheckBox12.TabIndex = 12
            Me.CheckBox12.Text = "utw"
            Me.CheckBox12.UseVisualStyleBackColor = False
            '
            'gboxScript
            '
            Me.gboxScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.gboxScript.Controls.Add(Me.CheckBox22)
            Me.gboxScript.Controls.Add(Me.CheckBox23)
            Me.gboxScript.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gboxScript.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gboxScript.Location = New System.Drawing.Point(274, 32)
            Me.gboxScript.Name = "gboxScript"
            Me.gboxScript.Size = New System.Drawing.Size(78, 102)
            Me.gboxScript.TabIndex = 1
            Me.gboxScript.TabStop = False
            Me.gboxScript.Text = "Scripts"
            '
            'CheckBox22
            '
            Me.CheckBox22.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox22.Checked = True
            Me.CheckBox22.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox22.Location = New System.Drawing.Point(16, 37)
            Me.CheckBox22.Name = "CheckBox22"
            Me.CheckBox22.Size = New System.Drawing.Size(52, 21)
            Me.CheckBox22.TabIndex = 0
            Me.CheckBox22.Text = "ncs"
            Me.CheckBox22.UseVisualStyleBackColor = False
            '
            'CheckBox23
            '
            Me.CheckBox23.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox23.Checked = True
            Me.CheckBox23.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.CheckBox23.Location = New System.Drawing.Point(16, 65)
            Me.CheckBox23.Name = "CheckBox23"
            Me.CheckBox23.Size = New System.Drawing.Size(52, 20)
            Me.CheckBox23.TabIndex = 1
            Me.CheckBox23.Text = "nss"
            Me.CheckBox23.UseVisualStyleBackColor = False
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.lblFooterSeparator)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 651)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(430, 71)
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
            Me.btnCancel.Location = New System.Drawing.Point(322, 23)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(76, 30)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnOK.Enabled = False
            Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnOK.Location = New System.Drawing.Point(238, 23)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(76, 30)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'lblFooterSeparator
            '
            Me.lblFooterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterSeparator.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterSeparator.Name = "lblFooterSeparator"
            Me.lblFooterSeparator.Size = New System.Drawing.Size(430, 1)
            Me.lblFooterSeparator.TabIndex = 2
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
            Me.pnlHeader.Size = New System.Drawing.Size(430, 88)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(24, 48)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(374, 21)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Configure archive, file-type, case, and game search filters."
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(22, 17)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(374, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Search Criteria"
            '
            'lblHeaderSeparator
            '
            Me.lblHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderSeparator.Location = New System.Drawing.Point(0, 85)
            Me.lblHeaderSeparator.Name = "lblHeaderSeparator"
            Me.lblHeaderSeparator.Size = New System.Drawing.Size(430, 3)
            Me.lblHeaderSeparator.TabIndex = 2
            '
            'frmRefSearchCriteria
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(430, 722)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.MaximizeBox = False
            Me.MinimumSize = New System.Drawing.Size(438, 646)
            Me.Name = "frmRefSearchCriteria"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.Text = "Search Criteria"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.gboxSearchString.ResumeLayout(False)
            Me.gboxSearchString.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.gboxCaseSens.ResumeLayout(False)
            Me.gboxArchiveTypes.ResumeLayout(False)
            Me.gboxFileTypes.ResumeLayout(False)
            Me.gboxGFF.ResumeLayout(False)
            Me.gboxScript.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace