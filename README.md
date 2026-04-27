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
