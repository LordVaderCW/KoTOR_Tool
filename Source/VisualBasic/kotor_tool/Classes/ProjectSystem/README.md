# Project System

`clsProject` stores Debug/Release paths, overrides, modules, lips and stream-wave groups; `clsProjectManager` XML-serializes it. Preserve member names and legacy collection shapes. Current `FileMode.Create` saves can truncate on failure, so future hardening should write/validate/replace with backup.
