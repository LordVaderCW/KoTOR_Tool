Namespace kotor_tool
	' Token: 0x02000063 RID: 99
	Public Partial Class frmModuleItem_Base_Editor
		Inherits Global.kotor_tool.frmParent

		' Token: 0x06000B90 RID: 2960 RVA: 0x0027B854 File Offset: 0x0027A854
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000C49 RID: 3145 RVA: 0x0027CC04 File Offset: 0x0027BC04
        <Global.System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
            Dim resourceManager As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmModuleItem_Base_Editor))
            Me.tbXPosition = New Global.System.Windows.Forms.TextBox()
            Me.tbYPosition = New Global.System.Windows.Forms.TextBox()
            Me.tbZPosition = New Global.System.Windows.Forms.TextBox()
            Me.tbResRef = New Global.System.Windows.Forms.TextBox()
            Me.lblResRef = New Global.System.Windows.Forms.Label()
            Me.Label2 = New Global.System.Windows.Forms.Label()
            Me.Label3 = New Global.System.Windows.Forms.Label()
            Me.Label4 = New Global.System.Windows.Forms.Label()
            Me.pboxXY = New Global.System.Windows.Forms.PictureBox()
            Me.nudXY = New Global.System.Windows.Forms.NumericUpDown()
            Me.Button1 = New Global.System.Windows.Forms.Button()
            Me.Button2 = New Global.System.Windows.Forms.Button()
            Me.Button3 = New Global.System.Windows.Forms.Button()
            Me.tbTag = New Global.System.Windows.Forms.TextBox()
            Me.lblTag = New Global.System.Windows.Forms.Label()
            Me.tabctrl = New Global.System.Windows.Forms.TabControl()
            Me.tabpagGeneral = New Global.System.Windows.Forms.TabPage()
            Me.lblBearing = New Global.System.Windows.Forms.Label()
            Me.tabpagWaypoint = New Global.System.Windows.Forms.TabPage()
            Me.btnSetNameLang = New Global.System.Windows.Forms.Button()
            Me.chkbHasMapNote = New Global.System.Windows.Forms.CheckBox()
            Me.Label9 = New Global.System.Windows.Forms.Label()
            Me.tbWPLinkedTo = New Global.System.Windows.Forms.TextBox()
            Me.tbWpDescription = New Global.System.Windows.Forms.TextBox()
            Me.tbWpMapNote = New Global.System.Windows.Forms.TextBox()
            Me.Label11 = New Global.System.Windows.Forms.Label()
            Me.Label12 = New Global.System.Windows.Forms.Label()
            Me.tbWpLocalizedName = New Global.System.Windows.Forms.TextBox()
            Me.lblLocalizedName = New Global.System.Windows.Forms.Label()
            Me.chkbMapNoteEnabled = New Global.System.Windows.Forms.CheckBox()
            Me.tabpagEncounter = New Global.System.Windows.Forms.TabPage()
            Me.tbBearing = New Global.System.Windows.Forms.TextBox()
            Me.tbxo = New Global.System.Windows.Forms.TextBox()
            Me.tbyo = New Global.System.Windows.Forms.TextBox()
            Me.pboxXYSpawnPointBearing = New Global.System.Windows.Forms.PictureBox()
            Me.nudXYSpawnPointBearing = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label25 = New Global.System.Windows.Forms.Label()
            Me.Label26 = New Global.System.Windows.Forms.Label()
            Me.nudSpawnPointX = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label27 = New Global.System.Windows.Forms.Label()
            Me.nudSpawnPointY = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label28 = New Global.System.Windows.Forms.Label()
            Me.nudSpawnPointZ = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label24 = New Global.System.Windows.Forms.Label()
            Me.lbSpawnPoints = New Global.System.Windows.Forms.ListBox()
            Me.Label5 = New Global.System.Windows.Forms.Label()
            Me.Label6 = New Global.System.Windows.Forms.Label()
            Me.Label7 = New Global.System.Windows.Forms.Label()
            Me.tabpagDoor = New Global.System.Windows.Forms.TabPage()
            Me.gbTriggerNode = New Global.System.Windows.Forms.GroupBox()
            Me.Label23 = New Global.System.Windows.Forms.Label()
            Me.tbTriggerNodeYPosition = New Global.System.Windows.Forms.TextBox()
            Me.tbTriggerNodeXPosition = New Global.System.Windows.Forms.TextBox()
            Me.Label22 = New Global.System.Windows.Forms.Label()
            Me.tbTriggerNodeZPosition = New Global.System.Windows.Forms.TextBox()
            Me.Label21 = New Global.System.Windows.Forms.Label()
            Me.cmbxDoorLinkedToFlags = New Global.System.Windows.Forms.ComboBox()
            Me.lblDoorLinkedTo = New Global.System.Windows.Forms.Label()
            Me.tbDoorLinkedTo = New Global.System.Windows.Forms.TextBox()
            Me.tbDoorLinkedToModule = New Global.System.Windows.Forms.TextBox()
            Me.tbDoorLinkedToTransitionDestin = New Global.System.Windows.Forms.TextBox()
            Me.lblDoorLinkedToFlags = New Global.System.Windows.Forms.Label()
            Me.lblDoorLinkedToModule = New Global.System.Windows.Forms.Label()
            Me.lblDoorLinkedToTransitionDestin = New Global.System.Windows.Forms.Label()
            Me.lblTransitionMsg = New Global.System.Windows.Forms.Label()
            Me.tabpagCamera = New Global.System.Windows.Forms.TabPage()
            Me.Label29 = New Global.System.Windows.Forms.Label()
            Me.nudCamOrientationX = New Global.System.Windows.Forms.NumericUpDown()
            Me.btnShowQuaternion = New Global.System.Windows.Forms.Button()
            Me.Label1 = New Global.System.Windows.Forms.Label()
            Me.tbCamPitch = New Global.System.Windows.Forms.TextBox()
            Me.tbCamHeight = New Global.System.Windows.Forms.TextBox()
            Me.Label15 = New Global.System.Windows.Forms.Label()
            Me.tbCamMicRange = New Global.System.Windows.Forms.TextBox()
            Me.Label16 = New Global.System.Windows.Forms.Label()
            Me.Label17 = New Global.System.Windows.Forms.Label()
            Me.tbCamFieldOfView = New Global.System.Windows.Forms.TextBox()
            Me.tbCamOrientationF1 = New Global.System.Windows.Forms.TextBox()
            Me.tbCamOrientationF2 = New Global.System.Windows.Forms.TextBox()
            Me.tbCamOrientationF4 = New Global.System.Windows.Forms.TextBox()
            Me.tbCamOrientationF3 = New Global.System.Windows.Forms.TextBox()
            Me.lblQuaternionW = New Global.System.Windows.Forms.Label()
            Me.Label18 = New Global.System.Windows.Forms.Label()
            Me.Label19 = New Global.System.Windows.Forms.Label()
            Me.Label20 = New Global.System.Windows.Forms.Label()
            Me.tbCamOrientationZ = New Global.System.Windows.Forms.TextBox()
            Me.tbCamOrientationX = New Global.System.Windows.Forms.TextBox()
            Me.tbCamOrientationY = New Global.System.Windows.Forms.TextBox()
            Me.nudCamOrientationY = New Global.System.Windows.Forms.NumericUpDown()
            Me.nudCamOrientationZ = New Global.System.Windows.Forms.NumericUpDown()
            Me.Label14 = New Global.System.Windows.Forms.Label()
            Me.ErrorProvider1 = New Global.System.Windows.Forms.ErrorProvider()
            CType(Me.nudXY, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabctrl.SuspendLayout()
            Me.tabpagGeneral.SuspendLayout()
            Me.tabpagWaypoint.SuspendLayout()
            Me.tabpagEncounter.SuspendLayout()
            CType(Me.nudXYSpawnPointBearing, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSpawnPointX, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSpawnPointY, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSpawnPointZ, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagDoor.SuspendLayout()
            Me.gbTriggerNode.SuspendLayout()
            Me.tabpagCamera.SuspendLayout()
            CType(Me.nudCamOrientationX, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCamOrientationY, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCamOrientationZ, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Dim tbXPosition As Global.System.Windows.Forms.Control = Me.tbXPosition
            Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(152, 80)
            tbXPosition.Location = point
            Me.tbXPosition.Name = "tbXPosition"
            Me.tbXPosition.TabIndex = 0
            Me.tbXPosition.Text = ""
            Me.tbXPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim tbYPosition As Global.System.Windows.Forms.Control = Me.tbYPosition
            point = New Global.System.Drawing.Point(152, 112)
            tbYPosition.Location = point
            Me.tbYPosition.Name = "tbYPosition"
            Me.tbYPosition.TabIndex = 0
            Me.tbYPosition.Text = ""
            Me.tbYPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim tbZPosition As Global.System.Windows.Forms.Control = Me.tbZPosition
            point = New Global.System.Drawing.Point(152, 144)
            tbZPosition.Location = point
            Me.tbZPosition.Name = "tbZPosition"
            Me.tbZPosition.TabIndex = 0
            Me.tbZPosition.Text = ""
            Me.tbZPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim tbResRef As Global.System.Windows.Forms.Control = Me.tbResRef
            point = New Global.System.Drawing.Point(152, 16)
            tbResRef.Location = point
            Me.tbResRef.MaxLength = 16
            Me.tbResRef.Name = "tbResRef"
            Dim tbResRef2 As Global.System.Windows.Forms.Control = Me.tbResRef
            Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(184, 20)
            tbResRef2.Size = size
            Me.tbResRef.TabIndex = 0
            Me.tbResRef.Text = ""
            Dim lblResRef As Global.System.Windows.Forms.Control = Me.lblResRef
            point = New Global.System.Drawing.Point(40, 16)
            lblResRef.Location = point
            Me.lblResRef.Name = "lblResRef"
            Dim lblResRef2 As Global.System.Windows.Forms.Control = Me.lblResRef
            size = New Global.System.Drawing.Size(96, 16)
            lblResRef2.Size = size
            Me.lblResRef.TabIndex = 1
            Me.lblResRef.Text = "TemplateResRef"
            Me.lblResRef.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label As Global.System.Windows.Forms.Control = Me.Label2
            point = New Global.System.Drawing.Point(40, 80)
            label.Location = point
            Me.Label2.Name = "Label2"
            Dim label2 As Global.System.Windows.Forms.Control = Me.Label2
            size = New Global.System.Drawing.Size(88, 16)
            label2.Size = size
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "X Position"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label3 As Global.System.Windows.Forms.Control = Me.Label3
            point = New Global.System.Drawing.Point(40, 112)
            label3.Location = point
            Me.Label3.Name = "Label3"
            Dim label4 As Global.System.Windows.Forms.Control = Me.Label3
            size = New Global.System.Drawing.Size(88, 16)
            label4.Size = size
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Y Position"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label5 As Global.System.Windows.Forms.Control = Me.Label4
            point = New Global.System.Drawing.Point(40, 144)
            label5.Location = point
            Me.Label4.Name = "Label4"
            Dim label6 As Global.System.Windows.Forms.Control = Me.Label4
            size = New Global.System.Drawing.Size(88, 16)
            label6.Size = size
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Z Position"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim pboxXY As Global.System.Windows.Forms.Control = Me.pboxXY
            point = New Global.System.Drawing.Point(280, 104)
            pboxXY.Location = point
            Me.pboxXY.Name = "pboxXY"
            Dim pboxXY2 As Global.System.Windows.Forms.Control = Me.pboxXY
            size = New Global.System.Drawing.Size(50, 50)
            pboxXY2.Size = size
            Me.pboxXY.TabIndex = 2
            Me.pboxXY.TabStop = False
            Me.nudXY.DecimalPlaces = 2
            Dim nudXY As Global.System.Windows.Forms.Control = Me.nudXY
            point = New Global.System.Drawing.Point(277, 160)
            nudXY.Location = point
            Dim nudXY2 As Global.System.Windows.Forms.NumericUpDown = Me.nudXY
            Dim num As Decimal = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            nudXY2.Maximum = num
            Me.nudXY.Name = "nudXY"
            Dim nudXY3 As Global.System.Windows.Forms.Control = Me.nudXY
            size = New Global.System.Drawing.Size(64, 20)
            nudXY3.Size = size
            Me.nudXY.TabIndex = 4
            Me.nudXY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
            Dim button As Global.System.Windows.Forms.Control = Me.Button1
            point = New Global.System.Drawing.Point(40, 352)
            button.Location = point
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 5
            Me.Button1.Text = "Button1"
            Me.Button1.Visible = False
            Me.Button2.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Dim button2 As Global.System.Windows.Forms.Control = Me.Button2
            point = New Global.System.Drawing.Point(296, 352)
            button2.Location = point
            Me.Button2.Name = "Button2"
            Me.Button2.TabIndex = 5
            Me.Button2.Text = "OK"
            Me.Button3.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Dim button3 As Global.System.Windows.Forms.Control = Me.Button3
            point = New Global.System.Drawing.Point(392, 352)
            button3.Location = point
            Me.Button3.Name = "Button3"
            Me.Button3.TabIndex = 5
            Me.Button3.Text = "Cancel"
            Dim tbTag As Global.System.Windows.Forms.Control = Me.tbTag
            point = New Global.System.Drawing.Point(152, 48)
            tbTag.Location = point
            Me.tbTag.MaxLength = 16
            Me.tbTag.Name = "tbTag"
            Dim tbTag2 As Global.System.Windows.Forms.Control = Me.tbTag
            size = New Global.System.Drawing.Size(184, 20)
            tbTag2.Size = size
            Me.tbTag.TabIndex = 0
            Me.tbTag.Text = ""
            Dim lblTag As Global.System.Windows.Forms.Control = Me.lblTag
            point = New Global.System.Drawing.Point(40, 48)
            lblTag.Location = point
            Me.lblTag.Name = "lblTag"
            Dim lblTag2 As Global.System.Windows.Forms.Control = Me.lblTag
            size = New Global.System.Drawing.Size(96, 16)
            lblTag2.Size = size
            Me.lblTag.TabIndex = 1
            Me.lblTag.Text = "Tag"
            Me.lblTag.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tabctrl.Controls.Add(Me.tabpagGeneral)
            Me.tabctrl.Controls.Add(Me.tabpagWaypoint)
            Me.tabctrl.Controls.Add(Me.tabpagDoor)
            Me.tabctrl.Controls.Add(Me.tabpagEncounter)
            Me.tabctrl.Controls.Add(Me.tabpagCamera)
            Dim tabctrl As Global.System.Windows.Forms.Control = Me.tabctrl
            point = New Global.System.Drawing.Point(8, 8)
            tabctrl.Location = point
            Me.tabctrl.Name = "tabctrl"
            Me.tabctrl.SelectedIndex = 0
            Dim tabctrl2 As Global.System.Windows.Forms.Control = Me.tabctrl
            size = New Global.System.Drawing.Size(480, 328)
            tabctrl2.Size = size
            Me.tabctrl.TabIndex = 6
            Me.tabpagGeneral.Controls.Add(Me.tbXPosition)
            Me.tabpagGeneral.Controls.Add(Me.tbYPosition)
            Me.tabpagGeneral.Controls.Add(Me.tbZPosition)
            Me.tabpagGeneral.Controls.Add(Me.tbTag)
            Me.tabpagGeneral.Controls.Add(Me.tbResRef)
            Me.tabpagGeneral.Controls.Add(Me.lblTag)
            Me.tabpagGeneral.Controls.Add(Me.lblResRef)
            Me.tabpagGeneral.Controls.Add(Me.Label2)
            Me.tabpagGeneral.Controls.Add(Me.Label3)
            Me.tabpagGeneral.Controls.Add(Me.Label4)
            Me.tabpagGeneral.Controls.Add(Me.pboxXY)
            Me.tabpagGeneral.Controls.Add(Me.nudXY)
            Me.tabpagGeneral.Controls.Add(Me.lblBearing)
            Dim tabpagGeneral As Global.System.Windows.Forms.Control = Me.tabpagGeneral
            point = New Global.System.Drawing.Point(4, 22)
            tabpagGeneral.Location = point
            Me.tabpagGeneral.Name = "tabpagGeneral"
            Dim tabpagGeneral2 As Global.System.Windows.Forms.Control = Me.tabpagGeneral
            size = New Global.System.Drawing.Size(472, 302)
            tabpagGeneral2.Size = size
            Me.tabpagGeneral.TabIndex = 1
            Me.tabpagGeneral.Text = "General"
            Dim lblBearing As Global.System.Windows.Forms.Control = Me.lblBearing
            point = New Global.System.Drawing.Point(281, 80)
            lblBearing.Location = point
            Me.lblBearing.Name = "lblBearing"
            Dim lblBearing2 As Global.System.Windows.Forms.Control = Me.lblBearing
            size = New Global.System.Drawing.Size(48, 16)
            lblBearing2.Size = size
            Me.lblBearing.TabIndex = 1
            Me.lblBearing.Text = "Bearing"
            Me.lblBearing.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.tabpagWaypoint.Controls.Add(Me.btnSetNameLang)
            Me.tabpagWaypoint.Controls.Add(Me.chkbHasMapNote)
            Me.tabpagWaypoint.Controls.Add(Me.Label9)
            Me.tabpagWaypoint.Controls.Add(Me.tbWPLinkedTo)
            Me.tabpagWaypoint.Controls.Add(Me.tbWpDescription)
            Me.tabpagWaypoint.Controls.Add(Me.tbWpMapNote)
            Me.tabpagWaypoint.Controls.Add(Me.Label11)
            Me.tabpagWaypoint.Controls.Add(Me.Label12)
            Me.tabpagWaypoint.Controls.Add(Me.tbWpLocalizedName)
            Me.tabpagWaypoint.Controls.Add(Me.lblLocalizedName)
            Me.tabpagWaypoint.Controls.Add(Me.chkbMapNoteEnabled)
            Dim tabpagWaypoint As Global.System.Windows.Forms.Control = Me.tabpagWaypoint
            point = New Global.System.Drawing.Point(4, 22)
            tabpagWaypoint.Location = point
            Me.tabpagWaypoint.Name = "tabpagWaypoint"
            Dim tabpagWaypoint2 As Global.System.Windows.Forms.Control = Me.tabpagWaypoint
            size = New Global.System.Drawing.Size(472, 302)
            tabpagWaypoint2.Size = size
            Me.tabpagWaypoint.TabIndex = 3
            Me.tabpagWaypoint.Text = "Waypoint Specific"
            Me.btnSetNameLang.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Dim btnSetNameLang As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            point = New Global.System.Drawing.Point(296, 264)
            btnSetNameLang.Location = point
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Dim btnSetNameLang2 As Global.System.Windows.Forms.Control = Me.btnSetNameLang
            size = New Global.System.Drawing.Size(88, 23)
            btnSetNameLang2.Size = size
            Me.btnSetNameLang.TabIndex = 10
            Me.btnSetNameLang.Text = "Set Language"
            Dim chkbHasMapNote As Global.System.Windows.Forms.Control = Me.chkbHasMapNote
            point = New Global.System.Drawing.Point(48, 168)
            chkbHasMapNote.Location = point
            Me.chkbHasMapNote.Name = "chkbHasMapNote"
            Dim chkbHasMapNote2 As Global.System.Windows.Forms.Control = Me.chkbHasMapNote
            size = New Global.System.Drawing.Size(192, 24)
            chkbHasMapNote2.Size = size
            Me.chkbHasMapNote.TabIndex = 9
            Me.chkbHasMapNote.Text = "Waypoint Contains a Map Note"
            Dim label7 As Global.System.Windows.Forms.Control = Me.Label9
            point = New Global.System.Drawing.Point(48, 16)
            label7.Location = point
            Me.Label9.Name = "Label9"
            Dim label8 As Global.System.Windows.Forms.Control = Me.Label9
            size = New Global.System.Drawing.Size(100, 16)
            label8.Size = size
            Me.Label9.TabIndex = 8
            Me.Label9.Text = "Linked To"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbWPLinkedTo As Global.System.Windows.Forms.Control = Me.tbWPLinkedTo
            point = New Global.System.Drawing.Point(176, 16)
            tbWPLinkedTo.Location = point
            Me.tbWPLinkedTo.Name = "tbWPLinkedTo"
            Dim tbWPLinkedTo2 As Global.System.Windows.Forms.Control = Me.tbWPLinkedTo
            size = New Global.System.Drawing.Size(208, 20)
            tbWPLinkedTo2.Size = size
            Me.tbWPLinkedTo.TabIndex = 5
            Me.tbWPLinkedTo.Text = ""
            Dim tbWpDescription As Global.System.Windows.Forms.Control = Me.tbWpDescription
            point = New Global.System.Drawing.Point(176, 96)
            tbWpDescription.Location = point
            Me.tbWpDescription.Multiline = True
            Me.tbWpDescription.Name = "tbWpDescription"
            Dim tbWpDescription2 As Global.System.Windows.Forms.Control = Me.tbWpDescription
            size = New Global.System.Drawing.Size(208, 60)
            tbWpDescription2.Size = size
            Me.tbWpDescription.TabIndex = 2
            Me.tbWpDescription.Text = ""
            Dim tbWpMapNote As Global.System.Windows.Forms.Control = Me.tbWpMapNote
            point = New Global.System.Drawing.Point(176, 192)
            tbWpMapNote.Location = point
            Me.tbWpMapNote.Multiline = True
            Me.tbWpMapNote.Name = "tbWpMapNote"
            Dim tbWpMapNote2 As Global.System.Windows.Forms.Control = Me.tbWpMapNote
            size = New Global.System.Drawing.Size(208, 60)
            tbWpMapNote2.Size = size
            Me.tbWpMapNote.TabIndex = 3
            Me.tbWpMapNote.Text = ""
            Dim label9 As Global.System.Windows.Forms.Control = Me.Label11
            point = New Global.System.Drawing.Point(48, 96)
            label9.Location = point
            Me.Label11.Name = "Label11"
            Dim label10 As Global.System.Windows.Forms.Control = Me.Label11
            size = New Global.System.Drawing.Size(100, 16)
            label10.Size = size
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Description"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label11 As Global.System.Windows.Forms.Control = Me.Label12
            point = New Global.System.Drawing.Point(48, 208)
            label11.Location = point
            Me.Label12.Name = "Label12"
            Dim label12 As Global.System.Windows.Forms.Control = Me.Label12
            size = New Global.System.Drawing.Size(120, 16)
            label12.Size = size
            Me.Label12.TabIndex = 7
            Me.Label12.Text = "Map Note"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbWpLocalizedName As Global.System.Windows.Forms.Control = Me.tbWpLocalizedName
            point = New Global.System.Drawing.Point(176, 56)
            tbWpLocalizedName.Location = point
            Me.tbWpLocalizedName.Name = "tbWpLocalizedName"
            Dim tbWpLocalizedName2 As Global.System.Windows.Forms.Control = Me.tbWpLocalizedName
            size = New Global.System.Drawing.Size(208, 20)
            tbWpLocalizedName2.Size = size
            Me.tbWpLocalizedName.TabIndex = 2
            Me.tbWpLocalizedName.Text = ""
            Dim lblLocalizedName As Global.System.Windows.Forms.Control = Me.lblLocalizedName
            point = New Global.System.Drawing.Point(48, 56)
            lblLocalizedName.Location = point
            Me.lblLocalizedName.Name = "lblLocalizedName"
            Dim lblLocalizedName2 As Global.System.Windows.Forms.Control = Me.lblLocalizedName
            size = New Global.System.Drawing.Size(100, 16)
            lblLocalizedName2.Size = size
            Me.lblLocalizedName.TabIndex = 6
            Me.lblLocalizedName.Text = "Localized Name"
            Me.lblLocalizedName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim chkbMapNoteEnabled As Global.System.Windows.Forms.Control = Me.chkbMapNoteEnabled
            point = New Global.System.Drawing.Point(256, 168)
            chkbMapNoteEnabled.Location = point
            Me.chkbMapNoteEnabled.Name = "chkbMapNoteEnabled"
            Dim chkbMapNoteEnabled2 As Global.System.Windows.Forms.Control = Me.chkbMapNoteEnabled
            size = New Global.System.Drawing.Size(128, 24)
            chkbMapNoteEnabled2.Size = size
            Me.chkbMapNoteEnabled.TabIndex = 9
            Me.chkbMapNoteEnabled.Text = "Map Note Enabled"
            Me.tabpagEncounter.Controls.Add(Me.tbBearing)
            Me.tabpagEncounter.Controls.Add(Me.tbxo)
            Me.tabpagEncounter.Controls.Add(Me.tbyo)
            Me.tabpagEncounter.Controls.Add(Me.pboxXYSpawnPointBearing)
            Me.tabpagEncounter.Controls.Add(Me.nudXYSpawnPointBearing)
            Me.tabpagEncounter.Controls.Add(Me.Label25)
            Me.tabpagEncounter.Controls.Add(Me.Label26)
            Me.tabpagEncounter.Controls.Add(Me.nudSpawnPointX)
            Me.tabpagEncounter.Controls.Add(Me.Label27)
            Me.tabpagEncounter.Controls.Add(Me.nudSpawnPointY)
            Me.tabpagEncounter.Controls.Add(Me.Label28)
            Me.tabpagEncounter.Controls.Add(Me.nudSpawnPointZ)
            Me.tabpagEncounter.Controls.Add(Me.Label24)
            Me.tabpagEncounter.Controls.Add(Me.lbSpawnPoints)
            Me.tabpagEncounter.Controls.Add(Me.Label5)
            Me.tabpagEncounter.Controls.Add(Me.Label6)
            Me.tabpagEncounter.Controls.Add(Me.Label7)
            Dim tabpagEncounter As Global.System.Windows.Forms.Control = Me.tabpagEncounter
            point = New Global.System.Drawing.Point(4, 22)
            tabpagEncounter.Location = point
            Me.tabpagEncounter.Name = "tabpagEncounter"
            Dim tabpagEncounter2 As Global.System.Windows.Forms.Control = Me.tabpagEncounter
            size = New Global.System.Drawing.Size(472, 302)
            tabpagEncounter2.Size = size
            Me.tabpagEncounter.TabIndex = 5
            Me.tabpagEncounter.Text = "Encounter Specific"
            Dim tbBearing As Global.System.Windows.Forms.Control = Me.tbBearing
            point = New Global.System.Drawing.Point(96, 248)
            tbBearing.Location = point
            Me.tbBearing.Name = "tbBearing"
            Me.tbBearing.[ReadOnly] = True
            Dim tbBearing2 As Global.System.Windows.Forms.Control = Me.tbBearing
            size = New Global.System.Drawing.Size(104, 20)
            tbBearing2.Size = size
            Me.tbBearing.TabIndex = 55
            Me.tbBearing.Text = ""
            Me.tbBearing.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbBearing.Visible = False
            Dim tbxo As Global.System.Windows.Forms.Control = Me.tbxo
            point = New Global.System.Drawing.Point(96, 192)
            tbxo.Location = point
            Me.tbxo.Name = "tbxo"
            Me.tbxo.[ReadOnly] = True
            Dim tbxo2 As Global.System.Windows.Forms.Control = Me.tbxo
            size = New Global.System.Drawing.Size(64, 20)
            tbxo2.Size = size
            Me.tbxo.TabIndex = 54
            Me.tbxo.Text = ""
            Me.tbxo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbxo.Visible = False
            Dim tbyo As Global.System.Windows.Forms.Control = Me.tbyo
            point = New Global.System.Drawing.Point(96, 216)
            tbyo.Location = point
            Me.tbyo.Name = "tbyo"
            Me.tbyo.[ReadOnly] = True
            Dim tbyo2 As Global.System.Windows.Forms.Control = Me.tbyo
            size = New Global.System.Drawing.Size(64, 20)
            tbyo2.Size = size
            Me.tbyo.TabIndex = 53
            Me.tbyo.Text = ""
            Me.tbyo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbyo.Visible = False
            Dim pboxXYSpawnPointBearing As Global.System.Windows.Forms.Control = Me.pboxXYSpawnPointBearing
            point = New Global.System.Drawing.Point(336, 80)
            pboxXYSpawnPointBearing.Location = point
            Me.pboxXYSpawnPointBearing.Name = "pboxXYSpawnPointBearing"
            Dim pboxXYSpawnPointBearing2 As Global.System.Windows.Forms.Control = Me.pboxXYSpawnPointBearing
            size = New Global.System.Drawing.Size(50, 50)
            pboxXYSpawnPointBearing2.Size = size
            Me.pboxXYSpawnPointBearing.TabIndex = 51
            Me.pboxXYSpawnPointBearing.TabStop = False
            Me.nudXYSpawnPointBearing.DecimalPlaces = 2
            Me.nudXYSpawnPointBearing.Enabled = False
            Dim nudXYSpawnPointBearing As Global.System.Windows.Forms.Control = Me.nudXYSpawnPointBearing
            point = New Global.System.Drawing.Point(328, 136)
            nudXYSpawnPointBearing.Location = point
            Dim nudXYSpawnPointBearing2 As Global.System.Windows.Forms.NumericUpDown = Me.nudXYSpawnPointBearing
            num = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            nudXYSpawnPointBearing2.Maximum = num
            Me.nudXYSpawnPointBearing.Name = "nudXYSpawnPointBearing"
            Dim nudXYSpawnPointBearing3 As Global.System.Windows.Forms.Control = Me.nudXYSpawnPointBearing
            size = New Global.System.Drawing.Size(64, 20)
            nudXYSpawnPointBearing3.Size = size
            Me.nudXYSpawnPointBearing.TabIndex = 52
            Me.nudXYSpawnPointBearing.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
            Dim label13 As Global.System.Windows.Forms.Control = Me.Label25
            point = New Global.System.Drawing.Point(336, 56)
            label13.Location = point
            Me.Label25.Name = "Label25"
            Dim label14 As Global.System.Windows.Forms.Control = Me.Label25
            size = New Global.System.Drawing.Size(48, 16)
            label14.Size = size
            Me.Label25.TabIndex = 50
            Me.Label25.Text = "Bearing"
            Me.Label25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Dim label15 As Global.System.Windows.Forms.Control = Me.Label26
            point = New Global.System.Drawing.Point(168, 64)
            label15.Location = point
            Me.Label26.Name = "Label26"
            Dim label16 As Global.System.Windows.Forms.Control = Me.Label26
            size = New Global.System.Drawing.Size(16, 16)
            label16.Size = size
            Me.Label26.TabIndex = 48
            Me.Label26.Text = "X"
            Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudSpawnPointX.DecimalPlaces = 4
            Me.nudSpawnPointX.Enabled = False
            Dim nudSpawnPointX As Global.System.Windows.Forms.Control = Me.nudSpawnPointX
            point = New Global.System.Drawing.Point(200, 64)
            nudSpawnPointX.Location = point
            Dim nudSpawnPointX2 As Global.System.Windows.Forms.NumericUpDown = Me.nudSpawnPointX
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            nudSpawnPointX2.Maximum = num
            Dim nudSpawnPointX3 As Global.System.Windows.Forms.NumericUpDown = Me.nudSpawnPointX
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            nudSpawnPointX3.Minimum = num
            Me.nudSpawnPointX.Name = "nudSpawnPointX"
            Dim nudSpawnPointX4 As Global.System.Windows.Forms.Control = Me.nudSpawnPointX
            size = New Global.System.Drawing.Size(96, 20)
            nudSpawnPointX4.Size = size
            Me.nudSpawnPointX.TabIndex = 44
            Me.nudSpawnPointX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label17 As Global.System.Windows.Forms.Control = Me.Label27
            point = New Global.System.Drawing.Point(168, 96)
            label17.Location = point
            Me.Label27.Name = "Label27"
            Dim label18 As Global.System.Windows.Forms.Control = Me.Label27
            size = New Global.System.Drawing.Size(16, 16)
            label18.Size = size
            Me.Label27.TabIndex = 49
            Me.Label27.Text = "Y"
            Me.Label27.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudSpawnPointY.DecimalPlaces = 4
            Me.nudSpawnPointY.Enabled = False
            Dim nudSpawnPointY As Global.System.Windows.Forms.Control = Me.nudSpawnPointY
            point = New Global.System.Drawing.Point(200, 96)
            nudSpawnPointY.Location = point
            Dim nudSpawnPointY2 As Global.System.Windows.Forms.NumericUpDown = Me.nudSpawnPointY
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            nudSpawnPointY2.Maximum = num
            Dim nudSpawnPointY3 As Global.System.Windows.Forms.NumericUpDown = Me.nudSpawnPointY
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            nudSpawnPointY3.Minimum = num
            Me.nudSpawnPointY.Name = "nudSpawnPointY"
            Dim nudSpawnPointY4 As Global.System.Windows.Forms.Control = Me.nudSpawnPointY
            size = New Global.System.Drawing.Size(96, 20)
            nudSpawnPointY4.Size = size
            Me.nudSpawnPointY.TabIndex = 45
            Me.nudSpawnPointY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label19 As Global.System.Windows.Forms.Control = Me.Label28
            point = New Global.System.Drawing.Point(168, 128)
            label19.Location = point
            Me.Label28.Name = "Label28"
            Dim label20 As Global.System.Windows.Forms.Control = Me.Label28
            size = New Global.System.Drawing.Size(16, 16)
            label20.Size = size
            Me.Label28.TabIndex = 47
            Me.Label28.Text = "Z"
            Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudSpawnPointZ.DecimalPlaces = 4
            Me.nudSpawnPointZ.Enabled = False
            Dim nudSpawnPointZ As Global.System.Windows.Forms.Control = Me.nudSpawnPointZ
            point = New Global.System.Drawing.Point(200, 128)
            nudSpawnPointZ.Location = point
            Dim nudSpawnPointZ2 As Global.System.Windows.Forms.NumericUpDown = Me.nudSpawnPointZ
            num = New Decimal(New Integer() {4000, 0, 0, 0})
            nudSpawnPointZ2.Maximum = num
            Dim nudSpawnPointZ3 As Global.System.Windows.Forms.NumericUpDown = Me.nudSpawnPointZ
            num = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            nudSpawnPointZ3.Minimum = num
            Me.nudSpawnPointZ.Name = "nudSpawnPointZ"
            Dim nudSpawnPointZ4 As Global.System.Windows.Forms.Control = Me.nudSpawnPointZ
            size = New Global.System.Drawing.Size(96, 20)
            nudSpawnPointZ4.Size = size
            Me.nudSpawnPointZ.TabIndex = 46
            Me.nudSpawnPointZ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label21 As Global.System.Windows.Forms.Control = Me.Label24
            point = New Global.System.Drawing.Point(72, 32)
            label21.Location = point
            Me.Label24.Name = "Label24"
            Dim label22 As Global.System.Windows.Forms.Control = Me.Label24
            size = New Global.System.Drawing.Size(80, 16)
            label22.Size = size
            Me.Label24.TabIndex = 43
            Me.Label24.Text = "Spawn Points"
            Dim lbSpawnPoints As Global.System.Windows.Forms.Control = Me.lbSpawnPoints
            point = New Global.System.Drawing.Point(80, 56)
            lbSpawnPoints.Location = point
            Me.lbSpawnPoints.Name = "lbSpawnPoints"
            Me.lbSpawnPoints.ScrollAlwaysVisible = True
            Dim lbSpawnPoints2 As Global.System.Windows.Forms.Control = Me.lbSpawnPoints
            size = New Global.System.Drawing.Size(56, 95)
            lbSpawnPoints2.Size = size
            Me.lbSpawnPoints.TabIndex = 42
            Dim label23 As Global.System.Windows.Forms.Control = Me.Label5
            point = New Global.System.Drawing.Point(64, 192)
            label23.Location = point
            Me.Label5.Name = "Label5"
            Dim label24 As Global.System.Windows.Forms.Control = Me.Label5
            size = New Global.System.Drawing.Size(16, 16)
            label24.Size = size
            Me.Label5.TabIndex = 48
            Me.Label5.Text = "X"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label5.Visible = False
            Dim label25 As Global.System.Windows.Forms.Control = Me.Label6
            point = New Global.System.Drawing.Point(64, 216)
            label25.Location = point
            Me.Label6.Name = "Label6"
            Dim label26 As Global.System.Windows.Forms.Control = Me.Label6
            size = New Global.System.Drawing.Size(16, 16)
            label26.Size = size
            Me.Label6.TabIndex = 49
            Me.Label6.Text = "Y"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label6.Visible = False
            Dim label27 As Global.System.Windows.Forms.Control = Me.Label7
            point = New Global.System.Drawing.Point(224, 40)
            label27.Location = point
            Me.Label7.Name = "Label7"
            Dim label28 As Global.System.Windows.Forms.Control = Me.Label7
            size = New Global.System.Drawing.Size(48, 16)
            label28.Size = size
            Me.Label7.TabIndex = 50
            Me.Label7.Text = "Position"
            Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.tabpagDoor.Controls.Add(Me.gbTriggerNode)
            Me.tabpagDoor.Controls.Add(Me.cmbxDoorLinkedToFlags)
            Me.tabpagDoor.Controls.Add(Me.lblDoorLinkedTo)
            Me.tabpagDoor.Controls.Add(Me.tbDoorLinkedTo)
            Me.tabpagDoor.Controls.Add(Me.tbDoorLinkedToModule)
            Me.tabpagDoor.Controls.Add(Me.tbDoorLinkedToTransitionDestin)
            Me.tabpagDoor.Controls.Add(Me.lblDoorLinkedToFlags)
            Me.tabpagDoor.Controls.Add(Me.lblDoorLinkedToModule)
            Me.tabpagDoor.Controls.Add(Me.lblDoorLinkedToTransitionDestin)
            Me.tabpagDoor.Controls.Add(Me.lblTransitionMsg)
            Dim tabpagDoor As Global.System.Windows.Forms.Control = Me.tabpagDoor
            point = New Global.System.Drawing.Point(4, 22)
            tabpagDoor.Location = point
            Me.tabpagDoor.Name = "tabpagDoor"
            Dim tabpagDoor2 As Global.System.Windows.Forms.Control = Me.tabpagDoor
            size = New Global.System.Drawing.Size(472, 302)
            tabpagDoor2.Size = size
            Me.tabpagDoor.TabIndex = 0
            Me.tabpagDoor.Text = "Door/Trigger Specific"
            Me.gbTriggerNode.Controls.Add(Me.Label23)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeYPosition)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeXPosition)
            Me.gbTriggerNode.Controls.Add(Me.Label22)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeZPosition)
            Me.gbTriggerNode.Controls.Add(Me.Label21)
            Dim gbTriggerNode As Global.System.Windows.Forms.Control = Me.gbTriggerNode
            point = New Global.System.Drawing.Point(16, 176)
            gbTriggerNode.Location = point
            Me.gbTriggerNode.Name = "gbTriggerNode"
            Dim gbTriggerNode2 As Global.System.Windows.Forms.Control = Me.gbTriggerNode
            size = New Global.System.Drawing.Size(304, 120)
            gbTriggerNode2.Size = size
            Me.gbTriggerNode.TabIndex = 9
            Me.gbTriggerNode.TabStop = False
            Me.gbTriggerNode.Text = "Trigger Node"
            Me.gbTriggerNode.Visible = False
            Dim label29 As Global.System.Windows.Forms.Control = Me.Label23
            point = New Global.System.Drawing.Point(24, 88)
            label29.Location = point
            Me.Label23.Name = "Label23"
            Dim label30 As Global.System.Windows.Forms.Control = Me.Label23
            size = New Global.System.Drawing.Size(88, 16)
            label30.Size = size
            Me.Label23.TabIndex = 6
            Me.Label23.Text = "Z Position"
            Me.Label23.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbTriggerNodeYPosition As Global.System.Windows.Forms.Control = Me.tbTriggerNodeYPosition
            point = New Global.System.Drawing.Point(136, 56)
            tbTriggerNodeYPosition.Location = point
            Me.tbTriggerNodeYPosition.Name = "tbTriggerNodeYPosition"
            Me.tbTriggerNodeYPosition.TabIndex = 4
            Me.tbTriggerNodeYPosition.Text = ""
            Me.tbTriggerNodeYPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim tbTriggerNodeXPosition As Global.System.Windows.Forms.Control = Me.tbTriggerNodeXPosition
            point = New Global.System.Drawing.Point(136, 24)
            tbTriggerNodeXPosition.Location = point
            Me.tbTriggerNodeXPosition.Name = "tbTriggerNodeXPosition"
            Me.tbTriggerNodeXPosition.TabIndex = 5
            Me.tbTriggerNodeXPosition.Text = ""
            Me.tbTriggerNodeXPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label31 As Global.System.Windows.Forms.Control = Me.Label22
            point = New Global.System.Drawing.Point(24, 56)
            label31.Location = point
            Me.Label22.Name = "Label22"
            Dim label32 As Global.System.Windows.Forms.Control = Me.Label22
            size = New Global.System.Drawing.Size(88, 16)
            label32.Size = size
            Me.Label22.TabIndex = 7
            Me.Label22.Text = "Y Position"
            Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbTriggerNodeZPosition As Global.System.Windows.Forms.Control = Me.tbTriggerNodeZPosition
            point = New Global.System.Drawing.Point(136, 88)
            tbTriggerNodeZPosition.Location = point
            Me.tbTriggerNodeZPosition.Name = "tbTriggerNodeZPosition"
            Me.tbTriggerNodeZPosition.TabIndex = 3
            Me.tbTriggerNodeZPosition.Text = ""
            Me.tbTriggerNodeZPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label33 As Global.System.Windows.Forms.Control = Me.Label21
            point = New Global.System.Drawing.Point(24, 24)
            label33.Location = point
            Me.Label21.Name = "Label21"
            Dim label34 As Global.System.Windows.Forms.Control = Me.Label21
            size = New Global.System.Drawing.Size(88, 16)
            label34.Size = size
            Me.Label21.TabIndex = 8
            Me.Label21.Text = "X Position"
            Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxDoorLinkedToFlags.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxDoorLinkedToFlags.Items.AddRange(New Object() {"Does not link to anything", "Is an Area Transition and links to a Door", "Is an Area Transition and links to a Waypoint"})
            Dim cmbxDoorLinkedToFlags As Global.System.Windows.Forms.Control = Me.cmbxDoorLinkedToFlags
            point = New Global.System.Drawing.Point(152, 16)
            cmbxDoorLinkedToFlags.Location = point
            Me.cmbxDoorLinkedToFlags.Name = "cmbxDoorLinkedToFlags"
            Dim cmbxDoorLinkedToFlags2 As Global.System.Windows.Forms.Control = Me.cmbxDoorLinkedToFlags
            size = New Global.System.Drawing.Size(272, 21)
            cmbxDoorLinkedToFlags2.Size = size
            Me.cmbxDoorLinkedToFlags.TabIndex = 2
            Dim lblDoorLinkedTo As Global.System.Windows.Forms.Control = Me.lblDoorLinkedTo
            point = New Global.System.Drawing.Point(40, 80)
            lblDoorLinkedTo.Location = point
            Me.lblDoorLinkedTo.Name = "lblDoorLinkedTo"
            Dim lblDoorLinkedTo2 As Global.System.Windows.Forms.Control = Me.lblDoorLinkedTo
            size = New Global.System.Drawing.Size(100, 16)
            lblDoorLinkedTo2.Size = size
            Me.lblDoorLinkedTo.TabIndex = 1
            Me.lblDoorLinkedTo.Text = "Linked To"
            Me.lblDoorLinkedTo.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbDoorLinkedTo As Global.System.Windows.Forms.Control = Me.tbDoorLinkedTo
            point = New Global.System.Drawing.Point(152, 80)
            tbDoorLinkedTo.Location = point
            Me.tbDoorLinkedTo.Name = "tbDoorLinkedTo"
            Dim tbDoorLinkedTo2 As Global.System.Windows.Forms.Control = Me.tbDoorLinkedTo
            size = New Global.System.Drawing.Size(208, 20)
            tbDoorLinkedTo2.Size = size
            Me.tbDoorLinkedTo.TabIndex = 0
            Me.tbDoorLinkedTo.Text = ""
            Dim tbDoorLinkedToModule As Global.System.Windows.Forms.Control = Me.tbDoorLinkedToModule
            point = New Global.System.Drawing.Point(152, 48)
            tbDoorLinkedToModule.Location = point
            Me.tbDoorLinkedToModule.Name = "tbDoorLinkedToModule"
            Dim tbDoorLinkedToModule2 As Global.System.Windows.Forms.Control = Me.tbDoorLinkedToModule
            size = New Global.System.Drawing.Size(208, 20)
            tbDoorLinkedToModule2.Size = size
            Me.tbDoorLinkedToModule.TabIndex = 0
            Me.tbDoorLinkedToModule.Text = ""
            Dim tbDoorLinkedToTransitionDestin As Global.System.Windows.Forms.Control = Me.tbDoorLinkedToTransitionDestin
            point = New Global.System.Drawing.Point(152, 112)
            tbDoorLinkedToTransitionDestin.Location = point
            Me.tbDoorLinkedToTransitionDestin.Name = "tbDoorLinkedToTransitionDestin"
            Dim tbDoorLinkedToTransitionDestin2 As Global.System.Windows.Forms.Control = Me.tbDoorLinkedToTransitionDestin
            size = New Global.System.Drawing.Size(208, 20)
            tbDoorLinkedToTransitionDestin2.Size = size
            Me.tbDoorLinkedToTransitionDestin.TabIndex = 0
            Me.tbDoorLinkedToTransitionDestin.Text = ""
            Dim lblDoorLinkedToFlags As Global.System.Windows.Forms.Control = Me.lblDoorLinkedToFlags
            point = New Global.System.Drawing.Point(40, 16)
            lblDoorLinkedToFlags.Location = point
            Me.lblDoorLinkedToFlags.Name = "lblDoorLinkedToFlags"
            Dim lblDoorLinkedToFlags2 As Global.System.Windows.Forms.Control = Me.lblDoorLinkedToFlags
            size = New Global.System.Drawing.Size(100, 16)
            lblDoorLinkedToFlags2.Size = size
            Me.lblDoorLinkedToFlags.TabIndex = 1
            Me.lblDoorLinkedToFlags.Text = "Linked To Flag"
            Me.lblDoorLinkedToFlags.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim lblDoorLinkedToModule As Global.System.Windows.Forms.Control = Me.lblDoorLinkedToModule
            point = New Global.System.Drawing.Point(40, 48)
            lblDoorLinkedToModule.Location = point
            Me.lblDoorLinkedToModule.Name = "lblDoorLinkedToModule"
            Dim lblDoorLinkedToModule2 As Global.System.Windows.Forms.Control = Me.lblDoorLinkedToModule
            size = New Global.System.Drawing.Size(100, 16)
            lblDoorLinkedToModule2.Size = size
            Me.lblDoorLinkedToModule.TabIndex = 1
            Me.lblDoorLinkedToModule.Text = "Linked To Module"
            Me.lblDoorLinkedToModule.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim lblDoorLinkedToTransitionDestin As Global.System.Windows.Forms.Control = Me.lblDoorLinkedToTransitionDestin
            point = New Global.System.Drawing.Point(40, 114)
            lblDoorLinkedToTransitionDestin.Location = point
            Me.lblDoorLinkedToTransitionDestin.Name = "lblDoorLinkedToTransitionDestin"
            Dim lblDoorLinkedToTransitionDestin2 As Global.System.Windows.Forms.Control = Me.lblDoorLinkedToTransitionDestin
            size = New Global.System.Drawing.Size(120, 16)
            lblDoorLinkedToTransitionDestin2.Size = size
            Me.lblDoorLinkedToTransitionDestin.TabIndex = 1
            Me.lblDoorLinkedToTransitionDestin.Text = "Transition Destination"
            Me.lblDoorLinkedToTransitionDestin.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim lblTransitionMsg As Global.System.Windows.Forms.Control = Me.lblTransitionMsg
            point = New Global.System.Drawing.Point(32, 144)
            lblTransitionMsg.Location = point
            Me.lblTransitionMsg.Name = "lblTransitionMsg"
            Dim lblTransitionMsg2 As Global.System.Windows.Forms.Control = Me.lblTransitionMsg
            size = New Global.System.Drawing.Size(432, 16)
            lblTransitionMsg2.Size = size
            Me.lblTransitionMsg.TabIndex = 1
            Me.lblTransitionMsg.Text = "Note: To enable the above fields, set the type to Transition in the Trigger editor."
            Me.lblTransitionMsg.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblTransitionMsg.Visible = False
            Me.tabpagCamera.Controls.Add(Me.Label29)
            Me.tabpagCamera.Controls.Add(Me.nudCamOrientationX)
            Me.tabpagCamera.Controls.Add(Me.btnShowQuaternion)
            Me.tabpagCamera.Controls.Add(Me.Label1)
            Me.tabpagCamera.Controls.Add(Me.tbCamPitch)
            Me.tabpagCamera.Controls.Add(Me.tbCamHeight)
            Me.tabpagCamera.Controls.Add(Me.Label15)
            Me.tabpagCamera.Controls.Add(Me.tbCamMicRange)
            Me.tabpagCamera.Controls.Add(Me.Label16)
            Me.tabpagCamera.Controls.Add(Me.Label17)
            Me.tabpagCamera.Controls.Add(Me.tbCamFieldOfView)
            Me.tabpagCamera.Controls.Add(Me.tbCamOrientationF1)
            Me.tabpagCamera.Controls.Add(Me.tbCamOrientationF2)
            Me.tabpagCamera.Controls.Add(Me.tbCamOrientationF4)
            Me.tabpagCamera.Controls.Add(Me.tbCamOrientationF3)
            Me.tabpagCamera.Controls.Add(Me.lblQuaternionW)
            Me.tabpagCamera.Controls.Add(Me.Label18)
            Me.tabpagCamera.Controls.Add(Me.Label19)
            Me.tabpagCamera.Controls.Add(Me.Label20)
            Me.tabpagCamera.Controls.Add(Me.tbCamOrientationZ)
            Me.tabpagCamera.Controls.Add(Me.tbCamOrientationX)
            Me.tabpagCamera.Controls.Add(Me.tbCamOrientationY)
            Me.tabpagCamera.Controls.Add(Me.nudCamOrientationY)
            Me.tabpagCamera.Controls.Add(Me.nudCamOrientationZ)
            Me.tabpagCamera.Controls.Add(Me.Label14)
            Dim tabpagCamera As Global.System.Windows.Forms.Control = Me.tabpagCamera
            point = New Global.System.Drawing.Point(4, 22)
            tabpagCamera.Location = point
            Me.tabpagCamera.Name = "tabpagCamera"
            Dim tabpagCamera2 As Global.System.Windows.Forms.Control = Me.tabpagCamera
            size = New Global.System.Drawing.Size(472, 302)
            tabpagCamera2.Size = size
            Me.tabpagCamera.TabIndex = 2
            Me.tabpagCamera.Text = "Camera Specific"
            Dim label35 As Global.System.Windows.Forms.Control = Me.Label29
            point = New Global.System.Drawing.Point(256, 8)
            label35.Location = point
            Me.Label29.Name = "Label29"
            Dim label36 As Global.System.Windows.Forms.Control = Me.Label29
            size = New Global.System.Drawing.Size(176, 40)
            label36.Size = size
            Me.Label29.TabIndex = 10
            Me.Label29.Text = "(Use this value or the one below to set the camera's pitch but not both. Set unused one to 0)"
            Dim nudCamOrientationX As Global.System.Windows.Forms.Control = Me.nudCamOrientationX
            point = New Global.System.Drawing.Point(152, 168)
            nudCamOrientationX.Location = point
            Dim nudCamOrientationX2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamOrientationX
            num = New Decimal(New Integer() {179, 0, 0, 0})
            nudCamOrientationX2.Maximum = num
            Dim nudCamOrientationX3 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamOrientationX
            num = New Decimal(New Integer() {179, 0, 0, Integer.MinValue})
            nudCamOrientationX3.Minimum = num
            Me.nudCamOrientationX.Name = "nudCamOrientationX"
            Dim nudCamOrientationX4 As Global.System.Windows.Forms.Control = Me.nudCamOrientationX
            size = New Global.System.Drawing.Size(48, 20)
            nudCamOrientationX4.Size = size
            Me.nudCamOrientationX.TabIndex = 9
            Me.nudCamOrientationX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.btnShowQuaternion.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnShowQuaternion.ForeColor = Global.System.Drawing.SystemColors.Control
            Dim btnShowQuaternion As Global.System.Windows.Forms.Control = Me.btnShowQuaternion
            point = New Global.System.Drawing.Point(376, 168)
            btnShowQuaternion.Location = point
            Me.btnShowQuaternion.Name = "btnShowQuaternion"
            Dim btnShowQuaternion2 As Global.System.Windows.Forms.Control = Me.btnShowQuaternion
            size = New Global.System.Drawing.Size(24, 23)
            btnShowQuaternion2.Size = size
            Me.btnShowQuaternion.TabIndex = 8
            Dim label37 As Global.System.Windows.Forms.Control = Me.Label1
            point = New Global.System.Drawing.Point(40, 16)
            label37.Location = point
            Me.Label1.Name = "Label1"
            Dim label38 As Global.System.Windows.Forms.Control = Me.Label1
            size = New Global.System.Drawing.Size(100, 16)
            label38.Size = size
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Pitch"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbCamPitch As Global.System.Windows.Forms.Control = Me.tbCamPitch
            point = New Global.System.Drawing.Point(152, 16)
            tbCamPitch.Location = point
            Me.tbCamPitch.Name = "tbCamPitch"
            Dim tbCamPitch2 As Global.System.Windows.Forms.Control = Me.tbCamPitch
            size = New Global.System.Drawing.Size(64, 20)
            tbCamPitch2.Size = size
            Me.tbCamPitch.TabIndex = 0
            Me.tbCamPitch.Text = ""
            Dim tbCamHeight As Global.System.Windows.Forms.Control = Me.tbCamHeight
            point = New Global.System.Drawing.Point(152, 48)
            tbCamHeight.Location = point
            Me.tbCamHeight.Name = "tbCamHeight"
            Dim tbCamHeight2 As Global.System.Windows.Forms.Control = Me.tbCamHeight
            size = New Global.System.Drawing.Size(64, 20)
            tbCamHeight2.Size = size
            Me.tbCamHeight.TabIndex = 1
            Me.tbCamHeight.Text = ""
            Dim label39 As Global.System.Windows.Forms.Control = Me.Label15
            point = New Global.System.Drawing.Point(40, 48)
            label39.Location = point
            Me.Label15.Name = "Label15"
            Dim label40 As Global.System.Windows.Forms.Control = Me.Label15
            size = New Global.System.Drawing.Size(100, 16)
            label40.Size = size
            Me.Label15.TabIndex = 3
            Me.Label15.Text = "Height"
            Me.Label15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbCamMicRange As Global.System.Windows.Forms.Control = Me.tbCamMicRange
            point = New Global.System.Drawing.Point(152, 80)
            tbCamMicRange.Location = point
            Me.tbCamMicRange.Name = "tbCamMicRange"
            Dim tbCamMicRange2 As Global.System.Windows.Forms.Control = Me.tbCamMicRange
            size = New Global.System.Drawing.Size(64, 20)
            tbCamMicRange2.Size = size
            Me.tbCamMicRange.TabIndex = 2
            Me.tbCamMicRange.Text = ""
            Dim label41 As Global.System.Windows.Forms.Control = Me.Label16
            point = New Global.System.Drawing.Point(40, 80)
            label41.Location = point
            Me.Label16.Name = "Label16"
            Dim label42 As Global.System.Windows.Forms.Control = Me.Label16
            size = New Global.System.Drawing.Size(100, 16)
            label42.Size = size
            Me.Label16.TabIndex = 3
            Me.Label16.Text = "Mic Range"
            Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label43 As Global.System.Windows.Forms.Control = Me.Label17
            point = New Global.System.Drawing.Point(40, 112)
            label43.Location = point
            Me.Label17.Name = "Label17"
            Dim label44 As Global.System.Windows.Forms.Control = Me.Label17
            size = New Global.System.Drawing.Size(100, 16)
            label44.Size = size
            Me.Label17.TabIndex = 3
            Me.Label17.Text = "Field of View"
            Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbCamFieldOfView As Global.System.Windows.Forms.Control = Me.tbCamFieldOfView
            point = New Global.System.Drawing.Point(152, 112)
            tbCamFieldOfView.Location = point
            Me.tbCamFieldOfView.Name = "tbCamFieldOfView"
            Dim tbCamFieldOfView2 As Global.System.Windows.Forms.Control = Me.tbCamFieldOfView
            size = New Global.System.Drawing.Size(64, 20)
            tbCamFieldOfView2.Size = size
            Me.tbCamFieldOfView.TabIndex = 3
            Me.tbCamFieldOfView.Text = ""
            Dim tbCamOrientationF As Global.System.Windows.Forms.Control = Me.tbCamOrientationF1
            point = New Global.System.Drawing.Point(24, 224)
            tbCamOrientationF.Location = point
            Me.tbCamOrientationF1.Name = "tbCamOrientationF1"
            Me.tbCamOrientationF1.[ReadOnly] = True
            Dim tbCamOrientationF2 As Global.System.Windows.Forms.Control = Me.tbCamOrientationF1
            size = New Global.System.Drawing.Size(88, 20)
            tbCamOrientationF2.Size = size
            Me.tbCamOrientationF1.TabIndex = 4
            Me.tbCamOrientationF1.Text = ""
            Me.tbCamOrientationF1.Visible = False
            Dim tbCamOrientationF3 As Global.System.Windows.Forms.Control = Me.tbCamOrientationF2
            point = New Global.System.Drawing.Point(136, 224)
            tbCamOrientationF3.Location = point
            Me.tbCamOrientationF2.Name = "tbCamOrientationF2"
            Me.tbCamOrientationF2.[ReadOnly] = True
            Dim tbCamOrientationF4 As Global.System.Windows.Forms.Control = Me.tbCamOrientationF2
            size = New Global.System.Drawing.Size(88, 20)
            tbCamOrientationF4.Size = size
            Me.tbCamOrientationF2.TabIndex = 5
            Me.tbCamOrientationF2.Text = ""
            Me.tbCamOrientationF2.Visible = False
            Dim tbCamOrientationF5 As Global.System.Windows.Forms.Control = Me.tbCamOrientationF4
            point = New Global.System.Drawing.Point(360, 224)
            tbCamOrientationF5.Location = point
            Me.tbCamOrientationF4.Name = "tbCamOrientationF4"
            Me.tbCamOrientationF4.[ReadOnly] = True
            Dim tbCamOrientationF6 As Global.System.Windows.Forms.Control = Me.tbCamOrientationF4
            size = New Global.System.Drawing.Size(88, 20)
            tbCamOrientationF6.Size = size
            Me.tbCamOrientationF4.TabIndex = 7
            Me.tbCamOrientationF4.Text = ""
            Me.tbCamOrientationF4.Visible = False
            Dim tbCamOrientationF7 As Global.System.Windows.Forms.Control = Me.tbCamOrientationF3
            point = New Global.System.Drawing.Point(248, 224)
            tbCamOrientationF7.Location = point
            Me.tbCamOrientationF3.Name = "tbCamOrientationF3"
            Me.tbCamOrientationF3.[ReadOnly] = True
            Dim tbCamOrientationF8 As Global.System.Windows.Forms.Control = Me.tbCamOrientationF3
            size = New Global.System.Drawing.Size(88, 20)
            tbCamOrientationF8.Size = size
            Me.tbCamOrientationF3.TabIndex = 6
            Me.tbCamOrientationF3.Text = ""
            Me.tbCamOrientationF3.Visible = False
            Dim lblQuaternionW As Global.System.Windows.Forms.Control = Me.lblQuaternionW
            point = New Global.System.Drawing.Point(24, 200)
            lblQuaternionW.Location = point
            Me.lblQuaternionW.Name = "lblQuaternionW"
            Dim lblQuaternionW2 As Global.System.Windows.Forms.Control = Me.lblQuaternionW
            size = New Global.System.Drawing.Size(40, 16)
            lblQuaternionW2.Size = size
            Me.lblQuaternionW.TabIndex = 3
            Me.lblQuaternionW.Text = "W"
            Me.lblQuaternionW.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblQuaternionW.Visible = False
            Dim label45 As Global.System.Windows.Forms.Control = Me.Label18
            point = New Global.System.Drawing.Point(160, 144)
            label45.Location = point
            Me.Label18.Name = "Label18"
            Dim label46 As Global.System.Windows.Forms.Control = Me.Label18
            size = New Global.System.Drawing.Size(40, 16)
            label46.Size = size
            Me.Label18.TabIndex = 3
            Me.Label18.Text = "Pitch"
            Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label47 As Global.System.Windows.Forms.Control = Me.Label19
            point = New Global.System.Drawing.Point(240, 144)
            label47.Location = point
            Me.Label19.Name = "Label19"
            Dim label48 As Global.System.Windows.Forms.Control = Me.Label19
            size = New Global.System.Drawing.Size(40, 16)
            label48.Size = size
            Me.Label19.TabIndex = 3
            Me.Label19.Text = "Roll"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim label49 As Global.System.Windows.Forms.Control = Me.Label20
            point = New Global.System.Drawing.Point(320, 144)
            label49.Location = point
            Me.Label20.Name = "Label20"
            Dim label50 As Global.System.Windows.Forms.Control = Me.Label20
            size = New Global.System.Drawing.Size(40, 16)
            label50.Size = size
            Me.Label20.TabIndex = 3
            Me.Label20.Text = "Yaw"
            Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Dim tbCamOrientationZ As Global.System.Windows.Forms.Control = Me.tbCamOrientationZ
            point = New Global.System.Drawing.Point(360, 264)
            tbCamOrientationZ.Location = point
            Me.tbCamOrientationZ.Name = "tbCamOrientationZ"
            Dim tbCamOrientationZ2 As Global.System.Windows.Forms.Control = Me.tbCamOrientationZ
            size = New Global.System.Drawing.Size(88, 20)
            tbCamOrientationZ2.Size = size
            Me.tbCamOrientationZ.TabIndex = 7
            Me.tbCamOrientationZ.Text = ""
            Me.tbCamOrientationZ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationZ.Visible = False
            Me.tbCamOrientationZ.WordWrap = False
            Me.ErrorProvider1.SetIconAlignment(Me.tbCamOrientationX, Global.System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
            Dim tbCamOrientationX As Global.System.Windows.Forms.Control = Me.tbCamOrientationX
            point = New Global.System.Drawing.Point(136, 264)
            tbCamOrientationX.Location = point
            Me.tbCamOrientationX.Name = "tbCamOrientationX"
            Dim tbCamOrientationX2 As Global.System.Windows.Forms.Control = Me.tbCamOrientationX
            size = New Global.System.Drawing.Size(88, 20)
            tbCamOrientationX2.Size = size
            Me.tbCamOrientationX.TabIndex = 5
            Me.tbCamOrientationX.Text = ""
            Me.tbCamOrientationX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationX.Visible = False
            Me.tbCamOrientationX.WordWrap = False
            Dim tbCamOrientationY As Global.System.Windows.Forms.Control = Me.tbCamOrientationY
            point = New Global.System.Drawing.Point(248, 264)
            tbCamOrientationY.Location = point
            Me.tbCamOrientationY.Name = "tbCamOrientationY"
            Dim tbCamOrientationY2 As Global.System.Windows.Forms.Control = Me.tbCamOrientationY
            size = New Global.System.Drawing.Size(88, 20)
            tbCamOrientationY2.Size = size
            Me.tbCamOrientationY.TabIndex = 6
            Me.tbCamOrientationY.Text = ""
            Me.tbCamOrientationY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationY.Visible = False
            Me.tbCamOrientationY.WordWrap = False
            Dim nudCamOrientationY As Global.System.Windows.Forms.Control = Me.nudCamOrientationY
            point = New Global.System.Drawing.Point(232, 168)
            nudCamOrientationY.Location = point
            Dim nudCamOrientationY2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamOrientationY
            num = New Decimal(New Integer() {179, 0, 0, 0})
            nudCamOrientationY2.Maximum = num
            Dim nudCamOrientationY3 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamOrientationY
            num = New Decimal(New Integer() {179, 0, 0, Integer.MinValue})
            nudCamOrientationY3.Minimum = num
            Me.nudCamOrientationY.Name = "nudCamOrientationY"
            Dim nudCamOrientationY4 As Global.System.Windows.Forms.Control = Me.nudCamOrientationY
            size = New Global.System.Drawing.Size(48, 20)
            nudCamOrientationY4.Size = size
            Me.nudCamOrientationY.TabIndex = 9
            Me.nudCamOrientationY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim nudCamOrientationZ As Global.System.Windows.Forms.Control = Me.nudCamOrientationZ
            point = New Global.System.Drawing.Point(312, 168)
            nudCamOrientationZ.Location = point
            Dim nudCamOrientationZ2 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamOrientationZ
            num = New Decimal(New Integer() {179, 0, 0, 0})
            nudCamOrientationZ2.Maximum = num
            Dim nudCamOrientationZ3 As Global.System.Windows.Forms.NumericUpDown = Me.nudCamOrientationZ
            num = New Decimal(New Integer() {179, 0, 0, Integer.MinValue})
            nudCamOrientationZ3.Minimum = num
            Me.nudCamOrientationZ.Name = "nudCamOrientationZ"
            Dim nudCamOrientationZ4 As Global.System.Windows.Forms.Control = Me.nudCamOrientationZ
            size = New Global.System.Drawing.Size(48, 20)
            nudCamOrientationZ4.Size = size
            Me.nudCamOrientationZ.TabIndex = 9
            Me.nudCamOrientationZ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Dim label51 As Global.System.Windows.Forms.Control = Me.Label14
            point = New Global.System.Drawing.Point(40, 168)
            label51.Location = point
            Me.Label14.Name = "Label14"
            Dim label52 As Global.System.Windows.Forms.Control = Me.Label14
            size = New Global.System.Drawing.Size(80, 16)
            label52.Size = size
            Me.Label14.TabIndex = 3
            Me.Label14.Text = "Camera Angle"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.ErrorProvider1.ContainerControl = Me
            size = New Global.System.Drawing.Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Global.System.Drawing.Size(504, 389)
            Me.ClientSize = size
            Me.Controls.Add(Me.tabctrl)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button3)
            Me.Icon = CType(resourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmModuleItem_Base_Editor"
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = ""
            CType(Me.nudXY, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabctrl.ResumeLayout(False)
            Me.tabpagGeneral.ResumeLayout(False)
            Me.tabpagWaypoint.ResumeLayout(False)
            Me.tabpagEncounter.ResumeLayout(False)
            CType(Me.nudXYSpawnPointBearing, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSpawnPointX, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSpawnPointY, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSpawnPointZ, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagDoor.ResumeLayout(False)
            Me.gbTriggerNode.ResumeLayout(False)
            Me.tabpagCamera.ResumeLayout(False)
            CType(Me.nudCamOrientationX, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCamOrientationY, Global.System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCamOrientationZ, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

		' Token: 0x04000628 RID: 1576
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
