# Global System

This directory owns application startup and process-wide state.

- `KT_Launch` is the STA entry point. It enables visual styles, installs UI/domain exception handlers and global theme hooks, then runs `frmMain`.
- `Options` is the XML-serializable settings model for paths, extraction behavior, recent files/tree state and form geometry.
- `UserSettings` loads/saves `settings.xml`, supports a legacy install-path migration and supplies defaults.
- `clsGlobalVars` is a thin GFF specialization for global-variable files.
- `Utils` contains cross-editor helpers, including finding controls and opening scripts from override/BIFF sources.

## Heuristics

Global settings and `frmMain` static state are observable across nearly every subsystem. Avoid adding more globals; pass game/version/path context explicitly in new code. Settings must tolerate missing/older XML elements, invalid paths and unwritable application directories. Exception handling must avoid recursive dialogs and keep non-UI exception display on an STA thread.

Test first run, legacy settings migration, corrupt XML, both game paths, save failure, command-line opening and an exception from both UI and background threads.
