Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class frmByteViewer
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmByteViewer.Designer.vb
        '
        ' Restored / facelifted Byte Viewer for the KoTOR Tool Restoration.
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
        '   - Event bindings are handled in the code-behind.
        '   - bv is now the custom DarkByteViewerControl used for the
        '     Hex / ANSI / Unicode byte views.
        ' -----------------------------------------------------------------

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents rbHex As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbANSI As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbUnicode As Global.System.Windows.Forms.RadioButton
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button

        Friend WithEvents bv As Global.kotor_tool.DarkByteViewerControl
        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlOptions As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlByteSurface As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label

        Friend WithEvents DarkPictureBox1 As Global.kotor_tool.DarkPictureBox

        ' -----------------------------------------------------------------
        ' Patch 1.0.3.3 - Byte Viewer primary utility controls.
        '
        ' These controls support the first practical investigation upgrades:
        '   - Search by hex/text pattern.
        '   - Go to decimal / hex offset.
        '   - Copy/export current dump output.
        '   - Display loaded byte status.
        ' -----------------------------------------------------------------
        Friend WithEvents pnlTools As Global.System.Windows.Forms.Panel
        Friend WithEvents lblFind As Global.System.Windows.Forms.Label
        Friend WithEvents tbFind As Global.System.Windows.Forms.TextBox
        Friend WithEvents cmbFindMode As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnFind As Global.System.Windows.Forms.Button
        Friend WithEvents btnFindNext As Global.System.Windows.Forms.Button
        Friend WithEvents lblGoto As Global.System.Windows.Forms.Label
        Friend WithEvents tbGotoOffset As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnGotoOffset As Global.System.Windows.Forms.Button
        Friend WithEvents cmbEncoding As Global.System.Windows.Forms.ComboBox
        Friend WithEvents lblEncoding As Global.System.Windows.Forms.Label
        Friend WithEvents btnCopyOffset As Global.System.Windows.Forms.Button
        Friend WithEvents btnCopyHex As Global.System.Windows.Forms.Button
        Friend WithEvents btnCopyAscii As Global.System.Windows.Forms.Button
        Friend WithEvents btnCopySelected As Global.System.Windows.Forms.Button
        Friend WithEvents btnExportDump As Global.System.Windows.Forms.Button
        Friend WithEvents btnExportVisible As Global.System.Windows.Forms.Button

        ' -----------------------------------------------------------------
        ' Patch 1.0.3.3 - Byte inspector and resource preview panel.
        '
        ' These are visual placeholders for backend selection support:
        '   - Current offset / visible range / selected byte count.
        '   - Byte value breakdown.
        '   - File/resource type hinting for KOTOR formats.
        ' -----------------------------------------------------------------
        Friend WithEvents pnlInspector As Global.System.Windows.Forms.Panel
        Friend WithEvents lblInspectorTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblDetectedTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblDetectedType As Global.System.Windows.Forms.Label
        Friend WithEvents lblOffsetTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblOffsetValue As Global.System.Windows.Forms.Label
        Friend WithEvents lblByteTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblByteValue As Global.System.Windows.Forms.Label
        Friend WithEvents lblUInt8Title As Global.System.Windows.Forms.Label
        Friend WithEvents lblUInt8Value As Global.System.Windows.Forms.Label
        Friend WithEvents lblInt8Title As Global.System.Windows.Forms.Label
        Friend WithEvents lblInt8Value As Global.System.Windows.Forms.Label
        Friend WithEvents lblAsciiTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblAsciiValue As Global.System.Windows.Forms.Label
        Friend WithEvents lblBinaryTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblBinaryValue As Global.System.Windows.Forms.Label
        Friend WithEvents lblSelectionTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSelectionValue As Global.System.Windows.Forms.Label
        Friend WithEvents lblVisibleTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblVisibleValue As Global.System.Windows.Forms.Label

        ' -----------------------------------------------------------------
        ' Patch 1.0.3.3 - Highlight toggles.
        '
        ' The renderer can later use these to highlight specific byte ranges:
        '   - NULL bytes.
        '   - Control characters.
        '   - High ASCII.
        '   - Non-printable bytes.
        ' -----------------------------------------------------------------
        Friend WithEvents gbHighlights As Global.System.Windows.Forms.GroupBox
        Friend WithEvents chkbHighlightNull As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbHighlightControl As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbHighlightHighAscii As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbHighlightNonPrintable As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbAlternateRows As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbFreezeHeader As Global.System.Windows.Forms.CheckBox

        ' -----------------------------------------------------------------
        ' Patch 1.0.3.3 - Footer status readout.
        ' -----------------------------------------------------------------
        Friend WithEvents lblStatus As Global.System.Windows.Forms.Label

        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.pnlByteSurface = New System.Windows.Forms.Panel()
            Me.pnlInspector = New System.Windows.Forms.Panel()
            Me.chkbFreezeHeader = New System.Windows.Forms.CheckBox()
            Me.chkbAlternateRows = New System.Windows.Forms.CheckBox()
            Me.gbHighlights = New System.Windows.Forms.GroupBox()
            Me.chkbHighlightNull = New System.Windows.Forms.CheckBox()
            Me.chkbHighlightControl = New System.Windows.Forms.CheckBox()
            Me.chkbHighlightHighAscii = New System.Windows.Forms.CheckBox()
            Me.chkbHighlightNonPrintable = New System.Windows.Forms.CheckBox()
            Me.lblVisibleValue = New System.Windows.Forms.Label()
            Me.lblVisibleTitle = New System.Windows.Forms.Label()
            Me.lblSelectionValue = New System.Windows.Forms.Label()
            Me.lblSelectionTitle = New System.Windows.Forms.Label()
            Me.lblBinaryValue = New System.Windows.Forms.Label()
            Me.lblBinaryTitle = New System.Windows.Forms.Label()
            Me.lblAsciiValue = New System.Windows.Forms.Label()
            Me.lblAsciiTitle = New System.Windows.Forms.Label()
            Me.lblInt8Value = New System.Windows.Forms.Label()
            Me.lblInt8Title = New System.Windows.Forms.Label()
            Me.lblUInt8Value = New System.Windows.Forms.Label()
            Me.lblUInt8Title = New System.Windows.Forms.Label()
            Me.lblByteValue = New System.Windows.Forms.Label()
            Me.lblByteTitle = New System.Windows.Forms.Label()
            Me.lblOffsetValue = New System.Windows.Forms.Label()
            Me.lblOffsetTitle = New System.Windows.Forms.Label()
            Me.lblDetectedType = New System.Windows.Forms.Label()
            Me.lblDetectedTitle = New System.Windows.Forms.Label()
            Me.lblInspectorTitle = New System.Windows.Forms.Label()
            Me.pnlTools = New System.Windows.Forms.Panel()
            Me.btnExportVisible = New System.Windows.Forms.Button()
            Me.btnExportDump = New System.Windows.Forms.Button()
            Me.btnCopySelected = New System.Windows.Forms.Button()
            Me.btnCopyAscii = New System.Windows.Forms.Button()
            Me.btnCopyHex = New System.Windows.Forms.Button()
            Me.btnCopyOffset = New System.Windows.Forms.Button()
            Me.cmbEncoding = New System.Windows.Forms.ComboBox()
            Me.lblEncoding = New System.Windows.Forms.Label()
            Me.btnGotoOffset = New System.Windows.Forms.Button()
            Me.tbGotoOffset = New System.Windows.Forms.TextBox()
            Me.lblGoto = New System.Windows.Forms.Label()
            Me.btnFindNext = New System.Windows.Forms.Button()
            Me.btnFind = New System.Windows.Forms.Button()
            Me.cmbFindMode = New System.Windows.Forms.ComboBox()
            Me.tbFind = New System.Windows.Forms.TextBox()
            Me.lblFind = New System.Windows.Forms.Label()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.pnlOptions = New System.Windows.Forms.Panel()
            Me.rbHex = New System.Windows.Forms.RadioButton()
            Me.rbANSI = New System.Windows.Forms.RadioButton()
            Me.rbUnicode = New System.Windows.Forms.RadioButton()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.bv = New kotor_tool.DarkByteViewerControl()
            Me.DarkPictureBox1 = New kotor_tool.DarkPictureBox()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlByteSurface.SuspendLayout()
            Me.pnlInspector.SuspendLayout()
            Me.gbHighlights.SuspendLayout()
            Me.pnlTools.SuspendLayout()
            Me.pnlFooter.SuspendLayout()
            Me.pnlOptions.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            CType(Me.DarkPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.pnlRoot.Size = New System.Drawing.Size(960, 770)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.pnlByteSurface)
            Me.pnlBody.Controls.Add(Me.pnlInspector)
            Me.pnlBody.Controls.Add(Me.pnlTools)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 127)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(16)
            Me.pnlBody.Size = New System.Drawing.Size(958, 585)
            Me.pnlBody.TabIndex = 1
            '
            'pnlByteSurface
            '
            Me.pnlByteSurface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlByteSurface.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
            Me.pnlByteSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlByteSurface.Controls.Add(Me.bv)
            Me.pnlByteSurface.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.pnlByteSurface.Location = New System.Drawing.Point(18, 118)
            Me.pnlByteSurface.Name = "pnlByteSurface"
            Me.pnlByteSurface.Size = New System.Drawing.Size(660, 439)
            Me.pnlByteSurface.TabIndex = 1
            '
            'pnlInspector
            '
            Me.pnlInspector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlInspector.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlInspector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlInspector.Controls.Add(Me.chkbFreezeHeader)
            Me.pnlInspector.Controls.Add(Me.chkbAlternateRows)
            Me.pnlInspector.Controls.Add(Me.gbHighlights)
            Me.pnlInspector.Controls.Add(Me.lblVisibleValue)
            Me.pnlInspector.Controls.Add(Me.lblVisibleTitle)
            Me.pnlInspector.Controls.Add(Me.lblSelectionValue)
            Me.pnlInspector.Controls.Add(Me.lblSelectionTitle)
            Me.pnlInspector.Controls.Add(Me.lblBinaryValue)
            Me.pnlInspector.Controls.Add(Me.lblBinaryTitle)
            Me.pnlInspector.Controls.Add(Me.lblAsciiValue)
            Me.pnlInspector.Controls.Add(Me.lblAsciiTitle)
            Me.pnlInspector.Controls.Add(Me.lblInt8Value)
            Me.pnlInspector.Controls.Add(Me.lblInt8Title)
            Me.pnlInspector.Controls.Add(Me.lblUInt8Value)
            Me.pnlInspector.Controls.Add(Me.lblUInt8Title)
            Me.pnlInspector.Controls.Add(Me.lblByteValue)
            Me.pnlInspector.Controls.Add(Me.lblByteTitle)
            Me.pnlInspector.Controls.Add(Me.lblOffsetValue)
            Me.pnlInspector.Controls.Add(Me.lblOffsetTitle)
            Me.pnlInspector.Controls.Add(Me.lblDetectedType)
            Me.pnlInspector.Controls.Add(Me.lblDetectedTitle)
            Me.pnlInspector.Controls.Add(Me.lblInspectorTitle)
            Me.pnlInspector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.pnlInspector.Location = New System.Drawing.Point(696, 118)
            Me.pnlInspector.Name = "pnlInspector"
            Me.pnlInspector.Size = New System.Drawing.Size(244, 439)
            Me.pnlInspector.TabIndex = 2
            '
            'chkbFreezeHeader
            '
            Me.chkbFreezeHeader.Checked = True
            Me.chkbFreezeHeader.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbFreezeHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbFreezeHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbFreezeHeader.Location = New System.Drawing.Point(14, 350)
            Me.chkbFreezeHeader.Name = "chkbFreezeHeader"
            Me.chkbFreezeHeader.Size = New System.Drawing.Size(106, 22)
            Me.chkbFreezeHeader.TabIndex = 21
            Me.chkbFreezeHeader.Text = "Freeze Header"
            '
            'chkbAlternateRows
            '
            Me.chkbAlternateRows.Checked = True
            Me.chkbAlternateRows.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkbAlternateRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbAlternateRows.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbAlternateRows.Location = New System.Drawing.Point(126, 350)
            Me.chkbAlternateRows.Name = "chkbAlternateRows"
            Me.chkbAlternateRows.Size = New System.Drawing.Size(104, 22)
            Me.chkbAlternateRows.TabIndex = 22
            Me.chkbAlternateRows.Text = "Alt Rows"
            '
            'gbHighlights
            '
            Me.gbHighlights.Controls.Add(Me.chkbHighlightNull)
            Me.gbHighlights.Controls.Add(Me.chkbHighlightControl)
            Me.gbHighlights.Controls.Add(Me.chkbHighlightHighAscii)
            Me.gbHighlights.Controls.Add(Me.chkbHighlightNonPrintable)
            Me.gbHighlights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gbHighlights.Location = New System.Drawing.Point(14, 246)
            Me.gbHighlights.Name = "gbHighlights"
            Me.gbHighlights.Size = New System.Drawing.Size(216, 98)
            Me.gbHighlights.TabIndex = 20
            Me.gbHighlights.TabStop = False
            Me.gbHighlights.Text = "Highlight Bytes"
            '
            'chkbHighlightNull
            '
            Me.chkbHighlightNull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbHighlightNull.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbHighlightNull.Location = New System.Drawing.Point(10, 20)
            Me.chkbHighlightNull.Name = "chkbHighlightNull"
            Me.chkbHighlightNull.Size = New System.Drawing.Size(88, 20)
            Me.chkbHighlightNull.TabIndex = 0
            Me.chkbHighlightNull.Text = "NULL"
            '
            'chkbHighlightControl
            '
            Me.chkbHighlightControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbHighlightControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbHighlightControl.Location = New System.Drawing.Point(108, 20)
            Me.chkbHighlightControl.Name = "chkbHighlightControl"
            Me.chkbHighlightControl.Size = New System.Drawing.Size(96, 20)
            Me.chkbHighlightControl.TabIndex = 1
            Me.chkbHighlightControl.Text = "Control"
            '
            'chkbHighlightHighAscii
            '
            Me.chkbHighlightHighAscii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbHighlightHighAscii.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbHighlightHighAscii.Location = New System.Drawing.Point(10, 54)
            Me.chkbHighlightHighAscii.Name = "chkbHighlightHighAscii"
            Me.chkbHighlightHighAscii.Size = New System.Drawing.Size(88, 20)
            Me.chkbHighlightHighAscii.TabIndex = 2
            Me.chkbHighlightHighAscii.Text = "High ASCII"
            '
            'chkbHighlightNonPrintable
            '
            Me.chkbHighlightNonPrintable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbHighlightNonPrintable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbHighlightNonPrintable.Location = New System.Drawing.Point(108, 54)
            Me.chkbHighlightNonPrintable.Name = "chkbHighlightNonPrintable"
            Me.chkbHighlightNonPrintable.Size = New System.Drawing.Size(104, 20)
            Me.chkbHighlightNonPrintable.TabIndex = 3
            Me.chkbHighlightNonPrintable.Text = "Non-print"
            '
            'lblVisibleValue
            '
            Me.lblVisibleValue.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVisibleValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblVisibleValue.Location = New System.Drawing.Point(96, 216)
            Me.lblVisibleValue.Name = "lblVisibleValue"
            Me.lblVisibleValue.Size = New System.Drawing.Size(134, 18)
            Me.lblVisibleValue.TabIndex = 19
            Me.lblVisibleValue.Text = "0x00000000-0x00000000"
            Me.lblVisibleValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblVisibleTitle
            '
            Me.lblVisibleTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblVisibleTitle.Location = New System.Drawing.Point(14, 216)
            Me.lblVisibleTitle.Name = "lblVisibleTitle"
            Me.lblVisibleTitle.Size = New System.Drawing.Size(76, 18)
            Me.lblVisibleTitle.TabIndex = 18
            Me.lblVisibleTitle.Text = "Visible"
            '
            'lblSelectionValue
            '
            Me.lblSelectionValue.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSelectionValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblSelectionValue.Location = New System.Drawing.Point(96, 194)
            Me.lblSelectionValue.Name = "lblSelectionValue"
            Me.lblSelectionValue.Size = New System.Drawing.Size(134, 18)
            Me.lblSelectionValue.TabIndex = 17
            Me.lblSelectionValue.Text = "0 bytes"
            Me.lblSelectionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblSelectionTitle
            '
            Me.lblSelectionTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSelectionTitle.Location = New System.Drawing.Point(14, 194)
            Me.lblSelectionTitle.Name = "lblSelectionTitle"
            Me.lblSelectionTitle.Size = New System.Drawing.Size(76, 18)
            Me.lblSelectionTitle.TabIndex = 16
            Me.lblSelectionTitle.Text = "Selected"
            '
            'lblBinaryValue
            '
            Me.lblBinaryValue.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBinaryValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblBinaryValue.Location = New System.Drawing.Point(96, 166)
            Me.lblBinaryValue.Name = "lblBinaryValue"
            Me.lblBinaryValue.Size = New System.Drawing.Size(134, 18)
            Me.lblBinaryValue.TabIndex = 15
            Me.lblBinaryValue.Text = "00000000"
            Me.lblBinaryValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblBinaryTitle
            '
            Me.lblBinaryTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblBinaryTitle.Location = New System.Drawing.Point(14, 166)
            Me.lblBinaryTitle.Name = "lblBinaryTitle"
            Me.lblBinaryTitle.Size = New System.Drawing.Size(76, 18)
            Me.lblBinaryTitle.TabIndex = 14
            Me.lblBinaryTitle.Text = "Binary"
            '
            'lblAsciiValue
            '
            Me.lblAsciiValue.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAsciiValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblAsciiValue.Location = New System.Drawing.Point(96, 144)
            Me.lblAsciiValue.Name = "lblAsciiValue"
            Me.lblAsciiValue.Size = New System.Drawing.Size(134, 18)
            Me.lblAsciiValue.TabIndex = 13
            Me.lblAsciiValue.Text = "."
            Me.lblAsciiValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblAsciiTitle
            '
            Me.lblAsciiTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblAsciiTitle.Location = New System.Drawing.Point(14, 144)
            Me.lblAsciiTitle.Name = "lblAsciiTitle"
            Me.lblAsciiTitle.Size = New System.Drawing.Size(76, 18)
            Me.lblAsciiTitle.TabIndex = 12
            Me.lblAsciiTitle.Text = "ASCII"
            '
            'lblInt8Value
            '
            Me.lblInt8Value.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInt8Value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblInt8Value.Location = New System.Drawing.Point(96, 122)
            Me.lblInt8Value.Name = "lblInt8Value"
            Me.lblInt8Value.Size = New System.Drawing.Size(134, 18)
            Me.lblInt8Value.TabIndex = 11
            Me.lblInt8Value.Text = "0"
            Me.lblInt8Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblInt8Title
            '
            Me.lblInt8Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblInt8Title.Location = New System.Drawing.Point(14, 122)
            Me.lblInt8Title.Name = "lblInt8Title"
            Me.lblInt8Title.Size = New System.Drawing.Size(76, 18)
            Me.lblInt8Title.TabIndex = 10
            Me.lblInt8Title.Text = "Int8"
            '
            'lblUInt8Value
            '
            Me.lblUInt8Value.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUInt8Value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblUInt8Value.Location = New System.Drawing.Point(96, 100)
            Me.lblUInt8Value.Name = "lblUInt8Value"
            Me.lblUInt8Value.Size = New System.Drawing.Size(134, 18)
            Me.lblUInt8Value.TabIndex = 9
            Me.lblUInt8Value.Text = "0"
            Me.lblUInt8Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblUInt8Title
            '
            Me.lblUInt8Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblUInt8Title.Location = New System.Drawing.Point(14, 100)
            Me.lblUInt8Title.Name = "lblUInt8Title"
            Me.lblUInt8Title.Size = New System.Drawing.Size(76, 18)
            Me.lblUInt8Title.TabIndex = 8
            Me.lblUInt8Title.Text = "UInt8"
            '
            'lblByteValue
            '
            Me.lblByteValue.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblByteValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblByteValue.Location = New System.Drawing.Point(96, 78)
            Me.lblByteValue.Name = "lblByteValue"
            Me.lblByteValue.Size = New System.Drawing.Size(134, 18)
            Me.lblByteValue.TabIndex = 7
            Me.lblByteValue.Text = "0x00"
            Me.lblByteValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblByteTitle
            '
            Me.lblByteTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblByteTitle.Location = New System.Drawing.Point(14, 78)
            Me.lblByteTitle.Name = "lblByteTitle"
            Me.lblByteTitle.Size = New System.Drawing.Size(76, 18)
            Me.lblByteTitle.TabIndex = 6
            Me.lblByteTitle.Text = "Byte"
            '
            'lblOffsetValue
            '
            Me.lblOffsetValue.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOffsetValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblOffsetValue.Location = New System.Drawing.Point(96, 56)
            Me.lblOffsetValue.Name = "lblOffsetValue"
            Me.lblOffsetValue.Size = New System.Drawing.Size(134, 18)
            Me.lblOffsetValue.TabIndex = 5
            Me.lblOffsetValue.Text = "0x00000000"
            Me.lblOffsetValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblOffsetTitle
            '
            Me.lblOffsetTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblOffsetTitle.Location = New System.Drawing.Point(14, 56)
            Me.lblOffsetTitle.Name = "lblOffsetTitle"
            Me.lblOffsetTitle.Size = New System.Drawing.Size(76, 18)
            Me.lblOffsetTitle.TabIndex = 4
            Me.lblOffsetTitle.Text = "Offset"
            '
            'lblDetectedType
            '
            Me.lblDetectedType.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetectedType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblDetectedType.Location = New System.Drawing.Point(96, 32)
            Me.lblDetectedType.Name = "lblDetectedType"
            Me.lblDetectedType.Size = New System.Drawing.Size(134, 18)
            Me.lblDetectedType.TabIndex = 3
            Me.lblDetectedType.Text = "Unknown"
            Me.lblDetectedType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDetectedTitle
            '
            Me.lblDetectedTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblDetectedTitle.Location = New System.Drawing.Point(14, 32)
            Me.lblDetectedTitle.Name = "lblDetectedTitle"
            Me.lblDetectedTitle.Size = New System.Drawing.Size(76, 18)
            Me.lblDetectedTitle.TabIndex = 2
            Me.lblDetectedTitle.Text = "Detected"
            '
            'lblInspectorTitle
            '
            Me.lblInspectorTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblInspectorTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblInspectorTitle.Location = New System.Drawing.Point(12, 8)
            Me.lblInspectorTitle.Name = "lblInspectorTitle"
            Me.lblInspectorTitle.Size = New System.Drawing.Size(218, 18)
            Me.lblInspectorTitle.TabIndex = 0
            Me.lblInspectorTitle.Text = "Byte Inspector"
            Me.lblInspectorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlTools
            '
            Me.pnlTools.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTools.Controls.Add(Me.btnExportVisible)
            Me.pnlTools.Controls.Add(Me.btnExportDump)
            Me.pnlTools.Controls.Add(Me.btnCopySelected)
            Me.pnlTools.Controls.Add(Me.btnCopyAscii)
            Me.pnlTools.Controls.Add(Me.btnCopyHex)
            Me.pnlTools.Controls.Add(Me.btnCopyOffset)
            Me.pnlTools.Controls.Add(Me.cmbEncoding)
            Me.pnlTools.Controls.Add(Me.lblEncoding)
            Me.pnlTools.Controls.Add(Me.btnGotoOffset)
            Me.pnlTools.Controls.Add(Me.tbGotoOffset)
            Me.pnlTools.Controls.Add(Me.lblGoto)
            Me.pnlTools.Controls.Add(Me.btnFindNext)
            Me.pnlTools.Controls.Add(Me.btnFind)
            Me.pnlTools.Controls.Add(Me.cmbFindMode)
            Me.pnlTools.Controls.Add(Me.tbFind)
            Me.pnlTools.Controls.Add(Me.lblFind)
            Me.pnlTools.Location = New System.Drawing.Point(18, 18)
            Me.pnlTools.Name = "pnlTools"
            Me.pnlTools.Size = New System.Drawing.Size(922, 84)
            Me.pnlTools.TabIndex = 0
            '
            'btnExportVisible
            '
            Me.btnExportVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExportVisible.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnExportVisible.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnExportVisible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnExportVisible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnExportVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExportVisible.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportVisible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnExportVisible.Location = New System.Drawing.Point(820, 48)
            Me.btnExportVisible.Name = "btnExportVisible"
            Me.btnExportVisible.Size = New System.Drawing.Size(86, 24)
            Me.btnExportVisible.TabIndex = 15
            Me.btnExportVisible.Text = "Export View"
            Me.btnExportVisible.UseVisualStyleBackColor = False
            '
            'btnExportDump
            '
            Me.btnExportDump.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExportDump.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnExportDump.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnExportDump.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnExportDump.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnExportDump.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExportDump.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportDump.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnExportDump.Location = New System.Drawing.Point(728, 48)
            Me.btnExportDump.Name = "btnExportDump"
            Me.btnExportDump.Size = New System.Drawing.Size(86, 24)
            Me.btnExportDump.TabIndex = 14
            Me.btnExportDump.Text = "Export All"
            Me.btnExportDump.UseVisualStyleBackColor = False
            '
            'btnCopySelected
            '
            Me.btnCopySelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCopySelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCopySelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCopySelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCopySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCopySelected.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCopySelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCopySelected.Location = New System.Drawing.Point(304, 48)
            Me.btnCopySelected.Name = "btnCopySelected"
            Me.btnCopySelected.Size = New System.Drawing.Size(92, 24)
            Me.btnCopySelected.TabIndex = 13
            Me.btnCopySelected.Text = "Copy Sel"
            Me.btnCopySelected.UseVisualStyleBackColor = False
            '
            'btnCopyAscii
            '
            Me.btnCopyAscii.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCopyAscii.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCopyAscii.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCopyAscii.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCopyAscii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCopyAscii.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCopyAscii.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCopyAscii.Location = New System.Drawing.Point(206, 48)
            Me.btnCopyAscii.Name = "btnCopyAscii"
            Me.btnCopyAscii.Size = New System.Drawing.Size(92, 24)
            Me.btnCopyAscii.TabIndex = 12
            Me.btnCopyAscii.Text = "Copy ASCII"
            Me.btnCopyAscii.UseVisualStyleBackColor = False
            '
            'btnCopyHex
            '
            Me.btnCopyHex.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCopyHex.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCopyHex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCopyHex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCopyHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCopyHex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCopyHex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCopyHex.Location = New System.Drawing.Point(108, 48)
            Me.btnCopyHex.Name = "btnCopyHex"
            Me.btnCopyHex.Size = New System.Drawing.Size(92, 24)
            Me.btnCopyHex.TabIndex = 11
            Me.btnCopyHex.Text = "Copy Hex"
            Me.btnCopyHex.UseVisualStyleBackColor = False
            '
            'btnCopyOffset
            '
            Me.btnCopyOffset.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnCopyOffset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnCopyOffset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnCopyOffset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnCopyOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCopyOffset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCopyOffset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnCopyOffset.Location = New System.Drawing.Point(10, 48)
            Me.btnCopyOffset.Name = "btnCopyOffset"
            Me.btnCopyOffset.Size = New System.Drawing.Size(92, 24)
            Me.btnCopyOffset.TabIndex = 10
            Me.btnCopyOffset.Text = "Copy Offset"
            Me.btnCopyOffset.UseVisualStyleBackColor = False
            '
            'cmbEncoding
            '
            Me.cmbEncoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbEncoding.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEncoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbEncoding.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbEncoding.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbEncoding.Items.AddRange(New Object() {"Hexdump", "ANSI", "UTF-8", "UTF-16 LE", "UTF-16 BE"})
            Me.cmbEncoding.Location = New System.Drawing.Point(784, 13)
            Me.cmbEncoding.Name = "cmbEncoding"
            Me.cmbEncoding.Size = New System.Drawing.Size(122, 21)
            Me.cmbEncoding.TabIndex = 9
            '
            'lblEncoding
            '
            Me.lblEncoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblEncoding.BackColor = System.Drawing.Color.Transparent
            Me.lblEncoding.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEncoding.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblEncoding.Location = New System.Drawing.Point(714, 14)
            Me.lblEncoding.Name = "lblEncoding"
            Me.lblEncoding.Size = New System.Drawing.Size(64, 20)
            Me.lblEncoding.TabIndex = 8
            Me.lblEncoding.Text = "Encoding"
            Me.lblEncoding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnGotoOffset
            '
            Me.btnGotoOffset.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnGotoOffset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnGotoOffset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnGotoOffset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnGotoOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGotoOffset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGotoOffset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnGotoOffset.Location = New System.Drawing.Point(656, 11)
            Me.btnGotoOffset.Name = "btnGotoOffset"
            Me.btnGotoOffset.Size = New System.Drawing.Size(42, 24)
            Me.btnGotoOffset.TabIndex = 7
            Me.btnGotoOffset.Text = "Go"
            Me.btnGotoOffset.UseVisualStyleBackColor = False
            '
            'tbGotoOffset
            '
            Me.tbGotoOffset.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbGotoOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbGotoOffset.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbGotoOffset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbGotoOffset.Location = New System.Drawing.Point(558, 13)
            Me.tbGotoOffset.Name = "tbGotoOffset"
            Me.tbGotoOffset.Size = New System.Drawing.Size(92, 20)
            Me.tbGotoOffset.TabIndex = 6
            Me.tbGotoOffset.Text = "0x00000000"
            '
            'lblGoto
            '
            Me.lblGoto.BackColor = System.Drawing.Color.Transparent
            Me.lblGoto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblGoto.Location = New System.Drawing.Point(506, 13)
            Me.lblGoto.Name = "lblGoto"
            Me.lblGoto.Size = New System.Drawing.Size(46, 20)
            Me.lblGoto.TabIndex = 5
            Me.lblGoto.Text = "Offset"
            Me.lblGoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnFindNext
            '
            Me.btnFindNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnFindNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnFindNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnFindNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFindNext.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFindNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnFindNext.Location = New System.Drawing.Point(434, 11)
            Me.btnFindNext.Name = "btnFindNext"
            Me.btnFindNext.Size = New System.Drawing.Size(56, 24)
            Me.btnFindNext.TabIndex = 4
            Me.btnFindNext.Text = "Next"
            Me.btnFindNext.UseVisualStyleBackColor = False
            '
            'btnFind
            '
            Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFind.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnFind.Location = New System.Drawing.Point(374, 11)
            Me.btnFind.Name = "btnFind"
            Me.btnFind.Size = New System.Drawing.Size(54, 24)
            Me.btnFind.TabIndex = 3
            Me.btnFind.Text = "Find"
            Me.btnFind.UseVisualStyleBackColor = False
            '
            'cmbFindMode
            '
            Me.cmbFindMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbFindMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFindMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbFindMode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbFindMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbFindMode.Items.AddRange(New Object() {"Hex", "ANSI", "Unicode"})
            Me.cmbFindMode.Location = New System.Drawing.Point(274, 13)
            Me.cmbFindMode.Name = "cmbFindMode"
            Me.cmbFindMode.Size = New System.Drawing.Size(92, 21)
            Me.cmbFindMode.TabIndex = 2
            '
            'tbFind
            '
            Me.tbFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbFind.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbFind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbFind.Location = New System.Drawing.Point(48, 13)
            Me.tbFind.Name = "tbFind"
            Me.tbFind.Size = New System.Drawing.Size(218, 20)
            Me.tbFind.TabIndex = 1
            '
            'lblFind
            '
            Me.lblFind.BackColor = System.Drawing.Color.Transparent
            Me.lblFind.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblFind.Location = New System.Drawing.Point(10, 13)
            Me.lblFind.Name = "lblFind"
            Me.lblFind.Size = New System.Drawing.Size(34, 20)
            Me.lblFind.TabIndex = 0
            Me.lblFind.Text = "Find"
            Me.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(16, 567)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(926, 2)
            Me.lblSeparatorBottom.TabIndex = 3
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.pnlOptions)
            Me.pnlFooter.Controls.Add(Me.lblStatus)
            Me.pnlFooter.Controls.Add(Me.Button1)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 712)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(958, 56)
            Me.pnlFooter.TabIndex = 2
            '
            'pnlOptions
            '
            Me.pnlOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pnlOptions.BackColor = System.Drawing.Color.Transparent
            Me.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlOptions.Controls.Add(Me.rbHex)
            Me.pnlOptions.Controls.Add(Me.rbANSI)
            Me.pnlOptions.Controls.Add(Me.rbUnicode)
            Me.pnlOptions.Location = New System.Drawing.Point(18, 15)
            Me.pnlOptions.Name = "pnlOptions"
            Me.pnlOptions.Size = New System.Drawing.Size(201, 28)
            Me.pnlOptions.TabIndex = 0
            '
            'rbHex
            '
            Me.rbHex.BackColor = System.Drawing.Color.Transparent
            Me.rbHex.Checked = True
            Me.rbHex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbHex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.rbHex.Location = New System.Drawing.Point(6, 4)
            Me.rbHex.Name = "rbHex"
            Me.rbHex.Size = New System.Drawing.Size(55, 18)
            Me.rbHex.TabIndex = 0
            Me.rbHex.TabStop = True
            Me.rbHex.Text = "Hex"
            Me.rbHex.UseVisualStyleBackColor = False
            '
            'rbANSI
            '
            Me.rbANSI.BackColor = System.Drawing.Color.Transparent
            Me.rbANSI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbANSI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.rbANSI.Location = New System.Drawing.Point(67, 4)
            Me.rbANSI.Name = "rbANSI"
            Me.rbANSI.Size = New System.Drawing.Size(54, 18)
            Me.rbANSI.TabIndex = 1
            Me.rbANSI.Text = "ANSI"
            Me.rbANSI.UseVisualStyleBackColor = False
            '
            'rbUnicode
            '
            Me.rbUnicode.BackColor = System.Drawing.Color.Transparent
            Me.rbUnicode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbUnicode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.rbUnicode.Location = New System.Drawing.Point(127, 4)
            Me.rbUnicode.Name = "rbUnicode"
            Me.rbUnicode.Size = New System.Drawing.Size(71, 18)
            Me.rbUnicode.TabIndex = 2
            Me.rbUnicode.Text = "Unicode"
            Me.rbUnicode.UseVisualStyleBackColor = False
            '
            'lblStatus
            '
            Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblStatus.BackColor = System.Drawing.Color.Transparent
            Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblStatus.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblStatus.Location = New System.Drawing.Point(225, 15)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(621, 28)
            Me.lblStatus.TabIndex = 1
            Me.lblStatus.Text = "Size: 0 bytes | Offset: 0x00000000 | Visible: 0x00000000-0x00000000 | Selected: 0" &
    ""
            Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button1.Location = New System.Drawing.Point(862, 15)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(78, 27)
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "OK"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.DarkPictureBox1)
            Me.pnlHeader.Controls.Add(Me.lblSeparatorTop)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(958, 127)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 124)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(958, 3)
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
            Me.lblSubtitle.Location = New System.Drawing.Point(132, 50)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(808, 24)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Inspect raw KOTOR resources with search, offset navigation, byte selection, copy/" &
    "export tools, encoding views, and resource detection."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTitle
            '
            Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTitle.AutoEllipsis = True
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(130, 10)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(810, 38)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Byte Viewer"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'bv
            '
            Me.bv.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
            Me.bv.DisplayMode = kotor_tool.DarkByteViewerDisplayMode.Hexdump
            Me.bv.Dock = System.Windows.Forms.DockStyle.Fill
            Me.bv.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.bv.Location = New System.Drawing.Point(0, 0)
            Me.bv.Name = "bv"
            Me.bv.Size = New System.Drawing.Size(658, 437)
            Me.bv.TabIndex = 0
            '
            'DarkPictureBox1
            '
            Me.DarkPictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.DarkPictureBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.DarkPictureBox1.BorderColorSecondary = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.DarkPictureBox1.BorderThickness = 1
            Me.DarkPictureBox1.CornerRadius = 8
            Me.DarkPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.DarkPictureBox1.Image = Global.My.Resources.Resources.koTOR_icon
            Me.DarkPictureBox1.InnerHighlightColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.DarkPictureBox1.InnerPadding = 4
            Me.DarkPictureBox1.Location = New System.Drawing.Point(18, 10)
            Me.DarkPictureBox1.Name = "DarkPictureBox1"
            Me.DarkPictureBox1.OuterShadowColor = System.Drawing.Color.Transparent
            Me.DarkPictureBox1.OuterShadowThickness = 2
            Me.DarkPictureBox1.SecondaryBorderThickness = 1
            Me.DarkPictureBox1.Size = New System.Drawing.Size(100, 100)
            Me.DarkPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.DarkPictureBox1.TabIndex = 3
            Me.DarkPictureBox1.TabStop = False
            Me.DarkPictureBox1.UseInnerHighlight = True
            Me.DarkPictureBox1.UseSecondaryBorder = True
            '
            'frmByteViewer
            '
            Me.AcceptButton = Me.Button1
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(960, 770)
            Me.Controls.Add(Me.pnlRoot)
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.MinimumSize = New System.Drawing.Size(900, 520)
            Me.Name = "frmByteViewer"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Byte Viewer"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlByteSurface.ResumeLayout(False)
            Me.pnlInspector.ResumeLayout(False)
            Me.gbHighlights.ResumeLayout(False)
            Me.pnlTools.ResumeLayout(False)
            Me.pnlTools.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlOptions.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            CType(Me.DarkPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace
