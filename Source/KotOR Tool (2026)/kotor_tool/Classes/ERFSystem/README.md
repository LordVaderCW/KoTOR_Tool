# ERF Archive System

`clsERF` reads and writes ERF-family archives, including ERF/MOD/SAV-style file types. `ERFKeyEntry` stores ResRef/type/index/offset/length information and `ERFLocalizedString` stores archive description strings.

## Operating heuristics

- The writer emits `<TYPE> V1.0`, a 160-byte header, localized-string data, key records, resource records and concatenated payloads.
- ResRefs are fixed-width archive identifiers and resource types come from `frmMain`'s central mapping.
- The reader retains the input `FileStream` and seeks to resource offsets on demand.
- Lookup by ResRef/type is case-insensitive in recovered code; duplicate names of different types remain distinct.

## Change and verification

Validate counts and all table/payload ranges before reading. Reject input files whose ResRefs/types cannot be encoded without ambiguity. Test zero/multiple localized descriptions, duplicate ResRefs across types, empty files, long names, large payloads and read-after-write extraction hashes. Do not overwrite source modules/saves during tests.
