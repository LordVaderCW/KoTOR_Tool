Option Strict Off
Option Explicit On

Imports System
Imports System.IO

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsSourcePluginContext.vb
    '
    ' Shared state object used by the source-only plugin pipeline.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Keeps the source-only plugin build pipeline clean.
    '   - Avoids passing long parameter chains between pipeline classes.
    ' -----------------------------------------------------------------

    Public Class clsSourcePluginContext

        Public Plugin As clsPluginDefinition

        Public PluginId As String
        Public PluginName As String
        Public SourceZipUrl As String

        Public DownloadRoot As String
        Public PluginsRoot As String
        Public TempRoot As String

        Public SourceZipPath As String
        Public ExtractRoot As String
        Public SourceRoot As String

        Public BuildScriptPath As String
        Public BuildOutputDirectory As String
        Public BuiltExecutablePath As String

        Public InstallDirectory As String
        Public InstalledExecutablePath As String

        Public Sub New()
        End Sub

        Public Shared Function CreateGhostRiggerContext(ByVal plugin As clsPluginDefinition,
                                                        ByVal downloadRoot As String,
                                                        ByVal pluginsRoot As String) As clsSourcePluginContext

            Dim context As clsSourcePluginContext = New clsSourcePluginContext()

            context.Plugin = plugin
            context.PluginId = "ghostrigger"
            context.PluginName = "GhostRigger / KotOR 3D Model Converter"
            context.SourceZipUrl = "https://github.com/CrispyW0nton/Kotor-3D-Model-Converter/archive/refs/heads/genspark_ai_developer.zip"

            context.PluginsRoot = pluginsRoot

            context.InstallDirectory = Path.Combine(pluginsRoot, "GhostRigger")
            context.InstalledExecutablePath = Path.Combine(context.InstallDirectory, "GhostRigger-K1-K2.exe")

            context.TempRoot = Path.Combine(context.InstallDirectory, "_Build")
            context.DownloadRoot = Path.Combine(context.TempRoot, "downloads")
            context.ExtractRoot = Path.Combine(context.TempRoot, "extract")
            context.SourceZipPath = Path.Combine(context.DownloadRoot, "GhostRigger-genspark_ai_developer.zip")

            Return context
        End Function

    End Class

End Namespace
