Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000013 RID: 19
	Public Class DLGConvListNode
		Inherits TreeNode

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x06000050 RID: 80 RVA: 0x0021BDD8 File Offset: 0x0021ADD8
		Public ReadOnly Property DialogColor As Color
			Get
				If Me.IsLink > 0 Then
					Return Color.Gray
				End If
				If Me.IsEntry Then
					Return Color.Red
				End If
				Return Color.Blue
			End Get
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x06000051 RID: 81 RVA: 0x0021BE0C File Offset: 0x0021AE0C
		Public ReadOnly Property IsEndDialog As Boolean
			Get
				Return Me.IsReply And (Me.Nodes.Count = 0)
			End Get
		End Property

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x06000052 RID: 82 RVA: 0x0021BE30 File Offset: 0x0021AE30
		Public ReadOnly Property IsContinueDialog As Boolean
			Get
				Return(StringType.StrCmp(Me.InternalText, "", False) = 0) And (Me.Nodes.Count > 0)
			End Get
		End Property

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000053 RID: 83 RVA: 0x0021BE60 File Offset: 0x0021AE60
		Public ReadOnly Property NodeDesc As String
			Get
				Dim text As String
				If Me.IsContinueDialog Then
					text = "[CONTINUE]"
				Else
					If Me.IsEntry Then
						If StringType.StrCmp(Me.Speaker, "", False) = 0 Then
							text = "[OWNER] - "
						Else
							text = "[" + Me.Speaker + "] - "
						End If
					End If
					text += Me.InternalText
					If Me.IsLink > 0 Then
						text += " (Link)"
					ElseIf Me.IsEndDialog Then
						text += " [END DIALOGUE]"
					End If
				End If
				Return text
			End Get
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000054 RID: 84 RVA: 0x0021BEF4 File Offset: 0x0021AEF4
		' (set) Token: 0x06000055 RID: 85 RVA: 0x0021BF08 File Offset: 0x0021AF08
		Public Property IsReply As Boolean
			Get
				Return Me.m_IsReply
			End Get
			Set(value As Boolean)
				Me.m_IsReply = value
				Me.m_IsEntry = Not value
			End Set
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000056 RID: 86 RVA: 0x0021BF1C File Offset: 0x0021AF1C
		' (set) Token: 0x06000057 RID: 87 RVA: 0x0021BF30 File Offset: 0x0021AF30
		Public Property IsEntry As Boolean
			Get
				Return Me.m_IsEntry
			End Get
			Set(value As Boolean)
				Me.m_IsEntry = value
				Me.m_IsReply = Not value
			End Set
		End Property

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000058 RID: 88 RVA: 0x0021BF44 File Offset: 0x0021AF44
		Public ReadOnly Property HasLinkedNodes As Boolean
			Get
				Return Me.LinkedNodesList IsNot Nothing AndAlso Me.LinkedNodesList.Count > 0
			End Get
		End Property

		' Token: 0x06000059 RID: 89 RVA: 0x0021BF6C File Offset: 0x0021AF6C
		Public Sub UpdateLinkedNodesText()
			If Me.HasLinkedNodes Then
				Try
					For Each obj As Object In Me.LinkedNodesList
						Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
						dlgconvListNode.InternalText = Me.InternalText
						dlgconvListNode.Text = dlgconvListNode.NodeDesc
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						CType(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600005A RID: 90 RVA: 0x0021BFE4 File Offset: 0x0021AFE4
		Public Sub New()
			Me.Script = ""
			Me.Speaker = ""
			Me.ActiveScript = ""
			Me.InternalText = ""
			Me.Comment = ""
			Me.Sound = ""
			Me.VO_ResRef = ""
			Me.Listener = ""
			Me.PlotIndex = -1
			Me.CamVidEffect = -1
		End Sub

		' Token: 0x0600005B RID: 91 RVA: 0x0021C060 File Offset: 0x0021B060
		Public Sub New(NodeText As String)
			MyBase.New(NodeText)
		End Sub

		' Token: 0x0600005C RID: 92 RVA: 0x0021C06C File Offset: 0x0021B06C
		Public Function Copy() As DLGConvListNode
			Dim dlgconvListNode As DLGConvListNode = New DLGConvListNode()
			dlgconvListNode.Speaker = Me.Speaker
			dlgconvListNode.ActiveScript = Me.ActiveScript
			dlgconvListNode.Text = Me.Text
			dlgconvListNode.InternalText = Me.InternalText
			dlgconvListNode.Script = Me.Script
			dlgconvListNode.Delay = Me.Delay
			dlgconvListNode.Comment = Me.Comment
			dlgconvListNode.Sound = Me.Sound
			dlgconvListNode.Quest = Me.Quest
			dlgconvListNode.QuestEntry = Me.QuestEntry
			dlgconvListNode.VO_ResRef = Me.VO_ResRef
			dlgconvListNode.PlotIndex = Me.PlotIndex
			dlgconvListNode.PlotXPPercentage = Me.PlotXPPercentage
			dlgconvListNode.Listener = Me.Listener
			dlgconvListNode.WaitFlags = Me.WaitFlags
			dlgconvListNode.CameraAngle = Me.CameraAngle
			dlgconvListNode.CamFieldOfView = Me.CamFieldOfView
			dlgconvListNode.FadeType = Me.FadeType
			dlgconvListNode.FadeDelay = Me.FadeDelay
			dlgconvListNode.FadeLength = Me.FadeLength
			dlgconvListNode.FadeColor = Me.FadeColor
			dlgconvListNode.TarHeightOffset = Me.TarHeightOffset
			dlgconvListNode.CamHeightOffset = Me.CamHeightOffset
			dlgconvListNode.SoundExists = Me.SoundExists
			If Me.LinkedNodesList IsNot Nothing Then
				dlgconvListNode.LinkedNodesList = CType(Me.LinkedNodesList.Clone(), ArrayList)
			End If
			dlgconvListNode.LinkedToNode = Me.LinkedToNode
			dlgconvListNode.IsEntry = Me.IsEntry
			dlgconvListNode.IsReply = Me.IsReply
			dlgconvListNode.IsLink = Me.IsLink
			Return dlgconvListNode
		End Function

		' Token: 0x04000072 RID: 114
		Public Animlist As ArrayList

		' Token: 0x04000073 RID: 115
		Public ActiveScript As String

		' Token: 0x04000074 RID: 116
		Public CameraAngle As Integer

		' Token: 0x04000075 RID: 117
		Public CameraID As Integer

		' Token: 0x04000076 RID: 118
		Public CamHeightOffset As Decimal

		' Token: 0x04000077 RID: 119
		Public CamFieldOfView As Decimal

		' Token: 0x04000078 RID: 120
		Public CamVidEffect As Integer

		' Token: 0x04000079 RID: 121
		Public Comment As String

		' Token: 0x0400007A RID: 122
		Public Delay As UInteger

		' Token: 0x0400007B RID: 123
		Public FadeType As Integer

		' Token: 0x0400007C RID: 124
		Public FadeDelay As Decimal

		' Token: 0x0400007D RID: 125
		Public FadeLength As Decimal

		' Token: 0x0400007E RID: 126
		Public FadeColor As GFFType17

		' Token: 0x0400007F RID: 127
		Public InternalText As String

		' Token: 0x04000080 RID: 128
		Public Listener As String

		' Token: 0x04000081 RID: 129
		Public PlotIndex As Integer

		' Token: 0x04000082 RID: 130
		Public PlotXPPercentage As Decimal

		' Token: 0x04000083 RID: 131
		Public Quest As String

		' Token: 0x04000084 RID: 132
		Public QuestEntry As UInteger

		' Token: 0x04000085 RID: 133
		Public Script As String

		' Token: 0x04000086 RID: 134
		Public Speaker As String

		' Token: 0x04000087 RID: 135
		Public Sound As String

		' Token: 0x04000088 RID: 136
		Public SoundExists As Integer

		' Token: 0x04000089 RID: 137
		Public TarHeightOffset As Decimal

		' Token: 0x0400008A RID: 138
		Public VO_ResRef As String

		' Token: 0x0400008B RID: 139
		Public WaitFlags As Integer

		' Token: 0x0400008C RID: 140
		Public IsLink As Byte

		' Token: 0x0400008D RID: 141
		Public LinkID As Integer

		' Token: 0x0400008E RID: 142
		Public LinkedToIndex As Integer

		' Token: 0x0400008F RID: 143
		Public LinkedNodesList As ArrayList

		' Token: 0x04000090 RID: 144
		Public LinkedToNode As DLGConvListNode

		' Token: 0x04000091 RID: 145
		Private m_IsEntry As Boolean

		' Token: 0x04000092 RID: 146
		Private m_IsReply As Boolean

		' Token: 0x04000093 RID: 147
		Public LinkDesc As String

		' Token: 0x04000094 RID: 148
		Public NodeOriginalPath As String
	End Class
End Namespace
