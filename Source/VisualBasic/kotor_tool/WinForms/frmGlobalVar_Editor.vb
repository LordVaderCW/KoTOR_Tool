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

    Partial Public Class frmGlobalVar_Editor
        Inherits frmParent

        ' -----------------------------------------------------------------
        ' Runtime patch notes:
        '
        ' These patches stop frmGlobalVar_Editor.vb from undoing the
        ' Designer layout and DarkSaber fallback styling at runtime.
        '
        ' Main fixes:
        '   - Removed old hard-coded TabControl1 Location/Size resets.
        '   - Replaced white DataGridTableStyle runtime colours.
        '   - Added ApplyRuntimeDataGridTheme so runtime DataGrid styles match
        '     the Designer after data binding/table styles are rebuilt.
        '   - Forces DataGrid controls to DockStyle.Fill so each grid fills the
        '     full render area inside its TabPage.
        '   - Keeps DataGrid captions visible for the internal section header.
        ' -----------------------------------------------------------------

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

        Public Sub New(ByVal GlobalsClass As clsGlobalVars, ByVal KotorVerIndex As Integer)
            Me.New()
            Me.Globals = GlobalsClass
            Me.KotorVersionIndex = KotorVerIndex
            Me.BuildTablesAndGrids()
            Me.FillGrids()
        End Sub

        Public Sub New(ByVal GlobalsClass As clsGlobalVars, ByVal filepath As String, ByVal KotorVerIndex As Integer)
            Me.New(GlobalsClass, KotorVerIndex)
            Me.g_savePath = filepath
            Me.Text = "Global Variable Editor  -  " + Strings.Mid(filepath, Strings.InStrRev(filepath, "\", -1, CompareMethod.Binary) + 1)
            Me.lblFile1.Text = filepath + "\GLOBALVARS.res"

            ' PATCH:
            ' Removed the old decompiled layout reset:
            '   TabControl1.Location = New Point(8, 32)
            '   TabControl1.Size = New Size(432, 488)
            '
            ' The themed Designer now owns the layout. Runtime code should not
            ' shrink the TabControl back to the legacy fixed-size editor layout.
            Me.miOpenCompare.Enabled = True
        End Sub

        Public Sub FillGlobalVarArrays()
            Me.BoolArray = CType(LateBinding.LateGet(Me.Globals.GetNodeValue("ValBoolean"), Nothing, "bytes", New Object(-1) {}, Nothing, Nothing), Byte())
            Me.NumericArray = CType(LateBinding.LateGet(Me.Globals.GetNodeValue("ValNumber"), Nothing, "bytes", New Object(-1) {}, Nothing, Nothing), Byte())
        End Sub

        Private Sub BuildTablesAndGrids()
            Me.BuildBoolDataTable()
            Me.BuildBoolDataGrid()
            Me.BuildNumericDataTable()
            Me.BuildNumericDataGrid()
            Me.BuildStringDataTable()
            Me.BuildStringDataGrid()
            Me.bTablesAndGridsBuilt = True
        End Sub

        Private Sub ClearTables()
            Me.dtBool.Rows.Clear()
            Me.dtNumeric.Rows.Clear()
            Me.dtString.Rows.Clear()
        End Sub

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
            Me.ApplyRuntimeDataGridTheme(Me.dgBoolGlobals)

            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.Globals.GetListItemCount("CatNumber") - 1
            For i As Integer = num3 To num4
                Dim dataRow As DataRow = Me.dtNumeric.NewRow()
                dataRow(0) = RuntimeHelpers.GetObjectValue(Me.Globals.GetNodeValue("CatNumber(" + StringType.FromInteger(i) + ").Name"))
                dataRow(1) = Me.NumericArray(i)
                Me.dtNumeric.Rows.Add(dataRow)
            Next
            Me.AutoSizeColumns(Me.dgNumericGlobals, Me.dtNumeric)
            Me.ApplyRuntimeDataGridTheme(Me.dgNumericGlobals)

            Dim num5 As Integer = 0
            Dim num6 As Integer = Me.Globals.GetListItemCount("CatString") - 1
            For i As Integer = num5 To num6
                Dim dataRow As DataRow = Me.dtString.NewRow()
                dataRow(0) = RuntimeHelpers.GetObjectValue(Me.Globals.GetNodeValue("CatString(" + StringType.FromInteger(i) + ").Name"))
                dataRow(1) = RuntimeHelpers.GetObjectValue(Me.Globals.GetNodeValue("ValString(" + StringType.FromInteger(i) + ").String"))
                Me.dtString.Rows.Add(dataRow)
            Next
            Me.AutoSizeColumns(Me.dgStringGlobals, Me.dtString)
            Me.ApplyRuntimeDataGridTheme(Me.dgStringGlobals)

            Me.dgBoolGlobals.ResumeLayout()
            Me.dgNumericGlobals.ResumeLayout()
            Me.dgStringGlobals.ResumeLayout()
            Me.TabPage1.ResumeLayout()
            Me.TabPage2.ResumeLayout()
            Me.TabPage4.ResumeLayout()
            Me.TabControl1.ResumeLayout()
        End Sub

        Private Function GetBit(ByVal bitnum As Integer, ByVal BooleanArray As Byte()) As Boolean
            Dim num As Integer = CInt(Math.Round(Conversion.Int(Math.Floor(CDbl(bitnum) / 8.0))))
            Dim b As Byte = BooleanArray(num)
            Return (CLng(b) And CLng(Math.Round(Math.Pow(2.0, CDbl((bitnum - num * 8)))))) <> 0L
        End Function

        Private Sub SetBit(ByVal bitnum As Integer, ByVal state As Boolean, ByVal BooleanArray As Byte())
            Dim num As Integer = CInt(Math.Round(Conversion.Int(Math.Floor(CDbl(bitnum) / 8.0))))
            Dim b As Byte = BooleanArray(num)
            If state Then
                b = CByte((CLng(b) Or CLng(Math.Round(Math.Pow(2.0, CDbl((bitnum - num * 8)))))))
            Else
                Dim b2 As Byte = CByte(Math.Round(255.0 - Math.Pow(2.0, CDbl((bitnum - num * 8)))))
                b = b And b2
            End If
            BooleanArray(num) = b
        End Sub

        Private Sub SetFilterState(ByVal active As Boolean)
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
                ' PATCH:
                ' Keep the status bar visible even when the difference filter is
                ' disabled. The panels remain useful as a fixed bottom status
                ' strip and should not vanish from the themed UI.
                Me.StatusBar.Visible = True
                CType(Me.dgBoolGlobals.DataSource, DataView).RowFilter = ""
                CType(Me.dgNumericGlobals.DataSource, DataView).RowFilter = ""
                CType(Me.dgStringGlobals.DataSource, DataView).RowFilter = ""
            End If
        End Sub

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

        Public Sub BuildBoolDataGrid()
            Me.dtBool.DefaultView.AllowDelete = False
            Me.dtBool.DefaultView.AllowNew = False
            Me.dtBool.DefaultView.AllowEdit = True

            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgBoolGlobals.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dtBool.TableName

            ' PATCH:
            ' The old decompiled code set AlternatingBackColor to white/grey.
            ' Runtime table styles override Designer colours, so the table style
            ' must be themed here as well.
            Me.ApplyRuntimeTableStyleTheme(dataGridTableStyle)

            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Variable"
            dataGridTextBoxColumn.HeaderText = "Variable"
            dataGridTextBoxColumn.ReadOnly = True
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

            ' PATCH:
            ' Keep the internal grid caption/header visible. The Designer uses
            ' this caption as the small section title inside the grid surface.
            Me.dgBoolGlobals.CaptionText = "Boolean Globals"
            Me.dgBoolGlobals.CaptionVisible = True

            Me.ApplyRuntimeDataGridTheme(Me.dgBoolGlobals)
        End Sub

        Public Sub BuildNumericDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Variable", GetType(String))
            Me.dtNumeric.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Value", GetType(Byte))
            Me.dtNumeric.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Value_Compare", GetType(Byte))
            Me.dtNumeric.Columns.Add(dataColumn)
        End Sub

        Public Sub BuildNumericDataGrid()
            Me.dtNumeric.DefaultView.AllowDelete = False
            Me.dtNumeric.DefaultView.AllowNew = False
            Me.dtNumeric.DefaultView.AllowEdit = True

            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgNumericGlobals.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dtNumeric.TableName

            ' PATCH:
            ' Keep runtime DataGridTableStyle consistent with the Designer theme.
            Me.ApplyRuntimeTableStyleTheme(dataGridTableStyle)

            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Variable"
            dataGridTextBoxColumn.HeaderText = "Variable"
            dataGridTextBoxColumn.ReadOnly = True
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

            ' PATCH:
            ' Keep the internal grid caption/header visible.
            Me.dgNumericGlobals.CaptionText = "Numeric Globals"
            Me.dgNumericGlobals.CaptionVisible = True

            Me.ApplyRuntimeDataGridTheme(Me.dgNumericGlobals)
        End Sub

        Public Sub BuildStringDataTable()
            Dim dataColumn As DataColumn = New DataColumn("Variable", GetType(String))
            Me.dtString.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Value", GetType(String))
            Me.dtString.Columns.Add(dataColumn)
            dataColumn = New DataColumn("Value_Compare", GetType(String))
            Me.dtString.Columns.Add(dataColumn)
        End Sub

        Public Sub BuildStringDataGrid()
            Me.dtString.DefaultView.AllowDelete = False
            Me.dtString.DefaultView.AllowNew = False
            Me.dtString.DefaultView.AllowEdit = True

            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
            Me.dgStringGlobals.TableStyles.Clear()
            dataGridTableStyle.MappingName = Me.dtString.TableName

            ' PATCH:
            ' Keep runtime DataGridTableStyle consistent with the Designer theme.
            Me.ApplyRuntimeTableStyleTheme(dataGridTableStyle)

            Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            dataGridTextBoxColumn.MappingName = "Variable"
            dataGridTextBoxColumn.HeaderText = "Variable"
            dataGridTextBoxColumn.ReadOnly = True
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

            ' PATCH:
            ' Keep the internal grid caption/header visible.
            Me.dgStringGlobals.CaptionText = "String Globals"
            Me.dgStringGlobals.CaptionVisible = True

            Me.ApplyRuntimeDataGridTheme(Me.dgStringGlobals)
        End Sub

        ' PATCH:
        ' Shared runtime grid theme. This must run after SetDataBinding and after
        ' TableStyles are rebuilt, because WinForms DataGrid runtime styles can
        ' override the Designer fallback styling.
        '
        ' It also forces DockStyle.Fill so each DataGrid expands to occupy the
        ' complete TabPage render area, instead of keeping a legacy fixed Size.
        Private Sub ApplyRuntimeDataGridTheme(ByVal grid As DataGrid)
            If grid Is Nothing Then
                Return
            End If

            grid.SuspendLayout()

            KotorThemeApplier.ApplyToForm(Me)

            ' Important:
            ' False gives the old WinForms DataGrid its proper raised/header edge lines.
            grid.FlatMode = False

            grid.ResumeLayout(False)
        End Sub

        ' PATCH:
        ' DataGridTableStyle has its own palette and is applied over the grid.
        ' Without this, the grid returns to classic white/grey rows after load.
        Private Sub ApplyRuntimeTableStyleTheme(ByVal tableStyle As DataGridTableStyle)
            If tableStyle Is Nothing Then
                Return
            End If

            KotorThemeApplier.ApplyDataGridTableStyle(tableStyle, KotorThemeManager.LoadTheme(KotorThemeManager.GetActiveThemeName()))
        End Sub


        ' PATCH:
        ' AutoSizeColumns now ignores hidden compare columns whose MappingName ends
        ' with "_off". These columns still exist in the DataGridTableStyle for compare
        ' mode, but they should not consume visible width during normal viewing.
        '
        ' Fixes:
        '   - Boolean, Numeric, and String grids now expand their visible columns across
        '     the full available DataGrid width.
        '   - Hidden compare columns are forced to Width = 0 until compare mode remaps
        '     them to Active_Compare / Value_Compare.
        '   - Runtime grid layout now matches the Designer preview more closely.
        '   - Prevents the dead empty area on the right side of the runtime grid.
        '
        ' Important:
        '   - ApplyRuntimeDataGridTheme should run before AutoSizeColumns.
        '   - AutoSizeColumns should be called again after compare mode enables the
        '     compare columns.
        Public Sub AutoSizeColumns(ByVal dg As DataGrid, ByVal dt As DataTable)
            If dg Is Nothing OrElse dt Is Nothing Then Return
            If dg.TableStyles Is Nothing OrElse dg.TableStyles.Count = 0 Then Return
            If dg.TableStyles(0).GridColumnStyles Is Nothing OrElse dg.TableStyles(0).GridColumnStyles.Count = 0 Then Return

            Dim tableStyle As DataGridTableStyle = dg.TableStyles(0)
            Dim visibleColumns As ArrayList = New ArrayList()

            Dim i As Integer
            For i = 0 To tableStyle.GridColumnStyles.Count - 1
                Dim col As DataGridColumnStyle = tableStyle.GridColumnStyles(i)

                If col.MappingName IsNot Nothing AndAlso col.MappingName.EndsWith("_off") Then
                    col.Width = 0
                Else
                    visibleColumns.Add(col)
                End If
            Next

            If visibleColumns.Count = 0 Then Return

            Dim usableWidth As Integer = dg.ClientSize.Width

            usableWidth -= dg.RowHeaderWidth
            usableWidth -= 22
            usableWidth -= 8

            If usableWidth < 100 Then usableWidth = 100

            If visibleColumns.Count = 2 Then
                CType(visibleColumns(0), DataGridColumnStyle).Width = CInt(usableWidth * 0.78)
                CType(visibleColumns(1), DataGridColumnStyle).Width = usableWidth - CType(visibleColumns(0), DataGridColumnStyle).Width
            ElseIf visibleColumns.Count = 3 Then
                CType(visibleColumns(0), DataGridColumnStyle).Width = CInt(usableWidth * 0.5)
                CType(visibleColumns(1), DataGridColumnStyle).Width = CInt(usableWidth * 0.25)
                CType(visibleColumns(2), DataGridColumnStyle).Width = usableWidth - CType(visibleColumns(0), DataGridColumnStyle).Width - CType(visibleColumns(1), DataGridColumnStyle).Width
            End If
        End Sub

        Protected Function GetColWidth(ByVal dg As DataGrid, ByVal col As Integer, ByVal DisplayName As String) As Integer
            Dim num As Single = 0.0F
            Dim count As Integer = CType(dg.DataSource, DataView).Count
            Dim graphics As Graphics = Graphics.FromHwnd(Me.Handle)
            Dim stringFormat As StringFormat = New StringFormat(StringFormat.GenericTypographic)
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

        Private Sub frmGlobalVar_Editor_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PositionWindow(Me.Name)

            ' PATCH:
            ' Keep the status bar visible as part of the themed layout. The old
            ' code only showed it during comparison filtering, which made the
            ' bottom area disappear during normal viewing.
            Me.StatusBar.Visible = True
        End Sub

        Private Sub frmGlobalVar_Editor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings(Me.Name)
        End Sub

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

            ' PATCH:
            ' Removed old runtime layout reset:
            '   TabControl1.Location = New Point(8, 32)
            '   TabControl1.Size = New Size(432, 488)
            '
            ' The Designer now controls the body panel and tab sizing.
            Me.miOpenCompare.Enabled = True
        End Sub

        Private Sub miOpenCompare_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenCompare.Click
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", "", "GLOBALVARS.res", "", "", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If

            Me.lblFile2.Text = text

            ' PATCH:
            ' Removed old compare-mode layout reset:
            '   TabControl1.Location = New Point(8, 56)
            '   TabControl1.Size = New Size(432, 464)
            '
            ' Compare mode should reveal the compare column, not resize the UI.
            Me.dgBoolGlobals.TableStyles(0).GridColumnStyles(2).MappingName = "Active_Compare"
            Me.AutoSizeColumns(Me.dgBoolGlobals, Me.dtBool)
            Me.ApplyRuntimeDataGridTheme(Me.dgBoolGlobals)

            Me.dgNumericGlobals.TableStyles(0).GridColumnStyles(2).MappingName = "Value_Compare"
            Me.AutoSizeColumns(Me.dgNumericGlobals, Me.dtNumeric)
            Me.ApplyRuntimeDataGridTheme(Me.dgNumericGlobals)

            Me.dgStringGlobals.TableStyles(0).GridColumnStyles(2).MappingName = "Value_Compare"
            Me.AutoSizeColumns(Me.dgStringGlobals, Me.dtString)
            Me.ApplyRuntimeDataGridTheme(Me.dgStringGlobals)

            Dim fileStream As FileStream = New FileStream(text, FileMode.Open)
            Me.Globals_Compare = New clsGlobalVars(fileStream, Me.KotorVersionIndex)
            fileStream.Close()

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
            Me.ApplyRuntimeDataGridTheme(Me.dgBoolGlobals)
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
            Me.ApplyRuntimeDataGridTheme(Me.dgNumericGlobals)
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
            Me.ApplyRuntimeDataGridTheme(Me.dgStringGlobals)
            dataView.Sort = text2

            Me.miShowOnlyDiffs.Enabled = True
            Me.miShowOnlyDiffs.Checked = True
            Me.bShowOnlyDiffs = True
            Me.SetFilterState(True)
        End Sub

        Private Sub miShowOnlyDiffs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miShowOnlyDiffs.Click
            Me.bShowOnlyDiffs = Not Me.bShowOnlyDiffs
            Me.miShowOnlyDiffs.Checked = Me.bShowOnlyDiffs
            Me.SetFilterState(Me.bShowOnlyDiffs)
        End Sub

        Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miSave.Click
            Me.SaveFormData()
        End Sub

        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miQuit.Click
            Me.Close()
        End Sub

        Public Globals As clsGlobalVars
        Public Globals_Compare As clsGlobalVars
        Public g_clsDialogTlk As clsDialogTlk
        Public g_clsChitinKey As clsChitinKey

        Private dtBool As DataTable
        Private dtNumeric As DataTable
        Private dtString As DataTable
        Private g_savePath As String
        Private bTablesAndGridsBuilt As Boolean
        Private bShowOnlyDiffs As Boolean
        Private BoolArray As Byte()
        Private NumericArray As Byte()

    End Class

End Namespace
