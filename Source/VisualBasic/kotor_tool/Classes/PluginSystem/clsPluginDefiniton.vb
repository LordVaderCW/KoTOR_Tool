Option Strict Off
Option Explicit On

Imports System.Collections

Namespace kotor_tool

    ' -----------------------------------------------------------------
    ' clsPluginDefinition.vb
    '
    ' Plugin identity and capability definition for the KoTOR Tool
    ' Restoration Project external plugin system.
    '
    ' Original Tool:
    '   Fred Tetra's KotOR Tool
    '
    ' Restoration Project:
    '   KoTOR Tool Restoration Project
    '
    ' Notes:
    '   - VS2010 / .NET Framework 2.0 compatible.
    '   - Loaded from Plugins\InstalledPlugins.xml and each plugin.xml file.
    '   - Command execution data is loaded separately from command.ini.
    ' -----------------------------------------------------------------

    Public Class clsPluginDefinition

        ' -------------------------------------------------------------
        ' InstalledPlugins.xml registry data
        ' -------------------------------------------------------------
        Public InstalledId As String
        Public InstalledName As String
        Public InstalledDirectory As String
        Public InstalledVersion As String
        Public ManifestFileName As String
        Public ManifestPath As String

        ' -------------------------------------------------------------
        ' plugin.xml manifest data
        ' -------------------------------------------------------------
        Public Id As String
        Public Name As String
        Public Author As String
        Public Version As String
        Public PluginType As String
        Public Description As String
        Public Enabled As Boolean

        Public PluginDirectory As String
        Public CommandIniFileName As String
        Public CommandIniPath As String

        Public AppFolderName As String
        Public ConfigFolderName As String
        Public RuntimeFolderName As String
        Public ToolsFolderName As String

        Public AppDirectory As String
        Public ConfigDirectory As String
        Public RuntimeDirectory As String
        Public ToolsDirectory As String

        ' -------------------------------------------------------------
        ' Compatibility metadata
        ' -------------------------------------------------------------
        Public CompatibleApplication As String
        Public MinimumAppVersion As String
        Public Framework As String
        Public Platform As String

        ' -------------------------------------------------------------
        ' Project metadata
        ' -------------------------------------------------------------
        Public GitHubRepo As String
        Public GitHubBranch As String
        Public Website As String

        ' -------------------------------------------------------------
        ' Capabilities and file requirements
        ' -------------------------------------------------------------
        Public ResourceHandles As ArrayList
        Public RequiredFiles As ArrayList
        Public OptionalFiles As ArrayList

        Public Sub New()
            Me.InstalledId = ""
            Me.InstalledName = ""
            Me.InstalledDirectory = ""
            Me.InstalledVersion = ""
            Me.ManifestFileName = "plugin.xml"
            Me.ManifestPath = ""

            Me.Id = ""
            Me.Name = ""
            Me.Author = ""
            Me.Version = ""
            Me.PluginType = "ExternalTool"
            Me.Description = ""
            Me.Enabled = True

            Me.PluginDirectory = ""
            Me.CommandIniFileName = "command.ini"
            Me.CommandIniPath = ""

            Me.CompatibleApplication = ""
            Me.MinimumAppVersion = ""
            Me.Framework = ""
            Me.Platform = ""

            Me.GitHubRepo = ""
            Me.GitHubBranch = ""
            Me.Website = ""

            Me.AppFolderName = "app"
            Me.ConfigFolderName = "config"
            Me.RuntimeFolderName = "runtime"
            Me.ToolsFolderName = "tools"

            Me.AppDirectory = ""
            Me.ConfigDirectory = ""
            Me.RuntimeDirectory = ""
            Me.ToolsDirectory = ""

            Me.ResourceHandles = New ArrayList()
            Me.RequiredFiles = New ArrayList()
            Me.OptionalFiles = New ArrayList()
        End Sub

        Public Overrides Function ToString() As String
            If Me.Name IsNot Nothing AndAlso Me.Name.Trim().Length > 0 Then
                Return Me.Name
            End If

            If Me.InstalledName IsNot Nothing AndAlso Me.InstalledName.Trim().Length > 0 Then
                Return Me.InstalledName
            End If

            Return Me.Id
        End Function

    End Class

End Namespace