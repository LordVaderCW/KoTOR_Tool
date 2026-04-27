Namespace kotor_tool
	' Token: 0x0200004E RID: 78
	Public Partial Class frmImageViewer
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000553 RID: 1363 RVA: 0x00242FE0 File Offset: 0x00241FE0
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600056E RID: 1390 RVA: 0x002432E0 File Offset: 0x002422E0
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmImageViewer))
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
            Dim pbox As Global.System.Windows.Forms.Control = Me.pbox
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
            pbox.Location = point
            Me.pbox.Name = "pbox"
            Dim pbox2 As Global.System.Windows.Forms.Control = Me.pbox
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(96, 80)
            pbox2.Size = size
            Me.pbox.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbox.TabIndex = 0
            Me.pbox.TabStop = False
            Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.btnOK.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
            point = New Global.System.Drawing.Point(344, 456)
            btnOK.Location = point
            Me.btnOK.Name = "btnOK"
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "OK"
            Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.AutoScroll = True
            Me.Panel1.Controls.Add(Me.pbox)
            Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
            point = New Global.System.Drawing.Point(16, 16)
            panel.Location = point
            Me.Panel1.Name = "Panel1"
            Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
            size = New Global.System.Drawing.Size(416, 376)
            panel2.Size = size
            Me.Panel1.TabIndex = 1
            Me.tbImageInfo.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim tbImageInfo As Global.System.Windows.Forms.Control = Me.tbImageInfo
            point = New Global.System.Drawing.Point(16, 400)
            tbImageInfo.Location = point
            Me.tbImageInfo.Multiline = True
            Me.tbImageInfo.Name = "tbImageInfo"
            Dim tbImageInfo2 As Global.System.Windows.Forms.Control = Me.tbImageInfo
            size = New Global.System.Drawing.Size(160, 64)
            tbImageInfo2.Size = size
            Me.tbImageInfo.TabIndex = 2
            Me.tbImageInfo.Text = ""
            Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim label As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(184, 400)
            label.Location = point
            Me.Label1.Name = "Label1"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(112, 16)
            label2.Size = size
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Number of mipmaps:"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.lblMipMapCount.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.lblMipMapCount.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim lblMipMapCount As Global.System.Windows.Forms.Control = Me.lblMipMapCount
            point = New Global.System.Drawing.Point(294, 400)
            lblMipMapCount.Location = point
            Me.lblMipMapCount.Name = "lblMipMapCount"
            Dim lblMipMapCount2 As Global.System.Windows.Forms.Control = Me.lblMipMapCount
            size = New Global.System.Drawing.Size(24, 16)
            lblMipMapCount2.Size = size
            Me.lblMipMapCount.TabIndex = 4
            Me.lblMipMapCount.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(288, 416)
            label3.Location = point
            Me.Label2.Name = "Label2"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(24, 16)
            label4.Size = size
            Me.Label2.TabIndex = 4
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.btnWriteFile.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
            Dim btnWriteFile As Global.System.Windows.Forms.Control = Me.btnWriteFile
            point = New Global.System.Drawing.Point(248, 456)
            btnWriteFile.Location = point
            Me.btnWriteFile.Name = "btnWriteFile"
            Me.btnWriteFile.TabIndex = 0
            Me.btnWriteFile.Text = "Write File"
            Me.lblFlag1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim lblFlag As Global.System.Windows.Forms.Control = Me.lblFlag1
            point = New Global.System.Drawing.Point(184, 432)
            lblFlag.Location = point
            Me.lblFlag1.Name = "lblFlag1"
            Dim lblFlag2 As Global.System.Windows.Forms.Control = Me.lblFlag1
            size = New Global.System.Drawing.Size(20, 16)
            lblFlag2.Size = size
            Me.lblFlag1.TabIndex = 5
            Me.lblFlag1.Text = "AA"
            Me.lblFlag1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblFlag2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim lblFlag3 As Global.System.Windows.Forms.Control = Me.lblFlag2
            point = New Global.System.Drawing.Point(208, 432)
            lblFlag3.Location = point
            Me.lblFlag2.Name = "lblFlag2"
            Dim lblFlag4 As Global.System.Windows.Forms.Control = Me.lblFlag2
            size = New Global.System.Drawing.Size(20, 16)
            lblFlag4.Size = size
            Me.lblFlag2.TabIndex = 6
            Me.lblFlag2.Text = "AA"
            Me.lblFlag2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblFlag3.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim lblFlag5 As Global.System.Windows.Forms.Control = Me.lblFlag3
            point = New Global.System.Drawing.Point(232, 432)
            lblFlag5.Location = point
            Me.lblFlag3.Name = "lblFlag3"
            Dim lblFlag6 As Global.System.Windows.Forms.Control = Me.lblFlag3
            size = New Global.System.Drawing.Size(20, 16)
            lblFlag6.Size = size
            Me.lblFlag3.TabIndex = 7
            Me.lblFlag3.Text = "AA"
            Me.lblFlag3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.lblFlag4.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim lblFlag7 As Global.System.Windows.Forms.Control = Me.lblFlag4
            point = New Global.System.Drawing.Point(256, 432)
            lblFlag7.Location = point
            Me.lblFlag4.Name = "lblFlag4"
            Dim lblFlag8 As Global.System.Windows.Forms.Control = Me.lblFlag4
            size = New Global.System.Drawing.Size(20, 16)
            lblFlag8.Size = size
            Me.lblFlag4.TabIndex = 8
            Me.lblFlag4.Text = "AA"
            Me.lblFlag4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.chkbExportSelectionToTXIfile.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim chkbExportSelectionToTXIfile As Global.System.Windows.Forms.Control = Me.chkbExportSelectionToTXIfile
            point = New Global.System.Drawing.Point(16, 472)
            chkbExportSelectionToTXIfile.Location = point
            Me.chkbExportSelectionToTXIfile.Name = "chkbExportSelectionToTXIfile"
            Dim chkbExportSelectionToTXIfile2 As Global.System.Windows.Forms.Control = Me.chkbExportSelectionToTXIfile
            size = New Global.System.Drawing.Size(160, 16)
            chkbExportSelectionToTXIfile2.Size = size
            Me.chkbExportSelectionToTXIfile.TabIndex = 9
            Me.chkbExportSelectionToTXIfile.Text = "Export Selection to TXI file"
            Me.AcceptButton = Me.btnOK
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnOK
            size = New Global.System.Drawing.Size(448, 493)
            Me.ClientSize = size
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
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            size = New Global.System.Drawing.Size(456, 472)
            Me.MinimumSize = size
            Me.Name = "frmImageViewer"
            Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Image Viewer"
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x040002E1 RID: 737
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
