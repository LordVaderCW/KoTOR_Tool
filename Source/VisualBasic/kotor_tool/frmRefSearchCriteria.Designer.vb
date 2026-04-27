Namespace kotor_tool
	' Token: 0x02000070 RID: 112
	Public Partial Class frmRefSearchCriteria
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000E4E RID: 3662 RVA: 0x0028D888 File Offset: 0x0028C888
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000E95 RID: 3733 RVA: 0x0028E168 File Offset: 0x0028D168
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.tbSearchString = New Global.System.Windows.Forms.TextBox()
            Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox2 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox3 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox4 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox5 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox6 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox7 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox8 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox11 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox12 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox13 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox16 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox18 = New Global.System.Windows.Forms.CheckBox()
            Me.btnSetAll = New Global.System.Windows.Forms.Button()
            Me.btnClearAll = New Global.System.Windows.Forms.Button()
            Me.rbtnSensitive = New Global.System.Windows.Forms.RadioButton()
            Me.rbtnInsensitive = New Global.System.Windows.Forms.RadioButton()
            Me.gboxFileTypes = New Global.System.Windows.Forms.GroupBox()
            Me.gboxGFF = New Global.System.Windows.Forms.GroupBox()
            Me.gboxScript = New Global.System.Windows.Forms.GroupBox()
            Me.CheckBox22 = New Global.System.Windows.Forms.CheckBox()
            Me.CheckBox23 = New Global.System.Windows.Forms.CheckBox()
            Me.gboxArchiveTypes = New Global.System.Windows.Forms.GroupBox()
            Me.chkbScripts = New Global.System.Windows.Forms.CheckBox()
            Me.chkbTemplates = New Global.System.Windows.Forms.CheckBox()
            Me.chkbRIMs = New Global.System.Windows.Forms.CheckBox()
            Me.chkbAllBifs = New Global.System.Windows.Forms.CheckBox()
            Me.gboxCaseSens = New Global.System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
            Me.rbSearchKotor1 = New Global.System.Windows.Forms.RadioButton()
            Me.rbSearchKotor2 = New Global.System.Windows.Forms.RadioButton()
            Me.gboxSearchString = New Global.System.Windows.Forms.GroupBox()
            Me.gboxFileTypes.SuspendLayout()
            Me.gboxGFF.SuspendLayout()
            Me.gboxScript.SuspendLayout()
            Me.gboxArchiveTypes.SuspendLayout()
            Me.gboxCaseSens.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.gboxSearchString.SuspendLayout()
            Me.SuspendLayout()
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.Enabled = False
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(172, 488)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 3
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(268, 488)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "Cancel"
            Dim tbSearchString As Global.System.Windows.Forms.Control = Me.tbSearchString
            point = New Global.System.Drawing.Point(16, 24)
            tbSearchString.Location = point
            Me.tbSearchString.Name = "tbSearchString"
            Dim tbSearchString2 As Global.System.Windows.Forms.Control = Me.tbSearchString
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(160, 20)
            tbSearchString2.Size = size
            Me.tbSearchString.TabIndex = 0
            Me.tbSearchString.Text = ""
            Me.CheckBox1.Checked = True
            Me.CheckBox1.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox1
            point = New Global.System.Drawing.Point(8, 24)
            checkBox.Location = point
            Me.CheckBox1.Name = "CheckBox1"
            Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox1
            size = New Global.System.Drawing.Size(48, 16)
            checkBox2.Size = size
            Me.CheckBox1.TabIndex = 0
            Me.CheckBox1.Text = "are"
            Me.CheckBox2.Checked = True
            Me.CheckBox2.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox3 As Global.System.Windows.Forms.Control = Me.CheckBox2
            point = New Global.System.Drawing.Point(8, 96)
            checkBox3.Location = point
            Me.CheckBox2.Name = "CheckBox2"
            Dim checkBox4 As Global.System.Windows.Forms.Control = Me.CheckBox2
            size = New Global.System.Drawing.Size(48, 16)
            checkBox4.Size = size
            Me.CheckBox2.TabIndex = 3
            Me.CheckBox2.Text = "dlg"
            Me.CheckBox3.Checked = True
            Me.CheckBox3.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox5 As Global.System.Windows.Forms.Control = Me.CheckBox3
            point = New Global.System.Drawing.Point(64, 24)
            checkBox5.Location = point
            Me.CheckBox3.Name = "CheckBox3"
            Dim checkBox6 As Global.System.Windows.Forms.Control = Me.CheckBox3
            size = New Global.System.Drawing.Size(48, 16)
            checkBox6.Size = size
            Me.CheckBox3.TabIndex = 4
            Me.CheckBox3.Text = "utc"
            Me.CheckBox4.Checked = True
            Me.CheckBox4.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox7 As Global.System.Windows.Forms.Control = Me.CheckBox4
            point = New Global.System.Drawing.Point(64, 48)
            checkBox7.Location = point
            Me.CheckBox4.Name = "CheckBox4"
            Dim checkBox8 As Global.System.Windows.Forms.Control = Me.CheckBox4
            size = New Global.System.Drawing.Size(48, 16)
            checkBox8.Size = size
            Me.CheckBox4.TabIndex = 5
            Me.CheckBox4.Text = "utd"
            Me.CheckBox5.Checked = True
            Me.CheckBox5.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox9 As Global.System.Windows.Forms.Control = Me.CheckBox5
            point = New Global.System.Drawing.Point(64, 96)
            checkBox9.Location = point
            Me.CheckBox5.Name = "CheckBox5"
            Dim checkBox10 As Global.System.Windows.Forms.Control = Me.CheckBox5
            size = New Global.System.Drawing.Size(48, 16)
            checkBox10.Size = size
            Me.CheckBox5.TabIndex = 7
            Me.CheckBox5.Text = "uti"
            Me.CheckBox6.Checked = True
            Me.CheckBox6.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox11 As Global.System.Windows.Forms.Control = Me.CheckBox6
            point = New Global.System.Drawing.Point(120, 24)
            checkBox11.Location = point
            Me.CheckBox6.Name = "CheckBox6"
            Dim checkBox12 As Global.System.Windows.Forms.Control = Me.CheckBox6
            size = New Global.System.Drawing.Size(48, 16)
            checkBox12.Size = size
            Me.CheckBox6.TabIndex = 8
            Me.CheckBox6.Text = "utm"
            Me.CheckBox7.Checked = True
            Me.CheckBox7.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox13 As Global.System.Windows.Forms.Control = Me.CheckBox7
            point = New Global.System.Drawing.Point(64, 72)
            checkBox13.Location = point
            Me.CheckBox7.Name = "CheckBox7"
            Dim checkBox14 As Global.System.Windows.Forms.Control = Me.CheckBox7
            size = New Global.System.Drawing.Size(48, 16)
            checkBox14.Size = size
            Me.CheckBox7.TabIndex = 6
            Me.CheckBox7.Text = "ute"
            Me.CheckBox8.Checked = True
            Me.CheckBox8.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox15 As Global.System.Windows.Forms.Control = Me.CheckBox8
            point = New Global.System.Drawing.Point(120, 96)
            checkBox15.Location = point
            Me.CheckBox8.Name = "CheckBox8"
            Dim checkBox16 As Global.System.Windows.Forms.Control = Me.CheckBox8
            size = New Global.System.Drawing.Size(48, 16)
            checkBox16.Size = size
            Me.CheckBox8.TabIndex = 11
            Me.CheckBox8.Text = "utt"
            Me.CheckBox11.Checked = True
            Me.CheckBox11.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox17 As Global.System.Windows.Forms.Control = Me.CheckBox11
            point = New Global.System.Drawing.Point(120, 48)
            checkBox17.Location = point
            Me.CheckBox11.Name = "CheckBox11"
            Dim checkBox18 As Global.System.Windows.Forms.Control = Me.CheckBox11
            size = New Global.System.Drawing.Size(48, 16)
            checkBox18.Size = size
            Me.CheckBox11.TabIndex = 9
            Me.CheckBox11.Text = "utp"
            Me.CheckBox12.Checked = True
            Me.CheckBox12.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox19 As Global.System.Windows.Forms.Control = Me.CheckBox12
            point = New Global.System.Drawing.Point(168, 24)
            checkBox19.Location = point
            Me.CheckBox12.Name = "CheckBox12"
            Dim checkBox20 As Global.System.Windows.Forms.Control = Me.CheckBox12
            size = New Global.System.Drawing.Size(48, 16)
            checkBox20.Size = size
            Me.CheckBox12.TabIndex = 12
            Me.CheckBox12.Text = "utw"
            Me.CheckBox13.Checked = True
            Me.CheckBox13.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox21 As Global.System.Windows.Forms.Control = Me.CheckBox13
            point = New Global.System.Drawing.Point(120, 72)
            checkBox21.Location = point
            Me.CheckBox13.Name = "CheckBox13"
            Dim checkBox22 As Global.System.Windows.Forms.Control = Me.CheckBox13
            size = New Global.System.Drawing.Size(48, 16)
            checkBox22.Size = size
            Me.CheckBox13.TabIndex = 10
            Me.CheckBox13.Text = "uts"
            Me.CheckBox16.Checked = True
            Me.CheckBox16.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox23 As Global.System.Windows.Forms.Control = Me.CheckBox16
            point = New Global.System.Drawing.Point(8, 72)
            checkBox23.Location = point
            Me.CheckBox16.Name = "CheckBox16"
            Dim checkBox24 As Global.System.Windows.Forms.Control = Me.CheckBox16
            size = New Global.System.Drawing.Size(48, 16)
            checkBox24.Size = size
            Me.CheckBox16.TabIndex = 2
            Me.CheckBox16.Text = "ifo"
            Me.CheckBox18.Checked = True
            Me.CheckBox18.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox25 As Global.System.Windows.Forms.Control = Me.CheckBox18
            point = New Global.System.Drawing.Point(8, 48)
            checkBox25.Location = point
            Me.CheckBox18.Name = "CheckBox18"
            Dim checkBox26 As Global.System.Windows.Forms.Control = Me.CheckBox18
            size = New Global.System.Drawing.Size(48, 16)
            checkBox26.Size = size
            Me.CheckBox18.TabIndex = 1
            Me.CheckBox18.Text = "git"
            Me.btnSetAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSetAll As Global.System.Windows.Forms.Control = Me.btnSetAll
            point = New Global.System.Drawing.Point(87, 168)
            btnSetAll.Location = point
            Me.btnSetAll.Name = "btnSetAll"
            Me.btnSetAll.TabIndex = 0
            Me.btnSetAll.Text = "Set All"
            Me.btnClearAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnClearAll As Global.System.Windows.Forms.Control = Me.btnClearAll
            point = New Global.System.Drawing.Point(191, 168)
            btnClearAll.Location = point
            Me.btnClearAll.Name = "btnClearAll"
            Me.btnClearAll.TabIndex = 1
            Me.btnClearAll.Text = "Clear All"
            Dim rbtnSensitive As Global.System.Windows.Forms.Control = Me.rbtnSensitive
            point = New Global.System.Drawing.Point(24, 14)
            rbtnSensitive.Location = point
            Me.rbtnSensitive.Name = "rbtnSensitive"
            Dim rbtnSensitive2 As Global.System.Windows.Forms.Control = Me.rbtnSensitive
            size = New Global.System.Drawing.Size(88, 20)
            rbtnSensitive2.Size = size
            Me.rbtnSensitive.TabIndex = 1
            Me.rbtnSensitive.Text = "Sensitive"
            Me.rbtnInsensitive.Checked = True
            Dim rbtnInsensitive As Global.System.Windows.Forms.Control = Me.rbtnInsensitive
            point = New Global.System.Drawing.Point(24, 38)
            rbtnInsensitive.Location = point
            Me.rbtnInsensitive.Name = "rbtnInsensitive"
            Dim rbtnInsensitive2 As Global.System.Windows.Forms.Control = Me.rbtnInsensitive
            size = New Global.System.Drawing.Size(88, 20)
            rbtnInsensitive2.Size = size
            Me.rbtnInsensitive.TabIndex = 2
            Me.rbtnInsensitive.TabStop = True
            Me.rbtnInsensitive.Text = "Insensitive"
            Me.gboxFileTypes.Controls.Add(Me.btnSetAll)
            Me.gboxFileTypes.Controls.Add(Me.btnClearAll)
            Me.gboxFileTypes.Controls.Add(Me.gboxGFF)
            Me.gboxFileTypes.Controls.Add(Me.gboxScript)
            Me.gboxFileTypes.Enabled = False
            Dim gboxFileTypes As Global.System.Windows.Forms.Control = Me.gboxFileTypes
            point = New Global.System.Drawing.Point(12, 272)
            gboxFileTypes.Location = point
            Me.gboxFileTypes.Name = "gboxFileTypes"
            Dim gboxFileTypes2 As Global.System.Windows.Forms.Control = Me.gboxFileTypes
            size = New Global.System.Drawing.Size(332, 208)
            gboxFileTypes2.Size = size
            Me.gboxFileTypes.TabIndex = 22
            Me.gboxFileTypes.TabStop = False
            Me.gboxFileTypes.Text = "File types to search in"
            Me.gboxGFF.Controls.Add(Me.CheckBox2)
            Me.gboxGFF.Controls.Add(Me.CheckBox3)
            Me.gboxGFF.Controls.Add(Me.CheckBox4)
            Me.gboxGFF.Controls.Add(Me.CheckBox5)
            Me.gboxGFF.Controls.Add(Me.CheckBox6)
            Me.gboxGFF.Controls.Add(Me.CheckBox7)
            Me.gboxGFF.Controls.Add(Me.CheckBox8)
            Me.gboxGFF.Controls.Add(Me.CheckBox11)
            Me.gboxGFF.Controls.Add(Me.CheckBox13)
            Me.gboxGFF.Controls.Add(Me.CheckBox16)
            Me.gboxGFF.Controls.Add(Me.CheckBox18)
            Me.gboxGFF.Controls.Add(Me.CheckBox1)
            Me.gboxGFF.Controls.Add(Me.CheckBox12)
            Dim gboxGFF As Global.System.Windows.Forms.Control = Me.gboxGFF
            point = New Global.System.Drawing.Point(16, 32)
            gboxGFF.Location = point
            Me.gboxGFF.Name = "gboxGFF"
            Dim gboxGFF2 As Global.System.Windows.Forms.Control = Me.gboxGFF
            size = New Global.System.Drawing.Size(224, 128)
            gboxGFF2.Size = size
            Me.gboxGFF.TabIndex = 24
            Me.gboxGFF.TabStop = False
            Me.gboxGFF.Text = "GFF-based files"
            Me.gboxScript.Controls.Add(Me.CheckBox22)
            Me.gboxScript.Controls.Add(Me.CheckBox23)
            Dim gboxScript As Global.System.Windows.Forms.Control = Me.gboxScript
            point = New Global.System.Drawing.Point(248, 32)
            gboxScript.Location = point
            Me.gboxScript.Name = "gboxScript"
            Dim gboxScript2 As Global.System.Windows.Forms.Control = Me.gboxScript
            size = New Global.System.Drawing.Size(72, 88)
            gboxScript2.Size = size
            Me.gboxScript.TabIndex = 24
            Me.gboxScript.TabStop = False
            Me.gboxScript.Text = "Scripts"
            Me.CheckBox22.Checked = True
            Me.CheckBox22.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox27 As Global.System.Windows.Forms.Control = Me.CheckBox22
            point = New Global.System.Drawing.Point(16, 32)
            checkBox27.Location = point
            Me.CheckBox22.Name = "CheckBox22"
            Dim checkBox28 As Global.System.Windows.Forms.Control = Me.CheckBox22
            size = New Global.System.Drawing.Size(48, 16)
            checkBox28.Size = size
            Me.CheckBox22.TabIndex = 0
            Me.CheckBox22.Text = "ncs"
            Me.CheckBox23.Checked = True
            Me.CheckBox23.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim checkBox29 As Global.System.Windows.Forms.Control = Me.CheckBox23
            point = New Global.System.Drawing.Point(16, 56)
            checkBox29.Location = point
            Me.CheckBox23.Name = "CheckBox23"
            Dim checkBox30 As Global.System.Windows.Forms.Control = Me.CheckBox23
            size = New Global.System.Drawing.Size(48, 16)
            checkBox30.Size = size
            Me.CheckBox23.TabIndex = 1
            Me.CheckBox23.Text = "nss"
            Me.gboxArchiveTypes.Controls.Add(Me.chkbScripts)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbTemplates)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbRIMs)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbAllBifs)
            Me.gboxArchiveTypes.Enabled = False
            Dim gboxArchiveTypes As Global.System.Windows.Forms.Control = Me.gboxArchiveTypes
            point = New Global.System.Drawing.Point(16, 160)
            gboxArchiveTypes.Location = point
            Me.gboxArchiveTypes.Name = "gboxArchiveTypes"
            Dim gboxArchiveTypes2 As Global.System.Windows.Forms.Control = Me.gboxArchiveTypes
            size = New Global.System.Drawing.Size(328, 96)
            gboxArchiveTypes2.Size = size
            Me.gboxArchiveTypes.TabIndex = 23
            Me.gboxArchiveTypes.TabStop = False
            Me.gboxArchiveTypes.Text = "Archive  types to search in"
            Me.chkbScripts.Checked = True
            Me.chkbScripts.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbScripts As Global.System.Windows.Forms.Control = Me.chkbScripts
            point = New Global.System.Drawing.Point(80, 64)
            chkbScripts.Location = point
            Me.chkbScripts.Name = "chkbScripts"
            Dim chkbScripts2 As Global.System.Windows.Forms.Control = Me.chkbScripts
            size = New Global.System.Drawing.Size(80, 24)
            chkbScripts2.Size = size
            Me.chkbScripts.TabIndex = 2
            Me.chkbScripts.Text = "Scripts.bif"
            Me.chkbTemplates.Checked = True
            Me.chkbTemplates.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbTemplates As Global.System.Windows.Forms.Control = Me.chkbTemplates
            point = New Global.System.Drawing.Point(80, 40)
            chkbTemplates.Location = point
            Me.chkbTemplates.Name = "chkbTemplates"
            Dim chkbTemplates2 As Global.System.Windows.Forms.Control = Me.chkbTemplates
            size = New Global.System.Drawing.Size(96, 24)
            chkbTemplates2.Size = size
            Me.chkbTemplates.TabIndex = 1
            Me.chkbTemplates.Text = "Templates.bif"
            Me.chkbRIMs.Checked = True
            Me.chkbRIMs.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbRIMs As Global.System.Windows.Forms.Control = Me.chkbRIMs
            point = New Global.System.Drawing.Point(224, 16)
            chkbRIMs.Location = point
            Me.chkbRIMs.Name = "chkbRIMs"
            Dim chkbRIMs2 As Global.System.Windows.Forms.Control = Me.chkbRIMs
            size = New Global.System.Drawing.Size(64, 24)
            chkbRIMs2.Size = size
            Me.chkbRIMs.TabIndex = 3
            Me.chkbRIMs.Text = "RIMs"
            Me.chkbAllBifs.Checked = True
            Me.chkbAllBifs.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbAllBifs As Global.System.Windows.Forms.Control = Me.chkbAllBifs
            point = New Global.System.Drawing.Point(64, 16)
            chkbAllBifs.Location = point
            Me.chkbAllBifs.Name = "chkbAllBifs"
            Dim chkbAllBifs2 As Global.System.Windows.Forms.Control = Me.chkbAllBifs
            size = New Global.System.Drawing.Size(64, 24)
            chkbAllBifs2.Size = size
            Me.chkbAllBifs.TabIndex = 0
            Me.chkbAllBifs.Text = "All BIFs"
            Me.gboxCaseSens.Controls.Add(Me.rbtnSensitive)
            Me.gboxCaseSens.Controls.Add(Me.rbtnInsensitive)
            Me.gboxCaseSens.Enabled = False
            Dim gboxCaseSens As Global.System.Windows.Forms.Control = Me.gboxCaseSens
            point = New Global.System.Drawing.Point(224, 88)
            gboxCaseSens.Location = point
            Me.gboxCaseSens.Name = "gboxCaseSens"
            Dim gboxCaseSens2 As Global.System.Windows.Forms.Control = Me.gboxCaseSens
            size = New Global.System.Drawing.Size(120, 64)
            gboxCaseSens2.Size = size
            Me.gboxCaseSens.TabIndex = 24
            Me.gboxCaseSens.TabStop = False
            Me.gboxCaseSens.Text = "Case"
            Me.GroupBox2.Controls.Add(Me.rbSearchKotor1)
            Me.GroupBox2.Controls.Add(Me.rbSearchKotor2)
            Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
            point = New Global.System.Drawing.Point(120, 8)
            groupBox.Location = point
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
            size = New Global.System.Drawing.Size(104, 64)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 25
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search within"
            Dim rbSearchKotor As Global.System.Windows.Forms.Control = Me.rbSearchKotor1
            point = New Global.System.Drawing.Point(24, 16)
            rbSearchKotor.Location = point
            Me.rbSearchKotor1.Name = "rbSearchKotor1"
            Dim rbSearchKotor2 As Global.System.Windows.Forms.Control = Me.rbSearchKotor1
            size = New Global.System.Drawing.Size(72, 20)
            rbSearchKotor2.Size = size
            Me.rbSearchKotor1.TabIndex = 0
            Me.rbSearchKotor1.Text = "KotOR I"
            Dim rbSearchKotor3 As Global.System.Windows.Forms.Control = Me.rbSearchKotor2
            point = New Global.System.Drawing.Point(24, 40)
            rbSearchKotor3.Location = point
            Me.rbSearchKotor2.Name = "rbSearchKotor2"
            Dim rbSearchKotor4 As Global.System.Windows.Forms.Control = Me.rbSearchKotor2
            size = New Global.System.Drawing.Size(72, 20)
            rbSearchKotor4.Size = size
            Me.rbSearchKotor2.TabIndex = 0
            Me.rbSearchKotor2.Text = "KotOR II"
            Me.gboxSearchString.Controls.Add(Me.tbSearchString)
            Me.gboxSearchString.Enabled = False
            Dim gboxSearchString As Global.System.Windows.Forms.Control = Me.gboxSearchString
            point = New Global.System.Drawing.Point(16, 88)
            gboxSearchString.Location = point
            Me.gboxSearchString.Name = "gboxSearchString"
            Dim gboxSearchString2 As Global.System.Windows.Forms.Control = Me.gboxSearchString
            size = New Global.System.Drawing.Size(192, 64)
            gboxSearchString2.Size = size
            Me.gboxSearchString.TabIndex = 26
            Me.gboxSearchString.TabStop = False
            Me.gboxSearchString.Text = "String to search for"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(360, 525)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.gboxSearchString)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.gboxCaseSens)
            Me.Controls.Add(Me.gboxArchiveTypes)
            Me.Controls.Add(Me.gboxFileTypes)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.MaximizeBox = False
            size = New Global.System.Drawing.Size(344, 376)
            Me.MinimumSize = size
            Me.Name = "frmRefSearchCriteria"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Search Criteria"
            Me.gboxFileTypes.ResumeLayout(False)
            Me.gboxGFF.ResumeLayout(False)
            Me.gboxScript.ResumeLayout(False)
            Me.gboxArchiveTypes.ResumeLayout(False)
            Me.gboxCaseSens.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.gboxSearchString.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x0400071C RID: 1820
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
