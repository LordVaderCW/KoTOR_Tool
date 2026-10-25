<<<<<<< HEAD:Source/KotOR Tool (2026)/kotor_tool/Themes/README.md
# Theme Definitions

The seven INI files are user-selectable themes loaded by `ThemeManager`: DarkSaber, Jedi Consular/Knight/Sentinal, and Sith Assasain/Lord/Marauder. Existing filename misspellings are compatibility names and should not be silently corrected.

Each file declares theme metadata plus color groups for general UI, error dialogs, grids, byte viewer, picture box, progress bar and tabs, followed by font definitions. Missing keys fall back to `KotorTheme.CreateDefault`.

Keep RGB/RGBA values in range, font sizes within manager limits and section/key names aligned with `ThemeManager`. Additive keys are backward-compatible when defaults exist. Test save/reload, runtime switching, packaged output discovery and every custom control. `ActiveTheme.txt` is generated user state and should not be committed as a fixed choice.
=======
# Themes

Eight INI themes include DarkSaber, Jedi/Sith variants and Treya's WinUI3 theme. Existing filename misspellings are compatibility names. Keep sections/keys aligned with `ThemeManager`, values/font sizes in range, fallback defaults additive, and test reload/switching/custom controls. `ActiveTheme.txt` is generated state.
>>>>>>> treya/v.1.0.3.4:Source/VisualBasic/kotor_tool/Themes/README.md
