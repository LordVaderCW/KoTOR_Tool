Namespace kotor_tool
	' Token: 0x02000072 RID: 114
	Public Partial Class frmResourceTypeSelector
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents chkbGIT As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbARE As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbIFO As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbPTH As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTD As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTM As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTT As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTC As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTW As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTE As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTS As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbUTP As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbNCS As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnSelectAll As Global.System.Windows.Forms.Button
        Friend WithEvents btnClear As Global.System.Windows.Forms.Button


		' Token: 0x06000EB0 RID: 3760 RVA: 0x002900F0 File Offset: 0x0028F0F0
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000ED5 RID: 3797 RVA: 0x002904E0 File Offset: 0x0028F4E0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmResourceTypeSelector))
            Me.chkbGIT = New Global.System.Windows.Forms.CheckBox()
            Me.chkbARE = New Global.System.Windows.Forms.CheckBox()
            Me.chkbIFO = New Global.System.Windows.Forms.CheckBox()
            Me.chkbPTH = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUTD = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUTM = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUTT = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUTC = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUTW = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUTE = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUTS = New Global.System.Windows.Forms.CheckBox()
            Me.chkbNCS = New Global.System.Windows.Forms.CheckBox()
            Me.chkbUTP = New Global.System.Windows.Forms.CheckBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.btnSelectAll = New Global.System.Windows.Forms.Button()
            Me.btnClear = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.chkbGIT.Checked = True
            Me.chkbGIT.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbGIT.Location = New Global.System.Drawing.Point(40, 48)
            Me.chkbGIT.Name = "chkbGIT"
            Me.chkbGIT.Size = New Global.System.Drawing.Size(152, 16)
            Me.chkbGIT.TabIndex = 0
            Me.chkbGIT.Text = "Dynamic Module Info"
            Me.chkbARE.Checked = True
            Me.chkbARE.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbARE.Location = New Global.System.Drawing.Point(40, 72)
            Me.chkbARE.Name = "chkbARE"
            Me.chkbARE.Size = New Global.System.Drawing.Size(152, 16)
            Me.chkbARE.TabIndex = 1
            Me.chkbARE.Text = "Static Module Info"
            Me.chkbIFO.Checked = True
            Me.chkbIFO.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbIFO.Location = New Global.System.Drawing.Point(40, 96)
            Me.chkbIFO.Name = "chkbIFO"
            Me.chkbIFO.Size = New Global.System.Drawing.Size(152, 16)
            Me.chkbIFO.TabIndex = 2
            Me.chkbIFO.Text = "Module.ifo"
            Me.chkbPTH.Checked = True
            Me.chkbPTH.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbPTH.Location = New Global.System.Drawing.Point(40, 120)
            Me.chkbPTH.Name = "chkbPTH"
            Me.chkbPTH.Size = New Global.System.Drawing.Size(152, 16)
            Me.chkbPTH.TabIndex = 3
            Me.chkbPTH.Text = "Path Info"
            Me.chkbUTD.Checked = True
            Me.chkbUTD.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbUTD.Location = New Global.System.Drawing.Point(208, 48)
            Me.chkbUTD.Name = "chkbUTD"
            Me.chkbUTD.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbUTD.TabIndex = 4
            Me.chkbUTD.Text = "Doors"
            Me.chkbUTM.Location = New Global.System.Drawing.Point(208, 144)
            Me.chkbUTM.Name = "chkbUTM"
            Me.chkbUTM.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbUTM.TabIndex = 8
            Me.chkbUTM.Text = "Merchants"
            Me.chkbUTT.Location = New Global.System.Drawing.Point(208, 168)
            Me.chkbUTT.Name = "chkbUTT"
            Me.chkbUTT.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbUTT.TabIndex = 9
            Me.chkbUTT.Text = "Triggers"
            Me.chkbUTC.Location = New Global.System.Drawing.Point(208, 120)
            Me.chkbUTC.Name = "chkbUTC"
            Me.chkbUTC.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbUTC.TabIndex = 7
            Me.chkbUTC.Text = "Creatures"
            Me.chkbUTW.Location = New Global.System.Drawing.Point(208, 96)
            Me.chkbUTW.Name = "chkbUTW"
            Me.chkbUTW.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbUTW.TabIndex = 6
            Me.chkbUTW.Text = "Waypoints"
            Me.chkbUTE.Location = New Global.System.Drawing.Point(208, 192)
            Me.chkbUTE.Name = "chkbUTE"
            Me.chkbUTE.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbUTE.TabIndex = 10
            Me.chkbUTE.Text = "Encounters"
            Me.chkbUTS.Location = New Global.System.Drawing.Point(208, 216)
            Me.chkbUTS.Name = "chkbUTS"
            Me.chkbUTS.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbUTS.TabIndex = 11
            Me.chkbUTS.Text = "Sounds"
            Me.chkbNCS.Location = New Global.System.Drawing.Point(208, 240)
            Me.chkbNCS.Name = "chkbNCS"
            Me.chkbNCS.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbNCS.TabIndex = 12
            Me.chkbNCS.Text = "Compiled Scripts"
            Me.chkbUTP.Checked = True
            Me.chkbUTP.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Me.chkbUTP.Location = New Global.System.Drawing.Point(208, 72)
            Me.chkbUTP.Name = "chkbUTP"
            Me.chkbUTP.Size = New Global.System.Drawing.Size(120, 16)
            Me.chkbUTP.TabIndex = 5
            Me.chkbUTP.Text = "Placeables"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(160, 288)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 13
            Me.btnOK.Text = "Next >>"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(256, 288)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 14
            Me.btnCancel.Text = "Cancel"
            Me.Label1.Location = New Global.System.Drawing.Point(88, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(208, 16)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Select the resource types to extract:"
            Me.btnSelectAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnSelectAll.Location = New Global.System.Drawing.Point(48, 184)
            Me.btnSelectAll.Name = "btnSelectAll"
            Me.btnSelectAll.TabIndex = 14
            Me.btnSelectAll.Text = "Select All"
            Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnClear.Location = New Global.System.Drawing.Point(48, 216)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.TabIndex = 14
            Me.btnClear.Text = "Clear"
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(360, 325)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.chkbPTH)
            Me.Controls.Add(Me.chkbUTD)
            Me.Controls.Add(Me.chkbUTM)
            Me.Controls.Add(Me.chkbGIT)
            Me.Controls.Add(Me.chkbARE)
            Me.Controls.Add(Me.chkbIFO)
            Me.Controls.Add(Me.chkbUTT)
            Me.Controls.Add(Me.chkbUTC)
            Me.Controls.Add(Me.chkbUTW)
            Me.Controls.Add(Me.chkbUTE)
            Me.Controls.Add(Me.chkbUTS)
            Me.Controls.Add(Me.chkbNCS)
            Me.Controls.Add(Me.chkbUTP)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSelectAll)
            Me.Controls.Add(Me.btnClear)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmResourceTypeSelector"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Resource Type Selector"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnSelectAll.Click, AddressOf Me.btnSelectAll_Click
            AddHandler Me.btnClear.Click, AddressOf Me.btnClear_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
