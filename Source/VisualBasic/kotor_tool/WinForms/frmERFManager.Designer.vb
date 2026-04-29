Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmERFManager
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' frmERFManager.Designer.vb
        '
        ' Restored / facelifted ERF Builder for the KoTOR Tool Restoration.
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
        Friend WithEvents ERFContentFiles As Global.System.Windows.Forms.ListBox
        Friend WithEvents btnAddFile As Global.System.Windows.Forms.Button
        Friend WithEvents btnRemoveItem As Global.System.Windows.Forms.Button
        Friend WithEvents btnMoveUp As Global.System.Windows.Forms.Button
        Friend WithEvents btnMoveDown As Global.System.Windows.Forms.Button
        Friend WithEvents btnBuild As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents tbErfName As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbxErfType As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnSelectOutputFile As Global.System.Windows.Forms.Button
        Friend WithEvents btnAddDirectory As Global.System.Windows.Forms.Button

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlOutput As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlActions As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label
        Friend WithEvents lblContentFiles As Global.System.Windows.Forms.Label

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
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmERFManager))
            Me.pnlRoot = New Global.System.Windows.Forms.Panel()
            Me.pnlBody = New Global.System.Windows.Forms.Panel()
            Me.ERFContentFiles = New Global.System.Windows.Forms.ListBox()
            Me.lblContentFiles = New Global.System.Windows.Forms.Label()
            Me.pnlActions = New Global.System.Windows.Forms.Panel()
            Me.btnAddFile = New Global.System.Windows.Forms.Button()
            Me.btnAddDirectory = New Global.System.Windows.Forms.Button()
            Me.btnRemoveItem = New Global.System.Windows.Forms.Button()
            Me.btnMoveUp = New Global.System.Windows.Forms.Button()
            Me.btnMoveDown = New Global.System.Windows.Forms.Button()
            Me.btnBuild = New Global.System.Windows.Forms.Button()
            Me.lblSeparatorBottom = New Global.System.Windows.Forms.Label()
            Me.pnlFooter = New Global.System.Windows.Forms.Panel()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.pnlOutput = New Global.System.Windows.Forms.Panel()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.tbErfName = New Global.System.Windows.Forms.TextBox()
            Me.btnSelectOutputFile = New Global.System.Windows.Forms.Button()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.cmbxErfType = New Global.System.Windows.Forms.ComboBox()
            Me.pnlHeader = New Global.System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New Global.System.Windows.Forms.Label()
            Me.lblSubtitle = New Global.System.Windows.Forms.Label()
            Me.lblTitle = New Global.System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlActions.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlOutput.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlOutput)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New Global.System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New Global.System.Drawing.Size(520, 520)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.ERFContentFiles)
            Me.pnlBody.Controls.Add(Me.lblContentFiles)
            Me.pnlBody.Controls.Add(Me.pnlActions)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New Global.System.Drawing.Point(0, 160)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New Global.System.Windows.Forms.Padding(16, 14, 16, 12)
            Me.pnlBody.Size = New Global.System.Drawing.Size(518, 304)
            Me.pnlBody.TabIndex = 2
            '
            'ERFContentFiles
            '
            Me.ERFContentFiles.AllowDrop = True
            Me.ERFContentFiles.Anchor = CType((((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom) _
                Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.ERFContentFiles.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.ERFContentFiles.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.ERFContentFiles.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ERFContentFiles.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ERFContentFiles.HorizontalScrollbar = True
            Me.ERFContentFiles.IntegralHeight = False
            Me.ERFContentFiles.Location = New Global.System.Drawing.Point(16, 42)
            Me.ERFContentFiles.Name = "ERFContentFiles"
            Me.ERFContentFiles.SelectionMode = Global.System.Windows.Forms.SelectionMode.MultiExtended
            Me.ERFContentFiles.Size = New Global.System.Drawing.Size(348, 238)
            Me.ERFContentFiles.TabIndex = 0
            '
            'lblContentFiles
            '
            Me.lblContentFiles.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.lblContentFiles.AutoEllipsis = True
            Me.lblContentFiles.BackColor = Global.System.Drawing.Color.Transparent
            Me.lblContentFiles.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblContentFiles.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblContentFiles.Location = New Global.System.Drawing.Point(16, 18)
            Me.lblContentFiles.Name = "lblContentFiles"
            Me.lblContentFiles.Size = New Global.System.Drawing.Size(348, 18)
            Me.lblContentFiles.TabIndex = 1
            Me.lblContentFiles.Text = "ERF Content Files"
            Me.lblContentFiles.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlActions
            '
            Me.pnlActions.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.pnlActions.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlActions.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlActions.Controls.Add(Me.btnAddFile)
            Me.pnlActions.Controls.Add(Me.btnAddDirectory)
            Me.pnlActions.Controls.Add(Me.btnRemoveItem)
            Me.pnlActions.Controls.Add(Me.btnMoveUp)
            Me.pnlActions.Controls.Add(Me.btnMoveDown)
            Me.pnlActions.Controls.Add(Me.btnBuild)
            Me.pnlActions.Location = New Global.System.Drawing.Point(378, 42)
            Me.pnlActions.Name = "pnlActions"
            Me.pnlActions.Size = New Global.System.Drawing.Size(124, 238)
            Me.pnlActions.TabIndex = 2
            '
            'btnAddFile
            '
            Me.btnAddFile.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAddFile.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAddFile.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAddFile.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAddFile.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnAddFile.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddFile.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnAddFile.Location = New Global.System.Drawing.Point(12, 12)
            Me.btnAddFile.Name = "btnAddFile"
            Me.btnAddFile.Size = New Global.System.Drawing.Size(98, 25)
            Me.btnAddFile.TabIndex = 0
            Me.btnAddFile.Text = "Add Files..."
            Me.btnAddFile.UseVisualStyleBackColor = False
            '
            'btnAddDirectory
            '
            Me.btnAddDirectory.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnAddDirectory.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnAddDirectory.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnAddDirectory.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnAddDirectory.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnAddDirectory.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddDirectory.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnAddDirectory.Location = New Global.System.Drawing.Point(12, 44)
            Me.btnAddDirectory.Name = "btnAddDirectory"
            Me.btnAddDirectory.Size = New Global.System.Drawing.Size(98, 25)
            Me.btnAddDirectory.TabIndex = 1
            Me.btnAddDirectory.Text = "Add Dir..."
            Me.btnAddDirectory.UseVisualStyleBackColor = False
            '
            'btnRemoveItem
            '
            Me.btnRemoveItem.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnRemoveItem.Enabled = False
            Me.btnRemoveItem.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnRemoveItem.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnRemoveItem.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnRemoveItem.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnRemoveItem.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRemoveItem.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnRemoveItem.Location = New Global.System.Drawing.Point(12, 86)
            Me.btnRemoveItem.Name = "btnRemoveItem"
            Me.btnRemoveItem.Size = New Global.System.Drawing.Size(98, 25)
            Me.btnRemoveItem.TabIndex = 2
            Me.btnRemoveItem.Text = "Remove"
            Me.btnRemoveItem.UseVisualStyleBackColor = False
            '
            'btnMoveUp
            '
            Me.btnMoveUp.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnMoveUp.Enabled = False
            Me.btnMoveUp.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnMoveUp.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnMoveUp.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnMoveUp.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnMoveUp.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMoveUp.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnMoveUp.Location = New Global.System.Drawing.Point(12, 128)
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.Size = New Global.System.Drawing.Size(98, 25)
            Me.btnMoveUp.TabIndex = 3
            Me.btnMoveUp.Text = "Move Up"
            Me.btnMoveUp.UseVisualStyleBackColor = False
            '
            'btnMoveDown
            '
            Me.btnMoveDown.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnMoveDown.Enabled = False
            Me.btnMoveDown.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnMoveDown.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnMoveDown.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnMoveDown.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnMoveDown.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMoveDown.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnMoveDown.Location = New Global.System.Drawing.Point(12, 160)
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.Size = New Global.System.Drawing.Size(98, 25)
            Me.btnMoveDown.TabIndex = 4
            Me.btnMoveDown.Text = "Move Down"
            Me.btnMoveDown.UseVisualStyleBackColor = False
            '
            'btnBuild
            '
            Me.btnBuild.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnBuild.Enabled = False
            Me.btnBuild.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnBuild.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnBuild.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnBuild.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnBuild.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuild.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnBuild.Location = New Global.System.Drawing.Point(12, 202)
            Me.btnBuild.Name = "btnBuild"
            Me.btnBuild.Size = New Global.System.Drawing.Size(98, 25)
            Me.btnBuild.TabIndex = 5
            Me.btnBuild.Text = "Build ..."
            Me.btnBuild.UseVisualStyleBackColor = False
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New Global.System.Drawing.Point(16, 290)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New Global.System.Drawing.Size(486, 2)
            Me.lblSeparatorBottom.TabIndex = 3
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New Global.System.Drawing.Point(0, 464)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New Global.System.Drawing.Size(518, 54)
            Me.pnlFooter.TabIndex = 3
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
            Me.btnCancel.Location = New Global.System.Drawing.Point(416, 15)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New Global.System.Drawing.Size(84, 25)
            Me.btnCancel.TabIndex = 0
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'pnlOutput
            '
            Me.pnlOutput.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlOutput.Controls.Add(Me.Label1)
            Me.pnlOutput.Controls.Add(Me.tbErfName)
            Me.pnlOutput.Controls.Add(Me.btnSelectOutputFile)
            Me.pnlOutput.Controls.Add(Me.Label2)
            Me.pnlOutput.Controls.Add(Me.cmbxErfType)
            Me.pnlOutput.Dock = Global.System.Windows.Forms.DockStyle.Top
            Me.pnlOutput.Location = New Global.System.Drawing.Point(0, 76)
            Me.pnlOutput.Name = "pnlOutput"
            Me.pnlOutput.Padding = New Global.System.Windows.Forms.Padding(16, 12, 16, 12)
            Me.pnlOutput.Size = New Global.System.Drawing.Size(518, 84)
            Me.pnlOutput.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label1.Location = New Global.System.Drawing.Point(16, 12)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(144, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Output file name"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbErfName
            '
            Me.tbErfName.Anchor = CType(((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left) _
                Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.tbErfName.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbErfName.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbErfName.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbErfName.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbErfName.Location = New Global.System.Drawing.Point(16, 38)
            Me.tbErfName.Name = "tbErfName"
            Me.tbErfName.Size = New Global.System.Drawing.Size(310, 22)
            Me.tbErfName.TabIndex = 1
            Me.tbErfName.Text = ""
            '
            'btnSelectOutputFile
            '
            Me.btnSelectOutputFile.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.btnSelectOutputFile.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSelectOutputFile.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSelectOutputFile.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSelectOutputFile.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSelectOutputFile.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnSelectOutputFile.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSelectOutputFile.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSelectOutputFile.Location = New Global.System.Drawing.Point(334, 37)
            Me.btnSelectOutputFile.Name = "btnSelectOutputFile"
            Me.btnSelectOutputFile.Size = New Global.System.Drawing.Size(34, 24)
            Me.btnSelectOutputFile.TabIndex = 2
            Me.btnSelectOutputFile.Text = "..."
            Me.btnSelectOutputFile.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
            Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label2.Location = New Global.System.Drawing.Point(384, 12)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(116, 18)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Output file type"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxErfType
            '
            Me.cmbxErfType.Anchor = CType((Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right), Global.System.Windows.Forms.AnchorStyles)
            Me.cmbxErfType.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.cmbxErfType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxErfType.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.cmbxErfType.Font = New Global.System.Drawing.Font("Segoe UI", 8.25!, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbxErfType.ForeColor = Global.System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxErfType.Items.AddRange(New Object() {"MOD", "ERF", "HAK", "SAV"})
            Me.cmbxErfType.Location = New Global.System.Drawing.Point(384, 38)
            Me.cmbxErfType.Name = "cmbxErfType"
            Me.cmbxErfType.Size = New Global.System.Drawing.Size(116, 21)
            Me.cmbxErfType.TabIndex = 4
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
            Me.pnlHeader.Size = New Global.System.Drawing.Size(518, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = Global.System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New Global.System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New Global.System.Drawing.Size(518, 2)
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
            Me.lblSubtitle.Size = New Global.System.Drawing.Size(482, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Build MOD, ERF, HAK, and SAV archives from selected content files."
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
            Me.lblTitle.Size = New Global.System.Drawing.Size(484, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "ERF Builder"
            Me.lblTitle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmERFManager
            '
            Me.AllowDrop = True
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.BackColor = Global.System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(520, 520)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(528, 552)
            Me.Name = "frmERFManager"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "ERF Builder"

            AddHandler Me.ERFContentFiles.KeyUp, AddressOf Me.ERFContentFiles_KeyUp
            AddHandler Me.ERFContentFiles.SelectedIndexChanged, AddressOf Me.ERFContentFiles_SelectedIndexChanged
            AddHandler Me.ERFContentFiles.DragDrop, AddressOf Me.ERFContentFiles_DragDrop
            AddHandler Me.ERFContentFiles.DragEnter, AddressOf Me.ERFContentFiles_DragEnter
            AddHandler Me.btnAddFile.Click, AddressOf Me.btnAddFile_Click
            AddHandler Me.btnRemoveItem.Click, AddressOf Me.btnRemoveItem_Click
            AddHandler Me.btnMoveUp.Click, AddressOf Me.btnMoveUp_Click
            AddHandler Me.btnMoveDown.Click, AddressOf Me.btnMoveDown_Click
            AddHandler Me.btnBuild.Click, AddressOf Me.btnBuild_Click
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.tbErfName.TextChanged, AddressOf Me.tbErfName_TextChanged
            AddHandler Me.tbErfName.ModifiedChanged, AddressOf Me.tbErfName_ModifiedChanged
            AddHandler Me.cmbxErfType.SelectedIndexChanged, AddressOf Me.cmbxErfType_SelectedIndexChanged
            AddHandler Me.btnSelectOutputFile.Click, AddressOf Me.btnSelectOutputFile_Click
            AddHandler Me.btnAddDirectory.Click, AddressOf Me.btnAddDirectory_Click

            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlActions.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlOutput.ResumeLayout(False)
            Me.pnlOutput.PerformLayout()
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace