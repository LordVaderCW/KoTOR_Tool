Imports System
Imports System.Collections.Generic
Imports System.IO
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
    ''' <summary>
    ''' Handles the decoding and extraction of TPC (Texture) files from various KOTOR archives (ERF, RIM, BIF).
    ''' This class is designed to operate headlessly, completely separate from any UI forms, allowing for 
    ''' fast batch processing and background execution.
    ''' </summary>
    Public Class clsImageExtraction

        ''' <summary>
        ''' Handles the batch extraction of TPC textures. Loops through a list of texture nodes,
        ''' retrieves their raw byte data from the appropriate archive, and exports them to the chosen format.
        ''' </summary>
        ''' <param name="startNode">The node the user initially selected in the tree/list.</param>
        ''' <param name="tpcNodes">A list of all TPC nodes available in the same container (folder/archive).</param>
        ''' <param name="count">The number of files the user requested to extract.</param>
        ''' <param name="exportFormat">The target format (TGA, PNG, JPG, or TPC).</param>
        ''' <param name="outputPath">The folder (for batch) or specific file path (for single) to save to.</param>
        ''' <param name="mainForm">A reference to frmMain so we can call its resource-fetching methods.</param>
        ''' <param name="progressMeter">The progress bar form to update (can be Nothing if only extracting 1 file).</param>
        Public Shared Sub ExtractTextureBatch(ByVal startNode As KotorTreeNode, ByVal tpcNodes As List(Of KotorTreeNode), ByVal count As Integer, ByVal exportFormat As String, ByVal outputPath As String, ByVal mainForm As frmMain, ByVal progressMeter As frmProgressMeter)

            ' Find the index of the starting node in the list. 
            ' If it's somehow not found, default to 0 to prevent crashes.
            Dim startIndex As Integer = tpcNodes.IndexOf(startNode)
            If startIndex < 0 Then startIndex = 0

            ' Keep track of how many files successfully export
            Dim exportedCount As Integer = 0

            ' Loop through the requested number of files
            For i As Integer = 0 To count - 1
                ' The Modulo operator (%) ensures that if the user requests more files than exist in the list,
                ' it will loop back to the beginning of the list and keep going.
                Dim idx As Integer = (startIndex + i) Mod tpcNodes.Count
                Dim currentNode As KotorTreeNode = tpcNodes(idx)

                ' Update the progress meter text so the user knows exactly which file is being processed
                If progressMeter IsNot Nothing Then
                    progressMeter.status = "Exporting " & currentNode.ResRef & "." & exportFormat.ToLower()
                End If

                ' Fetch the raw byte data for the current file based on its container type
                Dim data As Byte() = Nothing
                If ObjectType.ObjTst(currentNode.Tag, "RIM_Res", False) = 0 Then
                    data = mainForm.GetRIMResource(currentNode.FilePath, currentNode)
                ElseIf ObjectType.ObjTst(currentNode.Tag, "BIFF_Res", False) = 0 Then
                    data = mainForm.GetBIFFResource(currentNode.FilePath, currentNode.LocalResID).data
                ElseIf ObjectType.ObjTst(currentNode.Tag, "ERF_Res", False) = 0 Then
                    data = mainForm.GetERFResource(currentNode.FilePath, currentNode)
                End If

                ' If we successfully retrieved the data, proceed with saving
                If data IsNot Nothing Then
                    Dim finalOutputPath As String = outputPath

                    ' If we are extracting multiple files, the output path is a directory.
                    ' We need to append the filename and correct extension to the path.
                    If count > 1 Then
                        finalOutputPath = Path.Combine(outputPath, currentNode.ResRef & "." & exportFormat.ToLower())
                    End If

                    ' Use a Try/Catch block so that if one texture is corrupt and fails to export, 
                    ' it doesn't crash the entire batch process.
                    Try
                        ExportTPC(data, finalOutputPath, exportFormat)
                        exportedCount += 1
                    Catch ex As System.Exception
                        ' Optionally, you could log the error here (e.g., Console.WriteLine(ex.Message))
                    End Try
                End If

                ' Advance the progress bar by one step
                If progressMeter IsNot Nothing Then
                    progressMeter.stepUp()
                End If
            Next

            ' If this was a batch extraction, show a summary message when finished
            If count > 1 Then
                Interaction.MsgBox("Batch export complete. Exported " & exportedCount.ToString() & " textures.", MsgBoxStyle.Information, "Batch Export")
            End If
        End Sub

        ''' <summary>
        ''' Exports a single TPC byte array to the specified format.
        ''' This handles the file system checks and calls the underlying image decoding system.
        ''' </summary>
        ''' <param name="tpcData">The raw TPC byte array.</param>
        ''' <param name="outputPath">The exact file path to save to (including extension).</param>
        ''' <param name="exportFormat">The desired output format (TPC, TGA, PNG, JPG).</param>
        Public Shared Sub ExportTPC(ByVal tpcData As Byte(), ByVal outputPath As String, ByVal exportFormat As String)

            ' Ensure the directory exists before attempting to write the file
            Dim outputDir As String = Path.GetDirectoryName(outputPath)
            If Not String.IsNullOrEmpty(outputDir) AndAlso Not Directory.Exists(outputDir) Then
                Directory.CreateDirectory(outputDir)
            End If

            ' If the user selected "TPC", we don't need to decode the image at all.
            ' We simply write the raw byte array directly to disk.
            If exportFormat.Equals("TPC", StringComparison.OrdinalIgnoreCase) Then
                File.WriteAllBytes(outputPath, tpcData)
                Return
            End If

            ' For all other formats (TGA, PNG, JPG), we pass the data to clsImageSystem.
            ' This class handles the heavy lifting of decompressing DXT data and formatting it.
            Dim imageSystem As New clsImageSystem()
            imageSystem.SetupTPCData(tpcData, Path.GetFileNameWithoutExtension(outputPath))
            imageSystem.DecodeImage()
            imageSystem.ExportImage(outputPath, exportFormat.ToUpper())
        End Sub
    End Class
End Namespace