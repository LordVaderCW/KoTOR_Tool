# Initial K1/K2 model metadata register

`ModelMetadataRegistry` is a small compiled naming-rule register, not yet the full MetaDataSystem. Its result carries Category, Detail and Evidence. Specific names take precedence over broad prefixes; matching is case-insensitive and independent of the current culture. Unknown names stay visible in Other models. Each game has its own rule array (index 0 for K1, 1 for K2); other indexes return Other models. K2 rules use its inventory and inspected examples, with shared naming conventions explicitly identified.

`ModelTreeGroups` inserts alphabetically sorted, counted folders beneath each K1/K2 BIF's Aurora Model category. Existing resource nodes are moved, not cloned or rewritten: ResRef, resource ID, type, archive path and game identity remain intact. Folder nodes use NodeCategory and no resource type/ResRef, so they cannot be opened as MDLs. The grouping pass is repeatable. Module/RIM/ERF resources retain their current structure.

The main form groups after attaching each BIF's type categories. Whole-BIF and subtype extraction now recursively enumerate resource leaves; group extraction uses that same traversal and resolves the owning archive through ancestors. Individual model preview, Send to Max and file extraction still receive the original resource node. The metadata register never reads or alters model bytes at startup.

## Rules and evidence

All requested prefixes and named exceptions are implemented, including the explicit Sleheyron group. That cut-content attribution is retained as user-supplied identification, not an independently established fact. Broad rules remain naming conventions, not proof of engine usage. FX subtypes (carbonite, droid destruction, explosion, flame) are retained as Detail metadata under Standard FX rather than expanding the tree with more levels.

Inventory/research additions:

- Player heads: `p[fm]h[abc]##` (30 models in this installation).
- Player bodies: `p[fm]b...` (65); includes legacy/test-looking variants, so this describes a name family, not confirmed playability.
- Clothing and robes: `a_jedirobe_...`, `shirt_...` (6).
- Elderly NPCs: `old_...` (12); Twi'lek NPCs: `twilek_...` (7).
- Minigame: `mgb_`, `mgf_`, `mgg_` and area names `m##mg_...` are included before the general map pattern.
- GUI aliases: `3dgui`, `maingui`, `mainmenu`, `mainmenu_model`, `gui3d_room`.
- Stunt aliases without underscore: `stuntroom...`, `stuntdroids`; item bag variants `it_bag...`.

The extra families above are inferred from the installed K1 KEY inventory. For richer metadata, actual table/model relationships should supersede those inferences:

