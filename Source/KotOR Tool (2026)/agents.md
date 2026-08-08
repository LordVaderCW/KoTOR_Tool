# Automated Contributor Guide

Use [project.md](project.md) as the documentation entry point and read the guide for every directory you modify.

## Working rules

- Preserve the current restoration goal and source attribution.
- Inspect `git status` before editing. This checkout may be part of a migration with unrelated deleted/untracked paths; do not restore, delete or stage them implicitly.
- Keep changes scoped. Do not reformat recovered VB files while making a behavioral fix.
- Treat `.Designer.vb`, `.resx`, `.vbproj`, manifests, theme files and plugin command files as coupled artifacts.
- Do not modify checked-in DLL/EXE/BFD/image assets unless replacement is explicitly requested and provenance is recorded.
- Never use live game installs as disposable test output. Copy fixtures into a temporary/work directory before mutation.
- Do not infer that plugin manifests grant permission to download or execute tools. External downloads/processes require the user's requested scope and normal approval controls.

## Analysis expectations

- Cite concrete source files and distinguish verified behavior from inference.
- Trace both KoTOR I and II branches.
- For binary formats, state read/write direction, ownership of streams, offset/size validation and unknown-field preservation.
- For UI work, trace constructor/load/close events and designer/resource coupling.
- For external tools, trace executable resolution, arguments, working directory, timeout, output and failure reporting.

## Verification expectations

- Use Visual Studio full-framework MSBuild, not `dotnet build`, for acceptance.
- Build x86 and report whether warnings are pre-existing or new.
- Run focused parser round trips or UI smoke tests proportional to the change.
- Check Markdown links when changing documentation.
- Update the affected directory guide and root map when architecture, dependencies, permissions or version behavior changes.
