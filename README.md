# KoTOR Tool

Rebuild and rebirth of the original **KoTOR Tool**, originally developed by Fred Tetra in 2005.

---

# KoTOR Tool Restoration Project

**Version:** v1.0.3.3
**Patch Date:** 29.04.26
**Project Status:** Restored source build confirmed
**Target IDE:** Visual Studio 2010
**Target Framework:** .NET Framework 2.0
**Platform:** x86
**Language:** VB.NET

---

## Overview

This repository contains a restored and repaired source-code build of **Fred Tetra's KoTOR Tool**, rebuilt from a damaged and decompiled VB.NET codebase and repaired for modern development use.

The purpose of this project is to preserve, restore, and modernise the original KoTOR Tool so that it can continue serving the *Knights of the Old Republic* modding community on newer Windows systems.

This is **not** a rewrite from scratch. It is a restoration project focused on preserving the original tool's behaviour while repairing broken decompiler output, restoring missing resources, improving portability, and preparing the codebase for future long-term maintenance.

---

# Current Release

## v1.0.3.3 — GUI Overhaul Patch

Improved User Interface — this is **not fully complete yet**.

This release focused heavily on:

* Structural restoration
* WinForms Designer recovery
* UI modernisation
* Portability fixes
* Internal project cleanup

The goal was to stabilise the legacy Fred Tetra codebase for modern development under Visual Studio 2010.

Major UI improvements are ongoing and will continue in future updates.
Please check the forum page for visual comparisons and screenshots of the interface changes.

---

## Core Restoration Work

* Successfully reverse engineered major portions of the original KoTOR Tool back into editable Visual Studio 2010 source form
* Restored large sections of legacy VB.NET WinForms Designer files from decompiled output
* Rebuilt damaged partial classes and corrected missing Designer field declarations
* Preserved original source compatibility by retaining legacy control names, inherited base classes, and existing form behaviour
* Maintained strict VS2010 / .NET Framework 2.0 compatibility across restored forms
* Established the new **DarkSaber** restoration theme as the standard visual language for the tool

---

## Designer File Restoration

Completed major Designer-only restorations for multiple legacy forms, including:

* `frmAbout`
* `frmAppearanceWizard`
* `frmDialogEditor`
* `frmGlobalVar_Editor`
* `frmModule_Editor`
* `frmPackageTypeSelector`
* `frmSSFEditor`
* `frmUTM_Editor`
* `frmPathManager`
* and many others

---

## Result

Version **1.0.3.3** represents the first serious structural restoration milestone where KoTOR Tool has transitioned from fragmented decompiled legacy code into a maintainable, modern-restorable Visual Studio project ready for long-term continuation.

This is effectively the **foundation release** for full restoration.

---

# Previous Release

## v1.0.3.1 — Source Recovery Milestone

This update focused on restoring and stabilising the original KOTOR Tool source code after decompilation, with particular attention to WinForms Designer compatibility and safe recovery of the VB.NET project structure.

### Core Source Repair Fixes

* Restored multiple decompiled WinForms forms so they now open correctly in the Visual Studio 2010 Designer
* Repaired forms where decompiled `AccessedThroughProperty` wrappers prevented proper Designer loading
* Converted recovered control wrappers back into proper `Friend WithEvents` Designer declarations
* Moved Designer control declarations into the correct `.Designer.vb` files
* Preserved original event bindings by restoring them as explicit `AddHandler` calls inside `InitializeComponent`
* Removed obsolete private backing fields such as `_Button1`, `_Panel1`, `_MenuItem1`, etc.
* Fixed forms that previously produced Designer errors such as "undeclared or never assigned"

### WinForms Designer Compatibility

* Fixed duplicate temporary-variable issues inside `InitializeComponent`
* Repaired `NumericUpDown` decimal assignments that caused Designer failures
* Fixed panel/control initialization order problems
* Repaired component-container handling for controls such as `ToolTip`
* Improved Designer-safe layout generation for recovered forms
* Reduced malformed decompiler output that confused the old VS2010 CodeDom Designer

### Forms Repaired During This Pass

* `frmBWMEditor`
* `frmCreateAnimListEntry`
* `frmDialogEditor`
* `frmDialogTlk`
* Additional affected forms tested and confirmed working where the same repair pattern applied

This was not a feature expansion patch — it was a maintainability and source recovery milestone.

---

# Previous Release

## v1.0.23 — First Restoration Patch

This patch represents the first successful source-restored build of KoTOR Tool.

The application now:

* Builds successfully in Visual Studio 2010
* Launches from the restored VB.NET source
* Loads embedded WinForms resources
* Uses a portable `settings.xml` location beside the executable
* Avoids dead legacy auto-update calls during startup
* Supports improved KotOR I / KotOR II path detection
* Handles both old-style registry installs and Steam installs
* Preserves original legacy behaviour where practical

---

# Build Requirements

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

Project configuration:

```text
OutputType: WinExe
TargetFrameworkVersion: v2.0
PlatformTarget: x86
StartupObject: kotor_tool.KT_Launch
```

---

# Runtime Files

The application may expect helper files or folders beside the executable:

```text
settings.xml
maps
working
gffeditor.exe
mdlops.exe
nwnnsscomp.exe
KT_Help.chm
```

---

# Preservation Notice

This project exists for preservation, compatibility, education, and modding support.

The goal is to keep an important *Knights of the Old Republic* modding utility alive for modern systems while respecting the original tool's structure and purpose.

---

# Credits

## Original KoTOR Tool

**Fred Tetra**

## Restoration, Source Repair, Project Rebuild, and Modern Compatibility

**LordVaderCW**

---

# Disclaimer

This is an unofficial restoration project.

It is not affiliated with BioWare, Obsidian Entertainment, LucasArts, Disney, Aspyr, Steam, or any other rights holder.

All Star Wars and Knights of the Old Republic names, assets, and trademarks remain the property of their respective owners.

This repository is intended only for lawful modding, archival, educational, and preservation purposes.

---

# Licensing

See the attached `Licence.txt` for licensing terms.
