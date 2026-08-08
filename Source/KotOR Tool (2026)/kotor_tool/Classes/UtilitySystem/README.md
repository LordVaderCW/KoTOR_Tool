# Utility System

This directory contains module-editor settings/data and operational helpers.

- `ModuleEditorProjectOptions` and `ModuleEditorProjectSettings` XML-serialize filters, map/display options and scroll state to `project settings.xml`.
- `ModuleFileEntry` groups module package types and file lists.
- `utilWindowRelativePositioner` places dialogs relative to an owner.
- `utilFileValidator` computes/validates keyed hashes for the legacy updater.

Settings paths are user/project data: handle missing/corrupt XML and save through a temporary file before replace in future hardening. Window positioning must clamp to visible working areas and mixed-DPI screens. The validator is legacy integrity checking, not a modern public-key signature; do not use embedded/shared symmetric keys as release authenticity.
