# KoTOR Tool

Rebuild and rebirth of the original **KoTOR Tool**, originally developed by Fred Tetra in 2005.

---

# KoTOR Tool Restoration Project

**Version:** v1.0.3.3

**Patch Date:** 05.05.26

**Project Status:** Restored source build

**Target IDE:** Visual Studio 2010/2022

**Target Framework:** .NET Framework 4.0

**Platform:** x86
**Language:** VB.NET

---

## Overview

This repository contains a restored and repaired source-code build of **Fred Tetra's KoTOR Tool**, rebuilt from a damaged and decompiled VB.NET codebase and repaired for modern development use.

This release represents a major turning point in the project — transitioning from raw source recovery into a structured, maintainable, and visually modernised toolchain.

---

# Current Release

## v1.0.3.3 — GUI Overhaul & Structural Stabilisation

This is the **first true foundation release** where the KoTOR Tool begins to resemble a fully restored application rather than a recovered codebase.

Focus areas for this patch:

* WinForms Designer recovery and stabilisation
* DarkSaber UI implementation
* Structural refactoring of legacy forms
* Elimination of decompiler artefacts
* Long-term maintainability groundwork

---

## Major Improvements

### UI System Overhaul (DarkSaber)

* Introduced the **DarkSaber theme** as the standard UI framework across restored forms
* Implemented consistent panel-based layouts:

  * `pnlRoot`
  * `pnlHeader`
  * `pnlBody`
  * `pnlFooter`
* Added gold-accented header separators and structured visual hierarchy
* Standardised fonts, colours, and spacing across forms
* Replaced legacy flat WinForms layouts with **professional, tool-grade UI structure**

---

### WinForms Designer Restoration

* Rebuilt large portions of Designer files from unstable decompiled output
* Fixed Designer-breaking issues including:

  * Invalid control declarations
  * Missing component containers
  * Broken initialization ordering
  * Corrupt property assignments
* Ensured forms now:

  * Open reliably in Visual Studio 2010
  * Render correctly without visual corruption
  * Maintain consistent layout behaviour

---

### Legacy Compatibility Preservation

* Maintained original control names and structure for source compatibility
* Preserved inherited base classes and legacy form behaviour
* Retained **AccessedThroughProperty-compatible patterns** where required
* Ensured all restored forms remain compatible with:

  * VS2010 CodeDom Designer
  * .NET Framework 2.0 runtime

---

### Event Binding Recovery (Critical)

* Restored missing event bindings from decompiled sources
* Reintroduced explicit `AddHandler` bindings where Designer wiring was lost
* Ensured UI controls remain functionally identical to the original tool

This is a **critical restoration step** — without this, many forms would appear correct but fail at runtime.

---

### Form Refactoring Standardisation

All restored forms now follow a consistent structure model:

* Root container-driven layout (Dock-based)
* Header with title + subtitle
* Body with padded content layout
* Footer with action controls
* Separator labels used as UI rules

This establishes a **repeatable template** for future form restoration.

---

### Designer Cleanup & Stability Fixes

* Removed duplicate or corrupt Designer-generated variables
* Fixed NumericUpDown initialization issues
* Corrected resource binding inconsistencies
* Eliminated invisible control layering issues caused by identical backcolors
* Reduced Designer re-serialization corruption risk

---

### Structural Codebase Improvements

* Cleaned and reorganised partial classes
* Repaired broken inheritance chains
* Reduced reliance on unsafe decompiler patterns
* Improved readability and maintainability of Designer code

---

## Designer Restoration Coverage

Completed major Designer restorations across multiple forms, including:

* frmAbout
* frmAppearanceWizard
* frmDialogEditor
* frmGlobalVar_Editor
* frmModule_Editor
* frmModuleItem_Base_Editor
* frmPackageTypeSelector
* frmSSFEditor
* frmUTM_Editor
* frmPathManager
* Progress meter and utility dialogs
* Additional legacy forms following the same repair pattern

---

## Result

Version **1.0.3.3** marks the transition from:

> “Recovered source code”
> → to →
> “Structured, maintainable development platform”

The tool is now:

* Stable inside Visual Studio 2010
* Consistent in UI structure
* Ready for feature expansion
* Suitable for long-term maintenance

This is the **true baseline** for future development.

---

## Additional Patch Highlights (May the 4th Release – 05.05.26)

This update also marks a celebratory milestone release aligned with the May the 4th event, bringing several major system-level upgrades beyond UI restoration.

### Plugin System Introduction

* Implemented a **new Plugin Manager System**
* Introduced a flexible **XML / INI-driven plugin framework**
* Enables external tooling and modular feature expansion
* Establishes groundwork for future third-party integrations

---

### NCS Decompilation Upgrade

* Replaced reliance on legacy **nwnsscomp.exe** for decompilation
* Integrated **OpenKOTOR DeNCS** as a third-party plugin backend
* Improved reliability and accuracy of script decompilation
* Decoupled core tool from outdated NWN toolchain dependencies

---

### Progress System Overhaul

* Implemented a **new global Progress Manager system**
* Progress reporting now available across multiple operations
* Updated UI feedback via restored progress meter system
* Improved usability during long-running tasks

---

### Byte Viewer Enhancements

* Upgraded Byte Viewer to display **extended byte-level information**
* Improved rendering clarity and usability
* Introduced new backend control for byte display

---

### Full Form Restoration Status

* All forms now either:

  * Fully restored
  * Upgraded to DarkSaber layout standard
  * Or preserved with stable legacy structure
* Remaining inconsistencies are limited to **missing legacy icon assets** (e.g. Module Editor)

---

### New Custom Controls

Introduced a suite of reusable custom UI controls:

