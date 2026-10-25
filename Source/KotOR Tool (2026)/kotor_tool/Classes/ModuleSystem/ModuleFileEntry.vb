Imports System
Imports System.Collections
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000028 RID: 40
	Public Class ModuleFileEntry
		' Token: 0x06000109 RID: 265 RVA: 0x00224078 File Offset: 0x00223078
		Public Sub New()
			Me.m_PackageType = "MOD"
			Me.m_ModuleName = ""
			Me.m_ModuleFiles = New ArrayList()
		End Sub

		' Token: 0x0600010A RID: 266 RVA: 0x002240A4 File Offset: 0x002230A4
		Public Sub New(Name As String)
			Me.New()
			Me.m_ModuleName = Name
		End Sub

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x0600010B RID: 267 RVA: 0x002240B4 File Offset: 0x002230B4
		' (set) Token: 0x0600010C RID: 268 RVA: 0x002240C8 File Offset: 0x002230C8
		Public Property ModuleName As String
			Get
				Return Me.m_ModuleName
			End Get
			Set(value As String)
				Me.m_ModuleName = value
			End Set
		End Property

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x0600010D RID: 269 RVA: 0x002240D4 File Offset: 0x002230D4
		' (set) Token: 0x0600010E RID: 270 RVA: 0x002240E8 File Offset: 0x002230E8
		Public Property PackageType As String
			Get
				Return Me.m_PackageType
			End Get
			Set(value As String)
				Me.m_PackageType = value
			End Set
		End Property

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x0600010F RID: 271 RVA: 0x002240F4 File Offset: 0x002230F4
        <XmlIgnore()> _
  Public ReadOnly Property FilesHashTable() As Hashtable
            Get
                Dim hashtable As Hashtable = New Hashtable(Me.ModuleFiles.Count)
                Try
                    For Each obj As Object In Me.ModuleFiles
                        Dim text As String = StringType.FromObject(obj)
                        hashtable.Add(text, "")
                    Next
                Finally
                    Dim enumerator As IEnumerator = Nothing
                    If TypeOf enumerator Is IDisposable Then
                        CType(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Return hashtable
            End Get
        End Property

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000110 RID: 272 RVA: 0x00224168 File Offset: 0x00223168
		' (set) Token: 0x06000111 RID: 273 RVA: 0x0022417C File Offset: 0x0022317C
        <XmlArrayItem(GetType(String))> _
        <XmlArray()> _
        Public Property ModuleFiles() As ArrayList
            Get
                Return Me.m_ModuleFiles
            End Get
            Set(ByVal value As ArrayList)
                Me.m_ModuleFiles = value
            End Set
        End Property

		' Token: 0x04000104 RID: 260
		Private m_ModuleName As String

		' Token: 0x04000105 RID: 261
		Private m_ModuleFiles As ArrayList

		' Token: 0x04000106 RID: 262
		Private m_PackageType As String
	End Class
End Namespace
