# Core Classes

This directory contains parsers, persistence models, resource-tree data and shared UI infrastructure. The classes are organized by recovered subsystem rather than by strict architectural layer; several depend directly on `frmMain` or WinForms.

## Resource and format layers

- [Security](Security/README.md) reads `chitin.key`, which maps names/types to BIFF IDs.
- [BIFFSystem](BIFFSystem/README.md), [RIMSystem](RIMSystem/README.md) and [ERFSystem](ERFSystem/README.md) expose archived bytes.
- [GFFSystem](GFFSystem/README.md) is the structured-data core used by [DLGSystem](DLGSystem/README.md), globals and every `UT*System`.
- [2DASystem](2DASystem/README.md), [BWMSystem](BWMSystem/README.md), [MAPSystem](MAPSystem/README.md), [SoundSystem](SoundSystem/README.md) and [NCSSystem](NCSSystem/README.md) cover specialized formats/workflows.

## Application layers

- [GlobalSystem](GlobalSystem/README.md) owns startup, settings and global helpers.
- [ItemSystem](ItemSystem/README.md), [FilterSystem](FilterSystem/README.md), [AnimSystem](AnimSystem/README.md) and [StandardUI](StandardUI/README.md) supply editor/tree models.
- [ProjectSystem](ProjectSystem/README.md) and [UtilitySystem](UtilitySystem/README.md) persist restoration/module projects.
- [PluginSystem](PluginSystem/README.md) discovers, validates, installs and executes external tools; [Shared](Shared/README.md) contains cross-subsystem event data.
- [ThemeSystem](ThemeSystem/README.md) loads and applies the INI-driven UI theme.

## Coupling heuristic

Do not assume a class is a pure library because it is under `Classes`. `clsGFF`, `clsNCS`, theme classes, utility helpers and many models reference forms/controls or static state on `frmMain`. Extract those dependencies behind explicit interfaces before attempting reuse in tests or another language.
