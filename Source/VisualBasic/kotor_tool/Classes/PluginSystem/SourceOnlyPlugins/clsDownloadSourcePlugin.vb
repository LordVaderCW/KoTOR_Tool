Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Net

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsDownloadSourcePlugin.vb
    '
    ' Downloads source-only plugin archives for the KoTOR Tool
    ' Restoration Project plugin system.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Handles source-only repositories that do not publish releases.
    '   - First supported source-only plugin target: GhostRigger.
    '   - This class only downloads source archives.
    '   - Extraction, compilation, installation, and cleanup are handled by
    '     their own SourceOnlyPlugins classes.
    ' -----------------------------------------------------------------

    Public Class clsDownloadSourcePlugin

        Public Event ProgressChanged(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)

        Private Const BufferSize As Integer = 32768
        Private Const UserAgentText As String = "KoTOR-Tool-Restoration-SourcePluginManager/1.0.3.4 (+https://github.com/LordVaderCW/KoTOR_Tool)"

        Public Function DownloadSource(ByVal context As clsSourcePluginContext) As clsSourcePluginContext

            If context Is Nothing Then
                Throw New ArgumentNullException("context")
            End If

            If context.SourceZipUrl Is Nothing OrElse context.SourceZipUrl.Trim().Length = 0 Then
                Throw New ApplicationException("The source-only plugin has no SourceZipUrl.")
            End If

            If context.DownloadRoot Is Nothing OrElse context.DownloadRoot.Trim().Length = 0 Then
                Throw New ArgumentException("context.DownloadRoot")
            End If

            If context.SourceZipPath Is Nothing OrElse context.SourceZipPath.Trim().Length = 0 Then
                Throw New ArgumentException("context.SourceZipPath")
            End If

            If Not Directory.Exists(context.DownloadRoot) Then
                Directory.CreateDirectory(context.DownloadRoot)
            End If

            Me.ConfigureSecureProtocol()

            Me.ReportProgress("Downloading Source Plugin", "Preparing source archive download...", 1)

            Dim tempPath As String = context.SourceZipPath & ".download"

            Me.DeleteIfExists(context.SourceZipPath)
            Me.DeleteIfExists(tempPath)

            Try
                Me.DownloadFileStreamed(New Uri(context.SourceZipUrl.Trim()), tempPath)

                If Not File.Exists(tempPath) Then
                    Throw New FileNotFoundException("Source archive download completed, but the temporary package was not found.", tempPath)
                End If

                Dim info As FileInfo = New FileInfo(tempPath)

                If info.Length <= 0 Then
                    Throw New ApplicationException("Source archive download completed, but the downloaded file is empty.")
                End If

                If Not Me.IsZipFile(tempPath) Then
                    Throw New ApplicationException("Source archive download completed, but the file is not a valid ZIP archive.")
                End If

                File.Move(tempPath, context.SourceZipPath)

            Catch ex As System.Exception
                Try
                    Me.DeleteIfExists(tempPath)
                Catch exCleanup As System.Exception
                End Try

                Throw New ApplicationException("Source plugin download failed: " & ex.Message, ex)
            End Try

            If Not File.Exists(context.SourceZipPath) Then
                Throw New FileNotFoundException("Source archive download completed, but the final ZIP package was not found.", context.SourceZipPath)
            End If

            Me.ReportProgress("Downloading Source Plugin", "Source archive download complete.", 28)

            Return context
        End Function

        Private Sub DownloadFileStreamed(ByVal downloadUri As Uri,
                                         ByVal tempPath As String)

            Dim request As HttpWebRequest = CType(WebRequest.Create(downloadUri), HttpWebRequest)
            request.Method = "GET"
            request.UserAgent = UserAgentText
            request.AllowAutoRedirect = True
            request.Timeout = 30000
            request.ReadWriteTimeout = 30000

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

                If response.StatusCode <> HttpStatusCode.OK Then
                    Throw New ApplicationException("Source archive download failed. HTTP status: " & response.StatusCode.ToString())
                End If

                Dim totalBytes As Long = response.ContentLength
                Dim receivedBytes As Long = 0
                Dim lastProgress As Integer = -1
                Dim lastReportTime As DateTime = DateTime.MinValue

                Using inputStream As Stream = response.GetResponseStream()
                    Using outputStream As FileStream = New FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.None)

                        Dim buffer(BufferSize - 1) As Byte
                        Dim readCount As Integer = inputStream.Read(buffer, 0, buffer.Length)

                        While readCount > 0
                            outputStream.Write(buffer, 0, readCount)
                            receivedBytes += readCount

                            Me.ReportDownloadProgress(receivedBytes, totalBytes, lastProgress, lastReportTime)

                            readCount = inputStream.Read(buffer, 0, buffer.Length)
                        End While

                    End Using
                End Using

            End Using
        End Sub

        Private Sub ReportDownloadProgress(ByVal receivedBytes As Long,
                                           ByVal totalBytes As Long,
                                           ByRef lastProgress As Integer,
                                           ByRef lastReportTime As DateTime)

            Dim mappedProgress As Integer
            Dim percentText As String

            If totalBytes > 0 Then
                Dim percent As Integer = CInt(Math.Floor((CDbl(receivedBytes) / CDbl(totalBytes)) * 100.0R))

                If percent < 0 Then
                    percent = 0
                End If

                If percent > 100 Then
                    percent = 100
                End If

                mappedProgress = 3 + CInt(Math.Floor((CDbl(percent) / 100.0R) * 23.0R))
                percentText = percent.ToString() & "%"
            Else
                mappedProgress = 8
                percentText = Me.FormatBytes(receivedBytes) & " received"
            End If

            If mappedProgress = lastProgress AndAlso DateTime.Now.Subtract(lastReportTime).TotalMilliseconds < 500.0R Then
                Return
            End If

            lastProgress = mappedProgress
            lastReportTime = DateTime.Now

            Dim statusText As String = "Downloading source archive... " & percentText

            If totalBytes > 0 Then
                statusText &= "  (" & Me.FormatBytes(receivedBytes) & " / " & Me.FormatBytes(totalBytes) & ")"
            End If

            Me.ReportProgress("Downloading Source Plugin", statusText, mappedProgress)
        End Sub

        Private Function IsZipFile(ByVal filePath As String) As Boolean
            If Not File.Exists(filePath) Then
                Return False
            End If

            Using stream As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)

                If stream.Length < 4 Then
                    Return False
                End If

                Dim b1 As Integer = stream.ReadByte()
                Dim b2 As Integer = stream.ReadByte()
                Dim b3 As Integer = stream.ReadByte()
                Dim b4 As Integer = stream.ReadByte()

                Return b1 = &H50 AndAlso b2 = &H4B AndAlso
                    ((b3 = &H3 AndAlso b4 = &H4) OrElse
                     (b3 = &H5 AndAlso b4 = &H6) OrElse
                     (b3 = &H7 AndAlso b4 = &H8))
            End Using
        End Function

        Private Function FormatBytes(ByVal byteCount As Long) As String
            If byteCount >= 1073741824 Then
                Return (CDbl(byteCount) / 1073741824.0R).ToString("0.00") & " GB"
            End If

            If byteCount >= 1048576 Then
                Return (CDbl(byteCount) / 1048576.0R).ToString("0.00") & " MB"
            End If

            If byteCount >= 1024 Then
                Return (CDbl(byteCount) / 1024.0R).ToString("0.00") & " KB"
            End If

            Return byteCount.ToString() & " bytes"
        End Function

        Private Sub DeleteIfExists(ByVal filePath As String)
            If filePath Is Nothing OrElse filePath.Trim().Length = 0 Then
                Return
            End If

            If File.Exists(filePath) Then
                File.SetAttributes(filePath, FileAttributes.Normal)
                File.Delete(filePath)
            End If
        End Sub

        Private Sub ConfigureSecureProtocol()
            Try
                ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType) Or CType(768, SecurityProtocolType) Or SecurityProtocolType.Tls
                ServicePointManager.Expect100Continue = False
            Catch ex As System.Exception
                ServicePointManager.Expect100Continue = False
            End Try
        End Sub

        Private Sub ReportProgress(ByVal messageText As String,
                                   ByVal statusText As String,
                                   ByVal progressValue As Integer)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs(messageText, statusText, progressValue))
        End Sub

    End Class

End Namespace