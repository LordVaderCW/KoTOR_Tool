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
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000047 RID: 71
	Public Partial Class frmDialogEditor
		Inherits frmParent

		' Token: 0x0600030E RID: 782 RVA: 0x00231058 File Offset: 0x00230058
		Public Sub New()
			Me.dtStunt = New DataTable()
			Me.dtAnim = New DataTable()
			Me.InitializeComponent()
			Me.m_defaultTitleText = "Conversation Editor - KotOR "
			Me.Text = Me.m_defaultTitleText
			Me.BuildStuntDataGrid()
			Me.BuildAnimDataGrid()
		End Sub

        ' Token: 0x0600040D RID: 1037 RVA: 0x002374C8 File Offset: 0x002364C8
        Public Sub New(ByVal EditingPath As String, ByVal KotorVerIndex As Integer)
            Me.New()
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(EditingPath, tvConversation, KotorVerIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.filename = Path.GetFileNameWithoutExtension(EditingPath)
            Me.EditingFilePath = EditingPath
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
        End Sub

        ' Token: 0x0600040E RID: 1038 RVA: 0x00237524 File Offset: 0x00236524
        Public Sub New(ByVal fs As FileStream, ByVal KotorVerIndex As Integer)
            Me.New()
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(fs, tvConversation, KotorVerIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.filename = Path.GetFileNameWithoutExtension(fs.Name)
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
        End Sub

        ' Token: 0x0600040F RID: 1039 RVA: 0x0023757C File Offset: 0x0023657C
        Public Sub New(ByVal bytes As Byte(), ByVal file_name As String, ByVal KotorVerIndex As Integer)
            Me.New()
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(bytes, tvConversation, KotorVerIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.filename = file_name
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
        End Sub

        ' Token: 0x06000410 RID: 1040 RVA: 0x002375CC File Offset: 0x002365CC
        Public Sub SetupForNewDialog()
            Me.tvConversation.Nodes.Clear()
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(tvConversation, Me.KotorVersionIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.gff = Me.clsdlg.dlgGff
            Me.gff.AddFieldToStruct("", "DelayEntry", 4, 0)
            Me.gff.AddFieldToStruct("", "DelayReply", 4, 0)
            Me.gff.AddFieldToStruct("", "EndConversation", 11, "")
            Me.gff.AddFieldToStruct("", "EndConverAbort", 11, "")
            Me.gff.AddFieldToStruct("", "Skippable", 0, 0)
            Me.gff.AddFieldToStruct("", "CameraModel", 11, "")
            Me.gff.AddFieldToStruct("", "VO_ID", 10, "")
            Me.gff.AddFieldToStruct("", "ConversationType", 5, 0)
            Me.gff.AddFieldToStruct("", "ComputerType", 0, 0)
            Me.gff.AddFieldToStruct("", "OldHitCheck", 0, 0)
            Me.gff.AddFieldToStruct("", "AmbientTrack", 11, "")
            Me.gff.AddFieldToStruct("", "UnequipItems", 0, 0)
            Me.gff.AddFieldToStruct("", "AnimatedCut", 0, 0)
            Me.gff.AddFieldToStruct("", "UnequipHItem", 0, 0)
        End Sub

        ' Token: 0x06000411 RID: 1041 RVA: 0x002377A4 File Offset: 0x002367A4
        Private Sub SaveFile()
            Dim cursor As Cursor = cursor.Current
            cursor.Current = Cursors.WaitCursor
            Me.EntryList = New ArrayList()
            Me.ReplyList = New ArrayList()
            Me.gff.ClearListElements("EntryList")
            Me.gff.ClearListElements("ReplyList")
            Me.gff.ClearListElements("StartingList")
            Me.gff.ClearListElements("StuntList")
            Me.SeparateNodes(CType(Me.tvConversation.Nodes(0), DLGConvListNode), "Entry")
            Dim num As Integer
            Try
                For Each obj As Object In Me.EntryList
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    Me.struct = Me.CreateGFFStructFromNode(dlgconvListNode)
                    Me.struct.type = num
                    Me.gff.AddListElement("EntryList", Me.struct)
                    Me.gff.CreateList("EntryList(" + StringType.FromInteger(num) + ")", "AnimList")
                    If dlgconvListNode.Animlist IsNot Nothing Then
                        Dim num2 As Integer = 0
                        Dim num3 As Integer = dlgconvListNode.Animlist.Count - 1
                        For i As Integer = num2 To num3
                            Dim gff_Struct As GFF_Struct = New GFF_Struct(2, 0)
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(dlgconvListNode.Animlist(i), Nothing, "Participant", New Object(-1) {}, Nothing, Nothing)))
                            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_word, "Animation", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(dlgconvListNode.Animlist(i), Nothing, "Animation", New Object(-1) {}, Nothing, Nothing)))
                            Me.gff.AddListElement("EntryList(" + StringType.FromInteger(num) + ").AnimList", gff_Struct)
                        Next
                    End If
                    Me.gff.CreateList("EntryList(" + StringType.FromInteger(num) + ")", "RepliesList")
                    num += 1
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            num = 0
            Try
                For Each obj2 As Object In Me.ReplyList
                    Dim dlgconvListNode As DLGConvListNode = CType(obj2, DLGConvListNode)
                    Me.struct = Me.CreateGFFStructFromNode(dlgconvListNode)
                    Me.struct.type = num
                    Me.gff.AddListElement("ReplyList", Me.struct)
                    Me.gff.CreateList("ReplyList(" + StringType.FromInteger(num) + ")", "EntriesList")
                    Me.gff.CreateList("ReplyList(" + StringType.FromInteger(num) + ")", "AnimList")
                    If dlgconvListNode.Animlist IsNot Nothing Then
                        Dim num4 As Integer = 0
                        Dim num5 As Integer = dlgconvListNode.Animlist.Count - 1
                        For j As Integer = num4 To num5
                            Dim gff_Struct2 As GFF_Struct = New GFF_Struct(2, 0)
                            gff_Struct2.fields(0) = New GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(dlgconvListNode.Animlist(j), Nothing, "Participant", New Object(-1) {}, Nothing, Nothing)))
                            gff_Struct2.fields(1) = New GFF_Field(GFFField.GFF_word, "Animation", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(dlgconvListNode.Animlist(j), Nothing, "Animation", New Object(-1) {}, Nothing, Nothing)))
                            Me.gff.AddListElement("ReplyList(" + StringType.FromInteger(num) + ").AnimList", gff_Struct2)
                        Next
                    End If
                    num += 1
                Next
            Finally
                Dim enumerator2 As IEnumerator = Nothing
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
            Try
                For Each obj3 As Object In Me.tvConversation.Nodes(0).Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj3, DLGConvListNode)
                    Me.BuildGFFLists(dlgconvListNode, "Entry")
                    Dim gff_Struct3 As GFF_Struct = New GFF_Struct(2)
                    gff_Struct3.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.EntryList.IndexOf(dlgconvListNode))
                    Dim text As String
                    If dlgconvListNode.ActiveScript Is Nothing Then
                        text = ""
                    Else
                        text = dlgconvListNode.ActiveScript
                    End If
                    gff_Struct3.fields(1) = New GFF_Field(GFFField.GFF_CResRef, "Active", text)
                    Me.gff.AddListElement("StartingList", gff_Struct3)
                Next
            Finally
                Dim enumerator3 As IEnumerator = Nothing
                If TypeOf enumerator3 Is IDisposable Then
                    CType(enumerator3, IDisposable).Dispose()
                End If
            End Try
            Me.SetDLGRootItemsValues()
            cursor.Current = cursor
            Dim text2 As String
            If StringType.StrCmp(Me.EditingFilePath, "", False) <> 0 Then
                text2 = Me.EditingFilePath
            Else
                text2 = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, Me.filename + ".dlg", "", "", False, True))
            End If
            If StringType.StrCmp(text2, "", False) = 0 Then
                Return
            End If
            Me.gff.WriteFile(text2, "DLG")
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
            Me.Text = "Conversation Editor - " + Path.GetFileNameWithoutExtension(text2) + ".dlg"
        End Sub

        ' Token: 0x06000412 RID: 1042 RVA: 0x00237D24 File Offset: 0x00236D24
        Private Sub SetDLGRootItemsValues()
            If Not Me.gff.VerifyNodeExists("DelayEntry") Then
                Me.gff.AddFieldToStruct("", "DelayEntry", 4, 0)
            End If
            If Not Me.gff.VerifyNodeExists("DelayReply") Then
                Me.gff.AddFieldToStruct("", "DelayReply", 4, 0)
            End If
            If Not Me.gff.VerifyNodeExists("EndConversation") Then
                Me.gff.AddFieldToStruct("", "EndConversation", 11, "")
            End If
            If Not Me.gff.VerifyNodeExists("EndConverAbort") Then
                Me.gff.AddFieldToStruct("", "EndConverAbort", 11, "")
            End If
            If Not Me.gff.VerifyNodeExists("Skippable") Then
                Me.gff.AddFieldToStruct("", "Skippable", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("CameraModel") Then
                Me.gff.AddFieldToStruct("", "CameraModel", 11, "")
            End If
            If Not Me.gff.VerifyNodeExists("VO_ID") Then
                Me.gff.AddFieldToStruct("", "VO_ID", 10, "")
            End If
            If Not Me.gff.VerifyNodeExists("ConversationType") Then
                Me.gff.AddFieldToStruct("", "ConversationType", 5, 0)
            End If
            If Me.cmbxConversationType.SelectedIndex = 1 AndAlso Not Me.gff.VerifyNodeExists("ComputerType") Then
                Me.gff.AddFieldToStruct("", "ComputerType", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("OldHitCheck") Then
                Me.gff.AddFieldToStruct("", "OldHitCheck", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("AmbientTrack") Then
                Me.gff.AddFieldToStruct("", "AmbientTrack", 11, "")
            End If
            If Not Me.gff.VerifyNodeExists("UnequipItems") Then
                Me.gff.AddFieldToStruct("", "UnequipItems", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("UnequipHItem") Then
                Me.gff.AddFieldToStruct("", "UnequipHItem", 0, 0)
            End If
            If Not Me.gff.VerifyNodeExists("StuntList") Then
                Me.gff.CreateList("", "StuntList")
            End If
            Me.gff.SetNodeValue("DelayEntry", Me.nudDelayEntry.Value)
            Me.gff.SetNodeValue("DelayReply", Me.nudDelayReply.Value)
            Me.gff.SetNodeValue("EndConversation", Me.tbEndConversation.Text.Trim())
            Me.gff.SetNodeValue("EndConverAbort", Me.tbEndConverAbort.Text.Trim())
            Me.gff.SetNodeValue("Skippable", Me.chkbSkippable.Checked)
            Me.gff.SetNodeValue("VO_ID", Me.tbVO_ID.Text.Trim())
            Me.gff.SetNodeValue("ConversationType", Me.cmbxConversationType.SelectedIndex)
            If Me.cmbxConversationType.SelectedIndex = 1 Then
                Me.gff.SetNodeValue("ComputerType", CByte(Me.cmbxComputerType.SelectedIndex))
            End If
            Me.gff.SetNodeValue("AmbientTrack", Me.tbAmbientTrack.Text.Trim())
            Me.gff.SetNodeValue("UnequipItems", Me.chkbUnequipItems.Checked)
            Me.gff.SetNodeValue("UnequipHItem", Me.chkbUnequipHItem.Checked)
            If Me.gff.VerifyNodeExists("AnimatedCut") Then
                Me.chkbAnimatedCut.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("AnimatedCut"))
                If Not Me.gff.VerifyNodeExists("CameraModel") Then
                    Me.gff.AddFieldToStruct("", "CameraModel", 11, "")
                End If
                Me.gff.SetNodeValueFromTextBox(Me.tbCameraModel, "CameraModel")
            ElseIf Me.chkbAnimatedCut.Checked Then
                If Not Me.gff.VerifyNodeExists("AnimatedCut") Then
                    Me.gff.AddFieldToStruct("", "AnimatedCut", 0, 0)
                End If
                Me.gff.SetNodeValue("AnimatedCut", 1)
                If Not Me.gff.VerifyNodeExists("CameraModel") Then
                    Me.gff.AddFieldToStruct("", "CameraModel", 11, "")
                End If
                Me.gff.SetNodeValueFromTextBox(Me.tbCameraModel, "CameraModel")
            End If
            Dim num As Integer = 0
            Dim num2 As Integer = Me.DViewStunt.Table.Rows.Count - 1
            For i As Integer = num To num2
                Dim gff_Struct As GFF_Struct = New GFF_Struct(2, 0)
                gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CExoString, "Participant", RuntimeHelpers.GetObjectValue(Me.DViewStunt.Table.Rows(i)("Participant")))
                gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CResRef, "StuntModel", RuntimeHelpers.GetObjectValue(Me.DViewStunt.Table.Rows(i)("StuntModel")))
                Me.gff.AddListElement("StuntList", gff_Struct)
            Next
        End Sub

        ' Token: 0x06000413 RID: 1043 RVA: 0x002382F4 File Offset: 0x002372F4
        Private Sub SetFormToDLGRootItems()
            Me.gff.SetNumericUpDownToUIntNodeValue(Me.nudDelayEntry, "DelayEntry", 0.0F)
            Me.gff.SetNumericUpDownToUIntNodeValue(Me.nudDelayReply, "DelayReply", 0.0F)
            Me.gff.SetTextBoxToNodeValue(Me.tbEndConversation, "EndConversation")
            Me.gff.SetTextBoxToNodeValue(Me.tbEndConverAbort, "EndConverAbort")
            Me.chkbSkippable.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("Skippable"))
            Me.chkbUnequipItems.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("UnequipItems"))
            Me.chkbUnequipHItem.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("UnequipHItem"))
            Me.gff.SetTextBoxToNodeValue(Me.tbVO_ID, "VO_ID")
            Me.cmbxConversationType.SelectedIndex = IntegerType.FromObject(Me.gff.GetNodeValue("ConversationType"))
            If Me.cmbxConversationType.SelectedIndex = 1 Then
                Me.cmbxComputerType.SelectedIndex = IntegerType.FromObject(Me.gff.GetNodeValue("ComputerType"))
            End If
            Me.gff.SetTextBoxToNodeValue(Me.tbAmbientTrack, "AmbientTrack")
            Me.gff.SetTextBoxToNodeValue(Me.tbCameraModel, "CameraModel")
            Me.chkbAnimatedCut.Checked = BooleanType.FromObject(Me.gff.GetNodeValue("AnimatedCut"))
            If Me.gff.VerifyNodeExists("StuntList") AndAlso Me.gff.GetListItemCount("StuntList") > 0 Then
                Dim num As Integer = 0
                Dim num2 As Integer = Me.gff.GetListItemCount("StuntList") - 1
                For i As Integer = num To num2
                    Dim dataRow As DataRow = Me.dtStunt.NewRow()
                    dataRow(0) = RuntimeHelpers.GetObjectValue(Me.gff.GetNodeValue("StuntList(" + StringType.FromInteger(i) + ").Participant"))
                    dataRow(1) = RuntimeHelpers.GetObjectValue(Me.gff.GetNodeValue("StuntList(" + StringType.FromInteger(i) + ").StuntModel"))
                    Me.dtStunt.Rows.Add(dataRow)
                Next
            End If
        End Sub

        ' Token: 0x06000414 RID: 1044 RVA: 0x00238534 File Offset: 0x00237534
        Private Function CreateGFFStructFromNode(ByVal tn As DLGConvListNode) As GFF_Struct
            Dim gff_Struct As GFF_Struct = New GFF_Struct()
            gff_Struct.fieldCount = 4
            gff_Struct.fields = New GFF_Field(gff_Struct.fieldCount - 1 + 1 - 1) {}
            Dim gffexoLocString As GFFExoLocString = New GFFExoLocString()
            gffexoLocString.StringCount = 1
            gffexoLocString.StringRef = -1
            gffexoLocString.subStringArr = CType(Array.CreateInstance(GetType(Object), 1), Object())
            Dim gffexoLocSubString As GFFExoLocSubString = New GFFExoLocSubString()
            gffexoLocSubString.StringID = 0
            gffexoLocSubString.StringLength = tn.InternalText.Length
            gffexoLocSubString.value = tn.InternalText
            gffexoLocString.subStringArr(0) = gffexoLocSubString
            gffexoLocString.size = 16 + tn.InternalText.Length
            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_CExoLocString, "Text", gffexoLocString)
            gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_dword, "Delay", 4294967295L)
            gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_dword, "WaitFlags", 0)
            gff_Struct.fields(3) = New GFF_Field(GFFField.GFF_byte, "FadeType", tn.FadeType)
            Dim gff_Struct2 As GFF_Struct
            If StringType.StrCmp(tn.Script, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Script, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CResRef, "Script", tn.Script)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Sound, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Sound, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CResRef, "Sound", tn.Sound)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.VO_ResRef, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.VO_ResRef, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CResRef, "VO_ResRef", tn.VO_ResRef)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Speaker, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Speaker, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CExoString, "Speaker", tn.Speaker)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Comment, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Comment, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CExoString, "Comment", tn.Comment)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Listener, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Listener, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CExoString, "Listener", tn.Listener)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If tn.CameraAngle > 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_dword, "CameraAngle", tn.CameraAngle)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 1
            End If
            If StringType.StrCmp(tn.Quest, Nothing, False) <> 0 AndAlso StringType.StrCmp(tn.Quest, "", False) <> 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_CExoString, "Quest", tn.Quest)
                gff_Struct.fields(gff_Struct.fieldCount + 1) = New GFF_Field(GFFField.GFF_dword, "QuestEntry", tn.QuestEntry)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 2
            End If
            If tn.FadeType > 0 Then
                gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 2 + 1 - 1) {}), GFF_Field())
                gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_float, "FadeDelay", tn.FadeDelay)
                gff_Struct.fields(gff_Struct.fieldCount + 1) = New GFF_Field(GFFField.GFF_float, "FadeLength", tn.FadeLength)
                If tn.FadeColor Is Nothing Then
                    tn.FadeColor = New GFFType17()
                    tn.FadeColor.f1 = 0.0F
                    tn.FadeColor.f2 = 0.0F
                    tn.FadeColor.f3 = 0.0F
                End If
                gff_Struct.fields(gff_Struct.fieldCount + 2) = New GFF_Field(GFFField.GFF_Type17, "FadeColor", tn.FadeColor)
                gff_Struct2 = gff_Struct
                gff_Struct2.fieldCount += 3
            End If
            gff_Struct.fields = CType(Utils.CopyArray(CType(gff_Struct.fields, Array), New GFF_Field(gff_Struct.fieldCount + 1 + 1 - 1) {}), GFF_Field())
            gff_Struct.fields(gff_Struct.fieldCount) = New GFF_Field(GFFField.GFF_int, "CameraID", tn.CameraID)
            gff_Struct.fields(gff_Struct.fieldCount + 1) = New GFF_Field(GFFField.GFF_int, "CamVidEffect", tn.CamVidEffect)
            gff_Struct2 = gff_Struct
            gff_Struct2.fieldCount += 2
            Return gff_Struct
        End Function

        ' Token: 0x06000415 RID: 1045 RVA: 0x00238C18 File Offset: 0x00237C18
        Private Sub RemoveChildLinks(ByVal parentNode As DLGConvListNode)
            Try
                For Each obj As Object In parentNode.Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    Me.RemoveChildLinks(dlgconvListNode)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            If parentNode.IsLink > 0 Then
                parentNode.LinkedToNode.LinkedNodesList.Remove(parentNode)
            End If
        End Sub

        ' Token: 0x06000416 RID: 1046 RVA: 0x00238C90 File Offset: 0x00237C90
        Private Sub ResetChildNodesDescAfterPasteTree(ByVal parentNode As DLGConvListNode)
            Try
                For Each obj As Object In parentNode.Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    If parentNode.IsReply Then
                        dlgconvListNode.IsEntry = True
                    Else
                        dlgconvListNode.IsReply = True
                    End If
                    dlgconvListNode.ForeColor = dlgconvListNode.DialogColor
                    Me.ResetChildNodesDescAfterPasteTree(dlgconvListNode)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing

                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            If parentNode IsNot Me.tvConversation.Nodes(0) Then
                parentNode.Text = parentNode.NodeDesc
            End If
        End Sub

        ' Token: 0x06000417 RID: 1047 RVA: 0x00238D30 File Offset: 0x00237D30
        Private Sub SeparateNodes(ByVal innode As DLGConvListNode, ByVal CurrNodeType As String)
            Try
                For Each obj As Object In innode.Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    If StringType.StrCmp(CurrNodeType, "Entry", False) = 0 Then
                        Me.EntryList.Add(dlgconvListNode)
                        Me.SeparateNodes(dlgconvListNode, "Reply")
                    Else
                        Me.ReplyList.Add(dlgconvListNode)
                        Me.SeparateNodes(dlgconvListNode, "Entry")
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000418 RID: 1048 RVA: 0x00238DC8 File Offset: 0x00237DC8
        Private Sub BuildGFFLists(ByVal parentNode As DLGConvListNode, ByVal CurrNodeType As String)
            Try
                For Each obj As Object In parentNode.Nodes
                    Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
                    If StringType.StrCmp(CurrNodeType, "Entry", False) = 0 Then
                        Dim gff_Struct As GFF_Struct = New GFF_Struct(3)
                        If dlgconvListNode.IsLink > 0 Then
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.ReplyList.IndexOf(dlgconvListNode.LinkedToNode))
                        Else
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.ReplyList.IndexOf(dlgconvListNode))
                        End If
                        gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CResRef, "Active", dlgconvListNode.ActiveScript)
                        gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "IsChild", dlgconvListNode.IsLink)
                        Me.gff.AddListElement("EntryList(" + StringType.FromInteger(Me.EntryList.IndexOf(parentNode)) + ").RepliesList", gff_Struct)
                        If Not dlgconvListNode.IsLink > 0 Then
                            Me.BuildGFFLists(dlgconvListNode, "Reply")
                        End If
                    Else
                        Dim gff_Struct As GFF_Struct = New GFF_Struct(3)
                        If dlgconvListNode.IsLink > 0 Then
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.EntryList.IndexOf(dlgconvListNode.LinkedToNode))
                        Else
                            gff_Struct.fields(0) = New GFF_Field(GFFField.GFF_dword, "Index", Me.EntryList.IndexOf(dlgconvListNode))
                        End If
                        gff_Struct.fields(1) = New GFF_Field(GFFField.GFF_CResRef, "Active", dlgconvListNode.ActiveScript)
                        gff_Struct.fields(2) = New GFF_Field(GFFField.GFF_byte, "IsChild", dlgconvListNode.IsLink)
                        Me.gff.AddListElement("ReplyList(" + StringType.FromInteger(Me.ReplyList.IndexOf(parentNode)) + ").EntriesList", gff_Struct)
                        If Not dlgconvListNode.IsLink > 0 Then
                            Me.BuildGFFLists(dlgconvListNode, "Entry")
                        End If
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000419 RID: 1049 RVA: 0x00239008 File Offset: 0x00238008
        Public Sub BuildAnimDataGrid()
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgAnimList.TableStyles.Clear()
            dataGridTableStyle.MappingName = "ArrayList"
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Participant"
            dataGridTextBoxColumn.HeaderText = "Participant"
            dataGridTextBoxColumn.Alignment = HorizontalAlignment.Center
            dataGridTextBoxColumn.Width = 120
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.[ReadOnly] = False
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Animation"
            dataGridTextBoxColumn.HeaderText = "Animation"
            dataGridTextBoxColumn.Alignment = HorizontalAlignment.Center
            dataGridTextBoxColumn.Width = 75
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.CharacterCasing = CharacterCasing.Lower
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Me.dgAnimList.TableStyles.Add(dataGridTableStyle)
            Me.dgAnimList.CaptionText = "Animation List"
            Me.dgAnimList.CaptionFont = New Font("Microsoft Sans Serif", 9.0F)
        End Sub

        ' Token: 0x0600041A RID: 1050 RVA: 0x0023912C File Offset: 0x0023812C
        Public Sub BuildStuntDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Participant", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dtStunt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("StuntModel", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dtStunt.Columns.Add(dataColumn)
            Me.dtStunt.TableName = "StuntList"
        End Sub

        ' Token: 0x0600041B RID: 1051 RVA: 0x002391AC File Offset: 0x002381AC
        Public Sub BuildStuntDataGrid()
            Me.BuildStuntDataTable()
            Me.DViewStunt = Me.dtStunt.DefaultView
            Me.DViewStunt.AllowDelete = True
            Me.DViewStunt.AllowNew = True
            Me.DViewStunt.AllowEdit = True
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgStuntList.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dtStunt.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Participant"
            dataGridTextBoxColumn.HeaderText = "Participant"
            dataGridTextBoxColumn.Alignment = HorizontalAlignment.Center
            dataGridTextBoxColumn.Width = 120
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.[ReadOnly] = False
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "StuntModel"
            dataGridTextBoxColumn.HeaderText = "Model"
            dataGridTextBoxColumn.Alignment = HorizontalAlignment.Center
            dataGridTextBoxColumn.Width = 120
            dataGridTextBoxColumn.NullText = ""
            dataGridTextBoxColumn.TextBox.CharacterCasing = CharacterCasing.Lower
            dataGridTextBoxColumn.TextBox.MaxLength = 16
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Me.dgStuntList.TableStyles.Add(dataGridTableStyle)
            Me.dgStuntList.SetDataBinding(Me.DViewStunt, Nothing)
            Me.dgStuntList.CaptionText = "Stunt List"
            Me.dgStuntList.CaptionFont = New Font("Microsoft Sans Serif", 9.0F)
        End Sub

        ' Token: 0x0600041C RID: 1052 RVA: 0x00239330 File Offset: 0x00238330
        Private Sub btnExpandAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExpandAll.Click
            Me.tvConversation.ExpandAll()
            Me.tvConversation.SelectedNode = Me.tvConversation.Nodes(0)
        End Sub

        ' Token: 0x0600041D RID: 1053 RVA: 0x0023935C File Offset: 0x0023835C
        Private Sub btnCollapseAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCollapseAll.Click
            Me.tvConversation.CollapseAll()
        End Sub

        ' Token: 0x0600041E RID: 1054 RVA: 0x0023936C File Offset: 0x0023836C
        Private Sub btnDebug_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDebug.Click
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Filename = "dialog"
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
            frmTextEditor.RTFMode = True
            frmTextEditor.tbGeneric.Rtf = Me.clsdlg.ToString()
            frmTextEditor.tbGeneric.SelectionLength = 0
            frmTextEditor.Show()
        End Sub

        ' Token: 0x0600041F RID: 1055 RVA: 0x002393D0 File Offset: 0x002383D0
        Private Sub btnTest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTest.Click
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            Dim dlgconvListNode2 As DLGConvListNode = CType(dlgconvListNode.Parent, DLGConvListNode)
            Dim num As Integer = dlgconvListNode2.Nodes.IndexOf(dlgconvListNode)
            dlgconvListNode2.Nodes.Remove(dlgconvListNode)
            dlgconvListNode2.Nodes.Insert(num - 1, dlgconvListNode)
        End Sub

        ' Token: 0x06000420 RID: 1056 RVA: 0x00239424 File Offset: 0x00238424
        Private Sub btnChooseColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChooseColor.Click
            Dim colorDialog As ColorDialog = New ColorDialog()
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            If dlgconvListNode.FadeColor Is Nothing Then
                dlgconvListNode.FadeColor = New GFFType17()
                dlgconvListNode.FadeColor.f1 = 0.0F
                dlgconvListNode.FadeColor.f2 = 0.0F
                dlgconvListNode.FadeColor.f3 = 0.0F
            End If
            colorDialog.AllowFullOpen = True
            colorDialog.FullOpen = True
            colorDialog.Color = Color.FromArgb(0, CInt(Math.Round(CDbl(dlgconvListNode.FadeColor.f1))), CInt(Math.Round(CDbl(dlgconvListNode.FadeColor.f2))), CInt(Math.Round(CDbl(dlgconvListNode.FadeColor.f3))))
            If colorDialog.ShowDialog() = DialogResult.OK Then
                Me.nudFadeColorR.Text = StringType.FromByte(colorDialog.Color.R)
                Me.nudFadeColorG.Text = StringType.FromByte(colorDialog.Color.G)
                Me.nudFadeColorB.Text = StringType.FromByte(colorDialog.Color.B)
                dlgconvListNode.FadeColor.f1 = Convert.ToSingle(colorDialog.Color.R)
                dlgconvListNode.FadeColor.f2 = Convert.ToSingle(colorDialog.Color.G)
                dlgconvListNode.FadeColor.f3 = Convert.ToSingle(colorDialog.Color.B)
            End If
        End Sub

        ' Token: 0x06000421 RID: 1057 RVA: 0x002395A0 File Offset: 0x002385A0
        Private Sub WireUpEventHandlers()
            AddHandler Me.tbConversationText.TextChanged, AddressOf Me.tbConversationText_TextChanged
            AddHandler Me.tbTextActiveScript.TextChanged, AddressOf Me.tbTextActiveScript_TextChanged
            AddHandler Me.tbActionsTakenScript.TextChanged, AddressOf Me.tbActionsTakenScript_TextChanged
            AddHandler Me.nudPlotIndex.ValueChanged, AddressOf Me.nudPlotIndex_ValueChanged
            AddHandler Me.nudPlotXPPercentage.ValueChanged, AddressOf Me.nudPlotXPPercentage_ValueChanged
            AddHandler Me.tbComments.TextChanged, AddressOf Me.tbComments_TextChanged
            AddHandler Me.nudCameraAngle.ValueChanged, AddressOf Me.nudCameraAngle_ValueChanged
            AddHandler Me.nudCamHeightOffset.ValueChanged, AddressOf Me.nudCamHeightOffset_ValueChanged
            AddHandler Me.nudTarHeightOffset.ValueChanged, AddressOf Me.nudTarHeightOffset_ValueChanged
            AddHandler Me.tbListener.TextChanged, AddressOf Me.tbListener_TextChanged
            AddHandler Me.nudFadeDelay.ValueChanged, AddressOf Me.nudFadeDelay_ValueChanged
            AddHandler Me.nudFadeLength.ValueChanged, AddressOf Me.nudFadeLength_ValueChanged
            AddHandler Me.nudFadeColorR.ValueChanged, AddressOf Me.nudFadeColorR_ValueChanged
            AddHandler Me.nudFadeColorG.ValueChanged, AddressOf Me.nudFadeColorG_ValueChanged
            AddHandler Me.nudFadeColorB.ValueChanged, AddressOf Me.nudFadeColorB_ValueChanged
            AddHandler Me.tbSound.TextChanged, AddressOf Me.tbSound_TextChanged
            AddHandler Me.tbSpeaker.TextChanged, AddressOf Me.tbSpeaker_TextChanged
            AddHandler Me.tbVoiceOverResRef.TextChanged, AddressOf Me.tbVoiceOverResRef_TextChanged
            AddHandler Me.nudCameraID.ValueChanged, AddressOf Me.nudCameraID_ValueChanged
            AddHandler Me.cmbxCamVidEffect.SelectedIndexChanged, AddressOf Me.cmbxCamVidEffect_SelectedIndexChanged
            AddHandler Me.nudPlotIndex.Validated, AddressOf Me.nudPlotIndex_ValueChanged
            AddHandler Me.nudPlotXPPercentage.Validated, AddressOf Me.nudPlotXPPercentage_ValueChanged
            AddHandler Me.nudCameraAngle.Validated, AddressOf Me.nudCameraAngle_ValueChanged
            AddHandler Me.nudCamHeightOffset.Validated, AddressOf Me.nudCamHeightOffset_ValueChanged
            AddHandler Me.nudTarHeightOffset.Validated, AddressOf Me.nudTarHeightOffset_ValueChanged
            AddHandler Me.nudFadeDelay.Validated, AddressOf Me.nudFadeDelay_ValueChanged
            AddHandler Me.nudFadeLength.Validated, AddressOf Me.nudFadeLength_ValueChanged
            AddHandler Me.nudFadeColorR.Validated, AddressOf Me.nudFadeColorR_ValueChanged
            AddHandler Me.nudFadeColorG.Validated, AddressOf Me.nudFadeColorG_ValueChanged
            AddHandler Me.nudFadeColorB.Validated, AddressOf Me.nudFadeColorB_ValueChanged
            AddHandler Me.nudCameraID.Validated, AddressOf Me.nudCameraID_ValueChanged
            AddHandler Me.nudFadeColorB.ValueChanged, AddressOf Me.nudFadeColorB_ValueChanged
            AddHandler Me.tbQuest.TextChanged, AddressOf Me.tbQuest_TextChanged
            AddHandler Me.nudQuestEntry.Validated, AddressOf Me.nudQuestEntry_ValueChanged
            AddHandler Me.cmbxFadeType.SelectedIndexChanged, AddressOf Me.cmbxFadeType_SelectedIndexChanged
            AddHandler Me.nudCamFieldOfView.ValueChanged, AddressOf Me.nudCamFieldOfView_ValueChanged
            AddHandler Me.nudCamFieldOfView.Validated, AddressOf Me.nudCamFieldOfView_ValueChanged
        End Sub

        ' Token: 0x06000422 RID: 1058 RVA: 0x00239928 File Offset: 0x00238928
        Private Sub DisconnectEventHandlers()
            RemoveHandler Me.tbConversationText.TextChanged, AddressOf Me.tbConversationText_TextChanged
            RemoveHandler Me.tbTextActiveScript.TextChanged, AddressOf Me.tbTextActiveScript_TextChanged
            RemoveHandler Me.tbActionsTakenScript.TextChanged, AddressOf Me.tbActionsTakenScript_TextChanged
            RemoveHandler Me.nudPlotIndex.ValueChanged, AddressOf Me.nudPlotIndex_ValueChanged
            RemoveHandler Me.nudPlotXPPercentage.ValueChanged, AddressOf Me.nudPlotXPPercentage_ValueChanged
            RemoveHandler Me.tbComments.TextChanged, AddressOf Me.tbComments_TextChanged
            RemoveHandler Me.nudCameraAngle.ValueChanged, AddressOf Me.nudCameraAngle_ValueChanged
            RemoveHandler Me.nudCamHeightOffset.ValueChanged, AddressOf Me.nudCamHeightOffset_ValueChanged
            RemoveHandler Me.nudTarHeightOffset.ValueChanged, AddressOf Me.nudTarHeightOffset_ValueChanged
            RemoveHandler Me.tbListener.TextChanged, AddressOf Me.tbListener_TextChanged
            RemoveHandler Me.nudFadeDelay.ValueChanged, AddressOf Me.nudFadeDelay_ValueChanged
            RemoveHandler Me.nudFadeLength.ValueChanged, AddressOf Me.nudFadeLength_ValueChanged
            RemoveHandler Me.nudFadeColorR.ValueChanged, AddressOf Me.nudFadeColorR_ValueChanged
            RemoveHandler Me.nudFadeColorG.ValueChanged, AddressOf Me.nudFadeColorG_ValueChanged
            RemoveHandler Me.nudFadeColorB.ValueChanged, AddressOf Me.nudFadeColorB_ValueChanged
            RemoveHandler Me.tbSound.TextChanged, AddressOf Me.tbSound_TextChanged
            RemoveHandler Me.tbSpeaker.TextChanged, AddressOf Me.tbSpeaker_TextChanged
            RemoveHandler Me.tbVoiceOverResRef.TextChanged, AddressOf Me.tbVoiceOverResRef_TextChanged
            RemoveHandler Me.nudCameraID.ValueChanged, AddressOf Me.nudCameraID_ValueChanged
            RemoveHandler Me.cmbxCamVidEffect.SelectedIndexChanged, AddressOf Me.cmbxCamVidEffect_SelectedIndexChanged
            RemoveHandler Me.nudPlotIndex.Validated, AddressOf Me.nudPlotIndex_ValueChanged
            RemoveHandler Me.nudPlotXPPercentage.Validated, AddressOf Me.nudPlotXPPercentage_ValueChanged
            RemoveHandler Me.nudCameraAngle.Validated, AddressOf Me.nudCameraAngle_ValueChanged
            RemoveHandler Me.nudCamHeightOffset.Validated, AddressOf Me.nudCamHeightOffset_ValueChanged
            RemoveHandler Me.nudTarHeightOffset.Validated, AddressOf Me.nudTarHeightOffset_ValueChanged
            RemoveHandler Me.nudFadeDelay.Validated, AddressOf Me.nudFadeDelay_ValueChanged
            RemoveHandler Me.nudFadeLength.Validated, AddressOf Me.nudFadeLength_ValueChanged
            RemoveHandler Me.nudFadeColorR.Validated, AddressOf Me.nudFadeColorR_ValueChanged
            RemoveHandler Me.nudFadeColorG.Validated, AddressOf Me.nudFadeColorG_ValueChanged
            RemoveHandler Me.nudFadeColorB.Validated, AddressOf Me.nudFadeColorB_ValueChanged
            RemoveHandler Me.nudCameraID.Validated, AddressOf Me.nudCameraID_ValueChanged
            RemoveHandler Me.tbQuest.TextChanged, AddressOf Me.tbQuest_TextChanged
            RemoveHandler Me.nudQuestEntry.Validated, AddressOf Me.nudQuestEntry_ValueChanged
            RemoveHandler Me.cmbxFadeType.SelectedIndexChanged, AddressOf Me.cmbxFadeType_SelectedIndexChanged
            RemoveHandler Me.nudCamFieldOfView.ValueChanged, AddressOf Me.nudCamFieldOfView_ValueChanged
            RemoveHandler Me.nudCamFieldOfView.Validated, AddressOf Me.nudCamFieldOfView_ValueChanged
        End Sub

        ' Token: 0x06000423 RID: 1059 RVA: 0x00239C98 File Offset: 0x00238C98
        Private Sub tbConversationText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.InternalText = Me.tbConversationText.Text
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
            dlgconvListNode.UpdateLinkedNodesText()
        End Sub

        ' Token: 0x06000424 RID: 1060 RVA: 0x00239CDC File Offset: 0x00238CDC
        Private Sub tbTextActiveScript_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.ActiveScript = Me.tbTextActiveScript.Text.Trim()
        End Sub

        ' Token: 0x06000425 RID: 1061 RVA: 0x00239D10 File Offset: 0x00238D10
        Private Sub tbActionsTakenScript_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Script = Me.tbActionsTakenScript.Text.Trim()
        End Sub

        ' Token: 0x06000426 RID: 1062 RVA: 0x00239D44 File Offset: 0x00238D44
        Private Sub nudPlotIndex_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.PlotIndex = IntegerType.FromString(Me.nudPlotIndex.Text.Trim())
        End Sub

        ' Token: 0x06000427 RID: 1063 RVA: 0x00239D80 File Offset: 0x00238D80
        Private Sub nudPlotXPPercentage_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.PlotXPPercentage = Me.nudPlotXPPercentage.Value
        End Sub

        ' Token: 0x06000428 RID: 1064 RVA: 0x00239DB0 File Offset: 0x00238DB0
        Private Sub tbComments_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Comment = Me.tbComments.Text.Trim()
        End Sub

        ' Token: 0x06000429 RID: 1065 RVA: 0x00239DE4 File Offset: 0x00238DE4
        Private Sub nudCameraAngle_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CameraAngle = Convert.ToInt32(Me.nudCameraAngle.Value)
            If dlgconvListNode.CameraAngle = 6 Then
                Me.cmbxCamVidEffect.Enabled = True
                Select Case dlgconvListNode.CamVidEffect
                    Case -1
                        Me.cmbxCamVidEffect.SelectedIndex = 0
                        Return
                    Case 0
                        Me.cmbxCamVidEffect.SelectedIndex = 1
                        Return
                    Case 2
                        Me.cmbxCamVidEffect.SelectedIndex = 2
                        Return
                End Select
                Me.cmbxCamVidEffect.SelectedIndex = 0
            Else
                Me.cmbxCamVidEffect.Enabled = False
                Me.cmbxCamVidEffect.SelectedIndex = 0
            End If
        End Sub

        ' Token: 0x0600042A RID: 1066 RVA: 0x00239E9C File Offset: 0x00238E9C
        Private Sub nudCamHeightOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CamHeightOffset = Me.nudCamHeightOffset.Value
        End Sub

        ' Token: 0x0600042B RID: 1067 RVA: 0x00239ECC File Offset: 0x00238ECC
        Private Sub nudTarHeightOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CamHeightOffset = Me.nudTarHeightOffset.Value
        End Sub

        ' Token: 0x0600042C RID: 1068 RVA: 0x00239EFC File Offset: 0x00238EFC
        Private Sub tbListener_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Listener = Me.tbListener.Text.Trim()
        End Sub

        ' Token: 0x0600042D RID: 1069 RVA: 0x00239F30 File Offset: 0x00238F30
        Private Sub nudFadeDelay_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.FadeDelay = Me.nudFadeDelay.Value
        End Sub

        ' Token: 0x0600042E RID: 1070 RVA: 0x00239F60 File Offset: 0x00238F60
        Private Sub nudFadeLength_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.FadeLength = Me.nudFadeLength.Value
        End Sub

        ' Token: 0x0600042F RID: 1071 RVA: 0x00239F90 File Offset: 0x00238F90
        Private Sub nudFadeColorR_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            If dlgconvListNode.FadeColor Is Nothing Then
                dlgconvListNode.FadeColor = New GFFType17()
            End If
            dlgconvListNode.FadeColor.f1 = Convert.ToSingle(Me.nudFadeColorR.Value)
            dlgconvListNode.FadeColor.f2 = Convert.ToSingle(Me.nudFadeColorG.Value)
            dlgconvListNode.FadeColor.f3 = Convert.ToSingle(Me.nudFadeColorB.Value)
        End Sub

        ' Token: 0x06000430 RID: 1072 RVA: 0x0023A014 File Offset: 0x00239014
        Private Sub nudFadeColorG_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            If dlgconvListNode.FadeColor Is Nothing Then
                dlgconvListNode.FadeColor = New GFFType17()
            End If
            dlgconvListNode.FadeColor.f1 = Convert.ToSingle(Me.nudFadeColorR.Value)
            dlgconvListNode.FadeColor.f2 = Convert.ToSingle(Me.nudFadeColorG.Value)
            dlgconvListNode.FadeColor.f3 = Convert.ToSingle(Me.nudFadeColorB.Value)
        End Sub

        ' Token: 0x06000431 RID: 1073 RVA: 0x0023A098 File Offset: 0x00239098
        Private Sub nudFadeColorB_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            If dlgconvListNode.FadeColor Is Nothing Then
                dlgconvListNode.FadeColor = New GFFType17()
            End If
            dlgconvListNode.FadeColor.f1 = Convert.ToSingle(Me.nudFadeColorR.Value)
            dlgconvListNode.FadeColor.f2 = Convert.ToSingle(Me.nudFadeColorG.Value)
            dlgconvListNode.FadeColor.f3 = Convert.ToSingle(Me.nudFadeColorB.Value)
        End Sub

        ' Token: 0x06000432 RID: 1074 RVA: 0x0023A11C File Offset: 0x0023911C
        Private Sub tbSound_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Sound = Me.tbSound.Text.Trim()
        End Sub

        ' Token: 0x06000433 RID: 1075 RVA: 0x0023A150 File Offset: 0x00239150
        Private Sub tbSpeaker_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Speaker = Me.tbSpeaker.Text.Trim()
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
        End Sub

        ' Token: 0x06000434 RID: 1076 RVA: 0x0023A190 File Offset: 0x00239190
        Private Sub tbVoiceOverResRef_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.VO_ResRef = Me.tbVoiceOverResRef.Text.Trim()
        End Sub

        ' Token: 0x06000435 RID: 1077 RVA: 0x0023A1C4 File Offset: 0x002391C4
        Private Sub nudCameraID_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CameraID = Convert.ToInt32(Me.nudCameraID.Value)
        End Sub

        ' Token: 0x06000436 RID: 1078 RVA: 0x0023A1F8 File Offset: 0x002391F8
        Private Sub nudCamFieldOfView_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.CamFieldOfView = Me.nudCamFieldOfView.Value
        End Sub

        ' Token: 0x06000437 RID: 1079 RVA: 0x0023A228 File Offset: 0x00239228
        Private Sub cmbxCamVidEffect_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            Select Case Me.cmbxCamVidEffect.SelectedIndex
                Case 0
                    dlgconvListNode.CamVidEffect = -1
                Case 1
                    dlgconvListNode.CamVidEffect = 0
                Case 2
                    dlgconvListNode.CamVidEffect = 2
            End Select
        End Sub

        ' Token: 0x06000438 RID: 1080 RVA: 0x0023A280 File Offset: 0x00239280
        Private Sub tbQuest_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.Quest = Me.tbQuest.Text.Trim()
            Me.nudQuestEntry.Enabled = StringType.StrCmp(Me.tbQuest.Text.Trim(), "", False) <> 0
        End Sub

        ' Token: 0x06000439 RID: 1081 RVA: 0x0023A2E0 File Offset: 0x002392E0
        Private Sub nudQuestEntry_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.QuestEntry = Convert.ToUInt32(Me.nudQuestEntry.Value)
        End Sub

        ' Token: 0x0600043A RID: 1082 RVA: 0x0023A314 File Offset: 0x00239314
        Private Sub cmbxFadeType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            dlgconvListNode.FadeType = Me.cmbxFadeType.SelectedIndex
            Dim flag As Boolean = Me.cmbxFadeType.SelectedIndex > 0
            Me.nudFadeDelay.Enabled = flag
            Me.nudFadeLength.Enabled = flag
            Me.nudFadeColorR.Enabled = flag
            Me.nudFadeColorG.Enabled = flag
            Me.nudFadeColorB.Enabled = flag
        End Sub

        ' Token: 0x0600043B RID: 1083 RVA: 0x0023A390 File Offset: 0x00239390
        Private Sub tvConversation_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tvConversation.MouseDown
            Dim point As Point = New Point(e.X, e.Y)
            Dim point2 As Point = point
            Me.LastClickedTvConversationNode = CType(Me.tvConversation.GetNodeAt(point2), DLGConvListNode)
        End Sub

        ' Token: 0x0600043C RID: 1084 RVA: 0x0023A3CC File Offset: 0x002393CC
        Private Sub tvConversation_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tvConversation.MouseUp
            Dim point As Point = New Point(e.X, e.Y)
            Dim point2 As Point = point
            Dim lastClickedTvConversationNode As DLGConvListNode = Me.LastClickedTvConversationNode
            If lastClickedTvConversationNode IsNot Nothing Then
                Me.CurrentContextMenuTvConversationNode = lastClickedTvConversationNode
            End If
            If e.Button = MouseButtons.Right Then
                If lastClickedTvConversationNode IsNot Nothing Then
                    Me.AdjustContextMenuItems()
                    Me.cmTVfunctions.Show(Me.tvConversation, point2)
                    Me.tvConversation.SelectedNode = Me.CurrentContextMenuTvConversationNode
                End If
            ElseIf e.Button = MouseButtons.Left AndAlso lastClickedTvConversationNode IsNot Nothing AndAlso e.X < lastClickedTvConversationNode.Bounds.Left Then
                Return
            End If
        End Sub

        ' Token: 0x0600043D RID: 1085 RVA: 0x0023A464 File Offset: 0x00239464
        Private Sub tvConversation_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles tvConversation.AfterSelect
            Dim dlgconvListNode As DLGConvListNode = CType(CType(sender, TreeView).SelectedNode, DLGConvListNode)
            Me.AdjustTabPagesEnabledState(dlgconvListNode)
            If dlgconvListNode Is Me.tvConversation.Nodes(0) Then
                Return
            End If
            Me.tbLinkID.Text = StringType.FromInteger(dlgconvListNode.LinkID)
            If dlgconvListNode.LinkedNodesList Is Nothing Then
                Me.tbLinkedCnt.Text = "(empty)"
            Else
                Me.tbLinkedCnt.Text = StringType.FromInteger(dlgconvListNode.LinkedNodesList.Count)
            End If
            If dlgconvListNode.LinkedToNode Is Nothing Then
                Me.tbSharedCnt.Text = "(none)"
            Else
                Me.tbSharedCnt.Text = StringType.FromInteger(dlgconvListNode.LinkedToNode.LinkedNodesList.Count)
            End If
            Me.tbLinkDesc.Text = dlgconvListNode.LinkDesc
            Me.DisconnectEventHandlers()
            Me.tbConversationText.Text = dlgconvListNode.InternalText
            Me.tbTextActiveScript.Text = dlgconvListNode.ActiveScript
            Me.tbSound.Text = dlgconvListNode.Sound
            Me.tbComments.Text = dlgconvListNode.Comment
            Me.tbSound.Text = dlgconvListNode.Sound
            Me.tbActionsTakenScript.Text = dlgconvListNode.Script
            Me.tbSpeaker.Text = dlgconvListNode.Speaker
            Me.nudCameraAngle.Value = New Decimal(dlgconvListNode.CameraAngle)
            If dlgconvListNode.CameraAngle = 6 Then
                Me.cmbxCamVidEffect.Enabled = True
                Select Case dlgconvListNode.CamVidEffect
                    Case -1
                        Me.cmbxCamVidEffect.SelectedIndex = 0
                        GoTo IL_01DA
                    Case 0
                        Me.cmbxCamVidEffect.SelectedIndex = 1
                        GoTo IL_01DA
                    Case 2
                        Me.cmbxCamVidEffect.SelectedIndex = 2
                        GoTo IL_01DA
                End Select
                Me.cmbxCamVidEffect.SelectedIndex = 0
            Else
                Me.cmbxCamVidEffect.Enabled = False
                Me.cmbxCamVidEffect.SelectedIndex = 0
            End If
