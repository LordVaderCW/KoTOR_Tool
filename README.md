# KoTOR Tool Restoration Project

Rebuild and rebirth of the original **KoTOR Tool**, originally developed by **Fred Tetra** in 2005.

This repository contains the restored, repaired, and actively modernised source-code build of KoTOR Tool for the *Star Wars: Knights of the Old Republic* modding community.

---

## Current Release

>**Version:** v1.0.3.5
>
>**Patch date:** 25.10.26
>
>**Project status:** Active restoration / modernisation
>
>**Target IDE:** Visual Studio 2022
>
>**Target framework:** .NET Framework 4.6.2 or later
>
>**Platform:** x86
>
>**Language:** VB.NET WinForms

---

## Overview

The KoTOR Tool Restoration Project is focused on preserving the original behaviour of Fred Tetra's KoTOR Tool while repairing the recovered source tree, stabilising the WinForms application, modernising the interface, and preparing the project for long-term maintenance.

The project began from a damaged and decompiled VB.NET codebase. It has since been rebuilt into a maintainable Visual Studio solution with restored forms, repaired designer files, upgraded UI systems, plugin support, and modern build compatibility.

The restoration goal is simple:

> Preserve the original KoTOR Tool workflow, repair what was broken, and make the tool viable for modern development again.

---

## Branch Notes

### Treya Branch

The **Treya** branch is reserved for AI-agent-assisted development work.

This branch exists so tools such as Codex can safely inspect, edit, refactor, and test project changes without risking direct damage to the main working branch.

Use Treya for:

* AI-assisted patches
* experimental refactors
* controlled feature work
* staged code repair
* pre-merge validation

Mainline releases should only be updated after changes have been reviewed and confirmed stable.

---

## v1.0.3.4 Highlights

### Sound Editor Stabilisation

* Fixed Sound Editor preview playback for level sound objects whose RIFF/WAVE metadata previously triggered UTF-8 decoding errors.
* Reworked sound metadata parsing so RIFF FourCC identifiers are read as raw ASCII bytes instead of text-decoded payload data.
* Added safer handling for unknown RIFF chunks during sound parsing.
* Preserved existing KoTOR WAVE and embedded MPEG offset handling for FMOD playback.
* Stabilised FMOD cleanup so closing, cancelling, or completing preview playback no longer double-releases completed sound handles.

### Modern Build Baseline

* Updated active development target to **Visual Studio 2022**.
* Updated framework target to **.NET Framework 4.6.2+**.
* Continued x86 targeting for compatibility with legacy dependencies and original KoTOR Tool behaviour.
* Maintained VB.NET WinForms architecture.

---

## v1.0.3.3 Foundation Release

Version **v1.0.3.3** established the restored application baseline.

Major work included:

* DarkSaber UI implementation across restored forms.
* WinForms Designer recovery and stabilisation.
* Structural refactoring of legacy forms.
* Theme system groundwork and restored visual consistency.
* Plugin framework introduction.
* DeNCS external-tool plugin support.
* Progress Manager and progress meter improvements.
* Byte Viewer upgrades.
* Custom reusable UI controls.
* Long-term maintainability groundwork.

This was the first release where the project moved from recovered source code into a structured restoration platform.

---

## UI and Theme System

The restored UI uses the project theme system, with **DarkSaber** as the core restoration theme.

Current UI restoration standards include:

* Dock-based WinForms layouts.
* Restored header, body, and footer panel structures.
* Theme-aware colours and control styling.
* Preserved legacy control names for source compatibility.
* Preserved event bindings recovered from decompiled `AccessedThroughProperty` patterns.
* Designer-safe fallback colours for stable editing inside Visual Studio.

Reusable custom controls introduced during restoration include:

* `CustomTabControl`
* `CustomProgressBar`
* `DarkByteViewerControl`
* `CustomPictureBox`

---

## Plugin System

KoTOR Tool now includes an XML / INI driven plugin framework for external tool integration.

The first supported plugin profile is **DeNCS**, used for NCS script decompilation through:

```text
NCSDecompCLI.exe
```

Expected DeNCS plugin layout:

```text
Plugins/
    DeNCS/
        plugin.xml
        command.ini
        NCSDecompCLI.exe
        tools/*
        runtime/*
        config/*
        app/*
```

Plugin library files:

```text
AvailablePlugins.xml
InstalledPlugins.xml
```

These define which plugins are available, installed, enabled, and visible to the Plugin Manager.

---

## Build Requirements

Recommended development environment:

```text
Visual Studio 2022
.NET Framework 4.6.2 or later
Windows x86 build target
VB.NET WinForms workload
```

Required legacy references are expected under the local `Lib` folder:

```text
Lib\FMODCL.dll
Lib\ImageTools.dll
Lib\RTFLinenumberTextBox.dll
```

The application should continue to build as an x86 WinForms application due to legacy dependency expectations.

---

## Known Limitations

### Updater System

The automatic updater remains disabled by design.

A future updater may use:

* GitHub-based release delivery
* user-controlled update checks
* packaged build distribution
* safe rollback behaviour

### Missing Legacy Assets

Some original icon assets were lost during source recovery and decompilation.

Known affected areas include some editor forms, notably parts of the Module Editor UI.

### Legacy Dependency Constraints

