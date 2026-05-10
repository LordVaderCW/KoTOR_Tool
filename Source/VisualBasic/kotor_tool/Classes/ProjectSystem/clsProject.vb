Imports System
Imports System.Collections
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000027 RID: 39
    <Serializable()> _
 Public Class clsProject
        ' Token: 0x060000D1 RID: 209 RVA: 0x002234A8 File Offset: 0x002224A8
        Public Sub New()
            Me.m_ProjectName = "Project"
            Me.m_OverrideFiles = New ArrayList()
            Me.m_Modules = New ArrayList()
            Me.m_LipsModules = New ArrayList()
            Me.m_StreamWavesFiles = New ArrayList()
            Me.m_StreamWavesModules = New ArrayList()
            Me.m_KotorVersionIndex = -1
        End Sub

        ' Token: 0x17000018 RID: 24
        ' (get) Token: 0x060000D2 RID: 210 RVA: 0x00223504 File Offset: 0x00222504
        ' (set) Token: 0x060000D3 RID: 211 RVA: 0x00223518 File Offset: 0x00222518
        Public Property Name() As String
            Get
                Return Me.m_ProjectName
            End Get
            Set(ByVal value As String)
                Me.m_ProjectName = value
            End Set
        End Property

        ' Token: 0x17000019 RID: 25
        ' (get) Token: 0x060000D4 RID: 212 RVA: 0x00223524 File Offset: 0x00222524
        ' (set) Token: 0x060000D5 RID: 213 RVA: 0x00223538 File Offset: 0x00222538
        Public Property DebugFilePath() As String
            Get
                Return Me.m_DebugFilePath
            End Get
            Set(ByVal value As String)
                Me.m_DebugFilePath = value
            End Set
        End Property

        ' Token: 0x1700001A RID: 26
        ' (get) Token: 0x060000D6 RID: 214 RVA: 0x00223544 File Offset: 0x00222544
        ' (set) Token: 0x060000D7 RID: 215 RVA: 0x00223558 File Offset: 0x00222558
        Public Property ReleaseFilePath() As String
            Get
                Return Me.m_ReleaseFilePath
            End Get
            Set(ByVal value As String)
                Me.m_ReleaseFilePath = value
            End Set
        End Property

        ' Token: 0x1700001B RID: 27
        ' (get) Token: 0x060000D8 RID: 216 RVA: 0x00223564 File Offset: 0x00222564
        ' (set) Token: 0x060000D9 RID: 217 RVA: 0x00223578 File Offset: 0x00222578
        <XmlArray()> _
        <XmlArrayItem(GetType(String))> _
              Public Property OverrideFiles() As ArrayList
            Get
                Return Me.m_OverrideFiles
            End Get
            Set(ByVal value As ArrayList)
                Me.m_OverrideFiles = value
            End Set
        End Property

        ' Token: 0x1700001C RID: 28
        ' (get) Token: 0x060000DA RID: 218 RVA: 0x00223584 File Offset: 0x00222584
        ' (set) Token: 0x060000DB RID: 219 RVA: 0x00223598 File Offset: 0x00222598
        <XmlArray()> _
        <XmlArrayItem(GetType(ModuleFileEntry))> _
              Public Property Modules() As ArrayList
            Get
                Return Me.m_Modules
            End Get
            Set(ByVal value As ArrayList)
                Me.m_Modules = value
            End Set
        End Property

        ' Token: 0x1700001D RID: 29
        ' (get) Token: 0x060000DC RID: 220 RVA: 0x002235A4 File Offset: 0x002225A4
        ' (set) Token: 0x060000DD RID: 221 RVA: 0x002235B8 File Offset: 0x002225B8
        <XmlArray()> _
        <XmlArrayItem(GetType(ModuleFileEntry))> _
              Public Property LipsModules() As ArrayList
            Get
                Return Me.m_LipsModules
            End Get
            Set(ByVal value As ArrayList)
                Me.m_LipsModules = value
            End Set
        End Property

        ' Token: 0x1700001E RID: 30
        ' (get) Token: 0x060000DE RID: 222 RVA: 0x002235C4 File Offset: 0x002225C4
        ' (set) Token: 0x060000DF RID: 223 RVA: 0x002235D8 File Offset: 0x002225D8
        <XmlArrayItem(GetType(String))> _
        <XmlArray()> _
              Public Property StreamWavesFiles() As ArrayList
            Get
                Return Me.m_StreamWavesFiles
            End Get
            Set(ByVal value As ArrayList)
                Me.m_StreamWavesFiles = value
            End Set
        End Property

        ' Token: 0x1700001F RID: 31
        ' (get) Token: 0x060000E0 RID: 224 RVA: 0x002235E4 File Offset: 0x002225E4
        ' (set) Token: 0x060000E1 RID: 225 RVA: 0x002235F8 File Offset: 0x002225F8
        <XmlArrayItem(GetType(ModuleFileEntry))> _
        <XmlArray()> _
              Public Property StreamWavesModules() As ArrayList
            Get
                Return Me.m_StreamWavesModules
            End Get
            Set(ByVal value As ArrayList)
                Me.m_StreamWavesModules = value
            End Set
        End Property

        ' Token: 0x17000020 RID: 32
        ' (get) Token: 0x060000E2 RID: 226 RVA: 0x00223604 File Offset: 0x00222604
        <XmlIgnore()> _
        Public ReadOnly Property OverrideFilesHashTable() As Hashtable
            Get
                Dim hashtable As Hashtable = New Hashtable(Me.m_OverrideFiles.Count)
                Try
                    For Each obj As Object In Me.m_OverrideFiles
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

        ' Token: 0x17000021 RID: 33
        ' (get) Token: 0x060000E3 RID: 227 RVA: 0x00223678 File Offset: 0x00222678
        <XmlIgnore()> _
        Public ReadOnly Property StreamWavesFilesHashTable() As Hashtable
            Get
                Dim hashtable As Hashtable = New Hashtable(Me.m_StreamWavesFiles.Count)
                Try
                    For Each obj As Object In Me.m_StreamWavesFiles
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

        ' Token: 0x17000022 RID: 34
        ' (get) Token: 0x060000E4 RID: 228 RVA: 0x002236EC File Offset: 0x002226EC
        ' (set) Token: 0x060000E5 RID: 229 RVA: 0x00223700 File Offset: 0x00222700
        Public Property KotorVersionIndex() As Integer
            Get
                Return Me.m_KotorVersionIndex
            End Get
            Set(ByVal value As Integer)
                Me.m_KotorVersionIndex = value
            End Set
        End Property

        ' Token: 0x060000E6 RID: 230 RVA: 0x0022370C File Offset: 0x0022270C
        Public Function GetModuleIndex(ByVal ModuleName As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_Modules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_Modules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Return i
                End If
            Next
            Return -1
        End Function

        ' Token: 0x060000E7 RID: 231 RVA: 0x00223758 File Offset: 0x00222758
        Public Sub RemoveAllModules()
            Me.m_Modules.Clear()
        End Sub

        ' Token: 0x060000E8 RID: 232 RVA: 0x00223768 File Offset: 0x00222768
        Public Function AddModule(ByVal Name As String) As Integer
            Return Me.m_Modules.Add(New ModuleFileEntry(Name))
        End Function

        ' Token: 0x060000E9 RID: 233 RVA: 0x00223788 File Offset: 0x00222788
        Public Function AddModuleFile(ByVal ModuleName As String, ByVal FilePath As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_Modules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_Modules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    CType(Me.m_Modules(i), ModuleFileEntry).ModuleFiles.Add(FilePath)
                    Return 0
                End If
            Next
            Return -1
        End Function

        ' Token: 0x060000EA RID: 234 RVA: 0x002237F0 File Offset: 0x002227F0
        Public Sub RemoveModule(ByVal ModuleName As String)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_Modules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_Modules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Me.m_Modules.RemoveAt(i)
                    Return
                End If
            Next
        End Sub

        ' Token: 0x060000EB RID: 235 RVA: 0x00223844 File Offset: 0x00222844
        Public Sub RemoveAllModuleFiles(ByVal ModuleName As String)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_Modules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_Modules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    CType(Me.m_Modules(i), ModuleFileEntry).ModuleFiles.Clear()
                    Return
                End If
            Next
        End Sub

        ' Token: 0x060000EC RID: 236 RVA: 0x002238A8 File Offset: 0x002228A8
        Public Function GetModuleNames() As ArrayList
            Dim arrayList As ArrayList = New ArrayList()
            Try
                For Each obj As Object In Me.m_Modules
                    Dim moduleFileEntry As ModuleFileEntry = CType(obj, ModuleFileEntry)
                    arrayList.Add(moduleFileEntry.ModuleName)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return arrayList
        End Function

        ' Token: 0x060000ED RID: 237 RVA: 0x00223914 File Offset: 0x00222914
        Public Function GetModuleFiles(ByVal index As Integer) As ArrayList
            If Me.m_Modules.Count >= index Then
                Return CType(Me.m_Modules(index), ModuleFileEntry).ModuleFiles
            End If
            Return Nothing
        End Function

        ' Token: 0x060000EE RID: 238 RVA: 0x00223948 File Offset: 0x00222948
        Public Function GetModuleFiles(ByVal ModuleName As String) As ArrayList
            Return CType(Me.m_Modules(Me.GetModuleIndex(ModuleName)), ModuleFileEntry).ModuleFiles
        End Function

        ' Token: 0x060000EF RID: 239 RVA: 0x00223974 File Offset: 0x00222974
        Public Function RemoveModuleFile(ByVal ModuleName As String, ByVal FilePath As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_Modules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_Modules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Dim num3 As Integer = CType(Me.m_Modules(i), ModuleFileEntry).ModuleFiles.IndexOf(FilePath)
                    If num3 <> -1 Then
                        CType(Me.m_Modules(i), ModuleFileEntry).ModuleFiles.RemoveAt(num3)
                        Return 0
                    End If
                End If
            Next
            Return -1
        End Function

        ' Token: 0x060000F0 RID: 240 RVA: 0x002239FC File Offset: 0x002229FC
        Public Function RemoveOverrideFile(ByVal FilePath As String) As Integer
            Dim num As Integer = Me.m_OverrideFiles.IndexOf(FilePath)
            If num <> -1 Then
                Me.m_OverrideFiles.RemoveAt(num)
                Return 0
            End If
            Return -1
        End Function

        ' Token: 0x060000F1 RID: 241 RVA: 0x00223A2C File Offset: 0x00222A2C
        Public Sub RemoveAllOverrideFiles()
            Me.m_OverrideFiles.Clear()
        End Sub

        ' Token: 0x060000F2 RID: 242 RVA: 0x00223A3C File Offset: 0x00222A3C
        Public Function GetLipsModuleIndex(ByVal ModuleName As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_LipsModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Return i
                End If
            Next
            Return -1
        End Function

        ' Token: 0x060000F3 RID: 243 RVA: 0x00223A88 File Offset: 0x00222A88
        Public Sub RemoveAllLipsModules()
            Me.m_LipsModules.Clear()
        End Sub

        ' Token: 0x060000F4 RID: 244 RVA: 0x00223A98 File Offset: 0x00222A98
        Public Function AddLipsModule(ByVal Name As String) As Integer
            Return Me.m_LipsModules.Add(New ModuleFileEntry(Name))
        End Function

        ' Token: 0x060000F5 RID: 245 RVA: 0x00223AB8 File Offset: 0x00222AB8
        Public Function AddLipsModuleFile(ByVal ModuleName As String, ByVal FilePath As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_LipsModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleFiles.Add(FilePath)
                    Return 0
                End If
            Next
            Return -1
        End Function

        ' Token: 0x060000F6 RID: 246 RVA: 0x00223B20 File Offset: 0x00222B20
        Public Sub RemoveLipsModule(ByVal ModuleName As String)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_LipsModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Me.m_LipsModules.RemoveAt(i)
                    Return
                End If
            Next
        End Sub

        ' Token: 0x060000F7 RID: 247 RVA: 0x00223B74 File Offset: 0x00222B74
        Public Sub RemoveAllLipsModuleFiles(ByVal ModuleName As String)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_LipsModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleFiles.Clear()
                    Return
                End If
            Next
        End Sub

        ' Token: 0x060000F8 RID: 248 RVA: 0x00223BD8 File Offset: 0x00222BD8
        Public Function GetLipsModuleNames() As ArrayList
            Dim arrayList As ArrayList = New ArrayList()
            Try
                For Each obj As Object In Me.m_LipsModules
                    Dim moduleFileEntry As ModuleFileEntry = CType(obj, ModuleFileEntry)
                    arrayList.Add(moduleFileEntry.ModuleName)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return arrayList
        End Function

        ' Token: 0x060000F9 RID: 249 RVA: 0x00223C44 File Offset: 0x00222C44
        Public Function GetLipsModuleFiles(ByVal index As Integer) As ArrayList
            If Me.m_LipsModules.Count >= index Then
                Return CType(Me.m_LipsModules(index), ModuleFileEntry).ModuleFiles
            End If
            Return Nothing
        End Function

        ' Token: 0x060000FA RID: 250 RVA: 0x00223C78 File Offset: 0x00222C78
        Public Function GetLipsModuleFiles(ByVal ModuleName As String) As ArrayList
            Return CType(Me.m_LipsModules(Me.GetLipsModuleIndex(ModuleName)), ModuleFileEntry).ModuleFiles
        End Function

        ' Token: 0x060000FB RID: 251 RVA: 0x00223CA4 File Offset: 0x00222CA4
        Public Function RemoveLipsModuleFile(ByVal ModuleName As String, ByVal FilePath As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_LipsModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Dim num3 As Integer = CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleFiles.IndexOf(FilePath)
                    If num3 <> -1 Then
                        CType(Me.m_LipsModules(i), ModuleFileEntry).ModuleFiles.RemoveAt(num3)
                        Return 0
                    End If
                End If
            Next
            Return -1
        End Function

        ' Token: 0x060000FC RID: 252 RVA: 0x00223D2C File Offset: 0x00222D2C
        Public Function GetStreamWavesModuleIndex(ByVal ModuleName As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_StreamWavesModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Return i
                End If
            Next
            Return -1
        End Function

        ' Token: 0x060000FD RID: 253 RVA: 0x00223D78 File Offset: 0x00222D78
        Public Sub RemoveAllStreamWavesModules()
            Me.m_StreamWavesModules.Clear()
        End Sub

        ' Token: 0x060000FE RID: 254 RVA: 0x00223D88 File Offset: 0x00222D88
        Public Function AddStreamWavesModule(ByVal Name As String) As Integer
            Return Me.m_StreamWavesModules.Add(New ModuleFileEntry(Name))
        End Function

        ' Token: 0x060000FF RID: 255 RVA: 0x00223DA8 File Offset: 0x00222DA8
        Public Function AddStreamWavesModuleFile(ByVal ModuleName As String, ByVal FilePath As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_StreamWavesModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleFiles.Add(FilePath)
                    Return 0
                End If
            Next
            Return -1
        End Function

        ' Token: 0x06000100 RID: 256 RVA: 0x00223E10 File Offset: 0x00222E10
        Public Sub RemoveStreamWavesModule(ByVal ModuleName As String)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_StreamWavesModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Me.m_StreamWavesModules.RemoveAt(i)
                    Return
                End If
            Next
        End Sub

        ' Token: 0x06000101 RID: 257 RVA: 0x00223E64 File Offset: 0x00222E64
        Public Sub RemoveAllStreamWavesModuleFiles(ByVal ModuleName As String)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_StreamWavesModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleFiles.Clear()
                    Return
                End If
            Next
        End Sub

        ' Token: 0x06000102 RID: 258 RVA: 0x00223EC8 File Offset: 0x00222EC8
        Public Function GetStreamWavesModuleNames() As ArrayList
            Dim arrayList As ArrayList = New ArrayList()
            Try
                For Each obj As Object In Me.m_StreamWavesModules
                    Dim moduleFileEntry As ModuleFileEntry = CType(obj, ModuleFileEntry)
                    arrayList.Add(moduleFileEntry.ModuleName)
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return arrayList
        End Function

        ' Token: 0x06000103 RID: 259 RVA: 0x00223F34 File Offset: 0x00222F34
        Public Function GetStreamWavesModuleFiles(ByVal index As Integer) As ArrayList
            If Me.m_StreamWavesModules.Count >= index Then
                Return CType(Me.m_StreamWavesModules(index), ModuleFileEntry).ModuleFiles
            End If
            Return Nothing
        End Function

        ' Token: 0x06000104 RID: 260 RVA: 0x00223F68 File Offset: 0x00222F68
        Public Function GetStreamWavesModuleFiles(ByVal ModuleName As String) As ArrayList
            Return CType(Me.m_StreamWavesModules(Me.GetStreamWavesModuleIndex(ModuleName)), ModuleFileEntry).ModuleFiles
        End Function

        ' Token: 0x06000105 RID: 261 RVA: 0x00223F94 File Offset: 0x00222F94
        Public Function RemoveStreamWavesModuleFile(ByVal ModuleName As String, ByVal FilePath As String) As Integer
            Dim num As Integer = 0
            Dim num2 As Integer = Me.m_StreamWavesModules.Count - 1
            For i As Integer = num To num2
                If StringType.StrCmp(CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleName, ModuleName, False) = 0 Then
                    Dim num3 As Integer = CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleFiles.IndexOf(FilePath)
                    If num3 <> -1 Then
                        CType(Me.m_StreamWavesModules(i), ModuleFileEntry).ModuleFiles.RemoveAt(num3)
                        Return 0
                    End If
                End If
            Next
            Return -1
        End Function

        ' Token: 0x06000106 RID: 262 RVA: 0x0022401C File Offset: 0x0022301C
        Public Sub RemoveAllStreamWavesFiles()
            Me.m_StreamWavesFiles.Clear()
        End Sub

        ' Token: 0x06000107 RID: 263 RVA: 0x0022402C File Offset: 0x0022302C
        Public Function RemoveStreamWavesFile(ByVal FilePath As String) As Integer
            Dim num As Integer = Me.m_StreamWavesFiles.IndexOf(FilePath)
            If num <> -1 Then
                Me.m_StreamWavesFiles.RemoveAt(num)
                Return 0
            End If
            Return -1
        End Function

        ' Token: 0x06000108 RID: 264 RVA: 0x0022405C File Offset: 0x0022305C
        Public Function AddStreamWavesFile(ByVal Name As String) As Integer
            Return Me.m_StreamWavesFiles.Add(Name)
        End Function

        ' Token: 0x040000FB RID: 251
        Private m_ProjectName As String

        ' Token: 0x040000FC RID: 252
        Private m_OverrideFiles As ArrayList

        ' Token: 0x040000FD RID: 253
        Private m_Modules As ArrayList

        ' Token: 0x040000FE RID: 254
        Private m_LipsModules As ArrayList

        ' Token: 0x040000FF RID: 255
        Private m_StreamWavesFiles As ArrayList

        ' Token: 0x04000100 RID: 256
        Private m_StreamWavesModules As ArrayList

        ' Token: 0x04000101 RID: 257
        Private m_ReleaseFilePath As String

        ' Token: 0x04000102 RID: 258
        Private m_DebugFilePath As String

        ' Token: 0x04000103 RID: 259
        Private m_KotorVersionIndex As Integer
    End Class
End Namespace
