# KoTOR Tool Restoration Project

Rebuild and rebirth of the original **KoTOR Tool**, originally developed by **Fred Tetra** in 2005.

This repository contains the restored, repaired, and actively modernised source-code build of KoTOR Tool for the *Star Wars: Knights of the Old Republic* modding community.

---

## Current Release

**Version:** v1.0.3.4
**Patch date:** 10.05.26
**Project status:** Active restoration / modernisation
**Target IDE:** Visual Studio 2022
**Target framework:** .NET Framework 4.6.2 or later
**Platform:** x86
**Language:** VB.NET WinForms

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
