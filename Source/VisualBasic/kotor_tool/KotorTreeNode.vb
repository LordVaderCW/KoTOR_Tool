Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000086 RID: 134
	Public Class KotorTreeNode
		Inherits TreeNode

		' Token: 0x0600170A RID: 5898 RVA: 0x002CB1A0 File Offset: 0x002CA1A0
		Public Overrides Function ToString() As String
			Return Me.Text
		End Function

		' Token: 0x170008BB RID: 2235
		' (get) Token: 0x0600170B RID: 5899 RVA: 0x002CB1B4 File Offset: 0x002CA1B4
		' (set) Token: 0x0600170C RID: 5900 RVA: 0x002CB1F8 File Offset: 0x002CA1F8
		Public Property Filename As String
			Get
				If StringType.StrCmp(Me.mFileName, "", False) <> 0 Then
					Return Me.mFileName
				End If
				Return Me.mResRef + "." + frmMain.GetRsrcTypeForID(Me.mResType)
			End Get
			Set(value As String)
				Me.mFileName = value
			End Set
		End Property

		' Token: 0x170008BC RID: 2236
		' (get) Token: 0x0600170D RID: 5901 RVA: 0x002CB204 File Offset: 0x002CA204
		Public ReadOnly Property ResTypeStr As String
			Get
				Return frmMain.GetRsrcTypeForID(Me.mResType)
			End Get
		End Property

		' Token: 0x170008BD RID: 2237
		' (get) Token: 0x0600170E RID: 5902 RVA: 0x002CB21C File Offset: 0x002CA21C
		' (set) Token: 0x0600170F RID: 5903 RVA: 0x002CB230 File Offset: 0x002CA230
		Public Property ResType As Integer
			Get
				Return Me.mResType
			End Get
			Set(value As Integer)
				Me.mResType = value
			End Set
		End Property

		' Token: 0x170008BE RID: 2238
		' (get) Token: 0x06001710 RID: 5904 RVA: 0x002CB23C File Offset: 0x002CA23C
		Public ReadOnly Property ResRef As String
			Get
				Return Me.mResRef
			End Get
		End Property

		' Token: 0x170008BF RID: 2239
		' (get) Token: 0x06001711 RID: 5905 RVA: 0x002CB250 File Offset: 0x002CA250
		Public ReadOnly Property LocalResID As Integer
			Get
				Return Me.mResID And 1048575
			End Get
		End Property

		' Token: 0x170008C0 RID: 2240
		' (get) Token: 0x06001712 RID: 5906 RVA: 0x002CB26C File Offset: 0x002CA26C
		Public ReadOnly Property ResID As Integer
			Get
				Return Me.mResID
			End Get
		End Property

		' Token: 0x170008C1 RID: 2241
		' (get) Token: 0x06001713 RID: 5907 RVA: 0x002CB280 File Offset: 0x002CA280
		Public ReadOnly Property BiffFileNum As Integer
			Get
				Return Me.mResID >> 20
			End Get
		End Property

		' Token: 0x170008C2 RID: 2242
		' (get) Token: 0x06001714 RID: 5908 RVA: 0x002CB298 File Offset: 0x002CA298
		' (set) Token: 0x06001715 RID: 5909 RVA: 0x002CB2AC File Offset: 0x002CA2AC
		Public Property FilePath As String
			Get
				Return Me.mfilepath
			End Get
			Set(value As String)
				Me.mfilepath = value
			End Set
		End Property

		' Token: 0x170008C3 RID: 2243
		' (get) Token: 0x06001716 RID: 5910 RVA: 0x002CB2B8 File Offset: 0x002CA2B8
		' (set) Token: 0x06001717 RID: 5911 RVA: 0x002CB2CC File Offset: 0x002CA2CC
		Public Property RIMorERFindex As Integer
			Get
				Return Me.mRimOrErfIndex
			End Get
			Set(value As Integer)
				Me.mRimOrErfIndex = value
			End Set
		End Property

		' Token: 0x170008C4 RID: 2244
		' (get) Token: 0x06001718 RID: 5912 RVA: 0x002CB2D8 File Offset: 0x002CA2D8
		' (set) Token: 0x06001719 RID: 5913 RVA: 0x002CB2EC File Offset: 0x002CA2EC
		Public Property KotorVerIndex As Integer
			Get
				Return Me.mKotorVerIndex
			End Get
			Set(value As Integer)
				Me.mKotorVerIndex = value
			End Set
		End Property

		' Token: 0x0600171A RID: 5914 RVA: 0x002CB2F8 File Offset: 0x002CA2F8
		Public Sub New()
			Me.mKotorVerIndex = -1
		End Sub

		' Token: 0x0600171B RID: 5915 RVA: 0x002CB308 File Offset: 0x002CA308
		Public Sub New(text As String)
			MyBase.New(text)
			Me.mKotorVerIndex = -1
		End Sub

		' Token: 0x0600171C RID: 5916 RVA: 0x002CB318 File Offset: 0x002CA318
		Public Sub New(ke As KeyEntry)
			Me.mKotorVerIndex = -1
			Me.mResID = ke.ResID
			Me.mResRef = ke.ResRef
			Me.mResType = CInt(ke.ResourceType)
			Me.Text = ke.ResRef + "." + Me.ResTypeStr
		End Sub

		' Token: 0x0600171D RID: 5917 RVA: 0x002CB374 File Offset: 0x002CA374
		Public Sub New(ke As KeyEntry, sourcePath As String)
			Me.New(ke)
			Me.mfilepath = sourcePath
		End Sub

		' Token: 0x0600171E RID: 5918 RVA: 0x002CB384 File Offset: 0x002CA384
		Public Sub New(rke As RIMKeyEntry)
			Me.mKotorVerIndex = -1
			Me.mResID = CInt(rke._ResourceID)
			Me.mResRef = rke._ResourceName
			Me.mResType = CInt(rke._ResType)
			Me.Text = String.Concat(New String() { Me.mResRef, ".", Me.ResTypeStr, " (", StringType.FromInteger(rke._Length), ")" })
			Me.Tag = "RIM_Res"
		End Sub

		' Token: 0x0600171F RID: 5919 RVA: 0x002CB418 File Offset: 0x002CA418
		Public Sub New(rke As RIMKeyEntry, sourcePath As String)
			Me.New(rke)
			Me.mfilepath = sourcePath
		End Sub

		' Token: 0x06001720 RID: 5920 RVA: 0x002CB428 File Offset: 0x002CA428
		Public Sub New(eke As ERFKeyEntry)
			Me.mKotorVerIndex = -1
			Me.mResID = eke._ResourceID
			Me.mResRef = eke._ResourceName
			Me.mResType = CInt(eke._ResType)
			Me.Text = Me.mResRef + "." + Me.ResTypeStr
			Me.Tag = "ERF_Res"
		End Sub

		' Token: 0x06001721 RID: 5921 RVA: 0x002CB490 File Offset: 0x002CA490
		Public Sub New(eke As ERFKeyEntry, sourcePath As String)
			Me.New(eke)
			Me.mfilepath = sourcePath
		End Sub

		' Token: 0x04000B2D RID: 2861
		Private mResType As Integer

		' Token: 0x04000B2E RID: 2862
		Private mResRef As String

		' Token: 0x04000B2F RID: 2863
		Private mResID As Integer

		' Token: 0x04000B30 RID: 2864
		Private mfilepath As String

		' Token: 0x04000B31 RID: 2865
		Private mFileName As String

		' Token: 0x04000B32 RID: 2866
		Private mRimOrErfIndex As Integer

		' Token: 0x04000B33 RID: 2867
		Private mKotorVerIndex As Integer

		' Token: 0x04000B34 RID: 2868
		Public ContainingFileType As String
	End Class
End Namespace
