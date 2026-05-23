# KoTOR Tool Restoration Project

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

The restored project is maintained as a VB.NET WinForms application targeting x86. The source has been verified with modern MSBuild while preserving compatibility expectations for the restored Visual Studio project format.

See `Changelog.txt` for full release history and detailed patch notes.
