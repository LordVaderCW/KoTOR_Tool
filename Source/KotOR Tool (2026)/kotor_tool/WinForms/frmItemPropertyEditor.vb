Imports System
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
	' Token: 0x02000053 RID: 83
	Public Partial Class frmItemPropertyEditor
		Inherits frmParent

		' Token: 0x0600061F RID: 1567 RVA: 0x0024A0EC File Offset: 0x002490EC
		Public Sub New(KotorVerIndex As Integer)
			AddHandler MyBase.Load, AddressOf Me.frm_Load
			AddHandler MyBase.Closing, AddressOf Me.frm_Closing
			Me.usetting = New UserSettings()
			Me.g_bCmbxPropertyHasParam1ResRef = False
			Me.debug = False
			Me.InitializeComponent()
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.KotorVersionIndex = KotorVerIndex
			Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
			Me.g_clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(KotorVerIndex))
			Me.Load2DAs()
			Me.FillComboBoxFrom2DA(Me.cmbxPropertyName, "name", Me.itempropdef, Me.g_clsDialogTlk)
			Me.FillComboBoxFrom2DA(Me.cmbxUpgrade, "label", Me.ReadCls2DA("upgrade", Me.g_clsChitinKey), Nothing)
			Me.cmbxUpgrade.Items.Insert(0, "(None - default)")
		End Sub

        ' Token: 0x0600066A RID: 1642 RVA: 0x0024BCF8 File Offset: 0x0024ACF8
        Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.Name)
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x0600066B RID: 1643 RVA: 0x0024BD18 File Offset: 0x0024AD18
        Private Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.Name)
        End Sub

        ' Token: 0x0600066C RID: 1644 RVA: 0x0024BD28 File Offset: 0x0024AD28
        Public Sub New(ByVal PropertyID As Integer, ByVal SubtypeID As Integer, ByVal CostTableID As Integer, ByVal CostTableValue As Integer, ByVal Param1ID As Integer, ByVal Param1Value As Integer, ByVal Param2ID As Integer, ByVal Param2Value As Integer, ByVal KotorVerIndex As Integer)
            Me.New(KotorVerIndex)
            Me.cmbxPropertyName.SelectedIndex = PropertyID
            If Me.cmbxSubtype.Items.Count > 0 Then
                Me.cmbxSubtype.SelectedIndex = SubtypeID
            End If
            Me.cmbxCostValue.SelectedIndex = CostTableValue
        End Sub

        ' Token: 0x0600066D RID: 1645 RVA: 0x0024BD78 File Offset: 0x0024AD78
        Private Sub FillComboBoxFrom2DA(ByVal cmbx As ComboBox, ByVal colName As String, ByVal TwoDA As cls2DA, Optional ByVal DialogTlk As clsDialogTlk = Nothing)
            cmbx.Items.Clear()
            If DialogTlk IsNot Nothing Then
                Dim num As Integer = 0
                Dim rowsUpperBound As Integer = TwoDA.RowsUpperBound
                For i As Integer = num To rowsUpperBound
                    Dim indiceData As Object = TwoDA.GetIndiceData(i, colName)
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) Then
                        cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)))
                    Else
                        cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData))
                    End If
                Next
            Else
                Dim num2 As Integer = 0
                Dim rowsUpperBound2 As Integer = TwoDA.RowsUpperBound
                For i As Integer = num2 To rowsUpperBound2
                    cmbx.Items.Add(TwoDA.GetIndiceData(i, colName))
                Next
            End If
        End Sub

        ' Token: 0x0600066E RID: 1646 RVA: 0x0024BE14 File Offset: 0x0024AE14
        Public Function ReadCls2DA(ByVal TwoDAName As String, ByVal ChitinKey As clsChitinKey) As cls2DA
            Dim flag As Boolean = True
            Dim array As Byte() = Nothing
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

        ' Token: 0x0600066F RID: 1647 RVA: 0x0024BF50 File Offset: 0x0024AF50
        Public Sub Load2DAs()
            Me.itempropdef = Me.ReadCls2DA("itempropdef", Me.g_clsChitinKey)
            Me.iprp_costtable = Me.ReadCls2DA("iprp_costtable", Me.g_clsChitinKey)
            Me.iprp_paramtable = Me.ReadCls2DA("iprp_paramtable", Me.g_clsChitinKey)
        End Sub

        ' Token: 0x06000670 RID: 1648 RVA: 0x0024BFA4 File Offset: 0x0024AFA4
        Private Sub cmbxPropertyName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxPropertyName.SelectedIndexChanged
            Dim indiceData As String = Me.itempropdef.GetIndiceData(Me.cmbxPropertyName.SelectedIndex, "subtyperesref")
            Dim indiceData2 As String = Me.itempropdef.GetIndiceData(Me.cmbxPropertyName.SelectedIndex, "costtableresref")
            Dim indiceData3 As String = Me.itempropdef.GetIndiceData(Me.cmbxPropertyName.SelectedIndex, "param1resref")
            Me.CostTableID = indiceData2
            If (StringType.StrCmp(indiceData2, "****", False) = 0) Or (StringType.StrCmp(indiceData2, "0", False) = 0) Then
                Me.CostTableName = "None"
            Else
                Me.CostTableName = Me.iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "label")
            End If
            Me.cmbxParam1Value.Enabled = False
            Me.cmbxParam1Value.Items.Clear()
            Me.cmbxParam2Value.Enabled = False
            Me.cmbxParam2Value.Items.Clear()
            Me.tbCostTableID.Text = indiceData2
            Me.tbCostTableName.Text = Me.CostTableName
            Me.tbSubtyperesref.Text = indiceData
            Me.lblValueDesc.Text = "(" + Strings.Replace(Me.CostTableName, "_", " ", 1, -1, CompareMethod.Binary) + ")"
            If StringType.StrCmp(indiceData, "****", False) = 0 Then
                Me.cmbxSubtype.Enabled = False
                Me.cmbxSubtype.Items.Clear()
                Me.lblSubtypeDesc.Text = "(None)"
                If StringType.StrCmp(indiceData2, "0", False) <> 0 Then
                    Dim text As String = Me.iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "name")
                    Me.FillComboBoxFrom2DA(Me.cmbxCostValue, "name", Me.ReadCls2DA(text, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                    Me.cmbxCostValue.Enabled = True
                    Me.tbStatus.Text = "cmbxCostValue specifies CostValue"
                Else
                    Me.cmbxCostValue.Enabled = False
                    Me.cmbxCostValue.Items.Clear()
                    Me.tbStatus.Text = "No cost value needed"
                    Me.CostValue = 0
                End If
            Else
                ' The following expression was wrapped in a checked-expression
                Dim text As String = Strings.Mid(indiceData, Strings.InStr(indiceData, "_", CompareMethod.Binary) + 1)
                Me.lblSubtypeDesc.Text = "(" + Strings.UCase(Strings.Mid(text, 1, 1)) + Strings.LCase(Strings.Mid(text, 2)) + ")"
                Dim cls2DA As cls2DA = Me.ReadCls2DA(indiceData, Me.g_clsChitinKey)
                If StringType.StrCmp(indiceData, "Appearance", False) = 0 Then
                    Me.FillComboBoxFrom2DA(Me.cmbxSubtype, "label", cls2DA, Nothing)
                Else
                    Me.FillComboBoxFrom2DA(Me.cmbxSubtype, "name", cls2DA, Me.g_clsDialogTlk)
                End If
                Me.cmbxSubtype.Enabled = True
                If StringType.StrCmp(indiceData2, "****", False) = 0 OrElse StringType.StrCmp(indiceData2, "0", False) = 0 Then
                    Me.cmbxCostValue.Enabled = False
                    Me.cmbxCostValue.Items.Clear()
                    Me.tbStatus.Text = "cmbxSubtype specifies CostValue"
                Else
                    text = Me.iprp_costtable.GetIndiceData(IntegerType.FromString(indiceData2), "name")
                    Me.FillComboBoxFrom2DA(Me.cmbxCostValue, "name", Me.ReadCls2DA(text, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                    Me.cmbxCostValue.Enabled = True
                    Me.tbStatus.Text = "cmbxCostValue specifies CostValue"
                End If
            End If
            If StringType.StrCmp(indiceData3, "****", False) = 0 Then
                Me.cmbxParam1Value.Enabled = False
                Me.cmbxParam1Value.Items.Clear()
                Me.g_bCmbxPropertyHasParam1ResRef = False
                Me.tbParam1tableresref.Text = "None"
                Me.lblParam1Desc.Text = "(None)"
            Else
                Me.cmbxParam1Value.Enabled = True
                Dim num As Integer = IntegerType.FromString(indiceData3)
                Dim text As String = Me.iprp_paramtable.GetIndiceData(num, "tableresref")
                Me.FillComboBoxFrom2DA(Me.cmbxParam1Value, "name", Me.ReadCls2DA(text, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                Me.g_bCmbxPropertyHasParam1ResRef = True
                Me.tbParam1tableresref.Text = text
                Me.Param1Desc = Me.iprp_paramtable.GetIndiceData(num, "label")
                Me.lblParam1Desc.Text = "(" + Me.Param1Desc + ")"
                Me.tbParam1resref.Text = indiceData3
            End If
            Me.cmbxUpgrade.Enabled = True
            Me.cmbxUpgrade.SelectedIndex = 0
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x06000671 RID: 1649 RVA: 0x0024C434 File Offset: 0x0024B434
        Private Sub cmbxSubtype_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxSubtype.SelectedIndexChanged
            If Me.g_bCmbxPropertyHasParam1ResRef Then
                Return
            End If
            Dim indiceData As String = Me.itempropdef.GetIndiceData(Me.cmbxPropertyName.SelectedIndex, "subtyperesref")
            Dim cls2DA As cls2DA = Me.ReadCls2DA(indiceData, Me.g_clsChitinKey)
            Dim flag As Boolean = False
            Dim num As Integer = 0
            Dim columnUpperBound As Integer = cls2DA.ColumnUpperBound
            For i As Integer = num To columnUpperBound
                If StringType.StrCmp(Strings.LCase(cls2DA.ColNames(i)), "param1resref", False) = 0 Then
                    flag = True
                    Exit For
                End If
            Next
            If flag Then
                Dim text As String = cls2DA.GetIndiceData(Me.cmbxSubtype.SelectedIndex, "param1resref")
                Me.tbParam1resref.Text = text
                If StringType.StrCmp(text, "****", False) = 0 Then
                    Me.cmbxParam1Value.Enabled = False
                    Me.cmbxParam1Value.Items.Clear()
                    Me.tbParam1tableresref.Text = "None"
                    Me.lblParam1Desc.Text = "(None)"
                Else
                    Me.cmbxParam1Value.Enabled = True
                    Dim i As Integer = IntegerType.FromString(text)
                    text = Me.iprp_paramtable.GetIndiceData(i, "tableresref")
                    Me.FillComboBoxFrom2DA(Me.cmbxParam1Value, "name", Me.ReadCls2DA(text, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                    Me.tbParam1tableresref.Text = text
                    Me.Param1Desc = Me.iprp_paramtable.GetIndiceData(i, "label")
                    Me.lblParam1Desc.Text = "(" + Me.Param1Desc + ")"
                End If
            Else
                Me.cmbxParam1Value.Enabled = False
                Me.cmbxParam1Value.Items.Clear()
            End If
            flag = False
            Dim num2 As Integer = 0
            Dim columnUpperBound2 As Integer = cls2DA.ColumnUpperBound
            For i As Integer = num2 To columnUpperBound2
                If StringType.StrCmp(Strings.LCase(cls2DA.ColNames(i)), "param2resref", False) = 0 Then
                    flag = True
                    Exit For
                End If
            Next
            If flag Then
                Dim text2 As String = cls2DA.GetIndiceData(Me.cmbxSubtype.SelectedIndex, "param2resref")
                Me.tbParam2resref.Text = text2
                If StringType.StrCmp(text2, "****", False) = 0 Then
                    Me.cmbxParam2Value.Enabled = False
                    Me.cmbxParam2Value.Items.Clear()
                    Me.tbParam1tableresref.Text = "None"
                    Me.lblParam2Desc.Text = "(None)"
                Else
                    Me.cmbxParam2Value.Enabled = True
                    Dim i As Integer = IntegerType.FromString(text2)
                    text2 = Me.iprp_paramtable.GetIndiceData(i, "tableresref")
                    Me.FillComboBoxFrom2DA(Me.cmbxParam2Value, "name", Me.ReadCls2DA(text2, Me.g_clsChitinKey), Me.g_clsDialogTlk)
                    Me.tbParam2tableresref.Text = text2
                    Me.Param2Desc = Me.iprp_paramtable.GetIndiceData(i, "label")
                    Me.lblParam2Desc.Text = "(" + Me.Param2Desc + ")"
                End If
            Else
                Me.cmbxParam2Value.Enabled = False
                Me.cmbxParam2Value.Items.Clear()
            End If
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x06000672 RID: 1650 RVA: 0x0024C748 File Offset: 0x0024B748
        Private Function ValidateForm() As Boolean
            Return Me.cmbxPropertyName.SelectedIndex <> -1 AndAlso Not (Me.cmbxSubtype.Enabled And (Me.cmbxSubtype.SelectedIndex = -1)) AndAlso Not (Me.cmbxCostValue.Enabled And (Me.cmbxCostValue.SelectedIndex = -1)) AndAlso Not (Me.cmbxParam1Value.Enabled And (Me.cmbxParam1Value.SelectedIndex = -1)) AndAlso Not (Me.cmbxParam2Value.Enabled And (Me.cmbxParam2Value.SelectedIndex = -1))
        End Function

        ' Token: 0x06000673 RID: 1651 RVA: 0x0024C7E0 File Offset: 0x0024B7E0
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDebug.Click
            If Me.debug Then
                Dim size As Size = New Size(520, 296)
                Me.Size = size
                size = New Size(520, 296)
                Me.MaximumSize = size
                size = New Size(520, 296)
                Me.MinimumSize = size
                Me.debug = False
            Else
                Dim size As Size = New Size(720, 376)
                Me.MaximumSize = size
                size = New Size(720, 376)
                Me.MinimumSize = size
                size = New Size(720, 376)
                Me.Size = size
                Me.debug = True
            End If
        End Sub

        ' Token: 0x06000674 RID: 1652 RVA: 0x0024C898 File Offset: 0x0024B898
        Private Sub cmbxCostValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxCostValue.SelectedIndexChanged
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x06000675 RID: 1653 RVA: 0x0024C8AC File Offset: 0x0024B8AC
        Private Sub cmbxParam1Value_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxParam1Value.SelectedIndexChanged
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x06000676 RID: 1654 RVA: 0x0024C8C0 File Offset: 0x0024B8C0
        Private Sub cmbxParam2Value_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxParam2Value.SelectedIndexChanged
            Me.btnOK.Enabled = Me.ValidateForm()
        End Sub

        ' Token: 0x0400035C RID: 860
        Private usetting As UserSettings

        ' Token: 0x0400035D RID: 861
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x0400035E RID: 862
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x0400035F RID: 863
        Private itempropdef As cls2DA

        ' Token: 0x04000360 RID: 864
        Private iprp_costtable As cls2DA

        ' Token: 0x04000361 RID: 865
        Private iprp_paramtable As cls2DA

        ' Token: 0x04000362 RID: 866
        Private iprp_abilities As cls2DA

        ' Token: 0x04000363 RID: 867
        Private appearance As cls2DA

        ' Token: 0x04000364 RID: 868
        Private classes As cls2DA

        ' Token: 0x04000365 RID: 869
        Private feat As cls2DA

        ' Token: 0x04000366 RID: 870
        Private iprp_acmodtype As cls2DA

        ' Token: 0x04000367 RID: 871
        Private iprp_aligngrp As cls2DA

        ' Token: 0x04000368 RID: 872
        Private iprp_ammotype As cls2DA

        ' Token: 0x04000369 RID: 873
        Private iprp_combatdam As cls2DA

        ' Token: 0x0400036A RID: 874
        Private iprp_damagetype As cls2DA

        ' Token: 0x0400036B RID: 875
        Private iprp_immunity As cls2DA

        ' Token: 0x0400036C RID: 876
        Private iprp_monsterhit As cls2DA

        ' Token: 0x0400036D RID: 877
        Private iprp_onhit As cls2DA

        ' Token: 0x0400036E RID: 878
        Private iprp_protection As cls2DA

        ' Token: 0x0400036F RID: 879
        Private iprp_saveelement As cls2DA

        ' Token: 0x04000370 RID: 880
        Private iprp_savingthrow As cls2DA

        ' Token: 0x04000371 RID: 881
        Private iprp_walk As cls2DA

        ' Token: 0x04000372 RID: 882
        Private racialtypes As cls2DA

        ' Token: 0x04000373 RID: 883
        Private skills As cls2DA

        ' Token: 0x04000374 RID: 884
        Private spells As cls2DA

        ' Token: 0x04000375 RID: 885
        Private traps As cls2DA

        ' Token: 0x04000376 RID: 886
        Public g_bCmbxPropertyHasParam1ResRef As Boolean

        ' Token: 0x04000377 RID: 887
        Public CostTableValue As Integer

        ' Token: 0x04000378 RID: 888
        Public CostTableID As String

        ' Token: 0x04000379 RID: 889
        Public CostTableName As String

        ' Token: 0x0400037A RID: 890
        Public Param1Desc As String

        ' Token: 0x0400037B RID: 891
        Public Param2Desc As String

        ' Token: 0x0400037C RID: 892
        Public CostValue As Integer

        ' Token: 0x0400037D RID: 893
        Private debug As Boolean
    End Class
End Namespace
