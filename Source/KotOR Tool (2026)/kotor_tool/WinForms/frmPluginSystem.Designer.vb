Option Strict Off
Option Explicit On

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPluginSystem
    Inherits System.Windows.Forms.Form

    ' -----------------------------------------------------------------
    ' frmPluginSystem.Designer.vb
    '
    ' Plugin System manager UI for the KoTOR Tool Restoration Project.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Designer-only file.
    '   - Backend logic belongs in frmPluginSystem.vb.
    '   - Matches the default Visual Studio WinForms scaffold.
    ' -----------------------------------------------------------------

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlRoot As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlList As System.Windows.Forms.Panel
    Friend WithEvents pnlInstalledList As System.Windows.Forms.Panel
    Friend WithEvents pnlAvailableList As System.Windows.Forms.Panel
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents pnlActions As System.Windows.Forms.Panel

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderRule As System.Windows.Forms.Label
    Friend WithEvents lblFooterRule As System.Windows.Forms.Label
    Friend WithEvents lblPlugins As System.Windows.Forms.Label
    Friend WithEvents lblAvailablePlugins As System.Windows.Forms.Label
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblCommand As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label

    Friend WithEvents lbPlugins As System.Windows.Forms.ListBox
    Friend WithEvents lbAvailablePlugins As System.Windows.Forms.ListBox
    Friend WithEvents tbDetails As System.Windows.Forms.TextBox
    Friend WithEvents tbCommand As System.Windows.Forms.TextBox

    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnOpenPluginsFolder As System.Windows.Forms.Button
    Friend WithEvents btnOpenPluginFolder As System.Windows.Forms.Button
    Friend WithEvents btnEditPluginXml As System.Windows.Forms.Button
    Friend WithEvents btnEditCommandIni As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlRoot = New System.Windows.Forms.Panel()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.tbCommand = New System.Windows.Forms.TextBox()
        Me.lblCommand = New System.Windows.Forms.Label()
        Me.tbDetails = New System.Windows.Forms.TextBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.btnEditCommandIni = New System.Windows.Forms.Button()
        Me.btnEditPluginXml = New System.Windows.Forms.Button()
        Me.btnOpenPluginFolder = New System.Windows.Forms.Button()
        Me.btnOpenPluginsFolder = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.pnlAvailableList = New System.Windows.Forms.Panel()
        Me.lbAvailablePlugins = New System.Windows.Forms.ListBox()
        Me.lblAvailablePlugins = New System.Windows.Forms.Label()
        Me.pnlInstalledList = New System.Windows.Forms.Panel()
        Me.lbPlugins = New System.Windows.Forms.ListBox()
        Me.lblPlugins = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFooterRule = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderRule = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDownloadPlugin = New System.Windows.Forms.Button()
        Me.pnlRoot.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.pnlList.SuspendLayout()
        Me.pnlAvailableList.SuspendLayout()
        Me.pnlInstalledList.SuspendLayout()
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
        Me.pnlRoot.Size = New System.Drawing.Size(820, 560)
        Me.pnlRoot.TabIndex = 0
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlBody.Controls.Add(Me.pnlDetails)
        Me.pnlBody.Controls.Add(Me.pnlActions)
        Me.pnlBody.Controls.Add(Me.pnlList)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 88)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Padding = New System.Windows.Forms.Padding(14)
        Me.pnlBody.Size = New System.Drawing.Size(818, 414)
        Me.pnlBody.TabIndex = 1
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetails.Controls.Add(Me.tbCommand)
        Me.pnlDetails.Controls.Add(Me.lblCommand)
        Me.pnlDetails.Controls.Add(Me.tbDetails)
        Me.pnlDetails.Controls.Add(Me.lblDetails)
        Me.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetails.Location = New System.Drawing.Point(279, 14)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.pnlDetails.Size = New System.Drawing.Size(391, 386)
        Me.pnlDetails.TabIndex = 1
        '
        'tbCommand
        '
        Me.tbCommand.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.tbCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCommand.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCommand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tbCommand.Location = New System.Drawing.Point(12, 208)
        Me.tbCommand.Multiline = True
        Me.tbCommand.Name = "tbCommand"
        Me.tbCommand.ReadOnly = True
        Me.tbCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCommand.Size = New System.Drawing.Size(365, 176)
        Me.tbCommand.TabIndex = 3
        '
        'lblCommand
        '
        Me.lblCommand.BackColor = System.Drawing.Color.Transparent
        Me.lblCommand.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCommand.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblCommand.Location = New System.Drawing.Point(12, 182)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(365, 26)
        Me.lblCommand.TabIndex = 2
        Me.lblCommand.Text = "Command Preview"
        Me.lblCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbDetails
        '
        Me.tbDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.tbDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbDetails.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.tbDetails.Location = New System.Drawing.Point(12, 24)
        Me.tbDetails.Multiline = True
        Me.tbDetails.Name = "tbDetails"
        Me.tbDetails.ReadOnly = True
        Me.tbDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDetails.Size = New System.Drawing.Size(365, 158)
        Me.tbDetails.TabIndex = 1
        '
        'lblDetails
        '
        Me.lblDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblDetails.Location = New System.Drawing.Point(12, 0)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(365, 24)
        Me.lblDetails.TabIndex = 0
        Me.lblDetails.Text = "Plugin Details"
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActions.Controls.Add(Me.btnDownloadPlugin)
        Me.pnlActions.Controls.Add(Me.btnEditCommandIni)
        Me.pnlActions.Controls.Add(Me.btnEditPluginXml)
        Me.pnlActions.Controls.Add(Me.btnOpenPluginFolder)
        Me.pnlActions.Controls.Add(Me.btnOpenPluginsFolder)
        Me.pnlActions.Controls.Add(Me.btnReload)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlActions.Location = New System.Drawing.Point(670, 14)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlActions.Size = New System.Drawing.Size(134, 386)
        Me.pnlActions.TabIndex = 2
        '
        'btnEditCommandIni
        '
        Me.btnEditCommandIni.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEditCommandIni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEditCommandIni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnEditCommandIni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnEditCommandIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCommandIni.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCommandIni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEditCommandIni.Location = New System.Drawing.Point(11, 305)
        Me.btnEditCommandIni.Name = "btnEditCommandIni"
        Me.btnEditCommandIni.Size = New System.Drawing.Size(108, 30)
        Me.btnEditCommandIni.TabIndex = 4
        Me.btnEditCommandIni.Text = "Edit Plugin INI"
        Me.btnEditCommandIni.UseVisualStyleBackColor = False
        '
        'btnEditPluginXml
        '
        Me.btnEditPluginXml.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEditPluginXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnEditPluginXml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnEditPluginXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnEditPluginXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPluginXml.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPluginXml.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEditPluginXml.Location = New System.Drawing.Point(11, 341)
        Me.btnEditPluginXml.Name = "btnEditPluginXml"
        Me.btnEditPluginXml.Size = New System.Drawing.Size(108, 30)
        Me.btnEditPluginXml.TabIndex = 3
        Me.btnEditPluginXml.Text = "Edit Plugin XML"
        Me.btnEditPluginXml.UseVisualStyleBackColor = False
        '
        'btnOpenPluginFolder
        '
        Me.btnOpenPluginFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnOpenPluginFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnOpenPluginFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnOpenPluginFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnOpenPluginFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenPluginFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenPluginFolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnOpenPluginFolder.Location = New System.Drawing.Point(11, 198)
        Me.btnOpenPluginFolder.Name = "btnOpenPluginFolder"
        Me.btnOpenPluginFolder.Size = New System.Drawing.Size(108, 34)
        Me.btnOpenPluginFolder.TabIndex = 2
        Me.btnOpenPluginFolder.Text = "Open Selected"
        Me.btnOpenPluginFolder.UseVisualStyleBackColor = False
        '
        'btnOpenPluginsFolder
        '
        Me.btnOpenPluginsFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnOpenPluginsFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnOpenPluginsFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnOpenPluginsFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnOpenPluginsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenPluginsFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenPluginsFolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnOpenPluginsFolder.Location = New System.Drawing.Point(11, 158)
        Me.btnOpenPluginsFolder.Name = "btnOpenPluginsFolder"
        Me.btnOpenPluginsFolder.Size = New System.Drawing.Size(108, 34)
        Me.btnOpenPluginsFolder.TabIndex = 1
        Me.btnOpenPluginsFolder.Text = "Open Plugin Dir"
        Me.btnOpenPluginsFolder.UseVisualStyleBackColor = False
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnReload.Location = New System.Drawing.Point(11, 49)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(108, 30)
        Me.btnReload.TabIndex = 0
        Me.btnReload.Text = "Reload Plugins"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlList.Controls.Add(Me.pnlAvailableList)
        Me.pnlList.Controls.Add(Me.pnlInstalledList)
        Me.pnlList.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlList.Location = New System.Drawing.Point(14, 14)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlList.Size = New System.Drawing.Size(265, 386)
        Me.pnlList.TabIndex = 0
        '
        'pnlAvailableList
        '
        Me.pnlAvailableList.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.pnlAvailableList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAvailableList.Controls.Add(Me.lbAvailablePlugins)
        Me.pnlAvailableList.Controls.Add(Me.lblAvailablePlugins)
        Me.pnlAvailableList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAvailableList.Location = New System.Drawing.Point(10, 202)
        Me.pnlAvailableList.Name = "pnlAvailableList"
        Me.pnlAvailableList.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.pnlAvailableList.Size = New System.Drawing.Size(243, 172)
        Me.pnlAvailableList.TabIndex = 1
        '
        'lbAvailablePlugins
        '
        Me.lbAvailablePlugins.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lbAvailablePlugins.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbAvailablePlugins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbAvailablePlugins.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAvailablePlugins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lbAvailablePlugins.FormattingEnabled = True
        Me.lbAvailablePlugins.IntegralHeight = False
        Me.lbAvailablePlugins.Location = New System.Drawing.Point(0, 32)
        Me.lbAvailablePlugins.Name = "lbAvailablePlugins"
        Me.lbAvailablePlugins.Size = New System.Drawing.Size(241, 138)
        Me.lbAvailablePlugins.TabIndex = 1
        '
        'lblAvailablePlugins
        '
        Me.lblAvailablePlugins.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailablePlugins.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAvailablePlugins.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailablePlugins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblAvailablePlugins.Location = New System.Drawing.Point(0, 8)
        Me.lblAvailablePlugins.Name = "lblAvailablePlugins"
        Me.lblAvailablePlugins.Size = New System.Drawing.Size(241, 24)
        Me.lblAvailablePlugins.TabIndex = 0
        Me.lblAvailablePlugins.Text = "Available Plugins"
        Me.lblAvailablePlugins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInstalledList
        '
        Me.pnlInstalledList.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.pnlInstalledList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInstalledList.Controls.Add(Me.lbPlugins)
        Me.pnlInstalledList.Controls.Add(Me.lblPlugins)
        Me.pnlInstalledList.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInstalledList.Location = New System.Drawing.Point(10, 10)
        Me.pnlInstalledList.Name = "pnlInstalledList"
        Me.pnlInstalledList.Size = New System.Drawing.Size(243, 192)
        Me.pnlInstalledList.TabIndex = 0
        '
        'lbPlugins
        '
        Me.lbPlugins.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lbPlugins.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbPlugins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPlugins.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPlugins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lbPlugins.FormattingEnabled = True
        Me.lbPlugins.IntegralHeight = False
        Me.lbPlugins.Location = New System.Drawing.Point(0, 24)
        Me.lbPlugins.Name = "lbPlugins"
        Me.lbPlugins.Size = New System.Drawing.Size(241, 166)
        Me.lbPlugins.TabIndex = 1
        '
        'lblPlugins
        '
        Me.lblPlugins.BackColor = System.Drawing.Color.Transparent
        Me.lblPlugins.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPlugins.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlugins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblPlugins.Location = New System.Drawing.Point(0, 0)
        Me.lblPlugins.Name = "lblPlugins"
        Me.lblPlugins.Size = New System.Drawing.Size(241, 24)
        Me.lblPlugins.TabIndex = 0
        Me.lblPlugins.Text = "Installed Plugins"
        Me.lblPlugins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.lblStatus)
        Me.pnlFooter.Controls.Add(Me.lblFooterRule)
        Me.pnlFooter.Controls.Add(Me.btnClose)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 502)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(818, 56)
        Me.pnlFooter.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(18, 17)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(670, 24)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Ready."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFooterRule
        '
        Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFooterRule.Location = New System.Drawing.Point(0, 0)
        Me.lblFooterRule.Name = "lblFooterRule"
        Me.lblFooterRule.Size = New System.Drawing.Size(818, 1)
        Me.lblFooterRule.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(708, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 28)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblHeaderRule)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(818, 88)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeaderRule
        '
        Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHeaderRule.Location = New System.Drawing.Point(0, 85)
        Me.lblHeaderRule.Name = "lblHeaderRule"
        Me.lblHeaderRule.Size = New System.Drawing.Size(818, 3)
        Me.lblHeaderRule.TabIndex = 2
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubtitle.AutoEllipsis = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(21, 52)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(777, 22)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Manage installed and available external tool plugins used by KoTOR Tool Restorati" &
    "on."
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
        Me.lblTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(780, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Plugin System"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDownloadPlugin
        '
        Me.btnDownloadPlugin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDownloadPlugin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDownloadPlugin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDownloadPlugin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnDownloadPlugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownloadPlugin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownloadPlugin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnDownloadPlugin.Location = New System.Drawing.Point(11, 13)
        Me.btnDownloadPlugin.Name = "btnDownloadPlugin"
        Me.btnDownloadPlugin.Size = New System.Drawing.Size(108, 30)
        Me.btnDownloadPlugin.TabIndex = 5
        Me.btnDownloadPlugin.Text = "Download Plugin"
        Me.btnDownloadPlugin.UseVisualStyleBackColor = False
        '
        'frmPluginSystem
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(820, 560)
        Me.Controls.Add(Me.pnlRoot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPluginSystem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Plugin System"
        Me.pnlRoot.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.pnlActions.ResumeLayout(False)
        Me.pnlList.ResumeLayout(False)
        Me.pnlAvailableList.ResumeLayout(False)
        Me.pnlInstalledList.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDownloadPlugin As System.Windows.Forms.Button
End Class
