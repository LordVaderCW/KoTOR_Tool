Namespace kotor_tool
	' Token: 0x0200004C RID: 76
	Public Partial Class frmFilterDesigner
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060004DB RID: 1243 RVA: 0x0023EF70 File Offset: 0x0023DF70
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060004F2 RID: 1266 RVA: 0x0023F248 File Offset: 0x0023E248
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmFilterDesigner))
            Me.cmbxMatchOperator1 = New Global.System.Windows.Forms.ComboBox()
            Me.tbCriteria1 = New Global.System.Windows.Forms.TextBox()
            Me.cmbxConcatOperator1 = New Global.System.Windows.Forms.ComboBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnReset = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.btnAddFilter = New Global.System.Windows.Forms.Button()
            Me.cmbxColumnName1 = New Global.System.Windows.Forms.ComboBox()
            Me.btnRemove1 = New Global.System.Windows.Forms.Button()
            Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
            Me.SuspendLayout()
            Me.cmbxMatchOperator1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.HelpProvider1.SetHelpString(Me.cmbxMatchOperator1, "Choose the Match Operator for this filter element")
            Me.cmbxMatchOperator1.Items.AddRange(New Object() {"LIKE", "NOT LIKE", "=", "<>", "<", ">", "<=", ">=", "IN", "NOT IN"})
            Dim cmbxMatchOperator As Global.System.Windows.Forms.Control = Me.cmbxMatchOperator1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(168, 56)
            cmbxMatchOperator.Location = point
            Me.cmbxMatchOperator1.MaxDropDownItems = 10
            Me.cmbxMatchOperator1.Name = "cmbxMatchOperator1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxMatchOperator1, True)
            Dim cmbxMatchOperator2 As Global.System.Windows.Forms.Control = Me.cmbxMatchOperator1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(80, 21)
            cmbxMatchOperator2.Size = size
            Me.cmbxMatchOperator1.TabIndex = 1
            Me.cmbxMatchOperator1.Tag = "mo1"
            Me.HelpProvider1.SetHelpString(Me.tbCriteria1, "Enter the Criteria String for this filter element")
            Dim tbCriteria As Global.System.Windows.Forms.Control = Me.tbCriteria1
            point = New Global.System.Drawing.Point(256, 56)
            tbCriteria.Location = point
            Me.tbCriteria1.Name = "tbCriteria1"
            Me.HelpProvider1.SetShowHelp(Me.tbCriteria1, True)
            Dim tbCriteria2 As Global.System.Windows.Forms.Control = Me.tbCriteria1
            size = New Global.System.Drawing.Size(136, 20)
            tbCriteria2.Size = size
            Me.tbCriteria1.TabIndex = 2
            Me.tbCriteria1.Tag = "cr1"
            Me.tbCriteria1.Text = ""
            Me.cmbxConcatOperator1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.HelpProvider1.SetHelpString(Me.cmbxConcatOperator1, "Choose the Boolean Concatenation Operator for this filter element. This is only required if another filter element will follow this one.")
            Me.cmbxConcatOperator1.Items.AddRange(New Object() {"", "AND", "OR"})
            Dim cmbxConcatOperator As Global.System.Windows.Forms.Control = Me.cmbxConcatOperator1
            point = New Global.System.Drawing.Point(400, 56)
            cmbxConcatOperator.Location = point
            Me.cmbxConcatOperator1.Name = "cmbxConcatOperator1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxConcatOperator1, True)
            Dim cmbxConcatOperator2 As Global.System.Windows.Forms.Control = Me.cmbxConcatOperator1
            size = New Global.System.Drawing.Size(48, 21)
            cmbxConcatOperator2.Size = size
            Me.cmbxConcatOperator1.TabIndex = 3
            Me.cmbxConcatOperator1.Tag = "co1"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(107, 144)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 101
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(305, 144)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 103
            Me.btnCancel.Text = "Cancel"
            Me.btnReset.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Dim btnReset As Global.System.Windows.Forms.Control = Me.btnReset
            point = New Global.System.Drawing.Point(206, 144)
            btnReset.Location = point
            Me.btnReset.Name = "btnReset"
            Me.btnReset.TabIndex = 102
            Me.btnReset.Text = "Reset"
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(32, 32)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(96, 16)
            label2.Size = size
            Me.Label1.TabIndex = 43
            Me.Label1.Text = "Column"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.btnAddFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.HelpProvider1.SetHelpString(Me.btnAddFilter, "Add a new filter element")
            Dim btnAddFilter As Global.System.Windows.Forms.Control = Me.btnAddFilter
            point = New Global.System.Drawing.Point(332, 88)
            btnAddFilter.Location = point
            Me.btnAddFilter.Name = "btnAddFilter"
            Me.HelpProvider1.SetShowHelp(Me.btnAddFilter, True)
            Dim btnAddFilter2 As Global.System.Windows.Forms.Control = Me.btnAddFilter
            size = New Global.System.Drawing.Size(40, 23)
            btnAddFilter2.Size = size
            Me.btnAddFilter.TabIndex = 100
            Me.btnAddFilter.Text = "Add"
            Me.cmbxColumnName1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.HelpProvider1.SetHelpString(Me.cmbxColumnName1, "Choose the Column for this filter element")
            Dim cmbxColumnName As Global.System.Windows.Forms.Control = Me.cmbxColumnName1
            point = New Global.System.Drawing.Point(16, 56)
            cmbxColumnName.Location = point
            Me.cmbxColumnName1.Name = "cmbxColumnName1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxColumnName1, True)
            Dim cmbxColumnName2 As Global.System.Windows.Forms.Control = Me.cmbxColumnName1
            size = New Global.System.Drawing.Size(141, 21)
            cmbxColumnName2.Size = size
            Me.cmbxColumnName1.TabIndex = 0
            Me.cmbxColumnName1.Tag = "cn1"
            Me.btnRemove1.AccessibleDescription = "This is a template don't move it"
            Me.HelpProvider1.SetHelpString(Me.btnRemove1, "Click to remove this filter element")
            Dim btnRemove As Global.System.Windows.Forms.Control = Me.btnRemove1
            point = New Global.System.Drawing.Point(456, 56)
            btnRemove.Location = point
            Me.btnRemove1.Name = "btnRemove1"
            Me.HelpProvider1.SetShowHelp(Me.btnRemove1, True)
            Dim btnRemove2 As Global.System.Windows.Forms.Control = Me.btnRemove1
            size = New Global.System.Drawing.Size(21, 21)
            btnRemove2.Size = size
            Me.btnRemove1.TabIndex = 105
            Me.btnRemove1.Text = "This is a template don't move it"
            Me.btnRemove1.Visible = False
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(486, 187)
            Me.ClientSize = size
            Me.Controls.Add(Me.btnRemove1)
            Me.Controls.Add(Me.cmbxColumnName1)
            Me.Controls.Add(Me.btnAddFilter)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnReset)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.tbCriteria1)
            Me.Controls.Add(Me.cmbxMatchOperator1)
            Me.Controls.Add(Me.cmbxConcatOperator1)
            Me.HelpButton = True
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmFilterDesigner"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Filter Editor"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040002AD RID: 685
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
