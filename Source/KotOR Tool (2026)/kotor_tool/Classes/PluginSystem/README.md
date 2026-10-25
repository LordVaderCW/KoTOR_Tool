# Plugin System

<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/PluginSystem/README.md
The plugin layer supports catalog download/install and manifest-driven external tools.

- `clsPluginManager` loads `AvailablePlugins.xml` and `InstalledPlugins.xml`, parses each `plugin.xml`, normalizes handles, validates required files, reads `command.ini`, expands placeholders and executes a process with captured output/timeout.
- Definition, handle, command and result classes are mutable data contracts used by the manager and UI.
- `clsDownloadPlugin` and `clsInstallPlugin` download/extract/install packages and report progress; the first supported profile is DeNCS.

## Trust boundary

A plugin manifest is data, not authority. Constrain resolved files to the intended plugin directory, reject traversal/rooted paths where not explicitly allowed, validate archive entries before extraction, and show the user what will execute. Placeholder expansion must quote values safely. Timeout handling must terminate only the launched process and return complete diagnostics.

## Verification

Test enabled/disabled and duplicate handles, missing/optional files, malformed XML/INI, traversal attempts, spaces/quotes in paths, stdout/stderr capture, timeout, expected-output absence and success-exit overrides. Installation tests must use a temporary plugin root.
=======
The manager joins catalogs, installed records, manifests, handles and command INIs; it expands placeholders and executes captured/timed processes. Download/install classes support packaged plugins. Treat all metadata/packages as untrusted: constrain paths, quote values, validate required/output files and test traversal, timeouts and malformed metadata.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/PluginSystem/README.md
