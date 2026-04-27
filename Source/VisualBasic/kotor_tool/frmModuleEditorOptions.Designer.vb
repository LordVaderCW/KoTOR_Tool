Namespace kotor_tool
	' Token: 0x02000060 RID: 96
	Public Partial Class frmModuleEditorOptions
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000952 RID: 2386 RVA: 0x0026D920 File Offset: 0x0026C920
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000969 RID: 2409 RVA: 0x0026DB88 File Offset: 0x0026CB88
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmModuleEditorOptions))
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
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(40, 40)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(136, 16)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Module Element Dot Size"
            Me.nudDotSize.DecimalPlaces = 2
            Dim nudDotSize As Global.System.Windows.Forms.NumericUpDown = Me.nudDotSize
            Dim num As Decimal = New Decimal(New Integer() {25, 0, 0, 131072})
            nudDotSize.Increment = num
            Dim nudDotSize2 As Global.System.Windows.Forms.Control = Me.nudDotSize
            point = New Global.System.Drawing.Point(184, 38)
            nudDotSize2.Location = point
            Dim nudDotSize3 As Global.System.Windows.Forms.NumericUpDown = Me.nudDotSize
            num = New Decimal(New Integer() {4, 0, 0, 0})
            nudDotSize3.Maximum = num
            Dim nudDotSize4 As Global.System.Windows.Forms.NumericUpDown = Me.nudDotSize
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudDotSize4.Minimum = num
            Me.nudDotSize.Name = "nudDotSize"
            Dim nudDotSize5 As Global.System.Windows.Forms.Control = Me.nudDotSize
            size = New Global.System.Drawing.Size(48, 20)
            nudDotSize5.Size = size
            Me.nudDotSize.TabIndex = 1
            Dim nudDotSize6 As Global.System.Windows.Forms.NumericUpDown = Me.nudDotSize
            num = New Decimal(New Integer() {1, 0, 0, 0})
            nudDotSize6.Value = num
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(40, 80)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(136, 16)
            label4.Size = size
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Show Locator Ray"
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(40, 120)
            label5.Location = point
            Me.Label3.Name = "Label3"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(136, 16)
            label6.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Confirm Deletes"
            Dim chkbShowLocatorRay As Global.System.Windows.Forms.Control = Me.chkbShowLocatorRay
            point = New Global.System.Drawing.Point(184, 76)
            chkbShowLocatorRay.Location = point
            Me.chkbShowLocatorRay.Name = "chkbShowLocatorRay"
            Dim chkbShowLocatorRay2 As Global.System.Windows.Forms.Control = Me.chkbShowLocatorRay
            size = New Global.System.Drawing.Size(24, 24)
            chkbShowLocatorRay2.Size = size
            Me.chkbShowLocatorRay.TabIndex = 2
            Dim chkbConfirmDeletes As Global.System.Windows.Forms.Control = Me.chkbConfirmDeletes
            point = New Global.System.Drawing.Point(184, 112)
            chkbConfirmDeletes.Location = point
            Me.chkbConfirmDeletes.Name = "chkbConfirmDeletes"
            Dim chkbConfirmDeletes2 As Global.System.Windows.Forms.Control = Me.chkbConfirmDeletes
            size = New Global.System.Drawing.Size(24, 24)
            chkbConfirmDeletes2.Size = size
            Me.chkbConfirmDeletes.TabIndex = 2
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(260, 208)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 3
            Me.btnOK.Text = "OK"
            Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(348, 208)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            Me.btnModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnModuleExportPath As Global.System.Windows.Forms.Control = Me.btnModuleExportPath
            point = New Global.System.Drawing.Point(392, 160)
            btnModuleExportPath.Location = point
            Me.btnModuleExportPath.Name = "btnModuleExportPath"
            Dim btnModuleExportPath2 As Global.System.Windows.Forms.Control = Me.btnModuleExportPath
            size = New Global.System.Drawing.Size(24, 20)
            btnModuleExportPath2.Size = size
            Me.btnModuleExportPath.TabIndex = 14
            Me.btnModuleExportPath.Text = "..."
            Me.tbModuleExportPath.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim tbModuleExportPath As Global.System.Windows.Forms.Control = Me.tbModuleExportPath
            point = New Global.System.Drawing.Point(176, 160)
            tbModuleExportPath.Location = point
            Me.tbModuleExportPath.Name = "tbModuleExportPath"
            Dim tbModuleExportPath2 As Global.System.Windows.Forms.Control = Me.tbModuleExportPath
            size = New Global.System.Drawing.Size(200, 20)
            tbModuleExportPath2.Size = size
            Me.tbModuleExportPath.TabIndex = 13
            Me.tbModuleExportPath.Text = ""
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(40, 160)
            label7.Location = point
            Me.Label4.Name = "Label4"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(112, 16)
            label8.Size = size
            Me.Label4.TabIndex = 15
            Me.Label4.Text = "Module Export path"
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(448, 253)
            Me.ClientSize = size
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
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(300, 240)
            Me.MinimumSize = size
            Me.Name = "frmModuleEditorOptions"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Module Editor Options"
            CType(Me.nudDotSize, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040004DE RID: 1246
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
