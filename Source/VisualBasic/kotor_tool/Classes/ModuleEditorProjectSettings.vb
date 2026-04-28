Imports System
Imports System.IO
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic

Namespace kotor_tool
	' Token: 0x0200008B RID: 139
	Public Class ModuleEditorProjectSettings
		' Token: 0x06001745 RID: 5957 RVA: 0x002CB740 File Offset: 0x002CA740
		Public Shared Function GetSettings(LoadPath As String) As ModuleEditorProjectOptions
			Dim moduleEditorProjectOptions2 As ModuleEditorProjectOptions
			Try
				LoadPath = Path.Combine(LoadPath, "project settings.xml")
				Dim moduleEditorProjectOptions As ModuleEditorProjectOptions
				If File.Exists(LoadPath) Then
					Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(ModuleEditorProjectOptions))
					Dim fileStream As FileStream = New FileStream(LoadPath, FileMode.Open, FileAccess.Read)
					moduleEditorProjectOptions = CType(xmlSerializer.Deserialize(fileStream), ModuleEditorProjectOptions)
					fileStream.Close()
				Else
					moduleEditorProjectOptions = New ModuleEditorProjectOptions()
				End If
				moduleEditorProjectOptions2 = moduleEditorProjectOptions
            Catch ex As System.Exception
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "")
                moduleEditorProjectOptions2 = Nothing
			End Try
			Return moduleEditorProjectOptions2
		End Function

		' Token: 0x06001746 RID: 5958 RVA: 0x002CB7D0 File Offset: 0x002CA7D0
		Public Shared Sub SaveSettings(currentSettings As ModuleEditorProjectOptions, savePath As String)
			Try
				savePath = Path.Combine(savePath, "project settings.xml")
				Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(ModuleEditorProjectOptions))
				Dim fileStream As FileStream = New FileStream(savePath, FileMode.Create, FileAccess.ReadWrite)
				xmlSerializer.Serialize(fileStream, currentSettings)
				fileStream.Close()
            Catch ex As System.Exception
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, Nothing)
			End Try
		End Sub
	End Class
End Namespace
