# KoTOR Tool Engineering Map

This is the documentation root for the restored KoTOR Tool solution. It describes the behavior that can be verified from the current source tree; historical claims are identified separately when they disagree with build metadata.

## Snapshot

| Property | Verified value |
| --- | --- |
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
