# Dependencies

The project targets .NET Framework 4.6.2 and system Windows Forms/Drawing/Data/Design/XML/Management/IO Compression assemblies. There is no NuGet graph; `app.config` prefers CLR v4 with legacy v2 activation.

| Dependency | Purpose |
| --- | --- |
| `Lib/FMODCL.dll` + root/Lib `fmodex.dll` 4.1.5 | Managed/native x86 sound |
| `Lib/ImageTools.dll` | Legacy image support |
| `Lib/RTFLinenumberTextBox.dll` | Text-editor control |
| `GFFEditor.exe`, `nwnnsscomp.exe` | External GFF editor and NSS compiler |
| `Tools/7Zip/*` 26.01 | Generic `.7z`/RAR plugin package extraction |

Plugins are independent: DeNCS 1.0.2 and MDLOps 1.0.2. Their runtime payloads are installed separately and validated by the plugin installer.

Game/config dependencies include KEY/BIFF, RIM/ERF/MOD/SAV, GFF, 2DA, TLK, SSF, BWM, TPC/TGA/TXI, MDL/MDX, `settings.xml`, themes, plugin XML/INI and project XML. Verify provenance, license, bitness, clean output and deployed feature behavior when upgrading any dependency.
