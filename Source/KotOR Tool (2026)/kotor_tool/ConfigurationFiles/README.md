<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/ConfigurationFiles/README.md
# Configuration File Templates

This directory contains a legacy `app.config` variant with diagnostic logging and CLR 2-era binding redirects. It is included in the project as `None`; the active build configuration is the `app.config` at the application root.

Do not assume these two files are merged. Runtime changes belong in the root `app.config` unless the project explicitly introduces a generation/copy step. If this file is retained as a historical template, keep its purpose labeled and test the emitted `kotor_tool.exe.config` after any configuration change.
=======
# Configuration Templates

This legacy `app.config` variant is included as `None`; the application-root `app.config` drives emitted runtime configuration. Do not assume they merge. Test `kotor_tool.exe.config` after changes or label this file explicitly as historical/template data.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/ConfigurationFiles/README.md
