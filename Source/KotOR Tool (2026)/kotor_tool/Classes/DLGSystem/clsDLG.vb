Imports System
Imports System.Collections
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000012 RID: 18
	Public Class clsDLG
		' Token: 0x06000042 RID: 66 RVA: 0x0021A790 File Offset: 0x00219790
		Public Overrides Function ToString() As String
			Return Me.dlgGff.ToString()
		End Function

		' Token: 0x06000043 RID: 67 RVA: 0x0021A7A8 File Offset: 0x002197A8
		Public Sub New(KotorVerIndex As Integer)
			Me.nodeHT = New Hashtable()
			Me.IsDebugMode = False
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.clsDialogTlk = New clsDialogTlk(Me.CurrentSettings.KotorLocation(KotorVerIndex) + "\dialog.tlk", False)
		End Sub

		' Token: 0x06000044 RID: 68 RVA: 0x0021A7FC File Offset: 0x002197FC
		Public Sub New(ByRef extTV As TreeView, KotorVerIndex As Integer)
			Me.New(KotorVerIndex)
			Me.tv = extTV
			Me.tv.Nodes.Add(New DLGConvListNode("Root"))
			CType(Me.tv.Nodes(0), DLGConvListNode).IsReply = True
			Me.dlgGff = New clsGFF(KotorVerIndex)
			Me.dlgGff.CreateList("", "EntryList")
			Me.dlgGff.CreateList("", "ReplyList")
			Me.dlgGff.CreateList("", "StartingList")
			Me.dlgGff.CreateList("", "StuntList")
		End Sub

		' Token: 0x06000045 RID: 69 RVA: 0x0021A8B0 File Offset: 0x002198B0
		Public Sub New(bytes As Byte(), ByRef extTV As TreeView, KotorVerIndex As Integer)
			Me.New(KotorVerIndex)
			Me.dlgGff = New clsGFF(bytes, KotorVerIndex, True)
			Me.tv = extTV
			Me.LoadAndProcess()
		End Sub

		' Token: 0x06000046 RID: 70 RVA: 0x0021A8D8 File Offset: 0x002198D8
		Public Sub New(fs As FileStream, ByRef extTV As TreeView, KotorVerIndex As Integer)
			Me.New(KotorVerIndex)
			Me.dlgGff = New clsGFF(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x06000047 RID: 71 RVA: 0x0021A8F0 File Offset: 0x002198F0
		Public Sub New(filepath As String, ByRef extTV As TreeView, KotorVerIndex As Integer)
			Me.New(KotorVerIndex)
			Dim fileStream As FileStream = New FileStream(filepath, FileMode.Open, FileAccess.Read)
			Me.dlgGff = New clsGFF(fileStream, KotorVerIndex, True)
			Me.tv = extTV
			Me.LoadAndProcess()
		End Sub

		' Token: 0x06000048 RID: 72 RVA: 0x0021A92C File Offset: 0x0021992C
		Private Sub LoadAndProcess()
			Me.tv.Nodes.Add(New DLGConvListNode("Root"))
			CType(Me.tv.Nodes(0), DLGConvListNode).IsReply = True
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dlgGff.GetListItemCount("StartingList") - 1
			For i As Integer = num To num2
				Dim num3 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dlgGff.GetNodeValue("StartingList(" + StringType.FromInteger(i) + ").Index")))
				Dim gffexoLocString As GFFExoLocString = CType(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").Text"), GFFExoLocString)
				Dim text As String
				If gffexoLocString.StringRef = -1 Then
					If gffexoLocString.StringCount > 0 Then
						Dim gffexoLocSubString As GFFExoLocSubString = CType(gffexoLocString.subStringArr(0), GFFExoLocSubString)
						text = gffexoLocSubString.value
					Else
						text = ""
					End If
				Else
					text = Me.clsDialogTlk.GetString(gffexoLocString.StringRef)
				End If
				Dim dlgconvListNode As DLGConvListNode = New DLGConvListNode()
				dlgconvListNode.LinkID = num3
				dlgconvListNode.LinkDesc = "S" + num3.ToString()
				Me.nodeHT.Add("E" + num3.ToString(), "")
				dlgconvListNode.IsEntry = True
				dlgconvListNode.NodeOriginalPath = "StartingList(" + StringType.FromInteger(i) + ")"
				dlgconvListNode.ForeColor = Color.Red
				dlgconvListNode.ActiveScript = StringType.FromObject(Me.dlgGff.GetNodeValue("StartingList(" + StringType.FromInteger(i) + ").Active"))
				dlgconvListNode.Comment = StringType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").Comment"))
				dlgconvListNode.Delay = CUInt((If(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").Delay"), Activator.CreateInstance(GetType(UInteger)))))
				dlgconvListNode.InternalText = text
				dlgconvListNode.Quest = StringType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").Quest"))
				dlgconvListNode.Sound = StringType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").Sound"))
				dlgconvListNode.Script = StringType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").Script"))
				dlgconvListNode.Speaker = StringType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").Speaker"))
				dlgconvListNode.VO_ResRef = StringType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").VO_ResRef"))
				dlgconvListNode.SoundExists = IntegerType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").SoundExists"))
				dlgconvListNode.PlotIndex = IntegerType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").PlotIndex"))
				dlgconvListNode.PlotXPPercentage = DecimalType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").PlotXPPercentage"))
				dlgconvListNode.Listener = StringType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").Listener"))
				dlgconvListNode.WaitFlags = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").WaitFlags")))
				dlgconvListNode.CameraAngle = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").CameraAngle")))
				dlgconvListNode.CameraID = IntegerType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").CameraID"))
				dlgconvListNode.CamVidEffect = IntegerType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").CamVidEffect"))
				dlgconvListNode.FadeType = IntegerType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").FadeType"))
				dlgconvListNode.FadeDelay = DecimalType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").FadeDelay"))
				dlgconvListNode.FadeLength = DecimalType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").FadeLength"))
				dlgconvListNode.TarHeightOffset = DecimalType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").TarHeightOffset"))
				dlgconvListNode.CamHeightOffset = DecimalType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").CamHeightOffset"))
				dlgconvListNode.FadeColor = CType(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").FadeColor"), GFFType17)
				dlgconvListNode.CamFieldOfView = DecimalType.FromObject(Me.dlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").CamFieldOfView"))
				If Me.dlgGff.VerifyNodeExists("EntryList(" + StringType.FromInteger(num3) + ").AnimList") AndAlso Me.dlgGff.GetListItemCount("EntryList(" + StringType.FromInteger(num3) + ").AnimList") > 0 Then
					dlgconvListNode.Animlist = New ArrayList()
					Dim num4 As Integer = 0
					Dim num5 As Integer = Me.dlgGff.GetListItemCount("EntryList(" + StringType.FromInteger(num3) + ").AnimList") - 1
					For j As Integer = num4 To num5
						Dim animListEntry As AnimListEntry = New AnimListEntry()
						animListEntry.Participant = RuntimeHelpers.GetObjectValue(Me.dlgGff.GetNodeValue(String.Concat(New String() { "EntryList(", StringType.FromInteger(num3), ").AnimList(", StringType.FromInteger(j), ").Participant" })))
						animListEntry.Animation = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dlgGff.GetNodeValue(String.Concat(New String() { "EntryList(", StringType.FromInteger(num3), ").AnimList(", StringType.FromInteger(j), ").Animation" }))))
						dlgconvListNode.Animlist.Add(animListEntry)
					Next
				End If
				dlgconvListNode.Text = dlgconvListNode.NodeDesc
				Me.tv.Nodes(0).Nodes.Add(dlgconvListNode)
				Me.BuildTV("EntryList(" + StringType.FromInteger(num3) + ")", CType(Me.tv.Nodes(0).Nodes(i), DLGConvListNode))
			Next
			Me.EntryNodeList = New ArrayList()
			Me.ReplyNodeList = New ArrayList()
			Me.ScanTVForEntryNodes(CType(Me.tv.Nodes(0), DLGConvListNode), "Root")
			Me.ScanTVForLinkNodes(CType(Me.tv.Nodes(0), DLGConvListNode), "Root")
		End Sub

		' Token: 0x06000049 RID: 73 RVA: 0x0021B0E4 File Offset: 0x0021A0E4
		Public Sub BuildTV(listItemPath As String, dlgNode As DLGConvListNode)
			Dim text As String
			Dim text2 As String
			If listItemPath.StartsWith("EntryList") Then
				text = "RepliesList"
				text2 = "ReplyList"
			Else
				text = "EntriesList"
				text2 = "EntryList"
			End If
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dlgGff.GetListItemCount(listItemPath + "." + text) - 1
			For i As Integer = num To num2
				Dim dlgconvListNode As DLGConvListNode = New DLGConvListNode()
				If listItemPath.StartsWith("ReplyList") Then
					dlgconvListNode.ForeColor = Color.Red
					dlgconvListNode.IsEntry = True
				Else
					dlgconvListNode.ForeColor = Color.Blue
					dlgconvListNode.IsReply = True
				End If
				Dim num3 As Integer = IntegerType.FromObject(Me.dlgGff.GetNodeValue(String.Concat(New String() { listItemPath, ".", text, "(", StringType.FromInteger(i), ").IsChild" })))
				Dim num4 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dlgGff.GetNodeValue(String.Concat(New String() { listItemPath, ".", text, "(", StringType.FromInteger(i), ").Index" }))))
				dlgconvListNode.LinkID = num4
				dlgconvListNode.NodeOriginalPath = listItemPath
				If listItemPath.StartsWith("ReplyList") Then
					dlgconvListNode.LinkDesc = "E" + StringType.FromInteger(num4)
					If num3 <> 0 Then
						Dim dlgconvListNode2 As DLGConvListNode = dlgconvListNode
						dlgconvListNode2.LinkDesc += " (L)"
					End If
				Else
					dlgconvListNode.LinkDesc = "R" + StringType.FromInteger(num4)
				End If
				Dim gffexoLocString As GFFExoLocString = CType(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").Text"), GFFExoLocString)
				If gffexoLocString.StringRef = -1 Then
					If gffexoLocString.StringCount > 0 AndAlso CType(gffexoLocString.subStringArr(0), GFFExoLocSubString).StringLength > 0 Then
						Dim gffexoLocSubString As GFFExoLocSubString = CType(gffexoLocString.subStringArr(0), GFFExoLocSubString)
						dlgconvListNode.InternalText = gffexoLocSubString.value
					Else
						dlgconvListNode.InternalText = ""
					End If
				Else
					dlgconvListNode.InternalText = Me.clsDialogTlk.GetString(gffexoLocString.StringRef)
				End If
				Dim text3 As String = String.Concat(New String() { text2, "(", StringType.FromInteger(num4), ").", Me.GetOppositeRepliesListName(text) })
				Dim text4 As String
				If Me.dlgGff.GetListItemCount(text3) = 0 Then
					text4 = dlgconvListNode.InternalText + "[END DIALOGUE]"
				ElseIf dlgconvListNode.InternalText.Length = 0 Then
					text4 = "[CONTINUE]"
				Else
					text4 = dlgconvListNode.InternalText
				End If
				dlgconvListNode.ActiveScript = StringType.FromObject(Me.dlgGff.GetNodeValue(String.Concat(New String() { listItemPath, ".", text, "(", StringType.FromInteger(i), ").Active" })))
				dlgconvListNode.Comment = StringType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").Comment"))
				dlgconvListNode.Delay = CUInt((If(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").Delay"), Activator.CreateInstance(GetType(UInteger)))))
				dlgconvListNode.Quest = StringType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").Quest"))
				If StringType.StrCmp(dlgconvListNode.Quest, "", False) <> 0 Then
					dlgconvListNode.QuestEntry = CUInt((If(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").QuestEntry"), Activator.CreateInstance(GetType(UInteger)))))
				End If
				dlgconvListNode.Sound = StringType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").Sound"))
				dlgconvListNode.Script = StringType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").Script"))
				dlgconvListNode.Speaker = StringType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").Speaker"))
				dlgconvListNode.VO_ResRef = StringType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").VO_ResRef"))
				dlgconvListNode.SoundExists = IntegerType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").SoundExists"))
				dlgconvListNode.PlotIndex = IntegerType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").PlotIndex"))
				dlgconvListNode.PlotXPPercentage = DecimalType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").PlotXPPercentage"))
				dlgconvListNode.Listener = StringType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").Listener"))
				dlgconvListNode.WaitFlags = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").WaitFlags")))
				dlgconvListNode.CameraAngle = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").CameraAngle")))
				dlgconvListNode.CameraID = IntegerType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").CameraID"))
				dlgconvListNode.CamVidEffect = IntegerType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").CamVidEffect"))
				dlgconvListNode.FadeType = IntegerType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").FadeType"))
				dlgconvListNode.FadeDelay = DecimalType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").FadeDelay"))
				dlgconvListNode.FadeLength = DecimalType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").FadeLength"))
				dlgconvListNode.TarHeightOffset = DecimalType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").TarHeightOffset"))
				dlgconvListNode.CamHeightOffset = DecimalType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").CamHeightOffset"))
				dlgconvListNode.FadeColor = CType(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").FadeColor"), GFFType17)
				dlgconvListNode.CamFieldOfView = DecimalType.FromObject(Me.dlgGff.GetNodeValue(text2 + "(" + StringType.FromInteger(num4) + ").CamFieldOfView"))
				Dim flag As Boolean
				Dim text5 As String
				If Not listItemPath.StartsWith("EntryList") And Not flag Then
					If StringType.StrCmp(dlgconvListNode.Speaker, "", False) = 0 Then
						text5 = "[OWNER] - "
					Else
						text5 = "[" + dlgconvListNode.Speaker + "] - "
					End If
				Else
					text5 = ""
				End If
				If num3 = 0 Then
					dlgconvListNode.Text = text5 + text4
					dlgconvListNode.IsLink = 0
				Else
					dlgconvListNode.IsLink = 1
					dlgconvListNode.Text = text5 + text4 + " (Link)"
					dlgconvListNode.LinkedToIndex = num4
					dlgconvListNode.ForeColor = Color.Gray
				End If
				dlgNode.Nodes.Add(dlgconvListNode)
				If num3 = 0 Then
					If Me.IsDebugMode Then
						Console.WriteLine(String.Concat(New String() { "Parent Node ", dlgNode.LinkDesc, " of Node ", dlgconvListNode.LinkDesc, " is not a link, scanning children..." }))
					End If
					Me.BuildTV(text2 + "(" + StringType.FromInteger(num4) + ")", CType(dlgNode.Nodes(i), DLGConvListNode))
				ElseIf Me.IsDebugMode Then
					Console.WriteLine(String.Concat(New String() { "Node ", dlgNode.LinkDesc, " of Node ", dlgconvListNode.LinkDesc, " is a link, scanning children skipped" }))
				End If
			Next
		End Sub

		' Token: 0x0600004A RID: 74 RVA: 0x0021B9F0 File Offset: 0x0021A9F0
		Private Sub ScanTVForEntryNodes(innode As DLGConvListNode, CurrNodeType As String)
			Try
				For Each obj As Object In innode.Nodes
					Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
					If Not dlgconvListNode.IsLink > 0 Then
						If StringType.StrCmp(CurrNodeType, "Entry", False) = 0 Then
							Me.ReplyNodeList.Add(dlgconvListNode)
							Me.ScanTVForEntryNodes(dlgconvListNode, "Reply")
						Else
							Me.EntryNodeList.Add(dlgconvListNode)
							Me.ScanTVForEntryNodes(dlgconvListNode, "Entry")
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600004B RID: 75 RVA: 0x0021BA98 File Offset: 0x0021AA98
		Private Sub DumpLists()
			Try
				For Each obj As Object In Me.EntryNodeList
					Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
					If dlgconvListNode.LinkedNodesList IsNot Nothing Then
						Try
							For Each obj2 As Object In dlgconvListNode.LinkedNodesList
								Dim dlgconvListNode2 As DLGConvListNode = CType(obj2, DLGConvListNode)
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								CType(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
					If dlgconvListNode.IsLink = 1 Then
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each obj3 As Object In Me.ReplyNodeList
					Dim dlgconvListNode As DLGConvListNode = CType(obj3, DLGConvListNode)
					If dlgconvListNode.LinkedNodesList IsNot Nothing Then
						Try
							For Each obj4 As Object In dlgconvListNode.LinkedNodesList
								Dim dlgconvListNode2 As DLGConvListNode = CType(obj4, DLGConvListNode)
							Next
						Finally
							Dim enumerator4 As IEnumerator
							If TypeOf enumerator4 Is IDisposable Then
								CType(enumerator4, IDisposable).Dispose()
							End If
						End Try
					End If
					If dlgconvListNode.IsLink = 1 Then
					End If
				Next
			Finally
				Dim enumerator3 As IEnumerator
				If TypeOf enumerator3 Is IDisposable Then
					CType(enumerator3, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600004C RID: 76 RVA: 0x0021BBE8 File Offset: 0x0021ABE8
		Private Sub ScanTVForLinkNodes(innode As DLGConvListNode, CurrNodeType As String)
			Try
				For Each obj As Object In innode.Nodes
					Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
					If StringType.StrCmp(CurrNodeType, "Entry", False) = 0 Then
						If dlgconvListNode.IsLink = 1 Then
							dlgconvListNode.LinkedToNode = Me.FindNodeInListByLinkID(Me.ReplyNodeList, dlgconvListNode.LinkedToIndex)
							If dlgconvListNode.Text Is Nothing Then
							End If
							If dlgconvListNode.LinkedToNode.LinkedNodesList Is Nothing Then
								dlgconvListNode.LinkedToNode.LinkedNodesList = New ArrayList()
							End If
							dlgconvListNode.LinkedToNode.LinkedNodesList.Add(dlgconvListNode)
						End If
						Me.ScanTVForLinkNodes(dlgconvListNode, "Reply")
					Else
						If dlgconvListNode.IsLink = 1 Then
							dlgconvListNode.LinkedToNode = Me.FindNodeInListByLinkID(Me.EntryNodeList, dlgconvListNode.LinkedToIndex)
							If dlgconvListNode.Text Is Nothing Then
							End If
							If dlgconvListNode.LinkedToNode.LinkedNodesList Is Nothing Then
								dlgconvListNode.LinkedToNode.LinkedNodesList = New ArrayList()
							End If
							dlgconvListNode.LinkedToNode.LinkedNodesList.Add(dlgconvListNode)
						End If
						Me.ScanTVForLinkNodes(dlgconvListNode, "Entry")
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600004D RID: 77 RVA: 0x0021BD28 File Offset: 0x0021AD28
		Private Function FindNodeInListByLinkID(list As ArrayList, id As Integer) As DLGConvListNode
			Dim dlgconvListNode2 As DLGConvListNode
			Try
				For Each obj As Object In list
					Dim dlgconvListNode As DLGConvListNode = CType(obj, DLGConvListNode)
					If dlgconvListNode.LinkID = id Then
						dlgconvListNode2 = dlgconvListNode
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return dlgconvListNode2
		End Function

		' Token: 0x0600004E RID: 78 RVA: 0x0021BD88 File Offset: 0x0021AD88
		Private Function GetOppositeMainListName(listName As String) As String
			If StringType.StrCmp(listName, "EntryList", False) = 0 Then
				Return "ReplyList"
			End If
			Return "EntryList"
		End Function

		' Token: 0x0600004F RID: 79 RVA: 0x0021BDB0 File Offset: 0x0021ADB0
		Private Function GetOppositeRepliesListName(listName As String) As String
			If StringType.StrCmp(listName, "EntriesList", False) = 0 Then
				Return "RepliesList"
			End If
			Return "EntriesList"
		End Function

		' Token: 0x04000069 RID: 105
		Public StartingList As ArrayList

		' Token: 0x0400006A RID: 106
		Public dlgGff As clsGFF

		' Token: 0x0400006B RID: 107
		Public tv As TreeView

		' Token: 0x0400006C RID: 108
		Private clsDialogTlk As clsDialogTlk

		' Token: 0x0400006D RID: 109
		Public EntryNodeList As ArrayList

		' Token: 0x0400006E RID: 110
		Public ReplyNodeList As ArrayList

		' Token: 0x0400006F RID: 111
		Private nodeHT As Hashtable

		' Token: 0x04000070 RID: 112
		Public CurrentSettings As Options

		' Token: 0x04000071 RID: 113
		Private IsDebugMode As Boolean
	End Class
End Namespace
