# Requirements

## Build and runtime

- Windows, Visual Studio full-framework MSBuild and .NET Framework 4.6.2 targeting/developer pack.
- Legacy VB/MSBuild 2003 support, x86 output and checked-in `kotor_tool/Lib` references.
- Build with `MSBuild.exe kotor_tool.sln /p:Configuration=Debug /p:Platform=x86`; SDK `dotnet build` fails on legacy non-string resources.
- A configured KoTOR I or II install with `chitin.key`, BIFFs, `dialog.tlk`, archives and optional Override.
- Write access for application-relative settings/working/themes/plugins and user-selected outputs.
- Feature helpers: GFFEditor, NWScript compiler, and complete DeNCS/MDLOps payloads.

## Behavioral requirements

- Preserve game context, numeric types, offsets, unknown fields and localized-string representation.
- Keep installed game archives read-only by default.
- Validate counts/offsets and plugin paths before allocation, writes or execution.
- Keep WinForms STA threading and marshal background progress.
- Save settings/projects compatibly and surface missing/corrupt data.
- Restrict cleanup/install operations to exact canonical plugin roots.

On 2026-08-08 a Debug/x86 rebuild succeeded with 188 warnings and 0 errors. No automated test project exists; binary changes need fixture round trips and UI smoke tests.