Some original dependencies remain part of the restored project for compatibility. These should be replaced carefully and only where behaviour can be verified against the original tool.

---

## Project Direction

Upcoming work is focused on:

* completing form restoration and theme integration
* improving editor usability
* expanding plugin support
* strengthening archive and resource handling
* improving responsiveness during long-running operations
* preserving original behaviour while removing unstable decompiler artefacts

The long-term goal is to turn KoTOR Tool into a stable, maintainable, modern restoration of the original utility without breaking the workflows that made it valuable.

---

## Preservation Notice

This project exists for preservation, compatibility, education, and modding support.

KoTOR Tool remains an important part of the *Knights of the Old Republic* modding ecosystem. This restoration keeps that tool usable for modern systems while respecting the structure and purpose of the original application.

---

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


## Credits

### Original KoTOR Tool

**Fred Tetra**

### Restoration, Source Repair, Project Rebuild, and Modern Compatibility

**LordVaderCW**

---

## Disclaimer

This is an unofficial restoration project.

It is not affiliated with BioWare, Obsidian Entertainment, LucasArts, Disney, Aspyr, Steam, or any other rights holder.

All Star Wars and Knights of the Old Republic names, assets, and trademarks remain the property of their respective owners.

---

## Licensing

See `Licence.txt` for licensing terms.

---

## Changelog

See `Changelog.txt` for the full release history and detailed patch notes.

## Legal Status & Defense of Interoperability

This repository ("Rebuild and Rebirth of the KoTOR Tool") serves as a completely rewritten, modernized, and open-source utility platform. Because the original utility (created by Fred Tetra in 2005) was permanently abandoned in a closed-source compiled state, and because game file specifications remain hidden within a proprietary file structure, this project operates under established statutory and judicial protections for software preservation and interoperability.

Third-party claims regarding unverified "denials of permission" or standard End User License Agreements (EULAs) trying to forbid decompilation or reverse engineering are superseded by federal copyright exceptions. 

The legal architecture protecting this repository rests upon the following core federal precedents:

### 1. The Right to Intermediate Reverse Engineering for Interoperability
Under United States copyright law, decompiling a closed-source binary is protected as **Fair Use** if it is the only viable technological pathway to access non-copyrightable, functional data formats required to achieve compatibility with an external program.

* **Sega Enterprises Ltd. v. Accolade, Inc., 977 F.2d 1510 (9th Cir. 1992)**
  * **The Ruling:** The Ninth Circuit Court of Appeals ruled that disassembly or intermediate copying of copyrighted object code is a protected fair use under 17 U.S.C. § 107 when it is necessary to isolate the non-copyrightable, functional specifications required to make an independent program compatible. The court explicitly held that copyright cannot be used to gain a de facto monopoly over the purely functional interface elements of software.
  * **Application:** Because the original software was abandoned in a closed, compiled `.exe` bottleneck that broke on modern operating systems, intermediate extraction of the file-parsing, registry-mapping, and directory-unpacking schemas was the *only* way to engineer a working utility for modern computing environments.

### 2. Freedom of Alternative Implementation and Platform Emulation
Copyright protects the original *expressive* elements of a software package (story, music, art), but it cannot be weaponized to prevent external developers from creating updated platforms that handle the same files.

* **Sony Computer Entertainment, Inc. v. Connectix Corp., 203 F.3d 596 (9th Cir. 2000)**
  * **The Ruling:** Building upon the *Sega* precedent, the court ruled that Connectix’s reverse engineering of the Sony PlayStation BIOS to create a functional software emulator was protected fair use. The court rejected the claim that standard license restrictions could freeze out third-party developers, stating that a copyright holder does not possess the exclusive right to monopolize the functional environments where their data runs.
  * **Application:** This tool does not ship with, redistribute, or pirate the protected expressive assets of *Star Wars: Knights of the Old Republic*. It provides an independent functional lens through which users can access legally purchased game files on modern machines. Contractual EULA bans attempting to bar reverse engineering are legally overridden by this federal precedent.

### 3. Absolute Lack of Commercial Harm
The foundational pillar of the Fair Use doctrine (17 U.S.C. § 107(4)) evaluates the effect of the use upon the potential market value of the copyrighted work.

* **The Reality:** 
  1. **Fred Tetra’s Original Tool:** Has spent roughly two decades pulled from commercial channels, has a commercial market value of zero, and features an absent owner. No market damage can be inflicted upon a non-existent marketplace.
  2. **The Game Ecosystem:** By modernizing these archival modding workflows, this repository directly encourages continued consumer engagement and sales of the game on current digital platforms (Steam, GOG).

### 4. Rebuttal to Hearsay Restrictions & Equitable Estoppel
Unsubstantiated, undocumented third-party claims that a missing author privately "reiterated a denial of permission" hold zero legal or evidentiary weight. Under the doctrine of **Equitable Estoppel by Silence**, an IP owner who abandons a product publicly, shuts down their communications, and permits third-party repositories to host their tool for decades cannot suddenly utilize hearsay proxies to strike down community-led preservation.

Furthermore, copyright law protects functional utility, not a developer's "wishes." When software enters a state of de facto abandonment, the community acts as a custodian of necessity. By shifting this architecture into an open, collaborative GitHub repository, we guarantee the toolset can never be locked down or orphaned by a single point of failure again.

