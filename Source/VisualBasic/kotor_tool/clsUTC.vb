Imports System
Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x0200002D RID: 45
	Public Class clsUTC
		Inherits clsGFF

		' Token: 0x06000131 RID: 305 RVA: 0x00224AE0 File Offset: 0x00223AE0
		Public Sub New(KotorVerIndex As Integer)
			MyBase.New(KotorVerIndex)
			Me.KotorVersionIndex = KotorVerIndex
		End Sub

		' Token: 0x06000132 RID: 306 RVA: 0x00224AF0 File Offset: 0x00223AF0
		Public Sub New(fs As FileStream, KotorVerIndex As Integer)
			MyBase.New(fs, KotorVerIndex, True)
		End Sub

		' Token: 0x06000133 RID: 307 RVA: 0x00224AFC File Offset: 0x00223AFC
		Public Sub New(bytes As Byte(), KotorVerIndex As Integer)
			MyBase.New(bytes, KotorVerIndex, True)
		End Sub

		' Token: 0x06000134 RID: 308 RVA: 0x00224B08 File Offset: 0x00223B08
		Public Sub CreateEmptyShell()
			Me.g_structArr = Array.CreateInstance(GetType(Object), 40)
			LateBinding.LateIndexSet(Me.g_structArr, New Object() { 0, New GFF_Struct() }, Nothing)
			Me.StructArray(0).type = -1
			Me.StructArray(0).fieldCount = 69
			Me.StructArray(0).fields = CType(Array.CreateInstance(GetType(Object), 69), GFF_Field())
			Me.StructArray(0).fields(0) = New GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", Nothing)
			Me.StructArray(0).fields(1) = New GFF_Field(GFFField.GFF_byte, "Race", Nothing)
			Me.StructArray(0).fields(2) = New GFF_Field(GFFField.GFF_byte, "SubraceIndex", Nothing)
			Me.StructArray(0).fields(3) = New GFF_Field(GFFField.GFF_CExoLocString, "FirstName", Nothing)
			Me.StructArray(0).fields(4) = New GFF_Field(GFFField.GFF_CExoLocString, "LastName", Nothing)
			Me.StructArray(0).fields(5) = New GFF_Field(GFFField.GFF_word, "Appearance_Type", Nothing)
			Me.StructArray(0).fields(6) = New GFF_Field(GFFField.GFF_byte, "Gender", Nothing)
			Me.StructArray(0).fields(7) = New GFF_Field(GFFField.GFF_int, "Phenotype", Nothing)
			Me.StructArray(0).fields(8) = New GFF_Field(GFFField.GFF_word, "PortraitId", Nothing)
			Me.StructArray(0).fields(9) = New GFF_Field(GFFField.GFF_CExoLocString, "Description", Nothing)
			Me.StructArray(0).fields(10) = New GFF_Field(GFFField.GFF_CExoString, "Tag", Nothing)
			Me.StructArray(0).fields(11) = New GFF_Field(GFFField.GFF_CResRef, "Conversation", Nothing)
			Me.StructArray(0).fields(12) = New GFF_Field(GFFField.GFF_byte, "IsPC", Nothing)
			Me.StructArray(0).fields(13) = New GFF_Field(GFFField.GFF_word, "FactionID", Nothing)
			Me.StructArray(0).fields(14) = New GFF_Field(GFFField.GFF_byte, "Disarmable", Nothing)
			Me.StructArray(0).fields(15) = New GFF_Field(GFFField.GFF_CExoString, "Subrace", Nothing)
			Me.StructArray(0).fields(16) = New GFF_Field(GFFField.GFF_CExoString, "Deity", Nothing)
			Me.StructArray(0).fields(17) = New GFF_Field(GFFField.GFF_word, "SoundSetFile", Nothing)
			Me.StructArray(0).fields(18) = New GFF_Field(GFFField.GFF_byte, "Plot", Nothing)
			Me.StructArray(0).fields(19) = New GFF_Field(GFFField.GFF_byte, "Interruptable", Nothing)
			Me.StructArray(0).fields(20) = New GFF_Field(GFFField.GFF_byte, "NoPermDeath", Nothing)
			Me.StructArray(0).fields(21) = New GFF_Field(GFFField.GFF_byte, "NotReorienting", Nothing)
			Me.StructArray(0).fields(22) = New GFF_Field(GFFField.GFF_byte, "BodyBag", Nothing)
			Me.StructArray(0).fields(23) = New GFF_Field(GFFField.GFF_byte, "BodyVariation", Nothing)
			Me.StructArray(0).fields(24) = New GFF_Field(GFFField.GFF_byte, "TextureVar", Nothing)
			Me.StructArray(0).fields(25) = New GFF_Field(GFFField.GFF_byte, "Min1HP", Nothing)
			Me.StructArray(0).fields(26) = New GFF_Field(GFFField.GFF_byte, "PartyInteract", Nothing)
			Me.StructArray(0).fields(27) = New GFF_Field(GFFField.GFF_byte, "Str", Nothing)
			Me.StructArray(0).fields(28) = New GFF_Field(GFFField.GFF_byte, "Dex", Nothing)
			Me.StructArray(0).fields(29) = New GFF_Field(GFFField.GFF_byte, "Con", Nothing)
			Me.StructArray(0).fields(30) = New GFF_Field(GFFField.GFF_byte, "Int", Nothing)
			Me.StructArray(0).fields(31) = New GFF_Field(GFFField.GFF_byte, "Wis", Nothing)
			Me.StructArray(0).fields(32) = New GFF_Field(GFFField.GFF_byte, "Cha", Nothing)
			Me.StructArray(0).fields(33) = New GFF_Field(GFFField.GFF_int, "WalkRate", Nothing)
			Me.StructArray(0).fields(34) = New GFF_Field(GFFField.GFF_byte, "NaturalAC", Nothing)
			Me.StructArray(0).fields(35) = New GFF_Field(GFFField.GFF_short, "HitPoints", Nothing)
			Me.StructArray(0).fields(36) = New GFF_Field(GFFField.GFF_short, "CurrentHitPoints", Nothing)
			Me.StructArray(0).fields(37) = New GFF_Field(GFFField.GFF_short, "MaxHitPoints", Nothing)
			Me.StructArray(0).fields(38) = New GFF_Field(GFFField.GFF_short, "ForcePoints", Nothing)
			Me.StructArray(0).fields(39) = New GFF_Field(GFFField.GFF_short, "CurrentForce", Nothing)
			Me.StructArray(0).fields(40) = New GFF_Field(GFFField.GFF_short, "refbonus", Nothing)
			Me.StructArray(0).fields(41) = New GFF_Field(GFFField.GFF_short, "willbonus", Nothing)
			Me.StructArray(0).fields(42) = New GFF_Field(GFFField.GFF_short, "fortbonus", Nothing)
			Me.StructArray(0).fields(43) = New GFF_Field(GFFField.GFF_byte, "GoodEvil", Nothing)
			Me.StructArray(0).fields(44) = New GFF_Field(GFFField.GFF_byte, "LawfulChaotic", Nothing)
			Me.StructArray(0).fields(45) = New GFF_Field(GFFField.GFF_float, "ChallengeRating", Nothing)
			Me.StructArray(0).fields(46) = New GFF_Field(GFFField.GFF_byte, "PerceptionRange", Nothing)
			Me.StructArray(0).fields(47) = New GFF_Field(GFFField.GFF_CResRef, "ScriptHeartbeat", Nothing)
			Me.StructArray(0).fields(48) = New GFF_Field(GFFField.GFF_CResRef, "ScriptOnNotice", Nothing)
			Me.StructArray(0).fields(49) = New GFF_Field(GFFField.GFF_CResRef, "ScriptSpellAt", Nothing)
			Me.StructArray(0).fields(50) = New GFF_Field(GFFField.GFF_CResRef, "ScriptAttacked", Nothing)
			Me.StructArray(0).fields(51) = New GFF_Field(GFFField.GFF_CResRef, "ScriptDamaged", Nothing)
			Me.StructArray(0).fields(52) = New GFF_Field(GFFField.GFF_CResRef, "ScriptDisturbed", Nothing)
			Me.StructArray(0).fields(53) = New GFF_Field(GFFField.GFF_CResRef, "ScriptEndRound", Nothing)
			Me.StructArray(0).fields(54) = New GFF_Field(GFFField.GFF_CResRef, "ScriptEndDialogu", Nothing)
			Me.StructArray(0).fields(55) = New GFF_Field(GFFField.GFF_CResRef, "ScriptDialogue", Nothing)
			Me.StructArray(0).fields(56) = New GFF_Field(GFFField.GFF_CResRef, "ScriptSpawn", Nothing)
			Me.StructArray(0).fields(57) = New GFF_Field(GFFField.GFF_CResRef, "ScriptRested", Nothing)
			Me.StructArray(0).fields(58) = New GFF_Field(GFFField.GFF_CResRef, "ScriptDeath", Nothing)
			Me.StructArray(0).fields(59) = New GFF_Field(GFFField.GFF_CResRef, "ScriptUserDefine", Nothing)
			Me.StructArray(0).fields(60) = New GFF_Field(GFFField.GFF_CResRef, "ScriptOnBlocked", Nothing)
			Me.StructArray(0).fields(61) = New GFF_Field(GFFField.GFF_List, "SkillList", Nothing)
			Me.StructArray(0).fields(62) = New GFF_Field(GFFField.GFF_List, "FeatList", Nothing)
			Me.StructArray(0).fields(63) = New GFF_Field(GFFField.GFF_List, "TemplateList", Nothing)
			Me.StructArray(0).fields(64) = New GFF_Field(GFFField.GFF_List, "SpecAbilityList", Nothing)
			Me.StructArray(0).fields(65) = New GFF_Field(GFFField.GFF_List, "ClassList", Nothing)
			Me.StructArray(0).fields(66) = New GFF_Field(GFFField.GFF_List, "Equip_ItemList", Nothing)
			Me.StructArray(0).fields(67) = New GFF_Field(GFFField.GFF_byte, "PaletteID", Nothing)
			Me.StructArray(0).fields(68) = New GFF_Field(GFFField.GFF_CExoString, "Comment", Nothing)
		End Sub

		' Token: 0x06000135 RID: 309 RVA: 0x00225454 File Offset: 0x00224454
		Public Function StructArray(n As Object) As GFF_Struct
			Return CType(Me.g_structArr, GFF_Struct())(IntegerType.FromObject(n))
		End Function

		' Token: 0x06000136 RID: 310 RVA: 0x00225474 File Offset: 0x00224474
		Public Function StructArray() As GFF_Struct()
			Return CType(Me.g_structArr, GFF_Struct())
		End Function
	End Class
End Namespace
