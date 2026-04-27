Namespace kotor_tool
	' Token: 0x02000085 RID: 133
	Public Partial Class frmUTW_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x060016D6 RID: 5846 RVA: 0x002C9D80 File Offset: 0x002C8D80
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060016FF RID: 5887 RVA: 0x002CA240 File Offset: 0x002C9240
		<Global.System.Diagnostics.DebuggerStepThrough()>
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
			Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(288, 416)
			btnSave.Location = point
			Me.btnSave.Name = "btnSave"
			Me.btnSave.TabIndex = 5
			Me.btnSave.Text = "&Save"
			Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			point = New Global.System.Drawing.Point(384, 416)
			btnCancel.Location = point
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.TabIndex = 6
			Me.btnCancel.Text = "&Cancel"
			Me.btnSetNameLang.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Dim btnSetNameLang As Global.System.Windows.Forms.Control = Me.btnSetNameLang
			point = New Global.System.Drawing.Point(40, 416)
			btnSetNameLang.Location = point
			Me.btnSetNameLang.Name = "btnSetNameLang"
			Dim btnSetNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetNameLang
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(88, 23)
			btnSetNameLang2.Size = size
			Me.btnSetNameLang.TabIndex = 7
			Me.btnSetNameLang.Text = "Set Language"
			Me.btnDebug.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.btnDebug.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnDebug.ForeColor = Global.System.Drawing.SystemColors.Control
			Dim btnDebug As Global.System.Windows.Forms.Control = Me.btnDebug
			point = New Global.System.Drawing.Point(0, 88)
			btnDebug.Location = point
			Me.btnDebug.Name = "btnDebug"
			Dim btnDebug2 As Global.System.Windows.Forms.Control = Me.btnDebug
			size = New Global.System.Drawing.Size(8, 8)
			btnDebug2.Size = size
			Me.btnDebug.TabIndex = 18
			Me.btnDebug.TabStop = False
			Dim tbName As Global.System.Windows.Forms.Control = Me.tbName
			point = New Global.System.Drawing.Point(168, 56)
			tbName.Location = point
			Me.tbName.Name = "tbName"
			Dim tbName2 As Global.System.Windows.Forms.Control = Me.tbName
			size = New Global.System.Drawing.Size(176, 20)
			tbName2.Size = size
			Me.tbName.TabIndex = 19
			Me.tbName.Text = ""
			Dim label As Global.System.Windows.Forms.Control = Me.Label11
			point = New Global.System.Drawing.Point(56, 56)
			label.Location = point
			Me.Label11.Name = "Label11"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(100, 16)
			label2.Size = size
			Me.Label11.TabIndex = 20
			Me.Label11.Text = "Name"
			Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbTemplateResRef.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
			Dim tbTemplateResRef As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
			point = New Global.System.Drawing.Point(168, 24)
			tbTemplateResRef.Location = point
			Me.tbTemplateResRef.MaxLength = 16
			Me.tbTemplateResRef.Name = "tbTemplateResRef"
			Dim tbTemplateResRef2 As Global.System.Windows.Forms.Control = Me.tbTemplateResRef
			size = New Global.System.Drawing.Size(176, 20)
			tbTemplateResRef2.Size = size
			Me.tbTemplateResRef.TabIndex = 22
			Me.tbTemplateResRef.Text = ""
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label57
			point = New Global.System.Drawing.Point(56, 24)
			label3.Location = point
			Me.Label57.Name = "Label57"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label57
			size = New Global.System.Drawing.Size(100, 18)
			label4.Size = size
			Me.Label57.TabIndex = 21
			Me.Label57.Text = "Template ResRef"
			Me.Label57.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
			point = New Global.System.Drawing.Point(168, 88)
			tbTag.Location = point
			Me.tbTag.Name = "tbTag"
			Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
			size = New Global.System.Drawing.Size(176, 20)
			tbTag2.Size = size
			Me.tbTag.TabIndex = 24
			Me.tbTag.Text = ""
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(56, 88)
			label5.Location = point
			Me.Label2.Name = "Label2"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(100, 16)
			label6.Size = size
			Me.Label2.TabIndex = 23
			Me.Label2.Text = "Tag"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tbComment.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim tbComment As Global.System.Windows.Forms.Control = Me.tbComment
			point = New Global.System.Drawing.Point(168, 336)
			tbComment.Location = point
			Me.tbComment.Multiline = True
			Me.tbComment.Name = "tbComment"
			Me.tbComment.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Dim tbComment2 As Global.System.Windows.Forms.Control = Me.tbComment
			size = New Global.System.Drawing.Size(296, 48)
			tbComment2.Size = size
			Me.tbComment.TabIndex = 25
			Me.tbComment.Text = ""
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(56, 344)
			label7.Location = point
			Me.Label1.Name = "Label1"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(88, 16)
			label8.Size = size
			Me.Label1.TabIndex = 23
			Me.Label1.Text = "Comment"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim chkbHasMapNote As Global.System.Windows.Forms.Control = Me.chkbHasMapNote
			point = New Global.System.Drawing.Point(168, 224)
			chkbHasMapNote.Location = point
			Me.chkbHasMapNote.Name = "chkbHasMapNote"
			Dim chkbHasMapNote2 As Global.System.Windows.Forms.Control = Me.chkbHasMapNote
			size = New Global.System.Drawing.Size(192, 24)
			chkbHasMapNote2.Size = size
			Me.chkbHasMapNote.TabIndex = 33
			Me.chkbHasMapNote.Text = "Waypoint Contains a Map Note"
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(56, 120)
			label9.Location = point
			Me.Label9.Name = "Label9"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(100, 16)
			label10.Size = size
			Me.Label9.TabIndex = 31
			Me.Label9.Text = "Linked To"
			Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim tbWPLinkedTo As Global.System.Windows.Forms.Control = Me.tbWPLinkedTo
			point = New Global.System.Drawing.Point(168, 120)
			tbWPLinkedTo.Location = point
			Me.tbWPLinkedTo.Name = "tbWPLinkedTo"
			Dim tbWPLinkedTo2 As Global.System.Windows.Forms.Control = Me.tbWPLinkedTo
			size = New Global.System.Drawing.Size(208, 20)
			tbWPLinkedTo2.Size = size
			Me.tbWPLinkedTo.TabIndex = 28
			Me.tbWPLinkedTo.Text = ""
			Me.tbWpDescription.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim tbWpDescription As Global.System.Windows.Forms.Control = Me.tbWpDescription
			point = New Global.System.Drawing.Point(168, 160)
			tbWpDescription.Location = point
			Me.tbWpDescription.Multiline = True
			Me.tbWpDescription.Name = "tbWpDescription"
			Me.tbWpDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Dim tbWpDescription2 As Global.System.Windows.Forms.Control = Me.tbWpDescription
			size = New Global.System.Drawing.Size(296, 48)
			tbWpDescription2.Size = size
			Me.tbWpDescription.TabIndex = 26
			Me.tbWpDescription.Text = ""
			Me.tbWpMapNote.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim tbWpMapNote As Global.System.Windows.Forms.Control = Me.tbWpMapNote
			point = New Global.System.Drawing.Point(168, 264)
			tbWpMapNote.Location = point
			Me.tbWpMapNote.Multiline = True
			Me.tbWpMapNote.Name = "tbWpMapNote"
			Me.tbWpMapNote.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Dim tbWpMapNote2 As Global.System.Windows.Forms.Control = Me.tbWpMapNote
			size = New Global.System.Drawing.Size(296, 48)
			tbWpMapNote2.Size = size
			Me.tbWpMapNote.TabIndex = 27
			Me.tbWpMapNote.Text = ""
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(56, 160)
			label11.Location = point
			Me.Label3.Name = "Label3"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(100, 16)
			label12.Size = size
			Me.Label3.TabIndex = 29
			Me.Label3.Text = "Description"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label12
			point = New Global.System.Drawing.Point(56, 264)
			label13.Location = point
			Me.Label12.Name = "Label12"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label12
			size = New Global.System.Drawing.Size(80, 16)
			label14.Size = size
			Me.Label12.TabIndex = 30
			Me.Label12.Text = "Map Note"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim chkbMapNoteEnabled As Global.System.Windows.Forms.Control = Me.chkbMapNoteEnabled
			point = New Global.System.Drawing.Point(360, 224)
			chkbMapNoteEnabled.Location = point
			Me.chkbMapNoteEnabled.Name = "chkbMapNoteEnabled"
			Dim chkbMapNoteEnabled2 As Global.System.Windows.Forms.Control = Me.chkbMapNoteEnabled
			size = New Global.System.Drawing.Size(128, 24)
			chkbMapNoteEnabled2.Size = size
			Me.chkbMapNoteEnabled.TabIndex = 32
			Me.chkbMapNoteEnabled.Text = "Map Note Enabled"
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(488, 461)
			Me.ClientSize = size
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
			size = New Global.System.Drawing.Size(496, 488)
			Me.MinimumSize = size
			Me.Name = "frmUTW_Editor"
			Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
			Me.Text = "Waypoint Editor"
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000B27 RID: 2855
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
