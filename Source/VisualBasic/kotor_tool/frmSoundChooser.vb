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

		' Token: 0x17000535 RID: 1333
		' (get) Token: 0x06000EDC RID: 3804 RVA: 0x00291248 File Offset: 0x00290248
		' (set) Token: 0x06000EDD RID: 3805 RVA: 0x002911F4 File Offset: 0x002901F4
		Friend Overridable Property btnPlaySound As Button
			Get
				Return Me._btnPlaySound
			End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnPlaySound IsNot Nothing Then
                    RemoveHandler Me._btnPlaySound.Click, AddressOf Me.btnPlaySound_Click
                End If
                Me._btnPlaySound = value
                If Me._btnPlaySound IsNot Nothing Then
                    AddHandler Me._btnPlaySound.Click, AddressOf Me.btnPlaySound_Click
                End If
            End Set
        End Property

        ' Token: 0x17000536 RID: 1334
        ' (get) Token: 0x06000EDF RID: 3807 RVA: 0x0029125C File Offset: 0x0029025C
        ' (set) Token: 0x06000EDE RID: 3806 RVA: 0x00291270 File Offset: 0x00290270
        Friend Overridable Property btnStopSound() As Button
            Get
                Return Me._btnStopSound
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnStopSound IsNot Nothing Then
                    RemoveHandler Me._btnStopSound.Click, AddressOf Me.btnStopSound_Click
                End If
                Me._btnStopSound = value
                If Me._btnStopSound IsNot Nothing Then
                    AddHandler Me._btnStopSound.Click, AddressOf Me.btnStopSound_Click
                End If
            End Set
        End Property

        ' Token: 0x17000537 RID: 1335
        ' (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00291318 File Offset: 0x00290318
        ' (set) Token: 0x06000EE0 RID: 3808 RVA: 0x002912C4 File Offset: 0x002902C4
        Friend Overridable Property lbSounds() As ListBox
            Get
                Return Me._lbSounds
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ListBox)
                If Me._lbSounds IsNot Nothing Then
                    RemoveHandler Me._lbSounds.SelectedIndexChanged, AddressOf Me.lbSounds_SelectedIndexChanged
                End If
                Me._lbSounds = value
                If Me._lbSounds IsNot Nothing Then
                    AddHandler Me._lbSounds.SelectedIndexChanged, AddressOf Me.lbSounds_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x17000538 RID: 1336
        ' (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0029132C File Offset: 0x0029032C
        ' (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00291340 File Offset: 0x00290340
        Friend Overridable Property chkbLookSoundsBif() As CheckBox
            Get
                Return Me._chkbLookSoundsBif
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbLookSoundsBif IsNot Nothing Then
                    RemoveHandler Me._chkbLookSoundsBif.CheckedChanged, AddressOf Me.LookForSoundsChkBxsChanged
                End If
                Me._chkbLookSoundsBif = value
                If Me._chkbLookSoundsBif IsNot Nothing Then
                    AddHandler Me._chkbLookSoundsBif.CheckedChanged, AddressOf Me.LookForSoundsChkBxsChanged
                End If
            End Set
        End Property

        ' Token: 0x17000539 RID: 1337
        ' (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00291394 File Offset: 0x00290394
        ' (set) Token: 0x06000EE4 RID: 3812 RVA: 0x002913A8 File Offset: 0x002903A8
        Friend Overridable Property chkbLookStreamSounds() As CheckBox
            Get
                Return Me._chkbLookStreamSounds
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As CheckBox)
                If Me._chkbLookStreamSounds IsNot Nothing Then
                    RemoveHandler Me._chkbLookStreamSounds.CheckedChanged, AddressOf Me.LookForSoundsChkBxsChanged
                End If
                Me._chkbLookStreamSounds = value
                If Me._chkbLookStreamSounds IsNot Nothing Then
                    AddHandler Me._chkbLookStreamSounds.CheckedChanged, AddressOf Me.LookForSoundsChkBxsChanged
                End If
            End Set
        End Property

        ' Token: 0x1700053A RID: 1338
        ' (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00291450 File Offset: 0x00290450
        ' (set) Token: 0x06000EE6 RID: 3814 RVA: 0x002913FC File Offset: 0x002903FC
        Friend Overridable Property tbFilter() As TextBox
            Get
                Return Me._tbFilter
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As TextBox)
                If Me._tbFilter IsNot Nothing Then
                    RemoveHandler Me._tbFilter.TextChanged, AddressOf Me.tbFilter_TextChanged
                End If
                Me._tbFilter = value
                If Me._tbFilter IsNot Nothing Then
                    AddHandler Me._tbFilter.TextChanged, AddressOf Me.tbFilter_TextChanged
                End If
            End Set
        End Property

        ' Token: 0x1700053B RID: 1339
        ' (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00291464 File Offset: 0x00290464
        ' (set) Token: 0x06000EE8 RID: 3816 RVA: 0x00291478 File Offset: 0x00290478
        Friend Overridable Property cmbxFilter() As ComboBox
            Get
                Return Me._cmbxFilter
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As ComboBox)
                If Me._cmbxFilter IsNot Nothing Then
                    RemoveHandler Me._cmbxFilter.SelectedIndexChanged, AddressOf Me.cmbxFilter_SelectedIndexChanged
                End If
                Me._cmbxFilter = value
                If Me._cmbxFilter IsNot Nothing Then
                    AddHandler Me._cmbxFilter.SelectedIndexChanged, AddressOf Me.cmbxFilter_SelectedIndexChanged
                End If
            End Set
        End Property

        ' Token: 0x1700053C RID: 1340
        ' (get) Token: 0x06000EEA RID: 3818 RVA: 0x002914CC File Offset: 0x002904CC
        ' (set) Token: 0x06000EEB RID: 3819 RVA: 0x002914E0 File Offset: 0x002904E0
        Friend Overridable Property lblSoundCount() As Label
            Get
                Return Me._lblSoundCount
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._lblSoundCount IsNot Nothing Then
                End If
                Me._lblSoundCount = value
                If Me._lblSoundCount IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700053D RID: 1341
        ' (get) Token: 0x06000EED RID: 3821 RVA: 0x002914FC File Offset: 0x002904FC
        ' (set) Token: 0x06000EEC RID: 3820 RVA: 0x00291510 File Offset: 0x00290510
        Friend Overridable Property Label2() As Label
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label2 IsNot Nothing Then
                End If
                Me._Label2 = value
                If Me._Label2 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700053E RID: 1342
        ' (get) Token: 0x06000EEE RID: 3822 RVA: 0x0029152C File Offset: 0x0029052C
        ' (set) Token: 0x06000EEF RID: 3823 RVA: 0x00291540 File Offset: 0x00290540
        Friend Overridable Property btnOK() As Button
            Get
                Return Me._btnOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnOK IsNot Nothing Then
                End If
                Me._btnOK = value
                If Me._btnOK IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x1700053F RID: 1343
        ' (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0029155C File Offset: 0x0029055C
        ' (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00291570 File Offset: 0x00290570
        Friend Overridable Property btnCancel() As Button
            Get
                Return Me._btnCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Button)
                If Me._btnCancel IsNot Nothing Then
                End If
                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000540 RID: 1344
        ' (get) Token: 0x06000EF3 RID: 3827 RVA: 0x002915A8 File Offset: 0x002905A8
        ' (set) Token: 0x06000EF2 RID: 3826 RVA: 0x0029158C File Offset: 0x0029058C
        Friend Overridable Property Label1() As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label1 IsNot Nothing Then
                End If
                Me._Label1 = value
                If Me._Label1 IsNot Nothing Then
                End If
            End Set
        End Property

        ' Token: 0x17000541 RID: 1345
        ' (get) Token: 0x06000EF5 RID: 3829 RVA: 0x002915D8 File Offset: 0x002905D8
        ' (set) Token: 0x06000EF4 RID: 3828 RVA: 0x002915BC File Offset: 0x002905BC
        Friend Overridable Property Label3() As Label
            Get
                Return Me._Label3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
               Set(ByVal value As Label)
                If Me._Label3 IsNot Nothing Then
                End If
                Me._Label3 = value
                If Me._Label3 IsNot Nothing Then
                End If
            End Set
        End Property

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

        ' Token: 0x04000736 RID: 1846
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As Button

        ' Token: 0x04000737 RID: 1847
        <AccessedThroughProperty("lblSoundCount")> _
        Private _lblSoundCount As Label

        ' Token: 0x04000738 RID: 1848
        <AccessedThroughProperty("btnOK")> _
        Private _btnOK As Button

        ' Token: 0x04000739 RID: 1849
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label

        ' Token: 0x0400073A RID: 1850
        <AccessedThroughProperty("cmbxFilter")> _
        Private _cmbxFilter As ComboBox

        ' Token: 0x0400073B RID: 1851
        <AccessedThroughProperty("btnPlaySound")> _
        Private _btnPlaySound As Button

        ' Token: 0x0400073C RID: 1852
        <AccessedThroughProperty("tbFilter")> _
        Private _tbFilter As TextBox

        ' Token: 0x0400073D RID: 1853
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label

        ' Token: 0x0400073E RID: 1854
        <AccessedThroughProperty("chkbLookStreamSounds")> _
        Private _chkbLookStreamSounds As CheckBox

        ' Token: 0x0400073F RID: 1855
        <AccessedThroughProperty("btnStopSound")> _
        Private _btnStopSound As Button

        ' Token: 0x04000740 RID: 1856
        <AccessedThroughProperty("lbSounds")> _
        Private _lbSounds As ListBox

        ' Token: 0x04000741 RID: 1857
        <AccessedThroughProperty("chkbLookSoundsBif")> _
        Private _chkbLookSoundsBif As CheckBox

        ' Token: 0x04000742 RID: 1858
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label

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
