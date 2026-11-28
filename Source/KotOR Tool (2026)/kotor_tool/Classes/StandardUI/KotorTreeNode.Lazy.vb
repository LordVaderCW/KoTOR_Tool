Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic

Namespace kotor_tool
    Public Partial Class KotorTreeNode
        Private deferredChildren As KotorTreeNode()
        Private deferredParent As KotorTreeNode

        ' The resource hierarchy survives independently of native TreeView items.
        ' Call while building a detached archive, before it reaches the TreeView.
        Public Sub DeferDescendants(ByVal gameIndex As Integer)
            If TreeView IsNot Nothing Then Throw New InvalidOperationException("Defer nodes before attaching the archive to the tree.")
            KotorVerIndex = gameIndex
            If deferredChildren IsNot Nothing OrElse Nodes.Count = 0 Then Return
            Dim children As New List(Of KotorTreeNode)()
            For Each child As KotorTreeNode In Nodes
                child.DeferDescendants(gameIndex)
                child.deferredParent = Me
                children.Add(child)
            Next
            deferredChildren = children.ToArray()
            Nodes.Clear()
            Nodes.Add(New KotorTreeNode("") With {.Tag = "Deferred_Children", .KotorVerIndex = gameIndex})
        End Sub

        Public Sub MaterializeChildren()
            If deferredChildren Is Nothing Then Return
            Dim children As KotorTreeNode() = deferredChildren
            Nodes.Clear()
            Nodes.AddRange(children)
            For Each child As KotorTreeNode In children
                child.deferredParent = Nothing
            Next
            deferredChildren = Nothing
        End Sub

        ' Extraction must include resources in folders the user has never opened.
        Public Iterator Function ResourceChildren() As IEnumerable(Of KotorTreeNode)
            If deferredChildren IsNot Nothing Then
                For Each child As KotorTreeNode In deferredChildren
                    Yield child
                Next
            Else
                For Each child As KotorTreeNode In Nodes
                    Yield child
                Next
            End If
        End Function

        Public ReadOnly Property ResourceParent As KotorTreeNode
            Get
                Return If(TryCast(Parent, KotorTreeNode), deferredParent)
            End Get
        End Property
    End Class
End Namespace
