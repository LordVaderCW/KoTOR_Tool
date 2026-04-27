Namespace kotor_tool
	' Token: 0x02000045 RID: 69
	Public Partial Class frmCreateAnimListEntry
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002F7 RID: 759 RVA: 0x00230544 File Offset: 0x0022F544
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000306 RID: 774 RVA: 0x002306EC File Offset: 0x0022F6EC
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmCreateAnimListEntry))
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.tbParticipant = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.cmbxAnimation = New Global.System.Windows.Forms.ComboBox()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
            Me.SuspendLayout()
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(64, 160)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 2
            Me.btnOK.Text = "OK"
            Me.ToolTip1.SetToolTip(Me.btnOK, "Click when you have selected a Participant and an Animation.")
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
            point = New Global.System.Drawing.Point(168, 160)
            btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            Dim tbParticipant As Global.System.Windows.Forms.Control = Me.tbParticipant
            point = New Global.System.Drawing.Point(96, 48)
            tbParticipant.Location = point
            Me.tbParticipant.Name = "tbParticipant"
            Dim tbParticipant2 As Global.System.Windows.Forms.Control = Me.tbParticipant
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(128, 20)
            tbParticipant2.Size = size
            Me.tbParticipant.TabIndex = 0
            Me.tbParticipant.Text = ""
            Me.ToolTip1.SetToolTip(Me.tbParticipant, "Enter the Participant name for the Animation")
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(104, 32)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(88, 16)
            label2.Size = size
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Participant"
            Me.cmbxAnimation.Items.AddRange(New Object() {"A", "B", "C"})
            Dim cmbxAnimation As Global.System.Windows.Forms.Control = Me.cmbxAnimation
            point = New Global.System.Drawing.Point(96, 96)
            cmbxAnimation.Location = point
            Me.cmbxAnimation.Name = "cmbxAnimation"
            Dim cmbxAnimation2 As Global.System.Windows.Forms.Control = Me.cmbxAnimation
            size = New Global.System.Drawing.Size(121, 21)
            cmbxAnimation2.Size = size
            Me.cmbxAnimation.TabIndex = 4
            Me.ToolTip1.SetToolTip(Me.cmbxAnimation, "Select an Animation from the list or enter a number.")
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(96, 80)
            label3.Location = point
            Me.Label3.Name = "Label3"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(120, 16)
            label4.Size = size
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Common Animations"
            Me.AcceptButton = Me.btnOK
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Global.System.Drawing.Size(328, 213)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.cmbxAnimation)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.tbParticipant)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.Label3)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmCreateAnimListEntry"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Create Animation List Entry"
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040001DA RID: 474
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
