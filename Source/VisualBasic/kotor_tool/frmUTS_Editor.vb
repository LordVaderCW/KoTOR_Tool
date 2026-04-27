Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports FMOD
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000082 RID: 130
	Public Partial Class frmUTS_Editor
		Inherits frmParent

		' Token: 0x14000001 RID: 1
		' (add) Token: 0x06001541 RID: 5441 RVA: 0x002BF084 File Offset: 0x002BE084
		' (remove) Token: 0x06001540 RID: 5440 RVA: 0x002BF0A0 File Offset: 0x002BE0A0
		Public Event StoppedPlaying As frmUTS_Editor.StoppedPlayingEventHandler

		' Token: 0x06001542 RID: 5442 RVA: 0x002BF0BC File Offset: 0x002BE0BC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTS_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTS_Editor_Closing
			Me.m_bSaveGameMode = False
			Me.fmSystem = Nothing
			Me.sound1 = Nothing
			Me.channel = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x06001623 RID: 5667 RVA: 0x002C48A0 File Offset: 0x002C38A0
		Public Sub New(UTSClass As clsUTS, KotorVerIndex As Integer, Optional IsDirectEdit As Boolean = False, Optional EditingPath As String = "")
			Me.New()
			If IsDirectEdit Then
				Me.m_bSaveGameMode = True
				Me.m_EditingFilePath = EditingPath
			End If
			Me.m_defaultTitleText = "Sound Editor - KotOR "
			Me.Text = Me.m_defaultTitleText
			If KotorVerIndex = 0 Then
				Me.Text += "I"
			Else
				Me.Text += "II"
			End If
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.UTS = UTSClass
			Me.KotorVersionIndex = KotorVerIndex
			Me.Setup()
			Me.result = Factory.System_Create(Me.fmSystem)
			Me.result = Me.fmSystem.getVersion(Me.FMODversion)
			If Convert.ToInt32(Me.FMODversion) < Convert.ToInt32(262405) Then
				MessageBox.Show(String.Concat(New String() { "Error!  You are using an old version of FMOD ", Me.FMODversion.ToString("X"), ".  This program requires ", 262405.ToString("X"), "." }))
			End If
			Me.result = Me.fmSystem.init(32, INITFLAG.NORMAL, CType((If(Nothing, Activator.CreateInstance(GetType(IntPtr)))), IntPtr))
			Me.htBIFSounds = frmMain.KxChitinKey(Me.KotorVersionIndex).GetBIFFileHash("sounds")
			Me.SoundsBifPath = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\"
			Me.SoundsBifPath += CType(frmMain.KxChitinKey(Me.KotorVersionIndex).BiffListInfo("sounds"), BIFFEntry).filename
			Me.SoundsResInfo = BIFFArchive.GetBIFFResourceInfoList(Me.SoundsBifPath)
		End Sub

		' Token: 0x06001624 RID: 5668 RVA: 0x002C4A74 File Offset: 0x002C3A74
		Private Sub Setup()
			Me.UTS.SetTextBoxFromCExoLocStringNodeValue(Me.tbName, "LocName")
			Me.UTS.SetTextBoxToNodeValue(Me.tbTag, "Tag")
			Me.UTS.SetTextBoxToNodeValue(Me.tbComment, "Comment")
			Me.trkbarVolume.Value = IntegerType.FromObject(Me.UTS.GetNodeValue("Volume"))
			Me.trkbarVolume_ValueChanged(Nothing, Nothing)
			Dim num As Integer = 0
			Dim num2 As Integer = Me.UTS.GetListItemCount("Sounds") - 1
			For i As Integer = num To num2
				Me.lbSounds.Items.Add(RuntimeHelpers.GetObjectValue(Me.UTS.GetNodeValue("Sounds(" + StringType.FromInteger(i) + ").Sound")))
			Next
			Dim flag As Boolean = BooleanType.FromObject(Me.UTS.GetNodeValue("Positional"))
			Dim flag2 As Boolean = BooleanType.FromObject(Me.UTS.GetNodeValue("RandomPosition"))
			If Not flag AndAlso Not flag2 Then
				Me.rbPlaysEverywhere.Checked = True
			ElseIf flag AndAlso flag2 Then
				Me.rbRandomPosition.Checked = True
			Else
				Me.rbSpecificPosition.Checked = True
			End If
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudMaxDistance, "MaxDistance", 0F)
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudMinDistance, "MinDistance", 0F)
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudElevation, "Elevation", 0F)
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudRandomRangeX, "RandomRangeX", 0F)
			Me.UTS.SetNumericUpDownToNodeValue(Me.nudRandomRangeY, "RandomRangeY", 0F)
			Me.chkbActive.Checked = BooleanType.FromObject(Me.UTS.GetNodeValue("Active"))
			Dim nodeValue As Object = Me.UTS.GetNodeValue("Times")
			If ObjectType.ObjTst(nodeValue, 1, False) = 0 Then
				Me.rbPlayDay.Checked = True
			ElseIf ObjectType.ObjTst(nodeValue, 2, False) = 0 Then
				Me.rbPlayNight.Checked = True
			ElseIf ObjectType.ObjTst(nodeValue, 3, False) = 0 Then
				Me.rbPlayAllTimes.Checked = True
			ElseIf ObjectType.ObjTst(nodeValue, 0, False) = 0 Then
				Me.rbPlaySpecificHours.Checked = True
				Dim num3 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTS.GetNodeValue("Hours")))
				Try
					For Each obj As Object In Me.pnlHours.Controls
						Dim control As Control = CType(obj, Control)
						If StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0 AndAlso (CLng(num3) And CLng(Math.Round(Math.Pow(2.0, CDbl(Convert.ToInt32(RuntimeHelpers.GetObjectValue(control.Tag))))))) <> 0L Then
							CType(control, CheckBox).Checked = True
						End If
					Next
				Finally
                    Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Dim flag3 As Boolean = BooleanType.FromObject(Me.UTS.GetNodeValue("Continuous"))
			Dim flag4 As Boolean = BooleanType.FromObject(Me.UTS.GetNodeValue("Looping"))
			If Not flag3 AndAlso Not flag4 Then
				Me.rbOnce.Checked = True
			ElseIf flag3 And Not flag4 Then
				Me.rbRepeating.Checked = True
			ElseIf Not flag3 AndAlso flag4 Then
				Me.rbLooping.Checked = True
			End If
			If BooleanType.FromObject(Me.UTS.GetNodeValue("Random")) Then
				Me.rbRandom.Checked = True
			Else
				Me.rbSequential.Checked = True
			End If
			Me.UTS.SetNumericUpDownToUIntNodeValue(Me.nudInterval, "Interval", 0.01F)
			Me.UTS.SetNumericUpDownToUIntNodeValue(Me.nudIntervalVrtn, "IntervalVrtn", 0.01F)
			Me.trkbarVolumeVrtn.Value = IntegerType.FromObject(Me.UTS.GetNodeValue("VolumeVrtn"))
			Me.trkbarVolumeVrtn_ValueChanged(Nothing, Nothing)
			Me.trkbarPitchVrtn.Value = IntegerType.FromObject(ObjectType.MulObj(Me.UTS.GetNodeValue("PitchVariation"), 100))
			Me.trkbarPitchVrtn_ValueChanged(Nothing, Nothing)
		End Sub

		' Token: 0x06001625 RID: 5669 RVA: 0x002C4EE0 File Offset: 0x002C3EE0
		Private Sub SetGFFNodeValues()
			Me.UTS.SetCExoLocStringNodeValueFromTextBox(Me.tbName, "LocName", Me.NameLang)
			Me.UTS.SetNodeValueFromTextBox(Me.tbTag, "Tag")
			Me.UTS.SetNodeValueFromTextBox(Me.tbComment, "Comment")
			Me.UTS.SetNodeValue("Volume", Me.trkbarVolume.Value)
			Me.UTS.ClearListElements("Sounds")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.lbSounds.Items.Count - 1
			For i As Integer = num To num2
				Dim gff_Struct As GFF_Struct = New GFF_Struct(1, 0)
				gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "Sound", RuntimeHelpers.GetObjectValue(Me.lbSounds.Items(i)))
				Me.UTS.AddListElement("Sounds", gff_Struct)
			Next
			Me.UTS.SetNodeValue("Positional", Not Me.rbPlaysEverywhere.Checked)
			Me.UTS.SetNodeValue("RandomPosition", Me.rbRandomPosition.Checked)
			If Me.rbPlaysEverywhere.Checked Then
				Me.UTS.SetNodeValue("Positional", Not Me.rbPlaysEverywhere.Checked)
			Else
				Me.UTS.SetNodeValue("Positional", Not Me.rbPlaysEverywhere.Checked)
			End If
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudMaxDistance, "MaxDistance", 0F)
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudMinDistance, "MinDistance", 0F)
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudElevation, "Elevation", 0F)
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudRandomRangeX, "RandomRangeX", 0F)
			Me.UTS.SetNodeValueFromNumericUpDown(Me.nudRandomRangeY, "RandomRangeY", 0F)
			Me.UTS.SetNodeValue("Active", Me.chkbActive.Checked)
			If Me.rbPlayDay.Checked Then
				Me.UTS.SetNodeValue("Times", 1)
			ElseIf Me.rbPlayNight.Checked Then
				Me.UTS.SetNodeValue("Times", 2)
			ElseIf Me.rbPlayAllTimes.Checked Then
				Me.UTS.SetNodeValue("Times", 3)
			Else
				Me.UTS.SetNodeValue("Times", 0)
				Dim num3 As Integer = 0
				Try
					For Each obj As Object In Me.pnlHours.Controls
						Dim control As Control = CType(obj, Control)
						If StringType.StrCmp(control.[GetType]().Name, "CheckBox", False) = 0 AndAlso CType(control, CheckBox).Checked Then
							' The following expression was wrapped in a unchecked-expression
							num3 = CInt((CLng(num3) Or CLng(Math.Round(Math.Pow(2.0, CDbl(Convert.ToInt32(RuntimeHelpers.GetObjectValue(control.Tag))))))))
						End If
					Next
				Finally
                    Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.UTS.SetNodeValue("Hours", num3)
			End If
			Me.UTS.SetNodeValue("Continuous", Me.rbRepeating.Checked)
			Me.UTS.SetNodeValue("Looping", Me.rbLooping.Checked)
			Me.UTS.SetNodeValue("Random", Me.rbRandom.Checked)
			Me.UTS.SetUInt32NodeValueFromNumericUpDown(Me.nudInterval, "Interval", 0.01F)
			Me.UTS.SetUInt32NodeValueFromNumericUpDown(Me.nudIntervalVrtn, "IntervalVrtn", 0.01F)
			Me.UTS.SetNodeValue("VolumeVrtn", Me.trkbarVolumeVrtn.Value)
			Me.UTS.SetNodeValue("PitchVariation", CDbl(Me.trkbarPitchVrtn.Value) / 100.0)
		End Sub

		' Token: 0x06001626 RID: 5670 RVA: 0x002C5334 File Offset: 0x002C4334
		Private Sub btnAddSound_Click(sender As Object, e As EventArgs)
			Dim frmSoundChooser As frmSoundChooser = New frmSoundChooser()
			frmSoundChooser.SoundBifFilesHash = Me.htBIFSounds
			If Me.htStreamSounds Is Nothing Then
				Me.htStreamSounds = New Hashtable()
				Dim directoryInfo As DirectoryInfo = New DirectoryInfo(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamSounds")
				For Each fileInfo As FileInfo In directoryInfo.GetFiles()
					Me.htStreamSounds.Add(fileInfo.Name, Nothing)
				Next
			End If
			frmSoundChooser.StreamSoundsFilesHash = Me.htStreamSounds
			frmSoundChooser.ShowDialog(Me)
			If frmSoundChooser.DialogResult = DialogResult.OK Then
				Try
					For Each obj As Object In frmSoundChooser.SelectedSounds
						Dim text As String = StringType.FromObject(obj)
						If text.Length > 16 Then
							Interaction.MsgBox(String.Concat(New String() { "The sound """, text, """", " must be renamed to be no more than 16 characters long, not including the extension, to be used.", vbLf, vbLf, "The sound will not be added." }), MsgBoxStyle.Critical, "ResRef too long")
						Else
							Me.lbSounds.Items.Add(text)
						End If
					Next
				Finally
                    Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Me.UpdateUI()
		End Sub

		' Token: 0x06001627 RID: 5671 RVA: 0x002C54A8 File Offset: 0x002C44A8
		Private Sub btnRemoveSound_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.lbSounds.SelectedIndices.Count = 1 Then
				Me.lbSounds.Items.RemoveAt(Me.lbSounds.SelectedIndex)
			ElseIf Me.lbSounds.SelectedIndices.Count > 1 AndAlso Interaction.MsgBox("Remove all " + StringType.FromInteger(Me.lbSounds.SelectedIndices.Count) + " sounds?", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Confirm removal") = MsgBoxResult.Ok Then
				For i As Integer = Me.lbSounds.SelectedIndices.Count - 1 To 0 Step -1
					Me.lbSounds.Items.RemoveAt(Me.lbSounds.SelectedIndices(i))
				Next
			End If
			Me.UpdateUI()
		End Sub

		' Token: 0x06001628 RID: 5672 RVA: 0x002C5578 File Offset: 0x002C4578
		Private Sub btnPlaySound_Click(sender As Object, e As EventArgs)
			If Me.PlaySound(StringType.FromObject(ObjectType.StrCatObj(Me.lbSounds.SelectedItem, ".wav"))) Then
				Me.btnPlaySound.Enabled = False
				Me.btnStopSound.Enabled = True
			End If
		End Sub

		' Token: 0x06001629 RID: 5673 RVA: 0x002C55B4 File Offset: 0x002C45B4
		Private Sub btnStopSound_Click(sender As Object, e As EventArgs)
			Me.StopSound()
		End Sub

		' Token: 0x0600162A RID: 5674 RVA: 0x002C55BC File Offset: 0x002C45BC
		Private Sub btnMoveUp_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lbSounds.SelectedIndex
			If selectedIndex > 0 Then
				Dim text As String = StringType.FromObject(Me.lbSounds.SelectedItem)
				Me.lbSounds.Items(selectedIndex) = RuntimeHelpers.GetObjectValue(Me.lbSounds.Items(selectedIndex - 1))
				Me.lbSounds.Items(selectedIndex - 1) = text
				Dim lbSounds As ListBox = Me.lbSounds
				lbSounds.SelectedIndex -= 1
			End If
		End Sub

		' Token: 0x0600162B RID: 5675 RVA: 0x002C563C File Offset: 0x002C463C
		Private Sub btnMoveDown_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lbSounds.SelectedIndex
			If selectedIndex < Me.lbSounds.Items.Count - 1 Then
				Dim text As String = StringType.FromObject(Me.lbSounds.SelectedItem)
				Me.lbSounds.Items(selectedIndex) = RuntimeHelpers.GetObjectValue(Me.lbSounds.Items(selectedIndex + 1))
				Me.lbSounds.Items(selectedIndex + 1) = text
				Dim lbSounds As ListBox = Me.lbSounds
				lbSounds.SelectedIndex += 1
			End If
		End Sub

		' Token: 0x0600162C RID: 5676 RVA: 0x002C56D0 File Offset: 0x002C46D0
		Private Sub btnSetNameLang_Click(sender As Object, e As EventArgs)
			Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
			If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
				Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
			End If
		End Sub

		' Token: 0x0600162D RID: 5677 RVA: 0x002C5700 File Offset: 0x002C4700
		Private Sub btnDebug_Click(sender As Object, e As EventArgs)
			Dim frmTextEditor As frmTextEditor = New frmTextEditor()
			frmTextEditor.Filename = Me.tbName.Text + ".uts"
			frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
			frmTextEditor.RTFMode = True
			frmTextEditor.tbGeneric.Rtf = Me.UTS.ToString()
			frmTextEditor.tbGeneric.SelectionLength = 0
			frmTextEditor.Show()
		End Sub

		' Token: 0x0600162E RID: 5678 RVA: 0x002C5774 File Offset: 0x002C4774
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Me.SetGFFNodeValues()
			If Not Me.m_bSaveGameMode Then
				Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".uts", "", "", False, True))
				If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
					Return
				End If
			End If
			Me.UTS.WriteFile(Me.m_EditingFilePath, "UTS")
			If Me.m_bSaveGameMode Then
				Me.Close()
			End If
		End Sub

		' Token: 0x0600162F RID: 5679 RVA: 0x002C580C File Offset: 0x002C480C
		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06001630 RID: 5680 RVA: 0x002C5814 File Offset: 0x002C4814
		Private Sub lbSounds_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.lbSounds.SelectedIndex = -1 Then
				Me.btnMoveUp.Enabled = False
				Me.btnMoveDown.Enabled = False
				Me.btnRemoveSound.Enabled = False
				Me.btnPlaySound.Enabled = False
				Me.IsItemSelected = False
			Else
				Me.IsItemSelected = True
				If Not Me.IsSoundPlaying() Then
					Me.btnPlaySound.Enabled = True
				End If
				Me.btnRemoveSound.Enabled = True
				If(Me.lbSounds.Items.Count = 1) Or (Me.lbSounds.SelectedIndices.Count > 1) Then
					Me.btnMoveUp.Enabled = False
					Me.btnMoveDown.Enabled = False
				ElseIf Me.lbSounds.SelectedIndices.Count = 1 Then
					' The following expression was wrapped in a checked-expression
					If Me.lbSounds.SelectedIndex = Me.lbSounds.Items.Count - 1 Then
						Me.btnMoveUp.Enabled = True
						Me.btnMoveDown.Enabled = False
					ElseIf Me.lbSounds.SelectedIndex = 0 Then
						Me.btnMoveUp.Enabled = False
						Me.btnMoveDown.Enabled = True
					Else
						Me.btnMoveUp.Enabled = True
						Me.btnMoveDown.Enabled = True
					End If
				End If
			End If
		End Sub

		' Token: 0x06001631 RID: 5681 RVA: 0x002C5964 File Offset: 0x002C4964
		Private Sub lbSounds_DoubleClick(sender As Object, e As EventArgs)
			If(Me.lbSounds.SelectedIndex <> -1) And Not Me.IsSoundPlaying() Then
				Me.btnPlaySound_Click(Nothing, Nothing)
			End If
		End Sub

		' Token: 0x06001632 RID: 5682 RVA: 0x002C598C File Offset: 0x002C498C
		Private Sub rbPlaysWhere_CheckedChanged(sender As Object, e As EventArgs)
			Me.gbHeight.Enabled = Not Me.rbPlaysEverywhere.Checked
			Me.gbVolumeDistances.Enabled = Not Me.rbPlaysEverywhere.Checked
			Me.gbRandomRange.Enabled = Me.rbRandomPosition.Checked
		End Sub

		' Token: 0x06001633 RID: 5683 RVA: 0x002C59E4 File Offset: 0x002C49E4
		Private Sub rbPlayDay_CheckedChanged(sender As Object, e As EventArgs)
			Me.pnlHours.Enabled = Me.rbPlaySpecificHours.Checked
		End Sub

		' Token: 0x06001634 RID: 5684 RVA: 0x002C59FC File Offset: 0x002C49FC
		Private Sub rbLooping_CheckedChanged(sender As Object, e As EventArgs)
			Me.rbSequential.Enabled = Not Me.rbLooping.Checked
			Me.rbRandom.Enabled = Not Me.rbLooping.Checked
			Me.pnlVolPitch.Enabled = Not Me.rbLooping.Checked
			Me.gbInterval.Enabled = Me.rbRepeating.Checked
			If Me.rbLooping.Checked Then
				If Me.rbRandomPosition.Checked Then
					Me.rbPlaysEverywhere.Checked = True
				End If
				Me.rbSequential.Checked = True
			End If
			Me.rbRandomPosition.Enabled = Not Me.rbLooping.Checked
		End Sub

		' Token: 0x06001635 RID: 5685 RVA: 0x002C5AB8 File Offset: 0x002C4AB8
		Private Sub frmUTS_Editor_Load(sender As Object, e As EventArgs)
			Me.PositionWindow(Me.[GetType]().Name)
		End Sub

		' Token: 0x06001636 RID: 5686 RVA: 0x002C5ACC File Offset: 0x002C4ACC
		Private Sub frmUTS_Editor_Closing(sender As Object, e As CancelEventArgs)
			Me.SaveSettings(Me.[GetType]().Name)
			Me.ClosedownSound()
		End Sub

		' Token: 0x06001637 RID: 5687 RVA: 0x002C5AE8 File Offset: 0x002C4AE8
		Private Sub trkbarVolumeVrtn_ValueChanged(sender As Object, e As EventArgs)
			Me.tbVolumeVrtn.Text = StringType.FromInteger(Me.trkbarVolumeVrtn.Value)
		End Sub

		' Token: 0x06001638 RID: 5688 RVA: 0x002C5B08 File Offset: 0x002C4B08
		Private Sub trkbarPitchVrtn_ValueChanged(sender As Object, e As EventArgs)
			Me.tbPitchVrtn.Text = StringType.FromDouble(CDbl(Me.trkbarPitchVrtn.Value) / 100.0)
		End Sub

		' Token: 0x06001639 RID: 5689 RVA: 0x002C5B30 File Offset: 0x002C4B30
		Private Sub trkbarVolume_ValueChanged(sender As Object, e As EventArgs)
			Me.tbVolume.Text = StringType.FromInteger(Me.trkbarVolume.Value)
		End Sub

		' Token: 0x0600163A RID: 5690 RVA: 0x002C5B50 File Offset: 0x002C4B50
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			If Me.IsSoundPlaying() Then
				Dim num As UInteger
				Me.result = Me.channel.getPosition(num, TIMEUNIT.MS)
                Dim sound As Sound = Nothing
				Me.channel.getCurrentSound(sound)
				Dim num2 As UInteger
				If sound IsNot Nothing Then
					Me.result = sound.getLength(num2, TIMEUNIT.MS)
					If Me.result <> RESULT.OK AndAlso Me.result <> RESULT.ERR_INVALID_HANDLE AndAlso Me.result <> RESULT.ERR_CHANNEL_STOLEN Then
						Me.ERRCHECK(Me.result)
					End If
				End If
				Dim num3 As Integer = Convert.ToInt32(num2)
				Dim num4 As Integer = Convert.ToInt32(num)
				Me.tbSoundStatus.Text = String.Concat(New String() { (CLng(Math.Round(CDbl(num4) / 1000.0)) / 60L).ToString().PadLeft(2, "0"c), ":", Conversion.Int(CDbl(num4) / 1000.0 Mod 60.0).ToString().PadLeft(2, "0"c), ":", Conversion.Int(CDbl(num4) / 10.0 Mod 100.0).ToString().PadLeft(2, "0"c), "/", (CLng(Math.Round(CDbl(num3) / 1000.0)) / 60L).ToString().PadLeft(2, "0"c), ":", Conversion.Int(CDbl(num3) / 1000.0 Mod 60.0).ToString().PadLeft(2, "0"c), ":", Conversion.Int(CDbl(num3) / 10.0 Mod 100.0).ToString().PadLeft(2, "0"c) })
			Else
				Me.btnStopSound.Enabled = False
				If Me.IsItemSelected Then
					Me.btnPlaySound.Enabled = True
				End If
				Me.Timer1.Enabled = False
				If Me.sound1 IsNot Nothing Then
					Me.sound1.release()
				End If
				If Me.StoppedPlayingEvent IsNot Nothing Then
					Me.StoppedPlayingEvent()
				End If
			End If
		End Sub

		' Token: 0x0600163B RID: 5691 RVA: 0x002C5D98 File Offset: 0x002C4D98
		Private Sub ClosedownSound()
			If Me.channel IsNot Nothing Then
				Me.channel.[stop]()
			End If
			If Me.sound1 IsNot Nothing Then
				Me.sound1.release()
			End If
			If Me.fmSystem IsNot Nothing Then
				Me.result = Me.fmSystem.close()
				Me.result = Me.fmSystem.release()
			End If
		End Sub

		' Token: 0x0600163C RID: 5692 RVA: 0x002C5DF8 File Offset: 0x002C4DF8
		Private Sub UpdateUI()
			If Me.lbSounds.Items.Count > 1 Then
				Me.rbLooping.Enabled = False
				If Me.rbLooping.Checked Then
					Me.rbOnce.Checked = True
				End If
			Else
				Me.rbLooping.Enabled = True
				Me.rbSequential.Enabled = True
				Me.rbSequential.Checked = True
				Me.rbRandom.Enabled = False
			End If
		End Sub

		' Token: 0x0600163D RID: 5693 RVA: 0x002C5E70 File Offset: 0x002C4E70
		Public Sub SetFormName(Name As String)
			Me.Text = "Sound Editor - " + Name
		End Sub

		' Token: 0x0600163E RID: 5694 RVA: 0x002C5E84 File Offset: 0x002C4E84
		Public Function PlaySound(filename As String) As Boolean
            Dim biffvarRsrcEntryInfo As BIFFVarRsrcEntryInfo = Nothing
			Dim flag As Boolean
			If Me.htBIFSounds.ContainsKey(filename) Then
				biffvarRsrcEntryInfo = Me.SoundsResInfo(IntegerType.FromObject(Me.htBIFSounds(filename)))
				filename = Me.SoundsBifPath
				flag = True
			ElseIf File.Exists(Me.g_ProjectPath + "\extras\" + filename) Then
				filename = Me.g_ProjectPath + "\extras\" + filename
			ElseIf Me.CurrentSettings.bUseOverrideFiles AndAlso File.Exists(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\Override\" + filename) Then
				filename = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\Override\" + filename
			ElseIf File.Exists(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamSounds\" + filename) Then
				filename = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamSounds\" + filename
			ElseIf File.Exists(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamVoice\" + filename) Then
				filename = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamVoice\" + filename
			Else
				If Not File.Exists(frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamMusic\" + filename) Then
					Return False
				End If
				filename = frmMain.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\StreamMusic\" + filename
			End If
			Dim createsoundexinfo As CREATESOUNDEXINFO = Nothing
			createsoundexinfo.cbsize = 72
			If Not flag Then
				Dim kotorSoundInfo As KTSoundInfo = frmMain.GetKotorSoundInfo(filename)
				createsoundexinfo.length = Convert.ToUInt32(kotorSoundInfo.DataSize)
				createsoundexinfo.fileoffset = Convert.ToUInt32(kotorSoundInfo.DataOffset)
			Else
				createsoundexinfo.length = Convert.ToUInt32(biffvarRsrcEntryInfo.FileSize)
				createsoundexinfo.fileoffset = Convert.ToUInt32(biffvarRsrcEntryInfo.Offset)
			End If
			Me.result = Me.fmSystem.createSound(filename, CType(32936, MODE), createsoundexinfo, Me.sound1)
			Me.result = Me.fmSystem.playSound(CHANNELINDEX.FREE, Me.sound1, False, Me.channel)
			Me.Timer1.Enabled = True
			Return True
		End Function

		' Token: 0x0600163F RID: 5695 RVA: 0x002C60C4 File Offset: 0x002C50C4
		Public Sub StopSound()
			Me.channel.[stop]()
			Me.Timer1.Enabled = False
			Me.btnStopSound.Enabled = False
			Me.btnPlaySound.Enabled = True
			If Me.sound1 IsNot Nothing Then
				Me.sound1.release()
			End If
		End Sub

		' Token: 0x06001640 RID: 5696 RVA: 0x002C6118 File Offset: 0x002C5118
		Public Function IsSoundPlaying() As Boolean
			Dim flag As Boolean = False
			If Me.channel IsNot Nothing Then
				Me.result = Me.channel.isPlaying(flag)
			End If
			Return flag
		End Function

		' Token: 0x06001641 RID: 5697 RVA: 0x002C6144 File Offset: 0x002C5144
		Private Sub ERRCHECK(result As RESULT)
			If result <> RESULT.OK Then
			End If
		End Sub

		' Token: 0x04000AC1 RID: 2753
		Public UTS As clsUTS

		' Token: 0x04000AC2 RID: 2754
		Private NameLang As Integer

		' Token: 0x04000AC3 RID: 2755
		Private m_bSaveGameMode As Boolean

		' Token: 0x04000AC4 RID: 2756
		Public g_ProjectPath As String

		' Token: 0x04000AC5 RID: 2757
		Private fmSystem As Global.FMOD.System

		' Token: 0x04000AC6 RID: 2758
		Private result As RESULT

		' Token: 0x04000AC7 RID: 2759
		Private FMODversion As UInteger

		' Token: 0x04000AC8 RID: 2760
		Private sound1 As Sound

		' Token: 0x04000AC9 RID: 2761
		Private channel As Channel

		' Token: 0x04000ACA RID: 2762
		Private SoundsBifPath As String

		' Token: 0x04000ACB RID: 2763
		Private IsItemSelected As Boolean

		' Token: 0x04000ACC RID: 2764
		Private htBIFSounds As Hashtable

		' Token: 0x04000ACD RID: 2765
		Private htStreamSounds As Hashtable

		' Token: 0x04000ACE RID: 2766
		Private SoundsResInfo As BIFFVarRsrcEntryInfo()

		' Token: 0x02000083 RID: 131
		' (Invoke) Token: 0x06001645 RID: 5701
		Public Delegate Sub StoppedPlayingEventHandler()
	End Class
End Namespace
