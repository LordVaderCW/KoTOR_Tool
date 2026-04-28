Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000066 RID: 102
	Public Partial Class frmPackageTypeSelector
		Inherits Form

		' Token: 0x06000CBE RID: 3262 RVA: 0x002834F4 File Offset: 0x002824F4
		Public Sub New()
			Me.InitializeComponent()
		End Sub

        ' Token: 0x06000CC9 RID: 3273 RVA: 0x002838BC File Offset: 0x002828BC
        Public Sub New(ByVal PackageType As String)
            Me.New()
            Me.cmbxErfType.SelectedIndex = Me.cmbxErfType.FindStringExact(PackageType)
        End Sub

        ' Token: 0x1700046E RID: 1134
        ' (get) Token: 0x06000CCA RID: 3274 RVA: 0x002838DC File Offset: 0x002828DC
        Public ReadOnly Property PackageType() As String
            Get
                Return StringType.FromObject(Me.cmbxErfType.SelectedItem)
            End Get
        End Property
    End Class
End Namespace
