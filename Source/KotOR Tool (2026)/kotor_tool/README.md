# KoTOR Tool Restoration Project

> Engineering documentation starts at [`../project.md`](../project.md), including architecture, build requirements, dependency boundaries, language guides and per-directory operating heuristics.

Rebuild and rebirth of the original **KoTOR Tool**, originally developed by Fred Tetra in 2005.

**Current version:** v1.0.3.4  
**Patch date:** 10.05.26  
**Target IDE:** Visual Studio 2010  
**Target framework:** .NET Framework 4.6.2  
**Platform:** x86  
**Language:** VB.NET

## Overview

This repository contains a restored and repaired source-code build of **Fred Tetra's KoTOR Tool**, rebuilt from a damaged and decompiled VB.NET codebase and repaired for modern development use.

The restoration project focuses on preserving original KoTOR Tool behaviour while repairing the source tree, stabilising WinForms Designer support, modernising the interface, and making the application maintainable again.

## v1.0.3.4 Highlights

* Fixed Sound Editor preview playback for level sound objects whose RIFF/WAVE metadata previously triggered UTF-8 decoding errors.
* Reworked sound metadata parsing to read RIFF FourCC identifiers as raw ASCII bytes and skip unknown chunks safely.
* Stabilised FMOD cleanup so closing or cancelling the Sound Editor after playback no longer double-releases completed sounds.
* Preserved existing KoTOR WAVE and embedded MPEG offset handling for FMOD playback.

## Previous Foundation Release

Version **v1.0.3.3** established the restored application baseline, including:

* DarkSaber UI implementation
* WinForms Designer recovery and stabilisation
* Structural refactoring of legacy forms
* Plugin framework groundwork, including DeNCS external-tool support
* Long-term maintainability groundwork

## Build Notes

The restored project is maintained as a VB.NET WinForms application targeting x86. The acceptance build uses full Visual Studio MSBuild; `dotnet build` is not compatible with the legacy non-string WinForms resource pipeline in its present form.

See `Changelog.txt` for full release history and detailed patch notes.

## Source-tree guide

- `Classes/` contains format readers/writers, settings, plugins, themes and shared models; see [`Classes/README.md`](Classes/README.md).
- `WinForms/` contains the main resource browser and all editor/support forms; see [`WinForms/README.md`](WinForms/README.md).
- `CustomControls/` and `Themes/` implement the restored themed interface.
- `Lib/`, root DLLs and helper EXEs are checked-in runtime/build dependencies.
- `Plugins/` contains plugin catalogs and descriptors; the DeNCS binary payload is installed separately and is not complete in this source snapshot.
- `My Project/`, `app.config` and `kotor_tool.vbproj` define the VB assembly/build contract.
- `ProjectManager.py` is a separate Tk-based `.vbproj` organization/repair utility. It creates backups on save and is not part of the KoTOR Tool executable.
