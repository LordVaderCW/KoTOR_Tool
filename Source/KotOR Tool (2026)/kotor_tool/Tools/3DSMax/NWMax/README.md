# NWMax source snapshot

Copied on 2026-11-25 from `C:\Program Files\Autodesk\3ds Max 2021\scripts\NWmax`, the local installation used by NWListen. This is an installed, locally adapted Max 2021 snapshot, not an unmodified upstream release. Original author credits and legal notices remain in `nwmax.ms` and the supporting files. See the existing readme, release notes and Max 2021 compatibility notes for history.

`nwmax.ms` is the entry point; `nw_ie_inc` contains the importer/exporter and supporting scripts. Other folders retain the installed documentation, utilities and model templates. Backup files, scratch output and session-specific diagnostics under `tests` were excluded. Historical patch files and manifests are retained as references; their presence does not mean those patches should be applied again.

`source-files.json` records the relative path and SHA-256 of each file at capture. All copied files, including helper executables and model templates, were copied unchanged. Do not execute third-party helpers merely to inspect them. The preserved importer is `nw_ie_inc/aurora_fn_import.ms`; no importer behavior was changed when adding this folder to the solution.

Project entries are non-compiled source/support items. Builds copy them to the application's `Tools\3DSMax\NWMax` folder when newer, preserving all subfolders, and do not overwrite the live Max installation. NWListen's installer installs only NWListen; deployment of edited NWMax scripts is a separate action.
