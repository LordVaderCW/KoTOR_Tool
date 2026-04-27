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
