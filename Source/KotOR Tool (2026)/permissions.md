# Permission and Trust Boundaries

This document describes access the application needs or exercises. It does not grant OS, repository or network permission.

## Runtime filesystem access

| Location | Typical access | Reason |
| --- | --- | --- |
| KoTOR install directories | Read; user-selected writes only | KEY/BIFF/TLK/archive browsing, extraction sources, optional override/mod output |
| Application directory | Read and write | `settings.xml`, `working`, theme selection/edits, plugin catalogs/installations |
| User-selected export/project paths | Read and write | Exported resources, ERF/project/module outputs |
| Temporary plugin workspace | Read, write and delete specific generated files | NCS input/output and plugin installation staging |

Avoid elevated execution. Prefer a user-writable portable install directory or migrate mutable state to a per-user application-data directory in a future compatibility release.

## Process execution

The application can start `GFFEditor.exe`, `nwnnsscomp.exe`, user-configured external text/dialog/image tools and plugin-defined executables. Treat executable paths and arguments as a trust boundary:

- resolve paths under the intended application/plugin directory unless the user selected an external tool;
- quote arguments and keep input/output paths separate from command text;
- retain plugin timeouts and hidden-window settings;
- show the resolved executable, arguments and error output on failure;
- never execute a newly downloaded payload before validation and explicit workflow intent.

## Network access

Plugin download/install and legacy updater code can access remote URLs. Network access is not required for ordinary local browsing/editing. Downloaded archives are untrusted until source, integrity, contents and destination paths are validated.

## Sensitive or destructive operations

- Archive extraction is read-only with respect to game files; keep it that way by default.
- Overwriting an existing output, cleaning `working`, moving project files, or installing/removing plugins must use exact validated paths and user-visible confirmation where data may be lost.
- Never recursively clean the application root, repository root or a game-install root.
- Settings contain local paths and user state; do not publish them as portable defaults without review.

## Contributor permissions

Documentation and code changes inside this solution are normal scoped writes. Running the application, external helpers, installers, downloaders, or tests against a real game directory is a separate side effect and should only occur when it is part of the requested task and the target paths are verified.
