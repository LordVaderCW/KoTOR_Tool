Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200007F RID: 127
	Public Partial Class frmUTI_Editor
		Inherits frmParent

		' Token: 0x0600137F RID: 4991 RVA: 0x002B0BA4 File Offset: 0x002AFBA4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUTI_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmUTI_Editor_Closing
			Me.dt = New DataTable()
			Me.htOverrideFiles = New Hashtable()
			Me.m_bSaveGameMode = False
			Me.InitializeComponent()
		End Sub

        ' Token: 0x060013E2 RID: 5090 RVA: 0x002B33E8 File Offset: 0x002B23E8
        Public Sub New(ByVal UTIClass As clsUTI, ByVal KotorVerIndex As Integer, Optional ByVal IsDirectEdit As Boolean = False, Optional ByVal EditingPath As String = "")
            Me.New()
            If IsDirectEdit Then
                Me.m_bSaveGameMode = True
                Me.m_EditingFilePath = EditingPath
            End If
            Me.m_defaultTitleText = "Item Editor - KotOR "
            Me.Text = Me.m_defaultTitleText
            If KotorVerIndex = 0 Then
                Me.Text += "I"
            Else
                Me.Text += "II"
            End If
            Me.CurrentSettings = UserSettings.GetSettings()
            Me.g_clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
            Me.UTI = UTIClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.Setup()
            If Me.htOverrideFiles.Keys.Count > 0 AndAlso Interaction.MsgBox("The loaded file used some data from files in the Override folder" & vbLf & vbLf & "           Click OK to view the files used.", MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Override files used") = MsgBoxResult.Ok Then
                Dim frmOverrideFilesUsed As frmOverrideFilesUsed = New frmOverrideFilesUsed()
                For Each obj As Object In Me.htOverrideFiles
                    Dim dictionaryEntry As DictionaryEntry = CType((If(obj, Activator.CreateInstance(GetType(DictionaryEntry)))), DictionaryEntry)
                    frmOverrideFilesUsed.lbOverrideFiles.Items.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key))
                Next
                frmOverrideFilesUsed.ShowDialog(Me)
            End If
        End Sub

        ' Token: 0x060013E3 RID: 5091 RVA: 0x002B3524 File Offset: 0x002B2524
        Public Sub Setup()
            Me.g_clsChitinKey = New clsChitinKey(Me.CurrentSettings.KeyFileLocation(Me.KotorVersionIndex))
            Me.UTI.SetTextBoxToNodeValue(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTI.SetTextBoxToNodeValue(Me.tbTag, "Tag")
            Me.UTI.SetNumericUpDownToUIntNodeValue(Me.nudCost, "Cost", 0.0F)
            Me.UTI.SetNumericUpDownToUIntNodeValue(Me.nudAdditionalCost, "AddCost", 0.0F)
            Me.UTI.SetNumericUpDownToNodeValue(Me.nudModelVariation, "ModelVariation", 0.0F)
            Me.UTI.SetNumericUpDownToNodeValue(Me.nudCharges, "Charges", 0.0F)
            Me.UTI.SetNumericUpDownToUIntNodeValue(Me.nudStackSize, "StackSize", 0.0F)
            Me.chkbPlotItem.Checked = BooleanType.FromObject(Me.UTI.GetNodeValue("Plot"))
            Me.chkbStolen.Checked = BooleanType.FromObject(Me.UTI.GetNodeValue("Stolen"))
            Me.UTI.SetNumericUpDownToNodeValue(Me.nudPaletteID, "PaletteID", 0.0F)
            If Me.UTI.VerifyNodeExists("TextureVar") Then
                Me.UTI.SetNumericUpDownToNodeValue(Me.nudTextureVariation, "TextureVar", 0.0F)
                Me.nudTextureVariation.Visible = True
                Me.lblTextureVariation.Visible = True
            End If
            If Me.UTI.VerifyNodeExists("BodyVariation") Then
                Me.UTI.SetNumericUpDownToNodeValue(Me.nudBodyVariation, "BodyVariation", 0.0F)
                Me.nudBodyVariation.Visible = True
                Me.lblBodyVariation.Visible = True
            End If
            If Me.UTI.VerifyNodeExists("UpgradeLevel") Then
                Me.UTI.SetNumericUpDownToNodeValue(Me.nudBodyVariation, "UpgradeLevel", 0.0F)
                Me.nudUpgradeLevel.Visible = True
                Me.lblUpgradeLevel.Visible = True
            End If
            Me.BuildDataTable()
            Me.BuildDataGrid()
            Me.ReadPropsAndLoadGrid()
            Me.UTI.SetTextBoxFromCExoLocStringNodeValue(Me.tbLocalizedName, "LocalizedName", Me.g_clsDialogTlk)
            Me.UTI.SetTextBoxFromCExoLocStringNodeValue(Me.tbUnidentifiedDescription, "Description", Me.g_clsDialogTlk)
            Me.UnidentDescLang = IntegerType.FromObject(Me.UTI.GetCExoLocStringLanguage("Description"))
            Me.tbUnidentifiedDescription.Text = Strings.Replace(Me.tbUnidentifiedDescription.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            Me.UTI.SetTextBoxFromCExoLocStringNodeValue(Me.tbIdentifiedDescription, "DescIdentified", Me.g_clsDialogTlk)
            Me.IdentDescLang = IntegerType.FromObject(Me.UTI.GetCExoLocStringLanguage("DescIdentified"))
            Me.tbIdentifiedDescription.Text = Strings.Replace(Me.tbIdentifiedDescription.Text, vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            Me.chkbIdentified.Checked = BooleanType.FromObject(Me.UTI.GetNodeValue("Identified"))
            Me.UTI.SetTextBoxToNodeValue(Me.tbComment, "Comment")
            Me.BuildComboBoxes()
            Me.UTI.SyncComboBox(Me.cmbxBaseItem, "BaseItem")
            If Not Me.UTI.SyncComboBox(Me.cmbxBaseItem, "BaseItem") Then
                Interaction.MsgBox("One or more drop down menus could not be set." & vbLf & vbLf & "This occurs when the file's index value for a menu exceeds the number of items on the menu itself." & vbLf & vbLf & "Menus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error")
            End If
        End Sub

        ' Token: 0x060013E4 RID: 5092 RVA: 0x002B3894 File Offset: 0x002B2894
        Public Sub BuildComboBoxes()
            Me.BuildBaseItemComboBox()
        End Sub

        ' Token: 0x060013E5 RID: 5093 RVA: 0x002B389C File Offset: 0x002B289C
        Public Sub BuildBaseItemComboBox()
            Dim biffarchive As BIFFArchive = New BIFFArchive()
            Dim fileStream As FileStream = New FileStream(Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\data\templates.bif", FileMode.Open)
            Dim biffarchive2 As BIFFArchive = New BIFFArchive(fileStream)
            Dim flag As Boolean = True
            Dim array As Byte()
            If Me.CurrentSettings.bUseOverrideFiles Then
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\override\baseitems.2da"
                Try
                    If File.Exists(text) Then
                        Dim fileStream2 As FileStream = New FileStream(text, FileMode.Open)
                        array = New Byte(CInt(fileStream2.Length) + 1 - 1) {}
                        fileStream2.Read(array, 0, CInt(fileStream2.Length))
                        fileStream2.Close()
                        flag = False
                        Console.WriteLine("Read baseitems.2da from override")
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = Me.g_clsChitinKey.FindResIDForResRef("baseitems", 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + Me.g_clsChitinKey.BiffList(num >> 20).filename
                array = biffarchive.getBIFFResource(text, num).data
                Console.WriteLine("Read baseitems.2da from 2da.bif")
            End If
            Dim clsBaseItems2DA As clsBaseItems2DA = New clsBaseItems2DA(array)
            Dim itemNamesAndTypesList As ArrayList = clsBaseItems2DA.GetItemNamesAndTypesList(Me.g_clsDialogTlk)
            Try
                For Each obj As Object In itemNamesAndTypesList
                    Dim treeBaseItem As TreeBaseItem = CType(obj, TreeBaseItem)
                    Me.cmbxBaseItem.Items.Add(treeBaseItem._name)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x060013E6 RID: 5094 RVA: 0x002B3A70 File Offset: 0x002B2A70
        Private Sub SetGFFNodeValues()
            Me.UTI.SetNodeValueFromComboBox(Me.cmbxBaseItem, "BaseItem")
            Me.UTI.SetNodeValueFromTextBox(Me.tbTemplateResRef, "TemplateResRef")
            Me.UTI.SetNodeValueFromTextBox(Me.tbTag, "Tag")
            Me.UTI.SetNumericUpDownToUIntNodeValue(Me.nudCost, "Cost", 0.0F)
            Me.UTI.SetNodeValueFromNumericUpDown(Me.nudAdditionalCost, "AddCost", 0.0F)
            If Me.UTI.VerifyNodeExists("ModelVariation") Then
                Me.UTI.SetNodeValueFromNumericUpDown(Me.nudModelVariation, "ModelVariation", 0.0F)
            End If
            Me.UTI.SetNodeValueFromNumericUpDown(Me.nudCharges, "Charges", 0.0F)
            Me.UTI.SetNodeValueFromNumericUpDown(Me.nudStackSize, "StackSize", 0.0F)
            Me.UTI.SetNodeValue("Plot", Me.chkbPlotItem.Checked)
            Me.UTI.SetNodeValue("Stolen", Me.chkbStolen.Checked)
            Me.UTI.SetNodeValueFromNumericUpDown(Me.nudPaletteID, "PaletteID", 0.0F)
            If Me.UTI.VerifyNodeExists("TextureVar") Then
                Me.UTI.SetNodeValueFromNumericUpDown(Me.nudTextureVariation, "TextureVar", 0.0F)
            End If
            If Me.UTI.VerifyNodeExists("BodyVariation") Then
                Me.UTI.SetNodeValueFromNumericUpDown(Me.nudBodyVariation, "BodyVariation", 0.0F)
            End If
            If Me.UTI.VerifyNodeExists("UpgradeLevel") Then
                Me.UTI.SetNodeValueFromNumericUpDown(Me.nudBodyVariation, "UpgradeLevel", 0.0F)
            End If
            If Not Me.UTI.VerifyNodeExists("PropertiesList") Then
                Me.UTI.CreateList("", "PropertiesList")
            Else
                Me.UTI.ClearListElements("PropertiesList")
            End If
            Try
                For Each obj As Object In Me.dt.Rows
                    Dim dataRow As DataRow = CType(obj, DataRow)
                    Dim gff_Struct As GFF_Struct = New GFF_Struct()
                    gff_Struct.type = 0
                    gff_Struct.fieldCount = 7
                    If ObjectType.ObjTst(dataRow("Param2ID"), -1, False) <> 0 Then
                        Dim gff_Struct2 As GFF_Struct = gff_Struct
                        gff_Struct2.fieldCount += 2
                    End If
                    If ObjectType.ObjTst(dataRow("UpgradeID"), -1, False) <> 0 Then
                        Dim gff_Struct2 As GFF_Struct = gff_Struct
                        gff_Struct2.fieldCount += 1
                    End If
                    gff_Struct.fields = New GFF_Field(gff_Struct.fieldCount - 1 + 1 - 1) {}
                    gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_word, "PropertyName", IntegerType.FromObject(dataRow("PropertyID")))
                    gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_word, "Subtype", IntegerType.FromObject(dataRow("SubtypeID")))
                    gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "CostTable", IntegerType.FromObject(dataRow("CostTableID")))
                    gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_word, "CostValue", IntegerType.FromObject(dataRow("CostValueID")))
                    gff_Struct.fields(4) = New GFF_Field(GFFField.GFF_byte, "Param1", IntegerType.FromObject(dataRow("Param1ID")))
                    gff_Struct.fields(5) = New GFF_Field(GFFField.GFF_byte, "Param1Value", IntegerType.FromObject(dataRow("Param1ValueID")))
                    Dim num As Integer = 6
                    If ObjectType.ObjTst(dataRow("Param2ID"), -1, False) <> 0 Then
                        gff_Struct.fields(num) = New GFF_Field(GFFField.GFF_byte, "Param2", IntegerType.FromObject(dataRow("Param2ID")))
                        num += 1
                        gff_Struct.fields(num) = New GFF_Field(GFFField.GFF_byte, "Param2Value", IntegerType.FromObject(dataRow("Param2ValueID")))
                        num += 1
                    End If
                    If ObjectType.ObjTst(dataRow("UpgradeID"), -1, False) <> 0 Then
                        gff_Struct.fields(num) = New GFF_Field(GFFField.GFF_byte, "UpgradeType", IntegerType.FromObject(dataRow("UpgradeID")))
                        num += 1
                    End If
                    gff_Struct.fields(num) = New GFF_Field(GFFField.GFF_byte, "ChanceAppear", IntegerType.FromObject(dataRow("% Chance of Appearance")))
                    Me.UTI.AddListElement("PropertiesList", gff_Struct)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.UTI.SetNodeValue("Identified", Me.chkbIdentified.Checked)
            Me.UTI.SetCExoLocStringNodeValueFromTextBox(Me.tbLocalizedName, "LocalizedName", 0)
            Dim textBox As TextBox = New TextBox()
            textBox.Text = Strings.Replace(Me.tbUnidentifiedDescription.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary)
            Me.UTI.SetCExoLocStringNodeValueFromTextBox(textBox, "Description", Me.UnidentDescLang)
            textBox.Text = Strings.Replace(Me.tbIdentifiedDescription.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary)
            Me.UTI.SetCExoLocStringNodeValueFromTextBox(textBox, "DescIdentified", Me.IdentDescLang)
            Me.UTI.SetNodeValueFromTextBox(Me.tbComment, "Comment")
        End Sub

        ' Token: 0x060013E7 RID: 5095 RVA: 0x002B4004 File Offset: 0x002B3004
        Public Function ReadCls2DA(ByVal TwoDAName As String) As cls2DA
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
                    End If
                Catch ex As System.Exception
                    Console.WriteLine("Could not load " + text + " in " + Me.[GetType]().Name)
                End Try
            End If
            If flag Then
                Dim num As Integer = Me.g_clsChitinKey.FindResIDForResRef(TwoDAName, 2017)
                Dim text As String = Me.CurrentSettings.KotorLocation(Me.KotorVersionIndex) + "\" + Me.g_clsChitinKey.BiffList(num >> 20).filename
                array = BIFFArchive.getBIFFResource(text, num).data
            End If
            Return New cls2DA(array)
        End Function

        ' Token: 0x060013E8 RID: 5096 RVA: 0x002B4120 File Offset: 0x002B3120
        Public Function GetCls2DA(ByVal TwoDAName As String) As cls2DA
            Dim text As String = Strings.LCase(TwoDAName)
            If StringType.StrCmp(text, "iprp_abilities", False) = 0 Then
                If Me.iprp_abilities Is Nothing Then
                    Me.iprp_abilities = Me.ReadCls2DA("iprp_abilities")
                End If
                Return Me.iprp_abilities
            End If
            If StringType.StrCmp(text, "appearance", False) = 0 Then
                If Me.appearance Is Nothing Then
                    Me.appearance = Me.ReadCls2DA("appearance")
                End If
                Return Me.appearance
            End If
            If StringType.StrCmp(text, "classes", False) = 0 Then
                If Me.classes Is Nothing Then
                    Me.classes = Me.ReadCls2DA("classes")
                End If
                Return Me.classes
            End If
            If StringType.StrCmp(text, "feat", False) = 0 Then
                If Me.feat Is Nothing Then
                    Me.feat = Me.ReadCls2DA("feat")
                End If
                Return Me.feat
            End If
            If StringType.StrCmp(text, "iprp_acmodtype", False) = 0 Then
                If Me.iprp_acmodtype Is Nothing Then
                    Me.iprp_acmodtype = Me.ReadCls2DA("iprp_acmodtype")
                End If
                Return Me.iprp_acmodtype
            End If
            If StringType.StrCmp(text, "iprp_aligngrp", False) = 0 Then
                If Me.iprp_aligngrp Is Nothing Then
                    Me.iprp_aligngrp = Me.ReadCls2DA("iprp_aligngrp")
                End If
                Return Me.iprp_aligngrp
            End If
            If StringType.StrCmp(text, "iprp_ammotype", False) = 0 Then
                If Me.iprp_ammotype Is Nothing Then
                    Me.iprp_ammotype = Me.ReadCls2DA("iprp_ammotype")
                End If
                Return Me.iprp_ammotype
            End If
            If StringType.StrCmp(text, "iprp_combatdam", False) = 0 Then
                If Me.iprp_combatdam Is Nothing Then
                    Me.iprp_combatdam = Me.ReadCls2DA("iprp_combatdam")
                End If
                Return Me.iprp_combatdam
            End If
            If StringType.StrCmp(text, "iprp_damagetype", False) = 0 Then
                If Me.iprp_damagetype Is Nothing Then
                    Me.iprp_damagetype = Me.ReadCls2DA("iprp_damagetype")
                End If
                Return Me.iprp_damagetype
            End If
            If StringType.StrCmp(text, "iprp_immunity", False) = 0 Then
                If Me.iprp_immunity Is Nothing Then
                    Me.iprp_immunity = Me.ReadCls2DA("iprp_immunity")
                End If
                Return Me.iprp_immunity
            End If
            If StringType.StrCmp(text, "iprp_monsterhit", False) = 0 Then
                If Me.iprp_monsterhit Is Nothing Then
                    Me.iprp_monsterhit = Me.ReadCls2DA("iprp_monsterhit")
                End If
                Return Me.iprp_monsterhit
            End If
            If StringType.StrCmp(text, "iprp_onhit", False) = 0 Then
                If Me.iprp_onhit Is Nothing Then
                    Me.iprp_onhit = Me.ReadCls2DA("iprp_onhit")
                End If
                Return Me.iprp_onhit
            End If
            If StringType.StrCmp(text, "iprp_protection", False) = 0 Then
                If Me.iprp_protection Is Nothing Then
                    Me.iprp_protection = Me.ReadCls2DA("iprp_protection")
                End If
                Return Me.iprp_protection
            End If
            If StringType.StrCmp(text, "iprp_saveelement", False) = 0 Then
                If Me.iprp_saveelement Is Nothing Then
                    Me.iprp_saveelement = Me.ReadCls2DA("iprp_saveelement")
                End If
                Return Me.iprp_saveelement
            End If
            If StringType.StrCmp(text, "iprp_savingthrow", False) = 0 Then
                If Me.iprp_savingthrow Is Nothing Then
                    Me.iprp_savingthrow = Me.ReadCls2DA("iprp_savingthrow")
                End If
                Return Me.iprp_savingthrow
            End If
            If StringType.StrCmp(text, "iprp_walk", False) = 0 Then
                If Me.iprp_walk Is Nothing Then
                    Me.iprp_walk = Me.ReadCls2DA("iprp_walk")
                End If
                Return Me.iprp_walk
            End If
            If StringType.StrCmp(text, "racialtypes", False) = 0 Then
                If Me.racialtypes Is Nothing Then
                    Me.racialtypes = Me.ReadCls2DA("racialtypes")
                End If
                Return Me.racialtypes
            End If
            If StringType.StrCmp(text, "skills", False) = 0 Then
                If Me.skills Is Nothing Then
                    Me.skills = Me.ReadCls2DA("skills")
                End If
                Return Me.skills
            End If
            If StringType.StrCmp(text, "spells", False) = 0 Then
                If Me.spells Is Nothing Then
                    Me.spells = Me.ReadCls2DA("spells")
                End If
                Return Me.spells
            End If
            If StringType.StrCmp(text, "traps", False) = 0 Then
                If Me.traps Is Nothing Then
                    Me.traps = Me.ReadCls2DA("traps")
                End If
                Return Me.traps
            End If
            If StringType.StrCmp(text, "iprp_pc", False) = 0 Then
                If Me.iprp_pc Is Nothing Then
                    Me.iprp_pc = Me.ReadCls2DA("iprp_pc")
                End If
                Return Me.iprp_pc
            End If
            Console.WriteLine("UTI Editor: 2DA file needed for lookup loaded directly - " + TwoDAName)
            Return Me.ReadCls2DA(TwoDAName)
        End Function

        ' Token: 0x060013E9 RID: 5097 RVA: 0x002B4528 File Offset: 0x002B3528
        Public Sub Load2DAs()
            Me.itempropdef = Me.ReadCls2DA("itempropdef")
            Me.iprp_costtable = Me.ReadCls2DA("iprp_costtable")
            Me.iprp_paramtable = Me.ReadCls2DA("iprp_paramtable")
        End Sub

        ' Token: 0x060013EA RID: 5098 RVA: 0x002B4560 File Offset: 0x002B3560
        Public Sub BuildDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Property", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Subtype", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("CostTable", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("CostValue", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param1", GetType(String))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param1Value", GetType(String))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param2", GetType(String))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param2Value", GetType(String))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Upgrade", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("% Chance of Appearance", GetType(String))
            dataColumn.DefaultValue = 100
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("PropertyID", GetType(Integer))
            dataColumn.DefaultValue = 0
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("SubtypeID", GetType(Integer))
            dataColumn.DefaultValue = 0
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("CostTableID", GetType(Integer))
            dataColumn.DefaultValue = 0
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("CostValueID", GetType(Integer))
            dataColumn.DefaultValue = 0
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param1ID", GetType(Integer))
            dataColumn.DefaultValue = -1
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param1ValueID", GetType(Integer))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param2ID", GetType(Integer))
            dataColumn.DefaultValue = -1
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Param2ValueID", GetType(Integer))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("UpgradeID", GetType(Integer))
            dataColumn.DefaultValue = -1
            Me.dt.Columns.Add(dataColumn)
        End Sub

        ' Token: 0x060013EB RID: 5099 RVA: 0x002B48D8 File Offset: 0x002B38D8
        Public Sub BuildDataGrid()
            Me.DView = Me.dt.DefaultView
            Me.DView.AllowDelete = True
            Me.DView.AllowNew = True
            Me.DView.AllowEdit = False
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgProperties.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dt.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Property"
            dataGridTextBoxColumn.HeaderText = "Property"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Subtype"
            dataGridTextBoxColumn.HeaderText = "Subtype"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "CostTable"
            dataGridTextBoxColumn.HeaderText = "CostTable"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "CostValue"
            dataGridTextBoxColumn.HeaderText = "CostValue"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param1"
            dataGridTextBoxColumn.HeaderText = "Param1"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param1Value"
            dataGridTextBoxColumn.HeaderText = "Param1Value"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param2"
            dataGridTextBoxColumn.HeaderText = "Param2"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param2Value"
            dataGridTextBoxColumn.HeaderText = "Param2Value"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Upgrade"
            dataGridTextBoxColumn.HeaderText = "Upgrade"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "% Chance of Appearance"
            dataGridTextBoxColumn.HeaderText = "% Chance of Appearance"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "PropertyID"
            dataGridTextBoxColumn.HeaderText = "PropertyID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "SubtypeID"
            dataGridTextBoxColumn.HeaderText = "SubtypeID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "CostTableID"
            dataGridTextBoxColumn.HeaderText = "CostTableID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "CostValueID"
            dataGridTextBoxColumn.HeaderText = "CostValueID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param1ID"
            dataGridTextBoxColumn.HeaderText = "Param1ID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param1ValueID"
            dataGridTextBoxColumn.HeaderText = "Param1ValueID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param2ID"
            dataGridTextBoxColumn.HeaderText = "Param2ID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Param2ValueID"
            dataGridTextBoxColumn.HeaderText = "Param2ValueID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "UpgradeID"
            dataGridTextBoxColumn.HeaderText = "UpgradeID"
            dataGridTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Me.dgProperties.TableStyles.Add(dataGridTableStyle)
            Me.dgProperties.SetDataBinding(Me.DView, Nothing)
            Me.dgProperties.CaptionVisible = False
        End Sub

        ' Token: 0x060013EC RID: 5100 RVA: 0x002B4D84 File Offset: 0x002B3D84
        Public Sub AutoSizeColumns()
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1
            For i As Integer = num To num2
                Me.dgProperties.TableStyles(0).GridColumnStyles(i).Width = Me.GetColWidth(i, Me.dt.Columns(i).Caption)
            Next
        End Sub

        ' Token: 0x060013ED RID: 5101 RVA: 0x002B4DF0 File Offset: 0x002B3DF0
        Protected Function GetColWidth(ByVal col As Integer, ByVal DisplayName As String) As Integer
            Dim num As Single = 0.0F
            Dim count As Integer = CType(Me.dgProperties.DataSource, DataView).Count
            Dim graphics As Graphics = graphics.FromHwnd(Me.Handle)
            Dim stringFormat As StringFormat = New StringFormat(stringFormat.GenericTypographic)
            num = graphics.MeasureString(DisplayName, Me.Font, 500, stringFormat).Width
            Try
                Dim num2 As Integer = 0
                Dim num3 As Integer = count - 1
                For i As Integer = num2 To num3
                    Dim sizeF As SizeF = graphics.MeasureString(Me.dgProperties(i, col).ToString(), Me.Font, 500, stringFormat)
                    If sizeF.Width > num Then
                        num = sizeF.Width
                    End If
                Next
                graphics.Dispose()
            Catch ex As System.Exception
                num = 75.0F
            End Try
            Return CInt(Math.Round(CDbl((num + 10.0F))))
        End Function

        ' Token: 0x060013EE RID: 5102 RVA: 0x002B4EDC File Offset: 0x002B3EDC
        Private Sub ReadPropsAndLoadGrid()
            If Not Me.UTI.VerifyNodeExists("PropertiesList") Then
                Return
            End If
            Dim listItemCount As Integer = Me.UTI.GetListItemCount("PropertiesList")
            If listItemCount > 0 Then
                Me.Load2DAs()
            End If
            Dim num As Integer = 0
            Dim num2 As Integer = listItemCount - 1
            For i As Integer = num To num2
                Dim dataRow As DataRow = Me.dt.NewRow()
                Dim num3 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").PropertyName")))
                dataRow("PropertyID") = num3
                Dim num4 As Integer = IntegerType.FromString(Me.itempropdef.GetIndiceData(num3, "name"))
                Dim text As String = Me.g_clsDialogTlk.GetString(num4)
                dataRow("Property") = text
                text = Me.itempropdef.GetIndiceData(num3, "subtyperesref")
                Dim obj As Object
                If StringType.StrCmp(text, "****", False) <> 0 Then
                    num3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Subtype")))
                    dataRow("SubtypeID") = num3
                    If StringType.StrCmp(text, "Appearance", False) = 0 Then
                        obj = Me.GetCls2DA(text).GetIndiceData(num3, "label")
                    Else
                        obj = Me.GetCls2DA(text).GetIndiceData(num3, "name")
                    End If
                    If Information.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
                        text = Me.g_clsDialogTlk.GetString(IntegerType.FromObject(obj))
                    ElseIf obj.[GetType]().Name.EndsWith("String") Then
                        text = obj.ToString()
                    Else
                        text = "Error: Unknown type"
                    End If
                    dataRow("Subtype") = text
                End If
                num3 = IntegerType.FromObject(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").CostTable"))
                dataRow("CostTableID") = num3
                text = Me.iprp_costtable.GetIndiceData(num3, "label")
                dataRow("CostTable") = text
                text = Me.iprp_costtable.GetIndiceData(num3, "name")
                num3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").CostValue")))
                dataRow("CostValueID") = num3
                If StringType.StrCmp(text, "IPRP_BASE1", False) <> 0 Then
                    num4 = IntegerType.FromString(Me.ReadCls2DA(text).GetIndiceData(num3, "name"))
                    text = Me.g_clsDialogTlk.GetString(num4)
                    dataRow("CostValue") = text
                Else
                    dataRow("CostValue") = "n/a"
                End If
                obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param1"))
                If obj Is Nothing OrElse ObjectType.ObjTst(obj, 255, False) = 0 Then
                    dataRow("Param1") = "n/a"
                    If ObjectType.ObjTst(obj, 255, False) = 0 Then
                        dataRow("Param1ID") = RuntimeHelpers.GetObjectValue(obj)
                    End If
                    obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param1Value"))
                    If obj Is Nothing Then
                        dataRow("Param1Value") = "n/a"
                        dataRow("Param1ValueID") = -1
                    Else
                        dataRow("Param1ValueID") = RuntimeHelpers.GetObjectValue(obj)
                    End If
                Else
                    num3 = IntegerType.FromObject(obj)
                    dataRow("Param1ID") = num3
                    num4 = IntegerType.FromString(Me.iprp_paramtable.GetIndiceData(num3, "name"))
                    text = Me.g_clsDialogTlk.GetString(num4)
                    dataRow("Param1") = text
                    text = Me.iprp_paramtable.GetIndiceData(num3, "tableresref")
                    obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param1Value"))
                    If obj Is Nothing Then
                        dataRow("Param1Value") = "n/a"
                    Else
                        num3 = IntegerType.FromObject(obj)
                        dataRow("Param1ValueID") = num3
                        num4 = IntegerType.FromString(Me.ReadCls2DA(text).GetIndiceData(num3, "name"))
                        text = Me.g_clsDialogTlk.GetString(num4)
                        dataRow("Param1Value") = text
                    End If
                End If
                obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param2"))
                If obj Is Nothing OrElse ObjectType.ObjTst(obj, 255, False) = 0 Then
                    dataRow("Param2") = "n/a"
                    If ObjectType.ObjTst(obj, 255, False) = 0 Then
                        dataRow("Param2ID") = RuntimeHelpers.GetObjectValue(obj)
                    End If
                    obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param2Value"))
                    If obj Is Nothing Then
                        dataRow("Param2Value") = "n/a"
                        dataRow("Param2ValueID") = -1
                    Else
                        dataRow("Param2ValueID") = RuntimeHelpers.GetObjectValue(obj)
                        dataRow("Param2ValueID") = num3
                        num4 = IntegerType.FromString(Me.ReadCls2DA(text).GetIndiceData(num3, "name"))
                        text = Me.g_clsDialogTlk.GetString(num4)
                        dataRow("Param2Value") = text
                    End If
                Else
                    num3 = IntegerType.FromObject(obj)
                    dataRow("Param2ID") = num3
                    num4 = IntegerType.FromString(Me.iprp_paramtable.GetIndiceData(num3, "name"))
                    text = Me.g_clsDialogTlk.GetString(num4)
                    dataRow("Param2") = text
                    text = Me.iprp_paramtable.GetIndiceData(num3, "tableresref")
                    obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").Param2Value"))
                    If obj Is Nothing Then
                        dataRow("Param2Value") = "n/a"
                    Else
                        num3 = IntegerType.FromObject(obj)
                        dataRow("Param2ValueID") = num3
                        num4 = IntegerType.FromString(Me.ReadCls2DA(text).GetIndiceData(num3, "name"))
                        text = Me.g_clsDialogTlk.GetString(num4)
                        dataRow("Param2Value") = text
                    End If
                End If
                If Me.UTI.VerifyNodeExists("PropertiesList(" + StringType.FromInteger(i) + ").UpgradeType") Then
                    num4 = IntegerType.FromObject(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").UpgradeType"))
                    dataRow("UpgradeID") = num4
                    dataRow("Upgrade") = Strings.Replace(Me.ReadCls2DA("Upgrade").GetIndiceData(num4, "label"), "_", " ", 1, -1, CompareMethod.Binary)
                Else
                    dataRow("UpgradeID") = -1
                    dataRow("Upgrade") = "n/a"
                End If
                obj = RuntimeHelpers.GetObjectValue(Me.UTI.GetNodeValue("PropertiesList(" + StringType.FromInteger(i) + ").ChanceAppear"))
                If obj Is Nothing Then
                    dataRow("% Chance of Appearance") = "n/a"
                Else
                    dataRow("% Chance of Appearance") = RuntimeHelpers.GetObjectValue(obj)
                End If
                Me.dt.Rows.Add(dataRow)
            Next
            Me.AutoSizeColumns()
        End Sub

        ' Token: 0x060013EF RID: 5103 RVA: 0x002B5690 File Offset: 0x002B4690
        Private Sub dgProperties_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim cursor As Cursor = cursor.Current
            Dim dataGrid As DataGrid = CType(sender, DataGrid)
            Dim hitTestInfo As DataGrid.HitTestInfo = dataGrid.HitTest(dataGrid.PointToClient(Control.MousePosition).X, dataGrid.PointToClient(Control.MousePosition).Y)
            If hitTestInfo.Type = dataGrid.HitTestType.RowHeader Then
                Dim frmItemPropertyEditor As frmItemPropertyEditor = New frmItemPropertyEditor(Me.KotorVersionIndex)
                If Me.IsLastRow(hitTestInfo.Row) Then
                    frmItemPropertyEditor.btnOK.Text = "Add"
                    frmItemPropertyEditor.ShowDialog(Me)
                    Application.DoEvents()
                    If frmItemPropertyEditor.DialogResult = DialogResult.OK Then
                        Dim dataRow As DataRow = Me.dt.NewRow()
                        dataRow("Property") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxPropertyName.SelectedItem)
                        dataRow("Subtype") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxSubtype.SelectedItem)
                        dataRow("CostTable") = frmItemPropertyEditor.CostTableName
                        If Not frmItemPropertyEditor.cmbxParam1Value.Enabled Then
                            dataRow("Param1") = "n/a"
                            dataRow("Param1ID") = 255
                            dataRow("Param1Value") = "(none)"
                            dataRow("Param1ValueID") = 0
                        Else
                            dataRow("Param1") = frmItemPropertyEditor.Param1Desc
                            dataRow("Param1ID") = IntegerType.FromString(frmItemPropertyEditor.tbParam1resref.Text)
                            dataRow("Param1Value") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxParam1Value.SelectedItem)
                            dataRow("Param1ValueID") = frmItemPropertyEditor.cmbxParam1Value.SelectedIndex
                        End If
                        If Not frmItemPropertyEditor.cmbxParam2Value.Enabled Then
                            dataRow("Param2") = "n/a"
                            dataRow("Param2ID") = -1
                            dataRow("Param2Value") = "(none)"
                            dataRow("Param2ValueID") = -1
                        Else
                            dataRow("Param2") = frmItemPropertyEditor.Param2Desc
                            dataRow("Param2ID") = IntegerType.FromString(frmItemPropertyEditor.tbParam2resref.Text)
                            dataRow("Param2Value") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxParam2Value.SelectedItem)
                            dataRow("Param2ValueID") = frmItemPropertyEditor.cmbxParam2Value.SelectedIndex
                        End If
                        If frmItemPropertyEditor.cmbxUpgrade.SelectedIndex > 0 Then
                            dataRow("UpgradeID") = frmItemPropertyEditor.cmbxUpgrade.SelectedIndex - 1
                            dataRow("Upgrade") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxUpgrade.SelectedItem)
                        End If
                        dataRow("PropertyID") = frmItemPropertyEditor.cmbxPropertyName.SelectedIndex
                        If Not frmItemPropertyEditor.cmbxSubtype.Enabled Then
                            dataRow("SubtypeID") = 0
                        Else
                            dataRow("SubtypeID") = frmItemPropertyEditor.cmbxSubtype.SelectedIndex
                        End If
                        If StringType.StrCmp(frmItemPropertyEditor.CostTableID, "****", False) = 0 Then
                            dataRow("CostTableID") = 0
                        Else
                            dataRow("CostTableID") = frmItemPropertyEditor.CostTableID
                        End If
                        If (Not frmItemPropertyEditor.cmbxSubtype.Enabled Or (StringType.StrCmp(frmItemPropertyEditor.CostTableID, "****", False) = 0)) And Not frmItemPropertyEditor.cmbxCostValue.Enabled Then
                            dataRow("CostValue") = 0
                            dataRow("CostValueID") = 0
                        ElseIf frmItemPropertyEditor.cmbxSubtype.Enabled And Not frmItemPropertyEditor.cmbxCostValue.Enabled Then
                            dataRow("CostValue") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxSubtype.SelectedItem)
                            dataRow("CostValueID") = frmItemPropertyEditor.cmbxSubtype.SelectedIndex
                        Else
                            dataRow("CostValue") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxCostValue.SelectedItem)
                            dataRow("CostValueID") = frmItemPropertyEditor.cmbxCostValue.SelectedIndex
                        End If
                        dataRow("% Chance of Appearance") = frmItemPropertyEditor.nudPercentChance.Value
                        Me.dt.Rows.Add(dataRow)
                        cursor.Current = Cursors.WaitCursor
                        cursor.Current = cursor
                    End If
                Else
                    frmItemPropertyEditor.btnOK.Text = "Update"
                    Dim dataRow As DataRow = Me.dt.DefaultView(hitTestInfo.Row).Row
                    frmItemPropertyEditor.cmbxPropertyName.SelectedIndex = IntegerType.FromObject(dataRow("PropertyID"))
                    If frmItemPropertyEditor.cmbxSubtype.Items.Count > 0 Then
                        frmItemPropertyEditor.cmbxSubtype.SelectedIndex = IntegerType.FromObject(dataRow("SubtypeID"))
                    End If
                    If frmItemPropertyEditor.cmbxCostValue.Items.Count > 0 Then
                        frmItemPropertyEditor.cmbxCostValue.SelectedIndex = IntegerType.FromObject(dataRow("CostValueID"))
                    End If
                    If IntegerType.FromObject(dataRow("Param1ID")) <> 255 Then
                        frmItemPropertyEditor.cmbxParam1Value.SelectedIndex = IntegerType.FromObject(dataRow("Param1ValueID"))
                    End If
                    If IntegerType.FromObject(dataRow("Param2ID")) <> -1 Then
                        frmItemPropertyEditor.cmbxParam2Value.SelectedIndex = IntegerType.FromObject(dataRow("Param2ValueID"))
                    End If
                    If IntegerType.FromObject(dataRow("UpgradeID")) <> -1 Then
                        frmItemPropertyEditor.cmbxUpgrade.SelectedIndex = IntegerType.FromObject(dataRow("UpgradeID")) + 1
                    End If
                    dataGrid.UnSelect(dataGrid.CurrentRowIndex + 1)
                    frmItemPropertyEditor.ShowDialog(Me)
                    Application.DoEvents()
                    If frmItemPropertyEditor.DialogResult = DialogResult.OK Then
                        Me.SetDataTableReadOnlyState(False)
                        dataRow("Property") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxPropertyName.SelectedItem)
                        dataRow("Subtype") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxSubtype.SelectedItem)
                        dataRow("CostTable") = frmItemPropertyEditor.CostTableName
                        If Not frmItemPropertyEditor.cmbxParam1Value.Enabled Then
                            dataRow("Param1") = "n/a"
                            dataRow("Param1ID") = 255
                            dataRow("Param1Value") = "(none)"
                            dataRow("Param1ValueID") = 0
                        Else
                            dataRow("Param1") = frmItemPropertyEditor.Param1Desc
                            dataRow("Param1ID") = IntegerType.FromString(frmItemPropertyEditor.tbParam1resref.Text)
                            dataRow("Param1Value") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxParam1Value.SelectedItem)
                            dataRow("Param1ValueID") = frmItemPropertyEditor.cmbxParam1Value.SelectedIndex
                        End If
                        If Not frmItemPropertyEditor.cmbxParam2Value.Enabled Then
                            dataRow("Param2") = "n/a"
                            dataRow("Param2ID") = -1
                            dataRow("Param2Value") = "(none)"
                            dataRow("Param2ValueID") = -1
                        Else
                            dataRow("Param2") = frmItemPropertyEditor.Param2Desc
                            dataRow("Param2ID") = IntegerType.FromString(frmItemPropertyEditor.tbParam2resref.Text)
                            dataRow("Param2Value") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxParam2Value.SelectedItem)
                            dataRow("Param2ValueID") = frmItemPropertyEditor.cmbxParam2Value.SelectedIndex
                        End If
                        If frmItemPropertyEditor.cmbxUpgrade.SelectedIndex > 0 Then
                            dataRow("UpgradeID") = frmItemPropertyEditor.cmbxUpgrade.SelectedIndex - 1
                            dataRow("Upgrade") = Strings.Replace(StringType.FromObject(frmItemPropertyEditor.cmbxUpgrade.SelectedItem), "_", " ", 1, -1, CompareMethod.Binary)
                        Else
                            dataRow("UpgradeID") = -1
                            dataRow("Upgrade") = "n/a"
                        End If
                        dataRow("PropertyID") = frmItemPropertyEditor.cmbxPropertyName.SelectedIndex
                        If Not frmItemPropertyEditor.cmbxSubtype.Enabled Then
                            dataRow("SubtypeID") = 0
                        Else
                            dataRow("SubtypeID") = frmItemPropertyEditor.cmbxSubtype.SelectedIndex
                        End If
                        If StringType.StrCmp(frmItemPropertyEditor.CostTableID, "****", False) = 0 Then
                            dataRow("CostTableID") = 0
                        Else
                            dataRow("CostTableID") = frmItemPropertyEditor.CostTableID
                        End If
                        If (Not frmItemPropertyEditor.cmbxSubtype.Enabled Or (StringType.StrCmp(frmItemPropertyEditor.CostTableID, "****", False) = 0)) And Not frmItemPropertyEditor.cmbxCostValue.Enabled Then
                            dataRow("CostValue") = 0
                            dataRow("CostValueID") = 0
                        ElseIf frmItemPropertyEditor.cmbxSubtype.Enabled And Not frmItemPropertyEditor.cmbxCostValue.Enabled Then
                            dataRow("CostValue") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxSubtype.SelectedItem)
                            dataRow("CostValueID") = frmItemPropertyEditor.cmbxSubtype.SelectedIndex
                        Else
                            dataRow("CostValue") = RuntimeHelpers.GetObjectValue(frmItemPropertyEditor.cmbxCostValue.SelectedItem)
                            dataRow("CostValueID") = frmItemPropertyEditor.cmbxCostValue.SelectedIndex
                        End If
                        dataRow("% Chance of Appearance") = frmItemPropertyEditor.nudPercentChance.Value
                        Me.SetDataTableReadOnlyState(True)
                        dataGrid.[Select](hitTestInfo.Row)
                    End If
                End If
            End If
            Me.AutoSizeColumns()
        End Sub

        ' Token: 0x060013F0 RID: 5104 RVA: 0x002B60C8 File Offset: 0x002B50C8
        Protected Function IsLastRow(ByVal row As Integer) As Boolean
            ' The following expression was wrapped in a checked-statement
            Dim flag As Boolean
            Try
                Me.dgProperties.[Select](row + 1)
                Me.dgProperties.UnSelect(row + 1)
                flag = False
            Catch ex As IndexOutOfRangeException
                Dim ex2 As IndexOutOfRangeException = CType(ex, IndexOutOfRangeException)
                flag = True
            End Try
            Return flag
        End Function

        ' Token: 0x060013F1 RID: 5105 RVA: 0x002B611C File Offset: 0x002B511C
        Protected Sub SetDataTableReadOnlyState(ByVal ReadOnlyState As Boolean)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1
            For i As Integer = num To num2
                Me.dt.Columns(i).[ReadOnly] = ReadOnlyState
            Next
        End Sub

        ' Token: 0x060013F2 RID: 5106 RVA: 0x002B6160 File Offset: 0x002B5160
        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x060013F3 RID: 5107 RVA: 0x002B6168 File Offset: 0x002B5168
        Private Sub frmUTI_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.Name)
        End Sub

        ' Token: 0x060013F4 RID: 5108 RVA: 0x002B6178 File Offset: 0x002B5178
        Private Sub frmUTI_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.Name)
        End Sub

        ' Token: 0x060013F5 RID: 5109 RVA: 0x002B6188 File Offset: 0x002B5188
        Public Sub SetFormName(ByVal Name As String)
            Me.Text = "Item Editor - " + Name
        End Sub

        ' Token: 0x060013F6 RID: 5110 RVA: 0x002B619C File Offset: 0x002B519C
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetGFFNodeValues()
            If Not Me.m_bSaveGameMode Then
                Me.m_EditingFilePath = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(Me.m_EditingFilePath) + ".uti", "", "", False, True))
                If StringType.StrCmp(Me.m_EditingFilePath, "", False) = 0 Then
                    Return
                End If
            End If
            Me.UTI.WriteFile(Me.m_EditingFilePath, "UTI")
            If Me.m_bSaveGameMode Then
                Me.Close()
            End If
        End Sub

        ' Token: 0x060013F7 RID: 5111 RVA: 0x002B6234 File Offset: 0x002B5234
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = Me.tbTag.Text
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.UTI.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x060013F8 RID: 5112 RVA: 0x002B62A0 File Offset: 0x002B52A0
        Private Sub btnLoadXML_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", Me.CurrentSettings.defaultImportLocation, "", "Load Properties (XML) file...", "xml", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim dataSet As DataSet = New DataSet("Kotor_ItemProperties_File")
            dataSet.ReadXml(text)
            Me.dt = dataSet.Tables(0)
            dataSet.Tables.Remove(Me.dt)
            dataSet.Dispose()
            Me.DView = Me.dt.DefaultView
            Me.dgProperties.SetDataBinding(Me.DView, Nothing)
            Me.BuildDataGrid()
            Me.AutoSizeColumns()
        End Sub

        ' Token: 0x060013F9 RID: 5113 RVA: 0x002B6354 File Offset: 0x002B5354
        Private Sub btnSaveXML_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, Me.tbTemplateResRef.Text + ".xml", "Save Properties (XML) file...", "xml", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim dataSet As DataSet = New DataSet("Kotor_ItemProperties_File")
            dataSet.Tables.Add(Me.dt)
            dataSet.WriteXml(text)
            dataSet.Tables.Remove(Me.dt)
            dataSet.Dispose()
        End Sub

        ' Token: 0x060013FA RID: 5114 RVA: 0x002B63E8 File Offset: 0x002B53E8
        Private Sub btnSetUnidentDescLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.UnidentDescLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.UnidentDescLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x060013FB RID: 5115 RVA: 0x002B6418 File Offset: 0x002B5418
        Private Sub btnSetIdentDescLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.IdentDescLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.IdentDescLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x04000992 RID: 2450
        Public UTI As clsUTI

        ' Token: 0x04000993 RID: 2451
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x04000994 RID: 2452
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x04000995 RID: 2453
        Private dt As DataTable

        ' Token: 0x04000996 RID: 2454
        Private DView As DataView

        ' Token: 0x04000997 RID: 2455
        Public UnidentDescLang As Integer

        ' Token: 0x04000998 RID: 2456
        Public IdentDescLang As Integer

        ' Token: 0x04000999 RID: 2457
        Private htOverrideFiles As Hashtable

        ' Token: 0x0400099A RID: 2458
        Private m_bSaveGameMode As Boolean

        ' Token: 0x0400099B RID: 2459
        Private itempropdef As cls2DA

        ' Token: 0x0400099C RID: 2460
        Private iprp_costtable As cls2DA

        ' Token: 0x0400099D RID: 2461
        Private iprp_paramtable As cls2DA

        ' Token: 0x0400099E RID: 2462
        Private iprp_abilities As cls2DA

        ' Token: 0x0400099F RID: 2463
        Private appearance As cls2DA

        ' Token: 0x040009A0 RID: 2464
        Private classes As cls2DA

        ' Token: 0x040009A1 RID: 2465
        Private feat As cls2DA

        ' Token: 0x040009A2 RID: 2466
        Private iprp_acmodtype As cls2DA

        ' Token: 0x040009A3 RID: 2467
        Private iprp_aligngrp As cls2DA

        ' Token: 0x040009A4 RID: 2468
        Private iprp_ammotype As cls2DA

        ' Token: 0x040009A5 RID: 2469
        Private iprp_combatdam As cls2DA

        ' Token: 0x040009A6 RID: 2470
        Private iprp_damagetype As cls2DA

        ' Token: 0x040009A7 RID: 2471
        Private iprp_immunity As cls2DA

        ' Token: 0x040009A8 RID: 2472
        Private iprp_monsterhit As cls2DA

        ' Token: 0x040009A9 RID: 2473
        Private iprp_onhit As cls2DA

        ' Token: 0x040009AA RID: 2474
        Private iprp_protection As cls2DA

        ' Token: 0x040009AB RID: 2475
        Private iprp_saveelement As cls2DA

        ' Token: 0x040009AC RID: 2476
        Private iprp_savingthrow As cls2DA

        ' Token: 0x040009AD RID: 2477
        Private iprp_walk As cls2DA

        ' Token: 0x040009AE RID: 2478
        Private racialtypes As cls2DA

        ' Token: 0x040009AF RID: 2479
        Private skills As cls2DA

        ' Token: 0x040009B0 RID: 2480
        Private spells As cls2DA

        ' Token: 0x040009B1 RID: 2481
        Private traps As cls2DA

        ' Token: 0x040009B2 RID: 2482
        Private iprp_pc As cls2DA
    End Class
End Namespace
