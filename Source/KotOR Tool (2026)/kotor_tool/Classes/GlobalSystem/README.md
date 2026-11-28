# Global System

`KT_Launch` owns STA startup/exceptions/themes; `Options` and `UserSettings` persist application-relative `settings.xml`; `clsGlobalVars` specializes GFF. Avoid adding globals, pass game/path context explicitly, and test first run, legacy/corrupt settings, save failure, command-line opening and background exceptions.

The former `bModelExtraction_CleanWorkingDirectoryBeforeExport` option has been removed along with directory cleanup. XmlSerializer ignores that obsolete element when loading older settings; other recognized options still load and save normally.
`KT_Launch` sets the explicit LordVaderCW.KotorTool.Treya shell identity before creating UI. Startup always follows the normal editor path; there is no separate MDL Viewer process mode. The shell identity does not guarantee Task Manager grouping.
