Namespace kotor_tool
	' Token: 0x02000060 RID: 96
	Public Partial Class frmModuleEditorOptions
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbShowLocatorRay As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbConfirmDeletes As Global.System.Windows.Forms.CheckBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents nudDotSize As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents btnModuleExportPath As Global.System.Windows.Forms.Button
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents tbModuleExportPath As Global.System.Windows.Forms.TextBox


		' Token: 0x06000952 RID: 2386 RVA: 0x0026D920 File Offset: 0x0026C920
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x06000969 RID: 2409 RVA: 0x0026DB88 File Offset: 0x0026CB88
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmModuleEditorOptions))
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.nudDotSize = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.chkbShowLocatorRay = New Global.System.Windows.Forms.CheckBox()
            Me.chkbConfirmDeletes = New Global.System.Windows.Forms.CheckBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.btnModuleExportPath = New Global.System.Windows.Forms.Button()
            Me.tbModuleExportPath = New Global.System.Windows.Forms.TextBox()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            CType(Me.nudDotSize, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.Label1.Location = New Global.System.Drawing.Point(40, 40)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Module Element Dot localSize"
            Me.nudDotSize.DecimalPlaces = 2
            Me.nudDotSize.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
            Me.nudDotSize.Location = New Global.System.Drawing.Point(184, 38)
            Me.nudDotSize.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
            Me.nudDotSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudDotSize.Name = "nudDotSize"
            Me.nudDotSize.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudDotSize.TabIndex = 1
            Me.nudDotSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
            Me.Label2.Location = New Global.System.Drawing.Point(40, 80)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Show Locator Ray"
            Me.Label3.Location = New Global.System.Drawing.Point(40, 120)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(136, 16)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Confirm Deletes"
            Me.chkbShowLocatorRay.Location = New Global.System.Drawing.Point(184, 76)
            Me.chkbShowLocatorRay.Name = "chkbShowLocatorRay"
            Me.chkbShowLocatorRay.Size = New Global.System.Drawing.Size(24, 24)
            Me.chkbShowLocatorRay.TabIndex = 2
            Me.chkbConfirmDeletes.Location = New Global.System.Drawing.Point(184, 112)
            Me.chkbConfirmDeletes.Name = "chkbConfirmDeletes"
            Me.chkbConfirmDeletes.Size = New Global.System.Drawing.Size(24, 24)
            Me.chkbConfirmDeletes.TabIndex = 2
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New Global.System.Drawing.Point(260, 208)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 3
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(348, 208)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            Me.btnModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnModuleExportPath.Location = New Global.System.Drawing.Point(392, 160)
            Me.btnModuleExportPath.Name = "btnModuleExportPath"
            Me.btnModuleExportPath.Size = New Global.System.Drawing.Size(24, 20)
            Me.btnModuleExportPath.TabIndex = 14
            Me.btnModuleExportPath.Text = "..."
            Me.tbModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.tbModuleExportPath.Location = New Global.System.Drawing.Point(176, 160)
            Me.tbModuleExportPath.Name = "tbModuleExportPath"
            Me.tbModuleExportPath.Size = New Global.System.Drawing.Size(200, 20)
            Me.tbModuleExportPath.TabIndex = 13
            Me.tbModuleExportPath.Text = ""
            Me.Label4.Location = New Global.System.Drawing.Point(40, 160)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label4.TabIndex = 15
            Me.Label4.Text = "Module Export path"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(448, 253)
            Me.ControlBox = False
            Me.Controls.Add(Me.btnModuleExportPath)
            Me.Controls.Add(Me.tbModuleExportPath)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.chkbShowLocatorRay)
            Me.Controls.Add(Me.nudDotSize)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.chkbConfirmDeletes)
            Me.Controls.Add(Me.btnCancel)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(300, 240)
            Me.Name = "frmModuleEditorOptions"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Module Editor Options"
            CType(Me.nudDotSize, Global.System.ComponentModel.ISupportInitialize).EndInit()

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnModuleExportPath.Click, AddressOf Me.btnModuleExportPath_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
