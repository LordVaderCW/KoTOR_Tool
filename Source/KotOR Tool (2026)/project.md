<<<<<<< HEAD:Source/KotOR Tool (2026)/project.md
# KoTOR Tool Engineering Map

This is the documentation root for the restored KoTOR Tool solution. It describes the behavior that can be verified from the current source tree; historical claims are identified separately when they disagree with build metadata.
=======
# KoTOR Tool — Treya Engineering Map

This is the documentation root for the `treya/v.1.0.3.4` VB.NET solution. Statements are verified from Treya unless marked historical or inferred.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/project.md

## Snapshot

| Property | Verified value |
| --- | --- |
<<<<<<< HEAD:Source/KotOR Tool (2026)/project.md
| Application | Windows Forms resource browser and editor for *Knights of the Old Republic* I and II |
| Implementation | 210 VB source files, 59 `.resx` files, 58 form code-behind/designer pairs |
| Build | Legacy MSBuild project, .NET Framework 4.6.2, x86, `WinExe` |
| Entry point | `kotor_tool.KT_Launch.Main` |
| Display version | `1.0.3.4` from assembly version `1.0.3.04` |
| Primary orchestration | `kotor_tool/WinForms/frmMain.vb` |
| Build status | Full Visual Studio MSBuild succeeds with 190 existing compiler warnings; `dotnet build` is not compatible with the legacy non-string resources |

## Operating model

1. `KT_Launch.Main` enables WinForms visual styles, installs global exception handlers and theme hooks, then opens `frmMain` with optional command-line arguments.
2. `UserSettings` loads `settings.xml`, preferring the application directory and supporting a legacy install-path lookup. `Options` holds game paths, UI state, extraction preferences and recent-file/tree state.
3. `frmMain` detects configured KoTOR installations and opens each `chitin.key` through `clsChitinKey`. KEY entries map a resource name and type to a packed resource ID and a BIFF index.
4. The main resource tree combines BIFF content with scanned RIM, ERF/MOD/SAV and override content. Nodes carry archive path, resource type, game index and archive-entry identity.
5. Opening a node extracts its bytes and dispatches by resource type. Generic structured resources enter the GFF engine; known types open specialized editors; text, images, sounds, archives and scripts use their own paths.
6. Most specialized game objects (`UTC`, `UTD`, `UTI`, `UTM`, `UTP`, `UTS`, `UTT`, `UTW`, dialogs and globals) are GFF data with type-specific forms layered over shared path-based getters/setters.
7. Saves and projects serialize back to files selected by the user. Temporary extraction/decompilation files live below the application's `working` directory. Plugin commands may launch child processes.

## Core data flow

```text
game install
  chitin.key -> resource name/type -> BIFF file + resource id -> bytes
  modules/*.rim, *.mod, *.erf, saves/*.sav --------------------> bytes
  override/* --------------------------------------------------> bytes
                                                                |
                                                                v
                        frmMain resource dispatch -> parser/editor
                                                        |
                                  GFF / 2DA / TLK / SSF / BWM / text
                                                        |
                                                        v
                                              save, export, or preview
```

The code is stateful and UI-coupled. `frmMain` owns shared KEY/BIFF caches, resource-type mappings, settings and many file helpers. `clsGFF` also contains WinForms binding helpers and reads `dialog.tlk`/2DA data, so it is both a codec and an editor support layer.

## Documentation set

