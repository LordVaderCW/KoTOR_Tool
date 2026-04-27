Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000048 RID: 72
	Public Partial Class frmDialogTlk
		Inherits frmParent

		' Token: 0x06000458 RID: 1112 RVA: 0x0023B65C File Offset: 0x0023A65C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmDialogTlk_Load
			Me.dt = New DataTable()
			Me.g_currentRow = -1
			Me.g_useApplyBtn = True
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06000483 RID: 1155 RVA: 0x0023C5AC File Offset: 0x0023B5AC
        Public Sub New(ByVal inputpath As String)
            Me.New()
            Me.g_currentFilePath = inputpath
            Me.g_dialogtlk = New clsDialogTlk(Me.g_currentFilePath, True)
        End Sub

        ' Token: 0x06000484 RID: 1156 RVA: 0x0023C5D0 File Offset: 0x0023B5D0
        Private Sub BuildDataTable()
            Dim dataColumn As DataColumn = New DataColumn("index", GetType(Integer))
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Text", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
            dataColumn = New DataColumn("SoundRef", GetType(String))
            dataColumn.DefaultValue = ""
            Me.dt.Columns.Add(dataColumn)
        End Sub

        ' Token: 0x06000485 RID: 1157 RVA: 0x0023C668 File Offset: 0x0023B668
        Private Sub BuildDataGrid()
            Me.Panel1.SuspendLayout()
            If Me.Panel1.Controls.Contains(Me.dgDialogTlk) Then
                Me.Panel1.Controls.Remove(Me.dgDialogTlk)
            End If
            Me.dgDialogTlk = New DataGrid()
            Me.dgDialogTlk.CaptionFont = New Font("Lucida Console", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.dgDialogTlk.DataMember = ""
            Me.dgDialogTlk.Dock = DockStyle.Fill
            Me.dgDialogTlk.HeaderForeColor = SystemColors.ControlText
            Dim dgDialogTlk As Control = Me.dgDialogTlk
            Dim point As Point = New Point(0, 0)
            dgDialogTlk.Location = point
            Me.dgDialogTlk.Name = "dgDialogTlk"
            Me.dgDialogTlk.Size = Me.Panel1.Size
            Me.dgDialogTlk.TabIndex = 0
            Me.Panel1.Controls.Add(Me.dgDialogTlk)
            Me.Panel1.ResumeLayout(False)
            Me.DView = Me.dt.DefaultView
            Me.DView.AllowDelete = True
            Me.DView.AllowNew = True
            Me.DView.AllowEdit = True
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgDialogTlk.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dt.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridEnableTextBoxColumn As DataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
            dataGridEnableTextBoxColumn.MappingName = "index"
            dataGridEnableTextBoxColumn.HeaderText = "(index)"
            dataGridEnableTextBoxColumn.NullText = ""
            dataGridEnableTextBoxColumn.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
            dataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
            dataGridEnableTextBoxColumn.MappingName = "Text"
            dataGridEnableTextBoxColumn.HeaderText = "Text"
            dataGridEnableTextBoxColumn.NullText = ""
            dataGridEnableTextBoxColumn.Width = 350
            dataGridEnableTextBoxColumn.[ReadOnly] = True
            dataGridEnableTextBoxColumn.TextBox.Multiline = True
            dataGridEnableTextBoxColumn.TextBox.WordWrap = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
            dataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
            dataGridEnableTextBoxColumn.MappingName = "SoundRef"
            dataGridEnableTextBoxColumn.HeaderText = "SoundRef"
            dataGridEnableTextBoxColumn.TextBox.CharacterCasing = CharacterCasing.Lower
            dataGridEnableTextBoxColumn.TextBox.MaxLength = 16
            dataGridEnableTextBoxColumn.[ReadOnly] = True
            dataGridEnableTextBoxColumn.Width = 120
            dataGridEnableTextBoxColumn.NullText = ""
            dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
            Me.dgDialogTlk.TableStyles.Add(dataGridTableStyle)
            Me.dgDialogTlk.SetDataBinding(Me.DView, Nothing)
        End Sub

        ' Token: 0x06000486 RID: 1158 RVA: 0x0023C900 File Offset: 0x0023B900
        Private Sub LoadTableAndBuildGrid(ByVal dialogtlk As clsDialogTlk)
            Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
            Me.g_dialogtlk = dialogtlk
            Dim num As Integer = CInt(Math.Round(CDbl(dialogtlk.StringCount) / 10.0))
            If num = 0 Then
                num = 1
            End If
            Me.dgDialogTlk.SetDataBinding(Nothing, Nothing)
            Me.dt.Rows.Clear()
            frmProgressMeter.stepAmount = 10
            frmProgressMeter.message = "Loading"
            frmProgressMeter.Location = New utilWindowRelativePositioner(Me, frmProgressMeter).getConcentric()
            frmProgressMeter.Show()
            Dim num2 As Integer = 0
            Dim num3 As Integer = dialogtlk.StringCount - 1
            For i As Integer = num2 To num3
                Dim dataRow As DataRow = Me.dt.NewRow()
                Dim dialogTlkStrDataElement As DialogTlkStrDataElement = New DialogTlkStrDataElement()
                dialogTlkStrDataElement = dialogtlk.GetStringDataElement(i)
                dataRow(0) = i
                dataRow(1) = dialogTlkStrDataElement.Text
                dataRow(2) = dialogTlkStrDataElement.SoundResRef
                Me.dt.Rows.Add(dataRow)
                If CDbl(i) / CDbl(num) = CDbl((i / num)) Then
                    frmProgressMeter.stepUp()
                    frmProgressMeter.status = "Entry " + StringType.FromInteger(i)
                End If
            Next
            frmProgressMeter.Close()
            Me.BuildDataGrid()
            Me.nudEntryNumber.Maximum = New Decimal(dialogtlk.StringCount - 1)
            Me.nudEntryNumber.Enabled = True
            Me.btnFilter.Enabled = True
            Me.btnGoToEntry.Enabled = True
            Me.miSave.Enabled = True
            Me.miSaveAsXML.Enabled = True
            Me.tbSoundResRef.Enabled = False
            Me.tbSoundResRef.Text = ""
            Me.tbString.Enabled = False
            Me.tbString.Text = ""
        End Sub

        ' Token: 0x06000487 RID: 1159 RVA: 0x0023CAB4 File Offset: 0x0023BAB4
        Protected Sub ApplyFilter()
            If Me.RF IsNot Nothing AndAlso Me.RF.active Then
                Try
                    Me.DView.RowFilter = StringType.FromObject(Me.RF.FilterString())
                    Return
                Catch ex As SyntaxErrorException
                    Dim ex2 As SyntaxErrorException = CType(ex, SyntaxErrorException)
                    Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "Filter Error")
                    Return
                Catch ex3 As EvaluateException
                    Dim ex4 As EvaluateException = CType(ex3, EvaluateException)
                    Interaction.MsgBox(ex4.Message, MsgBoxStyle.Critical, "Filter Error")
                    Return
                End Try
            End If
            Me.DView.RowFilter = ""
        End Sub

        ' Token: 0x06000488 RID: 1160 RVA: 0x0023CB6C File Offset: 0x0023BB6C
        Private Sub frmDialogTlk_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.BuildDataTable()
            Me.miOpenK1.Visible = frmMain.hasKotor1()
            Me.miOpenK2.Visible = frmMain.hasKotor2()
            If Me.g_dialogtlk IsNot Nothing Then
                Me.LoadTableAndBuildGrid(Me.g_dialogtlk)
                Me.dgDialogTlk.CaptionText = Me.g_currentFilePath
            End If
        End Sub

        ' Token: 0x06000489 RID: 1161 RVA: 0x0023CBC4 File Offset: 0x0023BBC4
        Private Sub dgDialogTlk_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentCell As DataGridCell = CType(sender, DataGrid).CurrentCell
            Dim hitTestInfo As DataGrid.HitTestInfo = Me.dgDialogTlk.HitTest(Me.dgDialogTlk.PointToClient(Control.MousePosition))
            If hitTestInfo.Type = DataGrid.HitTestType.RowHeader OrElse hitTestInfo.Type = DataGrid.HitTestType.Cell Then
                Me.tbSoundResRef.Enabled = True
                Me.tbString.Enabled = True
                If hitTestInfo.Row = Me.dt.Rows.Count Then
                    Return
                End If
                Me.g_currentRow = hitTestInfo.Row
                Me.RemoveTextChangeHandlers()
                Me.tbString.Text = Strings.Replace(StringType.FromObject(Me.dgDialogTlk(hitTestInfo.Row, 1)), vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
                Me.tbSoundResRef.Text = StringType.FromObject(Me.dgDialogTlk(hitTestInfo.Row, 2))
                Me.tbString.Focus()
                Me.AddTextChangeHandlers()
            End If
        End Sub

        ' Token: 0x0600048A RID: 1162 RVA: 0x0023CCBC File Offset: 0x0023BCBC
        Private Sub dgDialogTlk_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.RemoveTextChangeHandlers()
            If Me.dgDialogTlk(Me.dgDialogTlk.CurrentCell.RowNumber, 1) IsNot DBNull.Value Then
                Me.tbString.Text = Strings.Replace(StringType.FromObject(Me.dgDialogTlk(Me.dgDialogTlk.CurrentCell.RowNumber, 1)), vbLf, vbCrLf, 1, -1, CompareMethod.Binary)
            End If
            If Me.dgDialogTlk(Me.dgDialogTlk.CurrentCell.RowNumber, 2) IsNot DBNull.Value Then
                Me.tbSoundResRef.Text = StringType.FromObject(Me.dgDialogTlk(Me.dgDialogTlk.CurrentCell.RowNumber, 2))
            End If
            Me.tbString.Focus()
            Me.g_currentRow = Me.dgDialogTlk.CurrentCell.RowNumber
            Me.tbSoundResRef.Enabled = True
            Me.tbString.Enabled = True
            Me.AddTextChangeHandlers()
        End Sub

        ' Token: 0x0600048B RID: 1163 RVA: 0x0023CDD0 File Offset: 0x0023BDD0
        Private Sub tbString_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnApplyChanges.Enabled = True
            If Not Me.g_useApplyBtn AndAlso Me.g_currentRow = Me.dgDialogTlk.CurrentCell.RowNumber Then
                Me.dgDialogTlk(Me.g_currentRow, 1) = Strings.Replace(Me.tbString.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary).Trim()
            End If
        End Sub

        ' Token: 0x0600048C RID: 1164 RVA: 0x0023CE40 File Offset: 0x0023BE40
        Private Sub tbSoundResRef_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnApplyChanges.Enabled = True
            If Not Me.g_useApplyBtn AndAlso Me.g_currentRow = Me.dgDialogTlk.CurrentCell.RowNumber Then
                Me.dgDialogTlk(Me.g_currentRow, 2) = Me.tbSoundResRef.Text.Trim()
            End If
        End Sub

        ' Token: 0x0600048D RID: 1165 RVA: 0x0023CEA0 File Offset: 0x0023BEA0
        Private Sub btnApplyChanges_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' The following expression was wrapped in a checked-statement
            If Me.g_useApplyBtn AndAlso Me.g_currentRow = Me.dgDialogTlk.CurrentCell.RowNumber Then
                Me.dgDialogTlk.TableStyles(0).GridColumnStyles(1).[ReadOnly] = False
                Me.dgDialogTlk.TableStyles(0).GridColumnStyles(2).[ReadOnly] = False
                Me.dgDialogTlk(Me.g_currentRow, 1) = Strings.Replace(Me.tbString.Text, vbCrLf, vbLf, 1, -1, CompareMethod.Binary).Trim()
                Me.dgDialogTlk(Me.g_currentRow, 2) = Me.tbSoundResRef.Text.Trim()
                Me.dgDialogTlk.TableStyles(0).GridColumnStyles(1).[ReadOnly] = True
                Me.dgDialogTlk.TableStyles(0).GridColumnStyles(2).[ReadOnly] = True
                Me.dgDialogTlk.[Select](Me.g_currentRow + 1)
                Me.dgDialogTlk.UnSelect(Me.g_currentRow + 1)
                Me.btnApplyChanges.Enabled = False
            End If
        End Sub

        ' Token: 0x0600048E RID: 1166 RVA: 0x0023CFE8 File Offset: 0x0023BFE8
        Private Sub AddTextChangeHandlers()
            AddHandler Me.tbString.TextChanged, AddressOf Me.tbSoundResRef_TextChanged
            AddHandler Me.tbSoundResRef.TextChanged, AddressOf Me.tbSoundResRef_TextChanged
        End Sub

        ' Token: 0x0600048F RID: 1167 RVA: 0x0023D01C File Offset: 0x0023C01C
        Private Sub RemoveTextChangeHandlers()
            RemoveHandler Me.tbString.TextChanged, AddressOf Me.tbSoundResRef_TextChanged
            RemoveHandler Me.tbSoundResRef.TextChanged, AddressOf Me.tbSoundResRef_TextChanged
        End Sub

        ' Token: 0x06000490 RID: 1168 RVA: 0x0023D050 File Offset: 0x0023C050
        Private Sub btnGoToEntry_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Integer = Convert.ToInt32(Me.nudEntryNumber.Value)
            If num > Me.dt.Rows.Count - 1 Then
                Return
            End If
            Dim dgDialogTlk As DataGrid = Me.dgDialogTlk
            Dim dataGridCell As DataGridCell = New DataGridCell(num, 0)
            dgDialogTlk.CurrentCell = dataGridCell
        End Sub

        ' Token: 0x06000491 RID: 1169 RVA: 0x0023D09C File Offset: 0x0023C09C
        Private Sub btnFilter_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim columnEntryList As ColumnEntryList = New ColumnEntryList()
            Dim columnEntryList2 As ColumnEntryList = New ColumnEntryList()
            columnEntryList2.Add(New ColumnEntry("index", "(index)", GetType(Integer)))
            columnEntryList2.Add(New ColumnEntry("Text", "Text", GetType(String)))
            columnEntryList2.Add(New ColumnEntry("SoundRef", "SoundRef", GetType(String)))
            Dim frmFilterDesigner As frmFilterDesigner
            If Me.RF Is Nothing Then
                frmFilterDesigner = New frmFilterDesigner(columnEntryList2)
            Else
                frmFilterDesigner = New frmFilterDesigner(columnEntryList2, Me.RF)
            End If
            frmFilterDesigner.ShowDialog(Me)
            If frmFilterDesigner.DialogResult = DialogResult.OK Then
                If frmFilterDesigner.DialogResult = DialogResult.OK AndAlso frmFilterDesigner.RF.FilterParts.Count > 0 Then
                    Me.RF = frmFilterDesigner.RF
                    Me.RF.active = True
                ElseIf Me.RF IsNot Nothing Then
                    Me.RF.active = False
                End If
            End If
            Me.ApplyFilter()
        End Sub

        ' Token: 0x06000492 RID: 1170 RVA: 0x0023D194 File Offset: 0x0023C194
        Private Sub nudEntryNumber_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Dim num As Integer = Convert.ToInt32(Me.nudEntryNumber.Value)
            If (num > Me.dt.Rows.Count - 1) Or (num < 0) Then
                Return
            End If
            Dim dgDialogTlk As DataGrid = Me.dgDialogTlk
            Dim dataGridCell As DataGridCell = New DataGridCell(num, 0)
            dgDialogTlk.CurrentCell = dataGridCell
            Me.nudEntryNumber.Focus()
        End Sub

        ' Token: 0x06000493 RID: 1171 RVA: 0x0023D1F0 File Offset: 0x0023C1F0
        Private Sub miOpenExternal_Click(ByVal sender As Object, ByVal e As EventArgs)
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
            If objectValue.[GetType]() IsNot GetType(String) Then
                Return
            End If
            Dim text2 As String = StringType.FromObject(objectValue)
            If Not text2.ToLower().EndsWith(".tlk") AndAlso Interaction.MsgBox("The file you selected does not have a .TLK extension; do you want to open it?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "Questionable file extension") = MsgBoxResult.No Then
                Return
            End If
            Dim clsDialogTlk As clsDialogTlk = New clsDialogTlk(text2, True)
            Me.LoadTableAndBuildGrid(clsDialogTlk)
            Me.dgDialogTlk.CaptionText = text2
        End Sub

        ' Token: 0x06000494 RID: 1172 RVA: 0x0023D2B8 File Offset: 0x0023C2B8
        Private Sub miOpenK1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim clsDialogTlk As clsDialogTlk = New clsDialogTlk(UserSettings.GetSettings().KotorLocation(0) + "\dialog.tlk", True)
            Me.LoadTableAndBuildGrid(clsDialogTlk)
            Me.dgDialogTlk.CaptionText = UserSettings.GetSettings().KotorLocation(0) + "\dialog.tlk"
        End Sub

        ' Token: 0x06000495 RID: 1173 RVA: 0x0023D308 File Offset: 0x0023C308
        Private Sub miOpenK2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim clsDialogTlk As clsDialogTlk = New clsDialogTlk(UserSettings.GetSettings().KotorLocation(1) + "\dialog.tlk", True)
            Me.LoadTableAndBuildGrid(clsDialogTlk)
            Me.dgDialogTlk.CaptionText = UserSettings.GetSettings().KotorLocation(1) + "\dialog.tlk"
        End Sub

        ' Token: 0x06000496 RID: 1174 RVA: 0x0023D358 File Offset: 0x0023C358
        Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, "Dialog.tlk", "Save Dialog.tlk file...", "xml", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.g_dialogtlk.ClearTalkEntryList()
            Try
                For Each obj As Object In Me.dt.Rows
                    Dim dataRow As DataRow = CType(obj, DataRow)
                    Dim dialogTlkStrDataElement As DialogTlkStrDataElement = New DialogTlkStrDataElement()
                    If StringType.StrCmp(dataRow("Text").ToString().Trim(), "", False) <> 0 Then
                        dialogTlkStrDataElement.Text = StringType.FromObject(dataRow("Text"))
                        dialogTlkStrDataElement.Flags = 1
                    End If
                    If StringType.StrCmp(dataRow("SoundRef").ToString().Trim(), "", False) <> 0 Then
                        dialogTlkStrDataElement.SoundResRef = StringType.FromObject(dataRow("SoundRef"))
                        Dim dialogTlkStrDataElement2 As DialogTlkStrDataElement = dialogTlkStrDataElement
                        dialogTlkStrDataElement2.Flags += 2
                    End If
                    If dialogTlkStrDataElement.Flags = 0 Then
                        dialogTlkStrDataElement.Flags = 32768
                    End If
                    Me.g_dialogtlk.AddTalkEntry(dialogTlkStrDataElement)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.g_dialogtlk.WriteListToFile(text)
            Me.dgDialogTlk.CaptionText = text
        End Sub

        ' Token: 0x06000497 RID: 1175 RVA: 0x0023D4CC File Offset: 0x0023C4CC
        Private Sub miSaveAsXML_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, "Dialog.tlk.xml", "Save Dialog.tlk XML file...", "xml", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim dataSet As DataSet = New DataSet("DialogTlkFile")
            dataSet.Tables.Add(Me.dt)
            dataSet.WriteXml(text)
            dataSet.Tables.Remove(Me.dt)
            dataSet.Dispose()
        End Sub

        ' Token: 0x06000498 RID: 1176 RVA: 0x0023D550 File Offset: 0x0023C550
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x04000283 RID: 643
        Private dt As DataTable

        ' Token: 0x04000284 RID: 644
        Private DView As DataView

        ' Token: 0x04000285 RID: 645
        Private RF As RowFilter

        ' Token: 0x04000286 RID: 646
        Private g_dialogtlk As clsDialogTlk

        ' Token: 0x04000287 RID: 647
        Private g_currentFilePath As String

        ' Token: 0x04000288 RID: 648
        Private g_currentRow As Integer

        ' Token: 0x04000289 RID: 649
        Private g_useApplyBtn As Boolean
    End Class
End Namespace
