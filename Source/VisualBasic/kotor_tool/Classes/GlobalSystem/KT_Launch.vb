Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
    ' Token: 0x02000087 RID: 135
    Friend Module KT_Launch

        ' Token: 0x06001722 RID: 5922 RVA: 0x002CB4A0 File Offset: 0x002CA4A0
        <STAThread()> _
        Public Sub Main(ByVal CmdArgs As String())
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            KotorThemeApplier.InstallGlobalThemeHooks()

            If CmdArgs IsNot Nothing AndAlso CmdArgs.Length > 0 Then
                Application.Run(New frmMain(CmdArgs))
            Else
                Application.Run(New frmMain())
            End If
        End Sub

    End Module
End Namespace
