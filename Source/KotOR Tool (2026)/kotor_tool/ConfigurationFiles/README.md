# Configuration File Templates

This directory contains a legacy `app.config` variant with diagnostic logging and CLR 2-era binding redirects. It is included in the project as `None`; the active build configuration is the `app.config` at the application root.

Do not assume these two files are merged. Runtime changes belong in the root `app.config` unless the project explicitly introduces a generation/copy step. If this file is retained as a historical template, keep its purpose labeled and test the emitted `kotor_tool.exe.config` after any configuration change.
