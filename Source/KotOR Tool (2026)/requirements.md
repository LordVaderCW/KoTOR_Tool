# Requirements

This file separates requirements verified by the current implementation from recommendations for future work.

## Build requirements

- Windows with Visual Studio MSBuild and the .NET Framework 4.6.2 targeting/developer pack.
- A Visual Basic compiler capable of the legacy MSBuild 2003 project format.
- An x86 build. All four solution configurations ultimately set `PlatformTarget` to `x86`.
- The checked-in assemblies in `kotor_tool/Lib` and native `fmodex.dll`.
- Full-framework MSBuild, for example:

  ```powershell
  & "<Visual Studio>\MSBuild\Current\Bin\MSBuild.exe" kotor_tool.sln /p:Configuration=Debug /p:Platform=x86
  ```

`dotnet build` with SDK 9 fails while processing non-string WinForms resources (`MSB3822`/`MSB3823`). Do not use that command as the acceptance build unless the project and resource pipeline are deliberately modernized.

## Runtime requirements

- Windows desktop and .NET Framework 4.6.2-compatible runtime.
- Write access beside the deployed executable for `settings.xml`, theme selection/edits, plugin installation and the `working` directory. Installing under a protected directory can prevent these features.
- At least one configured KoTOR installation for resource browsing. The expected files include `chitin.key`, BIFFs under `data`, `dialog.tlk`, module/archive directories and optional `Override` content.
- 32-bit process compatibility for `FMODCL` and FMOD Ex 4.1.5.
- External helper files beside the application when their features are used: `GFFEditor.exe`, `nwnnsscomp.exe`, and a complete DeNCS plugin payload.

## Functional requirements inferred from code

- Detect and distinguish KoTOR I and II paths, retaining a game-version index throughout parsing and editing.
- Resolve KEY entries into BIFF paths/resource IDs and enumerate RIM/ERF/MOD/SAV archive entries.
- Map numeric resource types to filename extensions and dispatch them to a suitable viewer/editor.
- Extract raw resources without modifying source game archives.
- Read and write supported structured formats without losing field type, list/struct relationships, localized-string data or game-specific values.
- Support standalone file opening from the command line as well as resource-tree navigation.
- Persist user options, recent files, window geometry, theme selection and module-project settings.
- Surface long-running plugin/install/decompile work through progress UI and return actionable diagnostics.
- Keep external process execution bounded by manifest command settings, including working directory, output path and timeout.

## Non-functional requirements

- Preserve original KoTOR Tool behavior unless a restoration fix is documented.
- Remain x86 and compatible with the shipped binary dependencies until those dependencies are explicitly replaced.
- Fail visibly on corrupt or missing game/plugin data; do not silently rewrite archives.
- Keep UI operations on the STA WinForms thread. Background workers must marshal completion/state changes safely.
- Maintain designer-loadable form triplets: code-behind, `.Designer.vb`, and `.resx` with matching `DependentUpon` metadata.
- Treat user-selected paths, plugin manifest paths and archive offsets as untrusted input; normalize and bounds-check before reads, writes or process launches.

## Verification baseline

As of 2026-08-08, a Debug/x86 rebuild succeeds with Visual Studio MSBuild, emits the executable under `kotor_tool/bin/x86/Debug`, and reports 190 compiler warnings with 0 errors. The warnings are chiefly possible use of unassigned locals, member shadowing and CLS-compliance issues. There is no automated test project, so parser/editor changes require fixture-based round trips plus focused UI smoke tests.
