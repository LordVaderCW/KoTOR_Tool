Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200003C RID: 60
	Public Partial Class frm2DAEditor
		Inherits Form

		' Token: 0x06000160 RID: 352 RVA: 0x00225AAC File Offset: 0x00224AAC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frm2DAEditor_Load
			AddHandler MyBase.Closing, AddressOf Me.frm2DAEditor_Closing
			AddHandler MyBase.Move, AddressOf Me.frm2DAEditor_Move
			Me.dt = New DataTable()
			Me.lastGDcell = Nothing
			Me.cm = New ContextMenu()
			Me.cmiInsertRow = New MenuItem("Insert Row")
			Me.cmiCopyRow = New MenuItem("Copy Row")
			Me.cmiPasteRow = New MenuItem("Paste Row")
			Me.cmiInsertCopiedRow = New MenuItem("Insert Copied Row")
			Me.cmiRenumberRowLabelColumn = New MenuItem("Renumber Row Labels")
            Me.cmiShowStrings = New MenuItem("Show Strings for Refs")

            Me.InitializeComponent()
            Me.LoadAndApplyTheme()

            AddHandler Me.dg2DA.MouseUp, AddressOf Me.dg_MouseUp
            AddHandler Me.miLoad2da.Click, AddressOf Me.miLoad2da_Click
            AddHandler Me.miSave2daV2b.Click, AddressOf Me.miSave2daV2b_Click
            AddHandler Me.miSave2daV2bXML.Click, AddressOf Me.miSave2daV2bXML_Click
            AddHandler Me.miQuit.Click, AddressOf Me.miQuit_Click
            AddHandler Me.miResetSort.Click, AddressOf Me.miResetSort_Click
            AddHandler Me.miUndoAll.Click, AddressOf Me.miUndoAll_Click
            AddHandler Me.miLoad2daXml.Click, AddressOf Me.miLoad2daXml_Click
            AddHandler Me.miSetKotORversion.Click, AddressOf Me.miSetKotORversion_Click
            AddHandler Me.miTestFunction.Click, AddressOf Me.miTestFunction_Click

        End Sub


        Private _theme As KotorTheme

        Private Sub ApplyApplicationIcon()
            Try
                Me.Icon = My.Resources.koTOR_icn
            Catch ex As System.Exception
                'Console.WriteLine("Icon could not be applied: " & ex.Message)
            End Try
        End Sub

        Private Sub LoadAndApplyTheme()
            Try
                _theme = KotorThemeManager.LoadTheme("DarkSaber")
            Catch
                _theme = KotorTheme.CreateDefault()
            End Try

            Me.Apply2DATheme()
        End Sub

        Private Sub Apply2DATheme()
            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            Me.BackColor = _theme.WindowBack

            If Me.pnlRoot IsNot Nothing Then
                Me.pnlRoot.BackColor = _theme.PanelRoot
            End If

            If Me.pnlHeader IsNot Nothing Then
                Me.pnlHeader.BackColor = _theme.PanelHeader
            End If

            If Me.pnlGridHost IsNot Nothing Then
                Me.pnlGridHost.BackColor = _theme.PanelBody
            End If

            If Me.lblBottomSeparator IsNot Nothing Then
                Me.lblBottomSeparator.BackColor = _theme.AccentGold
            End If

            If Me.lblTitle IsNot Nothing Then
                Me.lblTitle.ForeColor = _theme.AccentGoldLight
                Me.lblTitle.Font = New Font(_theme.BodyFontName, 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            End If

            If Me.lblSubTitle IsNot Nothing Then
                Me.lblSubTitle.ForeColor = _theme.TextSecondary
                Me.lblSubTitle.Font = _theme.CreateBodyFont()
            End If

            Me.ApplyDataGridTheme()
        End Sub

        Private Sub ApplyDataGridTheme()
            If Me.dg2DA Is Nothing Then
                Return
            End If

            Me.dg2DA.BackgroundColor = _theme.LogoBack
            Me.dg2DA.BackColor = _theme.LogoBack
            Me.dg2DA.ForeColor = _theme.TextPrimary

            Me.dg2DA.CaptionBackColor = _theme.PanelHeader
            Me.dg2DA.CaptionForeColor = _theme.AccentGoldLight
            Me.dg2DA.CaptionFont = New Font(_theme.BodyFontName, 9.0F, FontStyle.Bold, GraphicsUnit.Point)

            Me.dg2DA.HeaderBackColor = _theme.ControlDark
            Me.dg2DA.HeaderForeColor = _theme.TextPrimary

            Me.dg2DA.GridLineColor = _theme.BorderDark
            Me.dg2DA.LinkColor = _theme.AccentGoldLight

            Me.dg2DA.ParentRowsBackColor = _theme.PanelRoot
            Me.dg2DA.ParentRowsForeColor = _theme.TextSecondary

            Me.dg2DA.SelectionBackColor = _theme.ControlDown
            Me.dg2DA.SelectionForeColor = _theme.TextPrimary

            Me.dg2DA.FlatMode = True

            Try
                Me.dg2DA.Font = _theme.CreateBodyFont()
            Catch
                Me.dg2DA.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            End Try
        End Sub


        ' Token: 0x17000041 RID: 65
        ' (get) Token: 0x06000185 RID: 389 RVA: 0x002265EC File Offset: 0x002255EC
        ' (set) Token: 0x06000186 RID: 390 RVA: 0x00226600 File Offset: 0x00225600
        Public Overridable Property dt() As DataTable
            Get
                Return Me._dt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As DataTable)
                If Me._dt IsNot Nothing Then
                End If
                Me._dt = value
                If Me._dt IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000042 RID: 66
        ' (get) Token: 0x06000187 RID: 391 RVA: 0x0022661C File Offset: 0x0022561C
        ' (set) Token: 0x06000188 RID: 392 RVA: 0x00226630 File Offset: 0x00225630
        Protected Overridable Property cm() As ContextMenu
            Get
                Return Me._cm
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ContextMenu)
                If Me._cm IsNot Nothing Then
                End If
                Me._cm = value
                If Me._cm IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000043 RID: 67
        ' (get) Token: 0x06000189 RID: 393 RVA: 0x002266A0 File Offset: 0x002256A0
        ' (set) Token: 0x0600018A RID: 394 RVA: 0x0022664C File Offset: 0x0022564C
        Private Property cmiInsertRow() As MenuItem
            Get
                Return Me._cmiInsertRow
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._cmiInsertRow IsNot Nothing Then
                    RemoveHandler Me._cmiInsertRow.Click, AddressOf Me.cmiInsertRow_Click
                End If
                Me._cmiInsertRow = value
                If Me._cmiInsertRow IsNot Nothing Then
                    AddHandler Me._cmiInsertRow.Click, AddressOf Me.cmiInsertRow_Click
                End If
            End Set
        End Property

        ' Token: 0x17000044 RID: 68
        ' (get) Token: 0x0600018C RID: 396 RVA: 0x002266B4 File Offset: 0x002256B4
        ' (set) Token: 0x0600018B RID: 395 RVA: 0x002266C8 File Offset: 0x002256C8
        Private Property cmiCopyRow() As MenuItem
            Get
                Return Me._cmiCopyRow
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._cmiCopyRow IsNot Nothing Then
                    RemoveHandler Me._cmiCopyRow.Click, AddressOf Me.cmiCopyRow_Click
                End If
                Me._cmiCopyRow = value
                If Me._cmiCopyRow IsNot Nothing Then
                    AddHandler Me._cmiCopyRow.Click, AddressOf Me.cmiCopyRow_Click
                End If
            End Set
        End Property

        ' Token: 0x17000045 RID: 69
        ' (get) Token: 0x0600018D RID: 397 RVA: 0x00226770 File Offset: 0x00225770
        ' (set) Token: 0x0600018E RID: 398 RVA: 0x0022671C File Offset: 0x0022571C
        Private Property cmiPasteRow() As MenuItem
            Get
                Return Me._cmiPasteRow
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._cmiPasteRow IsNot Nothing Then
                    RemoveHandler Me._cmiPasteRow.Click, AddressOf Me.cmiPasteRow_Click
                End If
                Me._cmiPasteRow = value
                If Me._cmiPasteRow IsNot Nothing Then
                    AddHandler Me._cmiPasteRow.Click, AddressOf Me.cmiPasteRow_Click
                End If
            End Set
        End Property

        ' Token: 0x17000046 RID: 70
        ' (get) Token: 0x0600018F RID: 399 RVA: 0x00226784 File Offset: 0x00225784
        ' (set) Token: 0x06000190 RID: 400 RVA: 0x00226798 File Offset: 0x00225798
        Private Property cmiInsertCopiedRow() As MenuItem
            Get
                Return Me._cmiInsertCopiedRow
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._cmiInsertCopiedRow IsNot Nothing Then
                    RemoveHandler Me._cmiInsertCopiedRow.Click, AddressOf Me.cmiInsertCopiedRow_Click
                End If
                Me._cmiInsertCopiedRow = value
                If Me._cmiInsertCopiedRow IsNot Nothing Then
                    AddHandler Me._cmiInsertCopiedRow.Click, AddressOf Me.cmiInsertCopiedRow_Click
                End If
            End Set
        End Property

        ' Token: 0x17000047 RID: 71
        ' (get) Token: 0x06000192 RID: 402 RVA: 0x002267EC File Offset: 0x002257EC
        ' (set) Token: 0x06000191 RID: 401 RVA: 0x00226800 File Offset: 0x00225800
        Private Property cmiRenumberRowLabelColumn() As MenuItem
            Get
                Return Me._cmiRenumberRowLabelColumn
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._cmiRenumberRowLabelColumn IsNot Nothing Then
                    RemoveHandler Me._cmiRenumberRowLabelColumn.Click, AddressOf Me.cmiRenumberRowLabelColumn_Click
                End If
                Me._cmiRenumberRowLabelColumn = value
                If Me._cmiRenumberRowLabelColumn IsNot Nothing Then
                    AddHandler Me._cmiRenumberRowLabelColumn.Click, AddressOf Me.cmiRenumberRowLabelColumn_Click
                End If
            End Set
        End Property

        ' Token: 0x17000048 RID: 72
        ' (get) Token: 0x06000194 RID: 404 RVA: 0x00226854 File Offset: 0x00225854
        ' (set) Token: 0x06000193 RID: 403 RVA: 0x00226868 File Offset: 0x00225868
        Private Property cmiShowStrings() As MenuItem
            Get
                Return Me._cmiShowStrings
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As MenuItem)
                If Me._cmiShowStrings IsNot Nothing Then
                    RemoveHandler Me._cmiShowStrings.Click, AddressOf Me.cmiShowStrings_Click
                End If
                Me._cmiShowStrings = value
                If Me._cmiShowStrings IsNot Nothing Then
                    AddHandler Me._cmiShowStrings.Click, AddressOf Me.cmiShowStrings_Click
                End If
            End Set
        End Property

        ' Token: 0x06000195 RID: 405 RVA: 0x002268BC File Offset: 0x002258BC
        Public Sub New(ByVal a2DA As Byte())
            Me.New()
            Me.ary2da = a2DA
        End Sub

        ' Token: 0x06000196 RID: 406 RVA: 0x002268CC File Offset: 0x002258CC
        Public Sub New(ByVal filename As String, ByVal a2da As Byte(), Optional ByVal KotorVersIndex As Integer = -1)
            Me.New()
            Me.fname = filename
            Me.ary2da = a2da
            Me.dt.TableName = filename
            Me.KotorVersionIndex = KotorVersIndex
            Me.LastKotorVersionIndex = KotorVersIndex
            If KotorVersIndex = 0 Then
                Me.Text += " - Kotor I"
            ElseIf KotorVersIndex = 1 Then
                Me.Text += " - Kotor II"
            End If
        End Sub

        ' Token: 0x06000197 RID: 407 RVA: 0x00226940 File Offset: 0x00225940
        Public Sub CreateDataTable()
            Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
            Dim num As Integer = 9
            Dim num2 As Integer = Me.ary2da.Length - 1
            Dim i As Integer = num
            While i <= num2 AndAlso Me.ary2da(i) <> 0
                i += 1
            End While
            Dim num3 As Integer = i + 1
            Me.numRows = CInt(Math.Round(CDbl(Me.ary2da(num3)) + CDbl(Me.ary2da(num3 + 1)) * 256.0 + CDbl(Me.ary2da(num3 + 2)) * 65536.0 + CDbl(Me.ary2da(num3 + 3)) * 16777216.0))
            Me.colNames = Strings.Split(asciiencoding.GetString(Me.ary2da, 9, i - 10), vbTab, -1, CompareMethod.Binary)
            Me.numColumns = Me.colNames.Length
            Dim j As Integer = 0
            Dim num4 As Integer = num3 + 4
            Dim num5 As Integer = Me.ary2da.Length - 1
            i = num4
            While i <= num5
                If Me.ary2da(i) = 9 Then
                    j += 1
                    If j = Me.numRows Then
                        Exit While
                    End If
                End If
                i += 1
            End While
            i += 1
            Dim num6 As Integer = i
            Me.rowLabels = Strings.Split(asciiencoding.GetString(Me.ary2da, num3 + 4, i - num3 - 5), vbTab, -1, CompareMethod.Binary)
            Dim num7 As Integer = i + (Me.numRows * Me.numColumns + 1) * 2
            Me.dt.Columns.Add(New DataColumn("(Row Label)", GetType(String)))
            Dim num8 As Integer = 0
            Dim num9 As Integer = Me.numColumns - 1
            i = num8
            While i <= num9
                Dim dataColumn As DataColumn = New DataColumn(Me.colNames(i))
                dataColumn.DefaultValue = ""
                Me.dt.Columns.Add(dataColumn)
                i += 1
            End While
            Dim num10 As Integer = 0
            Dim num11 As Integer = Me.numRows - 1
            i = num10
            While i <= num11
                Dim dataRow As DataRow = Me.dt.NewRow()
                dataRow(0) = Me.rowLabels(i)
                Dim num12 As Integer = 0
                Dim num13 As Integer = Me.colNames.Length - 1
                j = num12
                While j <= num13
                    Dim num14 As Integer = (j + i * Me.numColumns) * 2 + num6
                    Dim num15 As Integer = num7 + CInt(Me.ary2da(num14)) + 256 * CInt(Me.ary2da(num14 + 1))
                    Dim num16 As Integer = num15
                    Dim num17 As Integer = Me.ary2da.Length - 1
                    Dim num18 As Integer = num16
                    While num18 <= num17 AndAlso Me.ary2da(num18) <> 0
                        num18 += 1
                    End While
                    Dim text As String
                    If num18 > num15 Then
                        text = asciiencoding.GetString(Me.ary2da, num15, num18 - num15)
                    Else
                        text = "****"
                    End If
                    dataRow(j + 1) = text
                    j += 1
                End While
                Me.dt.Rows.Add(dataRow)
                i += 1
            End While
        End Sub

        ' Token: 0x06000198 RID: 408 RVA: 0x00226C10 File Offset: 0x00225C10
        Private Sub frm2DAEditor_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Me.ary2da IsNot Nothing Then
                Me.BuildEditor()
            End If
            Me.PositionWindow()
        End Sub

        ' Token: 0x06000199 RID: 409 RVA: 0x00226C28 File Offset: 0x00225C28
        Private Sub frm2DAEditor_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SaveSettings()
        End Sub

        ' Token: 0x0600019A RID: 410 RVA: 0x00226C30 File Offset: 0x00225C30
        Public Sub BuildEditor()
            Me.CreateDataTable()
            Me.DView = Me.dt.DefaultView
            Me.DView.AllowDelete = True
            Me.DView.AllowNew = True
            Me.DView.AllowEdit = True
            Me.dg2DA.TableStyles.Clear()
            Me.dg2DA.SetDataBinding(Me.DView, Nothing)
            Me.dg2DA.CaptionText = Me.fname
            Me.dg2DA.CaptionFont = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
            Me.ApplyDataGridTheme()
            Me.CreateTableStyle()
            Me.AutoSizeColumns()
            AddHandler Me.dt.ColumnChanged, AddressOf Me.dt_ColumnChanged
        End Sub

        ' Token: 0x0600019B RID: 411 RVA: 0x00226CEC File Offset: 0x00225CEC
        Private Function WriteStringBytes(ByVal wr As BinaryWriter, ByVal str As String) As Object
            Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
            Dim array As Byte() = New Byte(255) {}
            asciiencoding.GetBytes(str, 0, Strings.Len(str), array, 0)
            wr.Write(array, 0, Strings.Len(str))
            Dim obj As Object
            Return obj
        End Function

        ' Token: 0x0600019C RID: 412 RVA: 0x00226D2C File Offset: 0x00225D2C
        'Public Sub Write2daV2bFile()
        '    Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, Me.fname, "Save 2DA v2.b file...", "2da", False, True))
        '    If StringType.StrCmp(text, "", False) = 0 Then
        '        Return
        '    End If
        '    Dim hashtable As Hashtable = New Hashtable()
        '    Dim fileStream As FileStream = New FileStream(text, FileMode.Create)
        '    Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)
        '    Dim array As Object()
        '    Dim array2 As Short()
        '    Dim num14 As Integer
        '    If Me.numColumns + 1 < Me.dt.Columns.Count Then
        '        Interaction.MsgBox("The columns added via the Show Strings function will be removed so that the file can be saved properly.", MsgBoxStyle.Information, "")
        '        Dim num As Integer = Me.dt.Columns.Count - 1
        '        Dim num2 As Integer = Me.numColumns + 1
        '        For i As Integer = num To num2 Step -1
        '            Me.dt.Columns.RemoveAt(i)
        '        Next
        '    End If
        '    Try
        '        Dim num3 As Integer = 0
        '        Dim num4 As Integer = 0
        '        Dim num5 As Integer = Me.dt.Rows.Count - 1
        '        For i As Integer = num4 To num5
        '            Dim num6 As Integer = 1
        '            Dim num7 As Integer = Me.dt.Columns.Count - 1
        '            For j As Integer = num6 To num7
        '                Dim obj As Object = RuntimeHelpers.GetObjectValue(Me.dg2DA(i, j))
        '                If Not hashtable.Contains(RuntimeHelpers.GetObjectValue(obj)) Then
        '                    hashtable.Add(RuntimeHelpers.GetObjectValue(obj), num3)
        '                    num3 += 1
        '                End If
        '            Next
        '        Next
        '    Catch ex As ArgumentOutOfRangeException
        '        Dim ex2 As ArgumentOutOfRangeException = CType(ex, ArgumentOutOfRangeException)
        '        Interaction.MsgBox("Error reading data from grid. dtc= " + StringType.FromInteger(Me.dt.Rows.Count) + " dvc= " + StringType.FromInteger(Me.DView.Count), MsgBoxStyle.Critical, Nothing)
        '        Return
        '    End Try
        '    array = New Object(hashtable.Count + 1 - 1) {}
        '    array2 = New Short(hashtable.Count + 1 - 1) {}
        '    hashtable.CopyTo(array, 0)
        '    Dim num8 As Integer = 0
        '    Dim num9 As Integer = hashtable.Count - 1
        '    For i As Integer = num8 To num9
        '        hashtable(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(array(i), Nothing, "key", New Object(-1) {}, Nothing, Nothing))) = i
        '    Next
        '    Me.WriteStringBytes(binaryWriter, "2DA V2.b" & vbLf)
        '    Dim num10 As Integer = 1
        '    Dim num11 As Integer = Me.dt.Columns.Count - 1
        '    For i As Integer = num10 To num11
        '        Me.WriteStringBytes(binaryWriter, Me.dt.Columns(i).ColumnName + vbTab)
        '    Next
        '    binaryWriter.Write(vbNullChar)
        '    binaryWriter.Write(Me.dt.Rows.Count)
        '    Dim num12 As Integer = 0
        '    Dim num13 As Integer = Me.dt.Rows.Count - 1
        '    For i As Integer = num12 To num13
        '        Me.WriteStringBytes(binaryWriter, StringType.FromObject(ObjectType.StrCatObj(Me.dg2DA(i, 0), vbTab)))
        '    Next
        '    num14 = CInt(fileStream.Position)
        '    fileStream.Seek(CLng((((Me.dt.Columns.Count - 1) * Me.dt.Rows.Count + 1) * 2)), SeekOrigin.Current)
        '    Dim num15 As Integer = 0
        '    Dim num16 As Integer = 0
        '    Dim num17 As Integer = hashtable.Count - 1
        '    Dim i As Integer
        '    i = num16
        '    While i <= num17
        '        Dim dictionaryEntry As DictionaryEntry = CType((If(array(i), Activator.CreateInstance(GetType(DictionaryEntry)))), DictionaryEntry)
        '        Dim text2 As String = StringType.FromObject(dictionaryEntry.Key)
        '        If StringType.StrCmp(text2, "****", False) = 0 Then
        '            text2 = ""
        '        End If
        '        Me.WriteStringBytes(binaryWriter, text2 + vbNullChar)
        '        array2(i) = CShort(num15)
        '        num15 += Strings.Len(text2) + 1
        '        i += 1
        '    End While
        '    array2(i) = CShort(num15)
        '    fileStream.Seek(CLng(num14), SeekOrigin.Begin)
        '    Dim num18 As Integer = 0
        '    Dim num19 As Integer = Me.dt.Rows.Count - 1
        '    i = num18
        '    While i <= num19
        '        Dim num20 As Integer = 1
        '        Dim num21 As Integer = Me.dt.Columns.Count - 1
        '        For j As Integer = num20 To num21
        '            Dim obj As Object = RuntimeHelpers.GetObjectValue(Me.dg2DA(i, j))
        '            Dim num3 As Integer = IntegerType.FromObject(hashtable(RuntimeHelpers.GetObjectValue(obj)))
        '            binaryWriter.Write(array2(num3))
        '        Next
        '        i += 1
        '    End While
        '    binaryWriter.Close()
        '    Me.fname = Path.GetFileName(text)
        '    Me.dg2DA.CaptionText = Me.fname
        'End Sub

        ' Token: 0x0600019C RID: 412 RVA: 0x00226D2C File Offset: 0x00225D2C
        Public Sub Write2daV2bFile()
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, Me.fname, "Save 2DA v2.b file...", "2da", False, True))

            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If

            Dim hashtable As Hashtable = New Hashtable()
            Dim fileStream As FileStream = New FileStream(text, FileMode.Create)
            Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream, Encoding.ASCII)

            Dim array As Object()
            Dim array2 As Short()
            Dim num14 As Integer
            Dim i As Integer
            Dim j As Integer

            If Me.numColumns + 1 < Me.dt.Columns.Count Then
                Interaction.MsgBox("The columns added via the Show Strings function will be removed so that the file can be saved properly.", MsgBoxStyle.Information, "")

                Dim num As Integer = Me.dt.Columns.Count - 1
                Dim num2 As Integer = Me.numColumns + 1

                For i = num To num2 Step -1
                    Me.dt.Columns.RemoveAt(i)
                Next
            End If

            Try
                Dim num3 As Integer = 0
                Dim num4 As Integer = 0
                Dim num5 As Integer = Me.dt.Rows.Count - 1

                For i = num4 To num5
                    Dim num6 As Integer = 1
                    Dim num7 As Integer = Me.dt.Columns.Count - 1

                    For j = num6 To num7
                        Dim obj As Object = RuntimeHelpers.GetObjectValue(Me.dg2DA(i, j))

                        If Not hashtable.Contains(RuntimeHelpers.GetObjectValue(obj)) Then
                            hashtable.Add(RuntimeHelpers.GetObjectValue(obj), num3)
                            num3 += 1
                        End If
                    Next
                Next

            Catch ex As ArgumentOutOfRangeException
                Interaction.MsgBox("Error reading data from grid. dtc= " + StringType.FromInteger(Me.dt.Rows.Count) + " dvc= " + StringType.FromInteger(Me.DView.Count), MsgBoxStyle.Critical, Nothing)
                binaryWriter.Close()
                Return
            End Try

            array = New Object(hashtable.Count + 1 - 1) {}
            array2 = New Short(hashtable.Count + 1 - 1) {}

            hashtable.CopyTo(array, 0)

            Dim num8 As Integer = 0
            Dim num9 As Integer = hashtable.Count - 1

            For i = num8 To num9
                hashtable(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(array(i), Nothing, "key", New Object(-1) {}, Nothing, Nothing))) = i
            Next

            Me.WriteStringBytes(binaryWriter, "2DA V2.b" & vbLf)

            Dim num10 As Integer = 1
            Dim num11 As Integer = Me.dt.Columns.Count - 1

            For i = num10 To num11
                Me.WriteStringBytes(binaryWriter, Me.dt.Columns(i).ColumnName + vbTab)
            Next

            binaryWriter.Write(vbNullChar)
            binaryWriter.Write(Me.dt.Rows.Count)

            Dim num12 As Integer = 0
            Dim num13 As Integer = Me.dt.Rows.Count - 1

            For i = num12 To num13
                Me.WriteStringBytes(binaryWriter, StringType.FromObject(ObjectType.StrCatObj(Me.dg2DA(i, 0), vbTab)))
            Next

            num14 = CInt(fileStream.Position)

            fileStream.Seek(CLng((((Me.dt.Columns.Count - 1) * Me.dt.Rows.Count + 1) * 2)), SeekOrigin.Current)

            Dim num15 As Integer = 0
            Dim num16 As Integer = 0
            Dim num17 As Integer = hashtable.Count - 1

            i = num16

            While i <= num17
                Dim dictionaryEntry As DictionaryEntry = CType((If(array(i), Activator.CreateInstance(GetType(DictionaryEntry)))), DictionaryEntry)
                Dim text2 As String = StringType.FromObject(dictionaryEntry.Key)

                If StringType.StrCmp(text2, "****", False) = 0 Then
                    text2 = ""
                End If

                Me.WriteStringBytes(binaryWriter, text2 + vbNullChar)

                array2(i) = CShort(num15)
                num15 += Strings.Len(text2) + 1
                i += 1
            End While

            array2(i) = CShort(num15)

            fileStream.Seek(CLng(num14), SeekOrigin.Begin)

            Dim num18 As Integer = 0
            Dim num19 As Integer = Me.dt.Rows.Count - 1

            i = num18

            While i <= num19
                Dim num20 As Integer = 1
                Dim num21 As Integer = Me.dt.Columns.Count - 1

                For j = num20 To num21
                    Dim obj As Object = RuntimeHelpers.GetObjectValue(Me.dg2DA(i, j))
                    Dim num3 As Integer = IntegerType.FromObject(hashtable(RuntimeHelpers.GetObjectValue(obj)))

                    binaryWriter.Write(array2(num3))
                Next

                i += 1
            End While

            binaryWriter.Close()

            Me.fname = Path.GetFileName(text)
            Me.dg2DA.CaptionText = Me.fname
        End Sub

        ' Token: 0x0600019D RID: 413 RVA: 0x002271A0 File Offset: 0x002261A0
        Private Sub LoadFromXMLFile(ByVal path As String)
            Me.filetype = "xml"
            Me.XMLfilepath = path
            Dim dataSet As DataSet = New DataSet()
            dataSet.ReadXml(path)
            Me.dt = dataSet.Tables(0)
            Me.DView = Me.dt.DefaultView
            Me.DView.AllowDelete = True
            Me.DView.AllowNew = True
            Me.DView.AllowEdit = True
            Me.dg2DA.TableStyles.Clear()
            Me.dg2DA.SetDataBinding(Me.DView, Nothing)
            Me.dg2DA.CaptionText = Me.dt.TableName
            Me.dg2DA.CaptionFont = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
            Me.ApplyDataGridTheme()
            Me.CreateTableStyle()
            Me.AutoSizeColumns()
            dataSet.Tables.Remove(Me.dt)
        End Sub

        ' Token: 0x0600019E RID: 414 RVA: 0x00227284 File Offset: 0x00226284
