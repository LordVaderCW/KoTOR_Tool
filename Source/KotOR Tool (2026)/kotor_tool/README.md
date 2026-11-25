# KoTOR Tool Restoration Project

Rebuild and rebirth of **KoTOR Tool**, originally developed by Fred Tetra in 2005.

**Current version:** v1.0.3.5a

**Patch date:** 25.11.26

**Target framework:** .NET Framework 4.6.2

**Platform:** x86

**Languages:** VB.NET, C# and JavaScript

## Overview

This project restores the original resource browser and editors for Knights of the Old Republic I and II. It preserves the original editing workflows while repairing the recovered source, improving the interface and adding model development tools.

Engineering documentation starts at [project.md](../project.md). Full release history is in [Changelog.txt](Changelog.txt).

## v1.0.3.5a Highlights

- **MDL Viewer:** textured model previews, smoothing groups, local and inherited animation clips, a key timeline, VFX previews and soundset browsing. Rotation starts paused. View controls sit below the viewport; glTF export sits below Send to 3DS Max.
- **3ds Max integration:** send models from the resource browser or MDL Viewer, with or without animations, through NWListen. NWListen and NWMax are included under the application's Tools folder. Dynamic transfer files use application-local working storage.
- **Model browsing:** K1 and K2 model categories, module-name labels and Maps grouped by location and level. Research-based labels distinguish uncertain, cut and restored content; unresolved areas remain identified as such.
- **Preview repairs:** duplicate model-node names receive unique preview identities. Extreme UV coordinates that prevented some Korriban and other area models from loading use a documented fallback. Unsupported data remains subject to viewer limitations.
- **Portable WebView2 packaging:** the English-only engine ships as a single `webview2.cab` of approximately 204 MiB. First use extracts it into the application's `AppData/WebView2Runtime` folder; later launches reuse it. Browser profile data also stays application-local.
- **Maintenance:** fixed the 187 reported compiler warnings and guarded missing clipboard data in the 2DA editor. Full-framework Release/x86 rebuilds with zero errors and warnings.

## Build and Deployment

Use full Visual Studio MSBuild, targeting x86 and .NET Framework 4.6.2. SDK-style `dotnet build` does not support the project's legacy non-string WinForms resource pipeline.

Release builds omit debug symbols and remove stale/copied PDB/MDB files from the output. Debug builds retain their debugging symbols.

Provision the fixed runtime source as described in the [MDL Viewer guide](../ModelPreview/README.md). The build creates and copies `webview2.cab`; the SDK assemblies and native loader remain beside the application to bootstrap WebView2. Distribute the complete application output, including the CAB, tools and required dependencies.

WebView2 cannot run directly from the cabinet. The application directory must be writable for first-use extraction and browser profile storage. The extracted engine occupies approximately 416 MiB in addition to the CAB. Runtime upgrades use separate cache directories; remove old versions only after closing all KotOR Tool processes.

The English-only package retains British and US English resources. Copilot assets, Widevine DRM and the PDF shell preview handler are omitted. The reduced runtime is application-tested; it is not a Microsoft-supported minimal-runtime package. Windows 10-specific runtime permissions still require deployment validation on Windows 10.

Validation for this patch includes copied K1/K2 model rendering and playback, viewer replacement/lifecycle checks, CAB extraction failure/concurrency/reuse checks, resource regression checks and 60 model-conversion checks. These checks do not establish exact in-game rendering for every model or effect.

## Source-tree Guide

- [Classes](Classes/README.md): format readers, writers, metadata, settings and shared models.
- [WinForms](WinForms/README.md): the resource browser, editors and supporting windows.
- [ModelPreview](../ModelPreview/README.md): the MDL Viewer, conversion pipeline and WebView2 packaging.
- [3DSMax tools](Tools/3DSMax/README.md): NWListen and NWMax integration.
- [Plugins](Plugins/README.md): external-tool descriptors and installation support.
- [My Project](My%20Project/README.md): application identity, resources and manifest.

## Previous Releases

Version **1.0.3.5** introduced batch texture conversion, batch JPG/PNG export and TGA export repairs. Version **1.0.3.4** stabilised Sound Editor playback and cleanup. Version **1.0.3.3** established the restored UI, designer and plugin foundation. See the changelog for the historical notes.
