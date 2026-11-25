# 3ds Max tools

These folders appear beneath `kotor_tool > Tools > 3DSMax` in Visual Studio Solution Explorer. Files are explicitly included as `None` items: scripts and supporting assets can be opened and edited without compiling them into KoTOR Tool. Builds copy the tools into `Tools\3DSMax\NWListen` and `Tools\3DSMax\NWMax` beside the application executable, preserving the directory structure. `CopyToOutputDirectory=PreserveNewest` refreshes changed files on subsequent builds. Tests and `.gitignore` remain source-only; generated diagnostics and transfer jobs are not project items or build payloads. Building does not install or execute scripts in Max.

- [NWListen](NWListen/README.md): maintained KoTOR Tool bridge, startup loader, installer and isolated tests. Run its `Install.ps1` to deploy the listener to Max 2021 after editing.
- [NWMax](NWMax/README.md): snapshot of the installed NWMax importer/exporter and supporting runtime assets.

NWListen's build payload is exactly `NWlisten.ms` and `NWlistenStartup.ms`. Its installer, documentation and `.gitignore` stay in the source project. Test scripts and fixtures remain on disk for standalone validation but are excluded from the Visual Studio project and build output. NWMax's scripts and supporting runtime files retain their copy-on-build metadata.

Add new files through Visual Studio or add explicit `None` entries to `kotor_tool.vbproj`; set Copy to Output Directory to Copy if newer for distributable tool files. Keep generated logs, copied game fixtures, scene recovery files and transfer queues out of project items. Send to Max continues to write runtime assets to `working\NWlisten\jobs` beside the KoTOR Tool executable.
