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

The standalone frmModelPreview form is defined in frmMain.ModelPreview.vb, with the standard frmMain.ModelPreview.Designer.vb and frmMain.ModelPreview.resx files nested beneath it. Use View Designer on that VB file to edit the native viewport panel and animation sidebar. Designer controls use framework types only; PreviewController creates WebView2 and the animated loading bar at runtime. The resource-browser context menu and selection timer remain in frmMain.ModelPreviewIntegration.vb, nested beneath frmMain.vb.

## Send to 3DS Max (2021)

Working-directory cleanup has been removed from the Tools menu and model-export options, including its deletion routine. Open Working Directory remains available. Model extraction no longer clears the export directory before writing its output.

The MDL context menu also calls frmMain.NWlisten.vb. It shares archive-aware resource reads with preview, stages ASCII MDL and textures under `Application.StartupPath\working\NWlisten\jobs`, and waits asynchronously for NWlisten import acknowledgement in frmProgressMeter. The sender registers its application directory in the 64-bit HKCU registry view so Max can discover it. Success closes automatically; failure stays readable with a close button, including an unwritable application folder (no user-profile fallback). Export assets persist for Max texture references. See ../Tools/3DSMax/NWListen/README.md for installation, queue lifecycle and validation.
