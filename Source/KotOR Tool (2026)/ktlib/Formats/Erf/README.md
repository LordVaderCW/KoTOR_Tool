# ERF-family archives — iteration 3.3

Standalone counterparts of `clsERF`, `ERFKeyEntry` and `ERFLocalizedString`. Reader/writer callers include the resource browser, ERF manager, project packager and module exporter. Display extensions, source-file selection, output paths and game context stay outside the library. Application files remain unchanged.

## Contracts

`ErfArchive(byte[])` owns an immutable snapshot, exposes ordered `ErfEntry` metadata and extracts fresh payload arrays by index or name/type. Names decode as ASCII through the first NUL in 16 bytes. Matching lowercases with current culture, then compares ordinally. Duplicate names/types remain ordered; first matching entry wins. Missing lookup returns -1; name-based extraction throws KeyNotFoundException. Payload previews return up to 16 bytes within the resource boundary.

Header metadata includes file type/version, entry/localization counts and offsets, build year/day and unsigned description-reference bits exposed as long. Resource IDs/offsets/lengths retain the VB positive-Int32 limit and types the positive-Short limit (0–32767); unknown values inside these ranges remain valid. Reserved entry words are exposed. Header signature/version are not validated. Bounds-valid overlapping payloads are accepted; empty resources may point to EOF.

`CopyArchiveBytes()` returns the exact original bytes, preserving reserved headers, unknown fields, localized data, gaps and trailing bytes. `CopyLocalizedData()` exposes the raw declared description block. The reader does not reinterpret localized encodings; the old reader did not decode descriptions either. There is no hidden rebuild of an existing archive.

`ErfWriter.Create(fileType, descriptionStringReference, buildDate, descriptions, resources)` creates a new archive as bytes. The caller supplies explicit resource names, numeric types and payloads rather than UI extension lookups or input filenames. `ErfResource` snapshots payload bytes, accepts names up to 16 characters and types 0–32767. `ErfLocalizedString` retains the supplied language ID/text. The writer uses ASCII replacement like VB, zero-based day-of-year, a 160-byte header, sequential IDs, 24-byte keys, 8-byte resource records and payloads in input order. Build time is explicit for reproducible tests. Description references accept 0–UInt32.MaxValue through long.

Localization creation follows the source writer's layout: language ID, encoded byte count, ASCII text, with an extra zero byte for ERF/HAK. Declared size excludes that optional terminator. C# uses the actual ASCII encoded byte count and pads names to 16 bytes even when replacement encoding changes character-to-byte length; the original writer used character counts. File type is trimmed/uppercased once before header and localization padding decisions, avoiding the original inconsistent handling of surrounding whitespace. This is source-derived behavior, not a claim about other tools' localization conventions. New archive creation and exact original-byte copying are separate operations; creation does not preserve metadata it was not given.

## Deliberate corrections, independently tested

1. The active VB writer emits 16 name bytes + Int32 ID + Int16 type + **two Int32 zeros**, totaling 30 bytes per entry, but declares a 24-byte stride. C# emits one Int16 reserved word, totaling 24 bytes. Copying the faulty output would break extraction, so whole-byte writer parity is not claimed for archives containing entries. Corrected output is read back by both readers on their common valid layout.
2. The VB reader records the resource-table offset but reads resource records immediately after key data. C# honors the declared offset and reads 8 bytes per entry, not VB's oversized 16-byte read. Separate-table fixtures distinguish the behavior. For adjacent-table archives, metadata and extracted bytes are compared directly with VB.
3. The VB localized-string constructor assigns its field to itself, losing nonzero language IDs. C# retains the argument. Tests demonstrate both behaviors.
4. VB missing-name lookup defaults to index zero; C# returns -1 and rejects missing-name extraction. VB TPC preview can read across a resource boundary; C# caps previews at the resource length. Tests distinguish these outcomes.

Additional boundary changes: a complete 160-byte header is required, eager count/table/payload checks and immutable input/metadata. Invalid ranges fail with InvalidDataException; numeric fields above the legacy positive ranges still throw OverflowException. New-write inputs are validated before allocating output, including the 16-character name limit and checked total length. No filenames from metadata are opened; these APIs acquire no file handles or native resources.

## Verification

`../../tests/Run-ErfTests.ps1` compiles the original VB files with a numeric-extension stub. Synthetic ERF/MOD/SAV/HAK fixtures compare metadata, extraction, lookups and valid output round trips; independent byte assertions cover writer offsets, header/date/description fields and reserved bytes. Tests expose legacy defects rather than treating their outputs as correct format oracles. Localization language IDs, hidden bytes, duplicate entries, malformed input, numeric limits and mutation isolation are covered.

Real K1/K2 archive fixtures and UI behavior remain untested. No application integration is claimed. No source game files are used or modified.

Recorded validation: 2,805 ERF-family checks pass. Prior SSF/RIM/BIFF/KEY suites also pass (10,987 checks). Full-framework Debug/x86 solution rebuild: 0 errors, unchanged 187-warning baseline. The reference VB test host emits existing BC42104 for its uninitialized enumerator; the C# library adds no warnings. All 370 application/solution files were verified unchanged.
