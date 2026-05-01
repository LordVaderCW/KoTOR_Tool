Option Strict Off
Option Explicit On

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmUTW_Editor
        Inherits Global.kotor_tool.frmParent

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderRule As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterRule As Global.System.Windows.Forms.Label

        Friend WithEvents btnSave As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnSetNameLang As Global.System.Windows.Forms.Button
        Friend WithEvents btnDebug As Global.System.Windows.Forms.Button
        Friend WithEvents tbName As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents tbTemplateResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label57 As Global.System.Windows.Forms.Label
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents tbComment As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbHasMapNote As Global.System.Windows.Forms.CheckBox
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents tbWPLinkedTo As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbWpDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbWpMapNote As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbMapNoteEnabled As Global.System.Windows.Forms.CheckBox

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
            Me.chkbHasMapNote = New System.Windows.Forms.CheckBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.tbWPLinkedTo = New System.Windows.Forms.TextBox()
            Me.tbWpDescription = New System.Windows.Forms.TextBox()
            Me.tbWpMapNote = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.chkbMapNoteEnabled = New System.Windows.Forms.CheckBox()
            Me.tbComment = New System.Windows.Forms.TextBox()
            Me.tbTag = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.tbTemplateResRef = New System.Windows.Forms.TextBox()
            Me.Label57 = New System.Windows.Forms.Label()
            Me.tbName = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterRule = New System.Windows.Forms.Label()
            Me.btnSetNameLang = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnDebug = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderRule = New System.Windows.Forms.Label()
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
            Me.pnlRoot.Size = New System.Drawing.Size(520, 588)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.chkbHasMapNote)
            Me.pnlBody.Controls.Add(Me.Label9)
            Me.pnlBody.Controls.Add(Me.tbWPLinkedTo)
            Me.pnlBody.Controls.Add(Me.tbWpDescription)
            Me.pnlBody.Controls.Add(Me.tbWpMapNote)
            Me.pnlBody.Controls.Add(Me.Label3)
            Me.pnlBody.Controls.Add(Me.Label12)
            Me.pnlBody.Controls.Add(Me.chkbMapNoteEnabled)
            Me.pnlBody.Controls.Add(Me.tbComment)
            Me.pnlBody.Controls.Add(Me.tbTag)
            Me.pnlBody.Controls.Add(Me.Label2)
            Me.pnlBody.Controls.Add(Me.tbTemplateResRef)
            Me.pnlBody.Controls.Add(Me.Label57)
            Me.pnlBody.Controls.Add(Me.tbName)
            Me.pnlBody.Controls.Add(Me.Label11)
            Me.pnlBody.Controls.Add(Me.Label1)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 67)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Size = New System.Drawing.Size(520, 459)
            Me.pnlBody.TabIndex = 1
            '
            'chkbHasMapNote
            '
            Me.chkbHasMapNote.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbHasMapNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbHasMapNote.Location = New System.Drawing.Point(168, 258)
            Me.chkbHasMapNote.Name = "chkbHasMapNote"
            Me.chkbHasMapNote.Size = New System.Drawing.Size(192, 28)
            Me.chkbHasMapNote.TabIndex = 33
            Me.chkbHasMapNote.Text = "Waypoint Contains a Map Note"
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(56, 138)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(100, 19)
            Me.Label9.TabIndex = 31
            Me.Label9.Text = "Linked To"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbWPLinkedTo
            '
            Me.tbWPLinkedTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbWPLinkedTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbWPLinkedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbWPLinkedTo.Location = New System.Drawing.Point(168, 138)
            Me.tbWPLinkedTo.Name = "tbWPLinkedTo"
            Me.tbWPLinkedTo.Size = New System.Drawing.Size(320, 22)
            Me.tbWPLinkedTo.TabIndex = 28
            '
            'tbWpDescription
            '
            Me.tbWpDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbWpDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbWpDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbWpDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbWpDescription.Location = New System.Drawing.Point(168, 185)
            Me.tbWpDescription.Multiline = True
            Me.tbWpDescription.Name = "tbWpDescription"
            Me.tbWpDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbWpDescription.Size = New System.Drawing.Size(320, 55)
            Me.tbWpDescription.TabIndex = 26
            '
            'tbWpMapNote
            '
            Me.tbWpMapNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbWpMapNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbWpMapNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbWpMapNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbWpMapNote.Location = New System.Drawing.Point(168, 305)
            Me.tbWpMapNote.Multiline = True
            Me.tbWpMapNote.Name = "tbWpMapNote"
            Me.tbWpMapNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbWpMapNote.Size = New System.Drawing.Size(320, 55)
            Me.tbWpMapNote.TabIndex = 27
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(56, 185)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(100, 18)
            Me.Label3.TabIndex = 29
            Me.Label3.Text = "Description"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label12
            '
            Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(56, 305)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(80, 18)
            Me.Label12.TabIndex = 30
            Me.Label12.Text = "Map Note"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbMapNoteEnabled
            '
            Me.chkbMapNoteEnabled.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkbMapNoteEnabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbMapNoteEnabled.Location = New System.Drawing.Point(360, 258)
            Me.chkbMapNoteEnabled.Name = "chkbMapNoteEnabled"
            Me.chkbMapNoteEnabled.Size = New System.Drawing.Size(128, 28)
            Me.chkbMapNoteEnabled.TabIndex = 32
            Me.chkbMapNoteEnabled.Text = "Map Note Enabled"
            '
            'tbComment
            '
            Me.tbComment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbComment.Location = New System.Drawing.Point(168, 388)
            Me.tbComment.Multiline = True
            Me.tbComment.Name = "tbComment"
            Me.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.tbComment.Size = New System.Drawing.Size(320, 55)
            Me.tbComment.TabIndex = 25
            '
            'tbTag
            '
            Me.tbTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTag.Location = New System.Drawing.Point(168, 102)
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(320, 22)
            Me.tbTag.TabIndex = 24
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(56, 102)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(100, 18)
            Me.Label2.TabIndex = 23
            Me.Label2.Text = "Tag"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbTemplateResRef
            '
            Me.tbTemplateResRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTemplateResRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTemplateResRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.tbTemplateResRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTemplateResRef.Location = New System.Drawing.Point(168, 28)
            Me.tbTemplateResRef.MaxLength = 16
            Me.tbTemplateResRef.Name = "tbTemplateResRef"
            Me.tbTemplateResRef.Size = New System.Drawing.Size(320, 22)
            Me.tbTemplateResRef.TabIndex = 22
            '
            'Label57
            '
            Me.Label57.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label57.Location = New System.Drawing.Point(56, 28)
            Me.Label57.Name = "Label57"
            Me.Label57.Size = New System.Drawing.Size(100, 20)
            Me.Label57.TabIndex = 21
            Me.Label57.Text = "Template ResRef"
            Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbName
            '
            Me.tbName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbName.Location = New System.Drawing.Point(168, 65)
            Me.tbName.Name = "tbName"
            Me.tbName.Size = New System.Drawing.Size(320, 22)
            Me.tbName.TabIndex = 19
            '
            'Label11
            '
            Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(56, 65)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(100, 18)
            Me.Label11.TabIndex = 20
            Me.Label11.Text = "Name"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(56, 397)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(88, 18)
            Me.Label1.TabIndex = 23
            Me.Label1.Text = "Comment"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterRule)
            Me.pnlFooter.Controls.Add(Me.btnSetNameLang)
            Me.pnlFooter.Controls.Add(Me.btnSave)
            Me.pnlFooter.Controls.Add(Me.btnCancel)
            Me.pnlFooter.Controls.Add(Me.btnDebug)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 526)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(520, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(520, 1)
            Me.lblFooterRule.TabIndex = 0
            '
            'btnSetNameLang
            '
            Me.btnSetNameLang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnSetNameLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSetNameLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetNameLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSetNameLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetNameLang.Location = New System.Drawing.Point(24, 18)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New System.Drawing.Size(104, 29)
            Me.btnSetNameLang.TabIndex = 7
            Me.btnSetNameLang.Text = "Set Language"
            Me.btnSetNameLang.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSave.Location = New System.Drawing.Point(324, 18)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(80, 29)
            Me.btnSave.TabIndex = 5
            Me.btnSave.Text = "&Save"
            Me.btnSave.UseVisualStyleBackColor = False
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
            Me.btnCancel.Location = New System.Drawing.Point(416, 18)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(80, 29)
            Me.btnCancel.TabIndex = 6
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnDebug
            '
            Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnDebug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnDebug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnDebug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnDebug.Location = New System.Drawing.Point(134, 18)
            Me.btnDebug.Name = "btnDebug"
            Me.btnDebug.Size = New System.Drawing.Size(104, 29)
            Me.btnDebug.TabIndex = 18
            Me.btnDebug.TabStop = False
            Me.btnDebug.Text = "Debug"
            Me.btnDebug.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderRule)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(520, 67)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(18, 12)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(360, 23)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Waypoint Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(20, 37)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(440, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Restored KoTOR Tool waypoint properties and map note data."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 65)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(520, 2)
            Me.lblHeaderRule.TabIndex = 2
            '
            'frmUTW_Editor
            '
            Me.AcceptButton = Me.btnSave
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(520, 588)
            Me.Controls.Add(Me.pnlRoot)
            Me.MinimumSize = New System.Drawing.Size(528, 608)
            Me.Name = "frmUTW_Editor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Waypoint Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.pnlBody.PerformLayout()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace