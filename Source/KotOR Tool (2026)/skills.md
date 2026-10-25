<<<<<<< HEAD:Source/KotOR Tool (2026)/skills.md
# Skills for Maintaining KoTOR Tool

This is a human/agent capability map, not an executable Codex skill package.

## Essential skills

- Legacy VB.NET and MSBuild 2003 project files, including `Option Strict Off` semantics.
- WinForms designer/resource maintenance and STA-thread event behavior.
- Binary parsing with little-endian readers, offset tables, fixed-width strings and bounds checks.
- BioWare Aurora/Odyssey resource concepts: KEY/BIFF, RIM, ERF/MOD/SAV, GFF, 2DA, TLK, SSF, NCS/NSS and walkmeshes.
- KoTOR I versus KoTOR II schema/resource differences.
- XML serialization and INI/XML configuration compatibility.
- Child-process orchestration, quoting, timeouts, output capture and safe path resolution.
- 32-bit managed/native dependency diagnosis, especially legacy FMOD.

## Task-to-skill routing

| Task | Read first | Validate with |
| --- | --- | --- |
| Archive extraction | `Security`, `BIFFSystem`, `RIMSystem`, `ERFSystem` guides | Known archive fixture and extracted hashes |
| Structured editor | `GFFSystem`, target `UT*System`, `WinForms` | GFF semantic round trip and editor smoke test |
| Script handling | `NCSSystem`, `PluginSystem`, `Plugins/DeNCS`, `WinForms` | Complete plugin payload and NSS compile/decompile sample |
| Audio | `SoundSystem`, `WinForms`, `Lib` | RIFF/WAVE variants, playback, stop/close lifecycle |
| UI/theme | `ThemeSystem`, `CustomControls`, `Themes`, `WinForms` | Designer load and runtime theme switch |
| Build/deployment | `requirements.md`, `dependencies.md`, `My Project` | Clean full-framework Debug/Release x86 builds |
| Language migration | `vb.md`, `csharp.md`, `cplusplus.md` | Cross-language fixture suite |

## Missing capability to prioritize

The repository has no automated tests. The most valuable new capability is a fixture-based parser test suite that can compare round trips and malformed-input behavior without starting WinForms.
=======
# Maintenance Skills

This is a capability map, not an executable skill package.

- Legacy VB.NET/MSBuild and WinForms designer/resources.
- KEY/BIFF, RIM, ERF/MOD/SAV, GFF, 2DA, TLK, SSF and BWM formats.
- TPC/TGA/TXI, MDL/MDX and texture/model resolution.
- KoTOR I/II differences, XML/INI compatibility and safe persistence.
- Process quoting/timeouts/output capture and FMOD lifecycle.
- Secure download, ZIP/7-Zip extraction and exact-root cleanup.
- x86 managed/native diagnosis.

The highest-priority missing capability is a headless fixture-based test suite.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/skills.md
