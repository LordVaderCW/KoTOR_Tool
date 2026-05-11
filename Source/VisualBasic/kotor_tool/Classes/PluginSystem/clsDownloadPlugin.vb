Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsDownloadPlugin.vb
    '
    ' Downloads available plugin packages for the KoTOR Tool Restoration
    ' Project plugin system.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Uses HttpWebRequest streaming instead of WebClient async callbacks.
    '   - Avoids progress-event storms and UI re-entrancy issues.
    '   - Supports GitHub repository URLs by resolving release assets.
    '   - Must be called from the plugin worker thread, not the UI thread.
    ' -----------------------------------------------------------------

    Public Class clsDownloadPlugin

        Public Event ProgressChanged(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)

        Private Const BufferSize As Integer = 32768
        Private Const UserAgentText As String = "KoTOR-Tool-Restoration-PluginManager/1.0.3.3 (+https://github.com/LordVaderCW/KoTOR_Tool)"

        Public Function DownloadPlugin(ByVal plugin As clsPluginDefinition,
                                       ByVal downloadRoot As String) As String

            If plugin Is Nothing Then
                Throw New ArgumentNullException("plugin")
            End If

            If plugin.DownloadUrl Is Nothing OrElse plugin.DownloadUrl.Trim().Length = 0 Then
                Throw New ApplicationException("The selected plugin has no DownloadUrl in AvailablePlugins.xml.")
            End If

            If downloadRoot Is Nothing OrElse downloadRoot.Trim().Length = 0 Then
                Throw New ArgumentException("downloadRoot")
            End If

            If Not Directory.Exists(downloadRoot) Then
                Directory.CreateDirectory(downloadRoot)
            End If

            Me.ConfigureSecureProtocol()

            Me.ReportProgress("Downloading Plugin", "Resolving plugin download package...", 3)

            Dim resolvedUrl As String = Me.ResolveDownloadUrl(plugin)
            Dim downloadUri As Uri = Me.CreateDownloadUri(resolvedUrl)

            Dim fileName As String = Path.GetFileName(downloadUri.AbsolutePath)

            If fileName Is Nothing OrElse fileName.Trim().Length = 0 Then
                fileName = plugin.Id & "-" & plugin.Version & ".zip"
            End If

            If fileName.IndexOf("?"c) >= 0 Then
                fileName = fileName.Substring(0, fileName.IndexOf("?"c))
            End If

            Dim outputPath As String = Path.Combine(downloadRoot, fileName)
            Dim tempPath As String = outputPath & ".download"

            Me.DeleteIfExists(outputPath)
            Me.DeleteIfExists(tempPath)

            Me.ReportProgress("Downloading Plugin", "Preparing download request...", 5)

            Try
                Me.DownloadFileStreamed(downloadUri, tempPath)

                If Not File.Exists(tempPath) Then
                    Throw New FileNotFoundException("Plugin download completed, but the temporary package was not found.", tempPath)
                End If

                Dim tempInfo As FileInfo = New FileInfo(tempPath)

                If tempInfo.Length <= 0 Then
                    Throw New ApplicationException("Plugin download completed, but the downloaded file is empty.")
                End If

                'If Not Me.IsZipFile(tempPath) Then
                'Throw New ApplicationException("Plugin download completed, but the downloaded file is not a valid ZIP package. The GitHub release may be returning a non-ZIP asset, HTML page, EXE, 7Z, or unsupported package type.")
                'End If

                ' Patch v.1.0.3.5 - 11.05.26 - Patched to include, .7z github repo archives, rar, and zip
                If Not Me.IsSupportedPluginPackage(tempPath, outputPath) Then
                    Throw New ApplicationException("Plugin download completed, but the downloaded file is not a supported plugin archive. Supported package formats are ZIP, 7Z, and RAR.")
                End If

                File.Move(tempPath, outputPath)

            Catch ex As System.Exception
                Try
                    Me.DeleteIfExists(tempPath)
                Catch exCleanup As System.Exception
                End Try

                Throw New ApplicationException("Plugin download failed: " & ex.Message, ex)
            End Try

            If Not File.Exists(outputPath) Then
                Throw New FileNotFoundException("Plugin download completed, but the zip package was not found.", outputPath)
            End If

            Me.ReportProgress("Downloading Plugin", "Download complete.", 55)

            Return outputPath
        End Function

        Private Function ResolveDownloadUrl(ByVal plugin As clsPluginDefinition) As String
            Dim rawUrl As String = plugin.DownloadUrl.Trim()

            If Not Me.IsGithubRepositoryUrl(rawUrl) Then
                Return rawUrl
            End If

            Dim owner As String = ""
            Dim repo As String = ""

            If Not Me.TryParseGithubRepository(rawUrl, owner, repo) Then
                Return rawUrl
            End If

            If plugin.Version IsNot Nothing AndAlso plugin.Version.Trim().Length > 0 Then
                Dim versionText As String = plugin.Version.Trim()

                Dim versionApiUrl As String = "https://api.github.com/repos/" & owner & "/" & repo & "/releases/tags/v" & versionText
                Dim versionAssetUrl As String = Me.TryGetGithubReleaseAssetUrl(versionApiUrl)

                If versionAssetUrl.Length > 0 Then
                    Return versionAssetUrl
                End If

                versionApiUrl = "https://api.github.com/repos/" & owner & "/" & repo & "/releases/tags/" & versionText
                versionAssetUrl = Me.TryGetGithubReleaseAssetUrl(versionApiUrl)

                If versionAssetUrl.Length > 0 Then
                    Return versionAssetUrl
                End If
            End If

            Dim latestApiUrl As String = "https://api.github.com/repos/" & owner & "/" & repo & "/releases/latest"
            Dim latestAssetUrl As String = Me.TryGetGithubReleaseAssetUrl(latestApiUrl)

            If latestAssetUrl.Length > 0 Then
                Return latestAssetUrl
            End If

            Throw New ApplicationException("No downloadable GitHub release asset could be found for " & owner & "/" & repo & ".")
        End Function

        Private Function IsGithubRepositoryUrl(ByVal urlText As String) As Boolean
            If urlText Is Nothing Then
                Return False
            End If

            Dim lowered As String = urlText.ToLowerInvariant()

            If lowered.IndexOf("github.com/") < 0 Then
                Return False
            End If

            If lowered.IndexOf("/releases/download/") >= 0 Then
                Return False
            End If

            If lowered.IndexOf("/archive/") >= 0 Then
                Return False
            End If

            If lowered.EndsWith(".zip") OrElse lowered.EndsWith(".7z") OrElse lowered.EndsWith(".rar") OrElse lowered.EndsWith(".exe") Then
                Return False
            End If

            Return True
        End Function

        Private Function TryParseGithubRepository(ByVal urlText As String,
                                                  ByRef owner As String,
                                                  ByRef repo As String) As Boolean
            owner = ""
            repo = ""

            Try
                Dim uri As Uri = New Uri(urlText.Trim())
                Dim pathText As String = uri.AbsolutePath.Trim("/"c)
                Dim parts As String() = pathText.Split("/"c)

                If parts Is Nothing OrElse parts.Length < 2 Then
                    Return False
                End If

                owner = parts(0).Trim()
                repo = parts(1).Trim()

                If repo.ToLowerInvariant().EndsWith(".git") Then
                    repo = repo.Substring(0, repo.Length - 4)
                End If

                Return owner.Length > 0 AndAlso repo.Length > 0

            Catch ex As System.Exception
                Return False
            End Try
        End Function

        Private Function TryGetGithubReleaseAssetUrl(ByVal apiUrl As String) As String
            Try
                Me.ReportProgress("Downloading Plugin", "Checking GitHub release metadata...", 4)

                Dim json As String = Me.DownloadString(apiUrl)

                If json Is Nothing OrElse json.Length = 0 Then
                    Return ""
                End If

                'Dim zipMatch As Match = Regex.Match(json, """browser_download_url""\s*:\s*""(?<url>[^""]+\.zip)""", RegexOptions.IgnoreCase)

                'If zipMatch.Success Then
                'Return Me.UnescapeJsonUrl(zipMatch.Groups("url").Value)
                'End If

                ' Patch v.1.0.3.5 - 11.05.26 - Patched to include, .7z github repo archives, rar, and zip

                Dim packageMatch As Match = Regex.Match(json, """browser_download_url""\s*:\s*""(?<url>[^""]+\.(zip|7z|rar))""", RegexOptions.IgnoreCase)

                If packageMatch.Success Then
                    Return Me.UnescapeJsonUrl(packageMatch.Groups("url").Value)
                End If

                Dim anyMatch As Match = Regex.Match(json, """browser_download_url""\s*:\s*""(?<url>[^""]+)""", RegexOptions.IgnoreCase)

                If anyMatch.Success Then
                    Return Me.UnescapeJsonUrl(anyMatch.Groups("url").Value)
                End If

            Catch ex As WebException
                Return ""
            Catch ex As System.Exception
                Return ""
            End Try

            Return ""
        End Function

        Private Function DownloadString(ByVal urlText As String) As String
            Dim request As HttpWebRequest = CType(WebRequest.Create(urlText), HttpWebRequest)
            request.Method = "GET"
            request.UserAgent = UserAgentText
            request.Accept = "application/vnd.github.v3+json"
            request.Headers(HttpRequestHeader.AcceptEncoding) = "identity"
            request.Headers(HttpRequestHeader.CacheControl) = "no-cache"
            request.AllowAutoRedirect = True
            request.Timeout = 30000
            request.ReadWriteTimeout = 30000
            request.KeepAlive = False

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using stream As Stream = response.GetResponseStream()
                    If stream Is Nothing Then
                        Return ""
                    End If

                    Using reader As StreamReader = New StreamReader(stream)
                        Return reader.ReadToEnd()
                    End Using
                End Using
            End Using
        End Function

        Private Sub DownloadFileStreamed(ByVal downloadUri As Uri,
                                         ByVal outputPath As String)

            Dim request As HttpWebRequest = CType(WebRequest.Create(downloadUri), HttpWebRequest)
            request.Method = "GET"
            request.UserAgent = UserAgentText
            request.Accept = "application/octet-stream, application/zip, */*"
            request.Headers(HttpRequestHeader.AcceptEncoding) = "identity"
            request.Headers(HttpRequestHeader.CacheControl) = "no-cache"
            request.AllowAutoRedirect = True
            request.Timeout = 30000
            request.ReadWriteTimeout = 30000
            request.KeepAlive = False

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Dim totalBytes As Long = response.ContentLength
                Dim receivedBytes As Long = 0
                Dim buffer(BufferSize - 1) As Byte
                Dim lastProgress As Integer = -1
                Dim lastReportTime As DateTime = DateTime.MinValue

                Using responseStream As Stream = response.GetResponseStream()
                    If responseStream Is Nothing Then
                        Throw New ApplicationException("The remote server did not return a readable response stream.")
                    End If

                    Using fileStream As FileStream = New FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None)
                        Dim bytesRead As Integer = responseStream.Read(buffer, 0, buffer.Length)

                        Do While bytesRead > 0
                            fileStream.Write(buffer, 0, bytesRead)
                            receivedBytes += bytesRead

                            Me.ReportDownloadProgress(receivedBytes, totalBytes, lastProgress, lastReportTime)

                            bytesRead = responseStream.Read(buffer, 0, buffer.Length)
                        Loop
                    End Using
                End Using
            End Using
        End Sub


        Private Sub ReportDownloadProgress(ByVal receivedBytes As Long,
                                           ByVal totalBytes As Long,
                                           ByRef lastProgress As Integer,
                                           ByRef lastReportTime As DateTime)

            Dim mappedProgress As Integer = 10
            Dim percentText As String = ""

            If totalBytes > 0 Then
                Dim percent As Integer = CInt(Math.Floor((CDbl(receivedBytes) / CDbl(totalBytes)) * 100.0R))

                If percent < 0 Then
                    percent = 0
                End If

                If percent > 100 Then
                    percent = 100
                End If

                mappedProgress = 5 + CInt(Math.Floor((CDbl(percent) / 100.0R) * 50.0R))
                percentText = percent.ToString() & "%"
            Else
                mappedProgress = 10
                percentText = Me.FormatBytes(receivedBytes)
            End If

            If mappedProgress = lastProgress AndAlso DateTime.Now.Subtract(lastReportTime).TotalMilliseconds < 500.0R Then
                Return
            End If

            lastProgress = mappedProgress
            lastReportTime = DateTime.Now

            Dim statusText As String = "Downloading plugin package... " & percentText

            If totalBytes > 0 Then
                statusText &= "  (" & Me.FormatBytes(receivedBytes) & " / " & Me.FormatBytes(totalBytes) & ")"
            Else
                statusText &= " received"
            End If

            Me.ReportProgress("Downloading Plugin", statusText, mappedProgress)
        End Sub

        Private Sub ReportProgress(ByVal messageText As String,
                                   ByVal statusText As String,
                                   ByVal progressValue As Integer)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs(messageText, statusText, progressValue))
        End Sub

        Private Sub ConfigureSecureProtocol()
            Try
                ' .NET 2.0 / VS2010 compatible TLS constants.
                ' TLS 1.1 = 768
                ' TLS 1.2 = 3072
                ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType) Or CType(768, SecurityProtocolType) Or SecurityProtocolType.Tls
                ServicePointManager.Expect100Continue = False
            Catch ex As System.Exception
                ServicePointManager.Expect100Continue = False
            End Try
        End Sub

        Private Function CreateDownloadUri(ByVal urlText As String) As Uri
            Try
                Return New Uri(urlText.Trim())
            Catch exUri As System.Exception
                Throw New ApplicationException("The resolved plugin download URL is invalid: " & urlText, exUri)
            End Try
        End Function

        Private Function UnescapeJsonUrl(ByVal urlText As String) As String
            If urlText Is Nothing Then
                Return ""
            End If

            Return urlText.Replace("\/", "/")
        End Function

        Private Sub DeleteIfExists(ByVal filePath As String)
            If filePath Is Nothing OrElse filePath.Trim().Length = 0 Then
                Return
            End If

            If File.Exists(filePath) Then
                File.Delete(filePath)
            End If
        End Sub

        Private Function FormatBytes(ByVal byteCount As Long) As String
            Dim value As Double = CDbl(byteCount)

            If value >= 1048576.0R Then
                Return (value / 1048576.0R).ToString("0.00") & " MB"
            End If

            If value >= 1024.0R Then
                Return (value / 1024.0R).ToString("0.00") & " KB"
            End If

            Return byteCount.ToString() & " bytes"
        End Function

        'No longer used, but kept for archival. could be useful for something else later. LordVaderCW. 
        Private Function IsZipFile(ByVal filePath As String) As Boolean
            If filePath Is Nothing OrElse filePath.Trim().Length = 0 Then
                Return False
            End If

            If Not File.Exists(filePath) Then
                Return False
            End If

            Using fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                If fs.Length < 4 Then
                    Return False
                End If

                Dim b0 As Integer = fs.ReadByte()
                Dim b1 As Integer = fs.ReadByte()
                Dim b2 As Integer = fs.ReadByte()
                Dim b3 As Integer = fs.ReadByte()

                ' ZIP signatures:
                ' PK 03 04 = normal zip
                ' PK 05 06 = empty zip
                ' PK 07 08 = spanned zip descriptor
                If b0 = &H50 AndAlso b1 = &H4B Then
                    If b2 = &H3 AndAlso b3 = &H4 Then
                        Return True
                    End If

                    If b2 = &H5 AndAlso b3 = &H6 Then
                        Return True
                    End If

                    If b2 = &H7 AndAlso b3 = &H8 Then
                        Return True
                    End If
                End If
            End Using

            Return False
        End Function

        Private Function IsSupportedPluginPackage(ByVal filePath As String,
                                          ByVal finalPath As String) As Boolean

            If filePath Is Nothing OrElse filePath.Trim().Length = 0 Then
                Return False
            End If

            If Not File.Exists(filePath) Then
                Return False
            End If

            Dim extensionText As String = ""

            If finalPath IsNot Nothing Then
                extensionText = Path.GetExtension(finalPath).ToLowerInvariant()
            End If

            Using fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                If fs.Length < 6 Then
                    Return False
                End If

                Dim b0 As Integer = fs.ReadByte()
                Dim b1 As Integer = fs.ReadByte()
                Dim b2 As Integer = fs.ReadByte()
                Dim b3 As Integer = fs.ReadByte()
                Dim b4 As Integer = fs.ReadByte()
                Dim b5 As Integer = fs.ReadByte()

                ' ZIP signatures:
                ' PK 03 04 = normal zip
                ' PK 05 06 = empty zip
                ' PK 07 08 = spanned zip descriptor
                If b0 = &H50 AndAlso b1 = &H4B Then
                    If b2 = &H3 AndAlso b3 = &H4 Then
                        Return True
                    End If

                    If b2 = &H5 AndAlso b3 = &H6 Then
                        Return True
                    End If

                    If b2 = &H7 AndAlso b3 = &H8 Then
                        Return True
                    End If
                End If

                ' 7Z signature:
                ' 37 7A BC AF 27 1C
                If b0 = &H37 AndAlso b1 = &H7A AndAlso b2 = &HBC AndAlso b3 = &HAF AndAlso b4 = &H27 AndAlso b5 = &H1C Then
                    Return True
                End If

                ' RAR signature:
                ' Rar! 1A 07 ...
                If b0 = &H52 AndAlso b1 = &H61 AndAlso b2 = &H72 AndAlso b3 = &H21 AndAlso b4 = &H1A AndAlso b5 = &H7 Then
                    Return True
                End If
            End Using

            ' Fallback: allow known archive extensions where signature checking is inconclusive.
            If extensionText = ".zip" OrElse extensionText = ".7z" OrElse extensionText = ".rar" Then
                Return True
            End If

            Return False
        End Function

    End Class

End Namespace