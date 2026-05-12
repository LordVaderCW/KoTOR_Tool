Option Strict Off
Option Explicit On

Imports System
Imports System.Collections
Imports System.IO
Imports System.Windows.Forms
Imports FMOD
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool

    Public Class clsAnimationSoundPlayer
        Implements IDisposable

        Public Event StoppedPlaying()

        Private fmSystem As Global.FMOD.System
        Private sound As Sound
        Private channel As Channel
        Private result As RESULT
        Private timer As Timer
        Private soundBifFilesHash As Hashtable
        Private soundsBifPath As String
        Private soundsResInfo As BIFFVarRsrcEntryInfo()
        Private kotorVersionIndex As Integer = -1

        Public Sub New()
            Me.timer = New Timer()
            Me.timer.Interval = 100
            AddHandler Me.timer.Tick, AddressOf Me.Timer_Tick
        End Sub

        Public Function PlayResRef(ByVal resRef As String, ByVal gameIndex As Integer) As Boolean
            Dim fileName As String = Me.NormalizeSoundFileName(resRef)

            If fileName.Length = 0 Then
                Return False
            End If

            Me.EnsureInitialized(gameIndex)

            If Me.fmSystem Is Nothing Then
                Return False
            End If

            Dim biffvarRsrcEntryInfo As BIFFVarRsrcEntryInfo = Nothing
            Dim useBif As Boolean = False
            Dim sourcePath As String = Me.ResolveSoundPath(fileName, biffvarRsrcEntryInfo, useBif)

            If sourcePath.Length = 0 Then
                Return False
            End If

            Dim createSoundInfo As CREATESOUNDEXINFO = Nothing
            createSoundInfo.cbsize = 72

            If useBif Then
                createSoundInfo.length = Convert.ToUInt32(biffvarRsrcEntryInfo.FileSize)
                createSoundInfo.fileoffset = Convert.ToUInt32(biffvarRsrcEntryInfo.Offset)
            Else
                Dim kotorSoundInfo As KTSoundInfo = frmMain.GetKotorSoundInfo(sourcePath)
                createSoundInfo.length = Convert.ToUInt32(kotorSoundInfo.DataSize)
                createSoundInfo.fileoffset = Convert.ToUInt32(kotorSoundInfo.DataOffset)
            End If

            Me.StopCurrentChannel()
            Me.ReleaseCurrentSound()

            Me.result = Me.fmSystem.createSound(sourcePath, CType(32936, MODE), createSoundInfo, Me.sound)

            If Me.result <> RESULT.OK Then
                Me.sound = Nothing
                Return False
            End If

            Me.result = Me.fmSystem.playSound(CHANNELINDEX.FREE, Me.sound, False, Me.channel)

            If Me.result <> RESULT.OK Then
                Me.ReleaseCurrentSound()
                Return False
            End If

            Me.timer.Enabled = True
            Return True
        End Function

        Public Sub StopSound()
            Me.timer.Enabled = False
            Me.StopCurrentChannel()
            Me.ReleaseCurrentSound()
            RaiseEvent StoppedPlaying()
        End Sub

        Public Function IsSoundPlaying() As Boolean
            Dim isPlaying As Boolean = False

            If Me.channel IsNot Nothing Then
                Me.result = Me.channel.isPlaying(isPlaying)

                If Me.result = RESULT.ERR_INVALID_HANDLE OrElse Me.result = RESULT.ERR_CHANNEL_STOLEN Then
                    Me.channel = Nothing
                    isPlaying = False
                End If
            End If

            Return isPlaying
        End Function

        Private Sub EnsureInitialized(ByVal gameIndex As Integer)
            If Me.fmSystem Is Nothing Then
                Me.result = Factory.System_Create(Me.fmSystem)

                If Me.fmSystem IsNot Nothing Then
                    Me.result = Me.fmSystem.init(32, INITFLAG.NORMAL, CType((If(Nothing, Activator.CreateInstance(GetType(IntPtr)))), IntPtr))
                End If
            End If

            If Me.kotorVersionIndex <> gameIndex OrElse Me.soundBifFilesHash Is Nothing Then
                Me.kotorVersionIndex = gameIndex
                Me.soundBifFilesHash = frmMain.KxChitinKey(gameIndex).GetBIFFileHash("sounds")
                Me.soundsBifPath = Path.Combine(frmMain.CurrentSettings.KotorLocation(gameIndex), CType(frmMain.KxChitinKey(gameIndex).BiffListInfo("sounds"), BIFFEntry).filename)
                Me.soundsResInfo = BIFFArchive.GetBIFFResourceInfoList(Me.soundsBifPath)
            End If
        End Sub

        Private Function ResolveSoundPath(ByVal fileName As String,
                                          ByRef biffvarRsrcEntryInfo As BIFFVarRsrcEntryInfo,
                                          ByRef useBif As Boolean) As String
            If Me.soundBifFilesHash IsNot Nothing AndAlso Me.soundBifFilesHash.ContainsKey(fileName) Then
                biffvarRsrcEntryInfo = CType(Me.soundsResInfo(IntegerType.FromObject(Me.soundBifFilesHash(fileName))), BIFFVarRsrcEntryInfo)
                useBif = True
                Return Me.soundsBifPath
            End If

            Dim gameRoot As String = frmMain.CurrentSettings.KotorLocation(Me.kotorVersionIndex)
            Dim candidate As String = ""

            If frmMain.CurrentSettings.bUseOverrideFiles Then
                candidate = Path.Combine(gameRoot, "Override\" & fileName)

                If File.Exists(candidate) Then
                    Return candidate
                End If
            End If

            candidate = Path.Combine(gameRoot, "StreamSounds\" & fileName)

            If File.Exists(candidate) Then
                Return candidate
            End If

            If Me.kotorVersionIndex = 1 Then
                candidate = Path.Combine(gameRoot, "StreamVoice\" & fileName)

                If File.Exists(candidate) Then
                    Return candidate
                End If

                candidate = Path.Combine(gameRoot, "streamwaves\" & fileName)

                If File.Exists(candidate) Then
                    Return candidate
                End If
            Else
                candidate = Path.Combine(gameRoot, "streamwaves\" & fileName)

                If File.Exists(candidate) Then
                    Return candidate
                End If

                candidate = Path.Combine(gameRoot, "StreamVoice\" & fileName)

                If File.Exists(candidate) Then
                    Return candidate
                End If
            End If

            candidate = Path.Combine(gameRoot, "StreamMusic\" & fileName)

            If File.Exists(candidate) Then
                Return candidate
            End If

            If Me.kotorVersionIndex = 1 Then
                candidate = Me.FindStreamFile(gameRoot, "StreamVoice", fileName)

                If candidate.Length > 0 Then
                    Return candidate
                End If

                candidate = Me.FindStreamFile(gameRoot, "streamwaves", fileName)

                If candidate.Length > 0 Then
                    Return candidate
                End If
            Else
                candidate = Me.FindStreamFile(gameRoot, "streamwaves", fileName)

                If candidate.Length > 0 Then
                    Return candidate
                End If

                candidate = Me.FindStreamFile(gameRoot, "StreamVoice", fileName)

                If candidate.Length > 0 Then
                    Return candidate
                End If
            End If

            Return ""
        End Function

        Private Function FindStreamFile(ByVal gameRoot As String, ByVal streamFolderName As String, ByVal fileName As String) As String
            Dim streamRoot As String = Path.Combine(gameRoot, streamFolderName)

            If Not Directory.Exists(streamRoot) Then
                Return ""
            End If

            Try
                Dim files As String() = Directory.GetFiles(streamRoot, fileName, SearchOption.AllDirectories)

                If files IsNot Nothing AndAlso files.Length > 0 Then
                    Return files(0)
                End If
            Catch ex As System.Exception
            End Try

            Return ""
        End Function

        Private Function NormalizeSoundFileName(ByVal resRef As String) As String
            If resRef Is Nothing Then
                Return ""
            End If

            Dim fileName As String = resRef.Trim()

            If fileName.Length = 0 Then
                Return ""
            End If

            If Path.GetExtension(fileName).Length = 0 Then
                fileName &= ".wav"
            End If

            Return fileName
        End Function

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.IsSoundPlaying() Then
                Return
            End If

            Me.timer.Enabled = False
            Me.StopCurrentChannel()
            Me.ReleaseCurrentSound()
            RaiseEvent StoppedPlaying()
        End Sub

        Private Sub StopCurrentChannel()
            If Me.channel Is Nothing Then
                Return
            End If

            Me.result = Me.channel.[stop]()
            Me.channel = Nothing
        End Sub

        Private Sub ReleaseCurrentSound()
            If Me.sound Is Nothing Then
                Return
            End If

            Me.result = Me.sound.release()
            Me.sound = Nothing
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Me.timer.Enabled = False
            RemoveHandler Me.timer.Tick, AddressOf Me.Timer_Tick
            Me.timer.Dispose()
            Me.StopCurrentChannel()
            Me.ReleaseCurrentSound()

            If Me.fmSystem IsNot Nothing Then
                Me.result = Me.fmSystem.close()
                Me.result = Me.fmSystem.release()
                Me.fmSystem = Nothing
            End If
        End Sub

    End Class

End Namespace
