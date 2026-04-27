Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200007C RID: 124
	Public Partial Class frmUTC_Editor
		Inherits frmParent

		' Token: 0x06001109 RID: 4361 RVA: 0x0029F1C0 File Offset: 0x0029E1C0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTC_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTC_Editor_Closing
			Me.ComboBoxSettingError = False
			Me.m_bSaveGameMode = False
			Me.g_ForcePowerList = New ArrayList()
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06001286 RID: 4742 RVA: 0x002A8C44 File Offset: 0x002A7C44
        Public Sub New(ByVal UTCClass As clsUTC, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Creature Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTC = UTCClass
            Me.KotorVersionIndex = KotorVerIndex
            Dim num As Integer = IntegerType.FromObject(Me.UTC.GetNodeValue("Color_Skin"))
            Me.Setup()
        End Sub

        ' Token: 0x170006D5 RID: 1749
        ' (get) Token: 0x06001287 RID: 4743 RVA: 0x002A8D0C File Offset: 0x002A7D0C
        ' (set) Token: 0x06001288 RID: 4744 RVA: 0x002A8D20 File Offset: 0x002A7D20
        Public Property IsSaveGameMode() As Boolean
            Get
                Return Me.m_bSaveGameMode
            End Get
            Set(ByVal value As Boolean)
                Me.m_bSaveGameMode = value
            End Set
        End Property

        ' Token: 0x06001289 RID: 4745 RVA: 0x002A8D2C File Offset: 0x002A7D2C
        Public Sub Setup()
            Dim clsChitinKey As clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me.BuildComboBoxes(clsChitinKey)
            Me.UTC.SetTextBoxFromCExoLocStringNodeValue(Me.tbFirstName, "FirstName")
            Me.UTC.SetTextBoxFromCExoLocStringNodeValue(Me.tbLastName, "LastName")
            Me.UTC.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTC.SetTextBoxToNodeValue(Me.tbConversation, "Conversation")
            Me.chkbNotInterruptable.Checked = BooleanType.FromObject(ObjectType.NotObj(ObjectType.ObjTst(Me.UTC.GetNodeValue("Interruptable"), 1, False) = 0))
            Me.UTC.SetTextBoxFromCExoLocStringNodeValue(Me.tbDescription, "Description")
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudStrength, "Str", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudIntelligence, "Int", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudWisdom, "Wis", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudDexterity, "Dex", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudConstitution, "Con", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudCharisma, "Cha", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudFortBonus, "fortbonus", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudRefBonus, "refbonus", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudWillBonus, "willbonus", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudNaturalAC, "NaturalAC", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudBaseHP, "HitPoints", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudMaxHP, "MaxHitPoints", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudCurrentHP, "CurrentHitPoints", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudAlignment, "GoodEvil", 0.0F)
            Me.trkbarAlignment.Value = IntegerType.FromObject(Me.UTC.GetNodeValue("GoodEvil"))
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudClassLevel, "ClassList(0).ClassLevel", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudComputerUse, "SkillList(0).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudDemolitions, "SkillList(1).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudStealth, "SkillList(2).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudAwareness, "SkillList(3).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudPersuade, "SkillList(4).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudRepair, "SkillList(5).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudSecurity, "SkillList(6).Rank", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudTreatInjury, "SkillList(7).Rank", 0.0F)
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnAttacked, "ScriptAttacked")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnBlocked, "ScriptOnBlocked")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnDamaged, "ScriptDamaged")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnDeath, "ScriptDeath")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnDialogue, "ScriptDialogue")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnDisturbed, "ScriptDisturbed")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnEndDialogu, "ScriptEndDialogu")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnEndRound, "ScriptEndRound")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnHeartbeat, "ScriptHeartbeat")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnNotice, "ScriptOnNotice")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnRested, "ScriptRested")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnSpawn, "ScriptSpawn")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnSpellAt, "ScriptSpellAt")
            Me.UTC.SetTextBoxToNodeValue(Me.tbOnUserDefine, "ScriptUserDefine")
            Me.FillChkListBoxFrom2DA(Me.chklbFeats, "name", "feat", clsChitinKey, Me.g_clsDialogTlk)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.UTC.GetListItemCount("FeatList") - 1
            For i As Integer = num To num2
                Me.chklbFeats.SetItemChecked(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTC.GetNodeValue("FeatList(" + StringType.FromInteger(i) + ").Feat"))), True)
            Next
            Me.FillSpecialAbilitiesChkListBoxFrom2DA(Me.chklbSpecialAbilities, clsChitinKey, Me.g_clsDialogTlk)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudForcePoints, "ForcePoints", 0.0F)
            Me.UTC.SetNumericUpDownToNodeValue(Me.nudCurrentForce, "CurrentForce", 0.0F)
            Me.FillSpellsChkListBoxFrom2DA(Me.chklbForcePowers, clsChitinKey, Me.g_clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA("spells", clsChitinKey)
            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.UTC.GetListItemCount("ClassList(0).KnownList0") - 1
            For i As Integer = num3 To num4
                Dim num5 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTC.GetNodeValue("ClassList(0).KnownList0(" + StringType.FromInteger(i) + ").Spell")))
                Dim indiceData As Object = cls2DA.GetIndiceData(num5, "usertype")
                If BooleanType.FromObject(If((Not BooleanType.FromObject(Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData))) OrElse Not BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(indiceData, 1, False) = 0, ObjectType.ObjTst(indiceData, -2, False) = 0), ObjectType.ObjTst(indiceData, 6, False) = 0))), False, True)) Then
                    Me.chklbForcePowers.SetItemChecked(Me.g_ForcePowerList.IndexOf(num5), True)
                End If
            Next
            Me.UTC.SetTextBoxToNodeValue(Me.tbChallengeRating, "ChallengeRating")
            Me.chkbDisarmable.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("Disarmable"))
            Me.chkbPlot.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("Plot"))
            Me.chkbNoPermDeath.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("NoPermDeath"))
            Me.chkbMin1HP.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("Min1HP"))
            Me.chkbIsPC.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("IsPC"))
            Me.UTC.SetTextBoxToNodeValue(Me.tbDeity, "Deity")
            If Me.UTC.VerifyNodeExists("TemplateResRef") Then
                Me.UTC.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
                Me.SyncPerceptionRangeComboBox()
            End If
            If Me.KotorVersionIndex = 1 Then
                Me.lblBlindSpot.Visible = True
                Me.lblMultiplierSet.Visible = True
                Me.nudBlindSpot.Visible = True
                Me.nudMultiplierSet.Visible = True
                Me.chkbIsHologram.Visible = True
                Me.chkbNotReorienting.Visible = True
                Me.chkbIgnoreCrePath.Visible = True
                Me.UTC.SetNumericUpDownToNodeValue(Me.nudBlindSpot, "BlindSpot", 0.0F)
                Me.UTC.SetNumericUpDownToNodeValue(Me.nudMultiplierSet, "MultiplierSet", 0.0F)
                Me.chkbIgnoreCrePath.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("IgnoreCrePath"))
                Me.chkbIsHologram.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("Hologram"))
                Me.chkbNotReorienting.Checked = BooleanType.FromObject(Me.UTC.GetNodeValue("NotReorienting"))
            End If
            Me.UTC.SetTextBoxToNodeValue(Me.tbComments, "Comment")
            If Me.ComboBoxSettingError Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
        End Sub

        ' Token: 0x0600128A RID: 4746 RVA: 0x002A95BC File Offset: 0x002A85BC
        Private Function BuildComboBoxes(ByVal clsChitin As clsChitinKey) As Object
            Me.FillComboBoxFrom2DA(Me.cmbxAppearance, "label", "appearance", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxAppearance, "Appearance_Type") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxFaction, "label", "repute", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxFaction, "FactionID") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxBodyBag, "label", "bodybag", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxBodyBag, "BodyBag") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxGender, "name", "gender", clsChitin, Me.g_clsDialogTlk)
            If Not Me.UTC.SyncComboBox(Me.cmbxGender, "Gender") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxRace, "name", "racialtypes", clsChitin, Me.g_clsDialogTlk)
            If Not Me.UTC.SyncComboBox(Me.cmbxRace, "Race") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxPhenotype, "label", "phenotype", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxPhenotype, "Phenotype") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxMovementRate, "label", "creaturespeed", clsChitin, Nothing)
            If Me.UTC.VerifyNodeExists("WalkRate") AndAlso Not Me.UTC.SyncComboBox(Me.cmbxMovementRate, "WalkRate") Then
                Me.ComboBoxSettingError = True
            End If
            If Me.UTC.VerifyNodeExists("MovementRate") AndAlso Not Me.UTC.SyncComboBox(Me.cmbxMovementRate, "MovementRate") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxClass, "name", "classes", clsChitin, Me.g_clsDialogTlk)
            If Not Me.UTC.SyncComboBox(Me.cmbxClass, "ClassList(0).Class") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxSubrace, "label", "subrace", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxSubrace, "SubraceIndex") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxSoundSet, "label", "soundset", clsChitin, Me.g_clsDialogTlk)
            If Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTC.GetNodeValue("SoundSetFile"))) = 65535 Then
                Me.cmbxSoundSet.SelectedIndex = 0
            ElseIf Not Me.UTC.SyncComboBox(Me.cmbxSoundSet, "SoundSetFile") Then
                Me.ComboBoxSettingError = True
            End If
            Me.FillComboBoxFrom2DA(Me.cmbxPortrait, "baseresref", "portraits", clsChitin, Nothing)
            If Not Me.UTC.SyncComboBox(Me.cmbxPortrait, "PortraitId") Then
                Me.ComboBoxSettingError = True
            End If
            Dim obj As Object
            Return obj
        End Function

        ' Token: 0x0600128B RID: 4747 RVA: 0x002A98B0 File Offset: 0x002A88B0
        Private Sub FillComboBoxFrom2DA(ByVal cmbx As ComboBox, ByVal colName As String, ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA(TwoDAName, ChitinKey)
            If DialogTlk IsNot Nothing Then
                Dim num As Integer = 0
                Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
                For i As Integer = num To rowsUpperBound
                    Dim indiceData As Object = cls2DA.GetIndiceData(i, colName)
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
                        cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
                    Else
                        cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
                    End If
                Next
            Else
                Dim num2 As Integer = 0
                Dim rowsUpperBound2 As Integer = cls2DA.RowsUpperBound
                For i As Integer = num2 To rowsUpperBound2
                    cmbx.Items.Add(cls2DA.GetIndiceData(i, colName))
                Next
            End If
        End Sub

        ' Token: 0x0600128C RID: 4748 RVA: 0x002A9950 File Offset: 0x002A8950
        Private Sub SyncPerceptionRangeComboBox()
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.UTC.GetNodeValue("PerceptionRange"))
            If objectValue IsNot Nothing Then
                ' The following expression was wrapped in a checked-expression
                Me.cmbxPerceptionRange.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)) - 9
            End If
        End Sub

        ' Token: 0x0600128D RID: 4749 RVA: 0x002A9990 File Offset: 0x002A8990
        Private Sub FillChkListBoxFrom2DA(ByVal lbx As CheckedListBox, ByVal colName As String, ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA(TwoDAName, ChitinKey)
            If DialogTlk IsNot Nothing Then
                Dim num As Integer = 0
                Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
                For i As Integer = num To rowsUpperBound
                    Dim indiceData As Object = cls2DA.GetIndiceData(i, colName)
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
                        lbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
                    Else
                        lbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
                    End If
                Next
            Else
                Dim num2 As Integer = 0
                Dim rowsUpperBound2 As Integer = cls2DA.RowsUpperBound
                For i As Integer = num2 To rowsUpperBound2
                    lbx.Items.Add(cls2DA.GetIndiceData(i, colName))
                Next
            End If
        End Sub

        ' Token: 0x0600128E RID: 4750 RVA: 0x002A9A30 File Offset: 0x002A8A30
        Private Sub FillSpellsChkListBoxFrom2DA(ByVal lbx As CheckedListBox, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim cls2DA As cls2DA = Me.ReadCls2DA("spells", ChitinKey)
            Dim num As Integer = 0
            Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
            For i As Integer = num To rowsUpperBound
                Dim obj As Object = cls2DA.GetIndiceData(i, "usertype")
                If BooleanType.FromObject(If((Not BooleanType.FromObject(Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj))) OrElse Not BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(obj, 1, False) = 0, ObjectType.ObjTst(obj, -2, False) = 0), ObjectType.ObjTst(obj, 6, False) = 0))), False, True)) Then
                    obj = cls2DA.GetIndiceData(i, "name")
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
                        lbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(obj)))
                        Me.g_ForcePowerList.Add(i)
                    End If
                End If
            Next
        End Sub

        ' Token: 0x0600128F RID: 4751 RVA: 0x002A9B38 File Offset: 0x002A8B38
        Private Sub FillSpecialAbilitiesChkListBoxFrom2DA(ByVal lbx As CheckedListBox, ByVal ChitinKey As clsChitinKey, ByVal DialogTlk As clsDialogTlk)
            Dim arrayList As ArrayList = New ArrayList()
            Dim cls2DA As cls2DA = Me.ReadCls2DA("spells", ChitinKey)
            Dim num As Integer = 0
            Dim rowsUpperBound As Integer = cls2DA.RowsUpperBound
            For i As Integer = num To rowsUpperBound
                Dim obj As Object = cls2DA.GetIndiceData(i, "usertype")
                If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) AndAlso ObjectType.ObjTst(obj, 2, False) = 0 Then
                    obj = cls2DA.GetIndiceData(i, "name")
                    Dim text As String
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
                        text = DialogTlk.GetString(IntegerType.FromObject(obj))
                    Else
                        text = StringType.FromObject(obj)
                    End If
                    If StringType.StrCmp(text, "****", False) <> 0 Then
                        arrayList.Add(New ComboBoxListItem(i, text, ""))
                    End If
                End If
            Next
            lbx.DataSource = arrayList
            lbx.DisplayMember = "Text"
            lbx.ValueMember = "TwoDAIndex"
        End Sub

        ' Token: 0x06001290 RID: 4752 RVA: 0x002A9C18 File Offset: 0x002A8C18
        Private Sub trkbarAlignment_Scroll(ByVal sender As Object, ByVal e As EventArgs)
            Me.nudAlignment.Value = New Decimal(CType(sender, TrackBar).Value)
        End Sub

        ' Token: 0x06001291 RID: 4753 RVA: 0x002A9C38 File Offset: 0x002A8C38
        Private Sub nudAlignment_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.trkbarAlignment.Value = Convert.ToInt32(CType(sender, NumericUpDown).Value)
        End Sub

        ' Token: 0x06001292 RID: 4754 RVA: 0x002A9C58 File Offset: 0x002A8C58
        Private Sub chklbForcePowers_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.tbForcePowerSummary.Clear()
            Try
                For Each obj As Object In Me.chklbForcePowers.CheckedItems
                    Dim text As String = StringType.FromObject(obj)
                    Dim tbForcePowerSummary As TextBox = Me.tbForcePowerSummary
                    tbForcePowerSummary.Text = tbForcePowerSummary.Text + text + vbCrLf
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06001293 RID: 4755 RVA: 0x002A9CDC File Offset: 0x002A8CDC
        Private Sub chklbFeats_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.tbFeatSummary.Clear()
            Try
                For Each obj As Object In Me.chklbFeats.CheckedItems
                    Dim text As String = StringType.FromObject(obj)
                    Dim tbFeatSummary As TextBox = Me.tbFeatSummary
                    tbFeatSummary.Text = tbFeatSummary.Text + text + vbCrLf
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x170006D6 RID: 1750
        ' (set) Token: 0x06001294 RID: 4756 RVA: 0x002A9D60 File Offset: 0x002A8D60
        Public WriteOnly Property UTCFileData() As Object
            Set(ByVal value As Object)
                Me.UTC = CType(value, clsUTC)
            End Set
        End Property

        ' Token: 0x06001295 RID: 4757 RVA: 0x002A9D70 File Offset: 0x002A8D70
        Private Sub SetGFFNodeValues()
            Me.UTC.SetCExoLocStringNodeValueFromTextBox(Me.tbFirstName, "FirstName", 0)
            Me.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.SetNodeValueFromTextBox(Me.tbConversation, "Conversation")
            Dim b As Byte
            If Me.chkbNotInterruptable.Checked Then
                b = 0
            Else
                b = 1
            End If
            Me.UTC.SetNodeValue("Interruptable", b)
            Me.UTC.SetCExoLocStringNodeValueFromTextBox(Me.tbDescription, "Description", 0)
            Me.SetNodeValueFromComboBox(Me.cmbxRace, "Race")
            Me.SetNodeValueFromComboBox(Me.cmbxAppearance, "Appearance_Type")
            Me.SetNodeValueFromComboBox(Me.cmbxGender, "Gender")
            Me.SetNodeValueFromComboBox(Me.cmbxPhenotype, "Phenotype")
            Me.SetNodeValueFromComboBox(Me.cmbxBodyBag, "BodyBag")
            Me.SetNodeValueFromNumericUpDown(Me.nudStrength, "Str")
            Me.SetNodeValueFromNumericUpDown(Me.nudIntelligence, "Int")
            Me.SetNodeValueFromNumericUpDown(Me.nudWisdom, "Wis")
            Me.SetNodeValueFromNumericUpDown(Me.nudDexterity, "Dex")
            Me.SetNodeValueFromNumericUpDown(Me.nudConstitution, "Con")
            Me.SetNodeValueFromNumericUpDown(Me.nudCharisma, "Cha")
            Me.SetNodeValueFromNumericUpDown(Me.nudFortBonus, "fortbonus")
            Me.SetNodeValueFromNumericUpDown(Me.nudRefBonus, "refbonus")
            Me.SetNodeValueFromNumericUpDown(Me.nudWillBonus, "willbonus")
            Me.SetNodeValueFromNumericUpDown(Me.nudNaturalAC, "NaturalAC")
            Me.SetNodeValueFromNumericUpDown(Me.nudBaseHP, "HitPoints")
            Me.SetNodeValueFromNumericUpDown(Me.nudMaxHP, "MaxHitPoints")
            Me.SetNodeValueFromNumericUpDown(Me.nudCurrentHP, "CurrentHitPoints")
            If Me.UTC.VerifyNodeExists("WalkRate") Then
                Me.SetNodeValueFromComboBox(Me.cmbxMovementRate, "WalkRate")
            End If
            If Me.UTC.VerifyNodeExists("MovementRate") Then
                Me.SetNodeValueFromComboBox(Me.cmbxMovementRate, "MovementRate")
            End If
            Me.SetNodeValueFromNumericUpDown(Me.nudAlignment, "GoodEvil")
            Me.SetNodeValueFromNumericUpDown(Me.nudClassLevel, "ClassList(0).ClassLevel")
            Me.SetNodeValueFromComboBox(Me.cmbxClass, "ClassList(0).Class")
            Me.SetNodeValueFromNumericUpDown(Me.nudComputerUse, "SkillList(0).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudDemolitions, "SkillList(1).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudStealth, "SkillList(2).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudAwareness, "SkillList(3).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudPersuade, "SkillList(4).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudRepair, "SkillList(5).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudSecurity, "SkillList(6).Rank")
            Me.SetNodeValueFromNumericUpDown(Me.nudTreatInjury, "SkillList(7).Rank")
            Me.SetNodeValueFromTextBox(Me.tbOnAttacked, "ScriptAttacked")
            Me.SetNodeValueFromTextBox(Me.tbOnBlocked, "ScriptOnBlocked")
            Me.SetNodeValueFromTextBox(Me.tbOnDamaged, "ScriptDamaged")
            Me.SetNodeValueFromTextBox(Me.tbOnDeath, "ScriptDeath")
            Me.SetNodeValueFromTextBox(Me.tbOnDialogue, "ScriptDialogue")
            Me.SetNodeValueFromTextBox(Me.tbOnDisturbed, "ScriptDisturbed")
            Me.SetNodeValueFromTextBox(Me.tbOnEndDialogu, "ScriptEndDialogu")
            Me.SetNodeValueFromTextBox(Me.tbOnEndRound, "ScriptEndRound")
            Me.SetNodeValueFromTextBox(Me.tbOnHeartbeat, "ScriptHeartbeat")
            Me.SetNodeValueFromTextBox(Me.tbOnNotice, "ScriptOnNotice")
            Me.SetNodeValueFromTextBox(Me.tbOnRested, "ScriptRested")
            Me.SetNodeValueFromTextBox(Me.tbOnSpawn, "ScriptSpawn")
            Me.SetNodeValueFromTextBox(Me.tbOnSpellAt, "ScriptSpellAt")
            Me.SetNodeValueFromTextBox(Me.tbOnUserDefine, "ScriptUserDefine")
            Me.UTC.ClearListElements("FeatList")
            Try
                For Each obj As Object In Me.chklbFeats.CheckedIndices
                    Dim num As Integer = IntegerType.FromObject(obj)
                    Dim gff_Struct As GFF_Struct = New GFF_Struct()
                    gff_Struct.type = 1
                    gff_Struct.fieldCount = 1
                    gff_Struct.fields = New GFF_Field(0) {}
                    gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_word, "Feat", num)
                    Me.UTC.AddListElement("FeatList", gff_Struct)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.SetNodeValueFromNumericUpDown(Me.nudForcePoints, "ForcePoints")
            Me.SetNodeValueFromNumericUpDown(Me.nudCurrentForce, "CurrentForce")
            Me.UTC.ClearListElements("ClassList(0).KnownList0")
            Try
                For Each obj2 As Object In Me.chklbForcePowers.CheckedIndices
                    Dim num As Integer = IntegerType.FromObject(obj2)
                    Dim gff_Struct As GFF_Struct = New GFF_Struct()
                    gff_Struct.type = 3
                    gff_Struct.fieldCount = 3
                    gff_Struct.fields = New GFF_Field(2) {}
                    Dim num2 As Integer = IntegerType.FromObject(Me.g_ForcePowerList(num))
                    gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_word, "Spell", num2)
                    gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_byte, "SpellMetaMagic", 0)
                    gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "SpellFlags", 1)
                    Me.UTC.AddListElement("ClassList(0).KnownList0", gff_Struct)
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            If Me.UTC.VerifyNodeExists("TemplateResRef") Then
                Me.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            End If
            Me.SetNodeValueFromComboBox(Me.cmbxSubrace, "Subrace")
            If Me.cmbxSoundSet.SelectedIndex = 0 Then
                Me.UTC.SetNodeValue("SoundSetFile", 65535)
            Else
                Me.SetNodeValueFromComboBox(Me.cmbxSoundSet, "SoundSetFile")
            End If
            Me.SetNodeValueFromTextBox(Me.tbDeity, "Deity")
            Me.SetNodeValueFromComboBox(Me.cmbxFaction, "FactionID")
            Me.UTC.SetNodeValue("Disarmable", Me.chkbDisarmable.Checked)
            Me.UTC.SetNodeValue("Plot", Me.chkbPlot.Checked)
            Me.UTC.SetNodeValue("Min1HP", Me.chkbMin1HP.Checked)
            Me.UTC.SetNodeValue("IsPC", Me.chkbIsPC.Checked)
            If Me.UTC.VerifyNodeExists("NoPermDeath") Then
                Me.UTC.SetNodeValue("NoPermDeath", Me.chkbNoPermDeath.Checked)
            End If
            Me.UTC.SetNodeValue("ChallengeRating", SingleType.FromString(Me.tbChallengeRating.Text))
            If Me.UTC.VerifyNodeExists("PerceptionRange") Then
                Me.SetPerceptionRangeNodeValueFromComboBox()
            End If
            If Me.KotorVersionIndex = 1 Then
                If Not Me.UTC.VerifyNodeExists("BlindSpot") Then
                    Me.UTC.AddSimpleField("BlindSpot", GFFField.GFF_float, Me.nudBlindSpot.Value)
                Else
                    Me.UTC.SetNodeValueFromNumericUpDown(Me.nudBlindSpot, "BlindSpot", 0.0F)
                End If
                If Not Me.UTC.VerifyNodeExists("MultiplierSet") Then
                    Me.UTC.AddSimpleField("MultiplierSet", GFFField.GFF_byte, Me.nudMultiplierSet.Value)
                Else
                    Me.UTC.SetNodeValueFromNumericUpDown(Me.nudMultiplierSet, "MultiplierSet", 0.0F)
                End If
                If Not Me.UTC.VerifyNodeExists("IgnoreCrePath") Then
                    Me.UTC.AddSimpleField("IgnoreCrePath", GFFField.GFF_byte, Me.chkbIgnoreCrePath.Checked)
                Else
                    Me.UTC.SetNodeValue("IgnoreCrePath", Me.chkbIgnoreCrePath.Checked)
                End If
                If Not Me.UTC.VerifyNodeExists("Hologram") Then
                    Me.UTC.AddSimpleField("Hologram", GFFField.GFF_byte, Me.chkbIsHologram.Checked)
                Else
                    Me.UTC.SetNodeValue("Hologram", Me.chkbIsHologram.Checked)
                End If
                If Not Me.UTC.VerifyNodeExists("NotReorienting") Then
                    Me.UTC.AddSimpleField("NotReorienting", GFFField.GFF_byte, Me.chkbNotReorienting.Checked)
                Else
                    Me.UTC.SetNodeValue("NotReorienting", Me.chkbNotReorienting.Checked)
                End If
            End If
            If Me.UTC.VerifyNodeExists("Comment") Then
                Me.SetNodeValueFromTextBox(Me.tbComments, "Comment")
            End If
        End Sub

        ' Token: 0x06001296 RID: 4758 RVA: 0x002AA628 File Offset: 0x002A9628
        Private Sub SetNodeValueFromNumericUpDown(ByVal NUD As NumericUpDown, ByVal NodePath As String)
            Me.UTC.SetNodeValue(NodePath, NUD.Value)
        End Sub

        ' Token: 0x06001297 RID: 4759 RVA: 0x002AA644 File Offset: 0x002A9644
        Private Sub SetNodeValueFromTextBox(ByVal TB As TextBox, ByVal NodePath As String)
            Me.UTC.SetNodeValue(NodePath, TB.Text)
        End Sub

        ' Token: 0x06001298 RID: 4760 RVA: 0x002AA658 File Offset: 0x002A9658
        Private Sub SetNodeValueFromComboBox(ByVal cmbx As ComboBox, ByVal NodePath As String)
            Me.UTC.SetNodeValue(NodePath, cmbx.SelectedIndex)
        End Sub

        ' Token: 0x06001299 RID: 4761 RVA: 0x002AA674 File Offset: 0x002A9674
        Private Sub SetPerceptionRangeNodeValueFromComboBox()
            ' The following expression was wrapped in a checked-expression
            Me.UTC.SetNodeValue("PerceptionRange", Me.cmbxPerceptionRange.SelectedIndex + 9)
        End Sub

        ' Token: 0x0600129A RID: 4762 RVA: 0x002AA69C File Offset: 0x002A969C
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x0600129B RID: 4763 RVA: 0x002AA6A4 File Offset: 0x002A96A4
        Private Sub btnWriteFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".utc", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTC.WriteFile(Me.m_EditingFilePath, "UTC")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x0600129C RID: 4764 RVA: 0x002AA73C File Offset: 0x002A973C
        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim gff_Struct As GFF_Struct = New GFF_Struct()
            gff_Struct.type = 3
            gff_Struct.fieldCount = 3
            gff_Struct.fields = New GFF_Field(2) {}
            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_word, "Spell", 99)
            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_byte, "SpellMetaMagic", 1)
            gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "SpellFlags", 2)
            Me.UTC.AddListElement("ClassList(0).KnownList0", gff_Struct)
        End Sub

        ' Token: 0x0600129D RID: 4765 RVA: 0x002AA7C8 File Offset: 0x002A97C8
        Private Sub btnInventory_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmInventoryEditor As frmInventoryEditor = New frmInventoryEditor(Me.KotorVersionIndex)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.UTC.GetListItemCount("ItemList") - 1
            For i As Integer = num To num2
                Dim text As String = StringType.FromObject(Me.UTC.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").InventoryRes"))
                Dim flag As Boolean = Not Me.UTC.VerifyNodeExists("ItemList(" + StringType.FromInteger(i) + ").Dropable") OrElse ObjectType.ObjTst(Me.UTC.GetNodeValue("ItemList(" + StringType.FromInteger(i) + ").Dropable"), 1, False) = 0
                frmInventoryEditor.AddPackItem(text, flag)
            Next
            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.UTC.GetListItemCount("Equip_ItemList") - 1
            For i As Integer = num3 To num4
                Dim text As String = StringType.FromObject(Me.UTC.GetNodeValue("Equip_ItemList(" + StringType.FromInteger(i) + ").EquippedRes"))
                Dim structFieldType As Integer = Me.UTC.GetStructFieldType("Equip_ItemList(" + StringType.FromInteger(i) + ")")
                Dim flag As Boolean = Not Me.UTC.VerifyNodeExists("Equip_ItemList(" + StringType.FromInteger(i) + ").Dropable") OrElse ObjectType.ObjTst(Me.UTC.GetNodeValue("Equip_ItemList(" + StringType.FromInteger(i) + ").Dropable"), 1, False) = 0
                frmInventoryEditor.AddEquippedItem(text, structFieldType, flag)
            Next
            frmInventoryEditor.SetFormName(Me.tbTemplateResRef.Text + ".utc")
            If frmInventoryEditor.ShowDialog() = DialogResult.OK Then
                Dim i As Integer = 0
                Me.UTC.ClearListElements("ItemList")
                Try
                    For Each obj As Object In frmInventoryEditor.GetPackItemsList()
                        Dim inventoryItem As InventoryItem = CType(obj, InventoryItem)
                        Dim num5 As Integer = 1
                        Dim quantity As Integer = inventoryItem._Quantity
                        For j As Integer = num5 To quantity
                            Dim gff_Struct As GFF_Struct = New GFF_Struct()
                            gff_Struct.type = i
                            gff_Struct.fieldCount = 4
                            gff_Struct.fields = New GFF_Field(3) {}
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "InventoryRes", inventoryItem._ResRef)
                            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_word, "Repos_PosX", i)
                            gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_word, "Repos_PosY", 0)
                            Dim b As Byte
                            If inventoryItem._Dropable Then
                                b = 1
                            Else
                                b = 0
                            End If
                            gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_byte, "Dropable", b)
                            If Not Me.UTC.VerifyNodeExists("ItemList") Then
                                Me.UTC.CreateList("", "ItemList")
                            End If
                            Me.UTC.AddListElement("ItemList", gff_Struct)
                            i += 1
                        Next
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Me.UTC.ClearListElements("Equip_ItemList")
                Try
                    For Each obj2 As Object In frmInventoryEditor.GetEquippedItemsList()
                        Dim inventoryItem As InventoryItem = CType(obj2, InventoryItem)
                        If inventoryItem._ResRef IsNot Nothing Then
                            Dim gff_Struct As GFF_Struct = New GFF_Struct()
                            gff_Struct.type = IntegerType.FromString(inventoryItem._EquipableSlots)
                            gff_Struct.fieldCount = 2
                            gff_Struct.fields = New GFF_Field(1) {}
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CResRef, "EquippedRes", inventoryItem._ResRef)
                            Dim b As Byte
                            If inventoryItem._Dropable Then
                                b = 1
                            Else
                                b = 0
                            End If
                            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_byte, "Dropable", b)
                            If Not Me.UTC.VerifyNodeExists("Equip_ItemList") Then
                                Me.UTC.CreateList("", "Equip_ItemList")
                            End If
                            Me.UTC.AddListElement("Equip_ItemList", gff_Struct)
                        End If
                    Next
                Finally
                    Dim enumerator2 As IEnumerator
                    If TypeOf enumerator2 Is IDisposable Then
                        CType(enumerator2, IDisposable).Dispose()
                    End If
                End Try
            End If
        End Sub

        ' Token: 0x0600129E RID: 4766 RVA: 0x002AAC1C File Offset: 0x002A9C1C
        Private Sub btnSelectAllPowers_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.chklbForcePowers.Items.Count - 1
            For i As Integer = num To num2
                Me.chklbForcePowers.SetItemChecked(i, True)
            Next
        End Sub

        ' Token: 0x0600129F RID: 4767 RVA: 0x002AAC58 File Offset: 0x002A9C58
        Private Sub btnClearAllPowers_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.chklbForcePowers.Items.Count - 1
            For i As Integer = num To num2
                Me.chklbForcePowers.SetItemChecked(i, False)
            Next
        End Sub

        ' Token: 0x060012A0 RID: 4768 RVA: 0x002AAC94 File Offset: 0x002A9C94
        Private Sub frmUTC_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060012A1 RID: 4769 RVA: 0x002AACA8 File Offset: 0x002A9CA8
        Private Sub frmUTC_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.[GetType]().Name)
        End Sub

        ' Token: 0x060012A2 RID: 4770 RVA: 0x002AACBC File Offset: 0x002A9CBC
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Creature Editor - " + Name
        End Sub

        ' Token: 0x060012A3 RID: 4771 RVA: 0x002AACD0 File Offset: 0x002A9CD0
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbTag.Text
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTC.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x060012A4 RID: 4772 RVA: 0x002AAD3C File Offset: 0x002A9D3C
        Public Function ReadCls2DA(ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey) As cls2DA
            Dim flag As Boolean = True
            Dim array As Byte()
            If Me.CurrentSettings.bUseOverrideFiles Then
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\override\" + TwoDAName + ".2da"
                Try
                    If File.Exists(text) Then
                        Dim fileStream As FileStream = New FileStream(text, FileMode.Open)
                        array = New Byte(CInt(fileStream.Length) + 1 - 1) {}
                        fileStream.Read(array, 0, CInt(fileStream.Length))
                        fileStream.Close()
                        flag = False
                        Console.WriteLine("Read " + TwoDAName + ".2da from override")
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = ChitinKey.FindResIDForResRef(TwoDAName, 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + ChitinKey.BiffList(num >> 20).filename
                array = BIFFArchive.getBIFFResource(text, num).data
                Console.WriteLine("Read " + TwoDAName + ".2da from 2da.bif")
            End If
            Return New cls2DA(array)
        End Function

        ' Token: 0x060012A5 RID: 4773 RVA: 0x002AAE78 File Offset: 0x002A9E78
        Private Sub btnEditScript_Click(ByVal sender As Object, ByVal e As EventArgs)
            Utils.EditScriptForTextBox(CType(sender, Button), Me.m_EditingFilePath, Me.KotorVersionIndex)
        End Sub

        ' Token: 0x040008F1 RID: 2289
        Public UTC As clsUTC

        ' Token: 0x040008F2 RID: 2290
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x040008F3 RID: 2291
        Private ComboBoxSettingError As Boolean

        ' Token: 0x040008F4 RID: 2292
        Private m_bSaveGameMode As Boolean

        ' Token: 0x040008F5 RID: 2293
        Private g_ForcePowerList As ArrayList
    End Class
End Namespace
