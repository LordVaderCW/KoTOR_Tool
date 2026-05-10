Imports System
Imports System.Diagnostics
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
    ' Token: 0x02000087 RID: 135
    Friend Module KT_Launch

        Private _showingExceptionDialog As Integer

        ' Token: 0x06001722 RID: 5922 RVA: 0x002CB4A0 File Offset: 0x002CA4A0
        <STAThread()> _
        Public Sub Main(ByVal CmdArgs As String())
            Try
                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
                AddHandler Application.ThreadException, AddressOf Application_ThreadException
                AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

                KotorThemeApplier.InstallGlobalThemeHooks()

                If CmdArgs IsNot Nothing AndAlso CmdArgs.Length > 0 Then
                    Application.Run(New frmMain(CmdArgs))
                Else
                    Application.Run(New frmMain())
                End If
            Catch ex As Global.System.Exception
                Dim result As DialogResult = ShowUnhandledExceptionDialog(ex, True)

                If result = DialogResult.Retry Then
                    LaunchJitDebugger()
                End If

                Environment.Exit(1)
            End Try
        End Sub

        Private Sub Application_ThreadException(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs)
            Dim result As DialogResult = ShowUnhandledExceptionDialog(e.Exception, False)

            If result = DialogResult.Retry Then
                LaunchJitDebugger()
            ElseIf result = DialogResult.Cancel Then
                Application.Exit()
            End If
        End Sub

        Private Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
            Dim ex As Global.System.Exception = TryCast(e.ExceptionObject, Global.System.Exception)

            If ex Is Nothing Then
                ex = New Global.System.Exception(Convert.ToString(e.ExceptionObject))
            End If

            Dim result As DialogResult = ShowUnhandledExceptionDialog(ex, True)

            If result = DialogResult.Retry Then
                LaunchJitDebugger()
            End If

            Environment.Exit(1)
        End Sub

        Private Function ShowUnhandledExceptionDialog(ByVal ex As Global.System.Exception, ByVal isTerminating As Boolean) As DialogResult
            If Interlocked.Exchange(_showingExceptionDialog, 1) = 1 Then
                Return DialogResult.Cancel
            End If

            Try
                If Thread.CurrentThread.GetApartmentState() = ApartmentState.STA Then
                    Return ShowUnhandledExceptionDialogOnCurrentThread(ex, isTerminating)
                End If

                Dim result As DialogResult = DialogResult.Cancel
                Dim dialogThread As Thread = New Thread(Sub()
                                                            result = ShowUnhandledExceptionDialogOnCurrentThread(ex, isTerminating)
                                                        End Sub)
                dialogThread.SetApartmentState(ApartmentState.STA)
                dialogThread.Start()
                dialogThread.Join()
                Return result
            Finally
                Interlocked.Exchange(_showingExceptionDialog, 0)
            End Try
        End Function

        Private Function ShowUnhandledExceptionDialogOnCurrentThread(ByVal ex As Global.System.Exception, ByVal isTerminating As Boolean) As DialogResult
            Dim owner As IWin32Window = Nothing

            If Application.OpenForms IsNot Nothing AndAlso Application.OpenForms.Count > 0 Then
                owner = Application.OpenForms(Application.OpenForms.Count - 1)
            End If

            Return frmErrorMessage.ShowException(owner, ex, isTerminating)
        End Function

        Private Sub LaunchJitDebugger()
            Try
                If Debugger.IsAttached = False Then
                    Debugger.Launch()
                End If

                Debugger.Break()
            Catch ex As Global.System.Exception
                MessageBox.Show("Unable to launch the JIT debugger." & Environment.NewLine & ex.Message, "JIT Debug", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

    End Module
End Namespace