Private Sub CreateTableStyle()
            Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()

            Me.dg2DA.TableStyles.Clear()

            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            dataGridTableStyle.MappingName = Me.fname
            dataGridTableStyle.BackColor = _theme.LogoBack
            dataGridTableStyle.ForeColor = _theme.TextPrimary
            dataGridTableStyle.GridLineColor = _theme.BorderDark
            dataGridTableStyle.HeaderBackColor = _theme.ControlDark
            dataGridTableStyle.HeaderForeColor = _theme.TextPrimary
            dataGridTableStyle.SelectionBackColor = _theme.ControlDown
            dataGridTableStyle.SelectionForeColor = _theme.TextPrimary
            dataGridTableStyle.AlternatingBackColor = _theme.PanelBody
            dataGridTableStyle.RowHeaderWidth = 42

            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1

            For i As Integer = num To num2
                Dim dataGridTextBoxColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn()

                dataGridTextBoxColumn.MappingName = Me.dt.Columns(i).Caption
                dataGridTextBoxColumn.HeaderText = Me.dt.Columns(i).Caption
                dataGridTextBoxColumn.NullText = ""

                dataGridTextBoxColumn.TextBox.BackColor = _theme.LogoBack
                dataGridTextBoxColumn.TextBox.ForeColor = _theme.TextPrimary
                dataGridTextBoxColumn.TextBox.BorderStyle = BorderStyle.None

                dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn)
            Next

            Me.dg2DA.TableStyles.Add(dataGridTableStyle)
        End Sub

        ' Token: 0x0600019F RID: 415 RVA: 0x0022735C File Offset: 0x0022635C
        Public Sub AutoSizeColumns()
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1
            For i As Integer = num To num2
                Me.dg2DA.TableStyles(0).GridColumnStyles(i).Width = Me.GetColWidth(i, Me.dt.Columns(i).Caption)
            Next
        End Sub

        ' Token: 0x060001A0 RID: 416 RVA: 0x002273C8 File Offset: 0x002263C8
        Protected Function GetColWidth(ByVal col As Integer, ByVal DisplayName As String) As Integer
            Dim num As Single = 0.0F
            Dim count As Integer = CType(Me.dg2DA.DataSource, DataView).Count
            Dim graphics As Graphics = graphics.FromHwnd(Me.Handle)
            Dim stringFormat As StringFormat = New StringFormat(stringFormat.GenericTypographic)
            num = graphics.MeasureString(DisplayName, Me.Font, 500, stringFormat).Width
            Try
                Dim num2 As Integer = 0
                Dim num3 As Integer = count - 1
                For i As Integer = num2 To num3
                    Dim sizeF As SizeF = graphics.MeasureString(Me.dg2DA(i, col).ToString(), Me.Font, 500, stringFormat)
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

        ' Token: 0x060001A1 RID: 417 RVA: 0x002274B4 File Offset: 0x002264B4
        Private Sub dg_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim currentCell As DataGridCell = CType(sender, DataGrid).CurrentCell
            Dim hitTestInfo As DataGrid.HitTestInfo = Me.dg2DA.HitTest(Me.dg2DA.PointToClient(Control.MousePosition))
            If hitTestInfo.Type = DataGrid.HitTestType.RowHeader Then
                If Not Me.IsLastRow(hitTestInfo.Row) Then
                    If (e.Button = MouseButtons.Right) And (e.Clicks = 1) Then
                        Me.gClickedRow = hitTestInfo.Row
                        Me.cm.MenuItems.Clear()
                        Me.cm.MenuItems.Add(Me.cmiInsertRow)
                        Me.cm.MenuItems.Add(Me.cmiCopyRow)
                        If Me.clipboardDataRow IsNot Nothing OrElse Clipboard.GetDataObject().GetDataPresent(DataFormats.CommaSeparatedValue) Then
                            Me.cm.MenuItems.Add(Me.cmiPasteRow)
                            Me.cm.MenuItems.Add(Me.cmiInsertCopiedRow)
                        End If
                        If Me.IsCol0AllNumbers() Then
                            Me.cm.MenuItems.Add(Me.cmiRenumberRowLabelColumn)
                        End If
                        Dim cm As ContextMenu = Me.cm
                        Dim point As Point = New Point(e.X, e.Y)
                        cm.Show(Me, point)
                    End If
                ElseIf (e.Button = MouseButtons.Right) And (e.Clicks = 1) And (Me.clipboardDataRow IsNot Nothing) Then
                    Me.gClickedRow = hitTestInfo.Row
                    Me.cm.MenuItems.Clear()
                    Me.cm.MenuItems.Add(Me.cmiPasteRow)
                    Dim cm2 As ContextMenu = Me.cm
                    Dim point As Point = New Point(e.X, e.Y)
                    cm2.Show(Me, point)
                End If
            ElseIf hitTestInfo.Type = DataGrid.HitTestType.ColumnHeader AndAlso ((e.Button = MouseButtons.Right) And (e.Clicks = 1)) Then
                Me.gClickedColumn = hitTestInfo.Column
                Me.cm.MenuItems.Clear()
                Me.cm.MenuItems.Add(Me.cmiShowStrings)
                Dim cm3 As ContextMenu = Me.cm
                Dim point As Point = New Point(e.X, e.Y)
                cm3.Show(Me, point)
            End If
        End Sub

        ' Token: 0x060001A2 RID: 418 RVA: 0x002276E8 File Offset: 0x002266E8
        Protected Function IsLastRow(ByVal row As Integer) As Boolean
            ' The following expression was wrapped in a checked-statement
            Try
                Me.dg2DA.[Select](row + 1)
                Me.dg2DA.UnSelect(row + 1)
            Catch ex As IndexOutOfRangeException
                Dim ex2 As IndexOutOfRangeException = CType(ex, IndexOutOfRangeException)
                Return True
            End Try
            Return False
        End Function

        ' Token: 0x060001A3 RID: 419 RVA: 0x0022773C File Offset: 0x0022673C
        Private Sub btnWrite2daV2bFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Write2daV2bFile()
        End Sub

        ' Token: 0x060001A4 RID: 420 RVA: 0x00227744 File Offset: 0x00226744
        Private Sub GetClipboardDataRow(ByRef DestRow As DataRow)
            Dim dataObject As DataObject = CType(Clipboard.GetDataObject(), DataObject)
            Dim text As String
            If dataObject IsNot Nothing AndAlso dataObject.GetDataPresent(DataFormats.CommaSeparatedValue) Then
                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataObject.GetData(DataFormats.CommaSeparatedValue))
                If StringType.StrCmp(objectValue.[GetType]().Name, "MemoryStream", False) = 0 Then
                    Dim streamReader As StreamReader = New StreamReader(CType(objectValue, MemoryStream))
                    text = streamReader.ReadLine()
                    streamReader.Close()
                ElseIf StringType.StrCmp(objectValue.[GetType]().Name, "String", False) = 0 Then
                    text = CStr(objectValue)
                End If
            End If
            Dim array As String() = text.Split(New Char() {","c})
            If array.GetLength(0) > Me.dt.Columns.Count Then
                If Interaction.MsgBox("The clipboard contains more columns of data than are present in the table." & vbLf & "Do you want to paste just the columns that will fit?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "") = MsgBoxResult.No Then
                    Return
                End If
                Dim num As Integer = 0
                Dim num2 As Integer = Me.dt.Columns.Count - 1
                For i As Integer = num To num2
                    DestRow(i) = array(i)
                Next
            ElseIf array.GetLength(0) < Me.dt.Columns.Count Then
                If Interaction.MsgBox("The clipboard contains fewer columns of data than are present in the table." & vbLf & "Do you want to continue?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "") = MsgBoxResult.No Then
                    Return
                End If
                Dim num3 As Integer = 0
                Dim num4 As Integer = array.GetLength(0) - 1
                For i As Integer = num3 To num4
                    DestRow(i) = array(i)
                Next
            Else
                Dim num5 As Integer = 0
                Dim num6 As Integer = Me.dt.Columns.Count - 1
                For i As Integer = num5 To num6
                    DestRow(i) = array(i)
                Next
            End If
        End Sub

        ' Token: 0x060001A5 RID: 421 RVA: 0x002278E4 File Offset: 0x002268E4
        Private Sub cmiInsertRow_Click(ByVal sender As Object, ByVal e As EventArgs)
            If StringType.StrCmp(Me.dt.DefaultView.Sort, "", False) <> 0 Then
                Dim dialogResult As DialogResult = Me.ShowPasteInsertWhileSortedMsg()
                If dialogResult = dialogResult.Yes Then
                    Me.dt.DefaultView.Sort = ""
                ElseIf dialogResult = dialogResult.Cancel Then
                    Return
                End If
            End If
            Me.InsertRow(Nothing)
        End Sub

        ' Token: 0x060001A6 RID: 422 RVA: 0x00227940 File Offset: 0x00226940
        Private Sub cmiCopyRow_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 2
            Dim i As Integer
            Dim text As String
            i = num
            While i <= num2
                text = StringType.FromObject(ObjectType.StrCatObj(text, ObjectType.StrCatObj(Me.DView(Me.gClickedRow).Row(i), ",")))
                i += 1
            End While
            text = StringType.FromObject(ObjectType.StrCatObj(text, Me.DView(Me.gClickedRow).Row(i)))
            Dim dataObject As DataObject = New DataObject()
            dataObject.SetData(DataFormats.CommaSeparatedValue, False, text)
            Clipboard.SetDataObject(dataObject, True)
        End Sub

        ' Token: 0x060001A7 RID: 423 RVA: 0x002279E0 File Offset: 0x002269E0
        Private Sub cmiPasteRow_Click(ByVal sender As Object, ByVal e As EventArgs)
            If StringType.StrCmp(Me.dt.DefaultView.Sort, "", False) <> 0 Then
                Dim dialogResult As DialogResult = Me.ShowPasteInsertWhileSortedMsg()
                If dialogResult = dialogResult.Yes Then
                    Me.dt.DefaultView.Sort = ""
                ElseIf dialogResult = dialogResult.Cancel Then
                    Return
                End If
            End If
            Dim dataRow As DataRow
            If Me.IsLastRow(Me.gClickedRow) Then
                dataRow = Me.dt.NewRow()
            Else
                dataRow = Me.DView(Me.gClickedRow).Row
            End If
            Me.GetClipboardDataRow(dataRow)
            If Me.IsLastRow(Me.gClickedRow) Then
                Me.dt.Rows.Add(dataRow)
            End If
            Me.dg2DA.ScrollToRow(Me.gClickedRow)
        End Sub

        ' Token: 0x060001A8 RID: 424 RVA: 0x00227AA0 File Offset: 0x00226AA0
        Private Sub cmiInsertCopiedRow_Click(ByVal sender As Object, ByVal e As EventArgs)
            If StringType.StrCmp(Me.dt.DefaultView.Sort, "", False) <> 0 Then
                Dim dialogResult As DialogResult = Me.ShowPasteInsertWhileSortedMsg()
                If dialogResult = dialogResult.Yes Then
                    Me.dt.DefaultView.Sort = ""
                ElseIf dialogResult = dialogResult.Cancel Then
                    Return
                End If
            End If
            Dim dataRow As DataRow = Me.dt.NewRow()
            Me.GetClipboardDataRow(dataRow)
            Me.InsertRow(dataRow)
        End Sub

        ' Token: 0x060001A9 RID: 425 RVA: 0x00227B10 File Offset: 0x00226B10
        Private Sub cmiRenumberRowLabelColumn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.RenumberRowLabelColumn()
        End Sub

        ' Token: 0x060001AA RID: 426 RVA: 0x00227B18 File Offset: 0x00226B18
        Private Sub miLoad2da_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultImportLocation, "", "Load 2DA v2.b file...", "2da", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.filetype = "binary"
            Dim fileStream As FileStream = New FileStream(text, FileMode.Open, FileAccess.Read)
            Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
            Me.ary2da = binaryReader.ReadBytes(CInt(fileStream.Length))
            binaryReader.Close()
            Me.fname = Strings.Mid(text, text.LastIndexOf("\") + 2)
            Me.dt = New DataTable(Me.fname)
            Me.dg2DA.SetDataBinding(Nothing, Nothing)
            Me.BuildEditor()
        End Sub

        ' Token: 0x060001AB RID: 427 RVA: 0x00227BD8 File Offset: 0x00226BD8
        Private Sub miLoad2daXml_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultImportLocation, "", "Load 2DA v2.b (XML) file...", "xml", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Me.LoadFromXMLFile(text)
        End Sub

        ' Token: 0x060001AC RID: 428 RVA: 0x00227C28 File Offset: 0x00226C28
        Private Sub miSave2daV2b_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim sort As String = Me.dt.DefaultView.Sort
            Me.dt.DefaultView.Sort = ""
            Me.Write2daV2bFile()
            Me.dt.DefaultView.Sort = sort
        End Sub

        ' Token: 0x060001AD RID: 429 RVA: 0x00227C74 File Offset: 0x00226C74
        Private Sub miSave2daV2bXML_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, Strings.Replace(Me.fname, "2da", "xml", 1, -1, CompareMethod.Binary), "Save 2DA v2.b (XML) file...", "xml", False, True))
            If StringType.StrCmp(text, "", False) = 0 Then
                Return
            End If
            Dim sort As String = Me.dt.DefaultView.Sort
            Me.dt.DefaultView.Sort = ""
            If Me.numColumns + 1 < Me.dt.Columns.Count Then
                Interaction.MsgBox("The columns added via the Show Strings function will be removed so that the file can be saved properly.", MsgBoxStyle.Information, "")
                Dim num As Integer = Me.dt.Columns.Count - 1
                Dim num2 As Integer = Me.numColumns + 1
                For i As Integer = num To num2 Step -1
                    Me.dt.Columns.RemoveAt(i)
                Next
            End If
            Dim dataSet As DataSet = New DataSet("Kotor_2DA_File")
            dataSet.Tables.Add(Me.dt)
            dataSet.WriteXml(text)
            dataSet.Tables.Remove(Me.dt)
            dataSet.Dispose()
            Me.dt.DefaultView.Sort = sort
        End Sub

        ' Token: 0x060001AE RID: 430 RVA: 0x00227DA8 File Offset: 0x00226DA8
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide()
        End Sub

        ' Token: 0x060001AF RID: 431 RVA: 0x00227DB0 File Offset: 0x00226DB0
        Private Sub miResetSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DView.Sort = ""
        End Sub

        ' Token: 0x060001B0 RID: 432 RVA: 0x00227DC4 File Offset: 0x00226DC4
        Private Sub miUndoAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Interaction.MsgBox("Are you sure you want to lose all changes and reload?", MsgBoxStyle.OkCancel, "") = MsgBoxResult.Ok Then
                If StringType.StrCmp(Me.filetype, "xml", False) = 0 Then
                    Me.LoadFromXMLFile(Me.XMLfilepath)
                Else
                    Me.dg2DA.SetDataBinding(Nothing, Nothing)
                    Me.dt = New DataTable(Me.fname)
                    Me.BuildEditor()
                End If
            End If
        End Sub

        ' Token: 0x060001B1 RID: 433 RVA: 0x00227E2C File Offset: 0x00226E2C
        Private Sub RenumberRowLabelColumn()
            ' The following expression was wrapped in a checked-statement
            If Me.IsCol0AllNumbers() Then
                Dim num As Integer
                If Information.IsNumeric(RuntimeHelpers.GetObjectValue(Me.dg2DA(0, 0))) Then
                    num = IntegerType.FromObject(Me.dg2DA(0, 0))
                End If
                Dim frmPromptForString As frmPromptForString = New frmPromptForString("Renumber Row Labels", "Enter the starting value:", StringType.FromInteger(num))
                If frmPromptForString.ShowDialog(Me) = DialogResult.OK Then
                    num = Convert.ToInt32(frmPromptForString.tbValue.Text)
                    Dim num2 As Integer = 0
                    Dim num3 As Integer = Me.DView.Count - 1
                    For i As Integer = num2 To num3
                        Me.dg2DA(i, 0) = i + num
                    Next
                End If
            Else
                Interaction.MsgBox("One or more Row Labels is not a number or empty; aborting", MsgBoxStyle.OkOnly, Nothing)
            End If
        End Sub

        ' Token: 0x060001B2 RID: 434 RVA: 0x00227EE0 File Offset: 0x00226EE0
        Private Function IsCol0AllNumbers() As Boolean
            Dim flag As Boolean = True
            Dim num As Integer = 0
            Dim num2 As Integer = Me.DView.Count - 1
            For i As Integer = num To num2
                If Not Information.IsNumeric(RuntimeHelpers.GetObjectValue(Me.dg2DA(i, 0))) AndAlso StringType.StrCmp(Me.dg2DA(i, 0).ToString().Trim(), "", False) <> 0 Then
                    flag = False
                    Exit For
                End If
            Next
            Return flag
        End Function

        ' Token: 0x060001B3 RID: 435 RVA: 0x00227F4C File Offset: 0x00226F4C
        Private Sub InsertRow(ByVal dr As DataRow)
            Dim sort As String = Me.dt.DefaultView.Sort
            Dim dataTable As DataTable = New DataTable("temp")
            Me.dt.DefaultView.Sort = ""
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1
            For i As Integer = num To num2
                Dim dataColumn As DataColumn = New DataColumn(Me.dt.Columns(i).ColumnName, GetType(String))
                dataColumn.DefaultValue = ""
                dataTable.Columns.Add(dataColumn)
            Next
            Dim num3 As Integer = 0
            Dim num4 As Integer = Me.gClickedRow - 1
            Dim dataRow As DataRow
            For i As Integer = num3 To num4
                dataRow = Me.DView(i).Row
                dataTable.ImportRow(dataRow)
            Next
            dataRow = dataTable.NewRow()
            If dr Is Nothing Then
                dataRow(0) = "new"
            Else
                Dim num5 As Integer = 0
                Dim num6 As Integer = Me.dt.Columns.Count - 1
                For i As Integer = num5 To num6
                    dataRow(i) = RuntimeHelpers.GetObjectValue(dr(i))
                Next
            End If
            dataTable.Rows.Add(dataRow)
            Dim num7 As Integer = Me.gClickedRow
            Dim num8 As Integer = Me.dt.Rows.Count - 1
            For i As Integer = num7 To num8
                dataRow = Me.DView(i).Row
                dataTable.ImportRow(dataRow)
            Next
            Me.dt = dataTable
            Me.dt.TableName = Me.fname
            Me.dt.DefaultView.Sort = sort
            Me.dg2DA.SetDataBinding(Nothing, Nothing)
            Me.DView = Nothing
            Me.DView = Me.dt.DefaultView
            Me.dg2DA.SetDataBinding(Me.DView, Nothing)
            Me.CreateTableStyle()
            Me.AutoSizeColumns()
            Me.dg2DA.ScrollToRow(Me.gClickedRow)
        End Sub

        ' Token: 0x060001B4 RID: 436 RVA: 0x00228130 File Offset: 0x00227130
        Private Function InsertColumn(ByVal ColumnName As String) As Integer
            Dim dataColumn As DataColumn = New DataColumn(ColumnName)
            Me.dt.Columns.Add(dataColumn)
            Me.CreateTableStyle()
            Me.AutoSizeColumns()
            Return Me.dt.Columns.IndexOf(dataColumn)
        End Function

        ' Token: 0x060001B5 RID: 437 RVA: 0x00228174 File Offset: 0x00227174
        Private Function ShowPasteInsertWhileSortedMsg() As DialogResult
            Return CType(Interaction.MsgBox("Pasting or Inserting rows while the grid is sorted may produce unexpected results." & vbLf & "Do you wish to reset the sort before continuing?", MsgBoxStyle.YesNoCancel, Nothing), DialogResult)
        End Function

        ' Token: 0x060001B6 RID: 438 RVA: 0x00228190 File Offset: 0x00227190
        Public Sub PositionWindow()
            Dim settings As Options = UserSettings.GetSettings()
            If Not settings.TwoDAEditorWindowLoc.IsEmpty Then
                Dim twoDAEditorWindowLoc As Point = settings.TwoDAEditorWindowLoc
                Dim point As Point
                If twoDAEditorWindowLoc.X < 0 Then
                    Dim options As Options = settings
                    point = New Point(10, 10)
                    options.TwoDAEditorWindowLoc = point
                End If
                point = settings.TwoDAEditorWindowLoc
                If point.Y < 0 Then
                    Dim options2 As Options = settings
                    twoDAEditorWindowLoc = New Point(10, 10)
                    options2.TwoDAEditorWindowLoc = twoDAEditorWindowLoc
                End If
                Me.Location = settings.TwoDAEditorWindowLoc
            End If
            If Not settings.TwoDAEditorWindowSize.IsEmpty Then
                Dim size As Size = settings.TwoDAEditorWindowSize
                Dim height As Integer
                Dim size2 As Size
                If size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                    Dim point As Point = Me.Location
                    Dim twoDAEditorWindowLoc As Point = New Point(point.X, Screen.PrimaryScreen.WorkingArea.Top)
                    Me.Location = twoDAEditorWindowLoc
                    height = Screen.PrimaryScreen.WorkingArea.Height
                    size = Me.Size
                    size2 = New Size(size.Width, height)
                    Me.Size = size2
                End If
                size2 = settings.TwoDAEditorWindowSize
                Dim width As Integer
                If size2.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                    Dim left As Integer = Screen.PrimaryScreen.WorkingArea.Left
                    Dim point As Point = Me.Location
                    Dim twoDAEditorWindowLoc As Point = New Point(left, point.Y)
                    Me.Location = twoDAEditorWindowLoc
                    width = Screen.PrimaryScreen.WorkingArea.Width
                    Dim num As Integer = width
                    size2 = Me.Size
                    size = New Size(num, size2.Height)
                    Me.Size = size
                End If
                If (width = 0) And (height = 0) Then
                    Me.Size = settings.TwoDAEditorWindowSize
                End If
            End If
        End Sub

        ' Token: 0x060001B7 RID: 439 RVA: 0x00228344 File Offset: 0x00227344
        Public Sub SaveSettings()
            Dim settings As Options = UserSettings.GetSettings()
            settings.TwoDAEditorWindowLoc = Me.Location
            settings.TwoDAEditorWindowSize = Me.Size
            UserSettings.SaveSettings(settings)
        End Sub

        ' Token: 0x060001B8 RID: 440 RVA: 0x00228378 File Offset: 0x00227378
        Private Sub cmiShowStrings_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.KotorVersionIndex = -1 Then
                Dim frmSpecifyKotorVersion As frmSpecifyKotorVersion = New frmSpecifyKotorVersion()
                If frmSpecifyKotorVersion.ShowDialog() <> DialogResult.OK Then
                    Return
                End If
                Me.KotorVersionIndex = frmSpecifyKotorVersion.KotorVerIndexSelected
            End If
            Me.getDialogTlk()
            Dim text As String = Me.dt.Columns(Me.gClickedColumn).ColumnName + " (Strs)"
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dt.Columns.Count - 1
            Dim num3 As Integer = num
            While num3 <= num2 AndAlso StringType.StrCmp(Me.dt.Columns(num3).ColumnName, text, False) <> 0
                num3 += 1
            End While
            Dim num4 As Integer
            If num3 = Me.dt.Columns.Count Then
                num4 = Me.InsertColumn(text)
            Else
                num4 = num3
            End If
            Dim num5 As Integer = 0
            Dim num6 As Integer = Me.dt.Rows.Count - 1
            For i As Integer = num5 To num6
                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.dg2DA(i, Me.gClickedColumn))
                If Information.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) Then
                    If ObjectType.ObjTst(objectValue, -1, False) > 0 Then
                        Me.dg2DA(i, num4) = Me.g_DialogTlk.GetString(IntegerType.FromObject(objectValue))
                    Else
                        Me.dg2DA(i, num4) = ""
                    End If
                End If
            Next
        End Sub

        ' Token: 0x060001B9 RID: 441 RVA: 0x002284CC File Offset: 0x002274CC
        Private Sub dt_ColumnChanged(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
            If e.Column.ColumnName.EndsWith("(Strs)") Then
                Return
            End If
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(e.ProposedValue)
            If Information.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) AndAlso ObjectType.ObjTst(Me.IndexOfColumnName(e.Column.ColumnName + " (Strs)"), -1, False) > 0 Then
                Me.dg2DA(Me.dg2DA.CurrentCell.RowNumber, IntegerType.FromObject(Me.IndexOfColumnName(e.Column.ColumnName + " (Strs)"))) = Me.g_DialogTlk.GetString(IntegerType.FromObject(objectValue))
            End If
        End Sub

        ' Token: 0x060001BA RID: 442 RVA: 0x00228584 File Offset: 0x00227584
        Private Function IndexOfColumnName(ByVal name As String) As Object
            Dim num As Integer = -1
            Dim num2 As Integer = 0
            Dim num3 As Integer = Me.dt.Columns.Count - 1
            For i As Integer = num2 To num3
                If StringType.StrCmp(Me.dt.Columns(i).ColumnName.ToLower(), name.ToLower(), False) = 0 Then
                    num = i
                    Exit For
                End If
            Next
            Return num
        End Function

        ' Token: 0x060001BB RID: 443 RVA: 0x002285E8 File Offset: 0x002275E8
        Private Sub frm2DAEditor_Move(ByVal sender As Object, ByVal e As EventArgs)
            Me.SaveSettings()
        End Sub

        ' Token: 0x060001BC RID: 444 RVA: 0x002285F0 File Offset: 0x002275F0
        Private Sub miSetKotORversion_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmSpecifyKotorVersion As frmSpecifyKotorVersion = New frmSpecifyKotorVersion()
            Select Case Me.KotorVersionIndex
                Case 0
                    frmSpecifyKotorVersion.rbKotor1.Checked = True
                Case 1
                    frmSpecifyKotorVersion.rbKotor2.Checked = True
            End Select
            If frmSpecifyKotorVersion.ShowDialog() <> DialogResult.OK Then
                Return
            End If
            Me.KotorVersionIndex = frmSpecifyKotorVersion.KotorVerIndexSelected
            If Me.KotorVersionIndex = 0 Then
                Me.Text = "2DA Editor - Kotor I"
            ElseIf Me.KotorVersionIndex = 1 Then
                Me.Text = "2DA Editor - Kotor II"
            End If
            If (Me.LastKotorVersionIndex <> Me.KotorVersionIndex) And (Me.g_DialogTlk IsNot Nothing) Then
                Me.g_DialogTlk = New clsDialogTlk(UserSettings.GetSettings().KotorLocation(Me.KotorVersionIndex) + "\dialog.tlk", False)
                If Me.numColumns + 1 < Me.dt.Columns.Count Then
                    Interaction.MsgBox("The columns added via the Show Strings function are being removed as the strings may not match between game versions.", MsgBoxStyle.Information, "")
                    Dim num As Integer = Me.dt.Columns.Count - 1
                    Dim num2 As Integer = Me.numColumns + 1
                    For i As Integer = num To num2 Step -1
                        Me.dt.Columns.RemoveAt(i)
                    Next
                End If
            End If
            Me.LastKotorVersionIndex = Me.KotorVersionIndex
        End Sub

        ' Token: 0x060001BD RID: 445 RVA: 0x0022872C File Offset: 0x0022772C
        Private Function getDialogTlk() As clsDialogTlk
            If Me.g_DialogTlk Is Nothing Then
                Me.g_DialogTlk = New clsDialogTlk(UserSettings.GetSettings().KotorLocation(Me.KotorVersionIndex) + "\dialog.tlk", False)
            End If
            Return Me.g_DialogTlk
        End Function

        ' Token: 0x060001BE RID: 446 RVA: 0x00228770 File Offset: 0x00227770
        Private Sub miTestFunction_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
            obj = RuntimeHelpers.GetObjectValue(frm2DAEditor.GetPrivateField(Me.dg2DA, "DataGridRows"))
        End Sub

        ' Token: 0x060001BF RID: 447 RVA: 0x002287A0 File Offset: 0x002277A0
        Public Shared Function GetPrivateField(ByVal PassedObject As Object, ByVal FieldName As String) As Object
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(New Object())
            If PassedObject Is Nothing Then
                Throw New ArgumentNullException("PassedObject", "PassedObject must be an instantiated object.")
            End If
            If FieldName Is Nothing OrElse StringType.StrCmp(FieldName.Trim(), "", False) = 0 Then
                Throw New ArgumentOutOfRangeException("FieldName", "Fieldname must be a non empty string.")
            End If
            Dim type As Type = PassedObject.[GetType]()
            Dim field As FieldInfo = type.GetField(FieldName, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.NonPublic)
            If field Is Nothing Then
                Throw New ArgumentOutOfRangeException("FieldName", type.FullName + " does not have a field : " + FieldName + ".")
            End If
            Return RuntimeHelpers.GetObjectValue(field.GetValue(RuntimeHelpers.GetObjectValue(PassedObject)))
        End Function

        ' Token: 0x060001C0 RID: 448 RVA: 0x0022883C File Offset: 0x0022783C
        Private Sub SetPrivateProperty(ByVal PassedObject As Object, ByVal PropertyName As String, ByVal value As Object)
            Dim baseType As Type = PassedObject.[GetType]().BaseType
            Dim [property] As PropertyInfo = baseType.GetProperty(PropertyName, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.NonPublic)
            If [property] IsNot Nothing Then
                [property].SetValue(RuntimeHelpers.GetObjectValue(PassedObject), RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(value), [property].PropertyType)), Nothing)
            End If
        End Sub

        ' Token: 0x04000124 RID: 292
        <AccessedThroughProperty("dt")> _
        Private _dt As DataTable

        ' Token: 0x04000125 RID: 293
        <AccessedThroughProperty("cmiInsertRow")> _
        Private _cmiInsertRow As MenuItem

        ' Token: 0x04000127 RID: 295
        <AccessedThroughProperty("cmiPasteRow")> _
        Private _cmiPasteRow As MenuItem

        ' Token: 0x04000128 RID: 296
        <AccessedThroughProperty("cmiInsertCopiedRow")> _
        Private _cmiInsertCopiedRow As MenuItem

        ' Token: 0x0400012B RID: 299
        <AccessedThroughProperty("cmiRenumberRowLabelColumn")> _
        Private _cmiRenumberRowLabelColumn As MenuItem

        ' Token: 0x0400012C RID: 300
        <AccessedThroughProperty("cmiShowStrings")> _
        Private _cmiShowStrings As MenuItem

        ' Token: 0x0400012D RID: 301
        <AccessedThroughProperty("cm")> _
        Private _cm As ContextMenu

        ' Token: 0x0400012F RID: 303
        <AccessedThroughProperty("cmiCopyRow")> _
        Private _cmiCopyRow As MenuItem

        ' Token: 0x0400013C RID: 316
        Private DView As DataView

        ' Token: 0x0400013D RID: 317
        Private lastGDcell As DataGridCell

        ' Token: 0x0400013E RID: 318
        Private ary2da As Byte()

        ' Token: 0x0400013F RID: 319
        Private fname As String

        ' Token: 0x04000140 RID: 320
        Private numRows As Integer

        ' Token: 0x04000141 RID: 321
        Private numColumns As Integer

        ' Token: 0x04000142 RID: 322
        Private colNames As String()

        ' Token: 0x04000143 RID: 323
        Private rowLabels As String()

        ' Token: 0x04000144 RID: 324
        Private gClickedRow As Integer

        ' Token: 0x04000145 RID: 325
        Private gClickedColumn As Integer

        ' Token: 0x04000146 RID: 326
        Private XMLfilepath As String

        ' Token: 0x04000147 RID: 327
        Private filetype As String

        ' Token: 0x04000148 RID: 328
        Private clipboardDataRow As DataRow

        ' Token: 0x04000149 RID: 329
        Private KotorVersionIndex As Integer

        ' Token: 0x0400014A RID: 330
        Private LastKotorVersionIndex As Integer

        ' Token: 0x0400014B RID: 331
        Private g_DialogTlk As clsDialogTlk

        ' Token: 0x0200003D RID: 61
        Public Class TwoDADataGrid
            Inherits DataGrid

            ' Token: 0x060001C2 RID: 450 RVA: 0x00228890 File Offset: 0x00227890
            Public Sub ScrollToRow(ByVal row As Integer)
                If Me.DataSource IsNot Nothing Then
                    Me.GridVScrolled(Me, New ScrollEventArgs(ScrollEventType.LargeIncrement, row))
                End If
            End Sub
        End Class
    End Class
End Namespace
