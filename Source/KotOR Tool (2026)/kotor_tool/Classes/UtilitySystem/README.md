# Utility System

<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Classes/UtilitySystem/README.md
This directory contains module-editor settings/data and operational helpers.

- `ModuleEditorProjectOptions` and `ModuleEditorProjectSettings` XML-serialize filters, map/display options and scroll state to `project settings.xml`.
- `ModuleFileEntry` groups module package types and file lists.
- `utilWindowRelativePositioner` places dialogs relative to an owner.
- `utilFileValidator` computes/validates keyed hashes for the legacy updater.

Settings paths are user/project data: handle missing/corrupt XML and save through a temporary file before replace in future hardening. Window positioning must clamp to visible working areas and mixed-DPI screens. The validator is legacy integrity checking, not a modern public-key signature; do not use embedded/shared symmetric keys as release authenticity.
=======
Treya places `Utils`, `utilFileValidator` and `utilWindowRelativePositioner` here. They open scripts/find controls, validate legacy updater hashes and position dialogs. Clamp windows to visible/DPI-aware areas; do not treat symmetric hashes as release signatures; keep cross-editor helpers from accumulating new global coupling.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Classes/UtilitySystem/README.md
