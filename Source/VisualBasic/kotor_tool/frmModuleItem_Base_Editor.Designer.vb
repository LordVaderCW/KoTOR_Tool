Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x02000063 RID: 99
    Partial Public Class frmModuleItem_Base_Editor
        Inherits Global.kotor_tool.frmParent

        ' -----------------------------------------------------------------
        ' Designer fields restored from decompiled
        ' AccessedThroughProperty wrappers.
        ' Kept before InitializeComponent for VS2010 CodeDom safety.
        ' -----------------------------------------------------------------
        Private components As Global.System.ComponentModel.IContainer
        Friend WithEvents Label2 As Global.System.Windows.Forms.Label
        Friend WithEvents Label3 As Global.System.Windows.Forms.Label
        Friend WithEvents Label4 As Global.System.Windows.Forms.Label
        Friend WithEvents pboxXY As Global.System.Windows.Forms.PictureBox
        Friend WithEvents tbXPosition As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbYPosition As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbZPosition As Global.System.Windows.Forms.TextBox
        Friend WithEvents nudXY As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Button1 As Global.System.Windows.Forms.Button
        Friend WithEvents Button2 As Global.System.Windows.Forms.Button
        Friend WithEvents Button3 As Global.System.Windows.Forms.Button
        Friend WithEvents tbResRef As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTag As Global.System.Windows.Forms.TextBox
        Friend WithEvents lblTag As Global.System.Windows.Forms.Label
        Friend WithEvents tabpagDoor As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagGeneral As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagCamera As Global.System.Windows.Forms.TabPage
        Friend WithEvents tabpagWaypoint As Global.System.Windows.Forms.TabPage
        Friend WithEvents tbDoorLinkedTo As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbDoorLinkedToModule As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbDoorLinkedToTransitionDestin As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label9 As Global.System.Windows.Forms.Label
        Friend WithEvents tbWPLinkedTo As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbWpDescription As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label11 As Global.System.Windows.Forms.Label
        Friend WithEvents Label12 As Global.System.Windows.Forms.Label
        Friend WithEvents tbWpLocalizedName As Global.System.Windows.Forms.TextBox
        Friend WithEvents lblLocalizedName As Global.System.Windows.Forms.Label
        Friend WithEvents chkbHasMapNote As Global.System.Windows.Forms.CheckBox
        Friend WithEvents chkbMapNoteEnabled As Global.System.Windows.Forms.CheckBox
        Friend WithEvents tabctrl As Global.System.Windows.Forms.TabControl
        Friend WithEvents cmbxDoorLinkedToFlags As Global.System.Windows.Forms.ComboBox
        Friend WithEvents lblResRef As Global.System.Windows.Forms.Label
        Friend WithEvents tbWpMapNote As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label1 As Global.System.Windows.Forms.Label
        Friend WithEvents tbCamPitch As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCamHeight As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label15 As Global.System.Windows.Forms.Label
        Friend WithEvents tbCamMicRange As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label16 As Global.System.Windows.Forms.Label
        Friend WithEvents Label17 As Global.System.Windows.Forms.Label
        Friend WithEvents tbCamFieldOfView As Global.System.Windows.Forms.TextBox
        Friend WithEvents lblBearing As Global.System.Windows.Forms.Label
        Friend WithEvents Label18 As Global.System.Windows.Forms.Label
        Friend WithEvents Label19 As Global.System.Windows.Forms.Label
        Friend WithEvents Label20 As Global.System.Windows.Forms.Label
        Friend WithEvents tbCamOrientationF1 As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCamOrientationF2 As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCamOrientationF4 As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCamOrientationF3 As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTriggerNodeXPosition As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTriggerNodeYPosition As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbTriggerNodeZPosition As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label21 As Global.System.Windows.Forms.Label
        Friend WithEvents Label22 As Global.System.Windows.Forms.Label
        Friend WithEvents Label23 As Global.System.Windows.Forms.Label
        Friend WithEvents gbTriggerNode As Global.System.Windows.Forms.GroupBox
        Friend WithEvents tabpagEncounter As Global.System.Windows.Forms.TabPage
        Friend WithEvents Label24 As Global.System.Windows.Forms.Label
        Friend WithEvents Label25 As Global.System.Windows.Forms.Label
        Friend WithEvents Label26 As Global.System.Windows.Forms.Label
        Friend WithEvents Label27 As Global.System.Windows.Forms.Label
        Friend WithEvents Label28 As Global.System.Windows.Forms.Label
        Friend WithEvents tbCamOrientationZ As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCamOrientationX As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbCamOrientationY As Global.System.Windows.Forms.TextBox
        Friend WithEvents ErrorProvider1 As ErrorProvider
        Friend WithEvents btnShowQuaternion As Global.System.Windows.Forms.Button
        Friend WithEvents lblQuaternionW As Global.System.Windows.Forms.Label
        Friend WithEvents nudCamOrientationX As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCamOrientationY As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudCamOrientationZ As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents Label14 As Global.System.Windows.Forms.Label
        Friend WithEvents Label29 As Global.System.Windows.Forms.Label
        Friend WithEvents lblDoorLinkedTo As Global.System.Windows.Forms.Label
        Friend WithEvents lblDoorLinkedToFlags As Global.System.Windows.Forms.Label
        Friend WithEvents lblDoorLinkedToModule As Global.System.Windows.Forms.Label
        Friend WithEvents lblDoorLinkedToTransitionDestin As Global.System.Windows.Forms.Label
        Friend WithEvents lblTransitionMsg As Global.System.Windows.Forms.Label
        Friend WithEvents nudXYSpawnPointBearing As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents pboxXYSpawnPointBearing As Global.System.Windows.Forms.PictureBox
        Friend WithEvents lbSpawnPoints As Global.System.Windows.Forms.ListBox
        Friend WithEvents nudSpawnPointX As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudSpawnPointY As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents nudSpawnPointZ As Global.System.Windows.Forms.NumericUpDown
        Friend WithEvents tbxo As Global.System.Windows.Forms.TextBox
        Friend WithEvents tbyo As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label5 As Global.System.Windows.Forms.Label
        Friend WithEvents Label6 As Global.System.Windows.Forms.Label
        Friend WithEvents tbBearing As Global.System.Windows.Forms.TextBox
        Friend WithEvents Label7 As Global.System.Windows.Forms.Label
        Friend WithEvents btnSetNameLang As Global.System.Windows.Forms.Button


        ' Token: 0x06000B90 RID: 2960 RVA: 0x0027B854 File Offset: 0x0027A854
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Token: 0x06000C49 RID: 3145 RVA: 0x0027CC04 File Offset: 0x0027BC04
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager(GetType(Global.kotor_tool.frmModuleItem_Base_Editor))
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
            Me.tbXPosition.Location = New Global.System.Drawing.Point(152, 80)
            Me.tbXPosition.Name = "tbXPosition"
            Me.tbXPosition.TabIndex = 0
            Me.tbXPosition.Text = ""
            Me.tbXPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbYPosition.Location = New Global.System.Drawing.Point(152, 112)
            Me.tbYPosition.Name = "tbYPosition"
            Me.tbYPosition.TabIndex = 0
            Me.tbYPosition.Text = ""
            Me.tbYPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbZPosition.Location = New Global.System.Drawing.Point(152, 144)
            Me.tbZPosition.Name = "tbZPosition"
            Me.tbZPosition.TabIndex = 0
            Me.tbZPosition.Text = ""
            Me.tbZPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbResRef.Location = New Global.System.Drawing.Point(152, 16)
            Me.tbResRef.MaxLength = 16
            Me.tbResRef.Name = "tbResRef"
            Me.tbResRef.Size = New Global.System.Drawing.Size(184, 20)
            Me.tbResRef.TabIndex = 0
            Me.tbResRef.Text = ""
            Me.lblResRef.Location = New Global.System.Drawing.Point(40, 16)
            Me.lblResRef.Name = "lblResRef"
            Me.lblResRef.Size = New Global.System.Drawing.Size(96, 16)
            Me.lblResRef.TabIndex = 1
            Me.lblResRef.Text = "TemplateResRef"
            Me.lblResRef.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label2.Location = New Global.System.Drawing.Point(40, 80)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "X Position"
            Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label3.Location = New Global.System.Drawing.Point(40, 112)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Y Position"
            Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label4.Location = New Global.System.Drawing.Point(40, 144)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Z Position"
            Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.pboxXY.Location = New Global.System.Drawing.Point(280, 104)
            Me.pboxXY.Name = "pboxXY"
            Me.pboxXY.Size = New Global.System.Drawing.Size(50, 50)
            Me.pboxXY.TabIndex = 2
            Me.pboxXY.TabStop = False
            Me.nudXY.DecimalPlaces = 2
            Me.nudXY.Location = New Global.System.Drawing.Point(277, 160)
            Me.nudXY.Maximum = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            Me.nudXY.Name = "nudXY"
            Me.nudXY.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudXY.TabIndex = 4
            Me.nudXY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
            Me.Button1.Location = New Global.System.Drawing.Point(40, 352)
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 5
            Me.Button1.Text = "Button1"
            Me.Button1.Visible = False
            Me.Button2.DialogResult = Global.System.Windows.Forms.DialogResult.OK
            Me.Button2.Location = New Global.System.Drawing.Point(296, 352)
            Me.Button2.Name = "Button2"
            Me.Button2.TabIndex = 5
            Me.Button2.Text = "OK"
            Me.Button3.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
            Me.Button3.Location = New Global.System.Drawing.Point(392, 352)
            Me.Button3.Name = "Button3"
            Me.Button3.TabIndex = 5
            Me.Button3.Text = "Cancel"
            Me.tbTag.Location = New Global.System.Drawing.Point(152, 48)
            Me.tbTag.MaxLength = 16
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New Global.System.Drawing.Size(184, 20)
            Me.tbTag.TabIndex = 0
            Me.tbTag.Text = ""
            Me.lblTag.Location = New Global.System.Drawing.Point(40, 48)
            Me.lblTag.Name = "lblTag"
            Me.lblTag.Size = New Global.System.Drawing.Size(96, 16)
            Me.lblTag.TabIndex = 1
            Me.lblTag.Text = "Tag"
            Me.lblTag.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tabctrl.Controls.Add(Me.tabpagGeneral)
            Me.tabctrl.Controls.Add(Me.tabpagWaypoint)
            Me.tabctrl.Controls.Add(Me.tabpagDoor)
            Me.tabctrl.Controls.Add(Me.tabpagEncounter)
            Me.tabctrl.Controls.Add(Me.tabpagCamera)
            Me.tabctrl.Location = New Global.System.Drawing.Point(8, 8)
            Me.tabctrl.Name = "tabctrl"
            Me.tabctrl.SelectedIndex = 0
            Me.tabctrl.Size = New Global.System.Drawing.Size(480, 328)
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
            Me.tabpagGeneral.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagGeneral.Name = "tabpagGeneral"
            Me.tabpagGeneral.Size = New Global.System.Drawing.Size(472, 302)
            Me.tabpagGeneral.TabIndex = 1
            Me.tabpagGeneral.Text = "General"
            Me.lblBearing.Location = New Global.System.Drawing.Point(281, 80)
            Me.lblBearing.Name = "lblBearing"
            Me.lblBearing.Size = New Global.System.Drawing.Size(48, 16)
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
            Me.tabpagWaypoint.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagWaypoint.Name = "tabpagWaypoint"
            Me.tabpagWaypoint.Size = New Global.System.Drawing.Size(472, 302)
            Me.tabpagWaypoint.TabIndex = 3
            Me.tabpagWaypoint.Text = "Waypoint Specific"
            Me.btnSetNameLang.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
            Me.btnSetNameLang.Location = New Global.System.Drawing.Point(296, 264)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New Global.System.Drawing.Size(88, 23)
            Me.btnSetNameLang.TabIndex = 10
            Me.btnSetNameLang.Text = "Set Language"
            Me.chkbHasMapNote.Location = New Global.System.Drawing.Point(48, 168)
            Me.chkbHasMapNote.Name = "chkbHasMapNote"
            Me.chkbHasMapNote.Size = New Global.System.Drawing.Size(192, 24)
            Me.chkbHasMapNote.TabIndex = 9
            Me.chkbHasMapNote.Text = "Waypoint Contains a Map Note"
            Me.Label9.Location = New Global.System.Drawing.Point(48, 16)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label9.TabIndex = 8
            Me.Label9.Text = "Linked To"
            Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbWPLinkedTo.Location = New Global.System.Drawing.Point(176, 16)
            Me.tbWPLinkedTo.Name = "tbWPLinkedTo"
            Me.tbWPLinkedTo.Size = New Global.System.Drawing.Size(208, 20)
            Me.tbWPLinkedTo.TabIndex = 5
            Me.tbWPLinkedTo.Text = ""
            Me.tbWpDescription.Location = New Global.System.Drawing.Point(176, 96)
            Me.tbWpDescription.Multiline = True
            Me.tbWpDescription.Name = "tbWpDescription"
            Me.tbWpDescription.Size = New Global.System.Drawing.Size(208, 60)
            Me.tbWpDescription.TabIndex = 2
            Me.tbWpDescription.Text = ""
            Me.tbWpMapNote.Location = New Global.System.Drawing.Point(176, 192)
            Me.tbWpMapNote.Multiline = True
            Me.tbWpMapNote.Name = "tbWpMapNote"
            Me.tbWpMapNote.Size = New Global.System.Drawing.Size(208, 60)
            Me.tbWpMapNote.TabIndex = 3
            Me.tbWpMapNote.Text = ""
            Me.Label11.Location = New Global.System.Drawing.Point(48, 96)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Description"
            Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label12.Location = New Global.System.Drawing.Point(48, 208)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New Global.System.Drawing.Size(120, 16)
            Me.Label12.TabIndex = 7
            Me.Label12.Text = "Map Note"
            Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbWpLocalizedName.Location = New Global.System.Drawing.Point(176, 56)
            Me.tbWpLocalizedName.Name = "tbWpLocalizedName"
            Me.tbWpLocalizedName.Size = New Global.System.Drawing.Size(208, 20)
            Me.tbWpLocalizedName.TabIndex = 2
            Me.tbWpLocalizedName.Text = ""
            Me.lblLocalizedName.Location = New Global.System.Drawing.Point(48, 56)
            Me.lblLocalizedName.Name = "lblLocalizedName"
            Me.lblLocalizedName.Size = New Global.System.Drawing.Size(100, 16)
            Me.lblLocalizedName.TabIndex = 6
            Me.lblLocalizedName.Text = "Localized Name"
            Me.lblLocalizedName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.chkbMapNoteEnabled.Location = New Global.System.Drawing.Point(256, 168)
            Me.chkbMapNoteEnabled.Name = "chkbMapNoteEnabled"
            Me.chkbMapNoteEnabled.Size = New Global.System.Drawing.Size(128, 24)
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
            Me.tabpagEncounter.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagEncounter.Name = "tabpagEncounter"
            Me.tabpagEncounter.Size = New Global.System.Drawing.Size(472, 302)
            Me.tabpagEncounter.TabIndex = 5
            Me.tabpagEncounter.Text = "Encounter Specific"
            Me.tbBearing.Location = New Global.System.Drawing.Point(96, 248)
            Me.tbBearing.Name = "tbBearing"
            Me.tbBearing.[ReadOnly] = True
            Me.tbBearing.Size = New Global.System.Drawing.Size(104, 20)
            Me.tbBearing.TabIndex = 55
            Me.tbBearing.Text = ""
            Me.tbBearing.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbBearing.Visible = False
            Me.tbxo.Location = New Global.System.Drawing.Point(96, 192)
            Me.tbxo.Name = "tbxo"
            Me.tbxo.[ReadOnly] = True
            Me.tbxo.Size = New Global.System.Drawing.Size(64, 20)
            Me.tbxo.TabIndex = 54
            Me.tbxo.Text = ""
            Me.tbxo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbxo.Visible = False
            Me.tbyo.Location = New Global.System.Drawing.Point(96, 216)
            Me.tbyo.Name = "tbyo"
            Me.tbyo.[ReadOnly] = True
            Me.tbyo.Size = New Global.System.Drawing.Size(64, 20)
            Me.tbyo.TabIndex = 53
            Me.tbyo.Text = ""
            Me.tbyo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbyo.Visible = False
            Me.pboxXYSpawnPointBearing.Location = New Global.System.Drawing.Point(336, 80)
            Me.pboxXYSpawnPointBearing.Name = "pboxXYSpawnPointBearing"
            Me.pboxXYSpawnPointBearing.Size = New Global.System.Drawing.Size(50, 50)
            Me.pboxXYSpawnPointBearing.TabIndex = 51
            Me.pboxXYSpawnPointBearing.TabStop = False
            Me.nudXYSpawnPointBearing.DecimalPlaces = 2
            Me.nudXYSpawnPointBearing.Enabled = False
            Me.nudXYSpawnPointBearing.Location = New Global.System.Drawing.Point(328, 136)
            Me.nudXYSpawnPointBearing.Maximum = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            Me.nudXYSpawnPointBearing.Name = "nudXYSpawnPointBearing"
            Me.nudXYSpawnPointBearing.Size = New Global.System.Drawing.Size(64, 20)
            Me.nudXYSpawnPointBearing.TabIndex = 52
            Me.nudXYSpawnPointBearing.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
            Me.Label25.Location = New Global.System.Drawing.Point(336, 56)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New Global.System.Drawing.Size(48, 16)
            Me.Label25.TabIndex = 50
            Me.Label25.Text = "Bearing"
            Me.Label25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
            Me.Label26.Location = New Global.System.Drawing.Point(168, 64)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label26.TabIndex = 48
            Me.Label26.Text = "X"
            Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudSpawnPointX.DecimalPlaces = 4
            Me.nudSpawnPointX.Enabled = False
            Me.nudSpawnPointX.Location = New Global.System.Drawing.Point(200, 64)
            Me.nudSpawnPointX.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudSpawnPointX.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.nudSpawnPointX.Name = "nudSpawnPointX"
            Me.nudSpawnPointX.Size = New Global.System.Drawing.Size(96, 20)
            Me.nudSpawnPointX.TabIndex = 44
            Me.nudSpawnPointX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label27.Location = New Global.System.Drawing.Point(168, 96)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label27.TabIndex = 49
            Me.Label27.Text = "Y"
            Me.Label27.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudSpawnPointY.DecimalPlaces = 4
            Me.nudSpawnPointY.Enabled = False
            Me.nudSpawnPointY.Location = New Global.System.Drawing.Point(200, 96)
            Me.nudSpawnPointY.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudSpawnPointY.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.nudSpawnPointY.Name = "nudSpawnPointY"
            Me.nudSpawnPointY.Size = New Global.System.Drawing.Size(96, 20)
            Me.nudSpawnPointY.TabIndex = 45
            Me.nudSpawnPointY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label28.Location = New Global.System.Drawing.Point(168, 128)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label28.TabIndex = 47
            Me.Label28.Text = "Z"
            Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.nudSpawnPointZ.DecimalPlaces = 4
            Me.nudSpawnPointZ.Enabled = False
            Me.nudSpawnPointZ.Location = New Global.System.Drawing.Point(200, 128)
            Me.nudSpawnPointZ.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudSpawnPointZ.Minimum = New Decimal(New Integer() {4000, 0, 0, Integer.MinValue})
            Me.nudSpawnPointZ.Name = "nudSpawnPointZ"
            Me.nudSpawnPointZ.Size = New Global.System.Drawing.Size(96, 20)
            Me.nudSpawnPointZ.TabIndex = 46
            Me.nudSpawnPointZ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label24.Location = New Global.System.Drawing.Point(72, 32)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label24.TabIndex = 43
            Me.Label24.Text = "Spawn Points"
            Me.lbSpawnPoints.Location = New Global.System.Drawing.Point(80, 56)
            Me.lbSpawnPoints.Name = "lbSpawnPoints"
            Me.lbSpawnPoints.ScrollAlwaysVisible = True
            Me.lbSpawnPoints.Size = New Global.System.Drawing.Size(56, 95)
            Me.lbSpawnPoints.TabIndex = 42
            Me.Label5.Location = New Global.System.Drawing.Point(64, 192)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label5.TabIndex = 48
            Me.Label5.Text = "X"
            Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label5.Visible = False
            Me.Label6.Location = New Global.System.Drawing.Point(64, 216)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Global.System.Drawing.Size(16, 16)
            Me.Label6.TabIndex = 49
            Me.Label6.Text = "Y"
            Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
            Me.Label6.Visible = False
            Me.Label7.Location = New Global.System.Drawing.Point(224, 40)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Global.System.Drawing.Size(48, 16)
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
            Me.tabpagDoor.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagDoor.Name = "tabpagDoor"
            Me.tabpagDoor.Size = New Global.System.Drawing.Size(472, 302)
            Me.tabpagDoor.TabIndex = 0
            Me.tabpagDoor.Text = "Door/Trigger Specific"
            Me.gbTriggerNode.Controls.Add(Me.Label23)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeYPosition)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeXPosition)
            Me.gbTriggerNode.Controls.Add(Me.Label22)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeZPosition)
            Me.gbTriggerNode.Controls.Add(Me.Label21)
            Me.gbTriggerNode.Location = New Global.System.Drawing.Point(16, 176)
            Me.gbTriggerNode.Name = "gbTriggerNode"
            Me.gbTriggerNode.Size = New Global.System.Drawing.Size(304, 120)
            Me.gbTriggerNode.TabIndex = 9
            Me.gbTriggerNode.TabStop = False
            Me.gbTriggerNode.Text = "Trigger Node"
            Me.gbTriggerNode.Visible = False
            Me.Label23.Location = New Global.System.Drawing.Point(24, 88)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label23.TabIndex = 6
            Me.Label23.Text = "Z Position"
            Me.Label23.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbTriggerNodeYPosition.Location = New Global.System.Drawing.Point(136, 56)
            Me.tbTriggerNodeYPosition.Name = "tbTriggerNodeYPosition"
            Me.tbTriggerNodeYPosition.TabIndex = 4
            Me.tbTriggerNodeYPosition.Text = ""
            Me.tbTriggerNodeYPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbTriggerNodeXPosition.Location = New Global.System.Drawing.Point(136, 24)
            Me.tbTriggerNodeXPosition.Name = "tbTriggerNodeXPosition"
            Me.tbTriggerNodeXPosition.TabIndex = 5
            Me.tbTriggerNodeXPosition.Text = ""
            Me.tbTriggerNodeXPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label22.Location = New Global.System.Drawing.Point(24, 56)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label22.TabIndex = 7
            Me.Label22.Text = "Y Position"
            Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbTriggerNodeZPosition.Location = New Global.System.Drawing.Point(136, 88)
            Me.tbTriggerNodeZPosition.Name = "tbTriggerNodeZPosition"
            Me.tbTriggerNodeZPosition.TabIndex = 3
            Me.tbTriggerNodeZPosition.Text = ""
            Me.tbTriggerNodeZPosition.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label21.Location = New Global.System.Drawing.Point(24, 24)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New Global.System.Drawing.Size(88, 16)
            Me.Label21.TabIndex = 8
            Me.Label21.Text = "X Position"
            Me.Label21.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.cmbxDoorLinkedToFlags.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxDoorLinkedToFlags.Items.AddRange(New Object() {"Does not link to anything", "Is an Area Transition and links to a Door", "Is an Area Transition and links to a Waypoint"})
            Me.cmbxDoorLinkedToFlags.Location = New Global.System.Drawing.Point(152, 16)
            Me.cmbxDoorLinkedToFlags.Name = "cmbxDoorLinkedToFlags"
            Me.cmbxDoorLinkedToFlags.Size = New Global.System.Drawing.Size(272, 21)
            Me.cmbxDoorLinkedToFlags.TabIndex = 2
            Me.lblDoorLinkedTo.Location = New Global.System.Drawing.Point(40, 80)
            Me.lblDoorLinkedTo.Name = "lblDoorLinkedTo"
            Me.lblDoorLinkedTo.Size = New Global.System.Drawing.Size(100, 16)
            Me.lblDoorLinkedTo.TabIndex = 1
            Me.lblDoorLinkedTo.Text = "Linked To"
            Me.lblDoorLinkedTo.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbDoorLinkedTo.Location = New Global.System.Drawing.Point(152, 80)
            Me.tbDoorLinkedTo.Name = "tbDoorLinkedTo"
            Me.tbDoorLinkedTo.Size = New Global.System.Drawing.Size(208, 20)
            Me.tbDoorLinkedTo.TabIndex = 0
            Me.tbDoorLinkedTo.Text = ""
            Me.tbDoorLinkedToModule.Location = New Global.System.Drawing.Point(152, 48)
            Me.tbDoorLinkedToModule.Name = "tbDoorLinkedToModule"
            Me.tbDoorLinkedToModule.Size = New Global.System.Drawing.Size(208, 20)
            Me.tbDoorLinkedToModule.TabIndex = 0
            Me.tbDoorLinkedToModule.Text = ""
            Me.tbDoorLinkedToTransitionDestin.Location = New Global.System.Drawing.Point(152, 112)
            Me.tbDoorLinkedToTransitionDestin.Name = "tbDoorLinkedToTransitionDestin"
            Me.tbDoorLinkedToTransitionDestin.Size = New Global.System.Drawing.Size(208, 20)
            Me.tbDoorLinkedToTransitionDestin.TabIndex = 0
            Me.tbDoorLinkedToTransitionDestin.Text = ""
            Me.lblDoorLinkedToFlags.Location = New Global.System.Drawing.Point(40, 16)
            Me.lblDoorLinkedToFlags.Name = "lblDoorLinkedToFlags"
            Me.lblDoorLinkedToFlags.Size = New Global.System.Drawing.Size(100, 16)
            Me.lblDoorLinkedToFlags.TabIndex = 1
            Me.lblDoorLinkedToFlags.Text = "Linked To Flag"
            Me.lblDoorLinkedToFlags.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblDoorLinkedToModule.Location = New Global.System.Drawing.Point(40, 48)
            Me.lblDoorLinkedToModule.Name = "lblDoorLinkedToModule"
            Me.lblDoorLinkedToModule.Size = New Global.System.Drawing.Size(100, 16)
            Me.lblDoorLinkedToModule.TabIndex = 1
            Me.lblDoorLinkedToModule.Text = "Linked To Module"
            Me.lblDoorLinkedToModule.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblDoorLinkedToTransitionDestin.Location = New Global.System.Drawing.Point(40, 114)
            Me.lblDoorLinkedToTransitionDestin.Name = "lblDoorLinkedToTransitionDestin"
            Me.lblDoorLinkedToTransitionDestin.Size = New Global.System.Drawing.Size(120, 16)
            Me.lblDoorLinkedToTransitionDestin.TabIndex = 1
            Me.lblDoorLinkedToTransitionDestin.Text = "Transition Destination"
            Me.lblDoorLinkedToTransitionDestin.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblTransitionMsg.Location = New Global.System.Drawing.Point(32, 144)
            Me.lblTransitionMsg.Name = "lblTransitionMsg"
            Me.lblTransitionMsg.Size = New Global.System.Drawing.Size(432, 16)
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
            Me.tabpagCamera.Location = New Global.System.Drawing.Point(4, 22)
            Me.tabpagCamera.Name = "tabpagCamera"
            Me.tabpagCamera.Size = New Global.System.Drawing.Size(472, 302)
            Me.tabpagCamera.TabIndex = 2
            Me.tabpagCamera.Text = "Camera Specific"
            Me.Label29.Location = New Global.System.Drawing.Point(256, 8)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New Global.System.Drawing.Size(176, 40)
            Me.Label29.TabIndex = 10
            Me.Label29.Text = "(Use this value or the one below to set the camera's pitch but not both. Set unused one to 0)"
            Me.nudCamOrientationX.Location = New Global.System.Drawing.Point(152, 168)
            Me.nudCamOrientationX.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
            Me.nudCamOrientationX.Minimum = New Decimal(New Integer() {179, 0, 0, Integer.MinValue})
            Me.nudCamOrientationX.Name = "nudCamOrientationX"
            Me.nudCamOrientationX.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudCamOrientationX.TabIndex = 9
            Me.nudCamOrientationX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.btnShowQuaternion.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnShowQuaternion.ForeColor = Global.System.Drawing.SystemColors.Control
            Me.btnShowQuaternion.Location = New Global.System.Drawing.Point(376, 168)
            Me.btnShowQuaternion.Name = "btnShowQuaternion"
            Me.btnShowQuaternion.Size = New Global.System.Drawing.Size(24, 23)
            Me.btnShowQuaternion.TabIndex = 8
            Me.Label1.Location = New Global.System.Drawing.Point(40, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Pitch"
            Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbCamPitch.Location = New Global.System.Drawing.Point(152, 16)
            Me.tbCamPitch.Name = "tbCamPitch"
            Me.tbCamPitch.Size = New Global.System.Drawing.Size(64, 20)
            Me.tbCamPitch.TabIndex = 0
            Me.tbCamPitch.Text = ""
            Me.tbCamHeight.Location = New Global.System.Drawing.Point(152, 48)
            Me.tbCamHeight.Name = "tbCamHeight"
            Me.tbCamHeight.Size = New Global.System.Drawing.Size(64, 20)
            Me.tbCamHeight.TabIndex = 1
            Me.tbCamHeight.Text = ""
            Me.Label15.Location = New Global.System.Drawing.Point(40, 48)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label15.TabIndex = 3
            Me.Label15.Text = "Height"
            Me.Label15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbCamMicRange.Location = New Global.System.Drawing.Point(152, 80)
            Me.tbCamMicRange.Name = "tbCamMicRange"
            Me.tbCamMicRange.Size = New Global.System.Drawing.Size(64, 20)
            Me.tbCamMicRange.TabIndex = 2
            Me.tbCamMicRange.Text = ""
            Me.Label16.Location = New Global.System.Drawing.Point(40, 80)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label16.TabIndex = 3
            Me.Label16.Text = "Mic Range"
            Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label17.Location = New Global.System.Drawing.Point(40, 112)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Global.System.Drawing.Size(100, 16)
            Me.Label17.TabIndex = 3
            Me.Label17.Text = "Field of View"
            Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbCamFieldOfView.Location = New Global.System.Drawing.Point(152, 112)
            Me.tbCamFieldOfView.Name = "tbCamFieldOfView"
            Me.tbCamFieldOfView.Size = New Global.System.Drawing.Size(64, 20)
            Me.tbCamFieldOfView.TabIndex = 3
            Me.tbCamFieldOfView.Text = ""
            Me.tbCamOrientationF1.Location = New Global.System.Drawing.Point(24, 224)
            Me.tbCamOrientationF1.Name = "tbCamOrientationF1"
            Me.tbCamOrientationF1.[ReadOnly] = True
            Me.tbCamOrientationF1.Size = New Global.System.Drawing.Size(88, 20)
            Me.tbCamOrientationF1.TabIndex = 4
            Me.tbCamOrientationF1.Text = ""
            Me.tbCamOrientationF1.Visible = False
            Me.tbCamOrientationF2.Location = New Global.System.Drawing.Point(136, 224)
            Me.tbCamOrientationF2.Name = "tbCamOrientationF2"
            Me.tbCamOrientationF2.[ReadOnly] = True
            Me.tbCamOrientationF2.Size = New Global.System.Drawing.Size(88, 20)
            Me.tbCamOrientationF2.TabIndex = 5
            Me.tbCamOrientationF2.Text = ""
            Me.tbCamOrientationF2.Visible = False
            Me.tbCamOrientationF4.Location = New Global.System.Drawing.Point(360, 224)
            Me.tbCamOrientationF4.Name = "tbCamOrientationF4"
            Me.tbCamOrientationF4.[ReadOnly] = True
            Me.tbCamOrientationF4.Size = New Global.System.Drawing.Size(88, 20)
            Me.tbCamOrientationF4.TabIndex = 7
            Me.tbCamOrientationF4.Text = ""
            Me.tbCamOrientationF4.Visible = False
            Me.tbCamOrientationF3.Location = New Global.System.Drawing.Point(248, 224)
            Me.tbCamOrientationF3.Name = "tbCamOrientationF3"
            Me.tbCamOrientationF3.[ReadOnly] = True
            Me.tbCamOrientationF3.Size = New Global.System.Drawing.Size(88, 20)
            Me.tbCamOrientationF3.TabIndex = 6
            Me.tbCamOrientationF3.Text = ""
            Me.tbCamOrientationF3.Visible = False
            Me.lblQuaternionW.Location = New Global.System.Drawing.Point(24, 200)
            Me.lblQuaternionW.Name = "lblQuaternionW"
            Me.lblQuaternionW.Size = New Global.System.Drawing.Size(40, 16)
            Me.lblQuaternionW.TabIndex = 3
            Me.lblQuaternionW.Text = "W"
            Me.lblQuaternionW.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.lblQuaternionW.Visible = False
            Me.Label18.Location = New Global.System.Drawing.Point(160, 144)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New Global.System.Drawing.Size(40, 16)
            Me.Label18.TabIndex = 3
            Me.Label18.Text = "Pitch"
            Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label19.Location = New Global.System.Drawing.Point(240, 144)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New Global.System.Drawing.Size(40, 16)
            Me.Label19.TabIndex = 3
            Me.Label19.Text = "Roll"
            Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.Label20.Location = New Global.System.Drawing.Point(320, 144)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New Global.System.Drawing.Size(40, 16)
            Me.Label20.TabIndex = 3
            Me.Label20.Text = "Yaw"
            Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.tbCamOrientationZ.Location = New Global.System.Drawing.Point(360, 264)
            Me.tbCamOrientationZ.Name = "tbCamOrientationZ"
            Me.tbCamOrientationZ.Size = New Global.System.Drawing.Size(88, 20)
            Me.tbCamOrientationZ.TabIndex = 7
            Me.tbCamOrientationZ.Text = ""
            Me.tbCamOrientationZ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationZ.Visible = False
            Me.tbCamOrientationZ.WordWrap = False
            Me.ErrorProvider1.SetIconAlignment(Me.tbCamOrientationX, Global.System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
            Me.tbCamOrientationX.Location = New Global.System.Drawing.Point(136, 264)
            Me.tbCamOrientationX.Name = "tbCamOrientationX"
            Me.tbCamOrientationX.Size = New Global.System.Drawing.Size(88, 20)
            Me.tbCamOrientationX.TabIndex = 5
            Me.tbCamOrientationX.Text = ""
            Me.tbCamOrientationX.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationX.Visible = False
            Me.tbCamOrientationX.WordWrap = False
            Me.tbCamOrientationY.Location = New Global.System.Drawing.Point(248, 264)
            Me.tbCamOrientationY.Name = "tbCamOrientationY"
            Me.tbCamOrientationY.Size = New Global.System.Drawing.Size(88, 20)
            Me.tbCamOrientationY.TabIndex = 6
            Me.tbCamOrientationY.Text = ""
            Me.tbCamOrientationY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationY.Visible = False
            Me.tbCamOrientationY.WordWrap = False
            Me.nudCamOrientationY.Location = New Global.System.Drawing.Point(232, 168)
            Me.nudCamOrientationY.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
            Me.nudCamOrientationY.Minimum = New Decimal(New Integer() {179, 0, 0, Integer.MinValue})
            Me.nudCamOrientationY.Name = "nudCamOrientationY"
            Me.nudCamOrientationY.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudCamOrientationY.TabIndex = 9
            Me.nudCamOrientationY.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.nudCamOrientationZ.Location = New Global.System.Drawing.Point(312, 168)
            Me.nudCamOrientationZ.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
            Me.nudCamOrientationZ.Minimum = New Decimal(New Integer() {179, 0, 0, Integer.MinValue})
            Me.nudCamOrientationZ.Name = "nudCamOrientationZ"
            Me.nudCamOrientationZ.Size = New Global.System.Drawing.Size(48, 20)
            Me.nudCamOrientationZ.TabIndex = 9
            Me.nudCamOrientationZ.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
            Me.Label14.Location = New Global.System.Drawing.Point(40, 168)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New Global.System.Drawing.Size(80, 16)
            Me.Label14.TabIndex = 3
            Me.Label14.Text = "Camera Angle"
            Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
            Me.ErrorProvider1.ContainerControl = Me
            Me.AutoScaleBaseSize = New Global.System.Drawing.Size(5, 13)
            Me.ClientSize = New Global.System.Drawing.Size(504, 389)
            Me.Controls.Add(Me.tabctrl)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button3)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
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

            ' -------------------------------------------------------------
            ' Event bindings restored from decompiled synchronized
            ' AccessedThroughProperty wrappers.
            ' -------------------------------------------------------------
            AddHandler Me.nudXY.ValueChanged, AddressOf Me.nudXY_ValueChanged
            AddHandler Me.nudXY.KeyUp, AddressOf Me.nudXY_KeyUp
            AddHandler Me.btnShowQuaternion.MouseUp, AddressOf Me.btnShowQuaternion_MouseUp
            AddHandler Me.btnShowQuaternion.MouseDown, AddressOf Me.btnShowQuaternion_MouseDown
            AddHandler Me.nudCamOrientationX.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
            AddHandler Me.nudCamOrientationY.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
            AddHandler Me.nudCamOrientationZ.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
            AddHandler Me.nudXYSpawnPointBearing.KeyUp, AddressOf Me.nudXYSpawnPointBearing_KeyUp
            AddHandler Me.nudXYSpawnPointBearing.ValueChanged, AddressOf Me.nudXYSpawnPointBearing_ValueChanged
            AddHandler Me.lbSpawnPoints.SelectedIndexChanged, AddressOf Me.lbSpawnPoints_SelectedIndexChanged
            AddHandler Me.btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
            Me.ResumeLayout(False)
        End Sub

    End Class
End Namespace
