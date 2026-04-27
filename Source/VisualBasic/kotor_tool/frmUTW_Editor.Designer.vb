Namespace kotor_tool
	' Token: 0x02000085 RID: 133
	Public Partial Class frmUTW_Editor
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
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


		' Token: 0x060016D6 RID: 5846 RVA: 0x002C9D80 File Offset: 0x002C8D80
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060016FF RID: 5887 RVA: 0x002CA240 File Offset: 0x002C9240
		<Global.System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.btnSetNameLang = New Global.System.Windows.Forms.Button()
			Me.btnDebug = New Global.System.Windows.Forms.Button()
			Me.tbName = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.tbTemplateResRef = New Global.System.Windows.Forms.TextBox()
			Me.Label57 = New Global.System.Windows.Forms.Label()
			Me.tbTag = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.tbComment = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.chkbHasMapNote = New Global.System.Windows.Forms.CheckBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.tbWPLinkedTo = New Global.System.Windows.Forms.TextBox()
			Me.tbWpDescription = New Global.System.Windows.Forms.TextBox()
			Me.tbWpMapNote = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.chkbMapNoteEnabled = New Global.System.Windows.Forms.CheckBox()
			Me.SuspendLayout()
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnSave.Location = New Global.System.Drawing.Point(288, 416)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.TabIndex = 5
			Me.btnSave.Text = "&Save"
			Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New Global.System.Drawing.Point(384, 416)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.TabIndex = 6
			Me.btnCancel.Text = "&Cancel"
			Me.btnSetNameLang.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.btnSetNameLang.Location = New Global.System.Drawing.Point(40, 416)
			Me.btnSetNameLang.Name = "btnSetNameLang"
			Me.btnSetNameLang.Size = New Global.System.Drawing.Size(88, 23)
			Me.btnSetNameLang.TabIndex = 7
			Me.btnSetNameLang.Text = "Set Language"
			Me.btnDebug.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
			Me.btnDebug.Location = New Global.System.Drawing.Point(0, 88)
			Me.btnDebug.Name = "btnDebug"
			Me.btnDebug.Size = New Global.System.Drawing.Size(8, 8)
			Me.btnDebug.TabIndex = 18
			Me.btnDebug.TabStop = False
			Me.tbName.Location = New Global.System.Drawing.Point(168, 56)
			Me.tbName.Name = "tbName"
			Me.tbName.Size = New Global.System.Drawing.Size(176, 20)
			Me.tbName.TabIndex = 19
			Me.tbName.Text = ""
			Me.Label11.Location = New Global.System.Drawing.Point(56, 56)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(100, 16)
			Me.Label11.TabIndex = 20
			Me.Label11.Text = "Name"
			Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
			Me.tbTemplateResRef.Location = New Global.System.Drawing.Point(168, 24)
			Me.tbTemplateResRef.MaxLength = 16
			Me.tbTemplateResRef.Name = "tbTemplateResRef"
			Me.tbTemplateResRef.Size = New Global.System.Drawing.Size(176, 20)
			Me.tbTemplateResRef.TabIndex = 22
			Me.tbTemplateResRef.Text = ""
			Me.Label57.Location = New Global.System.Drawing.Point(56, 24)
			Me.Label57.Name = "Label57"
			Me.Label57.Size = New Global.System.Drawing.Size(100, 18)
			Me.Label57.TabIndex = 21
			Me.Label57.Text = "Template ResRef"
			Me.Label57.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbTag.Location = New Global.System.Drawing.Point(168, 88)
			Me.tbTag.Name = "tbTag"
			Me.tbTag.Size = New Global.System.Drawing.Size(176, 20)
			Me.tbTag.TabIndex = 24
			Me.tbTag.Text = ""
			Me.Label2.Location = New Global.System.Drawing.Point(56, 88)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(100, 16)
			Me.Label2.TabIndex = 23
			Me.Label2.Text = "Tag"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbComment.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.tbComment.Location = New Global.System.Drawing.Point(168, 336)
			Me.tbComment.Multiline = True
			Me.tbComment.Name = "tbComment"
			Me.tbComment.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.tbComment.Size = New Global.System.Drawing.Size(296, 48)
			Me.tbComment.TabIndex = 25
			Me.tbComment.Text = ""
			Me.Label1.Location = New Global.System.Drawing.Point(56, 344)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(88, 16)
			Me.Label1.TabIndex = 23
			Me.Label1.Text = "Comment"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.chkbHasMapNote.Location = New Global.System.Drawing.Point(168, 224)
			Me.chkbHasMapNote.Name = "chkbHasMapNote"
			Me.chkbHasMapNote.Size = New Global.System.Drawing.Size(192, 24)
			Me.chkbHasMapNote.TabIndex = 33
			Me.chkbHasMapNote.Text = "Waypoint Contains a Map Note"
			Me.Label9.Location = New Global.System.Drawing.Point(56, 120)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(100, 16)
			Me.Label9.TabIndex = 31
			Me.Label9.Text = "Linked To"
			Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbWPLinkedTo.Location = New Global.System.Drawing.Point(168, 120)
			Me.tbWPLinkedTo.Name = "tbWPLinkedTo"
			Me.tbWPLinkedTo.Size = New Global.System.Drawing.Size(208, 20)
			Me.tbWPLinkedTo.TabIndex = 28
			Me.tbWPLinkedTo.Text = ""
			Me.tbWpDescription.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.tbWpDescription.Location = New Global.System.Drawing.Point(168, 160)
			Me.tbWpDescription.Multiline = True
			Me.tbWpDescription.Name = "tbWpDescription"
			Me.tbWpDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.tbWpDescription.Size = New Global.System.Drawing.Size(296, 48)
			Me.tbWpDescription.TabIndex = 26
			Me.tbWpDescription.Text = ""
			Me.tbWpMapNote.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.tbWpMapNote.Location = New Global.System.Drawing.Point(168, 264)
			Me.tbWpMapNote.Multiline = True
			Me.tbWpMapNote.Name = "tbWpMapNote"
			Me.tbWpMapNote.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.tbWpMapNote.Size = New Global.System.Drawing.Size(296, 48)
			Me.tbWpMapNote.TabIndex = 27
			Me.tbWpMapNote.Text = ""
			Me.Label3.Location = New Global.System.Drawing.Point(56, 160)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(100, 16)
			Me.Label3.TabIndex = 29
			Me.Label3.Text = "Description"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label12.Location = New Global.System.Drawing.Point(56, 264)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(80, 16)
			Me.Label12.TabIndex = 30
			Me.Label12.Text = "Map Note"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.chkbMapNoteEnabled.Location = New Global.System.Drawing.Point(360, 224)
			Me.chkbMapNoteEnabled.Name = "chkbMapNoteEnabled"
			Me.chkbMapNoteEnabled.Size = New Global.System.Drawing.Size(128, 24)
			Me.chkbMapNoteEnabled.TabIndex = 32
			Me.chkbMapNoteEnabled.Text = "Map Note Enabled"
			Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
			Me.ClientSize = New Global.System.Drawing.Size(488, 461)
			Me.Controls.Add(Me.chkbHasMapNote)
			Me.Controls.Add(Me.Label9)
			Me.Controls.Add(Me.tbWPLinkedTo)
			Me.Controls.Add(Me.tbWpDescription)
			Me.Controls.Add(Me.tbWpMapNote)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label12)
			Me.Controls.Add(Me.chkbMapNoteEnabled)
			Me.Controls.Add(Me.tbComment)
			Me.Controls.Add(Me.tbTag)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.tbTemplateResRef)
			Me.Controls.Add(Me.Label57)
			Me.Controls.Add(Me.tbName)
			Me.Controls.Add(Me.Label11)
			Me.Controls.Add(Me.btnDebug)
			Me.Controls.Add(Me.btnSetNameLang)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.Label1)
			Me.MinimumSize = New Global.System.Drawing.Size(496, 488)
			Me.Name = "frmUTW_Editor"
			Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
			Me.Text = "Waypoint Editor"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnSave.Click, AddressOf Me.btnSave_Click
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            AddHandler Me.btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
            AddHandler Me.btnDebug.Click, AddressOf Me.btnDebug_Click
			Me.ResumeLayout(False)
		End Sub

	End Class
End Namespace
