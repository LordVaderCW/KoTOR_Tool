Option Strict On
Option Explicit On

Namespace kotor_tool
    Public Partial Class frmModelPreview
        Private previewController As ModelPreview.PreviewController

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal directory As String, ByVal modelName As String)
            Me.New()
            previewController = New ModelPreview.PreviewController(Me, directory, modelName,
                viewportPanel, status, loading, animationList, clipSummary,
                playButton, stopButton, loopCheck, exportButton)
        End Sub

        Public Sub ShowLoading(ByVal modelName As String)
            If previewController IsNot Nothing Then previewController.ShowLoading(modelName)
        End Sub

        Public Sub ShowLoadError(ByVal message As String)
            If previewController IsNot Nothing Then previewController.ShowLoadError(message)
        End Sub

        Public Sub CancelLoading()
            If previewController IsNot Nothing Then previewController.CancelLoading()
        End Sub

        Public Sub ReplaceModel(ByVal directory As String, ByVal modelName As String)
            If previewController IsNot Nothing Then previewController.ReplaceModel(directory, modelName)
        End Sub
    End Class
End Namespace
