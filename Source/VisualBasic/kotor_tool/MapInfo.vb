Imports System
Imports System.Collections

Namespace kotor_tool
	' Token: 0x02000088 RID: 136
    <Serializable()> _
 Public Class MapInfo
        ' Token: 0x04000B35 RID: 2869
        Public MapList As ArrayList

        ' Token: 0x04000B36 RID: 2870
        Public Version As String

        ' Token: 0x02000089 RID: 137
        <Serializable()> _
        Public Class Map
            ' Token: 0x04000B37 RID: 2871
            Public L As Boolean

            ' Token: 0x04000B38 RID: 2872
            Public S As Boolean

            ' Token: 0x04000B39 RID: 2873
            Public AltS As Boolean

            ' Token: 0x04000B3A RID: 2874
            Public Name As String

            ' Token: 0x04000B3B RID: 2875
            Public MapName As String

            ' Token: 0x04000B3C RID: 2876
            Public ModuleName As String

            ' Token: 0x04000B3D RID: 2877
            Public MapAssembler As String

            ' Token: 0x04000B3E RID: 2878
            Public MapCalibrator As String

            ' Token: 0x04000B3F RID: 2879
            Public LXMul As Decimal

            ' Token: 0x04000B40 RID: 2880
            Public LYMul As Decimal

            ' Token: 0x04000B41 RID: 2881
            Public SXMul As Decimal

            ' Token: 0x04000B42 RID: 2882
            Public SYMul As Decimal

            ' Token: 0x04000B43 RID: 2883
            Public LXOff As Integer

            ' Token: 0x04000B44 RID: 2884
            Public LYOff As Integer

            ' Token: 0x04000B45 RID: 2885
            Public SXOff As Integer

            ' Token: 0x04000B46 RID: 2886
            Public SYOff As Integer

            ' Token: 0x04000B47 RID: 2887
            Public AltSXMul As Decimal

            ' Token: 0x04000B48 RID: 2888
            Public AltSYMul As Decimal

            ' Token: 0x04000B49 RID: 2889
            Public AltSXOff As Integer

            ' Token: 0x04000B4A RID: 2890
            Public AltSYOff As Integer
        End Class
    End Class
End Namespace
