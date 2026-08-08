# KoTOR Project System

`clsProject` is an XML-serializable model for project name, Debug/Release paths, override files, module groups, lips modules and stream-wave files/modules. `clsProjectManager` loads and saves it with `XmlSerializer`.

Collections use legacy `ArrayList`/nested array shapes and expose many mutation helpers. Preserve XML member names and ordering expectations for existing project files. Normalize module/file identity consistently before remove/lookups and avoid exposing live mutable collections in new APIs.

Saving uses `FileMode.Create`, so a failure can truncate an existing file. A future hardening change should serialize to a sibling temporary file, validate, then atomically replace with backup. Test old/new/empty projects, duplicate modules, missing files, corrupt XML and save interruption.
