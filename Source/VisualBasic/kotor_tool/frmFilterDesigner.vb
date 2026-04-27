Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200004C RID: 76
	Public Partial Class frmFilterDesigner
		Inherits Form

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x060004D7 RID: 1239 RVA: 0x0023EEC4 File Offset: 0x0023DEC4
		Public ReadOnly Property filterString As String
			Get
				Return StringType.FromObject(Me.RF.FilterString())
			End Get
		End Property

		' Token: 0x060004D8 RID: 1240 RVA: 0x0023EEE4 File Offset: 0x0023DEE4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmFilterDesigner_Load
			Me.m_HandlersActive = True
			Me.RF = New RowFilter()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060004D9 RID: 1241 RVA: 0x0023EF18 File Offset: 0x0023DF18
		Public Sub New(ColumnList As ColumnEntryList)
			Me.New()
			Me.m_ColumnList = ColumnList
			Me.cmbxColumnName1.DataSource = Me.m_ColumnList
			Me.cmbxColumnName1.DisplayMember = "displayColName"
			Me.cmbxColumnName1.ValueMember = "nativeColName"
		End Sub

		' Token: 0x060004DA RID: 1242 RVA: 0x0023EF58 File Offset: 0x0023DF58
		Public Sub New(ColumnList As ColumnEntryList, RowFilter As RowFilter)
			Me.New(ColumnList)
			Me.RF = RowFilter
			Me.BuildGuiFromRowFilterList()
		End Sub

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x060004DD RID: 1245 RVA: 0x0023EFAC File Offset: 0x0023DFAC
		' (set) Token: 0x060004DC RID: 1244 RVA: 0x0023EF90 File Offset: 0x0023DF90
		Friend Overridable Property tbCriteria1 As TextBox
			Get
				Return Me._tbCriteria1
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCriteria1 IsNot Nothing Then
                End If
                Me._tbCriteria1 = value
                If Me._tbCriteria1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000170 RID: 368
        ' (get) Token: 0x060004DF RID: 1247 RVA: 0x0023F014 File Offset: 0x0023E014
        ' (set) Token: 0x060004DE RID: 1246 RVA: 0x0023EFC0 File Offset: 0x0023DFC0
        Friend Overridable Property btnOK() As Button
            Get
                Return Me._btnOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                    RemoveHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                    AddHandler Me._btnOK.Click, AddressOf Me.btnOK_Click
                End If
            End Set
        End Property

        ' Token: 0x17000171 RID: 369
        ' (get) Token: 0x060004E1 RID: 1249 RVA: 0x0023F044 File Offset: 0x0023E044
        ' (set) Token: 0x060004E0 RID: 1248 RVA: 0x0023F028 File Offset: 0x0023E028
        Friend Overridable Property btnCancel() As Button
            Get
                Return Me._btnCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnCancel IsNot Nothing Then
                End If
                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000172 RID: 370
        ' (get) Token: 0x060004E2 RID: 1250 RVA: 0x0023F058 File Offset: 0x0023E058
        ' (set) Token: 0x060004E3 RID: 1251 RVA: 0x0023F06C File Offset: 0x0023E06C
        Friend Overridable Property btnReset() As Button
            Get
                Return Me._btnReset
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnReset IsNot Nothing Then
                    RemoveHandler Me._btnReset.Click, AddressOf Me.btnReset_Click
                End If
                Me._btnReset = value
                If Me._btnReset IsNot Nothing Then
                    AddHandler Me._btnReset.Click, AddressOf Me.btnReset_Click
                End If
            End Set
        End Property

        ' Token: 0x17000173 RID: 371
        ' (get) Token: 0x060004E4 RID: 1252 RVA: 0x0023F0C0 File Offset: 0x0023E0C0
        ' (set) Token: 0x060004E5 RID: 1253 RVA: 0x0023F0D4 File Offset: 0x0023E0D4
        Friend Overridable Property cmbxMatchOperator1() As ComboBox
            Get
                Return Me._cmbxMatchOperator1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxMatchOperator1 IsNot Nothing Then
                End If
                Me._cmbxMatchOperator1 = value
                If Me._cmbxMatchOperator1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000174 RID: 372
        ' (get) Token: 0x060004E6 RID: 1254 RVA: 0x0023F0F0 File Offset: 0x0023E0F0
        ' (set) Token: 0x060004E7 RID: 1255 RVA: 0x0023F104 File Offset: 0x0023E104
        Friend Overridable Property cmbxConcatOperator1() As ComboBox
            Get
                Return Me._cmbxConcatOperator1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxConcatOperator1 IsNot Nothing Then
                End If
                Me._cmbxConcatOperator1 = value
                If Me._cmbxConcatOperator1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000175 RID: 373
        ' (get) Token: 0x060004E8 RID: 1256 RVA: 0x0023F120 File Offset: 0x0023E120
        ' (set) Token: 0x060004E9 RID: 1257 RVA: 0x0023F134 File Offset: 0x0023E134
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

        ' Token: 0x17000176 RID: 374
        ' (get) Token: 0x060004EA RID: 1258 RVA: 0x0023F150 File Offset: 0x0023E150
        ' (set) Token: 0x060004EB RID: 1259 RVA: 0x0023F164 File Offset: 0x0023E164
        Friend Overridable Property btnAddFilter() As Button
            Get
                Return Me._btnAddFilter
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnAddFilter IsNot Nothing Then
                    RemoveHandler Me._btnAddFilter.Click, AddressOf Me.btnAddFilter_Click
                End If
                Me._btnAddFilter = value
                If Me._btnAddFilter IsNot Nothing Then
                    AddHandler Me._btnAddFilter.Click, AddressOf Me.btnAddFilter_Click
                End If
            End Set
        End Property

        ' Token: 0x17000177 RID: 375
        ' (get) Token: 0x060004ED RID: 1261 RVA: 0x0023F1B8 File Offset: 0x0023E1B8
        ' (set) Token: 0x060004EC RID: 1260 RVA: 0x0023F1CC File Offset: 0x0023E1CC
        Friend Overridable Property cmbxColumnName1() As ComboBox
            Get
                Return Me._cmbxColumnName1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxColumnName1 IsNot Nothing Then
                End If
                Me._cmbxColumnName1 = value
                If Me._cmbxColumnName1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000178 RID: 376
        ' (get) Token: 0x060004EF RID: 1263 RVA: 0x0023F204 File Offset: 0x0023E204
        ' (set) Token: 0x060004EE RID: 1262 RVA: 0x0023F1E8 File Offset: 0x0023E1E8
        Friend Overridable Property btnRemove1() As Button
            Get
                Return Me._btnRemove1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnRemove1 IsNot Nothing Then
                End If
                Me._btnRemove1 = value
                If Me._btnRemove1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000179 RID: 377
        ' (get) Token: 0x060004F0 RID: 1264 RVA: 0x0023F218 File Offset: 0x0023E218
        ' (set) Token: 0x060004F1 RID: 1265 RVA: 0x0023F22C File Offset: 0x0023E22C
        Friend Overridable Property HelpProvider1() As HelpProvider
            Get
                Return Me._HelpProvider1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As HelpProvider)
                If Me._HelpProvider1 IsNot Nothing Then
                End If
                Me._HelpProvider1 = value
                If Me._HelpProvider1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x060004F3 RID: 1267 RVA: 0x0023F9B4 File Offset: 0x0023E9B4
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.RF.FilterParts.Clear()
            Dim num As Integer = 1
            Dim num2 As Integer = Me.FilterControlCount()
            For i As Integer = num To num2
                Dim comboBox As ComboBox = CType(Me.FindControl("cn" + StringType.FromInteger(i)), ComboBox)
                Dim textBox As TextBox = CType(Me.FindControl("cr" + StringType.FromInteger(i)), TextBox)
                Dim comboBox2 As ComboBox = CType(Me.FindControl("mo" + StringType.FromInteger(i)), ComboBox)
                If (comboBox.SelectedIndex <> -1) And (StringType.StrCmp(textBox.Text, "", False) <> 0) And (comboBox2.SelectedIndex <> -1) Then
                    Dim comboBox3 As ComboBox = CType(Me.FindControl("co" + StringType.FromInteger(i)), ComboBox)
                    Me.RF.FilterParts.Add(New RowFilterPart(CType(comboBox.SelectedItem, ColumnEntry).nativeColName, CType(comboBox.SelectedItem, ColumnEntry).displayColName, StringType.FromObject(comboBox2.SelectedItem), textBox.Text, StringType.FromObject(comboBox3.SelectedItem), CType(comboBox.SelectedItem, ColumnEntry).data_type.Name))
                End If
            Next
            Me.DialogResult = DialogResult.OK
            Me.Hide()
        End Sub

        ' Token: 0x060004F4 RID: 1268 RVA: 0x0023FB0C File Offset: 0x0023EB0C
        Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.m_HandlersActive = False
            Dim num As Integer = 1
            Dim num2 As Integer = Me.FilterControlCount()
            For i As Integer = num To num2
                CType(Me.FindControl("cn" + StringType.FromInteger(i)), ComboBox).SelectedIndex = -1
                CType(Me.FindControl("mo" + StringType.FromInteger(i)), ComboBox).SelectedIndex = -1
                CType(Me.FindControl("co" + StringType.FromInteger(i)), ComboBox).SelectedIndex = 0
                CType(Me.FindControl("cr" + StringType.FromInteger(i)), TextBox).Text = ""
            Next
            Me.m_HandlersActive = True
        End Sub

        ' Token: 0x060004F5 RID: 1269 RVA: 0x0023FBC8 File Offset: 0x0023EBC8
        Private Sub btnAddFilter_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AddFilterRow()
        End Sub

        ' Token: 0x060004F6 RID: 1270 RVA: 0x0023FBD0 File Offset: 0x0023EBD0
        Private Function FindControl(ByVal tagName As String) As Control
            Dim control2 As Control
            Try
                For Each obj As Object In Me.Controls
                    Dim control As Control = CType(obj, Control)
                    If ObjectType.ObjTst(control.Tag, tagName, False) = 0 Then
                        control2 = control
                        Exit For
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return control2
        End Function

        ' Token: 0x060004F7 RID: 1271 RVA: 0x0023FC3C File Offset: 0x0023EC3C
        Private Function FilterControlCount() As Integer
            ' The following expression was wrapped in a checked-statement
            Dim num As Integer
            Try
                For Each obj As Object In Me.Controls
                    Dim control As Control = CType(obj, Control)
                    If StringType.StrCmp(Strings.Mid(StringType.FromObject(control.Tag), 1, 2), "cn", False) = 0 Then
                        num += 1
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return num
        End Function

        ' Token: 0x060004F8 RID: 1272 RVA: 0x0023FCB8 File Offset: 0x0023ECB8
        Private Sub BuildGuiFromRowFilterList()
            ' The following expression was wrapped in a checked-statement
            If Me.RF.FilterParts.Count > 1 Then
                Dim num As Integer = 1
                Dim num2 As Integer = Me.RF.FilterParts.Count - 1
                For i As Integer = num To num2
                    Me.AddFilterRow()
                Next
            End If
            Dim num3 As Integer = 1
            Dim count As Integer = Me.RF.FilterParts.Count
            For i As Integer = num3 To count
                Dim comboBox As ComboBox = CType(Me.FindControl("cn" + StringType.FromInteger(i)), ComboBox)
                Dim comboBox2 As ComboBox = CType(Me.FindControl("mo" + StringType.FromInteger(i)), ComboBox)
                Dim textBox As TextBox = CType(Me.FindControl("cr" + StringType.FromInteger(i)), TextBox)
                Dim comboBox3 As ComboBox = CType(Me.FindControl("co" + StringType.FromInteger(i)), ComboBox)
                Dim rowFilterPart As RowFilterPart = CType(Me.RF.FilterParts(i - 1), RowFilterPart)
                comboBox.SelectedIndex = comboBox.FindStringExact(rowFilterPart.displayColumnName)
                comboBox2.SelectedIndex = comboBox2.FindStringExact(rowFilterPart.matchOperator)
                textBox.Text = rowFilterPart.filterText
                comboBox3.SelectedIndex = comboBox3.FindStringExact(rowFilterPart.concatOperator)
            Next
        End Sub

        ' Token: 0x060004F9 RID: 1273 RVA: 0x0023FDF8 File Offset: 0x0023EDF8
        Private Sub AddFilterRow()
            Me.SuspendLayout()
            Dim num As Integer = Me.FilterControlCount() + 1
            Dim comboBox As ComboBox = New ComboBox()
            comboBox.Tag = "cn" + StringType.FromInteger(num)
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList
            Dim control As Control = comboBox
            Dim x As Integer = Me.cmbxColumnName1.Location.X
            Dim location As Point = Me.cmbxColumnName1.Location
            Dim point As Point = New Point(x, location.Y + 25 * (num - 1))
            control.Location = point
            comboBox.Size = Me.cmbxColumnName1.Size
            comboBox.TabIndex = (num - 1) * 5 + 1
            Try
                For Each obj As Object In Me.cmbxColumnName1.Items
                    Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
                    comboBox.Items.Add(RuntimeHelpers.GetObjectValue(objectValue))
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            comboBox.DisplayMember = "displayColName"
            comboBox.ValueMember = "nativeColName"
            AddHandler comboBox.SelectedIndexChanged, AddressOf Me.cmbxColumnName_SelectedIndexChanged
            Dim comboBox2 As ComboBox = New ComboBox()
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList
            comboBox2.Items.AddRange(New Object() {"LIKE", "NOT LIKE", "=", "<>", "<", ">", "<=", ">=", "IN", "NOT IN"})
            comboBox2.Tag = "mo" + StringType.FromInteger(num)
            Dim control2 As Control = comboBox2
            Dim x2 As Integer = Me.cmbxMatchOperator1.Location.X
            point = Me.cmbxMatchOperator1.Location
            location = New Point(x2, point.Y + 25 * (num - 1))
            control2.Location = location
            comboBox2.Size = Me.cmbxMatchOperator1.Size
            comboBox2.MaxDropDownItems = 10
            comboBox2.TabIndex = (num - 1) * 5 + 2
            Dim textBox As TextBox = New TextBox()
            textBox.Tag = "cr" + StringType.FromInteger(num)
            Dim control3 As Control = textBox
            Dim x3 As Integer = Me.tbCriteria1.Location.X
            point = Me.tbCriteria1.Location
            location = New Point(x3, point.Y + 25 * (num - 1))
            control3.Location = location
            textBox.Size = Me.tbCriteria1.Size
            textBox.TabIndex = (num - 1) * 5 + 3
            Dim comboBox3 As ComboBox = New ComboBox()
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList
            comboBox3.Items.AddRange(New Object() {"", "AND", "OR"})
            comboBox3.Tag = "co" + StringType.FromInteger(num)
            Dim control4 As Control = comboBox3
            Dim x4 As Integer = Me.cmbxConcatOperator1.Location.X
            point = Me.cmbxConcatOperator1.Location
            location = New Point(x4, point.Y + 25 * (num - 1))
            control4.Location = location
            comboBox3.Size = Me.cmbxConcatOperator1.Size
            comboBox3.TabIndex = (num - 1) * 5 + 4
            AddHandler comboBox3.SelectedIndexChanged, AddressOf Me.cmbxConcatOperator_SelectedIndexChanged
            Dim button As Button = New Button()
            button.Text = "X"
            Dim control5 As Control = button
            Dim size As Size = New Size(21, 21)
            control5.Size = size
            button.Tag = "rb" + StringType.FromInteger(num)
            button.TabIndex = (num - 1) * 5 + 5
            Dim control6 As Control = button
            Dim x5 As Integer = Me.btnRemove1.Location.X
            point = Me.btnRemove1.Location
            location = New Point(x5, point.Y + 25 * (num - 1))
            control6.Location = location
            AddHandler button.Click, AddressOf Me.btnRemove_Click
            Me.Controls.AddRange(New Control() {comboBox, comboBox2, textBox, comboBox3, button})
            Me.ResizeAndMoveButtons(25)
            Me.ResumeLayout(False)
        End Sub

        ' Token: 0x060004FA RID: 1274 RVA: 0x00240240 File Offset: 0x0023F240
        Private Sub RemoveFilterRow(ByVal InstanceNum As Integer)
            Me.SuspendLayout()
            Me.MoveControlsUp(InstanceNum)
            Me.RenumberControls(InstanceNum + 1)
            Me.Controls.Remove(Me.FindControl("cn" + StringType.FromInteger(InstanceNum)))
            Me.Controls.Remove(Me.FindControl("mo" + StringType.FromInteger(InstanceNum)))
            Me.Controls.Remove(Me.FindControl("cr" + StringType.FromInteger(InstanceNum)))
            Me.Controls.Remove(Me.FindControl("co" + StringType.FromInteger(InstanceNum)))
            Me.Controls.Remove(Me.FindControl("rb" + StringType.FromInteger(InstanceNum)))
            Me.ResizeAndMoveButtons(-25)
            Me.ResumeLayout()
        End Sub

        ' Token: 0x060004FB RID: 1275 RVA: 0x00240318 File Offset: 0x0023F318
        Private Sub RenumberControls(ByVal startControlInstanceNum As Integer)
            Dim num As Integer = Me.FilterControlCount()
            For i As Integer = startControlInstanceNum To num
                Dim control As Control = Me.FindControl("cn" + StringType.FromInteger(i))
                control.Tag = "cn" + StringType.FromInteger(i - 1)
                control = Me.FindControl("mo" + StringType.FromInteger(i))
                control.Tag = "mo" + StringType.FromInteger(i - 1)
                control = Me.FindControl("cr" + StringType.FromInteger(i))
                control.Tag = "cr" + StringType.FromInteger(i - 1)
                control = Me.FindControl("co" + StringType.FromInteger(i))
                control.Tag = "co" + StringType.FromInteger(i - 1)
                control = Me.FindControl("rb" + StringType.FromInteger(i))
                control.Tag = "rb" + StringType.FromInteger(i - 1)
            Next
        End Sub

        ' Token: 0x060004FC RID: 1276 RVA: 0x0024042C File Offset: 0x0023F42C
        Private Sub MoveControlsUp(ByVal startControlInstanceNum As Integer)
            Dim num As Integer = Me.FilterControlCount()
            For i As Integer = startControlInstanceNum To num
                Dim control As Control = Me.FindControl("cn" + StringType.FromInteger(i))
                Dim control2 As Control = control
                Dim x As Integer = control.Location.X
                Dim location As Point = control.Location
                Dim point As Point = New Point(x, location.Y - 25)
                control2.Location = point
                control = Me.FindControl("mo" + StringType.FromInteger(i))
                Dim control3 As Control = control
                Dim x2 As Integer = control.Location.X
                point = control.Location
                location = New Point(x2, point.Y - 25)
                control3.Location = location
                control = Me.FindControl("cr" + StringType.FromInteger(i))
                Dim control4 As Control = control
                Dim x3 As Integer = control.Location.X
                point = control.Location
                location = New Point(x3, point.Y - 25)
                control4.Location = location
                control = Me.FindControl("co" + StringType.FromInteger(i))
                Dim control5 As Control = control
                Dim x4 As Integer = control.Location.X
                point = control.Location
                location = New Point(x4, point.Y - 25)
                control5.Location = location
                control = Me.FindControl("rb" + StringType.FromInteger(i))
                Dim control6 As Control = control
                Dim x5 As Integer = control.Location.X
                point = control.Location
                location = New Point(x5, point.Y - 25)
                control6.Location = location
            Next
        End Sub

        ' Token: 0x060004FD RID: 1277 RVA: 0x002405B0 File Offset: 0x0023F5B0
        Private Sub ResizeAndMoveButtons(ByVal SizeY As Integer)
            ' The following expression was wrapped in a checked-statement
            Dim size As Size = New Size(Me.Size.Width, Me.Size.Height + SizeY)
            Me.Size = size
            Dim btnOK As Control = Me.btnOK
            Dim location As Point = Me.btnOK.Location
            Dim x As Integer = location.X
            size = Me.Size
            Dim point As Point = New Point(x, size.Height - 70)
            btnOK.Location = point
            Dim btnCancel As Control = Me.btnCancel
            point = Me.btnCancel.Location
            Dim x2 As Integer = point.X
            size = Me.Size
            location = New Point(x2, size.Height - 70)
            btnCancel.Location = location
            Dim btnReset As Control = Me.btnReset
            point = Me.btnReset.Location
            Dim x3 As Integer = point.X
            size = Me.Size
            location = New Point(x3, size.Height - 70)
            btnReset.Location = location
            Dim btnAddFilter As Control = Me.btnAddFilter
            point = Me.btnAddFilter.Location
            Dim x4 As Integer = point.X
            size = Me.Size
            location = New Point(x4, size.Height - 126)
            btnAddFilter.Location = location
        End Sub

        ' Token: 0x060004FE RID: 1278 RVA: 0x002406C8 File Offset: 0x0023F6C8
        Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.RemoveFilterRow(IntegerType.FromString(Strings.Mid(StringType.FromObject(CType(sender, Control).Tag), 3)))
        End Sub

        ' Token: 0x060004FF RID: 1279 RVA: 0x002406EC File Offset: 0x0023F6EC
        Private Sub cmbxColumnName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.m_HandlersActive Then
                Me.SetupMatchOperatorCB(CType(sender, ComboBox))
            End If
        End Sub

        ' Token: 0x06000500 RID: 1280 RVA: 0x00240704 File Offset: 0x0023F704
        Private Sub SetupMatchOperatorCB(ByVal BrotherColNameCB As ComboBox)
            Dim data_type As Type = CType(BrotherColNameCB.SelectedItem, ColumnEntry).data_type
            Dim comboBox As ComboBox = CType(Me.FindControl("mo" + Strings.Mid(StringType.FromObject(BrotherColNameCB.Tag), 3)), ComboBox)
            Dim text As String = comboBox.Text
            comboBox.Items.Clear()
            If data_type Is GetType(String) Then
                comboBox.Items.AddRange(New Object() {"LIKE", "NOT LIKE", "=", "<>", "<", ">", "<=", ">=", "IN", "NOT IN"})
            ElseIf (data_type Is GetType(Integer)) Or (data_type Is GetType(DateTime)) Then
                comboBox.Items.AddRange(New Object() {"=", "<>", "<", ">", "<=", ">="})
            End If
            comboBox.SelectedIndex = comboBox.FindStringExact(text)
        End Sub

        ' Token: 0x06000501 RID: 1281 RVA: 0x0024083C File Offset: 0x0023F83C
        Private Sub cmbxConcatOperator_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' The following expression was wrapped in a checked-expression
            If Me.m_HandlersActive AndAlso CType(sender, ComboBox).SelectedIndex <> 0 AndAlso Me.FindControl("cn" + StringType.FromInteger(IntegerType.FromString(Strings.Mid(StringType.FromObject(CType(sender, Control).Tag), 3)) + 1)) Is Nothing Then
                Me.AddFilterRow()
            End If
        End Sub

        ' Token: 0x06000502 RID: 1282 RVA: 0x0024089C File Offset: 0x0023F89C
        Private Sub frmFilterDesigner_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetupMatchOperatorCB(Me.cmbxColumnName1)
            AddHandler Me.cmbxColumnName1.SelectedIndexChanged, AddressOf Me.cmbxColumnName_SelectedIndexChanged
            AddHandler Me.cmbxConcatOperator1.SelectedIndexChanged, AddressOf Me.cmbxConcatOperator_SelectedIndexChanged
            AddHandler Me.btnRemove1.Click, AddressOf Me.btnRemove_Click
        End Sub

        ' Token: 0x0400029E RID: 670
        <AccessedThroughProperty("btnReset")> _
        Private _btnReset As Button

        ' Token: 0x0400029F RID: 671
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider

        ' Token: 0x040002A0 RID: 672
        <AccessedThroughProperty("cmbxConcatOperator1")> _
        Private _cmbxConcatOperator1 As ComboBox

        ' Token: 0x040002A1 RID: 673
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x040002A2 RID: 674
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040002A3 RID: 675
        <AccessedThroughProperty("btnRemove1")> _
        Private _btnRemove1 As Button

        ' Token: 0x040002A4 RID: 676
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040002A5 RID: 677
        <AccessedThroughProperty("tbCriteria1")> _
        Private _tbCriteria1 As TextBox

        ' Token: 0x040002A6 RID: 678
        <AccessedThroughProperty("cmbxColumnName1")> _
        Private _cmbxColumnName1 As ComboBox

        ' Token: 0x040002A7 RID: 679
        <AccessedThroughProperty("cmbxMatchOperator1")> _
        Private _cmbxMatchOperator1 As ComboBox

        ' Token: 0x040002A8 RID: 680
        <AccessedThroughProperty("btnAddFilter")> _
        Private _btnAddFilter As Button

        ' Token: 0x040002A9 RID: 681
        Private m_ColumnList As ColumnEntryList

        ' Token: 0x040002AA RID: 682
        Private m_HandlersActive As Boolean

        ' Token: 0x040002AB RID: 683
        Public RF As RowFilter

        ' Token: 0x040002AC RID: 684
        Private Const FILTERCONTROLSPACING As Integer = 25
    End Class
End Namespace
