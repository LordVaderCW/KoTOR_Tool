Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x02000045 RID: 69
    Partial Public Class frmCreateAnimListEntry
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents btnCancel As Global.System.Windows.Forms.Button
        Friend WithEvents tbParticipant As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents cmbxAnimation As Global.System.Windows.Forms.ComboBox
        Friend WithEvents ToolTip1 As ToolTip


        ' Token: 0x060002F7 RID: 759 RVA: 0x00230544 File Offset: 0x0022F544
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x06000306 RID: 774 RVA: 0x002306EC File Offset: 0x0022F6EC
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmCreateAnimListEntry))
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.btnCancel = New Global.System.Windows.Forms.Button()
            Me.tbParticipant = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.cmbxAnimation = New Global.System.Windows.Forms.ComboBox()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip()
            Me.SuspendLayout()
            Me.btnOK.Location = New Global.System.Drawing.Point(64, 160)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 2
            Me.btnOK.Text = "OK"
            Me.ToolTip1.SetToolTip(Me.btnOK, "Click when you have selected a Participant and an Animation.")
            Me.btnCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New Global.System.Drawing.Point(168, 160)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "Cancel"
            Me.tbParticipant.Location = New Global.System.Drawing.Point(96, 48)
            Me.tbParticipant.Name = "tbParticipant"
            Me.tbParticipant.Size = New Global.System.Drawing.Size(128, 20)
            Me.tbParticipant.TabIndex = 0
            Me.tbParticipant.Text = ""
            Me.ToolTip1.SetToolTip(Me.tbParticipant, "Enter the Participant name for the Animation")
            Me.Label1.Location = New Global.System.Drawing.Point(104, 32)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Participant"
            Me.cmbxAnimation.Items.AddRange(New Object() {"A", "B", "C"})
            Me.cmbxAnimation.Location = New Global.System.Drawing.Point(96, 96)
            Me.cmbxAnimation.Name = "cmbxAnimation"
            Me.cmbxAnimation.Size = New Global.System.Drawing.Size(121, 21)
            Me.cmbxAnimation.TabIndex = 4
            Me.ToolTip1.SetToolTip(Me.cmbxAnimation, "Select an Animation from the list or enter a number.")
            Me.Label3.Location = New Global.System.Drawing.Point(96, 80)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Common Animations"
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New Global.System.Drawing.Size(328, 213)
            Me.ControlBox = False
            Me.Controls.Add(Me.cmbxAnimation)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.tbParticipant)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.Label3)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmCreateAnimListEntry"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Create Animation List Entry"

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace
