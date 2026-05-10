Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
    ' Token: 0x02000051 RID: 81
    Public Class InventoryItem

        ' Token: 0x0600061C RID: 1564 RVA: 0x0024A058 File Offset: 0x00249058
        Public Sub New(ByVal Name As String, ByVal ResRef As String, Optional ByVal EquipableSlots As String = "", Optional ByVal Quantity As Integer = 1, Optional ByVal Dropable As Boolean = True)
            Me._Name = Name
            Me._ResRef = ResRef
            Me._EquipableSlots = EquipableSlots
            Me._Quantity = Quantity
            Me._Dropable = Dropable
        End Sub

        ' Token: 0x170001D3 RID: 467
        ' (get) Token: 0x0600061D RID: 1565 RVA: 0x0024A088 File Offset: 0x00249088
        Public ReadOnly Property Text() As String
            Get
                Dim displayText As String = Me._Name & " (" & Me._ResRef & ")"

                If Me._Quantity > 1 Then
                    displayText &= ControlChars.Tab & "Qty: " & StringType.FromInteger(Me._Quantity)
                End If

                Return displayText
            End Get
        End Property

        ' Token: 0x04000330 RID: 816
        Public _Name As String

        ' Token: 0x04000331 RID: 817
        Public _ResRef As String

        ' Token: 0x04000332 RID: 818
        Public _EquipableSlots As String

        ' Token: 0x04000333 RID: 819
        Public _Quantity As Integer

        ' Token: 0x04000334 RID: 820
        Public _Dropable As Boolean

    End Class
End Namespace