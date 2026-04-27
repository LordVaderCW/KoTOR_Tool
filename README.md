# KoTOR_Tool
Rebuild and Rebirth of the KoTOR Tool originally developed by Fred Tetra back 2005. 

# Kotor Tool Restoration Project

**Version:** v1.0.23  
**Patch Date:** 27.04.26  
**Project Status:** Restored source build confirmed  
**Target IDE:** Visual Studio 2010  
**Target Framework:** .NET Framework 2.0  
**Platform:** x86  
**Language:** VB.NET  

---

## Overview

This repository contains a restored and repaired source-code build of **Fred Tetra’s Kotor Tool**, rebuilt from a damaged/decompiled VB.NET codebase and repaired for modern development use.

The purpose of this project is to preserve, restore, and modernise the original Kotor Tool so that it can continue serving the *Knights of the Old Republic* modding community on newer Windows systems.

This is not a rewrite from scratch. It is a restoration project focused on preserving the original tool’s behaviour while repairing broken decompiler output, restoring missing resources, improving portability, and preparing the codebase for future maintenance.

---

## Current Release

### v1.0.23 — First Restoration Patch

This patch represents the first successful source-restored build of Kotor Tool.

The application now:

- Builds successfully in Visual Studio 2010.
- Launches from the restored VB.NET source.
- Loads embedded WinForms resources.
- Uses a portable `settings.xml` location beside the executable.
- Avoids dead legacy auto-update calls during startup.
- Supports improved KotOR I / KotOR II path detection.
- Handles both old-style registry installs and Steam installs.
- Preserves original legacy behaviour where practical.

---

## Major Restoration Work Completed

### Source Repair

The decompiled source contained invalid VB.NET output that required manual repair.

Fixed issues include:

- Invalid module declaration in `KT_Launch.vb`.
- Broken startup entry point.
- Invalid object initializer syntax.
- Invalid `GoTo` jumps into `Try/Catch` blocks.
- Variable shadowing errors.
- Broken property accessor calls.
- Missing or incorrectly decompiled indexed property usage.
- Incorrect `Process.StartInfo` initialisation.
- Broken form editor construction syntax.
- Broken `With` initialisers that did not survive decompilation cleanly.
- Incorrect SSF indexed accessor calls.
- Invalid `set_Bearing` / `get_Bearing` calls replaced with proper indexed property syntax.
- Invalid `NotInheritable Module` declaration corrected.
- Broken `Explorer.exe` process launch blocks repaired.

---

### Resource Restoration

The original decompiled project had `.resources` files sitting beside form source files but not properly embedded into the project file.

The `.vbproj` has now been updated to embed the restored form resources, including major forms such as:

- `frmMain`
- `frmModule_Editor`
- `frmModuleItem_Base_Editor`
- `frmSSFEditor`
- `frmUTC_Editor`
- `frmUTD_Editor`
- `frmUTI_Editor`
- `frmUTM_Editor`
- `frmUTP_Editor`
- `frmUTS_Editor`
- `frmUTT_Editor`
- `frmUTW_Editor`

This allows the application interface and editor forms to load correctly at runtime.

---

### Settings System Patch

The original Kotor Tool expected its configuration to be located through the registry path:

```text
HKLM\software\SCM\Kotor Tool
```

For restored and portable builds, this is fragile.

The `UserSettings.vb` logic has been updated so that the application can use:

```text
settings.xml
```

from the executable directory.

The original registry-based behaviour has been preserved as a fallback where needed.

This improves portability and allows the restored build to run more cleanly from its own application folder.

---

### Auto-Updater Patch

The original Kotor Tool attempted to contact an old Comcast-hosted update endpoint:

```text
http://kotortool.home.comcast.net/
```

This endpoint is no longer reliable and can cause failed startup behaviour.

For v1.0.23:

- Automatic startup update checks have been disabled.
- Manual update-check logic is preserved for future restoration.
- The updater can later be repointed to a modern endpoint if desired.
- No legacy update call should block startup.
- The XML setting can still preserve update configuration for future use.

---

### Automatic Game Detection Patch

The original auto-detect system primarily relied on legacy registry entries.

v1.0.23 improves detection support for:

- Original retail-style installs.
- Registry-detected installs.
- Steam installs.
- Steam libraries on non-default drives.
- Steam libraries moved to custom folders.

The Path Manager auto-detect system has been prepared to better locate:

- `Knights of the Old Republic`
- `Knights of the Old Republic II: The Sith Lords`

This is important because Steam can be installed on any drive, and Steam libraries can be moved to custom locations. The detection patch therefore avoids relying only on `C:\Program Files (x86)\Steam`.

---

## Build Requirements

Recommended environment:

```text
Visual Studio 2010
.NET Framework 2.0 Targeting Pack
Windows x86 build target
```

Required references are expected under the local `Lib` folder:

```text
Lib\FMODCL.dll
Lib\ImageTools.dll
Lib\RTFLinenumberTextBox.dll
```

The project is configured as:

```text
OutputType: WinExe
TargetFrameworkVersion: v2.0
PlatformTarget: x86
StartupObject: kotor_tool.KT_Launch
```

---

## Building

Open the project file:

```text
kotor_tool.vbproj
```

Then build using:

```text
Debug | x86
```

or:

```text
Release | x86
```

Successful output should generate:

```text
bin\x86\Debug\kotor_tool.exe
```

or:

```text
bin\x86\Release\kotor_tool.exe
```

---

## Runtime Files

The application may expect several helper files or folders beside the executable, depending on which feature is used.

Examples include:

```text
settings.xml
maps\
working\
gffeditor.exe
mdlops.exe
nwnnsscomp.exe
KT_Help.chm
```

Some helper tools are legacy dependencies and may require future cleanup or replacement.

---

## Known Issues

The project currently builds, but the restored decompiled source still produces many warnings.

Common warning types include:

- Variables used before assignment.
- CLS-compliance warnings.
- Shared member access through an instance.
- Legacy Visual Basic compatibility warnings.

These warnings do not currently prevent the application from compiling, but some may represent real runtime edge cases.

Future patches should prioritise the highest-risk warnings in:

- `frmMain.vb`
- `frmModule_Editor.vb`
- `frmSSFEditor.vb`
- `clsGFF.vb`
- `clsDLG.vb`
- `cls2DA.vb`

---

## v1.0.23 Changelog

**Date:** 27.04.26

### Added

- Portable `settings.xml` support beside the application executable.
- Improved auto-detection for Steam-based KotOR installations.
- More robust support for Steam libraries on custom drives or folders.
- Embedded `.resources` entries restored in the Visual Studio project file.

### Changed

- Startup settings now favour the application directory instead of requiring the original registry path.
- Auto-update behaviour is disabled at startup while preserving the old update code for later reactivation.
- Path Manager detection logic now supports both old-style installs and Steam installs.
- Decompiled VB.NET syntax has been normalised into buildable Visual Studio 2010-compatible code.

### Fixed

- Broken VB.NET module declaration in `KT_Launch.vb`.
- Broken startup object configuration.
- Broken form/resource loading caused by missing embedded resource declarations.
- Invalid decompiler-generated object initialisers.
- Invalid `GoTo` labels inside `Try/Catch` blocks.
- Shadowed local variables that prevented compilation.
- Broken indexed property accessors such as SSF reference arrays.
- Broken Bearing property calls in module item editor logic.
- Broken process launch syntax for opening folders and scripts.
- Missing or invalid form editor construction in several restored sections.

---

## Preservation Notice

This project exists for preservation, compatibility, education, and modding support.

The goal is to keep an important *Knights of the Old Republic* modding utility alive for modern systems while respecting the original tool’s structure and purpose.

---

## Credits

Original Kotor Tool created by:

```text
Fred Tetra
```

Restoration, source repair, project rebuild, and modern compatibility patching:

```text
LordVaderCW
```


---

## Disclaimer

This is an unofficial restoration project.

It is not affiliated with BioWare, Obsidian Entertainment, LucasArts, Disney, Aspyr, Steam, or any other rights holder.

All Star Wars and Knights of the Old Republic names, assets, and trademarks remain the property of their respective owners.

This repository is intended only for lawful modding, archival, educational, and preservation purposes.

---

## License

A formal license should be added before public distribution.

Until then, treat this repository as a restoration and preservation work-in-progress.

```text
HKLM\software\SCM\Kotor Tool
