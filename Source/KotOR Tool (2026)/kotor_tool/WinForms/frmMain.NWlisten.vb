Imports System
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic
Imports System.Diagnostics
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace kotor_tool
    Partial Public Class frmMain
        Private nwSendBusy As Boolean

        Private Async Sub SendModelToMax(ByVal sender As Object, ByVal e As EventArgs)
            If nwSendBusy OrElse modelPreviewBusy OrElse modelPreviewNode Is Nothing Then Return
            Dim node As KotorTreeNode = modelPreviewNode
            nwSendBusy = True
            modelPreviewBusy = True
            Dim meter As New frmProgressMeter()
            Dim job As String = Nothing
            Try
                meter.OperationTitle = "Send to 3DS Max (2021)"
                meter.message = node.ResRef
                meter.maxvalue = 100
                meter.AllowCancel = False
                meter.ControlBox = True
                meter.Show(Me)
                Dim game As Integer = NodeTreeRootIndex(node)
                If game < 0 OrElse game > 1 Then Throw New InvalidDataException("The model has no game context.")
                Dim maxRoot As String = Path.Combine(Environment.GetEnvironmentVariable("ProgramW6432"), "Autodesk\3ds Max 2021")
                Dim listener As String = Path.Combine(maxRoot, "scripts\NWlisten\NWlisten.ms")
                If Not File.Exists(listener) Then Throw New FileNotFoundException("Install NWlisten in 3ds Max 2021 before sending models.")
                Dim root As String = NWRegisterApplicationDirectory(Application.StartupPath)
                Dim queue As String = Path.Combine(root, "jobs")
                Directory.CreateDirectory(queue)
                meter.status = "Connecting to NWlisten"
                Dim heartbeat As String = Path.Combine(Path.GetDirectoryName(queue), "listener.alive")
                If Not NWListenerAlive(heartbeat) Then
                    Dim startup As DateTime = DateTime.UtcNow.AddSeconds(5)
                    If Process.GetProcessesByName("3dsmax").Length = 0 Then
                        Process.Start(New ProcessStartInfo(Path.Combine(maxRoot, "3dsmax.exe"), "-U MAXScript """ & listener & """") With {.UseShellExecute = False})
                        startup = DateTime.UtcNow.AddMinutes(2)
                    End If
                    ' Allow an already-running listener to discover this application's folder.
                    Do While Not NWListenerAlive(heartbeat)
                        If meter.IsDisposed OrElse IsDisposed Then Return
                        If DateTime.UtcNow > startup Then Throw New TimeoutException("NWlisten did not connect. In 3ds Max, run scripts\NWlisten\NWlisten.ms and retry.")
                        Await Task.Delay(500)
                    Loop
                End If
                meter.progress = 10
                meter.status = "Extracting MDL and MDX"
                job = Path.Combine(queue, Guid.NewGuid().ToString("N"))
                Directory.CreateDirectory(job)
                Dim mdl As Byte() = ReadPreviewResource(node, node.ResRef, 2002, True)
                Dim mdx As Byte() = ReadPreviewResource(node, node.ResRef, 3008, False)
                If mdl Is Nothing OrElse mdx Is Nothing Then Throw New InvalidDataException("The model or companion MDX is missing.")
                Dim input As String = Path.Combine(job, "model.mdl")
                Dim ascii As String = Path.Combine(job, "model-ascii.mdl")
                File.WriteAllBytes(input, mdl)
                File.WriteAllBytes(Path.Combine(job, "model.mdx"), mdx)
                Dim manager As New clsPluginManager()
                manager.LoadPlugins()
                Dim plugin As clsPluginDefinition = manager.FindPluginForResource("mdl", "decompile")
                If plugin Is Nothing Then Throw New InvalidOperationException("Install and enable the MDLOps plugin first.")
                meter.progress = 25
                meter.status = "Converting model with MDLOps"
                Dim result As clsPluginExecutionResult = manager.ExecutePlugin(plugin, input, ascii, game + 1, "model.mdl", "model", "mdl", "decompile", "")
                If result Is Nothing OrElse Not result.Success OrElse Not File.Exists(ascii) Then Throw New InvalidOperationException("MDLOps could not prepare the ASCII model.")
                meter.progress = 50
                meter.status = "Preparing textures"
                ' Include archive-local textures before falling back to game texture packs.
                Dim textures As String = Path.Combine(job, "model-textures.txt")
                If File.Exists(textures) Then
                    For Each name As String In File.ReadAllLines(textures)
                        name = name.Trim()
                        If name.Length = 0 OrElse name.Equals("null", StringComparison.OrdinalIgnoreCase) Then Continue For
                        If name <> Path.GetFileName(name) OrElse name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 Then Continue For
                        Dim data As Byte() = ReadPreviewResource(node, name, 3007, False)
                        If data Is Nothing Then data = TryGetTextureDataFromCommonPacks(game, name)
                        If data IsNot Nothing Then
                            clsImageExtraction.ExportTPC(data, Path.Combine(job, name & ".tga"), "TGA")
                        Else
                            meter.AppendDetail("Texture not found: " & name)
                        End If
                    Next
                End If
                If meter.IsDisposed OrElse IsDisposed Then Return
                meter.progress = 65
                meter.status = "Waiting for NWlisten to import into the current scene"
                File.WriteAllText(Path.Combine(job, "request.tmp"), "NWlisten/1", New UTF8Encoding(False))
                File.Move(Path.Combine(job, "request.tmp"), Path.Combine(job, "request.ready"))
                Dim deadline As DateTime = DateTime.UtcNow.AddMinutes(10)
                Do
                    If meter.IsDisposed OrElse IsDisposed Then Return
                    Dim response As String = Path.Combine(job, "result.txt")
                    If File.Exists(response) Then
                        Dim answer As String = File.ReadAllText(response)
                        If Not answer.StartsWith("OK" & vbLf, StringComparison.Ordinal) Then Throw New InvalidOperationException(answer)
                        meter.progress = 100
                        meter.status = "Imported " & node.ResRef & " into 3DS Max (2021)"
                        meter.AppendDetail("Assets retained in " & job)
                        Await Task.Delay(1800)
                        meter.Close()
                        Exit Do
                    End If
                    If File.Exists(Path.Combine(job, "request.working")) Then meter.progress = 80
                    If DateTime.UtcNow > deadline Then Throw New TimeoutException("NWlisten has not confirmed completion. Check Max before retrying; an import already started may still finish.")
                    Await Task.Delay(300)
                Loop
            Catch ex As System.Exception
                If Not meter.IsDisposed Then
                    meter.status = "Send failed: " & ex.Message
                    meter.AppendDetail(ex.ToString())
                    meter.OperationSubtitle = "Close this progress window when finished."
                End If
            Finally
                ' Withdraw only unclaimed work; never delete assets referenced by a Max scene.
                If job IsNot Nothing Then
                    Try
                        File.Delete(Path.Combine(job, "request.ready"))
                    Catch ex As IOException
                    End Try
                End If
                modelPreviewBusy = False
                nwSendBusy = False
            End Try
        End Sub

        Private Shared Function NWRegisterApplicationDirectory(ByVal applicationDirectory As String) As String
            Dim folder As String = Path.GetFullPath(applicationDirectory)
            Dim root As String = Path.Combine(folder, "working", "NWlisten")
            ' Use the same application-local working folder as GetWorkingDirectoryPath.
            ' A write failure must not fall back to the user profile.
            Directory.CreateDirectory(root)
            Using userKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.CurrentUser, Microsoft.Win32.RegistryView.Registry64)
                Using bridgeKey As Microsoft.Win32.RegistryKey = userKey.CreateSubKey("Software\KotOR Tool\NWlisten")
                    bridgeKey.SetValue("ApplicationDirectory", folder, Microsoft.Win32.RegistryValueKind.String)
                End Using
            End Using
            Return root
        End Function

        Private Shared Function NWListenerAlive(ByVal heartbeat As String) As Boolean
            Return File.Exists(heartbeat) AndAlso DateTime.UtcNow.Subtract(File.GetLastWriteTimeUtc(heartbeat)).TotalSeconds < 5
        End Function
    End Class
End Namespace
