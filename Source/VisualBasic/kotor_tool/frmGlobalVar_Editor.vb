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

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x06000506 RID: 1286 RVA: 0x002409A4 File Offset: 0x0023F9A4
		' (set) Token: 0x06000505 RID: 1285 RVA: 0x002409B8 File Offset: 0x0023F9B8
		Friend Overridable Property dgBoolGlobals As DataGrid
			Get
				Return Me._dgBoolGlobals
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As DataGrid)
                If Me._dgBoolGlobals IsNot Nothing Then
                End If
                Me._dgBoolGlobals = value
                If Me._dgBoolGlobals IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700017B RID: 379
        ' (get) Token: 0x06000507 RID: 1287 RVA: 0x002409F0 File Offset: 0x0023F9F0
        ' (set) Token: 0x06000508 RID: 1288 RVA: 0x002409D4 File Offset: 0x0023F9D4
        Friend Overridable Property TabControl1() As TabControl
            Get
                Return Me._TabControl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._TabControl1 IsNot Nothing Then
                End If
                Me._TabControl1 = value
                If Me._TabControl1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700017C RID: 380
        ' (get) Token: 0x06000509 RID: 1289 RVA: 0x00240A20 File Offset: 0x0023FA20
        ' (set) Token: 0x0600050A RID: 1290 RVA: 0x00240A04 File Offset: 0x0023FA04
        Friend Overridable Property TabPage1() As TabPage
            Get
                Return Me._TabPage1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage1 IsNot Nothing Then
                End If
                Me._TabPage1 = value
                If Me._TabPage1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700017D RID: 381
        ' (get) Token: 0x0600050B RID: 1291 RVA: 0x00240A50 File Offset: 0x0023FA50
        ' (set) Token: 0x0600050C RID: 1292 RVA: 0x00240A34 File Offset: 0x0023FA34
        Friend Overridable Property TabPage2() As TabPage
            Get
                Return Me._TabPage2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage2 IsNot Nothing Then
                End If
                Me._TabPage2 = value
                If Me._TabPage2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700017E RID: 382
        ' (get) Token: 0x0600050D RID: 1293 RVA: 0x00240AB8 File Offset: 0x0023FAB8
        ' (set) Token: 0x0600050E RID: 1294 RVA: 0x00240A64 File Offset: 0x0023FA64
        Friend Overridable Property dgNumericGlobals() As DataGrid
            Get
                Return Me._dgNumericGlobals
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As DataGrid)
                If Me._dgNumericGlobals IsNot Nothing Then
                    RemoveHandler Me._dgNumericGlobals.CurrentCellChanged, AddressOf Me.dgNumericGlobals_CurrentCellChanged
                End If
                Me._dgNumericGlobals = value
                If Me._dgNumericGlobals IsNot Nothing Then
                    AddHandler Me._dgNumericGlobals.CurrentCellChanged, AddressOf Me.dgNumericGlobals_CurrentCellChanged
                End If
            End Set
        End Property

        ' Token: 0x1700017F RID: 383
        ' (get) Token: 0x06000510 RID: 1296 RVA: 0x00240AE8 File Offset: 0x0023FAE8
        ' (set) Token: 0x0600050F RID: 1295 RVA: 0x00240ACC File Offset: 0x0023FACC
        Friend Overridable Property TabPage4() As TabPage
            Get
                Return Me._TabPage4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._TabPage4 IsNot Nothing Then
                End If
                Me._TabPage4 = value
                If Me._TabPage4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000180 RID: 384
        ' (get) Token: 0x06000511 RID: 1297 RVA: 0x00240B18 File Offset: 0x0023FB18
        ' (set) Token: 0x06000512 RID: 1298 RVA: 0x00240AFC File Offset: 0x0023FAFC
        Friend Overridable Property dgStringGlobals() As DataGrid
            Get
                Return Me._dgStringGlobals
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As DataGrid)
                If Me._dgStringGlobals IsNot Nothing Then
                End If
                Me._dgStringGlobals = value
                If Me._dgStringGlobals IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000181 RID: 385
        ' (get) Token: 0x06000513 RID: 1299 RVA: 0x00240B48 File Offset: 0x0023FB48
        ' (set) Token: 0x06000514 RID: 1300 RVA: 0x00240B2C File Offset: 0x0023FB2C
        Friend Overridable Property MainMenu1() As MainMenu
            Get
                Return Me._MainMenu1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MainMenu)
                If Me._MainMenu1 IsNot Nothing Then
                End If
                Me._MainMenu1 = value
                If Me._MainMenu1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000182 RID: 386
        ' (get) Token: 0x06000515 RID: 1301 RVA: 0x00240B5C File Offset: 0x0023FB5C
        ' (set) Token: 0x06000516 RID: 1302 RVA: 0x00240B70 File Offset: 0x0023FB70
        Friend Overridable Property MenuItem1() As MenuItem
            Get
                Return Me._MenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._MenuItem1 IsNot Nothing Then
                End If
                Me._MenuItem1 = value
                If Me._MenuItem1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000183 RID: 387
        ' (get) Token: 0x06000517 RID: 1303 RVA: 0x00240BE0 File Offset: 0x0023FBE0
        ' (set) Token: 0x06000518 RID: 1304 RVA: 0x00240B8C File Offset: 0x0023FB8C
        Friend Overridable Property miOpenFirst() As MenuItem
            Get
                Return Me._miOpenFirst
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miOpenFirst IsNot Nothing Then
                    RemoveHandler Me._miOpenFirst.Click, AddressOf Me.miOpenFirst_Click
                End If
                Me._miOpenFirst = value
                If Me._miOpenFirst IsNot Nothing Then
                    AddHandler Me._miOpenFirst.Click, AddressOf Me.miOpenFirst_Click
                End If
            End Set
        End Property

        ' Token: 0x17000184 RID: 388
        ' (get) Token: 0x06000519 RID: 1305 RVA: 0x00240C48 File Offset: 0x0023FC48
        ' (set) Token: 0x0600051A RID: 1306 RVA: 0x00240BF4 File Offset: 0x0023FBF4
        Friend Overridable Property miOpenCompare() As MenuItem
            Get
                Return Me._miOpenCompare
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miOpenCompare IsNot Nothing Then
                    RemoveHandler Me._miOpenCompare.Click, AddressOf Me.miOpenCompare_Click
                End If
                Me._miOpenCompare = value
                If Me._miOpenCompare IsNot Nothing Then
                    AddHandler Me._miOpenCompare.Click, AddressOf Me.miOpenCompare_Click
                End If
            End Set
        End Property

        ' Token: 0x17000185 RID: 389
        ' (get) Token: 0x0600051C RID: 1308 RVA: 0x00240C5C File Offset: 0x0023FC5C
        ' (set) Token: 0x0600051B RID: 1307 RVA: 0x00240C70 File Offset: 0x0023FC70
        Friend Overridable Property miSave() As MenuItem
            Get
                Return Me._miSave
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miSave IsNot Nothing Then
                    RemoveHandler Me._miSave.Click, AddressOf Me.miSave_Click
                End If
                Me._miSave = value
                If Me._miSave IsNot Nothing Then
                    AddHandler Me._miSave.Click, AddressOf Me.miSave_Click
                End If
            End Set
        End Property

        ' Token: 0x17000186 RID: 390
        ' (get) Token: 0x0600051E RID: 1310 RVA: 0x00240D18 File Offset: 0x0023FD18
        ' (set) Token: 0x0600051D RID: 1309 RVA: 0x00240CC4 File Offset: 0x0023FCC4
        Friend Overridable Property miQuit() As MenuItem
            Get
                Return Me._miQuit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miQuit IsNot Nothing Then
                    RemoveHandler Me._miQuit.Click, AddressOf Me.miQuit_Click
                End If
                Me._miQuit = value
                If Me._miQuit IsNot Nothing Then
                    AddHandler Me._miQuit.Click, AddressOf Me.miQuit_Click
                End If
            End Set
        End Property

        ' Token: 0x17000187 RID: 391
        ' (get) Token: 0x06000520 RID: 1312 RVA: 0x00240D48 File Offset: 0x0023FD48
        ' (set) Token: 0x0600051F RID: 1311 RVA: 0x00240D2C File Offset: 0x0023FD2C
        Friend Overridable Property MenuItem6() As MenuItem
            Get
                Return Me._MenuItem6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._MenuItem6 IsNot Nothing Then
                End If
                Me._MenuItem6 = value
                If Me._MenuItem6 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000188 RID: 392
        ' (get) Token: 0x06000522 RID: 1314 RVA: 0x00240D78 File Offset: 0x0023FD78
        ' (set) Token: 0x06000521 RID: 1313 RVA: 0x00240D5C File Offset: 0x0023FD5C
        Friend Overridable Property MenuItem2() As MenuItem
            Get
                Return Me._MenuItem2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._MenuItem2 IsNot Nothing Then
                End If
                Me._MenuItem2 = value
                If Me._MenuItem2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000189 RID: 393
        ' (get) Token: 0x06000523 RID: 1315 RVA: 0x00240D8C File Offset: 0x0023FD8C
        ' (set) Token: 0x06000524 RID: 1316 RVA: 0x00240DA0 File Offset: 0x0023FDA0
        Friend Overridable Property miShowOnlyDiffs() As MenuItem
            Get
                Return Me._miShowOnlyDiffs
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As MenuItem)
                If Me._miShowOnlyDiffs IsNot Nothing Then
                    RemoveHandler Me._miShowOnlyDiffs.Click, AddressOf Me.miShowOnlyDiffs_Click
                End If
                Me._miShowOnlyDiffs = value
                If Me._miShowOnlyDiffs IsNot Nothing Then
                    AddHandler Me._miShowOnlyDiffs.Click, AddressOf Me.miShowOnlyDiffs_Click
                End If
            End Set
        End Property

        ' Token: 0x1700018A RID: 394
        ' (get) Token: 0x06000525 RID: 1317 RVA: 0x00240DF4 File Offset: 0x0023FDF4
        ' (set) Token: 0x06000526 RID: 1318 RVA: 0x00240E08 File Offset: 0x0023FE08
        Friend Overridable Property lblFile1() As Label
            Get
                Return Me._lblFile1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblFile1 IsNot Nothing Then
                End If
                Me._lblFile1 = value
                If Me._lblFile1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700018B RID: 395
        ' (get) Token: 0x06000528 RID: 1320 RVA: 0x00240E24 File Offset: 0x0023FE24
        ' (set) Token: 0x06000527 RID: 1319 RVA: 0x00240E38 File Offset: 0x0023FE38
        Friend Overridable Property lblFile2() As Label
            Get
                Return Me._lblFile2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblFile2 IsNot Nothing Then
                End If
                Me._lblFile2 = value
                If Me._lblFile2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700018C RID: 396
        ' (get) Token: 0x06000529 RID: 1321 RVA: 0x00240E54 File Offset: 0x0023FE54
        ' (set) Token: 0x0600052A RID: 1322 RVA: 0x00240E68 File Offset: 0x0023FE68
        Friend Overridable Property Label1() As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label1 IsNot Nothing Then
                End If
                Me._Label1 = value
                If Me._Label1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700018D RID: 397
        ' (get) Token: 0x0600052C RID: 1324 RVA: 0x00240E84 File Offset: 0x0023FE84
        ' (set) Token: 0x0600052B RID: 1323 RVA: 0x00240E98 File Offset: 0x0023FE98
        Friend Overridable Property Label2() As Label
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label2 IsNot Nothing Then
                End If
                Me._Label2 = value
                If Me._Label2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700018E RID: 398
        ' (get) Token: 0x0600052D RID: 1325 RVA: 0x00240EB4 File Offset: 0x0023FEB4
        ' (set) Token: 0x0600052E RID: 1326 RVA: 0x00240EC8 File Offset: 0x0023FEC8
        Friend Overridable Property StatusBar() As StatusBar
            Get
                Return Me._StatusBar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As StatusBar)
                If Me._StatusBar IsNot Nothing Then
                End If
                Me._StatusBar = value
                If Me._StatusBar IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700018F RID: 399
        ' (get) Token: 0x06000530 RID: 1328 RVA: 0x00240F00 File Offset: 0x0023FF00
        ' (set) Token: 0x0600052F RID: 1327 RVA: 0x00240EE4 File Offset: 0x0023FEE4
        Friend Overridable Property sbpBool() As StatusBarPanel
            Get
                Return Me._sbpBool
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As StatusBarPanel)
                If Me._sbpBool IsNot Nothing Then
                End If
                Me._sbpBool = value
                If Me._sbpBool IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000190 RID: 400
        ' (get) Token: 0x06000532 RID: 1330 RVA: 0x00240F30 File Offset: 0x0023FF30
        ' (set) Token: 0x06000531 RID: 1329 RVA: 0x00240F14 File Offset: 0x0023FF14
        Friend Overridable Property sbpNumeric() As StatusBarPanel
            Get
                Return Me._sbpNumeric
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As StatusBarPanel)
                If Me._sbpNumeric IsNot Nothing Then
                End If
                Me._sbpNumeric = value
                If Me._sbpNumeric IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000191 RID: 401
        ' (get) Token: 0x06000533 RID: 1331 RVA: 0x00240F44 File Offset: 0x0023FF44
        ' (set) Token: 0x06000534 RID: 1332 RVA: 0x00240F58 File Offset: 0x0023FF58
        Friend Overridable Property sbpString() As StatusBarPanel
            Get
                Return Me._sbpString
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As StatusBarPanel)
                If Me._sbpString IsNot Nothing Then
                End If
                Me._sbpString = value
                If Me._sbpString IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000192 RID: 402
        ' (get) Token: 0x06000535 RID: 1333 RVA: 0x00240F74 File Offset: 0x0023FF74
        ' (set) Token: 0x06000536 RID: 1334 RVA: 0x00240F88 File Offset: 0x0023FF88
        Friend Overridable Property sbpLabel() As StatusBarPanel
            Get
                Return Me._sbpLabel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As StatusBarPanel)
                If Me._sbpLabel IsNot Nothing Then
                End If
                Me._sbpLabel = value
                If Me._sbpLabel IsNot Nothing Then
                End If
            End Set
        End Property

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
        Private Sub dgNumericGlobals_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub miOpenFirst_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub miOpenCompare_Click(ByVal sender As Object, ByVal e As EventArgs)
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
        Private Sub miShowOnlyDiffs_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.bShowOnlyDiffs = Not Me.bShowOnlyDiffs
            Me.miShowOnlyDiffs.Checked = Me.bShowOnlyDiffs
            Me.SetFilterState(Me.bShowOnlyDiffs)
        End Sub

        ' Token: 0x06000550 RID: 1360 RVA: 0x00242F9C File Offset: 0x00241F9C
        Private Sub miSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SaveFormData()
        End Sub

        ' Token: 0x06000551 RID: 1361 RVA: 0x00242FA4 File Offset: 0x00241FA4
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

        ' Token: 0x040002AE RID: 686
        <AccessedThroughProperty("MainMenu1")> _
        Private _MainMenu1 As MainMenu

        ' Token: 0x040002AF RID: 687
        <AccessedThroughProperty("sbpString")> _
        Private _sbpString As StatusBarPanel

        ' Token: 0x040002B0 RID: 688
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040002B1 RID: 689
        <AccessedThroughProperty("MenuItem2")> _
        Private _MenuItem2 As MenuItem

        ' Token: 0x040002B2 RID: 690
        <AccessedThroughProperty("sbpLabel")> _
        Private _sbpLabel As StatusBarPanel

        ' Token: 0x040002B3 RID: 691
        <AccessedThroughProperty("dgBoolGlobals")> _
        Private _dgBoolGlobals As DataGrid

        ' Token: 0x040002B4 RID: 692
        <AccessedThroughProperty("dgNumericGlobals")> _
        Private _dgNumericGlobals As DataGrid

        ' Token: 0x040002B5 RID: 693
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl

        ' Token: 0x040002B6 RID: 694
        <AccessedThroughProperty("sbpNumeric")> _
        Private _sbpNumeric As StatusBarPanel

        ' Token: 0x040002B7 RID: 695
        <AccessedThroughProperty("TabPage4")> _
        Private _TabPage4 As TabPage

        ' Token: 0x040002B8 RID: 696
        <AccessedThroughProperty("TabPage1")> _
        Private _TabPage1 As TabPage

        ' Token: 0x040002B9 RID: 697
        <AccessedThroughProperty("dgStringGlobals")> _
        Private _dgStringGlobals As DataGrid

        ' Token: 0x040002BA RID: 698
        <AccessedThroughProperty("TabPage2")> _
        Private _TabPage2 As TabPage

        ' Token: 0x040002BB RID: 699
        <AccessedThroughProperty("miOpenFirst")> _
        Private _miOpenFirst As MenuItem

        ' Token: 0x040002BC RID: 700
        <AccessedThroughProperty("miOpenCompare")> _
        Private _miOpenCompare As MenuItem

        ' Token: 0x040002BD RID: 701
        <AccessedThroughProperty("sbpBool")> _
        Private _sbpBool As StatusBarPanel

        ' Token: 0x040002BE RID: 702
        <AccessedThroughProperty("miShowOnlyDiffs")> _
        Private _miShowOnlyDiffs As MenuItem

        ' Token: 0x040002BF RID: 703
        <AccessedThroughProperty("MenuItem1")> _
        Private _MenuItem1 As MenuItem

        ' Token: 0x040002C0 RID: 704
        <AccessedThroughProperty("lblFile1")> _
        Private _lblFile1 As Label

        ' Token: 0x040002C1 RID: 705
        <AccessedThroughProperty("lblFile2")> _
        Private _lblFile2 As Label

        ' Token: 0x040002C2 RID: 706
        <AccessedThroughProperty("StatusBar")> _
        Private _StatusBar As StatusBar

        ' Token: 0x040002C3 RID: 707
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040002C4 RID: 708
        <AccessedThroughProperty("miSave")> _
        Private _miSave As MenuItem

        ' Token: 0x040002C5 RID: 709
        <AccessedThroughProperty("MenuItem6")> _
        Private _MenuItem6 As MenuItem

        ' Token: 0x040002C6 RID: 710
        <AccessedThroughProperty("miQuit")> _
        Private _miQuit As MenuItem

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
