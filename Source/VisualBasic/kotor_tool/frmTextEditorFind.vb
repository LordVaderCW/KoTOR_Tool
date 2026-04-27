Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000079 RID: 121
	Public Partial Class frmTextEditorFind
		Inherits Form

		' Token: 0x060010D0 RID: 4304 RVA: 0x0029DC80 File Offset: 0x0029CC80
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000602 RID: 1538
		' (get) Token: 0x060010D2 RID: 4306 RVA: 0x0029DCB0 File Offset: 0x0029CCB0
		' (set) Token: 0x060010D3 RID: 4307 RVA: 0x0029DCC4 File Offset: 0x0029CCC4
		Friend Overridable Property tbFindText As TextBox
			Get
				Return Me._tbFindText
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbFindText IsNot Nothing Then
                End If
                Me._tbFindText = value
                If Me._tbFindText IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000603 RID: 1539
        ' (get) Token: 0x060010D5 RID: 4309 RVA: 0x0029DCE0 File Offset: 0x0029CCE0
        ' (set) Token: 0x060010D4 RID: 4308 RVA: 0x0029DCF4 File Offset: 0x0029CCF4
        Friend Overridable Property btnFind() As Button
            Get
                Return Me._btnFind
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnFind IsNot Nothing Then
                End If
                Me._btnFind = value
                If Me._btnFind IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000604 RID: 1540
        ' (get) Token: 0x060010D7 RID: 4311 RVA: 0x0029DD2C File Offset: 0x0029CD2C
        ' (set) Token: 0x060010D6 RID: 4310 RVA: 0x0029DD10 File Offset: 0x0029CD10
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

        ' Token: 0x17000605 RID: 1541
        ' (get) Token: 0x060010D8 RID: 4312 RVA: 0x0029DD5C File Offset: 0x0029CD5C
        ' (set) Token: 0x060010D9 RID: 4313 RVA: 0x0029DD40 File Offset: 0x0029CD40
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

        ' Token: 0x17000606 RID: 1542
        ' (get) Token: 0x060010DA RID: 4314 RVA: 0x0029DD70 File Offset: 0x0029CD70
        ' (set) Token: 0x060010DB RID: 4315 RVA: 0x0029DD84 File Offset: 0x0029CD84
        Friend Overridable Property chkbMatchCase() As CheckBox
            Get
                Return Me._chkbMatchCase
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbMatchCase IsNot Nothing Then
                End If
                Me._chkbMatchCase = value
                If Me._chkbMatchCase IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000607 RID: 1543
        ' (get) Token: 0x060010DD RID: 4317 RVA: 0x0029DDA0 File Offset: 0x0029CDA0
        ' (set) Token: 0x060010DC RID: 4316 RVA: 0x0029DDB4 File Offset: 0x0029CDB4
        Friend Overridable Property chkbMatchWholeWord() As CheckBox
            Get
                Return Me._chkbMatchWholeWord
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbMatchWholeWord IsNot Nothing Then
                End If
                Me._chkbMatchWholeWord = value
                If Me._chkbMatchWholeWord IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000608 RID: 1544
        ' (get) Token: 0x060010DE RID: 4318 RVA: 0x0029DDEC File Offset: 0x0029CDEC
        ' (set) Token: 0x060010DF RID: 4319 RVA: 0x0029DDD0 File Offset: 0x0029CDD0
        Friend Overridable Property chkbSearchUp() As CheckBox
            Get
                Return Me._chkbSearchUp
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbSearchUp IsNot Nothing Then
                End If
                Me._chkbSearchUp = value
                If Me._chkbSearchUp IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x04000819 RID: 2073
        <AccessedThroughProperty("chkbMatchWholeWord")> _
        Private _chkbMatchWholeWord As CheckBox

        ' Token: 0x0400081A RID: 2074
        <AccessedThroughProperty("chkbMatchCase")> _
        Private _chkbMatchCase As CheckBox

        ' Token: 0x0400081B RID: 2075
        <AccessedThroughProperty("btnFind")> _
        Private _btnFind As Button

        ' Token: 0x0400081C RID: 2076
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x0400081D RID: 2077
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x0400081E RID: 2078
        <AccessedThroughProperty("chkbSearchUp")> _
        Private _chkbSearchUp As CheckBox

        ' Token: 0x0400081F RID: 2079
        <AccessedThroughProperty("tbFindText")> _
        Private _tbFindText As TextBox
    End Class
End Namespace
