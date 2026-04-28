Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000076 RID: 118
	Public Partial Class frmSSFEditor
		Inherits frmParent

		' Token: 0x06000F1B RID: 3867 RVA: 0x00292A20 File Offset: 0x00291A20
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSSFEditor_Load
			Me.InitializeComponent()
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.KotorVersionIndex = -1
		End Sub

		' Token: 0x0600101E RID: 4126 RVA: 0x00299CFC File Offset: 0x00298CFC
		Public Sub New(fs As FileStream, KotorVersionIndex As Integer)
			Me.New(New clsSSF(fs, KotorVersionIndex))
			fs.Close()
		End Sub

		' Token: 0x0600101F RID: 4127 RVA: 0x00299D14 File Offset: 0x00298D14
		Public Sub New(filepath As String, KotorVersionIndex As Integer)
			Me.New(New FileStream(filepath, FileMode.Open), KotorVersionIndex)
		End Sub

		' Token: 0x06001020 RID: 4128 RVA: 0x00299D24 File Offset: 0x00298D24
		Public Sub New(SSF As clsSSF)
			Me.New()
			Me._SSF = SSF
			Me.ParseSSF()
		End Sub

		' Token: 0x06001021 RID: 4129 RVA: 0x00299D3C File Offset: 0x00298D3C
		Private Function KotorVersion() As Integer
			Dim frmSpecifyKotorVersion As frmSpecifyKotorVersion = New frmSpecifyKotorVersion()
			frmSpecifyKotorVersion.btnCancel.Visible = False
			If frmSpecifyKotorVersion.ShowDialog(Me) = DialogResult.OK Then
				Return frmSpecifyKotorVersion.KotorVerIndexSelected
			End If
			Return -1
		End Function

        '' Token: 0x06001022 RID: 4130 RVA: 0x00299D70 File Offset: 0x00298D70
        'Private Sub ParseSSF()
        '	Dim num As Integer = 0
        '	Do
        '		Dim control As Control = Me.FindControlAndSetValue(Convert.ToString(num), StringType.FromInteger(Me._SSF.get_RefArray(num)))
        '		Me.FindControlAndSetValue("rr" + StringType.FromInteger(num), Me._SSF.get_RefArraySoundResRef(num))
        '		Dim control2 As Control = Me.FindControlAndSetValue("d" + StringType.FromInteger(num), Me._SSF.get_RefArrayString(num))
        '		AddHandler CType(control, NumericUpDown).ValueChanged, AddressOf Me.nud_ValueChanged
        '		AddHandler CType(control2, TextBox).MouseEnter, AddressOf Me.tbDesc_MouseEnter
        '		control.Enabled = True
        '		num += 1
        '	Loop While num <= 27
        'End Sub

        ' Token: 0x06001022 RID: 4130 RVA: 0x00299D70 File Offset: 0x00298D70
        Private Sub ParseSSF()
            Dim index As Integer = 0

            Do
                Dim nudControl As Control = Me.FindControlAndSetValue( _
                 Convert.ToString(index), _
                 StringType.FromInteger(Me._SSF.RefArray(index)) _
                )

                Me.FindControlAndSetValue( _
                 "rr" + StringType.FromInteger(index), _
                 Me._SSF.RefArraySoundResRef(index) _
                )

                Dim descControl As Control = Me.FindControlAndSetValue( _
                 "d" + StringType.FromInteger(index), _
                 Me._SSF.RefArrayString(index) _
                )

                AddHandler CType(nudControl, NumericUpDown).ValueChanged, AddressOf Me.nud_ValueChanged
                AddHandler CType(descControl, TextBox).MouseEnter, AddressOf Me.tbDesc_MouseEnter

                nudControl.Enabled = True
                index += 1
            Loop While index <= 27
        End Sub

		' Token: 0x06001023 RID: 4131 RVA: 0x00299E38 File Offset: 0x00298E38
		Private Sub LoadDialogTlk(Optional promptForVersion As Boolean = True)
			Dim flag As Boolean = False
			Dim text As String
			If Me.miUseK1DialogTlk.Checked AndAlso (Me.KotorVersionIndex = 1 OrElse Me.KotorVersionIndex = -1) Then
				text = Path.Combine(UserSettings.GetSettings().KotorLocation(0), "dialog.tlk")
				Me.KotorVersionIndex = 0
				flag = True
			End If
			If Me.miUseK2DialogTlk.Checked AndAlso (Me.KotorVersionIndex = 0 OrElse Me.KotorVersionIndex = -1) Then
				text = Path.Combine(UserSettings.GetSettings().KotorLocation(1), "dialog.tlk")
				Me.KotorVersionIndex = 1
				flag = True
			End If
			If Me.miAskDialogTlk.Checked AndAlso promptForVersion Then
				Dim num As Integer = Me.KotorVersion()
				If num = -1 Then
					Return
				End If
				If Me.KotorVersionIndex <> num Then
					Me.KotorVersionIndex = num
					text = Path.Combine(UserSettings.GetSettings().KotorLocation(Me.KotorVersionIndex), "dialog.tlk")
					flag = True
				End If
			End If
			If Me.miUseExtDialogTlk.Checked AndAlso (Me.KotorVersionIndex > -1 OrElse Me.g_dialogtlk Is Nothing) Then
				Me.g_dialogtlk = Nothing
				Me.GetExternalDialogTlk()
				Me.KotorVersionIndex = -1
			ElseIf flag Then
				Me.g_dialogtlk = New clsDialogTlk(text, True)
				Me.StatusBar1.Text = "Dialog.Tlk: " + text + " (KotOR I"
				If Me.KotorVersionIndex = 0 Then
					Dim statusBar As StatusBar = Me.StatusBar1
					statusBar.Text += ")"
				Else
					Dim statusBar As StatusBar = Me.StatusBar1
					statusBar.Text += "I)"
				End If
			End If
		End Sub

		' Token: 0x06001024 RID: 4132 RVA: 0x00299FB0 File Offset: 0x00298FB0
		Private Sub GetExternalDialogTlk()
			Dim text As String
			If frmMain.IsOnly1KotORInstalled() Then
				If frmMain.hasKotor1() Then
					text = UserSettings.GetSettings().KotorLocation(0)
				End If
				If frmMain.hasKotor2() Then
					text = UserSettings.GetSettings().KotorLocation(1)
				End If
			Else
				text = UserSettings.GetSettings().defaultImportLocation
			End If
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", text, "*.tlk", "Open Dialog.Tlk file...", "tlk", False, True))
			If objectValue.[GetType]() Is GetType(String) Then
				If ObjectType.ObjTst(objectValue, "", False) = 0 Then
					Return
				End If
				Dim text2 As String = StringType.FromObject(objectValue)
				If Not text2.ToLower().EndsWith(".tlk") AndAlso Interaction.MsgBox("The file you selected does not have a .TLK extension; do you want to open it?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "Questionable file extension") = MsgBoxResult.No Then
					Return
				End If
				Me.g_dialogtlk = New clsDialogTlk(text2, True)
				Me.StatusBar1.Text = "Dialog.Tlk: " + text2 + " (External)"
			End If
		End Sub

		' Token: 0x06001025 RID: 4133 RVA: 0x0029A094 File Offset: 0x00299094
		Public Sub SetFormName(Name As String)
			Me.Text = "SSF Editor - " + Name
		End Sub

		' Token: 0x06001026 RID: 4134 RVA: 0x0029A0A8 File Offset: 0x002990A8
		Private Function FindControlAndSetValue(tagStr As String, value As String) As Control
			Dim control2 As Control
			Try
				For Each obj As Object In Me.Panel1.Controls
					Dim control As Control = CType(obj, Control)
					If control.Tag IsNot Nothing AndAlso StringType.StrCmp(control.Tag.ToString(), tagStr, False) = 0 Then
						If StringType.StrCmp(control.[GetType]().Name, "NumericUpDown", False) = 0 Then
							CType(control, NumericUpDown).Value = New Decimal(Convert.ToDouble(value))
						Else
							control.Text = value
						End If
						control2 = control
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return control2
		End Function

		' Token: 0x06001027 RID: 4135 RVA: 0x0029A15C File Offset: 0x0029915C
		Public Sub EnableControls()
			Me.miSave.Enabled = True
			Me.miSaveAs.Enabled = True
		End Sub

        '' Token: 0x06001028 RID: 4136 RVA: 0x0029A184 File Offset: 0x00299184
        'Private Sub miNew_Click(sender As Object, e As EventArgs)
        '	Dim num As Integer = Me.KotorVersion()
        '	If num > -1 Then
        '		Me._SSF = New clsSSF(num)
        '		Dim num2 As Integer = 0
        '		Do
        '			Me._SSF.set_RefArray(num2, -1)
        '			num2 += 1
        '		Loop While num2 <= 39
        '		Me.ParseSSF()
        '		Me.EnableControls()
        '	End If
        'End Sub

        ' Token: 0x06001028 RID: 4136 RVA: 0x0029A184 File Offset: 0x00299184
        Private Sub miNew_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim kotorVersionIndex As Integer = Me.KotorVersion()

            If kotorVersionIndex > -1 Then
                Me._SSF = New clsSSF(kotorVersionIndex)

                Dim index As Integer = 0
                Do
                    Me._SSF.RefArray(index) = -1
                    index += 1
                Loop While index <= 39

                Me.ParseSSF()
                Me.EnableControls()
            End If
        End Sub

		' Token: 0x06001029 RID: 4137 RVA: 0x0029A1D4 File Offset: 0x002991D4
		Private Sub miOpen_Click(sender As Object, e As EventArgs)
			Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", Me.CurrentSettings.defaultSaveLocation, "", "Load SSF file...", "ssf", False, True))
			If StringType.StrCmp(text, "", False) = 0 Then
				Return
			End If
			Me.LoadDialogTlk(True)
			If Me.g_dialogtlk IsNot Nothing Then
				Me._SSF = New clsSSF(New FileStream(text, FileMode.Open), Me.g_dialogtlk)
				Me.ParseSSF()
				Me.SetFormName(text)
				Me.EnableControls()
			Else
				Interaction.MsgBox("Dialog.Tlk not loaded; opening of file aborted!", MsgBoxStyle.Exclamation, Nothing)
			End If
		End Sub

		' Token: 0x0600102A RID: 4138 RVA: 0x0029A268 File Offset: 0x00299268
		Private Sub miSave_Click(sender As Object, e As EventArgs)
			If StringType.StrCmp(Me.g_filepath, "", False) <> 0 Then
				Me._SSF.WriteFile(Me.g_filepath)
			Else
				Me.miSaveAs_Click(RuntimeHelpers.GetObjectValue(sender), e)
			End If
		End Sub

		' Token: 0x0600102B RID: 4139 RVA: 0x0029A2A0 File Offset: 0x002992A0
		Private Sub miSaveAs_Click(sender As Object, e As EventArgs)
			Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, "", "Save SSF file as...", "ssf", False, True))
			If StringType.StrCmp(text, "", False) <> 0 Then
				Me._SSF.WriteFile(text)
				Me.g_filepath = text
			End If
		End Sub

		' Token: 0x0600102C RID: 4140 RVA: 0x0029A2FC File Offset: 0x002992FC
		Private Sub miQuit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600102D RID: 4141 RVA: 0x0029A304 File Offset: 0x00299304
		Private Sub UseDialogTlk_Click(sender As Object, e As EventArgs)
			Me.miUseK1DialogTlk.Checked = False
			Me.miUseK2DialogTlk.Checked = False
			Me.miUseExtDialogTlk.Checked = False
			Me.miAskDialogTlk.Checked = False
			CType(sender, MenuItem).Checked = True
			Me.LoadDialogTlk(False)
		End Sub

        '' Token: 0x0600102E RID: 4142 RVA: 0x0029A354 File Offset: 0x00299354
        'Private Sub nud_ValueChanged(sender As Object, e As EventArgs)
        '	Dim num As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(sender, Nothing, "tag", New Object(-1) {}, Nothing, Nothing)))
        '	Me._SSF.set_RefArray(num, IntegerType.FromObject(LateBinding.LateGet(sender, Nothing, "Value", New Object(-1) {}, Nothing, Nothing)))
        '	Me.FindControlAndSetValue("rr" + StringType.FromInteger(num), Me._SSF.get_RefArraySoundResRef(num))
        '	Me.FindControlAndSetValue("d" + StringType.FromInteger(num), Me._SSF.get_RefArrayString(num))
        'End Sub

        ' Token: 0x0600102E RID: 4142 RVA: 0x0029A354 File Offset: 0x00299354
        Private Sub nud_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim nud As NumericUpDown = CType(sender, NumericUpDown)
            Dim index As Integer = Convert.ToInt32(nud.Tag)

            Me._SSF.RefArray(index) = Convert.ToInt32(nud.Value)

            Me.FindControlAndSetValue("rr" & StringType.FromInteger(index), Me._SSF.RefArraySoundResRef(index))
            Me.FindControlAndSetValue("d" & StringType.FromInteger(index), Me._SSF.RefArrayString(index))
        End Sub

		' Token: 0x0600102F RID: 4143 RVA: 0x0029A3FC File Offset: 0x002993FC
		Private Sub frmSSFEditor_Load(sender As Object, e As EventArgs)
			Me.miUseK1DialogTlk.Visible = frmMain.hasKotor1()
			Me.miUseK2DialogTlk.Visible = frmMain.hasKotor2()
		End Sub

		' Token: 0x06001030 RID: 4144 RVA: 0x0029A420 File Offset: 0x00299420
		Private Sub tbDesc_MouseEnter(sender As Object, e As EventArgs)
			Me.ToolTip1.SetToolTip(CType(sender, Control), CType(sender, TextBox).Text)
		End Sub

		' Token: 0x040007D1 RID: 2001
		Private _SSF As clsSSF

		' Token: 0x040007D2 RID: 2002
		Private g_dialogtlk As clsDialogTlk

		' Token: 0x040007D3 RID: 2003
		Private g_filepath As String
	End Class
End Namespace
