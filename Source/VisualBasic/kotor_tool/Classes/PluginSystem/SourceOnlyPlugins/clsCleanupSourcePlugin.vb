Option Strict Off
Option Explicit On

Imports System
Imports System.IO

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsCleanupSourcePlugin.vb
    '
    ' Cleans temporary folders created by the source-only plugin pipeline.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - This class only cleans temporary build/extraction folders.
    '   - It does not delete the downloaded source ZIP cache unless explicitly
    '     asked to do so.
    ' -----------------------------------------------------------------

    Public Class clsCleanupSourcePlugin

        Public Event ProgressChanged(ByVal sender As Object, ByVal e As clsPluginProgressEventArgs)

        Public Sub Cleanup(ByVal context As clsSourcePluginContext)

            If context Is Nothing Then
                Return
            End If

            Me.ReportProgress("Cleaning Source Plugin", "Cleaning temporary source plugin folders...", 98)

            If context.TempRoot IsNot Nothing AndAlso context.TempRoot.Trim().Length > 0 Then
                Me.DeleteDirectorySafe(context.TempRoot)
            End If

            Me.ReportProgress("Cleaning Source Plugin", "Source plugin cleanup complete.", 100)
        End Sub

        Public Sub CleanupDownloadedSourceArchive(ByVal context As clsSourcePluginContext)

            If context Is Nothing Then
                Return
            End If

            If context.SourceZipPath Is Nothing OrElse context.SourceZipPath.Trim().Length = 0 Then
                Return
            End If

            Try
                If File.Exists(context.SourceZipPath) Then
                    File.SetAttributes(context.SourceZipPath, FileAttributes.Normal)
                    File.Delete(context.SourceZipPath)
                End If
            Catch ex As System.Exception
            End Try
        End Sub

        Private Sub DeleteDirectorySafe(ByVal directoryPath As String)

            If directoryPath Is Nothing OrElse directoryPath.Trim().Length = 0 Then
                Return
            End If

            Try
                If Directory.Exists(directoryPath) Then
                    Me.NormalizeDirectoryAttributes(directoryPath)
                    Directory.Delete(directoryPath, True)
                End If
            Catch ex As System.Exception
            End Try
        End Sub

        Private Sub NormalizeDirectoryAttributes(ByVal directoryPath As String)

            If directoryPath Is Nothing OrElse directoryPath.Trim().Length = 0 Then
                Return
            End If

            If Not Directory.Exists(directoryPath) Then
                Return
            End If

            Try
                Dim directoryInfo As DirectoryInfo = New DirectoryInfo(directoryPath)
                directoryInfo.Attributes = FileAttributes.Directory

                Dim fileInfos As FileInfo() = directoryInfo.GetFiles("*", SearchOption.AllDirectories)

                For Each fileInfo As FileInfo In fileInfos
                    Try
                        fileInfo.Attributes = FileAttributes.Normal
                    Catch exFile As System.Exception
                    End Try
                Next

                Dim directoryInfos As DirectoryInfo() = directoryInfo.GetDirectories("*", SearchOption.AllDirectories)

                For Each childDirectory As DirectoryInfo In directoryInfos
                    Try
                        childDirectory.Attributes = FileAttributes.Directory
                    Catch exDirectory As System.Exception
                    End Try
                Next

            Catch ex As System.Exception
            End Try
        End Sub

        Private Sub ReportProgress(ByVal messageText As String,
                                   ByVal statusText As String,
                                   ByVal progressValue As Integer)

            RaiseEvent ProgressChanged(Me, New clsPluginProgressEventArgs(messageText, statusText, progressValue))
        End Sub

    End Class

End Namespace