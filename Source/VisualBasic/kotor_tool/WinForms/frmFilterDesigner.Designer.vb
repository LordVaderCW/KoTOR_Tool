Option Strict Off
Option Explicit On

Imports System.Windows.Forms

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmFilterDesigner
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmFilterDesigner.Designer.vb
        '
        ' Restored / facelifted Filter Editor for the KoTOR Tool Restoration.
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

        Friend WithEvents tbCriteria1 As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnReset As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxMatchOperator1 As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxConcatOperator1 As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents btnAddFilter As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxColumnName1 As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnRemove1 As Global.System.Windows.Forms.Button
        Friend WithEvents HelpProvider1 As Global.System.Windows.Forms.HelpProvider

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFilterRow As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label
        Friend WithEvents lblMatchOperator As Global.System.Windows.Forms.Label
        Friend WithEvents lblCriteria As Global.System.Windows.Forms.Label
        Friend WithEvents lblConcatOperator As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
            Me.cmbxColumnName1 = New System.Windows.Forms.ComboBox()
            Me.cmbxMatchOperator1 = New System.Windows.Forms.ComboBox()
            Me.tbCriteria1 = New System.Windows.Forms.TextBox()
            Me.cmbxConcatOperator1 = New System.Windows.Forms.ComboBox()
            Me.btnRemove1 = New System.Windows.Forms.Button()
            Me.btnAddFilter = New System.Windows.Forms.Button()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.pnlFilterRow = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblMatchOperator = New System.Windows.Forms.Label()
            Me.lblCriteria = New System.Windows.Forms.Label()
            Me.lblConcatOperator = New System.Windows.Forms.Label()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlFilterRow.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmbxColumnName1
            '
            Me.cmbxColumnName1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxColumnName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxColumnName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxColumnName1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxColumnName1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.cmbxColumnName1, "Choose the Column for this filter element")
            Me.cmbxColumnName1.Location = New System.Drawing.Point(12, 32)
            Me.cmbxColumnName1.Name = "cmbxColumnName1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxColumnName1, True)
            Me.cmbxColumnName1.Size = New System.Drawing.Size(136, 21)
            Me.cmbxColumnName1.TabIndex = 0
            Me.cmbxColumnName1.Tag = "cn1"
            '
            'cmbxMatchOperator1
            '
            Me.cmbxMatchOperator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxMatchOperator1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMatchOperator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxMatchOperator1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxMatchOperator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.cmbxMatchOperator1, "Choose the Match Operator for this filter element")
            Me.cmbxMatchOperator1.Items.AddRange(New Object() {"LIKE", "NOT LIKE", "=", "<>", "<", ">", "<=", ">=", "IN", "NOT IN"})
            Me.cmbxMatchOperator1.Location = New System.Drawing.Point(158, 32)
            Me.cmbxMatchOperator1.MaxDropDownItems = 10
            Me.cmbxMatchOperator1.Name = "cmbxMatchOperator1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxMatchOperator1, True)
            Me.cmbxMatchOperator1.Size = New System.Drawing.Size(82, 21)
            Me.cmbxMatchOperator1.TabIndex = 1
            Me.cmbxMatchOperator1.Tag = "mo1"
            '
            'tbCriteria1
            '
            Me.tbCriteria1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbCriteria1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCriteria1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbCriteria1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.tbCriteria1, "Enter the Criteria String for this filter element")
            Me.tbCriteria1.Location = New System.Drawing.Point(250, 32)
            Me.tbCriteria1.Name = "tbCriteria1"
            Me.HelpProvider1.SetShowHelp(Me.tbCriteria1, True)
            Me.tbCriteria1.Size = New System.Drawing.Size(136, 22)
            Me.tbCriteria1.TabIndex = 2
            Me.tbCriteria1.Tag = "cr1"
            '
            'cmbxConcatOperator1
            '
            Me.cmbxConcatOperator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxConcatOperator1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxConcatOperator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxConcatOperator1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxConcatOperator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.cmbxConcatOperator1, "Choose the Boolean Concatenation Operator for this filter element. This is only r" &
        "equired if another filter element will follow this one.")
            Me.cmbxConcatOperator1.Items.AddRange(New Object() {"", "AND", "OR"})
            Me.cmbxConcatOperator1.Location = New System.Drawing.Point(398, 32)
            Me.cmbxConcatOperator1.Name = "cmbxConcatOperator1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxConcatOperator1, True)
            Me.cmbxConcatOperator1.Size = New System.Drawing.Size(56, 21)
            Me.cmbxConcatOperator1.TabIndex = 3
            Me.cmbxConcatOperator1.Tag = "co1"
            '
            'btnRemove1
            '
            Me.btnRemove1.AccessibleDescription = "This is a template don't move it"
            Me.btnRemove1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnRemove1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnRemove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnRemove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnRemove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove1.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRemove1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.btnRemove1, "Click to remove this filter element")
            Me.btnRemove1.Location = New System.Drawing.Point(464, 32)
            Me.btnRemove1.Name = "btnRemove1"
            Me.HelpProvider1.SetShowHelp(Me.btnRemove1, True)
            Me.btnRemove1.Size = New System.Drawing.Size(21, 21)
            Me.btnRemove1.TabIndex = 105
            Me.btnRemove1.Text = "This is a template don't move it"
            Me.btnRemove1.UseVisualStyleBackColor = False
            Me.btnRemove1.Visible = False
            '
            'btnAddFilter
            '
            Me.btnAddFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAddFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAddFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAddFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAddFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.btnAddFilter, "Add a new filter element")
            Me.btnAddFilter.Location = New System.Drawing.Point(16, 91)
            Me.btnAddFilter.Name = "btnAddFilter"
            Me.HelpProvider1.SetShowHelp(Me.btnAddFilter, True)
            Me.btnAddFilter.Size = New System.Drawing.Size(526, 25)
            Me.btnAddFilter.TabIndex = 100
            Me.btnAddFilter.Text = "Add Filter"
            Me.btnAddFilter.UseVisualStyleBackColor = False
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
            Me.pnlRoot.Size = New System.Drawing.Size(560, 265)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.pnlFilterRow)
            Me.pnlBody.Controls.Add(Me.btnAddFilter)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(16, 14, 16, 12)
            Me.pnlBody.Size = New System.Drawing.Size(558, 135)
            Me.pnlBody.TabIndex = 1
            '
            'pnlFilterRow
            '
            Me.pnlFilterRow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlFilterRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFilterRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlFilterRow.Controls.Add(Me.Label1)
            Me.pnlFilterRow.Controls.Add(Me.lblMatchOperator)
            Me.pnlFilterRow.Controls.Add(Me.lblCriteria)
            Me.pnlFilterRow.Controls.Add(Me.lblConcatOperator)
            Me.pnlFilterRow.Controls.Add(Me.cmbxColumnName1)
            Me.pnlFilterRow.Controls.Add(Me.cmbxMatchOperator1)
            Me.pnlFilterRow.Controls.Add(Me.tbCriteria1)
            Me.pnlFilterRow.Controls.Add(Me.cmbxConcatOperator1)
            Me.pnlFilterRow.Controls.Add(Me.btnRemove1)
            Me.pnlFilterRow.Location = New System.Drawing.Point(16, 14)
            Me.pnlFilterRow.Name = "pnlFilterRow"
            Me.pnlFilterRow.Size = New System.Drawing.Size(526, 72)
            Me.pnlFilterRow.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(12, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(136, 18)
            Me.Label1.TabIndex = 43
            Me.Label1.Text = "Column"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMatchOperator
            '
            Me.lblMatchOperator.BackColor = System.Drawing.Color.Transparent
            Me.lblMatchOperator.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMatchOperator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblMatchOperator.Location = New System.Drawing.Point(158, 8)
            Me.lblMatchOperator.Name = "lblMatchOperator"
            Me.lblMatchOperator.Size = New System.Drawing.Size(88, 18)
            Me.lblMatchOperator.TabIndex = 44
            Me.lblMatchOperator.Text = "Match"
            Me.lblMatchOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCriteria
            '
            Me.lblCriteria.BackColor = System.Drawing.Color.Transparent
            Me.lblCriteria.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCriteria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblCriteria.Location = New System.Drawing.Point(250, 8)
            Me.lblCriteria.Name = "lblCriteria"
            Me.lblCriteria.Size = New System.Drawing.Size(142, 18)
            Me.lblCriteria.TabIndex = 45
            Me.lblCriteria.Text = "Criteria"
            Me.lblCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblConcatOperator
            '
            Me.lblConcatOperator.BackColor = System.Drawing.Color.Transparent
            Me.lblConcatOperator.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConcatOperator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblConcatOperator.Location = New System.Drawing.Point(398, 8)
            Me.lblConcatOperator.Name = "lblConcatOperator"
            Me.lblConcatOperator.Size = New System.Drawing.Size(58, 18)
            Me.lblConcatOperator.TabIndex = 46
            Me.lblConcatOperator.Text = "Join"
            Me.lblConcatOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(16, 121)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(526, 2)
            Me.lblSeparatorBottom.TabIndex = 47
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.btnReset)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 211)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(558, 52)
            Me.pnlFooter.TabIndex = 2
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
            Me.btnOK.Location = New System.Drawing.Point(272, 13)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(84, 25)
            Me.btnOK.TabIndex = 101
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'btnReset
            '
            Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnReset.Location = New System.Drawing.Point(364, 13)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(84, 25)
            Me.btnReset.TabIndex = 102
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New System.Drawing.Point(456, 13)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(84, 25)
            Me.btnCancel.TabIndex = 103
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(558, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(558, 2)
            Me.lblSeparatorTop.TabIndex = 2
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSubtitle.AutoEllipsis = True
            Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(18, 45)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(522, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Create column-based filters for Dialog.tlk and table-style editor views."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(524, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Filter Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmFilterDesigner
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(560, 265)
            Me.Controls.Add(Me.pnlRoot)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.HelpButton = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmFilterDesigner"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Filter Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlFilterRow.ResumeLayout(False)
            Me.pnlFilterRow.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace