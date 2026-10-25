# Global System

`KT_Launch` owns STA startup/exceptions/themes; `Options` and `UserSettings` persist application-relative `settings.xml`; `clsGlobalVars` specializes GFF. Avoid adding globals, pass game/path context explicitly, and test first run, legacy/corrupt settings, save failure, command-line opening and background exceptions.
