Namespace kotor_tool
	' Token: 0x0200004E RID: 78
	Public Partial Class frmImageViewer
		Inherits Global.System.Windows.Forms.Form

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents pbox As Global.System.Windows.Forms.PictureBox
        Friend WithEvents btnOK As Global.System.Windows.Forms.Button
        Friend WithEvents Panel1 As Global.System.Windows.Forms.Panel
        Friend WithEvents tbImageInfo As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents lblMipMapCount As Global.System.Windows.Forms.Label
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents btnWriteFile As Global.System.Windows.Forms.Button
        Friend WithEvents lblFlag1 As Global.System.Windows.Forms.Label
        Friend WithEvents lblFlag2 As Global.System.Windows.Forms.Label
        Friend WithEvents lblFlag3 As Global.System.Windows.Forms.Label
        Friend WithEvents lblFlag4 As Global.System.Windows.Forms.Label
        Friend WithEvents chkbExportSelectionToTXIfile As Global.System.Windows.Forms.CheckBox


		' Token: 0x06000553 RID: 1363 RVA: 0x00242FE0 File Offset: 0x00241FE0
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

		' Token: 0x0600056E RID: 1390 RVA: 0x002432E0 File Offset: 0x002422E0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmImageViewer))
            Me.pbox = New Global.System.Windows.Forms.PictureBox()
            Me.btnOK = New Global.System.Windows.Forms.Button()
            Me.Panel1 = New Global.System.Windows.Forms.Panel()
            Me.tbImageInfo = New Global.System.Windows.Forms.TextBox()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.lblMipMapCount = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.btnWriteFile = New Global.System.Windows.Forms.Button()
            Me.lblFlag1 = New Global.System.Windows.Forms.Label()
            Me.lblFlag2 = New Global.System.Windows.Forms.Label()
            Me.lblFlag3 = New Global.System.Windows.Forms.Label()
            Me.lblFlag4 = New Global.System.Windows.Forms.Label()
            Me.chkbExportSelectionToTXIfile = New Global.System.Windows.Forms.CheckBox()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            Me.pbox.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbox.Location = New Global.System.Drawing.Point(0, 0)
            Me.pbox.Name = "pbox"
            Me.pbox.Size = New Global.System.Drawing.Size(96, 80)
            Me.pbox.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbox.TabIndex = 0
            Me.pbox.TabStop = False
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.btnOK.Location = New Global.System.Drawing.Point(344, 456)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.AutoScroll = True
            Me.Panel1.Controls.Add(Me.pbox)
            Me.Panel1.Location = New Global.System.Drawing.Point(16, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New Global.System.Drawing.Size(416, 376)
            Me.Panel1.TabIndex = 1
            Me.tbImageInfo.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.tbImageInfo.Location = New Global.System.Drawing.Point(16, 400)
            Me.tbImageInfo.Multiline = True
            Me.tbImageInfo.Name = "tbImageInfo"
            Me.tbImageInfo.Size = New Global.System.Drawing.Size(160, 64)
            Me.tbImageInfo.TabIndex = 2
            Me.tbImageInfo.Text = ""
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label1.Location = New Global.System.Drawing.Point(184, 400)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(112, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Number of mipmaps:"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.lblMipMapCount.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.lblMipMapCount.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.lblMipMapCount.Location = New Global.System.Drawing.Point(294, 400)
            Me.lblMipMapCount.Name = "lblMipMapCount"
            Me.lblMipMapCount.Size = New Global.System.Drawing.Size(24, 16)
            Me.lblMipMapCount.TabIndex = 4
            Me.lblMipMapCount.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.Location = New Global.System.Drawing.Point(288, 416)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(24, 16)
            Me.Label2.TabIndex = 4
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.btnWriteFile.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnWriteFile.Location = New Global.System.Drawing.Point(248, 456)
            Me.btnWriteFile.Name = "btnWriteFile"
            Me.btnWriteFile.TabIndex = 0
            Me.btnWriteFile.Text = "Write File"
            Me.lblFlag1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.lblFlag1.Location = New Global.System.Drawing.Point(184, 432)
            Me.lblFlag1.Name = "lblFlag1"
            Me.lblFlag1.Size = New Global.System.Drawing.Size(20, 16)
            Me.lblFlag1.TabIndex = 5
            Me.lblFlag1.Text = "AA"
            Me.lblFlag1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblFlag2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.lblFlag2.Location = New Global.System.Drawing.Point(208, 432)
            Me.lblFlag2.Name = "lblFlag2"
            Me.lblFlag2.Size = New Global.System.Drawing.Size(20, 16)
            Me.lblFlag2.TabIndex = 6
            Me.lblFlag2.Text = "AA"
            Me.lblFlag2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblFlag3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.lblFlag3.Location = New Global.System.Drawing.Point(232, 432)
            Me.lblFlag3.Name = "lblFlag3"
            Me.lblFlag3.Size = New Global.System.Drawing.Size(20, 16)
            Me.lblFlag3.TabIndex = 7
            Me.lblFlag3.Text = "AA"
            Me.lblFlag3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblFlag4.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.lblFlag4.Location = New Global.System.Drawing.Point(256, 432)
            Me.lblFlag4.Name = "lblFlag4"
            Me.lblFlag4.Size = New Global.System.Drawing.Size(20, 16)
            Me.lblFlag4.TabIndex = 8
            Me.lblFlag4.Text = "AA"
            Me.lblFlag4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.chkbExportSelectionToTXIfile.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.chkbExportSelectionToTXIfile.Location = New Global.System.Drawing.Point(16, 472)
            Me.chkbExportSelectionToTXIfile.Name = "chkbExportSelectionToTXIfile"
            Me.chkbExportSelectionToTXIfile.Size = New Global.System.Drawing.Size(160, 16)
            Me.chkbExportSelectionToTXIfile.TabIndex = 9
            Me.chkbExportSelectionToTXIfile.Text = "Export Selection to TXI file"
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnOK
            Me.ClientSize = New Global.System.Drawing.Size(448, 493)
            Me.Controls.Add(Me.chkbExportSelectionToTXIfile)
            Me.Controls.Add(Me.lblFlag4)
            Me.Controls.Add(Me.lblFlag3)
            Me.Controls.Add(Me.lblFlag2)
            Me.Controls.Add(Me.lblFlag1)
            Me.Controls.Add(Me.lblMipMapCount)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.tbImageInfo)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnWriteFile)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MinimumSize = New Global.System.Drawing.Size(456, 472)
            Me.Name = "frmImageViewer"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Image Viewer"
            Me.Panel1.ResumeLayout(False)

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click
            AddHandler Me.btnWriteFile.Click, AddressOf Me.btnWriteFile_Click
            Me.ResumeLayout(False)
        End Sub

	End Class
End Namespace
