Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000073 RID: 115
	Public Partial Class frmSoundChooser
		Inherits Form

		' Token: 0x06000EDA RID: 3802 RVA: 0x002911A0 File Offset: 0x002901A0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSoundChooser_Load
			Me.FilterList = New ArrayList()
			Me.InitializeComponent()
			Me.SetUpcmbxFilter()
		End Sub

        ' Token: 0x06000EF7 RID: 3831 RVA: 0x00291DE0 File Offset: 0x00290DE0
        Private Sub btnPlaySound_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CType(Me.Owner, frmUTS_Editor).PlaySound(StringType.FromObject(ObjectType.StrCatObj(Me.lbSounds.SelectedItem, ".wav"))) Then
                Me.btnPlaySound.Enabled = False
                Me.btnStopSound.Enabled = True
            End If
        End Sub

        ' Token: 0x06000EF8 RID: 3832 RVA: 0x00291E34 File Offset: 0x00290E34
        Private Sub lbSounds_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnPlaySound.Enabled = Not CType(Me.Owner, frmUTS_Editor).IsSoundPlaying() AndAlso Me.lbSounds.SelectedIndices.Count > 0
        End Sub

        ' Token: 0x17000542 RID: 1346
        ' (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00291E6C File Offset: 0x00290E6C
        ' (set) Token: 0x06000EFA RID: 3834 RVA: 0x00291E80 File Offset: 0x00290E80
        Public Property SoundBifFilesHash() As Hashtable
            Get
                Return Me._soundBifFilesHash
            End Get
            Set(ByVal value As Hashtable)
                Me._soundBifFilesHash = value
                Me.AddSoundFileHashesToLB()
            End Set
        End Property

        ' Token: 0x17000543 RID: 1347
        ' (get) Token: 0x06000EFB RID: 3835 RVA: 0x00291E90 File Offset: 0x00290E90
        ' (set) Token: 0x06000EFC RID: 3836 RVA: 0x00291EA4 File Offset: 0x00290EA4
        Public Property StreamSoundsFilesHash() As Hashtable
            Get
                Return Me._StreamSoundsFilesHash
            End Get
            Set(ByVal value As Hashtable)
                Me._StreamSoundsFilesHash = value
                Me.AddSoundFileHashesToLB()
            End Set
        End Property

        ' Token: 0x17000544 RID: 1348
        ' (get) Token: 0x06000EFD RID: 3837 RVA: 0x00291EB4 File Offset: 0x00290EB4
        Public ReadOnly Property SelectedSounds() As ListBox.SelectedObjectCollection
            Get
                Return Me.lbSounds.SelectedItems
            End Get
        End Property

        ' Token: 0x06000EFE RID: 3838 RVA: 0x00291ECC File Offset: 0x00290ECC
        Private Sub tbFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.AddSoundFileHashesToLB()
        End Sub

        ' Token: 0x06000EFF RID: 3839 RVA: 0x00291ED4 File Offset: 0x00290ED4
        Private Sub cmbxFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.AddSoundFileHashesToLB()
        End Sub

        ' Token: 0x06000F00 RID: 3840 RVA: 0x00291EDC File Offset: 0x00290EDC
        Private Sub AddSoundFileHashesToLB()
            Me.lbSounds.BeginUpdate()
            Me.lbSounds.Items.Clear()
            Dim filterItem As frmSoundChooser.FilterItem = CType(Me.cmbxFilter.SelectedItem, frmSoundChooser.FilterItem)
            If Me._soundBifFilesHash IsNot Nothing AndAlso Me.chkbLookSoundsBif.Checked Then
                For Each obj As Object In Me._soundBifFilesHash
                    Dim dictionaryEntry As DictionaryEntry = CType((If(obj, Activator.CreateInstance(GetType(DictionaryEntry)))), DictionaryEntry)
                    If (StringType.StrCmp(filterItem._filter, "", False) = 0 OrElse (StringType.StrCmp(filterItem._filter, "", False) <> 0 AndAlso dictionaryEntry.Key.ToString().StartsWith(filterItem._filter))) AndAlso dictionaryEntry.Key.ToString().IndexOf(Me.tbFilter.Text) > -1 Then
                        Me.lbSounds.Items.Add(dictionaryEntry.Key.ToString().Replace(".wav", ""))
                    End If
                Next
            End If
            If Me._StreamSoundsFilesHash IsNot Nothing AndAlso Me.chkbLookStreamSounds.Checked Then
                For Each obj2 As Object In Me._StreamSoundsFilesHash
                    Dim dictionaryEntry2 As DictionaryEntry = CType((If(obj2, Activator.CreateInstance(GetType(DictionaryEntry)))), DictionaryEntry)
                    If (StringType.StrCmp(filterItem._filter, "", False) = 0 OrElse (StringType.StrCmp(filterItem._filter, "", False) <> 0 AndAlso dictionaryEntry2.Key.ToString().StartsWith(filterItem._filter))) AndAlso dictionaryEntry2.Key.ToString().IndexOf(Me.tbFilter.Text) > -1 Then
                        Me.lbSounds.Items.Add(dictionaryEntry2.Key.ToString().Replace(".wav", ""))
                    End If
                Next
            End If
            Me.lbSounds.Sorted = True
            Me.lbSounds.EndUpdate()
            Me.lblSoundCount.Text = StringType.FromInteger(Me.lbSounds.Items.Count) + " Sound"
            If Me.lbSounds.Items.Count > 1 OrElse Me.lbSounds.Items.Count = 0 Then
                Dim lblSoundCount As Label = Me.lblSoundCount
                lblSoundCount.Text += "s"
            End If
        End Sub

        ' Token: 0x06000F01 RID: 3841 RVA: 0x00292170 File Offset: 0x00291170
        Private Sub LookForSoundsChkBxsChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.AddSoundFileHashesToLB()
        End Sub

        ' Token: 0x06000F02 RID: 3842 RVA: 0x00292178 File Offset: 0x00291178
        Private Sub SetUpcmbxFilter()
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Ambient - Single shot", "as_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Ambient - Looping", "al_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Animals - Single shot", "as_an_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Electronic - Single shot", "as_el_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Environment - Single shot", "as_en_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Mechanical - Single shot", "as_me_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Natural - Single shot", "as_nt_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Other - Single shot", "as_ot_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("People - Single shot", "as_pl_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Visual Effects - Single shot", "as_en_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Animals - Looping", "al_an_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Electronic - Looping", "al_el_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Environment - Looping", "al_en_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Mechanical - Looping", "al_me_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Natural - Looping", "al_nt_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Other - Looping", "al_ot_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("People - Looping", "al_pl_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("Visual Effects - Looping", "al_en_"))
            Me.FilterList.Add(New frmSoundChooser.FilterItem("All Files", ""))
            Me.cmbxFilter.DataSource = Me.FilterList
        End Sub

        ' Token: 0x06000F03 RID: 3843 RVA: 0x00292398 File Offset: 0x00291398
        Private Sub OwnerStoppedPlaying()
            Me.btnPlaySound.Enabled = True
            Me.btnStopSound.Enabled = False
        End Sub

        ' Token: 0x06000F04 RID: 3844 RVA: 0x002923B4 File Offset: 0x002913B4
        Private Sub btnStopSound_Click(ByVal sender As Object, ByVal e As EventArgs)
            CType(Me.Owner, frmUTS_Editor).StopSound()
            Me.OwnerStoppedPlaying()
        End Sub

        ' Token: 0x06000F05 RID: 3845 RVA: 0x002923CC File Offset: 0x002913CC
        Private Sub frmSoundChooser_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddHandler CType(Me.Owner, frmUTS_Editor).StoppedPlaying, AddressOf Me.OwnerStoppedPlaying
        End Sub

        ' Token: 0x04000744 RID: 1860
        Private FilterList As ArrayList

        ' Token: 0x04000745 RID: 1861
        Private _soundBifFilesHash As Hashtable

        ' Token: 0x04000746 RID: 1862
        Private _StreamSoundsFilesHash As Hashtable

        ' Token: 0x04000747 RID: 1863
        Private _selected As ListBox.SelectedObjectCollection

        ' Token: 0x02000074 RID: 116
        Private Class FilterItem
            ' Token: 0x06000F06 RID: 3846 RVA: 0x002923EC File Offset: 0x002913EC
            Public Overrides Function ToString() As String
                Return Me._Text
            End Function

            ' Token: 0x06000F07 RID: 3847 RVA: 0x00292400 File Offset: 0x00291400
            Public Sub New()
            End Sub

            ' Token: 0x06000F08 RID: 3848 RVA: 0x00292408 File Offset: 0x00291408
            Public Sub New(ByVal Text As String, ByVal Filter As String)
                Me._Text = Text
                Me._filter = Filter
            End Sub

            ' Token: 0x04000748 RID: 1864
            Public _Text As String

            ' Token: 0x04000749 RID: 1865
            Public _filter As String
        End Class
    End Class
End Namespace
