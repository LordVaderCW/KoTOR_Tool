# ktlib

Standalone C# function library for future KoTOR consumers. Target: .NET Framework 4.6.2, managed AnyCPU. The main application is unchanged and does not reference or call this library.

Follow [transposition instruction.md](../transposition%20instruction.md). The [source inventory](migration-inventory.md) maps existing code and candidates; it is static triage, not a completed method-level audit. Read the VB application as reference material only. Do not edit it or wire this library into it without an explicit later instruction.

## First standalone implementation

`ktlib.Formats.Ssf.SoundSetCodec.Read(Stream)` returns 40 signed TLK references read from absolute offset 12. `Write(Stream, int[])` writes the canonical legacy SSF header and first 40 references at the current stream position, without truncating the stream. Both leave caller streams open, including on read failure. Invalid arguments fail before writing. No UI, settings, game files or TLK provider are required.

This codec reproduces the existing binary operations: reading ignores header contents and trailing bytes. It does not promise lossless preservation of those ignored bytes. The original VB `clsSSF` remains intact, including its binary implementation, settings, TLK lookups and public interface. No application source, designer, resource or project-reference changes are part of this stage.

## Verification

Run `tests/Run-SsfTests.ps1` from PowerShell. It builds only the library and compiles a temporary test host containing the unchanged VB `clsSSF` plus isolated settings/TLK substitutes, then runs an x86 .NET Framework executable. The test host is separate from the application and never loads game installations or real settings.

The suite checks independent expected bytes against both implementations, all 40 slots, signed limits, hidden references, stream ownership, truncation, legacy header/trailing tolerance, and VB constructors under two simulated game indices. There are 4,978 passing checks. This establishes binary compatibility for synthetic fixtures; it does not establish real-game or editor integration coverage.

The optional `-LegacySource` argument permits testing a separate saved original VB source. Test binaries are retained under a uniquely named temporary directory. Future library classes must retain the same application-independent boundary.

## RIM read/extract — iteration 3.1

`ktlib.Formats.Rim.RimArchive` reads an in-memory archive, exposes ordered immutable `RimEntry` records, extracts payload copies and retains the complete original bytes. It reproduces the VB field interpretation, including the byte-18 legacy ID and checked numeric limits, while adding explicit bounds checks and owned input storage. Display extensions and game/UI state remain outside the library. See [the RIM contract](Formats/Rim/README.md) for details and deliberate differences.

Run `tests/Run-RimTests.ps1` for 2,115 assertions comparing against the two unchanged VB sources, plus malformed-input and ownership tests. The original VB reference host emits its existing BC42025 warning; the library adds none. The SSF suite still passes. Full-framework Debug/x86 solution rebuild passes with 0 errors and the existing 187 warnings. All 370 non-generated application/solution files were verified unchanged. Real-game fixture coverage remains pending; no integration is claimed.

## BIFF + KEY — combined iteration 3.2

[BIFF](Formats/Biff/README.md) provides a stream-based variable-resource reader, immutable metadata and path helpers. [KEY](Formats/Key/README.md) supplies file/resource records, name/type lookup, packed-ID resolution, display maps with an explicit resolver and the original K1/K2 declared-size heuristics. Main-application code is unchanged and does not consume these classes.

Run `tests/Run-BiffTests.ps1` (3,406 checks) and `tests/Run-KeyTests.ps1` (488 checks). The combined path resolves a KEY resource and extracts its bytes from BIFF, compared with unchanged VB reference code. Both games' legacy layout heuristics are tested synthetically; these are not installation-integrity or real-game integration checks. Earlier SSF/RIM suites pass; full-framework Debug/x86 rebuild has 0 errors and the existing 187 warnings. All 370 application/solution files remain unchanged.

KEY metadata filenames are never opened automatically. Callers must select/constrain the BIFF stream or path. Unknown IDs/types and original KEY bytes are retained; compatibility limits and deliberate safety differences are documented in each format guide.

## ERF-family read/write — iteration 3.3

[ERF](Formats/Erf/README.md) adds archive snapshots/extraction, immutable entry and write-input records, localized-string records, and deterministic new-archive creation for ERF/MOD/SAV/HAK. Original archive bytes can be copied exactly, including unknown data. No application source, reference or UI changed.

The port explicitly corrects the original writer's 30-byte-versus-24-byte key mismatch, ignored resource-table offset, dropped language IDs, missing-name fallback and preview boundary overrun. The format guide distinguishes corrections from preserved behavior; no byte parity is claimed for malformed legacy entry output.

`tests/Run-ErfTests.ps1` passes 2,805 assertions, including C# write/read and unchanged-VB readback. All five format suites pass 13,792 checks in total. Debug/x86 full-framework solution build: 0 errors, unchanged 187 warnings. All 370 application/solution files remain unchanged. Tests use synthetic data; actual-game/editor coverage remains a future integration requirement.

## 2DA + base-item helpers — iteration 3.4

[2DA](Formats/TwoDa/README.md) adds immutable tables, bounded binary reading, deterministic V2.b writing, complete row/cell lookup and callback-based base-item projections. Original bytes can be copied intact; canonical serialization is a separate operation. Row-indexing and writer-size defects are corrected explicitly. TLK files, game settings and editor UI are not loaded.

The helpers use the framework Microsoft.VisualBasic runtime for exact existing numeric recognition/conversion behavior, while all new implementation code is C#. `tests/Run-TwoDaTests.ps1` passes 5,419 assertions. All six suites total 19,211 passing checks; final Debug/x86 and Release/x86 solution rebuilds pass with 0 errors and the same 187 warnings. All 370 application/solution files remain unchanged. Fixtures are synthetic; real-game/UI coverage is not claimed.
