# Plugins

<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Plugins/README.md
The runtime plugin root contains:

- `AvailablePlugins.xml`: downloadable catalog metadata.
- `InstalledPlugins.xml`: local enabled/installed records.
- one directory per plugin, currently [DeNCS](DeNCS/README.md).

At startup/use, `clsPluginManager` joins an installed record to its `plugin.xml`, validates required files, registers resource/action handles and loads `command.ini` only when executing.

Catalogs and manifests are untrusted input. Plugin IDs/directories must be unique and path-safe; installed version is not proof of complete files. Plugin packages should extract into staging, reject traversal/links/rooted entries, validate, then replace the exact plugin directory. Keep catalog, installed record, manifest and payload versions synchronized.
=======
`AvailablePlugins.xml` catalogs DeNCS and MDLOps; `InstalledPlugins.xml` currently records both. Runtime loading joins records to each plugin directory. IDs/directories must be unique/path-safe; versions do not prove payload completeness. Stage, validate and narrowly replace installations.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Plugins/README.md
