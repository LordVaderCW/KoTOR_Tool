Imports System
Imports System.Collections
Imports System.Xml.Serialization

Namespace kotor_tool
	' Token: 0x02000090 RID: 144
    <Serializable()> _
 Public Class RowFilter
        ' Token: 0x0600180A RID: 6154 RVA: 0x002CD1C8 File Offset: 0x002CC1C8
        Public Sub New()
            Me.active = False
            Me.m_FilterParts = New ArrayList()
        End Sub

        ' Token: 0x1700092E RID: 2350
        ' (get) Token: 0x0600180B RID: 6155 RVA: 0x002CD1E4 File Offset: 0x002CC1E4
        ' (set) Token: 0x0600180C RID: 6156 RVA: 0x002CD1F8 File Offset: 0x002CC1F8
        <XmlArray()> _
        <XmlArrayItem(GetType(RowFilterPart))> _
        Public Property FilterParts() As ArrayList
            Get
                Return Me.m_FilterParts
            End Get
            Set(ByVal value As ArrayList)
                Me.m_FilterParts = value
            End Set
        End Property

        ' Token: 0x0600180D RID: 6157 RVA: 0x002CD204 File Offset: 0x002CC204
        Public Function FilterString() As Object
            Dim text As String
            Try
                For Each obj As Object In Me.m_FilterParts
                    Dim rowFilterPart As RowFilterPart = CType(obj, RowFilterPart)
                    text = text + rowFilterPart.filterString + " "
                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return text
        End Function

        ' Token: 0x04000BC2 RID: 3010
        Public GD_type As String

        ' Token: 0x04000BC3 RID: 3011
        Public active As Boolean

        ' Token: 0x04000BC4 RID: 3012
        Private m_FilterParts As ArrayList
    End Class
End Namespace
