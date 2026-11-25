Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Namespace kotor_tool
    ' Initial naming register only. Rules are browsing conventions, not engine type declarations.
    Public NotInheritable Class ModelMetadataRegistry
        Public NotInheritable Class Classification
            Public ReadOnly Category As String
            Public ReadOnly Detail As String
            Public ReadOnly Evidence As String
            Public Sub New(ByVal category As String, ByVal detail As String, ByVal evidence As String)
                Me.Category = category : Me.Detail = detail : Me.Evidence = evidence
            End Sub
        End Class

        Private NotInheritable Class Rule
            Public ReadOnly Pattern As Regex
            Public ReadOnly Value As Classification
            Public Sub New(ByVal expression As String, ByVal category As String, ByVal detail As String, ByVal evidence As String)
                Pattern = New Regex(expression, RegexOptions.IgnoreCase Or RegexOptions.CultureInvariant)
                Value = New Classification(category, detail, evidence)
            End Sub
        End Class

        Private Shared ReadOnly Rules As Rule() = {
            New Rule("^(gidy_intlight|gidy_sun|m14light)$", "Lighting rigs", "Scene lighting", "Inspected K1 MDL: dummy roots and light nodes"),
            New Rule("^hcrates$", "Environment props", "Crate scenery with collision geometry", "Inspected K1 MDL: crate meshes, LZA crate textures and AABB"),
            New Rule("^h_m_hi01$", "Character rigs", "Facial/upper-body character rig", "Inspected K1 MDL: Character, facial hierarchy, CSpar2 supermodel"),
            New Rule("^h_m_hibody$", "Character rigs", "Body character rig", "Inspected K1 MDL: Character, articulated torso and limbs"),
            New Rule("^load_sw$", "GUI", "Loading-screen geometry", "Inspected K1 MDL: load_sw textures and statusbar node"),
            New Rule("^lplanet_01$", "Planets", "GUI planet display", "Inspected K1 MDL: Planet mesh, GUI_yavin_1, rotate/zoomin clips"),
            New Rule("^lqa_(dewback|gizka|mykal)$", "Creatures", "Alternate named creature models", "Inspected K1 MDLs: Character classification and creature mesh hierarchies"),
            New Rule("^m24_vine1$", "Environment props", "Hanging vine", "Inspected K1 MDL: Placeable, PLC_DnglVine textures"),
            New Rule("^mqa_01a$", "Development scenes", "Mixed test scene (inferred purpose)", "Inspected K1 MDL: Testmaterial meshes, creature textures, emitters and references"),
            New Rule("^mydoor2?$", "Doors", "Alternate named door models", "Inspected K1 MDLs: Door classification and door meshes"),
            New Rule("^plcaa$", "Development scenes", "Ruler-textured test scene (inferred purpose)", "Inspected K1 MDL: Ruler01 textures, BoxSpin and AABB geometry"),
            New Rule("^skyboxbase$", "Environment props", "Skybox scenery", "Inspected K1 MDL: Sky1-Sky4 meshes and LSL_sky textures"),
            New Rule("^sol_start$", "Development helpers", "Start marker (inferred purpose)", "Inspected K1 MDL: simple NGon/Line geometry with Toolcolors texture"),
            New Rule("^spawnpoint$", "Development helpers", "Spawn marker (inferred purpose)", "Inspected K1 MDL: SpawnPoint root and untextured Prism01"),
            New Rule("^upgitem_light$", "Special VFX", "Item-upgrade display lighting/camera rig", "Inspected K1 MDL: camera hooks, light nodes and WeaponGui plane"),
            New Rule("^(cgbody_light|cghead_light|cgmain_light|char3d_light|charmain_light|charrec_light|galaxy|lmg_distort)$", "Special VFX", "", "User register"),
            New Rule("^(charviewaxis|lmi_doornotready)$|^gi_", "Engine interface", "", "User register"),
            New Rule("^(ad_saul|darthband_h)$", "Special character heads", "", "User register"),
            New Rule("^(crossgob|hal0[1-4]gob)$", "Cut content - Sleheyron", "User identification; provenance not independently verified", "User register"),
            New Rule("^(computer|empty|spacesuit01|watersuit)$", "Miscellaneous", "", "User register"),
            New Rule("^fx_carbref$", "Standard FX", "Carbonite FX", "User register"),
            New Rule("^fxc?_droid[0-9]", "Standard FX", "Droid destruction FX", "User register"),
            New Rule("^fx_explode_", "Standard FX", "Explosion FX", "User register"),
            New Rule("^fx_flame", "Standard FX", "Flame FX", "User register"),
            New Rule("^fx_|^fxc_|^fxmuzzle$", "Standard FX", "", "User register / K1 inventory"),
            New Rule("^gui_|^(3dgui|maingui|mainmenu|mainmenu_model|gui3d_room)$", "GUI", "", "User register / K1 inventory"),
            New Rule("^p[fm]h[abc][0-9]{2}$", "Player heads", "", "K1 head naming family; heads.2da references"),
            New Rule("^p[fm]b", "Player bodies", "", "K1 body naming family; appearance.2da references"),
            New Rule("^a_jedirobe_|^shirt_", "Clothing and robes", "", "K1 inventory"),
            New Rule("^old_", "Elderly NPCs", "", "K1 inventory naming convention"),
            New Rule("^twilek_", "Twi'lek NPCs", "", "K1 inventory naming convention"),
            New Rule("^mg|^m[0-9]{2}mg_", "Minigame", "", "User register / K1 inventory"),
            New Rule("^m[0-9]{2}[a-z]{2}_", "Maps", "Area / room models", "User register / K1 inventory"),
            New Rule("^c_", "Creatures", "", "User register"),
            New Rule("^comm_", "Commoners", "", "User register"),
            New Rule("^child_", "Child NPCs", "", "User register"),
            New Rule("^czerka_", "Czerka", "", "User register"),
            New Rule("^dor_", "Doors", "", "User register"),
            New Rule("^l_", "Local NPCs", "", "User register"),
            New Rule("^n_", "Global NPCs", "", "User register"),
            New Rule("^or_", "Environment props", "", "User register"),
            New Rule("^p_", "Party NPCs", "", "User register"),
            New Rule("^plc_", "Placeable items", "", "User register"),
            New Rule("^planet", "Planets", "", "User register"),
            New Rule("^s_", "Supermodels", "", "User register"),
            New Rule("^stunt", "Stunts", "", "User register / K1 inventory"),
            New Rule("^v_", "Visuals", "", "User register"),
            New Rule("^rep_", "Republic", "", "User register"),
            New Rule("^sith_", "Sith", "", "User register"),
            New Rule("^i_|^it_bag(_[0-9]+)?$", "Items", "", "User register / K1 inventory"),
            New Rule("^w_", "Weapons", "", "User register")
        }
        Private Shared ReadOnly K2Rules As Rule() = {
            New Rule("^baodur_b[c-f]$", "Party NPCs", "Bao-Dur body variants", "Inspected K2 MDLs: character hierarchies with P_BaoDurBB supermodel"),
            New Rule("^k1_pfbim$", "Player bodies", "Legacy named female body", "Inspected K2 MDL: character body with S_Female03 supermodel"),
            New Rule("^p[fm]hh0[12]$", "Player heads", "Additional head variants", "Inspected K2 MDLs: head/neck meshes and character hierarchy"),
            New Rule("^mainmenu0[1-6]$", "GUI", "Main-menu scenes", "Inspected K2 MDLs: camera hooks, InnerMenu geometry and emitters"),
            New Rule("^ebon_01$", "GUI", "Ebon Hawk display", "Inspected K2 MDL: Gui_ebon_01, camera hook, zoomin/rotate clips"),
            New Rule("^tree_base$", "Environment props", "Tree scenery", "Inspected K2 MDL: tree meshes with DXn_leaves and DXn_bark"),
            New Rule("^(000test|999dia)$", "Development scenes", "Test scenes (inferred purpose)", "Inspected K2 MDLs: simple Peragus-textured geometry, walkmesh and lighting"),
            New Rule("^000trl$", "Stunts", "Staged camera/effect scene (inferred purpose)", "Inspected K2 MDL: camera hook, mist/sand emitters and lighting"),
            New Rule("^[0-9]{3}(ebo|per|har|tel|nar|dxn|ond|dan|kor|dro|nih|mal|cor)cam[0-9]*$", "Camera rigs", "Area cutscene cameras", "K2 inventory family; inspected 001ebocam/101percam: camera hooks and CUT clips"),
            New Rule("^211tel_mg[cemt][0-9]+$", "Minigame", "Telos minigame assets", "K2 inventory naming family; inspected 211tel_mgc01: hitbump collision, Ready/hit clips"),
            New Rule("^[0-9]{3}(ebo|per|har|tel|nar|dxn|ond|dan|kor|dro|nih|mal|cor)[a-z0-9_]*$", "Maps", "Area / room models", "K2 inventory naming family; inspected 101perab/301nara: area-textured scenery and walkmesh"),
            New Rule("^(gidy_intlight|gidy_sun|m14light)$", "Lighting rigs", "Scene lighting (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^hcrates$", "Environment props", "Crate scenery with collision geometry (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^h_m_hi01$", "Character rigs", "Facial/upper-body character rig (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^h_m_hibody$", "Character rigs", "Body character rig (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^load_sw$", "GUI", "Loading-screen geometry (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^lqa_(dewback|gizka|mykal)$", "Creatures", "Alternate named creature models (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^mydoor2?$", "Doors", "Alternate named door models (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^plcaa$", "Development scenes", "Ruler-textured test scene (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^skyboxbase$", "Environment props", "Skybox scenery (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^sol_start$", "Development helpers", "Start marker (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^spawnpoint$", "Development helpers", "Spawn marker (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^upgitem_light$", "Special VFX", "Item-upgrade display lighting/camera rig (name-based inference in K2)", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^(cgbody_light|cghead_light|cgmain_light|char3d_light|charmain_light|charrec_light|galaxy|lmg_distort)$", "Special VFX", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^(charviewaxis|lmi_doornotready)$|^gi_", "Engine interface", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^(ad_saul|darthband_h)$", "Special character heads", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^(crossgob|hal0[1-4]gob)$", "Legacy assets", "Shared K1 asset names; K2 usage not established", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^(computer|empty|spacesuit01|watersuit)$", "Miscellaneous", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^fx_carbref$", "Standard FX", "Carbonite FX", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^fxc?_droid[0-9]", "Standard FX", "Droid destruction FX", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^fx_explode_", "Standard FX", "Explosion FX", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^fx_flame", "Standard FX", "Flame FX", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^fx_|^fxc_|^fxmuzzle$", "Standard FX", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^gui_|^(3dgui|maingui|mainmenu|mainmenu_model|gui3d_room)$", "GUI", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^p[fm]h[abc][0-9]{2}$", "Player heads", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^p[fm]b", "Player bodies", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^a_jedirobe_|^shirt_", "Clothing and robes", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^old_", "Elderly NPCs", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^twilek_", "Twi'lek NPCs", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^mg|^m[0-9]{2}mg_", "Minigame", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^c_", "Creatures", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^comm_", "Commoners", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^child_", "Child NPCs", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^czerka_", "Czerka", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^dor_", "Doors", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^l_", "Local NPCs", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^n_", "Global NPCs", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^or_", "Environment props", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^p_", "Party NPCs", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^plc_", "Placeable items", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^planet", "Planets", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^s_", "Supermodels", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^stunt", "Stunts", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^v_", "Visuals", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^rep_", "Republic", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^sith_", "Sith", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^i_|^it_bag(_[0-9]+)?$", "Items", "", "K2 KEY inventory; shared K1 naming convention"),
            New Rule("^w_", "Weapons", "", "K2 KEY inventory; shared K1 naming convention")
        }
        Private Shared ReadOnly Unknown As New Classification("Other models", "Unclassified", "No matching naming rule")
        Public Shared Function Classify(ByVal resRef As String, ByVal gameIndex As Integer) As Classification
            If (gameIndex <> 0 AndAlso gameIndex <> 1) OrElse String.IsNullOrWhiteSpace(resRef) Then Return Unknown
            Dim name As String = resRef.Trim()
            If name.EndsWith(".mdl", StringComparison.OrdinalIgnoreCase) Then name = name.Substring(0, name.Length - 4)
            For Each rule As Rule In If(gameIndex = 0, Rules, K2Rules)
                If rule.Pattern.IsMatch(name) Then Return rule.Value
            Next
            Return Unknown
        End Function
    End Class
End Namespace
