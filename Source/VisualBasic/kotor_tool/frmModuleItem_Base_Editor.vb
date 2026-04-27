Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000063 RID: 99
	Public Partial Class frmModuleItem_Base_Editor
		Inherits frmParent

		' Token: 0x06000B8F RID: 2959 RVA: 0x0027B7FC File Offset: 0x0027A7FC
		Public Sub New()
			Me.bmpXY = New Bitmap(50, 50)
			Me.bmpXYSpawnPointBearing = New Bitmap(50, 50)
			Me._XYAngle = 0.0
			Me._SpawnPointXYAngle = 0.0
			Me.InitializeComponent()
		End Sub

		' Token: 0x170003E4 RID: 996
		' (get) Token: 0x06000B91 RID: 2961 RVA: 0x0027B890 File Offset: 0x0027A890
		' (set) Token: 0x06000B92 RID: 2962 RVA: 0x0027B874 File Offset: 0x0027A874
		Friend Overridable Property Label2 As Label
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

        ' Token: 0x170003E5 RID: 997
        ' (get) Token: 0x06000B93 RID: 2963 RVA: 0x0027B8A4 File Offset: 0x0027A8A4
        ' (set) Token: 0x06000B94 RID: 2964 RVA: 0x0027B8B8 File Offset: 0x0027A8B8
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

        ' Token: 0x170003E6 RID: 998
        ' (get) Token: 0x06000B95 RID: 2965 RVA: 0x0027B8F0 File Offset: 0x0027A8F0
        ' (set) Token: 0x06000B96 RID: 2966 RVA: 0x0027B8D4 File Offset: 0x0027A8D4
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

        ' Token: 0x170003E7 RID: 999
        ' (get) Token: 0x06000B98 RID: 2968 RVA: 0x0027B904 File Offset: 0x0027A904
        ' (set) Token: 0x06000B97 RID: 2967 RVA: 0x0027B918 File Offset: 0x0027A918
        Friend Overridable Property pboxXY() As PictureBox
            Get
                Return Me._pboxXY
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As PictureBox)
                If Me._pboxXY IsNot Nothing Then
                End If
                Me._pboxXY = value
                If Me._pboxXY IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003E8 RID: 1000
        ' (get) Token: 0x06000B99 RID: 2969 RVA: 0x0027B934 File Offset: 0x0027A934
        ' (set) Token: 0x06000B9A RID: 2970 RVA: 0x0027B948 File Offset: 0x0027A948
        Friend Overridable Property tbXPosition() As TextBox
            Get
                Return Me._tbXPosition
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbXPosition IsNot Nothing Then
                End If
                Me._tbXPosition = value
                If Me._tbXPosition IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003E9 RID: 1001
        ' (get) Token: 0x06000B9C RID: 2972 RVA: 0x0027B964 File Offset: 0x0027A964
        ' (set) Token: 0x06000B9B RID: 2971 RVA: 0x0027B978 File Offset: 0x0027A978
        Friend Overridable Property tbYPosition() As TextBox
            Get
                Return Me._tbYPosition
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbYPosition IsNot Nothing Then
                End If
                Me._tbYPosition = value
                If Me._tbYPosition IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003EA RID: 1002
        ' (get) Token: 0x06000B9E RID: 2974 RVA: 0x0027B994 File Offset: 0x0027A994
        ' (set) Token: 0x06000B9D RID: 2973 RVA: 0x0027B9A8 File Offset: 0x0027A9A8
        Friend Overridable Property tbZPosition() As TextBox
            Get
                Return Me._tbZPosition
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbZPosition IsNot Nothing Then
                End If
                Me._tbZPosition = value
                If Me._tbZPosition IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003EB RID: 1003
        ' (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0027BA48 File Offset: 0x0027AA48
        ' (set) Token: 0x06000B9F RID: 2975 RVA: 0x0027B9C4 File Offset: 0x0027A9C4
        Friend Overridable Property nudXY() As NumericUpDown
            Get
                Return Me._nudXY
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudXY IsNot Nothing Then
                    RemoveHandler Me._nudXY.ValueChanged, AddressOf Me.nudXY_ValueChanged
                    RemoveHandler Me._nudXY.KeyUp, AddressOf Me.nudXY_KeyUp
                End If
                Me._nudXY = value
                If Me._nudXY IsNot Nothing Then
                    AddHandler Me._nudXY.ValueChanged, AddressOf Me.nudXY_ValueChanged
                    AddHandler Me._nudXY.KeyUp, AddressOf Me.nudXY_KeyUp
                End If
            End Set
        End Property

        ' Token: 0x170003EC RID: 1004
        ' (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0027BA78 File Offset: 0x0027AA78
        ' (set) Token: 0x06000BA2 RID: 2978 RVA: 0x0027BA5C File Offset: 0x0027AA5C
        Friend Overridable Property Button1() As Button
            Get
                Return Me._Button1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._Button1 IsNot Nothing Then
                End If
                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003ED RID: 1005
        ' (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0027BAA8 File Offset: 0x0027AAA8
        ' (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0027BA8C File Offset: 0x0027AA8C
        Friend Overridable Property Button2() As Button
            Get
                Return Me._Button2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._Button2 IsNot Nothing Then
                End If
                Me._Button2 = value
                If Me._Button2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003EE RID: 1006
        ' (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0027BAD8 File Offset: 0x0027AAD8
        ' (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0027BABC File Offset: 0x0027AABC
        Friend Overridable Property Button3() As Button
            Get
                Return Me._Button3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._Button3 IsNot Nothing Then
                End If
                Me._Button3 = value
                If Me._Button3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003EF RID: 1007
        ' (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0027BAEC File Offset: 0x0027AAEC
        ' (set) Token: 0x06000BA8 RID: 2984 RVA: 0x0027BB00 File Offset: 0x0027AB00
        Friend Overridable Property tbResRef() As TextBox
            Get
                Return Me._tbResRef
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbResRef IsNot Nothing Then
                End If
                Me._tbResRef = value
                If Me._tbResRef IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F0 RID: 1008
        ' (get) Token: 0x06000BAA RID: 2986 RVA: 0x0027BB1C File Offset: 0x0027AB1C
        ' (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0027BB30 File Offset: 0x0027AB30
        Friend Overridable Property tbTag() As TextBox
            Get
                Return Me._tbTag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTag IsNot Nothing Then
                End If
                Me._tbTag = value
                If Me._tbTag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F1 RID: 1009
        ' (get) Token: 0x06000BAB RID: 2987 RVA: 0x0027BB4C File Offset: 0x0027AB4C
        ' (set) Token: 0x06000BAC RID: 2988 RVA: 0x0027BB60 File Offset: 0x0027AB60
        Friend Overridable Property lblTag() As Label
            Get
                Return Me._lblTag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblTag IsNot Nothing Then
                End If
                Me._lblTag = value
                If Me._lblTag IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F2 RID: 1010
        ' (get) Token: 0x06000BAE RID: 2990 RVA: 0x0027BB98 File Offset: 0x0027AB98
        ' (set) Token: 0x06000BAD RID: 2989 RVA: 0x0027BB7C File Offset: 0x0027AB7C
        Friend Overridable Property tabpagDoor() As TabPage
            Get
                Return Me._tabpagDoor
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagDoor IsNot Nothing Then
                End If
                Me._tabpagDoor = value
                If Me._tabpagDoor IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F3 RID: 1011
        ' (get) Token: 0x06000BAF RID: 2991 RVA: 0x0027BBAC File Offset: 0x0027ABAC
        ' (set) Token: 0x06000BB0 RID: 2992 RVA: 0x0027BBC0 File Offset: 0x0027ABC0
        Friend Overridable Property tabpagGeneral() As TabPage
            Get
                Return Me._tabpagGeneral
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagGeneral IsNot Nothing Then
                End If
                Me._tabpagGeneral = value
                If Me._tabpagGeneral IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F4 RID: 1012
        ' (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0027BBF8 File Offset: 0x0027ABF8
        ' (set) Token: 0x06000BB2 RID: 2994 RVA: 0x0027BBDC File Offset: 0x0027ABDC
        Friend Overridable Property tabpagCamera() As TabPage
            Get
                Return Me._tabpagCamera
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagCamera IsNot Nothing Then
                End If
                Me._tabpagCamera = value
                If Me._tabpagCamera IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F5 RID: 1013
        ' (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0027BC0C File Offset: 0x0027AC0C
        ' (set) Token: 0x06000BB4 RID: 2996 RVA: 0x0027BC20 File Offset: 0x0027AC20
        Friend Overridable Property tabpagWaypoint() As TabPage
            Get
                Return Me._tabpagWaypoint
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagWaypoint IsNot Nothing Then
                End If
                Me._tabpagWaypoint = value
                If Me._tabpagWaypoint IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F6 RID: 1014
        ' (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0027BC3C File Offset: 0x0027AC3C
        ' (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0027BC50 File Offset: 0x0027AC50
        Friend Overridable Property tbDoorLinkedTo() As TextBox
            Get
                Return Me._tbDoorLinkedTo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbDoorLinkedTo IsNot Nothing Then
                End If
                Me._tbDoorLinkedTo = value
                If Me._tbDoorLinkedTo IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F7 RID: 1015
        ' (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0027BC6C File Offset: 0x0027AC6C
        ' (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0027BC80 File Offset: 0x0027AC80
        Friend Overridable Property tbDoorLinkedToModule() As TextBox
            Get
                Return Me._tbDoorLinkedToModule
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbDoorLinkedToModule IsNot Nothing Then
                End If
                Me._tbDoorLinkedToModule = value
                If Me._tbDoorLinkedToModule IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F8 RID: 1016
        ' (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0027BC9C File Offset: 0x0027AC9C
        ' (set) Token: 0x06000BBA RID: 3002 RVA: 0x0027BCB0 File Offset: 0x0027ACB0
        Friend Overridable Property tbDoorLinkedToTransitionDestin() As TextBox
            Get
                Return Me._tbDoorLinkedToTransitionDestin
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbDoorLinkedToTransitionDestin IsNot Nothing Then
                End If
                Me._tbDoorLinkedToTransitionDestin = value
                If Me._tbDoorLinkedToTransitionDestin IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003F9 RID: 1017
        ' (get) Token: 0x06000BBC RID: 3004 RVA: 0x0027BCCC File Offset: 0x0027ACCC
        ' (set) Token: 0x06000BBB RID: 3003 RVA: 0x0027BCE0 File Offset: 0x0027ACE0
        Friend Overridable Property Label9() As Label
            Get
                Return Me._Label9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label9 IsNot Nothing Then
                End If
                Me._Label9 = value
                If Me._Label9 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003FA RID: 1018
        ' (get) Token: 0x06000BBD RID: 3005 RVA: 0x0027BD18 File Offset: 0x0027AD18
        ' (set) Token: 0x06000BBE RID: 3006 RVA: 0x0027BCFC File Offset: 0x0027ACFC
        Friend Overridable Property tbWPLinkedTo() As TextBox
            Get
                Return Me._tbWPLinkedTo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbWPLinkedTo IsNot Nothing Then
                End If
                Me._tbWPLinkedTo = value
                If Me._tbWPLinkedTo IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003FB RID: 1019
        ' (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0027BD2C File Offset: 0x0027AD2C
        ' (set) Token: 0x06000BBF RID: 3007 RVA: 0x0027BD40 File Offset: 0x0027AD40
        Friend Overridable Property tbWpDescription() As TextBox
            Get
                Return Me._tbWpDescription
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbWpDescription IsNot Nothing Then
                End If
                Me._tbWpDescription = value
                If Me._tbWpDescription IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003FC RID: 1020
        ' (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0027BD5C File Offset: 0x0027AD5C
        ' (set) Token: 0x06000BC1 RID: 3009 RVA: 0x0027BD70 File Offset: 0x0027AD70
        Friend Overridable Property Label11() As Label
            Get
                Return Me._Label11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label11 IsNot Nothing Then
                End If
                Me._Label11 = value
                If Me._Label11 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003FD RID: 1021
        ' (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0027BDA8 File Offset: 0x0027ADA8
        ' (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0027BD8C File Offset: 0x0027AD8C
        Friend Overridable Property Label12() As Label
            Get
                Return Me._Label12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label12 IsNot Nothing Then
                End If
                Me._Label12 = value
                If Me._Label12 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003FE RID: 1022
        ' (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0027BDD8 File Offset: 0x0027ADD8
        ' (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0027BDBC File Offset: 0x0027ADBC
        Friend Overridable Property tbWpLocalizedName() As TextBox
            Get
                Return Me._tbWpLocalizedName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbWpLocalizedName IsNot Nothing Then
                End If
                Me._tbWpLocalizedName = value
                If Me._tbWpLocalizedName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x170003FF RID: 1023
        ' (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0027BDEC File Offset: 0x0027ADEC
        ' (set) Token: 0x06000BC8 RID: 3016 RVA: 0x0027BE00 File Offset: 0x0027AE00
        Friend Overridable Property lblLocalizedName() As Label
            Get
                Return Me._lblLocalizedName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblLocalizedName IsNot Nothing Then
                End If
                Me._lblLocalizedName = value
                If Me._lblLocalizedName IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000400 RID: 1024
        ' (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0027BE1C File Offset: 0x0027AE1C
        ' (set) Token: 0x06000BCA RID: 3018 RVA: 0x0027BE30 File Offset: 0x0027AE30
        Friend Overridable Property chkbHasMapNote() As CheckBox
            Get
                Return Me._chkbHasMapNote
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbHasMapNote IsNot Nothing Then
                End If
                Me._chkbHasMapNote = value
                If Me._chkbHasMapNote IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000401 RID: 1025
        ' (get) Token: 0x06000BCB RID: 3019 RVA: 0x0027BE68 File Offset: 0x0027AE68
        ' (set) Token: 0x06000BCC RID: 3020 RVA: 0x0027BE4C File Offset: 0x0027AE4C
        Friend Overridable Property chkbMapNoteEnabled() As CheckBox
            Get
                Return Me._chkbMapNoteEnabled
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbMapNoteEnabled IsNot Nothing Then
                End If
                Me._chkbMapNoteEnabled = value
                If Me._chkbMapNoteEnabled IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000402 RID: 1026
        ' (get) Token: 0x06000BCE RID: 3022 RVA: 0x0027BE98 File Offset: 0x0027AE98
        ' (set) Token: 0x06000BCD RID: 3021 RVA: 0x0027BE7C File Offset: 0x0027AE7C
        Friend Overridable Property tabctrl() As TabControl
            Get
                Return Me._tabctrl
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabControl)
                If Me._tabctrl IsNot Nothing Then
                End If
                Me._tabctrl = value
                If Me._tabctrl IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000403 RID: 1027
        ' (get) Token: 0x06000BCF RID: 3023 RVA: 0x0027BEC8 File Offset: 0x0027AEC8
        ' (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0027BEAC File Offset: 0x0027AEAC
        Friend Overridable Property cmbxDoorLinkedToFlags() As ComboBox
            Get
                Return Me._cmbxDoorLinkedToFlags
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxDoorLinkedToFlags IsNot Nothing Then
                End If
                Me._cmbxDoorLinkedToFlags = value
                If Me._cmbxDoorLinkedToFlags IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000404 RID: 1028
        ' (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0027BEDC File Offset: 0x0027AEDC
        ' (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0027BEF0 File Offset: 0x0027AEF0
        Friend Overridable Property lblResRef() As Label
            Get
                Return Me._lblResRef
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblResRef IsNot Nothing Then
                End If
                Me._lblResRef = value
                If Me._lblResRef IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000405 RID: 1029
        ' (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0027BF0C File Offset: 0x0027AF0C
        ' (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0027BF20 File Offset: 0x0027AF20
        Friend Overridable Property tbWpMapNote() As TextBox
            Get
                Return Me._tbWpMapNote
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbWpMapNote IsNot Nothing Then
                End If
                Me._tbWpMapNote = value
                If Me._tbWpMapNote IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000406 RID: 1030
        ' (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0027BF58 File Offset: 0x0027AF58
        ' (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0027BF3C File Offset: 0x0027AF3C
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

        ' Token: 0x17000407 RID: 1031
        ' (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0027BF6C File Offset: 0x0027AF6C
        ' (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0027BF80 File Offset: 0x0027AF80
        Friend Overridable Property tbCamPitch() As TextBox
            Get
                Return Me._tbCamPitch
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamPitch IsNot Nothing Then
                End If
                Me._tbCamPitch = value
                If Me._tbCamPitch IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000408 RID: 1032
        ' (get) Token: 0x06000BDA RID: 3034 RVA: 0x0027BFB8 File Offset: 0x0027AFB8
        ' (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0027BF9C File Offset: 0x0027AF9C
        Friend Overridable Property tbCamHeight() As TextBox
            Get
                Return Me._tbCamHeight
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamHeight IsNot Nothing Then
                End If
                Me._tbCamHeight = value
                If Me._tbCamHeight IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000409 RID: 1033
        ' (get) Token: 0x06000BDC RID: 3036 RVA: 0x0027BFCC File Offset: 0x0027AFCC
        ' (set) Token: 0x06000BDB RID: 3035 RVA: 0x0027BFE0 File Offset: 0x0027AFE0
        Friend Overridable Property Label15() As Label
            Get
                Return Me._Label15
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label15 IsNot Nothing Then
                End If
                Me._Label15 = value
                If Me._Label15 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700040A RID: 1034
        ' (get) Token: 0x06000BDD RID: 3037 RVA: 0x0027BFFC File Offset: 0x0027AFFC
        ' (set) Token: 0x06000BDE RID: 3038 RVA: 0x0027C010 File Offset: 0x0027B010
        Friend Overridable Property tbCamMicRange() As TextBox
            Get
                Return Me._tbCamMicRange
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamMicRange IsNot Nothing Then
                End If
                Me._tbCamMicRange = value
                If Me._tbCamMicRange IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700040B RID: 1035
        ' (get) Token: 0x06000BDF RID: 3039 RVA: 0x0027C02C File Offset: 0x0027B02C
        ' (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0027C040 File Offset: 0x0027B040
        Friend Overridable Property Label16() As Label
            Get
                Return Me._Label16
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label16 IsNot Nothing Then
                End If
                Me._Label16 = value
                If Me._Label16 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700040C RID: 1036
        ' (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0027C05C File Offset: 0x0027B05C
        ' (set) Token: 0x06000BE1 RID: 3041 RVA: 0x0027C070 File Offset: 0x0027B070
        Friend Overridable Property Label17() As Label
            Get
                Return Me._Label17
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label17 IsNot Nothing Then
                End If
                Me._Label17 = value
                If Me._Label17 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700040D RID: 1037
        ' (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0027C0A8 File Offset: 0x0027B0A8
        ' (set) Token: 0x06000BE4 RID: 3044 RVA: 0x0027C08C File Offset: 0x0027B08C
        Friend Overridable Property tbCamFieldOfView() As TextBox
            Get
                Return Me._tbCamFieldOfView
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamFieldOfView IsNot Nothing Then
                End If
                Me._tbCamFieldOfView = value
                If Me._tbCamFieldOfView IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700040E RID: 1038
        ' (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0027C0D8 File Offset: 0x0027B0D8
        ' (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0027C0BC File Offset: 0x0027B0BC
        Friend Overridable Property lblBearing() As Label
            Get
                Return Me._lblBearing
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblBearing IsNot Nothing Then
                End If
                Me._lblBearing = value
                If Me._lblBearing IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700040F RID: 1039
        ' (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0027C0EC File Offset: 0x0027B0EC
        ' (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0027C100 File Offset: 0x0027B100
        Friend Overridable Property Label18() As Label
            Get
                Return Me._Label18
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label18 IsNot Nothing Then
                End If
                Me._Label18 = value
                If Me._Label18 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000410 RID: 1040
        ' (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0027C11C File Offset: 0x0027B11C
        ' (set) Token: 0x06000BEA RID: 3050 RVA: 0x0027C130 File Offset: 0x0027B130
        Friend Overridable Property Label19() As Label
            Get
                Return Me._Label19
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label19 IsNot Nothing Then
                End If
                Me._Label19 = value
                If Me._Label19 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000411 RID: 1041
        ' (get) Token: 0x06000BEB RID: 3051 RVA: 0x0027C14C File Offset: 0x0027B14C
        ' (set) Token: 0x06000BEC RID: 3052 RVA: 0x0027C160 File Offset: 0x0027B160
        Friend Overridable Property Label20() As Label
            Get
                Return Me._Label20
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label20 IsNot Nothing Then
                End If
                Me._Label20 = value
                If Me._Label20 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000412 RID: 1042
        ' (get) Token: 0x06000BEE RID: 3054 RVA: 0x0027C17C File Offset: 0x0027B17C
        ' (set) Token: 0x06000BED RID: 3053 RVA: 0x0027C190 File Offset: 0x0027B190
        Friend Overridable Property tbCamOrientationF1() As TextBox
            Get
                Return Me._tbCamOrientationF1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamOrientationF1 IsNot Nothing Then
                End If
                Me._tbCamOrientationF1 = value
                If Me._tbCamOrientationF1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000413 RID: 1043
        ' (get) Token: 0x06000BEF RID: 3055 RVA: 0x0027C1AC File Offset: 0x0027B1AC
        ' (set) Token: 0x06000BF0 RID: 3056 RVA: 0x0027C1C0 File Offset: 0x0027B1C0
        Friend Overridable Property tbCamOrientationF2() As TextBox
            Get
                Return Me._tbCamOrientationF2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamOrientationF2 IsNot Nothing Then
                End If
                Me._tbCamOrientationF2 = value
                If Me._tbCamOrientationF2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000414 RID: 1044
        ' (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0027C1F8 File Offset: 0x0027B1F8
        ' (set) Token: 0x06000BF2 RID: 3058 RVA: 0x0027C1DC File Offset: 0x0027B1DC
        Friend Overridable Property tbCamOrientationF4() As TextBox
            Get
                Return Me._tbCamOrientationF4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamOrientationF4 IsNot Nothing Then
                End If
                Me._tbCamOrientationF4 = value
                If Me._tbCamOrientationF4 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000415 RID: 1045
        ' (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0027C20C File Offset: 0x0027B20C
        ' (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0027C220 File Offset: 0x0027B220
        Friend Overridable Property tbCamOrientationF3() As TextBox
            Get
                Return Me._tbCamOrientationF3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamOrientationF3 IsNot Nothing Then
                End If
                Me._tbCamOrientationF3 = value
                If Me._tbCamOrientationF3 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000416 RID: 1046
        ' (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0027C258 File Offset: 0x0027B258
        ' (set) Token: 0x06000BF6 RID: 3062 RVA: 0x0027C23C File Offset: 0x0027B23C
        Friend Overridable Property tbTriggerNodeXPosition() As TextBox
            Get
                Return Me._tbTriggerNodeXPosition
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTriggerNodeXPosition IsNot Nothing Then
                End If
                Me._tbTriggerNodeXPosition = value
                If Me._tbTriggerNodeXPosition IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000417 RID: 1047
        ' (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0027C26C File Offset: 0x0027B26C
        ' (set) Token: 0x06000BF8 RID: 3064 RVA: 0x0027C280 File Offset: 0x0027B280
        Friend Overridable Property tbTriggerNodeYPosition() As TextBox
            Get
                Return Me._tbTriggerNodeYPosition
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTriggerNodeYPosition IsNot Nothing Then
                End If
                Me._tbTriggerNodeYPosition = value
                If Me._tbTriggerNodeYPosition IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000418 RID: 1048
        ' (get) Token: 0x06000BFA RID: 3066 RVA: 0x0027C2B8 File Offset: 0x0027B2B8
        ' (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0027C29C File Offset: 0x0027B29C
        Friend Overridable Property tbTriggerNodeZPosition() As TextBox
            Get
                Return Me._tbTriggerNodeZPosition
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbTriggerNodeZPosition IsNot Nothing Then
                End If
                Me._tbTriggerNodeZPosition = value
                If Me._tbTriggerNodeZPosition IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000419 RID: 1049
        ' (get) Token: 0x06000BFB RID: 3067 RVA: 0x0027C2E8 File Offset: 0x0027B2E8
        ' (set) Token: 0x06000BFC RID: 3068 RVA: 0x0027C2CC File Offset: 0x0027B2CC
        Friend Overridable Property Label21() As Label
            Get
                Return Me._Label21
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label21 IsNot Nothing Then
                End If
                Me._Label21 = value
                If Me._Label21 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700041A RID: 1050
        ' (get) Token: 0x06000BFE RID: 3070 RVA: 0x0027C2FC File Offset: 0x0027B2FC
        ' (set) Token: 0x06000BFD RID: 3069 RVA: 0x0027C310 File Offset: 0x0027B310
        Friend Overridable Property Label22() As Label
            Get
                Return Me._Label22
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label22 IsNot Nothing Then
                End If
                Me._Label22 = value
                If Me._Label22 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700041B RID: 1051
        ' (get) Token: 0x06000BFF RID: 3071 RVA: 0x0027C32C File Offset: 0x0027B32C
        ' (set) Token: 0x06000C00 RID: 3072 RVA: 0x0027C340 File Offset: 0x0027B340
        Friend Overridable Property Label23() As Label
            Get
                Return Me._Label23
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label23 IsNot Nothing Then
                End If
                Me._Label23 = value
                If Me._Label23 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700041C RID: 1052
        ' (get) Token: 0x06000C01 RID: 3073 RVA: 0x0027C35C File Offset: 0x0027B35C
        ' (set) Token: 0x06000C02 RID: 3074 RVA: 0x0027C370 File Offset: 0x0027B370
        Friend Overridable Property gbTriggerNode() As GroupBox
            Get
                Return Me._gbTriggerNode
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As GroupBox)
                If Me._gbTriggerNode IsNot Nothing Then
                End If
                Me._gbTriggerNode = value
                If Me._gbTriggerNode IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700041D RID: 1053
        ' (get) Token: 0x06000C04 RID: 3076 RVA: 0x0027C3A8 File Offset: 0x0027B3A8
        ' (set) Token: 0x06000C03 RID: 3075 RVA: 0x0027C38C File Offset: 0x0027B38C
        Friend Overridable Property tabpagEncounter() As TabPage
            Get
                Return Me._tabpagEncounter
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TabPage)
                If Me._tabpagEncounter IsNot Nothing Then
                End If
                Me._tabpagEncounter = value
                If Me._tabpagEncounter IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700041E RID: 1054
        ' (get) Token: 0x06000C05 RID: 3077 RVA: 0x0027C3D8 File Offset: 0x0027B3D8
        ' (set) Token: 0x06000C06 RID: 3078 RVA: 0x0027C3BC File Offset: 0x0027B3BC
        Friend Overridable Property Label24() As Label
            Get
                Return Me._Label24
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label24 IsNot Nothing Then
                End If
                Me._Label24 = value
                If Me._Label24 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700041F RID: 1055
        ' (get) Token: 0x06000C07 RID: 3079 RVA: 0x0027C3EC File Offset: 0x0027B3EC
        ' (set) Token: 0x06000C08 RID: 3080 RVA: 0x0027C400 File Offset: 0x0027B400
        Friend Overridable Property Label25() As Label
            Get
                Return Me._Label25
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label25 IsNot Nothing Then
                End If
                Me._Label25 = value
                If Me._Label25 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000420 RID: 1056
        ' (get) Token: 0x06000C09 RID: 3081 RVA: 0x0027C41C File Offset: 0x0027B41C
        ' (set) Token: 0x06000C0A RID: 3082 RVA: 0x0027C430 File Offset: 0x0027B430
        Friend Overridable Property Label26() As Label
            Get
                Return Me._Label26
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label26 IsNot Nothing Then
                End If
                Me._Label26 = value
                If Me._Label26 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000421 RID: 1057
        ' (get) Token: 0x06000C0B RID: 3083 RVA: 0x0027C468 File Offset: 0x0027B468
        ' (set) Token: 0x06000C0C RID: 3084 RVA: 0x0027C44C File Offset: 0x0027B44C
        Friend Overridable Property Label27() As Label
            Get
                Return Me._Label27
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label27 IsNot Nothing Then
                End If
                Me._Label27 = value
                If Me._Label27 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000422 RID: 1058
        ' (get) Token: 0x06000C0E RID: 3086 RVA: 0x0027C47C File Offset: 0x0027B47C
        ' (set) Token: 0x06000C0D RID: 3085 RVA: 0x0027C490 File Offset: 0x0027B490
        Friend Overridable Property Label28() As Label
            Get
                Return Me._Label28
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label28 IsNot Nothing Then
                End If
                Me._Label28 = value
                If Me._Label28 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000423 RID: 1059
        ' (get) Token: 0x06000C10 RID: 3088 RVA: 0x0027C4AC File Offset: 0x0027B4AC
        ' (set) Token: 0x06000C0F RID: 3087 RVA: 0x0027C4C0 File Offset: 0x0027B4C0
        Friend Overridable Property tbCamOrientationZ() As TextBox
            Get
                Return Me._tbCamOrientationZ
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamOrientationZ IsNot Nothing Then
                End If
                Me._tbCamOrientationZ = value
                If Me._tbCamOrientationZ IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000424 RID: 1060
        ' (get) Token: 0x06000C12 RID: 3090 RVA: 0x0027C4DC File Offset: 0x0027B4DC
        ' (set) Token: 0x06000C11 RID: 3089 RVA: 0x0027C4F0 File Offset: 0x0027B4F0
        Friend Overridable Property tbCamOrientationX() As TextBox
            Get
                Return Me._tbCamOrientationX
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamOrientationX IsNot Nothing Then
                End If
                Me._tbCamOrientationX = value
                If Me._tbCamOrientationX IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000425 RID: 1061
        ' (get) Token: 0x06000C14 RID: 3092 RVA: 0x0027C50C File Offset: 0x0027B50C
        ' (set) Token: 0x06000C13 RID: 3091 RVA: 0x0027C520 File Offset: 0x0027B520
        Friend Overridable Property tbCamOrientationY() As TextBox
            Get
                Return Me._tbCamOrientationY
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbCamOrientationY IsNot Nothing Then
                End If
                Me._tbCamOrientationY = value
                If Me._tbCamOrientationY IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000426 RID: 1062
        ' (get) Token: 0x06000C15 RID: 3093 RVA: 0x0027C558 File Offset: 0x0027B558
        ' (set) Token: 0x06000C16 RID: 3094 RVA: 0x0027C53C File Offset: 0x0027B53C
        Friend Overridable Property ErrorProvider1() As ErrorProvider
            Get
                Return Me._ErrorProvider1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ErrorProvider)
                If Me._ErrorProvider1 IsNot Nothing Then
                End If
                Me._ErrorProvider1 = value
                If Me._ErrorProvider1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000427 RID: 1063
        ' (get) Token: 0x06000C17 RID: 3095 RVA: 0x0027C5F0 File Offset: 0x0027B5F0
        ' (set) Token: 0x06000C18 RID: 3096 RVA: 0x0027C56C File Offset: 0x0027B56C
        Friend Overridable Property btnShowQuaternion() As Button
            Get
                Return Me._btnShowQuaternion
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnShowQuaternion IsNot Nothing Then
                    RemoveHandler Me._btnShowQuaternion.MouseUp, AddressOf Me.btnShowQuaternion_MouseUp
                    RemoveHandler Me._btnShowQuaternion.MouseDown, AddressOf Me.btnShowQuaternion_MouseDown
                End If
                Me._btnShowQuaternion = value
                If Me._btnShowQuaternion IsNot Nothing Then
                    AddHandler Me._btnShowQuaternion.MouseUp, AddressOf Me.btnShowQuaternion_MouseUp
                    AddHandler Me._btnShowQuaternion.MouseDown, AddressOf Me.btnShowQuaternion_MouseDown
                End If
            End Set
        End Property

        ' Token: 0x17000428 RID: 1064
        ' (get) Token: 0x06000C1A RID: 3098 RVA: 0x0027C604 File Offset: 0x0027B604
        ' (set) Token: 0x06000C19 RID: 3097 RVA: 0x0027C618 File Offset: 0x0027B618
        Friend Overridable Property lblQuaternionW() As Label
            Get
                Return Me._lblQuaternionW
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblQuaternionW IsNot Nothing Then
                End If
                Me._lblQuaternionW = value
                If Me._lblQuaternionW IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000429 RID: 1065
        ' (get) Token: 0x06000C1B RID: 3099 RVA: 0x0027C634 File Offset: 0x0027B634
        ' (set) Token: 0x06000C1C RID: 3100 RVA: 0x0027C648 File Offset: 0x0027B648
        Friend Overridable Property nudCamOrientationX() As NumericUpDown
            Get
                Return Me._nudCamOrientationX
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCamOrientationX IsNot Nothing Then
                    RemoveHandler Me._nudCamOrientationX.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
                End If
                Me._nudCamOrientationX = value
                If Me._nudCamOrientationX IsNot Nothing Then
                    AddHandler Me._nudCamOrientationX.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x1700042A RID: 1066
        ' (get) Token: 0x06000C1D RID: 3101 RVA: 0x0027C6F0 File Offset: 0x0027B6F0
        ' (set) Token: 0x06000C1E RID: 3102 RVA: 0x0027C69C File Offset: 0x0027B69C
        Friend Overridable Property nudCamOrientationY() As NumericUpDown
            Get
                Return Me._nudCamOrientationY
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCamOrientationY IsNot Nothing Then
                    RemoveHandler Me._nudCamOrientationY.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
                End If
                Me._nudCamOrientationY = value
                If Me._nudCamOrientationY IsNot Nothing Then
                    AddHandler Me._nudCamOrientationY.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x1700042B RID: 1067
        ' (get) Token: 0x06000C1F RID: 3103 RVA: 0x0027C704 File Offset: 0x0027B704
        ' (set) Token: 0x06000C20 RID: 3104 RVA: 0x0027C718 File Offset: 0x0027B718
        Friend Overridable Property nudCamOrientationZ() As NumericUpDown
            Get
                Return Me._nudCamOrientationZ
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudCamOrientationZ IsNot Nothing Then
                    RemoveHandler Me._nudCamOrientationZ.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
                End If
                Me._nudCamOrientationZ = value
                If Me._nudCamOrientationZ IsNot Nothing Then
                    AddHandler Me._nudCamOrientationZ.ValueChanged, AddressOf Me.nudCamOrientation_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x1700042C RID: 1068
        ' (get) Token: 0x06000C22 RID: 3106 RVA: 0x0027C788 File Offset: 0x0027B788
        ' (set) Token: 0x06000C21 RID: 3105 RVA: 0x0027C76C File Offset: 0x0027B76C
        Friend Overridable Property Label14() As Label
            Get
                Return Me._Label14
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label14 IsNot Nothing Then
                End If
                Me._Label14 = value
                If Me._Label14 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700042D RID: 1069
        ' (get) Token: 0x06000C23 RID: 3107 RVA: 0x0027C7B8 File Offset: 0x0027B7B8
        ' (set) Token: 0x06000C24 RID: 3108 RVA: 0x0027C79C File Offset: 0x0027B79C
        Friend Overridable Property Label29() As Label
            Get
                Return Me._Label29
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label29 IsNot Nothing Then
                End If
                Me._Label29 = value
                If Me._Label29 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700042E RID: 1070
        ' (get) Token: 0x06000C25 RID: 3109 RVA: 0x0027C7CC File Offset: 0x0027B7CC
        ' (set) Token: 0x06000C26 RID: 3110 RVA: 0x0027C7E0 File Offset: 0x0027B7E0
        Friend Overridable Property lblDoorLinkedTo() As Label
            Get
                Return Me._lblDoorLinkedTo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblDoorLinkedTo IsNot Nothing Then
                End If
                Me._lblDoorLinkedTo = value
                If Me._lblDoorLinkedTo IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700042F RID: 1071
        ' (get) Token: 0x06000C28 RID: 3112 RVA: 0x0027C7FC File Offset: 0x0027B7FC
        ' (set) Token: 0x06000C27 RID: 3111 RVA: 0x0027C810 File Offset: 0x0027B810
        Friend Overridable Property lblDoorLinkedToFlags() As Label
            Get
                Return Me._lblDoorLinkedToFlags
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblDoorLinkedToFlags IsNot Nothing Then
                End If
                Me._lblDoorLinkedToFlags = value
                If Me._lblDoorLinkedToFlags IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000430 RID: 1072
        ' (get) Token: 0x06000C29 RID: 3113 RVA: 0x0027C848 File Offset: 0x0027B848
        ' (set) Token: 0x06000C2A RID: 3114 RVA: 0x0027C82C File Offset: 0x0027B82C
        Friend Overridable Property lblDoorLinkedToModule() As Label
            Get
                Return Me._lblDoorLinkedToModule
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblDoorLinkedToModule IsNot Nothing Then
                End If
                Me._lblDoorLinkedToModule = value
                If Me._lblDoorLinkedToModule IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000431 RID: 1073
        ' (get) Token: 0x06000C2B RID: 3115 RVA: 0x0027C85C File Offset: 0x0027B85C
        ' (set) Token: 0x06000C2C RID: 3116 RVA: 0x0027C870 File Offset: 0x0027B870
        Friend Overridable Property lblDoorLinkedToTransitionDestin() As Label
            Get
                Return Me._lblDoorLinkedToTransitionDestin
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblDoorLinkedToTransitionDestin IsNot Nothing Then
                End If
                Me._lblDoorLinkedToTransitionDestin = value
                If Me._lblDoorLinkedToTransitionDestin IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000432 RID: 1074
        ' (get) Token: 0x06000C2D RID: 3117 RVA: 0x0027C8A8 File Offset: 0x0027B8A8
        ' (set) Token: 0x06000C2E RID: 3118 RVA: 0x0027C88C File Offset: 0x0027B88C
        Friend Overridable Property lblTransitionMsg() As Label
            Get
                Return Me._lblTransitionMsg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblTransitionMsg IsNot Nothing Then
                End If
                Me._lblTransitionMsg = value
                If Me._lblTransitionMsg IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000433 RID: 1075
        ' (get) Token: 0x06000C2F RID: 3119 RVA: 0x0027C940 File Offset: 0x0027B940
        ' (set) Token: 0x06000C30 RID: 3120 RVA: 0x0027C8BC File Offset: 0x0027B8BC
        Friend Overridable Property nudXYSpawnPointBearing() As NumericUpDown
            Get
                Return Me._nudXYSpawnPointBearing
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudXYSpawnPointBearing IsNot Nothing Then
                    RemoveHandler Me._nudXYSpawnPointBearing.KeyUp, AddressOf Me.nudXYSpawnPointBearing_KeyUp
                    RemoveHandler Me._nudXYSpawnPointBearing.ValueChanged, AddressOf Me.nudXYSpawnPointBearing_ValueChanged
                End If
                Me._nudXYSpawnPointBearing = value
                If Me._nudXYSpawnPointBearing IsNot Nothing Then
                    AddHandler Me._nudXYSpawnPointBearing.KeyUp, AddressOf Me.nudXYSpawnPointBearing_KeyUp
                    AddHandler Me._nudXYSpawnPointBearing.ValueChanged, AddressOf Me.nudXYSpawnPointBearing_ValueChanged
                End If
            End Set
        End Property

        ' Token: 0x17000434 RID: 1076
        ' (get) Token: 0x06000C32 RID: 3122 RVA: 0x0027C954 File Offset: 0x0027B954
        ' (set) Token: 0x06000C31 RID: 3121 RVA: 0x0027C968 File Offset: 0x0027B968
        Friend Overridable Property pboxXYSpawnPointBearing() As PictureBox
            Get
                Return Me._pboxXYSpawnPointBearing
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As PictureBox)
                If Me._pboxXYSpawnPointBearing IsNot Nothing Then
                End If
                Me._pboxXYSpawnPointBearing = value
                If Me._pboxXYSpawnPointBearing IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000435 RID: 1077
        ' (get) Token: 0x06000C34 RID: 3124 RVA: 0x0027C9D8 File Offset: 0x0027B9D8
        ' (set) Token: 0x06000C33 RID: 3123 RVA: 0x0027C984 File Offset: 0x0027B984
        Friend Overridable Property lbSpawnPoints() As ListBox
            Get
                Return Me._lbSpawnPoints
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ListBox)
                If Me._lbSpawnPoints IsNot Nothing Then
                    RemoveHandler Me._lbSpawnPoints.SelectedIndexChanged, AddressOf Me.lbSpawnPoints_SelectedIndexChanged
                End If
                Me._lbSpawnPoints = value
                If Me._lbSpawnPoints IsNot Nothing Then
                    AddHandler Me._lbSpawnPoints.SelectedIndexChanged, AddressOf Me.lbSpawnPoints_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x17000436 RID: 1078
        ' (get) Token: 0x06000C36 RID: 3126 RVA: 0x0027C9EC File Offset: 0x0027B9EC
        ' (set) Token: 0x06000C35 RID: 3125 RVA: 0x0027CA00 File Offset: 0x0027BA00
        Friend Overridable Property nudSpawnPointX() As NumericUpDown
            Get
                Return Me._nudSpawnPointX
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudSpawnPointX IsNot Nothing Then
                End If
                Me._nudSpawnPointX = value
                If Me._nudSpawnPointX IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000437 RID: 1079
        ' (get) Token: 0x06000C37 RID: 3127 RVA: 0x0027CA1C File Offset: 0x0027BA1C
        ' (set) Token: 0x06000C38 RID: 3128 RVA: 0x0027CA30 File Offset: 0x0027BA30
        Friend Overridable Property nudSpawnPointY() As NumericUpDown
            Get
                Return Me._nudSpawnPointY
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudSpawnPointY IsNot Nothing Then
                End If
                Me._nudSpawnPointY = value
                If Me._nudSpawnPointY IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000438 RID: 1080
        ' (get) Token: 0x06000C39 RID: 3129 RVA: 0x0027CA4C File Offset: 0x0027BA4C
        ' (set) Token: 0x06000C3A RID: 3130 RVA: 0x0027CA60 File Offset: 0x0027BA60
        Friend Overridable Property nudSpawnPointZ() As NumericUpDown
            Get
                Return Me._nudSpawnPointZ
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As NumericUpDown)
                If Me._nudSpawnPointZ IsNot Nothing Then
                End If
                Me._nudSpawnPointZ = value
                If Me._nudSpawnPointZ IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000439 RID: 1081
        ' (get) Token: 0x06000C3B RID: 3131 RVA: 0x0027CA7C File Offset: 0x0027BA7C
        ' (set) Token: 0x06000C3C RID: 3132 RVA: 0x0027CA90 File Offset: 0x0027BA90
        Friend Overridable Property tbxo() As TextBox
            Get
                Return Me._tbxo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbxo IsNot Nothing Then
                End If
                Me._tbxo = value
                If Me._tbxo IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700043A RID: 1082
        ' (get) Token: 0x06000C3E RID: 3134 RVA: 0x0027CAAC File Offset: 0x0027BAAC
        ' (set) Token: 0x06000C3D RID: 3133 RVA: 0x0027CAC0 File Offset: 0x0027BAC0
        Friend Overridable Property tbyo() As TextBox
            Get
                Return Me._tbyo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbyo IsNot Nothing Then
                End If
                Me._tbyo = value
                If Me._tbyo IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700043B RID: 1083
        ' (get) Token: 0x06000C3F RID: 3135 RVA: 0x0027CAF8 File Offset: 0x0027BAF8
        ' (set) Token: 0x06000C40 RID: 3136 RVA: 0x0027CADC File Offset: 0x0027BADC
        Friend Overridable Property Label5() As Label
            Get
                Return Me._Label5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label5 IsNot Nothing Then
                End If
                Me._Label5 = value
                If Me._Label5 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700043C RID: 1084
        ' (get) Token: 0x06000C41 RID: 3137 RVA: 0x0027CB0C File Offset: 0x0027BB0C
        ' (set) Token: 0x06000C42 RID: 3138 RVA: 0x0027CB20 File Offset: 0x0027BB20
        Friend Overridable Property Label6() As Label
            Get
                Return Me._Label6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label6 IsNot Nothing Then
                End If
                Me._Label6 = value
                If Me._Label6 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700043D RID: 1085
        ' (get) Token: 0x06000C43 RID: 3139 RVA: 0x0027CB3C File Offset: 0x0027BB3C
        ' (set) Token: 0x06000C44 RID: 3140 RVA: 0x0027CB50 File Offset: 0x0027BB50
        Friend Overridable Property tbBearing() As TextBox
            Get
                Return Me._tbBearing
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbBearing IsNot Nothing Then
                End If
                Me._tbBearing = value
                If Me._tbBearing IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700043E RID: 1086
        ' (get) Token: 0x06000C46 RID: 3142 RVA: 0x0027CB88 File Offset: 0x0027BB88
        ' (set) Token: 0x06000C45 RID: 3141 RVA: 0x0027CB6C File Offset: 0x0027BB6C
        Friend Overridable Property Label7() As Label
            Get
                Return Me._Label7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label7 IsNot Nothing Then
                End If
                Me._Label7 = value
                If Me._Label7 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700043F RID: 1087
        ' (get) Token: 0x06000C48 RID: 3144 RVA: 0x0027CB9C File Offset: 0x0027BB9C
        ' (set) Token: 0x06000C47 RID: 3143 RVA: 0x0027CBB0 File Offset: 0x0027BBB0
        Friend Overridable Property btnSetNameLang() As Button
            Get
                Return Me._btnSetNameLang
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnSetNameLang IsNot Nothing Then
                    RemoveHandler Me._btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
                End If
                Me._btnSetNameLang = value
                If Me._btnSetNameLang IsNot Nothing Then
                    AddHandler Me._btnSetNameLang.Click, AddressOf Me.btnSetNameLang_Click
                End If
            End Set
        End Property

        ' Token: 0x06000C4A RID: 3146 RVA: 0x00280214 File Offset: 0x0027F214
        Public Sub SetupOrientationIndicators()
            Dim num As Single = CSng(Math.Atan2(CDbl(Me._YOrientation), CDbl(Me._XOrientation)))
            Me._XYAngle = Math.Atan2(CDbl(Me._YOrientation), CDbl((Me._XOrientation * -1.0F))) * 180.0 / 3.1415926535897931 - 90.0
            If Me._XYAngle < 0.0 Then
                Me._XYAngle += 360.0
            End If
            Me.nudXY.Value = New Decimal(Me._XYAngle)
            Me.DrawXYOrientation()
        End Sub

        ' Token: 0x06000C4B RID: 3147 RVA: 0x002802B8 File Offset: 0x0027F2B8
        Public Sub SetupOrientationIndicators(ByVal XOrientation As Single, ByVal YOrientation As Single)
            Me._XOrientation = XOrientation
            Me._YOrientation = YOrientation
            Me.SetupOrientationIndicators()
        End Sub

        ' Token: 0x06000C4C RID: 3148 RVA: 0x002802D0 File Offset: 0x0027F2D0
        Private Sub DrawXYOrientation()
            Dim graphics As Graphics = graphics.FromImage(Me.bmpXY)
            graphics.FillEllipse(Brushes.White, 0, 0, 49, 49)
            graphics.DrawArc(New Pen(Color.Black), 0, 0, 49, 49, 0, 360)
            graphics.DrawPie(New Pen(Color.Black), 0.0F, 0.0F, 49.0F, 49.0F, CSng(Me._XYAngle), 1.0F)
            Me.bmpXY.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Me.pboxXY.Image = Me.bmpXY
        End Sub

        ' Token: 0x06000C4D RID: 3149 RVA: 0x00280364 File Offset: 0x0027F364
        Public Sub SetupOrientationIndicatorsSpawnPointBearing()
            Dim num As Single = CSng(Math.Atan2(CDbl(Me._YOrientation), CDbl(Me._XOrientation)))
            Me._XYAngle = Math.Atan2(CDbl(Me._YOrientation), CDbl((Me._XOrientation * -1.0F))) * 180.0 / 3.1415926535897931 - 90.0
            If Me._XYAngle < 0.0 Then
                Me._XYAngle += 360.0
            End If
            Me.nudXYSpawnPointBearing.Value = New Decimal(Me._XYAngle)
            Me.DrawXYOrientationSpawnPointBearing()
        End Sub

        ' Token: 0x06000C4E RID: 3150 RVA: 0x00280408 File Offset: 0x0027F408
        Public Sub SetupOrientationIndicatorsSpawnPointBearing(ByVal XOrientation As Single, ByVal YOrientation As Single)
            Me._XOrientation = XOrientation
            Me._YOrientation = YOrientation
            Me.SetupOrientationIndicatorsSpawnPointBearing()
        End Sub

        ' Token: 0x06000C4F RID: 3151 RVA: 0x00280420 File Offset: 0x0027F420
        Private Sub DrawXYOrientationSpawnPointBearing()
            Dim graphics As Graphics = graphics.FromImage(Me.bmpXYSpawnPointBearing)
            graphics.FillEllipse(Brushes.White, 0, 0, 49, 49)
            graphics.DrawArc(New Pen(Color.Black), 0, 0, 49, 49, 0, 360)
            graphics.DrawPie(New Pen(Color.Black), 0.0F, 0.0F, 49.0F, 49.0F, CSng(Me._SpawnPointXYAngle), 1.0F)
            Me.bmpXYSpawnPointBearing.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Me.pboxXYSpawnPointBearing.Image = Me.bmpXYSpawnPointBearing
        End Sub

        ' Token: 0x06000C50 RID: 3152 RVA: 0x002804B4 File Offset: 0x0027F4B4
        Public Sub SetupForItemType(ByVal type As Integer)
            If type <> 2042 AndAlso type <> 2058 Then
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
            End If
            If type = 6 Then
                Me.Text = "Camera Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.lblBearing)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.nudXY)
            ElseIf type = 2027 Then
                Me.Text = "Creature Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
            ElseIf type = 2042 Then
                Me.Text = "Door Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.gbTriggerNode.Visible = False
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
            ElseIf type = 2032 Then
                Me.Text = "Trigger Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.lblBearing)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.nudXY)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
            ElseIf type = 2044 Then
                Me.Text = "Placeable Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
            ElseIf type = 2035 Then
                Me.Text = "Sound Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.lblBearing)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.nudXY)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
            ElseIf type = 2051 Then
                Me.Text = "Merchant Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
                Me.lblResRef.Text = "ResRef"
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
            ElseIf type = 2058 Then
                Me.Text = "Waypoint Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagEncounter)
            ElseIf type = 2040 Then
                Me.Text = "Encounter Properties"
                Me.tabctrl.TabPages.Remove(Me.tabpagCamera)
                Me.tabctrl.TabPages.Remove(Me.tabpagDoor)
                Me.tabctrl.TabPages.Remove(Me.tabpagWaypoint)
                Me.tbTag.Visible = False
                Me.lblTag.Visible = False
                Me.tabctrl.TabPages(0).Controls.Remove(Me.lblBearing)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.pboxXY)
                Me.tabctrl.TabPages(0).Controls.Remove(Me.nudXY)
            End If
            Me.tabctrl.SelectedTab = Me.tabpagGeneral
        End Sub

        ' Token: 0x06000C51 RID: 3153 RVA: 0x00280A2C File Offset: 0x0027FA2C
        Public Sub DisableLinkedToFields()
            Me.lblDoorLinkedTo.Enabled = False
            Me.lblDoorLinkedToFlags.Enabled = False
            Me.lblDoorLinkedToModule.Enabled = False
            Me.lblDoorLinkedToTransitionDestin.Enabled = False
            Me.tbDoorLinkedTo.Enabled = False
            Me.cmbxDoorLinkedToFlags.Enabled = False
            Me.tbDoorLinkedToModule.Enabled = False
            Me.tbDoorLinkedToTransitionDestin.Enabled = False
            Me.lblTransitionMsg.Visible = True
        End Sub

        ' Token: 0x17000440 RID: 1088
        ' (get) Token: 0x06000C52 RID: 3154 RVA: 0x00280AA8 File Offset: 0x0027FAA8
        ' (set) Token: 0x06000C53 RID: 3155 RVA: 0x00280ABC File Offset: 0x0027FABC
        Public Property XOrientation() As Single
            Get
                Return Me._XOrientation
            End Get
            Set(ByVal value As Single)
                Me._XOrientation = value
            End Set
        End Property

        ' Token: 0x17000441 RID: 1089
        ' (get) Token: 0x06000C54 RID: 3156 RVA: 0x00280AC8 File Offset: 0x0027FAC8
        ' (set) Token: 0x06000C55 RID: 3157 RVA: 0x00280ADC File Offset: 0x0027FADC
        Public Property YOrientation() As Single
            Get
                Return Me._YOrientation
            End Get
            Set(ByVal value As Single)
                Me._YOrientation = value
            End Set
        End Property

        ' Token: 0x17000442 RID: 1090
        ' (get) Token: 0x06000C56 RID: 3158 RVA: 0x00280AE8 File Offset: 0x0027FAE8
        ' (set) Token: 0x06000C57 RID: 3159 RVA: 0x00280BC4 File Offset: 0x0027FBC4
        Public Property Bearing(ByVal ModItemType As Integer) As Single
            Get
                If ModItemType = 2044 Then
                    If Me._XYAngle > 90.0 Then
                        Return CSng(((270.0 - Me._XYAngle) / 180.0 * 3.1415926535897931))
                    End If
                    Return CSng((-CSng((Me._XYAngle + 90.0)) / 180.0 * 3.1415926535897931))
                Else
                    If ModItemType <> 2042 Then
                        Dim num As Single
                        Return num
                    End If
                    If Me._XYAngle > 180.0 Then
                        Return CSng((-CSng((Me._XYAngle - 180.0)) / 180.0 * 3.1415926535897931))
                    End If
                    Return CSng(((180.0 - Me._XYAngle) / 180.0 * 3.1415926535897931))
                End If
            End Get
            Set(ByVal value As Single)
                If ModItemType = 2042 Then
                    Me.SetupOrientationIndicators(CSng(Math.Sin(CDbl(value))), CSng((-CSng(Math.Cos(CDbl(value))))))
                ElseIf ModItemType = 2044 Then
                    Me.SetupOrientationIndicators(CSng((-CSng(Math.Cos(CDbl(value))))), CSng((-CSng(Math.Sin(CDbl(value))))))
                End If
                Me._Bearing = value
                Me.tbBearing.Text = StringType.FromSingle(value)
            End Set
        End Property

        ' Token: 0x17000443 RID: 1091
        ' (get) Token: 0x06000C58 RID: 3160 RVA: 0x00280C2C File Offset: 0x0027FC2C
        ' (set) Token: 0x06000C59 RID: 3161 RVA: 0x00280C40 File Offset: 0x0027FC40
        Public Property XYAngle() As Single
            Get
                Return CSng(Me._XYAngle)
            End Get
            Set(ByVal value As Single)
                Me._XYAngle = CDbl(value)
            End Set
        End Property

        ' Token: 0x17000444 RID: 1092
        ' (get) Token: 0x06000C5A RID: 3162 RVA: 0x00280C4C File Offset: 0x0027FC4C
        ' (set) Token: 0x06000C5B RID: 3163 RVA: 0x00280C60 File Offset: 0x0027FC60
        Public Property SpawnPointBearing() As Single
            Get
                Return Me._Bearing
            End Get
            Set(ByVal value As Single)
                Me._Bearing = value
                If Me._Bearing < 0.0F Then
                    Me._SpawnPointXYAngle = CDbl(Me._Bearing) / 3.1415926535897931 * 180.0 + 360.0
                Else
                    Me._SpawnPointXYAngle = CDbl(Me._Bearing) / 3.1415926535897931 * 180.0
                End If
                Me.DrawXYOrientationSpawnPointBearing()
                Me.tbBearing.Text = StringType.FromSingle(value)
                RemoveHandler Me.nudXYSpawnPointBearing.ValueChanged, AddressOf Me.nudXYSpawnPointBearing_ValueChanged
                Me.nudXYSpawnPointBearing.Value = New Decimal(Me._SpawnPointXYAngle)
                AddHandler Me.nudXYSpawnPointBearing.ValueChanged, AddressOf Me.nudXYSpawnPointBearing_ValueChanged
            End Set
        End Property

        ' Token: 0x17000445 RID: 1093
        ' (get) Token: 0x06000C5C RID: 3164 RVA: 0x00280D2C File Offset: 0x0027FD2C
        ' (set) Token: 0x06000C5D RID: 3165 RVA: 0x00280D40 File Offset: 0x0027FD40
        Public Property SpawnPointXYAngle() As Single
            Get
                Return CSng(Me._SpawnPointXYAngle)
            End Get
            Set(ByVal value As Single)
                Me._SpawnPointXYAngle = CDbl(value)
            End Set
        End Property

        ' Token: 0x17000446 RID: 1094
        ' (get) Token: 0x06000C5E RID: 3166 RVA: 0x00280D4C File Offset: 0x0027FD4C
        ' (set) Token: 0x06000C5F RID: 3167 RVA: 0x00280D60 File Offset: 0x0027FD60
        Public Property SpawnPoints() As GFFType16()
            Get
                Return Me._SpawnPoints
            End Get
            Set(ByVal value As GFFType16())
                Me._SpawnPoints = value
                Dim num As Integer = 1
                Dim length As Integer = Me._SpawnPoints.Length
                For i As Integer = num To length
                    Me.lbSpawnPoints.Items.Add(i)
                Next
            End Set
        End Property

        ' Token: 0x17000447 RID: 1095
        ' (get) Token: 0x06000C60 RID: 3168 RVA: 0x00280DA4 File Offset: 0x0027FDA4
        ' (set) Token: 0x06000C61 RID: 3169 RVA: 0x00280DB8 File Offset: 0x0027FDB8
        Public Property NameLang() As Integer
            Get
                Return Me._nameLang
            End Get
            Set(ByVal value As Integer)
                Me._nameLang = value
            End Set
        End Property

        ' Token: 0x17000448 RID: 1096
        ' (get) Token: 0x06000C62 RID: 3170 RVA: 0x00280DC4 File Offset: 0x0027FDC4
        ' (set) Token: 0x06000C63 RID: 3171 RVA: 0x00280F8C File Offset: 0x0027FF8C
        Public Property CameraOrientationQuat() As GFFType16
            Get
                Dim gfftype As GFFType16 = New GFFType16()
                Dim num As Double = Convert.ToDouble(Me.nudCamOrientationX.Value) * 3.1415926535897931 / 180.0
                Dim num2 As Double = Convert.ToDouble(Me.nudCamOrientationY.Value) * 3.1415926535897931 / 180.0
                Dim num3 As Double = Convert.ToDouble(Me.nudCamOrientationZ.Value) * 3.1415926535897931 / 180.0
                Dim num4 As Double = Math.Cos(num3 / 2.0)
                Dim num5 As Double = Math.Cos(num2 / 2.0)
                Dim num6 As Double = Math.Cos(num / 2.0)
                Dim num7 As Double = Math.Sin(num3 / 2.0)
                Dim num8 As Double = Math.Sin(num2 / 2.0)
                Dim num9 As Double = Math.Sin(num / 2.0)
                Dim num10 As Double = num4 * num5 * num6 - num7 * num8 * num9
                Dim num11 As Double = num4 * num5 * num9 - num7 * num8 * num6
                Dim num12 As Double = num4 * num8 * num6 + num7 * num5 * num9
                Dim num13 As Double = num7 * num5 * num6 - num4 * num8 * num9
                Dim num14 As Double = Math.Sqrt(Math.Pow(num10, 2.0) + Math.Pow(num11, 2.0) + Math.Pow(num12, 2.0) + Math.Pow(num13, 2.0))
                gfftype.W = Convert.ToSingle(num10 / num14)
                gfftype.X = Convert.ToSingle(num11 / num14)
                gfftype.Y = Convert.ToSingle(num12 / num14)
                gfftype.Z = Convert.ToSingle(num13 / num14)
                Return gfftype
            End Get
            Set(ByVal value As GFFType16)
                Me.tbCamOrientationF1.Text = StringType.FromSingle(value.W)
                Me.tbCamOrientationF2.Text = StringType.FromSingle(value.X)
                Me.tbCamOrientationF3.Text = StringType.FromSingle(value.Y)
                Me.tbCamOrientationF4.Text = StringType.FromSingle(value.Z)
            End Set
        End Property

        ' Token: 0x17000449 RID: 1097
        ' (get) Token: 0x06000C65 RID: 3173 RVA: 0x00281044 File Offset: 0x00280044
        ' (set) Token: 0x06000C64 RID: 3172 RVA: 0x00280FF4 File Offset: 0x0027FFF4
        Public Property CameraOrientationEulerAngles() As GFFType17
            Get
                Return New GFFType17() With {.X = Convert.ToSingle(Me.nudCamOrientationX.Value), .Y = Convert.ToSingle(Me.nudCamOrientationY.Value), .Z = Convert.ToSingle(Me.nudCamOrientationZ.Value)}
            End Get
            Set(ByVal value As GFFType17)
                Me.nudCamOrientationX.Value = New Decimal(value.X)
                Me.nudCamOrientationY.Value = New Decimal(value.Y)
                Me.nudCamOrientationZ.Value = New Decimal(value.Z)
            End Set
        End Property

        ' Token: 0x06000C66 RID: 3174 RVA: 0x0028109C File Offset: 0x0028009C
        Private Sub btnSetNameLang_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim frmCExoLocStringLanguagePicker As frmCExoLocStringLanguagePicker = New frmCExoLocStringLanguagePicker(Me.NameLang)
            If frmCExoLocStringLanguagePicker.ShowDialog(Me) = DialogResult.OK Then
                Me.NameLang = frmCExoLocStringLanguagePicker.LanguageID
            End If
        End Sub

        ' Token: 0x06000C67 RID: 3175 RVA: 0x002810CC File Offset: 0x002800CC
        Private Sub nudXY_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Me._XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientation()
            Me._XOrientation = -CSng(Math.Round(Math.Cos((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me._YOrientation = CSng(Math.Round(Math.Sin((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me.tbxo.Text = StringType.FromSingle(Me._XOrientation)
            Me.tbyo.Text = StringType.FromSingle(Me._YOrientation)
        End Sub

        ' Token: 0x06000C68 RID: 3176 RVA: 0x0028119C File Offset: 0x0028019C
        Private Sub nudXY_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me._XYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientation()
            Me._XOrientation = -CSng(Math.Round(Math.Cos((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me._YOrientation = CSng(Math.Round(Math.Sin((Me._XYAngle + 90.0) / 180.0 * 3.1415926535897931), 5))
            Me.tbxo.Text = StringType.FromSingle(Me._XOrientation)
            Me.tbyo.Text = StringType.FromSingle(Me._YOrientation)
        End Sub

        ' Token: 0x06000C69 RID: 3177 RVA: 0x0028126C File Offset: 0x0028026C
        Private Sub nudXYSpawnPointBearing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me._SpawnPointXYAngle = DoubleType.FromObject(LateBinding.LateGet(sender, Nothing, "value", New Object(-1) {}, Nothing, Nothing))
            Me.DrawXYOrientationSpawnPointBearing()
            If Me._SpawnPointXYAngle <= 180.0 Then
                Me._Bearing = CSng((Me._SpawnPointXYAngle / 180.0 * 3.1415926535897931))
            Else
                Me._Bearing = CSng(((Me._SpawnPointXYAngle - 360.0) / 180.0 * 3.1415926535897931))
            End If
            If Me.lbSpawnPoints.SelectedIndex <> -1 Then
                Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).W = Me._Bearing
            End If
            Me.tbBearing.Text = StringType.FromSingle(Me._Bearing)
        End Sub

        ' Token: 0x06000C6A RID: 3178 RVA: 0x00281340 File Offset: 0x00280340
        Private Sub btnShowQuaternion_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.tbCamOrientationF1.Visible = True
            Me.tbCamOrientationF2.Visible = True
            Me.tbCamOrientationF3.Visible = True
            Me.tbCamOrientationF4.Visible = True
            Me.lblQuaternionW.Visible = True
        End Sub

        ' Token: 0x06000C6B RID: 3179 RVA: 0x00281380 File Offset: 0x00280380
        Private Sub btnShowQuaternion_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.tbCamOrientationF1.Visible = False
            Me.tbCamOrientationF2.Visible = False
            Me.tbCamOrientationF3.Visible = False
            Me.tbCamOrientationF4.Visible = False
            Me.lblQuaternionW.Visible = False
        End Sub

        ' Token: 0x06000C6C RID: 3180 RVA: 0x002813C0 File Offset: 0x002803C0
        Private Sub nudCamOrientation_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ErrorProvider1.SetError(Me.nudCamOrientationX, "")
        End Sub

        ' Token: 0x06000C6D RID: 3181 RVA: 0x002813D8 File Offset: 0x002803D8
        Private Sub lbSpawnPoints_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.nudSpawnPointX.Enabled = True
            Me.nudSpawnPointY.Enabled = True
            Me.nudSpawnPointZ.Enabled = True
            Me.nudXYSpawnPointBearing.Enabled = True
            Me.nudSpawnPointX.Value = New Decimal(Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).X)
            Me.nudSpawnPointY.Value = New Decimal(Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).Y)
            Me.nudSpawnPointZ.Value = New Decimal(Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).Z)
            Me.SpawnPointBearing = Me._SpawnPoints(Me.lbSpawnPoints.SelectedIndex).W
        End Sub

        ' Token: 0x06000C6E RID: 3182 RVA: 0x002814A8 File Offset: 0x002804A8
        Private Sub nudXYSpawnPointBearing_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Me.nudXYSpawnPointBearing.Value = Me.nudXYSpawnPointBearing.Value
        End Sub

        ' Token: 0x040005CC RID: 1484
        <AccessedThroughProperty("nudXYSpawnPointBearing")> _
        Private _nudXYSpawnPointBearing As NumericUpDown

        ' Token: 0x040005CD RID: 1485
        <AccessedThroughProperty("lblTransitionMsg")> _
        Private _lblTransitionMsg As Label

        ' Token: 0x040005CE RID: 1486
        <AccessedThroughProperty("lblDoorLinkedToTransitionDestin")> _
        Private _lblDoorLinkedToTransitionDestin As Label

        ' Token: 0x040005CF RID: 1487
        <AccessedThroughProperty("lblDoorLinkedToModule")> _
        Private _lblDoorLinkedToModule As Label

        ' Token: 0x040005D0 RID: 1488
        <AccessedThroughProperty("lblBearing")> _
        Private _lblBearing As Label

        ' Token: 0x040005D1 RID: 1489
        <AccessedThroughProperty("lblDoorLinkedToFlags")> _
        Private _lblDoorLinkedToFlags As Label

        ' Token: 0x040005D2 RID: 1490
        <AccessedThroughProperty("nudXY")> _
        Private _nudXY As NumericUpDown

        ' Token: 0x040005D3 RID: 1491
        <AccessedThroughProperty("lblDoorLinkedTo")> _
        Private _lblDoorLinkedTo As Label

        ' Token: 0x040005D4 RID: 1492
        <AccessedThroughProperty("pboxXY")> _
        Private _pboxXY As PictureBox

        ' Token: 0x040005D5 RID: 1493
        <AccessedThroughProperty("nudCamOrientationZ")> _
        Private _nudCamOrientationZ As NumericUpDown

        ' Token: 0x040005D6 RID: 1494
        <AccessedThroughProperty("nudCamOrientationY")> _
        Private _nudCamOrientationY As NumericUpDown

        ' Token: 0x040005D7 RID: 1495
        <AccessedThroughProperty("Label24")> _
        Private _Label24 As Label

        ' Token: 0x040005D8 RID: 1496
        <AccessedThroughProperty("nudCamOrientationX")> _
        Private _nudCamOrientationX As NumericUpDown

        ' Token: 0x040005D9 RID: 1497
        <AccessedThroughProperty("Label23")> _
        Private _Label23 As Label

        ' Token: 0x040005DA RID: 1498
        <AccessedThroughProperty("lblQuaternionW")> _
        Private _lblQuaternionW As Label

        ' Token: 0x040005DB RID: 1499
        <AccessedThroughProperty("Label22")> _
        Private _Label22 As Label

        ' Token: 0x040005DC RID: 1500 
        <AccessedThroughProperty("btnShowQuaternion")> _
        Private _btnShowQuaternion As Button

        ' Token: 0x040005DD RID: 1501
        <AccessedThroughProperty("Label21")> _
        Private _Label21 As Label

        ' Token: 0x040005DE RID: 1502
        <AccessedThroughProperty("ErrorProvider1")> _
        Private _ErrorProvider1 As ErrorProvider

        ' Token: 0x040005DF RID: 1503
        <AccessedThroughProperty("Label20")> _
        Private _Label20 As Label

        ' Token: 0x040005E0 RID: 1504
        <AccessedThroughProperty("tbCamOrientationY")> _
        Private _tbCamOrientationY As TextBox

        ' Token: 0x040005E1 RID: 1505
        <AccessedThroughProperty("Label19")> _
        Private _Label19 As Label

        ' Token: 0x040005E2 RID: 1506
        <AccessedThroughProperty("tbCamOrientationX")> _
        Private _tbCamOrientationX As TextBox

        ' Token: 0x040005E3 RID: 1507
        <AccessedThroughProperty("Label18")> _
        Private _Label18 As Label

        ' Token: 0x040005E4 RID: 1508 _
        <AccessedThroughProperty("tbCamOrientationZ")> _
        Private _tbCamOrientationZ As TextBox

        ' Token: 0x040005E5 RID: 1509
        <AccessedThroughProperty("Label17")> _
        Private _Label17 As Label

        ' Token: 0x040005E6 RID: 1510
        <AccessedThroughProperty("tabpagEncounter")> _
        Private _tabpagEncounter As TabPage

        ' Token: 0x040005E7 RID: 1511
        <AccessedThroughProperty("Label16")> _
        Private _Label16 As Label

        ' Token: 0x040005E8 RID: 1512
        <AccessedThroughProperty("gbTriggerNode")> _
        Private _gbTriggerNode As GroupBox

        ' Token: 0x040005E9 RID: 1513
        <AccessedThroughProperty("Label15")> _
        Private _Label15 As Label

        ' Token: 0x040005EA RID: 1514
        <AccessedThroughProperty("tbTriggerNodeZPosition")> _
        Private _tbTriggerNodeZPosition As TextBox

        ' Token: 0x040005EB RID: 1515
        <AccessedThroughProperty("Label14")> _
        Private _Label14 As Label

        ' Token: 0x040005EC RID: 1516
        <AccessedThroughProperty("tbTriggerNodeYPosition")> _
        Private _tbTriggerNodeYPosition As TextBox

        ' Token: 0x040005ED RID: 1517
        <AccessedThroughProperty("tbTriggerNodeXPosition")> _
        Private _tbTriggerNodeXPosition As TextBox

        ' Token: 0x040005EE RID: 1518
        <AccessedThroughProperty("tbCamOrientationF3")> _
        Private _tbCamOrientationF3 As TextBox

        ' Token: 0x040005EF RID: 1519
        <AccessedThroughProperty("tbCamOrientationF4")> _
        Private _tbCamOrientationF4 As TextBox

        ' Token: 0x040005F0 RID: 1520
        <AccessedThroughProperty("tbCamOrientationF2")> _
        Private _tbCamOrientationF2 As TextBox

        ' Token: 0x040005F1 RID: 1521
        <AccessedThroughProperty("tbCamOrientationF1")> _
        Private _tbCamOrientationF1 As TextBox

        ' Token: 0x040005F2 RID: 1522
        <AccessedThroughProperty("Label12")> _
        Private _Label12 As Label

        ' Token: 0x040005F3 RID: 1523
        <AccessedThroughProperty("lbSpawnPoints")> _
        Private _lbSpawnPoints As ListBox

        ' Token: 0x040005F4 RID: 1524
        <AccessedThroughProperty("tbCamFieldOfView")> _
        Private _tbCamFieldOfView As TextBox

        ' Token: 0x040005F5 RID: 1525
        <AccessedThroughProperty("tbCamMicRange")> _
        Private _tbCamMicRange As TextBox

        ' Token: 0x040005F6 RID: 1526
        <AccessedThroughProperty("tbCamHeight")> _
        Private _tbCamHeight As TextBox

        ' Token: 0x040005F7 RID: 1527
        <AccessedThroughProperty("nudSpawnPointX")> _
        Private _nudSpawnPointX As NumericUpDown

        ' Token: 0x040005F8 RID: 1528
        <AccessedThroughProperty("nudSpawnPointY")> _
        Private _nudSpawnPointY As NumericUpDown

        ' Token: 0x040005F9 RID: 1529
        <AccessedThroughProperty("nudSpawnPointZ")> _
        Private _nudSpawnPointZ As NumericUpDown

        ' Token: 0x040005FA RID: 1530
        <AccessedThroughProperty("tbxo")> _
        Private _tbxo As TextBox

        ' Token: 0x040005FB RID: 1531
        <AccessedThroughProperty("tbCamPitch")> _
        Private _tbCamPitch As TextBox

        ' Token: 0x040005FC RID: 1532
        <AccessedThroughProperty("tbyo")> _
        Private _tbyo As TextBox

        ' Token: 0x040005FD RID: 1533
        <AccessedThroughProperty("tbBearing")> _
        Private _tbBearing As TextBox

        ' Token: 0x040005FE RID: 1534
        <AccessedThroughProperty("btnSetNameLang")> _
        Private _btnSetNameLang As Button

        ' Token: 0x040005FF RID: 1535
        <AccessedThroughProperty("Label25")> _
        Private _Label25 As Label

        ' Token: 0x04000600 RID: 1536
        <AccessedThroughProperty("tbWpMapNote")> _
        Private _tbWpMapNote As TextBox

        ' Token: 0x04000601 RID: 1537
        <AccessedThroughProperty("Button3")> _
        Private _Button3 As Button

        ' Token: 0x04000602 RID: 1538
        <AccessedThroughProperty("pboxXYSpawnPointBearing")> _
        Private _pboxXYSpawnPointBearing As PictureBox

        ' Token: 0x04000603 RID: 1539
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x04000604 RID: 1540
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button

        ' Token: 0x04000605 RID: 1541
        <AccessedThroughProperty("Label11")> _
        Private _Label11 As Label

        ' Token: 0x04000606 RID: 1542
        <AccessedThroughProperty("lblResRef")> _
        Private _lblResRef As Label

        ' Token: 0x04000607 RID: 1543
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x04000608 RID: 1544
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label

        ' Token: 0x04000609 RID: 1545
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label

        ' Token: 0x0400060A RID: 1546
        <AccessedThroughProperty("Label26")> _
        Private _Label26 As Label

        ' Token: 0x0400060B RID: 1547
        <AccessedThroughProperty("Label27")> _
        Private _Label27 As Label

        ' Token: 0x0400060C RID: 1548
        <AccessedThroughProperty("cmbxDoorLinkedToFlags")> _
        Private _cmbxDoorLinkedToFlags As ComboBox

        ' Token: 0x0400060D RID: 1549
        <AccessedThroughProperty("tbXPosition")> _
        Private _tbXPosition As TextBox

        ' Token: 0x0400060E RID: 1550
        <AccessedThroughProperty("tbYPosition")> _
        Private _tbYPosition As TextBox

        ' Token: 0x0400060F RID: 1551
        <AccessedThroughProperty("Label28")> _
        Private _Label28 As Label

        ' Token: 0x04000610 RID: 1552
        <AccessedThroughProperty("tbZPosition")> _
        Private _tbZPosition As TextBox

        ' Token: 0x04000611 RID: 1553
        <AccessedThroughProperty("Button2")> _
        Private _Button2 As Button

        ' Token: 0x04000612 RID: 1554
        <AccessedThroughProperty("Label29")> _
        Private _Label29 As Label

        ' Token: 0x04000613 RID: 1555
        <AccessedThroughProperty("tbResRef")> _
        Private _tbResRef As TextBox

        ' Token: 0x04000614 RID: 1556
        <AccessedThroughProperty("tbTag")> _
        Private _tbTag As TextBox

        ' Token: 0x04000615 RID: 1557
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

        ' Token: 0x04000616 RID: 1558
        <AccessedThroughProperty("tabpagCamera")> _
        Private _tabpagCamera As TabPage

        ' Token: 0x04000617 RID: 1559
        <AccessedThroughProperty("lblTag")> _
        Private _lblTag As Label

        ' Token: 0x04000618 RID: 1560
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label

        ' Token: 0x04000619 RID: 1561
        <AccessedThroughProperty("tabpagDoor")> _
        Private _tabpagDoor As TabPage

        ' Token: 0x0400061A RID: 1562
        <AccessedThroughProperty("Label7")> _
        Private _Label7 As Label

        ' Token: 0x0400061B RID: 1563
        <AccessedThroughProperty("tabpagGeneral")> _
        Private _tabpagGeneral As TabPage

        ' Token: 0x0400061C RID: 1564
        <AccessedThroughProperty("tabctrl")> _
        Private _tabctrl As TabControl

        ' Token: 0x0400061D RID: 1565
        <AccessedThroughProperty("chkbMapNoteEnabled")> _
        Private _chkbMapNoteEnabled As CheckBox

        ' Token: 0x0400061E RID: 1566
        <AccessedThroughProperty("chkbHasMapNote")> _
        Private _chkbHasMapNote As CheckBox

        ' Token: 0x0400061F RID: 1567
        <AccessedThroughProperty("lblLocalizedName")> _
        Private _lblLocalizedName As Label

        ' Token: 0x04000620 RID: 1568
        <AccessedThroughProperty("tabpagWaypoint")> _
        Private _tabpagWaypoint As TabPage

        ' Token: 0x04000621 RID: 1569
        <AccessedThroughProperty("tbWpLocalizedName")> _
        Private _tbWpLocalizedName As TextBox

        ' Token: 0x04000622 RID: 1570
        <AccessedThroughProperty("Label9")> _
        Private _Label9 As Label

        ' Token: 0x04000623 RID: 1571
        <AccessedThroughProperty("tbDoorLinkedTo")> _
        Private _tbDoorLinkedTo As TextBox

        ' Token: 0x04000624 RID: 1572
        <AccessedThroughProperty("tbDoorLinkedToModule")> _
        Private _tbDoorLinkedToModule As TextBox

        ' Token: 0x04000625 RID: 1573
        <AccessedThroughProperty("tbWpDescription")> _
        Private _tbWpDescription As TextBox

        ' Token: 0x04000626 RID: 1574
        <AccessedThroughProperty("tbDoorLinkedToTransitionDestin")> _
        Private _tbDoorLinkedToTransitionDestin As TextBox

        ' Token: 0x04000627 RID: 1575
        <AccessedThroughProperty("tbWPLinkedTo")> _
        Private _tbWPLinkedTo As TextBox

        ' Token: 0x04000629 RID: 1577
        Private bmpXY As Bitmap

        ' Token: 0x0400062A RID: 1578
        Private bmpXYSpawnPointBearing As Bitmap

        ' Token: 0x0400062B RID: 1579
        Private _XYAngle As Double

        ' Token: 0x0400062C RID: 1580
        Private _SpawnPointXYAngle As Double

        ' Token: 0x0400062D RID: 1581
        Private _XOrientation As Single

        ' Token: 0x0400062E RID: 1582
        Private _YOrientation As Single

        ' Token: 0x0400062F RID: 1583
        Private _ZOrientation As Single

        ' Token: 0x04000630 RID: 1584
        Private _Bearing As Single

        ' Token: 0x04000631 RID: 1585
        Private _SpawnPoints As GFFType16()

        ' Token: 0x04000632 RID: 1586
        Private _nameLang As Integer
    End Class
End Namespace
