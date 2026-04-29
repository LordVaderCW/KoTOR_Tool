Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmItemPropertyEditor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' frmItemPropertyEditor.Designer.vb
        '
        ' Restored / facelifted Item Property Editor for the KoTOR Tool
        ' Restoration Project.
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
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxPropertyName As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxSubtype As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxParam1Value As Global.System.Windows.Forms.ComboBox
        Friend WithEvents nudPercentChance As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents lblParam1 As Global.System.Windows.Forms.Label
        Friend WithEvents lblCostTable As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxCostValue As Global.System.Windows.Forms.ComboBox
        Friend WithEvents lblParam2 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxParam2Value As Global.System.Windows.Forms.ComboBox
        Friend WithEvents tbStatus As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbSubtyperesref As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCostTableID As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCostTableName As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbParam1resref As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbParam2resref As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents Label8 As Global.System.Windows.Forms.Label
        Friend WithEvents tbParam1tableresref As Global.System.Windows.Forms.TextBox
        Friend WithEvents label99 As Global.System.Windows.Forms.Label
        Friend WithEvents tbParam2tableresref As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label10 As Global.System.Windows.Forms.Label
        Friend WithEvents lblParam2Desc As Global.System.Windows.Forms.Label
        Friend WithEvents lblParam1Desc As Global.System.Windows.Forms.Label
        Friend WithEvents lblValueDesc As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtypeDesc As Global.System.Windows.Forms.Label
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxUpgrade As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlMainEditor As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlDebugInfo As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label
        Friend WithEvents lblDebugTitle As Global.System.Windows.Forms.Label

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemPropertyEditor))
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.pnlMainEditor = New System.Windows.Forms.Panel()
            Me.cmbxPropertyName = New System.Windows.Forms.ComboBox()
            Me.cmbxSubtype = New System.Windows.Forms.ComboBox()
            Me.cmbxParam1Value = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblParam1 = New System.Windows.Forms.Label()
            Me.nudPercentChance = New System.Windows.Forms.NumericUpDown()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblCostTable = New System.Windows.Forms.Label()
            Me.cmbxCostValue = New System.Windows.Forms.ComboBox()
            Me.lblParam2 = New System.Windows.Forms.Label()
            Me.cmbxParam2Value = New System.Windows.Forms.ComboBox()
            Me.lblParam2Desc = New System.Windows.Forms.Label()
            Me.lblParam1Desc = New System.Windows.Forms.Label()
            Me.lblValueDesc = New System.Windows.Forms.Label()
            Me.lblSubtypeDesc = New System.Windows.Forms.Label()
            Me.cmbxUpgrade = New System.Windows.Forms.ComboBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.pnlDebugInfo = New System.Windows.Forms.Panel()
            Me.lblDebugTitle = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.tbSubtyperesref = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.tbCostTableID = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.tbCostTableName = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.tbParam1resref = New System.Windows.Forms.TextBox()
            Me.label99 = New System.Windows.Forms.Label()
            Me.tbParam1tableresref = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.tbParam2resref = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.tbParam2tableresref = New System.Windows.Forms.TextBox()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.tbStatus = New System.Windows.Forms.TextBox()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlMainEditor.SuspendLayout()
            CType(Me.nudPercentChance, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlDebugInfo.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
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
            Me.pnlRoot.Size = New System.Drawing.Size(864, 420)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.pnlMainEditor)
            Me.pnlBody.Controls.Add(Me.pnlDebugInfo)
            Me.pnlBody.Controls.Add(Me.tbStatus)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(14, 14, 14, 12)
            Me.pnlBody.Size = New System.Drawing.Size(862, 290)
            Me.pnlBody.TabIndex = 1
            '
            'pnlMainEditor
            '
            Me.pnlMainEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pnlMainEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlMainEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlMainEditor.Controls.Add(Me.cmbxPropertyName)
            Me.pnlMainEditor.Controls.Add(Me.cmbxSubtype)
            Me.pnlMainEditor.Controls.Add(Me.cmbxParam1Value)
            Me.pnlMainEditor.Controls.Add(Me.Label1)
            Me.pnlMainEditor.Controls.Add(Me.Label2)
            Me.pnlMainEditor.Controls.Add(Me.lblParam1)
            Me.pnlMainEditor.Controls.Add(Me.nudPercentChance)
            Me.pnlMainEditor.Controls.Add(Me.Label5)
            Me.pnlMainEditor.Controls.Add(Me.lblCostTable)
            Me.pnlMainEditor.Controls.Add(Me.cmbxCostValue)
            Me.pnlMainEditor.Controls.Add(Me.lblParam2)
            Me.pnlMainEditor.Controls.Add(Me.cmbxParam2Value)
            Me.pnlMainEditor.Controls.Add(Me.lblParam2Desc)
            Me.pnlMainEditor.Controls.Add(Me.lblParam1Desc)
            Me.pnlMainEditor.Controls.Add(Me.lblValueDesc)
            Me.pnlMainEditor.Controls.Add(Me.lblSubtypeDesc)
            Me.pnlMainEditor.Controls.Add(Me.cmbxUpgrade)
            Me.pnlMainEditor.Controls.Add(Me.Label9)
            Me.pnlMainEditor.Location = New System.Drawing.Point(14, 14)
            Me.pnlMainEditor.Name = "pnlMainEditor"
            Me.pnlMainEditor.Size = New System.Drawing.Size(500, 218)
            Me.pnlMainEditor.TabIndex = 0
            '
            'cmbxPropertyName
            '
            Me.cmbxPropertyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxPropertyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxPropertyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxPropertyName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxPropertyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxPropertyName.Location = New System.Drawing.Point(16, 36)
            Me.cmbxPropertyName.MaxDropDownItems = 15
            Me.cmbxPropertyName.Name = "cmbxPropertyName"
            Me.cmbxPropertyName.Size = New System.Drawing.Size(224, 21)
            Me.cmbxPropertyName.TabIndex = 0
            '
            'cmbxSubtype
            '
            Me.cmbxSubtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxSubtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxSubtype.Enabled = False
            Me.cmbxSubtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxSubtype.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxSubtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxSubtype.Location = New System.Drawing.Point(16, 84)
            Me.cmbxSubtype.MaxDropDownItems = 12
            Me.cmbxSubtype.Name = "cmbxSubtype"
            Me.cmbxSubtype.Size = New System.Drawing.Size(224, 21)
            Me.cmbxSubtype.TabIndex = 1
            '
            'cmbxParam1Value
            '
            Me.cmbxParam1Value.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxParam1Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxParam1Value.Enabled = False
            Me.cmbxParam1Value.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxParam1Value.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxParam1Value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxParam1Value.Location = New System.Drawing.Point(260, 36)
            Me.cmbxParam1Value.MaxDropDownItems = 15
            Me.cmbxParam1Value.Name = "cmbxParam1Value"
            Me.cmbxParam1Value.Size = New System.Drawing.Size(218, 21)
            Me.cmbxParam1Value.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(16, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(120, 16)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Property Name"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(16, 66)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(64, 16)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Subtype"
            '
            'lblParam1
            '
            Me.lblParam1.BackColor = System.Drawing.Color.Transparent
            Me.lblParam1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParam1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblParam1.Location = New System.Drawing.Point(260, 18)
            Me.lblParam1.Name = "lblParam1"
            Me.lblParam1.Size = New System.Drawing.Size(64, 16)
            Me.lblParam1.TabIndex = 10
            Me.lblParam1.Text = "Param 1"
            '
            'nudPercentChance
            '
            Me.nudPercentChance.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.nudPercentChance.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudPercentChance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudPercentChance.Location = New System.Drawing.Point(260, 166)
            Me.nudPercentChance.Name = "nudPercentChance"
            Me.nudPercentChance.Size = New System.Drawing.Size(218, 20)
            Me.nudPercentChance.TabIndex = 5
            Me.nudPercentChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudPercentChance.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(16, 167)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(224, 19)
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "Chance of Appearance (%)"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblCostTable
            '
            Me.lblCostTable.BackColor = System.Drawing.Color.Transparent
            Me.lblCostTable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCostTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblCostTable.Location = New System.Drawing.Point(16, 114)
            Me.lblCostTable.Name = "lblCostTable"
            Me.lblCostTable.Size = New System.Drawing.Size(56, 16)
            Me.lblCostTable.TabIndex = 12
            Me.lblCostTable.Text = "Value"
            '
            'cmbxCostValue
            '
            Me.cmbxCostValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxCostValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxCostValue.Enabled = False
            Me.cmbxCostValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxCostValue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxCostValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxCostValue.Location = New System.Drawing.Point(16, 132)
            Me.cmbxCostValue.Name = "cmbxCostValue"
            Me.cmbxCostValue.Size = New System.Drawing.Size(224, 21)
            Me.cmbxCostValue.TabIndex = 2
            '
            'lblParam2
            '
            Me.lblParam2.BackColor = System.Drawing.Color.Transparent
            Me.lblParam2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParam2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblParam2.Location = New System.Drawing.Point(260, 66)
            Me.lblParam2.Name = "lblParam2"
            Me.lblParam2.Size = New System.Drawing.Size(64, 16)
            Me.lblParam2.TabIndex = 13
            Me.lblParam2.Text = "Param 2"
            '
            'cmbxParam2Value
            '
            Me.cmbxParam2Value.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxParam2Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxParam2Value.Enabled = False
            Me.cmbxParam2Value.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxParam2Value.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxParam2Value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxParam2Value.Location = New System.Drawing.Point(260, 84)
            Me.cmbxParam2Value.MaxDropDownItems = 12
            Me.cmbxParam2Value.Name = "cmbxParam2Value"
            Me.cmbxParam2Value.Size = New System.Drawing.Size(218, 21)
            Me.cmbxParam2Value.TabIndex = 4
            '
            'lblParam2Desc
            '
            Me.lblParam2Desc.BackColor = System.Drawing.Color.Transparent
            Me.lblParam2Desc.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParam2Desc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblParam2Desc.Location = New System.Drawing.Point(324, 66)
            Me.lblParam2Desc.Name = "lblParam2Desc"
            Me.lblParam2Desc.Size = New System.Drawing.Size(152, 16)
            Me.lblParam2Desc.TabIndex = 14
            '
            'lblParam1Desc
            '
            Me.lblParam1Desc.BackColor = System.Drawing.Color.Transparent
            Me.lblParam1Desc.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParam1Desc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblParam1Desc.Location = New System.Drawing.Point(324, 18)
            Me.lblParam1Desc.Name = "lblParam1Desc"
            Me.lblParam1Desc.Size = New System.Drawing.Size(152, 16)
            Me.lblParam1Desc.TabIndex = 15
            '
            'lblValueDesc
            '
            Me.lblValueDesc.BackColor = System.Drawing.Color.Transparent
            Me.lblValueDesc.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValueDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblValueDesc.Location = New System.Drawing.Point(78, 114)
            Me.lblValueDesc.Name = "lblValueDesc"
            Me.lblValueDesc.Size = New System.Drawing.Size(160, 16)
            Me.lblValueDesc.TabIndex = 16
            '
            'lblSubtypeDesc
            '
            Me.lblSubtypeDesc.BackColor = System.Drawing.Color.Transparent
            Me.lblSubtypeDesc.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtypeDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblSubtypeDesc.Location = New System.Drawing.Point(78, 66)
            Me.lblSubtypeDesc.Name = "lblSubtypeDesc"
            Me.lblSubtypeDesc.Size = New System.Drawing.Size(160, 16)
            Me.lblSubtypeDesc.TabIndex = 17
            '
            'cmbxUpgrade
            '
            Me.cmbxUpgrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxUpgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxUpgrade.Enabled = False
            Me.cmbxUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbxUpgrade.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxUpgrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxUpgrade.Location = New System.Drawing.Point(260, 132)
            Me.cmbxUpgrade.Name = "cmbxUpgrade"
            Me.cmbxUpgrade.Size = New System.Drawing.Size(218, 21)
            Me.cmbxUpgrade.TabIndex = 4
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(260, 114)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(180, 16)
            Me.Label9.TabIndex = 18
            Me.Label9.Text = "Upgrade required to activate"
            '
            'pnlDebugInfo
            '
            Me.pnlDebugInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlDebugInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlDebugInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlDebugInfo.Controls.Add(Me.lblDebugTitle)
            Me.pnlDebugInfo.Controls.Add(Me.Label3)
            Me.pnlDebugInfo.Controls.Add(Me.tbSubtyperesref)
            Me.pnlDebugInfo.Controls.Add(Me.Label4)
            Me.pnlDebugInfo.Controls.Add(Me.tbCostTableID)
            Me.pnlDebugInfo.Controls.Add(Me.Label6)
            Me.pnlDebugInfo.Controls.Add(Me.tbCostTableName)
            Me.pnlDebugInfo.Controls.Add(Me.Label7)
            Me.pnlDebugInfo.Controls.Add(Me.tbParam1resref)
            Me.pnlDebugInfo.Controls.Add(Me.label99)
            Me.pnlDebugInfo.Controls.Add(Me.tbParam1tableresref)
            Me.pnlDebugInfo.Controls.Add(Me.Label8)
            Me.pnlDebugInfo.Controls.Add(Me.tbParam2resref)
            Me.pnlDebugInfo.Controls.Add(Me.Label10)
            Me.pnlDebugInfo.Controls.Add(Me.tbParam2tableresref)
            Me.pnlDebugInfo.Controls.Add(Me.btnDebug)
            Me.pnlDebugInfo.Location = New System.Drawing.Point(520, 14)
            Me.pnlDebugInfo.Name = "pnlDebugInfo"
            Me.pnlDebugInfo.Size = New System.Drawing.Size(328, 218)
            Me.pnlDebugInfo.TabIndex = 1
            '
            'lblDebugTitle
            '
            Me.lblDebugTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblDebugTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDebugTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblDebugTitle.Location = New System.Drawing.Point(12, 8)
            Me.lblDebugTitle.Name = "lblDebugTitle"
            Me.lblDebugTitle.Size = New System.Drawing.Size(302, 22)
            Me.lblDebugTitle.TabIndex = 0
            Me.lblDebugTitle.Text = "Resolved Table Data"
            Me.lblDebugTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(12, 30)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(120, 14)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Subtyperesref"
            '
            'tbSubtyperesref
            '
            Me.tbSubtyperesref.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbSubtyperesref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbSubtyperesref.Font = New System.Drawing.Font("Consolas", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbSubtyperesref.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbSubtyperesref.Location = New System.Drawing.Point(12, 46)
            Me.tbSubtyperesref.Name = "tbSubtyperesref"
            Me.tbSubtyperesref.Size = New System.Drawing.Size(302, 20)
            Me.tbSubtyperesref.TabIndex = 5
            Me.tbSubtyperesref.TabStop = False
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(12, 70)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(120, 14)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "CostTableID"
            '
            'tbCostTableID
            '
            Me.tbCostTableID.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbCostTableID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCostTableID.Font = New System.Drawing.Font("Consolas", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbCostTableID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCostTableID.Location = New System.Drawing.Point(12, 86)
            Me.tbCostTableID.Name = "tbCostTableID"
            Me.tbCostTableID.Size = New System.Drawing.Size(130, 20)
            Me.tbCostTableID.TabIndex = 5
            Me.tbCostTableID.TabStop = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(184, 71)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(80, 14)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "CostTableName"
            '
            'tbCostTableName
            '
            Me.tbCostTableName.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbCostTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCostTableName.Font = New System.Drawing.Font("Consolas", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbCostTableName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCostTableName.Location = New System.Drawing.Point(184, 87)
            Me.tbCostTableName.Name = "tbCostTableName"
            Me.tbCostTableName.Size = New System.Drawing.Size(130, 20)
            Me.tbCostTableName.TabIndex = 5
            Me.tbCostTableName.TabStop = False
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(12, 110)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(80, 14)
            Me.Label7.TabIndex = 4
            Me.Label7.Text = "Param1resref"
            '
            'tbParam1resref
            '
            Me.tbParam1resref.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbParam1resref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbParam1resref.Font = New System.Drawing.Font("Consolas", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbParam1resref.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbParam1resref.Location = New System.Drawing.Point(12, 126)
            Me.tbParam1resref.Name = "tbParam1resref"
            Me.tbParam1resref.Size = New System.Drawing.Size(130, 20)
            Me.tbParam1resref.TabIndex = 5
            Me.tbParam1resref.TabStop = False
            '
            'label99
            '
            Me.label99.BackColor = System.Drawing.Color.Transparent
            Me.label99.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label99.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.label99.Location = New System.Drawing.Point(184, 111)
            Me.label99.Name = "label99"
            Me.label99.Size = New System.Drawing.Size(80, 14)
            Me.label99.TabIndex = 5
            Me.label99.Text = "Param1table"
            '
            'tbParam1tableresref
            '
            Me.tbParam1tableresref.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbParam1tableresref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbParam1tableresref.Font = New System.Drawing.Font("Consolas", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbParam1tableresref.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbParam1tableresref.Location = New System.Drawing.Point(184, 127)
            Me.tbParam1tableresref.Name = "tbParam1tableresref"
            Me.tbParam1tableresref.Size = New System.Drawing.Size(130, 20)
            Me.tbParam1tableresref.TabIndex = 5
            Me.tbParam1tableresref.TabStop = False
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(12, 150)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(80, 14)
            Me.Label8.TabIndex = 6
            Me.Label8.Text = "Param2resref"
            '
            'tbParam2resref
            '
            Me.tbParam2resref.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbParam2resref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbParam2resref.Font = New System.Drawing.Font("Consolas", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbParam2resref.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbParam2resref.Location = New System.Drawing.Point(12, 166)
            Me.tbParam2resref.Name = "tbParam2resref"
            Me.tbParam2resref.Size = New System.Drawing.Size(130, 20)
            Me.tbParam2resref.TabIndex = 5
            Me.tbParam2resref.TabStop = False
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(184, 151)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(80, 14)
            Me.Label10.TabIndex = 7
            Me.Label10.Text = "Param2table"
            '
            'tbParam2tableresref
            '
            Me.tbParam2tableresref.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbParam2tableresref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbParam2tableresref.Font = New System.Drawing.Font("Consolas", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbParam2tableresref.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbParam2tableresref.Location = New System.Drawing.Point(184, 167)
            Me.tbParam2tableresref.Name = "tbParam2tableresref"
            Me.tbParam2tableresref.Size = New System.Drawing.Size(130, 20)
            Me.tbParam2tableresref.TabIndex = 5
            Me.tbParam2tableresref.TabStop = False
            '
            'btnDebug
            '
            Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.btnDebug.Location = New System.Drawing.Point(0, 0)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(8, 8)
            Me.btnDebug.TabIndex = 8
            Me.btnDebug.TabStop = False
            Me.btnDebug.UseVisualStyleBackColor = False
            '
            'tbStatus
            '
            Me.tbStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbStatus.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbStatus.Location = New System.Drawing.Point(14, 244)
            Me.tbStatus.Name = "tbStatus"
            Me.tbStatus.Size = New System.Drawing.Size(834, 20)
            Me.tbStatus.TabIndex = 4
            Me.tbStatus.TabStop = False
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(14, 276)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(834, 2)
            Me.lblSeparatorBottom.TabIndex = 5
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnOK)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 366)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(862, 52)
            Me.pnlFooter.TabIndex = 2
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
            Me.btnOK.Location = New System.Drawing.Point(666, 13)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(84, 25)
            Me.btnOK.TabIndex = 6
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New System.Drawing.Point(760, 13)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(84, 25)
            Me.btnCancel.TabIndex = 7
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
            Me.pnlHeader.Size = New System.Drawing.Size(862, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(862, 2)
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
            Me.lblSubtitle.Size = New System.Drawing.Size(826, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Configure item property subtype, values, parameters, upgrade requirement, and app" & _
                "earance chance."
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
            Me.lblTitle.Size = New System.Drawing.Size(828, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Item Property Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmItemPropertyEditor
            '
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(864, 420)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(520, 296)
            Me.Name = "frmItemPropertyEditor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Item Property Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlBody.PerformLayout()
            Me.pnlMainEditor.ResumeLayout(False)
            CType(Me.nudPercentChance, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlDebugInfo.ResumeLayout(False)
            Me.pnlDebugInfo.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace