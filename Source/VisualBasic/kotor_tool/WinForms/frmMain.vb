Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace kotor_tool
    ' Token: 0x02000054 RID: 84
    Partial Public Class frmMain
        Inherits Form

        Private Sub WireModernToolbar()
            If Me.btnTool2DA IsNot Nothing Then
                RemoveHandler Me.btnTool2DA.Click, AddressOf Me.btnTool2DA_Click
                AddHandler Me.btnTool2DA.Click, AddressOf Me.btnTool2DA_Click
            End If

            If Me.btnToolConversation IsNot Nothing Then
                RemoveHandler Me.btnToolConversation.Click, AddressOf Me.btnToolConversation_Click
                AddHandler Me.btnToolConversation.Click, AddressOf Me.btnToolConversation_Click
            End If

            If Me.btnToolText IsNot Nothing Then
                RemoveHandler Me.btnToolText.Click, AddressOf Me.btnToolText_Click
                AddHandler Me.btnToolText.Click, AddressOf Me.btnToolText_Click
            End If

            If Me.btnToolERF IsNot Nothing Then
                RemoveHandler Me.btnToolERF.Click, AddressOf Me.btnToolERF_Click
                AddHandler Me.btnToolERF.Click, AddressOf Me.btnToolERF_Click
            End If
        End Sub

        Private Sub btnTool2DA_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Open2DAFileEditor()
        End Sub

        Private Sub btnToolConversation_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenConversationEditor()
        End Sub

        Private Sub btnToolText_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenTextEditor()
        End Sub

        Private Sub btnToolERF_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenERFBuilder()
        End Sub

        Private Sub LoadModernToolbarImages()
            Me.SetToolbarButtonImage(Me.btnTool2DA, "toolbar_2da")
            Me.SetToolbarButtonImage(Me.btnToolConversation, "toolbar_dialog")
            Me.SetToolbarButtonImage(Me.btnToolText, "toolbar_text")
            Me.SetToolbarButtonImage(Me.btnToolERF, "toolbar_erf")
        End Sub

        Private Sub SetToolbarButtonImage(ByVal button As Button, ByVal resourceName As String)
            If button Is Nothing Then
                Return
            End If

            If resourceName Is Nothing OrElse resourceName.Trim().Length = 0 Then
                Return
            End If

            Try
                Dim resourceObject As Object = My.Resources.ResourceManager.GetObject(resourceName)

                If resourceObject Is Nothing Then
                    Return
                End If

                If TypeOf resourceObject Is Image Then
                    button.Image = CType(resourceObject, Image)
                    button.ImageAlign = ContentAlignment.MiddleLeft
                    button.TextAlign = ContentAlignment.MiddleCenter
                    button.TextImageRelation = TextImageRelation.ImageBeforeText
                End If

            Catch ex As System.Exception
                Console.WriteLine("Toolbar image could not be loaded: " & resourceName & " - " & ex.Message)
            End Try
        End Sub


        Private Sub ApplyApplicationIcon()
            Try
                Me.Icon = My.Resources.koTOR_icn

            Catch ex As System.Exception
                Console.WriteLine("Application icon could not be applied: " & ex.Message)
            End Try
        End Sub

        Public Sub New(ByVal CmdArgs As String())
            AddHandler MyBase.Load, AddressOf Me.Form1_Load
            AddHandler MyBase.Closing, AddressOf Me.frmMain_Closing
            AddHandler MyBase.Move, AddressOf Me.frmMain_Move
            AddHandler MyBase.Activated, AddressOf Me.frmMain_Activated

            Me.BiffEntryListArray = New ArrayList(1, 30) {}
            Me.biffEntries = New ArrayList(2) {}
            Me.g_downloadURL = ""
            Me.g_CheckForUpdatesSilently = False
            Me.hasK1 = False
            Me.hasK2 = False
            Me.g_abbbIndex = 0

            Me.InitializeComponent()
            Me.ApplyApplicationIcon()
            Me.WireModernToolbar()
            Me.LoadModernToolbarImages()
            Me.InitialiseResourceBrowser()

            Me.CmdArgs = CmdArgs
        End Sub

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.Form1_Load
            AddHandler MyBase.Closing, AddressOf Me.frmMain_Closing
            AddHandler MyBase.Move, AddressOf Me.frmMain_Move
            AddHandler MyBase.Activated, AddressOf Me.frmMain_Activated

            Me.BiffEntryListArray = New ArrayList(1, 30) {}
            Me.biffEntries = New ArrayList(2) {}
            Me.g_downloadURL = ""
            Me.g_CheckForUpdatesSilently = False
            Me.hasK1 = False
            Me.hasK2 = False
            Me.g_abbbIndex = 0

            Me.InitializeComponent()
            Me.ApplyApplicationIcon()
            Me.WireModernToolbar()
            Me.LoadModernToolbarImages()
            Me.InitialiseResourceBrowser()
        End Sub

        ' Token: 0x060006E8 RID: 1768 RVA: 0x0024EC68 File Offset: 0x0024DC68
        Public Shared Function K1ChitinKey() As clsChitinKey
            If frmMain.gK1ChitinKey Is Nothing Then
                Dim settings As Options = UserSettings.GetSettings()
                frmMain.gK1ChitinKey = New clsChitinKey(settings.KeyFileLocation(0))
            End If
            Return frmMain.gK1ChitinKey
        End Function

        ' Token: 0x060006E9 RID: 1769 RVA: 0x0024EC98 File Offset: 0x0024DC98
        Public Shared Function K2ChitinKey() As clsChitinKey
            If frmMain.gK2ChitinKey Is Nothing Then
                Dim settings As Options = UserSettings.GetSettings()
                frmMain.gK2ChitinKey = New clsChitinKey(settings.KeyFileLocation(1))
            End If
            Return frmMain.gK2ChitinKey
        End Function

        ' Token: 0x060006EA RID: 1770 RVA: 0x0024ECC8 File Offset: 0x0024DCC8
        Public Shared Function KxChitinKey(ByVal KotorVerIndex As Integer) As clsChitinKey
            If KotorVerIndex = 0 Then
                Return frmMain.K1ChitinKey()
            End If
            If KotorVerIndex = 1 Then
                Return frmMain.K2ChitinKey()
            End If
            Dim clsChitinKey As clsChitinKey
            Return clsChitinKey
        End Function

        ' Token: 0x060006EB RID: 1771 RVA: 0x0024ECEC File Offset: 0x0024DCEC
        Public Shared Function K1TemplatesBif() As BIFFArchive
            If frmMain.gK1TemplatesBif Is Nothing Then
                Dim settings As Options = UserSettings.GetSettings()
                Dim fileStream As FileStream = New FileStream(settings.KotorLocation(0) + "\data\templates.bif", FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
                frmMain.gK1TemplatesBif = New BIFFArchive(fileStream)
            End If
            Return frmMain.gK1TemplatesBif
        End Function

        ' Token: 0x060006EC RID: 1772 RVA: 0x0024ED38 File Offset: 0x0024DD38
        Public Shared Function K2TemplatesBif() As BIFFArchive
            If frmMain.gK2TemplatesBif Is Nothing Then
                Dim settings As Options = UserSettings.GetSettings()
                Dim fileStream As FileStream = New FileStream(settings.KotorLocation(1) + "\data\templates.bif", FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
                frmMain.gK2TemplatesBif = New BIFFArchive(fileStream)
            End If
            Return frmMain.gK2TemplatesBif
        End Function

        ' Token: 0x060006ED RID: 1773 RVA: 0x0024ED84 File Offset: 0x0024DD84
        Public Shared Function KxTemplatesBif(ByVal KotorVerIndex As Integer) As BIFFArchive
            If KotorVerIndex = 0 Then
                Return frmMain.K1TemplatesBif()
            End If
            If KotorVerIndex = 1 Then
                Return frmMain.K2TemplatesBif()
            End If
            Dim biffarchive As BIFFArchive
            Return biffarchive
        End Function

        ' Token: 0x060006EE RID: 1774 RVA: 0x0024EDA8 File Offset: 0x0024DDA8
        Private Sub SetupTreeRoots()
            Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode("Kotor I")
            kotorTreeNode.Tag = "Kotor1"
            kotorTreeNode.FilePath = frmMain.CurrentSettings.defaultKotORLocation
            Me.TreeView.Nodes.Add(kotorTreeNode)
            kotorTreeNode = New KotorTreeNode("Kotor II")
            kotorTreeNode.Tag = "Kotor2"
            kotorTreeNode.FilePath = frmMain.CurrentSettings.defaultKotORLocation2
            Me.TreeView.Nodes.Add(kotorTreeNode)
        End Sub

        ' Token: 0x060006EF RID: 1775 RVA: 0x0024EE28 File Offset: 0x0024DE28
        Private Sub SetupRootChildren(ByVal Root As KotorTreeNode)
            Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode("BIFs")
            kotorTreeNode.Tag = "BIFF_Root"
            kotorTreeNode.FilePath = frmMain.CurrentSettings.KotorLocation(Me.TreeView.Nodes.IndexOf(Root)) + "\data"
            Dim kotorTreeNode2 As KotorTreeNode = New KotorTreeNode("")
            kotorTreeNode2.Tag = "dummy"
            kotorTreeNode.Nodes.Add(kotorTreeNode2)
            Root.Nodes.Add(kotorTreeNode)
            kotorTreeNode = New KotorTreeNode("RIMs")
            kotorTreeNode.Tag = "RIM_Root"
            kotorTreeNode.FilePath = frmMain.CurrentSettings.KotorLocation(Me.TreeView.Nodes.IndexOf(Root)) + "\Modules"
            Dim kotorTreeNode3 As KotorTreeNode = New KotorTreeNode("Modules")
            kotorTreeNode3.Tag = "RIM_Modules"
            kotorTreeNode2 = New KotorTreeNode("")
            kotorTreeNode2.Tag = "dummy"
            kotorTreeNode3.Nodes.Add(kotorTreeNode2)
            kotorTreeNode.Nodes.Add(kotorTreeNode3)
            Dim kotorTreeNode4 As KotorTreeNode = New KotorTreeNode("Rims")
            kotorTreeNode4.Tag = "RIM_Rims"
            kotorTreeNode2 = New KotorTreeNode("")
            kotorTreeNode2.Tag = "dummy"
            kotorTreeNode4.Nodes.Add(kotorTreeNode2)
            kotorTreeNode.Nodes.Add(kotorTreeNode4)
            Root.Nodes.Add(kotorTreeNode)
            kotorTreeNode = New KotorTreeNode("ERFs")
            kotorTreeNode.Tag = "ERF_Root"
            kotorTreeNode.FilePath = frmMain.CurrentSettings.KotorLocation(Me.TreeView.Nodes.IndexOf(Root)) + "\texturePacks"
            Dim kotorTreeNode5 As KotorTreeNode = New KotorTreeNode("TexturePacks")
            kotorTreeNode5.Tag = "ERF_TexturePacks"
            kotorTreeNode2 = New KotorTreeNode("")
            kotorTreeNode2.Tag = "dummy"
            kotorTreeNode5.Nodes.Add(kotorTreeNode2)
            kotorTreeNode.Nodes.Add(kotorTreeNode5)
            Root.Nodes.Add(kotorTreeNode)
            kotorTreeNode3 = New KotorTreeNode("Modules")
            kotorTreeNode3.Tag = "ERF_Modules"
            kotorTreeNode2 = New KotorTreeNode("")
            kotorTreeNode2.Tag = "dummy"
            kotorTreeNode3.Nodes.Add(kotorTreeNode2)
            kotorTreeNode.Nodes.Add(kotorTreeNode3)
            kotorTreeNode = New KotorTreeNode("Saves")
            kotorTreeNode.Tag = "Saves_Root"
            kotorTreeNode.FilePath = frmMain.CurrentSettings.KotorLocation(Me.TreeView.Nodes.IndexOf(Root)) + "\Saves"
            kotorTreeNode2 = New KotorTreeNode("")
            kotorTreeNode2.Tag = "dummy"
            kotorTreeNode.Nodes.Add(kotorTreeNode2)
            Root.Nodes.Add(kotorTreeNode)
        End Sub

        ' Token: 0x060006F0 RID: 1776 RVA: 0x0024F0D0 File Offset: 0x0024E0D0
        Private Sub BuildTreeView(ByVal Root As KotorTreeNode, Optional ByVal noProgressIndication As Boolean = False)
            Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
            Dim utilWindowRelativePositioner As utilWindowRelativePositioner = New utilWindowRelativePositioner(Me, frmProgressMeter)
            Dim filePath As String = Root.FilePath
            Dim num As Integer = Me.NodeTreeRootIndex(Root)
            Dim text As String = frmMain.CurrentSettings.KeyFileLocation(num)
            Dim fileStream As FileStream = New FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 600000)
            Dim binaryReader As BinaryReader = New BinaryReader(fileStream)
            frmProgressMeter.message = "Preparing Resource List"
            frmProgressMeter.status = "Reading key file"
            frmProgressMeter.Location = utilWindowRelativePositioner.getConcentric()
            frmProgressMeter.stepAmount = 5
            Root.Nodes(0).Nodes.Clear()
            Me.TreeView.BeginUpdate()
            Dim dateTime As DateTime = DateAndTime.Now
            fileStream.Seek(8L, SeekOrigin.Begin)
            Dim num2 As Integer = binaryReader.ReadInt32()
            Dim num3 As Integer = binaryReader.ReadInt32()
            Dim num4 As Integer = binaryReader.ReadInt32()
            Dim num5 As Integer = binaryReader.ReadInt32()
            Dim num6 As Integer = binaryReader.ReadInt32()
            Dim num7 As Integer = binaryReader.ReadInt32()
            Me.biffEntries(num) = New ArrayList(num2)
            Dim num8 As Integer = 0
            Dim num9 As Integer = num2 - 1
            For i As Integer = num8 To num9
                Me.biffEntries(num).Add(New BIFFEntry(i, fileStream, num4 + 12 * i))
                Me.BiffEntryListArray(num, i) = New ArrayList()
            Next
            Try
                For Each obj As Object In Me.biffEntries(num)
                    Dim biffentry As BIFFEntry = CType(obj, BIFFEntry)
                    Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode(Strings.Mid(biffentry.filename, biffentry.filename.LastIndexOf("\") + 2))
                    kotorTreeNode.Tag = "BIFF"
                    kotorTreeNode.Filename = Strings.Mid(biffentry.filename, biffentry.filename.LastIndexOf("\") + 2)
                    kotorTreeNode.FilePath = filePath + "\" + Strings.Mid(biffentry.filename, 1, biffentry.filename.LastIndexOf("\"))
                    kotorTreeNode.ContainingFileType = "BIF"
                    Root.Nodes(0).Nodes.Add(kotorTreeNode)
                    Console.WriteLine("Bif name: " + biffentry.filename + "  Length: " + StringType.FromInteger(biffentry.filelength))
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            fileStream.Seek(CLng(num5), SeekOrigin.Begin)
            dateTime = DateAndTime.Now
            Dim array As Byte() = New Byte(CInt(fileStream.Length) + 1 - 1) {}
            fileStream.Position = 0L
            fileStream.Read(array, 0, CInt((fileStream.Length - 1L)))
            If Not noProgressIndication Then
                frmProgressMeter.Show()
            End If
            Dim num10 As Integer = num3 / 20
            Dim num11 As Integer = 0
            Dim num12 As Integer = num3 - 1
            For i As Integer = num11 To num12
                Dim keyEntry As KeyEntry = New KeyEntry(i, array, num5 + 22 * i)
                Me.BiffEntryListArray(num, keyEntry.ResID >> 20).Add(keyEntry)
                If CDbl((i / num10)) = CDbl(i) / CDbl(num10) Then
                    frmProgressMeter.stepUp()
                End If
            Next
            frmProgressMeter.progress = 0
            Dim bBuildModelsBifNode As Boolean = frmMain.CurrentSettings.bBuildModelsBifNode
            Dim num13 As Integer = 0
            Dim num14 As Integer = 0
            Dim num15 As Integer = num2 - 1
            For i As Integer = num14 To num15
                frmProgressMeter.status = "Building tree for " + CType(Me.biffEntries(num)(i), BIFFEntry).filename
                If i <> 18 OrElse bBuildModelsBifNode Then
                    Dim treeNode As TreeNode = New KotorTreeNode()
                    Dim num16 As Integer = 0
                    Dim num17 As Integer = Me.BiffEntryListArray(num, i).Count - 1
                    For j As Integer = num16 To num17
                        Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode(CType(Me.BiffEntryListArray(num, i)(j), KeyEntry))
                        kotorTreeNode.Tag = "BIFF_Res"
                        kotorTreeNode.ContainingFileType = "BIF"
                        kotorTreeNode.FilePath = filePath + "\" + CType(Me.biffEntries(num)(i), BIFFEntry).filename
                        Me.OrganizeNodesByResType(CType(treeNode, KotorTreeNode), kotorTreeNode)
                        If CDbl((num13 / num10)) = CDbl(num13) / CDbl(num10) Then
                            frmProgressMeter.stepUp()
                        End If
                        num13 += 1
                    Next
                    Me.AttachNodeParentsSortedByDesc(CType(Root.Nodes(0).Nodes(i), KotorTreeNode), CType(treeNode, KotorTreeNode))
                End If
            Next
            Me.TreeView.EndUpdate()
            frmProgressMeter.Hide()
        End Sub

        ' Token: 0x060006F1 RID: 1777 RVA: 0x0024F570 File Offset: 0x0024E570
        Private Sub OrganizeNodesByResType(ByVal Collection As KotorTreeNode, ByVal node As KotorTreeNode)
            Dim kotorTreeNode As KotorTreeNode
            Try
                For Each obj As Object In Collection.Nodes
                    kotorTreeNode = CType(obj, KotorTreeNode)
                    If node.ResType = kotorTreeNode.ResType Then
                        kotorTreeNode.Nodes.Add(node)
                        Return
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            kotorTreeNode = New KotorTreeNode(Me.ParentDescForResType(node.ResType))
            kotorTreeNode.ResType = node.ResType
            kotorTreeNode.Tag = "NodeCategory"
            kotorTreeNode.Nodes.Add(node)
            Collection.Nodes.Add(kotorTreeNode)
        End Sub

        ' Token: 0x060006F2 RID: 1778 RVA: 0x0024F628 File Offset: 0x0024E628
        Private Sub AttachNodeParentsSortedByDesc(ByVal ContainerNode As KotorTreeNode, ByVal UnsortedNodeCollection As KotorTreeNode)
            Dim num As Integer = 0
            Dim array As String() = New String(UnsortedNodeCollection.Nodes.Count - 1 + 1 - 1) {}
            Dim kotorTreeNode As KotorTreeNode
            Try
                For Each obj As Object In UnsortedNodeCollection.Nodes
                    kotorTreeNode = CType(obj, KotorTreeNode)
                    array(num) = kotorTreeNode.Text
                    num += 1
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            array.Sort(array)
            For Each text As String In array
                Try
                    For Each obj2 As Object In UnsortedNodeCollection.Nodes
                        kotorTreeNode = CType(obj2, KotorTreeNode)
                        If StringType.StrCmp(text, kotorTreeNode.Text, False) = 0 Then
                            Exit For
                        End If
                    Next
                Finally
                    Dim enumerator2 As IEnumerator
                    If TypeOf enumerator2 Is IDisposable Then
                        CType(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                ContainerNode.Nodes.Add(kotorTreeNode)
            Next
        End Sub

        ' Token: 0x060006F3 RID: 1779 RVA: 0x0024F730 File Offset: 0x0024E730
        Private Sub ScanForRIMSandBuildTree(ByVal ktn As KotorTreeNode, ByVal directory As String)
            Dim bShowModuleDescriptions As Boolean = frmMain.CurrentSettings.bShowModuleDescriptions
            Dim bShowModuleLocations As Boolean = frmMain.CurrentSettings.bShowModuleLocations
            Dim text As String = CType(ktn.Parent.Parent, KotorTreeNode).FilePath + "\" + directory
            Dim directoryInfo As DirectoryInfo = New DirectoryInfo(text)
            Dim files As FileInfo() = directoryInfo.GetFiles()
            For Each fileInfo As FileInfo In files
                If StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".rim", False) = 0 Then
                    Dim text2 As String = fileInfo.Name
                    If bShowModuleDescriptions OrElse bShowModuleLocations Then
                        text2 += " - "
                    End If
                    If bShowModuleDescriptions Then
                        text2 += Me.GetModuleDescForRimName(fileInfo.Name)
                    End If
                    If bShowModuleLocations Then
                        text2 += Me.GetLocNameForRimName(fileInfo.Name)
                    End If
                    Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode(text2)
                    kotorTreeNode.Tag = "RIM"
                    kotorTreeNode.FilePath = fileInfo.DirectoryName
                    kotorTreeNode.Filename = fileInfo.Name
                    kotorTreeNode.ContainingFileType = "rim"
                    Dim kotorTreeNode2 As KotorTreeNode = New KotorTreeNode("")
                    kotorTreeNode2.Tag = "dummy"
                    kotorTreeNode.Nodes.Add(kotorTreeNode2)
                    ktn.Nodes.Add(kotorTreeNode)
                End If
            Next
        End Sub

        ' Token: 0x060006F4 RID: 1780 RVA: 0x0024F884 File Offset: 0x0024E884
        Private Sub ScanForERFsAndBuildTree(ByVal ktn As KotorTreeNode, ByVal directory As String)
            Dim text As String = frmMain.CurrentSettings.KotorLocation(Me.NodeTreeRootIndex(ktn)) + "\" + directory
            Dim directoryInfo As DirectoryInfo = New DirectoryInfo(text)
            Dim files As FileInfo() = directoryInfo.GetFiles()
            For Each fileInfo As FileInfo In files
                If (StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".erf", False) = 0) Or (StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".mod", False) = 0) Then
                    Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode(fileInfo.Name)
                    kotorTreeNode.Tag = "ERF"
                    kotorTreeNode.FilePath = fileInfo.DirectoryName
                    kotorTreeNode.Filename = fileInfo.Name
                    kotorTreeNode.ContainingFileType = "ERF"
                    Dim kotorTreeNode2 As KotorTreeNode = New KotorTreeNode("")
                    kotorTreeNode2.Tag = "dummy"
                    kotorTreeNode.Nodes.Add(kotorTreeNode2)
                    ktn.Nodes.Add(kotorTreeNode)
                End If
            Next
        End Sub

        ' Token: 0x060006F5 RID: 1781 RVA: 0x0024F988 File Offset: 0x0024E988
        Private Sub ScanForSavesAndBuildTree(ByVal path As String, ByVal node As KotorTreeNode)
            Dim directoryInfo As DirectoryInfo = New DirectoryInfo(path)
            Dim directories As DirectoryInfo() = directoryInfo.GetDirectories()
            For Each directoryInfo2 As DirectoryInfo In directories
                Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode(directoryInfo2.Name)
                kotorTreeNode.FilePath = directoryInfo2.FullName
                Dim kotorTreeNode2 As KotorTreeNode = New KotorTreeNode("GLOBALVARS.res")
                kotorTreeNode2.Tag = "globalvar"
                kotorTreeNode2.FilePath = kotorTreeNode.FilePath
                kotorTreeNode2.Filename = "GLOBALVARS.res"
                kotorTreeNode.Nodes.Add(kotorTreeNode2)
                node.Nodes.Add(kotorTreeNode)
            Next
        End Sub

        ' Token: 0x060006F6 RID: 1782 RVA: 0x0024FA28 File Offset: 0x0024EA28
        Public Shared Sub ExportBiffResource(ByVal biffPath As String, ByVal outputPath As String, ByVal resourceID As Integer)
            Dim fileStream As FileStream = New FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
            Dim biffarchive As BIFFArchive = New BIFFArchive(fileStream)
            Dim biffresource As BIFFVarRsrcEntry = biffarchive.getBIFFResource(resourceID)
            Dim fileStream2 As FileStream = New FileStream(outputPath, FileMode.Create)
            Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream2)
            binaryWriter.Write(biffresource.data)
            binaryWriter.Close()
            fileStream.Close()
        End Sub

        ' Token: 0x060006F7 RID: 1783 RVA: 0x0024FA7C File Offset: 0x0024EA7C
        Public Shared Sub ExportBiffResource(ByVal KotorVerIndex As Integer, ByVal FileNameToExport As String, ByVal FileResType As Integer, ByVal outputPath As String)
            Dim settings As Options = UserSettings.GetSettings()
            Dim num As Integer = frmMain.KxChitinKey(KotorVerIndex).FindResIDForResRef(FileNameToExport, FileResType)
            If num = -1 Then
                Throw New NotSupportedException()
            End If
            Dim text As String = settings.KotorLocation(KotorVerIndex) + "\" + frmMain.KxChitinKey(KotorVerIndex).BiffList(num >> 20).filename
            frmMain.ExportBiffResource(text, outputPath, num - (num >> 20 << 20))
        End Sub

        ' Token: 0x060006F8 RID: 1784 RVA: 0x0024FAE0 File Offset: 0x0024EAE0
        Public Function GetBIFFResource(ByVal biffPath As String, ByVal resourceID As Integer) As BIFFVarRsrcEntry
            Dim fileStream As FileStream = New FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
            Dim biffarchive As BIFFArchive = New BIFFArchive(fileStream)
            Dim biffresource As BIFFVarRsrcEntry = biffarchive.getBIFFResource(resourceID)
            fileStream.Close()
            Return biffresource
        End Function

        ' Token: 0x060006F9 RID: 1785 RVA: 0x0024FB14 File Offset: 0x0024EB14
        Public Shared Function GetBIFFResourceData(ByVal KotorVerIndex As Integer, ByVal FileName As String, ByVal FileResType As Integer) As Byte()
            Dim settings As Options = UserSettings.GetSettings()
            Dim clsChitinKey As clsChitinKey = frmMain.KxChitinKey(KotorVerIndex)
            Dim num As Integer = clsChitinKey.FindResIDForResRef(FileName, FileResType)
            If num = -1 Then
                Return Nothing
            End If
            Dim text As String = settings.KotorLocation(KotorVerIndex) + "\" + clsChitinKey.BiffList(num >> 20).filename
            Dim fileStream As FileStream = New FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
            Dim biffarchive As BIFFArchive = New BIFFArchive(fileStream)
            Dim data As Byte() = biffarchive.getBIFFResource(num - (num >> 20 << 20)).data
            fileStream.Close()
            Return data
        End Function

        ' Token: 0x060006FA RID: 1786 RVA: 0x0024FBA0 File Offset: 0x0024EBA0
        Public Shared Function GetTemplateBifResourceData(ByVal KotorVerIndex As Integer, ByVal FileName As String, ByVal FileResType As Integer) As Byte()
            Dim clsChitinKey As clsChitinKey = frmMain.KxChitinKey(KotorVerIndex)
            Dim num As Integer = clsChitinKey.FindResIDForResRef(FileName, FileResType)
            If num = -1 Then
                Return Nothing
            End If
            Return frmMain.KxTemplatesBif(KotorVerIndex).getBIFFResource(num - (num >> 20 << 20)).data
        End Function

        ' Token: 0x060006FB RID: 1787 RVA: 0x0024FBE0 File Offset: 0x0024EBE0
        Private Sub PerformStringSearch()
            Dim frmRefSearchResults As frmRefSearchResults = New frmRefSearchResults(frmMain.mainform)
            Dim frmRefSearchCriteria As frmRefSearchCriteria = New frmRefSearchCriteria()
            If Me.hasK1 Xor Me.hasK2 Then
                frmRefSearchCriteria.rbSearchKotor1.Checked = Me.hasK1
                frmRefSearchCriteria.rbSearchKotor1.Enabled = Me.hasK1
                frmRefSearchCriteria.rbSearchKotor2.Checked = Me.hasK2
                frmRefSearchCriteria.rbSearchKotor2.Enabled = Me.hasK2
                frmRefSearchCriteria.tbSearchString.Focus()
            End If
            frmRefSearchCriteria.ShowDialog(Me)
            If frmRefSearchCriteria.DialogResult <> DialogResult.OK Then
                Return
            End If
            Dim cursor As Cursor = Cursor.Current
            Dim num As Integer
            If frmRefSearchCriteria.rbSearchKotor1.Checked Then
                num = 0
            Else
                num = 1
            End If
            If (frmRefSearchCriteria.chkbAllBifs.Checked Or frmRefSearchCriteria.chkbScripts.Checked Or frmRefSearchCriteria.chkbTemplates.Checked) AndAlso ObjectType.ObjTst(Me.TreeView.Nodes(num).Nodes(0).Nodes(0).Tag, "dummy", False) = 0 Then
                Cursor.Current = Cursors.WaitCursor
                Me.BuildTreeView(CType(Me.TreeView.Nodes(num), KotorTreeNode), True)
            End If
            If frmRefSearchCriteria.chkbAllBifs.Checked Then
                Dim num2 As Integer = 0
                Dim num3 As Integer = Me.TreeView.Nodes(num).Nodes(0).Nodes.Count - 1
                For i As Integer = num2 To num3
                    Me.SearchBifsForText(num, frmRefSearchCriteria.tbSearchString.Text, frmRefSearchCriteria.rbtnSensitive.Checked, frmRefSearchCriteria.htFileTypes, frmRefSearchResults, i)
                Next
            Else
                If frmRefSearchCriteria.chkbScripts.Checked Then
                    Dim num4 As Integer = 0
                    Dim num5 As Integer = Me.TreeView.Nodes(num).Nodes(0).Nodes.Count - 1
                    Dim i As Integer = num4
                    While i <= num5 AndAlso Not Me.TreeView.Nodes(num).Nodes(0).Nodes(i).Text.ToLower().EndsWith("scripts.bif")
                        i += 1
                    End While
                    Me.SearchBifsForText(num, frmRefSearchCriteria.tbSearchString.Text, frmRefSearchCriteria.rbtnSensitive.Checked, frmRefSearchCriteria.htFileTypes, frmRefSearchResults, i)
                End If
                If frmRefSearchCriteria.chkbTemplates.Checked Then
                    Dim num6 As Integer = 0
                    Dim num7 As Integer = Me.TreeView.Nodes(num).Nodes(0).Nodes.Count - 1
                    Dim i As Integer = num6
                    While i <= num7 AndAlso Not Me.TreeView.Nodes(num).Nodes(0).Nodes(i).Text.ToLower().EndsWith("templates.bif")
                        i += 1
                    End While
                    Me.SearchBifsForText(num, frmRefSearchCriteria.tbSearchString.Text, frmRefSearchCriteria.rbtnSensitive.Checked, frmRefSearchCriteria.htFileTypes, frmRefSearchResults, i)
                End If
            End If
            If frmRefSearchCriteria.chkbRIMs.Checked Then
                Me.SearchAllModuleRimsForText(num, frmRefSearchCriteria.tbSearchString.Text, frmRefSearchCriteria.rbtnSensitive.Checked, frmRefSearchCriteria.htFileTypes, frmRefSearchResults)
            End If
            If frmRefSearchResults.lbMatches.Items.Count = 0 Then
                frmRefSearchResults.lblNoMatchesFound.Visible = True
                frmRefSearchResults.lbMatches.Visible = False
                frmRefSearchResults.lblDesc.Visible = False
                frmRefSearchResults.Size = frmRefSearchResults.MinimumSize
                frmRefSearchResults.lbMatches.Enabled = False
            End If
            Cursor.Current = cursor
            Dim utilWindowRelativePositioner As utilWindowRelativePositioner = New utilWindowRelativePositioner(Me, frmRefSearchResults)
            frmRefSearchResults.Location = utilWindowRelativePositioner.getConcentric()
            frmRefSearchResults.Show()
        End Sub

        ' Token: 0x060006FC RID: 1788 RVA: 0x0024FF80 File Offset: 0x0024EF80
        Private Sub SearchBifsForText(ByVal KotorVerIndex As Integer, ByVal SearchText As String, ByVal CaseSensitive As Boolean, ByVal FileTypes As Hashtable, ByVal ResultsForm As frmRefSearchResults, ByVal BifToSearchID As Integer)
            Dim hashtable As Hashtable = New Hashtable()
            For Each obj As Object In FileTypes
                Dim dictionaryEntry As DictionaryEntry = CType((If(obj, Activator.CreateInstance(GetType(DictionaryEntry)))), DictionaryEntry)
                hashtable.Add(frmMain.GetIDForRsrcType(StringType.FromObject(dictionaryEntry.Key)), RuntimeHelpers.GetObjectValue(dictionaryEntry.Value))
            Next
            Dim regex As Regex
            If CaseSensitive Then
                regex = New Regex(SearchText)
            Else
                regex = New Regex(SearchText, RegexOptions.IgnoreCase)
            End If
            Me.ScanBifForText(KotorVerIndex, BifToSearchID, hashtable, regex, ResultsForm.lbMatches.Items)
        End Sub

        ' Token: 0x060006FD RID: 1789 RVA: 0x0025001C File Offset: 0x0024F01C
        Private Sub ScanBifForText(ByVal KotorVerIndex As Integer, ByVal BiffListIndex As Integer, ByVal htFileTypeIDs As Hashtable, ByVal oRegex As Regex, ByVal lboc As ListBox.ObjectCollection)
            Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
            Dim text As String = frmMain.CurrentSettings.KotorLocation(KotorVerIndex) + "\" + CType(Me.biffEntries(KotorVerIndex)(BiffListIndex), BIFFEntry).filename
            Dim fileStream As FileStream = New FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
            Dim biffarchive As BIFFArchive = New BIFFArchive(fileStream)
            Try
                For Each obj As Object In Me.BiffEntryListArray(KotorVerIndex, BiffListIndex)
                    Dim keyEntry As KeyEntry = CType(obj, KeyEntry)
                    Dim num As Integer
                    Select Case num
                        Case 0
                            Cursor.Current = Cursors.PanNorth
                        Case 1
                            Cursor.Current = Cursors.PanNW
                        Case 2
                            Cursor.Current = Cursors.PanWest
                        Case 3
                            Cursor.Current = Cursors.PanSW
                        Case 4
                            Cursor.Current = Cursors.PanSouth
                        Case 5
                            Cursor.Current = Cursors.PanSE
                        Case 6
                            Cursor.Current = Cursors.PanEast
                        Case 7
                            Cursor.Current = Cursors.PanNE
                            num = -1
                    End Select
                    num += 1
                    If htFileTypeIDs.ContainsKey(keyEntry.ResourceType) Then
                        Dim [string] As String = asciiencoding.GetString(biffarchive.getBIFFResource(keyEntry.ResID - (keyEntry.ResID >> 20 << 20)).data)
                        Dim match As Match = oRegex.Match([string])
                        If match.Success Then
                            lboc.Add(New KotorTreeNode(keyEntry) With {.FilePath = text, .Tag = "BIFF_Res", .KotorVerIndex = KotorVerIndex})
                        End If
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            fileStream.Close()
        End Sub

        ' Token: 0x060006FE RID: 1790 RVA: 0x002501F0 File Offset: 0x0024F1F0
        Private Function GetModuleDescForRimName(ByVal RimName As String) As String
            Dim text As String = RimName.Replace(".rim", "").Replace("_s", "")
            If StringType.StrCmp(text, "end_m01aa", False) = 0 Then
                Return "Command Module"
            End If
            If StringType.StrCmp(text, "end_m01ab", False) = 0 Then
                Return "Starboard Section"
            End If
            If StringType.StrCmp(text, "tar_m02aa", False) = 0 Then
                Return "South Apartments"
            End If
            If StringType.StrCmp(text, "tar_m02ab", False) = 0 Then
                Return "Upper City North"
            End If
            If StringType.StrCmp(text, "tar_m02ac", False) = 0 Then
                Return "Upper City South"
            End If
            If StringType.StrCmp(text, "tar_m02ad", False) = 0 Then
                Return "North Apartments"
            End If
            If StringType.StrCmp(text, "tar_m02ae", False) = 0 Then
                Return "Upper City Cantina"
            End If
            If StringType.StrCmp(text, "tar_m02af", False) = 0 Then
                Return "Hideout"
            End If
            If StringType.StrCmp(text, "tar_m03aa", False) = 0 Then
                Return "Lower City"
            End If
            If StringType.StrCmp(text, "tar_m03ab", False) = 0 Then
                Return "Lower City Apartments"
            End If
            If StringType.StrCmp(text, "tar_m03ad", False) = 0 Then
                Return "Lower City Apartments"
            End If
            If StringType.StrCmp(text, "tar_m03ae", False) = 0 Then
                Return "Javyar's Cantina"
            End If
            If StringType.StrCmp(text, "tar_m03af", False) = 0 Then
                Return "Swoop Platform"
            End If
            If StringType.StrCmp(text, "tar_m04aa", False) = 0 Then
                Return "Undercity"
            End If
            If StringType.StrCmp(text, "tar_m05aa", False) = 0 Then
                Return "Lower Sewers"
            End If
            If StringType.StrCmp(text, "tar_m05ab", False) = 0 Then
                Return "Upper Sewers"
            End If
            If StringType.StrCmp(text, "tar_m08aa", False) = 0 Then
                Return "Davik's Estate"
            End If
            If StringType.StrCmp(text, "tar_m09aa", False) = 0 Then
                Return "Sith Base"
            End If
            If StringType.StrCmp(text, "tar_m09ab", False) = 0 Then
                Return "Sith Base"
            End If
            If StringType.StrCmp(text, "tar_m10aa", False) = 0 Then
                Return "Black Vulkar Base"
            End If
            If StringType.StrCmp(text, "tar_m10ab", False) = 0 Then
                Return "Black Vulkar Base"
            End If
            If StringType.StrCmp(text, "tar_m10ac", False) = 0 Then
                Return "Black Vulkar Base"
            End If
            If StringType.StrCmp(text, "tar_m11aa", False) = 0 Then
                Return "Hidden Bek Base"
            End If
            If StringType.StrCmp(text, "tar_m11ab", False) = 0 Then
                Return "Hidden Bek Base"
            End If
            If StringType.StrCmp(text, "ebo_m12aa", False) = 0 Then
                Return "Bridge"
            End If
            If StringType.StrCmp(text, "ebo_m46ab", False) = 0 Then
                Return "Mystery Box"
            End If
            If StringType.StrCmp(text, "danm13", False) = 0 Then
                Return "Jedi Enclave"
            End If
            If StringType.StrCmp(text, "danm14aa", False) = 0 Then
                Return "Courtyard"
            End If
            If StringType.StrCmp(text, "danm14ab", False) = 0 Then
                Return "Matale Grounds"
            End If
            If StringType.StrCmp(text, "danm14ac", False) = 0 Then
                Return "Grove"
            End If
            If StringType.StrCmp(text, "danm14ad", False) = 0 Then
                Return "Sandral Grounds"
            End If
            If StringType.StrCmp(text, "danm14ae", False) = 0 Then
                Return "Crystal Caves"
            End If
            If StringType.StrCmp(text, "danm15", False) = 0 Then
                Return "Ruins"
            End If
            If StringType.StrCmp(text, "danm16", False) = 0 Then
                Return "Sandral Estate"
            End If
            If StringType.StrCmp(text, "tat_m17aa", False) = 0 Then
                Return "Anchorhead"
            End If
            If StringType.StrCmp(text, "tat_m17ab", False) = 0 Then
                Return "Docking Bay"
            End If
            If StringType.StrCmp(text, "tat_m17ac", False) = 0 Then
                Return "Droid Shop"
            End If
            If StringType.StrCmp(text, "tat_m17ad", False) = 0 Then
                Return "Hunting Lodge"
            End If
            If StringType.StrCmp(text, "tat_m17ae", False) = 0 Then
                Return "Swoop Registration"
            End If
            If StringType.StrCmp(text, "tat_m17af", False) = 0 Then
                Return "Cantina"
            End If
            If StringType.StrCmp(text, "tat_m17ag", False) = 0 Then
                Return "Czerka Office"
            End If
            If StringType.StrCmp(text, "tat_m18aa", False) = 0 Then
                Return "Dune Sea"
            End If
            If StringType.StrCmp(text, "tat_m18ab", False) = 0 Then
                Return "Sand People Territory"
            End If
            If StringType.StrCmp(text, "tat_m18ac", False) = 0 Then
                Return "Eastern Dune Sea"
            End If
            If StringType.StrCmp(text, "tat_m20aa", False) = 0 Then
                Return "Sand People Enclave"
            End If
            If StringType.StrCmp(text, "kas_m22aa", False) = 0 Then
                Return "Czerka Landing Port"
            End If
            If StringType.StrCmp(text, "kas_m22ab", False) = 0 Then
                Return "The Great Walkway"
            End If
            If StringType.StrCmp(text, "kas_m23aa", False) = 0 Then
                Return "Village of Rwookrrorro"
            End If
            If StringType.StrCmp(text, "kas_m23ab", False) = 0 Then
                Return "Worrwill's Home"
            End If
            If StringType.StrCmp(text, "kas_m23ac", False) = 0 Then
                Return "Worrroznor's Home"
            End If
            If StringType.StrCmp(text, "kas_m23ad", False) = 0 Then
                Return "Chieftain's Hall"
            End If
            If StringType.StrCmp(text, "kas_m24aa", False) = 0 Then
                Return "Upper Shadowlands"
            End If
            If StringType.StrCmp(text, "kas_m25aa", False) = 0 Then
                Return "Lower Shadowlands"
            End If
            If StringType.StrCmp(text, "manm26aa", False) = 0 Then
                Return "Ahto West"
            End If
            If StringType.StrCmp(text, "manm26ab", False) = 0 Then
                Return "Ahto East"
            End If
            If StringType.StrCmp(text, "manm26ac", False) = 0 Then
                Return "West Central"
            End If
            If StringType.StrCmp(text, "manm26ad", False) = 0 Then
                Return "Docking Bay"
            End If
            If StringType.StrCmp(text, "manm26ae", False) = 0 Then
                Return "East Central"
            End If
            If StringType.StrCmp(text, "manm27aa", False) = 0 Then
                Return "Sith Base"
            End If
            If StringType.StrCmp(text, "manm28aa", False) = 0 Then
                Return "Hrakert Station"
            End If
            If StringType.StrCmp(text, "manm28ab", False) = 0 Then
                Return "Sea Floor"
            End If
            If StringType.StrCmp(text, "manm28ac", False) = 0 Then
                Return "Kolto Control"
            End If
            If StringType.StrCmp(text, "manm28ad", False) = 0 Then
                Return "Hrakert Rift"
            End If
            If StringType.StrCmp(text, "korr_m33aa", False) = 0 Then
                Return "Dreshdae"
            End If
            If StringType.StrCmp(text, "korr_m33ab", False) = 0 Then
                Return "Sith Academy Entrance "
            End If
            If StringType.StrCmp(text, "korr_m34aa", False) = 0 Then
                Return "Shyrack Caves"
            End If
            If StringType.StrCmp(text, "korr_m35aa", False) = 0 Then
                Return "Sith Academy Entrance"
            End If
            If StringType.StrCmp(text, "korr_m36aa", False) = 0 Then
                Return "Valley of Dark Lords"
            End If
            If StringType.StrCmp(text, "korr_m37aa", False) = 0 Then
                Return "Tomb of Ajunta Pall"
            End If
            If StringType.StrCmp(text, "korr_m38aa", False) = 0 Then
                Return "Tomb of Marka Ragnos"
            End If
            If StringType.StrCmp(text, "korr_m38ab", False) = 0 Then
                Return "Tomb of Tulak Hord"
            End If
            If StringType.StrCmp(text, "korr_m39aa", False) = 0 Then
                Return "Tomb of Naga Sadow"
            End If
            If StringType.StrCmp(text, "liv_m99aa", False) = 0 Then
                Return "Yavin Station"
            End If
            If StringType.StrCmp(text, "lev_m40aa", False) = 0 Then
                Return "Prison Block"
            End If
            If StringType.StrCmp(text, "lev_m40ab", False) = 0 Then
                Return "Command Deck"
            End If
            If StringType.StrCmp(text, "lev_m40ac", False) = 0 Then
                Return "Hangar"
            End If
            If StringType.StrCmp(text, "lev_m40ad", False) = 0 Then
                Return "Bridge"
            End If
            If StringType.StrCmp(text, "unk_m41aa", False) = 0 Then
                Return "Central Beach"
            End If
            If StringType.StrCmp(text, "unk_m41ab", False) = 0 Then
                Return "South Beach"
            End If
            If StringType.StrCmp(text, "unk_m41ac", False) = 0 Then
                Return "North Beach"
            End If
            If StringType.StrCmp(text, "unk_m41ad", False) = 0 Then
                Return "Temple Exterior"
            End If
            If StringType.StrCmp(text, "unk_m42aa", False) = 0 Then
                Return "Elder Settlement"
            End If
            If StringType.StrCmp(text, "unk_m43aa", False) = 0 Then
                Return "Rakatan Settlement"
            End If
            If StringType.StrCmp(text, "unk_m44aa", False) = 0 Then
                Return "Temple Main Floor"
            End If
            If StringType.StrCmp(text, "unk_m44ab", False) = 0 Then
                Return "Temple Catacombs"
            End If
            If StringType.StrCmp(text, "sta_m45aa", False) = 0 Then
                Return "Deck 1"
            End If
            If StringType.StrCmp(text, "sta_m45ab", False) = 0 Then
                Return "Deck 2"
            End If
            If StringType.StrCmp(text, "sta_m45ac", False) = 0 Then
                Return "Deck 3"
            End If
            If StringType.StrCmp(text, "sta_m45ad", False) = 0 Then
                Return "Deck 4"
            End If
            If StringType.StrCmp(text, "001EBO", False) = 0 Then
                Return "Interior"
            End If
            If StringType.StrCmp(text, "002EBO", False) = 0 Then
                Return "Exterior Hull"
            End If
            If StringType.StrCmp(text, "003EBO", False) = 0 Then
                Return "Interior"
            End If
            If StringType.StrCmp(text, "004EBO", False) = 0 Then
                Return "Interior"
            End If
            If StringType.StrCmp(text, "005EBO", False) = 0 Then
                Return "Interior"
            End If
            If StringType.StrCmp(text, "006EBO", False) = 0 Then
                Return "Interior"
            End If
            If StringType.StrCmp(text, "007EBO", False) = 0 Then
                Return "Interior"
            End If
            If StringType.StrCmp(text, "101PER", False) = 0 Then
                Return "kolto cutscene - Administration Level"
            End If
            If StringType.StrCmp(text, "102PER", False) = 0 Then
                Return "Mining Tunnels"
            End If
            If StringType.StrCmp(text, "103PER", False) = 0 Then
                Return "Fuel Depot"
            End If
            If StringType.StrCmp(text, "104PER", False) = 0 Then
                Return "Asteroid Exterior"
            End If
            If StringType.StrCmp(text, "105PER", False) = 0 Then
                Return "Dormitories"
            End If
            If StringType.StrCmp(text, "106PER", False) = 0 Then
                Return "Hangar Bay"
            End If
            If StringType.StrCmp(text, "107PER", False) = 0 Then
                Return "final cutscene a.k.a. leaving Peragus"
            End If
            If StringType.StrCmp(text, "151HAR", False) = 0 Then
                Return "Command Deck"
            End If
            If StringType.StrCmp(text, "152HAR", False) = 0 Then
                Return "Crew Quarters"
            End If
            If StringType.StrCmp(text, "153HAR", False) = 0 Then
                Return "Engine Deck"
            End If
            If StringType.StrCmp(text, "154HAR", False) = 0 Then
                Return "cutscene - Command Deck"
            End If
            If StringType.StrCmp(text, "201TEL", False) = 0 Then
                Return "Citadel Station Docking Module"
            End If
            If StringType.StrCmp(text, "202TEL", False) = 0 Then
                Return "Citadel Station Entertainment Module 081"
            End If
            If StringType.StrCmp(text, "203TEL", False) = 0 Then
                Return "Citadel Station Residential 082 East"
            End If
            If StringType.StrCmp(text, "204TEL", False) = 0 Then
                Return "Citadel Station Residential 082 West"
            End If
            If StringType.StrCmp(text, "205TEL", False) = 0 Then
                Return "Citadel Station Residential 082 West - leads to cutscene to Malachor V"
            End If
            If StringType.StrCmp(text, "207TEL", False) = 0 Then
                Return "Citadel Station Cantina"
            End If
            If StringType.StrCmp(text, "208TEL", False) = 0 Then
                Return "Bumani Exchange Corp."
            End If
            If StringType.StrCmp(text, "209TEL", False) = 0 Then
                Return "Czerka Offices"
            End If
            If StringType.StrCmp(text, "211TEL", False) = 0 Then
                Return "Citadel Station Swoop Track - not official name"
            End If
            If StringType.StrCmp(text, "220TEL", False) = 0 Then
                Return "Citadel Station Suburban - Sith Assault"
            End If
            If StringType.StrCmp(text, "221TEL", False) = 0 Then
                Return "Citadel Station Suburban - Sith Assault - cutscene w/Grenn"
            End If
            If StringType.StrCmp(text, "222TEL", False) = 0 Then
                Return "Citadel Station Entertainment Module 081 - Sith Assault"
            End If
            If StringType.StrCmp(text, "231TEL", False) = 0 Then
                Return "Restoration Zone"
            End If
            If StringType.StrCmp(text, "232TEL", False) = 0 Then
                Return "Underground Base"
            End If
            If StringType.StrCmp(text, "233TEL", False) = 0 Then
                Return "Czerka Site"
            End If
            If StringType.StrCmp(text, "261TEL", False) = 0 Then
                Return "Polar Plateau"
            End If
            If StringType.StrCmp(text, "262TEL", False) = 0 Then
                Return "Secret Academy"
            End If
            If StringType.StrCmp(text, "301NAR", False) = 0 Then
                Return "Refugee Landing Pad"
            End If
            If StringType.StrCmp(text, "302NAR", False) = 0 Then
                Return "Refugee Quad"
            End If
            If StringType.StrCmp(text, "303NAR", False) = 0 Then
                Return "Docks"
            End If
            If StringType.StrCmp(text, "304NAR", False) = 0 Then
                Return "Jekk'Jekk Tarr"
            End If
            If StringType.StrCmp(text, "305NAR", False) = 0 Then
                Return "Jekk'Jekk Tunnels"
            End If
            If StringType.StrCmp(text, "306NAR", False) = 0 Then
                Return "Entertainment Promenade"
            End If
            If StringType.StrCmp(text, "351NAR", False) = 0 Then
                Return "Goto's Yacht"
            End If
            If StringType.StrCmp(text, "352NAR", False) = 0 Then
                Return "Goto's Yacht (cutscene)"
            End If
            If StringType.StrCmp(text, "371NAR", False) = 0 Then
                Return "Nar Shaddaa Swoop Track"
            End If
            If StringType.StrCmp(text, "401DXN", False) = 0 Then
                Return "Jungle Landing"
            End If
            If StringType.StrCmp(text, "402DXN", False) = 0 Then
                Return "Jungle"
            End If
            If StringType.StrCmp(text, "403DXN", False) = 0 Then
                Return "Mandalorian Ruins"
            End If
            If StringType.StrCmp(text, "404DXN", False) = 0 Then
                Return "Mandalorian Cache"
            End If
            If StringType.StrCmp(text, "410DXN", False) = 0 Then
                Return "Jungle Tomb"
            End If
            If StringType.StrCmp(text, "411DXN", False) = 0 Then
                Return "Sith Tomb"
            End If
            If StringType.StrCmp(text, "421DXN", False) = 0 Then
                Return "Dxun Turret Game"
            End If
            If StringType.StrCmp(text, "501OND", False) = 0 Then
                Return "Iziz Spaceport"
            End If
            If StringType.StrCmp(text, "502OND", False) = 0 Then
                Return "Merchant Quarter"
            End If
            If StringType.StrCmp(text, "503OND", False) = 0 Then
                Return "Iziz Cantina"
            End If
            If StringType.StrCmp(text, "504OND", False) = 0 Then
                Return "Sky Ramp"
            End If
            If StringType.StrCmp(text, "505OND", False) = 0 Then
                Return "Turret"
            End If
            If StringType.StrCmp(text, "506OND", False) = 0 Then
                Return "Royal Palace"
            End If
            If StringType.StrCmp(text, "510OND", False) = 0 Then
                Return "Swoop Race Track"
            End If
            If StringType.StrCmp(text, "511OND", False) = 0 Then
                Return "Merchant Quarter"
            End If
            If StringType.StrCmp(text, "512OND", False) = 0 Then
                Return "Iziz - Western Square"
            End If
            If StringType.StrCmp(text, "601DAN", False) = 0 Then
                Return "Khoonda"
            End If
            If StringType.StrCmp(text, "602DAN", False) = 0 Then
                Return "Khoonda Plains"
            End If
            If StringType.StrCmp(text, "603DAN", False) = 0 Then
                Return "Movie Terminal on Khoonda Plains"
            End If
            If StringType.StrCmp(text, "604DAN", False) = 0 Then
                Return "Crystal Cave"
            End If
            If StringType.StrCmp(text, "605DAN", False) = 0 Then
                Return "Enclave Courtyard"
            End If
            If StringType.StrCmp(text, "610DAN", False) = 0 Then
                Return "Enclave Sublevel"
            End If
            If StringType.StrCmp(text, "650DAN", False) = 0 Then
                Return "Rebuilt Jedi Enclave"
            End If
            If StringType.StrCmp(text, "701KOR", False) = 0 Then
                Return "Valley of Dark Lords"
            End If
            If StringType.StrCmp(text, "702KOR", False) = 0 Then
                Return "Sith Academy"
            End If
            If StringType.StrCmp(text, "710KOR", False) = 0 Then
                Return "Shyrack Cave"
            End If
            If StringType.StrCmp(text, "711KOR", False) = 0 Then
                Return "Secret Tomb"
            End If
            If StringType.StrCmp(text, "851NIH", False) = 0 Then
                Return "Ravager Command Deck"
            End If
            If StringType.StrCmp(text, "852NIH", False) = 0 Then
                Return "Ravager Bridge"
            End If
            If StringType.StrCmp(text, "853NIH", False) = 0 Then
                Return "Ravager - cutscene Visas Nihilus convo."
            End If
            If StringType.StrCmp(text, "901MAL", False) = 0 Then
                Return "Surface"
            End If
            If StringType.StrCmp(text, "902MAL", False) = 0 Then
                Return "Depths"
            End If
            If StringType.StrCmp(text, "903MAL", False) = 0 Then
                Return "Trayus Academy"
            End If
            If StringType.StrCmp(text, "904MAL", False) = 0 Then
                Return "Trayus Core"
            End If
            If StringType.StrCmp(text, "905MAL", False) = 0 Then
                Return "Trayus Crescent"
            End If
            If StringType.StrCmp(text, "906MAL", False) = 0 Then
                Return "Trayus Proving Grounds"
            End If
            If StringType.StrCmp(text, "907MAL", False) = 0 Then
                Return "Trayus Core"
            End If
            Dim text2 As String
            Return text2
        End Function

        ' Token: 0x060006FF RID: 1791 RVA: 0x00251010 File Offset: 0x00250010
        Private Function GetLocNameForRimName(ByVal RimName As String) As String
            Dim text As String = RimName.Substring(0, 3)
            If StringType.StrCmp(text, "end", False) = 0 Then
                Return " (Endar Spire)"
            End If
            If StringType.StrCmp(text, "tar", False) = 0 Then
                Return " (Taris)"
            End If
            If StringType.StrCmp(text, "ebo", False) = 0 Then
                Return " (Ebon Hawk)"
            End If
            If StringType.StrCmp(text, "dan", False) = 0 Then
                Return " (Dantooine)"
            End If
            If StringType.StrCmp(text, "tat", False) = 0 Then
                Return " (Tatooine)"
            End If
            If StringType.StrCmp(text, "kas", False) = 0 Then
                Return " (Kashyyyk)"
            End If
            If StringType.StrCmp(text, "man", False) = 0 Then
                Return " (Manaan)"
            End If
            If StringType.StrCmp(text, "kor", False) = 0 Then
                Return " (Korriban)"
            End If
            If StringType.StrCmp(text, "liv", False) = 0 Then
                Return " (Yavin Station)"
            End If
            If StringType.StrCmp(text, "lev", False) = 0 Then
                Return " (Leviathan)"
            End If
            If StringType.StrCmp(text, "unk", False) = 0 Then
                Return " (Unknown World)"
            End If
            If StringType.StrCmp(text, "sta", False) = 0 Then
                Return " (Star Forge)"
            End If
            If StringType.StrCmp(text, "STU", False) = 0 Then
                Return " (cut scene)"
            End If
            Dim text2 As String = RimName.Substring(3, 3)
            If StringType.StrCmp(text2, "EBO", False) = 0 Then
                Return " (Ebon Hawk)"
            End If
            If StringType.StrCmp(text2, "KOR", False) = 0 Then
                Return " (Korriban)"
            End If
            If StringType.StrCmp(text2, "DAN", False) = 0 Then
                Return " (Dantooine)"
            End If
            If StringType.StrCmp(text2, "PER", False) = 0 Then
                Return " (Peragus)"
            End If
            If StringType.StrCmp(text2, "HAR", False) = 0 Then
                Return " (Harbinger)"
            End If
            If StringType.StrCmp(text2, "TEL", False) = 0 Then
                Return " (Telos)"
            End If
            If StringType.StrCmp(text2, "NAR", False) = 0 Then
                Return " (Nar Shaddaa)"
            End If
            If StringType.StrCmp(text2, "DXN", False) = 0 Then
                Return " (Dxun)"
            End If
            If StringType.StrCmp(text2, "OND", False) = 0 Then
                Return " (Onderon)"
            End If
            If StringType.StrCmp(text2, "NIH", False) = 0 Then
                Return " (Ravager)"
            End If
            If StringType.StrCmp(text2, "MAL", False) = 0 Then
                Return " (Malachor V)"
            End If
            If StringType.StrCmp(text2, "COR", False) = 0 Then
                Return " (Ebon Hawk)"
            End If
            Dim text3 As String
            Return text3
        End Function

        ' Token: 0x06000700 RID: 1792 RVA: 0x00251240 File Offset: 0x00250240
        Private Sub ReadRIMentries(ByVal RimFilePath As String, ByVal ktn As KotorTreeNode)
            Dim num As Integer = 0
            Dim fileStream As FileStream = New FileStream(RimFilePath, FileMode.Open, FileAccess.Read)
            Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
            Dim clsRIM As clsRIM = New clsRIM(binaryReader.ReadBytes(CInt(fileStream.Length)))
            binaryReader.Close()
            Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode()
            Try
                For Each obj As Object In clsRIM.KeyEntryList
                    Dim rimkeyEntry As RIMKeyEntry = CType(obj, RIMKeyEntry)
                    Dim kotorTreeNode2 As KotorTreeNode = New KotorTreeNode(rimkeyEntry, RimFilePath)
                    kotorTreeNode2.ContainingFileType = "RIM"
                    kotorTreeNode2.RIMorERFindex = num
                    num += 1
                    Me.OrganizeNodesByResType(kotorTreeNode, kotorTreeNode2)
                    If StringType.StrCmp(rimkeyEntry._ResTypeStr, "pth", False) = 0 Then
                        Console.WriteLine(String.Concat(New String() {ktn.Filename, "\", rimkeyEntry._ResourceName, " ", StringType.FromInteger(rimkeyEntry._Length)}))
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.AttachNodeParentsSortedByDesc(ktn, kotorTreeNode)
        End Sub

        ' Token: 0x06000701 RID: 1793 RVA: 0x0025136C File Offset: 0x0025036C
        Private Function GetRIMResource(ByVal RimFilePath As String, ByVal ktn As KotorTreeNode) As Byte()
            Dim fileStream As FileStream = New FileStream(RimFilePath, FileMode.Open, FileAccess.Read)
            Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
            Dim array As Byte() = binaryReader.ReadBytes(CInt(fileStream.Length))
            binaryReader.Close()
            Dim clsRIM As clsRIM = New clsRIM(array)
            Return clsRIM.GetRIMResource(ktn.RIMorERFindex)
        End Function

        ' Token: 0x06000702 RID: 1794 RVA: 0x002513BC File Offset: 0x002503BC
        Private Sub SearchAllModuleRimsForText(ByVal KotorVerIndex As Integer, ByVal searchText As String, ByVal CaseSensitive As Boolean, ByVal FileTypes As Hashtable, ByVal ResultsForm As frmRefSearchResults)
            Dim cursor As Cursor = Cursor.Current
            Dim text As String = frmMain.CurrentSettings.KotorLocation(KotorVerIndex) + "\Modules"
            Dim directoryInfo As DirectoryInfo = New DirectoryInfo(text)
            Dim files As FileInfo() = directoryInfo.GetFiles("*.rim")
            Dim regex As Regex
            If CaseSensitive Then
                regex = New Regex(searchText.Trim())
            Else
                regex = New Regex(searchText, RegexOptions.IgnoreCase)
            End If
            For Each fileInfo As FileInfo In files
                Dim num As Integer
                Select Case num
                    Case 0
                        Cursor.Current = Cursors.PanNorth
                    Case 1
                        Cursor.Current = Cursors.PanNE
                    Case 2
                        Cursor.Current = Cursors.PanEast
                    Case 3
                        Cursor.Current = Cursors.PanSE
                    Case 4
                        Cursor.Current = Cursors.PanSouth
                    Case 5
                        Cursor.Current = Cursors.PanSW
                    Case 6
                        Cursor.Current = Cursors.PanWest
                    Case 7
                        Cursor.Current = Cursors.PanNW
                        num = -1
                End Select
                num += 1
                Dim fileStream As FileStream = New FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read)
                Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
                Dim array2 As Byte() = binaryReader.ReadBytes(CInt(fileStream.Length))
                binaryReader.Close()
                Dim clsRIM As clsRIM = New clsRIM(array2)
                Dim num2 As Integer = 0
                Dim num3 As Integer = clsRIM.EntryCount - 1
                For j As Integer = num2 To num3
                    If FileTypes.ContainsKey(CType(clsRIM.KeyEntryList(j), RIMKeyEntry)._ResTypeStr) Then
                        Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
                        Dim [string] As String = asciiencoding.GetString(clsRIM.GetRIMResource(j))
                        Dim match As Match = regex.Match([string])
                        If match.Success Then
                            Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode(CType(clsRIM.KeyEntryList(j), RIMKeyEntry))
                            kotorTreeNode.FilePath = fileInfo.FullName
                            kotorTreeNode.RIMorERFindex = j
                            kotorTreeNode.KotorVerIndex = KotorVerIndex
                            ResultsForm.lbMatches.Items.Add(kotorTreeNode)
                        End If
                    End If
                Next
            Next
            Cursor.Current = cursor
        End Sub

        ' Token: 0x06000703 RID: 1795 RVA: 0x002515C8 File Offset: 0x002505C8
        Private Sub ReadERFentries(ByVal ERFFilePath As String, ByVal ktn As KotorTreeNode)
            Dim i As Integer = 48
            Do
                ktn.Nodes.Add(New KotorTreeNode(StringType.FromChar(Strings.Chr(i))))
                i += 1
            Loop While i <= 57
            i = 65
            Do
                ktn.Nodes.Add(New KotorTreeNode(StringType.FromChar(Strings.Chr(i))))
                i += 1
            Loop While i <= 90
            Dim fileStream As FileStream = New FileStream(ERFFilePath, FileMode.Open, FileAccess.Read)
            Dim clsERF As clsERF = New clsERF(fileStream)
            i = 0
            Try
                For Each obj As Object In clsERF.KeyEntryList
                    Dim erfkeyEntry As ERFKeyEntry = CType(obj, ERFKeyEntry)
                    Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode(erfkeyEntry, ERFFilePath)
                    kotorTreeNode.ContainingFileType = "ERF"
                    kotorTreeNode.RIMorERFindex = i
                    Try
                        For Each obj2 As Object In ktn.Nodes
                            Dim kotorTreeNode2 As KotorTreeNode = CType(obj2, KotorTreeNode)
                            If StringType.StrCmp(kotorTreeNode2.Text, StringType.FromChar(Strings.UCase(kotorTreeNode.Text(0))), False) = 0 Then
                                kotorTreeNode2.Nodes.Add(kotorTreeNode)
                                Exit For
                            End If
                        Next
                    Finally
                        Dim enumerator2 As IEnumerator
                        If TypeOf enumerator2 Is IDisposable Then
                            CType(enumerator2, IDisposable).Dispose()
                        End If
                    End Try
                    i += 1
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            i = ktn.Nodes.Count - 1
            While i >= 1
                If ktn.Nodes(i).Nodes.Count = 0 Then
                    ktn.Nodes.RemoveAt(i)
                End If
                i += -1
            End While
        End Sub

        ' Token: 0x06000704 RID: 1796 RVA: 0x0025176C File Offset: 0x0025076C
        Private Function GetERFResource(ByVal ERFFilePath As String, ByVal ktn As KotorTreeNode) As Byte()
            Dim fileStream As FileStream = New FileStream(ERFFilePath, FileMode.Open, FileAccess.Read)
            Dim clsERF As clsERF = New clsERF(fileStream)
            Return clsERF.getERFResource(ktn.RIMorERFindex)
        End Function

        ' Token: 0x06000705 RID: 1797 RVA: 0x00251798 File Offset: 0x00250798
        Private Function GetERFResource(ByVal ERFFilePath As String, ByVal ResRef As String, ByVal ResType As Integer) As Byte()
            Dim fileStream As FileStream = New FileStream(ERFFilePath, FileMode.Open, FileAccess.Read)
            Dim clsERF As clsERF = New clsERF(fileStream)
            Return clsERF.getERFResource(ResRef, ResType)
        End Function

        ' Token: 0x06000706 RID: 1798 RVA: 0x002517C0 File Offset: 0x002507C0
        'Public Shared Sub WriteByteArray(ByVal outputPath As String, ByVal byteArray As Byte())
        '    Dim fileStream As FileStream = New FileStream(outputPath, FileMode.Create)
        '    Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream)
        '    binaryWriter.Write(byteArray)
        '    binaryWriter.Close()
        'End Sub

        Public Shared Sub WriteByteArray(ByVal outputPath As String, ByVal byteArray As Byte())
            Dim outputDirectory As String = IO.Path.GetDirectoryName(outputPath)

            If Not String.IsNullOrEmpty(outputDirectory) AndAlso Not IO.Directory.Exists(outputDirectory) Then
                IO.Directory.CreateDirectory(outputDirectory)
            End If

            Using fileStream As New FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None)
                Using binaryWriter As New BinaryWriter(fileStream)
                    binaryWriter.Write(byteArray)
                End Using
            End Using
        End Sub

        ' Token: 0x06000707 RID: 1799 RVA: 0x002517EC File Offset: 0x002507EC
        Public Function ReadByteArray(ByVal Path As String) As Byte()
            Dim fileStream As FileStream = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)
            Dim binaryReader As BinaryReader = New BinaryReader(fileStream)
            Dim array As Byte() = New Byte(CInt((fileStream.Length - 1L)) + 1 - 1) {}
            fileStream.Read(array, 0, CInt(fileStream.Length))
            fileStream.Close()
            Return array
        End Function

        ' Token: 0x06000708 RID: 1800 RVA: 0x00251840 File Offset: 0x00250840
        Public Shared Sub SaveSettings()
            frmMain.CurrentSettings = UserSettings.GetSettings()
            If frmMain.mainform.WindowState = FormWindowState.Maximized OrElse frmMain.mainform.WindowState = FormWindowState.Minimized Then
                frmMain.mainform.WindowState = FormWindowState.Normal
            End If
            Dim num As Integer = frmMain.mainform.Size.Width
            Dim size As Size = frmMain.mainform.Size
            Dim num2 As Integer = size.Height
            If num2 >= Screen.PrimaryScreen.WorkingArea.Height Then
                num2 = Screen.PrimaryScreen.WorkingArea.Height - 20
            End If
            If num >= Screen.PrimaryScreen.WorkingArea.Width Then
                num = Screen.PrimaryScreen.WorkingArea.Width - 20
            End If
            Dim form As Form = frmMain.mainform
            size = New Size(num, num2)
            form.Size = size
            Dim point As Point = New Point(frmMain.mainform.Location.X, frmMain.mainform.Location.Y)
            If frmMain.mainform.Location.X < 0 Then
                point.X = 0
            End If
            If frmMain.mainform.Location.X + frmMain.mainform.Size.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                point.X = Screen.PrimaryScreen.WorkingArea.Width - frmMain.mainform.Size.Width - 30
            End If
            If frmMain.mainform.Location.Y < 0 Then
                point.Y = 0
            End If
            If frmMain.mainform.Location.Y + frmMain.mainform.Size.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                point.Y = Screen.PrimaryScreen.WorkingArea.Height - frmMain.mainform.Size.Height - 30
            End If
            frmMain.mainform.Location = point
            frmMain.CurrentSettings = UserSettings.GetSettings()
            frmMain.CurrentSettings.MainWindowLoc = frmMain.mainform.Location
            frmMain.CurrentSettings.MainWindowSize = frmMain.mainform.Size
            UserSettings.SaveSettings(frmMain.CurrentSettings)
        End Sub

        ' Token: 0x06000709 RID: 1801 RVA: 0x00251A9C File Offset: 0x00250A9C
        Public Sub SetDefaultSettings()
            frmMain.CurrentSettings = UserSettings.GetSettings()
            frmMain.CurrentSettings.bBuildModelsBifNode = True
            UserSettings.SaveSettings(frmMain.CurrentSettings)
        End Sub

        ' Token: 0x0600070A RID: 1802 RVA: 0x00251AC0 File Offset: 0x00250AC0
        Private Function ParentDescForResType(ByVal ResType As Integer) As String
            If ResType = 3 Then
                Return "TGA Images"
            End If
            If ResType = 4 Then
                Return "WAV Files"
            End If
            If ResType = 2002 Then
                Return "Aurora Model"
            End If
            If ResType = 2009 Then
                Return "Script, Source"
            End If
            If ResType = 2010 Then
                Return "Script, Compiled"
            End If
            If ResType = 2011 Then
                Return "Module"
            End If
            If ResType = 2012 Then
                Return "Static Area Info"
            End If
            If ResType = 2014 Then
                Return "Module Info File"
            End If
            If ResType = 2016 Then
                Return "Walkmesh"
            End If
            If ResType = 2017 Then
                Return "2D Array"
            End If
            If ResType = 2022 Then
                Return "Extra Texture info"
            End If
            If ResType = 2023 Then
                Return "Dynamic Area Info"
            End If
            If ResType = 2025 Then
                Return "Blueprint, Item"
            End If
            If ResType = 2027 Then
                Return "Blueprint, Character"
            End If
            If ResType = 2029 Then
                Return "Dialog"
            End If
            If ResType = 2030 Then
                Return "Blueprint Palette File"
            End If
            If ResType = 2032 Then
                Return "Blueprint, Triggers"
            End If
            If ResType = 2035 Then
                Return "Blueprint, Sound"
            End If
            If ResType = 2036 Then
                Return "Letter-combo Probability File"
            End If
            If ResType = 2038 Then
                Return "Faction File"
            End If
            If ResType = 2040 Then
                Return "Blueprint, Encounter"
            End If
            If ResType = 2042 Then
                Return "Blueprint, Doors"
            End If
            If ResType = 2044 Then
                Return "Blueprint, Placeables"
            End If
            If ResType = 2047 Then
                Return "GUI Elements"
            End If
            If ResType = 2051 Then
                Return "Blueprint, Merchant"
            End If
            If ResType = 2052 Then
                Return "Door Walkmesh"
            End If
            If ResType = 2053 Then
                Return "Placeable Object Walkmesh"
            End If
            If ResType = 2055 Then
                Return "Blueprint, "
            End If
            If ResType = 2056 Then
                Return "Journal File"
            End If
            If ResType = 2058 Then
                Return "Blueprint, Waypoint"
            End If
            If ResType = 2060 Then
                Return "Sound Sets"
            End If
            If ResType = 3000 Then
                Return "Layouts"
            End If
            If ResType = 3003 Then
                Return "Paths"
            End If
            If ResType = 3007 Then
                Return "PC Textures"
            End If
            If ResType = 3008 Then
                Return "Aurora Model Extension"
            End If
            Return frmMain.GetRsrcTypeForID(ResType)
        End Function

        ' Token: 0x0600070B RID: 1803 RVA: 0x00251CB8 File Offset: 0x00250CB8
        Public Shared Function GetIDForRsrcType(ByVal type As String) As Short
            If StringType.StrCmp(type, "res", False) = 0 Then
                Return 0S
            End If
            If StringType.StrCmp(type, "bmp", False) = 0 Then
                Return 1S
            End If
            If StringType.StrCmp(type, "mve", False) = 0 Then
                Return 2S
            End If
            If StringType.StrCmp(type, "tga", False) = 0 Then
                Return 3S
            End If
            If StringType.StrCmp(type, "wav", False) = 0 Then
                Return 4S
            End If
            If StringType.StrCmp(type, "plt", False) = 0 Then
                Return 6S
            End If
            If StringType.StrCmp(type, "ini", False) = 0 Then
                Return 7S
            End If
            If StringType.StrCmp(type, "mp3", False) = 0 Then
                Return 8S
            End If
            If StringType.StrCmp(type, "mpg", False) = 0 Then
                Return 9S
            End If
            If StringType.StrCmp(type, "txt", False) = 0 Then
                Return 10S
            End If
            If StringType.StrCmp(type, "wma", False) = 0 Then
                Return 11S
            End If
            If StringType.StrCmp(type, "wmv", False) = 0 Then
                Return 12S
            End If
            If StringType.StrCmp(type, "xmv", False) = 0 Then
                Return 13S
            End If
            If StringType.StrCmp(type, "plh", False) = 0 Then
                Return 2000S
            End If
            If StringType.StrCmp(type, "tex", False) = 0 Then
                Return 2001S
            End If
            If StringType.StrCmp(type, "mdl", False) = 0 Then
                Return 2002S
            End If
            If StringType.StrCmp(type, "thg", False) = 0 Then
                Return 2003S
            End If
            If StringType.StrCmp(type, "fnt", False) = 0 Then
                Return 2005S
            End If
            If StringType.StrCmp(type, "lua", False) = 0 Then
                Return 2007S
            End If
            If StringType.StrCmp(type, "slt", False) = 0 Then
                Return 2008S
            End If
            If StringType.StrCmp(type, "nss", False) = 0 Then
                Return 2009S
            End If
            If StringType.StrCmp(type, "ncs", False) = 0 Then
                Return 2010S
            End If
            If StringType.StrCmp(type, "mod", False) = 0 Then
                Return 2011S
            End If
            If StringType.StrCmp(type, "are", False) = 0 Then
                Return 2012S
            End If
            If StringType.StrCmp(type, "set", False) = 0 Then
                Return 2013S
            End If
            If StringType.StrCmp(type, "ifo", False) = 0 Then
                Return 2014S
            End If
            If StringType.StrCmp(type, "bic", False) = 0 Then
                Return 2015S
            End If
            If StringType.StrCmp(type, "wok", False) = 0 Then
                Return 2016S
            End If
            If StringType.StrCmp(type, "2da", False) = 0 Then
                Return 2017S
            End If
            If StringType.StrCmp(type, "tlk", False) = 0 Then
                Return 2018S
            End If
            If StringType.StrCmp(type, "txi", False) = 0 Then
                Return 2022S
            End If
            If StringType.StrCmp(type, "git", False) = 0 Then
                Return 2023S
            End If
            If StringType.StrCmp(type, "bti", False) = 0 Then
                Return 2024S
            End If
            If StringType.StrCmp(type, "uti", False) = 0 Then
                Return 2025S
            End If
            If StringType.StrCmp(type, "btc", False) = 0 Then
                Return 2026S
            End If
            If StringType.StrCmp(type, "utc", False) = 0 Then
                Return 2027S
            End If
            If StringType.StrCmp(type, "dlg", False) = 0 Then
                Return 2029S
            End If
            If StringType.StrCmp(type, "itp", False) = 0 Then
                Return 2030S
            End If
            If StringType.StrCmp(type, "btt", False) = 0 Then
                Return 2031S
            End If
            If StringType.StrCmp(type, "utt", False) = 0 Then
                Return 2032S
            End If
            If StringType.StrCmp(type, "dds", False) = 0 Then
                Return 2033S
            End If
            If StringType.StrCmp(type, "bts", False) = 0 Then
                Return 2034S
            End If
            If StringType.StrCmp(type, "uts", False) = 0 Then
                Return 2035S
            End If
            If StringType.StrCmp(type, "ltr", False) = 0 Then
                Return 2036S
            End If
            If StringType.StrCmp(type, "gff", False) = 0 Then
                Return 2037S
            End If
            If StringType.StrCmp(type, "fac", False) = 0 Then
                Return 2038S
            End If
            If StringType.StrCmp(type, "bts", False) = 0 Then
                Return 2039S
            End If
            If StringType.StrCmp(type, "ute", False) = 0 Then
                Return 2040S
            End If
            If StringType.StrCmp(type, "btd", False) = 0 Then
                Return 2041S
            End If
            If StringType.StrCmp(type, "utd", False) = 0 Then
                Return 2042S
            End If
            If StringType.StrCmp(type, "btp", False) = 0 Then
                Return 2043S
            End If
            If StringType.StrCmp(type, "utp", False) = 0 Then
                Return 2044S
            End If
            If StringType.StrCmp(type, "dft", False) = 0 Then
                Return 2045S
            End If
            If StringType.StrCmp(type, "gic", False) = 0 Then
                Return 2046S
            End If
            If StringType.StrCmp(type, "gui", False) = 0 Then
                Return 2047S
            End If
            If StringType.StrCmp(type, "css", False) = 0 Then
                Return 2048S
            End If
            If StringType.StrCmp(type, "ccs", False) = 0 Then
                Return 2049S
            End If
            If StringType.StrCmp(type, "btm", False) = 0 Then
                Return 2050S
            End If
            If StringType.StrCmp(type, "utm", False) = 0 Then
                Return 2051S
            End If
            If StringType.StrCmp(type, "dwk", False) = 0 Then
                Return 2052S
            End If
            If StringType.StrCmp(type, "pwk", False) = 0 Then
                Return 2053S
            End If
            If StringType.StrCmp(type, "btg", False) = 0 Then
                Return 2054S
            End If
            If StringType.StrCmp(type, "utg", False) = 0 Then
                Return 2055S
            End If
            If StringType.StrCmp(type, "jrl", False) = 0 Then
                Return 2056S
            End If
            If StringType.StrCmp(type, "sav", False) = 0 Then
                Return 2057S
            End If
            If StringType.StrCmp(type, "utw", False) = 0 Then
                Return 2058S
            End If
            If StringType.StrCmp(type, "4pc", False) = 0 Then
                Return 2059S
            End If
            If StringType.StrCmp(type, "ssf", False) = 0 Then
                Return 2060S
            End If
            If StringType.StrCmp(type, "hak", False) = 0 Then
                Return 2061S
            End If
            If StringType.StrCmp(type, "nwm", False) = 0 Then
                Return 2062S
            End If
            If StringType.StrCmp(type, "bik", False) = 0 Then
                Return 2063S
            End If
            If StringType.StrCmp(type, "ndb", False) = 0 Then
                Return 2064S
            End If
            If StringType.StrCmp(type, "ptm", False) = 0 Then
                Return 2065S
            End If
            If StringType.StrCmp(type, "ptt", False) = 0 Then
                Return 2066S
            End If
            If StringType.StrCmp(type, "lyt", False) = 0 Then
                Return 3000S
            End If
            If StringType.StrCmp(type, "vis", False) = 0 Then
                Return 3001S
            End If
            If StringType.StrCmp(type, "rim", False) = 0 Then
                Return 3002S
            End If
            If StringType.StrCmp(type, "pth", False) = 0 Then
                Return 3003S
            End If
            If StringType.StrCmp(type, "lip", False) = 0 Then
                Return 3004S
            End If
            If StringType.StrCmp(type, "bwm", False) = 0 Then
                Return 3005S
            End If
            If StringType.StrCmp(type, "txb", False) = 0 Then
                Return 3006S
            End If
            If StringType.StrCmp(type, "tpc", False) = 0 Then
                Return 3007S
            End If
            If StringType.StrCmp(type, "mdx", False) = 0 Then
                Return 3008S
            End If
            If StringType.StrCmp(type, "rsv", False) = 0 Then
                Return 3009S
            End If
            If StringType.StrCmp(type, "sig", False) = 0 Then
                Return 3010S
            End If
            If StringType.StrCmp(type, "xbx", False) = 0 Then
                Return 3011S
            End If
            If StringType.StrCmp(type, "erf", False) = 0 Then
                Return 9997S
            End If
            If StringType.StrCmp(type, "bif", False) = 0 Then
                Return 9998S
            End If
            If StringType.StrCmp(type, "key", False) = 0 Then
                Return 9999S
            End If
            Return -1S
        End Function

        ' Token: 0x0600070C RID: 1804 RVA: 0x002523E8 File Offset: 0x002513E8
        Public Shared Function GetRsrcTypeForID(ByVal id As Integer) As String
            If id = 0 Then
                Return "res"
            End If
            If id = 1 Then
                Return "bmp"
            End If
            If id = 2 Then
                Return "mve"
            End If
            If id = 3 Then
                Return "tga"
            End If
            If id = 4 Then
                Return "wav"
            End If
            If id = 6 Then
                Return "plt"
            End If
            If id = 7 Then
                Return "ini"
            End If
            If id = 8 Then
                Return "mp3"
            End If
            If id = 9 Then
                Return "mpg"
            End If
            If id = 10 Then
                Return "txt"
            End If
            If id = 11 Then
                Return "wma"
            End If
            If id = 12 Then
                Return "wmv"
            End If
            If id = 13 Then
                Return "xmv"
            End If
            If id = 2000 Then
                Return "plh"
            End If
            If id = 2001 Then
                Return "tex"
            End If
            If id = 2002 Then
                Return "mdl"
            End If
            If id = 2003 Then
                Return "thg"
            End If
            If id = 2005 Then
                Return "fnt"
            End If
            If id = 2007 Then
                Return "lua"
            End If
            If id = 2008 Then
                Return "slt"
            End If
            If id = 2009 Then
                Return "nss"
            End If
            If id = 2010 Then
                Return "ncs"
            End If
            If id = 2011 Then
                Return "mod"
            End If
            If id = 2012 Then
                Return "are"
            End If
            If id = 2013 Then
                Return "set"
            End If
            If id = 2014 Then
                Return "ifo"
            End If
            If id = 2015 Then
                Return "bic"
            End If
            If id = 2016 Then
                Return "wok"
            End If
            If id = 2017 Then
                Return "2da"
            End If
            If id = 2018 Then
                Return "tlk"
            End If
            If id = 2022 Then
                Return "txi"
            End If
            If id = 2023 Then
                Return "git"
            End If
            If id = 2024 Then
                Return "bti"
            End If
            If id = 2025 Then
                Return "uti"
            End If
            If id = 2026 Then
                Return "btc"
            End If
            If id = 2027 Then
                Return "utc"
            End If
            If id = 2029 Then
                Return "dlg"
            End If
            If id = 2030 Then
                Return "itp"
            End If
            If id = 2031 Then
                Return "btt"
            End If
            If id = 2032 Then
                Return "utt"
            End If
            If id = 2033 Then
                Return "dds"
            End If
            If id = 2034 Then
                Return "bts"
            End If
            If id = 2035 Then
                Return "uts"
            End If
            If id = 2036 Then
                Return "ltr"
            End If
            If id = 2037 Then
                Return "gff"
            End If
            If id = 2038 Then
                Return "fac"
            End If
            If id = 2039 Then
                Return "bts"
            End If
            If id = 2040 Then
                Return "ute"
            End If
            If id = 2041 Then
                Return "btd"
            End If
            If id = 2042 Then
                Return "utd"
            End If
            If id = 2043 Then
                Return "btp"
            End If
            If id = 2044 Then
                Return "utp"
            End If
            If id = 2045 Then
                Return "dft"
            End If
            If id = 2046 Then
                Return "gic"
            End If
            If id = 2047 Then
                Return "gui"
            End If
            If id = 2048 Then
                Return "css"
            End If
            If id = 2049 Then
                Return "ccs"
            End If
            If id = 2050 Then
                Return "btm"
            End If
            If id = 2051 Then
                Return "utm"
            End If
            If id = 2052 Then
                Return "dwk"
            End If
            If id = 2053 Then
                Return "pwk"
            End If
            If id = 2054 Then
                Return "btg"
            End If
            If id = 2055 Then
                Return "utg"
            End If
            If id = 2056 Then
                Return "jrl"
            End If
            If id = 2057 Then
                Return "sav"
            End If
            If id = 2058 Then
                Return "utw"
            End If
            If id = 2059 Then
                Return "4pc"
            End If
            If id = 2060 Then
                Return "ssf"
            End If
            If id = 2061 Then
                Return "hak"
            End If
            If id = 2062 Then
                Return "nwm"
            End If
            If id = 2063 Then
                Return "bik"
            End If
            If id = 2064 Then
                Return "ndb"
            End If
            If id = 2065 Then
                Return "ptm"
            End If
            If id = 2066 Then
                Return "ptt"
            End If
            If id = 3000 Then
                Return "lyt"
            End If
            If id = 3001 Then
                Return "vis"
            End If
            If id = 3002 Then
                Return "rim"
            End If
            If id = 3003 Then
                Return "pth"
            End If
            If id = 3004 Then
                Return "lip"
            End If
            If id = 3005 Then
                Return "bwm"
            End If
            If id = 3006 Then
                Return "txb"
            End If
            If id = 3007 Then
                Return "tpc"
            End If
            If id = 3008 Then
                Return "mdx"
            End If
            If id = 3009 Then
                Return "rsv"
            End If
            If id = 3010 Then
                Return "sig"
            End If
            If id = 3011 Then
                Return "xbx"
            End If
            If id = 9997 Then
                Return "erf"
            End If
            If id = 9998 Then
                Return "bif"
            End If
            If id = 9999 Then
                Return "key"
            End If
            Return "Unk (" + StringType.FromInteger(id) + ")"
        End Function

        ' Token: 0x0600070D RID: 1805 RVA: 0x002528BC File Offset: 0x002518BC
        Public Shared Function GetFilePath(ByVal action As String, ByVal startPath As String, ByVal sugg_filename As String, ByVal msg As String, ByVal filtertype As String, Optional ByVal multiselect As Boolean = False, Optional ByVal updateSavePath As Boolean = True) As Object
            If StringType.StrCmp(action, "load", False) = 0 Then
                Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
                If StringType.StrCmp(filtertype, "key", False) = 0 Then
                    openFileDialog.Title = "Select Chitin.key file..."
                    openFileDialog.Filter = "Chitin files (*.key)|*.key"
                ElseIf StringType.StrCmp(filtertype, "2da", False) = 0 Then
                    openFileDialog.Title = "Select 2DA file..."
                    openFileDialog.Filter = "2D Array files (*.2da)|*.2da"
                ElseIf StringType.StrCmp(filtertype, "tpc", False) = 0 Then
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "TPC Files (*.tpc)|*.tpc"
                ElseIf StringType.StrCmp(filtertype, "tga", False) = 0 Then
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "TGA files (*.tga)|*.tga"
                ElseIf StringType.StrCmp(filtertype, "xml", False) = 0 Then
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "XML files (*.xml)|*.xml"
                ElseIf StringType.StrCmp(filtertype, "dlg", False) = 0 Then
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "DLG (Conversation) files (*.dlg)|*.dlg"
                ElseIf StringType.StrCmp(filtertype, "tlk", False) = 0 Then
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "Talk files (*.tlk)|*.tlk"
                ElseIf StringType.StrCmp(filtertype, "pwk", False) = 0 Then
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "All Walkmesh files (*.pwk,*.dwk,*.wok)|*.pwk;*.dwk;*.wok|PWK files (*.pwk)|*.pwk|DWK files (*.dwk)|*.dwk|WOK files (*.wok)|*.wok"
                ElseIf StringType.StrCmp(filtertype, "ssf", False) = 0 Then
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "SSF files (*.ssf)|*.ssf"
                ElseIf StringType.StrCmp(filtertype, "gffsupported", False) = 0 Then
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "Supported GFF format files (*.dlg;*.utc;*.utd;*.uti;*.utm;*.utp;*.uts;*.utt;*.utw)|*.dlg;*.utc;*.utd;*.uti;*.utm;*.utp;*.uts;*.utt;*.utw"
                    Dim openFileDialog2 As OpenFileDialog = openFileDialog
                    openFileDialog2.Filter += "|Dialog files (*.dlg)|*.dlg"
                    openFileDialog2 = openFileDialog
                    openFileDialog2.Filter += "|Creature files (*.utc)|*.utc"
                    openFileDialog2 = openFileDialog
                    openFileDialog2.Filter += "|Door files (*.utd)|*.utd"
                    openFileDialog2 = openFileDialog
                    openFileDialog2.Filter += "|Item files (*.uti)|*.uti"
                    openFileDialog2 = openFileDialog
                    openFileDialog2.Filter += "|Merchant files (*.utm)|*.utm"
                    openFileDialog2 = openFileDialog
                    openFileDialog2.Filter += "|Placeable files (*.utp)|*.utp"
                    openFileDialog2 = openFileDialog
                    openFileDialog2.Filter += "|Sound files (*.uts)|*.uts"
                    openFileDialog2 = openFileDialog
                    openFileDialog2.Filter += "|Trigger files (*.utt)|*.utt"
                    openFileDialog2 = openFileDialog
                    openFileDialog2.Filter += "|Waypoint files (*.utw)|*.utw"
                Else
                    openFileDialog.Title = msg
                    openFileDialog.Filter = "All files (*.*)|*.*"
                End If
                openFileDialog.InitialDirectory = startPath
                openFileDialog.FilterIndex = 1
                openFileDialog.Multiselect = multiselect
                openFileDialog.RestoreDirectory = True
                openFileDialog.FileName = sugg_filename
                If openFileDialog.ShowDialog() <> DialogResult.OK Then
                    Return ""
                End If
                If StringType.StrCmp(startPath, "", False) <> 0 Then
                    frmMain.CurrentSettings = UserSettings.GetSettings()
                    frmMain.CurrentSettings.defaultImportLocation = Strings.Mid(openFileDialog.FileName, 1, openFileDialog.FileName.LastIndexOf("\"))
                    UserSettings.SaveSettings(frmMain.CurrentSettings)
                End If
                If Not multiselect Then
                    Return openFileDialog.FileName
                End If
                Return openFileDialog.FileNames
            ElseIf StringType.StrCmp(action, "save", False) = 0 Then
                Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
                If StringType.StrCmp(filtertype, "2da", False) = 0 Then
                    saveFileDialog.Title = "Select 2DA file..."
                    saveFileDialog.Filter = "2D Array files (*.2da)|*.2da"
                ElseIf StringType.StrCmp(filtertype, "tpc", False) = 0 Then
                    saveFileDialog.Title = msg
                    saveFileDialog.Filter = "TPC Files (*.tpc)|*.tpc"
                ElseIf StringType.StrCmp(filtertype, "tga", False) = 0 Then
                    saveFileDialog.Title = msg
                    saveFileDialog.Filter = "TGA files (*.tga)|*.tga"
                ElseIf StringType.StrCmp(filtertype, "xml", False) = 0 Then
                    saveFileDialog.Title = msg
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml"
                ElseIf StringType.StrCmp(filtertype, "pwk", False) = 0 Then
                    saveFileDialog.Title = msg
                    saveFileDialog.Filter = "All Walkmesh files (*.pwk,*.dwk,*.wok)|*.pwk;*.dwk;*.wok|PWK files (*.pwk)|*.pwk|DWK files (*.dwk)|*.dwk|WOK files (*.wok)|*.wok"
                ElseIf StringType.StrCmp(filtertype, "mod", False) = 0 Then
                    saveFileDialog.Title = msg
                    saveFileDialog.Filter = "MOD files (*.mod)|*.mod"
                ElseIf StringType.StrCmp(filtertype, "mod", False) = 0 Then
                    saveFileDialog.Title = msg
                    saveFileDialog.Filter = "SSF files (*.ssf)|*.ssf"
                Else
                    saveFileDialog.Title = msg
                    saveFileDialog.Filter = "All files (*.*)|*.*"
                End If
                saveFileDialog.InitialDirectory = startPath
                saveFileDialog.CheckFileExists = False
                saveFileDialog.FilterIndex = 1
                saveFileDialog.RestoreDirectory = True
                saveFileDialog.FileName = sugg_filename
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    If updateSavePath Then
                        frmMain.CurrentSettings = UserSettings.GetSettings()
                        frmMain.CurrentSettings.defaultSaveLocation = Strings.Mid(saveFileDialog.FileName, 1, saveFileDialog.FileName.LastIndexOf("\"))
                        UserSettings.SaveSettings(frmMain.CurrentSettings)
                    End If
                    Return saveFileDialog.FileName
                End If
                Return ""
            Else
                Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
                folderBrowserDialog.Description = msg
                folderBrowserDialog.SelectedPath = startPath
                folderBrowserDialog.ShowNewFolderButton = True
                If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                    If updateSavePath Then
                        frmMain.CurrentSettings = UserSettings.GetSettings()
                        frmMain.CurrentSettings.defaultSaveLocation = folderBrowserDialog.SelectedPath
                        UserSettings.SaveSettings(frmMain.CurrentSettings)
                    End If
                    Return folderBrowserDialog.SelectedPath
                End If
                Return ""
            End If
        End Function

        ' Token: 0x0600070E RID: 1806 RVA: 0x00252E14 File Offset: 0x00251E14
        Private Sub EditGFFResource(ByVal filename As String, ByVal data As Byte())
            'Me.EnsureWorkingDirectoryExists()
            'If File.Exists(frmMain.gRootPath + "working\" + filename) Then
            '    File.Delete(frmMain.gRootPath + "working\" + filename)
            'End If
            'frmMain.WriteByteArray(frmMain.gRootPath + "working\" + filename, data)
            'Me.LaunchGFFEditor(frmMain.gRootPath + "working\" + filename)

            Dim workingFilePath As String = frmMain.GetWorkingFilePath(filename)

            If File.Exists(workingFilePath) Then
                File.Delete(workingFilePath)
            End If

            frmMain.WriteByteArray(workingFilePath, data)
            Me.LaunchGFFEditor(workingFilePath)

        End Sub

        ' Token: 0x0600070F RID: 1807 RVA: 0x00252E80 File Offset: 0x00251E80
        Private Sub LaunchGFFEditor(ByVal filename As String)
            Dim text As String = frmMain.gRootPath + "gffeditor.exe"
            Try
                Process.Start(text, filename)
            Catch ex As System.Exception
                If StringType.StrCmp(ex.Message, "", False) <> 0 Then
                    Interaction.MsgBox("                      Error launching GFFEditor" & vbCr & vbCr & "Is it installed in the same directory as this program?", MsgBoxStyle.OkOnly, Nothing)
                End If
            End Try
        End Sub

        ' Token: 0x06000710 RID: 1808 RVA: 0x00252EE8 File Offset: 0x00251EE8
        Private Sub EditTPCResource(ByVal filename As String, ByVal data As Byte())
            Dim frmImageViewer As frmImageViewer = New frmImageViewer()
            If File.Exists(frmMain.gRootPath + "tpc2tga.exe") Then
                Interaction.MsgBox("tpc2tga is installed in the same directory as Kotor Tool, but is no longer needed", MsgBoxStyle.Critical, "TPC2TGA not needed")
            End If
            If Not File.Exists(frmMain.CurrentSettings.ImageViewerLocation) Then
                Interaction.MsgBox("The image viewer you have configured was not found in the location you specified", MsgBoxStyle.Critical, "Helper app missing")
                Return
            End If
            Me.EnsureWorkingDirectoryExists()
            frmImageViewer.SetupTPCData(data, "foo")
            frmImageViewer.DecodeImage()
            frmImageViewer.WriteTGAFile(frmMain.gRootPath + "working\" + Path.GetFileNameWithoutExtension(filename) + ".tga")
            Dim imageViewerLocation As String = frmMain.CurrentSettings.ImageViewerLocation
            Try
                Process.Start(imageViewerLocation, String.Concat(New String() {"""", frmMain.gRootPath, "working\", Path.GetFileNameWithoutExtension(filename), ".tga", """"}))
            Catch ex As System.Exception
                If StringType.StrCmp(ex.Message, "", False) <> 0 Then
                    Interaction.MsgBox("                      Error launching image viewer" & vbCr & vbCr & "Is it installed where you specified it to be?", MsgBoxStyle.OkOnly, Nothing)
                End If
            End Try
        End Sub

        ' Token: 0x06000711 RID: 1809 RVA: 0x00253010 File Offset: 0x00252010
        Private Sub OpenTGAInExternalViewer(ByVal filename As String, ByVal data As Byte())
            Dim imageViewerLocation As String = frmMain.CurrentSettings.ImageViewerLocation
            If Not File.Exists(imageViewerLocation) Then
                Interaction.MsgBox("The image viewer you have configured was not found in the location you specified", MsgBoxStyle.Critical, "Helper app missing")
                Return
            End If
            Me.EnsureWorkingDirectoryExists()
            frmMain.WriteByteArray(frmMain.gRootPath + "working\" + filename, data)
            Try
                Process.Start(imageViewerLocation, String.Concat(New String() {"""", frmMain.gRootPath, "working\", filename, """"}))
            Catch ex As System.Exception
                If StringType.StrCmp(ex.Message, "", False) <> 0 Then
                    Interaction.MsgBox("                      Error launching image viewer" & vbCr & vbCr & "Is it installed where you specified it to be?", MsgBoxStyle.OkOnly, Nothing)
                End If
            End Try
        End Sub

        ' Token: 0x06000712 RID: 1810 RVA: 0x002530D8 File Offset: 0x002520D8
        Private Sub ShowImage(ByVal node As KotorTreeNode)
            Dim array As Array
            If StringType.StrCmp(node.ContainingFileType, "ERF", False) = 0 Then
                array = Me.GetERFResource(node.FilePath, node)
            Else
                If StringType.StrCmp(node.ContainingFileType, "BIF", False) <> 0 Then
                    Return
                End If
                array = Me.GetBIFFResource(node.FilePath, node.LocalResID).data
            End If
            If frmMain.gImageViewer Is Nothing OrElse Not frmMain.gImageViewer.Created Then
                frmMain.gImageViewer = New frmImageViewer()
                Dim control As Control = frmMain.gImageViewer
                Dim point As Point = New Point(Me.Location.X + Me.Size.Width, Me.Location.Y)
                control.Location = point
            End If
            frmMain.gImageViewer.SetupTPCData(array, node.Filename)
            frmMain.gImageViewer.DecodeImage()
            frmMain.gImageViewer.Show()
        End Sub

        ' Token: 0x06000713 RID: 1811 RVA: 0x002531B8 File Offset: 0x002521B8
        Public Sub EnsureWorkingDirectoryExists()
            ''If Not Directory.Exists(frmMain.gRootPath + "working") Then
            ''Directory.CreateDirectory(frmMain.gRootPath + "working")
            ''End If

            frmMain.gWorkingPath = frmMain.GetWorkingDirectoryPath()
        End Sub

        '' Token: 0x06000714 RID: 1812 RVA: 0x002531E8 File Offset: 0x002521E8
        'Public Shared Function hasKotor1() As Boolean
        '    Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\Bioware\SW\KOTOR")
        '    Dim flag As Boolean
        '    If registryKey IsNot Nothing Then
        '        flag = registryKey.GetValue("path") IsNot Nothing
        '    End If
        '    Return flag
        'End Function

        '' Token: 0x06000715 RID: 1813 RVA: 0x00253220 File Offset: 0x00252220
        'Public Shared Function hasKotor2() As Boolean
        '    Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\LucasArts\KotOR2")
        '    Dim flag As Boolean
        '    If registryKey IsNot Nothing Then
        '        flag = registryKey.GetValue("path") IsNot Nothing
        '    End If
        '    Return flag
        'End Function

        ' Token: 0x06000714 RID: 1812 RVA: 0x002531E8 File Offset: 0x002521E8
        Public Shared Function hasKotor1() As Boolean
            Try
                Dim settings As Options = UserSettings.GetSettings()

                If settings IsNot Nothing Then
                    Dim configuredPath As String = settings.KotorLocation(0)

                    If configuredPath IsNot Nothing AndAlso configuredPath.Trim().Length > 0 Then
                        If File.Exists(Path.Combine(configuredPath, "chitin.key")) Then
                            Return True
                        End If
                    End If
                End If
            Catch ex As System.Exception
            End Try

            Try
                Dim detectedPath As String = frmPathManager.DetectKotor1Path()

                If detectedPath IsNot Nothing AndAlso detectedPath.Trim().Length > 0 Then
                    Return File.Exists(Path.Combine(detectedPath, "chitin.key"))
                End If
            Catch ex As System.Exception
            End Try

            Return False
        End Function

        ' Token: 0x06000715 RID: 1813 RVA: 0x00253220 File Offset: 0x00252220
        Public Shared Function hasKotor2() As Boolean
            Try
                Dim settings As Options = UserSettings.GetSettings()

                If settings IsNot Nothing Then
                    Dim configuredPath As String = settings.KotorLocation(1)

                    If configuredPath IsNot Nothing AndAlso configuredPath.Trim().Length > 0 Then
                        If File.Exists(Path.Combine(configuredPath, "chitin.key")) Then
                            Return True
                        End If
                    End If
                End If
            Catch ex As System.Exception
            End Try

            Try
                Dim detectedPath As String = frmPathManager.DetectKotor2Path()

                If detectedPath IsNot Nothing AndAlso detectedPath.Trim().Length > 0 Then
                    Return File.Exists(Path.Combine(detectedPath, "chitin.key"))
                End If
            Catch ex As System.Exception
            End Try

            Return False
        End Function

        ' Token: 0x06000716 RID: 1814 RVA: 0x00253258 File Offset: 0x00252258
        Public Shared Function IsOnly1KotORInstalled() As Boolean
            Return frmMain.hasKotor1() Xor frmMain.hasKotor2()
        End Function

        ' Token: 0x06000717 RID: 1815 RVA: 0x00253270 File Offset: 0x00252270
        Public Shared Function GetUniqueKotorInstalledVersion() As Integer
            If Not frmMain.IsOnly1KotORInstalled() Then
                Return -1
            End If
            If frmMain.hasKotor1() Then
                Return 0
            End If
            If frmMain.hasKotor2() Then
                Return 1
            End If
            Dim num As Integer
            Return num
        End Function

        ' Token: 0x06000718 RID: 1816 RVA: 0x0025329C File Offset: 0x0025229C
        Private Function OpenFileFromCmdLine() As Form
            Dim num As Integer = 0
            Dim num2 As Integer = Me.CmdArgs.Length - 1
            For i As Integer = num To num2
                If StringType.StrCmp(Me.CmdArgs(i), "-mapinfo", False) = 0 Then
                    Me.CreateMapInfoBFD_Click(Nothing, Nothing)
                    Environment.[Exit](0)
                End If
            Next
            If (StringType.StrCmp(Path.GetExtension(Me.CmdArgs(0)).ToLower(), ".2da", False) <> 0) And (StringType.StrCmp(Path.GetExtension(Me.CmdArgs(0)).ToLower(), ".tlk", False) <> 0) Then
                Return Me.OpenGFFFileInEditor(Me.CmdArgs(0), -1)
            End If
            If StringType.StrCmp(Path.GetExtension(Me.CmdArgs(0)).ToLower(), ".2da", False) = 0 Then
                Cursor.Current = Cursors.WaitCursor
                Dim fileStream As FileStream = New FileStream(Me.CmdArgs(0), FileMode.Open, FileAccess.Read)
                Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
                Dim array As Byte() = binaryReader.ReadBytes(CInt(fileStream.Length))
                binaryReader.Close()
                Dim frm2DAEditor As frm2DAEditor = New frm2DAEditor(Path.GetFileName(Me.CmdArgs(0)), array, -1)
                Dim control As Control = frm2DAEditor
                Dim point As Point = New Point(Me.Location.X + Me.Size.Width, Me.Location.Y)
                control.Location = point
                frm2DAEditor.Show()
                Return frm2DAEditor
            End If
            If StringType.StrCmp(Path.GetExtension(Me.CmdArgs(0)).ToLower(), ".tlk", False) = 0 Then
                Dim frmDialogTlk As frmDialogTlk = New frmDialogTlk(Me.CmdArgs(0))
                frmDialogTlk.Show()
                Return frmDialogTlk
            End If
            Dim form As Form
            Return form
        End Function

        ' Token: 0x06000719 RID: 1817 RVA: 0x0025343C File Offset: 0x0025243C
        Public Shared Function GetGFFFileKotorVersionIndex(ByVal filepath As String) As Integer
            Dim fileStream As FileStream
            Try
                fileStream = New FileStream(filepath, FileMode.Open, FileAccess.Read)
            Catch ex As FileNotFoundException
                Dim ex2 As FileNotFoundException = CType(ex, FileNotFoundException)
                Throw New FileNotFoundException()
            Catch ex3 As DirectoryNotFoundException
                Dim ex4 As DirectoryNotFoundException = CType(ex3, DirectoryNotFoundException)
                Throw New DirectoryNotFoundException()
            End Try
            Dim clsGFF As clsGFF = New clsGFF(fileStream, -1, True)
            Dim num As Integer = clsGFF.KotorVersIndex()
            If num > -1 Then
                Return num
            End If
            If num = -1 AndAlso frmMain.IsOnly1KotORInstalled() Then
                Dim text As String
                If frmMain.GetUniqueKotorInstalledVersion() = 0 Then
                    text = "KotOR I"
                Else
                    text = "KotOR II:TSL"
                End If
                If Interaction.MsgBox(String.Concat(New String() {"The file '", Path.GetFileName(filepath), "' has no embedded version info. Do you want to open in using ", text, "'s data?"}), MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    Return frmMain.GetUniqueKotorInstalledVersion()
                End If
                Return -1
            Else
                Dim frmSpecifyKotorVersion As frmSpecifyKotorVersion = New frmSpecifyKotorVersion()
                frmSpecifyKotorVersion.FileName = Path.GetFileName(filepath)
                If frmSpecifyKotorVersion.ShowDialog(frmMain.mainform) = DialogResult.OK Then
                    Return frmSpecifyKotorVersion.KotorVerIndexSelected
                End If
                Return -1
            End If
        End Function

        ' Token: 0x0600071A RID: 1818 RVA: 0x00253550 File Offset: 0x00252550
        Public Function OpenGFFFileInEditor(ByVal filepath As String, Optional ByVal formLocationOffset As Integer = -1) As Form
            Dim gfffileKotorVersionIndex As Integer
            Dim form As Form
            Try
                gfffileKotorVersionIndex = frmMain.GetGFFFileKotorVersionIndex(filepath)
            Catch ex As FileNotFoundException
                Dim ex2 As FileNotFoundException = CType(ex, FileNotFoundException)
                Me.ManageMRUMainFileList(filepath, True)
                Interaction.MsgBox("Could not find file: " + filepath, MsgBoxStyle.Critical, "")
                Return form
            Catch ex3 As DirectoryNotFoundException
                Dim ex4 As DirectoryNotFoundException = CType(ex3, DirectoryNotFoundException)
                Me.ManageMRUMainFileList(filepath, True)
                Interaction.MsgBox("Could not directory in path to: " + filepath, MsgBoxStyle.Critical, "")
                Return form
            End Try
            If gfffileKotorVersionIndex <> -1 Then
                Dim fileStream As FileStream = New FileStream(filepath, FileMode.Open, FileAccess.Read)
                Dim text As String = Strings.LCase(Path.GetExtension(filepath))
                Dim obj As Object
                If StringType.StrCmp(text, ".utc", False) = 0 Then
                    obj = New frmUTC_Editor(New clsUTC(fileStream, gfffileKotorVersionIndex), gfffileKotorVersionIndex, False, "")
                ElseIf StringType.StrCmp(text, ".uti", False) = 0 Then
                    obj = New frmUTI_Editor(New clsUTI(fileStream, gfffileKotorVersionIndex), gfffileKotorVersionIndex, False, "")
                ElseIf StringType.StrCmp(text, ".utd", False) = 0 Then
                    obj = New frmUTD_Editor(New clsUTD(fileStream, gfffileKotorVersionIndex), gfffileKotorVersionIndex, False, "")
                ElseIf StringType.StrCmp(text, ".utm", False) = 0 Then
                    obj = New frmUTM_Editor(New clsUTM(fileStream, gfffileKotorVersionIndex), gfffileKotorVersionIndex, False, "")
                ElseIf StringType.StrCmp(text, ".utp", False) = 0 Then
                    obj = New frmUTP_Editor(New clsUTP(fileStream, gfffileKotorVersionIndex), gfffileKotorVersionIndex, False, "")
                ElseIf StringType.StrCmp(text, ".uts", False) = 0 Then
                    obj = New frmUTS_Editor(New clsUTS(fileStream, gfffileKotorVersionIndex), gfffileKotorVersionIndex, False, "")
                ElseIf StringType.StrCmp(text, ".utt", False) = 0 Then
                    obj = New frmUTT_Editor(New clsUTT(fileStream, gfffileKotorVersionIndex), gfffileKotorVersionIndex, False, "")
                ElseIf StringType.StrCmp(text, ".utw", False) = 0 Then
                    obj = New frmUTW_Editor(New clsUTW(fileStream, gfffileKotorVersionIndex), gfffileKotorVersionIndex, False, "")
                Else
                    If StringType.StrCmp(text, ".dlg", False) <> 0 Then
                        Interaction.MsgBox("There is no editor available for that file type", MsgBoxStyle.Exclamation, "Unsupported File Type")
                        Return form
                    End If
                    obj = New frmDialogEditor(fileStream, gfffileKotorVersionIndex)
                End If
                Me.ManageMRUMainFileList(filepath, False)
                CType(obj, frmParent).EditingFilePath = filepath
                LateBinding.LateCall(obj, Nothing, "Show", New Object(-1) {}, Nothing, Nothing)
                If formLocationOffset <> -1 Then
                    Dim control As Control = CType(obj, Control)
                    Dim point As Point = New Point(CType(obj, Control).Location.X + formLocationOffset, CType(obj, Control).Location.Y + formLocationOffset)
                    control.Location = point
                End If
                Return CType(obj, Form)
            End If
            Return form
        End Function

        ' Token: 0x0600071B RID: 1819 RVA: 0x002537F0 File Offset: 0x002527F0
        Private Sub Open2DAFileEditor()
            Dim frm2DAEditor As frm2DAEditor = New frm2DAEditor()
            frm2DAEditor.Show()
        End Sub

        ' Token: 0x0600071C RID: 1820 RVA: 0x0025380C File Offset: 0x0025280C
        Private Sub OpenTextEditor()
            Dim frmTextEditor As frmTextEditor = New frmTextEditor()
            frmTextEditor.Show()
        End Sub

        ' Token: 0x0600071D RID: 1821 RVA: 0x00253828 File Offset: 0x00252828
        Private Sub OpenERFBuilder()
            Dim frmERFManager As frmERFManager = New frmERFManager()
            frmERFManager.Show()
        End Sub

        ' Token: 0x0600071E RID: 1822 RVA: 0x00253844 File Offset: 0x00252844
        Private Sub OpenConversationEditor()
            Dim frmDialogEditor As frmDialogEditor = New frmDialogEditor()
            frmDialogEditor.SetupForNewDialog()
            frmDialogEditor.Show()
        End Sub

        ' Token: 0x0600071F RID: 1823 RVA: 0x00253864 File Offset: 0x00252864
        Private Sub ManageMRUMainFileList(ByVal filepath As String, Optional ByVal delete As Boolean = False)
            frmMain.CurrentSettings = UserSettings.GetSettings()
            Dim num As Integer = frmMain.CurrentSettings.MRUMainFiles.IndexOf(filepath)
            If Not delete Then
                If num = -1 Then
                    frmMain.CurrentSettings.MRUMainFiles.Insert(0, filepath)
                    If frmMain.CurrentSettings.MRUMainFiles.Count > 10 Then
                        While frmMain.CurrentSettings.MRUMainFiles.Count > 10
                            ' The following expression was wrapped in a checked-expression
                            frmMain.CurrentSettings.MRUMainFiles.RemoveAt(frmMain.CurrentSettings.MRUMainFiles.Count - 1)
                        End While
                    End If
                Else
                    frmMain.CurrentSettings.MRUMainFiles.RemoveAt(num)
                    frmMain.CurrentSettings.MRUMainFiles.Insert(0, filepath)
                End If
            ElseIf num <> -1 Then
                frmMain.CurrentSettings.MRUMainFiles.RemoveAt(num)
            End If
            Me.ManageMRUMainFileMenu()
            UserSettings.SaveSettings(frmMain.CurrentSettings)
        End Sub

        ' Token: 0x06000720 RID: 1824 RVA: 0x00253938 File Offset: 0x00252938
        Private Sub ManageMRUMainFileMenu()
            Dim miRecentFiles As MenuItem = Me.miRecentFiles
            miRecentFiles.MenuItems.Clear()
            Try
                For Each obj As Object In frmMain.CurrentSettings.MRUMainFiles
                    Dim text As String = StringType.FromObject(obj)
                    Dim menuItem As MenuItem = New MenuItem(Path.GetFileName(text), AddressOf Me.miRecentFiles_Click)
                    miRecentFiles.MenuItems.Add(menuItem)
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000721 RID: 1825 RVA: 0x002539CC File Offset: 0x002529CC
        Public Shared Sub CleanDirectory(ByVal dirname As String)
            Dim directoryInfo As DirectoryInfo = New DirectoryInfo(dirname)
            Dim num As Integer
            Try
                Dim directories As FileSystemInfo() = directoryInfo.GetDirectories()
                Console.WriteLine("Number of directories: {0}", directories.Length)
                For Each directoryInfo2 As DirectoryInfo In directories
                    For Each fileSystemInfo As FileSystemInfo In directoryInfo2.GetFileSystemInfos()
                        Select Case num
                            Case 0
                                Cursor.Current = Cursors.PanNorth
                            Case 1
                                Cursor.Current = Cursors.PanNE
                            Case 2
                                Cursor.Current = Cursors.PanEast
                            Case 3
                                Cursor.Current = Cursors.PanSE
                            Case 4
                                Cursor.Current = Cursors.PanSouth
                            Case 5
                                Cursor.Current = Cursors.PanSW
                            Case 6
                                Cursor.Current = Cursors.PanWest
                            Case 7
                                Cursor.Current = Cursors.PanNW
                                num = -1
                        End Select
                        num += 1
                        File.Delete(fileSystemInfo.FullName)
                    Next
                    Directory.Delete(directoryInfo2.FullName)
                Next
            Catch ex As System.Exception
                Console.WriteLine("The process failed: {0}", ex.ToString())
            End Try
            Try
                Dim files As FileInfo() = directoryInfo.GetFiles()
                For Each fileInfo As FileInfo In files
                    Select Case num
                        Case 0
                            Cursor.Current = Cursors.PanNorth
                        Case 1
                            Cursor.Current = Cursors.PanNE
                        Case 2
                            Cursor.Current = Cursors.PanEast
                        Case 3
                            Cursor.Current = Cursors.PanSE
                        Case 4
                            Cursor.Current = Cursors.PanSouth
                        Case 5
                            Cursor.Current = Cursors.PanSW
                        Case 6
                            Cursor.Current = Cursors.PanWest
                        Case 7
                            Cursor.Current = Cursors.PanNW
                            num = -1
                    End Select
                    num += 1
                    File.Delete(fileInfo.FullName)
                Next
            Catch ex2 As System.Exception
                Console.WriteLine("The process failed: {0}", ex2.ToString())
            End Try
        End Sub

        ' Token: 0x06000722 RID: 1826 RVA: 0x00253C30 File Offset: 0x00252C30
        Public Shared Sub OpenTreeViewToPath(ByVal treepath As String, ByVal currNode As TreeNode, ByVal currLevel As Integer, Optional ByVal SelectAfterExpand As Boolean = True)
            Dim array As String() = treepath.Split(New Char() {"\"c})
            If currLevel = array.Length Then
                Return
            End If
            If currLevel = 0 Then
                Try
                    For Each obj As Object In currNode.TreeView.Nodes
                        Dim treeNode As TreeNode = CType(obj, TreeNode)
                        If StringType.StrCmp(treeNode.Text, array(currLevel), False) = 0 Then
                            treeNode.Expand()
                            If SelectAfterExpand Then
                                treeNode.TreeView.SelectedNode = treeNode
                            End If
                            frmMain.OpenTreeViewToPath(treepath, treeNode, currLevel + 1, SelectAfterExpand)
                        End If
                    Next
                    Return
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            Try
                For Each obj2 As Object In currNode.Nodes
                    Dim treeNode2 As TreeNode = CType(obj2, TreeNode)
                    If StringType.StrCmp(frmMain.TrimAfterDash(treeNode2.Text), frmMain.TrimAfterDash(array(currLevel)), False) = 0 Then
                        treeNode2.Expand()
                        treeNode2.TreeView.SelectedNode = treeNode2
                        frmMain.OpenTreeViewToPath(treepath, treeNode2, currLevel + 1, SelectAfterExpand)
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                If TypeOf enumerator2 Is IDisposable Then
                    CType(enumerator2, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000723 RID: 1827 RVA: 0x00253D68 File Offset: 0x00252D68
        Public Shared Function TrimAfterDash(ByVal s As String) As String
            If s.IndexOf("-") = -1 Then
                Return s
            End If
            Return s.Substring(0, s.IndexOf("-") - 1)
        End Function

        ' Token: 0x06000724 RID: 1828 RVA: 0x00253D9C File Offset: 0x00252D9C
        Private Sub CheckForUpdateA()
            Dim text As String = Me.g_downloadURL + "version.htm"
            Try
                Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(Me.g_downloadURL + "busy.htm"), HttpWebRequest)
                Dim response As WebResponse = httpWebRequest.GetResponse()
                Console.WriteLine("Busy.htm file found; exiting.")
                Return
            Catch ex As System.Exception
                Console.WriteLine(ex.ToString())
            End Try
            Dim text2 As String
            Try
                Dim httpWebRequest2 As HttpWebRequest = CType(WebRequest.Create(text), HttpWebRequest)
                Dim response2 As WebResponse = httpWebRequest2.GetResponse()
                Console.WriteLine("Response received.")
                Dim streamReader As StreamReader = New StreamReader(response2.GetResponseStream())
                text2 = streamReader.ReadToEnd()
                streamReader.Close()
            Catch ex2 As System.Exception
                Console.WriteLine(ex2.ToString())
                Interaction.MsgBox("Could not retrieve information on the latest version of Kotor Tool." & vbLf & "Error: " + ex2.Message, MsgBoxStyle.Critical, "Error")
                Return
            End Try
            Dim text3 As String = "<title>(?<match>.*?)</title>"
            Dim regex As Regex = New Regex(text3, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            Dim match As Match = regex.Match(text2)
            Dim text4 As String = "<version>(?<match>.*?)</version>"
            Dim regex2 As Regex = New Regex(text4, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            Dim match2 As Match = regex2.Match(text2)
            Dim text5 As String = "<filename>(?<match>.*?)</filename>"
            Dim regex3 As Regex = New Regex(text5, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            Dim match3 As Match = regex3.Match(text2)
            Dim text6 As String = "<comments>(?<match>.*?)</comments>"
            Dim regex4 As Regex = New Regex(text6, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            Dim match4 As Match = regex4.Match(text2)
            If match.Success Then
                Console.WriteLine("Found title: " + match.Groups("match").Value)
            End If
            Dim value As String
            If match2.Success Then
                value = match2.Groups("match").Value
                Console.WriteLine("Found version: " + value)
            End If
            Dim value2 As String
            Dim text7 As String
            If match3.Success Then
                Console.WriteLine("Found file name: " + match3.Groups("match").Value)
                value2 = match3.Groups("match").Value
                text7 = value2.Split(New Char() {"/"c})(value2.Split(New Char() {"/"c}).GetUpperBound(0))
            End If
            Dim text8 As String = "<signature>(?<match>.*?)</signature>"
            Dim regex5 As Regex = New Regex(text8, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            Dim text9 As String = match4.Groups("match").Value
            If StringType.StrCmp(text9, "", False) <> 0 Then
                text9 = vbLf & "Notes:" & vbLf + text9
            End If
            Dim match5 As Match = regex5.Match(text2)
            Dim text10 As String = Application.ProductVersion.ToString()
            If StringType.StrCmp(text10, value, False) < 0 Then
                If frmMain.CurrentSettings.bDownloadUpdatesAutomatically OrElse Interaction.MsgBox("A newer version of Kotor Tool is available. Would you like to download it?" + text9, MsgBoxStyle.YesNo, "Update Available") = MsgBoxResult.Yes Then
                    Me.g_downloadfile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
                    Me.g_downloadfile = Me.g_downloadfile + "\" + text7
                    Dim downloadUpdate As frmMain.DownloadUpdate = AddressOf Me.DownloadUpdateA
                    Console.WriteLine("Update found, starting download thread")
                    downloadUpdate.BeginInvoke(value2, Me.g_downloadfile, match5.Groups("match").Value, value, Nothing, Nothing)
                End If
            Else
                If Not Me.g_CheckForUpdatesSilently Then
                    Interaction.MsgBox("No newer version of Kotor Tool is available", MsgBoxStyle.Information, "Info")
                End If
                Console.WriteLine("No update found, exiting version check thread")
            End If
        End Sub

        ' Token: 0x06000725 RID: 1829 RVA: 0x00254110 File Offset: 0x00253110
        Private Sub DownloadUpdateA(ByVal URL As String, ByVal filePath As String, ByVal signature As String, ByVal onlineVersion As String)
            Try
                Dim webClient As WebClient = New WebClient()
                webClient.DownloadFile(URL, filePath)
                webClient.Dispose()
                Console.WriteLine("Downloading complete. Validating...")
                If Me.ValidateFile(filePath, signature) Then
                    Try
                        If File.Exists(Path.GetDirectoryName(filePath) + "\Kotor Tool Setup v" + onlineVersion + ".exe") Then
                            File.Delete(Path.GetDirectoryName(filePath) + "\Kotor Tool Setup v" + onlineVersion + ".exe")
                        End If
                        File.Move(filePath, Path.GetDirectoryName(filePath) + "\Kotor Tool Setup v" + onlineVersion + ".exe")
                    Catch ex As System.Exception
                        Console.WriteLine(ex.ToString())
                    End Try
                    If Interaction.MsgBox("A new version of Kotor Tool has been downloaded. Would you like to install it now?", MsgBoxStyle.YesNo, "Install now?") = MsgBoxResult.Yes Then
                        Dim processStartInfo As ProcessStartInfo = New ProcessStartInfo(Path.GetDirectoryName(filePath) + "\Kotor Tool Setup v" + onlineVersion + ".exe")
                        Process.Start(processStartInfo)
                        Environment.[Exit](0)
                    Else
                        Interaction.MsgBox("You can install the update later by running the setup program at:" & vbLf + filePath, MsgBoxStyle.Information, "Info")
                    End If
                Else
                    Interaction.MsgBox("Downloaded file did not validate against online version. You may want to try downloading manually.", MsgBoxStyle.Exclamation, "Download Validation Error")
                End If
            Catch ex2 As WebException
                Dim ex3 As WebException = CType(ex2, WebException)
                Console.WriteLine(ex3.ToString())
            End Try
        End Sub

        ' Token: 0x06000726 RID: 1830 RVA: 0x0025427C File Offset: 0x0025327C
        Private Function ValidateFile(ByVal filePath As String, ByVal signature As String) As Boolean
            Dim utilFileValidator As utilFileValidator = New utilFileValidator()
            utilFileValidator.Init(utilFileValidator.GenerateBase64Key("Test String"))
            Return utilFileValidator.Validate(filePath, signature)
        End Function

        Private Sub InitialiseResourceBrowser()
            If Me.cmbViewMode Is Nothing OrElse Me.lvResourceBrowser Is Nothing Then
                Return
            End If

            Me.cmbViewMode.Items.Clear()
            Me.cmbViewMode.Items.Add("Tree")
            Me.cmbViewMode.Items.Add("List")
            Me.cmbViewMode.Items.Add("Small Icons")
            Me.cmbViewMode.Items.Add("Large Icons")
            Me.cmbViewMode.Items.Add("Tiles")
            Me.cmbViewMode.Items.Add("Thumbnail Placeholders")
            Me.cmbViewMode.SelectedIndex = 0

            Me.lvResourceBrowser.Columns.Clear()
            Me.lvResourceBrowser.Columns.Add("Name", 220, HorizontalAlignment.Left)
            Me.lvResourceBrowser.Columns.Add("Type", 70, HorizontalAlignment.Left)
            Me.lvResourceBrowser.Columns.Add("Source", 110, HorizontalAlignment.Left)
            Me.lvResourceBrowser.MultiSelect = False
            Me.lvResourceBrowser.FullRowSelect = True
            Me.lvResourceBrowser.HideSelection = False
            Me.lvResourceBrowser.ShowItemToolTips = True
            Me.lvResourceBrowser.Padding = New Padding(8)

            If Me.lvResourceDetails IsNot Nothing Then
                Me.lvResourceDetails.Columns.Clear()
                Me.lvResourceDetails.Columns.Add("Name", 260, HorizontalAlignment.Left)
                Me.lvResourceDetails.Columns.Add("Type", 70, HorizontalAlignment.Left)
                Me.lvResourceDetails.Columns.Add("Source", 120, HorizontalAlignment.Left)
                Me.lvResourceDetails.MultiSelect = False
                Me.lvResourceDetails.FullRowSelect = True
                Me.lvResourceDetails.HideSelection = False
                Me.lvResourceDetails.ShowItemToolTips = True
                Me.lvResourceDetails.View = View.Details
            End If

            RemoveHandler Me.cmbViewMode.SelectedIndexChanged, AddressOf Me.cmbViewMode_SelectedIndexChanged
            AddHandler Me.cmbViewMode.SelectedIndexChanged, AddressOf Me.cmbViewMode_SelectedIndexChanged
            RemoveHandler Me.txtResourceFilter.TextChanged, AddressOf Me.txtResourceFilter_TextChanged
            AddHandler Me.txtResourceFilter.TextChanged, AddressOf Me.txtResourceFilter_TextChanged
            RemoveHandler Me.lvResourceBrowser.DoubleClick, AddressOf Me.lvResourceBrowser_DoubleClick
            AddHandler Me.lvResourceBrowser.DoubleClick, AddressOf Me.lvResourceBrowser_DoubleClick
            RemoveHandler Me.lvResourceBrowser.KeyDown, AddressOf Me.lvResourceBrowser_KeyDown
            AddHandler Me.lvResourceBrowser.KeyDown, AddressOf Me.lvResourceBrowser_KeyDown
            If Me.lvResourceDetails IsNot Nothing Then
                RemoveHandler Me.lvResourceDetails.DoubleClick, AddressOf Me.lvResourceDetails_DoubleClick
                AddHandler Me.lvResourceDetails.DoubleClick, AddressOf Me.lvResourceDetails_DoubleClick
                RemoveHandler Me.lvResourceDetails.KeyDown, AddressOf Me.lvResourceDetails_KeyDown
                AddHandler Me.lvResourceDetails.KeyDown, AddressOf Me.lvResourceDetails_KeyDown
            End If
            RemoveHandler Me.btnViewBack.Click, AddressOf Me.btnViewBack_Click
            AddHandler Me.btnViewBack.Click, AddressOf Me.btnViewBack_Click
            RemoveHandler Me.btnViewForward.Click, AddressOf Me.btnViewForward_Click
            AddHandler Me.btnViewForward.Click, AddressOf Me.btnViewForward_Click

            Me.ResourceViewHistory = New ArrayList()
            Me.ResourceViewHistoryIndex = -1
            Me.SuppressResourceViewHistory = False
            Me.EnsureResourceBrowserImageLists()
            Me.SetMainResourceViewMode("Tree")
            Me.ApplyResourceBrowserTheme()
        End Sub

        Private Sub ApplyResourceBrowserTheme()
            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            If Me.pnlBrowserContainer IsNot Nothing Then
                Me.pnlBrowserContainer.BackColor = _theme.LogoBack
            End If

            If Me.pnlResourceArea IsNot Nothing Then
                Me.pnlResourceArea.BackColor = _theme.PanelBody
            End If

            If Me.pnlBrowserBody IsNot Nothing Then
                Me.pnlBrowserBody.BackColor = _theme.LogoBack
            End If

            If Me.pnlViewHeader IsNot Nothing Then
                Me.pnlViewHeader.BackColor = _theme.PanelHeader
            End If

            If Me.lblViewTitle IsNot Nothing Then
                Me.lblViewTitle.ForeColor = _theme.AccentGoldLight
                Me.lblViewTitle.BorderStyle = BorderStyle.None
                Me.lblViewTitle.TextAlign = ContentAlignment.MiddleLeft
            End If

            If Me.lblResourceCount IsNot Nothing Then
                Me.lblResourceCount.ForeColor = _theme.TextMuted
            End If

            If Me.txtResourceFilter IsNot Nothing Then
                Me.txtResourceFilter.BackColor = _theme.LogoBack
                Me.txtResourceFilter.ForeColor = _theme.TextPrimary
                Try
                    Me.txtResourceFilter.Font = _theme.CreateBodyFont()
                Catch
                    Me.txtResourceFilter.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
                End Try
            End If

            If Me.cmbViewMode IsNot Nothing Then
                Me.cmbViewMode.BackColor = _theme.ControlDark
                Me.cmbViewMode.ForeColor = _theme.TextPrimary
                Try
                    Me.cmbViewMode.Font = _theme.CreateBodyFont()
                Catch
                    Me.cmbViewMode.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
                End Try
            End If

            If Me.lvResourceBrowser IsNot Nothing Then
                Me.lvResourceBrowser.BackColor = _theme.LogoBack
                Me.lvResourceBrowser.ForeColor = _theme.TextPrimary
                Try
                    Me.lvResourceBrowser.Font = _theme.CreateBodyFont()
                Catch
                    Me.lvResourceBrowser.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
                End Try
            End If

            If Me.pnlResourceDetails IsNot Nothing Then
                Me.pnlResourceDetails.BackColor = _theme.LogoBack
                Me.pnlResourceDetails.Visible = True
            End If

            If Me.lvResourceDetails IsNot Nothing Then
                Me.lvResourceDetails.BackColor = _theme.LogoBack
                Me.lvResourceDetails.ForeColor = _theme.TextPrimary
                Try
                    Me.lvResourceDetails.Font = _theme.CreateBodyFont()
                Catch
                    Me.lvResourceDetails.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
                End Try
            End If

            Me.ApplyNavigationButtonTheme(Me.btnViewBack)
            Me.ApplyNavigationButtonTheme(Me.btnViewForward)
            Me.InvalidateResourceBrowserIconsIfThemeChanged()
        End Sub

        Private Sub SetMainResourceViewMode(ByVal viewMode As String)
            If Me.TreeView Is Nothing OrElse Me.lvResourceBrowser Is Nothing Then
                Return
            End If

            Dim requestedMode As String = viewMode
            If requestedMode Is Nothing OrElse requestedMode.Length = 0 Then
                requestedMode = "Tree"
            End If

            Me.SelectResourceViewModeCombo(requestedMode)
            If Me.pnlResourceDetails IsNot Nothing Then
                Me.pnlResourceDetails.Visible = True
            End If

            If StringType.StrCmp(requestedMode, "Tree", False) = 0 Then
                Me.ClearResourceBrowserHistory()
                Me.TreeView.Dock = DockStyle.Fill
                Me.TreeView.Visible = True
                Me.TreeView.BringToFront()
                Me.lvResourceBrowser.Visible = False
                If Me.lblResourceCount IsNot Nothing Then
                    Me.lblResourceCount.Text = ""
                End If
                Return
            End If

            If (Me.ResourceViewHistory Is Nothing OrElse Me.ResourceViewHistory.Count = 0) AndAlso TypeOf Me.TreeView.SelectedNode Is KotorTreeNode Then
                Me.ResetResourceBrowserHistory(CType(Me.TreeView.SelectedNode, KotorTreeNode))
            End If

            Me.lvResourceBrowser.Visible = True

            If Not Object.ReferenceEquals(Me.lvResourceBrowser.Parent, Me.pnlBrowserBody) Then
                Me.lvResourceBrowser.Parent.Controls.Remove(Me.lvResourceBrowser)
                Me.pnlBrowserBody.Controls.Add(Me.lvResourceBrowser)
            End If

            Me.TreeView.Visible = False
            Me.lvResourceBrowser.Dock = DockStyle.Fill
            Me.lvResourceBrowser.BringToFront()

            If StringType.StrCmp(requestedMode, "List", False) = 0 Then
                Me.lvResourceBrowser.View = View.List
            ElseIf StringType.StrCmp(requestedMode, "Small Icons", False) = 0 Then
                Me.lvResourceBrowser.View = View.SmallIcon
            ElseIf StringType.StrCmp(requestedMode, "Large Icons", False) = 0 Then
                Me.lvResourceBrowser.View = View.LargeIcon
            ElseIf StringType.StrCmp(requestedMode, "Tiles", False) = 0 Then
                Me.lvResourceBrowser.View = View.Tile
                Me.lvResourceBrowser.TileSize = New Size(180, 72)
            ElseIf StringType.StrCmp(requestedMode, "Thumbnail Placeholders", False) = 0 Then
                Me.lvResourceBrowser.View = View.LargeIcon
            Else
                Me.lvResourceBrowser.View = View.List
            End If

            Me.EnsureResourceBrowserImageLists()

            If TypeOf Me.TreeView.SelectedNode Is KotorTreeNode Then
                Me.PopulateResourceBrowserFromNode(CType(Me.TreeView.SelectedNode, KotorTreeNode))
            End If
        End Sub

        Private Sub PopulateResourceBrowserFromNode(ByVal sourceNode As KotorTreeNode)
            If Me.lvResourceBrowser Is Nothing Then
                Return
            End If

            Me.lvResourceBrowser.BeginUpdate()
            Me.lvResourceBrowser.Items.Clear()
            If Me.lvResourceDetails IsNot Nothing Then
                Me.lvResourceDetails.BeginUpdate()
                Me.lvResourceDetails.Items.Clear()
            End If

            Dim itemCount As Integer = 0
            Dim filterText As String = ""
            If Me.txtResourceFilter IsNot Nothing AndAlso Me.txtResourceFilter.Text IsNot Nothing Then
                filterText = Me.txtResourceFilter.Text.Trim().ToLower()
            End If

            If sourceNode IsNot Nothing Then
                For Each obj As Object In sourceNode.Nodes
                    If TypeOf obj Is KotorTreeNode Then
                        Dim childNode As KotorTreeNode = CType(obj, KotorTreeNode)
                        Dim itemText As String = childNode.Text

                        If filterText.Length = 0 OrElse itemText.ToLower().IndexOf(filterText) >= 0 Then
                            Dim typeText As String = Me.GetShortResourceTypeText(childNode)
                            Dim iconKey As String = Me.GetResourceIconKey(childNode)
                            Dim sourceText As String = ""

                            If childNode.Tag IsNot Nothing Then
                                sourceText = childNode.Tag.ToString()
                            End If

                            Me.EnsureResourceBrowserIcon(iconKey, typeText, Me.IsFolderStyleResourceNode(childNode))

                            Dim item As ListViewItem = New ListViewItem(itemText)
                            item.Tag = childNode
                            item.ImageKey = iconKey
                            item.ToolTipText = childNode.FullPath
                            item.SubItems.Add(typeText)
                            item.SubItems.Add(sourceText)
                            Me.lvResourceBrowser.Items.Add(item)

                            If Me.lvResourceDetails IsNot Nothing Then
                                Dim detailsItem As ListViewItem = New ListViewItem(itemText)
                                detailsItem.Tag = childNode
                                detailsItem.ImageKey = iconKey
                                detailsItem.ToolTipText = childNode.FullPath
                                detailsItem.SubItems.Add(typeText)
                                detailsItem.SubItems.Add(sourceText)
                                Me.lvResourceDetails.Items.Add(detailsItem)
                            End If

                            itemCount += 1
                        End If
                    End If
                Next
            End If

            If Me.lblResourceCount IsNot Nothing Then
                If itemCount = 1 Then
                    Me.lblResourceCount.Text = "1 item"
                Else
                    Me.lblResourceCount.Text = itemCount.ToString() & " items"
                End If
            End If

            Me.lvResourceBrowser.EndUpdate()
            If Me.lvResourceDetails IsNot Nothing Then
                Me.lvResourceDetails.EndUpdate()
            End If
        End Sub

        Private Function GetResourceIconKey(ByVal node As KotorTreeNode) As String
            If node Is Nothing Then
                Return "folder"
            End If

            Dim typeText As String = Me.GetShortResourceTypeText(node).ToLower()
            If typeText.Length = 0 Then
                typeText = "res"
            End If

            If Me.IsFolderStyleResourceNode(node) Then
                Return "folder_" & typeText
            End If

            Return "doc_" & typeText
        End Function

        Private Sub EnsureResourceBrowserImageLists()
            If Me.imgResourceSmall Is Nothing OrElse Me.imgResourceLarge Is Nothing Then
                Return
            End If

            Me.InvalidateResourceBrowserIconsIfThemeChanged()

            Dim desiredLargeSize As Size = New Size(48, 48)
            Dim selectedMode As String = ""

            If Me.cmbViewMode IsNot Nothing AndAlso Me.cmbViewMode.SelectedItem IsNot Nothing Then
                selectedMode = Me.cmbViewMode.SelectedItem.ToString()
            End If

            If StringType.StrCmp(selectedMode, "Tiles", False) = 0 Then
                desiredLargeSize = New Size(64, 64)
            ElseIf StringType.StrCmp(selectedMode, "Thumbnail Placeholders", False) = 0 Then
                desiredLargeSize = New Size(96, 64)
            End If

            If Not Me.imgResourceSmall.ImageSize.Equals(New Size(16, 16)) Then
                Me.imgResourceSmall.Images.Clear()
                Me.imgResourceSmall.ImageSize = New Size(16, 16)
                Me.imgResourceSmall.ColorDepth = ColorDepth.Depth32Bit
            End If

            If Not Me.imgResourceLarge.ImageSize.Equals(desiredLargeSize) Then
                Me.imgResourceLarge.Images.Clear()
                Me.imgResourceLarge.ImageSize = desiredLargeSize
                Me.imgResourceLarge.ColorDepth = ColorDepth.Depth32Bit
            End If

            If Me.lvResourceBrowser IsNot Nothing Then
                Me.lvResourceBrowser.SmallImageList = Me.imgResourceSmall
                Me.lvResourceBrowser.LargeImageList = Me.imgResourceLarge
            End If
            If Me.lvResourceDetails IsNot Nothing Then
                Me.lvResourceDetails.SmallImageList = Me.imgResourceSmall
                Me.lvResourceDetails.LargeImageList = Me.imgResourceLarge
            End If
        End Sub

        Private Function CreatePlaceholderIcon(ByVal width As Integer, ByVal height As Integer, ByVal labelText As String, ByVal folderStyle As Boolean) As Bitmap
            Dim bitmap As Bitmap = New Bitmap(width, height)
            Dim g As Graphics = Graphics.FromImage(bitmap)

            Try
                g.Clear(Color.Transparent)
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

                Dim backColor As Color = Color.FromArgb(46, 55, 66)
                Dim borderColor As Color = Color.FromArgb(174, 136, 58)
                Dim textColor As Color = Color.FromArgb(238, 238, 230)
                Dim accentColor As Color = Color.FromArgb(210, 184, 112)

                If _theme IsNot Nothing Then
                    backColor = _theme.ControlDark
                    borderColor = _theme.AccentGold
                    textColor = _theme.TextPrimary
                    accentColor = _theme.AccentGoldLight
                End If

                If labelText Is Nothing OrElse labelText.Length = 0 Then
                    labelText = "RES"
                End If

                If folderStyle Then
                    Dim tabHeight As Integer = Math.Max(4, height \ 5)
                    Dim tabWidth As Integer = Math.Max(10, width \ 2)
                    Dim folderTop As Integer = Math.Max(2, height \ 5)
                    Dim tabRect As Rectangle = New Rectangle(2, folderTop - tabHeight + 1, tabWidth, tabHeight + 2)
                    Dim bodyRect As Rectangle = New Rectangle(2, folderTop, width - 4, height - folderTop - 3)
                    Dim accentBrush As SolidBrush = New SolidBrush(accentColor)
                    Dim backBrush As SolidBrush = New SolidBrush(backColor)
                    Dim borderPen As Pen = New Pen(borderColor)
                    g.FillRectangle(accentBrush, tabRect)
                    g.FillRectangle(backBrush, bodyRect)
                    g.DrawRectangle(borderPen, tabRect)
                    g.DrawRectangle(borderPen, bodyRect)
                    accentBrush.Dispose()
                    backBrush.Dispose()
                    borderPen.Dispose()
                Else
                    Dim docRect As Rectangle = New Rectangle(3, 2, width - 6, height - 5)
                    Dim backBrush As SolidBrush = New SolidBrush(backColor)
                    Dim accentBrush As SolidBrush = New SolidBrush(accentColor)
                    Dim borderPen As Pen = New Pen(borderColor)
                    g.FillRectangle(backBrush, docRect)
                    g.DrawRectangle(borderPen, docRect)
                    If width >= 32 AndAlso height >= 32 Then
                        Dim foldSize As Integer = Math.Min(12, Math.Min(width, height) \ 4)
                        Dim points As Point() = New Point() {New Point(docRect.Right - foldSize, docRect.Top), New Point(docRect.Right, docRect.Top + foldSize), New Point(docRect.Right - foldSize, docRect.Top + foldSize)}
                        g.FillPolygon(accentBrush, points)
                        g.DrawPolygon(borderPen, points)
                    End If
                    backBrush.Dispose()
                    accentBrush.Dispose()
                    borderPen.Dispose()
                End If

                Dim fontSize As Single = 7.0F
                If width >= 48 Then
                    fontSize = 9.0F
                End If
                If width >= 90 Then
                    fontSize = 10.0F
                End If

                Dim fontName As String = "Segoe UI"
                If _theme IsNot Nothing AndAlso _theme.BodyFontName IsNot Nothing AndAlso _theme.BodyFontName.Length > 0 Then
                    fontName = _theme.BodyFontName
                End If

                Dim labelFont As Font = New Font(fontName, fontSize, FontStyle.Bold, GraphicsUnit.Point)
                Dim textRect As Rectangle = New Rectangle(1, 1, width - 2, height - 2)
                TextRenderer.DrawText(g, labelText.ToUpper(), labelFont, textRect, textColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.EndEllipsis)
                labelFont.Dispose()

            Finally
                g.Dispose()
            End Try

            Return bitmap
        End Function

        Private Sub EnsureResourceBrowserIcon(ByVal iconKey As String, ByVal labelText As String, ByVal folderStyle As Boolean)
            If iconKey Is Nothing OrElse iconKey.Length = 0 Then
                Return
            End If

            Me.EnsureResourceBrowserImageLists()

            If Not Me.imgResourceSmall.Images.ContainsKey(iconKey) Then
                Me.imgResourceSmall.Images.Add(iconKey, Me.CreatePlaceholderIcon(16, 16, labelText, folderStyle))
            End If

            If Not Me.imgResourceLarge.Images.ContainsKey(iconKey) Then
                Me.imgResourceLarge.Images.Add(iconKey, Me.CreatePlaceholderIcon(Me.imgResourceLarge.ImageSize.Width, Me.imgResourceLarge.ImageSize.Height, labelText, folderStyle))
            End If
        End Sub

        Private Sub InvalidateResourceBrowserIconsIfThemeChanged()
            If Me.imgResourceSmall Is Nothing OrElse Me.imgResourceLarge Is Nothing Then
                Return
            End If

            Dim signature As String = Me.GetResourceBrowserThemeSignature()

            If Me.ResourceBrowserIconThemeSignature IsNot Nothing AndAlso
               StringType.StrCmp(Me.ResourceBrowserIconThemeSignature, signature, False) = 0 Then
                Return
            End If

            Me.ResourceBrowserIconThemeSignature = signature
            Me.imgResourceSmall.Images.Clear()
            Me.imgResourceLarge.Images.Clear()
        End Sub

        Private Function GetResourceBrowserThemeSignature() As String
            If _theme Is Nothing Then
                Return "default"
            End If

            Return _theme.Name & "|" &
                   _theme.ControlDark.ToArgb().ToString() & "|" &
                   _theme.AccentGold.ToArgb().ToString() & "|" &
                   _theme.AccentGoldLight.ToArgb().ToString() & "|" &
                   _theme.TextPrimary.ToArgb().ToString() & "|" &
                   _theme.BodyFontName
        End Function

        Private Function GetShortResourceTypeText(ByVal node As KotorTreeNode) As String
            If node Is Nothing Then
                Return "DIR"
            End If

            If Me.IsFolderStyleResourceNode(node) Then
                If node.Tag IsNot Nothing Then
                    Dim tagText As String = node.Tag.ToString().ToUpper()
                    If tagText.IndexOf("RIM") >= 0 Then
                        Return "RIM"
                    End If
                    If tagText.IndexOf("ERF") >= 0 Then
                        Return "ERF"
                    End If
                    If tagText.IndexOf("BIFF") >= 0 OrElse tagText.IndexOf("BIF") >= 0 Then
                        Return "BIF"
                    End If
                End If
                Return "DIR"
            End If

            Dim typeText As String = ""
            Try
                typeText = node.ResTypeStr
            Catch
                typeText = ""
            End Try

            If typeText Is Nothing OrElse typeText.Length = 0 Then
                typeText = Path.GetExtension(node.Filename)
                If typeText IsNot Nothing AndAlso typeText.StartsWith(".") Then
                    typeText = typeText.Substring(1)
                End If
            End If

            If typeText Is Nothing OrElse typeText.Length = 0 Then
                typeText = "RES"
            End If

            typeText = typeText.ToUpper()
            If typeText.Length > 4 Then
                typeText = typeText.Substring(0, 4)
            End If

            Return typeText
        End Function

        Private Function IsFolderStyleResourceNode(ByVal node As KotorTreeNode) As Boolean
            If node Is Nothing Then
                Return True
            End If

            If node.Tag Is Nothing Then
                Return node.Nodes.Count > 0
            End If

            Dim tagText As String = node.Tag.ToString()
            If ObjectType.ObjTst(tagText, "BIFF_Res", False) = 0 OrElse
               ObjectType.ObjTst(tagText, "RIM_Res", False) = 0 OrElse
               ObjectType.ObjTst(tagText, "ERF_Res", False) = 0 Then
                Return False
            End If

            Return True
        End Function

        Private Sub OpenSelectedResourceBrowserItem()
            Me.OpenSelectedResourceListItem(Me.lvResourceBrowser)
        End Sub

        Private Sub OpenSelectedResourceDetailsItem()
            Me.OpenSelectedResourceListItem(Me.lvResourceDetails)
        End Sub

        Private Sub OpenSelectedResourceListItem(ByVal listView As ListView)
            If listView Is Nothing OrElse listView.SelectedItems.Count = 0 Then
                Return
            End If

            Dim item As ListViewItem = listView.SelectedItems(0)
            If item Is Nothing OrElse Not TypeOf item.Tag Is KotorTreeNode Then
                Return
            End If

            Dim node As KotorTreeNode = CType(item.Tag, KotorTreeNode)

            If Not Me.IsTreeResourceViewMode() AndAlso Me.IsFolderStyleResourceNode(node) Then
                Me.NavigateResourceBrowserToNode(node, True)
            Else
                Me.TreeView.SelectedNode = node
                Me.HandleDataByNodeType(node, listView)
            End If
        End Sub

        Private Sub cmbViewMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.cmbViewMode Is Nothing OrElse Me.cmbViewMode.SelectedItem Is Nothing Then
                Me.SetMainResourceViewMode("Tree")
            Else
                Me.SetMainResourceViewMode(Me.cmbViewMode.SelectedItem.ToString())
            End If
        End Sub

        Private Sub btnViewBack_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.ResourceViewHistory Is Nothing OrElse Me.ResourceViewHistoryIndex <= 0 Then
                Return
            End If

            Me.ResourceViewHistoryIndex -= 1
            Me.NavigateResourceBrowserToNode(CType(Me.ResourceViewHistory(Me.ResourceViewHistoryIndex), KotorTreeNode), False)
            Me.UpdateResourceViewNavigationButtons()
        End Sub

        Private Sub btnViewForward_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.ResourceViewHistory Is Nothing OrElse Me.ResourceViewHistoryIndex >= Me.ResourceViewHistory.Count - 1 Then
                Return
            End If

            Me.ResourceViewHistoryIndex += 1
            Me.NavigateResourceBrowserToNode(CType(Me.ResourceViewHistory(Me.ResourceViewHistoryIndex), KotorTreeNode), False)
            Me.UpdateResourceViewNavigationButtons()
        End Sub

        Private Sub ResetResourceBrowserHistory(ByVal node As KotorTreeNode)
            If Me.SuppressResourceViewHistory Then
                Return
            End If

            Me.ResourceViewHistory = New ArrayList()
            Me.ResourceViewHistoryIndex = -1

            If node IsNot Nothing Then
                Me.ResourceViewHistory.Add(node)
                Me.ResourceViewHistoryIndex = 0
            End If

            Me.UpdateResourceViewNavigationButtons()
        End Sub

        Private Sub AddResourceViewHistory(ByVal node As KotorTreeNode)
            If Me.SuppressResourceViewHistory Then
                Return
            End If

            If node Is Nothing Then
                Return
            End If

            If Me.ResourceViewHistory Is Nothing Then
                Me.ResourceViewHistory = New ArrayList()
                Me.ResourceViewHistoryIndex = -1
            End If

            If Me.ResourceViewHistoryIndex >= 0 AndAlso
               Me.ResourceViewHistoryIndex < Me.ResourceViewHistory.Count AndAlso
               Object.ReferenceEquals(Me.ResourceViewHistory(Me.ResourceViewHistoryIndex), node) Then
                Me.UpdateResourceViewNavigationButtons()
                Return
            End If

            While Me.ResourceViewHistory.Count - 1 > Me.ResourceViewHistoryIndex
                Me.ResourceViewHistory.RemoveAt(Me.ResourceViewHistory.Count - 1)
            End While

            Me.ResourceViewHistory.Add(node)
            Me.ResourceViewHistoryIndex = Me.ResourceViewHistory.Count - 1
            Me.UpdateResourceViewNavigationButtons()
        End Sub

        Private Sub ClearResourceBrowserHistory()
            If Me.ResourceViewHistory IsNot Nothing Then
                Me.ResourceViewHistory.Clear()
            End If

            Me.ResourceViewHistoryIndex = -1
            Me.UpdateResourceViewNavigationButtons()
        End Sub

        Private Sub SelectResourceViewModeCombo(ByVal viewMode As String)
            If Me.cmbViewMode Is Nothing Then
                Return
            End If

            Dim i As Integer
            For i = 0 To Me.cmbViewMode.Items.Count - 1
                If StringType.StrCmp(Me.cmbViewMode.Items(i).ToString(), viewMode, False) = 0 Then
                    If Me.cmbViewMode.SelectedIndex <> i Then
                        Me.SuppressResourceViewHistory = True
                        Me.cmbViewMode.SelectedIndex = i
                        Me.SuppressResourceViewHistory = False
                    End If
                    Return
                End If
            Next
        End Sub

        Private Sub UpdateResourceViewNavigationButtons()
            Dim enableNavigation As Boolean = Not Me.IsTreeResourceViewMode()

            If Me.btnViewBack IsNot Nothing Then
                Me.btnViewBack.Enabled = enableNavigation AndAlso Me.ResourceViewHistory IsNot Nothing AndAlso Me.ResourceViewHistoryIndex > 0
            End If

            If Me.btnViewForward IsNot Nothing Then
                Me.btnViewForward.Enabled = enableNavigation AndAlso Me.ResourceViewHistory IsNot Nothing AndAlso Me.ResourceViewHistoryIndex < Me.ResourceViewHistory.Count - 1
            End If
        End Sub

        Private Function IsTreeResourceViewMode() As Boolean
            If Me.cmbViewMode Is Nothing OrElse Me.cmbViewMode.SelectedItem Is Nothing Then
                Return True
            End If

            Return StringType.StrCmp(Me.cmbViewMode.SelectedItem.ToString(), "Tree", False) = 0
        End Function

        Private Sub NavigateResourceBrowserToNode(ByVal node As KotorTreeNode, ByVal addToHistory As Boolean)
            If node Is Nothing Then
                Return
            End If

            Me.EnsureResourceBrowserNodeChildren(node)
            Me.TreeView.SelectedNode = node
            Me.PopulateResourceBrowserFromNode(node)

            If addToHistory Then
                Me.AddResourceViewHistory(node)
            End If
        End Sub

        Private Sub EnsureResourceBrowserNodeChildren(ByVal node As KotorTreeNode)
            If node Is Nothing OrElse node.Nodes.Count = 0 Then
                Return
            End If

            Try
                If node.Nodes.Count = 1 AndAlso node.Nodes(0).Tag IsNot Nothing AndAlso ObjectType.ObjTst(node.Nodes(0).Tag, "dummy", False) = 0 Then
                    node.Expand()
                End If
            Catch
            End Try
        End Sub

        Private Sub ApplyNavigationButtonTheme(ByVal button As Button)
            If button Is Nothing Then
                Return
            End If

            button.BackColor = _theme.ControlDark
            button.ForeColor = _theme.AccentGoldLight
            button.FlatStyle = FlatStyle.Flat
            button.UseVisualStyleBackColor = False
            button.FlatAppearance.BorderColor = _theme.BorderDark
            button.FlatAppearance.MouseOverBackColor = _theme.ControlHover
            button.FlatAppearance.MouseDownBackColor = _theme.ControlDown
            button.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold, GraphicsUnit.Point)
        End Sub

        Private Sub txtResourceFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If TypeOf Me.TreeView.SelectedNode Is KotorTreeNode Then
                Me.PopulateResourceBrowserFromNode(CType(Me.TreeView.SelectedNode, KotorTreeNode))
            Else
                Me.PopulateResourceBrowserFromNode(Nothing)
            End If
        End Sub

        Private Sub lvResourceBrowser_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenSelectedResourceBrowserItem()
        End Sub

        Private Sub lvResourceBrowser_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                Me.OpenSelectedResourceBrowserItem()
            End If
        End Sub

        Private Sub lvResourceDetails_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenSelectedResourceDetailsItem()
        End Sub

        Private Sub lvResourceDetails_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                Me.OpenSelectedResourceDetailsItem()
            End If
        End Sub


        Private Sub LoadAndApplyTheme()
            Try
                _theme = KotorThemeManager.LoadTheme(KotorThemeManager.GetActiveThemeName())
            Catch
                _theme = KotorTheme.CreateDefault()
            End Try

            ApplyMainTheme()
        End Sub

        Private Sub ApplyMainTheme()
            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            Me.BackColor = _theme.WindowBack

            If Me.pnlRoot IsNot Nothing Then
                Me.pnlRoot.BackColor = _theme.PanelRoot
            End If

            If Me.pnlMainArea IsNot Nothing Then
                Me.pnlMainArea.BackColor = _theme.PanelBody
            End If

            If Me.pnlActionPanel IsNot Nothing Then
                Me.pnlActionPanel.BackColor = _theme.PanelHeader
            End If

            If Me.lblMainSeparator IsNot Nothing Then
                Me.lblMainSeparator.BackColor = _theme.AccentGold
            End If

            If Me.lblActionHeader IsNot Nothing Then
                Me.lblActionHeader.ForeColor = _theme.AccentGoldLight
                Me.lblActionHeader.Font = New Font(_theme.BodyFontName, 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            End If

            ApplyTreeViewTheme()
            ApplyResourceBrowserTheme()
            ApplyToolBarTheme()
            ApplyButtonTheme(Me.btnExtract)
            ApplyButtonTheme(Me.btnExtractForModuleEditing)
            ApplyButtonTheme(Me.btnHexViewer)
            ApplyButtonTheme(Me.Button4)
            ApplyButtonTheme(Me.Button1)
            ApplyButtonTheme(Me.btnCreateMapInfoBFD)
        End Sub

        Private Sub ApplyTreeViewTheme()
            If Me.TreeView Is Nothing Then
                Return
            End If

            Me.TreeView.BackColor = _theme.LogoBack
            Me.TreeView.ForeColor = _theme.TextPrimary
            Me.TreeView.LineColor = _theme.BorderDark
            Me.TreeView.BorderStyle = BorderStyle.FixedSingle
            Me.TreeView.HideSelection = False

            Try
                Me.TreeView.Font = _theme.CreateBodyFont()
            Catch
                Me.TreeView.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            End Try
        End Sub

        Private Sub ApplyToolBarTheme()
            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            If Me.pnlToolBar IsNot Nothing Then
                Me.pnlToolBar.BackColor = _theme.PanelHeader
            End If

            Me.ApplyModernToolbarButtonTheme(Me.btnTool2DA)
            Me.ApplyModernToolbarButtonTheme(Me.btnToolConversation)
            Me.ApplyModernToolbarButtonTheme(Me.btnToolText)
            Me.ApplyModernToolbarButtonTheme(Me.btnToolERF)
        End Sub

        Private Sub ApplyModernToolbarButtonTheme(ByVal button As Button)
            If button Is Nothing Then
                Return
            End If

            button.BackColor = _theme.ControlDark
            button.ForeColor = _theme.TextPrimary
            button.FlatStyle = FlatStyle.Flat
            button.UseVisualStyleBackColor = False

            button.FlatAppearance.BorderColor = _theme.BorderDark
            button.FlatAppearance.MouseOverBackColor = _theme.ControlHover
            button.FlatAppearance.MouseDownBackColor = _theme.ControlDown

            button.TextAlign = ContentAlignment.MiddleCenter
            button.ImageAlign = ContentAlignment.MiddleLeft
            button.TextImageRelation = TextImageRelation.ImageBeforeText

            Try
                button.Font = New Font(_theme.BodyFontName, 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            Catch
                button.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            End Try
        End Sub



        Private Sub ApplyButtonTheme(ByVal button As Button)
            If button Is Nothing Then
                Return
            End If

            button.BackColor = _theme.ControlDark
            button.ForeColor = _theme.TextPrimary
            button.FlatStyle = FlatStyle.Flat
            button.UseVisualStyleBackColor = False

            button.FlatAppearance.BorderColor = _theme.AccentGold
            button.FlatAppearance.MouseOverBackColor = _theme.ControlHover
            button.FlatAppearance.MouseDownBackColor = _theme.ControlDown

            Try
                button.Font = _theme.CreateBodyFont()
            Catch
                button.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            End Try
        End Sub

        Private Sub RefreshTreeNodeColours()
            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            If Me.TreeView Is Nothing Then
                Return
            End If

            For Each node As TreeNode In Me.TreeView.Nodes
                ApplyTreeNodeColourRecursive(node)
            Next
        End Sub


        Private Sub ApplyTreeNodeColourRecursive(ByVal node As TreeNode)
            If node Is Nothing Then
                Return
            End If

            If Me.TreeView.Nodes.Count > 0 AndAlso Object.ReferenceEquals(node, Me.TreeView.Nodes(0)) AndAlso Not Me.hasK1 Then
                node.ForeColor = _theme.TextMuted
            ElseIf Me.TreeView.Nodes.Count > 1 AndAlso Object.ReferenceEquals(node, Me.TreeView.Nodes(1)) AndAlso Not Me.hasK2 Then
                node.ForeColor = _theme.TextMuted
            Else
                node.ForeColor = _theme.TextPrimary
            End If

            For Each child As TreeNode In node.Nodes
                ApplyTreeNodeColourRecursive(child)
            Next
        End Sub

        ' Token: 0x06000727 RID: 1831 RVA: 0x002542A8 File Offset: 0x002532A8
        ' Token: 0x06000727 RID: 1831 RVA: 0x002542A8 File Offset: 0x002532A8
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            frmMain.mainform = Me

            ' -----------------------------------------------------------------
            ' Apply runtime theme before visible setup continues.
            ' -----------------------------------------------------------------
            Me.LoadAndApplyTheme()

            frmMain.gRootPath = ""

            Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\SCM\Kotor Tool")

            If registryKey Is Nothing Then
                Dim registryErrorMessage As String = "Kotor Tool cannot find its key in the registry at HKLM\software\SCM\Kotor Tool." & vbLf & vbLf & "Please reinstall Kotor Tool."
                Interaction.MsgBox(registryErrorMessage, MsgBoxStyle.Critical, Nothing)
                System.Environment.Exit(0)
                Return
            End If

            'frmMain.gRootPath = StringType.FromObject(registryKey.GetValue("path"))
            '
            'If Not frmMain.gRootPath.EndsWith("\") Then
            'frmMain.gRootPath += "\"
            'End If

            ' -----------------------------------------------------------------
            ' Portable runtime root.
            ' The original tool used the registry install path, which commonly
            ' points to Program Files and causes UnauthorizedAccessException
            ' when extracting resources into the working folder.
            ' -----------------------------------------------------------------
            frmMain.gRootPath = frmMain.GetApplicationRootPath()
            frmMain.gWorkingPath = frmMain.GetWorkingDirectoryPath()

            Me.TreeView.HideSelection = False
            Me.Text = "Kotor Tool v" & Application.ProductVersion

            frmMain.CurrentSettings = UserSettings.GetSettings()

            ' -----------------------------------------------------------------
            ' Restore main window location safely.
            ' -----------------------------------------------------------------
            Dim mainWindowLoc As Point = frmMain.CurrentSettings.MainWindowLoc

            If (mainWindowLoc.X < 0) OrElse (mainWindowLoc.Y < 0) Then
                mainWindowLoc.X = 100
                mainWindowLoc.Y = 100
                frmMain.CurrentSettings.MainWindowLoc = mainWindowLoc
                UserSettings.SaveSettings(frmMain.CurrentSettings)
            End If

            Me.Location = mainWindowLoc

            ' -----------------------------------------------------------------
            ' Restore main window size safely.
            ' -----------------------------------------------------------------
            If Not frmMain.CurrentSettings.MainWindowSize.IsEmpty Then
                Dim savedSize As Size = frmMain.CurrentSettings.MainWindowSize
                Dim adjustedHeight As Integer = 0
                Dim adjustedWidth As Integer = 0

                If savedSize.Height > Screen.PrimaryScreen.WorkingArea.Height Then
                    Dim currentLocation As Point = Me.Location
                    Me.Location = New Point(currentLocation.X, Screen.PrimaryScreen.WorkingArea.Top)

                    adjustedHeight = Screen.PrimaryScreen.WorkingArea.Height
                    Me.Size = New Size(Me.Size.Width, adjustedHeight)
                End If

                savedSize = frmMain.CurrentSettings.MainWindowSize

                If savedSize.Width > Screen.PrimaryScreen.WorkingArea.Width Then
                    Dim currentLocation As Point = Me.Location
                    Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Left, currentLocation.Y)

                    adjustedWidth = Screen.PrimaryScreen.WorkingArea.Width
                    Me.Size = New Size(adjustedWidth, Me.Size.Height)
                End If

                If (adjustedWidth = 0) AndAlso (adjustedHeight = 0) Then
                    Me.Size = frmMain.CurrentSettings.MainWindowSize
                End If
            End If

            ' -----------------------------------------------------------------
            ' First-run / missing-path auto-detection.
            '
            ' Original behaviour depended on Me.hasK1 / Me.hasK2, which were
            ' registry-only checks. That meant Steam, GOG, or moved installs
            ' could be missed before the Path Manager even opened.
            '
            ' New behaviour uses the upgraded frmPathManager detector directly.
            ' -----------------------------------------------------------------

            Dim detectedKotor1Path As String = ""
            Dim detectedKotor2Path As String = ""

            If StringType.StrCmp(frmMain.CurrentSettings.defaultKotORLocation, "", False) = 0 Then
                detectedKotor1Path = frmPathManager.DetectKotor1Path()
            End If

            If StringType.StrCmp(frmMain.CurrentSettings.defaultKotORLocation2, "", False) = 0 Then
                detectedKotor2Path = frmPathManager.DetectKotor2Path()
            End If

            If detectedKotor1Path.Length > 0 Then
                frmMain.CurrentSettings.defaultKotORLocation = detectedKotor1Path
            End If

            If detectedKotor2Path.Length > 0 Then
                frmMain.CurrentSettings.defaultKotORLocation2 = detectedKotor2Path
            End If

            If detectedKotor1Path.Length > 0 OrElse detectedKotor2Path.Length > 0 Then
                UserSettings.SaveSettings(frmMain.CurrentSettings)
            End If

            Me.hasK1 = frmMain.hasKotor1()
            Me.hasK2 = frmMain.hasKotor2()

            If ((StringType.StrCmp(frmMain.CurrentSettings.defaultKotORLocation, "", False) = 0) AndAlso Not Me.hasK1) OrElse ((StringType.StrCmp(frmMain.CurrentSettings.defaultKotORLocation2, "", False) = 0) AndAlso Not Me.hasK2) Then
                Dim frmPathManager As frmPathManager = New frmPathManager()

                If detectedKotor1Path.Length > 0 Then
                    frmPathManager.tbKotorPath.Text = detectedKotor1Path
                End If

                If detectedKotor2Path.Length > 0 Then
                    frmPathManager.tbKotorPath2.Text = detectedKotor2Path
                End If

                Dim firstRunMessage As String = "KotOR Tool has attempted to detect your KotOR installation paths." & vbCrLf & "Please verify the directories before continuing."
                Interaction.MsgBox(firstRunMessage, MsgBoxStyle.Information, "First run configuration")

                frmPathManager.StartPosition = FormStartPosition.CenterScreen
                frmPathManager.ShowDialog(Me)

                frmMain.CurrentSettings = UserSettings.GetSettings()
                frmMain.CurrentSettings.bBuildModelsBifNode = True

                Me.hasK1 = frmMain.hasKotor1()
                Me.hasK2 = frmMain.hasKotor2()
            End If

            ' -----------------------------------------------------------------
            ' Warn only after upgraded detection and Path Manager verification.
            ' -----------------------------------------------------------------
            If Not Me.hasK1 AndAlso Not Me.hasK2 Then
                Dim noGamesMessage As String = "No installation of Kotor I or II was detected." & vbLf & vbLf & "Most features will not work."
                Interaction.MsgBox(noGamesMessage, MsgBoxStyle.Critical, "No games detected")
            End If

            ' -----------------------------------------------------------------
            ' Load chitin.key data for detected games.
            ' -----------------------------------------------------------------
            If Me.hasK1 Then
                frmMain.gK1ChitinKey = New clsChitinKey(frmMain.CurrentSettings.KeyFileLocation(0))

                Console.WriteLine("gK1ChitinKey: Lsum = " & StringType.FromLong(frmMain.gK1ChitinKey.Lsum) & ", Llength = " & StringType.FromLong(frmMain.gK1ChitinKey.Llength))

                If Not frmMain.gK1ChitinKey.IsValid(0) Then
                    Interaction.MsgBox("Your Kotor I chitin.key file appears to be corrupt." & vbLf & "You may want to reinstall KotOR II to fix this.", MsgBoxStyle.Information, "Chitin.key file not valid")
                End If

                If frmMain.gK1ChitinKey.BiffList.Length <> 26 Then
                    Interaction.MsgBox("Your Kotor I chitin.key file appears to have been altered from the official version." & vbLf & vbLf & "If you have not altered it by installing custom packages, you may want to reinstall KotOR to fix this.", MsgBoxStyle.Critical, "Chitin.key file altered")
                End If
            End If

            If Me.hasK2 Then
                frmMain.gK2ChitinKey = New clsChitinKey(frmMain.CurrentSettings.KeyFileLocation(1))

                Console.WriteLine("gK2ChitinKey: Lsum = " & StringType.FromLong(frmMain.gK2ChitinKey.Lsum) & ", Llength = " & StringType.FromLong(frmMain.gK2ChitinKey.Llength))

                If Not frmMain.gK2ChitinKey.IsValid(1) Then
                    Interaction.MsgBox("Your Kotor II chitin.key file appears to be corrupt or is a non-US version.", MsgBoxStyle.Information, "Chitin.key file not valid")
                End If

                If frmMain.gK2ChitinKey.BiffList.Length <> 11 Then
                    Interaction.MsgBox("Your Kotor II chitin.key file appears to have been altered from the official version." & vbLf & vbLf & "If you have not altered it by installing custom packages, you may want to reinstall KotOR to fix this.", MsgBoxStyle.Critical, "Chitin.key file altered")
                End If
            End If

            ' -----------------------------------------------------------------
            ' Build main resource roots and apply theme-aware tree colours.
            ' -----------------------------------------------------------------
            Me.SetupTreeRoots()

            If _theme Is Nothing Then
                _theme = KotorTheme.CreateDefault()
            End If

            If Not Me.hasK1 Then
                Me.TreeView.Nodes(0).ForeColor = _theme.TextMuted
            End If

            If Not Me.hasK2 Then
                Me.TreeView.Nodes(1).ForeColor = _theme.TextMuted
            End If

            If Me.hasK1 Then
                Me.SetupRootChildren(CType(Me.TreeView.Nodes(0), KotorTreeNode))
            End If

            If Me.hasK2 Then
                Me.SetupRootChildren(CType(Me.TreeView.Nodes(1), KotorTreeNode))
            End If

            Me.RefreshTreeNodeColours()

            If frmMain.CurrentSettings.bBuildBIFFtreeOnStartup Then
                If Me.hasK1 Then
                    Me.BuildTreeView(CType(Me.TreeView.Nodes(0), KotorTreeNode), False)
                End If

                If Me.hasK2 Then
                    Me.BuildTreeView(CType(Me.TreeView.Nodes(1), KotorTreeNode), False)
                End If

                Me.RefreshTreeNodeColours()
            End If

            If frmMain.IsOnly1KotORInstalled() Then
                If Me.hasK1 Then
                    Me.TreeView.SelectedNode = Me.TreeView.Nodes(0)
                End If

                If Me.hasK2 Then
                    Me.TreeView.SelectedNode = Me.TreeView.Nodes(1)
                End If
            End If

            Me.CreateTemplateTagsHashFiles()
            Me.ExtractNWScripts()

            If Me.CmdArgs IsNot Nothing Then
                Me.g_CmdLineOpenedForm = Me.OpenFileFromCmdLine()
            End If

            Me.ManageMRUMainFileMenu()

            If frmMain.CurrentSettings.bRememberLastTreeNode AndAlso frmMain.CurrentSettings.LastClickedTVNodePath IsNot Nothing AndAlso StringType.StrCmp(frmMain.CurrentSettings.LastClickedTVNodePath, "", False) <> 0 Then
                frmMain.OpenTreeViewToPath(frmMain.CurrentSettings.LastClickedTVNodePath, Me.TreeView.Nodes(0), 0, True)
            End If

            If frmMain.CurrentSettings.bRememberTreeViewState Then
                Try
                    For Each obj As Object In frmMain.CurrentSettings.TreeOpenPaths
                        Dim text As String = StringType.FromObject(obj)
                        frmMain.OpenTreeViewToPath(text, Me.TreeView.Nodes(0), 0, True)
                    Next
                Finally
                    Dim enumerator As IEnumerator

                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If

            If frmMain.CurrentSettings.bCheckForUpdatesAtStartup Then
                Me.g_CheckForUpdatesSilently = False

                Dim checkForUpdate As frmMain.CheckForUpdate = AddressOf Me.CheckForUpdateA

                Console.WriteLine("Starting CheckForUpdate thread")
                checkForUpdate.BeginInvoke(Nothing, Nothing)
            End If

            UserSettings.SaveSettings(frmMain.CurrentSettings)
        End Sub

        ' Token: 0x06000728 RID: 1832 RVA: 0x0025499C File Offset: 0x0025399C
        Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            frmMain.SaveSettings()
        End Sub

        ' Token: 0x06000729 RID: 1833 RVA: 0x002549A4 File Offset: 0x002539A4
        Private Sub frmMain_Move(ByVal sender As Object, ByVal e As EventArgs)
            If frmMain.CurrentSettings IsNot Nothing AndAlso frmMain.CurrentSettings.bDockImageViewer AndAlso frmMain.gImageViewer IsNot Nothing AndAlso frmMain.gImageViewer.Visible Then
                Dim control As Control = frmMain.gImageViewer
                Dim point As Point = New Point(Me.Location.X + Me.Size.Width, Me.Location.Y)
                control.Location = point
            End If
        End Sub

        '' Token: 0x0600072A RID: 1834 RVA: 0x00254A14 File Offset: 0x00253A14
        'Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As EventArgs)
        '    If (Me.CmdArgs <> Nothing) And (Me.g_CmdLineOpenedForm IsNot Nothing) Then
        '        Me.g_CmdLineOpenedForm.BringToFront()
        '        Me.g_CmdLineOpenedForm = Nothing
        '    End If
        'End Sub

        ' Token: 0x0600072A RID: 1834 RVA: 0x00254A14 File Offset: 0x00253A14
        Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.CmdArgs IsNot Nothing) AndAlso (Me.g_CmdLineOpenedForm IsNot Nothing) Then
                Me.g_CmdLineOpenedForm.BringToFront()
                Me.g_CmdLineOpenedForm = Nothing
            End If
        End Sub

        ' Token: 0x0600072B RID: 1835 RVA: 0x00254A44 File Offset: 0x00253A44
        Private Sub CreateMapInfoBFD_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateMapInfoBFD.Click
            Dim clsMapInfoCreator As clsMapInfoCreator = New clsMapInfoCreator()
            clsMapInfoCreator.write(frmMain.gRootPath)
        End Sub

        ' Token: 0x0600072C RID: 1836 RVA: 0x00254A64 File Offset: 0x00253A64
        Private Sub btnExtract_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExtract.Click
            Me.ExtractSelectedKotorFile(CType(Me.TreeView.SelectedNode, KotorTreeNode), "", "", Nothing)
        End Sub

        ' Token: 0x0600072D RID: 1837 RVA: 0x00254A88 File Offset: 0x00253A88
        Private Function ExtractSelectedKotorFile(ByVal node As KotorTreeNode, Optional ByVal outputpath As String = "", Optional ByVal SaveMsg As String = "", Optional ByVal ResTypes As Hashtable = Nothing) As Object
            Dim tag As Object = node.Tag
            If ObjectType.ObjTst(tag, "RIM", False) = 0 Then
                If StringType.StrCmp(SaveMsg, "", False) = 0 Then
                    SaveMsg = "Select Folder to extract RIM to..."
                End If
                If StringType.StrCmp(outputpath, "", False) = 0 Then
                    outputpath = StringType.FromObject(ObjectType.StrCatObj(frmMain.GetFilePath("", frmMain.CurrentSettings.defaultSaveLocation, "", SaveMsg, "", False, True), "\"))
                End If
                If StringType.StrCmp(outputpath, "\", False) = 0 Then
                    Dim obj As Object
                    Return obj
                End If
                Dim cursor As Cursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
                Dim fileStream As FileStream = New FileStream(node.FilePath + "\" + node.Filename, FileMode.Open, FileAccess.Read)
                Dim binaryReader As BinaryReader = New BinaryReader(fileStream, Encoding.ASCII)
                Dim array As Byte() = binaryReader.ReadBytes(CInt(fileStream.Length))
                binaryReader.Close()
                Dim clsRIM As clsRIM = New clsRIM(array)
                If ResTypes Is Nothing Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = clsRIM.EntryCount - 1
                    For i As Integer = num To num2
                        frmMain.WriteByteArray(outputpath + CType(clsRIM.KeyEntryList(i), RIMKeyEntry)._ResourceName + "." + CType(clsRIM.KeyEntryList(i), RIMKeyEntry)._ResTypeStr, clsRIM.GetRIMResource(i))
                    Next
                Else
                    Dim num3 As Integer = 0
                    Dim num4 As Integer = clsRIM.EntryCount - 1
                    For i As Integer = num3 To num4
                        If ResTypes.Contains(CType(clsRIM.KeyEntryList(i), RIMKeyEntry)._ResType) Then
                            frmMain.WriteByteArray(outputpath + CType(clsRIM.KeyEntryList(i), RIMKeyEntry)._ResourceName + "." + CType(clsRIM.KeyEntryList(i), RIMKeyEntry)._ResTypeStr, clsRIM.GetRIMResource(i))
                        End If
                    Next
                End If
                Cursor.Current = cursor
            ElseIf ObjectType.ObjTst(tag, "RIM_Res", False) = 0 Then
                outputpath = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, node.Filename, "Save " + node.Filename + " file...", node.ResTypeStr, False, True))
                If StringType.StrCmp(outputpath, "", False) = 0 Then
                    Dim obj As Object
                    Return obj
                End If
                Dim array As Byte() = Me.GetRIMResource(node.FilePath, node)
                frmMain.WriteByteArray(outputpath, array)
            ElseIf ObjectType.ObjTst(tag, "BIFF", False) = 0 Then
                If StringType.StrCmp(outputpath, "", False) = 0 Then
                    outputpath = StringType.FromObject(ObjectType.StrCatObj(frmMain.GetFilePath("", frmMain.CurrentSettings.defaultSaveLocation, "", "Select Folder to extract BIF to...", "", False, True), "\"))
                End If
                If StringType.StrCmp(outputpath, "\", False) = 0 Then
                    Dim obj As Object
                    Return obj
                End If
                Dim cursor2 As Cursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
                Try
                    For Each obj2 As Object In node.Nodes
                        Dim kotorTreeNode As KotorTreeNode = CType(obj2, KotorTreeNode)
                        Dim num5 As Integer = 0
                        Dim num6 As Integer = kotorTreeNode.GetNodeCount(False) - 1
                        For j As Integer = num5 To num6
                            frmMain.ExportBiffResource(node.FilePath + "\" + node.Filename, outputpath + CType(kotorTreeNode.Nodes(j), KotorTreeNode).ResRef + "." + CType(kotorTreeNode.Nodes(j), KotorTreeNode).ResTypeStr, CType(kotorTreeNode.Nodes(j), KotorTreeNode).LocalResID)
                        Next
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Cursor.Current = cursor2
            ElseIf ObjectType.ObjTst(tag, "BIFF_Res", False) = 0 Then
                outputpath = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, node.Filename, "Save " + node.Filename + " file...", node.ResTypeStr, False, True))
                If StringType.StrCmp(outputpath, "", False) = 0 Then
                    Dim obj As Object
                    Return obj
                End If
                frmMain.ExportBiffResource(node.FilePath, outputpath, node.LocalResID)
            ElseIf ObjectType.ObjTst(tag, "ERF", False) = 0 Then
                outputpath = StringType.FromObject(ObjectType.StrCatObj(frmMain.GetFilePath("", frmMain.CurrentSettings.defaultSaveLocation, "", "Select Folder to extract ERF to...", "", False, True), "\"))
                If StringType.StrCmp(outputpath, "\", False) = 0 Then
                    Dim obj As Object
                    Return obj
                End If
                Dim fileStream2 As FileStream = New FileStream(node.FilePath + "\" + node.Filename, FileMode.Open, FileAccess.Read)
                Dim clsERF As clsERF = New clsERF(fileStream2)
                Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
                frmProgressMeter.stepAmount = 1
                frmProgressMeter.maxvalue = clsERF.EntryCount
                frmProgressMeter.message = "Extracting files from " + node.Filename
                frmProgressMeter.Location = New utilWindowRelativePositioner(Me, frmProgressMeter).getConcentric()
                frmProgressMeter.Show()
                Dim num7 As Integer = 0
                Dim num8 As Integer = clsERF.EntryCount - 1
                For k As Integer = num7 To num8
                    Dim array As Byte() = clsERF.getERFResource(k)
                    Dim erfkeyEntry As ERFKeyEntry = CType(clsERF.KeyEntryList(k), ERFKeyEntry)
                    frmProgressMeter.status = "Writing " + erfkeyEntry._ResourceName + "." + erfkeyEntry._ResTypeStr
                    Dim fileStream3 As FileStream = New FileStream(outputpath + erfkeyEntry._ResourceName + "." + erfkeyEntry._ResTypeStr, FileMode.Create)
                    fileStream3.Write(array, 0, array.Length)
                    fileStream3.Close()
                    frmProgressMeter.stepUp()
                Next
                fileStream2.Close()
                frmProgressMeter.Close()
            ElseIf ObjectType.ObjTst(tag, "ERF_Res", False) = 0 Then
                Dim obj As Object
                Dim text As String
                If StringType.StrCmp(node.ResTypeStr, "tpc", False) = 0 Then
                    If Not frmMain.CurrentSettings.bAlwaysConvertTPC2TGA Then
                        Dim frmTPCFileSaveType As frmTPCFileSaveType = New frmTPCFileSaveType()
                        If frmTPCFileSaveType.ShowDialog(Me) = DialogResult.Cancel Then
                            Return obj
                        End If
                        text = frmTPCFileSaveType.saveType
                    Else
                        text = "tga"
                    End If
                    If StringType.StrCmp(text, "tga", False) = 0 Then
                        outputpath = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, node.ResRef + ".tga", "Save " + node.ResRef + ".tga file...", "tga", False, True))
                    Else
                        outputpath = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, node.Filename, "Save " + node.Filename + " file...", "tpc", False, True))
                    End If
                Else
                    outputpath = StringType.FromObject(frmMain.GetFilePath("save", frmMain.CurrentSettings.defaultSaveLocation, node.Filename + "", "Save " + node.Filename + " file...", "", False, True))
                End If
                If StringType.StrCmp(outputpath, "", False) = 0 Then
                    Return obj
                End If
                Dim array As Byte() = Me.GetERFResource(node.FilePath, node)
                If StringType.StrCmp(text, "tga", False) = 0 Then
                    Dim frmImageViewer As frmImageViewer = New frmImageViewer()
                    frmImageViewer.SetupTPCData(array, "foo")
                    frmImageViewer.DecodeImage()
                    frmImageViewer.WriteTGAFile(outputpath)
                Else
                    frmMain.WriteByteArray(outputpath, array)
                End If
            ElseIf ObjectType.ObjTst(tag, "NodeCategory", False) = 0 Then
                Dim containingFileType As String = CType(node.Parent, KotorTreeNode).ContainingFileType
                Dim kotorTreeNode2 As KotorTreeNode = CType(node.Parent, KotorTreeNode)
                If StringType.StrCmp(containingFileType, "BIF", False) = 0 OrElse StringType.StrCmp(containingFileType, "rim", False) = 0 Then
                    If StringType.StrCmp(SaveMsg, "", False) = 0 Then
                        SaveMsg = "Select Folder to extract entire subtype to..."
                    End If
                    If StringType.StrCmp(outputpath, "", False) = 0 Then
                        outputpath = StringType.FromObject(ObjectType.StrCatObj(frmMain.GetFilePath("", frmMain.CurrentSettings.defaultSaveLocation, "", SaveMsg, "", False, True), "\"))
                    End If
                    If StringType.StrCmp(outputpath, "\", False) = 0 Then
                        Dim obj As Object
                        Return obj
                    End If
                End If
                Dim text2 As String = containingFileType
                If StringType.StrCmp(text2, "BIF", False) = 0 Then
                    Dim cursor3 As Cursor = Cursor.Current
                    Cursor.Current = Cursors.WaitCursor
                    Try
                        For Each obj3 As Object In node.Nodes
                            Dim kotorTreeNode3 As KotorTreeNode = CType(obj3, KotorTreeNode)
                            frmMain.ExportBiffResource(kotorTreeNode2.FilePath + "\" + kotorTreeNode2.Filename, outputpath + kotorTreeNode3.ResRef + "." + kotorTreeNode3.ResTypeStr, kotorTreeNode3.LocalResID)
                        Next
                    Finally
                        Dim enumerator2 As IEnumerator
                        If TypeOf enumerator2 Is IDisposable Then
                            CType(enumerator2, IDisposable).Dispose()
                        End If
                    End Try
                    Cursor.Current = cursor3
                ElseIf StringType.StrCmp(text2, "rim", False) = 0 Then
                    Dim cursor4 As Cursor = Cursor.Current
                    Cursor.Current = Cursors.WaitCursor
                    Dim fileStream4 As FileStream = New FileStream(kotorTreeNode2.FilePath + "\" + kotorTreeNode2.Filename, FileMode.Open, FileAccess.Read)
                    Dim binaryReader2 As BinaryReader = New BinaryReader(fileStream4, Encoding.ASCII)
                    Dim array As Byte() = binaryReader2.ReadBytes(CInt(fileStream4.Length))
                    binaryReader2.Close()
                    Dim clsRIM2 As clsRIM = New clsRIM(array)
                    Dim num9 As Integer = 0
                    Dim num10 As Integer = clsRIM2.EntryCount - 1
                    For l As Integer = num9 To num10
                        If CInt(CType(clsRIM2.KeyEntryList(l), RIMKeyEntry)._ResType) = node.ResType Then
                            frmMain.WriteByteArray(outputpath + CType(clsRIM2.KeyEntryList(l), RIMKeyEntry)._ResourceName + "." + CType(clsRIM2.KeyEntryList(l), RIMKeyEntry)._ResTypeStr, clsRIM2.GetRIMResource(l))
                        End If
                    Next
                    Cursor.Current = cursor4
                End If
            End If
            Return outputpath
        End Function

        ' Token: 0x0600072E RID: 1838 RVA: 0x00255474 File Offset: 0x00254474
        Private Sub btnHexViewer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHexViewer.Click
            Dim kotorTreeNode As KotorTreeNode = CType(Me.TreeView.SelectedNode, KotorTreeNode)
            If kotorTreeNode IsNot Nothing Then
                If ObjectType.ObjTst(kotorTreeNode.Tag, "BIFF_Root", False) = 0 Then
                    Return
                End If
                If ObjectType.ObjTst(kotorTreeNode.Tag, "RIM_Root", False) = 0 Then
                    Return
                End If
                Dim tag As Object = kotorTreeNode.Tag
                Dim frmByteViewer As frmByteViewer
                If ObjectType.ObjTst(tag, "BIFF", False) = 0 OrElse ObjectType.ObjTst(tag, "RIM", False) = 0 Then
                    frmByteViewer = New frmByteViewer(kotorTreeNode.FilePath + "\" + kotorTreeNode.Filename)
                ElseIf ObjectType.ObjTst(tag, "RIM_Res", False) = 0 Then
                    frmByteViewer = New frmByteViewer(Me.GetRIMResource(kotorTreeNode.FilePath, kotorTreeNode))
                ElseIf ObjectType.ObjTst(tag, "BIFF_Res", False) = 0 Then
                    frmByteViewer = New frmByteViewer(Me.GetBIFFResource(kotorTreeNode.FilePath, kotorTreeNode.LocalResID).data)
                Else
                    If ObjectType.ObjTst(tag, "ERF_Res", False) <> 0 Then
                        Return
                    End If
                    frmByteViewer = New frmByteViewer(Me.GetERFResource(kotorTreeNode.FilePath, kotorTreeNode))
                End If
                frmByteViewer.Show()
            End If
        End Sub

        ' Token: 0x0600072F RID: 1839 RVA: 0x00255580 File Offset: 0x00254580
        Private Sub TreeView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles TreeView.DoubleClick
            Dim kotorTreeNode As KotorTreeNode = CType(Me.TreeView.SelectedNode, KotorTreeNode)
            Me.HandleDataByNodeType(kotorTreeNode, RuntimeHelpers.GetObjectValue(sender))
        End Sub

        ' Token: 0x06000730 RID: 1840 RVA: 0x002555AC File Offset: 0x002545AC
        Private Function GetMDLRoomBaseName(ByVal node As KotorTreeNode) As String
            Select Case Me.NodeTreeRootIndex(node)
                Case 0
                    Return node.ResRef.Substring(0, 5)
                Case 1
                    Return node.ResRef.Substring(0, 6)
                Case Else
                    Dim text As String
                    Return text
            End Select
        End Function

        ' Token: 0x06000731 RID: 1841 RVA: 0x002555F0 File Offset: 0x002545F0
        Private Function GetMDLRoomCount(ByVal node As KotorTreeNode) As Integer
            Dim num As Integer = -1
            Dim num2 As Integer = Me.NodeTreeRootIndex(node)
            Dim mdlroomBaseName As String = Me.GetMDLRoomBaseName(node)
            Dim biffresourceData As Byte() = frmMain.GetBIFFResourceData(num2, mdlroomBaseName, 3000)
            If biffresourceData IsNot Nothing Then
                Dim memoryStream As MemoryStream = New MemoryStream(biffresourceData)
                Dim streamReader As StreamReader = New StreamReader(memoryStream)
                streamReader.ReadLine()
                streamReader.ReadLine()
                streamReader.ReadLine()
                num = Convert.ToInt32(streamReader.ReadLine().Replace(" ", "").Replace("roomcount", ""))
                streamReader.Close()
            End If
            Return num
        End Function

        ' Token: 0x06000732 RID: 1842 RVA: 0x00255680 File Offset: 0x00254680
        Public Sub HandleDataByNodeType(ByVal node As KotorTreeNode, ByVal sender As Object)
            Dim cursor As Cursor = Cursor.Current
            frmMain.CurrentSettings = UserSettings.GetSettings()
            Dim tag As Object = node.Tag
            Dim array As Byte()
            If ObjectType.ObjTst(tag, "RIM_Res", False) = 0 Then
                array = Me.GetRIMResource(node.FilePath, node)
            ElseIf ObjectType.ObjTst(tag, "BIFF_Res", False) = 0 Then
                If StringType.StrCmp(node.ResTypeStr, "mdl", False) <> 0 Then
                    array = Me.GetBIFFResource(node.FilePath, node.LocalResID).data
                End If
            ElseIf ObjectType.ObjTst(tag, "ERF_Res", False) = 0 Then
                array = Me.GetERFResource(node.FilePath, node)
            Else
                If ObjectType.ObjTst(tag, "globalvar", False) = 0 Then
                    array = Me.ReadByteArray(node.FilePath + "\" + node.Filename)
                    Dim clsGlobalVars As clsGlobalVars = New clsGlobalVars(array, Me.NodeTreeRootIndex(node))
                    Dim frmGlobalVar_Editor As frmGlobalVar_Editor = New frmGlobalVar_Editor(clsGlobalVars, node.FilePath, Me.NodeTreeRootIndex(node))
                    frmGlobalVar_Editor.Show()
                    Return
                End If
                Return
            End If
            Dim resTypeStr As String = node.ResTypeStr
            If StringType.StrCmp(resTypeStr, "mdl", False) = 0 Then
                If frmMain.CurrentSettings.ModelExportLocation Is Nothing OrElse Not Directory.Exists(frmMain.CurrentSettings.ModelExportLocation) Then
                    Interaction.MsgBox("The Model Export Location is not set." & vbLf & vbLf & "A default path has been set in the Path Manager; you may accept it or choose your own.", MsgBoxStyle.Critical, "Path not set")
                    Dim frmPathManager As frmPathManager = New frmPathManager()
                    If Not Directory.Exists(frmMain.gRootPath + "working\Exported Models") Then
                        Directory.CreateDirectory(frmMain.gRootPath + "working\Exported Models")
                    End If
                    frmPathManager.tbModuleExportPath.Text = frmMain.gRootPath + "working\Exported Models"
                    frmPathManager.StartPosition = FormStartPosition.CenterScreen
                    frmPathManager.TabControl1.SelectedIndex = 2
                    frmPathManager.tbModuleExportPath.BackColor = KotorThemeManager.LoadTheme(KotorThemeManager.GetActiveThemeName()).ValidationErrorBack
                    frmPathManager.ShowDialog(Me)
                    frmMain.CurrentSettings = UserSettings.GetSettings()
                End If
                Dim mdlroomCount As Integer = Me.GetMDLRoomCount(node)
                Dim frmMdlOpsSwitches As frmMdlOpsSwitches = New frmMdlOpsSwitches()
                frmMdlOpsSwitches.chkbExtractAnimations.Checked = frmMain.CurrentSettings.bModelExtraction_ExtractAnimations
                frmMdlOpsSwitches.chkbConvertSkin.Checked = frmMain.CurrentSettings.bModelExtraction_ConvertSkinToTrimesh
                frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked = frmMain.CurrentSettings.bModelExtraction_EachModelInOwnDirectory
                frmMdlOpsSwitches.chkbCleanWorkingDir.Checked = frmMain.CurrentSettings.bModelExtraction_CleanWorkingDirectoryBeforeExport
                frmMdlOpsSwitches.tbModelExtractionPath.Text = frmMain.CurrentSettings.ModelExportLocation
                If frmMdlOpsSwitches.ShowDialog(Me) <> DialogResult.OK Then
                    Return
                End If
                While frmMdlOpsSwitches.tbModelExtractionPath.Text.EndsWith("\")
                    frmMdlOpsSwitches.tbModelExtractionPath.Text = frmMdlOpsSwitches.tbModelExtractionPath.Text.Substring(0, frmMdlOpsSwitches.tbModelExtractionPath.Text.Length - 1)
                End While
                If StringType.StrCmp(frmMdlOpsSwitches.tbModelExtractionPath.Text.Replace("\" + Me.GetMDLRoomBaseName(node), ""), frmMain.CurrentSettings.ModelExportLocation, False) <> 0 Then
                    frmMain.CurrentSettings.ModelExportLocation = frmMdlOpsSwitches.tbModelExtractionPath.Text
                    UserSettings.SaveSettings(frmMain.CurrentSettings)
                End If
                If Not Directory.Exists(frmMdlOpsSwitches.tbModelExtractionPath.Text) Then
                    Directory.CreateDirectory(frmMdlOpsSwitches.tbModelExtractionPath.Text)
                End If
                Dim checked As Boolean = frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked
                Dim checked2 As Boolean = frmMdlOpsSwitches.chkbCleanWorkingDir.Checked
                Dim frmProgressMeter As frmProgressMeter = New frmProgressMeter()
                frmProgressMeter.stepAmount = 1
                frmProgressMeter.maxvalue = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value)
                frmProgressMeter.message = "Extracting models"
                frmProgressMeter.Location = New utilWindowRelativePositioner(Me, frmProgressMeter).getConcentric()
                frmProgressMeter.Show()
                Me.EnsureWorkingDirectoryExists()
                frmMain.CurrentSettings.bModelExtraction_ExtractAnimations = frmMdlOpsSwitches.ExtractAnimations
                frmMain.CurrentSettings.bModelExtraction_ConvertSkinToTrimesh = frmMdlOpsSwitches.ConvertSkin
                frmMain.CurrentSettings.bModelExtraction_EachModelInOwnDirectory = frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked
                frmMain.CurrentSettings.bModelExtraction_CleanWorkingDirectoryBeforeExport = frmMdlOpsSwitches.chkbCleanWorkingDir.Checked
                UserSettings.SaveSettings(frmMain.CurrentSettings)
                If checked2 Then
                    frmMain.CleanDirectory(frmMdlOpsSwitches.tbModelExtractionPath.Text)
                End If
                If frmMdlOpsSwitches.chkbExportMdlAlignData.Checked Or frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked Then
                    Dim text As String
                    If Me.NodeTreeRootIndex(node) = 1 Then
                        text = node.ResRef.Substring(0, 6)
                    End If
                    Dim fileStream As FileStream = New FileStream("C:\3dsmax7\scripts\NWmax\plugins\test.txt", FileMode.Create)
                    Dim streamWriter As StreamWriter = New StreamWriter(fileStream)
                    array = frmMain.GetBIFFResourceData(Me.NodeTreeRootIndex(node), text, 3000)
                    Dim memoryStream As MemoryStream = New MemoryStream(array)
                    Dim streamReader As StreamReader = New StreamReader(memoryStream)
                    streamReader.ReadLine()
                    streamReader.ReadLine()
                    streamReader.ReadLine()
                    streamReader.ReadLine()
                    streamWriter.WriteLine(mdlroomCount)
                    Dim num As Integer = 1
                    Dim num2 As Integer = mdlroomCount
                    For i As Integer = num To num2
                        Dim array2 As String() = streamReader.ReadLine().Trim().Split(New Char() {" "c})
                        Dim num3 As Integer = 1
                        Do
                            ' The following expression was wrapped in a unchecked-expression
                            array2(num3) = (Convert.ToSingle(array2(num3)) * 100.0F).ToString()
                            num3 += 1
                        Loop While num3 <= 3
                        streamWriter.WriteLine(String.Concat(New String() {frmMdlOpsSwitches.tbModelExtractionPath.Text, "\", array2(0), "-ascii.mdl,", array2(0), ",", array2(1), ",", array2(2), ",", array2(3)}))
                    Next
                    streamWriter.Close()
                    streamReader.Close()
                End If
                If Not frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked Then
                    Dim num4 As Integer = 1
                    Dim num5 As Integer = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value)
                    For j As Integer = num4 To num5
                        frmProgressMeter.status = "Getting data for " + node.ResRef
                        array = Me.GetBIFFResource(node.FilePath, node.LocalResID).data
                        Dim text2 As String = frmMdlOpsSwitches.tbModelExtractionPath.Text + "\" + node.ResRef
                        If checked Then
                            If Not Directory.Exists(text2) Then
                                Directory.CreateDirectory(text2)
                            End If
                            text2 = text2 + "\" + node.ResRef
                        End If
                        frmMain.WriteByteArray(text2 + ".mdl", array)
                        frmMain.ExportBiffResource(Me.NodeTreeRootIndex(node), node.ResRef, 3008, text2 + ".mdx")
                        frmProgressMeter.status = "Exporting model " + node.ResRef
                        Dim text3 As String = frmMain.gRootPath + "mdlops.exe"
                        Try
                            Dim process As Process = New Process()
                            process.StartInfo.FileName = text3
                            process.StartInfo.CreateNoWindow = True
                            Dim processStartInfo As ProcessStartInfo
                            If Not frmMdlOpsSwitches.ExtractAnimations Then
                                processStartInfo = process.StartInfo
                                processStartInfo.Arguments += "-a "
                            End If
                            If frmMdlOpsSwitches.ConvertSkin Then
                                processStartInfo = process.StartInfo
                                processStartInfo.Arguments += "-s "
                            End If
                            processStartInfo = process.StartInfo
                            processStartInfo.Arguments = String.Concat(New String() {processStartInfo.Arguments, """", text2, ".mdl", """"})
                            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                            process.StartInfo.UseShellExecute = False
                            process.StartInfo.RedirectStandardOutput = True
                            process.Start()
                            Dim text4 As String = process.StandardOutput.ReadToEnd()
                            process.WaitForExit(15000)
                            frmProgressMeter.status = "Extracting textures for " + node.ResRef
                            Dim fileStream2 As FileStream = New FileStream(text2 + "-textures.txt", FileMode.Open)
                            Dim streamReader2 As StreamReader = New StreamReader(fileStream2)
                            Dim frmImageViewer As frmImageViewer = New frmImageViewer()
                            Dim text5 As String = streamReader2.ReadLine()
                            While text5 IsNot Nothing
                                text5 = text5.Trim()
                                If (text5.Length > 0) And (StringType.StrCmp(text5, "null", False) <> 0) Then
                                    array = Me.GetERFResource(frmMain.CurrentSettings.KotorLocation(Me.NodeTreeRootIndex(node)) + "\TexturePacks\swpc_tex_tpa.erf", text5, 3007)
                                    frmImageViewer.SetupTPCData(array, "foo")
                                    frmImageViewer.DecodeImage()
                                    frmImageViewer.WriteTGAFile(text2.Substring(0, text2.LastIndexOf("\") + 1) + text5 + ".tga")
                                End If
                                text5 = streamReader2.ReadLine()
                            End While
                            streamReader2.Close()
                            fileStream2.Close()
                            File.Delete(text2 + ".mdl")
                            File.Delete(text2 + ".mdx")
                            File.Delete(text2 + "-textures.txt")
                        Catch ex As System.Exception
                            If StringType.StrCmp(ex.Message, "", False) <> 0 Then
                            End If
                        End Try
                        node = CType(node.NextNode, KotorTreeNode)
                        frmProgressMeter.stepUp()
                    Next
                End If
                frmProgressMeter.Close()
                Interaction.MsgBox("Extraction Complete", MsgBoxStyle.Information, "Model Extraction")
            ElseIf StringType.StrCmp(resTypeStr, "2da", False) = 0 Then
                Cursor.Current = Cursors.WaitCursor
                Dim frm2DAEditor As frm2DAEditor = New frm2DAEditor(node.Filename, array, Me.NodeTreeRootIndex(node))
                frm2DAEditor.Show()
            ElseIf StringType.StrCmp(resTypeStr, "pwk", False) = 0 OrElse StringType.StrCmp(resTypeStr, "dwk", False) = 0 OrElse StringType.StrCmp(resTypeStr, "wok", False) = 0 Then
                Dim frmBWMEditor As frmBWMEditor = New frmBWMEditor(array, node.Filename)
                frmBWMEditor.Show()
            ElseIf StringType.StrCmp(resTypeStr, "nss", False) = 0 OrElse StringType.StrCmp(resTypeStr, "vis", False) = 0 OrElse StringType.StrCmp(resTypeStr, "txi", False) = 0 OrElse StringType.StrCmp(resTypeStr, "lyt", False) = 0 Then
                Dim frmTextEditor As frmTextEditor = New frmTextEditor(node.Filename, False, "")
                Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
                frmTextEditor.tbGeneric.Text = asciiencoding.GetString(array)
                frmTextEditor.tbGeneric.SelectionLength = 0
                frmTextEditor.KotorVersionIndex = Me.NodeTreeRootIndex(node)
                If StringType.StrCmp(node.ResTypeStr, "nss", False) = 0 Then
                    frmTextEditor.PrepareForScriptEditing()
                End If
                frmTextEditor.Show()
            Else






                ''' MAJOR PATCH V1.0.3.3 NCS IS NOW MANAGED VIA EXTERNAL PLUGIN. DeNCS



                If StringType.StrCmp(resTypeStr, "ncs", False) = 0 Then
                    Dim gameNumber As Integer = Me.NodeTreeRootIndex(node) + 1

                    clsNCS.DecompileAndOpen(
                        Me,
                        array,
                        node.Filename,
                        node.ResRef,
                        gameNumber
                    )

                    GoTo IL_12BE
                End If


                If StringType.StrCmp(resTypeStr, "are", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "fac", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "jrl", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "git", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "gui", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "ifo", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "itp", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "pth", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "ptm", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "ptt", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "res", False) = 0 OrElse
                   StringType.StrCmp(resTypeStr, "ute", False) = 0 Then

                    Cursor.Current = Cursors.WaitCursor

                    If (Control.ModifierKeys And Keys.Shift) > Keys.None Then
                        Dim clsGFF As clsGFF = New clsGFF(Me.NodeTreeRootIndex(node))
                        clsGFF.RTFMode = False
                        clsGFF.Parse(array)

                        Dim frmTextEditor As frmTextEditor = New frmTextEditor()
                        frmTextEditor.Filename = node.Filename
                        frmTextEditor.Text = "Text Editor - " & node.Filename
                        frmTextEditor.RTFMode = False
                        frmTextEditor.tbGeneric.Text = clsGFF.ToString()
                        frmTextEditor.tbGeneric.SelectionLength = 0
                        frmTextEditor.Show()

                    ElseIf ((Control.ModifierKeys And Keys.Control) > Keys.None) OrElse frmMain.CurrentSettings.bAlwaysUnknownGFFasText Then
                        Dim clsGFF2 As clsGFF = New clsGFF(Me.NodeTreeRootIndex(node))
                        clsGFF2.RTFMode = True
                        clsGFF2.Parse(array)

                        Dim frmTextEditor2 As frmTextEditor = New frmTextEditor()
                        frmTextEditor2.Filename = node.Filename
                        frmTextEditor2.Text = "Text Editor - " & node.Filename
                        frmTextEditor2.RTFMode = True
                        frmTextEditor2.tbGeneric.Rtf = clsGFF2.ToString()
                        frmTextEditor2.tbGeneric.SelectionLength = 0
                        frmTextEditor2.Show()

                    Else
                        Me.EditGFFResource(node.Filename, array)
                    End If

                ElseIf StringType.StrCmp(resTypeStr, "utc", False) = 0 Then
                    Dim clsUTC As clsUTC = New clsUTC(array, Me.NodeTreeRootIndex(node))
                    Dim frmUTCEditor As frmUTC_Editor = New frmUTC_Editor(clsUTC, Me.NodeTreeRootIndex(node), False, "")
                    frmUTCEditor.EditingFilePath = frmMain.CurrentSettings.defaultSaveLocation & "\" & node.Text
                    frmUTCEditor.Show()

                ElseIf StringType.StrCmp(resTypeStr, "utd", False) = 0 Then
                    Dim clsUTD As clsUTD = New clsUTD(array, Me.NodeTreeRootIndex(node))
                    Dim frmUTDEditor As frmUTD_Editor = New frmUTD_Editor(clsUTD, Me.NodeTreeRootIndex(node), False, "")
                    frmUTDEditor.EditingFilePath = frmMain.CurrentSettings.defaultSaveLocation & "\" & node.Text
                    frmUTDEditor.Show()

                ElseIf StringType.StrCmp(resTypeStr, "uti", False) = 0 Then
                    Dim clsUTI As clsUTI = New clsUTI(array, Me.NodeTreeRootIndex(node))
                    Dim frmUTIEditor As frmUTI_Editor = New frmUTI_Editor(clsUTI, Me.NodeTreeRootIndex(node), False, "")
                    frmUTIEditor.EditingFilePath = frmMain.CurrentSettings.defaultSaveLocation & "\" & node.Text
                    frmUTIEditor.Show()

                ElseIf StringType.StrCmp(resTypeStr, "utm", False) = 0 Then
                    Dim clsUTM As clsUTM = New clsUTM(array, Me.NodeTreeRootIndex(node))
                    Dim frmUTMEditor As frmUTM_Editor = New frmUTM_Editor(clsUTM, Me.NodeTreeRootIndex(node), False, "")
                    frmUTMEditor.EditingFilePath = frmMain.CurrentSettings.defaultSaveLocation & "\" & node.Text
                    frmUTMEditor.Show()

                ElseIf StringType.StrCmp(resTypeStr, "utp", False) = 0 Then
                    Dim clsUTP As clsUTP = New clsUTP(array, Me.NodeTreeRootIndex(node))
                    Dim frmUTPEditor As frmUTP_Editor = New frmUTP_Editor(clsUTP, Me.NodeTreeRootIndex(node), False, "")
                    frmUTPEditor.EditingFilePath = frmMain.CurrentSettings.defaultSaveLocation & "\" & node.Text
                    frmUTPEditor.Show()

                ElseIf StringType.StrCmp(resTypeStr, "uts", False) = 0 Then
                    Dim clsUTS As clsUTS = New clsUTS(array, Me.NodeTreeRootIndex(node))
                    Dim frmUTSEditor As frmUTS_Editor = New frmUTS_Editor(clsUTS, Me.NodeTreeRootIndex(node), False, "")
                    frmUTSEditor.EditingFilePath = frmMain.CurrentSettings.defaultSaveLocation & "\" & node.Text
                    frmUTSEditor.Show()

                ElseIf StringType.StrCmp(resTypeStr, "utt", False) = 0 Then
                    Dim clsUTT As clsUTT = New clsUTT(array, Me.NodeTreeRootIndex(node))
                    Dim frmUTTEditor As frmUTT_Editor = New frmUTT_Editor(clsUTT, Me.NodeTreeRootIndex(node), False, "")
                    frmUTTEditor.EditingFilePath = frmMain.CurrentSettings.defaultSaveLocation & "\" & node.Text
                    frmUTTEditor.Show()

                ElseIf StringType.StrCmp(resTypeStr, "utw", False) = 0 Then
                    Dim clsUTW As clsUTW = New clsUTW(array, Me.NodeTreeRootIndex(node))
                    Dim frmUTWEditor As frmUTW_Editor = New frmUTW_Editor(clsUTW, Me.NodeTreeRootIndex(node), False, "")
                    frmUTWEditor.EditingFilePath = frmMain.CurrentSettings.defaultSaveLocation & "\" & node.Text
                    frmUTWEditor.Show()

                ElseIf StringType.StrCmp(resTypeStr, "tpc", False) = 0 OrElse StringType.StrCmp(resTypeStr, "txb", False) = 0 Then
                    If Control.ModifierKeys = Keys.Shift Then
                        Me.EditTPCResource(node.Filename, array)
                    Else
                        Me.ShowImage(node)
                    End If
                ElseIf StringType.StrCmp(resTypeStr, "tga", False) = 0 Then
                    Me.OpenTGAInExternalViewer(node.Filename, array)
                ElseIf StringType.StrCmp(resTypeStr, "dlg", False) = 0 Then
                    Dim frmDialogEditor As frmDialogEditor = New frmDialogEditor(array, node.ResRef, Me.NodeTreeRootIndex(node))
                    frmDialogEditor.Show()
                ElseIf StringType.StrCmp(resTypeStr, "ssf", False) = 0 Then
                    Dim clsSSF As clsSSF = New clsSSF(array, Me.NodeTreeRootIndex(node))
                    Dim frmSSFEditor As frmSSFEditor = New frmSSFEditor(clsSSF)
                    Dim num6 As Integer = 0
                    Do
                        'Console.WriteLine(String.Concat(New String() {"Index: ", StringType.FromInteger(num6), "  StringRef: ", StringType.FromInteger(clsSSF.get_RefArray(num6)), "  SoundResRef: '", clsSSF.get_RefArraySoundResRef(num6)}) + "'  String: '" + clsSSF.get_RefArrayString(num6) + "'")
                        Console.WriteLine(
                                "Index: " & num6.ToString() &
                                "  StringRef: " & clsSSF.RefArray(num6).ToString() &
                                "  SoundResRef: '" & clsSSF.RefArraySoundResRef(num6) &
                                "'  String: '" & clsSSF.RefArrayString(num6) & "'"
                            )
                        num6 += 1
                    Loop While num6 <= 39
                    frmSSFEditor.ShowDialog()
                End If
            End If
IL_12BE:
            Cursor.Current = cursor
        End Sub

        ' Token: 0x06000733 RID: 1843 RVA: 0x00256988 File Offset: 0x00255988
        'Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs)
        '    If e.Node.[GetType]() = "System.Windows.Form.TreeNode" Then
        '        Return
        '    End If
        '    Dim kotorTreeNode As KotorTreeNode = CType(e.Node, KotorTreeNode)
        '    If ((Me.NodeTreeRootIndex(kotorTreeNode) = 0) And Me.hasK1) OrElse ((Me.NodeTreeRootIndex(kotorTreeNode) = 1) And Me.hasK2) Then
        '        If kotorTreeNode.Parent Is Nothing OrElse kotorTreeNode.Tag Is Nothing Then
        '            Me.miExtract.Enabled = False
        '            Me.btnExtract.Enabled = False
        '            Me.btnHexViewer.Enabled = False
        '            Return
        '        End If
        '        Me.btnExtractForModuleEditing.Enabled = False
        '        Dim tag As Object = kotorTreeNode.Tag
        '        If ObjectType.ObjTst(tag, "RIM_Modules", False) = 0 OrElse ObjectType.ObjTst(tag, "RIM_Rims", False) = 0 OrElse ObjectType.ObjTst(tag, "ERF_Root", False) = 0 OrElse ObjectType.ObjTst(tag, "ERF_TexturePacks", False) = 0 OrElse ObjectType.ObjTst(tag, "ERF_Modules", False) = 0 OrElse ObjectType.ObjTst(tag, "globalvar", False) = 0 Then
        '            Me.miExtract.Enabled = False
        '            Me.btnExtract.Enabled = False
        '            Me.btnHexViewer.Enabled = False
        '        Else
        '            Me.miExtract.Enabled = True
        '            Me.btnExtract.Enabled = True
        '            Me.btnHexViewer.Enabled = True
        '            Dim tag2 As Object = kotorTreeNode.Tag
        '            If ObjectType.ObjTst(tag2, "BIFF", False) = 0 Then
        '                Me.btnExtract.Text = "Extract entire BIFF file"
        '            ElseIf ObjectType.ObjTst(tag2, "RIM", False) = 0 Then
        '                Me.btnExtract.Text = "Extract entire RIM file"
        '                If ObjectType.ObjTst(kotorTreeNode.Tag, "RIM", False) = 0 AndAlso ObjectType.ObjTst(kotorTreeNode.Parent.Tag, "RIM_Modules", False) = 0 Then
        '                    If Not kotorTreeNode.Filename.Replace(".rim", "").EndsWith("_s") Then
        '                        Me.btnExtractForModuleEditing.Enabled = True
        '                    End If
        '                End If
        '            ElseIf ObjectType.ObjTst(tag2, "ERF", False) = 0 Then
        '                Me.btnExtract.Text = "Extract entire ERF file"
        '            ElseIf ObjectType.ObjTst(tag2, "BIFF_Res", False) = 0 OrElse ObjectType.ObjTst(tag2, "RIM_Res", False) = 0 OrElse ObjectType.ObjTst(tag2, "ERF_Res", False) = 0 Then
        '                Me.btnExtract.Text = "Extract file"
        '            ElseIf ObjectType.ObjTst(tag2, "NodeCategory", False) = 0 Then
        '                Dim containingFileType As String = CType(kotorTreeNode.Parent, KotorTreeNode).ContainingFileType
        '                If StringType.StrCmp(containingFileType, "BIF", False) = 0 Then
        '                    Me.btnExtract.Text = "Extract entire BIFF subtype"
        '                ElseIf StringType.StrCmp(containingFileType, "rim", False) = 0 Then
        '                    Me.btnExtract.Text = "Extract entire RIM subtype"
        '                End If
        '            End If
        '        End If
        '    End If
        'End Sub

        Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles TreeView.AfterSelect
            If e Is Nothing OrElse e.Node Is Nothing Then
                Return
            End If

            If Not TypeOf e.Node Is KotorTreeNode Then
                Return
            End If

            Dim kotorTreeNode As KotorTreeNode = CType(e.Node, KotorTreeNode)
            Me.PopulateResourceBrowserFromNode(kotorTreeNode)

            If ((Me.NodeTreeRootIndex(kotorTreeNode) = 0) AndAlso Me.hasK1) OrElse
               ((Me.NodeTreeRootIndex(kotorTreeNode) = 1) AndAlso Me.hasK2) Then

                If kotorTreeNode.Parent Is Nothing OrElse kotorTreeNode.Tag Is Nothing Then
                    Me.miExtract.Enabled = False
                    Me.btnExtract.Enabled = False
                    Me.btnHexViewer.Enabled = False
                    Me.btnExtractForModuleEditing.Enabled = False
                    Return
                End If

                Me.btnExtractForModuleEditing.Enabled = False

                Dim tag As Object = kotorTreeNode.Tag

                If ObjectType.ObjTst(tag, "RIM_Modules", False) = 0 OrElse
                   ObjectType.ObjTst(tag, "RIM_Rims", False) = 0 OrElse
                   ObjectType.ObjTst(tag, "ERF_Root", False) = 0 OrElse
                   ObjectType.ObjTst(tag, "ERF_TexturePacks", False) = 0 OrElse
                   ObjectType.ObjTst(tag, "ERF_Modules", False) = 0 OrElse
                   ObjectType.ObjTst(tag, "globalvar", False) = 0 Then

                    Me.miExtract.Enabled = False
                    Me.btnExtract.Enabled = False
                    Me.btnHexViewer.Enabled = False
                    Return
                End If

                Me.miExtract.Enabled = True
                Me.btnExtract.Enabled = True
                Me.btnHexViewer.Enabled = True

                Dim tag2 As Object = kotorTreeNode.Tag

                If ObjectType.ObjTst(tag2, "BIFF", False) = 0 Then
                    Me.btnExtract.Text = "Extract entire BIFF file"

                ElseIf ObjectType.ObjTst(tag2, "RIM", False) = 0 Then
                    Me.btnExtract.Text = "Extract entire RIM file"

                    If kotorTreeNode.Parent IsNot Nothing AndAlso
                       kotorTreeNode.Filename IsNot Nothing AndAlso
                       ObjectType.ObjTst(kotorTreeNode.Tag, "RIM", False) = 0 AndAlso
                       ObjectType.ObjTst(kotorTreeNode.Parent.Tag, "RIM_Modules", False) = 0 Then

                        If Not kotorTreeNode.Filename.Replace(".rim", "").EndsWith("_s") Then
                            Me.btnExtractForModuleEditing.Enabled = True
                        End If
                    End If

                ElseIf ObjectType.ObjTst(tag2, "ERF", False) = 0 Then
                    Me.btnExtract.Text = "Extract entire ERF file"

                ElseIf ObjectType.ObjTst(tag2, "BIFF_Res", False) = 0 OrElse
                       ObjectType.ObjTst(tag2, "RIM_Res", False) = 0 OrElse
                       ObjectType.ObjTst(tag2, "ERF_Res", False) = 0 Then

                    Me.btnExtract.Text = "Extract file"

                ElseIf ObjectType.ObjTst(tag2, "NodeCategory", False) = 0 Then
                    Dim containingFileType As String = CType(kotorTreeNode.Parent, KotorTreeNode).ContainingFileType

                    If StringType.StrCmp(containingFileType, "BIF", False) = 0 Then
                        Me.btnExtract.Text = "Extract entire BIFF subtype"
                    ElseIf StringType.StrCmp(containingFileType, "rim", False) = 0 Then
                        Me.btnExtract.Text = "Extract entire RIM subtype"
                    End If
                End If
            End If
        End Sub

        ' Token: 0x06000734 RID: 1844 RVA: 0x00256C40 File Offset: 0x00255C40
        Private Sub AddNodeChildrenToTreePaths(ByVal node As KotorTreeNode, ByVal arTreeOpenPaths As ArrayList)
            Try
                For Each obj As Object In node.Nodes
                    Dim kotorTreeNode As KotorTreeNode = CType(obj, KotorTreeNode)
                    If kotorTreeNode.IsExpanded Then
                        If Not arTreeOpenPaths.Contains(kotorTreeNode.FullPath) Then
                            arTreeOpenPaths.Add(kotorTreeNode.FullPath)
                        End If
                        Me.AddNodeChildrenToTreePaths(kotorTreeNode, arTreeOpenPaths)
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        ' Token: 0x06000735 RID: 1845 RVA: 0x00256CC0 File Offset: 0x00255CC0
        Private Sub TreeView_BeforeExpand(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles TreeView.BeforeExpand
            Dim kotorTreeNode As KotorTreeNode = CType(e.Node, KotorTreeNode)
            frmMain.CurrentSettings = UserSettings.GetSettings()
            If Not frmMain.CurrentSettings.TreeOpenPaths.Contains(kotorTreeNode.FullPath) Then
                frmMain.CurrentSettings.TreeOpenPaths.Add(kotorTreeNode.FullPath)
            End If
            Me.AddNodeChildrenToTreePaths(kotorTreeNode, frmMain.CurrentSettings.TreeOpenPaths)
            UserSettings.SaveSettings(frmMain.CurrentSettings)
            Dim tag As Object = kotorTreeNode.Tag
            If ObjectType.ObjTst(tag, "BIFF_Root", False) = 0 Then
                If ObjectType.ObjTst(kotorTreeNode.Nodes(0).Tag, "dummy", False) = 0 Then
                    Me.BuildTreeView(CType(kotorTreeNode.Parent, KotorTreeNode), False)
                End If
            ElseIf ObjectType.ObjTst(tag, "RIM_Modules", False) = 0 Then
                If ObjectType.ObjTst(kotorTreeNode.Nodes(0).Tag, "dummy", False) = 0 Then
                    Me.ScanForRIMSandBuildTree(kotorTreeNode, "modules")
                    kotorTreeNode.Nodes(0).Remove()
                End If
            ElseIf ObjectType.ObjTst(tag, "RIM_Rims", False) = 0 Then
                If ObjectType.ObjTst(kotorTreeNode.Nodes(0).Tag, "dummy", False) = 0 Then
                    Me.ScanForRIMSandBuildTree(kotorTreeNode, "rims")
                    kotorTreeNode.Nodes(0).Remove()
                End If
            ElseIf ObjectType.ObjTst(tag, "RIM", False) = 0 Then
                If ObjectType.ObjTst(kotorTreeNode.Nodes(0).Tag, "dummy", False) = 0 Then
                    Dim text As String = kotorTreeNode.FilePath + "\" + kotorTreeNode.Filename
                    Me.ReadRIMentries(text, kotorTreeNode)
                    kotorTreeNode.Nodes(0).Remove()
                End If
            ElseIf ObjectType.ObjTst(tag, "ERF_TexturePacks", False) = 0 Then
                If ObjectType.ObjTst(kotorTreeNode.Nodes(0).Tag, "dummy", False) = 0 Then
                    Me.ScanForERFsAndBuildTree(kotorTreeNode, "texturePacks")
                    kotorTreeNode.Nodes(0).Remove()
                End If
            ElseIf ObjectType.ObjTst(tag, "ERF_Modules", False) = 0 Then
                If ObjectType.ObjTst(kotorTreeNode.Nodes(0).Tag, "dummy", False) = 0 Then
                    Me.ScanForERFsAndBuildTree(kotorTreeNode, "modules")
                    kotorTreeNode.Nodes(0).Remove()
                Else
                    kotorTreeNode.Nodes.Clear()
                    Me.ScanForERFsAndBuildTree(kotorTreeNode, "modules")
                End If
            ElseIf ObjectType.ObjTst(tag, "ERF", False) = 0 Then
                If ObjectType.ObjTst(kotorTreeNode.Nodes(0).Tag, "dummy", False) = 0 Then
                    Dim text As String = kotorTreeNode.FilePath + "\" + kotorTreeNode.Filename
                    Me.ReadERFentries(text, kotorTreeNode)
                    kotorTreeNode.Nodes(0).Remove()
                End If
            ElseIf ObjectType.ObjTst(tag, "Saves_Root", False) = 0 Then
                If ObjectType.ObjTst(kotorTreeNode.Nodes(0).Tag, "dummy", False) = 0 Then
                    Dim text As String = kotorTreeNode.FilePath
                    Me.ScanForSavesAndBuildTree(text, kotorTreeNode)
                    kotorTreeNode.Nodes(0).Remove()
                Else
                    kotorTreeNode.Nodes.Clear()
                    Dim text As String = kotorTreeNode.FilePath
                    Me.ScanForSavesAndBuildTree(text, kotorTreeNode)
                End If
            End If
        End Sub

        ' Token: 0x06000736 RID: 1846 RVA: 0x00257014 File Offset: 0x00256014
        Private Sub TreeView_BeforeCollapse(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles TreeView.BeforeCollapse
            Dim kotorTreeNode As KotorTreeNode = CType(e.Node, KotorTreeNode)
            frmMain.CurrentSettings = UserSettings.GetSettings()
            For i As Integer = frmMain.CurrentSettings.TreeOpenPaths.Count - 1 To 0 Step -1
                If BooleanType.FromObject(If((BooleanType.FromObject(LateBinding.LateGet(frmMain.CurrentSettings.TreeOpenPaths(i), Nothing, "StartsWith", New Object() {kotorTreeNode.FullPath + "\"}, Nothing, Nothing)) OrElse BooleanType.FromObject(ObjectType.ObjTst(frmMain.CurrentSettings.TreeOpenPaths(i), kotorTreeNode.FullPath, False) = 0)), True, False)) Then
                    frmMain.CurrentSettings.TreeOpenPaths.RemoveAt(i)
                End If
            Next
            UserSettings.SaveSettings(frmMain.CurrentSettings)
        End Sub

        ' Token: 0x06000737 RID: 1847 RVA: 0x002570F4 File Offset: 0x002560F4
        Private Sub TreeView_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TreeView.KeyUp
            Dim resTypeStr As String = CType(Me.TreeView.SelectedNode, KotorTreeNode).ResTypeStr
            If (StringType.StrCmp(resTypeStr, "tpc", False) = 0) Or (StringType.StrCmp(resTypeStr, "txb", False) = 0) Then
                If frmMain.gImageViewer IsNot Nothing AndAlso frmMain.gImageViewer.Created AndAlso frmMain.gImageViewer.Visible Then
                    If (e.KeyCode = Keys.Up) Or (e.KeyCode = Keys.Down) Then
                        Me.ShowImage(CType(Me.TreeView.SelectedNode, KotorTreeNode))
                    End If
                ElseIf e.KeyCode = Keys.Space Then
                    Me.ShowImage(CType(Me.TreeView.SelectedNode, KotorTreeNode))
                End If
            End If
        End Sub

        ' Token: 0x06000738 RID: 1848 RVA: 0x002571A8 File Offset: 0x002561A8
        Private Sub TreeView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TreeView.MouseDown
            Dim point As Point = New Point(e.X, e.Y)
            Dim point2 As Point = point
            Me.SecondToLastClickedTVNode = Me.LastClickedTVNode
            Me.LastClickedTVNode = CType(Me.TreeView.GetNodeAt(point2), KotorTreeNode)
            If Me.LastClickedTVNode IsNot Nothing Then
                Me.TreeView.SelectedNode = Me.LastClickedTVNode
                frmMain.CurrentSettings = UserSettings.GetSettings()
                frmMain.CurrentSettings.LastClickedTVNodePath = Me.LastClickedTVNode.FullPath
                UserSettings.SaveSettings(frmMain.CurrentSettings)
            End If
            If Control.MouseButtons = MouseButtons.Right AndAlso Me.LastClickedTVNode IsNot Nothing AndAlso ObjectType.ObjTst(Me.LastClickedTVNode.Tag, "RIM", False) = 0 AndAlso ObjectType.ObjTst(Me.LastClickedTVNode.Parent.Tag, "RIM_Modules", False) = 0 AndAlso Not Me.LastClickedTVNode.Filename.Replace(".rim", "").EndsWith("_s") Then
                Me.tvCMenu.Show(CType(sender, TreeView), Me.TreeView.PointToClient(Control.MousePosition))
            End If
        End Sub

        ' Token: 0x06000739 RID: 1849 RVA: 0x002572C4 File Offset: 0x002562C4
        Private Sub TreeView_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TreeView.KeyPress
            If e.KeyChar = vbCr AndAlso Me.TreeView.SelectedNode IsNot Nothing Then
                e.Handled = True
                Dim kotorTreeNode As KotorTreeNode = CType(Me.TreeView.SelectedNode, KotorTreeNode)
                Me.HandleDataByNodeType(kotorTreeNode, RuntimeHelpers.GetObjectValue(sender))
            End If
        End Sub

        ' Token: 0x0600073A RID: 1850 RVA: 0x00257310 File Offset: 0x00256310
        Private Function CurrentTreeRootIndex() As Integer
            Dim text As String = Me.LastClickedTVNode.FullPath.ToLower()
            Dim text2 As String = text
            If StringType.StrCmp(text2, "kotor i", False) = 0 Then
                Return 0
            End If
            If StringType.StrCmp(text2, "kotor ii", False) = 0 Then
                Return 1
            End If
            Dim text3 As String = text.Substring(0, text.IndexOf(Me.TreeView.PathSeparator)).ToLower()
            If StringType.StrCmp(text3, "kotor i", False) = 0 Then
                Return 0
            End If
            If StringType.StrCmp(text3, "kotor ii", False) = 0 Then
                Return 1
            End If
            Dim num As Integer
            Return num
        End Function

        ' Token: 0x0600073B RID: 1851 RVA: 0x00257394 File Offset: 0x00256394
        Private Function CurrentTreeRoot() As KotorTreeNode
            Return CType(Me.TreeView.Nodes(Me.CurrentTreeRootIndex()), KotorTreeNode)
        End Function

        ' Token: 0x0600073C RID: 1852 RVA: 0x002573BC File Offset: 0x002563BC
        Private Function NodeTreeRootIndex(ByVal node As KotorTreeNode) As Integer
            Dim num As Integer
            Try
                Dim text As String = node.FullPath.ToLower()
                Dim text2 As String = text
                If StringType.StrCmp(text2, "kotor i", False) = 0 Then
                    num = 0
                ElseIf StringType.StrCmp(text2, "kotor ii", False) = 0 Then
                    num = 1
                Else
                    Dim text3 As String = text.Substring(0, text.IndexOf(Me.TreeView.PathSeparator)).ToLower()
                    If StringType.StrCmp(text3, "kotor i", False) = 0 Then
                        num = 0
                    ElseIf StringType.StrCmp(text3, "kotor ii", False) = 0 Then
                        num = 1
                    End If
                End If
            Catch ex As System.Exception
                If node Is Nothing Then
                    num = -1
                Else
                    num = node.KotorVerIndex
                End If
            End Try
            Return num
        End Function

        ' Token: 0x0600073D RID: 1853 RVA: 0x00257478 File Offset: 0x00256478
        Private Function NodeTreeRoot(ByVal node As KotorTreeNode) As KotorTreeNode
            Return CType(Me.TreeView.Nodes(Me.NodeTreeRootIndex(node)), KotorTreeNode)
        End Function

        ' Token: 0x0600073E RID: 1854 RVA: 0x002574A4 File Offset: 0x002564A4
        Private Sub miManagePaths_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miManagePaths.Click
            Dim frmPathManager As frmPathManager = New frmPathManager()
            frmPathManager.ShowDialog(Me)
        End Sub

        ' Token: 0x0600073F RID: 1855 RVA: 0x002574C0 File Offset: 0x002564C0
        'Private Sub miOpenGFFFile_Click(ByVal sender As Object, ByVal e As EventArgs)
        '    Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultImportLocation, "", "Open GFF files...", "gffsupported", True, True))
        '    If objectValue.[GetType]() Is GetType(String) Then
        '        Return
        '    End If
        '    Dim array As String() = CType(objectValue, String())
        '    Dim num As Integer = 0
        '    Dim num2 As Integer = array.Length - 1
        '    For i As Integer = num To num2
        '        Me.OpenGFFFileInEditor(array(i), i * 20)
        '    Next
        'End Sub

        Private Sub miOpenGFFFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenGFFFile.Click
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultImportLocation, "", "Open GFF files...", "gffsupported", True, True))

            If TypeOf objectValue Is String Then
                Return
            End If

            Dim array As String() = CType(objectValue, String())
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1

            For i As Integer = num To num2
                Me.OpenGFFFileInEditor(array(i), i * 20)
            Next
        End Sub

        ' Token: 0x06000740 RID: 1856 RVA: 0x00257540 File Offset: 0x00256540
        'Private Sub miViewGFFFile_Click(ByVal sender As Object, ByVal e As EventArgs)
        '    Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultImportLocation, "", "Open GFF files...", "", True, True))
        '    If objectValue.[GetType]() Is GetType(String) Then
        '        Return
        '    End If
        '    Dim array As String() = CType(objectValue, String())
        '    Dim num As Integer = 0
        '    Dim num2 As Integer = array.Length - 1
        '    For i As Integer = num To num2
        '        Dim gfffileKotorVersionIndex As Integer = frmMain.GetGFFFileKotorVersionIndex(array(i))
        '        Dim fileStream As FileStream = New FileStream(array(i), FileMode.Open, FileAccess.Read)
        '        Dim clsGFF As clsGFF = New clsGFF(gfffileKotorVersionIndex)
        '        clsGFF.RTFMode = False
        '        clsGFF.Parse(fileStream)
        '        Dim frmTextEditor As frmTextEditor = New frmTextEditor()
        '        frmTextEditor.Filename = Path.GetFileName(array(i))
        '        frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename
        '        frmTextEditor.RTFMode = True
        '        frmTextEditor.tbGeneric.Text = clsGFF.ToString()
        '        frmTextEditor.tbGeneric.SelectionLength = 0
        '        frmTextEditor.Show()
        '        Dim control As Control = frmTextEditor
        '        Dim point As Point = New Point(frmTextEditor.Location.X + i * 20, frmTextEditor.Location.Y + i * 20)
        '        control.Location = point
        '    Next
        'End Sub

        Private Sub miViewGFFFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miViewGFFFiles.Click
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", frmMain.CurrentSettings.defaultImportLocation, "", "Open GFF files...", "", True, True))

            If TypeOf objectValue Is String Then
                Return
            End If

            Dim array As String() = CType(objectValue, String())
            Dim num As Integer = 0
            Dim num2 As Integer = array.Length - 1

            For i As Integer = num To num2
                Dim gfffileKotorVersionIndex As Integer = frmMain.GetGFFFileKotorVersionIndex(array(i))
                Dim fileStream As FileStream = New FileStream(array(i), FileMode.Open, FileAccess.Read)

                Dim clsGFF As clsGFF = New clsGFF(gfffileKotorVersionIndex)
                clsGFF.RTFMode = False
                clsGFF.Parse(fileStream)

                Dim frmTextEditor As frmTextEditor = New frmTextEditor()
                frmTextEditor.Filename = Path.GetFileName(array(i))
                frmTextEditor.Text = "Text Editor - " & frmTextEditor.Filename
                frmTextEditor.RTFMode = True
                frmTextEditor.tbGeneric.Text = clsGFF.ToString()
                frmTextEditor.tbGeneric.SelectionLength = 0
                frmTextEditor.Show()

                Dim point As Point = New Point(frmTextEditor.Location.X + i * 20, frmTextEditor.Location.Y + i * 20)
                frmTextEditor.Location = point

                fileStream.Close()
            Next
        End Sub

        ' Token: 0x06000741 RID: 1857 RVA: 0x00257670 File Offset: 0x00256670
        Private Sub miRecentFiles_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim text As String = StringType.FromObject(frmMain.CurrentSettings.MRUMainFiles(CType(sender, MenuItem).Index))
            Console.WriteLine(text)
            Me.OpenGFFFileInEditor(text, -1)
        End Sub

        ' Token: 0x06000742 RID: 1858 RVA: 0x002576AC File Offset: 0x002566AC
        Private Sub miQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miQuit.Click
            frmMain.SaveSettings()
            Application.[Exit]()
        End Sub

        ' Token: 0x06000743 RID: 1859 RVA: 0x002576B8 File Offset: 0x002566B8
        '     Private Sub miOpenMapsFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
        'New Process() With { .StartInfo = { .FileName = "explorer.exe ", .Arguments = frmMain.gRootPath + "maps" } }.Start()
        '     End Sub

        Private Sub miOpenMapsFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenMapsFolder.Click
            Dim process As Process = New Process()
            process.StartInfo.FileName = "explorer.exe"
            process.StartInfo.Arguments = """" & frmMain.gRootPath & "maps" & """"
            process.Start()
        End Sub

        ' Token: 0x06000744 RID: 1860 RVA: 0x002576FC File Offset: 0x002566FC
        Private Sub miOpenModuleEditor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenModuleEditor.Click
            Dim frmModule_Editor As frmModule_Editor = New frmModule_Editor()
            frmModule_Editor.Show()
        End Sub

        ' Token: 0x06000745 RID: 1861 RVA: 0x00257718 File Offset: 0x00256718
        Private Sub miShowSupportedModEditorMaps_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miShowSupportedModEditorMaps.Click
            Dim frmMapInfoStatus As frmMapInfoStatus = New frmMapInfoStatus()
            frmMapInfoStatus.ShowDialog()
        End Sub

        ' Token: 0x06000746 RID: 1862 RVA: 0x00257734 File Offset: 0x00256734
        Private Sub miOpenSSFEditor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenSSFEditor.Click
            Dim frmSSFEditor As frmSSFEditor = New frmSSFEditor()
            frmSSFEditor.Show()
        End Sub

        ' Token: 0x06000747 RID: 1863 RVA: 0x00257750 File Offset: 0x00256750
        Private Sub miOpenProjectManager_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenProjectManager.Click
            Dim frmProjectManager As frmProjectManager = New frmProjectManager(Me)
            frmProjectManager.Show()
        End Sub

        ' Token: 0x06000748 RID: 1864 RVA: 0x0025776C File Offset: 0x0025676C
        Private Sub miOpen2DAFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpen2DAEditor.Click
            Me.Open2DAFileEditor()
        End Sub

        ' Token: 0x06000749 RID: 1865 RVA: 0x00257774 File Offset: 0x00256774
        Private Sub miConversationEditor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miConversationEditor.Click
            Me.OpenConversationEditor()
        End Sub

        ' Token: 0x0600074A RID: 1866 RVA: 0x0025777C File Offset: 0x0025677C
        Private Sub miGlobalVariableEditor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miGlobalVariableEditor.Click
            Dim frmGlobalVar_Editor As frmGlobalVar_Editor = New frmGlobalVar_Editor()
            Dim utilWindowRelativePositioner As utilWindowRelativePositioner = New utilWindowRelativePositioner(frmMain.mainform, frmGlobalVar_Editor)
            utilWindowRelativePositioner.SetLocationConcentric()
            frmGlobalVar_Editor.Show()
        End Sub

        ' Token: 0x0600074B RID: 1867 RVA: 0x002577A8 File Offset: 0x002567A8
        Private Sub miOpenTextEditor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenTextEditor.Click
            Me.OpenTextEditor()
        End Sub

        ' Token: 0x0600074C RID: 1868 RVA: 0x002577B0 File Offset: 0x002567B0
        Private Sub miOpenERFBuilder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenERFBuilder.Click
            Me.OpenERFBuilder()
        End Sub

        ' Token: 0x0600074D RID: 1869 RVA: 0x002577B8 File Offset: 0x002567B8
        Private Sub miOpenPWKEditor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenPWKEditor.Click
            Dim frmBWMEditor As frmBWMEditor = New frmBWMEditor()
            frmBWMEditor.Show()
        End Sub

        ' Token: 0x0600074E RID: 1870 RVA: 0x002577D4 File Offset: 0x002567D4
        Private Sub miOpenDialogTlkViewer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenDialogTlkViewer.Click
            Dim frmDialogTlk As frmDialogTlk = New frmDialogTlk()
            frmDialogTlk.Show()
        End Sub

        ' Token: 0x0600074F RID: 1871 RVA: 0x002577F0 File Offset: 0x002567F0
        Private Sub miRefSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miRefSearch.Click
            Me.PerformStringSearch()
        End Sub

        ' Token: 0x06000750 RID: 1872 RVA: 0x002577F8 File Offset: 0x002567F8
        Private Sub miCleanWorkingDir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCleanWorkingDir.Click
            If Interaction.MsgBox("Are you sure you want to delete all of the files in your working directory?", MsgBoxStyle.OkCancel Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "Clean working directory") = MsgBoxResult.Ok Then
                frmMain.CleanDirectory(frmMain.gRootPath + "working")
            End If
        End Sub

        ' Token: 0x06000751 RID: 1873 RVA: 0x00257828 File Offset: 0x00256828
        '     Private Sub miOpenWorkingDir_Click(ByVal sender As Object, ByVal e As EventArgs)
        'New Process() With { .StartInfo = { .FileName = "explorer.exe ", .Arguments = frmMain.gRootPath + "working" } }.Start()
        '     End Sub

        Private Sub miOpenWorkingDir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOpenWorkingDir.Click
            Dim process As Process = New Process()
            process.StartInfo.FileName = "explorer.exe"
            process.StartInfo.Arguments = """" & frmMain.gRootPath & "working" & """"
            process.Start()
        End Sub

        ' Token: 0x06000752 RID: 1874 RVA: 0x0025786C File Offset: 0x0025686C
        Private Sub miOptions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miOptions.Click
            Dim frmOptions As frmOptions = New frmOptions()
            frmMain.CurrentSettings = UserSettings.GetSettings()
            Dim bBuildModelsBifNode As Boolean = frmMain.CurrentSettings.bBuildModelsBifNode
            Dim bShowModuleDescriptions As Boolean = frmMain.CurrentSettings.bShowModuleDescriptions
            Dim bShowModuleLocations As Boolean = frmMain.CurrentSettings.bShowModuleLocations
            frmOptions.ShowDialog(Me)
            frmMain.CurrentSettings = UserSettings.GetSettings()
            If Not bBuildModelsBifNode And (frmMain.CurrentSettings.bBuildModelsBifNode <> bBuildModelsBifNode) Then
                Me.TreeView.Nodes.Clear()
                Me.SetupTreeRoots()
                MessageBox.Show("Models node added; Treeview rebuilt", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            Dim num As Integer = 0
            Do
                If Me.TreeView.Nodes(num).Nodes.Count > 0 AndAlso ObjectType.ObjTst(Me.TreeView.Nodes(num).Nodes(1).Nodes(0).Nodes(0).Tag, "dummy", False) <> 0 AndAlso ((frmMain.CurrentSettings.bShowModuleDescriptions <> bShowModuleDescriptions) Or (frmMain.CurrentSettings.bShowModuleLocations <> bShowModuleLocations)) Then
                    Dim isExpanded As Boolean = Me.TreeView.Nodes(num).Nodes(1).Nodes(0).IsExpanded
                    Me.TreeView.Nodes(num).Nodes(1).Nodes(0).Collapse()
                    Me.TreeView.Nodes(num).Nodes(1).Nodes(0).Nodes.Clear()
                    Dim kotorTreeNode As KotorTreeNode = New KotorTreeNode()
                    kotorTreeNode.Tag = "dummy"
                    Me.TreeView.Nodes(num).Nodes(1).Nodes(0).Nodes.Add(kotorTreeNode)
                    If isExpanded Then
                        Me.TreeView.Nodes(num).Nodes(1).Nodes(0).Expand()
                    End If
                End If
                num += 1
            Loop While num <= 1
        End Sub

        ' Token: 0x06000753 RID: 1875 RVA: 0x00257AA8 File Offset: 0x00256AA8
        Private Sub miBasicHelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miBasicHelp.Click
            Try
                Process.Start(frmMain.gRootPath + "KT_Help.chm")
            Catch ex As System.Exception
                If StringType.StrCmp(ex.Message, "", False) <> 0 Then
                    Interaction.MsgBox("                      Error launching Help File" & vbCr & vbCr & "Is it installed in the same directory as this program?", MsgBoxStyle.OkOnly, Nothing)
                End If
            End Try
        End Sub

        ' Token: 0x06000754 RID: 1876 RVA: 0x00257B0C File Offset: 0x00256B0C
        Private Sub miCheckForUpdates_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miCheckForUpdates.Click
            Me.g_CheckForUpdatesSilently = False
            Dim checkForUpdate As frmMain.CheckForUpdate = AddressOf Me.CheckForUpdateA
            Console.WriteLine("Starting CheckForUpdate thread")
            checkForUpdate.BeginInvoke(Nothing, Nothing)
        End Sub

        ' Token: 0x06000755 RID: 1877 RVA: 0x00257B44 File Offset: 0x00256B44
        '     Private Sub miAbout_Click(ByVal sender As Object, ByVal e As EventArgs)
        'New frmAbout() With { .lblVersion = { .Text = "Version " + Application.ProductVersion } }.ShowDialog(Me)
        '     End Sub

        Private Sub miAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles miAbout.Click
            Dim frmAbout As frmAbout = New frmAbout()
            frmAbout.lblVersion.Text = "Version " & Application.ProductVersion
            frmAbout.ShowDialog(Me)
        End Sub

        ' Token: 0x06000756 RID: 1878 RVA: 0x00257B7C File Offset: 0x00256B7C
        Private Sub cmiExtractForModuleEditing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiExtractForModuleEditing.Click
            Dim mapInfo As MapInfo = frmMapInfoStatus.ReadMapInfoFile()
            Dim text As String = Path.GetFileNameWithoutExtension(CType(Me.TreeView.SelectedNode, KotorTreeNode).Filename).ToLower()
            Dim text2 As String = "Unsupported"
            Dim text3 As String = "Unsupported"
            Dim text5 As String
            If mapInfo IsNot Nothing Then
                Dim text4 As String = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\SCM\Kotor Tool").GetValue("path")), "maps\")
                Try
                    For Each obj As Object In mapInfo.MapList
                        Dim map As MapInfo.Map = CType(obj, MapInfo.Map)
                        If StringType.StrCmp(text, map.MapName, False) = 0 Then
                            If map.S Then
                                If File.Exists(text4 + "map" + map.MapName + ".map") Then
                                    text2 = "Available"
                                Else
                                    text2 = "Missing"
                                End If
                            End If
                            If map.L Then
                                If File.Exists(text4 + "map" + map.MapName + "_lg.map") Then
                                    text3 = "Available"
                                Else
                                    text3 = "Missing"
                                End If
                            End If
                        End If
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
                If StringType.StrCmp(text2, "Unsupported", False) = 0 AndAlso StringType.StrCmp(text3, "Unsupported", False) = 0 Then
                    text5 = "A map is not yet supported for this module." & vbLf & vbLf & "Do you want to proceed with the extraction?"
                ElseIf (StringType.StrCmp(text2, "Unsupported", False) = 0 AndAlso StringType.StrCmp(text3, "Missing", False) = 0) OrElse (StringType.StrCmp(text2, "Missing", False) = 0 AndAlso StringType.StrCmp(text3, "Unsupported", False) = 0) Then
                    text5 = "At least one map size is supported for this module, but none was found in your Kotor Tool 'maps' folder." & vbLf & vbLf & "Do you want to proceed with the extraction?"
                End If
            End If
            If StringType.StrCmp(text5, "", False) <> 0 AndAlso Interaction.MsgBox(text5, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Map support") = MsgBoxResult.No Then
                Return
            End If
            Dim kotorTreeNode As KotorTreeNode = CType(Me.TreeView.SelectedNode.NextNode, KotorTreeNode)
            Dim frmResourceTypeSelector As frmResourceTypeSelector = New frmResourceTypeSelector()
            If frmResourceTypeSelector.ShowDialog(Me) = DialogResult.Cancel Then
                Return
            End If
            Dim text6 As String = StringType.FromObject(frmMain.GetFilePath("", frmMain.CurrentSettings.ModuleExtractPath, "", "Select or create the folder to extract the module to...", "", False, False))
            If text6 IsNot Nothing Then
                If StringType.StrCmp(text6, "", False) = 0 Then
                    Return
                End If
                If Not text6.EndsWith("\") Then
                    text6 += "\"
                End If
                Me.ExtractSelectedKotorFile(CType(Me.TreeView.SelectedNode, KotorTreeNode), text6, "", frmResourceTypeSelector.SelectedResTypes)
                If StringType.StrCmp(frmMain.CurrentSettings.ModuleExtractPath, text6, False) <> 0 Then
                    frmMain.CurrentSettings.ModuleExtractPath = text6
                    UserSettings.SaveSettings(frmMain.CurrentSettings)
                End If
                Me.ExtractSelectedKotorFile(kotorTreeNode, text6, "", frmResourceTypeSelector.SelectedResTypes)
                Dim files As String() = Directory.GetFiles(text6, "*.git")
                Dim text7 As String
                If files.Length > 0 Then
                    text7 = files(0)
                End If
                If StringType.StrCmp(text7, "", False) <> 0 Then
                    Dim fileStream As FileStream = New FileStream(text7, FileMode.Open)
                    Dim clsGFF As clsGFF = New clsGFF(fileStream, Me.NodeTreeRootIndex(kotorTreeNode), True)
                    If Interaction.MsgBox("Would you like the .GIT file cleaned of all non-extracted entities?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes Then
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("utc")) Then
                            clsGFF.ClearListElements("Creature List")
                        End If
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("utd")) Then
                            clsGFF.ClearListElements("Door List")
                        End If
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("ute")) Then
                            clsGFF.ClearListElements("Encounter List")
                        End If
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("uti")) Then
                            clsGFF.ClearListElements("Item List")
                        End If
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("utm")) Then
                            clsGFF.ClearListElements("StoreList")
                        End If
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("utp")) Then
                            clsGFF.ClearListElements("Placeable List")
                        End If
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("uts")) Then
                            clsGFF.ClearListElements("SoundList")
                        End If
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("utt")) Then
                            clsGFF.ClearListElements("TriggerList")
                        End If
                        If Not frmResourceTypeSelector.SelectedResTypes.Contains(frmMain.GetIDForRsrcType("utw")) Then
                            clsGFF.ClearListElements("WaypointList")
                        End If
                    End If
                    clsGFF.WriteFile(text7, "GIT")
                End If
                If Interaction.MsgBox("Extraction complete." & vbLf & "Would you like the Module Editor to be set to open your extract location the next time you use it?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes Then
                    frmMain.CurrentSettings = UserSettings.GetSettings()
                    frmMain.CurrentSettings.LastModuleEditedPath = text6
                    UserSettings.SaveSettings(frmMain.CurrentSettings)
                End If
            End If
        End Sub


        ' -----------------------------------------------------------------
        ' Legacy ToolBar1 handler removed.
        '
        ' The original WinForms ToolBar/ToolBarButton system has been replaced
        ' by pnlToolBar and normal themed Button controls:
        '
        '   btnTool2DA
        '   btnToolConversation
        '   btnToolText
        '   btnToolERF
        '
        ' Click events are now wired by WireModernToolbar().
        ' -----------------------------------------------------------------

        ' Token: 0x06000757 RID: 1879 RVA: 0x00258040 File Offset: 0x00257040
        'Private Sub ToolBar1_ButtonClick(ByVal sender As Object, ByVal e As ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        '    If e.Button Is Me.tbbtn2DAEditor Then
        '        Me.Open2DAFileEditor()
        '    ElseIf e.Button Is Me.tbbtnConversationEditor Then
        '        Me.OpenConversationEditor()
        '    ElseIf e.Button Is Me.tbbtnERFBuilder Then
        '        Me.OpenERFBuilder()
        '    ElseIf e.Button Is Me.tbbtnTextEditor Then
        '        Me.OpenTextEditor()
        '    End If
        'End Sub

        ' Token: 0x06000758 RID: 1880 RVA: 0x002580A4 File Offset: 0x002570A4
        Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        ' Token: 0x06000759 RID: 1881 RVA: 0x002580A8 File Offset: 0x002570A8
        Private Sub SetAABBNode(ByRef node As frmMain.aabb, ByVal aabbArray As frmMain.aabb())
            If Me.g_abbbIndex > aabbArray.Length Then
                Return
            End If
            If node.face = -1 Then
                Me.g_abbbIndex += 1
                node.left = Me.g_abbbIndex
                Me.SetAABBNode(aabbArray(Me.g_abbbIndex), aabbArray)
                Me.g_abbbIndex += 1
                node.right = Me.g_abbbIndex
                Me.SetAABBNode(aabbArray(Me.g_abbbIndex), aabbArray)
            Else
                node.left = -1
                node.right = -1
            End If
        End Sub

        ' Token: 0x0600075A RID: 1882 RVA: 0x00258138 File Offset: 0x00257138
        Public Shared Function GetGFFTag(ByVal data As Byte()) As String
            Return frmMain.GetGFFRootStringField(data, "Tag")
        End Function

        ' Token: 0x0600075B RID: 1883 RVA: 0x00258150 File Offset: 0x00257150
        Public Shared Function GetGFFRootStringField(ByVal data As Byte(), ByVal FieldName As String) As String
            Dim stringBuilder As StringBuilder = New StringBuilder()
            Dim memoryStream As MemoryStream = New MemoryStream(data)
            Dim binaryReader As BinaryReader = New BinaryReader(memoryStream, Encoding.ASCII)
            memoryStream.Seek(8L, SeekOrigin.Begin)
            Dim num As Integer = binaryReader.ReadInt32()
            Dim num2 As Integer = binaryReader.ReadInt32()
            Dim num3 As Integer = binaryReader.ReadInt32()
            Dim num4 As Integer = binaryReader.ReadInt32()
            Dim num5 As Integer = binaryReader.ReadInt32()
            Dim num6 As Integer = binaryReader.ReadInt32()
            Dim num7 As Integer = binaryReader.ReadInt32()
            memoryStream.Seek(CLng((num + 8)), SeekOrigin.Begin)
            Dim num8 As Integer = binaryReader.ReadInt32()
            Dim num9 As Integer = 0
            Dim num10 As Integer = num8 - 1
            For i As Integer = num9 To num10

                ' The following expression was wrapped in a checked-expression
                memoryStream.Seek(CLng((num3 + i * 12)), SeekOrigin.Begin)
                Dim num11 As Integer = binaryReader.ReadInt32()
                If num11 = 10 Then
                    Dim num12 As Integer = binaryReader.ReadInt32()
                    Dim position As Long = binaryReader.BaseStream.Position
                    memoryStream.Seek(CLng((num5 + num12 * 16)), SeekOrigin.Begin)
                    stringBuilder.Length = 0
                    stringBuilder.Append(binaryReader.ReadChars(16))
                    Dim num13 As Integer = 0
                    Dim text As String
                    While Strings.Asc(stringBuilder(num13)) <> 0
                        num13 += 1
                        If num13 > 15 Then
                            Exit While
                        End If
                    End While
                    stringBuilder.Length = num13
                    text = stringBuilder.ToString()
                    If StringType.StrCmp(text.ToLower(), FieldName.ToLower(), False) = 0 Then
                        memoryStream.Seek(position, SeekOrigin.Begin)
                        Dim num14 As Integer = binaryReader.ReadInt32()
                        memoryStream.Seek(CLng((num7 + num14)), SeekOrigin.Begin)
                        Dim num15 As Integer = binaryReader.ReadInt32()
                        Dim array As Byte() = New Byte(num15 - 1 + 1 - 1) {}
                        Dim encoding As Encoding = Encoding.GetEncoding(1252)
                        array = binaryReader.ReadBytes(num15)
                        Return encoding.GetString(array)
                    End If
                End If

            Next
            Dim text2 As String
            Return text2
        End Function

        ' Token: 0x0600075C RID: 1884 RVA: 0x00258308 File Offset: 0x00257308
        Private Sub btnExtractForModuleEditing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExtractForModuleEditing.Click
            Me.cmiExtractForModuleEditing_Click(Nothing, Nothing)
        End Sub

        ' Token: 0x0600075D RID: 1885 RVA: 0x00258314 File Offset: 0x00257314
        Private Sub CreateTemplateTagsHashFiles()
            Dim hashtable As Hashtable = New Hashtable()
            Dim hashtable2 As Hashtable = New Hashtable()
            Dim hashtable3 As Hashtable = New Hashtable()
            Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
            hashtable.Add(2040, 0)
            hashtable.Add(2027, 0)
            hashtable.Add(2042, 0)
            hashtable.Add(2025, 0)
            hashtable.Add(2051, 0)
            hashtable.Add(2044, 0)
            hashtable.Add(2035, 0)
            hashtable.Add(2032, 0)
            hashtable.Add(2058, 0)
            If Me.hasK1 AndAlso Not File.Exists("K1TemplateTags.bfd") Then
                If ObjectType.ObjTst(Me.TreeView.Nodes(0).Nodes(0).Nodes(0).Tag, "dummy", False) = 0 Then
                    Cursor.Current = Cursors.WaitCursor
                    Me.BuildTreeView(CType(Me.TreeView.Nodes(0), KotorTreeNode), True)
                End If
                Try
                    For Each obj As Object In Me.BiffEntryListArray(0, 23)
                        Dim keyEntry As KeyEntry = CType(obj, KeyEntry)
                        If hashtable.ContainsKey(Convert.ToInt32(keyEntry.ResourceType)) Then
                            Dim data As Byte() = frmMain.K1TemplatesBif().getBIFFResource(keyEntry.ResID - (keyEntry.ResID >> 20 << 20)).data
                            Dim text As String = frmMain.GetGFFTag(data)
                            hashtable2.Add(keyEntry.ResRef + "." + frmMain.GetRsrcTypeForID(CInt(keyEntry.ResourceType)), text)
                            If StringType.StrCmp(text, "", False) = 0 Then
                                Console.WriteLine("-----------------------------")
                            End If
                        End If
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Dim stream As Stream = File.Create("K1TemplateTags.bfd")
                binaryFormatter.Serialize(stream, hashtable2)
                stream.Close()
            End If
            If Me.hasK2 AndAlso Not File.Exists("K2TemplateTags.bfd") Then
                If ObjectType.ObjTst(Me.TreeView.Nodes(1).Nodes(0).Nodes(0).Tag, "dummy", False) = 0 Then
                    Cursor.Current = Cursors.WaitCursor
                    Me.BuildTreeView(CType(Me.TreeView.Nodes(1), KotorTreeNode), True)
                End If
                Try
                    For Each obj2 As Object In Me.BiffEntryListArray(1, 2)
                        Dim keyEntry2 As KeyEntry = CType(obj2, KeyEntry)
                        If hashtable.ContainsKey(Convert.ToInt32(keyEntry2.ResourceType)) Then
                            Dim data2 As Byte() = frmMain.K2TemplatesBif().getBIFFResource(keyEntry2.ResID - (keyEntry2.ResID >> 20 << 20)).data
                            Dim text As String = frmMain.GetGFFTag(data2)
                            hashtable3.Add(keyEntry2.ResRef + "." + frmMain.GetRsrcTypeForID(CInt(keyEntry2.ResourceType)), text)
                            If StringType.StrCmp(text, "", False) = 0 Then
                                Console.WriteLine("-----------------------------")
                            End If
                        End If
                    Next
                Finally
                    Dim enumerator2 As IEnumerator
                    If TypeOf enumerator2 Is IDisposable Then
                        CType(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                Dim stream As Stream = File.Create("K2TemplateTags.bfd")
                binaryFormatter.Serialize(stream, hashtable3)
                stream.Close()
            End If
        End Sub

        ' Token: 0x0600075E RID: 1886 RVA: 0x002586F0 File Offset: 0x002576F0
        Private Sub ExtractNWScripts()
            If Me.hasK1 AndAlso Not Directory.Exists(Path.Combine(frmMain.CurrentSettings.KotorLocation(0), "override")) Then
                Directory.CreateDirectory(Path.Combine(frmMain.CurrentSettings.KotorLocation(0), "override"))
            End If
            If Me.hasK2 AndAlso Not Directory.Exists(Path.Combine(frmMain.CurrentSettings.KotorLocation(1), "override")) Then
                Directory.CreateDirectory(Path.Combine(frmMain.CurrentSettings.KotorLocation(1), "override"))
            End If
            Dim text As String = Path.Combine(frmMain.CurrentSettings.KotorLocation(0), "override\nwscript.nss")
            Dim text2 As String = Path.Combine(frmMain.CurrentSettings.KotorLocation(1), "override\nwscript.nss")
            If Me.hasK1 AndAlso Not File.Exists(text) Then
                frmMain.ExportBiffResource(Path.Combine(frmMain.CurrentSettings.KotorLocation(0), "data\scripts.bif"), text, 3533)
            End If
            If Me.hasK2 AndAlso Not File.Exists(text) Then
                frmMain.ExportBiffResource(Path.Combine(frmMain.CurrentSettings.KotorLocation(1), "data\scripts.bif"), text2, 1245)
            End If
        End Sub

        ' Token: 0x0600075F RID: 1887 RVA: 0x00258808 File Offset: 0x00257808
        Private Sub ReadTreeBFD_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
            Dim assembly As Assembly = Assembly.LoadFrom("G:\My Documents\Visual Studio Projects\kotor_tool\MapInfo Generator\bin\MapInfo Generator.exe")
            Dim version As Version = assembly.GetName().Version
            Console.WriteLine(String.Concat(New String() {StringType.FromInteger(version.Major), ".", StringType.FromInteger(version.Minor), ".", StringType.FromInteger(version.Build), ".", StringType.FromInteger(version.Revision)}))
        End Sub

        ' Token: 0x06000760 RID: 1888 RVA: 0x00258890 File Offset: 0x00257890
        Public Shared Function GetKotorSoundInfo(ByVal filepath As Object) As KTSoundInfo
            Dim stream As Stream = File.Open(StringType.FromObject(filepath), FileMode.Open)
            Dim binaryReader As BinaryReader = New BinaryReader(stream)
            Dim text As String = New String(binaryReader.ReadChars(4))
            While StringType.StrCmp(text, "RIFF", False) <> 0
                text = New String(binaryReader.ReadChars(4))
            End While
            Dim num As Integer = CInt((binaryReader.BaseStream.Position - 4L))
            binaryReader.ReadBytes(8)
            text = New String(binaryReader.ReadChars(4))
            While StringType.StrCmp(text, "data", False) <> 0
                Dim text2 As String = text
                If StringType.StrCmp(text2, "fmt ", False) = 0 Then
                    Dim num2 As Integer = binaryReader.ReadInt32()
                    Dim num3 As Integer = CInt(binaryReader.ReadInt16())
                    Dim num4 As Integer = CInt(binaryReader.ReadInt16())
                    Dim num5 As Integer = binaryReader.ReadInt32()
                    Dim num6 As Integer = binaryReader.ReadInt32()
                    Dim num7 As Integer = CInt(binaryReader.ReadInt16())
                    Dim num8 As Integer = CInt(binaryReader.ReadInt16())
                    If num2 > 16 Then
                        binaryReader.ReadBytes(num2 - 16)
                    End If
                ElseIf StringType.StrCmp(text2, "fact", False) = 0 Then
                    Dim num2 As Integer = binaryReader.ReadInt32()
                    binaryReader.ReadBytes(num2)
                End If
                text = New String(binaryReader.ReadChars(4))
            End While
            Dim num10 As Integer
            Dim num11 As Integer
            Dim text3 As String
            If StringType.StrCmp(text, "data", False) = 0 Then
                Dim num9 As Integer = binaryReader.ReadInt32()
                If num9 = 0 Then
                    num10 = CInt(binaryReader.BaseStream.Position)
                    num11 = CInt((binaryReader.BaseStream.Length - CLng(num10)))
                    binaryReader.ReadBytes(1)
                    Dim b As Byte = binaryReader.ReadByte()
                    Dim b2 As Byte = binaryReader.ReadByte()
                    Dim num12 As Integer = (b And 24) >> 3
                    Dim num13 As Integer = (b And 6) >> 1
                    Dim num14 As Integer = (b2 And 240) >> 4
                    Dim num5 As Integer = (b2 And 12) >> 2
                    text3 = "MPEG " + StringType.FromInteger(num12) + "-" + StringType.FromInteger(num13)
                Else
                    num10 = num
                    num11 = CInt((binaryReader.BaseStream.Length - CLng(num10)))
                    text3 = "WAVE"
                End If
            End If
            stream.Close()
            Return New KTSoundInfo() With {.DataOffset = num10, .DataSize = num11, .Format = text3}
        End Function

        ' Token: 0x06000761 RID: 1889 RVA: 0x00258A9C File Offset: 0x00257A9C
        Private Sub Read_NWScript_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
            Dim fileStream As FileStream = New FileStream("C:\SharpDevelop_1.1.0.2081\src\Libraries\ICSharpCode.TextEditor\src\ICSharpCode.TextEditor.prjx", FileMode.Open)
            Dim streamWriter As StreamWriter = File.CreateText("c:\TextEditor.csproj")
            Dim streamReader As StreamReader = New StreamReader(fileStream)
            Dim num As Integer = 1
            Do
                Dim text As String = streamReader.ReadLine()
                If text.ToLower().IndexOf("<file") > -1 AndAlso text.IndexOf("Exclude") = -1 Then
                    Dim text2 As String = text.Replace("name=", "RelPath =").Replace(".\", "")
                    streamWriter.WriteLine(text2)
                End If
                num += 1
            Loop While num <= 647
            streamReader.Close()
            streamWriter.Close()
        End Sub

        ' Token: 0x040003B5 RID: 949
        Public Shared gRootPath As String
        Public Shared gWorkingPath As String

        Public Shared Function GetApplicationRootPath() As String
            Dim path As String = Application.StartupPath

            If Not path.EndsWith("\") Then
                path &= "\"
            End If

            Return path
        End Function

        Public Shared Function GetWorkingDirectoryPath() As String
            Dim path As String = IO.Path.Combine(GetApplicationRootPath(), "working")

            If Not IO.Directory.Exists(path) Then
                IO.Directory.CreateDirectory(path)
            End If

            If Not path.EndsWith("\") Then
                path &= "\"
            End If

            Return path
        End Function

        Public Shared Function GetWorkingFilePath(ByVal fileName As String) As String
            Return IO.Path.Combine(GetWorkingDirectoryPath(), IO.Path.GetFileName(fileName))
        End Function

        ' Token: 0x040003B6 RID: 950
        Public Shared gImageViewer As frmImageViewer

        ' Token: 0x040003B7 RID: 951
        Public Shared gK1ChitinKey As clsChitinKey

        ' Token: 0x040003B8 RID: 952
        Public Shared gK2ChitinKey As clsChitinKey

        ' Token: 0x040003B9 RID: 953
        Public Shared gK1TemplatesBif As BIFFArchive

        ' Token: 0x040003BA RID: 954
        Public Shared gK2TemplatesBif As BIFFArchive

        ' Token: 0x040003BB RID: 955
        Public Shared mainform As Form

        ' Token: 0x040003BC RID: 956
        Private BiffEntryListArray As ArrayList(,)

        ' Token: 0x040003BD RID: 957
        Private biffEntries As ArrayList()

        ' Token: 0x040003BE RID: 958
        Private LastClickedTVNode As KotorTreeNode

        ' Token: 0x040003BF RID: 959
        Private SecondToLastClickedTVNode As KotorTreeNode

        ' Token: 0x040003C0 RID: 960
        Private buffer As Byte()

        ' Token: 0x040003C1 RID: 961
        Public Shared usetting As UserSettings = New UserSettings()

        ' Token: 0x040003C2 RID: 962
        Public Shared CurrentSettings As Options

        ' Token: 0x040003C3 RID: 963
        Private CmdArgs As String()

        ' Token: 0x040003C4 RID: 964
        Private g_downloadURL As String

        ' Token: 0x040003C5 RID: 965
        Private g_downloadfile As String

        ' Token: 0x040003C6 RID: 966
        Private g_CheckForUpdatesSilently As Boolean

        ' Token: 0x040003C7 RID: 967
        Private hasK1 As Boolean

        ' Token: 0x040003C8 RID: 968
        Private hasK2 As Boolean

        ' Token: 0x040003C9 RID: 969
        Private g_CmdLineOpenedForm As Form

        ' Token: 0x040003CA RID: 970
        Private g_abbbIndex As Integer

        Private _theme As KotorTheme
        Private ResourceViewHistory As ArrayList
        Private ResourceViewHistoryIndex As Integer
        Private SuppressResourceViewHistory As Boolean
        Private ResourceBrowserIconThemeSignature As String

        ' Token: 0x02000055 RID: 85
        ' (Invoke) Token: 0x06000765 RID: 1893
        Private Delegate Sub CheckForUpdate()

        ' Token: 0x02000056 RID: 86
        ' (Invoke) Token: 0x06000769 RID: 1897
        Private Delegate Sub DownloadUpdate(ByVal URL As String, ByVal filePath As String, ByVal signature As String, ByVal onlineVersion As String)

        ' Token: 0x02000057 RID: 87
        Public Structure aabb
            ' Token: 0x040003CB RID: 971
            Public left As Integer

            ' Token: 0x040003CC RID: 972
            Public right As Integer

            ' Token: 0x040003CD RID: 973
            Public face As Integer
        End Structure

        Private Sub miOpenHexViewer_Click(sender As Object, e As EventArgs) Handles miOpenHexViewer.Click, miOpenByteView.Click
            Using viewer As New frmByteViewer()
                viewer.ShowDialog(Me)
            End Using
        End Sub

        Private Sub miOpenPluginManager_Click(sender As Object, e As EventArgs) Handles miOpenPluginManager.Click
            Dim frmPluginSystem As frmPluginSystem = New frmPluginSystem()
            frmPluginSystem.StartPosition = FormStartPosition.CenterParent
            frmPluginSystem.ShowDialog(Me)
            frmPluginSystem.Dispose()
        End Sub

        Private Sub miThemeEditor_Click(sender As Object, e As EventArgs) Handles miThemeEditor.Click
            Dim frmThemeEditor As frmThemeEditor = New frmThemeEditor()
            frmThemeEditor.StartPosition = FormStartPosition.CenterParent
            frmThemeEditor.ShowDialog(Me)
            frmThemeEditor.Dispose()
            Me.LoadAndApplyTheme()
            If TypeOf Me.TreeView.SelectedNode Is KotorTreeNode Then
                Me.PopulateResourceBrowserFromNode(CType(Me.TreeView.SelectedNode, KotorTreeNode))
            End If
        End Sub
    End Class
End Namespace
