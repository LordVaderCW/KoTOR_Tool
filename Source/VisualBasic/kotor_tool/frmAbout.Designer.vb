Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmAbout
        Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As Global.System.Windows.Forms.PictureBox
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents lblVersion As Global.System.Windows.Forms.Label


        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblVersion = New System.Windows.Forms.Label()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(138, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(124, 32)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "KotOR Tool"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Button1
            '
            Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.Button1.BackColor = System.Drawing.SystemColors.Control
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button1.Location = New System.Drawing.Point(304, 224)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "OK"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(72, 112)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(256, 23)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Email: FredTetra@hotmail.com"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'PictureBox1
            '
            Me.PictureBox1.Location = New System.Drawing.Point(72, 16)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
            Me.PictureBox1.TabIndex = 4
            Me.PictureBox1.TabStop = False
            '
            'Label4
            '
            Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.Label4.Location = New System.Drawing.Point(48, 192)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(307, 23)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Thanks to Eiz for his dxt1/5 converter code!"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.Label5.Location = New System.Drawing.Point(38, 144)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(325, 40)
            Me.Label5.TabIndex = 7
            Me.Label5.Text = "Thanks to Achilles, illuzion69, CDRSeadog, Darth333, death_disco, ChAiNz.2da, Gua" & _
                "rdian Archon, Gsccc, Uchiha Itachi, and everyone else for their support!"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblVersion
            '
            Me.lblVersion.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVersion.Location = New System.Drawing.Point(92, 72)
            Me.lblVersion.Name = "lblVersion"
            Me.lblVersion.Size = New System.Drawing.Size(216, 16)
            Me.lblVersion.TabIndex = 5
            Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'frmAbout
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.AliceBlue
            Me.ClientSize = New System.Drawing.Size(400, 261)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblVersion)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label5)
            Me.Name = "frmAbout"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "About Kotor Tool"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub


    End Class

End Namespace