# KoTOR Tool Restoration Project

> Treya engineering documentation starts at [`../project.md`](../project.md), including architecture, dependencies and per-directory heuristics.

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

The restored project is maintained as a VB.NET WinForms application targeting x86. Acceptance uses full Visual Studio MSBuild; SDK-style `dotnet build` is incompatible with the current legacy non-string WinForms resources.

See `Changelog.txt` for full release history and detailed patch notes.

## Treya source tree

`Classes` contains codecs plus image/model/plugin pipelines; `WinForms` contains the browser/editors. `Plugins` describes DeNCS and MDLOps, while `Tools/7Zip` supports generic `.7z` and RAR plugin package extraction. `Lib` and root helper binaries are checked-in dependencies. `ProjectManager.py` is a separate Tk `.vbproj` utility, not part of the executable.
