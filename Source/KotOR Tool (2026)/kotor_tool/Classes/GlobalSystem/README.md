# Global System

`KT_Launch` owns STA startup/exceptions/themes; `Options` and `UserSettings` persist application-relative `settings.xml`; `clsGlobalVars` specializes GFF. Avoid adding globals, pass game/path context explicitly, and test first run, legacy/corrupt settings, save failure, command-line opening and background exceptions.

The former `bModelExtraction_CleanWorkingDirectoryBeforeExport` option has been removed along with directory cleanup. XmlSerializer ignores that obsolete element when loading older settings; other recognized options still load and save normally.
