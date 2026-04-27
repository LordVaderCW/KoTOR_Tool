Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace kotor_tool
	' Token: 0x02000068 RID: 104
	Public Partial Class frmPathManager
		Inherits Form

		' Token: 0x06000CD3 RID: 3283 RVA: 0x00283DE4 File Offset: 0x00282DE4
		Public Sub New()
			Me.InitializeComponent()
			Me.CreateNew()
		End Sub

        ' Token: 0x06000D0C RID: 3340 RVA: 0x00285478 File Offset: 0x00284478
        Public Sub CreateNew()
            Me.options = UserSettings.GetSettings()
            Me.tbKotorPath.Text = Me.options.KotorLocation(0)
            Me.tbKotorPath2.Text = Me.options.KotorLocation(1)
            Me.tbImportPath.Text = Me.options.defaultImportLocation
            Me.tbSavePath.Text = Me.options.defaultSaveLocation
            Me.tbImageViewerPath.Text = Me.options.ImageViewerLocation
            Me.tbModuleExportPath.Text = Me.options.ModelExportLocation
        End Sub

        ' Token: 0x06000D0D RID: 3341 RVA: 0x00285518 File Offset: 0x00284518
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.options.defaultKotORLocation = Me.tbKotorPath.Text
            Me.options.defaultKotORLocation2 = Me.tbKotorPath2.Text
            Me.options.defaultImportLocation = Me.tbImportPath.Text
            Me.options.defaultSaveLocation = Me.tbSavePath.Text
            Me.options.ImageViewerLocation = Me.tbImageViewerPath.Text
            Me.options.ModelExportLocation = Me.tbModuleExportPath.Text
            UserSettings.SaveSettings(Me.options)
        End Sub

        ' Token: 0x06000D0E RID: 3342 RVA: 0x002855B4 File Offset: 0x002845B4
        Private Sub BrowseForFolder(ByRef fld As TextBox)
            Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
            folderBrowserDialog.Description = "Locate folder"
            folderBrowserDialog.SelectedPath = fld.Text
            folderBrowserDialog.ShowNewFolderButton = False
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = folderBrowserDialog.SelectedPath
            End If
        End Sub

        ' Token: 0x06000D0F RID: 3343 RVA: 0x002855FC File Offset: 0x002845FC
        Private Sub BrowseForFile(ByRef fld As TextBox)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Title = "Select Chitin.key file..."
            openFileDialog.Filter = "Chitin files (*.key)|*.key"
            openFileDialog.InitialDirectory = fld.Text
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = False
            openFileDialog.RestoreDirectory = True
            openFileDialog.FileName = "chitin.key"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = openFileDialog.FileName
            End If
        End Sub

        ' Token: 0x06000D10 RID: 3344 RVA: 0x00285668 File Offset: 0x00284668
        Private Sub BrowseForApp(ByRef fld As TextBox)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Title = "Select Program file..."
            openFileDialog.Filter = "Image Viewer Application (*.exe)|*.exe"
            If StringType.StrCmp(fld.Text, "", False) <> 0 Then
                openFileDialog.InitialDirectory = Strings.Mid(fld.Text, 1, fld.Text.LastIndexOf("\"))
            End If
            openFileDialog.FilterIndex = 1
            openFileDialog.Multiselect = False
            openFileDialog.RestoreDirectory = True
            If StringType.StrCmp(fld.Text, "", False) <> 0 Then
                ' The following expression was wrapped in a checked-expression
                openFileDialog.FileName = Strings.Mid(fld.Text, fld.Text.LastIndexOf("\") + 2)
            End If
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                fld.Text = openFileDialog.FileName
            End If
        End Sub

        ' Token: 0x06000D11 RID: 3345 RVA: 0x00285730 File Offset: 0x00284730
        Private Sub btnKotorPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbKotorPath As TextBox = Me.tbKotorPath
            Me.BrowseForFolder(tbKotorPath)
            Me.tbKotorPath = tbKotorPath
        End Sub

        ' Token: 0x06000D12 RID: 3346 RVA: 0x00285754 File Offset: 0x00284754
        Private Sub btnImageViewerPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbImageViewerPath As TextBox = Me.tbImageViewerPath
            Me.BrowseForApp(tbImageViewerPath)
            Me.tbImageViewerPath = tbImageViewerPath
        End Sub

        ' Token: 0x06000D13 RID: 3347 RVA: 0x00285778 File Offset: 0x00284778
        Private Sub btnImportPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbImportPath As TextBox = Me.tbImportPath
            Me.BrowseForFolder(tbImportPath)
            Me.tbImportPath = tbImportPath
        End Sub

        ' Token: 0x06000D14 RID: 3348 RVA: 0x0028579C File Offset: 0x0028479C
        Private Sub btnSavePath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbSavePath As TextBox = Me.tbSavePath
            Me.BrowseForFolder(tbSavePath)
            Me.tbSavePath = tbSavePath
        End Sub

        ' Token: 0x06000D15 RID: 3349 RVA: 0x002857C0 File Offset: 0x002847C0
        Private Sub btnKotorPath2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbKotorPath As TextBox = Me.tbKotorPath2
            Me.BrowseForFolder(tbKotorPath)
            Me.tbKotorPath2 = tbKotorPath
        End Sub

        ' ---------------------------------------------------------------------
        ' KotOR Path Auto-Detection Upgrade
        ' ---------------------------------------------------------------------
        '
        ' Original decompiled behaviour:
        '
        '   KotOR I:
        '       HKLM\software\Bioware\SW\KOTOR
        '       value: path
        '
        '   KotOR II:
        '       HKLM\software\LucasArts\KotOR2
        '       value: path
        '
        ' The original logic only checked the old retail registry keys.
        ' That is too narrow for modern systems because Steam may be installed
        ' on any drive, Steam libraries may be moved anywhere, and GOG/manual
        ' installs may not have the old registry keys.
        '
        ' New behaviour:
        '
        '   1. Check original retail registry keys.
        '   2. Check WOW6432Node registry keys.
        '   3. Detect Steam install path from registry.
        '   4. Read Steam libraryfolders.vdf from every discovered Steam path.
        '   5. Check Steam app manifests:
        '          KotOR I  = appmanifest_32370.acf
        '          KotOR II = appmanifest_208580.acf
        '   6. Check common install paths on every fixed drive.
        '   7. Perform a limited safe folder scan in likely game folders.
        '
        ' A path is accepted only if chitin.key exists inside it.
        ' ---------------------------------------------------------------------

        Private Shared Function NormaliseGamePath(ByVal gamePath As String) As String
            If gamePath Is Nothing Then
                Return ""
            End If

            gamePath = gamePath.Trim().Replace("/", "\")

            While gamePath.EndsWith("\")
                gamePath = gamePath.Substring(0, gamePath.Length - 1)
            End While

            Return gamePath
        End Function

        Private Shared Function SafeDirectoryExists(ByVal path As String) As Boolean
            Try
                If path Is Nothing Then
                    Return False
                End If

                Return Directory.Exists(path)
            Catch ex As System.Exception
                Return False
            End Try
        End Function

        Private Shared Function SafeFileExists(ByVal path As String) As Boolean
            Try
                If path Is Nothing Then
                    Return False
                End If

                Return File.Exists(path)
            Catch ex As System.Exception
                Return False
            End Try
        End Function

        Private Shared Function HasChitinKey(ByVal gamePath As String) As Boolean
            gamePath = NormaliseGamePath(gamePath)

            If gamePath.Length = 0 Then
                Return False
            End If

            Return SafeFileExists(Path.Combine(gamePath, "chitin.key"))
        End Function

        Private Shared Sub AddUniquePath(ByVal list As ArrayList, ByVal path As String)
            path = NormaliseGamePath(path)

            If path.Length = 0 Then
                Return
            End If

            If Not SafeDirectoryExists(path) Then
                Return
            End If

            For Each existingPathObj As Object In list
                Dim existingPath As String = NormaliseGamePath(StringType.FromObject(existingPathObj))

                If StringType.StrCmp(existingPath, path, False) = 0 Then
                    Return
                End If
            Next

            list.Add(path)
        End Sub

        Private Shared Function TryRegistryPath(ByVal hive As RegistryKey, ByVal registryPath As String, ByVal valueName As String, Optional ByVal valueIsFile As Boolean = False) As String
            Dim registryKey As RegistryKey = Nothing

            Try
                registryKey = hive.OpenSubKey(registryPath)

                If registryKey IsNot Nothing Then
                    Dim value As Object = registryKey.GetValue(valueName)

                    If value IsNot Nothing Then
                        Dim detectedPath As String = NormaliseGamePath(StringType.FromObject(value))

                        If valueIsFile Then
                            detectedPath = NormaliseGamePath(Path.GetDirectoryName(detectedPath))
                        End If

                        If detectedPath.Length > 0 AndAlso SafeDirectoryExists(detectedPath) Then
                            Return detectedPath
                        End If
                    End If
                End If
            Catch ex As System.Exception
            Finally
                If registryKey IsNot Nothing Then
                    registryKey.Close()
                End If
            End Try

            Return ""
        End Function

        Private Shared Function TryGameRegistryPath(ByVal hive As RegistryKey, ByVal registryPath As String, ByVal valueName As String) As String
            Dim detectedPath As String = TryRegistryPath(hive, registryPath, valueName, False)

            If HasChitinKey(detectedPath) Then
                Return detectedPath
            End If

            Return ""
        End Function

        Private Shared Function ExtractVdfValue(ByVal line As String, ByVal keyName As String) As String
            If line Is Nothing Then
                Return ""
            End If

            Dim pattern As String = """" & Regex.Escape(keyName) & """" & "\s+""(?<value>[^""]+)"""
            Dim match As Match = Regex.Match(line, pattern, RegexOptions.IgnoreCase)

            If match.Success Then
                Return match.Groups("value").Value.Replace("\\", "\")
            End If

            Return ""
        End Function

        Private Shared Function GetFixedDriveRoots() As ArrayList
            Dim driveRoots As ArrayList = New ArrayList()

            Try
                For Each drive As DriveInfo In DriveInfo.GetDrives()
                    If drive IsNot Nothing Then
                        If drive.IsReady AndAlso drive.DriveType = DriveType.Fixed Then
                            AddUniquePath(driveRoots, drive.RootDirectory.FullName)
                        End If
                    End If
                Next
            Catch ex As System.Exception
            End Try

            Return driveRoots
        End Function

        Private Shared Function GetSteamInstallCandidates() As ArrayList
            Dim steamPaths As ArrayList = New ArrayList()

            ' Steam registry locations.
            AddUniquePath(steamPaths, TryRegistryPath(Registry.CurrentUser, "Software\Valve\Steam", "SteamPath", False))
            AddUniquePath(steamPaths, TryRegistryPath(Registry.CurrentUser, "Software\Valve\Steam", "SteamExe", True))
            AddUniquePath(steamPaths, TryRegistryPath(Registry.LocalMachine, "Software\Valve\Steam", "InstallPath", False))
            AddUniquePath(steamPaths, TryRegistryPath(Registry.LocalMachine, "Software\WOW6432Node\Valve\Steam", "InstallPath", False))

            ' Common Steam locations on every fixed drive.
            Dim driveRoots As ArrayList = GetFixedDriveRoots()

            For Each driveRootObj As Object In driveRoots
                Dim driveRoot As String = StringType.FromObject(driveRootObj)

                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Steam"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "SteamLibrary"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Games\Steam"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Games\SteamLibrary"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Program Files\Steam"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Program Files (x86)\Steam"))
                AddUniquePath(steamPaths, Path.Combine(driveRoot, "Valve\Steam"))
            Next

            Return steamPaths
        End Function

        Private Shared Function GetSteamLibraryFoldersFromSteamPath(ByVal steamPath As String) As ArrayList
            Dim libraries As ArrayList = New ArrayList()

            steamPath = NormaliseGamePath(steamPath)

            If steamPath.Length = 0 Then
                Return libraries
            End If

            ' The Steam install folder itself is also a library folder.
            AddUniquePath(libraries, steamPath)

            Dim steamAppsPath As String = Path.Combine(steamPath, "steamapps")
            Dim libraryFoldersFile As String = Path.Combine(steamAppsPath, "libraryfolders.vdf")

            If Not SafeFileExists(libraryFoldersFile) Then
                Return libraries
            End If

            Try
                Dim lines As String() = File.ReadAllLines(libraryFoldersFile)

                For Each line As String In lines
                    Dim detectedPath As String = ExtractVdfValue(line, "path")

                    If detectedPath.Length > 0 Then
                        AddUniquePath(libraries, detectedPath)
                    End If
                Next
            Catch ex As System.Exception
            End Try

            Return libraries
        End Function

        Private Shared Function GetAllSteamLibraries() As ArrayList
            Dim allLibraries As ArrayList = New ArrayList()
            Dim steamInstallCandidates As ArrayList = GetSteamInstallCandidates()

            For Each steamPathObj As Object In steamInstallCandidates
                Dim steamPath As String = StringType.FromObject(steamPathObj)
                Dim libraries As ArrayList = GetSteamLibraryFoldersFromSteamPath(steamPath)

                For Each libraryPathObj As Object In libraries
                    AddUniquePath(allLibraries, StringType.FromObject(libraryPathObj))
                Next
            Next

            Return allLibraries
        End Function

        Private Shared Function TrySteamGamePath(ByVal appId As String, ByVal defaultFolderNames As String()) As String
            Dim libraries As ArrayList = GetAllSteamLibraries()

            For Each libraryPathObj As Object In libraries
                Dim libraryPath As String = NormaliseGamePath(StringType.FromObject(libraryPathObj))
                Dim steamAppsPath As String = Path.Combine(libraryPath, "steamapps")

                If SafeDirectoryExists(steamAppsPath) Then
                    Dim manifestPath As String = Path.Combine(steamAppsPath, "appmanifest_" & appId & ".acf")

                    ' Preferred detection: Steam manifest tells us the real folder name.
                    If SafeFileExists(manifestPath) Then
                        Try
                            Dim lines As String() = File.ReadAllLines(manifestPath)

                            For Each line As String In lines
                                Dim installDir As String = ExtractVdfValue(line, "installdir")

                                If installDir.Length > 0 Then
                                    Dim detectedPath As String = Path.Combine(Path.Combine(steamAppsPath, "common"), installDir)
                                    detectedPath = NormaliseGamePath(detectedPath)

                                    If HasChitinKey(detectedPath) Then
                                        Return detectedPath
                                    End If
                                End If
                            Next
                        Catch ex As System.Exception
                        End Try
                    End If

                    ' Fallback: known Steam common folder names.
                    For Each folderName As String In defaultFolderNames
                        Dim commonPath As String = Path.Combine(Path.Combine(steamAppsPath, "common"), folderName)

                        If HasChitinKey(commonPath) Then
                            Return NormaliseGamePath(commonPath)
                        End If
                    Next
                End If
            Next

            Return ""
        End Function

        Private Shared Function TryCommonGamePathEveryDrive(ByVal relativeCandidates As String()) As String
            Dim driveRoots As ArrayList = GetFixedDriveRoots()

            For Each driveRootObj As Object In driveRoots
                Dim driveRoot As String = StringType.FromObject(driveRootObj)

                For Each relativeCandidate As String In relativeCandidates
                    Dim candidate As String = Path.Combine(driveRoot, relativeCandidate)

                    If HasChitinKey(candidate) Then
                        Return NormaliseGamePath(candidate)
                    End If
                Next
            Next

            Return ""
        End Function

        Private Shared Function TryLimitedFolderScan(ByVal folderNameHints As String()) As String
            Dim driveRoots As ArrayList = GetFixedDriveRoots()

            For Each driveRootObj As Object In driveRoots
                Dim driveRoot As String = StringType.FromObject(driveRootObj)

                Dim scanRoots As String() = New String() { _
                    Path.Combine(driveRoot, "Games"), _
                    Path.Combine(driveRoot, "Steam"), _
                    Path.Combine(driveRoot, "SteamLibrary"), _
                    Path.Combine(driveRoot, "GOG Games"), _
                    Path.Combine(driveRoot, "Program Files"), _
                    Path.Combine(driveRoot, "Program Files (x86)") _
                }

                For Each scanRoot As String In scanRoots
                    Dim foundPath As String = TryLimitedFolderScanRecursive(scanRoot, folderNameHints, 0, 3)

                    If foundPath.Length > 0 Then
                        Return foundPath
                    End If
                Next
            Next

            Return ""
        End Function

        Private Shared Function TryLimitedFolderScanRecursive(ByVal currentPath As String, ByVal folderNameHints As String(), ByVal depth As Integer, ByVal maxDepth As Integer) As String
            If depth > maxDepth Then
                Return ""
            End If

            If Not SafeDirectoryExists(currentPath) Then
                Return ""
            End If

            If HasChitinKey(currentPath) Then
                Dim currentFolderName As String = Path.GetFileName(currentPath).ToLower()

                For Each hint As String In folderNameHints
                    If currentFolderName.IndexOf(hint.ToLower()) >= 0 Then
                        Return NormaliseGamePath(currentPath)
                    End If
                Next
            End If

            Try
                Dim directories As String() = Directory.GetDirectories(currentPath)

                For Each directoryPath As String In directories
                    Dim folderName As String = Path.GetFileName(directoryPath).ToLower()
                    Dim worthScanning As Boolean = False

                    For Each hint As String In folderNameHints
                        If folderName.IndexOf(hint.ToLower()) >= 0 Then
                            worthScanning = True
                            Exit For
                        End If
                    Next

                    ' Scan broad at the top two levels only, then narrow by folder name.
                    If worthScanning OrElse depth < 2 Then
                        Dim foundPath As String = TryLimitedFolderScanRecursive(directoryPath, folderNameHints, depth + 1, maxDepth)

                        If foundPath.Length > 0 Then
                            Return foundPath
                        End If
                    End If
                Next
            Catch ex As System.Exception
            End Try

            Return ""
        End Function

        Public Shared Function DetectKotor1Path() As String
            Dim detectedPath As String = ""

            ' Original old retail registry detection preserved and used first.
            detectedPath = TryGameRegistryPath(Registry.LocalMachine, "software\Bioware\SW\KOTOR", "path")
            If detectedPath.Length > 0 Then Return detectedPath

            ' 32-bit registry redirector location on 64-bit Windows.
            detectedPath = TryGameRegistryPath(Registry.LocalMachine, "software\WOW6432Node\Bioware\SW\KOTOR", "path")
            If detectedPath.Length > 0 Then Return detectedPath

            ' Steam AppID: Star Wars: Knights of the Old Republic.
            detectedPath = TrySteamGamePath("32370", New String() { _
                "swkotor", _
                "Star Wars Knights of the Old Republic", _
                "Knights of the Old Republic" _
            })
            If detectedPath.Length > 0 Then Return detectedPath

            ' Common retail, Steam, GOG, and manual install locations on every fixed drive.
            detectedPath = TryCommonGamePathEveryDrive(New String() { _
                "LucasArts\SWKotOR", _
                "Program Files\LucasArts\SWKotOR", _
                "Program Files (x86)\LucasArts\SWKotOR", _
                "Steam\steamapps\common\swkotor", _
                "SteamLibrary\steamapps\common\swkotor", _
                "GOG Games\Star Wars - KotOR", _
                "GOG Games\Star Wars Knights of the Old Republic", _
                "Games\Star Wars - KotOR", _
                "Games\Star Wars Knights of the Old Republic" _
            })
            If detectedPath.Length > 0 Then Return detectedPath

            ' Last safe fallback. Limited depth only.
            detectedPath = TryLimitedFolderScan(New String() { _
                "kotor", _
                "swkotor", _
                "knights of the old republic" _
            })

            Return detectedPath
        End Function

        Public Shared Function DetectKotor2Path() As String
            Dim detectedPath As String = ""

            ' Original old retail registry detection preserved and used first.
            detectedPath = TryGameRegistryPath(Registry.LocalMachine, "software\LucasArts\KotOR2", "path")
            If detectedPath.Length > 0 Then Return detectedPath

            ' 32-bit registry redirector location on 64-bit Windows.
            detectedPath = TryGameRegistryPath(Registry.LocalMachine, "software\WOW6432Node\LucasArts\KotOR2", "path")
            If detectedPath.Length > 0 Then Return detectedPath

            ' Steam AppID: Star Wars: Knights of the Old Republic II.
            detectedPath = TrySteamGamePath("208580", New String() { _
                "Knights of the Old Republic II", _
                "Star Wars Knights of the Old Republic II", _
                "swkotor2" _
            })
            If detectedPath.Length > 0 Then Return detectedPath

            ' Common retail, Steam, GOG, and manual install locations on every fixed drive.
            detectedPath = TryCommonGamePathEveryDrive(New String() { _
                "LucasArts\SWKotOR2", _
                "Program Files\LucasArts\SWKotOR2", _
                "Program Files (x86)\LucasArts\SWKotOR2", _
                "Steam\steamapps\common\Knights of the Old Republic II", _
                "SteamLibrary\steamapps\common\Knights of the Old Republic II", _
                "Steam\steamapps\common\swkotor2", _
                "SteamLibrary\steamapps\common\swkotor2", _
                "GOG Games\Star Wars - KotOR2", _
                "GOG Games\Star Wars Knights of the Old Republic II", _
                "Games\Star Wars - KotOR2", _
                "Games\Star Wars Knights of the Old Republic II" _
            })
            If detectedPath.Length > 0 Then Return detectedPath

            ' Last safe fallback. Limited depth only.
            detectedPath = TryLimitedFolderScan(New String() { _
                "kotor2", _
                "swkotor2", _
                "knights of the old republic ii", _
                "old republic ii" _
            })

            Return detectedPath
        End Function

        ' Token: 0x06000D16 RID: 3350 RVA: 0x002857E4 File Offset: 0x002847E4
        Public Sub btnAutoDetectKotor1_Click(ByVal sender As Object, ByVal e As EventArgs)

            ' -----------------------------------------------------------------
            ' Original preserved code:
            '
            ' Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\Bioware\SW\KOTOR")
            ' If registryKey Is Nothing Then
            '     Interaction.MsgBox("KotOR I not detected in registry. You mau still enter paths manually", MsgBoxStyle.Critical, "Registry value not found")
            ' Else
            '     Me.tbKotorPath.Text = StringType.FromObject(registryKey.GetValue("path"))
            ' End If
            ' -----------------------------------------------------------------

            Dim detectedPath As String = DetectKotor1Path()

            If detectedPath.Length > 0 Then
                Me.tbKotorPath.Text = detectedPath
            Else
                Interaction.MsgBox( _
                    "KotOR I was not detected in the registry, Steam libraries, common folders, or limited drive scan." & vbCrLf & vbCrLf & _
                    "You may still enter the path manually.", _
                    MsgBoxStyle.Exclamation, _
                    "KotOR I not detected" _
                )
            End If
        End Sub

        ' Token: 0x06000D17 RID: 3351 RVA: 0x00285834 File Offset: 0x00284834
        Public Sub btnAutoDetectKotor2_Click(ByVal sender As Object, ByVal e As EventArgs)

            ' -----------------------------------------------------------------
            ' Original preserved code:
            '
            ' Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("software\LucasArts\KotOR2")
            ' If registryKey Is Nothing Then
            '     Interaction.MsgBox("KotOR II not detected in registry. You mau still enter paths manually", MsgBoxStyle.Critical, "Registry value not found")
            ' Else
            '     Me.tbKotorPath2.Text = StringType.FromObject(registryKey.GetValue("path"))
            ' End If
            ' -----------------------------------------------------------------

            Dim detectedPath As String = DetectKotor2Path()

            If detectedPath.Length > 0 Then
                Me.tbKotorPath2.Text = detectedPath
            Else
                Interaction.MsgBox( _
                    "KotOR II was not detected in the registry, Steam libraries, common folders, or limited drive scan." & vbCrLf & vbCrLf & _
                    "You may still enter the path manually.", _
                    MsgBoxStyle.Exclamation, _
                    "KotOR II not detected" _
                )
            End If
        End Sub

        ' Token: 0x06000D18 RID: 3352 RVA: 0x00285884 File Offset: 0x00284884
        Private Sub btnModuleExportPath_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbModuleExportPath As TextBox = Me.tbModuleExportPath
            Me.BrowseForFolder(tbModuleExportPath)
            Me.tbModuleExportPath = tbModuleExportPath
        End Sub

        ' Token: 0x0400067D RID: 1661
        Private options As Options
    End Class
End Namespace
