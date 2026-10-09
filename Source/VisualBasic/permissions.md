# Permission and Trust Boundaries

This describes access; it grants nothing.

- Game directories: read, except explicit user-selected outputs.
- Application directory: read/write for settings, working, themes and plugins.
- Network: plugin downloads and legacy updater only.
- Processes: GFFEditor, NSS compiler, configured plugin commands, 7-Zip and MDLOps.

Canonicalize plugin staging paths beneath the plugin directory before cleanup. Reject archive traversal, validate expected files and never execute a download solely because catalog metadata names it. Avoid elevation and never clean repository, application or game roots.
