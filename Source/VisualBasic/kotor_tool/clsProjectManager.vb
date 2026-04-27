Imports System
Imports System.Collections
Imports System.IO
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic

Namespace kotor_tool
	' Token: 0x02000029 RID: 41
	Public Class clsProjectManager
		' Token: 0x06000112 RID: 274 RVA: 0x00224188 File Offset: 0x00223188
		Public Sub New(ProjectFilePath As String)
			Me.m_ProjectFilePath = ProjectFilePath
			If File.Exists(ProjectFilePath) Then
				Me.m_Project = Me.LoadProject()
			End If
			If Me.m_Project Is Nothing Then
				Interaction.MsgBox("Couldn't load project file", MsgBoxStyle.Critical, "clsProjectManager")
			End If
		End Sub

		' Token: 0x06000113 RID: 275 RVA: 0x002241C8 File Offset: 0x002231C8
		Public Sub New(ProjectFilePath As String, NewProjectName As String)
			Me.m_ProjectFilePath = ProjectFilePath
			Me.m_Project = New clsProject()
			Me.m_Project.Name = NewProjectName
		End Sub

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000114 RID: 276 RVA: 0x002241F0 File Offset: 0x002231F0
		' (set) Token: 0x06000115 RID: 277 RVA: 0x00224204 File Offset: 0x00223204
		Public Property Project As clsProject
			Get
				Return Me.m_Project
			End Get
			Set(value As clsProject)
				Me.m_Project = value
			End Set
		End Property

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000116 RID: 278 RVA: 0x00224210 File Offset: 0x00223210
		' (set) Token: 0x06000117 RID: 279 RVA: 0x00224224 File Offset: 0x00223224
		Public Property ProjectFilePath As String
			Get
				Return Me.m_ProjectFilePath
			End Get
			Set(value As String)
				Me.m_ProjectFilePath = value
			End Set
		End Property

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x06000118 RID: 280 RVA: 0x00224230 File Offset: 0x00223230
		' (set) Token: 0x06000119 RID: 281 RVA: 0x00224248 File Offset: 0x00223248
		Public Property ProjectKotorVersionIndex As Integer
			Get
				Return Me.m_Project.KotorVersionIndex
			End Get
			Set(value As Integer)
				Me.m_Project.KotorVersionIndex = value
			End Set
		End Property

		' Token: 0x0600011A RID: 282 RVA: 0x00224258 File Offset: 0x00223258
		Public Function GetProjectOverrideFiles() As ArrayList
			Return Me.m_Project.OverrideFiles
		End Function

		' Token: 0x0600011B RID: 283 RVA: 0x00224270 File Offset: 0x00223270
		Public Function GetProjectModuleCount() As Integer
			Return Me.m_Project.Modules.Count
		End Function

		' Token: 0x0600011C RID: 284 RVA: 0x00224290 File Offset: 0x00223290
		Public Function GetProjectModuleFiles(fileNum As Integer) As ArrayList
			Return CType(Me.m_Project.Modules(fileNum), ArrayList)
		End Function

		' Token: 0x0600011D RID: 285 RVA: 0x002242B4 File Offset: 0x002232B4
		Public Function LoadProject() As clsProject
			Return Me.LoadProject(Me.m_ProjectFilePath)
		End Function

		' Token: 0x0600011E RID: 286 RVA: 0x002242D0 File Offset: 0x002232D0
		Public Function LoadProject(projectPath As String) As clsProject
			Dim clsProject As clsProject
			Try
				If File.Exists(projectPath) Then
					Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(clsProject))
					Dim fileStream As FileStream = New FileStream(projectPath, FileMode.Open, FileAccess.Read)
					Me.m_Project = CType(xmlSerializer.Deserialize(fileStream), clsProject)
					fileStream.Close()
				End If
				clsProject = Me.m_Project
            Catch ex As System.Exception
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "")
                clsProject = Nothing
			End Try
			Return clsProject
		End Function

		' Token: 0x0600011F RID: 287 RVA: 0x00224354 File Offset: 0x00223354
		Public Sub SaveProject()
			Me.SaveProject(Me.m_ProjectFilePath, Me.m_Project)
		End Sub

		' Token: 0x06000120 RID: 288 RVA: 0x00224368 File Offset: 0x00223368
		Public Sub SaveProject(ProjectFilePath As String, Project As clsProject)
			Try
				Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(clsProject))
				Dim fileStream As FileStream = New FileStream(ProjectFilePath, FileMode.Create, FileAccess.ReadWrite)
				xmlSerializer.Serialize(fileStream, Project)
				fileStream.Close()
            Catch ex As System.Exception
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, Nothing)
			End Try
		End Sub

		' Token: 0x04000107 RID: 263
		Private m_ProjectFilePath As String

		' Token: 0x04000108 RID: 264
		Private m_Project As clsProject
	End Class
End Namespace
