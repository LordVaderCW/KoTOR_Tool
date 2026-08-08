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
