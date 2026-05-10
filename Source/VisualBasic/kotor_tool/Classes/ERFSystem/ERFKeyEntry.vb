Imports System

Namespace kotor_tool
    ' Token: 0x02000016 RID: 22
    <CLSCompliant(False)> _
    Public Class ERFKeyEntry
        ' Token: 0x06000069 RID: 105 RVA: 0x0021CA7C File Offset: 0x0021BA7C
        Public Sub New()
        End Sub

        ' Token: 0x0600006A RID: 106 RVA: 0x0021CA84 File Offset: 0x0021BA84
        Public Sub New(ByVal ResourceName As String, ByVal ResType As Short, ByVal ResourceID As Integer, ByVal Offset As Integer, ByVal Length As Integer, ByVal index As Integer)
            Me._ResourceName = ResourceName
            Me._ResType = ResType
            Me._ResTypeStr = frmMain.GetRsrcTypeForID(CInt(ResType))
            Me._ResourceID = ResourceID
            Me._Offset = Offset
            Me._Length = Length
            Me._Index = index
        End Sub

        ' Token: 0x0400009E RID: 158
        Public _ResourceName As String

        ' Token: 0x0400009F RID: 159
        Public _ResType As Short

        ' Token: 0x040000A0 RID: 160
        Public _ResTypeStr As String

        ' Token: 0x040000A1 RID: 161
        Public _ResourceID As Integer

        ' Token: 0x040000A2 RID: 162
        Public _Offset As Integer

        ' Token: 0x040000A3 RID: 163
        Public _Length As Integer

        ' Token: 0x040000A4 RID: 164
        Public _Index As Integer
    End Class
End Namespace