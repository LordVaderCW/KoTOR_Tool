Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000060 RID: 96
	Public Partial Class frmModuleEditorOptions
		Inherits Form

		' Token: 0x06000951 RID: 2385 RVA: 0x0026D910 File Offset: 0x0026C910
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170002D8 RID: 728
		' (get) Token: 0x06000954 RID: 2388 RVA: 0x0026D940 File Offset: 0x0026C940
		' (set) Token: 0x06000953 RID: 2387 RVA: 0x0026D954 File Offset: 0x0026C954
		Friend Overridable Property Label1 As Label
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

        ' Token: 0x170002D9 RID: 729
        ' (get) Token: 0x06000955 RID: 2389 RVA: 0x0026D98C File Offset: 0x0026C98C
        ' (set) Token: 0x06000956 RID: 2390 RVA: 0x0026D970 File Offset: 0x0026C970
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

        ' Token: 0x170002DA RID: 730
        ' (get) Token: 0x06000958 RID: 2392 RVA: 0x0026D9A0 File Offset: 0x0026C9A0
        ' (set) Token: 0x06000957 RID: 2391 RVA: 0x0026D9B4 File Offset: 0x0026C9B4
        Friend Overridable Property Label3() As Label
            Get
                Return Me._Label3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label3 IsNot Nothing Then
                End If
                Me._Label3 = value
                If Me._Label3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002DB RID: 731
        ' (get) Token: 0x0600095A RID: 2394 RVA: 0x0026D9D0 File Offset: 0x0026C9D0
        ' (set) Token: 0x06000959 RID: 2393 RVA: 0x0026D9E4 File Offset: 0x0026C9E4
        Friend Overridable Property chkbShowLocatorRay() As CheckBox
            Get
                Return Me._chkbShowLocatorRay
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbShowLocatorRay IsNot Nothing Then
                End If
                Me._chkbShowLocatorRay = value
                If Me._chkbShowLocatorRay IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002DC RID: 732
        ' (get) Token: 0x0600095B RID: 2395 RVA: 0x0026DA1C File Offset: 0x0026CA1C
        ' (set) Token: 0x0600095C RID: 2396 RVA: 0x0026DA00 File Offset: 0x0026CA00
        Friend Overridable Property chkbConfirmDeletes() As CheckBox
            Get
                Return Me._chkbConfirmDeletes
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbConfirmDeletes IsNot Nothing Then
                End If
                Me._chkbConfirmDeletes = value
                If Me._chkbConfirmDeletes IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002DD RID: 733
        ' (get) Token: 0x0600095D RID: 2397 RVA: 0x0026DA30 File Offset: 0x0026CA30
        ' (set) Token: 0x0600095E RID: 2398 RVA: 0x0026DA44 File Offset: 0x0026CA44
        Friend Overridable Property btnOK() As Button
            Get
                Return Me._btnOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002DE RID: 734
        ' (get) Token: 0x0600095F RID: 2399 RVA: 0x0026DA60 File Offset: 0x0026CA60
        ' (set) Token: 0x06000960 RID: 2400 RVA: 0x0026DA74 File Offset: 0x0026CA74
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

        ' Token: 0x170002DF RID: 735
        ' (get) Token: 0x06000961 RID: 2401 RVA: 0x0026DAAC File Offset: 0x0026CAAC
        ' (set) Token: 0x06000962 RID: 2402 RVA: 0x0026DA90 File Offset: 0x0026CA90
        Friend Overridable Property nudDotSize() As NumericUpDown
            Get
                Return Me._nudDotSize
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudDotSize IsNot Nothing Then
                End If
                Me._nudDotSize = value
                If Me._nudDotSize IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002E0 RID: 736
        ' (get) Token: 0x06000964 RID: 2404 RVA: 0x0026DAC0 File Offset: 0x0026CAC0
        ' (set) Token: 0x06000963 RID: 2403 RVA: 0x0026DAD4 File Offset: 0x0026CAD4
        Friend Overridable Property btnModuleExportPath() As Button
            Get
                Return Me._btnModuleExportPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnModuleExportPath IsNot Nothing Then
                    RemoveHandler Me._btnModuleExportPath.Click, AddressOf Me.btnModuleExportPath_Click
                End If
                Me._btnModuleExportPath = value
                If Me._btnModuleExportPath IsNot Nothing Then
                    AddHandler Me._btnModuleExportPath.Click, AddressOf Me.btnModuleExportPath_Click
                End If
            End Set
        End Property

        ' Token: 0x170002E1 RID: 737
        ' (get) Token: 0x06000966 RID: 2406 RVA: 0x0026DB28 File Offset: 0x0026CB28
        ' (set) Token: 0x06000965 RID: 2405 RVA: 0x0026DB3C File Offset: 0x0026CB3C
        Friend Overridable Property Label4() As Label
            Get
                Return Me._Label4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label4 IsNot Nothing Then
                End If
                Me._Label4 = value
                If Me._Label4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002E2 RID: 738
        ' (get) Token: 0x06000967 RID: 2407 RVA: 0x0026DB58 File Offset: 0x0026CB58
        ' (set) Token: 0x06000968 RID: 2408 RVA: 0x0026DB6C File Offset: 0x0026CB6C
        Friend Overridable Property tbModuleExportPath() As TextBox
            Get
                Return Me._tbModuleExportPath
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbModuleExportPath IsNot Nothing Then
                End If
                Me._tbModuleExportPath = value
                If Me._tbModuleExportPath IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170002E3 RID: 739
        ' (get) Token: 0x0600096A RID: 2410 RVA: 0x0026E254 File Offset: 0x0026D254
        ' (set) Token: 0x0600096B RID: 2411 RVA: 0x0026E26C File Offset: 0x0026D26C
        Public Property ModuleElementIndicatorSize() As Decimal
            Get
                Return Me.nudDotSize.Value
            End Get
            Set(ByVal value As Decimal)
                If Convert.ToDouble(value) < 1.0 Then
                    value = 1D
                End If
                If Convert.ToDouble(value) > 4.0 Then
                    value = 4D
                End If
                Me.nudDotSize.Value = value
            End Set
        End Property

        ' Token: 0x170002E4 RID: 740
        ' (get) Token: 0x0600096C RID: 2412 RVA: 0x0026E2C0 File Offset: 0x0026D2C0
        ' (set) Token: 0x0600096D RID: 2413 RVA: 0x0026E2D8 File Offset: 0x0026D2D8
        Public Property ConfirmDeletes() As Boolean
            Get
                Return Me.chkbConfirmDeletes.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkbConfirmDeletes.Checked = value
            End Set
        End Property

        ' Token: 0x170002E5 RID: 741
        ' (get) Token: 0x0600096E RID: 2414 RVA: 0x0026E2E8 File Offset: 0x0026D2E8
        ' (set) Token: 0x0600096F RID: 2415 RVA: 0x0026E300 File Offset: 0x0026D300
        Public Property ShowLocatorRay() As Boolean
            Get
                Return Me.chkbShowLocatorRay.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkbShowLocatorRay.Checked = value
            End Set
        End Property

        ' Token: 0x170002E6 RID: 742
        ' (get) Token: 0x06000970 RID: 2416 RVA: 0x0026E310 File Offset: 0x0026D310
        ' (set) Token: 0x06000971 RID: 2417 RVA: 0x0026E330 File Offset: 0x0026D330
        Public Property ModuleExportPath() As String
            Get
                Return Me.tbModuleExportPath.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.tbModuleExportPath.Text = value
            End Set
        End Property

        ' Token: 0x06000972 RID: 2418 RVA: 0x0026E340 File Offset: 0x0026D340
        Private Sub btnModuleExportPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbModuleExportPath As TextBox = Me.tbModuleExportPath
            Me.BrowseForModFile(tbModuleExportPath)
            Me.tbModuleExportPath = tbModuleExportPath
        End Sub

        ' Token: 0x06000973 RID: 2419 RVA: 0x0026E364 File Offset: 0x0026D364
        Private Sub BrowseForModFile(ByRef fld As TextBox)
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
            Dim saveFileDialog2 As SaveFileDialog = saveFileDialog
            saveFileDialog2.Title = "Select Module file to export to..."
            saveFileDialog2.Filter = "Module Files (*.mod)|*.mod"
            saveFileDialog2.ValidateNames = True
            saveFileDialog2.DefaultExt = ".mod"
            saveFileDialog2.CheckPathExists = True
            saveFileDialog2.AddExtension = True
            saveFileDialog2.CheckFileExists = False
            saveFileDialog2.CreatePrompt = False
            saveFileDialog2.FilterIndex = 1
            saveFileDialog2.RestoreDirectory = True
            If StringType.StrCmp(fld.Text, "", False) <> 0 Then
                saveFileDialog.InitialDirectory = Strings.Mid(fld.Text, 1, fld.Text.LastIndexOf("\"))
                saveFileDialog.FileName = Strings.Mid(fld.Text, fld.Text.LastIndexOf("\") + 2)
            End If
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = saveFileDialog.FileName
            End If
        End Sub

        ' Token: 0x040004D3 RID: 1235
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x040004D4 RID: 1236
        <AccessedThroughProperty("btnModuleExportPath")> _
        Private _btnModuleExportPath As Button

        ' Token: 0x040004D5 RID: 1237
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x040004D6 RID: 1238
        <AccessedThroughProperty("tbModuleExportPath")> _
        Private _tbModuleExportPath As TextBox

        ' Token: 0x040004D7 RID: 1239
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x040004D8 RID: 1240
        <AccessedThroughProperty("nudDotSize")> _
        Private _nudDotSize As NumericUpDown

        ' Token: 0x040004D9 RID: 1241
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x040004DA RID: 1242
        <AccessedThroughProperty("chkbShowLocatorRay")> _
        Private _chkbShowLocatorRay As CheckBox

        ' Token: 0x040004DB RID: 1243
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x040004DC RID: 1244
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x040004DD RID: 1245
        <AccessedThroughProperty("chkbConfirmDeletes")> _
        Private _chkbConfirmDeletes As CheckBox
    End Class
End Namespace
