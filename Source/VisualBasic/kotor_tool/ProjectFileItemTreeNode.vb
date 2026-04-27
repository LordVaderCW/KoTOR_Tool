Imports System
Imports System.IO
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200006C RID: 108
	Public Class ProjectFileItemTreeNode
		Inherits TreeNode

		' Token: 0x06000DFF RID: 3583 RVA: 0x0028BFA0 File Offset: 0x0028AFA0
		Public Sub New(NodeName As String)
			MyBase.New(NodeName)
		End Sub

		' Token: 0x06000E00 RID: 3584 RVA: 0x0028BFAC File Offset: 0x0028AFAC
		Public Sub New(NodeName As String, NodeArray As ProjectFileItemTreeNode())
			MyBase.New(NodeName, NodeArray)
		End Sub

		' Token: 0x06000E01 RID: 3585 RVA: 0x0028BFB8 File Offset: 0x0028AFB8
		Public Overrides Function ToString() As String
			Return Me.Text
		End Function

		' Token: 0x170004DE RID: 1246
		' (get) Token: 0x06000E02 RID: 3586 RVA: 0x0028BFCC File Offset: 0x0028AFCC
		' (set) Token: 0x06000E03 RID: 3587 RVA: 0x0028BFE4 File Offset: 0x0028AFE4
		Public Property Filename As String
			Get
				Return Path.GetFileName(Me.m_FilePath)
			End Get
			Set(value As String)
				Me.m_FilePath = Path.GetDirectoryName(Me.m_FilePath) + value
			End Set
		End Property

		' Token: 0x170004DF RID: 1247
		' (get) Token: 0x06000E04 RID: 3588 RVA: 0x0028C000 File Offset: 0x0028B000
		' (set) Token: 0x06000E05 RID: 3589 RVA: 0x0028C014 File Offset: 0x0028B014
		Public Property FilePath As String
			Get
				Return Me.m_FilePath
			End Get
			Set(value As String)
				Me.m_FilePath = value
			End Set
		End Property

		' Token: 0x040006D8 RID: 1752
		Private m_FilePath As String
	End Class
End Namespace
