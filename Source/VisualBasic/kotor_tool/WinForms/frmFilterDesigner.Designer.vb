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
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmFilterDesigner))
            Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.pnlFilterRow = New Global.System.Windows.Forms.Panel()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.lblMatchOperator = New Global.System.Windows.Forms.Label()
            Me.lblCriteria = New Global.System.Windows.Forms.Label()
            Me.lblConcatOperator = New Global.System.Windows.Forms.Label()
            Me.cmbxColumnName1 = New Global.System.Windows.Forms.ComboBox()
            Me.cmbxMatchOperator1 = New Global.System.Windows.Forms.ComboBox()
            Me.tbCriteria1 = New Global.System.Windows.Forms.TextBox()
            Me.cmbxConcatOperator1 = New Global.System.Windows.Forms.ComboBox()
            Me.btnRemove1 = New Global.System.Windows.Forms.Button()
            Me.btnAddFilter = New Global.System.Windows.Forms.Button()
            Me.lblSeparatorBottom = New Global.System.Windows.Forms.Label()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnReset = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New Global.System.Windows.Forms.Label()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlFilterRow.SuspendLayout()
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
            Me.pnlRoot.Size = New Global.System.Drawing.Size(560, 260)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.pnlFilterRow)
            Me.pnlBody.Controls.Add(Me.btnAddFilter)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(16, 14, 16, 12)
            Me.pnlBody.Size = New Global.System.Drawing.Size(558, 130)
            Me.pnlBody.TabIndex = 1
            '
            'pnlFilterRow
            '
            Me.pnlFilterRow.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.pnlFilterRow.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFilterRow.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlFilterRow.Controls.Add(Me.Label1)
            Me.pnlFilterRow.Controls.Add(Me.lblMatchOperator)
            Me.pnlFilterRow.Controls.Add(Me.lblCriteria)
            Me.pnlFilterRow.Controls.Add(Me.lblConcatOperator)
            Me.pnlFilterRow.Controls.Add(Me.cmbxColumnName1)
            Me.pnlFilterRow.Controls.Add(Me.cmbxMatchOperator1)
            Me.pnlFilterRow.Controls.Add(Me.tbCriteria1)
            Me.pnlFilterRow.Controls.Add(Me.cmbxConcatOperator1)
            Me.pnlFilterRow.Controls.Add(Me.btnRemove1)
            Me.pnlFilterRow.Location = New Global.System.Drawing.Point(16, 14)
            Me.pnlFilterRow.Name = "pnlFilterRow"
            Me.pnlFilterRow.Size = New Global.System.Drawing.Size(526, 72)
            Me.pnlFilterRow.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(12, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(136, 18)
            Me.Label1.TabIndex = 43
            Me.Label1.Text = "Column"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMatchOperator
            '
            Me.lblMatchOperator.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblMatchOperator.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMatchOperator.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblMatchOperator.Location = New Global.System.Drawing.Point(158, 8)
            Me.lblMatchOperator.Name = "lblMatchOperator"
            Me.lblMatchOperator.Size = New Global.System.Drawing.Size(88, 18)
            Me.lblMatchOperator.TabIndex = 44
            Me.lblMatchOperator.Text = "Match"
            Me.lblMatchOperator.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCriteria
            '
            Me.lblCriteria.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblCriteria.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCriteria.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblCriteria.Location = New Global.System.Drawing.Point(250, 8)
            Me.lblCriteria.Name = "lblCriteria"
            Me.lblCriteria.Size = New Global.System.Drawing.Size(142, 18)
            Me.lblCriteria.TabIndex = 45
            Me.lblCriteria.Text = "Criteria"
            Me.lblCriteria.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblConcatOperator
            '
            Me.lblConcatOperator.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblConcatOperator.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConcatOperator.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblConcatOperator.Location = New Global.System.Drawing.Point(398, 8)
            Me.lblConcatOperator.Name = "lblConcatOperator"
            Me.lblConcatOperator.Size = New Global.System.Drawing.Size(58, 18)
            Me.lblConcatOperator.TabIndex = 46
            Me.lblConcatOperator.Text = "Join"
            Me.lblConcatOperator.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxColumnName1
            '
            Me.cmbxColumnName1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxColumnName1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxColumnName1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxColumnName1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxColumnName1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.cmbxColumnName1, "Choose the Column for this filter element")
            Me.cmbxColumnName1.Location = New Global.System.Drawing.Point(12, 32)
            Me.cmbxColumnName1.Name = "cmbxColumnName1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxColumnName1, True)
            Me.cmbxColumnName1.Size = New Global.System.Drawing.Size(136, 21)
            Me.cmbxColumnName1.TabIndex = 0
            Me.cmbxColumnName1.Tag = "cn1"
            '
            'cmbxMatchOperator1
            '
            Me.cmbxMatchOperator1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxMatchOperator1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxMatchOperator1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxMatchOperator1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxMatchOperator1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.cmbxMatchOperator1, "Choose the Match Operator for this filter element")
            Me.cmbxMatchOperator1.Items.AddRange(New Object() {"LIKE", "NOT LIKE", "=", "<>", "<", ">", "<=", ">=", "IN", "NOT IN"})
            Me.cmbxMatchOperator1.Location = New Global.System.Drawing.Point(158, 32)
            Me.cmbxMatchOperator1.MaxDropDownItems = 10
            Me.cmbxMatchOperator1.Name = "cmbxMatchOperator1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxMatchOperator1, True)
            Me.cmbxMatchOperator1.Size = New Global.System.Drawing.Size(82, 21)
            Me.cmbxMatchOperator1.TabIndex = 1
            Me.cmbxMatchOperator1.Tag = "mo1"
            '
            'tbCriteria1
            '
            Me.tbCriteria1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbCriteria1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCriteria1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbCriteria1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.tbCriteria1, "Enter the Criteria String for this filter element")
            Me.tbCriteria1.Location = New Global.System.Drawing.Point(250, 32)
            Me.tbCriteria1.Name = "tbCriteria1"
            Me.HelpProvider1.SetShowHelp(Me.tbCriteria1, True)
            Me.tbCriteria1.Size = New Global.System.Drawing.Size(136, 22)
            Me.tbCriteria1.TabIndex = 2
            Me.tbCriteria1.Tag = "cr1"
            Me.tbCriteria1.Text = ""
            '
            'cmbxConcatOperator1
            '
            Me.cmbxConcatOperator1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxConcatOperator1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxConcatOperator1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxConcatOperator1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxConcatOperator1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.cmbxConcatOperator1, "Choose the Boolean Concatenation Operator for this filter element. This is only required if another filter element will follow this one.")
            Me.cmbxConcatOperator1.Items.AddRange(New Object() {"", "AND", "OR"})
            Me.cmbxConcatOperator1.Location = New Global.System.Drawing.Point(398, 32)
            Me.cmbxConcatOperator1.Name = "cmbxConcatOperator1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxConcatOperator1, True)
            Me.cmbxConcatOperator1.Size = New Global.System.Drawing.Size(56, 21)
            Me.cmbxConcatOperator1.TabIndex = 3
            Me.cmbxConcatOperator1.Tag = "co1"
            '
            'btnRemove1
            '
            Me.btnRemove1.AccessibleDescription = "This is a template don't move it"
            Me.btnRemove1.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnRemove1.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnRemove1.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnRemove1.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnRemove1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove1.Font = New Global.System.Drawing.Font("Segoe UI", 7.0!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRemove1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.btnRemove1, "Click to remove this filter element")
            Me.btnRemove1.Location = New Global.System.Drawing.Point(464, 32)
            Me.btnRemove1.Name = "btnRemove1"
            Me.HelpProvider1.SetShowHelp(Me.btnRemove1, True)
            Me.btnRemove1.Size = New Global.System.Drawing.Size(21, 21)
            Me.btnRemove1.TabIndex = 105
            Me.btnRemove1.Text = "This is a template don't move it"
            Me.btnRemove1.UseVisualStyleBackColor = False
            Me.btnRemove1.Visible = False
            '
            'btnAddFilter
            '
            Me.btnAddFilter.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnAddFilter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAddFilter.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAddFilter.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAddFilter.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAddFilter.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnAddFilter.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddFilter.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.HelpProvider1.SetHelpString(Me.btnAddFilter, "Add a new filter element")
            Me.btnAddFilter.Location = New Global.System.Drawing.Point(442, 92)
            Me.btnAddFilter.Name = "btnAddFilter"
            Me.HelpProvider1.SetShowHelp(Me.btnAddFilter, True)
            Me.btnAddFilter.Size = New Global.System.Drawing.Size(100, 25)
            Me.btnAddFilter.TabIndex = 100
            Me.btnAddFilter.Text = "Add Filter"
            Me.btnAddFilter.UseVisualStyleBackColor = False
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New Global.System.Drawing.Point(16, 116)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New Global.System.Drawing.Size(526, 2)
            Me.lblSeparatorBottom.TabIndex = 47
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.btnReset)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 206)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(558, 52)
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
            Me.btnOK.Location = New Global.System.Drawing.Point(272, 13)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New Global.System.Drawing.Size(84, 25)
            Me.btnOK.TabIndex = 101
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
            '
            'btnReset
            '
            Me.btnReset.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnReset.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnReset.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnReset.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnReset.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnReset.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReset.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnReset.Location = New Global.System.Drawing.Point(364, 13)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New Global.System.Drawing.Size(84, 25)
            Me.btnReset.TabIndex = 102
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New Global.System.Drawing.Point(456, 13)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New Global.System.Drawing.Size(84, 25)
            Me.btnCancel.TabIndex = 103
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
            Me.pnlHeader.Size = New Global.System.Drawing.Size(558, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New Global.System.Drawing.Size(558, 2)
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
            Me.lblSubtitle.Location = New Global.System.Drawing.Point(18, 45)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(522, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Create column-based filters for Dialog.tlk and table-style editor views."
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
            Me.lblTitle.Location = New Global.System.Drawing.Point(16, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New Global.System.Drawing.Size(524, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Filter Editor"
            Me.lblTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmFilterDesigner
            '
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(560, 260)
            Me.Controls.Add(Me.pnlRoot)
            Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.HelpButton = True
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmFilterDesigner"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Filter Editor"

            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.btnReset.Click, AddressOf Me.btnReset_Click
            AddHandler Me.btnAddFilter.Click, AddressOf Me.btnAddFilter_Click

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