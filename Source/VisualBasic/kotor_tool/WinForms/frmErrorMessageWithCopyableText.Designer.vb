Namespace kotor_tool
	' Token: 0x0200004B RID: 75
	Public Partial Class frmErrorMessageWithCopyableText
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents lblMsg As Global.System.Windows.Forms.Label
        Friend WithEvents tbMsg As Global.System.Windows.Forms.TextBox


		' Token: 0x060004CF RID: 1231 RVA: 0x0023EBDC File Offset: 0x0023DBDC
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x060004D6 RID: 1238 RVA: 0x0023EC8C File Offset: 0x0023DC8C
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmErrorMessageWithCopyableText))
            Me.lblMsg = New Global.System.Windows.Forms.Label()
            Me.tbMsg = New Global.System.Windows.Forms.TextBox()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.lblMsg.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.lblMsg.Location = New Global.System.Drawing.Point(36, 16)
            Me.lblMsg.Name = "lblMsg"
            Me.lblMsg.Size = New Global.System.Drawing.Size(296, 96)
            Me.lblMsg.TabIndex = 0
            Me.lblMsg.Text = "Kotor Tool has either detected a problem with your SW:KotOR installation or is having a problem with one of its own files. Please report this status code by copying it and pasting it into an email to FredTetra@hotmail.com. Thank you!"
            Me.tbMsg.Location = New Global.System.Drawing.Point(56, 120)
            Me.tbMsg.Multiline = True
            Me.tbMsg.Name = "tbMsg"
            Me.tbMsg.[ReadOnly] = True
            Me.tbMsg.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
            Me.tbMsg.Size = New Global.System.Drawing.Size(256, 88)
            Me.tbMsg.TabIndex = 1
            Me.tbMsg.Text = ""
            Me.Button1.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.Button1.Location = New Global.System.Drawing.Point(147, 224)
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "Sorry!"
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(360, 269)
            Me.ControlBox = False
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.tbMsg)
            Me.Controls.Add(Me.lblMsg)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.Name = "frmErrorMessageWithCopyableText"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "An error has occurred"
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