* **CustomTabControl** — Styled tab system with full DarkSaber integration
* **CustomProgressBar** — Animated, themed progress display control
* **DarkByteViewerControl** *(pending rename to CustomByteViewerControl)* — Custom hex/byte rendering engine
* **CustomPictureBox** — Themed image container for consistent UI presentation

These controls form the foundation of the new UI system and will be reused across future updates.

---

## Known Limitations / Pending Work

### Updater System

* Automatic updater remains **disabled by design**
* Future implementation planned:

  * GitHub-based update delivery
  * Optional user-controlled updates
  * Packaged build distribution system

---

### Missing Icon Assets

* Some editor forms (notably Module Editor) are missing original icons
* Icons were lost during decompilation process
* Planned for restoration in next patch cycle

---

## Why This Matters

### A Brief History of Copyright (Why Restoration Matters Legally and Culturally)

Copyright did not begin as a permanent or near-permanent control over creative works.

It began as a **limited, balanced protection** between creator and public:

* **Statute of Anne (1710, Great Britain)** — the first modern copyright law

  * 14-year protection
  * Renewable once (maximum 28 years) if the author was still alive

* **U.S. Copyright Act (1790)** — mirrored the same structure

  * 14 years + optional 14-year renewal

The original intent was clear:

> Grant creators a temporary monopoly, then return the work to the public domain.

---

### Expansion Over Time

Over the centuries, copyright terms expanded significantly:

* 1814 (UK): Extended to 28 years or life of the author
* 1831 (US): Initial term increased to 28 years
* 1976 Copyright Act: Shifted to **life of the author + 50 years**
* 1998 Copyright Term Extension Act (CTEA): Extended to

  * **Life + 70 years** (individual works)
  * **95 years** (corporate works / works for hire)

---

### Corporate Influence and the “Mickey Mouse Effect”

The 1998 extension is widely associated with lobbying efforts by major corporations, most notably **The Walt Disney Company**.

* The act was informally dubbed the **“Mickey Mouse Protection Act”**
* It extended corporate copyright from 75 to 95 years
* It delayed the public domain release of *Steamboat Willie* (1928)

Despite these extensions:

* The original *Steamboat Willie* finally entered the public domain on **January 1, 2024**

---

### Why This Matters for KoTOR Tool

This historical shift has real consequences:

* Tools and software remain locked away far longer than originally intended
* Communities lose access to foundational infrastructure
* Preservation becomes legally and technically difficult

KoTOR Tool sits in that gap:

* Not actively maintained
* Not commercially supported
* Yet still essential to a living modding ecosystem

---

### The Core Argument

The original philosophy of copyright was **temporary stewardship — not permanent control**.

When software is abandoned for decades, the balance shifts:

* The creator is no longer maintaining it
* The community still depends on it

At that point, restoration becomes not just practical — but justified.

---

### A Personal Statement — LordVaderCW

Efforts were made to locate and contact **Fred Tetra**, the original author of KoTOR Tool, regarding the restoration and continuation of the project. These efforts were unsuccessful. No active presence, point of contact, or ongoing stewardship of the original tool could be established.

In the absence of the original maintainer, and given the **clear, long-term abandonment of the software and its codebase**, I, **LordVaderCW**, have taken it upon myself to continue the work.

This decision was not made lightly. It is grounded in:

* The demonstrable lack of maintenance or support over an extended period
* The continued reliance of the modding community on this tool
* The risk of permanent loss if no action was taken

Where a tool has been abandoned, yet remains essential, responsibility does not vanish — it transfers to those willing to preserve it.

This restoration is therefore both:

* A continuation of the original vision
* And a necessary act of preservation in the absence of its creator

---

### A Personal Statement — LordVaderCW

This project is more than a technical restoration — it is a statement of principle.

Abandoned software is, in practice, **abandoned property**.

When a tool is no longer maintained, supported, or distributed by its original creators, it does not cease to have value. Instead, it becomes dependent on the community that continues to rely on it. If that community does nothing, the software dies. If it steps in, the software lives.

This restoration exists because KoTOR Tool was too important to be left to decay.

---

### The Right to Repair — Applied to Software

The philosophy behind this work aligns directly with the **Right to Repair** movement.

Traditionally applied to hardware, the principle is simple:

> If you own it, you should be able to fix it.

That same logic applies to software:

* If a tool is essential, it should not become unusable due to neglect
* If source code is recoverable, it should be restorable
* If systems break, they should be repairable — not discarded

KoTOR Tool represents exactly this situation — a critical modding utility that was effectively lost due to time, tooling changes, and lack of maintenance.

This project restores that right.

---

### #StopKillingGames — Preservation of Digital Culture

There is also a broader issue at play.

The **#StopKillingGames** argument highlights a growing problem in the industry:

> Software, tools, and even entire games are being rendered unusable over time — not because they must be, but because they are abandoned.

Modding tools like KoTOR Tool are part of that ecosystem.

Without them:

* Modding communities collapse
* Knowledge disappears
* Digital history is lost

By restoring this tool, we are not just fixing software — we are preserving:

* A modding pipeline
* A community standard
* A piece of gaming history

---

### The Real Outcome

This project proves something important:

* Legacy software **can** be restored
* Decompiled code **can** be made maintainable
* Abandoned tools **do not have to die**

KoTOR Tool is no longer a relic.

It is now a **living platform**, ready for extension, improvement, and future development.

---

## Forward Direction

The next phases will focus on:

* Completing UI overhaul across all remaining forms
* Enhancing editor functionality (GFF, UTC, UTP, etc.)
* Improving tool responsiveness and usability
* Expanding modding capabilities while preserving legacy behaviour

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

---

# Licensing

See the attached `Licence.txt` for licensing terms.
