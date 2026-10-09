# Theme System

`ThemeManager` loads/saves INI themes and `ActiveTheme.txt`; `KotorTheme` is the typed model and `KotorThemeApplier` recursively styles open/new forms. Missing keys fall back to defaults. Sanitize names, manage GDI object ownership, avoid reentrant hooks and test every theme at high DPI.
