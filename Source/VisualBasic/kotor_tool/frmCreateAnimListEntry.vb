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
	' Token: 0x02000045 RID: 69
	Public Partial Class frmCreateAnimListEntry
		Inherits Form

		' Token: 0x060002F6 RID: 758 RVA: 0x00230518 File Offset: 0x0022F518
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmCreateAnimListEntry_Load
			Me.al = New ArrayList()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x060002F8 RID: 760 RVA: 0x00230564 File Offset: 0x0022F564
		' (set) Token: 0x060002F9 RID: 761 RVA: 0x00230578 File Offset: 0x0022F578
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

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x060002FA RID: 762 RVA: 0x002305E8 File Offset: 0x0022F5E8
		' (set) Token: 0x060002FB RID: 763 RVA: 0x002305CC File Offset: 0x0022F5CC
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

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x060002FC RID: 764 RVA: 0x00230618 File Offset: 0x0022F618
		' (set) Token: 0x060002FD RID: 765 RVA: 0x002305FC File Offset: 0x0022F5FC
        Friend Overridable Property tbParticipant() As TextBox
            Get
                Return Me._tbParticipant
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As TextBox)
                If Me._tbParticipant IsNot Nothing Then
                End If
                Me._tbParticipant = value
                If Me._tbParticipant IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x060002FE RID: 766 RVA: 0x00230648 File Offset: 0x0022F648
		' (set) Token: 0x060002FF RID: 767 RVA: 0x0023062C File Offset: 0x0022F62C
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

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x06000300 RID: 768 RVA: 0x00230678 File Offset: 0x0022F678
		' (set) Token: 0x06000301 RID: 769 RVA: 0x0023065C File Offset: 0x0022F65C
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

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x06000302 RID: 770 RVA: 0x002306A8 File Offset: 0x0022F6A8
		' (set) Token: 0x06000303 RID: 771 RVA: 0x0023068C File Offset: 0x0022F68C
        Friend Overridable Property cmbxAnimation() As ComboBox
            Get
                Return Me._cmbxAnimation
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ComboBox)
                If Me._cmbxAnimation IsNot Nothing Then
                End If
                Me._cmbxAnimation = value
                If Me._cmbxAnimation IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x06000305 RID: 773 RVA: 0x002306D8 File Offset: 0x0022F6D8
		' (set) Token: 0x06000304 RID: 772 RVA: 0x002306BC File Offset: 0x0022F6BC
        Friend Overridable Property ToolTip1() As ToolTip
            Get
                Return Me._ToolTip1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal value As ToolTip)
                If Me._ToolTip1 IsNot Nothing Then
                End If
                Me._ToolTip1 = value
                If Me._ToolTip1 IsNot Nothing Then
                End If
            End Set
        End Property

		' Token: 0x06000307 RID: 775 RVA: 0x00230AC4 File Offset: 0x0022FAC4
		Private Sub btnOK_Click(sender As Object, e As EventArgs)
            Dim text As String = Nothing
			If Me.cmbxAnimation.SelectedIndex = -1 AndAlso StringType.StrCmp(Me.cmbxAnimation.Text, "", False) <> 0 Then
				text = Me.cmbxAnimation.Text
			ElseIf Me.cmbxAnimation.SelectedItem IsNot Nothing Then
				text = StringType.FromInteger(CType(Me.cmbxAnimation.SelectedItem, frmCreateAnimListEntry.Anim).Number)
			End If
			If(StringType.StrCmp(text, "", False) = 0) Or Not Information.IsNumeric(text) Then
				Interaction.MsgBox("You must either enter an animation number or select an animation from the list.", MsgBoxStyle.Critical, "Error")
			ElseIf StringType.StrCmp(Me.tbParticipant.Text.Trim(), "", False) = 0 Then
				Interaction.MsgBox("You must enter a Participant name.", MsgBoxStyle.Critical, "Error")
			Else
				Me.AnimationNumber = IntegerType.FromString(text)
				Me.Participant = Me.tbParticipant.Text.Trim()
				Me.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x06000308 RID: 776 RVA: 0x00230BB8 File Offset: 0x0022FBB8
		Private Sub frmCreateAnimListEntry_Load(sender As Object, e As EventArgs)
			Me.al.Add(New frmCreateAnimListEntry.Anim("ACTIVATE", 10127))
			Me.al.Add(New frmCreateAnimListEntry.Anim("BOW", 10035))
			Me.al.Add(New frmCreateAnimListEntry.Anim("CHOKE", 10150))
			Me.al.Add(New frmCreateAnimListEntry.Anim("COLLAPSE CHOKING", 10221))
			Me.al.Add(New frmCreateAnimListEntry.Anim("COLLAPSE KNOCKOUT", 10222))
			Me.al.Add(New frmCreateAnimListEntry.Anim("DEAD", 10006))
			Me.al.Add(New frmCreateAnimListEntry.Anim("DRUNK", 10058))
			Me.al.Add(New frmCreateAnimListEntry.Anim("FALL SLOWLY (CENTER)", 10224))
			Me.al.Add(New frmCreateAnimListEntry.Anim("FALL SLOWLY (RIGHT)", 10223))
			Me.al.Add(New frmCreateAnimListEntry.Anim("FLIRT", 10120))
			Me.al.Add(New frmCreateAnimListEntry.Anim("FORCE JUMP", 10220))
			Me.al.Add(New frmCreateAnimListEntry.Anim("GREETING", 10029))
			Me.al.Add(New frmCreateAnimListEntry.Anim("HORROR", 10124))
			Me.al.Add(New frmCreateAnimListEntry.Anim("INJECT", 10070))
			Me.al.Add(New frmCreateAnimListEntry.Anim("KNEEL TALK ANGRY", 10163))
			Me.al.Add(New frmCreateAnimListEntry.Anim("KNEEL TALK SAD", 10164))
			Me.al.Add(New frmCreateAnimListEntry.Anim("LISTEN", 10030))
			Me.al.Add(New frmCreateAnimListEntry.Anim("LISTEN INJURED", 10155))
			Me.al.Add(New frmCreateAnimListEntry.Anim("PAUSE", 10149))
			Me.al.Add(New frmCreateAnimListEntry.Anim("PERSUADE", 10126))
			Me.al.Add(New frmCreateAnimListEntry.Anim("PRONE", 10139))
			Me.al.Add(New frmCreateAnimListEntry.Anim("PUSHED BACK", 10219))
			Me.al.Add(New frmCreateAnimListEntry.Anim("READY", 10148))
			Me.al.Add(New frmCreateAnimListEntry.Anim("SALUTE", 10034))
			Me.al.Add(New frmCreateAnimListEntry.Anim("SCRATCH HEAD", 10055))
			Me.al.Add(New frmCreateAnimListEntry.Anim("SLEEP", 10137))
			Me.al.Add(New frmCreateAnimListEntry.Anim("TALK FORCEFUL", 10040))
			Me.al.Add(New frmCreateAnimListEntry.Anim("TALK INJURED", 10154))
			Me.al.Add(New frmCreateAnimListEntry.Anim("TALK LAUGHING", 10041))
			Me.al.Add(New frmCreateAnimListEntry.Anim("TALK NORMAL", 10038))
			Me.al.Add(New frmCreateAnimListEntry.Anim("TALK PLEADING", 10039))
			Me.al.Add(New frmCreateAnimListEntry.Anim("TALK SAD", 10042))
			Me.al.Add(New frmCreateAnimListEntry.Anim("TAUNT", 10028))
			Me.al.Add(New frmCreateAnimListEntry.Anim("USE COMPUTER", 10125))
			Me.al.Add(New frmCreateAnimListEntry.Anim("USE COMPUTER (loop)", 10121))
			Me.al.Add(New frmCreateAnimListEntry.Anim("VICTORY", 10044))
			Me.al.Add(New frmCreateAnimListEntry.Anim("WORSHIP", 10033))
			Me.cmbxAnimation.DataSource = Me.al
			Me.cmbxAnimation.DisplayMember = "Name"
			Me.cmbxAnimation.ValueMember = "Number"
		End Sub

        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        <AccessedThroughProperty("cmbxAnimation")> _
        Private _cmbxAnimation As ComboBox

        <AccessedThroughProperty("ToolTip1")> _
        Private _ToolTip1 As ToolTip

        <AccessedThroughProperty("tbParticipant")> _
        Private _tbParticipant As TextBox

        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

		' Token: 0x040001DB RID: 475
		Private al As ArrayList

		' Token: 0x040001DC RID: 476
		Public AnimationNumber As Integer

		' Token: 0x040001DD RID: 477
		Public Participant As String

		' Token: 0x02000046 RID: 70
		Private Class Anim
			' Token: 0x06000309 RID: 777 RVA: 0x00230FE0 File Offset: 0x0022FFE0
			Public Sub New(Name As String, Number As Integer)
				' The following expression was wrapped in a checked-expression
				Me.m_Name = Name.Substring(0, 1) + Name.Substring(1, Name.Length - 1).ToLower()
				Me.m_number = Number
			End Sub

			' Token: 0x170000CA RID: 202
			' (get) Token: 0x0600030A RID: 778 RVA: 0x00231018 File Offset: 0x00230018
			' (set) Token: 0x0600030B RID: 779 RVA: 0x0023102C File Offset: 0x0023002C
			Public Property Name As String
				Get
					Return Me.m_Name
				End Get
				Set(value As String)
					Me.m_Name = value
				End Set
			End Property

			' Token: 0x170000CB RID: 203
			' (get) Token: 0x0600030C RID: 780 RVA: 0x00231038 File Offset: 0x00230038
			' (set) Token: 0x0600030D RID: 781 RVA: 0x0023104C File Offset: 0x0023004C
			Public Property Number As Integer
				Get
					Return Me.m_number
				End Get
				Set(value As Integer)
					Me.m_number = value
				End Set
			End Property

			' Token: 0x040001DE RID: 478
			Private m_Name As String

			' Token: 0x040001DF RID: 479
			Private m_number As Integer
		End Class
	End Class
End Namespace