- [Requirements](requirements.md) — verified runtime/build needs and behavioral requirements.
- [Dependencies](dependencies.md) — managed, native, external-tool and game-data dependencies.
- [VB.NET guide](vb.md) — language and maintenance heuristics for the current implementation.
- [C# guide](csharp.md) — current absence and safe migration seams.
- [C++ guide](cplusplus.md) — current native boundary and when C++ is justified.
- [Skills](skills.md) — knowledge needed to work safely in this codebase.
- [Agents](agents.md) — repository-specific rules for automated contributors.
- [Permissions](permissions.md) — runtime and contributor access boundaries.
- [Authors](authors.md) — source-backed attribution.
- [Versioning](versioning.md) — application, deployment and plugin version rules.
- [Application overview](kotor_tool/README.md) — release-facing summary.

## Directory guides

Every maintained directory is linked here. Generated `bin`, `obj` and `.vs` directories are intentionally excluded.

- [Application root](kotor_tool/README.md)
- [Classes](kotor_tool/Classes/README.md)
  - [2DASystem](kotor_tool/Classes/2DASystem/README.md)
  - [AnimSystem](kotor_tool/Classes/AnimSystem/README.md)
  - [BIFFSystem](kotor_tool/Classes/BIFFSystem/README.md)
  - [BWMSystem](kotor_tool/Classes/BWMSystem/README.md)
  - [DLGSystem](kotor_tool/Classes/DLGSystem/README.md)
  - [ERFSystem](kotor_tool/Classes/ERFSystem/README.md)
  - [FilterSystem](kotor_tool/Classes/FilterSystem/README.md)
  - [GFFSystem](kotor_tool/Classes/GFFSystem/README.md)
  - [GlobalSystem](kotor_tool/Classes/GlobalSystem/README.md)
  - [ItemSystem](kotor_tool/Classes/ItemSystem/README.md)
  - [MAPSystem](kotor_tool/Classes/MAPSystem/README.md)
  - [NCSSystem](kotor_tool/Classes/NCSSystem/README.md)
  - [PluginSystem](kotor_tool/Classes/PluginSystem/README.md)
  - [ProjectSystem](kotor_tool/Classes/ProjectSystem/README.md)
  - [RIMSystem](kotor_tool/Classes/RIMSystem/README.md)
  - [Security](kotor_tool/Classes/Security/README.md)
  - [Shared](kotor_tool/Classes/Shared/README.md)
  - [SoundSystem](kotor_tool/Classes/SoundSystem/README.md)
  - [StandardUI](kotor_tool/Classes/StandardUI/README.md)
  - [ThemeSystem](kotor_tool/Classes/ThemeSystem/README.md)
  - [UTCSystem](kotor_tool/Classes/UTCSystem/README.md)
  - [UTDSystem](kotor_tool/Classes/UTDSystem/README.md)
  - [UTISystem](kotor_tool/Classes/UTISystem/README.md)
  - [UTMSystem](kotor_tool/Classes/UTMSystem/README.md)
  - [UTPSystem](kotor_tool/Classes/UTPSystem/README.md)
  - [UTSSytem](kotor_tool/Classes/UTSSytem/README.md)
  - [UTTSystem](kotor_tool/Classes/UTTSystem/README.md)
  - [UTWSystem](kotor_tool/Classes/UTWSystem/README.md)
  - [UtilitySystem](kotor_tool/Classes/UtilitySystem/README.md)
- [ConfigurationFiles](kotor_tool/ConfigurationFiles/README.md)
- [CustomControls](kotor_tool/CustomControls/README.md)
- [Lib](kotor_tool/Lib/README.md)
- [My Project](<kotor_tool/My Project/README.md>)
- [Plugins](kotor_tool/Plugins/README.md)
  - [DeNCS](kotor_tool/Plugins/DeNCS/README.md)
- [Resources](kotor_tool/Resources/README.md)
- [Themes](kotor_tool/Themes/README.md)
- [WinForms](kotor_tool/WinForms/README.md)

## Maintenance heuristics

- Treat binary layouts, resource-type IDs, GFF field names and game-version branches as compatibility contracts. Preserve unknown fields and byte ordering unless a fixture proves a change.
- Keep x86 until FMOD and all shipped managed/native dependencies have been replaced or verified for another architecture.
- Do not edit `.Designer.vb` or `.resx` by hand for ordinary UI behavior. Keep event/business logic in the form's code-behind and verify the Visual Studio designer after layout changes.
- Compile with full-framework Visual Studio MSBuild. The .NET SDK build's resource errors do not imply corrupt `.resx` files.
- The successful build has a large warning baseline. New changes should not add warnings; fixes to uninitialized-local warnings need behavior tests because many are decompiler artifacts.
- Keep source-relative deployment metadata in sync with runtime output: themes, plugins, helper executables, `settings.xml`, template BFDs and native DLLs are located from `Application.StartupPath` or copied beside the executable.
- Separate verified behavior from roadmap language. The existing changelog contains historical target-framework and plugin statements that no longer exactly match the project file or present checkout.

## Evidence and freshness

This map was derived from `kotor_tool.sln`, `kotor_tool/kotor_tool.vbproj`, assembly metadata, source declarations, configuration/manifests, the existing README/changelog/license, binary version metadata, and a successful Debug/x86 Visual Studio MSBuild on 2026-08-08 (190 warnings, 0 errors). Update the relevant directory guide and this index whenever ownership, data flow or build behavior changes.
=======
| Application | Windows Forms resource browser/editor for KoTOR I and II |
| Source | 217 VB files, 59 `.resx` files, 58 form code-behind/designer pairs |
| Build | Legacy MSBuild, .NET Framework 4.6.2, x86 `WinExe` |
| Entry/version | `kotor_tool.KT_Launch.Main`; assembly `1.0.3.04` displayed as `1.0.3.4` |
| Build baseline | Debug/x86 rebuild succeeds with 188 warnings and 0 errors |
| Orchestration | `kotor_tool/WinForms/frmMain.vb` |

## How it operates

1. `KT_Launch` initializes the STA WinForms process, exception handling and global theming, then starts `frmMain`.
2. `UserSettings` loads `settings.xml`; `Options` supplies game paths, UI state and extraction preferences.
3. `clsChitinKey` reads each `chitin.key`, mapping resource names/types to packed BIFF IDs. RIM, ERF/MOD/SAV and Override scanning add other resources.
4. `frmMain` extracts bytes and dispatches by type. GFF backs dialogs, globals and the UTC/UTD/UTI/UTM/UTP/UTS/UTT/UTW editors; 2DA, TLK, SSF, BWM and images use specialized codecs.
5. `ImageSystem` decodes/exports TPC/TGA/PNG/JPG/TXI. Model workflows extract MDL/MDX/textures and invoke MDLOps; NCS decompilation invokes DeNCS.
6. Plugins join catalog, installed record, manifest and command INI data. Binary plugin packages can be downloaded, validated and extracted with managed ZIP or bundled 7-Zip support.
7. User output, projects, settings, themes and plugin/build files are written to selected or application-relative paths.

## Documentation

- [Requirements](requirements.md), [dependencies](dependencies.md), [permissions](permissions.md)
- [VB.NET](vb.md), [C# migration](csharp.md), [C++/native boundary](cplusplus.md)
- [Skills](skills.md), [agent rules](agents.md), [authors](authors.md), [versioning](versioning.md)
- [Application README](kotor_tool/README.md)

## Directory guides

- [Classes](kotor_tool/Classes/README.md): [2DA](kotor_tool/Classes/2DASystem/README.md), [animation](kotor_tool/Classes/AnimSystem/README.md), [BIFF](kotor_tool/Classes/BIFFSystem/README.md), [BWM](kotor_tool/Classes/BWMSystem/README.md), [DLG/TLK](kotor_tool/Classes/DLGSystem/README.md), [ERF](kotor_tool/Classes/ERFSystem/README.md), [filters](kotor_tool/Classes/FilterSystem/README.md), [GFF](kotor_tool/Classes/GFFSystem/README.md), [globals](kotor_tool/Classes/GlobalSystem/README.md), [images](kotor_tool/Classes/ImageSystem/README.md), [items](kotor_tool/Classes/ItemSystem/README.md), [maps](kotor_tool/Classes/MAPSystem/README.md), [modules](kotor_tool/Classes/ModuleSystem/README.md), [NCS](kotor_tool/Classes/NCSSystem/README.md), [plugins](kotor_tool/Classes/PluginSystem/README.md), [projects](kotor_tool/Classes/ProjectSystem/README.md), [RIM](kotor_tool/Classes/RIMSystem/README.md), [security/KEY](kotor_tool/Classes/Security/README.md), [shared](kotor_tool/Classes/Shared/README.md), [sound](kotor_tool/Classes/SoundSystem/README.md), [standard UI](kotor_tool/Classes/StandardUI/README.md), [themes](kotor_tool/Classes/ThemeSystem/README.md), [UTC](kotor_tool/Classes/UTCSystem/README.md), [UTD](kotor_tool/Classes/UTDSystem/README.md), [UTI](kotor_tool/Classes/UTISystem/README.md), [UTM](kotor_tool/Classes/UTMSystem/README.md), [UTP](kotor_tool/Classes/UTPSystem/README.md), [UTS](kotor_tool/Classes/UTSSytem/README.md), [UTT](kotor_tool/Classes/UTTSystem/README.md), [UTW](kotor_tool/Classes/UTWSystem/README.md), [utilities](kotor_tool/Classes/UtilitySystem/README.md)
- [Configuration](kotor_tool/ConfigurationFiles/README.md), [custom controls](kotor_tool/CustomControls/README.md), [libraries](kotor_tool/Lib/README.md), [VB metadata](<kotor_tool/My Project/README.md>)
- [Plugins](kotor_tool/Plugins/README.md): [DeNCS](kotor_tool/Plugins/DeNCS/README.md), [MDLOps](kotor_tool/Plugins/MDLOps/README.md)
- [Resources](kotor_tool/Resources/README.md), [themes](kotor_tool/Themes/README.md), [tools](kotor_tool/Tools/README.md), [7-Zip](kotor_tool/Tools/7Zip/README.md), [WinForms](kotor_tool/WinForms/README.md)

## Maintenance heuristics

- Treat binary layouts, resource IDs, GFF paths, game branches and plugin placeholders as compatibility contracts.
- Keep x86 until FMOD and opaque dependencies are replaced or verified for another architecture.
- Use full Visual Studio MSBuild; `dotnet build` is not the acceptance path for legacy non-string `.resx` files.
- Preserve unknown data and test both games before codec changes.
- Keep form, designer, `.resx` and `.vbproj` metadata synchronized.
- Constrain plugin downloads, extraction, cleanup and executed commands.
- Do not add to the 188-warning recovery baseline.

Derived from source/configuration/manifests, binary metadata and a successful full-framework Debug/x86 rebuild on 2026-08-08.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/project.md

## Model preview addition (2026-11-16)

The separate [ModelPreview library](ModelPreview/README.md) converts MDLOps ASCII output to embedded glTF and hosts a local HTML/WebView2 viewport. The resource-browser right-click menu invokes it; double-click extraction is unchanged. See its guide for dependencies, lifecycle, tests and rendering limits.

## NWlisten bridge (2026-11-19)

[ NWlisten ](kotor_tool/Tools/3DSMax/NWListen/README.md) adds an MDL context action for 3DS Max 2021. The frmMain.NWlisten.vb partial stages MDLOps output and textures into persistent jobs under `working\NWlisten` beside the application executable; a separately installed MAXScript listener discovers that directory through an HKCU registry pointer, imports with NWmax and acknowledges completion to the existing progress window. No changes to NWmax importer internals or game data are required.

NWlisten now resets controllers only on the newly imported nodes and removes generated rest-pose jumps between animation clips before acknowledging completion. Clip endpoints are preserved using Max's own key insertion; see its guide for validation and the separate war-droid death-track limitation.

Send to Max stores generated assets in the application's existing `working\NWlisten\jobs` directory. The working-directory cleanup command and pre-export cleanup option have been removed, along with their deletion routine and saved setting.

The maintained [3ds Max tools](kotor_tool/Tools/3DSMax/README.md) live under `kotor_tool/Tools/3DSMax/NWListen` and `NWMax` and appear in the application's Visual Studio project as non-compiled items. NWListen's installer and tests moved with its source; NWMax is a hash-recorded snapshot of the installed runtime. Builds copy distributable tool files into `Tools\3DSMax` beside the application executable using PreserveNewest; tests and generated artifacts are excluded. Builds do not automatically deploy either tool to Max.
