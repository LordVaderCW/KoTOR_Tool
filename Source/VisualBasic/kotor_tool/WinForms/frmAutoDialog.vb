Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Namespace kotor_tool
    ' Token: 0x02000040 RID: 64
    Partial Public Class frmAutoDialog
        Inherits Form

        ' Token: 0x06000268 RID: 616 RVA: 0x0022C9F8 File Offset: 0x0022B9F8
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmAutoDialog_Load
            AddHandler MyBase.Closing, AddressOf Me.frmAutoDialog_Closing
            Me.filepath = frmMain.CurrentSettings.defaultKotORLocation + "\override\ft_watch.dlg"
            Me.InitializeComponent()
        End Sub

        Private Sub ApplyKotorTheme()
            Dim theme As KotorTheme = KotorThemeManager.LoadTheme("DarkSaber")

            Me.BackColor = theme.WindowBack
            Me.ForeColor = theme.TextPrimary
            Me.Font = theme.CreateBodyFont()

            Me.Label1.BackColor = Color.Transparent
            Me.Label1.ForeColor = theme.TextSecondary
            Me.Label1.Font = theme.CreateBodyFont()
        End Sub

        ' Token: 0x17000092 RID: 146
        ' (get) Token: 0x0600026B RID: 619 RVA: 0x0022CAC8 File Offset: 0x0022BAC8
        ' (set) Token: 0x0600026A RID: 618 RVA: 0x0022CA74 File Offset: 0x0022BA74
        ' Token: 0x17000093 RID: 147
        ' (get) Token: 0x0600026C RID: 620 RVA: 0x0022CADC File Offset: 0x0022BADC
        ' (set) Token: 0x0600026D RID: 621 RVA: 0x0022CAF0 File Offset: 0x0022BAF0
        ' Token: 0x0600026F RID: 623 RVA: 0x0022CC30 File Offset: 0x0022BC30
        Private Sub SetDLGData()
            Dim fileStream As FileStream = New FileStream(Me.filepath, FileMode.Open)
            Dim clsGFF As clsGFF = New clsGFF(fileStream, 0, True)
            clsGFF.SetEnglishCExoLocSubStringEntry("EntryList(0).Text", "The time is " + DateAndTime.Now.ToLongTimeString())
            clsGFF.WriteFile(Me.filepath, "DLG")
        End Sub

        ' Token: 0x06000270 RID: 624 RVA: 0x0022CC88 File Offset: 0x0022BC88
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetDLGData()
        End Sub

        ' Token: 0x06000271 RID: 625 RVA: 0x0022CC90 File Offset: 0x0022BC90
        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetDLGData()
        End Sub

        ' Token: 0x06000272 RID: 626 RVA: 0x0022CC98 File Offset: 0x0022BC98
        Private Sub frmAutoDialog_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.ApplyKotorTheme()
            Me.Timer1.Enabled = True

        End Sub

        ' Token: 0x06000273 RID: 627 RVA: 0x0022CCA8 File Offset: 0x0022BCA8
        Private Sub frmAutoDialog_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.Timer1.Enabled = False
        End Sub

        ' Token: 0x04000198 RID: 408
        ' Token: 0x04000199 RID: 409
        ' Token: 0x0400019B RID: 411
        Private filepath As String
    End Class
End Namespace
