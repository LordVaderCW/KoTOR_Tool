<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/WinForms/README.md
# WinForms Application and Editors

This directory is the application layer: 58 form code-behind files, matching designer files and resources. Forms orchestrate parsers, game data, file dialogs, settings and external tools; a large amount of format schema is encoded directly in control bindings and event handlers.

## Main workflows

- `frmMain` is the startup form, resource browser and central service locator. It loads settings/game indexes, builds resource trees, maps resource type IDs/extensions, extracts archive entries, dispatches editors, manages MRU/tree state, themes, command-line files and legacy updating.
- Generic tools include 2DA, ERF, text/NSS, byte, image, SSF, GFF/dialog, filter and reference-search forms.
- Template editors cover UTC, UTD, UTI, UTM, UTP, UTS, UTT and UTW resources.
- Module/project forms edit package contents, placed objects, module IFO/area properties and project output settings.
- Options, paths, themes, plugins, progress/error/help/about and small prompt/selectors support the main workflows.

## Resource dispatch heuristic

`frmMain` resolves bytes first, then dispatches primarily by extension/resource type. Known GFF file types open a specialized form; unknown GFF may use text/generic GFF paths. Archive nodes can be expanded or extracted. NCS uses `clsNCS`, images may use internal/external viewers, and sound preview uses FMOD.

Keep `GetIDForRsrcType` and `GetRsrcTypeForID` symmetric. A new format normally needs mapping, tree grouping, extraction naming, open dispatch and possibly filter/search support.

## Designer rules

- Keep behavior in `frmName.vb`; use the designer for ordinary layout/resource changes.
- Preserve partial class names and `.vbproj` `DependentUpon` relationships.
- Constructor overloads must all call `InitializeComponent` before touching controls.
- Apply themes after initialization and avoid duplicate event subscriptions when a form is reopened or rethemed.
- Dispose streams, images and FMOD/process resources on success, cancel, failure and form close.

## Verification matrix

Build with full-framework MSBuild, open changed forms in the Visual Studio designer, then exercise standalone-file and archive-resource entry paths. Test both games, save/cancel, corrupt/missing data, theme switching, high DPI and repeated open/close. For module/template editors, reopen the saved GFF and compare unedited fields as well as visible values.
=======
# WinForms Application

Fifty-eight forms implement the main resource browser, generic/archive/text/image/dialog/SSF editors, all UT editors, module/project workflows and support dialogs.

`frmMain` owns game indexes, resource maps/tree/extraction/dispatch, settings, themes and plugin menus. `frmImageViewer` uses `ImageSystem`; model extraction uses `frmMdlOpsSwitches`, MDLOps and sidecar MDX/textures; NCS uses DeNCS. New formats generally require symmetric ID mapping, grouping, extraction naming, dispatch and search/filter support.

Keep behavior in code-behind and layout/resources in designer triplets. All constructors must initialize controls before use; avoid duplicate event subscriptions; dispose streams/images/FMOD/processes on success/cancel/failure/close. Test standalone and archive entry paths, both games, save/cancel, theme/DPI and reopen saved data.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/WinForms/README.md

## Model preview context action

The frmMain.ModelPreviewIntegration.vb partial class adds Preview 3D model to right-click menus for MDL resources in tree/list/details views. Existing double-click extraction remains unchanged. The separate ModelPreview library owns glTF geometry/transform-animation conversion and the designer-backed WebView2 window; see ../../ModelPreview/README.md for dependency and validation details.

The main form retains a single preview window and follows focused resource selection while it is open. A component-owned debounce timer queues only the newest model; request versions discard stale conversion results and closing the preview cancels pending work. Automatic replacement preserves browser-list focus and reports conversion errors inside the viewer.

The standalone frmMDLPreview form is defined in frmMDLPreview.vb, with the standard frmMDLPreview.Designer.vb and frmMDLPreview.resx files nested beneath it. Use View Designer on that VB file to edit the native viewport panel and animation sidebar. Designer controls use framework types only; PreviewController creates WebView2 and the animated loading bar at runtime. The resource-browser context menu and selection timer remain in frmMain.ModelPreviewIntegration.vb, nested beneath frmMain.vb.

