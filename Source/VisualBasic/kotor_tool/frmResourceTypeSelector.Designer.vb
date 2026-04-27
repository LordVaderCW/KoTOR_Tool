Namespace kotor_tool
	' Token: 0x02000072 RID: 114
	Public Partial Class frmResourceTypeSelector
		Inherits Global.System.Windows.Forms.Form

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
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmResourceTypeSelector))
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
            Dim chkbGIT As Global.System.Windows.Forms.Control = Me.chkbGIT
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(40, 48)
            chkbGIT.Location = point
            Me.chkbGIT.Name = "chkbGIT"
            Dim chkbGIT2 As Global.System.Windows.Forms.Control = Me.chkbGIT
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(152, 16)
            chkbGIT2.Size = size
            Me.chkbGIT.TabIndex = 0
            Me.chkbGIT.Text = "Dynamic Module Info"
            Me.chkbARE.Checked = True
            Me.chkbARE.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbARE As Global.System.Windows.Forms.Control = Me.chkbARE
            point = New Global.System.Drawing.Point(40, 72)
            chkbARE.Location = point
            Me.chkbARE.Name = "chkbARE"
            Dim chkbARE2 As Global.System.Windows.Forms.Control = Me.chkbARE
            size = New Global.System.Drawing.Size(152, 16)
            chkbARE2.Size = size
            Me.chkbARE.TabIndex = 1
            Me.chkbARE.Text = "Static Module Info"
            Me.chkbIFO.Checked = True
            Me.chkbIFO.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbIFO As Global.System.Windows.Forms.Control = Me.chkbIFO
            point = New Global.System.Drawing.Point(40, 96)
            chkbIFO.Location = point
            Me.chkbIFO.Name = "chkbIFO"
            Dim chkbIFO2 As Global.System.Windows.Forms.Control = Me.chkbIFO
            size = New Global.System.Drawing.Size(152, 16)
            chkbIFO2.Size = size
            Me.chkbIFO.TabIndex = 2
            Me.chkbIFO.Text = "Module.ifo"
            Me.chkbPTH.Checked = True
            Me.chkbPTH.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbPTH As Global.System.Windows.Forms.Control = Me.chkbPTH
            point = New Global.System.Drawing.Point(40, 120)
            chkbPTH.Location = point
            Me.chkbPTH.Name = "chkbPTH"
            Dim chkbPTH2 As Global.System.Windows.Forms.Control = Me.chkbPTH
            size = New Global.System.Drawing.Size(152, 16)
            chkbPTH2.Size = size
            Me.chkbPTH.TabIndex = 3
            Me.chkbPTH.Text = "Path Info"
            Me.chkbUTD.Checked = True
            Me.chkbUTD.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbUTD As Global.System.Windows.Forms.Control = Me.chkbUTD
            point = New Global.System.Drawing.Point(208, 48)
            chkbUTD.Location = point
            Me.chkbUTD.Name = "chkbUTD"
            Dim chkbUTD2 As Global.System.Windows.Forms.Control = Me.chkbUTD
            size = New Global.System.Drawing.Size(120, 16)
            chkbUTD2.Size = size
            Me.chkbUTD.TabIndex = 4
            Me.chkbUTD.Text = "Doors"
            Dim chkbUTM As Global.System.Windows.Forms.Control = Me.chkbUTM
            point = New Global.System.Drawing.Point(208, 144)
            chkbUTM.Location = point
            Me.chkbUTM.Name = "chkbUTM"
            Dim chkbUTM2 As Global.System.Windows.Forms.Control = Me.chkbUTM
            size = New Global.System.Drawing.Size(120, 16)
            chkbUTM2.Size = size
            Me.chkbUTM.TabIndex = 8
            Me.chkbUTM.Text = "Merchants"
            Dim chkbUTT As Global.System.Windows.Forms.Control = Me.chkbUTT
            point = New Global.System.Drawing.Point(208, 168)
            chkbUTT.Location = point
            Me.chkbUTT.Name = "chkbUTT"
            Dim chkbUTT2 As Global.System.Windows.Forms.Control = Me.chkbUTT
            size = New Global.System.Drawing.Size(120, 16)
            chkbUTT2.Size = size
            Me.chkbUTT.TabIndex = 9
            Me.chkbUTT.Text = "Triggers"
            Dim chkbUTC As Global.System.Windows.Forms.Control = Me.chkbUTC
            point = New Global.System.Drawing.Point(208, 120)
            chkbUTC.Location = point
            Me.chkbUTC.Name = "chkbUTC"
            Dim chkbUTC2 As Global.System.Windows.Forms.Control = Me.chkbUTC
            size = New Global.System.Drawing.Size(120, 16)
            chkbUTC2.Size = size
            Me.chkbUTC.TabIndex = 7
            Me.chkbUTC.Text = "Creatures"
            Dim chkbUTW As Global.System.Windows.Forms.Control = Me.chkbUTW
            point = New Global.System.Drawing.Point(208, 96)
            chkbUTW.Location = point
            Me.chkbUTW.Name = "chkbUTW"
            Dim chkbUTW2 As Global.System.Windows.Forms.Control = Me.chkbUTW
            size = New Global.System.Drawing.Size(120, 16)
            chkbUTW2.Size = size
            Me.chkbUTW.TabIndex = 6
            Me.chkbUTW.Text = "Waypoints"
            Dim chkbUTE As Global.System.Windows.Forms.Control = Me.chkbUTE
            point = New Global.System.Drawing.Point(208, 192)
            chkbUTE.Location = point
            Me.chkbUTE.Name = "chkbUTE"
            Dim chkbUTE2 As Global.System.Windows.Forms.Control = Me.chkbUTE
            size = New Global.System.Drawing.Size(120, 16)
            chkbUTE2.Size = size
            Me.chkbUTE.TabIndex = 10
            Me.chkbUTE.Text = "Encounters"
            Dim chkbUTS As Global.System.Windows.Forms.Control = Me.chkbUTS
            point = New Global.System.Drawing.Point(208, 216)
            chkbUTS.Location = point
            Me.chkbUTS.Name = "chkbUTS"
            Dim chkbUTS2 As Global.System.Windows.Forms.Control = Me.chkbUTS
            size = New Global.System.Drawing.Size(120, 16)
            chkbUTS2.Size = size
            Me.chkbUTS.TabIndex = 11
            Me.chkbUTS.Text = "Sounds"
            Dim chkbNCS As Global.System.Windows.Forms.Control = Me.chkbNCS
            point = New Global.System.Drawing.Point(208, 240)
            chkbNCS.Location = point
            Me.chkbNCS.Name = "chkbNCS"
            Dim chkbNCS2 As Global.System.Windows.Forms.Control = Me.chkbNCS
            size = New Global.System.Drawing.Size(120, 16)
            chkbNCS2.Size = size
            Me.chkbNCS.TabIndex = 12
            Me.chkbNCS.Text = "Compiled Scripts"
            Me.chkbUTP.Checked = True
            Me.chkbUTP.CheckState = Global.System.Windows.Forms.CheckState.Checked
            Dim chkbUTP As Global.System.Windows.Forms.Control = Me.chkbUTP
            point = New Global.System.Drawing.Point(208, 72)
            chkbUTP.Location = point
            Me.chkbUTP.Name = "chkbUTP"
            Dim chkbUTP2 As Global.System.Windows.Forms.Control = Me.chkbUTP
            size = New Global.System.Drawing.Size(120, 16)
            chkbUTP2.Size = size
            Me.chkbUTP.TabIndex = 5
            Me.chkbUTP.Text = "Placeables"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(160, 288)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 13
            Me.btnOK.Text = "Next >>"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(256, 288)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 14
            Me.btnCancel.Text = "Cancel"
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(88, 16)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(208, 16)
            label2.Size = size
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Select the resource types to extract:"
            Me.btnSelectAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnSelectAll As Global.System.Windows.Forms.Control = Me.btnSelectAll
            point = New Global.System.Drawing.Point(48, 184)
            btnSelectAll.Location = point
            Me.btnSelectAll.Name = "btnSelectAll"
            Me.btnSelectAll.TabIndex = 14
            Me.btnSelectAll.Text = "Select All"
            Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnClear As Global.System.Windows.Forms.Control = Me.btnClear
            point = New Global.System.Drawing.Point(48, 216)
            btnClear.Location = point
            Me.btnClear.Name = "btnClear"
            Me.btnClear.TabIndex = 14
            Me.btnClear.Text = "Clear"
            Me.AcceptButton = Me.btnOK
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(360, 325)
            Me.ClientSize = size
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
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmResourceTypeSelector"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Resource Type Selector"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000735 RID: 1845
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
