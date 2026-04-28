Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace kotor_tool
	' Token: 0x02000069 RID: 105
	Public Partial Class frmProgressMeter
		Inherits Form

		' Token: 0x06000D19 RID: 3353 RVA: 0x002858A8 File Offset: 0x002848A8
		Public Sub New()
			Me.InitializeComponent()
		End Sub

        ' Token: 0x1700048E RID: 1166
        ' (set) Token: 0x06000D22 RID: 3362 RVA: 0x00285B20 File Offset: 0x00284B20
        Public WriteOnly Property progress() As Integer
            Set(ByVal value As Integer)
                Me.pbar.Value = value
            End Set
        End Property

        ' Token: 0x1700048F RID: 1167
        ' (set) Token: 0x06000D23 RID: 3363 RVA: 0x00285B30 File Offset: 0x00284B30
        Public WriteOnly Property stepAmount() As Integer
            Set(ByVal value As Integer)
                Me.pbar.[Step] = value
            End Set
        End Property

        ' Token: 0x17000490 RID: 1168
        ' (set) Token: 0x06000D24 RID: 3364 RVA: 0x00285B40 File Offset: 0x00284B40
        Public WriteOnly Property message() As String
            Set(ByVal value As String)
                Me.lblMsg.Text = value
                Application.DoEvents()
            End Set
        End Property

        ' Token: 0x17000491 RID: 1169
        ' (set) Token: 0x06000D25 RID: 3365 RVA: 0x00285B54 File Offset: 0x00284B54
        Public WriteOnly Property status() As String
            Set(ByVal value As String)
                Me.lblStatus.Text = value
                Application.DoEvents()
            End Set
        End Property

        ' Token: 0x17000492 RID: 1170
        ' (set) Token: 0x06000D26 RID: 3366 RVA: 0x00285B68 File Offset: 0x00284B68
        Public WriteOnly Property maxvalue() As Integer
            Set(ByVal value As Integer)
                Me.pbar.Maximum = value
            End Set
        End Property

        ' Token: 0x06000D27 RID: 3367 RVA: 0x00285B78 File Offset: 0x00284B78
        Public Sub stepUp()
            Me.pbar.PerformStep()
            Application.DoEvents()
        End Sub
    End Class
End Namespace