## Send to 3DS Max (2021)

Working-directory cleanup has been removed from the Tools menu and model-export options, including its deletion routine. Open Working Directory remains available. Model extraction no longer clears the export directory before writing its output.

The MDL context menu also calls frmMain.NWlisten.vb. It shares archive-aware resource reads with preview, stages ASCII MDL and textures under `Application.StartupPath\working\NWlisten\jobs`, and waits asynchronously for NWlisten import acknowledgement in frmProgressMeter. The sender registers its application directory in the 64-bit HKCU registry view so Max can discover it. Success closes automatically; failure stays readable with a close button, including an unwritable application folder (no user-profile fallback). Export assets persist for Max texture references. See ../Tools/3DSMax/NWListen/README.md for installation, queue lifecycle and validation.

## K1/K2 model groups

BuildTreeView applies `ModelTreeGroups` to each detached K1/K2 BIF's resource-type folders before deferring its descendants and attaching the archive to the native tree. Aurora Model gains counted naming-category folders; Each game uses its own naming rules; module trees retain their existing layout. Extraction traverses resource descendants and finds archive ancestors, so grouped and whole-subtype exports operate on the same original leaf nodes. See [MetaDataSystem](../Classes/MetaDataSystem/README.md) for rules, evidence and inventory coverage.

Map model leaves append the compiled area name to display text only (`filename.mdl | area name`). Resource identity and export filenames remain unchanged; unavailable names have an explicit fallback. See `MapModuleMetadata` in MetaDataSystem.

For both games, Maps now nests location and level folders above the original model leaves. Nested folders use the existing NodeCategory/mdl-group contract, so selecting any location or level enables recursive group extraction with unchanged filenames. Unresolved areas are grouped by code under Unidentified levels.

Startup path validation (1.0.3.5a): frmMain resolves missing or stale game locations before reading either KEY. A detected replacement is saved first; availability checks no longer report an unrelated detected folder as available while the reader still uses the old setting. Valid custom folders take priority. Undetected paths are retained for temporarily disconnected drives and presented through Path Manager, but their trees are not initialized. Validation uses copied K1/K2 KEY files and checks valid, stale, empty, absent and null paths.

## Dialogue index (2026-11-27)

`frmMain.DialogueTree.vb` adds a lazy `Dialogue` root beneath each game. Expand it to browse location > area/module > conversation; shared BIF entries and loose Override files have separate folders. `DialogueTree` reads every DLG entry in the configured game's KEY, Modules/Rims RIM/ERF/MOD archives, and top-level Override directory. The existing MapModuleMetadata catalogue supplies names; Telos includes Citadel Station, and unknown modules remain under Other Modules. This is an inventory of source versions, not a resolver of the game's effective override order. External Workshop directories and save-game snapshots are not scanned.

Archive leaves retain their normal BIFF_Res/RIM_Res/ERF_Res tags, paths, indices and game identity. Source filenames appear in display labels so duplicate ResRefs remain distinguishable. Loose Dialogue_File leaves use the existing DLG editor dispatch with bytes read from their file; single extraction, hex view and browser batch extraction accept them. Navigation folders disable extraction/hex actions. The root is appended after legacy roots to preserve index-based navigation, and collapsing/reopening it rescans sources. Scans dispose file handles and show unreadable sources without hiding other archives. The editor's GFF serialization is unchanged.

Validation: `tests/Run-DialogueTreeTests.ps1 -Kotor1Path <installation> -Kotor2Path <installation>` builds Release/x86 and copies fixtures into a new temporary directory. An independent binary-table inventory verifies complete coverage, source identity and byte-exact reads through existing archive readers; tests also cover folder/file browser classification, repeat scans, K1/K2 planet mapping, unknown modules, malformed archives, loose Override entries and released file handles. The 2026-11-27 installed-data run passed 1,167 K1 and 1,160 K2 entries (246 Telos). These are installation-specific counts, not stock-game guarantees. Interactive editor/theme/DPI checks remain manual.

### Dialogue descriptions

