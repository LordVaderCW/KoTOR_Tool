Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200003F RID: 63
	Public Partial Class frmAppearanceWizard
		Inherits frmParent

		' Token: 0x060001D5 RID: 469 RVA: 0x00228F04 File Offset: 0x00227F04
		Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmAppearanceWizard_Load
            Me.TabPage1.UseVisualStyleBackColor = False
            Me.TabPage2.UseVisualStyleBackColor = False

            Me.btnOK.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
            Me.InitializeComponent()

        End Sub

        ' Token: 0x0600025C RID: 604 RVA: 0x0022BE9C File Offset: 0x0022AE9C
        Private Sub frmAppearanceWizard_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.ApplyKotorTheme()

            Me.cmbxEnvMap.SelectedIndex = 0
            Me.cmbxGender.SelectedIndex = 0
            Me.cmbxModelNaming.SelectedIndex = 0
            Me.cmbxModelType.SelectedIndex = 0
            Me.cmbxMovementRate.SelectedIndex = 4
            Me.cmbxSizes.SelectedIndex = 1

            Me.tbHitRadius.Text = "0.25"
            Me.tbPerspace.Text = "0.35"
            Me.tbCreperspace.Text = "0.4"
            Me.tbprefatkdist.Text = "0.5"
        End Sub

        Private Sub ApplyKotorTheme()
            Dim theme As KotorTheme = KotorThemeManager.LoadTheme(KotorThemeManager.GetActiveThemeName())

            Me.BackColor = theme.WindowBack
            Me.ForeColor = theme.TextPrimary
            Me.Font = theme.CreateBodyFont()

            ApplyThemeToControl(Me, theme)
        End Sub

        Private Sub ApplyThemeToControl(ByVal parentControl As Control, ByVal theme As KotorTheme)
            If parentControl Is Nothing Then
                Return
            End If

            For Each childControl As Control In parentControl.Controls

                If TypeOf childControl Is TabControl Then
                    childControl.BackColor = theme.PanelRoot
                    childControl.ForeColor = theme.TextPrimary
                    childControl.Font = theme.CreateBodyFont()

                ElseIf TypeOf childControl Is TabPage Then
                    childControl.BackColor = theme.PanelBody
                    childControl.ForeColor = theme.TextPrimary
                    childControl.Font = theme.CreateBodyFont()

                ElseIf TypeOf childControl Is Label Then
                    childControl.BackColor = Color.Transparent
                    childControl.ForeColor = theme.TextSecondary
                    childControl.Font = theme.CreateBodyFont()

                ElseIf TypeOf childControl Is TextBox Then
                    childControl.BackColor = theme.ControlDark
                    childControl.ForeColor = theme.TextPrimary
                    childControl.Font = theme.CreateMonoFont()

                ElseIf TypeOf childControl Is ComboBox Then
                    childControl.BackColor = theme.ControlDark
                    childControl.ForeColor = theme.TextPrimary
                    childControl.Font = theme.CreateBodyFont()

                ElseIf TypeOf childControl Is Button Then
                    Dim buttonControl As Button = CType(childControl, Button)

                    buttonControl.BackColor = theme.ControlDark
                    buttonControl.ForeColor = theme.TextPrimary
                    buttonControl.FlatStyle = FlatStyle.Flat
                    buttonControl.FlatAppearance.BorderColor = theme.BorderDark
                    buttonControl.FlatAppearance.MouseOverBackColor = theme.ControlHover
                    buttonControl.FlatAppearance.MouseDownBackColor = theme.ControlDown
                    buttonControl.Font = theme.CreateBodyFont()

                ElseIf TypeOf childControl Is CheckBox Then
                    childControl.BackColor = theme.PanelBody
                    childControl.ForeColor = theme.TextSecondary
                    childControl.Font = theme.CreateBodyFont()
                End If

                If childControl.HasChildren Then
                    ApplyThemeToControl(childControl, theme)
                End If
            Next
        End Sub

        ' Token: 0x0600025D RID: 605 RVA: 0x0022BF34 File Offset: 0x0022AF34
        Public Function GetSizeString(ByVal index As Integer) As String
            Select Case index
                Case 1
                    Return "SML"
                Case 2
                    Return "MED"
                Case 3
                    Return "LRG"
                Case Else
                    Dim text As String
                    Return text
            End Select
        End Function

        ' Token: 0x0600025E RID: 606 RVA: 0x0022BF6C File Offset: 0x0022AF6C
        Public Function GetSizeLetter(ByVal index As Integer) As String
            Return Strings.Mid(Me.GetSizeString(index), 1, 1)
        End Function

        ' Token: 0x0600025F RID: 607 RVA: 0x0022BF88 File Offset: 0x0022AF88
        Public Function GetSpeedString() As String
            Select Case Me.cmbxMovementRate.SelectedIndex
                Case 0
                    Return "NOMOVE"
                Case 1
                    Return "WEE_FOLK"
                Case 2
                    Return "VSLOW"
                Case 3
                    Return "SLOW"
                Case 4
                    Return "NORM"
                Case 5
                    Return "FAST"
                Case 6
                    Return "VFAST"
                Case 7
                    Return "PLAYER"
                Case 8
                    Return "HUGE"
                Case 9
                    Return "GIANT"
                Case 10
                    Return "DFAST"
                Case Else
                    Dim text As String
                    Return text
            End Select
        End Function

        ' Token: 0x06000260 RID: 608 RVA: 0x0022C018 File Offset: 0x0022B018
        Public Sub FillRowCommonInfo(ByRef dr As DataRow)
            dr(0) = "512"
            dr(1) = "placeholder for name"
            dr(2) = "****"
            dr(3) = "****"
            dr(4) = "1.813"
            dr(5) = "3.96"
            dr(6) = "1.813"
            dr(7) = "3.96"
            dr(8) = "****"
            dr(9) = "B"
            dr(10) = "77"
            dr(11) = "PMBAL"
            dr(12) = ""
            dr(13) = ""
            dr(14) = ""
            dr(15) = ""
            dr(16) = ""
            dr(17) = ""
            dr(18) = ""
            dr(19) = ""
            dr(20) = ""
            dr(21) = ""
            dr(22) = ""
            dr(23) = ""
            dr(24) = ""
            dr(25) = ""
            dr(26) = ""
            dr(27) = ""
            dr(28) = ""
            dr(29) = ""
            dr(30) = ""
            dr(31) = ""
            dr(32) = "****"
            dr(33) = "****"
            dr(34) = "****"
            dr(35) = "****"
            dr(36) = "****"
            dr(37) = "****"
            dr(38) = "DEFAULT"
            dr(39) = "R"
            dr(40) = "****"
            dr(41) = "1"
            dr(42) = "NORM"
            dr(43) = "50"
            dr(44) = "5.4"
            dr(45) = "0.25"
            dr(46) = "0.35"
            dr(47) = "0.4"
            dr(48) = "****"
            dr(49) = "1.6"
            dr(50) = "l"
            dr(51) = "0"
            dr(52) = "20"
            dr(53) = "1"
            dr(54) = "1"
            dr(55) = "****"
            dr(56) = "****"
            dr(57) = "1"
            dr(58) = "3"
            dr(59) = "****"
            dr(60) = "****"
            dr(61) = "****"
            dr(62) = "****"
            dr(63) = "9"
            dr(64) = "0"
            dr(65) = "0"
            dr(66) = "1"
            dr(67) = "30"
            dr(68) = "15"
            dr(69) = "****"
            dr(70) = "1"
            dr(71) = "0.5"
            dr(72) = "0"
            dr(73) = "2"
            dr(74) = "****"
            dr(75) = "****"
            dr(76) = "****"
            dr(77) = "****"
            dr(78) = "****"
            dr(79) = "****"
            dr(80) = "****"
        End Sub

        ' Token: 0x06000261 RID: 609 RVA: 0x0022C48C File Offset: 0x0022B48C
        Public Sub GenerateModelStrings(ByVal size As Integer)
            Me.tbMa.Text = Me.tbBaseModelName.Text + "A" + Me.GetSizeLetter(size)
            Me.tbMb.Text = Me.tbBaseModelName.Text + "B" + Me.GetSizeLetter(size)
            Me.tbMc.Text = Me.tbBaseModelName.Text + "C" + Me.GetSizeLetter(size)
            Me.tbMd.Text = Me.tbBaseModelName.Text + "D" + Me.GetSizeLetter(size)
            Me.tbMe.Text = Me.tbBaseModelName.Text + "E" + Me.GetSizeLetter(size)
            Me.tbMf.Text = Me.tbBaseModelName.Text + "F" + Me.GetSizeLetter(size)
            Me.tbMg.Text = Me.tbBaseModelName.Text + "G" + Me.GetSizeLetter(size)
            Me.tbMh.Text = Me.tbBaseModelName.Text + "H" + Me.GetSizeLetter(size)
            Me.tbMi.Text = Me.tbBaseModelName.Text + "I" + Me.GetSizeLetter(size)
            Me.tbMj.Text = Me.tbBaseModelName.Text + "J" + Me.GetSizeLetter(size)
            Me.tbTa.Text = Me.tbBaseModelName.Text + "A"
            Me.tbTb.Text = Me.tbBaseModelName.Text + "B"
            Me.tbTc.Text = Me.tbBaseModelName.Text + "C"
            Me.tbTd.Text = Me.tbBaseModelName.Text + "D"
            Me.tbTe.Text = Me.tbBaseModelName.Text + "E"
            Me.tbTf.Text = Me.tbBaseModelName.Text + "F"
            Me.tbTg.Text = Me.tbBaseModelName.Text + "G"
            Me.tbTh.Text = Me.tbBaseModelName.Text + "H"
            Me.tbTi.Text = Me.tbBaseModelName.Text + "I"
            Me.tbTj.Text = Me.tbBaseModelName.Text + "J"
        End Sub

        ' Token: 0x06000262 RID: 610 RVA: 0x0022C760 File Offset: 0x0022B760
        Public Sub PropagateBaseModelString()
            Me.SetAllModelStrings(Me.tbBaseModelName.Text)
        End Sub

        ' Token: 0x06000263 RID: 611 RVA: 0x0022C774 File Offset: 0x0022B774
        Public Sub ClearAllModelStrings()
            Me.SetAllModelStrings("")
        End Sub

        ' Token: 0x06000264 RID: 612 RVA: 0x0022C784 File Offset: 0x0022B784
        Public Sub SetAllModelStrings(ByVal s As String)
            Me.tbMa.Text = s
            Me.tbMb.Text = s
            Me.tbMc.Text = s
            Me.tbMd.Text = s
            Me.tbMe.Text = s
            Me.tbMf.Text = s
            Me.tbMg.Text = s
            Me.tbMh.Text = s
            Me.tbMi.Text = s
            Me.tbMj.Text = s
            Me.tbTa.Text = s
            Me.tbTb.Text = s
            Me.tbTc.Text = s
            Me.tbTd.Text = s
            Me.tbTe.Text = s
            Me.tbTf.Text = s
            Me.tbTg.Text = s
            Me.tbTh.Text = s
            Me.tbTi.Text = s
            Me.tbTj.Text = s
        End Sub

        ' Token: 0x06000265 RID: 613 RVA: 0x0022C884 File Offset: 0x0022B884
        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TabControl1.SelectedIndexChanged
            If StringType.StrCmp(Strings.Trim(Me.tbBaseModelName.Text), "", False) <> 0 Then
                If Me.cmbxModelNaming.SelectedIndex = 1 Then
                    Me.GenerateModelStrings(1)
                Else
                    Me.PropagateBaseModelString()
                End If
            End If
        End Sub

        ' Token: 0x06000266 RID: 614 RVA: 0x0022C8C4 File Offset: 0x0022B8C4
        Private Sub cmbxModelNaming_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxModelNaming.SelectedIndexChanged
            Me.chkbAutoCreateSeqEntries.Visible = Me.cmbxModelNaming.SelectedIndex = 1
        End Sub

        ' Token: 0x06000267 RID: 615 RVA: 0x0022C8E0 File Offset: 0x0022B8E0
        Private Sub chkbAutoCreateSeqEntires_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkbAutoCreateSeqEntries.CheckedChanged
            Dim checked As Boolean = Me.chkbAutoCreateSeqEntries.Checked
            Me.tbMa.[ReadOnly] = checked
            Me.tbTa.[ReadOnly] = checked
            Me.tbEvilTexture.[ReadOnly] = checked
            Me.tbMb.[ReadOnly] = checked
            Me.tbTb.[ReadOnly] = checked
            Me.tbMc.[ReadOnly] = checked
            Me.tbTc.[ReadOnly] = checked
            Me.tbMd.[ReadOnly] = checked
            Me.tbTd.[ReadOnly] = checked
            Me.tbMe.[ReadOnly] = checked
            Me.tbTe.[ReadOnly] = checked
            Me.tbMf.[ReadOnly] = checked
            Me.tbTf.[ReadOnly] = checked
            Me.tbMg.[ReadOnly] = checked
            Me.tbTg.[ReadOnly] = checked
            Me.tbMh.[ReadOnly] = checked
            Me.tbTh.[ReadOnly] = checked
            Me.tbMi.[ReadOnly] = checked
            Me.tbTi.[ReadOnly] = checked
            Me.tbMj.[ReadOnly] = checked
            Me.tbTj.[ReadOnly] = checked
        End Sub

        ' Token: 0x04000197 RID: 407
        Public appearanceName As String
    End Class
End Namespace
