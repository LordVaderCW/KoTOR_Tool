Imports System.Windows.Forms.Timer
Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x0200008D RID: 141
    Partial Public Class RegReminder
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents lblRegHeader As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents Timer1 As Timer
        Friend WithEvents lblTimeMsg As Global.System.Windows.Forms.Label
        Friend WithEvents Button2 As Global.System.Windows.Forms.Button
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label


        ' Token: 0x060017DF RID: 6111 RVA: 0x002CC7BC File Offset: 0x002CB7BC
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x060017EE RID: 6126 RVA: 0x002CC9D4 File Offset: 0x002CB9D4
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Global.System.ComponentModel.Container()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.RegReminder))
            Me.lblRegHeader = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.lblTimeMsg = New Global.System.Windows.Forms.Label()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.Timer1 = New Global.System.Windows.Forms.Timer()
            Me.Button2 = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.SuspendLayout()
            Me.lblRegHeader.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.lblRegHeader.Location = New Global.System.Drawing.Point(15, 32)
            Me.lblRegHeader.Name = "lblRegHeader"
            Me.lblRegHeader.Size = New Global.System.Drawing.Size(300, 23)
            Me.lblRegHeader.TabIndex = 0
            Me.lblRegHeader.Text = "This copy of Kotor Tool is not registered"
            Me.lblRegHeader.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.Location = New Global.System.Drawing.Point(16, 72)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(288, 48)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Registration removes this nag screen and unlocks additional features"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.lblTimeMsg.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.lblTimeMsg.Location = New Global.System.Drawing.Point(80, 192)
            Me.lblTimeMsg.Name = "lblTimeMsg"
            Me.lblTimeMsg.Size = New Global.System.Drawing.Size(144, 23)
            Me.lblTimeMsg.TabIndex = 0
            Me.lblTimeMsg.Text = "Please wait .. "
            Me.Button1.Enabled = False
            Me.Button1.Location = New Global.System.Drawing.Point(72, 240)
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "OK"
            Me.Timer1.Interval = 800
            Me.Button2.Location = New Global.System.Drawing.Point(176, 240)
            Me.Button2.Name = "Button2"
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "Cancel"
            Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.Location = New Global.System.Drawing.Point(16, 128)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(312, 48)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Use the Registration option on the Help menu to start the registration process"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(336, 304)
            Me.ControlBox = False
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.lblRegHeader)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.lblTimeMsg)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(328, 312)
            Me.Name = "RegReminder"
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Reminder"
            Me.TopMost = True

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.Button1.Click, AddressOf Me.Button1_Click
            AddHandler Me.Timer1.Tick, AddressOf Me.Timer1_Tick
            AddHandler Me.Button2.Click, AddressOf Me.Button2_Click
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace
