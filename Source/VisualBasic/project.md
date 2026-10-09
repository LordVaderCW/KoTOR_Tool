# KoTOR Tool — Treya Engineering Map

This is the documentation root for the `treya/v.1.0.3.4` VB.NET solution. Statements are verified from Treya unless marked historical or inferred.

## Snapshot

| Property | Verified value |
| --- | --- |
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
