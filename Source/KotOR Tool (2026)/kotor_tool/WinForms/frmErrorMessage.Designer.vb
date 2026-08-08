Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmErrorMessage
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' frmErrorMessageWithCopyableText.Designer.vb
        '
        ' Restored / facelifted copyable error message dialog for the KoTOR
        ' Tool Restoration.
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

        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnJitDebug As Global.System.Windows.Forms.Button
        Friend WithEvents pnlSummary As Global.System.Windows.Forms.Panel
        Friend WithEvents lblSummaryAccent As Global.System.Windows.Forms.Label
        Friend WithEvents lblMsg As Global.System.Windows.Forms.Label
        Friend WithEvents lblCategory As Global.System.Windows.Forms.Label
        Friend WithEvents lblCategoryValue As Global.System.Windows.Forms.Label
        Friend WithEvents lblImpact As Global.System.Windows.Forms.Label
        Friend WithEvents lblImpactValue As Global.System.Windows.Forms.Label
        Friend WithEvents lblNextStep As Global.System.Windows.Forms.Label
        Friend WithEvents lblNextStepValue As Global.System.Windows.Forms.Label
        Friend WithEvents lblTechnicalHeading As Global.System.Windows.Forms.Label
        Friend WithEvents tbMsg As Global.System.Windows.Forms.TextBox

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorTop As Global.System.Windows.Forms.Label
        Friend WithEvents lblSeparatorBottom As Global.System.Windows.Forms.Label

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErrorMessage))
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.pnlSummary = New System.Windows.Forms.Panel()
            Me.lblMsg = New System.Windows.Forms.Label()
            Me.lblCategory = New System.Windows.Forms.Label()
            Me.lblCategoryValue = New System.Windows.Forms.Label()
            Me.lblImpact = New System.Windows.Forms.Label()
            Me.lblImpactValue = New System.Windows.Forms.Label()
            Me.lblNextStep = New System.Windows.Forms.Label()
            Me.lblNextStepValue = New System.Windows.Forms.Label()
            Me.lblSummaryAccent = New System.Windows.Forms.Label()
            Me.lblTechnicalHeading = New System.Windows.Forms.Label()
            Me.tbMsg = New System.Windows.Forms.TextBox()
            Me.lblSeparatorBottom = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnJitDebug = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSeparatorTop = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.pnlSummary.SuspendLayout()
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
            Me.pnlBody.Controls.Add(Me.pnlSummary)
            Me.pnlBody.Controls.Add(Me.lblTechnicalHeading)
            Me.pnlBody.Controls.Add(Me.tbMsg)
            Me.pnlBody.Controls.Add(Me.lblSeparatorBottom)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 76)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(22, 18, 22, 14)
            Me.pnlBody.Size = New System.Drawing.Size(818, 430)
            Me.pnlBody.TabIndex = 1
            '
            'pnlSummary
            '
            Me.pnlSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlSummary.Controls.Add(Me.lblMsg)
            Me.pnlSummary.Controls.Add(Me.lblCategory)
            Me.pnlSummary.Controls.Add(Me.lblCategoryValue)
            Me.pnlSummary.Controls.Add(Me.lblImpact)
            Me.pnlSummary.Controls.Add(Me.lblImpactValue)
            Me.pnlSummary.Controls.Add(Me.lblNextStep)
            Me.pnlSummary.Controls.Add(Me.lblNextStepValue)
            Me.pnlSummary.Controls.Add(Me.lblSummaryAccent)
            Me.pnlSummary.Location = New System.Drawing.Point(22, 10)
            Me.pnlSummary.Name = "pnlSummary"
            Me.pnlSummary.Size = New System.Drawing.Size(774, 137)
            Me.pnlSummary.TabIndex = 0
            '
            'lblMsg
            '
            Me.lblMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblMsg.BackColor = System.Drawing.Color.Transparent
            Me.lblMsg.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblMsg.Location = New System.Drawing.Point(18, 8)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New System.Drawing.Size(736, 38)
            Me.lblMsg.TabIndex = 0
            Me.lblMsg.Text = "KoTOR Tool caught an unhandled exception and prepared the details below. Review t" &
    "he category and impact, then choose whether to continue, close, or attach a debu" &
    "gger."
            Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCategory
            '
            Me.lblCategory.BackColor = System.Drawing.Color.Transparent
            Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.lblCategory.Location = New System.Drawing.Point(18, 58)
            Me.lblCategory.Name = "lblCategory"
            Me.lblCategory.Size = New System.Drawing.Size(78, 19)
            Me.lblCategory.TabIndex = 1
            Me.lblCategory.Text = "Category"
            Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCategoryValue
            '
            Me.lblCategoryValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCategoryValue.BackColor = System.Drawing.Color.Transparent
            Me.lblCategoryValue.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCategoryValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblCategoryValue.Location = New System.Drawing.Point(102, 58)
            Me.lblCategoryValue.Name = "lblCategoryValue"
            Me.lblCategoryValue.Size = New System.Drawing.Size(652, 19)
            Me.lblCategoryValue.TabIndex = 2
            Me.lblCategoryValue.Text = "General application exception"
            Me.lblCategoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblImpact
            '
            Me.lblImpact.BackColor = System.Drawing.Color.Transparent
            Me.lblImpact.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblImpact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.lblImpact.Location = New System.Drawing.Point(18, 82)
            Me.lblImpact.Name = "lblImpact"
            Me.lblImpact.Size = New System.Drawing.Size(78, 19)
            Me.lblImpact.TabIndex = 3
            Me.lblImpact.Text = "Impact"
            Me.lblImpact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblImpactValue
            '
            Me.lblImpactValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblImpactValue.BackColor = System.Drawing.Color.Transparent
            Me.lblImpactValue.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblImpactValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblImpactValue.Location = New System.Drawing.Point(102, 82)
            Me.lblImpactValue.Name = "lblImpactValue"
            Me.lblImpactValue.Size = New System.Drawing.Size(652, 19)
            Me.lblImpactValue.TabIndex = 4
            Me.lblImpactValue.Text = "The current operation failed; KoTOR Tool may be able to continue."
            Me.lblImpactValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblNextStep
            '
            Me.lblNextStep.BackColor = System.Drawing.Color.Transparent
            Me.lblNextStep.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNextStep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.lblNextStep.Location = New System.Drawing.Point(18, 106)
            Me.lblNextStep.Name = "lblNextStep"
            Me.lblNextStep.Size = New System.Drawing.Size(78, 19)
            Me.lblNextStep.TabIndex = 5
            Me.lblNextStep.Text = "Next step"
            Me.lblNextStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblNextStepValue
            '
            Me.lblNextStepValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblNextStepValue.BackColor = System.Drawing.Color.Transparent
            Me.lblNextStepValue.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNextStepValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblNextStepValue.Location = New System.Drawing.Point(102, 106)
            Me.lblNextStepValue.Name = "lblNextStepValue"
            Me.lblNextStepValue.Size = New System.Drawing.Size(652, 19)
            Me.lblNextStepValue.TabIndex = 6
            Me.lblNextStepValue.Text = "Click OK to continue, Cancel to close, or JIT Debug to inspect live state."
            Me.lblNextStepValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSummaryAccent
            '
            Me.lblSummaryAccent.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.lblSummaryAccent.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblSummaryAccent.Location = New System.Drawing.Point(0, 0)
            Me.lblSummaryAccent.Name = "lblSummaryAccent"
            Me.lblSummaryAccent.Size = New System.Drawing.Size(4, 135)
            Me.lblSummaryAccent.TabIndex = 7
            '
            'lblTechnicalHeading
            '
            Me.lblTechnicalHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTechnicalHeading.BackColor = System.Drawing.Color.Transparent
            Me.lblTechnicalHeading.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTechnicalHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lblTechnicalHeading.Location = New System.Drawing.Point(22, 150)
            Me.lblTechnicalHeading.Name = "lblTechnicalHeading"
            Me.lblTechnicalHeading.Size = New System.Drawing.Size(774, 19)
            Me.lblTechnicalHeading.TabIndex = 1
            Me.lblTechnicalHeading.Text = "Technical details"
            Me.lblTechnicalHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbMsg
            '
            Me.tbMsg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tbMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbMsg.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbMsg.Location = New System.Drawing.Point(22, 174)
            Me.tbMsg.Multiline = True
            Me.tbMsg.Name = "tbMsg"
            Me.tbMsg.ReadOnly = True
            Me.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbMsg.Size = New System.Drawing.Size(774, 238)
            Me.tbMsg.TabIndex = 2
            Me.tbMsg.Text = resources.GetString("tbMsg.Text")
            '
            'lblSeparatorBottom
            '
            Me.lblSeparatorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblSeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorBottom.Location = New System.Drawing.Point(22, 414)
            Me.lblSeparatorBottom.Name = "lblSeparatorBottom"
            Me.lblSeparatorBottom.Size = New System.Drawing.Size(774, 2)
            Me.lblSeparatorBottom.TabIndex = 6
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.Button1)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnJitDebug)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 506)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(818, 52)
            Me.pnlFooter.TabIndex = 2
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
            Me.Button1.Location = New System.Drawing.Point(508, 13)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(84, 25)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "OK"
            Me.Button1.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New System.Drawing.Point(602, 13)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(84, 25)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnJitDebug
            '
            Me.btnJitDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnJitDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnJitDebug.DialogResult = System.Windows.Forms.DialogResult.Retry
            Me.btnJitDebug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnJitDebug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnJitDebug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnJitDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnJitDebug.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnJitDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnJitDebug.Location = New System.Drawing.Point(696, 13)
            Me.btnJitDebug.Name = "btnJitDebug"
            Me.btnJitDebug.Size = New System.Drawing.Size(100, 25)
            Me.btnJitDebug.TabIndex = 2
            Me.btnJitDebug.Text = "JIT Debug"
            Me.btnJitDebug.UseVisualStyleBackColor = False
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
            Me.pnlHeader.Size = New System.Drawing.Size(818, 76)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSeparatorTop
            '
            Me.lblSeparatorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSeparatorTop.Location = New System.Drawing.Point(0, 74)
            Me.lblSeparatorTop.Name = "lblSeparatorTop"
            Me.lblSeparatorTop.Size = New System.Drawing.Size(818, 2)
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
            Me.lblSubtitle.Size = New System.Drawing.Size(780, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "The application captured the failure and prepared a structured report."
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
            Me.lblTitle.Size = New System.Drawing.Size(780, 34)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Unhandled Error Detected"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmErrorMessage
            '
            Me.AcceptButton = Me.Button1
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(820, 560)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlRoot)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(820, 560)
            Me.Name = "frmErrorMessage"
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "An error has occurred"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlBody.PerformLayout()
            Me.pnlSummary.ResumeLayout(False)
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class

End Namespace
