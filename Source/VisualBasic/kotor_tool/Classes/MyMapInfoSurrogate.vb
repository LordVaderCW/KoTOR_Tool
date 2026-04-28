Imports System
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200005A RID: 90
	Public Class MyMapInfoSurrogate
		Implements ISerializationSurrogate, ISurrogateSelector

		' Token: 0x06000777 RID: 1911 RVA: 0x002594AC File Offset: 0x002584AC
		Public Sub New(assemblyToMigrate As Assembly)
			Me._assemblyToMigrate = assemblyToMigrate
		End Sub

		' Token: 0x06000778 RID: 1912 RVA: 0x002594BC File Offset: 0x002584BC
		Public Function SetObjectData(obj As Object, info As SerializationInfo, context As StreamingContext, selector As ISurrogateSelector) As Object Implements System.Runtime.Serialization.ISerializationSurrogate.SetObjectData
			Dim text As String = String.Empty
			For Each serializationEntry As SerializationEntry In info
				text = serializationEntry.Name
				Dim type As Type
				If text.IndexOf("+") <> -1 Then
					Dim array As String() = text.Split("+".ToCharArray())
					Dim text2 As String = array(0)
					text = array(1)
					type = obj.[GetType]()
					While StringType.StrCmp(type.Name, text2, False) <> 0
						type = type.BaseType
					End While
				Else
					type = obj.[GetType]()
				End If
				Dim member As MemberInfo() = type.GetMember(text, MemberTypes.Field, BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.NonPublic)
				If member.Length > 0 Then
					Dim fieldInfo As FieldInfo = CType(member(0), FieldInfo)
					Dim obj2 As Object = RuntimeHelpers.GetObjectValue(serializationEntry.Value)
					If obj2 IsNot Nothing AndAlso Not fieldInfo.FieldType.IsInstanceOfType(RuntimeHelpers.GetObjectValue(obj2)) Then
						obj2 = RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(obj2), fieldInfo.FieldType))
					End If
					fieldInfo.SetValue(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj2))
				End If
			Next
			Return Nothing
		End Function

		' Token: 0x06000779 RID: 1913 RVA: 0x002595C4 File Offset: 0x002585C4
		Public Sub GetObjectData(entity As Object, info As SerializationInfo, context As StreamingContext) Implements System.Runtime.Serialization.ISerializationSurrogate.GetObjectData
			Throw New NotImplementedException()
		End Sub

		' Token: 0x0600077A RID: 1914 RVA: 0x002595CC File Offset: 0x002585CC
		Public Function GetSurrogate(type As Type, context As StreamingContext, ByRef selector As ISurrogateSelector) As ISerializationSurrogate Implements System.Runtime.Serialization.ISurrogateSelector.GetSurrogate
			If type.Assembly Is Me._assemblyToMigrate Then
				selector = Me
				Return Me
			End If
			selector = Nothing
			Return Nothing
		End Function

		' Token: 0x0600077B RID: 1915 RVA: 0x002595F0 File Offset: 0x002585F0
		Public Function GetNextSelector() As ISurrogateSelector Implements System.Runtime.Serialization.ISurrogateSelector.GetNextSelector
			Return Nothing
		End Function

		' Token: 0x0600077C RID: 1916 RVA: 0x00259600 File Offset: 0x00258600
		Public Sub ChainSelector(selector As ISurrogateSelector) Implements System.Runtime.Serialization.ISurrogateSelector.ChainSelector
			Throw New NotImplementedException("ChainSelector not supported")
		End Sub

		' Token: 0x040003D8 RID: 984
		Private _assemblyToMigrate As Assembly
	End Class
End Namespace