- [PyKotor's 2DA documentation](https://github.com/OpenKotOR/PyKotor/blob/master/wiki/2DA-File-Format.md#heads2da) describes `heads.2da` head model references and `appearance.2da` body model columns. These provide a stronger future source than a prefix alone.
- [PyKotor's MDL documentation](https://github.com/OpenKotOR/PyKotor/blob/master/wiki/MDL-MDX-File-Format.md) identifies model structure, supermodel links and LYT room placement. Future enrichment can follow supermodel references and LYT membership instead of assuming every `s_` or `m...` name proves its function.

## Inventory coverage (2026-11-25)

Across **all BIFs** in the installed K1 KEY: 2,832 MDLs, all 2,832 classified into 36 named categories, none remaining in Other models. Each actual BIF displays only the categories present in that archive. Counts are installation-specific, not a guaranteed stock manifest.

```text
Character rigs (2)
Child NPCs (2)
Clothing and robes (6)
Commoners (12)
Creatures (57)
Cut content - Sleheyron (5)
Czerka (1)
Development helpers (2)
Development scenes (2)
Doors (56)
Elderly NPCs (12)
Engine interface (14)
Environment props (14)
Global NPCs (86)
GUI (7)
Items (127)
Lighting rigs (3)
Local NPCs (27)
Maps (1417)
Minigame (249)
Miscellaneous (4)
Party NPCs (24)
Placeable items (249)
Planets (8)
Player bodies (65)
Player heads (30)
Republic (4)
Sith (3)
Special character heads (2)
Special VFX (9)
Standard FX (41)
Stunts (21)
Supermodels (5)
Twi'lek NPCs (7)
Visuals (123)
Weapons (136)
```

## Remaining entries resolved from copied MDLs

All twenty remaining names were extracted read-only from K1 and decompiled from isolated copies with the existing MDLOps tool. These are exact-name rules, not new catch-all prefixes. Model contents establish the visible asset type; intended runtime/development use is still an inference where indicated.

| Names | Group | Observed evidence / detail |
| --- | --- | --- |
| `gidy_intlight`, `gidy_sun`, `m14light` | Lighting rigs | Dummy roots and light nodes |
| `hcrates` | Environment props | Crate meshes/textures and AABB collision geometry |
| `h_m_hi01`, `h_m_hibody` | Character rigs | Character classification; facial/upper-body and body hierarchies respectively; the first references CSpar2 |
| `load_sw` | GUI | Loading textures and a statusbar node |
| `lplanet_01` | Planets | Planet mesh, GUI_yavin_1 texture, rotate/zoomin animations |
| `lqa_dewback`, `lqa_gizka`, `lqa_mykal` | Creatures | Character classification and matching creature mesh hierarchies; no claim about quality or unused status |
| `m24_vine1` | Environment props | Placeable classification, PLC_DnglVine textures |
| `mqa_01a` | Development scenes | Mixed Testmaterial meshes, creature textures, lights, emitters and references; test-scene purpose inferred |
| `mydoor`, `mydoor2` | Doors | Door classification and door meshes |
| `plcaa` | Development scenes | Ruler01-textured geometry, BoxSpin and AABB; test-scene purpose inferred |
| `skyboxbase` | Environment props | Sky1-Sky4 meshes and sky textures |
| `sol_start`, `spawnpoint` | Development helpers | Toolcolors-textured NGon/Line geometry and an untextured Prism01 respectively; marker purpose inferred |
| `upgitem_light` | Special VFX | Camera hooks, light nodes and WeaponGui plane; item-upgrade display rig |

This does not establish that development-looking assets are unused or cut content. Unknown future/modded model names still fall back to Other models.

## Verification

Ignored test fixtures contain copied K1/K2 KEY files and a synthetic BIFF. The compiled application was checked against 2,832 K1 and 3,237 K2 MDLs for resource preservation, sorting, repeat grouping, case/exception precedence and unknown fallback. Both games receive category folders; all K1 classifications were checked against the previous baseline. Archive/category/group extraction reproduced fixture bytes exactly. A rendered TreeView confirmed folder presentation. Test executables and fixtures are not application payload or Visual Studio source items.

## K2 inventory and rules (2026-11-25)

The installed K2 KEY contains **3,237 MDLs, classified into 37 categories**, with none remaining in Other models. Counts describe this installation, not every release/mod configuration. K1 rules and their results are unchanged. K2 has a separate array so game-specific exceptions and evidence cannot leak between games. Shared naming families are recorded as conventions; K1 inspection evidence is not presented as K2 inspection.

K2 numbered area families use the bounded suffix set `ebo`, `per`, `har`, `tel`, `nar`, `dxn`, `ond`, `dan`, `kor`, `dro`, `nih`, `mal`, `cor`. Camera names ending in `cam` plus optional digits are classified first as Camera rigs (19). `211tel_mg[cemt]#` assets are classified first as Minigame. Other matching numbered assets are Maps. These are name-family rules supported by inspected samples, not an assertion that every mesh in the family is a room.

Remaining exceptions were inspected from isolated copies using MDLOps in K2 mode:

| Names | Group | Evidence / interpretation |
| --- | --- | --- |
| `baodur_bc` through `baodur_bf` | Party NPCs | Character bodies with P_BaoDurBB supermodel |
| `k1_pfbim` | Player bodies | Character body with S_Female03 supermodel |
| `pfhh01`, `pfhh02`, `pmhh01`, `pmhh02` | Player heads | Head/neck geometry and character hierarchy |
| `mainmenu01` through `mainmenu06` | GUI | Camera hooks, InnerMenu geometry and emitters |
| `ebon_01` | GUI | Gui_ebon_01 texture, camera, zoomin/rotate clips |
| `tree_base` | Environment props | Tree meshes with DXn_leaves and DXn_bark textures |
| `000test`, `999dia` | Development scenes | Simple Peragus-textured geometry, walkmesh and lights; development purpose inferred |
| `000trl` | Stunts | Staged camera, lights and mist/sand effects; purpose inferred |

Inspected area samples `101perab` and `301nara` contain scenery; `001ebocam` and `101percam` contain camera hooks and CUT animations. `211tel_mgc01` contains hitbump collision and Ready/hit clips. K1's user-attributed Sleheyron names are grouped in K2 as Legacy assets, with no claim about their K2 story role or unused status. Shared exact-name exceptions retain their browsing categories with explicitly name-based K2 evidence.

K2 category counts:

```text
Camera rigs (19)
Character rigs (2)
Child NPCs (2)
Clothing and robes (6)
Commoners (12)
Creatures (94)
Czerka (1)
Development helpers (2)
Development scenes (3)
Doors (113)
Elderly NPCs (12)
Engine interface (14)
Environment props (14)
Global NPCs (164)
GUI (14)
Items (128)
Legacy assets (5)
Lighting rigs (2)
Local NPCs (27)
Maps (1475)
Minigame (169)
Miscellaneous (4)
Party NPCs (38)
Placeable items (385)
Planets (9)
Player bodies (73)
Player heads (46)
Republic (4)
Sith (3)
Special character heads (2)
Special VFX (8)
Standard FX (45)
Stunts (2)
Supermodels (5)
Twi'lek NPCs (7)
Visuals (151)
Weapons (177)
```

Full-framework MSBuild x86 Release passed. The fixture harness checked both games, unchanged K1 classifications, repeated grouping, original node identities, ordering, case/extension normalization, game isolation, unknown names/indexes and exact-byte archive/category/group extraction. A synthetic WinForms TreeView rendered the K2 folders for visual inspection. Fixtures/harness outputs remain ignored and outside Visual Studio source items and application payload.

## Map model labels

Deferred BIF browsing (2026-11-28): `ResourceLeaves` and `FindArchive` traverse `KotorTreeNode.ResourceChildren()` / `ResourceParent` so group and archive extraction includes unopened folders without creating native TreeView items. Grouping still runs on the complete detached hierarchy before deferral. The WinForms lazy-tree harness verifies original resource identity, both game indices and exact-byte extraction including unknown resource types.

`MapModuleMetadata` stores stock English area names separately for K1 and K2. Map leaves display `filename.mdl | area name`, for example `m01aa_01a.mdl | Endar Spire - Command Module` and `001ebo1.mdl | Ebon Hawk - Interior`. Only `TreeNode.Text` changes. Filename, ResRef, archive path, resource ID and game identity remain untouched, and labels are reconstructed from Filename on each grouping pass so they never accumulate suffixes. Other model categories keep their current labels.

The compiled register was derived read-only from the installed games' base module ARE `Name` localized strings and `dialog.tlk` on 2026-11-25. It contains 95 K1 and 73 K2 area identifiers. Exact LYT room membership takes precedence where it differs from the name prefix (nine K1 room exceptions). Multiple distinct area names for a shared identifier are retained, separated by ` / `. Empty and Untitled names are excluded. The ARE's own wording is retained even for cutscene scenes whose familiar community name differs.

Known labels cover 1,303 of 1,417 K1 Maps and 1,381 of 1,475 K2 Maps in the inspected KEY inventories. The remaining 114 K1 and 94 K2 map assets show `Module name unavailable`; absent or unnamed modules are not assigned speculative names. This is a stock metadata snapshot, not a live resolver for mod replacements or localized installs. Unknown future model names do not inherit arbitrary nearby area labels.

Verification: full-framework MSBuild x86 Release passed. The ignored fixture harness checked both complete model inventories, repeated label application, game isolation, case/extension handling, unknown names, unchanged resource filenames and byte-exact archive/category/Maps-group extraction of labelled resources. A synthetic WinForms tree rendered both games' labels. No game files were edited, and test executables were removed from the application output after verification.

## Map location and level folders (K1 and K2)

Both games now expand Maps into counted location and level folders, for example `Maps > Taris > South Apartments > model files` and `Maps > Peragus > Administration Level > model files`. `MapModuleMetadata.GetLevel` uses the canonical area-family name in the selected game's register, independently of shared-room aliases in leaf labels. It splits the location and level at the first ` - `. Names without a level (such as K1 Ebon Hawk) put their files directly under the location. Multiple level names in one canonical entry remain one shared level folder. Unresolved entries appear under `Unidentified levels > area code`; no geographic assignment is guessed.

Location/level folders retain NodeCategory, no resource type or ResRef, and the correct game index. Their `mdl-group:` identity keeps the existing Extract model group action available. Counts represent descendant files, not immediate child folders. Locations, levels and files are sorted; grouping still moves original leaves and is repeatable. The Maps category and existing filename/area labels remain present. Other categories are unchanged.

Verification: full-framework x86 Release build passed. The ignored harness covered both full KEY inventories, resource identity, filenames, game-specific parent folders, folder counts/order, repeated grouping and unknown areas. Synthetic BIFF extraction from archives, type folders, Maps, locations and levels reproduced the source bytes. A rendered WinForms tree confirmed the nested layout for both games. Test executables were removed from application output.

## Internet research additions (2026-11-25)

Added 17 area-family identifications covering 143 previously unnamed map models. The current inspected inventory has 1,352/1,417 K1 Maps with labels and 1,475/1,475 K2 Maps with labels. These are identifications for browsing, not proof that a module is playable in an unmodified installation. Existing ARE-derived entries are unchanged.

Sources and qualifications:

- [DarthParametric's K1 model/layout register](https://deadlystream.com/topic/11352-trying-to-locate-all-the-files-for-ebon-hawk-interior/) identifies `m19aa` as the cut Tatooine temple, `m25ab` as cut Lower Shadowlands B, and `m31aa`, `m31ab`, `m31ad` as cut Sleheyron arenas A, B and D. The same register describes `m21aa` as a cut Czerka office but leaves its location uncertain. It therefore appears under **Unknown location**, not an invented planet. These are community research identifications, not names recovered from ARE records.
- [DarthParametric's firsthand cutscene-model findings](https://deadlystream.com/files/file/1958-dark-side-ending-cutscene-enhancement/?tab=comments), comment dated 2025-05-07, link `m44ad` to the revelation scene and the ending layout `stunt_unktemp`. The shipped LYT room references independently confirm that shared geometry. Label: Unknown World / Temple Summit (revelation / ending scenes).
- [Sith Holocron's TSL module register](https://deadlystream.com/blogs/entry/413-blog-111-the-tsl-warp-code-list/) identifies `298tel` and `299tel` with the HK factory areas in TSLRCM and `352nar` with Goto's cutscene. [DarthParametric's module list](https://deadlystream.com/topic/9824-editing-the-static-map/) corroborates these uses. This does not imply TSLRCM is installed.
- [The loading-screen author's M4-78 area list](https://deadlystream.com/files/file/1253-replacement-loading-screens-for-kotor2-add-on-pack-with-or-without-tslrcm/) maps `801dro` through `807dro` to landing, central, environmental, industrial and three archon areas. These labels explicitly say **restored name**: the documented names are from M4-78 Enhancement Project usage of the surviving assets, not verified original shipping titles. Archon character names from the restoration were omitted.

Remaining K1 research gaps: `m09zz` (3 models), `m12ac`–`m12ah` (54), `m41az` (6), `m47ac` (2). Searches for these exact codes and room names did not produce a dependable online module-title mapping. Local LYT inspection shows the m12 variants contain MGO/MGT assets, `m41az` is shared with `stunt_unkramp`, and `m47ac` rooms occur in `m47aa.lyt`; these clues are not sufficient to assign a precise level name. They remain under Unidentified levels. Failure to find online documentation is not evidence that an asset was cut.

The full-framework x86 Release build and ignored fixture harness passed after these additions: both game inventories, exact researched labels, case handling, parent groups, counts, repeated grouping, resource identity and nested extraction remain valid. K2 unresolved map count is zero; K1 is 65. Test harnesses and fixtures remain outside Visual Studio source items and application payload.