`frmMain.DialogueMetadata.vb` enriches a dialogue group when it is selected or expanded, rather than parsing every conversation at startup. Each filename gains a short label from nearby UTC/UTP/UTD Conversation assignments or explicit speaker tags, followed by a possible opening/text sample. Tree and list tooltips show template evidence, speakers, NPC-entry/player-reply/start counts, author comments, journal identifiers, action scripts and conversation type. Raw filenames, archive IDs and editor dispatch are unchanged; filtering also matches the visible description.

Descriptions use read-only GFF parsing with game index -1 (no global settings/TLK side effects) and a separate bounded TLK lookup against the selected game's dialog.tlk. Embedded strings are retained; missing tables/references and malformed dialogues degrade to explicit unavailable descriptions. Nearby templates include the module's RIM, supplemental RIM, MOD and dialogue ERF. Template assignment is labelled as evidence, not proof that an object is placed or that a source wins mod precedence. Shared/Override dialogues may lack nearby template associations. A starting link can be conditional, and fallback text is labelled as a sample. No filename-derived plot claims, script execution, unused-content claims or save-specific reachability claims are made.

Metadata is cached only on the current leaf nodes; reopening the Dialogue root rebuilds them and picks up edits. Tests now describe all 2,327 fixture dialogues, verify resolved text/template evidence, unchanged payload bytes and repeatable labels, and exercise embedded Unicode strings, invalid StrRefs, absent TLK files and malformed DLG files. Original archive identity and extraction checks remain in place. Interactive tooltip layout/theme checks remain manual.

Quick Send to 3DS Max (2026-11-28): the resource context-menu handler passes includeAnimations=False for both games and all model types, including static module rooms. The sender publishes animations=0 and the existing listener disables animation import and skips controller reset/clip-gap processing. The model viewer's explicit Include animations checkbox remains available. This prevents the quick action from requesting the animation path implicated in the reported 901mala import freeze; a live Max reproduction has not been performed.

The MDL command constructs frmMDLPreview in the editor process and calls Show() without an owner. The viewer is an independent top-level form with ShowInTaskbar=True; it has no Parent or MdiParent and is a separate project item from frmMain. The main browser is not hidden or recreated. Model following, audio and Send to Max use direct calls/events. Editor close cancels pending selection, awaits bounded viewer cleanup and explicitly closes the tracked preview. WebView2 manages its own rendering helper processes. See the ModelPreview guide for lifecycle validation.

## BIF tree shutdown cost (2026-11-28)

An isolated normal-open/close trace, without opening the MDL Viewer, located the expensive work in native TreeView destruction (`Control.Dispose` / `DestroyWindow` / comctl32). With the saved expanded K2 navigation, 19,899 native items took 11,342 ms wall time and 10,062.5 ms process CPU to dispose. Settings saving took about 10 ms. The same navigation after deferring unopened BIF folders created 1,455 items and disposed in 155 ms, using 78.125 ms process CPU. These are local measurements, not universal timing guarantees.

Expansion and list navigation materialize only immediate children. Saved paths continue expanding each ancestor normally. Extraction traverses the full logical hierarchy independently of visible items. Already opened folders retain their native items; deliberately opening the entire tree can still increase teardown cost. Rendering cadence and the MDL Viewer are unchanged by this patch.

Run `tests/Run-LazyResourceTreeTests.ps1 -Kotor1Path <installation> -Kotor2Path <installation> [-Configuration Debug|Release]`. It builds with full-framework MSBuild x86, copies application settings and required KEY/scripts.bif fixtures into a unique temporary directory, and performs all startup writes there. The harness compares both complete KEY inventories, deferred archive/game identity, saved-path navigation, list contents, repeated expansion and exact-byte synthetic BIF extraction including unknown types. Failures are written to `lazy-tree-results.txt` rather than opening an unhandled-exception dialog. Fixtures and logs are retained outside application output.

Acceptance passed in Debug/x86 and Release/x86: all 25,836 K1 and 18,439 K2 resources matched their copied KEY tables. The test's two navigated game trees closed in 77 ms and 44 ms respectively by build configuration. The earlier DirectoryNotFoundException in the isolated test was caused by omitting scripts.bif from its copied fixtures; the runner now includes that startup dependency.
