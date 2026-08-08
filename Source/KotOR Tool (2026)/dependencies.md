# Dependencies

## Framework and system assemblies

The VB project targets .NET Framework 4.6.2 and references `Microsoft.VisualBasic`, `System`, `System.Data`, `System.Design`, `System.Drawing`, `System.IO.Compression`, `System.IO.Compression.FileSystem`, `System.Management`, `System.Windows.Forms` and `System.Xml`. There is no NuGet/package restore graph.

The main `app.config` asks for CLR v4 first and enables `useLegacyV2RuntimeActivationPolicy`, which helps older mixed/runtime dependencies load in the CLR 4 process.

## Checked-in managed libraries

| File | Role | Observed metadata |
| --- | --- | --- |
| `Lib/FMODCL.dll` | Managed FMOD wrapper used by the UTS sound editor | File version `1.0.2118.32981` |
| `Lib/ImageTools.dll` | Legacy image conversion/handling support | No useful version metadata |
| `Lib/RTFLinenumberTextBox.dll` | `mystuff.Controls.LinenumberTextBox` used by the text editor | File version `1.0.20053.1` |

These are file references, not package references. Renaming or relocating them breaks compilation.

## Native/runtime binaries

| File | Role | Constraint |
| --- | --- | --- |
| root `fmodex.dll` | Deployed FMOD Ex audio engine | Version 4.1.5; keep x86 compatibility with `Lib/FMODCL.dll` |
| `Lib/fmodex.dll` | Legacy/source copy of the native FMOD engine | Avoid version drift with the root deployed copy |
| `GFFEditor.exe` | External generic GFF editor launched by `frmMain` | Must be beside the application |
| `nwnnsscomp.exe` | Legacy NSS compiler used by text/project workflows | Must be beside the application; distinct from DeNCS tools |

## Plugin dependency

The DeNCS manifest registers `.ncs` + `decompile`. A complete runtime installation also needs `NCSDecompCLI.exe`, KoTOR I/TSL `nwscript` files and two compiler helpers under `Plugins/DeNCS/tools`. Those payload files are not present in this source snapshot, so the manifest is present but runtime validation will report the plugin incomplete.

## Game-data dependencies

- `chitin.key` is the index into BIFF resources.
- `data/*.bif` holds bulk resources; `templates.bif`, 2DA, scripts, models, textures and sounds are accessed by different features.
- `dialog.tlk` resolves StrRefs, display strings, sound ResRefs and sound lengths.
- RIM, ERF, MOD and SAV archives provide module/save resources.
- `Override` may take precedence when the corresponding user option is enabled.
- `K1TemplateTags.bfd` and `MapInfo.bfd` are copied runtime data used by template/map workflows.

## Configuration and persistence

- `settings.xml`: XML-serialized `Options`; loaded/saved beside the application, with a legacy-path migration path.
- `Themes/*.ini` and generated `Themes/ActiveTheme.txt`: appearance configuration.
- `Plugins/*.xml`, each `plugin.xml`, and `command.ini`: plugin catalog, installation and execution contract.
- `project settings.xml`: XML-serialized module-editor options within a project path.
- KoTOR Tool project files: XML-serialized `clsProject` data managed by `clsProjectManager`.

## Dependency-change checklist

1. Verify bitness and CLR compatibility.
2. Update the `.vbproj` `Reference`, `Content` and copy metadata.
3. Verify clean Debug and Release x86 outputs, not only an incremental build.
4. Exercise the feature that loads the dependency from the deployed output directory.
5. Record licensing, provenance, hashes/version and upgrade notes before replacing opaque binaries.
