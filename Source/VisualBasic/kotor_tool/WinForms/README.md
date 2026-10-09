# WinForms Application

Fifty-eight forms implement the main resource browser, generic/archive/text/image/dialog/SSF editors, all UT editors, module/project workflows and support dialogs.

`frmMain` owns game indexes, resource maps/tree/extraction/dispatch, settings, themes and plugin menus. `frmImageViewer` uses `ImageSystem`; model extraction uses `frmMdlOpsSwitches`, MDLOps and sidecar MDX/textures; NCS uses DeNCS. New formats generally require symmetric ID mapping, grouping, extraction naming, dispatch and search/filter support.

Keep behavior in code-behind and layout/resources in designer triplets. All constructors must initialize controls before use; avoid duplicate event subscriptions; dispose streams/images/FMOD/processes on success/cancel/failure/close. Test standalone and archive entry paths, both games, save/cancel, theme/DPI and reopen saved data.
