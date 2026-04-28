Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x0200004C RID: 76
    Partial Public Class frmFilterDesigner
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents tbCriteria1 As Global.System.Windows.Forms.TextBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents btnReset As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxMatchOperator1 As Global.System.Windows.Forms.ComboBox
        Friend WithEvents cmbxConcatOperator1 As Global.System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents btnAddFilter As Global.System.Windows.Forms.Button
        Friend WithEvents cmbxColumnName1 As Global.System.Windows.Forms.ComboBox
        Friend WithEvents btnRemove1 As Global.System.Windows.Forms.Button
        Friend WithEvents HelpProvider1 As HelpProvider


        ' Token: 0x060004DB RID: 1243 RVA: 0x0023EF70 File Offset: 0x0023DF70
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x060004F2 RID: 1266 RVA: 0x0023F248 File Offset: 0x0023E248
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmFilterDesigner))
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
            Me.cmbxMatchOperator1.Location = New Global.System.Drawing.Point(168, 56)
            Me.cmbxMatchOperator1.MaxDropDownItems = 10
            Me.cmbxMatchOperator1.Name = "cmbxMatchOperator1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxMatchOperator1, True)
            Me.cmbxMatchOperator1.Size = New Global.System.Drawing.Size(80, 21)
            Me.cmbxMatchOperator1.TabIndex = 1
            Me.cmbxMatchOperator1.Tag = "mo1"
            Me.HelpProvider1.SetHelpString(Me.tbCriteria1, "Enter the Criteria String for this filter element")
            Me.tbCriteria1.Location = New Global.System.Drawing.Point(256, 56)
            Me.tbCriteria1.Name = "tbCriteria1"
            Me.HelpProvider1.SetShowHelp(Me.tbCriteria1, True)
            Me.tbCriteria1.Size = New Global.System.Drawing.Size(136, 20)
            Me.tbCriteria1.TabIndex = 2
            Me.tbCriteria1.Tag = "cr1"
            Me.tbCriteria1.Text = ""
            Me.cmbxConcatOperator1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.HelpProvider1.SetHelpString(Me.cmbxConcatOperator1, "Choose the Boolean Concatenation Operator for this filter element. This is only required if another filter element will follow this one.")
            Me.cmbxConcatOperator1.Items.AddRange(New Object() {"", "AND", "OR"})
            Me.cmbxConcatOperator1.Location = New Global.System.Drawing.Point(400, 56)
            Me.cmbxConcatOperator1.Name = "cmbxConcatOperator1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxConcatOperator1, True)
            Me.cmbxConcatOperator1.Size = New Global.System.Drawing.Size(48, 21)
            Me.cmbxConcatOperator1.TabIndex = 3
            Me.cmbxConcatOperator1.Tag = "co1"
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.btnOK.Location = New Global.System.Drawing.Point(107, 144)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 101
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(305, 144)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 103
            Me.btnCancel.Text = "Cancel"
            Me.btnReset.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.btnReset.Location = New Global.System.Drawing.Point(206, 144)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.TabIndex = 102
            Me.btnReset.Text = "Reset"
            Me.Label1.Location = New Global.System.Drawing.Point(32, 32)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(96, 16)
            Me.Label1.TabIndex = 43
            Me.Label1.Text = "Column"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.btnAddFilter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
            Me.HelpProvider1.SetHelpString(Me.btnAddFilter, "Add a new filter element")
            Me.btnAddFilter.Location = New Global.System.Drawing.Point(332, 88)
            Me.btnAddFilter.Name = "btnAddFilter"
            Me.HelpProvider1.SetShowHelp(Me.btnAddFilter, True)
            Me.btnAddFilter.Size = New Global.System.Drawing.Size(40, 23)
            Me.btnAddFilter.TabIndex = 100
            Me.btnAddFilter.Text = "Add"
            Me.cmbxColumnName1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.HelpProvider1.SetHelpString(Me.cmbxColumnName1, "Choose the Column for this filter element")
            Me.cmbxColumnName1.Location = New Global.System.Drawing.Point(16, 56)
            Me.cmbxColumnName1.Name = "cmbxColumnName1"
            Me.HelpProvider1.SetShowHelp(Me.cmbxColumnName1, True)
            Me.cmbxColumnName1.Size = New Global.System.Drawing.Size(141, 21)
            Me.cmbxColumnName1.TabIndex = 0
            Me.cmbxColumnName1.Tag = "cn1"
            Me.btnRemove1.AccessibleDescription = "This is a template don't move it"
            Me.HelpProvider1.SetHelpString(Me.btnRemove1, "Click to remove this filter element")
            Me.btnRemove1.Location = New Global.System.Drawing.Point(456, 56)
            Me.btnRemove1.Name = "btnRemove1"
            Me.HelpProvider1.SetShowHelp(Me.btnRemove1, True)
            Me.btnRemove1.Size = New Global.System.Drawing.Size(21, 21)
            Me.btnRemove1.TabIndex = 105
            Me.btnRemove1.Text = "This is a template don't move it"
            Me.btnRemove1.Visible = False
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(486, 187)
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
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmFilterDesigner"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Filter Editor"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.btnReset.Click, AddressOf Me.btnReset_Click
            AddHandler Me.btnAddFilter.Click, AddressOf Me.btnAddFilter_Click
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace
