Namespace kotor_tool
	' Token: 0x02000070 RID: 112
	Public Partial Class frmRefSearchCriteria
		Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents tbSearchString As Global.System.Windows.Forms.TextBox
        Friend WithEvents CheckBox1 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox2 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox3 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox4 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox5 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox6 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox7 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox8 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox11 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox12 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox13 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox16 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox18 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnSetAll As Global.System.Windows.Forms.Button
        Friend WithEvents btnClearAll As Global.System.Windows.Forms.Button
        Friend WithEvents rbtnSensitive As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbtnInsensitive As Global.System.Windows.Forms.RadioButton
        Friend WithEvents gboxFileTypes As Global.System.Windows.Forms.GroupBox
        Friend WithEvents gboxArchiveTypes As Global.System.Windows.Forms.GroupBox
        Friend WithEvents chkbScripts As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbTemplates As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbRIMs As Global.System.Windows.Forms.CheckBox
        Friend WithEvents gboxGFF As Global.System.Windows.Forms.GroupBox
        Friend WithEvents CheckBox22 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox23 As Global.System.Windows.Forms.CheckBox
        Friend WithEvents gboxScript As Global.System.Windows.Forms.GroupBox
        Friend WithEvents chkbAllBifs As Global.System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox2 As Global.System.Windows.Forms.GroupBox
        Friend WithEvents rbSearchKotor1 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents rbSearchKotor2 As Global.System.Windows.Forms.RadioButton
        Friend WithEvents gboxCaseSens As Global.System.Windows.Forms.GroupBox
        Friend WithEvents gboxSearchString As Global.System.Windows.Forms.GroupBox


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
            Me.btnOK.Location = New Global.System.Drawing.Point(172, 488)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 3
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(268, 488)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "Cancel"
            Me.tbSearchString.Location = New Global.System.Drawing.Point(16, 24)
            Me.tbSearchString.Name = "tbSearchString"
            Me.tbSearchString.Size = New Global.System.Drawing.Size(160, 20)
            Me.tbSearchString.TabIndex = 0
            Me.tbSearchString.Text = ""
            Me.CheckBox1.Checked = True
            Me.CheckBox1.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox1.Location = New Global.System.Drawing.Point(8, 24)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox1.TabIndex = 0
            Me.CheckBox1.Text = "are"
            Me.CheckBox2.Checked = True
            Me.CheckBox2.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox2.Location = New Global.System.Drawing.Point(8, 96)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox2.TabIndex = 3
            Me.CheckBox2.Text = "dlg"
            Me.CheckBox3.Checked = True
            Me.CheckBox3.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox3.Location = New Global.System.Drawing.Point(64, 24)
            Me.CheckBox3.Name = "CheckBox3"
            Me.CheckBox3.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox3.TabIndex = 4
            Me.CheckBox3.Text = "utc"
            Me.CheckBox4.Checked = True
            Me.CheckBox4.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox4.Location = New Global.System.Drawing.Point(64, 48)
            Me.CheckBox4.Name = "CheckBox4"
            Me.CheckBox4.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox4.TabIndex = 5
            Me.CheckBox4.Text = "utd"
            Me.CheckBox5.Checked = True
            Me.CheckBox5.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox5.Location = New Global.System.Drawing.Point(64, 96)
            Me.CheckBox5.Name = "CheckBox5"
            Me.CheckBox5.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox5.TabIndex = 7
            Me.CheckBox5.Text = "uti"
            Me.CheckBox6.Checked = True
            Me.CheckBox6.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox6.Location = New Global.System.Drawing.Point(120, 24)
            Me.CheckBox6.Name = "CheckBox6"
            Me.CheckBox6.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox6.TabIndex = 8
            Me.CheckBox6.Text = "utm"
            Me.CheckBox7.Checked = True
            Me.CheckBox7.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox7.Location = New Global.System.Drawing.Point(64, 72)
            Me.CheckBox7.Name = "CheckBox7"
            Me.CheckBox7.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox7.TabIndex = 6
            Me.CheckBox7.Text = "ute"
            Me.CheckBox8.Checked = True
            Me.CheckBox8.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox8.Location = New Global.System.Drawing.Point(120, 96)
            Me.CheckBox8.Name = "CheckBox8"
            Me.CheckBox8.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox8.TabIndex = 11
            Me.CheckBox8.Text = "utt"
            Me.CheckBox11.Checked = True
            Me.CheckBox11.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox11.Location = New Global.System.Drawing.Point(120, 48)
            Me.CheckBox11.Name = "CheckBox11"
            Me.CheckBox11.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox11.TabIndex = 9
            Me.CheckBox11.Text = "utp"
            Me.CheckBox12.Checked = True
            Me.CheckBox12.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox12.Location = New Global.System.Drawing.Point(168, 24)
            Me.CheckBox12.Name = "CheckBox12"
            Me.CheckBox12.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox12.TabIndex = 12
            Me.CheckBox12.Text = "utw"
            Me.CheckBox13.Checked = True
            Me.CheckBox13.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox13.Location = New Global.System.Drawing.Point(120, 72)
            Me.CheckBox13.Name = "CheckBox13"
            Me.CheckBox13.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox13.TabIndex = 10
            Me.CheckBox13.Text = "uts"
            Me.CheckBox16.Checked = True
            Me.CheckBox16.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox16.Location = New Global.System.Drawing.Point(8, 72)
            Me.CheckBox16.Name = "CheckBox16"
            Me.CheckBox16.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox16.TabIndex = 2
            Me.CheckBox16.Text = "ifo"
            Me.CheckBox18.Checked = True
            Me.CheckBox18.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox18.Location = New Global.System.Drawing.Point(8, 48)
            Me.CheckBox18.Name = "CheckBox18"
            Me.CheckBox18.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox18.TabIndex = 1
            Me.CheckBox18.Text = "git"
            Me.btnSetAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSetAll.Location = New Global.System.Drawing.Point(87, 168)
            Me.btnSetAll.Name = "btnSetAll"
            Me.btnSetAll.TabIndex = 0
            Me.btnSetAll.Text = "Set All"
            Me.btnClearAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnClearAll.Location = New Global.System.Drawing.Point(191, 168)
            Me.btnClearAll.Name = "btnClearAll"
            Me.btnClearAll.TabIndex = 1
            Me.btnClearAll.Text = "Clear All"
            Me.rbtnSensitive.Location = New Global.System.Drawing.Point(24, 14)
            Me.rbtnSensitive.Name = "rbtnSensitive"
            Me.rbtnSensitive.Size = New Global.System.Drawing.Size(88, 20)
            Me.rbtnSensitive.TabIndex = 1
            Me.rbtnSensitive.Text = "Sensitive"
            Me.rbtnInsensitive.Checked = True
            Me.rbtnInsensitive.Location = New Global.System.Drawing.Point(24, 38)
            Me.rbtnInsensitive.Name = "rbtnInsensitive"
            Me.rbtnInsensitive.Size = New Global.System.Drawing.Size(88, 20)
            Me.rbtnInsensitive.TabIndex = 2
            Me.rbtnInsensitive.TabStop = True
            Me.rbtnInsensitive.Text = "Insensitive"
            Me.gboxFileTypes.Controls.Add(Me.btnSetAll)
            Me.gboxFileTypes.Controls.Add(Me.btnClearAll)
            Me.gboxFileTypes.Controls.Add(Me.gboxGFF)
            Me.gboxFileTypes.Controls.Add(Me.gboxScript)
            Me.gboxFileTypes.Enabled = False
            Me.gboxFileTypes.Location = New Global.System.Drawing.Point(12, 272)
            Me.gboxFileTypes.Name = "gboxFileTypes"
            Me.gboxFileTypes.Size = New Global.System.Drawing.Size(332, 208)
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
            Me.gboxGFF.Location = New Global.System.Drawing.Point(16, 32)
            Me.gboxGFF.Name = "gboxGFF"
            Me.gboxGFF.Size = New Global.System.Drawing.Size(224, 128)
            Me.gboxGFF.TabIndex = 24
            Me.gboxGFF.TabStop = False
            Me.gboxGFF.Text = "GFF-based files"
            Me.gboxScript.Controls.Add(Me.CheckBox22)
            Me.gboxScript.Controls.Add(Me.CheckBox23)
            Me.gboxScript.Location = New Global.System.Drawing.Point(248, 32)
            Me.gboxScript.Name = "gboxScript"
            Me.gboxScript.Size = New Global.System.Drawing.Size(72, 88)
            Me.gboxScript.TabIndex = 24
            Me.gboxScript.TabStop = False
            Me.gboxScript.Text = "Scripts"
            Me.CheckBox22.Checked = True
            Me.CheckBox22.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox22.Location = New Global.System.Drawing.Point(16, 32)
            Me.CheckBox22.Name = "CheckBox22"
            Me.CheckBox22.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox22.TabIndex = 0
            Me.CheckBox22.Text = "ncs"
            Me.CheckBox23.Checked = True
            Me.CheckBox23.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.CheckBox23.Location = New Global.System.Drawing.Point(16, 56)
            Me.CheckBox23.Name = "CheckBox23"
            Me.CheckBox23.Size = New Global.System.Drawing.Size(48, 16)
            Me.CheckBox23.TabIndex = 1
            Me.CheckBox23.Text = "nss"
            Me.gboxArchiveTypes.Controls.Add(Me.chkbScripts)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbTemplates)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbRIMs)
            Me.gboxArchiveTypes.Controls.Add(Me.chkbAllBifs)
            Me.gboxArchiveTypes.Enabled = False
            Me.gboxArchiveTypes.Location = New Global.System.Drawing.Point(16, 160)
            Me.gboxArchiveTypes.Name = "gboxArchiveTypes"
            Me.gboxArchiveTypes.Size = New Global.System.Drawing.Size(328, 96)
            Me.gboxArchiveTypes.TabIndex = 23
            Me.gboxArchiveTypes.TabStop = False
            Me.gboxArchiveTypes.Text = "Archive  types to search in"
            Me.chkbScripts.Checked = True
            Me.chkbScripts.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbScripts.Location = New Global.System.Drawing.Point(80, 64)
            Me.chkbScripts.Name = "chkbScripts"
            Me.chkbScripts.Size = New Global.System.Drawing.Size(80, 24)
            Me.chkbScripts.TabIndex = 2
            Me.chkbScripts.Text = "Scripts.bif"
            Me.chkbTemplates.Checked = True
            Me.chkbTemplates.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbTemplates.Location = New Global.System.Drawing.Point(80, 40)
            Me.chkbTemplates.Name = "chkbTemplates"
            Me.chkbTemplates.Size = New Global.System.Drawing.Size(96, 24)
            Me.chkbTemplates.TabIndex = 1
            Me.chkbTemplates.Text = "Templates.bif"
            Me.chkbRIMs.Checked = True
            Me.chkbRIMs.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbRIMs.Location = New Global.System.Drawing.Point(224, 16)
            Me.chkbRIMs.Name = "chkbRIMs"
            Me.chkbRIMs.Size = New Global.System.Drawing.Size(64, 24)
            Me.chkbRIMs.TabIndex = 3
            Me.chkbRIMs.Text = "RIMs"
            Me.chkbAllBifs.Checked = True
            Me.chkbAllBifs.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbAllBifs.Location = New Global.System.Drawing.Point(64, 16)
            Me.chkbAllBifs.Name = "chkbAllBifs"
            Me.chkbAllBifs.Size = New Global.System.Drawing.Size(64, 24)
            Me.chkbAllBifs.TabIndex = 0
            Me.chkbAllBifs.Text = "All BIFs"
            Me.gboxCaseSens.Controls.Add(Me.rbtnSensitive)
            Me.gboxCaseSens.Controls.Add(Me.rbtnInsensitive)
            Me.gboxCaseSens.Enabled = False
            Me.gboxCaseSens.Location = New Global.System.Drawing.Point(224, 88)
            Me.gboxCaseSens.Name = "gboxCaseSens"
            Me.gboxCaseSens.Size = New Global.System.Drawing.Size(120, 64)
            Me.gboxCaseSens.TabIndex = 24
            Me.gboxCaseSens.TabStop = False
            Me.gboxCaseSens.Text = "Case"
            Me.GroupBox2.Controls.Add(Me.rbSearchKotor1)
            Me.GroupBox2.Controls.Add(Me.rbSearchKotor2)
            Me.GroupBox2.Location = New Global.System.Drawing.Point(120, 8)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New Global.System.Drawing.Size(104, 64)
            Me.GroupBox2.TabIndex = 25
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search within"
            Me.rbSearchKotor1.Location = New Global.System.Drawing.Point(24, 16)
            Me.rbSearchKotor1.Name = "rbSearchKotor1"
            Me.rbSearchKotor1.Size = New Global.System.Drawing.Size(72, 20)
            Me.rbSearchKotor1.TabIndex = 0
            Me.rbSearchKotor1.Text = "KotOR I"
            Me.rbSearchKotor2.Location = New Global.System.Drawing.Point(24, 40)
            Me.rbSearchKotor2.Name = "rbSearchKotor2"
            Me.rbSearchKotor2.Size = New Global.System.Drawing.Size(72, 20)
            Me.rbSearchKotor2.TabIndex = 0
            Me.rbSearchKotor2.Text = "KotOR II"
            Me.gboxSearchString.Controls.Add(Me.tbSearchString)
            Me.gboxSearchString.Enabled = False
            Me.gboxSearchString.Location = New Global.System.Drawing.Point(16, 88)
            Me.gboxSearchString.Name = "gboxSearchString"
            Me.gboxSearchString.Size = New Global.System.Drawing.Size(192, 64)
            Me.gboxSearchString.TabIndex = 26
            Me.gboxSearchString.TabStop = False
            Me.gboxSearchString.Text = "String to search for"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(360, 525)
            Me.ControlBox = False
            Me.Controls.Add(Me.gboxSearchString)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.gboxCaseSens)
            Me.Controls.Add(Me.gboxArchiveTypes)
            Me.Controls.Add(Me.gboxFileTypes)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.MaximizeBox = False
            Me.MinimumSize = New Global.System.Drawing.Size(344, 376)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.tbSearchString.TextChanged, AddressOf Me.tbSearchString_TextChanged
            AddHandler Me.btnSetAll.Click, AddressOf Me.btnSetAll_Click
            AddHandler Me.btnClearAll.Click, AddressOf Me.btnClearAll_Click
            AddHandler Me.chkbScripts.CheckedChanged, AddressOf Me.chkbScripts_CheckedChanged
            AddHandler Me.chkbTemplates.CheckedChanged, AddressOf Me.chkbTemplates_CheckedChanged
            AddHandler Me.chkbRIMs.CheckedChanged, AddressOf Me.chkbRIMs_CheckedChanged
            AddHandler Me.chkbAllBifs.CheckedChanged, AddressOf Me.chkbAllBifs_CheckedChanged
            AddHandler Me.rbSearchKotor1.CheckedChanged, AddressOf Me.rbSearch_CheckedChanged
            AddHandler Me.rbSearchKotor2.CheckedChanged, AddressOf Me.rbSearch_CheckedChanged
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
