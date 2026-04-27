Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200004D RID: 77
	Public Partial Class frmGlobalVar_Editor
		Inherits frmParent

		' Token: 0x06000503 RID: 1283 RVA: 0x00240900 File Offset: 0x0023F900
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmGlobalVar_Editor_Load
			AddHandler MyBase.Closing, AddressOf Me.frmGlobalVar_Editor_Closing
			Me.dtBool = New DataTable()
			Me.dtNumeric = New DataTable()
			Me.dtString = New DataTable()
			Me.bTablesAndGridsBuilt = False
			Me.BoolArray = New Byte(102) {}
			Me.NumericArray = New Byte(368) {}
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06000538 RID: 1336 RVA: 0x00241AC4 File Offset: 0x00240AC4
        Public Sub New(ByVal GlobalsClass As clsGlobalVars, ByVal KotorVerIndex As Integer)
            Me.New()
            Me.Globals = GlobalsClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.BuildTablesAndGrids()
            Me.FillGrids()
        End Sub

        ' Token: 0x06000539 RID: 1337 RVA: 0x00241AE8 File Offset: 0x00240AE8
        Public Sub New(ByVal GlobalsClass As clsGlobalVars, ByVal filepath As String, ByVal KotorVerIndex As Integer)
            Me.New(GlobalsClass, KotorVerIndex)
            Me.g_savePath = filepath
            Me.Text = "Global Variable Editor  -  " + Strings.Mid(filepath, Strings.InStrRev(filepath, "\", -1, CompareMethod.Binary) + 1)
            Me.lblFile1.Text = filepath + "\GLOBALVARS.res"
            Dim tabControl As Control = Me.TabControl1
            Dim point As Point = New Point(8, 32)
            tabControl.Location = point
            Dim tabControl2 As Control = Me.TabControl1
            Dim size As Size = New Size(432, 488)
            tabControl2.Size = size
            Me.miOpenCompare.Enabled = True
        End Sub

        ' Token: 0x0600053A RID: 1338 RVA: 0x00241B80 File Offset: 0x00240B80
        Public Sub FillGlobalVarArrays()
            Me.BoolArray = CType(LateBinding.LateGet(Me.Globals.GetNodeValue("ValBoolean"), Nothing, "bytes", New Object(-1) {}, Nothing, Nothing), Byte())
            Me.NumericArray = CType(LateBinding.LateGet(Me.Globals.GetNodeValue("ValNumber"), Nothing, "bytes", New Object(-1) {}, Nothing, Nothing), Byte())
        End Sub

        ' Token: 0x0600053B RID: 1339 RVA: 0x00241BEC File Offset: 0x00240BEC
        Private Sub BuildTablesAndGrids()
            Me.BuildBoolDataTable()
            Me.BuildBoolDataGrid()
            Me.BuildNumericDataTable()
            Me.BuildNumericDataGrid()
            Me.BuildStringDataTable()
            Me.BuildStringDataGrid()
            Me.bTablesAndGridsBuilt = True
        End Sub

        ' Token: 0x0600053C RID: 1340 RVA: 0x00241C1C File Offset: 0x00240C1C
        Private Sub ClearTables()
            Me.dtBool.Rows.Clear()
            Me.dtNumeric.Rows.Clear()
            Me.dtString.Rows.Clear()
        End Sub

        ' Token: 0x0600053D RID: 1341 RVA: 0x00241C50 File Offset: 0x00240C50
        Public Sub FillGrids()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage4.SuspendLayout()
            Me.dgBoolGlobals.SuspendLayout()
            Me.dgNumericGlobals.SuspendLayout()
            Me.dgStringGlobals.SuspendLayout()
            Me.FillGlobalVarArrays()
            Dim num As Integer = 0
            Dim num2 As Integer = Me.Globals.GetListItemCount("CatBoolean") - 1
            For i As Integer = num To num2
                Dim dataRow As DataRow = Me.dtBool.NewRow()
                dataRow(0) = RuntimeHelpers.GetObjectValue(Me.Globals.GetNodeValue("CatBoolean(" + StringType.FromInteger(i) + ").Name"))
                dataRow(1) = Me.GetBit(i, Me.BoolArray)
                Me.dtBool.Rows.Add(dataRow)
            Next
            Me.AutoSizeColumns(Me.dgBoolGlobals, Me.dtBool)
            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.Globals.GetListItemCount("CatNumber") - 1
            For i As Integer = num3 To num4
                Dim dataRow As DataRow = Me.dtNumeric.NewRow()
                dataRow(0) = RuntimeHelpers.GetObjectValue(Me.Globals.GetNodeValue("CatNumber(" + StringType.FromInteger(i) + ").Name"))
                dataRow(1) = Me.NumericArray(i)
                Me.dtNumeric.Rows.Add(dataRow)
            Next
            Me.AutoSizeColumns(Me.dgNumericGlobals, Me.dtNumeric)
            Dim num5 As Integer = 0
            Dim num6 As Integer = Me.Globals.GetListItemCount("CatString") - 1
            For i As Integer = num5 To num6
                Dim dataRow As DataRow = Me.dtString.NewRow()
                dataRow(0) = RuntimeHelpers.GetObjectValue(Me.Globals.GetNodeValue("CatString(" + StringType.FromInteger(i) + ").Name"))
                dataRow(1) = RuntimeHelpers.GetObjectValue(Me.Globals.GetNodeValue("ValString(" + StringType.FromInteger(i) + ").String"))
                Me.dtString.Rows.Add(dataRow)
            Next
            Me.AutoSizeColumns(Me.dgStringGlobals, Me.dtString)
            Me.dgBoolGlobals.ResumeLayout()
            Me.dgNumericGlobals.ResumeLayout()
            Me.dgStringGlobals.ResumeLayout()
            Me.TabPage1.ResumeLayout()
            Me.TabPage2.ResumeLayout()
            Me.TabPage4.ResumeLayout()
            Me.TabControl1.ResumeLayout()
        End Sub

        ' Token: 0x0600053E RID: 1342 RVA: 0x00241EC8 File Offset: 0x00240EC8
        Private Function GetBit(ByVal bitnum As Integer, ByVal BooleanArray As Byte()) As Boolean
            ' The following expression was wrapped in a checked-expression
            Dim num As Integer = CInt(Math.Round(Conversion.Int(Math.Floor(CDbl(bitnum) / 8.0))))
            Dim b As Byte = BooleanArray(num)
            Return (CLng(b) And CLng(Math.Round(Math.Pow(2.0, CDbl((bitnum - num * 8)))))) <> 0L
        End Function

        ' Token: 0x0600053F RID: 1343 RVA: 0x00241F20 File Offset: 0x00240F20
        Private Sub SetBit(ByVal bitnum As Integer, ByVal state As Boolean, ByVal BooleanArray As Byte())
            ' The following expression was wrapped in a checked-statement
            Dim num As Integer = CInt(Math.Round(Conversion.Int(Math.Floor(CDbl(bitnum) / 8.0))))
            Dim b As Byte = BooleanArray(num)
            If state Then
                ' The following expression was wrapped in a unchecked-expression
                b = CByte((CLng(b) Or CLng(Math.Round(Math.Pow(2.0, CDbl((bitnum - num * 8)))))))
            Else
                ' The following expression was wrapped in a unchecked-expression
                ' The following expression was wrapped in a checked-expression
                Dim b2 As Byte = CByte(Math.Round(255.0 - Math.Pow(2.0, CDbl((bitnum - num * 8)))))
                b = b And b2
            End If
            BooleanArray(num) = b
        End Sub

        ' Token: 0x06000540 RID: 1344 RVA: 0x00241FA0 File Offset: 0x00240FA0
        Private Sub SetFilterState(ByVal active As Boolean)
            ' The following expression was wrapped in a checked-statement
            If active Then
                Me.StatusBar.Visible = True
                Me.dtBool.AcceptChanges()
                Me.dtNumeric.AcceptChanges()
                Me.dtString.AcceptChanges()
                CType(Me.dgBoolGlobals.DataSource, DataView).RowFilter = "Active <> Active_Compare"
                Me.sbpBool.Text = StringType.FromInteger(CType(Me.dgBoolGlobals.DataSource, DataView).Count)
                Dim num As Integer
                num += CType(Me.dgBoolGlobals.DataSource, DataView).Count
                CType(Me.dgNumericGlobals.DataSource, DataView).RowFilter = "Value <> Value_Compare"
                Me.sbpNumeric.Text = StringType.FromInteger(CType(Me.dgNumericGlobals.DataSource, DataView).Count)
                num += CType(Me.dgNumericGlobals.DataSource, DataView).Count
                CType(Me.dgStringGlobals.DataSource, DataView).RowFilter = "Value <> Value_Compare"
                Me.sbpString.Text = StringType.FromInteger(CType(Me.dgStringGlobals.DataSource, DataView).Count)
                num += CType(Me.dgStringGlobals.DataSource, DataView).Count
                If num = 0 Then
                    Interaction.MsgBox("Files are identical", MsgBoxStyle.Information, "Note")
                End If
            Else
                Me.StatusBar.Visible = False
                CType(Me.dgBoolGlobals.DataSource, DataView).RowFilter = ""
                CType(Me.dgNumericGlobals.DataSource, DataView).RowFilter = ""
                CType(Me.dgStringGlobals.DataSource, DataView).RowFilter = ""
            End If
        End Sub

        ' Token: 0x06000541 RID: 1345 RVA: 0x00242158 File Offset: 0x00241158
        Private Sub SaveFormData()
            Dim num As Integer = 0
            Dim num2 As Integer = Me.Globals.GetListItemCount("CatBoolean") - 1
            For i As Integer = num To num2
                Me.SetBit(i, BooleanType.FromObject(Me.dgBoolGlobals(i, 1)), Me.BoolArray)
            Next
            LateBinding.LateSetComplex(Me.Globals.GetNodeValue("ValBoolean"), Nothing, "bytes", New Object() {Me.BoolArray}, Nothing, False, True)
            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.Globals.GetListItemCount("CatNumber") - 1
            For i As Integer = num3 To num4
                Me.NumericArray(i) = ByteType.FromObject(Me.dgNumericGlobals(i, 1))
            Next
            LateBinding.LateSetComplex(Me.Globals.GetNodeValue("ValNumber"), Nothing, "bytes", New Object() {Me.NumericArray}, Nothing, False, True)
            Dim num5 As Integer = 0
            Dim num6 As Integer = Me.Globals.GetListItemCount("CatString") - 1
            For i As Integer = num5 To num6
                Me.Globals.SetNodeValue("CatString(" + StringType.FromInteger(i) + ").Name", RuntimeHelpers.GetObjectValue(Me.dgStringGlobals(i, 0)))
                Me.Globals.SetNodeValue("ValString(" + StringType.FromInteger(i) + ").String", RuntimeHelpers.GetObjectValue(Me.dgStringGlobals(i, 1)))
            Next
            If StringType.StrCmp(Me.g_savePath, "", False) = 0 Then
                Me.g_savePath = UserSettings.GetSettings().defaultSaveLocation
            End If
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", Me.g_savePath, "GLOBALVARS.res", "Save Global Variables Table file...", "res", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.Globals.WriteFile(text, "GVT")
        End Sub

        ' Token: 0x06000542 RID: 1346 RVA: 0x00242334 File Offset: 0x00241334
        Public Sub BuildBoolDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Variable", GetType(String))
            Me.dtBool.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Active", GetType(Boolean))
            dataColumn.DefaultValue = False
            Me.dtBool.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Active_Compare", GetType(Boolean))
            dataColumn.DefaultValue = False
            Me.dtBool.Columns.Add(dataColumn)
        End Sub

        ' Token: 0x06000543 RID: 1347 RVA: 0x002423CC File Offset: 0x002413CC
        Public Sub BuildBoolDataGrid()
            Me.dtBool.DefaultView.AllowDelete = False
            Me.dtBool.DefaultView.AllowNew = False
            Me.dtBool.DefaultView.AllowEdit = True
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgBoolGlobals.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dtBool.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Variable"
            dataGridTextBoxColumn.HeaderText = "Variable"
            dataGridTextBoxColumn.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Dim dataGridBoolColumn As DataGridBoolColumn = New DataGridBoolColumn()
            dataGridBoolColumn.MappingName = "Active"
            dataGridBoolColumn.HeaderText = "Active"
            dataGridBoolColumn.AllowNull = False
            dataGridTableStyle.GridColumnStyles.Add(dataGridBoolColumn)
            dataGridBoolColumn = New DataGridBoolColumn()
            dataGridBoolColumn.MappingName = "Active_Compare_off"
            dataGridBoolColumn.HeaderText = "Active (Compare)"
            dataGridBoolColumn.AllowNull = False
            dataGridTableStyle.GridColumnStyles.Add(dataGridBoolColumn)
            Me.dgBoolGlobals.TableStyles.Add(dataGridTableStyle)
            Me.dgBoolGlobals.SetDataBinding(Me.dtBool.DefaultView, Nothing)
            Me.dgBoolGlobals.CaptionVisible = False
        End Sub

        ' Token: 0x06000544 RID: 1348 RVA: 0x00242518 File Offset: 0x00241518
        Public Sub BuildNumericDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Variable", GetType(String))
            Me.dtNumeric.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Value", GetType(Byte))
            Me.dtNumeric.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Value_Compare", GetType(Byte))
            Me.dtNumeric.Columns.Add(dataColumn)
        End Sub

        ' Token: 0x06000545 RID: 1349 RVA: 0x00242598 File Offset: 0x00241598
        Public Sub BuildNumericDataGrid()
            Me.dtNumeric.DefaultView.AllowDelete = False
            Me.dtNumeric.DefaultView.AllowNew = False
            Me.dtNumeric.DefaultView.AllowEdit = True
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgNumericGlobals.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dtNumeric.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Variable"
            dataGridTextBoxColumn.HeaderText = "Variable"
            dataGridTextBoxColumn.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Value"
            dataGridTextBoxColumn.HeaderText = "Value"
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Value_Compare_off"
            dataGridTextBoxColumn.HeaderText = "Value (Compare)"
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Me.dgNumericGlobals.TableStyles.Add(dataGridTableStyle)
            Me.dgNumericGlobals.SetDataBinding(Me.dtNumeric.DefaultView, Nothing)
            Me.dgNumericGlobals.CaptionVisible = False
        End Sub

        ' Token: 0x06000546 RID: 1350 RVA: 0x002426D8 File Offset: 0x002416D8
        Public Sub BuildStringDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Variable", GetType(String))
            Me.dtString.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Value", GetType(String))
            Me.dtString.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Value_Compare", GetType(String))
            Me.dtString.Columns.Add(dataColumn)
        End Sub

        ' Token: 0x06000547 RID: 1351 RVA: 0x00242758 File Offset: 0x00241758
        Public Sub BuildStringDataGrid()
            Me.dtString.DefaultView.AllowDelete = False
            Me.dtString.DefaultView.AllowNew = False
            Me.dtString.DefaultView.AllowEdit = True
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgStringGlobals.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dtString.TableName
            dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Variable"
            dataGridTextBoxColumn.HeaderText = "Variable"
            dataGridTextBoxColumn.[ReadOnly] = True
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Value"
            dataGridTextBoxColumn.HeaderText = "Value"
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            dataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Value_Compare_off"
            dataGridTextBoxColumn.HeaderText = "Value (Compare)"
            dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Me.dgStringGlobals.TableStyles.Add(dataGridTableStyle)
            Me.dgStringGlobals.SetDataBinding(Me.dtString.DefaultView, Nothing)
            Me.dgStringGlobals.CaptionVisible = False
        End Sub

        ' Token: 0x06000548 RID: 1352 RVA: 0x00242898 File Offset: 0x00241898
        Public Sub AutoSizeColumns(ByVal dg As DataGrid, ByVal dt As DataTable)
            Dim num As Integer = 0
            Dim num2 As Integer = dt.Columns.Count - 1
            For i As Integer = num To num2
                dg.TableStyles(0).GridColumnStyles(i).Width = Me.GetColWidth(dg, i, dt.Columns(i).Caption)
            Next
        End Sub

        ' Token: 0x06000549 RID: 1353 RVA: 0x002428F4 File Offset: 0x002418F4
        Protected Function GetColWidth(ByVal dg As DataGrid, ByVal col As Integer, ByVal DisplayName As String) As Integer
            Dim num As Single = 0.0F
            Dim count As Integer = CType(dg.DataSource, DataView).Count
            Dim graphics As Graphics = graphics.FromHwnd(Me.Handle)
            Dim stringFormat As StringFormat = New StringFormat(stringFormat.GenericTypographic)
            num = graphics.MeasureString(DisplayName, Me.Font, 500, stringFormat).Width
            Try
                Dim num2 As Integer = 0
                Dim num3 As Integer = count - 1
                For i As Integer = num2 To num3
                    Dim sizeF As SizeF = graphics.MeasureString(dg(i, col).ToString(), Me.Font, 500, stringFormat)
                    If sizeF.Width > num Then
                        num = sizeF.Width
                    End If
                Next
                graphics.Dispose()
            Catch ex As System.Exception
                num = 75.0F
            End Try
            Return CInt(Math.Round(CDbl((num + 15.0F))))
        End Function

        ' Token: 0x0600054A RID: 1354 RVA: 0x002429D8 File Offset: 0x002419D8
        Private Sub frmGlobalVar_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.Name)
        End Sub

        ' Token: 0x0600054B RID: 1355 RVA: 0x002429E8 File Offset: 0x002419E8
        Private Sub frmGlobalVar_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.Name)
        End Sub

        ' Token: 0x0600054C RID: 1356 RVA: 0x002429F8 File Offset: 0x002419F8
        Private Sub dgNumericGlobals_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgNumericGlobals.CurrentCellChanged
            Try
                For Each obj As Object In Me.dtNumeric.Rows
                    Dim dataRow As DataRow = CType(obj, DataRow)
                    dataRow.EndEdit()
                    Dim flag As Boolean = False
                    Dim flag2 As Boolean = False
                    If dataRow(1) Is DBNull.Value Then
                        flag = True
                    End If
                    If BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(dataRow(1), 0, False) < 0, ObjectType.ObjTst(dataRow(1), 255, False) > 0)) Then
                        flag2 = True
                    End If
                    dataRow.ClearErrors()
                    If flag Then
                        dataRow.SetColumnError(1, "You must enter a numeric value for this item")
                    End If
                    If flag2 Then
                        dataRow.SetColumnError(2, "You must enter a numeric value from 0-255 for this item")
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x0600054D RID: 1357 RVA: 0x00242AE0 File Offset: 0x00241AE0
        Private Sub miOpenFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenFirst.Click
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", "", "GLOBALVARS.res", "", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.g_savePath = text
            Me.lblFile1.Text = text
            If Not Me.bTablesAndGridsBuilt Then
                Me.BuildTablesAndGrids()
            Else
                Me.ClearTables()
            End If
            Dim fileStream As FileStream = New FileStream(text, FileMode.Open)
            Me.Globals = New clsGlobalVars(fileStream, Me.KotorVersionIndex)
            fileStream.Close()
            Me.FillGrids()
            If Me.Globals_Compare IsNot Nothing Then
                Me.SetFilterState(True)
            End If
            If Me.Globals_Compare Is Nothing Then
                Dim tabControl As Control = Me.TabControl1
                Dim point As Point = New Point(8, 32)
                tabControl.Location = point
                Dim tabControl2 As Control = Me.TabControl1
                Dim size As Size = New Size(432, 488)
                tabControl2.Size = size
            End If
            Me.miOpenCompare.Enabled = True
        End Sub

        ' Token: 0x0600054E RID: 1358 RVA: 0x00242BC8 File Offset: 0x00241BC8
        Private Sub miOpenCompare_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenCompare.Click
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", "", "GLOBALVARS.res", "", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.lblFile2.Text = text
            Dim tabControl As Control = Me.TabControl1
            Dim point As Point = New Point(8, 56)
            tabControl.Location = point
            Dim tabControl2 As Control = Me.TabControl1
            Dim size As Size = New Size(432, 464)
            tabControl2.Size = size
            Me.dgBoolGlobals.TableStyles(0).GridColumnStyles(2).MappingName = "Active_Compare"
            Me.AutoSizeColumns(Me.dgBoolGlobals, Me.dtBool)
            Me.dgNumericGlobals.TableStyles(0).GridColumnStyles(2).MappingName = "Value_Compare"
            Me.AutoSizeColumns(Me.dgNumericGlobals, Me.dtNumeric)
            Me.dgStringGlobals.TableStyles(0).GridColumnStyles(2).MappingName = "Value_Compare"
            Me.AutoSizeColumns(Me.dgStringGlobals, Me.dtString)
            Dim fileStream As FileStream = New FileStream(text, FileMode.Open)
            Me.Globals_Compare = New clsGlobalVars(fileStream, Me.KotorVersionIndex)
            Dim array As Byte() = CType(LateBinding.LateGet(Me.Globals_Compare.GetNodeValue("ValBoolean"), Nothing, "bytes", New Object(-1) {}, Nothing, Nothing), Byte())
            Dim array2 As Byte() = CType(LateBinding.LateGet(Me.Globals_Compare.GetNodeValue("ValNumber"), Nothing, "bytes", New Object(-1) {}, Nothing, Nothing), Byte())
            Dim dataView As DataView = CType(Me.dgBoolGlobals.DataSource, DataView)
            Dim text2 As String = dataView.Sort
            dataView.Sort = ""
            dataView.RowFilter = ""
            Dim num As Integer = 0
            Dim num2 As Integer = Me.Globals_Compare.GetListItemCount("CatBoolean") - 1
            For i As Integer = num To num2
                Dim dataRow As DataRow = Me.dtBool.DefaultView(i).Row
                dataRow(2) = Me.GetBit(i, array)
            Next
            Me.AutoSizeColumns(Me.dgBoolGlobals, Me.dtBool)
            dataView.Sort = text2
            dataView = CType(Me.dgNumericGlobals.DataSource, DataView)
            text2 = dataView.Sort
            dataView.Sort = ""
            dataView.RowFilter = ""
            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.Globals_Compare.GetListItemCount("CatNumber") - 1
            For i As Integer = num3 To num4
                Dim dataRow As DataRow = Me.dtNumeric.DefaultView(i).Row
                dataRow(2) = array2(i)
            Next
            Me.AutoSizeColumns(Me.dgNumericGlobals, Me.dtNumeric)
            dataView.Sort = text2
            dataView = CType(Me.dgStringGlobals.DataSource, DataView)
            text2 = dataView.Sort
            dataView.Sort = ""
            dataView.RowFilter = ""
            Dim num5 As Integer = 0
            Dim num6 As Integer = Me.Globals_Compare.GetListItemCount("CatString") - 1
            For i As Integer = num5 To num6
                Dim dataRow As DataRow = Me.dtString.DefaultView(i).Row
                dataRow(2) = RuntimeHelpers.GetObjectValue(Me.Globals_Compare.GetNodeValue("ValString(" + StringType.FromInteger(i) + ").String"))
            Next
            Me.AutoSizeColumns(Me.dgStringGlobals, Me.dtString)
            dataView.Sort = text2
            Me.miShowOnlyDiffs.Enabled = True
            Me.miShowOnlyDiffs.Checked = True
            Me.bShowOnlyDiffs = True
            Me.SetFilterState(True)
        End Sub

        ' Token: 0x0600054F RID: 1359 RVA: 0x00242F6C File Offset: 0x00241F6C
        Private Sub miShowOnlyDiffs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miShowOnlyDiffs.Click
            Me.bShowOnlyDiffs = Not Me.bShowOnlyDiffs
            Me.miShowOnlyDiffs.Checked = Me.bShowOnlyDiffs
            Me.SetFilterState(Me.bShowOnlyDiffs)
        End Sub

        ' Token: 0x06000550 RID: 1360 RVA: 0x00242F9C File Offset: 0x00241F9C
        Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miSave.Click
            Me.SaveFormData()
        End Sub

        ' Token: 0x06000551 RID: 1361 RVA: 0x00242FA4 File Offset: 0x00241FA4
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miQuit.Click
            Me.Close()
        End Sub

        ' Token: 0x040002C8 RID: 712
        Public Globals As clsGlobalVars

        ' Token: 0x040002C9 RID: 713
        Public Globals_Compare As clsGlobalVars

        ' Token: 0x040002CA RID: 714
        Public g_clsDialogTlk As clsDialogTlk

        ' Token: 0x040002CB RID: 715
        Public g_clsChitinKey As clsChitinKey

        ' Token: 0x040002CC RID: 716
        Private dtBool As DataTable

        ' Token: 0x040002CD RID: 717
        Private dtNumeric As DataTable

        ' Token: 0x040002CE RID: 718
        Private dtString As DataTable

        ' Token: 0x040002CF RID: 719
        Private g_savePath As String

        ' Token: 0x040002D0 RID: 720
        Private bTablesAndGridsBuilt As Boolean

        ' Token: 0x040002D1 RID: 721
        Private bShowOnlyDiffs As Boolean

        ' Token: 0x040002D2 RID: 722
        Private BoolArray As Byte()

        ' Token: 0x040002D3 RID: 723
        Private NumericArray As Byte()
    End Class
End Namespace