IL_01DA:
            Me.nudCameraID.Value = New Decimal(dlgconvListNode.CameraID)
            Me.cmbxFadeType.SelectedIndex = dlgconvListNode.FadeType
            Dim flag As Boolean = Me.cmbxFadeType.SelectedIndex > 0
            Me.nudFadeDelay.Enabled = flag
            Me.nudFadeLength.Enabled = flag
            Me.nudFadeColorR.Enabled = flag
            Me.nudFadeColorG.Enabled = flag
            Me.nudFadeColorB.Enabled = flag
            Me.tbListener.Text = dlgconvListNode.Listener
            Me.nudPlotIndex.Value = New Decimal(dlgconvListNode.PlotIndex)
            Me.nudPlotXPPercentage.Value = dlgconvListNode.PlotXPPercentage
            Me.tbVoiceOverResRef.Text = dlgconvListNode.VO_ResRef
            Me.nudCamHeightOffset.Value = dlgconvListNode.CamHeightOffset
            Me.nudTarHeightOffset.Value = dlgconvListNode.TarHeightOffset
            Me.nudFadeDelay.Value = dlgconvListNode.FadeDelay
            Me.nudFadeLength.Value = dlgconvListNode.FadeLength
            If dlgconvListNode.FadeColor IsNot Nothing Then
                Me.nudFadeColorR.Text = StringType.FromByte(Convert.ToByte(dlgconvListNode.FadeColor.f1))
                Me.nudFadeColorG.Text = StringType.FromByte(Convert.ToByte(dlgconvListNode.FadeColor.f2))
                Me.nudFadeColorB.Text = StringType.FromByte(Convert.ToByte(dlgconvListNode.FadeColor.f3))
            Else
                Me.nudFadeColorR.Text = ""
                Me.nudFadeColorG.Text = ""
                Me.nudFadeColorB.Text = ""
            End If
            Me.dgAnimList.SetDataBinding(dlgconvListNode.Animlist, Nothing)
            Me.dgAnimList.DataSource = dlgconvListNode.Animlist
            If StringType.StrCmp(dlgconvListNode.Quest, Nothing, False) = 0 Then
                Me.tbQuest.Text = ""
                Me.nudQuestEntry.Value = 0D
                Me.nudQuestEntry.Enabled = False
            Else
                Me.tbQuest.Text = dlgconvListNode.Quest
                Me.nudQuestEntry.Value = Convert.ToDecimal(dlgconvListNode.QuestEntry)
                Me.nudQuestEntry.Enabled = True
            End If
            If Me.chkbAnimatedCut.Checked Then
                Me.nudCamFieldOfView.Value = dlgconvListNode.CamFieldOfView
            End If
            Me.WireUpEventHandlers()
        End Sub

        ' Token: 0x0600043E RID: 1086 RVA: 0x0023A89C File Offset: 0x0023989C
        Private Sub cmiTV_Add_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTV_Add.Click
            If Me.LastClickedTvConversationNode.IsLink > 0 Then
                Return
            End If
            Dim dlgconvListNode As DLGConvListNode = New DLGConvListNode()
            Dim frmPromptForString As frmPromptForString = New frmPromptForString()
            frmPromptForString.tbValue.Multiline = True
            frmPromptForString.tbValue.AcceptsReturn = False
            frmPromptForString.tbValue.AcceptsTab = False
            Dim form As Form = frmPromptForString
            Dim size As Size = New Size(300, 272)
            form.Size = size
            Dim tbValue As Control = frmPromptForString.tbValue
            size = New Size(232, 96)
            tbValue.Size = size
            If Me.LastClickedTvConversationNode.IsReply Then
                frmPromptForString.lblMsg.Text = "Enter what the NPC says:"
            Else
                frmPromptForString.lblMsg.Text = "Enter what the PC says:"
            End If
            If frmPromptForString.ShowDialog(Me) = DialogResult.OK Then
                dlgconvListNode.InternalText = frmPromptForString.tbValue.Text.Trim()
                If Me.LastClickedTvConversationNode.IsReply Then
                    dlgconvListNode.IsEntry = True
                Else
                    dlgconvListNode.IsReply = True
                    dlgconvListNode.Speaker = ""
                End If
                dlgconvListNode.Text = dlgconvListNode.NodeDesc
                dlgconvListNode.ForeColor = dlgconvListNode.DialogColor
                Me.LastClickedTvConversationNode.Nodes.Add(dlgconvListNode)
                If Me.LastClickedTvConversationNode IsNot Me.tvConversation.Nodes(0) Then
                    Me.LastClickedTvConversationNode.Text = Me.LastClickedTvConversationNode.NodeDesc
                End If
                dlgconvListNode.EnsureVisible()
                Me.tvConversation.SelectedNode = dlgconvListNode
            End If
        End Sub

        ' Token: 0x0600043F RID: 1087 RVA: 0x0023AA04 File Offset: 0x00239A04
        Private Sub cmiTV_Copy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTV_Copy.Click
            Me.ClipBoardNode = Me.CurrentContextMenuTvConversationNode
        End Sub

        ' Token: 0x06000440 RID: 1088 RVA: 0x0023AA14 File Offset: 0x00239A14
        Private Sub cmiTV_Paste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTV_Paste.Click
            Dim dlgconvListNode As DLGConvListNode = Me.ClipBoardNode.Copy()
            If Me.LastClickedTvConversationNode.IsReply Then
                dlgconvListNode.IsEntry = True
            Else
                dlgconvListNode.IsReply = True
                dlgconvListNode.Speaker = ""
            End If
            dlgconvListNode.ForeColor = dlgconvListNode.DialogColor
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
            dlgconvListNode.LinkedNodesList = Nothing
            If dlgconvListNode.IsLink > 0 Then
                If Me.ClipBoardNode.LinkedToNode.LinkedNodesList Is Nothing Then
                    Me.ClipBoardNode.LinkedToNode.LinkedNodesList = New ArrayList()
                End If
                Me.ClipBoardNode.LinkedToNode.LinkedNodesList.Add(dlgconvListNode)
            End If
            Me.LastClickedTvConversationNode.Nodes.Add(dlgconvListNode)
            Me.LastClickedTvConversationNode.Text = Me.LastClickedTvConversationNode.NodeDesc
            dlgconvListNode.EnsureVisible()
        End Sub

        ' Token: 0x06000441 RID: 1089 RVA: 0x0023AAEC File Offset: 0x00239AEC
        Private Sub cmiTV_PasteTree_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTV_PasteTree.Click
            Dim clipBoardNode As DLGConvListNode = Me.ClipBoardNode
            If Me.LastClickedTvConversationNode.IsReply Then
                clipBoardNode.IsEntry = True
            Else
                clipBoardNode.IsReply = True
                clipBoardNode.Speaker = ""
            End If
            clipBoardNode.ForeColor = clipBoardNode.DialogColor
            clipBoardNode.Text = clipBoardNode.NodeDesc
            clipBoardNode.LinkedNodesList = Nothing
            If clipBoardNode.IsLink > 0 Then
                If Me.ClipBoardNode.LinkedToNode.LinkedNodesList Is Nothing Then
                    Me.ClipBoardNode.LinkedToNode.LinkedNodesList = New ArrayList()
                End If
                Me.ClipBoardNode.LinkedToNode.LinkedNodesList.Add(clipBoardNode)
            End If
            Me.LastClickedTvConversationNode.Nodes.Add(clipBoardNode)
            Me.LastClickedTvConversationNode.Text = Me.LastClickedTvConversationNode.NodeDesc
            clipBoardNode.EnsureVisible()
            Me.ClipBoardNode = Nothing
            Me.ResetChildNodesDescAfterPasteTree(Me.LastClickedTvConversationNode)
        End Sub

        ' Token: 0x06000442 RID: 1090 RVA: 0x0023ABD4 File Offset: 0x00239BD4
        Private Sub cmiTV_PasteAsLink_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTV_PasteAsLink.Click
            Dim dlgconvListNode As DLGConvListNode = Me.ClipBoardNode.Copy()
            dlgconvListNode.IsLink = Byte.MaxValue
            dlgconvListNode.LinkedNodesList = Nothing
            dlgconvListNode.LinkedToNode = Me.ClipBoardNode
            If Me.ClipBoardNode.LinkedNodesList Is Nothing Then
                Me.ClipBoardNode.LinkedNodesList = New ArrayList()
            End If
            Me.ClipBoardNode.LinkedNodesList.Add(dlgconvListNode)
            dlgconvListNode.ForeColor = dlgconvListNode.DialogColor
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
            Me.LastClickedTvConversationNode.Nodes.Add(dlgconvListNode)
            Me.LastClickedTvConversationNode.Text = Me.LastClickedTvConversationNode.NodeDesc
            Me.LastClickedTvConversationNode.ForeColor = Me.LastClickedTvConversationNode.DialogColor
            dlgconvListNode.EnsureVisible()
        End Sub

        ' Token: 0x06000443 RID: 1091 RVA: 0x0023AC98 File Offset: 0x00239C98
        Private Sub cmiTV_Cut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTV_Cut.Click
            Me.ClipBoardNode = Me.CurrentContextMenuTvConversationNode
            Me.RemoveChildLinks(Me.ClipBoardNode)
            Dim dlgconvListNode As DLGConvListNode = CType(Me.ClipBoardNode.Parent, DLGConvListNode)
            Me.ClipBoardNode.Parent.Nodes.Remove(Me.ClipBoardNode)
            dlgconvListNode.Text = dlgconvListNode.NodeDesc
        End Sub

        ' Token: 0x06000444 RID: 1092 RVA: 0x0023ACF8 File Offset: 0x00239CF8
        Private Sub AdjustContextMenuItems()
            Me.cmiTV_Add.Enabled = Not Me.LastClickedTvConversationNode.IsLink > 0
            Me.cmiTV_Copy.Enabled = Me.LastClickedTvConversationNode IsNot Me.tvConversation.Nodes(0)
            Me.cmiTV_Cut.Enabled = Me.LastClickedTvConversationNode IsNot Me.tvConversation.Nodes(0)
            Me.cmiTV_Paste.Enabled = Me.ClipBoardNode IsNot Nothing AndAlso Not Me.LastClickedTvConversationNode.IsLink > 0
            Me.cmiTV_PasteTree.Enabled = Me.ClipBoardNode IsNot Nothing AndAlso Not Me.LastClickedTvConversationNode.IsLink > 0
            Me.cmiTV_PasteAsLink.Enabled = Me.ClipBoardNode IsNot Nothing AndAlso Not Me.ClipBoardNode.IsLink > 0 AndAlso Not Me.LastClickedTvConversationNode.IsLink > 0 AndAlso Me.LastClickedTvConversationNode.IsReply
            If Me.LastClickedTvConversationNode Is Me.tvConversation.Nodes(0) Then
                Me.cmiTV_MoveNodeUp.Enabled = False
                Me.cmiTV_MoveNodeDown.Enabled = False
            Else
                Dim dlgconvListNode As DLGConvListNode = CType(Me.LastClickedTvConversationNode.Parent, DLGConvListNode)
                Me.cmiTV_MoveNodeUp.Enabled = dlgconvListNode.Nodes.IndexOf(Me.LastClickedTvConversationNode) > 0
                Me.cmiTV_MoveNodeDown.Enabled = dlgconvListNode.Nodes.IndexOf(Me.LastClickedTvConversationNode) < dlgconvListNode.Nodes.Count - 1
            End If
        End Sub

        ' Token: 0x06000445 RID: 1093 RVA: 0x0023AE98 File Offset: 0x00239E98
        Private Sub AdjustTabPagesEnabledState(ByVal node As DLGConvListNode)
            If (If((-If(((node Is Me.tvConversation.Nodes(0)) > False), 1S, 0S)), 1S, 0S) Or CShort(node.IsLink)) <> 0S Then
                Me.tabpagActionsTaken.Enabled = False
                Me.tabpagAnimationSound.Enabled = False
                Me.tabpagCamera.Enabled = False
                Me.tabpagComment.Enabled = False
                Me.tabpagPlot.Enabled = False
            Else
                Me.tabpagActionsTaken.Enabled = True
                Me.tabpagAnimationSound.Enabled = True
                Me.tabpagCamera.Enabled = True
                Me.tabpagComment.Enabled = True
                Me.tabpagPlot.Enabled = True
            End If
        End Sub

        ' Token: 0x06000446 RID: 1094 RVA: 0x0023AF44 File Offset: 0x00239F44
        Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
            Me.OpenFile()
        End Sub

        ' Token: 0x06000447 RID: 1095 RVA: 0x0023AF4C File Offset: 0x00239F4C
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
            Me.SaveFile()
        End Sub

        ' Token: 0x06000448 RID: 1096 RVA: 0x0023AF54 File Offset: 0x00239F54
        Private Sub OpenFile()
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultImportLocation, "", "Open DLG files...", "dlg", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim gfffileKotorVersionIndex As Integer = frmMain.GetGFFFileKotorVersionIndex(text)
            Dim fileStream As FileStream = New FileStream(text, FileMode.Open, FileAccess.Read)
            Me.SetupForNewDialog()
            Me.tvConversation.Nodes.Clear()
            Dim fileStream2 As FileStream = fileStream
            Dim tvConversation As TreeView = Me.tvConversation
            Dim clsDLG As clsDLG = New clsDLG(fileStream2, tvConversation, gfffileKotorVersionIndex)
            Me.tvConversation = tvConversation
            Me.clsdlg = clsDLG
            Me.filename = Path.GetFileNameWithoutExtension(fileStream.Name)
            Me.gff = Me.clsdlg.dlgGff
            Me.SetFormToDLGRootItems()
            Me.Text = "Conversation Editor - " + Me.filename + ".dlg"
        End Sub

        ' Token: 0x06000449 RID: 1097 RVA: 0x0023B024 File Offset: 0x0023A024
        Private Sub miNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miNew.Click
            Me.SetupForNewDialog()
        End Sub

        ' Token: 0x0600044A RID: 1098 RVA: 0x0023B02C File Offset: 0x0023A02C
        Private Sub miOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpen.Click
            Me.OpenFile()
        End Sub

        ' Token: 0x0600044B RID: 1099 RVA: 0x0023B034 File Offset: 0x0023A034
        Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miSave.Click
            Me.SaveFile()
        End Sub

        ' Token: 0x0600044C RID: 1100 RVA: 0x0023B03C File Offset: 0x0023A03C
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miQuit.Click
            Me.Close()
        End Sub

        ' Token: 0x0600044D RID: 1101 RVA: 0x0023B044 File Offset: 0x0023A044
        Private Sub btnAddAnimListEntry_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAnimListEntry.Click
            If Me.LastClickedTvConversationNode.Animlist Is Nothing Then
                Me.LastClickedTvConversationNode.Animlist = New ArrayList(1)
            End If
            Dim frmCreateAnimListEntry As frmCreateAnimListEntry = New frmCreateAnimListEntry()
            If frmCreateAnimListEntry.ShowDialog(Me) = DialogResult.OK Then
                Me.LastClickedTvConversationNode.Animlist.Add(New AnimListEntry(frmCreateAnimListEntry.Participant, frmCreateAnimListEntry.AnimationNumber))
                Me.dgAnimList.SetDataBinding(Me.LastClickedTvConversationNode.Animlist, Nothing)
                Dim currencyManager As CurrencyManager = CType(Me.dgAnimList.BindingContext(RuntimeHelpers.GetObjectValue(Me.dgAnimList.DataSource)), CurrencyManager)
                If currencyManager IsNot Nothing Then
                    currencyManager.Refresh()
                End If
                Me.dgAnimList.Refresh()
            End If
        End Sub

        ' Token: 0x0600044E RID: 1102 RVA: 0x0023B0F4 File Offset: 0x0023A0F4
        Private Sub btnDeleteAnimListEntry_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteAnimListEntry.Click
            Dim currencyManager As CurrencyManager = CType(Me.dgAnimList.BindingContext(RuntimeHelpers.GetObjectValue(Me.dgAnimList.DataSource)), CurrencyManager)
            Dim position As Integer = currencyManager.Position
            Me.LastClickedTvConversationNode.Animlist.RemoveAt(position)
            If currencyManager IsNot Nothing Then
                currencyManager.Refresh()
            End If
            Me.btnDeleteAnimListEntry.Enabled = False
        End Sub

        ' Token: 0x0600044F RID: 1103 RVA: 0x0023B154 File Offset: 0x0023A154
        Private Sub dgAnimList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles dgAnimList.Click
            Dim dataGrid As DataGrid = CType(sender, DataGrid)
            Dim hitTestInfo As DataGrid.HitTestInfo = dataGrid.HitTest(dataGrid.PointToClient(Control.MousePosition).X, dataGrid.PointToClient(Control.MousePosition).Y)
            If (hitTestInfo.Type = dataGrid.HitTestType.RowHeader) Or (hitTestInfo.Type = dataGrid.HitTestType.Cell) Then
                Me.dgAnimList.[Select](hitTestInfo.Row)
                Me.btnDeleteAnimListEntry.Enabled = True
            End If
        End Sub

        ' Token: 0x06000450 RID: 1104 RVA: 0x0023B1C8 File Offset: 0x0023A1C8
        Private Sub dgAnimList_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles dgAnimList.Validated
            Me.btnDeleteAnimListEntry.Enabled = False
        End Sub

        ' Token: 0x06000451 RID: 1105 RVA: 0x0023B1D8 File Offset: 0x0023A1D8
        Private Sub trkbTVIndent_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trkbTVIndent.Scroll
            Me.tvConversation.Indent = Me.trkbTVIndent.Value
        End Sub

        ' Token: 0x06000452 RID: 1106 RVA: 0x0023B1F0 File Offset: 0x0023A1F0
        Private Sub trkbTVItemHeight_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trkbTVItemHeight.Scroll
            ' The following expression was wrapped in a checked-expression
            Me.tvConversation.ItemHeight = Me.trkbTVItemHeight.Value * 2
        End Sub

        ' Token: 0x06000453 RID: 1107 RVA: 0x0023B20C File Offset: 0x0023A20C
        Private Sub cmbxConversationType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxConversationType.SelectedIndexChanged
            Me.cmbxComputerType.Enabled = Me.cmbxConversationType.SelectedIndex = 1
        End Sub

        ' Token: 0x06000454 RID: 1108 RVA: 0x0023B228 File Offset: 0x0023A228
        Private Sub btnShowLists_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowLists.Click
            Console.WriteLine("-----------------------------------------")
            Console.WriteLine("Entries")
            Console.WriteLine("-----------------------------------------")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.gff.GetListItemCount("EntryList") - 1
            For i As Integer = num To num2
                Console.Write("Entry " + StringType.FromInteger(i) + ": ")
                If Me.gff.GetListItemCount("EntryList(" + StringType.FromInteger(i) + ").RepliesList") > 0 Then
                    Dim num3 As Integer = 0
                    Dim num4 As Integer = Me.gff.GetListItemCount("EntryList(" + StringType.FromInteger(i) + ").RepliesList") - 1
                    For j As Integer = num3 To num4
                        Console.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.gff.GetNodeValue(String.Concat(New String() {"EntryList(", StringType.FromInteger(i), ").RepliesList(", StringType.FromInteger(j), ").Index"})))))
                        If ObjectType.ObjTst(Me.gff.GetNodeValue(String.Concat(New String() {"EntryList(", StringType.FromInteger(i), ").RepliesList(", StringType.FromInteger(j), ").IsChild"})), 0, False) > 0 Then
                            Console.Write(" (L), ")
                        Else
                            Console.Write(", ")
                        End If
                    Next
                End If
                Console.WriteLine()
            Next
            Console.WriteLine("-----------------------------------------")
            Console.WriteLine("Replies")
            Console.WriteLine("-----------------------------------------")
            Dim num5 As Integer = 0
            Dim num6 As Integer = Me.gff.GetListItemCount("ReplyList") - 1
            For i As Integer = num5 To num6
                Console.Write("Entry " + StringType.FromInteger(i) + ": ")
                If Me.gff.GetListItemCount("ReplyList(" + StringType.FromInteger(i) + ").EntriesList") > 0 Then
                    Dim num7 As Integer = 0
                    Dim num8 As Integer = Me.gff.GetListItemCount("ReplyList(" + StringType.FromInteger(i) + ").EntriesList") - 1
                    For j As Integer = num7 To num8
                        Console.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.gff.GetNodeValue(String.Concat(New String() {"ReplyList(", StringType.FromInteger(i), ").EntriesList(", StringType.FromInteger(j), ").Index"})))))
                        If ObjectType.ObjTst(Me.gff.GetNodeValue(String.Concat(New String() {"ReplyList(", StringType.FromInteger(i), ").EntriesList(", StringType.FromInteger(j), ").IsChild"})), 0, False) > 0 Then
                            Console.Write(" (L), ")
                        Else
                            Console.Write(", ")
                        End If
                    Next
                End If
                Console.WriteLine()
            Next
            Console.WriteLine("-----------------------------------------")
        End Sub

        ' Token: 0x06000455 RID: 1109 RVA: 0x0023B54C File Offset: 0x0023A54C
        Private Sub chkbAnimatedCut_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkbAnimatedCut.CheckedChanged
            Me.tbCameraModel.Enabled = CType(sender, CheckBox).Checked
            Me.nudCamFieldOfView.Enabled = CType(sender, CheckBox).Checked
        End Sub

        ' Token: 0x06000456 RID: 1110 RVA: 0x0023B57C File Offset: 0x0023A57C
        Private Sub cmiTV_MoveNodeUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTV_MoveNodeUp.Click
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            Dim dlgconvListNode2 As DLGConvListNode = CType(dlgconvListNode.Parent, DLGConvListNode)
            Dim num As Integer = dlgconvListNode2.Nodes.IndexOf(dlgconvListNode)
            dlgconvListNode2.Nodes.Remove(dlgconvListNode)
            dlgconvListNode2.Nodes.Insert(num - 1, dlgconvListNode)
            Me.tvConversation.SelectedNode = dlgconvListNode
        End Sub

        ' Token: 0x06000457 RID: 1111 RVA: 0x0023B5DC File Offset: 0x0023A5DC
        Private Sub cmiTV_MoveNodeDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTV_MoveNodeDown.Click
            Dim dlgconvListNode As DLGConvListNode = CType(Me.tvConversation.SelectedNode, DLGConvListNode)
            Dim dlgconvListNode2 As DLGConvListNode = CType(dlgconvListNode.Parent, DLGConvListNode)
            Dim num As Integer = dlgconvListNode2.Nodes.IndexOf(dlgconvListNode)
            dlgconvListNode2.Nodes.Remove(dlgconvListNode)
            If num = dlgconvListNode2.Nodes.Count - 1 Then
                dlgconvListNode2.Nodes.Add(dlgconvListNode)
            Else
                dlgconvListNode2.Nodes.Insert(num + 1, dlgconvListNode)
            End If
            Me.tvConversation.SelectedNode = dlgconvListNode
        End Sub

        ' Token: 0x0400025F RID: 607
        Private clsdlg As clsDLG

        ' Token: 0x04000260 RID: 608
        Private EntryIndex As Integer

        ' Token: 0x04000261 RID: 609
        Private ReplyIndex As Integer

        ' Token: 0x04000262 RID: 610
        Private EntryList As ArrayList

        ' Token: 0x04000263 RID: 611
        Private ReplyList As ArrayList

        ' Token: 0x04000264 RID: 612
        Private gff As clsGFF

        ' Token: 0x04000265 RID: 613
        Private struct As GFF_Struct

        ' Token: 0x04000266 RID: 614
        Private LastClickedTvConversationNode As DLGConvListNode

        ' Token: 0x04000267 RID: 615
        Private CurrentContextMenuTvConversationNode As DLGConvListNode

        ' Token: 0x04000268 RID: 616
        Private ClipBoardNode As DLGConvListNode

        ' Token: 0x04000269 RID: 617
        Private filename As String

        ' Token: 0x0400026A RID: 618
        Private dtStunt As DataTable

        ' Token: 0x0400026B RID: 619
        Private DViewStunt As DataView

        ' Token: 0x0400026C RID: 620
        Private dtAnim As DataTable

        ' Token: 0x0400026D RID: 621
        Private DViewAnim As DataView
    End Class
End Namespace
