Option Strict Off
Option Explicit On

Imports System.Windows.Forms

Namespace kotor_tool

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class frmModuleItem_Base_Editor
        Inherits Global.kotor_tool.frmParent

        Private components As Global.System.ComponentModel.IContainer

        Friend WithEvents pnlRoot As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlHeader As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlBody As Global.System.Windows.Forms.Panel
        Friend WithEvents pnlFooter As Global.System.Windows.Forms.Panel
        Friend WithEvents lblTitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As Global.System.Windows.Forms.Label
        Friend WithEvents lblHeaderRule As Global.System.Windows.Forms.Label
        Friend WithEvents lblFooterRule As Global.System.Windows.Forms.Label

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
        Friend WithEvents tabctrl As Global.kotor_tool.CustomTabControl
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
        Friend WithEvents ErrorProvider1 As Global.System.Windows.Forms.ErrorProvider
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

        <Global.System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuleItem_Base_Editor))
            Me.pnlRoot = New System.Windows.Forms.Panel()
            Me.pnlBody = New System.Windows.Forms.Panel()
            Me.tabctrl = New kotor_tool.CustomTabControl()
            Me.tabpagGeneral = New System.Windows.Forms.TabPage()
            Me.tbXPosition = New System.Windows.Forms.TextBox()
            Me.tbYPosition = New System.Windows.Forms.TextBox()
            Me.tbZPosition = New System.Windows.Forms.TextBox()
            Me.tbTag = New System.Windows.Forms.TextBox()
            Me.tbResRef = New System.Windows.Forms.TextBox()
            Me.lblTag = New System.Windows.Forms.Label()
            Me.lblResRef = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pboxXY = New System.Windows.Forms.PictureBox()
            Me.nudXY = New System.Windows.Forms.NumericUpDown()
            Me.lblBearing = New System.Windows.Forms.Label()
            Me.tabpagWaypoint = New System.Windows.Forms.TabPage()
            Me.btnSetNameLang = New System.Windows.Forms.Button()
            Me.chkbHasMapNote = New System.Windows.Forms.CheckBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.tbWPLinkedTo = New System.Windows.Forms.TextBox()
            Me.tbWpDescription = New System.Windows.Forms.TextBox()
            Me.tbWpMapNote = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.tbWpLocalizedName = New System.Windows.Forms.TextBox()
            Me.lblLocalizedName = New System.Windows.Forms.Label()
            Me.chkbMapNoteEnabled = New System.Windows.Forms.CheckBox()
            Me.tabpagDoor = New System.Windows.Forms.TabPage()
            Me.gbTriggerNode = New System.Windows.Forms.GroupBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.tbTriggerNodeYPosition = New System.Windows.Forms.TextBox()
            Me.tbTriggerNodeXPosition = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.tbTriggerNodeZPosition = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.cmbxDoorLinkedToFlags = New System.Windows.Forms.ComboBox()
            Me.lblDoorLinkedTo = New System.Windows.Forms.Label()
            Me.tbDoorLinkedTo = New System.Windows.Forms.TextBox()
            Me.tbDoorLinkedToModule = New System.Windows.Forms.TextBox()
            Me.tbDoorLinkedToTransitionDestin = New System.Windows.Forms.TextBox()
            Me.lblDoorLinkedToFlags = New System.Windows.Forms.Label()
            Me.lblDoorLinkedToModule = New System.Windows.Forms.Label()
            Me.lblDoorLinkedToTransitionDestin = New System.Windows.Forms.Label()
            Me.lblTransitionMsg = New System.Windows.Forms.Label()
            Me.tabpagEncounter = New System.Windows.Forms.TabPage()
            Me.tbBearing = New System.Windows.Forms.TextBox()
            Me.tbxo = New System.Windows.Forms.TextBox()
            Me.tbyo = New System.Windows.Forms.TextBox()
            Me.pboxXYSpawnPointBearing = New System.Windows.Forms.PictureBox()
            Me.nudXYSpawnPointBearing = New System.Windows.Forms.NumericUpDown()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.nudSpawnPointX = New System.Windows.Forms.NumericUpDown()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.nudSpawnPointY = New System.Windows.Forms.NumericUpDown()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.nudSpawnPointZ = New System.Windows.Forms.NumericUpDown()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.lbSpawnPoints = New System.Windows.Forms.ListBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.tabpagCamera = New System.Windows.Forms.TabPage()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.nudCamOrientationX = New System.Windows.Forms.NumericUpDown()
            Me.btnShowQuaternion = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.tbCamPitch = New System.Windows.Forms.TextBox()
            Me.tbCamHeight = New System.Windows.Forms.TextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.tbCamMicRange = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.tbCamFieldOfView = New System.Windows.Forms.TextBox()
            Me.tbCamOrientationF1 = New System.Windows.Forms.TextBox()
            Me.tbCamOrientationF2 = New System.Windows.Forms.TextBox()
            Me.tbCamOrientationF4 = New System.Windows.Forms.TextBox()
            Me.tbCamOrientationF3 = New System.Windows.Forms.TextBox()
            Me.lblQuaternionW = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.tbCamOrientationZ = New System.Windows.Forms.TextBox()
            Me.tbCamOrientationX = New System.Windows.Forms.TextBox()
            Me.tbCamOrientationY = New System.Windows.Forms.TextBox()
            Me.nudCamOrientationY = New System.Windows.Forms.NumericUpDown()
            Me.nudCamOrientationZ = New System.Windows.Forms.NumericUpDown()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.pnlFooter = New System.Windows.Forms.Panel()
            Me.lblFooterRule = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblHeaderRule = New System.Windows.Forms.Label()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.pnlRoot.SuspendLayout()
            Me.pnlBody.SuspendLayout()
            Me.tabctrl.SuspendLayout()
            Me.tabpagGeneral.SuspendLayout()
            CType(Me.pboxXY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudXY, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagWaypoint.SuspendLayout()
            Me.tabpagDoor.SuspendLayout()
            Me.gbTriggerNode.SuspendLayout()
            Me.tabpagEncounter.SuspendLayout()
            CType(Me.pboxXYSpawnPointBearing, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudXYSpawnPointBearing, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSpawnPointX, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSpawnPointY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudSpawnPointZ, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabpagCamera.SuspendLayout()
            CType(Me.nudCamOrientationX, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCamOrientationY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCamOrientationZ, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFooter.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlRoot
            '
            Me.pnlRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlRoot.Controls.Add(Me.pnlBody)
            Me.pnlRoot.Controls.Add(Me.pnlFooter)
            Me.pnlRoot.Controls.Add(Me.pnlHeader)
            Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
            Me.pnlRoot.Name = "pnlRoot"
            Me.pnlRoot.Size = New System.Drawing.Size(520, 561)
            Me.pnlRoot.TabIndex = 0
            '
            'pnlBody
            '
            Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.pnlBody.Controls.Add(Me.tabctrl)
            Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBody.Location = New System.Drawing.Point(0, 67)
            Me.pnlBody.Name = "pnlBody"
            Me.pnlBody.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlBody.Size = New System.Drawing.Size(520, 432)
            Me.pnlBody.TabIndex = 1
            '
            'tabctrl
            '
            Me.tabctrl.Controls.Add(Me.tabpagGeneral)
            Me.tabctrl.Controls.Add(Me.tabpagWaypoint)
            Me.tabctrl.Controls.Add(Me.tabpagDoor)
            Me.tabctrl.Controls.Add(Me.tabpagEncounter)
            Me.tabctrl.Controls.Add(Me.tabpagCamera)
            Me.tabctrl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabctrl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabctrl.Location = New System.Drawing.Point(10, 10)
            Me.tabctrl.Name = "tabctrl"
            Me.tabctrl.SelectedIndex = 0
            Me.tabctrl.Size = New System.Drawing.Size(500, 412)
            Me.tabctrl.TabIndex = 6
            '
            'tabpagGeneral
            '
            Me.tabpagGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagGeneral.Location = New System.Drawing.Point(4, 22)
            Me.tabpagGeneral.Name = "tabpagGeneral"
            Me.tabpagGeneral.Size = New System.Drawing.Size(492, 386)
            Me.tabpagGeneral.TabIndex = 1
            Me.tabpagGeneral.Text = "General"
            '
            'tbXPosition
            '
            Me.tbXPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbXPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbXPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbXPosition.Location = New System.Drawing.Point(152, 92)
            Me.tbXPosition.Name = "tbXPosition"
            Me.tbXPosition.Size = New System.Drawing.Size(184, 22)
            Me.tbXPosition.TabIndex = 0
            Me.tbXPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbYPosition
            '
            Me.tbYPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbYPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbYPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbYPosition.Location = New System.Drawing.Point(152, 129)
            Me.tbYPosition.Name = "tbYPosition"
            Me.tbYPosition.Size = New System.Drawing.Size(184, 22)
            Me.tbYPosition.TabIndex = 1
            Me.tbYPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbZPosition
            '
            Me.tbZPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbZPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbZPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbZPosition.Location = New System.Drawing.Point(152, 166)
            Me.tbZPosition.Name = "tbZPosition"
            Me.tbZPosition.Size = New System.Drawing.Size(184, 22)
            Me.tbZPosition.TabIndex = 2
            Me.tbZPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbTag
            '
            Me.tbTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTag.Location = New System.Drawing.Point(152, 55)
            Me.tbTag.MaxLength = 16
            Me.tbTag.Name = "tbTag"
            Me.tbTag.Size = New System.Drawing.Size(184, 22)
            Me.tbTag.TabIndex = 4
            '
            'tbResRef
            '
            Me.tbResRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbResRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbResRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbResRef.Location = New System.Drawing.Point(152, 18)
            Me.tbResRef.MaxLength = 16
            Me.tbResRef.Name = "tbResRef"
            Me.tbResRef.Size = New System.Drawing.Size(184, 22)
            Me.tbResRef.TabIndex = 3
            '
            'lblTag
            '
            Me.lblTag.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblTag.Location = New System.Drawing.Point(40, 55)
            Me.lblTag.Name = "lblTag"
            Me.lblTag.Size = New System.Drawing.Size(96, 19)
            Me.lblTag.TabIndex = 1
            Me.lblTag.Text = "Tag"
            Me.lblTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblResRef
            '
            Me.lblResRef.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblResRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblResRef.Location = New System.Drawing.Point(40, 18)
            Me.lblResRef.Name = "lblResRef"
            Me.lblResRef.Size = New System.Drawing.Size(96, 19)
            Me.lblResRef.TabIndex = 1
            Me.lblResRef.Text = "TemplateResRef"
            Me.lblResRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(40, 92)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(88, 19)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "X Position"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(40, 129)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(88, 19)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Y Position"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(40, 166)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 19)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Z Position"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pboxXY
            '
            Me.pboxXY.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pboxXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pboxXY.Location = New System.Drawing.Point(402, 150)
            Me.pboxXY.Name = "pboxXY"
            Me.pboxXY.Size = New System.Drawing.Size(50, 58)
            Me.pboxXY.TabIndex = 2
            Me.pboxXY.TabStop = False
            '
            'nudXY
            '
            Me.nudXY.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudXY.DecimalPlaces = 2
            Me.nudXY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudXY.Location = New System.Drawing.Point(312, 214)
            Me.nudXY.Maximum = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            Me.nudXY.Name = "nudXY"
            Me.nudXY.Size = New System.Drawing.Size(170, 22)
            Me.nudXY.TabIndex = 4
            Me.nudXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblBearing
            '
            Me.lblBearing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBearing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblBearing.Location = New System.Drawing.Point(344, 169)
            Me.lblBearing.Name = "lblBearing"
            Me.lblBearing.Size = New System.Drawing.Size(48, 19)
            Me.lblBearing.TabIndex = 1
            Me.lblBearing.Text = "Bearing"
            Me.lblBearing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tabpagWaypoint
            '
            Me.tabpagWaypoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagWaypoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagWaypoint.Location = New System.Drawing.Point(4, 22)
            Me.tabpagWaypoint.Name = "tabpagWaypoint"
            Me.tabpagWaypoint.Size = New System.Drawing.Size(492, 386)
            Me.tabpagWaypoint.TabIndex = 3
            Me.tabpagWaypoint.Text = "Waypoint Specific"
            '
            'btnSetNameLang
            '
            Me.btnSetNameLang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnSetNameLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnSetNameLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnSetNameLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetNameLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSetNameLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnSetNameLang.Location = New System.Drawing.Point(390, 279)
            Me.btnSetNameLang.Name = "btnSetNameLang"
            Me.btnSetNameLang.Size = New System.Drawing.Size(96, 29)
            Me.btnSetNameLang.TabIndex = 10
            Me.btnSetNameLang.Text = "Set Language"
            Me.btnSetNameLang.UseVisualStyleBackColor = False
            '
            'chkbHasMapNote
            '
            Me.chkbHasMapNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbHasMapNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbHasMapNote.Location = New System.Drawing.Point(51, 149)
            Me.chkbHasMapNote.Name = "chkbHasMapNote"
            Me.chkbHasMapNote.Size = New System.Drawing.Size(192, 28)
            Me.chkbHasMapNote.TabIndex = 9
            Me.chkbHasMapNote.Text = "Waypoint Contains a Map Note"
            '
            'Label9
            '
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(48, 18)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(100, 19)
            Me.Label9.TabIndex = 8
            Me.Label9.Text = "Linked To"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbWPLinkedTo
            '
            Me.tbWPLinkedTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbWPLinkedTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbWPLinkedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbWPLinkedTo.Location = New System.Drawing.Point(176, 18)
            Me.tbWPLinkedTo.Name = "tbWPLinkedTo"
            Me.tbWPLinkedTo.Size = New System.Drawing.Size(208, 22)
            Me.tbWPLinkedTo.TabIndex = 5
            '
            'tbWpDescription
            '
            Me.tbWpDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbWpDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbWpDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbWpDescription.Location = New System.Drawing.Point(176, 74)
            Me.tbWpDescription.Multiline = True
            Me.tbWpDescription.Name = "tbWpDescription"
            Me.tbWpDescription.Size = New System.Drawing.Size(208, 69)
            Me.tbWpDescription.TabIndex = 2
            '
            'tbWpMapNote
            '
            Me.tbWpMapNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbWpMapNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbWpMapNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbWpMapNote.Location = New System.Drawing.Point(179, 183)
            Me.tbWpMapNote.Multiline = True
            Me.tbWpMapNote.Name = "tbWpMapNote"
            Me.tbWpMapNote.Size = New System.Drawing.Size(208, 69)
            Me.tbWpMapNote.TabIndex = 3
            '
            'Label11
            '
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(48, 74)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(100, 18)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Description"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label12
            '
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(51, 201)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(120, 18)
            Me.Label12.TabIndex = 7
            Me.Label12.Text = "Map Note"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbWpLocalizedName
            '
            Me.tbWpLocalizedName.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbWpLocalizedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbWpLocalizedName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbWpLocalizedName.Location = New System.Drawing.Point(176, 46)
            Me.tbWpLocalizedName.Name = "tbWpLocalizedName"
            Me.tbWpLocalizedName.Size = New System.Drawing.Size(208, 22)
            Me.tbWpLocalizedName.TabIndex = 2
            '
            'lblLocalizedName
            '
            Me.lblLocalizedName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblLocalizedName.Location = New System.Drawing.Point(48, 46)
            Me.lblLocalizedName.Name = "lblLocalizedName"
            Me.lblLocalizedName.Size = New System.Drawing.Size(100, 18)
            Me.lblLocalizedName.TabIndex = 6
            Me.lblLocalizedName.Text = "Localized Name"
            Me.lblLocalizedName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'chkbMapNoteEnabled
            '
            Me.chkbMapNoteEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkbMapNoteEnabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.chkbMapNoteEnabled.Location = New System.Drawing.Point(259, 149)
            Me.chkbMapNoteEnabled.Name = "chkbMapNoteEnabled"
            Me.chkbMapNoteEnabled.Size = New System.Drawing.Size(128, 28)
            Me.chkbMapNoteEnabled.TabIndex = 9
            Me.chkbMapNoteEnabled.Text = "Map Note Enabled"
            '
            'tabpagDoor
            '
            Me.tabpagDoor.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagDoor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagDoor.Location = New System.Drawing.Point(4, 22)
            Me.tabpagDoor.Name = "tabpagDoor"
            Me.tabpagDoor.Size = New System.Drawing.Size(492, 386)
            Me.tabpagDoor.TabIndex = 0
            Me.tabpagDoor.Text = "Door/Trigger Specific"
            '
            'gbTriggerNode
            '
            Me.gbTriggerNode.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
            Me.gbTriggerNode.Controls.Add(Me.Label23)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeYPosition)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeXPosition)
            Me.gbTriggerNode.Controls.Add(Me.Label22)
            Me.gbTriggerNode.Controls.Add(Me.tbTriggerNodeZPosition)
            Me.gbTriggerNode.Controls.Add(Me.Label21)
            Me.gbTriggerNode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.gbTriggerNode.Location = New System.Drawing.Point(25, 166)
            Me.gbTriggerNode.Name = "gbTriggerNode"
            Me.gbTriggerNode.Size = New System.Drawing.Size(442, 129)
            Me.gbTriggerNode.TabIndex = 9
            Me.gbTriggerNode.TabStop = False
            Me.gbTriggerNode.Text = "Trigger Node"
            Me.gbTriggerNode.Visible = False
            '
            'Label23
            '
            Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label23.Location = New System.Drawing.Point(23, 97)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(88, 18)
            Me.Label23.TabIndex = 6
            Me.Label23.Text = "Z Position"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbTriggerNodeYPosition
            '
            Me.tbTriggerNodeYPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTriggerNodeYPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTriggerNodeYPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTriggerNodeYPosition.Location = New System.Drawing.Point(135, 62)
            Me.tbTriggerNodeYPosition.Name = "tbTriggerNodeYPosition"
            Me.tbTriggerNodeYPosition.Size = New System.Drawing.Size(285, 22)
            Me.tbTriggerNodeYPosition.TabIndex = 4
            Me.tbTriggerNodeYPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'tbTriggerNodeXPosition
            '
            Me.tbTriggerNodeXPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTriggerNodeXPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTriggerNodeXPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTriggerNodeXPosition.Location = New System.Drawing.Point(135, 28)
            Me.tbTriggerNodeXPosition.Name = "tbTriggerNodeXPosition"
            Me.tbTriggerNodeXPosition.Size = New System.Drawing.Size(285, 22)
            Me.tbTriggerNodeXPosition.TabIndex = 5
            Me.tbTriggerNodeXPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label22
            '
            Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label22.Location = New System.Drawing.Point(23, 65)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(88, 18)
            Me.Label22.TabIndex = 7
            Me.Label22.Text = "Y Position"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbTriggerNodeZPosition
            '
            Me.tbTriggerNodeZPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbTriggerNodeZPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbTriggerNodeZPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbTriggerNodeZPosition.Location = New System.Drawing.Point(135, 97)
            Me.tbTriggerNodeZPosition.Name = "tbTriggerNodeZPosition"
            Me.tbTriggerNodeZPosition.Size = New System.Drawing.Size(285, 22)
            Me.tbTriggerNodeZPosition.TabIndex = 3
            Me.tbTriggerNodeZPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label21
            '
            Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label21.Location = New System.Drawing.Point(23, 28)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(88, 18)
            Me.Label21.TabIndex = 8
            Me.Label21.Text = "X Position"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbxDoorLinkedToFlags
            '
            Me.cmbxDoorLinkedToFlags.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.cmbxDoorLinkedToFlags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbxDoorLinkedToFlags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.cmbxDoorLinkedToFlags.Items.AddRange(New Object() {"Does not link to anything", "Is an Area Transition and links to a Door", "Is an Area Transition and links to a Waypoint"})
            Me.cmbxDoorLinkedToFlags.Location = New System.Drawing.Point(152, 9)
            Me.cmbxDoorLinkedToFlags.Name = "cmbxDoorLinkedToFlags"
            Me.cmbxDoorLinkedToFlags.Size = New System.Drawing.Size(272, 21)
            Me.cmbxDoorLinkedToFlags.TabIndex = 2
            '
            'lblDoorLinkedTo
            '
            Me.lblDoorLinkedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblDoorLinkedTo.Location = New System.Drawing.Point(40, 73)
            Me.lblDoorLinkedTo.Name = "lblDoorLinkedTo"
            Me.lblDoorLinkedTo.Size = New System.Drawing.Size(100, 19)
            Me.lblDoorLinkedTo.TabIndex = 1
            Me.lblDoorLinkedTo.Text = "Linked To"
            Me.lblDoorLinkedTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbDoorLinkedTo
            '
            Me.tbDoorLinkedTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbDoorLinkedTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDoorLinkedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDoorLinkedTo.Location = New System.Drawing.Point(152, 73)
            Me.tbDoorLinkedTo.Name = "tbDoorLinkedTo"
            Me.tbDoorLinkedTo.Size = New System.Drawing.Size(272, 22)
            Me.tbDoorLinkedTo.TabIndex = 0
            '
            'tbDoorLinkedToModule
            '
            Me.tbDoorLinkedToModule.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbDoorLinkedToModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDoorLinkedToModule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDoorLinkedToModule.Location = New System.Drawing.Point(152, 36)
            Me.tbDoorLinkedToModule.Name = "tbDoorLinkedToModule"
            Me.tbDoorLinkedToModule.Size = New System.Drawing.Size(272, 22)
            Me.tbDoorLinkedToModule.TabIndex = 0
            '
            'tbDoorLinkedToTransitionDestin
            '
            Me.tbDoorLinkedToTransitionDestin.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbDoorLinkedToTransitionDestin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbDoorLinkedToTransitionDestin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbDoorLinkedToTransitionDestin.Location = New System.Drawing.Point(152, 110)
            Me.tbDoorLinkedToTransitionDestin.Name = "tbDoorLinkedToTransitionDestin"
            Me.tbDoorLinkedToTransitionDestin.Size = New System.Drawing.Size(272, 22)
            Me.tbDoorLinkedToTransitionDestin.TabIndex = 0
            '
            'lblDoorLinkedToFlags
            '
            Me.lblDoorLinkedToFlags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblDoorLinkedToFlags.Location = New System.Drawing.Point(40, 9)
            Me.lblDoorLinkedToFlags.Name = "lblDoorLinkedToFlags"
            Me.lblDoorLinkedToFlags.Size = New System.Drawing.Size(100, 19)
            Me.lblDoorLinkedToFlags.TabIndex = 1
            Me.lblDoorLinkedToFlags.Text = "Linked To Flag"
            Me.lblDoorLinkedToFlags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDoorLinkedToModule
            '
            Me.lblDoorLinkedToModule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblDoorLinkedToModule.Location = New System.Drawing.Point(40, 36)
            Me.lblDoorLinkedToModule.Name = "lblDoorLinkedToModule"
            Me.lblDoorLinkedToModule.Size = New System.Drawing.Size(100, 19)
            Me.lblDoorLinkedToModule.TabIndex = 1
            Me.lblDoorLinkedToModule.Text = "Linked To Module"
            Me.lblDoorLinkedToModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDoorLinkedToTransitionDestin
            '
            Me.lblDoorLinkedToTransitionDestin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblDoorLinkedToTransitionDestin.Location = New System.Drawing.Point(40, 113)
            Me.lblDoorLinkedToTransitionDestin.Name = "lblDoorLinkedToTransitionDestin"
            Me.lblDoorLinkedToTransitionDestin.Size = New System.Drawing.Size(120, 18)
            Me.lblDoorLinkedToTransitionDestin.TabIndex = 1
            Me.lblDoorLinkedToTransitionDestin.Text = "Transition Destination"
            Me.lblDoorLinkedToTransitionDestin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTransitionMsg
            '
            Me.lblTransitionMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.lblTransitionMsg.Location = New System.Drawing.Point(30, 135)
            Me.lblTransitionMsg.Name = "lblTransitionMsg"
            Me.lblTransitionMsg.Size = New System.Drawing.Size(432, 19)
            Me.lblTransitionMsg.TabIndex = 1
            Me.lblTransitionMsg.Text = "Note: To enable the above fields, set the type to Transition in the Trigger edito" &
    "r."
            Me.lblTransitionMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblTransitionMsg.Visible = False
            '
            'tabpagEncounter
            '
            Me.tabpagEncounter.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagEncounter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagEncounter.Location = New System.Drawing.Point(4, 22)
            Me.tabpagEncounter.Name = "tabpagEncounter"
            Me.tabpagEncounter.Size = New System.Drawing.Size(492, 386)
            Me.tabpagEncounter.TabIndex = 5
            Me.tabpagEncounter.Text = "Encounter Specific"
            '
            'tbBearing
            '
            Me.tbBearing.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbBearing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbBearing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbBearing.Location = New System.Drawing.Point(59, 221)
            Me.tbBearing.Name = "tbBearing"
            Me.tbBearing.ReadOnly = True
            Me.tbBearing.Size = New System.Drawing.Size(104, 22)
            Me.tbBearing.TabIndex = 55
            Me.tbBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.tbBearing.Visible = False
            '
            'tbxo
            '
            Me.tbxo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbxo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbxo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbxo.Location = New System.Drawing.Point(59, 157)
            Me.tbxo.Name = "tbxo"
            Me.tbxo.ReadOnly = True
            Me.tbxo.Size = New System.Drawing.Size(104, 22)
            Me.tbxo.TabIndex = 54
            Me.tbxo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.tbxo.Visible = False
            '
            'tbyo
            '
            Me.tbyo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbyo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbyo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbyo.Location = New System.Drawing.Point(59, 184)
            Me.tbyo.Name = "tbyo"
            Me.tbyo.ReadOnly = True
            Me.tbyo.Size = New System.Drawing.Size(104, 22)
            Me.tbyo.TabIndex = 53
            Me.tbyo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.tbyo.Visible = False
            '
            'pboxXYSpawnPointBearing
            '
            Me.pboxXYSpawnPointBearing.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pboxXYSpawnPointBearing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pboxXYSpawnPointBearing.Location = New System.Drawing.Point(352, 39)
            Me.pboxXYSpawnPointBearing.Name = "pboxXYSpawnPointBearing"
            Me.pboxXYSpawnPointBearing.Size = New System.Drawing.Size(50, 58)
            Me.pboxXYSpawnPointBearing.TabIndex = 51
            Me.pboxXYSpawnPointBearing.TabStop = False
            '
            'nudXYSpawnPointBearing
            '
            Me.nudXYSpawnPointBearing.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudXYSpawnPointBearing.DecimalPlaces = 2
            Me.nudXYSpawnPointBearing.Enabled = False
            Me.nudXYSpawnPointBearing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudXYSpawnPointBearing.Location = New System.Drawing.Point(341, 112)
            Me.nudXYSpawnPointBearing.Maximum = New Decimal(New Integer() {736755711, 8381903, 0, 917504})
            Me.nudXYSpawnPointBearing.Name = "nudXYSpawnPointBearing"
            Me.nudXYSpawnPointBearing.Size = New System.Drawing.Size(80, 22)
            Me.nudXYSpawnPointBearing.TabIndex = 52
            Me.nudXYSpawnPointBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(338, 10)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(83, 21)
            Me.Label25.TabIndex = 50
            Me.Label25.Text = "Bearing"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label26
            '
            Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label26.Location = New System.Drawing.Point(167, 38)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(16, 18)
            Me.Label26.TabIndex = 48
            Me.Label26.Text = "X"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'nudSpawnPointX
            '
            Me.nudSpawnPointX.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudSpawnPointX.DecimalPlaces = 4
            Me.nudSpawnPointX.Enabled = False
            Me.nudSpawnPointX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudSpawnPointX.Location = New System.Drawing.Point(199, 38)
            Me.nudSpawnPointX.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudSpawnPointX.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.nudSpawnPointX.Name = "nudSpawnPointX"
            Me.nudSpawnPointX.Size = New System.Drawing.Size(96, 22)
            Me.nudSpawnPointX.TabIndex = 44
            Me.nudSpawnPointX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label27
            '
            Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label27.Location = New System.Drawing.Point(167, 75)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(16, 18)
            Me.Label27.TabIndex = 49
            Me.Label27.Text = "Y"
            Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'nudSpawnPointY
            '
            Me.nudSpawnPointY.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudSpawnPointY.DecimalPlaces = 4
            Me.nudSpawnPointY.Enabled = False
            Me.nudSpawnPointY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudSpawnPointY.Location = New System.Drawing.Point(199, 75)
            Me.nudSpawnPointY.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudSpawnPointY.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.nudSpawnPointY.Name = "nudSpawnPointY"
            Me.nudSpawnPointY.Size = New System.Drawing.Size(96, 22)
            Me.nudSpawnPointY.TabIndex = 45
            Me.nudSpawnPointY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label28
            '
            Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label28.Location = New System.Drawing.Point(167, 112)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(16, 18)
            Me.Label28.TabIndex = 47
            Me.Label28.Text = "Z"
            Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'nudSpawnPointZ
            '
            Me.nudSpawnPointZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudSpawnPointZ.DecimalPlaces = 4
            Me.nudSpawnPointZ.Enabled = False
            Me.nudSpawnPointZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudSpawnPointZ.Location = New System.Drawing.Point(199, 112)
            Me.nudSpawnPointZ.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
            Me.nudSpawnPointZ.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
            Me.nudSpawnPointZ.Name = "nudSpawnPointZ"
            Me.nudSpawnPointZ.Size = New System.Drawing.Size(96, 22)
            Me.nudSpawnPointZ.TabIndex = 46
            Me.nudSpawnPointZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label24
            '
            Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(28, 14)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(127, 17)
            Me.Label24.TabIndex = 43
            Me.Label24.Text = "Spawn Points"
            '
            'lbSpawnPoints
            '
            Me.lbSpawnPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.lbSpawnPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lbSpawnPoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.lbSpawnPoints.Location = New System.Drawing.Point(28, 34)
            Me.lbSpawnPoints.Name = "lbSpawnPoints"
            Me.lbSpawnPoints.ScrollAlwaysVisible = True
            Me.lbSpawnPoints.Size = New System.Drawing.Size(127, 106)
            Me.lbSpawnPoints.TabIndex = 42
            '
            'Label5
            '
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(27, 157)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(16, 18)
            Me.Label5.TabIndex = 48
            Me.Label5.Text = "X"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label5.Visible = False
            '
            'Label6
            '
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(27, 184)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(16, 19)
            Me.Label6.TabIndex = 49
            Me.Label6.Text = "Y"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label6.Visible = False
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(199, 10)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(96, 21)
            Me.Label7.TabIndex = 50
            Me.Label7.Text = "Position"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tabpagCamera
            '
            Me.tabpagCamera.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
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
            Me.tabpagCamera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tabpagCamera.Location = New System.Drawing.Point(4, 22)
            Me.tabpagCamera.Name = "tabpagCamera"
            Me.tabpagCamera.Size = New System.Drawing.Size(492, 386)
            Me.tabpagCamera.TabIndex = 2
            Me.tabpagCamera.Text = "Camera Specific"
            '
            'Label29
            '
            Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.Label29.Location = New System.Drawing.Point(256, 9)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(176, 46)
            Me.Label29.TabIndex = 10
            Me.Label29.Text = "(Use this value or the one below to set the camera's pitch but not both. Set unus" &
    "ed one to 0)"
            '
            'nudCamOrientationX
            '
            Me.nudCamOrientationX.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCamOrientationX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCamOrientationX.Location = New System.Drawing.Point(152, 194)
            Me.nudCamOrientationX.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
            Me.nudCamOrientationX.Minimum = New Decimal(New Integer() {179, 0, 0, -2147483648})
            Me.nudCamOrientationX.Name = "nudCamOrientationX"
            Me.nudCamOrientationX.Size = New System.Drawing.Size(48, 22)
            Me.nudCamOrientationX.TabIndex = 9
            Me.nudCamOrientationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnShowQuaternion
            '
            Me.btnShowQuaternion.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.btnShowQuaternion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.btnShowQuaternion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.btnShowQuaternion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.btnShowQuaternion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnShowQuaternion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnShowQuaternion.Location = New System.Drawing.Point(376, 194)
            Me.btnShowQuaternion.Name = "btnShowQuaternion"
            Me.btnShowQuaternion.Size = New System.Drawing.Size(24, 26)
            Me.btnShowQuaternion.TabIndex = 8
            Me.btnShowQuaternion.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(40, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(100, 19)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Pitch"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbCamPitch
            '
            Me.tbCamPitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamPitch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamPitch.Location = New System.Drawing.Point(152, 18)
            Me.tbCamPitch.Name = "tbCamPitch"
            Me.tbCamPitch.Size = New System.Drawing.Size(64, 22)
            Me.tbCamPitch.TabIndex = 0
            '
            'tbCamHeight
            '
            Me.tbCamHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamHeight.Location = New System.Drawing.Point(152, 55)
            Me.tbCamHeight.Name = "tbCamHeight"
            Me.tbCamHeight.Size = New System.Drawing.Size(64, 22)
            Me.tbCamHeight.TabIndex = 1
            '
            'Label15
            '
            Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label15.Location = New System.Drawing.Point(40, 55)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(100, 19)
            Me.Label15.TabIndex = 3
            Me.Label15.Text = "Height"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbCamMicRange
            '
            Me.tbCamMicRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamMicRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamMicRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamMicRange.Location = New System.Drawing.Point(152, 92)
            Me.tbCamMicRange.Name = "tbCamMicRange"
            Me.tbCamMicRange.Size = New System.Drawing.Size(64, 22)
            Me.tbCamMicRange.TabIndex = 2
            '
            'Label16
            '
            Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label16.Location = New System.Drawing.Point(40, 92)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(100, 19)
            Me.Label16.TabIndex = 3
            Me.Label16.Text = "Mic Range"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label17
            '
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(40, 129)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(100, 19)
            Me.Label17.TabIndex = 3
            Me.Label17.Text = "Field of View"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbCamFieldOfView
            '
            Me.tbCamFieldOfView.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamFieldOfView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamFieldOfView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamFieldOfView.Location = New System.Drawing.Point(152, 129)
            Me.tbCamFieldOfView.Name = "tbCamFieldOfView"
            Me.tbCamFieldOfView.Size = New System.Drawing.Size(64, 22)
            Me.tbCamFieldOfView.TabIndex = 3
            '
            'tbCamOrientationF1
            '
            Me.tbCamOrientationF1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamOrientationF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamOrientationF1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamOrientationF1.Location = New System.Drawing.Point(24, 258)
            Me.tbCamOrientationF1.Name = "tbCamOrientationF1"
            Me.tbCamOrientationF1.ReadOnly = True
            Me.tbCamOrientationF1.Size = New System.Drawing.Size(88, 22)
            Me.tbCamOrientationF1.TabIndex = 4
            Me.tbCamOrientationF1.Visible = False
            '
            'tbCamOrientationF2
            '
            Me.tbCamOrientationF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamOrientationF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamOrientationF2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamOrientationF2.Location = New System.Drawing.Point(136, 258)
            Me.tbCamOrientationF2.Name = "tbCamOrientationF2"
            Me.tbCamOrientationF2.ReadOnly = True
            Me.tbCamOrientationF2.Size = New System.Drawing.Size(88, 22)
            Me.tbCamOrientationF2.TabIndex = 5
            Me.tbCamOrientationF2.Visible = False
            '
            'tbCamOrientationF4
            '
            Me.tbCamOrientationF4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamOrientationF4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamOrientationF4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamOrientationF4.Location = New System.Drawing.Point(360, 258)
            Me.tbCamOrientationF4.Name = "tbCamOrientationF4"
            Me.tbCamOrientationF4.ReadOnly = True
            Me.tbCamOrientationF4.Size = New System.Drawing.Size(88, 22)
            Me.tbCamOrientationF4.TabIndex = 7
            Me.tbCamOrientationF4.Visible = False
            '
            'tbCamOrientationF3
            '
            Me.tbCamOrientationF3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamOrientationF3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamOrientationF3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamOrientationF3.Location = New System.Drawing.Point(248, 258)
            Me.tbCamOrientationF3.Name = "tbCamOrientationF3"
            Me.tbCamOrientationF3.ReadOnly = True
            Me.tbCamOrientationF3.Size = New System.Drawing.Size(88, 22)
            Me.tbCamOrientationF3.TabIndex = 6
            Me.tbCamOrientationF3.Visible = False
            '
            'lblQuaternionW
            '
            Me.lblQuaternionW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblQuaternionW.Location = New System.Drawing.Point(24, 231)
            Me.lblQuaternionW.Name = "lblQuaternionW"
            Me.lblQuaternionW.Size = New System.Drawing.Size(40, 18)
            Me.lblQuaternionW.TabIndex = 3
            Me.lblQuaternionW.Text = "W"
            Me.lblQuaternionW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblQuaternionW.Visible = False
            '
            'Label18
            '
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(160, 166)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(40, 19)
            Me.Label18.TabIndex = 3
            Me.Label18.Text = "Pitch"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label19
            '
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(240, 166)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(40, 19)
            Me.Label19.TabIndex = 3
            Me.Label19.Text = "Roll"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label20
            '
            Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label20.Location = New System.Drawing.Point(320, 166)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(40, 19)
            Me.Label20.TabIndex = 3
            Me.Label20.Text = "Yaw"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tbCamOrientationZ
            '
            Me.tbCamOrientationZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamOrientationZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamOrientationZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamOrientationZ.Location = New System.Drawing.Point(360, 305)
            Me.tbCamOrientationZ.Name = "tbCamOrientationZ"
            Me.tbCamOrientationZ.Size = New System.Drawing.Size(88, 22)
            Me.tbCamOrientationZ.TabIndex = 7
            Me.tbCamOrientationZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationZ.Visible = False
            Me.tbCamOrientationZ.WordWrap = False
            '
            'tbCamOrientationX
            '
            Me.tbCamOrientationX.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamOrientationX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamOrientationX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ErrorProvider1.SetIconAlignment(Me.tbCamOrientationX, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
            Me.tbCamOrientationX.Location = New System.Drawing.Point(136, 305)
            Me.tbCamOrientationX.Name = "tbCamOrientationX"
            Me.tbCamOrientationX.Size = New System.Drawing.Size(88, 22)
            Me.tbCamOrientationX.TabIndex = 5
            Me.tbCamOrientationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationX.Visible = False
            Me.tbCamOrientationX.WordWrap = False
            '
            'tbCamOrientationY
            '
            Me.tbCamOrientationY.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.tbCamOrientationY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tbCamOrientationY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tbCamOrientationY.Location = New System.Drawing.Point(248, 305)
            Me.tbCamOrientationY.Name = "tbCamOrientationY"
            Me.tbCamOrientationY.Size = New System.Drawing.Size(88, 22)
            Me.tbCamOrientationY.TabIndex = 6
            Me.tbCamOrientationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.tbCamOrientationY.Visible = False
            Me.tbCamOrientationY.WordWrap = False
            '
            'nudCamOrientationY
            '
            Me.nudCamOrientationY.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCamOrientationY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCamOrientationY.Location = New System.Drawing.Point(232, 194)
            Me.nudCamOrientationY.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
            Me.nudCamOrientationY.Minimum = New Decimal(New Integer() {179, 0, 0, -2147483648})
            Me.nudCamOrientationY.Name = "nudCamOrientationY"
            Me.nudCamOrientationY.Size = New System.Drawing.Size(48, 22)
            Me.nudCamOrientationY.TabIndex = 9
            Me.nudCamOrientationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'nudCamOrientationZ
            '
            Me.nudCamOrientationZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
            Me.nudCamOrientationZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.nudCamOrientationZ.Location = New System.Drawing.Point(312, 194)
            Me.nudCamOrientationZ.Maximum = New Decimal(New Integer() {179, 0, 0, 0})
            Me.nudCamOrientationZ.Minimum = New Decimal(New Integer() {179, 0, 0, -2147483648})
            Me.nudCamOrientationZ.Name = "nudCamOrientationZ"
            Me.nudCamOrientationZ.Size = New System.Drawing.Size(48, 22)
            Me.nudCamOrientationZ.TabIndex = 9
            Me.nudCamOrientationZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label14
            '
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(40, 194)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(80, 18)
            Me.Label14.TabIndex = 3
            Me.Label14.Text = "Camera Angle"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlFooter
            '
            Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.pnlFooter.Controls.Add(Me.lblFooterRule)
            Me.pnlFooter.Controls.Add(Me.Button1)
            Me.pnlFooter.Controls.Add(Me.Button2)
            Me.pnlFooter.Controls.Add(Me.Button3)
            Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlFooter.Location = New System.Drawing.Point(0, 499)
            Me.pnlFooter.Name = "pnlFooter"
            Me.pnlFooter.Size = New System.Drawing.Size(520, 62)
            Me.pnlFooter.TabIndex = 2
            '
            'lblFooterRule
            '
            Me.lblFooterRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(82, Byte), Integer))
            Me.lblFooterRule.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblFooterRule.Location = New System.Drawing.Point(0, 0)
            Me.lblFooterRule.Name = "lblFooterRule"
            Me.lblFooterRule.Size = New System.Drawing.Size(520, 1)
            Me.lblFooterRule.TabIndex = 0
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button1.Location = New System.Drawing.Point(18, 18)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 29)
            Me.Button1.TabIndex = 5
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = False
            Me.Button1.Visible = False
            '
            'Button2
            '
            Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button2.Location = New System.Drawing.Point(326, 18)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(80, 29)
            Me.Button2.TabIndex = 5
            Me.Button2.Text = "OK"
            Me.Button2.UseVisualStyleBackColor = False
            '
            'Button3
            '
            Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
            Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Button3.Location = New System.Drawing.Point(416, 18)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(80, 29)
            Me.Button3.TabIndex = 5
            Me.Button3.Text = "Cancel"
            Me.Button3.UseVisualStyleBackColor = False
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblHeaderRule)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(520, 67)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(18, 12)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(360, 23)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Module Item Editor"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSubtitle
            '
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(20, 37)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(440, 18)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Restored KoTOR Tool module placement and transition properties."
            Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHeaderRule
            '
            Me.lblHeaderRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.lblHeaderRule.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblHeaderRule.Location = New System.Drawing.Point(0, 65)
            Me.lblHeaderRule.Name = "lblHeaderRule"
            Me.lblHeaderRule.Size = New System.Drawing.Size(520, 2)
            Me.lblHeaderRule.TabIndex = 2
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.ContainerControl = Me
            '
            'frmModuleItem_Base_Editor
            '
            Me.AcceptButton = Me.Button2
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.CancelButton = Me.Button3
            Me.ClientSize = New System.Drawing.Size(520, 561)
            Me.Controls.Add(Me.pnlRoot)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmModuleItem_Base_Editor"
            Me.Text = "Module Item Editor"
            Me.pnlRoot.ResumeLayout(False)
            Me.pnlBody.ResumeLayout(False)
            Me.tabctrl.ResumeLayout(False)
            Me.tabpagGeneral.ResumeLayout(False)
            Me.tabpagGeneral.PerformLayout()
            CType(Me.pboxXY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudXY, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagWaypoint.ResumeLayout(False)
            Me.tabpagWaypoint.PerformLayout()
            Me.tabpagDoor.ResumeLayout(False)
            Me.tabpagDoor.PerformLayout()
            Me.gbTriggerNode.ResumeLayout(False)
            Me.gbTriggerNode.PerformLayout()
            Me.tabpagEncounter.ResumeLayout(False)
            Me.tabpagEncounter.PerformLayout()
            CType(Me.pboxXYSpawnPointBearing, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudXYSpawnPointBearing, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSpawnPointX, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSpawnPointY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudSpawnPointZ, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabpagCamera.ResumeLayout(False)
            Me.tabpagCamera.PerformLayout()
            CType(Me.nudCamOrientationX, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCamOrientationY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCamOrientationZ, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFooter.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()




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