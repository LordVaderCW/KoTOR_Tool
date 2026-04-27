Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System.Windows.Forms

Namespace kotor_tool
    ' Token: 0x02000091 RID: 145
    Public Class UserSettings

        Private Shared Function GetApplicationSettingsPath() As String
            Return Path.Combine(Application.StartupPath, "settings.xml")
        End Function

        Private Shared Function GetLegacySettingsPath() As String
            Try
                Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\SCM\Kotor Tool")

                If registryKey Is Nothing Then
                    Return Nothing
                End If

                Dim installPathObj As Object = registryKey.GetValue("path")

                If installPathObj Is Nothing Then
                    Return Nothing
                End If

                Return Path.Combine(StringType.FromObject(installPathObj), "settings.xml")
            Catch ex As System.Exception
                Return Nothing
            End Try
        End Function

        Private Shared Function GetLegacyInstallPath() As String
            Try
                Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\SCM\Kotor Tool")

                If registryKey Is Nothing Then
                    Return Application.StartupPath
                End If

                Dim installPathObj As Object = registryKey.GetValue("path")

                If installPathObj Is Nothing Then
                    Return Application.StartupPath
                End If

                Return StringType.FromObject(installPathObj)
            Catch ex As System.Exception
                Return Application.StartupPath
            End Try
        End Function

        ' Token: 0x0600180F RID: 6159 RVA: 0x002CD274 File Offset: 0x002CC274
        Public Shared Function GetSettings() As Options
            Dim options3 As Options

            Try
                Dim text As String = GetApplicationSettingsPath()
                Dim legacyText As String = GetLegacySettingsPath()
                Dim options As Options = Nothing

                If File.Exists(text) Then
                    Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Options))

                    Using fileStream As FileStream = New FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read)
                        options = CType(xmlSerializer.Deserialize(fileStream), Options)
                    End Using
                ElseIf legacyText IsNot Nothing AndAlso File.Exists(legacyText) Then
                    Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Options))

                    Using fileStream As FileStream = New FileStream(legacyText, FileMode.Open, FileAccess.Read, FileShare.Read)
                        options = CType(xmlSerializer.Deserialize(fileStream), Options)
                    End Using

                    ' Preserve old install behaviour, but migrate a readable legacy settings.xml
                    ' into the application directory when possible.
                    Try
                        SaveSettings(options)
                    Catch ex As System.Exception
                    End Try
                Else
                    options = New Options()
                    options.defaultSaveLocation = GetLegacyInstallPath()

                    If options.defaultSaveLocation Is Nothing OrElse StringType.StrCmp(options.defaultSaveLocation, "", False) = 0 Then
                        options.defaultSaveLocation = Application.StartupPath
                    End If

                    If Not options.defaultSaveLocation.EndsWith("\") Then
                        Dim options2 As Options = options
                        options2.defaultSaveLocation += "\"
                    End If
                End If

                options3 = options
            Catch ex As System.Exception
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "")
                options3 = Nothing
            End Try

            Return options3
        End Function

        ' Token: 0x06001810 RID: 6160 RVA: 0x002CD374 File Offset: 0x002CC374
        Public Shared Sub SaveSettings(ByVal currentSettings As Options)
            Try
                If currentSettings Is Nothing Then
                    Return
                End If

                Dim text As String = GetApplicationSettingsPath()
                Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Options))

                Using fileStream As FileStream = New FileStream(text, FileMode.Create, FileAccess.Write, FileShare.None)
                    xmlSerializer.Serialize(fileStream, currentSettings)
                End Using
            Catch ex As UnauthorizedAccessException
                Interaction.MsgBox( _
                 "Kotor Tool could not save settings.xml beside the application:" & vbCrLf & vbCrLf & _
                 GetApplicationSettingsPath() & vbCrLf & vbCrLf & _
                 "Move Kotor Tool to a writable folder, or run it as Administrator.", _
                 MsgBoxStyle.Exclamation, _
                 "Settings Save Error" _
                )
            Catch ex As System.Exception
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, Nothing)
            End Try
        End Sub
    End Class
End Namespace