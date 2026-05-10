Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x0200004B RID: 75
	Public Partial Class frmErrorMessage
		Inherits Form

        Private _summaryBorderColor As Color = Color.FromArgb(62, 70, 82)

		' Token: 0x060004CE RID: 1230 RVA: 0x0023EBCC File Offset: 0x0023DBCC
		Public Sub New()
			Me.InitializeComponent()
            Me.ConfigureErrorButtons()
            AddHandler Me.pnlSummary.Paint, AddressOf pnlSummary_Paint
		End Sub

        Public Shared Function ShowException(ByVal owner As IWin32Window, ByVal ex As Global.System.Exception, ByVal isTerminating As Boolean) As DialogResult
            Using dialog As frmErrorMessage = New frmErrorMessage()
                dialog.SetException(ex, isTerminating)

                Try
                    KotorThemeApplier.ApplyToForm(dialog)
                Catch themeEx As Global.System.Exception
                End Try

                If owner IsNot Nothing Then
                    Return dialog.ShowDialog(owner)
                End If

                Return dialog.ShowDialog()
            End Using
        End Function

        Public Sub SetException(ByVal ex As Global.System.Exception, ByVal isTerminating As Boolean)
            Dim details As ErrorDetails = Me.ClassifyException(ex, isTerminating)

            Me.lblTitle.Text = details.Title
            Me.lblSubtitle.Text = details.Subtitle
            Me.lblMsg.Text = details.UserMessage
            Me.lblCategoryValue.Text = details.Category
            Me.lblImpactValue.Text = details.Impact
            Me.lblNextStepValue.Text = details.NextStep

            Me.tbMsg.Text = Me.BuildDiagnosticText(ex, isTerminating, details)
            Me.tbMsg.SelectionStart = 0
            Me.tbMsg.SelectionLength = 0
        End Sub

        Private Sub ConfigureErrorButtons()
            Me.Button1.Text = "OK"
            Me.Button1.DialogResult = DialogResult.OK
            Me.AcceptButton = Me.Button1

            Me.btnCancel.DialogResult = DialogResult.Cancel
            Me.CancelButton = Me.btnCancel

            Me.btnJitDebug.DialogResult = DialogResult.Retry
        End Sub

        Friend Sub SetSummaryBorderColor(ByVal value As Color)
            Me._summaryBorderColor = value
            Me.pnlSummary.Invalidate()
        End Sub

        Private Sub pnlSummary_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            Using pen As Pen = New Pen(Me._summaryBorderColor)
                Dim rect As Rectangle = Me.pnlSummary.ClientRectangle
                rect.Width -= 1
                rect.Height -= 1
                e.Graphics.DrawRectangle(pen, rect)
            End Using
        End Sub

        Private Function BuildDiagnosticText(ByVal ex As Global.System.Exception, ByVal isTerminating As Boolean, ByVal details As ErrorDetails) As String
            Dim builder As StringBuilder = New StringBuilder()

            Me.AppendSection(builder, "ERROR OVERVIEW")
            builder.AppendLine("Category: " & details.Category)
            builder.AppendLine("Summary: " & details.Summary)
            builder.AppendLine("Exception type: " & details.ExceptionType)
            builder.AppendLine("Message: " & details.ExceptionMessage)
            builder.AppendLine("Impact: " & details.Impact)
            builder.AppendLine("Recommended next step: " & details.NextStep)
            builder.AppendLine("Application will close: " & isTerminating.ToString())

            Me.AppendSection(builder, "LIKELY CAUSE")
            builder.AppendLine(details.LikelyCause)

            Me.AppendSection(builder, "RECOVERY GUIDANCE")
            builder.AppendLine(details.RecoveryGuidance)

            Me.AppendSection(builder, "ERROR CONTEXT")
            builder.AppendLine("Time: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            builder.AppendLine("Application: " & Application.ProductName & " " & Application.ProductVersion)
            builder.AppendLine("Machine: " & Environment.MachineName)
            builder.AppendLine("User: " & Environment.UserName)
            builder.AppendLine(".NET runtime: " & Environment.Version.ToString())
            builder.AppendLine("OS: " & Environment.OSVersion.ToString())
            builder.AppendLine("Working directory: " & Environment.CurrentDirectory)

            If ex Is Nothing Then
                Me.AppendSection(builder, "EXCEPTION DETAILS")
                builder.AppendLine("No exception details were provided.")
            Else
                Me.AppendExceptionDetails(builder, ex)

                Dim loaderException As ReflectionTypeLoadException = TryCast(ex, ReflectionTypeLoadException)
                If loaderException IsNot Nothing AndAlso loaderException.LoaderExceptions IsNot Nothing Then
                    Me.AppendSection(builder, "LOADER EXCEPTIONS")

                    For Each item As Global.System.Exception In loaderException.LoaderExceptions
                        If item IsNot Nothing Then
                            Me.AppendExceptionDetails(builder, item)
                        End If
                    Next
                End If
            End If

            Return builder.ToString()
        End Function

        Private Function ClassifyException(ByVal ex As Global.System.Exception, ByVal isTerminating As Boolean) As ErrorDetails
            Dim details As ErrorDetails = New ErrorDetails()
            details.Title = If(isTerminating, "Critical Error Detected", "Unhandled Error Detected")
            details.Subtitle = "The application captured the failure and prepared a structured report."
            details.Category = "General application exception"
            details.ExceptionType = If(ex Is Nothing, "Unknown", ex.GetType().FullName)
            details.ExceptionMessage = If(ex Is Nothing, "No exception message was provided.", ex.Message)
            details.Summary = Me.GetDiagnosticSummary(ex)
            details.Impact = If(isTerminating, "The current operation cannot continue and KoTOR Tool will close.", "The current operation failed; KoTOR Tool may be able to continue.")
            details.NextStep = If(isTerminating, "Copy the report, then restart KoTOR Tool.", "Click OK to continue, Cancel to close, or JIT Debug to inspect live state.")
            details.LikelyCause = "The application reached a code path that did not handle this exception type before it reached the global error handler."
            details.RecoveryGuidance = "Save any work that is still available. Include the full technical report when filing an issue."
            details.UserMessage = "KoTOR Tool caught an unhandled exception and prepared the details below. Review the category and impact, then choose whether to continue, close, or attach a debugger."

            If TypeOf ex Is FileNotFoundException Then
                details.Title = "Required File Missing"
                details.Category = "File system / missing file"
                details.Impact = "A file needed by the current operation was not found."
                details.NextStep = "Check that the file exists at the expected path, then retry the operation."
                details.LikelyCause = "A required game resource, configuration file, plugin file, or managed assembly is missing or was moved."
                details.RecoveryGuidance = "Verify the file path shown in the report. If this is an application file, reinstall or restore the missing file."
                details.UserMessage = "KoTOR Tool could not find a required file. The report separates the missing-file summary from the full exception details."
            ElseIf TypeOf ex Is DirectoryNotFoundException Then
                details.Title = "Required Folder Missing"
                details.Category = "File system / missing directory"
                details.Impact = "A folder needed by the current operation was not found."
                details.NextStep = "Check the configured path and confirm the folder still exists."
                details.LikelyCause = "A game, override, module, plugin, or export directory path points to a folder that is no longer available."
                details.RecoveryGuidance = "Update the path in options or recreate the missing folder before retrying."
                details.UserMessage = "KoTOR Tool could not find a required folder. The report highlights the missing path and the full exception chain."
            ElseIf TypeOf ex Is DllNotFoundException Then
                details.Title = "Required DLL Missing"
                details.Category = "Native dependency / missing DLL"
                details.Impact = "A native library required by this feature could not be loaded."
                details.NextStep = "Confirm the DLL exists beside the executable or in the expected dependency folder."
                details.LikelyCause = "A native dependency is missing, blocked, or not discoverable through the process DLL search path."
                details.RecoveryGuidance = "Restore the missing DLL and check that the application is using the correct x86 dependency set."
                details.UserMessage = "KoTOR Tool could not load a native DLL. The report separates dependency details from the full stack trace."
            ElseIf TypeOf ex Is FileLoadException Then
                details.Title = "File Or Assembly Load Failed"
                details.Category = "Assembly loading / blocked or incompatible file"
                details.Impact = "A required file was found but could not be loaded."
                details.NextStep = "Check whether the file is blocked, incompatible, already locked, or the wrong version."
                details.LikelyCause = "The runtime located the file, but rejected it because of version, policy, lock, trust, or dependency problems."
                details.RecoveryGuidance = "Review the file name and Fusion/log details if available, then restore the expected version."
                details.UserMessage = "KoTOR Tool found a required file but the runtime could not load it. The report includes file and loader details."
            ElseIf TypeOf ex Is BadImageFormatException Then
                details.Title = "Incompatible File Or DLL"
                details.Category = "Binary format / architecture mismatch"
                details.Impact = "A file or DLL was not compatible with this x86 application."
                details.NextStep = "Confirm the dependency is the correct 32-bit version and is not corrupted."
                details.LikelyCause = "The application tried to load a binary built for the wrong CPU architecture or a non-.NET file as an assembly."
                details.RecoveryGuidance = "Replace the dependency with the x86 build expected by KoTOR Tool."
                details.UserMessage = "KoTOR Tool hit a binary compatibility problem. The report calls out the likely architecture or format issue."
            ElseIf TypeOf ex Is ReflectionTypeLoadException Then
                details.Title = "Type Loading Failed"
                details.Category = "Reflection / plugin or assembly type load"
                details.Impact = "One or more types could not be loaded from an assembly."
                details.NextStep = "Review the Loader Exceptions section for the exact missing dependency or type."
                details.LikelyCause = "A plugin or assembly references a missing dependency, incompatible version, or type that cannot be resolved."
                details.RecoveryGuidance = "Restore the missing dependency or update the plugin/assembly so all referenced types can load."
                details.UserMessage = "KoTOR Tool could not load one or more reflected types. The report includes a dedicated Loader Exceptions section."
            End If

            Return details
        End Function

        Private Function GetDiagnosticSummary(ByVal ex As Global.System.Exception) As String
            If ex Is Nothing Then
                Return "No exception details were provided."
            End If

            Dim fileMissing As FileNotFoundException = TryCast(ex, FileNotFoundException)
            If fileMissing IsNot Nothing Then
                Return "File not found" & Me.FormatFileName(fileMissing.FileName)
            End If

            Dim fileLoad As FileLoadException = TryCast(ex, FileLoadException)
            If fileLoad IsNot Nothing Then
                Return "File or assembly could not be loaded" & Me.FormatFileName(fileLoad.FileName)
            End If

            If TypeOf ex Is DirectoryNotFoundException Then
                Return "Directory not found: " & ex.Message
            End If

            If TypeOf ex Is DllNotFoundException Then
                Return "DLL not found: " & ex.Message
            End If

            If TypeOf ex Is BadImageFormatException Then
                Return "Invalid file or DLL format: " & ex.Message
            End If

            If TypeOf ex Is ReflectionTypeLoadException Then
                Return "One or more types could not be loaded: " & ex.Message
            End If

            Return ex.GetType().FullName & ": " & ex.Message
        End Function

        Private Sub AppendSection(ByVal builder As StringBuilder, ByVal title As String)
            If builder.Length > 0 Then
                builder.AppendLine()
            End If

            builder.AppendLine("============================================================")
            builder.AppendLine(title)
            builder.AppendLine("============================================================")
        End Sub

        Private Sub AppendExceptionDetails(ByVal builder As StringBuilder, ByVal ex As Global.System.Exception)
            Me.AppendSection(builder, "EXCEPTION DETAILS")
            builder.AppendLine("Type: " & ex.GetType().FullName)
            builder.AppendLine("Message: " & ex.Message)
            builder.AppendLine("Source: " & If(ex.Source, ""))
            builder.AppendLine("Target site: " & If(ex.TargetSite Is Nothing, "", ex.TargetSite.ToString()))
            builder.AppendLine("HResult: 0x" & ex.HResult.ToString("X8"))

            Dim fileMissing As FileNotFoundException = TryCast(ex, FileNotFoundException)
            If fileMissing IsNot Nothing Then
                builder.AppendLine("File name: " & If(fileMissing.FileName, ""))
                builder.AppendLine("Fusion log: " & If(fileMissing.FusionLog, ""))
            End If

            Dim fileLoad As FileLoadException = TryCast(ex, FileLoadException)
            If fileLoad IsNot Nothing Then
                builder.AppendLine("File name: " & If(fileLoad.FileName, ""))
                builder.AppendLine("Fusion log: " & If(fileLoad.FusionLog, ""))
            End If

            builder.AppendLine()
            builder.AppendLine("Stack trace:")
            builder.AppendLine(If(ex.StackTrace, "(no stack trace provided)"))

            If ex.InnerException IsNot Nothing Then
                Me.AppendInnerExceptions(builder, ex.InnerException)
            End If
        End Sub

        Private Sub AppendInnerExceptions(ByVal builder As StringBuilder, ByVal ex As Global.System.Exception)
            Dim index As Integer = 1
            Dim current As Global.System.Exception = ex

            Me.AppendSection(builder, "INNER EXCEPTIONS")

            While current IsNot Nothing
                builder.AppendLine("Inner exception " & index.ToString())
                builder.AppendLine("Type: " & current.GetType().FullName)
                builder.AppendLine("Message: " & current.Message)
                builder.AppendLine("Stack trace:")
                builder.AppendLine(If(current.StackTrace, "(no stack trace provided)"))
                builder.AppendLine()
                current = current.InnerException
                index += 1
            End While
        End Sub

        Private Function FormatFileName(ByVal fileName As String) As String
            If String.IsNullOrEmpty(fileName) Then
                Return ": file name was not provided by the runtime."
            End If

            Return ": " & fileName
        End Function

        Private Class ErrorDetails
            Public Title As String
            Public Subtitle As String
            Public Category As String
            Public Summary As String
            Public Impact As String
            Public NextStep As String
            Public LikelyCause As String
            Public RecoveryGuidance As String
            Public ExceptionType As String
            Public ExceptionMessage As String
            Public UserMessage As String
        End Class
    End Class
End Namespace
