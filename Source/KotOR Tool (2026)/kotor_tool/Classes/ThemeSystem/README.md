# Theme System

`ThemeManager` loads/saves named INI themes, remembers the active theme in `Themes/ActiveTheme.txt`, searches deployed and source-tree theme directories, and falls back to `KotorTheme.CreateDefault`. `KotorTheme` is the typed color/font model. `KotorThemeApplier` recursively applies a theme to forms, grids and custom controls and installs global hooks.

## Heuristics

- Missing/invalid keys fall back to defaults, enabling additive theme-schema evolution.
- Theme names are sanitized before path construction. Keep theme files within the themes directory.
- Fonts/colors created during application must have clear ownership; do not dispose an object still assigned to a live control.
- Global hooks can apply during form creation, so avoid reentrant layout/event loops.
- Source-directory fallback is development convenience; packaged behavior should be verified from output alone.

Test every bundled theme, missing/malformed values, out-of-range font sizes/colors, runtime switching, newly opened and already open forms, custom controls and high-DPI layout.
