Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace kotor_tool
	' Token: 0x02000059 RID: 89
	Public Partial Class frmMapInfoStatus
		Inherits Form

		' Token: 0x0600076B RID: 1899 RVA: 0x00258B40 File Offset: 0x00257B40
		Public Sub New()
			Me.dt = New DataTable()
			Me.g_mapsPath = Path.Combine(frmMain.GetApplicationRootPath(), "maps\")
			Me.InitializeComponent()
			Me.BuildDataGrid()
			Me.Map_Info = frmMapInfoStatus.ReadMapInfoFile()
			Me.ShowStatus()
			Me.AutoSizeColumns()
			Me.Width = Me.g_totalColWidth + 80
		End Sub

		' Token: 0x06000770 RID: 1904 RVA: 0x00258D58 File Offset: 0x00257D58
        Public Shared Function ReadMapInfoFile() As MapInfo
            Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
            Dim stream As Stream = File.OpenRead(frmMain.gRootPath + "MapInfo.bfd")
            Dim mapInfo As MapInfo
            Try
                mapInfo = CType(binaryFormatter.Deserialize(stream), MapInfo)
                stream.Close()
            Catch ex As System.Exception
                stream.Seek(0L, SeekOrigin.Begin)
                binaryFormatter = frmMapInfoStatus.CreateMapInfoFormatter(Type.[GetType]("kotor_tool.MapInfo"))
                mapInfo = CType(binaryFormatter.Deserialize(stream), MapInfo)
                stream.Close()
                If mapInfo.[GetType]() Is Type.[GetType]("kotor_tool.MapInfo") Then
                    stream = File.OpenWrite(frmMain.gRootPath + "MapInfo.bfd")
                    binaryFormatter = New BinaryFormatter()
                    binaryFormatter.Serialize(stream, mapInfo)
                    stream.Close()
                Else
                    Interaction.MsgBox("Unable to load MapInfo.bfd file." & vbLf & vbLf & "Please download a fresh copy.", MsgBoxStyle.Critical, "MapInfo error")
                End If
            End Try
            Return mapInfo
        End Function

		' Token: 0x06000771 RID: 1905 RVA: 0x00258E3C File Offset: 0x00257E3C
		Public Shared Function CreateMapInfoFormatter(type As Type) As BinaryFormatter
			Dim myMapInfoSurrogate As MyMapInfoSurrogate = New MyMapInfoSurrogate(type.Assembly)
			Dim surrogateSelector As ISurrogateSelector = myMapInfoSurrogate
			Dim streamingContext As StreamingContext = New StreamingContext(StreamingContextStates.All)
			Return New BinaryFormatter(surrogateSelector, streamingContext)
		End Function

		' Token: 0x06000772 RID: 1906 RVA: 0x00258E68 File Offset: 0x00257E68
		Public Sub ShowStatus()
			Try
				For Each obj As Object In Me.Map_Info.MapList
					Dim map As MapInfo.Map = CType(obj, MapInfo.Map)
					Dim dataRow As DataRow = Me.dt.NewRow()
					dataRow(0) = map.MapName
					If map.S Then
						If File.Exists(Me.g_mapsPath + "map" + map.MapName + ".map") Then
							dataRow(1) = "Available"
						Else
							dataRow(1) = "File Missing"
						End If
					Else
						dataRow(1) = "Unsupported"
					End If
					If map.L Then
						If File.Exists(Me.g_mapsPath + "map" + map.MapName + "_lg.map") Then
							dataRow(2) = "Available"
						Else
							dataRow(2) = "File Missing"
						End If
					Else
						dataRow(2) = "Unsupported"
					End If
					dataRow(3) = map.ModuleName
					dataRow(4) = map.MapAssembler
					dataRow(5) = map.MapCalibrator
					Me.dt.Rows.Add(dataRow)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000773 RID: 1907 RVA: 0x00258FCC File Offset: 0x00257FCC
		Public Sub BuildDataTable()
			Dim dataColumn As DataColumn = New DataColumn("Map Name", GetType(String))
			dataColumn.DefaultValue = ""
			Me.dt.Columns.Add(dataColumn)
			dataColumn = New DataColumn("Small map", GetType(String))
			dataColumn.DefaultValue = ""
			Me.dt.Columns.Add(dataColumn)
			dataColumn = New DataColumn("Large map", GetType(String))
			dataColumn.DefaultValue = ""
			Me.dt.Columns.Add(dataColumn)
			dataColumn = New DataColumn("Module Description", GetType(String))
			dataColumn.DefaultValue = ""
			Me.dt.Columns.Add(dataColumn)
			dataColumn = New DataColumn("Map Assembler", GetType(String))
			dataColumn.DefaultValue = ""
			Me.dt.Columns.Add(dataColumn)
			dataColumn = New DataColumn("Map Calibrator", GetType(String))
			dataColumn.DefaultValue = ""
			Me.dt.Columns.Add(dataColumn)
		End Sub

		' Token: 0x06000774 RID: 1908 RVA: 0x00259100 File Offset: 0x00258100
		Public Sub BuildDataGrid()
			Me.BuildDataTable()
			Me.DView = Me.dt.DefaultView
			Me.DView.AllowDelete = False
			Me.DView.AllowNew = False
			Me.DView.AllowEdit = False
			Me.DView.Sort = "Map Name ASC"
			Dim dataGridTableStyle As DataGridTableStyle = New DataGridTableStyle()
			Me.dgMapInfoStatus.TableStyles.Clear()
			dataGridTableStyle.MappingName = Me.dt.TableName
			dataGridTableStyle.AlternatingBackColor = Color.FromArgb(255, 240, 240, 240)
			Dim dataGridEnableTextBoxColumn As DataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
			dataGridEnableTextBoxColumn.MappingName = "Map Name"
			dataGridEnableTextBoxColumn.HeaderText = "Map Name"
			dataGridEnableTextBoxColumn.NullText = ""
			dataGridEnableTextBoxColumn.[ReadOnly] = True
			dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
			dataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
			dataGridEnableTextBoxColumn.MappingName = "Small map"
			dataGridEnableTextBoxColumn.HeaderText = "Small map"
			dataGridEnableTextBoxColumn.NullText = ""
			dataGridEnableTextBoxColumn.[ReadOnly] = True
			dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
			dataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
			dataGridEnableTextBoxColumn.MappingName = "Large map"
			dataGridEnableTextBoxColumn.HeaderText = "Large map"
			dataGridEnableTextBoxColumn.NullText = ""
			dataGridEnableTextBoxColumn.[ReadOnly] = True
			dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
			dataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
			dataGridEnableTextBoxColumn.MappingName = "Module Description"
			dataGridEnableTextBoxColumn.HeaderText = "Module Description"
			dataGridEnableTextBoxColumn.NullText = ""
			dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
			dataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
			dataGridEnableTextBoxColumn.MappingName = "Map Assembler"
			dataGridEnableTextBoxColumn.HeaderText = "Map Assembler"
			dataGridEnableTextBoxColumn.NullText = ""
			dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
			dataGridEnableTextBoxColumn = New DataGridEnableTextBoxColumn()
			dataGridEnableTextBoxColumn.MappingName = "Map Calibrator"
			dataGridEnableTextBoxColumn.HeaderText = "Map Calibrator"
			dataGridEnableTextBoxColumn.NullText = ""
			dataGridTableStyle.GridColumnStyles.Add(dataGridEnableTextBoxColumn)
			Me.dgMapInfoStatus.TableStyles.Add(dataGridTableStyle)
			Me.dgMapInfoStatus.SetDataBinding(Me.DView, Nothing)
			Me.dgMapInfoStatus.CaptionText = "Map Status"
			Me.dgMapInfoStatus.CaptionFont = New Font("Microsoft Sans Serif", 9F)
		End Sub

		' Token: 0x06000775 RID: 1909 RVA: 0x0025933C File Offset: 0x0025833C
		Public Sub AutoSizeColumns()
			Me.g_totalColWidth = 0
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dt.Columns.Count - 1
			For i As Integer = num To num2
				Dim colWidth As Integer = Me.GetColWidth(i, Me.dt.Columns(i).Caption)
				Me.dgMapInfoStatus.TableStyles(0).GridColumnStyles(i).Width = colWidth
				Me.g_totalColWidth += colWidth
			Next
		End Sub

		' Token: 0x06000776 RID: 1910 RVA: 0x002593C0 File Offset: 0x002583C0
		Protected Function GetColWidth(col As Integer, DisplayName As String) As Integer
			Dim num As Single = 0F
			Dim count As Integer = CType(Me.dgMapInfoStatus.DataSource, DataView).Count
			Dim graphics As Graphics = Graphics.FromHwnd(Me.Handle)
			Dim stringFormat As StringFormat = New StringFormat(StringFormat.GenericTypographic)
			num = graphics.MeasureString(DisplayName, Me.Font, 500, stringFormat).Width
			Try
				Dim num2 As Integer = 0
				Dim num3 As Integer = count - 1
				For i As Integer = num2 To num3
					Dim sizeF As SizeF = graphics.MeasureString(Me.dgMapInfoStatus(i, col).ToString(), Me.Font, 500, stringFormat)
					If sizeF.Width > num Then
						num = sizeF.Width
					End If
				Next
				graphics.Dispose()
            Catch ex As System.Exception
                num = 75.0F
			End Try
			Return CInt(Math.Round(CDbl((num + 10F))))
		End Function

		' Token: 0x040003D3 RID: 979
		Private dt As DataTable

		' Token: 0x040003D4 RID: 980
		Private DView As DataView

		' Token: 0x040003D5 RID: 981
		Private Map_Info As MapInfo

		' Token: 0x040003D6 RID: 982
		Private g_mapsPath As String

		' Token: 0x040003D7 RID: 983
		Private g_totalColWidth As Integer
	End Class
End Namespace
