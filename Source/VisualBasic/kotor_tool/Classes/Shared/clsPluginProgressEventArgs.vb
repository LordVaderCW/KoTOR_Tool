Option Strict Off
Option Explicit On

Imports System

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsPluginProgressEventArgs.vb
    '
    ' Progress event payload for the KoTOR Tool Restoration Project
    ' plugin download and installation system.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Used by clsDownloadPlugin and clsInstallPlugin.
    '   - Designed to feed frmProgressMeter without coupling the worker
    '     classes directly to a WinForms dialog.
    ' -----------------------------------------------------------------

    Public Class clsPluginProgressEventArgs
        Inherits EventArgs

        Public Message As String
        Public Status As String
        Public Progress As Integer

        Public Sub New()
            Me.Message = ""
            Me.Status = ""
            Me.Progress = 0
        End Sub

        Public Sub New(ByVal messageText As String,
                       ByVal statusText As String,
                       ByVal progressValue As Integer)

            If messageText Is Nothing Then
                Me.Message = ""
            Else
                Me.Message = messageText
            End If

            If statusText Is Nothing Then
                Me.Status = ""
            Else
                Me.Status = statusText
            End If

            If progressValue < 0 Then
                progressValue = 0
            End If

            If progressValue > 100 Then
                progressValue = 100
            End If

            Me.Progress = progressValue
        End Sub

    End Class

End Namespace
